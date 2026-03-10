namespace Evolucao
{
    partial class form_localiza_forn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_localiza_forn));
            this.tb_localiza = new System.Windows.Forms.TextBox();
            this.dgvForn = new System.Windows.Forms.DataGridView();
            this.col_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_razao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_FORN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIPOMATERIALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIPOMATERIAL2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIPOMATERIAL3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIPOMATERIAL4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iERGFORNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNDERECOFORNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bAIRROFORNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIDADEFORNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEPFORNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAISFORNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILFORNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tELFORNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONTATOFORNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tELCONTATOFORNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILCONTATOFORNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oUTRASINFFORNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.datForn = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand5 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand6 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand7 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand8 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_cnpj = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvForn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsForn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FORNECEDORES)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_localiza
            // 
            this.tb_localiza.Location = new System.Drawing.Point(9, 26);
            this.tb_localiza.Name = "tb_localiza";
            this.tb_localiza.Size = new System.Drawing.Size(233, 20);
            this.tb_localiza.TabIndex = 5;
            this.tb_localiza.TextChanged += new System.EventHandler(this.tb_localiza_TextChanged);
            // 
            // dgvForn
            // 
            this.dgvForn.AllowUserToAddRows = false;
            this.dgvForn.AutoGenerateColumns = false;
            this.dgvForn.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvForn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvForn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_cod,
            this.col_razao,
            this.NOME_FORN,
            this.col_cnpj,
            this.col_estado,
            this.tIPOMATERIALDataGridViewTextBoxColumn,
            this.tIPOMATERIAL2DataGridViewTextBoxColumn,
            this.tIPOMATERIAL3DataGridViewTextBoxColumn,
            this.tIPOMATERIAL4DataGridViewTextBoxColumn,
            this.iERGFORNDataGridViewTextBoxColumn,
            this.eNDERECOFORNDataGridViewTextBoxColumn,
            this.bAIRROFORNDataGridViewTextBoxColumn,
            this.cIDADEFORNDataGridViewTextBoxColumn,
            this.cEPFORNDataGridViewTextBoxColumn,
            this.pAISFORNDataGridViewTextBoxColumn,
            this.eMAILFORNDataGridViewTextBoxColumn,
            this.tELFORNDataGridViewTextBoxColumn,
            this.cONTATOFORNDataGridViewTextBoxColumn,
            this.tELCONTATOFORNDataGridViewTextBoxColumn,
            this.eMAILCONTATOFORNDataGridViewTextBoxColumn,
            this.oUTRASINFFORNDataGridViewTextBoxColumn});
            this.dgvForn.DataMember = "FORNECEDORES";
            this.dgvForn.DataSource = this.dsForn;
            this.dgvForn.Location = new System.Drawing.Point(3, 78);
            this.dgvForn.Name = "dgvForn";
            this.dgvForn.ReadOnly = true;
            this.dgvForn.RowHeadersVisible = false;
            this.dgvForn.Size = new System.Drawing.Size(669, 351);
            this.dgvForn.TabIndex = 4;
            this.dgvForn.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvForn_CellDoubleClick);
            this.dgvForn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvForn_CellContentClick);
            // 
            // col_cod
            // 
            this.col_cod.DataPropertyName = "COD_FORN";
            this.col_cod.HeaderText = "Cód.";
            this.col_cod.Name = "col_cod";
            this.col_cod.ReadOnly = true;
            this.col_cod.Width = 50;
            // 
            // col_razao
            // 
            this.col_razao.DataPropertyName = "RAZAO_SOCIAL_FORN";
            this.col_razao.HeaderText = "Razão Social";
            this.col_razao.Name = "col_razao";
            this.col_razao.ReadOnly = true;
            this.col_razao.Width = 200;
            // 
            // NOME_FORN
            // 
            this.NOME_FORN.DataPropertyName = "NOME_FORN";
            this.NOME_FORN.HeaderText = "Nome Fantasia";
            this.NOME_FORN.Name = "NOME_FORN";
            this.NOME_FORN.ReadOnly = true;
            this.NOME_FORN.Width = 200;
            // 
            // col_cnpj
            // 
            this.col_cnpj.DataPropertyName = "CNPJ_CPF_FORN";
            this.col_cnpj.HeaderText = "CNPJ";
            this.col_cnpj.Name = "col_cnpj";
            this.col_cnpj.ReadOnly = true;
            this.col_cnpj.Width = 180;
            // 
            // col_estado
            // 
            this.col_estado.DataPropertyName = "ESTADO_FORN";
            this.col_estado.HeaderText = "UF";
            this.col_estado.Name = "col_estado";
            this.col_estado.ReadOnly = true;
            // 
            // tIPOMATERIALDataGridViewTextBoxColumn
            // 
            this.tIPOMATERIALDataGridViewTextBoxColumn.DataPropertyName = "TIPO_MATERIAL";
            this.tIPOMATERIALDataGridViewTextBoxColumn.HeaderText = "TIPO_MATERIAL";
            this.tIPOMATERIALDataGridViewTextBoxColumn.Name = "tIPOMATERIALDataGridViewTextBoxColumn";
            this.tIPOMATERIALDataGridViewTextBoxColumn.ReadOnly = true;
            this.tIPOMATERIALDataGridViewTextBoxColumn.Visible = false;
            // 
            // tIPOMATERIAL2DataGridViewTextBoxColumn
            // 
            this.tIPOMATERIAL2DataGridViewTextBoxColumn.DataPropertyName = "TIPO_MATERIAL_2";
            this.tIPOMATERIAL2DataGridViewTextBoxColumn.HeaderText = "TIPO_MATERIAL_2";
            this.tIPOMATERIAL2DataGridViewTextBoxColumn.Name = "tIPOMATERIAL2DataGridViewTextBoxColumn";
            this.tIPOMATERIAL2DataGridViewTextBoxColumn.ReadOnly = true;
            this.tIPOMATERIAL2DataGridViewTextBoxColumn.Visible = false;
            // 
            // tIPOMATERIAL3DataGridViewTextBoxColumn
            // 
            this.tIPOMATERIAL3DataGridViewTextBoxColumn.DataPropertyName = "TIPO_MATERIAL_3";
            this.tIPOMATERIAL3DataGridViewTextBoxColumn.HeaderText = "TIPO_MATERIAL_3";
            this.tIPOMATERIAL3DataGridViewTextBoxColumn.Name = "tIPOMATERIAL3DataGridViewTextBoxColumn";
            this.tIPOMATERIAL3DataGridViewTextBoxColumn.ReadOnly = true;
            this.tIPOMATERIAL3DataGridViewTextBoxColumn.Visible = false;
            // 
            // tIPOMATERIAL4DataGridViewTextBoxColumn
            // 
            this.tIPOMATERIAL4DataGridViewTextBoxColumn.DataPropertyName = "TIPO_MATERIAL_4";
            this.tIPOMATERIAL4DataGridViewTextBoxColumn.HeaderText = "TIPO_MATERIAL_4";
            this.tIPOMATERIAL4DataGridViewTextBoxColumn.Name = "tIPOMATERIAL4DataGridViewTextBoxColumn";
            this.tIPOMATERIAL4DataGridViewTextBoxColumn.ReadOnly = true;
            this.tIPOMATERIAL4DataGridViewTextBoxColumn.Visible = false;
            // 
            // iERGFORNDataGridViewTextBoxColumn
            // 
            this.iERGFORNDataGridViewTextBoxColumn.DataPropertyName = "IE_RG_FORN";
            this.iERGFORNDataGridViewTextBoxColumn.HeaderText = "IE_RG_FORN";
            this.iERGFORNDataGridViewTextBoxColumn.Name = "iERGFORNDataGridViewTextBoxColumn";
            this.iERGFORNDataGridViewTextBoxColumn.ReadOnly = true;
            this.iERGFORNDataGridViewTextBoxColumn.Visible = false;
            // 
            // eNDERECOFORNDataGridViewTextBoxColumn
            // 
            this.eNDERECOFORNDataGridViewTextBoxColumn.DataPropertyName = "ENDERECO_FORN";
            this.eNDERECOFORNDataGridViewTextBoxColumn.HeaderText = "ENDERECO_FORN";
            this.eNDERECOFORNDataGridViewTextBoxColumn.Name = "eNDERECOFORNDataGridViewTextBoxColumn";
            this.eNDERECOFORNDataGridViewTextBoxColumn.ReadOnly = true;
            this.eNDERECOFORNDataGridViewTextBoxColumn.Visible = false;
            // 
            // bAIRROFORNDataGridViewTextBoxColumn
            // 
            this.bAIRROFORNDataGridViewTextBoxColumn.DataPropertyName = "BAIRRO_FORN";
            this.bAIRROFORNDataGridViewTextBoxColumn.HeaderText = "BAIRRO_FORN";
            this.bAIRROFORNDataGridViewTextBoxColumn.Name = "bAIRROFORNDataGridViewTextBoxColumn";
            this.bAIRROFORNDataGridViewTextBoxColumn.ReadOnly = true;
            this.bAIRROFORNDataGridViewTextBoxColumn.Visible = false;
            // 
            // cIDADEFORNDataGridViewTextBoxColumn
            // 
            this.cIDADEFORNDataGridViewTextBoxColumn.DataPropertyName = "CIDADE_FORN";
            this.cIDADEFORNDataGridViewTextBoxColumn.HeaderText = "CIDADE_FORN";
            this.cIDADEFORNDataGridViewTextBoxColumn.Name = "cIDADEFORNDataGridViewTextBoxColumn";
            this.cIDADEFORNDataGridViewTextBoxColumn.ReadOnly = true;
            this.cIDADEFORNDataGridViewTextBoxColumn.Visible = false;
            // 
            // cEPFORNDataGridViewTextBoxColumn
            // 
            this.cEPFORNDataGridViewTextBoxColumn.DataPropertyName = "CEP_FORN";
            this.cEPFORNDataGridViewTextBoxColumn.HeaderText = "CEP_FORN";
            this.cEPFORNDataGridViewTextBoxColumn.Name = "cEPFORNDataGridViewTextBoxColumn";
            this.cEPFORNDataGridViewTextBoxColumn.ReadOnly = true;
            this.cEPFORNDataGridViewTextBoxColumn.Visible = false;
            // 
            // pAISFORNDataGridViewTextBoxColumn
            // 
            this.pAISFORNDataGridViewTextBoxColumn.DataPropertyName = "PAIS_FORN";
            this.pAISFORNDataGridViewTextBoxColumn.HeaderText = "PAIS_FORN";
            this.pAISFORNDataGridViewTextBoxColumn.Name = "pAISFORNDataGridViewTextBoxColumn";
            this.pAISFORNDataGridViewTextBoxColumn.ReadOnly = true;
            this.pAISFORNDataGridViewTextBoxColumn.Visible = false;
            // 
            // eMAILFORNDataGridViewTextBoxColumn
            // 
            this.eMAILFORNDataGridViewTextBoxColumn.DataPropertyName = "EMAIL_FORN";
            this.eMAILFORNDataGridViewTextBoxColumn.HeaderText = "EMAIL_FORN";
            this.eMAILFORNDataGridViewTextBoxColumn.Name = "eMAILFORNDataGridViewTextBoxColumn";
            this.eMAILFORNDataGridViewTextBoxColumn.ReadOnly = true;
            this.eMAILFORNDataGridViewTextBoxColumn.Visible = false;
            // 
            // tELFORNDataGridViewTextBoxColumn
            // 
            this.tELFORNDataGridViewTextBoxColumn.DataPropertyName = "TEL_FORN";
            this.tELFORNDataGridViewTextBoxColumn.HeaderText = "TEL_FORN";
            this.tELFORNDataGridViewTextBoxColumn.Name = "tELFORNDataGridViewTextBoxColumn";
            this.tELFORNDataGridViewTextBoxColumn.ReadOnly = true;
            this.tELFORNDataGridViewTextBoxColumn.Visible = false;
            // 
            // cONTATOFORNDataGridViewTextBoxColumn
            // 
            this.cONTATOFORNDataGridViewTextBoxColumn.DataPropertyName = "CONTATO_FORN";
            this.cONTATOFORNDataGridViewTextBoxColumn.HeaderText = "CONTATO_FORN";
            this.cONTATOFORNDataGridViewTextBoxColumn.Name = "cONTATOFORNDataGridViewTextBoxColumn";
            this.cONTATOFORNDataGridViewTextBoxColumn.ReadOnly = true;
            this.cONTATOFORNDataGridViewTextBoxColumn.Visible = false;
            // 
            // tELCONTATOFORNDataGridViewTextBoxColumn
            // 
            this.tELCONTATOFORNDataGridViewTextBoxColumn.DataPropertyName = "TEL_CONTATO_FORN";
            this.tELCONTATOFORNDataGridViewTextBoxColumn.HeaderText = "TEL_CONTATO_FORN";
            this.tELCONTATOFORNDataGridViewTextBoxColumn.Name = "tELCONTATOFORNDataGridViewTextBoxColumn";
            this.tELCONTATOFORNDataGridViewTextBoxColumn.ReadOnly = true;
            this.tELCONTATOFORNDataGridViewTextBoxColumn.Visible = false;
            // 
            // eMAILCONTATOFORNDataGridViewTextBoxColumn
            // 
            this.eMAILCONTATOFORNDataGridViewTextBoxColumn.DataPropertyName = "EMAIL_CONTATO_FORN";
            this.eMAILCONTATOFORNDataGridViewTextBoxColumn.HeaderText = "EMAIL_CONTATO_FORN";
            this.eMAILCONTATOFORNDataGridViewTextBoxColumn.Name = "eMAILCONTATOFORNDataGridViewTextBoxColumn";
            this.eMAILCONTATOFORNDataGridViewTextBoxColumn.ReadOnly = true;
            this.eMAILCONTATOFORNDataGridViewTextBoxColumn.Visible = false;
            // 
            // oUTRASINFFORNDataGridViewTextBoxColumn
            // 
            this.oUTRASINFFORNDataGridViewTextBoxColumn.DataPropertyName = "OUTRAS_INF_FORN";
            this.oUTRASINFFORNDataGridViewTextBoxColumn.HeaderText = "OUTRAS_INF_FORN";
            this.oUTRASINFFORNDataGridViewTextBoxColumn.Name = "oUTRASINFFORNDataGridViewTextBoxColumn";
            this.oUTRASINFFORNDataGridViewTextBoxColumn.ReadOnly = true;
            this.oUTRASINFFORNDataGridViewTextBoxColumn.Visible = false;
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
            this.OUTRAS_INF_FORN});
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
            this.NOME_FANTASIA_FORN.Caption = "NOME_FORN";
            this.NOME_FANTASIA_FORN.ColumnName = "NOME_FORN";
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
            // datForn
            // 
            this.datForn.DeleteCommand = this.fbCommand4;
            this.datForn.InsertCommand = this.fbCommand2;
            this.datForn.SelectCommand = this.fbCommand1;
            this.datForn.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * from fornecedores order by razao_social_forn";
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
            // fbCommand5
            // 
            this.fbCommand5.CommandTimeout = 30;
            // 
            // fbCommand6
            // 
            this.fbCommand6.CommandTimeout = 30;
            // 
            // fbCommand7
            // 
            this.fbCommand7.CommandTimeout = 30;
            // 
            // fbCommand8
            // 
            this.fbCommand8.CommandTimeout = 30;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(248, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Razão Social";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nome Fantasia";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tb_cnpj);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.tb_localiza);
            this.panel1.Location = new System.Drawing.Point(3, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(669, 61);
            this.panel1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(436, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "CNPJ";
            // 
            // tb_cnpj
            // 
            this.tb_cnpj.Location = new System.Drawing.Point(436, 26);
            this.tb_cnpj.Name = "tb_cnpj";
            this.tb_cnpj.Size = new System.Drawing.Size(182, 20);
            this.tb_cnpj.TabIndex = 9;
            this.tb_cnpj.TextChanged += new System.EventHandler(this.tb_cnpj_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(292, 436);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Modificar Cadastro";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // form_localiza_forn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 471);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvForn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "form_localiza_forn";
            this.Text = "Localiza Fornecedor";
            this.Load += new System.EventHandler(this.form_localiza_forn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvForn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsForn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FORNECEDORES)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tb_localiza;
        private System.Windows.Forms.DataGridView dgvForn;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datForn;
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
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand5;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand6;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand7;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_cnpj;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_razao;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_FORN;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIPOMATERIALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIPOMATERIAL2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIPOMATERIAL3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIPOMATERIAL4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iERGFORNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNDERECOFORNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bAIRROFORNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDADEFORNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEPFORNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAISFORNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILFORNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tELFORNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONTATOFORNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tELCONTATOFORNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILCONTATOFORNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oUTRASINFFORNDataGridViewTextBoxColumn;
    }
}