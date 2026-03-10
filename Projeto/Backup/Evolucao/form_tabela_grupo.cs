using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_tabela_grupo : Form
    {
        public string nome;
        public bool busca;

        public form_tabela_grupo()
        {
            InitializeComponent();
        }

        private void form_tabela_grupo_Load(object sender, EventArgs e)
        {
            try
            {
                datTab_grupo.SelectCommand.CommandText =
                    "SELECT * FROM TAB_GRUPO ORDER BY COD_GRUPO";
                datTab_grupo.SelectCommand.Connection = fbConnection1;
                fbConnection1.Open();
                datTab_grupo.SelectCommand.ExecuteNonQuery();
                datTab_grupo.Fill(TAB_GRUPO);
                fbConnection1.Close();

                dgvTab_grupo.AutoGenerateColumns = false;
                dgvTab_grupo.DataSource = dsTab_grupo.Tables["TAB_GRUPO"];
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
                dsTab_grupo.Tables["TAB_GRUPO"].DefaultView.RowFilter = "nome_grupo like '*" + tbNome.Text + "*'";
            }
            catch { }



        }

        private void button1_Click(object sender, EventArgs e)
        {
                            salvar();
        }

        private void salvar()
        {
            try
            {
                this.BindingContext[dsTab_grupo, "TAB_GRUPO"].EndCurrentEdit();
                fbConnection1.Open();
                if (dsTab_grupo.HasChanges())
                {
                    datTab_grupo.UpdateCommand = cbTab_grupo.GetUpdateCommand();
                    datTab_grupo.InsertCommand = cbTab_grupo.GetInsertCommand();
                    datTab_grupo.DeleteCommand = cbTab_grupo.GetDeleteCommand();
                    datTab_grupo.Update(dsTab_grupo, "TAB_GRUPO");
                    dsTab_grupo.AcceptChanges();

                }
                fbConnection1.Close();
                
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
                fbConnection1.Close();
            }
        }

        private void dgvTab_grupo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (busca == true)
            {
                nome = dgvTab_grupo.Rows[e.RowIndex].Cells["col_nome"].Value.ToString();
                this.Close();
            }
        }

        private void dgvTab_grupo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void datTab_grupo_RowUpdated(object sender, FirebirdSql.Data.FirebirdClient.FbRowUpdatedEventArgs e)
        {

        }

        private void fbConnection1_InfoMessage(object sender, FirebirdSql.Data.FirebirdClient.FbInfoMessageEventArgs e)
        {

        }
    }
}