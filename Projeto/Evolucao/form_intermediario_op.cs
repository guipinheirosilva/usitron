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
    public partial class form_intermediario_op : Form
    {
        public DataTable dtIntermediario;
       // public string dtInicial;
        public form_intermediario_op()
        {
            InitializeComponent();
        }

        private void form_intermediario_op_Load(object sender, EventArgs e)
        {
            dgvProdutos.DataSource = dtIntermediario;

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

        public void inserir_op(string cod_produto, string descricao, string ferramenta, int posicao, string qtde, 
            string cod_pedido, string data_entrega_pedido, string op_mae, string cliente, out string _cod_op)
        {
            string tipo = "";
            double horas = 0;
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
            string funcao = buscar_funcao(cod_produto);
            try
            {
                

                if (op_mae == "")
                    op_mae = "null";
                string urgente = "null";
                if (cbUrgente.Checked)
                    urgente = "1";
                FbCommand insert = new FbCommand();
                insert.Connection = fbConnection1;
                insert.CommandText =
                       "INSERT INTO OP (FERRAMENTA_OP, DESCRICAO_FERRAMENTA_OP, COND_PGTO, DATA_PDF, " + 
                        "N_PDF, QDE_FAB, QDE_PDF, PEDIDO_INTERNO_OP, POSICAO_ATUAL_OP, ENTREGA_DIA, OP_MAE, URGENTE_OP, PEDIDO_OP, FUNCAO_OP, DATA_ENTRADA_OP)" +
                       "VALUES ('" + ferramenta + "', '" + descricao + "', '" + cod_produto + "','" + DateTime.Now.ToShortDateString().Replace("/", ".") + "'," +
                       "'" + posicao + "','" +
                       qtde.Replace(".", "").Replace(",", ".") + "', '" + qtde.Replace(".", "").Replace(",", ".") + "', "+ 
                       cod_pedido + ",'Aguardando Material'," + data_entrega_pedido + ", " + op_mae + "," + urgente +", " + cod_pedido + ",'" + funcao + "','" + 
                       DateTime.Now.ToShortDateString().Replace("/",".") + "') returning COD_OP";
                fbConnection1.Open();
                FbDataAdapter datOp = new FbDataAdapter();
                datOp.InsertCommand = insert;
                object cod_op = datOp.InsertCommand.ExecuteScalar();
                fbConnection1.Close();

                FbCommand update1 = new FbCommand();
                update1.Connection = fbConnection1;
                update1.CommandText =
                "UPDATE OP SET DESENHO_OP_ATUAL = '" +  cod_pedido + "' WHERE COD_OP = '" + cod_op.ToString() + "'";
                fbConnection1.Open();
                FbDataAdapter datUpdate1 = new FbDataAdapter();
                datUpdate1.UpdateCommand = update1;
                datUpdate1.UpdateCommand.ExecuteNonQuery();
                fbConnection1.Close();

                //FbCommand select = new FbCommand();
                //select.CommandText =
                //       "INSERT INTO DESENHOS (N_OS_PECA, CLIENTE)" +
                //       "VALUES ('" + cod_pedido +"','" + cliente + "')";
                //select.Connection = fbConnection1;
                //fbConnection1.Open();
                //FbDataAdapter datSelect = new FbDataAdapter();
                //datSelect.InsertCommand = select;
                //datSelect.InsertCommand.ExecuteNonQuery();
                //fbConnection1.Close();

                //FbCommand select = new FbCommand();
                //select.CommandText = "select * from tipos_operacoes";
                //select.Connection = fbConnection1;
                //fbConnection1.Open();
                //FbDataAdapter datSelect = new FbDataAdapter();
                //datSelect.SelectCommand = select;
                //DataTable dtSelect = new DataTable();
                //datSelect.Fill(dtSelect);
                //fbConnection1.Close();
                posicao = 1;
                for (int i = 0; i <= 22; i++ ) //22 pois são 22 operações no orçamento
                {

                    verificar_tipo_op(i, descricao, cod_pedido, out tipo, out horas);
                //foreach (DataRow dr in dtSelect.Rows)
                //{

                    
                    

                    if (tipo != "")
                    {

                        //Convert.ToInt32(posicao.ToString());
                        FbDataAdapter datRotas_campo = new FbDataAdapter();
                        FbCommand insert1 = new FbCommand();
                        insert1.Connection = fbConnection1;
                        insert1.CommandText =
                             "INSERT INTO ROTAS_CAMPO (COD_NUM_ROTAS, OPERACAO_CAMPO, DESENHO_CAMPO, N_PDF_CAMPO, OP_ROTA, " +
                             "POSICAO_FILA_CAMPO, QTDE_ROTA, PREVISAO_PRODUCAO)" +
                             "VALUES ('*','" + tipo + "','" + cod_pedido + "','" + cod_produto + "','" + cod_op.ToString() + "','" +
                             posicao.ToString() + "','" + qtde.Replace(".", "").Replace(",", ".") + "', '" + horas.ToString().Replace(".", "").Replace(",", ".") + "') returning COD_ROTA_CAMPO";
                        fbConnection1.Open();
                        datRotas_campo.InsertCommand = insert1;
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
                        posicao++;
                        //}
                    }

                    _cod_op = cod_op.ToString();
                    
                }
            }
            catch (Exception ex)
            {
                fbConnection1.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private string buscar_funcao(string cod_produto)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.CommandText = "select descricao_grupo_produto from produtos where COD_FORNECEDOR_PRODUTO = '" + cod_produto + "'";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    return dr[0].ToString();
                }
                return "";
            }
            catch
            {
                fbConnection1.Close();
                return "";
            }
        }

        private void verificar_tipo_op(int qtde, string descricao, string cod_pedido, out string tipo, out double horas)
        {
            
            tipo = "";
            horas = 0;
            double qtde_orcamento = 0;

            
                try
                {
                    FbCommand selectItens_Orc = new FbCommand();
                    selectItens_Orc.CommandText = "SELECT  o.horas_oper1_item_orc, o.horas_oper2_item_orc, o.horas_oper3_item_orc, " +
                    "o.horas_oper4_item_orc, o.horas_oper5_item_orc, o.horas_oper6_item_orc, o.horas_oper7_item_orc, o.horas_oper8_item_orc, " +
                    "o.horas_oper9_item_orc, o.horas_oper10_item_orc, o.horas_oper11_item_orc, o.horas_oper12_item_orc, o.horas_oper13_item_orc, " +
                    "o.horas_oper14_item_orc, o.horas_oper15_item_orc, o.horas_oper16_item_orc, o.horas_oper17_item_orc, " +
                    "o.horas_oper18_item_orc, o.horas_oper19_item_orc, o.horas_oper20_item_orc, o.horas_oper21_item_orc, o.horas_oper22_item_orc, o.QTDE_ITEM_ORC FROM ITENS_ORCAMENTO o " +
                    "inner join pedidos_venda pv on pv.COD_ORCAMENTO_PED_VENDA = o.COD_ORCAMENTO_ITEM_ORC " +
                    "where pv.cod_ped_venda = '" + cod_pedido + "'" +
                    " and o.nome_item_orc = '" + descricao + "'";
                    selectItens_Orc.Connection = fbConnection1;
                    fbConnection1.Open();
                    FbDataAdapter datSelect_Itens_Orc = new FbDataAdapter();
                    datSelect_Itens_Orc.SelectCommand = selectItens_Orc;
                    DataTable dtSelect_Itens_Orc = new DataTable();
                    datSelect_Itens_Orc.Fill(dtSelect_Itens_Orc);
                    fbConnection1.Close();
                    foreach (DataRow dr in dtSelect_Itens_Orc.Rows)
                    {
                        horas = Convert.ToDouble(dr[qtde].ToString());
                        qtde_orcamento = Convert.ToDouble(dr[22].ToString());
                        horas = horas * qtde_orcamento;
                    }
                }
                catch
                {
                    fbConnection1.Close();
                }
            
            if (horas != 0)
            {
                qtde++;

                try
                {
                    FbCommand select = new FbCommand();
                    select.CommandText = "select tipo from tipos_operacoes where ordem_operacao_tipo = " + qtde;
                    select.Connection = fbConnection1;
                    fbConnection1.Open();
                    FbDataAdapter datSelect = new FbDataAdapter();
                    datSelect.SelectCommand = select;
                    DataTable dtSelect = new DataTable();
                    datSelect.Fill(dtSelect);
                    fbConnection1.Close();
                    foreach (DataRow dr in dtSelect.Rows)
                    {
                        tipo = dr[0].ToString();
                    }
                }
                catch
                {
                    fbConnection1.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dgvProdutos.Sort(dgvProdutos.Columns["col_mae"], ListSortDirection.Ascending);
            int posicao = 1;
            DataTable maes = new DataTable();
            DataColumn cod_mae = new DataColumn();
            cod_mae.ColumnName = "cod_mae";
            DataColumn _op_mae = new DataColumn();
            _op_mae.ColumnName = "op_mae";
            maes.Columns.Add(cod_mae);
            maes.Columns.Add(_op_mae);

            for (int i = 0; i < dgvProdutos.RowCount; i++)
            {
                verificar_se_os_existe(dgvProdutos.Rows[i].Cells["Pedido"].Value.ToString(), dgvProdutos.Rows[i].Cells["Cliente"].Value.ToString());
                if (Convert.ToBoolean(dgvProdutos.Rows[i].Cells["col_selecionado"].Value) && dgvProdutos.Rows[i].Cells["col_mae"].Value.ToString() == "") //primeiro faço as mães
                {
                    try
                    {
                        string op_mae = "";
                        if (dgvProdutos.Rows[i].Cells["col_mae"].Value.ToString() != "")
                        {
                            foreach (DataRow dr in maes.Select("cod_mae = '" + dgvProdutos.Rows[i].Cells["col_mae"].Value.ToString() + "'"))
                            {
                                op_mae = dr["op_mae"].ToString();
                            }
                            

                        }

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
                                double porc = (((nova_op / saldo) * -1 - 1) * 100);
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
                    
                        if (ok)
                        {
                            string _cod_op = "";

                            inserir_op(dgvProdutos.Rows[i].Cells["Cod_Produto"].Value.ToString(),
                                dgvProdutos.Rows[i].Cells["Item"].Value.ToString(), dgvProdutos.Rows[i].Cells["Ferramenta"].Value.ToString(),
                                Convert.ToInt32(posicao.ToString()), dgvProdutos.Rows[i].Cells["Qtde_a_Fabricar"].Value.ToString(),
                                dgvProdutos.Rows[i].Cells["Pedido"].Value.ToString(), 
                                dgvProdutos.Rows[i].Cells["Data_Entrega"].Value.ToString(), op_mae, 
                                dgvProdutos.Rows[i].Cells["Cliente"].Value.ToString(), 
                                out _cod_op);

                            if (dgvProdutos.Rows[i].Cells["col_mae"].Value.ToString() == "")
                                maes.Rows.Add(dgvProdutos.Rows[i].Cells["Cod_Produto"].Value.ToString(), _cod_op);

                            if (dgvProdutos.Rows[i].Cells["COD_ITEM_VENDA"].Value.ToString() != "")
                            {
                                try
                                {
                                    FbCommand update = new FbCommand();
                                    update.Connection = fbConnection1;
                                    update.CommandText = "UPDATE ITENS_PEDIDO_VENDA SET OP_INTERNA_ITEM_VENDA = '" + _cod_op + "' WHERE COD_ITEM_VENDA = " + dgvProdutos.Rows[i].Cells["COD_ITEM_VENDA"].Value.ToString();
                                    fbConnection1.Open();
                                    FbDataAdapter datUpdate = new FbDataAdapter();
                                    datUpdate.UpdateCommand = update;
                                    datUpdate.UpdateCommand.ExecuteNonQuery();
                                    fbConnection1.Close();
                                }
                                catch { fbConnection1.Close(); }
                            }
                            classeEstoque estoque = new classeEstoque();
                            estoque.fbConnection1.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
                            estoque.calcular_estoque(dgvProdutos.Rows[i].Cells["Cod_Produto"].Value.ToString());
                            
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

            for (int i = 0; i < dgvProdutos.RowCount; i++)
            {

                if (Convert.ToBoolean(dgvProdutos.Rows[i].Cells["col_selecionado"].Value) && dgvProdutos.Rows[i].Cells["col_mae"].Value.ToString() != "") //depois faço os filhos
                {
                    try
                    {
                        string op_mae = "";
                        if (dgvProdutos.Rows[i].Cells["col_mae"].Value.ToString() != "")
                        {
                            foreach (DataRow dr in maes.Select("cod_mae = '" + dgvProdutos.Rows[i].Cells["col_mae"].Value.ToString() + "'"))
                            {
                                op_mae = dr["op_mae"].ToString();
                            }


                        }

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
                                double porc = (((nova_op / saldo) * -1 - 1) * 100);
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

                        if (ok)
                        {
                            string _cod_op = "";

                            inserir_op(dgvProdutos.Rows[i].Cells["Cod_Produto"].Value.ToString(),
                                dgvProdutos.Rows[i].Cells["Item"].Value.ToString(), dgvProdutos.Rows[i].Cells["Ferramenta"].Value.ToString(),
                                Convert.ToInt32(posicao.ToString()), dgvProdutos.Rows[i].Cells["Qtde_a_Fabricar"].Value.ToString(),
                                dgvProdutos.Rows[i].Cells["Pedido"].Value.ToString(), dgvProdutos.Rows[i].Cells["Data_Entrega"].Value.ToString(), 
                                dgvProdutos.Rows[i].Cells["Cliente"].Value.ToString(),
                                op_mae, out _cod_op);

                            if (dgvProdutos.Rows[i].Cells["col_mae"].Value.ToString() == "")
                                maes.Rows.Add(dgvProdutos.Rows[i].Cells["Cod_Produto"].Value.ToString(), _cod_op);

                            if (dgvProdutos.Rows[i].Cells["COD_ITEM_VENDA"].Value.ToString() != "")
                            {
                                try
                                {
                                    FbCommand update = new FbCommand();
                                    update.Connection = fbConnection1;
                                    update.CommandText = "UPDATE ITENS_PEDIDO_VENDA SET OP_INTERNA_ITEM_VENDA = '" + _cod_op + "' WHERE COD_ITEM_VENDA = " + dgvProdutos.Rows[i].Cells["COD_ITEM_VENDA"].Value.ToString();
                                    fbConnection1.Open();
                                    FbDataAdapter datUpdate = new FbDataAdapter();
                                    datUpdate.UpdateCommand = update;
                                    datUpdate.UpdateCommand.ExecuteNonQuery();
                                    fbConnection1.Close();
                                }
                                catch { fbConnection1.Close(); }
                            }
                            classeEstoque estoque = new classeEstoque();
                            estoque.fbConnection1.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
                            estoque.calcular_estoque(dgvProdutos.Rows[i].Cells["Cod_Produto"].Value.ToString());

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
            this.Close();
        }

        private void verificar_se_os_existe(string pedido, string cliente)
        {
            bool nao_existe = true;
            try
            {
                FbCommand select = new FbCommand();
                select.CommandText = "SELECT * FROM DESENHOS WHERE N_OS_PECA = '" + pedido + "'";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    nao_existe = false;
                }

                if (nao_existe)
                {
                    try
                    {
                        FbDataAdapter datDesenhos = new FbDataAdapter();
                        FbCommand insert1 = new FbCommand();
                        insert1.Connection = fbConnection1;
                        insert1.CommandText =
                            //"INSERT INTO DESENHOS (N_OS_PECA, CLIENTE)" +
                            //       "VALUES ('" + cod_pedido +"','" + cliente + "')";
                             "INSERT INTO DESENHOS (N_OS_PECA, CLIENTE)" +
                             "VALUES ('" + pedido + "','" + cliente + "') RETURNING COD_PECA";
                        fbConnection1.Open();
                        datDesenhos.InsertCommand = insert1;
                        object _cod_peca = datDesenhos.InsertCommand.ExecuteScalar();
                        fbConnection1.Close();
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.ToString());
                        fbConnection1.Close();
                    }
                }
                    
            }
            catch { }
        }

        private void tb_pedido_TextChanged(object sender, EventArgs e)
        {
            try
            {

                dtIntermediario.DefaultView.RowFilter = " Pedido = '" + tb_pedido.Text + "'";

            }
            catch
            {
                dtIntermediario.DefaultView.RowFilter = " 0=0 ";
            }
        }

        private void tb_cod_cliente_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dtIntermediario.DefaultView.RowFilter = " Cod_Produto = '" + tb_cod_cliente.Text + "'";

            }
            catch
            {
                dtIntermediario.DefaultView.RowFilter = " 0=0 ";
            }
        }

        private void tb_descricao_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dtIntermediario.DefaultView.RowFilter = " Item like '*" + tb_descricao.Text + "*'";

            }
            catch
            {
                dtIntermediario.DefaultView.RowFilter = " 0=0 ";
            }
        }

        private void button2_Click(object sender, EventArgs e)
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
    }
}
