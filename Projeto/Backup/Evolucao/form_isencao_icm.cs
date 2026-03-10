using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_isencao_icm : Form
    {
        public string cliente_atual;
        public string isencao_icm;
        public form_isencao_icm()
        {
            InitializeComponent();
        }

        private void form_isencao_icm_Load(object sender, EventArgs e)
        {
            this.datClientes.SelectCommand.CommandText =
                "SELECT * FROM CLIENTES WHERE RAZAO_SOCIAL = '" + cliente_atual + "'";
            this.fbConnection1.Open();
            this.datClientes.SelectCommand.Connection = fbConnection1;
            this.datClientes.SelectCommand.ExecuteNonQuery();
            datClientes.Fill(CLIENTES);
            this.fbConnection1.Close();
        }

        private void bt_confirmar_Click(object sender, EventArgs e)
        {
            isencao_icm = tb_isencao.Text;
            this.Close();
        }
    }
}