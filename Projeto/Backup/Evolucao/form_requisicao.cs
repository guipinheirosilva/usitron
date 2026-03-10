using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Evolucao
{
    public partial class form_requisicao : Form
    {
        string autorizante = "";
        public bool abrir_requisicao;
        public string n_requisicao;

        public form_requisicao()
        {
            InitializeComponent();
        }

        private void form_requisicao_Load(object sender, EventArgs e)
        {
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
            this.datRequisicoes.DeleteCommand.CommandText =
                        "DELETE FROM REQUISICOES WHERE REQUISITANTE_REQUISICAO = 'NOVO'";
            this.fbConnection1.Open();
            this.datRequisicoes.DeleteCommand.Connection = fbConnection1;
            this.datRequisicoes.DeleteCommand.ExecuteNonQuery();
            this.fbConnection1.Close();

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
            string descricao= "";
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
                    tb_descricao_item.Text = localiza_item.item_produto_escolhido;
                    descricao = localiza_item.descricao_produto_escolhido;
                    tb_cod_item.Text = localiza_item.cod_produto_escolhido;
                    tb_unidade.Text = localiza_item.unidade_produto_escolhido;
                    tb_descricao_produto.Text = localiza_item.grupo_escolhido;
                    cod_forntextBox.Text = localiza_item.cod_forn;
                }
            }
            tb_descricao_produto.Text = descricao;
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
            string item = tb_descricao_produto.Text;
            if (item == "")
                item = "null";
            else
                item = "'" + item + "'";
            string cod_forn = cod_forntextBox.Text;
            if (cod_forn == "")
                cod_forn = "null";
            else
                cod_forn = "'" + cod_forn + "'";

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
                       "SITUACAO_ATUAL_ITEM_REQ, COD_FORN_ITEM_REQ)" +
                       "VALUES ('" + tb_cod.Text + "'," + op + "," + pos + ",'" + tb_qtde.Text.Replace(",", ".") + "','" + tb_unidade.Text + "'," + cod + "," + item + ",'" +
                       tb_descricao_item.Text + "','" + Convert.ToDateTime(tb_data_limite.Text).ToShortDateString().Replace("/", ".") + "','" + urgente + "','" + tb_requisitante.Text + "','" +
                       tb_setor.Text + "','" + Convert.ToDateTime(tb_data_req.Text).ToShortDateString().Replace("/", ".") + "','REQUISIÇÃO AGUARDANDO RESPOSTA'," + cod_forn + ")";
                    this.fbConnection1.Open();
                    this.datItens_req.InsertCommand.Connection = fbConnection1;
                    this.datItens_req.InsertCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                }
                else
                {
                    this.datItens_req.InsertCommand.CommandText =
                       "INSERT INTO ITENS_REQUISICAO (COD_REQ_ITEM_REQ, OP_ITEM_REQ, POSICAO_ITEM_REQ, QTDE_ITEM_REQ, UNIDADE_ITEM_REQ, COD_ESTOQUE_ITEM_REQ, ITEM_ITEM_REQ," +
                       "DESCRICAO_ITEM_REQ, URGENTE_ITEM_REQ, REQUISITANTE_ITEM_REQ, SETOR_ITEM_REQ, DATA_REQUISICAO_ITEM_REQ, " +
                       "SITUACAO_ATUAL_ITEM_REQ, COD_FORN_ITEM_REQ)" +
                       "VALUES ('" + tb_cod.Text + "'," + op + "," + pos + ",'" + tb_qtde.Text.Replace(",", ".") + "','" + tb_unidade.Text + "'," + cod + "," + item + ",'" +
                       tb_descricao_item.Text + "','" + urgente + "','" + tb_requisitante.Text + "','" +
                       tb_setor.Text + "','" + Convert.ToDateTime(tb_data_req.Text).ToShortDateString().Replace("/", ".") + "','REQUISIÇÃO AGUARDANDO RESPOSTA'," + cod_forn + ")";
                    this.fbConnection1.Open();
                    this.datItens_req.InsertCommand.Connection = fbConnection1;
                    this.datItens_req.InsertCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();

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
            tb_descricao_produto.Text = "";
            cod_forntextBox.Text = "";

        }

        private void tb_novo_Click(object sender, EventArgs e)
        {
            dsItens_req.Clear();
            dsRequisicoes.Clear();

            this.datRequisicoes.DeleteCommand.CommandText =
                        "DELETE FROM REQUISICOES WHERE REQUISITANTE_REQUISICAO = 'NOVO'";
            this.fbConnection1.Open();
            this.datRequisicoes.DeleteCommand.Connection = fbConnection1;
            this.datRequisicoes.DeleteCommand.ExecuteNonQuery();
            this.fbConnection1.Close();

            this.datRequisicoes.InsertCommand.CommandText =
                "INSERT INTO REQUISICOES (REQUISITANTE_REQUISICAO)" +
                "VALUES ('NOVO')";
            this.fbConnection1.Open();
            this.datRequisicoes.InsertCommand.Connection = fbConnection1;
            this.datRequisicoes.InsertCommand.ExecuteNonQuery();
            this.fbConnection1.Close();

            try
            {

                this.datRequisicoes.SelectCommand.CommandText =
                    "SELECT * FROM REQUISICOES WHERE REQUISITANTE_REQUISICAO = 'NOVO'";
                this.fbConnection1.Open();
                this.datRequisicoes.SelectCommand.Connection = fbConnection1;
                this.datRequisicoes.SelectCommand.ExecuteNonQuery();
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
                _caminho_arquivo = "c:\\evolucao_dokinos\\REQUISICOES\\" + "REQUISICAO_" + tb_cod.Text + ".pdf";
                
            }
            catch
            {
                MessageBox.Show("Antes de enviar o email, imprima ou vizualize a impressão da Requisição");
                _erro = true;
            }
            FileInfo d = new FileInfo(_caminho_arquivo);
            if (d.Exists == true)
            {
                string _assunto = "Nova Requisição de Orçamento: " + tb_cod.Text;
                string _mensagem = "Segue anexo Requisição de Orçamento sob n.º " + tb_cod.Text + " emitida em " + Convert.ToDateTime(tb_data_req.Text).ToShortDateString();
                Email_pedido_compra novo_email = new Email_pedido_compra();

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

        private void button5_Click(object sender, EventArgs e)
        {
            form_localiza_forn localiza_forn = new form_localiza_forn(true);
            try
            {
                localiza_forn.ShowDialog();
            }
            finally
            {
                localiza_forn.Dispose();
                tb_email_1.Text = detectar_email(localiza_forn.forn_escolhido);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            form_localiza_forn localiza_forn = new form_localiza_forn(true);
            try
            {
                localiza_forn.ShowDialog();
            }
            finally
            {
                localiza_forn.Dispose();
                tb_email_2.Text = detectar_email(localiza_forn.forn_escolhido);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            form_localiza_forn localiza_forn = new form_localiza_forn(true);
            try
            {
                localiza_forn.ShowDialog();
            }
            finally
            {
                localiza_forn.Dispose();
                tb_email_3.Text = detectar_email(localiza_forn.forn_escolhido);
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