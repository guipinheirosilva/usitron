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
    public partial class form_tp_opcoes : Form
    {
        public string tipo;
        public string estado;
        public form_tp_opcoes()
        {
            InitializeComponent();
        }

        private void form_tp_opcoes_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbTipo.Text != "" || cbEstado.Text != "")
            {
                tipo = cbTipo.Text;
                estado = cbEstado.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("Selecione o tipo e o restado para gerar a tabela");
            }

        }
    }
}
