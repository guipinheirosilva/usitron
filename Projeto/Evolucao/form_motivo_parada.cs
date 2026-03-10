using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_motivo_parada : Form
    {
        public string _tipo_parada;
        public form_motivo_parada()
        {
            InitializeComponent();
        }

        private void form_motivo_parada_Load(object sender, EventArgs e)
        {
            datTipos_parada.Fill(TIPOS_PARADA);
        }

        private void cbTipo_parada_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbTipo_parada.Text == "Outros")
            {
                tb_outros.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbTipo_parada.Text != "Outros")
            {
                _tipo_parada = cbTipo_parada.Text;
                this.Close();
            }
            else
            {
                if (tb_outros.Text != "")
                {
                    _tipo_parada = tb_outros.Text;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Digite o motivo da parada");
                }
            }
        }
    }
}