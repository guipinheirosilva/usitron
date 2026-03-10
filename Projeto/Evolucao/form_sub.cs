using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_sub : Form
    {
        public string coddesenho;
        public object cod_sub_atual;
        public form_sub()
        {
            
            InitializeComponent();
        }

        private void form_sub_Load(object sender, EventArgs e)
        {
            if (cod_sub_atual != null)
            {
                int qualquer = Convert.ToInt16(cod_sub_atual);
                MessageBox.Show(cod_sub_atual.ToString());
                datSub.Fill(SUB);
                datRotas.Fill(ROTAS);
                datTipos_operacoes.Fill(TIPOS_OPERACOES);
                datClientes.Fill(CLIENTES);
                datOp.Fill(OP);
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dsRotas.Tables["ROTAS"];
                dgvOp.AutoGenerateColumns = false;
                dgvOp.DataSource = dsOp.Tables["OP"];
                this.BindingContext[dsSub, "SUB"].Position = qualquer;
                cod_peca_desenhos.Focus();
            }
            else
            {
                datSub.Fill(SUB);
                datRotas.Fill(ROTAS);
                datTipos_operacoes.Fill(TIPOS_OPERACOES);
                datClientes.Fill(CLIENTES);
                datOp.Fill(OP);
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dsRotas.Tables["ROTAS"];
                Atualizar();
                this.BindingContext[dsSub, "SUB"].AddNew();
                cod_peca_desenhos.Focus();
                cod_peca_desenhos.Text = coddesenho;
            }
            
        }
        
                
        private void cod_peca_desenhos_TextChanged(object sender, EventArgs e)
        {
            dsRotas.Tables["ROTAS"].DefaultView.RowFilter = "Desenho Like '" + cod_peca_desenhos.Text + "'";
            dsOp.Tables["OP"].DefaultView.RowFilter = "desenho_op_atual Like '" + cod_peca_desenhos.Text + "'";
            
        }

        private void novo_registro_Click(object sender, EventArgs e)
        {
            Atualizar();
            this.BindingContext[dsSub, "SUB"].AddNew();
            cod_peca_desenhos.Focus();
            cod_peca_desenhos.Text = coddesenho;
        }

        private void vai_proximo_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsSub, "SUB"].Position++;
        }

        private void vai_anterior_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsSub, "SUB"].Position--;
        }
        private void Atualizar()
        {
            this.BindingContext[dsSub, "SUB"].EndCurrentEdit();
            fbConnection1.Open();
            if (dsSub.HasChanges())
            {
                datSub.UpdateCommand = cbSub.GetUpdateCommand();
                datSub.InsertCommand = cbSub.GetInsertCommand();
                datSub.DeleteCommand = cbSub.GetDeleteCommand();
                datSub.Update(dsSub, "SUB");
                dsSub.AcceptChanges();
            }
            //inserção na tabela de rotas
            this.BindingContext[dsRotas, "ROTAS"].EndCurrentEdit();
            if (dsRotas.HasChanges())
            {
                datRotas.UpdateCommand = cbRotas.GetUpdateCommand();
                datRotas.InsertCommand = cbRotas.GetInsertCommand();
                datRotas.DeleteCommand = cbRotas.GetDeleteCommand();
                datRotas.Update(dsRotas, "ROTAS");
                dsRotas.AcceptChanges();
            }
            fbConnection1.Close(); 
        }

        private void salva_registro_Click(object sender, EventArgs e)
        {
            Atualizar();
        }


          private void form_sub_FormClosing(object sender, FormClosingEventArgs e)
        {
            Atualizar();
        }

        private void form_sub_FormClosed(object sender, FormClosedEventArgs e)
        {
            Atualizar();
            form_peca fechar_form = new form_peca();
            
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_RowValidating_1(object sender, DataGridViewCellCancelEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells["desenho_coluna"].Value = cod_peca_desenhos.Text;
        }

        private void abre_op_Click(object sender, EventArgs e)
        {
            form_op op_form = new form_op();
            try
            {
                op_form.desenho_variavel = cod_peca_desenhos.Text;
                op_form.ShowDialog();
            }
            finally
            {
                op_form.Dispose();
            }
        }

        private void dgvOp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            form_op op_form = new form_op();
            try
            {
                op_form.cod_op_atual_variavel = dgvOp.Rows[e.RowIndex].Cells["cod_op_coluna"].Value;
                //MessageBox.Show("passou o paramento para o form");
                op_form.ShowDialog();
            }
            finally
            {
                op_form.Dispose();
            }
        }
    }
}