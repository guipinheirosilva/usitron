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
            this.label11 = new System.Windows.Forms.Label();
            this.tb_qtde_item = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_espessura_item = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_dimensao_item = new System.Windows.Forms.TextBox();
            this.tb_material_item = new System.Windows.Forms.TextBox();
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
            this.datSaida_estoque = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand8 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand6 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand5 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand7 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_data = new System.Windows.Forms.TextBox();
            this.tb_op = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dsEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ESTOQUE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSaida_estoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ESTOQUE_SAIDA)).BeginInit();
            this.SuspendLayout();
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label28.Location = new System.Drawing.Point(12, 9);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(384, 42);
            this.label28.TabIndex = 135;
            this.label28.Text = "SAIDA DE ESTOQUE";
            // 
            // bt_localizar_item
            // 
            this.bt_localizar_item.Location = new System.Drawing.Point(12, 66);
            this.bt_localizar_item.Name = "bt_localizar_item";
            this.bt_localizar_item.Size = new System.Drawing.Size(132, 23);
            this.bt_localizar_item.TabIndex = 123;
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(657, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 149;
            this.label11.Text = "Qtde";
            // 
            // tb_qtde_item
            // 
            this.tb_qtde_item.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsEstoque, "ESTOQUE.ESTOQUE_ATUAL_ESTOQUE", true));
            this.tb_qtde_item.Location = new System.Drawing.Point(660, 105);
            this.tb_qtde_item.Name = "tb_qtde_item";
            this.tb_qtde_item.Size = new System.Drawing.Size(110, 20);
            this.tb_qtde_item.TabIndex = 148;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(541, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 147;
            this.label10.Text = "Espessura";
            // 
            // tb_espessura_item
            // 
            this.tb_espessura_item.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsEstoque, "ESTOQUE.ESPESSURA_ESTOQUE", true));
            this.tb_espessura_item.Location = new System.Drawing.Point(544, 105);
            this.tb_espessura_item.Name = "tb_espessura_item";
            this.tb_espessura_item.Size = new System.Drawing.Size(110, 20);
            this.tb_espessura_item.TabIndex = 146;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(425, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 145;
            this.label8.Text = "Dimensão";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(319, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 144;
            this.label9.Text = "Material";
            // 
            // tb_dimensao_item
            // 
            this.tb_dimensao_item.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsEstoque, "ESTOQUE.DIMENSAO_ESTOQUE", true));
            this.tb_dimensao_item.Location = new System.Drawing.Point(428, 105);
            this.tb_dimensao_item.Name = "tb_dimensao_item";
            this.tb_dimensao_item.Size = new System.Drawing.Size(110, 20);
            this.tb_dimensao_item.TabIndex = 143;
            // 
            // tb_material_item
            // 
            this.tb_material_item.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsEstoque, "ESTOQUE.MATERIAL_ESTOQUE", true));
            this.tb_material_item.Location = new System.Drawing.Point(319, 105);
            this.tb_material_item.Name = "tb_material_item";
            this.tb_material_item.Size = new System.Drawing.Size(103, 20);
            this.tb_material_item.TabIndex = 142;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(199, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 141;
            this.label7.Text = "Descrição";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(93, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 140;
            this.label6.Text = "Item";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 139;
            this.label5.Text = "Cód.";
            // 
            // tb_descricao_item
            // 
            this.tb_descricao_item.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsEstoque, "ESTOQUE.DESCRICAO_ESTOQUE", true));
            this.tb_descricao_item.Location = new System.Drawing.Point(202, 105);
            this.tb_descricao_item.Name = "tb_descricao_item";
            this.tb_descricao_item.Size = new System.Drawing.Size(110, 20);
            this.tb_descricao_item.TabIndex = 138;
            // 
            // tb_item_item
            // 
            this.tb_item_item.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsEstoque, "ESTOQUE.ITEM_ESTOQUE", true));
            this.tb_item_item.Location = new System.Drawing.Point(93, 105);
            this.tb_item_item.Name = "tb_item_item";
            this.tb_item_item.Size = new System.Drawing.Size(103, 20);
            this.tb_item_item.TabIndex = 137;
            // 
            // tb_cod_item
            // 
            this.tb_cod_item.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsEstoque, "ESTOQUE.COD_ESTOQUE", true));
            this.tb_cod_item.Location = new System.Drawing.Point(13, 105);
            this.tb_cod_item.Name = "tb_cod_item";
            this.tb_cod_item.Size = new System.Drawing.Size(74, 20);
            this.tb_cod_item.TabIndex = 136;
            // 
            // tb_cracha
            // 
            this.tb_cracha.Location = new System.Drawing.Point(318, 141);
            this.tb_cracha.Name = "tb_cracha";
            this.tb_cracha.Size = new System.Drawing.Size(110, 20);
            this.tb_cracha.TabIndex = 152;
            // 
            // tb_qtde_saida
            // 
            this.tb_qtde_saida.Location = new System.Drawing.Point(202, 141);
            this.tb_qtde_saida.Name = "tb_qtde_saida";
            this.tb_qtde_saida.Size = new System.Drawing.Size(110, 20);
            this.tb_qtde_saida.TabIndex = 151;
            // 
            // bt_adicionar_item
            // 
            this.bt_adicionar_item.Location = new System.Drawing.Point(14, 138);
            this.bt_adicionar_item.Name = "bt_adicionar_item";
            this.bt_adicionar_item.Size = new System.Drawing.Size(179, 23);
            this.bt_adicionar_item.TabIndex = 150;
            this.bt_adicionar_item.Text = "Remover Item do Estoque";
            this.bt_adicionar_item.UseVisualStyleBackColor = true;
            this.bt_adicionar_item.Click += new System.EventHandler(this.bt_adicionar_item_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(315, 128);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 155;
            this.label13.Text = "Crachá";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(199, 128);
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
            this.oPESTOQUESAIDADataGridViewTextBoxColumn,
            this.dATAESTOQUESAIDADataGridViewTextBoxColumn});
            this.dataGridView1.DataMember = "ESTOQUE_SAIDA";
            this.dataGridView1.DataSource = this.dsSaida_estoque;
            this.dataGridView1.Location = new System.Drawing.Point(14, 171);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(651, 142);
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
            // oPESTOQUESAIDADataGridViewTextBoxColumn
            // 
            this.oPESTOQUESAIDADataGridViewTextBoxColumn.DataPropertyName = "OP_ESTOQUE_SAIDA";
            this.oPESTOQUESAIDADataGridViewTextBoxColumn.HeaderText = "OP";
            this.oPESTOQUESAIDADataGridViewTextBoxColumn.Name = "oPESTOQUESAIDADataGridViewTextBoxColumn";
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
            this.DATA_ESTOQUE_SAIDA});
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
            this.label1.Location = new System.Drawing.Point(547, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 160;
            this.label1.Text = "Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(431, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 159;
            this.label2.Text = "OP";
            // 
            // tb_data
            // 
            this.tb_data.Location = new System.Drawing.Point(550, 140);
            this.tb_data.Name = "tb_data";
            this.tb_data.Size = new System.Drawing.Size(110, 20);
            this.tb_data.TabIndex = 158;
            // 
            // tb_op
            // 
            this.tb_op.Location = new System.Drawing.Point(434, 140);
            this.tb_op.Name = "tb_op";
            this.tb_op.Size = new System.Drawing.Size(110, 20);
            this.tb_op.TabIndex = 157;
            // 
            // form_saidas_estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 325);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_data);
            this.Controls.Add(this.tb_op);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tb_cracha);
            this.Controls.Add(this.tb_qtde_saida);
            this.Controls.Add(this.bt_adicionar_item);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tb_qtde_item);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_espessura_item);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_dimensao_item);
            this.Controls.Add(this.tb_material_item);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_descricao_item);
            this.Controls.Add(this.tb_item_item);
            this.Controls.Add(this.tb_cod_item);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.bt_localizar_item);
            this.Name = "form_saidas_estoque";
            this.Text = "Saída de Estoque";
            ((System.ComponentModel.ISupportInitialize)(this.dsEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ESTOQUE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSaida_estoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ESTOQUE_SAIDA)).EndInit();
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
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_qtde_item;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_espessura_item;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_dimensao_item;
        private System.Windows.Forms.TextBox tb_material_item;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn cODESTOQUESAIDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODITEMESTOQUESAIDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTEMESTOQUESAIDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qTDEESTOQUESAIDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRACHAESTOQUESAIDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPESTOQUESAIDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAESTOQUESAIDADataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_data;
        private System.Windows.Forms.TextBox tb_op;
    }
}