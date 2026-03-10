using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_cp_cr : Form
    {
        public bool veio_buscar_caixa, credito, debito;
        public string cod_cr_cp;
        public form_cp_cr()
        {
            InitializeComponent();
        }

        private void bt_pesquisar_cp_Click(object sender, EventArgs e)
        {
            if (rbAtrasados_cp.Checked == false && rbPagos_cp.Checked == false && rbTodos_cp.Checked == false && rbAbertos_cp.Checked == false)
            {
                rbTodos_cp.Checked = true;
            }
            
            if (rbTodos_cp.Checked == true)
            {
                pesquisar_todos_cp();
            }
            if (rbPagos_cp.Checked == true)
            {
                pesquisar_pagos_cp();
            }
            if (rbAtrasados_cp.Checked == true)
            {
               pesquisar_atrasados_cp();
            }
            if (rbAbertos_cp.Checked == true)
            {
                pesquisar_abertos_cp();
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


        private string detectar_cod_cliente(string nome_cli)
        {
            string _nome_cli = "", _cod_cli = "";
            comando_select.CommandText = "SELECT * FROM CLIENTES WHERE RAZAO_SOCIAL = '" + nome_cli + "'";
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

        private void pesquisar_todos_cp()
        {
            if (cb_data_cp.Checked == true && cb_forn_cp.Checked == true)
            {
                try
                {
                    dsContas_a_pagar.Clear();
                    this.datContas_a_pagar.SelectCommand.CommandText =
                        "SELECT * FROM CONTAS_A_PAGAR WHERE (DATA_PREVISTA_CP >= '" + Convert.ToDateTime(dtInicial_cp.Text).ToShortDateString().Replace("/", ".") + "'" +
                        "AND DATA_PREVISTA_CP <= '" + Convert.ToDateTime(dtFinal_cp.Text).ToShortDateString().Replace("/", ".") + "')" +
                        "AND COD_FORNECEDOR_CP = '" + tb_cod_forn_cp.Text + "' ORDER BY DATA_PREVISTA_CP";
                    this.fbConnection1.Open();
                    this.datContas_a_pagar.SelectCommand.Connection = fbConnection1;
                    this.datContas_a_pagar.SelectCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                    datContas_a_pagar.Fill(CONTAS_A_PAGAR);
                    somar_valores();

                }
                catch
                {
                    MessageBox.Show("Erro na pesquisa TODOS por data e fornecedor");
                    fbConnection1.Close();
                }
            }
            if (cb_data_cp.Checked == true && cb_forn_cp.Checked == false)
            {
                try
                {
                    dsContas_a_pagar.Clear();
                    this.datContas_a_pagar.SelectCommand.CommandText =
                        "SELECT * FROM CONTAS_A_PAGAR WHERE (DATA_PREVISTA_CP >= '" + Convert.ToDateTime(dtInicial_cp.Text).ToShortDateString().Replace("/", ".") + "'" +
                        "AND DATA_PREVISTA_CP <= '" + Convert.ToDateTime(dtFinal_cp.Text).ToShortDateString().Replace("/", ".") + "') ORDER BY DATA_PREVISTA_CP";
                    this.fbConnection1.Open();
                    this.datContas_a_pagar.SelectCommand.Connection = fbConnection1;
                    this.datContas_a_pagar.SelectCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                    datContas_a_pagar.Fill(CONTAS_A_PAGAR);
                    somar_valores();

                }
                catch
                {
                    MessageBox.Show("Erro na pesquisa TODOS por data");
                    fbConnection1.Close();
                }
            }
            if (cb_data_cp.Checked == false && cb_forn_cp.Checked == true)
            {
                try
                {
                    dsContas_a_pagar.Clear();
                    this.datContas_a_pagar.SelectCommand.CommandText =
                        "SELECT * FROM CONTAS_A_PAGAR WHERE COD_FORNECEDOR_CP = '" + tb_cod_forn_cp.Text + "' ORDER BY DATA_PREVISTA_CP";
                    this.fbConnection1.Open();
                    this.datContas_a_pagar.SelectCommand.Connection = fbConnection1;
                    this.datContas_a_pagar.SelectCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                    datContas_a_pagar.Fill(CONTAS_A_PAGAR);
                    somar_valores();

                }
                catch
                {
                    MessageBox.Show("Erro na pesquisa TODOS por fornecedor");
                    fbConnection1.Close();
                }
            }
        

        }

        
        private void pesquisar_pagos_cp()
        {
            if (cb_data_cp.Checked == true && cb_forn_cp.Checked == true)
            {
                try
                {
                    dsContas_a_pagar.Clear();
                    this.datContas_a_pagar.SelectCommand.CommandText =
                        "SELECT * FROM CONTAS_A_PAGAR WHERE (DATA_PAGAMENTO_CP >= '" + Convert.ToDateTime(dtInicial_cp.Text).ToShortDateString().Replace("/", ".") + "'" +
                        "AND DATA_PAGAMENTO_CP <= '" + Convert.ToDateTime(dtFinal_cp.Text).ToShortDateString().Replace("/", ".") + "')" +
                        "AND COD_FORNECEDOR_CP = '" + tb_cod_forn_cp.Text + "' AND PAGO_CP = 1 ORDER BY DATA_PREVISTA_CP";
                    this.fbConnection1.Open();
                    this.datContas_a_pagar.SelectCommand.Connection = fbConnection1;
                    this.datContas_a_pagar.SelectCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                    datContas_a_pagar.Fill(CONTAS_A_PAGAR);
                    somar_valores();

                }
                catch
                {
                    MessageBox.Show("Erro na pesquisa PAGOS por data e fornecedor");
                    fbConnection1.Close();
                }
            }
            if (cb_data_cp.Checked == true && cb_forn_cp.Checked == false)
            {
                try
                {
                    dsContas_a_pagar.Clear();
                    this.datContas_a_pagar.SelectCommand.CommandText =
                        "SELECT * FROM CONTAS_A_PAGAR WHERE (DATA_PAGAMENTO_CP >= '" + Convert.ToDateTime(dtInicial_cp.Text).ToShortDateString().Replace("/", ".") + "'" +
                        "AND DATA_PAGAMENTO_CP <= '" + Convert.ToDateTime(dtFinal_cp.Text).ToShortDateString().Replace("/", ".") + "') AND PAGO_CP = 1 ORDER BY DATA_PREVISTA_CP";
                    this.fbConnection1.Open();
                    this.datContas_a_pagar.SelectCommand.Connection = fbConnection1;
                    this.datContas_a_pagar.SelectCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                    datContas_a_pagar.Fill(CONTAS_A_PAGAR);
                    somar_valores();

                }
                catch
                {
                    MessageBox.Show("Erro na pesquisa PAGOS por data");
                    fbConnection1.Close();
                }
            }
            if (cb_data_cp.Checked == false && cb_forn_cp.Checked == true)
            {
                try
                {
                    dsContas_a_pagar.Clear();
                    this.datContas_a_pagar.SelectCommand.CommandText =
                        "SELECT * FROM CONTAS_A_PAGAR WHERE COD_FORNECEDOR_CP = '" + tb_cod_forn_cp.Text + "' AND PAGO_CP = 1 ORDER BY DATA_PREVISTA_CP";
                    this.fbConnection1.Open();
                    this.datContas_a_pagar.SelectCommand.Connection = fbConnection1;
                    this.datContas_a_pagar.SelectCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                    datContas_a_pagar.Fill(CONTAS_A_PAGAR);
                    somar_valores();

                }
                catch
                {
                    MessageBox.Show("Erro na pesquisa PAGOS por fornecedor");
                    fbConnection1.Close();
                }
            }


        }

        private void pesquisar_abertos_cp()
        {
            if (cb_data_cp.Checked == true && cb_forn_cp.Checked == true)
            {
                try
                {
                    dsContas_a_pagar.Clear();
                    this.datContas_a_pagar.SelectCommand.CommandText =
                        "SELECT * FROM CONTAS_A_PAGAR WHERE (DATA_PREVISTA_CP >= '" + Convert.ToDateTime(dtInicial_cp.Text).ToShortDateString().Replace("/", ".") + "'" +
                        "AND DATA_PREVISTA_CP <= '" + Convert.ToDateTime(dtFinal_cp.Text).ToShortDateString().Replace("/", ".") + "')" +
                        "AND COD_FORNECEDOR_CP = '" + tb_cod_forn_cp.Text + "' AND (PAGO_CP != 1 OR PAGO_CP IS NULL) ORDER BY DATA_PREVISTA_CP";
                    this.fbConnection1.Open();
                    this.datContas_a_pagar.SelectCommand.Connection = fbConnection1;
                    this.datContas_a_pagar.SelectCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                    datContas_a_pagar.Fill(CONTAS_A_PAGAR);
                    somar_valores();

                }
                catch
                {
                    MessageBox.Show("Erro na pesquisa ABERTOS por data e fornecedor");
                    fbConnection1.Close();
                }
            }
            if (cb_data_cp.Checked == true && cb_forn_cp.Checked == false)
            {
                try
                {
                    dsContas_a_pagar.Clear();
                    this.datContas_a_pagar.SelectCommand.CommandText =
                        "SELECT * FROM CONTAS_A_PAGAR WHERE (DATA_PREVISTA_CP >= '" + Convert.ToDateTime(dtInicial_cp.Text).ToShortDateString().Replace("/", ".") + "'" +
                        "AND DATA_PREVISTA_CP <= '" + Convert.ToDateTime(dtFinal_cp.Text).ToShortDateString().Replace("/", ".") + "') AND (PAGO_CP != 1 OR PAGO_CP IS NULL) ORDER BY DATA_PREVISTA_CP";
                    this.fbConnection1.Open();
                    this.datContas_a_pagar.SelectCommand.Connection = fbConnection1;
                    this.datContas_a_pagar.SelectCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                    datContas_a_pagar.Fill(CONTAS_A_PAGAR);
                    somar_valores();

                }
                catch
                {
                    MessageBox.Show("Erro na pesquisa ABERTOS por data");
                    fbConnection1.Close();
                }
            }
            if (cb_data_cp.Checked == false && cb_forn_cp.Checked == true)
            {
                try
                {
                    dsContas_a_pagar.Clear();
                    this.datContas_a_pagar.SelectCommand.CommandText =
                        "SELECT * FROM CONTAS_A_PAGAR WHERE COD_FORNECEDOR_CP = '" + tb_cod_forn_cp.Text + "' AND (PAGO_CP != 1 OR PAGO_CP IS NULL) ORDER BY DATA_PREVISTA_CP";
                    this.fbConnection1.Open();
                    this.datContas_a_pagar.SelectCommand.Connection = fbConnection1;
                    this.datContas_a_pagar.SelectCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                    datContas_a_pagar.Fill(CONTAS_A_PAGAR);
                    somar_valores();

                }
                catch
                {
                    MessageBox.Show("Erro na pesquisa ABERTOS por fornecedor");
                    fbConnection1.Close();
                }
            }
        }

        private void pesquisar_atrasados_cp()
        {
            if (cb_data_cp.Checked == true && cb_forn_cp.Checked == true)
            {
                try
                {
                    dsContas_a_pagar.Clear();
                    this.datContas_a_pagar.SelectCommand.CommandText =
                        "SELECT * FROM CONTAS_A_PAGAR WHERE (DATA_PREVISTA_CP >= '" + Convert.ToDateTime(dtInicial_cp.Text).ToShortDateString().Replace("/", ".") + "'" +
                        "AND DATA_PREVISTA_CP <= '" + Convert.ToDateTime(dtFinal_cp.Text).ToShortDateString().Replace("/", ".") + "')" +
                        "AND COD_FORNECEDOR_CP = '" + tb_cod_forn_cp.Text + "' (PAGO_CP != '1' or (PAGO_CP IS NULL) )  AND DATA_PREVISTA_CP < '" + DateTime.Now.ToShortDateString().Replace("/", ".") + "' ORDER BY DATA_PREVISTA_CP";
                    this.fbConnection1.Open();
                    this.datContas_a_pagar.SelectCommand.Connection = fbConnection1;
                    this.datContas_a_pagar.SelectCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                    datContas_a_pagar.Fill(CONTAS_A_PAGAR);
                    somar_valores();

                }
                catch
                {
                    MessageBox.Show("Erro na pesquisa ATRASADOS por data e fornecedor");
                    fbConnection1.Close();
                }
            }
            if (cb_data_cp.Checked == true && cb_forn_cp.Checked == false)
            {
                try
                {
                    dsContas_a_pagar.Clear();
                    this.datContas_a_pagar.SelectCommand.CommandText =
                        "SELECT * FROM CONTAS_A_PAGAR WHERE (DATA_PREVISTA_CP >= '" + Convert.ToDateTime(dtInicial_cp.Text).ToShortDateString().Replace("/", ".") + "'" +
                        "AND DATA_PREVISTA_CP <= '" + Convert.ToDateTime(dtFinal_cp.Text).ToShortDateString().Replace("/", ".") + "') AND (PAGO_CP != '1' or (PAGO_CP IS NULL) )  AND DATA_PREVISTA_CP < '" + DateTime.Now.ToShortDateString().Replace("/", ".") + "' ORDER BY DATA_PREVISTA_CP";
                    this.fbConnection1.Open();
                    this.datContas_a_pagar.SelectCommand.Connection = fbConnection1;
                    this.datContas_a_pagar.SelectCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                    datContas_a_pagar.Fill(CONTAS_A_PAGAR);
                    somar_valores();

                }
                catch
                {
                    MessageBox.Show("Erro na pesquisa ATRASADOS por data");
                    fbConnection1.Close();
                }
            }
            if (cb_data_cp.Checked == false && cb_forn_cp.Checked == true)
            {
                try
                {
                    dsContas_a_pagar.Clear();
                    this.datContas_a_pagar.SelectCommand.CommandText =
                        "SELECT * FROM CONTAS_A_PAGAR WHERE COD_FORNECEDOR_CP = '" + tb_cod_forn_cp.Text + "' AND (PAGO_CP != '1' or (PAGO_CP IS NULL) )  AND DATA_PREVISTA_CP < '" + DateTime.Now.ToShortDateString().Replace("/", ".") + "' ORDER BY DATA_PREVISTA_CP";
                    this.fbConnection1.Open();
                    this.datContas_a_pagar.SelectCommand.Connection = fbConnection1;
                    this.datContas_a_pagar.SelectCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                    datContas_a_pagar.Fill(CONTAS_A_PAGAR);
                    somar_valores();

                }
                catch
                {
                    MessageBox.Show("Erro na pesquisa ATRASADOS por fornecedor");
                    fbConnection1.Close();
                }
            }


        }


        private void somar_valores()
        {
            double _total_cr = 0;
            for (int i = 0; i < dgvCp.RowCount; i++)
            {
                try
                {
                    _total_cr = _total_cr + Convert.ToDouble(dgvCp.Rows[i].Cells["col_valor_total_cp"].Value);
                }
                catch { }
            }
            tb_valor_total_cp.Text = _total_cr.ToString("n2");

        }

        private void somar_valores_cr()
        {
            double _total_cr = 0;
            for (int i = 0; i < dgvCr.RowCount; i++)
            {
                try
                {
                    _total_cr = _total_cr + Convert.ToDouble(dgvCr.Rows[i].Cells["col_valor_total_cr"].Value);
                }
                catch { }
            }
            tb_valor_total_cr.Text = _total_cr.ToString("n2");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            form_localiza_forn forn = new form_localiza_forn(true);
            try
            {
                forn.ShowDialog();

            }
            finally
            {
                tb_nome_forn_cp.Text = forn.razao_forn_escolhido;
                tb_cod_forn_cp.Text = detectar_cod_fornecedor(tb_nome_forn_cp.Text);
            }
        }

        private void bt_buscar_cliente_Click(object sender, EventArgs e)
        {
            form_localiza_cliente cli = new form_localiza_cliente(true);
            try
            {
                cli.ShowDialog();

            }
            finally
            {
                tb_nome_cliente.Text = cli.cliente_escolhido;
                tb_cod_cliente_cr.Text = detectar_cod_cliente(tb_nome_cliente.Text);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (rbAtrasados_cr.Checked == false && rbPagos_cr.Checked == false && rbTodos_cr.Checked == false && rbAbertos_cr.Checked == false)
            {
                rbTodos_cr.Checked = true;
            }
            if (rbTodos_cr.Checked == true)
            {
                pesquisar_todos_cr();
            }
            if (rbPagos_cr.Checked == true)
            {
                pesquisar_pagos_cr();
            }
            if (rbAtrasados_cr.Checked == true)
            {
                pesquisar_atrasados_cr();
            }
            if (rbAbertos_cr.Checked == true)
            {
                pesquisar_abertos_cr();
            }

        }
        private void pesquisar_todos_cr()
        {
            if (cb_data_cr.Checked == true && cb_cliente_cr.Checked == true)
            {
                try
                {
                    dsContas_a_receber.Clear();
                    this.datContas_a_receber.SelectCommand.CommandText =
                        "SELECT * FROM CONTAS_A_RECEBER WHERE (DATA_PREVISTA_CR >= '" + Convert.ToDateTime(dtInicial_cr.Text).ToShortDateString().Replace("/", ".") + "'" +
                        "AND DATA_PREVISTA_CR <= '" + Convert.ToDateTime(dtFinal_cr.Text).ToShortDateString().Replace("/", ".") + "')" +
                        "AND COD_CLIENTE_CR = '" + tb_cod_cliente_cr.Text + "' ORDER BY DATA_PREVISTA_CR";
                    this.fbConnection1.Open();
                    this.datContas_a_receber.SelectCommand.Connection = fbConnection1;
                    this.datContas_a_receber.SelectCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                    datContas_a_receber.Fill(CONTAS_A_RECEBER);
                    somar_valores_cr();

                }
                catch
                {
                    MessageBox.Show("Erro na pesquisa TODOS por data e cliente");
                    fbConnection1.Close();
                }
            }
            if (cb_data_cr.Checked == true && cb_cliente_cr.Checked == false)
            {
                try
                {
                    dsContas_a_receber.Clear();
                    this.datContas_a_receber.SelectCommand.CommandText =
                        "SELECT * FROM CONTAS_A_RECEBER WHERE (DATA_PREVISTA_CR >= '" + Convert.ToDateTime(dtInicial_cr.Text).ToShortDateString().Replace("/", ".") + "'" +
                        "AND DATA_PREVISTA_CR <= '" + Convert.ToDateTime(dtFinal_cr.Text).ToShortDateString().Replace("/", ".") + "') ORDER BY DATA_PREVISTA_CR";
                    this.fbConnection1.Open();
                    this.datContas_a_receber.SelectCommand.Connection = fbConnection1;
                    this.datContas_a_receber.SelectCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                    datContas_a_receber.Fill(CONTAS_A_RECEBER);
                    somar_valores_cr();

                }
                catch
                {
                    MessageBox.Show("Erro na pesquisa TODOS por data");
                    fbConnection1.Close();
                }
            }
            if (cb_data_cr.Checked == false && cb_cliente_cr.Checked == true)
            {
                try
                {
                    dsContas_a_receber.Clear();
                    this.datContas_a_receber.SelectCommand.CommandText =
                        "SELECT * FROM CONTAS_A_RECEBER WHERE COD_CLIENTE_CR = '" + tb_cod_cliente_cr.Text + "' ORDER BY DATA_PREVISTA_CR";
                    this.fbConnection1.Open();
                    this.datContas_a_receber.SelectCommand.Connection = fbConnection1;
                    this.datContas_a_receber.SelectCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                    datContas_a_receber.Fill(CONTAS_A_RECEBER);
                    somar_valores_cr();

                }
                catch
                {
                    MessageBox.Show("Erro na pesquisa TODOS por Cliente");
                    fbConnection1.Close();
                }
            }


        }


        private void pesquisar_pagos_cr()
        {
            if (cb_data_cr.Checked == true && cb_cliente_cr.Checked == true)
            {
                try
                {
                    dsContas_a_receber.Clear();
                    this.datContas_a_receber.SelectCommand.CommandText =
                        "SELECT * FROM CONTAS_A_RECEBER WHERE (DATA_RECEBIMENTO_CR >= '" + Convert.ToDateTime(dtInicial_cr.Text).ToShortDateString().Replace("/", ".") + "'" +
                        "AND DATA_RECEBIMENTO_CR <= '" + Convert.ToDateTime(dtFinal_cr.Text).ToShortDateString().Replace("/", ".") + "')" +
                        "AND COD_CLIENTE_CR = '" + tb_cod_cliente_cr.Text + "' AND RECEBIDO_CR = 1 ORDER BY DATA_PREVISTA_CR";
                    this.fbConnection1.Open();
                    this.datContas_a_receber.SelectCommand.Connection = fbConnection1;
                    this.datContas_a_receber.SelectCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                    datContas_a_receber.Fill(CONTAS_A_RECEBER);
                    somar_valores_cr();

                }
                catch
                {
                    MessageBox.Show("Erro na pesquisa PAGOS por data e Cliente");
                    fbConnection1.Close();
                }
            }
            if (cb_data_cr.Checked == true && cb_cliente_cr.Checked == false)
            {
                try
                {
                    dsContas_a_receber.Clear();
                    this.datContas_a_receber.SelectCommand.CommandText =
                        "SELECT * FROM CONTAS_A_RECEBER WHERE (DATA_RECEBIMENTO_CR >= '" + Convert.ToDateTime(dtInicial_cr.Text).ToShortDateString().Replace("/", ".") + "'" +
                        "AND DATA_RECEBIMENTO_CR <= '" + Convert.ToDateTime(dtFinal_cr.Text).ToShortDateString().Replace("/", ".") + "') AND RECEBIDO_CR = 1 ORDER BY DATA_PREVISTA_CR";
                    this.fbConnection1.Open();
                    this.datContas_a_receber.SelectCommand.Connection = fbConnection1;
                    this.datContas_a_receber.SelectCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                    datContas_a_receber.Fill(CONTAS_A_RECEBER);
                    somar_valores_cr();

                }
                catch
                {
                    MessageBox.Show("Erro na pesquisa PAGOS por data");
                    fbConnection1.Close();
                }
            }
            if (cb_data_cr.Checked == false && cb_cliente_cr.Checked == true)
            {
                try
                {
                    dsContas_a_receber.Clear();
                    this.datContas_a_receber.SelectCommand.CommandText =
                        "SELECT * FROM CONTAS_A_RECEBER WHERE COD_CLIENTE_CR = '" + tb_cod_cliente_cr.Text + "' AND RECEBIDO_CR = 1 ORDER BY DATA_PREVISTA_CR";
                    this.fbConnection1.Open();
                    this.datContas_a_receber.SelectCommand.Connection = fbConnection1;
                    this.datContas_a_receber.SelectCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                    datContas_a_receber.Fill(CONTAS_A_RECEBER);
                    somar_valores_cr();

                }
                catch
                {
                    MessageBox.Show("Erro na pesquisa PAGOS por fornecedor");
                    fbConnection1.Close();
                }
            }


        }
        /*
        private void pesquisar_abertos_cr()
        {
            if (cb_data_cr.Checked == true && cb_cliente_cr.Checked == true)
            {
                try
                {
                    dsContas_a_receber.Clear();
                    this.datContas_a_receber.SelectCommand.CommandText =
                        "SELECT * FROM CONTAS_A_RECEBER WHERE (DATA_RECEBIMENTO_CR >= '" + Convert.ToDateTime(dtInicial_cr.Text).ToShortDateString().Replace("/", ".") + "'" +
                        "AND DATA_RECEBIMENTO_CR <= '" + Convert.ToDateTime(dtFinal_cr.Text).ToShortDateString().Replace("/", ".") + "')" +
                        "AND COD_CLIENTE_CR = '" + tb_cod_cliente_cr.Text + "' AND (RECEBIDO_CR != 1 OR RECEBIDO_CR IS NULL) ORDER BY DATA_PREVISTA_CR";
                    this.fbConnection1.Open();
                    this.datContas_a_receber.SelectCommand.Connection = fbConnection1;
                    this.datContas_a_receber.SelectCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                    datContas_a_receber.Fill(CONTAS_A_RECEBER);
                    somar_valores_cr();

                }
                catch
                {
                    MessageBox.Show("Erro na pesquisa ABERTOS por data e Cliente");
                    fbConnection1.Close();
                }
            }
            if (cb_data_cr.Checked == true && cb_cliente_cr.Checked == false)
            {
                try
                {
                    dsContas_a_receber.Clear();
                    this.datContas_a_receber.SelectCommand.CommandText =
                        "SELECT * FROM CONTAS_A_RECEBER WHERE (DATA_RECEBIMENTO_CR >= '" + Convert.ToDateTime(dtInicial_cr.Text).ToShortDateString().Replace("/", ".") + "'" +
                        "AND DATA_RECEBIMENTO_CR <= '" + Convert.ToDateTime(dtFinal_cr.Text).ToShortDateString().Replace("/", ".") + "') AND (RECEBIDO_CR != 1 OR RECEBIDO_CR IS NULL) ORDER BY DATA_PREVISTA_CR";
                    this.fbConnection1.Open();
                    this.datContas_a_receber.SelectCommand.Connection = fbConnection1;
                    this.datContas_a_receber.SelectCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                    datContas_a_receber.Fill(CONTAS_A_RECEBER);
                    somar_valores_cr();

                }
                catch
                {
                    MessageBox.Show("Erro na pesquisa ABERTOS por data");
                    fbConnection1.Close();
                }
            }
            if (cb_data_cr.Checked == false && cb_cliente_cr.Checked == true)
            {
                try
                {
                    dsContas_a_receber.Clear();
                    this.datContas_a_receber.SelectCommand.CommandText =
                        "SELECT * FROM CONTAS_A_RECEBER WHERE COD_CLIENTE_CR = '" + tb_cod_cliente_cr.Text + "' AND (RECEBIDO_CR != 1 OR RECEBIDO_CR IS NULL) ORDER BY DATA_PREVISTA_CR";
                    this.fbConnection1.Open();
                    this.datContas_a_receber.SelectCommand.Connection = fbConnection1;
                    this.datContas_a_receber.SelectCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                    datContas_a_receber.Fill(CONTAS_A_RECEBER);
                    somar_valores_cr();

                }
                catch
                {
                    MessageBox.Show("Erro na pesquisa ABERTOS por fornecedor");
                    fbConnection1.Close();
                }
            }


        }
        */

        private void pesquisar_abertos_cr()
        {
            if (cb_data_cr.Checked == true && cb_cliente_cr.Checked == true)
            {
                try
                {
                    dsContas_a_receber.Clear();
                    this.datContas_a_receber.SelectCommand.CommandText =
                        "SELECT * FROM CONTAS_A_RECEBER WHERE (DATA_RECEBIMENTO_CR >= '" + Convert.ToDateTime(dtInicial_cr.Text).ToShortDateString().Replace("/", ".") + "'" +
                        "AND DATA_RECEBIMENTO_CR <= '" + Convert.ToDateTime(dtFinal_cr.Text).ToShortDateString().Replace("/", ".") + "')" +
                        "AND COD_CLIENTE_CR = '" + tb_cod_cliente_cr.Text + "' AND (RECEBIDO_CR != 1 OR RECEBIDO_CR IS NULL) ORDER BY DATA_PREVISTA_CR";
                    this.fbConnection1.Open();
                    this.datContas_a_receber.SelectCommand.Connection = fbConnection1;
                    this.datContas_a_receber.SelectCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                    datContas_a_receber.Fill(CONTAS_A_RECEBER);
                    somar_valores_cr();

                }
                catch
                {
                    MessageBox.Show("Erro na pesquisa ABERTOS por data e Cliente");
                    fbConnection1.Close();
                }
            }
            if (cb_data_cr.Checked == true && cb_cliente_cr.Checked == false)
            {
                try
                {
                    dsContas_a_receber.Clear();
                    this.datContas_a_receber.SelectCommand.CommandText =
                        "SELECT * FROM CONTAS_A_RECEBER WHERE (DATA_RECEBIMENTO_CR >= '" + Convert.ToDateTime(dtInicial_cr.Text).ToShortDateString().Replace("/", ".") + "'" +
                        "AND DATA_RECEBIMENTO_CR <= '" + Convert.ToDateTime(dtFinal_cr.Text).ToShortDateString().Replace("/", ".") + "') AND (RECEBIDO_CR != 1 OR RECEBIDO_CR IS NULL) ORDER BY DATA_PREVISTA_CR";
                    this.fbConnection1.Open();
                    this.datContas_a_receber.SelectCommand.Connection = fbConnection1;
                    this.datContas_a_receber.SelectCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                    datContas_a_receber.Fill(CONTAS_A_RECEBER);
                    somar_valores_cr();

                }
                catch
                {
                    MessageBox.Show("Erro na pesquisa ABERTOS por data");
                    fbConnection1.Close();
                }
            }
            if (cb_data_cr.Checked == false && cb_cliente_cr.Checked == true)
            {
                try
                {
                    dsContas_a_receber.Clear();
                    this.datContas_a_receber.SelectCommand.CommandText =
                        "SELECT * FROM CONTAS_A_RECEBER WHERE COD_CLIENTE_CR = '" + tb_cod_cliente_cr.Text + "' AND (RECEBIDO_CR != 1 OR RECEBIDO_CR IS NULL) ORDER BY DATA_PREVISTA_CR";
                    this.fbConnection1.Open();
                    this.datContas_a_receber.SelectCommand.Connection = fbConnection1;
                    this.datContas_a_receber.SelectCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                    datContas_a_receber.Fill(CONTAS_A_RECEBER);
                    somar_valores_cr();

                }
                catch
                {
                    MessageBox.Show("Erro na pesquisa ABERTOS por fornecedor");
                    fbConnection1.Close();
                }
            }


        }

        private void pesquisar_atrasados_cr()
        {
            if (cb_data_cr.Checked == true && cb_cliente_cr.Checked == true)
            {
                try
                {
                    dsContas_a_receber.Clear();
                    this.datContas_a_receber.SelectCommand.CommandText =
                        "SELECT * FROM CONTAS_A_RECEBER WHERE (DATA_PREVISTA_CR >= '" + Convert.ToDateTime(dtInicial_cr.Text).ToShortDateString().Replace("/", ".") + "'" +
                        "AND DATA_PREVISTA_CR <= '" + Convert.ToDateTime(dtFinal_cr.Text).ToShortDateString().Replace("/", ".") + "')" +
                        "AND COD_CLIENTE_CR = '" + tb_cod_cliente_cr.Text + "' AND (RECEBIDO_CR != 1 OR RECEBIDO_CR IS NULL) AND DATA_PREVISTA_CR < '" + DateTime.Now.ToShortDateString().Replace("/", ".") + "' ORDER BY DATA_PREVISTA_CR";
                    this.fbConnection1.Open();
                    this.datContas_a_receber.SelectCommand.Connection = fbConnection1;
                    this.datContas_a_receber.SelectCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                    datContas_a_receber.Fill(CONTAS_A_RECEBER);
                    somar_valores_cr();

                }
                catch
                {
                    MessageBox.Show("Erro na pesquisa ATRASADOS por data e fornecedor");
                    fbConnection1.Close();
                }
            }
            if (cb_data_cr.Checked == true && cb_cliente_cr.Checked == false)
            {
                try
                {
                    dsContas_a_receber.Clear();
                    this.datContas_a_receber.SelectCommand.CommandText =
                        "SELECT * FROM CONTAS_A_RECEBER WHERE (DATA_PREVISTA_CR >= '" + Convert.ToDateTime(dtInicial_cr.Text).ToShortDateString().Replace("/", ".") + "'" +
                        "AND DATA_PREVISTA_CR <= '" + Convert.ToDateTime(dtFinal_cr.Text).ToShortDateString().Replace("/", ".") + "') AND (RECEBIDO_CR != 1 OR RECEBIDO_CR IS NULL) AND DATA_PREVISTA_CR < '" + DateTime.Now.ToShortDateString().Replace("/", ".") + "' ORDER BY DATA_PREVISTA_CR";
                    this.fbConnection1.Open();
                    this.datContas_a_receber.SelectCommand.Connection = fbConnection1;
                    this.datContas_a_receber.SelectCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                    datContas_a_receber.Fill(CONTAS_A_RECEBER);
                    somar_valores_cr();

                }
                catch
                {
                    MessageBox.Show("Erro na pesquisa ATRASADOS por data");
                    fbConnection1.Close();
                }
            }
            if (cb_data_cr.Checked == false && cb_cliente_cr.Checked == true)
            {
                try
                {
                    dsContas_a_receber.Clear();
                    this.datContas_a_receber.SelectCommand.CommandText =
                        "SELECT * FROM CONTAS_A_RECEBER WHERE COD_CLIENTE_CR = '" + tb_cod_cliente_cr.Text + "' AND (RECEBIDO_CR != 1 OR RECEBIDO_CR IS NULL) AND DATA_PREVISTA_CR < '" + DateTime.Now.ToShortDateString().Replace("/", ".") + "' ORDER BY DATA_PREVISTA_CR";
                    this.fbConnection1.Open();
                    this.datContas_a_receber.SelectCommand.Connection = fbConnection1;
                    this.datContas_a_receber.SelectCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                    datContas_a_receber.Fill(CONTAS_A_RECEBER);
                    somar_valores_cr();

                }
                catch
                {
                    MessageBox.Show("Erro na pesquisa ATRASADOS por fornecedor");
                    fbConnection1.Close();
                }
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            form_operacoes_cp op = new form_operacoes_cp();
            try
            {
                op.adicionar = true;
                op.ShowDialog();
            }
            finally
            {
                dsContas_a_pagar.Clear();
                datContas_a_pagar.Fill(CONTAS_A_PAGAR);
                op.Dispose();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            form_operacoes_cp op = new form_operacoes_cp();
            try
            {
                try
                {
                    op.cod_a_abrir = dgvCp.SelectedRows[0].Cells["col_cod"].Value.ToString();
                    op.excluir = true;
                    op.ShowDialog();
                }
                catch
                {
                    MessageBox.Show("Por favor, selecione a linha inteira");
                }
                
            }
            finally
            {
                dsContas_a_pagar.Clear();
                datContas_a_pagar.Fill(CONTAS_A_PAGAR);
                op.Dispose();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            form_operacoes_cp op = new form_operacoes_cp();
            try
            {
                try
                {
                    op.cod_a_abrir = dgvCp.SelectedRows[0].Cells["col_cod"].Value.ToString();
                    op.alterar = true;
                    op.ShowDialog();
                }
                catch
                {
                    MessageBox.Show("Por favor, selecione a linha inteira");
                }
                
            }
            finally
            {
                dsContas_a_pagar.Clear();
                datContas_a_pagar.Fill(CONTAS_A_PAGAR);
                op.Dispose();
            }
        }

        private void bt_adicionar_cr_Click(object sender, EventArgs e)
        {
            form_operacoes_cr op = new form_operacoes_cr();
            try
            {
                op.adicionar = true;
                op.ShowDialog();
            }
            finally
            {
                dsContas_a_receber.Clear();
                datContas_a_receber.Fill(CONTAS_A_RECEBER);
                op.Dispose();
            }
        }

        private void bt_excluir_cr_Click(object sender, EventArgs e)
        {
            form_operacoes_cr op = new form_operacoes_cr();
            try
            {
                try
                {
                    op.cod_a_abrir = dgvCr.SelectedRows[0].Cells["col_cod_cr"].Value.ToString();
                }
                catch
                {
                    MessageBox.Show("Por favor, selecione a linha inteira");
                }
                op.excluir = true;
                op.ShowDialog();
            }
            finally
            {
                dsContas_a_receber.Clear();
                datContas_a_receber.Fill(CONTAS_A_RECEBER);
                op.Dispose();
            }
        }

        private void bt_alterar_cr_Click(object sender, EventArgs e)
        {
            form_operacoes_cr op = new form_operacoes_cr();
            try
            {
                try
                {
                    op.cod_a_abrir = dgvCr.SelectedRows[0].Cells["col_cod_cr"].Value.ToString();
                }
                catch
                {
                    MessageBox.Show("Por favor, selecione a linha inteira");
                }
                op.alterar = true;
                op.ShowDialog();
            }
            finally
            {
                dsContas_a_pagar.Clear();
                datContas_a_receber.Fill(CONTAS_A_RECEBER);
                op.Dispose();
            }
        }

        private void form_cp_cr_Load(object sender, EventArgs e)
        {
            dgvCp.AutoGenerateColumns = false;
            dgvCp.DataSource = dsContas_a_pagar.Tables["CONTAS_A_PAGAR"];
            dgvCr.AutoGenerateColumns = false;
            dgvCr.DataSource = dsContas_a_receber.Tables["CONTAS_A_RECEBER"];
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (veio_buscar_caixa == true)
            {
                try
                {
                    if (debito == true)
                    {
                        cod_cr_cp = dgvCp.SelectedRows[0].Cells["col_cod"].Value.ToString();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Você não pode fazer essa operação pois selecionou 'Crédito' no caixa");
                    }
                }
                catch
                {
                    MessageBox.Show("Selecione a linha inteira por favor");
                }
            }
            else
            {
                
                if (dgvCp.SelectedRows.Count == 1)
                {
                    inserir_baixa_unica_cp();
                }
                if (dgvCp.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Selecione ao menos uma linha por favor.");
                }
            }
        }

        private void inserir_malote_cp()
        {
            form_malote malote = new form_malote();
            try
            {
                malote.debito = true;
                malote.n_itens_malote = dgvCp.SelectedRows.Count;
                string[] itens = new string[100];
                for (int i = 0; i < dgvCp.SelectedRows.Count; i++)
                {
                    itens[i] = dgvCp.SelectedRows[i].Cells["col_cod"].Value.ToString();
                }
                malote._itens = itens;
                malote.novo = true;
                malote.ShowDialog();
            }
            finally
            {

            }
        }

        private void inserir_malote_cr()
        {
            form_malote malote = new form_malote();
            try
            {
                malote.credito = true;
                malote.n_itens_malote = dgvCr.SelectedRows.Count;
                string[] itens = new string[100];
                for (int i = 0; i < dgvCr.SelectedRows.Count; i++)
                {
                    itens[i] = dgvCr.SelectedRows[i].Cells["col_cod_cr"].Value.ToString();
                }
                malote._itens = itens;
                malote.novo = true;
                malote.ShowDialog();
            }
            finally
            {

            }
        }

        private void inserir_baixa_unica_cp()
        {
            form_operacoes_caixa caixa = new form_operacoes_caixa();
            try
            {
                caixa.adicionar = true;
                caixa.cp_cr_a_vincular = dgvCp.SelectedRows[0].Cells["col_cod"].Value.ToString();
                caixa.debito = true;
                caixa.ShowDialog();
            }
            finally
            {
                caixa.Dispose();

            }
        }

        private void inserir_baixa_unica_cr()
        {
            form_operacoes_caixa caixa = new form_operacoes_caixa();
            try
            {
                caixa.adicionar = true;
                caixa.cp_cr_a_vincular = dgvCr.SelectedRows[0].Cells["col_cod_cr"].Value.ToString();
                caixa.credito = true;
                caixa.ShowDialog();
            }
            finally
            {
                caixa.Dispose();

            }
        }

        private void bt_baixar_cr_Click(object sender, EventArgs e)
        {
            if (veio_buscar_caixa == true)
            {
                try
                {
                    if (credito == true)
                    {
                        cod_cr_cp = dgvCr.SelectedRows[0].Cells["col_cod_cr"].Value.ToString();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Você não pode fazer essa operação pois selecionou 'Débito' no caixa");
                    }
                }
                catch
                {
                    MessageBox.Show("Selecione a linha inteira por favor");
                }
            }
            else
            {
                if (dgvCr.SelectedRows.Count == 1)
                {
                    inserir_baixa_unica_cr();
                }
                if (dgvCr.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Selecione ao menos uma linha por favor.");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dgvCp.SelectedRows[0].Cells["col_descricao"].Value.ToString() + " " + dgvCp.SelectedRows[1].Cells["col_descricao"].Value.ToString());// + " " + dgvCr.SelectedRows[2].Cells["col_cod_cr"].Value.ToString());
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (dgvCp.SelectedRows.Count > 0)
            {
                inserir_malote_cp();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb_data_cp.Checked == true)
                {

                    this.datImp_cp_cr.DeleteCommand.CommandText =
                        "DELETE FROM IMP_CP_CR";
                    this.fbConnection1.Open();
                    this.datImp_cp_cr.DeleteCommand.Connection = fbConnection1;
                    this.datImp_cp_cr.DeleteCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();

                    this.datImp_cp_cr.InsertCommand.CommandText =
                    "INSERT INTO IMP_CP_CR (DATA_INICIAL_IMP_CP_CR, DATA_FINAL_IMP_CP_CR)" +
                    "VALUES ('" + Convert.ToDateTime(dtInicial_cp.Text).ToShortDateString().Replace("/",".") +
                    "','" + Convert.ToDateTime(dtFinal_cp.Text).ToShortDateString().Replace("/", ".") + "')";
                    this.fbConnection1.Open();
                    this.datImp_cp_cr.InsertCommand.Connection = fbConnection1;
                    this.datImp_cp_cr.InsertCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                }
                dsCp_cr imprimir = new dsCp_cr();
                fbConnection1.Open();
                datImp_cp_cr.Fill(imprimir.IMP_CP_CR);
                datContas_a_pagar.Fill(imprimir.CONTAS_A_PAGAR);
                fbConnection1.Close();
                crContas_a_pagar novo_ped = new crContas_a_pagar();
                novo_ped.SetDataSource(imprimir);
                form_imprimir imprime = new form_imprimir(novo_ped);
                imprime.Show();
                
            }
            catch
            {
                fbConnection1.Close();
            }
        }

        private void bt_imprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb_data_cp.Checked == true)
                {

                    this.datImp_cp_cr.DeleteCommand.CommandText =
                        "DELETE FROM IMP_CP_CR";
                    this.fbConnection1.Open();
                    this.datImp_cp_cr.DeleteCommand.Connection = fbConnection1;
                    this.datImp_cp_cr.DeleteCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();

                    this.datImp_cp_cr.InsertCommand.CommandText =
                    "INSERT INTO IMP_CP_CR (DATA_INICIAL_IMP_CP_CR, DATA_FINAL_IMP_CP_CR)" +
                    "VALUES ('" + Convert.ToDateTime(dtInicial_cp.Text).ToShortDateString().Replace("/", ".") +
                    "','" + Convert.ToDateTime(dtFinal_cp.Text).ToShortDateString().Replace("/", ".") + "')";
                    this.fbConnection1.Open();
                    this.datImp_cp_cr.InsertCommand.Connection = fbConnection1;
                    this.datImp_cp_cr.InsertCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                }
                dsCp_cr imprimir = new dsCp_cr();
                fbConnection1.Open();
                datImp_cp_cr.Fill(imprimir.IMP_CP_CR);
                datContas_a_receber.Fill(imprimir.CONTAS_A_RECEBER);
                fbConnection1.Close();
                crContas_a_receber novo_ped = new crContas_a_receber();
                novo_ped.SetDataSource(imprimir);
                form_imprimir imprime = new form_imprimir(novo_ped);
                imprime.Show();

            }
            catch
            {
                fbConnection1.Close();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (dgvCr.SelectedRows.Count > 0)
            {
                inserir_malote_cr();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dsContas_a_pagar.Tables["CONTAS_A_PAGAR"].DefaultView.RowFilter = "DESCRICAO_CP LIKE '*" + tb_filtro_descricao.Text + "*'";
        }

        private void tb_filtro_fornecedor_TextChanged(object sender, EventArgs e)
        {
            dsContas_a_pagar.Tables["CONTAS_A_PAGAR"].DefaultView.RowFilter = "RAZAO_FORNECEDOR_CP LIKE '*" + tb_filtro_fornecedor.Text + "*'";
        }

        private void tb_filtro_cr_descricao_TextChanged(object sender, EventArgs e)
        {
            dsContas_a_receber.Tables["CONTAS_A_RECEBER"].DefaultView.RowFilter = "DESCRICAO_CR LIKE '*" + tb_filtro_cr_descricao.Text + "*'";
        }

        private void tb_filtro_cr_cliente_TextChanged(object sender, EventArgs e)
        {
            dsContas_a_receber.Tables["CONTAS_A_RECEBER"].DefaultView.RowFilter = "RAZAO_CLIENTE_CR LIKE '*" + tb_filtro_cr_cliente.Text + "*'";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string _cp_descricao = "", _cp_valor = "", _cp_data_prevista = "", _cp_data_pgto = "", _cp_cod_forn = "", _cp_fornecedor = "", _cp_plano = "", _cp_carteira = "";
            comando_select.CommandText = "SELECT * FROM CONTAS_A_PAGAR WHERE COD_CP = '" + dgvCp.SelectedRows[0].Cells["col_cod"].Value.ToString() + "'";
            DataSet cp = new DataSet();
            fbConnection1.Open();
            datContas_a_pagar.SelectCommand = comando_select;
            datContas_a_pagar.Fill(cp);
            fbConnection1.Close();
            foreach (DataRow dr in cp.Tables[0].Rows)
            {
                
                _cp_descricao = dr["DESCRICAO_CP"].ToString();
                _cp_valor = dr["VALOR_CP"].ToString();
                _cp_data_prevista = dr["DATA_PREVISTA_CP"].ToString();
                _cp_data_pgto = dr["DATA_PAGAMENTO_CP"].ToString();
                _cp_cod_forn = dr["COD_FORNECEDOR_CP"].ToString();
                _cp_fornecedor = dr["RAZAO_FORNECEDOR_CP"].ToString();
                _cp_plano = dr["PLANO_CP"].ToString();
                _cp_carteira = dr["CARTEIRA_CP"].ToString();
            }

            form_multiplicar_cp_cr cp_cr = new form_multiplicar_cp_cr();
            try
            {
                cp_cr._multiplicar_cp = true;
                cp_cr._cp_descricao = _cp_descricao;
                cp_cr._cp_valor = _cp_valor;
                cp_cr._cp_data_prevista = _cp_data_prevista;
                cp_cr._cp_data_pgto = _cp_data_pgto;
                cp_cr._cp_cod_forn = _cp_cod_forn;
                cp_cr._cp_fornecedor = _cp_fornecedor;
                cp_cr._cp_plano = _cp_plano;
                cp_cr._cp_carteira = _cp_carteira;
                cp_cr.ShowDialog();
            }
            finally
            {
                cp_cr.Dispose();
                datContas_a_pagar.Fill(CONTAS_A_PAGAR);
            }
        }

        private void bt_multiplicar_cr_Click(object sender, EventArgs e)
        {
            string _cr_descricao = "", _cr_valor = "", _cr_data_prevista = "", _cr_data_pgto = "", _cr_cod_cliente = "", _cr_cliente = "", _cr_plano = "", _cr_carteira = "";
            comando_select.CommandText = "SELECT * FROM CONTAS_A_RECEBER WHERE COD_CR = '" + dgvCr.SelectedRows[0].Cells["col_cod_cr"].Value.ToString() + "'";
            DataSet cr = new DataSet();
            fbConnection1.Open();
            datContas_a_receber.SelectCommand = comando_select;
            datContas_a_receber.Fill(cr);
            fbConnection1.Close();
            foreach (DataRow dr in cr.Tables[0].Rows)
            {

                _cr_descricao = dr["DESCRICAO_CR"].ToString();
                _cr_valor = dr["VALOR_CR"].ToString();
                _cr_data_prevista = dr["DATA_PREVISTA_CR"].ToString();
                _cr_data_pgto = dr["DATA_RECEBIMENTO_CR"].ToString();
                _cr_cod_cliente = dr["COD_CLIENTE_CR"].ToString();
                _cr_cliente = dr["RAZAO_CLIENTE_CR"].ToString();
                _cr_plano = dr["PLANO_CR"].ToString();
                _cr_carteira = dr["CARTEIRA_CR"].ToString();
            }

            form_multiplicar_cp_cr cp_cr = new form_multiplicar_cp_cr();
            try
            {
                cp_cr._multiplicar_cr = true;
                cp_cr._cr_descricao = _cr_descricao;
                cp_cr._cr_valor = _cr_valor;
                cp_cr._cr_data_prevista = _cr_data_prevista;
                cp_cr._cr_data_pgto = _cr_data_pgto;
                cp_cr._cr_cod_cliente = _cr_cod_cliente;
                cp_cr._cr_cliente = _cr_cliente;
                cp_cr._cr_plano = _cr_plano;
                cp_cr._cr_carteira = _cr_carteira;
                cp_cr.ShowDialog();
            }
            finally
            {
                cp_cr.Dispose();
                datContas_a_receber.Fill(CONTAS_A_RECEBER);
            }
        }

        

       
    }
}