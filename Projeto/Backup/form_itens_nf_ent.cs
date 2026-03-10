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
    public partial class form_itens_nf_ent : Form
    {
        public string usuario_atual;
        public string cnpj_empresa;
        public form_itens_nf_ent(string cnpj_empresa)
        {
            this.cnpj_empresa = cnpj_empresa;
            InitializeComponent();
        }

        private void buscar_cnpj_nome_empresa(out string cnpj_cliente, out string cliente_produto)
        {
            cnpj_cliente = ""; cliente_produto = "";
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT RAZAO_SOCIAL_EMPRESA, CNPJ_EMPRESA FROM EMPRESA";
                FbDataAdapter datEmpresa = new FbDataAdapter();
                datEmpresa.SelectCommand = select;
                DataSet dsEmpresa = new DataSet();
                datEmpresa.Fill(dsEmpresa);
                fbConnection1.Close();
                foreach (DataRow dr in dsEmpresa.Tables[0].Rows)
                {
                    cnpj_cliente = dr[1].ToString();
                    cliente_produto = dr[0].ToString();
                }
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private bool buscar_cliente_requisicao(string cod_item_requisicao, out string cnpj_cliente, out string cliente_produto)
        {
            cnpj_cliente = ""; cliente_produto = "";
            string cod_req = "";
            try
            {
                if (cod_item_requisicao != "")
                {
                    FbCommand select_item_req = new FbCommand();
                    select_item_req.Connection = fbConnection1;
                    fbConnection1.Open();
                    select_item_req.CommandText =
                        "SELECT COD_REQ_ITEM_REQ FROM ITENS_REQUISICAO WHERE COD_ITEM_REQ = '" + cod_item_requisicao + "'";
                    FbDataAdapter datItem_req = new FbDataAdapter();
                    datItem_req.SelectCommand = select_item_req;
                    DataSet dsItem_req = new DataSet();
                    datItem_req.Fill(dsItem_req);
                    fbConnection1.Close();
                    
                    foreach (DataRow dr in dsItem_req.Tables[0].Rows)
                    {
                        cod_req = dr[0].ToString();
                    }
                }
                
                if (cod_req != "")
                {
                    FbCommand select_req = new FbCommand();
                    select_req.Connection = fbConnection1;
                    fbConnection1.Open();
                    select_req.CommandText =
                        "SELECT CLIENTE_REQUISICAO FROM REQUISICOES WHERE COD_REQUISICAO = '" + cod_req + "'";
                    FbDataAdapter datReq = new FbDataAdapter();
                    datReq.SelectCommand = select_req;
                    DataSet dsReq = new DataSet();
                    datReq.Fill(dsReq);
                    fbConnection1.Close();
                    foreach (DataRow dr_req in dsReq.Tables[0].Rows)
                    {
                        if (dr_req[0].ToString() != "" && dr_req[0].ToString().Contains("SCHNEIDER"))
                        {
                            cliente_produto = dr_req[0].ToString();
                            cnpj_cliente = buscar_cnpj_cliente(cliente_produto);
                            return true;
                        }
                        else
                        {
                            return false;
                        }

                    }
                }
                return false;
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
                return false;
            }
        }

        private string buscar_cnpj_cliente(string cliente_produto)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT CNPJ FROM CLIENTES WHERE RAZAO_SOCIAL = '" + cliente_produto + "'";
                FbDataAdapter datClientes = new FbDataAdapter();
                datClientes.SelectCommand = select;
                DataSet dsClientes = new DataSet();
                datClientes.Fill(dsClientes);
                fbConnection1.Close();
                foreach (DataRow dr in dsClientes.Tables[0].Rows)
                {
                    return dr[0].ToString();
                }
                return "Não encontrado";
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
                return "erro";
            }
        }

        private void buscar_dados_item_estoque(string cod, out string descricao, out string dimensoes, 
            out string tipo_material, out string nome_proprietario)
        {
            descricao = null; dimensoes = null; tipo_material = null; nome_proprietario = null;
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT ITEM_ESTOQUE, DESCRICAO_ESTOQUE, MATERIAL_ESTOQUE, DIMENSAO_ESTOQUE, NOME_PROPRIETARIO_ESTOQUE FROM ESTOQUE WHERE " +
                    " COD_ESTOQUE = '" + cod + "'";
                FbDataAdapter datEstoque = new FbDataAdapter();
                datEstoque.SelectCommand = select;
                DataSet dsEstoque = new DataSet();
                datEstoque.Fill(dsEstoque);
                fbConnection1.Close();
                foreach (DataRow dr in dsEstoque.Tables[0].Rows)
                {
                    descricao = dr[0].ToString();
                    if (dr[1].ToString() != "")
                        descricao = descricao + " " + dr[1].ToString();
                    dimensoes = dr[3].ToString();
                    tipo_material = dr[2].ToString();
                    nome_proprietario = dr[4].ToString();
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
                fbConnection1.Close();
            }
        }

        private void buscar_informacoes_produto_pedido(string nf, string cod_estoque, string cfop, string cod_item_requisicao, out string cod_produto, out string descricao_produto,
    out string dimensoes_produto, out string material_produto, out string cliente_produto, out string cnpj_cliente)
        {
            cod_produto = ""; descricao_produto = ""; dimensoes_produto = ""; material_produto = ""; cliente_produto = ""; cnpj_cliente = "";
            try
            {
                string cnpj_proprietario, nome_proprietario;
                buscar_dados_item_estoque(cod_estoque, out descricao_produto, out dimensoes_produto, out material_produto, out nome_proprietario);
                cod_produto = cod_estoque;
                if (cfop[1].ToString() == "9") //REMESSA PARA BENEFICIAMENTO
                {
                    buscar_cnpj_cliente_nf(nf, out cnpj_cliente, out cliente_produto);
                }
                if (cfop[1].ToString() == "1") //VENDAS
                {
                    if (cfop == "6122" || cfop == "5122")
                    {
                        buscar_cnpj_cliente(nome_proprietario, out cnpj_cliente, out cliente_produto);
                    }
                    else
                    {
                        if (buscar_cliente_requisicao(cod_item_requisicao, out cnpj_cliente, out cliente_produto))
                        {

                        }
                        else
                        {
                            buscar_cnpj_nome_empresa(out cnpj_cliente, out cliente_produto);
                        }
                    }
                }
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void buscar_cnpj_cliente(string nome_proprietario, out string cnpj_cliente, out string cliente_produto)
        {
            cnpj_cliente = "não achou"; cliente_produto = "não achou";
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT RAZAO_SOCIAL, CNPJ FROM CLIENTES WHERE RAZAO_SOCIAL = '" + nome_proprietario + "'";
                FbDataAdapter datClientes = new FbDataAdapter();
                datClientes.SelectCommand = select;
                DataSet dsClientes = new DataSet();
                datClientes.Fill(dsClientes);
                fbConnection1.Close();
                foreach (DataRow dr in dsClientes.Tables[0].Rows)
                {
                    cnpj_cliente = dr[1].ToString();
                    cliente_produto = dr[0].ToString();
                }
            }
            catch(Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

       

        private void buscar_cnpj_cliente_nf(string cod_sistema_nf, out string cnpj_cliente, out string cliente_produto)
        {
            cnpj_cliente = ""; cliente_produto = "";
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT CLIENTE_FORN_NF_ENT, CNPJ_CLIENTE_FORN_ENT FROM NOTA_FISCAL_ENT WHERE COD_SISTEMA_NF_ENT = '" + cod_sistema_nf + "'";
                FbDataAdapter datNota = new FbDataAdapter();
                datNota.SelectCommand = select;
                DataSet dsNota = new DataSet();
                datNota.Fill(dsNota);
                fbConnection1.Close();
                foreach (DataRow dr in dsNota.Tables[0].Rows)
                {
                    cliente_produto = dr[0].ToString();
                    cnpj_cliente = dr[1].ToString();
                }
            }
            catch(Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void dgvItens_nota_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvItens_nota.Columns[e.ColumnIndex].Name == "col_buscar_item_est")
            {
                form_busca_item_estoque_mp est = new form_busca_item_estoque_mp(cnpj_empresa);
                try
                {
                    est.ShowDialog();
                }
                finally
                {
                    if (est.cod_escolhido != "")
                    {
                        dgvItens_nota.Rows[e.RowIndex].Cells["col_cod_item_est"].Value = est.cod_escolhido;
                    }
                    else
                        dgvItens_nota.Rows[e.RowIndex].Cells["col_cod_item_est"].Value = "";
                }
            }
            if (dgvItens_nota.Columns[e.ColumnIndex].Name == "col_novo_lote")
            {
                form_lote_novo lote = new form_lote_novo();
                try
                {
                    if (dgvItens_nota.Rows[e.RowIndex].Cells["col_lote"].Value.ToString() != "")
                    {
                        
                            lote.cod_lote = dgvItens_nota.Rows[e.RowIndex].Cells["col_lote"].Value.ToString();
                            lote.usuario_atual = usuario_atual;
                            lote.ShowDialog();
                    }
                    else
                    {

                        string cod_produto, descricao_produto, dimensoes_produto, material_produto, cliente_produto,
                            cnpj_cliente_produto;
                        buscar_informacoes_produto_pedido(dgvItens_nota.Rows[e.RowIndex].Cells["col_cod_nf_sistema"].Value.ToString(),
                            dgvItens_nota.Rows[e.RowIndex].Cells["col_cod_item_est"].Value.ToString(),
                            dgvItens_nota.Rows[e.RowIndex].Cells["col_cfo"].Value.ToString(),
                            dgvItens_nota.Rows[e.RowIndex].Cells["col_cod_item_req"].Value.ToString(),
                            out cod_produto, out descricao_produto, out dimensoes_produto, out material_produto, out cliente_produto,
                            out cnpj_cliente_produto);

                        lote.cod_item_nf_ent = dgvItens_nota.Rows[e.RowIndex].Cells["col_cod_item_nota_ent"].Value.ToString();
                        lote.cod_mp = cod_produto;
                        lote.descricao_mp = descricao_produto;
                        lote.dimensoes = dimensoes_produto;
                        lote.material = material_produto;
                        lote.nome_cliente = cliente_produto;
                        lote.cnpj_cliente = cnpj_cliente_produto;
                        lote.usuario_atual = usuario_atual;
                        lote.nota_fiscal = dgvItens_nota.Rows[e.RowIndex].Cells["col_nf"].Value.ToString();

                        lote.ShowDialog();
                    }
                }
                finally
                {
                    if (lote.excluir)
                    {
                        dgvItens_nota.Rows[e.RowIndex].Cells["col_lote"].Value = "";


                        update_itens_nf_ent(dgvItens_nota.Rows[e.RowIndex].Cells["col_cod_item_nota_ent"].Value.ToString(),
                            "", "", "", "");

                        dgvItens_nota.Rows[e.RowIndex].Cells["col_qtde_lote"].Value = "0";
                        dgvItens_nota.Rows[e.RowIndex].Cells["col_cnpj_cliente"].Value = "";
                        dgvItens_nota.Rows[e.RowIndex].Cells["col_cliente"].Value = "";

                        atualizar();

                        classeEstoque_material est = new classeEstoque_material();
                        est.fbConnection1.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=\evolucao\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
                        est.calcular_estoque(dgvItens_nota.Rows[e.RowIndex].Cells["col_cod_item_est"].Value.ToString());
                    }

                    else
                    {
                        dgvItens_nota.Rows[e.RowIndex].Cells["col_lote"].Value = lote.cod_lote;
                        string cod_produto_lote, descricao_produto_lote, dimensoes_produto_lote, material_produto_lote, cliente_produto_lote,
                                cnpj_cliente_produto_lote, qtde_produto_lote, data_liberacao_lote, nota_fiscal_lote, rastreameto_lote;

                        buscar_informacoes_lote(dgvItens_nota.Rows[e.RowIndex].Cells["col_lote"].Value.ToString(),
                            out cod_produto_lote, out descricao_produto_lote, out dimensoes_produto_lote, out material_produto_lote,
                            out cliente_produto_lote, out cnpj_cliente_produto_lote, out qtde_produto_lote, out data_liberacao_lote,
                            out nota_fiscal_lote, out rastreameto_lote);

                        update_itens_nf_ent(dgvItens_nota.Rows[e.RowIndex].Cells["col_cod_item_nota_ent"].Value.ToString(),
                            lote.cod_lote, qtde_produto_lote, cnpj_cliente_produto_lote, cliente_produto_lote);

                        dgvItens_nota.Rows[e.RowIndex].Cells["col_qtde_lote"].Value = qtde_produto_lote;
                        dgvItens_nota.Rows[e.RowIndex].Cells["col_cnpj_cliente"].Value = cnpj_cliente_produto_lote;
                        dgvItens_nota.Rows[e.RowIndex].Cells["col_cliente"].Value = cliente_produto_lote;

                        atualizar();

                        update_item_estoque(dgvItens_nota.Rows[e.RowIndex].Cells["col_cod_item_est"].Value.ToString(),
                            dgvItens_nota.Rows[e.RowIndex].Cells["col_preco_total"].Value.ToString(),
                            dgvItens_nota.Rows[e.RowIndex].Cells["col_qtde"].Value.ToString(),
                            dgvItens_nota.Rows[e.RowIndex].Cells["col_qtde_lote"].Value.ToString(),
                            dgvItens_nota.Rows[e.RowIndex].Cells["col_ncm"].Value.ToString());

                        classeEstoque_material est = new classeEstoque_material();
                        est.fbConnection1.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=\evolucao\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
                        est.calcular_estoque(dgvItens_nota.Rows[e.RowIndex].Cells["col_cod_item_est"].Value.ToString());

                    }
                }
            
            }
        }

        private void update_itens_nf_ent(string cod_itens_nota, string lote, string qtde_produto_lote, string cnpj_cliente_produto_lote, string cliente_produto_lote)
        {
            try
            {
                if (lote == "")
                    lote = "null";
                else
                    lote = "'" + lote + "'";

                if (qtde_produto_lote == "")
                    qtde_produto_lote = "null";
                else
                    qtde_produto_lote = "'" + qtde_produto_lote.Replace(".", "").Replace(",", ".") + "'";

                if (cliente_produto_lote == "")
                    cliente_produto_lote = "null";
                else
                    cliente_produto_lote = "'" + cliente_produto_lote + "'";

                if (cnpj_cliente_produto_lote == "")
                    cnpj_cliente_produto_lote = "null";
                else
                    cnpj_cliente_produto_lote = "'" + cnpj_cliente_produto_lote + "'";
                string baixado = "1";
                if (qtde_produto_lote == "null")
                {
                    baixado = "0";
                }

                FbCommand update = new FbCommand();
                update.Connection = fbConnection1;
                fbConnection1.Open();
                update.CommandText =
                    "UPDATE ITENS_NOTA_ENT SET LOTE_ITEM_ENT = " + lote + ", QTDE_LOTE_ITEM_ENT = " + qtde_produto_lote + ", " +
                    "NOME_PROPRIETARIO_ITEM_ENT = " + cliente_produto_lote + ", BAIXADO_ITEM_ENT = '" + baixado + "', CNPJ_PROPRIETARIO_ITEM = " + cnpj_cliente_produto_lote + " " +
                    "WHERE COD_ITENS_NOTA_ENT = '" + cod_itens_nota + "'";
                FbDataAdapter datItens = new FbDataAdapter();
                datItens.UpdateCommand = update;
                datItens.UpdateCommand.ExecuteNonQuery();
                fbConnection1.Close();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void update_item_estoque(string cod, string valor_total, string qtde, string qtde_lote, string ncm)
        {
            if (qtde_lote != "")
            {
                try
                {
                    double valor_unit = 0, peso_unit = 0;
                    try
                    {
                        valor_unit = Convert.ToDouble(valor_total) / Convert.ToDouble(qtde_lote);
                    }
                    catch { }
                    try
                    {
                        peso_unit = Convert.ToDouble(qtde) / Convert.ToDouble(qtde_lote);
                    }
                    catch { }

                    FbCommand update = new FbCommand();
                    update.Connection = fbConnection1;
                    fbConnection1.Open();
                    update.CommandText =
                         "UPDATE ESTOQUE SET NCM_ESTOQUE = '" + ncm + "' WHERE COD_ESTOQUE = '" + cod + "'";
                      //  "UPDATE ESTOQUE SET NCM_ESTOQUE = '" + ncm + "', VALOR_UNIT_ESTOQUE = '" + valor_unit.ToString().Replace(".", "").Replace(",", ".") + "', " +
                      //  "PESO_UNIT_ESTOQUE = '" + peso_unit.ToString().Replace(".", "").Replace(",", ".") + "' WHERE COD_ESTOQUE = '" + cod + "'";
                    FbDataAdapter datEstoque = new FbDataAdapter();
                    datEstoque.UpdateCommand = update;
                    datEstoque.UpdateCommand.ExecuteNonQuery();
                    fbConnection1.Close();

                }
                catch (Exception a)
                {
                    fbConnection1.Close();
                    MessageBox.Show(a.ToString());
                }

            }
        }


        private void buscar_informacoes_lote(string cod_lote, out string cod_produto_lote, out string descricao_produto_lote,
    out string dimensoes_produto_lote, out string material_produto_lote, out string cliente_produto_lote,
    out string cnpj_cliente_produto_lote, out string qtde_produto_lote, out string data_liberacao_lote,
    out string nota_fiscal_lote, out string rastreameto_lote)
        {
            cod_produto_lote = ""; descricao_produto_lote = ""; dimensoes_produto_lote = ""; material_produto_lote = "";
            cliente_produto_lote = ""; cnpj_cliente_produto_lote = ""; qtde_produto_lote = ""; data_liberacao_lote = "";
            nota_fiscal_lote = ""; rastreameto_lote = "";

            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT * FROM LOTE_RECEBIMENTO WHERE COD_LR = '" + cod_lote + "'";
                FbDataAdapter datLr = new FbDataAdapter();
                datLr.SelectCommand = select;
                DataSet dsLr = new DataSet();
                datLr.Fill(dsLr);
                fbConnection1.Close();
                foreach (DataRow dr in dsLr.Tables[0].Rows)
                {
                    cod_produto_lote = dr["COD_PRODUTO_LR"].ToString();
                    descricao_produto_lote = dr["DESCRICAO_LR"].ToString();
                    dimensoes_produto_lote = dr["DIMENSOES_LR"].ToString();
                    material_produto_lote = dr["MATERIAL_LR"].ToString();
                    cliente_produto_lote = dr["CLIENTE_LR"].ToString();
                    cnpj_cliente_produto_lote = dr["CNPJ_CLIENTE_LR"].ToString();
                    rastreameto_lote = dr["RASTREAMENTO_LR"].ToString();
                    qtde_produto_lote = dr["QTDE_LR"].ToString();
                    try
                    {
                        data_liberacao_lote = Convert.ToDateTime(dr["DATA_LIBERACAO_LR"].ToString()).ToShortDateString();
                    }
                    catch { }
                    nota_fiscal_lote = dr["NOTA_FISCAL_LR"].ToString();
                }

            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }

        }

        private void form_itens_nf_ent_Load(object sender, EventArgs e)
        {
            try
            {
                datItens_nota_ent.SelectCommand.CommandText =
                    "SELECT ITENS_NOTA_ENT.*, NOTA_FISCAL_ENT.CLIENTE_FORN_NF_ENT, NOTA_FISCAL_ENT.CNPJ_CLIENTE_FORN_ENT FROM ITENS_NOTA_ENT " +
                    " JOIN NOTA_FISCAL_ENT ON ITENS_NOTA_ENT.COD_SISTEMA_NF_ITEM_ENT = NOTA_FISCAL_ENT.COD_SISTEMA_NF_ENT " + 
                    " where itens_nota_ent.cod_item_est_item_ent is not null " +
                    "ORDER BY COD_ITENS_NOTA_ENT DESC";
                datItens_nota_ent.SelectCommand.Connection = fbConnection1;
                fbConnection1.Open();
                datItens_nota_ent.SelectCommand.ExecuteNonQuery();
                datItens_nota_ent.Fill(ITENS_NOTA_ENT);
                fbConnection1.Close();

                dgvItens_nota.AutoGenerateColumns = false;
                dgvItens_nota.DataSource = dsItens_nota_ent.Tables["ITENS_NOTA_ENT"];
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void atualizar()
        {
            try
            {
                this.BindingContext[dsItens_nota_ent, "ITENS_NOTA_ENT"].EndCurrentEdit();
                if (dsItens_nota_ent.HasChanges())
                {
                    fbConnection1.Open();
                    datItens_nota_ent.UpdateCommand = cbItens_nota_ent.GetUpdateCommand();
                    datItens_nota_ent.InsertCommand = cbItens_nota_ent.GetInsertCommand();
                    datItens_nota_ent.DeleteCommand = cbItens_nota_ent.GetDeleteCommand();
                    datItens_nota_ent.Update(dsItens_nota_ent, "ITENS_NOTA_ENT");
                    dsItens_nota_ent.AcceptChanges();
                    fbConnection1.Close();
                }
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                //MessageBox.Show(a.ToString());
            }
        }

        private void tb_codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                try
                {
                    if (tb_codigo.Text[0].ToString() == "#")
                    {
                        selecionar_lote(tb_codigo.Text);
                    }
                }
                catch
                {

                }
            }
        }

        private void selecionar_lote(string cod)
        {
            string lote = "";
            
            try
            {
                int i = 1;
                while (cod[i].ToString() != "#")
                {
                    i++;
                }
                i++;
                while (cod[i].ToString() != "#")
                {
                    i++;
                }
                i++;
                while (cod[i].ToString() != "#")
                {
                    lote = lote + cod[i];
                    i++;
                }
                i++;
                while (i < cod.Length)
                {
                    i++;
                }
                dsItens_nota_ent.Clear();
                datItens_nota_ent.SelectCommand.CommandText =
                    "SELECT ITENS_NOTA_ENT.*, NOTA_FISCAL_ENT.CLIENTE_FORN_NF_ENT, NOTA_FISCAL_ENT.CNPJ_CLIENTE_FORN_ENT FROM ITENS_NOTA_ENT " +
                    " JOIN NOTA_FISCAL_ENT ON ITENS_NOTA_ENT.COD_SISTEMA_NF_ITEM_ENT = NOTA_FISCAL_ENT.COD_SISTEMA_NF_ENT " +  
                    "WHERE LOTE_ITEM_ENT = '" + lote + "'";
                datItens_nota_ent.SelectCommand.Connection = fbConnection1;
                fbConnection1.Open();
                datItens_nota_ent.SelectCommand.ExecuteNonQuery();
                datItens_nota_ent.Fill(ITENS_NOTA_ENT);
                fbConnection1.Close();
                tb_localidade.Focus();

            }
            catch(Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void update_item_req(string n_item_ped)
        {
            try
            {
                string _cod_req = null;
                FbCommand comando_select = new FbCommand();
                comando_select.Connection = fbConnection1;
                comando_select.CommandText = "SELECT * FROM ITENS_PEDIDO_COMPRA WHERE COD_ITEM_PED = '" + n_item_ped + "'";
                DataSet ped = new DataSet();
                fbConnection1.Open();
                FbDataAdapter datItens_ped = new FbDataAdapter();
                datItens_ped.SelectCommand = comando_select;
                datItens_ped.Fill(ped);
                fbConnection1.Close();
                foreach (DataRow dr in ped.Tables[0].Rows)
                {
                    _cod_req = dr["COD_ITEM_REQ_ITEM_PED"].ToString();
                }

                if (_cod_req != "")
                {
                    //FbDataAdapter datItens_req = new FbDataAdapter();
                    datItens_req.UpdateCommand.Connection = fbConnection1;
                    datItens_req.UpdateCommand.CommandText =
                    "UPDATE ITENS_REQUISICAO SET SITUACAO_ATUAL_ITEM_REQ = 'ITEM CHEGOU NO DIA " + dgvItens_nota.Rows[0].Cells["col_data"].
                Value.ToString() + " NF: " + dgvItens_nota.Rows[0].Cells["col_nf"].
                Value.ToString() + "' WHERE COD_ITEM_REQ = '" + _cod_req + "'";
                    fbConnection1.Open();
                    datItens_req.UpdateCommand.Connection = fbConnection1;
                    datItens_req.UpdateCommand.ExecuteNonQuery();
                    fbConnection1.Close();
                }
            }
            catch
            {
                MessageBox.Show("Erro na inserção do status no Item da Requisição");
                fbConnection1.Close();
            }
        }

        private void update_item_ped(string n_item_ped)
        {
            try
            {
                //FbDataAdapter datItens_ped = new FbDataAdapter();
                datItens_ped.UpdateCommand.Connection = fbConnection1;
                datItens_ped.UpdateCommand.CommandText =
                "UPDATE ITENS_PEDIDO_COMPRA SET CHEGOU_ITEM_PED = '1' WHERE COD_ITEM_PED = '" + n_item_ped + "'";
                fbConnection1.Open();
                datItens_ped.UpdateCommand.Connection = fbConnection1;
                datItens_ped.UpdateCommand.ExecuteNonQuery();
                fbConnection1.Close();

                datItens_ped.UpdateCommand.CommandText =
                "UPDATE ITENS_PEDIDO_COMPRA SET COD_NF_ENTRADA_ITEM_PED = '" + dgvItens_nota.Rows[0].Cells["col_nf"].Value.ToString() + 
                "' WHERE COD_ITEM_PED = '" + n_item_ped + "'";
                fbConnection1.Open();
                datItens_ped.UpdateCommand.Connection = fbConnection1;
                datItens_ped.UpdateCommand.ExecuteNonQuery();
                fbConnection1.Close();

                datItens_ped.UpdateCommand.CommandText =
                "UPDATE ITENS_PEDIDO_COMPRA SET DATA_CHEGADA_ITEM_PED = '" + Convert.ToDateTime(dgvItens_nota.Rows[0].Cells["col_data"].
                Value.ToString()).ToShortDateString().Replace("/", ".") + "' WHERE COD_ITEM_PED = '" + n_item_ped + "'";
                fbConnection1.Open();
                datItens_ped.UpdateCommand.Connection = fbConnection1;
                datItens_ped.UpdateCommand.ExecuteNonQuery();
                fbConnection1.Close();
            }
            catch
            {
                MessageBox.Show("Erro na Inserção de informação nos Itens do Pedido de Compra");
                fbConnection1.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvItens_nota.RowCount != 1)
                    MessageBox.Show("Erro ao procurar o lote");
                else
                {
                    if (dgvItens_nota.Rows[0].Cells["col_cod_item_ped"].Value.ToString().Trim() != "")
                    {
                        update_item_ped(dgvItens_nota.Rows[0].Cells["col_cod_item_ped"].Value.ToString());
                        update_item_req(dgvItens_nota.Rows[0].Cells["col_cod_item_ped"].Value.ToString());
                    }

                    FbCommand update = new FbCommand();
                    update.Connection = fbConnection1;
                    fbConnection1.Open();
                    update.CommandText =
                        "UPDATE ITENS_NOTA_ENT SET BAIXADO_ITEM_ENT = '1' WHERE COD_ITENS_NOTA_ENT = '" + dgvItens_nota.Rows[0].Cells["col_cod_item_nota_ent"].Value.ToString() + "'";
                    FbDataAdapter itens_nota_entDataAdapter = new FbDataAdapter();
                    itens_nota_entDataAdapter.UpdateCommand = update;
                    itens_nota_entDataAdapter.UpdateCommand.ExecuteNonQuery();
                    fbConnection1.Close();

                    FbCommand update_lote = new FbCommand();
                    update_lote.Connection = fbConnection1;
                    fbConnection1.Open();
                    update_lote.CommandText =
                        "UPDATE LOTE_RECEBIMENTO SET LOCALIDADE_LR = '" + tb_localidade.Text + "' WHERE COD_LR = '" + dgvItens_nota.Rows[0].Cells["col_lote"].Value.ToString() + "'";
                    FbDataAdapter loteDataAdapter = new FbDataAdapter();
                    loteDataAdapter.UpdateCommand = update_lote;
                    loteDataAdapter.UpdateCommand.ExecuteNonQuery();
                    fbConnection1.Close();

                    //UPDATE ESTOQUE
                    update_local_estoque(dgvItens_nota.Rows[0].Cells["col_cod_item_est"].Value.ToString());

                    classeEstoque_material est = new classeEstoque_material();
                    est.fbConnection1.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=\evolucao\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
                    est.calcular_estoque(dgvItens_nota.Rows[0].Cells["col_cod_item_est"].Value.ToString());

                    dsItens_nota_ent.Clear();
                    datItens_nota_ent.Fill(ITENS_NOTA_ENT);

                    MessageBox.Show("Inserido");
                    tb_codigo.Text = "";
                    tb_localidade.Text = "";
                }
            }
            catch(Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void update_local_estoque(string cod)
        {
            try
            {
                FbCommand update = new FbCommand();
                update.Connection = fbConnection1;
                fbConnection1.Open();
                update.CommandText =
                    "UPDATE ESTOQUE SET LOCALIZACAO_ESTOQUE = '" + tb_localidade.Text + "' WHERE COD_ESTOQUE = '" + cod + "'";
                FbDataAdapter datEstoque = new FbDataAdapter();
                datEstoque.UpdateCommand = update;
                datEstoque.UpdateCommand.ExecuteNonQuery();
                fbConnection1.Close();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private bool verificar_se_todos_tem_lote()
        {

            try
            {
                for (int i = 0; i < dgvItens_nota.SelectedRows.Count; i++)
                {
                    if (dgvItens_nota.SelectedRows[i].Cells["col_lote"].Value.ToString() == "")
                    {
                        return false;
                    }
                }
                return true;
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
                return false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvItens_nota.SelectedRows.Count > 0)
            {
                if (verificar_se_todos_tem_lote())
                {
                    try
                    {
                        FbCommand delete = new FbCommand();
                        delete.Connection = fbConnection1;
                        fbConnection1.Open();
                        delete.CommandText = "DELETE FROM IMP_FICHA_MATERIAL";
                        FbDataAdapter datImp_ficha_material = new FbDataAdapter();
                        datImp_ficha_material.DeleteCommand = delete;
                        datImp_ficha_material.DeleteCommand.ExecuteNonQuery();
                        fbConnection1.Close();
                        string forn = "";


                        for (int i = 0; i < dgvItens_nota.SelectedRows.Count; i++)
                        {
                            string palete = "";
                            double qtdPalete = 0;
                            FbCommand selectPalete = new FbCommand();
                            selectPalete.Connection = fbConnection1;
                            selectPalete.CommandText =
                                "SELECT * FROM PALETE_LOTE WHERE LOTE_PALETE_LOTE = '" + dgvItens_nota.SelectedRows[i].Cells["col_lote"].Value.ToString() + "'";
                            FbDataAdapter datPalete = new FbDataAdapter();
                            DataSet dsPalete = new DataSet();
                            datPalete.SelectCommand = selectPalete;
                            fbConnection1.Open();
                            datPalete.Fill(dsPalete);
                            fbConnection1.Close();
                            foreach (DataRow dr in dsPalete.Tables[0].Rows)
                            {
                                palete = dr[1].ToString();
                                try
                                {
                                    qtdPalete = Convert.ToDouble(dr[2].ToString());
                                }
                                catch { qtdPalete = 0; }
                                forn = buscarForn(dgvItens_nota.SelectedRows[i].Cells["col_cod_nf_sistema"].Value.ToString());
                                try
                                {
                                    fbConnection1.Open();
                                    FbTransaction trans = fbConnection1.BeginTransaction();
                                    fbConnection1.Close();
                                    FbCommand insert = new FbCommand("INSERT INTO IMP_FICHA_MATERIAL " +
                      "(PROPRIETARIO_IFM, COD_ITEM_IFM, DESCRICAO_ITEM_IFM, QTDE_IFM, LOTE_IFM, PROX_OPERACAO_IFM, " +
                      "DIMENSOES_IFM, DATA_LIBERACAO_IFM, COD_BARRAS_IFM, TIPO_MATERIAL_IFM, RASTREAMENTO_IFM, PALETE_IFM) " +
                      "VALUES(?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)", fbConnection1, trans);
                                    insert.Parameters.AddWithValue("PROPRIETARIO_IFM", forn);
                                    insert.Parameters.AddWithValue("COD_ITEM_IFM", dgvItens_nota.SelectedRows[i].Cells["col_cod_item_est"].Value.ToString());
                                    string descricao = null, dimensoes = null, tipo_material = null, nome_proprietario = null;
                                    buscar_dados_item_estoque(dgvItens_nota.SelectedRows[i].Cells["col_cod_item_est"].Value.ToString(),
                                        out descricao, out dimensoes, out tipo_material, out nome_proprietario);
                                    insert.Parameters.AddWithValue("DESCRICAO_ITEM_IFM", descricao);
                                    insert.Parameters.AddWithValue("QTDE_IFM", qtdPalete.ToString().Replace(".", "").Replace(",", "."));
                                    insert.Parameters.AddWithValue("LOTE_IFM", dgvItens_nota.SelectedRows[i].Cells["col_lote"].Value.ToString());
                                    insert.Parameters.AddWithValue("PROX_OPERACAO_IFM", "ARMAZENAR");
                                    insert.Parameters.AddWithValue("DIMENSOES_IFM", dimensoes);
                                    insert.Parameters.AddWithValue("DATA_LIBERACAO_IFM", DateTime.Now.ToShortDateString().Replace("/", "."));

                                    //criando código de barras
                                    BarcodeLib.Barcode bar = new BarcodeLib.Barcode();
                                    Image bmp = bar.Encode(BarcodeLib.TYPE.CODE128, "#" + dgvItens_nota.SelectedRows[i].Cells["col_cod_item_est"].Value.ToString() +
                                        "#" + dgvItens_nota.SelectedRows[i].Cells["col_nf"].Value.ToString() + "#" +
                                        dgvItens_nota.SelectedRows[i].Cells["col_lote"].Value.ToString() + "#" + palete, 300, 150);

                                    FbParameter blob = new FbParameter();
                                    blob.FbDbType = FbDbType.Binary;
                                    // using System.ComponentModel and convert Bitmap to byte[]
                                    blob.Value = (byte[])TypeDescriptor.GetConverter(bmp).ConvertTo(bmp, typeof(byte[]));
                                    //inserindo código no banco
                                    insert.Parameters.Add(blob);
                                    insert.Parameters.AddWithValue("TIPO_MATERIAL_IFM", tipo_material);

                                    insert.Parameters.AddWithValue("RASTREAMENTO_IFM", buscar_cod_rastreamento(dgvItens_nota.SelectedRows[i].Cells["col_lote"].Value.ToString()));
                                    insert.Parameters.AddWithValue("PALETE_IFM", palete);

                                    fbConnection1.Open();
                                    //insert.Connection = fbConnection1;
                                    datImp_ficha_material.InsertCommand = insert;
                                    datImp_ficha_material.InsertCommand.ExecuteNonQuery();

                                    fbConnection1.Close();

                                }
                                catch (Exception a)
                                {
                                    fbConnection1.Close();
                                    MessageBox.Show(a.ToString());
                                }

                            }
                        }
                        FbCommand select = new FbCommand();
                        select.Connection = fbConnection1;
                        fbConnection1.Open();
                        select.CommandText = "SELECT * FROM IMP_FICHA_MATERIAL ORDER BY COD_IFM";
                        datImp_ficha_material.SelectCommand = select;
                        dsImp_ficha_material fichas = new dsImp_ficha_material();
                        datImp_ficha_material.Fill(fichas.IMP_FICHA_MATERIAL);
                        fbConnection1.Close();
                        //crTeste nova_op = new crTeste();
                        crFicha_material_2 nova_op = new crFicha_material_2();
                        nova_op.SetDataSource(fichas);
                        form_imprimir imprime = new form_imprimir(nova_op);
                        imprime.Show();
                    }
                    catch (Exception a)
                    {
                        fbConnection1.Close();
                        MessageBox.Show(a.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("É necessário digitar o lote de todos os itens além de digitar o proprietário no campo ao lado");
                }
            }
            else
            {
                MessageBox.Show("Selecione os itens a imprimir");
            }
        }

        private string buscarForn(string nf)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                select.CommandText =
                    "SELECT CLIENTE_FORN_NF_ENT FROM NOTA_FISCAL_ENT WHERE COD_SISTEMA_NF_ENT = '" + nf + "'";
                FbDataAdapter datTable = new FbDataAdapter();
                DataSet dsTable = new DataSet();
                fbConnection1.Open();
                datTable.SelectCommand = select;
                datTable.Fill(dsTable);
                fbConnection1.Close();
                DataRow dr = dsTable.Tables[0].Rows[0];
                return dr[0].ToString();
            }
            catch
            {
                fbConnection1.Close();
                return "";
            }
        }
        private string buscar_cod_rastreamento(string cod_lote)
        {

            string rastreamento = "";
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT * FROM LOTE_RECEBIMENTO WHERE COD_LR = '" + cod_lote + "'";
                FbDataAdapter datLr = new FbDataAdapter();
                datLr.SelectCommand = select;
                DataSet dsLr = new DataSet();
                datLr.Fill(dsLr);
                fbConnection1.Close();

                foreach (DataRow dr in dsLr.Tables[0].Rows)
                {
                    rastreamento = dr["RASTREAMENTO_LR"].ToString();
                }
                return rastreamento;
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
                return "erro";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string baixado = "";
                if (rbEntrada_efetuada.Checked)
                    baixado = " AND BAIXADO_ITEM_ENT = '1'";
                if (rbAguardando.Checked)
                    baixado = " AND (BAIXADO_ITEM_ENT IS NULL OR BAIXADO_ITEM_ENT != '1')";
                string tipo = "";
                if (rbAlmoxarifado.Checked)
                    tipo = " AND ALMOXARIFADO_ITEM_ENT = '1'";
                if (rbMateria_prima.Checked)
                    tipo = " AND MATERIA_PRIMA_ITEM_ENT = '1'";
                string data = "";
                if (cb_data.Checked)
                    data = " AND (DATA_INSERCAO_ITEM_ENT_NOTA >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") + "' AND " +
                        " DATA_INSERCAO_ITEM_ENT_NOTA <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "')";

                dsItens_nota_ent.Clear();
                datItens_nota_ent.SelectCommand.CommandText =
                    "SELECT ITENS_NOTA_ENT.*, NOTA_FISCAL_ENT.CLIENTE_FORN_NF_ENT, NOTA_FISCAL_ENT.CNPJ_CLIENTE_FORN_ENT FROM ITENS_NOTA_ENT " +
                    " JOIN NOTA_FISCAL_ENT ON ITENS_NOTA_ENT.COD_SISTEMA_NF_ITEM_ENT = NOTA_FISCAL_ENT.COD_SISTEMA_NF_ENT " + 
                    "WHERE COD_ITENS_NOTA_ENT IS NOT NULL" + baixado + tipo + data;
                datItens_nota_ent.SelectCommand.Connection = fbConnection1;
                fbConnection1.Open();
                datItens_nota_ent.SelectCommand.ExecuteNonQuery();
                datItens_nota_ent.Fill(ITENS_NOTA_ENT);
                fbConnection1.Close();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void tb_descricao_TextChanged(object sender, EventArgs e)
        {

            try
            {
                dsItens_nota_ent.Tables["ITENS_NOTA_ENT"].DefaultView.RowFilter = "DESCRICAO_ITEM_ENT Like '*" + tb_descricao.Text + "*'";
            }
            catch { }
        }

        private void tb_nota_fiscal_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsItens_nota_ent.Tables["ITENS_NOTA_ENT"].DefaultView.RowFilter = "NF_ITEM_ENT = '" + tb_nota_fiscal.Text + "'";
            }
            catch { }
        }

        private void tb_cod_item_estoque_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsItens_nota_ent.Tables["ITENS_NOTA_ENT"].DefaultView.RowFilter = "COD_ITEM_EST_ITEM_ENT = '" + tb_cod_item_estoque.Text + "'";
            }
            catch { }
        }

        private void tb_lote_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsItens_nota_ent.Tables["ITENS_NOTA_ENT"].DefaultView.RowFilter = "LOTE_ITEM_ENT = '" + tb_lote.Text + "'";
            }
            catch { }
        }

       

    }
}