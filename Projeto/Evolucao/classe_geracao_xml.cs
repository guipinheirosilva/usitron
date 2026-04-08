using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using ICSharpCode.SharpZipLib.Zip;
using System.IO.Compression;
using ICSharpCode.SharpZipLib.Zip;
using OfficeOpenXml;

namespace Evolucao
{
    class classe_geracao_xml
    {
        
        public string caminho_pasta;
        public string caminho_pasta_entrada;
        public DateTime inicio;
        public DateTime fim;
        public string cnpj = "";
        public string email_destinatario;

        public string cnpj_empresa;
        FbConnection conexao = new FbConnection(@"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=10.3.3.4;" +
           "Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0");




        public void gerar_todas(out string caminho_excel_saidas)
        {
            caminho_excel_saidas = "";
            gerar_inutilizadas();
            gerar_autorizadas();
            gerar_canceladas();

            FbCommand select = new FbCommand();
            try
            {
                DataTable dtSelect = new DataTable();
                dtSelect.TableName = "saidas";
                string _cnpj = "";
                if (cnpj != "")
                    _cnpj = " AND REPLACE(REPLACE(REPLACE(nf.CNPJ_EMISSOR_NF, '.', ''), '/', ''), '-', '') = REPLACE(REPLACE(REPLACE(" + cnpj + ", '.', ''), '/', ''), '-', '')"; // CNPJ_EMISSOR_NF = '" + cnpj + "' ";
                select.CommandText =
                    @"SELECT nf.n_nf as NF, nf.data_emissao_nf AS EMISSAO,
nf.natureza_operacao_nf as NATUREZA, nf.cnpj_cliente_forn as CNPJ_CLIENTE,
nf.cliente_forn_nf AS RAZAO, nf.status_nfe as STATUS, nf.valor_nota_nf as VALOR_NF,
nf.valor_ipi_nf as IPI, nf.base_calc_icms_nf AS BASE_ICMS,
nf.valor_icms_nf AS VALOR_ICMS, nf.estado_cliente_nf as ESTADO , XML_AUTORIZADO_NF, CHAVE_ACESSO_NFE as CHAVE FROM NOTA_FISCAL nf
                        where nf.DATA_EMISSAO_NF >= '" + inicio.ToShortDateString().Replace("/", ".") + "' AND " +
                         @"nf.DATA_EMISSAO_NF <= '" + fim.ToShortDateString().Replace("/", ".") + "' " +
                         _cnpj +  " ORDER BY N_NF ";
                select.Connection = conexao;
                conexao.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;

                datSelect.Fill(dtSelect);
                conexao.Close();

                dtSelect.Columns.Remove("XML_AUTORIZADO_NF");
                dtSelect.WriteXml(@caminho_pasta + "notas_saida.xml");
                //caminho_excel_saidas = @caminho_pasta + "notas_saida.xml";


                string nomeArquivoXML = @caminho_pasta + "notas_saida.xml"; ;
                string nomeArquivoXLSX = @caminho_pasta + "notas_saida.xlsx";
                caminho_excel_saidas = @caminho_pasta + "notas_saida.xlsx";
                try
                {
                    // Carrega os dados do arquivo XML para um DataTable
                    DataSet dataSet = new DataSet();
                    dataSet.ReadXml(nomeArquivoXML);
                    DataTable dt = dataSet.Tables[0]; // Supondo que há apenas uma tabela no DataSet

                    // Cria um novo arquivo Excel
                    FileInfo newFile = new FileInfo(nomeArquivoXLSX);

                    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;


                    using (ExcelPackage excelPackage = new ExcelPackage(newFile))
                    {

                        // Adiciona uma planilha ao arquivo Excel
                        ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Planilha1");

                        // Preenche a planilha com os dados do DataTable
                        worksheet.Cells.LoadFromDataTable(dt, true);

                        // Salva o arquivo Excel
                        excelPackage.Save();
                    }

                    Console.WriteLine("Arquivo XLSX salvo com sucesso.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro: " + ex.Message);
                }

            }
            catch (Exception ex)
            {
                conexao.Close();
            }
        }

