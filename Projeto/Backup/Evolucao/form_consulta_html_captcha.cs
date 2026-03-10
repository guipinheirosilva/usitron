using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Text.RegularExpressions;
using System.IO;

namespace Evolucao
{
    public partial class form_consulta_html_captcha : Form
    {
        public string chave;
        public form_consulta_html_captcha()
        {
            InitializeComponent();
        }

        private void form_consulta_html_captcha_Load(object sender, EventArgs e)
        {
            try
            {
               
                //string captcha = doc.DocumentNode.SelectSingleNode("//img *[@id='ContentPlaceHolder1_imgCaptcha']").Attributes["src"].Value.ToString();
                string captcha = "http://www.nfe.fazenda.gov.br/scripts/srf/intercepta/captcha.aspx?opt=image";
                pictureBox1.ImageLocation = captcha;
                consulta();


            }
            catch { }
        }

        private string HTMLEspeciais(string sString)
        {
            string retorno = "";
            if (sString != "")
            {
                sString = sString.Replace("á", "a");
                sString = sString.Replace("â", "a");
                sString = sString.Replace("à", "a");
                sString = sString.Replace("ã", "a");
                sString = sString.Replace("ç", "c");
                sString = sString.Replace("é", "e");
                sString = sString.Replace("ê", "e");
                sString = sString.Replace("í", "i");
                sString = sString.Replace("ó", "o");
                sString = sString.Replace("ô", "o");
                sString = sString.Replace("õ", "o");
                sString = sString.Replace("ú", "u");
                sString = sString.Replace("ü", "u");
                sString = sString.Replace("Á", "A");
                sString = sString.Replace("Â", "A");
                sString = sString.Replace("À", "A");
                sString = sString.Replace("Ã", "A");
                sString = sString.Replace("Ç", "C");
                sString = sString.Replace("É", "E");
                sString = sString.Replace("Ê", "E");
                sString = sString.Replace("Í", "I");
                sString = sString.Replace("Ó", "O");
                sString = sString.Replace("Ô", "O");
                sString = sString.Replace("Õ", "O");
                sString = sString.Replace("Ú", "U");
                sString = sString.Replace("Ü", "U");

                sString = sString.Replace("&aacute;", "a");
                sString = sString.Replace("&acirc;", "a");
                sString = sString.Replace("&agrave;", "a");
                sString = sString.Replace("&atilde;", "a");
                sString = sString.Replace("&ccedil;", "c");
                sString = sString.Replace("&eacute;", "e");
                sString = sString.Replace("&ecirc;", "e");
                sString = sString.Replace("&iacute;", "i");
                sString = sString.Replace("&oacute;", "o");
                sString = sString.Replace("&ocirc;", "o");
                sString = sString.Replace("&otilde;", "o");
                sString = sString.Replace("&uacute;", "u");
                sString = sString.Replace("&uuml;", "u");
                sString = sString.Replace("&Aacute;", "A");
                sString = sString.Replace("&Acirc;", "A");
                sString = sString.Replace("&Agrave;", "A");
                sString = sString.Replace("&Atilde;", "A");
                sString = sString.Replace("&Ccedil;", "C");
                sString = sString.Replace("&Eacute;", "E");
                sString = sString.Replace("&Ecirc;", "E");
                sString = sString.Replace("&Iacute;", "I");
                sString = sString.Replace("&Oacute;", "O");
                sString = sString.Replace("&Ocirc;", "O");
                sString = sString.Replace("&Otilde;", "O");
                sString = sString.Replace("&Uacute;", "U");
                sString = sString.Replace("&Uuml;", "U");
                sString = sString.Replace("&quot;", "");
                sString = sString.Replace("&lt;", "<");
                sString = sString.Replace("&gt;", ">");
                sString = sString.Replace("&nbsp;", "");

                //sString = sString.Replace(",", "");
                sString = sString.Replace("\n", "");
                sString = sString.Replace("\r", "");
                sString = sString.Replace("\r\n", "");
                sString = sString.Replace("  ", " ");
                sString = sString.Replace(System.Environment.NewLine, "");

                sString = sString.Replace("\"TextoFundoBrancoNegrito\"", "TextoFundoBrancoNegrito"); //no Windows XP ele lê a propriedade do html com aspas
                sString = sString.Replace("\"linha\"", "linha");
            }
            retorno = sString;
            return retorno;
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            string temp = webBrowser1.DocumentText;
            temp = HTMLEspeciais(temp);

            Regex r, s, t;
            Match n, m, p;

            RichTextBox rtb = new RichTextBox();

            Random rnd = new Random();
            int month = rnd.Next(1, 10000);
            StreamWriter swrArquivo = new StreamWriter(@"C:\teste\NFe_" + month.ToString() + ".txt");

            // Monta o cabeçalho
           
            //ORIGINAL
            r = new Regex(@"<SPAN class=linha\s*?>(.*?)</SPAN>", 
            //r = new Regex(@"<SPAN class=linha\s*?>(.*)|[0-9][a-zA-Z]0-9]-</SPAN>",

                 RegexOptions.IgnoreCase | RegexOptions.Compiled);
            
            //ORIGINAL
            t = new Regex(@">(.*?)<", 
            //t = new Regex(@">(.*)|[0-9][a-zA-Z]0-9]-<", 
                RegexOptions.IgnoreCase | RegexOptions.Compiled);
            //(linha">)(.*?\S)(<)  linha.?>(.*?)<
            //s = new Regex(@"span id=.*?\s* class=.*?\s*>(.*?)</span>",
            
            ///* Original
            s = new Regex(@"<SPAN id=(.*)| class=(.*)>(.*)|[0-9][a-zA-Z]0-9]-<\/SPAN>",
           

             //s = new Regex(@"<span.*? id=p.*? class=.*?|class=.*?|>(.*?)<",

            
              RegexOptions.IgnoreCase | RegexOptions.Compiled);
           //  * */

            /* TESTE GUI
            s = new Regex(@"<SPAN class=TextoFundoBrancoNegrito\s*?>(.*?)</SPAN>",


                 RegexOptions.IgnoreCase | RegexOptions.Compiled);
            */

            for (m = s.Match(temp); m.Success; m = m.NextMatch())
            {

                rtb.AppendText("Chave: " + m.Groups[1] + "\n" + m.Groups[2]);
                swrArquivo.WriteLine(m.Groups[1] + "\n" + m.Groups[2]);
            }
            for (n = r.Match(temp); n.Success; n = n.NextMatch())
            {
                rtb.AppendText("Dados: " + n.Groups[1] + "\n" + n.Groups[2]);
                swrArquivo.WriteLine(n.Groups[1] + "\n" + n.Groups[2]);
            }

            File.WriteAllText(@"C:\ConsultaNfe.html", rtb.Text);
            //File.WriteAllText(@"C:\ConsultaNfe.txt", rtb.Text);
            string tt = rtb.Text;//.Replace("-","").Replace("/","").Replace(".","");
            RichTextBox tb = new RichTextBox();
            for (p = t.Match(tt); p.Success; p = p.NextMatch())
            {
                if (p.Groups[1].Value != "")
                {string teste;
                    if(p.Groups[1].Value.ToString() == "Endereco")
                        teste = p.Groups[1].ToString();

                    tb.AppendText(p.Groups[1] + "\n");
                    
                    swrArquivo.WriteLine(p.Groups[1] + "\n");
                }

            }
            File.WriteAllText(@"C:\ConsultaNfe.html", tb.Text);
            //File.WriteAllText(@"C:\ConsultaNfe.txt", tb.Text);
            MessageBox.Show("Arquivo Exportado", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            consulta();
        }
        
        private void consulta()
            {
            //pictureBox1.Load("http://www.nfe.fazenda.gov.br/scripts/srf/intercepta/captcha.aspx?opt=image");
            webBrowser1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(webBrowser1_DocumentCompleted);
            webBrowser1.Navigate("http://www.nfe.fazenda.gov.br/portal/consulta.aspx?tipoConsulta=completa&tipoConteudo=XbSeqxE8pl8=");
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            /* Verificar como faz para ir direto com o Captcha
            //Consulta Nf-e Sefaz
            HtmlElement ChaveNfe = webBrowser1.Document.GetElementById("ctl00$ContentPlaceHolder1$txtChaveAcessoCompleta");
            HtmlElement Captcha = webBrowser1.Document.GetElementById("ctl00$ContentPlaceHolder1$txtCaptcha");
            HtmlElement OK = webBrowser1.Document.GetElementById("ContentPlaceHolder1_btnConsultar");
            webBrowser1.Document.Encoding = "utf-8";
            if (ChaveNfe != null)
            {
                ChaveNfe.SetAttribute("value", txtChaveAcesso.Text);
                Captcha.SetAttribute("value", txtCaptcha.Text);
                pictureBox1.Load("http://www.nfe.fazenda.gov.br/scripts/srf/intercepta/captcha.aspx?opt=image");


                foreach (HtmlElement ele in ChaveNfe.Parent.Children)
                {
                    foreach (HtmlElement eleU in Captcha.Parent.Children)
                    {
                        foreach (HtmlElement eleA in OK.Parent.Children)
                        {
                            if (eleA.TagName.ToLower() == "input" && eleA.Name.ToLower() == "ctl00$ContentPlaceHolder1$btnConsultar")
                            {
                                eleA.InvokeMember("click");


                                break;
                            }
                        }
                    }
                }

            }
             * */

            //Consulta Nf-e Sefaz
            HtmlElement ChaveNfe = webBrowser1.Document.GetElementById("ctl00$ContentPlaceHolder1$txtChaveAcessoCompleta");
            HtmlElement Captcha = webBrowser1.Document.GetElementById("ctl00$ContentPlaceHolder1$txtCaptcha");
            HtmlElement OK = webBrowser1.Document.GetElementById("ContentPlaceHolder1_btnConsultar");
            webBrowser1.Document.Encoding = "utf-8";
            if (ChaveNfe != null)
            {
                ChaveNfe.SetAttribute("value", chave);
                Captcha.SetAttribute("value", txtCaptcha.Text);
                pictureBox1.Load("http://www.nfe.fazenda.gov.br/scripts/srf/intercepta/captcha.aspx?opt=image");


                foreach (HtmlElement ele in ChaveNfe.Parent.Children)
                {
                    foreach (HtmlElement eleU in Captcha.Parent.Children)
                    {
                        foreach (HtmlElement eleA in OK.Parent.Children)
                        {
                            if (eleA.TagName.ToLower() == "input" && eleA.Name.ToLower() == "ctl00$ContentPlaceHolder1$btnConsultar")
                            {
                                eleA.InvokeMember("click");


                                break;
                            }
                        }
                    }
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ler_html();
        }

        private void ler_html()
            {
            classe_ler_tabela_html teste = new classe_ler_tabela_html();
            int n_linhas = 0;
            //MessageBox.Show(webBrowser1.DocumentText);
            string temp = webBrowser1.DocumentText;
            gerar_html_teste(temp);

            temp = HTMLEspeciais(temp);
            

            string html_nota = indexar_campos_html(temp, out n_linhas);

            gerar_html(html_nota.Replace("class", "id"));
            teste.n_linhas = n_linhas;
            teste.buscar_html("c:\\evolucao_dokinos\\site.html");
            //teste.buscar_html("http://www.bmfbovespa.com.br/indices/ResumoCarteiraTeorica.aspx?Indice=IBOVESPA&idioma=pt-br");
        }

        private string indexar_campos_html(string html, out int numero_linhas)
        {
            numero_linhas = 0;
            int i = 1;
            string texto = "=TextoFundoBrancoNegrito>";
            while (html.Contains(texto))
            {
                int indice = 0;
                indice = html.IndexOf(texto);
                indice = indice + 1;
                html = html.Insert(indice, i.ToString() + "_");

                string texto2 = "=linha>";
                try
                {
                    int indice2 = 0;
                    indice2 = html.IndexOf(texto2,indice);
                    indice2 = indice2 + 1;
                    html = html.Insert(indice2, i.ToString() + "_");
                }
                catch { }

                i++;
            }
            numero_linhas = i;

            

            
            
            return html;
            
        }

        private void gerar_html_teste(string html)
        {
            try
            {
                FileInfo d = new FileInfo("c:\\evolucao_dokinos\\site_teste.html");
                d.Delete();
            }
            catch { }
            FileInfo t = new FileInfo("c:\\evolucao_dokinos\\site_teste.txt");
            try
            {

                using (StreamWriter texto = t.CreateText())
                {
                    texto.WriteLine(html);
                }
                t.CopyTo(Path.ChangeExtension(t.FullName, ".html"), false);
            }
            catch { }

            string filepath = "c:\\evolucao_dokinos\\site_teste.txt";
            StreamReader fileStream = new StreamReader(filepath);
            string fileContent = fileStream.ReadToEnd();
            Encoding fileEncoding = fileStream.CurrentEncoding;
            fileStream.Close();
            Encoding unicode = Encoding.Unicode;

            Encoding ansi = Encoding.GetEncoding(1252);

            Byte[] utf8Bytes = unicode.GetBytes(fileContent);

            Byte[] ansiBytes = Encoding.Convert(unicode, ansi, utf8Bytes);

            string ansiContent = ansi.GetString(ansiBytes);

            // Now writes the content in ANSI
            StreamWriter ansiWriter = new StreamWriter(filepath.Replace(".txt", "-ansi.txt"), false);
            ansiWriter.Write(ansiContent);
            ansiWriter.Close();

        }


        private void gerar_html(string html)
        {
            try
            {
                FileInfo d = new FileInfo("c:\\evolucao_dokinos\\site.html");
                d.Delete();
            }
            catch { }
            FileInfo t = new FileInfo("c:\\evolucao_dokinos\\site.txt");
            try
            {
                using (StreamWriter texto = t.CreateText())
                {
                    texto.WriteLine(html);
                }
                t.CopyTo(Path.ChangeExtension(t.FullName, ".html"), false);
            }
            catch { }

        }

        private void form_consulta_html_captcha_FormClosed(object sender, FormClosedEventArgs e)
        {
            ler_html();
        }
    }
}