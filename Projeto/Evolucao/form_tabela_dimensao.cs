using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_tabela_dimensao : Form
    {
        public string nome;
        public bool busca;

        public form_tabela_dimensao()
        {
            InitializeComponent();
        }

        private void form_tabela_dimensao_Load(object sender, EventArgs e)
        {
            try
            {
                datTab_dimensao.SelectCommand.CommandText =
                        "SELECT * FROM TAB_DIMENSAO ORDER BY COD_DIMENSAO";
                datTab_dimensao.SelectCommand.Connection = fbConnection1;
                fbConnection1.Open();
                datTab_dimensao.SelectCommand.ExecuteNonQuery();
                datTab_dimensao.Fill(TAB_DIMENSAO);
                fbConnection1.Close(); 

                dgvTab_dimensao.AutoGenerateColumns = false;
                dgvTab_dimensao.DataSource = dsTab_dimensao.Tables["TAB_DIMENSAO"];
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
                dsTab_dimensao.Tables["TAB_DIMENSAO"].DefaultView.RowFilter = "nome_dimensao like '*" + tbNome + "*'";
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
                this.BindingContext[dsTab_dimensao, "TAB_DIMENSAO"].EndCurrentEdit();
                fbConnection1.Open();
                if (dsTab_dimensao.HasChanges())
                {
                    datTab_dimensao.UpdateCommand = cbTab_dimensao.GetUpdateCommand();
                    datTab_dimensao.InsertCommand = cbTab_dimensao.GetInsertCommand();
                    datTab_dimensao.DeleteCommand = cbTab_dimensao.GetDeleteCommand();
                    datTab_dimensao.Update(dsTab_dimensao, "TAB_DIMENSAO");
                    dsTab_dimensao.AcceptChanges();
                }
                fbConnection1.Close(); 
            }

            catch (Exception a)
            {
                fbConnection1.Close(); 
                MessageBox.Show(a.ToString());
            }

        }

        private void dgvTab_dimensao_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (busca == true)
            {
                nome = dgvTab_dimensao.Rows[e.RowIndex].Cells["col_nome"].Value.ToString();
                this.Close();
            }
        }
    }
}