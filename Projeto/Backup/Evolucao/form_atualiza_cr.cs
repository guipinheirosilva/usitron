using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_atualiza_cr : Form
    {
        public form_atualiza_cr()
        {
            InitializeComponent();
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
        private void somar_valores_cr()
        {
            double _total_cr = 0;
            double _total_atual = 0;
            for (int i = 0; i < dgvCr.RowCount; i++)
            {
                try
                {
                    _total_cr = _total_cr + Convert.ToDouble(dgvCr.Rows[i].Cells["col_valor_total_cr"].Value);
                    _total_atual = _total_atual + Convert.ToDouble(dgvCr.Rows[i].Cells["col_valor_atualizado"].Value);
                }
                catch { }
            }
            tb_valor_total_cr.Text = _total_cr.ToString("n2");
            tb_total_atualizado.Text = _total_atual.ToString("n2");
            double juros = _total_atual - _total_cr;
            if(juros > 0)
                tb_juros.Text = juros.ToString("n2");
            

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

        private void pesquisar_abertos_cr()
        {
            if (cb_data_cr.Checked == true && cb_cliente_cr.Checked == true)
            {
                try
                {
                    dsContas_a_receber.Clear();
                    this.datContas_a_receber.SelectCommand.CommandText =
                        "SELECT * FROM CONTAS_A_RECEBER WHERE (DATA_PREVISTA_CR >= '" + Convert.ToDateTime(dtInicial_cr.Text).ToShortDateString().Replace("/", ".") + "'" +
                        "AND DATA_PREVISTA_CR <= '" + Convert.ToDateTime(dtFinal_cr.Text).ToShortDateString().Replace("/", ".") + "')" +
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
                        "SELECT * FROM CONTAS_A_RECEBER WHERE (DATA_PREVISTA_CR >= '" + Convert.ToDateTime(dtInicial_cr.Text).ToShortDateString().Replace("/", ".") + "'" +
                        "AND DATA_PREVISTA_CR <= '" + Convert.ToDateTime(dtFinal_cr.Text).ToShortDateString().Replace("/", ".") + "') AND (RECEBIDO_CR != 1 OR RECEBIDO_CR IS NULL) ORDER BY DATA_PREVISTA_CR";
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
        private void tb_filtro_cr_descricao_TextChanged(object sender, EventArgs e)
        {
            dsContas_a_receber.Tables["CONTAS_A_RECEBER"].DefaultView.RowFilter = "DESCRICAO_CR LIKE '*" + tb_filtro_cr_descricao.Text + "*'";
        }

        private void tb_filtro_cr_cliente_TextChanged(object sender, EventArgs e)
        {
            dsContas_a_receber.Tables["CONTAS_A_RECEBER"].DefaultView.RowFilter = "RAZAO_CLIENTE_CR LIKE '*" + tb_filtro_cr_cliente.Text + "*'";
        }

        private void form_atualiza_cr_Load(object sender, EventArgs e)
        {
            dgvCr.AutoGenerateColumns = false;
            dgvCr.DataSource = dsContas_a_receber.Tables["CONTAS_A_RECEBER"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_aliquota.Text == "")
            {
                tb_aliquota.Text = "0,15";
            }
            double aliquota = Convert.ToDouble(tb_aliquota.Text);
            for (int i = 0; i < dgvCr.RowCount; i++)
            {
                double valor_original = Convert.ToDouble(dgvCr.Rows[i].Cells["col_valor_total_cr"].Value);
                int numero_dias = 0;
                double juros = 0;
                DateTime dia_vencimento = Convert.ToDateTime(dgvCr.Rows[i].Cells["col_data_vencimento"].Value);
                DateTime dia_pgto = Convert.ToDateTime(dtData_pgto.Text);
                TimeSpan dias = dia_pgto - dia_vencimento;
                numero_dias = Convert.ToInt32(dias.Days.ToString()) ;
                if (numero_dias < 7 && numero_dias > -7)
                    numero_dias = 0;
                juros = Convert.ToDouble(dgvCr.Rows[i].Cells["col_valor_total_cr"].Value) * numero_dias * (aliquota/100);
                double valor_atualizado = valor_original + juros;
                if (numero_dias < 0)
                {
                    aliquota = Convert.ToDouble("0,05");
                    juros = Convert.ToDouble(dgvCr.Rows[i].Cells["col_valor_total_cr"].Value) * numero_dias * (aliquota/100);
                    valor_atualizado = valor_original + juros;
                }
                dgvCr.Rows[i].Cells["col_valor_atualizado"].Value = valor_atualizado.ToString("n2").Replace(".", "");

            }
            somar_valores_cr();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvCr.SelectedRows.Count > 0)
            {
                Atualizar();
                inserir_malote_cr();

            }
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

        
    }
}