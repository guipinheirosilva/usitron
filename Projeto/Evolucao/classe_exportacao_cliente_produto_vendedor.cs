using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;
using System.Data;
using System.Xml;
using System.IO;
using System.Data.OleDb;

namespace Evolucao
{
    public class classe_exportacao_cliente_produto_vendedor
    {
        DataSet theDS = new DataSet();
        public classe_exportacao_cliente_produto_vendedor()
        {
            OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:\\evolucao\\excel\\munic.xls';Extended Properties=\"Excel 8.0;HDR=NO;IMEX=1;\"");
            theConnection.Open();
            OleDbDataAdapter theDataAdapter = new OleDbDataAdapter("SELECT * FROM [Mun$]", theConnection);
            theDataAdapter.Fill(theDS);
            theConnection.Close();
        }

        public void exportar_clientes(string cod_webservice_empresa)
        {

            FbConnection conexao = new FbConnection();
            try
            {
                FbCommand select_vendedores = new FbCommand();

                conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=False; MaxPoolSize = 100;Packet Size=8192;Server Type=0";
                select_vendedores.Connection = conexao;
                select_vendedores.CommandText =
                    "SELECT COD_VENDEDOR FROM VENDEDORES";
                conexao.Open();
                FbDataAdapter datSelect_vendedores = new FbDataAdapter();
                datSelect_vendedores.SelectCommand = select_vendedores;
                DataTable dtSelect = new DataTable();
                datSelect_vendedores.Fill(dtSelect);
                conexao.Close();
                bool ok = false;
                foreach (DataRow dr_vend in dtSelect.Rows)
                {
                    XmlDocument xml = new XmlDocument();
                    try
                    {
                        //C.ATIVO_CLIENTE = 1 AND

                        FbCommand select = new FbCommand();
                        select.CommandText =
                     "SELECT C.* FROM CLIENTES C " +
                     "JOIN VENDEDORES_CLIENTE V ON C.COD_CLIENTE = V.COD_CLIENTE_VC " +
                     "WHERE V.COD_VENDEDOR_VC = '" + dr_vend[0].ToString() +
                     "' order by C.RAZAO_SOCIAL";
                        select.Connection = conexao;
                        conexao.Open();
                        FbDataAdapter datSelect = new FbDataAdapter();
                        datSelect.SelectCommand = select;
                        DataSet dsSelect = new DataSet();
                        datSelect.Fill(dsSelect);
                        conexao.Close();
                        dsSelect.Tables[0].TableName = "CLIENTES";
                        dsSelect.WriteXml(@"c:\\evolucao\\exportacoes\clientes_vendedor_" + dr_vend[0].ToString() + @".xml");
                        string arquivo = @"c:\\evolucao\\exportacoes\clientes_vendedor_" + dr_vend[0].ToString() + @".xml";
                        xml.Load(arquivo);

                        string _string_xml = GetXMLAsString(xml);

                        webservice.Service1 webser = new webservice.Service1();

                        if (cod_webservice_empresa != "")
                        {
                            ok = webser.exportar_offline_XML_clientes_cnpj(Convert.ToInt32(dr_vend[0].ToString()),
                                Convert.ToInt32(cod_webservice_empresa), _string_xml);
                        }
                    }
                    catch (Exception a)
                    {
                        form_erro fe = new form_erro();
                        fe.erro = a.ToString();
                        fe.ShowDialog();
                    }
                }
                if (ok)
                {
                    form_erro fe = new form_erro();
                    fe.erro = "Clientes exportados com sucesso!";
                    fe.ShowDialog();
                }
                else
                {
                    form_erro fe = new form_erro();
                    fe.erro = "Clientes não exportados. Contate o suporte.";
                    fe.ShowDialog();
                }
                conexao.Dispose();
            }
            catch (Exception a)
            {
                form_erro fe = new form_erro();
                fe.erro = a.ToString();
                fe.ShowDialog();
                conexao.Dispose();
            }

        }

        public string GetXMLAsString(XmlDocument myxml)
        {

            StringWriter sw = new StringWriter();
            XmlTextWriter tx = new XmlTextWriter(sw);
            myxml.WriteTo(tx);

            string str = sw.ToString();// 
            return str;
        }

