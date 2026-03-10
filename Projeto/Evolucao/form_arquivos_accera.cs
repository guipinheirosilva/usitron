using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using Evolucao.Modelos;

namespace Evolucao
{
    public partial class form_arquivos_accera : Form
    {
        string razao_social_empresa = "", nome_fantasia_empresa = "", cnpj_empresa = "", ie_empresa = "", im_empresa = "", cnae_empresa = "", endereco_empresa = "", n_endereco_empresa = "",
        complemento_empresa = "", bairro_empresa = "", cidade_empresa = "", estado_empresa = "", cep_empresa = "", telefone_empresa = "", cod_cidade_empresa = "", pais_empresa = "",
        cod_pais_empresa = "", licenca_dll_nfe_empresa = "", nome_certificado_nfe_empresa = "", assunto_nfe_email_empresa = "", smtp_nfe_empresa = "", email_nfe_empresa = "",
        senha_email_nfe_empresa = "", logotipo_empresa = "", proxy_empresa = "", usuario_proxy_empresa = "", senha_proxy_empresa = "", crt_empresa = "", serie_empresa = "";

        public form_arquivos_accera()
        {
            InitializeComponent();
        }
        private void form_arquivos_accera_Load(object sender, EventArgs e)
        {
            detectar_dados_empresa(out razao_social_empresa, out nome_fantasia_empresa, out cnpj_empresa, out ie_empresa, out im_empresa, out cnae_empresa, out endereco_empresa, out n_endereco_empresa,
           out complemento_empresa, out bairro_empresa, out cidade_empresa, out estado_empresa, out cep_empresa, out telefone_empresa, out cod_cidade_empresa, out pais_empresa,
           out cod_pais_empresa, out licenca_dll_nfe_empresa, out nome_certificado_nfe_empresa, out assunto_nfe_email_empresa, out smtp_nfe_empresa, out email_nfe_empresa,
           out senha_email_nfe_empresa, out logotipo_empresa, out proxy_empresa, out usuario_proxy_empresa, out senha_proxy_empresa, out crt_empresa, out serie_empresa);

        }
        private void btnGerarArquivos_Click(object sender, EventArgs e)
        {
            gerar_produtos();
            gerar_lojas();
            gerar_clientes();
            gerar_estoque();
            gerar_notas_entrada();
            gerar_vendas();
        }

