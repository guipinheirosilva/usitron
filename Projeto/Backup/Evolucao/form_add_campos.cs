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
    public partial class form_add_campos : Form
    {
        public form_add_campos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FbConnection conexao = new FbConnection();
            conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=\evolucao_dokinos\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
            FbCommand comando_alter = new FbCommand();
            int erros = 0;
            try
            {
                comando_alter.CommandText =
                    "ALTER TABLE ITENS_NOTA " +
                    "ADD    VALOR_BC_ICMS_ST_ITEM    DOUBLE PRECISION";
                comando_alter.Connection = conexao;
                conexao.Open();
                comando_alter.ExecuteNonQuery();
                conexao.Close();
            }
            catch
            {
                conexao.Close();
                erros++;
            }
            try
            {
                comando_alter.CommandText =
                    "ALTER TABLE ITENS_NOTA " +
                    "ADD	    VALOR_ICMS_ST_ITEM       DOUBLE PRECISION";
                comando_alter.Connection = conexao;
                conexao.Open();
                comando_alter.ExecuteNonQuery();
                conexao.Close();
            }
            catch
            {
                conexao.Close();
                erros++;
            }
            try
            {
                comando_alter.CommandText =
                    "ALTER TABLE ITENS_NOTA " +
                    "ADD	    VALOR_FRETE_ITEM         DOUBLE PRECISION";
                comando_alter.Connection = conexao;
                conexao.Open();
                comando_alter.ExecuteNonQuery();
                conexao.Close();
            }
            catch
            {
                conexao.Close();
                erros++;
            }
            try
            {
                comando_alter.CommandText =
                    "ALTER TABLE ITENS_NOTA " +
                    "ADD	    VALOR_DESCONTO_ITEM      DOUBLE PRECISION";
                comando_alter.Connection = conexao;
                conexao.Open();
                comando_alter.ExecuteNonQuery();
                conexao.Close();
            }
            catch
            {
                conexao.Close();
                erros++;
            }
            try
            {
                comando_alter.CommandText =
                    "ALTER TABLE ITENS_NOTA " +
                    "ADD	    VALOR_SEGURO_ITEM        DOUBLE PRECISION";
                comando_alter.Connection = conexao;
                conexao.Open();
                comando_alter.ExecuteNonQuery();
                conexao.Close();
            }
            catch
            {
                conexao.Close();
                erros++;
            }
            try
            {
                comando_alter.CommandText =
                    "ALTER TABLE ITENS_NOTA " +
                    "ADD	    VALOR_OUTRAS_DESP_ITEM   DOUBLE PRECISION";
                comando_alter.Connection = conexao;
                conexao.Open();
                comando_alter.ExecuteNonQuery();
                conexao.Close();
            }
            catch
            {
                conexao.Close();
                erros++;
            }
            try
            {
                comando_alter.CommandText =
                    "ALTER TABLE ITENS_NOTA " +
                    "ADD	    IVA_ITEM                 DOUBLE PRECISION";
                comando_alter.Connection = conexao;
                conexao.Open();
                comando_alter.ExecuteNonQuery();
                conexao.Close();
            }
            catch
            {
                conexao.Close();
                erros++;
            }
            try
            {
                comando_alter.CommandText =
                    "ALTER TABLE ITENS_NOTA " +
                    "ADD	    REDUCAO_ITEM             DOUBLE PRECISION";
                comando_alter.Connection = conexao;
                conexao.Open();
                comando_alter.ExecuteNonQuery();
                conexao.Close();
            }
            catch
            {
                conexao.Close();
                erros++;
            }
            try
            {
                comando_alter.CommandText =
                    "ALTER TABLE ITENS_NOTA " +
                    "ADD	    COFINS_ITEM              DOUBLE PRECISION";
                comando_alter.Connection = conexao;
                conexao.Open();
                comando_alter.ExecuteNonQuery();
                conexao.Close();
            }
            catch
            {
                conexao.Close();
                erros++;
            }
            try
            {
                comando_alter.CommandText =
                    "ALTER TABLE ITENS_NOTA " +
                    "ADD	    VALOR_COFINS_ITEM        DOUBLE PRECISION";
                comando_alter.Connection = conexao;
                conexao.Open();
                comando_alter.ExecuteNonQuery();
                conexao.Close();
            }
            catch
            {
                conexao.Close();
                erros++;
            }
            try
            {
                comando_alter.CommandText =
                    "ALTER TABLE ITENS_NOTA " +
                    "ADD	    PIS_ITEM                 DOUBLE PRECISION";
                comando_alter.Connection = conexao;
                conexao.Open();
                comando_alter.ExecuteNonQuery();
                conexao.Close();
            }
            catch
            {
                conexao.Close();
                erros++;
            }
            try
            {
                comando_alter.CommandText =
                    "ALTER TABLE ITENS_NOTA " +
                    "ADD	    VALOR_PIS_ITEM                 DOUBLE PRECISION";
                comando_alter.Connection = conexao;
                conexao.Open();
                comando_alter.ExecuteNonQuery();
                conexao.Close();
            }
            catch
            {
                conexao.Close();
                erros++;
            }
            try
            {
                comando_alter.CommandText =
                    "ALTER TABLE ITENS_NOTA " +
                    "ADD	    ORIGEM_ITEM              VARCHAR(1)";
                comando_alter.Connection = conexao;
                conexao.Open();
                comando_alter.ExecuteNonQuery();
                conexao.Close();
            }
            catch
            {
                conexao.Close();
                erros++;
            }
            try
            {
                comando_alter.CommandText =
                    "ALTER TABLE ITENS_NOTA " +
                    "ADD	    MOD_BC_ITEM              VARCHAR(100)";
                comando_alter.Connection = conexao;
                conexao.Open();
                comando_alter.ExecuteNonQuery();
                conexao.Close();
            }
            catch
            {
                conexao.Close();
                erros++;
            }
            try
            {
                comando_alter.CommandText =
                    "ALTER TABLE ITENS_NOTA " +
                    "ADD	    ISS_ITEM                 DOUBLE PRECISION";
                comando_alter.Connection = conexao;
                conexao.Open();
                comando_alter.ExecuteNonQuery();
                conexao.Close();
            }
            catch
            {
                conexao.Close();
                erros++;
            }
            try
            {
                comando_alter.CommandText =
                    "ALTER TABLE ITENS_NOTA " +
                    "ADD	    MOD_BC_ST_ITEM           VARCHAR(100)";
                comando_alter.Connection = conexao;
                conexao.Open();
                comando_alter.ExecuteNonQuery();
                conexao.Close();
            }
            catch
            {
                conexao.Close();
                erros++;
            }
            try
            {
                comando_alter.CommandText =
                    "ALTER TABLE ITENS_NOTA " +
                    "ADD	    REDUCAO_ST_ITEM          DOUBLE PRECISION";
                comando_alter.Connection = conexao;
                conexao.Open();
                comando_alter.ExecuteNonQuery();
                conexao.Close();
            }
            catch
            {
                conexao.Close();
                erros++;
            }
            try
            {
                comando_alter.CommandText =
                    "ALTER TABLE ITENS_NOTA " +
                    "ADD	    ICMS_ST_ITEM             DOUBLE PRECISION";
                comando_alter.Connection = conexao;
                conexao.Open();
                comando_alter.ExecuteNonQuery();
                conexao.Close();
            }
            catch
            {
                conexao.Close();
                erros++;
            }
            try
            {
                comando_alter.CommandText =
                    "ALTER TABLE ITENS_NOTA " +
                    "ADD	    ALIQUOTA_CREDITO_ITEM    DOUBLE PRECISION";
                comando_alter.Connection = conexao;
                conexao.Open();
                comando_alter.ExecuteNonQuery();
                conexao.Close();
            }
            catch
            {
                conexao.Close();
                erros++;
            }
            try
            {
                comando_alter.CommandText =
                    "ALTER TABLE ITENS_NOTA " +
                    "ADD	    VALOR_CREDITO_ITEM       DOUBLE PRECISION";
                comando_alter.Connection = conexao;
                conexao.Open();
                comando_alter.ExecuteNonQuery();
                conexao.Close();
            }
            catch
            {
                conexao.Close();
                erros++;
            }
            try
            {
                comando_alter.CommandText =
                    "ALTER TABLE ITENS_NOTA " +
                    "ADD	    IPI_TRIB_ITEM            INTEGER";
                comando_alter.Connection = conexao;
                conexao.Open();
                comando_alter.ExecuteNonQuery();
                conexao.Close();
            }
            catch
            {
                conexao.Close();
                erros++;
            }
            try
            {
                comando_alter.CommandText =
                    "ALTER TABLE ITENS_NOTA " +
                    "ADD	    IPI_N_TRIB_ITEM          INTEGER";
                comando_alter.Connection = conexao;
                conexao.Open();
                comando_alter.ExecuteNonQuery();
                conexao.Close();
            }
            catch
            {
                conexao.Close();
                erros++;
            }
            try
            {
                comando_alter.CommandText =
                    "ALTER TABLE ITENS_NOTA " +
                    "ADD	    CST_IPI_TRIB_ITEM        VARCHAR(100)";
                comando_alter.Connection = conexao;
                conexao.Open();
                comando_alter.ExecuteNonQuery();
                conexao.Close();
            }
            catch
            {
                conexao.Close();
                erros++;
            }
            try
            {
                comando_alter.CommandText =
                    "ALTER TABLE ITENS_NOTA " +
                    "ADD	    CST_IPI_N_TRIB_ITEM        VARCHAR(100)";
                comando_alter.Connection = conexao;
                conexao.Open();
                comando_alter.ExecuteNonQuery();
                conexao.Close();
            }
            catch
            {
                conexao.Close();
                erros++;
            }
            try
            {
                comando_alter.CommandText =
                    "ALTER TABLE ITENS_NOTA " +
                    "ADD	    TIPO_PIS_ITEM            VARCHAR(100)";
                comando_alter.Connection = conexao;
                conexao.Open();
                comando_alter.ExecuteNonQuery();
                conexao.Close();
            }
            catch
            {
                conexao.Close();
                erros++;
            }
            try
            {
                comando_alter.CommandText =
                    "ALTER TABLE ITENS_NOTA " +
                    "ADD	    CST_PIS_ITEM             VARCHAR(200)";
                comando_alter.Connection = conexao;
                conexao.Open();
                comando_alter.ExecuteNonQuery();
                conexao.Close();
            }
            catch
            {
                conexao.Close();
                erros++;
            }
            try
            {
                comando_alter.CommandText =
                    "ALTER TABLE ITENS_NOTA " +
                    "ADD	    TIPO_COFINS_ITEM         VARCHAR(100)";
                comando_alter.Connection = conexao;
                conexao.Open();
                comando_alter.ExecuteNonQuery();
                conexao.Close();
            }
            catch
            {
                conexao.Close();
                erros++;
            }
            try
            {
                comando_alter.CommandText =
                    "ALTER TABLE ITENS_NOTA " +
                    "ADD	    CST_COFINS_ITEM          VARCHAR(200)";
                comando_alter.Connection = conexao;
                conexao.Open();
                comando_alter.ExecuteNonQuery();
                conexao.Close();
            }
            catch
            {
                conexao.Close();
                erros++;
            }
            try
            {
                comando_alter.CommandText =
                    "ALTER TABLE ITENS_NOTA " +
                    "ADD	    TIPO_SERVICO_ITEM        VARCHAR(100)";
                comando_alter.Connection = conexao;
                conexao.Open();
                comando_alter.ExecuteNonQuery();
                conexao.Close();
            }
            catch
            {
                conexao.Close();
                erros++;
            }
            try
            {
                comando_alter.CommandText =
                    "ALTER TABLE ITENS_NOTA " +
                    "ADD	    ITEM_PEDIDO_COMPRA_ITEM  VARCHAR(100)";
                comando_alter.Connection = conexao;
                conexao.Open();
                comando_alter.ExecuteNonQuery();
                conexao.Close();
            }
            catch
            {
                conexao.Close();
                erros++;
            }
            try
            {
                comando_alter.CommandText =
                    "ALTER TABLE ITENS_NOTA " +
                    "ADD	    BC_IPI_ITEM              DOUBLE PRECISION";
                comando_alter.Connection = conexao;
                conexao.Open();
                comando_alter.ExecuteNonQuery();
                conexao.Close();
            }
            catch
            {
                conexao.Close();
                erros++;
            }
            try
            {
                comando_alter.CommandText =
                    "ALTER TABLE ITENS_NOTA " +
                    "ADD	    BC_PIS_ITEM              DOUBLE PRECISION";
                comando_alter.Connection = conexao;
                conexao.Open();
                comando_alter.ExecuteNonQuery();
                conexao.Close();
            }
            catch
            {
                conexao.Close();
                erros++;
            }
            try
            {
                comando_alter.CommandText =
                    "ALTER TABLE ITENS_NOTA " +
                    "ADD	    BC_COFINS_ITEM           DOUBLE PRECISION";
                comando_alter.Connection = conexao;
                conexao.Open();
                comando_alter.ExecuteNonQuery();
                conexao.Close();
            }
            catch
            {
                conexao.Close();
                erros++;
            }
            try
            {
                comando_alter.CommandText =
                    "ALTER TABLE ITENS_NOTA " +
                    "ADD	    BC_ISS_ITEM              DOUBLE PRECISION";
                comando_alter.Connection = conexao;
                conexao.Open();
                comando_alter.ExecuteNonQuery();
                conexao.Close();
            }
            catch
            {
                conexao.Close();
                erros++;
            }
            try
            {
                comando_alter.CommandText =
                    "ALTER TABLE ITENS_NOTA " +
                    "ADD	    BC_COM_IPI_ITEM          INTEGER";
                comando_alter.Connection = conexao;
                conexao.Open();
                comando_alter.ExecuteNonQuery();
                conexao.Close();
            }
            catch
            {
                conexao.Close();
                erros++;
            }
            try
            {
                comando_alter.CommandText =
                    "ALTER TABLE ITENS_NOTA " +
                    "ADD	    ST_IMPRESSAO_ITEM        VARCHAR(4)";
                comando_alter.Connection = conexao;
                conexao.Open();
                comando_alter.ExecuteNonQuery();
                conexao.Close();
            }
            catch
            {
                conexao.Close();
                erros++;
            }
            MessageBox.Show(erros.ToString() + " ERROS ");




        }

        private void button2_Click(object sender, EventArgs e)
        {
            FbConnection conexao = new FbConnection();
            conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=\evolucao_dokinos\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
            FbCommand comando_alter = new FbCommand();
            int erros = 0;
            int n_campos = 5;
            string[] campos = new string[n_campos];
            campos[0] = "ADD    DATA_AUTORIZACAO_NF         DATE";
            campos[1] = "ADD    HORA_AUTORIZACAO_NF         VARCHAR(50)";
            campos[2] = "ADD    ESTADO_CLIENTE_NF           VARCHAR(2)";
            campos[3] = "ADD    REFERENCIADA_NF             INTEGER";
            campos[4] = "ADD    N_NF_REFERENCIADA_NF        VARCHAR(300)";
            for (int i = 0; i < n_campos; i++)
            {
                try
                {
                    comando_alter.CommandText =
                        "ALTER TABLE NOTA_FISCAL " +
                        campos[i];
                    comando_alter.Connection = conexao;
                    conexao.Open();
                    comando_alter.ExecuteNonQuery();
                    conexao.Close();
                }
                catch
                {
                    conexao.Close();
                    erros++;
                }
            }
            MessageBox.Show(erros.ToString() + " ERROS");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FbConnection conexao = new FbConnection();
            conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=\evolucao_dokinos\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
            FbCommand comando_alter = new FbCommand();
            int erros = 0;
            int n_campos = 23;
            string[] campos = new string[n_campos];
            campos[0] = "ADD    ORIGEM_PRODUTO             VARCHAR(100)";
            campos[1] = "ADD    MOD_BC_PRODUTO             VARCHAR(100)";
            campos[2] = "ADD    ST_PRODUTO                 VARCHAR(100)";
            campos[3] = "ADD    IPI_PRODUTO                DOUBLE PRECISION";
            campos[4] = "ADD    ICMS_PRODUTO               DOUBLE PRECISION";
            campos[5] = "ADD    ISS_PRODUTO                DOUBLE PRECISION";
            campos[6] = "ADD    PRESTACAO_SERVICO_PRODUTO  INTEGER";
            campos[7] = "ADD    IVA_PRODUTO                DOUBLE PRECISION";
            campos[8] = "ADD    REDUCAO_PRODUTO            DOUBLE PRECISION";
            campos[9] = "ADD    PIS_PRODUTO                DOUBLE PRECISION";
            campos[10] = "ADD    COFINS_PRODUTO             DOUBLE PRECISION";
            campos[11] = "ADD    MOD_BC_ST_PRODUTO          VARCHAR(100)";
            campos[12] = "ADD    REDUCAO_ST_PRODUTO         DOUBLE PRECISION";
            campos[13] = "ADD    IPI_TRIB_PRODUTO           INTEGER";
            campos[14] = "ADD    IPI_N_TRIB_PRODUTO         INTEGER";
            campos[15] = "ADD    CST_IPI_TRIB_PRODUTO       VARCHAR(100)";
            campos[16] = "ADD    CST_IPI_N_TRIB_PRODUTO     VARCHAR(100)";
            campos[17] = "ADD    TIPO_PIS_PRODUTO           VARCHAR(100)";
            campos[18] = "ADD    CST_PIS_PRODUTO            VARCHAR(200)";
            campos[19] = "ADD    TIPO_COFINS_PRODUTO        VARCHAR(100)";
            campos[20] = "ADD    CST_COFINS_PRODUTO         VARCHAR(200)";
            campos[21] = "ADD    TIPO_SERVICO_PRODUTO       VARCHAR(100)";
            campos[22] = "ADD    BC_COM_IPI_PRODUTO         INTEGER";

            for (int i = 0; i < n_campos; i++)
            {
                try
                {
                    comando_alter.CommandText =
                        "ALTER TABLE PRODUTOS " +
                        campos[i];
                    comando_alter.Connection = conexao;
                    conexao.Open();
                    comando_alter.ExecuteNonQuery();
                    conexao.Close();
                }
                catch
                {
                    conexao.Close();
                    erros++;
                }
            }
            MessageBox.Show(erros.ToString() + " ERROS");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FbConnection conexao = new FbConnection();
            conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=\evolucao_dokinos\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
            FbCommand comando_alter = new FbCommand();
            int erros = 0;
            try
            {
                comando_alter.CommandText =
                    "CREATE TABLE PRODUTOS (" +
                    "    COD_PRODUTO                INTEGER NOT NULL," +
                    "    DESCRICAO_PRODUTO          VARCHAR(100)," +
                    "    UNIDADE_PRODUTO            VARCHAR(3)," +
                    "    NCM_PRODUTO                VARCHAR(8)," +
                    "    PRECO_PRODUTO              DOUBLE PRECISION," +
                    "    COD_SISTEMA_PRODUTO        VARCHAR(12)," +
                    "    ORIGEM_PRODUTO             VARCHAR(100)," +
                    "    MOD_BC_PRODUTO             VARCHAR(100)," +
                    "    ST_PRODUTO                 VARCHAR(100)," +
                    "    IPI_PRODUTO                DOUBLE PRECISION," +
                    "    ICMS_PRODUTO               DOUBLE PRECISION," +
                    "    ISS_PRODUTO                DOUBLE PRECISION," +
                    "    PRESTACAO_SERVICO_PRODUTO  INTEGER," +
                    "    IVA_PRODUTO                DOUBLE PRECISION," +
                    "    REDUCAO_PRODUTO            DOUBLE PRECISION," +
                    "    PIS_PRODUTO                DOUBLE PRECISION," +
                    "    COFINS_PRODUTO             DOUBLE PRECISION," +
                    "    MOD_BC_ST_PRODUTO          VARCHAR(100)," +
                    "    REDUCAO_ST_PRODUTO         DOUBLE PRECISION," +
                    "    IPI_TRIB_PRODUTO           INTEGER," +
                    "    IPI_N_TRIB_PRODUTO         INTEGER," +
                    "    CST_IPI_TRIB_PRODUTO       VARCHAR(100)," +
                    "    CST_IPI_N_TRIB_PRODUTO     VARCHAR(100)," +
                    "    TIPO_PIS_PRODUTO           VARCHAR(100)," +
                    "    CST_PIS_PRODUTO            VARCHAR(200)," +
                    "    TIPO_COFINS_PRODUTO        VARCHAR(100)," +
                    "    CST_COFINS_PRODUTO         VARCHAR(200)," +
                    "    TIPO_SERVICO_PRODUTO       VARCHAR(100)," +
                    "    BC_COM_IPI_PRODUTO         INTEGER" +
                    ")";
                comando_alter.Connection = conexao;
                conexao.Open();
                comando_alter.ExecuteNonQuery();
                conexao.Close();
            }
            catch
            {
                conexao.Close();
                erros++;
            }
            //ALTER TABLE PRODUTOS ADD CONSTRAINT PK_PRODUTOS PRIMARY KEY (COD_PRODUTO);
            try
            {
                comando_alter.CommandText =
                    "ALTER TABLE PRODUTOS ADD CONSTRAINT PK_PRODUTOS PRIMARY KEY (COD_PRODUTO)";
                comando_alter.Connection = conexao;
                conexao.Open();
                comando_alter.ExecuteNonQuery();
                conexao.Close();
            }
            catch
            {
                conexao.Close();
                erros++;
            }
            MessageBox.Show(erros.ToString() + " ERROS");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FbConnection conexao = new FbConnection();
            conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=\evolucao_dokinos\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
            FbCommand comando_alter = new FbCommand();
            int erros = 0;
            int n_campos = 10;
            string[] campos = new string[n_campos];
            campos[0] = "ADD    ICMS_CLIENTE            DOUBLE PRECISION";
            campos[1] = "ADD    REDUCAO_CLIENTE         DOUBLE PRECISION";
            campos[2] = "ADD    ICMS_ST_CLIENTE         DOUBLE PRECISION";
            campos[3] = "ADD    IVA_CLIENTE             DOUBLE PRECISION";
            campos[4] = "ADD    IPI_CLIENTE             DOUBLE PRECISION";
            campos[5] = "ADD    PIS_CLIENTE             DOUBLE PRECISION";
            campos[6] = "ADD    COFINS_CLIENTE          DOUBLE PRECISION";
            campos[7] = "ADD    REDUCAO_ST_CLIENTE      DOUBLE PRECISION";
            campos[8] = "ADD    COMPLEMENTO_CLIENTE     VARCHAR(100)";
            campos[9] = "ADD    BC_COM_IPI_CLIENTE      INTEGER";

            for (int i = 0; i < n_campos; i++)
            {
                try
                {
                    comando_alter.CommandText =
                        "ALTER TABLE CLIENTES " +
                        campos[i];
                    comando_alter.Connection = conexao;
                    conexao.Open();
                    comando_alter.ExecuteNonQuery();
                    conexao.Close();
                }
                catch
                {
                    conexao.Close();
                    erros++;
                }
            }
            MessageBox.Show(erros.ToString() + " ERROS");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FbConnection conexao = new FbConnection();
            conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=\evolucao_dokinos\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
            FbCommand comando_alter = new FbCommand();
            int erros = 0;
            int n_campos = 26;
            string[] campos = new string[n_campos];
            campos[0] = "ADD    ICMS_EMPRESA                  DOUBLE PRECISION";
            campos[1] = "ADD    REDUCAO_EMPRESA               DOUBLE PRECISION";
            campos[2] = "ADD    ICMS_ST_EMPRESA               DOUBLE PRECISION";
            campos[3] = "ADD    IVA_EMPRESA                   DOUBLE PRECISION";
            campos[4] = "ADD    IPI_EMPRESA                   DOUBLE PRECISION";
            campos[5] = "ADD    PIS_EMPRESA                   DOUBLE PRECISION";
            campos[6] = "ADD    COFINS_EMPRESA                DOUBLE PRECISION";
            campos[7] = "ADD    ORIGEM_EMPRESA                VARCHAR(100)";
            campos[8] = "ADD    MOD_BC_EMPRESA                VARCHAR(100)";
            campos[9] = "ADD    ISS_EMPRESA                   DOUBLE PRECISION";
            campos[10] = "ADD    CST_EMPRESA                   VARCHAR(3)";
            campos[11] = "ADD    CRT_EMPRESA                   VARCHAR(1)";
            campos[12] = "ADD    ALIQUOTA_CREDITO_EMPRESA      DOUBLE PRECISION";
            campos[13] = "ADD    MOD_BC_ST_EMPRESA             VARCHAR(100)";
            campos[14] = "ADD    REDUCAO_ST_EMPRESA            DOUBLE PRECISION";
            campos[15] = "ADD    IPI_TRIB_EMPRESA              INTEGER";
            campos[16] = "ADD    IPI_N_TRIB_EMPRESA            INTEGER";
            campos[17] = "ADD    CST_IPI_TRIB_EMPRESA          VARCHAR(100)";
            campos[18] = "ADD    CST_IPI_N_TRIB_EMPRESA        VARCHAR(100)";
            campos[19] = "ADD    TIPO_PIS_EMPRESA              VARCHAR(100)";
            campos[20] = "ADD    CST_PIS_EMPRESA               VARCHAR(200)";
            campos[21] = "ADD    TIPO_COFINS_EMPRESA           VARCHAR(100)";
            campos[22] = "ADD    CST_COFINS_EMPRESA            VARCHAR(200)";
            campos[23] = "ADD    TIPO_SERVICO_EMPRESA          VARCHAR(100)";
            campos[24] = "ADD    BC_COM_IPI_EMPRESA            INTEGER";
            campos[25] = "ADD    CNAE_EMPRESA                  VARCHAR(20)";


            for (int i = 0; i < n_campos; i++)
            {
                try
                {
                    comando_alter.CommandText =
                        "ALTER TABLE EMPRESA " +
                        campos[i];
                    comando_alter.Connection = conexao;
                    conexao.Open();
                    comando_alter.ExecuteNonQuery();
                    conexao.Close();
                }
                catch
                {
                    conexao.Close();
                    erros++;
                }
            }
            MessageBox.Show(erros.ToString() + " ERROS");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FbConnection conexao = new FbConnection();
            conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=\evolucao_dokinos\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
            FbCommand comando_alter = new FbCommand();
            int erros = 0;
            int n_campos = 26;
            try
            {
                comando_alter.CommandText =
                    "CREATE GENERATOR GEN_CONTATOS_ID";
                    
                comando_alter.Connection = conexao;
                conexao.Open();
                comando_alter.ExecuteNonQuery();
                conexao.Close();
            }
            catch
            {
                conexao.Close();
                erros++;
            }
            try
            {
                comando_alter.CommandText =
                    "CREATE TABLE CONTATOS (" +
                    "    COD_CONTATO               INTEGER NOT NULL," +
                    "    NOME_CONTATO              VARCHAR(100)," +
                    "    EMAIL_CONTATO             VARCHAR(100)," +
                    "    TEL_1_CONTATO             VARCHAR(100)," +
                    "    TEL_2_CONTATO             VARCHAR(100)," +
                    "    CLIENTE_FORN_CONTATO      VARCHAR(10)," +
                    "    COD_CLIENTE_FORN_CONTATO  INTEGER," +
                    "    TIPO_CONTATO              VARCHAR(30)" +
                    ")";
                comando_alter.Connection = conexao;
                conexao.Open();
                comando_alter.ExecuteNonQuery();
                conexao.Close();
            }
            catch
            {
                conexao.Close();
                erros++;
            }
            try
            {
                comando_alter.CommandText =
                    "ALTER TABLE CONTATOS ADD CONSTRAINT PK_CONTATOS PRIMARY KEY (COD_CONTATO)";
                comando_alter.Connection = conexao;
                conexao.Open();
                comando_alter.ExecuteNonQuery();
                conexao.Close();
            }
            catch
            {
                conexao.Close();
                erros++;
            }
            //ALTER TABLE CONTATOS ADD CONSTRAINT PK_CONTATOS PRIMARY KEY (COD_CONTATO);
            
            MessageBox.Show(erros.ToString() + " ERROS");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FbConnection conexao = new FbConnection();
            conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=\evolucao_dokinos\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
            FbCommand comando_alter = new FbCommand();
            int erros = 0;
            int n_campos = 26;
            try
            {
                comando_alter.CommandText =
                    "CREATE GENERATOR GEN_NFS_INUTILIZADAS_ID";

                comando_alter.Connection = conexao;
                conexao.Open();
                comando_alter.ExecuteNonQuery();
                conexao.Close();
            }
            catch
            {
                conexao.Close();
                erros++;
            }
            try
            {
                comando_alter.CommandText =
                    "CREATE TABLE NFS_INUTILIZADAS (" +
                    "    COD_NF_INUTILIZADA            INTEGER NOT NULL," +
                    "    N_INICIO_NF_INUTILIZADA       INTEGER," +
                    "    N_FIM_NF_INUTILIZADA          INTEGER," +
                    "    JUSTIFICATIVA_NF_INUTILIZADA  VARCHAR(100)," +
                    "    DATA_NF_INUTILIZADA           DATE" +
                    ")";
                comando_alter.Connection = conexao;
                conexao.Open();
                comando_alter.ExecuteNonQuery();
                conexao.Close();
            }
            catch
            {
                conexao.Close();
                erros++;
            }
            try
            {
                comando_alter.CommandText =
                    "ALTER TABLE NFS_INUTILIZADAS ADD CONSTRAINT PK_NFS_INUTILIZADAS PRIMARY KEY (COD_NF_INUTILIZADA)";
                comando_alter.Connection = conexao;
                conexao.Open();
                comando_alter.ExecuteNonQuery();
                conexao.Close();
            }
            catch
            {
                conexao.Close();
                erros++;
            }
            //ALTER TABLE CONTATOS ADD CONSTRAINT PK_CONTATOS PRIMARY KEY (COD_CONTATO);

            MessageBox.Show(erros.ToString() + " ERROS");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FbConnection conexao = new FbConnection();
            conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=\evolucao_dokinos\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
            FbCommand comando_alter = new FbCommand();
            int erros = 0;
            int n_campos = 26;
            try
            {
                comando_alter.CommandText =
                    "CREATE GENERATOR GEN_EMPRESA_ID";

                comando_alter.Connection = conexao;
                conexao.Open();
                comando_alter.ExecuteNonQuery();
                conexao.Close();
            }
            catch
            {
                conexao.Close();
                erros++;
            }
            try
            {
                comando_alter.CommandText =
                    "CREATE TABLE EMPRESA (" +
                "    COD_EMPRESA                   INTEGER NOT NULL," +
                "    RAZAO_SOCIAL_EMPRESA          VARCHAR(200)," +
                "    NOME_FANTASIA_EMPRESA         VARCHAR(200)," +
                "    CNPJ_EMPRESA                  VARCHAR(30)," +
                "    IE_EMPRESA                    VARCHAR(30)," +
                "    IM_EMPRESA                    VARCHAR(30)," +
                "    ENDERECO_EMPRESA              VARCHAR(200)," +
                "    N_ENDERECO_EMPRESA            VARCHAR(20)," +
                "    COMPLEMENTO_EMPRESA           VARCHAR(50)," +
                "    BAIRRO_EMPRESA                VARCHAR(50)," +
                "    CIDADE_EMPRESA                VARCHAR(50)," +
                "    ESTADO_EMPRESA                VARCHAR(2)," +
                "    CEP_EMPRESA                   VARCHAR(10)," +
                "    TELEFONE_EMPRESA              VARCHAR(50)," +
                "    COD_CIDADE_EMPRESA            VARCHAR(7)," +
                "    PAIS_EMPRESA                  VARCHAR(50)," +
                "    COD_PAIS_EMPRESA              VARCHAR(20)," +
                "    LICENCA_DLL_NFE_EMPRESA       VARCHAR(200)," +
                "    NOME_CERTIFICADO_NFE_EMPRESA  VARCHAR(400)," +
                "    ASSUNTO_NFE_EMAIL_EMPRESA     VARCHAR(200)," +
                "    SMTP_NFE_EMPRESA              VARCHAR(50)," +
                "    EMAIL_NFE_EMPRESA             VARCHAR(50)," +
                "    SENHA_EMAIL_NFE_EMPRESA       VARCHAR(50)," +
                "    LOGOTIPO_EMPRESA              BLOB SUB_TYPE 0 SEGMENT SIZE 80," +
                "    PROXY_EMPRESA                 VARCHAR(20)," +
                "    USUARIO_PROXY_EMPRESA         VARCHAR(50)," +
                "    SENHA_PROXY_EMPRESA           VARCHAR(50)," +
                "    NOME_CONTATO_EMAIL_NFE        VARCHAR(200)," +
                "    ICMS_EMPRESA                  DOUBLE PRECISION," +
                "    REDUCAO_EMPRESA               DOUBLE PRECISION," +
                "    ICMS_ST_EMPRESA               DOUBLE PRECISION," +
                "    IVA_EMPRESA                   DOUBLE PRECISION," +
                "    IPI_EMPRESA                   DOUBLE PRECISION," +
                "    PIS_EMPRESA                   DOUBLE PRECISION," +
                "    COFINS_EMPRESA                DOUBLE PRECISION," +
                "    ORIGEM_EMPRESA                VARCHAR(100)," +
                "    MOD_BC_EMPRESA                VARCHAR(100)," +
                "    ISS_EMPRESA                   DOUBLE PRECISION," +
                "    CST_EMPRESA                   VARCHAR(3)," +
                "    CRT_EMPRESA                   VARCHAR(1)," +
                "    ALIQUOTA_CREDITO_EMPRESA      DOUBLE PRECISION," +
                "    MOD_BC_ST_EMPRESA             VARCHAR(100)," +
                "    REDUCAO_ST_EMPRESA            DOUBLE PRECISION," +
                "    IPI_TRIB_EMPRESA              INTEGER," +
                "    IPI_N_TRIB_EMPRESA            INTEGER," +
                "    CST_IPI_TRIB_EMPRESA          VARCHAR(100)," +
                "    CST_IPI_N_TRIB_EMPRESA        VARCHAR(100)," +
                "    TIPO_PIS_EMPRESA              VARCHAR(100)," +
                "    CST_PIS_EMPRESA               VARCHAR(200)," +
                "    TIPO_COFINS_EMPRESA           VARCHAR(100)," +
                "    CST_COFINS_EMPRESA            VARCHAR(200)," +
                "    TIPO_SERVICO_EMPRESA          VARCHAR(100)," +
                "    BC_COM_IPI_EMPRESA            INTEGER," +
                "    CNAE_EMPRESA                  VARCHAR(20)" +
                ")";

                comando_alter.Connection = conexao;
                conexao.Open();
                comando_alter.ExecuteNonQuery();
                conexao.Close();
            }
            catch
            {
                conexao.Close();
                erros++;
            }
            try
            {
                comando_alter.CommandText =
                    "ALTER TABLE EMPRESA ADD CONSTRAINT PK_EMPRESA PRIMARY KEY (COD_EMPRESA)";
                comando_alter.Connection = conexao;
                conexao.Open();
                comando_alter.ExecuteNonQuery();
                conexao.Close();
            }
            catch
            {
                conexao.Close();
                erros++;
            }
            //ALTER TABLE CONTATOS ADD CONSTRAINT PK_CONTATOS PRIMARY KEY (COD_CONTATO);

            MessageBox.Show(erros.ToString() + " ERROS");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FbConnection conexao = new FbConnection();
            conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=\evolucao_dokinos\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
            FbCommand comando_alter = new FbCommand();
            int erros = 0;
            int n_campos = 1;
            string[] campos = new string[n_campos];
            campos[0] = "ADD    TRIBUTADA_CFO         INTEGER";
            
            for (int i = 0; i < n_campos; i++)
            {
                try
                {
                    comando_alter.CommandText =
                        "ALTER TABLE CFO " +
                        campos[i];
                    comando_alter.Connection = conexao;
                    conexao.Open();
                    comando_alter.ExecuteNonQuery();
                    conexao.Close();
                }
                catch
                {
                    conexao.Close();
                    erros++;
                }
            }
            MessageBox.Show(erros.ToString() + " ERROS");
        }

        private void form_add_campos_Load(object sender, EventArgs e)
        {

        }
    }
}