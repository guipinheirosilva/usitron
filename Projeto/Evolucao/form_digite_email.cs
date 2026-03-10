using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_digite_email : Form
    {
        public string email;

        public form_digite_email()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_email.Text != "")
            {
                    email = tb_email.Text;
                    this.Close();                        
            }
            else
                MessageBox.Show("Digite um email para enviar a NFCe");
        }
    }
}
