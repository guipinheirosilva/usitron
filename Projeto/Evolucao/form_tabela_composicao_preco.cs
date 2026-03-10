using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_tabela_composicao_preco : Form
    {
        public form_tabela_composicao_preco()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
try
            {
                this.BindingContext[dsTabela_composicao_preco, "TABELA_COMPOSICAO_PRECO"].EndCurrentEdit();
                if (dsTabela_composicao_preco.HasChanges())
                {
                    fbConnection1.Open();
                    datTabela_composicao_preco.UpdateCommand = cbTabela_composicao_preco.GetUpdateCommand();
                    datTabela_composicao_preco.InsertCommand = cbTabela_composicao_preco.GetInsertCommand();
                    datTabela_composicao_preco.DeleteCommand = cbTabela_composicao_preco.GetDeleteCommand();
                    datTabela_composicao_preco.Update(dsTabela_composicao_preco, "TABELA_COMPOSICAO_PRECO");
                    dsTabela_composicao_preco.AcceptChanges();
                    fbConnection1.Close(); 
                }
            }
            catch (Exception a)
            {
                fbConnection1.Close(); 
                MessageBox.Show(a.ToString());
            }
        }

        private void form_tabela_composicao_preco_Load(object sender, EventArgs e)
        {
            datTabela_composicao_preco.Fill(TABELA_COMPOSICAO_PRECO);

            dgvTabela_composicao_preco.AutoGenerateColumns = false;
            dgvTabela_composicao_preco.DataSource = dsTabela_composicao_preco.Tables[0];
        }

        private void tb_cnpj_TextChanged(object sender, EventArgs e)
        {
            try
            {
               dsTabela_composicao_preco.Tables[0].DefaultView.RowFilter = "CNPJ_CLIENTE_TCP LIKE '*" + tb_cnpj.Text + "*'";
            }
            catch { }
        }

        private void tb_cliente_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsTabela_composicao_preco.Tables[0].DefaultView.RowFilter = "NOME_CLIENTE_TCP LIKE '*" + tb_cliente.Text + "*'";
            }
            catch { }
        }

        private void tb_tipo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsTabela_composicao_preco.Tables[0].DefaultView.RowFilter = "FRETE_TCP LIKE '*" + tb_tipo.Text + "*'";
            }
            catch { }
        }
    }
}