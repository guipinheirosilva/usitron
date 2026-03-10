using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using FirebirdSql.Data.FirebirdClient;

namespace Evolucao
{
    public partial class form_requisicao : Form
    {
        string autorizante = "";
        public bool abrir_requisicao;
        public string n_requisicao;
        public string cnpj_empresa;
        public string cod_usuario;
        public form_requisicao(string cnpj_empresa)
        {
            this.cnpj_empresa = cnpj_empresa;
            InitializeComponent();
        }

        private void form_requisicao_Load(object sender, EventArgs e)
        {
            detectar_dados_empresa(out razao_social_empresa, out nome_fantasia_empresa, out cnpj_empresa, out ie_empresa, out im_empresa, out cnae_empresa, out endereco_empresa, out n_endereco_empresa,
      out complemento_empresa, out bairro_empresa, out cidade_empresa, out estado_empresa, out cep_empresa, out telefone_empresa, out cod_cidade_empresa, out pais_empresa,
      out cod_pais_empresa, out licenca_dll_nfe_empresa, out nome_certificado_nfe_empresa, out assunto_nfe_email_empresa, out smtp_nfe_empresa, out email_nfe_empresa,
      out senha_email_nfe_empresa, out logotipo_empresa, out proxy_empresa, out usuario_proxy_empresa, out senha_proxy_empresa, out crt_empresa, out portaEmailEmpresa, out sslEmpresa, out serie_empresa,
      out boleto_pedido_empresa, out cliente_inadimplente_empresa);

            if (abrir_requisicao == true)
            {
                try
                {
                    dsRequisicoes.Clear();
                    dsItens_req.Clear();
                    this.datRequisicoes.SelectCommand.CommandText =
                    "SELECT * FROM REQUISICOES WHERE COD_REQUISICAO = '" + n_requisicao + "'";
                    this.fbConnection1.Open();
                    this.datRequisicoes.SelectCommand.Connection = fbConnection1;
                    this.datRequisicoes.SelectCommand.ExecuteNonQuery();
                    datRequisicoes.Fill(REQUISICOES);
                    this.fbConnection1.Close();

                    this.datItens_req.SelectCommand.CommandText =
                    "SELECT * FROM ITENS_REQUISICAO WHERE COD_REQ_ITEM_REQ = '" + n_requisicao + "'";
                    this.fbConnection1.Open();
                    this.datItens_req.SelectCommand.Connection = fbConnection1;
                    this.datItens_req.SelectCommand.ExecuteNonQuery();
                    datItens_req.Fill(ITENS_REQUISICAO);
                    this.fbConnection1.Close();
                }
                catch
                {
                    fbConnection1.Close();
                }
            }
            

        }

        private void form_requisicao_KeyDown(object sender, KeyEventArgs e)
        {
            
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
                { }
                else
                {
                    tb_descricao_item.Text = localiza_item.descricao_produto_escolhido;
                    tb_cod_item.Text = localiza_item.cod_produto_escolhido;
                    tb_item_item.Text = localiza_item.cod_forn;
                    tb_unidade.Text = localiza_item.unidade_produto_escolhido;
                    

                }
            }
            //form_busca_item_estoque_mp localiza_item = new form_busca_item_estoque_mp(cnpj_empresa);
            //try
            //{
            //    localiza_item.ShowDialog();
            //}
            //finally
            //{
            //    localiza_item.Dispose();
            //    if (localiza_item.cod_escolhido == "")
            //    { }
            //    else
            //    {
            //        tb_descricao_item.Text = localiza_item.descricao_escolhido;
            //        tb_cod_item.Text = localiza_item.cod_escolhido;
            //        tb_item_item.Text = localiza_item.item_escolhido;

            //    }
            //}
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

