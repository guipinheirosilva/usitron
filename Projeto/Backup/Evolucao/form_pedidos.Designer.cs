namespace Evolucao
{
    partial class form_pedidos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_pedidos));
            this.label28 = new System.Windows.Forms.Label();
            this.tb_n_pedido = new System.Windows.Forms.TextBox();
            this.dsPedidos_venda = new System.Data.DataSet();
            this.PEDIDOS_VENDA = new System.Data.DataTable();
            this.COD_PED_VENDA = new System.Data.DataColumn();
            this.DATA_PED_VENDA = new System.Data.DataColumn();
            this.DATA_BAIXA_PED_VENDA = new System.Data.DataColumn();
            this.CLIENTE_PED_VENDA = new System.Data.DataColumn();
            this.CNPJ_PED_VENDA = new System.Data.DataColumn();
            this.COND_PGTO_PED_VENDA = new System.Data.DataColumn();
            this.VALOR_TOTAL_PED_VENDA = new System.Data.DataColumn();
            this.VALOR_TOTAL_ICMS_PED_VENDA = new System.Data.DataColumn();
            this.VALOR_TOTAL_IPI_PED_VENDA = new System.Data.DataColumn();
            this.VALOR_DESCONTO_PED_VENDA = new System.Data.DataColumn();
            this.OBS_PED_VENDA = new System.Data.DataColumn();
            this.NF_PED_VENDA = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataColumn7 = new System.Data.DataColumn();
            this.dataColumn10 = new System.Data.DataColumn();
            this.dataColumn16 = new System.Data.DataColumn();
            this.dataColumn17 = new System.Data.DataColumn();
            this.dataColumn18 = new System.Data.DataColumn();
            this.dataColumn19 = new System.Data.DataColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_data_pedido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_cliente = new System.Windows.Forms.TextBox();
            this.tb_cnpj_cliente = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.tb_descricao_produto = new System.Windows.Forms.TextBox();
            this.tb_cod_fornecedor = new System.Windows.Forms.TextBox();
            this.tb_preco_unit_item = new System.Windows.Forms.TextBox();
            this.tb_qtde_item = new System.Windows.Forms.TextBox();
            this.tb_unid_item = new System.Windows.Forms.TextBox();
            this.dgvItens_nota = new System.Windows.Forms.DataGridView();
            this.cODITEMVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cod_forn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRICAOPRODITEMVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRICAO_ITEM_PROD_ITEM_VENDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MARCA_ITEM_VENDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uNIDADEPRODITEMVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRAZO_ITEM_VENDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_qtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_valor_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_valor_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bCICMSPRODITEMVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aLIQICMSPRODITEMVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bCIPIPRODITEMVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aLIQIPIPRODITEMVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nFPRODITEMVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nNFPRODITEMVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oBSITEMVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsItens_ped_venda = new System.Data.DataSet();
            this.ITENS_PEDIDO_VENDA = new System.Data.DataTable();
            this.COD_ITEM_VENDA = new System.Data.DataColumn();
            this.QTDE_ITEM_VENDA = new System.Data.DataColumn();
            this.COD_PROD_ITEM_VENDA = new System.Data.DataColumn();
            this.DESCRICAO_PROD_ITEM_VENDA = new System.Data.DataColumn();
            this.VALOR_UNIT_PROD_ITEM_VENDA = new System.Data.DataColumn();
            this.VALOR_TOTAL_PROD_ITEM_VENDA = new System.Data.DataColumn();
            this.UNIDADE_PROD_ITEM_VENDA = new System.Data.DataColumn();
            this.BC_ICMS_PROD_ITEM_VENDA = new System.Data.DataColumn();
            this.ALIQ_ICMS_PROD_ITEM_VENDA = new System.Data.DataColumn();
            this.BC_IPI_PROD_ITEM_VENDA = new System.Data.DataColumn();
            this.ALIQ_IPI_PROD_ITEM_VENDA = new System.Data.DataColumn();
            this.NF_PROD_ITEM_VENDA = new System.Data.DataColumn();
            this.N_NF_PROD_ITEM_VENDA = new System.Data.DataColumn();
            this.OBS_ITEM_VENDA = new System.Data.DataColumn();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn8 = new System.Data.DataColumn();
            this.dataColumn9 = new System.Data.DataColumn();
            this.dataColumn11 = new System.Data.DataColumn();
            this.dataColumn12 = new System.Data.DataColumn();
            this.dataColumn13 = new System.Data.DataColumn();
            this.dataColumn14 = new System.Data.DataColumn();
            this.dataColumn15 = new System.Data.DataColumn();
            this.tb_forma_pgto = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.tb_total_pedido = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tb_total_prod = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_Nfe = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_total_icms = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_icms_ipi = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.cbPedidos_venda = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.datPedidos_venda = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand12 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand10 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand9 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand11 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.datItens_ped_venda = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand8 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand6 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand5 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand7 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.bt_localizar = new System.Windows.Forms.Button();
            this.bt_excluir = new System.Windows.Forms.Button();
            this.bt_salvar = new System.Windows.Forms.Button();
            this.bt_novo = new System.Windows.Forms.Button();
            this.cbItens_ped_venda = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.comando_select = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.cb_baixado_est = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.datProdutos = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand16 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand14 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand13 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand15 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand17 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand18 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand19 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand20 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.datFatura_nf = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand24 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand22 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand21 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand23 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsFatura_nf = new System.Data.DataSet();
            this.FATURA_NF = new System.Data.DataTable();
            this.COD_FATURA = new System.Data.DataColumn();
            this.PRAZO_FATURA = new System.Data.DataColumn();
            this.DATA_VENC_FATURA = new System.Data.DataColumn();
            this.VALOR_FATURA = new System.Data.DataColumn();
            this.NF_FATURA = new System.Data.DataColumn();
            this.datImp_duplicatas = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand28 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand26 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand25 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand27 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsImp_duplicatas = new System.Data.DataSet();
            this.IMP_DUPLICATAS = new System.Data.DataTable();
            this.COD_IMP_DUPLICATA = new System.Data.DataColumn();
            this.COD_1_IMP_DUPLICATA = new System.Data.DataColumn();
            this.DATA_1_IMP_DUPLICATA = new System.Data.DataColumn();
            this.VALOR_1_IMP_DUPLICATA = new System.Data.DataColumn();
            this.COD_2_IMP_DUPLICATA = new System.Data.DataColumn();
            this.DATA_2_IMP_DUPLICATA = new System.Data.DataColumn();
            this.VALOR_2_IMP_DUPLICATA = new System.Data.DataColumn();
            this.COD_3_IMP_DUPLICATA = new System.Data.DataColumn();
            this.DATA_3_IMP_DUPLICATA = new System.Data.DataColumn();
            this.VALOR_3_IMP_DUPLICATA = new System.Data.DataColumn();
            this.COD_4_IMP_DUPLICATA = new System.Data.DataColumn();
            this.DATA_4_IMP_DUPLICATA = new System.Data.DataColumn();
            this.VALOR_4_IMP_DUPLICATA = new System.Data.DataColumn();
            this.COD_5_IMP_DUPLICATA = new System.Data.DataColumn();
            this.DATA_5_IMP_DUPLICATA = new System.Data.DataColumn();
            this.VALOR_5_IMP_DUPLICATA = new System.Data.DataColumn();
            this.COD_6_IMP_DUPLICATA = new System.Data.DataColumn();
            this.DATA_6_IMP_DUPLICATA = new System.Data.DataColumn();
            this.VALOR_6_IMP_DUPLICATA = new System.Data.DataColumn();
            this.tb_vendedor = new System.Windows.Forms.TextBox();
            this.tb_cod_vendedor = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.datContas_a_receber = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand32 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand30 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand29 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand31 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.datClientes = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand36 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand34 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand33 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand35 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.button8 = new System.Windows.Forms.Button();
            this.cbRecebido = new System.Windows.Forms.CheckBox();
            this.tb_descricao_item = new System.Windows.Forms.TextBox();
            this.tb_prazo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_marca = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tb_cod_sistema = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.barra_status = new System.Windows.Forms.StatusStrip();
            this.datEmails_enviados = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand40 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand38 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand37 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand39 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.contatotextBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.teltextBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.emailtextBox = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fbCommand41 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand42 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand43 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand44 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb_valor_desconto = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.tb_porc_desconto = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dsPedidos_venda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PEDIDOS_VENDA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens_nota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsItens_ped_venda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITENS_PEDIDO_VENDA)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsFatura_nf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FATURA_NF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsImp_duplicatas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMP_DUPLICATAS)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label28.Location = new System.Drawing.Point(208, 25);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(386, 42);
            this.label28.TabIndex = 90;
            this.label28.Text = "PEDIDOS DE VENDA";
            // 
            // tb_n_pedido
            // 
            this.tb_n_pedido.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPedidos_venda, "PEDIDOS_VENDA.COD_PED_VENDA", true));
            this.tb_n_pedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_n_pedido.Location = new System.Drawing.Point(22, 25);
            this.tb_n_pedido.Name = "tb_n_pedido";
            this.tb_n_pedido.Size = new System.Drawing.Size(169, 44);
            this.tb_n_pedido.TabIndex = 136;
            // 
            // dsPedidos_venda
            // 
            this.dsPedidos_venda.DataSetName = "dsPedidos_venda";
            this.dsPedidos_venda.Namespace = "http://www.tempuri.org/dsPedidos_venda.xsd";
            this.dsPedidos_venda.Tables.AddRange(new System.Data.DataTable[] {
            this.PEDIDOS_VENDA});
            // 
            // PEDIDOS_VENDA
            // 
            this.PEDIDOS_VENDA.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_PED_VENDA,
            this.DATA_PED_VENDA,
            this.DATA_BAIXA_PED_VENDA,
            this.CLIENTE_PED_VENDA,
            this.CNPJ_PED_VENDA,
            this.COND_PGTO_PED_VENDA,
            this.VALOR_TOTAL_PED_VENDA,
            this.VALOR_TOTAL_ICMS_PED_VENDA,
            this.VALOR_TOTAL_IPI_PED_VENDA,
            this.VALOR_DESCONTO_PED_VENDA,
            this.OBS_PED_VENDA,
            this.NF_PED_VENDA,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn6,
            this.dataColumn7,
            this.dataColumn10,
            this.dataColumn16,
            this.dataColumn17,
            this.dataColumn18,
            this.dataColumn19});
            this.PEDIDOS_VENDA.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_PED_VENDA"}, true)});
            this.PEDIDOS_VENDA.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_PED_VENDA};
            this.PEDIDOS_VENDA.TableName = "PEDIDOS_VENDA";
            // 
            // COD_PED_VENDA
            // 
            this.COD_PED_VENDA.AllowDBNull = false;
            this.COD_PED_VENDA.ColumnName = "COD_PED_VENDA";
            this.COD_PED_VENDA.DataType = typeof(int);
            // 
            // DATA_PED_VENDA
            // 
            this.DATA_PED_VENDA.ColumnName = "DATA_PED_VENDA";
            this.DATA_PED_VENDA.DataType = typeof(System.DateTime);
            // 
            // DATA_BAIXA_PED_VENDA
            // 
            this.DATA_BAIXA_PED_VENDA.ColumnName = "DATA_BAIXA_PED_VENDA";
            this.DATA_BAIXA_PED_VENDA.DataType = typeof(System.DateTime);
            // 
            // CLIENTE_PED_VENDA
            // 
            this.CLIENTE_PED_VENDA.ColumnName = "CLIENTE_PED_VENDA";
            this.CLIENTE_PED_VENDA.MaxLength = 200;
            // 
            // CNPJ_PED_VENDA
            // 
            this.CNPJ_PED_VENDA.ColumnName = "CNPJ_PED_VENDA";
            this.CNPJ_PED_VENDA.MaxLength = 30;
            // 
            // COND_PGTO_PED_VENDA
            // 
            this.COND_PGTO_PED_VENDA.ColumnName = "COND_PGTO_PED_VENDA";
            this.COND_PGTO_PED_VENDA.MaxLength = 30;
            // 
            // VALOR_TOTAL_PED_VENDA
            // 
            this.VALOR_TOTAL_PED_VENDA.ColumnName = "VALOR_TOTAL_PED_VENDA";
            this.VALOR_TOTAL_PED_VENDA.DataType = typeof(double);
            // 
            // VALOR_TOTAL_ICMS_PED_VENDA
            // 
            this.VALOR_TOTAL_ICMS_PED_VENDA.ColumnName = "VALOR_TOTAL_ICMS_PED_VENDA";
            this.VALOR_TOTAL_ICMS_PED_VENDA.DataType = typeof(double);
            // 
            // VALOR_TOTAL_IPI_PED_VENDA
            // 
            this.VALOR_TOTAL_IPI_PED_VENDA.ColumnName = "VALOR_TOTAL_IPI_PED_VENDA";
            this.VALOR_TOTAL_IPI_PED_VENDA.DataType = typeof(double);
            // 
            // VALOR_DESCONTO_PED_VENDA
            // 
            this.VALOR_DESCONTO_PED_VENDA.ColumnName = "VALOR_DESCONTO_PED_VENDA";
            this.VALOR_DESCONTO_PED_VENDA.DataType = typeof(double);
            // 
            // OBS_PED_VENDA
            // 
            this.OBS_PED_VENDA.ColumnName = "OBS_PED_VENDA";
            this.OBS_PED_VENDA.MaxLength = 300;
            // 
            // NF_PED_VENDA
            // 
            this.NF_PED_VENDA.ColumnName = "NF_PED_VENDA";
            this.NF_PED_VENDA.DataType = typeof(int);
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "VALOR_TOTAL_PROD_PED_VENDA";
            this.dataColumn4.DataType = typeof(double);
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "BAIXADO_ESTOQUE_PED_VENDA";
            this.dataColumn5.DataType = typeof(int);
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "VENDEDOR_PED_VENDA";
            this.dataColumn6.MaxLength = 100;
            // 
            // dataColumn7
            // 
            this.dataColumn7.ColumnName = "COD_VENDEDOR_PED_VENDA";
            this.dataColumn7.DataType = typeof(int);
            // 
            // dataColumn10
            // 
            this.dataColumn10.ColumnName = "PAGO_PED_VENDA";
            this.dataColumn10.DataType = typeof(int);
            // 
            // dataColumn16
            // 
            this.dataColumn16.ColumnName = "NOME_CONTATO_PED_VENDA";
            this.dataColumn16.MaxLength = 100;
            // 
            // dataColumn17
            // 
            this.dataColumn17.ColumnName = "TELEFONE_CONTATO_PED_VENDA";
            this.dataColumn17.MaxLength = 100;
            // 
            // dataColumn18
            // 
            this.dataColumn18.ColumnName = "EMAIL_CONTATO_PED_VENDA";
            this.dataColumn18.MaxLength = 100;
            // 
            // dataColumn19
            // 
            this.dataColumn19.ColumnName = "PORC_DESCONTO_PED_VENDA";
            this.dataColumn19.DataType = typeof(double);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 135;
            this.label2.Text = "N.º Orçamento:";
            // 
            // tb_data_pedido
            // 
            this.tb_data_pedido.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPedidos_venda, "PEDIDOS_VENDA.DATA_PED_VENDA", true));
            this.tb_data_pedido.Location = new System.Drawing.Point(92, 94);
            this.tb_data_pedido.Name = "tb_data_pedido";
            this.tb_data_pedido.Size = new System.Drawing.Size(97, 20);
            this.tb_data_pedido.TabIndex = 138;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 137;
            this.label4.Text = "Data Pedido:";
            // 
            // tb_cliente
            // 
            this.tb_cliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPedidos_venda, "PEDIDOS_VENDA.CLIENTE_PED_VENDA", true));
            this.tb_cliente.Location = new System.Drawing.Point(223, 11);
            this.tb_cliente.Name = "tb_cliente";
            this.tb_cliente.Size = new System.Drawing.Size(319, 20);
            this.tb_cliente.TabIndex = 141;
            // 
            // tb_cnpj_cliente
            // 
            this.tb_cnpj_cliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPedidos_venda, "PEDIDOS_VENDA.CNPJ_PED_VENDA", true));
            this.tb_cnpj_cliente.Location = new System.Drawing.Point(58, 11);
            this.tb_cnpj_cliente.Name = "tb_cnpj_cliente";
            this.tb_cnpj_cliente.Size = new System.Drawing.Size(166, 20);
            this.tb_cnpj_cliente.TabIndex = 140;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(545, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 140;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 142;
            this.label8.Text = "Cliente:";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(23, 189);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(39, 22);
            this.button5.TabIndex = 148;
            this.button5.Text = "OK";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // tb_descricao_produto
            // 
            this.tb_descricao_produto.Location = new System.Drawing.Point(129, 191);
            this.tb_descricao_produto.Name = "tb_descricao_produto";
            this.tb_descricao_produto.Size = new System.Drawing.Size(190, 20);
            this.tb_descricao_produto.TabIndex = 141;
            this.tb_descricao_produto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_descricao_peca_KeyDown);
            // 
            // tb_cod_fornecedor
            // 
            this.tb_cod_fornecedor.Location = new System.Drawing.Point(63, 191);
            this.tb_cod_fornecedor.Name = "tb_cod_fornecedor";
            this.tb_cod_fornecedor.Size = new System.Drawing.Size(67, 20);
            this.tb_cod_fornecedor.TabIndex = 143;
            // 
            // tb_preco_unit_item
            // 
            this.tb_preco_unit_item.Location = new System.Drawing.Point(828, 191);
            this.tb_preco_unit_item.Name = "tb_preco_unit_item";
            this.tb_preco_unit_item.Size = new System.Drawing.Size(92, 20);
            this.tb_preco_unit_item.TabIndex = 147;
            // 
            // tb_qtde_item
            // 
            this.tb_qtde_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_qtde_item.Location = new System.Drawing.Point(762, 191);
            this.tb_qtde_item.Name = "tb_qtde_item";
            this.tb_qtde_item.Size = new System.Drawing.Size(67, 20);
            this.tb_qtde_item.TabIndex = 146;
            // 
            // tb_unid_item
            // 
            this.tb_unid_item.Location = new System.Drawing.Point(630, 191);
            this.tb_unid_item.Name = "tb_unid_item";
            this.tb_unid_item.Size = new System.Drawing.Size(31, 20);
            this.tb_unid_item.TabIndex = 144;
            // 
            // dgvItens_nota
            // 
            this.dgvItens_nota.AllowUserToAddRows = false;
            this.dgvItens_nota.AutoGenerateColumns = false;
            this.dgvItens_nota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens_nota.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODITEMVENDADataGridViewTextBoxColumn,
            this.col_cod_forn,
            this.dESCRICAOPRODITEMVENDADataGridViewTextBoxColumn,
            this.DESCRICAO_ITEM_PROD_ITEM_VENDA,
            this.MARCA_ITEM_VENDA,
            this.uNIDADEPRODITEMVENDADataGridViewTextBoxColumn,
            this.PRAZO_ITEM_VENDA,
            this.col_qtde,
            this.col_valor_unit,
            this.col_valor_total,
            this.col_cod,
            this.bCICMSPRODITEMVENDADataGridViewTextBoxColumn,
            this.aLIQICMSPRODITEMVENDADataGridViewTextBoxColumn,
            this.bCIPIPRODITEMVENDADataGridViewTextBoxColumn,
            this.aLIQIPIPRODITEMVENDADataGridViewTextBoxColumn,
            this.nFPRODITEMVENDADataGridViewTextBoxColumn,
            this.nNFPRODITEMVENDADataGridViewTextBoxColumn,
            this.oBSITEMVENDADataGridViewTextBoxColumn});
            this.dgvItens_nota.DataMember = "ITENS_PEDIDO_VENDA";
            this.dgvItens_nota.DataSource = this.dsItens_ped_venda;
            this.dgvItens_nota.Location = new System.Drawing.Point(23, 217);
            this.dgvItens_nota.Name = "dgvItens_nota";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItens_nota.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvItens_nota.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvItens_nota.Size = new System.Drawing.Size(995, 219);
            this.dgvItens_nota.TabIndex = 149;
            // 
            // cODITEMVENDADataGridViewTextBoxColumn
            // 
            this.cODITEMVENDADataGridViewTextBoxColumn.DataPropertyName = "COD_ITEM_VENDA";
            this.cODITEMVENDADataGridViewTextBoxColumn.HeaderText = "COD_ITEM_VENDA";
            this.cODITEMVENDADataGridViewTextBoxColumn.Name = "cODITEMVENDADataGridViewTextBoxColumn";
            this.cODITEMVENDADataGridViewTextBoxColumn.Visible = false;
            // 
            // col_cod_forn
            // 
            this.col_cod_forn.DataPropertyName = "COD_PROD_ITEM_VENDA";
            this.col_cod_forn.HeaderText = "Cód.";
            this.col_cod_forn.Name = "col_cod_forn";
            this.col_cod_forn.Width = 65;
            // 
            // dESCRICAOPRODITEMVENDADataGridViewTextBoxColumn
            // 
            this.dESCRICAOPRODITEMVENDADataGridViewTextBoxColumn.DataPropertyName = "DESCRICAO_PROD_ITEM_VENDA";
            this.dESCRICAOPRODITEMVENDADataGridViewTextBoxColumn.HeaderText = "Descrição Produto";
            this.dESCRICAOPRODITEMVENDADataGridViewTextBoxColumn.Name = "dESCRICAOPRODITEMVENDADataGridViewTextBoxColumn";
            this.dESCRICAOPRODITEMVENDADataGridViewTextBoxColumn.Width = 190;
            // 
            // DESCRICAO_ITEM_PROD_ITEM_VENDA
            // 
            this.DESCRICAO_ITEM_PROD_ITEM_VENDA.DataPropertyName = "DESCRICAO_ITEM_PROD_ITEM_VENDA";
            this.DESCRICAO_ITEM_PROD_ITEM_VENDA.HeaderText = "Descrição Item";
            this.DESCRICAO_ITEM_PROD_ITEM_VENDA.Name = "DESCRICAO_ITEM_PROD_ITEM_VENDA";
            this.DESCRICAO_ITEM_PROD_ITEM_VENDA.Width = 210;
            // 
            // MARCA_ITEM_VENDA
            // 
            this.MARCA_ITEM_VENDA.DataPropertyName = "MARCA_ITEM_VENDA";
            this.MARCA_ITEM_VENDA.HeaderText = "Marca";
            this.MARCA_ITEM_VENDA.Name = "MARCA_ITEM_VENDA";
            // 
            // uNIDADEPRODITEMVENDADataGridViewTextBoxColumn
            // 
            this.uNIDADEPRODITEMVENDADataGridViewTextBoxColumn.DataPropertyName = "UNIDADE_PROD_ITEM_VENDA";
            this.uNIDADEPRODITEMVENDADataGridViewTextBoxColumn.HeaderText = "Un.";
            this.uNIDADEPRODITEMVENDADataGridViewTextBoxColumn.Name = "uNIDADEPRODITEMVENDADataGridViewTextBoxColumn";
            this.uNIDADEPRODITEMVENDADataGridViewTextBoxColumn.Width = 30;
            // 
            // PRAZO_ITEM_VENDA
            // 
            this.PRAZO_ITEM_VENDA.DataPropertyName = "PRAZO_ITEM_VENDA";
            this.PRAZO_ITEM_VENDA.HeaderText = "Prazo";
            this.PRAZO_ITEM_VENDA.Name = "PRAZO_ITEM_VENDA";
            // 
            // col_qtde
            // 
            this.col_qtde.DataPropertyName = "QTDE_ITEM_VENDA";
            this.col_qtde.HeaderText = "Qtde";
            this.col_qtde.Name = "col_qtde";
            this.col_qtde.Width = 70;
            // 
            // col_valor_unit
            // 
            this.col_valor_unit.DataPropertyName = "VALOR_UNIT_PROD_ITEM_VENDA";
            this.col_valor_unit.HeaderText = "Valor Unitário";
            this.col_valor_unit.Name = "col_valor_unit";
            this.col_valor_unit.Width = 90;
            // 
            // col_valor_total
            // 
            this.col_valor_total.DataPropertyName = "VALOR_TOTAL_PROD_ITEM_VENDA";
            this.col_valor_total.HeaderText = "Valor Total";
            this.col_valor_total.Name = "col_valor_total";
            this.col_valor_total.Width = 90;
            // 
            // col_cod
            // 
            this.col_cod.DataPropertyName = "COD_SISTEMA_PROD_ITEM_VENDA";
            this.col_cod.HeaderText = "COD_SISTEMA_PROD_ITEM_VENDA";
            this.col_cod.Name = "col_cod";
            // 
            // bCICMSPRODITEMVENDADataGridViewTextBoxColumn
            // 
            this.bCICMSPRODITEMVENDADataGridViewTextBoxColumn.DataPropertyName = "BC_ICMS_PROD_ITEM_VENDA";
            this.bCICMSPRODITEMVENDADataGridViewTextBoxColumn.HeaderText = "BC Icms";
            this.bCICMSPRODITEMVENDADataGridViewTextBoxColumn.Name = "bCICMSPRODITEMVENDADataGridViewTextBoxColumn";
            // 
            // aLIQICMSPRODITEMVENDADataGridViewTextBoxColumn
            // 
            this.aLIQICMSPRODITEMVENDADataGridViewTextBoxColumn.DataPropertyName = "ALIQ_ICMS_PROD_ITEM_VENDA";
            this.aLIQICMSPRODITEMVENDADataGridViewTextBoxColumn.HeaderText = "Aliquota Icms";
            this.aLIQICMSPRODITEMVENDADataGridViewTextBoxColumn.Name = "aLIQICMSPRODITEMVENDADataGridViewTextBoxColumn";
            // 
            // bCIPIPRODITEMVENDADataGridViewTextBoxColumn
            // 
            this.bCIPIPRODITEMVENDADataGridViewTextBoxColumn.DataPropertyName = "BC_IPI_PROD_ITEM_VENDA";
            this.bCIPIPRODITEMVENDADataGridViewTextBoxColumn.HeaderText = "BC IPI";
            this.bCIPIPRODITEMVENDADataGridViewTextBoxColumn.Name = "bCIPIPRODITEMVENDADataGridViewTextBoxColumn";
            // 
            // aLIQIPIPRODITEMVENDADataGridViewTextBoxColumn
            // 
            this.aLIQIPIPRODITEMVENDADataGridViewTextBoxColumn.DataPropertyName = "ALIQ_IPI_PROD_ITEM_VENDA";
            this.aLIQIPIPRODITEMVENDADataGridViewTextBoxColumn.HeaderText = "Aliquota IPI";
            this.aLIQIPIPRODITEMVENDADataGridViewTextBoxColumn.Name = "aLIQIPIPRODITEMVENDADataGridViewTextBoxColumn";
            // 
            // nFPRODITEMVENDADataGridViewTextBoxColumn
            // 
            this.nFPRODITEMVENDADataGridViewTextBoxColumn.DataPropertyName = "NF_PROD_ITEM_VENDA";
            this.nFPRODITEMVENDADataGridViewTextBoxColumn.HeaderText = "NF?";
            this.nFPRODITEMVENDADataGridViewTextBoxColumn.Name = "nFPRODITEMVENDADataGridViewTextBoxColumn";
            // 
            // nNFPRODITEMVENDADataGridViewTextBoxColumn
            // 
            this.nNFPRODITEMVENDADataGridViewTextBoxColumn.DataPropertyName = "N_NF_PROD_ITEM_VENDA";
            this.nNFPRODITEMVENDADataGridViewTextBoxColumn.HeaderText = "Nº NF";
            this.nNFPRODITEMVENDADataGridViewTextBoxColumn.Name = "nNFPRODITEMVENDADataGridViewTextBoxColumn";
            // 
            // oBSITEMVENDADataGridViewTextBoxColumn
            // 
            this.oBSITEMVENDADataGridViewTextBoxColumn.DataPropertyName = "OBS_ITEM_VENDA";
            this.oBSITEMVENDADataGridViewTextBoxColumn.HeaderText = "Obs";
            this.oBSITEMVENDADataGridViewTextBoxColumn.Name = "oBSITEMVENDADataGridViewTextBoxColumn";
            // 
            // dsItens_ped_venda
            // 
            this.dsItens_ped_venda.DataSetName = "dsItens_ped_venda";
            this.dsItens_ped_venda.Namespace = "http://www.tempuri.org/dsItens_ped_venda.xsd";
            this.dsItens_ped_venda.Tables.AddRange(new System.Data.DataTable[] {
            this.ITENS_PEDIDO_VENDA});
            // 
            // ITENS_PEDIDO_VENDA
            // 
            this.ITENS_PEDIDO_VENDA.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_ITEM_VENDA,
            this.QTDE_ITEM_VENDA,
            this.COD_PROD_ITEM_VENDA,
            this.DESCRICAO_PROD_ITEM_VENDA,
            this.VALOR_UNIT_PROD_ITEM_VENDA,
            this.VALOR_TOTAL_PROD_ITEM_VENDA,
            this.UNIDADE_PROD_ITEM_VENDA,
            this.BC_ICMS_PROD_ITEM_VENDA,
            this.ALIQ_ICMS_PROD_ITEM_VENDA,
            this.BC_IPI_PROD_ITEM_VENDA,
            this.ALIQ_IPI_PROD_ITEM_VENDA,
            this.NF_PROD_ITEM_VENDA,
            this.N_NF_PROD_ITEM_VENDA,
            this.OBS_ITEM_VENDA,
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn8,
            this.dataColumn9,
            this.dataColumn11,
            this.dataColumn12,
            this.dataColumn13,
            this.dataColumn14,
            this.dataColumn15});
            this.ITENS_PEDIDO_VENDA.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_ITEM_VENDA"}, true)});
            this.ITENS_PEDIDO_VENDA.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_ITEM_VENDA};
            this.ITENS_PEDIDO_VENDA.TableName = "ITENS_PEDIDO_VENDA";
            // 
            // COD_ITEM_VENDA
            // 
            this.COD_ITEM_VENDA.AllowDBNull = false;
            this.COD_ITEM_VENDA.ColumnName = "COD_ITEM_VENDA";
            this.COD_ITEM_VENDA.DataType = typeof(int);
            // 
            // QTDE_ITEM_VENDA
            // 
            this.QTDE_ITEM_VENDA.ColumnName = "QTDE_ITEM_VENDA";
            this.QTDE_ITEM_VENDA.DataType = typeof(double);
            // 
            // COD_PROD_ITEM_VENDA
            // 
            this.COD_PROD_ITEM_VENDA.ColumnName = "COD_PROD_ITEM_VENDA";
            this.COD_PROD_ITEM_VENDA.MaxLength = 50;
            // 
            // DESCRICAO_PROD_ITEM_VENDA
            // 
            this.DESCRICAO_PROD_ITEM_VENDA.ColumnName = "DESCRICAO_PROD_ITEM_VENDA";
            this.DESCRICAO_PROD_ITEM_VENDA.MaxLength = 200;
            // 
            // VALOR_UNIT_PROD_ITEM_VENDA
            // 
            this.VALOR_UNIT_PROD_ITEM_VENDA.ColumnName = "VALOR_UNIT_PROD_ITEM_VENDA";
            this.VALOR_UNIT_PROD_ITEM_VENDA.DataType = typeof(double);
            // 
            // VALOR_TOTAL_PROD_ITEM_VENDA
            // 
            this.VALOR_TOTAL_PROD_ITEM_VENDA.ColumnName = "VALOR_TOTAL_PROD_ITEM_VENDA";
            this.VALOR_TOTAL_PROD_ITEM_VENDA.DataType = typeof(double);
            // 
            // UNIDADE_PROD_ITEM_VENDA
            // 
            this.UNIDADE_PROD_ITEM_VENDA.ColumnName = "UNIDADE_PROD_ITEM_VENDA";
            this.UNIDADE_PROD_ITEM_VENDA.MaxLength = 30;
            // 
            // BC_ICMS_PROD_ITEM_VENDA
            // 
            this.BC_ICMS_PROD_ITEM_VENDA.ColumnName = "BC_ICMS_PROD_ITEM_VENDA";
            this.BC_ICMS_PROD_ITEM_VENDA.DataType = typeof(double);
            // 
            // ALIQ_ICMS_PROD_ITEM_VENDA
            // 
            this.ALIQ_ICMS_PROD_ITEM_VENDA.ColumnName = "ALIQ_ICMS_PROD_ITEM_VENDA";
            this.ALIQ_ICMS_PROD_ITEM_VENDA.DataType = typeof(double);
            // 
            // BC_IPI_PROD_ITEM_VENDA
            // 
            this.BC_IPI_PROD_ITEM_VENDA.ColumnName = "BC_IPI_PROD_ITEM_VENDA";
            this.BC_IPI_PROD_ITEM_VENDA.DataType = typeof(int);
            // 
            // ALIQ_IPI_PROD_ITEM_VENDA
            // 
            this.ALIQ_IPI_PROD_ITEM_VENDA.ColumnName = "ALIQ_IPI_PROD_ITEM_VENDA";
            this.ALIQ_IPI_PROD_ITEM_VENDA.DataType = typeof(double);
            // 
            // NF_PROD_ITEM_VENDA
            // 
            this.NF_PROD_ITEM_VENDA.ColumnName = "NF_PROD_ITEM_VENDA";
            this.NF_PROD_ITEM_VENDA.DataType = typeof(int);
            // 
            // N_NF_PROD_ITEM_VENDA
            // 
            this.N_NF_PROD_ITEM_VENDA.ColumnName = "N_NF_PROD_ITEM_VENDA";
            this.N_NF_PROD_ITEM_VENDA.DataType = typeof(int);
            // 
            // OBS_ITEM_VENDA
            // 
            this.OBS_ITEM_VENDA.ColumnName = "OBS_ITEM_VENDA";
            this.OBS_ITEM_VENDA.MaxLength = 300;
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "VALOR_IPI_ITEM_VENDA";
            this.dataColumn1.DataType = typeof(double);
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "VALOR_ICMS_ITEM_VENDA";
            this.dataColumn2.DataType = typeof(double);
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "COD_PEDIDO_ITEM_VENDA";
            this.dataColumn3.DataType = typeof(int);
            // 
            // dataColumn8
            // 
            this.dataColumn8.ColumnName = "COD_VENDEDOR_ITEM_VENDA";
            this.dataColumn8.DataType = typeof(int);
            // 
            // dataColumn9
            // 
            this.dataColumn9.ColumnName = "DATA_PEDIDO_ITEM_VENDA";
            this.dataColumn9.DataType = typeof(System.DateTime);
            // 
            // dataColumn11
            // 
            this.dataColumn11.ColumnName = "PRAZO_ITEM_VENDA";
            this.dataColumn11.MaxLength = 50;
            // 
            // dataColumn12
            // 
            this.dataColumn12.ColumnName = "CANCELADO_ITEM_PED";
            this.dataColumn12.DataType = typeof(int);
            // 
            // dataColumn13
            // 
            this.dataColumn13.ColumnName = "DESCRICAO_ITEM_PROD_ITEM_VENDA";
            this.dataColumn13.MaxLength = 200;
            // 
            // dataColumn14
            // 
            this.dataColumn14.ColumnName = "MARCA_ITEM_VENDA";
            this.dataColumn14.MaxLength = 50;
            // 
            // dataColumn15
            // 
            this.dataColumn15.ColumnName = "COD_SISTEMA_PROD_ITEM_VENDA";
            this.dataColumn15.DataType = typeof(int);
            // 
            // tb_forma_pgto
            // 
            this.tb_forma_pgto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPedidos_venda, "PEDIDOS_VENDA.COND_PGTO_PED_VENDA", true));
            this.tb_forma_pgto.Location = new System.Drawing.Point(679, 527);
            this.tb_forma_pgto.Name = "tb_forma_pgto";
            this.tb_forma_pgto.Size = new System.Drawing.Size(121, 20);
            this.tb_forma_pgto.TabIndex = 212;
            this.tb_forma_pgto.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tb_forma_pgto_MouseDoubleClick);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(566, 530);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(110, 13);
            this.label35.TabIndex = 215;
            this.label35.Text = "Forma de pagamento:";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(15, 50);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(163, 21);
            this.button6.TabIndex = 211;
            this.button6.Text = "Calcular";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // tb_total_pedido
            // 
            this.tb_total_pedido.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPedidos_venda, "PEDIDOS_VENDA.VALOR_TOTAL_PED_VENDA", true));
            this.tb_total_pedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_total_pedido.Location = new System.Drawing.Point(15, 138);
            this.tb_total_pedido.Name = "tb_total_pedido";
            this.tb_total_pedido.Size = new System.Drawing.Size(164, 31);
            this.tb_total_pedido.TabIndex = 217;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(12, 122);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(166, 13);
            this.label20.TabIndex = 214;
            this.label20.Text = "Valor Total do Orçamento/Pedido";
            // 
            // tb_total_prod
            // 
            this.tb_total_prod.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPedidos_venda, "PEDIDOS_VENDA.VALOR_TOTAL_PROD_PED_VENDA", true));
            this.tb_total_prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_total_prod.Location = new System.Drawing.Point(15, 88);
            this.tb_total_prod.Name = "tb_total_prod";
            this.tb_total_prod.Size = new System.Drawing.Size(163, 31);
            this.tb_total_prod.TabIndex = 216;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 72);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(123, 13);
            this.label15.TabIndex = 213;
            this.label15.Text = "Valor Total dos Produtos";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(126, 175);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(150, 13);
            this.label12.TabIndex = 218;
            this.label12.Text = "Descrição Produto (Aperte F2)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 219;
            this.label1.Text = "Cód. Forn.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(633, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 220;
            this.label3.Text = "Un.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(778, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 221;
            this.label5.Text = "Qtde";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(838, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 222;
            this.label6.Text = "Valor Unitário";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cb_Nfe
            // 
            this.cb_Nfe.AutoSize = true;
            this.cb_Nfe.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsPedidos_venda, "PEDIDOS_VENDA.NF_PED_VENDA", true));
            this.cb_Nfe.Location = new System.Drawing.Point(158, 14);
            this.cb_Nfe.Name = "cb_Nfe";
            this.cb_Nfe.Size = new System.Drawing.Size(43, 17);
            this.cb_Nfe.TabIndex = 223;
            this.cb_Nfe.Text = "Nfe";
            this.cb_Nfe.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 225;
            this.label7.Text = "Total ICMS:";
            // 
            // tb_total_icms
            // 
            this.tb_total_icms.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPedidos_venda, "PEDIDOS_VENDA.VALOR_TOTAL_ICMS_PED_VENDA", true));
            this.tb_total_icms.Location = new System.Drawing.Point(114, 24);
            this.tb_total_icms.Name = "tb_total_icms";
            this.tb_total_icms.Size = new System.Drawing.Size(121, 20);
            this.tb_total_icms.TabIndex = 224;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 227;
            this.label9.Text = "Total IPI:";
            // 
            // tb_icms_ipi
            // 
            this.tb_icms_ipi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPedidos_venda, "PEDIDOS_VENDA.VALOR_TOTAL_IPI_PED_VENDA", true));
            this.tb_icms_ipi.Location = new System.Drawing.Point(114, 50);
            this.tb_icms_ipi.Name = "tb_icms_ipi";
            this.tb_icms_ipi.Size = new System.Drawing.Size(121, 20);
            this.tb_icms_ipi.TabIndex = 226;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_icms_ipi);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tb_total_icms);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(565, 442);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 79);
            this.groupBox1.TabIndex = 228;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tributação";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 173);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 30);
            this.button2.TabIndex = 229;
            this.button2.Text = "Fechar Pedido";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbPedidos_venda
            // 
            this.cbPedidos_venda.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbPedidos_venda.DataAdapter = this.datPedidos_venda;
            this.cbPedidos_venda.QuotePrefix = "\"";
            this.cbPedidos_venda.QuoteSuffix = "\"";
            // 
            // datPedidos_venda
            // 
            this.datPedidos_venda.DeleteCommand = this.fbCommand12;
            this.datPedidos_venda.InsertCommand = this.fbCommand10;
            this.datPedidos_venda.SelectCommand = this.fbCommand9;
            this.datPedidos_venda.UpdateCommand = this.fbCommand11;
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
            this.fbCommand9.CommandText = "select * from pedidos_venda";
            this.fbCommand9.CommandTimeout = 30;
            this.fbCommand9.Connection = this.fbConnection1;
            // 
            // fbConnection1
            // 
            this.fbConnection1.ConnectionString = resources.GetString("fbConnection1.ConnectionString");
            // 
            // fbCommand11
            // 
            this.fbCommand11.CommandTimeout = 30;
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
            this.fbCommand1.CommandTimeout = 30;
            // 
            // fbCommand3
            // 
            this.fbCommand3.CommandTimeout = 30;
            // 
            // datItens_ped_venda
            // 
            this.datItens_ped_venda.DeleteCommand = this.fbCommand8;
            this.datItens_ped_venda.InsertCommand = this.fbCommand6;
            this.datItens_ped_venda.SelectCommand = this.fbCommand5;
            this.datItens_ped_venda.UpdateCommand = this.fbCommand7;
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
            this.fbCommand5.CommandText = "SELECT * FROM ITENS_PEDIDO_VENDA";
            this.fbCommand5.CommandTimeout = 30;
            this.fbCommand5.Connection = this.fbConnection1;
            // 
            // fbCommand7
            // 
            this.fbCommand7.CommandTimeout = 30;
            // 
            // bt_localizar
            // 
            this.bt_localizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_localizar.BackgroundImage")));
            this.bt_localizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_localizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_localizar.Location = new System.Drawing.Point(817, 17);
            this.bt_localizar.Name = "bt_localizar";
            this.bt_localizar.Size = new System.Drawing.Size(57, 60);
            this.bt_localizar.TabIndex = 273;
            this.bt_localizar.UseVisualStyleBackColor = true;
            this.bt_localizar.Click += new System.EventHandler(this.bt_localizar_Click);
            // 
            // bt_excluir
            // 
            this.bt_excluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_excluir.BackgroundImage")));
            this.bt_excluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_excluir.Location = new System.Drawing.Point(745, 16);
            this.bt_excluir.Name = "bt_excluir";
            this.bt_excluir.Size = new System.Drawing.Size(57, 60);
            this.bt_excluir.TabIndex = 272;
            this.bt_excluir.UseVisualStyleBackColor = true;
            this.bt_excluir.Click += new System.EventHandler(this.bt_excluir_Click);
            // 
            // bt_salvar
            // 
            this.bt_salvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_salvar.BackgroundImage")));
            this.bt_salvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_salvar.Location = new System.Drawing.Point(607, 16);
            this.bt_salvar.Name = "bt_salvar";
            this.bt_salvar.Size = new System.Drawing.Size(57, 60);
            this.bt_salvar.TabIndex = 270;
            this.bt_salvar.UseVisualStyleBackColor = true;
            this.bt_salvar.Click += new System.EventHandler(this.bt_salvar_Click);
            // 
            // bt_novo
            // 
            this.bt_novo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_novo.BackgroundImage")));
            this.bt_novo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_novo.Location = new System.Drawing.Point(676, 16);
            this.bt_novo.Name = "bt_novo";
            this.bt_novo.Size = new System.Drawing.Size(57, 60);
            this.bt_novo.TabIndex = 271;
            this.bt_novo.UseVisualStyleBackColor = true;
            this.bt_novo.Click += new System.EventHandler(this.bt_novo_Click);
            // 
            // cbItens_ped_venda
            // 
            this.cbItens_ped_venda.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbItens_ped_venda.DataAdapter = this.datItens_ped_venda;
            this.cbItens_ped_venda.QuotePrefix = "\"";
            this.cbItens_ped_venda.QuoteSuffix = "\"";
            // 
            // comando_select
            // 
            this.comando_select.CommandTimeout = 30;
            this.comando_select.Connection = this.fbConnection1;
            // 
            // cb_baixado_est
            // 
            this.cb_baixado_est.AutoSize = true;
            this.cb_baixado_est.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsPedidos_venda, "PEDIDOS_VENDA.BAIXADO_ESTOQUE_PED_VENDA", true));
            this.cb_baixado_est.Location = new System.Drawing.Point(83, 7);
            this.cb_baixado_est.Name = "cb_baixado_est";
            this.cb_baixado_est.Size = new System.Drawing.Size(65, 30);
            this.cb_baixado_est.TabIndex = 274;
            this.cb_baixado_est.Text = "Baixado\r\nEstoque";
            this.cb_baixado_est.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(216, 645);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 30);
            this.button3.TabIndex = 275;
            this.button3.Text = "Selecionar todos";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // datProdutos
            // 
            this.datProdutos.DeleteCommand = this.fbCommand16;
            this.datProdutos.InsertCommand = this.fbCommand14;
            this.datProdutos.SelectCommand = this.fbCommand13;
            this.datProdutos.UpdateCommand = this.fbCommand15;
            // 
            // fbCommand16
            // 
            this.fbCommand16.CommandTimeout = 30;
            // 
            // fbCommand14
            // 
            this.fbCommand14.CommandTimeout = 30;
            // 
            // fbCommand13
            // 
            this.fbCommand13.CommandText = "select * from produtos";
            this.fbCommand13.CommandTimeout = 30;
            this.fbCommand13.Connection = this.fbConnection1;
            // 
            // fbCommand15
            // 
            this.fbCommand15.CommandTimeout = 30;
            // 
            // fbCommand17
            // 
            this.fbCommand17.CommandText = "select * from itens_PEDIDO_VENDA";
            this.fbCommand17.CommandTimeout = 30;
            this.fbCommand17.Connection = this.fbConnection1;
            // 
            // fbCommand18
            // 
            this.fbCommand18.CommandTimeout = 30;
            // 
            // fbCommand19
            // 
            this.fbCommand19.CommandTimeout = 30;
            // 
            // fbCommand20
            // 
            this.fbCommand20.CommandTimeout = 30;
            // 
            // datFatura_nf
            // 
            this.datFatura_nf.DeleteCommand = this.fbCommand24;
            this.datFatura_nf.InsertCommand = this.fbCommand22;
            this.datFatura_nf.SelectCommand = this.fbCommand21;
            this.datFatura_nf.UpdateCommand = this.fbCommand23;
            // 
            // fbCommand24
            // 
            this.fbCommand24.CommandTimeout = 30;
            // 
            // fbCommand22
            // 
            this.fbCommand22.CommandTimeout = 30;
            // 
            // fbCommand21
            // 
            this.fbCommand21.CommandText = "select * from fatura_nf";
            this.fbCommand21.CommandTimeout = 30;
            this.fbCommand21.Connection = this.fbConnection1;
            // 
            // fbCommand23
            // 
            this.fbCommand23.CommandTimeout = 30;
            // 
            // dsFatura_nf
            // 
            this.dsFatura_nf.DataSetName = "dsFatura_nf";
            this.dsFatura_nf.Namespace = "http://www.tempuri.org/dsFatura_nf.xsd";
            this.dsFatura_nf.Tables.AddRange(new System.Data.DataTable[] {
            this.FATURA_NF});
            // 
            // FATURA_NF
            // 
            this.FATURA_NF.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_FATURA,
            this.PRAZO_FATURA,
            this.DATA_VENC_FATURA,
            this.VALOR_FATURA,
            this.NF_FATURA});
            this.FATURA_NF.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_FATURA"}, true)});
            this.FATURA_NF.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_FATURA};
            this.FATURA_NF.TableName = "FATURA_NF";
            // 
            // COD_FATURA
            // 
            this.COD_FATURA.AllowDBNull = false;
            this.COD_FATURA.ColumnName = "COD_FATURA";
            this.COD_FATURA.DataType = typeof(int);
            // 
            // PRAZO_FATURA
            // 
            this.PRAZO_FATURA.ColumnName = "PRAZO_FATURA";
            this.PRAZO_FATURA.DataType = typeof(int);
            // 
            // DATA_VENC_FATURA
            // 
            this.DATA_VENC_FATURA.ColumnName = "DATA_VENC_FATURA";
            this.DATA_VENC_FATURA.DataType = typeof(System.DateTime);
            // 
            // VALOR_FATURA
            // 
            this.VALOR_FATURA.ColumnName = "VALOR_FATURA";
            this.VALOR_FATURA.DataType = typeof(double);
            // 
            // NF_FATURA
            // 
            this.NF_FATURA.ColumnName = "NF_FATURA";
            this.NF_FATURA.DataType = typeof(int);
            // 
            // datImp_duplicatas
            // 
            this.datImp_duplicatas.DeleteCommand = this.fbCommand28;
            this.datImp_duplicatas.InsertCommand = this.fbCommand26;
            this.datImp_duplicatas.SelectCommand = this.fbCommand25;
            this.datImp_duplicatas.UpdateCommand = this.fbCommand27;
            // 
            // fbCommand28
            // 
            this.fbCommand28.CommandTimeout = 30;
            // 
            // fbCommand26
            // 
            this.fbCommand26.CommandTimeout = 30;
            // 
            // fbCommand25
            // 
            this.fbCommand25.CommandText = "select * from imp_duplicatas";
            this.fbCommand25.CommandTimeout = 30;
            this.fbCommand25.Connection = this.fbConnection1;
            // 
            // fbCommand27
            // 
            this.fbCommand27.CommandTimeout = 30;
            // 
            // dsImp_duplicatas
            // 
            this.dsImp_duplicatas.DataSetName = "dsImp_duplicatas";
            this.dsImp_duplicatas.Namespace = "http://www.tempuri.org/dsImp_duplicatas.xsd";
            this.dsImp_duplicatas.Tables.AddRange(new System.Data.DataTable[] {
            this.IMP_DUPLICATAS});
            // 
            // IMP_DUPLICATAS
            // 
            this.IMP_DUPLICATAS.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_IMP_DUPLICATA,
            this.COD_1_IMP_DUPLICATA,
            this.DATA_1_IMP_DUPLICATA,
            this.VALOR_1_IMP_DUPLICATA,
            this.COD_2_IMP_DUPLICATA,
            this.DATA_2_IMP_DUPLICATA,
            this.VALOR_2_IMP_DUPLICATA,
            this.COD_3_IMP_DUPLICATA,
            this.DATA_3_IMP_DUPLICATA,
            this.VALOR_3_IMP_DUPLICATA,
            this.COD_4_IMP_DUPLICATA,
            this.DATA_4_IMP_DUPLICATA,
            this.VALOR_4_IMP_DUPLICATA,
            this.COD_5_IMP_DUPLICATA,
            this.DATA_5_IMP_DUPLICATA,
            this.VALOR_5_IMP_DUPLICATA,
            this.COD_6_IMP_DUPLICATA,
            this.DATA_6_IMP_DUPLICATA,
            this.VALOR_6_IMP_DUPLICATA});
            this.IMP_DUPLICATAS.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_IMP_DUPLICATA"}, true)});
            this.IMP_DUPLICATAS.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_IMP_DUPLICATA};
            this.IMP_DUPLICATAS.TableName = "IMP_DUPLICATAS";
            // 
            // COD_IMP_DUPLICATA
            // 
            this.COD_IMP_DUPLICATA.AllowDBNull = false;
            this.COD_IMP_DUPLICATA.ColumnName = "COD_IMP_DUPLICATA";
            this.COD_IMP_DUPLICATA.DataType = typeof(int);
            // 
            // COD_1_IMP_DUPLICATA
            // 
            this.COD_1_IMP_DUPLICATA.ColumnName = "COD_1_IMP_DUPLICATA";
            this.COD_1_IMP_DUPLICATA.DataType = typeof(int);
            // 
            // DATA_1_IMP_DUPLICATA
            // 
            this.DATA_1_IMP_DUPLICATA.ColumnName = "DATA_1_IMP_DUPLICATA";
            this.DATA_1_IMP_DUPLICATA.DataType = typeof(System.DateTime);
            // 
            // VALOR_1_IMP_DUPLICATA
            // 
            this.VALOR_1_IMP_DUPLICATA.ColumnName = "VALOR_1_IMP_DUPLICATA";
            this.VALOR_1_IMP_DUPLICATA.DataType = typeof(double);
            // 
            // COD_2_IMP_DUPLICATA
            // 
            this.COD_2_IMP_DUPLICATA.ColumnName = "COD_2_IMP_DUPLICATA";
            this.COD_2_IMP_DUPLICATA.DataType = typeof(int);
            // 
            // DATA_2_IMP_DUPLICATA
            // 
            this.DATA_2_IMP_DUPLICATA.ColumnName = "DATA_2_IMP_DUPLICATA";
            this.DATA_2_IMP_DUPLICATA.DataType = typeof(System.DateTime);
            // 
            // VALOR_2_IMP_DUPLICATA
            // 
            this.VALOR_2_IMP_DUPLICATA.ColumnName = "VALOR_2_IMP_DUPLICATA";
            this.VALOR_2_IMP_DUPLICATA.DataType = typeof(double);
            // 
            // COD_3_IMP_DUPLICATA
            // 
            this.COD_3_IMP_DUPLICATA.ColumnName = "COD_3_IMP_DUPLICATA";
            this.COD_3_IMP_DUPLICATA.DataType = typeof(int);
            // 
            // DATA_3_IMP_DUPLICATA
            // 
            this.DATA_3_IMP_DUPLICATA.ColumnName = "DATA_3_IMP_DUPLICATA";
            this.DATA_3_IMP_DUPLICATA.DataType = typeof(System.DateTime);
            // 
            // VALOR_3_IMP_DUPLICATA
            // 
            this.VALOR_3_IMP_DUPLICATA.ColumnName = "VALOR_3_IMP_DUPLICATA";
            this.VALOR_3_IMP_DUPLICATA.DataType = typeof(double);
            // 
            // COD_4_IMP_DUPLICATA
            // 
            this.COD_4_IMP_DUPLICATA.ColumnName = "COD_4_IMP_DUPLICATA";
            this.COD_4_IMP_DUPLICATA.DataType = typeof(int);
            // 
            // DATA_4_IMP_DUPLICATA
            // 
            this.DATA_4_IMP_DUPLICATA.ColumnName = "DATA_4_IMP_DUPLICATA";
            this.DATA_4_IMP_DUPLICATA.DataType = typeof(System.DateTime);
            // 
            // VALOR_4_IMP_DUPLICATA
            // 
            this.VALOR_4_IMP_DUPLICATA.ColumnName = "VALOR_4_IMP_DUPLICATA";
            this.VALOR_4_IMP_DUPLICATA.DataType = typeof(double);
            // 
            // COD_5_IMP_DUPLICATA
            // 
            this.COD_5_IMP_DUPLICATA.ColumnName = "COD_5_IMP_DUPLICATA";
            this.COD_5_IMP_DUPLICATA.DataType = typeof(int);
            // 
            // DATA_5_IMP_DUPLICATA
            // 
            this.DATA_5_IMP_DUPLICATA.ColumnName = "DATA_5_IMP_DUPLICATA";
            this.DATA_5_IMP_DUPLICATA.DataType = typeof(System.DateTime);
            // 
            // VALOR_5_IMP_DUPLICATA
            // 
            this.VALOR_5_IMP_DUPLICATA.ColumnName = "VALOR_5_IMP_DUPLICATA";
            this.VALOR_5_IMP_DUPLICATA.DataType = typeof(double);
            // 
            // COD_6_IMP_DUPLICATA
            // 
            this.COD_6_IMP_DUPLICATA.ColumnName = "COD_6_IMP_DUPLICATA";
            this.COD_6_IMP_DUPLICATA.DataType = typeof(int);
            // 
            // DATA_6_IMP_DUPLICATA
            // 
            this.DATA_6_IMP_DUPLICATA.ColumnName = "DATA_6_IMP_DUPLICATA";
            this.DATA_6_IMP_DUPLICATA.DataType = typeof(System.DateTime);
            // 
            // VALOR_6_IMP_DUPLICATA
            // 
            this.VALOR_6_IMP_DUPLICATA.ColumnName = "VALOR_6_IMP_DUPLICATA";
            this.VALOR_6_IMP_DUPLICATA.DataType = typeof(double);
            // 
            // tb_vendedor
            // 
            this.tb_vendedor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPedidos_venda, "PEDIDOS_VENDA.VENDEDOR_PED_VENDA", true));
            this.tb_vendedor.Location = new System.Drawing.Point(132, 119);
            this.tb_vendedor.Name = "tb_vendedor";
            this.tb_vendedor.Size = new System.Drawing.Size(121, 20);
            this.tb_vendedor.TabIndex = 278;
            // 
            // tb_cod_vendedor
            // 
            this.tb_cod_vendedor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPedidos_venda, "PEDIDOS_VENDA.COD_VENDEDOR_PED_VENDA", true));
            this.tb_cod_vendedor.Location = new System.Drawing.Point(92, 119);
            this.tb_cod_vendedor.Name = "tb_cod_vendedor";
            this.tb_cod_vendedor.Size = new System.Drawing.Size(41, 20);
            this.tb_cod_vendedor.TabIndex = 277;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(253, 117);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(23, 23);
            this.button4.TabIndex = 139;
            this.button4.Text = "+";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 279;
            this.label10.Text = "Vendedor:";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(79, 645);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(131, 30);
            this.button7.TabIndex = 280;
            this.button7.Text = "Cancelar Pedido";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Visible = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // datContas_a_receber
            // 
            this.datContas_a_receber.DeleteCommand = this.fbCommand32;
            this.datContas_a_receber.InsertCommand = this.fbCommand30;
            this.datContas_a_receber.SelectCommand = this.fbCommand29;
            this.datContas_a_receber.UpdateCommand = this.fbCommand31;
            // 
            // fbCommand32
            // 
            this.fbCommand32.CommandTimeout = 30;
            // 
            // fbCommand30
            // 
            this.fbCommand30.CommandTimeout = 30;
            // 
            // fbCommand29
            // 
            this.fbCommand29.CommandText = "select * from contas_a_receber";
            this.fbCommand29.CommandTimeout = 30;
            this.fbCommand29.Connection = this.fbConnection1;
            // 
            // fbCommand31
            // 
            this.fbCommand31.CommandTimeout = 30;
            // 
            // datClientes
            // 
            this.datClientes.DeleteCommand = this.fbCommand36;
            this.datClientes.InsertCommand = this.fbCommand34;
            this.datClientes.SelectCommand = this.fbCommand33;
            this.datClientes.UpdateCommand = this.fbCommand35;
            // 
            // fbCommand36
            // 
            this.fbCommand36.CommandTimeout = 30;
            // 
            // fbCommand34
            // 
            this.fbCommand34.CommandTimeout = 30;
            // 
            // fbCommand33
            // 
            this.fbCommand33.CommandText = "select * from clientes";
            this.fbCommand33.CommandTimeout = 30;
            this.fbCommand33.Connection = this.fbConnection1;
            // 
            // fbCommand35
            // 
            this.fbCommand35.CommandTimeout = 30;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(79, 591);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(131, 37);
            this.button8.TabIndex = 281;
            this.button8.Text = "Inserir no Contas a receber";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Visible = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // cbRecebido
            // 
            this.cbRecebido.AutoSize = true;
            this.cbRecebido.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsPedidos_venda, "PEDIDOS_VENDA.PAGO_PED_VENDA", true));
            this.cbRecebido.Enabled = false;
            this.cbRecebido.Location = new System.Drawing.Point(5, 14);
            this.cbRecebido.Name = "cbRecebido";
            this.cbRecebido.Size = new System.Drawing.Size(72, 17);
            this.cbRecebido.TabIndex = 282;
            this.cbRecebido.Text = "Recebido";
            this.cbRecebido.UseVisualStyleBackColor = true;
            // 
            // tb_descricao_item
            // 
            this.tb_descricao_item.Location = new System.Drawing.Point(318, 191);
            this.tb_descricao_item.Name = "tb_descricao_item";
            this.tb_descricao_item.Size = new System.Drawing.Size(210, 20);
            this.tb_descricao_item.TabIndex = 142;
            // 
            // tb_prazo
            // 
            this.tb_prazo.Location = new System.Drawing.Point(660, 191);
            this.tb_prazo.Name = "tb_prazo";
            this.tb_prazo.Size = new System.Drawing.Size(103, 20);
            this.tb_prazo.TabIndex = 145;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(697, 175);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 285;
            this.label11.Text = "Prazo";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tb_marca
            // 
            this.tb_marca.Location = new System.Drawing.Point(528, 191);
            this.tb_marca.Name = "tb_marca";
            this.tb_marca.Size = new System.Drawing.Size(103, 20);
            this.tb_marca.TabIndex = 143;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(555, 175);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 287;
            this.label13.Text = "Marca";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(325, 175);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 13);
            this.label14.TabIndex = 288;
            this.label14.Text = "Descrição Item";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(923, 175);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 13);
            this.label16.TabIndex = 290;
            this.label16.Text = "Cód. Produto";
            // 
            // tb_cod_sistema
            // 
            this.tb_cod_sistema.Location = new System.Drawing.Point(919, 191);
            this.tb_cod_sistema.Name = "tb_cod_sistema";
            this.tb_cod_sistema.Size = new System.Drawing.Size(76, 20);
            this.tb_cod_sistema.TabIndex = 289;
            this.tb_cod_sistema.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_cod_sistema_KeyPress);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(15, 203);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(77, 37);
            this.button9.TabIndex = 291;
            this.button9.Text = "Imprimir Pedido";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(98, 203);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(80, 38);
            this.button10.TabIndex = 292;
            this.button10.Text = "Enviar Email";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // barra_status
            // 
            this.barra_status.Location = new System.Drawing.Point(0, 686);
            this.barra_status.Name = "barra_status";
            this.barra_status.Size = new System.Drawing.Size(1034, 22);
            this.barra_status.TabIndex = 293;
            this.barra_status.Text = "statusStrip1";
            // 
            // datEmails_enviados
            // 
            this.datEmails_enviados.DeleteCommand = this.fbCommand40;
            this.datEmails_enviados.InsertCommand = this.fbCommand38;
            this.datEmails_enviados.SelectCommand = this.fbCommand37;
            this.datEmails_enviados.UpdateCommand = this.fbCommand39;
            // 
            // fbCommand40
            // 
            this.fbCommand40.CommandTimeout = 30;
            // 
            // fbCommand38
            // 
            this.fbCommand38.CommandTimeout = 30;
            // 
            // fbCommand37
            // 
            this.fbCommand37.CommandText = "select * from emails_enviados";
            this.fbCommand37.CommandTimeout = 30;
            this.fbCommand37.Connection = this.fbConnection1;
            // 
            // fbCommand39
            // 
            this.fbCommand39.CommandTimeout = 30;
            // 
            // contatotextBox
            // 
            this.contatotextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPedidos_venda, "PEDIDOS_VENDA.NOME_CONTATO_PED_VENDA", true));
            this.contatotextBox.Location = new System.Drawing.Point(58, 37);
            this.contatotextBox.Name = "contatotextBox";
            this.contatotextBox.Size = new System.Drawing.Size(166, 20);
            this.contatotextBox.TabIndex = 294;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(10, 40);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 13);
            this.label17.TabIndex = 295;
            this.label17.Text = "Contato:";
            // 
            // teltextBox
            // 
            this.teltextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPedidos_venda, "PEDIDOS_VENDA.TELEFONE_CONTATO_PED_VENDA", true));
            this.teltextBox.Location = new System.Drawing.Point(262, 37);
            this.teltextBox.Name = "teltextBox";
            this.teltextBox.Size = new System.Drawing.Size(113, 20);
            this.teltextBox.TabIndex = 296;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(231, 40);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(25, 13);
            this.label18.TabIndex = 297;
            this.label18.Text = "Tel:";
            // 
            // emailtextBox
            // 
            this.emailtextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPedidos_venda, "PEDIDOS_VENDA.EMAIL_CONTATO_PED_VENDA", true));
            this.emailtextBox.Location = new System.Drawing.Point(429, 37);
            this.emailtextBox.Name = "emailtextBox";
            this.emailtextBox.Size = new System.Drawing.Size(113, 20);
            this.emailtextBox.TabIndex = 298;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(388, 40);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(35, 13);
            this.label19.TabIndex = 299;
            this.label19.Text = "Email:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.emailtextBox);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.teltextBox);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.contatotextBox);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.tb_cliente);
            this.panel1.Controls.Add(this.tb_cnpj_cliente);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(434, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 65);
            this.panel1.TabIndex = 300;
            // 
            // fbCommand41
            // 
            this.fbCommand41.CommandText = "select * from clientes";
            this.fbCommand41.CommandTimeout = 30;
            this.fbCommand41.Connection = this.fbConnection1;
            // 
            // fbCommand42
            // 
            this.fbCommand42.CommandTimeout = 30;
            // 
            // fbCommand43
            // 
            this.fbCommand43.CommandTimeout = 30;
            // 
            // fbCommand44
            // 
            this.fbCommand44.CommandTimeout = 30;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPedidos_venda, "PEDIDOS_VENDA.OBS_PED_VENDA", true));
            this.textBox1.Location = new System.Drawing.Point(63, 448);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(493, 81);
            this.textBox1.TabIndex = 301;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(25, 451);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(29, 13);
            this.label21.TabIndex = 228;
            this.label21.Text = "Obs:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.cbRecebido);
            this.panel2.Controls.Add(this.cb_baixado_est);
            this.panel2.Controls.Add(this.cb_Nfe);
            this.panel2.Location = new System.Drawing.Point(585, 639);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 44);
            this.panel2.TabIndex = 302;
            // 
            // tb_valor_desconto
            // 
            this.tb_valor_desconto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPedidos_venda, "PEDIDOS_VENDA.VALOR_DESCONTO_PED_VENDA", true));
            this.tb_valor_desconto.Location = new System.Drawing.Point(102, 25);
            this.tb_valor_desconto.Name = "tb_valor_desconto";
            this.tb_valor_desconto.Size = new System.Drawing.Size(77, 20);
            this.tb_valor_desconto.TabIndex = 303;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(13, 28);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(83, 13);
            this.label22.TabIndex = 304;
            this.label22.Text = "Valor Desconto:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(13, 6);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(67, 13);
            this.label23.TabIndex = 305;
            this.label23.Text = "% Desconto:";
            // 
            // tb_porc_desconto
            // 
            this.tb_porc_desconto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPedidos_venda, "PEDIDOS_VENDA.PORC_DESCONTO_PED_VENDA", true));
            this.tb_porc_desconto.Location = new System.Drawing.Point(102, 3);
            this.tb_porc_desconto.Name = "tb_porc_desconto";
            this.tb_porc_desconto.Size = new System.Drawing.Size(77, 20);
            this.tb_porc_desconto.TabIndex = 306;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.tb_porc_desconto);
            this.panel3.Controls.Add(this.label23);
            this.panel3.Controls.Add(this.label22);
            this.panel3.Controls.Add(this.tb_valor_desconto);
            this.panel3.Controls.Add(this.button10);
            this.panel3.Controls.Add(this.button9);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.tb_total_pedido);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.tb_total_prod);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Location = new System.Drawing.Point(828, 441);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(194, 245);
            this.panel3.TabIndex = 307;
            // 
            // form_pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 708);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barra_status);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.tb_cod_sistema);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tb_marca);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tb_prazo);
            this.Controls.Add(this.tb_descricao_item);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_vendedor);
            this.Controls.Add(this.tb_cod_vendedor);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.bt_localizar);
            this.Controls.Add(this.bt_excluir);
            this.Controls.Add(this.bt_salvar);
            this.Controls.Add(this.bt_novo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tb_forma_pgto);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.tb_descricao_produto);
            this.Controls.Add(this.tb_cod_fornecedor);
            this.Controls.Add(this.tb_preco_unit_item);
            this.Controls.Add(this.tb_qtde_item);
            this.Controls.Add(this.tb_unid_item);
            this.Controls.Add(this.dgvItens_nota);
            this.Controls.Add(this.tb_data_pedido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_n_pedido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label28);
            this.Name = "form_pedidos";
            this.Text = "Orçamentos";
            this.Load += new System.EventHandler(this.form_pedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsPedidos_venda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PEDIDOS_VENDA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens_nota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsItens_ped_venda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITENS_PEDIDO_VENDA)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsFatura_nf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FATURA_NF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsImp_duplicatas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMP_DUPLICATAS)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox tb_n_pedido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_data_pedido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_cliente;
        private System.Windows.Forms.TextBox tb_cnpj_cliente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox tb_descricao_produto;
        private System.Windows.Forms.TextBox tb_cod_fornecedor;
        private System.Windows.Forms.TextBox tb_preco_unit_item;
        private System.Windows.Forms.TextBox tb_qtde_item;
        private System.Windows.Forms.TextBox tb_unid_item;
        private System.Windows.Forms.DataGridView dgvItens_nota;
        private System.Windows.Forms.TextBox tb_forma_pgto;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox tb_total_pedido;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tb_total_prod;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cb_Nfe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_total_icms;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_icms_ipi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Data.DataSet dsPedidos_venda;
        private System.Data.DataTable PEDIDOS_VENDA;
        private System.Data.DataColumn COD_PED_VENDA;
        private System.Data.DataColumn DATA_PED_VENDA;
        private System.Data.DataColumn DATA_BAIXA_PED_VENDA;
        private System.Data.DataColumn CLIENTE_PED_VENDA;
        private System.Data.DataColumn CNPJ_PED_VENDA;
        private System.Data.DataColumn COND_PGTO_PED_VENDA;
        private System.Data.DataColumn VALOR_TOTAL_PED_VENDA;
        private System.Data.DataColumn VALOR_TOTAL_ICMS_PED_VENDA;
        private System.Data.DataColumn VALOR_TOTAL_IPI_PED_VENDA;
        private System.Data.DataColumn VALOR_DESCONTO_PED_VENDA;
        private System.Data.DataColumn OBS_PED_VENDA;
        private System.Data.DataColumn NF_PED_VENDA;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbPedidos_venda;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private System.Data.DataSet dsItens_ped_venda;
        private System.Data.DataTable ITENS_PEDIDO_VENDA;
        private System.Data.DataColumn COD_ITEM_VENDA;
        private System.Data.DataColumn QTDE_ITEM_VENDA;
        private System.Data.DataColumn COD_PROD_ITEM_VENDA;
        private System.Data.DataColumn DESCRICAO_PROD_ITEM_VENDA;
        private System.Data.DataColumn VALOR_UNIT_PROD_ITEM_VENDA;
        private System.Data.DataColumn VALOR_TOTAL_PROD_ITEM_VENDA;
        private System.Data.DataColumn UNIDADE_PROD_ITEM_VENDA;
        private System.Data.DataColumn BC_ICMS_PROD_ITEM_VENDA;
        private System.Data.DataColumn ALIQ_ICMS_PROD_ITEM_VENDA;
        private System.Data.DataColumn BC_IPI_PROD_ITEM_VENDA;
        private System.Data.DataColumn ALIQ_IPI_PROD_ITEM_VENDA;
        private System.Data.DataColumn NF_PROD_ITEM_VENDA;
        private System.Data.DataColumn N_NF_PROD_ITEM_VENDA;
        private System.Data.DataColumn OBS_ITEM_VENDA;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datItens_ped_venda;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand8;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand6;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand5;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand7;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Windows.Forms.Button bt_localizar;
        private System.Windows.Forms.Button bt_excluir;
        private System.Windows.Forms.Button bt_salvar;
        private System.Windows.Forms.Button bt_novo;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbItens_ped_venda;
        private FirebirdSql.Data.FirebirdClient.FbCommand comando_select;
        private System.Data.DataColumn dataColumn4;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datPedidos_venda;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand12;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand10;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand9;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand11;
        private System.Data.DataColumn dataColumn5;
        private System.Windows.Forms.CheckBox cb_baixado_est;
        private System.Windows.Forms.Button button3;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datProdutos;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand16;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand14;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand13;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand15;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand20;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand18;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand17;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand19;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datFatura_nf;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand24;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand22;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand21;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand23;
        private System.Data.DataSet dsFatura_nf;
        private System.Data.DataTable FATURA_NF;
        private System.Data.DataColumn COD_FATURA;
        private System.Data.DataColumn PRAZO_FATURA;
        private System.Data.DataColumn DATA_VENC_FATURA;
        private System.Data.DataColumn VALOR_FATURA;
        private System.Data.DataColumn NF_FATURA;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datImp_duplicatas;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand28;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand26;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand25;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand27;
        private System.Data.DataSet dsImp_duplicatas;
        private System.Data.DataTable IMP_DUPLICATAS;
        private System.Data.DataColumn COD_IMP_DUPLICATA;
        private System.Data.DataColumn COD_1_IMP_DUPLICATA;
        private System.Data.DataColumn DATA_1_IMP_DUPLICATA;
        private System.Data.DataColumn VALOR_1_IMP_DUPLICATA;
        private System.Data.DataColumn COD_2_IMP_DUPLICATA;
        private System.Data.DataColumn DATA_2_IMP_DUPLICATA;
        private System.Data.DataColumn VALOR_2_IMP_DUPLICATA;
        private System.Data.DataColumn COD_3_IMP_DUPLICATA;
        private System.Data.DataColumn DATA_3_IMP_DUPLICATA;
        private System.Data.DataColumn VALOR_3_IMP_DUPLICATA;
        private System.Data.DataColumn COD_4_IMP_DUPLICATA;
        private System.Data.DataColumn DATA_4_IMP_DUPLICATA;
        private System.Data.DataColumn VALOR_4_IMP_DUPLICATA;
        private System.Data.DataColumn COD_5_IMP_DUPLICATA;
        private System.Data.DataColumn DATA_5_IMP_DUPLICATA;
        private System.Data.DataColumn VALOR_5_IMP_DUPLICATA;
        private System.Data.DataColumn COD_6_IMP_DUPLICATA;
        private System.Data.DataColumn DATA_6_IMP_DUPLICATA;
        private System.Data.DataColumn VALOR_6_IMP_DUPLICATA;
        private System.Data.DataColumn dataColumn6;
        private System.Data.DataColumn dataColumn7;
        private System.Windows.Forms.TextBox tb_vendedor;
        private System.Windows.Forms.TextBox tb_cod_vendedor;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label10;
        private System.Data.DataColumn dataColumn8;
        private System.Data.DataColumn dataColumn9;
        private System.Windows.Forms.Button button7;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datContas_a_receber;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand32;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand30;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand29;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand31;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datClientes;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand36;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand34;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand33;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand35;
        private System.Windows.Forms.Button button8;
        private System.Data.DataColumn dataColumn10;
        private System.Windows.Forms.CheckBox cbRecebido;
        private System.Data.DataColumn dataColumn11;
        private System.Data.DataColumn dataColumn12;
        private System.Data.DataColumn dataColumn13;
        private System.Data.DataColumn dataColumn14;
        private System.Windows.Forms.TextBox tb_descricao_item;
        private System.Windows.Forms.TextBox tb_prazo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_marca;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tb_cod_sistema;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODITEMVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod_forn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRICAOPRODITEMVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRICAO_ITEM_PROD_ITEM_VENDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MARCA_ITEM_VENDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn uNIDADEPRODITEMVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRAZO_ITEM_VENDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_qtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_valor_unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_valor_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn bCICMSPRODITEMVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aLIQICMSPRODITEMVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bCIPIPRODITEMVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aLIQIPIPRODITEMVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nFPRODITEMVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nNFPRODITEMVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oBSITEMVENDADataGridViewTextBoxColumn;
        private System.Data.DataColumn dataColumn15;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.StatusStrip barra_status;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datEmails_enviados;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand40;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand38;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand37;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand39;
        private System.Windows.Forms.TextBox contatotextBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox teltextBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox emailtextBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel panel1;
        private System.Data.DataColumn dataColumn16;
        private System.Data.DataColumn dataColumn17;
        private System.Data.DataColumn dataColumn18;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand41;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand42;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand43;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand44;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tb_valor_desconto;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox tb_porc_desconto;
        private System.Windows.Forms.Panel panel3;
        private System.Data.DataColumn dataColumn19;
    }
}