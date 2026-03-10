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
    public partial class form_pesquisa_itens_pedido : Form
    {
        DataTable dtSelect = new DataTable();
        public string cnpj;
        public form_pesquisa_itens_pedido(string cnpj)
        {
            this.cnpj = cnpj;
            InitializeComponent();
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
                tb_vendedor.Text = vend.vendedor_escolhido;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            form_localiza_cliente localiza_cliente = new form_localiza_cliente(true, "");
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
                    tb_cod_produto.Text = dr["COD_BARRAS_PRODUTO"].ToString();
                    tb_descricao_produto.Text = dr["DESCRICAO_PRODUTO"].ToString();
                }
            }
            catch
            {

                fbConnection1.Close();
            }





        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string where_vendedor = "";
                if (tb_cod_vendedor.Text != "")
                {
                    where_vendedor = " AND ped.COD_VENDEDOR_PED_VENDA = '" + tb_cod_vendedor.Text + "'";
                }

                string where_cliente = "";
                if (tb_cnpj_cliente.Text != "")
                {
                    where_cliente = " AND ped.CNPJ_PED_VENDA = '" + tb_cnpj_cliente.Text + "'";
                }

                string where_produtos = "";
                if (tb_cod_produto.Text != "")
                {
                    where_produtos = " AND prod.COD_BARRAS_PRODUTO = '" + tb_cod_produto.Text + "'";
                }

                string inner_tabela = "", where_tabela = "";
                if (tb_cod_tabela.Text != "")
                {
                    inner_tabela = " INNER JOIN CLIENTES cli ON cli.CNPJ = ped.CNPJ_PED_VENDA";
                    where_tabela = " AND cli.COD_TP_CLIENTE = '" + tb_cod_tabela.Text + "'";
                }
                dtSelect.Clear();
                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT ped.DATA_PED_VENDA, ped.COD_PED_VENDA, ped.CLIENTE_PED_VENDA, iped.QTDE_ITEM_VENDA, " +
                    " iped.DESCRICAO_PROD_ITEM_VENDA, iped.VALOR_UNIT_PROD_ITEM_VENDA, iped.VALOR_TOTAL_PROD_ITEM_VENDA, " +
                    "vend.porc_comissao_cpv as COMISSAO, (iped.VALOR_TOTAL_PROD_ITEM_VENDA * vend.porc_comissao_cpv /100) as VALOR_COMISSAO  " + 
                    "  FROM ITENS_PEDIDO_VENDA iped " +
                    "INNER JOIN PEDIDOS_VENDA ped ON ped.COD_PED_VENDA = iped.COD_PEDIDO_ITEM_VENDA " +
                    " INNER JOIN PRODUTOS prod ON iped.COD_PROD_ITEM_VENDA = prod.COD_FORNECEDOR_PRODUTO" +
                    " INNER JOIN comissao_produto_vendedor vend ON prod.cod_produto = vend.cod_produto_cpv and ped.cod_vendedor_ped_venda = vend.cod_vendedor_cpv " +
                    inner_tabela +
                    " WHERE ped.DATA_PED_VENDA >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") +  "' AND "  +
                    " ped.DATA_PED_VENDA <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") +  "' " + 
                    where_vendedor + where_cliente + where_produtos + where_tabela;
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                dgvPesquisa.DataSource = dtSelect;


                //inner_produtos = " INNER JOIN PRODUTOS prod ON iped.COD_PROD_ITEM_VENDA = prod.COD_FORNECEDOR_PRODUTO";

            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void form_pesquisa_itens_pedido_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            somar();
        }

        private void somar()
        {
            double qtde = 0, valor = 0, comissao = 0;
            for (int i = 0; i < dgvPesquisa.RowCount; i++)
            {
                try
                {
                    qtde = qtde + Convert.ToDouble(dgvPesquisa.Rows[i].Cells["QTDE_ITEM_VENDA"].Value.ToString());
                }
                catch { }
                try
                {
                    valor = valor + Convert.ToDouble(dgvPesquisa.Rows[i].Cells["VALOR_TOTAL_PROD_ITEM_VENDA"].Value.ToString());
                }
                catch { }
                try
                {
                    comissao = comissao + Convert.ToDouble(dgvPesquisa.Rows[i].Cells["VALOR_COMISSAO"].Value.ToString());
                }
                catch { }
            }
            tb_qtde_total.Text = qtde.ToString("n3");
            tb_valor_total.Text = valor.ToString("n3");
            tb_comissao_total.Text = comissao.ToString("n2");
        }

        private void button7_Click(object sender, EventArgs e)
        {

            dsItens_venda cli = new dsItens_venda();

            FbCommand select1 = new FbCommand();
            try
            {

                select1.Connection = fbConnection1;
                fbConnection1.Open();
                select1.CommandText =
                    "SELECT * FROM EMPRESA where LICENCA_DLL_NFE_EMPRESA is not null";
                FbDataAdapter datTabela1 = new FbDataAdapter();
                datTabela1.SelectCommand = select1;
                datTabela1.Fill(cli.EMPRESA);
                fbConnection1.Close();

            }
            catch (Exception a)
            {
                fbConnection1.Close();
                //MessageBox.Show(a.ToString());
            }

            foreach (DataRow dr in dtSelect.Rows)
            {
                cli.Itens.AddItensRow(Convert.ToDateTime(dr[0].ToString()), Convert.ToInt32(dr[1].ToString()), dr[2].ToString(), Convert.ToDouble(dr[3].ToString()),
                    dr[4].ToString(), Convert.ToDouble(dr[5].ToString()), Convert.ToDouble(dr[6].ToString()), Convert.ToDouble(dr[7].ToString()), Convert.ToDouble(dr[8].ToString()));
            }


            crItens_venda cr = new crItens_venda();
            cr.SetDataSource(cli);
            form_imprimir imprime = new form_imprimir(cr);
            imprime.Show();
        }
    }
}
