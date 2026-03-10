using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_tabela_classificacao : Form
    {
        public string nome;
        public bool busca;

        public form_tabela_classificacao()
        {
            InitializeComponent();
        }

        private void form_tabela_classificacao_Load(object sender, EventArgs e)
        {
            try
            {
                datTab_classificacao.SelectCommand.CommandText =
                    "SELECT * FROM TAB_CLASSIFICACAO ORDER BY COD_CLASSIFICACAO";
                datTab_classificacao.SelectCommand.Connection = fbConnection1;
                fbConnection1.Open();
                datTab_classificacao.SelectCommand.ExecuteNonQuery();
                datTab_classificacao.Fill(TAB_CLASSIFICACAO);
                fbConnection1.Close(); 

                dgvTab_classificacao.AutoGenerateColumns = false;
                dgvTab_classificacao.DataSource = dsTab_classificacao.Tables["TAB_CLASSIFICACAO"];
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
                dsTab_classificacao.Tables["TAB_CLASSIFICACAO"].DefaultView.RowFilter = "nome_classificacao like '*" + tbNome.Text + "*'";
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
                this.BindingContext[dsTab_classificacao, "TAB_CLASSIFICACAO"].EndCurrentEdit();
                fbConnection1.Open();
                if (dsTab_classificacao.HasChanges())
                {
                    datTab_classificacao.UpdateCommand = cbTab_classificacao.GetUpdateCommand();
                    datTab_classificacao.InsertCommand = cbTab_classificacao.GetInsertCommand();
                    datTab_classificacao.DeleteCommand = cbTab_classificacao.GetDeleteCommand();
                    datTab_classificacao.Update(dsTab_classificacao, "TAB_CLASSIFICACAO");
                    dsTab_classificacao.AcceptChanges();
                }
                fbConnection1.Close(); 
            }

            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
                fbConnection1.Close(); 
            }


        }

        private void dgvTab_classificacao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvTab_classificacao_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (busca = true)
            {
                nome = dgvTab_classificacao.Rows[e.RowIndex].Cells["col_nome"].Value.ToString();
                this.Close();
            }

        }
    }
}