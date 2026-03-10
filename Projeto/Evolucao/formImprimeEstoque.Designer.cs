namespace Evolucao
{
    partial class formImprimeEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formImprimeEstoque));
            this.cbxFornecedores = new System.Windows.Forms.ComboBox();
            this.cbxGrupos = new System.Windows.Forms.ComboBox();
            this.cbxSubGrupos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataFim = new System.Windows.Forms.DateTimePicker();
            this.dataInicio = new System.Windows.Forms.DateTimePicker();
            this.rbtnImpressaoDetalhada = new System.Windows.Forms.RadioButton();
            this.rbtnImpressaoSimples = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.datFornecedores = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsFornecedores = new System.Data.DataSet();
            this.FORNECEDORES = new System.Data.DataTable();
            this.COD_FORN = new System.Data.DataColumn();
            this.NOME_FORN = new System.Data.DataColumn();
            this.TEL_FORN = new System.Data.DataColumn();
            this.RAZAO_SOCIAL_FORN = new System.Data.DataColumn();
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
            this.CONTATO_FORN = new System.Data.DataColumn();
            this.TEL_CONTATO_FORN = new System.Data.DataColumn();
            this.EMAIL_CONTATO_FORN = new System.Data.DataColumn();
            this.OUTRAS_INF_FORN = new System.Data.DataColumn();
            this.ISO_FORN = new System.Data.DataColumn();
            this.VALIDADE_ISO_FORN = new System.Data.DataColumn();
            this.CERT_UNI_FORN = new System.Data.DataColumn();
            this.VALIDADE_CERT_UNI_FORN = new System.Data.DataColumn();
            this.NOTA_CERT_UNI_FORN = new System.Data.DataColumn();
            this.datGrupos = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand8 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand6 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand5 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand7 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsGrupos = new System.Data.DataSet();
            this.GRUPOS = new System.Data.DataTable();
            this.COD_GRUPO = new System.Data.DataColumn();
            this.DESCRICAO_GRUPO = new System.Data.DataColumn();
            this.datSubGrupos = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand12 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand10 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand9 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand11 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsSubGrupos = new System.Data.DataSet();
            this.SUB_GRUPOS = new System.Data.DataTable();
            this.COD_SUB_GRUPOS = new System.Data.DataColumn();
            this.COD_GRUPO_SUB_GRUPO = new System.Data.DataColumn();
            this.DESCRICAO_GRUPO_SUB_GRUPO = new System.Data.DataColumn();
            this.DESCRICAO_SUB_GRUPO = new System.Data.DataColumn();
            this.datProdutos = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand16 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand14 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand13 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand15 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsFornecedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FORNECEDORES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGrupos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRUPOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSubGrupos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SUB_GRUPOS)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxFornecedores
            // 
            this.cbxFornecedores.FormattingEnabled = true;
            this.cbxFornecedores.Location = new System.Drawing.Point(9, 33);
            this.cbxFornecedores.Name = "cbxFornecedores";
            this.cbxFornecedores.Size = new System.Drawing.Size(346, 21);
            this.cbxFornecedores.TabIndex = 0;
            // 
            // cbxGrupos
            // 
            this.cbxGrupos.FormattingEnabled = true;
            this.cbxGrupos.Location = new System.Drawing.Point(9, 72);
            this.cbxGrupos.Name = "cbxGrupos";
            this.cbxGrupos.Size = new System.Drawing.Size(346, 21);
            this.cbxGrupos.TabIndex = 1;
            // 
            // cbxSubGrupos
            // 
            this.cbxSubGrupos.FormattingEnabled = true;
            this.cbxSubGrupos.Location = new System.Drawing.Point(9, 112);
            this.cbxSubGrupos.Name = "cbxSubGrupos";
            this.cbxSubGrupos.Size = new System.Drawing.Size(346, 21);
            this.cbxSubGrupos.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fornecedor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Grupo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sub-Grupo:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(627, 150);
            this.panel1.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dataFim);
            this.groupBox1.Controls.Add(this.dataInicio);
            this.groupBox1.Controls.Add(this.rbtnImpressaoDetalhada);
            this.groupBox1.Controls.Add(this.rbtnImpressaoSimples);
            this.groupBox1.Location = new System.Drawing.Point(377, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 138);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Impressão";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Fim:";
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Início:";
            this.label4.Visible = false;
            // 
            // dataFim
            // 
            this.dataFim.Enabled = false;
            this.dataFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataFim.Location = new System.Drawing.Point(108, 90);
            this.dataFim.Name = "dataFim";
            this.dataFim.Size = new System.Drawing.Size(96, 20);
            this.dataFim.TabIndex = 3;
            this.dataFim.Visible = false;
            // 
            // dataInicio
            // 
            this.dataInicio.Enabled = false;
            this.dataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataInicio.Location = new System.Drawing.Point(6, 90);
            this.dataInicio.Name = "dataInicio";
            this.dataInicio.Size = new System.Drawing.Size(96, 20);
            this.dataInicio.TabIndex = 2;
            this.dataInicio.Visible = false;
            // 
            // rbtnImpressaoDetalhada
            // 
            this.rbtnImpressaoDetalhada.AutoSize = true;
            this.rbtnImpressaoDetalhada.Location = new System.Drawing.Point(97, 34);
            this.rbtnImpressaoDetalhada.Name = "rbtnImpressaoDetalhada";
            this.rbtnImpressaoDetalhada.Size = new System.Drawing.Size(74, 17);
            this.rbtnImpressaoDetalhada.TabIndex = 1;
            this.rbtnImpressaoDetalhada.TabStop = true;
            this.rbtnImpressaoDetalhada.Text = "Detalhada";
            this.rbtnImpressaoDetalhada.UseVisualStyleBackColor = true;
            this.rbtnImpressaoDetalhada.Visible = false;
            this.rbtnImpressaoDetalhada.Click += new System.EventHandler(this.rbtnImpressaoDetalhada_Click);
            // 
            // rbtnImpressaoSimples
            // 
            this.rbtnImpressaoSimples.AutoSize = true;
            this.rbtnImpressaoSimples.Location = new System.Drawing.Point(6, 34);
            this.rbtnImpressaoSimples.Name = "rbtnImpressaoSimples";
            this.rbtnImpressaoSimples.Size = new System.Drawing.Size(61, 17);
            this.rbtnImpressaoSimples.TabIndex = 0;
            this.rbtnImpressaoSimples.TabStop = true;
            this.rbtnImpressaoSimples.Text = "Simples";
            this.rbtnImpressaoSimples.UseVisualStyleBackColor = true;
            this.rbtnImpressaoSimples.Click += new System.EventHandler(this.rbtnImpressaoSimples_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbxFornecedores);
            this.groupBox2.Controls.Add(this.cbxSubGrupos);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbxGrupos);
            this.groupBox2.Location = new System.Drawing.Point(10, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 138);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Condições:";
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackgroundImage = global::Evolucao.Properties.Resources.impressora;
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnImprimir.Location = new System.Drawing.Point(12, 168);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(80, 80);
            this.btnImprimir.TabIndex = 14;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // datFornecedores
            // 
            this.datFornecedores.DeleteCommand = this.fbCommand4;
            this.datFornecedores.InsertCommand = this.fbCommand2;
            this.datFornecedores.SelectCommand = this.fbCommand1;
            this.datFornecedores.UpdateCommand = this.fbCommand3;
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
            // dsFornecedores
            // 
            this.dsFornecedores.DataSetName = "dsFornecedores";
            this.dsFornecedores.Namespace = "http://www.tempuri.org/dsFornecedores.xsd";
            this.dsFornecedores.Tables.AddRange(new System.Data.DataTable[] {
            this.FORNECEDORES});
            // 
            // FORNECEDORES
            // 
            this.FORNECEDORES.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_FORN,
            this.NOME_FORN,
            this.TEL_FORN,
            this.RAZAO_SOCIAL_FORN,
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
            this.CONTATO_FORN,
            this.TEL_CONTATO_FORN,
            this.EMAIL_CONTATO_FORN,
            this.OUTRAS_INF_FORN,
            this.ISO_FORN,
            this.VALIDADE_ISO_FORN,
            this.CERT_UNI_FORN,
            this.VALIDADE_CERT_UNI_FORN,
            this.NOTA_CERT_UNI_FORN});
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
            // NOME_FORN
            // 
            this.NOME_FORN.ColumnName = "NOME_FORN";
            this.NOME_FORN.MaxLength = 50;
            // 
            // TEL_FORN
            // 
            this.TEL_FORN.ColumnName = "TEL_FORN";
            this.TEL_FORN.MaxLength = 20;
            // 
            // RAZAO_SOCIAL_FORN
            // 
            this.RAZAO_SOCIAL_FORN.ColumnName = "RAZAO_SOCIAL_FORN";
            this.RAZAO_SOCIAL_FORN.MaxLength = 80;
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
            // CERT_UNI_FORN
            // 
            this.CERT_UNI_FORN.ColumnName = "CERT_UNI_FORN";
            this.CERT_UNI_FORN.DataType = typeof(int);
            // 
            // VALIDADE_CERT_UNI_FORN
            // 
            this.VALIDADE_CERT_UNI_FORN.ColumnName = "VALIDADE_CERT_UNI_FORN";
            this.VALIDADE_CERT_UNI_FORN.DataType = typeof(System.DateTime);
            // 
            // NOTA_CERT_UNI_FORN
            // 
            this.NOTA_CERT_UNI_FORN.ColumnName = "NOTA_CERT_UNI_FORN";
            this.NOTA_CERT_UNI_FORN.DataType = typeof(double);
            // 
            // datGrupos
            // 
            this.datGrupos.DeleteCommand = this.fbCommand8;
            this.datGrupos.InsertCommand = this.fbCommand6;
            this.datGrupos.SelectCommand = this.fbCommand5;
            this.datGrupos.UpdateCommand = this.fbCommand7;
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
            this.fbCommand5.CommandText = "select * from grupos order by descricao_grupo";
            this.fbCommand5.CommandTimeout = 30;
            this.fbCommand5.Connection = this.fbConnection1;
            // 
            // fbCommand7
            // 
            this.fbCommand7.CommandTimeout = 30;
            // 
            // dsGrupos
            // 
            this.dsGrupos.DataSetName = "dsGrupos";
            this.dsGrupos.Namespace = "http://www.tempuri.org/dsGrupos.xsd";
            this.dsGrupos.Tables.AddRange(new System.Data.DataTable[] {
            this.GRUPOS});
            // 
            // GRUPOS
            // 
            this.GRUPOS.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_GRUPO,
            this.DESCRICAO_GRUPO});
            this.GRUPOS.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_GRUPO"}, true)});
            this.GRUPOS.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_GRUPO};
            this.GRUPOS.TableName = "GRUPOS";
            // 
            // COD_GRUPO
            // 
            this.COD_GRUPO.AllowDBNull = false;
            this.COD_GRUPO.ColumnName = "COD_GRUPO";
            this.COD_GRUPO.DataType = typeof(int);
            // 
            // DESCRICAO_GRUPO
            // 
            this.DESCRICAO_GRUPO.ColumnName = "DESCRICAO_GRUPO";
            this.DESCRICAO_GRUPO.MaxLength = 100;
            // 
            // datSubGrupos
            // 
            this.datSubGrupos.DeleteCommand = this.fbCommand12;
            this.datSubGrupos.InsertCommand = this.fbCommand10;
            this.datSubGrupos.SelectCommand = this.fbCommand9;
            this.datSubGrupos.UpdateCommand = this.fbCommand11;
            // 
            // fbCommand12
            // 
            this.fbCommand12.CommandTimeout = 30;
            // 
            // fbCommand10
            // 
            this.fbCommand10.CommandTimeout = 30;
            // 
            // fbCommand9
            // 
            this.fbCommand9.CommandText = "select * from sub_grupos order by descricao_sub_grupo";
            this.fbCommand9.CommandTimeout = 30;
            this.fbCommand9.Connection = this.fbConnection1;
            // 
            // fbCommand11
            // 
            this.fbCommand11.CommandTimeout = 30;
            // 
            // dsSubGrupos
            // 
            this.dsSubGrupos.DataSetName = "dsSubGrupos";
            this.dsSubGrupos.Namespace = "http://www.tempuri.org/dsSubGrupos.xsd";
            this.dsSubGrupos.Tables.AddRange(new System.Data.DataTable[] {
            this.SUB_GRUPOS});
            // 
            // SUB_GRUPOS
            // 
            this.SUB_GRUPOS.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_SUB_GRUPOS,
            this.COD_GRUPO_SUB_GRUPO,
            this.DESCRICAO_GRUPO_SUB_GRUPO,
            this.DESCRICAO_SUB_GRUPO});
            this.SUB_GRUPOS.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_SUB_GRUPOS"}, true)});
            this.SUB_GRUPOS.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_SUB_GRUPOS};
            this.SUB_GRUPOS.TableName = "SUB_GRUPOS";
            // 
            // COD_SUB_GRUPOS
            // 
            this.COD_SUB_GRUPOS.AllowDBNull = false;
            this.COD_SUB_GRUPOS.ColumnName = "COD_SUB_GRUPOS";
            this.COD_SUB_GRUPOS.DataType = typeof(int);
            // 
            // COD_GRUPO_SUB_GRUPO
            // 
            this.COD_GRUPO_SUB_GRUPO.ColumnName = "COD_GRUPO_SUB_GRUPO";
            this.COD_GRUPO_SUB_GRUPO.DataType = typeof(int);
            // 
            // DESCRICAO_GRUPO_SUB_GRUPO
            // 
            this.DESCRICAO_GRUPO_SUB_GRUPO.ColumnName = "DESCRICAO_GRUPO_SUB_GRUPO";
            this.DESCRICAO_GRUPO_SUB_GRUPO.MaxLength = 100;
            // 
            // DESCRICAO_SUB_GRUPO
            // 
            this.DESCRICAO_SUB_GRUPO.ColumnName = "DESCRICAO_SUB_GRUPO";
            this.DESCRICAO_SUB_GRUPO.MaxLength = 100;
            // 
            // datProdutos
            // 
            this.datProdutos.DeleteCommand = this.fbCommand16;
            this.datProdutos.InsertCommand = this.fbCommand14;
            this.datProdutos.SelectCommand = this.fbCommand13;
            this.datProdutos.UpdateCommand = this.fbCommand15;
            // 
            // fbCommand16
            // 
            this.fbCommand16.CommandTimeout = 30;
            // 
            // fbCommand14
            // 
            this.fbCommand14.CommandTimeout = 30;
            // 
            // fbCommand13
            // 
            this.fbCommand13.CommandText = "select * from produtos";
            this.fbCommand13.CommandTimeout = 30;
            this.fbCommand13.Connection = this.fbConnection1;
            // 
            // fbCommand15
            // 
            this.fbCommand15.CommandTimeout = 30;
            // 
            // formImprimeEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 260);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnImprimir);
            this.Name = "formImprimeEstoque";
            this.Text = "Imprimir Estoque";
            this.Load += new System.EventHandler(this.formImprimeEstoque_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsFornecedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FORNECEDORES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGrupos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRUPOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSubGrupos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SUB_GRUPOS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxFornecedores;
        private System.Windows.Forms.ComboBox cbxGrupos;
        private System.Windows.Forms.ComboBox cbxSubGrupos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnImpressaoDetalhada;
        private System.Windows.Forms.RadioButton rbtnImpressaoSimples;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dataFim;
        private System.Windows.Forms.DateTimePicker dataInicio;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datFornecedores;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Data.DataSet dsFornecedores;
        private System.Data.DataTable FORNECEDORES;
        private System.Data.DataColumn COD_FORN;
        private System.Data.DataColumn NOME_FORN;
        private System.Data.DataColumn TEL_FORN;
        private System.Data.DataColumn RAZAO_SOCIAL_FORN;
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
        private System.Data.DataColumn CONTATO_FORN;
        private System.Data.DataColumn TEL_CONTATO_FORN;
        private System.Data.DataColumn EMAIL_CONTATO_FORN;
        private System.Data.DataColumn OUTRAS_INF_FORN;
        private System.Data.DataColumn ISO_FORN;
        private System.Data.DataColumn VALIDADE_ISO_FORN;
        private System.Data.DataColumn CERT_UNI_FORN;
        private System.Data.DataColumn VALIDADE_CERT_UNI_FORN;
        private System.Data.DataColumn NOTA_CERT_UNI_FORN;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datGrupos;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand8;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand6;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand5;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand7;
        private System.Data.DataSet dsGrupos;
        private System.Data.DataTable GRUPOS;
        private System.Data.DataColumn COD_GRUPO;
        private System.Data.DataColumn DESCRICAO_GRUPO;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datSubGrupos;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand12;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand10;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand9;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand11;
        private System.Data.DataSet dsSubGrupos;
        private System.Data.DataTable SUB_GRUPOS;
        private System.Data.DataColumn COD_SUB_GRUPOS;
        private System.Data.DataColumn COD_GRUPO_SUB_GRUPO;
        private System.Data.DataColumn DESCRICAO_GRUPO_SUB_GRUPO;
        private System.Data.DataColumn DESCRICAO_SUB_GRUPO;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datProdutos;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand16;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand14;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand13;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand15;
    }
}