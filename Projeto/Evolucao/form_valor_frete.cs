using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_valor_frete : Form
    {
        public double valor_frete;
        public form_valor_frete()
        {
            InitializeComponent();
        }

        private void form_valor_frete_Load(object sender, EventArgs e)
        {
            tb_valor_frete.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sair();
        }

        private void sair()
        {
            if (validar())
            {
                valor_frete = Convert.ToDouble(tb_valor_frete.Text);
                this.Close();
            }
            else
                MessageBox.Show("Valor Inválido");
        }

        private bool validar()
        {
            try
            {
                double valor = Convert.ToDouble(tb_valor_frete.Text);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void form_valor_frete_FormClosed(object sender, FormClosedEventArgs e)
        {
            sair();
        }

        private void tb_valor_frete_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                sair();
            }
        }
    }
}