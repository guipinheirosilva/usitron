using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_caixa : Form
    {
        public form_caixa()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (rbCreditos.Checked == false && rbDebitos.Checked == false && rbTodos.Checked == false)
            {
                rbTodos.Checked = true;
            }
            if (rbTodos.Checked == true)
            {
                pesquisar_todos_caixa();
            }

        }

        private void pesquisar_todos_caixa()
        {
            if (cb_data_cr.Checked == true && rb_cliente.Checked == true)
            {
                try
                {
                    dsCaixa.Clear();
                    this.datCaixa.SelectCommand.CommandText =
                        "SELECT * FROM CAIXA WHERE (DATA_CAIXA >= '" + Convert.ToDateTime(dtInicial_cr.Text).ToShortDateString().Replace("/", ".") + "'" +
                        "AND DATA_CAIXA <= '" + Convert.ToDateTime(dtFinal_cr.Text).ToShortDateString().Replace("/", ".") + "')" +
                        "AND COD_FORN_CLI_CAIXA = '" + tb_cod_cliente_cr.Text + "'";
                    this.fbConnection1.Open();
                    this.datCaixa.SelectCommand.Connection = fbConnection1;
                    this.datCaixa.SelectCommand.ExecuteNonQuery();
                    this.fbConnection1.Close(); 
                    datCaixa.Fill(CAIXA);
                    somar_valores_caixa();

                }
                catch
                {
                    MessageBox.Show("Erro na pesquisa TODOS por data e cliente");
                    fbConnection1.Close(); 
                }
            }
            else
            {
                if (cb_data_cr.Checked == true && rb_cc.Checked == true)
                {
                    try
                    {
                        if (tb_cod_cc_caixa.Text == "")
                        {
                            MessageBox.Show("Selecione a Conta Corrente por favor");
                        }
                        else
                        {
                            dsCaixa.Clear();
                            this.datCaixa.SelectCommand.CommandText =
                                "SELECT * FROM CAIXA WHERE (DATA_CAIXA >= '" + Convert.ToDateTime(dtInicial_cr.Text).ToShortDateString().Replace("/", ".") + "'" +
                                "AND DATA_CAIXA <= '" + Convert.ToDateTime(dtFinal_cr.Text).ToShortDateString().Replace("/", ".") + "')" +
                                "AND CC_CAIXA = '" + tb_cod_cc_caixa.Text + "'";
                            this.fbConnection1.Open();
                            this.datCaixa.SelectCommand.Connection = fbConnection1;
                            this.datCaixa.SelectCommand.ExecuteNonQuery();
                            this.fbConnection1.Close(); 
                            datCaixa.Fill(CAIXA);
                            somar_valores_caixa();
                        }

                    }
                    catch
                    {
                        MessageBox.Show("Erro na pesquisa TODOS por data e conta corrente");
                        fbConnection1.Close(); 
                    }
                }
                else
                {
                    try
                    {
                        dsCaixa.Clear();
                        this.datCaixa.SelectCommand.CommandText =
                            "SELECT * FROM CAIXA WHERE (DATA_CAIXA >= '" + Convert.ToDateTime(dtInicial_cr.Text).ToShortDateString().Replace("/", ".") + "'" +
                            "AND DATA_CAIXA <= '" + Convert.ToDateTime(dtFinal_cr.Text).ToShortDateString().Replace("/", ".") + "')";
                        this.fbConnection1.Open();
                        this.datCaixa.SelectCommand.Connection = fbConnection1;
                        this.datCaixa.SelectCommand.ExecuteNonQuery();
                        this.fbConnection1.Close(); 
                        datCaixa.Fill(CAIXA);
                        somar_valores_caixa();

                    }
                    catch
                    {
                        MessageBox.Show("Erro na pesquisa TODOS por data");
                        fbConnection1.Close(); 
                    }
                }
            }
            

        }

        private void somar_valores_caixa()
        {
            double _total_debitos = 0, _total_creditos = 0, _balanco = 0;
            for (int i = 0; i < dgvCaixa.RowCount; i++)
            {
                if (dgvCaixa.Rows[i].Cells["col_debito"].Value.ToString() == "1")
                {
                    _total_debitos = _total_debitos + Convert.ToDouble(dgvCaixa.Rows[i].Cells["col_valor"].Value.ToString());
                }
                if (dgvCaixa.Rows[i].Cells["col_credito"].Value.ToString() == "1")
                {
                    _total_creditos = _total_creditos + Convert.ToDouble(dgvCaixa.Rows[i].Cells["col_valor"].Value.ToString());
                }
            }

            _balanco = _total_creditos - _total_debitos;
            tb_balanco.Text = _balanco.ToString("n2");
            tb_valor_creditos.Text = _total_creditos.ToString("n2");
            tb_valor_debitos.Text = _total_debitos.ToString("n2");

        }

        private void bt_adicionar_cr_Click(object sender, EventArgs e)
        {
            form_operacoes_caixa op = new form_operacoes_caixa();
            try
            {
                op.adicionar = true;
                op.ShowDialog();
            }
            finally
            {
                dsCaixa.Clear();
                datCaixa.Fill(CAIXA);
                op.Dispose();
            }
        }

        private void dgvCaixa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bt_alterar_cr_Click(object sender, EventArgs e)
        {
            form_operacoes_caixa op = new form_operacoes_caixa();
            try
            {
                try
                {
                    op.cod_a_abrir = dgvCaixa.SelectedRows[0].Cells["col_cod"].Value.ToString();
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
                dsCaixa.Clear();
                datCaixa.Fill(CAIXA);
                op.Dispose();
            }
        }

        private void bt_excluir_cr_Click(object sender, EventArgs e)
        {
            form_operacoes_caixa op = new form_operacoes_caixa();
            try
            {
                try
                {
                    op.cod_a_abrir = dgvCaixa.SelectedRows[0].Cells["col_cod"].Value.ToString();

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
                dsCaixa.Clear();
                datCaixa.Fill(CAIXA);
                op.Dispose();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.datMalotes.SelectCommand.CommandText =
                        "SELECT * FROM MALOTES ORDER BY DATA_MALOTE DESC";
            this.fbConnection1.Open();
            this.datMalotes.SelectCommand.Connection = fbConnection1;
            this.datMalotes.SelectCommand.ExecuteNonQuery();
            datMalotes.Fill(MALOTES);
            this.fbConnection1.Close(); 
        }

        private void dgvMalotes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dsCaixa.Clear();
                this.datCaixa.SelectCommand.CommandText =
                            "SELECT * FROM CAIXA WHERE MALOTE_CAIXA = '" + dgvMalotes.Rows[e.RowIndex].Cells["col_cod_malote"].Value.ToString() + "'";
                this.fbConnection1.Open();
                this.datCaixa.SelectCommand.Connection = fbConnection1;
                this.datCaixa.SelectCommand.ExecuteNonQuery();
                datCaixa.Fill(CAIXA);
                this.fbConnection1.Close(); 
                somar_valores_caixa();
            }
            catch
            {
                fbConnection1.Close(); 
            }
        }

        private void dgvMalotes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            form_malote malote = new form_malote();
            try
            {
                malote.abrir = true;
                malote._cod_malote_a_abrir = dgvMalotes.Rows[e.RowIndex].Cells["col_cod_malote"].Value.ToString();
                malote.ShowDialog();
            }
            finally
            {
                malote.Dispose();
                datMalotes.Fill(MALOTES);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form_cc cc = new form_cc();
            try
            {
                cc.ShowDialog();

            }
            finally
            {
                tb_cod_cc_caixa.Text = cc.cod_escolhido;
                tb_descricao_cc_caixa.Text = cc.descricao_escolhido;

            }
        }

        private void bt_imprimir_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (cb_data_cr.Checked == true)
                {

                    this.datImp_caixa.DeleteCommand.CommandText =
                        "DELETE FROM IMP_CAIXA";
                    this.fbConnection1.Open();
                    this.datImp_caixa.DeleteCommand.Connection = fbConnection1;
                    this.datImp_caixa.DeleteCommand.ExecuteNonQuery();
                    this.fbConnection1.Close(); 
                    string _conta_corrente = "";
                    _conta_corrente = tb_descricao_cc_caixa.Text;
                    if (_conta_corrente == "")
                        _conta_corrente = "null";
                    else
                        _conta_corrente = "'" + _conta_corrente + "'";
                    this.datImp_caixa.InsertCommand.CommandText =
                    "INSERT INTO IMP_CAIXA (VALOR_DEBITOS_CAIXA, VALOR_CREDITO_CAIXA, BALANCO_CAIXA, DATA_INICIAL_CAIXA, DATA_FINAL_CAIXA, CONTA_CORRENTE_CAIXA)" +
                    "VALUES ('" + tb_valor_debitos.Text.Replace(".","").Replace(",",".") + "','" + tb_valor_creditos.Text.Replace(".","").Replace(",",".") +  "','" + tb_balanco.Text.Replace(".","").Replace(",",".") + "','" + Convert.ToDateTime(dtInicial_cr.Text).ToShortDateString().Replace("/", ".") +
                    "','" + Convert.ToDateTime(dtFinal_cr.Text).ToShortDateString().Replace("/", ".") + "'," + _conta_corrente + ")";
                    this.fbConnection1.Open();
                    this.datImp_caixa.InsertCommand.Connection = fbConnection1;
                    this.datImp_caixa.InsertCommand.ExecuteNonQuery();
                    this.fbConnection1.Close(); 
                }
                
                dsMalote imprimir = new dsMalote();
                fbConnection1.Open();
                datImp_caixa.Fill(imprimir.IMP_CAIXA);
                datCaixa.Fill(imprimir.CAIXA);
                fbConnection1.Close(); 
                crCaixa novo_ped = new crCaixa();
                novo_ped.SetDataSource(imprimir);
                form_imprimir imprime = new form_imprimir(novo_ped);
                imprime.Show();

            }
            catch
            {
                fbConnection1.Close(); 
            }
        }

        private void form_caixa_Load(object sender, EventArgs e)
        {

        }

       


    }
}