        //adicionar o where para o cnpj apenas da batavo
        private void gerar_produtos()
        {
            DateTime data_documento = DateTime.Now;

            //NOME E CAMINHO DO ARQUIVOS
            string caminho = @"c:\\evolucao\\accera\arquivosTXT\ACC_CADPROD_" + retirar_caracteres(data_documento.ToString("yyyyMMdd")) + ".txt";
            string caminhoAnsi = @"c:\\evolucao\\accera\arquivosTXT\ACC_CADPROD_" + retirar_caracteres(data_documento.ToString("yyyyMMdd")) + "-ansi.txt";

            if (criar_arquivo(caminho))
            {
                FileInfo t = new FileInfo(caminho);
                using (StreamWriter texto = t.CreateText())
                {
                    //CABEÇALHO
                    //H;CNPJ_DISTRIBUIDOR;UN;KG;3;CX;PALLET;BU;DATA_CRIACAO_ARQUIVO
                    texto.WriteLine("H" + ";" + cnpj_empresa + ";" + "UN" + ";" + "KG" + ";" + "3" + ";" + "CX" +
                    ";" + "PALLET" + ";" + "BU" + ";" + retirar_caracteres(data_documento.ToString("yyyyMMdd")));

                    //VALORES
                    //FIXO = V;CNPJ_FORNECEDOR;RAZAO_FORNECEDOR;COD_PRODUTO;DESCRICAO_PRODUTO;COD_GRUPO;DESCRICAO_GRUPO;COD_FAMILIA
                    //DESCRICAO_FAMILIA;COD_SUB_FAMILIA;DESCRICAO_SUBFAMILIA;FIXO = E;COD_EAN;TIPO_EMBALAGEM;FIXO = UN; VOLUME_EMBALAGEM * 1000; STATUS_PRODUTO;DATA_CADASTRO
                    DataTable dt = new DataTable();

                    FbDataAdapter da = new FbDataAdapter(@"
                    SELECT P.cnpj_fornecedor_produto,P.nome_fornecedor_produto,
                    P.cod_produto,P.descricao_produto,P.cod_grupo_produto,P.descricao_grupo_produto,P.descricao_unidade_produto,
                    P.cod_barras_produto,P.qtde_unidade_produto,P.status_produto FROM produtos P WHERE P.nome_fornecedor_produto LIKE '%ELEBAT%'", fbConnection1);
                    da.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        //preenchendo o objeto produto
                        ModeloProduto produto = new ModeloProduto();
                        produto.CNPJ_FORNECEDOR_PRODUTO = dr["CNPJ_FORNECEDOR_PRODUTO"].ToString();

                        produto.NOME_FORNECEDOR_PRODUTO = dr["NOME_FORNECEDOR_PRODUTO"].ToString();

                        try { produto.COD_PRODUTO = int.Parse(dr["COD_PRODUTO"].ToString()); }
                        catch { }

                        produto.DESCRICAO_PRODUTO = dr["DESCRICAO_PRODUTO"].ToString();

                        try { produto.COD_GRUPO_PRODUTO = int.Parse(dr["COD_GRUPO_PRODUTO"].ToString()); }
                        catch { }

                        produto.DESCRICAO_GRUPO_PRODUTO = dr["DESCRICAO_GRUPO_PRODUTO"].ToString();

                        produto.COD_BARRAS_PRODUTO = dr["COD_BARRAS_PRODUTO"].ToString();

                        try { produto.QTDE_UNIDADE_PRODUTO = int.Parse(dr["QTDE_UNIDADE_PRODUTO"].ToString()); }
                        catch { }

                        produto.STATUS_PRODUTO = dr["STATUS_PRODUTO"].ToString();

                        produto.DESCRICAO_UNIDADE_PRODUTO = dr["DESCRICAO_UNIDADE_PRODUTO"].ToString();
                        //VALORES
                        //FIXO = V;CNPJ_FORNECEDOR;RAZAO_FORNECEDOR;COD_PRODUTO;DESCRICAO_PRODUTO;COD_GRUPO;
                        //DESCRICAO_GRUPO;COD_FAMILIA
                        //DESCRICAO_FAMILIA;COD_SUB_FAMILIA;DESCRICAO_SUBFAMILIA;FIXO = E;COD_EAN;
                        //TIPO_EMBALAGEM;FIXO = UN; VOLUME_EMBALAGEM * 1000; STATUS_PRODUTO;DATA_CADASTRO

                        texto.WriteLine("V" + ";" + produto.CNPJ_FORNECEDOR_PRODUTO + ";" + produto.NOME_FORNECEDOR_PRODUTO + ";" +
                        produto.COD_PRODUTO + ";" + produto.DESCRICAO_PRODUTO + ";" + produto.COD_GRUPO_PRODUTO + ";" +
                        produto.DESCRICAO_GRUPO_PRODUTO + ";" + "" + ";" + "" + ";" + "" + ";" + "" + ";" + "E" + ";" +
                        produto.COD_BARRAS_PRODUTO + ";" + "NI" + ";" + produto.QTDE_UNIDADE_PRODUTO * 1000 + ";" +
                        produto.STATUS_PRODUTO + ";" + "NI");
                    }
                    //ULTIMA LINHA
                    texto.WriteLine("E");

                }
            }
        }
        private void gerar_lojas()
        {
            DateTime data_documento = DateTime.Now;

            //NOME E CAMINHO DO ARQUIVOS
            string caminho = @"c:\\evolucao\\accera\arquivosTXT\ACC_CADSITE_" + retirar_caracteres(data_documento.ToString("yyyyMMdd")) + ".txt";
            string caminhoAnsi = @"c:\\evolucao\\accera\arquivosTXT\ACC_CADSITE_" + retirar_caracteres(data_documento.ToString("yyyyMMdd")) + "-ansi.txt";

            if (criar_arquivo(caminho))
            {
                FileInfo t = new FileInfo(caminho);
                using (StreamWriter texto = t.CreateText())
                {
                    //CABEÇALHO
                    //H;CNPJ_DISTRIBUIDOR;DATA_CRIACAO_ARQUIVO
                    texto.WriteLine("H" + ";" + cnpj_empresa + ";" + retirar_caracteres(data_documento.ToString("yyyyMMdd")));
                    //VALORES
                    //V;COD_LOJA;DESCRICAO_LOJA;UF_LOJA;CIDADE;BAIRRO;CEP;STATUS;
                    texto.WriteLine("V" + ";" + "1" + ";" + razao_social_empresa + ";" + estado_empresa + ";" +
                    cidade_empresa + ";" + bairro_empresa + ";" + cep_empresa + ";" + "1");
                    //ULTIMA LINHA
                    texto.WriteLine("E");

                }
            }
        }
        private void gerar_clientes()
        {
            DateTime data_documento = DateTime.Now;

            //NOME E CAMINHO DO ARQUIVOS
            string caminho = @"c:\\evolucao\\accera\arquivosTXT\ACC_PDVS_" + retirar_caracteres(data_documento.ToString("yyyyMMdd")) + ".txt";
            string caminhoAnsi = @"c:\\evolucao\\accera\arquivosTXT\ACC_PDVS_" + retirar_caracteres(data_documento.ToString("yyyyMMdd")) + "-ansi.txt";

            if (criar_arquivo(caminho))
            {
                FileInfo t = new FileInfo(caminho);
                using (StreamWriter texto = t.CreateText())
                {
                    //CABEÇALHO
                    //H;CNPJ_DISTRIBUIDOR;DATA_CRIACAO_ARQUIVO
                    texto.WriteLine("H" + ";" + cnpj_empresa + ";" + retirar_caracteres(data_documento.ToString("yyyyMMdd")));
                    //VALORES
                    //V;CNPJ;RAZAO;NOME_FANTASIA;PAIS;REGIAO;ESTADO;CIDADE;BAIRRO;ENDERECO;GRUPO/REDE;CLASSIFICAÇÃO_PDV;
                    //VENDEDOR;CEP;CONTATO-EMAIL;STATUS;
                    FbDataAdapter da = new FbDataAdapter(@"
                    SELECT cli.cnpj,cli.razao_social,cli.nome_fantasia,cli.pais,
                    cli.estado,cli.cidade,cli.bairro,cli.endereco,cli.vendedor_cliente,
                    cli.cep_cliente,cli.email,cli.atividade_cliente FROM CLIENTES CLI INNER JOIN nota_fiscal NF ON CLI.cnpj = NF.cnpj_cliente_forn
                    inner JOIN itens_nota i ON I.nf_item = NF.n_nf INNER JOIN produtos P ON P.cod_produto = I.cod_item
                    WHERE P.nome_fornecedor_produto LIKE '%ELEBAT%' group by cli.cnpj,cli.razao_social,cli.nome_fantasia,cli.pais,
                    cli.estado,cli.cidade,cli.bairro,cli.endereco,cli.vendedor_cliente,
                    cli.cep_cliente,cli.email,cli.atividade_cliente ", fbConnection1);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        ModeloCliente cliente = new ModeloCliente();
                        cliente.CNPJ = dr["CNPJ"].ToString();
                        cliente.RAZAO_SOCIAL = dr["RAZAO_SOCIAL"].ToString();
                        cliente.NOME_FANTASIA = dr["NOME_FANTASIA"].ToString();
                        cliente.PAIS = dr["PAIS"].ToString();
                        cliente.ESTADO = dr["ESTADO"].ToString();
                        cliente.CIDADE = dr["CIDADE"].ToString();
                        cliente.BAIRRO = dr["BAIRRO"].ToString();
                        cliente.ENDERECO = dr["ENDERECO"].ToString();
                        cliente.VENDEDOR_CLIENTE = dr["VENDEDOR_CLIENTE"].ToString();
                        cliente.CEP_CLIENTE = dr["CEP_CLIENTE"].ToString();
                        cliente.EMAIL = dr["EMAIL"].ToString();
                        try { cliente.ATIVO_CLIENTE = int.Parse(dr["ATIVO_CLIENTE"].ToString()); }
                        catch { }
                        //V;CNPJ;RAZAO;NOME_FANTASIA;PAIS;REGIAO;ESTADO;CIDADE;BAIRRO;ENDERECO;GRUPO/REDE;CLASSIFICAÇÃO_PDV;
                        //VENDEDOR;CEP;CONTATO-EMAIL;STATUS;
                        texto.WriteLine("V" + ";" + cliente.CNPJ + ";" + cliente.RAZAO_SOCIAL + ";" + cliente.NOME_FANTASIA + ";"
                        + cliente.PAIS + ";" + ";" + cliente.ESTADO + ";" + cliente.CIDADE + ";" + cliente.BAIRRO + ";"
                        + cliente.ENDERECO + ";" + ";" + ";" + cliente.VENDEDOR_CLIENTE + ";" + cliente.CEP_CLIENTE + ";"
                        + cliente.EMAIL + ";" + cliente.ATIVO_CLIENTE);
                    }

                    //ULTIMA LINHA
                    texto.WriteLine("E");

                }
            }
        }
        private void gerar_estoque()
        {
            DateTime data_documento = DateTime.Now;
            string caminho = @"c:\\evolucao\\accera\arquivosTXT\ACC_POSESTQ_" + retirar_caracteres(data_documento.ToString("yyyyMMdd")) + ".txt";
            string caminhoAnsi = @"c:\\evolucao\\accera\arquivosTXT\ACC_POSESTQ_" + retirar_caracteres(data_documento.ToString("yyyyMMdd")) + "-ansi.txt";

            if (criar_arquivo(caminho))
            {
                FileInfo t = new FileInfo(caminho);
                using (StreamWriter texto = t.CreateText())
                {
                    //CABEÇALHO
                    //H;CNPJ_DISTRIBUIDOR;DATA_INICIO;DATA_FINAL
                    texto.WriteLine("H" + ";" + cnpj_empresa + ";" + retirar_caracteres(dtInicio.Value.ToString("yyyyMMdd")) + ";" + retirar_caracteres(dtTermino.Value.ToString("yyyyMMdd")));
                    //VALORES
                    //V;CNPJ_DISTRIBUIDOR;CNPJ_FORNECEDOR;COD_EAN;LOTE;DATA_VALIDADE_LOTE;QUANTIDADE_EM_ESTOQUE;TIPO_ESTOQUE;DATA_POSICAO
                    DataTable dt = new DataTable();
                    FbDataAdapter da = new FbDataAdapter(@"SELECT p.cnpj_fornecedor_produto,p.cod_barras_produto,p.estoque_atual_produto,p.estoque_reservado_produto
                    FROM produtos P where p.ESTOQUE_RESERVADO_PRODUTO >= 0 and p.ESTOQUE_ATUAL_PRODUTO >= 0 and P.nome_fornecedor_produto LIKE '%ELEBAT%'", fbConnection1);
                    da.Fill(dt);
                    foreach (DataRow linha in dt.Rows)
                    {
                        ModeloProduto mod = new ModeloProduto();
                        mod.CNPJ_FORNECEDOR_PRODUTO = linha["CNPJ_FORNECEDOR_PRODUTO"].ToString();
                        mod.COD_BARRAS_PRODUTO = linha["COD_BARRAS_PRODUTO"].ToString();
                        try { mod.ESTOQUE_ATUAL_PRODUTO = int.Parse(linha["ESTOQUE_ATUAL_PRODUTO"].ToString()) * 1000; }
                        catch { }
                        try { mod.ESTOQUE_RESERVADO_PRODUTO = int.Parse(linha["ESTOQUE_RESERVADO_PRODUTO"].ToString()) * 1000; }
                        catch { }

                        //VALORES
                        //V;CNPJ_DISTRIBUIDOR;CNPJ_FORNECEDOR;COD_EAN;LOTE;DATA_VALIDADE_LOTE;QUANTIDADE_EM_ESTOQUE;TIPO_ESTOQUE;DATA_POSICAO

                        //TIPO DE ESTOQUE = 
                        //H = IN HOUSE = ESTOQUE FISICO
                        //T = EM TRANSITO
                        //C = ESTOQUE RESERVADO

                        //Linha para indicar o estoque atual
                        texto.WriteLine("V" + ";" + cnpj_empresa + ";" + mod.CNPJ_FORNECEDOR_PRODUTO + ";" + mod.COD_BARRAS_PRODUTO
                        + ";" + ";" + ";" + mod.ESTOQUE_ATUAL_PRODUTO + ";" + "H" + ";" + retirar_caracteres(data_documento.ToString("yyyyMMdd")));
                        //linha para indicar o estoque reservado
                        texto.WriteLine("V" + ";" + cnpj_empresa + ";" + mod.CNPJ_FORNECEDOR_PRODUTO + ";" + mod.COD_BARRAS_PRODUTO
                        + ";" + ";" + ";" + mod.ESTOQUE_RESERVADO_PRODUTO + ";" + "C" + ";" + retirar_caracteres(data_documento.ToString("yyyyMMdd")));
                    }
                    //ULTIMA LINHA
                    texto.WriteLine("E");
                }
            }
        }
        private void gerar_notas_entrada()
        {
            DateTime data_documento = DateTime.Now;

            //NOME E CAMINHO DO ARQUIVOS
            string caminho = @"c:\\evolucao\\accera\arquivosTXT\ACC_NFS_" + retirar_caracteres(data_documento.ToString("yyyyMMdd")) + ".txt";
            string caminhoAnsi = @"c:\\evolucao\\accera\arquivosTXT\ACC_NFS_" + retirar_caracteres(data_documento.ToString("yyyyMMdd")) + "-ansi.txt";

            if (criar_arquivo(caminho))
            {
                FileInfo t = new FileInfo(caminho);
                using (StreamWriter texto = t.CreateText())
                {
                    //CABEÇALHO
                    //H;CNPJ_DISTRIBUIDOR;DATA_INICIO;DATA_FINAL
                    texto.WriteLine("H" + ";" + cnpj_empresa + ";" + retirar_caracteres(dtInicio.Value.ToString("yyyyMMdd")) + ";" + retirar_caracteres(dtTermino.Value.ToString("yyyyMMdd")));
                    //VALORES
                    //V;CNPJ_FORNECEDOR;NUMERO_NF;AÇAO(R OU E);VALOR;QTD;DATA_ACAO;DATA_ENTRADA;
                    DataTable dt = new DataTable();
                    FbDataAdapter da = new FbDataAdapter(@"SELECT NF.cnpj_cliente_forn_ent,NF.n_nf_ent,NF.valor_nota_nf_ent,SUM(INE.qtde_item_ent),
                    NF.data_autorizacao_nf_ent,NF.data_emissao_nf_ent
                    FROM nota_fiscal_ent NF INNER JOIN ITENS_NOTA_ENT INE ON
                    NF.n_nf_ent = INE.nf_item_ent WHERE NF.n_nf_ent <> 9999990 and NF.data_emissao_nf_ent >= '" + data_documento.AddDays(-30).ToShortDateString().Replace("/", ".") + "' " +
                    @"GROUP BY NF.cnpj_cliente_forn_ent,NF.n_nf_ent,
                    NF.valor_nota_nf_ent,
                    NF.data_emissao_nf_ent,NF.data_autorizacao_nf_ent", fbConnection1);
                    da.Fill(dt);
                    foreach (DataRow linha in dt.Rows)
                    {
                        ModeloNotaEntrada nf = new ModeloNotaEntrada();
                        //V;CNPJ_FORNECEDOR;NUMERO_NF;AÇAO(R OU E);VALOR;QTD;DATA_ACAO;DATA_ENTRADA;
                        nf.CNPJ_CLIENTE_FORN_ENT = linha["cnpj_cliente_forn_ent"].ToString();
                        try { nf.N_NF_ENT = int.Parse(linha["N_NF_ENT"].ToString()); }
                        catch { }
                        try { nf.VALOR_NOTA_NF_ENT = double.Parse(linha["valor_nota_nf_ent"].ToString()); }
                        catch { }
                        try { nf.DATA_AUTORIZACAO_NF_ENT = DateTime.Parse(linha["data_emissao_nf_ent"].ToString()); }
                        catch { }
                        try { nf.DATA_EMISSAO_NF_ENT = DateTime.Parse(linha["data_emissao_nf_ent"].ToString()); }
                        catch { }

                        texto.WriteLine("V" + ";" + nf.CNPJ_CLIENTE_FORN_ENT + ";" + nf.N_NF_ENT + ";" + "E" + ";" + nf.VALOR_NOTA_NF_ENT +
                        linha["SUM"].ToString() + ";" + retirar_caracteres(nf.DATA_AUTORIZACAO_NF_ENT.ToShortDateString()) + ";" +
                        retirar_caracteres(nf.DATA_AUTORIZACAO_NF_ENT.ToShortDateString()));
                    }
                    //ULTIMA LINHA
                    texto.WriteLine("E");

                }
            }
        }
        private void gerar_vendas()
        {
            DateTime data_documento = DateTime.Now;

            //NOME E CAMINHO DO ARQUIVOS
            string caminho = @"c:\\evolucao\\accera\arquivosTXT\ACC_SELLOUT_" + retirar_caracteres(data_documento.ToString("yyyyMMdd")) + ".txt";
            string caminhoAnsi = @"c:\\evolucao\\accera\arquivosTXT\ACC_SELLOUT_" + retirar_caracteres(data_documento.ToString("yyyyMMdd")) + "-ansi.txt";

            if (criar_arquivo(caminho))
            {
                FileInfo t = new FileInfo(caminho);
                using (StreamWriter texto = t.CreateText())
                {
                    //CABEÇALHO
                    //H;CNPJ_DISTRIBUIDOR;DATA_INICIO;DATA_FINAL
                    texto.WriteLine("H" + ";" + cnpj_empresa + ";" + retirar_caracteres(dtInicio.Value.ToString("yyyyMMdd")) + ";" + retirar_caracteres(dtTermino.Value.ToString("yyyyMMdd")));

                    //VALORES
                    //V;CNPJ_DISTRIBUIDOR;CNPJ_FORNECEDOR;NUMERO;CODIGO_BARRAS;NUMERO_LOTE;VALIDADE_LOTE;QTD_PRODUTO;VALOR_FINAL;MOEDA(FIXO BRL);
                    //N_NF;DATA_TRANSAÇÃO;TIPO_TRANSAÇÃO(V = VENDA/DV = DEVOLUCAO/C = CANCELAMENTO/B = BONIFICAÇÃO);CFOP;TIPO_CLIENTE(1 = CPF; 2 = CNPJ);
                    //CNPJ OU CPF;RAZAO_SOCIAL_CLIENTE;CEP_CLEINTE;CLASSIFICACAO_CLIENTE(EM BRANCO);VENDEDOR(CODIGO - NOME);CAMPOLIVRE;CAMPOLIVRE2(OBSERVAÇÕES)
                    FbDataAdapter da = new FbDataAdapter(@" SELECT p.cnpj_fornecedor_produto,P.cod_barras_produto,INF.qtde_item,NF.valor_nota_nf,NF.n_nf,NF.data_emissao_nf,NF.status_nfe,nf.natureza_operacao_nf,inf.cfop_item,NF.cnpj_cl_nf,NF.razao_social_cl_nf,
                    CLI.cep_cliente,v.cod_vendedor,ped.vendedor_ped_venda,nf.inf_compl_nf FROM NOTA_FISCAL NF INNER JOIN itens_nota INF ON INF.nf_item = NF.n_nf INNER JOIN PRODUTOS P
                    ON INF.cod_item = P.cod_produto INNER JOIN clientes CLI ON CLI.cnpj = NF.cnpj_cl_nf inner join pedidos_nf pf on pf.nf_pedido_nf = inf.nf_item
                    inner join itens_pedido_venda pv on pv.cod_pedido_item_venda = pf.cod_pedido_nf inner join pedidos_venda ped on pv.cod_pedido_item_venda = ped.cod_ped_venda
                    inner join vendedores v on ped.vendedor_ped_venda = v.nome_vendedor
                    WHERE NF.data_emissao_nf >= '01.10.2016' group by p.cnpj_fornecedor_produto,P.cod_barras_produto,INF.qtde_item,NF.valor_nota_nf,NF.n_nf,NF.data_emissao_nf,
                    NF.status_nfe,nf.natureza_operacao_nf,inf.cfop_item,NF.cnpj_cl_nf,NF.razao_social_cl_nf,CLI.cep_cliente,v.cod_vendedor,ped.vendedor_ped_venda,nf.inf_compl_nf", fbConnection1);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    foreach (DataRow linha in dt.Rows) 
                    {
                        int qtd = 0;
                        int.TryParse(linha["qtde_item"].ToString(), out qtd);

                        texto.WriteLine("V" + ";" + cnpj_empresa + ";" + linha["cnpj_fornecedor_produto"].ToString() + ";" +
                        linha["cod_barras_produto"].ToString() + ";" + /*lote*/ ";" + /*Validade_lote*/ ";" + qtd * 1000 + ";" +
                        linha["valor_nota_nf"].ToString() + ";" + "BRL" + ";" + linha["n_nf"].ToString() + ";" +
                        acertar_data(DateTime.Parse(linha["data_emissao_nf"].ToString())) + ";" + str_tipo_nf(linha["status_nfe"].ToString(), linha["natureza_operacao_nf"].ToString()) + ";" +
                        linha["cfop_item"].ToString() + ";" + verificarTipoCliente(linha["cnpj_cl_nf"].ToString()) + ";" +
                        linha["cnpj_cl_nf"].ToString() + ";" + linha["razao_social_cl_nf"].ToString() + ";" + linha["cep_cliente"].ToString() + ";" + /*Classificação do PDV*/ ";" +
                        linha["cod_vendedor"].ToString() + "-" + linha["vendedor_ped_venda"].ToString() + ";" + acertar_tamanho(retirar_caracteres(linha["inf_compl_nf"].ToString()),255));
                    }

                    //ULTIMA LINHA
                    texto.WriteLine("E");
                }
            }
        }

        //verifica o tipo da nota fiscal (Venda, Devolução, Cancelada) e retorna um inteiro indicando
        private string str_tipo_nf(string status_nf, string natureza_operacao_nf)
        {
            try
            {
                if (status_nf.ToUpper().Contains("CANCELADA"))
                    return "C";
                if (natureza_operacao_nf.ToUpper().Contains("DEV"))
                {
                    return "DV";
                }
                else if (natureza_operacao_nf.ToUpper().Contains("BONI"))
                {
                    return "B";
                }
                else if (natureza_operacao_nf.ToUpper().Contains("VENDA"))
                {
                    return "V";
                }
                return "V";
            }
            catch
            {
                return "";
            }


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
            catch
            {
                return "";
            }
        }
        private string retirar_caracteres(string arquivo)
        {
            try
            {
                return arquivo.Replace("Ã", "A").Replace("Õ", "O").Replace("Ç", "C").Replace("Â", "A").Replace("Á", "A").Replace("À", "A")
                .Replace("Ô", "O").Replace("\r\n", " ").Replace("-", " ").Replace("(", "").Replace(")", "").Replace("/", " ")
                .Replace("&", "e").Replace("'", "").Replace(":", " ").Replace(" ", "").Replace(".", " ").Replace(",", "").Replace("-", " ").Replace("_", "");
            }
            catch
            {
                return "";
            }
        }
        private string verificarTipoCliente(string cnpj)
        {
            if (cnpj.Length <= 11) return "1";
            else return "2";
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
    }
}
