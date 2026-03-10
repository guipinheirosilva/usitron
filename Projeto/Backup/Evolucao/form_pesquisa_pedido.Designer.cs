namespace Evolucao
{
    partial class form_pesquisa_pedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_pesquisa_pedido));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtFinal = new System.Windows.Forms.DateTimePicker();
            this.dtInicial = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.datPedidos_venda = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsPedidos_venda = new System.Data.DataSet();
            this.PEDIDOS_VENDA = new System.Data.DataTable();
            this.COD_PED_VENDA = new System.Data.DataColumn();
            this.DATA_PED_VENDA = new System.Data.DataColumn();
            this.DATA_BAIXA_PED_VENDA = new System.Data.DataColumn();
            this.CLIENTE_PED_VENDA = new System.Data.DataColumn();
            this.CNPJ_PED_VENDA = new System.Data.DataColumn();
            this.COND_PGTO_PED_VENDA = new System.Data.DataColumn();
            this.VALOR_TOTAL_PROD_PED_VENDA = new System.Data.DataColumn();
            this.VALOR_TOTAL_PED_VENDA = new System.Data.DataColumn();
            this.VALOR_TOTAL_ICMS_PED_VENDA = new System.Data.DataColumn();
            this.VALOR_TOTAL_IPI_PED_VENDA = new System.Data.DataColumn();
            this.VALOR_DESCONTO_PED_VENDA = new System.Data.DataColumn();
            this.OBS_PED_VENDA = new System.Data.DataColumn();
            this.NF_PED_VENDA = new System.Data.DataColumn();
            this.BAIXADO_ESTOQUE_PED_VENDA = new System.Data.DataColumn();
            this.PAGO_PED_VENDA = new System.Data.DataColumn();
            this.COD_CAIXA_PGTO_PED_VENDA = new System.Data.DataColumn();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.col_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAPEDVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATABAIXAPEDVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTEPEDVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNPJPEDVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONDPGTOPEDVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORTOTALPRODPEDVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_valor_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VENDEDOR_PED_VENDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORTOTALICMSPEDVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORTOTALIPIPEDVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORDESCONTOPEDVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oBSPEDVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nFPEDVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bAIXADOESTOQUEPEDVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAGOPEDVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODCAIXAPGTOPEDVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COD_VENDEDOR_PED_VENDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_cliente = new System.Windows.Forms.TextBox();
            this.tb_vendedor = new System.Windows.Forms.TextBox();
            this.tb_valor_total = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.comando_select = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cb_vendedor = new System.Windows.Forms.CheckBox();
            this.tb_nome_vendedor = new System.Windows.Forms.TextBox();
            this.tb_cod_vendedor = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_cliente = new System.Windows.Forms.CheckBox();
            this.tb_nome_cliente = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodPedido = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsPedidos_venda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PEDIDOS_VENDA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtFinal);
            this.groupBox2.Controls.Add(this.dtInicial);
            this.groupBox2.Location = new System.Drawing.Point(22, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(112, 79);
            this.groupBox2.TabIndex = 15;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(413, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 76);
            this.button1.TabIndex = 17;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // datPedidos_venda
            // 
            this.datPedidos_venda.DeleteCommand = this.fbCommand4;
            this.datPedidos_venda.InsertCommand = this.fbCommand2;
            this.datPedidos_venda.SelectCommand = this.fbCommand1;
            this.datPedidos_venda.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * from pedidos_venda order by cod_ped_venda desc";
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
            this.VALOR_TOTAL_PROD_PED_VENDA,
            this.VALOR_TOTAL_PED_VENDA,
            this.VALOR_TOTAL_ICMS_PED_VENDA,
            this.VALOR_TOTAL_IPI_PED_VENDA,
            this.VALOR_DESCONTO_PED_VENDA,
            this.OBS_PED_VENDA,
            this.NF_PED_VENDA,
            this.BAIXADO_ESTOQUE_PED_VENDA,
            this.PAGO_PED_VENDA,
            this.COD_CAIXA_PGTO_PED_VENDA,
            this.dataColumn1,
            this.dataColumn2});
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
            // VALOR_TOTAL_PROD_PED_VENDA
            // 
            this.VALOR_TOTAL_PROD_PED_VENDA.ColumnName = "VALOR_TOTAL_PROD_PED_VENDA";
            this.VALOR_TOTAL_PROD_PED_VENDA.DataType = typeof(double);
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
            // BAIXADO_ESTOQUE_PED_VENDA
            // 
            this.BAIXADO_ESTOQUE_PED_VENDA.ColumnName = "BAIXADO_ESTOQUE_PED_VENDA";
            this.BAIXADO_ESTOQUE_PED_VENDA.DataType = typeof(int);
            // 
            // PAGO_PED_VENDA
            // 
            this.PAGO_PED_VENDA.ColumnName = "PAGO_PED_VENDA";
            this.PAGO_PED_VENDA.DataType = typeof(int);
            // 
            // COD_CAIXA_PGTO_PED_VENDA
            // 
            this.COD_CAIXA_PGTO_PED_VENDA.ColumnName = "COD_CAIXA_PGTO_PED_VENDA";
            this.COD_CAIXA_PGTO_PED_VENDA.DataType = typeof(int);
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "VENDEDOR_PED_VENDA";
            this.dataColumn1.MaxLength = 100;
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "COD_VENDEDOR_PED_VENDA";
            this.dataColumn2.DataType = typeof(int);
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AutoGenerateColumns = false;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_cod,
            this.dATAPEDVENDADataGridViewTextBoxColumn,
            this.dATABAIXAPEDVENDADataGridViewTextBoxColumn,
            this.cLIENTEPEDVENDADataGridViewTextBoxColumn,
            this.cNPJPEDVENDADataGridViewTextBoxColumn,
            this.cONDPGTOPEDVENDADataGridViewTextBoxColumn,
            this.vALORTOTALPRODPEDVENDADataGridViewTextBoxColumn,
            this.col_valor_total,
            this.VENDEDOR_PED_VENDA,
            this.vALORTOTALICMSPEDVENDADataGridViewTextBoxColumn,
            this.vALORTOTALIPIPEDVENDADataGridViewTextBoxColumn,
            this.vALORDESCONTOPEDVENDADataGridViewTextBoxColumn,
            this.oBSPEDVENDADataGridViewTextBoxColumn,
            this.nFPEDVENDADataGridViewTextBoxColumn,
            this.bAIXADOESTOQUEPEDVENDADataGridViewTextBoxColumn,
            this.pAGOPEDVENDADataGridViewTextBoxColumn,
            this.cODCAIXAPGTOPEDVENDADataGridViewTextBoxColumn,
            this.COD_VENDEDOR_PED_VENDA});
            this.dgvPedidos.DataMember = "PEDIDOS_VENDA";
            this.dgvPedidos.DataSource = this.dsPedidos_venda;
            this.dgvPedidos.Location = new System.Drawing.Point(22, 147);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.Size = new System.Drawing.Size(881, 415);
            this.dgvPedidos.TabIndex = 18;
            this.dgvPedidos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedidos_CellDoubleClick);
            this.dgvPedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedidos_CellContentClick);
            // 
            // col_cod
            // 
            this.col_cod.DataPropertyName = "COD_PED_VENDA";
            this.col_cod.HeaderText = "Cód.";
            this.col_cod.Name = "col_cod";
            this.col_cod.Width = 40;
            // 
            // dATAPEDVENDADataGridViewTextBoxColumn
            // 
            this.dATAPEDVENDADataGridViewTextBoxColumn.DataPropertyName = "DATA_PED_VENDA";
            this.dATAPEDVENDADataGridViewTextBoxColumn.HeaderText = "Data Pedido";
            this.dATAPEDVENDADataGridViewTextBoxColumn.Name = "dATAPEDVENDADataGridViewTextBoxColumn";
            this.dATAPEDVENDADataGridViewTextBoxColumn.Width = 70;
            // 
            // dATABAIXAPEDVENDADataGridViewTextBoxColumn
            // 
            this.dATABAIXAPEDVENDADataGridViewTextBoxColumn.DataPropertyName = "DATA_BAIXA_PED_VENDA";
            this.dATABAIXAPEDVENDADataGridViewTextBoxColumn.HeaderText = "Data Baixa";
            this.dATABAIXAPEDVENDADataGridViewTextBoxColumn.Name = "dATABAIXAPEDVENDADataGridViewTextBoxColumn";
            this.dATABAIXAPEDVENDADataGridViewTextBoxColumn.Width = 70;
            // 
            // cLIENTEPEDVENDADataGridViewTextBoxColumn
            // 
            this.cLIENTEPEDVENDADataGridViewTextBoxColumn.DataPropertyName = "CLIENTE_PED_VENDA";
            this.cLIENTEPEDVENDADataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.cLIENTEPEDVENDADataGridViewTextBoxColumn.Name = "cLIENTEPEDVENDADataGridViewTextBoxColumn";
            this.cLIENTEPEDVENDADataGridViewTextBoxColumn.Width = 150;
            // 
            // cNPJPEDVENDADataGridViewTextBoxColumn
            // 
            this.cNPJPEDVENDADataGridViewTextBoxColumn.DataPropertyName = "CNPJ_PED_VENDA";
            this.cNPJPEDVENDADataGridViewTextBoxColumn.HeaderText = "CNPJ";
            this.cNPJPEDVENDADataGridViewTextBoxColumn.Name = "cNPJPEDVENDADataGridViewTextBoxColumn";
            this.cNPJPEDVENDADataGridViewTextBoxColumn.Width = 50;
            // 
            // cONDPGTOPEDVENDADataGridViewTextBoxColumn
            // 
            this.cONDPGTOPEDVENDADataGridViewTextBoxColumn.DataPropertyName = "COND_PGTO_PED_VENDA";
            this.cONDPGTOPEDVENDADataGridViewTextBoxColumn.HeaderText = "Cond. Pgto";
            this.cONDPGTOPEDVENDADataGridViewTextBoxColumn.Name = "cONDPGTOPEDVENDADataGridViewTextBoxColumn";
            this.cONDPGTOPEDVENDADataGridViewTextBoxColumn.Width = 60;
            // 
            // vALORTOTALPRODPEDVENDADataGridViewTextBoxColumn
            // 
            this.vALORTOTALPRODPEDVENDADataGridViewTextBoxColumn.DataPropertyName = "VALOR_TOTAL_PROD_PED_VENDA";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.vALORTOTALPRODPEDVENDADataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.vALORTOTALPRODPEDVENDADataGridViewTextBoxColumn.HeaderText = "Valor Produtos";
            this.vALORTOTALPRODPEDVENDADataGridViewTextBoxColumn.Name = "vALORTOTALPRODPEDVENDADataGridViewTextBoxColumn";
            this.vALORTOTALPRODPEDVENDADataGridViewTextBoxColumn.Width = 70;
            // 
            // col_valor_total
            // 
            this.col_valor_total.DataPropertyName = "VALOR_TOTAL_PED_VENDA";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.col_valor_total.DefaultCellStyle = dataGridViewCellStyle2;
            this.col_valor_total.HeaderText = "Valor Total";
            this.col_valor_total.Name = "col_valor_total";
            this.col_valor_total.Width = 70;
            // 
            // VENDEDOR_PED_VENDA
            // 
            this.VENDEDOR_PED_VENDA.DataPropertyName = "VENDEDOR_PED_VENDA";
            this.VENDEDOR_PED_VENDA.HeaderText = "Vendedor";
            this.VENDEDOR_PED_VENDA.Name = "VENDEDOR_PED_VENDA";
            // 
            // vALORTOTALICMSPEDVENDADataGridViewTextBoxColumn
            // 
            this.vALORTOTALICMSPEDVENDADataGridViewTextBoxColumn.DataPropertyName = "VALOR_TOTAL_ICMS_PED_VENDA";
            this.vALORTOTALICMSPEDVENDADataGridViewTextBoxColumn.HeaderText = "ICMS";
            this.vALORTOTALICMSPEDVENDADataGridViewTextBoxColumn.Name = "vALORTOTALICMSPEDVENDADataGridViewTextBoxColumn";
            this.vALORTOTALICMSPEDVENDADataGridViewTextBoxColumn.Width = 45;
            // 
            // vALORTOTALIPIPEDVENDADataGridViewTextBoxColumn
            // 
            this.vALORTOTALIPIPEDVENDADataGridViewTextBoxColumn.DataPropertyName = "VALOR_TOTAL_IPI_PED_VENDA";
            this.vALORTOTALIPIPEDVENDADataGridViewTextBoxColumn.HeaderText = "IPI";
            this.vALORTOTALIPIPEDVENDADataGridViewTextBoxColumn.Name = "vALORTOTALIPIPEDVENDADataGridViewTextBoxColumn";
            this.vALORTOTALIPIPEDVENDADataGridViewTextBoxColumn.Width = 45;
            // 
            // vALORDESCONTOPEDVENDADataGridViewTextBoxColumn
            // 
            this.vALORDESCONTOPEDVENDADataGridViewTextBoxColumn.DataPropertyName = "VALOR_DESCONTO_PED_VENDA";
            this.vALORDESCONTOPEDVENDADataGridViewTextBoxColumn.HeaderText = "Desconto";
            this.vALORDESCONTOPEDVENDADataGridViewTextBoxColumn.Name = "vALORDESCONTOPEDVENDADataGridViewTextBoxColumn";
            this.vALORDESCONTOPEDVENDADataGridViewTextBoxColumn.Width = 60;
            // 
            // oBSPEDVENDADataGridViewTextBoxColumn
            // 
            this.oBSPEDVENDADataGridViewTextBoxColumn.DataPropertyName = "OBS_PED_VENDA";
            this.oBSPEDVENDADataGridViewTextBoxColumn.HeaderText = "Obs";
            this.oBSPEDVENDADataGridViewTextBoxColumn.Name = "oBSPEDVENDADataGridViewTextBoxColumn";
            // 
            // nFPEDVENDADataGridViewTextBoxColumn
            // 
            this.nFPEDVENDADataGridViewTextBoxColumn.DataPropertyName = "NF_PED_VENDA";
            this.nFPEDVENDADataGridViewTextBoxColumn.HeaderText = "NF?";
            this.nFPEDVENDADataGridViewTextBoxColumn.Name = "nFPEDVENDADataGridViewTextBoxColumn";
            // 
            // bAIXADOESTOQUEPEDVENDADataGridViewTextBoxColumn
            // 
            this.bAIXADOESTOQUEPEDVENDADataGridViewTextBoxColumn.DataPropertyName = "BAIXADO_ESTOQUE_PED_VENDA";
            this.bAIXADOESTOQUEPEDVENDADataGridViewTextBoxColumn.HeaderText = "Baixado";
            this.bAIXADOESTOQUEPEDVENDADataGridViewTextBoxColumn.Name = "bAIXADOESTOQUEPEDVENDADataGridViewTextBoxColumn";
            // 
            // pAGOPEDVENDADataGridViewTextBoxColumn
            // 
            this.pAGOPEDVENDADataGridViewTextBoxColumn.DataPropertyName = "PAGO_PED_VENDA";
            this.pAGOPEDVENDADataGridViewTextBoxColumn.HeaderText = "Pago?";
            this.pAGOPEDVENDADataGridViewTextBoxColumn.Name = "pAGOPEDVENDADataGridViewTextBoxColumn";
            // 
            // cODCAIXAPGTOPEDVENDADataGridViewTextBoxColumn
            // 
            this.cODCAIXAPGTOPEDVENDADataGridViewTextBoxColumn.DataPropertyName = "COD_CAIXA_PGTO_PED_VENDA";
            this.cODCAIXAPGTOPEDVENDADataGridViewTextBoxColumn.HeaderText = "Cod Caixa";
            this.cODCAIXAPGTOPEDVENDADataGridViewTextBoxColumn.Name = "cODCAIXAPGTOPEDVENDADataGridViewTextBoxColumn";
            // 
            // COD_VENDEDOR_PED_VENDA
            // 
            this.COD_VENDEDOR_PED_VENDA.DataPropertyName = "COD_VENDEDOR_PED_VENDA";
            this.COD_VENDEDOR_PED_VENDA.HeaderText = "Cód. Vendedor";
            this.COD_VENDEDOR_PED_VENDA.Name = "COD_VENDEDOR_PED_VENDA";
            this.COD_VENDEDOR_PED_VENDA.Width = 30;
            // 
            // tb_cliente
            // 
            this.tb_cliente.Location = new System.Drawing.Point(128, 121);
            this.tb_cliente.Name = "tb_cliente";
            this.tb_cliente.Size = new System.Drawing.Size(150, 20);
            this.tb_cliente.TabIndex = 19;
            this.tb_cliente.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tb_vendedor
            // 
            this.tb_vendedor.Location = new System.Drawing.Point(284, 121);
            this.tb_vendedor.Name = "tb_vendedor";
            this.tb_vendedor.Size = new System.Drawing.Size(103, 20);
            this.tb_vendedor.TabIndex = 20;
            this.tb_vendedor.TextChanged += new System.EventHandler(this.tb_vendedor_TextChanged);
            // 
            // tb_valor_total
            // 
            this.tb_valor_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_valor_total.Location = new System.Drawing.Point(548, 582);
            this.tb_valor_total.Name = "tb_valor_total";
            this.tb_valor_total.Size = new System.Drawing.Size(166, 31);
            this.tb_valor_total.TabIndex = 21;
            this.tb_valor_total.TextChanged += new System.EventHandler(this.tb_valor_total_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(426, 585);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 26);
            this.label1.TabIndex = 22;
            this.label1.Text = "Valor Total";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(508, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 76);
            this.button2.TabIndex = 23;
            this.button2.Text = "Confirmar\r\nSeleção";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comando_select
            // 
            this.comando_select.CommandTimeout = 30;
            this.comando_select.Connection = this.fbConnection1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cb_vendedor);
            this.groupBox3.Controls.Add(this.tb_nome_vendedor);
            this.groupBox3.Controls.Add(this.tb_cod_vendedor);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Location = new System.Drawing.Point(140, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(253, 39);
            this.groupBox3.TabIndex = 25;
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
            this.cb_vendedor.CheckedChanged += new System.EventHandler(this.cb_vendedor_CheckedChanged);
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
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(603, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 76);
            this.button3.TabIndex = 26;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_cliente);
            this.groupBox1.Controls.Add(this.tb_nome_cliente);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Location = new System.Drawing.Point(140, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 39);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clientes";
            // 
            // cb_cliente
            // 
            this.cb_cliente.AutoSize = true;
            this.cb_cliente.Location = new System.Drawing.Point(232, 16);
            this.cb_cliente.Name = "cb_cliente";
            this.cb_cliente.Size = new System.Drawing.Size(15, 14);
            this.cb_cliente.TabIndex = 282;
            this.cb_cliente.UseVisualStyleBackColor = true;
            // 
            // tb_nome_cliente
            // 
            this.tb_nome_cliente.Location = new System.Drawing.Point(12, 13);
            this.tb_nome_cliente.Name = "tb_nome_cliente";
            this.tb_nome_cliente.Size = new System.Drawing.Size(168, 20);
            this.tb_nome_cliente.TabIndex = 281;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(186, 11);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(23, 23);
            this.button5.TabIndex = 279;
            this.button5.Text = "+";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Vendedor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Cod. Pedido:";
            // 
            // txtCodPedido
            // 
            this.txtCodPedido.Location = new System.Drawing.Point(22, 121);
            this.txtCodPedido.Name = "txtCodPedido";
            this.txtCodPedido.Size = new System.Drawing.Size(100, 20);
            this.txtCodPedido.TabIndex = 31;
            this.txtCodPedido.TextChanged += new System.EventHandler(this.txtCodPedido_TextChanged);
            // 
            // form_pesquisa_pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 646);
            this.Controls.Add(this.txtCodPedido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_valor_total);
            this.Controls.Add(this.tb_vendedor);
            this.Controls.Add(this.tb_cliente);
            this.Controls.Add(this.dgvPedidos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Name = "form_pesquisa_pedido";
            this.Text = "Pesquisa Pedido";
            this.Load += new System.EventHandler(this.form_pesquisa_pedido_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsPedidos_venda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PEDIDOS_VENDA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtFinal;
        private System.Windows.Forms.DateTimePicker dtInicial;
        private System.Windows.Forms.Button button1;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datPedidos_venda;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private System.Data.DataSet dsPedidos_venda;
        private System.Data.DataTable PEDIDOS_VENDA;
        private System.Data.DataColumn COD_PED_VENDA;
        private System.Data.DataColumn DATA_PED_VENDA;
        private System.Data.DataColumn DATA_BAIXA_PED_VENDA;
        private System.Data.DataColumn CLIENTE_PED_VENDA;
        private System.Data.DataColumn CNPJ_PED_VENDA;
        private System.Data.DataColumn COND_PGTO_PED_VENDA;
        private System.Data.DataColumn VALOR_TOTAL_PROD_PED_VENDA;
        private System.Data.DataColumn VALOR_TOTAL_PED_VENDA;
        private System.Data.DataColumn VALOR_TOTAL_ICMS_PED_VENDA;
        private System.Data.DataColumn VALOR_TOTAL_IPI_PED_VENDA;
        private System.Data.DataColumn VALOR_DESCONTO_PED_VENDA;
        private System.Data.DataColumn OBS_PED_VENDA;
        private System.Data.DataColumn NF_PED_VENDA;
        private System.Data.DataColumn BAIXADO_ESTOQUE_PED_VENDA;
        private System.Data.DataColumn PAGO_PED_VENDA;
        private System.Data.DataColumn COD_CAIXA_PGTO_PED_VENDA;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.TextBox tb_cliente;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Windows.Forms.TextBox tb_vendedor;
        private System.Windows.Forms.TextBox tb_valor_total;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAPEDVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATABAIXAPEDVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTEPEDVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPJPEDVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONDPGTOPEDVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORTOTALPRODPEDVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_valor_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn VENDEDOR_PED_VENDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORTOTALICMSPEDVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORTOTALIPIPEDVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORDESCONTOPEDVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oBSPEDVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nFPEDVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bAIXADOESTOQUEPEDVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAGOPEDVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODCAIXAPGTOPEDVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_VENDEDOR_PED_VENDA;
        private FirebirdSql.Data.FirebirdClient.FbCommand comando_select;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tb_nome_vendedor;
        private System.Windows.Forms.TextBox tb_cod_vendedor;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox cb_vendedor;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cb_cliente;
        private System.Windows.Forms.TextBox tb_nome_cliente;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodPedido;
    }
}