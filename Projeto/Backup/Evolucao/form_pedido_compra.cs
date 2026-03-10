using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_pedido_compra : Form
    {
        public bool abrir_pedido;
        public string n_pedido;
        public form_pedido_compra()
        {
            InitializeComponent();
        }

        private void bt_localizar_forn_Click(object sender, EventArgs e)
        {
            
            form_localiza_forn localiza_forn = new form_localiza_forn(true);
            try
            {
                localiza_forn.ShowDialog();
            }
            finally
            {

                localiza_forn.Dispose();
                try
                {
                    string _nome_forn = "", _cnpj_forn = "";
                    comando_select.CommandText = "SELECT * FROM FORNECEDORES WHERE COD_FORN = '" + localiza_forn.forn_escolhido + "'";
                    DataSet forn = new DataSet();
                    fbConnection1.Open();
                    datFornecedores.SelectCommand = comando_select;
                    datFornecedores.Fill(forn);
                    fbConnection1.Close();
                    foreach (DataRow dr in forn.Tables[0].Rows)
                    {
                        _nome_forn = dr["RAZAO_SOCIAL_FORN"].ToString();
                        _cnpj_forn = dr["CNPJ_CPF_FORN"].ToString();
                    }
                    if (_nome_forn != "")
                    {
                        tb_nome_forn.Text = _nome_forn;
                        tb_cnpj_forn.Text = _cnpj_forn;
                    }
                    else
                    {
                        MessageBox.Show("Fornecedor não encontrado ou com dados incompletos.");
                    }
                    form_busca_contato busca = new form_busca_contato();
                    try
                    {
                        busca.cod_cli_forn = detectar_cod();
                        busca.cli_forn = "FORN";
                        busca.ShowDialog();
                    }
                    finally
                    {
                        for (int i = 0; i < busca.qtde; i++)
                        {
                            tb_tel_contato.Text = busca.valores[i, 2];
                            tb_contato.Text = busca.valores[i, 1];
                            tb_email_contato.Text = busca.valores[i, 0];
                        }
                    }
                }
                catch
                {
                    fbConnection1.Close();
                }
            }
        }

        private void form_pedido_compra_Load(object sender, EventArgs e)
        {
            if (abrir_pedido == true)
            {
                try
                {
                    dsPedido_compra.Clear();
                    dsItens_ped.Clear();
                    this.datPedido_compra.SelectCommand.CommandText =
                    "SELECT * FROM PEDIDO_COMPRA WHERE COD_PED = '" + n_pedido + "'";
                    this.fbConnection1.Open();
                    this.datPedido_compra.SelectCommand.Connection = fbConnection1;
                    this.datPedido_compra.SelectCommand.ExecuteNonQuery();
                    datPedido_compra.Fill(PEDIDO_COMPRA);
                    this.fbConnection1.Close();

                    this.datItens_ped.SelectCommand.CommandText =
                    "SELECT * FROM ITENS_PEDIDO_COMPRA WHERE N_PEDIDO_ITEM_PED = '" + n_pedido + "'";
                    this.fbConnection1.Open();
                    this.datItens_ped.SelectCommand.Connection = fbConnection1;
                    this.datItens_ped.SelectCommand.ExecuteNonQuery();
                    datItens_ped.Fill(ITENS_PEDIDO_COMPRA);
                    this.fbConnection1.Close();
                    visualizar_botoes();
                }
                catch
                {
                    fbConnection1.Close();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dsItens_ped.Clear();
            dsPedido_compra.Clear();

            this.datPedido_compra.DeleteCommand.CommandText =
                        "DELETE FROM PEDIDO_COMPRA WHERE NOME_FORN_PED = 'NOVO'";
            this.fbConnection1.Open();
            this.datPedido_compra.DeleteCommand.Connection = fbConnection1;
            this.datPedido_compra.DeleteCommand.ExecuteNonQuery();
            this.fbConnection1.Close();

            this.datPedido_compra.InsertCommand.CommandText =
                "INSERT INTO PEDIDO_COMPRA (NOME_FORN_PED)" +
                "VALUES ('NOVO')";
            this.fbConnection1.Open();
            this.datPedido_compra.InsertCommand.Connection = fbConnection1;
            this.datPedido_compra.InsertCommand.ExecuteNonQuery();
            this.fbConnection1.Close();

            try
            {

                this.datPedido_compra.SelectCommand.CommandText =
                    "SELECT * FROM PEDIDO_COMPRA WHERE NOME_FORN_PED = 'NOVO'";
                this.fbConnection1.Open();
                this.datPedido_compra.SelectCommand.Connection = fbConnection1;
                this.datPedido_compra.SelectCommand.ExecuteNonQuery();
                datPedido_compra.Fill(PEDIDO_COMPRA);
                this.fbConnection1.Close();
                tb_nome_forn.Text = "";
                tb_data_emissao.Text = DateTime.Now.ToShortDateString();
                apagar_campos();
            }
            catch
            {
                fbConnection1.Close();
                MessageBox.Show("Erro");
            }
        }

        private void apagar_campos()
        {
            tb_descricao_item.Text = "";
            tb_cod_item.Text = "";
            tb_item_n_pedido.Text = "";
            tb_qtde.Text = "";
            tb_unidade.Text = "";
            tb_valor_unit.Text = "";
            tb_os.Text = "";
            tb_pos.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("O registro será excluído permanentemente, tem certeza?",
               "Confirma a exclusão?", MessageBoxButtons.YesNo))
            {

                try
                {
                    this.datItens_ped.DeleteCommand.CommandText =
                        "DELETE FROM ITENS_PEDIDO_COMPRA WHERE N_PEDIDO_ITEM_PED = '" + tb_n_pedido.Text + "'";
                    this.fbConnection1.Open();
                    this.datItens_ped.DeleteCommand.Connection = fbConnection1;
                    this.datItens_ped.DeleteCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();

                    this.datPedido_compra.DeleteCommand.CommandText =
                        "DELETE FROM PEDIDO_COMPRA WHERE COD_PED = '" + tb_n_pedido.Text + "'";
                    this.fbConnection1.Open();
                    this.datPedido_compra.DeleteCommand.Connection = fbConnection1;
                    this.datPedido_compra.DeleteCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                    dsPedido_compra.Clear();
                    dsItens_ped.Clear();
                }
                catch
                {
                    fbConnection1.Close();
                    MessageBox.Show("Erro");
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tb_data_emissao.Text == "")
                tb_data_emissao.Text = DateTime.Now.ToShortDateString();
            Atualizar();
        }

        private void Atualizar()
        {
            this.BindingContext[dsPedido_compra, "PEDIDO_COMPRA"].EndCurrentEdit();
            if (dsPedido_compra.HasChanges())
            {
                fbConnection1.Open();
                datPedido_compra.UpdateCommand = cbPedido_compra.GetUpdateCommand();
                datPedido_compra.InsertCommand = cbPedido_compra.GetInsertCommand();
                datPedido_compra.DeleteCommand = cbPedido_compra.GetDeleteCommand();
                datPedido_compra.Update(dsPedido_compra, "PEDIDO_COMPRA");
                dsPedido_compra.AcceptChanges();
                fbConnection1.Close();
            }
            this.BindingContext[dsItens_ped, "ITENS_PEDIDO_COMPRA"].EndCurrentEdit();
            if (dsItens_ped.HasChanges())
            {
                fbConnection1.Open();
                datItens_ped.UpdateCommand = cbItens_ped.GetUpdateCommand();
                datItens_ped.InsertCommand = cbItens_ped.GetInsertCommand();
                datItens_ped.DeleteCommand = cbItens_ped.GetDeleteCommand();
                datItens_ped.Update(dsItens_ped, "ITENS_PEDIDO_COMPRA");
                dsItens_ped.AcceptChanges();
                fbConnection1.Close();
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            form_localiza_ped ped = new form_localiza_ped();
            try
            {
                ped.ShowDialog();
            }
            finally
            {
                ped.Dispose();
                try
                {
                    dsPedido_compra.Clear();
                    dsItens_ped.Clear();
                    this.datPedido_compra.SelectCommand.CommandText =
                    "SELECT * FROM PEDIDO_COMPRA WHERE COD_PED = '" + ped.ped_escolhido + "'";
                    this.fbConnection1.Open();
                    this.datPedido_compra.SelectCommand.Connection = fbConnection1;
                    this.datPedido_compra.SelectCommand.ExecuteNonQuery();
                    datPedido_compra.Fill(PEDIDO_COMPRA);
                    this.fbConnection1.Close();

                    this.datItens_ped.SelectCommand.CommandText =
                    "SELECT * FROM ITENS_PEDIDO_COMPRA WHERE N_PEDIDO_ITEM_PED = '" + ped.ped_escolhido + "'";
                    this.fbConnection1.Open();
                    this.datItens_ped.SelectCommand.Connection = fbConnection1;
                    this.datItens_ped.SelectCommand.ExecuteNonQuery();
                    datItens_ped.Fill(ITENS_PEDIDO_COMPRA);
                    this.fbConnection1.Close();
                    visualizar_botoes();
                }
                catch
                {
                    fbConnection1.Close();
                }

            }
        }

        private void visualizar_botoes()
        {
            bt_enviar_email.Visible = false;
            bt_imprimir.Visible = false;
            if (tb_nome_autorizante.Text != "")
            {
                bt_enviar_email.Visible = true;
                bt_imprimir.Visible = true;
            }
        }

        private void bt_inserir_Click(object sender, EventArgs e)
        {
            if (tb_nome_autorizante.Text == "")
            {
                try
                {
                    if (tb_item_n_pedido.Text != "")
                    {
                        string _data_limite = "", _op = "", _cod = "", _item = "", _pos = "";
                        comando_select.CommandText = "SELECT * FROM ITENS_REQUISICAO WHERE COD_ITEM_REQ = '" + tb_item_n_pedido.Text + "'";
                        DataSet req = new DataSet();
                        fbConnection1.Open();
                        datItens_req.SelectCommand = comando_select;
                        datItens_req.Fill(req);
                        fbConnection1.Close();
                        foreach (DataRow dr in req.Tables[0].Rows)
                        {
                            _data_limite = dr["DATA_LIMITE_ITEM_REQ"].ToString();
                            _op = dr["OP_ITEM_REQ"].ToString();
                            _cod = dr["COD_ITEM_REQ"].ToString();
                            _pos = dr["POSICAO_ITEM_REQ"].ToString();
                            _item = dr["ITEM_ITEM_REQ"].ToString();
                            
                        }
                        if (_cod.ToString() != "")
                        {
                            string data_limite = "";
                            string op = "";
                            string pos = "";
                            string plano = "";
                            string item = "";
                            if (tb_planos.Text != "")
                            {
                                plano = "'" + tb_planos.Text + "'";
                                if (plano == "''")
                                    plano = "null";
                            }

                            else
                            {
                                plano = "null";
                            }
                            try
                            {
                                data_limite = "'" + Convert.ToDateTime(_data_limite).ToShortDateString().Replace("/", ".") + "'";
                            }
                            catch
                            {
                                data_limite = "null";
                            }

                            if(_op != "")
                            {
                                op = "'" + _op + "'";
                                if (op == "''")
                                    op = "null";
                            }
                                
                            else
                            {
                                op = "null";
                            }

                            if (_item != "")
                            {
                                item = "'" + _item + "'";
                                if (item == "''")
                                    item = "null";
                            }

                            else
                            {
                                item = "null";
                            }
                            

                            if (_pos != "")
                            {
                                pos = "'" + _pos + "'";
                                if (pos == "''")
                                    pos = "null";
                                
                            }
                            else
                            {
                                pos = "null";
                            }
                            double valor_total = 0;
                            try
                            {
                                valor_total = Convert.ToDouble(tb_qtde.Text) * Convert.ToDouble(tb_valor_unit.Text);
                            }
                            catch { }
                            string _cod_item = "";
                            if (tb_cod_item.Text != "")
                            {
                                _cod_item = "'" + Convert.ToString(tb_cod_item.Text) + "'";
                            }
                            else
                            {
                                _cod_item = "null";
                            }

                            string _qtde = "";
                            if (tb_qtde.Text != "")
                            {
                                _qtde = "'" + Convert.ToString(tb_qtde.Text) + "'";
                            }
                            else
                            {
                                _qtde = "null";
                            }

                            string _peso = "";
                            if (tb_peso.Text != "")
                            {
                                _peso= "'" + Convert.ToString(tb_peso.Text) + "'";
                            }
                            else
                            {
                                _peso = "null";
                            }




                            this.datItens_ped.InsertCommand.CommandText =
                               "INSERT INTO ITENS_PEDIDO_COMPRA (N_PEDIDO_ITEM_PED, COD_ITEM_REQ_ITEM_PED, OP_ITEM_PED, POSICAO_ITEM_PED, QTDE_ITEM_PED, PESO_ITEM_PED, UNID_ITEM_PED, VALOR_UNIT_ITEM_PED, " +
                               "VALOR_TOTAL_ITEM_PED, COD_ESTOQUE_ITEM_PED, ITEM_ITEM_PED, DESCRICAO_ITEM_PED, DATA_LIMITE_ITEM_PED, PLANO_ITEM_PED) " +
                               "VALUES ('" + tb_n_pedido.Text + "','" + tb_item_n_pedido.Text + "'," + op + "," + pos + "," + _qtde.Replace(",",".") + "," + _peso.Replace(",",".") + ",'" + tb_unidade.Text + "','" + tb_valor_unit.Text.Replace(".","").Replace(",", ".") + "','" +
                               valor_total.ToString("n2").Replace(".", "").Replace(",",".") + "'," + _cod_item + "," + item + ",'" + tb_descricao_item.Text + "'," + data_limite + "," + plano + ")";
                            this.fbConnection1.Open();
                            this.datItens_ped.InsertCommand.Connection = fbConnection1;
                            this.datItens_ped.InsertCommand.ExecuteNonQuery();
                            this.fbConnection1.Close();

                            dsItens_ped.Clear();
                            this.datItens_ped.SelectCommand.CommandText =
                            "SELECT * FROM ITENS_PEDIDO_COMPRA WHERE N_PEDIDO_ITEM_PED = '" + tb_n_pedido.Text + "'";
                            this.fbConnection1.Open();
                            this.datItens_ped.SelectCommand.Connection = fbConnection1;
                            this.datItens_ped.SelectCommand.ExecuteNonQuery();
                            datItens_ped.Fill(ITENS_PEDIDO_COMPRA);
                            this.fbConnection1.Close();

                           
                            this.datItens_req.UpdateCommand.CommandText =
                                "UPDATE ITENS_REQUISICAO SET SITUACAO_ATUAL_ITEM_REQ = 'AGUARDANDO AUTORIZAÇÃO NO PEDIDO DE COMPRA' WHERE COD_ITEM_REQ = " + tb_item_n_pedido.Text + "";
                            this.fbConnection1.Open();
                            this.datItens_req.UpdateCommand.Connection = fbConnection1;
                            this.datItens_req.UpdateCommand.ExecuteNonQuery();
                            this.fbConnection1.Close();

                            apagar_campos();
                        }
                        else
                        {
                            MessageBox.Show("Código do Item da Requisição inexistente");
                        }


                    }
                    else
                    {
                        string plano = "";
                        string item = "";
                        double valor_total = 0;
                        try
                        {
                            valor_total = Convert.ToDouble(tb_qtde.Text) * Convert.ToDouble(tb_valor_unit.Text);
                        }
                        catch { }
                        string _cod_item = "";
                        if(tb_cod_item.Text != "")
                        {
                            _cod_item = "'" + Convert.ToString(tb_cod_item.Text) + "'";
                        }
                        else
                    
                        {
                            _cod_item = "null";
                        }

                        string _item = "";
                        if (tb_item_item.Text != "")
                        {
                            _item = "'" + Convert.ToString(tb_item_item.Text) + "'";
                        }
                        else
                        {
                            _item = "null";
                        }

                        string _pos = "";
                        if (tb_planos.Text != "")
                        {
                            plano = "'" + tb_planos.Text + "'";
                            if (plano == "''")
                                plano = "null";
                        }
                        else
                        {
                            plano = "null";
                        }

                        

                       

                        if (tb_pos.Text != "")
                        {
                            _pos = "'" + Convert.ToString(tb_pos.Text) + "'";
                        }
                        else
                        {
                            _pos = "null";
                        }

                        string _os = "";
                        if (tb_os.Text != "")
                        {
                            _os = "'" + Convert.ToString(tb_os.Text) + "'";
                        }
                        else
                        {
                            _os = "null";
                        }
                        this.datItens_ped.InsertCommand.CommandText =
                               "INSERT INTO ITENS_PEDIDO_COMPRA (N_PEDIDO_ITEM_PED, OP_ITEM_PED, POSICAO_ITEM_PED, QTDE_ITEM_PED, UNID_ITEM_PED, VALOR_UNIT_ITEM_PED, " +
                               "VALOR_TOTAL_ITEM_PED, COD_ESTOQUE_ITEM_PED, ITEM_ITEM_PED, DESCRICAO_ITEM_PED, PLANO_ITEM_PED) " +
                               "VALUES ('" + tb_n_pedido.Text + "'," + _os + "," + _pos + ",'" + tb_qtde.Text + "','" + tb_unidade.Text + "','" + tb_valor_unit.Text.Replace(".","").Replace(",", ".") + "','" +
                               valor_total.ToString("n2").Replace(".","").Replace(",", ".") + "'," + _cod_item + "," + _item + ",'" + tb_descricao_item.Text + "'," + plano + ")";
                        this.fbConnection1.Open();
                        this.datItens_ped.InsertCommand.Connection = fbConnection1;
                        this.datItens_ped.InsertCommand.ExecuteNonQuery();
                        this.fbConnection1.Close();

                        dsItens_ped.Clear();
                        this.datItens_ped.SelectCommand.CommandText =
                        "SELECT * FROM ITENS_PEDIDO_COMPRA WHERE N_PEDIDO_ITEM_PED = '" + tb_n_pedido.Text + "'";
                        this.fbConnection1.Open();
                        this.datItens_ped.SelectCommand.Connection = fbConnection1;
                        this.datItens_ped.SelectCommand.ExecuteNonQuery();
                        datItens_ped.Fill(ITENS_PEDIDO_COMPRA);
                        this.fbConnection1.Close();
                        apagar_campos();
                    }
                }
                catch
                {
                    MessageBox.Show("Erro. Verifique os dados por favor");
                    fbConnection1.Close();
                }
            }
            else
            {
                MessageBox.Show("Não é possível inserir itens pois o Pedido de Compra já foi autorizado");
            }
            
        }

        

        private void tb_descricao_item_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void localiza_item()
        {
            form_pesquisa_requisicao localiza_item = new form_pesquisa_requisicao();
            try
            {
                localiza_item.fazer_pedido_item = true;
                localiza_item.ShowDialog();
            }
            finally
            {
                localiza_item.Dispose();
                if (localiza_item.cod_escolhido == "")
                {
                    tb_descricao_item.Text = localiza_item.descricao_escolhido;
                    MessageBox.Show("Esse item não está vinculado a nenhum item do estoque");
                }
                else
                {
                    tb_descricao_item.Text = localiza_item.descricao_escolhido;
                    tb_cod_item.Text = localiza_item.cod_item_escolhido;
                    tb_item_n_pedido.Text = localiza_item.cod_escolhido;
                    tb_qtde.Text = localiza_item.qtde_escolhida;
                    tb_unidade.Text = localiza_item.unid_escolhida;
                    tb_item_item.Text = localiza_item.item_escolhido;

                }
            }
        
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double valor_total = 0;
            try
            {
                for (int i = 0; i < dgvItens_ped.RowCount; i++)
                {
                    double valor_parcial = 0;
                    if (dgvItens_ped.Rows[i].Cells["col_peso"].Value.ToString() != "")
                    {
                        valor_parcial = Convert.ToDouble(dgvItens_ped.Rows[i].Cells["col_valor_unit"].Value) * Convert.ToDouble(dgvItens_ped.Rows[i].Cells["col_peso"].Value);
                    }
                    else
                    {
                        valor_parcial = Convert.ToDouble(dgvItens_ped.Rows[i].Cells["col_valor_unit"].Value) * Convert.ToDouble(dgvItens_ped.Rows[i].Cells["col_qtde"].Value);
                    }
                    dgvItens_ped.Rows[i].Cells["col_valor_total"].Value = valor_parcial.ToString("n2").Replace(".", "");
                    valor_total = valor_total + valor_parcial;
                }
                try
                {
                    valor_total = valor_total + Convert.ToDouble(tb_valor_outras_desp.Text);
                }
                catch { }
                try
                {
                    valor_total = valor_total + Convert.ToDouble(tb_valor_real_ipi.Text);
                }
                catch { }
                tb_valor_total.Text = valor_total.ToString("n2");
            }
            catch
            {
                MessageBox.Show("Confira os valores por favor");
            }
        }

        private void tb_descricao_item_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2:
                    localiza_item();
                    break;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (tb_nome_autorizante.Text != "")
                MessageBox.Show("Pedido já foi autorizado");
            else
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
                        if (usuario._nivel_acesso_usuario == "1")
                        {
                            tb_nome_autorizante.Text = usuario._nome_usuario;
                            tb_data_autorizacao.Text = DateTime.Now.ToShortDateString();
                            tb_hora_autorizacao.Text = DateTime.Now.ToShortTimeString();
                            cbAutorizado.Checked = true;
                            bt_imprimir.Visible = true;
                            bt_enviar_email.Visible = true;
                            atualizar_requisicoes("PEDIDO DE COMPRA AUTORIZADO");
                            
                            Atualizar();
                        }
                        else
                        {
                            MessageBox.Show("Esse usuário não tem acesso a esse recurso");
                        }
                    }


                }
            }
            
        }
        private void atualizar_requisicoes(string _posicao_atual)
        {

            for (int i = 0; i < dgvItens_ped.RowCount; i++)
            {
                if (dgvItens_ped.Rows[i].Cells["col_item_req"].Value.ToString() != "")
                {
                    this.datItens_req.UpdateCommand.CommandText =
                            "UPDATE ITENS_REQUISICAO SET SITUACAO_ATUAL_ITEM_REQ = '" + _posicao_atual + "' WHERE COD_ITEM_REQ = " + dgvItens_ped.Rows[i].Cells["col_item_req"].Value.ToString() + "";
                    this.fbConnection1.Open();
                    this.datItens_req.UpdateCommand.Connection = fbConnection1;
                    this.datItens_req.UpdateCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                }
            }
                            
        }

        private void dgvItens_ped_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvItens_ped.Columns[e.ColumnIndex].Name == "Req")
            {
                if (dgvItens_ped.Rows[e.RowIndex].Cells["col_item_req"].Value.ToString() != "")
                {
                    string _cod_req = "";
                    comando_select.CommandText = "SELECT * FROM ITENS_REQUISICAO WHERE COD_ITEM_REQ = '" + dgvItens_ped.Rows[e.RowIndex].Cells["col_item_req"].Value.ToString() + "'";
                    DataSet req = new DataSet();
                    fbConnection1.Open();
                    datItens_req.SelectCommand = comando_select;
                    datItens_req.Fill(req);
                    fbConnection1.Close();
                    foreach (DataRow dr in req.Tables[0].Rows)
                    {
                        _cod_req = dr["COD_REQ_ITEM_REQ"].ToString();
                    }
                    form_requisicao requisicao = new form_requisicao();
                    try
                    {
                        requisicao.abrir_requisicao = true;
                        requisicao.n_requisicao = _cod_req;
                        requisicao.ShowDialog();
                    }
                    finally
                    {
                        requisicao.Dispose();
                    }
                }
            }
             
        }

        private void bt_imprimir_Click(object sender, EventArgs e)
        {
            try
            {
                this.datPedido_compra.SelectCommand.CommandText =
                    "SELECT * FROM PEDIDO_COMPRA WHERE COD_PED = '" + tb_n_pedido.Text + "'";
                this.fbConnection1.Open();
                this.datPedido_compra.SelectCommand.Connection = fbConnection1;
                this.datPedido_compra.SelectCommand.ExecuteNonQuery();
                this.fbConnection1.Close();

                this.datItens_ped.SelectCommand.CommandText =
                "SELECT * FROM ITENS_PEDIDO_COMPRA WHERE N_PEDIDO_ITEM_PED = '" + tb_n_pedido.Text + "'";
                this.fbConnection1.Open();
                this.datItens_ped.SelectCommand.Connection = fbConnection1;
                this.datItens_ped.SelectCommand.ExecuteNonQuery();
                this.fbConnection1.Close();

                this.datFornecedores.SelectCommand.CommandText =
                    "SELECT * FROM FORNECEDORES WHERE CNPJ_CPF_FORN = '" + tb_cnpj_forn.Text + "'";
                this.fbConnection1.Open();
                this.datFornecedores.SelectCommand.Connection = fbConnection1;
                this.datFornecedores.SelectCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
                dsImp_pedido_compra imprimir = new dsImp_pedido_compra();
                fbConnection1.Open();
                datPedido_compra.Fill(imprimir.PEDIDO_COMPRA);
                datItens_ped.Fill(imprimir.ITENS_PEDIDO_COMPRA);
                datFornecedores.Fill(imprimir.FORNECEDORES);
                fbConnection1.Close();
                
                    crPedido_compra novo_ped = new crPedido_compra();
                    novo_ped.SetDataSource(imprimir);
                    form_imprimir imprime = new form_imprimir(novo_ped);
                    imprime.n_pedido_compra = tb_n_pedido.Text;
                    imprime.pedido_compra = true;
                    imprime.Show();
                    baixar_pedido();
                
            }
            catch
            {
                fbConnection1.Close();
            }
        }


        private void baixar_pedido()
        {
            cb_efetuado.Checked = true;
            Atualizar();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_n_requisicao.Text == "")
            {
                MessageBox.Show("Digite uma requisição por favor");
            }
            else
            {
                try
                {
                    string[] _cod = new string[100];
                    string[] _cod_estoque = new string[100];
                    string[] _item = new string[100];
                    string[] _descricao = new string[100];
                    string[] _qtde = new string[100];
                    string[] _unid = new string[100];
                    string[] _data_limite = new string[100];
                    string[] _op = new string[100];
                    string[] _pos = new string[100];
                    string[] _sit_atual = new string[100];
                    string[] _cod_forn = new string[100];
                    comando_select.CommandText = "SELECT * FROM ITENS_REQUISICAO WHERE COD_REQ_ITEM_REQ = '" + tb_n_requisicao.Text + "'";
                    DataSet req = new DataSet();
                    fbConnection1.Open();
                    datItens_req.SelectCommand = comando_select;
                    datItens_req.Fill(req);
                    fbConnection1.Close();
                    int n = 0;
                    foreach (DataRow dr in req.Tables[0].Rows)
                    {
                        _cod[n] = dr["COD_ITEM_REQ"].ToString();
                        _cod_estoque[n] = dr["COD_ESTOQUE_ITEM_REQ"].ToString();
                        _item[n] = dr["ITEM_ITEM_REQ"].ToString();
                        _descricao[n] = dr["DESCRICAO_ITEM_REQ"].ToString();
                        _qtde[n] = dr["QTDE_ITEM_REQ"].ToString();
                        _unid[n] = dr["UNIDADE_ITEM_REQ"].ToString();
                        _data_limite[n] = dr["DATA_LIMITE_ITEM_REQ"].ToString();
                        _op[n] = dr["OP_ITEM_REQ"].ToString();
                        _pos[n] = dr["POSICAO_ITEM_REQ"].ToString();
                        _sit_atual[n] = dr["SITUACAO_ATUAL_ITEM_REQ"].ToString();
                        _cod_forn[n] = dr["COD_FORN_ITEM_REQ"].ToString();
                        n++;
                    }

                    for (int i = 0; i < n; i++)
                    {
                        if (_sit_atual[i] == "REQUISIÇÃO AUTORIZADA")
                        {
                            if (_cod[i].ToString() != "")
                            {
                                string data_limite = "";
                                string op = "";
                                string pos = "";
                                string plano = "";
                                if (tb_planos.Text != "")
                                {
                                    plano = "'" + tb_planos.Text + "'";
                                    if (plano == "''")
                                        plano = "null";
                                }

                                else
                                {
                                    plano = "null";
                                }
                                try
                                {
                                    data_limite = "'" + Convert.ToDateTime(_data_limite[i]).ToShortDateString().Replace("/", ".") + "'";
                                }
                                catch
                                {
                                    data_limite = "null";
                                }

                                try
                                {
                                    op = "'" + Convert.ToString(_op[i]) + "'";
                                }
                                catch
                                {
                                    op = "null";
                                }

                                try
                                {
                                    pos = "'" + Convert.ToString(_pos[i]) + "'";
                                }
                                catch
                                {
                                    pos = "null";
                                }


                                string _cod_est = "";
                                if (_cod_estoque[i] != "")
                                {
                                    _cod_est = "'" + Convert.ToString(_cod_estoque[i]) + "'";
                                }
                                else
                                {
                                    _cod_est = "null";
                                }

                                string _item_1 = "";
                                if (_item[i] != "")
                                {
                                    _item_1 = "'" + Convert.ToString(_item[i]) + "'";
                                }
                                else
                                {
                                    _item_1 = "null";
                                }

                                string _cod_forn1 = "";
                                if (_cod_forn[i] != "")
                                {
                                    _cod_forn1 = "'" + Convert.ToString(_cod_forn[i]) + "'";
                                }
                                else
                                {
                                    _cod_forn1 = "null";
                                }



                                this.datItens_ped.InsertCommand.CommandText =
                                   "INSERT INTO ITENS_PEDIDO_COMPRA (N_PEDIDO_ITEM_PED, COD_ITEM_REQ_ITEM_PED, OP_ITEM_PED, POSICAO_ITEM_PED, QTDE_ITEM_PED, UNID_ITEM_PED, " +
                                   "COD_ESTOQUE_ITEM_PED, ITEM_ITEM_PED, DESCRICAO_ITEM_PED, DATA_LIMITE_ITEM_PED, PLANO_ITEM_PED, COD_FORN_ITEM_PED) " +
                                   "VALUES ('" + tb_n_pedido.Text + "','" + _cod[i] + "'," + op + "," + pos + ",'" + _qtde[i].Replace(",", ".") + "','" + _unid[i] + "'," +
                                   _cod_est + "," + _item_1 + ",'" + _descricao[i] + "'," + data_limite + "," + plano + "," + _cod_forn1 + ")";
                                this.fbConnection1.Open();
                                this.datItens_ped.InsertCommand.Connection = fbConnection1;
                                this.datItens_ped.InsertCommand.ExecuteNonQuery();
                                this.fbConnection1.Close();

                                dsItens_ped.Clear();
                                this.datItens_ped.SelectCommand.CommandText =
                                "SELECT * FROM ITENS_PEDIDO_COMPRA WHERE N_PEDIDO_ITEM_PED = '" + tb_n_pedido.Text + "'";
                                this.fbConnection1.Open();
                                this.datItens_ped.SelectCommand.Connection = fbConnection1;
                                this.datItens_ped.SelectCommand.ExecuteNonQuery();
                                datItens_ped.Fill(ITENS_PEDIDO_COMPRA);
                                this.fbConnection1.Close();

                                this.datItens_req.UpdateCommand.CommandText =
                                    "UPDATE ITENS_REQUISICAO SET SITUACAO_ATUAL_ITEM_REQ = 'AGUARDANDO AUTORIZAÇÃO NO PEDIDO DE COMPRA' WHERE COD_ITEM_REQ = " + _cod[i] + "";
                                this.fbConnection1.Open();
                                this.datItens_req.UpdateCommand.Connection = fbConnection1;
                                this.datItens_req.UpdateCommand.ExecuteNonQuery();
                                this.fbConnection1.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Não pode ser inserido porque a Situação Atual dessa requisição é: " + _sit_atual[i]);
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Erro na inserção");
                    fbConnection1.Close();
                }
            }
             
        }
        private string detectar_cod()
        {
            comando_select.CommandText = "SELECT COD_FORN " +
                "FROM FORNECEDORES WHERE CNPJ_CPF_FORN = '" + tb_cnpj_forn.Text + "'";
            DataSet forn = new DataSet();
            fbConnection1.Open();

            datFornecedores.SelectCommand = comando_select;
            datFornecedores.Fill(forn);
            string fornecedor_atual = "";
            foreach (DataRow dr in forn.Tables[0].Rows)
            {

                fornecedor_atual = dr["COD_FORN"].ToString();
            }

            this.fbConnection1.Close();
            return fornecedor_atual;

        }
        private void bt_enviar_email_Click(object sender, EventArgs e)
        {
            /*
            form_busca_contato busca = new form_busca_contato();
            try
            {
                busca.cod_cli_forn = detectar_cod();
                busca.cli_forn = "FORN";
                busca.ShowDialog();
            }
            finally
            {
                for (int i = 0; i < busca.qtde; i++)
                {
                    enviar_email(busca.valores[i,0]);
                }
            }
             * */

            enviar_email(tb_email_contato.Text);
        }

        private void enviar_email(string destinatario)
        {
            string _caminho_arquivo = "c:\\evolucao_dokinos\\PEDIDOS_COMPRA\\" + "PEDIDO_" + tb_n_pedido.Text + ".pdf";
            string _assunto = "PEDIDO DE COMPRA Nº" + tb_n_pedido.Text + " - NG FERRAMENTAS";
            string _mensagem = "<html xmlns:v='urn:schemas-microsoft-com:vml'" +
"xmlns:o='urn:schemas-microsoft-com:office:office'" +
"xmlns:w='urn:schemas-microsoft-com:office:word'" +
"xmlns='http://www.w3.org/TR/REC-html40'>" +

"<head>" +
"<meta http-equiv=Content-Type content='text/html; charset=windows-1252'>" +
"<meta name=ProgId content=Word.Document>" +
"<meta name=Generator content='Microsoft Word 11'>" +
"<meta name=Originator content='Microsoft Word 11'>" +
"<link rel=File-List href='body_arquivos/filelist.xml'>" +
"<title>Prezado cliente,</title>" +
"</head>" +
"<body lang=PT-BR link=blue vlink=purple style='tab-interval:35.4pt' fontface = 'Arial'> " +
"<div class=Section1> " +
"<p class=MsoPlainText><span style='font-family:'Comic Sans MS''>Prezado fornecedor,<o:p></o:p></span></p> " +
"<p class=MsoPlainText><span style='font-family:'Comic Sans MS''><o:p>&nbsp;</o:p></span></p>" +
"<p class=MsoPlainText><span style='font-family:'Comic Sans MS''>SEGUE EM ANEXO PEDIDO DE COMPRA Nº " + tb_n_pedido.Text + " , DE " + tb_data_emissao.Text + "." +
        "<p class=MsoPlainText><span style='font-family:'Comic Sans MS''>CASO HAJA ALGUMA DIVERGÊNCIA ENTRAR EM CONTATO,<o:p></o:p></span></p>" +
"<p class=MsoPlainText><span style='font-family:'Comic Sans MS''>ATT,<o:p></o:p></span></p>" +
"<p class=MsoNormal><span style='font-size:10.0pt;font-family:'Comic Sans MS';" +
"mso-bidi-font-family:Arial'><o:p>&nbsp;</o:p></span></p>" +
"<p class=MsoNormal><span style='font-size:10.0pt;font-family:'Comic Sans MS';" +
"mso-no-proof:yes'>_________________________<br>" +
"Depto. Compras<br>" +
"NG Ferramentas<br>" +
"</div>" +
"</body>" +
"</html>";
            Email_pedido_compra novo_email = new Email_pedido_compra();
            bool _erro;
            novo_email.EnviarEmail(destinatario, _assunto, _mensagem, _caminho_arquivo, out _erro);
            if (_erro == false)
            {
                if (barra_status.Text == "Status Atual")
                    barra_status.Text = "";
                barra_status.Text = barra_status.Text + "Email enviado com sucesso. ";
                inserir_historico_email(detectar_email(), _caminho_arquivo, _assunto);
            }
            else
            {
                if (barra_status.Text == "Status Atual")
                    barra_status.Text = "";
                barra_status.Text = barra_status.Text + "Email não enviado. Favor verificar dados. ";
            }
        }

        private void inserir_historico_email(string destinatario, string caminho, string tipo)
        {
            try
            {
                this.datEmails_enviados.InsertCommand.CommandText =
                           "INSERT INTO EMAILS_ENVIADOS (DESTINATARIO_EMAIL_ENVIADO, DATA_EMAIL_ENVIADO, TIPO_EMAIL_ENVIADO, HORA_EMAIL_ENVIADO, CAMINHO_ARQUIVO_EMAIL_ENVIADO)" +
                           "VALUES ('" + destinatario + "','" + DateTime.Now.ToShortDateString().Replace("/", ".") + "','" + tipo + "','" + DateTime.Now.ToShortTimeString() + "','" + caminho + "')";
                this.fbConnection1.Open();
                this.datEmails_enviados.InsertCommand.Connection = fbConnection1;
                this.datEmails_enviados.InsertCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
            }
            catch
            {
                MessageBox.Show("Erro na inserção do histórico de emails enviados");
                fbConnection1.Close();
            }
        }

        private string detectar_email()
        {
            comando_select.CommandText = "SELECT EMAIL_FORN " +
                "FROM FORNECEDORES WHERE CNPJ_CPF_FORN = '" + tb_cnpj_forn.Text + "'";
            DataSet forn = new DataSet();
            fbConnection1.Open();

            datFornecedores.SelectCommand = comando_select;
            datFornecedores.Fill(forn);
            string fornecedor_atual = "";
            foreach (DataRow dr in forn.Tables[0].Rows)
            {

                fornecedor_atual = dr["EMAIL_FORN"].ToString();
            }

            this.fbConnection1.Close();
            return fornecedor_atual;

        }

        
        private void button8_Click(object sender, EventArgs e)
        {
            form_planos planos = new form_planos();
            try
            {
                planos.ShowDialog();

            }
            finally
            {
                tb_planos.Text = planos.nome_escolhido;

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            form_pesquisa_requisicao req = new form_pesquisa_requisicao();
            try
            {
                req.fazer_pedido_item = true;
                req.ShowDialog();
            }
            finally
            {
                tb_n_requisicao.Text = req.requisicao_escolhida;
            }
        }

        private void tb_item_item_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2:
                    localiza_item();
                    break;
            }
        }
    }
}