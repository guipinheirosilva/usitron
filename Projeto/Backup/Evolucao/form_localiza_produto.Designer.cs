namespace Evolucao
{
    partial class form_localiza_produto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_localiza_produto));
            this.datProdutos = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsProdutos = new System.Data.DataSet();
            this.PRODUTOS = new System.Data.DataTable();
            this.COD_PRODUTO = new System.Data.DataColumn();
            this.COD_GRUPO_PRODUTO = new System.Data.DataColumn();
            this.DESCRICAO_GRUPO_PRODUTO = new System.Data.DataColumn();
            this.COD_SUB_GRUPO_PRODUTO = new System.Data.DataColumn();
            this.DESCRICAO_SUB_GRUPO_PRODUTO = new System.Data.DataColumn();
            this.DESCRICAO_PRODUTO = new System.Data.DataColumn();
            this.CARACT_ADIC_PRODUTO = new System.Data.DataColumn();
            this.COD_BARRAS_PRODUTO = new System.Data.DataColumn();
            this.COD_ONU_PRODUTO = new System.Data.DataColumn();
            this.CLASSE_TOXIC_PRODUTO = new System.Data.DataColumn();
            this.COD_UNIDADE_PRODUTO = new System.Data.DataColumn();
            this.DESCRICAO_UNIDADE_PRODUTO = new System.Data.DataColumn();
            this.META_ANUAL_PRODUTO = new System.Data.DataColumn();
            this.COD_REDUZIDO_PRODUTO = new System.Data.DataColumn();
            this.TAB_PRODUTO = new System.Data.DataColumn();
            this.META_SEMESTRAL_PRODUTO = new System.Data.DataColumn();
            this.ESTOQUE_ATUAL_PRODUTO = new System.Data.DataColumn();
            this.ESTOQUE_RESERVADO_PRODUTO = new System.Data.DataColumn();
            this.ESTOQUE_MINIMO_PRODUTO = new System.Data.DataColumn();
            this.ESTOQUE_ENCOMENDADO_PRODUTO = new System.Data.DataColumn();
            this.ESTOQUE_MAXIMO_PRODUTO = new System.Data.DataColumn();
            this.ESTOQUE_MEDIO_PRODUTO = new System.Data.DataColumn();
            this.CUSTO_PRODUTO = new System.Data.DataColumn();
            this.CUSTO_MED_PRODUTO = new System.Data.DataColumn();
            this.VALOR_VENDA_PRODUTOR_PRODUTO = new System.Data.DataColumn();
            this.VALOR_VENDA_REVEND_PRODUTO = new System.Data.DataColumn();
            this.VALOR_PROMOCAO_PRODUTO = new System.Data.DataColumn();
            this.OUTRO_VALOR_PRODUTO = new System.Data.DataColumn();
            this.LUCRO_PRODUTO = new System.Data.DataColumn();
            this.ULT_REAJ_PRODUTO = new System.Data.DataColumn();
            this.PROD_RECEITA_PRODUTO = new System.Data.DataColumn();
            this.STATUS_PRODUTO = new System.Data.DataColumn();
            this.ICMS_S_N_PRODUTO = new System.Data.DataColumn();
            this.ALIQUOTA_ICMS_PRODUTO = new System.Data.DataColumn();
            this.REDUCAO_FORA_PRODUTO = new System.Data.DataColumn();
            this.ALIQUOTA_IPI_PRODUTO = new System.Data.DataColumn();
            this.PIS_PRODUTO = new System.Data.DataColumn();
            this.COFINS_PRODUTO = new System.Data.DataColumn();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataColumn7 = new System.Data.DataColumn();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_cod_forn = new System.Windows.Forms.TextBox();
            this.cb_status = new System.Windows.Forms.CheckBox();
            this.tb_descricao_item = new System.Windows.Forms.TextBox();
            this.tb_descricao = new System.Windows.Forms.TextBox();
            this.tb_sub_grupo = new System.Windows.Forms.TextBox();
            this.tb_grupo = new System.Windows.Forms.TextBox();
            this.tb_cod_grupo = new System.Windows.Forms.TextBox();
            this.tb_cod = new System.Windows.Forms.TextBox();
            this.tbcod_sub_grupo = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_valor_estoque = new System.Windows.Forms.TextBox();
            this.cODPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODGRUPOPRODUTODataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRICAOGRUPOPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODSUBGRUPOPRODUTODataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRICAOSUBGRUPOPRODUTODataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRICAOPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cARACTADICPRODUTODataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODBARRASPRODUTODataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODONUPRODUTODataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLASSETOXICPRODUTODataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODUNIDADEPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRICAOUNIDADEPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mETAANUALPRODUTODataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODREDUZIDOPRODUTODataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tABPRODUTODataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mETASEMESTRALPRODUTODataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSTOQUEATUALPRODUTODataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSTOQUERESERVADOPRODUTODataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSTOQUEMINIMOPRODUTODataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSTOQUEENCOMENDADOPRODUTODataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSTOQUEMAXIMOPRODUTODataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSTOQUEMEDIOPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTOPRODUTODataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTOMEDPRODUTODataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORVENDAPRODUTORPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORVENDAREVENDPRODUTODataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORPROMOCAOPRODUTODataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oUTROVALORPRODUTODataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lUCROPRODUTODataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uLTREAJPRODUTODataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODRECEITAPRODUTODataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTATUSPRODUTODataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iCMSSNPRODUTODataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aLIQUOTAICMSPRODUTODataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEDUCAOFORAPRODUTODataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aLIQUOTAIPIPRODUTODataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pISPRODUTODataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOFINSPRODUTODataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODMARCAPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mARCAPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iVAPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nCMPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRICAOITEMPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODFORNECEDORPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRIGEMPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_valor_compra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.col_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODGRUPOPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_grupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COD_MARCA_PRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODSUBGRUPOPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRICAOSUBGRUPOPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cod_forn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cARACTADICPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODBARRASPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODONUPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLASSETOXICPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_uni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_uni2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mETAANUALPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODREDUZIDOPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tABPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mETASEMESTRALPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_estoque_atual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSTOQUERESERVADOPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSTOQUEMINIMOPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSTOQUEENCOMENDADOPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSTOQUEMAXIMOPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_estoque_medio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_custo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTOMEDPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_valor_venda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTATUSPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.vALORVENDAREVENDPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORPROMOCAOPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oUTROVALORPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lUCROPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IVA_PRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uLTREAJPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODRECEITAPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iCMSSNPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aLIQUOTAICMSPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEDUCAOFORAPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aLIQUOTAIPIPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pISPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOFINSPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dsProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PRODUTOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // datProdutos
            // 
            this.datProdutos.DeleteCommand = this.fbCommand4;
            this.datProdutos.InsertCommand = this.fbCommand2;
            this.datProdutos.SelectCommand = this.fbCommand1;
            this.datProdutos.UpdateCommand = this.fbCommand3;
            // 
            // fbCommand4
            // 
            this.fbCommand4.CommandTimeout = 30;
            // 
            // fbCommand2
            // 
            this.fbCommand2.CommandTimeout = 30;
            // 
            // fbCommand1
            // 
            this.fbCommand1.CommandText = "select * from produtos order by descricao_produto";
            this.fbCommand1.CommandTimeout = 30;
            this.fbCommand1.Connection = this.fbConnection1;
            // 
            // fbConnection1
            // 
            this.fbConnection1.ConnectionString = resources.GetString("fbConnection1.ConnectionString");
            // 
            // fbCommand3
            // 
            this.fbCommand3.CommandTimeout = 30;
            // 
            // dsProdutos
            // 
            this.dsProdutos.DataSetName = "dsProdutos";
            this.dsProdutos.Namespace = "http://www.tempuri.org/dsProdutos.xsd";
            this.dsProdutos.Tables.AddRange(new System.Data.DataTable[] {
            this.PRODUTOS});
            // 
            // PRODUTOS
            // 
            this.PRODUTOS.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_PRODUTO,
            this.COD_GRUPO_PRODUTO,
            this.DESCRICAO_GRUPO_PRODUTO,
            this.COD_SUB_GRUPO_PRODUTO,
            this.DESCRICAO_SUB_GRUPO_PRODUTO,
            this.DESCRICAO_PRODUTO,
            this.CARACT_ADIC_PRODUTO,
            this.COD_BARRAS_PRODUTO,
            this.COD_ONU_PRODUTO,
            this.CLASSE_TOXIC_PRODUTO,
            this.COD_UNIDADE_PRODUTO,
            this.DESCRICAO_UNIDADE_PRODUTO,
            this.META_ANUAL_PRODUTO,
            this.COD_REDUZIDO_PRODUTO,
            this.TAB_PRODUTO,
            this.META_SEMESTRAL_PRODUTO,
            this.ESTOQUE_ATUAL_PRODUTO,
            this.ESTOQUE_RESERVADO_PRODUTO,
            this.ESTOQUE_MINIMO_PRODUTO,
            this.ESTOQUE_ENCOMENDADO_PRODUTO,
            this.ESTOQUE_MAXIMO_PRODUTO,
            this.ESTOQUE_MEDIO_PRODUTO,
            this.CUSTO_PRODUTO,
            this.CUSTO_MED_PRODUTO,
            this.VALOR_VENDA_PRODUTOR_PRODUTO,
            this.VALOR_VENDA_REVEND_PRODUTO,
            this.VALOR_PROMOCAO_PRODUTO,
            this.OUTRO_VALOR_PRODUTO,
            this.LUCRO_PRODUTO,
            this.ULT_REAJ_PRODUTO,
            this.PROD_RECEITA_PRODUTO,
            this.STATUS_PRODUTO,
            this.ICMS_S_N_PRODUTO,
            this.ALIQUOTA_ICMS_PRODUTO,
            this.REDUCAO_FORA_PRODUTO,
            this.ALIQUOTA_IPI_PRODUTO,
            this.PIS_PRODUTO,
            this.COFINS_PRODUTO,
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn6,
            this.dataColumn7});
            this.PRODUTOS.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_PRODUTO"}, true)});
            this.PRODUTOS.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_PRODUTO};
            this.PRODUTOS.TableName = "PRODUTOS";
            // 
            // COD_PRODUTO
            // 
            this.COD_PRODUTO.AllowDBNull = false;
            this.COD_PRODUTO.ColumnName = "COD_PRODUTO";
            this.COD_PRODUTO.DataType = typeof(int);
            // 
            // COD_GRUPO_PRODUTO
            // 
            this.COD_GRUPO_PRODUTO.ColumnName = "COD_GRUPO_PRODUTO";
            this.COD_GRUPO_PRODUTO.DataType = typeof(int);
            // 
            // DESCRICAO_GRUPO_PRODUTO
            // 
            this.DESCRICAO_GRUPO_PRODUTO.ColumnName = "DESCRICAO_GRUPO_PRODUTO";
            this.DESCRICAO_GRUPO_PRODUTO.MaxLength = 100;
            // 
            // COD_SUB_GRUPO_PRODUTO
            // 
            this.COD_SUB_GRUPO_PRODUTO.ColumnName = "COD_SUB_GRUPO_PRODUTO";
            this.COD_SUB_GRUPO_PRODUTO.DataType = typeof(int);
            // 
            // DESCRICAO_SUB_GRUPO_PRODUTO
            // 
            this.DESCRICAO_SUB_GRUPO_PRODUTO.ColumnName = "DESCRICAO_SUB_GRUPO_PRODUTO";
            this.DESCRICAO_SUB_GRUPO_PRODUTO.MaxLength = 100;
            // 
            // DESCRICAO_PRODUTO
            // 
            this.DESCRICAO_PRODUTO.ColumnName = "DESCRICAO_PRODUTO";
            this.DESCRICAO_PRODUTO.MaxLength = 200;
            // 
            // CARACT_ADIC_PRODUTO
            // 
            this.CARACT_ADIC_PRODUTO.ColumnName = "CARACT_ADIC_PRODUTO";
            this.CARACT_ADIC_PRODUTO.MaxLength = 200;
            // 
            // COD_BARRAS_PRODUTO
            // 
            this.COD_BARRAS_PRODUTO.ColumnName = "COD_BARRAS_PRODUTO";
            this.COD_BARRAS_PRODUTO.MaxLength = 200;
            // 
            // COD_ONU_PRODUTO
            // 
            this.COD_ONU_PRODUTO.ColumnName = "COD_ONU_PRODUTO";
            this.COD_ONU_PRODUTO.MaxLength = 100;
            // 
            // CLASSE_TOXIC_PRODUTO
            // 
            this.CLASSE_TOXIC_PRODUTO.ColumnName = "CLASSE_TOXIC_PRODUTO";
            this.CLASSE_TOXIC_PRODUTO.MaxLength = 100;
            // 
            // COD_UNIDADE_PRODUTO
            // 
            this.COD_UNIDADE_PRODUTO.ColumnName = "COD_UNIDADE_PRODUTO";
            this.COD_UNIDADE_PRODUTO.MaxLength = 10;
            // 
            // DESCRICAO_UNIDADE_PRODUTO
            // 
            this.DESCRICAO_UNIDADE_PRODUTO.ColumnName = "DESCRICAO_UNIDADE_PRODUTO";
            this.DESCRICAO_UNIDADE_PRODUTO.MaxLength = 50;
            // 
            // META_ANUAL_PRODUTO
            // 
            this.META_ANUAL_PRODUTO.ColumnName = "META_ANUAL_PRODUTO";
            this.META_ANUAL_PRODUTO.DataType = typeof(double);
            // 
            // COD_REDUZIDO_PRODUTO
            // 
            this.COD_REDUZIDO_PRODUTO.ColumnName = "COD_REDUZIDO_PRODUTO";
            this.COD_REDUZIDO_PRODUTO.MaxLength = 100;
            // 
            // TAB_PRODUTO
            // 
            this.TAB_PRODUTO.ColumnName = "TAB_PRODUTO";
            this.TAB_PRODUTO.DataType = typeof(int);
            // 
            // META_SEMESTRAL_PRODUTO
            // 
            this.META_SEMESTRAL_PRODUTO.ColumnName = "META_SEMESTRAL_PRODUTO";
            this.META_SEMESTRAL_PRODUTO.DataType = typeof(double);
            // 
            // ESTOQUE_ATUAL_PRODUTO
            // 
            this.ESTOQUE_ATUAL_PRODUTO.ColumnName = "ESTOQUE_ATUAL_PRODUTO";
            this.ESTOQUE_ATUAL_PRODUTO.DataType = typeof(double);
            // 
            // ESTOQUE_RESERVADO_PRODUTO
            // 
            this.ESTOQUE_RESERVADO_PRODUTO.ColumnName = "ESTOQUE_RESERVADO_PRODUTO";
            this.ESTOQUE_RESERVADO_PRODUTO.DataType = typeof(double);
            // 
            // ESTOQUE_MINIMO_PRODUTO
            // 
            this.ESTOQUE_MINIMO_PRODUTO.ColumnName = "ESTOQUE_MINIMO_PRODUTO";
            this.ESTOQUE_MINIMO_PRODUTO.DataType = typeof(double);
            // 
            // ESTOQUE_ENCOMENDADO_PRODUTO
            // 
            this.ESTOQUE_ENCOMENDADO_PRODUTO.ColumnName = "ESTOQUE_ENCOMENDADO_PRODUTO";
            this.ESTOQUE_ENCOMENDADO_PRODUTO.DataType = typeof(double);
            // 
            // ESTOQUE_MAXIMO_PRODUTO
            // 
            this.ESTOQUE_MAXIMO_PRODUTO.ColumnName = "ESTOQUE_MAXIMO_PRODUTO";
            this.ESTOQUE_MAXIMO_PRODUTO.DataType = typeof(double);
            // 
            // ESTOQUE_MEDIO_PRODUTO
            // 
            this.ESTOQUE_MEDIO_PRODUTO.ColumnName = "ESTOQUE_MEDIO_PRODUTO";
            this.ESTOQUE_MEDIO_PRODUTO.DataType = typeof(double);
            // 
            // CUSTO_PRODUTO
            // 
            this.CUSTO_PRODUTO.ColumnName = "CUSTO_PRODUTO";
            this.CUSTO_PRODUTO.DataType = typeof(double);
            // 
            // CUSTO_MED_PRODUTO
            // 
            this.CUSTO_MED_PRODUTO.ColumnName = "CUSTO_MED_PRODUTO";
            this.CUSTO_MED_PRODUTO.DataType = typeof(double);
            // 
            // VALOR_VENDA_PRODUTOR_PRODUTO
            // 
            this.VALOR_VENDA_PRODUTOR_PRODUTO.ColumnName = "VALOR_VENDA_PRODUTOR_PRODUTO";
            this.VALOR_VENDA_PRODUTOR_PRODUTO.DataType = typeof(double);
            // 
            // VALOR_VENDA_REVEND_PRODUTO
            // 
            this.VALOR_VENDA_REVEND_PRODUTO.ColumnName = "VALOR_VENDA_REVEND_PRODUTO";
            this.VALOR_VENDA_REVEND_PRODUTO.DataType = typeof(double);
            // 
            // VALOR_PROMOCAO_PRODUTO
            // 
            this.VALOR_PROMOCAO_PRODUTO.ColumnName = "VALOR_PROMOCAO_PRODUTO";
            this.VALOR_PROMOCAO_PRODUTO.DataType = typeof(double);
            // 
            // OUTRO_VALOR_PRODUTO
            // 
            this.OUTRO_VALOR_PRODUTO.ColumnName = "OUTRO_VALOR_PRODUTO";
            this.OUTRO_VALOR_PRODUTO.DataType = typeof(double);
            // 
            // LUCRO_PRODUTO
            // 
            this.LUCRO_PRODUTO.ColumnName = "LUCRO_PRODUTO";
            this.LUCRO_PRODUTO.DataType = typeof(double);
            // 
            // ULT_REAJ_PRODUTO
            // 
            this.ULT_REAJ_PRODUTO.ColumnName = "ULT_REAJ_PRODUTO";
            this.ULT_REAJ_PRODUTO.DataType = typeof(System.DateTime);
            // 
            // PROD_RECEITA_PRODUTO
            // 
            this.PROD_RECEITA_PRODUTO.ColumnName = "PROD_RECEITA_PRODUTO";
            this.PROD_RECEITA_PRODUTO.DataType = typeof(int);
            // 
            // STATUS_PRODUTO
            // 
            this.STATUS_PRODUTO.ColumnName = "STATUS_PRODUTO";
            this.STATUS_PRODUTO.MaxLength = 10;
            // 
            // ICMS_S_N_PRODUTO
            // 
            this.ICMS_S_N_PRODUTO.ColumnName = "ICMS_S_N_PRODUTO";
            this.ICMS_S_N_PRODUTO.DataType = typeof(int);
            // 
            // ALIQUOTA_ICMS_PRODUTO
            // 
            this.ALIQUOTA_ICMS_PRODUTO.ColumnName = "ALIQUOTA_ICMS_PRODUTO";
            this.ALIQUOTA_ICMS_PRODUTO.DataType = typeof(double);
            // 
            // REDUCAO_FORA_PRODUTO
            // 
            this.REDUCAO_FORA_PRODUTO.ColumnName = "REDUCAO_FORA_PRODUTO";
            this.REDUCAO_FORA_PRODUTO.DataType = typeof(double);
            // 
            // ALIQUOTA_IPI_PRODUTO
            // 
            this.ALIQUOTA_IPI_PRODUTO.ColumnName = "ALIQUOTA_IPI_PRODUTO";
            this.ALIQUOTA_IPI_PRODUTO.DataType = typeof(double);
            // 
            // PIS_PRODUTO
            // 
            this.PIS_PRODUTO.ColumnName = "PIS_PRODUTO";
            this.PIS_PRODUTO.DataType = typeof(int);
            // 
            // COFINS_PRODUTO
            // 
            this.COFINS_PRODUTO.ColumnName = "COFINS_PRODUTO";
            this.COFINS_PRODUTO.DataType = typeof(int);
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "COD_MARCA_PRODUTO";
            this.dataColumn1.DataType = typeof(int);
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "MARCA_PRODUTO";
            this.dataColumn2.MaxLength = 100;
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "IVA_PRODUTO";
            this.dataColumn3.DataType = typeof(double);
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "NCM_PRODUTO";
            this.dataColumn4.MaxLength = 50;
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "DESCRICAO_ITEM_PRODUTO";
            this.dataColumn5.MaxLength = 200;
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "COD_FORNECEDOR_PRODUTO";
            this.dataColumn6.MaxLength = 50;
            // 
            // dataColumn7
            // 
            this.dataColumn7.ColumnName = "ORIGEM_PRODUTO";
            this.dataColumn7.MaxLength = 100;
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AutoGenerateColumns = false;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_cod,
            this.cODGRUPOPRODUTODataGridViewTextBoxColumn,
            this.col_grupo,
            this.COD_MARCA_PRODUTO,
            this.col_marca,
            this.cODSUBGRUPOPRODUTODataGridViewTextBoxColumn,
            this.dESCRICAOSUBGRUPOPRODUTODataGridViewTextBoxColumn,
            this.col_cod_forn,
            this.col_nome,
            this.col_item,
            this.cARACTADICPRODUTODataGridViewTextBoxColumn,
            this.cODBARRASPRODUTODataGridViewTextBoxColumn,
            this.cODONUPRODUTODataGridViewTextBoxColumn,
            this.cLASSETOXICPRODUTODataGridViewTextBoxColumn,
            this.col_uni,
            this.col_uni2,
            this.mETAANUALPRODUTODataGridViewTextBoxColumn,
            this.cODREDUZIDOPRODUTODataGridViewTextBoxColumn,
            this.tABPRODUTODataGridViewTextBoxColumn,
            this.mETASEMESTRALPRODUTODataGridViewTextBoxColumn,
            this.col_estoque_atual,
            this.eSTOQUERESERVADOPRODUTODataGridViewTextBoxColumn,
            this.eSTOQUEMINIMOPRODUTODataGridViewTextBoxColumn,
            this.eSTOQUEENCOMENDADOPRODUTODataGridViewTextBoxColumn,
            this.eSTOQUEMAXIMOPRODUTODataGridViewTextBoxColumn,
            this.col_estoque_medio,
            this.col_custo,
            this.cUSTOMEDPRODUTODataGridViewTextBoxColumn,
            this.col_valor_venda,
            this.sTATUSPRODUTODataGridViewTextBoxColumn,
            this.vALORVENDAREVENDPRODUTODataGridViewTextBoxColumn,
            this.vALORPROMOCAOPRODUTODataGridViewTextBoxColumn,
            this.oUTROVALORPRODUTODataGridViewTextBoxColumn,
            this.lUCROPRODUTODataGridViewTextBoxColumn,
            this.IVA_PRODUTO,
            this.uLTREAJPRODUTODataGridViewTextBoxColumn,
            this.pRODRECEITAPRODUTODataGridViewTextBoxColumn,
            this.iCMSSNPRODUTODataGridViewTextBoxColumn,
            this.aLIQUOTAICMSPRODUTODataGridViewTextBoxColumn,
            this.rEDUCAOFORAPRODUTODataGridViewTextBoxColumn,
            this.aLIQUOTAIPIPRODUTODataGridViewTextBoxColumn,
            this.pISPRODUTODataGridViewTextBoxColumn,
            this.cOFINSPRODUTODataGridViewTextBoxColumn});
            this.dgvProdutos.DataMember = "PRODUTOS";
            this.dgvProdutos.DataSource = this.dsProdutos;
            this.dgvProdutos.Location = new System.Drawing.Point(12, 88);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(1130, 395);
            this.dgvProdutos.TabIndex = 0;
            this.dgvProdutos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellDoubleClick);
            this.dgvProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(189, 526);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_cod_forn);
            this.groupBox1.Controls.Add(this.cb_status);
            this.groupBox1.Controls.Add(this.tb_descricao_item);
            this.groupBox1.Controls.Add(this.tb_descricao);
            this.groupBox1.Controls.Add(this.tb_sub_grupo);
            this.groupBox1.Controls.Add(this.tb_grupo);
            this.groupBox1.Controls.Add(this.tb_cod_grupo);
            this.groupBox1.Controls.Add(this.tb_cod);
            this.groupBox1.Location = new System.Drawing.Point(12, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1136, 36);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // tb_cod_forn
            // 
            this.tb_cod_forn.Location = new System.Drawing.Point(321, 12);
            this.tb_cod_forn.Name = "tb_cod_forn";
            this.tb_cod_forn.Size = new System.Drawing.Size(101, 20);
            this.tb_cod_forn.TabIndex = 7;
            this.tb_cod_forn.TextChanged += new System.EventHandler(this.tb_cod_forn_TextChanged);
            // 
            // cb_status
            // 
            this.cb_status.AutoSize = true;
            this.cb_status.Location = new System.Drawing.Point(983, 22);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(15, 14);
            this.cb_status.TabIndex = 6;
            this.cb_status.UseVisualStyleBackColor = true;
            this.cb_status.CheckedChanged += new System.EventHandler(this.cb_status_CheckedChanged);
            // 
            // tb_descricao_item
            // 
            this.tb_descricao_item.Location = new System.Drawing.Point(621, 12);
            this.tb_descricao_item.Name = "tb_descricao_item";
            this.tb_descricao_item.Size = new System.Drawing.Size(199, 20);
            this.tb_descricao_item.TabIndex = 5;
            this.tb_descricao_item.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // tb_descricao
            // 
            this.tb_descricao.Location = new System.Drawing.Point(421, 12);
            this.tb_descricao.Name = "tb_descricao";
            this.tb_descricao.Size = new System.Drawing.Size(200, 20);
            this.tb_descricao.TabIndex = 5;
            this.tb_descricao.TextChanged += new System.EventHandler(this.tb_descricao_TextChanged);
            // 
            // tb_sub_grupo
            // 
            this.tb_sub_grupo.Location = new System.Drawing.Point(242, 12);
            this.tb_sub_grupo.Name = "tb_sub_grupo";
            this.tb_sub_grupo.Size = new System.Drawing.Size(80, 20);
            this.tb_sub_grupo.TabIndex = 4;
            this.tb_sub_grupo.TextChanged += new System.EventHandler(this.tb_sub_grupo_TextChanged);
            // 
            // tb_grupo
            // 
            this.tb_grupo.Location = new System.Drawing.Point(122, 12);
            this.tb_grupo.Name = "tb_grupo";
            this.tb_grupo.Size = new System.Drawing.Size(80, 20);
            this.tb_grupo.TabIndex = 3;
            this.tb_grupo.TextChanged += new System.EventHandler(this.tb_grupo_TextChanged);
            // 
            // tb_cod_grupo
            // 
            this.tb_cod_grupo.Location = new System.Drawing.Point(82, 12);
            this.tb_cod_grupo.Name = "tb_cod_grupo";
            this.tb_cod_grupo.Size = new System.Drawing.Size(40, 20);
            this.tb_cod_grupo.TabIndex = 1;
            this.tb_cod_grupo.TextChanged += new System.EventHandler(this.tb_cod_grupo_TextChanged);
            // 
            // tb_cod
            // 
            this.tb_cod.Location = new System.Drawing.Point(42, 12);
            this.tb_cod.Name = "tb_cod";
            this.tb_cod.Size = new System.Drawing.Size(40, 20);
            this.tb_cod.TabIndex = 0;
            this.tb_cod.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbcod_sub_grupo
            // 
            this.tbcod_sub_grupo.Location = new System.Drawing.Point(214, 64);
            this.tbcod_sub_grupo.Name = "tbcod_sub_grupo";
            this.tbcod_sub_grupo.Size = new System.Drawing.Size(40, 20);
            this.tbcod_sub_grupo.TabIndex = 3;
            this.tbcod_sub_grupo.TextChanged += new System.EventHandler(this.tbcod_sub_grupo_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label20.Location = new System.Drawing.Point(262, 3);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(423, 46);
            this.label20.TabIndex = 119;
            this.label20.Text = "LOCALIZA PRODUTO";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(270, 526);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 120;
            this.button2.Text = "Criar Novo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(510, 497);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 25);
            this.label1.TabIndex = 121;
            this.label1.Text = "Valor Estoque Venda:";
            // 
            // tb_valor_estoque
            // 
            this.tb_valor_estoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_valor_estoque.Location = new System.Drawing.Point(765, 495);
            this.tb_valor_estoque.Name = "tb_valor_estoque";
            this.tb_valor_estoque.Size = new System.Drawing.Size(184, 31);
            this.tb_valor_estoque.TabIndex = 122;
            // 
            // cODPRODUTODataGridViewTextBoxColumn
            // 
            this.cODPRODUTODataGridViewTextBoxColumn.DataPropertyName = "COD_PRODUTO";
            this.cODPRODUTODataGridViewTextBoxColumn.HeaderText = "COD_PRODUTO";
            this.cODPRODUTODataGridViewTextBoxColumn.Name = "cODPRODUTODataGridViewTextBoxColumn";
            // 
            // cODGRUPOPRODUTODataGridViewTextBoxColumn1
            // 
            this.cODGRUPOPRODUTODataGridViewTextBoxColumn1.DataPropertyName = "COD_GRUPO_PRODUTO";
            this.cODGRUPOPRODUTODataGridViewTextBoxColumn1.HeaderText = "COD_GRUPO_PRODUTO";
            this.cODGRUPOPRODUTODataGridViewTextBoxColumn1.Name = "cODGRUPOPRODUTODataGridViewTextBoxColumn1";
            // 
            // dESCRICAOGRUPOPRODUTODataGridViewTextBoxColumn
            // 
            this.dESCRICAOGRUPOPRODUTODataGridViewTextBoxColumn.DataPropertyName = "DESCRICAO_GRUPO_PRODUTO";
            this.dESCRICAOGRUPOPRODUTODataGridViewTextBoxColumn.HeaderText = "DESCRICAO_GRUPO_PRODUTO";
            this.dESCRICAOGRUPOPRODUTODataGridViewTextBoxColumn.Name = "dESCRICAOGRUPOPRODUTODataGridViewTextBoxColumn";
            // 
            // cODSUBGRUPOPRODUTODataGridViewTextBoxColumn1
            // 
            this.cODSUBGRUPOPRODUTODataGridViewTextBoxColumn1.DataPropertyName = "COD_SUB_GRUPO_PRODUTO";
            this.cODSUBGRUPOPRODUTODataGridViewTextBoxColumn1.HeaderText = "COD_SUB_GRUPO_PRODUTO";
            this.cODSUBGRUPOPRODUTODataGridViewTextBoxColumn1.Name = "cODSUBGRUPOPRODUTODataGridViewTextBoxColumn1";
            // 
            // dESCRICAOSUBGRUPOPRODUTODataGridViewTextBoxColumn1
            // 
            this.dESCRICAOSUBGRUPOPRODUTODataGridViewTextBoxColumn1.DataPropertyName = "DESCRICAO_SUB_GRUPO_PRODUTO";
            this.dESCRICAOSUBGRUPOPRODUTODataGridViewTextBoxColumn1.HeaderText = "DESCRICAO_SUB_GRUPO_PRODUTO";
            this.dESCRICAOSUBGRUPOPRODUTODataGridViewTextBoxColumn1.Name = "dESCRICAOSUBGRUPOPRODUTODataGridViewTextBoxColumn1";
            // 
            // dESCRICAOPRODUTODataGridViewTextBoxColumn
            // 
            this.dESCRICAOPRODUTODataGridViewTextBoxColumn.DataPropertyName = "DESCRICAO_PRODUTO";
            this.dESCRICAOPRODUTODataGridViewTextBoxColumn.HeaderText = "DESCRICAO_PRODUTO";
            this.dESCRICAOPRODUTODataGridViewTextBoxColumn.Name = "dESCRICAOPRODUTODataGridViewTextBoxColumn";
            // 
            // cARACTADICPRODUTODataGridViewTextBoxColumn1
            // 
            this.cARACTADICPRODUTODataGridViewTextBoxColumn1.DataPropertyName = "CARACT_ADIC_PRODUTO";
            this.cARACTADICPRODUTODataGridViewTextBoxColumn1.HeaderText = "CARACT_ADIC_PRODUTO";
            this.cARACTADICPRODUTODataGridViewTextBoxColumn1.Name = "cARACTADICPRODUTODataGridViewTextBoxColumn1";
            // 
            // cODBARRASPRODUTODataGridViewTextBoxColumn1
            // 
            this.cODBARRASPRODUTODataGridViewTextBoxColumn1.DataPropertyName = "COD_BARRAS_PRODUTO";
            this.cODBARRASPRODUTODataGridViewTextBoxColumn1.HeaderText = "COD_BARRAS_PRODUTO";
            this.cODBARRASPRODUTODataGridViewTextBoxColumn1.Name = "cODBARRASPRODUTODataGridViewTextBoxColumn1";
            // 
            // cODONUPRODUTODataGridViewTextBoxColumn1
            // 
            this.cODONUPRODUTODataGridViewTextBoxColumn1.DataPropertyName = "COD_ONU_PRODUTO";
            this.cODONUPRODUTODataGridViewTextBoxColumn1.HeaderText = "COD_ONU_PRODUTO";
            this.cODONUPRODUTODataGridViewTextBoxColumn1.Name = "cODONUPRODUTODataGridViewTextBoxColumn1";
            // 
            // cLASSETOXICPRODUTODataGridViewTextBoxColumn1
            // 
            this.cLASSETOXICPRODUTODataGridViewTextBoxColumn1.DataPropertyName = "CLASSE_TOXIC_PRODUTO";
            this.cLASSETOXICPRODUTODataGridViewTextBoxColumn1.HeaderText = "CLASSE_TOXIC_PRODUTO";
            this.cLASSETOXICPRODUTODataGridViewTextBoxColumn1.Name = "cLASSETOXICPRODUTODataGridViewTextBoxColumn1";
            // 
            // cODUNIDADEPRODUTODataGridViewTextBoxColumn
            // 
            this.cODUNIDADEPRODUTODataGridViewTextBoxColumn.DataPropertyName = "COD_UNIDADE_PRODUTO";
            this.cODUNIDADEPRODUTODataGridViewTextBoxColumn.HeaderText = "COD_UNIDADE_PRODUTO";
            this.cODUNIDADEPRODUTODataGridViewTextBoxColumn.Name = "cODUNIDADEPRODUTODataGridViewTextBoxColumn";
            // 
            // dESCRICAOUNIDADEPRODUTODataGridViewTextBoxColumn
            // 
            this.dESCRICAOUNIDADEPRODUTODataGridViewTextBoxColumn.DataPropertyName = "DESCRICAO_UNIDADE_PRODUTO";
            this.dESCRICAOUNIDADEPRODUTODataGridViewTextBoxColumn.HeaderText = "DESCRICAO_UNIDADE_PRODUTO";
            this.dESCRICAOUNIDADEPRODUTODataGridViewTextBoxColumn.Name = "dESCRICAOUNIDADEPRODUTODataGridViewTextBoxColumn";
            // 
            // mETAANUALPRODUTODataGridViewTextBoxColumn1
            // 
            this.mETAANUALPRODUTODataGridViewTextBoxColumn1.DataPropertyName = "META_ANUAL_PRODUTO";
            this.mETAANUALPRODUTODataGridViewTextBoxColumn1.HeaderText = "META_ANUAL_PRODUTO";
            this.mETAANUALPRODUTODataGridViewTextBoxColumn1.Name = "mETAANUALPRODUTODataGridViewTextBoxColumn1";
            // 
            // cODREDUZIDOPRODUTODataGridViewTextBoxColumn1
            // 
            this.cODREDUZIDOPRODUTODataGridViewTextBoxColumn1.DataPropertyName = "COD_REDUZIDO_PRODUTO";
            this.cODREDUZIDOPRODUTODataGridViewTextBoxColumn1.HeaderText = "COD_REDUZIDO_PRODUTO";
            this.cODREDUZIDOPRODUTODataGridViewTextBoxColumn1.Name = "cODREDUZIDOPRODUTODataGridViewTextBoxColumn1";
            // 
            // tABPRODUTODataGridViewTextBoxColumn1
            // 
            this.tABPRODUTODataGridViewTextBoxColumn1.DataPropertyName = "TAB_PRODUTO";
            this.tABPRODUTODataGridViewTextBoxColumn1.HeaderText = "TAB_PRODUTO";
            this.tABPRODUTODataGridViewTextBoxColumn1.Name = "tABPRODUTODataGridViewTextBoxColumn1";
            // 
            // mETASEMESTRALPRODUTODataGridViewTextBoxColumn1
            // 
            this.mETASEMESTRALPRODUTODataGridViewTextBoxColumn1.DataPropertyName = "META_SEMESTRAL_PRODUTO";
            this.mETASEMESTRALPRODUTODataGridViewTextBoxColumn1.HeaderText = "META_SEMESTRAL_PRODUTO";
            this.mETASEMESTRALPRODUTODataGridViewTextBoxColumn1.Name = "mETASEMESTRALPRODUTODataGridViewTextBoxColumn1";
            // 
            // eSTOQUEATUALPRODUTODataGridViewTextBoxColumn1
            // 
            this.eSTOQUEATUALPRODUTODataGridViewTextBoxColumn1.DataPropertyName = "ESTOQUE_ATUAL_PRODUTO";
            this.eSTOQUEATUALPRODUTODataGridViewTextBoxColumn1.HeaderText = "ESTOQUE_ATUAL_PRODUTO";
            this.eSTOQUEATUALPRODUTODataGridViewTextBoxColumn1.Name = "eSTOQUEATUALPRODUTODataGridViewTextBoxColumn1";
            // 
            // eSTOQUERESERVADOPRODUTODataGridViewTextBoxColumn1
            // 
            this.eSTOQUERESERVADOPRODUTODataGridViewTextBoxColumn1.DataPropertyName = "ESTOQUE_RESERVADO_PRODUTO";
            this.eSTOQUERESERVADOPRODUTODataGridViewTextBoxColumn1.HeaderText = "ESTOQUE_RESERVADO_PRODUTO";
            this.eSTOQUERESERVADOPRODUTODataGridViewTextBoxColumn1.Name = "eSTOQUERESERVADOPRODUTODataGridViewTextBoxColumn1";
            // 
            // eSTOQUEMINIMOPRODUTODataGridViewTextBoxColumn1
            // 
            this.eSTOQUEMINIMOPRODUTODataGridViewTextBoxColumn1.DataPropertyName = "ESTOQUE_MINIMO_PRODUTO";
            this.eSTOQUEMINIMOPRODUTODataGridViewTextBoxColumn1.HeaderText = "ESTOQUE_MINIMO_PRODUTO";
            this.eSTOQUEMINIMOPRODUTODataGridViewTextBoxColumn1.Name = "eSTOQUEMINIMOPRODUTODataGridViewTextBoxColumn1";
            // 
            // eSTOQUEENCOMENDADOPRODUTODataGridViewTextBoxColumn1
            // 
            this.eSTOQUEENCOMENDADOPRODUTODataGridViewTextBoxColumn1.DataPropertyName = "ESTOQUE_ENCOMENDADO_PRODUTO";
            this.eSTOQUEENCOMENDADOPRODUTODataGridViewTextBoxColumn1.HeaderText = "ESTOQUE_ENCOMENDADO_PRODUTO";
            this.eSTOQUEENCOMENDADOPRODUTODataGridViewTextBoxColumn1.Name = "eSTOQUEENCOMENDADOPRODUTODataGridViewTextBoxColumn1";
            // 
            // eSTOQUEMAXIMOPRODUTODataGridViewTextBoxColumn1
            // 
            this.eSTOQUEMAXIMOPRODUTODataGridViewTextBoxColumn1.DataPropertyName = "ESTOQUE_MAXIMO_PRODUTO";
            this.eSTOQUEMAXIMOPRODUTODataGridViewTextBoxColumn1.HeaderText = "ESTOQUE_MAXIMO_PRODUTO";
            this.eSTOQUEMAXIMOPRODUTODataGridViewTextBoxColumn1.Name = "eSTOQUEMAXIMOPRODUTODataGridViewTextBoxColumn1";
            // 
            // eSTOQUEMEDIOPRODUTODataGridViewTextBoxColumn
            // 
            this.eSTOQUEMEDIOPRODUTODataGridViewTextBoxColumn.DataPropertyName = "ESTOQUE_MEDIO_PRODUTO";
            this.eSTOQUEMEDIOPRODUTODataGridViewTextBoxColumn.HeaderText = "ESTOQUE_MEDIO_PRODUTO";
            this.eSTOQUEMEDIOPRODUTODataGridViewTextBoxColumn.Name = "eSTOQUEMEDIOPRODUTODataGridViewTextBoxColumn";
            // 
            // cUSTOPRODUTODataGridViewTextBoxColumn1
            // 
            this.cUSTOPRODUTODataGridViewTextBoxColumn1.DataPropertyName = "CUSTO_PRODUTO";
            this.cUSTOPRODUTODataGridViewTextBoxColumn1.HeaderText = "CUSTO_PRODUTO";
            this.cUSTOPRODUTODataGridViewTextBoxColumn1.Name = "cUSTOPRODUTODataGridViewTextBoxColumn1";
            // 
            // cUSTOMEDPRODUTODataGridViewTextBoxColumn1
            // 
            this.cUSTOMEDPRODUTODataGridViewTextBoxColumn1.DataPropertyName = "CUSTO_MED_PRODUTO";
            this.cUSTOMEDPRODUTODataGridViewTextBoxColumn1.HeaderText = "CUSTO_MED_PRODUTO";
            this.cUSTOMEDPRODUTODataGridViewTextBoxColumn1.Name = "cUSTOMEDPRODUTODataGridViewTextBoxColumn1";
            // 
            // vALORVENDAPRODUTORPRODUTODataGridViewTextBoxColumn
            // 
            this.vALORVENDAPRODUTORPRODUTODataGridViewTextBoxColumn.DataPropertyName = "VALOR_VENDA_PRODUTOR_PRODUTO";
            this.vALORVENDAPRODUTORPRODUTODataGridViewTextBoxColumn.HeaderText = "VALOR_VENDA_PRODUTOR_PRODUTO";
            this.vALORVENDAPRODUTORPRODUTODataGridViewTextBoxColumn.Name = "vALORVENDAPRODUTORPRODUTODataGridViewTextBoxColumn";
            // 
            // vALORVENDAREVENDPRODUTODataGridViewTextBoxColumn1
            // 
            this.vALORVENDAREVENDPRODUTODataGridViewTextBoxColumn1.DataPropertyName = "VALOR_VENDA_REVEND_PRODUTO";
            this.vALORVENDAREVENDPRODUTODataGridViewTextBoxColumn1.HeaderText = "VALOR_VENDA_REVEND_PRODUTO";
            this.vALORVENDAREVENDPRODUTODataGridViewTextBoxColumn1.Name = "vALORVENDAREVENDPRODUTODataGridViewTextBoxColumn1";
            // 
            // vALORPROMOCAOPRODUTODataGridViewTextBoxColumn1
            // 
            this.vALORPROMOCAOPRODUTODataGridViewTextBoxColumn1.DataPropertyName = "VALOR_PROMOCAO_PRODUTO";
            this.vALORPROMOCAOPRODUTODataGridViewTextBoxColumn1.HeaderText = "VALOR_PROMOCAO_PRODUTO";
            this.vALORPROMOCAOPRODUTODataGridViewTextBoxColumn1.Name = "vALORPROMOCAOPRODUTODataGridViewTextBoxColumn1";
            // 
            // oUTROVALORPRODUTODataGridViewTextBoxColumn1
            // 
            this.oUTROVALORPRODUTODataGridViewTextBoxColumn1.DataPropertyName = "OUTRO_VALOR_PRODUTO";
            this.oUTROVALORPRODUTODataGridViewTextBoxColumn1.HeaderText = "OUTRO_VALOR_PRODUTO";
            this.oUTROVALORPRODUTODataGridViewTextBoxColumn1.Name = "oUTROVALORPRODUTODataGridViewTextBoxColumn1";
            // 
            // lUCROPRODUTODataGridViewTextBoxColumn1
            // 
            this.lUCROPRODUTODataGridViewTextBoxColumn1.DataPropertyName = "LUCRO_PRODUTO";
            this.lUCROPRODUTODataGridViewTextBoxColumn1.HeaderText = "LUCRO_PRODUTO";
            this.lUCROPRODUTODataGridViewTextBoxColumn1.Name = "lUCROPRODUTODataGridViewTextBoxColumn1";
            // 
            // uLTREAJPRODUTODataGridViewTextBoxColumn1
            // 
            this.uLTREAJPRODUTODataGridViewTextBoxColumn1.DataPropertyName = "ULT_REAJ_PRODUTO";
            this.uLTREAJPRODUTODataGridViewTextBoxColumn1.HeaderText = "ULT_REAJ_PRODUTO";
            this.uLTREAJPRODUTODataGridViewTextBoxColumn1.Name = "uLTREAJPRODUTODataGridViewTextBoxColumn1";
            // 
            // pRODRECEITAPRODUTODataGridViewTextBoxColumn1
            // 
            this.pRODRECEITAPRODUTODataGridViewTextBoxColumn1.DataPropertyName = "PROD_RECEITA_PRODUTO";
            this.pRODRECEITAPRODUTODataGridViewTextBoxColumn1.HeaderText = "PROD_RECEITA_PRODUTO";
            this.pRODRECEITAPRODUTODataGridViewTextBoxColumn1.Name = "pRODRECEITAPRODUTODataGridViewTextBoxColumn1";
            // 
            // sTATUSPRODUTODataGridViewTextBoxColumn1
            // 
            this.sTATUSPRODUTODataGridViewTextBoxColumn1.DataPropertyName = "STATUS_PRODUTO";
            this.sTATUSPRODUTODataGridViewTextBoxColumn1.HeaderText = "STATUS_PRODUTO";
            this.sTATUSPRODUTODataGridViewTextBoxColumn1.Name = "sTATUSPRODUTODataGridViewTextBoxColumn1";
            // 
            // iCMSSNPRODUTODataGridViewTextBoxColumn1
            // 
            this.iCMSSNPRODUTODataGridViewTextBoxColumn1.DataPropertyName = "ICMS_S_N_PRODUTO";
            this.iCMSSNPRODUTODataGridViewTextBoxColumn1.HeaderText = "ICMS_S_N_PRODUTO";
            this.iCMSSNPRODUTODataGridViewTextBoxColumn1.Name = "iCMSSNPRODUTODataGridViewTextBoxColumn1";
            // 
            // aLIQUOTAICMSPRODUTODataGridViewTextBoxColumn1
            // 
            this.aLIQUOTAICMSPRODUTODataGridViewTextBoxColumn1.DataPropertyName = "ALIQUOTA_ICMS_PRODUTO";
            this.aLIQUOTAICMSPRODUTODataGridViewTextBoxColumn1.HeaderText = "ALIQUOTA_ICMS_PRODUTO";
            this.aLIQUOTAICMSPRODUTODataGridViewTextBoxColumn1.Name = "aLIQUOTAICMSPRODUTODataGridViewTextBoxColumn1";
            // 
            // rEDUCAOFORAPRODUTODataGridViewTextBoxColumn1
            // 
            this.rEDUCAOFORAPRODUTODataGridViewTextBoxColumn1.DataPropertyName = "REDUCAO_FORA_PRODUTO";
            this.rEDUCAOFORAPRODUTODataGridViewTextBoxColumn1.HeaderText = "REDUCAO_FORA_PRODUTO";
            this.rEDUCAOFORAPRODUTODataGridViewTextBoxColumn1.Name = "rEDUCAOFORAPRODUTODataGridViewTextBoxColumn1";
            // 
            // aLIQUOTAIPIPRODUTODataGridViewTextBoxColumn1
            // 
            this.aLIQUOTAIPIPRODUTODataGridViewTextBoxColumn1.DataPropertyName = "ALIQUOTA_IPI_PRODUTO";
            this.aLIQUOTAIPIPRODUTODataGridViewTextBoxColumn1.HeaderText = "ALIQUOTA_IPI_PRODUTO";
            this.aLIQUOTAIPIPRODUTODataGridViewTextBoxColumn1.Name = "aLIQUOTAIPIPRODUTODataGridViewTextBoxColumn1";
            // 
            // pISPRODUTODataGridViewTextBoxColumn1
            // 
            this.pISPRODUTODataGridViewTextBoxColumn1.DataPropertyName = "PIS_PRODUTO";
            this.pISPRODUTODataGridViewTextBoxColumn1.HeaderText = "PIS_PRODUTO";
            this.pISPRODUTODataGridViewTextBoxColumn1.Name = "pISPRODUTODataGridViewTextBoxColumn1";
            // 
            // cOFINSPRODUTODataGridViewTextBoxColumn1
            // 
            this.cOFINSPRODUTODataGridViewTextBoxColumn1.DataPropertyName = "COFINS_PRODUTO";
            this.cOFINSPRODUTODataGridViewTextBoxColumn1.HeaderText = "COFINS_PRODUTO";
            this.cOFINSPRODUTODataGridViewTextBoxColumn1.Name = "cOFINSPRODUTODataGridViewTextBoxColumn1";
            // 
            // cODMARCAPRODUTODataGridViewTextBoxColumn
            // 
            this.cODMARCAPRODUTODataGridViewTextBoxColumn.DataPropertyName = "COD_MARCA_PRODUTO";
            this.cODMARCAPRODUTODataGridViewTextBoxColumn.HeaderText = "COD_MARCA_PRODUTO";
            this.cODMARCAPRODUTODataGridViewTextBoxColumn.Name = "cODMARCAPRODUTODataGridViewTextBoxColumn";
            // 
            // mARCAPRODUTODataGridViewTextBoxColumn
            // 
            this.mARCAPRODUTODataGridViewTextBoxColumn.DataPropertyName = "MARCA_PRODUTO";
            this.mARCAPRODUTODataGridViewTextBoxColumn.HeaderText = "MARCA_PRODUTO";
            this.mARCAPRODUTODataGridViewTextBoxColumn.Name = "mARCAPRODUTODataGridViewTextBoxColumn";
            // 
            // iVAPRODUTODataGridViewTextBoxColumn
            // 
            this.iVAPRODUTODataGridViewTextBoxColumn.DataPropertyName = "IVA_PRODUTO";
            this.iVAPRODUTODataGridViewTextBoxColumn.HeaderText = "IVA_PRODUTO";
            this.iVAPRODUTODataGridViewTextBoxColumn.Name = "iVAPRODUTODataGridViewTextBoxColumn";
            // 
            // nCMPRODUTODataGridViewTextBoxColumn
            // 
            this.nCMPRODUTODataGridViewTextBoxColumn.DataPropertyName = "NCM_PRODUTO";
            this.nCMPRODUTODataGridViewTextBoxColumn.HeaderText = "NCM_PRODUTO";
            this.nCMPRODUTODataGridViewTextBoxColumn.Name = "nCMPRODUTODataGridViewTextBoxColumn";
            // 
            // dESCRICAOITEMPRODUTODataGridViewTextBoxColumn
            // 
            this.dESCRICAOITEMPRODUTODataGridViewTextBoxColumn.DataPropertyName = "DESCRICAO_ITEM_PRODUTO";
            this.dESCRICAOITEMPRODUTODataGridViewTextBoxColumn.HeaderText = "DESCRICAO_ITEM_PRODUTO";
            this.dESCRICAOITEMPRODUTODataGridViewTextBoxColumn.Name = "dESCRICAOITEMPRODUTODataGridViewTextBoxColumn";
            // 
            // cODFORNECEDORPRODUTODataGridViewTextBoxColumn
            // 
            this.cODFORNECEDORPRODUTODataGridViewTextBoxColumn.DataPropertyName = "COD_FORNECEDOR_PRODUTO";
            this.cODFORNECEDORPRODUTODataGridViewTextBoxColumn.HeaderText = "COD_FORNECEDOR_PRODUTO";
            this.cODFORNECEDORPRODUTODataGridViewTextBoxColumn.Name = "cODFORNECEDORPRODUTODataGridViewTextBoxColumn";
            // 
            // oRIGEMPRODUTODataGridViewTextBoxColumn
            // 
            this.oRIGEMPRODUTODataGridViewTextBoxColumn.DataPropertyName = "ORIGEM_PRODUTO";
            this.oRIGEMPRODUTODataGridViewTextBoxColumn.HeaderText = "ORIGEM_PRODUTO";
            this.oRIGEMPRODUTODataGridViewTextBoxColumn.Name = "oRIGEMPRODUTODataGridViewTextBoxColumn";
            // 
            // tb_valor_compra
            // 
            this.tb_valor_compra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_valor_compra.Location = new System.Drawing.Point(765, 532);
            this.tb_valor_compra.Name = "tb_valor_compra";
            this.tb_valor_compra.Size = new System.Drawing.Size(184, 31);
            this.tb_valor_compra.TabIndex = 124;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(510, 534);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 25);
            this.label2.TabIndex = 123;
            this.label2.Text = "Valor Estoque Compra:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(982, 489);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 74);
            this.button3.TabIndex = 125;
            this.button3.Text = "Somar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // col_cod
            // 
            this.col_cod.DataPropertyName = "COD_PRODUTO";
            this.col_cod.HeaderText = "Cód.";
            this.col_cod.Name = "col_cod";
            this.col_cod.Width = 40;
            // 
            // cODGRUPOPRODUTODataGridViewTextBoxColumn
            // 
            this.cODGRUPOPRODUTODataGridViewTextBoxColumn.DataPropertyName = "COD_GRUPO_PRODUTO";
            this.cODGRUPOPRODUTODataGridViewTextBoxColumn.HeaderText = "Cód. Grupo";
            this.cODGRUPOPRODUTODataGridViewTextBoxColumn.Name = "cODGRUPOPRODUTODataGridViewTextBoxColumn";
            this.cODGRUPOPRODUTODataGridViewTextBoxColumn.Width = 40;
            // 
            // col_grupo
            // 
            this.col_grupo.DataPropertyName = "DESCRICAO_GRUPO_PRODUTO";
            this.col_grupo.HeaderText = "Grupo";
            this.col_grupo.Name = "col_grupo";
            this.col_grupo.Width = 80;
            // 
            // COD_MARCA_PRODUTO
            // 
            this.COD_MARCA_PRODUTO.DataPropertyName = "COD_MARCA_PRODUTO";
            this.COD_MARCA_PRODUTO.HeaderText = "Cód. Marca";
            this.COD_MARCA_PRODUTO.Name = "COD_MARCA_PRODUTO";
            this.COD_MARCA_PRODUTO.Width = 40;
            // 
            // col_marca
            // 
            this.col_marca.DataPropertyName = "MARCA_PRODUTO";
            this.col_marca.HeaderText = "Marca";
            this.col_marca.Name = "col_marca";
            this.col_marca.Width = 80;
            // 
            // cODSUBGRUPOPRODUTODataGridViewTextBoxColumn
            // 
            this.cODSUBGRUPOPRODUTODataGridViewTextBoxColumn.DataPropertyName = "COD_SUB_GRUPO_PRODUTO";
            this.cODSUBGRUPOPRODUTODataGridViewTextBoxColumn.HeaderText = "Cód. Sub Grupo";
            this.cODSUBGRUPOPRODUTODataGridViewTextBoxColumn.Name = "cODSUBGRUPOPRODUTODataGridViewTextBoxColumn";
            this.cODSUBGRUPOPRODUTODataGridViewTextBoxColumn.Visible = false;
            this.cODSUBGRUPOPRODUTODataGridViewTextBoxColumn.Width = 40;
            // 
            // dESCRICAOSUBGRUPOPRODUTODataGridViewTextBoxColumn
            // 
            this.dESCRICAOSUBGRUPOPRODUTODataGridViewTextBoxColumn.DataPropertyName = "DESCRICAO_SUB_GRUPO_PRODUTO";
            this.dESCRICAOSUBGRUPOPRODUTODataGridViewTextBoxColumn.HeaderText = "Sub Grupo";
            this.dESCRICAOSUBGRUPOPRODUTODataGridViewTextBoxColumn.Name = "dESCRICAOSUBGRUPOPRODUTODataGridViewTextBoxColumn";
            this.dESCRICAOSUBGRUPOPRODUTODataGridViewTextBoxColumn.Visible = false;
            this.dESCRICAOSUBGRUPOPRODUTODataGridViewTextBoxColumn.Width = 80;
            // 
            // col_cod_forn
            // 
            this.col_cod_forn.DataPropertyName = "COD_FORNECEDOR_PRODUTO";
            this.col_cod_forn.HeaderText = "Cód. Forn";
            this.col_cod_forn.Name = "col_cod_forn";
            // 
            // col_nome
            // 
            this.col_nome.DataPropertyName = "DESCRICAO_PRODUTO";
            this.col_nome.HeaderText = "Descrição Produto";
            this.col_nome.Name = "col_nome";
            this.col_nome.Width = 200;
            // 
            // col_item
            // 
            this.col_item.DataPropertyName = "DESCRICAO_ITEM_PRODUTO";
            this.col_item.HeaderText = "Descrição Item";
            this.col_item.Name = "col_item";
            this.col_item.Width = 200;
            // 
            // cARACTADICPRODUTODataGridViewTextBoxColumn
            // 
            this.cARACTADICPRODUTODataGridViewTextBoxColumn.DataPropertyName = "CARACT_ADIC_PRODUTO";
            this.cARACTADICPRODUTODataGridViewTextBoxColumn.HeaderText = "CARACT_ADIC_PRODUTO";
            this.cARACTADICPRODUTODataGridViewTextBoxColumn.Name = "cARACTADICPRODUTODataGridViewTextBoxColumn";
            this.cARACTADICPRODUTODataGridViewTextBoxColumn.Visible = false;
            // 
            // cODBARRASPRODUTODataGridViewTextBoxColumn
            // 
            this.cODBARRASPRODUTODataGridViewTextBoxColumn.DataPropertyName = "COD_BARRAS_PRODUTO";
            this.cODBARRASPRODUTODataGridViewTextBoxColumn.HeaderText = "Cód. Barras";
            this.cODBARRASPRODUTODataGridViewTextBoxColumn.Name = "cODBARRASPRODUTODataGridViewTextBoxColumn";
            this.cODBARRASPRODUTODataGridViewTextBoxColumn.Visible = false;
            // 
            // cODONUPRODUTODataGridViewTextBoxColumn
            // 
            this.cODONUPRODUTODataGridViewTextBoxColumn.DataPropertyName = "COD_ONU_PRODUTO";
            this.cODONUPRODUTODataGridViewTextBoxColumn.HeaderText = "COD_ONU_PRODUTO";
            this.cODONUPRODUTODataGridViewTextBoxColumn.Name = "cODONUPRODUTODataGridViewTextBoxColumn";
            this.cODONUPRODUTODataGridViewTextBoxColumn.Visible = false;
            // 
            // cLASSETOXICPRODUTODataGridViewTextBoxColumn
            // 
            this.cLASSETOXICPRODUTODataGridViewTextBoxColumn.DataPropertyName = "CLASSE_TOXIC_PRODUTO";
            this.cLASSETOXICPRODUTODataGridViewTextBoxColumn.HeaderText = "CLASSE_TOXIC_PRODUTO";
            this.cLASSETOXICPRODUTODataGridViewTextBoxColumn.Name = "cLASSETOXICPRODUTODataGridViewTextBoxColumn";
            this.cLASSETOXICPRODUTODataGridViewTextBoxColumn.Visible = false;
            // 
            // col_uni
            // 
            this.col_uni.DataPropertyName = "COD_UNIDADE_PRODUTO";
            this.col_uni.HeaderText = "COD_UNIDADE_PRODUTO";
            this.col_uni.Name = "col_uni";
            this.col_uni.Visible = false;
            // 
            // col_uni2
            // 
            this.col_uni2.DataPropertyName = "DESCRICAO_UNIDADE_PRODUTO";
            this.col_uni2.HeaderText = "DESCRICAO_UNIDADE_PRODUTO";
            this.col_uni2.Name = "col_uni2";
            this.col_uni2.Visible = false;
            // 
            // mETAANUALPRODUTODataGridViewTextBoxColumn
            // 
            this.mETAANUALPRODUTODataGridViewTextBoxColumn.DataPropertyName = "META_ANUAL_PRODUTO";
            this.mETAANUALPRODUTODataGridViewTextBoxColumn.HeaderText = "META_ANUAL_PRODUTO";
            this.mETAANUALPRODUTODataGridViewTextBoxColumn.Name = "mETAANUALPRODUTODataGridViewTextBoxColumn";
            this.mETAANUALPRODUTODataGridViewTextBoxColumn.Visible = false;
            // 
            // cODREDUZIDOPRODUTODataGridViewTextBoxColumn
            // 
            this.cODREDUZIDOPRODUTODataGridViewTextBoxColumn.DataPropertyName = "COD_REDUZIDO_PRODUTO";
            this.cODREDUZIDOPRODUTODataGridViewTextBoxColumn.HeaderText = "COD_REDUZIDO_PRODUTO";
            this.cODREDUZIDOPRODUTODataGridViewTextBoxColumn.Name = "cODREDUZIDOPRODUTODataGridViewTextBoxColumn";
            this.cODREDUZIDOPRODUTODataGridViewTextBoxColumn.Visible = false;
            // 
            // tABPRODUTODataGridViewTextBoxColumn
            // 
            this.tABPRODUTODataGridViewTextBoxColumn.DataPropertyName = "TAB_PRODUTO";
            this.tABPRODUTODataGridViewTextBoxColumn.HeaderText = "TAB_PRODUTO";
            this.tABPRODUTODataGridViewTextBoxColumn.Name = "tABPRODUTODataGridViewTextBoxColumn";
            this.tABPRODUTODataGridViewTextBoxColumn.Visible = false;
            // 
            // mETASEMESTRALPRODUTODataGridViewTextBoxColumn
            // 
            this.mETASEMESTRALPRODUTODataGridViewTextBoxColumn.DataPropertyName = "META_SEMESTRAL_PRODUTO";
            this.mETASEMESTRALPRODUTODataGridViewTextBoxColumn.HeaderText = "META_SEMESTRAL_PRODUTO";
            this.mETASEMESTRALPRODUTODataGridViewTextBoxColumn.Name = "mETASEMESTRALPRODUTODataGridViewTextBoxColumn";
            this.mETASEMESTRALPRODUTODataGridViewTextBoxColumn.Visible = false;
            // 
            // col_estoque_atual
            // 
            this.col_estoque_atual.DataPropertyName = "ESTOQUE_ATUAL_PRODUTO";
            this.col_estoque_atual.HeaderText = "Est. Atual";
            this.col_estoque_atual.Name = "col_estoque_atual";
            this.col_estoque_atual.Width = 40;
            // 
            // eSTOQUERESERVADOPRODUTODataGridViewTextBoxColumn
            // 
            this.eSTOQUERESERVADOPRODUTODataGridViewTextBoxColumn.DataPropertyName = "ESTOQUE_RESERVADO_PRODUTO";
            this.eSTOQUERESERVADOPRODUTODataGridViewTextBoxColumn.HeaderText = "ESTOQUE_RESERVADO_PRODUTO";
            this.eSTOQUERESERVADOPRODUTODataGridViewTextBoxColumn.Name = "eSTOQUERESERVADOPRODUTODataGridViewTextBoxColumn";
            this.eSTOQUERESERVADOPRODUTODataGridViewTextBoxColumn.Visible = false;
            // 
            // eSTOQUEMINIMOPRODUTODataGridViewTextBoxColumn
            // 
            this.eSTOQUEMINIMOPRODUTODataGridViewTextBoxColumn.DataPropertyName = "ESTOQUE_MINIMO_PRODUTO";
            this.eSTOQUEMINIMOPRODUTODataGridViewTextBoxColumn.HeaderText = "ESTOQUE_MINIMO_PRODUTO";
            this.eSTOQUEMINIMOPRODUTODataGridViewTextBoxColumn.Name = "eSTOQUEMINIMOPRODUTODataGridViewTextBoxColumn";
            this.eSTOQUEMINIMOPRODUTODataGridViewTextBoxColumn.Visible = false;
            // 
            // eSTOQUEENCOMENDADOPRODUTODataGridViewTextBoxColumn
            // 
            this.eSTOQUEENCOMENDADOPRODUTODataGridViewTextBoxColumn.DataPropertyName = "ESTOQUE_ENCOMENDADO_PRODUTO";
            this.eSTOQUEENCOMENDADOPRODUTODataGridViewTextBoxColumn.HeaderText = "ESTOQUE_ENCOMENDADO_PRODUTO";
            this.eSTOQUEENCOMENDADOPRODUTODataGridViewTextBoxColumn.Name = "eSTOQUEENCOMENDADOPRODUTODataGridViewTextBoxColumn";
            this.eSTOQUEENCOMENDADOPRODUTODataGridViewTextBoxColumn.Visible = false;
            // 
            // eSTOQUEMAXIMOPRODUTODataGridViewTextBoxColumn
            // 
            this.eSTOQUEMAXIMOPRODUTODataGridViewTextBoxColumn.DataPropertyName = "ESTOQUE_MAXIMO_PRODUTO";
            this.eSTOQUEMAXIMOPRODUTODataGridViewTextBoxColumn.HeaderText = "ESTOQUE_MAXIMO_PRODUTO";
            this.eSTOQUEMAXIMOPRODUTODataGridViewTextBoxColumn.Name = "eSTOQUEMAXIMOPRODUTODataGridViewTextBoxColumn";
            this.eSTOQUEMAXIMOPRODUTODataGridViewTextBoxColumn.Visible = false;
            // 
            // col_estoque_medio
            // 
            this.col_estoque_medio.DataPropertyName = "ESTOQUE_MEDIO_PRODUTO";
            this.col_estoque_medio.HeaderText = "Est. Médio";
            this.col_estoque_medio.Name = "col_estoque_medio";
            this.col_estoque_medio.Width = 40;
            // 
            // col_custo
            // 
            this.col_custo.DataPropertyName = "CUSTO_PRODUTO";
            this.col_custo.HeaderText = "Valor Custo";
            this.col_custo.Name = "col_custo";
            this.col_custo.Width = 70;
            // 
            // cUSTOMEDPRODUTODataGridViewTextBoxColumn
            // 
            this.cUSTOMEDPRODUTODataGridViewTextBoxColumn.DataPropertyName = "CUSTO_MED_PRODUTO";
            this.cUSTOMEDPRODUTODataGridViewTextBoxColumn.HeaderText = "CUSTO_MED_PRODUTO";
            this.cUSTOMEDPRODUTODataGridViewTextBoxColumn.Name = "cUSTOMEDPRODUTODataGridViewTextBoxColumn";
            this.cUSTOMEDPRODUTODataGridViewTextBoxColumn.Visible = false;
            // 
            // col_valor_venda
            // 
            this.col_valor_venda.DataPropertyName = "VALOR_VENDA_PRODUTOR_PRODUTO";
            this.col_valor_venda.HeaderText = "Valor Venda";
            this.col_valor_venda.Name = "col_valor_venda";
            this.col_valor_venda.Width = 70;
            // 
            // sTATUSPRODUTODataGridViewTextBoxColumn
            // 
            this.sTATUSPRODUTODataGridViewTextBoxColumn.DataPropertyName = "STATUS_PRODUTO";
            this.sTATUSPRODUTODataGridViewTextBoxColumn.FalseValue = "0";
            this.sTATUSPRODUTODataGridViewTextBoxColumn.HeaderText = "Status";
            this.sTATUSPRODUTODataGridViewTextBoxColumn.IndeterminateValue = "0";
            this.sTATUSPRODUTODataGridViewTextBoxColumn.Name = "sTATUSPRODUTODataGridViewTextBoxColumn";
            this.sTATUSPRODUTODataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sTATUSPRODUTODataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sTATUSPRODUTODataGridViewTextBoxColumn.TrueValue = "1";
            this.sTATUSPRODUTODataGridViewTextBoxColumn.Width = 40;
            // 
            // vALORVENDAREVENDPRODUTODataGridViewTextBoxColumn
            // 
            this.vALORVENDAREVENDPRODUTODataGridViewTextBoxColumn.DataPropertyName = "VALOR_VENDA_REVEND_PRODUTO";
            this.vALORVENDAREVENDPRODUTODataGridViewTextBoxColumn.HeaderText = "Valor Revenda";
            this.vALORVENDAREVENDPRODUTODataGridViewTextBoxColumn.Name = "vALORVENDAREVENDPRODUTODataGridViewTextBoxColumn";
            this.vALORVENDAREVENDPRODUTODataGridViewTextBoxColumn.Width = 70;
            // 
            // vALORPROMOCAOPRODUTODataGridViewTextBoxColumn
            // 
            this.vALORPROMOCAOPRODUTODataGridViewTextBoxColumn.DataPropertyName = "VALOR_PROMOCAO_PRODUTO";
            this.vALORPROMOCAOPRODUTODataGridViewTextBoxColumn.HeaderText = "VALOR_PROMOCAO_PRODUTO";
            this.vALORPROMOCAOPRODUTODataGridViewTextBoxColumn.Name = "vALORPROMOCAOPRODUTODataGridViewTextBoxColumn";
            this.vALORPROMOCAOPRODUTODataGridViewTextBoxColumn.Visible = false;
            // 
            // oUTROVALORPRODUTODataGridViewTextBoxColumn
            // 
            this.oUTROVALORPRODUTODataGridViewTextBoxColumn.DataPropertyName = "OUTRO_VALOR_PRODUTO";
            this.oUTROVALORPRODUTODataGridViewTextBoxColumn.HeaderText = "OUTRO_VALOR_PRODUTO";
            this.oUTROVALORPRODUTODataGridViewTextBoxColumn.Name = "oUTROVALORPRODUTODataGridViewTextBoxColumn";
            this.oUTROVALORPRODUTODataGridViewTextBoxColumn.Visible = false;
            // 
            // lUCROPRODUTODataGridViewTextBoxColumn
            // 
            this.lUCROPRODUTODataGridViewTextBoxColumn.DataPropertyName = "LUCRO_PRODUTO";
            this.lUCROPRODUTODataGridViewTextBoxColumn.HeaderText = "LUCRO_PRODUTO";
            this.lUCROPRODUTODataGridViewTextBoxColumn.Name = "lUCROPRODUTODataGridViewTextBoxColumn";
            this.lUCROPRODUTODataGridViewTextBoxColumn.Visible = false;
            // 
            // IVA_PRODUTO
            // 
            this.IVA_PRODUTO.DataPropertyName = "IVA_PRODUTO";
            this.IVA_PRODUTO.HeaderText = "IVA";
            this.IVA_PRODUTO.Name = "IVA_PRODUTO";
            // 
            // uLTREAJPRODUTODataGridViewTextBoxColumn
            // 
            this.uLTREAJPRODUTODataGridViewTextBoxColumn.DataPropertyName = "ULT_REAJ_PRODUTO";
            this.uLTREAJPRODUTODataGridViewTextBoxColumn.HeaderText = "ULT_REAJ_PRODUTO";
            this.uLTREAJPRODUTODataGridViewTextBoxColumn.Name = "uLTREAJPRODUTODataGridViewTextBoxColumn";
            this.uLTREAJPRODUTODataGridViewTextBoxColumn.Visible = false;
            // 
            // pRODRECEITAPRODUTODataGridViewTextBoxColumn
            // 
            this.pRODRECEITAPRODUTODataGridViewTextBoxColumn.DataPropertyName = "PROD_RECEITA_PRODUTO";
            this.pRODRECEITAPRODUTODataGridViewTextBoxColumn.HeaderText = "PROD_RECEITA_PRODUTO";
            this.pRODRECEITAPRODUTODataGridViewTextBoxColumn.Name = "pRODRECEITAPRODUTODataGridViewTextBoxColumn";
            this.pRODRECEITAPRODUTODataGridViewTextBoxColumn.Visible = false;
            // 
            // iCMSSNPRODUTODataGridViewTextBoxColumn
            // 
            this.iCMSSNPRODUTODataGridViewTextBoxColumn.DataPropertyName = "ICMS_S_N_PRODUTO";
            this.iCMSSNPRODUTODataGridViewTextBoxColumn.HeaderText = "ICMS_S_N_PRODUTO";
            this.iCMSSNPRODUTODataGridViewTextBoxColumn.Name = "iCMSSNPRODUTODataGridViewTextBoxColumn";
            this.iCMSSNPRODUTODataGridViewTextBoxColumn.Visible = false;
            // 
            // aLIQUOTAICMSPRODUTODataGridViewTextBoxColumn
            // 
            this.aLIQUOTAICMSPRODUTODataGridViewTextBoxColumn.DataPropertyName = "ALIQUOTA_ICMS_PRODUTO";
            this.aLIQUOTAICMSPRODUTODataGridViewTextBoxColumn.HeaderText = "ALIQUOTA_ICMS_PRODUTO";
            this.aLIQUOTAICMSPRODUTODataGridViewTextBoxColumn.Name = "aLIQUOTAICMSPRODUTODataGridViewTextBoxColumn";
            this.aLIQUOTAICMSPRODUTODataGridViewTextBoxColumn.Visible = false;
            // 
            // rEDUCAOFORAPRODUTODataGridViewTextBoxColumn
            // 
            this.rEDUCAOFORAPRODUTODataGridViewTextBoxColumn.DataPropertyName = "REDUCAO_FORA_PRODUTO";
            this.rEDUCAOFORAPRODUTODataGridViewTextBoxColumn.HeaderText = "REDUCAO_FORA_PRODUTO";
            this.rEDUCAOFORAPRODUTODataGridViewTextBoxColumn.Name = "rEDUCAOFORAPRODUTODataGridViewTextBoxColumn";
            this.rEDUCAOFORAPRODUTODataGridViewTextBoxColumn.Visible = false;
            // 
            // aLIQUOTAIPIPRODUTODataGridViewTextBoxColumn
            // 
            this.aLIQUOTAIPIPRODUTODataGridViewTextBoxColumn.DataPropertyName = "ALIQUOTA_IPI_PRODUTO";
            this.aLIQUOTAIPIPRODUTODataGridViewTextBoxColumn.HeaderText = "ALIQUOTA_IPI_PRODUTO";
            this.aLIQUOTAIPIPRODUTODataGridViewTextBoxColumn.Name = "aLIQUOTAIPIPRODUTODataGridViewTextBoxColumn";
            this.aLIQUOTAIPIPRODUTODataGridViewTextBoxColumn.Visible = false;
            // 
            // pISPRODUTODataGridViewTextBoxColumn
            // 
            this.pISPRODUTODataGridViewTextBoxColumn.DataPropertyName = "PIS_PRODUTO";
            this.pISPRODUTODataGridViewTextBoxColumn.HeaderText = "PIS_PRODUTO";
            this.pISPRODUTODataGridViewTextBoxColumn.Name = "pISPRODUTODataGridViewTextBoxColumn";
            this.pISPRODUTODataGridViewTextBoxColumn.Visible = false;
            // 
            // cOFINSPRODUTODataGridViewTextBoxColumn
            // 
            this.cOFINSPRODUTODataGridViewTextBoxColumn.DataPropertyName = "COFINS_PRODUTO";
            this.cOFINSPRODUTODataGridViewTextBoxColumn.HeaderText = "COFINS_PRODUTO";
            this.cOFINSPRODUTODataGridViewTextBoxColumn.Name = "cOFINSPRODUTODataGridViewTextBoxColumn";
            this.cOFINSPRODUTODataGridViewTextBoxColumn.Visible = false;
            // 
            // form_localiza_produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 582);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tb_valor_compra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_valor_estoque);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.tbcod_sub_grupo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvProdutos);
            this.Name = "form_localiza_produto";
            this.Text = "Localiza Produto";
            this.Load += new System.EventHandler(this.form_localiza_produto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PRODUTOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datProdutos;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Data.DataSet dsProdutos;
        private System.Data.DataTable PRODUTOS;
        private System.Data.DataColumn COD_PRODUTO;
        private System.Data.DataColumn COD_GRUPO_PRODUTO;
        private System.Data.DataColumn DESCRICAO_GRUPO_PRODUTO;
        private System.Data.DataColumn COD_SUB_GRUPO_PRODUTO;
        private System.Data.DataColumn DESCRICAO_SUB_GRUPO_PRODUTO;
        private System.Data.DataColumn DESCRICAO_PRODUTO;
        private System.Data.DataColumn CARACT_ADIC_PRODUTO;
        private System.Data.DataColumn COD_BARRAS_PRODUTO;
        private System.Data.DataColumn COD_ONU_PRODUTO;
        private System.Data.DataColumn CLASSE_TOXIC_PRODUTO;
        private System.Data.DataColumn COD_UNIDADE_PRODUTO;
        private System.Data.DataColumn DESCRICAO_UNIDADE_PRODUTO;
        private System.Data.DataColumn META_ANUAL_PRODUTO;
        private System.Data.DataColumn COD_REDUZIDO_PRODUTO;
        private System.Data.DataColumn TAB_PRODUTO;
        private System.Data.DataColumn META_SEMESTRAL_PRODUTO;
        private System.Data.DataColumn ESTOQUE_ATUAL_PRODUTO;
        private System.Data.DataColumn ESTOQUE_RESERVADO_PRODUTO;
        private System.Data.DataColumn ESTOQUE_MINIMO_PRODUTO;
        private System.Data.DataColumn ESTOQUE_ENCOMENDADO_PRODUTO;
        private System.Data.DataColumn ESTOQUE_MAXIMO_PRODUTO;
        private System.Data.DataColumn ESTOQUE_MEDIO_PRODUTO;
        private System.Data.DataColumn CUSTO_PRODUTO;
        private System.Data.DataColumn CUSTO_MED_PRODUTO;
        private System.Data.DataColumn VALOR_VENDA_PRODUTOR_PRODUTO;
        private System.Data.DataColumn VALOR_VENDA_REVEND_PRODUTO;
        private System.Data.DataColumn VALOR_PROMOCAO_PRODUTO;
        private System.Data.DataColumn OUTRO_VALOR_PRODUTO;
        private System.Data.DataColumn LUCRO_PRODUTO;
        private System.Data.DataColumn ULT_REAJ_PRODUTO;
        private System.Data.DataColumn PROD_RECEITA_PRODUTO;
        private System.Data.DataColumn STATUS_PRODUTO;
        private System.Data.DataColumn ICMS_S_N_PRODUTO;
        private System.Data.DataColumn ALIQUOTA_ICMS_PRODUTO;
        private System.Data.DataColumn REDUCAO_FORA_PRODUTO;
        private System.Data.DataColumn ALIQUOTA_IPI_PRODUTO;
        private System.Data.DataColumn PIS_PRODUTO;
        private System.Data.DataColumn COFINS_PRODUTO;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_sub_grupo;
        private System.Windows.Forms.TextBox tb_grupo;
        private System.Windows.Forms.TextBox tb_cod_grupo;
        private System.Windows.Forms.TextBox tb_cod;
        private System.Windows.Forms.TextBox tbcod_sub_grupo;
        private System.Windows.Forms.TextBox tb_descricao_item;
        private System.Windows.Forms.TextBox tb_descricao;
        private System.Windows.Forms.CheckBox cb_status;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_valor_estoque;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Windows.Forms.TextBox tb_cod_forn;
        private System.Data.DataColumn dataColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODGRUPOPRODUTODataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRICAOGRUPOPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODSUBGRUPOPRODUTODataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRICAOSUBGRUPOPRODUTODataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRICAOPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cARACTADICPRODUTODataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODBARRASPRODUTODataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODONUPRODUTODataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLASSETOXICPRODUTODataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODUNIDADEPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRICAOUNIDADEPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mETAANUALPRODUTODataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODREDUZIDOPRODUTODataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tABPRODUTODataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mETASEMESTRALPRODUTODataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTOQUEATUALPRODUTODataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTOQUERESERVADOPRODUTODataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTOQUEMINIMOPRODUTODataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTOQUEENCOMENDADOPRODUTODataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTOQUEMAXIMOPRODUTODataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTOQUEMEDIOPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSTOPRODUTODataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSTOMEDPRODUTODataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORVENDAPRODUTORPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORVENDAREVENDPRODUTODataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORPROMOCAOPRODUTODataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn oUTROVALORPRODUTODataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lUCROPRODUTODataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn uLTREAJPRODUTODataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODRECEITAPRODUTODataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTATUSPRODUTODataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iCMSSNPRODUTODataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aLIQUOTAICMSPRODUTODataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEDUCAOFORAPRODUTODataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aLIQUOTAIPIPRODUTODataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pISPRODUTODataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOFINSPRODUTODataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODMARCAPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mARCAPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iVAPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nCMPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRICAOITEMPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODFORNECEDORPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oRIGEMPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox tb_valor_compra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODGRUPOPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_grupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_MARCA_PRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODSUBGRUPOPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRICAOSUBGRUPOPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod_forn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn cARACTADICPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODBARRASPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODONUPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLASSETOXICPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_uni;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_uni2;
        private System.Windows.Forms.DataGridViewTextBoxColumn mETAANUALPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODREDUZIDOPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tABPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mETASEMESTRALPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_estoque_atual;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTOQUERESERVADOPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTOQUEMINIMOPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTOQUEENCOMENDADOPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTOQUEMAXIMOPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_estoque_medio;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_custo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSTOMEDPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_valor_venda;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sTATUSPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORVENDAREVENDPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORPROMOCAOPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oUTROVALORPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lUCROPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IVA_PRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn uLTREAJPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODRECEITAPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iCMSSNPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aLIQUOTAICMSPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEDUCAOFORAPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aLIQUOTAIPIPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pISPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOFINSPRODUTODataGridViewTextBoxColumn;
    }
}