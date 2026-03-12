using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Evolucao
{
    class classeNfe40
    {

        private static readonly XNamespace Ns = "http://www.portalfiscal.inf.br/nfe";
        private static readonly CultureInfo Inv = CultureInfo.InvariantCulture;
        public string cod_nf_sistema;
        NFe_Util_2G.Util util2 = new NFe_Util_2G.Util();
        FbConnection fbConnection1 = new FbConnection(@"User=SYSDBA;Password=masterkey;Database=C:\evolucao\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0");
        //informacoes nf
        string forma_pgto;
        double valor_total_pagamento;
        public double valorTotalNFCe;

        WebServiceEvolucao.WebService1 webEvo = new WebServiceEvolucao.WebService1();


        public string acertos_diversos(string xml)
        {
            buscar_informacoes_nf();
            xml = retirarCaracteresEspeciais(xml);
           
            xml = infNfe_versao(xml);
            xml = ide_indPag(xml);
            xml = ICMSTot_camposDiversos(xml);
            xml = infNfe(xml);
           // xml = xSt60(xml);
            xml = xSt60Novo(xml);
           
           // xml = xSt500Novo(xml);
            xml = acertarLugarIe(xml);
            xml = xSt500(xml);
            xml = xCst51(xml);
            xml = xUtf(xml);
            xml = fat(xml);
            xml = pag(xml);
            xml = infAdProd(xml);
            xml = infcomb(xml);
            xml = cEAN(xml);
            xml = xRt(xml);
            
            return xml;
        }

        

        public DataTable CarregarItensIbsCbs(string cod_nf_sistema)
        {
            DataTable dt = new DataTable();

            string sql = @"
        SELECT 
            (SELECT COUNT(*)
               FROM itens_nota inf2
               WHERE inf2.nf_item = inf.nf_item
                 AND inf2.cod_itens_nota <= inf.cod_itens_nota
            ) AS NITEM,
            inf.cod_itens_nota,
            inf.CST_IBSCBS_ITEM,
            inf.CCLASSTRIB_ITEM,
            inf.BC_IBSCBS_ITEM,
            inf.ALIQ_IBS_ITEM,
            inf.ALIQ_CBS_ITEM,
            inf.VALOR_IBS_ITEM,
            inf.VALOR_CBS_ITEM
        FROM itens_nota inf
        inner join NOTA_FISCAL nf on inf.NF_ITEM = nf.N_NF
        WHERE nf.COD_SISTEMA_NF = @NF
        ORDER BY inf.cod_itens_nota
    ";

            using (FbCommand cmd = new FbCommand(sql, fbConnection1))
            {
                cmd.Parameters.AddWithValue("@NF", cod_nf_sistema);

                using (FbDataAdapter da = new FbDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }

            return dt;
        }

        private string xRt(string xml)
        {
            // 1) DataTable com NITEM, BC_IBSCBS_ITEM, VALOR_IBS_ITEM, VALOR_CBS_ITEM, etc.
            DataTable dt = CarregarItensIbsCbs(cod_nf_sistema);

            // 2) Seu método existente:
            string GerarBlocoIbscbsXml(int nItem, string nNF)
            {
                string retorno = "";

                foreach (DataRow dr in dt.Select("NITEM = " + nItem))
                {
                    try
                    {
                        
                        retorno = util2.IBSCBSv130(
                            dr["CST_IBSCBS_ITEM"].ToString(),
                            dr["CCLASSTRIB_ITEM"].ToString(),
                            "",
                            util2.gIBSCBS(
                                Convert.ToDouble(dr["BC_IBSCBS_ITEM"].ToString()),
                                util2.gIBSUF(
                                    Convert.ToDouble(dr["ALIQ_IBS_ITEM"].ToString()),
                                    0, 0, 0, 0, 0,
                                    Convert.ToDouble(dr["VALOR_IBS_ITEM"].ToString())
                                ),
                                util2.gIBSMun(0, 0, 0, 0, 0, 0, 0),
                                Convert.ToDouble(dr["VALOR_IBS_ITEM"].ToString()),
                                util2.gCBS(
                                    Convert.ToDouble(dr["ALIQ_CBS_ITEM"].ToString()),
                                    0, 0, 0, 0, 0,
                                    Convert.ToDouble(dr["VALOR_CBS_ITEM"].ToString())
                                ),
                                "", "", "", ""
                            ),
                            "",
                            ""
                        );
                    }
                    catch { }
                }

                return retorno;
            }

            // 3) Aplicar no XML
            string xmlOriginal = xml;

            string xmlNovo = AplicarIBSCBSporNItem(
                xmlOriginal,
                dt,
                GerarBlocoIbscbsXml);

            // Se quiser gravar em disco pra testar:
            // File.WriteAllText(@"C:\xml\NFE588_IBSCBS.xml", xmlNovo);

            return xmlNovo;
        }

        private string AplicarIBSCBSporNItem(
        string xmlOriginal,
        DataTable dt,
        Func<int, string, string> gerarBlocoIbscbsXml)
        {
            var doc = XDocument.Parse(xmlOriginal, LoadOptions.PreserveWhitespace);

            var infNFe = doc.Descendants(Ns + "infNFe").FirstOrDefault()
                       ?? throw new Exception("infNFe não encontrado.");

            var ide = infNFe.Element(Ns + "ide")
                   ?? throw new Exception("<ide> não encontrado.");
            var nNFEl = ide.Element(Ns + "nNF")
                     ?? throw new Exception("<nNF> não encontrado.");
            string nNF = nNFEl.Value;

            decimal somaBC = 0m;
            decimal somaValorIBS = 0m;
            decimal somaValorCBS = 0m;

            // 1) Loop em cada <det nItem="">
            foreach (var det in infNFe.Elements(Ns + "det"))
            {
                var nItemAttr = det.Attribute("nItem");
                if (nItemAttr == null) continue;

                int nItem = int.Parse(nItemAttr.Value);

                // Busca linha correspondente no DataTable (NITEM = nItem)
                DataRow row = dt.AsEnumerable()
                                .FirstOrDefault(r => Convert.ToInt32(r["NITEM"]) == nItem);

                if (row == null)
                    continue;

                var imposto = det.Element(Ns + "imposto");
                if (imposto == null) continue;

                // Remove IBSCBS existente, se houver
                var ibsExist = imposto.Element(Ns + "IBSCBS");
                ibsExist?.Remove();

                // Chama seu método para gerar o bloco IBSCBS
                string blocoXml = gerarBlocoIbscbsXml(nItem, nNF);
                if (string.IsNullOrWhiteSpace(blocoXml))
                    continue;

                var ibsElement = XElement.Parse(blocoXml);
                AjustarNamespace(ibsElement, Ns);

                // Insere o bloco IBSCBS dentro de <imposto> (no fim)
                imposto.Add(ibsElement);

                // Acumula totais
                somaBC += Convert.ToDecimal(row["BC_IBSCBS_ITEM"], Inv);
                somaValorIBS += Convert.ToDecimal(row["VALOR_IBS_ITEM"], Inv);
                somaValorCBS += Convert.ToDecimal(row["VALOR_CBS_ITEM"], Inv);
            }

            // 2) Totais: IBSCBSTot + vNFTot
            var total = infNFe.Element(Ns + "total")
                       ?? throw new Exception("<total> não encontrado.");
            var icmsTot = total.Element(Ns + "ICMSTot")
                         ?? throw new Exception("<ICMSTot> não encontrado.");

            decimal vNF = 0m;
            var vNFEl2 = icmsTot.Element(Ns + "vNF");
            if (vNFEl2 != null)
                decimal.TryParse(vNFEl2.Value, NumberStyles.Any, Inv, out vNF);

            // Remove IBSCBSTot se existir para recriar
            var totExist = total.Element(Ns + "IBSCBSTot");
            totExist?.Remove();
            if (somaBC > 0)
            {
                var novoTot = new XElement(Ns + "IBSCBSTot",
                new XElement(Ns + "vBCIBSCBS", somaBC.ToString("0.00", Inv)),
                new XElement(Ns + "gIBS",
                    new XElement(Ns + "gIBSUF",
                        new XElement(Ns + "vDif", "0.00"),
                        new XElement(Ns + "vDevTrib", "0.00"),
                        new XElement(Ns + "vIBSUF", somaValorIBS.ToString("0.00", Inv))
                    ),
                    new XElement(Ns + "gIBSMun",
                        new XElement(Ns + "vDif", "0.00"),
                        new XElement(Ns + "vDevTrib", "0.00"),
                        new XElement(Ns + "vIBSMun", "0.00")
                    ),
                    new XElement(Ns + "vIBS", somaValorIBS.ToString("0.00", Inv)),
                    new XElement(Ns + "vCredPres", "0.00"),
                    new XElement(Ns + "vCredPresCondSus", "0.00")
                ),
                new XElement(Ns + "gCBS",
                    new XElement(Ns + "vDif", "0.00"),
                    new XElement(Ns + "vDevTrib", "0.00"),
                    new XElement(Ns + "vCBS", somaValorCBS.ToString("0.00", Inv)),
                    new XElement(Ns + "vCredPres", "0.00"),
                    new XElement(Ns + "vCredPresCondSus", "0.00")
                )
            );


                icmsTot.AddAfterSelf(novoTot);


                // vNFTot obrigatório se existir IBSCBSTot
                var vNFTot = total.Element(Ns + "vNFTot");
                if (vNFTot == null)
                {
                    vNFTot = new XElement(Ns + "vNFTot", vNF.ToString("0.00", Inv));
                    total.Add(vNFTot);
                }
                else
                {
                    vNFTot.Value = vNF.ToString("0.00", Inv);
                }
            }
            return doc.ToString(SaveOptions.DisableFormatting);
        }

        private static void AjustarNamespace(XElement el, XNamespace ns)
        {
            el.Name = ns + el.Name.LocalName;
            foreach (var child in el.Elements())
            {
                AjustarNamespace(child, ns);
            }
        }

        private string xStMonofasico(string xml)
        {
            try
            {
                if (xml.Contains("<ICMS60><orig>0</orig><CST>60</CST><vBCSTRet>0.00</vBCSTRet><pST>18.00</pST><vICMSSubstituto>0.00</vICMSSubstituto><vICMSSTRet>0.00</vICMSSTRet></ICMS60>"))
                {
                    xml = xml.Replace("<ICMS60><orig>0</orig><CST>60</CST><vBCSTRet>0.00</vBCSTRet><pST>18.00</pST><vICMSSubstituto>0.00</vICMSSubstituto><vICMSSTRet>0.00</vICMSSTRet></ICMS60>",
                        "<ICMS61><orig>0</orig><CST>61</CST><qBCMonoRet>0.0000</qBCMonoRet><adRemICMSRet>0.0000</adRemICMSRet><vICMSMonoRet>0.00</vICMSMonoRet></ICMS61>");

                }
            }
            catch { }
            return xml;
        }

        private string infcomb(string xml)
        {
            try
            {
                if (xml.Contains("</cProdANP>"))
                {
                    xml = xml.Replace("</cProdANP>", "</cProdANP><descANP>IDEM A DESCRICAO DO ITEM</descANP>");
                    xml = xStMonofasico(xml);
                }
            }
            catch { }
            return xml;
        }

        private string infAdProd(string xml)
        {
            try
            {
                if(xml.Contains("<infAdProd>.</infAdProd><prod>"))
                {
                    xml = xml.Replace("<infAdProd>.</infAdProd><prod>", "<prod>");
                }
                if (!xml.Contains("<infAdProd>"))
                {
                    xml = xml.Replace("</det>", "<infAdProd>.</infAdProd></det>");
                }
            }
            catch { }
            return xml;
        }

        private string acertarLugarIe(string xml)
        {
            try
            {
                //emitente
                int indice_fim = xml.IndexOf("<enderEmit>");
                int indice_inicio = xml.IndexOf("<IE>");
                string ie_crt = xml.Substring(indice_inicio, indice_fim - indice_inicio);
                xml = xml.Remove(indice_inicio, indice_fim - indice_inicio);
                indice_inicio = xml.IndexOf("</emit>");
                xml = xml.Insert(indice_inicio, ie_crt);
            }
            catch { }
            try
            {
                //destinatario
                int indice_fim = xml.IndexOf("<enderDest>");
                int indice_inicio = xml.IndexOf("<indIEDest>"); //a partir do ultimo indice
                string ie_email = xml.Substring(indice_inicio, indice_fim - indice_inicio);
                xml = xml.Remove(indice_inicio, indice_fim - indice_inicio);
                indice_inicio = xml.IndexOf("</dest>");
                xml = xml.Insert(indice_inicio, ie_email);
            }
            catch { }


            return xml;
        }

        private string xUtf(string xml)
        {
            try
            {
                if (!xml.Contains("<?xml version=\"1.0\" encoding=\"UTF-8\"?>"))
                {
                    xml = xml.Replace("<NFe xmlns", "<?xml version=\"1.0\" encoding=\"UTF-8\"?><NFe xmlns");
                }
            }
            catch { }
            return xml;
        }

        private string xSt60Novo(string xml)
        { 
            try
            {
                DataSet ds = new DataSet();
                ds.ReadXml(new StringReader(xml));
                foreach (DataRow dr in ds.Tables["ICMS60"].Rows) //para ver se tem o CST60
                { }
                DataColumn col1 = new DataColumn("vBCSTRet");
                DataColumn col2 = new DataColumn("pST");
                DataColumn col3 = new DataColumn("vICMSSubstituto");
                DataColumn col4 = new DataColumn("vICMSSTRet");
                try
                {
                    ds.Tables["ICMS60"].Columns.Add(col1);
                }
                catch { }
                try
                {
                    ds.Tables["ICMS60"].Columns.Add(col2);
                }
                catch { }
                try
                {
                    ds.Tables["ICMS60"].Columns.Add(col3);
                }
                catch { }
                try
                {
                    ds.Tables["ICMS60"].Columns.Add(col4);
                }
                catch { }
                // DataRow dr;
                ds.Tables["ICMS60"].Columns["orig"].SetOrdinal(0);
                ds.Tables["ICMS60"].Columns["CST"].SetOrdinal(1);
                ds.Tables["ICMS60"].Columns["vBCSTRet"].SetOrdinal(2);
                ds.Tables["ICMS60"].Columns["pST"].SetOrdinal(3);
                ds.Tables["ICMS60"].Columns["vICMSSubstituto"].SetOrdinal(4);
                ds.Tables["ICMS60"].Columns["vICMSSTRet"].SetOrdinal(5);
                ds.Tables["ICMS60"].Columns["ICMS_Id"].SetOrdinal(6);

                foreach (DataRow dr in ds.Tables["ICMS60"].Rows)
                {

                    foreach (DataRow drProd in ds.Tables["Prod"].Select("det_Id = " + dr["ICMS_Id"].ToString()))
                    {
                        double _vlTotalProduto = 0, _vbcstret = 0.00000001, _pst = 18, _vicmssubstituto = 0.00000001, _vicmsstret = 0.00000001;
                        double _vlTotalProdutoEnt = 0, _vbcstretEnt = 0, _pstEnt = 0, _vicmssubstitutoEnt = 0, _vicmsstretEnt = 0;
                        buscar_informacoes_entrada(drProd["cEAN"].ToString(), out _vlTotalProdutoEnt, out _vbcstretEnt,
                            out _pstEnt, out _vicmssubstitutoEnt, out _vicmsstretEnt);

                        _vlTotalProduto = Convert.ToDouble(drProd["vProd"].ToString().Replace(".", ","));
                        if (_vbcstretEnt > 0)
                        {
                            _vbcstret = _vbcstretEnt * _vlTotalProduto / _vlTotalProdutoEnt;
                            _pst = _pstEnt;
                            _vicmssubstituto = _vicmssubstitutoEnt * _vlTotalProduto / _vlTotalProdutoEnt;
                            _vicmsstret = _vicmsstretEnt * _vlTotalProduto / _vlTotalProdutoEnt;
                        }
                        dr["vBCSTRet"] = _vbcstret.ToString("n2").Replace(".", "").Replace(",", ".");
                        dr["pST"] = _pst.ToString("n2").Replace(".", "").Replace(",", ".");
                        dr["vICMSSubstituto"] = _vicmssubstituto.ToString("n2").Replace(".", "").Replace(",", ".");
                        dr["vICMSSTRet"] = _vicmsstret.ToString("n2").Replace(".", "").Replace(",", ".");

                        //dr["vBCSTRet"] = _vbcstret.ToString("n8").Replace(".", "").Replace(",", ".");
                        //dr["pST"] = _pst.ToString("n4").Replace(".", "").Replace(",", ".");
                        //dr["vICMSSubstituto"] = _vicmssubstituto.ToString("n8").Replace(".", "").Replace(",", ".");
                        //dr["vICMSSTRet"] = _vicmsstret.ToString("n8").Replace(".", "").Replace(",", ".");
                        /*
                        try { _vbcstret = dr["vbcstret"].ToString().Replace(".", ","); }
                        catch { }
                        try { _pst = dr["pst"].ToString().Replace(".", ","); }
                        catch { }
                        try { _vicmssubstituto = dr["vicmssubstituto"].ToString().Replace(".", ","); }
                        catch { }
                        try { _vicmsstret = dr["vicmsstret"].ToString().Replace(".", ","); }
                        catch { }
                         * */
            }
        }


                // string novo = util2.icmsEfetNT201805("0", "60", 0.00000001, 18, 0.00000001, 0.000000001, 0, 0, 0, 0, 0, 0, 0, 0, 0);

                xml = ds.GetXml();
                xml = CorrigeDescricao(xml);
            }
            catch { }
            return xml;
        }

        internal static string CorrigeDescricao(string descricao)
        {
            var tab = '\u0009';
            descricao = descricao.Replace("  ", " ");
            descricao = descricao.Replace("\r\n ", "");
            descricao = descricao.Replace("\r\n", "");
            descricao = descricao.Replace("\t", " ");//> <
            descricao = descricao.Replace("> <", "><"); //>  <
            descricao = descricao.Replace(">  <", "><");
            descricao = descricao.Replace(">   <", "><");
            descricao = descricao.Replace(">    <", "><");
            descricao = descricao.Replace(">     <", "><");
            descricao = descricao.Replace(tab.ToString(), "");
            return descricao;
        }

        private string xSt500Novo(string xml)
        {
            try
            {
                DataSet ds = new DataSet();
                ds.ReadXml(new StringReader(xml));
                DataColumn col1 = new DataColumn("vBCSTRet");
                DataColumn col2 = new DataColumn("pST");
                DataColumn col3 = new DataColumn("vICMSSubstituto");
                DataColumn col4 = new DataColumn("vICMSSTRet");
                try
                {
                    ds.Tables["ICMSSN500"].Columns.Add(col1);
                }
                catch { }
                //try
                //{
                //    ds.Tables["ICMSSN500"].Columns.Add(col2);
                //}
                //catch { }
                //try
                //{
                //    ds.Tables["ICMSSN500"].Columns.Add(col3);
                //}
                //catch { }
                try
                {
                    ds.Tables["ICMSSN500"].Columns.Add(col4);
                }
                catch { }

                ds.Tables["ICMSSN500"].Columns["orig"].SetOrdinal(0);
                ds.Tables["ICMSSN500"].Columns["CST"].SetOrdinal(1);
                ds.Tables["ICMSSN500"].Columns["vBCSTRet"].SetOrdinal(2);
               // ds.Tables["ICMSSN500"].Columns["vICMSSTRet"].SetOrdinal(3);
                ds.Tables["ICMSSN500"].Columns["ICMS_Id"].SetOrdinal(4);

                // DataRow dr;
                foreach (DataRow dr in ds.Tables["ICMSSN500"].Rows)
                {

                    foreach (DataRow drProd in ds.Tables["Prod"].Select("det_Id = " + dr["ICMS_Id"].ToString()))
                    {
                        double _vlTotalProduto = 0, _vbcstret = 0.00000001, _pst = 18, _vicmssubstituto = 0.00000001, _vicmsstret = 0.00000001;
                        double _vlTotalProdutoEnt = 0, _vbcstretEnt = 0, _pstEnt = 0, _vicmssubstitutoEnt = 0, _vicmsstretEnt = 0;
                        buscar_informacoes_entrada(drProd["cEAN"].ToString(), out _vlTotalProdutoEnt, out _vbcstretEnt,
                            out _pstEnt, out _vicmssubstitutoEnt, out _vicmsstretEnt);

                        _vlTotalProduto = Convert.ToDouble(drProd["vProd"].ToString().Replace(".", ","));
                        if (_vbcstretEnt > 0)
                        {
                            _vbcstret = _vbcstretEnt * _vlTotalProduto / _vlTotalProdutoEnt;
                            _pst = _pstEnt;
                            _vicmssubstituto = _vicmssubstitutoEnt * _vlTotalProduto / _vlTotalProdutoEnt;
                            _vicmsstret = _vicmsstretEnt * _vlTotalProduto / _vlTotalProdutoEnt;
                        }
                        dr["vBCSTRet"] = _vbcstret.ToString("n8").Replace(".", "").Replace(",", ".");
                        //dr["pST"] = _pst.ToString("n4").Replace(".", "").Replace(",", ".");
                        //dr["vICMSSubstituto"] = _vicmssubstituto.ToString("n8").Replace(".", "").Replace(",", ".");
                        dr["vICMSSTRet"] = _vicmsstret.ToString("n8").Replace(".", "").Replace(",", ".");
                        /*
                        try { _vbcstret = dr["vbcstret"].ToString().Replace(".", ","); }
                        catch { }
                        try { _pst = dr["pst"].ToString().Replace(".", ","); }
                        catch { }
                        try { _vicmssubstituto = dr["vicmssubstituto"].ToString().Replace(".", ","); }
                        catch { }
                        try { _vicmsstret = dr["vicmsstret"].ToString().Replace(".", ","); }
                        catch { }
                         * */
                    }
                }


                // string novo = util2.icmsEfetNT201805("0", "60", 0.00000001, 18, 0.00000001, 0.000000001, 0, 0, 0, 0, 0, 0, 0, 0, 0);

                xml = ds.GetXml();
                xml = CorrigeDescricao(xml);
                
            }
            catch { }
            return xml;
        }

        private void buscar_informacoes_entrada(string ean, out double _vlTotalProduto, out double _vbcstret, out double _pst, 
            out double _vicmssubstituto, out double _vicmsstret)
        {
            _vlTotalProduto = 0;
            _vbcstret = 0; _pst = 0; _vicmssubstituto = 0; _vicmsstret = 0;
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText = 
                        "SELECT first(1) inf.* FROM ITENS_NOTA_ENT inf " +
                        "INNER JOIN PRODUTOS p on (inf.COD_EAN_ITEM_ENT = p.COD_BARRAS_CAIXA_PRODUTO or inf.COD_EAN_ITEM_ENT = p.COD_BARRAS_PRODUTO) " +
                        "WHERE p.COD_BARRAS_PRODUTO = '" + ean + "' and vbcstret_item_ent > 0 order by inf.COD_ITENS_NOTA_ENT desc";
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    try
                    {
                        _vlTotalProduto = Convert.ToDouble(dr["PRECO_TOTAL_ITEM_ENT"].ToString());
                        _vbcstret = Convert.ToDouble(dr["vbcstret_item_ent"].ToString());
                        _pst = Convert.ToDouble(dr["pst_item_ent"].ToString());
                        _vicmssubstituto = Convert.ToDouble(dr["vicmssubstituto_item_ent"].ToString());
                        _vicmsstret = Convert.ToDouble(dr["vicmsstret_item_ent"].ToString());
                    }
                    catch { }
                }
            }
            catch (Exception a)
            {
                fbConnection1.Close();

            }
        }

        private string xSt60(string xml)
        {
            /*  int indice_fim = xml.IndexOf("<infAdic>");
                    int indice_inicio = xml.IndexOf("<pag>");
                    xml = xml.Remove(indice_inicio, indice_fim - indice_inicio);
                    xml = xml.Insert(indice_inicio, _xmlpag);*/

           
            //buscar da nota de entrada
            string novo = util2.icmsEfetNT201805("0", "60", 0.00000001, 18, 0.00000001, 0.000000001, 0, 0, 0, 0, 0, 0, 0, 0, 0);
            
            xml = xml.Replace("<ICMS><ICMS60><orig>0</orig><CST>60</CST></ICMS60></ICMS>",novo);
            xml = xml.Replace("<ICMS><ICMS60><orig>1</orig><CST>60</CST></ICMS60></ICMS>", novo);
            return xml;
        }

        private string xSt500(string xml)
        {
            string novo = util2.icmsEfetNT201805("0", "500", 0.00000001, 18, 0.00000001, 0.00000001, 0, 0, 0, 0, 0, 0, 0, 0, 0);
            xml = xml.Replace("<ICMS><ICMSSN500><orig>0</orig><CSOSN>500</CSOSN></ICMSSN500></ICMS>", novo);
            return xml;
        }

        private string xCst51(string xml)
        {

            xml = xml.Replace("<CST>51</CST><modBC>3</modBC><pDif>100.00</pDif></ICMS51>", "<CST>51</CST></ICMS51>");
            return xml;
        }
        /*<CST>51</CST><modBC>3</modBC><pDif>100.00</pDif></ICMS51>*/
        private string fat(string xml)
        {
            if (xml.Contains("</vOrig><vLiq>"))
                xml = xml.Replace("</vOrig><vLiq>", "</vOrig><vDesc>0.00</vDesc><vLiq>");
            else
            {
                if (valorTotalNFCe > 0)
                {
                    double total_nota = valorTotalNFCe;
                    string total = total_nota.ToString("n2").Replace(".","").Replace(",", ".");
                    xml = xml.Replace("</nFat></fat>", "</nFat><vOrig>" + total + "</vOrig><vDesc>0.00</vDesc><vLiq>" + total + "</vLiq></fat>");
                }
                else
                {
                    double total_nota = buscar_valor_total_nf();
                    string total = total_nota.ToString("n2").Replace(".","").Replace(",", ".");
                    xml = xml.Replace("</nFat></fat>", "</nFat><vOrig>" + total + "</vOrig><vDesc>0.00</vDesc><vLiq>" + total + "</vLiq></fat>");
                }
            }


            return xml;
        }

        private double buscar_valor_total_nf()
        {
            double total = 0;
            try
            {
                FbCommand sel = new FbCommand();
                FbDataAdapter datSel = new FbDataAdapter();
                DataTable dt = new DataTable();
                sel.Connection = fbConnection1;
                sel.CommandText = "SELECT VALOR_NOTA_NF FROM NOTA_FISCAL WHERE COD_SISTEMA_NF = " + cod_nf_sistema;
                datSel.SelectCommand = sel;
                fbConnection1.Open();
                datSel.Fill(dt);
                fbConnection1.Close();
                foreach (DataRow dr in dt.Rows)
                {
                    try
                    {
                        total = Convert.ToDouble(dr[0].ToString());
                    }
                    catch { }
                }
                return total;
            }
            catch
            {
                fbConnection1.Close();
                return total;
            }
        }

        private string cEAN(string xml)
        {
            try
            {
                xml = xml.Replace("<cEAN/>", "<cEAN>SEM GTIN</cEAN>");
                xml = xml.Replace("<cEAN />", "<cEAN>SEM GTIN</cEAN>");
                xml = xml.Replace("<cEANTrib/>", "<cEANTrib>SEM GTIN</cEANTrib>");
                xml = xml.Replace("<cEANTrib />", "<cEANTrib>SEM GTIN</cEANTrib>");
            }
            catch { }
            return xml;

        }

        public static string SubstituiCaracteresEspeciais(string text)
        {
            if (!string.IsNullOrEmpty(text))
            {
                /*
                var sb = new StringBuilder();
                var arrayChar = text.Normalize(NormalizationForm.FormD).ToCharArray();

                foreach (char c in arrayChar)
                {
                    if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                        sb.Append(c);
                }
                  
                return Regex.Replace(sb.ToString(), @"[^0-9a-zA-Z°ºª&¹²³.,\\@\- ]+", x => new string(' ', x.Length))
                 */ 
                return text.Replace("ª", "a")
                    .Replace("º", "o")
                    .Replace("°", "o")
                    .Replace("&", "e")
                    .Replace("¹", "1")
                    .Replace("²", "2")
                    .Replace("³", "3");
               }
            return string.Empty;
        }


        private string retirarCaracteresEspeciais(string xml)
        {

            xml = SubstituiCaracteresEspeciais(xml);
            return xml;
        }

        public void acertar_campos_bd()
        {
            try
            {
                FbCommand alter = new FbCommand();
                alter.CommandText =
                 "alter table nota_fiscal alter forma_pgto_nf type varchar(100)";
                alter.Connection = fbConnection1;
                fbConnection1.Open();
                alter.ExecuteNonQuery();
                fbConnection1.Close();

            }
            catch(Exception a)
            {
                fbConnection1.Close();
            }

            try
            {
                FbCommand alter = new FbCommand();
                alter.CommandText =
                 "alter table EMPRESA ADD    DATA_LICENCA_EMPRESA            DATE";
                alter.Connection = fbConnection1;
                fbConnection1.Open();
                alter.ExecuteNonQuery();
                fbConnection1.Close();

                FbCommand alter1 = new FbCommand();
                alter1.CommandText =
                 "alter table EMPRESA ADD    HASH_LICENCA_EMPRESA            VARCHAR(100)";
                alter1.Connection = fbConnection1;
                fbConnection1.Open();
                alter1.ExecuteNonQuery();
                fbConnection1.Close();

            }
            catch (Exception a)
            {
                fbConnection1.Close();
            }

        }

        public string inverter_cnpj(string cnpj)
        {

            string retorno =  "";
            cnpj += DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString();
            for (int i = 0; i < cnpj.Length; i++)
            {
                int posicao = i + 1;
                int caractere = Convert.ToInt16(cnpj[i].ToString());
                int variavel = caractere * posicao;
                int soma_interna = 0;
                while (variavel.ToString().Length != 1)
                {
                    soma_interna = 0;
                    for (int j = 0; j < variavel.ToString().Length; j++)
                    {
                        soma_interna = soma_interna + Convert.ToInt16(variavel.ToString()[j].ToString());
                    }
                    variavel = soma_interna;
                }
                retorno += variavel.ToString();
            }
            /*
            for (int i = cnpj.Length - 1; i >= 0; i--)
            {
                retorno += cnpj[i].ToString();
            }
             * */
            return retorno;
            /*
            string retorno =  "";
            for (int i = cnpj.Length -1; i >= 0; i--)
            {
                retorno += cnpj[i];
            }
            return retorno;
             */
        }

        public bool buscar_dados_licenca(out string hash, out DateTime data_licenca, out string cnpj, out string mensagem)
        {
            /* Coluna 0 - CNPJ invertido
            * Coluna 1 - Mensagem
            * Coluna 2 - Data licenca
            * Coluna 3 - Status Cliente (OK, NL (Não Licenciado))
            */
            string[] retorno = new string[4];

            hash =  "";
            data_licenca = Convert.ToDateTime("01/09/1983");
            cnpj =  "";
            mensagem =  "";
           try
            {
                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT DATA_LICENCA_EMPRESA, HASH_LICENCA_EMPRESA, CNPJ_EMPRESA FROM EMPRESA";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    hash = dr["HASH_LICENCA_EMPRESA"].ToString();
                    try
                    {
                        data_licenca = Convert.ToDateTime(dr["DATA_LICENCA_EMPRESA"].ToString());
                    }
                    catch { }
                    cnpj = dr["CNPJ_EMPRESA"].ToString().Replace(".","").Replace("-", "").Replace("/", "");
                }
               /*
                if (data_licenca < DateTime.Now.AddDays(-7) || hash != inverter_cnpj(cnpj))
                {
                    try
                    {
                       // bool retorno = webEvo.Consulta(cnpj, out hash, out mensagem, out data_licenca);
                        retorno = webEvo.Consulta_cnpj(cnpj);
                        hash = retorno[0];
                        mensagem = retorno[1];
                        data_licenca = Convert.ToDateTime(retorno[2]);

                    }
                    catch (Exception a)
                    {
                        form_erro erro = new form_erro();
                        erro.erro = a.ToString();
                        erro.ShowDialog();
                    }
                    if (retorno[3].ToString() == "NL")
                    {
                        if(mensagem == "")
                            mensagem = "Licença não encontrada. Contate o suporte";
                        return false;
                    }
                    else
                    {
                        try
                        {
                            FbCommand update = new FbCommand();
                            update.CommandText =
                                "UPDATE EMPRESA SET DATA_LICENCA_EMPRESA = '"  +  data_licenca.ToShortDateString().Replace("/",".") + "', " +
                            "HASH_LICENCA_EMPRESA = '" + hash + "'";
                            update.Connection = fbConnection1;
                            fbConnection1.Open();
                            FbDataAdapter datUpdate = new FbDataAdapter();
                            datUpdate.UpdateCommand = update;
                            datUpdate.UpdateCommand.ExecuteNonQuery();
                            fbConnection1.Close();
                        }
                        catch
                        {
                            fbConnection1.Close();
                        }
                        return true;
                    }
                }
                */
                return true;
            }
            catch(Exception a)
            {
                fbConnection1.Close();
                acertar_campos_bd();
                return false;
            }

        }

        public string verificar_erros_comuns()
        {
            string erros =  "";
            string ie = "", pessoa_fisica  =  "";
            int n_erro = 1;
            try
            {

                //ERROS NA NOTA FISCAL E CLIENTE
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT c.IE, c.NUMERO_CLIENTE, c.COD_CIDADE_CLIENTE, c.BAIRRO, c.CIDADE, " +
                    "n.FORMA_PGTO_NF, n.FRETE_CONTA_NF, c.PESSOA_FISICA_CLIENTE, n.NATUREZA_OPERACAO_NF " + 
                    "FROM NOTA_FISCAL n " +
                    "INNER JOIN CLIENTES c on c.CNPJ = n.CNPJ_CLIENTE_FORN " +
                    "WHERE n.COD_SISTEMA_NF = '" + cod_nf_sistema + "'";
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                bool existe = false;
                
                foreach (DataRow dr in dtSelect.Rows)
                {
                    existe = true;
                    ie = dr["IE"].ToString();
                    try
                    {
                        pessoa_fisica = dr["PESSOA_FISICA_CLIENTE"].ToString();
                    }
                    catch { }
                    if (dr["IE"].ToString() == "")
                    {
                        erros += n_erro.ToString() + " - Inscrição Estadual do Cliente incorreta. Verifique o correto no http://www.sintegra.com.br ou coloque ISENTO no cadastro do Cliente. \n";
                        n_erro++;
                    }
                    if (dr["NUMERO_CLIENTE"].ToString() == "")
                    {
                        erros += n_erro.ToString() + " - Número do endereço do cliente incorreto. Verifique o correto no http://www.sintegra.com.br ou coloque SN no cadastro do Cliente. \n";
                        n_erro++;
                    }
                    if (dr["COD_CIDADE_CLIENTE"].ToString() == "" || dr["COD_CIDADE_CLIENTE"].ToString().Length != 7)
                    {
                        erros += n_erro.ToString() + " - Código da cidade do cliente incorreto. Verifique o correto em https://cidades.ibge.gov.br/ e acerte no cadastro do Cliente. \n";
                        n_erro++;
                    }
                    if (dr["BAIRRO"].ToString() == "")
                    {
                        erros += n_erro.ToString() + " - Bairro do cliente vazio. Verifique o correto em http://www.sintegra.com.br e acerte no cadastro do Cliente. \n";
                        n_erro++;
                    }
                    if (dr["CIDADE"].ToString() == "")
                    {
                        erros += n_erro.ToString() + " - Cidade do cliente vazia. Verifique a correta em http://www.sintegra.com.br e acerte no cadastro do Clientes. \n";
                        n_erro.ToString();
                    }
                    if (dr["NATUREZA_OPERACAO_NF"].ToString() == "")
                    {
                        erros += n_erro.ToString() + " - Natureza da Operação vazia. Possivelmente CFOP não está cadastrada. Cadastre a CFOP e insira os itens novamente \n";
                        n_erro++;
                    }
                    if (dr["FORMA_PGTO_NF"].ToString() == "")
                    {
                        erros += n_erro.ToString() + " - Forma de Pagamento vazia. Coloque uma forma de pagamento na Nota Fiscal \n";
                        n_erro++;
                    }
                    else
                    {
                        if (dr["FORMA_PGTO_NF"].ToString()[0].ToString() != "0" && 
                            dr["FORMA_PGTO_NF"].ToString()[0].ToString() != "1" && 
                            dr["FORMA_PGTO_NF"].ToString()[0].ToString() != "2")
                        {
                            erros += n_erro.ToString() + " - Descrição da Forma de Pagamento incorreta. O início da descrição da forma de pagamento deve conter (0 para a vista, 1 para a prazo ou 2 para Outros) \n";
                            n_erro++;
                        }
                        if (dr["FORMA_PGTO_NF"].ToString()[0].ToString() == "1")
                        {
                            if (buscar_valor_pagamentos() <= 0)
                            {
                                erros += n_erro.ToString() + " - Valor total das faturas de pagamento tem que ser maior que zero quando a forma de pagamento for 'À prazo' \n";
                                n_erro++;
                            }
                        }
                    }
                    if (dr["FRETE_CONTA_NF"].ToString() == "")
                    {
                        erros += n_erro.ToString() + " - Frete por conta não preenchido. Insira 0 - Remetente, 1 - Destinatário, 9 - Outros. \n";
                        n_erro++;
                    }
                }
                if (!existe)
                {
                    erros += n_erro.ToString() + " - Cliente não encontrado. O CNPJ do remetente da nota e o CNPJ do Cadastro do Cliente devem estar iguais. \n";
                    n_erro++;
                }

                //ERROS ITENS_NOTA
                try
                {
                    FbCommand select_itens = new FbCommand();
                    select_itens.Connection = fbConnection1;
                    fbConnection1.Open();
                    select_itens.CommandText =
                        "SELECT * " +
                        "FROM ITENS_NOTA i " +
                        "INNER JOIN NOTA_FISCAL n on i.NF_ITEM = n.N_NF " +
                        "WHERE n.COD_SISTEMA_NF = '" + cod_nf_sistema + "' " +
                        "ORDER BY i.COD_ITENS_NOTA ";
                    FbDataAdapter datSelect_itens = new FbDataAdapter();
                    datSelect_itens.SelectCommand = select_itens;
                    DataTable dtSelect_itens = new DataTable();
                    datSelect_itens.Fill(dtSelect_itens);
                    fbConnection1.Close();
                    int n_item = 1;
                    foreach (DataRow dr_itens in dtSelect_itens.Rows)
                    {
                        //CST ISENTO
                        if (ie == "ISENTO" || pessoa_fisica == "1")
                        {
                            if (dr_itens["ST_ITEM"].ToString() == "101" ||
                                dr_itens["ST_ITEM"].ToString() == "201")
                            {
                                erros += n_erro.ToString() + " - O item " + n_item + " está com CST " + dr_itens["ST_ITEM"].ToString() + ". Quando a venda é para Consumidor Final o CST correto é 102 (Substituindo 101) ou 202 (Substituindo 201). \n";
                                n_erro++;
                            }
                            
                        }
                        //CST VAZIA
                        if (dr_itens["ST_ITEM"].ToString() == "")
                        {
                            erros += n_erro.ToString() + " - O item " + n_item + " está com CST VAZIA. Verifique os cadastros de tributação. \n";
                            n_erro++;
                        }

                        //BASE DE CALCULO COM ICMS ZERADO
                        try
                        {
                            if (dr_itens["VALOR_ICM_ITEM"].ToString() != "")
                            {
                                if (Convert.ToDouble(dr_itens["VALOR_ICM_ITEM"].ToString()) == 0)
                                {
                                    try
                                    {
                                        FbCommand update = new FbCommand();
                                        update.CommandText =
                                            "UPDATE ITENS_NOTA SET VALOR_BC_ITEM = NULL, VALOR_ICM_ITEM = 0 WHERE COD_ITENS_NOTA = '" +
                                            dr_itens["COD_ITENS_NOTA"].ToString() + "'";
                                        update.Connection = fbConnection1;
                                        fbConnection1.Open();
                                        FbDataAdapter datUpdate = new FbDataAdapter();
                                        datUpdate.UpdateCommand = update;
                                        datUpdate.UpdateCommand.ExecuteNonQuery();
                                        fbConnection1.Close();

                                    }
                                    catch { fbConnection1.Close(); }
                                }
                            }
                            else
                            {
                                if (dr_itens["VALOR_BC_ITEM"].ToString() != "")
                                {
                                    try
                                    {
                                        FbCommand update = new FbCommand();
                                        update.CommandText =
                                            "UPDATE ITENS_NOTA SET VALOR_BC_ITEM = NULL WHERE COD_ITENS_NOTA = '" + dr_itens["COD_ITENS_NOTA"].ToString() + "'";
                                        update.Connection = fbConnection1;
                                        fbConnection1.Open();
                                        FbDataAdapter datUpdate = new FbDataAdapter();
                                        datUpdate.UpdateCommand = update;
                                        datUpdate.UpdateCommand.ExecuteNonQuery();
                                        fbConnection1.Close();
                                    }
                                    catch { fbConnection1.Close(); }
                                }
                            }
                        }
                        catch
                        {
                            fbConnection1.Close();
                        }
                    }
                }
                catch
                {
                    fbConnection1.Close();
                }


                return erros;
            }
            catch (Exception a)
            {
                fbConnection1.Close();
               
                return a.ToString();
            }


        }

        public double buscar_valor_pagamentos()
        {
            double valor_total_pagamento = 0;
            try
            {
                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT SUM(f.VALOR_FATURA) FROM FATURA_NF f " +
                    "INNER JOIN NOTA_FISCAL n ON f.NF_FATURA = n.N_NF " +
                    "WHERE COD_SISTEMA_NF = '" + cod_nf_sistema + "'";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                valor_total_pagamento = 0;
                foreach (DataRow dr in dtSelect.Rows)
                {
                    try
                    {
                        valor_total_pagamento = Convert.ToDouble(dr[0].ToString());
                    }
                    catch { }
                }
                
                return valor_total_pagamento;
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                form_erro erro = new form_erro();
                erro.erro = a.ToString();
                erro.ShowDialog();
                return valor_total_pagamento;
            }
        }

        private void buscar_informacoes_nf()
        {
            //FORMA DE PAGAMENTO
            if (!String.IsNullOrEmpty(cod_nf_sistema))
            {
                try
                {
                    FbCommand select = new FbCommand();
                    select.CommandText =
                        "SELECT FORMA_PGTO_NF FROM NOTA_FISCAL WHERE COD_SISTEMA_NF = '" + cod_nf_sistema + "'";
                    select.Connection = fbConnection1;
                    fbConnection1.Open();
                    FbDataAdapter datSelect = new FbDataAdapter();
                    datSelect.SelectCommand = select;
                    DataTable dtSelect = new DataTable();
                    datSelect.Fill(dtSelect);
                    fbConnection1.Close();
                    foreach (DataRow dr in dtSelect.Rows)
                    {
                        forma_pgto = dr["FORMA_PGTO_NF"].ToString();
                    }
                }
                catch (Exception a)
                {
                    fbConnection1.Close();
                    form_erro erro = new form_erro();
                    erro.erro = a.ToString();
                    erro.ShowDialog();
                }

                //VALOR TOTAL PAGAMENTO
                try
                {
                    FbCommand select = new FbCommand();
                    select.CommandText =
                        "SELECT SUM(f.VALOR_FATURA) FROM FATURA_NF f " +
                        "INNER JOIN NOTA_FISCAL n ON f.NF_FATURA = n.N_NF " +
                        "WHERE COD_SISTEMA_NF = '" + cod_nf_sistema + "'";
                    select.Connection = fbConnection1;
                    fbConnection1.Open();
                    FbDataAdapter datSelect = new FbDataAdapter();
                    datSelect.SelectCommand = select;
                    DataTable dtSelect = new DataTable();
                    datSelect.Fill(dtSelect);
                    fbConnection1.Close();
                    valor_total_pagamento = 0;
                    foreach (DataRow dr in dtSelect.Rows)
                    {
                        try
                        {
                            valor_total_pagamento = Convert.ToDouble(dr[0].ToString());
                        }
                        catch { }
                    }
                    if (valor_total_pagamento == 0)
                        valor_total_pagamento = buscar_valor_total_nf();
                }
                catch (Exception a)
                {
                    fbConnection1.Close();
                    form_erro erro = new form_erro();
                    erro.erro = a.ToString();
                    erro.ShowDialog();
                }
            }
        }

        private string pag(string xml)
        {
            if (valorTotalNFCe > 0)
                valor_total_pagamento = valorTotalNFCe;
            
            string _xmlpag =  "";
            if (!String.IsNullOrEmpty(forma_pgto))
            {
                if (forma_pgto[0].ToString() == "2")
                {
                    _xmlpag = util2.pagamento400(util2.detPag("", "90", 0, "", "", "", ""), 0);
                }

                if (forma_pgto[0].ToString() == "0")
                {
                    //_xmlpag = util2.pagamento400(util2.detPag("1", "01", valor_total_pagamento, "", "", "", ""), 0);
                    _xmlpag = util2.pagamento400(util2.detPag202006("0", "99", "Outros", valor_total_pagamento, "", "", "", ""), 0);
                }
                if (forma_pgto[0].ToString() == "1")
                {
                   // _xmlpag = util2.pagamento400(util2.detPag("1", "01", valor_total_pagamento, "", "", "", ""), 0);
                    _xmlpag = util2.pagamento400(util2.detPag202006("1", "99", "Outros", valor_total_pagamento, "", "", "", ""), 0);
                }            //buscando indice das informacoes adicionas, pois o pagamento é sempre antes
                int indice_inicio = xml.IndexOf("<infAdic>");
                xml = xml.Insert(indice_inicio, _xmlpag);
            }
            else
            {
                try
                {
                    _xmlpag = util2.pagamento400(util2.detPag202006("0", "99", "Outros", valor_total_pagamento, "", "", "", ""), 0);
                    //_xmlpag = util2.pagamento400(util2.detPag("1", "01", valor_total_pagamento, "", "", "", ""), 0);
                    //_xmlpag = util2.pagamento400(util2.detPag("", "90", 0, "", "", "", ""), 0);
                    int indice_fim = xml.IndexOf("<infAdic>");
                    int indice_inicio = xml.IndexOf("<pag>");
                    xml = xml.Remove(indice_inicio, indice_fim - indice_inicio);
                    xml = xml.Insert(indice_inicio, _xmlpag);
                }
                catch { }
            }

            return xml;
        }

        public string infNfe_versao(string xml)
        {
            xml = xml.Replace("infNFe versao=\"3.10\"", "infNFe versao=\"4.00\"");
            return xml;
        }

        public string ide_indPag(string xml)
        {
            int indice_inicio = xml.IndexOf("<indPag>");
            int indice_fim = xml.IndexOf("</indPag>");
            indice_fim = indice_fim + "</indPag>".Length;
            int tamanho = indice_fim - indice_inicio;
            xml = xml.Remove(indice_inicio, tamanho);
           // xml = xml.Replace("<indPag>2</indPag>", "");
            return xml;
        }

        public string infNfe(string xml)
        {
            DataSet dsXml = new DataSet();
            XmlDocument xDoc = new XmlDocument();
            xDoc.LoadXml(xml);
            XmlNodeReader xmlReader = new XmlNodeReader(xDoc);
            dsXml.ReadXml(xmlReader);
            string _xmlinfAdic =  "";
            try
            {
                foreach (DataRow dr in dsXml.Tables["infAdic"].Rows)
                {
                    _xmlinfAdic = util2.infAdic("", dr["infCpl"].ToString(), "", "", "");
                }

                int indice_inicio = xml.IndexOf("<infAdic>");
                int indice_fim = xml.IndexOf("</infAdic>");
                indice_fim = indice_fim + "</infAdic>".Length;
                int tamanho = indice_fim - indice_inicio;
                xml = xml.Remove(indice_inicio, tamanho);
                xml = xml.Insert(indice_inicio, _xmlinfAdic);
            }
            catch { }
            return xml;
        }

        public string ICMSTot_camposDiversos(string xml)
        {
            /* COMO O XML DEVE SER
             * <ICMSTot>
    <vBC>100.00</vBC>
    <vICMS>18.00</vICMS>
    <vICMSDeson>0.00</vICMSDeson>
    <vFCPUFDest>1.00</vFCPUFDest>
    <vICMSUFDest>2.40</vICMSUFDest>
    <vICMSUFRemet>3.60</vICMSUFRemet>
    <vFCP>0.00</vFCP>
    <vBCST>0.00</vBCST>
    <vST>0.00</vST>
    <vFCPST>0.00</vFCPST>
    <vFCPSTRet>0.00</vFCPSTRet>
    <vProd>100.00</vProd>
    <vFrete>0.00</vFutilrete>
    <vSeg>0.00</vSeg>
    <vDesc>0.00</vDesc>
    <vII>0.00</vII>
    <vIPI>0.00</vIPI>
    <vIPIDevol>0.00</vIPIDevol>
    <vPIS>0.00</vPIS>
    <vCOFINS>0.00</vCOFINS>
    <vOutro>0.00</vOutro>
    <vNF>100.00</vNF>
</ICMSTot>
             * */

            DataSet dsXml = new DataSet();
            XmlDocument xDoc = new XmlDocument();
            xDoc.LoadXml(xml);
            XmlNodeReader xmlReader = new XmlNodeReader(xDoc);
            dsXml.ReadXml(xmlReader);
            string _xmlICMSTot =  "";
            
            foreach (DataRow dr in dsXml.Tables["ICMSTot"].Rows)
            {
                double vTotTrib = 0;
                double vFCPUFDest = 0;
                double vICMSUFDest = 0;
                double vICMSUFRemet = 0;
                try
                {
                    vTotTrib = Convert.ToDouble(dr["vTotTrib"].ToString().Replace(".", ","));
                }
                catch { }
                try
                {
                    vFCPUFDest = Convert.ToDouble(dr["vFCPUFDest"].ToString().Replace(".", ","));
                }
                catch { }
                try
                {
                    vICMSUFDest = Convert.ToDouble(dr["vICMSUFDest"].ToString().Replace(".", ","));
                }
                catch { }
                try
                {
                    vICMSUFRemet = Convert.ToDouble(dr["vICMSUFRemet"].ToString().Replace(".", ","));
                }
                catch { }
                _xmlICMSTot = util2.totalICMS400(Convert.ToDouble(dr["vBC"].ToString().Replace(".", ",")), Convert.ToDouble(dr["vICMS"].ToString().Replace(".", ",")),
                    Convert.ToDouble(dr["vBCST"].ToString().Replace(".", ",")), Convert.ToDouble(dr["vST"].ToString().Replace(".", ",")),
                    Convert.ToDouble(dr["vProd"].ToString().Replace(".", ",")), Convert.ToDouble(dr["vFrete"].ToString().Replace(".", ",")),
                    Convert.ToDouble(dr["vSeg"].ToString().Replace(".", ",")), Convert.ToDouble(dr["vDesc"].ToString().Replace(".", ",")),
                    Convert.ToDouble(dr["vII"].ToString().Replace(".", ",")), Convert.ToDouble(dr["vIPI"].ToString().Replace(".", ",")),
                    Convert.ToDouble(dr["vPIS"].ToString().Replace(".", ",")), Convert.ToDouble(dr["vCOFINS"].ToString().Replace(".", ",")),
                    Convert.ToDouble(dr["vOutro"].ToString().Replace(".", ",")), Convert.ToDouble(dr["vNF"].ToString().Replace(".", ",")),
                    vTotTrib, 0, vICMSUFDest, vICMSUFRemet, vFCPUFDest, 0, 0, 0, 0);
            }

            int indice_inicio = xml.IndexOf("<ICMSTot>");
            int indice_fim = xml.IndexOf("</ICMSTot>");
            indice_fim = indice_fim + "</ICMSTot>".Length;
            int tamanho = indice_fim - indice_inicio;
            xml = xml.Remove(indice_inicio, tamanho);
            xml = xml.Insert(indice_inicio, _xmlICMSTot);

            return xml;
        }





    }



}
