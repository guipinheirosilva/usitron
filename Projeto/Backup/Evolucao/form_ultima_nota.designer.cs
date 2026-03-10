namespace Evolucao
{
    partial class form_ultima_nota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_ultima_nota));
            this.datImp = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsImp = new System.Data.DataSet();
            this.ULT_IMP_NF = new System.Data.DataTable();
            this.COD_ULT_IMP_NF = new System.Data.DataColumn();
            this.NUM_ULT_NF = new System.Data.DataColumn();
            this.cbImp = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_motivo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvNd_inutilizadas = new System.Windows.Forms.DataGridView();
            this.cODNFINUTILIZADADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA_NF_INUTILIZADA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nINICIONFINUTILIZADADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nFIMNFINUTILIZADADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jUSTIFICATIVANFINUTILIZADADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsNf_inutilizadas = new System.Data.DataSet();
            this.NFS_INUTILIZADAS = new System.Data.DataTable();
            this.COD_NF_INUTILIZADA = new System.Data.DataColumn();
            this.N_INICIO_NF_INUTILIZADA = new System.Data.DataColumn();
            this.N_FIM_NF_INUTILIZADA = new System.Data.DataColumn();
            this.JUSTIFICATIVA_NF_INUTILIZADA = new System.Data.DataColumn();
            this.DATA_N_INUTILIZADA = new System.Data.DataColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.tb_fim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_inicio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.datNf_inutilizadas = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand8 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand6 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand5 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand7 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.comando_select = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand9 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand10 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand11 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand12 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand13 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand14 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand15 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand16 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.datEmpresa = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand17 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand18 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand19 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand20 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.button1 = new System.Windows.Forms.Button();
            this.dsEmpresa = new System.Data.DataSet();
            this.EMPRESA = new System.Data.DataTable();
            this.COD_EMPRESA = new System.Data.DataColumn();
            this.RAZAO_SOCIAL_EMPRESA = new System.Data.DataColumn();
            this.NOME_FANTASIA_EMPRESA = new System.Data.DataColumn();
            this.CNPJ_EMPRESA = new System.Data.DataColumn();
            this.IE_EMPRESA = new System.Data.DataColumn();
            this.IM_EMPRESA = new System.Data.DataColumn();
            this.ENDERECO_EMPRESA = new System.Data.DataColumn();
            this.N_ENDERECO_EMPRESA = new System.Data.DataColumn();
            this.COMPLEMENTO_EMPRESA = new System.Data.DataColumn();
            this.BAIRRO_EMPRESA = new System.Data.DataColumn();
            this.CIDADE_EMPRESA = new System.Data.DataColumn();
            this.ESTADO_EMPRESA = new System.Data.DataColumn();
            this.CEP_EMPRESA = new System.Data.DataColumn();
            this.TELEFONE_EMPRESA = new System.Data.DataColumn();
            this.COD_CIDADE_EMPRESA = new System.Data.DataColumn();
            this.PAIS_EMPRESA = new System.Data.DataColumn();
            this.COD_PAIS_EMPRESA = new System.Data.DataColumn();
            this.LICENCA_DLL_NFE_EMPRESA = new System.Data.DataColumn();
            this.NOME_CERTIFICADO_NFE_EMPRESA = new System.Data.DataColumn();
            this.ASSUNTO_NFE_EMAIL_EMPRESA = new System.Data.DataColumn();
            this.SMTP_NFE_EMPRESA = new System.Data.DataColumn();
            this.EMAIL_NFE_EMPRESA = new System.Data.DataColumn();
            this.SENHA_EMAIL_NFE_EMPRESA = new System.Data.DataColumn();
            this.LOGOTIPO_EMPRESA = new System.Data.DataColumn();
            this.PROXY_EMPRESA = new System.Data.DataColumn();
            this.USUARIO_PROXY_EMPRESA = new System.Data.DataColumn();
            this.SENHA_PROXY_EMPRESA = new System.Data.DataColumn();
            this.NOME_CONTATO_EMAIL_NFE = new System.Data.DataColumn();
            this.ICMS_EMPRESA = new System.Data.DataColumn();
            this.REDUCAO_EMPRESA = new System.Data.DataColumn();
            this.ICMS_ST_EMPRESA = new System.Data.DataColumn();
            this.IVA_EMPRESA = new System.Data.DataColumn();
            this.IPI_EMPRESA = new System.Data.DataColumn();
            this.PIS_EMPRESA = new System.Data.DataColumn();
            this.COFINS_EMPRESA = new System.Data.DataColumn();
            this.ORIGEM_EMPRESA = new System.Data.DataColumn();
            this.MOD_BC_EMPRESA = new System.Data.DataColumn();
            this.ISS_EMPRESA = new System.Data.DataColumn();
            this.CST_EMPRESA = new System.Data.DataColumn();
            this.CRT_EMPRESA = new System.Data.DataColumn();
            this.ALIQUOTA_CREDITO_EMPRESA = new System.Data.DataColumn();
            this.MOD_BC_ST_EMPRESA = new System.Data.DataColumn();
            this.REDUCAO_ST_EMPRESA = new System.Data.DataColumn();
            this.IPI_TRIB_EMPRESA = new System.Data.DataColumn();
            this.IPI_N_TRIB_EMPRESA = new System.Data.DataColumn();
            this.CST_IPI_TRIB_EMPRESA = new System.Data.DataColumn();
            this.CST_IPI_N_TRIB_EMPRESA = new System.Data.DataColumn();
            this.TIPO_PIS_EMPRESA = new System.Data.DataColumn();
            this.CST_PIS_EMPRESA = new System.Data.DataColumn();
            this.TIPO_COFINS_EMPRESA = new System.Data.DataColumn();
            this.CST_COFINS_EMPRESA = new System.Data.DataColumn();
            this.TIPO_SERVICO_EMPRESA = new System.Data.DataColumn();
            this.BC_COM_IPI_EMPRESA = new System.Data.DataColumn();
            this.CNAE_EMPRESA = new System.Data.DataColumn();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.cbEmpresa = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            ((System.ComponentModel.ISupportInitialize)(this.dsImp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ULT_IMP_NF)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNd_inutilizadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNf_inutilizadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NFS_INUTILIZADAS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EMPRESA)).BeginInit();
            this.SuspendLayout();
            // 
            // datImp
            // 
            this.datImp.DeleteCommand = this.fbCommand4;
            this.datImp.InsertCommand = this.fbCommand2;
            this.datImp.SelectCommand = this.fbCommand1;
            this.datImp.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * from ult_imp_nf";
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
            // dsImp
            // 
            this.dsImp.DataSetName = "dsImp";
            this.dsImp.Namespace = "http://www.tempuri.org/dsImp.xsd";
            this.dsImp.Tables.AddRange(new System.Data.DataTable[] {
            this.ULT_IMP_NF});
            // 
            // ULT_IMP_NF
            // 
            this.ULT_IMP_NF.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_ULT_IMP_NF,
            this.NUM_ULT_NF});
            this.ULT_IMP_NF.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_ULT_IMP_NF"}, true)});
            this.ULT_IMP_NF.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_ULT_IMP_NF};
            this.ULT_IMP_NF.TableName = "ULT_IMP_NF";
            // 
            // COD_ULT_IMP_NF
            // 
            this.COD_ULT_IMP_NF.AllowDBNull = false;
            this.COD_ULT_IMP_NF.ColumnName = "COD_ULT_IMP_NF";
            this.COD_ULT_IMP_NF.DataType = typeof(int);
            // 
            // NUM_ULT_NF
            // 
            this.NUM_ULT_NF.ColumnName = "NUM_ULT_NF";
            this.NUM_ULT_NF.DataType = typeof(int);
            // 
            // cbImp
            // 
            this.cbImp.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbImp.DataAdapter = this.datImp;
            this.cbImp.QuotePrefix = "\"";
            this.cbImp.QuoteSuffix = "\"";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_motivo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dgvNd_inutilizadas);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.tb_fim);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tb_inicio);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 207);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Inutilizar Numeração de NFe";
            // 
            // tb_motivo
            // 
            this.tb_motivo.Location = new System.Drawing.Point(51, 48);
            this.tb_motivo.Name = "tb_motivo";
            this.tb_motivo.Size = new System.Drawing.Size(104, 20);
            this.tb_motivo.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Motivo";
            // 
            // dgvNd_inutilizadas
            // 
            this.dgvNd_inutilizadas.AllowUserToAddRows = false;
            this.dgvNd_inutilizadas.AllowUserToDeleteRows = false;
            this.dgvNd_inutilizadas.AutoGenerateColumns = false;
            this.dgvNd_inutilizadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNd_inutilizadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODNFINUTILIZADADataGridViewTextBoxColumn,
            this.DATA_NF_INUTILIZADA,
            this.nINICIONFINUTILIZADADataGridViewTextBoxColumn,
            this.nFIMNFINUTILIZADADataGridViewTextBoxColumn,
            this.jUSTIFICATIVANFINUTILIZADADataGridViewTextBoxColumn});
            this.dgvNd_inutilizadas.DataMember = "NFS_INUTILIZADAS";
            this.dgvNd_inutilizadas.DataSource = this.dsNf_inutilizadas;
            this.dgvNd_inutilizadas.Location = new System.Drawing.Point(5, 74);
            this.dgvNd_inutilizadas.Name = "dgvNd_inutilizadas";
            this.dgvNd_inutilizadas.ReadOnly = true;
            this.dgvNd_inutilizadas.Size = new System.Drawing.Size(249, 122);
            this.dgvNd_inutilizadas.TabIndex = 8;
            // 
            // cODNFINUTILIZADADataGridViewTextBoxColumn
            // 
            this.cODNFINUTILIZADADataGridViewTextBoxColumn.DataPropertyName = "COD_NF_INUTILIZADA";
            this.cODNFINUTILIZADADataGridViewTextBoxColumn.HeaderText = "COD_NF_INUTILIZADA";
            this.cODNFINUTILIZADADataGridViewTextBoxColumn.Name = "cODNFINUTILIZADADataGridViewTextBoxColumn";
            this.cODNFINUTILIZADADataGridViewTextBoxColumn.ReadOnly = true;
            this.cODNFINUTILIZADADataGridViewTextBoxColumn.Visible = false;
            // 
            // DATA_NF_INUTILIZADA
            // 
            this.DATA_NF_INUTILIZADA.DataPropertyName = "DATA_NF_INUTILIZADA";
            this.DATA_NF_INUTILIZADA.HeaderText = "Data";
            this.DATA_NF_INUTILIZADA.Name = "DATA_NF_INUTILIZADA";
            this.DATA_NF_INUTILIZADA.ReadOnly = true;
            this.DATA_NF_INUTILIZADA.Width = 50;
            // 
            // nINICIONFINUTILIZADADataGridViewTextBoxColumn
            // 
            this.nINICIONFINUTILIZADADataGridViewTextBoxColumn.DataPropertyName = "N_INICIO_NF_INUTILIZADA";
            this.nINICIONFINUTILIZADADataGridViewTextBoxColumn.HeaderText = "Ini";
            this.nINICIONFINUTILIZADADataGridViewTextBoxColumn.Name = "nINICIONFINUTILIZADADataGridViewTextBoxColumn";
            this.nINICIONFINUTILIZADADataGridViewTextBoxColumn.ReadOnly = true;
            this.nINICIONFINUTILIZADADataGridViewTextBoxColumn.Width = 25;
            // 
            // nFIMNFINUTILIZADADataGridViewTextBoxColumn
            // 
            this.nFIMNFINUTILIZADADataGridViewTextBoxColumn.DataPropertyName = "N_FIM_NF_INUTILIZADA";
            this.nFIMNFINUTILIZADADataGridViewTextBoxColumn.HeaderText = "Fim";
            this.nFIMNFINUTILIZADADataGridViewTextBoxColumn.Name = "nFIMNFINUTILIZADADataGridViewTextBoxColumn";
            this.nFIMNFINUTILIZADADataGridViewTextBoxColumn.ReadOnly = true;
            this.nFIMNFINUTILIZADADataGridViewTextBoxColumn.Width = 25;
            // 
            // jUSTIFICATIVANFINUTILIZADADataGridViewTextBoxColumn
            // 
            this.jUSTIFICATIVANFINUTILIZADADataGridViewTextBoxColumn.DataPropertyName = "JUSTIFICATIVA_NF_INUTILIZADA";
            this.jUSTIFICATIVANFINUTILIZADADataGridViewTextBoxColumn.HeaderText = "Justificativa";
            this.jUSTIFICATIVANFINUTILIZADADataGridViewTextBoxColumn.Name = "jUSTIFICATIVANFINUTILIZADADataGridViewTextBoxColumn";
            this.jUSTIFICATIVANFINUTILIZADADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dsNf_inutilizadas
            // 
            this.dsNf_inutilizadas.DataSetName = "dsNf_inutlizadas";
            this.dsNf_inutilizadas.Namespace = "http://www.tempuri.org/dsNf_inutlizadas.xsd";
            this.dsNf_inutilizadas.Tables.AddRange(new System.Data.DataTable[] {
            this.NFS_INUTILIZADAS});
            // 
            // NFS_INUTILIZADAS
            // 
            this.NFS_INUTILIZADAS.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_NF_INUTILIZADA,
            this.N_INICIO_NF_INUTILIZADA,
            this.N_FIM_NF_INUTILIZADA,
            this.JUSTIFICATIVA_NF_INUTILIZADA,
            this.DATA_N_INUTILIZADA});
            this.NFS_INUTILIZADAS.TableName = "NFS_INUTILIZADAS";
            // 
            // COD_NF_INUTILIZADA
            // 
            this.COD_NF_INUTILIZADA.AllowDBNull = false;
            this.COD_NF_INUTILIZADA.ColumnName = "COD_NF_INUTILIZADA";
            this.COD_NF_INUTILIZADA.DataType = typeof(int);
            // 
            // N_INICIO_NF_INUTILIZADA
            // 
            this.N_INICIO_NF_INUTILIZADA.ColumnName = "N_INICIO_NF_INUTILIZADA";
            this.N_INICIO_NF_INUTILIZADA.DataType = typeof(int);
            // 
            // N_FIM_NF_INUTILIZADA
            // 
            this.N_FIM_NF_INUTILIZADA.ColumnName = "N_FIM_NF_INUTILIZADA";
            this.N_FIM_NF_INUTILIZADA.DataType = typeof(int);
            // 
            // JUSTIFICATIVA_NF_INUTILIZADA
            // 
            this.JUSTIFICATIVA_NF_INUTILIZADA.ColumnName = "JUSTIFICATIVA_NF_INUTILIZADA";
            this.JUSTIFICATIVA_NF_INUTILIZADA.MaxLength = 100;
            // 
            // DATA_N_INUTILIZADA
            // 
            this.DATA_N_INUTILIZADA.ColumnName = "DATA_NF_INUTILIZADA";
            this.DATA_N_INUTILIZADA.DataType = typeof(System.DateTime);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(159, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Inutilizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tb_fim
            // 
            this.tb_fim.Location = new System.Drawing.Point(170, 19);
            this.tb_fim.Name = "tb_fim";
            this.tb_fim.Size = new System.Drawing.Size(64, 20);
            this.tb_fim.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fim";
            // 
            // tb_inicio
            // 
            this.tb_inicio.Location = new System.Drawing.Point(51, 19);
            this.tb_inicio.Name = "tb_inicio";
            this.tb_inicio.Size = new System.Drawing.Size(64, 20);
            this.tb_inicio.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Inicio";
            // 
            // datNf_inutilizadas
            // 
            this.datNf_inutilizadas.DeleteCommand = this.fbCommand8;
            this.datNf_inutilizadas.InsertCommand = this.fbCommand6;
            this.datNf_inutilizadas.SelectCommand = this.fbCommand5;
            this.datNf_inutilizadas.UpdateCommand = this.fbCommand7;
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
            this.fbCommand5.CommandText = "SELECT * FROM NFS_INUTILIZADAS";
            this.fbCommand5.CommandTimeout = 30;
            this.fbCommand5.Connection = this.fbConnection1;
            // 
            // fbCommand7
            // 
            this.fbCommand7.CommandTimeout = 30;
            // 
            // comando_select
            // 
            this.comando_select.CommandTimeout = 30;
            this.comando_select.Connection = this.fbConnection1;
            // 
            // fbCommand9
            // 
            this.fbCommand9.CommandText = "select * from empresa";
            this.fbCommand9.CommandTimeout = 30;
            this.fbCommand9.Connection = this.fbConnection1;
            // 
            // fbCommand10
            // 
            this.fbCommand10.CommandTimeout = 30;
            // 
            // fbCommand11
            // 
            this.fbCommand11.CommandTimeout = 30;
            // 
            // fbCommand12
            // 
            this.fbCommand12.CommandTimeout = 30;
            // 
            // fbCommand13
            // 
            this.fbCommand13.CommandText = "select * from empresa";
            this.fbCommand13.CommandTimeout = 30;
            this.fbCommand13.Connection = this.fbConnection1;
            // 
            // fbCommand14
            // 
            this.fbCommand14.CommandTimeout = 30;
            // 
            // fbCommand15
            // 
            this.fbCommand15.CommandTimeout = 30;
            // 
            // fbCommand16
            // 
            this.fbCommand16.CommandTimeout = 30;
            // 
            // datEmpresa
            // 
            this.datEmpresa.DeleteCommand = this.fbCommand20;
            this.datEmpresa.InsertCommand = this.fbCommand18;
            this.datEmpresa.SelectCommand = this.fbCommand17;
            this.datEmpresa.UpdateCommand = this.fbCommand19;
            // 
            // fbCommand17
            // 
            this.fbCommand17.CommandText = "select * from empresa";
            this.fbCommand17.CommandTimeout = 30;
            this.fbCommand17.Connection = this.fbConnection1;
            // 
            // fbCommand18
            // 
            this.fbCommand18.CommandTimeout = 30;
            // 
            // fbCommand19
            // 
            this.fbCommand19.CommandTimeout = 30;
            // 
            // fbCommand20
            // 
            this.fbCommand20.CommandTimeout = 30;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(187, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 113;
            this.button1.Text = "Salvar Aliquota";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dsEmpresa
            // 
            this.dsEmpresa.DataSetName = "dsEmpresa";
            this.dsEmpresa.Namespace = "http://www.tempuri.org/dsEmpresa.xsd";
            this.dsEmpresa.Tables.AddRange(new System.Data.DataTable[] {
            this.EMPRESA});
            // 
            // EMPRESA
            // 
            this.EMPRESA.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_EMPRESA,
            this.RAZAO_SOCIAL_EMPRESA,
            this.NOME_FANTASIA_EMPRESA,
            this.CNPJ_EMPRESA,
            this.IE_EMPRESA,
            this.IM_EMPRESA,
            this.ENDERECO_EMPRESA,
            this.N_ENDERECO_EMPRESA,
            this.COMPLEMENTO_EMPRESA,
            this.BAIRRO_EMPRESA,
            this.CIDADE_EMPRESA,
            this.ESTADO_EMPRESA,
            this.CEP_EMPRESA,
            this.TELEFONE_EMPRESA,
            this.COD_CIDADE_EMPRESA,
            this.PAIS_EMPRESA,
            this.COD_PAIS_EMPRESA,
            this.LICENCA_DLL_NFE_EMPRESA,
            this.NOME_CERTIFICADO_NFE_EMPRESA,
            this.ASSUNTO_NFE_EMAIL_EMPRESA,
            this.SMTP_NFE_EMPRESA,
            this.EMAIL_NFE_EMPRESA,
            this.SENHA_EMAIL_NFE_EMPRESA,
            this.LOGOTIPO_EMPRESA,
            this.PROXY_EMPRESA,
            this.USUARIO_PROXY_EMPRESA,
            this.SENHA_PROXY_EMPRESA,
            this.NOME_CONTATO_EMAIL_NFE,
            this.ICMS_EMPRESA,
            this.REDUCAO_EMPRESA,
            this.ICMS_ST_EMPRESA,
            this.IVA_EMPRESA,
            this.IPI_EMPRESA,
            this.PIS_EMPRESA,
            this.COFINS_EMPRESA,
            this.ORIGEM_EMPRESA,
            this.MOD_BC_EMPRESA,
            this.ISS_EMPRESA,
            this.CST_EMPRESA,
            this.CRT_EMPRESA,
            this.ALIQUOTA_CREDITO_EMPRESA,
            this.MOD_BC_ST_EMPRESA,
            this.REDUCAO_ST_EMPRESA,
            this.IPI_TRIB_EMPRESA,
            this.IPI_N_TRIB_EMPRESA,
            this.CST_IPI_TRIB_EMPRESA,
            this.CST_IPI_N_TRIB_EMPRESA,
            this.TIPO_PIS_EMPRESA,
            this.CST_PIS_EMPRESA,
            this.TIPO_COFINS_EMPRESA,
            this.CST_COFINS_EMPRESA,
            this.TIPO_SERVICO_EMPRESA,
            this.BC_COM_IPI_EMPRESA,
            this.CNAE_EMPRESA});
            this.EMPRESA.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_EMPRESA"}, true)});
            this.EMPRESA.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_EMPRESA};
            this.EMPRESA.TableName = "EMPRESA";
            // 
            // COD_EMPRESA
            // 
            this.COD_EMPRESA.AllowDBNull = false;
            this.COD_EMPRESA.ColumnName = "COD_EMPRESA";
            this.COD_EMPRESA.DataType = typeof(int);
            // 
            // RAZAO_SOCIAL_EMPRESA
            // 
            this.RAZAO_SOCIAL_EMPRESA.ColumnName = "RAZAO_SOCIAL_EMPRESA";
            this.RAZAO_SOCIAL_EMPRESA.MaxLength = 200;
            // 
            // NOME_FANTASIA_EMPRESA
            // 
            this.NOME_FANTASIA_EMPRESA.ColumnName = "NOME_FANTASIA_EMPRESA";
            this.NOME_FANTASIA_EMPRESA.MaxLength = 200;
            // 
            // CNPJ_EMPRESA
            // 
            this.CNPJ_EMPRESA.ColumnName = "CNPJ_EMPRESA";
            this.CNPJ_EMPRESA.MaxLength = 30;
            // 
            // IE_EMPRESA
            // 
            this.IE_EMPRESA.ColumnName = "IE_EMPRESA";
            this.IE_EMPRESA.MaxLength = 30;
            // 
            // IM_EMPRESA
            // 
            this.IM_EMPRESA.ColumnName = "IM_EMPRESA";
            this.IM_EMPRESA.MaxLength = 30;
            // 
            // ENDERECO_EMPRESA
            // 
            this.ENDERECO_EMPRESA.ColumnName = "ENDERECO_EMPRESA";
            this.ENDERECO_EMPRESA.MaxLength = 200;
            // 
            // N_ENDERECO_EMPRESA
            // 
            this.N_ENDERECO_EMPRESA.ColumnName = "N_ENDERECO_EMPRESA";
            this.N_ENDERECO_EMPRESA.MaxLength = 20;
            // 
            // COMPLEMENTO_EMPRESA
            // 
            this.COMPLEMENTO_EMPRESA.ColumnName = "COMPLEMENTO_EMPRESA";
            this.COMPLEMENTO_EMPRESA.MaxLength = 50;
            // 
            // BAIRRO_EMPRESA
            // 
            this.BAIRRO_EMPRESA.ColumnName = "BAIRRO_EMPRESA";
            this.BAIRRO_EMPRESA.MaxLength = 50;
            // 
            // CIDADE_EMPRESA
            // 
            this.CIDADE_EMPRESA.ColumnName = "CIDADE_EMPRESA";
            this.CIDADE_EMPRESA.MaxLength = 50;
            // 
            // ESTADO_EMPRESA
            // 
            this.ESTADO_EMPRESA.ColumnName = "ESTADO_EMPRESA";
            this.ESTADO_EMPRESA.MaxLength = 2;
            // 
            // CEP_EMPRESA
            // 
            this.CEP_EMPRESA.ColumnName = "CEP_EMPRESA";
            this.CEP_EMPRESA.MaxLength = 10;
            // 
            // TELEFONE_EMPRESA
            // 
            this.TELEFONE_EMPRESA.ColumnName = "TELEFONE_EMPRESA";
            this.TELEFONE_EMPRESA.MaxLength = 50;
            // 
            // COD_CIDADE_EMPRESA
            // 
            this.COD_CIDADE_EMPRESA.ColumnName = "COD_CIDADE_EMPRESA";
            this.COD_CIDADE_EMPRESA.MaxLength = 7;
            // 
            // PAIS_EMPRESA
            // 
            this.PAIS_EMPRESA.ColumnName = "PAIS_EMPRESA";
            this.PAIS_EMPRESA.MaxLength = 50;
            // 
            // COD_PAIS_EMPRESA
            // 
            this.COD_PAIS_EMPRESA.ColumnName = "COD_PAIS_EMPRESA";
            this.COD_PAIS_EMPRESA.MaxLength = 20;
            // 
            // LICENCA_DLL_NFE_EMPRESA
            // 
            this.LICENCA_DLL_NFE_EMPRESA.ColumnName = "LICENCA_DLL_NFE_EMPRESA";
            this.LICENCA_DLL_NFE_EMPRESA.MaxLength = 200;
            // 
            // NOME_CERTIFICADO_NFE_EMPRESA
            // 
            this.NOME_CERTIFICADO_NFE_EMPRESA.ColumnName = "NOME_CERTIFICADO_NFE_EMPRESA";
            this.NOME_CERTIFICADO_NFE_EMPRESA.MaxLength = 400;
            // 
            // ASSUNTO_NFE_EMAIL_EMPRESA
            // 
            this.ASSUNTO_NFE_EMAIL_EMPRESA.ColumnName = "ASSUNTO_NFE_EMAIL_EMPRESA";
            this.ASSUNTO_NFE_EMAIL_EMPRESA.MaxLength = 200;
            // 
            // SMTP_NFE_EMPRESA
            // 
            this.SMTP_NFE_EMPRESA.ColumnName = "SMTP_NFE_EMPRESA";
            this.SMTP_NFE_EMPRESA.MaxLength = 50;
            // 
            // EMAIL_NFE_EMPRESA
            // 
            this.EMAIL_NFE_EMPRESA.ColumnName = "EMAIL_NFE_EMPRESA";
            this.EMAIL_NFE_EMPRESA.MaxLength = 50;
            // 
            // SENHA_EMAIL_NFE_EMPRESA
            // 
            this.SENHA_EMAIL_NFE_EMPRESA.ColumnName = "SENHA_EMAIL_NFE_EMPRESA";
            this.SENHA_EMAIL_NFE_EMPRESA.MaxLength = 50;
            // 
            // LOGOTIPO_EMPRESA
            // 
            this.LOGOTIPO_EMPRESA.ColumnName = "LOGOTIPO_EMPRESA";
            this.LOGOTIPO_EMPRESA.DataType = typeof(byte[]);
            // 
            // PROXY_EMPRESA
            // 
            this.PROXY_EMPRESA.ColumnName = "PROXY_EMPRESA";
            this.PROXY_EMPRESA.MaxLength = 20;
            // 
            // USUARIO_PROXY_EMPRESA
            // 
            this.USUARIO_PROXY_EMPRESA.ColumnName = "USUARIO_PROXY_EMPRESA";
            this.USUARIO_PROXY_EMPRESA.MaxLength = 50;
            // 
            // SENHA_PROXY_EMPRESA
            // 
            this.SENHA_PROXY_EMPRESA.ColumnName = "SENHA_PROXY_EMPRESA";
            this.SENHA_PROXY_EMPRESA.MaxLength = 50;
            // 
            // NOME_CONTATO_EMAIL_NFE
            // 
            this.NOME_CONTATO_EMAIL_NFE.ColumnName = "NOME_CONTATO_EMAIL_NFE";
            this.NOME_CONTATO_EMAIL_NFE.MaxLength = 200;
            // 
            // ICMS_EMPRESA
            // 
            this.ICMS_EMPRESA.ColumnName = "ICMS_EMPRESA";
            this.ICMS_EMPRESA.DataType = typeof(double);
            // 
            // REDUCAO_EMPRESA
            // 
            this.REDUCAO_EMPRESA.ColumnName = "REDUCAO_EMPRESA";
            this.REDUCAO_EMPRESA.DataType = typeof(double);
            // 
            // ICMS_ST_EMPRESA
            // 
            this.ICMS_ST_EMPRESA.ColumnName = "ICMS_ST_EMPRESA";
            this.ICMS_ST_EMPRESA.DataType = typeof(double);
            // 
            // IVA_EMPRESA
            // 
            this.IVA_EMPRESA.ColumnName = "IVA_EMPRESA";
            this.IVA_EMPRESA.DataType = typeof(double);
            // 
            // IPI_EMPRESA
            // 
            this.IPI_EMPRESA.ColumnName = "IPI_EMPRESA";
            this.IPI_EMPRESA.DataType = typeof(double);
            // 
            // PIS_EMPRESA
            // 
            this.PIS_EMPRESA.ColumnName = "PIS_EMPRESA";
            this.PIS_EMPRESA.DataType = typeof(double);
            // 
            // COFINS_EMPRESA
            // 
            this.COFINS_EMPRESA.ColumnName = "COFINS_EMPRESA";
            this.COFINS_EMPRESA.DataType = typeof(double);
            // 
            // ORIGEM_EMPRESA
            // 
            this.ORIGEM_EMPRESA.ColumnName = "ORIGEM_EMPRESA";
            this.ORIGEM_EMPRESA.MaxLength = 100;
            // 
            // MOD_BC_EMPRESA
            // 
            this.MOD_BC_EMPRESA.ColumnName = "MOD_BC_EMPRESA";
            this.MOD_BC_EMPRESA.MaxLength = 100;
            // 
            // ISS_EMPRESA
            // 
            this.ISS_EMPRESA.ColumnName = "ISS_EMPRESA";
            this.ISS_EMPRESA.DataType = typeof(double);
            // 
            // CST_EMPRESA
            // 
            this.CST_EMPRESA.ColumnName = "CST_EMPRESA";
            this.CST_EMPRESA.MaxLength = 3;
            // 
            // CRT_EMPRESA
            // 
            this.CRT_EMPRESA.ColumnName = "CRT_EMPRESA";
            this.CRT_EMPRESA.MaxLength = 1;
            // 
            // ALIQUOTA_CREDITO_EMPRESA
            // 
            this.ALIQUOTA_CREDITO_EMPRESA.ColumnName = "ALIQUOTA_CREDITO_EMPRESA";
            this.ALIQUOTA_CREDITO_EMPRESA.DataType = typeof(double);
            // 
            // MOD_BC_ST_EMPRESA
            // 
            this.MOD_BC_ST_EMPRESA.ColumnName = "MOD_BC_ST_EMPRESA";
            this.MOD_BC_ST_EMPRESA.MaxLength = 100;
            // 
            // REDUCAO_ST_EMPRESA
            // 
            this.REDUCAO_ST_EMPRESA.ColumnName = "REDUCAO_ST_EMPRESA";
            this.REDUCAO_ST_EMPRESA.DataType = typeof(double);
            // 
            // IPI_TRIB_EMPRESA
            // 
            this.IPI_TRIB_EMPRESA.ColumnName = "IPI_TRIB_EMPRESA";
            this.IPI_TRIB_EMPRESA.DataType = typeof(int);
            // 
            // IPI_N_TRIB_EMPRESA
            // 
            this.IPI_N_TRIB_EMPRESA.ColumnName = "IPI_N_TRIB_EMPRESA";
            this.IPI_N_TRIB_EMPRESA.DataType = typeof(int);
            // 
            // CST_IPI_TRIB_EMPRESA
            // 
            this.CST_IPI_TRIB_EMPRESA.ColumnName = "CST_IPI_TRIB_EMPRESA";
            this.CST_IPI_TRIB_EMPRESA.MaxLength = 100;
            // 
            // CST_IPI_N_TRIB_EMPRESA
            // 
            this.CST_IPI_N_TRIB_EMPRESA.ColumnName = "CST_IPI_N_TRIB_EMPRESA";
            this.CST_IPI_N_TRIB_EMPRESA.MaxLength = 100;
            // 
            // TIPO_PIS_EMPRESA
            // 
            this.TIPO_PIS_EMPRESA.ColumnName = "TIPO_PIS_EMPRESA";
            this.TIPO_PIS_EMPRESA.MaxLength = 100;
            // 
            // CST_PIS_EMPRESA
            // 
            this.CST_PIS_EMPRESA.ColumnName = "CST_PIS_EMPRESA";
            this.CST_PIS_EMPRESA.MaxLength = 200;
            // 
            // TIPO_COFINS_EMPRESA
            // 
            this.TIPO_COFINS_EMPRESA.ColumnName = "TIPO_COFINS_EMPRESA";
            this.TIPO_COFINS_EMPRESA.MaxLength = 100;
            // 
            // CST_COFINS_EMPRESA
            // 
            this.CST_COFINS_EMPRESA.ColumnName = "CST_COFINS_EMPRESA";
            this.CST_COFINS_EMPRESA.MaxLength = 200;
            // 
            // TIPO_SERVICO_EMPRESA
            // 
            this.TIPO_SERVICO_EMPRESA.ColumnName = "TIPO_SERVICO_EMPRESA";
            this.TIPO_SERVICO_EMPRESA.MaxLength = 100;
            // 
            // BC_COM_IPI_EMPRESA
            // 
            this.BC_COM_IPI_EMPRESA.ColumnName = "BC_COM_IPI_EMPRESA";
            this.BC_COM_IPI_EMPRESA.DataType = typeof(int);
            // 
            // CNAE_EMPRESA
            // 
            this.CNAE_EMPRESA.ColumnName = "CNAE_EMPRESA";
            this.CNAE_EMPRESA.MaxLength = 20;
            // 
            // textBox16
            // 
            this.textBox16.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsEmpresa, "EMPRESA.ALIQUOTA_CREDITO_EMPRESA", true));
            this.textBox16.Location = new System.Drawing.Point(130, 18);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(51, 20);
            this.textBox16.TabIndex = 115;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(9, 21);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(115, 13);
            this.label35.TabIndex = 114;
            this.label35.Text = "Alíquota Crédito ICMS:";
            // 
            // cbEmpresa
            // 
            this.cbEmpresa.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbEmpresa.DataAdapter = this.datEmpresa;
            this.cbEmpresa.QuotePrefix = "\"";
            this.cbEmpresa.QuoteSuffix = "\"";
            // 
            // form_ultima_nota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 277);
            this.Controls.Add(this.textBox16);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Name = "form_ultima_nota";
            this.Text = "Operações com NF";
            this.Load += new System.EventHandler(this.form_ultima_nota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsImp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ULT_IMP_NF)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNd_inutilizadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNf_inutilizadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NFS_INUTILIZADAS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EMPRESA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datImp;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Data.DataSet dsImp;
        private System.Data.DataTable ULT_IMP_NF;
        private System.Data.DataColumn COD_ULT_IMP_NF;
        private System.Data.DataColumn NUM_ULT_NF;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbImp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tb_fim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_inicio;
        private System.Windows.Forms.Label label2;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datNf_inutilizadas;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand8;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand6;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand5;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand7;
        private System.Windows.Forms.TextBox tb_motivo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvNd_inutilizadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODNFINUTILIZADADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA_NF_INUTILIZADA;
        private System.Windows.Forms.DataGridViewTextBoxColumn nINICIONFINUTILIZADADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nFIMNFINUTILIZADADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jUSTIFICATIVANFINUTILIZADADataGridViewTextBoxColumn;
        private System.Data.DataColumn DATA_N_INUTILIZADA;
        private System.Data.DataColumn JUSTIFICATIVA_NF_INUTILIZADA;
        private System.Data.DataColumn N_FIM_NF_INUTILIZADA;
        private System.Data.DataColumn N_INICIO_NF_INUTILIZADA;
        private System.Data.DataColumn COD_NF_INUTILIZADA;
        private System.Data.DataTable NFS_INUTILIZADAS;
        private System.Data.DataSet dsNf_inutilizadas;
        private FirebirdSql.Data.FirebirdClient.FbCommand comando_select;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand12;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand10;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand9;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand11;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand13;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand14;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand15;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand16;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datEmpresa;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand20;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand18;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand17;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand19;
        private System.Windows.Forms.Button button1;
        private System.Data.DataSet dsEmpresa;
        private System.Data.DataTable EMPRESA;
        private System.Data.DataColumn COD_EMPRESA;
        private System.Data.DataColumn RAZAO_SOCIAL_EMPRESA;
        private System.Data.DataColumn NOME_FANTASIA_EMPRESA;
        private System.Data.DataColumn CNPJ_EMPRESA;
        private System.Data.DataColumn IE_EMPRESA;
        private System.Data.DataColumn IM_EMPRESA;
        private System.Data.DataColumn ENDERECO_EMPRESA;
        private System.Data.DataColumn N_ENDERECO_EMPRESA;
        private System.Data.DataColumn COMPLEMENTO_EMPRESA;
        private System.Data.DataColumn BAIRRO_EMPRESA;
        private System.Data.DataColumn CIDADE_EMPRESA;
        private System.Data.DataColumn ESTADO_EMPRESA;
        private System.Data.DataColumn CEP_EMPRESA;
        private System.Data.DataColumn TELEFONE_EMPRESA;
        private System.Data.DataColumn COD_CIDADE_EMPRESA;
        private System.Data.DataColumn PAIS_EMPRESA;
        private System.Data.DataColumn COD_PAIS_EMPRESA;
        private System.Data.DataColumn LICENCA_DLL_NFE_EMPRESA;
        private System.Data.DataColumn NOME_CERTIFICADO_NFE_EMPRESA;
        private System.Data.DataColumn ASSUNTO_NFE_EMAIL_EMPRESA;
        private System.Data.DataColumn SMTP_NFE_EMPRESA;
        private System.Data.DataColumn EMAIL_NFE_EMPRESA;
        private System.Data.DataColumn SENHA_EMAIL_NFE_EMPRESA;
        private System.Data.DataColumn LOGOTIPO_EMPRESA;
        private System.Data.DataColumn PROXY_EMPRESA;
        private System.Data.DataColumn USUARIO_PROXY_EMPRESA;
        private System.Data.DataColumn SENHA_PROXY_EMPRESA;
        private System.Data.DataColumn NOME_CONTATO_EMAIL_NFE;
        private System.Data.DataColumn ICMS_EMPRESA;
        private System.Data.DataColumn REDUCAO_EMPRESA;
        private System.Data.DataColumn ICMS_ST_EMPRESA;
        private System.Data.DataColumn IVA_EMPRESA;
        private System.Data.DataColumn IPI_EMPRESA;
        private System.Data.DataColumn PIS_EMPRESA;
        private System.Data.DataColumn COFINS_EMPRESA;
        private System.Data.DataColumn ORIGEM_EMPRESA;
        private System.Data.DataColumn MOD_BC_EMPRESA;
        private System.Data.DataColumn ISS_EMPRESA;
        private System.Data.DataColumn CST_EMPRESA;
        private System.Data.DataColumn CRT_EMPRESA;
        private System.Data.DataColumn ALIQUOTA_CREDITO_EMPRESA;
        private System.Data.DataColumn MOD_BC_ST_EMPRESA;
        private System.Data.DataColumn REDUCAO_ST_EMPRESA;
        private System.Data.DataColumn IPI_TRIB_EMPRESA;
        private System.Data.DataColumn IPI_N_TRIB_EMPRESA;
        private System.Data.DataColumn CST_IPI_TRIB_EMPRESA;
        private System.Data.DataColumn CST_IPI_N_TRIB_EMPRESA;
        private System.Data.DataColumn TIPO_PIS_EMPRESA;
        private System.Data.DataColumn CST_PIS_EMPRESA;
        private System.Data.DataColumn TIPO_COFINS_EMPRESA;
        private System.Data.DataColumn CST_COFINS_EMPRESA;
        private System.Data.DataColumn TIPO_SERVICO_EMPRESA;
        private System.Data.DataColumn BC_COM_IPI_EMPRESA;
        private System.Data.DataColumn CNAE_EMPRESA;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.Label label35;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbEmpresa;
    }
}