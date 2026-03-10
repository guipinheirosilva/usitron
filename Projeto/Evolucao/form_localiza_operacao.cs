using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{

    public partial class form_localiza_operacao : Form
    {
        public string[,] operacao_escolhida = new string[100,2];
        public string[] abrev_escolhida = new string[100];
        public int numero_de_itens;
        public form_localiza_operacao()
        {
            InitializeComponent();
        }

        private void form_localiza_operacao_Load(object sender, EventArgs e)
        {
            datTipos_operacoes.Fill(TIPOS_OPERACOES);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dsTipos_operacoes.Tables["TIPOS_OPERACOES"];
            dataGridView1.Focus();
        }

        private void tb_localiza_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsTipos_operacoes.Tables["TIPOS_OPERACOES"].DefaultView.RowFilter = "TIPO Like '*" + tb_localiza.Text + "*'";
            }
            catch { }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //operacao_escolhida = dataGridView1.Rows[e.RowIndex].Cells["col_tipo"].Value.ToString();
           // this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int j = 0;
            for (int i = dataGridView1.SelectedRows.Count - 1; i >= 0; i--)
            {
                operacao_escolhida[i,0] = dataGridView1.SelectedRows[j].Cells["col_tipo"].Value.ToString();
                abrev_escolhida[i] = dataGridView1.SelectedRows[j].Cells["col_abrev"].Value.ToString();
                j++;
            }
            numero_de_itens = dataGridView1.SelectedRows.Count;
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsTipos_operacoes.Tables["TIPOS_OPERACOES"].DefaultView.RowFilter = "SETOR_TIPO Like '" + textBox1.Text + "*'";
            }
            catch { }
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                //dgvPecas.Rows[dgvPecas.SelectedCells[0].RowIndex - 1].Cells["col_descricao"].Value.ToString();
                operacao_escolhida[0,0] = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex - 1].Cells["col_tipo"].Value.ToString();
                abrev_escolhida[0] = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex - 1].Cells["col_abrev"].Value.ToString();
                numero_de_itens = 1;
                this.Close();
            }
        }
    }
}