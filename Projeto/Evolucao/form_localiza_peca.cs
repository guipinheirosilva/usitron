using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_localiza_peca : Form
    {
        public form_localiza_peca()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            form_peca sub = new form_peca();
            try
            {
                sub.peca_existente = true;
                sub.peca_atual = dataGridView1.Rows[e.RowIndex].Cells["cod_peca_atual"].Value;
                sub.ShowDialog();
            }
            finally
            {
                sub.Dispose();
                //this.Close();
                
            }
        }

        private void form_localiza_peca_Load(object sender, EventArgs e)
        {
            datDesenhos.Fill(DESENHOS);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dsDesenhos.Tables["DESENHOS"];
        }

        private void tb_localiza_peca_TextChanged(object sender, EventArgs e)
        {
            dsDesenhos.Tables["DESENHOS"].DefaultView.RowFilter = "cod_peca Like '" + tb_localiza_peca.Text + "*'";
        }
    }
}