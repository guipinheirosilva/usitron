namespace Evolucao
{
    partial class form_atualiza_cr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_atualiza_cr));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.datContas_a_receber = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
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
            this.COD_PLANO_CR = new System.Data.DataColumn();
            this.dataColumn1 = new System.Data.DataColumn();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.tb_filtro_cr_cliente = new System.Windows.Forms.TextBox();
            this.tb_filtro_cr_descricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCr = new System.Windows.Forms.DataGridView();
            this.col_cod_cr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRICAOCRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_valor_total_cr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_data_vencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODCLIENTECRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAZAOCLIENTECRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dUPLICATACRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nFCRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rECEBIDOCRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dATARECEBIMENTOCRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODCAIXACRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_valor_atualizado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.button14 = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.rbAbertos_cr = new System.Windows.Forms.RadioButton();
            this.rbPagos_cr = new System.Windows.Forms.RadioButton();
            this.rbAtrasados_cr = new System.Windows.Forms.RadioButton();
            this.rbTodos_cr = new System.Windows.Forms.RadioButton();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.bt_buscar_cliente = new System.Windows.Forms.Button();
            this.tb_cod_cliente_cr = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_nome_cliente = new System.Windows.Forms.TextBox();
            this.cb_cliente_cr = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.cb_data_cr = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtFinal_cr = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.dtInicial_cr = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtData_pgto = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.comando_select = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.datClientes = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand8 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand6 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand5 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand7 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.tb_valor_total_cr = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_total_atualizado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_juros = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_aliquota = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbContas_a_receber = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            ((System.ComponentModel.ISupportInitialize)(this.dsContas_a_receber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CONTAS_A_RECEBER)).BeginInit();
            this.groupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCr)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.SuspendLayout();
            // 
            // datContas_a_receber
            // 
            this.datContas_a_receber.DeleteCommand = this.fbCommand4;
            this.datContas_a_receber.InsertCommand = this.fbCommand2;
            this.datContas_a_receber.SelectCommand = this.fbCommand1;
            this.datContas_a_receber.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * from contas_a_receber";
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
            this.CARTEIRA_CR,
            this.COD_PLANO_CR,
            this.dataColumn1});
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
            // COD_PLANO_CR
            // 
            this.COD_PLANO_CR.ColumnName = "COD_PLANO_CR";
            this.COD_PLANO_CR.DataType = typeof(int);
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "VALOR_ATUALIZADO_CR";
            this.dataColumn1.DataType = typeof(double);
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.tb_filtro_cr_cliente);
            this.groupBox12.Controls.Add(this.tb_filtro_cr_descricao);
            this.groupBox12.Location = new System.Drawing.Point(20, 242);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(439, 42);
            this.groupBox12.TabIndex = 23;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Filtro";
            // 
            // tb_filtro_cr_cliente
            // 
            this.tb_filtro_cr_cliente.Location = new System.Drawing.Point(314, 19);
            this.tb_filtro_cr_cliente.Name = "tb_filtro_cr_cliente";
            this.tb_filtro_cr_cliente.Size = new System.Drawing.Size(95, 20);
            this.tb_filtro_cr_cliente.TabIndex = 13;
            this.tb_filtro_cr_cliente.TextChanged += new System.EventHandler(this.tb_filtro_cr_cliente_TextChanged);
            // 
            // tb_filtro_cr_descricao
            // 
            this.tb_filtro_cr_descricao.Location = new System.Drawing.Point(41, 19);
            this.tb_filtro_cr_descricao.Name = "tb_filtro_cr_descricao";
            this.tb_filtro_cr_descricao.Size = new System.Drawing.Size(151, 20);
            this.tb_filtro_cr_descricao.TabIndex = 7;
            this.tb_filtro_cr_descricao.TextChanged += new System.EventHandler(this.tb_filtro_cr_descricao_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(353, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 31);
            this.label2.TabIndex = 19;
            this.label2.Text = "CONTAS A RECEBER";
            // 
            // dgvCr
            // 
            this.dgvCr.AllowUserToAddRows = false;
            this.dgvCr.AllowUserToDeleteRows = false;
            this.dgvCr.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCr.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_cod_cr,
            this.dESCRICAOCRDataGridViewTextBoxColumn,
            this.col_valor_total_cr,
            this.col_data_vencimento,
            this.cODCLIENTECRDataGridViewTextBoxColumn,
            this.rAZAOCLIENTECRDataGridViewTextBoxColumn,
            this.dUPLICATACRDataGridViewTextBoxColumn,
            this.nFCRDataGridViewTextBoxColumn,
            this.rECEBIDOCRDataGridViewTextBoxColumn,
            this.dATARECEBIMENTOCRDataGridViewTextBoxColumn,
            this.cODCAIXACRDataGridViewTextBoxColumn,
            this.col_valor_atualizado});
            this.dgvCr.DataMember = "CONTAS_A_RECEBER";
            this.dgvCr.DataSource = this.dsContas_a_receber;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCr.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCr.Location = new System.Drawing.Point(21, 284);
            this.dgvCr.Name = "dgvCr";
            this.dgvCr.ReadOnly = true;
            this.dgvCr.Size = new System.Drawing.Size(766, 341);
            this.dgvCr.TabIndex = 22;
            // 
            // col_cod_cr
            // 
            this.col_cod_cr.DataPropertyName = "COD_CR";
            this.col_cod_cr.HeaderText = "COD_CR";
            this.col_cod_cr.Name = "col_cod_cr";
            this.col_cod_cr.ReadOnly = true;
            this.col_cod_cr.Visible = false;
            // 
            // dESCRICAOCRDataGridViewTextBoxColumn
            // 
            this.dESCRICAOCRDataGridViewTextBoxColumn.DataPropertyName = "DESCRICAO_CR";
            this.dESCRICAOCRDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.dESCRICAOCRDataGridViewTextBoxColumn.Name = "dESCRICAOCRDataGridViewTextBoxColumn";
            this.dESCRICAOCRDataGridViewTextBoxColumn.ReadOnly = true;
            this.dESCRICAOCRDataGridViewTextBoxColumn.Width = 150;
            // 
            // col_valor_total_cr
            // 
            this.col_valor_total_cr.DataPropertyName = "VALOR_CR";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.col_valor_total_cr.DefaultCellStyle = dataGridViewCellStyle2;
            this.col_valor_total_cr.HeaderText = "Valor";
            this.col_valor_total_cr.Name = "col_valor_total_cr";
            this.col_valor_total_cr.ReadOnly = true;
            this.col_valor_total_cr.Width = 70;
            // 
            // col_data_vencimento
            // 
            this.col_data_vencimento.DataPropertyName = "DATA_PREVISTA_CR";
            this.col_data_vencimento.HeaderText = "Data Prevista";
            this.col_data_vencimento.Name = "col_data_vencimento";
            this.col_data_vencimento.ReadOnly = true;
            this.col_data_vencimento.Width = 50;
            // 
            // cODCLIENTECRDataGridViewTextBoxColumn
            // 
            this.cODCLIENTECRDataGridViewTextBoxColumn.DataPropertyName = "COD_CLIENTE_CR";
            this.cODCLIENTECRDataGridViewTextBoxColumn.HeaderText = "COD_CLIENTE_CR";
            this.cODCLIENTECRDataGridViewTextBoxColumn.Name = "cODCLIENTECRDataGridViewTextBoxColumn";
            this.cODCLIENTECRDataGridViewTextBoxColumn.ReadOnly = true;
            this.cODCLIENTECRDataGridViewTextBoxColumn.Visible = false;
            // 
            // rAZAOCLIENTECRDataGridViewTextBoxColumn
            // 
            this.rAZAOCLIENTECRDataGridViewTextBoxColumn.DataPropertyName = "RAZAO_CLIENTE_CR";
            this.rAZAOCLIENTECRDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.rAZAOCLIENTECRDataGridViewTextBoxColumn.Name = "rAZAOCLIENTECRDataGridViewTextBoxColumn";
            this.rAZAOCLIENTECRDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dUPLICATACRDataGridViewTextBoxColumn
            // 
            this.dUPLICATACRDataGridViewTextBoxColumn.DataPropertyName = "DUPLICATA_CR";
            this.dUPLICATACRDataGridViewTextBoxColumn.HeaderText = "Duplicata";
            this.dUPLICATACRDataGridViewTextBoxColumn.Name = "dUPLICATACRDataGridViewTextBoxColumn";
            this.dUPLICATACRDataGridViewTextBoxColumn.ReadOnly = true;
            this.dUPLICATACRDataGridViewTextBoxColumn.Visible = false;
            // 
            // nFCRDataGridViewTextBoxColumn
            // 
            this.nFCRDataGridViewTextBoxColumn.DataPropertyName = "NF_CR";
            this.nFCRDataGridViewTextBoxColumn.HeaderText = "Pedido";
            this.nFCRDataGridViewTextBoxColumn.Name = "nFCRDataGridViewTextBoxColumn";
            this.nFCRDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rECEBIDOCRDataGridViewTextBoxColumn
            // 
            this.rECEBIDOCRDataGridViewTextBoxColumn.DataPropertyName = "RECEBIDO_CR";
            this.rECEBIDOCRDataGridViewTextBoxColumn.FalseValue = "0";
            this.rECEBIDOCRDataGridViewTextBoxColumn.HeaderText = "Recebido";
            this.rECEBIDOCRDataGridViewTextBoxColumn.IndeterminateValue = "0";
            this.rECEBIDOCRDataGridViewTextBoxColumn.Name = "rECEBIDOCRDataGridViewTextBoxColumn";
            this.rECEBIDOCRDataGridViewTextBoxColumn.ReadOnly = true;
            this.rECEBIDOCRDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.rECEBIDOCRDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.rECEBIDOCRDataGridViewTextBoxColumn.TrueValue = "1";
            this.rECEBIDOCRDataGridViewTextBoxColumn.Width = 40;
            // 
            // dATARECEBIMENTOCRDataGridViewTextBoxColumn
            // 
            this.dATARECEBIMENTOCRDataGridViewTextBoxColumn.DataPropertyName = "DATA_RECEBIMENTO_CR";
            this.dATARECEBIMENTOCRDataGridViewTextBoxColumn.HeaderText = "Data Receb.";
            this.dATARECEBIMENTOCRDataGridViewTextBoxColumn.Name = "dATARECEBIMENTOCRDataGridViewTextBoxColumn";
            this.dATARECEBIMENTOCRDataGridViewTextBoxColumn.ReadOnly = true;
            this.dATARECEBIMENTOCRDataGridViewTextBoxColumn.Width = 50;
            // 
            // cODCAIXACRDataGridViewTextBoxColumn
            // 
            this.cODCAIXACRDataGridViewTextBoxColumn.DataPropertyName = "COD_CAIXA_CR";
            this.cODCAIXACRDataGridViewTextBoxColumn.HeaderText = "COD_CAIXA_CR";
            this.cODCAIXACRDataGridViewTextBoxColumn.Name = "cODCAIXACRDataGridViewTextBoxColumn";
            this.cODCAIXACRDataGridViewTextBoxColumn.ReadOnly = true;
            this.cODCAIXACRDataGridViewTextBoxColumn.Visible = false;
            // 
            // col_valor_atualizado
            // 
            this.col_valor_atualizado.DataPropertyName = "VALOR_ATUALIZADO_CR";
            this.col_valor_atualizado.HeaderText = "Valor Atualizado";
            this.col_valor_atualizado.Name = "col_valor_atualizado";
            this.col_valor_atualizado.ReadOnly = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.button14);
            this.groupBox7.Controls.Add(this.groupBox8);
            this.groupBox7.Controls.Add(this.groupBox9);
            this.groupBox7.Controls.Add(this.groupBox10);
            this.groupBox7.Location = new System.Drawing.Point(20, 57);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(439, 175);
            this.groupBox7.TabIndex = 20;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Pesquisa";
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(6, 141);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 23);
            this.button14.TabIndex = 7;
            this.button14.Text = "Pesquisar";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.rbAbertos_cr);
            this.groupBox8.Controls.Add(this.rbPagos_cr);
            this.groupBox8.Controls.Add(this.rbAtrasados_cr);
            this.groupBox8.Controls.Add(this.rbTodos_cr);
            this.groupBox8.Location = new System.Drawing.Point(350, 13);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(83, 123);
            this.groupBox8.TabIndex = 3;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Posição";
            // 
            // rbAbertos_cr
            // 
            this.rbAbertos_cr.AutoSize = true;
            this.rbAbertos_cr.Location = new System.Drawing.Point(10, 91);
            this.rbAbertos_cr.Name = "rbAbertos_cr";
            this.rbAbertos_cr.Size = new System.Drawing.Size(61, 17);
            this.rbAbertos_cr.TabIndex = 3;
            this.rbAbertos_cr.TabStop = true;
            this.rbAbertos_cr.Text = "Abertos";
            this.rbAbertos_cr.UseVisualStyleBackColor = true;
            // 
            // rbPagos_cr
            // 
            this.rbPagos_cr.AutoSize = true;
            this.rbPagos_cr.Location = new System.Drawing.Point(10, 68);
            this.rbPagos_cr.Name = "rbPagos_cr";
            this.rbPagos_cr.Size = new System.Drawing.Size(55, 17);
            this.rbPagos_cr.TabIndex = 2;
            this.rbPagos_cr.TabStop = true;
            this.rbPagos_cr.Text = "Pagos";
            this.rbPagos_cr.UseVisualStyleBackColor = true;
            // 
            // rbAtrasados_cr
            // 
            this.rbAtrasados_cr.AutoSize = true;
            this.rbAtrasados_cr.Location = new System.Drawing.Point(10, 45);
            this.rbAtrasados_cr.Name = "rbAtrasados_cr";
            this.rbAtrasados_cr.Size = new System.Drawing.Size(72, 17);
            this.rbAtrasados_cr.TabIndex = 1;
            this.rbAtrasados_cr.TabStop = true;
            this.rbAtrasados_cr.Text = "Atrasados";
            this.rbAtrasados_cr.UseVisualStyleBackColor = true;
            // 
            // rbTodos_cr
            // 
            this.rbTodos_cr.AutoSize = true;
            this.rbTodos_cr.Location = new System.Drawing.Point(10, 21);
            this.rbTodos_cr.Name = "rbTodos_cr";
            this.rbTodos_cr.Size = new System.Drawing.Size(55, 17);
            this.rbTodos_cr.TabIndex = 0;
            this.rbTodos_cr.TabStop = true;
            this.rbTodos_cr.Text = "Todos";
            this.rbTodos_cr.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.bt_buscar_cliente);
            this.groupBox9.Controls.Add(this.tb_cod_cliente_cr);
            this.groupBox9.Controls.Add(this.label9);
            this.groupBox9.Controls.Add(this.tb_nome_cliente);
            this.groupBox9.Controls.Add(this.cb_cliente_cr);
            this.groupBox9.Controls.Add(this.label10);
            this.groupBox9.Location = new System.Drawing.Point(6, 74);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(253, 62);
            this.groupBox9.TabIndex = 2;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Cliente";
            // 
            // bt_buscar_cliente
            // 
            this.bt_buscar_cliente.Location = new System.Drawing.Point(142, 12);
            this.bt_buscar_cliente.Name = "bt_buscar_cliente";
            this.bt_buscar_cliente.Size = new System.Drawing.Size(63, 23);
            this.bt_buscar_cliente.TabIndex = 2;
            this.bt_buscar_cliente.Text = "Buscar";
            this.bt_buscar_cliente.UseVisualStyleBackColor = true;
            this.bt_buscar_cliente.Click += new System.EventHandler(this.bt_buscar_cliente_Click);
            // 
            // tb_cod_cliente_cr
            // 
            this.tb_cod_cliente_cr.Location = new System.Drawing.Point(6, 36);
            this.tb_cod_cliente_cr.Name = "tb_cod_cliente_cr";
            this.tb_cod_cliente_cr.Size = new System.Drawing.Size(40, 20);
            this.tb_cod_cliente_cr.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Cód.";
            // 
            // tb_nome_cliente
            // 
            this.tb_nome_cliente.Location = new System.Drawing.Point(49, 36);
            this.tb_nome_cliente.Name = "tb_nome_cliente";
            this.tb_nome_cliente.Size = new System.Drawing.Size(156, 20);
            this.tb_nome_cliente.TabIndex = 1;
            // 
            // cb_cliente_cr
            // 
            this.cb_cliente_cr.AutoSize = true;
            this.cb_cliente_cr.Location = new System.Drawing.Point(223, 34);
            this.cb_cliente_cr.Name = "cb_cliente_cr";
            this.cb_cliente_cr.Size = new System.Drawing.Size(15, 14);
            this.cb_cliente_cr.TabIndex = 3;
            this.cb_cliente_cr.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(46, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Nome Cliente";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.cb_data_cr);
            this.groupBox10.Controls.Add(this.label11);
            this.groupBox10.Controls.Add(this.dtFinal_cr);
            this.groupBox10.Controls.Add(this.label12);
            this.groupBox10.Controls.Add(this.dtInicial_cr);
            this.groupBox10.Location = new System.Drawing.Point(6, 12);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(253, 62);
            this.groupBox10.TabIndex = 1;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Data";
            // 
            // cb_data_cr
            // 
            this.cb_data_cr.AutoSize = true;
            this.cb_data_cr.Location = new System.Drawing.Point(223, 34);
            this.cb_data_cr.Name = "cb_data_cr";
            this.cb_data_cr.Size = new System.Drawing.Size(15, 14);
            this.cb_data_cr.TabIndex = 2;
            this.cb_data_cr.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(110, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Data Final";
            // 
            // dtFinal_cr
            // 
            this.dtFinal_cr.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFinal_cr.Location = new System.Drawing.Point(110, 34);
            this.dtFinal_cr.Name = "dtFinal_cr";
            this.dtFinal_cr.Size = new System.Drawing.Size(98, 20);
            this.dtFinal_cr.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Data Inicial";
            // 
            // dtInicial_cr
            // 
            this.dtInicial_cr.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicial_cr.Location = new System.Drawing.Point(6, 34);
            this.dtInicial_cr.Name = "dtInicial_cr";
            this.dtInicial_cr.Size = new System.Drawing.Size(98, 20);
            this.dtInicial_cr.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(514, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Atualizar Valores";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(626, 162);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Imprimir";
            this.button2.UseVisualStyleBackColor = true;
            
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(514, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Data do Pagamento";
            // 
            // dtData_pgto
            // 
            this.dtData_pgto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtData_pgto.Location = new System.Drawing.Point(514, 136);
            this.dtData_pgto.Name = "dtData_pgto";
            this.dtData_pgto.Size = new System.Drawing.Size(98, 20);
            this.dtData_pgto.TabIndex = 25;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(514, 191);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 23);
            this.button3.TabIndex = 27;
            this.button3.Text = "Baixar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comando_select
            // 
            this.comando_select.CommandTimeout = 30;
            this.comando_select.Connection = this.fbConnection1;
            // 
            // datClientes
            // 
            this.datClientes.DeleteCommand = this.fbCommand8;
            this.datClientes.InsertCommand = this.fbCommand6;
            this.datClientes.SelectCommand = this.fbCommand5;
            this.datClientes.UpdateCommand = this.fbCommand7;
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
            this.fbCommand5.CommandText = "select * from clientes";
            this.fbCommand5.CommandTimeout = 30;
            this.fbCommand5.Connection = this.fbConnection1;
            // 
            // fbCommand7
            // 
            this.fbCommand7.CommandTimeout = 30;
            // 
            // tb_valor_total_cr
            // 
            this.tb_valor_total_cr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_valor_total_cr.Location = new System.Drawing.Point(144, 629);
            this.tb_valor_total_cr.Name = "tb_valor_total_cr";
            this.tb_valor_total_cr.Size = new System.Drawing.Size(142, 29);
            this.tb_valor_total_cr.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 632);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 24);
            this.label8.TabIndex = 28;
            this.label8.Text = "Total Previsto";
            // 
            // tb_total_atualizado
            // 
            this.tb_total_atualizado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_total_atualizado.Location = new System.Drawing.Point(441, 629);
            this.tb_total_atualizado.Name = "tb_total_atualizado";
            this.tb_total_atualizado.Size = new System.Drawing.Size(142, 29);
            this.tb_total_atualizado.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(292, 632);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 24);
            this.label3.TabIndex = 30;
            this.label3.Text = "Total Atualizado";
            // 
            // tb_juros
            // 
            this.tb_juros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_juros.Location = new System.Drawing.Point(651, 629);
            this.tb_juros.Name = "tb_juros";
            this.tb_juros.Size = new System.Drawing.Size(142, 29);
            this.tb_juros.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(589, 632);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 24);
            this.label4.TabIndex = 32;
            this.label4.Text = "Juros";
            // 
            // tb_aliquota
            // 
            this.tb_aliquota.Location = new System.Drawing.Point(514, 103);
            this.tb_aliquota.Name = "tb_aliquota";
            this.tb_aliquota.Size = new System.Drawing.Size(102, 20);
            this.tb_aliquota.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(514, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Alíquota";
            // 
            // cbContas_a_receber
            // 
            this.cbContas_a_receber.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbContas_a_receber.DataAdapter = this.datContas_a_receber;
            this.cbContas_a_receber.QuotePrefix = "\"";
            this.cbContas_a_receber.QuoteSuffix = "\"";
            // 
            // form_atualiza_cr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 693);
            this.Controls.Add(this.tb_aliquota);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_juros);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_total_atualizado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_valor_total_cr);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtData_pgto);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvCr);
            this.Controls.Add(this.groupBox7);
            this.Name = "form_atualiza_cr";
            this.Text = "Atualiza Contas a Receber";
            this.Load += new System.EventHandler(this.form_atualiza_cr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsContas_a_receber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CONTAS_A_RECEBER)).EndInit();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCr)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datContas_a_receber;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
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
        private System.Data.DataColumn COD_PLANO_CR;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.TextBox tb_filtro_cr_cliente;
        private System.Windows.Forms.TextBox tb_filtro_cr_descricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvCr;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.RadioButton rbAbertos_cr;
        private System.Windows.Forms.RadioButton rbPagos_cr;
        private System.Windows.Forms.RadioButton rbAtrasados_cr;
        private System.Windows.Forms.RadioButton rbTodos_cr;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button bt_buscar_cliente;
        private System.Windows.Forms.TextBox tb_cod_cliente_cr;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_nome_cliente;
        private System.Windows.Forms.CheckBox cb_cliente_cr;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.CheckBox cb_data_cr;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtFinal_cr;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtInicial_cr;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtData_pgto;
        private System.Windows.Forms.Button button3;
        private FirebirdSql.Data.FirebirdClient.FbCommand comando_select;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datClientes;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand8;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand6;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand5;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand7;
        private System.Windows.Forms.TextBox tb_valor_total_cr;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_total_atualizado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_juros;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_aliquota;
        private System.Windows.Forms.Label label5;
        private System.Data.DataColumn dataColumn1;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbContas_a_receber;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod_cr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRICAOCRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_valor_total_cr;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_data_vencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODCLIENTECRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAZAOCLIENTECRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dUPLICATACRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nFCRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn rECEBIDOCRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATARECEBIMENTOCRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODCAIXACRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_valor_atualizado;
    }
}