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
    public partial class form_localiza_operador : Form
    {
        public bool atualizar_arquivo;
        public string operador_escolhido;
        public form_localiza_operador()
        {
            InitializeComponent();
        }

        private void form_localiza_operador_Load(object sender, EventArgs e)
        {
            datOperador.Fill(OPERADORES);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dsOperador.Tables["OPERADORES"];
            if (atualizar_arquivo == true)
            {
                gerar_arquivo();
                this.Close();
            }
        }

        private void tb_localiza_operador_TextChanged(object sender, EventArgs e)
        {
            dsOperador.Tables["OPERADORES"].DefaultView.RowFilter = "nome Like '" + tb_localiza_operador.Text + "*'";
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            operador_escolhido = dataGridView1.Rows[e.RowIndex].Cells["col_cod"].Value.ToString();
            this.Close();
        }

        private void gerar_arquivo()
        {
            FileInfo d = new FileInfo("c:\\evolucao_dokinos\\operadores2.txt");
            if(d.Exists == true)
                d.Delete();
            FileInfo t = new FileInfo("c:\\evolucao_dokinos\\operadores2.txt");
            try
            {
                using (StreamWriter texto = t.CreateText())
                {
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        texto.WriteLine(dataGridView1.Rows[i].Cells[0].Value + "\t" + dataGridView1.Rows[i].Cells[1].Value);
                    }
                }
            }
            catch { }


        }
    }
}