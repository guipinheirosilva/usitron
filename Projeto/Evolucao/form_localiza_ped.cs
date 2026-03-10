using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_localiza_ped : Form
    {
        public string ped_escolhido;
        public form_localiza_ped()
        {
            InitializeComponent();
        }

        private void form_localiza_req_Load(object sender, EventArgs e)
        {
            datPedido_compra.Fill(PEDIDO_COMPRA);
            dgvPedido_compra.AutoGenerateColumns = false;
            dgvPedido_compra.DataSource = dsPedido_compra.Tables["PEDIDO_COMPRA"];
            tb_localiza.Focus();
        }

        private void tb_localiza_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsPedido_compra.Tables["PEDIDO_COMPRA"].DefaultView.RowFilter = "COD_PED = ('" + tb_localiza.Text + "')";
            }
            catch { }
        }

        private void dgvRequisicoes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ped_escolhido = dgvPedido_compra.Rows[e.RowIndex].Cells["col_cod"].Value.ToString();
            this.Close();
        }

        public string cod_usuario { get; set; }
    }
}