        private void bt_inserir_Click(object sender, EventArgs e)
        {
            string op = tb_op.Text;
            string pos = tb_pos.Text;
            if (op == "")
                op = "null";
            else
                op = "'" + op + "'";
            if (pos == "")
                pos = "null";
            else
                pos = "'" + pos + "'";
            string cod = tb_cod_item.Text;
            if (cod == "")
                cod = "null";
            else
                cod = "'" + cod + "'";
            string item = tb_item_item.Text;
            if (item == "")
                item = "null";
            else
                item = "'" + item + "'";

            string urgente = "0";
            if (cbUrgente.Checked == true)
                urgente = "1";
            try
            {
                if (tb_data_limite.Text != "")
                {
                    this.datItens_req.InsertCommand.CommandText =
                       "INSERT INTO ITENS_REQUISICAO (COD_REQ_ITEM_REQ, OP_ITEM_REQ, POSICAO_ITEM_REQ, QTDE_ITEM_REQ, UNIDADE_ITEM_REQ, COD_ESTOQUE_ITEM_REQ, ITEM_ITEM_REQ, " +
                       "DESCRICAO_ITEM_REQ, DATA_LIMITE_ITEM_REQ, URGENTE_ITEM_REQ, REQUISITANTE_ITEM_REQ, SETOR_ITEM_REQ, DATA_REQUISICAO_ITEM_REQ, " +
                       "SITUACAO_ATUAL_ITEM_REQ)" +
                       "VALUES ('" + tb_cod.Text + "'," + op + "," + pos + ",'" + tb_qtde.Text.Replace(",", ".") + "','" + tb_unidade.Text + "'," + cod + "," + item + ",'" +
                       tb_descricao_item.Text + "','" + Convert.ToDateTime(tb_data_limite.Text).ToShortDateString().Replace("/", ".") + "','" + urgente + "','" + tb_requisitante.Text + "','" +
                       tb_setor.Text + "','" + Convert.ToDateTime(tb_data_req.Text).ToShortDateString().Replace("/", ".") + "','REQUISIÇÃO AGUARDANDO RESPOSTA')";
                    this.fbConnection1.Open();
                    this.datItens_req.InsertCommand.Connection = fbConnection1;
                    this.datItens_req.InsertCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                    tb_ultima_insercao.Text = DateTime.Now.ToString();
                    Atualizar();
                }
                else
                {
                    this.datItens_req.InsertCommand.CommandText =
                       "INSERT INTO ITENS_REQUISICAO (COD_REQ_ITEM_REQ, OP_ITEM_REQ, POSICAO_ITEM_REQ, QTDE_ITEM_REQ, UNIDADE_ITEM_REQ, COD_ESTOQUE_ITEM_REQ, ITEM_ITEM_REQ," +
                       "DESCRICAO_ITEM_REQ, URGENTE_ITEM_REQ, REQUISITANTE_ITEM_REQ, SETOR_ITEM_REQ, DATA_REQUISICAO_ITEM_REQ, " +
                       "SITUACAO_ATUAL_ITEM_REQ)" +
                       "VALUES ('" + tb_cod.Text + "'," + op + "," + pos + ",'" + tb_qtde.Text.Replace(",", ".") + "','" + tb_unidade.Text + "'," + cod + "," + item + ",'" +
                       tb_descricao_item.Text + "','" + urgente + "','" + tb_requisitante.Text + "','" +
                       tb_setor.Text + "','" + Convert.ToDateTime(tb_data_req.Text).ToShortDateString().Replace("/", ".") + "','REQUISIÇÃO AGUARDANDO RESPOSTA')";
                    this.fbConnection1.Open();
                    this.datItens_req.InsertCommand.Connection = fbConnection1;
                    this.datItens_req.InsertCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                    tb_ultima_insercao.Text = DateTime.Now.ToString();
                    Atualizar();

                }
            }
            catch
            {
                fbConnection1.Close();
            }
            dsItens_req.Clear();
            this.datItens_req.SelectCommand.CommandText =
                    "SELECT * FROM ITENS_REQUISICAO WHERE COD_REQ_ITEM_REQ = '" + tb_cod.Text + "'";
            this.fbConnection1.Open();
            this.datItens_req.SelectCommand.Connection = fbConnection1;
            this.datItens_req.SelectCommand.ExecuteNonQuery();
            datItens_req.Fill(ITENS_REQUISICAO);
            this.fbConnection1.Close();
            tb_cod_item.Text = "";
            tb_descricao_item.Text = "";
            tb_op.Text = "";
            tb_unidade.Text = "";
            tb_qtde.Text = "";
            cbUrgente.Checked = false;
            tb_data_limite.Text = "";
            tb_pos.Text = "";
            tb_item_item.Text = "";
            

        }