        public void gerar_entrada(out string caminho_excel_entradas)
        {
            caminho_excel_entradas = "";
            gerar_autorizadas_entrada(out caminho_excel_entradas);
        }

        private void detectar_dados_empresa(out string razao_social_empresa, out string nome_fantasia_empresa, out string cnpj_empresa, out string ie_empresa, out string im_empresa, out string cnae_empresa, out string endereco_empresa, out string n_endereco_empresa,
                    out string complemento_empresa, out string bairro_empresa, out string cidade_empresa, out string estado_empresa, out string cep_empresa, out string telefone_empresa, out string cod_cidade_empresa, out string pais_empresa,
                    out string cod_pais_empresa, out string licenca_dll_nfe_empresa, out string nome_certificado_nfe_empresa, out string assunto_nfe_email_empresa, out string smtp_nfe_empresa, out string email_nfe_empresa,
                    out string senha_email_nfe_empresa, out string logotipo_empresa, out string proxy_empresa, out string usuario_proxy_empresa, out string senha_proxy_empresa,
            out string crt_empresa, out string portaEmailEmpresa, out string sslEmpresa, out string serie_empresa, out string boleto_pedido_empresa, out string saida_estoque_pedido_empresa, out string cod_forn_empresa, out string cod_empresa)
        {
            razao_social_empresa = ""; nome_fantasia_empresa = ""; cnpj_empresa = ""; ie_empresa = ""; im_empresa = ""; cnae_empresa = ""; endereco_empresa = ""; n_endereco_empresa = "";
            complemento_empresa = ""; bairro_empresa = ""; cidade_empresa = ""; estado_empresa = ""; cep_empresa = ""; telefone_empresa = ""; cod_cidade_empresa = ""; pais_empresa = "";
            cod_pais_empresa = ""; licenca_dll_nfe_empresa = ""; nome_certificado_nfe_empresa = ""; assunto_nfe_email_empresa = ""; smtp_nfe_empresa = ""; email_nfe_empresa = "";
            senha_email_nfe_empresa = ""; logotipo_empresa = ""; proxy_empresa = ""; usuario_proxy_empresa = ""; senha_proxy_empresa = ""; crt_empresa = ""; portaEmailEmpresa = "";
            sslEmpresa = ""; serie_empresa = ""; boleto_pedido_empresa = ""; saida_estoque_pedido_empresa = ""; cod_forn_empresa = ""; cod_empresa = "";
            try
            {

                FbCommand comando = new FbCommand();
                comando.Connection = conexao;
                comando.CommandText = "SELECT * FROM EMPRESA where LICENCA_DLL_NFE_EMPRESA is not null";
                DataSet empresa = new DataSet();
                conexao.Open();
                FbDataAdapter datEmpresa = new FbDataAdapter();
                datEmpresa.SelectCommand = comando;
                datEmpresa.Fill(empresa);
                conexao.Close();
                foreach (DataRow dr in empresa.Tables[0].Rows)
                {
                    cod_empresa = dr["COD_EMPRESA"].ToString();
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

                    serie_empresa = dr["SERIE_NF_EMPRESA"].ToString();

                    try
                    {
                        boleto_pedido_empresa = dr["BOLETO_PEDIDO_EMPRESA"].ToString();
                    }
                    catch { }
                    try
                    {
                        saida_estoque_pedido_empresa = dr["SAIDA_ESTOQUE_PEDIDO_EMPRESA"].ToString();
                    }
                    catch { }
                    try
                    {
                        cod_forn_empresa = dr["COD_FORN_EMPRESA"].ToString();
                    }
                    catch { }
                    
                }

            }
            catch (Exception a)
            {
                conexao.Close();
            }
        }

