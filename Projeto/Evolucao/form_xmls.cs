using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_xmls : Form
    {
        public form_xmls()
        {
            InitializeComponent();
        }

        FbConnection conexao = new FbConnection(@"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=10.3.3.4;" +
          "Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0");


        private void button1_Click(object sender, EventArgs e)
        {

            //folderBrowserDialog1.Description = "Selecione uma pasta para realizar o Backup";
            //folderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer;
            //folderBrowserDialog1.ShowNewFolderButton = true;

            ////Exibe a caixa de diálogo
            //DialogResult result = folderBrowserDialog1.ShowDialog();
            //if (result == DialogResult.OK)
            //{
            //Exibe a pasta selecionada

            string pasta = @"c:\\evolucao\\xmls";  //folderBrowserDialog1.SelectedPath;

            try
            {
                // Verifica se a pasta existe
                if (Directory.Exists(pasta))
                {
                    // Apaga a pasta e todo o seu conteúdo
                    Directory.Delete(pasta, true);

                    Console.WriteLine("Pasta apagada com sucesso.");
                }

                // Cria a pasta novamente
                Directory.CreateDirectory(pasta);

                Console.WriteLine("Pasta criada novamente com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }

           
                 FbCommand select = new FbCommand();
            try
            {
                select.CommandText =
                    @"SELECT CNPJ_EMPRESA FROM EMPRESA ";
                select.Connection = conexao;
                conexao.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                conexao.Close();
                classe_geracao_xml xml = new classe_geracao_xml();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    
                    string cnpj = dr[0].ToString().Replace("/", "").Replace(".", "").Replace("-", "");
                    xml.cnpj = cnpj;
                    xml.caminho_pasta = pasta + "//" + cnpj + "//SAIDAS";
                    xml.caminho_pasta_entrada = pasta + "//" + cnpj + "//ENTRADAS";
                    xml.inicio = Convert.ToDateTime(dt_inicial.Text);
                    xml.fim = Convert.ToDateTime(dt_final.Text);
                    string caminho_excel_saidas = "";
                    xml.gerar_todas(out caminho_excel_saidas);
                    string caminho_excel_entradas = "";
                    xml.gerar_entrada(out caminho_excel_entradas);
                    try
                    {
                        // Inicia o processo do explorador de arquivos na pasta especificada
                        //Process.Start("explorer.exe", pasta);
                        //  Process.Start("excel", caminho_excel_saidas);
                        //  Process.Start("excel", caminho_excel_entradas);

                    }
                    catch (Exception ex)
                    {
                        // Manipular exceções, se necessário
                        Console.WriteLine("Erro ao abrir a pasta: " + ex.Message);
                    }
                    xml.ZiparPastas(pasta);
                    xml.cnpj_empresa = cnpj;


                }
                xml.enviar_email(pasta + @"\ZIP\nfs.zip", dt_inicial.Text, dt_final.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            //}
        }

        private void form_xmls_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string pasta = "c://evolucao//xmls";  //folderBrowserDialog1.SelectedPath;
            FbCommand select = new FbCommand();
            try
            {
                select.CommandText =
                    @"SELECT CNPJ_EMPRESA FROM EMPRESA ";
                select.Connection = conexao;
                conexao.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                conexao.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    classe_geracao_xml xml = new classe_geracao_xml();
                    string cnpj = dr[0].ToString().Replace("/", "").Replace(".", "").Replace("-", "");
                    xml.cnpj = cnpj;
                    xml.caminho_pasta = pasta + "//" + cnpj + "//SAIDAS";
                    xml.caminho_pasta_entrada = pasta + "//" + cnpj + "//ENTRADAS";
                    xml.inicio = Convert.ToDateTime(dt_inicial.Text);
                    xml.fim = Convert.ToDateTime(dt_final.Text);
                    //xml.gerar_todas();
                    //xml.gerar_entrada();
                    xml.ZiparPastas(pasta);
                    xml.cnpj_empresa = cnpj;
                    xml.enviar_email(pasta + "\\zip\\nfs.zip", dt_inicial.Text, dt_final.Text);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
