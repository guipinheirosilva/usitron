using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_pesquisa_vendas : Form
    {
        DataTable dtSelect = new DataTable();
        public string cnpj;
        public form_pesquisa_vendas(string cnpj)
        {
            this.cnpj = cnpj;
            InitializeComponent();
        }

        private void btnAddVendedor_Click(object sender, EventArgs e)
        {
            form_vendedores vend = new form_vendedores();
            try
            {
                vend.ShowDialog();
            }
            finally
            {
                vend.Dispose();
                tb_cod_vendedor.Text = vend.cod_vendedor_escolhido;
                tb_nome_vendedor.Text = vend.vendedor_escolhido;
            }
        }

        private void btnAddCliente_Click(object sender, EventArgs e)
        {
            form_localiza_cliente localiza_cliente = new form_localiza_cliente(true, "");
            try
            {
                localiza_cliente.ShowDialog();
            }
            finally
            {
                localiza_cliente.Dispose();
                tb_nome_cliente.Text = localiza_cliente.cliente_escolhido;
                tb_cod_cliente.Text = localiza_cliente.cnpj_escolhido;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form_localiza_produto localiza_item = new form_localiza_produto(false, cnpj);
            try
            {
                localiza_item.buscar = true;
                localiza_item.ShowDialog();
            }
            finally
            {
                localiza_item.Dispose();
                if (localiza_item.cod_produto_escolhido == "")
                { }
                else
                {
                   localizar_item(localiza_item.cod_produto_escolhido);
                }

            }
        }

        private void localizar_item(string cod)
        {

            try
            {
                FbCommand comando_select = new FbCommand();
                comando_select.CommandText = "SELECT * FROM PRODUTOS WHERE COD_PRODUTO = '" + cod + "'";
                comando_select.Connection = fbConnection1;
                DataSet prod = new DataSet();
                fbConnection1.Open();
                FbDataAdapter datProdutos = new FbDataAdapter();
                datProdutos.SelectCommand = comando_select;
                datProdutos.Fill(prod);
                fbConnection1.Close(); 

                foreach (DataRow dr in prod.Tables[0].Rows)
                {
                    tb_cod_produto.Text = dr["COD_PRODUTO"].ToString();
                    tb_descricao_produto.Text = dr["DESCRICAO_PRODUTO"].ToString();
                }
            }
            catch
            {

                fbConnection1.Close(); 
            }





        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbPedidos.Checked)
                {
                    dtSelect.Clear();
                    string vendedor = "";
                    if (cb_vendedor.Checked)
                        vendedor = " AND ped.VENDEDOR_PED_VENDA = '" + tb_nome_vendedor.Text + "' ";

                    string cliente = "";
                    if (cb_cliente.Checked)
                        cliente = " AND ped.CNPJ_PED_VENDA = '" + tb_cod_cliente.Text + "' ";

                    string produto = "";
                    if (cbProduto.Checked)
                        produto = " AND IPED.COD_PROD_ITEM_VENDA = '" + tb_cod_produto.Text + "' ";

                    string cidade = "", inner_cidade = "";
                    if (cbCidade.Checked)
                    {
                        cidade = " AND upper(cli.CIDADE) like upper('%" + tb_cidade.Text + "%') ";
                        inner_cidade = " INNER JOIN CLIENTES cli ON cli.CNPJ = ped.CNPJ_PED_VENDA ";

                    }
                    string fornecedor = "";
                    if (ckbFornecedor.Checked)
                    {
                        fornecedor = " AND prod.CNPJ_FORNECEDOR_PRODUTO = '" + lblCnpj.Text + "'";
                    }
                    string tipo = "";
                    if (cbTroca.Checked)
                    {
                        tipo = " AND ped.TROCA_PED_VENDA = '1' ";
                    }
                    else
                    {
                        if (cbBonificacao.Checked)
                        {
                            tipo = " AND ped.BONIFICACAO_PED_VENDA = '1' ";
                        }
                        else
                        {
                            tipo = " AND (ped.TROCA_PED_VENDA = '0' OR ped.TROCA_PED_VENDA IS NULL) AND " +
                                "(ped.BONIFICACAO_PED_VENDA = '0' OR ped.BONIFICACAO_PED_VENDA IS NULL) ";
                        }
                    }
                    string fechados_abertos = "";
                    if (cbFechados.Checked)
                        fechados_abertos = " AND ped.BAIXADO_ESTOQUE_PED_VENDA = '1' ";
                    else
                        fechados_abertos = " AND (ped.BAIXADO_ESTOQUE_PED_VENDA = '0' or ped.BAIXADO_ESTOQUE_PED_VENDA is null) ";

                    string data = "";
                    if (!cb_data_entrada.Checked && !cb_data_entrega.Checked)
                        cb_data_entrada.Checked = true;

                    if (cb_data_entrada.Checked)
                    {
                        data = " AND ped.DATA_PED_VENDA >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") + "' AND " +
                        "ped.DATA_PED_VENDA <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' ";
                    }
                    if (cb_data_entrega.Checked)
                    {
                        data = " AND ped.DATA_BAIXA_PED_VENDA >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") + "' AND " +
                        "ped.DATA_BAIXA_PED_VENDA <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' ";
                    }


                    FbCommand select = new FbCommand();
                    select.CommandText =
                              select.CommandText =
                        "SELECT prod.COD_PRODUTO as COD, prod.DESCRICAO_PRODUTO, " +
                        "cast(sum(iped.VALOR_TOTAL_PROD_ITEM_VENDA) AS NUMERIC(15,3)) AS VALOR_TOTAL , " +
                        "cast(sum(iped.QTDE_ITEM_VENDA) AS NUMERIC(15,3)) as QTDE_TOTAL, " +
                        "cast(prod.ESTOQUE_ATUAL_PRODUTO AS NUMERIC(15,3)) AS ESTOQUE_ATUAL,  " +
                        "cast(prod.ESTOQUE_ATUAL_PRODUTO AS NUMERIC(15,3)) - cast(sum(iped.QTDE_ITEM_VENDA) AS NUMERIC(15,3))  AS DIFERENCA  " +
                        " FROM PRODUTOS prod " +
                        "INNER JOIN ITENS_PEDIDO_VENDA iped ON cast(prod.COD_PRODUTO as varchar(100)) = iped.COD_PROD_ITEM_VENDA " +
                        "INNER JOIN PEDIDOS_VENDA ped ON ped.COD_PED_VENDA = iped.COD_PEDIDO_ITEM_VENDA " +

                        inner_cidade +
                        "WHERE 0 = 0 " + data + 
                        fechados_abertos + 
                        //"(ped.NF_PED_VENDA IS NULL OR ped.NF_PED_VENDA = 0) " +
                        vendedor + cliente + produto + cidade + tipo + fornecedor +
                        "group by prod.COD_PRODUTO, prod.DESCRICAO_PRODUTO, prod.ESTOQUE_ATUAL_PRODUTO";
                        /*
                        "SELECT prod.COD_PRODUTO as COD, prod.DESCRICAO_PRODUTO ,  cast(sum(iped.QTDE_ITEM_VENDA) AS NUMERIC(15,3)) as QTDE_TOTAL, cast(sum(iped.VALOR_TOTAL_PROD_ITEM_VENDA) AS NUMERIC(15,3)) AS VALOR_TOTAL FROM PRODUTOS prod " +
                        "INNER JOIN ITENS_PEDIDO_VENDA iped ON cast(prod.COD_PRODUTO as varchar(100)) = iped.COD_PROD_ITEM_VENDA " +
                        "INNER JOIN PEDIDOS_VENDA ped ON ped.COD_PED_VENDA = iped.COD_PEDIDO_ITEM_VENDA " +
                        inner_cidade +
                        "WHERE ped.DATA_PED_VENDA >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") + "' AND " +
                        "ped.DATA_PED_VENDA <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' AND " +
                        "ped.BAIXADO_ESTOQUE_PED_VENDA = '1' " +
                        vendedor + cliente + produto + cidade +
                        "group by prod.COD_PRODUTO, prod.DESCRICAO_PRODUTO";
                         * */
                    select.Connection = fbConnection1;
                    fbConnection1.Open();
                    FbDataAdapter datSelect = new FbDataAdapter();
                    datSelect.SelectCommand = select;
                    datSelect.Fill(dtSelect);
                    fbConnection1.Close(); 
                    somar();
                }
                if (cbPdv.Checked)
                {
                    dtSelect.Clear();
                   
                    string produto = "";
                    if (cbProduto.Checked)
                        produto = " AND IPED.COD_PROD_ITEM_VENDA = '" + tb_cod_produto.Text + "' ";

                   

                    FbCommand select = new FbCommand();
                    select.CommandText =
                        "SELECT prod.COD_PRODUTO as COD, prod.DESCRICAO_PRODUTO ,  cast(sum(iped.QTDE_INFCE) AS NUMERIC(15,3)) as QTDE_TOTAL, cast(sum(iped.VALOR_TOTAL_INFCE) AS NUMERIC(15,3)) AS VALOR_TOTAL FROM PRODUTOS prod " +
                        "INNER JOIN ITENS_NFCE iped ON prod.COD_PRODUTO = iped.COD_ESTOQUE_INFCE " +
                        "INNER JOIN NFCE ped ON ped.PEDIDO_NFCE = iped.COD_PEDIDO_INFCE " +

                        "WHERE ped.DATA_EMISSAO_NFCE >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") + "' AND " +
                        "ped.DATA_EMISSAO_NFCE <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' AND " +
                        "ped.PEDIDO_FECHADO_NFCE = '1' " +
                         produto +
                        "group by prod.COD_PRODUTO, prod.DESCRICAO_PRODUTO";
                    select.Connection = fbConnection1;
                    fbConnection1.Open();
                    FbDataAdapter datSelect = new FbDataAdapter();
                    datSelect.SelectCommand = select;
                    datSelect.Fill(dtSelect);
                    fbConnection1.Close(); 
                    somar();
                }
            }
            catch (Exception a)
            {
                fbConnection1.Close(); 
                MessageBox.Show(a.ToString());
            }
        }

        private void somar()
        {
            double qtde = 0, valor = 0;
            for(int i = 0; i < dgvSelect.RowCount; i++)
            {
                try
                {
                    qtde = qtde + Convert.ToDouble(dgvSelect.Rows[i].Cells["QTDE_TOTAL"].Value.ToString());
                }
                catch{}
                  try
                {
                    valor = valor + Convert.ToDouble(dgvSelect.Rows[i].Cells["VALOR_TOTAL"].Value.ToString());
                }
                catch{}
            }
            tb_qtde.Text = qtde.ToString("n3");
            tb_valor.Text = valor.ToString("n2");
        }

        private void form_pesquisa_vendas_Load(object sender, EventArgs e)
        {
            dgvSelect.DataSource = dtSelect;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dsVendas ven = new dsVendas();
            foreach (DataRow dr in dtSelect.Rows)
            {
                try
                {
                    ven.Vendas.AddVendasRow(dr[0].ToString(), dr[1].ToString(), Convert.ToDouble(dr[3].ToString()), Convert.ToDouble(dr[2].ToString()), dr[4].ToString(), dr[5].ToString());
                }
                catch { }
            }
            string observacoes = "";
       
            if (cb_vendedor.Checked)
                observacoes += " VENDEDOR: " + tb_nome_vendedor.Text + " ";
            if (cb_cliente.Checked)
                observacoes += " CLIENTE: " + tb_nome_cliente.Text + "";
            if (cbProduto.Checked)
                observacoes += " PRODUTO: " + tb_descricao_produto.Text + "";
            if (cbTroca.Checked)
                observacoes += " TIPO: TROCA";
            if (cbBonificacao.Checked)
                observacoes += " TIPO: BONIFICACAO";
            if (cbCidade.Checked)
            {
                observacoes += " CIDADE: " + tb_cidade.Text + "";
            }
     ven.Informacoes.AddInformacoesRow(Convert.ToDateTime(dtInicial.Text), Convert.ToDateTime(dtFinal.Text), observacoes);
            crVendas cr = new crVendas();
            cr.SetDataSource(ven);
            form_imprimir imp = new form_imprimir(cr);
            imp.Show();
        }

        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            form_localiza_forn forn = new form_localiza_forn(false, "");
            try
            {
                forn.ShowDialog();
            }
            finally
            {
                forn.Dispose();
                txtCodFornecedor.Text = forn.cod_escolhido;
                txtFornecedor.Text = forn.razao_forn_escolhido;
                lblCnpj.Text = forn.cnpj_escolhido;
            }
        }
        
    }
}
