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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbData_entrega = new System.Windows.Forms.CheckBox();
            this.cb_data_prevista = new System.Windows.Forms.CheckBox();
            this.cbData = new System.Windows.Forms.CheckBox();
            this.cbSem_vendedor = new System.Windows.Forms.CheckBox();
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
            this.dataColumn14 = new System.Data.DataColumn();
            this.dataColumn15 = new System.Data.DataColumn();
            this.dataColumn16 = new System.Data.DataColumn();
            this.dataColumn17 = new System.Data.DataColumn();
            this.dataColumn18 = new System.Data.DataColumn();
            this.dataColumn19 = new System.Data.DataColumn();
            this.dataColumn20 = new System.Data.DataColumn();
            this.dataColumn21 = new System.Data.DataColumn();
            this.dataColumn22 = new System.Data.DataColumn();
            this.dataColumn23 = new System.Data.DataColumn();
            this.dataColumn24 = new System.Data.DataColumn();
            this.dataColumn25 = new System.Data.DataColumn();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.col_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N_PED_VENDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_pai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA_EXPORTACAO_PED_VENDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HORA_EXPORTACAO_PED_VENDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAPEDVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_FANTASIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS_PED_VENDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO_PED_VENDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNPJPEDVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BAIRRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COD_ROTEIRO_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_valor_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORTOTALPRODPEDVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTDE_TOTAL_PED_VENDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VENDEDOR_PED_VENDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONDPGTOPEDVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA_ENTREGA_PED_VENDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNPJ_EMISSOR_PED_VENDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RAZAO_EMISSOR_PED_VENDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORTOTALICMSPEDVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATABAIXAPEDVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N_NF_PED_VENDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA_NF_PED_VENDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTEPEDVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEP_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORDESCONTOPEDVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPedidoCel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORTOTALIPIPEDVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oBSPEDVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAGOPEDVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODCAIXAPGTOPEDVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COD_VENDEDOR_PED_VENDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_cliente = new System.Windows.Forms.TextBox();
            this.tb_vendedor = new System.Windows.Forms.TextBox();
            this.tb_valor_total = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comando_select = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCodPedido = new System.Windows.Forms.Label();
            this.txtCodPedido = new System.Windows.Forms.TextBox();
            this.txtCnpj = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnConfirmarPedido = new System.Windows.Forms.Button();
            this.cbFechados = new System.Windows.Forms.CheckBox();
            this.cb_Nao_fechados = new System.Windows.Forms.CheckBox();
            this.cbNao_faturados = new System.Windows.Forms.CheckBox();
            this.cbFaturados = new System.Windows.Forms.CheckBox();
            this.labelQTdeOrcamentos = new System.Windows.Forms.Label();
            this.tb_qtde_pedidos = new System.Windows.Forms.TextBox();
            this.cbBonificacao = new System.Windows.Forms.CheckBox();
            this.cbTroca = new System.Windows.Forms.CheckBox();
            this.cbVenda = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_valor = new System.Windows.Forms.TextBox();
            this.tb_n_pedido = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_roteiro = new System.Windows.Forms.TextBox();
            this.tb_nome_fantasia = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbBombas = new System.Windows.Forms.CheckBox();
            this.cbIndustrializacao = new System.Windows.Forms.CheckBox();
            this.cbDegustacao = new System.Windows.Forms.CheckBox();
            this.cbPv = new System.Windows.Forms.CheckBox();
            this.cbDevolucao = new System.Windows.Forms.CheckBox();
            this.cbApenas_orcamentos = new System.Windows.Forms.CheckBox();
            this.cbCancelados = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_pedido_cliente = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_op_cliente = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_produto = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.cbConfirmados_aguardando = new System.Windows.Forms.CheckBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsPedidos_venda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PEDIDOS_VENDA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbData_entrega);
            this.groupBox2.Controls.Add(this.cb_data_prevista);
            this.groupBox2.Controls.Add(this.cbData);
            this.groupBox2.Controls.Add(this.cbSem_vendedor);
            this.groupBox2.Controls.Add(this.dtFinal);
            this.groupBox2.Controls.Add(this.dtInicial);
            this.groupBox2.Location = new System.Drawing.Point(22, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 114);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Entre Datas";
            // 
            // cbData_entrega
            // 
            this.cbData_entrega.AllowDrop = true;
            this.cbData_entrega.AutoSize = true;
            this.cbData_entrega.Location = new System.Drawing.Point(111, 94);
            this.cbData_entrega.Name = "cbData_entrega";
            this.cbData_entrega.Size = new System.Drawing.Size(111, 17);
            this.cbData_entrega.TabIndex = 54;
            this.cbData_entrega.Text = "Data Confirmação";
            this.cbData_entrega.UseVisualStyleBackColor = true;
            // 
            // cb_data_prevista
            // 
            this.cb_data_prevista.AllowDrop = true;
            this.cb_data_prevista.AutoSize = true;
            this.cb_data_prevista.Location = new System.Drawing.Point(7, 94);
            this.cb_data_prevista.Name = "cb_data_prevista";
            this.cb_data_prevista.Size = new System.Drawing.Size(79, 17);
            this.cb_data_prevista.TabIndex = 15;
            this.cb_data_prevista.Text = "Data Limite";
            this.cb_data_prevista.UseVisualStyleBackColor = true;
            // 
            // cbData
            // 
            this.cbData.AllowDrop = true;
            this.cbData.AutoSize = true;
            this.cbData.Location = new System.Drawing.Point(7, 71);
            this.cbData.Name = "cbData";
            this.cbData.Size = new System.Drawing.Size(85, 17);
            this.cbData.TabIndex = 14;
            this.cbData.Text = "Data Pedido";
            this.cbData.UseVisualStyleBackColor = true;
            // 
            // cbSem_vendedor
            // 
            this.cbSem_vendedor.AutoSize = true;
            this.cbSem_vendedor.Location = new System.Drawing.Point(111, 71);
            this.cbSem_vendedor.Name = "cbSem_vendedor";
            this.cbSem_vendedor.Size = new System.Drawing.Size(94, 17);
            this.cbSem_vendedor.TabIndex = 53;
            this.cbSem_vendedor.Text = "Mostrar Todos";
            this.cbSem_vendedor.UseVisualStyleBackColor = true;
            // 
            // dtFinal
            // 
            this.dtFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFinal.Location = new System.Drawing.Point(6, 45);
            this.dtFinal.Name = "dtFinal";
            this.dtFinal.Size = new System.Drawing.Size(194, 20);
            this.dtFinal.TabIndex = 13;
            // 
            // dtInicial
            // 
            this.dtInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicial.Location = new System.Drawing.Point(6, 19);
            this.dtInicial.Name = "dtInicial";
            this.dtInicial.Size = new System.Drawing.Size(194, 20);
            this.dtInicial.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(255, 15);
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
            this.fbCommand1.CommandText = resources.GetString("fbCommand1.CommandText");
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
            this.dataColumn14,
            this.dataColumn15,
            this.dataColumn16,
            this.dataColumn17,
            this.dataColumn18,
            this.dataColumn19,
            this.dataColumn20,
            this.dataColumn21,
            this.dataColumn22,
            this.dataColumn23,
            this.dataColumn24,
            this.dataColumn25});
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
            this.OBS_PED_VENDA.MaxLength = 5000;
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
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "N_NF_PED_VENDA";
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "CANCELADO_PED_VENDA";
            this.dataColumn4.DataType = typeof(int);
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "ID_PEDIDO_CEL_PED_VENDA";
            this.dataColumn5.DataType = typeof(int);
            // 
            // dataColumn6
            // 
            this.dataColumn6.Caption = "IMPRESSO_PED_VENDA";
            this.dataColumn6.ColumnName = "IMPRESSO_PED_VENDA";
            this.dataColumn6.DataType = typeof(int);
            // 
            // dataColumn7
            // 
            this.dataColumn7.ColumnName = "TROCA_PED_VENDA";
            this.dataColumn7.DataType = typeof(int);
            // 
            // dataColumn8
            // 
            this.dataColumn8.ColumnName = "BONIFICACAO_PED_VENDA";
            this.dataColumn8.DataType = typeof(int);
            // 
            // dataColumn9
            // 
            this.dataColumn9.ColumnName = "DATA_ENTREGA_PED_VENDA";
            this.dataColumn9.DataType = typeof(System.DateTime);
            // 
            // dataColumn10
            // 
            this.dataColumn10.ColumnName = "cod_pedido_pai_ped_venda";
            this.dataColumn10.DataType = typeof(int);
            // 
            // dataColumn11
            // 
            this.dataColumn11.ColumnName = "NOME_FANTASIA";
            this.dataColumn11.MaxLength = 200;
            // 
            // dataColumn12
            // 
            this.dataColumn12.ColumnName = "COD_ROTEIRO_CLIENTE";
            this.dataColumn12.DataType = typeof(int);
            // 
            // dataColumn13
            // 
            this.dataColumn13.ColumnName = "BAIRRO";
            this.dataColumn13.MaxLength = 100;
            // 
            // dataColumn14
            // 
            this.dataColumn14.ColumnName = "CEP_CLIENTE";
            this.dataColumn14.MaxLength = 20;
            // 
            // dataColumn15
            // 
            this.dataColumn15.ColumnName = "QTDE_TOTAL_PED_VENDA";
            this.dataColumn15.DataType = typeof(double);
            // 
            // dataColumn16
            // 
            this.dataColumn16.ColumnName = "DATA_NF_PED_VENDA";
            this.dataColumn16.DataType = typeof(System.DateTime);
            // 
            // dataColumn17
            // 
            this.dataColumn17.ColumnName = "DATA_EXPORTACAO_PED_VENDA";
            this.dataColumn17.DataType = typeof(System.DateTime);
            // 
            // dataColumn18
            // 
            this.dataColumn18.ColumnName = "HORA_EXPORTACAO_PED_VENDA";
            this.dataColumn18.DataType = typeof(System.DateTime);
            // 
            // dataColumn19
            // 
            this.dataColumn19.ColumnName = "PV_PED_VENDA";
            this.dataColumn19.DataType = typeof(int);
            // 
            // dataColumn20
            // 
            this.dataColumn20.ColumnName = "DEGUSTACAO_PED_VENDA";
            this.dataColumn20.DataType = typeof(int);
            // 
            // dataColumn21
            // 
            this.dataColumn21.ColumnName = "CNPJ_EMISSOR_PED_VENDA";
            // 
            // dataColumn22
            // 
            this.dataColumn22.ColumnName = "RAZAO_EMISSOR_PED_VENDA";
            // 
            // dataColumn23
            // 
            this.dataColumn23.ColumnName = "N_PED_VENDA";
            this.dataColumn23.DataType = typeof(int);
            // 
            // dataColumn24
            // 
            this.dataColumn24.ColumnName = "STATUS_PED_VENDA";
            this.dataColumn24.MaxLength = 100;
            // 
            // dataColumn25
            // 
            this.dataColumn25.ColumnName = "TIPO_PED_VENDA";
            this.dataColumn25.MaxLength = 100;
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AllowUserToAddRows = false;
            this.dgvPedidos.AllowUserToDeleteRows = false;
            this.dgvPedidos.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_cod,
            this.N_PED_VENDA,
            this.col_pai,
            this.DATA_EXPORTACAO_PED_VENDA,
            this.HORA_EXPORTACAO_PED_VENDA,
            this.dATAPEDVENDADataGridViewTextBoxColumn,
            this.NOME_FANTASIA,
            this.STATUS_PED_VENDA,
            this.TIPO_PED_VENDA,
            this.dataGridViewTextBoxColumn1,
            this.cNPJPEDVENDADataGridViewTextBoxColumn,
            this.CIDADE,
            this.BAIRRO,
            this.COD_ROTEIRO_CLIENTE,
            this.col_valor_total,
            this.vALORTOTALPRODPEDVENDADataGridViewTextBoxColumn,
            this.QTDE_TOTAL_PED_VENDA,
            this.VENDEDOR_PED_VENDA,
            this.cONDPGTOPEDVENDADataGridViewTextBoxColumn,
            this.DATA_ENTREGA_PED_VENDA,
            this.dataGridViewTextBoxColumn2,
            this.CNPJ_EMISSOR_PED_VENDA,
            this.RAZAO_EMISSOR_PED_VENDA,
            this.dataGridViewTextBoxColumn3,
            this.vALORTOTALICMSPEDVENDADataGridViewTextBoxColumn,
            this.dATABAIXAPEDVENDADataGridViewTextBoxColumn,
            this.N_NF_PED_VENDA,
            this.DATA_NF_PED_VENDA,
            this.cLIENTEPEDVENDADataGridViewTextBoxColumn,
            this.CEP_CLIENTE,
            this.vALORDESCONTOPEDVENDADataGridViewTextBoxColumn,
            this.colPedidoCel,
            this.vALORTOTALIPIPEDVENDADataGridViewTextBoxColumn,
            this.oBSPEDVENDADataGridViewTextBoxColumn,
            this.pAGOPEDVENDADataGridViewTextBoxColumn,
            this.cODCAIXAPGTOPEDVENDADataGridViewTextBoxColumn,
            this.COD_VENDEDOR_PED_VENDA});
            this.dgvPedidos.DataMember = "PEDIDOS_VENDA";
            this.dgvPedidos.DataSource = this.dsPedidos_venda;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPedidos.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPedidos.Location = new System.Drawing.Point(22, 220);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedidos.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvPedidos.Size = new System.Drawing.Size(1217, 366);
            this.dgvPedidos.TabIndex = 18;
            this.dgvPedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedidos_CellContentClick);
            this.dgvPedidos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedidos_CellDoubleClick);
            this.dgvPedidos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPedidos_CellFormatting);
            // 
            // col_cod
            // 
            this.col_cod.DataPropertyName = "COD_PED_VENDA";
            this.col_cod.HeaderText = "Cód. Interno";
            this.col_cod.Name = "col_cod";
            this.col_cod.ReadOnly = true;
            this.col_cod.Width = 50;
            // 
            // N_PED_VENDA
            // 
            this.N_PED_VENDA.DataPropertyName = "N_PED_VENDA";
            this.N_PED_VENDA.HeaderText = "N. Pedido";
            this.N_PED_VENDA.Name = "N_PED_VENDA";
            this.N_PED_VENDA.ReadOnly = true;
            this.N_PED_VENDA.Width = 50;
            // 
            // col_pai
            // 
            this.col_pai.DataPropertyName = "cod_pedido_pai_ped_venda";
            this.col_pai.FillWeight = 30F;
            this.col_pai.HeaderText = "Pai";
            this.col_pai.Name = "col_pai";
            this.col_pai.ReadOnly = true;
            this.col_pai.Width = 30;
            // 
            // DATA_EXPORTACAO_PED_VENDA
            // 
            this.DATA_EXPORTACAO_PED_VENDA.DataPropertyName = "DATA_EXPORTACAO_PED_VENDA";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.DATA_EXPORTACAO_PED_VENDA.DefaultCellStyle = dataGridViewCellStyle2;
            this.DATA_EXPORTACAO_PED_VENDA.HeaderText = "Data Exp.";
            this.DATA_EXPORTACAO_PED_VENDA.Name = "DATA_EXPORTACAO_PED_VENDA";
            this.DATA_EXPORTACAO_PED_VENDA.ReadOnly = true;
            this.DATA_EXPORTACAO_PED_VENDA.Visible = false;
            this.DATA_EXPORTACAO_PED_VENDA.Width = 50;
            // 
            // HORA_EXPORTACAO_PED_VENDA
            // 
            this.HORA_EXPORTACAO_PED_VENDA.DataPropertyName = "HORA_EXPORTACAO_PED_VENDA";
            dataGridViewCellStyle3.Format = "t";
            dataGridViewCellStyle3.NullValue = null;
            this.HORA_EXPORTACAO_PED_VENDA.DefaultCellStyle = dataGridViewCellStyle3;
            this.HORA_EXPORTACAO_PED_VENDA.HeaderText = "Hora Exp.";
            this.HORA_EXPORTACAO_PED_VENDA.Name = "HORA_EXPORTACAO_PED_VENDA";
            this.HORA_EXPORTACAO_PED_VENDA.ReadOnly = true;
            this.HORA_EXPORTACAO_PED_VENDA.Visible = false;
            this.HORA_EXPORTACAO_PED_VENDA.Width = 50;
            // 
            // dATAPEDVENDADataGridViewTextBoxColumn
            // 
            this.dATAPEDVENDADataGridViewTextBoxColumn.DataPropertyName = "DATA_PED_VENDA";
            this.dATAPEDVENDADataGridViewTextBoxColumn.HeaderText = "Data Pedido";
            this.dATAPEDVENDADataGridViewTextBoxColumn.Name = "dATAPEDVENDADataGridViewTextBoxColumn";
            this.dATAPEDVENDADataGridViewTextBoxColumn.ReadOnly = true;
            this.dATAPEDVENDADataGridViewTextBoxColumn.Width = 50;
            // 
            // NOME_FANTASIA
            // 
            this.NOME_FANTASIA.DataPropertyName = "NOME_FANTASIA";
            this.NOME_FANTASIA.HeaderText = "Nome Fantasia";
            this.NOME_FANTASIA.Name = "NOME_FANTASIA";
            this.NOME_FANTASIA.ReadOnly = true;
            this.NOME_FANTASIA.Visible = false;
            // 
            // STATUS_PED_VENDA
            // 
            this.STATUS_PED_VENDA.DataPropertyName = "STATUS_PED_VENDA";
            this.STATUS_PED_VENDA.HeaderText = "Status";
            this.STATUS_PED_VENDA.Name = "STATUS_PED_VENDA";
            this.STATUS_PED_VENDA.ReadOnly = true;
            this.STATUS_PED_VENDA.Width = 150;
            // 
            // TIPO_PED_VENDA
            // 
            this.TIPO_PED_VENDA.DataPropertyName = "TIPO_PED_VENDA";
            this.TIPO_PED_VENDA.HeaderText = "Tipo";
            this.TIPO_PED_VENDA.Name = "TIPO_PED_VENDA";
            this.TIPO_PED_VENDA.ReadOnly = true;
            this.TIPO_PED_VENDA.Width = 120;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CLIENTE_PED_VENDA";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nome Cliente";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // cNPJPEDVENDADataGridViewTextBoxColumn
            // 
            this.cNPJPEDVENDADataGridViewTextBoxColumn.DataPropertyName = "CNPJ_PED_VENDA";
            this.cNPJPEDVENDADataGridViewTextBoxColumn.HeaderText = "CNPJ";
            this.cNPJPEDVENDADataGridViewTextBoxColumn.Name = "cNPJPEDVENDADataGridViewTextBoxColumn";
            this.cNPJPEDVENDADataGridViewTextBoxColumn.ReadOnly = true;
            this.cNPJPEDVENDADataGridViewTextBoxColumn.Width = 50;
            // 
            // CIDADE
            // 
            this.CIDADE.DataPropertyName = "CIDADE";
            this.CIDADE.HeaderText = "Cidade";
            this.CIDADE.Name = "CIDADE";
            this.CIDADE.ReadOnly = true;
            this.CIDADE.Width = 50;
            // 
            // BAIRRO
            // 
            this.BAIRRO.DataPropertyName = "BAIRRO";
            this.BAIRRO.HeaderText = "Bairro";
            this.BAIRRO.Name = "BAIRRO";
            this.BAIRRO.ReadOnly = true;
            this.BAIRRO.Width = 50;
            // 
            // COD_ROTEIRO_CLIENTE
            // 
            this.COD_ROTEIRO_CLIENTE.DataPropertyName = "COD_ROTEIRO_CLIENTE";
            this.COD_ROTEIRO_CLIENTE.HeaderText = "Roteiro";
            this.COD_ROTEIRO_CLIENTE.Name = "COD_ROTEIRO_CLIENTE";
            this.COD_ROTEIRO_CLIENTE.ReadOnly = true;
            this.COD_ROTEIRO_CLIENTE.Width = 25;
            // 
            // col_valor_total
            // 
            this.col_valor_total.DataPropertyName = "VALOR_TOTAL_PED_VENDA";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.col_valor_total.DefaultCellStyle = dataGridViewCellStyle4;
            this.col_valor_total.HeaderText = "Valor Total";
            this.col_valor_total.Name = "col_valor_total";
            this.col_valor_total.ReadOnly = true;
            this.col_valor_total.Width = 50;
            // 
            // vALORTOTALPRODPEDVENDADataGridViewTextBoxColumn
            // 
            this.vALORTOTALPRODPEDVENDADataGridViewTextBoxColumn.DataPropertyName = "VALOR_TOTAL_PROD_PED_VENDA";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.vALORTOTALPRODPEDVENDADataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.vALORTOTALPRODPEDVENDADataGridViewTextBoxColumn.HeaderText = "Valor Produtos";
            this.vALORTOTALPRODPEDVENDADataGridViewTextBoxColumn.Name = "vALORTOTALPRODPEDVENDADataGridViewTextBoxColumn";
            this.vALORTOTALPRODPEDVENDADataGridViewTextBoxColumn.ReadOnly = true;
            this.vALORTOTALPRODPEDVENDADataGridViewTextBoxColumn.Visible = false;
            this.vALORTOTALPRODPEDVENDADataGridViewTextBoxColumn.Width = 70;
            // 
            // QTDE_TOTAL_PED_VENDA
            // 
            this.QTDE_TOTAL_PED_VENDA.DataPropertyName = "QTDE_TOTAL_PED_VENDA";
            this.QTDE_TOTAL_PED_VENDA.HeaderText = "Qtde Cx.";
            this.QTDE_TOTAL_PED_VENDA.Name = "QTDE_TOTAL_PED_VENDA";
            this.QTDE_TOTAL_PED_VENDA.ReadOnly = true;
            this.QTDE_TOTAL_PED_VENDA.Width = 25;
            // 
            // VENDEDOR_PED_VENDA
            // 
            this.VENDEDOR_PED_VENDA.DataPropertyName = "VENDEDOR_PED_VENDA";
            this.VENDEDOR_PED_VENDA.HeaderText = "Vendedor";
            this.VENDEDOR_PED_VENDA.Name = "VENDEDOR_PED_VENDA";
            this.VENDEDOR_PED_VENDA.ReadOnly = true;
            this.VENDEDOR_PED_VENDA.Width = 70;
            // 
            // cONDPGTOPEDVENDADataGridViewTextBoxColumn
            // 
            this.cONDPGTOPEDVENDADataGridViewTextBoxColumn.DataPropertyName = "COND_PGTO_PED_VENDA";
            this.cONDPGTOPEDVENDADataGridViewTextBoxColumn.HeaderText = "Cond. Pgto";
            this.cONDPGTOPEDVENDADataGridViewTextBoxColumn.Name = "cONDPGTOPEDVENDADataGridViewTextBoxColumn";
            this.cONDPGTOPEDVENDADataGridViewTextBoxColumn.ReadOnly = true;
            this.cONDPGTOPEDVENDADataGridViewTextBoxColumn.Width = 60;
            // 
            // DATA_ENTREGA_PED_VENDA
            // 
            this.DATA_ENTREGA_PED_VENDA.DataPropertyName = "DATA_ENTREGA_PED_VENDA";
            this.DATA_ENTREGA_PED_VENDA.HeaderText = "Data Limite";
            this.DATA_ENTREGA_PED_VENDA.Name = "DATA_ENTREGA_PED_VENDA";
            this.DATA_ENTREGA_PED_VENDA.ReadOnly = true;
            this.DATA_ENTREGA_PED_VENDA.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "OBS_PED_VENDA";
            this.dataGridViewTextBoxColumn2.HeaderText = "Obs";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 70;
            // 
            // CNPJ_EMISSOR_PED_VENDA
            // 
            this.CNPJ_EMISSOR_PED_VENDA.DataPropertyName = "CNPJ_EMISSOR_PED_VENDA";
            this.CNPJ_EMISSOR_PED_VENDA.HeaderText = "CNPJ Emissor";
            this.CNPJ_EMISSOR_PED_VENDA.Name = "CNPJ_EMISSOR_PED_VENDA";
            this.CNPJ_EMISSOR_PED_VENDA.ReadOnly = true;
            this.CNPJ_EMISSOR_PED_VENDA.Width = 70;
            // 
            // RAZAO_EMISSOR_PED_VENDA
            // 
            this.RAZAO_EMISSOR_PED_VENDA.DataPropertyName = "RAZAO_EMISSOR_PED_VENDA";
            this.RAZAO_EMISSOR_PED_VENDA.HeaderText = "Razão Emissor";
            this.RAZAO_EMISSOR_PED_VENDA.Name = "RAZAO_EMISSOR_PED_VENDA";
            this.RAZAO_EMISSOR_PED_VENDA.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "N_NF_PED_VENDA";
            this.dataGridViewTextBoxColumn3.HeaderText = "NF";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 70;
            // 
            // vALORTOTALICMSPEDVENDADataGridViewTextBoxColumn
            // 
            this.vALORTOTALICMSPEDVENDADataGridViewTextBoxColumn.DataPropertyName = "VALOR_TOTAL_ICMS_PED_VENDA";
            this.vALORTOTALICMSPEDVENDADataGridViewTextBoxColumn.HeaderText = "ICMS";
            this.vALORTOTALICMSPEDVENDADataGridViewTextBoxColumn.Name = "vALORTOTALICMSPEDVENDADataGridViewTextBoxColumn";
            this.vALORTOTALICMSPEDVENDADataGridViewTextBoxColumn.ReadOnly = true;
            this.vALORTOTALICMSPEDVENDADataGridViewTextBoxColumn.Visible = false;
            this.vALORTOTALICMSPEDVENDADataGridViewTextBoxColumn.Width = 45;
            // 
            // dATABAIXAPEDVENDADataGridViewTextBoxColumn
            // 
            this.dATABAIXAPEDVENDADataGridViewTextBoxColumn.DataPropertyName = "DATA_BAIXA_PED_VENDA";
            this.dATABAIXAPEDVENDADataGridViewTextBoxColumn.HeaderText = "Data Entrega";
            this.dATABAIXAPEDVENDADataGridViewTextBoxColumn.Name = "dATABAIXAPEDVENDADataGridViewTextBoxColumn";
            this.dATABAIXAPEDVENDADataGridViewTextBoxColumn.ReadOnly = true;
            this.dATABAIXAPEDVENDADataGridViewTextBoxColumn.Width = 70;
            // 
            // N_NF_PED_VENDA
            // 
            this.N_NF_PED_VENDA.DataPropertyName = "N_NF_PED_VENDA";
            this.N_NF_PED_VENDA.HeaderText = "No. NF.";
            this.N_NF_PED_VENDA.Name = "N_NF_PED_VENDA";
            this.N_NF_PED_VENDA.ReadOnly = true;
            this.N_NF_PED_VENDA.Width = 50;
            // 
            // DATA_NF_PED_VENDA
            // 
            this.DATA_NF_PED_VENDA.DataPropertyName = "DATA_NF_PED_VENDA";
            this.DATA_NF_PED_VENDA.HeaderText = "Data NF";
            this.DATA_NF_PED_VENDA.Name = "DATA_NF_PED_VENDA";
            this.DATA_NF_PED_VENDA.ReadOnly = true;
            this.DATA_NF_PED_VENDA.Width = 70;
            // 
            // cLIENTEPEDVENDADataGridViewTextBoxColumn
            // 
            this.cLIENTEPEDVENDADataGridViewTextBoxColumn.DataPropertyName = "CLIENTE_PED_VENDA";
            this.cLIENTEPEDVENDADataGridViewTextBoxColumn.HeaderText = "Razão";
            this.cLIENTEPEDVENDADataGridViewTextBoxColumn.Name = "cLIENTEPEDVENDADataGridViewTextBoxColumn";
            this.cLIENTEPEDVENDADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CEP_CLIENTE
            // 
            this.CEP_CLIENTE.DataPropertyName = "CEP_CLIENTE";
            this.CEP_CLIENTE.HeaderText = "Cep";
            this.CEP_CLIENTE.Name = "CEP_CLIENTE";
            this.CEP_CLIENTE.ReadOnly = true;
            // 
            // vALORDESCONTOPEDVENDADataGridViewTextBoxColumn
            // 
            this.vALORDESCONTOPEDVENDADataGridViewTextBoxColumn.DataPropertyName = "VALOR_DESCONTO_PED_VENDA";
            this.vALORDESCONTOPEDVENDADataGridViewTextBoxColumn.HeaderText = "Desconto";
            this.vALORDESCONTOPEDVENDADataGridViewTextBoxColumn.Name = "vALORDESCONTOPEDVENDADataGridViewTextBoxColumn";
            this.vALORDESCONTOPEDVENDADataGridViewTextBoxColumn.ReadOnly = true;
            this.vALORDESCONTOPEDVENDADataGridViewTextBoxColumn.Width = 60;
            // 
            // colPedidoCel
            // 
            this.colPedidoCel.DataPropertyName = "ID_PEDIDO_CEL_PED_VENDA";
            this.colPedidoCel.HeaderText = "ID Cel.:";
            this.colPedidoCel.Name = "colPedidoCel";
            this.colPedidoCel.ReadOnly = true;
            this.colPedidoCel.Width = 60;
            // 
            // vALORTOTALIPIPEDVENDADataGridViewTextBoxColumn
            // 
            this.vALORTOTALIPIPEDVENDADataGridViewTextBoxColumn.DataPropertyName = "VALOR_TOTAL_IPI_PED_VENDA";
            this.vALORTOTALIPIPEDVENDADataGridViewTextBoxColumn.HeaderText = "IPI";
            this.vALORTOTALIPIPEDVENDADataGridViewTextBoxColumn.Name = "vALORTOTALIPIPEDVENDADataGridViewTextBoxColumn";
            this.vALORTOTALIPIPEDVENDADataGridViewTextBoxColumn.ReadOnly = true;
            this.vALORTOTALIPIPEDVENDADataGridViewTextBoxColumn.Visible = false;
            this.vALORTOTALIPIPEDVENDADataGridViewTextBoxColumn.Width = 45;
            // 
            // oBSPEDVENDADataGridViewTextBoxColumn
            // 
            this.oBSPEDVENDADataGridViewTextBoxColumn.DataPropertyName = "OBS_PED_VENDA";
            this.oBSPEDVENDADataGridViewTextBoxColumn.HeaderText = "Obs";
            this.oBSPEDVENDADataGridViewTextBoxColumn.Name = "oBSPEDVENDADataGridViewTextBoxColumn";
            this.oBSPEDVENDADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pAGOPEDVENDADataGridViewTextBoxColumn
            // 
            this.pAGOPEDVENDADataGridViewTextBoxColumn.DataPropertyName = "PAGO_PED_VENDA";
            this.pAGOPEDVENDADataGridViewTextBoxColumn.HeaderText = "Pago?";
            this.pAGOPEDVENDADataGridViewTextBoxColumn.Name = "pAGOPEDVENDADataGridViewTextBoxColumn";
            this.pAGOPEDVENDADataGridViewTextBoxColumn.ReadOnly = true;
            this.pAGOPEDVENDADataGridViewTextBoxColumn.Visible = false;
            // 
            // cODCAIXAPGTOPEDVENDADataGridViewTextBoxColumn
            // 
            this.cODCAIXAPGTOPEDVENDADataGridViewTextBoxColumn.DataPropertyName = "COD_CAIXA_PGTO_PED_VENDA";
            this.cODCAIXAPGTOPEDVENDADataGridViewTextBoxColumn.HeaderText = "Cod Caixa";
            this.cODCAIXAPGTOPEDVENDADataGridViewTextBoxColumn.Name = "cODCAIXAPGTOPEDVENDADataGridViewTextBoxColumn";
            this.cODCAIXAPGTOPEDVENDADataGridViewTextBoxColumn.ReadOnly = true;
            this.cODCAIXAPGTOPEDVENDADataGridViewTextBoxColumn.Visible = false;
            // 
            // COD_VENDEDOR_PED_VENDA
            // 
            this.COD_VENDEDOR_PED_VENDA.DataPropertyName = "COD_VENDEDOR_PED_VENDA";
            this.COD_VENDEDOR_PED_VENDA.HeaderText = "Cód. Vendedor";
            this.COD_VENDEDOR_PED_VENDA.Name = "COD_VENDEDOR_PED_VENDA";
            this.COD_VENDEDOR_PED_VENDA.ReadOnly = true;
            this.COD_VENDEDOR_PED_VENDA.Visible = false;
            this.COD_VENDEDOR_PED_VENDA.Width = 30;
            // 
            // tb_cliente
            // 
            this.tb_cliente.Location = new System.Drawing.Point(113, 24);
            this.tb_cliente.Name = "tb_cliente";
            this.tb_cliente.Size = new System.Drawing.Size(150, 20);
            this.tb_cliente.TabIndex = 19;
            this.tb_cliente.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tb_vendedor
            // 
            this.tb_vendedor.Location = new System.Drawing.Point(269, 24);
            this.tb_vendedor.Name = "tb_vendedor";
            this.tb_vendedor.Size = new System.Drawing.Size(133, 20);
            this.tb_vendedor.TabIndex = 20;
            this.tb_vendedor.TextChanged += new System.EventHandler(this.tb_vendedor_TextChanged);
            // 
            // tb_valor_total
            // 
            this.tb_valor_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_valor_total.Location = new System.Drawing.Point(1073, 592);
            this.tb_valor_total.Name = "tb_valor_total";
            this.tb_valor_total.Size = new System.Drawing.Size(166, 31);
            this.tb_valor_total.TabIndex = 21;
            this.tb_valor_total.Visible = false;
            this.tb_valor_total.TextChanged += new System.EventHandler(this.tb_valor_total_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(951, 595);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 26);
            this.label1.TabIndex = 22;
            this.label1.Text = "Valor Total:";
            this.label1.Visible = false;
            // 
            // comando_select
            // 
            this.comando_select.CommandTimeout = 30;
            this.comando_select.Connection = this.fbConnection1;
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(445, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 76);
            this.button3.TabIndex = 26;
            this.button3.Text = "Imprimir Consulta";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Vendedor:";
            // 
            // labelCodPedido
            // 
            this.labelCodPedido.AutoSize = true;
            this.labelCodPedido.Location = new System.Drawing.Point(4, 8);
            this.labelCodPedido.Name = "labelCodPedido";
            this.labelCodPedido.Size = new System.Drawing.Size(65, 13);
            this.labelCodPedido.TabIndex = 30;
            this.labelCodPedido.Text = "Cod. Interno";
            // 
            // txtCodPedido
            // 
            this.txtCodPedido.Location = new System.Drawing.Point(7, 24);
            this.txtCodPedido.Name = "txtCodPedido";
            this.txtCodPedido.Size = new System.Drawing.Size(100, 20);
            this.txtCodPedido.TabIndex = 31;
            this.txtCodPedido.TextChanged += new System.EventHandler(this.txtCodPedido_TextChanged);
            // 
            // txtCnpj
            // 
            this.txtCnpj.Location = new System.Drawing.Point(408, 24);
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(145, 20);
            this.txtCnpj.TabIndex = 32;
            this.txtCnpj.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(405, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "CNPJ Cliente:";
            // 
            // btnConfirmarPedido
            // 
            this.btnConfirmarPedido.Location = new System.Drawing.Point(350, 15);
            this.btnConfirmarPedido.Name = "btnConfirmarPedido";
            this.btnConfirmarPedido.Size = new System.Drawing.Size(89, 76);
            this.btnConfirmarPedido.TabIndex = 34;
            this.btnConfirmarPedido.Text = "Confirmar Pedido(s) para Faturamento";
            this.btnConfirmarPedido.UseVisualStyleBackColor = true;
            this.btnConfirmarPedido.Click += new System.EventHandler(this.btnConfirmarPedido_Click);
            // 
            // cbFechados
            // 
            this.cbFechados.AutoSize = true;
            this.cbFechados.Location = new System.Drawing.Point(131, 45);
            this.cbFechados.Name = "cbFechados";
            this.cbFechados.Size = new System.Drawing.Size(74, 17);
            this.cbFechados.TabIndex = 37;
            this.cbFechados.Text = "Entregues";
            this.cbFechados.UseVisualStyleBackColor = true;
            // 
            // cb_Nao_fechados
            // 
            this.cb_Nao_fechados.AutoSize = true;
            this.cb_Nao_fechados.Location = new System.Drawing.Point(131, 23);
            this.cb_Nao_fechados.Name = "cb_Nao_fechados";
            this.cb_Nao_fechados.Size = new System.Drawing.Size(62, 17);
            this.cb_Nao_fechados.TabIndex = 38;
            this.cb_Nao_fechados.Text = "Abertos";
            this.cb_Nao_fechados.UseVisualStyleBackColor = true;
            // 
            // cbNao_faturados
            // 
            this.cbNao_faturados.AutoSize = true;
            this.cbNao_faturados.Location = new System.Drawing.Point(258, 49);
            this.cbNao_faturados.Name = "cbNao_faturados";
            this.cbNao_faturados.Size = new System.Drawing.Size(96, 17);
            this.cbNao_faturados.TabIndex = 40;
            this.cbNao_faturados.Text = "Não Faturados";
            this.cbNao_faturados.UseVisualStyleBackColor = true;
            this.cbNao_faturados.Visible = false;
            // 
            // cbFaturados
            // 
            this.cbFaturados.AutoSize = true;
            this.cbFaturados.Location = new System.Drawing.Point(131, 66);
            this.cbFaturados.Name = "cbFaturados";
            this.cbFaturados.Size = new System.Drawing.Size(68, 17);
            this.cbFaturados.TabIndex = 39;
            this.cbFaturados.Text = "Faturado";
            this.cbFaturados.UseVisualStyleBackColor = true;
            // 
            // labelQTdeOrcamentos
            // 
            this.labelQTdeOrcamentos.AutoSize = true;
            this.labelQTdeOrcamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQTdeOrcamentos.Location = new System.Drawing.Point(694, 595);
            this.labelQTdeOrcamentos.Name = "labelQTdeOrcamentos";
            this.labelQTdeOrcamentos.Size = new System.Drawing.Size(150, 26);
            this.labelQTdeOrcamentos.TabIndex = 42;
            this.labelQTdeOrcamentos.Text = "Qtde Pedidos:";
            // 
            // tb_qtde_pedidos
            // 
            this.tb_qtde_pedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_qtde_pedidos.Location = new System.Drawing.Point(850, 592);
            this.tb_qtde_pedidos.Name = "tb_qtde_pedidos";
            this.tb_qtde_pedidos.Size = new System.Drawing.Size(76, 31);
            this.tb_qtde_pedidos.TabIndex = 41;
            // 
            // cbBonificacao
            // 
            this.cbBonificacao.AutoSize = true;
            this.cbBonificacao.Location = new System.Drawing.Point(6, 46);
            this.cbBonificacao.Name = "cbBonificacao";
            this.cbBonificacao.Size = new System.Drawing.Size(82, 17);
            this.cbBonificacao.TabIndex = 44;
            this.cbBonificacao.Text = "Bonificação";
            this.cbBonificacao.UseVisualStyleBackColor = true;
            this.cbBonificacao.Visible = false;
            // 
            // cbTroca
            // 
            this.cbTroca.AutoSize = true;
            this.cbTroca.Location = new System.Drawing.Point(6, 24);
            this.cbTroca.Name = "cbTroca";
            this.cbTroca.Size = new System.Drawing.Size(54, 17);
            this.cbTroca.TabIndex = 43;
            this.cbTroca.Text = "Troca";
            this.cbTroca.UseVisualStyleBackColor = true;
            this.cbTroca.Visible = false;
            // 
            // cbVenda
            // 
            this.cbVenda.AutoSize = true;
            this.cbVenda.Location = new System.Drawing.Point(6, 2);
            this.cbVenda.Name = "cbVenda";
            this.cbVenda.Size = new System.Drawing.Size(57, 17);
            this.cbVenda.TabIndex = 45;
            this.cbVenda.Text = "Venda";
            this.cbVenda.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(47, 595);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 26);
            this.label8.TabIndex = 47;
            this.label8.Text = "Visitas Program.:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(232, 592);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 31);
            this.textBox1.TabIndex = 46;
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(540, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 76);
            this.button2.TabIndex = 48;
            this.button2.Text = "Imprimir Lucratividade";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.tb_valor);
            this.panel2.Controls.Add(this.tb_n_pedido);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.tb_roteiro);
            this.panel2.Controls.Add(this.tb_nome_fantasia);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtCnpj);
            this.panel2.Controls.Add(this.txtCodPedido);
            this.panel2.Controls.Add(this.labelCodPedido);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tb_vendedor);
            this.panel2.Controls.Add(this.tb_cliente);
            this.panel2.Location = new System.Drawing.Point(23, 129);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(576, 86);
            this.panel2.TabIndex = 49;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(405, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 41;
            this.label11.Text = "Valor:";
            // 
            // tb_valor
            // 
            this.tb_valor.Location = new System.Drawing.Point(408, 62);
            this.tb_valor.Name = "tb_valor";
            this.tb_valor.Size = new System.Drawing.Size(145, 20);
            this.tb_valor.TabIndex = 40;
            this.tb_valor.TextChanged += new System.EventHandler(this.tb_valor_TextChanged);
            // 
            // tb_n_pedido
            // 
            this.tb_n_pedido.Location = new System.Drawing.Point(7, 62);
            this.tb_n_pedido.Name = "tb_n_pedido";
            this.tb_n_pedido.Size = new System.Drawing.Size(100, 20);
            this.tb_n_pedido.TabIndex = 39;
            this.tb_n_pedido.TextChanged += new System.EventHandler(this.tb_n_pedido_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "No. Pedido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Roteiro:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(107, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Nome Fantasia:";
            // 
            // tb_roteiro
            // 
            this.tb_roteiro.Location = new System.Drawing.Point(266, 62);
            this.tb_roteiro.Name = "tb_roteiro";
            this.tb_roteiro.Size = new System.Drawing.Size(133, 20);
            this.tb_roteiro.TabIndex = 35;
            this.tb_roteiro.TextChanged += new System.EventHandler(this.tb_roteiro_TextChanged);
            // 
            // tb_nome_fantasia
            // 
            this.tb_nome_fantasia.Location = new System.Drawing.Point(110, 62);
            this.tb_nome_fantasia.Name = "tb_nome_fantasia";
            this.tb_nome_fantasia.Size = new System.Drawing.Size(150, 20);
            this.tb_nome_fantasia.TabIndex = 34;
            this.tb_nome_fantasia.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.cbBombas);
            this.panel3.Controls.Add(this.cbIndustrializacao);
            this.panel3.Controls.Add(this.cbDegustacao);
            this.panel3.Controls.Add(this.cbPv);
            this.panel3.Controls.Add(this.cbDevolucao);
            this.panel3.Controls.Add(this.cbApenas_orcamentos);
            this.panel3.Controls.Add(this.cbCancelados);
            this.panel3.Controls.Add(this.cbVenda);
            this.panel3.Controls.Add(this.cbBonificacao);
            this.panel3.Controls.Add(this.cbTroca);
            this.panel3.Controls.Add(this.cbNao_faturados);
            this.panel3.Controls.Add(this.cbFaturados);
            this.panel3.Controls.Add(this.cb_Nao_fechados);
            this.panel3.Controls.Add(this.cbFechados);
            this.panel3.Location = new System.Drawing.Point(1021, 108);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(218, 107);
            this.panel3.TabIndex = 50;
            this.panel3.Visible = false;
            // 
            // cbBombas
            // 
            this.cbBombas.AutoSize = true;
            this.cbBombas.Location = new System.Drawing.Point(6, 45);
            this.cbBombas.Name = "cbBombas";
            this.cbBombas.Size = new System.Drawing.Size(64, 17);
            this.cbBombas.TabIndex = 52;
            this.cbBombas.Text = "Bombas";
            this.cbBombas.UseVisualStyleBackColor = true;
            // 
            // cbIndustrializacao
            // 
            this.cbIndustrializacao.AutoSize = true;
            this.cbIndustrializacao.Location = new System.Drawing.Point(6, 23);
            this.cbIndustrializacao.Name = "cbIndustrializacao";
            this.cbIndustrializacao.Size = new System.Drawing.Size(99, 17);
            this.cbIndustrializacao.TabIndex = 51;
            this.cbIndustrializacao.Text = "Industrialização";
            this.cbIndustrializacao.UseVisualStyleBackColor = true;
            // 
            // cbDegustacao
            // 
            this.cbDegustacao.AutoSize = true;
            this.cbDegustacao.Location = new System.Drawing.Point(6, 68);
            this.cbDegustacao.Name = "cbDegustacao";
            this.cbDegustacao.Size = new System.Drawing.Size(84, 17);
            this.cbDegustacao.TabIndex = 50;
            this.cbDegustacao.Text = "Degustação";
            this.cbDegustacao.UseVisualStyleBackColor = true;
            this.cbDegustacao.Visible = false;
            // 
            // cbPv
            // 
            this.cbPv.AutoSize = true;
            this.cbPv.Location = new System.Drawing.Point(258, 2);
            this.cbPv.Name = "cbPv";
            this.cbPv.Size = new System.Drawing.Size(40, 17);
            this.cbPv.TabIndex = 49;
            this.cbPv.Text = "PV";
            this.cbPv.UseVisualStyleBackColor = true;
            this.cbPv.Visible = false;
            // 
            // cbDevolucao
            // 
            this.cbDevolucao.AutoSize = true;
            this.cbDevolucao.Location = new System.Drawing.Point(365, 2);
            this.cbDevolucao.Name = "cbDevolucao";
            this.cbDevolucao.Size = new System.Drawing.Size(83, 17);
            this.cbDevolucao.TabIndex = 48;
            this.cbDevolucao.Text = "Devoluções";
            this.cbDevolucao.UseVisualStyleBackColor = true;
            this.cbDevolucao.Visible = false;
            // 
            // cbApenas_orcamentos
            // 
            this.cbApenas_orcamentos.AutoSize = true;
            this.cbApenas_orcamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbApenas_orcamentos.Location = new System.Drawing.Point(131, 2);
            this.cbApenas_orcamentos.Name = "cbApenas_orcamentos";
            this.cbApenas_orcamentos.Size = new System.Drawing.Size(83, 17);
            this.cbApenas_orcamentos.TabIndex = 47;
            this.cbApenas_orcamentos.Text = "Orçamentos";
            this.cbApenas_orcamentos.UseVisualStyleBackColor = true;
            // 
            // cbCancelados
            // 
            this.cbCancelados.AutoSize = true;
            this.cbCancelados.Location = new System.Drawing.Point(225, 64);
            this.cbCancelados.Name = "cbCancelados";
            this.cbCancelados.Size = new System.Drawing.Size(82, 17);
            this.cbCancelados.TabIndex = 46;
            this.cbCancelados.Text = "Cancelados";
            this.cbCancelados.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.OldLace;
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.tb_pedido_cliente);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.tb_op_cliente);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.tb_produto);
            this.panel4.Location = new System.Drawing.Point(605, 97);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(139, 118);
            this.panel4.TabIndex = 51;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 80);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Pedido Cliente:";
            // 
            // tb_pedido_cliente
            // 
            this.tb_pedido_cliente.Location = new System.Drawing.Point(19, 94);
            this.tb_pedido_cliente.Name = "tb_pedido_cliente";
            this.tb_pedido_cliente.Size = new System.Drawing.Size(100, 20);
            this.tb_pedido_cliente.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(38, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "OP Cliente:";
            // 
            // tb_op_cliente
            // 
            this.tb_op_cliente.Location = new System.Drawing.Point(19, 57);
            this.tb_op_cliente.Name = "tb_op_cliente";
            this.tb_op_cliente.Size = new System.Drawing.Size(100, 20);
            this.tb_op_cliente.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Cód. Cliente Produto:";
            // 
            // tb_produto
            // 
            this.tb_produto.Location = new System.Drawing.Point(19, 21);
            this.tb_produto.Name = "tb_produto";
            this.tb_produto.Size = new System.Drawing.Size(100, 20);
            this.tb_produto.TabIndex = 0;
            this.tb_produto.TextChanged += new System.EventHandler(this.tb_produto_TextChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1164, 68);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 52;
            this.button4.Text = "Separação";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Location = new System.Drawing.Point(635, 15);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(89, 76);
            this.button5.TabIndex = 54;
            this.button5.Tag = "Fechar Pedidos";
            this.button5.Text = "Fechar Pedidos";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.Location = new System.Drawing.Point(730, 15);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(89, 76);
            this.button6.TabIndex = 55;
            this.button6.Tag = "";
            this.button6.Text = "Imprimir Pedidos";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.Location = new System.Drawing.Point(825, 15);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(89, 76);
            this.button7.TabIndex = 56;
            this.button7.Tag = "";
            this.button7.Text = "Imprimir Produtos Pedidos";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(345, 595);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 26);
            this.label7.TabIndex = 58;
            this.label7.Text = "Número de Caixas:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(550, 592);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(76, 31);
            this.textBox2.TabIndex = 57;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(920, 15);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(84, 76);
            this.button8.TabIndex = 59;
            this.button8.Text = "Material Necessário";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // cbStatus
            // 
            this.cbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "",
            "Orçamento",
            "Aguardando Confirmação",
            "Confirmado",
            "Faturado",
            "Entregue"});
            this.cbStatus.Location = new System.Drawing.Point(750, 126);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(265, 32);
            this.cbStatus.TabIndex = 382;
            this.cbStatus.SelectedValueChanged += new System.EventHandler(this.cbStatus_SelectedValueChanged);
            // 
            // cbTipo
            // 
            this.cbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "",
            "Industrialização",
            "Vendas",
            "Bombas",
            "Serviços"});
            this.cbTipo.Location = new System.Drawing.Point(750, 182);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(265, 32);
            this.cbTipo.TabIndex = 383;
            this.cbTipo.SelectedValueChanged += new System.EventHandler(this.cbTipo_SelectedValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(750, 108);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Status:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(750, 166);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 13);
            this.label15.TabIndex = 384;
            this.label15.Text = "Tipo:";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(1010, 15);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(84, 76);
            this.button9.TabIndex = 385;
            this.button9.Text = "Status Itens";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // cbConfirmados_aguardando
            // 
            this.cbConfirmados_aguardando.AutoSize = true;
            this.cbConfirmados_aguardando.Location = new System.Drawing.Point(825, 103);
            this.cbConfirmados_aguardando.Name = "cbConfirmados_aguardando";
            this.cbConfirmados_aguardando.Size = new System.Drawing.Size(154, 17);
            this.cbConfirmados_aguardando.TabIndex = 386;
            this.cbConfirmados_aguardando.Text = "Confirmados e Aguardando";
            this.cbConfirmados_aguardando.UseVisualStyleBackColor = true;
            // 
            // form_pesquisa_pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 630);
            this.Controls.Add(this.cbConfirmados_aguardando);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelQTdeOrcamentos);
            this.Controls.Add(this.tb_qtde_pedidos);
            this.Controls.Add(this.btnConfirmarPedido);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_valor_total);
            this.Controls.Add(this.dgvPedidos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Name = "form_pesquisa_pedido";
            this.Text = "Pesquisa Pedido";
            this.Load += new System.EventHandler(this.form_pesquisa_pedido_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsPedidos_venda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PEDIDOS_VENDA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
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
        private FirebirdSql.Data.FirebirdClient.FbCommand comando_select;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelCodPedido;
        private System.Windows.Forms.TextBox txtCodPedido;
        private System.Data.DataColumn dataColumn3;
        private System.Windows.Forms.TextBox txtCnpj;
        private System.Windows.Forms.Label label5;
        private System.Data.DataColumn dataColumn4;
        private System.Windows.Forms.Button btnConfirmarPedido;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Windows.Forms.CheckBox cbFechados;
        private System.Windows.Forms.CheckBox cb_Nao_fechados;
        private System.Windows.Forms.CheckBox cbNao_faturados;
        private System.Windows.Forms.CheckBox cbFaturados;
        private System.Windows.Forms.CheckBox cbData;
        private System.Windows.Forms.Label labelQTdeOrcamentos;
        private System.Windows.Forms.TextBox tb_qtde_pedidos;
        private System.Data.DataColumn dataColumn7;
        private System.Data.DataColumn dataColumn8;
        private System.Windows.Forms.CheckBox cbBonificacao;
        private System.Windows.Forms.CheckBox cbTroca;
        private System.Windows.Forms.CheckBox cbVenda;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_produto;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox cbSem_vendedor;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.CheckBox cb_data_prevista;
        private System.Data.DataColumn dataColumn9;
        private System.Data.DataColumn dataColumn10;
        private System.Windows.Forms.CheckBox cbApenas_orcamentos;
        private System.Windows.Forms.CheckBox cbCancelados;
        private System.Windows.Forms.CheckBox cbData_entrega;
        private System.Data.DataColumn dataColumn11;
        private System.Data.DataColumn dataColumn12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_roteiro;
        private System.Windows.Forms.TextBox tb_nome_fantasia;
        private System.Windows.Forms.Button button7;
        private System.Data.DataColumn dataColumn13;
        private System.Data.DataColumn dataColumn14;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Data.DataColumn dataColumn15;
        private System.Data.DataColumn dataColumn16;
        private System.Windows.Forms.CheckBox cbDegustacao;
        private System.Windows.Forms.CheckBox cbPv;
        private System.Windows.Forms.CheckBox cbDevolucao;
        private System.Data.DataColumn dataColumn17;
        private System.Data.DataColumn dataColumn18;
        private System.Data.DataColumn dataColumn19;
        private System.Data.DataColumn dataColumn20;
        private System.Data.DataColumn dataColumn21;
        private System.Data.DataColumn dataColumn22;
        private System.Data.DataColumn dataColumn23;
        private System.Windows.Forms.TextBox tb_n_pedido;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_valor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_pedido_cliente;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_op_cliente;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.CheckBox cbIndustrializacao;
        private System.Windows.Forms.CheckBox cbBombas;
        private System.Data.DataColumn dataColumn24;
        private System.Data.DataColumn dataColumn25;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn N_PED_VENDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_pai;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA_EXPORTACAO_PED_VENDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORA_EXPORTACAO_PED_VENDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAPEDVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_FANTASIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS_PED_VENDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO_PED_VENDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPJPEDVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDADE;
        private System.Windows.Forms.DataGridViewTextBoxColumn BAIRRO;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_ROTEIRO_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_valor_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORTOTALPRODPEDVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTDE_TOTAL_PED_VENDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn VENDEDOR_PED_VENDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONDPGTOPEDVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA_ENTREGA_PED_VENDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNPJ_EMISSOR_PED_VENDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn RAZAO_EMISSOR_PED_VENDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORTOTALICMSPEDVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATABAIXAPEDVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn N_NF_PED_VENDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA_NF_PED_VENDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTEPEDVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEP_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORDESCONTOPEDVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPedidoCel;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORTOTALIPIPEDVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oBSPEDVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAGOPEDVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODCAIXAPGTOPEDVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_VENDEDOR_PED_VENDA;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.CheckBox cbConfirmados_aguardando;
    }
}