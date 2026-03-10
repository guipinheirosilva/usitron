namespace Evolucao
{
    partial class form_pesquisa_requisicao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_pesquisa_requisicao));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.datItens_req = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand8 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand6 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand5 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand7 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsItens_req = new System.Data.DataSet();
            this.ITENS_REQUISICAO = new System.Data.DataTable();
            this.COD_ITEM_REQ = new System.Data.DataColumn();
            this.COD_REQ_ITEM_REQ = new System.Data.DataColumn();
            this.OP_ITEM_REQ = new System.Data.DataColumn();
            this.QTDE_ITEM_REQ = new System.Data.DataColumn();
            this.UNIDADE_ITEM_REQ = new System.Data.DataColumn();
            this.COD_ESTOQUE_ITEM_REQ = new System.Data.DataColumn();
            this.DESCRICAO_ITEM_REQ = new System.Data.DataColumn();
            this.DATA_LIMITE_ITEM_REQ = new System.Data.DataColumn();
            this.URGENTE_ITEM_REQ = new System.Data.DataColumn();
            this.REQUISITANTE_ITEM_REQ = new System.Data.DataColumn();
            this.SETOR_ITEM_REQ = new System.Data.DataColumn();
            this.DATA_REQUISICAO_ITEM_REQ = new System.Data.DataColumn();
            this.SITUACAO_ATUAL_ITEM_REQ = new System.Data.DataColumn();
            this.AUTORIZADO_POR_ITEM_REQ = new System.Data.DataColumn();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dgvItens_requisicao = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.comando_select = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.tb_item = new System.Windows.Forms.TextBox();
            this.tb_requisicao = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Ok = new System.Windows.Forms.DataGridViewButtonColumn();
            this.col_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_requisicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPITEMREQDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cod_estoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_qtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_unid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATALIMITEITEMREQDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uRGENTEITEMREQDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.rEQUISITANTEITEMREQDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aut = new System.Windows.Forms.DataGridViewButtonColumn();
            this.col_autorizante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sETORITEMREQDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAREQUISICAOITEMREQDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dsItens_req)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITENS_REQUISICAO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens_requisicao)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fbCommand1
            // 
            this.fbCommand1.CommandText = "select * from requisicoes";
            this.fbCommand1.CommandTimeout = 30;
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
            // fbConnection1
            // 
            this.fbConnection1.ConnectionString = resources.GetString("fbConnection1.ConnectionString");
            // 
            // fbCommand7
            // 
            this.fbCommand7.CommandTimeout = 30;
            // 
            // dsItens_req
            // 
            this.dsItens_req.DataSetName = "dsItens_req";
            this.dsItens_req.Namespace = "http://www.tempuri.org/dsItens_req.xsd";
            this.dsItens_req.Tables.AddRange(new System.Data.DataTable[] {
            this.ITENS_REQUISICAO});
            // 
            // ITENS_REQUISICAO
            // 
            this.ITENS_REQUISICAO.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_ITEM_REQ,
            this.COD_REQ_ITEM_REQ,
            this.OP_ITEM_REQ,
            this.QTDE_ITEM_REQ,
            this.UNIDADE_ITEM_REQ,
            this.COD_ESTOQUE_ITEM_REQ,
            this.DESCRICAO_ITEM_REQ,
            this.DATA_LIMITE_ITEM_REQ,
            this.URGENTE_ITEM_REQ,
            this.REQUISITANTE_ITEM_REQ,
            this.SETOR_ITEM_REQ,
            this.DATA_REQUISICAO_ITEM_REQ,
            this.SITUACAO_ATUAL_ITEM_REQ,
            this.AUTORIZADO_POR_ITEM_REQ,
            this.dataColumn1});
            this.ITENS_REQUISICAO.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_ITEM_REQ"}, true)});
            this.ITENS_REQUISICAO.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_ITEM_REQ};
            this.ITENS_REQUISICAO.TableName = "ITENS_REQUISICAO";
            // 
            // COD_ITEM_REQ
            // 
            this.COD_ITEM_REQ.AllowDBNull = false;
            this.COD_ITEM_REQ.ColumnName = "COD_ITEM_REQ";
            this.COD_ITEM_REQ.DataType = typeof(int);
            // 
            // COD_REQ_ITEM_REQ
            // 
            this.COD_REQ_ITEM_REQ.ColumnName = "COD_REQ_ITEM_REQ";
            this.COD_REQ_ITEM_REQ.DataType = typeof(int);
            // 
            // OP_ITEM_REQ
            // 
            this.OP_ITEM_REQ.ColumnName = "OP_ITEM_REQ";
            this.OP_ITEM_REQ.MaxLength = 50;
            // 
            // QTDE_ITEM_REQ
            // 
            this.QTDE_ITEM_REQ.ColumnName = "QTDE_ITEM_REQ";
            this.QTDE_ITEM_REQ.DataType = typeof(double);
            // 
            // UNIDADE_ITEM_REQ
            // 
            this.UNIDADE_ITEM_REQ.ColumnName = "UNIDADE_ITEM_REQ";
            this.UNIDADE_ITEM_REQ.MaxLength = 10;
            // 
            // COD_ESTOQUE_ITEM_REQ
            // 
            this.COD_ESTOQUE_ITEM_REQ.ColumnName = "COD_ESTOQUE_ITEM_REQ";
            this.COD_ESTOQUE_ITEM_REQ.DataType = typeof(int);
            // 
            // DESCRICAO_ITEM_REQ
            // 
            this.DESCRICAO_ITEM_REQ.ColumnName = "DESCRICAO_ITEM_REQ";
            this.DESCRICAO_ITEM_REQ.MaxLength = 200;
            // 
            // DATA_LIMITE_ITEM_REQ
            // 
            this.DATA_LIMITE_ITEM_REQ.ColumnName = "DATA_LIMITE_ITEM_REQ";
            this.DATA_LIMITE_ITEM_REQ.DataType = typeof(System.DateTime);
            // 
            // URGENTE_ITEM_REQ
            // 
            this.URGENTE_ITEM_REQ.ColumnName = "URGENTE_ITEM_REQ";
            this.URGENTE_ITEM_REQ.DataType = typeof(int);
            // 
            // REQUISITANTE_ITEM_REQ
            // 
            this.REQUISITANTE_ITEM_REQ.ColumnName = "REQUISITANTE_ITEM_REQ";
            this.REQUISITANTE_ITEM_REQ.MaxLength = 100;
            // 
            // SETOR_ITEM_REQ
            // 
            this.SETOR_ITEM_REQ.ColumnName = "SETOR_ITEM_REQ";
            this.SETOR_ITEM_REQ.MaxLength = 100;
            // 
            // DATA_REQUISICAO_ITEM_REQ
            // 
            this.DATA_REQUISICAO_ITEM_REQ.ColumnName = "DATA_REQUISICAO_ITEM_REQ";
            this.DATA_REQUISICAO_ITEM_REQ.DataType = typeof(System.DateTime);
            // 
            // SITUACAO_ATUAL_ITEM_REQ
            // 
            this.SITUACAO_ATUAL_ITEM_REQ.ColumnName = "SITUACAO_ATUAL_ITEM_REQ";
            this.SITUACAO_ATUAL_ITEM_REQ.MaxLength = 50;
            // 
            // AUTORIZADO_POR_ITEM_REQ
            // 
            this.AUTORIZADO_POR_ITEM_REQ.ColumnName = "AUTORIZADO_POR_ITEM_REQ";
            this.AUTORIZADO_POR_ITEM_REQ.MaxLength = 50;
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "ITEM_ITEM_REQ";
            this.dataColumn1.MaxLength = 200;
            // 
            // dgvItens_requisicao
            // 
            this.dgvItens_requisicao.AllowUserToAddRows = false;
            this.dgvItens_requisicao.AllowUserToDeleteRows = false;
            this.dgvItens_requisicao.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItens_requisicao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItens_requisicao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens_requisicao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ok,
            this.col_cod,
            this.col_requisicao,
            this.oPITEMREQDataGridViewTextBoxColumn,
            this.col_cod_estoque,
            this.col_item,
            this.col_descricao,
            this.col_qtde,
            this.col_unid,
            this.dATALIMITEITEMREQDataGridViewTextBoxColumn,
            this.uRGENTEITEMREQDataGridViewTextBoxColumn,
            this.rEQUISITANTEITEMREQDataGridViewTextBoxColumn,
            this.Aut,
            this.col_autorizante,
            this.sETORITEMREQDataGridViewTextBoxColumn,
            this.dATAREQUISICAOITEMREQDataGridViewTextBoxColumn,
            this.col_situacao});
            this.dgvItens_requisicao.DataMember = "ITENS_REQUISICAO";
            this.dgvItens_requisicao.DataSource = this.dsItens_req;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItens_requisicao.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvItens_requisicao.Location = new System.Drawing.Point(12, 128);
            this.dgvItens_requisicao.Name = "dgvItens_requisicao";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItens_requisicao.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvItens_requisicao.Size = new System.Drawing.Size(978, 358);
            this.dgvItens_requisicao.TabIndex = 83;
            this.dgvItens_requisicao.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItens_requisicao_CellContentDoubleClick);
            this.dgvItens_requisicao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItens_requisicao_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 49);
            this.button1.TabIndex = 84;
            this.button1.Text = "Mostrar\r\nTodos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(120, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 49);
            this.button2.TabIndex = 85;
            this.button2.Text = "Mostrar\r\nAutorizados";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(228, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 49);
            this.button3.TabIndex = 86;
            this.button3.Text = "Mostrar\r\nNão Autorizados";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(898, 67);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(57, 34);
            this.button4.TabIndex = 103;
            this.button4.Text = "Autorizar\r\nTodos";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // comando_select
            // 
            this.comando_select.CommandTimeout = 30;
            this.comando_select.Connection = this.fbConnection1;
            // 
            // tb_item
            // 
            this.tb_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_item.Location = new System.Drawing.Point(6, 71);
            this.tb_item.Name = "tb_item";
            this.tb_item.Size = new System.Drawing.Size(208, 23);
            this.tb_item.TabIndex = 104;
            this.tb_item.TextChanged += new System.EventHandler(this.tb_item_TextChanged);
            // 
            // tb_requisicao
            // 
            this.tb_requisicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_requisicao.Location = new System.Drawing.Point(6, 29);
            this.tb_requisicao.Name = "tb_requisicao";
            this.tb_requisicao.Size = new System.Drawing.Size(69, 23);
            this.tb_requisicao.TabIndex = 105;
            this.tb_requisicao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_requisicao_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_requisicao);
            this.groupBox1.Controls.Add(this.tb_item);
            this.groupBox1.Location = new System.Drawing.Point(357, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 99);
            this.groupBox1.TabIndex = 106;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 13);
            this.label2.TabIndex = 107;
            this.label2.Text = "Digite a requisição e tecle <Enter>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 106;
            this.label1.Text = "Digite a descrição:";
            // 
            // Ok
            // 
            this.Ok.HeaderText = "Ok";
            this.Ok.Name = "Ok";
            this.Ok.Text = "Ok";
            this.Ok.ToolTipText = "Ok";
            this.Ok.UseColumnTextForButtonValue = true;
            this.Ok.Width = 50;
            // 
            // col_cod
            // 
            this.col_cod.DataPropertyName = "COD_ITEM_REQ";
            this.col_cod.HeaderText = "Cód Item Req.";
            this.col_cod.Name = "col_cod";
            this.col_cod.Width = 50;
            // 
            // col_requisicao
            // 
            this.col_requisicao.DataPropertyName = "COD_REQ_ITEM_REQ";
            this.col_requisicao.HeaderText = "Requisição";
            this.col_requisicao.Name = "col_requisicao";
            this.col_requisicao.Width = 70;
            // 
            // oPITEMREQDataGridViewTextBoxColumn
            // 
            this.oPITEMREQDataGridViewTextBoxColumn.DataPropertyName = "OP_ITEM_REQ";
            this.oPITEMREQDataGridViewTextBoxColumn.HeaderText = "OS";
            this.oPITEMREQDataGridViewTextBoxColumn.Name = "oPITEMREQDataGridViewTextBoxColumn";
            this.oPITEMREQDataGridViewTextBoxColumn.Width = 70;
            // 
            // col_cod_estoque
            // 
            this.col_cod_estoque.DataPropertyName = "COD_ESTOQUE_ITEM_REQ";
            this.col_cod_estoque.HeaderText = "Código Estoque";
            this.col_cod_estoque.Name = "col_cod_estoque";
            this.col_cod_estoque.Width = 65;
            // 
            // col_item
            // 
            this.col_item.DataPropertyName = "ITEM_ITEM_REQ";
            this.col_item.HeaderText = "Descrição Produto";
            this.col_item.Name = "col_item";
            this.col_item.Width = 135;
            // 
            // col_descricao
            // 
            this.col_descricao.DataPropertyName = "DESCRICAO_ITEM_REQ";
            this.col_descricao.HeaderText = "Descrição Item";
            this.col_descricao.Name = "col_descricao";
            this.col_descricao.Width = 135;
            // 
            // col_qtde
            // 
            this.col_qtde.DataPropertyName = "QTDE_ITEM_REQ";
            this.col_qtde.HeaderText = "Qtde";
            this.col_qtde.Name = "col_qtde";
            this.col_qtde.Width = 70;
            // 
            // col_unid
            // 
            this.col_unid.DataPropertyName = "UNIDADE_ITEM_REQ";
            this.col_unid.HeaderText = "Unidade";
            this.col_unid.Name = "col_unid";
            this.col_unid.Width = 70;
            // 
            // dATALIMITEITEMREQDataGridViewTextBoxColumn
            // 
            this.dATALIMITEITEMREQDataGridViewTextBoxColumn.DataPropertyName = "DATA_LIMITE_ITEM_REQ";
            this.dATALIMITEITEMREQDataGridViewTextBoxColumn.HeaderText = "Data Limite";
            this.dATALIMITEITEMREQDataGridViewTextBoxColumn.Name = "dATALIMITEITEMREQDataGridViewTextBoxColumn";
            // 
            // uRGENTEITEMREQDataGridViewTextBoxColumn
            // 
            this.uRGENTEITEMREQDataGridViewTextBoxColumn.DataPropertyName = "URGENTE_ITEM_REQ";
            this.uRGENTEITEMREQDataGridViewTextBoxColumn.FalseValue = "0";
            this.uRGENTEITEMREQDataGridViewTextBoxColumn.HeaderText = "Urgente";
            this.uRGENTEITEMREQDataGridViewTextBoxColumn.Name = "uRGENTEITEMREQDataGridViewTextBoxColumn";
            this.uRGENTEITEMREQDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.uRGENTEITEMREQDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.uRGENTEITEMREQDataGridViewTextBoxColumn.TrueValue = "1";
            this.uRGENTEITEMREQDataGridViewTextBoxColumn.Width = 50;
            // 
            // rEQUISITANTEITEMREQDataGridViewTextBoxColumn
            // 
            this.rEQUISITANTEITEMREQDataGridViewTextBoxColumn.DataPropertyName = "REQUISITANTE_ITEM_REQ";
            this.rEQUISITANTEITEMREQDataGridViewTextBoxColumn.HeaderText = "REQUISITANTE_ITEM_REQ";
            this.rEQUISITANTEITEMREQDataGridViewTextBoxColumn.Name = "rEQUISITANTEITEMREQDataGridViewTextBoxColumn";
            this.rEQUISITANTEITEMREQDataGridViewTextBoxColumn.Visible = false;
            // 
            // Aut
            // 
            this.Aut.HeaderText = "Aut";
            this.Aut.Name = "Aut";
            this.Aut.Text = "Aut";
            this.Aut.ToolTipText = "Aut";
            this.Aut.UseColumnTextForButtonValue = true;
            this.Aut.Width = 50;
            // 
            // col_autorizante
            // 
            this.col_autorizante.DataPropertyName = "AUTORIZADO_POR_ITEM_REQ";
            this.col_autorizante.HeaderText = "Autorizado por";
            this.col_autorizante.Name = "col_autorizante";
            this.col_autorizante.ReadOnly = true;
            // 
            // sETORITEMREQDataGridViewTextBoxColumn
            // 
            this.sETORITEMREQDataGridViewTextBoxColumn.DataPropertyName = "SETOR_ITEM_REQ";
            this.sETORITEMREQDataGridViewTextBoxColumn.HeaderText = "SETOR_ITEM_REQ";
            this.sETORITEMREQDataGridViewTextBoxColumn.Name = "sETORITEMREQDataGridViewTextBoxColumn";
            this.sETORITEMREQDataGridViewTextBoxColumn.Visible = false;
            // 
            // dATAREQUISICAOITEMREQDataGridViewTextBoxColumn
            // 
            this.dATAREQUISICAOITEMREQDataGridViewTextBoxColumn.DataPropertyName = "DATA_REQUISICAO_ITEM_REQ";
            this.dATAREQUISICAOITEMREQDataGridViewTextBoxColumn.HeaderText = "DATA_REQUISICAO_ITEM_REQ";
            this.dATAREQUISICAOITEMREQDataGridViewTextBoxColumn.Name = "dATAREQUISICAOITEMREQDataGridViewTextBoxColumn";
            this.dATAREQUISICAOITEMREQDataGridViewTextBoxColumn.Visible = false;
            // 
            // col_situacao
            // 
            this.col_situacao.DataPropertyName = "SITUACAO_ATUAL_ITEM_REQ";
            this.col_situacao.HeaderText = "Situação Atual";
            this.col_situacao.Name = "col_situacao";
            this.col_situacao.Width = 250;
            // 
            // form_pesquisa_requisicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 498);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvItens_requisicao);
            this.Name = "form_pesquisa_requisicao";
            this.Text = "Pesquisa Requisição";
            this.Load += new System.EventHandler(this.form_pesquisa_requisicao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsItens_req)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITENS_REQUISICAO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens_requisicao)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datItens_req;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand8;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand6;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand5;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand7;
        private System.Data.DataSet dsItens_req;
        private System.Data.DataTable ITENS_REQUISICAO;
        private System.Data.DataColumn COD_ITEM_REQ;
        private System.Data.DataColumn COD_REQ_ITEM_REQ;
        private System.Data.DataColumn OP_ITEM_REQ;
        private System.Data.DataColumn QTDE_ITEM_REQ;
        private System.Data.DataColumn UNIDADE_ITEM_REQ;
        private System.Data.DataColumn COD_ESTOQUE_ITEM_REQ;
        private System.Data.DataColumn DESCRICAO_ITEM_REQ;
        private System.Data.DataColumn DATA_LIMITE_ITEM_REQ;
        private System.Data.DataColumn URGENTE_ITEM_REQ;
        private System.Data.DataColumn REQUISITANTE_ITEM_REQ;
        private System.Data.DataColumn SETOR_ITEM_REQ;
        private System.Data.DataColumn DATA_REQUISICAO_ITEM_REQ;
        private System.Data.DataColumn SITUACAO_ATUAL_ITEM_REQ;
        private System.Data.DataColumn AUTORIZADO_POR_ITEM_REQ;
        private System.Windows.Forms.DataGridView dgvItens_requisicao;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private FirebirdSql.Data.FirebirdClient.FbCommand comando_select;
        private System.Windows.Forms.TextBox tb_item;
        private System.Windows.Forms.TextBox tb_requisicao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Data.DataColumn dataColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn Ok;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_requisicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPITEMREQDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod_estoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_qtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_unid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATALIMITEITEMREQDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn uRGENTEITEMREQDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEQUISITANTEITEMREQDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Aut;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_autorizante;
        private System.Windows.Forms.DataGridViewTextBoxColumn sETORITEMREQDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAREQUISICAOITEMREQDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_situacao;
    }
}