namespace Evolucao
{
    partial class form_pesquisa_itens_pedidos_compra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_pesquisa_itens_pedidos_compra));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.datItens_ped = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsItens_ped = new System.Data.DataSet();
            this.ITENS_PEDIDO_COMPRA = new System.Data.DataTable();
            this.COD_ITEM_PED = new System.Data.DataColumn();
            this.N_PEDIDO_ITEM_PED = new System.Data.DataColumn();
            this.COD_ITEM_REQ_ITEM_PED = new System.Data.DataColumn();
            this.OP_ITEM_PED = new System.Data.DataColumn();
            this.QTDE_ITEM_PED = new System.Data.DataColumn();
            this.UNID_ITEM_PED = new System.Data.DataColumn();
            this.VALOR_UNIT_ITEM_PED = new System.Data.DataColumn();
            this.VALOR_TOTAL_ITEM_PED = new System.Data.DataColumn();
            this.DESCRICAO_ITEM_PED = new System.Data.DataColumn();
            this.DATA_LIMITE_ITEM_PED = new System.Data.DataColumn();
            this.COD_ESTOQUE_ITEM_PED = new System.Data.DataColumn();
            this.POSICAO_ITEM_PED = new System.Data.DataColumn();
            this.PESO_ITEM_PED = new System.Data.DataColumn();
            this.CHEGOU_ITEM_PED = new System.Data.DataColumn();
            this.COD_NF_ENTRADA_ITEM_PED = new System.Data.DataColumn();
            this.DATA_ENTRADA_ITEM_PED = new System.Data.DataColumn();
            this.PLANO_ITEM_PED = new System.Data.DataColumn();
            this.ITEM_ITEM_PED = new System.Data.DataColumn();
            this.FORNECEDOR_ITEM_PED = new System.Data.DataColumn();
            this.dgvItens_ped = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb_item = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_cod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_descricao = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxTrimestre = new System.Windows.Forms.ComboBox();
            this.nudAno = new System.Windows.Forms.NumericUpDown();
            this.rdbTrimestre = new System.Windows.Forms.RadioButton();
            this.rdbPeriodo = new System.Windows.Forms.RadioButton();
            this.lblTermino = new System.Windows.Forms.Label();
            this.dtTermino = new System.Windows.Forms.DateTimePicker();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.lblInicio = new System.Windows.Forms.Label();
            this.tb_nome_forn = new System.Windows.Forms.TextBox();
            this.tb_cnpj_forn = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_valor_total = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cod_item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nPEDIDOITEMPEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_item_req = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cod_estoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRICAOITEMPEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_qtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uNIDITEMPEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_valor_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_valor_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Req = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dATALIMITEITEMPEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPITEMPEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_chegou = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.col_nf_entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA_CHEGADA_ITEM_PED = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dsItens_ped)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITENS_PEDIDO_COMPRA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens_ped)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAno)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // datItens_ped
            // 
            this.datItens_ped.DeleteCommand = this.fbCommand4;
            this.datItens_ped.InsertCommand = this.fbCommand2;
            this.datItens_ped.SelectCommand = this.fbCommand1;
            this.datItens_ped.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * from itens_pedido_compra";
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
            // dsItens_ped
            // 
            this.dsItens_ped.DataSetName = "dsItens_ped";
            this.dsItens_ped.Namespace = "http://www.tempuri.org/dsItens_ped.xsd";
            this.dsItens_ped.Tables.AddRange(new System.Data.DataTable[] {
            this.ITENS_PEDIDO_COMPRA});
            // 
            // ITENS_PEDIDO_COMPRA
            // 
            this.ITENS_PEDIDO_COMPRA.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_ITEM_PED,
            this.N_PEDIDO_ITEM_PED,
            this.COD_ITEM_REQ_ITEM_PED,
            this.OP_ITEM_PED,
            this.QTDE_ITEM_PED,
            this.UNID_ITEM_PED,
            this.VALOR_UNIT_ITEM_PED,
            this.VALOR_TOTAL_ITEM_PED,
            this.DESCRICAO_ITEM_PED,
            this.DATA_LIMITE_ITEM_PED,
            this.COD_ESTOQUE_ITEM_PED,
            this.POSICAO_ITEM_PED,
            this.PESO_ITEM_PED,
            this.CHEGOU_ITEM_PED,
            this.COD_NF_ENTRADA_ITEM_PED,
            this.DATA_ENTRADA_ITEM_PED,
            this.PLANO_ITEM_PED,
            this.ITEM_ITEM_PED,
            this.FORNECEDOR_ITEM_PED});
            this.ITENS_PEDIDO_COMPRA.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_ITEM_PED"}, true)});
            this.ITENS_PEDIDO_COMPRA.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_ITEM_PED};
            this.ITENS_PEDIDO_COMPRA.TableName = "ITENS_PEDIDO_COMPRA";
            // 
            // COD_ITEM_PED
            // 
            this.COD_ITEM_PED.AllowDBNull = false;
            this.COD_ITEM_PED.ColumnName = "COD_ITEM_PED";
            this.COD_ITEM_PED.DataType = typeof(int);
            // 
            // N_PEDIDO_ITEM_PED
            // 
            this.N_PEDIDO_ITEM_PED.ColumnName = "N_PEDIDO_ITEM_PED";
            this.N_PEDIDO_ITEM_PED.DataType = typeof(int);
            // 
            // COD_ITEM_REQ_ITEM_PED
            // 
            this.COD_ITEM_REQ_ITEM_PED.ColumnName = "COD_ITEM_REQ_ITEM_PED";
            this.COD_ITEM_REQ_ITEM_PED.DataType = typeof(int);
            // 
            // OP_ITEM_PED
            // 
            this.OP_ITEM_PED.ColumnName = "OP_ITEM_PED";
            this.OP_ITEM_PED.MaxLength = 50;
            // 
            // QTDE_ITEM_PED
            // 
            this.QTDE_ITEM_PED.ColumnName = "QTDE_ITEM_PED";
            this.QTDE_ITEM_PED.DataType = typeof(double);
            // 
            // UNID_ITEM_PED
            // 
            this.UNID_ITEM_PED.ColumnName = "UNID_ITEM_PED";
            this.UNID_ITEM_PED.MaxLength = 10;
            // 
            // VALOR_UNIT_ITEM_PED
            // 
            this.VALOR_UNIT_ITEM_PED.ColumnName = "VALOR_UNIT_ITEM_PED";
            this.VALOR_UNIT_ITEM_PED.DataType = typeof(double);
            // 
            // VALOR_TOTAL_ITEM_PED
            // 
            this.VALOR_TOTAL_ITEM_PED.ColumnName = "VALOR_TOTAL_ITEM_PED";
            this.VALOR_TOTAL_ITEM_PED.DataType = typeof(double);
            // 
            // DESCRICAO_ITEM_PED
            // 
            this.DESCRICAO_ITEM_PED.ColumnName = "DESCRICAO_ITEM_PED";
            this.DESCRICAO_ITEM_PED.MaxLength = 250;
            // 
            // DATA_LIMITE_ITEM_PED
            // 
            this.DATA_LIMITE_ITEM_PED.ColumnName = "DATA_LIMITE_ITEM_PED";
            this.DATA_LIMITE_ITEM_PED.DataType = typeof(System.DateTime);
            // 
            // COD_ESTOQUE_ITEM_PED
            // 
            this.COD_ESTOQUE_ITEM_PED.ColumnName = "COD_ESTOQUE_ITEM_PED";
            this.COD_ESTOQUE_ITEM_PED.DataType = typeof(int);
            // 
            // POSICAO_ITEM_PED
            // 
            this.POSICAO_ITEM_PED.ColumnName = "POSICAO_ITEM_PED";
            this.POSICAO_ITEM_PED.MaxLength = 50;
            // 
            // PESO_ITEM_PED
            // 
            this.PESO_ITEM_PED.ColumnName = "PESO_ITEM_PED";
            this.PESO_ITEM_PED.DataType = typeof(double);
            // 
            // CHEGOU_ITEM_PED
            // 
            this.CHEGOU_ITEM_PED.ColumnName = "CHEGOU_ITEM_PED";
            this.CHEGOU_ITEM_PED.DataType = typeof(int);
            // 
            // COD_NF_ENTRADA_ITEM_PED
            // 
            this.COD_NF_ENTRADA_ITEM_PED.ColumnName = "COD_NF_ENTRADA_ITEM_PED";
            this.COD_NF_ENTRADA_ITEM_PED.MaxLength = 20;
            // 
            // DATA_ENTRADA_ITEM_PED
            // 
            this.DATA_ENTRADA_ITEM_PED.ColumnName = "DATA_CHEGADA_ITEM_PED";
            this.DATA_ENTRADA_ITEM_PED.DataType = typeof(System.DateTime);
            // 
            // PLANO_ITEM_PED
            // 
            this.PLANO_ITEM_PED.ColumnName = "PLANO_ITEM_PED";
            this.PLANO_ITEM_PED.MaxLength = 100;
            // 
            // ITEM_ITEM_PED
            // 
            this.ITEM_ITEM_PED.ColumnName = "ITEM_ITEM_PED";
            this.ITEM_ITEM_PED.MaxLength = 30;
            // 
            // FORNECEDOR_ITEM_PED
            // 
            this.FORNECEDOR_ITEM_PED.ColumnName = "FORNECEDOR_ITEM_PED";
            this.FORNECEDOR_ITEM_PED.MaxLength = 200;
            // 
            // dgvItens_ped
            // 
            this.dgvItens_ped.AllowUserToAddRows = false;
            this.dgvItens_ped.AllowUserToResizeColumns = false;
            this.dgvItens_ped.AllowUserToResizeRows = false;
            this.dgvItens_ped.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItens_ped.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItens_ped.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens_ped.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OK,
            this.dataGridViewTextBoxColumn1,
            this.col_cod_item,
            this.nPEDIDOITEMPEDDataGridViewTextBoxColumn,
            this.col_item_req,
            this.col_cod_estoque,
            this.dataGridViewTextBoxColumn2,
            this.dESCRICAOITEMPEDDataGridViewTextBoxColumn,
            this.col_qtde,
            this.uNIDITEMPEDDataGridViewTextBoxColumn,
            this.col_valor_unit,
            this.col_valor_total,
            this.Req,
            this.dATALIMITEITEMPEDDataGridViewTextBoxColumn,
            this.oPITEMPEDDataGridViewTextBoxColumn,
            this.col_chegou,
            this.col_nf_entrada,
            this.DATA_CHEGADA_ITEM_PED});
            this.dgvItens_ped.DataMember = "ITENS_PEDIDO_COMPRA";
            this.dgvItens_ped.DataSource = this.dsItens_ped;
            this.dgvItens_ped.Location = new System.Drawing.Point(12, 106);
            this.dgvItens_ped.Name = "dgvItens_ped";
            this.dgvItens_ped.Size = new System.Drawing.Size(1139, 441);
            this.dgvItens_ped.TabIndex = 109;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.tb_item);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.tb_cod);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.tb_descricao);
            this.panel2.Location = new System.Drawing.Point(798, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(353, 88);
            this.panel2.TabIndex = 111;
            // 
            // tb_item
            // 
            this.tb_item.Location = new System.Drawing.Point(112, 45);
            this.tb_item.Name = "tb_item";
            this.tb_item.Size = new System.Drawing.Size(131, 20);
            this.tb_item.TabIndex = 18;
            this.tb_item.TextChanged += new System.EventHandler(this.tb_item_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Item:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Filtros";
            // 
            // tb_cod
            // 
            this.tb_cod.Location = new System.Drawing.Point(112, 25);
            this.tb_cod.Name = "tb_cod";
            this.tb_cod.Size = new System.Drawing.Size(131, 20);
            this.tb_cod.TabIndex = 15;
            this.tb_cod.TextChanged += new System.EventHandler(this.tb_cod_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Descrição:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Cód:";
            // 
            // tb_descricao
            // 
            this.tb_descricao.Location = new System.Drawing.Point(112, 65);
            this.tb_descricao.Name = "tb_descricao";
            this.tb_descricao.Size = new System.Drawing.Size(232, 20);
            this.tb_descricao.TabIndex = 13;
            this.tb_descricao.TextChanged += new System.EventHandler(this.tb_descricao_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.tb_nome_forn);
            this.panel1.Controls.Add(this.tb_cnpj_forn);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 88);
            this.panel1.TabIndex = 110;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(700, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 68);
            this.button3.TabIndex = 18;
            this.button3.Text = "Imprimir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(619, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 68);
            this.button2.TabIndex = 17;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxTrimestre);
            this.groupBox2.Controls.Add(this.nudAno);
            this.groupBox2.Controls.Add(this.rdbTrimestre);
            this.groupBox2.Controls.Add(this.rdbPeriodo);
            this.groupBox2.Controls.Add(this.lblTermino);
            this.groupBox2.Controls.Add(this.dtTermino);
            this.groupBox2.Controls.Add(this.dtInicio);
            this.groupBox2.Controls.Add(this.lblInicio);
            this.groupBox2.Location = new System.Drawing.Point(244, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(303, 72);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Intervalos de Datas";
            // 
            // cbxTrimestre
            // 
            this.cbxTrimestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTrimestre.FormattingEnabled = true;
            this.cbxTrimestre.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbxTrimestre.Location = new System.Drawing.Point(218, 18);
            this.cbxTrimestre.Name = "cbxTrimestre";
            this.cbxTrimestre.Size = new System.Drawing.Size(49, 21);
            this.cbxTrimestre.TabIndex = 19;
            this.cbxTrimestre.Visible = false;
            // 
            // nudAno
            // 
            this.nudAno.Location = new System.Drawing.Point(218, 44);
            this.nudAno.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.nudAno.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudAno.Name = "nudAno";
            this.nudAno.Size = new System.Drawing.Size(49, 20);
            this.nudAno.TabIndex = 19;
            this.nudAno.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudAno.Visible = false;
            // 
            // rdbTrimestre
            // 
            this.rdbTrimestre.AutoSize = true;
            this.rdbTrimestre.Location = new System.Drawing.Point(6, 44);
            this.rdbTrimestre.Name = "rdbTrimestre";
            this.rdbTrimestre.Size = new System.Drawing.Size(87, 17);
            this.rdbTrimestre.TabIndex = 5;
            this.rdbTrimestre.TabStop = true;
            this.rdbTrimestre.Text = "Por Trimestre";
            this.rdbTrimestre.UseVisualStyleBackColor = true;
            this.rdbTrimestre.CheckedChanged += new System.EventHandler(this.rdbTrimestre_CheckedChanged);
            // 
            // rdbPeriodo
            // 
            this.rdbPeriodo.AutoSize = true;
            this.rdbPeriodo.Location = new System.Drawing.Point(6, 19);
            this.rdbPeriodo.Name = "rdbPeriodo";
            this.rdbPeriodo.Size = new System.Drawing.Size(82, 17);
            this.rdbPeriodo.TabIndex = 4;
            this.rdbPeriodo.TabStop = true;
            this.rdbPeriodo.Text = "Por Período";
            this.rdbPeriodo.UseVisualStyleBackColor = true;
            this.rdbPeriodo.CheckedChanged += new System.EventHandler(this.rdbPeriodo_CheckedChanged);
            // 
            // lblTermino
            // 
            this.lblTermino.AutoSize = true;
            this.lblTermino.Location = new System.Drawing.Point(151, 46);
            this.lblTermino.Name = "lblTermino";
            this.lblTermino.Size = new System.Drawing.Size(45, 13);
            this.lblTermino.TabIndex = 3;
            this.lblTermino.Text = "Término";
            // 
            // dtTermino
            // 
            this.dtTermino.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTermino.Location = new System.Drawing.Point(202, 45);
            this.dtTermino.Name = "dtTermino";
            this.dtTermino.Size = new System.Drawing.Size(95, 20);
            this.dtTermino.TabIndex = 2;
            // 
            // dtInicio
            // 
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicio.Location = new System.Drawing.Point(202, 19);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(95, 20);
            this.dtInicio.TabIndex = 0;
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Location = new System.Drawing.Point(151, 23);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(32, 13);
            this.lblInicio.TabIndex = 1;
            this.lblInicio.Text = "Inicio";
            // 
            // tb_nome_forn
            // 
            this.tb_nome_forn.Location = new System.Drawing.Point(10, 50);
            this.tb_nome_forn.Name = "tb_nome_forn";
            this.tb_nome_forn.Size = new System.Drawing.Size(212, 20);
            this.tb_nome_forn.TabIndex = 11;
            // 
            // tb_cnpj_forn
            // 
            this.tb_cnpj_forn.Location = new System.Drawing.Point(77, 25);
            this.tb_cnpj_forn.Name = "tb_cnpj_forn";
            this.tb_cnpj_forn.Size = new System.Drawing.Size(113, 20);
            this.tb_cnpj_forn.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(201, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(21, 21);
            this.button1.TabIndex = 9;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fornecedor:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.tb_valor_total);
            this.panel3.Location = new System.Drawing.Point(872, 553);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(279, 74);
            this.panel3.TabIndex = 112;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(194, 13);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 48);
            this.button4.TabIndex = 111;
            this.button4.Text = "Somar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 13);
            this.label14.TabIndex = 106;
            this.label14.Text = "Valor Total:";
            // 
            // tb_valor_total
            // 
            this.tb_valor_total.Location = new System.Drawing.Point(72, 28);
            this.tb_valor_total.Name = "tb_valor_total";
            this.tb_valor_total.Size = new System.Drawing.Size(98, 20);
            this.tb_valor_total.TabIndex = 105;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel4.Controls.Add(this.button7);
            this.panel4.Controls.Add(this.button6);
            this.panel4.Controls.Add(this.button5);
            this.panel4.Location = new System.Drawing.Point(12, 553);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(257, 74);
            this.panel4.TabIndex = 113;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(10, 13);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(237, 48);
            this.button7.TabIndex = 114;
            this.button7.Text = "Gerar IQF Todos";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(91, 13);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 48);
            this.button6.TabIndex = 113;
            this.button6.Text = "Gerar IQF Terceiros";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(10, 13);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 48);
            this.button5.TabIndex = 112;
            this.button5.Text = "Gerar IQF Compras";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // OK
            // 
            this.OK.HeaderText = "OK";
            this.OK.Name = "OK";
            this.OK.Text = "OK";
            this.OK.ToolTipText = "OK";
            this.OK.UseColumnTextForButtonValue = true;
            this.OK.Width = 30;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "N_PEDIDO_ITEM_PED";
            this.dataGridViewTextBoxColumn1.HeaderText = "N. Ped.";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // col_cod_item
            // 
            this.col_cod_item.DataPropertyName = "COD_ITEM_PED";
            this.col_cod_item.HeaderText = "Cód.";
            this.col_cod_item.Name = "col_cod_item";
            this.col_cod_item.Width = 30;
            // 
            // nPEDIDOITEMPEDDataGridViewTextBoxColumn
            // 
            this.nPEDIDOITEMPEDDataGridViewTextBoxColumn.DataPropertyName = "N_PEDIDO_ITEM_PED";
            this.nPEDIDOITEMPEDDataGridViewTextBoxColumn.HeaderText = "Nº Item Pedido";
            this.nPEDIDOITEMPEDDataGridViewTextBoxColumn.Name = "nPEDIDOITEMPEDDataGridViewTextBoxColumn";
            this.nPEDIDOITEMPEDDataGridViewTextBoxColumn.Visible = false;
            this.nPEDIDOITEMPEDDataGridViewTextBoxColumn.Width = 85;
            // 
            // col_item_req
            // 
            this.col_item_req.DataPropertyName = "COD_ITEM_REQ_ITEM_PED";
            this.col_item_req.HeaderText = "Nº Item Requisição";
            this.col_item_req.Name = "col_item_req";
            this.col_item_req.Width = 85;
            // 
            // col_cod_estoque
            // 
            this.col_cod_estoque.DataPropertyName = "COD_ESTOQUE_ITEM_PED";
            this.col_cod_estoque.HeaderText = "Cód. Estoque";
            this.col_cod_estoque.Name = "col_cod_estoque";
            this.col_cod_estoque.Width = 70;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ITEM_ITEM_PED";
            this.dataGridViewTextBoxColumn2.HeaderText = "Item";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dESCRICAOITEMPEDDataGridViewTextBoxColumn
            // 
            this.dESCRICAOITEMPEDDataGridViewTextBoxColumn.DataPropertyName = "DESCRICAO_ITEM_PED";
            this.dESCRICAOITEMPEDDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.dESCRICAOITEMPEDDataGridViewTextBoxColumn.Name = "dESCRICAOITEMPEDDataGridViewTextBoxColumn";
            this.dESCRICAOITEMPEDDataGridViewTextBoxColumn.Width = 155;
            // 
            // col_qtde
            // 
            this.col_qtde.DataPropertyName = "QTDE_ITEM_PED";
            this.col_qtde.HeaderText = "Qtde";
            this.col_qtde.Name = "col_qtde";
            this.col_qtde.Width = 40;
            // 
            // uNIDITEMPEDDataGridViewTextBoxColumn
            // 
            this.uNIDITEMPEDDataGridViewTextBoxColumn.DataPropertyName = "UNID_ITEM_PED";
            this.uNIDITEMPEDDataGridViewTextBoxColumn.HeaderText = "Unid.";
            this.uNIDITEMPEDDataGridViewTextBoxColumn.Name = "uNIDITEMPEDDataGridViewTextBoxColumn";
            this.uNIDITEMPEDDataGridViewTextBoxColumn.Width = 40;
            // 
            // col_valor_unit
            // 
            this.col_valor_unit.DataPropertyName = "VALOR_UNIT_ITEM_PED";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.col_valor_unit.DefaultCellStyle = dataGridViewCellStyle2;
            this.col_valor_unit.HeaderText = "Valor Unit.";
            this.col_valor_unit.Name = "col_valor_unit";
            this.col_valor_unit.Width = 90;
            // 
            // col_valor_total
            // 
            this.col_valor_total.DataPropertyName = "VALOR_TOTAL_ITEM_PED";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.col_valor_total.DefaultCellStyle = dataGridViewCellStyle3;
            this.col_valor_total.HeaderText = "Valor Total";
            this.col_valor_total.Name = "col_valor_total";
            this.col_valor_total.Width = 90;
            // 
            // Req
            // 
            this.Req.HeaderText = "Req";
            this.Req.Name = "Req";
            this.Req.Text = "Req";
            this.Req.ToolTipText = "Req";
            this.Req.UseColumnTextForButtonValue = true;
            this.Req.Width = 50;
            // 
            // dATALIMITEITEMPEDDataGridViewTextBoxColumn
            // 
            this.dATALIMITEITEMPEDDataGridViewTextBoxColumn.DataPropertyName = "DATA_LIMITE_ITEM_PED";
            this.dATALIMITEITEMPEDDataGridViewTextBoxColumn.HeaderText = "Data Limite ";
            this.dATALIMITEITEMPEDDataGridViewTextBoxColumn.Name = "dATALIMITEITEMPEDDataGridViewTextBoxColumn";
            // 
            // oPITEMPEDDataGridViewTextBoxColumn
            // 
            this.oPITEMPEDDataGridViewTextBoxColumn.DataPropertyName = "OP_ITEM_PED";
            this.oPITEMPEDDataGridViewTextBoxColumn.HeaderText = "OP";
            this.oPITEMPEDDataGridViewTextBoxColumn.Name = "oPITEMPEDDataGridViewTextBoxColumn";
            // 
            // col_chegou
            // 
            this.col_chegou.DataPropertyName = "CHEGOU_ITEM_PED";
            this.col_chegou.FalseValue = "0";
            this.col_chegou.HeaderText = "Chegou?";
            this.col_chegou.IndeterminateValue = "0";
            this.col_chegou.Name = "col_chegou";
            this.col_chegou.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_chegou.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_chegou.TrueValue = "1";
            this.col_chegou.Width = 40;
            // 
            // col_nf_entrada
            // 
            this.col_nf_entrada.DataPropertyName = "COD_NF_ENTRADA_ITEM_PED";
            this.col_nf_entrada.HeaderText = "Cód. NF Entrada";
            this.col_nf_entrada.Name = "col_nf_entrada";
            // 
            // DATA_CHEGADA_ITEM_PED
            // 
            this.DATA_CHEGADA_ITEM_PED.DataPropertyName = "DATA_CHEGADA_ITEM_PED";
            this.DATA_CHEGADA_ITEM_PED.HeaderText = "Data Chegada";
            this.DATA_CHEGADA_ITEM_PED.Name = "DATA_CHEGADA_ITEM_PED";
            // 
            // form_pesquisa_itens_pedidos_compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 647);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvItens_ped);
            this.Name = "form_pesquisa_itens_pedidos_compra";
            this.Text = "Pesquisa itens pedido de compra";
            this.Load += new System.EventHandler(this.form_pesquisa_itens_pedidos_compra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsItens_ped)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITENS_PEDIDO_COMPRA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens_ped)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAno)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datItens_ped;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Data.DataSet dsItens_ped;
        private System.Data.DataTable ITENS_PEDIDO_COMPRA;
        private System.Data.DataColumn COD_ITEM_PED;
        private System.Data.DataColumn N_PEDIDO_ITEM_PED;
        private System.Data.DataColumn COD_ITEM_REQ_ITEM_PED;
        private System.Data.DataColumn OP_ITEM_PED;
        private System.Data.DataColumn QTDE_ITEM_PED;
        private System.Data.DataColumn UNID_ITEM_PED;
        private System.Data.DataColumn VALOR_UNIT_ITEM_PED;
        private System.Data.DataColumn VALOR_TOTAL_ITEM_PED;
        private System.Data.DataColumn DESCRICAO_ITEM_PED;
        private System.Data.DataColumn DATA_LIMITE_ITEM_PED;
        private System.Data.DataColumn COD_ESTOQUE_ITEM_PED;
        private System.Data.DataColumn POSICAO_ITEM_PED;
        private System.Data.DataColumn PESO_ITEM_PED;
        private System.Data.DataColumn CHEGOU_ITEM_PED;
        private System.Data.DataColumn COD_NF_ENTRADA_ITEM_PED;
        private System.Data.DataColumn DATA_ENTRADA_ITEM_PED;
        private System.Data.DataColumn PLANO_ITEM_PED;
        private System.Data.DataColumn ITEM_ITEM_PED;
        private System.Data.DataColumn FORNECEDOR_ITEM_PED;
        private System.Windows.Forms.DataGridView dgvItens_ped;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_cod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_descricao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTermino;
        private System.Windows.Forms.DateTimePicker dtTermino;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.TextBox tb_nome_forn;
        private System.Windows.Forms.TextBox tb_cnpj_forn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_item;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tb_valor_total;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox cbxTrimestre;
        private System.Windows.Forms.NumericUpDown nudAno;
        private System.Windows.Forms.RadioButton rdbTrimestre;
        private System.Windows.Forms.RadioButton rdbPeriodo;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridViewButtonColumn OK;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn nPEDIDOITEMPEDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_item_req;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod_estoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRICAOITEMPEDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_qtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn uNIDITEMPEDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_valor_unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_valor_total;
        private System.Windows.Forms.DataGridViewButtonColumn Req;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATALIMITEITEMPEDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPITEMPEDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_chegou;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nf_entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA_CHEGADA_ITEM_PED;
    }
}