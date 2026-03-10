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
    public partial class form_desconto_pontualidade : Form
    {
        public double desconto;
        public int desconto_valor;
        public int desconto_pontualidade;
        public form_desconto_pontualidade()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                desconto_valor = 0;
                desconto_pontualidade = 0;
                if (rbDesconto_pontualidade.Checked)
                    desconto_pontualidade = 1;
                if (rbDesconto_valor.Checked)
                    desconto_valor = 1;

                desconto = Convert.ToDouble(tb_desconto.Text);
                this.Close();
            }
            catch {
                MessageBox.Show("Favor digitar o desconto corretamente");
            }
        }
    }
}
