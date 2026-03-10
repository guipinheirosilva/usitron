using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_fatura_produto : Form
    {
        public form_fatura_produto()
        {
            InitializeComponent();
        }

        private void form_fatura_produto_Load(object sender, EventArgs e)
        {
            datItens_ped_venda.Fill(ITENS_PEDIDO_VENDA);
            dgvItens_ped_venda.AutoGenerateColumns = false;
            dgvItens_ped_venda.DataSource = dsItens_ped_venda.Tables["ITENS_PED_VENDA"];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            form_vendedores vend = new form_vendedores();
            try
            {
                vend.ShowDialog();
            }
            finally
            {
                tb_cod_vendedor.Text = vend.cod_vendedor_escolhido;
                tb_nome_vendedor.Text = vend.vendedor_escolhido;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}