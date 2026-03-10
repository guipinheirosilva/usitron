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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dataColumn8 = new System.Data.DataColumn();
            this.dataColumn9 = new System.Data.DataColumn();
            this.dataColumn10 = new System.Data.DataColumn();
            this.dataColumn11 = new System.Data.DataColumn();
            this.dataColumn12 = new System.Data.DataColumn();
            this.dataColumn13 = new System.Data.DataColumn();
            this.ESTOQUE_RESERVA_FECHADA_PRODUTO = new System.Data.DataColumn();
            this.dataColumn14 = new System.Data.DataColumn();
            this.dataColumn15 = new System.Data.DataColumn();
            this.dataColumn16 = new System.Data.DataColumn();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.col_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cod_forn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODGRUPOPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_grupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRICAOSUBGRUPOPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COD_MARCA_PRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODSUBGRUPOPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_FAMILIA_PRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_FORNECEDOR_PRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cARACTADICPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cod_ean = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COD_BARRAS_CAIXA_PRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_uni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODONUPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLASSETOXICPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_uni2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mETAANUALPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODREDUZIDOPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tABPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mETASEMESTRALPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOCALIZACAO_PRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_valor_venda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORPROMOCAOPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_acerto_estoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_estoque_atual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSTOQUERESERVADOPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSTOQUEENCOMENDADOPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_sep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTOQUE_DISPONIVEL_PRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstoqueMinimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_estoque_medio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSTOQUEMAXIMOPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTOMEDPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTATUSPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.RATEIO_PRODUTO = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.col_custo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_porc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tb_subgrupo = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tb_fornecedor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_familia = new System.Windows.Forms.TextBox();
            this.cbxStatus = new System.Windows.Forms.CheckBox();
            this.txtCodBarras = new System.Windows.Forms.TextBox();
            this.tb_descricao = new System.Windows.Forms.TextBox();
            this.tb_grupo = new System.Windows.Forms.TextBox();
            this.tb_cod = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
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
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.tb_porcentagem = new System.Windows.Forms.TextBox();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.cbProdutos = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button12 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_familia_pesquisa = new System.Windows.Forms.TextBox();
            this.tb_cod_barras_pesquisa = new System.Windows.Forms.TextBox();
            this.tb_descricao_pesquisa = new System.Windows.Forms.TextBox();
            this.tb_grupo_pesquisa = new System.Windows.Forms.TextBox();
            this.tb_cod_pesquisa = new System.Windows.Forms.TextBox();
            this.button13 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dsProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PRODUTOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.fbCommand1.CommandText = "select * from produtos order by cod_produto";
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
            this.dataColumn7,
            this.dataColumn8,
            this.dataColumn9,
            this.dataColumn10,
            this.dataColumn11,
            this.dataColumn12,
            this.dataColumn13,
            this.ESTOQUE_RESERVA_FECHADA_PRODUTO,
            this.dataColumn14,
            this.dataColumn15,
            this.dataColumn16});
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
            this.COD_PRODUTO.DataType = typeof(long);
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
            // dataColumn8
            // 
            this.dataColumn8.ColumnName = "NOME_FORNECEDOR_PRODUTO";
            // 
            // dataColumn9
            // 
            this.dataColumn9.ColumnName = "COD_BARRAS_CAIXA_PRODUTO";
            this.dataColumn9.MaxLength = 200;
            // 
            // dataColumn10
            // 
            this.dataColumn10.ColumnName = "NOME_FAMILIA_PRODUTO";
            this.dataColumn10.MaxLength = 100;
            // 
            // dataColumn11
            // 
            this.dataColumn11.ColumnName = "ACERTO_ESTOQUE_PRODUTO";
            this.dataColumn11.MaxLength = 200;
            // 
            // dataColumn12
            // 
            this.dataColumn12.ColumnName = "ESTOQUE_DISPONIVEL_PRODUTO";
            this.dataColumn12.DataType = typeof(double);
            // 
            // dataColumn13
            // 
            this.dataColumn13.ColumnName = "LUCRO";
            this.dataColumn13.DataType = typeof(double);
            // 
            // ESTOQUE_RESERVA_FECHADA_PRODUTO
            // 
            this.ESTOQUE_RESERVA_FECHADA_PRODUTO.Caption = "ESTOQUE_RESERVA_FECHADA_PRODUTO";
            this.ESTOQUE_RESERVA_FECHADA_PRODUTO.ColumnName = "ESTOQUE_RESERVA_FECHADA_PRODUTO";
            // 
            // dataColumn14
            // 
            this.dataColumn14.ColumnName = "ESTOQUE_SEPARADO_PRODUTO";
            this.dataColumn14.DataType = typeof(double);
            // 
            // dataColumn15
            // 
            this.dataColumn15.ColumnName = "LOCALIZACAO_PRODUTO";
            // 
            // dataColumn16
            // 
            this.dataColumn16.ColumnName = "RATEIO_PRODUTO";
            this.dataColumn16.DataType = typeof(int);
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProdutos.AutoGenerateColumns = false;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_cod,
            this.col_cod_forn,
            this.cODGRUPOPRODUTODataGridViewTextBoxColumn,
            this.col_grupo,
            this.dESCRICAOSUBGRUPOPRODUTODataGridViewTextBoxColumn,
            this.COD_MARCA_PRODUTO,
            this.col_marca,
            this.cODSUBGRUPOPRODUTODataGridViewTextBoxColumn,
            this.NOME_FAMILIA_PRODUTO,
            this.NOME_FORNECEDOR_PRODUTO,
            this.col_nome,
            this.col_item,
            this.cARACTADICPRODUTODataGridViewTextBoxColumn,
            this.col_cod_ean,
            this.COD_BARRAS_CAIXA_PRODUTO,
            this.col_uni,
            this.cODONUPRODUTODataGridViewTextBoxColumn,
            this.cLASSETOXICPRODUTODataGridViewTextBoxColumn,
            this.col_uni2,
            this.mETAANUALPRODUTODataGridViewTextBoxColumn,
            this.cODREDUZIDOPRODUTODataGridViewTextBoxColumn,
            this.tABPRODUTODataGridViewTextBoxColumn,
            this.mETASEMESTRALPRODUTODataGridViewTextBoxColumn,
            this.LOCALIZACAO_PRODUTO,
            this.col_valor_venda,
            this.vALORPROMOCAOPRODUTODataGridViewTextBoxColumn,
            this.col_acerto_estoque,
            this.col_estoque_atual,
            this.eSTOQUERESERVADOPRODUTODataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.eSTOQUEENCOMENDADOPRODUTODataGridViewTextBoxColumn,
            this.col_sep,
            this.ESTOQUE_DISPONIVEL_PRODUTO,
            this.colEstoqueMinimo,
            this.col_estoque_medio,
            this.eSTOQUEMAXIMOPRODUTODataGridViewTextBoxColumn,
            this.cUSTOMEDPRODUTODataGridViewTextBoxColumn,
            this.sTATUSPRODUTODataGridViewTextBoxColumn,
            this.RATEIO_PRODUTO,
            this.col_custo,
            this.col_porc,
            this.dataGridViewTextBoxColumn2,
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
            this.dgvProdutos.Location = new System.Drawing.Point(8, 256);
            this.dgvProdutos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.RowHeadersWidth = 51;
            this.dgvProdutos.Size = new System.Drawing.Size(1656, 399);
            this.dgvProdutos.TabIndex = 100;
            this.dgvProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellDoubleClick);
            this.dgvProdutos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellDoubleClick);
            // 
            // col_cod
            // 
            this.col_cod.DataPropertyName = "COD_PRODUTO";
            this.col_cod.HeaderText = "Código Produto";
            this.col_cod.MinimumWidth = 6;
            this.col_cod.Name = "col_cod";
            this.col_cod.Visible = false;
            this.col_cod.Width = 40;
            // 
            // col_cod_forn
            // 
            this.col_cod_forn.DataPropertyName = "COD_FORNECEDOR_PRODUTO";
            this.col_cod_forn.HeaderText = "Cód.";
            this.col_cod_forn.MinimumWidth = 6;
            this.col_cod_forn.Name = "col_cod_forn";
            this.col_cod_forn.ReadOnly = true;
            this.col_cod_forn.Width = 150;
            // 
            // cODGRUPOPRODUTODataGridViewTextBoxColumn
            // 
            this.cODGRUPOPRODUTODataGridViewTextBoxColumn.DataPropertyName = "COD_GRUPO_PRODUTO";
            this.cODGRUPOPRODUTODataGridViewTextBoxColumn.HeaderText = "Cód. Grupo";
            this.cODGRUPOPRODUTODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cODGRUPOPRODUTODataGridViewTextBoxColumn.Name = "cODGRUPOPRODUTODataGridViewTextBoxColumn";
            this.cODGRUPOPRODUTODataGridViewTextBoxColumn.Visible = false;
            this.cODGRUPOPRODUTODataGridViewTextBoxColumn.Width = 40;
            // 
            // col_grupo
            // 
            this.col_grupo.DataPropertyName = "DESCRICAO_GRUPO_PRODUTO";
            this.col_grupo.HeaderText = "Grupo";
            this.col_grupo.MinimumWidth = 6;
            this.col_grupo.Name = "col_grupo";
            this.col_grupo.ReadOnly = true;
            this.col_grupo.Width = 70;
            // 
            // dESCRICAOSUBGRUPOPRODUTODataGridViewTextBoxColumn
            // 
            this.dESCRICAOSUBGRUPOPRODUTODataGridViewTextBoxColumn.DataPropertyName = "DESCRICAO_SUB_GRUPO_PRODUTO";
            this.dESCRICAOSUBGRUPOPRODUTODataGridViewTextBoxColumn.HeaderText = "Sub-Grupo";
            this.dESCRICAOSUBGRUPOPRODUTODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dESCRICAOSUBGRUPOPRODUTODataGridViewTextBoxColumn.Name = "dESCRICAOSUBGRUPOPRODUTODataGridViewTextBoxColumn";
            this.dESCRICAOSUBGRUPOPRODUTODataGridViewTextBoxColumn.ReadOnly = true;
            this.dESCRICAOSUBGRUPOPRODUTODataGridViewTextBoxColumn.Width = 70;
            // 
            // COD_MARCA_PRODUTO
            // 
            this.COD_MARCA_PRODUTO.DataPropertyName = "COD_MARCA_PRODUTO";
            this.COD_MARCA_PRODUTO.HeaderText = "Cód. Marca";
            this.COD_MARCA_PRODUTO.MinimumWidth = 6;
            this.COD_MARCA_PRODUTO.Name = "COD_MARCA_PRODUTO";
            this.COD_MARCA_PRODUTO.Visible = false;
            this.COD_MARCA_PRODUTO.Width = 40;
            // 
            // col_marca
            // 
            this.col_marca.DataPropertyName = "MARCA_PRODUTO";
            this.col_marca.HeaderText = "Marca";
            this.col_marca.MinimumWidth = 6;
            this.col_marca.Name = "col_marca";
            this.col_marca.Visible = false;
            this.col_marca.Width = 80;
            // 
            // cODSUBGRUPOPRODUTODataGridViewTextBoxColumn
            // 
            this.cODSUBGRUPOPRODUTODataGridViewTextBoxColumn.DataPropertyName = "COD_SUB_GRUPO_PRODUTO";
            this.cODSUBGRUPOPRODUTODataGridViewTextBoxColumn.HeaderText = "Cód. Sub Grupo";
            this.cODSUBGRUPOPRODUTODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cODSUBGRUPOPRODUTODataGridViewTextBoxColumn.Name = "cODSUBGRUPOPRODUTODataGridViewTextBoxColumn";
            this.cODSUBGRUPOPRODUTODataGridViewTextBoxColumn.Visible = false;
            this.cODSUBGRUPOPRODUTODataGridViewTextBoxColumn.Width = 40;
            // 
            // NOME_FAMILIA_PRODUTO
            // 
            this.NOME_FAMILIA_PRODUTO.DataPropertyName = "NOME_FAMILIA_PRODUTO";
            this.NOME_FAMILIA_PRODUTO.HeaderText = "Família";
            this.NOME_FAMILIA_PRODUTO.MinimumWidth = 6;
            this.NOME_FAMILIA_PRODUTO.Name = "NOME_FAMILIA_PRODUTO";
            this.NOME_FAMILIA_PRODUTO.ReadOnly = true;
            this.NOME_FAMILIA_PRODUTO.Width = 90;
            // 
            // NOME_FORNECEDOR_PRODUTO
            // 
            this.NOME_FORNECEDOR_PRODUTO.DataPropertyName = "NOME_FORNECEDOR_PRODUTO";
            this.NOME_FORNECEDOR_PRODUTO.HeaderText = "Fornecedor";
            this.NOME_FORNECEDOR_PRODUTO.Name = "NOME_FORNECEDOR_PRODUTO";
            // 
            // col_nome
            // 
            this.col_nome.DataPropertyName = "DESCRICAO_PRODUTO";
            this.col_nome.HeaderText = "Descrição Produto";
            this.col_nome.MinimumWidth = 6;
            this.col_nome.Name = "col_nome";
            this.col_nome.ReadOnly = true;
            this.col_nome.Width = 340;
            // 
            // col_item
            // 
            this.col_item.DataPropertyName = "DESCRICAO_ITEM_PRODUTO";
            this.col_item.HeaderText = "Descrição Item";
            this.col_item.MinimumWidth = 6;
            this.col_item.Name = "col_item";
            this.col_item.Visible = false;
            this.col_item.Width = 200;
            // 
            // cARACTADICPRODUTODataGridViewTextBoxColumn
            // 
            this.cARACTADICPRODUTODataGridViewTextBoxColumn.DataPropertyName = "CARACT_ADIC_PRODUTO";
            this.cARACTADICPRODUTODataGridViewTextBoxColumn.HeaderText = "CARACT_ADIC_PRODUTO";
            this.cARACTADICPRODUTODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cARACTADICPRODUTODataGridViewTextBoxColumn.Name = "cARACTADICPRODUTODataGridViewTextBoxColumn";
            this.cARACTADICPRODUTODataGridViewTextBoxColumn.Visible = false;
            this.cARACTADICPRODUTODataGridViewTextBoxColumn.Width = 125;
            // 
            // col_cod_ean
            // 
            this.col_cod_ean.DataPropertyName = "COD_BARRAS_PRODUTO";
            this.col_cod_ean.HeaderText = "Cód. Barras Un.";
            this.col_cod_ean.MinimumWidth = 6;
            this.col_cod_ean.Name = "col_cod_ean";
            this.col_cod_ean.ReadOnly = true;
            this.col_cod_ean.Width = 95;
            // 
            // COD_BARRAS_CAIXA_PRODUTO
            // 
            this.COD_BARRAS_CAIXA_PRODUTO.DataPropertyName = "COD_BARRAS_CAIXA_PRODUTO";
            this.COD_BARRAS_CAIXA_PRODUTO.HeaderText = "Cód. Barras Cx.";
            this.COD_BARRAS_CAIXA_PRODUTO.MinimumWidth = 6;
            this.COD_BARRAS_CAIXA_PRODUTO.Name = "COD_BARRAS_CAIXA_PRODUTO";
            this.COD_BARRAS_CAIXA_PRODUTO.ReadOnly = true;
            this.COD_BARRAS_CAIXA_PRODUTO.Visible = false;
            this.COD_BARRAS_CAIXA_PRODUTO.Width = 95;
            // 
            // col_uni
            // 
            this.col_uni.DataPropertyName = "COD_UNIDADE_PRODUTO";
            this.col_uni.HeaderText = "Un";
            this.col_uni.MinimumWidth = 6;
            this.col_uni.Name = "col_uni";
            this.col_uni.Visible = false;
            this.col_uni.Width = 125;
            // 
            // cODONUPRODUTODataGridViewTextBoxColumn
            // 
            this.cODONUPRODUTODataGridViewTextBoxColumn.DataPropertyName = "COD_ONU_PRODUTO";
            this.cODONUPRODUTODataGridViewTextBoxColumn.HeaderText = "COD_ONU_PRODUTO";
            this.cODONUPRODUTODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cODONUPRODUTODataGridViewTextBoxColumn.Name = "cODONUPRODUTODataGridViewTextBoxColumn";
            this.cODONUPRODUTODataGridViewTextBoxColumn.Visible = false;
            this.cODONUPRODUTODataGridViewTextBoxColumn.Width = 125;
            // 
            // cLASSETOXICPRODUTODataGridViewTextBoxColumn
            // 
            this.cLASSETOXICPRODUTODataGridViewTextBoxColumn.DataPropertyName = "CLASSE_TOXIC_PRODUTO";
            this.cLASSETOXICPRODUTODataGridViewTextBoxColumn.HeaderText = "CLASSE_TOXIC_PRODUTO";
            this.cLASSETOXICPRODUTODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cLASSETOXICPRODUTODataGridViewTextBoxColumn.Name = "cLASSETOXICPRODUTODataGridViewTextBoxColumn";
            this.cLASSETOXICPRODUTODataGridViewTextBoxColumn.Visible = false;
            this.cLASSETOXICPRODUTODataGridViewTextBoxColumn.Width = 125;
            // 
            // col_uni2
            // 
            this.col_uni2.DataPropertyName = "DESCRICAO_UNIDADE_PRODUTO";
            this.col_uni2.HeaderText = "DESCRICAO_UNIDADE_PRODUTO";
            this.col_uni2.MinimumWidth = 6;
            this.col_uni2.Name = "col_uni2";
            this.col_uni2.Visible = false;
            this.col_uni2.Width = 125;
            // 
            // mETAANUALPRODUTODataGridViewTextBoxColumn
            // 
            this.mETAANUALPRODUTODataGridViewTextBoxColumn.DataPropertyName = "META_ANUAL_PRODUTO";
            this.mETAANUALPRODUTODataGridViewTextBoxColumn.HeaderText = "META_ANUAL_PRODUTO";
            this.mETAANUALPRODUTODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mETAANUALPRODUTODataGridViewTextBoxColumn.Name = "mETAANUALPRODUTODataGridViewTextBoxColumn";
            this.mETAANUALPRODUTODataGridViewTextBoxColumn.Visible = false;
            this.mETAANUALPRODUTODataGridViewTextBoxColumn.Width = 125;
            // 
            // cODREDUZIDOPRODUTODataGridViewTextBoxColumn
            // 
            this.cODREDUZIDOPRODUTODataGridViewTextBoxColumn.DataPropertyName = "COD_REDUZIDO_PRODUTO";
            this.cODREDUZIDOPRODUTODataGridViewTextBoxColumn.HeaderText = "COD_REDUZIDO_PRODUTO";
            this.cODREDUZIDOPRODUTODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cODREDUZIDOPRODUTODataGridViewTextBoxColumn.Name = "cODREDUZIDOPRODUTODataGridViewTextBoxColumn";
            this.cODREDUZIDOPRODUTODataGridViewTextBoxColumn.Visible = false;
            this.cODREDUZIDOPRODUTODataGridViewTextBoxColumn.Width = 125;
            // 
            // tABPRODUTODataGridViewTextBoxColumn
            // 
            this.tABPRODUTODataGridViewTextBoxColumn.DataPropertyName = "TAB_PRODUTO";
            this.tABPRODUTODataGridViewTextBoxColumn.HeaderText = "TAB_PRODUTO";
            this.tABPRODUTODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tABPRODUTODataGridViewTextBoxColumn.Name = "tABPRODUTODataGridViewTextBoxColumn";
            this.tABPRODUTODataGridViewTextBoxColumn.Visible = false;
            this.tABPRODUTODataGridViewTextBoxColumn.Width = 125;
            // 
            // mETASEMESTRALPRODUTODataGridViewTextBoxColumn
            // 
            this.mETASEMESTRALPRODUTODataGridViewTextBoxColumn.DataPropertyName = "META_SEMESTRAL_PRODUTO";
            this.mETASEMESTRALPRODUTODataGridViewTextBoxColumn.HeaderText = "META_SEMESTRAL_PRODUTO";
            this.mETASEMESTRALPRODUTODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mETASEMESTRALPRODUTODataGridViewTextBoxColumn.Name = "mETASEMESTRALPRODUTODataGridViewTextBoxColumn";
            this.mETASEMESTRALPRODUTODataGridViewTextBoxColumn.Visible = false;
            this.mETASEMESTRALPRODUTODataGridViewTextBoxColumn.Width = 125;
            // 
            // LOCALIZACAO_PRODUTO
            // 
            this.LOCALIZACAO_PRODUTO.DataPropertyName = "LOCALIZACAO_PRODUTO";
            this.LOCALIZACAO_PRODUTO.HeaderText = "Loc.";
            this.LOCALIZACAO_PRODUTO.MinimumWidth = 6;
            this.LOCALIZACAO_PRODUTO.Name = "LOCALIZACAO_PRODUTO";
            this.LOCALIZACAO_PRODUTO.Width = 40;
            // 
            // col_valor_venda
            // 
            this.col_valor_venda.DataPropertyName = "VALOR_VENDA_REVEND_PRODUTO";
            this.col_valor_venda.HeaderText = "Valor Sem Impostos";
            this.col_valor_venda.MinimumWidth = 6;
            this.col_valor_venda.Name = "col_valor_venda";
            this.col_valor_venda.Width = 50;
            // 
            // vALORPROMOCAOPRODUTODataGridViewTextBoxColumn
            // 
            this.vALORPROMOCAOPRODUTODataGridViewTextBoxColumn.DataPropertyName = "VALOR_PROMOCAO_PRODUTO";
            this.vALORPROMOCAOPRODUTODataGridViewTextBoxColumn.HeaderText = "Valor Mínimo";
            this.vALORPROMOCAOPRODUTODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vALORPROMOCAOPRODUTODataGridViewTextBoxColumn.Name = "vALORPROMOCAOPRODUTODataGridViewTextBoxColumn";
            this.vALORPROMOCAOPRODUTODataGridViewTextBoxColumn.Visible = false;
            this.vALORPROMOCAOPRODUTODataGridViewTextBoxColumn.Width = 50;
            // 
            // col_acerto_estoque
            // 
            this.col_acerto_estoque.DataPropertyName = "ACERTO_ESTOQUE_PRODUTO";
            this.col_acerto_estoque.HeaderText = "Acerto Est.";
            this.col_acerto_estoque.MinimumWidth = 6;
            this.col_acerto_estoque.Name = "col_acerto_estoque";
            this.col_acerto_estoque.Width = 35;
            // 
            // col_estoque_atual
            // 
            this.col_estoque_atual.DataPropertyName = "ESTOQUE_ATUAL_PRODUTO";
            dataGridViewCellStyle1.Format = "N2";
            this.col_estoque_atual.DefaultCellStyle = dataGridViewCellStyle1;
            this.col_estoque_atual.HeaderText = "Est. Atual";
            this.col_estoque_atual.MinimumWidth = 6;
            this.col_estoque_atual.Name = "col_estoque_atual";
            this.col_estoque_atual.ReadOnly = true;
            this.col_estoque_atual.Width = 40;
            // 
            // eSTOQUERESERVADOPRODUTODataGridViewTextBoxColumn
            // 
            this.eSTOQUERESERVADOPRODUTODataGridViewTextBoxColumn.DataPropertyName = "ESTOQUE_RESERVA_FECHADA_PRODUTO";
            dataGridViewCellStyle2.Format = "N2";
            this.eSTOQUERESERVADOPRODUTODataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.eSTOQUERESERVADOPRODUTODataGridViewTextBoxColumn.HeaderText = "Empe- nhado";
            this.eSTOQUERESERVADOPRODUTODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eSTOQUERESERVADOPRODUTODataGridViewTextBoxColumn.Name = "eSTOQUERESERVADOPRODUTODataGridViewTextBoxColumn";
            this.eSTOQUERESERVADOPRODUTODataGridViewTextBoxColumn.ReadOnly = true;
            this.eSTOQUERESERVADOPRODUTODataGridViewTextBoxColumn.Width = 40;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ESTOQUE_RESERVADO_PRODUTO";
            this.dataGridViewTextBoxColumn1.HeaderText = "Neces- sidade";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 40;
            // 
            // eSTOQUEENCOMENDADOPRODUTODataGridViewTextBoxColumn
            // 
            this.eSTOQUEENCOMENDADOPRODUTODataGridViewTextBoxColumn.DataPropertyName = "ESTOQUE_ENCOMENDADO_PRODUTO";
            this.eSTOQUEENCOMENDADOPRODUTODataGridViewTextBoxColumn.HeaderText = "Prod.";
            this.eSTOQUEENCOMENDADOPRODUTODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eSTOQUEENCOMENDADOPRODUTODataGridViewTextBoxColumn.Name = "eSTOQUEENCOMENDADOPRODUTODataGridViewTextBoxColumn";
            this.eSTOQUEENCOMENDADOPRODUTODataGridViewTextBoxColumn.Width = 40;
            // 
            // col_sep
            // 
            this.col_sep.DataPropertyName = "ESTOQUE_SEPARADO_PRODUTO";
            dataGridViewCellStyle3.Format = "N2";
            this.col_sep.DefaultCellStyle = dataGridViewCellStyle3;
            this.col_sep.HeaderText = "Separado";
            this.col_sep.MinimumWidth = 6;
            this.col_sep.Name = "col_sep";
            this.col_sep.Width = 40;
            // 
            // ESTOQUE_DISPONIVEL_PRODUTO
            // 
            this.ESTOQUE_DISPONIVEL_PRODUTO.DataPropertyName = "ESTOQUE_DISPONIVEL_PRODUTO";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.Format = "N2";
            this.ESTOQUE_DISPONIVEL_PRODUTO.DefaultCellStyle = dataGridViewCellStyle4;
            this.ESTOQUE_DISPONIVEL_PRODUTO.HeaderText = "Est. Disp.";
            this.ESTOQUE_DISPONIVEL_PRODUTO.MinimumWidth = 6;
            this.ESTOQUE_DISPONIVEL_PRODUTO.Name = "ESTOQUE_DISPONIVEL_PRODUTO";
            this.ESTOQUE_DISPONIVEL_PRODUTO.ReadOnly = true;
            this.ESTOQUE_DISPONIVEL_PRODUTO.Width = 40;
            // 
            // colEstoqueMinimo
            // 
            this.colEstoqueMinimo.DataPropertyName = "ESTOQUE_MINIMO_PRODUTO";
            dataGridViewCellStyle5.Format = "N2";
            this.colEstoqueMinimo.DefaultCellStyle = dataGridViewCellStyle5;
            this.colEstoqueMinimo.HeaderText = "Est. Mín.";
            this.colEstoqueMinimo.MinimumWidth = 6;
            this.colEstoqueMinimo.Name = "colEstoqueMinimo";
            this.colEstoqueMinimo.ReadOnly = true;
            this.colEstoqueMinimo.Width = 40;
            // 
            // col_estoque_medio
            // 
            this.col_estoque_medio.DataPropertyName = "ESTOQUE_MEDIO_PRODUTO";
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.col_estoque_medio.DefaultCellStyle = dataGridViewCellStyle6;
            this.col_estoque_medio.HeaderText = "Est. Ideal";
            this.col_estoque_medio.MinimumWidth = 6;
            this.col_estoque_medio.Name = "col_estoque_medio";
            this.col_estoque_medio.ReadOnly = true;
            this.col_estoque_medio.Visible = false;
            this.col_estoque_medio.Width = 40;
            // 
            // eSTOQUEMAXIMOPRODUTODataGridViewTextBoxColumn
            // 
            this.eSTOQUEMAXIMOPRODUTODataGridViewTextBoxColumn.DataPropertyName = "ESTOQUE_MAXIMO_PRODUTO";
            this.eSTOQUEMAXIMOPRODUTODataGridViewTextBoxColumn.HeaderText = "ESTOQUE_MAXIMO_PRODUTO";
            this.eSTOQUEMAXIMOPRODUTODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eSTOQUEMAXIMOPRODUTODataGridViewTextBoxColumn.Name = "eSTOQUEMAXIMOPRODUTODataGridViewTextBoxColumn";
            this.eSTOQUEMAXIMOPRODUTODataGridViewTextBoxColumn.Visible = false;
            this.eSTOQUEMAXIMOPRODUTODataGridViewTextBoxColumn.Width = 125;
            // 
            // cUSTOMEDPRODUTODataGridViewTextBoxColumn
            // 
            this.cUSTOMEDPRODUTODataGridViewTextBoxColumn.DataPropertyName = "CUSTO_MED_PRODUTO";
            this.cUSTOMEDPRODUTODataGridViewTextBoxColumn.HeaderText = "CUSTO_MED_PRODUTO";
            this.cUSTOMEDPRODUTODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cUSTOMEDPRODUTODataGridViewTextBoxColumn.Name = "cUSTOMEDPRODUTODataGridViewTextBoxColumn";
            this.cUSTOMEDPRODUTODataGridViewTextBoxColumn.Visible = false;
            this.cUSTOMEDPRODUTODataGridViewTextBoxColumn.Width = 125;
            // 
            // sTATUSPRODUTODataGridViewTextBoxColumn
            // 
            this.sTATUSPRODUTODataGridViewTextBoxColumn.DataPropertyName = "STATUS_PRODUTO";
            this.sTATUSPRODUTODataGridViewTextBoxColumn.FalseValue = "0";
            this.sTATUSPRODUTODataGridViewTextBoxColumn.HeaderText = "A";
            this.sTATUSPRODUTODataGridViewTextBoxColumn.IndeterminateValue = "0";
            this.sTATUSPRODUTODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sTATUSPRODUTODataGridViewTextBoxColumn.Name = "sTATUSPRODUTODataGridViewTextBoxColumn";
            this.sTATUSPRODUTODataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sTATUSPRODUTODataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sTATUSPRODUTODataGridViewTextBoxColumn.TrueValue = "1";
            this.sTATUSPRODUTODataGridViewTextBoxColumn.Width = 20;
            // 
            // RATEIO_PRODUTO
            // 
            this.RATEIO_PRODUTO.DataPropertyName = "RATEIO_PRODUTO";
            this.RATEIO_PRODUTO.FalseValue = "0";
            this.RATEIO_PRODUTO.HeaderText = "R";
            this.RATEIO_PRODUTO.IndeterminateValue = "0";
            this.RATEIO_PRODUTO.MinimumWidth = 6;
            this.RATEIO_PRODUTO.Name = "RATEIO_PRODUTO";
            this.RATEIO_PRODUTO.TrueValue = "1";
            this.RATEIO_PRODUTO.Width = 20;
            // 
            // col_custo
            // 
            this.col_custo.DataPropertyName = "CUSTO_PRODUTO";
            this.col_custo.HeaderText = "Valor Custo";
            this.col_custo.MinimumWidth = 6;
            this.col_custo.Name = "col_custo";
            this.col_custo.Width = 50;
            // 
            // col_porc
            // 
            this.col_porc.DataPropertyName = "LUCRO_PRODUTO";
            dataGridViewCellStyle7.Format = "N1";
            dataGridViewCellStyle7.NullValue = null;
            this.col_porc.DefaultCellStyle = dataGridViewCellStyle7;
            this.col_porc.HeaderText = "%";
            this.col_porc.MinimumWidth = 6;
            this.col_porc.Name = "col_porc";
            this.col_porc.ReadOnly = true;
            this.col_porc.Width = 30;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ESTOQUE_RESERVADO_PRODUTO";
            this.dataGridViewTextBoxColumn2.HeaderText = "Res. Total";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 40;
            // 
            // oUTROVALORPRODUTODataGridViewTextBoxColumn
            // 
            this.oUTROVALORPRODUTODataGridViewTextBoxColumn.DataPropertyName = "OUTRO_VALOR_PRODUTO";
            this.oUTROVALORPRODUTODataGridViewTextBoxColumn.HeaderText = "OUTRO_VALOR_PRODUTO";
            this.oUTROVALORPRODUTODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oUTROVALORPRODUTODataGridViewTextBoxColumn.Name = "oUTROVALORPRODUTODataGridViewTextBoxColumn";
            this.oUTROVALORPRODUTODataGridViewTextBoxColumn.Visible = false;
            this.oUTROVALORPRODUTODataGridViewTextBoxColumn.Width = 125;
            // 
            // lUCROPRODUTODataGridViewTextBoxColumn
            // 
            this.lUCROPRODUTODataGridViewTextBoxColumn.DataPropertyName = "LUCRO_PRODUTO";
            this.lUCROPRODUTODataGridViewTextBoxColumn.HeaderText = "LUCRO_PRODUTO";
            this.lUCROPRODUTODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lUCROPRODUTODataGridViewTextBoxColumn.Name = "lUCROPRODUTODataGridViewTextBoxColumn";
            this.lUCROPRODUTODataGridViewTextBoxColumn.Visible = false;
            this.lUCROPRODUTODataGridViewTextBoxColumn.Width = 125;
            // 
            // IVA_PRODUTO
            // 
            this.IVA_PRODUTO.DataPropertyName = "IVA_PRODUTO";
            this.IVA_PRODUTO.HeaderText = "IVA";
            this.IVA_PRODUTO.MinimumWidth = 6;
            this.IVA_PRODUTO.Name = "IVA_PRODUTO";
            this.IVA_PRODUTO.Visible = false;
            this.IVA_PRODUTO.Width = 125;
            // 
            // uLTREAJPRODUTODataGridViewTextBoxColumn
            // 
            this.uLTREAJPRODUTODataGridViewTextBoxColumn.DataPropertyName = "ULT_REAJ_PRODUTO";
            this.uLTREAJPRODUTODataGridViewTextBoxColumn.HeaderText = "ULT_REAJ_PRODUTO";
            this.uLTREAJPRODUTODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uLTREAJPRODUTODataGridViewTextBoxColumn.Name = "uLTREAJPRODUTODataGridViewTextBoxColumn";
            this.uLTREAJPRODUTODataGridViewTextBoxColumn.Visible = false;
            this.uLTREAJPRODUTODataGridViewTextBoxColumn.Width = 125;
            // 
            // pRODRECEITAPRODUTODataGridViewTextBoxColumn
            // 
            this.pRODRECEITAPRODUTODataGridViewTextBoxColumn.DataPropertyName = "PROD_RECEITA_PRODUTO";
            this.pRODRECEITAPRODUTODataGridViewTextBoxColumn.HeaderText = "PROD_RECEITA_PRODUTO";
            this.pRODRECEITAPRODUTODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pRODRECEITAPRODUTODataGridViewTextBoxColumn.Name = "pRODRECEITAPRODUTODataGridViewTextBoxColumn";
            this.pRODRECEITAPRODUTODataGridViewTextBoxColumn.Visible = false;
            this.pRODRECEITAPRODUTODataGridViewTextBoxColumn.Width = 125;
            // 
            // iCMSSNPRODUTODataGridViewTextBoxColumn
            // 
            this.iCMSSNPRODUTODataGridViewTextBoxColumn.DataPropertyName = "ICMS_S_N_PRODUTO";
            this.iCMSSNPRODUTODataGridViewTextBoxColumn.HeaderText = "ICMS_S_N_PRODUTO";
            this.iCMSSNPRODUTODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iCMSSNPRODUTODataGridViewTextBoxColumn.Name = "iCMSSNPRODUTODataGridViewTextBoxColumn";
            this.iCMSSNPRODUTODataGridViewTextBoxColumn.Visible = false;
            this.iCMSSNPRODUTODataGridViewTextBoxColumn.Width = 125;
            // 
            // aLIQUOTAICMSPRODUTODataGridViewTextBoxColumn
            // 
            this.aLIQUOTAICMSPRODUTODataGridViewTextBoxColumn.DataPropertyName = "ALIQUOTA_ICMS_PRODUTO";
            this.aLIQUOTAICMSPRODUTODataGridViewTextBoxColumn.HeaderText = "ALIQUOTA_ICMS_PRODUTO";
            this.aLIQUOTAICMSPRODUTODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aLIQUOTAICMSPRODUTODataGridViewTextBoxColumn.Name = "aLIQUOTAICMSPRODUTODataGridViewTextBoxColumn";
            this.aLIQUOTAICMSPRODUTODataGridViewTextBoxColumn.Visible = false;
            this.aLIQUOTAICMSPRODUTODataGridViewTextBoxColumn.Width = 125;
            // 
            // rEDUCAOFORAPRODUTODataGridViewTextBoxColumn
            // 
            this.rEDUCAOFORAPRODUTODataGridViewTextBoxColumn.DataPropertyName = "REDUCAO_FORA_PRODUTO";
            this.rEDUCAOFORAPRODUTODataGridViewTextBoxColumn.HeaderText = "REDUCAO_FORA_PRODUTO";
            this.rEDUCAOFORAPRODUTODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rEDUCAOFORAPRODUTODataGridViewTextBoxColumn.Name = "rEDUCAOFORAPRODUTODataGridViewTextBoxColumn";
            this.rEDUCAOFORAPRODUTODataGridViewTextBoxColumn.Visible = false;
            this.rEDUCAOFORAPRODUTODataGridViewTextBoxColumn.Width = 125;
            // 
            // aLIQUOTAIPIPRODUTODataGridViewTextBoxColumn
            // 
            this.aLIQUOTAIPIPRODUTODataGridViewTextBoxColumn.DataPropertyName = "ALIQUOTA_IPI_PRODUTO";
            this.aLIQUOTAIPIPRODUTODataGridViewTextBoxColumn.HeaderText = "ALIQUOTA_IPI_PRODUTO";
            this.aLIQUOTAIPIPRODUTODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aLIQUOTAIPIPRODUTODataGridViewTextBoxColumn.Name = "aLIQUOTAIPIPRODUTODataGridViewTextBoxColumn";
            this.aLIQUOTAIPIPRODUTODataGridViewTextBoxColumn.Visible = false;
            this.aLIQUOTAIPIPRODUTODataGridViewTextBoxColumn.Width = 125;
            // 
            // pISPRODUTODataGridViewTextBoxColumn
            // 
            this.pISPRODUTODataGridViewTextBoxColumn.DataPropertyName = "PIS_PRODUTO";
            this.pISPRODUTODataGridViewTextBoxColumn.HeaderText = "PIS_PRODUTO";
            this.pISPRODUTODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pISPRODUTODataGridViewTextBoxColumn.Name = "pISPRODUTODataGridViewTextBoxColumn";
            this.pISPRODUTODataGridViewTextBoxColumn.Visible = false;
            this.pISPRODUTODataGridViewTextBoxColumn.Width = 125;
            // 
            // cOFINSPRODUTODataGridViewTextBoxColumn
            // 
            this.cOFINSPRODUTODataGridViewTextBoxColumn.DataPropertyName = "COFINS_PRODUTO";
            this.cOFINSPRODUTODataGridViewTextBoxColumn.HeaderText = "COFINS_PRODUTO";
            this.cOFINSPRODUTODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cOFINSPRODUTODataGridViewTextBoxColumn.Name = "cOFINSPRODUTODataGridViewTextBoxColumn";
            this.cOFINSPRODUTODataGridViewTextBoxColumn.Visible = false;
            this.cOFINSPRODUTODataGridViewTextBoxColumn.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 17);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 62);
            this.button1.TabIndex = 110;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.tb_subgrupo);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.tb_fornecedor);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_familia);
            this.groupBox1.Controls.Add(this.cbxStatus);
            this.groupBox1.Controls.Add(this.txtCodBarras);
            this.groupBox1.Controls.Add(this.tb_descricao);
            this.groupBox1.Controls.Add(this.tb_grupo);
            this.groupBox1.Controls.Add(this.tb_cod);
            this.groupBox1.Location = new System.Drawing.Point(8, 185);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1512, 63);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(371, 18);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 17);
            this.label16.TabIndex = 19;
            this.label16.Text = "Sub-Grupo";
            // 
            // tb_subgrupo
            // 
            this.tb_subgrupo.Location = new System.Drawing.Point(364, 38);
            this.tb_subgrupo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_subgrupo.Name = "tb_subgrupo";
            this.tb_subgrupo.Size = new System.Drawing.Size(83, 22);
            this.tb_subgrupo.TabIndex = 18;
            this.tb_subgrupo.TextChanged += new System.EventHandler(this.tb_subgrupo_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(585, 18);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 17);
            this.label15.TabIndex = 17;
            this.label15.Text = "Fornecedor";
            // 
            // tb_fornecedor
            // 
            this.tb_fornecedor.Location = new System.Drawing.Point(580, 38);
            this.tb_fornecedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_fornecedor.Name = "tb_fornecedor";
            this.tb_fornecedor.Size = new System.Drawing.Size(119, 22);
            this.tb_fornecedor.TabIndex = 16;
            this.tb_fornecedor.TextChanged += new System.EventHandler(this.tb_fornecedor_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1167, 18);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Cód. Barras";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(713, 18);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Descrição Produto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(459, 18);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Família";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(269, 17);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Grupo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 17);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cód.";
            // 
            // tb_familia
            // 
            this.tb_familia.Location = new System.Drawing.Point(453, 38);
            this.tb_familia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_familia.Name = "tb_familia";
            this.tb_familia.Size = new System.Drawing.Size(119, 22);
            this.tb_familia.TabIndex = 3;
            this.tb_familia.TextChanged += new System.EventHandler(this.tb_familia_TextChanged);
            // 
            // cbxStatus
            // 
            this.cbxStatus.AutoSize = true;
            this.cbxStatus.Location = new System.Drawing.Point(1371, 37);
            this.cbxStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(130, 21);
            this.cbxStatus.TabIndex = 10;
            this.cbxStatus.Text = "Mostrar inativos";
            this.cbxStatus.UseVisualStyleBackColor = true;
            this.cbxStatus.CheckedChanged += new System.EventHandler(this.cbxStatus_CheckedChanged);
            this.cbxStatus.Click += new System.EventHandler(this.cbxStatus_Click);
            // 
            // txtCodBarras
            // 
            this.txtCodBarras.Location = new System.Drawing.Point(1161, 38);
            this.txtCodBarras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodBarras.Name = "txtCodBarras";
            this.txtCodBarras.Size = new System.Drawing.Size(125, 22);
            this.txtCodBarras.TabIndex = 5;
            this.txtCodBarras.TextChanged += new System.EventHandler(this.txtCodBarras_TextChanged);
            // 
            // tb_descricao
            // 
            this.tb_descricao.Location = new System.Drawing.Point(708, 38);
            this.tb_descricao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_descricao.Name = "tb_descricao";
            this.tb_descricao.Size = new System.Drawing.Size(452, 22);
            this.tb_descricao.TabIndex = 0;
            this.tb_descricao.TextChanged += new System.EventHandler(this.tb_descricao_TextChanged);
            // 
            // tb_grupo
            // 
            this.tb_grupo.Location = new System.Drawing.Point(263, 37);
            this.tb_grupo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_grupo.Name = "tb_grupo";
            this.tb_grupo.Size = new System.Drawing.Size(92, 22);
            this.tb_grupo.TabIndex = 2;
            this.tb_grupo.TextChanged += new System.EventHandler(this.tb_grupo_TextChanged);
            // 
            // tb_cod
            // 
            this.tb_cod.Location = new System.Drawing.Point(55, 37);
            this.tb_cod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_cod.Name = "tb_cod";
            this.tb_cod.Size = new System.Drawing.Size(199, 22);
            this.tb_cod.TabIndex = 1;
            this.tb_cod.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label20.Location = new System.Drawing.Point(705, 26);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(308, 58);
            this.label20.TabIndex = 119;
            this.label20.Text = "PRODUTOS";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(128, 17);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 62);
            this.button2.TabIndex = 120;
            this.button2.Text = "Criar Novo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tb_valor_estoque
            // 
            this.tb_valor_estoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_valor_estoque.Location = new System.Drawing.Point(1349, 750);
            this.tb_valor_estoque.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_valor_estoque.Name = "tb_valor_estoque";
            this.tb_valor_estoque.Size = new System.Drawing.Size(171, 30);
            this.tb_valor_estoque.TabIndex = 122;
            this.tb_valor_estoque.Visible = false;
            // 
            // cODPRODUTODataGridViewTextBoxColumn
            // 
            this.cODPRODUTODataGridViewTextBoxColumn.DataPropertyName = "COD_PRODUTO";
            this.cODPRODUTODataGridViewTextBoxColumn.HeaderText = "COD_PRODUTO";
            this.cODPRODUTODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cODPRODUTODataGridViewTextBoxColumn.Name = "cODPRODUTODataGridViewTextBoxColumn";
            this.cODPRODUTODataGridViewTextBoxColumn.Width = 125;
            // 
            // cODGRUPOPRODUTODataGridViewTextBoxColumn1
            // 
            this.cODGRUPOPRODUTODataGridViewTextBoxColumn1.DataPropertyName = "COD_GRUPO_PRODUTO";
            this.cODGRUPOPRODUTODataGridViewTextBoxColumn1.HeaderText = "COD_GRUPO_PRODUTO";
            this.cODGRUPOPRODUTODataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.cODGRUPOPRODUTODataGridViewTextBoxColumn1.Name = "cODGRUPOPRODUTODataGridViewTextBoxColumn1";
            this.cODGRUPOPRODUTODataGridViewTextBoxColumn1.Width = 125;
            // 
            // dESCRICAOGRUPOPRODUTODataGridViewTextBoxColumn
            // 
            this.dESCRICAOGRUPOPRODUTODataGridViewTextBoxColumn.DataPropertyName = "DESCRICAO_GRUPO_PRODUTO";
            this.dESCRICAOGRUPOPRODUTODataGridViewTextBoxColumn.HeaderText = "DESCRICAO_GRUPO_PRODUTO";
            this.dESCRICAOGRUPOPRODUTODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dESCRICAOGRUPOPRODUTODataGridViewTextBoxColumn.Name = "dESCRICAOGRUPOPRODUTODataGridViewTextBoxColumn";
            this.dESCRICAOGRUPOPRODUTODataGridViewTextBoxColumn.Width = 125;
            // 
            // cODSUBGRUPOPRODUTODataGridViewTextBoxColumn1
            // 
            this.cODSUBGRUPOPRODUTODataGridViewTextBoxColumn1.DataPropertyName = "COD_SUB_GRUPO_PRODUTO";
            this.cODSUBGRUPOPRODUTODataGridViewTextBoxColumn1.HeaderText = "COD_SUB_GRUPO_PRODUTO";
            this.cODSUBGRUPOPRODUTODataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.cODSUBGRUPOPRODUTODataGridViewTextBoxColumn1.Name = "cODSUBGRUPOPRODUTODataGridViewTextBoxColumn1";
            this.cODSUBGRUPOPRODUTODataGridViewTextBoxColumn1.Width = 125;
            // 
            // dESCRICAOSUBGRUPOPRODUTODataGridViewTextBoxColumn1
            // 
            this.dESCRICAOSUBGRUPOPRODUTODataGridViewTextBoxColumn1.DataPropertyName = "DESCRICAO_SUB_GRUPO_PRODUTO";
            this.dESCRICAOSUBGRUPOPRODUTODataGridViewTextBoxColumn1.HeaderText = "DESCRICAO_SUB_GRUPO_PRODUTO";
            this.dESCRICAOSUBGRUPOPRODUTODataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dESCRICAOSUBGRUPOPRODUTODataGridViewTextBoxColumn1.Name = "dESCRICAOSUBGRUPOPRODUTODataGridViewTextBoxColumn1";
            this.dESCRICAOSUBGRUPOPRODUTODataGridViewTextBoxColumn1.Width = 125;
            // 
            // dESCRICAOPRODUTODataGridViewTextBoxColumn
            // 
            this.dESCRICAOPRODUTODataGridViewTextBoxColumn.DataPropertyName = "DESCRICAO_PRODUTO";
            this.dESCRICAOPRODUTODataGridViewTextBoxColumn.HeaderText = "DESCRICAO_PRODUTO";
            this.dESCRICAOPRODUTODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dESCRICAOPRODUTODataGridViewTextBoxColumn.Name = "dESCRICAOPRODUTODataGridViewTextBoxColumn";
            this.dESCRICAOPRODUTODataGridViewTextBoxColumn.Width = 125;
            // 
            // cARACTADICPRODUTODataGridViewTextBoxColumn1
            // 
            this.cARACTADICPRODUTODataGridViewTextBoxColumn1.DataPropertyName = "CARACT_ADIC_PRODUTO";
            this.cARACTADICPRODUTODataGridViewTextBoxColumn1.HeaderText = "CARACT_ADIC_PRODUTO";
            this.cARACTADICPRODUTODataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.cARACTADICPRODUTODataGridViewTextBoxColumn1.Name = "cARACTADICPRODUTODataGridViewTextBoxColumn1";
            this.cARACTADICPRODUTODataGridViewTextBoxColumn1.Width = 125;
            // 
            // cODBARRASPRODUTODataGridViewTextBoxColumn1
            // 
            this.cODBARRASPRODUTODataGridViewTextBoxColumn1.DataPropertyName = "COD_BARRAS_PRODUTO";
            this.cODBARRASPRODUTODataGridViewTextBoxColumn1.HeaderText = "COD_BARRAS_PRODUTO";
            this.cODBARRASPRODUTODataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.cODBARRASPRODUTODataGridViewTextBoxColumn1.Name = "cODBARRASPRODUTODataGridViewTextBoxColumn1";
            this.cODBARRASPRODUTODataGridViewTextBoxColumn1.Width = 125;
            // 
            // cODONUPRODUTODataGridViewTextBoxColumn1
            // 
            this.cODONUPRODUTODataGridViewTextBoxColumn1.DataPropertyName = "COD_ONU_PRODUTO";
            this.cODONUPRODUTODataGridViewTextBoxColumn1.HeaderText = "COD_ONU_PRODUTO";
            this.cODONUPRODUTODataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.cODONUPRODUTODataGridViewTextBoxColumn1.Name = "cODONUPRODUTODataGridViewTextBoxColumn1";
            this.cODONUPRODUTODataGridViewTextBoxColumn1.Width = 125;
            // 
            // cLASSETOXICPRODUTODataGridViewTextBoxColumn1
            // 
            this.cLASSETOXICPRODUTODataGridViewTextBoxColumn1.DataPropertyName = "CLASSE_TOXIC_PRODUTO";
            this.cLASSETOXICPRODUTODataGridViewTextBoxColumn1.HeaderText = "CLASSE_TOXIC_PRODUTO";
            this.cLASSETOXICPRODUTODataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.cLASSETOXICPRODUTODataGridViewTextBoxColumn1.Name = "cLASSETOXICPRODUTODataGridViewTextBoxColumn1";
            this.cLASSETOXICPRODUTODataGridViewTextBoxColumn1.Width = 125;
            // 
            // cODUNIDADEPRODUTODataGridViewTextBoxColumn
            // 
            this.cODUNIDADEPRODUTODataGridViewTextBoxColumn.DataPropertyName = "COD_UNIDADE_PRODUTO";
            this.cODUNIDADEPRODUTODataGridViewTextBoxColumn.HeaderText = "COD_UNIDADE_PRODUTO";
            this.cODUNIDADEPRODUTODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cODUNIDADEPRODUTODataGridViewTextBoxColumn.Name = "cODUNIDADEPRODUTODataGridViewTextBoxColumn";
            this.cODUNIDADEPRODUTODataGridViewTextBoxColumn.Width = 125;
            // 
            // dESCRICAOUNIDADEPRODUTODataGridViewTextBoxColumn
            // 
            this.dESCRICAOUNIDADEPRODUTODataGridViewTextBoxColumn.DataPropertyName = "DESCRICAO_UNIDADE_PRODUTO";
            this.dESCRICAOUNIDADEPRODUTODataGridViewTextBoxColumn.HeaderText = "DESCRICAO_UNIDADE_PRODUTO";
            this.dESCRICAOUNIDADEPRODUTODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dESCRICAOUNIDADEPRODUTODataGridViewTextBoxColumn.Name = "dESCRICAOUNIDADEPRODUTODataGridViewTextBoxColumn";
            this.dESCRICAOUNIDADEPRODUTODataGridViewTextBoxColumn.Width = 125;
            // 
            // mETAANUALPRODUTODataGridViewTextBoxColumn1
            // 
            this.mETAANUALPRODUTODataGridViewTextBoxColumn1.DataPropertyName = "META_ANUAL_PRODUTO";
            this.mETAANUALPRODUTODataGridViewTextBoxColumn1.HeaderText = "META_ANUAL_PRODUTO";
            this.mETAANUALPRODUTODataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.mETAANUALPRODUTODataGridViewTextBoxColumn1.Name = "mETAANUALPRODUTODataGridViewTextBoxColumn1";
            this.mETAANUALPRODUTODataGridViewTextBoxColumn1.Width = 125;
            // 
            // cODREDUZIDOPRODUTODataGridViewTextBoxColumn1
            // 
            this.cODREDUZIDOPRODUTODataGridViewTextBoxColumn1.DataPropertyName = "COD_REDUZIDO_PRODUTO";
            this.cODREDUZIDOPRODUTODataGridViewTextBoxColumn1.HeaderText = "COD_REDUZIDO_PRODUTO";
            this.cODREDUZIDOPRODUTODataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.cODREDUZIDOPRODUTODataGridViewTextBoxColumn1.Name = "cODREDUZIDOPRODUTODataGridViewTextBoxColumn1";
            this.cODREDUZIDOPRODUTODataGridViewTextBoxColumn1.Width = 125;
            // 
            // tABPRODUTODataGridViewTextBoxColumn1
            // 
            this.tABPRODUTODataGridViewTextBoxColumn1.DataPropertyName = "TAB_PRODUTO";
            this.tABPRODUTODataGridViewTextBoxColumn1.HeaderText = "TAB_PRODUTO";
            this.tABPRODUTODataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.tABPRODUTODataGridViewTextBoxColumn1.Name = "tABPRODUTODataGridViewTextBoxColumn1";
            this.tABPRODUTODataGridViewTextBoxColumn1.Width = 125;
            // 
            // mETASEMESTRALPRODUTODataGridViewTextBoxColumn1
            // 
            this.mETASEMESTRALPRODUTODataGridViewTextBoxColumn1.DataPropertyName = "META_SEMESTRAL_PRODUTO";
            this.mETASEMESTRALPRODUTODataGridViewTextBoxColumn1.HeaderText = "META_SEMESTRAL_PRODUTO";
            this.mETASEMESTRALPRODUTODataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.mETASEMESTRALPRODUTODataGridViewTextBoxColumn1.Name = "mETASEMESTRALPRODUTODataGridViewTextBoxColumn1";
            this.mETASEMESTRALPRODUTODataGridViewTextBoxColumn1.Width = 125;
            // 
            // eSTOQUEATUALPRODUTODataGridViewTextBoxColumn1
            // 
            this.eSTOQUEATUALPRODUTODataGridViewTextBoxColumn1.DataPropertyName = "ESTOQUE_ATUAL_PRODUTO";
            this.eSTOQUEATUALPRODUTODataGridViewTextBoxColumn1.HeaderText = "ESTOQUE_ATUAL_PRODUTO";
            this.eSTOQUEATUALPRODUTODataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.eSTOQUEATUALPRODUTODataGridViewTextBoxColumn1.Name = "eSTOQUEATUALPRODUTODataGridViewTextBoxColumn1";
            this.eSTOQUEATUALPRODUTODataGridViewTextBoxColumn1.Width = 125;
            // 
            // eSTOQUERESERVADOPRODUTODataGridViewTextBoxColumn1
            // 
            this.eSTOQUERESERVADOPRODUTODataGridViewTextBoxColumn1.DataPropertyName = "ESTOQUE_RESERVADO_PRODUTO";
            this.eSTOQUERESERVADOPRODUTODataGridViewTextBoxColumn1.HeaderText = "ESTOQUE_RESERVADO_PRODUTO";
            this.eSTOQUERESERVADOPRODUTODataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.eSTOQUERESERVADOPRODUTODataGridViewTextBoxColumn1.Name = "eSTOQUERESERVADOPRODUTODataGridViewTextBoxColumn1";
            this.eSTOQUERESERVADOPRODUTODataGridViewTextBoxColumn1.Width = 125;
            // 
            // eSTOQUEMINIMOPRODUTODataGridViewTextBoxColumn1
            // 
            this.eSTOQUEMINIMOPRODUTODataGridViewTextBoxColumn1.DataPropertyName = "ESTOQUE_MINIMO_PRODUTO";
            this.eSTOQUEMINIMOPRODUTODataGridViewTextBoxColumn1.HeaderText = "ESTOQUE_MINIMO_PRODUTO";
            this.eSTOQUEMINIMOPRODUTODataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.eSTOQUEMINIMOPRODUTODataGridViewTextBoxColumn1.Name = "eSTOQUEMINIMOPRODUTODataGridViewTextBoxColumn1";
            this.eSTOQUEMINIMOPRODUTODataGridViewTextBoxColumn1.Width = 125;
            // 
            // eSTOQUEENCOMENDADOPRODUTODataGridViewTextBoxColumn1
            // 
            this.eSTOQUEENCOMENDADOPRODUTODataGridViewTextBoxColumn1.DataPropertyName = "ESTOQUE_ENCOMENDADO_PRODUTO";
            this.eSTOQUEENCOMENDADOPRODUTODataGridViewTextBoxColumn1.HeaderText = "ESTOQUE_ENCOMENDADO_PRODUTO";
            this.eSTOQUEENCOMENDADOPRODUTODataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.eSTOQUEENCOMENDADOPRODUTODataGridViewTextBoxColumn1.Name = "eSTOQUEENCOMENDADOPRODUTODataGridViewTextBoxColumn1";
            this.eSTOQUEENCOMENDADOPRODUTODataGridViewTextBoxColumn1.Width = 125;
            // 
            // eSTOQUEMAXIMOPRODUTODataGridViewTextBoxColumn1
            // 
            this.eSTOQUEMAXIMOPRODUTODataGridViewTextBoxColumn1.DataPropertyName = "ESTOQUE_MAXIMO_PRODUTO";
            this.eSTOQUEMAXIMOPRODUTODataGridViewTextBoxColumn1.HeaderText = "ESTOQUE_MAXIMO_PRODUTO";
            this.eSTOQUEMAXIMOPRODUTODataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.eSTOQUEMAXIMOPRODUTODataGridViewTextBoxColumn1.Name = "eSTOQUEMAXIMOPRODUTODataGridViewTextBoxColumn1";
            this.eSTOQUEMAXIMOPRODUTODataGridViewTextBoxColumn1.Width = 125;
            // 
            // eSTOQUEMEDIOPRODUTODataGridViewTextBoxColumn
            // 
            this.eSTOQUEMEDIOPRODUTODataGridViewTextBoxColumn.DataPropertyName = "ESTOQUE_MEDIO_PRODUTO";
            this.eSTOQUEMEDIOPRODUTODataGridViewTextBoxColumn.HeaderText = "ESTOQUE_MEDIO_PRODUTO";
            this.eSTOQUEMEDIOPRODUTODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eSTOQUEMEDIOPRODUTODataGridViewTextBoxColumn.Name = "eSTOQUEMEDIOPRODUTODataGridViewTextBoxColumn";
            this.eSTOQUEMEDIOPRODUTODataGridViewTextBoxColumn.Width = 125;
            // 
            // cUSTOPRODUTODataGridViewTextBoxColumn1
            // 
            this.cUSTOPRODUTODataGridViewTextBoxColumn1.DataPropertyName = "CUSTO_PRODUTO";
            this.cUSTOPRODUTODataGridViewTextBoxColumn1.HeaderText = "CUSTO_PRODUTO";
            this.cUSTOPRODUTODataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.cUSTOPRODUTODataGridViewTextBoxColumn1.Name = "cUSTOPRODUTODataGridViewTextBoxColumn1";
            this.cUSTOPRODUTODataGridViewTextBoxColumn1.Width = 125;
            // 
            // cUSTOMEDPRODUTODataGridViewTextBoxColumn1
            // 
            this.cUSTOMEDPRODUTODataGridViewTextBoxColumn1.DataPropertyName = "CUSTO_MED_PRODUTO";
            this.cUSTOMEDPRODUTODataGridViewTextBoxColumn1.HeaderText = "CUSTO_MED_PRODUTO";
            this.cUSTOMEDPRODUTODataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.cUSTOMEDPRODUTODataGridViewTextBoxColumn1.Name = "cUSTOMEDPRODUTODataGridViewTextBoxColumn1";
            this.cUSTOMEDPRODUTODataGridViewTextBoxColumn1.Width = 125;
            // 
            // vALORVENDAPRODUTORPRODUTODataGridViewTextBoxColumn
            // 
            this.vALORVENDAPRODUTORPRODUTODataGridViewTextBoxColumn.DataPropertyName = "VALOR_VENDA_PRODUTOR_PRODUTO";
            this.vALORVENDAPRODUTORPRODUTODataGridViewTextBoxColumn.HeaderText = "VALOR_VENDA_PRODUTOR_PRODUTO";
            this.vALORVENDAPRODUTORPRODUTODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vALORVENDAPRODUTORPRODUTODataGridViewTextBoxColumn.Name = "vALORVENDAPRODUTORPRODUTODataGridViewTextBoxColumn";
            this.vALORVENDAPRODUTORPRODUTODataGridViewTextBoxColumn.Width = 125;
            // 
            // vALORVENDAREVENDPRODUTODataGridViewTextBoxColumn1
            // 
            this.vALORVENDAREVENDPRODUTODataGridViewTextBoxColumn1.DataPropertyName = "VALOR_VENDA_REVEND_PRODUTO";
            this.vALORVENDAREVENDPRODUTODataGridViewTextBoxColumn1.HeaderText = "VALOR_VENDA_REVEND_PRODUTO";
            this.vALORVENDAREVENDPRODUTODataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.vALORVENDAREVENDPRODUTODataGridViewTextBoxColumn1.Name = "vALORVENDAREVENDPRODUTODataGridViewTextBoxColumn1";
            this.vALORVENDAREVENDPRODUTODataGridViewTextBoxColumn1.Width = 125;
            // 
            // vALORPROMOCAOPRODUTODataGridViewTextBoxColumn1
            // 
            this.vALORPROMOCAOPRODUTODataGridViewTextBoxColumn1.DataPropertyName = "VALOR_PROMOCAO_PRODUTO";
            this.vALORPROMOCAOPRODUTODataGridViewTextBoxColumn1.HeaderText = "VALOR_PROMOCAO_PRODUTO";
            this.vALORPROMOCAOPRODUTODataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.vALORPROMOCAOPRODUTODataGridViewTextBoxColumn1.Name = "vALORPROMOCAOPRODUTODataGridViewTextBoxColumn1";
            this.vALORPROMOCAOPRODUTODataGridViewTextBoxColumn1.Width = 125;
            // 
            // oUTROVALORPRODUTODataGridViewTextBoxColumn1
            // 
            this.oUTROVALORPRODUTODataGridViewTextBoxColumn1.DataPropertyName = "OUTRO_VALOR_PRODUTO";
            this.oUTROVALORPRODUTODataGridViewTextBoxColumn1.HeaderText = "OUTRO_VALOR_PRODUTO";
            this.oUTROVALORPRODUTODataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.oUTROVALORPRODUTODataGridViewTextBoxColumn1.Name = "oUTROVALORPRODUTODataGridViewTextBoxColumn1";
            this.oUTROVALORPRODUTODataGridViewTextBoxColumn1.Width = 125;
            // 
            // lUCROPRODUTODataGridViewTextBoxColumn1
            // 
            this.lUCROPRODUTODataGridViewTextBoxColumn1.DataPropertyName = "LUCRO_PRODUTO";
            this.lUCROPRODUTODataGridViewTextBoxColumn1.HeaderText = "LUCRO_PRODUTO";
            this.lUCROPRODUTODataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.lUCROPRODUTODataGridViewTextBoxColumn1.Name = "lUCROPRODUTODataGridViewTextBoxColumn1";
            this.lUCROPRODUTODataGridViewTextBoxColumn1.Width = 125;
            // 
            // uLTREAJPRODUTODataGridViewTextBoxColumn1
            // 
            this.uLTREAJPRODUTODataGridViewTextBoxColumn1.DataPropertyName = "ULT_REAJ_PRODUTO";
            this.uLTREAJPRODUTODataGridViewTextBoxColumn1.HeaderText = "ULT_REAJ_PRODUTO";
            this.uLTREAJPRODUTODataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.uLTREAJPRODUTODataGridViewTextBoxColumn1.Name = "uLTREAJPRODUTODataGridViewTextBoxColumn1";
            this.uLTREAJPRODUTODataGridViewTextBoxColumn1.Width = 125;
            // 
            // pRODRECEITAPRODUTODataGridViewTextBoxColumn1
            // 
            this.pRODRECEITAPRODUTODataGridViewTextBoxColumn1.DataPropertyName = "PROD_RECEITA_PRODUTO";
            this.pRODRECEITAPRODUTODataGridViewTextBoxColumn1.HeaderText = "PROD_RECEITA_PRODUTO";
            this.pRODRECEITAPRODUTODataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.pRODRECEITAPRODUTODataGridViewTextBoxColumn1.Name = "pRODRECEITAPRODUTODataGridViewTextBoxColumn1";
            this.pRODRECEITAPRODUTODataGridViewTextBoxColumn1.Width = 125;
            // 
            // sTATUSPRODUTODataGridViewTextBoxColumn1
            // 
            this.sTATUSPRODUTODataGridViewTextBoxColumn1.DataPropertyName = "STATUS_PRODUTO";
            this.sTATUSPRODUTODataGridViewTextBoxColumn1.HeaderText = "STATUS_PRODUTO";
            this.sTATUSPRODUTODataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.sTATUSPRODUTODataGridViewTextBoxColumn1.Name = "sTATUSPRODUTODataGridViewTextBoxColumn1";
            this.sTATUSPRODUTODataGridViewTextBoxColumn1.Width = 125;
            // 
            // iCMSSNPRODUTODataGridViewTextBoxColumn1
            // 
            this.iCMSSNPRODUTODataGridViewTextBoxColumn1.DataPropertyName = "ICMS_S_N_PRODUTO";
            this.iCMSSNPRODUTODataGridViewTextBoxColumn1.HeaderText = "ICMS_S_N_PRODUTO";
            this.iCMSSNPRODUTODataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.iCMSSNPRODUTODataGridViewTextBoxColumn1.Name = "iCMSSNPRODUTODataGridViewTextBoxColumn1";
            this.iCMSSNPRODUTODataGridViewTextBoxColumn1.Width = 125;
            // 
            // aLIQUOTAICMSPRODUTODataGridViewTextBoxColumn1
            // 
            this.aLIQUOTAICMSPRODUTODataGridViewTextBoxColumn1.DataPropertyName = "ALIQUOTA_ICMS_PRODUTO";
            this.aLIQUOTAICMSPRODUTODataGridViewTextBoxColumn1.HeaderText = "ALIQUOTA_ICMS_PRODUTO";
            this.aLIQUOTAICMSPRODUTODataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.aLIQUOTAICMSPRODUTODataGridViewTextBoxColumn1.Name = "aLIQUOTAICMSPRODUTODataGridViewTextBoxColumn1";
            this.aLIQUOTAICMSPRODUTODataGridViewTextBoxColumn1.Width = 125;
            // 
            // rEDUCAOFORAPRODUTODataGridViewTextBoxColumn1
            // 
            this.rEDUCAOFORAPRODUTODataGridViewTextBoxColumn1.DataPropertyName = "REDUCAO_FORA_PRODUTO";
            this.rEDUCAOFORAPRODUTODataGridViewTextBoxColumn1.HeaderText = "REDUCAO_FORA_PRODUTO";
            this.rEDUCAOFORAPRODUTODataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.rEDUCAOFORAPRODUTODataGridViewTextBoxColumn1.Name = "rEDUCAOFORAPRODUTODataGridViewTextBoxColumn1";
            this.rEDUCAOFORAPRODUTODataGridViewTextBoxColumn1.Width = 125;
            // 
            // aLIQUOTAIPIPRODUTODataGridViewTextBoxColumn1
            // 
            this.aLIQUOTAIPIPRODUTODataGridViewTextBoxColumn1.DataPropertyName = "ALIQUOTA_IPI_PRODUTO";
            this.aLIQUOTAIPIPRODUTODataGridViewTextBoxColumn1.HeaderText = "ALIQUOTA_IPI_PRODUTO";
            this.aLIQUOTAIPIPRODUTODataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.aLIQUOTAIPIPRODUTODataGridViewTextBoxColumn1.Name = "aLIQUOTAIPIPRODUTODataGridViewTextBoxColumn1";
            this.aLIQUOTAIPIPRODUTODataGridViewTextBoxColumn1.Width = 125;
            // 
            // pISPRODUTODataGridViewTextBoxColumn1
            // 
            this.pISPRODUTODataGridViewTextBoxColumn1.DataPropertyName = "PIS_PRODUTO";
            this.pISPRODUTODataGridViewTextBoxColumn1.HeaderText = "PIS_PRODUTO";
            this.pISPRODUTODataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.pISPRODUTODataGridViewTextBoxColumn1.Name = "pISPRODUTODataGridViewTextBoxColumn1";
            this.pISPRODUTODataGridViewTextBoxColumn1.Width = 125;
            // 
            // cOFINSPRODUTODataGridViewTextBoxColumn1
            // 
            this.cOFINSPRODUTODataGridViewTextBoxColumn1.DataPropertyName = "COFINS_PRODUTO";
            this.cOFINSPRODUTODataGridViewTextBoxColumn1.HeaderText = "COFINS_PRODUTO";
            this.cOFINSPRODUTODataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.cOFINSPRODUTODataGridViewTextBoxColumn1.Name = "cOFINSPRODUTODataGridViewTextBoxColumn1";
            this.cOFINSPRODUTODataGridViewTextBoxColumn1.Width = 125;
            // 
            // cODMARCAPRODUTODataGridViewTextBoxColumn
            // 
            this.cODMARCAPRODUTODataGridViewTextBoxColumn.DataPropertyName = "COD_MARCA_PRODUTO";
            this.cODMARCAPRODUTODataGridViewTextBoxColumn.HeaderText = "COD_MARCA_PRODUTO";
            this.cODMARCAPRODUTODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cODMARCAPRODUTODataGridViewTextBoxColumn.Name = "cODMARCAPRODUTODataGridViewTextBoxColumn";
            this.cODMARCAPRODUTODataGridViewTextBoxColumn.Width = 125;
            // 
            // mARCAPRODUTODataGridViewTextBoxColumn
            // 
            this.mARCAPRODUTODataGridViewTextBoxColumn.DataPropertyName = "MARCA_PRODUTO";
            this.mARCAPRODUTODataGridViewTextBoxColumn.HeaderText = "MARCA_PRODUTO";
            this.mARCAPRODUTODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mARCAPRODUTODataGridViewTextBoxColumn.Name = "mARCAPRODUTODataGridViewTextBoxColumn";
            this.mARCAPRODUTODataGridViewTextBoxColumn.Width = 125;
            // 
            // iVAPRODUTODataGridViewTextBoxColumn
            // 
            this.iVAPRODUTODataGridViewTextBoxColumn.DataPropertyName = "IVA_PRODUTO";
            this.iVAPRODUTODataGridViewTextBoxColumn.HeaderText = "IVA_PRODUTO";
            this.iVAPRODUTODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iVAPRODUTODataGridViewTextBoxColumn.Name = "iVAPRODUTODataGridViewTextBoxColumn";
            this.iVAPRODUTODataGridViewTextBoxColumn.Width = 125;
            // 
            // nCMPRODUTODataGridViewTextBoxColumn
            // 
            this.nCMPRODUTODataGridViewTextBoxColumn.DataPropertyName = "NCM_PRODUTO";
            this.nCMPRODUTODataGridViewTextBoxColumn.HeaderText = "NCM_PRODUTO";
            this.nCMPRODUTODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nCMPRODUTODataGridViewTextBoxColumn.Name = "nCMPRODUTODataGridViewTextBoxColumn";
            this.nCMPRODUTODataGridViewTextBoxColumn.Width = 125;
            // 
            // dESCRICAOITEMPRODUTODataGridViewTextBoxColumn
            // 
            this.dESCRICAOITEMPRODUTODataGridViewTextBoxColumn.DataPropertyName = "DESCRICAO_ITEM_PRODUTO";
            this.dESCRICAOITEMPRODUTODataGridViewTextBoxColumn.HeaderText = "DESCRICAO_ITEM_PRODUTO";
            this.dESCRICAOITEMPRODUTODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dESCRICAOITEMPRODUTODataGridViewTextBoxColumn.Name = "dESCRICAOITEMPRODUTODataGridViewTextBoxColumn";
            this.dESCRICAOITEMPRODUTODataGridViewTextBoxColumn.Width = 125;
            // 
            // cODFORNECEDORPRODUTODataGridViewTextBoxColumn
            // 
            this.cODFORNECEDORPRODUTODataGridViewTextBoxColumn.DataPropertyName = "COD_FORNECEDOR_PRODUTO";
            this.cODFORNECEDORPRODUTODataGridViewTextBoxColumn.HeaderText = "COD_FORNECEDOR_PRODUTO";
            this.cODFORNECEDORPRODUTODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cODFORNECEDORPRODUTODataGridViewTextBoxColumn.Name = "cODFORNECEDORPRODUTODataGridViewTextBoxColumn";
            this.cODFORNECEDORPRODUTODataGridViewTextBoxColumn.Width = 125;
            // 
            // oRIGEMPRODUTODataGridViewTextBoxColumn
            // 
            this.oRIGEMPRODUTODataGridViewTextBoxColumn.DataPropertyName = "ORIGEM_PRODUTO";
            this.oRIGEMPRODUTODataGridViewTextBoxColumn.HeaderText = "ORIGEM_PRODUTO";
            this.oRIGEMPRODUTODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oRIGEMPRODUTODataGridViewTextBoxColumn.Name = "oRIGEMPRODUTODataGridViewTextBoxColumn";
            this.oRIGEMPRODUTODataGridViewTextBoxColumn.Width = 125;
            // 
            // tb_valor_compra
            // 
            this.tb_valor_compra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_valor_compra.Location = new System.Drawing.Point(1349, 795);
            this.tb_valor_compra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_valor_compra.Name = "tb_valor_compra";
            this.tb_valor_compra.Size = new System.Drawing.Size(171, 30);
            this.tb_valor_compra.TabIndex = 124;
            this.tb_valor_compra.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(452, 17);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 62);
            this.button4.TabIndex = 130;
            this.button4.Text = "Acertar Estoque";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(344, 17);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 62);
            this.button5.TabIndex = 131;
            this.button5.Text = "Atualizar Tela";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(559, 17);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 62);
            this.button6.TabIndex = 132;
            this.button6.Text = "Inserir Comissão";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.tb_porcentagem);
            this.panel3.Controls.Add(this.button16);
            this.panel3.Controls.Add(this.button15);
            this.panel3.Controls.Add(this.button14);
            this.panel3.Controls.Add(this.button8);
            this.panel3.Controls.Add(this.button11);
            this.panel3.Controls.Add(this.button7);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button9);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(8, 667);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1601, 105);
            this.panel3.TabIndex = 133;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1112, 81);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(20, 17);
            this.label17.TabIndex = 141;
            this.label17.Text = "%";
            // 
            // tb_porcentagem
            // 
            this.tb_porcentagem.Location = new System.Drawing.Point(1136, 78);
            this.tb_porcentagem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_porcentagem.Name = "tb_porcentagem";
            this.tb_porcentagem.Size = new System.Drawing.Size(60, 22);
            this.tb_porcentagem.TabIndex = 140;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(1099, 17);
            this.button16.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(100, 62);
            this.button16.TabIndex = 139;
            this.button16.Text = "Ajustar Preços";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(1207, 17);
            this.button15.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(100, 62);
            this.button15.TabIndex = 138;
            this.button15.Text = "Tabela Preços";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(775, 17);
            this.button14.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(100, 62);
            this.button14.TabIndex = 135;
            this.button14.Text = "Duplicar Produto";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(236, 17);
            this.button8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(100, 62);
            this.button8.TabIndex = 134;
            this.button8.Text = "Confirmar Seleção";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(991, 17);
            this.button11.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(100, 62);
            this.button11.TabIndex = 137;
            this.button11.Text = "Salvar";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(667, 17);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 62);
            this.button7.TabIndex = 133;
            this.button7.Text = "Inserir Famílias";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(883, 17);
            this.button9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(100, 62);
            this.button9.TabIndex = 134;
            this.button9.Text = "Acerto Estoque Planilha";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackgroundImage = global::Evolucao.Properties.Resources.impressora;
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnImprimir.Location = new System.Drawing.Point(1360, 9);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(71, 63);
            this.btnImprimir.TabIndex = 135;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(1552, 9);
            this.button10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(100, 98);
            this.button10.TabIndex = 136;
            this.button10.Text = "Calcular Lucro Produto";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Visible = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // cbProdutos
            // 
            this.cbProdutos.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbProdutos.DataAdapter = this.datProdutos;
            this.cbProdutos.QuotePrefix = "\"";
            this.cbProdutos.QuoteSuffix = "\"";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.button12);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.tb_familia_pesquisa);
            this.groupBox2.Controls.Add(this.tb_cod_barras_pesquisa);
            this.groupBox2.Controls.Add(this.tb_descricao_pesquisa);
            this.groupBox2.Controls.Add(this.tb_grupo_pesquisa);
            this.groupBox2.Controls.Add(this.tb_cod_pesquisa);
            this.groupBox2.Location = new System.Drawing.Point(8, 98);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(1512, 63);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pesquisa Rápida";
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(959, 16);
            this.button12.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(100, 46);
            this.button12.TabIndex = 16;
            this.button12.Text = "Pesquisar";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(792, 16);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 17);
            this.label10.TabIndex = 15;
            this.label10.Text = "Cód. Barras";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(339, 16);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 17);
            this.label11.TabIndex = 14;
            this.label11.Text = "Descrição Produto";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(219, 16);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 17);
            this.label12.TabIndex = 13;
            this.label12.Text = "Família";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(127, 16);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 17);
            this.label13.TabIndex = 12;
            this.label13.Text = "Grupo";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(53, 16);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 17);
            this.label14.TabIndex = 11;
            this.label14.Text = "Cód.";
            // 
            // tb_familia_pesquisa
            // 
            this.tb_familia_pesquisa.Location = new System.Drawing.Point(215, 36);
            this.tb_familia_pesquisa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_familia_pesquisa.Name = "tb_familia_pesquisa";
            this.tb_familia_pesquisa.Size = new System.Drawing.Size(119, 22);
            this.tb_familia_pesquisa.TabIndex = 3;
            this.tb_familia_pesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_familia_pesquisa_KeyPress);
            // 
            // tb_cod_barras_pesquisa
            // 
            this.tb_cod_barras_pesquisa.Location = new System.Drawing.Point(788, 36);
            this.tb_cod_barras_pesquisa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_cod_barras_pesquisa.Name = "tb_cod_barras_pesquisa";
            this.tb_cod_barras_pesquisa.Size = new System.Drawing.Size(125, 22);
            this.tb_cod_barras_pesquisa.TabIndex = 5;
            this.tb_cod_barras_pesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_cod_barras_pesquisa_KeyPress);
            // 
            // tb_descricao_pesquisa
            // 
            this.tb_descricao_pesquisa.Location = new System.Drawing.Point(335, 36);
            this.tb_descricao_pesquisa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_descricao_pesquisa.Name = "tb_descricao_pesquisa";
            this.tb_descricao_pesquisa.Size = new System.Drawing.Size(452, 22);
            this.tb_descricao_pesquisa.TabIndex = 0;
            this.tb_descricao_pesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_descricao_pesquisa_KeyPress);
            // 
            // tb_grupo_pesquisa
            // 
            this.tb_grupo_pesquisa.Location = new System.Drawing.Point(121, 36);
            this.tb_grupo_pesquisa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_grupo_pesquisa.Name = "tb_grupo_pesquisa";
            this.tb_grupo_pesquisa.Size = new System.Drawing.Size(92, 22);
            this.tb_grupo_pesquisa.TabIndex = 2;
            this.tb_grupo_pesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_grupo_pesquisa_KeyPress);
            // 
            // tb_cod_pesquisa
            // 
            this.tb_cod_pesquisa.Location = new System.Drawing.Point(55, 36);
            this.tb_cod_pesquisa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_cod_pesquisa.Name = "tb_cod_pesquisa";
            this.tb_cod_pesquisa.Size = new System.Drawing.Size(65, 22);
            this.tb_cod_pesquisa.TabIndex = 1;
            this.tb_cod_pesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_cod_pesquisa_KeyPress);
            // 
            // button13
            // 
            this.button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button13.Location = new System.Drawing.Point(1245, 9);
            this.button13.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(107, 63);
            this.button13.TabIndex = 138;
            this.button13.Text = "Imprimir Composição";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Visible = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // form_localiza_produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1680, 785);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.tb_valor_compra);
            this.Controls.Add(this.tb_valor_estoque);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvProdutos);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "form_localiza_produto";
            this.Text = "Localizar Produto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.form_localiza_produto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PRODUTOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.TextBox tb_grupo;
        private System.Windows.Forms.TextBox tb_cod;
        private System.Windows.Forms.TextBox tb_descricao;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tb_valor_estoque;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
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
        private System.Data.DataColumn dataColumn8;
        private System.Windows.Forms.TextBox txtCodBarras;
        private System.Data.DataColumn dataColumn9;
        private System.Windows.Forms.CheckBox cbxStatus;
        private System.Data.DataColumn dataColumn10;
        private System.Windows.Forms.TextBox tb_familia;
        private System.Windows.Forms.Button button4;
        private System.Data.DataColumn dataColumn11;
        private System.Windows.Forms.Button button5;
        private System.Data.DataColumn dataColumn12;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button btnImprimir;
        private System.Data.DataColumn dataColumn13;
        private System.Windows.Forms.Button button10;
        private System.Data.DataColumn ESTOQUE_RESERVA_FECHADA_PRODUTO;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbProdutos;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tb_familia_pesquisa;
        private System.Windows.Forms.TextBox tb_cod_barras_pesquisa;
        private System.Windows.Forms.TextBox tb_descricao_pesquisa;
        private System.Windows.Forms.TextBox tb_grupo_pesquisa;
        private System.Windows.Forms.TextBox tb_cod_pesquisa;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Data.DataColumn dataColumn14;
        private System.Data.DataColumn dataColumn15;
        private System.Data.DataColumn dataColumn16;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod_forn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODGRUPOPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_grupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRICAOSUBGRUPOPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_MARCA_PRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODSUBGRUPOPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_FAMILIA_PRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_FORNECEDOR_PRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn cARACTADICPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod_ean;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_BARRAS_CAIXA_PRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_uni;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODONUPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLASSETOXICPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_uni2;
        private System.Windows.Forms.DataGridViewTextBoxColumn mETAANUALPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODREDUZIDOPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tABPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mETASEMESTRALPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOCALIZACAO_PRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_valor_venda;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORPROMOCAOPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_acerto_estoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_estoque_atual;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTOQUERESERVADOPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTOQUEENCOMENDADOPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_sep;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTOQUE_DISPONIVEL_PRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstoqueMinimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_estoque_medio;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTOQUEMAXIMOPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSTOMEDPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sTATUSPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn RATEIO_PRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_custo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_porc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
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
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tb_subgrupo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tb_fornecedor;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tb_porcentagem;
    }
}