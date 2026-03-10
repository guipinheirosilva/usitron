using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_localiza_nf : Form
    {
        public string nf_escolhida;
        public form_localiza_nf()
        {
            InitializeComponent();
        }

        private void form_localiza_nf_Load(object sender, EventArgs e)
        {
            datNota_fiscal.Fill(NOTA_FISCAL);
            dgvNota_fiscal.AutoGenerateColumns = false;
            dgvNota_fiscal.DataSource = dsNota_fiscal.Tables["NOTA_FISCAL"];
            
        }

        private void tb_localiza_TextChanged(object sender, EventArgs e)
        {
            dsNota_fiscal.Tables["NOTA_FISCAL"].DefaultView.RowFilter = "n_nf = '" + tb_localiza.Text + "'";
        }

        private void dgvNota_fiscal_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            form_faturamento nf = new form_faturamento();
            try
            {
                nf_escolhida = dgvNota_fiscal.Rows[e.RowIndex].Cells["col_nf"].Value.ToString();
                nf.abre_nf = true;
                //sub.peca_existente = true;
               // nf.nf_atual = 
                //nf.ShowDialog();
                this.Close();
            }
            finally
            {
                //nf.Dispose();
            }
        }

        private void dgvNota_fiscal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}