using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using HtmlAgilityPack;
using System.IO;

namespace Evolucao
{

    class classe_ler_tabela_html
    {
        DataTable retorno = new DataTable();
        public int n_linhas;

        public void buscar_html(string link_site)
        {

            HtmlAgilityPack.HtmlWeb web = new HtmlWeb();
           
            HtmlAgilityPack.HtmlDocument doc = web.Load(link_site);
            //HtmlAgilityPack.HtmlDocument doc = web. link_site;
            // Nome dos Controles
            String strTabela = "ctl00_contentPlaceHolderConteudo_grdResumoCarteiraTeorica";
            String strControle = "ctl00";
            List<String> strCampo = new List<String>();
            String strXPath;
            String strXPath2;
            String strValue;

            //Nome dos Campos
            strCampo.Add("_label");
            strCampo.Add("_linha");
            

            // Cria e abre arquivo no caminho informado
            StreamWriter swrArquivo = new StreamWriter(@"c:\\evolucao\\pagina.csv");

            // Monta o cabeçalho
            strValue = "Campos;Valores";
            swrArquivo.WriteLine(strValue);

            DataTable itens = new DataTable();
            DataColumn coluna0 = new DataColumn();
            
            itens.Columns.Add(coluna0);
            // Preenche os valores dos campos
            // Percorre as linhas

            
            for (int row = 0; row < n_linhas; row++)
            {
                try
                {
                    strValue = "";

                    // Percorre as colunas
                    for (int col = 0; col < strCampo.Count; col++)
                    {
                        // Monta a string do caminho de consulta
                        
                        //strXPath = strTabela + "_" + strControle + "_" + "ctl" + linha.ToString("00") + "_" + strCampo[col];
                        strXPath = row + strCampo[col];
                        strXPath = doc.GetElementbyId(strXPath).XPath;
                       
                        // Obtem valor do campo
                        foreach (HtmlNode link in doc.DocumentNode.SelectNodes(strXPath))
                        {
                            
                            if (col == 1)
                                strValue += link.InnerText.Trim().Replace("  "," ") + ";";
                            else
                            {
                                string _link = link.InnerText.Trim().Replace(" ", "");
                                
                                if (itens.Select("Column1 = '" + _link + "'").Length > 0)
                                {
                                    int i = 1;
                                    while (itens.Select("Column1 = '" + _link + i.ToString() + "'").Length > 0)
                                    {
                                        i++;
                                    }
                                    _link = _link + i.ToString();

                                    DataRow dr;
                                    dr = itens.NewRow();
                                    dr[0] = _link;
                                    itens.Rows.Add(dr);
                                }
                                else
                                {
                                    DataRow dr;
                                    dr = itens.NewRow();
                                    dr[0] = _link;
                                    itens.Rows.Add(dr);
                                }
                                strValue += _link + ";";
                            }
                        }
                    }

                    // Salva linha no arquivo
                    swrArquivo.WriteLine(strValue);
                }
                catch (Exception) { }
            }

            // Finaliza o arquivo após preenchido
            swrArquivo.Close();

        }

        private string retirar_espacos(string texto)
        {
            while (texto.Contains("  "))
                texto.Replace("  ", " ");
            return texto;
        }




    }
}