        public void enviar_email(string arquivo, string inicio, string fim)
        {
            string cod_empresa = "", razao_social_empresa = "", nome_fantasia_empresa = "", /*cnpj_empresa = "",*/ ie_empresa = "", im_empresa = "", cnae_empresa = "", endereco_empresa = "", n_endereco_empresa = "",
          complemento_empresa = "", bairro_empresa = "", cidade_empresa = "", estado_empresa = "", cep_empresa = "", telefone_empresa = "", cod_cidade_empresa = "", pais_empresa = "",
          cod_pais_empresa = "", licenca_dll_nfe_empresa = "", nome_certificado_nfe_empresa = "", assunto_nfe_email_empresa = "", smtp_nfe_empresa = "", email_nfe_empresa = "",
          senha_email_nfe_empresa = "", logotipo_empresa = "", proxy_empresa = "", usuario_proxy_empresa = "", senha_proxy_empresa = "", crt_empresa = "", portaEmailEmpresa = "",
          sslEmpresa = "", serie_empresa = "", boleto_pedido_empresa = "", saida_estoque_pedido_empresa = "", cod_forn_empresa = "";

            detectar_dados_empresa(out razao_social_empresa, out nome_fantasia_empresa, out cnpj_empresa, out ie_empresa, out im_empresa, out cnae_empresa, out endereco_empresa, out n_endereco_empresa,
       out complemento_empresa, out bairro_empresa, out cidade_empresa, out estado_empresa, out cep_empresa, out telefone_empresa, out cod_cidade_empresa, out pais_empresa,
       out cod_pais_empresa, out licenca_dll_nfe_empresa, out nome_certificado_nfe_empresa, out assunto_nfe_email_empresa, out smtp_nfe_empresa, out email_nfe_empresa,
       out senha_email_nfe_empresa, out logotipo_empresa, out proxy_empresa, out usuario_proxy_empresa, out senha_proxy_empresa, out crt_empresa, out portaEmailEmpresa, out sslEmpresa,
out serie_empresa, out boleto_pedido_empresa, out saida_estoque_pedido_empresa, out cod_forn_empresa, out cod_empresa);


            string _caminho_arquivo = arquivo;


            //var assunto
            string _assunto = "NFs";
            
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
"<title>Prezado cliente,</title>" +
"</head>" +
"<body lang=PT-BR link=blue vlink=purple style='tab-interval:35.4pt' fontface = 'Arial'> " +
"<div class=Section1> " +
"<p class=MsoPlainText><span style='font-family:'Comic Sans MS''>Prezado,<o:p></o:p></span></p> " +
"<p class=MsoPlainText><span style='font-family:'Comic Sans MS''><o:p>&nbsp;</o:p></span></p>" +
"<p class=MsoPlainText><span style='font-family:'Comic Sans MS''>Segue anexo a NFs de Entrada e Saída referentes ao período: " + inicio + " até " + fim + "  <o:p></o:p></span></p>" +
"<p class=MsoPlainText><span style='font-family:'Comic Sans MS''>_________________________<br>" +
"Setor de Faturamento<br>" +
"</div>" +
"</body>" +
"</html>";
            Email novo_email = new Email();
            bool _erro;
            //var smtp, email, senha_email
            novo_email.EnviarEmail("vendas@crprodutos.com.br", _assunto, _mensagem, _caminho_arquivo, "", "",
            email_nfe_empresa, senha_email_nfe_empresa, smtp_nfe_empresa, out _erro, "");

            if (_erro == false)
            {
                form_erro msg = new form_erro();
                msg.erro = "Email enviado com sucesso. ";
                msg.ShowDialog();
            }
            else
            {
                form_erro msg = new form_erro();
                msg.erro = "Email não enviado. Favor verificar dados. ";
                msg.ShowDialog();
            }
        }
        public void ZiparPastas(string caminho)
        {
            try
            {
                string zipPath = Path.Combine(caminho, "ZIP", "nfs.zip");

                if (!Directory.Exists(Path.Combine(caminho, "ZIP")))
                {
                    Directory.CreateDirectory(Path.Combine(caminho, "ZIP"));
                }

                if (File.Exists(zipPath))
                {
                    File.Delete(zipPath); // Exclui o zip caso já exista
                }

                using (FileStream fsOut = File.Create(zipPath))
                using (ZipOutputStream zipStream = new ZipOutputStream(fsOut))
                {
                    zipStream.SetLevel(9); // Nível máximo de compactação
                    Console.WriteLine("Iniciando o processo de criação do ZIP...");
                    AdicionarPastaAoZip(caminho, zipStream, ""); // Passa apenas a pasta raiz com caminho relativo vazio
                }

                Console.WriteLine("Arquivo ZIP criado com sucesso com estrutura de pastas.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao criar o arquivo ZIP: " + ex.Message);
            }
        }


