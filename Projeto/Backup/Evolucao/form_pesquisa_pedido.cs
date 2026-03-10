using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_pesquisa_pedido : Form
    {
        public string cod_ped_escolhido;
        public string[] pedidos_selecionados = new string[500];
        public bool consulta; public bool selecao_nf;
        public int numero_pedidos;
        bool erro = false;
        public form_pesquisa_pedido()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dsPedidos_venda.Clear();
                
                string vendedor = "", cliente = "";

                if (cb_vendedor.Checked == true)
                {
                    vendedor = " AND COD_VENDEDOR_PED_VENDA = '" + tb_cod_vendedor.Text + "' ";
                }
                if (cb_cliente.Checked == true)
                {
                    cliente = " AND CLIENTE_PED_VENDA = '" + tb_nome_cliente.Text + "' ";
                }

                string select = "SELECT * FROM PEDIDOS_VENDA WHERE DATA_PED_VENDA >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") + "' AND DATA_PED_VENDA <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "'" +
                    vendedor + cliente + "ORDER BY DATA_PED_VENDA";
                this.datPedidos_venda.SelectCommand.CommandText = select;
              
                this.fbConnection1.Open();
                this.datPedidos_venda.SelectCommand.Connection = fbConnection1;
                this.datPedidos_venda.SelectCommand.ExecuteNonQuery();
                datPedidos_venda.Fill(PEDIDOS_VENDA);
                this.fbConnection1.Close();
                somar_totais();
            }
            catch
            {
                fbConnection1.Close();
                MessageBox.Show("ERRO");
            }
        }

        private void somar_totais()
        {
            double total = 0;
            for (int i = 0; i < dgvPedidos.RowCount; i++)
            {
                try
                {
                    total = total + Convert.ToDouble(dgvPedidos.Rows[i].Cells["col_valor_total"].Value);
                }
                catch
                { }
            }
            tb_valor_total.Text = total.ToString("n2");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dsPedidos_venda.Tables["PEDIDOS_VENDA"].DefaultView.RowFilter = "CLIENTE_PED_VENDA Like '*" + tb_cliente.Text + "*'";
            somar_totais();
        }

        private void tb_vendedor_TextChanged(object sender, EventArgs e)
        {
            dsPedidos_venda.Tables["PEDIDOS_VENDA"].DefaultView.RowFilter = "VENDEDOR_PED_VENDA Like '*" + tb_vendedor.Text + "*'";
            somar_totais();
        }

        private void form_pesquisa_pedido_Load(object sender, EventArgs e)
        {
            datPedidos_venda.Fill(PEDIDOS_VENDA);
            dgvPedidos.AutoGenerateColumns = false;
            dgvPedidos.DataSource = dsPedidos_venda.Tables["PEDIDOS_VENDA"];
            txtCodPedido.Select();
        }

        private void dgvPedidos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (consulta == true)
            {
                cod_ped_escolhido = dgvPedidos.Rows[e.RowIndex].Cells["col_cod"].Value.ToString();
                this.Close();
            }
            else
            {
                form_pedidos ped = new form_pedidos();
                try
                {
                    ped.abrir = true;
                    ped.cod_a_abrir = dgvPedidos.Rows[e.RowIndex].Cells["col_cod"].Value.ToString();
                    ped.ShowDialog();
                }
                finally
                {
                    ped.Dispose();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (selecao_nf == true)
            {
                
                for (int j = 0; j < dgvPedidos.SelectedRows.Count; j++)
                {
                    comando_select.CommandText = "SELECT * FROM PEDIDOS_VENDA WHERE COD_PED_VENDA = '" + dgvPedidos.SelectedRows[j].Cells["col_cod"].Value.ToString() + "'";
                    DataSet pedido = new DataSet();
                    fbConnection1.Open();
                    datPedidos_venda.SelectCommand = comando_select;
                    datPedidos_venda.Fill(pedido);
                    string _nf = "";
                    string _cod = "";
                    foreach (DataRow dr in pedido.Tables[0].Rows)
                    {
                        _cod = dr["COD_PED_VENDA"].ToString();
                        _nf = dr["NF_PED_VENDA"].ToString();
                    }
                    fbConnection1.Close();
                    if (_nf == "0" || _nf == "")
                    {

                    }
                    else
                    {
                        MessageBox.Show("O Pedido " + _cod + " já foi faturado");
                        erro = true;
                    }

                    pedidos_selecionados[j] = dgvPedidos.SelectedRows[j].Cells["col_cod"].Value.ToString();
                    numero_pedidos = j + 1;
                }
                if (erro == false)
                    this.Close();
                else
                {
                    pedidos_selecionados = null;
                    numero_pedidos = 0;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            form_localiza_produto localiza_item = new form_localiza_produto();
            try
            {
                localiza_item.buscar = true;
                localiza_item.ShowDialog();
            }
            finally
            {
                localiza_item.Dispose();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            form_vendedores vend = new form_vendedores();
            try
            {
                vend.ShowDialog();
            }
            finally
            {
                tb_cod_vendedor.Text = vend.cod_vendedor_escolhido;
                tb_nome_vendedor.Text = vend.vendedor_escolhido;
            }
        }

        private void cb_vendedor_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_vendedor.Checked == false)
            {
                tb_cod_vendedor.Text = "";
                tb_nome_vendedor.Text = "";
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            dsPedidos imprimir = new dsPedidos();
            fbConnection1.Open();
            datPedidos_venda.Fill(imprimir.PEDIDOS_VENDA);
            fbConnection1.Close();
            crPesquisa_pedidos novo_ped = new crPesquisa_pedidos();
            novo_ped.SetDataSource(imprimir);
            form_imprimir imprime = new form_imprimir(novo_ped);
            imprime.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            form_localiza_cliente localiza_cliente = new form_localiza_cliente(true);
            try
            {
                localiza_cliente.ShowDialog();
            }
            finally
            {
                localiza_cliente.Dispose();
                //MessageBox.Show(localiza_peca.peca_escolhida);
                
                tb_nome_cliente.Text = localiza_cliente.cliente_escolhido;

                //tb_dados_adicionais.Text = "#C.FISC.: " + tb_class_fiscal.Text + "#" + tb_dados_adicionais.Text;

            }
        }

        private void tb_valor_total_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtCodPedido_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsPedidos_venda.Tables["PEDIDOS_VENDA"].DefaultView.RowFilter = " COD_PED_VENDA = " + txtCodPedido.Text;
                somar_totais();
            }
            catch
            {
                dsPedidos_venda.Tables["PEDIDOS_VENDA"].DefaultView.RowFilter = " COD_PED_VENDA IS NOT NULL";
                somar_totais();
            }
        }

        
    }
}