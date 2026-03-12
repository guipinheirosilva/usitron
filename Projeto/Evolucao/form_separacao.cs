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
    public partial class form_separacao : Form
    {
        public string cnpj_empresa;
        public string cod_usuario;

        public string filtro;
        public string tipo, cnpj_emissor, cnpj_cliente, cod_interno_pedido, cod_produto, descricao_produto;
        public form_separacao(string cnpj_empresa)
        {
            this.cnpj_empresa = cnpj_empresa;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void selecionar_ops(string os)
        {
             try
            {
                dsOp.Clear();
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText = 
                        @"SELECT op.*, prod.* FROM OP op 
                    inner join produtos prod on op.COND_PGTO = prod.COD_FORNECEDOR_PRODUTO and prod.STATUS_PRODUTO = 1 
                 WHERE op.DESENHO_OP_ATUAL = '" + os + "' order by op.cod_op";
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
                    if (tb_cnpj_empresa.Text == "")
                    {
                        tb_cnpj_empresa.Text = cnpj_empresa;
                        tb_descricao_empresa.Text = razao_social_empresa;
                    }
                }

            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }
        
        DataTable dtItens_pedido;

        private void form_criar_ops_Load(object sender, EventArgs e)
        {
            tipo = ""; cnpj_emissor = ""; cnpj_cliente = ""; cod_interno_pedido = ""; cod_produto = ""; descricao_produto = "";
              detectar_dados_empresa(out razao_social_empresa, out nome_fantasia_empresa, out cnpj_empresa, out ie_empresa, out im_empresa, out cnae_empresa, out endereco_empresa, out n_endereco_empresa,
      out complemento_empresa, out bairro_empresa, out cidade_empresa, out estado_empresa, out cep_empresa, out telefone_empresa, out cod_cidade_empresa, out pais_empresa,
      out cod_pais_empresa, out licenca_dll_nfe_empresa, out nome_certificado_nfe_empresa, out assunto_nfe_email_empresa, out smtp_nfe_empresa, out email_nfe_empresa,
      out senha_email_nfe_empresa, out logotipo_empresa, out proxy_empresa, out usuario_proxy_empresa, out senha_proxy_empresa, out crt_empresa, out portaEmailEmpresa, out sslEmpresa, out serie_empresa,
      out boleto_pedido_empresa, out cliente_inadimplente_empresa);

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
                         @"select iped.COD_ITEM_VENDA, iped.DATA_ENTREGA_ITEM_VENDA as Data_Entrega, pv.N_PED_VENDA as Pedido, pv.COD_PED_VENDA as Cod_interno,
                    pv.CLIENTE_PED_VENDA as Cliente, iped.PEDIDO_CLIENTE_ITEM_VENDA as Pedido_Cliente,  iped.ITEM_PED_CLIENTE_ITEM_VENDA as Item_Ped_Cliente,  
                    iped.COD_SISTEMA_PROD_ITEM_VENDA as Cod_Sistema_Produto, iped.cod_prod_item_venda as Cod_Produto, 
                    iped.descricao_prod_item_venda as Item, 
                    iped.UNIDADE_PROD_ITEM_VENDA as Un, prod.estoque_atual_produto as Estoque_Atual, 
                    prod.ESTOQUE_RESERVADO_PRODUTO as Necessidade, prod.ESTOQUE_RESERVA_FECHADA_PRODUTO as Empenhado, prod.ESTOQUE_ENCOMENDADO_PRODUTO as Producao, 
                    prod.ESTOQUE_SEPARADO_PRODUTO as Separado, 
                    prod.ESTOQUE_DISPONIVEL_PRODUTO as Saldo, iped.qtde_item_venda as Qtde, qtde_item_venda as Qtde_a_Separar,
                    pv.CNPJ_EMISSOR_PED_VENDA, pv.TIPO_PED_VENDA, pv.CNPJ_PED_VENDA  
                    from itens_pedido_venda iped 
                    inner join pedidos_venda pv on iped.COD_PEDIDO_ITEM_VENDA = pv.COD_PED_VENDA 
                    inner join produtos prod on iped.COD_PROD_ITEM_VENDA = prod.COD_FORNECEDOR_PRODUTO 
                    where  iped.CONFIRMADO_ITEM_VENDA = 1 AND iped.ITEM_LIBERACAO_ITEM_VENDA IS NULL and iped.ITEM_NOTA_ITEM_VENDA is null and prod.estoque_atual_produto > 0 
                    and pv.CNPJ_EMISSOR_PED_VENDA = '" + cnpj_empresa + @"'                                                                      
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
                dgvProdutos.Columns["Cliente"].Width = 150; dgvProdutos.Columns["Cliente"].ReadOnly = true;
                dgvProdutos.Columns["Pedido_Cliente"].Width = 60; dgvProdutos.Columns["Pedido_Cliente"].ReadOnly = true;
                dgvProdutos.Columns["Item_Ped_Cliente"].Width = 30; dgvProdutos.Columns["Item_Ped_Cliente"].ReadOnly = true;
                dgvProdutos.Columns["Cod_Produto"].Width = 100; dgvProdutos.Columns["Cod_Produto"].ReadOnly = true;
                dgvProdutos.Columns["Cod_Sistema_Produto"].Width = 50; dgvProdutos.Columns["Cod_Sistema_Produto"].Visible = false; dgvProdutos.Columns["Cod_Sistema_Produto"].ReadOnly = true;
                dgvProdutos.Columns["Item"].Width = 180; dgvProdutos.Columns["Item"].ReadOnly = true;
                dgvProdutos.Columns["Un"].Width = 30; dgvProdutos.Columns["Un"].ReadOnly = true; dgvProdutos.Columns["Qtde"].HeaderText = "Qtde Pedido";
                dgvProdutos.Columns["Qtde"].Width = 60; dgvProdutos.Columns["Qtde"].ReadOnly = true;
                dgvProdutos.Columns["Estoque_Atual"].Width = 40; dgvProdutos.Columns["Estoque_Atual"].ReadOnly = true;
                dgvProdutos.Columns["Necessidade"].Width = 40; dgvProdutos.Columns["Necessidade"].ReadOnly = true;
                dgvProdutos.Columns["Empenhado"].Width = 40; dgvProdutos.Columns["Empenhado"].ReadOnly = true;
                dgvProdutos.Columns["Producao"].Width = 40; dgvProdutos.Columns["Producao"].ReadOnly = true;
                dgvProdutos.Columns["Separado"].Width = 40; dgvProdutos.Columns["Separado"].ReadOnly = true;
                dgvProdutos.Columns["Saldo"].Width = 40; dgvProdutos.Columns["Saldo"].ReadOnly = true;
                dgvProdutos.Columns["Qtde_a_Separar"].Width = 60; dgvProdutos.Columns["Qtde_a_Separar"].ReadOnly = true; dgvProdutos.Columns["Qtde_a_Separar"].HeaderText = "Qtde a Separar"; dgvProdutos.Columns["Qtde_a_Separar"].DefaultCellStyle.BackColor = Color.GreenYellow;
                dgvProdutos.Columns["Data_Entrega"].Width = 90; dgvProdutos.Columns["Data_Entrega"].ReadOnly = true;
                dgvProdutos.Columns["COD_ITEM_VENDA"].Visible = false;
                dgvProdutos.Columns["CNPJ_EMISSOR_PED_VENDA"].Visible = false;
                dgvProdutos.Columns["TIPO_PED_VENDA"].Visible = false;
                dgvProdutos.Columns["CNPJ_PED_VENDA"].Visible = false;

                filtrar();



            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void salvar()
        {
            //baixar_do_estoque();
            try
            {
               
                    this.BindingContext[dsLiberacao, "LIBERACAO"].EndCurrentEdit();
                    if (dsLiberacao.HasChanges())
                    {
                        fbConnection1.Open();
                        datLiberacao.UpdateCommand = cbLiberacao.GetUpdateCommand();
                        datLiberacao.InsertCommand = cbLiberacao.GetInsertCommand();
                        datLiberacao.DeleteCommand = cbLiberacao.GetDeleteCommand();
                        datLiberacao.Update(dsLiberacao, "LIBERACAO");
                        dsLiberacao.AcceptChanges();
                        fbConnection1.Close();
                    }
                    this.BindingContext[dsItens_liberacao, "ITENS_LIBERACAO"].EndCurrentEdit();
                    if (dsItens_liberacao.HasChanges())
                    {
                        //baixar_do_estoque();
                        fbConnection1.Open();
                        datItens_liberacao.UpdateCommand = cbItens_liberacao.GetUpdateCommand();
                        datItens_liberacao.InsertCommand = cbItens_liberacao.GetInsertCommand();
                        datItens_liberacao.DeleteCommand = cbItens_liberacao.GetDeleteCommand();
                        datItens_liberacao.Update(dsItens_liberacao, "ITENS_LIBERACAO");
                        dsItens_liberacao.AcceptChanges();
                        fbConnection1.Close();
                    }
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
                            "SELECT * FROM ROTAS_CAMPO WHERE OP_ROTA = '" + cod_op + "'";
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
                imprimir.imprimir_direto = true;
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
                    finally
                    {

                    }
                   
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
                        "SELECT * FROM produtos WHERE COD_FORNECEDOR_PRODUTO = '" + cod_produto + "'";
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
            
        }

        private void tb_cod_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void tb_descricao_TextChanged(object sender, EventArgs e)
        {
            if (tb_descricao.Text != "")
            {
                descricao_produto = " and Item like '*" + tb_descricao.Text + "*'";

            }
            else
            {
                descricao_produto = "";
            }
            filtrar();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            salvar();
            recalcular_estoques();
            selecionar_itens();
            //selecionar_ops(tb_os.Text);
            MessageBox.Show("Salvo");
        }

        private void recalcular_estoques()
        {
            //for (int i = 0; i < dgvOp.RowCount; i++)
            //{

            //    classeEstoque estoque = new classeEstoque();
            //    estoque.fbConnection1.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
            //    estoque.calcular_estoque(dgvOp.Rows[i].Cells["col_cod_produto"].Value.ToString());
            //}
        }

        private void button7_Click(object sender, EventArgs e)
        {
          
        }

        private void tb_cod_cliente_TextChanged(object sender, EventArgs e)
        {
            if (tb_cod_cliente.Text != "")
            {
                cod_produto = " and Cod_Produto = '" + tb_cod_cliente.Text + "'";

            }
            else
                cod_produto = "";
            filtrar();
        }

        private void tb_pedido_pesquisa_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_pedido_TextChanged(object sender, EventArgs e)
        {

            if (tb_pedido.Text != "")
            {
                cod_interno_pedido = " and Cod_interno = '" + tb_pedido.Text + "'";
            }
            else
                cod_interno_pedido = "";
            filtrar();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void bt_novo_Click(object sender, EventArgs e)
        {
            try
            {
                datLiberacao.InsertCommand.CommandText =
                    @"INSERT INTO LIBERACAO (QTDE_ITENS_LIB, BAIXADO_LIB, DATA_LIB, HORA_LIB, RESPONSAVEL_LIB, CNPJ_EMISSOR_LIB, RAZAO_EMISSOR_LIB) 
                        VALUES(0,0,CURRENT_DATE, CURRENT_TIME, " + cod_usuario + @", '" + cnpj_empresa + "','" + razao_social_empresa + "') RETURNING COD_LIB";
                fbConnection1.Open();
                datLiberacao.InsertCommand.Connection = fbConnection1;
                object cod_lib = datLiberacao.InsertCommand.ExecuteScalar();
                fbConnection1.Close();

                dsItens_liberacao.Clear();
                dsLiberacao.Clear();
                datLiberacao.SelectCommand.CommandText =
                "SELECT * FROM LIBERACAO WHERE COD_LIB = " + cod_lib.ToString() + "";
                fbConnection1.Open();
                datLiberacao.SelectCommand.Connection = fbConnection1;
                datLiberacao.Fill(LIBERACAO);
                fbConnection1.Close();
                
               
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
                fbConnection1.Close();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (tb_cod.Text != "")
                {
                    int posicao = 1;
                    int linhas = 0;
                    for (int i = 0; i < dgvProdutos.RowCount; i++)
                    {

                        if (Convert.ToBoolean(dgvProdutos.Rows[i].Cells["col_selecionado"].Value))
                        {
                            if (linhas == 0)
                            {
                                linhas = 1;
                                try
                                {
                                    /*
            
                       dgvProdutos.Columns["Pedido"].Width = 40; dgvProdutos.Columns["Pedido"].ReadOnly = true;
                       dgvProdutos.Columns["Cod_interno"].Width = 40; dgvProdutos.Columns["Cod_interno"].Visible = false; dgvProdutos.Columns["Cod_interno"].ReadOnly = true;
                       dgvProdutos.Columns["Cliente"].Width = 160; dgvProdutos.Columns["Cliente"].ReadOnly = true;
                       dgvProdutos.Columns["Pedido_Cliente"].Width = 60; dgvProdutos.Columns["Pedido_Cliente"].ReadOnly = true;
                       dgvProdutos.Columns["Item_Ped_Cliente"].Width = 30; dgvProdutos.Columns["Item_Ped_Cliente"].ReadOnly = true;
                       dgvProdutos.Columns["Cod_Produto"].Width = 100; dgvProdutos.Columns["Cod_Produto"].ReadOnly = true;
                       dgvProdutos.Columns["Cod_Sistema_Produto"].Width = 50; dgvProdutos.Columns["Cod_Sistema_Produto"].Visible = false; dgvProdutos.Columns["Cod_Sistema_Produto"].ReadOnly = true;
                       dgvProdutos.Columns["Descricao"].Width = 180; dgvProdutos.Columns["Descricao"].ReadOnly = true;
                       dgvProdutos.Columns["Un"].Width = 30; dgvProdutos.Columns["Un"].ReadOnly = true;
                       dgvProdutos.Columns["Qtde"].Width = 50; dgvProdutos.Columns["Qtde"].ReadOnly = true;
                       dgvProdutos.Columns["Estoque_Atual"].Width = 50; dgvProdutos.Columns["Estoque_Atual"].ReadOnly = true;
                       dgvProdutos.Columns["Necessidade"].Width = 50; dgvProdutos.Columns["Necessidade"].ReadOnly = true;
                       dgvProdutos.Columns["Empenhado"].Width = 50; dgvProdutos.Columns["Empenhado"].ReadOnly = true;
                       dgvProdutos.Columns["Producao"].Width = 50; dgvProdutos.Columns["Producao"].ReadOnly = true;
                       dgvProdutos.Columns["Separado"].Width = 50; dgvProdutos.Columns["Separado"].ReadOnly = true;
                       dgvProdutos.Columns["Saldo"].Width = 50; dgvProdutos.Columns["Saldo"].ReadOnly = true;
                       dgvProdutos.Columns["Qtde_a_Separar"].Width = 50;
                       dgvProdutos.Columns["Data_Entrega"].Width = 90; dgvProdutos.Columns["Data_Entrega"].ReadOnly */

                                    double saldo = 0, nova_separacao = 0, diferenca = 0, estoque_fisico = 0, separado = 0, disponivel_para_separar = 0;
                                    bool ok = false, _30 = false;

                                    try
                                    {
                                        saldo = Convert.ToDouble(dgvProdutos.Rows[i].Cells["Qtde"].Value.ToString());
                                        nova_separacao = Convert.ToDouble(dgvProdutos.Rows[i].Cells["Qtde_a_Separar"].Value.ToString());
                                        estoque_fisico = Convert.ToDouble(dgvProdutos.Rows[i].Cells["Estoque_Atual"].Value.ToString());
                                        separado = Convert.ToDouble(dgvProdutos.Rows[i].Cells["Separado"].Value.ToString());
                                        disponivel_para_separar = estoque_fisico - separado;

                                        diferenca = saldo - nova_separacao;

                                        //if (disponivel_para_separar >= nova_separacao)
                                        //{
                                        //    ok = true;
                                        //}
                                        //else
                                        //{
                                        //    MessageBox.Show("Não existe quantidade suficiente para incluir essa separação");
                                        //}
                                        ok = true; //pedido pra liberar sem estoque feito em 08/08/2022


                                    }
                                    catch
                                    {
                                        ok = true; //pedido pra liberar sem estoque feito em 08/08/2022
                                    }

                                    if (ok)
                                    {


                                        FbCommand insert = new FbCommand();
                                        insert.CommandText =
                                            "INSERT INTO ITENS_LIBERACAO (COD_LIB_ITEM_LIB, COD_PRODUTO_ITEM_LIB, COD_PEDIDO_ITEM_LIB, COD_ITEM_PEDIDO_ITEM_LIB, QTDE_ITEM_LIB, " +
                                            "DESCRICAO_ITEM_LIB) " +
                                            "VALUES('" + tb_cod.Text + "','" + dgvProdutos.Rows[i].Cells["Cod_Sistema_Produto"].Value.ToString() + "','" + dgvProdutos.Rows[i].Cells["Cod_interno"].Value.ToString() + "','" +
                                            dgvProdutos.Rows[i].Cells["COD_ITEM_VENDA"].Value.ToString() + "','" + dgvProdutos.Rows[i].Cells["Qtde_a_Separar"].Value.ToString()
                                           + "','" + dgvProdutos.Rows[i].Cells["Item"].Value.ToString() + "') returning COD_ITEM_LIB";
                                        insert.Connection = fbConnection1;
                                        fbConnection1.Open();
                                        FbDataAdapter datInsert = new FbDataAdapter();
                                        datInsert.InsertCommand = insert;
                                        object _cod_item_liberacao = datInsert.InsertCommand.ExecuteScalar();
                                        fbConnection1.Close();


                                        FbCommand update = new FbCommand();
                                        update.Connection = fbConnection1;
                                        update.CommandText = "UPDATE ITENS_PEDIDO_VENDA SET ITEM_LIBERACAO_ITEM_VENDA = '" + _cod_item_liberacao.ToString() +
                                            "' WHERE COD_ITEM_VENDA = " + dgvProdutos.Rows[i].Cells["COD_ITEM_VENDA"].Value.ToString();
                                        fbConnection1.Open();
                                        FbDataAdapter datUpdate = new FbDataAdapter();
                                        datUpdate.UpdateCommand = update;
                                        datUpdate.UpdateCommand.ExecuteNonQuery();
                                        fbConnection1.Close();

                                        classeEstoque estoque = new classeEstoque();
                                        estoque.fbConnection1.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
                                        estoque.calcular_estoque(dgvProdutos.Rows[i].Cells["Cod_Produto"].Value.ToString());

                                    }
                                    else
                                    {
                                        MessageBox.Show("Não é possível criar uma liberação menor do que o Saldo");
                                    }
                                }
                                catch (Exception ex)
                                {
                                    fbConnection1.Close();
                                }

                            }
                            else
                            {
                                MessageBox.Show("Por favor inclua apenas 1 item por vez para evitar erro no estoque");
                            }
                        }
                    }
                    selecionar_itens();
                    selecionar_itens_liberacao(tb_cod.Text);


                }
                else
                {
                    MessageBox.Show("Para inserir um item, é necessário ter uma liberação aberta");
                }
            }
            catch (Exception ex)
            {
                fbConnection1.Close();
                MessageBox.Show(ex.Message);

            }
        }

        private void selecionar_itens_liberacao(string cod_liberacao)
        {
            try
            {
                if (cod_liberacao != "")
                {
                    dsItens_liberacao.Clear();
                    FbCommand select = new FbCommand();
                    select.Connection = fbConnection1;
                    fbConnection1.Open();
                    select.CommandText =
                            @"SELECT il.*, ipv.COD_PROD_ITEM_VENDA as COD_FORN, pv.N_PED_VENDA as N_PEDIDO, 
                    ipv.PEDIDO_CLIENTE_ITEM_VENDA as PEDIDO_CLIENTE, ipv.ITEM_PED_CLIENTE_ITEM_VENDA as ITEM_PEDIDO_CLIENTE, 
                    ipv.VALOR_UNIT_PROD_ITEM_VENDA AS VALOR_UNIT_ITEM_VENDA,  ipv.VALOR_TOTAL_PROD_ITEM_VENDA AS VALOR_TOTAL_ITEM_VENDA, prod.LOCALIZACAO_PRODUTO as LOCALIZACAO 
                    FROM ITENS_LIBERACAO il 
                    inner join ITENS_PEDIDO_VENDA ipv on il.COD_ITEM_LIB = ipv.ITEM_LIBERACAO_ITEM_VENDA 
                    inner join PRODUTOS prod on ipv.COD_SISTEMA_PROD_ITEM_VENDA = prod.COD_PRODUTO 
                    inner join PEDIDOS_VENDA pv on ipv.COD_PEDIDO_ITEM_VENDA = pv.cod_ped_venda 
                 WHERE il.COD_LIB_ITEM_LIB = '" + cod_liberacao + "' order by il.COD_ITEM_LIB desc";
                    FbDataAdapter datSelect = new FbDataAdapter();
                    datSelect.SelectCommand = select;
                    DataTable dtSelect = new DataTable();
                    datItens_liberacao.SelectCommand = select;
                    datItens_liberacao.Fill(ITENS_LIBERACAO);
                    fbConnection1.Close();
                }
            }
            catch (Exception ex)
            {
                fbConnection1.Close();
                MessageBox.Show(ex.Message);
            }
        
        }

        private void tb_cnpj_empresa_TextChanged(object sender, EventArgs e)
        {
            cnpj_emissor = " AND CNPJ_EMISSOR_PED_VENDA = '" + tb_cnpj_empresa.Text + "'";
            filtrar();
        }

        private void filtrar()
        {
            try
            {
                dtItens_pedido.DefaultView.RowFilter = "0 = 0 " + cnpj_cliente + cnpj_emissor + tipo + cod_produto + descricao_produto + cod_interno_pedido;
            }
            catch
            {
                try
                {
                    dtItens_pedido.DefaultView.RowFilter = "0=0";
                }
                catch { }
            }
        }

        private void tb_cnpj_cliente_TextChanged(object sender, EventArgs e)
        {
            cnpj_cliente = " AND CNPJ_PED_VENDA = '" + tb_cnpj_cliente.Text + "'";
            filtrar();
        }

        private void cbTipo_SelectedValueChanged(object sender, EventArgs e)
        {
            tipo = " AND TIPO_PED_VENDA = '" + cbTipo.Text + "'";
            filtrar();
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            salvar();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvItens.SelectedRows.Count; i++)
            {
                excluir_item(dgvItens.SelectedRows[i].Cells["COL_COD_ITEM_LIB"].Value.ToString(), dgvItens.SelectedRows[i].Cells["COL_COD_ITEM_PEDIDO_ITEM_LIB"].Value.ToString(),
                    dgvItens.SelectedRows[i].Cells["COD_FORN"].Value.ToString());
            }
            selecionar_itens();
            selecionar_itens_liberacao(tb_cod.Text);
        }

        private void excluir_item(string cod_item_lib, string cod_item_pedido, string cod_forn)
        {
            try
            {
                fbConnection1.Open();
                
                FbCommand delete = new FbCommand();
                delete.Connection = fbConnection1;
                delete.CommandText = "DELETE FROM ITENS_LIBERACAO WHERE COD_ITEM_LIB = '" + cod_item_lib + "'";
                FbDataAdapter datDelete = new FbDataAdapter();
                datDelete.DeleteCommand = delete;
                datDelete.DeleteCommand.ExecuteNonQuery();

                FbCommand update = new FbCommand();
                update.Connection = fbConnection1;
                update.CommandText = "UPDATE ITENS_PEDIDO_VENDA SET ITEM_LIBERACAO_ITEM_VENDA = NULL WHERE COD_ITEM_VENDA = '" + cod_item_pedido + "'";
                FbDataAdapter datUpdate = new FbDataAdapter();
                datUpdate.UpdateCommand = update;
                datUpdate.UpdateCommand.ExecuteNonQuery();
                
                fbConnection1.Close();

                classeEstoque estoque1 = new classeEstoque();
                estoque1.fbConnection1.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
                estoque1.calcular_estoque(cod_forn);




            }
            catch (Exception ex)
            {
                fbConnection1.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void bt_excluir_Click(object sender, EventArgs e)
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
                         for (int i = 0; i < dgvProdutos.SelectedRows.Count; i++)
                         {
                             excluir_item(dgvProdutos.Rows[i].Cells["COD_ITEM_LIB"].Value.ToString(), dgvProdutos.Rows[i].Cells["COD_ITEM_PEDIDO_ITEM_LIB"].Value.ToString(),
                                 dgvProdutos.Rows[i].Cells["COD_FORN"].Value.ToString());
                         }
                         fbConnection1.Open();

                         FbCommand delete = new FbCommand();
                         delete.Connection = fbConnection1;
                         delete.CommandText = "DELETE FROM LIBERACAO WHERE COD_LIB = '" + tb_cod.Text + "'";
                         FbDataAdapter datDelete = new FbDataAdapter();
                         datDelete.DeleteCommand = delete;
                         datDelete.DeleteCommand.ExecuteNonQuery();

                         fbConnection1.Close();
                         selecionar_itens();
                         dsLiberacao.Clear();
                         selecionar_itens_liberacao(tb_cod.Text);
                     }
                     else
                     {
                         MessageBox.Show("Usuário não autorizado");
                     }
                 }
             }
        }

        private void bt_localizar_Click(object sender, EventArgs e)
        {
            form_localiza_liberacao lib = new form_localiza_liberacao(cnpj_empresa);
            try
            {
                
                lib.ShowDialog();
            }
            finally
            {
                selecionar_liberacao(lib.cod_selecionado);
            }
        }

        private void selecionar_liberacao(string cod_lib)
        {
            try
            {
                if (cod_lib != "")
                {
                    dsLiberacao.Clear();
                    datLiberacao.SelectCommand.CommandText =
                    "SELECT * FROM LIBERACAO WHERE COD_LIB = " + cod_lib.ToString() + "";
                    fbConnection1.Open();
                    datLiberacao.SelectCommand.Connection = fbConnection1;
                    datLiberacao.Fill(LIBERACAO);
                    fbConnection1.Close();

                    selecionar_itens_liberacao(tb_cod.Text);
                }

            }
            catch (Exception ex)
            {
                fbConnection1.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            form_localiza_cliente localiza_cliente = new form_localiza_cliente(true, cnpj_empresa);
            try
            {
                localiza_cliente.nf = true;
                localiza_cliente.ShowDialog();
            }
            finally
            {
                localiza_cliente.Dispose();
                tb_cnpj_cliente.Text = localiza_cliente.cnpj_escolhido;
                tb_cliente.Text = localiza_cliente.cliente_escolhido;
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            cbLiberado.Checked = true;
            salvar();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (cbLiberado.Checked)
            {
                salvar();
                dsSeparacao sep = new dsSeparacao();
                try
                {


                    datLiberacao.Fill(sep.LIBERACAO);
                    datItens_liberacao.Fill(sep.ITENS_LIBERACAO);
                    sep.INFORMACOES.AddINFORMACOESRow("NF");

                    crSeparacao cr = new crSeparacao();
                    cr.SetDataSource(sep);
                    form_imprimir imp = new form_imprimir(cr);
                    imp.Show();
                }
                catch { }
            }
            else
                MessageBox.Show("É necessário liberar o faturamento antes de imprimir");
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            dsSeparacao sep = new dsSeparacao();
            try
            {
                salvar();

                datLiberacao.Fill(sep.LIBERACAO);
                datItens_liberacao.Fill(sep.ITENS_LIBERACAO);
                sep.INFORMACOES.AddINFORMACOESRow("SEPARACAO");

                crSeparacao cr = new crSeparacao();
                cr.SetDataSource(sep);
                form_imprimir imp = new form_imprimir(cr);
                imp.Show();
            }
            catch { }
        }
    }
}
