namespace Evolucao
{
    partial class form_multiplicar_cp_cr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_multiplicar_cp_cr));
            this.tb_n = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_dia = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.datContas_a_pagar = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsContas_a_pagar = new System.Data.DataSet();
            this.CONTAS_A_PAGAR = new System.Data.DataTable();
            this.COD_CP = new System.Data.DataColumn();
            this.VALOR_CP = new System.Data.DataColumn();
            this.DATA_PREVISTA_CP = new System.Data.DataColumn();
            this.DATA_PAGAMENTO_CP = new System.Data.DataColumn();
            this.COD_FORNECEDOR_CP = new System.Data.DataColumn();
            this.RAZAO_FORNECEDOR_CP = new System.Data.DataColumn();
            this.DESCRICAO_CP = new System.Data.DataColumn();
            this.DUPLICATA_CP = new System.Data.DataColumn();
            this.PLANO_CP = new System.Data.DataColumn();
            this.PAGO_CP = new System.Data.DataColumn();
            this.NF_CP = new System.Data.DataColumn();
            this.COD_CAIXA_CP = new System.Data.DataColumn();
            this.CARTEIRA_CP = new System.Data.DataColumn();
            this.cbContas_a_pagar = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.datContas_a_receber = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand8 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand6 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand5 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand7 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsContas_a_receber = new System.Data.DataSet();
            this.CONTAS_A_RECEBER = new System.Data.DataTable();
            this.COD_CR = new System.Data.DataColumn();
            this.VALOR_CR = new System.Data.DataColumn();
            this.DATA_PREVISTA_CR = new System.Data.DataColumn();
            this.DATA_RECEBIMENTO_CR = new System.Data.DataColumn();
            this.COD_CLIENTE_CR = new System.Data.DataColumn();
            this.RAZAO_CLIENTE_CR = new System.Data.DataColumn();
            this.DESCRICAO_CR = new System.Data.DataColumn();
            this.DUPLICATA_CR = new System.Data.DataColumn();
            this.NF_CR = new System.Data.DataColumn();
            this.RECEBIDO_CR = new System.Data.DataColumn();
            this.COD_CAIXA_CR = new System.Data.DataColumn();
            this.PLANO_CR = new System.Data.DataColumn();
            this.CARTEIRA_CR = new System.Data.DataColumn();
            this.cbContas_a_receber = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_data_prevista_inicial = new System.Windows.Forms.TextBox();
            this.dgvContas_a_pagar = new System.Windows.Forms.DataGridView();
            this.cODCPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORCPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAPREVISTACPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAPAGAMENTOCPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODFORNECEDORCPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAZAOFORNECEDORCPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRICAOCPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dUPLICATACPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pLANOCPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAGOCPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nFCPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODCAIXACPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cARTEIRACPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvContas_a_receber = new System.Windows.Forms.DataGridView();
            this.cODCRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORCRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAPREVISTACRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATARECEBIMENTOCRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODCLIENTECRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAZAOCLIENTECRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRICAOCRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dUPLICATACRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nFCRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rECEBIDOCRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODCAIXACRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pLANOCRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cARTEIRACRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dsContas_a_pagar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CONTAS_A_PAGAR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsContas_a_receber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CONTAS_A_RECEBER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContas_a_pagar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContas_a_receber)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_n
            // 
            this.tb_n.Location = new System.Drawing.Point(324, 6);
            this.tb_n.Name = "tb_n";
            this.tb_n.Size = new System.Drawing.Size(51, 20);
            this.tb_n.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nº a Multiplicar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dia de Vencimento:";
            // 
            // tb_dia
            // 
            this.tb_dia.Location = new System.Drawing.Point(240, 26);
            this.tb_dia.Name = "tb_dia";
            this.tb_dia.Size = new System.Drawing.Size(51, 20);
            this.tb_dia.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(134, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Multiplicar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // datContas_a_pagar
            // 
            this.datContas_a_pagar.DeleteCommand = this.fbCommand4;
            this.datContas_a_pagar.InsertCommand = this.fbCommand2;
            this.datContas_a_pagar.SelectCommand = this.fbCommand1;
            this.datContas_a_pagar.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * from contas_a_pagar";
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
            // dsContas_a_pagar
            // 
            this.dsContas_a_pagar.DataSetName = "dsContas_a_pagar";
            this.dsContas_a_pagar.Namespace = "http://www.tempuri.org/dsContas_a_pagar.xsd";
            this.dsContas_a_pagar.Tables.AddRange(new System.Data.DataTable[] {
            this.CONTAS_A_PAGAR});
            // 
            // CONTAS_A_PAGAR
            // 
            this.CONTAS_A_PAGAR.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_CP,
            this.VALOR_CP,
            this.DATA_PREVISTA_CP,
            this.DATA_PAGAMENTO_CP,
            this.COD_FORNECEDOR_CP,
            this.RAZAO_FORNECEDOR_CP,
            this.DESCRICAO_CP,
            this.DUPLICATA_CP,
            this.PLANO_CP,
            this.PAGO_CP,
            this.NF_CP,
            this.COD_CAIXA_CP,
            this.CARTEIRA_CP});
            this.CONTAS_A_PAGAR.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_CP"}, true)});
            this.CONTAS_A_PAGAR.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_CP};
            this.CONTAS_A_PAGAR.TableName = "CONTAS_A_PAGAR";
            // 
            // COD_CP
            // 
            this.COD_CP.AllowDBNull = false;
            this.COD_CP.ColumnName = "COD_CP";
            this.COD_CP.DataType = typeof(int);
            // 
            // VALOR_CP
            // 
            this.VALOR_CP.ColumnName = "VALOR_CP";
            this.VALOR_CP.DataType = typeof(double);
            // 
            // DATA_PREVISTA_CP
            // 
            this.DATA_PREVISTA_CP.ColumnName = "DATA_PREVISTA_CP";
            this.DATA_PREVISTA_CP.DataType = typeof(System.DateTime);
            // 
            // DATA_PAGAMENTO_CP
            // 
            this.DATA_PAGAMENTO_CP.ColumnName = "DATA_PAGAMENTO_CP";
            this.DATA_PAGAMENTO_CP.DataType = typeof(System.DateTime);
            // 
            // COD_FORNECEDOR_CP
            // 
            this.COD_FORNECEDOR_CP.ColumnName = "COD_FORNECEDOR_CP";
            this.COD_FORNECEDOR_CP.DataType = typeof(int);
            // 
            // RAZAO_FORNECEDOR_CP
            // 
            this.RAZAO_FORNECEDOR_CP.ColumnName = "RAZAO_FORNECEDOR_CP";
            this.RAZAO_FORNECEDOR_CP.MaxLength = 100;
            // 
            // DESCRICAO_CP
            // 
            this.DESCRICAO_CP.ColumnName = "DESCRICAO_CP";
            this.DESCRICAO_CP.MaxLength = 200;
            // 
            // DUPLICATA_CP
            // 
            this.DUPLICATA_CP.ColumnName = "DUPLICATA_CP";
            this.DUPLICATA_CP.MaxLength = 50;
            // 
            // PLANO_CP
            // 
            this.PLANO_CP.ColumnName = "PLANO_CP";
            this.PLANO_CP.MaxLength = 50;
            // 
            // PAGO_CP
            // 
            this.PAGO_CP.ColumnName = "PAGO_CP";
            this.PAGO_CP.DataType = typeof(int);
            // 
            // NF_CP
            // 
            this.NF_CP.ColumnName = "NF_CP";
            this.NF_CP.MaxLength = 50;
            // 
            // COD_CAIXA_CP
            // 
            this.COD_CAIXA_CP.ColumnName = "COD_CAIXA_CP";
            this.COD_CAIXA_CP.DataType = typeof(int);
            // 
            // CARTEIRA_CP
            // 
            this.CARTEIRA_CP.ColumnName = "CARTEIRA_CP";
            this.CARTEIRA_CP.MaxLength = 50;
            // 
            // cbContas_a_pagar
            // 
            this.cbContas_a_pagar.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbContas_a_pagar.DataAdapter = this.datContas_a_pagar;
            this.cbContas_a_pagar.QuotePrefix = "\"";
            this.cbContas_a_pagar.QuoteSuffix = "\"";
            // 
            // datContas_a_receber
            // 
            this.datContas_a_receber.DeleteCommand = this.fbCommand8;
            this.datContas_a_receber.InsertCommand = this.fbCommand6;
            this.datContas_a_receber.SelectCommand = this.fbCommand5;
            this.datContas_a_receber.UpdateCommand = this.fbCommand7;
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
            this.fbCommand5.CommandText = "select * from contas_a_receber";
            this.fbCommand5.CommandTimeout = 30;
            this.fbCommand5.Connection = this.fbConnection1;
            // 
            // fbCommand7
            // 
            this.fbCommand7.CommandTimeout = 30;
            // 
            // dsContas_a_receber
            // 
            this.dsContas_a_receber.DataSetName = "dsContas_a_receber";
            this.dsContas_a_receber.Namespace = "http://www.tempuri.org/dsContas_a_receber.xsd";
            this.dsContas_a_receber.Tables.AddRange(new System.Data.DataTable[] {
            this.CONTAS_A_RECEBER});
            // 
            // CONTAS_A_RECEBER
            // 
            this.CONTAS_A_RECEBER.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_CR,
            this.VALOR_CR,
            this.DATA_PREVISTA_CR,
            this.DATA_RECEBIMENTO_CR,
            this.COD_CLIENTE_CR,
            this.RAZAO_CLIENTE_CR,
            this.DESCRICAO_CR,
            this.DUPLICATA_CR,
            this.NF_CR,
            this.RECEBIDO_CR,
            this.COD_CAIXA_CR,
            this.PLANO_CR,
            this.CARTEIRA_CR});
            this.CONTAS_A_RECEBER.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_CR"}, true)});
            this.CONTAS_A_RECEBER.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_CR};
            this.CONTAS_A_RECEBER.TableName = "CONTAS_A_RECEBER";
            // 
            // COD_CR
            // 
            this.COD_CR.AllowDBNull = false;
            this.COD_CR.ColumnName = "COD_CR";
            this.COD_CR.DataType = typeof(int);
            // 
            // VALOR_CR
            // 
            this.VALOR_CR.ColumnName = "VALOR_CR";
            this.VALOR_CR.DataType = typeof(double);
            // 
            // DATA_PREVISTA_CR
            // 
            this.DATA_PREVISTA_CR.ColumnName = "DATA_PREVISTA_CR";
            this.DATA_PREVISTA_CR.DataType = typeof(System.DateTime);
            // 
            // DATA_RECEBIMENTO_CR
            // 
            this.DATA_RECEBIMENTO_CR.ColumnName = "DATA_RECEBIMENTO_CR";
            this.DATA_RECEBIMENTO_CR.DataType = typeof(System.DateTime);
            // 
            // COD_CLIENTE_CR
            // 
            this.COD_CLIENTE_CR.ColumnName = "COD_CLIENTE_CR";
            this.COD_CLIENTE_CR.DataType = typeof(int);
            // 
            // RAZAO_CLIENTE_CR
            // 
            this.RAZAO_CLIENTE_CR.ColumnName = "RAZAO_CLIENTE_CR";
            this.RAZAO_CLIENTE_CR.MaxLength = 100;
            // 
            // DESCRICAO_CR
            // 
            this.DESCRICAO_CR.ColumnName = "DESCRICAO_CR";
            this.DESCRICAO_CR.MaxLength = 200;
            // 
            // DUPLICATA_CR
            // 
            this.DUPLICATA_CR.ColumnName = "DUPLICATA_CR";
            this.DUPLICATA_CR.MaxLength = 20;
            // 
            // NF_CR
            // 
            this.NF_CR.ColumnName = "NF_CR";
            this.NF_CR.DataType = typeof(int);
            // 
            // RECEBIDO_CR
            // 
            this.RECEBIDO_CR.ColumnName = "RECEBIDO_CR";
            this.RECEBIDO_CR.DataType = typeof(int);
            // 
            // COD_CAIXA_CR
            // 
            this.COD_CAIXA_CR.ColumnName = "COD_CAIXA_CR";
            this.COD_CAIXA_CR.DataType = typeof(int);
            // 
            // PLANO_CR
            // 
            this.PLANO_CR.ColumnName = "PLANO_CR";
            this.PLANO_CR.MaxLength = 50;
            // 
            // CARTEIRA_CR
            // 
            this.CARTEIRA_CR.ColumnName = "CARTEIRA_CR";
            this.CARTEIRA_CR.MaxLength = 50;
            // 
            // cbContas_a_receber
            // 
            this.cbContas_a_receber.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbContas_a_receber.DataAdapter = this.datContas_a_receber;
            this.cbContas_a_receber.QuotePrefix = "\"";
            this.cbContas_a_receber.QuoteSuffix = "\"";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data Prevista Inicial:";
            // 
            // tb_data_prevista_inicial
            // 
            this.tb_data_prevista_inicial.Location = new System.Drawing.Point(153, 6);
            this.tb_data_prevista_inicial.Name = "tb_data_prevista_inicial";
            this.tb_data_prevista_inicial.Size = new System.Drawing.Size(78, 20);
            this.tb_data_prevista_inicial.TabIndex = 5;
            // 
            // dgvContas_a_pagar
            // 
            this.dgvContas_a_pagar.AllowUserToAddRows = false;
            this.dgvContas_a_pagar.AutoGenerateColumns = false;
            this.dgvContas_a_pagar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContas_a_pagar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODCPDataGridViewTextBoxColumn,
            this.vALORCPDataGridViewTextBoxColumn,
            this.dATAPREVISTACPDataGridViewTextBoxColumn,
            this.dATAPAGAMENTOCPDataGridViewTextBoxColumn,
            this.cODFORNECEDORCPDataGridViewTextBoxColumn,
            this.rAZAOFORNECEDORCPDataGridViewTextBoxColumn,
            this.dESCRICAOCPDataGridViewTextBoxColumn,
            this.dUPLICATACPDataGridViewTextBoxColumn,
            this.pLANOCPDataGridViewTextBoxColumn,
            this.pAGOCPDataGridViewTextBoxColumn,
            this.nFCPDataGridViewTextBoxColumn,
            this.cODCAIXACPDataGridViewTextBoxColumn,
            this.cARTEIRACPDataGridViewTextBoxColumn});
            this.dgvContas_a_pagar.DataMember = "CONTAS_A_PAGAR";
            this.dgvContas_a_pagar.DataSource = this.dsContas_a_pagar;
            this.dgvContas_a_pagar.Location = new System.Drawing.Point(8, 120);
            this.dgvContas_a_pagar.Name = "dgvContas_a_pagar";
            this.dgvContas_a_pagar.Size = new System.Drawing.Size(195, 281);
            this.dgvContas_a_pagar.TabIndex = 7;
            // 
            // cODCPDataGridViewTextBoxColumn
            // 
            this.cODCPDataGridViewTextBoxColumn.DataPropertyName = "COD_CP";
            this.cODCPDataGridViewTextBoxColumn.HeaderText = "COD_CP";
            this.cODCPDataGridViewTextBoxColumn.Name = "cODCPDataGridViewTextBoxColumn";
            this.cODCPDataGridViewTextBoxColumn.Visible = false;
            // 
            // vALORCPDataGridViewTextBoxColumn
            // 
            this.vALORCPDataGridViewTextBoxColumn.DataPropertyName = "VALOR_CP";
            this.vALORCPDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.vALORCPDataGridViewTextBoxColumn.Name = "vALORCPDataGridViewTextBoxColumn";
            this.vALORCPDataGridViewTextBoxColumn.Width = 70;
            // 
            // dATAPREVISTACPDataGridViewTextBoxColumn
            // 
            this.dATAPREVISTACPDataGridViewTextBoxColumn.DataPropertyName = "DATA_PREVISTA_CP";
            this.dATAPREVISTACPDataGridViewTextBoxColumn.HeaderText = "Data Prevista";
            this.dATAPREVISTACPDataGridViewTextBoxColumn.Name = "dATAPREVISTACPDataGridViewTextBoxColumn";
            // 
            // dATAPAGAMENTOCPDataGridViewTextBoxColumn
            // 
            this.dATAPAGAMENTOCPDataGridViewTextBoxColumn.DataPropertyName = "DATA_PAGAMENTO_CP";
            this.dATAPAGAMENTOCPDataGridViewTextBoxColumn.HeaderText = "DATA_PAGAMENTO_CP";
            this.dATAPAGAMENTOCPDataGridViewTextBoxColumn.Name = "dATAPAGAMENTOCPDataGridViewTextBoxColumn";
            this.dATAPAGAMENTOCPDataGridViewTextBoxColumn.Visible = false;
            // 
            // cODFORNECEDORCPDataGridViewTextBoxColumn
            // 
            this.cODFORNECEDORCPDataGridViewTextBoxColumn.DataPropertyName = "COD_FORNECEDOR_CP";
            this.cODFORNECEDORCPDataGridViewTextBoxColumn.HeaderText = "COD_FORNECEDOR_CP";
            this.cODFORNECEDORCPDataGridViewTextBoxColumn.Name = "cODFORNECEDORCPDataGridViewTextBoxColumn";
            this.cODFORNECEDORCPDataGridViewTextBoxColumn.Visible = false;
            // 
            // rAZAOFORNECEDORCPDataGridViewTextBoxColumn
            // 
            this.rAZAOFORNECEDORCPDataGridViewTextBoxColumn.DataPropertyName = "RAZAO_FORNECEDOR_CP";
            this.rAZAOFORNECEDORCPDataGridViewTextBoxColumn.HeaderText = "RAZAO_FORNECEDOR_CP";
            this.rAZAOFORNECEDORCPDataGridViewTextBoxColumn.Name = "rAZAOFORNECEDORCPDataGridViewTextBoxColumn";
            this.rAZAOFORNECEDORCPDataGridViewTextBoxColumn.Visible = false;
            // 
            // dESCRICAOCPDataGridViewTextBoxColumn
            // 
            this.dESCRICAOCPDataGridViewTextBoxColumn.DataPropertyName = "DESCRICAO_CP";
            this.dESCRICAOCPDataGridViewTextBoxColumn.HeaderText = "DESCRICAO_CP";
            this.dESCRICAOCPDataGridViewTextBoxColumn.Name = "dESCRICAOCPDataGridViewTextBoxColumn";
            this.dESCRICAOCPDataGridViewTextBoxColumn.Visible = false;
            // 
            // dUPLICATACPDataGridViewTextBoxColumn
            // 
            this.dUPLICATACPDataGridViewTextBoxColumn.DataPropertyName = "DUPLICATA_CP";
            this.dUPLICATACPDataGridViewTextBoxColumn.HeaderText = "DUPLICATA_CP";
            this.dUPLICATACPDataGridViewTextBoxColumn.Name = "dUPLICATACPDataGridViewTextBoxColumn";
            this.dUPLICATACPDataGridViewTextBoxColumn.Visible = false;
            // 
            // pLANOCPDataGridViewTextBoxColumn
            // 
            this.pLANOCPDataGridViewTextBoxColumn.DataPropertyName = "PLANO_CP";
            this.pLANOCPDataGridViewTextBoxColumn.HeaderText = "PLANO_CP";
            this.pLANOCPDataGridViewTextBoxColumn.Name = "pLANOCPDataGridViewTextBoxColumn";
            this.pLANOCPDataGridViewTextBoxColumn.Visible = false;
            // 
            // pAGOCPDataGridViewTextBoxColumn
            // 
            this.pAGOCPDataGridViewTextBoxColumn.DataPropertyName = "PAGO_CP";
            this.pAGOCPDataGridViewTextBoxColumn.HeaderText = "PAGO_CP";
            this.pAGOCPDataGridViewTextBoxColumn.Name = "pAGOCPDataGridViewTextBoxColumn";
            this.pAGOCPDataGridViewTextBoxColumn.Visible = false;
            // 
            // nFCPDataGridViewTextBoxColumn
            // 
            this.nFCPDataGridViewTextBoxColumn.DataPropertyName = "NF_CP";
            this.nFCPDataGridViewTextBoxColumn.HeaderText = "NF_CP";
            this.nFCPDataGridViewTextBoxColumn.Name = "nFCPDataGridViewTextBoxColumn";
            this.nFCPDataGridViewTextBoxColumn.Visible = false;
            // 
            // cODCAIXACPDataGridViewTextBoxColumn
            // 
            this.cODCAIXACPDataGridViewTextBoxColumn.DataPropertyName = "COD_CAIXA_CP";
            this.cODCAIXACPDataGridViewTextBoxColumn.HeaderText = "COD_CAIXA_CP";
            this.cODCAIXACPDataGridViewTextBoxColumn.Name = "cODCAIXACPDataGridViewTextBoxColumn";
            this.cODCAIXACPDataGridViewTextBoxColumn.Visible = false;
            // 
            // cARTEIRACPDataGridViewTextBoxColumn
            // 
            this.cARTEIRACPDataGridViewTextBoxColumn.DataPropertyName = "CARTEIRA_CP";
            this.cARTEIRACPDataGridViewTextBoxColumn.HeaderText = "CARTEIRA_CP";
            this.cARTEIRACPDataGridViewTextBoxColumn.Name = "cARTEIRACPDataGridViewTextBoxColumn";
            this.cARTEIRACPDataGridViewTextBoxColumn.Visible = false;
            // 
            // dgvContas_a_receber
            // 
            this.dgvContas_a_receber.AllowUserToAddRows = false;
            this.dgvContas_a_receber.AutoGenerateColumns = false;
            this.dgvContas_a_receber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContas_a_receber.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODCRDataGridViewTextBoxColumn,
            this.vALORCRDataGridViewTextBoxColumn,
            this.dATAPREVISTACRDataGridViewTextBoxColumn,
            this.dATARECEBIMENTOCRDataGridViewTextBoxColumn,
            this.cODCLIENTECRDataGridViewTextBoxColumn,
            this.rAZAOCLIENTECRDataGridViewTextBoxColumn,
            this.dESCRICAOCRDataGridViewTextBoxColumn,
            this.dUPLICATACRDataGridViewTextBoxColumn,
            this.nFCRDataGridViewTextBoxColumn,
            this.rECEBIDOCRDataGridViewTextBoxColumn,
            this.cODCAIXACRDataGridViewTextBoxColumn,
            this.pLANOCRDataGridViewTextBoxColumn,
            this.cARTEIRACRDataGridViewTextBoxColumn});
            this.dgvContas_a_receber.DataMember = "CONTAS_A_RECEBER";
            this.dgvContas_a_receber.DataSource = this.dsContas_a_receber;
            this.dgvContas_a_receber.Location = new System.Drawing.Point(209, 120);
            this.dgvContas_a_receber.Name = "dgvContas_a_receber";
            this.dgvContas_a_receber.Size = new System.Drawing.Size(195, 281);
            this.dgvContas_a_receber.TabIndex = 8;
            // 
            // cODCRDataGridViewTextBoxColumn
            // 
            this.cODCRDataGridViewTextBoxColumn.DataPropertyName = "COD_CR";
            this.cODCRDataGridViewTextBoxColumn.HeaderText = "COD_CR";
            this.cODCRDataGridViewTextBoxColumn.Name = "cODCRDataGridViewTextBoxColumn";
            this.cODCRDataGridViewTextBoxColumn.Visible = false;
            // 
            // vALORCRDataGridViewTextBoxColumn
            // 
            this.vALORCRDataGridViewTextBoxColumn.DataPropertyName = "VALOR_CR";
            this.vALORCRDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.vALORCRDataGridViewTextBoxColumn.Name = "vALORCRDataGridViewTextBoxColumn";
            this.vALORCRDataGridViewTextBoxColumn.Width = 70;
            // 
            // dATAPREVISTACRDataGridViewTextBoxColumn
            // 
            this.dATAPREVISTACRDataGridViewTextBoxColumn.DataPropertyName = "DATA_PREVISTA_CR";
            this.dATAPREVISTACRDataGridViewTextBoxColumn.HeaderText = "Data Prevista";
            this.dATAPREVISTACRDataGridViewTextBoxColumn.Name = "dATAPREVISTACRDataGridViewTextBoxColumn";
            // 
            // dATARECEBIMENTOCRDataGridViewTextBoxColumn
            // 
            this.dATARECEBIMENTOCRDataGridViewTextBoxColumn.DataPropertyName = "DATA_RECEBIMENTO_CR";
            this.dATARECEBIMENTOCRDataGridViewTextBoxColumn.HeaderText = "DATA_RECEBIMENTO_CR";
            this.dATARECEBIMENTOCRDataGridViewTextBoxColumn.Name = "dATARECEBIMENTOCRDataGridViewTextBoxColumn";
            this.dATARECEBIMENTOCRDataGridViewTextBoxColumn.Visible = false;
            // 
            // cODCLIENTECRDataGridViewTextBoxColumn
            // 
            this.cODCLIENTECRDataGridViewTextBoxColumn.DataPropertyName = "COD_CLIENTE_CR";
            this.cODCLIENTECRDataGridViewTextBoxColumn.HeaderText = "COD_CLIENTE_CR";
            this.cODCLIENTECRDataGridViewTextBoxColumn.Name = "cODCLIENTECRDataGridViewTextBoxColumn";
            this.cODCLIENTECRDataGridViewTextBoxColumn.Visible = false;
            // 
            // rAZAOCLIENTECRDataGridViewTextBoxColumn
            // 
            this.rAZAOCLIENTECRDataGridViewTextBoxColumn.DataPropertyName = "RAZAO_CLIENTE_CR";
            this.rAZAOCLIENTECRDataGridViewTextBoxColumn.HeaderText = "RAZAO_CLIENTE_CR";
            this.rAZAOCLIENTECRDataGridViewTextBoxColumn.Name = "rAZAOCLIENTECRDataGridViewTextBoxColumn";
            this.rAZAOCLIENTECRDataGridViewTextBoxColumn.Visible = false;
            // 
            // dESCRICAOCRDataGridViewTextBoxColumn
            // 
            this.dESCRICAOCRDataGridViewTextBoxColumn.DataPropertyName = "DESCRICAO_CR";
            this.dESCRICAOCRDataGridViewTextBoxColumn.HeaderText = "DESCRICAO_CR";
            this.dESCRICAOCRDataGridViewTextBoxColumn.Name = "dESCRICAOCRDataGridViewTextBoxColumn";
            this.dESCRICAOCRDataGridViewTextBoxColumn.Visible = false;
            // 
            // dUPLICATACRDataGridViewTextBoxColumn
            // 
            this.dUPLICATACRDataGridViewTextBoxColumn.DataPropertyName = "DUPLICATA_CR";
            this.dUPLICATACRDataGridViewTextBoxColumn.HeaderText = "DUPLICATA_CR";
            this.dUPLICATACRDataGridViewTextBoxColumn.Name = "dUPLICATACRDataGridViewTextBoxColumn";
            this.dUPLICATACRDataGridViewTextBoxColumn.Visible = false;
            // 
            // nFCRDataGridViewTextBoxColumn
            // 
            this.nFCRDataGridViewTextBoxColumn.DataPropertyName = "NF_CR";
            this.nFCRDataGridViewTextBoxColumn.HeaderText = "NF_CR";
            this.nFCRDataGridViewTextBoxColumn.Name = "nFCRDataGridViewTextBoxColumn";
            this.nFCRDataGridViewTextBoxColumn.Visible = false;
            // 
            // rECEBIDOCRDataGridViewTextBoxColumn
            // 
            this.rECEBIDOCRDataGridViewTextBoxColumn.DataPropertyName = "RECEBIDO_CR";
            this.rECEBIDOCRDataGridViewTextBoxColumn.HeaderText = "RECEBIDO_CR";
            this.rECEBIDOCRDataGridViewTextBoxColumn.Name = "rECEBIDOCRDataGridViewTextBoxColumn";
            this.rECEBIDOCRDataGridViewTextBoxColumn.Visible = false;
            // 
            // cODCAIXACRDataGridViewTextBoxColumn
            // 
            this.cODCAIXACRDataGridViewTextBoxColumn.DataPropertyName = "COD_CAIXA_CR";
            this.cODCAIXACRDataGridViewTextBoxColumn.HeaderText = "COD_CAIXA_CR";
            this.cODCAIXACRDataGridViewTextBoxColumn.Name = "cODCAIXACRDataGridViewTextBoxColumn";
            this.cODCAIXACRDataGridViewTextBoxColumn.Visible = false;
            // 
            // pLANOCRDataGridViewTextBoxColumn
            // 
            this.pLANOCRDataGridViewTextBoxColumn.DataPropertyName = "PLANO_CR";
            this.pLANOCRDataGridViewTextBoxColumn.HeaderText = "PLANO_CR";
            this.pLANOCRDataGridViewTextBoxColumn.Name = "pLANOCRDataGridViewTextBoxColumn";
            this.pLANOCRDataGridViewTextBoxColumn.Visible = false;
            // 
            // cARTEIRACRDataGridViewTextBoxColumn
            // 
            this.cARTEIRACRDataGridViewTextBoxColumn.DataPropertyName = "CARTEIRA_CR";
            this.cARTEIRACRDataGridViewTextBoxColumn.HeaderText = "CARTEIRA_CR";
            this.cARTEIRACRDataGridViewTextBoxColumn.Name = "cARTEIRACRDataGridViewTextBoxColumn";
            this.cARTEIRACRDataGridViewTextBoxColumn.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Contas a Pagar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Contas a Receber";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(297, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Salvar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // form_multiplicar_cp_cr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 413);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvContas_a_receber);
            this.Controls.Add(this.dgvContas_a_pagar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_data_prevista_inicial);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_dia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_n);
            this.Name = "form_multiplicar_cp_cr";
            this.Text = "Multiplicar CP CR";
            this.Load += new System.EventHandler(this.form_multiplicar_cp_cr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsContas_a_pagar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CONTAS_A_PAGAR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsContas_a_receber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CONTAS_A_RECEBER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContas_a_pagar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContas_a_receber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_n;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_dia;
        private System.Windows.Forms.Button button1;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datContas_a_pagar;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Data.DataSet dsContas_a_pagar;
        private System.Data.DataTable CONTAS_A_PAGAR;
        private System.Data.DataColumn COD_CP;
        private System.Data.DataColumn VALOR_CP;
        private System.Data.DataColumn DATA_PREVISTA_CP;
        private System.Data.DataColumn DATA_PAGAMENTO_CP;
        private System.Data.DataColumn COD_FORNECEDOR_CP;
        private System.Data.DataColumn RAZAO_FORNECEDOR_CP;
        private System.Data.DataColumn DESCRICAO_CP;
        private System.Data.DataColumn DUPLICATA_CP;
        private System.Data.DataColumn PLANO_CP;
        private System.Data.DataColumn PAGO_CP;
        private System.Data.DataColumn NF_CP;
        private System.Data.DataColumn COD_CAIXA_CP;
        private System.Data.DataColumn CARTEIRA_CP;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbContas_a_pagar;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datContas_a_receber;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand8;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand6;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand5;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand7;
        private System.Data.DataSet dsContas_a_receber;
        private System.Data.DataTable CONTAS_A_RECEBER;
        private System.Data.DataColumn COD_CR;
        private System.Data.DataColumn VALOR_CR;
        private System.Data.DataColumn DATA_PREVISTA_CR;
        private System.Data.DataColumn DATA_RECEBIMENTO_CR;
        private System.Data.DataColumn COD_CLIENTE_CR;
        private System.Data.DataColumn RAZAO_CLIENTE_CR;
        private System.Data.DataColumn DESCRICAO_CR;
        private System.Data.DataColumn DUPLICATA_CR;
        private System.Data.DataColumn NF_CR;
        private System.Data.DataColumn RECEBIDO_CR;
        private System.Data.DataColumn COD_CAIXA_CR;
        private System.Data.DataColumn PLANO_CR;
        private System.Data.DataColumn CARTEIRA_CR;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbContas_a_receber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_data_prevista_inicial;
        private System.Windows.Forms.DataGridView dgvContas_a_pagar;
        private System.Windows.Forms.DataGridView dgvContas_a_receber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODCPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORCPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAPREVISTACPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAPAGAMENTOCPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODFORNECEDORCPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAZAOFORNECEDORCPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRICAOCPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dUPLICATACPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLANOCPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAGOCPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nFCPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODCAIXACPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cARTEIRACPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODCRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORCRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAPREVISTACRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATARECEBIMENTOCRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODCLIENTECRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAZAOCLIENTECRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRICAOCRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dUPLICATACRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nFCRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rECEBIDOCRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODCAIXACRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLANOCRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cARTEIRACRDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
    }
}