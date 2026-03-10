using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace Evolucao
{
    public partial class form_pesquisa_orcamentos : Form
    {
        public string _cod_escolhido;
        string cnpj_empresa;
        public form_pesquisa_orcamentos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string cliente = "";
                if (tb_cnpj_cliente.Text != "")
                {
                    cliente = " AND CLIENTE_ORCAMENTO = '" + tb_cliente.Text + "'";
                }

                DateTime inicio = Convert.ToDateTime(dtInicio.Text);
                DateTime termino = Convert.ToDateTime(dtTermino.Text);
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                select.CommandText =
                    "SELECT COD_ORCAMENTO FROM ORCAMENTOS WHERE DATA_ORCAMENTO >= '" + inicio.ToShortDateString().Replace("/", ".") + "'" +
                    "AND DATA_ORCAMENTO <= '" + termino.ToShortDateString().Replace("/", ".") + "'" + cliente;
                fbConnection1.Open();
                FbDataAdapter datOrcamentos = new FbDataAdapter();
                datOrcamentos.SelectCommand = select;
                DataSet dsOrcamentos = new DataSet();
                datOrcamentos.Fill(dsOrcamentos);
                fbConnection1.Close();
                string _where_orcamentos = "WHERE (";
                int i = 0;
                foreach (DataRow dr in dsOrcamentos.Tables[0].Rows)
                {
                    if (i == 0)
                        _where_orcamentos = _where_orcamentos + "COD_ORCAMENTO_ITEM_ORC = '" + dr[0].ToString() + "'";
                    else
                        _where_orcamentos = _where_orcamentos + " OR COD_ORCAMENTO_ITEM_ORC = '" + dr[0].ToString() + "'";
                    i++;
                }
                if (i > 0)
                {
                    _where_orcamentos = _where_orcamentos + ")";
                    if (rbAprovadas.Checked)
                        _where_orcamentos = _where_orcamentos + " AND STATUS_ITEM_ORC = 'ITEM APROVADO'";
                    if (rbReprovadas.Checked)
                        _where_orcamentos = _where_orcamentos + " AND STATUS_ITEM_ORC = 'ITEM REPROVADO'";
                    if (rbEm_aberto.Checked)
                        _where_orcamentos = _where_orcamentos + " AND STATUS_ITEM_ORC = 'ITEM INSERIDO'";
                }
                else
                {
                    _where_orcamentos = _where_orcamentos.Replace("(", "");
                    if (rbAprovadas.Checked)
                        _where_orcamentos = _where_orcamentos + " STATUS_ITEM_ORC = 'ITEM APROVADO'";
                    if (rbReprovadas.Checked)
                        _where_orcamentos = _where_orcamentos + " STATUS_ITEM_ORC = 'ITEM REPROVADO'";
                    if (rbEm_aberto.Checked)
                        _where_orcamentos = _where_orcamentos + " STATUS_ITEM_ORC = 'ITEM INSERIDO'";
                }
                
                dsItens_orcamento.Clear();
                datItens_orcamento.SelectCommand.CommandText =
                    "SELECT * FROM ITENS_ORCAMENTO " + _where_orcamentos;
                fbConnection1.Open();
                datItens_orcamento.SelectCommand.Connection = fbConnection1;
                datItens_orcamento.SelectCommand.ExecuteNonQuery();
                fbConnection1.Close();
                datItens_orcamento.Fill(ITENS_ORCAMENTO);
                calcular();

            }
            catch(Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form_localiza_cliente localiza_cliente = new form_localiza_cliente(true, cnpj_empresa);
            try
            {
                localiza_cliente.ShowDialog();
            }
            finally
            {
                localiza_cliente.Dispose();
                tb_cnpj_cliente.Text = localiza_cliente.cnpj_escolhido;
                tb_cliente.Text = localiza_cliente.cliente_escolhido;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsItens_orcamento.Tables["ITENS_ORCAMENTO"].DefaultView.RowFilter = "NOME_ITEM_ORC Like '*" + textBox1.Text + "*'";
                calcular();
            }
            catch { }
        }

        private void calcular()
        {
            double valor_total = 0;
            for (int i = 0; i < dgvItens_orcamento.RowCount; i++)
            {
                try
                {
                    valor_total = valor_total + Convert.ToDouble(dgvItens_orcamento.Rows[i].Cells["col_valor_total"].Value.ToString());
                }
                catch { }
            }
            tb_valor_total.Text = valor_total.ToString("n2");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsItens_orcamento.Tables["ITENS_ORCAMENTO"].DefaultView.RowFilter = "COD_ORCAMENTO_ITEM_ORC = '" + textBox2.Text + "'";
                calcular();
            }
            catch { }
        }

        private void form_pesquisa_orcamentos_Load(object sender, EventArgs e)
        {
            dgvItens_orcamento.AutoGenerateColumns = false;
            dgvItens_orcamento.DataSource = dsItens_orcamento.Tables["ITENS_ORCAMENTO"];
        }

        private void dgvItens_orcamento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _cod_escolhido = dgvItens_orcamento.Rows[e.RowIndex].Cells["col_cod_item"].Value.ToString();
            this.Close();
        }
    }
}