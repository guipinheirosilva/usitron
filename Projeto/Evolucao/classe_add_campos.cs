using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evolucao
{
    class classe_add_campos
    {
        FbConnection conexao = new FbConnection(@"User=SYSDBA;Password=masterkey;Database=C:\evolucao\evolucao.fdb;DataSource=localhost;" +
            "Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0");


        public void adicionar_campos()
        {
            try
            {
                int erros = 0;
                int n_campos = 10; //MAXIMO DE CAMPOS ALTERADOS EM UMA UNICA TABELA
                int n_tabelas = 28; // NUMERO DE TABELAS ALTERADAS
                int n_tabelas_criadas = 9;
                int n_campo_tabelas_criadas = 4;
                string[,] campos = new string[n_tabelas, n_campos];

                string[] tabelas = new string[28] {"PEDIDOS_VENDA", "ROMANEIO", "NOTA_FISCAL_ENT",
                    "PRODUTOS", "EMPRESA", "CLIENTES", "VENDEDORES", "NFCE", "FORMA_PGTO",
                    "CONTAS_A_RECEBER", "LOTE_RECEB_WEB", "CTE", "PROMOCAO", "ITENS_PROMOCAO",
                    "DESCARTE_PEDIDO_VENDA", "REMESSA_CNAB400", "ITENS_PEDIDO_COMPRA", "CONTAS_CORRENTES", 
                    "ITENS_PEDIDO_VENDA", "ITENS_NOTA", "NOTA_FISCAL", "NFS_INUTILIZADAS", "FAMILIA_PRODUTO",  
                    "ITENS_NOTA_ENT", "CONTAS_A_PAGAR", "MOTIVO_NAO_VENDA", "ITENS_ROMANEIO", "PEDIDO_COMPRA"};

                string[,] criar_tabelas = new string[n_tabelas_criadas, n_campo_tabelas_criadas]; //GENERATOR, TABLE, ALTER TABLE, TRIGGER
                //TABELA PEDIDOS_VENDA = 0
                //campos[0, 0] = "ADD    QTDE_TOTAL_PED_VENDA               DOUBLE PRECISION";
                //campos[0, 1] = "ADD    DATA_MOD_PED_VENDA            DATE";
                //campos[0, 2] = "ADD    LATITUDE_PED_VENDA       DOUBLE PRECISION";7
                //campos[0, 3] = "ADD    LONGITUDE_PED_VENDA                  DOUBLE PRECISION";
                //campos[0, 4] = "ADD    COD_TP_PED_VENDA                INTEGER";
                //campos[0, 5] = "ADD    DESCRICAO_TP_PED_VENDA           VARCHAR(100)";
                //campos[0, 6] = "ADD    BOLETO_VD_PED_VENDA                INTEGER";
                //campos[0, 7] = "ADD    NF_VD_PED_VENDA                    INTEGER";
                //campos[0, 8] = "ADD    COD_WEB_PED_VENDA                  INTEGER";
                //campos[0, 9] = "ADD    HORA_PED_VENDA                     TIME";


                //TABELA ROMANEIOS = 1
                //campos[1, 0] = "ADD    VENDEDOR_ROMANEIO               VARCHAR(100)";
                //campos[1, 1] = "ADD    DESCRICAO_ROTEIRO_ROMANEIO      VARCHAR(100)";
                //campos[1, 2] = "ADD    VALOR_ROMANEIO                  DOUBLE PRECISION";
                //campos[1, 3] = "ADD    FECHADO_ROMANEIO                INTEGER";

                ////TABELA NOTA_FISCAL_ENT = 2
                campos[2, 0] = "ADD    XML_AUTORIZADO_NF_ENT             BLOB SUB_TYPE 1 SEGMENT SIZE 16384";
                //campos[2, 1] = "ADD    NOME_VENDEDOR_NF_ENT            VARCHAR(100)";
                //campos[2, 2] = "ADD    CNPJ_DESTINATARIO_NF_ENT        VARCHAR(14)";
                //campos[2, 3] = "ADD    RAZAO_DESTINATARIO_NF_ENT       VARCHAR(100)";

                ////TABELA ITENS_NOTA = 19
                campos[19, 0] = "ADD CST_IBSCBS_ITEM VARCHAR(100)";
                campos[19, 1] = "ADD CCLASSTRIB_ITEM VARCHAR(100)";
                campos[19, 2] = "ADD ALIQ_IBS_ITEM DOUBLE PRECISION";
                campos[19, 3] = "ADD ALIQ_CBS_ITEM DOUBLE PRECISION";
                campos[19, 4] = "ADD VALOR_IBS_ITEM DOUBLE PRECISION";
                campos[19, 5] = "ADD VALOR_CBS_ITEM DOUBLE PRECISION";
                campos[19, 6] = "ADD BC_IBSCBS_ITEM DOUBLE PRECISION";


                ////TABELA PRODUTOS = 3

                campos[3, 0] = "ADD    COD_ANP_PRODUTO     VARCHAR(100)";
                campos[3, 1] = "ADD    CODIF_PRODUTO     VARCHAR(100)";
                campos[3, 2] = "ADD    CST_IBSCBS_PRODUTO     VARCHAR(100)";
                campos[3, 3] = "ADD    CCLASSTRIB_PRODUTO     VARCHAR(100)";
                campos[3, 4] = "ADD    ALIQ_IBS_PRODUTO      DOUBLE PRECISION";
                campos[3, 5] = "ADD    ALIQ_CBS_PRODUTO      DOUBLE PRECISION";


                ////TABELA EMPRESA = 4
                campos[4, 0] = "ADD CST_IBSCBS_EMPRESA VARCHAR(100)";
                campos[4, 1] = "ADD CCLASSTRIB_EMPRESA VARCHAR(100)";
                campos[4, 2] = "ADD ALIQ_IBS_EMPRESA DOUBLE PRECISION";
                campos[4, 3] = "ADD ALIQ_CBS_EMPRESA DOUBLE PRECISION";



                ////TABELA PRODUTOS = 3

                //campos[3, 1] = "ADD    ESTOQUE1_PRODUTO     DOUBLE PRECISION";
                //campos[3, 2] = "ADD    ESTOQUE2_PRODUTO     DOUBLE PRECISION";
               
                //campos[3, 3] = "ADD    KIT_PROMOCIONAL_PRODUTO       INTEGER";
                //campos[3, 4] = "ADD    ALIQUOTA_PIS_PRODUTO          DOUBLE PRECISION";
                //campos[3, 5] = "ADD    ALIQUOTA_COFINS_PRODUTO       DOUBLE PRECISION";
                //campos[3, 6] = "ADD    estoque_terceiros_produto     DOUBLE PRECISION";
                //campos[3, 7] = "ADD    COD_ALTERNATIVO_PRODUTO     VARCHAR(100)";
                //campos[3, 8] = "ADD    OBS_PRODUTO     VARCHAR(5000)";

                ////KIT_PROMOCIONAL_PRODUTO

                ////TABELA EMPRESA = 4
                //campos[4, 0] = "ADD    MERCADORIA_CTE_EMPRESA           VARCHAR(100)";
                //campos[4, 1] = "ADD    CTE_OS_EMPRESA                   INTEGER";
                //campos[4, 2] = "ADD    CAIXA_PEDIDO_EMPRESA             INTEGER";
                //campos[4, 3] = "ADD    SAIDA_ESTOQUE_PEDIDO_EMPRESA     INTEGER";
                //campos[4, 4] = "ADD    CAMINHO_ATUALIZACAO_EMPRESA      VARCHAR(300)";

                //TABELA CLIENTES = 5
               // campos[5, 0] = "ADD    COD_ROTEIRO_CLIENTE            INTEGER";
                //campos[5, 1] = "ADD    LONGITUDE_CLIENTE            DOUBLE PRECISION";
                //campos[5, 2] = "ADD    COD_MATRIZ_CLIENTE            INTEGER";
                //campos[5, 3] = "ADD    RAZAO_MATRIZ_CLIENTE           VARCHAR(200)";
                //campos[5, 4] = "ADD    TRAVAR_LOCAL_CLIENTE            INTEGER";
                //campos[5, 5] = "ADD    BLOQUEAR_TROCA_CLIENTE            INTEGER";
                //campos[5, 2] = "ADD    DESCONTO_INSTRUCAO_CLIENTE            INTEGER";
                //campos[5, 3] = "ADD    DESCONTO_VALOR_NOTA_CLIENTE           INTEGER";
                //campos[5, 4] = "ADD    DUPLICATAS_VENCIDAS_CLIENTE           VARCHAR(1000)";
                //campos[5, 5] = "ADD    CLASSIFICACAO_CLIENTE           VARCHAR(200)";

                ////TABELA VENDEDORES = 6
                campos[6, 0] = "ADD    ROTEIRO_VENDEDOR            INTEGER";
                //campos[6, 1] = "ADD    CPF_VENDEDOR            VARCHAR(100)";
                //campos[6, 2] = "ADD    RG_VENDEDOR            VARCHAR(100)";
                //campos[6, 3] = "ADD    APELIDO_VENDEDOR            VARCHAR(100)";
                //campos[6, 4] = "ADD    ESTADO_VENDEDOR            VARCHAR(10)";
                //campos[6, 5] = "ADD    EMAIL_VENDEDOR            VARCHAR(100)";

                ////TABELA NFCE = 7
                //campos[7, 0] = "ADD COD_CAIXA_NFCE INTEGER";
                //campos[7, 1] = "ADD FATURAMENTO_NFCE INTEGER";

                ////TABELA FORMA_PGTO = 8
                //campos[8, 0] = "ADD PRAZO_7_FORMA_PGTO INTEGER";
                //campos[8, 1] = "ADD PRAZO_8_FORMA_PGTO INTEGER";
                //campos[8, 2] = "ADD PRAZO_9_FORMA_PGTO INTEGER";
                //campos[8, 3] = "ADD PRAZO_10_FORMA_PGTO INTEGER";
                //campos[8, 4] = "ADD PRAZO_11_FORMA_PGTO INTEGER";
                //campos[8, 5] = "ADD PRAZO_12_FORMA_PGTO INTEGER";

                ////TABELA CONTAS_A_RECEBER = 9
                //campos[9, 0] = "ADD TIPO_CR VARCHAR(100)";
                //campos[9, 1] = "ADD SERIE_CR INTEGER";
                //campos[9, 2] = "ADD FORMA_PGTO_CR VARCHAR(100)";
                //campos[9, 3] = "ADD COD_WEB_CR INTEGER";
                //campos[9, 4] = "ADD RESPONSAVEL_BAIXA_CR INTEGER";
                //campos[9, 5] = "ADD DATA_BAIXA_CR DATE";

                ////CAMPO TABELA LOTE_RECEB_WEB = 10
                //campos[10, 0] = "ADD ESTOQUE_CONFERIDO_LRW INTEGER";

                //TABELA CTE = 11
                //campos[11, 0] = "ADD REDESPACHO_CTE INTEGER";


                ////TABELA DESCARTE_PEDIDO_VENDA = 14
                //campos[14, 0] = "ADD COD_PRODUTO_DVP INTEGER";
                //campos[14, 1] = "ADD DESCRICAO_PRODUTO_DPV VARCHAR(200)";
                //campos[14, 2] = "ADD PEDIDO_DPV INTEGER";
                //campos[14, 3] = "ADD MOTIVO_CORTE_DPV VARCHAR(200)";
                //campos[14, 4] = "ADD DATA_CORTE_DPV DATE";
                //campos[14, 5] = "ADD VALOR_TOTAL_DPV DOUBLE PRECISION";

                ////TABELA REMESSA_CNAB400 = 15
                //campos[15, 0] = "ADD N_REMESSA INTEGER";

                ////TABELA ITENS_PEDIDO_COMPRA = 16
                //campos[16, 0] = "ADD COD_BARRAS_ITEM_PED VARCHAR(100)";

                ////TABELA CONTAS_CORRENTES = 17
                //campos[17, 0] = "ADD COD_TRANSMISSAO VARCHAR(100)";
                //campos[17, 1] = "ADD NAO_APARECER_CC INTEGER";

                ////TABELA ITENS_PEDIDO_VENDA = 18
                //campos[18, 0] = "ADD OPERACAO_ITEM_VENDA INTEGER";
                //campos[18, 1] = "ADD NCM_ITEM_VENDA INTEGER";

                ///*   campos[2, 4] = "ADD VBCSTRET_ITEM_ENT DOUBLE PRECISION";
                //campos[2, 5] = "ADD PST_ITEM_ENT DOUBLE PRECISION";
                //campos[2, 6] = "ADD VICMSSUBSTITUTO_ITEM_ENT DOUBLE PRECISION";
                //campos[2, 7] = "ADD VICMSSTRET_ITEM_ENT DOUBLE PRECISION";
                // */

                ////TABELA ITENS_NOTA = 19
                //campos[19, 0] = "ADD CEST_ITEM VARCHAR(10)";
                //campos[19, 1] = "ADD VBCSTRET_ITEM DOUBLE PRECISION";
                //campos[19, 2] = "ADD PST_ITEM DOUBLE PRECISION";
                //campos[19, 3] = "ADD VICMSSUBSTITUTO_ITEM DOUBLE PRECISION";
                //campos[19, 4] = "ADD VICMSSTRET_ITEM DOUBLE PRECISION";

                ////TABELA nota_fiscal = 20
                //campos[20, 0] = "ADD DESCONTO_NF DOUBLE PRECISION";

                ////TABELA nfs_inutilizadas = 21
                //campos[21, 0] = "ADD XML_NF_INUTILIZADA BLOB SUB_TYPE 1 SEGMENT SIZE 16384";

                ////TABELA FAMILIA_PRODUTO = 22
                //campos[22, 0] = "ADD CNPJ_FORNECEDOR_FP VARCHAR(30)";
                //campos[22, 1] = "ADD RAZAO_FORNECEDOR_FP VARCHAR(100)";

                //TABELA ITENS_NOTA-ENT = 23
                //campos[23, 0] = "ADD USUARIO_ITEM_ENT INTEGER";
                //campos[23, 1] = "ADD QTDE_DEV_ITEM_ENT DOUBLE PRECISION";
                //campos[23, 1] = "ADD PST_ITEM_ENT DOUBLE PRECISION";
                //campos[23, 2] = "ADD VICMSSUBSTITUTO_ITEM_ENT DOUBLE PRECISION";
                //campos[23, 3] = "ADD VICMSSTRET_ITEM_ENT DOUBLE PRECISION";

                //TABELA ITENS_ROMANRIO = 26
                //campos[26, 0] = "ADD CHAVE_ACESSO_IR VARCHAR(44)";
                // campos[23, 1] = "ADD QTDE_DEV_ITEM_ENT DOUBLE PRECISION";
                //campos[23, 1] = "ADD PST_ITEM_ENT DOUBLE PRECISION";
                //campos[23, 2] = "ADD VICMSSUBSTITUTO_ITEM_ENT DOUBLE PRECISION";
                //campos[23, 3] = "ADD VICMSSTRET_ITEM_ENT DOUBLE PRECISION";

                //TABELA CONTAS_A_pagar = 24
                //campos[9, 0] = "ADD OPERACAO_CP INTEGER";

                //TABELA MOTIVO_NAO_VENDA = 25
                //campos[25, 0] = "ADD COD_WEB_MNV INTEGER";
                //campos[25, 1] = "ADD LATITUDE_MNV DOUBLE PRECISION";
                //campos[25, 2] = "ADD LONGITUDE_MNV DOUBLE PRECISION";
                
                //TABELA ITENS_ROMANRIO = 26
                //campos[26, 0] = "ADD CHAVE_ACESSO_IR VARCHAR(44)";

                //TABELA PEDIDO_COMPRA = 27
                //campos[27, 0] = "ADD OPERACAO_PED INTEGER";
                //campos[27, 1] = "ADD QTDE_TOTAL_PED DOUBLE PRECISION";
                //campos[27, 2] = "ADD PLANO_PED DOUBLE PRECISION";

                //TABELA lote_receb_web
                //                criar_tabelas[0, 0] =
                //                    @"
                //CREATE GENERATOR GEN_LOTE_RECEB_WEB_ID;";
                //                criar_tabelas[0, 1] = @"
                //CREATE TABLE LOTE_RECEB_WEB (
                //    COD_LRW              INTEGER NOT NULL,
                //    DATA_LRW             DATE,
                //    HORA_LRW             TIME,
                //    COD_WEB_INICIAL_LRW  INTEGER,
                //    COD_WEB_FINAL_LRW    INTEGER,
                //    NUMERO_PEDIDOS_LRW   INTEGER,
                //    ESTOQUE_CONFERIDO_LRW INTEGER
                //);
                //";
                //                criar_tabelas[0, 2] = @"
                //ALTER TABLE LOTE_RECEB_WEB ADD CONSTRAINT PK_LOTE_RECEB_WEB PRIMARY KEY (COD_LRW);";
                //                criar_tabelas[0, 3] =
                //                    @"
                //CREATE TRIGGER LOTE_RECEB_WEB_BI FOR LOTE_RECEB_WEB
                //ACTIVE BEFORE INSERT POSITION 0
                //AS
                //BEGIN
                //  IF (NEW.COD_LRW IS NULL) THEN
                //    NEW.COD_LRW = GEN_ID(GEN_LOTE_RECEB_WEB_ID,1);
                //END";

                criar_tabelas[1, 0] = @"
CREATE GENERATOR GEN_DOC_DESTINADOS_ID;";
                criar_tabelas[1, 1] = @"
CREATE TABLE DOC_DESTINADOS (
    COD_DD                     INTEGER NOT NULL,
    NSU_DD                     INTEGER NOT NULL,
    TIPO_DD                    VARCHAR(100),
    CHAVE_DD                   VARCHAR(44),
    PROTOCOLO_DD               VARCHAR(100),
    REMETENTE_DD               VARCHAR(200),
    CNPJ_REMETENTE_DD          VARCHAR(14),
    IE_REMETENTE_DD            VARCHAR(15),
    SITUACAO_DD                INTEGER,
    DATA_DD                    DATE,
    VALOR_DD                   DOUBLE PRECISION,
    XML_DD                     BLOB SUB_TYPE 1 SEGMENT SIZE 16384,
    PROTOCOLO_MANIFESTACAO_DD  VARCHAR(100),
    STATUS_DD                  VARCHAR(100)
);
";
                criar_tabelas[1, 2] = @"
ALTER TABLE DOC_DESTINADOS ADD PRIMARY KEY (NSU_DD);
";
                criar_tabelas[1, 3] = @"
CREATE TRIGGER DOC_DESTINADOS_BI FOR DOC_DESTINADOS
ACTIVE BEFORE INSERT POSITION 0
AS
BEGIN
  IF (NEW.COD_DD IS NULL) THEN
    NEW.COD_DD = GEN_ID(GEN_DOC_DESTINADOS_ID,1);
END
";

//                criar_tabelas[2, 0] = @"
//CREATE GENERATOR GEN_PAGAMENTOS_ID;
//";
//                criar_tabelas[2, 1] = @"
//CREATE TABLE PAGAMENTOS (
//    COD_PGTO         INTEGER NOT NULL,
//    COD_PEDIDO_PGTO  INTEGER,
//    COD_CAIXA_PGTO   INTEGER,
//    FORMA_PGTO       VARCHAR(100),
//    VALOR_PGTO       DOUBLE PRECISION,
//    HORA_PGTO        TIME,
//    TIPO_PGTO            VARCHAR(100),
//    COD_FORMA_PGTO_PGTO  INTEGER,
//    DATA_PGTO            DATE,
//    N_CHEQUE_PGTO        VARCHAR(100),
//    NOME_CHEQUE_PGTO     VARCHAR(200),
//    CPF_CHEQUE_PGTO      VARCHAR(100)
//);
//";
//                criar_tabelas[2, 2] = @"
//ALTER TABLE PAGAMENTOS ADD CONSTRAINT PK_PAGAMENTOS PRIMARY KEY (COD_PGTO);
//";
//                criar_tabelas[2, 3] = @"
//CREATE TRIGGER PAGAMENTOS_BI FOR PAGAMENTOS
//ACTIVE BEFORE INSERT POSITION 0
//as
//begin
//  if (new.cod_pgto is null) then
//    new.cod_pgto = gen_id(gen_pagamentos_id,1);
//end
//";
//                criar_tabelas[3, 0] = @"
//CREATE GENERATOR GEN_SAIDA_CAIXA_ID;
//";
//                criar_tabelas[3, 1] = @"
//CREATE TABLE SAIDA_CAIXA (
//    COD_SAIDA_CAIXA             INTEGER NOT NULL,
//    COD_CAIXA_SAIDA_CAIXA       INTEGER,
//    USUARIO_SAIDA_CAIXA         VARCHAR(100),
//    DESCRICAO_SAIDA_CAIXA       VARCHAR(100),
//    VALOR_SAIDA_CAIXA           DOUBLE PRECISION,
//    HORA_SAIDA_CAIXA            TIME,
//    COD_FORNECEDOR_SAIDA_CAIXA  INTEGER,
//    FORNECEDOR_SAIDA_CAIXA      VARCHAR(300),
//    PLANO_SAIDA_CAIXA           VARCHAR(50),
//    COD_PLANO_SAIDA_CAIXA       INTEGER
//);
//";
//                criar_tabelas[3, 2] = @"
//ALTER TABLE SAIDA_CAIXA ADD CONSTRAINT PK_SAIDA_CAIXA PRIMARY KEY (COD_SAIDA_CAIXA);
//";
//                criar_tabelas[3, 3] = @"
//CREATE TRIGGER SAIDA_CAIXA_BI FOR SAIDA_CAIXA
//ACTIVE BEFORE INSERT POSITION 0
//as
//begin
//  if (new.cod_saida_caixa is null) then
//    new.cod_saida_caixa = gen_id(gen_saida_caixa_id,1);
//end
//";

//                criar_tabelas[4, 0] = @"
//CREATE GENERATOR GEN_ENTRADA_CAIXA_ID;
//";
//                criar_tabelas[4, 1] = @"
//CREATE TABLE ENTRADA_CAIXA (
//    COD_ENTRADA_CAIXA           INTEGER NOT NULL,
//    COD_CAIXA_ENTRADA_CAIXA     INTEGER,
//    DESCRICAO_ENTRADA_CAIXA     VARCHAR(100),
//    VALOR_ENTRADA_CAIXA         DOUBLE PRECISION,
//    COD_CLIENTE_ENTRADA_CAIXA   INTEGER,
//    NOME_CLIENTE_ENTRADA_CAIXA  VARCHAR(300),
//    CNPJ_CLIENTE_ENTRADA_CAIXA  VARCHAR(50),
//    COD_PEDIDO_ENTRADA_CAIXA    INTEGER
//);
//";
//                criar_tabelas[4, 2] = @"
//ALTER TABLE ENTRADA_CAIXA ADD CONSTRAINT PK_ENTRADA_CAIXA PRIMARY KEY (COD_ENTRADA_CAIXA);
//";
//                criar_tabelas[4, 3] = @"
//CREATE TRIGGER ENTRADA_CAIXA_BI FOR ENTRADA_CAIXA
//ACTIVE BEFORE INSERT POSITION 0
//as
//begin
//  if (new.cod_entrada_caixa is null) then
//    new.cod_entrada_caixa = gen_id(gen_entrada_caixa_id,1);
//end
//";

//                criar_tabelas[5, 0] = @"
//CREATE GENERATOR GEN_PROMOCAO_ID;
//";
//                criar_tabelas[5, 1] = @"
//CREATE TABLE PROMOCAO (
//    COD_PROMOCAO          INTEGER NOT NULL,
//    NOME_PROMOCAO         VARCHAR(200),
//    DATA_INICIO_PROMOCAO  DATE,
//    DATA_FIM_PROMOCAO     DATE
//);
//";
//                criar_tabelas[5, 2] = @"
//ALTER TABLE PROMOCAO ADD CONSTRAINT PK_PROMOCAO PRIMARY KEY (COD_PROMOCAO);
//";
//                criar_tabelas[5, 3] = @"
//CREATE TRIGGER PROMOCAO_BI FOR PROMOCAO
//ACTIVE BEFORE INSERT POSITION 0
//AS
//BEGIN
//  IF (NEW.COD_PROMOCAO IS NULL) THEN
//    NEW.COD_PROMOCAO = GEN_ID(GEN_PROMOCAO_ID,1);
//END
//";

//                criar_tabelas[6, 0] = @"
//CREATE GENERATOR GEN_ITENS_PROMOCAO_ID;
//";
//                criar_tabelas[6, 1] = @"
//CREATE TABLE ITENS_PROMOCAO (
//    COD_IPRO                INTEGER NOT NULL,
//    COD_PROMOCAO_IPRO       INTEGER,
//    COD_PRODUTO_IPRO        INTEGER,
//    DESCRICAO_PRODUTO_IPRO  VARCHAR(200),
//    QTDE_MINIMA_IPRO        DOUBLE PRECISION,
//    VALOR_UNITARIO_IPRO     DOUBLE PRECISION
//);
//";
//                criar_tabelas[6, 2] = @"
//ALTER TABLE ITENS_PROMOCAO ADD CONSTRAINT PK_ITENS_PROMOCAO PRIMARY KEY (COD_IPRO);
//";
//                criar_tabelas[6, 3] = @"
//CREATE TRIGGER ITENS_PROMOCAO_BI FOR ITENS_PROMOCAO
//ACTIVE BEFORE INSERT POSITION 0
//AS
//BEGIN
//  IF (NEW.COD_IPRO IS NULL) THEN
//    NEW.COD_IPRO = GEN_ID(GEN_ITENS_PROMOCAO_ID,1);
//END
//";
////PRODUTOS KIT
//                criar_tabelas[7, 0] = @"
//CREATE GENERATOR GEN_PRODUTOS_KIT_ID;
//";
//                criar_tabelas[7, 1] = @"
//CREATE TABLE PRODUTOS_KIT (
//    COD_PK          INTEGER NOT NULL,
//    COD_PRODUTO_PK  INTEGER,
//    DESCRICAO_PK    VARCHAR(100),
//    QTDE_PK         DOUBLE PRECISION,
//    VALOR_UNIT_PK   DOUBLE PRECISION,
//    COD_KIT_PK      INTEGER
//);
//";
//                criar_tabelas[7, 2] = @"
//ALTER TABLE PRODUTOS_KIT ADD CONSTRAINT PK_PRODUTOS_KIT PRIMARY KEY (COD_PK);
//";
//                criar_tabelas[7, 3] = @"
//CREATE TRIGGER PRODUTOS_KIT_BI FOR PRODUTOS_KIT
//ACTIVE BEFORE INSERT POSITION 0
//AS
//BEGIN
//  IF (NEW.COD_PK IS NULL) THEN
//    NEW.COD_PK = GEN_ID(GEN_PRODUTOS_KIT_ID,1);
//END
//";

//                //PESQUISAS
//                criar_tabelas[8, 0] =  "";
//                criar_tabelas[7, 1] = @"
//CREATE TABLE PESQUISAS (
//    COD_PESQUISA        INTEGER NOT NULL,
//    DESCRICAO_PESQUISA  VARCHAR(100),
//    STRING_PESQUISA     VARCHAR(2000)
//);
//";
//                criar_tabelas[7, 2] = @"
//ALTER TABLE PESQUISAS ADD CONSTRAINT PK_PESQUISAS PRIMARY KEY (COD_PESQUISA);
//";
//                criar_tabelas[7, 3] =  "";




                //ADD TABELAS

                for (int i = 0; i < n_tabelas_criadas; i++)
                {
                    try
                    {
                        for (int j = 0; j < n_campo_tabelas_criadas; j++)
                        {
                            try
                            {
                                FbCommand alter = new FbCommand();
                                alter.CommandText =
                                 criar_tabelas[i, j];
                                alter.Connection = conexao;
                                conexao.Open();
                                alter.ExecuteNonQuery();
                                conexao.Close();
                            }
                            catch
                            {
                                conexao.Close();
                                erros++;
                            }
                        }
                    }
                    catch { }

                }
                try
                {
                    FbCommand alter = new FbCommand();
                    alter.CommandText = "alter table produtos alter column qtde_unidade_produto type double precision";
                    alter.Connection = conexao;
                    conexao.Open();
                    alter.ExecuteNonQuery();
                    conexao.Close();
                }
                catch
                {
                    conexao.Close();
                }
                //ADD CAMPOS
                for (int i = 0; i < n_tabelas; i++)
                {
                    if (i == 23)
                    {

                    }
                    for (int j = 0; j < n_campos; j++)
                    {
                        try
                        {
                            FbCommand alter = new FbCommand();
                            alter.CommandText =
                           "ALTER TABLE " + tabelas[i] + " " +
                           campos[i, j];
                            alter.Connection = conexao;
                            conexao.Open();
                            alter.ExecuteNonQuery();
                            conexao.Close();

                            //if (i == 10)
                            //{
                            //    FbCommand alter1 = new FbCommand();
                            //    alter1.CommandText =
                            //  "UPDATE LOTE_RECEB_WEB SET ESTOQUE_CONFERIDO_LRW = 1";
                            //    alter1.Connection = conexao;
                            //    conexao.Open();
                            //    alter1.ExecuteNonQuery();
                            //    conexao.Close();
                            //}

                        }
                        catch
                        {
                            conexao.Close();
                            erros++;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
