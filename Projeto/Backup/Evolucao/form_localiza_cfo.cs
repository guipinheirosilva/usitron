using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_localiza_cfo : Form
    {
        public string cfo_escolhida;
        public string descricao_escolhida;
        public string nome_escolhido;
        public form_localiza_cfo()
        {
            InitializeComponent();
        }

        private void tb_cfo_TextChanged(object sender, EventArgs e)
        {
            dsCfo.Tables["CFO"].DefaultView.RowFilter = "descricao_cfo Like '" + tb_localiza.Text + "*'";
        }

        private void form_localiza_cfo_Load(object sender, EventArgs e)
        {
            datCfo.Fill(CFO);
            dgvCfo.AutoGenerateColumns = false;
            dgvCfo.DataSource = dsCfo.Tables["CFO"];
        }

        private void dgvCfo_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cfo_escolhida = dgvCfo.Rows[e.RowIndex].Cells["col_n_cfo"].Value.ToString();
            descricao_escolhida = dgvCfo.Rows[e.RowIndex].Cells["col_obs"].Value.ToString();
            nome_escolhido = dgvCfo.Rows[e.RowIndex].Cells["col_descricao"].Value.ToString();
            this.Close();
        }

        private void dgvCfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cfo_escolhida = dgvCfo.Rows[e.RowIndex].Cells["col_n_cfo"].Value.ToString();
            descricao_escolhida = dgvCfo.Rows[e.RowIndex].Cells["col_obs"].Value.ToString();
            nome_escolhido = dgvCfo.Rows[e.RowIndex].Cells["col_descricao"].Value.ToString();
            this.Close();
        }
    }
}