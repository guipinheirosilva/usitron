using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_criar_ops : Form
    {
        public form_criar_ops()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dtIntermediario = dtItens_pedido.Clone();
            DataColumn col_mae = new DataColumn();
            col_mae.ColumnName = "col_mae";
            dtIntermediario.Columns.Add(col_mae);
                int posicao = 1;
                for (int i = 0; i < dgvProdutos.RowCount; i++)
                {
                    if (Convert.ToBoolean(dgvProdutos.Rows[i].Cells["col_selecionado"].Value))
                    {
                        try
                        {
                           

                            double saldo = 0, nova_op = 0, diferenca = 0;
                            bool ok = false, _30 = false;

                            try
                            {
                                saldo = Convert.ToDouble(dgvProdutos.Rows[i].Cells["Qtde"].Value.ToString());
                                nova_op = Convert.ToDouble(dgvProdutos.Rows[i].Cells["Qtde_a_Fabricar"].Value.ToString());
                                diferenca = saldo + nova_op;
                                if (diferenca >= 0)
                                {
                                    ok = true;
                                    double porc = (((nova_op/saldo)*-1 - 1) * 100);
                                    if (porc > 30)
                                    {
                                        _30 = true;
                                        MessageBox.Show("Você está criando uma OP com a quantidade " + porc.ToString() + "% a mais do que precisa. Verifique.");
                                    }
                                }
                               
                                    
                            }
                            catch
                            {

                            }
                            /*   @"select  iped.cod_prod_item_venda as Cod_Produto, 
                    iped.descricao_prod_item_venda as Descricao, iped.DATA_ENTREGA_ITEM_VENDA as Data_Entrega, qtde_item_venda as Qtde_a_Fabricar,
                    prod.ESTOQUE_RESERVADO_PRODUTO as Necessidade, prod.ESTOQUE_RESERVA_FECHADA_PRODUTO as Empenhado, prod.ESTOQUE_ENCOMENDADO_PRODUTO as Producao, 
                    prod.ESTOQUE_SEPARADO_PRODUTO as Separado, 
                    prod.ESTOQUE_DISPONIVEL_PRODUTO as Saldo, prod.estoque_atual_produto as Estoque_Atual,  pv.CLIENTE_PED_VENDA as Cliente,
                    iped.COD_ITEM_VENDA,  pv.N_PED_VENDA as Pedido,  pv.COD_PED_VENDA as Cod_interno,
                    iped.PEDIDO_CLIENTE_ITEM_VENDA as Pedido_Cliente,  iped.ITEM_PED_CLIENTE_ITEM_VENDA as Item_Ped_Cliente,  
                    iped.COD_SISTEMA_PROD_ITEM_VENDA as Cod_Sistema_Produto,
                    iped.UNIDADE_PROD_ITEM_VENDA as Un, 
                     iped.qtde_item_venda as Qtde;*/
                            if (ok)
                            {
                                /*preenchendo dataset*/
                               
                               
                                string cod = dgvProdutos.Rows[i].Cells["COD_ITEM_VENDA"].Value.ToString();
                                string cod_mae = dgvProdutos.Rows[i].Cells["Cod_Produto"].Value.ToString();
                                FbCommand select1 = new FbCommand();
                                select1.Connection = fbConnection1;
                                fbConnection1.Open();
                                select1.CommandText =
                                         @"select  iped.cod_prod_item_venda as Cod_Produto, 
                    iped.descricao_prod_item_venda as Item, iped.DESCRICAO_ITEM_PROD_ITEM_VENDA as Ferramenta, iped.DATA_ENTREGA_ITEM_VENDA as Data_Entrega,  " + 
//(case
//    WHEN ( prod.ESTOQUE_DISPONIVEL_PRODUTO >= 0) then 0
//    When (prod.ESTOQUE_DISPONIVEL_PRODUTO < 0) then prod.ESTOQUE_DISPONIVEL_PRODUTO * -1 end) 
@" iped.qtde_item_venda 
as Qtde_a_Fabricar,
                    prod.ESTOQUE_RESERVADO_PRODUTO as Necessidade, prod.ESTOQUE_RESERVA_FECHADA_PRODUTO as Empenhado, prod.ESTOQUE_ENCOMENDADO_PRODUTO as Producao, 
                    prod.ESTOQUE_SEPARADO_PRODUTO as Separado, 
                    prod.ESTOQUE_DISPONIVEL_PRODUTO as Saldo, prod.estoque_atual_produto as Estoque_Atual,  pv.CLIENTE_PED_VENDA as Cliente,
                    iped.COD_ITEM_VENDA,  pv.N_PED_VENDA as Pedido,  pv.COD_PED_VENDA as Cod_interno,
                    iped.PEDIDO_CLIENTE_ITEM_VENDA as Pedido_Cliente,  iped.ITEM_PED_CLIENTE_ITEM_VENDA as Item_Ped_Cliente,  
                    iped.COD_SISTEMA_PROD_ITEM_VENDA as Cod_Sistema_Produto,
                    iped.UNIDADE_PROD_ITEM_VENDA as Un, 
                     iped.qtde_item_venda as Qtde, '' as col_mae 
                    from itens_pedido_venda iped 
                    inner join pedidos_venda pv on iped.COD_PEDIDO_ITEM_VENDA = pv.COD_PED_VENDA 
                    inner join produtos prod on iped.COD_PROD_ITEM_VENDA = prod.COD_FORNECEDOR_PRODUTO 
                    where  
                    iped.COD_ITEM_VENDA = '" + cod + "'";

                                FbDataAdapter datSelect1 = new FbDataAdapter();
                                datSelect1.SelectCommand = select1;
                                DataTable dtSelect1 = new DataTable();
                                datSelect1.Fill(dtIntermediario);
                                fbConnection1.Close();
                               

                                //string _cod_op = "";

                                //inserir_op(dgvProdutos.Rows[i].Cells["Cod_Produto"].Value.ToString(),
                                //    dgvProdutos.Rows[i].Cells["Descricao"].Value.ToString(),
                                //    posicao.ToString(), dgvProdutos.Rows[i].Cells["Qtde_a_Fabricar"].Value.ToString(),
                                //    dgvProdutos.Rows[i].Cells["Cod_interno"].Value.ToString(), dgvProdutos.Rows[i].Cells["Data_Entrega"].Value.ToString(), "", out _cod_op);
                                //string op_mae = _cod_op;

                                //FbCommand update = new FbCommand();
                                //update.Connection = fbConnection1;
                                //update.CommandText = "UPDATE ITENS_PEDIDO_VENDA SET OP_INTERNA_ITEM_VENDA = '" + _cod_op + "' WHERE COD_ITEM_VENDA = " + dgvProdutos.Rows[i].Cells["COD_ITEM_VENDA"].Value.ToString();
                                //fbConnection1.Open();
                                //FbDataAdapter datUpdate = new FbDataAdapter();
                                //datUpdate.UpdateCommand = update;
                                //datUpdate.UpdateCommand.ExecuteNonQuery();
                                //fbConnection1.Close();

                                //classeEstoque estoque = new classeEstoque();
                                //estoque.fbConnection1.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=10.3.3.4;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
                                //estoque.calcular_estoque(dgvProdutos.Rows[i].Cells["Cod_Produto"].Value.ToString());


                                FbCommand select = new FbCommand();
                                select.Connection = fbConnection1;
                                fbConnection1.Open();
                                select.CommandText =
                                        "SELECT pk.*, p.COD_FORNECEDOR_PRODUTO as COD_FORN, p.COD_PRODUTO FROM PRODUTOS_KIT pk INNER JOIN produtos p on pk.COD_PRODUTO_PK = p.cod_produto " +
                                        "WHERE pk.COD_KIT_PK = '" + dgvProdutos.Rows[i].Cells["Cod_Sistema_Produto"].Value.ToString() + "'";
                                FbDataAdapter datSelect = new FbDataAdapter();
                                datSelect.SelectCommand = select;
                                DataTable dtSelect = new DataTable();
                                datSelect.Fill(dtSelect);
                                fbConnection1.Close();
                                posicao++;
                                foreach (DataRow dr in dtSelect.Rows)
                                {
                                    double qtde = 0;
                                    try
                                    {
                                        try
                                        {
                                            qtde = Convert.ToDouble(dr["QTDE_PK"].ToString()) * Convert.ToDouble(dgvProdutos.Rows[i].Cells["Qtde_a_Fabricar"].Value.ToString());
                                        }
                                        catch { }
                                        string cod_op = "";

                                        /*preenchendo dataset*/
                                        FbCommand select2 = new FbCommand();
                                        select2.Connection = fbConnection1;
                                        fbConnection1.Open();
                                        //qtde.ToString() + @"' as Qtde_a_Fabricar,
                                        select2.CommandText =
                                                 @"select  prod.COD_FORNECEDOR_PRODUTO as Cod_Produto, 
                    prod.DESCRICAO_PRODUTO as Item, prod.DESCRICAO_ITEM_PROD_ITEM_VENDA as Ferramenta, '" + dgvProdutos.Rows[i].Cells["Data_Entrega"].Value.ToString() + @"' as Data_Entrega, " + 
//                    @"(case
//    WHEN ( prod.ESTOQUE_DISPONIVEL_PRODUTO >= 0) then 0
//    When (prod.ESTOQUE_DISPONIVEL_PRODUTO < 0) then prod.ESTOQUE_DISPONIVEL_PRODUTO * -1 end)
@" iped.qtde_item_venda 
as Qtde_a_Fabricar,
                    
                    prod.ESTOQUE_RESERVADO_PRODUTO as Necessidade, prod.ESTOQUE_RESERVA_FECHADA_PRODUTO as Empenhado, prod.ESTOQUE_ENCOMENDADO_PRODUTO as Producao, 
                    prod.ESTOQUE_SEPARADO_PRODUTO as Separado, 
                    prod.ESTOQUE_DISPONIVEL_PRODUTO as Saldo, prod.estoque_atual_produto as Estoque_Atual,  '" + dgvProdutos.Rows[i].Cells["Cliente"].Value.ToString() + @"' as Cliente, 
                    '', '" + dgvProdutos.Rows[i].Cells["Pedido"].Value.ToString() + "' as Pedido, '" + dgvProdutos.Rows[i].Cells["Cod_interno"].Value.ToString() + @"' as Cod_interno, '" + 
                            dgvProdutos.Rows[i].Cells["Pedido_Cliente"].Value.ToString() + @"' as Pedido_Cliente, '" +  dgvProdutos.Rows[i].Cells["Item_Ped_Cliente"].Value.ToString() + @"'  as Item_Ped_Cliente,  
                    prod.COD_PRODUTO as Cod_Sistema_Produto,
                    prod.cod_unidade_produto as Un, 
                    '" + qtde.ToString() + @"' as Qtde, '" + cod_mae + @"' as col_mae  
                    from PRODUTOS prod
                    where  
                    prod.COD_FORNECEDOR_PRODUTO = '" + dr["COD_FORN"].ToString() + "'";

                                        FbDataAdapter datSelect2 = new FbDataAdapter();
                                        datSelect2.SelectCommand = select2;
                                        DataTable dtSelect2 = new DataTable();
                                        datSelect2.Fill(dtIntermediario);
                                        fbConnection1.Close();

                                        //inserir_op(dr["COD_FORN"].ToString(), dr["DESCRICAO_PK"].ToString(), posicao.ToString(), qtde.ToString(),
                                        //    dgvProdutos.Rows[i].Cells["Cod_interno"].Value.ToString(), dgvProdutos.Rows[i].Cells["Data_Entrega"].Value.ToString(), op_mae,  out cod_op);
                                        //classeEstoque estoque1 = new classeEstoque();
                                        //estoque1.fbConnection1.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=10.3.3.4;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
                                        //estoque1.calcular_estoque(dr["COD_FORN"].ToString());
                                    }
                                    catch { }
                                    posicao++;

                                }



                                posicao++;
                            }
                            else
                            {
                                MessageBox.Show("Não é possível criar uma OP menor do que o Saldo");
                            }
                        }
                        catch (Exception ex)
                        {
                            fbConnection1.Close();
                            MessageBox.Show(ex.Message);
                        }

                    }
                }
                form_intermediario_op op = new form_intermediario_op();
                try
                {
                    op.dtIntermediario = dtIntermediario;
                    op.ShowDialog();
                }
                finally
                {
                    selecionar_ops(tb_os.Text);
                    selecionar_itens();
                }

               

        }

        private void selecionar_ops(string os)
        {
             try
            {
                string _os = "";
                if (os != "")
                    _os = " and op.DESENHO_OP_ATUAL = '" + os + "'";
                dsOp.Clear();
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText = 
                        @"SELECT op.*, prod.* FROM OP op 
                    inner join produtos prod on op.COND_PGTO = prod.COD_FORNECEDOR_PRODUTO and prod.STATUS_PRODUTO = 1 
                 WHERE 0 = 0 " + _os + " order by op.cod_op desc";
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(OP);
                fbConnection1.Close();

            }
            catch (Exception ex)
            {
                fbConnection1.Close();
                MessageBox.Show(ex.Message);
            }
        }

        public void inserir_op(string cod_produto, string descricao, string posicao, string qtde, string cod_pedido, string data_entrega_pedido, string op_mae, out string _cod_op)
        {
            _cod_op = "";
            if (data_entrega_pedido == "")
            {
                data_entrega_pedido = "null";
            }
            else
            {
                data_entrega_pedido = "'" + Convert.ToDateTime(data_entrega_pedido).AddDays(-5).ToShortDateString().Replace("/", ".") + "'";
            }
            if (descricao.Length > 50)
                descricao = descricao.Remove(50);
            try
            {
                if (op_mae == "")
                    op_mae = "null";

                string urgente = "null";
                if (cbUrgente.Checked)
                    urgente = "1";
                datOp.InsertCommand.CommandText =
                       "INSERT INTO OP (FERRAMENTA_OP, COND_PGTO, DATA_PDF, DESENHO_OP_ATUAL, N_PDF, QDE_FAB, PEDIDO_INTERNO_OP, POSICAO_ATUAL_OP, ENTREGA_DIA, OP_MAE, URGENTE_OP)" +
                       "VALUES ('" + descricao + "','" + cod_produto + "','" + DateTime.Now.ToShortDateString().Replace("/", ".") + "', " +
                       cod_pedido + ",'" + posicao + "','" +
                       qtde.Replace(".", "").Replace(",", ".") + "'," + cod_pedido + ",'Aguardando Material'," + data_entrega_pedido + ", " + op_mae + "," + urgente + ") returning COD_OP";
                fbConnection1.Open();
                datOp.InsertCommand.Connection = fbConnection1;
                object cod_op = datOp.InsertCommand.ExecuteScalar();
                fbConnection1.Close();
                
                FbDataAdapter datRotas_campo = new FbDataAdapter();
                FbCommand insert = new FbCommand();
                insert.Connection = fbConnection1;
                insert.CommandText = 
                     "INSERT INTO ROTAS_CAMPO (COD_NUM_ROTAS, OPERACAO_CAMPO, DESENHO_CAMPO, N_PDF_CAMPO, OP_ROTA, " +
                     "POSICAO_FILA_CAMPO, QTDE_ROTA)" +
                     "VALUES ('*','Produção','" + DateTime.Now.ToShortDateString().Replace("/", "") + "','" + cod_produto + "','" + cod_op.ToString() + "','"  +
                     posicao.ToString() + "','" + qtde.Replace(".","").Replace(",",".") + "') returning COD_ROTA_CAMPO";
                fbConnection1.Open();
                datRotas_campo.InsertCommand = insert;
                object cod_rota_campo = datRotas_campo.InsertCommand.ExecuteScalar();
                fbConnection1.Close();

                FbCommand update = new FbCommand();
                update.Connection = fbConnection1;
                update.CommandText = 
                "UPDATE ROTAS_CAMPO SET RETRABALHO_ROTA = COD_ROTA_CAMPO, COD_ROTA_PECA = COD_NUM_ROTAS||COD_ROTA_CAMPO||COD_NUM_ROTAS WHERE COD_ROTA_CAMPO = '" + cod_rota_campo.ToString() + "'";
                fbConnection1.Open();
                datRotas_campo.UpdateCommand = update;
                datRotas_campo.UpdateCommand.ExecuteNonQuery();
                fbConnection1.Close();

                _cod_op = cod_op.ToString();

            }
            catch(Exception ex)
            {
                fbConnection1.Close();
                MessageBox.Show(ex.Message);
            }
        }
        DataTable dtItens_pedido;

        private void form_criar_ops_Load(object sender, EventArgs e)
        {
            selecionar_itens();
        }

        private void selecionar_itens()
        {
            try
            {
                
                
                dtItens_pedido = new DataTable();
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                         @"select  iped.cod_prod_item_venda as Cod_Produto, 
                    iped.descricao_prod_item_venda as Item, iped.DESCRICAO_ITEM_PROD_ITEM_VENDA as Ferramenta, iped.DATA_ENTREGA_ITEM_VENDA as Data_Entrega, " + 
    //                                                                                                                                                           (case
    //WHEN ( prod.ESTOQUE_DISPONIVEL_PRODUTO >= 0) then 0
    //When (prod.ESTOQUE_DISPONIVEL_PRODUTO < 0) then prod.ESTOQUE_DISPONIVEL_PRODUTO * -1 end) 
    @"iped.qtde_item_venda 
as Qtde_a_Fabricar, 
                    prod.ESTOQUE_RESERVADO_PRODUTO as Necessidade, prod.ESTOQUE_RESERVA_FECHADA_PRODUTO as Empenhado, prod.ESTOQUE_ENCOMENDADO_PRODUTO as Producao, 
                    prod.ESTOQUE_SEPARADO_PRODUTO as Separado, 
                    prod.ESTOQUE_DISPONIVEL_PRODUTO as Saldo, prod.estoque_atual_produto as Estoque_Atual,  pv.CLIENTE_PED_VENDA as Cliente,
                    iped.COD_ITEM_VENDA,  pv.N_PED_VENDA as Pedido,  pv.COD_PED_VENDA as Cod_interno,
                    iped.PEDIDO_CLIENTE_ITEM_VENDA as Pedido_Cliente,  iped.ITEM_PED_CLIENTE_ITEM_VENDA as Item_Ped_Cliente,  
                    iped.COD_SISTEMA_PROD_ITEM_VENDA as Cod_Sistema_Produto,
                    iped.UNIDADE_PROD_ITEM_VENDA as Un, 
                     iped.qtde_item_venda as Qtde
                    from itens_pedido_venda iped 
                    inner join pedidos_venda pv on iped.COD_PEDIDO_ITEM_VENDA = pv.COD_PED_VENDA 
                    inner join produtos prod on iped.COD_PROD_ITEM_VENDA = prod.COD_FORNECEDOR_PRODUTO 
                    where  iped.CONFIRMADO_ITEM_VENDA = 1 AND iped.OP_INTERNA_ITEM_VENDA IS NULL and (pv.STATUS_PED_VENDA != 'Faturado' and (iped.FINALIZADO_ITEM_VENDA is null or  iped.FINALIZADO_ITEM_VENDA = 0))                                                                     
                    ORDER BY iped.cod_prod_item_venda, iped.DATA_ENTREGA_ITEM_VENDA ";
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtItens_pedido);
                fbConnection1.Close();

                //dgvProdutos.AutoGenerateColumns = false;
                dgvProdutos.DataSource = dtItens_pedido;

                dgvProdutos.Columns["Pedido"].Width = 40; dgvProdutos.Columns["Pedido"].ReadOnly = true;
                dgvProdutos.Columns["Cod_interno"].Width = 40; dgvProdutos.Columns["Cod_interno"].Visible = false; dgvProdutos.Columns["Cod_interno"].ReadOnly = true;
                dgvProdutos.Columns["Cliente"].Width = 160; dgvProdutos.Columns["Cliente"].ReadOnly = true;
                dgvProdutos.Columns["Pedido_Cliente"].Width = 60; dgvProdutos.Columns["Pedido_Cliente"].ReadOnly = true;
                dgvProdutos.Columns["Item_Ped_Cliente"].Width = 30; dgvProdutos.Columns["Item_Ped_Cliente"].ReadOnly = true;
                dgvProdutos.Columns["Cod_Produto"].Width = 100; dgvProdutos.Columns["Cod_Produto"].ReadOnly = true;
                dgvProdutos.Columns["Cod_Sistema_Produto"].Width = 50; dgvProdutos.Columns["Cod_Sistema_Produto"].Visible = false; dgvProdutos.Columns["Cod_Sistema_Produto"].ReadOnly = true;
                dgvProdutos.Columns["Item"].Width = 180; dgvProdutos.Columns["Item"].ReadOnly = true;
                dgvProdutos.Columns["Ferramenta"].Width = 180; dgvProdutos.Columns["Ferramenta"].ReadOnly = true;
                dgvProdutos.Columns["Un"].Width = 30; dgvProdutos.Columns["Un"].ReadOnly = true;
                dgvProdutos.Columns["Qtde"].Width = 50; dgvProdutos.Columns["Qtde"].ReadOnly = true;
                dgvProdutos.Columns["Estoque_Atual"].Width = 50; dgvProdutos.Columns["Estoque_Atual"].ReadOnly = true;
                dgvProdutos.Columns["Necessidade"].Width = 50; dgvProdutos.Columns["Necessidade"].ReadOnly = true;
                dgvProdutos.Columns["Empenhado"].Width = 50; dgvProdutos.Columns["Empenhado"].ReadOnly = true;
                dgvProdutos.Columns["Producao"].Width = 50; dgvProdutos.Columns["Producao"].ReadOnly = true;
                dgvProdutos.Columns["Separado"].Width = 50; dgvProdutos.Columns["Separado"].ReadOnly = true;
                dgvProdutos.Columns["Saldo"].Width = 50; dgvProdutos.Columns["Saldo"].ReadOnly = true;
                dgvProdutos.Columns["Qtde_a_Fabricar"].Width = 50; dgvProdutos.Columns["Qtde_a_Fabricar"].DefaultCellStyle.BackColor = Color.GreenYellow;
                dgvProdutos.Columns["Data_Entrega"].Width = 90; dgvProdutos.Columns["Data_Entrega"].ReadOnly = true;
                dgvProdutos.Columns["COD_ITEM_VENDA"].Visible = false;




            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            selecionar_ops(tb_os.Text);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            salvar();
            for (int i = 0; i < dgvOp.SelectedRows.Count; i++)
            {
                Thread.Sleep(1000);
                imprimir_op(dgvOp.SelectedRows[i].Cells["col_cod_op"].Value.ToString(),
                    dgvOp.SelectedRows[i].Cells["col_cod_produto"].Value.ToString());

            }

            selecionar_ops(tb_os.Text);

        }

        private void salvar()
        {
            try
            {
                this.BindingContext[dsOp, "OP"].EndCurrentEdit();
                fbConnection1.Open();
                if (dsOp.HasChanges())
                {
                    datOp.UpdateCommand = cbOp.GetUpdateCommand();
                    datOp.InsertCommand = cbOp.GetInsertCommand();
                    datOp.DeleteCommand = cbOp.GetDeleteCommand();
                    datOp.Update(dsOp, "OP");
                    dsOp.AcceptChanges();
                }
                fbConnection1.Close();
            }
            catch(Exception ex)
            {
                fbConnection1.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void imprimir_op(string cod_op, string cod_produto)
        {

            try
            {


                dsConsulta imprime_op = new dsConsulta();

                //datTabela_impressao.Fill(dsRelatorio.TABELA_IMPRESSAO);
                try
                {
                    FbCommand select = new FbCommand();
                    select.Connection = fbConnection1;
                    fbConnection1.Open();
                    select.CommandText =
                            "SELECT * FROM ROTAS_CAMPO WHERE OP_ROTA = '" + cod_op + "' ORDER BY POSICAO_FILA_CAMPO";
                    FbDataAdapter datSelect = new FbDataAdapter();
                    datSelect.SelectCommand = select;
                    DataTable dtSelect = new DataTable();
                    datSelect.Fill(imprime_op.ROTAS_CAMPO);
                    fbConnection1.Close();

                }
                catch (Exception a)
                {
                    fbConnection1.Close();
                }

                double qtde_fab = 0;
                try
                {
                    FbCommand select = new FbCommand();
                    select.Connection = fbConnection1;
                    fbConnection1.Open();
                    select.CommandText =
                            "SELECT * FROM OP WHERE COD_OP = '" + cod_op + "'";
                    FbDataAdapter datSelect = new FbDataAdapter();
                    datSelect.SelectCommand = select;
                    DataTable dtSelect = new DataTable();
                    datSelect.Fill(imprime_op.OP);
                    fbConnection1.Close();
                    foreach (DataRow dr in imprime_op.OP.Rows)
                    {
                        try
                        {
                            qtde_fab = Convert.ToDouble(dr["QDE_FAB"].ToString());
                        }
                        catch { }
                    }

                }
                catch (Exception a)
                {
                    fbConnection1.Close();
                }

                string _cod_produto = buscar_cod_produto(cod_produto);
                try
                {
                    FbCommand select = new FbCommand();
                    select.Connection = fbConnection1;
                    fbConnection1.Open();
                    select.CommandText =
                            "SELECT * FROM ITENS_PRODUTO inner join produtos on COD_PRODUTO_IP = cod_produto WHERE COD_FORNECEDOR_PRODUTO = '" + cod_produto + "'";
                    FbDataAdapter datSelect = new FbDataAdapter();
                    datSelect.SelectCommand = select;
                    DataTable dtSelect = new DataTable();
                    datSelect.Fill(imprime_op.ITENS_PRODUTO);
                    fbConnection1.Close();
                    foreach (DataRow dr in imprime_op.ITENS_PRODUTO.Rows)
                    {
                        _cod_produto = dr["COD_PRODUTO"].ToString();
                    }

                }
                catch (Exception a)
                {
                    fbConnection1.Close();
                }

                try
                {
                    FbCommand select = new FbCommand();
                    select.Connection = fbConnection1;
                    fbConnection1.Open();
                    select.CommandText =
                             @"SELECT pk.*, p.COD_FORNECEDOR_PRODUTO as COD_FORN, (pk.QTDE_PK * " + qtde_fab.ToString().Replace(".", "").Replace(",", ".") + 
                             @") AS QDE_COMPONENTE FROM PRODUTOS_KIT pk 
                            INNER JOIN produtos p on pk.COD_PRODUTO_PK = p.cod_produto WHERE pk.COD_KIT_PK = '" + _cod_produto + "'";
                    FbDataAdapter datSelect = new FbDataAdapter();
                    datSelect.SelectCommand = select;
                    DataTable dtSelect = new DataTable();
                    datSelect.Fill(imprime_op.PRODUTOS_KIT);
                    fbConnection1.Close();

                }
                catch (Exception a)
                {
                    fbConnection1.Close();
                }
               



                //datOperadores.Fill(dsRelatorio.OPERADORES);
                //datParadas.Fill(dsRelatorio.PARADAS);
                // fbConnection1.Close();

                cr_nova_op_dale op_nova = new cr_nova_op_dale();
                op_nova.SetDataSource(imprime_op);
                op_nova.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4;
                op_nova.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto;
                form_imprimir imprimir = new form_imprimir(op_nova);
                
                //imprimir.imprimir_direto = true;
                imprimir.op = true;
                try
                {
                    Thread.Sleep(1000);
                    imprimir.ShowDialog();
                }
                finally
                {

                    try
                    {
                        FbCommand update = new FbCommand();
                        update.Connection = fbConnection1;
                        update.CommandText = "UPDATE OP SET IMPRESSO_OP = 1 WHERE COD_OP = '" + cod_op + "'";
                        fbConnection1.Open();
                        FbDataAdapter datUpdate = new FbDataAdapter();
                        datUpdate.UpdateCommand = update;
                        datUpdate.UpdateCommand.ExecuteNonQuery();
                        fbConnection1.Close();
                    }
                    catch (Exception ex)
                    {
                        fbConnection1.Close();

                    }

                    if (cbDesenhos_Juntos.Checked)
                    {
                        try
                        {
                            FbCommand select = new FbCommand();
                            select.Connection = fbConnection1;
                            fbConnection1.Open();
                            select.CommandText =
                                    "SELECT LINK_DES_PRODUTO FROM DESENHOS_PRODUTO INNER JOIN PRODUTOS ON COD_PROD_DES_PRODUTO = COD_PRODUTO WHERE COD_FORNECEDOR_PRODUTO = '" + cod_produto + "'";
                            FbDataAdapter datSelect = new FbDataAdapter();
                            datSelect.SelectCommand = select;
                            DataTable dtSelect = new DataTable();
                            datSelect.Fill(dtSelect);
                            fbConnection1.Close();
                            foreach (DataRow dr in dtSelect.Rows)
                            {

                                try
                                {
                                    Process p = new Process();
                                    p.StartInfo = new ProcessStartInfo()
                                    {
                                        CreateNoWindow = true,
                                        Verb = "print",
                                        FileName = dr[0].ToString() //put the correct path here
                                    };
                                    p.Start();
                                }
                                catch
                                {
                                    fbConnection1.Close();
                                    MessageBox.Show("É necessário instalar o Acrobat Reader para imprimir diretamente e o arquivo tem que estar disponivel");
                                    Process.Start(dr[0].ToString());
                                }
                            }
                        }
                        catch
                        {
                            fbConnection1.Close();
                        }
                    }
                    else
                    {}
                    //finally
                    //{
                    //    try
                    //    {
                    //        FbCommand update = new FbCommand();
                    //        update.Connection = fbConnection1;
                    //        update.CommandText = "UPDATE OP SET IMPRESSO_OP = 1 WHERE COD_OP = '" + cod_op + "'";
                    //        fbConnection1.Open();
                    //        FbDataAdapter datUpdate = new FbDataAdapter();
                    //        datUpdate.UpdateCommand = update;
                    //        datUpdate.UpdateCommand.ExecuteNonQuery();
                    //        fbConnection1.Close();
                    //    }
                    //    catch (Exception ex)
                    //    {
                    //        fbConnection1.Close();

                    //    }
                    //}

                   
                }



            }
            catch (Exception ex)
            {
                fbConnection1.Close();

                MessageBox.Show(ex.Message);
            }
        }

        private string buscar_cod_produto(string cod_produto)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                        "SELECT * FROM PRODUTOS WHERE COD_FORNECEDOR_PRODUTO = '" + cod_produto + "'";
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    return dr["COD_PRODUTO"].ToString();
                }
                return "";
            }
            catch (Exception ex)
            {
                fbConnection1.Close();
                MessageBox.Show(ex.Message);
                return "";
            }
        }

        private void dgvOp_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dgvOp.SelectedRows.Count > 0)
            {
                if (DialogResult.Yes == MessageBox.Show("O registro será excluído permanentemente, tem certeza?",
                  "Confirma a exclusão?", MessageBoxButtons.YesNo))
                {
                    form_usuario usuario = new form_usuario();

                    try
                    {
                        usuario.ShowDialog();
                    }
                    finally
                    {
                        if (usuario.confirmado == true)
                        {
                            if (usuario._cod_usuario == "1" || usuario._cod_usuario == "3" || usuario._cod_usuario == "4")
                            {
                                try
                                {
                                    for (int i = 0; i < dgvOp.SelectedRows.Count; i++)
                                    {
                                        if (dgvOp.SelectedRows[i].Cells["col_status"].Value.ToString() == "Finalizado")
                                        {
                                            MessageBox.Show("A OP: " + dgvOp.SelectedRows[i].Cells["col_cod_op"].Value.ToString() + " não pode ser excluída pois está Finalizada");
                                        }
                                        else
                                        {
                                            FbCommand delete = new FbCommand();
                                            fbConnection1.Open();
                                            delete.CommandText =
                                                "DELETE FROM OP WHERE COD_OP = '" + dgvOp.SelectedRows[i].Cells["col_cod_op"].Value.ToString() + "'";
                                            delete.Connection = fbConnection1;
                                            FbDataAdapter datDelete = new FbDataAdapter();
                                            datDelete.DeleteCommand = delete;
                                            datDelete.DeleteCommand.ExecuteNonQuery();
                                            fbConnection1.Close();

                                            FbCommand update = new FbCommand();
                                            update.Connection = fbConnection1;
                                            update.CommandText = "UPDATE ITENS_PEDIDO_VENDA SET OP_INTERNA_ITEM_VENDA = null WHERE (OP_INTERNA_ITEM_VENDA = " + dgvOp.SelectedRows[i].Cells["col_cod_op"].Value.ToString() +
                                                " or OP_INTERNA_ITEM_VENDA = -" + dgvOp.SelectedRows[i].Cells["col_cod_op"].Value.ToString() + ")";
                                            fbConnection1.Open();
                                            FbDataAdapter datUpdate = new FbDataAdapter();
                                            datUpdate.UpdateCommand = update;
                                            datUpdate.UpdateCommand.ExecuteNonQuery();
                                            fbConnection1.Close();

                                            classeEstoque estoque = new classeEstoque();
                                            estoque.fbConnection1.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=10.3.3.4;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
                                            estoque.calcular_estoque(dgvOp.SelectedRows[i].Cells["col_cod_produto"].Value.ToString());
                                        }
                                    }
                                    selecionar_ops(tb_os.Text);
                                    selecionar_itens();
                                }
                                catch (Exception ex)
                                {
                                    fbConnection1.Close();
                                    MessageBox.Show(ex.Message);
                                }

                            }
                            else
                            {
                                MessageBox.Show("Usuário não autorizado");
                            }

                        }
                    }
                    
                   
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma ou mais linhas");
            }
        }

        private void tb_cod_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void tb_descricao_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dtItens_pedido.DefaultView.RowFilter = " Item like '*" + tb_descricao.Text + "*'";

            }
            catch
            {
                dtItens_pedido.DefaultView.RowFilter = " 0=0 ";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dgvOp.SelectedRows.Count > 0)
            {
                if (DialogResult.Yes == MessageBox.Show("O registro será finalizado permanentemente, tem certeza?",
                  "Confirma a finalização?", MessageBoxButtons.YesNo))
                {
                    try
                    {
                        for (int i = 0; i < dgvOp.SelectedRows.Count; i++)
                        {
                            //FbCommand delete = new FbCommand();
                            //fbConnection1.Open();
                            //delete.CommandText =
                            //    "DELETE FROM OP WHERE COD_OP = '" + dgvOp.SelectedRows[i].Cells["col_op"].Value.ToString() + "'";
                            //delete.Connection = fbConnection1;
                            //FbDataAdapter datDelete = new FbDataAdapter();
                            //datDelete.DeleteCommand = delete;
                            //datDelete.DeleteCommand.ExecuteNonQuery();
                            //fbConnection1.Close();
                            try
                            {
                                FbCommand update = new FbCommand();
                                update.CommandText =
                                    "UPDATE OP SET FINALIZADO_OP = '1', ENTREGOU_DIA = '" + DateTime.Now.ToShortDateString().Replace("/",".") + "', POSICAO_ATUAL_OP = 'Finalizado' " + 
                                    "where COD_OP = '" + dgvOp.SelectedRows[i].Cells["col_cod_op"].Value.ToString() + "'";
                                update.Connection = fbConnection1;
                                fbConnection1.Open();
                                
                                FbDataAdapter datUpdate = new FbDataAdapter();
                                datUpdate.UpdateCommand = update;
                                datUpdate.UpdateCommand.ExecuteNonQuery();
                                fbConnection1.Close();

                                classeEstoque estoque = new classeEstoque();
                                estoque.fbConnection1.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=10.3.3.4;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
                                estoque.calcular_estoque(dgvOp.SelectedRows[i].Cells["col_cod_produto"].Value.ToString());
                            }
                            catch (Exception ex)
                            {
                                fbConnection1.Close();
                                MessageBox.Show(ex.Message);
                            }

                           


                        }
                        selecionar_ops(tb_os.Text);
                    }
                    catch (Exception ex)
                    {
                        fbConnection1.Close();
                        MessageBox.Show(ex.Message);
                    }
                    //Atualizar();
                    //this.Close();

                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma ou mais linhas");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            salvar();
            recalcular_estoques();
            selecionar_itens();
            selecionar_ops(tb_os.Text);
            MessageBox.Show("Salvo");
        }

        private void recalcular_estoques()
        {
            for (int i = 0; i < dgvOp.RowCount; i++)
            {

                classeEstoque estoque = new classeEstoque();
                estoque.fbConnection1.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=10.3.3.4;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
                estoque.calcular_estoque(dgvOp.Rows[i].Cells["col_cod_produto"].Value.ToString());
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string faturado_01 = "";
            string nao_finalizada = "";
            string finalizada = "";
            string cliente = "";
            string campo = "";
           

            if (data_saidaradioButton.Checked)
            {
               
                    campo = " AND op.ENTREGOU_DIA >= '" + Convert.ToDateTime(dtInicio.Text).ToShortDateString().Replace("/", ".") + //"" + 
                        "' AND op.ENTREGOU_DIA <= '" + Convert.ToDateTime(dtTermino.Text).ToShortDateString().Replace("/", ".") + "'";
               
            }
           
                if (data_entradaradioButton.Checked)
                {
                    campo = " AND op.DATA_PDF >= '" + Convert.ToDateTime(dtInicio.Text).ToShortDateString().Replace("/", ".") + //"" + 
                    "' AND op.DATA_PDF <= '" + Convert.ToDateTime(dtTermino.Text).ToShortDateString().Replace("/", ".") + "'";
                }


                if (rbTodas.Checked)
                {
                    campo = " AND op.DATA_PDF >= '" + Convert.ToDateTime(dtInicio.Text).ToShortDateString().Replace("/", ".") + //"" + 
                    "' AND op.DATA_PDF <= '" + Convert.ToDateTime(dtTermino.Text).ToShortDateString().Replace("/", ".") + "'";
                }


                if (cb_finalizadas.Checked == true)
                    finalizada = " AND op.POSICAO_ATUAL_OP LIKE '%FINALIZAD%' ";
                if (naoentreguesCheckbox.Checked)
                    nao_finalizada = " AND (op.POSICAO_ATUAL_OP NOT LIKE '%FINALIZAD%' or op.POSICAO_ATUAL_OP is null or op.POSICAO_ATUAL_OP = '') ";

            string pedido = "";
            if (tb_pedido_pesquisa.Text != "")
                pedido = " AND op.PEDIDO_INTERNO_OP = '" + tb_pedido_pesquisa.Text + "'";


            dsOp.Clear();
            this.datOp.SelectCommand.CommandText =
                    "SELECT op.*, prod.* FROM OP op " + 
                    "inner join produtos prod on op.COND_PGTO = prod.COD_FORNECEDOR_PRODUTO and prod.STATUS_PRODUTO = 1 " + 
                    "WHERE op.COD_OP IS NOT NULL " +
                campo + finalizada + nao_finalizada + cliente + faturado_01 + pedido + " ORDER BY op.cod_op DESC ";
            this.fbConnection1.Open();
            this.datOp.SelectCommand.Connection = fbConnection1;
            //this.datOp.SelectCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
            datOp.Fill(OP);
        }

        private void tb_cod_cliente_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dtItens_pedido.DefaultView.RowFilter = " Cod_Produto = '" + tb_cod_cliente.Text + "'";

            }
            catch
            {
                dtItens_pedido.DefaultView.RowFilter = " 0=0 ";
            }
        }

        private void tb_pedido_pesquisa_TextChanged(object sender, EventArgs e)
        {
            if (tb_pedido_pesquisa.Text.Trim() != "")
            {
                try
                {
                    dsOp.Tables["OP"].DefaultView.RowFilter = "PEDIDO_INTERNO_OP = '" + tb_pedido_pesquisa.Text.Trim() + "' ";
                }
                catch { }
            }
            else
            {
                dsOp.Tables["OP"].DefaultView.RowFilter = "COD_OP IS NOT NULL";
            }//PEDIDO_INTERNO_OP
        }

        private void tb_pedido_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dtItens_pedido.DefaultView.RowFilter = " Cod_interno = '" + tb_pedido.Text + "'";

            }
            catch
            {
                dtItens_pedido.DefaultView.RowFilter = " 0=0 ";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int posicao = 1;
            if (tb_op_suficiente.Text == "")
                MessageBox.Show("Marque a OP que é suficiente para esse item");
            else
            {
                for (int i = 0; i < dgvProdutos.RowCount; i++)
                {
                    if (Convert.ToBoolean(dgvProdutos.Rows[i].Cells["col_selecionado"].Value))
                    {
                        try
                        {
                            /*
                dgvProdutos.Columns["Pedido"].Width = 40;
                dgvProdutos.Columns["Cod_interno"].Width = 40;
                dgvProdutos.Columns["Cliente"].Width = 160;
                dgvProdutos.Columns["Cod_Produto"].Width = 100;
                dgvProdutos.Columns["Descricao"].Width = 180;
                dgvProdutos.Columns["Un"].Width = 30;
                dgvProdutos.Columns["Qtde"].Width = 50;
                dgvProdutos.Columns["Estoque_Atual"].Width = 50;
                dgvProdutos.Columns["Necessidade"].Width = 50;
                dgvProdutos.Columns["Empenhado"].Width = 50;
                dgvProdutos.Columns["Producao"].Width = 50;
                dgvProdutos.Columns["Saldo"].Width = 50;
                dgvProdutos.Columns["Qtde_a_Fabricar"].Width = 50;
                dgvProdutos.Columns["Cod_Sistema_Produto"].Width = 100;
                dgvProdutos.Columns["Data_Entrega"].Width = 90;*/

                            FbCommand update = new FbCommand();
                            update.Connection = fbConnection1;
                            update.CommandText = "UPDATE ITENS_PEDIDO_VENDA SET OP_INTERNA_ITEM_VENDA = '-" + tb_op_suficiente.Text + "' WHERE COD_ITEM_VENDA = " + dgvProdutos.Rows[i].Cells["COD_ITEM_VENDA"].Value.ToString();
                            fbConnection1.Open();
                            FbDataAdapter datUpdate = new FbDataAdapter();
                            datUpdate.UpdateCommand = update;
                            datUpdate.UpdateCommand.ExecuteNonQuery();
                            fbConnection1.Close();

                            classeEstoque estoque = new classeEstoque();
                            estoque.fbConnection1.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=10.3.3.4;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
                            estoque.calcular_estoque(dgvProdutos.Rows[i].Cells["Cod_Produto"].Value.ToString());

                        }
                        catch { fbConnection1.Close(); }
                    }
                }
                selecionar_ops(tb_os.Text);
                selecionar_itens();
            }
        }

        private void tb_op_TextChanged(object sender, EventArgs e)
       {
            if (tb_op.Text.Trim() != "")
            {
                try
                {
                    dsOp.Tables["OP"].DefaultView.RowFilter = "COD_OP = '" + tb_op.Text.Trim() + "' OR OP_MAE = '" + tb_op.Text.Trim() + "' ";
                }
                catch { }
            }
            else
            {
                dsOp.Tables["OP"].DefaultView.RowFilter = "COD_OP IS NOT NULL";
            }
            
        }

        private void tb_produto_TextChanged(object sender, EventArgs e)
        {
            if (tb_produto.Text.Trim() != "")
            {
                try
                {
                    dsOp.Tables["OP"].DefaultView.RowFilter = "COND_PGTO = '" + tb_produto.Text.Trim() + "' ";
                }
                catch { }
            }
            else
            {
                dsOp.Tables["OP"].DefaultView.RowFilter = "COD_OP IS NOT NULL";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //URGENTE_OP
            try
            {
                for (int i = 0; i < dgvOp.SelectedRows.Count; i++)
                {
                    FbCommand update = new FbCommand();
                    update.Connection = fbConnection1;
                    update.CommandText = "UPDATE OP SET URGENTE_OP = 1 WHERE COD_OP = '" + dgvOp.SelectedRows[i].Cells["col_cod_op"].Value.ToString() + "'";
                    fbConnection1.Open();
                    FbDataAdapter datUpdate = new FbDataAdapter();
                    datUpdate.UpdateCommand = update;
                    datUpdate.UpdateCommand.ExecuteNonQuery();
                    fbConnection1.Close();
                }
            }
            catch (Exception ex)
            {
                fbConnection1.Close();

            }
            selecionar_ops(tb_os.Text);
        }

        private void cbUrgente_filtro_CheckedChanged(object sender, EventArgs e)
        {
            if (cbUrgente_filtro.Checked)
            {
                try
                {
                    dsOp.Tables["OP"].DefaultView.RowFilter = " URGENTE_OP = '1' ";
                }
                catch { }
            }
            else
            {
                try
                {
                    dsOp.Tables["OP"].DefaultView.RowFilter = " URGENTE_OP IS NULL OR URGENTE_OP = 0 ";
                }
                catch { }
            }
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //URGENTE_OP
            try
            {
                for (int i = 0; i < dgvOp.SelectedRows.Count; i++)
                {
                    FbCommand update = new FbCommand();
                    update.Connection = fbConnection1;
                    update.CommandText = "UPDATE OP SET URGENTE_OP = null WHERE COD_OP = '" + dgvOp.SelectedRows[i].Cells["col_cod_op"].Value.ToString() + "'";
                    fbConnection1.Open();
                    FbDataAdapter datUpdate = new FbDataAdapter();
                    datUpdate.UpdateCommand = update;
                    datUpdate.UpdateCommand.ExecuteNonQuery();
                    fbConnection1.Close();
                }
            }
            catch (Exception ex)
            {
                fbConnection1.Close();

            }
            selecionar_ops(tb_os.Text);
        }

        private void btn_imprimir_desenho_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < dgvOp.SelectedRows.Count; i++)
            {
                Thread.Sleep(1000);
                imprimir_desenhos(dgvOp.SelectedRows[i].Cells["col_cod_op"].Value.ToString(),
                    dgvOp.SelectedRows[i].Cells["col_cod_produto"].Value.ToString());

            }

            
        }

        private void imprimir_desenhos(string cod_op, string cod_produto)
        {

            string _cod_produto = buscar_cod_produto(cod_produto);
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                        "SELECT * FROM ITENS_PRODUTO inner join produtos on COD_PRODUTO_IP = cod_produto WHERE COD_FORNECEDOR_PRODUTO = '" + cod_produto + "'";
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    _cod_produto = dr["COD_PRODUTO"].ToString();
                }

            }
            catch (Exception a)
            {
                fbConnection1.Close();
            }

            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                        "SELECT LINK_DES_PRODUTO FROM DESENHOS_PRODUTO INNER JOIN PRODUTOS ON COD_PROD_DES_PRODUTO = COD_PRODUTO WHERE COD_FORNECEDOR_PRODUTO = '" + cod_produto + "'";
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {

                    try
                    {
                        Process p = new Process();
                        p.StartInfo = new ProcessStartInfo()
                        {
                            CreateNoWindow = true,
                            Verb = "print",
                            FileName = dr[0].ToString() //put the correct path here
                        };
                        p.Start();
                    }
                    catch
                    {
                        fbConnection1.Close();
                        MessageBox.Show("É necessário instalar o Acrobat Reader para imprimir diretamente e o arquivo tem que estar disponivel");
                        Process.Start(dr[0].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                fbConnection1.Close();
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void tb_os_filtro_TextChanged(object sender, EventArgs e)
        {
            if (tb_os_filtro.Text.Trim() != "")
            {
                try
                {
                    dsOp.Tables["OP"].DefaultView.RowFilter = "DESENHO_OP_ATUAL = '" + tb_os_filtro.Text.Trim() + "' ";
                }
                catch { }
            }
            else
            {
                dsOp.Tables["OP"].DefaultView.RowFilter = "DESENHO_OP_ATUAL IS NOT NULL";
            }
        }

        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i <= dgvProdutos.Rows.Count; i++)
                {
                    dgvProdutos.Rows[i].Cells["col_selecionado"].Value = 1;
                }
            }
            catch (Exception erro)
            {
                //MessageBox.Show(erro.ToString());
            }
        }

        private void dgvOp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            form_op op = new form_op();
            op.cod_op_atual_variavel = dgvOp.Rows[e.RowIndex].Cells["col_cod_op"].Value.ToString();
            op.codOsSistema = dgvOp.Rows[e.RowIndex].Cells["col_os"].Value.ToString();
            try
            {
                op.Show();
            }
            finally
            {

            }
        }

        private void tb_os_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
