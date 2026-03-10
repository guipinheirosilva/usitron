using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_tabela_material : Form
    {
        public string nome;
        public bool busca;

        public form_tabela_material()
        {
            InitializeComponent();
        }

        private void form_tabela_material_Load(object sender, EventArgs e)
        {
            try
            {
                datTab_material.SelectCommand.CommandText =
                    "SELECT * FROM TAB_MATERIAL ORDER BY COD_MATERIAL";
                datTab_material.SelectCommand.Connection = fbConnection1;
                fbConnection1.Open();
                datTab_material.SelectCommand.ExecuteNonQuery();
                datTab_material.Fill(TAB_MATERIAL);
                fbConnection1.Close(); 

                
                dgvTab_material.AutoGenerateColumns = false;
                dgvTab_material.DataSource = dsTab_material.Tables["TAB_MATERIAL"];
            }
            catch (Exception a)
            {

                fbConnection1.Close(); 
                MessageBox.Show(a.ToString());
            }

                  
               

        }

        private void tbNome_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsTab_material.Tables["TAB_MATERIAL"].DefaultView.RowFilter = "nome_material like '*"  + tbNome.Text + "*'";
            }
            catch{}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            salvar();
        }

        private void salvar()
        {
            try
            {
                this.BindingContext[dsTab_material, "TAB_MATERIAL"].EndCurrentEdit();
                fbConnection1.Open();
                if (dsTab_material.HasChanges())
                {
                    datTab_material.UpdateCommand = cbTab_material.GetUpdateCommand();
                    datTab_material.InsertCommand = cbTab_material.GetInsertCommand();
                    datTab_material.DeleteCommand = cbTab_material.GetDeleteCommand();
                    datTab_material.Update(dsTab_material, "TAB_MATERIAL");
                    dsTab_material.AcceptChanges();
                }
                fbConnection1.Close(); 
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
                fbConnection1.Close(); 
            }

        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
                            salvar();
        }

        private void dgvTab_material_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (busca == true)
            {
                nome = dgvTab_material.Rows[e.RowIndex].Cells["col_nome"].Value.ToString();
                this.Close();
            }

        }
    }
    }
