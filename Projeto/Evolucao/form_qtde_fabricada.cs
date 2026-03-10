using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_qtde_fabricada : Form
    {
        
        public int qtde;
        public string op; public string rota;
        public form_qtde_fabricada()
        {
            InitializeComponent();
        }

        private void form_qtde_fabricada_Load(object sender, EventArgs e)
        {
            OPlabel.Text = rota;
            tb_qtde.Focus();
        }

        private void tb_qtde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                if (tb_qtde.Text != "")
                {
                    try
                    {
                        qtde = Convert.ToInt32(tb_qtde.Text);
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Digite a quantidade corretamente");
                    }

                }
                else
                {
                    MessageBox.Show("Digite a quantidade corretamente");
                }
            }
        }
    }
}