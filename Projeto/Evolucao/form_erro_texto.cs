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
    public partial class form_erro_texto : Form
    {
        public string mensagem;
        public form_erro_texto()
        {
            InitializeComponent();
        }

        private void form_erro_texto_Load(object sender, EventArgs e)
        {
            textBox1.Text = mensagem;
        }
    }
}
