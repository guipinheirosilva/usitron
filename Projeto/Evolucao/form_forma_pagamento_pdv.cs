using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_forma_pagamento_pdv : Form
    {
        public string forma_pgto;
        public form_forma_pagamento_pdv()
        {
            InitializeComponent();
        }

        private void cbListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void form_forma_pagamento_pdv_Load(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            forma_pgto = comboBox1.Text;
            if(forma_pgto !="")
                this.Close();
        }
    }
}
