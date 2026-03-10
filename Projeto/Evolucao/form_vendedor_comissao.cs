using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_vendedor_comissao : Form
    {
        public string cod_vendedor, vendedor;
        public double comissao;
        public form_vendedor_comissao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cod_vendedor = txtCodVendedor.Text;
            vendedor = txtNomeVendedor.Text;
            comissao = 0;
            try
            {
                comissao = Convert.ToDouble(tb_comissao.Text);
            }
            catch { }
            this.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            form_vendedores vendedores = new form_vendedores();

            try
            {
                vendedores.ShowDialog();
            }
            finally
            {
                txtCodVendedor.Text = vendedores.cod_vendedor_escolhido;
                txtNomeVendedor.Text = vendedores.vendedor_escolhido;
            }
        }
    }
}
