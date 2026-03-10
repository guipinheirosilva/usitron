using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_localiza_transportadora : Form
    {
        public string transportadora_escolhida;
        public string cod_transportadora_escolhida;
        public form_localiza_transportadora()
        {
            InitializeComponent();
        }

        private void tb_localiza_TextChanged(object sender, EventArgs e)
        {
            dsTransportadora.Tables["TRANSPORTADORAS"].DefaultView.RowFilter = "razao_social_transportadora Like '*" + tb_localiza.Text + "*'";
        }

        private void form_localiza_transportadora_Load(object sender, EventArgs e)
        {
            datTransportadora.Fill(TRANSPORTADORAS);
            dgvTransportadora.AutoGenerateColumns = false;
            dgvTransportadora.DataSource = dsTransportadora.Tables["TRANSPORTADORAS"];
        }

        private void dgvTransportadora_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            transportadora_escolhida = dgvTransportadora.Rows[e.RowIndex].Cells["col_razao_social_transp"].Value.ToString();
            cod_transportadora_escolhida = dgvTransportadora.Rows[e.RowIndex].Cells["col_cod_transp"].Value.ToString(); 
            this.Close();
        }

        private void dgvTransportadora_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            transportadora_escolhida = dgvTransportadora.Rows[e.RowIndex].Cells["col_razao_social_transp"].Value.ToString();
            cod_transportadora_escolhida = dgvTransportadora.Rows[e.RowIndex].Cells["col_cod_transp"].Value.ToString(); 
            this.Close();
        }
    }
}