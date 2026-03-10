using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_erro : Form
    {
        public string erro;
        public form_erro()
        {
            InitializeComponent();
        }

        private void form_erro_Load(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(erro);
            }
            finally
            {
                this.Close();
            }
        }
    }
}