        public void exportar_produtos(string cod_webservice_empresa)
        {
            FbConnection conexao = new FbConnection();
            conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=False; MaxPoolSize = 100;Packet Size=8192;Server Type=0";
            XmlDocument xml = new XmlDocument();
            bool ok = false;
            try
            {
                FbCommand select = new FbCommand();

                select.CommandText =
                    //"SELECT * FROM PRODUTOS WHERE status_produto = '1' order by DESCRICAO_PRODUTO";
                 "SELECT COD_PRODUTO, DESCRICAO_PRODUTO, COD_FORNECEDOR_PRODUTO, NOME_FORNECEDOR_PRODUTO, " +
                " CNPJ_FORNECEDOR_PRODUTO, MARCA_PRODUTO, COD_UNIDADE_PRODUTO, QTDE_UNIDADE_PRODUTO, VALOR_VENDA_REVEND_PRODUTO, DESCONTO_MAXIMO_PRODUTO, " +
                " VALOR_PROMOCAO_PRODUTO FROM PRODUTOS WHERE status_produto = '1' order by DESCRICAO_PRODUTO";
                select.Connection = conexao;
                conexao.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataSet dsSelect = new DataSet();
                datSelect.Fill(dsSelect);
                dsSelect.Tables[0].TableName = "PRODUTOS";
                dsSelect.WriteXml(@"c:\\evolucao\\exportacoes\produtos.xml");
                string arquivo = @"c:\\evolucao\\exportacoes\produtos.xml";
                xml.Load(arquivo);
                string _string_xml = GetXMLAsString(xml);
                webservice.Service1 webser = new webservice.Service1();
                if (cod_webservice_empresa != "")
                {
                    ok = webser.exportar_offline_XML_produtos_cnpj(Convert.ToInt32(cod_webservice_empresa), _string_xml);
                }

                if (ok)
                {
                    form_erro fe = new form_erro();
                    fe.erro = "Produtos exportados com sucesso!";
                    fe.ShowDialog();
                }
                else
                {
                    form_erro fe = new form_erro();
                    fe.erro = "Produtos não exportados. Contate o suporte.";
                    fe.ShowDialog();
                }
            }
            catch (Exception a)
            {
                form_erro fe = new form_erro();
                fe.erro = a.ToString();
                fe.ShowDialog();
            }
        }

        public void exportar_vendedores(string cod_webservice_empresa)
        {
            FbConnection conexao = new FbConnection();
            conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=False; MaxPoolSize = 100;Packet Size=8192;Server Type=0";
            XmlDocument xml = new XmlDocument();
            bool ok = false;
            try
            {
                FbCommand select = new FbCommand();

                select.CommandText =
                    //"SELECT * FROM PRODUTOS WHERE status_produto = '1' order by DESCRICAO_PRODUTO";
                 "SELECT * from vendedores";
                select.Connection = conexao;
                conexao.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataSet dsSelect = new DataSet();
                datSelect.Fill(dsSelect);
                dsSelect.Tables[0].TableName = "VENDEDORES";
                dsSelect.WriteXml(@"c:\\evolucao\\exportacoes\vendedores.xml");
                string arquivo = @"c:\\evolucao\\exportacoes\vendedores.xml";
                xml.Load(arquivo);
                string _string_xml = GetXMLAsString(xml);
                webservice.Service1 webser = new webservice.Service1();
                if (cod_webservice_empresa != "")
                {
                    ok = webser.exportar_offline_XML_vendedores_cnpj(Convert.ToInt32(cod_webservice_empresa), _string_xml);
                }

                if (ok)
                {
                    form_erro fe = new form_erro();
                    fe.erro = "Vendedores exportados com sucesso!";
                    fe.ShowDialog();
                }
                else
                {
                    form_erro fe = new form_erro();
                    fe.erro = "Vendedores não exportados. Contate o suporte.";
                    fe.ShowDialog();
                }
            }
            catch (Exception a)
            {
                form_erro fe = new form_erro();
                fe.erro = "Vendedores não exportados. Contate o suporte.";
                fe.ShowDialog();
            }
        }
    }
}