        private void tb_novo_Click(object sender, EventArgs e)
        {
            try
            {
                dsItens_req.Clear();
                dsRequisicoes.Clear();
                //dsOrcamentos_item_req.Clear();
                //this.datRequisicoes.DeleteCommand.CommandText =
                //            "DELETE FROM REQUISICOES WHERE REQUISITANTE_REQUISICAO = 'NOVO'";
                //this.fbConnection1.Open();
                //this.datRequisicoes.DeleteCommand.Connection = fbConnection1;
                //this.datRequisicoes.DeleteCommand.ExecuteNonQuery();
                //this.fbConnection1.Close();

                this.datRequisicoes.InsertCommand.CommandText =
                    "INSERT INTO REQUISICOES (REQUISITANTE_REQUISICAO)" +
                    "VALUES ('NOVO') RETURNING COD_REQUISICAO";
                this.fbConnection1.Open();
                this.datRequisicoes.InsertCommand.Connection = fbConnection1;
                object cod = datRequisicoes.InsertCommand.ExecuteScalar();
                this.fbConnection1.Close();



                this.datRequisicoes.SelectCommand.CommandText =
                    "SELECT * FROM REQUISICOES WHERE COD_REQUISICAO = '" + cod.ToString() + "'";
                this.fbConnection1.Open();
                this.datRequisicoes.SelectCommand.Connection = fbConnection1;
                //this.datRequisicoes.SelectCommand.ExecuteNonQuery();
                datRequisicoes.Fill(REQUISICOES);
                this.fbConnection1.Close();
                tb_requisitante.Text = "";
                tb_data_req.Text = DateTime.Now.ToShortDateString();

            }
            catch
            {
                fbConnection1.Close();
                MessageBox.Show("Erro");
            }
        }

