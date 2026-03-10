using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_operacoes_cp : Form
    {
        public string cod_a_abrir;
        public bool adicionar, excluir, multiplicar, alterar;
        public form_operacoes_cp()
        {
            InitializeComponent();
        }

        private void form_operacoes_cp_Load(object sender, EventArgs e)
        {
            
            if (adicionar == true)
            {
                adicionar_cp();
            }
            if (excluir == true)
            {
                excluir_cp();
            }
            if (multiplicar == true)
            {
                //multiplicar_cp();
            }
            if (alterar == true)
            {
                alterar_cp();
            }
        }

        private void alterar_cp()
        {
            try
            {
                this.datContas_a_pagar.SelectCommand.CommandText =
                    "SELECT * FROM CONTAS_A_PAGAR WHERE COD_CP = '" + cod_a_abrir + "'";
                this.fbConnection1.Open();
                this.datContas_a_pagar.SelectCommand.Connection = fbConnection1;
                this.datContas_a_pagar.SelectCommand.ExecuteNonQuery();
                datContas_a_pagar.Fill(CONTAS_A_PAGAR);
                this.fbConnection1.Close();

            }
            catch
            {
                MessageBox.Show("Erro na seleção de uma conta a pagar.");
                fbConnection1.Close();
            }
        }

        private void excluir_cp()
        {
            if (DialogResult.Yes == MessageBox.Show("O registro será excluído permanentemente, tem certeza?",
               "Confirma a exclusão?", MessageBoxButtons.YesNo))
            {
                try
                {
                    try
                    {
                        this.datContas_a_pagar.SelectCommand.CommandText =
                        "SELECT * FROM CONTAS_A_PAGAR WHERE COD_CP = '" + cod_a_abrir + "'";
                        this.fbConnection1.Open();
                        this.datContas_a_pagar.SelectCommand.Connection = fbConnection1;
                        this.datContas_a_pagar.SelectCommand.ExecuteNonQuery();
                        datContas_a_pagar.Fill(CONTAS_A_PAGAR);
                        this.fbConnection1.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Erro na abertura");
                        fbConnection1.Close();
                    }
                    this.datContas_a_pagar.DeleteCommand.CommandText =
                        "DELETE FROM CONTAS_A_PAGAR WHERE COD_CP = '" + tb_cod.Text + "'";
                    this.fbConnection1.Open();
                    this.datContas_a_pagar.DeleteCommand.Connection = fbConnection1;
                    this.datContas_a_pagar.DeleteCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Erro ao apagar registro");
                    fbConnection1.Close();
                }
            }
        }

        private void adicionar_cp()
        {
            try
            {
                this.datContas_a_pagar.DeleteCommand.CommandText =
                    "DELETE FROM CONTAS_A_PAGAR WHERE RAZAO_FORNECEDOR_CP = 'NOVO'";
                this.fbConnection1.Open();
                this.datContas_a_pagar.DeleteCommand.Connection = fbConnection1;
                this.datContas_a_pagar.DeleteCommand.ExecuteNonQuery();
                this.fbConnection1.Close();

                this.datContas_a_pagar.InsertCommand.CommandText =
                "INSERT INTO CONTAS_A_PAGAR (RAZAO_FORNECEDOR_CP) " +
                "VALUES ('NOVO')";
                this.fbConnection1.Open();
                this.datContas_a_pagar.InsertCommand.Connection = fbConnection1;
                this.datContas_a_pagar.InsertCommand.ExecuteNonQuery();
                this.fbConnection1.Close();

                this.datContas_a_pagar.SelectCommand.CommandText =
                    "SELECT * FROM CONTAS_A_PAGAR WHERE RAZAO_FORNECEDOR_CP = 'NOVO'";
                this.fbConnection1.Open();
                this.datContas_a_pagar.SelectCommand.Connection = fbConnection1;
                this.datContas_a_pagar.SelectCommand.ExecuteNonQuery();
                datContas_a_pagar.Fill(CONTAS_A_PAGAR);
                this.fbConnection1.Close();
                
            }
            catch {
                MessageBox.Show("Erro na inserção de uma nova conta a pagar.");
                fbConnection1.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            form_localiza_forn forn = new form_localiza_forn(true);
            try
            {
                forn.ShowDialog();

            }
            finally
            {
                tb_nome_forn.Text = forn.razao_forn_escolhido;
                tb_cod_forn.Text = detectar_cod_fornecedor(tb_nome_forn.Text);
            }
        }

        private string detectar_cod_fornecedor(string nome_forn)
        {
            string _nome_forn = "", _cod_forn = "";
            comando_select.CommandText = "SELECT * FROM FORNECEDORES WHERE RAZAO_SOCIAL_FORN = '" + nome_forn + "'";
            DataSet forn = new DataSet();
            fbConnection1.Open();
            datForn.SelectCommand = comando_select;
            datForn.Fill(forn);
            fbConnection1.Close();
            foreach (DataRow dr in forn.Tables[0].Rows)
            {
                _nome_forn = dr["RAZAO_SOCIAL_FORN"].ToString();
                _cod_forn = dr["COD_FORN"].ToString();
            }
            return _cod_forn;
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
                tb_cod_plano.Text = planos.cod_escolhido;
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
            this.BindingContext[dsContas_a_pagar, "CONTAS_A_PAGAR"].EndCurrentEdit();
            if (dsContas_a_pagar.HasChanges())
            {
                fbConnection1.Open();
                datContas_a_pagar.UpdateCommand = cbContas_a_pagar.GetUpdateCommand();
                datContas_a_pagar.InsertCommand = cbContas_a_pagar.GetInsertCommand();
                datContas_a_pagar.DeleteCommand = cbContas_a_pagar.GetDeleteCommand();
                datContas_a_pagar.Update(dsContas_a_pagar, "CONTAS_A_PAGAR");
                dsContas_a_pagar.AcceptChanges();
                fbConnection1.Close();
            }
        }
    }
}