        //public void ZiparPastas(string caminho)
        //{
        //    try
        //    {
        //        string caminhoPasta = @caminho;
        //        string caminhoZip = @"c:\\evolucao\\zip";
        //        string zipPath = Path.Combine(caminhoZip, "ZIP", "nfs.zip");

        //        if (!Directory.Exists(Path.Combine(caminhoZip, "ZIP")))
        //        {
        //            Directory.CreateDirectory(Path.Combine(caminhoZip, "ZIP"));
        //        }

        //        if (File.Exists(zipPath))
        //        {
        //            File.Delete(zipPath); // Exclui o zip caso já exista
        //        }

        //        using (FileStream fsOut = File.Create(zipPath))
        //        using (ZipOutputStream zipStream = new ZipOutputStream(fsOut))
        //        {
        //            zipStream.SetLevel(9); // Nível máximo de compactação
        //            AdicionarPastaAoZip(caminhoPasta, zipStream, zipPath);
        //        } // `fsOut` e `zipStream` serão fechados automaticamente ao sair do bloco `using`
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Erro ao zipping: " + ex.Message);
        //    }
        //}
        //public void ZiparPastas(string caminho)
        //{
        //    try
        //    {
        //        string caminhoPasta = @caminho;
        //        string zipPath = caminhoPasta + "\\ZIP\\nfs.zip";

        //        if (!Directory.Exists(caminhoPasta + "\\ZIP\\"))
        //        {
        //            Directory.CreateDirectory(caminhoPasta + "\\ZIP\\");
        //        }

        //        if (File.Exists(zipPath))
        //        {
        //            File.Delete(zipPath);
        //        }

        //        using (FileStream fsOut = File.Create(zipPath))
        //        {
        //            using (ZipOutputStream zipStream = new ZipOutputStream(fsOut))
        //            {
        //                try
        //                {
        //                    zipStream.SetLevel(9); // Nível máximo de compactação

        //                    AdicionarPastaAoZip(caminhoPasta, zipStream, "");
        //                }
        //                catch (Exception ex)
        //                {
        //                }
        //            }
        //        }
        //    }
        //    catch(Exception ex)
        //    { }
        //}

