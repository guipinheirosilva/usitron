using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.IO;

namespace Evolucao
{
    public partial class form_arquivo_j_macedo : Form
    {
        DataTable dados_tabela = new DataTable();
        public form_arquivo_j_macedo()
        {
            InitializeComponent();
        }
                private void detectar_dados_empresa(out string razao_social_empresa, out string nome_fantasia_empresa, out string cnpj_empresa, out string ie_empresa, out string im_empresa, out string cnae_empresa, out string endereco_empresa, out string n_endereco_empresa,
                    out string complemento_empresa, out string bairro_empresa, out string cidade_empresa, out string estado_empresa, out string cep_empresa, out string telefone_empresa, out string cod_cidade_empresa, out string pais_empresa,
                    out string cod_pais_empresa, out string licenca_dll_nfe_empresa, out string nome_certificado_nfe_empresa, out string assunto_nfe_email_empresa, out string smtp_nfe_empresa, out string email_nfe_empresa,
                    out string senha_email_nfe_empresa, out string logotipo_empresa, out string proxy_empresa, out string usuario_proxy_empresa, out string senha_proxy_empresa, out string crt_empresa)
        {
            razao_social_empresa = ""; nome_fantasia_empresa = ""; cnpj_empresa = ""; ie_empresa = ""; im_empresa = ""; cnae_empresa = ""; endereco_empresa = ""; n_endereco_empresa = "";
                    complemento_empresa = ""; bairro_empresa = ""; cidade_empresa = ""; estado_empresa = ""; cep_empresa = ""; telefone_empresa = ""; cod_cidade_empresa = ""; pais_empresa = "";
                    cod_pais_empresa = ""; licenca_dll_nfe_empresa = ""; nome_certificado_nfe_empresa = ""; assunto_nfe_email_empresa = ""; smtp_nfe_empresa = ""; email_nfe_empresa = "";
                    senha_email_nfe_empresa = ""; logotipo_empresa = ""; proxy_empresa = ""; usuario_proxy_empresa = ""; senha_proxy_empresa = ""; crt_empresa = "";
            try
            {
                FbCommand comando = new FbCommand();
                comando.Connection = fbConnection1;
                comando.CommandText = "SELECT * FROM EMPRESA";
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
                    cnpj_empresa = dr["CNPJ_EMPRESA"].ToString().Replace(".","").Replace("/","").Replace("-","").Replace("(","").Replace(")","").Replace(" ","");
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
                }
                
            }
            catch
            {
                fbConnection1.Close();
                MessageBox.Show("Erro ao buscar dados da empresa");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                 string razao_social_empresa = "", nome_fantasia_empresa = "", cnpj_empresa = "", ie_empresa = "", im_empresa = "", cnae_empresa = "", endereco_empresa = "", n_endereco_empresa = "",
            complemento_empresa = "", bairro_empresa = "", cidade_empresa = "", estado_empresa = "", cep_empresa = "", telefone_empresa = "", cod_cidade_empresa = "", pais_empresa = "",
            cod_pais_empresa = "", licenca_dll_nfe_empresa = "", nome_certificado_nfe_empresa = "", assunto_nfe_email_empresa = "", smtp_nfe_empresa = "", email_nfe_empresa = "",
            senha_email_nfe_empresa = "", logotipo_empresa = "", proxy_empresa = "", usuario_proxy_empresa = "", senha_proxy_empresa = "", crt_empresa = "";

                detectar_dados_empresa(out razao_social_empresa, out nome_fantasia_empresa, out cnpj_empresa, out ie_empresa, out im_empresa, out cnae_empresa, out endereco_empresa, out n_endereco_empresa,
                        out complemento_empresa, out bairro_empresa, out cidade_empresa, out estado_empresa, out cep_empresa, out telefone_empresa, out cod_cidade_empresa, out pais_empresa,
                        out cod_pais_empresa, out licenca_dll_nfe_empresa, out nome_certificado_nfe_empresa, out assunto_nfe_email_empresa, out smtp_nfe_empresa, out email_nfe_empresa,
                        out senha_email_nfe_empresa, out logotipo_empresa, out proxy_empresa, out usuario_proxy_empresa, out senha_proxy_empresa, out crt_empresa);



                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                /*select.CommandText =
                    "SELECT '" + cnpj_empresa + "' AS CNPJ, nota.CNPJ_CLIENTE_FORN, nota.DATA_EMISSAO_NF, " +
                    "nota.N_NF, item.COD_EAN_ITEM, item.QTDE_ITEM, CAST(item.PRECO_UNIT_ITEM as numeric(18,2))PRECO_UNIT_ITEM, '1' AS COD_VENDEDOR, " +
                    "' ' AS RESERVADO, 'N' AS NF, (SELECT CEP_CLIENTE FROM CLIENTES WHERE CNPJ = nota.CNPJ_CLIENTE_FORN) AS CEP " +
                    "FROM NOTA_FISCAL nota INNER JOIN ITENS_NOTA item ON nota.N_NF = item.NF_ITEM INNER JOIN PRODUTOS produto ON " + 
                    "item.COD_EAN_ITEM = produto.COD_BARRAS_PRODUTO WHERE " +
                    " nota.DATA_EMISSAO_NF >= '" + Convert.ToDateTime(dtInicio.Text).ToShortDateString().Replace("/",".") + "' AND " +
                    " nota.DATA_EMISSAO_NF <= '" + Convert.ToDateTime(dtTermino.Text).ToShortDateString().Replace("/",".") + "' AND " + 
                    " produto.CNPJ_FORNECEDOR_PRODUTO = '14998371004530'";*/
                select.CommandText = 
                    "select " +
                    "   ('" + cnpj_empresa + "')cnpj_empresa, " +
                    "   nf.cnpj_cliente_forn, " + 
                    "   nf.data_emissao_nf, " + 
                    "   inf.nf_item, " + 
                    "   inf.cod_ean_item, " + 
                    "   inf.qtde_item, " + 
                    "   inf.preco_unit_item, " + 
                    "   ipv.cod_vendedor_item_venda, " + 
                    "   (' ')reservado, " + 
                    "   ('N')tipo_documento, " + 
                    "   c.cep_cliente " + 
                    "from itens_nota inf " + 
                    "   inner join nota_fiscal nf " + 
                    "       on nf.n_nf = inf.nf_item " + 
                    "   inner join clientes c " + 
                    "       on c.cnpj = nf.cnpj_cliente_forn " + 
                    "   inner join pedidos_nf pnf " + 
                    "       on pnf.nf_pedido_nf = nf.n_nf " + 
                    "   inner join itens_pedido_venda ipv " + 
                    "       on ipv.cod_pedido_item_venda = pnf.n_pedido_nf " +
                    "   inner join produtos p " +
                    "       on p.cod_produto = inf.cod_item " +
                    "where nf.data_emissao_nf >= '" + Convert.ToDateTime(dtInicio.Text).ToShortDateString().Replace("/", ".") + "' " +
                    "   and nf.data_emissao_nf <= '" + Convert.ToDateTime(dtTermino.Text).ToShortDateString().Replace("/", ".") + "' " + 
                    "   and ipv.cod_sistema_prod_item_venda = inf.cod_item " + 
                    "   and pnf.n_pedido_nf is not null " +
                    "   and nf.status_nfe like 'NFe Autorizada.' " +
                    "   and inf.cfop_item in(5101,5102,6101,6102,6404,5405,5551,5901) " +
                    "   and p.cnpj_fornecedor_produto = 14998371004530;";
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                fbConnection1.Open();
                datSelect.Fill(dados_tabela);
                fbConnection1.Close();
                dgvDados.DataSource = dados_tabela;

                formatarDgv();

            }
            catch(Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void formatarDgv()
        {
            dgvDados.Columns[6].DefaultCellStyle.Format = "N2";
        }

 
        private void button2_Click(object sender, EventArgs e)
        {
            string razao_social_empresa = "", nome_fantasia_empresa = "", cnpj_empresa = "", ie_empresa = "", im_empresa = "", cnae_empresa = "", endereco_empresa = "", n_endereco_empresa = "",
           complemento_empresa = "", bairro_empresa = "", cidade_empresa = "", estado_empresa = "", cep_empresa = "", telefone_empresa = "", cod_cidade_empresa = "", pais_empresa = "",
           cod_pais_empresa = "", licenca_dll_nfe_empresa = "", nome_certificado_nfe_empresa = "", assunto_nfe_email_empresa = "", smtp_nfe_empresa = "", email_nfe_empresa = "",
           senha_email_nfe_empresa = "", logotipo_empresa = "", proxy_empresa = "", usuario_proxy_empresa = "", senha_proxy_empresa = "", crt_empresa = "";

            detectar_dados_empresa(out razao_social_empresa, out nome_fantasia_empresa, out cnpj_empresa, out ie_empresa, out im_empresa, out cnae_empresa, out endereco_empresa, out n_endereco_empresa,
                    out complemento_empresa, out bairro_empresa, out cidade_empresa, out estado_empresa, out cep_empresa, out telefone_empresa, out cod_cidade_empresa, out pais_empresa,
                    out cod_pais_empresa, out licenca_dll_nfe_empresa, out nome_certificado_nfe_empresa, out assunto_nfe_email_empresa, out smtp_nfe_empresa, out email_nfe_empresa,
                    out senha_email_nfe_empresa, out logotipo_empresa, out proxy_empresa, out usuario_proxy_empresa, out senha_proxy_empresa, out crt_empresa);

            //ARQUIVO VENDAS
            string caminho = @"c:\evolucao_dokinos\\JMACEDO\VENDASJM" + retirar_caracteres(DateTime.Now.ToString()) + ".txt";
            string caminhoAnsi = @"c:\evolucao_dokinos\\JMACEDO\VENDASJM" + retirar_caracteres(DateTime.Now.ToString()) + "-ansi.txt";

            if (criar_arquivo(caminho))
            {
                FileInfo t = new FileInfo(caminho);
                using (StreamWriter texto = t.CreateText())
                {
                    texto.WriteLine("HVENDA1014998371004530");
                    for (int i = 0; i < dgvDados.RowCount; i++)
                    {
                        try
                        {
                            texto.WriteLine("D" + acertar_tamanho(retirar_caracteres(dgvDados.Rows[i].Cells[0].Value.ToString()), 14) +
                                acertar_tamanho(retirar_caracteres(dgvDados.Rows[i].Cells[1].Value.ToString()), 18) +
                                acertar_data(Convert.ToDateTime(dgvDados.Rows[i].Cells[2].Value.ToString())) +
                                acertar_tamanho(retirar_caracteres(dgvDados.Rows[i].Cells[3].Value.ToString()), 20) +
                                acertar_tamanho(retirar_caracteres(dgvDados.Rows[i].Cells[4].Value.ToString()), 14) +
                                acertar_numero(retirar_caracteres(dgvDados.Rows[i].Cells[5].Value.ToString()), 8) +
                                acertar_numero_decimal(retirar_caracteres(Convert.ToDouble(dgvDados.Rows[i].Cells[6].Value).ToString("N2")), 8, 2, ".","p") +
                                acertar_tamanho(retirar_caracteres(dgvDados.Rows[i].Cells[7].Value.ToString()), 20) +
                                acertar_tamanho(dgvDados.Rows[i].Cells[8].Value.ToString(), 10) +
                                acertar_tamanho(retirar_caracteres(dgvDados.Rows[i].Cells[9].Value.ToString()), 1) +
                                acertar_numero_decimal(retirar_caracteres(dgvDados.Rows[i].Cells[10].Value.ToString()), 8, 3, "-","") +
                                acertar_tamanho("", 13) +
                                acertar_tamanho("", 6) +
                                acertar_tamanho("", 2));
                        }
                        catch { }
                    }
                }
                converterAnsi(caminho);
                System.IO.File.Delete(caminho);
                System.IO.File.Move(caminhoAnsi,caminho);
            }
            
            //ARQUIVO ESTOQUE
            caminho = @"c:\evolucao_dokinos\\JMACEDO\ESTOQUEJM" + retirar_caracteres(DateTime.Now.ToString()) + ".txt";
            caminhoAnsi = @"c:\evolucao_dokinos\\JMACEDO\ESTOQUEJM" + retirar_caracteres(DateTime.Now.ToString()) + "-ansi.txt";
            if (criar_arquivo(caminho))
            {

                FileInfo t = new FileInfo(caminho);
                using (StreamWriter texto = t.CreateText())
                {
                    texto.WriteLine("HESTOQ0914998371004530" + acertar_data(Convert.ToDateTime(dtTermino.Text)));
                    DataTable dtEstoque = new DataTable();
                    buscar_estoque_j_macedo("14998371004530", out dtEstoque);
                    foreach (DataRow dr in dtEstoque.Rows)
                    {
                        try
                        {
                            texto.WriteLine("E" + cnpj_empresa +
                                acertar_tamanho(retirar_caracteres(dr[0].ToString()), 14) +
                                acertar_numero(retirar_caracteres(dr[1].ToString()), 8));                                
                        }
                        catch { }
                    }
                }
                converterAnsi(caminho);
                System.IO.File.Delete(caminho);
                System.IO.File.Move(caminhoAnsi, caminho);
            }

            //ARQUIVO CLIENTES
            caminho = @"c:\evolucao_dokinos\\JMACEDO\CLIENTESJM" + retirar_caracteres(DateTime.Now.ToString()) + ".txt";
            caminhoAnsi = @"c:\evolucao_dokinos\\JMACEDO\CLIENTESJM" + retirar_caracteres(DateTime.Now.ToString()) + "-ansi.txt";
            if (criar_arquivo(caminho))
            {

                FileInfo t = new FileInfo(caminho);
                using (StreamWriter texto = t.CreateText())
                {
                    texto.WriteLine("HPDV10  14998371004530");
                    DataTable dtClientes = new DataTable();
                    buscar_clientes(out dtClientes);
                    foreach (DataRow dr in dtClientes.Rows)
                    {
                        try
                        {
                            texto.WriteLine("D" + retirar_caracteres(cnpj_empresa) +
                                acertar_tamanho(retirar_caracteres(dr[0].ToString()), 18) +
                                acertar_tamanho(dr[1].ToString(), 40) +
                                acertar_tamanho(dr[2].ToString(), 40) +
                                acertar_tamanho(dr[3].ToString(), 30) +
                                acertar_numero_decimal(retirar_caracteres(dr[4].ToString()), 8, 3, "-","") +
                                acertar_tamanho(dr[5].ToString(), 30) +
                                acertar_tamanho(dr[6].ToString(), 30) +
                                acertar_tamanho(dr[7].ToString(), 20) +
                                acertar_tamanho(dr[8].ToString(), 40) +
                                acertar_tamanho(retirar_caracteres(dr[9].ToString()), 18) +
                                acertar_tamanho(retirar_caracteres(dr[10].ToString()), 10) +
                                acertar_tamanho(retirar_caracteres(dr[11].ToString()), 10) +
                                acertar_tamanho(retirar_caracteres(dr[12].ToString()), 10) +
                                acertar_numero_decimal(retirar_caracteres(dr[13].ToString()), 6, 3, ".",""));
                        }
                        catch {  }
                    }
                }
                converterAnsi(caminho);
                System.IO.File.Delete(caminho);
                System.IO.File.Move(caminhoAnsi, caminho);
            }

            //ARQUIVO FORÇA VENDAS
            caminho = @"c:\evolucao_dokinos\\JMACEDO\FORCAVENDASJM" + retirar_caracteres(DateTime.Now.ToString()) + ".txt";
            caminhoAnsi = @"c:\evolucao_dokinos\\JMACEDO\FORCAVENDASJM" + retirar_caracteres(DateTime.Now.ToString()) + "-ansi.txt";
            if (criar_arquivo(caminho))
            {

                FileInfo t = new FileInfo(caminho);
                using (StreamWriter texto = t.CreateText())
                {
                    texto.WriteLine("HFV10   14998371004530");
                    DataTable dtVendedores = new DataTable();
                    buscar_vendedores(out dtVendedores);
                    foreach (DataRow dr in dtVendedores.Rows)
                    {
                        try
                        {
                            texto.WriteLine("D" + retirar_caracteres(cnpj_empresa) +
                                acertar_tamanho(retirar_caracteres(dr[0].ToString()), 18) +
                                acertar_tamanho("1", 13) +
                                acertar_tamanho("JOSE LUIZ", 50) +
                                acertar_tamanho("1", 13) +
                                acertar_tamanho("JOSE LUIZ", 50) +
                                acertar_tamanho(dr[1].ToString(), 20) +
                                acertar_tamanho(dr[2].ToString(), 50));
                        }
                        catch { }
                    }
                }
                converterAnsi(caminho);
                System.IO.File.Delete(caminho);
                System.IO.File.Move(caminhoAnsi, caminho);
            }

            //ARQUIVO PRODUTOS
            caminho = @"c:\evolucao_dokinos\\JMACEDO\PRODUTOSJM" + retirar_caracteres(DateTime.Now.ToString()) + ".txt";
            caminhoAnsi = @"c:\evolucao_dokinos\\JMACEDO\PRODUTOSJM" + retirar_caracteres(DateTime.Now.ToString()) + "-ansi.txt";
            if (criar_arquivo(caminho))
            {

                FileInfo t = new FileInfo(caminho);
                using (StreamWriter texto = t.CreateText())
                {
                    texto.WriteLine("HCADPROD   " + acertar_data(Convert.ToDateTime(dtTermino.Text)));
                    texto.WriteLine("I09229374000158");
                    DataTable dtProdutos = new DataTable();
                    buscar_produtos("14998371004530", out dtProdutos);
                    foreach (DataRow dr in dtProdutos.Rows)
                    {
                        try
                        {
                            texto.WriteLine("V" + acertar_tamanho("14998371004530", 18) +
                                acertar_tamanho("J MACEDO", 30) +
                                acertar_tamanho(dr[0].ToString(), 14) +
                                acertar_tamanho(dr[1].ToString(), 1) +
                                acertar_tamanho(dr[2].ToString(), 14) +
                                acertar_tamanho(dr[3].ToString(), 1) +
                                acertar_tamanho(dr[4].ToString(), 100) + 
                                acertar_tamanho("J MACEDO", 40) + 
                                acertar_tamanho("", 30) + 
                                acertar_tamanho("A", 1) +
                                acertar_tamanho("", 27));
                        }
                        catch { }
                    }
                }
                converterAnsi(caminho);
                System.IO.File.Delete(caminho);
                System.IO.File.Move(caminhoAnsi, caminho);
            }

            MessageBox.Show("Arquivos gerados com sucesso!");

        }

        private void converterAnsi(string arquivo)
        {
            string filepath = arquivo;
            StreamReader fileStream = new StreamReader(filepath);
            string fileContent = fileStream.ReadToEnd();
            Encoding fileEncoding = fileStream.CurrentEncoding;
            fileStream.Close();
            Encoding unicode = Encoding.Unicode;

            Encoding ansi = Encoding.GetEncoding(1252);

            Byte[] utf8Bytes = unicode.GetBytes(fileContent);

            Byte[] ansiBytes = Encoding.Convert(unicode, ansi, utf8Bytes);

            string ansiContent = ansi.GetString(ansiBytes);

            // Now writes the content in ANSI
            StreamWriter ansiWriter = new StreamWriter(filepath.Replace(".txt", "-ansi.txt"), false);
            ansiWriter.Write(ansiContent);
            ansiWriter.Close();
        }

        private void buscar_produtos(string cnpj, out DataTable dtProdutos)
        {
            DataTable dtRetorno = new DataTable();
            dtProdutos = dtRetorno;
            try
            {
                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT COD_PRODUTO, '0', COD_BARRAS_PRODUTO, " + 
                    "'1', DESCRICAO_PRODUTO  FROM " +
                    "PRODUTOS WHERE CNPJ_FORNECEDOR_PRODUTO = '" + cnpj + "'";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                dtProdutos = dtSelect;
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
                fbConnection1.Close();

            }
        }

        private void buscar_vendedores(out DataTable dtVendedores)
        {
            DataTable dtRetorno = new DataTable();
            dtVendedores = dtRetorno;
            try
            {
                FbCommand select = new FbCommand();
                select.CommandText =
                    //"SELECT COD_VENDEDOR, NOME_VENDEDOR FROM " +
                    //"VENDEDORES";
                    "select " + 
                    "    nf.cnpj_cliente_forn, " + 
                    "    pv.cod_vendedor_ped_venda, " + 
                    "    pv.vendedor_ped_venda " + 
                    "from " + 
                    "    nota_fiscal nf " + 
                    "        inner join itens_nota inf " + 
                    "            on nf.n_nf = inf.nf_item " + 
                    "        inner join clientes c " + 
                    "            on c.cnpj = nf.cnpj_cliente_forn " + 
                    "        inner join pedidos_nf pnf " + 
                    "            on pnf.nf_pedido_nf = nf.n_nf " + 
                    "        inner join pedidos_venda pv " + 
                    "            on pv.cod_ped_venda = pnf.n_pedido_nf " + 
                    "        inner join produtos p " + 
                    "            on p.cod_produto = inf.cod_item " +
                    "where " +
                    "    nf.data_emissao_nf >= '" + Convert.ToDateTime(dtInicio.Text).ToShortDateString().Replace("/", ".") + "' " +
                    "    and nf.data_emissao_nf <= '" + Convert.ToDateTime(dtTermino.Text).ToShortDateString().Replace("/", ".") + "' " +
                    "    and pnf.n_pedido_nf is not null " + 
                    "    and nf.status_nfe like 'NFe Autorizada.' " + 
                    "    and inf.cfop_item in(5101,5102,6101,6102,6404,5405,5551,5901) " + 
                    "    and p.cnpj_fornecedor_produto = 14998371004530 " + 
                    "group by " + 
                    "    nf.cnpj_cliente_forn, " + 
                    "    pv.cod_vendedor_ped_venda, " + 
                    "    pv.vendedor_ped_venda;";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                dtVendedores = dtSelect;
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
                fbConnection1.Close();

            }
        }

        private void buscar_clientes(out DataTable dtClientes)
        {
            DataTable dtRetorno = new DataTable();
            dtClientes = dtRetorno;
            try
            {
                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT CNPJ, SUBSTRING(RAZAO_SOCIAL FROM 1 FOR 40), SUBSTRING(ENDERECO FROM 1 FOR 35) || ',' || NUMERO_CLIENTE, " + 
                    " BAIRRO, CEP_CLIENTE, CIDADE, ESTADO, '', FONE, " + 
                    "CNPJ, '0', '', classificacao_clientes, '' FROM " +
                    "CLIENTES";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                dtClientes = dtSelect;
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
                fbConnection1.Close();

            }
        }

        private void buscar_estoque_j_macedo(string cnpj, out DataTable dtEstoque)
        {
            DataTable dtRetorno = new DataTable();
            dtEstoque = dtRetorno;
            try
            {
                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT COD_BARRAS_PRODUTO, ESTOQUE_ATUAL_PRODUTO FROM " + 
                    "PRODUTOS WHERE CNPJ_FORNECEDOR_PRODUTO = '" + cnpj + "'";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                dtEstoque = dtSelect;
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
                fbConnection1.Close();
               
            }
        }

        private string acertar_numero(string numero, int tamanho)
        {
            int tamanho_texto = numero.Length;
            int tamanho_restante = tamanho - tamanho_texto;
            string zero = "";
            for (int i = 0; i < tamanho_restante; i++)
            {
                zero = zero + "0";
            }
            return zero + numero;
        }

        private string acertar_numero_decimal(string numero, int tamanho, int decimais, string caractere, string tipo)
        {
            int tamanho_texto = (numero.Length) + 1;
            int tamanho_restante = tamanho - tamanho_texto;
            string zero = "";
            for (int i = 0; i < tamanho_restante; i++)
            {
                zero = zero + "0";
            }
            string novo_numero = zero + numero;
            int local_caractere = 0;
            local_caractere = tipo == "p" ? ((tamanho - 1) - decimais) : (tamanho - decimais); //Subtrair 1 do tamanho quando o valor for 'preço'
            return novo_numero.Insert(local_caractere, caractere);
        }

        private string acertar_data(DateTime data)
        {
            string mes = data.Month.ToString();
            if (mes.Length == 1)
                mes = "0" + mes;
            string dia = data.Day.ToString();
            if (dia.Length == 1)
                dia = "0" + dia;
            return data.Year.ToString() + mes + dia;
        }

        private string acertar_tamanho(string nome, int n_caracteres)
        {
            try
            {
                string retorno = nome.Trim();
                int tamanho = retorno.Length;

                for (int i = tamanho; i < n_caracteres; i++)
                {
                    retorno = retorno + " ";
                }
                return retorno;
            }
            catch { 
                return "";
            }
        }

        private string retirar_caracteres(string arquivo)
        {
            try
            {
                return arquivo.Replace("Ã", "A").Replace("Õ", "O").Replace("Ç", "C").Replace("Â", "A").Replace("Á", "A").Replace("À", "A")
                .Replace("Ô", "O").Replace("\r\n", " ").Replace("-", "").Replace("(", "").Replace(")", "").Replace("/", "")
                .Replace("&", "e").Replace("'", "").Replace(":", "").Replace(" ", "").Replace(".", "").Replace(",", "");
            }
            catch
            {
                return "";
            }
        }

        public Boolean criar_arquivo(String Name)
        {
            StreamWriter Arquivo;
            try
            {
                Arquivo = new StreamWriter(Name);
                Arquivo.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void form_arquivo_j_macedo_Load(object sender, EventArgs e)
        {

        }
    }
}