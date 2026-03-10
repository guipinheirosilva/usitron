using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_tabela_espessura : Form
    {
        public string nome;
        public bool busca;

        public form_tabela_espessura()
        {
            InitializeComponent();
        }

        private void form_tabela_espessura_Load(object sender, EventArgs e)
        {
            try
            {
                datTab_espessura.SelectCommand.CommandText =
                    "SELECT * FROM TAB_ESPESSURA ORDER BY COD_ESPESSURA";
                datTab_espessura.SelectCommand.Connection = fbConnection1;
                fbConnection1.Open();
                datTab_espessura.SelectCommand.ExecuteNonQuery();
                datTab_espessura.Fill(TAB_ESPESSURA);
                fbConnection1.Close();

                dgvTab_espessura.AutoGenerateColumns = false;
                dgvTab_espessura.DataSource = dsTab_espessura.Tables["TAB_ESPESSURA"];
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
                dsTab_espessura.Tables["TAB_ESPESSURA"].DefaultView.RowFilter = "nome_espessura like '*" + tbNome.Text + "*'";
            }
            catch { }
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
                            salvar();
        }

        private void salvar()
        {
            try
            {
                this.BindingContext[dsTab_espessura, "TAB_ESPESSURA"].EndCurrentEdit();
                fbConnection1.Open();
                if (dsTab_espessura.HasChanges())
                {
                    datTab_espessura.UpdateCommand = cbTab_espessura.GetUpdateCommand();
                    datTab_espessura.InsertCommand = cbTab_espessura.GetInsertCommand();
                    datTab_espessura.DeleteCommand = cbTab_espessura.GetDeleteCommand();
                    datTab_espessura.Update(dsTab_espessura, "TAB_ESPESSURA");
                    dsTab_espessura.AcceptChanges();
                }
                fbConnection1.Close();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void dgvTab_espessura_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (busca = true)
            {
                nome = dgvTab_espessura.Rows[e.RowIndex].Cells["col_nome"].Value.ToString();
                this.Close();
            }

        }
    }
}