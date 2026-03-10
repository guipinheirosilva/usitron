using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.IO;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;

namespace Evolucao
{
    public partial class formVendasFornecedor : Form
    {

        private bool consulta = false;
        
        public formVendasFornecedor()
        {
            InitializeComponent();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            dsVendasFornecedor vf = new dsVendasFornecedor();

            if (consulta)
            {
                if (rbtnClientes.Checked)
                {
                    foreach (DataGridViewRow row in dgvVendasFornecedor.Rows)
                    {
                        if (row.Index != (dgvVendasFornecedor.Rows.Count))
                        {
                            vf.Tables["VENDAS_FORNECEDOR"].Rows.Add(row);

                            vf.Tables["VENDAS_FORNECEDOR"].Rows[row.Index][0] = row.Cells[0].Value;
                            vf.Tables["VENDAS_FORNECEDOR"].Rows[row.Index][1] = row.Cells[1].Value;
                            vf.Tables["VENDAS_FORNECEDOR"].Rows[row.Index][2] = row.Cells[2].Value;
                            vf.Tables["VENDAS_FORNECEDOR"].Rows[row.Index][3] = row.Cells[3].Value;
                            vf.Tables["VENDAS_FORNECEDOR"].Rows[row.Index][4] = row.Cells[4].Value;
                            vf.Tables["VENDAS_FORNECEDOR"].Rows[row.Index][5] = Convert.ToDouble(row.Cells[5].Value);
                        }
                    }

                    crVendasFornecedor cr = new crVendasFornecedor();

                    cr.SetDataSource(vf);
                    cr.SetParameterValue(cr.Parameter_nomeFornecedor.ParameterFieldName.ToString(), cbxFornecedores.Text.ToString());
                    cr.SetParameterValue(cr.Parameter_dataInicio.ParameterFieldName.ToString(), dataInicio.Text.ToString());
                    cr.SetParameterValue(cr.Parameter_dataFim.ParameterFieldName.ToString(), dataFim.Text.ToString());

                    form_imprimir imprimir = new form_imprimir(cr);
                    imprimir.Show();
                }
                else
                {
                    foreach (DataGridViewRow row in dgvVendasFornecedor.Rows)
                    {
                        if (row.Index != (dgvVendasFornecedor.Rows.Count))
                        {
                            vf.Tables["VENDAS_PRODUTOS_FORNECEDOR"].Rows.Add(row);

                            vf.Tables["VENDAS_PRODUTOS_FORNECEDOR"].Rows[row.Index][0] = row.Cells[0].Value;
                            vf.Tables["VENDAS_PRODUTOS_FORNECEDOR"].Rows[row.Index][1] = row.Cells[1].Value;
                            vf.Tables["VENDAS_PRODUTOS_FORNECEDOR"].Rows[row.Index][2] = Convert.ToInt32(row.Cells[2].Value);
                        }
                    }

                    crVendasProdutosFornecedor cr = new crVendasProdutosFornecedor();

                    cr.SetDataSource(vf);
                    cr.SetParameterValue(cr.Parameter_nomeFornecedor.ParameterFieldName.ToString(), cbxFornecedores.Text.ToString());
                    cr.SetParameterValue(cr.Parameter_dataInicio.ParameterFieldName.ToString(), dataInicio.Text.ToString());
                    cr.SetParameterValue(cr.Parameter_dataFim.ParameterFieldName.ToString(), dataFim.Text.ToString());

                    form_imprimir imprimir = new form_imprimir(cr);
                    imprimir.Show();
                }
            }
            else
            {
                MessageBox.Show("Não é possível imprimir o relatório sem pesquisar os dados!");
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FbCommand selectVendasFornecedor = new FbCommand();
            FbDataAdapter datVendas = new FbDataAdapter();
            DataTable dtVendas = new DataTable();
            string cnpjFornecedor;

            if (rbtnClientes.Checked || rbtnProdutos.Checked)
            {
                try
                {
                    if (cbxFornecedores.SelectedIndex == -1)
                    {
                        MessageBox.Show("Selecione um fornecedor!");
                    }
                    else
                    {
                        if (rbtnClientes.Checked)
                        {
                            /*SELECIONAR AS VENDAS DO FORNECEDOR*/
                            cnpjFornecedor = cbxFornecedores.SelectedValue.ToString();

                            dtVendas.Clear();
                            selectVendasFornecedor.CommandText =
                                 "select " +
                                 "    nfe.data_emissao_nf data, " +
                                 "    nfe.n_nf nf, " +
                                 "    nfe.cliente_forn_nf cliente, " +
                                 "    c.cidade cidade, " +
                                 "    pv.vendedor_ped_venda vendedor, " +
                                 "    sum(infe.preco_total_item)total " +
                                 "from itens_nota infe " +
                                 "    inner join nota_fiscal nfe " +
                                 "        on nfe.n_nf = infe.nf_item " +
                                 "    inner join produtos p " +
                                 "        on p.cod_produto = infe.cod_item or p.cod_fornecedor_produto = infe.cod_item " +
                                 "    inner join clientes c " +
                                 "        on c.cnpj = nfe.cnpj_cliente_forn " +
                                 "    inner join pedidos_nf pnf " +
                                 "        on pnf.nf_pedido_nf = nfe.n_nf " +
                                 "    inner join pedidos_venda pv " +
                                 "        on pv.cod_ped_venda = pnf.n_pedido_nf " +
                                  "   inner join cfo " +
                        "       on cfo.n_cfo = infe.cfop_item " +
                                 "where " +
                                 "    nfe.data_emissao_nf >= '" + Convert.ToDateTime(dataInicio.Text).ToShortDateString().Replace("/", ".") + "' " +
                                 "    and nfe.data_emissao_nf <= '" + Convert.ToDateTime(dataFim.Text).ToShortDateString().Replace("/", ".") + "' " +
                                 /*
                                 "    and nfe.status_nfe like 'NFe Autorizada.' " +
                                 "    and nfe.natureza_operacao_nf like '%VENDA%' " +
                                  * */
                                  "   and nfe.status_nfe like '%Autorizada%' " +
                                 "   and infe.cfop_item <> '5910' " +
                                "   and infe.cfop_item <> '6910' " +
                                 "   and cfo.tributada_cfo = '1' " +
                                 "    and p.cnpj_fornecedor_produto like '" + cnpjFornecedor + "' " +
                                 "group by " +
                                 "    nfe.data_emissao_nf, " +
                                 "    nfe.n_nf, " +
                                 "    nfe.cliente_forn_nf, " +
                                 "    c.cidade, " +
                                 "    pv.vendedor_ped_venda";

                            datVendas.SelectCommand = selectVendasFornecedor;
                            datVendas.SelectCommand.Connection = fbConnection1;
                            fbConnection1.Open();
                            datVendas.SelectCommand.ExecuteNonQuery();
                            datVendas.Fill(dtVendas);
                            fbConnection1.Close(); 

                            /*PREENCHER DATAGRIDVIEW*/
                            dgvVendasFornecedor.DataSource = dtVendas;

                            /*FORMATAR DATAGRIDVIEW*/
                            dgvVendasFornecedor.Columns[0].Width = 80;
                            dgvVendasFornecedor.Columns[0].HeaderText = "Data";
                            dgvVendasFornecedor.Columns[0].ValueType = typeof(DateTime);
                            dgvVendasFornecedor.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy";

                            dgvVendasFornecedor.Columns[1].Width = 80;
                            dgvVendasFornecedor.Columns[1].HeaderText = "Nota";

                            dgvVendasFornecedor.Columns[2].Width = 400;
                            dgvVendasFornecedor.Columns[2].HeaderText = "Cliente";

                            dgvVendasFornecedor.Columns[3].Width = 100;
                            dgvVendasFornecedor.Columns[3].HeaderText = "Cidade";

                            dgvVendasFornecedor.Columns[4].Width = 100;
                            dgvVendasFornecedor.Columns[4].HeaderText = "Vendedor";

                            dgvVendasFornecedor.Columns[5].Width = 100;
                            dgvVendasFornecedor.Columns[5].HeaderText = "Total";
                            dgvVendasFornecedor.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            dgvVendasFornecedor.Columns[5].DefaultCellStyle.Format = "n2";

                            dgvVendasFornecedor.Sort(dgvVendasFornecedor.Columns[0], ListSortDirection.Ascending);

                            /*CALCULAR TOTAGL GERAL*/
                            double totalGeral = 0;

                            for (int i = 0; i < dgvVendasFornecedor.Rows.Count; i++)
                            {
                                totalGeral += Convert.ToDouble(dgvVendasFornecedor.Rows[i].Cells[5].Value);
                            }

                            txtTotalGeral.Text = totalGeral.ToString("n2");
                            consulta = true;
                        }
                        else
                        {
                            /*SELECIONAR OS PRODUTOS VENDIDOS DO FORNECEDOR*/
                            cnpjFornecedor = cbxFornecedores.SelectedValue.ToString();

                            dtVendas.Clear();
                            selectVendasFornecedor.CommandText =
                                "select item.cod_ean_item, item.descricao_item, sum(item.qtde_item) " + 
                                "from itens_nota item " + 
                                "    inner join nota_fiscal nf " + 
                                "        on nf.n_nf = item.nf_item " + 
                                "    inner join produtos p " + 
                                "        on p.cod_barras_produto = item.cod_ean_item " +
                                "where nf.data_emissao_nf >= '" + Convert.ToDateTime(dataInicio.Text).ToShortDateString().Replace("/", ".") + "' " +
                                "    and nf.data_emissao_nf <= '" + Convert.ToDateTime(dataFim.Text).ToShortDateString().Replace("/", ".") + "' " + 
                                "    and nf.status_nfe like 'NFe Autorizada.' " + 
                                "    and nf.natureza_operacao_nf like '%VENDA%' " +
                                "    and p.cnpj_fornecedor_produto like '" + cnpjFornecedor + "' " + 
                                "group by item.cod_ean_item, item.descricao_item " + 
                                "order by item.cod_ean_item";
                            datVendas.SelectCommand = selectVendasFornecedor;
                            datVendas.SelectCommand.Connection = fbConnection1;
                            fbConnection1.Open();
                            datVendas.SelectCommand.ExecuteNonQuery();
                            datVendas.Fill(dtVendas);
                            fbConnection1.Close(); 

                            /*PREENCHER DATAGRIDVIEW*/
                            dgvVendasFornecedor.DataSource = dtVendas;

                            /*FORMATAR DATAGRIDVIEW*/
                            dgvVendasFornecedor.Columns[0].Width = 100;
                            dgvVendasFornecedor.Columns[0].HeaderText = "Cod. Barras";

                            dgvVendasFornecedor.Columns[1].Width = 300;
                            dgvVendasFornecedor.Columns[1].HeaderText = "Descrição";

                            dgvVendasFornecedor.Columns[2].Width = 100;
                            dgvVendasFornecedor.Columns[2].HeaderText = "Qtde";
                            dgvVendasFornecedor.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            dgvVendasFornecedor.Columns[2].DefaultCellStyle.Format = "n0";


                            dgvVendasFornecedor.Sort(dgvVendasFornecedor.Columns[0], ListSortDirection.Ascending);

                            /*CALCULAR TOTAGL GERAL*/
                            double totalGeral = 0;

                            for (int i = 0; i < dgvVendasFornecedor.Rows.Count; i++)
                            {
                                totalGeral += Convert.ToInt32(dgvVendasFornecedor.Rows[i].Cells[2].Value);
                            }

                            txtTotalGeral.Text = totalGeral.ToString("N0");
                            consulta = true;
                        }
                    }
                }
                catch (Exception a)
                {
                    fbConnection1.Close(); 
                    consulta = false;
                    MessageBox.Show("Houve um erro ao buscar os produtos vendidos!\nErro: " + a.Message);
                }
            }
            else
            {
                consulta = false;
                MessageBox.Show("É necessário selecionar um tipo de relatório!");
            }
        }

        private void formVendasFornecedor_Load(object sender, EventArgs e)
        {
            //Carregando os dados de classificação no comboBox------------------------------//
            datFornecedores.Fill(FORNECEDORES);                     //Preenchendo DataTable
            cbxFornecedores.DataSource = FORNECEDORES;              //Preenchendo ComboBox
            cbxFornecedores.DisplayMember = "razao_social_forn";    //Definindo Legenda
            cbxFornecedores.ValueMember = "cnpj_cpf_forn";          //Definindo Valor

            cbxFornecedores.SelectedIndex = -1;                     //Selecionando nada
            //------------------------------------------------------------------------------//
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string _fornecedor = "";
                if (cbxFornecedores.Text != "")
                    _fornecedor = " AND prod.NOME_FORNECEDOR_PRODUTO = '" + cbxFornecedores.Text + "' ";
               

                dsClientesxproduto cli = new dsClientesxproduto();
                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT item.COD_ITEM, sum(item.QTDE_ITEM), sum(item.PRECO_TOTAL_ITEM), " +
                    "nf.CNPJ_CLIENTE_FORN FROM ITENS_NOTA item INNER JOIN NOTA_FISCAL nf " +
                    "on item.NF_ITEM = nf.N_NF INNER JOIN PRODUTOS prod on item.COD_ITEM = prod.COD_PRODUTO WHERE " +
                    " nf.DATA_EMISSAO_NF >= '" + Convert.ToDateTime(dataInicio.Text).ToShortDateString().Replace("/", ".") + "' AND " +
                    " nf.DATA_EMISSAO_NF <= '" + Convert.ToDateTime(dataFim.Text).ToShortDateString().Replace("/", ".") + "'" + _fornecedor +
                    " GROUP BY nf.CNPJ_CLIENTE_FORN, item.COD_ITEM";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close(); 
                foreach (DataRow dr in dtSelect.Rows)
                {
                    try
                    {
                        cli.ProdutosXclientes.AddProdutosXclientesRow(dr[0].ToString(), Convert.ToInt32(dr[1].ToString()),
                            Convert.ToDouble(dr[2].ToString()), dr[3].ToString());
                    }
                    catch { }
                }

                FbCommand select_clientes = new FbCommand();
                select_clientes.CommandText =
                    "SELECT * from clientes";
                select_clientes.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect_clientes = new FbDataAdapter();
                datSelect_clientes.SelectCommand = select_clientes;
                datSelect_clientes.Fill(cli.CLIENTES);
                fbConnection1.Close(); 

                FbCommand select_produtos = new FbCommand();
                select_produtos.CommandText =
                    "SELECT * from produtos";
                select_produtos.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect_produtos = new FbDataAdapter();
                datSelect_produtos.SelectCommand = select_produtos;
                datSelect_produtos.Fill(cli.PRODUTOS);
                fbConnection1.Close(); 


               // cli.Dados.AddDadosRow(cbxFornecedores.Text, Convert.ToDateTime(dataInicio.Text), Convert.ToDateTime(dataFim.Text), "", "", "");


                crProdutosxclientes cr = new crProdutosxclientes();
                cr.SetDataSource(cli);
                form_imprimir imprime = new form_imprimir(cr);
                imprime.Show();
            }
            catch (Exception a)
            {
                fbConnection1.Close(); 
                MessageBox.Show(a.ToString());
            }
        }
    }
}