        private void tb_excluir_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("O registro será excluído permanentemente, tem certeza?",
               "Confirma a exclusão?", MessageBoxButtons.YesNo))
            {

                try
                {
                    this.datItens_req.DeleteCommand.CommandText =
                        "DELETE FROM ITENS_REQUISICAO WHERE COD_REQ_ITEM_REQ = '" + tb_cod.Text + "'";
                    this.fbConnection1.Open();
                    this.datItens_req.DeleteCommand.Connection = fbConnection1;
                    this.datItens_req.DeleteCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();

                    this.datRequisicoes.DeleteCommand.CommandText =
                        "DELETE FROM REQUISICOES WHERE COD_REQUISICAO = '" + tb_cod.Text + "'";
                    this.fbConnection1.Open();
                    this.datRequisicoes.DeleteCommand.Connection = fbConnection1;
                    this.datRequisicoes.DeleteCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                    dsItens_req.Clear();
                    dsRequisicoes.Clear();
                    dsOrcamentos_item_req.Clear();
                }
                catch 
                { 
                    fbConnection1.Close();
                    MessageBox.Show("Erro");
                }
           }
        }

        private void tb_salvar_Click(object sender, EventArgs e)
        {
            Atualizar();
        }

        private void Atualizar()
        {
            this.BindingContext[dsRequisicoes, "REQUISICOES"].EndCurrentEdit();
            if (dsRequisicoes.HasChanges())
            {
                fbConnection1.Open();
                datRequisicoes.UpdateCommand = cbRequisicoes.GetUpdateCommand();
                datRequisicoes.InsertCommand = cbRequisicoes.GetInsertCommand();
                datRequisicoes.DeleteCommand = cbRequisicoes.GetDeleteCommand();
                datRequisicoes.Update(dsRequisicoes, "REQUISICOES");
                dsRequisicoes.AcceptChanges();
                fbConnection1.Close();
            }
            this.BindingContext[dsItens_req, "ITENS_REQUISICAO"].EndCurrentEdit();
            if (dsItens_req.HasChanges())
            {
                fbConnection1.Open();
                datItens_req.UpdateCommand = cbItens_req.GetUpdateCommand();
                datItens_req.InsertCommand = cbItens_req.GetInsertCommand();
                datItens_req.DeleteCommand = cbItens_req.GetDeleteCommand();
                datItens_req.Update(dsItens_req, "ITENS_REQUISICAO");
                dsItens_req.AcceptChanges();
                fbConnection1.Close();
            }
            this.BindingContext[dsOrcamentos_item_req, "ORCAMENTOS_ITEM_REQ"].EndCurrentEdit();
            if (dsOrcamentos_item_req.HasChanges())
            {
                fbConnection1.Open();
                datOrcamentos_item_req.UpdateCommand = cbOrcamentos_item_req.GetUpdateCommand();
                datOrcamentos_item_req.InsertCommand = cbOrcamentos_item_req.GetInsertCommand();
                datOrcamentos_item_req.DeleteCommand = cbOrcamentos_item_req.GetDeleteCommand();
                datOrcamentos_item_req.Update(dsOrcamentos_item_req, "ORCAMENTOS_ITEM_REQ");
                dsOrcamentos_item_req.AcceptChanges();
                fbConnection1.Close();
            }

        }

        private void bt_localizar_Click(object sender, EventArgs e)
        {
            form_localiza_req req = new form_localiza_req();
            try
            {
                req.ShowDialog();
            }
            finally
            {
                req.Dispose();
                try
                {
                    dsRequisicoes.Clear();
                    dsItens_req.Clear();
                    this.datRequisicoes.SelectCommand.CommandText =
                    "SELECT * FROM REQUISICOES WHERE COD_REQUISICAO = '" + req.req_escolhida + "'";
                    this.fbConnection1.Open();
                    this.datRequisicoes.SelectCommand.Connection = fbConnection1;
                    this.datRequisicoes.SelectCommand.ExecuteNonQuery();
                    datRequisicoes.Fill(REQUISICOES);
                    this.fbConnection1.Close();

                    this.datItens_req.SelectCommand.CommandText =
                    "SELECT * FROM ITENS_REQUISICAO WHERE COD_REQ_ITEM_REQ = '" + req.req_escolhida + "'";
                    this.fbConnection1.Open();
                    this.datItens_req.SelectCommand.Connection = fbConnection1;
                    this.datItens_req.SelectCommand.ExecuteNonQuery();
                    datItens_req.Fill(ITENS_REQUISICAO);
                    this.fbConnection1.Close();
                    dsOrcamentos_item_req.Clear();
                }
                catch
                {
                    fbConnection1.Close();
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.datRequisicoes.SelectCommand.CommandText =
                    "SELECT * FROM REQUISICOES WHERE COD_REQUISICAO = '" + tb_cod.Text + "'";
                this.fbConnection1.Open();
                this.datRequisicoes.SelectCommand.Connection = fbConnection1;
                this.datRequisicoes.SelectCommand.ExecuteNonQuery();
                datRequisicoes.Fill(REQUISICOES);
                this.fbConnection1.Close();

                if (dgvItens_requisicao.SelectedRows.Count > 0)
                {
                    string[] _itens = new string[100];
                    string select = "COD_ITEM_REQ = '";
                    int n = dgvItens_requisicao.SelectedRows.Count;
                    for (int i = 0; i < n; i++)
                    {
                        _itens[i] = dgvItens_requisicao.SelectedRows[i].Cells["col_cod"].Value.ToString();
                        if (i == 0)
                        {
                            select = select + _itens[i] + "'";
                        }
                        else
                        {
                            select = select + " OR COD_ITEM_REQ = '" + _itens[i] + "'";
                        }

                    }
                    dsItens_req.Clear();
                    for (int i = 0; i < n; i++)
                    {
                        this.datItens_req.SelectCommand.CommandText =
                        "SELECT * FROM ITENS_REQUISICAO WHERE " + select;
                        this.fbConnection1.Open();
                        this.datItens_req.SelectCommand.Connection = fbConnection1;
                        this.datItens_req.SelectCommand.ExecuteNonQuery();
                        datItens_req.Fill(ITENS_REQUISICAO);
                        this.fbConnection1.Close();
                    }
                }
                else
                {
                    this.datItens_req.SelectCommand.CommandText =
                    "SELECT * FROM ITENS_REQUISICAO WHERE COD_REQ_ITEM_REQ = '" + tb_cod.Text + "'";
                    this.fbConnection1.Open();
                    this.datItens_req.SelectCommand.Connection = fbConnection1;
                    this.datItens_req.SelectCommand.ExecuteNonQuery();
                    datItens_req.Fill(ITENS_REQUISICAO);
                    this.fbConnection1.Close();
                }

                dsRequisicao imprimir = new dsRequisicao();
                FbCommand selectEmpresa = new FbCommand();
                selectEmpresa.Connection = fbConnection1;
                selectEmpresa.CommandText =
                    "SELECT * FROM EMPRESA WHERE CNPJ_EMPRESA = '" + cnpj_empresa + "'";
                FbDataAdapter datSelect = new FbDataAdapter();
                fbConnection1.Open();
                datSelect.SelectCommand = selectEmpresa;
                datSelect.Fill(imprimir.EMPRESA);
                fbConnection1.Close();

                fbConnection1.Open();
                datRequisicoes.Fill(imprimir.REQUISICOES);
                datItens_req.Fill(imprimir.ITENS_REQUISICAO);
                fbConnection1.Close();
                crRequisicao nova_req = new crRequisicao();
                nova_req.SetDataSource(imprimir);
                form_imprimir imprime = new form_imprimir(nova_req);
                imprime.n_requisicao = tb_cod.Text;
                imprime.requisicao = true;
                imprime.Show();
                this.datItens_req.SelectCommand.CommandText =
                    "SELECT * FROM ITENS_REQUISICAO WHERE COD_REQ_ITEM_REQ = '" + tb_cod.Text + "'";
                this.fbConnection1.Open();
                this.datItens_req.SelectCommand.Connection = fbConnection1;
                this.datItens_req.SelectCommand.ExecuteNonQuery();
                datItens_req.Fill(ITENS_REQUISICAO);
                this.fbConnection1.Close();
            }
            catch
            {
                fbConnection1.Close();
            }

        }

        private void dgvItens_requisicao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

            if (dgvItens_requisicao.Columns[e.ColumnIndex].Name == "Aut")
            {
                if (dgvItens_requisicao.Rows[e.RowIndex].Cells["col_autorizante"].Value.ToString() == "")
                {
                    if (autorizante == "")
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
                                if (usuario._nivel_acesso_usuario == "1" || usuario._nivel_acesso_usuario == "2")
                                {
                                    autorizante = usuario._nome_usuario;
                                    inserir_autorizacao(dgvItens_requisicao.Rows[e.RowIndex].Cells["col_cod"].Value.ToString(), autorizante);
                                    dsItens_req.Clear();
                                    datItens_req.Fill(ITENS_REQUISICAO);
                                }
                                else
                                {
                                    MessageBox.Show("Usuário não autorizado");
                                }
                            }

                        }
                    }
                    else
                    {
                        inserir_autorizacao(dgvItens_requisicao.Rows[e.RowIndex].Cells["col_cod"].Value.ToString(), autorizante);
                        dsItens_req.Clear();
                        datItens_req.Fill(ITENS_REQUISICAO);
                    }
                }
                else
                    MessageBox.Show("Item já autorizado");
                

            }
        }
        private void inserir_autorizacao(string _cod, string _autorizante)
        {
            this.datItens_req.UpdateCommand.CommandText =
                            "UPDATE ITENS_REQUISICAO SET SITUACAO_ATUAL_ITEM_REQ = 'REQUISIÇÃO AUTORIZADA' WHERE COD_ITEM_REQ = " + _cod + "";
            this.fbConnection1.Open();
            this.datItens_req.UpdateCommand.Connection = fbConnection1;
            this.datItens_req.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();

            this.datItens_req.UpdateCommand.CommandText =
                            "UPDATE ITENS_REQUISICAO SET AUTORIZADO_POR_ITEM_REQ = '" + _autorizante + "' WHERE COD_ITEM_REQ = " + _cod + "";
            this.fbConnection1.Open();
            this.datItens_req.UpdateCommand.Connection = fbConnection1;
            this.datItens_req.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (autorizante == "")
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
                        if (usuario._nivel_acesso_usuario == "1" || usuario._nivel_acesso_usuario == "2")
                        {
                            autorizante = usuario._nome_usuario;
                            for (int i = 0; i < dgvItens_requisicao.RowCount; i++)
                            {
                                if (dgvItens_requisicao.Rows[i].Cells["col_autorizante"].Value.ToString() == "")
                                    inserir_autorizacao(dgvItens_requisicao.Rows[i].Cells["col_cod"].Value.ToString(), autorizante);
                                else
                                    MessageBox.Show("Item já autorizado");
                            }
                            dsItens_req.Clear();
                            datItens_req.Fill(ITENS_REQUISICAO);
                        }
                            
                        
                        else
                        {
                            MessageBox.Show("Usuário não autorizado");
                        }
                    }
                    

                }
            }
            else
            {
                for(int i = 0; i < dgvItens_requisicao.RowCount; i++)
                {
                    inserir_autorizacao(dgvItens_requisicao.Rows[i].Cells["col_cod"].Value.ToString(), autorizante);
                }
                dsItens_req.Clear();
                datItens_req.Fill(ITENS_REQUISICAO);
            }
        
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            enviar_email();
        }

        private void enviar_email()
        {
            bool _erro = false;
            string _caminho_arquivo = "";
            try
            {
                _caminho_arquivo = @"c:\\evolucao\\REQUISICOES\" + "REQUISICAO_" + tb_cod.Text + ".pdf";
                
            }
            catch
            {
                MessageBox.Show("Antes de enviar o email, imprima ou vizualize a impressão da Requisição");
                _erro = true;
            }
            string boa = "Bom dia, ";
            if (DateTime.Now > Convert.ToDateTime(DateTime.Now.ToShortDateString() + " " + "12:00:00"))
                boa = "Boa tarde, ";
            FileInfo d = new FileInfo(_caminho_arquivo);
            if (d.Exists == true)
            {
                string _email, _senha_email;
                buscar_email(cod_usuario, out _email, out _senha_email);

                string _assunto = nome_fantasia_empresa + " - REQUISIÇÃO DE ORÇAMENTO Nº " + tb_cod.Text;
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
"<title>Prezado fornecedor,</title>" +
"</head>" +
"<body>" +
"<font size='2' face='tahoma' color='black'>" +

"<div class=Section1> " +
boa + " <br>" +

"Prezado fornecedor, <br> " +

"Segue anexo requisição de orçamento nº " + tb_cod.Text + ".<br>" +
"Aguardamos uma resposta.<br><br>" +


"Atenciosamente, <br>" +
"<table><tr><font family = 'Berlin Sans FB','sans-serif' color='#365F91',font-weight: bold> " +
"<td> " +
"<span style='font-size:12.0pt;font-family:'Berlin Sans FB','sans-serif';color:#365F91'>Departamento de Compras</span><br>" +
"<span style='font-size:12.0pt;font-family:Wingdings;color:#365F91'>(</span><span style='font-size:12.0pt;font-family:'Berlin Sans FB','sans-serif';color:#365F91'>" + telefone_empresa + "</span><span style='font-size:12.0pt;color:#365F91'></span><br> " +
"<span style='font-size:12.0pt;font-family:Wingdings;color:#365F91'>*</span><span style='font-size:12.0pt;font-family:'Berlin Sans FB','sans-serif';color:#365F91'>" + _email + "</span> <br> " +
//"<p><img src='cid:atual'/></p>" +
"</td>" +
"</table>" +
"</font>" +
"</div>" +
"</body>" +
"</html>";

               

                Email_pedido_compra novo_email = new Email_pedido_compra();
                novo_email.cnpj_empresa = cnpj_empresa;
                novo_email._email = _email;
                novo_email._senha_email = _senha_email;
                
                if (tb_email_1.Text != "")
                {
                    _erro = false;
                    novo_email.EnviarEmail(tb_email_1.Text, _assunto, _mensagem, _caminho_arquivo, out _erro);
                    if (_erro == false)
                    {
                        if (barra_status.Text == "Status Atual")
                            barra_status.Text = "";
                        barra_status.Text = barra_status.Text + "Email 1 enviado com sucesso. ";
                        inserir_historico_email(tb_email_1.Text, _caminho_arquivo, _assunto);
                        tb_email_1.Text = "";
                    }
                    else
                    {
                        if (barra_status.Text == "Status Atual")
                            barra_status.Text = "";
                        barra_status.Text = barra_status.Text + "Email 1 não enviado. Favor verificar dados. ";
                    }
                }
                if (tb_email_2.Text != "")
                {
                    _erro = false;
                    novo_email.EnviarEmail(tb_email_2.Text, _assunto, _mensagem, _caminho_arquivo, out _erro);
                    if (_erro == false)
                    {
                        if (barra_status.Text == "Status Atual")
                            barra_status.Text = "";
                        barra_status.Text = barra_status.Text + "Email 2 enviado com sucesso. ";
                        inserir_historico_email(tb_email_2.Text, _caminho_arquivo, _assunto);
                        tb_email_1.Text = "";
                    }
                    else
                    {
                        if (barra_status.Text == "Status Atual")
                            barra_status.Text = "";
                        barra_status.Text = barra_status.Text + "Email 2 não enviado. Favor verificar dados. ";
                    }
                }
                if (tb_email_3.Text != "")
                {
                    _erro = false;
                    novo_email.EnviarEmail(tb_email_3.Text, _assunto, _mensagem, _caminho_arquivo, out _erro);
                    if (_erro == false)
                    {
                        if (barra_status.Text == "Status Atual")
                            barra_status.Text = "";
                        barra_status.Text = barra_status.Text + "Email 3 enviado com sucesso. ";
                        inserir_historico_email(tb_email_3.Text, _caminho_arquivo, _assunto);
                        tb_email_1.Text = "";
                    }
                    else
                    {
                        if (barra_status.Text == "Status Atual")
                            barra_status.Text = "";
                        barra_status.Text = barra_status.Text + "Email 3 não enviado. Favor verificar dados. ";
                    }
                }
            }
            else
            {
                MessageBox.Show("Antes de enviar o email, imprima ou vizualize a impressão da Requisição");
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

        private string detectar_email(string cod)
        {
            /*
            string email = "";
            form_busca_contato busca = new form_busca_contato();
            try
            {
                busca.cod_cli_forn = cod;
                busca.cli_forn = "FORN";
                busca.requisicao = true;
                busca.ShowDialog();
            }
            finally
            {
                email = busca.valores[0];
            }
            return email;
             * */
            try
            {
                comando_select.CommandText = "SELECT EMAIL_FORN " +
                    "FROM FORNECEDORES WHERE COD_FORN = '" + cod + "'";
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
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
                return "erro";
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            form_localiza_cliente cl = new form_localiza_cliente(true, "");
            // form_localiza_forn localiza_forn = new form_localiza_forn(false, cnpj_empresa);
            try
            {
                cl.pesquisa_fornecedor = true;
                cl.ShowDialog();
            }
            finally
            {

                cl.Dispose();
                try
                {
                    string _nome_forn = "", _cnpj_forn = "";
                    comando_select.CommandText = "SELECT EMAIL FROM CLIENTES WHERE CNPJ = '" + cl.cnpj_escolhido + "'";
                    DataSet forn = new DataSet();
                    fbConnection1.Open();
                    datFornecedores.SelectCommand = comando_select;
                    datFornecedores.Fill(forn);
                    fbConnection1.Close();
                    string iso, validade_iso, cliente, validade_cliente, nota;
                    foreach (DataRow dr in forn.Tables[0].Rows)
                    {
                        tb_email_1.Text = dr[0].ToString();
                    }

                    
                }
                catch
                {
                    fbConnection1.Close();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            form_localiza_cliente cl = new form_localiza_cliente(true, "");
            // form_localiza_forn localiza_forn = new form_localiza_forn(false, cnpj_empresa);
            try
            {
                cl.pesquisa_fornecedor = true;
                cl.ShowDialog();
            }
            finally
            {

                cl.Dispose();
                try
                {
                    string _nome_forn = "", _cnpj_forn = "";
                    comando_select.CommandText = "SELECT EMAIL FROM CLIENTES WHERE CNPJ = '" + cl.cnpj_escolhido + "'";
                    DataSet forn = new DataSet();
                    fbConnection1.Open();
                    datFornecedores.SelectCommand = comando_select;
                    datFornecedores.Fill(forn);
                    fbConnection1.Close();
                    string iso, validade_iso, cliente, validade_cliente, nota;
                    foreach (DataRow dr in forn.Tables[0].Rows)
                    {
                        tb_email_2.Text = dr[0].ToString();
                    }


                }
                catch
                {
                    fbConnection1.Close();
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            form_localiza_cliente cl = new form_localiza_cliente(true, "");
            // form_localiza_forn localiza_forn = new form_localiza_forn(false, cnpj_empresa);
            try
            {
                cl.pesquisa_fornecedor = true;
                cl.ShowDialog();
            }
            finally
            {

                cl.Dispose();
                try
                {
                    string _nome_forn = "", _cnpj_forn = "";
                    comando_select.CommandText = "SELECT EMAIL FROM CLIENTES WHERE CNPJ = '" + cl.cnpj_escolhido + "'";
                    DataSet forn = new DataSet();
                    fbConnection1.Open();
                    datFornecedores.SelectCommand = comando_select;
                    datFornecedores.Fill(forn);
                    fbConnection1.Close();
                    string iso, validade_iso, cliente, validade_cliente, nota;
                    foreach (DataRow dr in forn.Tables[0].Rows)
                    {
                        tb_email_3.Text = dr[0].ToString();
                    }


                }
                catch
                {
                    fbConnection1.Close();
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void dgvItens_ped_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

            try
            {
                selecionar_cotacoes(dgvItens_requisicao.SelectedRows[0].Cells[0].Value.ToString());
                selecionar_pedidos(dgvItens_requisicao.SelectedRows[0].Cells["col_cod_estoque"].Value.ToString());
            }

            catch
            {
                MessageBox.Show("Erro na visualização das cotações, verifique se a linha está selecionada");
                fbConnection1.Close();
            }

        }

        private void selecionar_cotacoes(string n_cotacao)
        {
            try
            {
                dsOrcamentos_item_req.Clear();
                this.datOrcamentos_item_req.SelectCommand.CommandText =
                "SELECT * FROM ORCAMENTOS_ITEM_REQ WHERE COD_ITEM_ORC_ITEM_REQ = '" + n_cotacao + "'";
                this.fbConnection1.Open();
                this.datOrcamentos_item_req.SelectCommand.Connection = fbConnection1;
                this.datOrcamentos_item_req.SelectCommand.ExecuteNonQuery();
                datOrcamentos_item_req.Fill(ORCAMENTOS_ITEM_REQ);
                this.fbConnection1.Close();
            }
            catch
            {
                MessageBox.Show("Erro! Verifique se a linha inteira do item da requisição está selecionada");
                fbConnection1.Close();
            }
        }

        private void selecionar_pedidos(string cod)
        {
            try
            {
                dsItens_ped.Clear();
                this.datItens_ped.SelectCommand.CommandText =
                "SELECT * FROM ITENS_PEDIDO_COMPRA WHERE COD_ESTOQUE_ITEM_PED = '" + cod + "' ORDER BY DATA_CHEGADA_ITEM_PED DESC";
                this.fbConnection1.Open();
                this.datItens_ped.SelectCommand.Connection = fbConnection1;
                this.datItens_ped.SelectCommand.ExecuteNonQuery();
                datItens_ped.Fill(ITENS_PEDIDO_COMPRA);
                this.fbConnection1.Close();
                calcular_consumo_medio();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.Message);
            }
        }

        private void calcular_consumo_medio()
        {
            DateTime data_hoje = Convert.ToDateTime(tb_data_req.Text);
            for (int i = 0; i < dgvItens_ped.RowCount; i++)
            {
                try
                {
                    DateTime data_ultima_compra = Convert.ToDateTime(dgvItens_ped.Rows[i].Cells["col_data_chegada"].Value.ToString());
                    TimeSpan intervalo = data_hoje - data_ultima_compra;
                    if (intervalo.Days > 0)
                    {
                        double ultima_qtde_comprada = 0;
                        try
                        {
                            ultima_qtde_comprada = Convert.ToDouble(dgvItens_ped.Rows[i].Cells["col_qtde"].Value.ToString());
                        }
                        catch { }
                        double media_consumo = 0;
                        try
                        {
                            media_consumo = ultima_qtde_comprada / intervalo.Days;
                        }
                        catch { }
                        dgvItens_ped.Rows[i].Cells["col_consumo_medio"].Value = media_consumo.ToString("n2");
                    }
                    data_hoje = data_ultima_compra;
                }
                catch { }
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            form_localiza_cliente cl = new form_localiza_cliente(true, "");
            // form_localiza_forn localiza_forn = new form_localiza_forn(false, cnpj_empresa);
            try
            {
                cl.pesquisa_fornecedor = true;
                cl.ShowDialog();
            }
            finally
            {

                tb_forn_cotacao.Text = cl.cliente_escolhido;
            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            try
            {
                string dataEntrega = "";
                try
                {
                    dataEntrega = "'" + Convert.ToDateTime(tb_data_entrega_orc.Text).ToShortDateString().Replace("/", ".") + "'";
                }
                catch
                {
                    dataEntrega = "null";
                }
                
                int codItem = Convert.ToInt32(dgvItens_requisicao["col_cod", dgvItens_requisicao.CurrentRow.Index].Value.ToString());
                FbCommand insert = new FbCommand();
                insert.CommandText =
                    "INSERT INTO ORCAMENTOS_ITEM_REQ (COD_ITEM_ORC_ITEM_REQ, VALOR_TOTAL_ORC_ITEM_REQ, FORN_ORC_ITEM_REQ, DATA_ENTREGA_ORC_ITEM_REQ) " +
                    "VALUES('" + codItem + "', '" + tb_valor_cotacao.Text.Replace(".", "").Replace(",", ".") + "', '" + tb_forn_cotacao.Text + "', " + dataEntrega + ")";
                insert.Connection = fbConnection1;
                fbConnection1.Open();
                datOrcamentos_item_req.InsertCommand = insert;
                datOrcamentos_item_req.InsertCommand.ExecuteNonQuery();
                fbConnection1.Close();

                datOrcamentos_item_req.SelectCommand.Connection = fbConnection1;
                fbConnection1.Open();
                datOrcamentos_item_req.SelectCommand.CommandText =
                    "SELECT * FROM ORCAMENTOS_ITEM_REQ WHERE COD_ITEM_ORC_ITEM_REQ = '" + codItem + "'";
                datOrcamentos_item_req.Fill(dsOrcamentos_item_req.Tables[0]);
                fbConnection1.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
                fbConnection1.Close();
            }
        }

        private void dgvItens_requisicao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dsOrcamentos_item_req.Clear();
                int codItem = Convert.ToInt32(dgvItens_requisicao["col_cod", dgvItens_requisicao.CurrentRow.Index].Value.ToString());
                datOrcamentos_item_req.SelectCommand.Connection = fbConnection1;
                fbConnection1.Open();
                datOrcamentos_item_req.SelectCommand.CommandText =
                    "SELECT * FROM ORCAMENTOS_ITEM_REQ WHERE COD_ITEM_ORC_ITEM_REQ = '" + codItem + "'";
                datOrcamentos_item_req.Fill(dsOrcamentos_item_req.Tables[0]);
                fbConnection1.Close();
            }
            catch (Exception ex)
            {
                fbConnection1.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void tb_cod_item_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                selecionar_cod_estoque(tb_cod_item.Text);

            }
        }

        private void selecionar_cod_estoque(string cod)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT * FROM ESTOQUE WHERE COD_ESTOQUE = '" + cod + "'";
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    tb_descricao_item.Text = dr["DESCRICAO_ESTOQUE"].ToString();
                    tb_item_item.Text = dr["ITEM_ESTOQUE"].ToString();
                }
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        
    }
}