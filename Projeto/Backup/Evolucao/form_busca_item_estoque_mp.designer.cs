namespace Evolucao
{
    partial class form_busca_item_estoque_mp
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_busca_item_estoque_mp));
            this.tb_grupo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_material = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_cod = new System.Windows.Forms.TextBox();
            this.tb_item = new System.Windows.Forms.TextBox();
            this.dgvEstoque = new System.Windows.Forms.DataGridView();
            this.col_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gRUPOESTOQUEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mATERIALESTOQUEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLASSIFICACAO_ESTOQUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACABAMENTO_ESTOQUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMPRIMENTO_ESTOQUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_PROPRIETARIO_ESTOQUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTOQUE_RESERVADO_ESTOQUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_minimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTOQUE_AGUARDANDO_ESTOQUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSTOQUEATUALESTOQUEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_disponivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_peso_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_qtde_saidas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_peso_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_valor_ultima_compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_unidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTEESTOQUEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRAZOMEDIOESTOQUEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOCALIZACAOESTOQUEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.label6 = new System.Windows.Forms.Label();
            this.tb_dimensao = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_espessura = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.datEstoque = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_comprimento = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_cliente = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_acabamento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_classificacao = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtFinal = new System.Windows.Forms.DateTimePicker();
            this.dtInicial = new System.Windows.Forms.DateTimePicker();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ESTOQUE)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_grupo
            // 
            this.tb_grupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_grupo.Location = new System.Drawing.Point(19, 63);
            this.tb_grupo.Name = "tb_grupo";
            this.tb_grupo.Size = new System.Drawing.Size(110, 23);
            this.tb_grupo.TabIndex = 21;
            this.tb_grupo.TextChanged += new System.EventHandler(this.tb_grupo_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(134, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "MATERIAL";
            // 
            // tb_material
            // 
            this.tb_material.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_material.Location = new System.Drawing.Point(135, 63);
            this.tb_material.Name = "tb_material";
            this.tb_material.Size = new System.Drawing.Size(110, 23);
            this.tb_material.TabIndex = 19;
            this.tb_material.TextChanged += new System.EventHandler(this.tb_material_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "GRUPO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "ITEM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "COD";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(504, 604);
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
            this.tb_cod.Location = new System.Drawing.Point(19, 22);
            this.tb_cod.Name = "tb_cod";
            this.tb_cod.Size = new System.Drawing.Size(71, 23);
            this.tb_cod.TabIndex = 12;
            this.tb_cod.TextChanged += new System.EventHandler(this.tb_cod_TextChanged);
            // 
            // tb_item
            // 
            this.tb_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_item.Location = new System.Drawing.Point(96, 22);
            this.tb_item.Name = "tb_item";
            this.tb_item.Size = new System.Drawing.Size(347, 23);
            this.tb_item.TabIndex = 13;
            this.tb_item.TextChanged += new System.EventHandler(this.tb_item_TextChanged);
            // 
            // dgvEstoque
            // 
            this.dgvEstoque.AllowUserToAddRows = false;
            this.dgvEstoque.AllowUserToDeleteRows = false;
            this.dgvEstoque.AllowUserToResizeRows = false;
            this.dgvEstoque.AutoGenerateColumns = false;
            this.dgvEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstoque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_cod,
            this.gRUPOESTOQUEDataGridViewTextBoxColumn,
            this.mATERIALESTOQUEDataGridViewTextBoxColumn,
            this.CLASSIFICACAO_ESTOQUE,
            this.ACABAMENTO_ESTOQUE,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.COMPRIMENTO_ESTOQUE,
            this.NOME_PROPRIETARIO_ESTOQUE,
            this.ESTOQUE_RESERVADO_ESTOQUE,
            this.col_minimo,
            this.ESTOQUE_AGUARDANDO_ESTOQUE,
            this.eSTOQUEATUALESTOQUEDataGridViewTextBoxColumn,
            this.col_disponivel,
            this.col_peso_unit,
            this.col_qtde_saidas,
            this.col_peso_total,
            this.col_valor_ultima_compra,
            this.col_item,
            this.col_descricao,
            this.col_unidade,
            this.cLIENTEESTOQUEDataGridViewTextBoxColumn,
            this.pRAZOMEDIOESTOQUEDataGridViewTextBoxColumn,
            this.lOCALIZACAOESTOQUEDataGridViewTextBoxColumn,
            this.cHAPAESTOQUEDataGridViewTextBoxColumn,
            this.cODBARRASITEMFABRICANTEDataGridViewTextBoxColumn});
            this.dgvEstoque.DataMember = "ESTOQUE";
            this.dgvEstoque.DataSource = this.dsEstoque;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEstoque.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEstoque.Location = new System.Drawing.Point(12, 110);
            this.dgvEstoque.Name = "dgvEstoque";
            this.dgvEstoque.RowHeadersVisible = false;
            this.dgvEstoque.RowHeadersWidth = 15;
            this.dgvEstoque.Size = new System.Drawing.Size(1260, 488);
            this.dgvEstoque.TabIndex = 14;
            this.dgvEstoque.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstoque_CellContentDoubleClick);
            this.dgvEstoque.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstoque_CellContentClick);
            // 
            // col_cod
            // 
            this.col_cod.DataPropertyName = "COD_ESTOQUE";
            this.col_cod.HeaderText = "Cód.";
            this.col_cod.Name = "col_cod";
            this.col_cod.Width = 50;
            // 
            // gRUPOESTOQUEDataGridViewTextBoxColumn
            // 
            this.gRUPOESTOQUEDataGridViewTextBoxColumn.DataPropertyName = "GRUPO_ESTOQUE";
            this.gRUPOESTOQUEDataGridViewTextBoxColumn.HeaderText = "Grupo";
            this.gRUPOESTOQUEDataGridViewTextBoxColumn.Name = "gRUPOESTOQUEDataGridViewTextBoxColumn";
            this.gRUPOESTOQUEDataGridViewTextBoxColumn.Width = 70;
            // 
            // mATERIALESTOQUEDataGridViewTextBoxColumn
            // 
            this.mATERIALESTOQUEDataGridViewTextBoxColumn.DataPropertyName = "MATERIAL_ESTOQUE";
            this.mATERIALESTOQUEDataGridViewTextBoxColumn.HeaderText = "Material";
            this.mATERIALESTOQUEDataGridViewTextBoxColumn.Name = "mATERIALESTOQUEDataGridViewTextBoxColumn";
            this.mATERIALESTOQUEDataGridViewTextBoxColumn.Width = 70;
            // 
            // CLASSIFICACAO_ESTOQUE
            // 
            this.CLASSIFICACAO_ESTOQUE.DataPropertyName = "CLASSIFICACAO_ESTOQUE";
            this.CLASSIFICACAO_ESTOQUE.HeaderText = "Classificação";
            this.CLASSIFICACAO_ESTOQUE.Name = "CLASSIFICACAO_ESTOQUE";
            this.CLASSIFICACAO_ESTOQUE.Width = 70;
            // 
            // ACABAMENTO_ESTOQUE
            // 
            this.ACABAMENTO_ESTOQUE.DataPropertyName = "ACABAMENTO_ESTOQUE";
            this.ACABAMENTO_ESTOQUE.HeaderText = "Acabamento";
            this.ACABAMENTO_ESTOQUE.Name = "ACABAMENTO_ESTOQUE";
            this.ACABAMENTO_ESTOQUE.Width = 70;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ESPESSURA_ESTOQUE";
            this.dataGridViewTextBoxColumn1.HeaderText = "Espessura";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 40;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DIMENSAO_ESTOQUE";
            this.dataGridViewTextBoxColumn2.HeaderText = "Dimensão";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 70;
            // 
            // COMPRIMENTO_ESTOQUE
            // 
            this.COMPRIMENTO_ESTOQUE.DataPropertyName = "COMPRIMENTO_ESTOQUE";
            this.COMPRIMENTO_ESTOQUE.HeaderText = "Comprimento";
            this.COMPRIMENTO_ESTOQUE.Name = "COMPRIMENTO_ESTOQUE";
            this.COMPRIMENTO_ESTOQUE.Width = 40;
            // 
            // NOME_PROPRIETARIO_ESTOQUE
            // 
            this.NOME_PROPRIETARIO_ESTOQUE.DataPropertyName = "NOME_PROPRIETARIO_ESTOQUE";
            this.NOME_PROPRIETARIO_ESTOQUE.HeaderText = "Cliente";
            this.NOME_PROPRIETARIO_ESTOQUE.Name = "NOME_PROPRIETARIO_ESTOQUE";
            // 
            // ESTOQUE_RESERVADO_ESTOQUE
            // 
            this.ESTOQUE_RESERVADO_ESTOQUE.DataPropertyName = "ESTOQUE_RESERVADO_ESTOQUE";
            this.ESTOQUE_RESERVADO_ESTOQUE.HeaderText = "Reservado";
            this.ESTOQUE_RESERVADO_ESTOQUE.Name = "ESTOQUE_RESERVADO_ESTOQUE";
            this.ESTOQUE_RESERVADO_ESTOQUE.Width = 50;
            // 
            // col_minimo
            // 
            this.col_minimo.DataPropertyName = "ESTOQUE_MINIMO_ESTOQUE";
            this.col_minimo.HeaderText = "Mínimo";
            this.col_minimo.Name = "col_minimo";
            this.col_minimo.Width = 50;
            // 
            // ESTOQUE_AGUARDANDO_ESTOQUE
            // 
            this.ESTOQUE_AGUARDANDO_ESTOQUE.DataPropertyName = "ESTOQUE_AGUARDANDO_ESTOQUE";
            this.ESTOQUE_AGUARDANDO_ESTOQUE.HeaderText = "Em Compras";
            this.ESTOQUE_AGUARDANDO_ESTOQUE.Name = "ESTOQUE_AGUARDANDO_ESTOQUE";
            this.ESTOQUE_AGUARDANDO_ESTOQUE.Width = 50;
            // 
            // eSTOQUEATUALESTOQUEDataGridViewTextBoxColumn
            // 
            this.eSTOQUEATUALESTOQUEDataGridViewTextBoxColumn.DataPropertyName = "ESTOQUE_ATUAL_ESTOQUE";
            this.eSTOQUEATUALESTOQUEDataGridViewTextBoxColumn.HeaderText = "Armazenado";
            this.eSTOQUEATUALESTOQUEDataGridViewTextBoxColumn.Name = "eSTOQUEATUALESTOQUEDataGridViewTextBoxColumn";
            this.eSTOQUEATUALESTOQUEDataGridViewTextBoxColumn.Width = 50;
            // 
            // col_disponivel
            // 
            this.col_disponivel.DataPropertyName = "ESTOQUE_DISPONIVEL_ESTOQUE";
            this.col_disponivel.HeaderText = "Disponível";
            this.col_disponivel.Name = "col_disponivel";
            this.col_disponivel.Width = 50;
            // 
            // col_peso_unit
            // 
            this.col_peso_unit.DataPropertyName = "PESO_UNIT_ESTOQUE";
            this.col_peso_unit.HeaderText = "Peso Unit";
            this.col_peso_unit.Name = "col_peso_unit";
            this.col_peso_unit.Width = 50;
            // 
            // col_qtde_saidas
            // 
            this.col_qtde_saidas.HeaderText = "Saídas Período";
            this.col_qtde_saidas.Name = "col_qtde_saidas";
            this.col_qtde_saidas.Width = 50;
            // 
            // col_peso_total
            // 
            this.col_peso_total.HeaderText = "Peso Total";
            this.col_peso_total.Name = "col_peso_total";
            this.col_peso_total.Width = 60;
            // 
            // col_valor_ultima_compra
            // 
            this.col_valor_ultima_compra.DataPropertyName = "VALOR_ULTIMA_COMPRA_ESTOQUE";
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.col_valor_ultima_compra.DefaultCellStyle = dataGridViewCellStyle1;
            this.col_valor_ultima_compra.HeaderText = "Ultima Compra";
            this.col_valor_ultima_compra.Name = "col_valor_ultima_compra";
            this.col_valor_ultima_compra.Width = 70;
            // 
            // col_item
            // 
            this.col_item.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.col_item.DataPropertyName = "ITEM_ESTOQUE";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.col_item.DefaultCellStyle = dataGridViewCellStyle2;
            this.col_item.HeaderText = "Item";
            this.col_item.Name = "col_item";
            this.col_item.Width = 52;
            // 
            // col_descricao
            // 
            this.col_descricao.DataPropertyName = "DESCRICAO_ESTOQUE";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.col_descricao.DefaultCellStyle = dataGridViewCellStyle3;
            this.col_descricao.HeaderText = "Descrição";
            this.col_descricao.Name = "col_descricao";
            this.col_descricao.Width = 250;
            // 
            // col_unidade
            // 
            this.col_unidade.DataPropertyName = "UNIDADE_ESTOQUE";
            this.col_unidade.HeaderText = "Unidade";
            this.col_unidade.Name = "col_unidade";
            // 
            // cLIENTEESTOQUEDataGridViewTextBoxColumn
            // 
            this.cLIENTEESTOQUEDataGridViewTextBoxColumn.DataPropertyName = "CLIENTE_ESTOQUE";
            this.cLIENTEESTOQUEDataGridViewTextBoxColumn.HeaderText = "CLIENTE_ESTOQUE";
            this.cLIENTEESTOQUEDataGridViewTextBoxColumn.Name = "cLIENTEESTOQUEDataGridViewTextBoxColumn";
            this.cLIENTEESTOQUEDataGridViewTextBoxColumn.Visible = false;
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
            this.COD_BARRAS_ITEM_FABRICANTE,
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
            this.dataColumn11});
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
            this.ESPESSURA_ESTOQUE.MaxLength = 100;
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
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "TIPO_ITEM_ESTOQUE";
            this.dataColumn1.MaxLength = 200;
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "ESTOQUE_DISPONIVEL_ESTOQUE";
            this.dataColumn2.DataType = typeof(double);
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "ESTOQUE_AGUARDANDO_ESTOQUE";
            this.dataColumn3.DataType = typeof(double);
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "ESTOQUE_RESERVADO_ESTOQUE";
            this.dataColumn4.DataType = typeof(double);
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "CLASSIFICACAO_ESTOQUE";
            this.dataColumn5.MaxLength = 100;
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "ACABAMENTO_ESTOQUE";
            this.dataColumn6.MaxLength = 100;
            // 
            // dataColumn7
            // 
            this.dataColumn7.ColumnName = "COMPRIMENTO_ESTOQUE";
            this.dataColumn7.MaxLength = 100;
            // 
            // dataColumn8
            // 
            this.dataColumn8.ColumnName = "PESO_UNIT_ESTOQUE";
            this.dataColumn8.DataType = typeof(double);
            // 
            // dataColumn9
            // 
            this.dataColumn9.ColumnName = "NOME_PROPRIETARIO_ESTOQUE";
            this.dataColumn9.MaxLength = 200;
            // 
            // dataColumn10
            // 
            this.dataColumn10.ColumnName = "VALOR_ULTIMA_COMPRA_ESTOQUE";
            this.dataColumn10.DataType = typeof(double);
            // 
            // dataColumn11
            // 
            this.dataColumn11.ColumnName = "UNIDADE_ESTOQUE";
            this.dataColumn11.MaxLength = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(599, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "DIMENSÃO";
            // 
            // tb_dimensao
            // 
            this.tb_dimensao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_dimensao.Location = new System.Drawing.Point(599, 63);
            this.tb_dimensao.Name = "tb_dimensao";
            this.tb_dimensao.Size = new System.Drawing.Size(110, 23);
            this.tb_dimensao.TabIndex = 24;
            this.tb_dimensao.TextChanged += new System.EventHandler(this.tb_dimensao_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(483, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "ESPESSURA";
            // 
            // tb_espessura
            // 
            this.tb_espessura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_espessura.Location = new System.Drawing.Point(483, 63);
            this.tb_espessura.Name = "tb_espessura";
            this.tb_espessura.Size = new System.Drawing.Size(110, 23);
            this.tb_espessura.TabIndex = 26;
            this.tb_espessura.TextChanged += new System.EventHandler(this.tb_espessura_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(366, 604);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.tb_comprimento);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.tb_cliente);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.tb_acabamento);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tb_classificacao);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.cbTipo);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.tb_espessura);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tb_dimensao);
            this.panel1.Controls.Add(this.tb_grupo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tb_material);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tb_cod);
            this.panel1.Controls.Add(this.tb_item);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1260, 92);
            this.panel1.TabIndex = 31;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(715, 50);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 13);
            this.label14.TabIndex = 309;
            this.label14.Text = "COMPRIMENTO";
            // 
            // tb_comprimento
            // 
            this.tb_comprimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_comprimento.Location = new System.Drawing.Point(715, 63);
            this.tb_comprimento.Name = "tb_comprimento";
            this.tb_comprimento.Size = new System.Drawing.Size(110, 23);
            this.tb_comprimento.TabIndex = 308;
            this.tb_comprimento.TextChanged += new System.EventHandler(this.tb_comprimento_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(660, 7);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 13);
            this.label13.TabIndex = 307;
            this.label13.Text = "CLIENTE";
            // 
            // tb_cliente
            // 
            this.tb_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cliente.Location = new System.Drawing.Point(663, 22);
            this.tb_cliente.Name = "tb_cliente";
            this.tb_cliente.Size = new System.Drawing.Size(162, 23);
            this.tb_cliente.TabIndex = 306;
            this.tb_cliente.TextChanged += new System.EventHandler(this.tb_cliente_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(367, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 13);
            this.label11.TabIndex = 305;
            this.label11.Text = "ACABAMENTO";
            // 
            // tb_acabamento
            // 
            this.tb_acabamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_acabamento.Location = new System.Drawing.Point(367, 63);
            this.tb_acabamento.Name = "tb_acabamento";
            this.tb_acabamento.Size = new System.Drawing.Size(110, 23);
            this.tb_acabamento.TabIndex = 304;
            this.tb_acabamento.TextChanged += new System.EventHandler(this.tb_acabamento_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(251, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 303;
            this.label5.Text = "CLASSIFICAÇÃO";
            // 
            // tb_classificacao
            // 
            this.tb_classificacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_classificacao.Location = new System.Drawing.Point(251, 63);
            this.tb_classificacao.Name = "tb_classificacao";
            this.tb_classificacao.Size = new System.Drawing.Size(110, 23);
            this.tb_classificacao.TabIndex = 302;
            this.tb_classificacao.TextChanged += new System.EventHandler(this.tb_classificacao_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.dtFinal);
            this.panel2.Controls.Add(this.dtInicial);
            this.panel2.Location = new System.Drawing.Point(887, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(370, 43);
            this.panel2.TabIndex = 301;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(214, 2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Peso Total";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(217, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(56, 20);
            this.textBox1.TabIndex = 32;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(279, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 27);
            this.button3.TabIndex = 17;
            this.button3.Text = "Cálculos";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(111, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Fim";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Início";
            // 
            // dtFinal
            // 
            this.dtFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFinal.Location = new System.Drawing.Point(108, 15);
            this.dtFinal.Name = "dtFinal";
            this.dtFinal.Size = new System.Drawing.Size(97, 20);
            this.dtFinal.TabIndex = 13;
            // 
            // dtInicial
            // 
            this.dtInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicial.Location = new System.Drawing.Point(8, 15);
            this.dtInicial.Name = "dtInicial";
            this.dtInicial.Size = new System.Drawing.Size(97, 20);
            this.dtInicial.TabIndex = 12;
            // 
            // cbTipo
            // 
            this.cbTipo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsEstoque, "ESTOQUE.TIPO_ITEM_ESTOQUE", true));
            this.cbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "00 – Mercadoria para Revenda",
            "01 – Matéria-Prima",
            "02 – Embalagem",
            "03 – Produto em Processo",
            "04 – Produto Acabado",
            "05 – Subproduto",
            "06 – Produto Intermediário",
            "07 – Material de Uso e Consumo",
            "08 – Ativo Imobilizado",
            "09 – Serviços",
            "10 – Outros insumos",
            "99 – Outras"});
            this.cbTipo.Location = new System.Drawing.Point(449, 22);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(208, 21);
            this.cbTipo.TabIndex = 161;
            this.cbTipo.SelectedIndexChanged += new System.EventHandler(this.cbTipo_SelectedIndexChanged);
            this.cbTipo.TextChanged += new System.EventHandler(this.cbTipo_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(448, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "TIPO";
            // 
            // form_busca_item_estoque_mp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1284, 639);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvEstoque);
            this.Name = "form_busca_item_estoque_mp";
            this.Text = "Busca Item Estoque";
            this.Load += new System.EventHandler(this.form_busca_item_estoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ESTOQUE)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.DataGridView dgvEstoque;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_dimensao;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_espessura;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Data.DataColumn dataColumn7;
        private System.Data.DataColumn dataColumn8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtFinal;
        private System.Windows.Forms.DateTimePicker dtInicial;
        private System.Data.DataColumn dataColumn9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_acabamento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_classificacao;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_cliente;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tb_comprimento;
        private System.Data.DataColumn dataColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn gRUPOESTOQUEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mATERIALESTOQUEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLASSIFICACAO_ESTOQUE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACABAMENTO_ESTOQUE;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMPRIMENTO_ESTOQUE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_PROPRIETARIO_ESTOQUE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTOQUE_RESERVADO_ESTOQUE;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_minimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTOQUE_AGUARDANDO_ESTOQUE;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTOQUEATUALESTOQUEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_disponivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_peso_unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_qtde_saidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_peso_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_valor_ultima_compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_unidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTEESTOQUEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRAZOMEDIOESTOQUEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOCALIZACAOESTOQUEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHAPAESTOQUEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODBARRASITEMFABRICANTEDataGridViewTextBoxColumn;
        private System.Data.DataColumn dataColumn11;
    }
}