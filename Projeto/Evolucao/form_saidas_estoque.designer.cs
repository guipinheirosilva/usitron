namespace Evolucao
{
    partial class form_saidas_estoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_saidas_estoque));
            this.label28 = new System.Windows.Forms.Label();
            this.bt_localizar_item = new System.Windows.Forms.Button();
            this.datEstoque = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsEstoque = new System.Data.DataSet();
            this.ESTOQUE = new System.Data.DataTable();
            this.COD_ESTOQUE = new System.Data.DataColumn();
            this.ITEM_ESTOQUE = new System.Data.DataColumn();
            this.DESCRICAO_ESTOQUE = new System.Data.DataColumn();
            this.GRUPO_ESTOQUE = new System.Data.DataColumn();
            this.CLIENTE_ESTOQUE = new System.Data.DataColumn();
            this.MATERIAL_ESTOQUE = new System.Data.DataColumn();
            this.DIMENSAO_ESTOQUE = new System.Data.DataColumn();
            this.PRAZO_MEDIO_ESTOQUE = new System.Data.DataColumn();
            this.LOCALIZACAO_ESTOQUE = new System.Data.DataColumn();
            this.ESPESSURA_ESTOQUE = new System.Data.DataColumn();
            this.ESTOQUE_MINIMO_ESTOQUE = new System.Data.DataColumn();
            this.ESTOQUE_ATUAL_ESTOQUE = new System.Data.DataColumn();
            this.CHAPA_ESTOQUE = new System.Data.DataColumn();
            this.COD_BARRAS_ITEM_FABRICANTE = new System.Data.DataColumn();
            this.MARCA_ESTOQUE = new System.Data.DataColumn();
            this.OBSERVACOES_ESTOQUE = new System.Data.DataColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_descricao_item = new System.Windows.Forms.TextBox();
            this.tb_item_item = new System.Windows.Forms.TextBox();
            this.tb_cod_item = new System.Windows.Forms.TextBox();
            this.tb_cracha = new System.Windows.Forms.TextBox();
            this.tb_qtde_saida = new System.Windows.Forms.TextBox();
            this.bt_adicionar_item = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cODESTOQUESAIDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODITEMESTOQUESAIDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTEMESTOQUESAIDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qTDEESTOQUESAIDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRACHAESTOQUESAIDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OS_ESTOQUE_SAIDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPESTOQUESAIDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAESTOQUESAIDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsSaida_estoque = new System.Data.DataSet();
            this.ESTOQUE_SAIDA = new System.Data.DataTable();
            this.COD_ESTOQUE_SAIDA = new System.Data.DataColumn();
            this.ITEM_ESTOQUE_SAIDA = new System.Data.DataColumn();
            this.COD_ITEM_ESTOQUE_SAIDA = new System.Data.DataColumn();
            this.QTDE_ESTOQUE_SAIDA = new System.Data.DataColumn();
            this.CRACHA_ESTOQUE_SAIDA = new System.Data.DataColumn();
            this.OP_ESTOQUE_SAIDA = new System.Data.DataColumn();
            this.DATA_ESTOQUE_SAIDA = new System.Data.DataColumn();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.datSaida_estoque = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand8 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand6 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand5 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand7 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_data = new System.Windows.Forms.TextBox();
            this.tb_op = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_qtde_item = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dsEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ESTOQUE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSaida_estoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ESTOQUE_SAIDA)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label28.Location = new System.Drawing.Point(151, 9);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(384, 42);
            this.label28.TabIndex = 135;
            this.label28.Text = "SAÍDA DE ESTOQUE";
            // 
            // bt_localizar_item
            // 
            this.bt_localizar_item.Location = new System.Drawing.Point(14, 11);
            this.bt_localizar_item.Name = "bt_localizar_item";
            this.bt_localizar_item.Size = new System.Drawing.Size(63, 44);
            this.bt_localizar_item.TabIndex = 1;
            this.bt_localizar_item.Text = "Localizar Item";
            this.bt_localizar_item.UseVisualStyleBackColor = true;
            this.bt_localizar_item.Click += new System.EventHandler(this.bt_localizar_item_Click);
            // 
            // datEstoque
            // 
            this.datEstoque.DeleteCommand = this.fbCommand4;
            this.datEstoque.InsertCommand = this.fbCommand2;
            this.datEstoque.SelectCommand = this.fbCommand1;
            this.datEstoque.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * from estoque";
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
            // dsEstoque
            // 
            this.dsEstoque.DataSetName = "dsEstoque";
            this.dsEstoque.Namespace = "http://www.tempuri.org/dsEstoque.xsd";
            this.dsEstoque.Tables.AddRange(new System.Data.DataTable[] {
            this.ESTOQUE});
            // 
            // ESTOQUE
            // 
            this.ESTOQUE.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_ESTOQUE,
            this.ITEM_ESTOQUE,
            this.DESCRICAO_ESTOQUE,
            this.GRUPO_ESTOQUE,
            this.CLIENTE_ESTOQUE,
            this.MATERIAL_ESTOQUE,
            this.DIMENSAO_ESTOQUE,
            this.PRAZO_MEDIO_ESTOQUE,
            this.LOCALIZACAO_ESTOQUE,
            this.ESPESSURA_ESTOQUE,
            this.ESTOQUE_MINIMO_ESTOQUE,
            this.ESTOQUE_ATUAL_ESTOQUE,
            this.CHAPA_ESTOQUE,
            this.COD_BARRAS_ITEM_FABRICANTE,
            this.MARCA_ESTOQUE,
            this.OBSERVACOES_ESTOQUE});
            this.ESTOQUE.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_ESTOQUE"}, true)});
            this.ESTOQUE.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_ESTOQUE};
            this.ESTOQUE.TableName = "ESTOQUE";
            // 
            // COD_ESTOQUE
            // 
            this.COD_ESTOQUE.AllowDBNull = false;
            this.COD_ESTOQUE.ColumnName = "COD_ESTOQUE";
            this.COD_ESTOQUE.DataType = typeof(int);
            // 
            // ITEM_ESTOQUE
            // 
            this.ITEM_ESTOQUE.ColumnName = "ITEM_ESTOQUE";
            this.ITEM_ESTOQUE.MaxLength = 100;
            // 
            // DESCRICAO_ESTOQUE
            // 
            this.DESCRICAO_ESTOQUE.ColumnName = "DESCRICAO_ESTOQUE";
            this.DESCRICAO_ESTOQUE.MaxLength = 100;
            // 
            // GRUPO_ESTOQUE
            // 
            this.GRUPO_ESTOQUE.ColumnName = "GRUPO_ESTOQUE";
            this.GRUPO_ESTOQUE.MaxLength = 100;
            // 
            // CLIENTE_ESTOQUE
            // 
            this.CLIENTE_ESTOQUE.ColumnName = "CLIENTE_ESTOQUE";
            this.CLIENTE_ESTOQUE.MaxLength = 100;
            // 
            // MATERIAL_ESTOQUE
            // 
            this.MATERIAL_ESTOQUE.ColumnName = "MATERIAL_ESTOQUE";
            this.MATERIAL_ESTOQUE.MaxLength = 100;
            // 
            // DIMENSAO_ESTOQUE
            // 
            this.DIMENSAO_ESTOQUE.ColumnName = "DIMENSAO_ESTOQUE";
            this.DIMENSAO_ESTOQUE.MaxLength = 100;
            // 
            // PRAZO_MEDIO_ESTOQUE
            // 
            this.PRAZO_MEDIO_ESTOQUE.ColumnName = "PRAZO_MEDIO_ESTOQUE";
            this.PRAZO_MEDIO_ESTOQUE.DataType = typeof(int);
            // 
            // LOCALIZACAO_ESTOQUE
            // 
            this.LOCALIZACAO_ESTOQUE.ColumnName = "LOCALIZACAO_ESTOQUE";
            this.LOCALIZACAO_ESTOQUE.MaxLength = 50;
            // 
            // ESPESSURA_ESTOQUE
            // 
            this.ESPESSURA_ESTOQUE.ColumnName = "ESPESSURA_ESTOQUE";
            this.ESPESSURA_ESTOQUE.MaxLength = 10;
            // 
            // ESTOQUE_MINIMO_ESTOQUE
            // 
            this.ESTOQUE_MINIMO_ESTOQUE.ColumnName = "ESTOQUE_MINIMO_ESTOQUE";
            this.ESTOQUE_MINIMO_ESTOQUE.DataType = typeof(double);
            // 
            // ESTOQUE_ATUAL_ESTOQUE
            // 
            this.ESTOQUE_ATUAL_ESTOQUE.ColumnName = "ESTOQUE_ATUAL_ESTOQUE";
            this.ESTOQUE_ATUAL_ESTOQUE.DataType = typeof(double);
            // 
            // CHAPA_ESTOQUE
            // 
            this.CHAPA_ESTOQUE.ColumnName = "CHAPA_ESTOQUE";
            this.CHAPA_ESTOQUE.DataType = typeof(int);
            // 
            // COD_BARRAS_ITEM_FABRICANTE
            // 
            this.COD_BARRAS_ITEM_FABRICANTE.ColumnName = "COD_BARRAS_ITEM_FABRICANTE";
            this.COD_BARRAS_ITEM_FABRICANTE.MaxLength = 100;
            // 
            // MARCA_ESTOQUE
            // 
            this.MARCA_ESTOQUE.ColumnName = "MARCA_ESTOQUE";
            this.MARCA_ESTOQUE.MaxLength = 100;
            // 
            // OBSERVACOES_ESTOQUE
            // 
            this.OBSERVACOES_ESTOQUE.ColumnName = "OBSERVACOES_ESTOQUE";
            this.OBSERVACOES_ESTOQUE.MaxLength = 200;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(298, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 141;
            this.label7.Text = "Descrição";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(189, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 140;
            this.label6.Text = "Item";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(106, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 139;
            this.label5.Text = "Cód.";
            // 
            // tb_descricao_item
            // 
            this.tb_descricao_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_descricao_item.Location = new System.Drawing.Point(298, 27);
            this.tb_descricao_item.Name = "tb_descricao_item";
            this.tb_descricao_item.Size = new System.Drawing.Size(204, 20);
            this.tb_descricao_item.TabIndex = 9;
            // 
            // tb_item_item
            // 
            this.tb_item_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_item_item.Location = new System.Drawing.Point(189, 27);
            this.tb_item_item.Name = "tb_item_item";
            this.tb_item_item.Size = new System.Drawing.Size(103, 20);
            this.tb_item_item.TabIndex = 8;
            // 
            // tb_cod_item
            // 
            this.tb_cod_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cod_item.Location = new System.Drawing.Point(109, 27);
            this.tb_cod_item.Name = "tb_cod_item";
            this.tb_cod_item.Size = new System.Drawing.Size(74, 20);
            this.tb_cod_item.TabIndex = 2;
            this.tb_cod_item.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_cod_item_KeyPress);
            // 
            // tb_cracha
            // 
            this.tb_cracha.Location = new System.Drawing.Point(225, 29);
            this.tb_cracha.Name = "tb_cracha";
            this.tb_cracha.Size = new System.Drawing.Size(110, 20);
            this.tb_cracha.TabIndex = 4;
            // 
            // tb_qtde_saida
            // 
            this.tb_qtde_saida.Location = new System.Drawing.Point(109, 29);
            this.tb_qtde_saida.Name = "tb_qtde_saida";
            this.tb_qtde_saida.Size = new System.Drawing.Size(110, 20);
            this.tb_qtde_saida.TabIndex = 3;
            // 
            // bt_adicionar_item
            // 
            this.bt_adicionar_item.Location = new System.Drawing.Point(13, 12);
            this.bt_adicionar_item.Name = "bt_adicionar_item";
            this.bt_adicionar_item.Size = new System.Drawing.Size(63, 51);
            this.bt_adicionar_item.TabIndex = 7;
            this.bt_adicionar_item.Text = "Remover Item do Estoque";
            this.bt_adicionar_item.UseVisualStyleBackColor = true;
            this.bt_adicionar_item.Click += new System.EventHandler(this.bt_adicionar_item_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(222, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 155;
            this.label13.Text = "Crachá";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(106, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 154;
            this.label12.Text = "Quantidade";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODESTOQUESAIDADataGridViewTextBoxColumn,
            this.cODITEMESTOQUESAIDADataGridViewTextBoxColumn,
            this.iTEMESTOQUESAIDADataGridViewTextBoxColumn,
            this.qTDEESTOQUESAIDADataGridViewTextBoxColumn,
            this.cRACHAESTOQUESAIDADataGridViewTextBoxColumn,
            this.OS_ESTOQUE_SAIDA,
            this.oPESTOQUESAIDADataGridViewTextBoxColumn,
            this.dATAESTOQUESAIDADataGridViewTextBoxColumn});
            this.dataGridView1.DataMember = "ESTOQUE_SAIDA";
            this.dataGridView1.DataSource = this.dsSaida_estoque;
            this.dataGridView1.Location = new System.Drawing.Point(14, 211);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(651, 330);
            this.dataGridView1.TabIndex = 156;
            // 
            // cODESTOQUESAIDADataGridViewTextBoxColumn
            // 
            this.cODESTOQUESAIDADataGridViewTextBoxColumn.DataPropertyName = "COD_ESTOQUE_SAIDA";
            this.cODESTOQUESAIDADataGridViewTextBoxColumn.HeaderText = "COD_ESTOQUE_SAIDA";
            this.cODESTOQUESAIDADataGridViewTextBoxColumn.Name = "cODESTOQUESAIDADataGridViewTextBoxColumn";
            this.cODESTOQUESAIDADataGridViewTextBoxColumn.Visible = false;
            // 
            // cODITEMESTOQUESAIDADataGridViewTextBoxColumn
            // 
            this.cODITEMESTOQUESAIDADataGridViewTextBoxColumn.DataPropertyName = "COD_ITEM_ESTOQUE_SAIDA";
            this.cODITEMESTOQUESAIDADataGridViewTextBoxColumn.HeaderText = "Cod Item";
            this.cODITEMESTOQUESAIDADataGridViewTextBoxColumn.Name = "cODITEMESTOQUESAIDADataGridViewTextBoxColumn";
            // 
            // iTEMESTOQUESAIDADataGridViewTextBoxColumn
            // 
            this.iTEMESTOQUESAIDADataGridViewTextBoxColumn.DataPropertyName = "ITEM_ESTOQUE_SAIDA";
            this.iTEMESTOQUESAIDADataGridViewTextBoxColumn.HeaderText = "Item";
            this.iTEMESTOQUESAIDADataGridViewTextBoxColumn.Name = "iTEMESTOQUESAIDADataGridViewTextBoxColumn";
            // 
            // qTDEESTOQUESAIDADataGridViewTextBoxColumn
            // 
            this.qTDEESTOQUESAIDADataGridViewTextBoxColumn.DataPropertyName = "QTDE_ESTOQUE_SAIDA";
            this.qTDEESTOQUESAIDADataGridViewTextBoxColumn.HeaderText = "Qtde";
            this.qTDEESTOQUESAIDADataGridViewTextBoxColumn.Name = "qTDEESTOQUESAIDADataGridViewTextBoxColumn";
            // 
            // cRACHAESTOQUESAIDADataGridViewTextBoxColumn
            // 
            this.cRACHAESTOQUESAIDADataGridViewTextBoxColumn.DataPropertyName = "CRACHA_ESTOQUE_SAIDA";
            this.cRACHAESTOQUESAIDADataGridViewTextBoxColumn.HeaderText = "Crachá";
            this.cRACHAESTOQUESAIDADataGridViewTextBoxColumn.Name = "cRACHAESTOQUESAIDADataGridViewTextBoxColumn";
            // 
            // OS_ESTOQUE_SAIDA
            // 
            this.OS_ESTOQUE_SAIDA.DataPropertyName = "OS_ESTOQUE_SAIDA";
            this.OS_ESTOQUE_SAIDA.HeaderText = "OP";
            this.OS_ESTOQUE_SAIDA.Name = "OS_ESTOQUE_SAIDA";
            // 
            // oPESTOQUESAIDADataGridViewTextBoxColumn
            // 
            this.oPESTOQUESAIDADataGridViewTextBoxColumn.DataPropertyName = "OP_ESTOQUE_SAIDA";
            this.oPESTOQUESAIDADataGridViewTextBoxColumn.HeaderText = "OP";
            this.oPESTOQUESAIDADataGridViewTextBoxColumn.Name = "oPESTOQUESAIDADataGridViewTextBoxColumn";
            this.oPESTOQUESAIDADataGridViewTextBoxColumn.Visible = false;
            // 
            // dATAESTOQUESAIDADataGridViewTextBoxColumn
            // 
            this.dATAESTOQUESAIDADataGridViewTextBoxColumn.DataPropertyName = "DATA_ESTOQUE_SAIDA";
            this.dATAESTOQUESAIDADataGridViewTextBoxColumn.HeaderText = "Data";
            this.dATAESTOQUESAIDADataGridViewTextBoxColumn.Name = "dATAESTOQUESAIDADataGridViewTextBoxColumn";
            // 
            // dsSaida_estoque
            // 
            this.dsSaida_estoque.DataSetName = "dsSaida_estoque";
            this.dsSaida_estoque.Namespace = "http://www.tempuri.org/dsSaida_estoque.xsd";
            this.dsSaida_estoque.Tables.AddRange(new System.Data.DataTable[] {
            this.ESTOQUE_SAIDA});
            // 
            // ESTOQUE_SAIDA
            // 
            this.ESTOQUE_SAIDA.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_ESTOQUE_SAIDA,
            this.ITEM_ESTOQUE_SAIDA,
            this.COD_ITEM_ESTOQUE_SAIDA,
            this.QTDE_ESTOQUE_SAIDA,
            this.CRACHA_ESTOQUE_SAIDA,
            this.OP_ESTOQUE_SAIDA,
            this.DATA_ESTOQUE_SAIDA,
            this.dataColumn1,
            this.dataColumn2});
            this.ESTOQUE_SAIDA.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_ESTOQUE_SAIDA"}, true)});
            this.ESTOQUE_SAIDA.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_ESTOQUE_SAIDA};
            this.ESTOQUE_SAIDA.TableName = "ESTOQUE_SAIDA";
            // 
            // COD_ESTOQUE_SAIDA
            // 
            this.COD_ESTOQUE_SAIDA.AllowDBNull = false;
            this.COD_ESTOQUE_SAIDA.ColumnName = "COD_ESTOQUE_SAIDA";
            this.COD_ESTOQUE_SAIDA.DataType = typeof(int);
            // 
            // ITEM_ESTOQUE_SAIDA
            // 
            this.ITEM_ESTOQUE_SAIDA.ColumnName = "ITEM_ESTOQUE_SAIDA";
            this.ITEM_ESTOQUE_SAIDA.MaxLength = 100;
            // 
            // COD_ITEM_ESTOQUE_SAIDA
            // 
            this.COD_ITEM_ESTOQUE_SAIDA.ColumnName = "COD_ITEM_ESTOQUE_SAIDA";
            this.COD_ITEM_ESTOQUE_SAIDA.DataType = typeof(int);
            // 
            // QTDE_ESTOQUE_SAIDA
            // 
            this.QTDE_ESTOQUE_SAIDA.ColumnName = "QTDE_ESTOQUE_SAIDA";
            this.QTDE_ESTOQUE_SAIDA.DataType = typeof(double);
            // 
            // CRACHA_ESTOQUE_SAIDA
            // 
            this.CRACHA_ESTOQUE_SAIDA.ColumnName = "CRACHA_ESTOQUE_SAIDA";
            this.CRACHA_ESTOQUE_SAIDA.DataType = typeof(int);
            // 
            // OP_ESTOQUE_SAIDA
            // 
            this.OP_ESTOQUE_SAIDA.ColumnName = "OP_ESTOQUE_SAIDA";
            this.OP_ESTOQUE_SAIDA.MaxLength = 100;
            // 
            // DATA_ESTOQUE_SAIDA
            // 
            this.DATA_ESTOQUE_SAIDA.ColumnName = "DATA_ESTOQUE_SAIDA";
            this.DATA_ESTOQUE_SAIDA.DataType = typeof(System.DateTime);
            // 
            // dataColumn1
            // 
            this.dataColumn1.Caption = "LOTE_ESTOQUE_SAIDA";
            this.dataColumn1.ColumnName = "LOTE_ESTOQUE_SAIDA";
            this.dataColumn1.DataType = typeof(int);
            // 
            // dataColumn2
            // 
            this.dataColumn2.Caption = "OS_ESTOQUE_SAIDA";
            this.dataColumn2.ColumnName = "OS_ESTOQUE_SAIDA";
            this.dataColumn2.MaxLength = 200;
            // 
            // datSaida_estoque
            // 
            this.datSaida_estoque.DeleteCommand = this.fbCommand8;
            this.datSaida_estoque.InsertCommand = this.fbCommand6;
            this.datSaida_estoque.SelectCommand = this.fbCommand5;
            this.datSaida_estoque.UpdateCommand = this.fbCommand7;
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
            this.fbCommand5.CommandText = "select * from estoque_saida";
            this.fbCommand5.CommandTimeout = 30;
            this.fbCommand5.Connection = this.fbConnection1;
            // 
            // fbCommand7
            // 
            this.fbCommand7.CommandTimeout = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(454, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 160;
            this.label1.Text = "Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(338, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 159;
            this.label2.Text = "OP";
            // 
            // tb_data
            // 
            this.tb_data.Location = new System.Drawing.Point(457, 28);
            this.tb_data.Name = "tb_data";
            this.tb_data.Size = new System.Drawing.Size(110, 20);
            this.tb_data.TabIndex = 6;
            // 
            // tb_op
            // 
            this.tb_op.Location = new System.Drawing.Point(341, 28);
            this.tb_op.Name = "tb_op";
            this.tb_op.Size = new System.Drawing.Size(110, 20);
            this.tb_op.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tb_qtde_item);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tb_descricao_item);
            this.panel1.Controls.Add(this.tb_item_item);
            this.panel1.Controls.Add(this.tb_cod_item);
            this.panel1.Controls.Add(this.bt_localizar_item);
            this.panel1.Location = new System.Drawing.Point(10, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 72);
            this.panel1.TabIndex = 161;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(508, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 143;
            this.label3.Text = "Qtde Disponível";
            // 
            // tb_qtde_item
            // 
            this.tb_qtde_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_qtde_item.Location = new System.Drawing.Point(508, 27);
            this.tb_qtde_item.Name = "tb_qtde_item";
            this.tb_qtde_item.Size = new System.Drawing.Size(103, 20);
            this.tb_qtde_item.TabIndex = 142;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tb_data);
            this.panel2.Controls.Add(this.tb_op);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.tb_cracha);
            this.panel2.Controls.Add(this.tb_qtde_saida);
            this.panel2.Controls.Add(this.bt_adicionar_item);
            this.panel2.Location = new System.Drawing.Point(10, 129);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(655, 72);
            this.panel2.TabIndex = 162;
            // 
            // form_saidas_estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 553);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label28);
            this.Name = "form_saidas_estoque";
            this.Text = "Saída de Estoque";
            this.Load += new System.EventHandler(this.form_saidas_estoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ESTOQUE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSaida_estoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ESTOQUE_SAIDA)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button bt_localizar_item;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datEstoque;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Data.DataSet dsEstoque;
        private System.Data.DataTable ESTOQUE;
        private System.Data.DataColumn COD_ESTOQUE;
        private System.Data.DataColumn ITEM_ESTOQUE;
        private System.Data.DataColumn DESCRICAO_ESTOQUE;
        private System.Data.DataColumn GRUPO_ESTOQUE;
        private System.Data.DataColumn CLIENTE_ESTOQUE;
        private System.Data.DataColumn MATERIAL_ESTOQUE;
        private System.Data.DataColumn DIMENSAO_ESTOQUE;
        private System.Data.DataColumn PRAZO_MEDIO_ESTOQUE;
        private System.Data.DataColumn LOCALIZACAO_ESTOQUE;
        private System.Data.DataColumn ESPESSURA_ESTOQUE;
        private System.Data.DataColumn ESTOQUE_MINIMO_ESTOQUE;
        private System.Data.DataColumn ESTOQUE_ATUAL_ESTOQUE;
        private System.Data.DataColumn CHAPA_ESTOQUE;
        private System.Data.DataColumn COD_BARRAS_ITEM_FABRICANTE;
        private System.Data.DataColumn MARCA_ESTOQUE;
        private System.Data.DataColumn OBSERVACOES_ESTOQUE;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_descricao_item;
        private System.Windows.Forms.TextBox tb_item_item;
        private System.Windows.Forms.TextBox tb_cod_item;
        private System.Windows.Forms.TextBox tb_cracha;
        private System.Windows.Forms.TextBox tb_qtde_saida;
        private System.Windows.Forms.Button bt_adicionar_item;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Data.DataSet dsSaida_estoque;
        private System.Data.DataTable ESTOQUE_SAIDA;
        private System.Data.DataColumn COD_ESTOQUE_SAIDA;
        private System.Data.DataColumn ITEM_ESTOQUE_SAIDA;
        private System.Data.DataColumn COD_ITEM_ESTOQUE_SAIDA;
        private System.Data.DataColumn QTDE_ESTOQUE_SAIDA;
        private System.Data.DataColumn CRACHA_ESTOQUE_SAIDA;
        private System.Data.DataColumn OP_ESTOQUE_SAIDA;
        private System.Data.DataColumn DATA_ESTOQUE_SAIDA;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datSaida_estoque;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand8;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand6;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand5;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_data;
        private System.Windows.Forms.TextBox tb_op;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_qtde_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODESTOQUESAIDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODITEMESTOQUESAIDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTEMESTOQUESAIDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qTDEESTOQUESAIDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRACHAESTOQUESAIDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OS_ESTOQUE_SAIDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPESTOQUESAIDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAESTOQUESAIDADataGridViewTextBoxColumn;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
    }
}