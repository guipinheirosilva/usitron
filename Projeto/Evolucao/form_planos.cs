using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_planos : Form
    {
        public string nome_escolhido;
        public string cod_escolhido;
        public form_planos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsPlanos, "PLANOS"].EndCurrentEdit();
            if (dsPlanos.HasChanges())
            {
                fbConnection1.Open();
                datPlanos.UpdateCommand = cbPlanos.GetUpdateCommand();
                datPlanos.InsertCommand = cbPlanos.GetInsertCommand();
                datPlanos.DeleteCommand = cbPlanos.GetDeleteCommand();
                datPlanos.Update(dsPlanos, "PLANOS");
                dsPlanos.AcceptChanges();
                fbConnection1.Close(); 
            }
        }

        private void dgvPlanos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            nome_escolhido = dgvPlanos.Rows[e.RowIndex].Cells["col_nome"].Value.ToString();
            cod_escolhido = dgvPlanos.Rows[e.RowIndex].Cells["col_cod"].Value.ToString();
            this.Close();
        }

        private void form_planos_Load(object sender, EventArgs e)
        {
            datPlanos.Fill(PLANOS);
            datGrupo_planos.Fill(GRUPO_PLANOS);
            dgvPlanos.AutoGenerateColumns = false;
            dgvPlanos.DataSource = dsPlanos.Tables["PLANOS"];
        }

        private void tb_nome_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsPlanos.Tables["PLANOS"].DefaultView.RowFilter = "NOME_PLANO Like '*" + tb_nome.Text + "*'";
            }
            catch { }
        }

        
        
    }
}