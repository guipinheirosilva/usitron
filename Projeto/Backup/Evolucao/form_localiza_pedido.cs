using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_localiza_pedido : Form
    {
        public string pedido_escolhido;
        public form_localiza_pedido()
        {
            InitializeComponent();
        }

        private void form_localiza_nf_Load(object sender, EventArgs e)
        {
            datPedidos_venda.Fill(PEDIDOS_VENDA);
            dgvPedidos.AutoGenerateColumns = false;
            dgvPedidos.DataSource = dsPedidos_venda.Tables["PEDIDOS_VENDA"];
        }

        private void tb_localiza_TextChanged(object sender, EventArgs e)
        {
            dsPedidos_venda.Tables["PEDIDOS_VENDA"].DefaultView.RowFilter = "COD_PED_VENDA = '" + tb_localiza.Text + "'";
        }

        private void dgvNota_fiscal_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            pedido_escolhido = dgvPedidos.Rows[e.RowIndex].Cells["col_cod"].Value.ToString();
            this.Close();
        }

        private void dgvNota_fiscal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}