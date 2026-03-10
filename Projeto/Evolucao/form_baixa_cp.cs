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
    public partial class form_baixa_cp : Form
    {
        public string cod_cc, descricao_cc, carteira, data;
        public form_baixa_cp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form_cc cc = new form_cc();
            try
            {
                cc.ShowDialog();

            }
            finally
            {
                tb_descricao_cc.Text = cc.descricao_escolhido;
                tb_cod_cc.Text = cc.cod_escolhido;
            }
        }

        private void form_baixa_cp_Load(object sender, EventArgs e)
        {
            this.datCarteira.Fill(CARTEIRAS);

            cb_carteira.SelectedIndex = cb_carteira.FindStringExact(carteira);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cod_cc = tb_cod_cc.Text;
            descricao_cc = tb_descricao_cc.Text;
            data = Convert.ToDateTime(dt_pgto.Text).ToShortDateString();
            carteira = cb_carteira.Text;
            this.Close();
        }
    }
}
