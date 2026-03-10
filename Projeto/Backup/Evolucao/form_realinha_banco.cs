using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_realinha_banco : Form
    {
        public form_realinha_banco()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.datRotas_campo.UpdateCommand.CommandText =
                "UPDATE ROTAS_CAMPO SET OPERADOR_FINALIZADOR = NULL WHERE DATA_FECHAMENTO IS NULL";
            this.fbConnection1.Open();
            this.datRotas_campo.UpdateCommand.Connection = fbConnection1;
            this.datRotas_campo.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
            
        }
    }
}