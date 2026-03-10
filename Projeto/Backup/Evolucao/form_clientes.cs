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
    public partial class form_clientes : Form
    {
        
        public bool confirmacao;
        public bool pessoa_fisica;
        public string ie_cliente, cnpj_cliente, logradouro_cliente, n_logradouro_cliente, complemento_cliente, bairro_cliente, cod_municipio_cliente,
            uf_cliente, cep_cliente, cod_pais_cliente, pais_cliente, telefone_cliente, cidade_cliente, cpf_cliente;
        int novox = 0;
        public string cliente_consulta;
        public bool consulta;
        public form_clientes()
        {
            InitializeComponent();
        }

        private void form_clientes_Load(object sender, EventArgs e)
        {
            if (consulta == true)
            {

                this.datClientes.SelectCommand.CommandText =
                "SELECT * FROM CLIENTES WHERE CNPJ = '" + cliente_consulta + "'";
                this.fbConnection1.Open();
                this.datClientes.SelectCommand.Connection = fbConnection1;
                this.datClientes.SelectCommand.ExecuteNonQuery();
                datClientes.Fill(CLIENTES);
                this.fbConnection1.Close();
                ie_cliente = tb_ie.Text;
                cnpj_cliente = tb_cnpj.Text;
                logradouro_cliente = tb_logradouro.Text;
                n_logradouro_cliente = tb_n.Text;
                //complemento_cliente = pegar_dados_cliente.complemento_cliente;
                bairro_cliente = tb_bairro.Text;
                cod_municipio_cliente = tb_cod_cidade.Text;
                uf_cliente = tb_estado.Text;
                cep_cliente = tb_Cep.Text;
                cod_pais_cliente = tb_cod_pais.Text;
                pais_cliente = tb_pais.Text;
                telefone_cliente = tb_fone.Text;
                cidade_cliente = tb_cidade.Text;
                if (cb_pessoa_fisica.Checked == true)
                {
                    pessoa_fisica = true;
                    cpf_cliente = tb_cnpj.Text;
                }
                
                if (confirmacao == true)
                    this.Close();
                else
                    selecionar_contatos();
                
            }

           // datClientes.Fill(CLIENTES);

            //Carregando os dados de classificação no comboBox------------------------------//
            datClassificacaoClientes.Fill(CLASSIFICACAO_CLIENTES); //Preenchendo DataTable
            cbxClassificacao.DataSource = CLASSIFICACAO_CLIENTES;  //Preenchendo ComboBox
            cbxClassificacao.DisplayMember = "descricao";          //Definindo Legenda
            cbxClassificacao.ValueMember = "cod";                  //Definindo Valor
            //------------------------------------------------------------------------------//


        }

        private void vai_primeiro_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsClientes, "CLIENTES"].Position = 0;
        }

        private void vai_anterior_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsClientes, "CLIENTES"].Position--;
        }

        private void vai_proximo_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsClientes, "CLIENTES"].Position++;
        }

        private void vai_ultimo_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsClientes, "CLIENTES"].Position = 100000000;
        }

        private void novo_registro_Click(object sender, EventArgs e)
        {
            try
            {
                this.datClientes.DeleteCommand.CommandText =
                "DELETE FROM CLIENTES WHERE CNPJ = '000'";
                this.fbConnection1.Open();
                this.datClientes.DeleteCommand.Connection = fbConnection1;
                this.datClientes.DeleteCommand.ExecuteNonQuery();
                this.fbConnection1.Close();

                this.datClientes.DeleteCommand.CommandText =
                "DELETE FROM CLIENTES WHERE RAZAO_SOCIAL = 'NOVO'";
                this.fbConnection1.Open();
                this.datClientes.DeleteCommand.Connection = fbConnection1;
                this.datClientes.DeleteCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
                

                this.datClientes.InsertCommand.CommandText =
                    "INSERT INTO CLIENTES(CNPJ, RAZAO_SOCIAL) VALUES('000', 'NOVO')";
                this.fbConnection1.Open();
                this.datClientes.InsertCommand.Connection = fbConnection1;
                this.datClientes.InsertCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
                dsClientes.Clear();
                this.datClientes.SelectCommand.CommandText =
                "SELECT * FROM CLIENTES WHERE CNPJ = '000'";
                this.fbConnection1.Open();
                this.datClientes.SelectCommand.Connection = fbConnection1;
                this.datClientes.SelectCommand.ExecuteNonQuery();
                datClientes.Fill(CLIENTES);
                this.fbConnection1.Close();
                razao.Focus();
            }
            catch
            {
                MessageBox.Show("Erro validando...");
                fbConnection1.Close();
            }
        }
        private void Atualizar()
        {
            this.BindingContext[dsClientes, "CLIENTES"].EndCurrentEdit();
            if (dsClientes.HasChanges())
            {
                try
                {
                    //MessageBox.Show("CHEGOU AQUI");
                    fbConnection1.Open();
                    datClientes.UpdateCommand = fbCommandBuilder1.GetUpdateCommand(); // o problema está cin esse comando pra passar o dscliente para a tabela clientes
                    datClientes.InsertCommand = fbCommandBuilder1.GetInsertCommand();
                    datClientes.DeleteCommand = fbCommandBuilder1.GetDeleteCommand();
                    datClientes.Update(dsClientes, "CLIENTES");
                    dsClientes.AcceptChanges();
                    fbConnection1.Close();
                }
                catch
                {
                    MessageBox.Show("Erro, tente novamente");
                    fbConnection1.Close();
                }
            }
        }

        private void salva_registro_Click(object sender, EventArgs e)
        {
            Atualizar();
        }

        private void fbConnection1_InfoMessage(object sender, FirebirdSql.Data.FirebirdClient.FbInfoMessageEventArgs e)
        {

        }

        private void fbConnection2_InfoMessage(object sender, FirebirdSql.Data.FirebirdClient.FbInfoMessageEventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void fbConnection1_InfoMessage_1(object sender, FbInfoMessageEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            localizar();
        }

        private void apaga_registro_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("O registro será excluído permanentemente, tem certeza?",
                "Confirma a exclusão?", MessageBoxButtons.YesNo))
            {
                this.datClientes.DeleteCommand.CommandText =
                "DELETE FROM CLIENTES WHERE COD_CLIENTE = '" + codigo.Text + "'";
                this.fbConnection1.Open();
                this.datClientes.DeleteCommand.Connection = fbConnection1;
                this.datClientes.DeleteCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
                dsClientes.Clear();
                datClientes.Fill(CLIENTES);
                //Atualizar();
                //this.Close();

            }
                
        }

        private void codigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void razao_DoubleClick(object sender, EventArgs e)
        {
            //localizar();
        }

        private void localizar()
        {
            form_localiza_cliente localiza_cliente = new form_localiza_cliente(false);
            try
            {
                localiza_cliente.ShowDialog();
            }
            finally
            {
                localiza_cliente.Dispose();
                dsClientes.Clear();
                //MessageBox.Show(localiza_peca.peca_escolhida);
                //tb_cliente.Text = localiza_cliente.cliente_escolhido;
                this.datClientes.SelectCommand.CommandText =
                "SELECT * FROM CLIENTES WHERE CNPJ = '" + localiza_cliente.cnpj_escolhido + "'";
                this.fbConnection1.Open();
                this.datClientes.SelectCommand.Connection = fbConnection1;
                this.datClientes.SelectCommand.ExecuteNonQuery();
                datClientes.Fill(CLIENTES);
                this.fbConnection1.Close();
                selecionar_contatos();

            }
        }


        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dsImprimir_op cli = new dsImprimir_op();
            fbConnection1.Open();
            //datTabela_impressao.Fill(dsRelatorio.TABELA_IMPRESSAO);
            datClientes.Fill(cli.CLIENTES);
            datContatos.Fill(cli.CONTATOS);
            //datOperadores.Fill(dsRelatorio.OPERADORES);
            //datParadas.Fill(dsRelatorio.PARADAS);
            fbConnection1.Close();
            crCliente op_nova = new crCliente();
            op_nova.SetDataSource(cli);
            op_nova.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4;
            op_nova.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto;
            form_imprimir imprimir = new form_imprimir(op_nova);
            imprimir.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tb_nome_contato.Text == "")
            {
                MessageBox.Show("Digite ao menos o nome, por favor");
            }
            else
            {
                string _nome = "", _email = "", _tel_1 = "", _tel_2 = "", _tipo = "";
                if (tb_nome_contato.Text == "")
                {
                    _nome = "null";
                }
                else
                {
                    _nome = "'" + tb_nome_contato.Text + "'";
                }
                if (tb_email.Text == "")
                {
                    _email = "null";
                }
                else
                {
                    _email = "'" + tb_email.Text + "'";
                }
                if (tb_telefone_1.Text == "")
                {
                    _tel_1 = "null";
                }
                else
                {
                    _tel_1 = "'" + tb_telefone_1.Text + "'";
                }
                if (tb_telefone_2.Text == "")
                {
                    _tel_2 = "null";
                }
                else
                {
                    _tel_2 = "'" + tb_telefone_2.Text + "'";
                }
                if (tb_tipo.Text == "")
                {
                    _tipo = "null";
                }
                else
                {
                    _tipo = "'" + tb_tipo.Text + "'";
                }



                try
                {
                    // colocar os campos corretamente para inserir o contato, depois acertar a busca do contato no envio do email
                    this.datContatos.InsertCommand.CommandText =
                           "INSERT INTO CONTATOS(NOME_CONTATO, EMAIL_CONTATO, TEL_1_CONTATO, TEL_2_CONTATO, CLIENTE_FORN_CONTATO, COD_CLIENTE_FORN_CONTATO, TIPO_CONTATO) VALUES(" + _nome + "," + _email + "," + _tel_1 + "," + _tel_2 + "," + "'CLIENTE'" + "," + codigo.Text + "," + _tipo + ")";
                    this.fbConnection1.Open();
                    this.datContatos.InsertCommand.Connection = fbConnection1;
                    this.datContatos.InsertCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                    selecionar_contatos();
                    tb_nome_contato.Text = "";
                    tb_telefone_1.Text = "";
                    tb_telefone_2.Text = "";
                    tb_tipo.Text = "";
                    tb_email.Text = "";
                }
                catch
                {
                    fbConnection1.Close();
                    MessageBox.Show("Erro na inserção do contato");
                }
            }
        }
        private void selecionar_contatos()
        {
            try
            {
                dsContatos.Clear();
                this.datContatos.SelectCommand.CommandText =
                        "SELECT * FROM CONTATOS WHERE COD_CLIENTE_FORN_CONTATO = '" + codigo.Text + "' AND CLIENTE_FORN_CONTATO = 'CLIENTE'";
                this.fbConnection1.Open();
                this.datContatos.SelectCommand.Connection = fbConnection1;
                this.datContatos.SelectCommand.ExecuteNonQuery();
                datContatos.Fill(CONTATOS);
                this.fbConnection1.Close();
            }
            catch
            {
                fbConnection1.Close();
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"http://www.ibge.gov.br/home/geociencias/areaterritorial/area.php?nome=" + tb_cidade.Text +"&codigo=&submit.x=7&submit.y=4");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"http://www.buscacep.correios.com.br/servicos/dnec/menuAction.do?Metodo=menuLogradouro");
        }

        private void tb_Cep_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsEndereco.Endereco en = new clsEndereco.Endereco();
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                DataSet dsX = new DataSet();
                DataRow drX;
                try
                {
                    dsX.ReadXml(@"http://www.buscarcep.com.br/?cep=" + tb_Cep.Text + "&formato=xml&chave=1xXQkOKNhiJF.jO7Yt0Kifh5GS7w29/");
                }
                catch
                {
                    MessageBox.Show("Não foi possível encontrar o WebService do site: www.buscarcep.com.br. \n\n Verifique sua Conexão de Internet !" + "\r\n", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                drX = dsX.Tables["retorno"].Rows[0]; // Captura a 1ª linha da tabela do XML
                en.Resul = int.Parse(drX["resultado"].ToString()); //Captura o resultado do WS
                if (en.Resul == 1) // O cep foi localizado
                {
                    try
                    {
                        en.TipoLogradouro = drX["tipo_logradouro"].ToString();
                        en.Logradouro = drX["logradouro"].ToString();
                        en.Bairro = drX["bairro"].ToString();
                        en.Cidade = drX["cidade"].ToString();
                        en.UF = drX["uf"].ToString();
                        en.IBGE = drX["ibge_municipio_verificador"].ToString();

                        tb_logradouro.Text = en.TipoLogradouro.ToUpper();
                        tb_logradouro.Text += ' ' + en.Logradouro.ToUpper();
                        tb_bairro.Text = en.Bairro.ToUpper();
                        tb_cidade.Text = en.Cidade.ToUpper();
                        tb_estado.Text = en.UF.ToUpper();
                        tb_cod_cidade.Text = en.IBGE;
                    }

                    catch
                    {
                        MessageBox.Show("erro");
                    }

                }
                else if (en.Resul == -1) { Limpar(); MessageBox.Show("Cep não encontrado !" + "\r\n", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                else if (en.Resul == -2) { Limpar(); MessageBox.Show("Formato de CEP inválido !" + "\r\n", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                else if (en.Resul == -3) { Limpar(); MessageBox.Show("Busca de CEP congestionada. \n Aguarde alguns segundos e tente novamente. !" + "\r\n", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                else if (en.Resul == -4) { Limpar(); MessageBox.Show("IP Banido. \n contate o administrador !" + "\r\n", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                else if (en.Resul == -5) { Limpar(); MessageBox.Show("Chave banida. contate o administrador !" + "\r\n", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                else { Limpar(); MessageBox.Show("Erro na busca de CEP !" + "\r\n", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }
        private void Limpar()
        {
            foreach (Control ctr in this.Controls)
            {
                foreach (Control txt in ctr.Controls)
                {
                    if (txt is TextBox) { ((TextBox)txt).Text = ""; }
                }
            }
            tb_Cep.Focus();
        }

    }
}