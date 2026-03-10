using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_tabela_comprimento : Form
    {
        public string nome;
        public bool busca;

        public form_tabela_comprimento()
        {
            InitializeComponent();
        }

        private void form_tabela_comprimento_Load(object sender, EventArgs e)
        {
            try
            {
                datTab_comprimento.SelectCommand.CommandText =
                    "SELECT * FROM TAB_COMPRIMENTO ORDER BY COD_COMPRIMENTO";
                datTab_comprimento.SelectCommand.Connection = fbConnection1;
                fbConnection1.Open();
                datTab_comprimento.Fill(TAB_COMPRIMENTO);
                fbConnection1.Close();

                dgvTab_comprimento.AutoGenerateColumns = false;
                dgvTab_comprimento.DataSource = dsTab_comprimento.Tables["TAB_COMPRIMENTO"];
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
                dsTab_comprimento.Tables["TAB_COMPRIMENTO"].DefaultView.RowFilter = "nome_comprimento like '*" + tbNome.Text + "*'";
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
                this.BindingContext[dsTab_comprimento, "TAB_COMPRIMENTO"].EndCurrentEdit();
                fbConnection1.Open();
                if (dsTab_comprimento.HasChanges())
                {
                    datTab_comprimento.UpdateCommand = cbTab_comprimento.GetUpdateCommand();
                    datTab_comprimento.InsertCommand = cbTab_comprimento.GetInsertCommand();
                    datTab_comprimento.DeleteCommand = cbTab_comprimento.GetDeleteCommand();
                    datTab_comprimento.Update(dsTab_comprimento, "TAB_COMPRIMENTO");
                    dsTab_comprimento.AcceptChanges();
                }
                fbConnection1.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
                fbConnection1.Close();
                
            }
        }
        private void dgvTab_comprimento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (busca = true)
            {
                nome = dgvTab_comprimento.Rows[e.RowIndex].Cells["col_nome"].Value.ToString();
                this.Close();
            }

        }
    }
}
