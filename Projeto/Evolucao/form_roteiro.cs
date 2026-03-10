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
    public partial class form_roteiro : Form
    {
        public int roteiro;
        public form_roteiro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                roteiro = Convert.ToInt32(tb_roteiro.Text);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Favor digitar o roteiro corretamente");
            }
        }

      
    }
}
