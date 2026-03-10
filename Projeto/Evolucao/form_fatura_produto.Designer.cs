namespace Evolucao
{
    partial class form_fatura_produto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_fatura_produto));
            this.datItens_ped_venda = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
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
            this.VALOR_ICMS_ITEM_VENDA = new System.Data.DataColumn();
            this.BC_IPI_PROD_ITEM_VENDA = new System.Data.DataColumn();
            this.ALIQ_IPI_PROD_ITEM_VENDA = new System.Data.DataColumn();
            this.VALOR_IPI_ITEM_VENDA = new System.Data.DataColumn();
            this.NF_PROD_ITEM_VENDA = new System.Data.DataColumn();
            this.N_NF_PROD_ITEM_VENDA = new System.Data.DataColumn();
            this.OBS_ITEM_VENDA = new System.Data.DataColumn();
            this.COD_PEDIDO_ITEM_VENDA = new System.Data.DataColumn();
            this.COD_VENDEDOR_ITEM_VENDA = new System.Data.DataColumn();
            this.dgvItens_ped_venda = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.cODITEMVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qTDEITEMVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODPRODITEMVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRICAOPRODITEMVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORUNITPRODITEMVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORTOTALPRODITEMVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uNIDADEPRODITEMVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bCICMSPRODITEMVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aLIQICMSPRODITEMVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORICMSITEMVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bCIPIPRODITEMVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aLIQIPIPRODITEMVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORIPIITEMVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nFPRODITEMVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nNFPRODITEMVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oBSITEMVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODPEDIDOITEMVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODVENDEDORITEMVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cb_vendedor = new System.Windows.Forms.CheckBox();
            this.tb_nome_vendedor = new System.Windows.Forms.TextBox();
            this.tb_cod_vendedor = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtFinal = new System.Windows.Forms.DateTimePicker();
            this.dtInicial = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_valor_total = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dsItens_ped_venda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITENS_PEDIDO_VENDA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens_ped_venda)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // datItens_ped_venda
            // 
            this.datItens_ped_venda.DeleteCommand = this.fbCommand4;
            this.datItens_ped_venda.InsertCommand = this.fbCommand2;
            this.datItens_ped_venda.SelectCommand = this.fbCommand1;
            this.datItens_ped_venda.UpdateCommand = this.fbCommand3;
            // 
            // fbCommand1
            // 
            this.fbCommand1.CommandText = "select * from itens_pedido_venda";
            this.fbCommand1.CommandTimeout = 30;
            this.fbCommand1.Connection = this.fbConnection1;
            // 
            // fbCommand2
            // 
            this.fbCommand2.CommandTimeout = 30;
            // 
            // fbCommand3
            // 
            this.fbCommand3.CommandTimeout = 30;
            // 
            // fbCommand4
            // 
            this.fbCommand4.CommandTimeout = 30;
            // 
            // fbConnection1
            // 
            this.fbConnection1.ConnectionString = resources.GetString("fbConnection1.ConnectionString");
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
            this.VALOR_ICMS_ITEM_VENDA,
            this.BC_IPI_PROD_ITEM_VENDA,
            this.ALIQ_IPI_PROD_ITEM_VENDA,
            this.VALOR_IPI_ITEM_VENDA,
            this.NF_PROD_ITEM_VENDA,
            this.N_NF_PROD_ITEM_VENDA,
            this.OBS_ITEM_VENDA,
            this.COD_PEDIDO_ITEM_VENDA,
            this.COD_VENDEDOR_ITEM_VENDA});
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
            this.QTDE_ITEM_VENDA.DataType = typeof(int);
            // 
            // COD_PROD_ITEM_VENDA
            // 
            this.COD_PROD_ITEM_VENDA.ColumnName = "COD_PROD_ITEM_VENDA";
            this.COD_PROD_ITEM_VENDA.DataType = typeof(int);
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
            // VALOR_ICMS_ITEM_VENDA
            // 
            this.VALOR_ICMS_ITEM_VENDA.ColumnName = "VALOR_ICMS_ITEM_VENDA";
            this.VALOR_ICMS_ITEM_VENDA.DataType = typeof(double);
            // 
            // BC_IPI_PROD_ITEM_VENDA
            // 
            this.BC_IPI_PROD_ITEM_VENDA.ColumnName = "BC_IPI_PROD_ITEM_VENDA";
            this.BC_IPI_PROD_ITEM_VENDA.DataType = typeof(double);
            // 
            // ALIQ_IPI_PROD_ITEM_VENDA
            // 
            this.ALIQ_IPI_PROD_ITEM_VENDA.ColumnName = "ALIQ_IPI_PROD_ITEM_VENDA";
            this.ALIQ_IPI_PROD_ITEM_VENDA.DataType = typeof(double);
            // 
            // VALOR_IPI_ITEM_VENDA
            // 
            this.VALOR_IPI_ITEM_VENDA.ColumnName = "VALOR_IPI_ITEM_VENDA";
            this.VALOR_IPI_ITEM_VENDA.DataType = typeof(double);
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
            // COD_PEDIDO_ITEM_VENDA
            // 
            this.COD_PEDIDO_ITEM_VENDA.ColumnName = "COD_PEDIDO_ITEM_VENDA";
            this.COD_PEDIDO_ITEM_VENDA.DataType = typeof(int);
            // 
            // COD_VENDEDOR_ITEM_VENDA
            // 
            this.COD_VENDEDOR_ITEM_VENDA.ColumnName = "COD_VENDEDOR_ITEM_VENDA";
            this.COD_VENDEDOR_ITEM_VENDA.DataType = typeof(int);
            // 
            // dgvItens_ped_venda
            // 
            this.dgvItens_ped_venda.AutoGenerateColumns = false;
            this.dgvItens_ped_venda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens_ped_venda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODITEMVENDADataGridViewTextBoxColumn,
            this.qTDEITEMVENDADataGridViewTextBoxColumn,
            this.cODPRODITEMVENDADataGridViewTextBoxColumn,
            this.dESCRICAOPRODITEMVENDADataGridViewTextBoxColumn,
            this.vALORUNITPRODITEMVENDADataGridViewTextBoxColumn,
            this.vALORTOTALPRODITEMVENDADataGridViewTextBoxColumn,
            this.uNIDADEPRODITEMVENDADataGridViewTextBoxColumn,
            this.bCICMSPRODITEMVENDADataGridViewTextBoxColumn,
            this.aLIQICMSPRODITEMVENDADataGridViewTextBoxColumn,
            this.vALORICMSITEMVENDADataGridViewTextBoxColumn,
            this.bCIPIPRODITEMVENDADataGridViewTextBoxColumn,
            this.aLIQIPIPRODITEMVENDADataGridViewTextBoxColumn,
            this.vALORIPIITEMVENDADataGridViewTextBoxColumn,
            this.nFPRODITEMVENDADataGridViewTextBoxColumn,
            this.nNFPRODITEMVENDADataGridViewTextBoxColumn,
            this.oBSITEMVENDADataGridViewTextBoxColumn,
            this.cODPEDIDOITEMVENDADataGridViewTextBoxColumn,
            this.cODVENDEDORITEMVENDADataGridViewTextBoxColumn});
            this.dgvItens_ped_venda.DataMember = "ITENS_PEDIDO_VENDA";
            this.dgvItens_ped_venda.DataSource = this.dsItens_ped_venda;
            this.dgvItens_ped_venda.Location = new System.Drawing.Point(12, 81);
            this.dgvItens_ped_venda.Name = "dgvItens_ped_venda";
            this.dgvItens_ped_venda.Size = new System.Drawing.Size(704, 424);
            this.dgvItens_ped_venda.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(335, 561);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Imprimir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cODITEMVENDADataGridViewTextBoxColumn
            // 
            this.cODITEMVENDADataGridViewTextBoxColumn.DataPropertyName = "COD_ITEM_VENDA";
            this.cODITEMVENDADataGridViewTextBoxColumn.HeaderText = "Cód.";
            this.cODITEMVENDADataGridViewTextBoxColumn.Name = "cODITEMVENDADataGridViewTextBoxColumn";
            this.cODITEMVENDADataGridViewTextBoxColumn.Width = 40;
            // 
            // qTDEITEMVENDADataGridViewTextBoxColumn
            // 
            this.qTDEITEMVENDADataGridViewTextBoxColumn.DataPropertyName = "QTDE_ITEM_VENDA";
            this.qTDEITEMVENDADataGridViewTextBoxColumn.HeaderText = "Qtde";
            this.qTDEITEMVENDADataGridViewTextBoxColumn.Name = "qTDEITEMVENDADataGridViewTextBoxColumn";
            this.qTDEITEMVENDADataGridViewTextBoxColumn.Width = 40;
            // 
            // cODPRODITEMVENDADataGridViewTextBoxColumn
            // 
            this.cODPRODITEMVENDADataGridViewTextBoxColumn.DataPropertyName = "COD_PROD_ITEM_VENDA";
            this.cODPRODITEMVENDADataGridViewTextBoxColumn.HeaderText = "Cód. Prod.";
            this.cODPRODITEMVENDADataGridViewTextBoxColumn.Name = "cODPRODITEMVENDADataGridViewTextBoxColumn";
            this.cODPRODITEMVENDADataGridViewTextBoxColumn.Width = 40;
            // 
            // dESCRICAOPRODITEMVENDADataGridViewTextBoxColumn
            // 
            this.dESCRICAOPRODITEMVENDADataGridViewTextBoxColumn.DataPropertyName = "DESCRICAO_PROD_ITEM_VENDA";
            this.dESCRICAOPRODITEMVENDADataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.dESCRICAOPRODITEMVENDADataGridViewTextBoxColumn.Name = "dESCRICAOPRODITEMVENDADataGridViewTextBoxColumn";
            this.dESCRICAOPRODITEMVENDADataGridViewTextBoxColumn.Width = 200;
            // 
            // vALORUNITPRODITEMVENDADataGridViewTextBoxColumn
            // 
            this.vALORUNITPRODITEMVENDADataGridViewTextBoxColumn.DataPropertyName = "VALOR_UNIT_PROD_ITEM_VENDA";
            this.vALORUNITPRODITEMVENDADataGridViewTextBoxColumn.HeaderText = "Valor Unit.";
            this.vALORUNITPRODITEMVENDADataGridViewTextBoxColumn.Name = "vALORUNITPRODITEMVENDADataGridViewTextBoxColumn";
            this.vALORUNITPRODITEMVENDADataGridViewTextBoxColumn.Width = 70;
            // 
            // vALORTOTALPRODITEMVENDADataGridViewTextBoxColumn
            // 
            this.vALORTOTALPRODITEMVENDADataGridViewTextBoxColumn.DataPropertyName = "VALOR_TOTAL_PROD_ITEM_VENDA";
            this.vALORTOTALPRODITEMVENDADataGridViewTextBoxColumn.HeaderText = "Valor Total";
            this.vALORTOTALPRODITEMVENDADataGridViewTextBoxColumn.Name = "vALORTOTALPRODITEMVENDADataGridViewTextBoxColumn";
            this.vALORTOTALPRODITEMVENDADataGridViewTextBoxColumn.Width = 70;
            // 
            // uNIDADEPRODITEMVENDADataGridViewTextBoxColumn
            // 
            this.uNIDADEPRODITEMVENDADataGridViewTextBoxColumn.DataPropertyName = "UNIDADE_PROD_ITEM_VENDA";
            this.uNIDADEPRODITEMVENDADataGridViewTextBoxColumn.HeaderText = "UNIDADE_PROD_ITEM_VENDA";
            this.uNIDADEPRODITEMVENDADataGridViewTextBoxColumn.Name = "uNIDADEPRODITEMVENDADataGridViewTextBoxColumn";
            this.uNIDADEPRODITEMVENDADataGridViewTextBoxColumn.Visible = false;
            // 
            // bCICMSPRODITEMVENDADataGridViewTextBoxColumn
            // 
            this.bCICMSPRODITEMVENDADataGridViewTextBoxColumn.DataPropertyName = "BC_ICMS_PROD_ITEM_VENDA";
            this.bCICMSPRODITEMVENDADataGridViewTextBoxColumn.HeaderText = "BC_ICMS_PROD_ITEM_VENDA";
            this.bCICMSPRODITEMVENDADataGridViewTextBoxColumn.Name = "bCICMSPRODITEMVENDADataGridViewTextBoxColumn";
            this.bCICMSPRODITEMVENDADataGridViewTextBoxColumn.Visible = false;
            // 
            // aLIQICMSPRODITEMVENDADataGridViewTextBoxColumn
            // 
            this.aLIQICMSPRODITEMVENDADataGridViewTextBoxColumn.DataPropertyName = "ALIQ_ICMS_PROD_ITEM_VENDA";
            this.aLIQICMSPRODITEMVENDADataGridViewTextBoxColumn.HeaderText = "ALIQ_ICMS_PROD_ITEM_VENDA";
            this.aLIQICMSPRODITEMVENDADataGridViewTextBoxColumn.Name = "aLIQICMSPRODITEMVENDADataGridViewTextBoxColumn";
            this.aLIQICMSPRODITEMVENDADataGridViewTextBoxColumn.Visible = false;
            // 
            // vALORICMSITEMVENDADataGridViewTextBoxColumn
            // 
            this.vALORICMSITEMVENDADataGridViewTextBoxColumn.DataPropertyName = "VALOR_ICMS_ITEM_VENDA";
            this.vALORICMSITEMVENDADataGridViewTextBoxColumn.HeaderText = "VALOR_ICMS_ITEM_VENDA";
            this.vALORICMSITEMVENDADataGridViewTextBoxColumn.Name = "vALORICMSITEMVENDADataGridViewTextBoxColumn";
            this.vALORICMSITEMVENDADataGridViewTextBoxColumn.Visible = false;
            // 
            // bCIPIPRODITEMVENDADataGridViewTextBoxColumn
            // 
            this.bCIPIPRODITEMVENDADataGridViewTextBoxColumn.DataPropertyName = "BC_IPI_PROD_ITEM_VENDA";
            this.bCIPIPRODITEMVENDADataGridViewTextBoxColumn.HeaderText = "BC_IPI_PROD_ITEM_VENDA";
            this.bCIPIPRODITEMVENDADataGridViewTextBoxColumn.Name = "bCIPIPRODITEMVENDADataGridViewTextBoxColumn";
            this.bCIPIPRODITEMVENDADataGridViewTextBoxColumn.Visible = false;
            // 
            // aLIQIPIPRODITEMVENDADataGridViewTextBoxColumn
            // 
            this.aLIQIPIPRODITEMVENDADataGridViewTextBoxColumn.DataPropertyName = "ALIQ_IPI_PROD_ITEM_VENDA";
            this.aLIQIPIPRODITEMVENDADataGridViewTextBoxColumn.HeaderText = "ALIQ_IPI_PROD_ITEM_VENDA";
            this.aLIQIPIPRODITEMVENDADataGridViewTextBoxColumn.Name = "aLIQIPIPRODITEMVENDADataGridViewTextBoxColumn";
            this.aLIQIPIPRODITEMVENDADataGridViewTextBoxColumn.Visible = false;
            // 
            // vALORIPIITEMVENDADataGridViewTextBoxColumn
            // 
            this.vALORIPIITEMVENDADataGridViewTextBoxColumn.DataPropertyName = "VALOR_IPI_ITEM_VENDA";
            this.vALORIPIITEMVENDADataGridViewTextBoxColumn.HeaderText = "VALOR_IPI_ITEM_VENDA";
            this.vALORIPIITEMVENDADataGridViewTextBoxColumn.Name = "vALORIPIITEMVENDADataGridViewTextBoxColumn";
            this.vALORIPIITEMVENDADataGridViewTextBoxColumn.Visible = false;
            // 
            // nFPRODITEMVENDADataGridViewTextBoxColumn
            // 
            this.nFPRODITEMVENDADataGridViewTextBoxColumn.DataPropertyName = "NF_PROD_ITEM_VENDA";
            this.nFPRODITEMVENDADataGridViewTextBoxColumn.HeaderText = "NF_PROD_ITEM_VENDA";
            this.nFPRODITEMVENDADataGridViewTextBoxColumn.Name = "nFPRODITEMVENDADataGridViewTextBoxColumn";
            this.nFPRODITEMVENDADataGridViewTextBoxColumn.Visible = false;
            // 
            // nNFPRODITEMVENDADataGridViewTextBoxColumn
            // 
            this.nNFPRODITEMVENDADataGridViewTextBoxColumn.DataPropertyName = "N_NF_PROD_ITEM_VENDA";
            this.nNFPRODITEMVENDADataGridViewTextBoxColumn.HeaderText = "N_NF_PROD_ITEM_VENDA";
            this.nNFPRODITEMVENDADataGridViewTextBoxColumn.Name = "nNFPRODITEMVENDADataGridViewTextBoxColumn";
            this.nNFPRODITEMVENDADataGridViewTextBoxColumn.Visible = false;
            // 
            // oBSITEMVENDADataGridViewTextBoxColumn
            // 
            this.oBSITEMVENDADataGridViewTextBoxColumn.DataPropertyName = "OBS_ITEM_VENDA";
            this.oBSITEMVENDADataGridViewTextBoxColumn.HeaderText = "OBS_ITEM_VENDA";
            this.oBSITEMVENDADataGridViewTextBoxColumn.Name = "oBSITEMVENDADataGridViewTextBoxColumn";
            this.oBSITEMVENDADataGridViewTextBoxColumn.Visible = false;
            // 
            // cODPEDIDOITEMVENDADataGridViewTextBoxColumn
            // 
            this.cODPEDIDOITEMVENDADataGridViewTextBoxColumn.DataPropertyName = "COD_PEDIDO_ITEM_VENDA";
            this.cODPEDIDOITEMVENDADataGridViewTextBoxColumn.HeaderText = "Pedido";
            this.cODPEDIDOITEMVENDADataGridViewTextBoxColumn.Name = "cODPEDIDOITEMVENDADataGridViewTextBoxColumn";
            this.cODPEDIDOITEMVENDADataGridViewTextBoxColumn.Width = 80;
            // 
            // cODVENDEDORITEMVENDADataGridViewTextBoxColumn
            // 
            this.cODVENDEDORITEMVENDADataGridViewTextBoxColumn.DataPropertyName = "COD_VENDEDOR_ITEM_VENDA";
            this.cODVENDEDORITEMVENDADataGridViewTextBoxColumn.HeaderText = "Cod. Vendedor";
            this.cODVENDEDORITEMVENDADataGridViewTextBoxColumn.Name = "cODVENDEDORITEMVENDADataGridViewTextBoxColumn";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cb_vendedor);
            this.groupBox3.Controls.Add(this.tb_nome_vendedor);
            this.groupBox3.Controls.Add(this.tb_cod_vendedor);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Location = new System.Drawing.Point(130, -1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(253, 39);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Vendedor";
            // 
            // cb_vendedor
            // 
            this.cb_vendedor.AutoSize = true;
            this.cb_vendedor.Location = new System.Drawing.Point(232, 16);
            this.cb_vendedor.Name = "cb_vendedor";
            this.cb_vendedor.Size = new System.Drawing.Size(15, 14);
            this.cb_vendedor.TabIndex = 282;
            this.cb_vendedor.UseVisualStyleBackColor = true;
            // 
            // tb_nome_vendedor
            // 
            this.tb_nome_vendedor.Location = new System.Drawing.Point(59, 13);
            this.tb_nome_vendedor.Name = "tb_nome_vendedor";
            this.tb_nome_vendedor.Size = new System.Drawing.Size(121, 20);
            this.tb_nome_vendedor.TabIndex = 281;
            // 
            // tb_cod_vendedor
            // 
            this.tb_cod_vendedor.Location = new System.Drawing.Point(12, 13);
            this.tb_cod_vendedor.Name = "tb_cod_vendedor";
            this.tb_cod_vendedor.Size = new System.Drawing.Size(41, 20);
            this.tb_cod_vendedor.TabIndex = 280;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(186, 11);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(23, 23);
            this.button4.TabIndex = 279;
            this.button4.Text = "+";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(518, -1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 76);
            this.button2.TabIndex = 27;
            this.button2.Text = "Ok";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtFinal);
            this.groupBox2.Controls.Add(this.dtInicial);
            this.groupBox2.Location = new System.Drawing.Point(12, -1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(112, 76);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Entre Datas";
            // 
            // dtFinal
            // 
            this.dtFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFinal.Location = new System.Drawing.Point(6, 45);
            this.dtFinal.Name = "dtFinal";
            this.dtFinal.Size = new System.Drawing.Size(97, 20);
            this.dtFinal.TabIndex = 13;
            // 
            // dtInicial
            // 
            this.dtInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicial.Location = new System.Drawing.Point(6, 19);
            this.dtInicial.Name = "dtInicial";
            this.dtInicial.Size = new System.Drawing.Size(97, 20);
            this.dtInicial.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, 519);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 26);
            this.label1.TabIndex = 30;
            this.label1.Text = "Valor Total";
            // 
            // tb_valor_total
            // 
            this.tb_valor_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_valor_total.Location = new System.Drawing.Point(416, 516);
            this.tb_valor_total.Name = "tb_valor_total";
            this.tb_valor_total.Size = new System.Drawing.Size(166, 31);
            this.tb_valor_total.TabIndex = 29;
            // 
            // form_fatura_produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 596);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_valor_total);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvItens_ped_venda);
            this.Name = "form_fatura_produto";
            this.Text = "Fatura Produto";
            this.Load += new System.EventHandler(this.form_fatura_produto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsItens_ped_venda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITENS_PEDIDO_VENDA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens_ped_venda)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datItens_ped_venda;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
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
        private System.Data.DataColumn VALOR_ICMS_ITEM_VENDA;
        private System.Data.DataColumn BC_IPI_PROD_ITEM_VENDA;
        private System.Data.DataColumn ALIQ_IPI_PROD_ITEM_VENDA;
        private System.Data.DataColumn VALOR_IPI_ITEM_VENDA;
        private System.Data.DataColumn NF_PROD_ITEM_VENDA;
        private System.Data.DataColumn N_NF_PROD_ITEM_VENDA;
        private System.Data.DataColumn OBS_ITEM_VENDA;
        private System.Data.DataColumn COD_PEDIDO_ITEM_VENDA;
        private System.Data.DataColumn COD_VENDEDOR_ITEM_VENDA;
        private System.Windows.Forms.DataGridView dgvItens_ped_venda;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODITEMVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qTDEITEMVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODPRODITEMVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRICAOPRODITEMVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORUNITPRODITEMVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORTOTALPRODITEMVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uNIDADEPRODITEMVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bCICMSPRODITEMVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aLIQICMSPRODITEMVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORICMSITEMVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bCIPIPRODITEMVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aLIQIPIPRODITEMVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORIPIITEMVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nFPRODITEMVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nNFPRODITEMVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oBSITEMVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODPEDIDOITEMVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODVENDEDORITEMVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cb_vendedor;
        private System.Windows.Forms.TextBox tb_nome_vendedor;
        private System.Windows.Forms.TextBox tb_cod_vendedor;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtFinal;
        private System.Windows.Forms.DateTimePicker dtInicial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_valor_total;
    }
}