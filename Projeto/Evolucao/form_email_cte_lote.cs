using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_email_cte_lote : Form
    {
        public string email;
        public form_email_cte_lote()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            email = tb_email.Text;
            this.Close();
           
        }

        private void form_email_cte_lote_Load(object sender, EventArgs e)
        {

        }
    }
}