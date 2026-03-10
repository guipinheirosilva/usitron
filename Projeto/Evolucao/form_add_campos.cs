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
            conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=10.3.3.4;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
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
            conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=10.3.3.4;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
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
            conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=10.3.3.4;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
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
            conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=10.3.3.4;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
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
            conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=10.3.3.4;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
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
            conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=10.3.3.4;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
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
            conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=10.3.3.4;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
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
            conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=10.3.3.4;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
            FbCommand comando_alter = new FbCommand();
            int erros = 0;
            int n_campos = 1;
            string[] campos = new string[n_campos];
            campos[0] = "ADD    TRIBUTADA_EMPRESA                  INTEGER";
            
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

        private void button9_Click(object sender, EventArgs e)
        {
            FbConnection conexao = new FbConnection();
            conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=10.3.3.4;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
            FbCommand comando_alter = new FbCommand();
            comando_alter.Connection = conexao;
            int erros = 0;
            try
            {
                comando_alter.CommandText =
                    "DELETE FROM AGENDA_OS";
                conexao.Open();
                FbDataAdapter datDelete = new FbDataAdapter();
                datDelete.DeleteCommand = comando_alter;
                datDelete.DeleteCommand.ExecuteNonQuery();
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
                    "DELETE FROM ALIQUOTA_SIMPLES";
                conexao.Open();
                FbDataAdapter datDelete = new FbDataAdapter();
                datDelete.DeleteCommand = comando_alter;
                datDelete.DeleteCommand.ExecuteNonQuery();
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
                    "DELETE FROM APONTAMENTOS";
                conexao.Open();
                FbDataAdapter datDelete = new FbDataAdapter();
                datDelete.DeleteCommand = comando_alter;
                datDelete.DeleteCommand.ExecuteNonQuery();
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
                    "DELETE FROM AREA_ATUACAO_FORN";
                conexao.Open();
                FbDataAdapter datDelete = new FbDataAdapter();
                datDelete.DeleteCommand = comando_alter;
                datDelete.DeleteCommand.ExecuteNonQuery();
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
                    "DELETE FROM BAIXAS_CONJUNTAS_OF";
                conexao.Open();
                FbDataAdapter datDelete = new FbDataAdapter();
                datDelete.DeleteCommand = comando_alter;
                datDelete.DeleteCommand.ExecuteNonQuery();
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
                    "DELETE FROM CAIXA";
                conexao.Open();
                FbDataAdapter datDelete = new FbDataAdapter();
                datDelete.DeleteCommand = comando_alter;
                datDelete.DeleteCommand.ExecuteNonQuery();
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
                    "DELETE FROM CARTEIRAS";
                conexao.Open();
                FbDataAdapter datDelete = new FbDataAdapter();
                datDelete.DeleteCommand = comando_alter;
                datDelete.DeleteCommand.ExecuteNonQuery();
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
                    "DELETE FROM CLIENTES";
                conexao.Open();
                FbDataAdapter datDelete = new FbDataAdapter();
                datDelete.DeleteCommand = comando_alter;
                datDelete.DeleteCommand.ExecuteNonQuery();
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
                    "DELETE FROM CONSULTA_OPER";
                conexao.Open();
                FbDataAdapter datDelete = new FbDataAdapter();
                datDelete.DeleteCommand = comando_alter;
                datDelete.DeleteCommand.ExecuteNonQuery();
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
                    "DELETE FROM CONTAS_A_PAGAR";
                conexao.Open();
                FbDataAdapter datDelete = new FbDataAdapter();
                datDelete.DeleteCommand = comando_alter;
                datDelete.DeleteCommand.ExecuteNonQuery();
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
                    "DELETE FROM CONTAS_A_RECEBER";
                conexao.Open();
                FbDataAdapter datDelete = new FbDataAdapter();
                datDelete.DeleteCommand = comando_alter;
                datDelete.DeleteCommand.ExecuteNonQuery();
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
                    "DELETE FROM CONTAS_CORRENTES";
                conexao.Open();
                FbDataAdapter datDelete = new FbDataAdapter();
                datDelete.DeleteCommand = comando_alter;
                datDelete.DeleteCommand.ExecuteNonQuery();
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
                    "DELETE FROM CONTATOS";
                conexao.Open();
                FbDataAdapter datDelete = new FbDataAdapter();
                datDelete.DeleteCommand = comando_alter;
                datDelete.DeleteCommand.ExecuteNonQuery();
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
                    "DELETE FROM CONTATOS_ORC";
                conexao.Open();
                FbDataAdapter datDelete = new FbDataAdapter();
                datDelete.DeleteCommand = comando_alter;
                datDelete.DeleteCommand.ExecuteNonQuery();
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
                    "DELETE FROM CRONO_FERRAMENTAL";
                conexao.Open();
                FbDataAdapter datDelete = new FbDataAdapter();
                datDelete.DeleteCommand = comando_alter;
                datDelete.DeleteCommand.ExecuteNonQuery();
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
                    "DELETE FROM DESENHOS";
                conexao.Open();
                FbDataAdapter datDelete = new FbDataAdapter();
                datDelete.DeleteCommand = comando_alter;
                datDelete.DeleteCommand.ExecuteNonQuery();
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
                    "DELETE FROM DESPESAS_MOLDE";
                conexao.Open();
                FbDataAdapter datDelete = new FbDataAdapter();
                datDelete.DeleteCommand = comando_alter;
                datDelete.DeleteCommand.ExecuteNonQuery();
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
                    "DELETE FROM EDI";
                conexao.Open();
                FbDataAdapter datDelete = new FbDataAdapter();
                datDelete.DeleteCommand = comando_alter;
                datDelete.DeleteCommand.ExecuteNonQuery();
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
                    "DELETE FROM EMAILS_ENVIADOS";
                conexao.Open();
                FbDataAdapter datDelete = new FbDataAdapter();
                datDelete.DeleteCommand = comando_alter;
                datDelete.DeleteCommand.ExecuteNonQuery();
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
                    "DELETE FROM ENTRADAS_SUCATA";
                conexao.Open();
                FbDataAdapter datDelete = new FbDataAdapter();
                datDelete.DeleteCommand = comando_alter;
                datDelete.DeleteCommand.ExecuteNonQuery();
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
                    "DELETE FROM ENTRADA_PA";
                conexao.Open();
                FbDataAdapter datDelete = new FbDataAdapter();
                datDelete.DeleteCommand = comando_alter;
                datDelete.DeleteCommand.ExecuteNonQuery();
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
                    "DELETE FROM ESTOQUE";
                conexao.Open();
                FbDataAdapter datDelete = new FbDataAdapter();
                datDelete.DeleteCommand = comando_alter;
                datDelete.DeleteCommand.ExecuteNonQuery();
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
                    "DELETE FROM ESTOQUE_PECAS";
                conexao.Open();
                FbDataAdapter datDelete = new FbDataAdapter();
                datDelete.DeleteCommand = comando_alter;
                datDelete.DeleteCommand.ExecuteNonQuery();
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
                    "DELETE FROM ESTOQUE_SAIDA";
                conexao.Open();
                FbDataAdapter datDelete = new FbDataAdapter();
                datDelete.DeleteCommand = comando_alter;
                datDelete.DeleteCommand.ExecuteNonQuery();
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
                    "DELETE FROM EXCECOES";
                conexao.Open();
                FbDataAdapter datDelete = new FbDataAdapter();
                datDelete.DeleteCommand = comando_alter;
                datDelete.DeleteCommand.ExecuteNonQuery();
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
                    "DELETE FROM FATURA_NF";
                conexao.Open();
                FbDataAdapter datDelete = new FbDataAdapter();
                datDelete.DeleteCommand = comando_alter;
                datDelete.DeleteCommand.ExecuteNonQuery();
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
                    "DELETE FROM FATURA_NF_ENTRADA";
                conexao.Open();
                FbDataAdapter datDelete = new FbDataAdapter();
                datDelete.DeleteCommand = comando_alter;
                datDelete.DeleteCommand.ExecuteNonQuery();
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
                    "DELETE FROM FORNECEDORES";
                conexao.Open();
                FbDataAdapter datDelete = new FbDataAdapter();
                datDelete.DeleteCommand = comando_alter;
                datDelete.DeleteCommand.ExecuteNonQuery();
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
                    "DELETE FROM HORAS_PROGRAMACAO";
                conexao.Open();
                FbDataAdapter datDelete = new FbDataAdapter();
                datDelete.DeleteCommand = comando_alter;
                datDelete.DeleteCommand.ExecuteNonQuery();
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
                    "DELETE FROM HORAS_SEMANA";
                conexao.Open();
                FbDataAdapter datDelete = new FbDataAdapter();
                datDelete.DeleteCommand = comando_alter;
                datDelete.DeleteCommand.ExecuteNonQuery();
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
                    "DELETE FROM IMPRESSAO_ELETRODOS";
                conexao.Open();
                FbDataAdapter datDelete = new FbDataAdapter();
                datDelete.DeleteCommand = comando_alter;
                datDelete.DeleteCommand.ExecuteNonQuery();
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
                    "DELETE FROM ITENS_MATERIA_PRIMA_PECA";
                conexao.Open();
                FbDataAdapter datDelete = new FbDataAdapter();
                datDelete.DeleteCommand = comando_alter;
                datDelete.DeleteCommand.ExecuteNonQuery();
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
                    "DELETE FROM ITENS_NF_ENTRADA";
                conexao.Open();
                FbDataAdapter datDelete = new FbDataAdapter();
                datDelete.DeleteCommand = comando_alter;
                datDelete.DeleteCommand.ExecuteNonQuery();
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
                    "DELETE FROM ITENS_NOTA";
                conexao.Open();
                FbDataAdapter datDelete = new FbDataAdapter();
                datDelete.DeleteCommand = comando_alter;
                datDelete.DeleteCommand.ExecuteNonQuery();
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
                    "DELETE FROM ITENS_ORCAMENTO";
                conexao.Open();
                FbDataAdapter datDelete = new FbDataAdapter();
                datDelete.DeleteCommand = comando_alter;
                datDelete.DeleteCommand.ExecuteNonQuery();
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
                    "DELETE FROM ITENS_PEDIDO_COMPRA";
                conexao.Open();
                FbDataAdapter datDelete = new FbDataAdapter();
                datDelete.DeleteCommand = comando_alter;
                datDelete.DeleteCommand.ExecuteNonQuery();
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
                    "DELETE FROM ITENS_REQUISICAO";
                conexao.Open();
                FbDataAdapter datDelete = new FbDataAdapter();
                datDelete.DeleteCommand = comando_alter;
                datDelete.DeleteCommand.ExecuteNonQuery();
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
                    "DELETE FROM ITENS_TERCEIROS";
                conexao.Open();
                FbDataAdapter datDelete = new FbDataAdapter();
                datDelete.DeleteCommand = comando_alter;
                datDelete.DeleteCommand.ExecuteNonQuery();
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
                    "DELETE FROM LOTE_APONTAMENTO";
                conexao.Open();
                FbDataAdapter datDelete = new FbDataAdapter();
                datDelete.DeleteCommand = comando_alter;
                datDelete.DeleteCommand.ExecuteNonQuery();
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
                    "DELETE FROM MALOTES";
                conexao.Open();
                FbDataAdapter datDelete = new FbDataAdapter();
                datDelete.DeleteCommand = comando_alter;
                datDelete.DeleteCommand.ExecuteNonQuery();
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
                    "DELETE FROM MAQUINAS";
                conexao.Open();
                FbDataAdapter datDelete = new FbDataAdapter();
                datDelete.DeleteCommand = comando_alter;
                datDelete.DeleteCommand.ExecuteNonQuery();
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
                    "DELETE FROM MAQUINA_RODANDO";
                conexao.Open();
                FbDataAdapter datDelete = new FbDataAdapter();
                datDelete.DeleteCommand = comando_alter;
                datDelete.DeleteCommand.ExecuteNonQuery();
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
                    "DELETE FROM MATERIA_PRIMA";
                conexao.Open();
                FbDataAdapter datDelete = new FbDataAdapter();
                datDelete.DeleteCommand = comando_alter;
                datDelete.DeleteCommand.ExecuteNonQuery();
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
                    "DELETE FROM NFS_INUTILIZADAS";
                conexao.Open();
                FbDataAdapter datDelete = new FbDataAdapter();
                datDelete.DeleteCommand = comando_alter;
                datDelete.DeleteCommand.ExecuteNonQuery();
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
                    "DELETE FROM NOTA_FISCAL";
                conexao.Open();
                FbDataAdapter datDelete = new FbDataAdapter();
                datDelete.DeleteCommand = comando_alter;
                datDelete.DeleteCommand.ExecuteNonQuery();
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
                    "DELETE FROM NOTA_FISCAL_ENTRADA";
                conexao.Open();
                FbDataAdapter datDelete = new FbDataAdapter();
                datDelete.DeleteCommand = comando_alter;
                datDelete.DeleteCommand.ExecuteNonQuery();
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
                    "DELETE FROM OFS";
                conexao.Open();
                FbDataAdapter datDelete = new FbDataAdapter();
                datDelete.DeleteCommand = comando_alter;
                datDelete.DeleteCommand.ExecuteNonQuery();
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
                    "DELETE FROM OP";
                conexao.Open();
                FbDataAdapter datDelete = new FbDataAdapter();
                datDelete.DeleteCommand = comando_alter;
                datDelete.DeleteCommand.ExecuteNonQuery();
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
                    "DELETE FROM OPERADORES";
                conexao.Open();
                FbDataAdapter datDelete = new FbDataAdapter();
                datDelete.DeleteCommand = comando_alter;
                datDelete.DeleteCommand.ExecuteNonQuery();
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
                    "DELETE FROM OPS_BAIXADAS_OF";
                conexao.Open();
                FbDataAdapter datDelete = new FbDataAdapter();
                datDelete.DeleteCommand = comando_alter;
                datDelete.DeleteCommand.ExecuteNonQuery();
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
                    "DELETE FROM OP_OF";
                conexao.Open();
                FbDataAdapter datDelete = new FbDataAdapter();
                datDelete.DeleteCommand = comando_alter;
                datDelete.DeleteCommand.ExecuteNonQuery();
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
                    "DELETE FROM ORCAMENTOS";
                conexao.Open();
                FbDataAdapter datDelete = new FbDataAdapter();
                datDelete.DeleteCommand = comando_alter;
                datDelete.DeleteCommand.ExecuteNonQuery();
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
                    "DELETE FROM PARADAS";
                conexao.Open();
                FbDataAdapter datDelete = new FbDataAdapter();
                datDelete.DeleteCommand = comando_alter;
                datDelete.DeleteCommand.ExecuteNonQuery();
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
                    "DELETE FROM PECAS";
                conexao.Open();
                FbDataAdapter datDelete = new FbDataAdapter();
                datDelete.DeleteCommand = comando_alter;
                datDelete.DeleteCommand.ExecuteNonQuery();
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
                    "DELETE FROM PEDIDO_COMPRA";
                conexao.Open();
                FbDataAdapter datDelete = new FbDataAdapter();
                datDelete.DeleteCommand = comando_alter;
                datDelete.DeleteCommand.ExecuteNonQuery();
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
                    "DELETE FROM PERIODOS";
                conexao.Open();
                FbDataAdapter datDelete = new FbDataAdapter();
                datDelete.DeleteCommand = comando_alter;
                datDelete.DeleteCommand.ExecuteNonQuery();
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
                    "DELETE FROM PRODUTOS";
                conexao.Open();
                FbDataAdapter datDelete = new FbDataAdapter();
                datDelete.DeleteCommand = comando_alter;
                datDelete.DeleteCommand.ExecuteNonQuery();
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
                    "DELETE FROM REQUISICOES";
                conexao.Open();
                FbDataAdapter datDelete = new FbDataAdapter();
                datDelete.DeleteCommand = comando_alter;
                datDelete.DeleteCommand.ExecuteNonQuery();
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
                    "DELETE FROM RECEITAS_MOLDE";
                conexao.Open();
                FbDataAdapter datDelete = new FbDataAdapter();
                datDelete.DeleteCommand = comando_alter;
                datDelete.DeleteCommand.ExecuteNonQuery();
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
                    "DELETE FROM ROTAS";
                conexao.Open();
                FbDataAdapter datDelete = new FbDataAdapter();
                datDelete.DeleteCommand = comando_alter;
                datDelete.DeleteCommand.ExecuteNonQuery();
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
                    "DELETE FROM ROTAS_CAMPO";
                conexao.Open();
                FbDataAdapter datDelete = new FbDataAdapter();
                datDelete.DeleteCommand = comando_alter;
                datDelete.DeleteCommand.ExecuteNonQuery();
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
                    "DELETE FROM ROTAS_PECA";
                conexao.Open();
                FbDataAdapter datDelete = new FbDataAdapter();
                datDelete.DeleteCommand = comando_alter;
                datDelete.DeleteCommand.ExecuteNonQuery();
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
                    "DELETE FROM SAIDAS_SUCATA";
                conexao.Open();
                FbDataAdapter datDelete = new FbDataAdapter();
                datDelete.DeleteCommand = comando_alter;
                datDelete.DeleteCommand.ExecuteNonQuery();
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
                    "DELETE FROM SAIDA_PA";
                conexao.Open();
                FbDataAdapter datDelete = new FbDataAdapter();
                datDelete.DeleteCommand = comando_alter;
                datDelete.DeleteCommand.ExecuteNonQuery();
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
                    "DELETE FROM SALARIO_OFF";
                conexao.Open();
                FbDataAdapter datDelete = new FbDataAdapter();
                datDelete.DeleteCommand = comando_alter;
                datDelete.DeleteCommand.ExecuteNonQuery();
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
                    "DELETE FROM SERVICOS_EXTERNOS_ORC";
                conexao.Open();
                FbDataAdapter datDelete = new FbDataAdapter();
                datDelete.DeleteCommand = comando_alter;
                datDelete.DeleteCommand.ExecuteNonQuery();
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
                    "DELETE FROM TERCEIROS";
                conexao.Open();
                FbDataAdapter datDelete = new FbDataAdapter();
                datDelete.DeleteCommand = comando_alter;
                datDelete.DeleteCommand.ExecuteNonQuery();
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
                    "DELETE FROM TRANSPORTADORAS";
                conexao.Open();
                FbDataAdapter datDelete = new FbDataAdapter();
                datDelete.DeleteCommand = comando_alter;
                datDelete.DeleteCommand.ExecuteNonQuery();
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
                    "DELETE FROM TRIBUTACAO";
                conexao.Open();
                FbDataAdapter datDelete = new FbDataAdapter();
                datDelete.DeleteCommand = comando_alter;
                datDelete.DeleteCommand.ExecuteNonQuery();
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
                    "DELETE FROM VALORES_VARIAVEIS_PECA";
                conexao.Open();
                FbDataAdapter datDelete = new FbDataAdapter();
                datDelete.DeleteCommand = comando_alter;
                datDelete.DeleteCommand.ExecuteNonQuery();
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
                    "DELETE FROM VALOR_OPERACAO";
                conexao.Open();
                FbDataAdapter datDelete = new FbDataAdapter();
                datDelete.DeleteCommand = comando_alter;
                datDelete.DeleteCommand.ExecuteNonQuery();
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
                    "DELETE FROM VALOR_OPERACAO_CLIENTE";
                conexao.Open();
                FbDataAdapter datDelete = new FbDataAdapter();
                datDelete.DeleteCommand = comando_alter;
                datDelete.DeleteCommand.ExecuteNonQuery();
                conexao.Close(); 
            }
            catch
            {
                conexao.Close(); 
                erros++;
            }
                
        
        }

        private void form_add_campos_Load(object sender, EventArgs e)
        {

        }
    }
}