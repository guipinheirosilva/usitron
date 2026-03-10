using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_malote : Form
    {
        public string[] _itens = new string[100];
        public int n_itens_malote;
        public bool credito, debito, novo, abrir;
        public string _cod_malote_a_abrir;
        public form_malote()
        {
            InitializeComponent();
        }

        private void form_malote_Load(object sender, EventArgs e)
        {
            if (novo == true)
            {
                try
                {
                    this.datMalotes.DeleteCommand.CommandText =
                        "DELETE FROM MALOTES WHERE DESCRICAO_MALOTE = 'NOVO'";
                    this.fbConnection1.Open();
                    this.datMalotes.DeleteCommand.Connection = fbConnection1;
                    this.datMalotes.DeleteCommand.ExecuteNonQuery();
                    this.fbConnection1.Close(); 

                    this.datMalotes.InsertCommand.CommandText =
                    "INSERT INTO MALOTES (DESCRICAO_MALOTE) " +
                    "VALUES ('NOVO')";
                    this.fbConnection1.Open();
                    this.datMalotes.InsertCommand.Connection = fbConnection1;
                    this.datMalotes.InsertCommand.ExecuteNonQuery();
                    this.fbConnection1.Close(); 

                    this.datMalotes.SelectCommand.CommandText =
                        "SELECT * FROM MALOTES WHERE DESCRICAO_MALOTE = 'NOVO'";
                    this.fbConnection1.Open();
                    this.datMalotes.SelectCommand.Connection = fbConnection1;
                    this.datMalotes.SelectCommand.ExecuteNonQuery();
                    datMalotes.Fill(MALOTES);
                    this.fbConnection1.Close(); 
                }
                catch
                {
                    fbConnection1.Close(); 
                    MessageBox.Show("Erro na inserção de um novo malote");
                }
            }
            if (abrir == true)
            {
                this.datMalotes.SelectCommand.CommandText =
                        "SELECT * FROM MALOTES WHERE COD_MALOTE = '" + _cod_malote_a_abrir + "'";
                this.fbConnection1.Open();
                this.datMalotes.SelectCommand.Connection = fbConnection1;
                this.datMalotes.SelectCommand.ExecuteNonQuery();
                datMalotes.Fill(MALOTES);
                this.fbConnection1.Close(); 

                this.datCaixa.SelectCommand.CommandText =
                        "SELECT * FROM CAIXA WHERE MALOTE_CAIXA = '" + _cod_malote_a_abrir + "'";
                this.fbConnection1.Open();
                this.datCaixa.SelectCommand.Connection = fbConnection1;
                this.datCaixa.SelectCommand.ExecuteNonQuery();
                datCaixa.Fill(CAIXA);
                this.fbConnection1.Close(); 
           }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (tb_cod_cc.Text == "" || tb_data.Text == "" || tb_descricao.Text == "" || tb_descricao.Text == "NOVO")
            {
                MessageBox.Show("Os campos Conta Corrente, Descrição e Data são obrigatórios");
            }
            else
            {
                inserir_itens_caixa();

                dsCaixa.Clear();
                this.datCaixa.SelectCommand.CommandText =
                        "SELECT * FROM CAIXA WHERE MALOTE_CAIXA = '" + tb_cod.Text + "'";
                this.fbConnection1.Open();
                this.datCaixa.SelectCommand.Connection = fbConnection1;
                this.datCaixa.SelectCommand.ExecuteNonQuery();
                datCaixa.Fill(CAIXA);
                this.fbConnection1.Close(); 
            }
        }

        private void inserir_itens_caixa()
        {
            for (int i = 0; i < n_itens_malote; i++)
            {
                try
                {
                    string _descricao, _valor, _cod_cli_forn, _razao_cli_forn, _duplicata, _nf, _plano, _carteira, _cod_plano;
                    vincular_cr_cp(_itens[i], out _descricao, out _valor, out _cod_cli_forn, out _razao_cli_forn, out _duplicata, out _nf, out _plano, out _carteira, out _cod_plano);
                    if (debito == true)
                    {
                        this.datCaixa.InsertCommand.CommandText =
                    "INSERT INTO CAIXA (DESCRICAO_CAIXA, CC_CAIXA, DESCRICAO_CC_CAIXA, COD_CP_CR_CAIXA, " +
                    "VALOR_CAIXA, DATA_CAIXA, COD_FORN_CLI_CAIXA, RAZAO_CLI_FORN_CAIXA, DUPLICATA_CAIXA, NF_CAIXA, " +
                    "PLANO_CAIXA, CARTEIRA_CAIXA, DEBITO_CAIXA, MALOTE_CAIXA, COD_PLANO_CAIXA) VALUES " +
                    "(" + _descricao + ",'" + tb_cod_cc.Text + "','" + tb_descricao_cc.Text + "','" + _itens[i] + "'," +
                    _valor + ",'" + tb_data.Text.Replace("/", ".") + "'," + _cod_cli_forn + ", " + _razao_cli_forn + ", " + _duplicata + "," +
                    _nf + "," + _plano + "," + _carteira + ",'1' ,'" + tb_cod.Text + "'," + _cod_plano + ")";
                        this.fbConnection1.Open();
                        this.datCaixa.InsertCommand.Connection = fbConnection1;
                        this.datCaixa.InsertCommand.ExecuteNonQuery();
                        this.fbConnection1.Close(); 
                        baixar_cp_cr(_itens[i], buscar_cod_caixa(tb_cod.Text, _itens[i].ToString(), _descricao));
                    }

                    if (credito == true)
                    {
                        this.datCaixa.InsertCommand.CommandText =
                    "INSERT INTO CAIXA (DESCRICAO_CAIXA, CC_CAIXA, DESCRICAO_CC_CAIXA, COD_CP_CR_CAIXA, " +
                    "VALOR_CAIXA, DATA_CAIXA, COD_FORN_CLI_CAIXA, RAZAO_CLI_FORN_CAIXA, DUPLICATA_CAIXA, NF_CAIXA, " +
                    "PLANO_CAIXA, CARTEIRA_CAIXA, CREDITO_CAIXA, MALOTE_CAIXA) VALUES " +
                    "(" + _descricao + ",'" + tb_cod_cc.Text + "','" + tb_descricao_cc.Text + "','" + _itens[i] + "'," +
                    _valor + ",'" + tb_data.Text.Replace("/", ".") + "'," + _cod_cli_forn + ", " + _razao_cli_forn + ", " + _duplicata + "," +
                    _nf + "," + _plano + "," + _carteira + ",'1' ,'" + tb_cod.Text + "')";
                        this.fbConnection1.Open();
                        this.datCaixa.InsertCommand.Connection = fbConnection1;
                        this.datCaixa.InsertCommand.ExecuteNonQuery();
                        this.fbConnection1.Close(); 
                        baixar_cp_cr(_itens[i], buscar_cod_caixa(tb_cod.Text, _itens[i], _descricao));
                        baixar_pedido(_itens[i]);
                    }
                }
                catch
                {
                    fbConnection1.Close(); 
                    MessageBox.Show("Erro na inserção do item nº " + _itens[i].ToString());
                }



            }
        }

        public string buscar_cod_caixa(string malote, string cod_cp_cr, string descricao)
        {
            string comparativo_descricao = "=";
            if (descricao == "null")
                comparativo_descricao = "is";
            comando_select.CommandText = "SELECT * FROM CAIXA WHERE MALOTE_CAIXA = '" + malote + "' AND COD_CP_CR_CAIXA = '" + cod_cp_cr  +
                "' AND DESCRICAO_CAIXA " + comparativo_descricao + " " + descricao + "";
            DataSet cx = new DataSet();
            fbConnection1.Open();
            datCaixa.SelectCommand = comando_select;
            datCaixa.Fill(cx);
            fbConnection1.Close(); 
            string cod = "";
            foreach (DataRow dr in cx.Tables[0].Rows)
            {
                cod = dr["COD_CAIXA"].ToString();
                
            }
            return cod;
        }

        private void vincular_cr_nf(string cod, out string _nf)
        {
            _nf = "";
            if (credito == true)
            {
                comando_select.CommandText = "SELECT * FROM CONTAS_A_RECEBER WHERE COD_CR = " + cod + "";
                DataSet cli = new DataSet();
                fbConnection1.Open();
                datContas_a_receber.SelectCommand = comando_select;
                datContas_a_receber.Fill(cli);
                fbConnection1.Close(); 
                foreach (DataRow dr in cli.Tables[0].Rows)
                {
                    
                    _nf = dr["NF_CR"].ToString();
                    
                }

            }
           
            if (_nf == "")
                _nf = "null";
            else
                _nf = "'" + _nf + "'";

            


        }
        private void baixar_pedido(string _item_cr_cp)
        {
            if (credito == true)
            {
                try
                {
                    string _nf = "";
                    vincular_cr_nf(_item_cr_cp, out _nf);
                    this.datPedidos_venda.UpdateCommand.CommandText =
                    "UPDATE PEDIDOS_VENDA SET PAGO_PED_VENDA = '1' WHERE COD_PED_VENDA = " + _nf + "";
                    this.fbConnection1.Open();
                    this.datPedidos_venda.UpdateCommand.Connection = fbConnection1;
                    this.datPedidos_venda.UpdateCommand.ExecuteNonQuery();
                    this.fbConnection1.Close(); 
                }
                catch
                {
                    fbConnection1.Close(); 
                }
            }
        }
        private void baixar_cp_cr(string _item_cr_cp, string _cod_caixa)
        {
            if (credito == true)
            {
                try
                {
                    
                        this.datContas_a_receber.UpdateCommand.CommandText =
                        "UPDATE CONTAS_A_RECEBER SET RECEBIDO_CR = '1' WHERE COD_CR = '" + _item_cr_cp + "'";
                        this.fbConnection1.Open();
                        this.datContas_a_receber.UpdateCommand.Connection = fbConnection1;
                        this.datContas_a_receber.UpdateCommand.ExecuteNonQuery();
                        this.fbConnection1.Close(); 

                        this.datContas_a_receber.UpdateCommand.CommandText =
                        "UPDATE CONTAS_A_RECEBER SET DATA_RECEBIMENTO_CR = '" + tb_data.Text.Replace("/", ".") + "' WHERE COD_CR = '" + _item_cr_cp + "'";
                        this.fbConnection1.Open();
                        this.datContas_a_receber.UpdateCommand.Connection = fbConnection1;
                        this.datContas_a_receber.UpdateCommand.ExecuteNonQuery();
                        this.fbConnection1.Close(); 

                        this.datContas_a_receber.UpdateCommand.CommandText =
                       "UPDATE CONTAS_A_RECEBER SET COD_CAIXA_CR = '" + _cod_caixa + "' WHERE COD_CR = '" + _item_cr_cp + "'";
                        this.fbConnection1.Open();
                        this.datContas_a_receber.UpdateCommand.Connection = fbConnection1;
                        this.datContas_a_receber.UpdateCommand.ExecuteNonQuery();
                        this.fbConnection1.Close(); 

                    
                }
                catch
                {
                    fbConnection1.Close(); 
                    MessageBox.Show("Erro ao baixar o Contas a Receber");
                }
            }
            if (debito == true)
            {
                try
                {
                    
                        this.datContas_a_pagar.UpdateCommand.CommandText =
                        "UPDATE CONTAS_A_PAGAR SET PAGO_CP = '1' WHERE COD_CP = '" + _item_cr_cp + "'";
                        this.fbConnection1.Open();
                        this.datContas_a_pagar.UpdateCommand.Connection = fbConnection1;
                        this.datContas_a_pagar.UpdateCommand.ExecuteNonQuery();
                        this.fbConnection1.Close(); 

                        this.datContas_a_pagar.UpdateCommand.CommandText =
                        "UPDATE CONTAS_A_PAGAR SET DATA_PAGAMENTO_CP = '" + tb_data.Text.Replace("/", ".") + "' WHERE COD_CP = '" + _item_cr_cp + "'";
                        this.fbConnection1.Open();
                        this.datContas_a_pagar.UpdateCommand.Connection = fbConnection1;
                        this.datContas_a_pagar.UpdateCommand.ExecuteNonQuery();
                        this.fbConnection1.Close(); 

                        this.datContas_a_pagar.UpdateCommand.CommandText =
                        "UPDATE CONTAS_A_PAGAR SET COD_CAIXA_CP = '" + _cod_caixa + "' WHERE COD_CP = '" + _item_cr_cp + "'";
                        this.fbConnection1.Open();
                        this.datContas_a_pagar.UpdateCommand.Connection = fbConnection1;
                        this.datContas_a_pagar.UpdateCommand.ExecuteNonQuery();
                        this.fbConnection1.Close(); 


                    
                }
                catch
                {
                    fbConnection1.Close(); 
                    MessageBox.Show("Erro ao baixar o Contas a Pagar");
                }
            }
        }

        private void vincular_cr_cp(string cod, out string _descricao, out string _valor, out string _cod_cli_forn, out string _razao_cli_forn, out string _duplicata, out string _nf, out string _plano, out string _carteira, out string _cod_plano)
        {
            _descricao = ""; _valor = ""; _cod_cli_forn = ""; _razao_cli_forn = ""; _duplicata = ""; _nf = ""; _plano = ""; _carteira = ""; _cod_plano = "";
            if (credito == true)
            {
                comando_select.CommandText = "SELECT * FROM CONTAS_A_RECEBER WHERE COD_CR = '" + cod + "'";
                DataSet cli = new DataSet();
                fbConnection1.Open();
                datContas_a_receber.SelectCommand = comando_select;
                datContas_a_receber.Fill(cli);
                fbConnection1.Close(); 
                foreach (DataRow dr in cli.Tables[0].Rows)
                {
                    _descricao = dr["DESCRICAO_CR"].ToString();
                    _valor = dr["VALOR_ATUALIZADO_CR"].ToString();
                    _cod_cli_forn = dr["COD_CLIENTE_CR"].ToString();
                    _razao_cli_forn = dr["RAZAO_CLIENTE_CR"].ToString();
                    _duplicata = dr["DUPLICATA_CR"].ToString();
                    _nf = dr["NF_CR"].ToString();
                    _plano = dr["PLANO_CR"].ToString();
                    _carteira = dr["CARTEIRA_CR"].ToString();
                    _cod_plano = dr["COD_PLANO_CR"].ToString();
                }

            }
            if (debito == true)
            {
                comando_select.CommandText = "SELECT * FROM CONTAS_A_PAGAR WHERE COD_CP = '" + cod + "'";
                DataSet cli = new DataSet();
                fbConnection1.Open();
                datContas_a_pagar.SelectCommand = comando_select;
                datContas_a_pagar.Fill(cli);
                fbConnection1.Close(); 
                foreach (DataRow dr in cli.Tables[0].Rows)
                {
                    _descricao = dr["DESCRICAO_CP"].ToString();
                    _valor = dr["VALOR_CP"].ToString();
                    _cod_cli_forn = dr["COD_FORNECEDOR_CP"].ToString();
                    _razao_cli_forn = dr["RAZAO_FORNECEDOR_CP"].ToString();
                    _duplicata = dr["DUPLICATA_CP"].ToString();
                    _nf = dr["NF_CP"].ToString();
                    _plano = dr["PLANO_CP"].ToString();
                    _carteira = dr["CARTEIRA_CP"].ToString();
                    _cod_plano = dr["COD_PLANO_CP"].ToString();
                }

            }
            if (_descricao == "")
                _descricao = "null";
            else
                _descricao = "'" + _descricao + "'";

            if (_valor == "")
                _valor = "null";
            else
                _valor = "'" + _valor.Replace(".","").Replace(",",".") + "'";

            if (_cod_cli_forn == "")
                _cod_cli_forn = "null";
            else
                _cod_cli_forn = "'" + _cod_cli_forn + "'";

            if (_razao_cli_forn == "")
                _razao_cli_forn = "null";
            else
                _razao_cli_forn = "'" + _razao_cli_forn + "'";

            if (_duplicata == "")
                _duplicata = "null";
            else
                _duplicata = "'" + _duplicata + "'";

            if (_nf == "")
                _nf = "null";
            else
                _nf = "'" + _nf + "'";

            if (_plano == "")
                _plano = "null";
            else
                _plano = "'" + _plano + "'";

            if (_cod_plano == "")
                _cod_plano = "null";
            else
                _cod_plano = "'" + _cod_plano + "'";

            if (_carteira == "")
                _carteira = "null";
            else
                _carteira = "'" + _carteira + "'";

            
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

        private void salva_registro_Click(object sender, EventArgs e)
        {
            Atualizar();
        }

        private void Atualizar()
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

            this.BindingContext[dsMalotes, "MALOTES"].EndCurrentEdit();
            if (dsMalotes.HasChanges())
            {
                fbConnection1.Open();
                datMalotes.UpdateCommand = cbMalotes.GetUpdateCommand();
                datMalotes.InsertCommand = cbMalotes.GetInsertCommand();
                datMalotes.DeleteCommand = cbMalotes.GetDeleteCommand();
                datMalotes.Update(dsMalotes, "MALOTES");
                dsMalotes.AcceptChanges();
                fbConnection1.Close(); 
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.datMalotes.SelectCommand.CommandText =
                        "SELECT * FROM MALOTES WHERE COD_MALOTE = '" + tb_cod.Text + "'";
            this.fbConnection1.Open();
            this.datMalotes.SelectCommand.Connection = fbConnection1;
            this.datMalotes.SelectCommand.ExecuteNonQuery();
            datMalotes.Fill(MALOTES);
            this.fbConnection1.Close(); 

            this.datCaixa.SelectCommand.CommandText =
                    "SELECT * FROM CAIXA WHERE MALOTE_CAIXA = '" + tb_cod.Text + "'";
            this.fbConnection1.Open();
            this.datCaixa.SelectCommand.Connection = fbConnection1;
            this.datCaixa.SelectCommand.ExecuteNonQuery();
            datCaixa.Fill(CAIXA);
            this.fbConnection1.Close(); 

            dsMalote imprimir = new dsMalote();
            fbConnection1.Open();
            datMalotes.Fill(imprimir.MALOTES);
            datCaixa.Fill(imprimir.CAIXA);
            fbConnection1.Close(); 
            if (credito == true)
            {
                crMalote novo_ped = new crMalote();
                novo_ped.SetDataSource(imprimir);
                form_imprimir imprime = new form_imprimir(novo_ped);
                imprime.Show();
            }
            else
            {
                crMalote novo_ped = new crMalote();
                novo_ped.SetDataSource(imprimir);
                form_imprimir imprime = new form_imprimir(novo_ped);
                imprime.Show();
            }
        }

    
    }
}