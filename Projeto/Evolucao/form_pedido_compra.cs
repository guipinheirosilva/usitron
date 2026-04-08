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
    public partial class form_pedido_compra : Form
    {
        public string cod_usuario;
        public bool abrir_pedido;
        public string n_pedido;
        public string cnpj_empresa;

        public form_pedido_compra(string cnpj_empresa)
        {
            this.cnpj_empresa = cnpj_empresa;
            InitializeComponent();
        }

        private void bt_localizar_forn_Click(object sender, EventArgs e)
        {
            //form_localiza_cliente cl = new form_localiza_cliente(true, cnpj_empresa);
           // form_localiza_forn localiza_forn = new form_localiza_forn(false, cnpj_empresa);
            form_localiza_cliente localiza_cliente = new form_localiza_cliente(true, cnpj_empresa);
            try
            {
                localiza_cliente.pesquisa_fornecedor = true;
                //localiza_cliente.nf = true;
                localiza_cliente.ShowDialog();
            }
            finally
            {

                localiza_cliente.Dispose();
                try
                {
                    string _nome_forn = "", _cnpj_forn = "";
                    comando_select.CommandText = "SELECT * FROM CLIENTES WHERE CNPJ = '" + localiza_cliente.cnpj_escolhido + "'";
                    DataSet forn = new DataSet();
                    fbConnection1.Open();
                    datFornecedores.SelectCommand = comando_select;
                    datFornecedores.Fill(forn);
                    fbConnection1.Close();
                    string iso, validade_iso, cliente, validade_cliente, nota;
                    foreach (DataRow dr in forn.Tables[0].Rows)
                    {
                        _nome_forn = dr["RAZAO_SOCIAL"].ToString();
                        _cnpj_forn = dr["CNPJ"].ToString();
                       // iso = dr["ISO_FORN"].ToString();
                      //  validade_iso = dr["VALIDADE_ISO_FORN"].ToString();
                     //   cliente = dr["CERT_UNI_FORN"].ToString();
                     //   validade_cliente = dr["VALIDADE_CERT_UNI_FORN"].ToString();
                    //    nota = dr["NOTA_CERT_UNI_FORN"].ToString();
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
                }
                catch
                {
                    fbConnection1.Close();
                }
            }
        }

        private void form_pedido_compra_Load(object sender, EventArgs e)
        {
            
            
            detectar_dados_empresa(out razao_social_empresa, out nome_fantasia_empresa, out cnpj_empresa, out ie_empresa, out im_empresa, out cnae_empresa, out endereco_empresa, out n_endereco_empresa,
      out complemento_empresa, out bairro_empresa, out cidade_empresa, out estado_empresa, out cep_empresa, out telefone_empresa, out cod_cidade_empresa, out pais_empresa,
      out cod_pais_empresa, out licenca_dll_nfe_empresa, out nome_certificado_nfe_empresa, out assunto_nfe_email_empresa, out smtp_nfe_empresa, out email_nfe_empresa,
      out senha_email_nfe_empresa, out logotipo_empresa, out proxy_empresa, out usuario_proxy_empresa, out senha_proxy_empresa, out crt_empresa, out portaEmailEmpresa, out sslEmpresa, out serie_empresa,
      out boleto_pedido_empresa, out cliente_inadimplente_empresa);

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
                    selecionar_faturas();
                }
                catch
                {
                    fbConnection1.Close();
                }
                

            }
        }

        private string buscar_nome_empresa(string cnpj_empresa)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT RAZAO_SOCIAL_EMPRESA FROM EMPRESA WHERE CNPJ_EMPRESA = '" + cnpj_empresa + "'";
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
            catch(Exception ex) 
            {
                fbConnection1.Close();
                MessageBox.Show(ex.Message);
                return "";
            }
        
        }

        string razao_social_empresa = "", nome_fantasia_empresa = "", ie_empresa = "", im_empresa = "", cnae_empresa = "", endereco_empresa = "", n_endereco_empresa = "",
          complemento_empresa = "", bairro_empresa = "", cidade_empresa = "", estado_empresa = "", cep_empresa = "", telefone_empresa = "", cod_cidade_empresa = "", pais_empresa = "",
          cod_pais_empresa = "", licenca_dll_nfe_empresa = "", nome_certificado_nfe_empresa = "", assunto_nfe_email_empresa = "", smtp_nfe_empresa = "", email_nfe_empresa = "",
          senha_email_nfe_empresa = "", logotipo_empresa = "", proxy_empresa = "", usuario_proxy_empresa = "", senha_proxy_empresa = "", crt_empresa = "", portaEmailEmpresa = "",
          sslEmpresa = "", serie_empresa = "", boleto_pedido_empresa = "", cliente_inadimplente_empresa = "", _cod_transmissao = "";

        private void detectar_dados_empresa(out string razao_social_empresa, out string nome_fantasia_empresa, out string cnpj_empresa, out string ie_empresa, out string im_empresa, out string cnae_empresa, out string endereco_empresa, out string n_endereco_empresa,
               out string complemento_empresa, out string bairro_empresa, out string cidade_empresa, out string estado_empresa, out string cep_empresa, out string telefone_empresa, out string cod_cidade_empresa, out string pais_empresa,
               out string cod_pais_empresa, out string licenca_dll_nfe_empresa, out string nome_certificado_nfe_empresa, out string assunto_nfe_email_empresa, out string smtp_nfe_empresa, out string email_nfe_empresa,
               out string senha_email_nfe_empresa, out string logotipo_empresa, out string proxy_empresa, out string usuario_proxy_empresa, out string senha_proxy_empresa,
       out string crt_empresa, out string portaEmailEmpresa, out string sslEmpresa, out string serie_empresa, out string boleto_pedido_empresa, out string cliente_inadimplente_empresa)
        {
            razao_social_empresa = ""; nome_fantasia_empresa = ""; cnpj_empresa = this.cnpj_empresa; ie_empresa = ""; im_empresa = ""; cnae_empresa = ""; endereco_empresa = ""; n_endereco_empresa = "";
            complemento_empresa = ""; bairro_empresa = ""; cidade_empresa = ""; estado_empresa = ""; cep_empresa = ""; telefone_empresa = ""; cod_cidade_empresa = ""; pais_empresa = "";
            cod_pais_empresa = ""; licenca_dll_nfe_empresa = ""; nome_certificado_nfe_empresa = ""; assunto_nfe_email_empresa = ""; smtp_nfe_empresa = ""; email_nfe_empresa = "";
            senha_email_nfe_empresa = ""; logotipo_empresa = ""; proxy_empresa = ""; usuario_proxy_empresa = ""; senha_proxy_empresa = ""; crt_empresa = ""; portaEmailEmpresa = "";
            sslEmpresa = ""; serie_empresa = ""; boleto_pedido_empresa = ""; cliente_inadimplente_empresa = "";
            try
            {
                FbCommand comando = new FbCommand();
                comando.Connection = fbConnection1;
                comando.CommandText = "SELECT * FROM EMPRESA where LICENCA_DLL_NFE_EMPRESA is not null and cnpj_empresa = '" + cnpj_empresa + "'";
                DataSet empresa = new DataSet();
                fbConnection1.Open();
                FbDataAdapter datEmpresa = new FbDataAdapter();

                datEmpresa.SelectCommand = comando;
                datEmpresa.Fill(empresa);
                fbConnection1.Close();
                foreach (DataRow dr in empresa.Tables[0].Rows)
                {

                    razao_social_empresa = dr["RAZAO_SOCIAL_EMPRESA"].ToString();
                    nome_fantasia_empresa = dr["NOME_FANTASIA_EMPRESA"].ToString();
                    // cnpj_empresa = dr["CNPJ_EMPRESA"].ToString().Replace(".", "").Replace("/", "").Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
                    ie_empresa = dr["IE_EMPRESA"].ToString().Replace(".", "").Replace("/", "").Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
                    im_empresa = dr["IM_EMPRESA"].ToString().Replace(".", "").Replace("/", "").Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
                    cnae_empresa = dr["CNAE_EMPRESA"].ToString().Replace(".", "").Replace("/", "").Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
                    endereco_empresa = dr["ENDERECO_EMPRESA"].ToString();
                    n_endereco_empresa = dr["N_ENDERECO_EMPRESA"].ToString();
                    complemento_empresa = dr["COMPLEMENTO_EMPRESA"].ToString();
                    bairro_empresa = dr["BAIRRO_EMPRESA"].ToString();
                    cidade_empresa = dr["CIDADE_EMPRESA"].ToString();
                    estado_empresa = dr["ESTADO_EMPRESA"].ToString();
                    cep_empresa = dr["CEP_EMPRESA"].ToString().Replace(".", "").Replace("/", "").Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
                    telefone_empresa = dr["TELEFONE_EMPRESA"].ToString().Replace(".", "").Replace("/", "").Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
                    cod_cidade_empresa = dr["COD_CIDADE_EMPRESA"].ToString();
                    pais_empresa = dr["PAIS_EMPRESA"].ToString();
                    cod_cidade_empresa = dr["COD_CIDADE_EMPRESA"].ToString();
                    licenca_dll_nfe_empresa = dr["LICENCA_DLL_NFE_EMPRESA"].ToString();
                    nome_certificado_nfe_empresa = dr["NOME_CERTIFICADO_NFE_EMPRESA"].ToString();
                    assunto_nfe_email_empresa = dr["ASSUNTO_NFE_EMAIL_EMPRESA"].ToString();
                    smtp_nfe_empresa = dr["SMTP_NFE_EMPRESA"].ToString();
                    email_nfe_empresa = dr["EMAIL_NFE_EMPRESA"].ToString();
                    senha_email_nfe_empresa = dr["SENHA_EMAIL_NFE_EMPRESA"].ToString();
                    logotipo_empresa = dr["LOGOTIPO_EMPRESA"].ToString();
                    proxy_empresa = dr["PROXY_EMPRESA"].ToString();
                    usuario_proxy_empresa = dr["USUARIO_PROXY_EMPRESA"].ToString();
                    senha_proxy_empresa = dr["SENHA_PROXY_EMPRESA"].ToString();
                    crt_empresa = dr["CRT_EMPRESA"].ToString();
                    try
                    {
                        portaEmailEmpresa = dr["PORTA_EMAIL_EMP"].ToString();
                    }
                    catch { }
                    try
                    {
                        sslEmpresa = dr["SSL_EMP"].ToString();
                    }
                    catch { }

                    serie_empresa = dr["SERIE_EMPRESA"].ToString();
                    try
                    {
                        boleto_pedido_empresa = dr["BOLETO_PEDIDO_EMPRESA"].ToString();
                    }
                    catch { }
                    try
                    {
                        cliente_inadimplente_empresa = dr["CLIENTE_INADIMPLENTE_EMPRESA"].ToString();
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

        private void button5_Click(object sender, EventArgs e)
        {
            dsItens_ped.Clear();
            dsPedido_compra.Clear();

           
            this.datPedido_compra.InsertCommand.CommandText =
                "INSERT INTO PEDIDO_COMPRA (NOME_FORN_PED, CNPJ_EMISSOR_PED, RAZAO_EMISSOR_PED)" +
                "VALUES ('NOVO','" + cnpj_empresa + "','" + razao_social_empresa + "') RETURNING COD_PED";
            this.fbConnection1.Open();
            this.datPedido_compra.InsertCommand.Connection = fbConnection1;
            object cod = datPedido_compra.InsertCommand.ExecuteScalar();
            this.fbConnection1.Close();

            try
            {

                this.datPedido_compra.SelectCommand.CommandText =
                    "SELECT * FROM PEDIDO_COMPRA WHERE COD_PED = '" + cod + "'";
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
            if (tb_nome_autorizante.Text != "")
                MessageBox.Show("Não é possível alterar pedido autorizado");
            else
            {
                if (dgvItens_ped.Rows.Count > 0)
                {
                    MessageBox.Show("Não é possível excluir pedido com itens lançados. Exclua os itens antes");
                }
                else
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
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tb_cnpj_empresa.Text == "")
                MessageBox.Show("Coloque a empresa emissora por favor");
            else
            {
                if (tb_nome_autorizante.Text != "")
                    MessageBox.Show("Não é possível alterar pedido autorizado");
                else
                {
                    if (tb_data_emissao.Text == "")
                        tb_data_emissao.Text = DateTime.Now.ToShortDateString();
                    update_itens_ped();
                    Atualizar();
                }
            }
            
        }

        private void update_itens_ped()
        {
            try
            {
                string _cnpj_forn = "null", _data_prevista = "null", _nome_forn = "null";
                if (tb_cnpj_forn.Text != "")
                {
                    _cnpj_forn = "'" + tb_cnpj_forn.Text + "'";
                }
                if (tb_data_entrega.Text != "")
                {
                    _data_prevista = "'" + Convert.ToDateTime(tb_data_entrega.Text)
                                    .ToShortDateString().Replace("/", ".") + "'";
                }
                if (tb_nome_forn.Text != "")
                {
                    _nome_forn = "'" + tb_nome_forn.Text + "'";
                }

                datItens_ped.UpdateCommand.CommandText =
                    "UPDATE ITENS_PEDIDO_COMPRA SET FORNECEDOR_ITEM_PED = " + _cnpj_forn +
                    ", DATA_LIMITE_ITEM_PED = " + _data_prevista +
                    ", NOME_FORNECEDOR_ITEM_PED = " + _nome_forn +
                    " WHERE N_PEDIDO_ITEM_PED = '" + tb_n_pedido.Text + "'";
                fbConnection1.Open();
                datItens_ped.UpdateCommand.Connection = fbConnection1;
                datItens_ped.UpdateCommand.ExecuteNonQuery();
                fbConnection1.Close();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }


        private void Atualizar()
        {
            try
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
                this.BindingContext[dsFatura_pc, "FATURA_PC"].EndCurrentEdit();
                if (dsFatura_pc.HasChanges())
                {
                    fbConnection1.Open();
                    datFatura_pc.UpdateCommand = cbFatura_pc.GetUpdateCommand();
                    datFatura_pc.InsertCommand = cbFatura_pc.GetInsertCommand();
                    datFatura_pc.DeleteCommand = cbFatura_pc.GetDeleteCommand();
                    datFatura_pc.Update(dsFatura_pc, "FATURA_PC");
                    dsFatura_pc.AcceptChanges();
                    fbConnection1.Close();
                }
                MessageBox.Show("Salvo!");

            }
            catch (Exception ex)
            {
                fbConnection1.Close();
                MessageBox.Show(ex.Message);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            form_localiza_ped ped = new form_localiza_ped();
            try
            {
                ped.cod_usuario = cod_usuario;
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
                    selecionar_faturas();
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
            btnLiberar.Visible = false;
            if (tb_nome_autorizante.Text != "")
            {
                bt_enviar_email.Visible = true;
                bt_imprimir.Visible = true;
                btnLiberar.Visible = true;
            }
        }

        private void bt_inserir_Click(object sender, EventArgs e)
        {
            if (tb_nome_autorizante.Text != "")
                MessageBox.Show("Não é possível alterar pedido autorizado");
            else
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

                                if (_op != "")
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
                                    _peso = "'" + Convert.ToString(tb_peso.Text) + "'";
                                }
                                else
                                {
                                    _peso = "null";
                                }




                                this.datItens_ped.InsertCommand.CommandText =
                                   "INSERT INTO ITENS_PEDIDO_COMPRA (N_PEDIDO_ITEM_PED, COD_ITEM_REQ_ITEM_PED, OP_ITEM_PED, POSICAO_ITEM_PED, QTDE_ITEM_PED, PESO_ITEM_PED, UNID_ITEM_PED, VALOR_UNIT_ITEM_PED, " +
                                   "VALOR_TOTAL_ITEM_PED, COD_ESTOQUE_ITEM_PED, ITEM_ITEM_PED, DESCRICAO_ITEM_PED, DATA_LIMITE_ITEM_PED, PLANO_ITEM_PED) " +
                                   "VALUES ('" + tb_n_pedido.Text + "','" + tb_item_n_pedido.Text + "'," + op + "," + pos + "," + _qtde.Replace(",", ".") + "," + _peso.Replace(",", ".") + ",'" + tb_unidade.Text + "','" + tb_valor_unit.Text.Replace(".", "").Replace(",", ".") + "','" +
                                   valor_total.ToString("n2").Replace(".", "").Replace(",", ".") + "'," + _cod_item + "," + item + ",'" + tb_descricao_item.Text + "'," + data_limite + "," + plano + ")";
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
                            if (tb_cod_item.Text != "")
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
                                   "VALUES ('" + tb_n_pedido.Text + "'," + _os + "," + _pos + ",'" + Convert.ToDouble(tb_qtde.Text).ToString().Replace(".", "").Replace(",", ".") +
                                   "','" + tb_unidade.Text + "','" + tb_valor_unit.Text.Replace(".", "").Replace(",", ".") + "','" +
                                   valor_total.ToString("n2").Replace(".", "").Replace(",", ".") + "'," + _cod_item + "," + _item + ",'" + tb_descricao_item.Text + "'," + plano + ")";
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

        }



        private void tb_descricao_item_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void localiza_item()
        {
            //form_pesquisa_requisicao localiza_item = new form_pesquisa_requisicao(cnpj_empresa);
            //try
            //{
            //    localiza_item.fazer_pedido_item = true;
            //    localiza_item.ShowDialog();
            //}
            //finally
            //{
            //    localiza_item.Dispose();
            //    if (localiza_item.cod_escolhido == "")
            //    {
            //        tb_descricao_item.Text = localiza_item.descricao_escolhido;
            //        MessageBox.Show("Esse item não está vinculado a nenhum item do estoque");
            //    }
            //    else
            //    {
            //        tb_descricao_item.Text = localiza_item.descricao_escolhido;
            //        tb_cod_item.Text = localiza_item.cod_item_escolhido;
            //        tb_item_n_pedido.Text = localiza_item.cod_escolhido;
            //        tb_qtde.Text = localiza_item.qtde_escolhida;
            //        tb_unidade.Text = localiza_item.unid_escolhida;
            //        tb_item_item.Text = localiza_item.item_escolhido;
                    
            //    }
            //}
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
                { }
                else
                {
                    tb_descricao_item.Text = localiza_item.descricao_produto_escolhido;
                    tb_cod_item.Text = localiza_item.cod_produto_escolhido;
                    tb_item_item.Text = localiza_item.cod_forn;
                    tb_unidade.Text = localiza_item.unidade_produto_escolhido;
                    tb_valor_unit.Text = localiza_item.preco_unit_produto;

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
                    double valor_frete = 0;
                    if (dgvItens_ped.Rows[i].Cells["col_peso"].Value.ToString() != "")
                    {
                        valor_parcial = Convert.ToDouble(dgvItens_ped.Rows[i].Cells["col_valor_unit"].Value) * Convert.ToDouble(dgvItens_ped.Rows[i].Cells["col_peso"].Value);
                    }
                    else
                    {
                        valor_parcial = Convert.ToDouble(dgvItens_ped.Rows[i].Cells["col_valor_unit"].Value) * Convert.ToDouble(dgvItens_ped.Rows[i].Cells["col_qtde"].Value);
                    }
                    try
                    {
                        valor_frete = Convert.ToDouble(dgvItens_ped.Rows[i].Cells["col_frete"].Value);
                    }
                    catch
                    {
                        valor_frete = 0;
                    }
                    dgvItens_ped.Rows[i].Cells["col_valor_total"].Value = valor_parcial.ToString("n2").Replace(".", "");
                    valor_total = valor_total + valor_parcial + valor_frete;
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
                try
                {
                    valor_total = valor_total - Convert.ToDouble(tb_desconto.Text);
                }
                catch { }
                tb_valor_total.Text = valor_total.ToString("n2");
            }
            catch
            {
                MessageBox.Show("Confira os valores por favor");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (tb_nome_autorizante.Text != "")
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


                            tb_nome_autorizante.Text = "";
                            tb_data_autorizacao.Text = "";
                            tb_hora_autorizacao.Text = "";
                            cbAutorizado.Checked = false;
                            bt_imprimir.Visible = false;
                            bt_enviar_email.Visible = false;
                            atualizar_requisicoes("AGUARDANDO AUTORIZAÇÃO NO PEDIDO DE COMPRA");
                            apagar_itens_cr_pedido();
                            
                            Atualizar();
                        }
                        else
                        {
                            MessageBox.Show("Esse usuário não tem acesso a esse recurso");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Pedido não está autorizado");
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

        private bool verificar_certificacao(string cnpj)
        {
            try
            {
                comando_select.CommandText = "SELECT * FROM FORNECEDORES WHERE CNPJ_CPF_FORN = '" + cnpj + "'";
                DataSet forn = new DataSet();
                fbConnection1.Open();
                datFornecedores.SelectCommand = comando_select;
                datFornecedores.Fill(forn);
                fbConnection1.Close();
                string iso = "", validade_iso = "", cliente = "", validade_cliente = "", nota = "0";
                foreach (DataRow dr in forn.Tables[0].Rows)
                {
                    iso = dr["ISO_FORN"].ToString();
                    validade_iso = dr["VALIDADE_ISO_FORN"].ToString();
                    cliente = dr["CERT_UNI_FORN"].ToString();
                    validade_cliente = dr["VALIDADE_CERT_UNI_FORN"].ToString();
                    nota = dr["NOTA_CERT_UNI_FORN"].ToString();
                }
                bool retorno = false;
                if (iso == "1")
                {
                    if (Convert.ToDateTime(validade_iso) > DateTime.Now)
                        retorno = true;
                }
                else
                {
                    if (cliente == "1")
                    {
                        if (Convert.ToDateTime(validade_cliente) > DateTime.Now && Convert.ToDouble(nota) > 60)
                            retorno = true;
                    }
                }
                return retorno;
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
                return false;
            }
        }

        private void apagar_itens_cr_pedido()
        {
            try
            {
                FbCommand delete = new FbCommand();
                delete.Connection = fbConnection1;
                delete.CommandText = 
                    "DELETE FROM CONTAS_A_PAGAR WHERE NF_CP = '" + tb_n_pedido.Text + "' AND ORIGEM_CP = 'PC'";
                fbConnection1.Open();
                FbDataAdapter datDelete = new FbDataAdapter();
                datDelete.DeleteCommand = delete;
                datDelete.DeleteCommand.ExecuteNonQuery();
                fbConnection1.Close();
               

            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void detectar_numero_vencimentos_fatura(out int n_venc)
        {
            try
            {
                comando_select.CommandText = "SELECT * " +
                    "FROM FATURA_PC WHERE N_PEDIDO_FATURA_PC = '" + tb_n_pedido.Text + "'";
                DataSet fatura = new DataSet();
                fbConnection1.Open();
                datFatura_pc.SelectCommand = comando_select;
                datFatura_pc.Fill(fatura);
                int n = 0;
                foreach (DataRow dr in fatura.Tables[0].Rows)
                {

                    _cod[n] = dr["COD_FATURA_PC"].ToString();
                    _valores[n] = dr["VALOR_FATURA_PC"].ToString();
                    _datas[n] = dr["DATA_VENC_FATURA_PC"].ToString();
                    n++;

                }

                this.fbConnection1.Close();
                n_venc = n;
            }
            catch
            {
                fbConnection1.Close();
                n_venc = 0;
            }
        }

       

        string[] _datas = new string[50];
        string[] _valores = new string[50];
        string[] _cod = new string[50];

        private void inserir_duplicatas_cr()
        {
            apagar_itens_cr_pedido();
            int _n_vencimentos;
            //a parada é 6 pois é o numero máximo de parcelas
            for (int i = 0; i < 6; i++)
            {
                _cod[i] = ""; _datas[i] = ""; _valores[i] = "";
            }
            detectar_numero_vencimentos_fatura(out _n_vencimentos);

            for (int i = 0; i < _n_vencimentos; i++)
            {
                try
                {
                    DateTime _data = Convert.ToDateTime(_datas[i]);
                    double _valor = Convert.ToDouble(_valores[i]);
                    string _nome_forn = "null", _cod_forn = "null";
                   
                    FbCommand comando_select = new FbCommand();
                    comando_select.Connection = fbConnection1;
                    comando_select.CommandText = "SELECT * FROM CLIENTES WHERE CNPJ LIKE '" + tb_cnpj_forn.Text + "'";
                    DataSet forn = new DataSet();
                    fbConnection1.Open();
                    FbDataAdapter datForn = new FbDataAdapter();
                    datForn.SelectCommand = comando_select;
                    datForn.Fill(forn);
                    fbConnection1.Close(); 
                    foreach (DataRow dr in forn.Tables[0].Rows)
                    {
                        _nome_forn = "'" + dr["RAZAO_SOCIAL"].ToString() + "'";
                        _cod_forn = "'" + dr["COD_CLIENTE"].ToString() + "'";
                    }
                    string plano = "";
                    string cod_plano = "";

                    plano = tb_planos.Text;
                    cod_plano = buscar_cod_plano(plano);
                    if (plano != "null")
                        plano = "'" + plano + "'";
                    if (cod_plano != "null")
                        cod_plano = "'" + cod_plano + "'";
                    int dup = i + 1;
                    string descricao_cp = "Duplic.: " + dup.ToString() + " ref. Pedido de Compra: " + tb_n_pedido.Text;

                    string pessoa = "";
                    buscar_pessoa(tb_n_pedido.Text, out pessoa);


                    FbCommand insert = new FbCommand();
                    insert.Connection = fbConnection1;
                    fbConnection1.Open();
                    insert.CommandText =
                        "INSERT INTO CONTAS_A_PAGAR (DATA_PREVISTA_CP, VALOR_CP, COD_FORNECEDOR_CP, RAZAO_FORNECEDOR_CP, DESCRICAO_CP, DUPLICATA_CP, NF_CP, PLANO_CP, COD_PLANO_CP, ORIGEM_CP, STATUS_CP, PESSOA_CP) " +
                         "VALUES " +
                         "('" + _data.ToShortDateString().Replace("/", ".") + "','" + _valor.ToString("n2").Replace(".", "").Replace(",", ".") + "'," + _cod_forn + "," + _nome_forn +
                         ",'" + descricao_cp +
                         "','" + dup.ToString() + "/" + dgvFatura_pc.RowCount.ToString() + "','" + tb_n_pedido.Text + "'," + plano + "," + cod_plano + ",'PC', 'PROVISIONADO','" + pessoa + "')";
                    FbDataAdapter datContas_a_pagar = new FbDataAdapter();
                    datContas_a_pagar.InsertCommand = insert;
                    datContas_a_pagar.InsertCommand.ExecuteNonQuery();
                    fbConnection1.Close(); 
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.ToString());
                    fbConnection1.Close(); 
                }
            
            }
            selecionar_faturas();

        }

        private void buscar_pessoa(string cod_pedido, out string pessoa)
        {
            pessoa = "0";
            if (cod_pedido != "")
            {
                try
                {
                    FbCommand comando_select = new FbCommand();
                    comando_select.Connection = fbConnection1;
                    comando_select.CommandText = @"SELECT COD_EMPRESA FROM EMPRESA emp
                INNER JOIN PEDIDO_COMPRA pc on pc.CNPJ_EMISSOR_PED = emp.CNPJ_EMPRESA
                WHERE COD_PED = '" + cod_pedido + "'";
                    DataSet forn = new DataSet();
                    fbConnection1.Open();
                    FbDataAdapter datForn = new FbDataAdapter();
                    datForn.SelectCommand = comando_select;
                    datForn.Fill(forn);
                    fbConnection1.Close();
                    foreach (DataRow dr in forn.Tables[0].Rows)
                    {
                        pessoa = dr[0].ToString();
                    }
                    if (pessoa == "0")
                        MessageBox.Show("Pedido sem empresa emissora cadastrada");
                }
                catch (Exception ex)
                {
                    fbConnection1.Close();
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private string buscar_cod_plano(string plano)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT COD_PLANO FROM PLANOS " +
                    " WHERE NOME_PLANO = '" + plano + "'";
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
                return "0";
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
                return "0";
            }
        }

        private void selecionar_faturas()
        {
            try
            {
                //dsFped.Clear();
                dsFatura_pc.Clear();
                FbCommand select = new FbCommand();
                select.CommandText = "SELECT * FROM FATURA_PC WHERE  N_PEDIDO_FATURA_PC = '" + tb_n_pedido.Text + "'";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                datSelect.Fill(FATURA_PC);
                fbConnection1.Close();

            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (tb_cnpj_empresa.Text == "")
            {
                MessageBox.Show("É necessário selecionar a empresa emissora do pedido");
                tb_cnpj_empresa.BackColor = Color.Orange;
                tb_cnpj_empresa.Focus();
            }
            else
            {
                if (tb_planos.Text == "")
                {
                    MessageBox.Show("Selecione o Plano de Contas");
                    tb_planos.BackColor = Color.Orange;
                    tb_planos.Focus();
                }
                else
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
                                    inserir_duplicatas_cr();
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
            }

        }
        private void atualizar_requisicoes(string _posicao_atual)
        {

            for (int i = 0; i < dgvItens_ped.RowCount; i++)
            {
                try
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
                    if (dgvItens_ped.Rows[i].Cells["col_cod_estoque"].Value.ToString() != "")
                    {
                        classeEstoque estoque = new classeEstoque();
                        estoque.fbConnection1.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=10.3.3.4;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
                        estoque.calcular_estoque(dgvItens_ped.Rows[i].Cells["ITEM_ITEM_PED"].Value.ToString());

                    }
                }
                catch (Exception ex)
                {
                    fbConnection1.Close();
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
                    form_requisicao requisicao = new form_requisicao(cnpj_empresa);
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
                dsImp_pedido_compra imprimir = new dsImp_pedido_compra();
                this.datPedido_compra.SelectCommand.CommandText =
                    "SELECT * FROM PEDIDO_COMPRA WHERE COD_PED = '" + tb_n_pedido.Text + "'";
                this.fbConnection1.Open();
                this.datPedido_compra.SelectCommand.Connection = fbConnection1;
                this.datPedido_compra.SelectCommand.ExecuteNonQuery();
                this.fbConnection1.Close();

                this.datItens_ped.SelectCommand.CommandText =
                "SELECT * FROM ITENS_PEDIDO_COMPRA WHERE N_PEDIDO_ITEM_PED = '" + tb_n_pedido.Text + "' ORDER BY cod_item_ped";
                this.fbConnection1.Open();
                this.datItens_ped.SelectCommand.Connection = fbConnection1;
                this.datItens_ped.SelectCommand.ExecuteNonQuery();
                this.fbConnection1.Close();

                try
                {
                    FbCommand select = new FbCommand();
                    select.Connection = fbConnection1;
                    fbConnection1.Open();
                    select.CommandText =
                            "SELECT * FROM CLIENTES WHERE CNPJ = '" + tb_cnpj_forn.Text + "'";
                    FbDataAdapter datSelect = new FbDataAdapter();
                    datSelect.SelectCommand = select;
                    DataTable dtSelect = new DataTable();
                    datSelect.Fill(imprimir.CLIENTES);
                    fbConnection1.Close();
                   
                }
                catch (Exception a)
                {
                    fbConnection1.Close();
                }

               

                FbCommand selectEmpresa = new FbCommand();
                selectEmpresa.Connection = fbConnection1;
                selectEmpresa.CommandText =
                    "SELECT * FROM EMPRESA WHERE CNPJ_EMPRESA = '" + tb_cnpj_empresa.Text + "'";
               // FbDataAdapter datSelect = new FbDataAdapter();
                fbConnection1.Open();
                FbDataAdapter datSelectEmpresa = new FbDataAdapter();
                datSelectEmpresa.SelectCommand = selectEmpresa;
                datSelectEmpresa.Fill(imprimir.EMPRESA);
                fbConnection1.Close();

                fbConnection1.Open();
                datPedido_compra.Fill(imprimir.PEDIDO_COMPRA);
                datItens_ped.Fill(imprimir.ITENS_PEDIDO_COMPRA);
               // datFornecedores.Fill(imprimir.CLIENTES);
                fbConnection1.Close();
               
                    crPedido_compra novo_ped = new crPedido_compra();
                    novo_ped.SetDataSource(imprimir);
                    form_imprimir imprime = new form_imprimir(novo_ped);
                    imprime.n_pedido_compra = tb_n_pedido.Text;
                    imprime.pedido_compra = true;
                    imprime.Show();
                    
                
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
            if (tb_nome_autorizante.Text != "")
                MessageBox.Show("Não é possível alterar pedido autorizado");
            else
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
                        comando_select.CommandText = "SELECT * FROM ITENS_REQUISICAO WHERE COD_REQ_ITEM_REQ = '" + tb_n_requisicao.Text + "' ORDER BY cod_item_req";
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



                                    this.datItens_ped.InsertCommand.CommandText =
                                       "INSERT INTO ITENS_PEDIDO_COMPRA (N_PEDIDO_ITEM_PED, COD_ITEM_REQ_ITEM_PED, OP_ITEM_PED, POSICAO_ITEM_PED, QTDE_ITEM_PED, UNID_ITEM_PED, " +
                                       "COD_ESTOQUE_ITEM_PED, ITEM_ITEM_PED, DESCRICAO_ITEM_PED, DATA_LIMITE_ITEM_PED, PLANO_ITEM_PED) " +
                                       "VALUES ('" + tb_n_pedido.Text + "','" + _cod[i] + "'," + op + "," + pos + ",'" + _qtde[i].Replace(",", ".") + "','" + _unid[i] + "'," +
                                       _cod_est + "," + _item_1 + ",'" + _descricao[i] + "'," + data_limite + "," + plano + ")";
                                    this.fbConnection1.Open();
                                    this.datItens_ped.InsertCommand.Connection = fbConnection1;
                                    this.datItens_ped.InsertCommand.ExecuteNonQuery();
                                    this.fbConnection1.Close();

                                    dsItens_ped.Clear();
                                    this.datItens_ped.SelectCommand.CommandText =
                                    "SELECT * FROM ITENS_PEDIDO_COMPRA WHERE N_PEDIDO_ITEM_PED = '" + tb_n_pedido.Text + "' ORDER BY cod_item_ped";
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
                    }
                }
            }

        }

        private void bt_enviar_email_Click(object sender, EventArgs e)
        {
            enviar_email();
        }

        private void enviar_email()
        {
            string _email, _senha_email;
            buscar_email(cod_usuario, out _email, out _senha_email);
            string _caminho_arquivo = "c:\\evolucao\\PEDIDOS_COMPRA\\" + "PEDIDO_" + tb_n_pedido.Text + ".pdf";
            string _assunto = nome_fantasia_empresa +": PEDIDO DE COMPRA Nº" + tb_n_pedido.Text + "";
            string boa = "Bom dia, ";
            if (DateTime.Now > Convert.ToDateTime(DateTime.Now.ToShortDateString() + " " + "12:00:00"))
                boa = "Boa tarde, ";
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
"<title>Pedido Compra</title>" +
"</head>" +
"<body>" +
"<font size='2' face='tahoma' color='black'>" +

"<div class=Section1> " +
boa + " <br>" +

"Prezado fornecedor, <br> " +

"Segue anexo pedido de compra nº " + tb_n_pedido.Text + " , de " + tb_data_emissao.Text + ".<br>" +
"Favor confirmar o pedido e a data de entrega.<br><br>" +

"Caso haja alguma divergência entrar em contato, <br>" +

"Atenciosamente, <br>" +
"</font>" +
"<table><tr><font family = 'Berlin Sans FB','sans-serif' color='#365F91',font-weight: bold> " +
"<td> " +
"<span style='font-size:12.0pt;font-family:'Berlin Sans FB','sans-serif';color:#365F91'>Departamento de Compras</span><br>" +
"<span style='font-size:12.0pt;font-family:Wingdings;color:#365F91'>(</span><span style='font-size:12.0pt;font-family:'Berlin Sans FB','sans-serif';color:#365F91'>" + telefone_empresa + "</span><span style='font-size:12.0pt;color:#365F91'></span><br> " +
"<span style='font-size:12.0pt;font-family:Wingdings;color:#365F91'>*</span><span style='font-size:12.0pt;font-family:'Berlin Sans FB','sans-serif';color:#365F91'>" + _email + "</span> <br> " +
                //"<p><img src='cid:atual'/></p>" +
"</td>" +
"</table>" +

"</div>" +
"</body>" +
"</html>";

          

            Email_pedido_compra novo_email = new Email_pedido_compra();
            novo_email.cnpj_empresa = cnpj_empresa;
            novo_email._email = _email;
            novo_email._senha_email = _senha_email;
            bool _erro;
            novo_email.EnviarEmail(detectar_email(), _assunto, _mensagem, _caminho_arquivo, out _erro);
            if (_erro == false)
            {
                if (barra_status.Text == "Status Atual")
                    barra_status.Text = "";
                barra_status.Text = barra_status.Text + "Email enviado com sucesso. ";
                inserir_historico_email(detectar_email(), _caminho_arquivo, _assunto);
                baixar_pedido();
            }
            else
            {
                if (barra_status.Text == "Status Atual")
                    barra_status.Text = "";
                barra_status.Text = barra_status.Text + "Email não enviado. Favor verificar dados. ";
            }
        }

        private void buscar_email(string usuario_atual, out string _email, out string _senha_email)
        {
            _email = "";
            _senha_email = "";

            try
            {
                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT EMAIL_USUARIO, SENHA_EMAIL_USUARIO FROM USUARIOS " +
                    " WHERE COD_USUARIO = '" + usuario_atual + "'";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    _email = dr[0].ToString();
                    _senha_email = dr[1].ToString();
                }

            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
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
            comando_select.CommandText = "SELECT EMAIL " +
                "FROM CLIENTES WHERE CNPJ = '" + tb_cnpj_forn.Text + "'";
            DataSet forn = new DataSet();
            fbConnection1.Open();

            datFornecedores.SelectCommand = comando_select;
            datFornecedores.Fill(forn);
            string fornecedor_atual = "";
            foreach (DataRow dr in forn.Tables[0].Rows)
            {

                fornecedor_atual = dr["EMAIL"].ToString();
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

        private void btnLiberar_Click(object sender, EventArgs e)
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
                        this.datPedido_compra.UpdateCommand.CommandText =
                                "UPDATE PEDIDO_COMPRA SET NOME_AUTORIZANTE_PED = NULL WHERE COD_PED = " + tb_n_pedido.Text + "";
                        this.fbConnection1.Open();
                        this.datPedido_compra.UpdateCommand.Connection = fbConnection1;
                        this.datPedido_compra.UpdateCommand.ExecuteNonQuery();
                        this.fbConnection1.Close();

                        this.datPedido_compra.UpdateCommand.CommandText =
                                "UPDATE PEDIDO_COMPRA SET DATA_AUTORIZACAO_PED = NULL WHERE COD_PED = " + tb_n_pedido.Text + "";
                        this.fbConnection1.Open();
                        this.datPedido_compra.UpdateCommand.Connection = fbConnection1;
                        this.datPedido_compra.UpdateCommand.ExecuteNonQuery();
                        this.fbConnection1.Close();

                        this.datPedido_compra.UpdateCommand.CommandText =
                                "UPDATE PEDIDO_COMPRA SET HORA_AUTORIZACAO_PED = NULL WHERE COD_PED = " + tb_n_pedido.Text + "";
                        this.fbConnection1.Open();
                        this.datPedido_compra.UpdateCommand.Connection = fbConnection1;
                        this.datPedido_compra.UpdateCommand.ExecuteNonQuery();
                        this.fbConnection1.Close();

                        this.datPedido_compra.UpdateCommand.CommandText =
                                "UPDATE PEDIDO_COMPRA SET AUTORIZADO_PED = NULL WHERE COD_PED = " + tb_n_pedido.Text + "";
                        this.fbConnection1.Open();
                        this.datPedido_compra.UpdateCommand.Connection = fbConnection1;
                        this.datPedido_compra.UpdateCommand.ExecuteNonQuery();
                        this.fbConnection1.Close();

                        this.datPedido_compra.UpdateCommand.CommandText =
                                "UPDATE PEDIDO_COMPRA SET EFETUADO_PED = NULL WHERE COD_PED = " + tb_n_pedido.Text + "";
                        this.fbConnection1.Open();
                        this.datPedido_compra.UpdateCommand.Connection = fbConnection1;
                        this.datPedido_compra.UpdateCommand.ExecuteNonQuery();
                        this.fbConnection1.Close();

                        //************** cbAutorizado_diretoria.Checked = false;
                        //cbAutorizado_requisitante.Checked = false;
                        //************** cbEfetuado.Checked = false;
                        for (int i = 0; i < dgvItens_ped.RowCount; i++)
                            /*
             tb_nome_autorizante.Text = "";
             tb_data_autorizacao.Text = "";
             tb_hora_autorizacao.Text = "";
             cbAutorizado_diretoria.Checked = false;
             tb_nome_autorizante_req.Text = "";
             tb_data_autorizacao_req.Text = "";
             tb_hora_autorizacao_req.Text = "";
                         
             cbAutorizado_requisitante.Checked = false;
            */
                            cb_efetuado.Checked = false;
                        cbAutorizado.Checked = false;

                        bt_imprimir.Visible = false;
                        bt_enviar_email.Visible = false;
                        btnLiberar.Visible = false;
                        atualizar_requisicoes("AGUARDANDO AUTORIZAÇÃO NO PEDIDO DE COMPRA");
                        datPedido_compra.Fill(PEDIDO_COMPRA);
                        dsItens_ped.Clear();
                        datItens_ped.Fill(ITENS_PEDIDO_COMPRA);
                        Atualizar();
                    }
                    else
                    {
                        MessageBox.Show("Esse usuário não tem acesso a esse recurso");
                    }

                }
            }
        }

        private void tb_cod_item_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                FbCommand selectItemEstoque = new FbCommand();
                FbDataAdapter datItemEstoque = new FbDataAdapter();
                DataTable dtItemEstoque = new DataTable();

                try
                {
                    /*SELECIONAR O ITEM DO ESTOQUE CORRESPONDENTE AO CÓDIGO DIGITADO*/
                    selectItemEstoque.CommandText =
                        "select e.item_estoque, e.descricao_estoque, e.unidade_estoque " +
                        "from estoque e " +
                        "where cod_estoque = " + tb_cod_item.Text;
                    datItemEstoque.SelectCommand = selectItemEstoque;
                    datItemEstoque.SelectCommand.Connection = fbConnection1;
                    fbConnection1.Open();
                    datItemEstoque.SelectCommand.ExecuteNonQuery();
                    datItemEstoque.Fill(dtItemEstoque);
                    fbConnection1.Close();

                    /*SETAR A DESCRIÇÃO DO ITEM E A UNIDADE DE MEDIDA NOS CAMPOS DE TEXTO*/
                    tb_descricao_item.Text = dtItemEstoque.Rows[0]["descricao_estoque"].ToString();
                    tb_item_item.Text = dtItemEstoque.Rows[0]["item_estoque"].ToString();
                    tb_unidade.Text = dtItemEstoque.Rows[0]["unidade_estoque"].ToString();

                    /*FOCO NA QUANTIDADE*/
                    tb_qtde.Focus();
                }
                catch (Exception a)
                {
                    fbConnection1.Close();
                    MessageBox.Show("Houve um erro ao buscar o item no estoque!\nErro: " + a.Message);
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < dgvItens_ped.RowCount; i++)
            {
                dgvItens_ped.Rows[i].Cells["col_chegou"].Value = dgvItens_ped.Rows[0].Cells["col_chegou"].Value;
                dgvItens_ped.Rows[i].Cells["col_nf"].Value = dgvItens_ped.Rows[0].Cells["col_nf"].Value;
                dgvItens_ped.Rows[i].Cells["col_data_chegada"].Value = dgvItens_ped.Rows[0].Cells["col_data_chegada"].Value;
                dgvItens_ped.Rows[i].Cells["col_resp_chegada"].Value = dgvItens_ped.Rows[0].Cells["col_resp_chegada"].Value;
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
             
            form_localiza_req req = new form_localiza_req();
            try
            {
                req.ShowDialog();
               
            }
            finally
            {   
                tb_n_requisicao.Text = req.req_escolhida.ToString();
                req.Dispose();
              

            }
        
        }

        private void button26_Click(object sender, EventArgs e)
        {
            form_selecionar_empresa emp = new form_selecionar_empresa();
            try
            {
                emp.busca_dentro = true;
                emp.ShowDialog();
            }
            finally
            {
                tb_cnpj_empresa.Text = emp.cnpj_empresa_emissora;
                tb_descricao_empresa.Text = emp.empresa_emissora;
                
            }
        }

        private void apaga_faturas_anteriores()
        {
            try
            {

                this.datFatura_pc.DeleteCommand.CommandText =
                        "DELETE FROM FATURA_PC WHERE N_PEDIDO_FATURA_PC = '" + tb_n_pedido.Text + "'";
                this.fbConnection1.Open();
                this.datFatura_pc.DeleteCommand.Connection = fbConnection1;
                this.datFatura_pc.DeleteCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
            }
            catch
            {
                fbConnection1.Close();
                MessageBox.Show("Erro ao apagar faturas");
            }
        }

        private void insere_fatura(string prazo, string data, string valor, string nf)
        {
            try
            {

                this.datFatura_pc.InsertCommand.CommandText =
                        "INSERT INTO FATURA_PC (PRAZO_FATURA_PC, DATA_VENC_FATURA_PC, VALOR_FATURA_PC, N_PEDIDO_FATURA_PC)" +
                        "VALUES ('" + prazo + "','" + data + "','" + valor + "','" + nf + "')";
                this.fbConnection1.Open();
                this.datFatura_pc.InsertCommand.Connection = fbConnection1;
                this.datFatura_pc.InsertCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
            }
            catch
            {
                fbConnection1.Close();
                MessageBox.Show("erro na inserção da fatura");
            }


        }
        private void acertar_faturas(string n_parcelas, string prazo_1, string prazo_2, string prazo_3,
         string prazo_4, string prazo_5, string prazo_6, string prazo_7, string prazo_8, string prazo_9, string prazo_10, string prazo_11, string prazo_12)
        {
            try
            {

                int numero_parcelas = 0;
                DateTime hoje = DateTime.Now;
                try
                {
                    hoje = Convert.ToDateTime(tb_data_entrega.Text);

                }
                catch { }
                //hoje = DateTime.Now;
                try
                {
                    numero_parcelas = Convert.ToInt32(n_parcelas);
                }
                catch
                {
                    numero_parcelas = 0;
                    // MessageBox.Show("Número de parcelas incorreto");
                }
                decimal valor = 0;// buscar_valor_faturado() / numero_parcelas;
                valor = Convert.ToDecimal(Convert.ToDecimal((Convert.ToDecimal(tb_valor_total.Text)) / numero_parcelas).ToString("n2"));
                // valor = Convert.ToDecimal(Convert.ToDecimal((Convert.ToDecimal(tb_total_prod.Text) - Convert.ToDecimal(tb_valor_desconto.Text)) / numero_parcelas).ToString("n2"));
                string[] prazos = { prazo_1, prazo_2, prazo_3, prazo_4, prazo_5, prazo_6, prazo_7, prazo_8, prazo_9, prazo_10, prazo_11, prazo_12 };

                for (int i = 0; i < numero_parcelas; i++)
                {
                    double prazo = 0;
                    prazo = Convert.ToDouble(prazos[i]);
                    DateTime data1 = hoje.AddDays(prazo);
                    insere_fatura(prazos[i].ToString(), data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_pedido.Text);
                }




            }
            catch { }

        }
        /*
        private void acertar_faturas(string n_parcelas, string prazo_1, string prazo_2, string prazo_3,
           string prazo_4, string prazo_5, string prazo_6)
        {

            int numero_parcelas = 0;
            DateTime hoje = Convert.ToDateTime(tb_data_entrega.Text);
            //hoje = DateTime.Now;
            try
            {
                numero_parcelas = Convert.ToInt32(n_parcelas);
            }
            catch
            {
                numero_parcelas = 0;
                // MessageBox.Show("Número de parcelas incorreto");
            }
            decimal valor = 0;
            try
            {
                //if (razao_social_empresa.ToUpper().Contains("DEBORA") || razao_social_empresa.ToUpper().Contains("DANIEL"))
                // {
                valor = Convert.ToDecimal(Convert.ToDecimal((Convert.ToDecimal(tb_valor_total.Text)) / numero_parcelas).ToString("n2"));
                //  }
                ///  else
                //  {
                //      valor = Convert.ToDecimal(Convert.ToDecimal((Convert.ToDecimal(tb_total_pedido.Text)) / numero_parcelas).ToString("n2"));
                //  }
            }
            catch { }

            switch (numero_parcelas)
            {

                case 1:
                    {
                        double prazo = Convert.ToDouble(prazo_1);
                        decimal diferenca = 0;
                        try
                        {
                            decimal valorProdutos = Convert.ToDecimal(Convert.ToDecimal((Convert.ToDecimal(tb_valor_total.Text))).ToString("n2"));
                            decimal somaParcelas = valor * numero_parcelas;
                            diferenca = valorProdutos - somaParcelas;
                        }
                        catch { }
                        decimal valor1 = valor + diferenca;
                        DateTime data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_1, data1.ToShortDateString().Replace("/", "."), valor1.ToString().Replace(",", "."), tb_n_pedido.Text);
                        break;
                    }

                case 2:
                    {
                        double prazo = Convert.ToDouble(prazo_1);
                        decimal diferenca = 0;
                        try
                        {
                            decimal valorProdutos = Convert.ToDecimal(Convert.ToDecimal((Convert.ToDecimal(tb_valor_total.Text))).ToString("n2"));
                            decimal somaParcelas = valor * numero_parcelas;
                            diferenca = valorProdutos - somaParcelas;
                        }
                        catch { }
                        decimal valor1 = valor + diferenca;
                        DateTime data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_1, data1.ToShortDateString().Replace("/", "."), valor1.ToString().Replace(",", "."), tb_n_pedido.Text);
                        prazo = Convert.ToDouble(prazo_2);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_2, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_pedido.Text);
                        break;
                    }
                case 3:
                    {
                        double prazo = Convert.ToDouble(prazo_1);
                        decimal diferenca = 0;
                        try
                        {
                            decimal valorProdutos = Convert.ToDecimal(Convert.ToDecimal((Convert.ToDecimal(tb_valor_total.Text))).ToString("n2"));
                            decimal somaParcelas = valor * numero_parcelas;
                            diferenca = valorProdutos - somaParcelas;
                        }
                        catch { }
                        decimal valor1 = valor + diferenca;
                        DateTime data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_1, data1.ToShortDateString().Replace("/", "."), valor1.ToString().Replace(",", "."), tb_n_pedido.Text);
                        prazo = Convert.ToDouble(prazo_2);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_2, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_pedido.Text);
                        prazo = Convert.ToDouble(prazo_3);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_3, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_pedido.Text);
                        break;
                    }
                case 4:
                    {
                        double prazo = Convert.ToDouble(prazo_1);
                        decimal diferenca = 0;
                        try
                        {
                            decimal valorProdutos = Convert.ToDecimal(Convert.ToDecimal((Convert.ToDecimal(tb_valor_total.Text))).ToString("n2"));
                            decimal somaParcelas = valor * numero_parcelas;
                            diferenca = valorProdutos - somaParcelas;
                        }
                        catch { }
                        decimal valor1 = valor + diferenca;
                        DateTime data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_1, data1.ToShortDateString().Replace("/", "."), valor1.ToString().Replace(",", "."), tb_n_pedido.Text);
                        prazo = Convert.ToDouble(prazo_2);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_2, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_pedido.Text);
                        prazo = Convert.ToDouble(prazo_3);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_3, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_pedido.Text);
                        prazo = Convert.ToDouble(prazo_4);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_4, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_pedido.Text);
                        break;
                    }
                case 5:
                    {
                        double prazo = Convert.ToDouble(prazo_1);
                        decimal diferenca = 0;
                        try
                        {
                            decimal valorProdutos = Convert.ToDecimal(Convert.ToDecimal((Convert.ToDecimal(tb_valor_total.Text))).ToString("n2"));
                            decimal somaParcelas = valor * numero_parcelas;
                            diferenca = valorProdutos - somaParcelas;
                        }
                        catch { }
                        decimal valor1 = valor + diferenca;
                        DateTime data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_1, data1.ToShortDateString().Replace("/", "."), valor1.ToString().Replace(",", "."), tb_n_pedido.Text);
                        prazo = Convert.ToDouble(prazo_2);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_2, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_pedido.Text);
                        prazo = Convert.ToDouble(prazo_3);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_3, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_pedido.Text);
                        prazo = Convert.ToDouble(prazo_4);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_4, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_pedido.Text);
                        prazo = Convert.ToDouble(prazo_5);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_5, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_pedido.Text);
                        break;
                    }
                case 6:
                    {
                        double prazo = Convert.ToDouble(prazo_1);
                        decimal diferenca = 0;
                        try
                        {
                            decimal valorProdutos = Convert.ToDecimal(Convert.ToDecimal((Convert.ToDecimal(tb_valor_total.Text))).ToString("n2"));
                            decimal somaParcelas = valor * numero_parcelas;
                            diferenca = valorProdutos - somaParcelas;
                        }
                        catch { }
                        decimal valor1 = valor + diferenca;
                        DateTime data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_1, data1.ToShortDateString().Replace("/", "."), valor1.ToString().Replace(",", "."), tb_n_pedido.Text);
                        prazo = Convert.ToDouble(prazo_2);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_2, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_pedido.Text);
                        prazo = Convert.ToDouble(prazo_3);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_3, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_pedido.Text);
                        prazo = Convert.ToDouble(prazo_4);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_4, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_pedido.Text);
                        prazo = Convert.ToDouble(prazo_5);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_5, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_pedido.Text);
                        prazo = Convert.ToDouble(prazo_6);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_6, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_pedido.Text);
                        break;
                    }



            }
        }
        */

        private void button11_Click(object sender, EventArgs e)
        {
            if (tb_data_entrega.Text != "")
            {
               
                    if (tb_valor_total.Text != "")
                    {

                        form_forma_pgto localiza_forma = new form_forma_pgto();
                        try
                        {
                            localiza_forma.forma_pgto_ja_escolhida = "";
                            localiza_forma.busca_forma_escolhida = true;
                            localiza_forma.ShowDialog();
                        }
                        finally
                        {
                            localiza_forma.Dispose();
                            //MessageBox.Show(localiza_peca.peca_escolhida);
                            tb_forma_pgto.Text = localiza_forma.forma_pgto_escolhida;
                            apaga_faturas_anteriores();
                        acertar_faturas(localiza_forma.n_parcelas, localiza_forma.prazo_1, localiza_forma.prazo_2, localiza_forma.prazo_3,
                                   localiza_forma.prazo_4, localiza_forma.prazo_5, localiza_forma.prazo_6,
                                   localiza_forma.prazo_7, localiza_forma.prazo_8, localiza_forma.prazo_9,
                                   localiza_forma.prazo_10, localiza_forma.prazo_11, localiza_forma.prazo_12);
                        selecionar_faturas();

                        }

                    }
                    else
                        MessageBox.Show("Calcule o valor da Nota antes de inserir a forma de pagamento.");
                
            }
            else
            {
                MessageBox.Show("Para gerar as datas de provisionamento, digite a data de entrega prevista");
                tb_data_entrega.BackColor = Color.Orange;
                tb_data_entrega.Focus();
            }
        }

    }
}