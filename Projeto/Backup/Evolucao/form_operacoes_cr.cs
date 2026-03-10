using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_operacoes_cr : Form
    {
        public string cod_a_abrir;
        public bool adicionar, excluir, multiplicar, alterar;
        public form_operacoes_cr()
        {
            InitializeComponent();
        }

        private void form_operacoes_cr_Load(object sender, EventArgs e)
        {
            
        }

        private void alterar_cr()
        {
            try
            {
                this.datContas_a_receber.SelectCommand.CommandText =
                    "SELECT * FROM CONTAS_A_RECEBER WHERE COD_CR = '" + cod_a_abrir + "'";
                this.fbConnection1.Open();
                this.datContas_a_receber.SelectCommand.Connection = fbConnection1;
                this.datContas_a_receber.SelectCommand.ExecuteNonQuery();
                datContas_a_receber.Fill(CONTAS_A_RECEBER);
                this.fbConnection1.Close();

            }
            catch
            {
                MessageBox.Show("Erro na seleção de uma conta a receber.");
                fbConnection1.Close();
            }
        }

        private void excluir_cr()
        {
            if (DialogResult.Yes == MessageBox.Show("O registro será excluído permanentemente, tem certeza?",
               "Confirma a exclusão?", MessageBoxButtons.YesNo))
            {
                try
                {
                    this.datContas_a_receber.DeleteCommand.CommandText =
                        "DELETE FROM CONTAS_A_RECEBER WHERE COD_CR = '" + tb_cod.Text + "'";
                    this.fbConnection1.Open();
                    this.datContas_a_receber.DeleteCommand.Connection = fbConnection1;
                    this.datContas_a_receber.DeleteCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Erro ao excluir registro");
                    fbConnection1.Close();
                }
            }
        }

        private void adicionar_cr()
        {
            try
            {
                this.datContas_a_receber.DeleteCommand.CommandText =
                    "DELETE FROM CONTAS_A_RECEBER WHERE RAZAO_CLIENTE_CR = 'NOVO'";
                this.fbConnection1.Open();
                this.datContas_a_receber.DeleteCommand.Connection = fbConnection1;
                this.datContas_a_receber.DeleteCommand.ExecuteNonQuery();
                this.fbConnection1.Close();

                this.datContas_a_receber.InsertCommand.CommandText =
                "INSERT INTO CONTAS_A_RECEBER (RAZAO_CLIENTE_CR) " +
                "VALUES ('NOVO')";
                this.fbConnection1.Open();
                this.datContas_a_receber.InsertCommand.Connection = fbConnection1;
                this.datContas_a_receber.InsertCommand.ExecuteNonQuery();
                this.fbConnection1.Close();

                this.datContas_a_receber.SelectCommand.CommandText =
                    "SELECT * FROM CONTAS_A_RECEBER WHERE RAZAO_CLIENTE_CR = 'NOVO'";
                this.fbConnection1.Open();
                this.datContas_a_receber.SelectCommand.Connection = fbConnection1;
                this.datContas_a_receber.SelectCommand.ExecuteNonQuery();
                datContas_a_receber.Fill(CONTAS_A_RECEBER);
                this.fbConnection1.Close();
                
            }
            catch {
                MessageBox.Show("Erro na inserção de uma nova conta a receber.");
                fbConnection1.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            form_localiza_cliente cliente = new form_localiza_cliente(true);
            try
            {
                cliente.ShowDialog();

            }
            finally
            {
                tb_nome_forn.Text = cliente.cliente_escolhido;
                tb_cod_forn.Text = detectar_cod_cliente(tb_nome_forn.Text);
            }
        }

        private string detectar_cod_cliente(string nome_cliente)
        {
            string _nome_cli = "", _cod_cli = "";
            comando_select.CommandText = "SELECT * FROM CLIENTES WHERE RAZAO_SOCIAL = '" + nome_cliente + "'";
            DataSet cli = new DataSet();
            fbConnection1.Open();
            datClientes.SelectCommand = comando_select;
            datClientes.Fill(cli);
            fbConnection1.Close();
            foreach (DataRow dr in cli.Tables[0].Rows)
            {
                _nome_cli = dr["RAZAO_SOCIAL"].ToString();
                _cod_cli = dr["COD_CLIENTE"].ToString();
            }
            return _cod_cli;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form_planos planos = new form_planos();
            try
            {
                planos.ShowDialog();

            }
            finally
            {
                tb_planos.Text = planos.nome_escolhido;
                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            form_carteiras carteiras = new form_carteiras();
            try
            {
                carteiras.ShowDialog();

            }
            finally
            {
                tb_carteira.Text = carteiras.nome_escolhido;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Atualizar();
        }

        private void Atualizar()
        {
            this.BindingContext[dsContas_a_receber, "CONTAS_A_RECEBER"].EndCurrentEdit();
            if (dsContas_a_receber.HasChanges())
            {
                fbConnection1.Open();
                datContas_a_receber.UpdateCommand = cbContas_a_receber.GetUpdateCommand();
                datContas_a_receber.InsertCommand = cbContas_a_receber.GetInsertCommand();
                datContas_a_receber.DeleteCommand = cbContas_a_receber.GetDeleteCommand();
                datContas_a_receber.Update(dsContas_a_receber, "CONTAS_A_RECEBER");
                dsContas_a_receber.AcceptChanges();
                fbConnection1.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void form_operacoes_cr_Load_1(object sender, EventArgs e)
        {
            if (cod_a_abrir != null)
            {
                try
                {
                    this.datContas_a_receber.SelectCommand.CommandText =
                    "SELECT * FROM CONTAS_A_RECEBER WHERE COD_CR = '" + cod_a_abrir + "'";
                    this.fbConnection1.Open();
                    this.datContas_a_receber.SelectCommand.Connection = fbConnection1;
                    this.datContas_a_receber.SelectCommand.ExecuteNonQuery();
                    datContas_a_receber.Fill(CONTAS_A_RECEBER);
                    this.fbConnection1.Close();
                }
                catch
                {
                    MessageBox.Show("Erro na abertura");
                    fbConnection1.Close();
                }

            }
            if (adicionar == true)
            {
                adicionar_cr();
            }
            if (excluir == true)
            {
                excluir_cr();
            }
            if (multiplicar == true)
            {
                //multiplicar_cr();
            }
            if (alterar == true)
            {
                alterar_cr();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            form_planos planos = new form_planos();
            try
            {
                planos.ShowDialog();

            }
            finally
            {
                tb_planos.Text = planos.nome_escolhido;
                tb_cod_plano.Text = planos.cod_escolhido;
            }
        }
    }
}