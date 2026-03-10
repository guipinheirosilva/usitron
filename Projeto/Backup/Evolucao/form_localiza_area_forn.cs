using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_localiza_area_forn : Form
    {
        public string area_escolhida;
        public string descricao_escolhida;
        public form_localiza_area_forn()
        {
            InitializeComponent();
        }

        private void form_localiza_area_forn_Load(object sender, EventArgs e)
        {
            datArea.Fill(AREA_ATUACAO_FORN);
            dgvArea.AutoGenerateColumns = false;
            dgvArea.DataSource = dsArea.Tables["AREA_ATUACAO_FORN"];
        }

        private void tb_localiza_TextChanged(object sender, EventArgs e)
        {
            dsArea.Tables["AREA_ATUACAO_FORN"].DefaultView.RowFilter = "descricao_area_forn Like '" + tb_localiza.Text + "*'";
        }

        private void dgvArea_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            area_escolhida = dgvArea.Rows[e.RowIndex].Cells["col_cod"].Value.ToString();
            descricao_escolhida = dgvArea.Rows[e.RowIndex].Cells["col_descricao"].Value.ToString();
            this.Close();
        }
    }
}