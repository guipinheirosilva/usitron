using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_carteiras : Form
    {
        public string nome_escolhido;
        public form_carteiras()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsCarteiras, "CARTEIRAS"].EndCurrentEdit();
            if (dsCarteiras.HasChanges())
            {
                fbConnection1.Open();
                datCarteiras.UpdateCommand = cbCarteiras.GetUpdateCommand();
                datCarteiras.InsertCommand = cbCarteiras.GetInsertCommand();
                datCarteiras.DeleteCommand = cbCarteiras.GetDeleteCommand();
                datCarteiras.Update(dsCarteiras, "CARTEIRAS");
                dsCarteiras.AcceptChanges();
                fbConnection1.Close(); 
            }
        }

        private void dgvCarteiras_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            nome_escolhido = dgvCarteiras.Rows[e.RowIndex].Cells["col_nome"].Value.ToString();
            this.Close();
        }

        private void form_carteiras_Load(object sender, EventArgs e)
        {
            datCarteiras.Fill(CARTEIRAS);
        }
    }
}