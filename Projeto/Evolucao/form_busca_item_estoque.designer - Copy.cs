namespace Evolucao
{
    partial class form_busca_item_estoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_busca_item_estoque));
            this.tb_grupo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_material = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_cod = new System.Windows.Forms.TextBox();
            this.tb_item = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.col_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRICAOESTOQUEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gRUPOESTOQUEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTEESTOQUEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mATERIALESTOQUEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIMENSAOESTOQUEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRAZOMEDIOESTOQUEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOCALIZACAOESTOQUEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSPESSURAESTOQUEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSTOQUEMINIMOESTOQUEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSTOQUEATUALESTOQUEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHAPAESTOQUEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODBARRASITEMFABRICANTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.label5 = new System.Windows.Forms.Label();
            this.tb_descricao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_dimensao = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_espessura = new System.Windows.Forms.TextBox();
            this.tb_cod_fabricante = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.datEstoque = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ESTOQUE)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_grupo
            // 
            this.tb_grupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_grupo.Location = new System.Drawing.Point(12, 72);
            this.tb_grupo.Name = "tb_grupo";
            this.tb_grupo.Size = new System.Drawing.Size(210, 23);
            this.tb_grupo.TabIndex = 21;
            this.tb_grupo.TextChanged += new System.EventHandler(this.tb_grupo_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "MATERIAL";
            // 
            // tb_material
            // 
            this.tb_material.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_material.Location = new System.Drawing.Point(228, 72);
            this.tb_material.Name = "tb_material";
            this.tb_material.Size = new System.Drawing.Size(208, 23);
            this.tb_material.TabIndex = 19;
            this.tb_material.TextChanged += new System.EventHandler(this.tb_material_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "GRUPO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "ITEM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "COD";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(487, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Cancelar Pesquisa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_cod
            // 
            this.tb_cod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cod.Location = new System.Drawing.Point(12, 31);
            this.tb_cod.Name = "tb_cod";
            this.tb_cod.Size = new System.Drawing.Size(210, 23);
            this.tb_cod.TabIndex = 12;
            this.tb_cod.TextChanged += new System.EventHandler(this.tb_cod_TextChanged);
            // 
            // tb_item
            // 
            this.tb_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_item.Location = new System.Drawing.Point(228, 31);
            this.tb_item.Name = "tb_item";
            this.tb_item.Size = new System.Drawing.Size(208, 23);
            this.tb_item.TabIndex = 13;
            this.tb_item.TextChanged += new System.EventHandler(this.tb_item_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_cod,
            this.col_item,
            this.dESCRICAOESTOQUEDataGridViewTextBoxColumn,
            this.gRUPOESTOQUEDataGridViewTextBoxColumn,
            this.cLIENTEESTOQUEDataGridViewTextBoxColumn,
            this.mATERIALESTOQUEDataGridViewTextBoxColumn,
            this.dIMENSAOESTOQUEDataGridViewTextBoxColumn,
            this.pRAZOMEDIOESTOQUEDataGridViewTextBoxColumn,
            this.lOCALIZACAOESTOQUEDataGridViewTextBoxColumn,
            this.eSPESSURAESTOQUEDataGridViewTextBoxColumn,
            this.eSTOQUEMINIMOESTOQUEDataGridViewTextBoxColumn,
            this.eSTOQUEATUALESTOQUEDataGridViewTextBoxColumn,
            this.cHAPAESTOQUEDataGridViewTextBoxColumn,
            this.cODBARRASITEMFABRICANTEDataGridViewTextBoxColumn});
            this.dataGridView1.DataMember = "ESTOQUE";
            this.dataGridView1.DataSource = this.dsEstoque;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(647, 274);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // col_cod
            // 
            this.col_cod.DataPropertyName = "COD_ESTOQUE";
            this.col_cod.HeaderText = "Cód.";
            this.col_cod.Name = "col_cod";
            this.col_cod.Width = 50;
            // 
            // col_item
            // 
            this.col_item.DataPropertyName = "ITEM_ESTOQUE";
            this.col_item.HeaderText = "Item";
            this.col_item.Name = "col_item";
            this.col_item.Width = 150;
            // 
            // dESCRICAOESTOQUEDataGridViewTextBoxColumn
            // 
            this.dESCRICAOESTOQUEDataGridViewTextBoxColumn.DataPropertyName = "DESCRICAO_ESTOQUE";
            this.dESCRICAOESTOQUEDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.dESCRICAOESTOQUEDataGridViewTextBoxColumn.Name = "dESCRICAOESTOQUEDataGridViewTextBoxColumn";
            // 
            // gRUPOESTOQUEDataGridViewTextBoxColumn
            // 
            this.gRUPOESTOQUEDataGridViewTextBoxColumn.DataPropertyName = "GRUPO_ESTOQUE";
            this.gRUPOESTOQUEDataGridViewTextBoxColumn.HeaderText = "Grupo";
            this.gRUPOESTOQUEDataGridViewTextBoxColumn.Name = "gRUPOESTOQUEDataGridViewTextBoxColumn";
            this.gRUPOESTOQUEDataGridViewTextBoxColumn.Width = 50;
            // 
            // cLIENTEESTOQUEDataGridViewTextBoxColumn
            // 
            this.cLIENTEESTOQUEDataGridViewTextBoxColumn.DataPropertyName = "CLIENTE_ESTOQUE";
            this.cLIENTEESTOQUEDataGridViewTextBoxColumn.HeaderText = "CLIENTE_ESTOQUE";
            this.cLIENTEESTOQUEDataGridViewTextBoxColumn.Name = "cLIENTEESTOQUEDataGridViewTextBoxColumn";
            this.cLIENTEESTOQUEDataGridViewTextBoxColumn.Visible = false;
            // 
            // mATERIALESTOQUEDataGridViewTextBoxColumn
            // 
            this.mATERIALESTOQUEDataGridViewTextBoxColumn.DataPropertyName = "MATERIAL_ESTOQUE";
            this.mATERIALESTOQUEDataGridViewTextBoxColumn.HeaderText = "Material";
            this.mATERIALESTOQUEDataGridViewTextBoxColumn.Name = "mATERIALESTOQUEDataGridViewTextBoxColumn";
            this.mATERIALESTOQUEDataGridViewTextBoxColumn.Width = 50;
            // 
            // dIMENSAOESTOQUEDataGridViewTextBoxColumn
            // 
            this.dIMENSAOESTOQUEDataGridViewTextBoxColumn.DataPropertyName = "DIMENSAO_ESTOQUE";
            this.dIMENSAOESTOQUEDataGridViewTextBoxColumn.HeaderText = "Dimensão";
            this.dIMENSAOESTOQUEDataGridViewTextBoxColumn.Name = "dIMENSAOESTOQUEDataGridViewTextBoxColumn";
            this.dIMENSAOESTOQUEDataGridViewTextBoxColumn.Width = 70;
            // 
            // pRAZOMEDIOESTOQUEDataGridViewTextBoxColumn
            // 
            this.pRAZOMEDIOESTOQUEDataGridViewTextBoxColumn.DataPropertyName = "PRAZO_MEDIO_ESTOQUE";
            this.pRAZOMEDIOESTOQUEDataGridViewTextBoxColumn.HeaderText = "PRAZO_MEDIO_ESTOQUE";
            this.pRAZOMEDIOESTOQUEDataGridViewTextBoxColumn.Name = "pRAZOMEDIOESTOQUEDataGridViewTextBoxColumn";
            this.pRAZOMEDIOESTOQUEDataGridViewTextBoxColumn.Visible = false;
            // 
            // lOCALIZACAOESTOQUEDataGridViewTextBoxColumn
            // 
            this.lOCALIZACAOESTOQUEDataGridViewTextBoxColumn.DataPropertyName = "LOCALIZACAO_ESTOQUE";
            this.lOCALIZACAOESTOQUEDataGridViewTextBoxColumn.HeaderText = "LOCALIZACAO_ESTOQUE";
            this.lOCALIZACAOESTOQUEDataGridViewTextBoxColumn.Name = "lOCALIZACAOESTOQUEDataGridViewTextBoxColumn";
            this.lOCALIZACAOESTOQUEDataGridViewTextBoxColumn.Visible = false;
            // 
            // eSPESSURAESTOQUEDataGridViewTextBoxColumn
            // 
            this.eSPESSURAESTOQUEDataGridViewTextBoxColumn.DataPropertyName = "ESPESSURA_ESTOQUE";
            this.eSPESSURAESTOQUEDataGridViewTextBoxColumn.HeaderText = "Espessura";
            this.eSPESSURAESTOQUEDataGridViewTextBoxColumn.Name = "eSPESSURAESTOQUEDataGridViewTextBoxColumn";
            this.eSPESSURAESTOQUEDataGridViewTextBoxColumn.Width = 70;
            // 
            // eSTOQUEMINIMOESTOQUEDataGridViewTextBoxColumn
            // 
            this.eSTOQUEMINIMOESTOQUEDataGridViewTextBoxColumn.DataPropertyName = "ESTOQUE_MINIMO_ESTOQUE";
            this.eSTOQUEMINIMOESTOQUEDataGridViewTextBoxColumn.HeaderText = "ESTOQUE_MINIMO_ESTOQUE";
            this.eSTOQUEMINIMOESTOQUEDataGridViewTextBoxColumn.Name = "eSTOQUEMINIMOESTOQUEDataGridViewTextBoxColumn";
            this.eSTOQUEMINIMOESTOQUEDataGridViewTextBoxColumn.Visible = false;
            // 
            // eSTOQUEATUALESTOQUEDataGridViewTextBoxColumn
            // 
            this.eSTOQUEATUALESTOQUEDataGridViewTextBoxColumn.DataPropertyName = "ESTOQUE_ATUAL_ESTOQUE";
            this.eSTOQUEATUALESTOQUEDataGridViewTextBoxColumn.HeaderText = "ESTOQUE_ATUAL_ESTOQUE";
            this.eSTOQUEATUALESTOQUEDataGridViewTextBoxColumn.Name = "eSTOQUEATUALESTOQUEDataGridViewTextBoxColumn";
            this.eSTOQUEATUALESTOQUEDataGridViewTextBoxColumn.Visible = false;
            // 
            // cHAPAESTOQUEDataGridViewTextBoxColumn
            // 
            this.cHAPAESTOQUEDataGridViewTextBoxColumn.DataPropertyName = "CHAPA_ESTOQUE";
            this.cHAPAESTOQUEDataGridViewTextBoxColumn.HeaderText = "CHAPA_ESTOQUE";
            this.cHAPAESTOQUEDataGridViewTextBoxColumn.Name = "cHAPAESTOQUEDataGridViewTextBoxColumn";
            this.cHAPAESTOQUEDataGridViewTextBoxColumn.Visible = false;
            // 
            // cODBARRASITEMFABRICANTEDataGridViewTextBoxColumn
            // 
            this.cODBARRASITEMFABRICANTEDataGridViewTextBoxColumn.DataPropertyName = "COD_BARRAS_ITEM_FABRICANTE";
            this.cODBARRASITEMFABRICANTEDataGridViewTextBoxColumn.HeaderText = "Barras Fabricante";
            this.cODBARRASITEMFABRICANTEDataGridViewTextBoxColumn.Name = "cODBARRASITEMFABRICANTEDataGridViewTextBoxColumn";
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
            this.COD_BARRAS_ITEM_FABRICANTE});
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(450, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "DESCRIÇÃO";
            // 
            // tb_descricao
            // 
            this.tb_descricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_descricao.Location = new System.Drawing.Point(442, 31);
            this.tb_descricao.Name = "tb_descricao";
            this.tb_descricao.Size = new System.Drawing.Size(208, 23);
            this.tb_descricao.TabIndex = 22;
            this.tb_descricao.TextChanged += new System.EventHandler(this.tb_descricao_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(452, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "DIMENSÃO";
            // 
            // tb_dimensao
            // 
            this.tb_dimensao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_dimensao.Location = new System.Drawing.Point(442, 72);
            this.tb_dimensao.Name = "tb_dimensao";
            this.tb_dimensao.Size = new System.Drawing.Size(208, 23);
            this.tb_dimensao.TabIndex = 24;
            this.tb_dimensao.TextChanged += new System.EventHandler(this.tb_dimensao_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(236, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(226, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "COD BARRAS EMITIDO PELO FABRICANTE";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 102);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "ESPESSURA";
            // 
            // tb_espessura
            // 
            this.tb_espessura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_espessura.Location = new System.Drawing.Point(12, 118);
            this.tb_espessura.Name = "tb_espessura";
            this.tb_espessura.Size = new System.Drawing.Size(210, 23);
            this.tb_espessura.TabIndex = 26;
            this.tb_espessura.TextChanged += new System.EventHandler(this.tb_espessura_TextChanged);
            // 
            // tb_cod_fabricante
            // 
            this.tb_cod_fabricante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cod_fabricante.Location = new System.Drawing.Point(228, 118);
            this.tb_cod_fabricante.Name = "tb_cod_fabricante";
            this.tb_cod_fabricante.Size = new System.Drawing.Size(422, 23);
            this.tb_cod_fabricante.TabIndex = 27;
            this.tb_cod_fabricante.TextChanged += new System.EventHandler(this.tb_cod_fabricante_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(349, 445);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 23);
            this.button2.TabIndex = 30;
            this.button2.Text = "Adicionar Item";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // form_busca_item_estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 480);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tb_espessura);
            this.Controls.Add(this.tb_cod_fabricante);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_dimensao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_descricao);
            this.Controls.Add(this.tb_grupo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_material);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_cod);
            this.Controls.Add(this.tb_item);
            this.Controls.Add(this.dataGridView1);
            this.Name = "form_busca_item_estoque";
            this.Text = "Busca Item Estoque";
            this.Load += new System.EventHandler(this.form_busca_item_estoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ESTOQUE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_grupo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_material;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_cod;
        private System.Windows.Forms.TextBox tb_item;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_descricao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_dimensao;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_espessura;
        private System.Windows.Forms.TextBox tb_cod_fabricante;
        private System.Windows.Forms.Button button2;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRICAOESTOQUEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gRUPOESTOQUEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTEESTOQUEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mATERIALESTOQUEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIMENSAOESTOQUEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRAZOMEDIOESTOQUEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOCALIZACAOESTOQUEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSPESSURAESTOQUEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTOQUEMINIMOESTOQUEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTOQUEATUALESTOQUEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHAPAESTOQUEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODBARRASITEMFABRICANTEDataGridViewTextBoxColumn;
    }
}