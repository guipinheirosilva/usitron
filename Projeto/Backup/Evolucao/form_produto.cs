using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_produto : Form
    {
        public bool modificar, novo;
        public string cod_prod;
        public form_produto()
        {
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
                this.BindingContext[dsItens_nf_entrada, "ITENS_NF_ENTRADA"].EndCurrentEdit();
                if (dsItens_nf_entrada.HasChanges())
                {
                    fbConnection1.Open();
                    datItens_nf_entrada.UpdateCommand = cbItens_nf_entrada.GetUpdateCommand();
                    datItens_nf_entrada.InsertCommand = cbItens_nf_entrada.GetInsertCommand();
                    datItens_nf_entrada.DeleteCommand = cbItens_nf_entrada.GetDeleteCommand();
                    datItens_nf_entrada.Update(dsItens_nf_entrada, "ITENS_NF_ENTRADA");
                    dsItens_nf_entrada.AcceptChanges();
                    fbConnection1.Close();
                }
                this.BindingContext[dsItens_ped_venda, "ITENS_PEDIDO_VENDA"].EndCurrentEdit();
                if (dsItens_ped_venda.HasChanges())
                {
                    fbConnection1.Open();
                    datItens_ped_venda.UpdateCommand = cbItens_ped_venda.GetUpdateCommand();
                    datItens_ped_venda.InsertCommand = cbItens_ped_venda.GetInsertCommand();
                    datItens_ped_venda.DeleteCommand = cbItens_ped_venda.GetDeleteCommand();
                    datItens_ped_venda.Update(dsItens_ped_venda, "ITENS_PEDIDO_VENDA");
                    dsItens_ped_venda.AcceptChanges();
                    fbConnection1.Close();
                }

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
            form_localiza_produto localiza_item = new form_localiza_produto();
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
                        "SELECT * FROM ITENS_NF_ENTRADA WHERE COD_ITENS_NF_ENT = '" + cod + "'";
                        this.fbConnection1.Open();
                        this.datItens_nf_entrada.SelectCommand.Connection = fbConnection1;
                        this.datItens_nf_entrada.SelectCommand.ExecuteNonQuery();
                        datItens_nf_entrada.Fill(ITENS_NF_ENTRADA);
                        this.fbConnection1.Close();
             }
                      
                    catch { 
                    fbConnection1.Close();
                        MessageBox.Show("Erro no select entrada");
                    }
                    
        }

        private void selecionar_saidas(string cod)
        {
            try
            {
                dsItens_ped_venda.Clear();
                this.datItens_ped_venda.SelectCommand.CommandText =
                "SELECT * FROM ITENS_PEDIDO_VENDA WHERE COD_SISTEMA_PROD_ITEM_VENDA = '" + cod + "'";
                this.fbConnection1.Open();
                this.datItens_ped_venda.SelectCommand.Connection = fbConnection1;
                this.datItens_ped_venda.SelectCommand.ExecuteNonQuery();
                datItens_ped_venda.Fill(ITENS_PEDIDO_VENDA);
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
                        "SELECT * FROM PRODUTOS WHERE COD_PRODUTO = '" + cod + "'";
                        this.fbConnection1.Open();
                        this.datProdutos.SelectCommand.Connection = fbConnection1;
                        this.datProdutos.SelectCommand.ExecuteNonQuery();
                        datProdutos.Fill(PRODUTOS);
                        this.fbConnection1.Close();
                        selecionar_entradas(cod);
                        selecionar_saidas(cod);
                    }
                    catch { 
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
                tb_cod_sub_grupo.Text = grup.cod;
                tb_sub_grupo.Text = grup.descricao;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                this.datItens_ped_venda.InsertCommand.CommandText =
                    "INSERT INTO ITENS_PEDIDO_VENDA (COD_PROD_ITEM_VENDA, DESCRICAO_PROD_ITEM_VENDA, UNIDADE_PROD_ITEM_VENDA, QTDE_ITEM_VENDA, COD_PEDIDO_ITEM_VENDA) " +
                    "VALUES ('" + tb_cod.Text + "','" + tb_descricao.Text + "','" + tb_cod_unidade.Text + "','0','0')";
                this.fbConnection1.Open();
                this.datItens_ped_venda.InsertCommand.Connection = fbConnection1;
                this.datItens_ped_venda.InsertCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
                selecionar_saidas(tb_cod.Text);
            }
            catch
            {
                fbConnection1.Close();
                MessageBox.Show("Erro na inserção");
            }
                    
       
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvItens_nota.SelectedRows[0].Cells["col_ped"].Value.ToString() == "0")
                {
                    this.datItens_ped_venda.DeleteCommand.CommandText =
                            "DELETE FROM ITENS_PEDIDO_VENDA WHERE COD_ITEM_VENDA = '" + dgvItens_nota.SelectedRows[0].Cells["col_cod_item_saida"].Value.ToString() + "'";
                    this.fbConnection1.Open();
                    this.datItens_ped_venda.DeleteCommand.Connection = fbConnection1;
                    this.datItens_ped_venda.DeleteCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                    selecionar_saidas(tb_cod.Text);
                }
                else
                {
                    MessageBox.Show("Para apagar um item de pedido, você deve entrar no pedido para excluí-lo.");
                }
            }
            catch
            {
                fbConnection1.Close();
                MessageBox.Show("Erro ao excluir");
            }
        }

        private void dgvItens_nota_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           

        }

        private void button9_Click(object sender, EventArgs e)
        {

            try
            {
                this.datItens_nf_entrada.InsertCommand.CommandText =
                "INSERT INTO ITENS_NF_ENTRADA (COD_ITENS_NF_ENT, ITEM_ITENS_NF_ENT, QTDE_ITENS_NF_ENT, DATA_ENT_ITENS_NF_ENT, N_NOTA_ITENS_NF_ENT) VALUES " +
                "('" + tb_cod.Text + "','" + tb_descricao.Text + "','0','" + DateTime.Now.ToShortDateString().Replace("/",".") + "','0')";
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
            form_nf_entrada nf = new form_nf_entrada();
            try
            {
                nf.abrir = true;
                nf.cod_a_abrir = dgvItens_nota.Rows[e.RowIndex].Cells["col_cod_item_entrada"].Value.ToString();
                nf.ShowDialog();
            }
            finally
            {
                selecionar_entradas(tb_cod.Text);
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
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

        }

        private void dgvItens_nota_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void dgvItens_nota_EditModeChanged(object sender, EventArgs e)
        {
           
        }

        private void dgvItens_nota_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                form_nf_entrada nf = new form_nf_entrada();
                try
                {
                    nf.abrir = true;
                    nf.cod_a_abrir = dgvItens_nota.SelectedRows[0].Cells["col_cod_item_entrada"].Value.ToString();
                    nf.ShowDialog();
                }
                finally
                {
                    selecionar_entradas(tb_cod.Text);
                }
            }
            catch
            {
                MessageBox.Show("selecione a linha inteira");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            form_pedidos ped = new form_pedidos();
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
            if (dgvItens.Rows[e.RowIndex].Cells["col_nf_entrada"].Value.ToString() != "0")
                MessageBox.Show("Para alterar esse item você deve entrar na nf entrada");
        }

        private void dgvItens_nota_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvItens_nota.Rows[e.RowIndex].Cells["col_ped"].Value.ToString() != "0")
                MessageBox.Show("Para alterar esse item você deve entrar no pedido");
        }

        private void btnSelecionarFornecedor_Click(object sender, EventArgs e)
        {
            form_localiza_forn fornecedores = new form_localiza_forn(false);

            try
            {
                fornecedores.ShowDialog();
            }
            finally
            {
                txtCnpjFornecedor.Text = fornecedores.cnpj_escolhido;
                txtNomeFornecedor.Text = fornecedores.razao_forn_escolhido;

                fornecedores.Dispose();
            }
        }

        
        

        

        
    }
}