using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_operacoes_caixa : Form
    {
        public string cod_a_abrir;
        public string[] cp_cr_a_vincular = new string[200];
        public int n_baixas;
        public bool transferencia;
        public bool debito, credito;
        public bool adicionar, excluir, multiplicar, alterar;
        public string descricao_trans;
        public string valor_trans;
        public string data_trans;
        public string cod_cc_trans;
        public string descricao_cc_trans;

        //baixa_retorno
        public decimal valor_baixa;
        public DateTime data_baixa;


        public form_operacoes_caixa()
        {
            InitializeComponent();
        }

        private void form_caixa_Load(object sender, EventArgs e)
        {

            if (adicionar == true)
            {
                adicionar_caixa();
            }
            if (excluir == true)
            {
                excluir_caixa();
            }
            if (multiplicar == true)
            {
                //multiplicar_cp();
            }
            if (alterar == true)
            {
                alterar_caixa();
            }
        }

        private void alterar_caixa()
        {
            try
            {
                this.datCaixa.SelectCommand.CommandText =
                    "SELECT * FROM CAIXA WHERE COD_CAIXA = '" + cod_a_abrir + "'";
                this.fbConnection1.Open();
                this.datCaixa.SelectCommand.Connection = fbConnection1;
                this.datCaixa.SelectCommand.ExecuteNonQuery();
                datCaixa.Fill(CAIXA);
                this.fbConnection1.Close(); 

            }
            catch
            {
                MessageBox.Show("Erro na seleção de uma conta a pagar.");
                fbConnection1.Close(); 
            }
        }

        private void excluir_caixa()
        {
            if (DialogResult.Yes == MessageBox.Show("O registro será excluído permanentemente, tem certeza?",
               "Confirma a exclusão?", MessageBoxButtons.YesNo))
            {
                try
                {
                    try
                    {
                        this.datCaixa.SelectCommand.CommandText =
                        "SELECT * FROM CAIXA WHERE COD_CAIXA = '" + cod_a_abrir + "'";
                        this.fbConnection1.Open();
                        this.datCaixa.SelectCommand.Connection = fbConnection1;
                        this.datCaixa.SelectCommand.ExecuteNonQuery();
                        datCaixa.Fill(CAIXA);
                        this.fbConnection1.Close(); 
                    }
                    catch
                    {
                        MessageBox.Show("Erro na abertura");
                        fbConnection1.Close(); 
                    }
                    voltar_cp_cr();
                    this.datCaixa.DeleteCommand.CommandText =
                        "DELETE FROM CAIXA WHERE COD_CAIXA = '" + tb_cod.Text + "'";
                    this.fbConnection1.Open();
                    this.datCaixa.DeleteCommand.Connection = fbConnection1;
                    this.datCaixa.DeleteCommand.ExecuteNonQuery();
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

        private void voltar_cp_cr()
        {
            if (rb_Credito.Checked == true)
            {
                try
                {
                    if (tb_cr_cp.Text != "")
                    {
                        this.datContas_a_receber.UpdateCommand.CommandText =
                        "UPDATE CONTAS_A_RECEBER SET RECEBIDO_CR = '0' WHERE COD_CR = '" + tb_cr_cp.Text + "'";
                        this.fbConnection1.Open();
                        this.datContas_a_receber.UpdateCommand.Connection = fbConnection1;
                        this.datContas_a_receber.UpdateCommand.ExecuteNonQuery();
                        this.fbConnection1.Close(); 

                        this.datContas_a_receber.UpdateCommand.CommandText =
                        "UPDATE CONTAS_A_RECEBER SET DATA_RECEBIMENTO_CR = null WHERE COD_CR = '" + tb_cr_cp.Text + "'";
                        this.fbConnection1.Open();
                        this.datContas_a_receber.UpdateCommand.Connection = fbConnection1;
                        this.datContas_a_receber.UpdateCommand.ExecuteNonQuery();
                        this.fbConnection1.Close(); 

                        this.datContas_a_receber.UpdateCommand.CommandText =
                       "UPDATE CONTAS_A_RECEBER SET COD_CAIXA_CR = null WHERE COD_CR = '" + tb_cr_cp.Text + "'";
                        this.fbConnection1.Open();
                        this.datContas_a_receber.UpdateCommand.Connection = fbConnection1;
                        this.datContas_a_receber.UpdateCommand.ExecuteNonQuery();
                        this.fbConnection1.Close(); 

                    }
                }
                catch
                {
                    fbConnection1.Close(); 
                    MessageBox.Show("Erro ao voltar o Contas a Receber");
                }
            }
            if (rb_Debito.Checked == true)
            {
                try
                {
                    if (tb_cr_cp.Text != "")
                    {
                        this.datContas_a_pagar.UpdateCommand.CommandText =
                        "UPDATE CONTAS_A_PAGAR SET PAGO_CP = '0' WHERE COD_CP = '" + tb_cr_cp.Text + "'";
                        this.fbConnection1.Open();
                        this.datContas_a_pagar.UpdateCommand.Connection = fbConnection1;
                        this.datContas_a_pagar.UpdateCommand.ExecuteNonQuery();
                        this.fbConnection1.Close(); 

                        this.datContas_a_pagar.UpdateCommand.CommandText =
                        "UPDATE CONTAS_A_PAGAR SET DATA_PAGAMENTO_CP = null WHERE COD_CP = '" + tb_cr_cp.Text + "'";
                        this.fbConnection1.Open();
                        this.datContas_a_pagar.UpdateCommand.Connection = fbConnection1;
                        this.datContas_a_pagar.UpdateCommand.ExecuteNonQuery();
                        this.fbConnection1.Close(); 

                        this.datContas_a_pagar.UpdateCommand.CommandText =
                        "UPDATE CONTAS_A_PAGAR SET COD_CAIXA_CP = null WHERE COD_CP = '" + tb_cr_cp.Text + "'";
                        this.fbConnection1.Open();
                        this.datContas_a_pagar.UpdateCommand.Connection = fbConnection1;
                        this.datContas_a_pagar.UpdateCommand.ExecuteNonQuery();
                        this.fbConnection1.Close(); 


                    }
                }
                catch
                {
                    fbConnection1.Close(); 
                    MessageBox.Show("Erro ao voltar o Contas a Pagar");
                }
            }
        }
        private void adicionar_caixa()
        {
            try
            {
                this.datCaixa.DeleteCommand.CommandText =
                    "DELETE FROM CAIXA WHERE DESCRICAO_CAIXA = 'NOVO'";
                this.fbConnection1.Open();
                this.datCaixa.DeleteCommand.Connection = fbConnection1;
                this.datCaixa.DeleteCommand.ExecuteNonQuery();
                this.fbConnection1.Close(); 

                this.datCaixa.InsertCommand.CommandText =
                "INSERT INTO CAIXA (DESCRICAO_CAIXA) " +
                "VALUES ('NOVO')";
                this.fbConnection1.Open();
                this.datCaixa.InsertCommand.Connection = fbConnection1;
                this.datCaixa.InsertCommand.ExecuteNonQuery();
                this.fbConnection1.Close(); 

                this.datCaixa.SelectCommand.CommandText =
                    "SELECT * FROM CAIXA WHERE DESCRICAO_CAIXA = 'NOVO'";
                this.fbConnection1.Open();
                this.datCaixa.SelectCommand.Connection = fbConnection1;
                this.datCaixa.SelectCommand.ExecuteNonQuery();
                datCaixa.Fill(CAIXA);
                this.fbConnection1.Close(); 
                if (cp_cr_a_vincular != null)
                {
                    if (debito == true)
                    {

                        rb_Debito.Checked = true;
                        vincular_cr_cp(cp_cr_a_vincular);
                    }
                    if (credito == true)
                    {
                        rb_Credito.Checked = true;
                        vincular_cr_cp(cp_cr_a_vincular);
                        if (data_baixa != null && data_baixa != Convert.ToDateTime("01/01/0001"))
                        {
                            Atualizar();
                            baixar_cp_cr();
                            this.Close();
                        }
                    }
                }
                if (transferencia == true)
                {
                    if (debito == true)
                    {
                        tb_descricao.Text = descricao_trans;
                        tb_valor.Text = valor_trans;
                        tb_data.Text = data_trans;
                        tb_cod_cc.Text = cod_cc_trans;
                        tb_descricao_cc.Text = descricao_cc_trans;
                        rb_Debito.Checked = true;
                    }
                    if (credito == true)
                    {
                        tb_descricao.Text = descricao_trans;
                        tb_valor.Text = valor_trans;
                        tb_data.Text = data_trans;
                        tb_cod_cc.Text = cod_cc_trans;
                        tb_descricao_cc.Text = descricao_cc_trans;
                        rb_Credito.Checked = true;
                    }
                    Atualizar();
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Erro na inserção de uma novo item no caixa.");
                fbConnection1.Close(); 
            }
        }

        private void vincular_cr_cp(string[] cod)
        {
            string _cod = "", _descricao = "", _cod_cli_forn = "", _razao_cli_forn = "", _duplicata = "", _nf = "", _plano = "", _carteira = "", _cod_plano = "", _cc = "", _descricao_cc = "";
            double _valor = 0;
            if (rb_Credito.Checked == true)
            {
                for (int i = 0; i < n_baixas; i++)
                {
                    comando_select.CommandText = "SELECT * FROM CONTAS_A_RECEBER WHERE COD_CR = '" + cod[i] + "'";
                    DataSet cli = new DataSet();
                    fbConnection1.Open();
                    datContas_a_receber.SelectCommand = comando_select;
                    datContas_a_receber.Fill(cli);
                    fbConnection1.Close(); 
                    foreach (DataRow dr in cli.Tables[0].Rows)
                    {
                        _cod = _cod + "" + dr["COD_CR"].ToString() + "";
                        _descricao = _descricao + "" + dr["DESCRICAO_CR"].ToString() + "";
                        _valor = _valor + Convert.ToDouble(dr["VALOR_CR"].ToString());

                        _duplicata = _duplicata + "" + dr["DUPLICATA_CR"].ToString() + "";
                        _nf = _nf + "" + dr["NF_CR"].ToString() + "";

                        if (i == 0 && n_baixas == 1) //EM BAIXAS CONJUNTAS EU NÃO INCREMENTO CLIENTE, PLANO E CARTEIRA
                        {
                            _cod_cli_forn = dr["COD_CLIENTE_CR"].ToString();
                            _razao_cli_forn = dr["RAZAO_CLIENTE_CR"].ToString();
                            _plano = dr["PLANO_CR"].ToString();
                            _carteira = dr["CARTEIRA_CR"].ToString();
                            _cod_plano = dr["COD_PLANO_CR"].ToString();
                        }
                        buscar_dados_conta(out _cc, out _descricao_cc);
                        if (dr["CC_CR"].ToString() != "")
                        {
                            _cc = dr["CC_CR"].ToString();
                            _descricao_cc = dr["DESCRICAO_CC_CR"].ToString();
                        }
                    }
                }

            }
            if (rb_Debito.Checked == true)
            {
                for (int i = 0; i < n_baixas; i++)
                {
                    comando_select.CommandText = "SELECT * FROM CONTAS_A_PAGAR WHERE COD_CP = '" + cod[i] + "'";
                    DataSet cli = new DataSet();
                    fbConnection1.Open();
                    datContas_a_pagar.SelectCommand = comando_select;
                    datContas_a_pagar.Fill(cli);
                    fbConnection1.Close(); 
                    foreach (DataRow dr in cli.Tables[0].Rows)
                    {
                        _cod = _cod + " " + dr["COD_CP"].ToString() + "/";
                        _descricao = _descricao + " " + dr["DESCRICAO_CP"].ToString() + "/";
                        _valor = _valor + Convert.ToDouble(dr["VALOR_CP"].ToString());

                        _duplicata = _duplicata + " " + dr["DUPLICATA_CP"].ToString() + "/";
                        _nf = _nf + " " + dr["NF_CP"].ToString() + "/";

                        if (i == 0 && n_baixas == 1) //EM BAIXAS CONJUNTAS EU NÃO INCREMENTO CLIENTE, PLANO E CARTEIRA
                        {

                            _cod_cli_forn = dr["COD_FORNECEDOR_CP"].ToString();
                            _razao_cli_forn = dr["RAZAO_FORNECEDOR_CP"].ToString();
                            _plano = dr["PLANO_CP"].ToString();
                            _carteira = dr["CARTEIRA_CP"].ToString();
                            _cod_plano = dr["COD_PLANO_CP"].ToString();
                        }

                        _cc = dr["CC_CP"].ToString();
                        _descricao_cc = dr["DESCRICAO_CC_CP"].ToString();
                    }
                }

            }
            if (valor_baixa != null && valor_baixa != 0)
            {
                try
                {
                    _valor = Convert.ToDouble(valor_baixa);
                }
                catch { }

            }
            if (data_baixa != null && data_baixa != Convert.ToDateTime("01/01/0001")) 
            {
                try
                {
                    tb_data.Text = data_baixa.ToShortDateString();
                }
                catch { }
            }
            tb_descricao.Text = _descricao;
            tb_cr_cp.Text = _cod;
            tb_cod_forn.Text = _cod_cli_forn;
            tb_nome_forn.Text = _razao_cli_forn;
            tb_planos.Text = _plano;
            tb_carteira.Text = _carteira;
            tb_nf.Text = _nf;
            tb_valor.Text = _valor.ToString();
            tb_duplicata.Text = _duplicata;
            tb_cod_plano.Text = _cod_plano;
            tb_cod_cc.Text = _cc;
            tb_descricao_cc.Text = _descricao_cc;
        }

        private void buscar_dados_conta(out string _cc, out string _descricao_cc)
        {
            _cc = ""; _descricao_cc = "";
            try
            {

                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT * FROM CONTAS_CORRENTES WHERE BOLETO_CC = '1'";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    _cc = dr["COD_CC"].ToString();
                    _descricao_cc = dr["DESCRICAO_CC"].ToString();
                }
            }
            catch {
                fbConnection1.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vincular_cp_cr();
        }

        private void vincular_cp_cr()
        {
            if (rb_Credito.Checked == false && rb_Debito.Checked == false)
                MessageBox.Show("Por favor, selecione se esse item é um débito ou crédito.");
            else
            {
                if (rb_Credito.Checked == true)
                {
                    form_cp_cr cp = new form_cp_cr();
                    try
                    {
                        cp.credito = true;
                        cp.veio_buscar_caixa = true;
                        cp.ShowDialog();
                    }
                    finally
                    {
                        if (cp.cod_cr_cp != null)
                            vincular_cr_cp(cp.cod_cr_cp);
                        cp.Dispose();

                    }

                }
                if (rb_Debito.Checked == true)
                {
                    form_cp_cr cp = new form_cp_cr();
                    try
                    {
                        cp.debito = true;
                        cp.veio_buscar_caixa = true;
                        cp.ShowDialog();
                    }
                    finally
                    {
                        if (cp.cod_cr_cp != null)
                            vincular_cr_cp(cp.cod_cr_cp);
                        cp.Dispose();

                    }

                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (tb_data.Text == "")
                tb_data.Text = DateTime.Now.ToShortDateString();
            Atualizar();
            baixar_cp_cr();

        }

        private void baixar_cp_cr()
        {
            if (rb_Credito.Checked == true)
            {
                try
                {
                    if (tb_cr_cp.Text != "")
                    {
                        for (int i = 0; i < n_baixas; i++)
                        {

                            this.datContas_a_receber.UpdateCommand.CommandText =
                            "UPDATE CONTAS_A_RECEBER SET RECEBIDO_CR = '1' WHERE COD_CR = '" + cp_cr_a_vincular[i] + "'";
                            this.fbConnection1.Open();
                            this.datContas_a_receber.UpdateCommand.Connection = fbConnection1;
                            this.datContas_a_receber.UpdateCommand.ExecuteNonQuery();
                            this.fbConnection1.Close(); 

                            this.datContas_a_receber.UpdateCommand.CommandText =
                            "UPDATE CONTAS_A_RECEBER SET DATA_RECEBIMENTO_CR = '" + tb_data.Text.Replace("/", ".") + "' WHERE COD_CR = '" + cp_cr_a_vincular[i] + "'";
                            this.fbConnection1.Open();
                            this.datContas_a_receber.UpdateCommand.Connection = fbConnection1;
                            this.datContas_a_receber.UpdateCommand.ExecuteNonQuery();
                            this.fbConnection1.Close(); 

                            this.datContas_a_receber.UpdateCommand.CommandText =
                            "UPDATE CONTAS_A_RECEBER SET DATA_PREVISTA_CR = '" + tb_data.Text.Replace("/", ".") + "' WHERE COD_CR = '" + cp_cr_a_vincular[i] + "'";
                            this.fbConnection1.Open();
                            this.datContas_a_receber.UpdateCommand.Connection = fbConnection1;
                            this.datContas_a_receber.UpdateCommand.ExecuteNonQuery();
                            this.fbConnection1.Close(); 

                            this.datContas_a_receber.UpdateCommand.CommandText =
                           "UPDATE CONTAS_A_RECEBER SET COD_CAIXA_CR = '" + tb_cod.Text + "' WHERE COD_CR = '" + cp_cr_a_vincular[i] + "'";
                            this.fbConnection1.Open();
                            this.datContas_a_receber.UpdateCommand.Connection = fbConnection1;
                            this.datContas_a_receber.UpdateCommand.ExecuteNonQuery();
                            this.fbConnection1.Close(); 

                            this.datContas_a_receber.UpdateCommand.CommandText =
                           "UPDATE CONTAS_A_RECEBER SET CC_CR = '" + tb_cod_cc.Text + "', DESCRICAO_CC_CR = '" + tb_descricao_cc.Text + "' WHERE COD_CR = '" + cp_cr_a_vincular[i] + "'";
                            this.fbConnection1.Open();
                            this.datContas_a_receber.UpdateCommand.Connection = fbConnection1;
                            this.datContas_a_receber.UpdateCommand.ExecuteNonQuery();
                            this.fbConnection1.Close(); 
                        }

                    }
                }
                catch
                {
                    fbConnection1.Close(); 
                    MessageBox.Show("Erro ao baixar o Contas a Receber");
                }
            }
            if (rb_Debito.Checked == true)
            {
                try
                {
                    if (tb_cr_cp.Text != "")
                    {
                        for (int i = 0; i < n_baixas; i++)
                        {
                            this.datContas_a_pagar.UpdateCommand.CommandText =
                            "UPDATE CONTAS_A_PAGAR SET PAGO_CP = '1' WHERE COD_CP = '" + cp_cr_a_vincular[i] + "'";
                            this.fbConnection1.Open();
                            this.datContas_a_pagar.UpdateCommand.Connection = fbConnection1;
                            this.datContas_a_pagar.UpdateCommand.ExecuteNonQuery();
                            this.fbConnection1.Close(); 

                            this.datContas_a_pagar.UpdateCommand.CommandText =
                            "UPDATE CONTAS_A_PAGAR SET DATA_PAGAMENTO_CP = '" + tb_data.Text.Replace("/", ".") + "' WHERE COD_CP = '" + cp_cr_a_vincular[i] + "'";
                            this.fbConnection1.Open();
                            this.datContas_a_pagar.UpdateCommand.Connection = fbConnection1;
                            this.datContas_a_pagar.UpdateCommand.ExecuteNonQuery();
                            this.fbConnection1.Close(); 

                            this.datContas_a_pagar.UpdateCommand.CommandText =
                            "UPDATE CONTAS_A_PAGAR SET DATA_PREVISTA_CP = '" + tb_data.Text.Replace("/", ".") + "' WHERE COD_CP = '" + cp_cr_a_vincular[i] + "'";
                            this.fbConnection1.Open();
                            this.datContas_a_pagar.UpdateCommand.Connection = fbConnection1;
                            this.datContas_a_pagar.UpdateCommand.ExecuteNonQuery();
                            this.fbConnection1.Close(); 

                            this.datContas_a_pagar.UpdateCommand.CommandText =
                            "UPDATE CONTAS_A_PAGAR SET COD_CAIXA_CP = '" + tb_cod.Text + "' WHERE COD_CP = '" + cp_cr_a_vincular[i] + "'";
                            this.fbConnection1.Open();
                            this.datContas_a_pagar.UpdateCommand.Connection = fbConnection1;
                            this.datContas_a_pagar.UpdateCommand.ExecuteNonQuery();
                            this.fbConnection1.Close(); 

                            this.datContas_a_pagar.UpdateCommand.CommandText =
                          "UPDATE CONTAS_A_PAGAR SET DUPLICATA_CP = '" + tb_duplicata.Text + "', CC_CP = '" + tb_cod_cc.Text + "', DESCRICAO_CC_CP = '" + tb_descricao_cc.Text + "' WHERE COD_CP = '" + cp_cr_a_vincular[i] + "'";
                            this.fbConnection1.Open();
                            this.datContas_a_pagar.UpdateCommand.Connection = fbConnection1;
                            this.datContas_a_pagar.UpdateCommand.ExecuteNonQuery();
                            this.fbConnection1.Close(); 
                        }

                    }
                }
                catch
                {
                    fbConnection1.Close(); 
                    MessageBox.Show("Erro ao baixar o Contas a Pagar");
                }
            }
        }
        private void Atualizar()
        {
            try
            {
                this.BindingContext[dsCaixa, "CAIXA"].EndCurrentEdit();
                if (dsCaixa.HasChanges())
                {
                    fbConnection1.Open();
                    datCaixa.UpdateCommand = cbCaixa.GetUpdateCommand();
                    datCaixa.InsertCommand = cbCaixa.GetInsertCommand();
                    datCaixa.DeleteCommand = cbCaixa.GetDeleteCommand();
                    datCaixa.Update(dsCaixa, "CAIXA");
                    dsCaixa.AcceptChanges();
                    fbConnection1.Close(); 
                }
            }
            catch
            {

                fbConnection1.Close(); 
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            form_cc cc = new form_cc();
            try
            {
                cc.ShowDialog();

            }
            finally
            {
                tb_cod_cc.Text = cc.cod_escolhido;
                tb_descricao_cc.Text = cc.descricao_escolhido;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (rb_Credito.Checked == false && rb_Debito.Checked == false)
            {
                MessageBox.Show("Selecione entre Crédito e Débito por favor");
            }
            else
            {
                if (rb_Debito.Checked == true)
                {
                    form_localiza_forn forn = new form_localiza_forn(false, "");
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
                if (rb_Credito.Checked == true)
                {
                    form_localiza_cliente cliente = new form_localiza_cliente(false, "");
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

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}