using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_localiza_requisicao : Form
    {
        public string requisicao_escolhida;
        public form_localiza_requisicao()
        {
            InitializeComponent();
        }

        private void tb_localiza_TextChanged(object sender, EventArgs e)
        {
            dsRequisicao.Tables["REQUISICAO"].DefaultView.RowFilter = "REQUISITANTE_REQUISICAO Like '" + tb_localiza.Text + "*'";
        }

        private void form_localiza_requisicao_Load(object sender, EventArgs e)
        {
            datRequisicao.Fill(REQUISICAO);
            dgvRequisicao.AutoGenerateColumns = false;
            dgvRequisicao.DataSource = dsRequisicao.Tables["REQUISICAO"];
        }

        private void dgvRequisicao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            requisicao_escolhida = dgvRequisicao.Rows[e.RowIndex].Cells[0].Value.ToString();
            //descricao_escolhida = dgvRequisicao.Rows[e.RowIndex].Cells["col_obs"].Value.ToString();
            this.Close();
        }
    }
}