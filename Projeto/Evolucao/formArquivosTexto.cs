using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Evolucao
{
    public partial class formArquivosTexto : Form
    {
        public formArquivosTexto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Converter arquivo CLIENTES
            converterAnsi(@"c:\\evolucao\\jmacedo\CLIENTESJM05122013092103.txt");

            //Converter arquivo VENDAS
            converterAnsi(@"c:\\evolucao\\jmacedo\VENDASJM05122013092100.txt");

            //Converter arquivo ESTOQUE
            converterAnsi(@"c:\\evolucao\\jmacedo\ESTOQUEJM05122013092103.txt");

            //Converter arquivo FORÇA DE VENDAS
            converterAnsi(@"c:\\evolucao\\jmacedo\FORCAVENDASJM05122013092103.txt");

            //Converter arquivo PRODUTOS
            converterAnsi(@"c:\\evolucao\\jmacedo\PRODUTOSJM05122013092106.txt");

            MessageBox.Show("Arquivos JMacedo convertidos com sucesso!");
        }

        private void converterAnsi(string arquivo)
        {
            string filepath = arquivo;
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
    }
}