using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_localiza_peca_fatura : Form
    {
        public string peca_escolhida;
        public form_localiza_peca_fatura()
        {
            InitializeComponent();
        }

        private void tb_localiza_TextChanged(object sender, EventArgs e)
        {
            dsOp.Tables["OP"].DefaultView.RowFilter = "DESCRICAO_PECA_OP Like '" + tb_localiza.Text + "*'";
        }

        private void form_localiza_peca_fatura_Load(object sender, EventArgs e)
        {
            datOp.Fill(OP);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dsOp.Tables["OP"];
            
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            peca_escolhida = dataGridView1.Rows[e.RowIndex].Cells["col_cod_op"].Value.ToString();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        

       
        

       
    }
}