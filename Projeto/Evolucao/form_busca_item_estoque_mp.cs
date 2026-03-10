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
    public partial class form_busca_item_estoque_mp : Form
    {
        public string usuario;
        public string cod_escolhido;
        public string item_escolhido;
        public string descricao_escolhido;
        public bool busca;
        string _cod, _grupo, _material, _classificacao, _acabamento, _espessura, _dimensao, _comprimento, _cliente, _tipo;
        int qtde_itens_filtrados;
        public string tipo_escolhido;
        public string pedido_escolhido;
        public string cnpj_empresa;
        public form_busca_item_estoque_mp(string cnpj_empresa)
        {
            this.cnpj_empresa = cnpj_empresa;
            InitializeComponent();
        }

        private void filtrar()
        {
            try
            {
                dsEstoque.Tables["ESTOQUE"].DefaultView.RowFilter = "COD_ESTOQUE IS NOT NULL " + _grupo + _material + 
                    _classificacao + _acabamento + _espessura + _dimensao + _cliente + _tipo + _comprimento;
            }
            catch { }
        }

        private void buscar_qtde_itens_filtrados()
        {
            qtde_itens_filtrados = 0;
            if (cbTipo.Text != "")
                qtde_itens_filtrados++;
            if (tb_cliente.Text != "")
                qtde_itens_filtrados++;
            if (tb_grupo.Text != "")
                qtde_itens_filtrados++;
            if (tb_material.Text != "")
                qtde_itens_filtrados++;
            if (tb_classificacao.Text != "")
                qtde_itens_filtrados++;
            if (tb_acabamento.Text != "")
                qtde_itens_filtrados++;
            if (tb_espessura.Text != "")
                qtde_itens_filtrados++;
            if (tb_dimensao.Text != "")
                qtde_itens_filtrados++;
            if (tb_comprimento.Text != "")
                qtde_itens_filtrados++;

        }

        private void tb_cod_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsEstoque.Tables["ESTOQUE"].DefaultView.RowFilter = "COD_ESTOQUE = '" + tb_cod.Text + "'";
            }
            catch { }
        }

        private void tb_item_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsEstoque.Tables["ESTOQUE"].DefaultView.RowFilter = "ITEM_ESTOQUE Like '*" + tb_item.Text + "*'";
                colocar_cores();
            }
            catch { }
        }

        private void tb_grupo_TextChanged(object sender, EventArgs e)
        {
            _grupo = "";
            if(tb_grupo.Text != "")
                _grupo = " AND GRUPO_ESTOQUE Like '*" + tb_grupo.Text + "*'";
            filtrar();
        }

        private void tb_material_TextChanged(object sender, EventArgs e)
        {
            _material = "";
            if(tb_material.Text != "")
                _material = " AND MATERIAL_ESTOQUE Like '*" + tb_material.Text + "*'";
            filtrar();
        }

        private void tb_dimensao_TextChanged(object sender, EventArgs e)
        {
            _dimensao = ""; 
            if(tb_dimensao.Text != "")
                _dimensao = " AND DIMENSAO_ESTOQUE Like '*" + tb_dimensao.Text + "*'";
            filtrar();
        }

        private void tb_espessura_TextChanged(object sender, EventArgs e)
        {
            _espessura = "";
            if(tb_espessura.Text != "")
                _espessura = " AND ESPESSURA_ESTOQUE Like '*" + tb_espessura.Text + "*'";
            filtrar();
        }

     

        private void form_busca_item_estoque_Load(object sender, EventArgs e)
        {
            try
            {
                datEstoque.Fill(ESTOQUE);
                dgvEstoque.AutoGenerateColumns = false;
                dgvEstoque.DataSource = dsEstoque.Tables["ESTOQUE"];
                //if (tipo_escolhido != "")
               //     cbTipo.Text = tipo_escolhido;
                tb_cod.Focus();
                colocar_cores();
            }
            catch
            {
                fbConnection1.Close();
            }
        }

        private void colocar_cores()
        {
            for (int i = 0; i < dgvEstoque.RowCount; i++)
            {
                double estoque_minimo = 0;
                double estoque_disponivel = 0;
                try
                {
                    estoque_minimo = Convert.ToDouble(dgvEstoque.Rows[i].Cells["col_minimo"].Value.ToString());
                    estoque_disponivel = Convert.ToDouble(dgvEstoque.Rows[i].Cells["col_armazenado"].Value.ToString());
                    if (estoque_disponivel < 0)
                        dgvEstoque.Rows[i].DefaultCellStyle.BackColor = Color.LightCoral;
                    else
                    {
                        if (estoque_minimo == estoque_disponivel)
                        {
                            dgvEstoque.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                        }
                        else
                        {
                            if (estoque_minimo > estoque_disponivel)
                            {
                                dgvEstoque.Rows[i].DefaultCellStyle.BackColor = Color.LightCoral;
                            }
                            else
                            {
                                dgvEstoque.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                            }
                        }
                    }
                }
                catch
                {

                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            cod_escolhido = "";
            this.Close();
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            form_estoque est = new form_estoque(cnpj_empresa);
            try
            {
                est.ShowDialog();
            }
            finally
            {
                dsEstoque.Clear();
                datEstoque.Fill(ESTOQUE);
            }
        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            _tipo = "";
            if (cbTipo.Text != "")
            {
                try
                {
                    _tipo = " AND TIPO_ITEM_ESTOQUE Like '%" + cbTipo.Text + "%'";
                }
                catch
                {
                    _tipo = " AND TIPO_ITEM_ESTOQUE != null";
                }
                filtrar();
            }
             * */
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double total_geral = 0;
                for (int i = 0; i < dgvEstoque.RowCount; i++)
                {
                    double saidas = buscar_saidas_periodo(dgvEstoque.Rows[i].Cells["col_cod"].Value.ToString());
                    try
                    {
                        double peso_unit = Convert.ToDouble(dgvEstoque.Rows[i].Cells["col_peso_unit"].Value.ToString());
                        double total = peso_unit * saidas;
                        //double ultima_compra = buscar_ultima_compra(dgvEstoque.Rows[i].Cells["col_cod"].Value.ToString());
                       // dgvEstoque.Rows[i].Cells["col_valor_ultima_compra"].Value = ultima_compra.ToString("n2");
                        dgvEstoque.Rows[i].Cells["col_peso_total"].Value = total.ToString("n2");
                        dgvEstoque.Rows[i].Cells["col_qtde_saidas"].Value = saidas.ToString("n2");
                        total_geral = total_geral + total;
                    }
                    catch { }
                }

            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private double buscar_ultima_compra(string cod_estoque)
        {
            FbDataAdapter datItens = new FbDataAdapter();
            FbCommand select = new FbCommand();
            try
            {
                
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT PRECO_UNIT_ITEM_ENT FROM ITENS_NOTA_ENT WHERE COD_ITEM_EST_ITEM_ENT = '" + cod_estoque + "' order by COD_ITENS_NOTA_ENT desc";
                
                datItens.SelectCommand = select;
                DataSet dsItens = new DataSet();
                datItens.Fill(dsItens);
                fbConnection1.Close();
                foreach (DataRow dr in dsItens.Tables[0].Rows)
                {
                    try
                    {
                        return Convert.ToDouble(dr[0].ToString());
                    }
                    catch { }
                }
                return 0;

            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
                return 0;
            }
        }

        private double buscar_saidas_periodo(string cod)
        {
            double retorno = 0;
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT QTDE_ESTOQUE_SAIDA FROM ESTOQUE_SAIDA WHERE COD_ITEM_ESTOQUE_SAIDA = '" + cod + "' AND (" +
                    "DATA_ESTOQUE_SAIDA >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") + "' AND " +
                    "DATA_ESTOQUE_SAIDA <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "')";
                FbDataAdapter datSaidas = new FbDataAdapter();
                datSaidas.SelectCommand = select;
                DataSet dsSaidas = new DataSet();
                datSaidas.Fill(dsSaidas);
                fbConnection1.Close();
                foreach (DataRow dr in dsSaidas.Tables[0].Rows)
                {
                    try
                    {
                        retorno = retorno + Convert.ToDouble(dr[0].ToString());
                    }
                    catch { }
                }
                return retorno;
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
                return 0;
            }
        }

        private void dgvEstoque_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (busca)
            {
                form_estoque est = new form_estoque(cnpj_empresa);
                est.cod_a_abrir = cod_escolhido = dgvEstoque.Rows[e.RowIndex].Cells["col_cod"].Value.ToString();
                est.Show();
            }
            else
            {
                try
                {
                    cod_escolhido = dgvEstoque.Rows[e.RowIndex].Cells["col_cod"].Value.ToString();
                    item_escolhido = dgvEstoque.Rows[e.RowIndex].Cells["col_item"].Value.ToString();
                    descricao_escolhido = dgvEstoque.Rows[e.RowIndex].Cells["col_descricao"].Value.ToString();
                    this.Close();
                }
                catch { }
            }
        }

        private void tb_classificacao_TextChanged(object sender, EventArgs e)
        {
            _classificacao = "";
            if(tb_classificacao.Text != "")
                _classificacao = " AND CLASSIFICACAO_ESTOQUE Like '*" + tb_classificacao.Text + "*'";
            filtrar();
        }

        private void tb_comprimento_TextChanged(object sender, EventArgs e)
        {
            _comprimento = "";
            if(tb_comprimento.Text != "")
                _comprimento = " AND COMPRIMENTO_ESTOQUE Like '*" + tb_comprimento.Text + "*'";
            filtrar();
        }

        private void tb_acabamento_TextChanged(object sender, EventArgs e)
        {
            _acabamento = "";
            if(tb_acabamento.Text != "")
                _acabamento = " AND ACABAMENTO_ESTOQUE Like '*" + tb_acabamento.Text + "*'";
            filtrar();
        }

        private void tb_cliente_TextChanged(object sender, EventArgs e)
        {
            _cliente = "";
            if (tb_cliente.Text != "")
                _cliente = " AND NOME_PROPRIETARIO_ESTOQUE like '*" + tb_cliente.Text + "*'";
            filtrar();
        }

        private void cbTipo_TextChanged(object sender, EventArgs e)
        {
            /*
            _tipo = "";
            if (cbTipo.Text != "")
            {
                try
                {
                    _tipo = " AND TIPO_ITEM_ESTOQUE Like '%" + cbTipo.Text + "%'";
                }
                catch
                {
                    _tipo = " AND TIPO_ITEM_ESTOQUE != null";
                }
                filtrar();
            }
             * */
        }

        private void dgvEstoque_CellClick(object sender, DataGridViewCellEventArgs e)
        { 
           try
            {
                if (e.RowIndex != -1)
                {
                    string cod_item = dgvEstoque.Rows[e.RowIndex].Cells["col_item"].Value.ToString();

                    //this.dsItensPedidoCompra.

                    this.dsMateriaPrima.Clear();
                    this.datMateriaPrima.SelectCommand.CommandText =
                        "SELECT I.N_PEDIDO_ITEM_PED,I.QTDE_ITEM_PED, I.VALOR_UNIT_ITEM_PED, I.VALOR_TOTAL_ITEM_PED, I.DESCRICAO_ITEM_PED," +
                        "I.ITEM_ITEM_PED,p.nome_forn_ped FROM ITENS_PEDIDO_COMPRA I " +
                        "INNER JOIN PEDIDO_COMPRA P ON I.n_pedido_item_ped = P.cod_ped WHERE P.data_emissao_ped >= '01.01.2014' AND I.ITEM_ITEM_PED = '" + cod_item + "'";


                    /*"SELECT I.N_PEDIDO_ITEM_PED,I.QTDE_ITEM_PED, I.UNID_ITEM_PED, I.VALOR_UNIT_ITEM_PED, I.VALOR_TOTAL_ITEM_PED," +
                    "I.DESCRICAO_ITEM_PED, I.DATA_ENTRADA_ITEM_PED, I.ITEM_ITEM_PED," +
                    "(SELECT NOME_FORN FROM FORNECEDORES F WHERE F.CNPJ_CPF_FORN = I.FORNECEDOR_ITEM_PED) FROM ITENS_PEDIDO_COMPRA I WHERE I.ITEM_ITEM_PED = '" + cod_item + "'";*/
                    this.fbConnection1.Open();
                    this.datMateriaPrima.SelectCommand.Connection = fbConnection1;
                    this.datMateriaPrima.SelectCommand.ExecuteNonQuery();
                    this.datMateriaPrima.Fill(MATERIA_PRIMA);
                    this.fbConnection1.Close();
                }
            }
            catch (Exception a) 
            {
                this.fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void dgvEstoque_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            pedido_escolhido = dataGridView1.Rows[e.RowIndex].Cells["col_n_pedido"].Value.ToString();

            form_pedido_compra ped = new form_pedido_compra(cnpj_empresa);
            ped.n_pedido = pedido_escolhido;
            ped.abrir_pedido = true;
            ped.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string itens = "";
            if (dgvEstoque.RowCount > 0)
            {
                itens = " est.ITEM_ESTOQUE = '" + dgvEstoque.Rows[0].Cells["col_item"].Value.ToString() + "' ";
                for (int i = 1; i < dgvEstoque.RowCount; i++)
                {
                    itens += " OR est.ITEM_ESTOQUE = '" + dgvEstoque.Rows[0].Cells["col_item"].Value.ToString() + "' ";
                }
                /*
                FbCommand select_estoque = new FbCommand();
                select_estoque.Connection = fbConnection1;
                select_estoque.CommandText =
                    "SELECT COD_ESTOQUE, ITEM_ESTOQUE, ESTOQUE_ATUAL_ESTOQUE, ESTOQUE_MINIMO_ESTOQUE FROM ESTOQUE " +
                    " WHERE 0 = 0 " + itens;
                fbConnection1.Open();
                FbDataAdapter datSelect_estoque = new FbDataAdapter();
                datSelect_estoque.SelectCommand = select_estoque;
                DataTable dtSelect_estoque = new DataTable();
                datSelect_estoque.Fill(dtSelect_estoque);
                fbConnection1.Close();
                */


                for (int i = 1; i < dgvEstoque.RowCount; i++)
                {
                    try
                    {
                        //selecionando consumido


                        string _cfop = " and (item.cfop_item like '_1__'	" +
                            "	or item.cfop_item like '_4__') ";

                        dsClientesxproduto cli = new dsClientesxproduto();
                        FbCommand select = new FbCommand();
                        select.CommandText =
                        "select prod.COD_DESENHO_PECA, prod.DESCRICAO_PECA, IM.DESCRICAO_ITENS_MP_PECA, sum(item.QDE_PDF),  " +
                            "sum(item.PRECO_UNIT * item.QDE_PDF), IM.peso_itens_mp_peca from op item " +
                            "left join PECAS prod on prod.COD_DESENHO_PECA = item.COND_PGTO " +
                            "left JOIN itens_materia_prima_peca IM ON IM.COD_PECA_ITENS_MP_PECA = prod.cod_peca " +
                            "left join ESTOQUE est on est.COD_ESTOQUE = IM.COD_PECA_ITENS_MP_PECA " +
                            "where " +
                            " item.FINALIZADO_OP = '1' AND item.CODIGO_OP = '01' " +
                            " AND item.ENTREGOU_DIA >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") +
                            "' and item.ENTREGOU_DIA <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                        " and est.ITEM_ESTOQUE = '" + dgvEstoque.Rows[0].Cells["col_item"].Value.ToString() + "' " +
                            "group by  prod.COD_DESENHO_PECA, prod.DESCRICAO_PECA, IM.DESCRICAO_ITENS_MP_PECA, IM.peso_itens_mp_peca " +
                        " union " +
                        "select prod.COD_DESENHO_PECA, prod.DESCRICAO_PECA, IM.DESCRICAO_ITENS_MP_PECA, sum(item.qtde_item), " +
                        "sum(item.PRECO_TOTAL_ITEM), IM.peso_itens_mp_peca from itens_nota item " +
                        "left join PECAS prod on prod.COD_DESENHO_PECA = item.cod_item " +
                        "left JOIN itens_materia_prima_peca IM ON IM.COD_PECA_ITENS_MP_PECA = prod.cod_peca " +
                         "left join ESTOQUE est on est.COD_ESTOQUE = IM.COD_PECA_ITENS_MP_PECA " +
                        "INNER JOIN nota_fiscal nf ON ITEM.NF_ITEM = NF.N_NF " +
                        "where " +
                        "nf.STATUS_NFE LIKE ('%Autorizada%') and nf.ENTRADA_SAIDA_NF = '1' " +
                         _cfop +
                        " AND nf.data_emissao_nf >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") +
                        "' and nf.data_emissao_nf <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                        " and est.ITEM_ESTOQUE = '" + dgvEstoque.Rows[0].Cells["col_item"].Value.ToString() + "' " +
                        "group by prod.COD_DESENHO_PECA, prod.DESCRICAO_PECA, IM.DESCRICAO_ITENS_MP_PECA, IM.peso_itens_mp_peca ";





                        select.Connection = fbConnection1;
                        fbConnection1.Open();
                        FbDataAdapter datSelect = new FbDataAdapter();
                        datSelect.SelectCommand = select;
                        DataTable dtSelect = new DataTable();
                        datSelect.Fill(dtSelect);
                        fbConnection1.Close();
                    }
                    catch
                    {
                        fbConnection1.Close();

                    }



                }
            }

        }

        private void tb_descricao_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsEstoque.Tables["ESTOQUE"].DefaultView.RowFilter = "DESCRICAO_ESTOQUE Like '*" + tb_descricao.Text + "*'";
                colocar_cores();
            }
            catch { }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Iniciando os atributos
            FbDataAdapter datEstoque1 = new FbDataAdapter();
            dsConsulta dsEstoque1 = new dsConsulta();
            FbCommand cmdEstoque = new FbCommand();
            crEstoqueSintetico relEstoqueSintetico = new crEstoqueSintetico();
            form_imprimir formImp = new form_imprimir(relEstoqueSintetico);
            string tipo = "";
           
            try
            {

                string cod1 = "", cliente1 = "", descricao1 = "", item1 = "";
                if(tb_cod.Text != "")
                    cod1 = " AND COD_ESTOQUE = '" + tb_cod.Text + "'";
                if (tb_cliente.Text != "")
                    cliente1 = " AND upper(NOME_PROPRIETARIO_ESTOQUE) like upper('%" + tb_cliente.Text + "%')";
                if(tb_descricao.Text != "")
                    descricao1 = "AND UPPER(DESCRICAO_ESTOQUE) Like UPPER('%" + tb_descricao.Text + "%')";
                if (tb_item.Text != "")
                    item1 = "AND UPPER(ITEM_ESTOQUE) Like UPPER('%" + tb_item.Text + "%')";

                //Selecionando os itens de estoque
                string query = "SELECT * " +
                    "FROM estoque where 0=0 " +cod1 + cliente1 + descricao1 + item1 + 
                    " ORDER BY cod_estoque ";
                cmdEstoque.CommandText = query.Replace("'*", "'%").Replace("*'","%'");
                datEstoque1.SelectCommand = cmdEstoque;
                datEstoque1.SelectCommand.Connection = fbConnection1;
                datEstoque1.SelectCommand.Connection.Open();
                datEstoque1.Fill(dsEstoque1.ESTOQUE);
                datEstoque1.SelectCommand.Connection.Close();

                //Exibindo o relatório
                relEstoqueSintetico.SetDataSource(dsEstoque1);
                formImp.Show();

            }
            catch (Exception a)
            {
                datEstoque.SelectCommand.Connection.Close();
                MessageBox.Show(a.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FbDataAdapter datEstoque1 = new FbDataAdapter();
            dsConsulta dsEstoque1 = new dsConsulta();
            FbCommand cmdEstoque = new FbCommand();
            crEstoqueLotes relEstoqueSintetico = new crEstoqueLotes();
            form_imprimir formImp = new form_imprimir(relEstoqueSintetico);
            string tipo = "";
            if (cbTipo.Text != "")
                tipo = " AND tipo_item_estoque = '" + cbTipo.Text + "'";
            try
            {
                //Selecionando os itens de estoque
                cmdEstoque.CommandText =
                    "SELECT est.COD_ESTOQUE, est.ITEM_ESTOQUE, est.DESCRICAO_ESTOQUE,  " +
                    "pl.LOTE_PALETE_LOTE, pl.N_PALETE_LOTE, pl.QTD_PALETE_LOTE " + 
                    "FROM estoque est " + 
                    "INNER JOIN LOTE_RECEBIMENTO lt on lt.COD_PRODUTO_LR = est.COD_ESTOQUE " + 
                    "INNER JOIN PALETE_LOTE pl on pl.lote_palete_lote = lt.COD_LR " +
                    "where 0=0 and pl.QTD_PALETE_LOTE != 0 " + tipo +
                    "ORDER BY est.cod_estoque, pl.LOTE_PALETE_LOTE, pl.N_PALETE_LOTE ";
                datEstoque1.SelectCommand = cmdEstoque;
                datEstoque1.SelectCommand.Connection = fbConnection1;
                datEstoque1.SelectCommand.Connection.Open();
                datEstoque1.SelectCommand.ExecuteNonQuery();
                DataTable dtEstoque = new DataTable();
                datEstoque1.Fill(dtEstoque);
                datEstoque1.SelectCommand.Connection.Close();

                foreach (DataRow dr in dtEstoque.Rows)
                {
                    dsEstoque1.ESTOQUE_LOTES.AddESTOQUE_LOTESRow(Convert.ToInt32(dr["COD_ESTOQUE"].ToString()),
                        dr["ITEM_ESTOQUE"].ToString(), dr["DESCRICAO_ESTOQUE"].ToString(),
                        Convert.ToInt32(dr["LOTE_PALETE_LOTE"].ToString()), Convert.ToInt32(dr["N_PALETE_LOTE"].ToString()),
                        Convert.ToDouble(dr["QTD_PALETE_LOTE"].ToString()));
                }
                
                //Exibindo o relatório
                relEstoqueSintetico.SetDataSource(dsEstoque1);
                formImp.Show();

            }
            catch (Exception a)
            {
                datEstoque.SelectCommand.Connection.Close();
                MessageBox.Show(a.Message);
            }

        }

        
    }
}