        private void AdicionarPastaAoZip(string pastaAtual, ZipOutputStream zipStream, string caminhoRelativo)
        {
            try
            {
                // Obtem todos os arquivos na pasta atual
                string[] arquivos = Directory.GetFiles(pastaAtual);

                foreach (string arquivo in arquivos)
                {
                    using (FileStream fs = File.OpenRead(arquivo))
                    {
                        byte[] buffer = new byte[fs.Length];
                        fs.Read(buffer, 0, buffer.Length);

                        // Cria o caminho relativo da entrada no ZIP, mantendo a estrutura de pastas
                        string caminhoEntradaZip = Path.Combine(caminhoRelativo, Path.GetFileName(arquivo)).Replace("\\", "/");
                        ZipEntry entry = new ZipEntry(caminhoEntradaZip);

                        Console.WriteLine($"Adicionando arquivo ao ZIP: {caminhoEntradaZip}"); // Log para verificar o arquivo sendo adicionado
                        zipStream.PutNextEntry(entry);

                        zipStream.Write(buffer, 0, buffer.Length);
                        zipStream.CloseEntry();
                    }
                }

                // Processa as subpastas recursivamente
                string[] subPastas = Directory.GetDirectories(pastaAtual);
                foreach (string subPasta in subPastas)
                {
                    string subPastaRelativa = Path.Combine(caminhoRelativo, Path.GetFileName(subPasta)).Replace("\\", "/");
                    Console.WriteLine($"Processando subpasta: {subPastaRelativa}"); // Log para verificar a subpasta
                    AdicionarPastaAoZip(subPasta, zipStream, subPastaRelativa);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao adicionar ao zip: " + ex.Message);
            }
        }

        //private void AdicionarPastaAoZip(string pastaAtual, ZipOutputStream zipStream, string caminhoZip)
        //{
        //    try
        //    {
        //        string[] arquivos = Directory.GetFiles(pastaAtual);

        //        foreach (string arquivo in arquivos)
        //        {
        //            using (FileStream fs = File.OpenRead(arquivo))
        //            {
        //                byte[] buffer = new byte[fs.Length];
        //                fs.Read(buffer, 0, buffer.Length);
        //                ZipEntry entry = new ZipEntry(Path.GetFileName(arquivo)); // Ajustado para incluir apenas o nome do arquivo
        //                zipStream.PutNextEntry(entry);
        //                zipStream.Write(buffer, 0, buffer.Length);
        //                zipStream.CloseEntry(); // Certifique-se de fechar cada entrada no zip
        //            }
        //        }

        //        string[] subPastas = Directory.GetDirectories(pastaAtual);
        //        foreach (string subPasta in subPastas)
        //        {
        //            AdicionarPastaAoZip(subPasta, zipStream, Path.Combine(caminhoZip, Path.GetFileName(subPasta)));
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Erro ao adicionar ao zip: " + ex.Message);
        //    }
        //}
        //private void AdicionarPastaAoZip(string pastaAtual, ZipOutputStream zipStream, string caminhoZip)
        //{
        //    try
        //    {
        //        string[] arquivos = Directory.GetFiles(pastaAtual + "");

        //        foreach (string arquivo in arquivos)
        //        {
        //            using (FileStream fs = File.OpenRead(arquivo))
        //            {
        //                byte[] buffer = new byte[fs.Length];
        //                fs.Read(buffer, 0, buffer.Length);
        //                ZipEntry entry = new ZipEntry(Path.Combine(caminhoZip, Path.GetFileName(arquivo)));
        //                zipStream.PutNextEntry(entry);
        //                zipStream.Write(buffer, 0, buffer.Length);
        //            }
        //        }

        //        string[] subPastas = Directory.GetDirectories(pastaAtual);
        //        foreach (string subPasta in subPastas)
        //        {
        //            AdicionarPastaAoZip(subPasta, zipStream, Path.Combine(caminhoZip, Path.GetFileName(subPasta)));
        //        }
        //    }
        //    catch(Exception ex)
        //    { }
        //}
        public void gerar_autorizadas()
        {
            FbCommand select = new FbCommand();
            try
            {
                DataTable dtSelect = new DataTable();
                dtSelect.TableName = "saidas";
                string _cnpj = "";
                if (cnpj != "")
                    _cnpj = " AND REPLACE(REPLACE(REPLACE(nf.CNPJ_EMISSOR_NF, '.', ''), '/', ''), '-', '') = REPLACE(REPLACE(REPLACE(" + cnpj + ", '.', ''), '/', ''), '-', '')"; // CNPJ_EMISSOR_NF = '" + cnpj + "' ";
                select.CommandText =
                    @"SELECT nf.n_nf as NF, nf.data_emissao_nf AS EMISSAO,
nf.natureza_operacao_nf as NATUREZA, nf.cnpj_cliente_forn as CNPJ_CLIENTE,
nf.cliente_forn_nf AS RAZAO, nf.status_nfe as STATUS, nf.valor_nota_nf as VALOR_NF,
nf.valor_ipi_nf as IPI, nf.base_calc_icms_nf AS BASE_ICMS,
nf.valor_icms_nf AS VALOR_ICMS, nf.estado_cliente_nf as ESTADO , XML_AUTORIZADO_NF, CHAVE_ACESSO_NFE as CHAVE FROM NOTA_FISCAL nf
                        where nf.DATA_EMISSAO_NF >= '" + inicio.ToShortDateString().Replace("/", ".") + "' AND " +
                         @"nf.DATA_EMISSAO_NF <= '" + fim.ToShortDateString().Replace("/", ".") + "' AND " +
                         @"nf.STATUS_NFE like '%Autorizada%' " + _cnpj;
                select.Connection = conexao;
                conexao.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                
                datSelect.Fill(dtSelect);
                conexao.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                     if (!Directory.Exists(@caminho_pasta + "\\AUTORIZADAS\\"))
                    {
                        Directory.CreateDirectory(@caminho_pasta + "\\AUTORIZADAS\\");
                    }
                    FileInfo t = new FileInfo(@caminho_pasta + "\\AUTORIZADAS\\NFE" + dr["CHAVE"].ToString() + ".xml");
                    using (StreamWriter texto = t.CreateText())
                    {
                        texto.WriteLine(dr["XML_AUTORIZADO_NF"].ToString());
                    }
                }
                //dtSelect.Columns.Remove("XML_AUTORIZADO_NF");
                //dtSelect.WriteXml(@caminho_pasta + "notas_saida.xml");


            }
            catch (Exception a)
            {
                conexao.Close();
            }

            /* FileInfo t = new FileInfo("c:\\evolucao\\NFE\\autorizadas\\" + "NFE" + tb_chave_acesso_nfe.Text + ".xml");
            using (StreamWriter texto = t.CreateText())
            {
                texto.WriteLine(xml_autorizado);
            }*/
        }

