using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.IO;

namespace Evolucao
{
    public partial class ImpressaoBoleto : Form
    {
        public Bitmap bmp;
        public string n_nf;
        public ImpressaoBoleto()
        {
            InitializeComponent();
        }

        private void visualizarImagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  FormVisualizarImagem form = new FormVisualizarImagem(GerarImagem());
           // form.ShowDialog();
            
        }

        private string GerarImagem()
        {
            string address = webBrowser.Url.ToString();
            int width = 750;
            int height = 1000;

            int webBrowserWidth = 750;
            int webBrowserHeight = 1000;

           bmp = WebsiteThumbnailImageGenerator.GetWebSiteThumbnail(address,webBrowserWidth, webBrowserHeight, width, height);

          //  GerarPdf(bmp, n_nf);

            string file = Path.Combine(@"c:\\evolucao\\nfe\boletos\", "nf" + n_nf + "boleto.bmp");

            bmp.Save(file);

            return file;
        }

        private void enviarImagemPorEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //EnviarEmail form = new EnviarEmail(GerarImagem());
          //  form.ShowDialog();
        }

        private void ImpressaoBoleto_Load(object sender, EventArgs e)
        {
           // GerarImagem();
            
            /*
            PrintDialog pd = new PrintDialog();
            if (pd.ShowDialog() == DialogResult.OK)
            {
                pd.PrinterSettings = pd.PrinterSettings;
                //Something
            }
             * */
        }

        

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            GerarImagem();
            this.Close();
        }
    }
}