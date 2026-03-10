namespace Evolucao
{
    partial class form_area_atuacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_area_atuacao));
            this.label20 = new System.Windows.Forms.Label();
            this.tb_descricao = new System.Windows.Forms.TextBox();
            this.dsArea_forn = new System.Data.DataSet();
            this.AREA_ATUACAO_FORN = new System.Data.DataTable();
            this.COD_AREA_FORN = new System.Data.DataColumn();
            this.DESCRICAO_AREA_FORN = new System.Data.DataColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.codigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dsForn = new System.Data.DataSet();
            this.FORNECEDORES = new System.Data.DataTable();
            this.COD_FORN = new System.Data.DataColumn();
            this.RAZAO_SOCIAL_FORN = new System.Data.DataColumn();
            this.NOME_FANTASIA_FORN = new System.Data.DataColumn();
            this.TIPO_MATERIAL = new System.Data.DataColumn();
            this.TIPO_MATERIAL_2 = new System.Data.DataColumn();
            this.TIPO_MATERIAL_3 = new System.Data.DataColumn();
            this.TIPO_MATERIAL_4 = new System.Data.DataColumn();
            this.CNPJ_CPF_FORN = new System.Data.DataColumn();
            this.IE_RG_FORN = new System.Data.DataColumn();
            this.ENDERECO_FORN = new System.Data.DataColumn();
            this.BAIRRO_FORN = new System.Data.DataColumn();
            this.CIDADE_FORN = new System.Data.DataColumn();
            this.CEP_FORN = new System.Data.DataColumn();
            this.ESTADO_FORN = new System.Data.DataColumn();
            this.PAIS_FORN = new System.Data.DataColumn();
            this.EMAIL_FORN = new System.Data.DataColumn();
            this.TEL_FORN = new System.Data.DataColumn();
            this.CONTATO_FORN = new System.Data.DataColumn();
            this.TEL_CONTATO_FORN = new System.Data.DataColumn();
            this.EMAIL_CONTATO_FORN = new System.Data.DataColumn();
            this.OUTRAS_INF_FORN = new System.Data.DataColumn();
            this.ISO_FORN = new System.Data.DataColumn();
            this.VALIDADE_ISO_FORN = new System.Data.DataColumn();
            this.apaga_registro = new System.Windows.Forms.Button();
            this.salva_registro = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.novo_registro = new System.Windows.Forms.Button();
            this.datArea_forn = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.button1 = new System.Windows.Forms.Button();
            this.datForn = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand8 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand6 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand5 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand7 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommandBuilder1 = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.col_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAZAOSOCIALFORNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMEFANTASIAFORNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIPOMATERIALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIPOMATERIAL2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIPOMATERIAL3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIPOMATERIAL4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNPJCPFFORNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iERGFORNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNDERECOFORNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bAIRROFORNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIDADEFORNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEPFORNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSTADOFORNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAISFORNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILFORNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tELFORNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONTATOFORNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tELCONTATOFORNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILCONTATOFORNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oUTRASINFFORNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSOFORNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALIDADEISOFORNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dsArea_forn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AREA_ATUACAO_FORN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsForn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FORNECEDORES)).BeginInit();
            this.SuspendLayout();
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label20.Location = new System.Drawing.Point(189, 9);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(211, 50);
            this.label20.TabIndex = 71;
            this.label20.Text = "ÁREA DE ATUAÇÃO\r\nFORNECEDORES";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_descricao
            // 
            this.tb_descricao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsArea_forn, "AREA_ATUACAO_FORN.DESCRICAO_AREA_FORN", true));
            this.tb_descricao.Location = new System.Drawing.Point(188, 99);
            this.tb_descricao.Name = "tb_descricao";
            this.tb_descricao.Size = new System.Drawing.Size(265, 20);
            this.tb_descricao.TabIndex = 66;
            // 
            // dsArea_forn
            // 
            this.dsArea_forn.DataSetName = "dsArea_forn";
            this.dsArea_forn.Namespace = "http://www.tempuri.org/dsArea_forn.xsd";
            this.dsArea_forn.Tables.AddRange(new System.Data.DataTable[] {
            this.AREA_ATUACAO_FORN});
            // 
            // AREA_ATUACAO_FORN
            // 
            this.AREA_ATUACAO_FORN.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_AREA_FORN,
            this.DESCRICAO_AREA_FORN});
            this.AREA_ATUACAO_FORN.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_AREA_FORN"}, true)});
            this.AREA_ATUACAO_FORN.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_AREA_FORN};
            this.AREA_ATUACAO_FORN.TableName = "AREA_ATUACAO_FORN";
            // 
            // COD_AREA_FORN
            // 
            this.COD_AREA_FORN.AllowDBNull = false;
            this.COD_AREA_FORN.ColumnName = "COD_AREA_FORN";
            this.COD_AREA_FORN.DataType = typeof(int);
            // 
            // DESCRICAO_AREA_FORN
            // 
            this.DESCRICAO_AREA_FORN.ColumnName = "DESCRICAO_AREA_FORN";
            this.DESCRICAO_AREA_FORN.MaxLength = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 67;
            this.label2.Text = "Descrição:";
            // 
            // codigo
            // 
            this.codigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsArea_forn, "AREA_ATUACAO_FORN.COD_AREA_FORN", true));
            this.codigo.Location = new System.Drawing.Point(271, 73);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(70, 20);
            this.codigo.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 65;
            this.label1.Text = "Código da Área de Atuação:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_cod,
            this.rAZAOSOCIALFORNDataGridViewTextBoxColumn,
            this.nOMEFANTASIAFORNDataGridViewTextBoxColumn,
            this.tIPOMATERIALDataGridViewTextBoxColumn,
            this.tIPOMATERIAL2DataGridViewTextBoxColumn,
            this.tIPOMATERIAL3DataGridViewTextBoxColumn,
            this.tIPOMATERIAL4DataGridViewTextBoxColumn,
            this.cNPJCPFFORNDataGridViewTextBoxColumn,
            this.iERGFORNDataGridViewTextBoxColumn,
            this.eNDERECOFORNDataGridViewTextBoxColumn,
            this.bAIRROFORNDataGridViewTextBoxColumn,
            this.cIDADEFORNDataGridViewTextBoxColumn,
            this.cEPFORNDataGridViewTextBoxColumn,
            this.eSTADOFORNDataGridViewTextBoxColumn,
            this.pAISFORNDataGridViewTextBoxColumn,
            this.eMAILFORNDataGridViewTextBoxColumn,
            this.tELFORNDataGridViewTextBoxColumn,
            this.cONTATOFORNDataGridViewTextBoxColumn,
            this.tELCONTATOFORNDataGridViewTextBoxColumn,
            this.eMAILCONTATOFORNDataGridViewTextBoxColumn,
            this.oUTRASINFFORNDataGridViewTextBoxColumn,
            this.iSOFORNDataGridViewTextBoxColumn,
            this.vALIDADEISOFORNDataGridViewTextBoxColumn});
            this.dataGridView1.DataMember = "FORNECEDORES";
            this.dataGridView1.DataSource = this.dsForn;
            this.dataGridView1.Location = new System.Drawing.Point(16, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(548, 150);
            this.dataGridView1.TabIndex = 72;
            // 
            // dsForn
            // 
            this.dsForn.DataSetName = "dsForn";
            this.dsForn.Namespace = "http://www.tempuri.org/dsForn.xsd";
            this.dsForn.Tables.AddRange(new System.Data.DataTable[] {
            this.FORNECEDORES});
            // 
            // FORNECEDORES
            // 
            this.FORNECEDORES.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_FORN,
            this.RAZAO_SOCIAL_FORN,
            this.NOME_FANTASIA_FORN,
            this.TIPO_MATERIAL,
            this.TIPO_MATERIAL_2,
            this.TIPO_MATERIAL_3,
            this.TIPO_MATERIAL_4,
            this.CNPJ_CPF_FORN,
            this.IE_RG_FORN,
            this.ENDERECO_FORN,
            this.BAIRRO_FORN,
            this.CIDADE_FORN,
            this.CEP_FORN,
            this.ESTADO_FORN,
            this.PAIS_FORN,
            this.EMAIL_FORN,
            this.TEL_FORN,
            this.CONTATO_FORN,
            this.TEL_CONTATO_FORN,
            this.EMAIL_CONTATO_FORN,
            this.OUTRAS_INF_FORN,
            this.ISO_FORN,
            this.VALIDADE_ISO_FORN});
            this.FORNECEDORES.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_FORN"}, true)});
            this.FORNECEDORES.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_FORN};
            this.FORNECEDORES.TableName = "FORNECEDORES";
            // 
            // COD_FORN
            // 
            this.COD_FORN.AllowDBNull = false;
            this.COD_FORN.ColumnName = "COD_FORN";
            this.COD_FORN.DataType = typeof(int);
            // 
            // RAZAO_SOCIAL_FORN
            // 
            this.RAZAO_SOCIAL_FORN.ColumnName = "RAZAO_SOCIAL_FORN";
            this.RAZAO_SOCIAL_FORN.MaxLength = 80;
            // 
            // NOME_FANTASIA_FORN
            // 
            this.NOME_FANTASIA_FORN.ColumnName = "NOME_FANTASIA_FORN";
            this.NOME_FANTASIA_FORN.MaxLength = 80;
            // 
            // TIPO_MATERIAL
            // 
            this.TIPO_MATERIAL.ColumnName = "TIPO_MATERIAL";
            this.TIPO_MATERIAL.MaxLength = 50;
            // 
            // TIPO_MATERIAL_2
            // 
            this.TIPO_MATERIAL_2.ColumnName = "TIPO_MATERIAL_2";
            this.TIPO_MATERIAL_2.MaxLength = 50;
            // 
            // TIPO_MATERIAL_3
            // 
            this.TIPO_MATERIAL_3.ColumnName = "TIPO_MATERIAL_3";
            this.TIPO_MATERIAL_3.MaxLength = 50;
            // 
            // TIPO_MATERIAL_4
            // 
            this.TIPO_MATERIAL_4.ColumnName = "TIPO_MATERIAL_4";
            this.TIPO_MATERIAL_4.MaxLength = 50;
            // 
            // CNPJ_CPF_FORN
            // 
            this.CNPJ_CPF_FORN.ColumnName = "CNPJ_CPF_FORN";
            this.CNPJ_CPF_FORN.MaxLength = 20;
            // 
            // IE_RG_FORN
            // 
            this.IE_RG_FORN.ColumnName = "IE_RG_FORN";
            this.IE_RG_FORN.MaxLength = 20;
            // 
            // ENDERECO_FORN
            // 
            this.ENDERECO_FORN.ColumnName = "ENDERECO_FORN";
            this.ENDERECO_FORN.MaxLength = 80;
            // 
            // BAIRRO_FORN
            // 
            this.BAIRRO_FORN.ColumnName = "BAIRRO_FORN";
            this.BAIRRO_FORN.MaxLength = 50;
            // 
            // CIDADE_FORN
            // 
            this.CIDADE_FORN.ColumnName = "CIDADE_FORN";
            this.CIDADE_FORN.MaxLength = 50;
            // 
            // CEP_FORN
            // 
            this.CEP_FORN.ColumnName = "CEP_FORN";
            this.CEP_FORN.MaxLength = 15;
            // 
            // ESTADO_FORN
            // 
            this.ESTADO_FORN.ColumnName = "ESTADO_FORN";
            this.ESTADO_FORN.MaxLength = 2;
            // 
            // PAIS_FORN
            // 
            this.PAIS_FORN.ColumnName = "PAIS_FORN";
            this.PAIS_FORN.MaxLength = 30;
            // 
            // EMAIL_FORN
            // 
            this.EMAIL_FORN.ColumnName = "EMAIL_FORN";
            this.EMAIL_FORN.MaxLength = 50;
            // 
            // TEL_FORN
            // 
            this.TEL_FORN.ColumnName = "TEL_FORN";
            this.TEL_FORN.MaxLength = 20;
            // 
            // CONTATO_FORN
            // 
            this.CONTATO_FORN.ColumnName = "CONTATO_FORN";
            this.CONTATO_FORN.MaxLength = 50;
            // 
            // TEL_CONTATO_FORN
            // 
            this.TEL_CONTATO_FORN.ColumnName = "TEL_CONTATO_FORN";
            this.TEL_CONTATO_FORN.MaxLength = 20;
            // 
            // EMAIL_CONTATO_FORN
            // 
            this.EMAIL_CONTATO_FORN.ColumnName = "EMAIL_CONTATO_FORN";
            this.EMAIL_CONTATO_FORN.MaxLength = 50;
            // 
            // OUTRAS_INF_FORN
            // 
            this.OUTRAS_INF_FORN.ColumnName = "OUTRAS_INF_FORN";
            this.OUTRAS_INF_FORN.MaxLength = 300;
            // 
            // ISO_FORN
            // 
            this.ISO_FORN.ColumnName = "ISO_FORN";
            this.ISO_FORN.DataType = typeof(int);
            // 
            // VALIDADE_ISO_FORN
            // 
            this.VALIDADE_ISO_FORN.ColumnName = "VALIDADE_ISO_FORN";
            this.VALIDADE_ISO_FORN.DataType = typeof(System.DateTime);
            // 
            // apaga_registro
            // 
            this.apaga_registro.Location = new System.Drawing.Point(296, 125);
            this.apaga_registro.Name = "apaga_registro";
            this.apaga_registro.Size = new System.Drawing.Size(49, 22);
            this.apaga_registro.TabIndex = 74;
            this.apaga_registro.Text = "Excluir";
            this.apaga_registro.UseVisualStyleBackColor = true;
            this.apaga_registro.Click += new System.EventHandler(this.apaga_registro_Click);
            // 
            // salva_registro
            // 
            this.salva_registro.Location = new System.Drawing.Point(351, 125);
            this.salva_registro.Name = "salva_registro";
            this.salva_registro.Size = new System.Drawing.Size(49, 22);
            this.salva_registro.TabIndex = 73;
            this.salva_registro.Text = "Salvar";
            this.salva_registro.UseVisualStyleBackColor = true;
            this.salva_registro.Click += new System.EventHandler(this.salva_registro_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(175, 125);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 22);
            this.button3.TabIndex = 76;
            this.button3.Text = "Localizar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // novo_registro
            // 
            this.novo_registro.Location = new System.Drawing.Point(241, 125);
            this.novo_registro.Name = "novo_registro";
            this.novo_registro.Size = new System.Drawing.Size(49, 22);
            this.novo_registro.TabIndex = 75;
            this.novo_registro.Text = "Novo";
            this.novo_registro.UseVisualStyleBackColor = true;
            this.novo_registro.Click += new System.EventHandler(this.novo_registro_Click);
            // 
            // datArea_forn
            // 
            this.datArea_forn.DeleteCommand = this.fbCommand4;
            this.datArea_forn.InsertCommand = this.fbCommand2;
            this.datArea_forn.SelectCommand = this.fbCommand1;
            this.datArea_forn.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * from area_atuacao_forn order by cod_area_forn";
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 21);
            this.button1.TabIndex = 78;
            this.button1.Text = "Fornecedores";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // datForn
            // 
            this.datForn.DeleteCommand = this.fbCommand8;
            this.datForn.InsertCommand = this.fbCommand6;
            this.datForn.SelectCommand = this.fbCommand5;
            this.datForn.UpdateCommand = this.fbCommand7;
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
            this.fbCommand5.CommandText = "select * from fornecedores order by razao_social_forn";
            this.fbCommand5.CommandTimeout = 30;
            this.fbCommand5.Connection = this.fbConnection1;
            // 
            // fbCommand7
            // 
            this.fbCommand7.CommandTimeout = 30;
            // 
            // fbCommandBuilder1
            // 
            this.fbCommandBuilder1.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.fbCommandBuilder1.DataAdapter = this.datArea_forn;
            this.fbCommandBuilder1.QuotePrefix = "\"";
            this.fbCommandBuilder1.QuoteSuffix = "\"";
            // 
            // col_cod
            // 
            this.col_cod.DataPropertyName = "COD_FORN";
            this.col_cod.HeaderText = "Cód.";
            this.col_cod.Name = "col_cod";
            // 
            // rAZAOSOCIALFORNDataGridViewTextBoxColumn
            // 
            this.rAZAOSOCIALFORNDataGridViewTextBoxColumn.DataPropertyName = "RAZAO_SOCIAL_FORN";
            this.rAZAOSOCIALFORNDataGridViewTextBoxColumn.HeaderText = "Razão Social";
            this.rAZAOSOCIALFORNDataGridViewTextBoxColumn.Name = "rAZAOSOCIALFORNDataGridViewTextBoxColumn";
            this.rAZAOSOCIALFORNDataGridViewTextBoxColumn.Width = 200;
            // 
            // nOMEFANTASIAFORNDataGridViewTextBoxColumn
            // 
            this.nOMEFANTASIAFORNDataGridViewTextBoxColumn.DataPropertyName = "NOME_FANTASIA_FORN";
            this.nOMEFANTASIAFORNDataGridViewTextBoxColumn.HeaderText = "Nome Fantasia";
            this.nOMEFANTASIAFORNDataGridViewTextBoxColumn.Name = "nOMEFANTASIAFORNDataGridViewTextBoxColumn";
            this.nOMEFANTASIAFORNDataGridViewTextBoxColumn.Width = 200;
            // 
            // tIPOMATERIALDataGridViewTextBoxColumn
            // 
            this.tIPOMATERIALDataGridViewTextBoxColumn.DataPropertyName = "TIPO_MATERIAL";
            this.tIPOMATERIALDataGridViewTextBoxColumn.HeaderText = "TIPO_MATERIAL";
            this.tIPOMATERIALDataGridViewTextBoxColumn.Name = "tIPOMATERIALDataGridViewTextBoxColumn";
            this.tIPOMATERIALDataGridViewTextBoxColumn.Visible = false;
            // 
            // tIPOMATERIAL2DataGridViewTextBoxColumn
            // 
            this.tIPOMATERIAL2DataGridViewTextBoxColumn.DataPropertyName = "TIPO_MATERIAL_2";
            this.tIPOMATERIAL2DataGridViewTextBoxColumn.HeaderText = "TIPO_MATERIAL_2";
            this.tIPOMATERIAL2DataGridViewTextBoxColumn.Name = "tIPOMATERIAL2DataGridViewTextBoxColumn";
            this.tIPOMATERIAL2DataGridViewTextBoxColumn.Visible = false;
            // 
            // tIPOMATERIAL3DataGridViewTextBoxColumn
            // 
            this.tIPOMATERIAL3DataGridViewTextBoxColumn.DataPropertyName = "TIPO_MATERIAL_3";
            this.tIPOMATERIAL3DataGridViewTextBoxColumn.HeaderText = "TIPO_MATERIAL_3";
            this.tIPOMATERIAL3DataGridViewTextBoxColumn.Name = "tIPOMATERIAL3DataGridViewTextBoxColumn";
            this.tIPOMATERIAL3DataGridViewTextBoxColumn.Visible = false;
            // 
            // tIPOMATERIAL4DataGridViewTextBoxColumn
            // 
            this.tIPOMATERIAL4DataGridViewTextBoxColumn.DataPropertyName = "TIPO_MATERIAL_4";
            this.tIPOMATERIAL4DataGridViewTextBoxColumn.HeaderText = "TIPO_MATERIAL_4";
            this.tIPOMATERIAL4DataGridViewTextBoxColumn.Name = "tIPOMATERIAL4DataGridViewTextBoxColumn";
            this.tIPOMATERIAL4DataGridViewTextBoxColumn.Visible = false;
            // 
            // cNPJCPFFORNDataGridViewTextBoxColumn
            // 
            this.cNPJCPFFORNDataGridViewTextBoxColumn.DataPropertyName = "CNPJ_CPF_FORN";
            this.cNPJCPFFORNDataGridViewTextBoxColumn.HeaderText = "CNPJ_CPF_FORN";
            this.cNPJCPFFORNDataGridViewTextBoxColumn.Name = "cNPJCPFFORNDataGridViewTextBoxColumn";
            this.cNPJCPFFORNDataGridViewTextBoxColumn.Visible = false;
            // 
            // iERGFORNDataGridViewTextBoxColumn
            // 
            this.iERGFORNDataGridViewTextBoxColumn.DataPropertyName = "IE_RG_FORN";
            this.iERGFORNDataGridViewTextBoxColumn.HeaderText = "IE_RG_FORN";
            this.iERGFORNDataGridViewTextBoxColumn.Name = "iERGFORNDataGridViewTextBoxColumn";
            this.iERGFORNDataGridViewTextBoxColumn.Visible = false;
            // 
            // eNDERECOFORNDataGridViewTextBoxColumn
            // 
            this.eNDERECOFORNDataGridViewTextBoxColumn.DataPropertyName = "ENDERECO_FORN";
            this.eNDERECOFORNDataGridViewTextBoxColumn.HeaderText = "ENDERECO_FORN";
            this.eNDERECOFORNDataGridViewTextBoxColumn.Name = "eNDERECOFORNDataGridViewTextBoxColumn";
            this.eNDERECOFORNDataGridViewTextBoxColumn.Visible = false;
            // 
            // bAIRROFORNDataGridViewTextBoxColumn
            // 
            this.bAIRROFORNDataGridViewTextBoxColumn.DataPropertyName = "BAIRRO_FORN";
            this.bAIRROFORNDataGridViewTextBoxColumn.HeaderText = "BAIRRO_FORN";
            this.bAIRROFORNDataGridViewTextBoxColumn.Name = "bAIRROFORNDataGridViewTextBoxColumn";
            this.bAIRROFORNDataGridViewTextBoxColumn.Visible = false;
            // 
            // cIDADEFORNDataGridViewTextBoxColumn
            // 
            this.cIDADEFORNDataGridViewTextBoxColumn.DataPropertyName = "CIDADE_FORN";
            this.cIDADEFORNDataGridViewTextBoxColumn.HeaderText = "CIDADE_FORN";
            this.cIDADEFORNDataGridViewTextBoxColumn.Name = "cIDADEFORNDataGridViewTextBoxColumn";
            this.cIDADEFORNDataGridViewTextBoxColumn.Visible = false;
            // 
            // cEPFORNDataGridViewTextBoxColumn
            // 
            this.cEPFORNDataGridViewTextBoxColumn.DataPropertyName = "CEP_FORN";
            this.cEPFORNDataGridViewTextBoxColumn.HeaderText = "CEP_FORN";
            this.cEPFORNDataGridViewTextBoxColumn.Name = "cEPFORNDataGridViewTextBoxColumn";
            this.cEPFORNDataGridViewTextBoxColumn.Visible = false;
            // 
            // eSTADOFORNDataGridViewTextBoxColumn
            // 
            this.eSTADOFORNDataGridViewTextBoxColumn.DataPropertyName = "ESTADO_FORN";
            this.eSTADOFORNDataGridViewTextBoxColumn.HeaderText = "ESTADO_FORN";
            this.eSTADOFORNDataGridViewTextBoxColumn.Name = "eSTADOFORNDataGridViewTextBoxColumn";
            this.eSTADOFORNDataGridViewTextBoxColumn.Visible = false;
            // 
            // pAISFORNDataGridViewTextBoxColumn
            // 
            this.pAISFORNDataGridViewTextBoxColumn.DataPropertyName = "PAIS_FORN";
            this.pAISFORNDataGridViewTextBoxColumn.HeaderText = "PAIS_FORN";
            this.pAISFORNDataGridViewTextBoxColumn.Name = "pAISFORNDataGridViewTextBoxColumn";
            this.pAISFORNDataGridViewTextBoxColumn.Visible = false;
            // 
            // eMAILFORNDataGridViewTextBoxColumn
            // 
            this.eMAILFORNDataGridViewTextBoxColumn.DataPropertyName = "EMAIL_FORN";
            this.eMAILFORNDataGridViewTextBoxColumn.HeaderText = "EMAIL_FORN";
            this.eMAILFORNDataGridViewTextBoxColumn.Name = "eMAILFORNDataGridViewTextBoxColumn";
            this.eMAILFORNDataGridViewTextBoxColumn.Visible = false;
            // 
            // tELFORNDataGridViewTextBoxColumn
            // 
            this.tELFORNDataGridViewTextBoxColumn.DataPropertyName = "TEL_FORN";
            this.tELFORNDataGridViewTextBoxColumn.HeaderText = "TEL_FORN";
            this.tELFORNDataGridViewTextBoxColumn.Name = "tELFORNDataGridViewTextBoxColumn";
            this.tELFORNDataGridViewTextBoxColumn.Visible = false;
            // 
            // cONTATOFORNDataGridViewTextBoxColumn
            // 
            this.cONTATOFORNDataGridViewTextBoxColumn.DataPropertyName = "CONTATO_FORN";
            this.cONTATOFORNDataGridViewTextBoxColumn.HeaderText = "CONTATO_FORN";
            this.cONTATOFORNDataGridViewTextBoxColumn.Name = "cONTATOFORNDataGridViewTextBoxColumn";
            this.cONTATOFORNDataGridViewTextBoxColumn.Visible = false;
            // 
            // tELCONTATOFORNDataGridViewTextBoxColumn
            // 
            this.tELCONTATOFORNDataGridViewTextBoxColumn.DataPropertyName = "TEL_CONTATO_FORN";
            this.tELCONTATOFORNDataGridViewTextBoxColumn.HeaderText = "TEL_CONTATO_FORN";
            this.tELCONTATOFORNDataGridViewTextBoxColumn.Name = "tELCONTATOFORNDataGridViewTextBoxColumn";
            this.tELCONTATOFORNDataGridViewTextBoxColumn.Visible = false;
            // 
            // eMAILCONTATOFORNDataGridViewTextBoxColumn
            // 
            this.eMAILCONTATOFORNDataGridViewTextBoxColumn.DataPropertyName = "EMAIL_CONTATO_FORN";
            this.eMAILCONTATOFORNDataGridViewTextBoxColumn.HeaderText = "EMAIL_CONTATO_FORN";
            this.eMAILCONTATOFORNDataGridViewTextBoxColumn.Name = "eMAILCONTATOFORNDataGridViewTextBoxColumn";
            this.eMAILCONTATOFORNDataGridViewTextBoxColumn.Visible = false;
            // 
            // oUTRASINFFORNDataGridViewTextBoxColumn
            // 
            this.oUTRASINFFORNDataGridViewTextBoxColumn.DataPropertyName = "OUTRAS_INF_FORN";
            this.oUTRASINFFORNDataGridViewTextBoxColumn.HeaderText = "OUTRAS_INF_FORN";
            this.oUTRASINFFORNDataGridViewTextBoxColumn.Name = "oUTRASINFFORNDataGridViewTextBoxColumn";
            this.oUTRASINFFORNDataGridViewTextBoxColumn.Visible = false;
            // 
            // iSOFORNDataGridViewTextBoxColumn
            // 
            this.iSOFORNDataGridViewTextBoxColumn.DataPropertyName = "ISO_FORN";
            this.iSOFORNDataGridViewTextBoxColumn.HeaderText = "ISO_FORN";
            this.iSOFORNDataGridViewTextBoxColumn.Name = "iSOFORNDataGridViewTextBoxColumn";
            this.iSOFORNDataGridViewTextBoxColumn.Visible = false;
            // 
            // vALIDADEISOFORNDataGridViewTextBoxColumn
            // 
            this.vALIDADEISOFORNDataGridViewTextBoxColumn.DataPropertyName = "VALIDADE_ISO_FORN";
            this.vALIDADEISOFORNDataGridViewTextBoxColumn.HeaderText = "VALIDADE_ISO_FORN";
            this.vALIDADEISOFORNDataGridViewTextBoxColumn.Name = "vALIDADEISOFORNDataGridViewTextBoxColumn";
            this.vALIDADEISOFORNDataGridViewTextBoxColumn.Visible = false;
            // 
            // form_area_atuacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 341);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.apaga_registro);
            this.Controls.Add(this.salva_registro);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.novo_registro);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.tb_descricao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.label1);
            this.Name = "form_area_atuacao";
            this.Text = "Área de Atuação Fornecedores";
            ((System.ComponentModel.ISupportInitialize)(this.dsArea_forn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AREA_ATUACAO_FORN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsForn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FORNECEDORES)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tb_descricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox codigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button apaga_registro;
        private System.Windows.Forms.Button salva_registro;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button novo_registro;
        private System.Data.DataSet dsArea_forn;
        private System.Data.DataTable AREA_ATUACAO_FORN;
        private System.Data.DataColumn COD_AREA_FORN;
        private System.Data.DataColumn DESCRICAO_AREA_FORN;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datArea_forn;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Data.DataSet dsForn;
        private System.Data.DataTable FORNECEDORES;
        private System.Data.DataColumn COD_FORN;
        private System.Data.DataColumn RAZAO_SOCIAL_FORN;
        private System.Data.DataColumn NOME_FANTASIA_FORN;
        private System.Data.DataColumn TIPO_MATERIAL;
        private System.Data.DataColumn TIPO_MATERIAL_2;
        private System.Data.DataColumn TIPO_MATERIAL_3;
        private System.Data.DataColumn TIPO_MATERIAL_4;
        private System.Data.DataColumn CNPJ_CPF_FORN;
        private System.Data.DataColumn IE_RG_FORN;
        private System.Data.DataColumn ENDERECO_FORN;
        private System.Data.DataColumn BAIRRO_FORN;
        private System.Data.DataColumn CIDADE_FORN;
        private System.Data.DataColumn CEP_FORN;
        private System.Data.DataColumn ESTADO_FORN;
        private System.Data.DataColumn PAIS_FORN;
        private System.Data.DataColumn EMAIL_FORN;
        private System.Data.DataColumn TEL_FORN;
        private System.Data.DataColumn CONTATO_FORN;
        private System.Data.DataColumn TEL_CONTATO_FORN;
        private System.Data.DataColumn EMAIL_CONTATO_FORN;
        private System.Data.DataColumn OUTRAS_INF_FORN;
        private System.Data.DataColumn ISO_FORN;
        private System.Data.DataColumn VALIDADE_ISO_FORN;
        private System.Windows.Forms.Button button1;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datForn;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand8;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand6;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand5;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand7;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder fbCommandBuilder1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAZAOSOCIALFORNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMEFANTASIAFORNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIPOMATERIALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIPOMATERIAL2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIPOMATERIAL3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIPOMATERIAL4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPJCPFFORNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iERGFORNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNDERECOFORNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bAIRROFORNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDADEFORNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEPFORNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTADOFORNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAISFORNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILFORNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tELFORNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONTATOFORNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tELCONTATOFORNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILCONTATOFORNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oUTRASINFFORNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSOFORNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALIDADEISOFORNDataGridViewTextBoxColumn;
    }
}