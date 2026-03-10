using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_localiza_nf_entrada : Form
    {
        public string nf_escolhida;
        public form_localiza_nf_entrada()
        {
            InitializeComponent();
        }

        private void tb_localiza_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsNF_entrada.Tables["NOTA_FISCAL_ENTRADA"].DefaultView.RowFilter = "N_NF_ENTRADA = '" + tb_localiza.Text + "'";
            }
            catch { }
        }

        private void form_localiza_nf_entrada_Load(object sender, EventArgs e)
        {
            datNF_entrada.Fill(NOTA_FISCAL_ENTRADA);
            dgvNota_fiscal.AutoGenerateColumns = false;
            dgvNota_fiscal.DataSource = dsNF_entrada.Tables["NOTA_FISCAL_ENTRADA"];
                
        }

        private void dgvNota_fiscal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            nf_escolhida = dgvNota_fiscal.Rows[e.RowIndex].Cells["col_cod"].Value.ToString();
            this.Close();
        }
    }
}