using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Data.OleDb;
using System.Text.RegularExpressions;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

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
        public bool fornecedor;
        public string cnpj_empresa;
        public form_clientes(string cnpj_empresa)
        {
            InitializeComponent();
            this.cnpj_empresa = cnpj_empresa;
        }

        private void form_clientes_Load(object sender, EventArgs e)
        {
            if (fornecedor)
            {
                labelNome.Text = "Fornecedores";
                this.Text = "Fornecedores";
                //List<String>
                comboBoxTipo.Items.Clear();

                comboBoxTipo.Items.Add("Fornecedor Produtivo");
                comboBoxTipo.Items.Add("Fornecedor Ativo Imobilizado");
                comboBoxTipo.Items.Add("Fornecedor Uso e Consumo");

                tabControl1.TabPages.Remove(tabPageOutros);
                tabControl1.TabPages.Remove(tabPageTabelaPrecos);
                tabControl1.TabPages.Remove(tabPageVendas);
                tabControl1.TabPages.Remove(tabPageDadosAdicionais);

                panelContasaReceber.Visible = false;
                    
            }
            if (consulta == true)
            {
                try
                {
                    this.datClientes.SelectCommand.CommandText =
                    "SELECT * FROM CLIENTES WHERE CNPJ = '" + cliente_consulta + "'";
                    this.fbConnection1.Open();
                    this.datClientes.SelectCommand.Connection = fbConnection1;
                    this.datClientes.SelectCommand.ExecuteNonQuery();
                    datClientes.Fill(CLIENTES);
                    this.fbConnection1.Close();
                    selecionar_vendedores(codigo.Text);

                   

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

                    this.datContas.SelectCommand.CommandText =
                        "SELECT * FROM CONTAS_A_RECEBER WHERE COD_CLIENTE_CR = '" + codigo.Text +
                        "' AND (RECEBIDO_CR = 0 or RECEBIDO_CR IS NULL) " +
                        " ORDER BY DATA_PREVISTA_CR";
                    this.datContas.SelectCommand.Connection = fbConnection1;
                    fbConnection1.Open();
                    this.datContas.SelectCommand.ExecuteNonQuery();
                    this.datContas.Fill(CONTAS_A_RECEBER);
                    fbConnection1.Close();
                    somar_contas();
                    selecionar_itens_tp();
                    selecionar_itensPedAntigo();
                    selecionar_pedidos();
                    selecionar_valores_operacao();
                    selecionar_pagamentos_caract();
                    
                }
                catch
                {
                    fbConnection1.Close();
                }

            }
            
           // datClientes.Fill(CLIENTES);

            //Carregando os dados de classificação no comboBox------------------------------//
            try
            {
                datClassificacaoClientes.Fill(CLASSIFICACAO_CLIENTES); //Preenchendo DataTable
                cbxClassificacao1.DataSource = CLASSIFICACAO_CLIENTES;  //Preenchendo ComboBox
                cbxClassificacao1.DisplayMember = "descricao";          //Definindo Legenda
                cbxClassificacao1.ValueMember = "cod";                  //Definindo Valor
                //------------------------------------------------------------------------------//

                //Carregando os dados de forma de pagamento no comboBox------------------------------//
                datFormaPagamento.Fill(FORMA_PGTO);                         //Preenchendo DataTable
                cbxFormaPagamento.DataSource = FORMA_PGTO;                  //Preenchendo ComboBox
                cbxFormaPagamento.DisplayMember = "descricao_forma_pgto";   //Definindo Legenda
                cbxFormaPagamento.ValueMember = "cod_forma_pgto";           //Definindo Valor
                //------------------------------------------------------------------------------//
            }
            catch { }
        }

        private void selecionar_itensPedAntigo()
        {
            try
            {
                dsItemPedAntigo.Clear();
                fbConnection1.Open();
                datItemPedAntigo.SelectCommand.CommandText =
                        "SELECT * FROM ITEMPED WHERE PC_CLI = '" + tb_cnpj.Text + "' order by PC_EMISSAO desc";
                datItemPedAntigo.Fill(ITEMPED);
                fbConnection1.Close();
               // dgvItemPedAntigo.AutoGenerateColumns = false;
                //dgvItemPedAntigo.DataSource = dsItemPedAntigo.Tables["ITEMPED"];
            }
            catch (Exception a)
            {
                fbConnection1.Close();
            }
        }

        private void somar_contas()
        {
            double valor_total = 0;

            for (int i = 0; i < dgvContas.RowCount; i++)
            {
                valor_total = valor_total + Convert.ToDouble(dgvContas.Rows[i].Cells["col_valor"].Value.ToString());
            }
            tb_total.Text = valor_total.ToString("n2");
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

                string fornecedor_cliente = "0";
                if (fornecedor)
                    fornecedor_cliente = "1";


                this.datClientes.InsertCommand.CommandText =
                    "INSERT INTO CLIENTES(CNPJ, RAZAO_SOCIAL, FORNECEDOR_CLIENTE) VALUES('000', 'NOVO', '" + fornecedor_cliente + "') RETURNING COD_CLIENTE";
                this.fbConnection1.Open();
                this.datClientes.InsertCommand.Connection = fbConnection1;
                object cod = datClientes.InsertCommand.ExecuteScalar();
                this.fbConnection1.Close(); 
                dsClientes.Clear();
                this.datClientes.SelectCommand.CommandText =
                "SELECT * FROM CLIENTES WHERE COD_CLIENTE = '" + cod.ToString() + "'";
                this.fbConnection1.Open();
                this.datClientes.SelectCommand.Connection = fbConnection1;
                this.datClientes.SelectCommand.ExecuteNonQuery();
                datClientes.Fill(CLIENTES);
                this.fbConnection1.Close();
                tb_cnpj.Text = cod.ToString();
                Atualizar();
                razao.Focus();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                fbConnection1.Close(); 
            }
        }
        private void Atualizar()
        {
            try
            {
                this.BindingContext[dsClientes, "CLIENTES"].EndCurrentEdit();
                if (dsClientes.HasChanges())
                {

                    fbConnection1.Open();
                    datClientes.UpdateCommand = fbCommandBuilder1.GetUpdateCommand();
                    datClientes.InsertCommand = fbCommandBuilder1.GetInsertCommand();
                    datClientes.DeleteCommand = fbCommandBuilder1.GetDeleteCommand();
                    datClientes.Update(dsClientes, "CLIENTES");
                    dsClientes.AcceptChanges();
                    fbConnection1.Close();



                }

                this.BindingContext[dsVendedores, "VENDEDORES_CLIENTE"].EndCurrentEdit();
                if (dsVendedores.HasChanges())
                {
                    fbConnection1.Open();
                    datVendedores.DeleteCommand = cbVendedores.GetDeleteCommand();
                    datVendedores.Update(dsVendedores, "VENDEDORES_CLIENTE");
                    dsVendedores.AcceptChanges();
                    fbConnection1.Close();



                }
                this.BindingContext[dsContatos, "CONTATOS"].EndCurrentEdit();
                if (dsContatos.HasChanges())
                {

                    //MessageBox.Show("CHEGOU AQUI");
                    fbConnection1.Open();
                    datContatos.UpdateCommand = cbContatos.GetUpdateCommand();
                    datContatos.InsertCommand = cbContatos.GetInsertCommand();
                    datContatos.DeleteCommand = cbContatos.GetDeleteCommand();
                    datContatos.Update(dsContatos, "CONTATOS");
                    dsContatos.AcceptChanges();
                    fbConnection1.Close();

                }
                this.BindingContext[dsItens_tp, "ITENS_TP"].EndCurrentEdit();
                if (dsItens_tp.HasChanges())
                {


                    fbConnection1.Open();
                    datItens_tp.UpdateCommand = cbItens_tp.GetUpdateCommand();
                    datItens_tp.InsertCommand = cbItens_tp.GetInsertCommand();
                    datItens_tp.DeleteCommand = cbItens_tp.GetDeleteCommand();
                    datItens_tp.Update(dsItens_tp, "ITENS_TP");
                    dsItens_tp.AcceptChanges();
                    fbConnection1.Close();

                }
                this.BindingContext[dsValor_operacao_cliente, "VALOR_OPERACAO_CLIENTE"].EndCurrentEdit();
                if (dsValor_operacao_cliente.HasChanges())
                {
                    try
                    {
                        //MessageBox.Show("CHEGOU AQUI");
                        fbConnection1.Open();
                        datValor_operacao_cliente.UpdateCommand = cbValor_operacao_cliente.GetUpdateCommand();
                        datValor_operacao_cliente.InsertCommand = cbValor_operacao_cliente.GetInsertCommand();
                        datValor_operacao_cliente.DeleteCommand = cbValor_operacao_cliente.GetDeleteCommand();
                        datValor_operacao_cliente.Update(dsValor_operacao_cliente, "VALOR_OPERACAO_CLIENTE");
                        dsValor_operacao_cliente.AcceptChanges();
                        fbConnection1.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Erro, tente novamente");
                        fbConnection1.Close();
                    }
                }
                MessageBox.Show("Salvo!");
            }
            catch (Exception ex)
            {
                fbConnection1.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void salva_registro_Click(object sender, EventArgs e)
        {
            validacaDados();
            Atualizar();
            
            try
            {
                tb_inicio_entrega.Text = Convert.ToDateTime(tb_inicio_entrega.Text).ToShortTimeString();
                tb_fim_entrega.Text = Convert.ToDateTime(tb_fim_entrega.Text).ToShortTimeString();
            }
            catch { }
        }

        private void validacaDados()
        {
            try
            {
                string cnpj = tb_cnpj.Text.ToString().Trim().Replace("\t","").Replace(" ", "");
                tb_cnpj.Text = cnpj;
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao validar dados");
            }
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
            form_localiza_cliente localiza_cliente = new form_localiza_cliente(false, cnpj_empresa);
            try
            {
                localiza_cliente.pesquisa_fornecedor = fornecedor;
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
                selecionar_vendedores(localiza_cliente.cod_escolhido);
                selecionar_itens_tp();
                selecionar_pedidos();
            }
        }

        private void selecionar_vendedores(string codigoCliente)
        {
            FbCommand selectVendedor = new FbCommand();

            try
            {
                dsVendedores.Clear();
                selectVendedor.CommandText =
                    "SELECT vc.* " +
                    "FROM vendedores_cliente vc " +
                    "WHERE vc.cod_cliente_vc = " + codigoCliente;
                datVendedores.SelectCommand = selectVendedor;
                datVendedores.SelectCommand.Connection = fbConnection1;
                fbConnection1.Open();
                datVendedores.SelectCommand.ExecuteNonQuery();
                datVendedores.Fill(VENDEDORES_CLIENTE);
                fbConnection1.Close(); 
            }
            catch(Exception a)
            {
                fbConnection1.Close(); 
                MessageBox.Show("Houve um erro ao selecionar os vendedores deste cliente!\nErro: " + a.Message);
            }
        }


        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                tb_inicio_entrega.Text = Convert.ToDateTime(tb_inicio_entrega.Text).ToShortTimeString();
                tb_fim_entrega.Text = Convert.ToDateTime(tb_fim_entrega.Text).ToShortTimeString();
            }
            catch { }
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
        public static string SubstituiCaracteresEspeciais(string strline)
        {
            try
            {
                strline = strline.Replace("ã", "a");
                strline = strline.Replace('Ã', 'A');
                strline = strline.Replace('â', 'a');
                strline = strline.Replace('Â', 'A');
                strline = strline.Replace('á', 'a');
                strline = strline.Replace('Á', 'A');
                strline = strline.Replace('à', 'a');
                strline = strline.Replace('À', 'A');
                strline = strline.Replace('ç', 'c');
                strline = strline.Replace('Ç', 'C');
                strline = strline.Replace('é', 'e');
                strline = strline.Replace('É', 'E');
                strline = strline.Replace('Ê', 'E');
                strline = strline.Replace('ê', 'e');
                strline = strline.Replace('õ', 'o');
                strline = strline.Replace('Õ', 'O');
                strline = strline.Replace('ó', 'o');
                strline = strline.Replace('Ó', 'O');
                strline = strline.Replace('ô', 'o');
                strline = strline.Replace('Ô', 'O');
                strline = strline.Replace('ú', 'u');
                strline = strline.Replace('Ú', 'U');
                strline = strline.Replace('ü', 'u');
                strline = strline.Replace('Ü', 'U');
                strline = strline.Replace('í', 'i');
                strline = strline.Replace('Í', 'I');
                strline = strline.Replace('ª', 'a');
                strline = strline.Replace('º', 'o');
                strline = strline.Replace('°', 'o');
                strline = strline.Replace('&', 'e');

                return strline;
            }
            catch (Exception ex)
            {
                Exception tmpEx = new Exception("Erro ao formatar string.", ex);
                throw tmpEx;
            }
        }

        private string buscar_cod_mun(string _cidade)
        {
            try
            {
                DataSet theDS = new DataSet();
                OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:\\evolucao\\excel\\munic.xls';Extended Properties=\"Excel 8.0;HDR=NO;IMEX=1;\"");
                theConnection.Open();
                OleDbDataAdapter theDataAdapter = new OleDbDataAdapter("SELECT * FROM [Mun$]", theConnection);

                theDataAdapter.Fill(theDS);
                theConnection.Close();
                string cidade = _cidade.ToUpper().Replace("\t", "");
                foreach (DataRow dr in theDS.Tables[0].Select("F3 = '" + cidade + "'"))
                {
                    return dr[1].ToString();
                }

                return "";
            }
            catch
            {
                return "";
            }
        }
        public class Endereco
        {
            public string Cep { get; set; }
            public string Logradouro { get; set; }
            public string Complemento { get; set; }
            public string Bairro { get; set; }
            public string Localidade { get; set; }
            public string Uf { get; set; }
            public string Ibge { get; set; }
            public string Gia { get; set; }
            public string Ddd { get; set; }
            public string Siafi { get; set; }
        }

        private static readonly HttpClient client = new HttpClient();
        private async Task ConsultaCEPAsync(string cep)
        {
            string url = $"https://viacep.com.br/ws/{cep}/json/";
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            try
            {

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";

                using (HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync())
                {
                    using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                    {
                        string responseBody = await reader.ReadToEndAsync();
                        Endereco endereco = JsonConvert.DeserializeObject<Endereco>(responseBody);
                        tb_bairro.Text = endereco.Bairro.ToUpper();
                        tb_cidade.Text = endereco.Localidade.ToUpper();
                        tb_logradouro.Text = endereco.Logradouro.ToUpper();
                        tb_estado.Text = endereco.Uf.ToUpper();
                        tb_cod_cidade.Text = endereco.Ibge;
                        // Processa o resultado...
                    }
                }

            }
            catch (HttpRequestException e)
            {
                MessageBox.Show("Erro na consulta do CEP: " + e.Message);
            }
        }

        private async void tb_Cep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                string cep = tb_Cep.Text; // Substitua pelo CEP que deseja consultar
                await ConsultaCEPAsync(cep);
            }

            //if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            //{

            //        webCEP.AtendeClienteService web = new webCEP.AtendeClienteService();
            //        try
            //        {
            //            //string cpf = tb_cpf.Text;

            //            var dados = web.consultaCEP(tb_Cep.Text);


            //            if (dados != null)
            //            {
            //                tb_bairro.Text = SubstituiCaracteresEspeciais(dados.bairro.ToUpper());
            //                tb_cidade.Text = SubstituiCaracteresEspeciais(dados.cidade.ToUpper());
            //                tb_logradouro.Text = SubstituiCaracteresEspeciais(dados.end.ToUpper());
            //                tb_estado.Text = SubstituiCaracteresEspeciais(dados.uf.ToUpper());
            //                tb_cod_cidade.Text = buscar_cod_mun(tb_cidade.Text);
            //            }
            //            else
            //            {
            //                MessageBox.Show("CEP inexistente");
            //            }
            //        }
            //        catch (Exception a)
            //        {
            //            MessageBox.Show(a.Message);
            //        }




            //}
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

        private void txtCodVendedor_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F2)
            {
                form_vendedores vendedores = new form_vendedores();

                try
                {
                    vendedores.ShowDialog();
                }
                finally
                {
                    txtCodVendedor.Text = vendedores.cod_vendedor_escolhido;
                    txtNomeVendedor.Text = vendedores.vendedor_escolhido;

                    btnInserirVendedor.Focus();
                }
            }
        }

        private void txtNomeVendedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                form_vendedores vendedores = new form_vendedores();

                try
                {
                    vendedores.ShowDialog();
                }
                finally
                {
                    txtCodVendedor.Text = vendedores.cod_vendedor_escolhido;
                    txtNomeVendedor.Text = vendedores.vendedor_escolhido;

                    btnInserirVendedor.Focus();
                }
            }
        }

        private void txtCodVendedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                FbCommand selectVendedor = new FbCommand();
                FbDataAdapter datVendedor = new FbDataAdapter();
                DataTable dtVendedor = new DataTable();

                try
                {
                    selectVendedor.CommandText =
                        "SELECT v.cod_vendedor, v.nome_vendedor " +
                        "FROM vendedores v " + 
                        "WHERE v.cod_vendedor = " + txtCodVendedor.Text;
                    datVendedor.SelectCommand = selectVendedor;
                    datVendedor.SelectCommand.Connection = fbConnection1;
                    fbConnection1.Open();
                    datVendedor.SelectCommand.ExecuteNonQuery();
                    datVendedor.Fill(dtVendedor);
                    fbConnection1.Close(); 

                    if (dtVendedor.Rows.Count > 0)
                    {
                        txtCodVendedor.Text = dtVendedor.Rows[0]["cod_vendedor"].ToString();
                        txtNomeVendedor.Text = dtVendedor.Rows[0]["nome_vendedor"].ToString();

                        btnInserirVendedor.Focus();
                    }
                    else
                    {
                        throw new Exception("Não há vendedor com este código!");
                    }
                }
                catch(Exception a)
                {
                    fbConnection1.Close(); 
                    MessageBox.Show("Houve um erro ao selecionar o vendedor!\nErro: " + a.Message);
                }
            }
        }

        private void txtCodVendedor_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            form_vendedores vendedores = new form_vendedores();

            try
            {
                vendedores.ShowDialog();
            }
            finally
            {
                txtCodVendedor.Text = vendedores.cod_vendedor_escolhido;
                txtNomeVendedor.Text = vendedores.vendedor_escolhido;

                btnInserirVendedor.Focus();
            }
        }

        private void txtNomeVendedor_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            form_vendedores vendedores = new form_vendedores();

            try
            {
                vendedores.ShowDialog();
            }
            finally
            {
                txtCodVendedor.Text = vendedores.cod_vendedor_escolhido;
                txtNomeVendedor.Text = vendedores.vendedor_escolhido;

                btnInserirVendedor.Focus();
            }
        }

        private void btnInserirVendedor_Click(object sender, EventArgs e)
        {
            if (codigo.Text == "")
            {
                MessageBox.Show("Selecione um cliente!");
            }
            else
            {
                if (txtCodVendedor.Text == "")
                {
                    MessageBox.Show("Selecione um vendedor!");
                }
                else
                {
                    FbCommand insereVendedor = new FbCommand();
                    FbCommand selectVendedor = new FbCommand();

                    string codigoCliente;
                    string codigoVendedor;
                    string nomeVendedor;

                    try
                    {
                        codigoCliente = codigo.Text;
                        codigoVendedor = txtCodVendedor.Text;
                        nomeVendedor = txtNomeVendedor.Text;

                        nomeVendedor = nomeVendedor == "" ? "null" : "'" + nomeVendedor + "'";

                        insereVendedor.CommandText =
                            "INSERT INTO vendedores_cliente (cod_cliente_vc, cod_vendedor_vc, nome_vendedor_vc) VALUES (" + codigoCliente + ", " + codigoVendedor + ", " + nomeVendedor + ")";
                        datVendedores.InsertCommand = insereVendedor;
                        datVendedores.InsertCommand.Connection = fbConnection1;
                        fbConnection1.Open();
                        datVendedores.InsertCommand.ExecuteNonQuery();
                        fbConnection1.Close(); 

                        txtCodVendedor.Text = "";
                        txtNomeVendedor.Text = "";

                        dsVendedores.Clear();
                        selectVendedor.CommandText =
                            "SELECT vc.* " + 
                            "FROM vendedores_cliente vc " + 
                            "WHERE vc.cod_cliente_vc = " + codigoCliente;
                        datVendedores.SelectCommand = selectVendedor;
                        datVendedores.SelectCommand.Connection = fbConnection1;
                        fbConnection1.Open();
                        datVendedores.SelectCommand.ExecuteNonQuery();
                        datVendedores.Fill(VENDEDORES_CLIENTE);
                        fbConnection1.Close(); 

                        txtCodVendedor.Focus();
                    }
                    catch (Exception a)
                    {
                        fbConnection1.Close(); 
                        MessageBox.Show("Houve um erro ao inserir o vendedor!\nErro: " + a.Message);
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            form_vendedores vendedores = new form_vendedores();

            try
            {
                vendedores.ShowDialog();
            }
            finally
            {
                txtCodVendedor.Text = vendedores.cod_vendedor_escolhido;
                txtNomeVendedor.Text = vendedores.vendedor_escolhido;


            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
             form_dia_visita dia = new form_dia_visita();
             try
             {
                 dia.ShowDialog();
             }
             finally
             {
                 tb_dia_visita.Text = dia.cod_dia_visita;
             }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            form_localiza_tabela_preco tab = new form_localiza_tabela_preco();
            try
            {
                tab.ShowDialog();
            }
            finally
            {
                tb_cod_tabela.Text = tab._cod;
                tb_nome_tabela_preco.Text = tab._descricao;
            }
        
        }

        private void tb_inicio_entrega_Validated(object sender, EventArgs e)
        {
            try
            {
                tb_inicio_entrega.Text = Convert.ToDateTime(tb_inicio_entrega.Text).ToShortTimeString();
               
            }
            catch { }
        }

        private void tb_inicio_entrega_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                tb_inicio_entrega.Text = Convert.ToDateTime(tb_inicio_entrega.Text).ToShortTimeString();
               
            }
            catch { }
        }

        private void tb_fim_entrega_Validated(object sender, EventArgs e)
        {

            try
            {
               
                tb_fim_entrega.Text = Convert.ToDateTime(tb_fim_entrega.Text).ToShortTimeString();
            }
            catch { }
        }

        private void tb_fim_entrega_Validating(object sender, CancelEventArgs e)
        {
            try
            {

                tb_fim_entrega.Text = Convert.ToDateTime(tb_fim_entrega.Text).ToShortTimeString();
            }
            catch { }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                FbCommand insert = new FbCommand();
                insert.Connection = fbConnection1;
                insert.CommandText =
                            "INSERT INTO TABELA_PRECO (NOME_TABELA_PRECO)" +
                            "VALUES ('" + codigo.Text + "') RETURNING COD_TABELA_PRECO";
                fbConnection1.Open();
                FbDataAdapter datInsert = new FbDataAdapter();
                datInsert.InsertCommand = insert;
                object cod_tp = datInsert.InsertCommand.ExecuteScalar();
                fbConnection1.Close();
                tb_cod_tabela.Text = cod_tp.ToString();
                tb_nome_tabela_preco.Text = codigo.Text;
                Atualizar();

                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                        "SELECT COD_GRUPO, DESCRICAO_GRUPO FROM GRUPOS ORDER BY COD_GRUPO";
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();

                foreach (DataRow dr in dtSelect.Rows)
                {
                    FbCommand insertItens = new FbCommand();
                    insertItens.Connection = fbConnection1;
                    insertItens.CommandText =
                   "INSERT INTO ITENS_TP (COD_TABELA_ITEM_TP, COD_PRODUTO_ITEM_TP, DESCRICAO_PRODUTO_ITEM_TP, PRECO_PRODUTO_ITEM_TP, PRECO_MINIMO_ITEM_TP)" +
                               "VALUES ('" + cod_tp + "','" + dr[0].ToString() + "','" + dr[1].ToString() + "',0,0)";
                    fbConnection1.Open();
                    FbDataAdapter datInsertItens = new FbDataAdapter();
                    datInsertItens.InsertCommand = insertItens;
                    datInsertItens.InsertCommand.ExecuteNonQuery();
                    fbConnection1.Close();
                }

                selecionar_itens_tp();
            }
            catch
            {
                fbConnection1.Close();
            }
        }

        private void selecionar_itens_tp()
        {
            try
            {
                dsItens_tp.Clear();
                datItens_tp.SelectCommand.CommandText =
              "SELECT itp.* FROM ITENS_TP itp " + 
              "INNER JOIN TABELA_PRECO tp on tp.COD_TABELA_PRECO = itp.COD_TABELA_ITEM_TP " +
              "WHERE tp.NOME_TABELA_PRECO = '" + codigo.Text + "'";
                fbConnection1.Open();
                datItens_tp.SelectCommand.Connection = fbConnection1;
                datItens_tp.Fill(ITENS_TP);
                fbConnection1.Close();
                if (dgvItens_tp.Columns[0].HeaderText == "COD_ITEM_TP")
                    dgvItens_tp.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                fbConnection1.Close();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (cbTipo_pgto.Text == "")
            {
                MessageBox.Show("Selecione o tipo do pagamento");

            }
            else
            {
                try
                {
                    FbCommand insert = new FbCommand();
                    insert.CommandText = "INSERT INTO PAGAMENTOS_CARACT (CNPJ_CLIENTE_PC, NUMERO_PC, TIPO_PC) VALUES ('" + tb_cnpj.Text + "','" + tb_n_pgto.Text + "','" + cbTipo_pgto.Text + "')";
                    insert.Connection = fbConnection1;
                    fbConnection1.Open();
                    FbDataAdapter datInsert = new FbDataAdapter();
                    datInsert.InsertCommand = insert;
                    datInsert.InsertCommand.ExecuteNonQuery();
                    fbConnection1.Close();
                    selecionar_pagamentos_caract();
                }
                catch(Exception  ex)
                {
                    fbConnection1.Close();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void selecionar_pagamentos_caract()
        {
            try
            {
                dsPagamentos_caract.Clear();
                datPagamentos_caract.SelectCommand.CommandText = "SELECT  * FROM PAGAMENTOS_CARACT WHERE CNPJ_CLIENTE_PC = '" + tb_cnpj.Text + "'";
                fbConnection1.Open();
                datPagamentos_caract.Fill(PAGAMENTOS_CARACT);
                fbConnection1.Close();
                dgvPagamentos_caract.DataSource = dsPagamentos_caract;
                dgvPagamentos_caract.Columns[0].Visible = false;

            }
            catch(Exception ex)
            {
                fbConnection1.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            form_grupo_produto grup = new form_grupo_produto();
            try
            {
                grup.busca = true;
                grup.ShowDialog();
            }
            finally
            {
                //tb_cod_grupo.Text = grup.cod;
                //tb_grupo.Text = grup.descricao;
                try
                {
                    string cod_tp = buscar_cod_tp(codigo.Text);
                    
                    FbCommand insertItens = new FbCommand();
                    insertItens.Connection = fbConnection1;
                    insertItens.CommandText =
                   "INSERT INTO ITENS_TP (COD_TABELA_ITEM_TP, COD_PRODUTO_ITEM_TP, DESCRICAO_PRODUTO_ITEM_TP, PRECO_PRODUTO_ITEM_TP, PRECO_MINIMO_ITEM_TP)" +
                               "VALUES ('" + cod_tp + "','" + grup.cod + "','" + grup.descricao + "',0,0)";
                    fbConnection1.Open();
                    FbDataAdapter datInsertItens = new FbDataAdapter();
                    datInsertItens.InsertCommand = insertItens;
                    datInsertItens.InsertCommand.ExecuteNonQuery();
                    fbConnection1.Close();
                    selecionar_itens_tp();
                }
                catch (Exception ex)
                {
                    fbConnection1.Close();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private string buscar_cod_tp(string descricao_tp)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                 "SELECT tp.COD_TABELA_PRECO FROM ITENS_TP itp " +
              "INNER JOIN TABELA_PRECO tp on tp.COD_TABELA_PRECO = itp.COD_TABELA_ITEM_TP " +
              "WHERE tp.NOME_TABELA_PRECO = '" + descricao_tp + "'";
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
            catch (Exception ex)
            {
                fbConnection1.Close();
                MessageBox.Show(ex.Message);
                return "";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            form_localiza_cliente localiza_cliente = new form_localiza_cliente(true, cnpj_empresa);
            try
            {
                localiza_cliente.ShowDialog();
            }
            finally
            {
                localiza_cliente.Dispose();
               // tb_nome_cliente.Text = localiza_cliente.cliente_escolhido;
                //tb_cod_cliente.Text = localiza_cliente.cod_escolhido;
              //  tb_cnpj.Text = localiza_cliente.cnpj_escolhido;
                try
                {
                    FbCommand select = new FbCommand();
                    select.Connection = fbConnection1;
                    fbConnection1.Open();
                    select.CommandText =
                      "SELECT itp.* FROM ITENS_TP itp " +
                      "INNER JOIN TABELA_PRECO tp on tp.COD_TABELA_PRECO = itp.COD_TABELA_ITEM_TP " +
                      "WHERE tp.NOME_TABELA_PRECO = '" + localiza_cliente.cod_escolhido + "'";
                    FbDataAdapter datSelect = new FbDataAdapter();
                    datSelect.SelectCommand = select;
                    DataTable dtSelect = new DataTable();
                    datSelect.Fill(dtSelect);
                    fbConnection1.Close();
                    object cod_tp = new object();
                    if (dtSelect.Rows.Count > 0)
                    {
                        FbCommand insert = new FbCommand();
                        insert.Connection = fbConnection1;
                        insert.CommandText =
                                    "INSERT INTO TABELA_PRECO (NOME_TABELA_PRECO)" +
                                    "VALUES ('" + codigo.Text + "') RETURNING COD_TABELA_PRECO";
                        fbConnection1.Open();
                        FbDataAdapter datInsert = new FbDataAdapter();
                        datInsert.InsertCommand = insert;
                        cod_tp = datInsert.InsertCommand.ExecuteScalar();
                        fbConnection1.Close();
                        tb_cod_tabela.Text = cod_tp.ToString();
                        tb_nome_tabela_preco.Text = codigo.Text;
                        Atualizar();
                    }
                    foreach (DataRow dr in dtSelect.Rows)
                    {
                        FbCommand insertItens = new FbCommand();
                        insertItens.Connection = fbConnection1;
                        insertItens.CommandText =
                       "INSERT INTO ITENS_TP (COD_TABELA_ITEM_TP, COD_PRODUTO_ITEM_TP, DESCRICAO_PRODUTO_ITEM_TP, PRECO_PRODUTO_ITEM_TP, PRECO_MINIMO_ITEM_TP)" +
                                   "VALUES ('" + cod_tp.ToString() + "','" + dr["COD_PRODUTO_ITEM_TP"].ToString() + "','" + dr["DESCRICAO_PRODUTO_ITEM_TP"].ToString() + "','" +
                        Convert.ToDouble(dr["PRECO_PRODUTO_ITEM_TP"].ToString()).ToString().Replace(".", "").Replace(",", ".") + "','" + 
                        Convert.ToDouble(dr["PRECO_MINIMO_ITEM_TP"].ToString()).ToString().Replace(".", "").Replace(",", ".") + "')";
                        fbConnection1.Open();
                        FbDataAdapter datInsertItens = new FbDataAdapter();
                        datInsertItens.InsertCommand = insertItens;
                        datInsertItens.InsertCommand.ExecuteNonQuery();
                        fbConnection1.Close();
                    }
                    selecionar_itens_tp();
                }
                catch (Exception ex)
                {
                    fbConnection1.Close();
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void tbNPedido_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsItemPedAntigo.Tables["ITEMPED"].DefaultView.RowFilter = " PC_NRPED like '*" + tbNPedido.Text + "*'" ;
            }
            catch
            {
                dsItemPedAntigo.Tables["ITEMPED"].DefaultView.RowFilter = "0 = 0";
            }
        }

        private void tbFormaPgto_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsItemPedAntigo.Tables["ITEMPED"].DefaultView.RowFilter = " FP_DESCR like '*" + tbFormaPgto.Text + "*'";
            }
            catch
            {
                dsItemPedAntigo.Tables["ITEMPED"].DefaultView.RowFilter = "0 = 0";
            }
        }

        private void tbDescricaoProduto_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsItemPedAntigo.Tables["ITEMPED"].DefaultView.RowFilter = " DESCRICAO_PROD like '*" + tbDescricaoProduto.Text + "*'";
            }
            catch
            {
                dsItemPedAntigo.Tables["ITEMPED"].DefaultView.RowFilter = "0 = 0";
            }
        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvPedidos_venda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            form_pedidos ped = new form_pedidos(cnpj_empresa);
            try
            {
                try
                {
                    ped.cnpj_empresa = cnpj_empresa;
                    ped.abrir = true;
                    ped.cod_a_abrir = dgvPedidos_venda.Rows[e.RowIndex].Cells["col_cod_interno"].Value.ToString();
                    ped.ShowDialog();
                    
                }
                catch { }
            }
            finally
            {

                ped.Dispose();
                selecionar_pedidos();
            }
        }

        private void selecionar_pedidos()
        {
            try
            {
                dsPedidos_venda.Clear();
                datPedidos_venda.SelectCommand.CommandText =
                        "SELECT * FROM PEDIDOS_VENDA WHERE CNPJ_PED_VENDA = '" + tb_cnpj.Text + "'";
                fbConnection1.Open();
                datPedidos_venda.Fill(PEDIDOS_VENDA);
                fbConnection1.Close();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.Message);
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            form_localiza_operacao abre = new form_localiza_operacao();
            try
            {
                //this.Close();
                abre.ShowDialog();

            }
            finally
            {
                abre.Dispose();
                inserir_operacoes(abre.numero_de_itens, abre.operacao_escolhida);
            }
        }

        private void inserir_operacoes(int numero, string[,] nome)
        {
            for (int i = 0; i < numero; i++)
            {
                try
                {

                    FbCommand select = new FbCommand();
                    select.Connection = fbConnection1;
                    fbConnection1.Open();
                    select.CommandText =
                        "INSERT INTO VALOR_OPERACAO_CLIENTE (OPERACAO_VOC, CNPJ_CLIENTE_VOC)" +
                        "VALUES ('" + nome[i, 0] + "','" + tb_cnpj.Text + "')";
                    datValor_operacao_cliente.InsertCommand = select;
                    datValor_operacao_cliente.InsertCommand.ExecuteNonQuery();
                    fbConnection1.Close();

                }
                catch (Exception a)
                {
                    fbConnection1.Close();
                    MessageBox.Show(a.ToString());
                }
            }
            selecionar_valores_operacao();
        }

        private void selecionar_valores_operacao()
        {
            try
            {
                dsValor_operacao_cliente.Clear();
                datValor_operacao_cliente.SelectCommand.CommandText =
                    "SELECT * FROM VALOR_OPERACAO_CLIENTE WHERE CNPJ_CLIENTE_VOC = '" + tb_cnpj.Text + "'";
                datValor_operacao_cliente.SelectCommand.Connection = fbConnection1;
                fbConnection1.Open();
                datValor_operacao_cliente.SelectCommand.ExecuteNonQuery();
                datValor_operacao_cliente.Fill(VALOR_OPERACAO_CLIENTE);
                fbConnection1.Close();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
               // MessageBox.Show(a.ToString());
            }
        }

        private void dgvValor_cliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



    }
}