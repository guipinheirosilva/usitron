using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_localiza_operacao_old : Form
    {
        public string operacao_escolhida;
        public string abrev_escolhida;
        public int numero_de_itens;
        public form_localiza_operacao_old()
        {
            InitializeComponent();
        }

        private void form_localiza_operacao_Load(object sender, EventArgs e)
        {
            datTipos_operacoes.Fill(TIPOS_OPERACOES);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dsTipos_operacoes.Tables["TIPOS_OPERACOES"];
        }

        private void tb_localiza_TextChanged(object sender, EventArgs e)
        {
            dsTipos_operacoes.Tables["TIPOS_OPERACOES"].DefaultView.RowFilter = "TIPO Like '" + tb_localiza.Text + "*'";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //operacao_escolhida = dataGridView1.Rows[e.RowIndex].Cells["col_tipo"].Value.ToString();
            //this.Close();
        }
    }
}