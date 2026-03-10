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
    public partial class formInput : Form
    {
        public string titulo;
        public string texto;
        public string retorno;

        public formInput()
        {
            InitializeComponent();
        }

        private void formInput_Load(object sender, EventArgs e)
        {
            this.Text = texto;
            labelTexto.Text = texto;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            retorno = tbRetorno.Text;
            this.Close();
        }
    }
}
