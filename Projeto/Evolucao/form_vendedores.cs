using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_vendedores : Form
    {
        public string cod_vendedor_escolhido, vendedor_escolhido;
        public form_vendedores()
        {
            InitializeComponent();
        }

        private void form_vendedores_Load(object sender, EventArgs e)
        {
            datVendedores.Fill(VENDEDORES);
        }

        private void dgvVendedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.BindingContext[dsVendedores, "VENDEDORES"].EndCurrentEdit();
                if (dsVendedores.HasChanges())
                {
                    fbConnection1.Open();
                    datVendedores.UpdateCommand = cbVendedores.GetUpdateCommand();
                    datVendedores.InsertCommand = cbVendedores.GetInsertCommand();
                    datVendedores.DeleteCommand = cbVendedores.GetDeleteCommand();
                    datVendedores.Update(dsVendedores, "VENDEDORES");
                    dsVendedores.AcceptChanges();
                    fbConnection1.Close(); 
                }
            }
            catch
            {
                fbConnection1.Close(); 
            }
        }

        private void dgvVendedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvVendedores.Columns[e.ColumnIndex].Name == "col_metas")
            {
                form_metas_produto_vendedor metas = new form_metas_produto_vendedor();
                try
                {
                    metas.vendedor = dgvVendedores.Rows[e.RowIndex].Cells[1].Value.ToString();
                    metas.cod_vendedor = dgvVendedores.Rows[e.RowIndex].Cells[0].Value.ToString();
                    metas.Show();
                }
                finally
                {

                }
            }
        }

        private void dgvVendedores_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            cod_vendedor_escolhido = dgvVendedores.Rows[e.RowIndex].Cells["col_cod"].Value.ToString();
            vendedor_escolhido = dgvVendedores.Rows[e.RowIndex].Cells["col_nome"].Value.ToString();
            this.Close();
        }

        private void dgvVendedores_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvVendedores.Columns[e.ColumnIndex].Name == "col_metas")
            {
                form_metas_produto_vendedor metas = new form_metas_produto_vendedor();
                try
                {
                    metas.vendedor = dgvVendedores.Rows[e.RowIndex].Cells[1].Value.ToString();
                    metas.cod_vendedor = dgvVendedores.Rows[e.RowIndex].Cells[0].Value.ToString();
                    metas.Show();
                }
                finally
                {

                }
            }
        }

        
    }
}