        public void gerar_autorizadas_entrada(out string caminho_excel_entradas)
        {
            caminho_excel_entradas = "";
            FbCommand select = new FbCommand();
            
            try
            {
                DataTable dtSelect = new DataTable();
                dtSelect.TableName = "entradas";

                string _cnpj = "";
                if (cnpj != "")
                    _cnpj = " AND REPLACE(REPLACE(REPLACE(nf.CNPJ_DESTINATARIO_NF_ENT, '.', ''), '/', ''), '-', '') = REPLACE(REPLACE(REPLACE(" + cnpj + ", '.', ''), '/', ''), '-', '')"; // " AND nf.CNPJ_DESTINATARIO_NF_ENT = '" + cnpj + "' ";
                select.CommandText =
                    @"SELECT nf.n_nf_ent as NF, nf.data_emissao_nf_ent AS EMISSAO,
nf.natureza_operacao_nf_ent as NATUREZA, nf.cnpj_cliente_forn_ent as CNPJ_CLIENTE,
nf.cliente_forn_nf_ent AS RAZAO, nf.status_nf_ent as STATUS, nf.valor_nota_nf_ent as VALOR_NF,
nf.valor_ipi_nf_ent as IPI, nf.base_calc_icms_nf_ent AS BASE_ICMS,
nf.valor_icms_nf_ent AS VALOR_ICMS, nf.estado_cliente_nf_ent as ESTADO, nf.XML_AUTORIZADO_NF_ENT, nf.CHAVE_ACESSO_NF_ENT as CHAVE FROM NOTA_FISCAL_ENT nf
                        where nf.DATA_EMISSAO_NF_ENT >= '" + inicio.ToShortDateString().Replace("/", ".") + "' AND " +
                         @"nf.DATA_EMISSAO_NF_ENT <= '" + fim.ToShortDateString().Replace("/", ".") + "' AND nf.BAIXADA_NF_ENT = 1 " + _cnpj;
                select.Connection = conexao;
                conexao.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                
                datSelect.Fill(dtSelect);
                conexao.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    if (!Directory.Exists(@caminho_pasta_entrada + "\\AUTORIZADAS\\"))
                    {
                        Directory.CreateDirectory(@caminho_pasta_entrada + "\\AUTORIZADAS\\");
                    }
                    FileInfo t = new FileInfo(@caminho_pasta_entrada + "\\AUTORIZADAS\\NFE" + dr["CHAVE"].ToString() + ".xml");
                    using (StreamWriter texto = t.CreateText())
                    {
                        texto.WriteLine(dr["XML_AUTORIZADO_NF_ENT"].ToString());
                    }
                }


                // dtEstoque.TableName = "ESTOQUE";
                dtSelect.Columns.Remove("XML_AUTORIZADO_NF_ENT");
                dtSelect.WriteXml(@caminho_pasta_entrada + "notas_entrada.xml");
                
                string nomeArquivoXML = @caminho_pasta_entrada + "notas_entrada.xml"; ;
                string nomeArquivoXLSX = @caminho_pasta_entrada + "notas_entrada.xlsx";
                caminho_excel_entradas = @caminho_pasta_entrada + "notas_entrada.xlsx";
                try
                {
                    // Carrega os dados do arquivo XML para um DataTable
                    DataSet dataSet = new DataSet();
                    dataSet.ReadXml(nomeArquivoXML);
                    DataTable dt = dataSet.Tables[0]; // Supondo que há apenas uma tabela no DataSet

                    // Cria um novo arquivo Excel
                    FileInfo newFile = new FileInfo(nomeArquivoXLSX);

                    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                   
                    using (ExcelPackage excelPackage = new ExcelPackage(newFile))
                    {
                        
                        // Adiciona uma planilha ao arquivo Excel
                        ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Planilha1");

                        // Preenche a planilha com os dados do DataTable
                        worksheet.Cells.LoadFromDataTable(dt, true);

                        // Salva o arquivo Excel
                        excelPackage.Save();
                    }

                    Console.WriteLine("Arquivo XLSX salvo com sucesso.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro: " + ex.Message);
                }
            
                //System.Diagnostics.Process.Start("excel", @"c:\\evolucao\\" + tb_descricao_pesquisa.Text + ".xml");


            }
            catch (Exception a)
            {
                conexao.Close();
            }

