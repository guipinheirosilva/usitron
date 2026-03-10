using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_cc : Form
    {
        public string descricao_escolhido;
        public string cod_escolhido;
        public form_cc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsCc, "CONTAS_CORRENTES"].EndCurrentEdit();
            if (dsCc.HasChanges())
            {
                fbConnection1.Open();
                datCc.UpdateCommand = cbCc.GetUpdateCommand();
                datCc.InsertCommand = cbCc.GetInsertCommand();
                datCc.DeleteCommand = cbCc.GetDeleteCommand();
                datCc.Update(dsCc, "CONTAS_CORRENTES");
                dsCc.AcceptChanges();
                fbConnection1.Close(); 
            }
        }

        private void dgvCarteiras_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            descricao_escolhido = dgvCc.Rows[e.RowIndex].Cells["col_descricao"].Value.ToString();
            cod_escolhido = dgvCc.Rows[e.RowIndex].Cells["col_cod"].Value.ToString();
            this.Close();
        }

        private void form_carteiras_Load(object sender, EventArgs e)
        {
            datCc.Fill(CONTAS_CORRENTES);
        }

       
    }
}