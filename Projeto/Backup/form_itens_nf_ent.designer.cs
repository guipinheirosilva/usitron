namespace Evolucao
{
    partial class form_itens_nf_ent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_itens_nf_ent));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.datItens_nota_ent = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsItens_nota_ent = new System.Data.DataSet();
            this.ITENS_NOTA_ENT = new System.Data.DataTable();
            this.COD_ITENS_NOTA_ENT = new System.Data.DataColumn();
            this.DESCRICAO_ITEM_ENT = new System.Data.DataColumn();
            this.UNIDADE_ITEM_ENT = new System.Data.DataColumn();
            this.QTDE_ITEM_ENT = new System.Data.DataColumn();
            this.ST_ITEM_ENT = new System.Data.DataColumn();
            this.PRECO_UNIT_ITEM_ENT = new System.Data.DataColumn();
            this.PRECO_TOTAL_ITEM_ENT = new System.Data.DataColumn();
            this.IPI_ITEM_ENT = new System.Data.DataColumn();
            this.ICM_ITEM_ENT = new System.Data.DataColumn();
            this.NF_ITEM_ENT = new System.Data.DataColumn();
            this.VALOR_IPI_ITEM_ENT = new System.Data.DataColumn();
            this.PEDIDO_COMPRA_ITEM_ENT = new System.Data.DataColumn();
            this.MAE_ITEM_ENT = new System.Data.DataColumn();
            this.COD_ITEM_ENT = new System.Data.DataColumn();
            this.CFOP_ITEM_ENT = new System.Data.DataColumn();
            this.VALOR_ICM_ITEM_ENT = new System.Data.DataColumn();
            this.VALOR_ISS_ITEM_ENT = new System.Data.DataColumn();
            this.PRESTACAO_SERVICO_ITEM_ENT = new System.Data.DataColumn();
            this.VALOR_BC_ITEM_ENT = new System.Data.DataColumn();
            this.COD_COMISSIONARIO_ITEM_ENT = new System.Data.DataColumn();
            this.VALOR_UNIT_COMISSAO_ITEM_ENT = new System.Data.DataColumn();
            this.VALOR_TOTAL_COMISSAO_ITEM_ENT = new System.Data.DataColumn();
            this.DATA_INSERCAO_ITEM_ENT_NOTA = new System.Data.DataColumn();
            this.CNPJ_CLIENTE_ITEM_ENT = new System.Data.DataColumn();
            this.STATUS_ATUAL_NFE_ENT = new System.Data.DataColumn();
            this.PORC_COMISSAO_ITEM_ENT = new System.Data.DataColumn();
            this.N_LINHA_PED_ITEM_ENT = new System.Data.DataColumn();
            this.VALOR_BC_ICMS_ST_ITEM_ENT = new System.Data.DataColumn();
            this.VALOR_ICMS_ST_ITEM_ENT = new System.Data.DataColumn();
            this.VALOR_FRETE_ITEM_ENT = new System.Data.DataColumn();
            this.VALOR_DESCONTO_ITEM_ENT = new System.Data.DataColumn();
            this.VALOR_SEGURO_ITEM_ENT = new System.Data.DataColumn();
            this.VALOR_OUTRAS_DESP_ITEM_ENT = new System.Data.DataColumn();
            this.IVA_ITEM_ENT = new System.Data.DataColumn();
            this.REDUCAO_ITEM_ENT = new System.Data.DataColumn();
            this.COFINS_ITEM_ENT = new System.Data.DataColumn();
            this.VALOR_COFINS_ITEM_ENT = new System.Data.DataColumn();
            this.PIS_ITEM_ENT = new System.Data.DataColumn();
            this.VALOR_PIS_ITEM_ENT = new System.Data.DataColumn();
            this.ORIGEM_ITEM_ENT = new System.Data.DataColumn();
            this.MOD_BC_ITEM_ENT = new System.Data.DataColumn();
            this.ISS_ITEM_ENT = new System.Data.DataColumn();
            this.MOD_BC_ST_ITEM_ENT = new System.Data.DataColumn();
            this.REDUCAO_ST_ITEM_ENT = new System.Data.DataColumn();
            this.ICMS_ST_ITEM_ENT = new System.Data.DataColumn();
            this.ALIQUOTA_CREDITO_ITEM_ENT = new System.Data.DataColumn();
            this.VALOR_CREDITO_ITEM_ENT = new System.Data.DataColumn();
            this.IPI_TRIB_ITEM_ENT = new System.Data.DataColumn();
            this.IPI_N_TRIB_ITEM_ENT = new System.Data.DataColumn();
            this.CST_IPI_TRIB_ITEM_ENT = new System.Data.DataColumn();
            this.CST_IPI_N_TRIB_ITEM_ENT = new System.Data.DataColumn();
            this.TIPO_PIS_ITEM_ENT = new System.Data.DataColumn();
            this.CST_PIS_ITEM_ENT = new System.Data.DataColumn();
            this.TIPO_COFINS_ITEM_ENT = new System.Data.DataColumn();
            this.CST_COFINS_ITEM_ENT = new System.Data.DataColumn();
            this.TIPO_SERVICO_ITEM_ENT = new System.Data.DataColumn();
            this.ITEM_PEDIDO_COMPRA_ITEM_ENT = new System.Data.DataColumn();
            this.BC_IPI_ITEM_ENT = new System.Data.DataColumn();
            this.BC_PIS_ITEM_ENT = new System.Data.DataColumn();
            this.BC_COFINS_ITEM_ENT = new System.Data.DataColumn();
            this.BC_ISS_ITEM_ENT = new System.Data.DataColumn();
            this.BC_COM_IPI_ITEM_ENT = new System.Data.DataColumn();
            this.ST_IMPRESSAO_ITEM_ENT = new System.Data.DataColumn();
            this.ROTA_ITEM_ENT = new System.Data.DataColumn();
            this.DI_ITEM_ENT = new System.Data.DataColumn();
            this.DATA_DI_ITEM_ENT = new System.Data.DataColumn();
            this.LOCAL_DES_ITEM_ENT = new System.Data.DataColumn();
            this.UF_DES_ITEM_ENT = new System.Data.DataColumn();
            this.DATA_DES_ITEM_ENT = new System.Data.DataColumn();
            this.COD_EXP_ITEM_ENT = new System.Data.DataColumn();
            this.COD_ITEM_REQ_ITEM_ENT = new System.Data.DataColumn();
            this.COD_ITEM_PED_ITEM_ENT = new System.Data.DataColumn();
            this.COD_ITEM_EST_ITEM_ENT = new System.Data.DataColumn();
            this.COD_SISTEMA_NF_ITEM_ENT = new System.Data.DataColumn();
            this.NCM_ITEM_ENT = new System.Data.DataColumn();
            this.LOTE_ITEM_ENT = new System.Data.DataColumn();
            this.QTDE_LOTE_ITEM_ENT = new System.Data.DataColumn();
            this.NOME_PROPRIETARIO_ITEM_ENT = new System.Data.DataColumn();
            this.CNPJ_PROPRIETARIO_ITEM_ENT = new System.Data.DataColumn();
            this.BAIXADO_ITEM_ENT = new System.Data.DataColumn();
            this.MATERIA_PRIMA_ITEM_ENT = new System.Data.DataColumn();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dgvItens_nota = new System.Windows.Forms.DataGridView();
            this.col_nf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cod_nf_sistema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRICAOITEMENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cod_item_nota_ent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_qtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_preco_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ncm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_novo_lote = new System.Windows.Forms.DataGridViewButtonColumn();
            this.col_lote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_qtde_lote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNPJ_CLIENTE_FORN_ENT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLIENTE_FORN_NF_ENT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cnpj_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_n_linha_ped = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cod_item_req = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cod_item_ped = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cod_item_est = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_buscar_item_est = new System.Windows.Forms.DataGridViewButtonColumn();
            this.col_data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbAguardando = new System.Windows.Forms.RadioButton();
            this.rbTodos_itens = new System.Windows.Forms.RadioButton();
            this.rbEntrada_efetuada = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cb_data = new System.Windows.Forms.CheckBox();
            this.dtFinal = new System.Windows.Forms.DateTimePicker();
            this.dtInicial = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbAlmoxarifado = new System.Windows.Forms.RadioButton();
            this.rbMateria_prima = new System.Windows.Forms.RadioButton();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.tb_codigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_localidade = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbItens_nota_ent = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.button2 = new System.Windows.Forms.Button();
            this.datItens_req = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand8 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand6 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand5 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand7 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.datItens_ped = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand12 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand10 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand9 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand11 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.button3 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tb_cod_item_estoque = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_nota_fiscal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_descricao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_lote = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsItens_nota_ent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITENS_NOTA_ENT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens_nota)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // datItens_nota_ent
            // 
            this.datItens_nota_ent.DeleteCommand = this.fbCommand4;
            this.datItens_nota_ent.InsertCommand = this.fbCommand2;
            this.datItens_nota_ent.SelectCommand = this.fbCommand1;
            this.datItens_nota_ent.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * from itens_nota_ent";
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
            // dsItens_nota_ent
            // 
            this.dsItens_nota_ent.DataSetName = "dsItens_nota_ent";
            this.dsItens_nota_ent.Namespace = "http://www.tempuri.org/dsItens_nota_ent.xsd";
            this.dsItens_nota_ent.Tables.AddRange(new System.Data.DataTable[] {
            this.ITENS_NOTA_ENT});
            // 
            // ITENS_NOTA_ENT
            // 
            this.ITENS_NOTA_ENT.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_ITENS_NOTA_ENT,
            this.DESCRICAO_ITEM_ENT,
            this.UNIDADE_ITEM_ENT,
            this.QTDE_ITEM_ENT,
            this.ST_ITEM_ENT,
            this.PRECO_UNIT_ITEM_ENT,
            this.PRECO_TOTAL_ITEM_ENT,
            this.IPI_ITEM_ENT,
            this.ICM_ITEM_ENT,
            this.NF_ITEM_ENT,
            this.VALOR_IPI_ITEM_ENT,
            this.PEDIDO_COMPRA_ITEM_ENT,
            this.MAE_ITEM_ENT,
            this.COD_ITEM_ENT,
            this.CFOP_ITEM_ENT,
            this.VALOR_ICM_ITEM_ENT,
            this.VALOR_ISS_ITEM_ENT,
            this.PRESTACAO_SERVICO_ITEM_ENT,
            this.VALOR_BC_ITEM_ENT,
            this.COD_COMISSIONARIO_ITEM_ENT,
            this.VALOR_UNIT_COMISSAO_ITEM_ENT,
            this.VALOR_TOTAL_COMISSAO_ITEM_ENT,
            this.DATA_INSERCAO_ITEM_ENT_NOTA,
            this.CNPJ_CLIENTE_ITEM_ENT,
            this.STATUS_ATUAL_NFE_ENT,
            this.PORC_COMISSAO_ITEM_ENT,
            this.N_LINHA_PED_ITEM_ENT,
            this.VALOR_BC_ICMS_ST_ITEM_ENT,
            this.VALOR_ICMS_ST_ITEM_ENT,
            this.VALOR_FRETE_ITEM_ENT,
            this.VALOR_DESCONTO_ITEM_ENT,
            this.VALOR_SEGURO_ITEM_ENT,
            this.VALOR_OUTRAS_DESP_ITEM_ENT,
            this.IVA_ITEM_ENT,
            this.REDUCAO_ITEM_ENT,
            this.COFINS_ITEM_ENT,
            this.VALOR_COFINS_ITEM_ENT,
            this.PIS_ITEM_ENT,
            this.VALOR_PIS_ITEM_ENT,
            this.ORIGEM_ITEM_ENT,
            this.MOD_BC_ITEM_ENT,
            this.ISS_ITEM_ENT,
            this.MOD_BC_ST_ITEM_ENT,
            this.REDUCAO_ST_ITEM_ENT,
            this.ICMS_ST_ITEM_ENT,
            this.ALIQUOTA_CREDITO_ITEM_ENT,
            this.VALOR_CREDITO_ITEM_ENT,
            this.IPI_TRIB_ITEM_ENT,
            this.IPI_N_TRIB_ITEM_ENT,
            this.CST_IPI_TRIB_ITEM_ENT,
            this.CST_IPI_N_TRIB_ITEM_ENT,
            this.TIPO_PIS_ITEM_ENT,
            this.CST_PIS_ITEM_ENT,
            this.TIPO_COFINS_ITEM_ENT,
            this.CST_COFINS_ITEM_ENT,
            this.TIPO_SERVICO_ITEM_ENT,
            this.ITEM_PEDIDO_COMPRA_ITEM_ENT,
            this.BC_IPI_ITEM_ENT,
            this.BC_PIS_ITEM_ENT,
            this.BC_COFINS_ITEM_ENT,
            this.BC_ISS_ITEM_ENT,
            this.BC_COM_IPI_ITEM_ENT,
            this.ST_IMPRESSAO_ITEM_ENT,
            this.ROTA_ITEM_ENT,
            this.DI_ITEM_ENT,
            this.DATA_DI_ITEM_ENT,
            this.LOCAL_DES_ITEM_ENT,
            this.UF_DES_ITEM_ENT,
            this.DATA_DES_ITEM_ENT,
            this.COD_EXP_ITEM_ENT,
            this.COD_ITEM_REQ_ITEM_ENT,
            this.COD_ITEM_PED_ITEM_ENT,
            this.COD_ITEM_EST_ITEM_ENT,
            this.COD_SISTEMA_NF_ITEM_ENT,
            this.NCM_ITEM_ENT,
            this.LOTE_ITEM_ENT,
            this.QTDE_LOTE_ITEM_ENT,
            this.NOME_PROPRIETARIO_ITEM_ENT,
            this.CNPJ_PROPRIETARIO_ITEM_ENT,
            this.BAIXADO_ITEM_ENT,
            this.MATERIA_PRIMA_ITEM_ENT,
            this.dataColumn1,
            this.dataColumn2});
            this.ITENS_NOTA_ENT.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_ITENS_NOTA_ENT"}, true)});
            this.ITENS_NOTA_ENT.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_ITENS_NOTA_ENT};
            this.ITENS_NOTA_ENT.TableName = "ITENS_NOTA_ENT";
            // 
            // COD_ITENS_NOTA_ENT
            // 
            this.COD_ITENS_NOTA_ENT.AllowDBNull = false;
            this.COD_ITENS_NOTA_ENT.ColumnName = "COD_ITENS_NOTA_ENT";
            this.COD_ITENS_NOTA_ENT.DataType = typeof(int);
            // 
            // DESCRICAO_ITEM_ENT
            // 
            this.DESCRICAO_ITEM_ENT.ColumnName = "DESCRICAO_ITEM_ENT";
            this.DESCRICAO_ITEM_ENT.MaxLength = 120;
            // 
            // UNIDADE_ITEM_ENT
            // 
            this.UNIDADE_ITEM_ENT.ColumnName = "UNIDADE_ITEM_ENT";
            this.UNIDADE_ITEM_ENT.MaxLength = 10;
            // 
            // QTDE_ITEM_ENT
            // 
            this.QTDE_ITEM_ENT.ColumnName = "QTDE_ITEM_ENT";
            this.QTDE_ITEM_ENT.DataType = typeof(double);
            // 
            // ST_ITEM_ENT
            // 
            this.ST_ITEM_ENT.ColumnName = "ST_ITEM_ENT";
            this.ST_ITEM_ENT.MaxLength = 40;
            // 
            // PRECO_UNIT_ITEM_ENT
            // 
            this.PRECO_UNIT_ITEM_ENT.ColumnName = "PRECO_UNIT_ITEM_ENT";
            this.PRECO_UNIT_ITEM_ENT.DataType = typeof(double);
            // 
            // PRECO_TOTAL_ITEM_ENT
            // 
            this.PRECO_TOTAL_ITEM_ENT.ColumnName = "PRECO_TOTAL_ITEM_ENT";
            this.PRECO_TOTAL_ITEM_ENT.DataType = typeof(double);
            // 
            // IPI_ITEM_ENT
            // 
            this.IPI_ITEM_ENT.ColumnName = "IPI_ITEM_ENT";
            this.IPI_ITEM_ENT.DataType = typeof(double);
            // 
            // ICM_ITEM_ENT
            // 
            this.ICM_ITEM_ENT.ColumnName = "ICM_ITEM_ENT";
            this.ICM_ITEM_ENT.DataType = typeof(double);
            // 
            // NF_ITEM_ENT
            // 
            this.NF_ITEM_ENT.ColumnName = "NF_ITEM_ENT";
            this.NF_ITEM_ENT.DataType = typeof(int);
            // 
            // VALOR_IPI_ITEM_ENT
            // 
            this.VALOR_IPI_ITEM_ENT.ColumnName = "VALOR_IPI_ITEM_ENT";
            this.VALOR_IPI_ITEM_ENT.DataType = typeof(double);
            // 
            // PEDIDO_COMPRA_ITEM_ENT
            // 
            this.PEDIDO_COMPRA_ITEM_ENT.ColumnName = "PEDIDO_COMPRA_ITEM_ENT";
            this.PEDIDO_COMPRA_ITEM_ENT.MaxLength = 20;
            // 
            // MAE_ITEM_ENT
            // 
            this.MAE_ITEM_ENT.ColumnName = "MAE_ITEM_ENT";
            this.MAE_ITEM_ENT.DataType = typeof(int);
            // 
            // COD_ITEM_ENT
            // 
            this.COD_ITEM_ENT.ColumnName = "COD_ITEM_ENT";
            this.COD_ITEM_ENT.MaxLength = 100;
            // 
            // CFOP_ITEM_ENT
            // 
            this.CFOP_ITEM_ENT.ColumnName = "CFOP_ITEM_ENT";
            this.CFOP_ITEM_ENT.MaxLength = 10;
            // 
            // VALOR_ICM_ITEM_ENT
            // 
            this.VALOR_ICM_ITEM_ENT.ColumnName = "VALOR_ICM_ITEM_ENT";
            this.VALOR_ICM_ITEM_ENT.DataType = typeof(double);
            // 
            // VALOR_ISS_ITEM_ENT
            // 
            this.VALOR_ISS_ITEM_ENT.ColumnName = "VALOR_ISS_ITEM_ENT";
            this.VALOR_ISS_ITEM_ENT.DataType = typeof(double);
            // 
            // PRESTACAO_SERVICO_ITEM_ENT
            // 
            this.PRESTACAO_SERVICO_ITEM_ENT.ColumnName = "PRESTACAO_SERVICO_ITEM_ENT";
            this.PRESTACAO_SERVICO_ITEM_ENT.DataType = typeof(int);
            // 
            // VALOR_BC_ITEM_ENT
            // 
            this.VALOR_BC_ITEM_ENT.ColumnName = "VALOR_BC_ITEM_ENT";
            this.VALOR_BC_ITEM_ENT.DataType = typeof(double);
            // 
            // COD_COMISSIONARIO_ITEM_ENT
            // 
            this.COD_COMISSIONARIO_ITEM_ENT.ColumnName = "COD_COMISSIONARIO_ITEM_ENT";
            this.COD_COMISSIONARIO_ITEM_ENT.DataType = typeof(int);
            // 
            // VALOR_UNIT_COMISSAO_ITEM_ENT
            // 
            this.VALOR_UNIT_COMISSAO_ITEM_ENT.ColumnName = "VALOR_UNIT_COMISSAO_ITEM_ENT";
            this.VALOR_UNIT_COMISSAO_ITEM_ENT.DataType = typeof(double);
            // 
            // VALOR_TOTAL_COMISSAO_ITEM_ENT
            // 
            this.VALOR_TOTAL_COMISSAO_ITEM_ENT.ColumnName = "VALOR_TOTAL_COMISSAO_ITEM_ENT";
            this.VALOR_TOTAL_COMISSAO_ITEM_ENT.DataType = typeof(double);
            // 
            // DATA_INSERCAO_ITEM_ENT_NOTA
            // 
            this.DATA_INSERCAO_ITEM_ENT_NOTA.ColumnName = "DATA_INSERCAO_ITEM_ENT_NOTA";
            this.DATA_INSERCAO_ITEM_ENT_NOTA.DataType = typeof(System.DateTime);
            // 
            // CNPJ_CLIENTE_ITEM_ENT
            // 
            this.CNPJ_CLIENTE_ITEM_ENT.ColumnName = "CNPJ_CLIENTE_ITEM_ENT";
            this.CNPJ_CLIENTE_ITEM_ENT.MaxLength = 50;
            // 
            // STATUS_ATUAL_NFE_ENT
            // 
            this.STATUS_ATUAL_NFE_ENT.ColumnName = "STATUS_ATUAL_NFE_ENT";
            this.STATUS_ATUAL_NFE_ENT.MaxLength = 100;
            // 
            // PORC_COMISSAO_ITEM_ENT
            // 
            this.PORC_COMISSAO_ITEM_ENT.ColumnName = "PORC_COMISSAO_ITEM_ENT";
            this.PORC_COMISSAO_ITEM_ENT.DataType = typeof(double);
            // 
            // N_LINHA_PED_ITEM_ENT
            // 
            this.N_LINHA_PED_ITEM_ENT.ColumnName = "N_LINHA_PED_ITEM_ENT";
            this.N_LINHA_PED_ITEM_ENT.MaxLength = 100;
            // 
            // VALOR_BC_ICMS_ST_ITEM_ENT
            // 
            this.VALOR_BC_ICMS_ST_ITEM_ENT.ColumnName = "VALOR_BC_ICMS_ST_ITEM_ENT";
            this.VALOR_BC_ICMS_ST_ITEM_ENT.DataType = typeof(double);
            // 
            // VALOR_ICMS_ST_ITEM_ENT
            // 
            this.VALOR_ICMS_ST_ITEM_ENT.ColumnName = "VALOR_ICMS_ST_ITEM_ENT";
            this.VALOR_ICMS_ST_ITEM_ENT.DataType = typeof(double);
            // 
            // VALOR_FRETE_ITEM_ENT
            // 
            this.VALOR_FRETE_ITEM_ENT.ColumnName = "VALOR_FRETE_ITEM_ENT";
            this.VALOR_FRETE_ITEM_ENT.DataType = typeof(double);
            // 
            // VALOR_DESCONTO_ITEM_ENT
            // 
            this.VALOR_DESCONTO_ITEM_ENT.ColumnName = "VALOR_DESCONTO_ITEM_ENT";
            this.VALOR_DESCONTO_ITEM_ENT.DataType = typeof(double);
            // 
            // VALOR_SEGURO_ITEM_ENT
            // 
            this.VALOR_SEGURO_ITEM_ENT.ColumnName = "VALOR_SEGURO_ITEM_ENT";
            this.VALOR_SEGURO_ITEM_ENT.DataType = typeof(double);
            // 
            // VALOR_OUTRAS_DESP_ITEM_ENT
            // 
            this.VALOR_OUTRAS_DESP_ITEM_ENT.ColumnName = "VALOR_OUTRAS_DESP_ITEM_ENT";
            this.VALOR_OUTRAS_DESP_ITEM_ENT.DataType = typeof(double);
            // 
            // IVA_ITEM_ENT
            // 
            this.IVA_ITEM_ENT.ColumnName = "IVA_ITEM_ENT";
            this.IVA_ITEM_ENT.DataType = typeof(double);
            // 
            // REDUCAO_ITEM_ENT
            // 
            this.REDUCAO_ITEM_ENT.ColumnName = "REDUCAO_ITEM_ENT";
            this.REDUCAO_ITEM_ENT.DataType = typeof(double);
            // 
            // COFINS_ITEM_ENT
            // 
            this.COFINS_ITEM_ENT.ColumnName = "COFINS_ITEM_ENT";
            this.COFINS_ITEM_ENT.DataType = typeof(double);
            // 
            // VALOR_COFINS_ITEM_ENT
            // 
            this.VALOR_COFINS_ITEM_ENT.ColumnName = "VALOR_COFINS_ITEM_ENT";
            this.VALOR_COFINS_ITEM_ENT.DataType = typeof(double);
            // 
            // PIS_ITEM_ENT
            // 
            this.PIS_ITEM_ENT.ColumnName = "PIS_ITEM_ENT";
            this.PIS_ITEM_ENT.DataType = typeof(double);
            // 
            // VALOR_PIS_ITEM_ENT
            // 
            this.VALOR_PIS_ITEM_ENT.ColumnName = "VALOR_PIS_ITEM_ENT";
            this.VALOR_PIS_ITEM_ENT.DataType = typeof(double);
            // 
            // ORIGEM_ITEM_ENT
            // 
            this.ORIGEM_ITEM_ENT.ColumnName = "ORIGEM_ITEM_ENT";
            this.ORIGEM_ITEM_ENT.MaxLength = 1;
            // 
            // MOD_BC_ITEM_ENT
            // 
            this.MOD_BC_ITEM_ENT.ColumnName = "MOD_BC_ITEM_ENT";
            this.MOD_BC_ITEM_ENT.MaxLength = 100;
            // 
            // ISS_ITEM_ENT
            // 
            this.ISS_ITEM_ENT.ColumnName = "ISS_ITEM_ENT";
            this.ISS_ITEM_ENT.DataType = typeof(double);
            // 
            // MOD_BC_ST_ITEM_ENT
            // 
            this.MOD_BC_ST_ITEM_ENT.ColumnName = "MOD_BC_ST_ITEM_ENT";
            this.MOD_BC_ST_ITEM_ENT.MaxLength = 100;
            // 
            // REDUCAO_ST_ITEM_ENT
            // 
            this.REDUCAO_ST_ITEM_ENT.ColumnName = "REDUCAO_ST_ITEM_ENT";
            this.REDUCAO_ST_ITEM_ENT.DataType = typeof(double);
            // 
            // ICMS_ST_ITEM_ENT
            // 
            this.ICMS_ST_ITEM_ENT.ColumnName = "ICMS_ST_ITEM_ENT";
            this.ICMS_ST_ITEM_ENT.DataType = typeof(double);
            // 
            // ALIQUOTA_CREDITO_ITEM_ENT
            // 
            this.ALIQUOTA_CREDITO_ITEM_ENT.ColumnName = "ALIQUOTA_CREDITO_ITEM_ENT";
            this.ALIQUOTA_CREDITO_ITEM_ENT.DataType = typeof(double);
            // 
            // VALOR_CREDITO_ITEM_ENT
            // 
            this.VALOR_CREDITO_ITEM_ENT.ColumnName = "VALOR_CREDITO_ITEM_ENT";
            this.VALOR_CREDITO_ITEM_ENT.DataType = typeof(double);
            // 
            // IPI_TRIB_ITEM_ENT
            // 
            this.IPI_TRIB_ITEM_ENT.ColumnName = "IPI_TRIB_ITEM_ENT";
            this.IPI_TRIB_ITEM_ENT.DataType = typeof(int);
            // 
            // IPI_N_TRIB_ITEM_ENT
            // 
            this.IPI_N_TRIB_ITEM_ENT.ColumnName = "IPI_N_TRIB_ITEM_ENT";
            this.IPI_N_TRIB_ITEM_ENT.DataType = typeof(int);
            // 
            // CST_IPI_TRIB_ITEM_ENT
            // 
            this.CST_IPI_TRIB_ITEM_ENT.ColumnName = "CST_IPI_TRIB_ITEM_ENT";
            this.CST_IPI_TRIB_ITEM_ENT.MaxLength = 100;
            // 
            // CST_IPI_N_TRIB_ITEM_ENT
            // 
            this.CST_IPI_N_TRIB_ITEM_ENT.ColumnName = "CST_IPI_N_TRIB_ITEM_ENT";
            this.CST_IPI_N_TRIB_ITEM_ENT.MaxLength = 100;
            // 
            // TIPO_PIS_ITEM_ENT
            // 
            this.TIPO_PIS_ITEM_ENT.ColumnName = "TIPO_PIS_ITEM_ENT";
            this.TIPO_PIS_ITEM_ENT.MaxLength = 100;
            // 
            // CST_PIS_ITEM_ENT
            // 
            this.CST_PIS_ITEM_ENT.ColumnName = "CST_PIS_ITEM_ENT";
            this.CST_PIS_ITEM_ENT.MaxLength = 200;
            // 
            // TIPO_COFINS_ITEM_ENT
            // 
            this.TIPO_COFINS_ITEM_ENT.ColumnName = "TIPO_COFINS_ITEM_ENT";
            this.TIPO_COFINS_ITEM_ENT.MaxLength = 100;
            // 
            // CST_COFINS_ITEM_ENT
            // 
            this.CST_COFINS_ITEM_ENT.ColumnName = "CST_COFINS_ITEM_ENT";
            this.CST_COFINS_ITEM_ENT.MaxLength = 200;
            // 
            // TIPO_SERVICO_ITEM_ENT
            // 
            this.TIPO_SERVICO_ITEM_ENT.ColumnName = "TIPO_SERVICO_ITEM_ENT";
            this.TIPO_SERVICO_ITEM_ENT.MaxLength = 100;
            // 
            // ITEM_PEDIDO_COMPRA_ITEM_ENT
            // 
            this.ITEM_PEDIDO_COMPRA_ITEM_ENT.ColumnName = "ITEM_PEDIDO_COMPRA_ITEM_ENT";
            this.ITEM_PEDIDO_COMPRA_ITEM_ENT.MaxLength = 100;
            // 
            // BC_IPI_ITEM_ENT
            // 
            this.BC_IPI_ITEM_ENT.ColumnName = "BC_IPI_ITEM_ENT";
            this.BC_IPI_ITEM_ENT.DataType = typeof(double);
            // 
            // BC_PIS_ITEM_ENT
            // 
            this.BC_PIS_ITEM_ENT.ColumnName = "BC_PIS_ITEM_ENT";
            this.BC_PIS_ITEM_ENT.DataType = typeof(double);
            // 
            // BC_COFINS_ITEM_ENT
            // 
            this.BC_COFINS_ITEM_ENT.ColumnName = "BC_COFINS_ITEM_ENT";
            this.BC_COFINS_ITEM_ENT.DataType = typeof(double);
            // 
            // BC_ISS_ITEM_ENT
            // 
            this.BC_ISS_ITEM_ENT.ColumnName = "BC_ISS_ITEM_ENT";
            this.BC_ISS_ITEM_ENT.DataType = typeof(double);
            // 
            // BC_COM_IPI_ITEM_ENT
            // 
            this.BC_COM_IPI_ITEM_ENT.ColumnName = "BC_COM_IPI_ITEM_ENT";
            this.BC_COM_IPI_ITEM_ENT.DataType = typeof(int);
            // 
            // ST_IMPRESSAO_ITEM_ENT
            // 
            this.ST_IMPRESSAO_ITEM_ENT.ColumnName = "ST_IMPRESSAO_ITEM_ENT";
            this.ST_IMPRESSAO_ITEM_ENT.MaxLength = 4;
            // 
            // ROTA_ITEM_ENT
            // 
            this.ROTA_ITEM_ENT.ColumnName = "ROTA_ITEM_ENT";
            this.ROTA_ITEM_ENT.MaxLength = 20;
            // 
            // DI_ITEM_ENT
            // 
            this.DI_ITEM_ENT.ColumnName = "DI_ITEM_ENT";
            this.DI_ITEM_ENT.MaxLength = 10;
            // 
            // DATA_DI_ITEM_ENT
            // 
            this.DATA_DI_ITEM_ENT.ColumnName = "DATA_DI_ITEM_ENT";
            this.DATA_DI_ITEM_ENT.DataType = typeof(System.DateTime);
            // 
            // LOCAL_DES_ITEM_ENT
            // 
            this.LOCAL_DES_ITEM_ENT.ColumnName = "LOCAL_DES_ITEM_ENT";
            this.LOCAL_DES_ITEM_ENT.MaxLength = 60;
            // 
            // UF_DES_ITEM_ENT
            // 
            this.UF_DES_ITEM_ENT.ColumnName = "UF_DES_ITEM_ENT";
            this.UF_DES_ITEM_ENT.MaxLength = 2;
            // 
            // DATA_DES_ITEM_ENT
            // 
            this.DATA_DES_ITEM_ENT.ColumnName = "DATA_DES_ITEM_ENT";
            this.DATA_DES_ITEM_ENT.DataType = typeof(System.DateTime);
            // 
            // COD_EXP_ITEM_ENT
            // 
            this.COD_EXP_ITEM_ENT.ColumnName = "COD_EXP_ITEM_ENT";
            this.COD_EXP_ITEM_ENT.MaxLength = 60;
            // 
            // COD_ITEM_REQ_ITEM_ENT
            // 
            this.COD_ITEM_REQ_ITEM_ENT.ColumnName = "COD_ITEM_REQ_ITEM_ENT";
            this.COD_ITEM_REQ_ITEM_ENT.DataType = typeof(int);
            // 
            // COD_ITEM_PED_ITEM_ENT
            // 
            this.COD_ITEM_PED_ITEM_ENT.ColumnName = "COD_ITEM_PED_ITEM_ENT";
            this.COD_ITEM_PED_ITEM_ENT.DataType = typeof(int);
            // 
            // COD_ITEM_EST_ITEM_ENT
            // 
            this.COD_ITEM_EST_ITEM_ENT.ColumnName = "COD_ITEM_EST_ITEM_ENT";
            this.COD_ITEM_EST_ITEM_ENT.DataType = typeof(int);
            // 
            // COD_SISTEMA_NF_ITEM_ENT
            // 
            this.COD_SISTEMA_NF_ITEM_ENT.ColumnName = "COD_SISTEMA_NF_ITEM_ENT";
            this.COD_SISTEMA_NF_ITEM_ENT.DataType = typeof(int);
            // 
            // NCM_ITEM_ENT
            // 
            this.NCM_ITEM_ENT.ColumnName = "NCM_ITEM_ENT";
            this.NCM_ITEM_ENT.MaxLength = 50;
            // 
            // LOTE_ITEM_ENT
            // 
            this.LOTE_ITEM_ENT.ColumnName = "LOTE_ITEM_ENT";
            this.LOTE_ITEM_ENT.MaxLength = 100;
            // 
            // QTDE_LOTE_ITEM_ENT
            // 
            this.QTDE_LOTE_ITEM_ENT.ColumnName = "QTDE_LOTE_ITEM_ENT";
            this.QTDE_LOTE_ITEM_ENT.DataType = typeof(double);
            // 
            // NOME_PROPRIETARIO_ITEM_ENT
            // 
            this.NOME_PROPRIETARIO_ITEM_ENT.ColumnName = "NOME_PROPRIETARIO_ITEM_ENT";
            this.NOME_PROPRIETARIO_ITEM_ENT.MaxLength = 200;
            // 
            // CNPJ_PROPRIETARIO_ITEM_ENT
            // 
            this.CNPJ_PROPRIETARIO_ITEM_ENT.ColumnName = "CNPJ_PROPRIETARIO_ITEM";
            this.CNPJ_PROPRIETARIO_ITEM_ENT.MaxLength = 100;
            // 
            // BAIXADO_ITEM_ENT
            // 
            this.BAIXADO_ITEM_ENT.ColumnName = "BAIXADO_ITEM_ENT";
            this.BAIXADO_ITEM_ENT.DataType = typeof(int);
            // 
            // MATERIA_PRIMA_ITEM_ENT
            // 
            this.MATERIA_PRIMA_ITEM_ENT.ColumnName = "MATERIA_PRIMA_ITEM_ENT";
            this.MATERIA_PRIMA_ITEM_ENT.DataType = typeof(int);
            // 
            // dataColumn1
            // 
            this.dataColumn1.Caption = "CLIENTE_FORN_NF_ENT";
            this.dataColumn1.ColumnName = "CLIENTE_FORN_NF_ENT";
            this.dataColumn1.MaxLength = 200;
            // 
            // dataColumn2
            // 
            this.dataColumn2.Caption = "CNPJ_CLIENTE_FORN_ENT";
            this.dataColumn2.ColumnName = "CNPJ_CLIENTE_FORN_ENT";
            this.dataColumn2.MaxLength = 20;
            // 
            // dgvItens_nota
            // 
            this.dgvItens_nota.AllowUserToAddRows = false;
            this.dgvItens_nota.AutoGenerateColumns = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItens_nota.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvItens_nota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens_nota.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_nf,
            this.col_cod_nf_sistema,
            this.dESCRICAOITEMENTDataGridViewTextBoxColumn,
            this.col_cod_item_nota_ent,
            this.col_qtde,
            this.dataGridViewTextBoxColumn1,
            this.col_preco_total,
            this.col_ncm,
            this.col_cfo,
            this.col_novo_lote,
            this.col_lote,
            this.col_qtde_lote,
            this.CNPJ_CLIENTE_FORN_ENT,
            this.CLIENTE_FORN_NF_ENT,
            this.col_cnpj_cliente,
            this.col_cliente,
            this.col_pedido,
            this.col_n_linha_ped,
            this.col_cod_item_req,
            this.col_cod_item_ped,
            this.col_cod_item_est,
            this.col_buscar_item_est,
            this.col_data,
            this.dataGridViewTextBoxColumn2});
            this.dgvItens_nota.DataMember = "ITENS_NOTA_ENT";
            this.dgvItens_nota.DataSource = this.dsItens_nota_ent;
            this.dgvItens_nota.Location = new System.Drawing.Point(12, 161);
            this.dgvItens_nota.Name = "dgvItens_nota";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItens_nota.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvItens_nota.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvItens_nota.Size = new System.Drawing.Size(940, 382);
            this.dgvItens_nota.TabIndex = 295;
            this.dgvItens_nota.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItens_nota_CellContentClick);
            // 
            // col_nf
            // 
            this.col_nf.DataPropertyName = "NF_ITEM_ENT";
            this.col_nf.HeaderText = "Nº NF";
            this.col_nf.Name = "col_nf";
            this.col_nf.Width = 60;
            // 
            // col_cod_nf_sistema
            // 
            this.col_cod_nf_sistema.DataPropertyName = "COD_SISTEMA_NF_ITEM_ENT";
            this.col_cod_nf_sistema.HeaderText = "COD_SISTEMA_NF_ITEM_ENT";
            this.col_cod_nf_sistema.Name = "col_cod_nf_sistema";
            this.col_cod_nf_sistema.Visible = false;
            // 
            // dESCRICAOITEMENTDataGridViewTextBoxColumn
            // 
            this.dESCRICAOITEMENTDataGridViewTextBoxColumn.DataPropertyName = "DESCRICAO_ITEM_ENT";
            this.dESCRICAOITEMENTDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.dESCRICAOITEMENTDataGridViewTextBoxColumn.Name = "dESCRICAOITEMENTDataGridViewTextBoxColumn";
            this.dESCRICAOITEMENTDataGridViewTextBoxColumn.Width = 250;
            // 
            // col_cod_item_nota_ent
            // 
            this.col_cod_item_nota_ent.DataPropertyName = "COD_ITENS_NOTA_ENT";
            this.col_cod_item_nota_ent.HeaderText = "COD_ITENS_NOTA_ENT";
            this.col_cod_item_nota_ent.Name = "col_cod_item_nota_ent";
            this.col_cod_item_nota_ent.Visible = false;
            // 
            // col_qtde
            // 
            this.col_qtde.DataPropertyName = "QTDE_ITEM_ENT";
            this.col_qtde.HeaderText = "Qtde";
            this.col_qtde.Name = "col_qtde";
            this.col_qtde.Width = 60;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "UNIDADE_ITEM_ENT";
            this.dataGridViewTextBoxColumn1.HeaderText = "Un.";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 40;
            // 
            // col_preco_total
            // 
            this.col_preco_total.DataPropertyName = "PRECO_TOTAL_ITEM_ENT";
            this.col_preco_total.HeaderText = "PRECO_TOTAL_ITEM_ENT";
            this.col_preco_total.Name = "col_preco_total";
            this.col_preco_total.Visible = false;
            // 
            // col_ncm
            // 
            this.col_ncm.DataPropertyName = "NCM_ITEM_ENT";
            this.col_ncm.HeaderText = "NCM_ITEM_ENT";
            this.col_ncm.Name = "col_ncm";
            this.col_ncm.Visible = false;
            // 
            // col_cfo
            // 
            this.col_cfo.DataPropertyName = "CFOP_ITEM_ENT";
            this.col_cfo.HeaderText = "CFOP";
            this.col_cfo.Name = "col_cfo";
            this.col_cfo.Visible = false;
            this.col_cfo.Width = 60;
            // 
            // col_novo_lote
            // 
            this.col_novo_lote.HeaderText = "Novo Lote";
            this.col_novo_lote.Name = "col_novo_lote";
            this.col_novo_lote.Text = "Novo Lote";
            this.col_novo_lote.ToolTipText = "Novo Lote";
            this.col_novo_lote.UseColumnTextForButtonValue = true;
            this.col_novo_lote.Width = 65;
            // 
            // col_lote
            // 
            this.col_lote.DataPropertyName = "LOTE_ITEM_ENT";
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.col_lote.DefaultCellStyle = dataGridViewCellStyle9;
            this.col_lote.HeaderText = "Lote";
            this.col_lote.Name = "col_lote";
            this.col_lote.ReadOnly = true;
            this.col_lote.Width = 70;
            // 
            // col_qtde_lote
            // 
            this.col_qtde_lote.DataPropertyName = "QTDE_LOTE_ITEM_ENT";
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.col_qtde_lote.DefaultCellStyle = dataGridViewCellStyle10;
            this.col_qtde_lote.HeaderText = "Qtde Lote";
            this.col_qtde_lote.Name = "col_qtde_lote";
            this.col_qtde_lote.ReadOnly = true;
            this.col_qtde_lote.Width = 70;
            // 
            // CNPJ_CLIENTE_FORN_ENT
            // 
            this.CNPJ_CLIENTE_FORN_ENT.DataPropertyName = "CNPJ_CLIENTE_FORN_ENT";
            this.CNPJ_CLIENTE_FORN_ENT.HeaderText = "CNPJ Forn";
            this.CNPJ_CLIENTE_FORN_ENT.Name = "CNPJ_CLIENTE_FORN_ENT";
            // 
            // CLIENTE_FORN_NF_ENT
            // 
            this.CLIENTE_FORN_NF_ENT.DataPropertyName = "CLIENTE_FORN_NF_ENT";
            this.CLIENTE_FORN_NF_ENT.HeaderText = "Fornecedor";
            this.CLIENTE_FORN_NF_ENT.Name = "CLIENTE_FORN_NF_ENT";
            this.CLIENTE_FORN_NF_ENT.Width = 200;
            // 
            // col_cnpj_cliente
            // 
            this.col_cnpj_cliente.DataPropertyName = "CNPJ_PROPRIETARIO_ITEM";
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.col_cnpj_cliente.DefaultCellStyle = dataGridViewCellStyle11;
            this.col_cnpj_cliente.HeaderText = "CNPJ Cliente";
            this.col_cnpj_cliente.Name = "col_cnpj_cliente";
            this.col_cnpj_cliente.ReadOnly = true;
            // 
            // col_cliente
            // 
            this.col_cliente.DataPropertyName = "NOME_PROPRIETARIO_ITEM_ENT";
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.col_cliente.DefaultCellStyle = dataGridViewCellStyle12;
            this.col_cliente.HeaderText = "Nome Cliente";
            this.col_cliente.Name = "col_cliente";
            this.col_cliente.ReadOnly = true;
            this.col_cliente.Width = 200;
            // 
            // col_pedido
            // 
            this.col_pedido.DataPropertyName = "PEDIDO_COMPRA_ITEM_ENT";
            this.col_pedido.HeaderText = "Pedido Compra";
            this.col_pedido.Name = "col_pedido";
            // 
            // col_n_linha_ped
            // 
            this.col_n_linha_ped.DataPropertyName = "N_LINHA_PED_ITEM_ENT";
            this.col_n_linha_ped.HeaderText = "Nº Linha Pedido";
            this.col_n_linha_ped.Name = "col_n_linha_ped";
            this.col_n_linha_ped.Width = 70;
            // 
            // col_cod_item_req
            // 
            this.col_cod_item_req.DataPropertyName = "COD_ITEM_REQ_ITEM_ENT";
            this.col_cod_item_req.HeaderText = "Cód. Item Requisição";
            this.col_cod_item_req.Name = "col_cod_item_req";
            // 
            // col_cod_item_ped
            // 
            this.col_cod_item_ped.DataPropertyName = "COD_ITEM_PED_ITEM_ENT";
            this.col_cod_item_ped.HeaderText = "Código Item Pedido";
            this.col_cod_item_ped.Name = "col_cod_item_ped";
            // 
            // col_cod_item_est
            // 
            this.col_cod_item_est.DataPropertyName = "COD_ITEM_EST_ITEM_ENT";
            this.col_cod_item_est.HeaderText = "Código Item Estoque";
            this.col_cod_item_est.Name = "col_cod_item_est";
            // 
            // col_buscar_item_est
            // 
            this.col_buscar_item_est.HeaderText = "Buscar Item Est";
            this.col_buscar_item_est.Name = "col_buscar_item_est";
            this.col_buscar_item_est.Text = "Buscar Item Est";
            this.col_buscar_item_est.ToolTipText = "Buscar Item Est";
            this.col_buscar_item_est.UseColumnTextForButtonValue = true;
            // 
            // col_data
            // 
            this.col_data.DataPropertyName = "DATA_INSERCAO_ITEM_ENT_NOTA";
            this.col_data.HeaderText = "DATA_INSERCAO_ITEM_ENT_NOTA";
            this.col_data.Name = "col_data";
            this.col_data.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "BAIXADO_ITEM_ENT";
            this.dataGridViewTextBoxColumn2.HeaderText = "BAIXADO_ITEM_ENT";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // rbAguardando
            // 
            this.rbAguardando.AutoSize = true;
            this.rbAguardando.Location = new System.Drawing.Point(15, 33);
            this.rbAguardando.Name = "rbAguardando";
            this.rbAguardando.Size = new System.Drawing.Size(123, 17);
            this.rbAguardando.TabIndex = 296;
            this.rbAguardando.TabStop = true;
            this.rbAguardando.Text = "Aguardando Entrada";
            this.rbAguardando.UseVisualStyleBackColor = true;
            // 
            // rbTodos_itens
            // 
            this.rbTodos_itens.AutoSize = true;
            this.rbTodos_itens.Location = new System.Drawing.Point(15, 10);
            this.rbTodos_itens.Name = "rbTodos_itens";
            this.rbTodos_itens.Size = new System.Drawing.Size(95, 17);
            this.rbTodos_itens.TabIndex = 297;
            this.rbTodos_itens.TabStop = true;
            this.rbTodos_itens.Text = "Todos os Itens";
            this.rbTodos_itens.UseVisualStyleBackColor = true;
            // 
            // rbEntrada_efetuada
            // 
            this.rbEntrada_efetuada.AutoSize = true;
            this.rbEntrada_efetuada.Location = new System.Drawing.Point(15, 56);
            this.rbEntrada_efetuada.Name = "rbEntrada_efetuada";
            this.rbEntrada_efetuada.Size = new System.Drawing.Size(108, 17);
            this.rbEntrada_efetuada.TabIndex = 298;
            this.rbEntrada_efetuada.TabStop = true;
            this.rbEntrada_efetuada.Text = "Entrada Efetuada";
            this.rbEntrada_efetuada.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.rbEntrada_efetuada);
            this.panel1.Controls.Add(this.rbTodos_itens);
            this.panel1.Controls.Add(this.rbAguardando);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(148, 81);
            this.panel1.TabIndex = 299;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.cb_data);
            this.panel2.Controls.Add(this.dtFinal);
            this.panel2.Controls.Add(this.dtInicial);
            this.panel2.Location = new System.Drawing.Point(166, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 35);
            this.panel2.TabIndex = 300;
            // 
            // cb_data
            // 
            this.cb_data.AutoSize = true;
            this.cb_data.Location = new System.Drawing.Point(230, 9);
            this.cb_data.Name = "cb_data";
            this.cb_data.Size = new System.Drawing.Size(66, 17);
            this.cb_data.TabIndex = 14;
            this.cb_data.Text = "Por data";
            this.cb_data.UseVisualStyleBackColor = true;
            // 
            // dtFinal
            // 
            this.dtFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFinal.Location = new System.Drawing.Point(111, 8);
            this.dtFinal.Name = "dtFinal";
            this.dtFinal.Size = new System.Drawing.Size(97, 20);
            this.dtFinal.TabIndex = 13;
            // 
            // dtInicial
            // 
            this.dtInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicial.Location = new System.Drawing.Point(5, 8);
            this.dtInicial.Name = "dtInicial";
            this.dtInicial.Size = new System.Drawing.Size(97, 20);
            this.dtInicial.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.rbAlmoxarifado);
            this.panel3.Controls.Add(this.rbMateria_prima);
            this.panel3.Controls.Add(this.rbTodos);
            this.panel3.Location = new System.Drawing.Point(166, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(303, 40);
            this.panel3.TabIndex = 301;
            // 
            // rbAlmoxarifado
            // 
            this.rbAlmoxarifado.AutoSize = true;
            this.rbAlmoxarifado.Location = new System.Drawing.Point(211, 12);
            this.rbAlmoxarifado.Name = "rbAlmoxarifado";
            this.rbAlmoxarifado.Size = new System.Drawing.Size(85, 17);
            this.rbAlmoxarifado.TabIndex = 2;
            this.rbAlmoxarifado.TabStop = true;
            this.rbAlmoxarifado.Text = "Almoxarifado";
            this.rbAlmoxarifado.UseVisualStyleBackColor = true;
            // 
            // rbMateria_prima
            // 
            this.rbMateria_prima.AutoSize = true;
            this.rbMateria_prima.Location = new System.Drawing.Point(90, 12);
            this.rbMateria_prima.Name = "rbMateria_prima";
            this.rbMateria_prima.Size = new System.Drawing.Size(89, 17);
            this.rbMateria_prima.TabIndex = 1;
            this.rbMateria_prima.TabStop = true;
            this.rbMateria_prima.Text = "Matéria Prima";
            this.rbMateria_prima.UseVisualStyleBackColor = true;
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Location = new System.Drawing.Point(8, 12);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(55, 17);
            this.rbTodos.TabIndex = 0;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos";
            this.rbTodos.UseVisualStyleBackColor = true;
            // 
            // tb_codigo
            // 
            this.tb_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_codigo.Location = new System.Drawing.Point(294, 11);
            this.tb_codigo.Name = "tb_codigo";
            this.tb_codigo.Size = new System.Drawing.Size(269, 38);
            this.tb_codigo.TabIndex = 302;
            this.tb_codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_codigo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 31);
            this.label1.TabIndex = 303;
            this.label1.Text = "Clique no código aqui:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(201, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 31);
            this.label2.TabIndex = 305;
            this.label2.Text = "Local:";
            // 
            // tb_localidade
            // 
            this.tb_localidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_localidade.Location = new System.Drawing.Point(294, 55);
            this.tb_localidade.Name = "tb_localidade";
            this.tb_localidade.Size = new System.Drawing.Size(269, 38);
            this.tb_localidade.TabIndex = 304;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(593, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 82);
            this.button1.TabIndex = 306;
            this.button1.Text = "Inserir no Estoque";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.tb_localidade);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.tb_codigo);
            this.panel4.Location = new System.Drawing.Point(27, 551);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(689, 107);
            this.panel4.TabIndex = 307;
            this.panel4.Visible = false;
            // 
            // cbItens_nota_ent
            // 
            this.cbItens_nota_ent.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbItens_nota_ent.DataAdapter = this.datItens_nota_ent;
            this.cbItens_nota_ent.QuotePrefix = "\"";
            this.cbItens_nota_ent.QuoteSuffix = "\"";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(876, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 51);
            this.button2.TabIndex = 308;
            this.button2.Text = "Imprimir Etiquetas";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // datItens_req
            // 
            this.datItens_req.DeleteCommand = this.fbCommand8;
            this.datItens_req.InsertCommand = this.fbCommand6;
            this.datItens_req.SelectCommand = this.fbCommand5;
            this.datItens_req.UpdateCommand = this.fbCommand7;
            // 
            // fbCommand8
            // 
            this.fbCommand8.CommandTimeout = 30;
            // 
            // fbCommand6
            // 
            this.fbCommand6.CommandTimeout = 30;
            // 
            // fbCommand5
            // 
            this.fbCommand5.CommandText = "select * from itens_requisicao";
            this.fbCommand5.CommandTimeout = 30;
            this.fbCommand5.Connection = this.fbConnection1;
            // 
            // fbCommand7
            // 
            this.fbCommand7.CommandTimeout = 30;
            // 
            // datItens_ped
            // 
            this.datItens_ped.DeleteCommand = this.fbCommand12;
            this.datItens_ped.InsertCommand = this.fbCommand10;
            this.datItens_ped.SelectCommand = this.fbCommand9;
            this.datItens_ped.UpdateCommand = this.fbCommand11;
            // 
            // fbCommand12
            // 
            this.fbCommand12.CommandTimeout = 30;
            // 
            // fbCommand10
            // 
            this.fbCommand10.CommandTimeout = 30;
            // 
            // fbCommand9
            // 
            this.fbCommand9.CommandText = "select * from itens_pedido_compra";
            this.fbCommand9.CommandTimeout = 30;
            this.fbCommand9.Connection = this.fbConnection1;
            // 
            // fbCommand11
            // 
            this.fbCommand11.CommandTimeout = 30;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(488, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 81);
            this.button3.TabIndex = 309;
            this.button3.Text = "OK";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel5.Controls.Add(this.tb_lote);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.tb_cod_item_estoque);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.tb_nota_fiscal);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.tb_descricao);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(14, 98);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(937, 63);
            this.panel5.TabIndex = 310;
            // 
            // tb_cod_item_estoque
            // 
            this.tb_cod_item_estoque.Location = new System.Drawing.Point(576, 23);
            this.tb_cod_item_estoque.Name = "tb_cod_item_estoque";
            this.tb_cod_item_estoque.Size = new System.Drawing.Size(88, 20);
            this.tb_cod_item_estoque.TabIndex = 5;
            this.tb_cod_item_estoque.TextChanged += new System.EventHandler(this.tb_cod_item_estoque_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(473, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cod. Item Estoque:";
            // 
            // tb_nota_fiscal
            // 
            this.tb_nota_fiscal.Location = new System.Drawing.Point(357, 23);
            this.tb_nota_fiscal.Name = "tb_nota_fiscal";
            this.tb_nota_fiscal.Size = new System.Drawing.Size(88, 20);
            this.tb_nota_fiscal.TabIndex = 3;
            this.tb_nota_fiscal.TextChanged += new System.EventHandler(this.tb_nota_fiscal_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(293, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nota Fiscal:";
            // 
            // tb_descricao
            // 
            this.tb_descricao.Location = new System.Drawing.Point(94, 23);
            this.tb_descricao.Name = "tb_descricao";
            this.tb_descricao.Size = new System.Drawing.Size(175, 20);
            this.tb_descricao.TabIndex = 1;
            this.tb_descricao.TextChanged += new System.EventHandler(this.tb_descricao_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Descrição:";
            // 
            // tb_lote
            // 
            this.tb_lote.Location = new System.Drawing.Point(731, 23);
            this.tb_lote.Name = "tb_lote";
            this.tb_lote.Size = new System.Drawing.Size(88, 20);
            this.tb_lote.TabIndex = 7;
            this.tb_lote.TextChanged += new System.EventHandler(this.tb_lote_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(694, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Lote:";
            // 
            // form_itens_nf_ent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 662);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvItens_nota);
            this.Name = "form_itens_nf_ent";
            this.Text = "Itens Nota Fiscal Entrada";
            this.Load += new System.EventHandler(this.form_itens_nf_ent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsItens_nota_ent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITENS_NOTA_ENT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens_nota)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datItens_nota_ent;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Data.DataSet dsItens_nota_ent;
        private System.Data.DataTable ITENS_NOTA_ENT;
        private System.Data.DataColumn COD_ITENS_NOTA_ENT;
        private System.Data.DataColumn DESCRICAO_ITEM_ENT;
        private System.Data.DataColumn UNIDADE_ITEM_ENT;
        private System.Data.DataColumn QTDE_ITEM_ENT;
        private System.Data.DataColumn ST_ITEM_ENT;
        private System.Data.DataColumn PRECO_UNIT_ITEM_ENT;
        private System.Data.DataColumn PRECO_TOTAL_ITEM_ENT;
        private System.Data.DataColumn IPI_ITEM_ENT;
        private System.Data.DataColumn ICM_ITEM_ENT;
        private System.Data.DataColumn NF_ITEM_ENT;
        private System.Data.DataColumn VALOR_IPI_ITEM_ENT;
        private System.Data.DataColumn PEDIDO_COMPRA_ITEM_ENT;
        private System.Data.DataColumn MAE_ITEM_ENT;
        private System.Data.DataColumn COD_ITEM_ENT;
        private System.Data.DataColumn CFOP_ITEM_ENT;
        private System.Data.DataColumn VALOR_ICM_ITEM_ENT;
        private System.Data.DataColumn VALOR_ISS_ITEM_ENT;
        private System.Data.DataColumn PRESTACAO_SERVICO_ITEM_ENT;
        private System.Data.DataColumn VALOR_BC_ITEM_ENT;
        private System.Data.DataColumn COD_COMISSIONARIO_ITEM_ENT;
        private System.Data.DataColumn VALOR_UNIT_COMISSAO_ITEM_ENT;
        private System.Data.DataColumn VALOR_TOTAL_COMISSAO_ITEM_ENT;
        private System.Data.DataColumn DATA_INSERCAO_ITEM_ENT_NOTA;
        private System.Data.DataColumn CNPJ_CLIENTE_ITEM_ENT;
        private System.Data.DataColumn STATUS_ATUAL_NFE_ENT;
        private System.Data.DataColumn PORC_COMISSAO_ITEM_ENT;
        private System.Data.DataColumn N_LINHA_PED_ITEM_ENT;
        private System.Data.DataColumn VALOR_BC_ICMS_ST_ITEM_ENT;
        private System.Data.DataColumn VALOR_ICMS_ST_ITEM_ENT;
        private System.Data.DataColumn VALOR_FRETE_ITEM_ENT;
        private System.Data.DataColumn VALOR_DESCONTO_ITEM_ENT;
        private System.Data.DataColumn VALOR_SEGURO_ITEM_ENT;
        private System.Data.DataColumn VALOR_OUTRAS_DESP_ITEM_ENT;
        private System.Data.DataColumn IVA_ITEM_ENT;
        private System.Data.DataColumn REDUCAO_ITEM_ENT;
        private System.Data.DataColumn COFINS_ITEM_ENT;
        private System.Data.DataColumn VALOR_COFINS_ITEM_ENT;
        private System.Data.DataColumn PIS_ITEM_ENT;
        private System.Data.DataColumn VALOR_PIS_ITEM_ENT;
        private System.Data.DataColumn ORIGEM_ITEM_ENT;
        private System.Data.DataColumn MOD_BC_ITEM_ENT;
        private System.Data.DataColumn ISS_ITEM_ENT;
        private System.Data.DataColumn MOD_BC_ST_ITEM_ENT;
        private System.Data.DataColumn REDUCAO_ST_ITEM_ENT;
        private System.Data.DataColumn ICMS_ST_ITEM_ENT;
        private System.Data.DataColumn ALIQUOTA_CREDITO_ITEM_ENT;
        private System.Data.DataColumn VALOR_CREDITO_ITEM_ENT;
        private System.Data.DataColumn IPI_TRIB_ITEM_ENT;
        private System.Data.DataColumn IPI_N_TRIB_ITEM_ENT;
        private System.Data.DataColumn CST_IPI_TRIB_ITEM_ENT;
        private System.Data.DataColumn CST_IPI_N_TRIB_ITEM_ENT;
        private System.Data.DataColumn TIPO_PIS_ITEM_ENT;
        private System.Data.DataColumn CST_PIS_ITEM_ENT;
        private System.Data.DataColumn TIPO_COFINS_ITEM_ENT;
        private System.Data.DataColumn CST_COFINS_ITEM_ENT;
        private System.Data.DataColumn TIPO_SERVICO_ITEM_ENT;
        private System.Data.DataColumn ITEM_PEDIDO_COMPRA_ITEM_ENT;
        private System.Data.DataColumn BC_IPI_ITEM_ENT;
        private System.Data.DataColumn BC_PIS_ITEM_ENT;
        private System.Data.DataColumn BC_COFINS_ITEM_ENT;
        private System.Data.DataColumn BC_ISS_ITEM_ENT;
        private System.Data.DataColumn BC_COM_IPI_ITEM_ENT;
        private System.Data.DataColumn ST_IMPRESSAO_ITEM_ENT;
        private System.Data.DataColumn ROTA_ITEM_ENT;
        private System.Data.DataColumn DI_ITEM_ENT;
        private System.Data.DataColumn DATA_DI_ITEM_ENT;
        private System.Data.DataColumn LOCAL_DES_ITEM_ENT;
        private System.Data.DataColumn UF_DES_ITEM_ENT;
        private System.Data.DataColumn DATA_DES_ITEM_ENT;
        private System.Data.DataColumn COD_EXP_ITEM_ENT;
        private System.Data.DataColumn COD_ITEM_REQ_ITEM_ENT;
        private System.Data.DataColumn COD_ITEM_PED_ITEM_ENT;
        private System.Data.DataColumn COD_ITEM_EST_ITEM_ENT;
        private System.Data.DataColumn COD_SISTEMA_NF_ITEM_ENT;
        private System.Data.DataColumn NCM_ITEM_ENT;
        private System.Data.DataColumn LOTE_ITEM_ENT;
        private System.Data.DataColumn QTDE_LOTE_ITEM_ENT;
        private System.Data.DataColumn NOME_PROPRIETARIO_ITEM_ENT;
        private System.Data.DataColumn CNPJ_PROPRIETARIO_ITEM_ENT;
        private System.Data.DataColumn BAIXADO_ITEM_ENT;
        private System.Data.DataColumn MATERIA_PRIMA_ITEM_ENT;
        private System.Windows.Forms.DataGridView dgvItens_nota;
        private System.Windows.Forms.RadioButton rbAguardando;
        private System.Windows.Forms.RadioButton rbTodos_itens;
        private System.Windows.Forms.RadioButton rbEntrada_efetuada;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox cb_data;
        private System.Windows.Forms.DateTimePicker dtFinal;
        private System.Windows.Forms.DateTimePicker dtInicial;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rbAlmoxarifado;
        private System.Windows.Forms.RadioButton rbMateria_prima;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.TextBox tb_codigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_localidade;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbItens_nota_ent;
        private System.Windows.Forms.Button button2;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datItens_req;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand8;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand6;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand5;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand7;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datItens_ped;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand12;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand10;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand9;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand11;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox tb_cod_item_estoque;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_nota_fiscal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_descricao;
        private System.Windows.Forms.Label label3;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nf;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod_nf_sistema;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRICAOITEMENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod_item_nota_ent;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_qtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_preco_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ncm;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cfo;
        private System.Windows.Forms.DataGridViewButtonColumn col_novo_lote;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_lote;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_qtde_lote;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNPJ_CLIENTE_FORN_ENT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLIENTE_FORN_NF_ENT;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cnpj_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_n_linha_ped;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod_item_req;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod_item_ped;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod_item_est;
        private System.Windows.Forms.DataGridViewButtonColumn col_buscar_item_est;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_data;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TextBox tb_lote;
        private System.Windows.Forms.Label label6;
    }
}