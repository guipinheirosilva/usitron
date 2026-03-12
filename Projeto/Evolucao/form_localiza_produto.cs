using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    
    public partial class form_localiza_produto : Form
    {
        string descricao, familia, grupo, subgrupo, fornecedor;
        DataTable dtNcm_cst = new DataTable();

        string razao_social_empresa = "", nome_fantasia_empresa = "", ie_empresa = "", im_empresa = "", cnae_empresa = "", endereco_empresa = "", n_endereco_empresa = "",
          complemento_empresa = "", bairro_empresa = "", cidade_empresa = "", estado_empresa = "", cep_empresa = "", telefone_empresa = "", cod_cidade_empresa = "", pais_empresa = "",
          cod_pais_empresa = "", licenca_dll_nfe_empresa = "", nome_certificado_nfe_empresa = "", assunto_nfe_email_empresa = "", smtp_nfe_empresa = "", email_nfe_empresa = "",
          senha_email_nfe_empresa = "", logotipo_empresa = "", proxy_empresa = "", usuario_proxy_empresa = "", senha_proxy_empresa = "", crt_empresa = "", portaEmailEmpresa = "",
          sslEmpresa = "", serie_empresa = "", boleto_pedido_empresa = "", cliente_inadimplente_empresa = "", _cod_transmissao = "";


        public string cod_produto_escolhido, descricao_produto_escolhido, item_produto_escolhido, unidade_produto_escolhido,
            marca_escolhido, grupo_escolhido, origem_produto, ncm_produto, preco_unit_produto,
            descricao_completa_produto_escolhido, cod_forn, ean_escolhido;
        public bool buscar;
        private bool iniciadoPeloPedido;

        public string[] produtos_selecionados = new string[1000];

        private void tb_fornecedor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tb_fornecedor.Text != "")
                    fornecedor = " AND NOME_FORNECEDOR_PRODUTO LIKE '*" + tb_fornecedor.Text + "*'";
                else
                    fornecedor = "";
                filtrar();

            }
            catch
            {

            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            double porcentagem = 0;
            try
            {

                porcentagem = 1 + (Convert.ToDouble(tb_porcentagem.Text)/100);

                if (DialogResult.Yes == MessageBox.Show("Essa operação irá atualizar os preços nos produtos, tem certeza?",
                  "Confirma?", MessageBoxButtons.YesNo))
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
                            if (usuario._cod_usuario == "1" || usuario._cod_usuario == "2" || usuario._cod_usuario == "4")
                            {
                                

                                        for (int i = 0; i < dgvProdutos.SelectedRows.Count; i++)
                                        {
                                            try
                                            {


                                                FbCommand update = new FbCommand();
                                                update.CommandText =
                                                    "UPDATE PRODUTOS SET VALOR_VENDA_REVEND_PRODUTO = VALOR_VENDA_REVEND_PRODUTO * " + 
                                                    porcentagem.ToString().Replace(".","").Replace(",",".") + ", " +
                                                    "VALOR_PROMOCAO_PRODUTO = VALOR_PROMOCAO_PRODUTO * " +
                                                    porcentagem.ToString().Replace(".", "").Replace(",", ".") + " WHERE COD_PRODUTO = '" +
                                                    dgvProdutos.SelectedRows[i].Cells["col_cod"].Value.ToString() + "'";
                                                update.Connection = fbConnection1;
                                                fbConnection1.Open();
                                                FbDataAdapter datUpdate = new FbDataAdapter();
                                                datUpdate.UpdateCommand = update;
                                                datUpdate.UpdateCommand.ExecuteNonQuery();
                                                fbConnection1.Close();
                                            }
                                            catch (Exception a)
                                            {
                                                fbConnection1.Close();
                                                MessageBox.Show(a.ToString());
                                            }

                                        }

                                selecionar_itens();
                                   
                                
                            }
                            else
                            {
                                MessageBox.Show("Usuário não autorizado");
                            }
                            MessageBox.Show("Inserção Realizada!");
                        }



                    }
                }
            }
            catch
            {
                MessageBox.Show("Digite o valor do aumento no campo %");

            }
        }

        public int qtde_produtos_selecionados;

        private void tb_subgrupo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tb_subgrupo.Text != "")
                    subgrupo = " AND DESCRICAO_SUB_GRUPO_PRODUTO LIKE '*" + tb_subgrupo.Text + "*'";
                else
                    subgrupo = "";
                filtrar();

            }
            catch
            {

            }
        }

        public string cnpj_empresa;
        public form_localiza_produto(bool iniciadoPeloPedido, string cnpj_empresa)
        {
            this.cnpj_empresa = cnpj_empresa;
            this.iniciadoPeloPedido = iniciadoPeloPedido;
            InitializeComponent();
        }

        private void buscar_ncm_cst()
        {
            if (razao_social_empresa.Contains("COMPANY"))
            {
                try
                {
                    //OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:\\evolucao\\excel\\ncm_cst.xlsx';Extended Properties=\"Excel 12.0 Xml;HDR=Yes;IMEX=1;\"");
                    //OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:\\evolucao\\excel\\ncm_cst_antigo.xls';Extended Properties=\"Excel 12.0 Xml;HDR=Yes;IMEX=1;\"");
                    OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:\\evolucao\\excel\\ncm_cst_company.xls';Extended Properties=\"Excel 12.0 Xml;HDR=Yes;IMEX=1;\"");
                    theConnection.Open();
                    OleDbDataAdapter theDataAdapter = new OleDbDataAdapter("SELECT * FROM [ncm$]", theConnection);
                    DataSet theDS = new DataSet();
                    theDataAdapter.Fill(dtNcm_cst);
                    theConnection.Close();
                }
                catch
                {
                    MessageBox.Show("Erro ao ler arquivo NCM_CST_COMPANY");

                }
            }
            else if (razao_social_empresa.Contains("MECANICA"))
            {
                try
                {
                    //OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:\\evolucao\\excel\\ncm_cst.xlsx';Extended Properties=\"Excel 12.0 Xml;HDR=Yes;IMEX=1;\"");
                    //OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:\\evolucao\\excel\\ncm_cst_antigo.xls';Extended Properties=\"Excel 12.0 Xml;HDR=Yes;IMEX=1;\"");
                    OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:\\evolucao\\excel\\ncm_cst_mecanica.xls';Extended Properties=\"Excel 12.0 Xml;HDR=Yes;IMEX=1;\"");
                    theConnection.Open();
                    OleDbDataAdapter theDataAdapter = new OleDbDataAdapter("SELECT * FROM [ncm$]", theConnection);
                    DataSet theDS = new DataSet();
                    theDataAdapter.Fill(dtNcm_cst);
                    theConnection.Close();
                }
                catch
                {
                    MessageBox.Show("Erro ao ler arquivo NCM_CST_MECANICA");

                }
            }
            else if (cnpj_empresa.Contains("47755820000157")) //claratec
            {
                try
                {
                    //OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:\\evolucao\\excel\\ncm_cst.xlsx';Extended Properties=\"Excel 12.0 Xml;HDR=Yes;IMEX=1;\"");
                    //OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:\\evolucao\\excel\\ncm_cst_antigo.xls';Extended Properties=\"Excel 12.0 Xml;HDR=Yes;IMEX=1;\"");
                    OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:\\evolucao\\excel\\ncm_cst_claratec.xls';Extended Properties=\"Excel 12.0 Xml;HDR=Yes;IMEX=1;\"");
                    theConnection.Open();
                    OleDbDataAdapter theDataAdapter = new OleDbDataAdapter("SELECT * FROM [ncm$]", theConnection);
                    DataSet theDS = new DataSet();
                    theDataAdapter.Fill(dtNcm_cst);
                    theConnection.Close();
                }
                catch
                {
                    MessageBox.Show("Erro ao ler arquivo NCM_CST_MECANICA");

                }
            }
            else
            {
                try
                {
                    //OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:\\evolucao\\excel\\ncm_cst.xlsx';Extended Properties=\"Excel 12.0 Xml;HDR=Yes;IMEX=1;\"");
                    //OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:\\evolucao\\excel\\ncm_cst_antigo.xls';Extended Properties=\"Excel 12.0 Xml;HDR=Yes;IMEX=1;\"");
                    OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:\\evolucao\\excel\\ncm_cst.xls';Extended Properties=\"Excel 12.0 Xml;HDR=Yes;IMEX=1;\"");
                    theConnection.Open();
                    OleDbDataAdapter theDataAdapter = new OleDbDataAdapter("SELECT * FROM [ncm$]", theConnection);
                    DataSet theDS = new DataSet();
                    theDataAdapter.Fill(dtNcm_cst);
                    theConnection.Close();

                    foreach (DataRow row in dtNcm_cst.Rows)
                    {
                        // Verifique se a coluna CFOP não é nula antes de converter para string
                        if (!row.IsNull("CFOP"))
                        {
                            // Converta o valor da coluna CFOP para string
                            row["CFOP"] = row["CFOP"].ToString();
                        }
                        else
                        {
                            // Se a coluna CFOP for nula, você pode atribuir uma string vazia ou outro valor padrão, se necessário
                            row["CFOP"] = string.Empty; // Ou qualquer outro valor padrão desejado
                        }
                    }
                }
                catch
                {
                    // MessageBox.Show("Erro ao ler arquivo NCM_CST");

                }
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tb_cod.Text != "")
                {
                    dsProdutos.Tables["PRODUTOS"].DefaultView.RowFilter = "cod_fornecedor_produto like '" + tb_cod.Text + "*'";
                    if (dgvProdutos.RowCount < 200)
                    {
                        formatarDgv();
                    }
                }
                else
                {
                    dsProdutos.Tables["PRODUTOS"].DefaultView.RowFilter = "cod_produto IS NOT NULL";
                    if (dgvProdutos.RowCount < 200)
                    {
                        formatarDgv();
                    }
                }
            }
            catch
            {
                dsProdutos.Tables["PRODUTOS"].DefaultView.RowFilter = "cod_produto IS NOT NULL";
                if (dgvProdutos.RowCount < 200)
                {
                    formatarDgv();
                }
            }
        }

        private void filtrar()
        {
            try
            {
                dsProdutos.Tables["PRODUTOS"].DefaultView.RowFilter = " 0 = 0 " + grupo + familia + 
                    subgrupo + fornecedor + descricao; 
            }
            catch { dsProdutos.Tables["PRODUTOS"].DefaultView.RowFilter = " 0 = 0 "; }
        }
        private void tb_grupo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tb_grupo.Text != "")
                    grupo = " AND DESCRICAO_GRUPO_PRODUTO LIKE '*" + tb_grupo.Text + "*'";
                else
                    grupo = "";
                filtrar();
                
            }
            catch
            {
                
            }
        }



        private void tb_descricao_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tb_descricao.Text != "")
                    descricao = " AND DESCRICAO_PRODUTO LIKE '*" + tb_descricao.Text + "*'";
                else
                    descricao = "";
                filtrar();

            }
            catch
            {

            }
            //try
            //{
            //    dsProdutos.Tables["PRODUTOS"].DefaultView.RowFilter = "DESCRICAO_PRODUTO LIKE '*" + tb_descricao.Text + "*'";
            //    if (dgvProdutos.RowCount < 200)
            //    {
            //        formatarDgv();
            //    }
            //}
            //catch
            //{
            //    dsProdutos.Tables["PRODUTOS"].DefaultView.RowFilter = "cod_produto IS NOT NULL";
            //    if (dgvProdutos.RowCount < 200)
            //    {
            //        formatarDgv();
            //    }
            //}
        }

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
                    //if (tb_cnpj_empresa.Text == "")
                    //{
                    //    tb_cnpj_empresa.Text = cnpj_empresa;
                    //    tb_descricao_empresa.Text = razao_social_empresa;
                    //}
                }

            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void form_localiza_produto_Load(object sender, EventArgs e)
        {
            detectar_dados_empresa(out razao_social_empresa, out nome_fantasia_empresa, out cnpj_empresa, out ie_empresa, out im_empresa, out cnae_empresa, out endereco_empresa, out n_endereco_empresa,
      out complemento_empresa, out bairro_empresa, out cidade_empresa, out estado_empresa, out cep_empresa, out telefone_empresa, out cod_cidade_empresa, out pais_empresa,
      out cod_pais_empresa, out licenca_dll_nfe_empresa, out nome_certificado_nfe_empresa, out assunto_nfe_email_empresa, out smtp_nfe_empresa, out email_nfe_empresa,
      out senha_email_nfe_empresa, out logotipo_empresa, out proxy_empresa, out usuario_proxy_empresa, out senha_proxy_empresa, out crt_empresa, out portaEmailEmpresa, out sslEmpresa, out serie_empresa,
      out boleto_pedido_empresa, out cliente_inadimplente_empresa);
            buscar_ncm_cst();

            selecionar_itens();
        }

        private void selecionar_itens()
        {
            dsProdutos.Clear();
            string status = " and status_produto = 1";
            if (cbxStatus.Checked)
                status = "";
            if (!iniciadoPeloPedido)
            {
                try
                {
                   
                    datProdutos.SelectCommand.CommandText =
                        "SELECT * FROM produtos WHERE 0=0  " + status + " ORDER BY cod_fornecedor_produto";
                    datProdutos.SelectCommand.Connection = fbConnection1;
                    fbConnection1.Open();
                    datProdutos.SelectCommand.ExecuteNonQuery();
                    datProdutos.Fill(PRODUTOS);
                    fbConnection1.Close();
                    //datProdutos.Fill(PRODUTOS);

                }
                catch (Exception a)
                {
                    fbConnection1.Close();
                    MessageBox.Show("Não foi possível selecionar os produtos!\nErro: " + a.Message);
                }
            }
            else
            {
                try
                {
                    datProdutos.SelectCommand.CommandText =
                        "SELECT * FROM produtos p WHERE 0 = 0 " + status + " ORDER BY cod_fornecedor_produto";
                    datProdutos.SelectCommand.Connection = fbConnection1;
                    fbConnection1.Open();
                    datProdutos.SelectCommand.ExecuteNonQuery();
                    datProdutos.Fill(PRODUTOS);
                    fbConnection1.Close();
                }
                catch (Exception a)
                {
                    fbConnection1.Close();
                    MessageBox.Show("Não foi possível selecionar os produtos!\nErro: " + a.Message);
                }
            }

            dgvProdutos.AutoGenerateColumns = false;
            dgvProdutos.DataSource = dsProdutos.Tables["PRODUTOS"];
            
            if (dgvProdutos.RowCount < 200)
            {
                formatarDgv();
            }
            
            //calcular_valor_estoque();
        }

        private void formatarDgv()
        {
            /*
            for (int i = 0; i < dgvProdutos.Rows.Count; i++)
            {
                double estoqueAtual = 0, estoqueMinimo = 0;
                try { estoqueAtual = Convert.ToDouble(dgvProdutos.Rows[i].Cells["col_estoque_atual"].Value.ToString()); }
                catch { estoqueAtual = 0; }
                try { estoqueMinimo = Convert.ToDouble(dgvProdutos.Rows[i].Cells["colEstoqueMinimo"].Value.ToString()); }
                catch { estoqueMinimo = 0; }
                if (estoqueAtual <= 0)
                {
                    dgvProdutos.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
                else if (estoqueAtual <= estoqueMinimo)
                {
                    dgvProdutos.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                }
            }
             * */
        }

        private void calcular_valor_estoque_novo()
        {

            double valor = 0;
            double valor_custo = 0;
            for (int i = 0; i < dgvProdutos.RowCount; i++)
            {
                try
                {
                    double valor_parcial = (Convert.ToDouble(dgvProdutos.Rows[i].Cells["col_estoque_atual"].Value.ToString()) *
                                Convert.ToDouble(dgvProdutos.Rows[i].Cells["col_valor_venda"].Value.ToString()));


                    if (valor_parcial < 0)
                        valor_parcial = 0;
                    valor = valor + valor_parcial;
                }
                catch { }
                try
                {
                    double valor_parcial_custo = (Convert.ToDouble(dgvProdutos.Rows[i].Cells["col_estoque_atual"].Value.ToString()) *
                                Convert.ToDouble(dgvProdutos.Rows[i].Cells["col_custo"].Value.ToString()));
                    if (valor_parcial_custo < 0)
                        valor_parcial_custo = 0;
                    valor_custo = valor_custo + valor_parcial_custo;

                }
                catch
                {
                    // MessageBox.Show(dgvProdutos.Rows[i].Cells["col_estoque_medio"].Value.ToString() + " " + dgvProdutos.Rows[i].Cells["col_valor_venda"].Value.ToString());
                }
            }
            tb_valor_estoque.Text = valor.ToString("n2");
            tb_valor_compra.Text = valor_custo.ToString("n2");

        }
        private void dgvProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (buscar == true)
            {
                if (!iniciadoPeloPedido)
                {
                    cod_produto_escolhido = dgvProdutos.Rows[e.RowIndex].Cells["col_cod"].Value.ToString();
                    descricao_produto_escolhido = dgvProdutos.Rows[e.RowIndex].Cells["col_nome"].Value.ToString();
                    item_produto_escolhido = dgvProdutos.Rows[e.RowIndex].Cells["col_item"].Value.ToString();
                    descricao_completa_produto_escolhido = descricao_produto_escolhido + " - " + item_produto_escolhido;
                    unidade_produto_escolhido = dgvProdutos.Rows[e.RowIndex].Cells["col_uni"].Value.ToString();
                    grupo_escolhido = dgvProdutos.Rows[e.RowIndex].Cells["col_grupo"].Value.ToString();
                    preco_unit_produto = dgvProdutos.Rows[e.RowIndex].Cells["col_valor_venda"].Value.ToString();
                    cod_forn = dgvProdutos.Rows[e.RowIndex].Cells["col_cod_forn"].Value.ToString();
                    ean_escolhido = dgvProdutos.Rows[e.RowIndex].Cells["col_cod_ean"].Value.ToString();
                    this.Close();
                }
                else
                {
                    //if (Convert.ToDouble(dgvProdutos.Rows[e.RowIndex].Cells["col_estoque_atual"].Value.ToString()) < 0)
                    //   {
                    ////       MessageBox.Show("Este produto não está disponível no estoque!");
                    //   }
                    //   else
                    //   {
                    try
                    {
                        cod_produto_escolhido = dgvProdutos.Rows[e.RowIndex].Cells["col_cod"].Value.ToString();
                        descricao_produto_escolhido = dgvProdutos.Rows[e.RowIndex].Cells["col_nome"].Value.ToString();
                        item_produto_escolhido = dgvProdutos.Rows[e.RowIndex].Cells["col_item"].Value.ToString();
                        descricao_completa_produto_escolhido = descricao_produto_escolhido + " - " + item_produto_escolhido;
                        unidade_produto_escolhido = dgvProdutos.Rows[e.RowIndex].Cells["col_uni"].Value.ToString();
                        grupo_escolhido = dgvProdutos.Rows[e.RowIndex].Cells["col_grupo"].Value.ToString();
                        preco_unit_produto = dgvProdutos.Rows[e.RowIndex].Cells["col_valor_venda"].Value.ToString();
                        cod_forn = dgvProdutos.Rows[e.RowIndex].Cells["col_cod_forn"].Value.ToString();
                        ean_escolhido = dgvProdutos.Rows[e.RowIndex].Cells["col_cod_ean"].Value.ToString();
                        this.Close();
                    }
                    catch { }
                    //  }
                }
            }
            else
            {
                form_produto prod = new form_produto(cnpj_empresa);
                try
                {
                    bool erro = false;
                    prod.modificar = true;
                   
                        prod.cod_prod = dgvProdutos.Rows[e.RowIndex].Cells["col_cod"].Value.ToString();

                  
                        prod.ShowDialog();
                }
                finally
                {
                    dsProdutos.Clear();
                    datProdutos.Fill(PRODUTOS);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            form_produto prod = new form_produto(cnpj_empresa);
            try
            {
                bool erro = false;
                prod.modificar = true;
                try
                {
                    prod.cod_prod = dgvProdutos.SelectedRows[0].Cells["col_cod"].Value.ToString();

                }
                catch
                {
                    MessageBox.Show("Selecione a linha inteira do produto a modificar");
                    erro = true;
                }
                if (erro == false)
                    prod.ShowDialog();
            }
            finally
            {
                dsProdutos.Clear();
                datProdutos.Fill(PRODUTOS);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form_produto prod = new form_produto(cnpj_empresa);
            try
            {
                prod.novo = true;
                prod.ShowDialog();

            }
            finally
            {
                dsProdutos.Clear();
                datProdutos.Fill(PRODUTOS);
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            calcular_valor_estoque_novo();
        }

       

        private void txtCodBarras_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtCodBarras.Text != "")
                {
                    dsProdutos.Tables["PRODUTOS"].DefaultView.RowFilter = "cod_barras_produto = '" + txtCodBarras.Text + "'";
                    if (dgvProdutos.RowCount < 200)
                    {
                        formatarDgv();
                    }
                }
                else
                {
                    dsProdutos.Tables["PRODUTOS"].DefaultView.RowFilter = "cod_produto IS NOT NULL";
                    if (dgvProdutos.RowCount < 200)
                    {
                        formatarDgv();
                    }
                }
            }
            catch
            {
                dsProdutos.Tables["PRODUTOS"].DefaultView.RowFilter = "cod_produto IS NOT NULL";
                if (dgvProdutos.RowCount < 200)
                {
                    formatarDgv();
                }
            }
        }

      


        private void cbxStatus_Click(object sender, EventArgs e)
        {
            if (cbxStatus.Checked)
            {
                selecionar_itens();
            }
            else
            {
                dsProdutos.Tables["PRODUTOS"].DefaultView.RowFilter = "COD_PRODUTO IS NOT NULL";
                if (dgvProdutos.RowCount < 200)
                {
                    formatarDgv();
                }
            }
        }

        private void tb_familia_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tb_familia.Text != "")
                    familia = " AND NOME_FAMILIA_PRODUTO LIKE '*" + tb_familia.Text + "*'";
                else
                    familia = "";
                filtrar();

            }
            catch
            {

            }
            //try
            //{
            //    if (tb_familia.Text != "")
            //    {
            //        dsProdutos.Tables["PRODUTOS"].DefaultView.RowFilter = "NOME_FAMILIA_PRODUTO LIKE '*" + tb_familia.Text + "*'";
            //        if (dgvProdutos.RowCount < 200)
            //        {
            //            formatarDgv();
            //        }
            //    }
            //    else
            //    {
            //        dsProdutos.Tables["PRODUTOS"].DefaultView.RowFilter = "cod_produto IS NOT NULL";
            //        if (dgvProdutos.RowCount < 200)
            //        {
            //            formatarDgv();
            //        }
            //    }
            //}
            //catch
            //{
            //    dsProdutos.Tables["PRODUTOS"].DefaultView.RowFilter = "cod_produto IS NOT NULL";
            //    if (dgvProdutos.RowCount < 200)
            //    {
            //        formatarDgv();
            //    }
            //}
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Essa operação irá adicionar ou excluir estoque sem rastreabilidade, tem certeza?",
              "Confirma?", MessageBoxButtons.YesNo))
            {
                form_usuario usuario = new form_usuario();

                try
                {
                    usuario.ShowDialog();
                }
                finally
                {
                    bool ok = false;
                    if (usuario.confirmado == true)
                    {
                        if (usuario._cod_usuario == "1" || usuario._cod_usuario == "10")
                        {
                            inserir_retirar_estoque();
                            ok = true;
                        }
                        else
                        {
                            MessageBox.Show("Usuário não autorizado");
                        }

                    }
                    if(ok)
                        MessageBox.Show("Acerto Realizado!");
                    selecionar_itens();

                }


            }
        }

        private void inserir_retirar_estoque()
        {
            try
            {
                for (int i = 0; i < dgvProdutos.Rows.Count; i++)
                {
                    /*
                     * "SELECT QTDE_ITEM_ENT, QTDE_LOTE_ITEM_ENT, PRECO_TOTAL_ITEM_ENT, NF_ITEM_ENT " +
                            "FROM ITENS_NOTA_ENT JOIN NOTA_FISCAL_ENT ON COD_SISTEMA_NF_ITEM_ENT = COD_SISTEMA_NF_ENT " +
                            "WHERE (COD_EAN_ITEM_ENT = '" + codBarrasCaixa + "' OR COD_EAN_ITEM_ENT = '" + codBarrasUnidade + "') " + 
                            "AND BAIXADO_ITEM_ENT = '1' " +
                            dataEmissaoEnt +
                            "ORDER BY COD_ITENS_NOTA_ENT DESC";
                     * */
                    try
                    {
                        //FINALIZAR INSERCOES DE ESTOQUE MANUAL, RELATORIO DE CLIENTES POR VENDEDOR, CORTE NO PEDIDO

                        double qtde = 0;
                        try
                        {
                            qtde = Convert.ToDouble(dgvProdutos.Rows[i].Cells["col_acerto_estoque"].Value.ToString());
                        }
                        catch { }

                        if (qtde != 0)
                        {
                            string nf = "9999990";
                            
                            string cod_sistema_nf_ent = buscar_cod_nf_ent("9999990");

                            FbCommand insert = new FbCommand();
                            insert.CommandText =
                                "INSERT INTO ITENS_NOTA_ENT (QTDE_ITEM_ENT, NF_ITEM_ENT, COD_ITEM_ENT, BAIXADO_ITEM_ENT, COD_SISTEMA_NF_ITEM_ENT, QTDE_LOTE_ITEM_ENT) " +
                                "VALUES ('" + qtde.ToString().Replace(".", "").Replace(",", ".") + "','" + nf + "','" +
                                dgvProdutos.Rows[i].Cells["col_cod_forn"].Value.ToString() + "','1', '" + cod_sistema_nf_ent + "','" + qtde.ToString().Replace(".", "").Replace(",", ".") + "')";
                            insert.Connection = fbConnection1;
                            fbConnection1.Open();
                            FbDataAdapter datInsert = new FbDataAdapter();
                            datInsert.InsertCommand = insert;
                            datInsert.InsertCommand.ExecuteNonQuery();
                            fbConnection1.Close();
                            try
                            {
                                try
                                {
                                        classeEstoque estoque = new classeEstoque();
                                        estoque.fbConnection1.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
                                        estoque.calcular_estoque(dgvProdutos.Rows[i].Cells["col_cod_forn"].Value.ToString());
                                }
                                catch { }
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

            }
            catch (Exception a)
            {

            }
        }

        private string buscar_cod_nf_ent(string nf)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.CommandText =
               "SELECT * FROM NOTA_FISCAL_ENT WHERE N_NF_ENT = '" + nf + "'";
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

        private void button5_Click(object sender, EventArgs e)
        {
            selecionar_itens();
        }

        private void cbxStatus_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Essa operação irá criar/alterar a comissão do vendedor nos produtos, tem certeza?",
              "Confirma?", MessageBoxButtons.YesNo))
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
                        if (usuario._cod_usuario == "1" || usuario._cod_usuario == "2" || usuario._cod_usuario == "4")
                        {
                            form_vendedor_comissao vend = new form_vendedor_comissao();
                            string cod_vendedor, vendedor;
                            double comissao;
                            try
                            {
                                vend.ShowDialog();
                            }
                            finally
                            {
                                cod_vendedor = vend.cod_vendedor;
                                vendedor = vend.vendedor;
                                comissao = vend.comissao;
                                if (comissao >= 0 && cod_vendedor != "")
                                {
                                    for (int i = 0; i < dgvProdutos.SelectedRows.Count; i++)
                                    {
                                        try
                                        {
                                            FbCommand delete = new FbCommand();
                                            delete.CommandText =
                                                "DELETE FROM COMISSAO_PRODUTO_VENDEDOR WHERE COD_VENDEDOR_CPV = '" + cod_vendedor + "' AND " +
                                                "COD_PRODUTO_CPV = '" + dgvProdutos.SelectedRows[i].Cells["col_cod"].Value.ToString() + "'";
                                            delete.Connection = fbConnection1;
                                            fbConnection1.Open();
                                            FbDataAdapter datDelete = new FbDataAdapter();
                                            datDelete.DeleteCommand = delete;
                                            datDelete.DeleteCommand.ExecuteNonQuery();
                                            fbConnection1.Close();


                                            FbCommand insereVendedor = new FbCommand();
                                            insereVendedor.CommandText =
                                            "INSERT INTO COMISSAO_PRODUTO_VENDEDOR (COD_VENDEDOR_CPV, " +
                                            "COD_PRODUTO_CPV, PORC_COMISSAO_CPV, NOME_VENDEDOR_CPV) " +
                                            " values ('" + cod_vendedor + "','" +
                                            dgvProdutos.SelectedRows[i].Cells["col_cod"].Value.ToString() + "','" +
                                            comissao.ToString().Replace(",", ".") + "','" +
                                            vendedor + "')";
                                            FbDataAdapter datVendedores = new FbDataAdapter();
                                            datVendedores.InsertCommand = insereVendedor;
                                            datVendedores.InsertCommand.Connection = fbConnection1;
                                            fbConnection1.Open();
                                            datVendedores.InsertCommand.ExecuteNonQuery();
                                            fbConnection1.Close();
                                        }
                                        catch (Exception a)
                                        {
                                            fbConnection1.Close();
                                            MessageBox.Show(a.ToString());
                                        }

                                    }

                                }


                            }

                        }
                        else
                        {
                            MessageBox.Show("Usuário não autorizado");
                        }

                    }
                    MessageBox.Show("Inserção Realizada!");


                }


            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Essa operação irá criar/alterar a família nos produtos, tem certeza?",
              "Confirma?", MessageBoxButtons.YesNo))
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
                        if (usuario._cod_usuario == "1" || usuario._cod_usuario == "2" || usuario._cod_usuario == "4")
                        {
                            form_familias_produto vend = new form_familias_produto();
                            string familia;
                            try
                            {
                                vend.ShowDialog();
                            }
                            finally
                            {
                                if (vend.n_selecionados == 1)
                                {
                                    familia = vend.familias[1, 0].ToString();

                                    for (int i = 0; i < dgvProdutos.SelectedRows.Count; i++)
                                    {
                                        try
                                        {
                                            FbCommand update = new FbCommand();
                                            update.CommandText =
                                                "UPDATE PRODUTOS SET NOME_FAMILIA_PRODUTO = '" + familia + "' WHERE COD_PRODUTO = '" +
                                                dgvProdutos.SelectedRows[i].Cells["col_cod"].Value.ToString() + "'";
                                            update.Connection = fbConnection1;
                                            fbConnection1.Open();
                                            FbDataAdapter datUpdate = new FbDataAdapter();
                                            datUpdate.UpdateCommand = update;
                                            datUpdate.UpdateCommand.ExecuteNonQuery();
                                            fbConnection1.Close();
                                        }
                                        catch (Exception a)
                                        {
                                            fbConnection1.Close();
                                            MessageBox.Show(a.ToString());
                                        }

                                    }
                                }


                                else
                                {
                                    MessageBox.Show("Selecione apenas uma família");
                                }
                            }
                        }


                        else
                        {
                            MessageBox.Show("Usuário não autorizado");
                        }
                        MessageBox.Show("Inserção Realizada!");
                    }



                }


            }
        }



        private void button8_Click(object sender, EventArgs e)
        {
            qtde_produtos_selecionados = dgvProdutos.SelectedRows.Count;
            for (int i = 0; i < dgvProdutos.SelectedRows.Count; i++)
            {
                produtos_selecionados[i] = dgvProdutos.SelectedRows[i].Cells["col_cod"].Value.ToString();
            }
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Essa operação irá adicionar ou excluir estoque sem rastreabilidade, tem certeza?",
             "Confirma?", MessageBoxButtons.YesNo))
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
                        if (usuario._cod_usuario == "1")
                        {
                            acertar_planilha();
                            inserir_retirar_estoque();

                        }
                        else
                        {
                            MessageBox.Show("Usuário não autorizado");
                        }


                    }
                    MessageBox.Show("Acerto Realizado!");
                    //selecionar_itens();
                }


            }
        }

        private void acertar_planilha()
        {
            try
            {
                OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:\\evolucao\\excel\\acerto.xls';Extended Properties=\"Excel 8.0;HDR=NO;IMEX=1;\"");
                theConnection.Open();
                OleDbDataAdapter theDataAdapter = new OleDbDataAdapter("SELECT * FROM [Plan1$]", theConnection);
                DataSet theDS = new DataSet();
                theDataAdapter.Fill(theDS);
                theConnection.Close();

                foreach (DataRow dr in theDS.Tables[0].Rows)
                {
                    try
                    {
                        /*
                        string estoque_minimo = dr[3].ToString().Replace(",", ".");
                        if (estoque_minimo == "")
                            estoque_minimo = "0";
                        string estoque_medio = dr[4].ToString().Replace(",", ".");
                        if (estoque_medio == "")
                            estoque_medio = "0";
                        string custo = dr[5].ToString().Replace(",", ".");
                        if (custo == "")
                            custo = "0";

                        FbCommand update = new FbCommand();
                        update.Connection = fbConnection1;
                        update.CommandText =
                            "UPDATE PRODUTOS SET ESTOQUE_MINIMO_PRODUTO = " + estoque_minimo +
                            ", ESTOQUE_MEDIO_PRODUTO = " + estoque_medio + ", CUSTO_PRODUTO = " +
                            custo + " WHERE COD_FORNECEDOR_PRODUTO = '" + dr[0].ToString() + "'";
                        fbConnection1.Open();
                        FbDataAdapter datUpdate = new FbDataAdapter();
                        datUpdate.InsertCommand = update;
                        datUpdate.InsertCommand.ExecuteNonQuery();
                        fbConnection1.Close();
                        */
                        for (int i = 0; i < dgvProdutos.Rows.Count; i++)
                        {
                            if (dgvProdutos.Rows[i].Cells["col_cod_forn"].Value.ToString() == dr[0].ToString())
                            {
                                double valor_real = Convert.ToDouble(dr[2].ToString());
                                double valor_atual = Convert.ToDouble(dgvProdutos.Rows[i].Cells["col_estoque_atual"].Value.ToString());
                                double valor_acerto = valor_real - valor_atual;

                                dgvProdutos.Rows[i].Cells["col_acerto_estoque"].Value = valor_acerto;
                            }
                        }
                    }
                    catch (Exception a)
                    {
                        fbConnection1.Close();
                        MessageBox.Show(a.ToString());
                    }
                }
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            formImprimeEstoque est = new formImprimeEstoque();
            est.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                if(dgvProdutos.SelectedRows.Count > 0)
                {
                    FbCommand insert = new FbCommand();
                    insert.Connection = fbConnection1;
                    fbConnection1.Open();
                    insert.CommandText =
                        @"INSERT INTO PRODUTOS (COD_GRUPO_PRODUTO	,
DESCRICAO_GRUPO_PRODUTO ,
COD_SUB_GRUPO_PRODUTO   ,
DESCRICAO_SUB_GRUPO_PRODUTO ,
DESCRICAO_PRODUTO   ,
CARACT_ADIC_PRODUTO ,
COD_BARRAS_PRODUTO  ,
COD_ONU_PRODUTO ,
CLASSE_TOXIC_PRODUTO    ,
COD_UNIDADE_PRODUTO ,
DESCRICAO_UNIDADE_PRODUTO   ,
META_ANUAL_PRODUTO  ,
COD_REDUZIDO_PRODUTO    ,
TAB_PRODUTO ,
META_SEMESTRAL_PRODUTO  ,
ESTOQUE_ATUAL_PRODUTO   ,
ESTOQUE_RESERVADO_PRODUTO   ,
ESTOQUE_MINIMO_PRODUTO  ,
ESTOQUE_ENCOMENDADO_PRODUTO ,
ESTOQUE_MAXIMO_PRODUTO  ,
ESTOQUE_MEDIO_PRODUTO   ,
CUSTO_PRODUTO   ,
CUSTO_MED_PRODUTO   ,
VALOR_VENDA_PRODUTOR_PRODUTO    ,
VALOR_VENDA_REVEND_PRODUTO  ,
VALOR_PROMOCAO_PRODUTO  ,
OUTRO_VALOR_PRODUTO ,
LUCRO_PRODUTO   ,
ULT_REAJ_PRODUTO    ,
PROD_RECEITA_PRODUTO    ,
STATUS_PRODUTO  ,
ICMS_S_N_PRODUTO    ,
ALIQUOTA_ICMS_PRODUTO   ,
REDUCAO_FORA_PRODUTO    ,
ALIQUOTA_IPI_PRODUTO    ,
PIS_PRODUTO ,
COFINS_PRODUTO  ,
COMISSAO_PRODUTO    ,
COD_MARCA_PRODUTO   ,
MARCA_PRODUTO   ,
IVA_PRODUTO ,
NCM_PRODUTO ,
DESCRICAO_ITEM_PRODUTO  ,
COD_FORNECEDOR_PRODUTO  ,
CFOP_ENTRADA_PRODUTO    ,
ORIGEM_PRODUTO  ,
LOCALIZACAO_PRODUTO ,
ST_PRODUTO  ,
ICMS_FORA_S_N_PRODUTO   ,
ALIQUOTA_FORA_ICMS_PRODUTO  ,
REDUCAO_ICMS_PRODUTO    ,
IVA_FORA_PRODUTO    ,
ALIQUOTA_ICMS_ST_PRODUTO    ,
ALIQUOTA_ICMS_ST_FORA_PRODUTO   ,
ST_SAIDA_PRODUTO    ,
ST_SAIDA_FORA_PRODUTO   ,
MOD_BC_PRODUTO  ,
IPI_PRODUTO ,
ICMS_PRODUTO    ,
ISS_PRODUTO ,
PRESTACAO_SERVICO_PRODUTO   ,
REDUCAO_PRODUTO ,
MOD_BC_ST_PRODUTO   ,
REDUCAO_ST_PRODUTO  ,
IPI_TRIB_PRODUTO    ,
IPI_N_TRIB_PRODUTO  ,
CST_IPI_TRIB_PRODUTO    ,
CST_IPI_N_TRIB_PRODUTO  ,
TIPO_PIS_PRODUTO    ,
CST_PIS_PRODUTO ,
TIPO_COFINS_PRODUTO ,
CST_COFINS_PRODUTO  ,
TIPO_SERVICO_PRODUTO    ,
BC_COM_IPI_PRODUTO  ,
REDUCAO_ST_FORA_PRODUTO ,
UNIDADE_PRODUTO ,
PRECO_PRODUTO   ,
COD_BARRAS_CAIXA_PRODUTO    ,
QTDE_UNIDADE_PRODUTO    ,
CNPJ_FORNECEDOR_PRODUTO ,
NOME_FORNECEDOR_PRODUTO ,
NOME_FAMILIA_PRODUTO    ,
PESO_UNIT_PRODUTO   ,
PIS_COFINS_PRODUTO  ,
DESCONTO_MAXIMO_PRODUTO ,
COEFICIENTE_LUCRO_PRODUTO   ,
CORTAR_SEM_ESTOQUE_PRODUTO  ,
ESTOQUE_DISPONIVEL_PRODUTO  ,
ESTOQUE_RESERVA_FECHADA_PRODUTO ,
CEST_PRODUTO    ,
QTDE_PACOTE_SAIDA_PRODUTO   ,
ALIQUOTA_PIS_PRODUTO    ,
ALIQUOTA_COFINS_PRODUTO ,
ALIQUOTA_IPI_FORA_PRODUTO   ,
INDUSTRIALIZADO_PRODUTO ,
CONTROLE_ESTOQUE_PRODUTO    ,
CUBAGEM_PRODUTO ,
KIT_PROMOCIONAL_PRODUTO ,
ESTOQUE_TERCEIROS_PRODUTO   ,
COD_ALTERNATIVO_PRODUTO ,
OBS_PRODUTO ,
ESTOQUE_SEPARADO_PRODUTO    ,
RATEIO_PRODUTO  ) 
 SELECT 
COD_GRUPO_PRODUTO	,
DESCRICAO_GRUPO_PRODUTO	,
COD_SUB_GRUPO_PRODUTO	,
DESCRICAO_SUB_GRUPO_PRODUTO	,
DESCRICAO_PRODUTO	,
CARACT_ADIC_PRODUTO	,
COD_BARRAS_PRODUTO	,
COD_ONU_PRODUTO	,
CLASSE_TOXIC_PRODUTO	,
COD_UNIDADE_PRODUTO	,
DESCRICAO_UNIDADE_PRODUTO	,
META_ANUAL_PRODUTO	,
COD_REDUZIDO_PRODUTO	,
TAB_PRODUTO	,
META_SEMESTRAL_PRODUTO	,
ESTOQUE_ATUAL_PRODUTO	,
ESTOQUE_RESERVADO_PRODUTO	,
ESTOQUE_MINIMO_PRODUTO	,
ESTOQUE_ENCOMENDADO_PRODUTO	,
ESTOQUE_MAXIMO_PRODUTO	,
ESTOQUE_MEDIO_PRODUTO	,
CUSTO_PRODUTO	,
CUSTO_MED_PRODUTO	,
VALOR_VENDA_PRODUTOR_PRODUTO	,
VALOR_VENDA_REVEND_PRODUTO	,
VALOR_PROMOCAO_PRODUTO	,
OUTRO_VALOR_PRODUTO	,
LUCRO_PRODUTO	,
ULT_REAJ_PRODUTO	,
PROD_RECEITA_PRODUTO	,
STATUS_PRODUTO	,
ICMS_S_N_PRODUTO	,
ALIQUOTA_ICMS_PRODUTO	,
REDUCAO_FORA_PRODUTO	,
ALIQUOTA_IPI_PRODUTO	,
PIS_PRODUTO	,
COFINS_PRODUTO	,
COMISSAO_PRODUTO	,
COD_MARCA_PRODUTO	,
MARCA_PRODUTO	,
IVA_PRODUTO	,
NCM_PRODUTO	,
DESCRICAO_ITEM_PRODUTO	,
COD_FORNECEDOR_PRODUTO	,
CFOP_ENTRADA_PRODUTO	,
ORIGEM_PRODUTO	,
LOCALIZACAO_PRODUTO	,
ST_PRODUTO	,
ICMS_FORA_S_N_PRODUTO	,
ALIQUOTA_FORA_ICMS_PRODUTO	,
REDUCAO_ICMS_PRODUTO	,
IVA_FORA_PRODUTO	,
ALIQUOTA_ICMS_ST_PRODUTO	,
ALIQUOTA_ICMS_ST_FORA_PRODUTO	,
ST_SAIDA_PRODUTO	,
ST_SAIDA_FORA_PRODUTO	,
MOD_BC_PRODUTO	,
IPI_PRODUTO	,
ICMS_PRODUTO	,
ISS_PRODUTO	,
PRESTACAO_SERVICO_PRODUTO	,
REDUCAO_PRODUTO	,
MOD_BC_ST_PRODUTO	,
REDUCAO_ST_PRODUTO	,
IPI_TRIB_PRODUTO	,
IPI_N_TRIB_PRODUTO	,
CST_IPI_TRIB_PRODUTO	,
CST_IPI_N_TRIB_PRODUTO	,
TIPO_PIS_PRODUTO	,
CST_PIS_PRODUTO	,
TIPO_COFINS_PRODUTO	,
CST_COFINS_PRODUTO	,
TIPO_SERVICO_PRODUTO	,
BC_COM_IPI_PRODUTO	,
REDUCAO_ST_FORA_PRODUTO	,
UNIDADE_PRODUTO	,
PRECO_PRODUTO	,
COD_BARRAS_CAIXA_PRODUTO	,
QTDE_UNIDADE_PRODUTO	,
CNPJ_FORNECEDOR_PRODUTO	,
NOME_FORNECEDOR_PRODUTO	,
NOME_FAMILIA_PRODUTO	,
PESO_UNIT_PRODUTO	,
PIS_COFINS_PRODUTO	,
DESCONTO_MAXIMO_PRODUTO	,
COEFICIENTE_LUCRO_PRODUTO	,
CORTAR_SEM_ESTOQUE_PRODUTO	,
ESTOQUE_DISPONIVEL_PRODUTO	,
ESTOQUE_RESERVA_FECHADA_PRODUTO	,
CEST_PRODUTO	,
QTDE_PACOTE_SAIDA_PRODUTO	,
ALIQUOTA_PIS_PRODUTO	,
ALIQUOTA_COFINS_PRODUTO	,
ALIQUOTA_IPI_FORA_PRODUTO	,
INDUSTRIALIZADO_PRODUTO	,
CONTROLE_ESTOQUE_PRODUTO	,
CUBAGEM_PRODUTO	,
KIT_PROMOCIONAL_PRODUTO	,
ESTOQUE_TERCEIROS_PRODUTO	,
COD_ALTERNATIVO_PRODUTO	,
OBS_PRODUTO	,
ESTOQUE_SEPARADO_PRODUTO	,
RATEIO_PRODUTO FROM PRODUTOS WHERE COD_PRODUTO = '" + 
dgvProdutos.SelectedRows[0].Cells["col_cod"].Value.ToString() + "' returning COD_PRODUTO";
                    FbDataAdapter datInsert = new FbDataAdapter();
                    datInsert.InsertCommand = insert;
                    object cod_novo = insert.ExecuteScalar();
                    fbConnection1.Close();


                    FbCommand update = new FbCommand();
                    update.Connection = fbConnection1;
                    fbConnection1.Open();
                    update.CommandText =
                        @"UPDATE PRODUTOS p set p.COD_BARRAS_PRODUTO = '" + cod_novo + "', " +
                        "p.COD_BARRAS_CAIXA_PRODUTO = '" + cod_novo + "' WHERE COD_PRODUTO = '" + cod_novo + "'";
                    FbDataAdapter datUpdate = new FbDataAdapter();
                    datUpdate.UpdateCommand = update;
                    datUpdate.UpdateCommand.ExecuteNonQuery();
                    fbConnection1.Close();

                }
            }
            catch(Exception ex)
            {
                fbConnection1.Close();
                MessageBox.Show(ex.Message);

            }
            selecionar_itens();
        }

        private void buscar_informacoes_padrao(out string _origem, out string _cst, out string _modalidade,
         out string _icms, out string _icms_st, out string _reducao, out string _reducao_st, out string _iva, out string _ipi,
         out string _pis, out string _cofins, out string _iss, out string _crt, out string _aliquota_credito,
         out string _modalidade_st, out string _bc_com_ipi,
         out string _ipi_tributado, out string _ipi_n_tributado,
         out string _cst_ipi_tributado, out string _cst_ipi_n_tributado, out string _tipo_pis, out string _cst_pis,
         out string _tipo_cofins, out string _cst_cofins, out string _pCredICMS)
        {
            _origem = "";
            _cst = "";
            _modalidade = "";
            _icms = "";
            _icms_st = "";
            _reducao = "";
            _reducao_st = "";
            _iva = "";
            _ipi = "";
            _pis = "";
            _cofins = "";
            _iss = "";
            _crt = "";
            _aliquota_credito = "";
            _modalidade_st = "";
            _bc_com_ipi = "";
            _ipi_tributado = "";
            _ipi_n_tributado = "";
            _cst_ipi_tributado = "";
            _cst_ipi_n_tributado = "";
            _tipo_pis = "";
            _cst_pis = "";
            _tipo_cofins = "";
            _cst_cofins = "";
            _pCredICMS = "";
            try
            {
                FbCommand comando = new FbCommand();
                comando.Connection = fbConnection1;
                comando.CommandText =
                   "SELECT * FROM EMPRESA where LICENCA_DLL_NFE_EMPRESA is not null AND CNPJ_EMPRESA = '" + cnpj_empresa + "' ";
                fbConnection1.Open();
                DataSet inf_padrao = new DataSet();
                FbDataAdapter datEmpresa = new FbDataAdapter();
                datEmpresa.SelectCommand = comando;
                datEmpresa.Fill(inf_padrao);
                fbConnection1.Close();
                foreach (DataRow dr in inf_padrao.Tables[0].Rows)
                {
                    _origem = dr["ORIGEM_EMPRESA"].ToString();
                    _cst = dr["CST_EMPRESA"].ToString();
                    _modalidade = dr["MOD_BC_EMPRESA"].ToString();
                    _icms = dr["ICMS_EMPRESA"].ToString();
                    _icms_st = dr["ICMS_ST_EMPRESA"].ToString();
                    _reducao = dr["REDUCAO_EMPRESA"].ToString();
                    _reducao_st = dr["REDUCAO_ST_EMPRESA"].ToString();
                    _iva = dr["IVA_EMPRESA"].ToString();
                    _ipi = dr["IPI_EMPRESA"].ToString();
                    _pis = dr["PIS_EMPRESA"].ToString();
                    _cofins = dr["COFINS_EMPRESA"].ToString();
                    _iss = dr["ISS_EMPRESA"].ToString();
                    _crt = dr["CRT_EMPRESA"].ToString();
                    _aliquota_credito = dr["ALIQUOTA_CREDITO_EMPRESA"].ToString();
                    _modalidade_st = dr["MOD_BC_ST_EMPRESA"].ToString();
                    _bc_com_ipi = dr["BC_COM_IPI_EMPRESA"].ToString();
                    _ipi_tributado = dr["IPI_TRIB_EMPRESA"].ToString();
                    _ipi_n_tributado = dr["IPI_N_TRIB_EMPRESA"].ToString();
                    _cst_ipi_tributado = dr["CST_IPI_TRIB_EMPRESA"].ToString();
                    _cst_ipi_n_tributado = dr["CST_IPI_N_TRIB_EMPRESA"].ToString();
                    _tipo_pis = dr["TIPO_PIS_EMPRESA"].ToString();
                    _cst_pis = dr["CST_PIS_EMPRESA"].ToString();
                    _tipo_cofins = dr["TIPO_COFINS_EMPRESA"].ToString();
                    _cst_cofins = dr["CST_COFINS_EMPRESA"].ToString();
                    _pCredICMS = dr["ALIQUOTA_CREDITO_EMPRESA"].ToString();
                }
            }
            catch
            {
                fbConnection1.Close();
            }
        }

        private void buscar_informacoes_produto(string cod_peca, out string _origem, out string _cst,
           out string _modalidade, out string _icms, out string _icms_st, out string _reducao, out string _reducao_st,
           out string _iva, out string _ipi, out string _pis, out string _cofins, out string _iss,
           out string _crt, out string _aliquota_credito, out string _modalidade_st, out string _bc_com_ipi,
           out string _ipi_tributado, out string _ipi_n_tributado, out string _cst_ipi_tributado,
           out string _cst_ipi_n_tributado, out string _tipo_pis, out string _cst_pis, out string _tipo_cofins,
           out string _cst_cofins, out string _pCredICMS, out string _preco_minimo, out string _custo,
           out string cfop_produto, out string cest_produto, string tipo, string estado, string ncm)
        {
            _cst = ""; _origem = ""; _modalidade = ""; _icms = ""; _icms_st = ""; _reducao = ""; _reducao_st = ""; _iva = ""; _ipi = "";
            _pis = ""; _cofins = ""; _iss = ""; _crt = ""; _aliquota_credito = ""; _modalidade_st = ""; _bc_com_ipi = "";
            _ipi_tributado = ""; _ipi_n_tributado = ""; _cst_ipi_tributado = ""; _cst_ipi_n_tributado = "";
            _tipo_pis = ""; _cst_pis = ""; _tipo_cofins = ""; _cst_cofins = ""; _pCredICMS = ""; _preco_minimo = ""; _custo = ""; cfop_produto = ""; cest_produto = "";
            try
            {

                bool ncm_encontrado = false;
                string tipo_cliente = tipo;
                if (tipo == "Atacadista")
                    tipo = "Revenda";
                foreach (DataRow dr_ncm in dtNcm_cst.Select("Convert(NCM, 'System.String') like '%" + ncm + "%' AND ESTADO like '" +
                    estado + "' AND Tipo like '" + tipo + "' AND Convert(CNPJ, 'System.String') = '" + cnpj_empresa + "'"))
                {
                    if (dr_ncm["CST_ICMS"].ToString() == "")
                        break;
                    else
                    {
                        try
                        {
                            /* icms */
                            ncm_encontrado = true;


                            cfop_produto = dr_ncm["CFOP"].ToString();
                            _cst = dr_ncm["CST_ICMS"].ToString();

                            _icms = dr_ncm["ICMS"].ToString();
                            _icms_st = dr_ncm["ICMS_ST"].ToString();

                            _reducao = dr_ncm["REDUÇÃO"].ToString();
                            _reducao_st = dr_ncm["REDUÇÃO_ST"].ToString();
                            _iva = dr_ncm["MVA"].ToString();

                            /* pis cofins */
                            _pis = "0,00"; _cofins = "0,00";
                            _ipi = "0,00";
                            try
                            {
                                try
                                {
                                    _ipi = Convert.ToDouble(dr_ncm["IPI"].ToString()).ToString();
                                }
                                catch { };
                                if (dr_ncm["CST_IPI"].ToString().Substring(0, 2) != "50")
                                {
                                    _cst_ipi_n_tributado = dr_ncm["CST_IPI"].ToString();
                                    _ipi_tributado = "0";
                                    _ipi_n_tributado = "1";
                                }
                                else
                                {
                                    _cst_ipi_tributado = dr_ncm["CST_IPI"].ToString();
                                    _ipi_tributado = "1";
                                    _ipi_n_tributado = "0";
                                }
                            }
                            catch
                            {
                                _cst_ipi_n_tributado = "53";
                                _ipi_tributado = "0";
                                _ipi_n_tributado = "1";
                            }
                            try
                            {
                                _pis = Convert.ToDouble(dr_ncm["PIS"].ToString()).ToString();
                                _cofins = Convert.ToDouble(dr_ncm["COFINS"].ToString()).ToString();


                            }
                            catch { }

                            if (dr_ncm["CST_COFINS"].ToString() != "")
                            {
                                _cst_cofins = dr_ncm["CST_COFINS"].ToString();
                            }
                            if (dr_ncm["CST_PIS"].ToString() != "")
                            {
                                _cst_pis = dr_ncm["CST_PIS"].ToString();
                            }
                            if (dr_ncm["TIPO_COFINS"].ToString() != "")
                            {
                                _tipo_cofins = dr_ncm["TIPO_COFINS"].ToString();
                            }
                            if (dr_ncm["TIPO_PIS"].ToString() != "")
                            {
                                _tipo_pis = dr_ncm["TIPO_PIS"].ToString();
                            }
                        }
                        catch { }
                    }
                }
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }
        private void button15_Click(object sender, EventArgs e)
        {
            form_tp_opcoes op = new form_tp_opcoes();
            try
            {
                op.ShowDialog();

            }
            finally
            {
                if (op.tipo != "" && op.estado != "")
                {
                    dsTabelaPreco dsTp = new dsTabelaPreco();

                    FbCommand comando_select = new FbCommand();
                    comando_select.Connection = fbConnection1;
                    comando_select.CommandText = @"SELECT COD_PRODUTO, NCM_PRODUTO, NOME_FAMILIA_PRODUTO, 
                            DESCRICAO_GRUPO_PRODUTO, DESCRICAO_SUB_GRUPO_PRODUTO, VALOR_VENDA_REVEND_PRODUTO FROM PRODUTOS";
                    DataSet prod = new DataSet();
                    fbConnection1.Open();
                    datProdutos.SelectCommand = comando_select;
                    datProdutos.Fill(prod);
                    fbConnection1.Close();

                    for (int i = dgvProdutos.SelectedRows.Count - 1; i > -1; i--)
                    {
                        try
                        {
                            string _origem, _cst, _modalidade, _icms, _icms_st, _reducao, _reducao_st, _iva, _ipi, _pis,
                             _cofins, _iss, _crt, _aliquota_credito, _modalidade_st, _bc_com_ipi, _ipi_tributado,
                             _ipi_n_tributado, _cst_ipi_tributado, _cst_ipi_n_tributado, _tipo_pis, _cst_pis,
                             _tipo_cofins, _cst_cofins, _pCredICMS, _preco_minimo, _custo_produto, _cfop_produto, _cest_produto;

                            string estado = op.estado;

                            string cod_produto = dgvProdutos.SelectedRows[i].Cells["col_cod"].Value.ToString();



                            double preco_produto = 0;
                            string ncm = "", familia = "", linha = "", cor = "";
                            try
                            {


                                foreach (DataRow dr in prod.Tables[0].Select("COD_PRODUTO = '" + cod_produto + "'"))
                                {
                                    try
                                    {
                                        ncm = dr["NCM_PRODUTO"].ToString();
                                        buscar_informacoes_produto(cod_produto,
                                out _origem, out _cst, out _modalidade, out _icms,
                                out _icms_st, out _reducao, out _reducao_st, out _iva, out _ipi, out _pis, out _cofins,
                                out _iss, out _crt, out _aliquota_credito, out _modalidade_st, out _bc_com_ipi,
                                out _ipi_tributado, out _ipi_n_tributado, out _cst_ipi_tributado,
                                out _cst_ipi_n_tributado, out _tipo_pis, out _cst_pis, out _tipo_cofins, out _cst_cofins,
                                out _pCredICMS, out _preco_minimo, out _custo_produto, out _cfop_produto, out _cest_produto, op.tipo, estado, ncm);

                                       
                                        familia = dr["NOME_FAMILIA_PRODUTO"].ToString();
                                        linha = dr["DESCRICAO_GRUPO_PRODUTO"].ToString();
                                        cor = dr["DESCRICAO_SUB_GRUPO_PRODUTO"].ToString();
                                        double acrescimo = 1;
                                        if (op.tipo.Contains("Consumidor"))
                                            acrescimo = 1.28;
                                        if (op.tipo.Contains("Atacadista"))
                                            acrescimo = 0.80;
                                        preco_produto = Convert.ToDouble(dr["VALOR_VENDA_REVEND_PRODUTO"].ToString());
                                        double icms = 0;
                                        double impostos = 0;
                                        try
                                        {
                                            icms = (Convert.ToDouble(_icms) / 100);
                                            impostos = (1 + icms + (Convert.ToDouble(_pis) / 100) +
                                            (Convert.ToDouble(_cofins) / 100));
                                        }
                                        catch { }

                                        preco_produto = (preco_produto * impostos);

                                      //  preco_produto = (preco_produto * (1 + ((Convert.ToDouble(_icms) / 100) + (Convert.ToDouble(_pis) / 100) +
                                       //     (Convert.ToDouble(_cofins) / 100))));
                                        preco_produto = preco_produto * acrescimo;




                                        double _valor_total = 0, _bc_icms = 0, _bc_ipi = 0, _red_bc_icms = 0, _valor_ipi = 0, _valor_icms = 0, _valor_st = 0;

                                        try
                                        {
                                            _valor_total = preco_produto;
                                        }
                                        catch { }
                                        //calcular aqui a redução por estado
                                        _bc_icms = _valor_total;
                                        _bc_ipi = _valor_total;
                                        _bc_icms = _valor_total;

                                        try
                                        {
                                            _valor_ipi = _bc_ipi * Convert.ToDouble(_ipi) / 100;
                                        }
                                        catch { }
                                        try
                                        {

                                            double pICMS = 0;
                                            try
                                            {
                                                pICMS = Convert.ToDouble(_icms);
                                            }
                                            catch { }
                                            double pICMSST = 0;
                                            try
                                            {
                                                pICMSST = Convert.ToDouble(_icms_st);
                                            }
                                            catch
                                            {

                                            }
                                            double pMVAST = 0;
                                            try
                                            {
                                                pMVAST = Convert.ToDouble(_iva);
                                            }
                                            catch { }
                                            double vICMS = 0;
                                            try
                                            {
                                                vICMS = _bc_icms * pICMS / 100;
                                            }
                                            catch { }
                                            try
                                            {
                                                if (pMVAST > 0)
                                                {
                                                    double vBCST = _bc_icms + (_bc_icms * pMVAST / 100);
                                                    double valor_temp_icms_st = vBCST * pICMSST / 100;
                                                    _valor_st = valor_temp_icms_st - vICMS;
                                                }
                                            }
                                            catch { }


                                        }


                                        catch { }
                                        try
                                        {
                                            _valor_icms = _bc_icms * Convert.ToDouble(_icms) / 100;

                                        }
                                        catch { }

                                        dsTp.Produtos.AddProdutosRow(Convert.ToInt32(dgvProdutos.SelectedRows[i].Cells["col_cod"].Value.ToString()),
                                            dgvProdutos.SelectedRows[i].Cells["col_cod_forn"].Value.ToString(),
                                            dgvProdutos.SelectedRows[i].Cells["col_cod_ean"].Value.ToString(),
                                            familia, linha, cor,
                                            dgvProdutos.SelectedRows[i].Cells["col_nome"].Value.ToString(), ncm,
                                            dgvProdutos.SelectedRows[i].Cells["col_uni"].Value.ToString(),
                                            _valor_total, _valor_ipi, _valor_st);


                                    }
                                    catch
                                    {

                                    }
                                }

                                

                            }
                            catch { }
                        }
                        catch { }
                    }
                    try
                    {
                        FbCommand select = new FbCommand();
                        select.Connection = fbConnection1;
                        select.CommandText = "SELECT * FROM EMPRESA";
                        FbDataAdapter datSelect = new FbDataAdapter();
                        fbConnection1.Open();
                        datSelect.SelectCommand = select;

                        datSelect.Fill(dsTp.EMPRESA);
                        fbConnection1.Close();


                    }
                    catch (Exception ex)
                    {
                        fbConnection1.Close();
                        MessageBox.Show("Erro:" + ex.Message);
                    }

                    dsTp.Informações.AddInformaçõesRow(op.estado);
                    crTp_estado cr = new crTp_estado();
                    cr.SetDataSource(dsTp);
                    form_imprimir imp = new form_imprimir(cr);
                    imp.Show();
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvProdutos.RowCount; i++)
            {
                double valor_venda = 0, custo = 0;
                try
                {
                    valor_venda = Convert.ToDouble(dgvProdutos.Rows[i].Cells["col_valor_venda"].Value.ToString());
                }
                catch { }
                try
                {
                    custo = Convert.ToDouble(dgvProdutos.Rows[i].Cells["col_custo"].Value.ToString());
                }
                catch { }
                double porc_lucro = 0;
                try
                {
                    porc_lucro = ((valor_venda - custo) / valor_venda) * 100;
                }
                catch { }
                dgvProdutos.Rows[i].Cells["col_porc"].Value = porc_lucro.ToString("n2");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Essa operação irá alterar os produtos, tem certeza?",
             "Confirma?", MessageBoxButtons.YesNo))
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
                        if (usuario._cod_usuario == "1" || usuario._cod_usuario == "2")
                        {
                            salvar();
                        }
                        else
                        {
                            MessageBox.Show("Usuário não autorizado");
                        }
                    }
                    MessageBox.Show("Acerto Realizado!");
                    //selecionar_itens();
                }
            }
        }

        private void salvar()
        {
            try
            {
                this.BindingContext[dsProdutos, "PRODUTOS"].EndCurrentEdit();
                if (dsProdutos.HasChanges())
                {
                    fbConnection1.Open();
                    datProdutos.UpdateCommand = cbProdutos.GetUpdateCommand();
                    datProdutos.InsertCommand = cbProdutos.GetInsertCommand();
                    datProdutos.DeleteCommand = cbProdutos.GetDeleteCommand();
                    datProdutos.Update(dsProdutos, "PRODUTOS");
                    dsProdutos.AcceptChanges();
                    fbConnection1.Close();
                }
            }
            catch
            {
                fbConnection1.Close();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            pesquisa_rapida();

        }

        private void pesquisa_rapida()
        {
            string status = " and status_produto = 1";
            if (cbxStatus.Checked)
                status = "";
           
                try
                {
                    string cod = "", grupo = "", familia = "", descricao = "", cod_barras = "";
                    if (tb_cod_pesquisa.Text != "")
                        cod = " AND UPPER(COD_FORNECEDOR_PRODUTO) LIKE UPPER('%" + tb_cod_pesquisa.Text + "%')";

                    if (tb_grupo_pesquisa.Text != "")
                        grupo = " AND UPPER(DESCRICAO_GRUPO_PRODUTO) LIKE UPPER('%" +  tb_grupo_pesquisa.Text + "%')";

                    if (tb_familia_pesquisa.Text != "")
                        familia = "AND UPPER(FAMILIA_PRODUTO) LIKE UPPER('%" + tb_familia_pesquisa.Text + "%')";

                    if (tb_descricao_pesquisa.Text != "")
                        descricao = " AND UPPER(DESCRICAO_PRODUTO) LIKE UPPER('%" + tb_descricao_pesquisa.Text + "%')";

                    if (tb_cod_barras_pesquisa.Text != "")
                        cod_barras = " AND UPPER(COD_BARRAS_PRODUTO) LIKE UPPER('%" + tb_cod_barras_pesquisa.Text + "%')";

                    dsProdutos.Clear();
                    datProdutos.SelectCommand.CommandText =
                        "SELECT * FROM produtos WHERE 0=0  " + status + cod + grupo + familia + descricao + cod_barras + " ORDER BY cod_produto";
                    datProdutos.SelectCommand.Connection = fbConnection1;
                    fbConnection1.Open();
                    datProdutos.SelectCommand.ExecuteNonQuery();
                    datProdutos.Fill(PRODUTOS);
                    fbConnection1.Close();

                    dgvProdutos.AutoGenerateColumns = false;
                    dgvProdutos.DataSource = dsProdutos.Tables["PRODUTOS"];

                    if (dgvProdutos.RowCount < 200)
                    {
                        formatarDgv();
                    }
    

                }
                catch (Exception a)
                {
                    fbConnection1.Close();
                    MessageBox.Show("Não foi possível selecionar os produtos!\nErro: " + a.Message);
                }
            
        }

        private void tb_cod_pesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                pesquisa_rapida();
            }
        }

        private void tb_grupo_pesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                pesquisa_rapida();
            }
        }

        private void tb_familia_pesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                pesquisa_rapida();
            }
        }

        private void tb_descricao_pesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                pesquisa_rapida();
            }
        }

        private void tb_cod_barras_pesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                pesquisa_rapida();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }
    }
}

    
