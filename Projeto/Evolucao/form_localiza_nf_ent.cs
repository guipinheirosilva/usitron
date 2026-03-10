using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_localiza_nf_ent : Form
    {
        public string n_nf;
        public string numero_nota_correto = "";
        public form_localiza_nf_ent()
        {
            InitializeComponent();
        }

        private void form_localiza_nf_ent_Load(object sender, EventArgs e)
        {
            try
            {
                datNota_fiscal_ent.Fill(NOTA_FISCAL_ENT);
                dgvNota_fiscal_ent.AutoGenerateColumns = false;
                dgvNota_fiscal_ent.DataSource = dsNota_fiscal_ent.Tables[0];
            }
            catch { }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsNota_fiscal_ent.Tables[0].DefaultView.RowFilter = "N_NF_ENT = '" + tb_n_nf.Text + "'";
            }
            catch { }
        }

        private void tb_cliente_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsNota_fiscal_ent.Tables[0].DefaultView.RowFilter = "CLIENTE_FORN_NF_ENT LIKE '*" + tb_cliente.Text + "*'";
            }
            catch { }
        }

        private void dgvNota_fiscal_ent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                n_nf = dgvNota_fiscal_ent.Rows[e.RowIndex].Cells[0].Value.ToString();
                numero_nota_correto = dgvNota_fiscal_ent.Rows[e.RowIndex].Cells["col_n_nf"].Value.ToString();
                this.Close();
            }
            catch { }
        }
    }
}