using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    class GerarPdfNfce
    {

        public void gerarPdf(string caminho)
        {
            try
            {
                dsNfce nfce = new dsNfce();
                DataSet ds = new DataSet();
                ds.ReadXml(caminho);

                string razao = "", cnpj = "", ie = "", logradouro = "", nro = "", bairro = "", cidade = "", uf = "",
                    protocolo = "", chave = "", n_nfce = "", serie = "";
                double vl_total = 0;
                string data_hora = "";
                string cpf = "";

                foreach (DataRow dt in ds.Tables["emit"].Rows)
                {
                    razao = dt["xNome"].ToString();
                    cnpj = dt["CNPJ"].ToString();
                    ie = dt["IE"].ToString();
                }
                foreach (DataRow dt in ds.Tables["enderEmit"].Rows)
                {
                    logradouro = dt["xLgr"].ToString();
                    nro = dt["nro"].ToString();
                    bairro = dt["xBairro"].ToString();
                    cidade = dt["xMun"].ToString();
                    uf = dt["UF"].ToString();
                }
                foreach (DataRow dt in ds.Tables["infProt"].Rows)
                {
                    protocolo = dt["nProt"].ToString();
                    chave = dt["chNfe"].ToString();
                    data_hora = dt["dhRecbto"].ToString();
                }

                string data = Convert.ToDateTime(data_hora.Substring(0, 10).Replace("-", "/")).ToString("dd/MM/yyyy");
                string hora = data_hora.Substring(11, (data_hora.Length - 17));

                try
                {
                    foreach (DataRow dt in ds.Tables["dest"].Rows)
                    {
                        cpf = dt["CPF"].ToString();
                    }
                }
                catch
                {
                    cpf = "Consumidor não identificado";
                }
                foreach (DataRow dt in ds.Tables["ide"].Rows)
                {
                    n_nfce = dt["nNF"].ToString();
                    serie = dt["serie"].ToString();
                }
                foreach (DataRow dt in ds.Tables["pag"].Rows)
                {
                    vl_total = Convert.ToDouble(dt["vPag"].ToString().Replace(".", ","));
                }

                nfce.NFCE.AddNFCERow(razao, cnpj, ie, logradouro, nro, bairro, cidade, uf, n_nfce, serie, data, hora,
                    protocolo, chave, cpf, vl_total);

                string cod = "", descricao = "", un = "";
                double qtde = 0, vl_unit = 0, vl_total_item = 0;

                foreach (DataRow dt in ds.Tables["prod"].Rows)
                {
                    cod = dt["cProd"].ToString();
                    descricao = dt["xProd"].ToString();
                    un = dt["uCom"].ToString();
                    try
                    {
                        qtde = Convert.ToDouble(dt["qCom"].ToString().Replace(".", ","));
                    }
                    catch { }
                    try
                    {
                        vl_unit = Convert.ToDouble(dt["vUnCom"].ToString().Replace(".", ","));
                    }
                    catch { }
                    try
                    {
                        vl_total_item = Convert.ToDouble(dt["vProd"].ToString().Replace(".", ","));
                    }
                    catch { }

                    nfce.ITENS.AddITENSRow(cod, descricao, qtde, un, vl_unit, vl_total_item);
                }

                crNfce cr = new crNfce();
                cr.SetDataSource(nfce);
                form_imprimir imprime = new form_imprimir(cr);
                imprime.nfce = true;
                imprime.nfce_email = true;
                imprime.n_nfce = n_nfce;
                imprime.Show();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
            }
        }
    }
}
