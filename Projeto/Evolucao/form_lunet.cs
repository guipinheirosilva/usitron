using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_lunet : Form
    {
        public form_lunet()
        {
            InitializeComponent();
        }

        

        string razao_social_empresa = "", nome_fantasia_empresa = "", cnpj_empresa = "", ie_empresa = "", im_empresa = "", cnae_empresa = "", endereco_empresa = "", n_endereco_empresa = "",
        complemento_empresa = "", bairro_empresa = "", cidade_empresa = "", estado_empresa = "", cep_empresa = "", telefone_empresa = "", cod_cidade_empresa = "", pais_empresa = "",
        cod_pais_empresa = "", licenca_dll_nfe_empresa = "", nome_certificado_nfe_empresa = "", assunto_nfe_email_empresa = "", smtp_nfe_empresa = "", email_nfe_empresa = "",
        senha_email_nfe_empresa = "", logotipo_empresa = "", proxy_empresa = "", usuario_proxy_empresa = "", senha_proxy_empresa = "", crt_empresa = "", serie_empresa = "";

        private void button1_Click(object sender, EventArgs e)
        {
            string [] tabelas = new string[8];
            buscar_tabela_preco(out tabelas[0]);
            buscar_representantes(out tabelas[1]);
            buscar_cond_pgto(out tabelas[2]);
            buscar_parcelas_pagamento(out tabelas[3]);
            buscar_clientes(out tabelas[4]);
            buscar_tipos_venda(out tabelas[5]);
            buscar_itens(out tabelas[6]);
            buscar_itens_tabela_preco(out tabelas[7]);

            string dados = "";
            string arquivo = "";
            for (int i = 0; i < 8; i++)
            {
                string caminho = tabelas[i];
                StreamReader objReader = new StreamReader(caminho);
                ArrayList arrText = new ArrayList();
                dados = objReader.ReadToEnd();
                objReader.Close();
                dados = dados.Remove(dados.Length - 6, 6);
                arquivo += dados;
            }
            

            WebLunetRemessa.LunetRemessa remessa = new WebLunetRemessa.LunetRemessa();
            string retorno = "";
            retorno = remessa.enviardados("13606094000199", "d21582d5bcd1db4cc0a6a2b0a5456e3e", arquivo, "");
            if (retorno != "OK")
            {
                salvar_retorno(retorno);
            }
        }

        private void salvar_retorno(string retorno)
        {
            
        }

        private void buscar_itens_tabela_preco(out string itens_tabela_preco)
        {
            DateTime data_documento = DateTime.Now;
            string caminho = @"c:\\evolucao\\LUNET\ITENS_TP_" + cnpj_empresa + "_" + retirar_caracteres(data_documento.ToString("yyyyMMddHHmmss")) + ".csv";
            //string caminhoAnsi = @"c:\\evolucao\\LUNET\TABELAPRECO_" + cnpj_empresa + "_" + retirar_caracteres(data_documento.ToString("yyyyMMddHHmmss")) + "-ansi.csv";
            itens_tabela_preco = caminho;
            if (criar_arquivo(caminho))
            {
                FileInfo t = new FileInfo(caminho);
                using (StreamWriter texto = t.CreateText())
                {
                    FbCommand select1 = new FbCommand();
                    select1.CommandText =
                    select1.CommandText =
                        "SELECT * FROM TABELA_PRECO";
                    select1.Connection = fbConnection1;
                    fbConnection1.Open();
                    FbDataAdapter datSelect1 = new FbDataAdapter();
                    datSelect1.SelectCommand = select1;
                    DataTable dtSelect1 = new DataTable();
                    datSelect1.Fill(dtSelect1);
                    fbConnection1.Close();
                    
                    foreach (DataRow dr1 in dtSelect1.Rows)
                    {

                        FbCommand select = new FbCommand();
                        select.CommandText =
                        select.CommandText =
                            "SELECT * FROM ITENS_TP WHERE COD_TABELA_ITEM_TP = '" + dr1["COD_TABELA_PRECO"].ToString() + "'";
                        select.Connection = fbConnection1;
                        fbConnection1.Open();
                        FbDataAdapter datSelect = new FbDataAdapter();
                        datSelect.SelectCommand = select;
                        DataTable dtSelect = new DataTable();
                        datSelect.Fill(dtSelect);
                        fbConnection1.Close();
                        string conteudo = "";
                        foreach (DataRow dr in dtSelect.Rows)
                        {
                            conteudo += "1.03;ITENS DA TABELA DE PRECO;" + dr1["COD_TABELA_PRECO"].ToString() + ";ADM;" +
                                dr["COD_PRODUTO_ITEM_TP"].ToString() + ";0;999999;" +
                                dr["PRECO_PRODUTO_ITEM_TP"].ToString().Replace(".","").Replace(",",".") + 
                                ";1900-01-01;2999-12-31;100.00;" + 
                                dr["PRECO_MINIMO_ITEM_TP"].ToString().Replace(".","").Replace(",",".") + ";1900-01-01;2999-12-31;100.00;<br>";
                        }
                        texto.WriteLine(conteudo);
                    }


                }
            }
        }

        private void buscar_itens(out string itens)
        {
            DateTime data_documento = DateTime.Now;
            string caminho = @"c:\\evolucao\\LUNET\ITENS_" + cnpj_empresa + "_" + retirar_caracteres(data_documento.ToString("yyyyMMddHHmmss")) + ".csv";
            //string caminhoAnsi = @"c:\\evolucao\\LUNET\TABELAPRECO_" + cnpj_empresa + "_" + retirar_caracteres(data_documento.ToString("yyyyMMddHHmmss")) + "-ansi.csv";
            itens = caminho;
            if (criar_arquivo(caminho))
            {
                FileInfo t = new FileInfo(caminho);
                using (StreamWriter texto = t.CreateText())
                {
                    FbCommand select = new FbCommand();
                    select.CommandText =
                    select.CommandText =
                        "SELECT * FROM PRODUTOS WHERE STATUS_PRODUTO = '1'";
                    select.Connection = fbConnection1;
                    fbConnection1.Open();
                    FbDataAdapter datSelect = new FbDataAdapter();
                    datSelect.SelectCommand = select;
                    DataTable dtSelect = new DataTable();
                    datSelect.Fill(dtSelect);
                    fbConnection1.Close();
                    string conteudo = "";
                    foreach (DataRow dr in dtSelect.Rows)
                    {
                        string cod_familia = buscar_cod_familia(dr["NOME_FAMILIA_PRODUTO"].ToString());
                        string nome_familia = dr["NOME_FAMILIA_PRODUTO"].ToString();
                        if(cod_familia == "")
                            nome_familia = "";
                        double desconto = 0;
                        try
                        {
                            desconto = 1 - Convert.ToDouble(dr["VALOR_PROMOCAO_PRODUTO"].ToString()) /
                                Convert.ToDouble(dr["VALOR_VENDA_REVEND_PRODUTO"].ToString());
                        }
                        catch { }
                        conteudo += "1.03;ITEM;" + dr["COD_PRODUTO"].ToString() + ";" +
                            dr["COD_FORNECEDOR_PRODUTO"].ToString() + ";" + dr["DESCRICAO_PRODUTO"].ToString() + ";" + 
                            cod_familia + ";" + nome_familia + ";" + dr["COD_GRUPO_PRODUTO"].ToString() + ";" +
                            dr["DESCRICAO_GRUPO_PRODUTO"].ToString() + ";" + dr["COD_SUB_GRUPO_PRODUTO"].ToString() + ";" +
                            dr["DESCRICAO_SUB_GRUPO_PRODUTO"].ToString() + ";" + dr["DESCRICAO_UNIDADE_PRODUTO"].ToString() + ";" + 
                            dr["CNPJ_FORNECEDOR_PRODUTO"].ToString() + ";" + dr["NOME_FORNECEDOR_PRODUTO"].ToString() + ";;;;;;100;" +
                            dr["ESTOQUE_ATUAL_PRODUTO"].ToString().Replace(".", "").Replace(",", ".") + ";S;" + dr["DESCRICAO_ITEM_PRODUTO"].ToString() + ";;;;" +
                            dr["PESO_UNIT_PRODUTO"].ToString().Replace(".", "").Replace(",", ".") + ";" + dr["PESO_UNIT_PRODUTO"].ToString().Replace(".", "").Replace(",", ".") + ";;;;;" + 
                            dr["QTDE_UNIDADE_PRODUTO"].ToString() + ";N;" +
                            Convert.ToDateTime(dr["DATA_INCLUSAO_PRODUTO"].ToString()).ToString("yyyy-MM-dd") + ";ALL;A;;;<br>";
                           
                    }
                    texto.WriteLine(conteudo);

                }
            }
        }

        private string buscar_cod_familia(string familia)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT * FROM FAMILIA_PRODUTO WHERE FAMILIA_FP = '" + familia + "'";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    return dr["COD_FP"].ToString();
                }
                return "";
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                return "";
            }
        }

        private void buscar_tipos_venda(out string tipos_venda)
        {
           
            DateTime data_documento = DateTime.Now;
            string caminho = @"c:\\evolucao\\LUNET\TIPOSVENDA_" + cnpj_empresa + "_" + retirar_caracteres(data_documento.ToString("yyyyMMddHHmmss")) + ".csv";
            //string caminhoAnsi = @"c:\\evolucao\\LUNET\TABELAPRECO_" + cnpj_empresa + "_" + retirar_caracteres(data_documento.ToString("yyyyMMddHHmmss")) + "-ansi.csv";
            tipos_venda = caminho;
            if (criar_arquivo(caminho))
            {
                FileInfo t = new FileInfo(caminho);
                using (StreamWriter texto = t.CreateText())
                {
                    FbCommand select = new FbCommand();
                    select.CommandText =
                    select.CommandText =
                        "SELECT * FROM CFO WHERE TRIBUTADA_CFO = '1'";
                    select.Connection = fbConnection1;
                    fbConnection1.Open();
                    FbDataAdapter datSelect = new FbDataAdapter();
                    datSelect.SelectCommand = select;
                    DataTable dtSelect = new DataTable();
                    datSelect.Fill(dtSelect);
                    fbConnection1.Close();
                    string conteudo = "";
                    foreach (DataRow dr in dtSelect.Rows)
                    {
                         conteudo += "1.01;TIPO DE VENDA;" + dr["COD_SISTEMA_CFO"].ToString() + ";" + 
                              dr["DESCRICAO_CFO"].ToString() + ";A;;;ALL;ALL;<br>";
                    }
                    texto.WriteLine(conteudo);

                }
            }
        
        }

        private void buscar_clientes(out string clientes)
        {
            DateTime data_documento = DateTime.Now;
            string caminho = @"c:\\evolucao\\LUNET\CLIENTES_" + cnpj_empresa + "_" + retirar_caracteres(data_documento.ToString("yyyyMMddHHmmss")) + ".csv";
            //string caminhoAnsi = @"c:\\evolucao\\LUNET\TABELAPRECO_" + cnpj_empresa + "_" + retirar_caracteres(data_documento.ToString("yyyyMMddHHmmss")) + "-ansi.csv";
            clientes = caminho;
            if (criar_arquivo(caminho))
            {
                FileInfo t = new FileInfo(caminho);
                using (StreamWriter texto = t.CreateText())
                {
                    FbCommand select = new FbCommand();
                    select.CommandText =
                    select.CommandText =
                        "SELECT first(10) * FROM CLIENTES WHERE ATIVO_CLIENTE = '1'";
                    select.Connection = fbConnection1;
                    fbConnection1.Open();
                    FbDataAdapter datSelect = new FbDataAdapter();
                    datSelect.SelectCommand = select;
                    DataTable dtSelect = new DataTable();
                    datSelect.Fill(dtSelect);
                    fbConnection1.Close();
                    string conteudo = "";

                    foreach (DataRow dr in dtSelect.Rows)
                    {
                        try
                        {
                            string tipo_pessoa = "J";
                            if (dr["PESSOA_FISICA_CLIENTE"].ToString() == "1")
                                tipo_pessoa = "F";

                            string codigos, cpfs;
                            buscar_vendedores_cliente(dr["COD_CLIENTE"].ToString(), out codigos, out cpfs);
                            conteudo += "1.06;CLIENTE;;" + dr["COD_CLIENTE"].ToString() + ";N;" + tipo_pessoa + ";" +
                                dr["CNPJ"].ToString() + ";" + dr["IE"].ToString() + ";" + dr["RAZAO_SOCIAL"].ToString() + ";" + dr["RAZAO_SOCIAL"].ToString() + ";Principal;" +
                                dr["CEP_CLIENTE"].ToString().Replace("-","") + ";Outros;" +
                                dr["ENDERECO"].ToString() + ";" + dr["ENDERECO"].ToString() + ";" + dr["NUMERO_CLIENTE"].ToString() + ";" + dr["COMPLEMENTO_CLIENTE"].ToString() + ";" +
                          dr["BAIRRO"].ToString() + ";" + dr["CIDADE"].ToString() + ";" + dr["ESTADO"].ToString() + ";;;;" + dr["FONE"].ToString() + ";;;;;" + dr["CONTATO1"].ToString() + ";" +
                          dr["EMAIL"].ToString() + ";;;;;;;;;" +
                          codigos + ";" + cpfs + ";;;" + dr["COD_TP_CLIENTE"].ToString() + ";ALL;;;" + dr["FORMA_PAGAMENTO_CLIENTE"].ToString() + ";ALL;;ALL;;" + dr["LIMITE_CREDITO_CLIENTE"].ToString().Replace(".", "").Replace(",", ".") + ";N;;" +
                          Convert.ToDateTime(dr["DATA_INCLUSAO_CLIENTE"].ToString()).ToString("yyyy-MM-dd") + ";A;;;<br>";
                          /*
                          ;;" + dr["COD_TP_CLIENTE"].ToString() + ";ALL;;;;ALL;;" +
                          dr["LIMITE_CREDITO_CLIENTE"].ToString().Replace(".", "").Replace(",", ".") + ";ALL;;;" + dr["FORMA_PAGAMENTO_CLIENTE"].ToString() + ";ALL;;ALL;" +
                          Convert.ToDateTime(dr["DATA_INCLUSAO_CLIENTE"].ToString()).Year.ToString() + ";A;;;<br>";
                           */ 
                        }
                        catch { }
                    }
                    texto.WriteLine(conteudo);


                }
            }
        }

        private void buscar_vendedores_cliente(string cod_cliente, out string codigos, out string cpfs)
        {
            string[,] vendedores = new string[2, 100];
            codigos = "["; cpfs = "[";
            try
            {
                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT v.COD_VENDEDOR, v.CPF_VENDEDOR FROM VENDEDORES v " + 
                    "LEFT JOIN VENDEDORES_CLIENTE vc ON vc.COD_VENDEDOR_VC = v.COD_VENDEDOR " +
                    "WHERE vc.COD_CLIENTE_VC = '" + cod_cliente +  "'";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                int i = 0;
                foreach (DataRow dr in dtSelect.Rows)
                {
                    vendedores[i, 0] = dr[0].ToString();
                    vendedores[i, 1] = dr[1].ToString();
                    i++;
                }
                for (int j = 0; j < i; j++)
                {
                    if (j != i - 1)
                    {
                        codigos += vendedores[j, 0] + ",";
                        cpfs += vendedores[j, 1] + ",";
                    }
                    else
                    {
                        codigos += vendedores[j, 0] + "";
                        cpfs += vendedores[j, 1] + "";
                    }
                }
                codigos += "]";
                cpfs += "]";
            }
            catch(Exception a)
            {
                fbConnection1.Close();
            }
        }

        private void buscar_parcelas_pagamento(out string parcelas_pagamento)
        {
            DateTime data_documento = DateTime.Now;
            string caminho = @"c:\\evolucao\\LUNET\PARCELAFORMAPGTO_" + cnpj_empresa + "_" + retirar_caracteres(data_documento.ToString("yyyyMMddHHmmss")) + ".csv";
            //string caminhoAnsi = @"c:\\evolucao\\LUNET\TABELAPRECO_" + cnpj_empresa + "_" + retirar_caracteres(data_documento.ToString("yyyyMMddHHmmss")) + "-ansi.csv";
            parcelas_pagamento = caminho;
            if (criar_arquivo(caminho))
            {
                FileInfo t = new FileInfo(caminho);
                using (StreamWriter texto = t.CreateText())
                {
                    FbCommand select = new FbCommand();
                    select.CommandText =
                    select.CommandText =
                        "SELECT * FROM FORMA_PGTO";
                    select.Connection = fbConnection1;
                    fbConnection1.Open();
                    FbDataAdapter datSelect = new FbDataAdapter();
                    datSelect.SelectCommand = select;
                    DataTable dtSelect = new DataTable();
                    datSelect.Fill(dtSelect);
                    fbConnection1.Close();
                    string conteudo = "";
                    foreach (DataRow dr in dtSelect.Rows)
                    {

                        double percentual = 0;
                        try
                        {
                            percentual = 1 / Convert.ToInt16(dr["N_PARCELAS_FORMA_PGTO"].ToString()) * 100;
                        }
                        catch { }
                        for (int i = 0; i < Convert.ToInt16(dr["N_PARCELAS_FORMA_PGTO"].ToString()) && i < 6; i++)
                        {
                            conteudo += "1.00;CONDICAO DE PAGAMENTO PARCELAS;" + dr["COD_FORMA_PGTO"].ToString() + ";" + i.ToString() + ";" + 
                                dr[i + 3].ToString() + ";" + percentual.ToString("n2").Replace(".","").Replace(",",".") + ";<br>";
                        }
                    }
                    texto.WriteLine(conteudo);


                }
            }
        }

        private void buscar_cond_pgto(out string forma_pgto)
        {
            DateTime data_documento = DateTime.Now;
            string caminho = @"c:\\evolucao\\LUNET\CONDPGTO_" + cnpj_empresa + "_" + retirar_caracteres(data_documento.ToString("yyyyMMddHHmmss")) + ".csv";
            //string caminhoAnsi = @"c:\\evolucao\\LUNET\TABELAPRECO_" + cnpj_empresa + "_" + retirar_caracteres(data_documento.ToString("yyyyMMddHHmmss")) + "-ansi.csv";
            forma_pgto = caminho;
            if (criar_arquivo(caminho))
            {
                FileInfo t = new FileInfo(caminho);
                using (StreamWriter texto = t.CreateText())
                {
                    FbCommand select = new FbCommand();
                    select.CommandText =
                    select.CommandText =
                        "SELECT * FROM FORMA_PGTO";
                    select.Connection = fbConnection1;
                    fbConnection1.Open();
                    FbDataAdapter datSelect = new FbDataAdapter();
                    datSelect.SelectCommand = select;
                    DataTable dtSelect = new DataTable();
                    datSelect.Fill(dtSelect);
                    fbConnection1.Close();
                    string conteudo = "";
                    foreach (DataRow dr in dtSelect.Rows)
                    {
                        conteudo += "1.06;CONDICAO DE PAGAMENTO;" + dr["COD_FORMA_PGTO"].ToString() + ";" + dr["DESCRICAO_FORMA_PGTO"].ToString() + ";" + 
                            dr["N_PARCELAS_FORMA_PGTO"].ToString() + ";0;X;ADM;ADM;ADM;ADM;;A;;;<br>";
                    }
                    texto.WriteLine(conteudo);
                }
            }
        }


        private void buscar_forma_pgto(out string forma_pgto)
        {
            DateTime data_documento = DateTime.Now;
            string caminho = @"c:\\evolucao\\LUNET\FORMAPGTO_" + cnpj_empresa + "_" + retirar_caracteres(data_documento.ToString("yyyyMMddHHmmss")) + ".csv";
            //string caminhoAnsi = @"c:\\evolucao\\LUNET\TABELAPRECO_" + cnpj_empresa + "_" + retirar_caracteres(data_documento.ToString("yyyyMMddHHmmss")) + "-ansi.csv";
            forma_pgto = caminho;
            if (criar_arquivo(caminho))
            {
                FileInfo t = new FileInfo(caminho);
                using (StreamWriter texto = t.CreateText())
                {
                    FbCommand select = new FbCommand();
                    select.CommandText =
                    select.CommandText =
                        "SELECT * FROM FORMA_PGTO";
                    select.Connection = fbConnection1;
                    fbConnection1.Open();
                    FbDataAdapter datSelect = new FbDataAdapter();
                    datSelect.SelectCommand = select;
                    DataTable dtSelect = new DataTable();
                    datSelect.Fill(dtSelect);
                    fbConnection1.Close();
                    string conteudo = "";
                    foreach (DataRow dr in dtSelect.Rows)
                    {
                        conteudo += "1.11;FORMA DE PAGAMENTO;" + dr["COD_FORMA_PGTO"].ToString() + ";" + dr["DESCRICAO_FORMA_PGTO"].ToString() + ";S;A;;ALL;<br>";
                    }
                    texto.WriteLine(conteudo);
                }
            }
        }

        private void buscar_representantes(out string representantes)
        {
            DateTime data_documento = DateTime.Now;
            string caminho = @"c:\\evolucao\\LUNET\REPRESENTANTES_" + cnpj_empresa + "_" + retirar_caracteres(data_documento.ToString("yyyyMMddHHmmss")) + ".csv";
            //string caminhoAnsi = @"c:\\evolucao\\LUNET\TABELAPRECO_" + cnpj_empresa + "_" + retirar_caracteres(data_documento.ToString("yyyyMMddHHmmss")) + "-ansi.csv";
            representantes = caminho;
            if (criar_arquivo(caminho))
            {
                FileInfo t = new FileInfo(caminho);
                using (StreamWriter texto = t.CreateText())
                {
                    FbCommand select = new FbCommand();
                    select.CommandText =
                    select.CommandText =
                        "SELECT * FROM VENDEDORES WHERE ATIVO_VENDEDOR = '1'";
                    select.Connection = fbConnection1;
                    fbConnection1.Open();
                    FbDataAdapter datSelect = new FbDataAdapter();
                    datSelect.SelectCommand = select;
                    DataTable dtSelect = new DataTable();
                    datSelect.Fill(dtSelect);
                    fbConnection1.Close();
                    string conteudo = "";
                    foreach (DataRow dr in dtSelect.Rows)
                    {
                        string ativo = "I";
                        if(dr["ATIVO_VENDEDOR"].ToString() == "1")
                            ativo = "A";
                        conteudo += "1.02;REPRESENTANTE;" + dr["COD_VENDEDOR"].ToString() + ";F;" + dr["CPF_VENDEDOR"].ToString() + ";" + dr["RG_VENDEDOR"].ToString() + ";" + dr["NOME_VENDEDOR"].ToString() + ";" +
                            dr["APELIDO_VENDEDOR"].ToString() + ";" + dr["ESTADO_VENDEDOR"].ToString() + ";" + dr["EMAIL_VENDEDOR"].ToString() + ";" + dr["TELEFONE_VENDEDOR"].ToString() + ";;" + dr["CELULAR_VENDEDOR"].ToString() + ";;" + 
                            ativo + ";;;;;;;<br>";
                    }
                    texto.WriteLine(conteudo);
                }
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

        private string retirar_caracteres(string arquivo)
        {
            try
            {
                return arquivo.Replace("Ã", "A").Replace("Õ", "O").Replace("Ç", "C").Replace("Â", "A").Replace("Á", "A").Replace("À", "A")
                .Replace("Ô", "O").Replace("\r\n", " ").Replace("-", "").Replace("(", "").Replace(")", "").Replace("/", "")
                .Replace("&", "e").Replace("'", "").Replace(":", "").Replace(" ", "").Replace(".", "").Replace(",", "").Replace("-", "").Replace("_", "");
            }
            catch
            {
                return "";
            }
        }

        private void buscar_tabela_preco(out string tabela_preco)
        {
            DateTime data_documento = DateTime.Now;
            string caminho = @"c:\\evolucao\\LUNET\TABELAPRECO_" + cnpj_empresa + "_" + retirar_caracteres(data_documento.ToString("yyyyMMddHHmmss")) + ".csv";
            //string caminhoAnsi = @"c:\\evolucao\\LUNET\TABELAPRECO_" + cnpj_empresa + "_" + retirar_caracteres(data_documento.ToString("yyyyMMddHHmmss")) + "-ansi.csv";
            tabela_preco = caminho;
            if (criar_arquivo(caminho))
            {
                FileInfo t = new FileInfo(caminho);
                using (StreamWriter texto = t.CreateText())
                {
                   FbCommand select = new FbCommand();
                   select.CommandText =
                   select.CommandText =
                       "SELECT * FROM TABELA_PRECO";
                    select.Connection = fbConnection1;
                    fbConnection1.Open();
                    FbDataAdapter datSelect = new FbDataAdapter();
                    datSelect.SelectCommand = select;
                    DataTable dtSelect = new DataTable();
                    datSelect.Fill(dtSelect);
                    fbConnection1.Close();
                    string conteudo = "";
                    foreach (DataRow dr in dtSelect.Rows)
                    {
                        conteudo += "1.04;TABELA DE PRECO;" + dr["COD_TABELA_PRECO"].ToString() + ";" + dr["NOME_TABELA_PRECO"].ToString() + ";100;S;S;S;N;A;;;ALL;ALL;ALL;ALL;ALL;ALL;;<br>";
                    }
                    texto.WriteLine(conteudo);
                }
            }
        }

        private void form_lunet_Load(object sender, EventArgs e)
        {
            detectar_dados_empresa(out razao_social_empresa, out nome_fantasia_empresa, out cnpj_empresa, out ie_empresa, out im_empresa, out cnae_empresa, out endereco_empresa, out n_endereco_empresa,
                   out complemento_empresa, out bairro_empresa, out cidade_empresa, out estado_empresa, out cep_empresa, out telefone_empresa, out cod_cidade_empresa, out pais_empresa,
                   out cod_pais_empresa, out licenca_dll_nfe_empresa, out nome_certificado_nfe_empresa, out assunto_nfe_email_empresa, out smtp_nfe_empresa, out email_nfe_empresa,
                   out senha_email_nfe_empresa, out logotipo_empresa, out proxy_empresa, out usuario_proxy_empresa, out senha_proxy_empresa, out crt_empresa, out serie_empresa);

        }

        private void detectar_dados_empresa(out string razao_social_empresa, out string nome_fantasia_empresa, out string cnpj_empresa, out string ie_empresa, out string im_empresa, out string cnae_empresa, out string endereco_empresa, out string n_endereco_empresa,
       out string complemento_empresa, out string bairro_empresa, out string cidade_empresa, out string estado_empresa, out string cep_empresa, out string telefone_empresa, out string cod_cidade_empresa, out string pais_empresa,
       out string cod_pais_empresa, out string licenca_dll_nfe_empresa, out string nome_certificado_nfe_empresa, out string assunto_nfe_email_empresa, out string smtp_nfe_empresa, out string email_nfe_empresa,
       out string senha_email_nfe_empresa, out string logotipo_empresa, out string proxy_empresa, out string usuario_proxy_empresa, out string senha_proxy_empresa, out string crt_empresa, out string serie_empresa)
        {
            razao_social_empresa = ""; nome_fantasia_empresa = ""; cnpj_empresa = ""; ie_empresa = ""; im_empresa = ""; cnae_empresa = ""; endereco_empresa = ""; n_endereco_empresa = "";
            complemento_empresa = ""; bairro_empresa = ""; cidade_empresa = ""; estado_empresa = ""; cep_empresa = ""; telefone_empresa = ""; cod_cidade_empresa = ""; pais_empresa = "";
            cod_pais_empresa = ""; licenca_dll_nfe_empresa = ""; nome_certificado_nfe_empresa = ""; assunto_nfe_email_empresa = ""; smtp_nfe_empresa = ""; email_nfe_empresa = "";
            senha_email_nfe_empresa = ""; logotipo_empresa = ""; proxy_empresa = ""; usuario_proxy_empresa = ""; senha_proxy_empresa = ""; crt_empresa = ""; serie_empresa = "";
            try
            {
                FbCommand comando = new FbCommand();
                comando.Connection = fbConnection1;
                comando.CommandText = "SELECT * FROM EMPRESA WHERE LICENCA_DLL_NFE_EMPRESA IS NOT NULL";
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
                    cnpj_empresa = dr["CNPJ_EMPRESA"].ToString().Replace(".", "").Replace("/", "").Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
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
                    serie_empresa = dr["SERIE_NF_EMPRESA"].ToString();
                }

            }
            catch
            {
                fbConnection1.Close();
                MessageBox.Show("Erro ao buscar dados da empresa");
            }
        }

    }
}
