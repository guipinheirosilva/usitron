using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_tabela_acabamento : Form
    {
        public string nome;
        public bool busca;

        public form_tabela_acabamento()
        {
            InitializeComponent();
        }

        private void form_tabela_acabamento_Load(object sender, EventArgs e)
        {
            try
            {
                datTab_acabamento.SelectCommand.CommandText =
                    "SELECT * FROM TAB_ACABAMENTO ORDER BY COD_ACABAMENTO";
                datTab_acabamento.SelectCommand.Connection = fbConnection1;
                fbConnection1.Open();
                datTab_acabamento.SelectCommand.ExecuteNonQuery();
                datTab_acabamento.Fill(TAB_ACABAMENTO);
                fbConnection1.Close(); 

                dgvTab_acabamento.AutoGenerateColumns = false;
               // dgvTab_acabamento.DataSource = dsTab_acabamento.Tables["TAB_ACABAMENTO"];
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
                dsTab_acabamento.Tables["TAB_ACABAMENTO"].DefaultView.RowFilter = "nome_acabamento like '*" + tbNome.Text + "*'";
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
                this.BindingContext[dsTab_acabamento, "TAB_ACABAMENTO"].EndCurrentEdit();
                fbConnection1.Open();
                if (dsTab_acabamento.HasChanges())
                {
                    datTab_acabamento.UpdateCommand = cbTab_acabamento.GetUpdateCommand();
                    datTab_acabamento.InsertCommand = cbTab_acabamento.GetInsertCommand();
                    datTab_acabamento.DeleteCommand = cbTab_acabamento.GetDeleteCommand();
                    datTab_acabamento.Update(dsTab_acabamento, "TAB_ACABAMENTO");
                    dsTab_acabamento.AcceptChanges();
                }
                fbConnection1.Close(); 
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
                fbConnection1.Close(); 
            }


        }

        

        private void dgvTab_acabamento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (busca == true)
            {
                nome = dgvTab_acabamento.Rows[e.RowIndex].Cells["col_nome"].Value.ToString();
                this.Close();
            }

        }
    }
}