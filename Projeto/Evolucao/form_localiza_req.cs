using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_localiza_req : Form
    {
        public string req_escolhida;
        public form_localiza_req()
        {
            InitializeComponent();
        }

        private void form_localiza_req_Load(object sender, EventArgs e)
        {
            datRequisicoes.Fill(REQUISICOES);
            dgvRequisicoes.AutoGenerateColumns = false;
            dgvRequisicoes.DataSource = dsRequisicoes.Tables["REQUISICOES"];
            tb_localiza.Focus();
        }

        private void tb_localiza_TextChanged(object sender, EventArgs e)
        {
            dsRequisicoes.Tables["REQUISICOES"].DefaultView.RowFilter = "REQUISITANTE_REQUISICAO like ('*" + tb_localiza.Text + "*')";
        }

        private void dgvRequisicoes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            req_escolhida = dgvRequisicoes.Rows[e.RowIndex].Cells["col_cod"].Value.ToString();
            this.Close();
        }
    }
}