            /* FileInfo t = new FileInfo("c:\\evolucao\\NFE\\autorizadas\\" + "NFE" + tb_chave_acesso_nfe.Text + ".xml");
            using (StreamWriter texto = t.CreateText())
            {
                texto.WriteLine(xml_autorizado);
            }*/
        }
        public void gerar_autorizada_unica(string chave)
        {
            FbCommand select = new FbCommand();
            try
            {

                select.CommandText =
                    @"SELECT XML_AUTORIZADO_NF, CHAVE_ACESSO_NFE FROM NOTA_FISCAL nf
                        where chave_acesso_nfe = '" + chave + "' AND " +
                         @"nf.STATUS_NFE like '%Autorizada%'";
                select.Connection = conexao;
                conexao.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                conexao.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    if (!Directory.Exists(@caminho_pasta + "\\AUTORIZADAS\\"))
                    {
                        Directory.CreateDirectory(@caminho_pasta + "\\AUTORIZADAS\\");
                    }
                    FileInfo t = new FileInfo(@caminho_pasta + "\\AUTORIZADAS\\NFE" + dr["CHAVE_ACESSO_NFE"].ToString() + ".xml");
                    using (StreamWriter texto = t.CreateText())
                    {
                        texto.WriteLine(dr["XML_AUTORIZADO_NF"].ToString());
                    }
                }


            }
            catch (Exception a)
            {
                conexao.Close();
            }

