using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_produto : Form
    {
        public bool modificar, novo, novo_produto;
        public bool selecao_orc;
        public string cod_prod;
        string cnpj_empresa;
        public int n_cod, n_orc;
        public form_produto(string cnpj_empresa)
        {
            this.cnpj_empresa = cnpj_empresa;
            InitializeComponent();
        }

        private void form_produto_Load(object sender, EventArgs e)
        {

            if (modificar == true)
            {
                localizar_item(cod_prod);
            }
            if (novo == true)
            {
                criar_item();
            }

            //try
            //{
            //    if (novo_produto)
            //    {
            //        criar_item();
            //        buscar_item(n_cod);
            //        bool ok = false;
            //    }
            //}
            //catch { }
        }

        private void buscar_item(int n_cod)
        {
            //form_orcamentos orc = new form_orcamentos();
            //try
            //{
            //    if (n_orc == 0)
            //    {
            //        orc.selecao_orc = true;
            //        orc.ShowDialog();
            //    }
            //    else
            //    {
            //        orc.numero_orcamento = 1;
            //        orc.orcamentos_selecionados[0] = n_orc.ToString();
            //    }
            //}
            //finally
            //{
            //    for (int i = 0; i < orc.numero_orcamento; i++)
            //    {
            //        try
            //        {
            //            FbCommand comando = new FbCommand();
            //            comando.Connection = fbConnection1;
            //            comando.CommandText =
            //                "SELECT * FROM ITENS_ORCAMENTO WHERE COD_ORCAMENTO_ITEM_ORC = '" + orc.orcamentos_selecionados[1] + "'";
            //            DataSet orcamento = new DataSet();
            //            fbConnection1.Open();
            //            datItens_orcamentos.SelectCommand = comando;
            //            datItens_orcamentos.Fill(orcamento);

            //            string descricao;
            //            string ncm;
            //            string unidade;
            //            string valor_unitario;
            //            string cst;

            //        }
            //    }
            //}
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            salvar();


        }

        private void salvar()
        {
            try
            {
                this.BindingContext[dsProdutos, "PRODUTOS"].EndCurrentEdit();
                
                if (dsProdutos.HasChanges())
                {
                    fbConnection1.Open();
                    datProdutos.UpdateCommand = cbProdutos.GetUpdateCommand();
                    datProdutos.InsertCommand = cbProdutos.GetInsertCommand();
                    datProdutos.DeleteCommand = cbProdutos.GetDeleteCommand();
                    datProdutos.Update(dsProdutos, "PRODUTOS");
                    dsProdutos.AcceptChanges();
                    fbConnection1.Close();
                }

                this.BindingContext[dsCpv, "COMISSAO_PRODUTO_VENDEDOR"].EndCurrentEdit();
                if (dsCpv.HasChanges())
                {
                    fbConnection1.Open();
                    datCpv.UpdateCommand = cbCpv.GetUpdateCommand();
                    datCpv.InsertCommand = cbCpv.GetInsertCommand();
                    datCpv.DeleteCommand = cbCpv.GetDeleteCommand();
                    datCpv.Update(dsCpv, "COMISSAO_PRODUTO_VENDEDOR");
                    dsCpv.AcceptChanges();
                    fbConnection1.Close();
                }

                this.BindingContext[dsProdutos_kit, "PRODUTOS_KIT"].EndCurrentEdit();
                if (dsProdutos_kit.HasChanges())
                {
                    fbConnection1.Open();
                    datProdutos_kit.UpdateCommand = cbProdutos_kit.GetUpdateCommand();
                    datProdutos_kit.InsertCommand = cbProdutos_kit.GetInsertCommand();
                    datProdutos_kit.DeleteCommand = cbProdutos_kit.GetDeleteCommand();
                    datProdutos_kit.Update(dsProdutos_kit, "PRODUTOS_KIT");
                    dsProdutos_kit.AcceptChanges();
                    fbConnection1.Close();
                }

                this.BindingContext[dsItens_produto, "ITENS_PRODUTO"].EndCurrentEdit();
                if (dsItens_produto.HasChanges())
                {
                    fbConnection1.Open();
                    datItens_produto.UpdateCommand = cbItens_produto.GetUpdateCommand();
                    datItens_produto.InsertCommand = cbItens_produto.GetInsertCommand();
                    datItens_produto.DeleteCommand = cbItens_produto.GetDeleteCommand();
                    datItens_produto.Update(dsItens_produto, "ITENS_PRODUTO");
                    dsItens_produto.AcceptChanges();
                    fbConnection1.Close();
                    
                }

                this.BindingContext[dsDesenhos_produto, "DESENHOS_PRODUTO"].EndCurrentEdit();
                if (dsDesenhos_produto.HasChanges())
                {
                    fbConnection1.Open();
                    datDesenhos_produto.UpdateCommand = cbDesenhos_produto.GetUpdateCommand();
                    datDesenhos_produto.InsertCommand = cbDesenhos_produto.GetInsertCommand();
                    datDesenhos_produto.DeleteCommand = cbDesenhos_produto.GetDeleteCommand();
                    datDesenhos_produto.Update(dsDesenhos_produto, "DESENHOS_PRODUTO");
                    dsDesenhos_produto.AcceptChanges();
                    fbConnection1.Close();

                }

                /*
                this.BindingContext[dsItens_nf_entrada, "ITENS_NOTA_ENT"].EndCurrentEdit();
                if (dsItens_nf_entrada.HasChanges())
                {
                    fbConnection1.Open();
                    datItens_nf_entrada.UpdateCommand = cbItens_nf_entrada.GetUpdateCommand();
                    datItens_nf_entrada.InsertCommand = cbItens_nf_entrada.GetInsertCommand();
                    datItens_nf_entrada.DeleteCommand = cbItens_nf_entrada.GetDeleteCommand();
                    datItens_nf_entrada.Update(dsItens_nf_entrada, "ITENS_NOTA_ENT");
                    dsItens_nf_entrada.AcceptChanges();
                    fbConnection1.Close(); 
                }
                */
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show("Cód. de Barra já existe");
            }

        }

        private void bt_novo_Click(object sender, EventArgs e)
        {
            criar_item();
        }

        private void criar_item()
        {
            dsProdutos.Clear();

            try
            {
                this.datProdutos.DeleteCommand.CommandText =
                    "DELETE FROM PRODUTOS WHERE DESCRICAO_PRODUTO = 'NOVO'";
                this.fbConnection1.Open();
                this.datProdutos.DeleteCommand.Connection = fbConnection1;
                this.datProdutos.DeleteCommand.ExecuteNonQuery();
                this.fbConnection1.Close();

                this.datProdutos.InsertCommand.CommandText =
                    "INSERT INTO PRODUTOS (DESCRICAO_PRODUTO, ESTOQUE_ATUAL_PRODUTO, ESTOQUE_MEDIO_PRODUTO)" +
                    "VALUES ('NOVO',0,0)";
                this.fbConnection1.Open();
                this.datProdutos.InsertCommand.Connection = fbConnection1;
                this.datProdutos.InsertCommand.ExecuteNonQuery();
                this.fbConnection1.Close();

                this.datProdutos.SelectCommand.CommandText =
                    "SELECT * FROM PRODUTOS WHERE DESCRICAO_PRODUTO = 'NOVO'";
                this.fbConnection1.Open();
                this.datProdutos.SelectCommand.Connection = fbConnection1;
                this.datProdutos.SelectCommand.ExecuteNonQuery();
                datProdutos.Fill(PRODUTOS);
                this.fbConnection1.Close();

                txtCodAlternativo.Text = tb_cod.Text;


            }


            catch
            {
                fbConnection1.Close();
                MessageBox.Show("Erro");
            }
        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("O registro será excluído permanentemente, tem certeza?",
               "Confirma a exclusão?", MessageBoxButtons.YesNo))
            {
                try
                {
                    this.datProdutos.DeleteCommand.CommandText =
                        "DELETE FROM PRODUTOS WHERE COD_PRODUTO = '" + tb_cod.Text + "'";
                    this.fbConnection1.Open();
                    this.datProdutos.DeleteCommand.Connection = fbConnection1;
                    this.datProdutos.DeleteCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                    dsProdutos.Clear();
                }
                catch
                {
                    fbConnection1.Close();
                    MessageBox.Show("Erro");
                }


            }
        }

        private void bt_localizar_Click(object sender, EventArgs e)
        {
            form_localiza_produto localiza_item = new form_localiza_produto(false, cnpj_empresa);
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

        private void selecionar_entradas(string cod)
        {

            try
            {
                dsItens_nf_entrada.Clear();
                this.datItens_nf_entrada.SelectCommand.CommandText =
                    "SELECT ITENS_NOTA_ENT.* " +
                    "FROM ITENS_NOTA_ENT JOIN NOTA_FISCAL_ENT ON COD_SISTEMA_NF_ITEM_ENT = COD_SISTEMA_NF_ENT " +
                    "WHERE (COD_EAN_ITEM_ENT = '" + txtCodBarrasUnit.Text + "' OR COD_EAN_ITEM_ENT = '" + txtCodBarrasCaixa.Text + "') " +
                    "AND BAIXADO_ITEM_ENT = '1' " +
                    "ORDER BY COD_ITENS_NOTA_ENT DESC";
                this.fbConnection1.Open();
                this.datItens_nf_entrada.SelectCommand.Connection = fbConnection1;
                this.datItens_nf_entrada.SelectCommand.ExecuteNonQuery();
                datItens_nf_entrada.Fill(ITENS_NOTA_ENT);
                this.fbConnection1.Close();
            }

            catch
            {
                fbConnection1.Close();
                MessageBox.Show("Erro no select entrada");
            }

        }

        private void selecionar_saidas(string cod)
        {
            try
            {
                /*
                dsItens_ped_venda.Clear();
                this.datItens_ped_venda.SelectCommand.CommandText =
                "SELECT * FROM ITENS_PEDIDO_VENDA WHERE COD_SISTEMA_PROD_ITEM_VENDA = '" + cod + "'";
                this.fbConnection1.Open();
                this.datItens_ped_venda.SelectCommand.Connection = fbConnection1;
                this.datItens_ped_venda.SelectCommand.ExecuteNonQuery();
                datItens_ped_venda.Fill(ITENS_PEDIDO_VENDA);
                this.fbConnection1.Close(); 
                */
                dsItens_nota.Clear();
                this.datItens_nota.SelectCommand.CommandText =
                    "SELECT nf.n_nf, nf.data_emissao_nf, nf.cliente_forn_nf, item.qtde_item, item.unidade_item " +
                    "FROM itens_nota item " +
                    "INNER JOIN nota_fiscal nf " +
                    "ON nf.COD_SISTEMA_NF = item.COD_SISTEMA_NF_ITEM " +
                    //"JOIN pedidos_nf pf " +
                    //"ON nf.n_nf = pf.nf_pedido_nf " +
                    "WHERE (item.cod_item like '" + txtCodAlternativo.Text + "') " +
                    "and item.CFOP_ITEM LIKE '_1__' " + 
                    "AND nf.status_nfe like '%NFe Autorizada%' " +
                    "ORDER BY NF.data_emissao_nf DESC";
                this.fbConnection1.Open();
                this.datItens_nota.SelectCommand.Connection = fbConnection1;
                this.datItens_nota.SelectCommand.ExecuteNonQuery();
                datItens_nota.Fill(ITENS_NOTA);
                this.fbConnection1.Close();
            }

            catch
            {
                fbConnection1.Close();
                MessageBox.Show("Erro no select saida");
            }

        }

        private void localizar_item(string cod)
        {
            try
            {
                dsProdutos.Clear();
                this.datProdutos.SelectCommand.CommandText =
                "SELECT * FROM PRODUTOS WHERE COD_PRODUTO = " + cod;
                this.fbConnection1.Open();
                this.datProdutos.SelectCommand.Connection = fbConnection1;
                this.datProdutos.SelectCommand.ExecuteNonQuery();
                datProdutos.Fill(PRODUTOS);
                this.fbConnection1.Close();
                selecionar_entradas(cod);
                selecionar_saidas(cod);
                selecionar_comissao();
                selecionar_itens_kit();
                selecionar_itens_produto();
                selecionar_desenhos();

                //selecio
            }
            catch
            {
                fbConnection1.Close();
                MessageBox.Show("Erro no select");
            }




        }

        private void button1_Click(object sender, EventArgs e)
        {
            form_grupo_produto grup = new form_grupo_produto();
            try
            {
                grup.busca = true;
                grup.ShowDialog();
            }
            finally
            {
                tb_cod_grupo.Text = grup.cod;
                tb_grupo.Text = grup.descricao;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            form_unidade unid = new form_unidade();
            try
            {
                unid.busca = true;
                unid.ShowDialog();
            }
            finally
            {
                tb_cod_unidade.Text = unid.abreviacao;
                tb_unidade.Text = unid.descricao;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form_sub_grupo_produto grup = new form_sub_grupo_produto();
            try
            {
                grup.busca = true;
                grup.ShowDialog();
            }
            finally
            {
                if (grup.cod == null)
                {
                    grup.cod = "";
                    grup.descricao = "";
                }
                tb_cod_sub_grupo.Text = grup.cod;
                tb_sub_grupo.Text = grup.descricao;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {



        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

            try
            {
                this.datItens_nf_entrada.InsertCommand.CommandText =
                "INSERT INTO ITENS_NF_ENTRADA (COD_ITENS_NF_ENT, ITEM_ITENS_NF_ENT, QTDE_ITENS_NF_ENT, DATA_ENT_ITENS_NF_ENT, N_NOTA_ITENS_NF_ENT) VALUES " +
                "('" + tb_cod.Text + "','" + tb_descricao.Text + "','0','" + DateTime.Now.ToShortDateString().Replace("/", ".") + "','0')";
                this.fbConnection1.Open();
                this.datItens_nf_entrada.InsertCommand.Connection = fbConnection1;
                this.datItens_nf_entrada.InsertCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
                selecionar_entradas(tb_cod.Text);
            }
            catch
            {
                fbConnection1.Close();
                MessageBox.Show("Erro na inserção");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvItens.SelectedRows[0].Cells["col_nf_entrada"].Value.ToString() == "0")
                {
                    this.datItens_nf_entrada.DeleteCommand.CommandText =
                            "DELETE FROM ITENS_NF_ENTRADA WHERE COD_CONTROLE_ITENS_NF_ENT = '" + dgvItens.SelectedRows[0].Cells["col_cod_item_entrada"].Value.ToString() + "'";
                    this.fbConnection1.Open();
                    this.datItens_nf_entrada.DeleteCommand.Connection = fbConnection1;
                    this.datItens_nf_entrada.DeleteCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                    selecionar_entradas(tb_cod.Text);
                }
                else
                {
                    MessageBox.Show("Para apagar um item de nf de entrada, você deve entrar no nf de entrada para excluí-lo.");
                }
            }
            catch
            {
                fbConnection1.Close();
                MessageBox.Show("Erro ao excluir");
            }
        }

        private void dgvItens_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {


        }

        private void button10_Click(object sender, EventArgs e)
        {
            /*
            double _total_saidas = 0, _total_entradas = 0, _saldo =0;
            for (int i = 0; i < dgvItens_nota.RowCount; i++)
            {
                try
                {
                    _total_saidas = _total_saidas + Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_qtde_saida"].Value);
                }
                catch { }
            }
            for (int i = 0; i < dgvItens.RowCount; i++)
            {
                try
                {
                    _total_entradas = _total_entradas + Convert.ToDouble(dgvItens.Rows[i].Cells["col_qtde_entrada"].Value);
                }
                catch { }
            }
            _saldo = _total_entradas - _total_saidas;
            tabControl1.SelectedTab = tabPage2;
            tb_estoque_atual.Text = _saldo.ToString(); //pq não foi lançada as nnf de saida ainda
            //tb_estoque_medio.Text = _saldo.ToString();
            */
            classeEstoque estoque = new classeEstoque();
            estoque.fbConnection1.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=10.3.3.4;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
            estoque.calcular_estoque(txtCodAlternativo.Text);
            localizar_item(tb_cod.Text);

        }

        private void dgvItens_nota_EditModeChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            form_pedidos ped = new form_pedidos(cnpj_empresa);
            try
            {
                ped.abrir = true;
                ped.cod_a_abrir = dgvItens_nota.SelectedRows[0].Cells["col_ped"].Value.ToString();
                ped.ShowDialog();
            }
            finally
            {
                selecionar_saidas(tb_cod.Text);
            }
        }

        private void dgvItens_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvItens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            if (dgvItens.Rows[e.RowIndex].Cells["col_nf_entrada"].Value.ToString() != "0")
                MessageBox.Show("Para alterar esse item você deve entrar na nf entrada");
             * */
        }

        private void btnSelecionarFornecedor_Click(object sender, EventArgs e)
        {
            form_localiza_cliente fornecedores = new form_localiza_cliente(false, cnpj_empresa);

            try
            {
                fornecedores._cadastro = true;
                fornecedores.ShowDialog();
            }
            finally
            {
                txtCnpjFornecedor.Text = fornecedores.cnpj_escolhido;
                txtNomeFornecedor.Text = fornecedores.cliente_escolhido;

                fornecedores.Dispose();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            form_familias_produto grup = new form_familias_produto();
            try
            {
                grup.busca = true;
                grup.ShowDialog();
            }
            finally
            {
                tb_familia.Text = grup.descricao;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            double coeficiente = 0, custo = 0, venda = 0, minimo = 0;
            try
            {

                if (tb_custo.Text != "" && tb_lucro_produto.Text != "")
                {
                    double custo_produto = double.Parse(tb_custo.Text);
                    double lucro_produto = (double.Parse(tb_lucro_produto.Text) / 100) + 1;
                    tb_coeficiente.Text = ((custo_produto / (lucro_produto * custo_produto))).ToString("n2");
                }
                custo = Convert.ToDouble(tb_custo.Text);
                coeficiente = Convert.ToDouble(tb_coeficiente.Text);
                minimo = custo / coeficiente;
                venda = custo / (coeficiente - 0.05);
                tb_venda.Text = venda.ToString("n2");
                tb_minimo.Text = minimo.ToString("n2");
            }
            catch { }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            form_vendedores vendedores = new form_vendedores();

            try
            {
                vendedores.ShowDialog();
            }
            finally
            {
                txtCodVendedor.Text = vendedores.cod_vendedor_escolhido;
                txtNomeVendedor.Text = vendedores.vendedor_escolhido;


            }
        }

        private void btnInserirVendedor_Click(object sender, EventArgs e)
        {
            try
            {
                FbCommand insert = new FbCommand();
                insert.CommandText =
                    "INSERT INTO COMISSAO_PRODUTO_VENDEDOR (COD_VENDEDOR_CPV, " +
                    "COD_PRODUTO_CPV, PORC_COMISSAO_CPV, NOME_VENDEDOR_CPV) " +
                    " values ('" + txtCodVendedor.Text + "','" + tb_cod.Text + "','" +
                    Convert.ToDouble(tb_comissao.Text).ToString().Replace(",", ".") + "','" +
                    txtNomeVendedor.Text + "')";
                insert.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datInsert = new FbDataAdapter();
                datInsert.InsertCommand = insert;
                datInsert.InsertCommand.ExecuteNonQuery();
                fbConnection1.Close();
                selecionar_comissao();

            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void selecionar_comissao()
        {
            try
            {
                dsCpv.Clear();
                datCpv.SelectCommand.CommandText =
                    "SELECT * FROM COMISSAO_PRODUTO_VENDEDOR WHERE COD_PRODUTO_CPV = '" + tb_cod.Text + "'";
                datCpv.SelectCommand.Connection = fbConnection1;
                fbConnection1.Open();
                datCpv.Fill(COMISSAO_PRODUTO_VENDEDOR);
                fbConnection1.Close();

            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void textBox26_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2:
                    localiza_item();
                    break;
            }
        }

        private void localiza_item()
        {
            form_localiza_produto localiza_item = new form_localiza_produto(true, cnpj_empresa);
            try
            {
                localiza_item.buscar = true;
                localiza_item.ShowDialog();
            }
            finally
            {
                localiza_item.Dispose();
                if (localiza_item.cod_produto_escolhido == "")
                {
                    MessageBox.Show("Esse item não está vinculado a nenhum item do estoque");
                }
                else
                {
                    tb_item_item.Text = localiza_item.descricao_produto_escolhido;
                    tb_cod_item.Text = localiza_item.cod_produto_escolhido;
                    tb_qtde_kit.Focus();
                }
            }
        }

        private void localiza_item_mp()
        {
            form_localiza_produto localiza_item = new form_localiza_produto(true, cnpj_empresa);
            try
            {
                localiza_item.buscar = true;
                localiza_item.ShowDialog();
            }
            finally
            {
                localiza_item.Dispose();
                if (localiza_item.cod_produto_escolhido == "")
                {
                    MessageBox.Show("Esse item não está vinculado a nenhum item do estoque");
                }
                else
                {
                    tb_descricao_componente.Text = localiza_item.descricao_produto_escolhido;
                    tb_item.Text = localiza_item.cod_forn;
                    tb_cod_componente.Text = localiza_item.cod_produto_escolhido;
                    tb_un_componente.Text = localiza_item.unidade_produto_escolhido;
                    tb_qtde_componente.Focus();
                }
            }
        }

        private void tb_cod_item_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                if (tb_cod_item.Text == "")
                { }
                else
                {
                    localizar_item_kit(tb_cod_item.Text);
                    tb_qtde_kit.Focus();
                }
            }
        }

        private void localizar_item_kit(string cod)
        {
            try
            {
                FbCommand select = new FbCommand();
                FbDataAdapter datProdutos1 = new FbDataAdapter();
                DataTable dtProdutos = new DataTable();
                select.CommandText =
                "SELECT DESCRICAO_PRODUTO FROM PRODUTOS WHERE COD_PRODUTO = " + cod;
                select.Connection = fbConnection1;
                fbConnection1.Open();
                datProdutos1.SelectCommand = select;
                datProdutos1.Fill(dtProdutos);
                fbConnection1.Close();
                foreach (DataRow dr in dtProdutos.Rows)
                {
                    tb_item_item.Text = dr[0].ToString();
                }
            }
            catch
            {
                fbConnection1.Close();
                MessageBox.Show("Erro no select");
            }
        }

        private void tb_qtde_kit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                if (tb_qtde_kit.Text == "")
                { }
                else
                {
                    button15.Focus();
                }
            }
        }

        private void selecionar_itens_kit()
        {
            try
            {
                dsProdutos_kit.Clear();
                datProdutos_kit.SelectCommand.CommandText =
                    "SELECT pk.*, p.COD_FORNECEDOR_PRODUTO as COD_FORN FROM PRODUTOS_KIT pk INNER JOIN produtos p on pk.COD_PRODUTO_PK = p.cod_produto WHERE pk.COD_KIT_PK = " + tb_cod.Text + "";
                datProdutos_kit.SelectCommand.Connection = fbConnection1;
                fbConnection1.Open();
                datProdutos_kit.Fill(PRODUTOS_KIT);
                fbConnection1.Close();

            }
            catch (Exception a)
            {
                fbConnection1.Close();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                FbCommand insert = new FbCommand();
                insert.CommandText =
                    "INSERT INTO PRODUTOS_KIT (COD_KIT_PK, COD_PRODUTO_PK, DESCRICAO_PK, QTDE_PK) VALUES (" + tb_cod.Text + "," + tb_cod_item.Text + ",'" +
                    tb_item_item.Text + "','" + Convert.ToDouble(tb_qtde_kit.Text).ToString().Replace(".", "").Replace(",", ".") + "')";
                insert.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datInsert = new FbDataAdapter();
                datInsert.InsertCommand = insert;
                datInsert.InsertCommand.ExecuteNonQuery();
                fbConnection1.Close();

                selecionar_itens_kit();
                tb_cod_item.Text = ""; tb_item_item.Text = ""; tb_qtde_kit.Text = "";

            }
            catch (Exception a)
            {
                fbConnection1.Close();
            }
        }

        private void tb_qtde_producao_para_estoque_TextChanged(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void bt_abrir_Click(object sender, EventArgs e)
        {

        }


        public string retornaImpressoraPadrao()
        {
            PrintDocument pd = new PrintDocument();
            return pd.PrinterSettings.PrinterName;
        }

        [DllImport("winspool.drv", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetDefaultPrinter(string Name);

        private void button28_Click(object sender, EventArgs e)
        {
            string impressoraPadraoOriginal = retornaImpressoraPadrao();
            string impressoraEtiqueta = "ZDesigner TLP 2844";
            try
            {

                SetDefaultPrinter(impressoraEtiqueta);



                dsEtiquetas ds = new dsEtiquetas();
                try
                {
                    FbCommand select = new FbCommand();
                    select.CommandText =
                        "SELECT * FROM EMPRESA WHERE LICENCA_DLL_NFE_EMPRESA IS NOT NULL";
                    select.Connection = fbConnection1;
                    fbConnection1.Open();
                    FbDataAdapter datSelect = new FbDataAdapter();
                    datSelect.SelectCommand = select;
                    DataTable dtSelect = new DataTable();
                    datSelect.Fill(ds.EMPRESA);
                    fbConnection1.Close();

                }
                catch (Exception a)
                {
                    fbConnection1.Close();
                    MessageBox.Show(a.ToString());
                }

                try
                {

                    ds.Produtos.AddProdutosRow(txtCodAlternativo.Text,
                       tb_descricao.Text,
                        DateTime.Now, 0, "");

                }
                catch { }

                crEtiquetas cr = new crEtiquetas();
                cr.SetDataSource(ds);
                form_imprimir print = new form_imprimir(cr);
                print.Show();
            }
            finally
            {
                SetDefaultPrinter(impressoraPadraoOriginal);
            }

        }

        private void button29_Click(object sender, EventArgs e)
        {
            string cod = tb_cod_grupo.Text + zero_a_esquerda(3, tb_cod_sub_grupo.Text) + zero_a_esquerda(4, proximo_codigo(tb_cod_grupo.Text + zero_a_esquerda(3, tb_cod_sub_grupo.Text)));
            tb_cod.Text = cod.ToString();
            txtCodAlternativo.Text = cod.ToString();
            txtCodBarrasCaixa.Text = cod.ToString();
            txtCodBarrasUnit.Text = cod.ToString();
             //salvar();
        }

        private string proximo_codigo(string grupo_subgrupo)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                        "SELECT COD_FORNECEDOR_PRODUTO FROM PRODUTOS WHERE COD_FORNECEDOR_PRODUTO like '" + grupo_subgrupo + "%'";
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                int maior = 0;
                int cod = 0;
                foreach (DataRow dr in dtSelect.Rows)
                {
                    try
                    {
                        cod = Convert.ToInt16(dr[0].ToString().Substring(6, 4));
                        if (cod > maior)
                        {
                            maior = cod;
                        }

                    }
                    catch { }

                }
                maior++;
                return maior.ToString();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                return "0";
            }
           
        }

        private string zero_a_esquerda(int tamanho_pretendido, string valor)
        {
            tamanho_pretendido = tamanho_pretendido; //por causa do 14 na frente (Caixa) 
            int tamanho = valor.Length;
            for (int p = 0; p < tamanho_pretendido - tamanho; p++)
            {
                valor = "0" + valor;
            }

            return valor;
        }

        private void button16_Click_1(object sender, EventArgs e)
        {

        }

        private void selecionar_itens_produto()
        {
            try
            {
                dsItens_produto.Clear();
                FbCommand cmd = new FbCommand();
                cmd.CommandText =
                    @"SELECT * FROM ITENS_PRODUTO WHERE COD_PRODUTO_IP = '" + tb_cod.Text + "'";
                cmd.Connection = fbConnection1;
                datItens_produto.SelectCommand = cmd;
                fbConnection1.Open();
                datItens_produto.Fill(ITENS_PRODUTO);
                fbConnection1.Close();
            }
            catch
            {
                fbConnection1.Close();
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_cod_componente.Text != "" && tb_descricao_componente.Text != "" && tb_qtde_componente.Text != "" && tb_item.Text != "")
                {
                    string cod = tb_cod_componente.Text, descricao = tb_descricao_componente.Text, cod_prod = tb_cod.Text;
                    double qtde = 0;
                    Double.TryParse(tb_qtde_componente.Text, out qtde);

                    FbCommand cmd = new FbCommand();
                    FbDataAdapter datItensProduto = new FbDataAdapter();
                    cmd.CommandText =
                        @"INSERT INTO ITENS_PRODUTO (COD_ESTOQUE_IP, DESCRICAO_IP, QTDE_IP, COD_PRODUTO_IP, UN_IP, ITEM_IP) VALUES
                        ('" + cod + "','" + descricao + "','" + qtde.ToString().Replace(".", "").Replace(",", ".") + "','" + cod_prod + "', '" + tb_un_componente.Text + "','" + tb_item.Text + "')";
                    cmd.Connection = fbConnection1;
                    datItensProduto.InsertCommand = cmd;
                    fbConnection1.Open();
                    datItensProduto.InsertCommand.ExecuteNonQuery();
                    fbConnection1.Close();
                    selecionar_itens_produto();
                }
                else
                {
                    MessageBox.Show("Campos preenchidos incorretamente");
                }

            }
            catch
            {
                fbConnection1.Close();
            }
        }

        private void button16_Click_2(object sender, EventArgs e)
        {
            localiza_item_estoque();
        }

        private void localiza_item_estoque()
        {
            form_busca_item_estoque_mp localiza_item = new form_busca_item_estoque_mp(cnpj_empresa);
            try
            {
                localiza_item.ShowDialog();
            }
            finally
            {
                localiza_item.Dispose();
                if (localiza_item.cod_escolhido == "")
                {
                    MessageBox.Show("Esse item não está vinculado a nenhum item do estoque");
                }
                else
                {
                    tb_descricao_componente.Text = localiza_item.item_escolhido + " " + localiza_item.descricao_escolhido;
                    tb_cod_componente.Text = localiza_item.cod_escolhido;
                   // tb_un_componente.Text = localiza_item; ;
                    tb_item.Text = localiza_item.item_escolhido;
                    tb_qtde_componente.Focus();
                }
            }
        
        }

        private void dgvKit_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            form_produto prod = new form_produto(cnpj_empresa);
            try
            {
                bool erro = false;
                prod.modificar = true;

                prod.cod_prod = dgvKit.Rows[e.RowIndex].Cells["col_cod"].Value.ToString();


                prod.Show();
            }
            finally
            {
               
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog2 = new OpenFileDialog();
             openFileDialog2.Multiselect = true;
             if (openFileDialog2.ShowDialog() == DialogResult.OK)
             {
                 if (openFileDialog2.FileNames.Length > 0)
                 {
                     for (int i = 0; i < openFileDialog2.FileNames.Length; i++)
                     {
                         try
                         {
                             FbCommand insert = new FbCommand();
                             insert.Connection = fbConnection1;
                             fbConnection1.Open();
                             insert.CommandText =
                                 "INSERT INTO DESENHOS_PRODUTO (LINK_DES_PRODUTO, COD_PROD_DES_PRODUTO) values ('" + 
                                 openFileDialog2.FileNames[i].ToString() + "','" + tb_cod.Text + "')";
                             FbDataAdapter datInsert = new FbDataAdapter();
                             datInsert.InsertCommand = insert;
                             datInsert.InsertCommand.ExecuteNonQuery();
                             fbConnection1.Close();
                         }
                         catch (Exception ex)
                         {
                             fbConnection1.Close();
                         }

                     }
                     selecionar_desenhos();

                 }
             }
        }

        private void selecionar_desenhos()
        {
            try
            {
                dsDesenhos_produto.Clear();
                datDesenhos_produto.SelectCommand.CommandText = "SELECT * FROM DESENHOS_PRODUTO WHERE COD_PROD_DES_PRODUTO = '" + tb_cod.Text + "'";
                datDesenhos_produto.SelectCommand.Connection = fbConnection1;
                fbConnection1.Open();
                datDesenhos_produto.Fill(DESENHOS_PRODUTO);
                fbConnection1.Close();

            }
            catch { fbConnection1.Close(); }
        }

        private void dgvDesenhos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void tb_descricao_componente_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2:
                    localiza_item_mp();
                    break;
            }
        }

        private void dgvDesenhos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDesenhos.Columns[e.ColumnIndex].Name == "col_abrir_desenho")
            {
                Process.Start(dgvDesenhos.Rows[e.RowIndex].Cells["col_link"].Value.ToString());
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            form_localiza_produto localiza_item = new form_localiza_produto(true, cnpj_empresa);
            try
            {
                localiza_item.buscar = true;
                localiza_item.ShowDialog();
            }
            finally
            {
                localiza_item.Dispose();
                if (localiza_item.cod_produto_escolhido == "")
                {
                    MessageBox.Show("Esse item não está vinculado a nenhum item do estoque");
                }
                else
                {
                    try
                    {
                        FbCommand select = new FbCommand();
                        select.Connection = fbConnection1;
                        fbConnection1.Open();
                        select.CommandText =
                            @"SELECT pk.*  FROM PRODUTOS_KIT pk
                            WHERE pk.COD_KIT_PK = " + localiza_item.cod_produto_escolhido + "";
                        FbDataAdapter datSelect = new FbDataAdapter();
                        datSelect.SelectCommand = select;
                        DataTable dtSelect = new DataTable();
                        datSelect.Fill(dtSelect);
                        fbConnection1.Close();
                        foreach (DataRow dr in dtSelect.Rows)
                        {
                            try
                            {
                                FbCommand insert = new FbCommand();
                                insert.CommandText =
                                    "INSERT INTO PRODUTOS_KIT (COD_KIT_PK, COD_PRODUTO_PK, DESCRICAO_PK, QTDE_PK) VALUES (" + tb_cod.Text + "," + dr["COD_PRODUTO_PK"].ToString() + ",'" +
                                     dr["DESCRICAO_PK"].ToString() + "','" + Convert.ToDouble(dr["QTDE_PK"].ToString()).ToString().Replace(".", "").Replace(",", ".") + "')";
                                insert.Connection = fbConnection1;
                                fbConnection1.Open();
                                FbDataAdapter datInsert = new FbDataAdapter();
                                datInsert.InsertCommand = insert;
                                datInsert.InsertCommand.ExecuteNonQuery();
                                fbConnection1.Close();

                                
                                

                            }
                            catch (Exception a)
                            {
                                fbConnection1.Close();
                            }
                        }
                        selecionar_itens_kit();

                    }
                    catch (Exception a)
                    {
                        fbConnection1.Close();
                    }

                }
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvKit.SelectedRows.Count; i++)
            {
                try
                {
                    FbCommand delete = new FbCommand();
                    delete.Connection = fbConnection1;
                    delete.CommandText =
                            "DELETE FROM PRODUTOS_KIT WHERE COD_PK = '" + dgvKit.SelectedRows[i].Cells["col_cod_pk"].Value.ToString() + "'";
                    fbConnection1.Open();
                    FbDataAdapter datDelete = new FbDataAdapter();
                    datDelete.DeleteCommand = delete;
                    datDelete.DeleteCommand.ExecuteNonQuery();
                    fbConnection1.Close();
                    selecionar_itens_kit();
                }
                catch (Exception ex)
                {
                    fbConnection1.Close();
                    MessageBox.Show(ex.Message);
                }
            }
        }
        
        
        
        
        
    }
}