            /* FileInfo t = new FileInfo("c:\\evolucao\\NFE\\autorizadas\\" + "NFE" + tb_chave_acesso_nfe.Text + ".xml");
            using (StreamWriter texto = t.CreateText())
            {
                texto.WriteLine(xml_autorizado);
            }*/
        }
        public void gerar_canceladas()
        {
            FbCommand select = new FbCommand();
            try
            {
                string _cnpj = "";
                if (cnpj != "")
                    _cnpj = " AND REPLACE(REPLACE(REPLACE(nf.CNPJ_EMISSOR_NF, '.', ''), '/', ''), '-', '') = REPLACE(REPLACE(REPLACE(" + cnpj + ", '.', ''), '/', ''), '-', '')"; // CNPJ_EMISSOR_NF = '" + cnpj + "' ";

                select.CommandText =
                    @"SELECT XML_CANCELADO_NF, CHAVE_ACESSO_NFE FROM NOTA_FISCAL nf
                        where nf.DATA_EMISSAO_NF >= '" + inicio.ToShortDateString().Replace("/", ".") + "' AND " +
                         @"nf.DATA_EMISSAO_NF <= '" + fim.ToShortDateString().Replace("/", ".") + "' AND " +
                         @"nf.STATUS_NFE like '%Cancelada%' " + _cnpj;
                select.Connection = conexao;
                conexao.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                conexao.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    if (!Directory.Exists(@caminho_pasta + "\\CANCELADAS\\"))
                    {
                        Directory.CreateDirectory(@caminho_pasta + "\\CANCELADAS\\");
                    }
                    FileInfo t = new FileInfo(@caminho_pasta + "\\CANCELADAS\\NFE" + dr["CHAVE_ACESSO_NFE"].ToString() + ".xml");
                    using (StreamWriter texto = t.CreateText())
                    {
                        texto.WriteLine(dr["XML_CANCELADO_NF"].ToString());
                    }
                }


            }
            catch (Exception a)
            {
                conexao.Close();
            }

        }
        public void gerar_canceladas_unica(string chave)
        {
            FbCommand select = new FbCommand();
            try
            {
                select.CommandText =
                    @"SELECT XML_CANCELADO_NF, CHAVE_ACESSO_NFE FROM NOTA_FISCAL nf
                        where chave_acesso_nfe = '" + chave + "'  AND " +
                         @"nf.STATUS_NFE like '%Cancelada%'";
                select.Connection = conexao;
                conexao.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                conexao.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    if (!Directory.Exists(@caminho_pasta + "\\CANCELADAS\\"))
                    {
                        Directory.CreateDirectory(@caminho_pasta + "\\CANCELADAS\\");
                    }
                    FileInfo t = new FileInfo(@caminho_pasta + "\\CANCELADAS\\NFE" + dr["CHAVE_ACESSO_NFE"].ToString() + ".xml");
                    using (StreamWriter texto = t.CreateText())
                    {
                        texto.WriteLine(dr["XML_CANCELADO_NF"].ToString());
                    }
                }


            }
            catch (Exception a)
            {
                conexao.Close();
            }

        }
        public void gerar_inutilizadas()
        {
             FbCommand select = new FbCommand();
            try
            {
                //CNPJ_EMPRESA_NF_INUTILIZADA
                string _cnpj = "";
                if (cnpj != "")
                    _cnpj = " AND CNPJ_EMPRESA_NF_INUTILIZADA = '" + cnpj + "' ";
                select.CommandText =
                    @"SELECT XML_NF_INUTILIZADA, N_INICIO_NF_INUTILIZADA, N_FIM_NF_INUTILIZADA FROM NFS_INUTILIZADAS nf
                        where nf.DATA_NF_INUTILIZADA >= '" + inicio.ToShortDateString().Replace("/", ".") + "' AND " +
                         @"nf.DATA_NF_INUTILIZADA <= '" + fim.ToShortDateString().Replace("/", ".") + "' " + _cnpj;
                select.Connection = conexao;
                conexao.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                conexao.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    if (!Directory.Exists(@caminho_pasta + "\\INUTILIZADAS\\"))
                    {
                        Directory.CreateDirectory(@caminho_pasta + "\\INUTILIZADAS\\");
                    }
                    FileInfo t = new FileInfo(@caminho_pasta + "\\INUTILIZADAS\\NF" + dr["N_INICIO_NF_INUTILIZADA"].ToString() + "_" + dr["N_FIM_NF_INUTILIZADA"].ToString() + ".xml");
                    using (StreamWriter texto = t.CreateText())
                    {
                        texto.WriteLine(dr["XML_NF_INUTILIZADA"].ToString());
                    }
                }


            }
            catch (Exception a)
            {
                conexao.Close();
            }
        }

    }


}
