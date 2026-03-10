namespace Evolucao
{
    partial class form_requisicao
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_requisicao));
            this.label20 = new System.Windows.Forms.Label();
            this.tb_setor = new System.Windows.Forms.TextBox();
            this.dsRequisicoes = new System.Data.DataSet();
            this.REQUISICOES = new System.Data.DataTable();
            this.COD_REQUISICAO = new System.Data.DataColumn();
            this.REQUISITANTE_REQUISICAO = new System.Data.DataColumn();
            this.SETOR_REQUISICAO = new System.Data.DataColumn();
            this.OBS_REQUISICAO = new System.Data.DataColumn();
            this.DATA_REQUISICAO = new System.Data.DataColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_requisitante = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_cod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_excluir = new System.Windows.Forms.Button();
            this.tb_salvar = new System.Windows.Forms.Button();
            this.bt_localizar = new System.Windows.Forms.Button();
            this.tb_novo = new System.Windows.Forms.Button();
            this.dgvItens_requisicao = new System.Windows.Forms.DataGridView();
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
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.tb_obs = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_inserir = new System.Windows.Forms.Button();
            this.tb_op = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_data_req = new System.Windows.Forms.TextBox();
            this.tb_descricao_item = new System.Windows.Forms.TextBox();
            this.tb_qtde = new System.Windows.Forms.TextBox();
            this.tb_data_limite = new System.Windows.Forms.TextBox();
            this.cbUrgente = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_cod_item = new System.Windows.Forms.TextBox();
            this.datRequisicoes = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.cbRequisicoes = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.datItens_req = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand8 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand6 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand5 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand7 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.cbItens_req = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_unidade = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tb_email_3 = new System.Windows.Forms.TextBox();
            this.tb_email_2 = new System.Windows.Forms.TextBox();
            this.tb_email_1 = new System.Windows.Forms.TextBox();
            this.fbCommand9 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand10 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand11 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand12 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.datEmails_enviados = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand16 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand14 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand13 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand15 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsEmails_enviados = new System.Data.DataSet();
            this.EMAILS_ENVIADOS = new System.Data.DataTable();
            this.COD_EMAIL_ENVIADO = new System.Data.DataColumn();
            this.DESTINATARIO_EMAIL_ENVIADO = new System.Data.DataColumn();
            this.DATA_EMAIL_ENVIADO = new System.Data.DataColumn();
            this.TIPO_EMAIL_ENVIADO = new System.Data.DataColumn();
            this.HORA_EMAIL_ENVIADO = new System.Data.DataColumn();
            this.CAMINHO_ARQUIVO_EMAIL_ENVIADO = new System.Data.DataColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.barra_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.datFornecedores = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand20 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand18 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand17 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand19 = new FirebirdSql.Data.FirebirdClient.FbCommand();
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
            this.comando_select = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_pos = new System.Windows.Forms.TextBox();
            this.tb_descricao_produto = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cod_forntextBox = new System.Windows.Forms.TextBox();
            this.col_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODREQITEMREQDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPITEMREQDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.POSICAO_ITEM_REQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODESTOQUEITEMREQDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COD_FORN_ITEM_REQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRICAOITEMREQDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qTDEITEMREQDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uNIDADEITEMREQDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATALIMITEITEMREQDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uRGENTEITEMREQDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.rEQUISITANTEITEMREQDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aut = new System.Windows.Forms.DataGridViewButtonColumn();
            this.col_autorizante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sETORITEMREQDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAREQUISICAOITEMREQDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sITUACAOATUALITEMREQDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dsRequisicoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.REQUISICOES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens_requisicao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsItens_req)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITENS_REQUISICAO)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsEmails_enviados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EMAILS_ENVIADOS)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsFornecedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FORNECEDORES)).BeginInit();
            this.SuspendLayout();
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label20.Location = new System.Drawing.Point(12, 9);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(270, 46);
            this.label20.TabIndex = 50;
            this.label20.Text = "REQUISIÇÃO";
            // 
            // tb_setor
            // 
            this.tb_setor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRequisicoes, "REQUISICOES.SETOR_REQUISICAO", true));
            this.tb_setor.Location = new System.Drawing.Point(561, 65);
            this.tb_setor.Name = "tb_setor";
            this.tb_setor.Size = new System.Drawing.Size(199, 20);
            this.tb_setor.TabIndex = 2;
            // 
            // dsRequisicoes
            // 
            this.dsRequisicoes.DataSetName = "dsRequisicoes";
            this.dsRequisicoes.Namespace = "http://www.tempuri.org/dsRequisicoes.xsd";
            this.dsRequisicoes.Tables.AddRange(new System.Data.DataTable[] {
            this.REQUISICOES});
            // 
            // REQUISICOES
            // 
            this.REQUISICOES.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_REQUISICAO,
            this.REQUISITANTE_REQUISICAO,
            this.SETOR_REQUISICAO,
            this.OBS_REQUISICAO,
            this.DATA_REQUISICAO});
            this.REQUISICOES.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_REQUISICAO"}, true)});
            this.REQUISICOES.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_REQUISICAO};
            this.REQUISICOES.TableName = "REQUISICOES";
            // 
            // COD_REQUISICAO
            // 
            this.COD_REQUISICAO.AllowDBNull = false;
            this.COD_REQUISICAO.ColumnName = "COD_REQUISICAO";
            this.COD_REQUISICAO.DataType = typeof(int);
            // 
            // REQUISITANTE_REQUISICAO
            // 
            this.REQUISITANTE_REQUISICAO.ColumnName = "REQUISITANTE_REQUISICAO";
            this.REQUISITANTE_REQUISICAO.MaxLength = 200;
            // 
            // SETOR_REQUISICAO
            // 
            this.SETOR_REQUISICAO.ColumnName = "SETOR_REQUISICAO";
            this.SETOR_REQUISICAO.MaxLength = 200;
            // 
            // OBS_REQUISICAO
            // 
            this.OBS_REQUISICAO.ColumnName = "OBS_REQUISICAO";
            this.OBS_REQUISICAO.MaxLength = 250;
            // 
            // DATA_REQUISICAO
            // 
            this.DATA_REQUISICAO.ColumnName = "DATA_REQUISICAO";
            this.DATA_REQUISICAO.DataType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(520, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 80;
            this.label3.Text = "Setor:";
            // 
            // tb_requisitante
            // 
            this.tb_requisitante.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRequisicoes, "REQUISICOES.REQUISITANTE_REQUISICAO", true));
            this.tb_requisitante.Location = new System.Drawing.Point(262, 65);
            this.tb_requisitante.Name = "tb_requisitante";
            this.tb_requisitante.Size = new System.Drawing.Size(229, 20);
            this.tb_requisitante.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 78;
            this.label2.Text = "Requisitante:";
            // 
            // tb_cod
            // 
            this.tb_cod.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRequisicoes, "REQUISICOES.COD_REQUISICAO", true));
            this.tb_cod.Location = new System.Drawing.Point(76, 65);
            this.tb_cod.Name = "tb_cod";
            this.tb_cod.Size = new System.Drawing.Size(74, 20);
            this.tb_cod.TabIndex = 77;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 76;
            this.label1.Text = "Cód.";
            // 
            // tb_excluir
            // 
            this.tb_excluir.Location = new System.Drawing.Point(656, 12);
            this.tb_excluir.Name = "tb_excluir";
            this.tb_excluir.Size = new System.Drawing.Size(49, 22);
            this.tb_excluir.TabIndex = 11;
            this.tb_excluir.Text = "Excluir";
            this.tb_excluir.UseVisualStyleBackColor = true;
            this.tb_excluir.Click += new System.EventHandler(this.tb_excluir_Click);
            // 
            // tb_salvar
            // 
            this.tb_salvar.Location = new System.Drawing.Point(711, 12);
            this.tb_salvar.Name = "tb_salvar";
            this.tb_salvar.Size = new System.Drawing.Size(49, 22);
            this.tb_salvar.TabIndex = 10;
            this.tb_salvar.Text = "Salvar";
            this.tb_salvar.UseVisualStyleBackColor = true;
            this.tb_salvar.Click += new System.EventHandler(this.tb_salvar_Click);
            // 
            // bt_localizar
            // 
            this.bt_localizar.Location = new System.Drawing.Point(535, 12);
            this.bt_localizar.Name = "bt_localizar";
            this.bt_localizar.Size = new System.Drawing.Size(60, 22);
            this.bt_localizar.TabIndex = 13;
            this.bt_localizar.Text = "Localizar";
            this.bt_localizar.UseVisualStyleBackColor = true;
            this.bt_localizar.Click += new System.EventHandler(this.bt_localizar_Click);
            // 
            // tb_novo
            // 
            this.tb_novo.Location = new System.Drawing.Point(601, 12);
            this.tb_novo.Name = "tb_novo";
            this.tb_novo.Size = new System.Drawing.Size(49, 22);
            this.tb_novo.TabIndex = 12;
            this.tb_novo.Text = "Novo";
            this.tb_novo.UseVisualStyleBackColor = true;
            this.tb_novo.Click += new System.EventHandler(this.tb_novo_Click);
            // 
            // dgvItens_requisicao
            // 
            this.dgvItens_requisicao.AllowUserToAddRows = false;
            this.dgvItens_requisicao.AutoGenerateColumns = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItens_requisicao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvItens_requisicao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens_requisicao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_cod,
            this.cODREQITEMREQDataGridViewTextBoxColumn,
            this.oPITEMREQDataGridViewTextBoxColumn,
            this.POSICAO_ITEM_REQ,
            this.cODESTOQUEITEMREQDataGridViewTextBoxColumn,
            this.COD_FORN_ITEM_REQ,
            this.col_item,
            this.dESCRICAOITEMREQDataGridViewTextBoxColumn,
            this.qTDEITEMREQDataGridViewTextBoxColumn,
            this.uNIDADEITEMREQDataGridViewTextBoxColumn,
            this.dATALIMITEITEMREQDataGridViewTextBoxColumn,
            this.uRGENTEITEMREQDataGridViewTextBoxColumn,
            this.rEQUISITANTEITEMREQDataGridViewTextBoxColumn,
            this.Aut,
            this.col_autorizante,
            this.sETORITEMREQDataGridViewTextBoxColumn,
            this.dATAREQUISICAOITEMREQDataGridViewTextBoxColumn,
            this.sITUACAOATUALITEMREQDataGridViewTextBoxColumn});
            this.dgvItens_requisicao.DataMember = "ITENS_REQUISICAO";
            this.dgvItens_requisicao.DataSource = this.dsItens_req;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItens_requisicao.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvItens_requisicao.Location = new System.Drawing.Point(18, 214);
            this.dgvItens_requisicao.Name = "dgvItens_requisicao";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItens_requisicao.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvItens_requisicao.Size = new System.Drawing.Size(974, 137);
            this.dgvItens_requisicao.TabIndex = 82;
            this.dgvItens_requisicao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItens_requisicao_CellContentClick);
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
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4});
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
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "AUTORIZADO_POR_ITEM_REQ";
            this.dataColumn1.MaxLength = 50;
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "POSICAO_ITEM_REQ";
            this.dataColumn2.MaxLength = 50;
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "ITEM_ITEM_REQ";
            this.dataColumn3.MaxLength = 200;
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "COD_FORN_ITEM_REQ";
            this.dataColumn4.MaxLength = 50;
            // 
            // tb_obs
            // 
            this.tb_obs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRequisicoes, "REQUISICOES.OBS_REQUISICAO", true));
            this.tb_obs.Location = new System.Drawing.Point(262, 91);
            this.tb_obs.Multiline = true;
            this.tb_obs.Name = "tb_obs";
            this.tb_obs.Size = new System.Drawing.Size(229, 57);
            this.tb_obs.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(183, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 83;
            this.label4.Text = "Observações:";
            // 
            // bt_inserir
            // 
            this.bt_inserir.Location = new System.Drawing.Point(18, 183);
            this.bt_inserir.Name = "bt_inserir";
            this.bt_inserir.Size = new System.Drawing.Size(45, 23);
            this.bt_inserir.TabIndex = 11;
            this.bt_inserir.Text = "Inserir";
            this.bt_inserir.UseVisualStyleBackColor = true;
            this.bt_inserir.Click += new System.EventHandler(this.bt_inserir_Click);
            // 
            // tb_op
            // 
            this.tb_op.Location = new System.Drawing.Point(116, 185);
            this.tb_op.Name = "tb_op";
            this.tb_op.Size = new System.Drawing.Size(75, 20);
            this.tb_op.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(520, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 87;
            this.label5.Text = "Data:";
            // 
            // tb_data_req
            // 
            this.tb_data_req.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRequisicoes, "REQUISICOES.DATA_REQUISICAO", true));
            this.tb_data_req.Location = new System.Drawing.Point(561, 91);
            this.tb_data_req.Name = "tb_data_req";
            this.tb_data_req.Size = new System.Drawing.Size(127, 20);
            this.tb_data_req.TabIndex = 88;
            // 
            // tb_descricao_item
            // 
            this.tb_descricao_item.Location = new System.Drawing.Point(459, 185);
            this.tb_descricao_item.Name = "tb_descricao_item";
            this.tb_descricao_item.Size = new System.Drawing.Size(108, 20);
            this.tb_descricao_item.TabIndex = 6;
            this.tb_descricao_item.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_descricao_item_KeyDown);
            // 
            // tb_qtde
            // 
            this.tb_qtde.Location = new System.Drawing.Point(573, 185);
            this.tb_qtde.Name = "tb_qtde";
            this.tb_qtde.Size = new System.Drawing.Size(96, 20);
            this.tb_qtde.TabIndex = 7;
            // 
            // tb_data_limite
            // 
            this.tb_data_limite.Location = new System.Drawing.Point(761, 185);
            this.tb_data_limite.Name = "tb_data_limite";
            this.tb_data_limite.Size = new System.Drawing.Size(101, 20);
            this.tb_data_limite.TabIndex = 9;
            // 
            // cbUrgente
            // 
            this.cbUrgente.AutoSize = true;
            this.cbUrgente.Location = new System.Drawing.Point(865, 186);
            this.cbUrgente.Name = "cbUrgente";
            this.cbUrgente.Size = new System.Drawing.Size(64, 17);
            this.cbUrgente.TabIndex = 10;
            this.cbUrgente.Text = "Urgente";
            this.cbUrgente.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(123, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 93;
            this.label6.Text = "OS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(456, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 26);
            this.label7.TabIndex = 94;
            this.label7.Text = "Descrição \r\nItem (Aperte F2)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(570, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 95;
            this.label8.Text = "Quantidade";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(758, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 13);
            this.label9.TabIndex = 96;
            this.label9.Text = "Data Limite (se houver)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(245, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 26);
            this.label10.TabIndex = 98;
            this.label10.Text = "Cód\r\nInt";
            // 
            // tb_cod_item
            // 
            this.tb_cod_item.Location = new System.Drawing.Point(242, 185);
            this.tb_cod_item.Name = "tb_cod_item";
            this.tb_cod_item.Size = new System.Drawing.Size(29, 20);
            this.tb_cod_item.TabIndex = 5;
            // 
            // datRequisicoes
            // 
            this.datRequisicoes.DeleteCommand = this.fbCommand4;
            this.datRequisicoes.InsertCommand = this.fbCommand2;
            this.datRequisicoes.SelectCommand = this.fbCommand1;
            this.datRequisicoes.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * from requisicoes";
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
            // cbRequisicoes
            // 
            this.cbRequisicoes.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbRequisicoes.DataAdapter = this.datRequisicoes;
            this.cbRequisicoes.QuotePrefix = "\"";
            this.cbRequisicoes.QuoteSuffix = "\"";
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
            // fbCommand7
            // 
            this.fbCommand7.CommandTimeout = 30;
            // 
            // cbItens_req
            // 
            this.cbItens_req.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbItens_req.DataAdapter = this.datItens_req;
            this.cbItens_req.QuotePrefix = "\"";
            this.cbItens_req.QuoteSuffix = "\"";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(671, 169);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 100;
            this.label11.Text = "Unidade";
            // 
            // tb_unidade
            // 
            this.tb_unidade.Location = new System.Drawing.Point(674, 185);
            this.tb_unidade.Name = "tb_unidade";
            this.tb_unidade.Size = new System.Drawing.Size(81, 20);
            this.tb_unidade.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(471, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 22);
            this.button1.TabIndex = 101;
            this.button1.Text = "Imprimir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(935, 169);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 34);
            this.button2.TabIndex = 102;
            this.button2.Text = "Autorizar\r\nTodos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(766, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(49, 22);
            this.button3.TabIndex = 103;
            this.button3.Text = "Email";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.tb_email_3);
            this.groupBox1.Controls.Add(this.tb_email_2);
            this.groupBox1.Controls.Add(this.tb_email_1);
            this.groupBox1.Location = new System.Drawing.Point(825, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(166, 71);
            this.groupBox1.TabIndex = 104;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Destinatários";
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(141, 51);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(19, 17);
            this.button6.TabIndex = 5;
            this.button6.Text = "3";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(141, 15);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(19, 17);
            this.button5.TabIndex = 4;
            this.button5.Text = "1";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(141, 33);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(19, 17);
            this.button4.TabIndex = 3;
            this.button4.Text = "2";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tb_email_3
            // 
            this.tb_email_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_email_3.Location = new System.Drawing.Point(6, 51);
            this.tb_email_3.Name = "tb_email_3";
            this.tb_email_3.Size = new System.Drawing.Size(129, 17);
            this.tb_email_3.TabIndex = 2;
            // 
            // tb_email_2
            // 
            this.tb_email_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_email_2.Location = new System.Drawing.Point(6, 33);
            this.tb_email_2.Name = "tb_email_2";
            this.tb_email_2.Size = new System.Drawing.Size(129, 17);
            this.tb_email_2.TabIndex = 1;
            // 
            // tb_email_1
            // 
            this.tb_email_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_email_1.Location = new System.Drawing.Point(6, 15);
            this.tb_email_1.Name = "tb_email_1";
            this.tb_email_1.Size = new System.Drawing.Size(129, 17);
            this.tb_email_1.TabIndex = 0;
            // 
            // fbCommand9
            // 
            this.fbCommand9.CommandTimeout = 30;
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
            // datEmails_enviados
            // 
            this.datEmails_enviados.DeleteCommand = this.fbCommand16;
            this.datEmails_enviados.InsertCommand = this.fbCommand14;
            this.datEmails_enviados.SelectCommand = this.fbCommand13;
            this.datEmails_enviados.UpdateCommand = this.fbCommand15;
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
            this.fbCommand13.CommandText = "SELECT * FROM EMAILS_ENVIADOS";
            this.fbCommand13.CommandTimeout = 30;
            this.fbCommand13.Connection = this.fbConnection1;
            // 
            // fbCommand15
            // 
            this.fbCommand15.CommandTimeout = 30;
            // 
            // dsEmails_enviados
            // 
            this.dsEmails_enviados.DataSetName = "dsEmails_enviados";
            this.dsEmails_enviados.Namespace = "http://www.tempuri.org/dsEmails_enviados.xsd";
            this.dsEmails_enviados.Tables.AddRange(new System.Data.DataTable[] {
            this.EMAILS_ENVIADOS});
            // 
            // EMAILS_ENVIADOS
            // 
            this.EMAILS_ENVIADOS.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_EMAIL_ENVIADO,
            this.DESTINATARIO_EMAIL_ENVIADO,
            this.DATA_EMAIL_ENVIADO,
            this.TIPO_EMAIL_ENVIADO,
            this.HORA_EMAIL_ENVIADO,
            this.CAMINHO_ARQUIVO_EMAIL_ENVIADO});
            this.EMAILS_ENVIADOS.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_EMAIL_ENVIADO"}, true)});
            this.EMAILS_ENVIADOS.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_EMAIL_ENVIADO};
            this.EMAILS_ENVIADOS.TableName = "EMAILS_ENVIADOS";
            // 
            // COD_EMAIL_ENVIADO
            // 
            this.COD_EMAIL_ENVIADO.AllowDBNull = false;
            this.COD_EMAIL_ENVIADO.ColumnName = "COD_EMAIL_ENVIADO";
            this.COD_EMAIL_ENVIADO.DataType = typeof(int);
            // 
            // DESTINATARIO_EMAIL_ENVIADO
            // 
            this.DESTINATARIO_EMAIL_ENVIADO.ColumnName = "DESTINATARIO_EMAIL_ENVIADO";
            this.DESTINATARIO_EMAIL_ENVIADO.MaxLength = 100;
            // 
            // DATA_EMAIL_ENVIADO
            // 
            this.DATA_EMAIL_ENVIADO.ColumnName = "DATA_EMAIL_ENVIADO";
            this.DATA_EMAIL_ENVIADO.DataType = typeof(System.DateTime);
            // 
            // TIPO_EMAIL_ENVIADO
            // 
            this.TIPO_EMAIL_ENVIADO.ColumnName = "TIPO_EMAIL_ENVIADO";
            this.TIPO_EMAIL_ENVIADO.MaxLength = 100;
            // 
            // HORA_EMAIL_ENVIADO
            // 
            this.HORA_EMAIL_ENVIADO.ColumnName = "HORA_EMAIL_ENVIADO";
            this.HORA_EMAIL_ENVIADO.DataType = typeof(System.DateTime);
            // 
            // CAMINHO_ARQUIVO_EMAIL_ENVIADO
            // 
            this.CAMINHO_ARQUIVO_EMAIL_ENVIADO.ColumnName = "CAMINHO_ARQUIVO_EMAIL_ENVIADO";
            this.CAMINHO_ARQUIVO_EMAIL_ENVIADO.MaxLength = 100;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barra_status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 385);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1004, 22);
            this.statusStrip1.TabIndex = 252;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // barra_status
            // 
            this.barra_status.Name = "barra_status";
            this.barra_status.Size = new System.Drawing.Size(70, 17);
            this.barra_status.Text = "Status Atual";
            // 
            // datFornecedores
            // 
            this.datFornecedores.DeleteCommand = this.fbCommand20;
            this.datFornecedores.InsertCommand = this.fbCommand18;
            this.datFornecedores.SelectCommand = this.fbCommand17;
            this.datFornecedores.UpdateCommand = this.fbCommand19;
            // 
            // fbCommand20
            // 
            this.fbCommand20.CommandTimeout = 30;
            // 
            // fbCommand18
            // 
            this.fbCommand18.CommandTimeout = 30;
            // 
            // fbCommand17
            // 
            this.fbCommand17.CommandText = "select * from fornecedores";
            this.fbCommand17.CommandTimeout = 30;
            this.fbCommand17.Connection = this.fbConnection1;
            // 
            // fbCommand19
            // 
            this.fbCommand19.CommandTimeout = 30;
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
            // comando_select
            // 
            this.comando_select.CommandTimeout = 30;
            this.comando_select.Connection = this.fbConnection1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(194, 169);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 13);
            this.label12.TabIndex = 254;
            this.label12.Text = "Pos";
            // 
            // tb_pos
            // 
            this.tb_pos.Location = new System.Drawing.Point(197, 185);
            this.tb_pos.Name = "tb_pos";
            this.tb_pos.Size = new System.Drawing.Size(39, 20);
            this.tb_pos.TabIndex = 253;
            // 
            // tb_descricao_produto
            // 
            this.tb_descricao_produto.Location = new System.Drawing.Point(315, 185);
            this.tb_descricao_produto.Name = "tb_descricao_produto";
            this.tb_descricao_produto.Size = new System.Drawing.Size(138, 20);
            this.tb_descricao_produto.TabIndex = 255;
            this.tb_descricao_produto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_item_item_KeyDown);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(314, 156);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 26);
            this.label13.TabIndex = 256;
            this.label13.Text = "Descrição \r\nProduto (Aperte F2)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(281, 156);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 26);
            this.label14.TabIndex = 258;
            this.label14.Text = "Cód\r\nForn";
            // 
            // cod_forntextBox
            // 
            this.cod_forntextBox.Location = new System.Drawing.Point(280, 185);
            this.cod_forntextBox.Name = "cod_forntextBox";
            this.cod_forntextBox.Size = new System.Drawing.Size(29, 20);
            this.cod_forntextBox.TabIndex = 257;
            // 
            // col_cod
            // 
            this.col_cod.DataPropertyName = "COD_ITEM_REQ";
            this.col_cod.HeaderText = "Cód.";
            this.col_cod.Name = "col_cod";
            this.col_cod.Width = 50;
            // 
            // cODREQITEMREQDataGridViewTextBoxColumn
            // 
            this.cODREQITEMREQDataGridViewTextBoxColumn.DataPropertyName = "COD_REQ_ITEM_REQ";
            this.cODREQITEMREQDataGridViewTextBoxColumn.HeaderText = "COD_REQ_ITEM_REQ";
            this.cODREQITEMREQDataGridViewTextBoxColumn.Name = "cODREQITEMREQDataGridViewTextBoxColumn";
            this.cODREQITEMREQDataGridViewTextBoxColumn.Visible = false;
            // 
            // oPITEMREQDataGridViewTextBoxColumn
            // 
            this.oPITEMREQDataGridViewTextBoxColumn.DataPropertyName = "OP_ITEM_REQ";
            this.oPITEMREQDataGridViewTextBoxColumn.HeaderText = "OS";
            this.oPITEMREQDataGridViewTextBoxColumn.Name = "oPITEMREQDataGridViewTextBoxColumn";
            this.oPITEMREQDataGridViewTextBoxColumn.Width = 90;
            // 
            // POSICAO_ITEM_REQ
            // 
            this.POSICAO_ITEM_REQ.DataPropertyName = "POSICAO_ITEM_REQ";
            this.POSICAO_ITEM_REQ.HeaderText = "Pos";
            this.POSICAO_ITEM_REQ.Name = "POSICAO_ITEM_REQ";
            this.POSICAO_ITEM_REQ.Width = 40;
            // 
            // cODESTOQUEITEMREQDataGridViewTextBoxColumn
            // 
            this.cODESTOQUEITEMREQDataGridViewTextBoxColumn.DataPropertyName = "COD_ESTOQUE_ITEM_REQ";
            this.cODESTOQUEITEMREQDataGridViewTextBoxColumn.HeaderText = "Cod Int";
            this.cODESTOQUEITEMREQDataGridViewTextBoxColumn.Name = "cODESTOQUEITEMREQDataGridViewTextBoxColumn";
            this.cODESTOQUEITEMREQDataGridViewTextBoxColumn.Width = 37;
            // 
            // COD_FORN_ITEM_REQ
            // 
            this.COD_FORN_ITEM_REQ.DataPropertyName = "COD_FORN_ITEM_REQ";
            this.COD_FORN_ITEM_REQ.HeaderText = "Cod Forn";
            this.COD_FORN_ITEM_REQ.Name = "COD_FORN_ITEM_REQ";
            this.COD_FORN_ITEM_REQ.Width = 38;
            // 
            // col_item
            // 
            this.col_item.DataPropertyName = "ITEM_ITEM_REQ";
            this.col_item.HeaderText = "Descrição Produto";
            this.col_item.Name = "col_item";
            this.col_item.Width = 140;
            // 
            // dESCRICAOITEMREQDataGridViewTextBoxColumn
            // 
            this.dESCRICAOITEMREQDataGridViewTextBoxColumn.DataPropertyName = "DESCRICAO_ITEM_REQ";
            this.dESCRICAOITEMREQDataGridViewTextBoxColumn.HeaderText = "Descrição Item";
            this.dESCRICAOITEMREQDataGridViewTextBoxColumn.Name = "dESCRICAOITEMREQDataGridViewTextBoxColumn";
            this.dESCRICAOITEMREQDataGridViewTextBoxColumn.Width = 120;
            // 
            // qTDEITEMREQDataGridViewTextBoxColumn
            // 
            this.qTDEITEMREQDataGridViewTextBoxColumn.DataPropertyName = "QTDE_ITEM_REQ";
            this.qTDEITEMREQDataGridViewTextBoxColumn.HeaderText = "Qtde";
            this.qTDEITEMREQDataGridViewTextBoxColumn.Name = "qTDEITEMREQDataGridViewTextBoxColumn";
            // 
            // uNIDADEITEMREQDataGridViewTextBoxColumn
            // 
            this.uNIDADEITEMREQDataGridViewTextBoxColumn.DataPropertyName = "UNIDADE_ITEM_REQ";
            this.uNIDADEITEMREQDataGridViewTextBoxColumn.HeaderText = "Unidade";
            this.uNIDADEITEMREQDataGridViewTextBoxColumn.Name = "uNIDADEITEMREQDataGridViewTextBoxColumn";
            this.uNIDADEITEMREQDataGridViewTextBoxColumn.Width = 90;
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
            // sITUACAOATUALITEMREQDataGridViewTextBoxColumn
            // 
            this.sITUACAOATUALITEMREQDataGridViewTextBoxColumn.DataPropertyName = "SITUACAO_ATUAL_ITEM_REQ";
            this.sITUACAOATUALITEMREQDataGridViewTextBoxColumn.HeaderText = "Situação Atual";
            this.sITUACAOATUALITEMREQDataGridViewTextBoxColumn.Name = "sITUACAOATUALITEMREQDataGridViewTextBoxColumn";
            this.sITUACAOATUALITEMREQDataGridViewTextBoxColumn.Width = 250;
            // 
            // form_requisicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 407);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cod_forntextBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tb_descricao_produto);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tb_pos);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tb_unidade);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_cod_item);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbUrgente);
            this.Controls.Add(this.tb_data_limite);
            this.Controls.Add(this.tb_qtde);
            this.Controls.Add(this.tb_descricao_item);
            this.Controls.Add(this.tb_data_req);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_op);
            this.Controls.Add(this.bt_inserir);
            this.Controls.Add(this.tb_obs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvItens_requisicao);
            this.Controls.Add(this.tb_setor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_requisitante);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_cod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_excluir);
            this.Controls.Add(this.tb_salvar);
            this.Controls.Add(this.bt_localizar);
            this.Controls.Add(this.tb_novo);
            this.Controls.Add(this.label20);
            this.KeyPreview = true;
            this.Name = "form_requisicao";
            this.Text = "Requisição";
            this.Load += new System.EventHandler(this.form_requisicao_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.form_requisicao_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dsRequisicoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.REQUISICOES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens_requisicao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsItens_req)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITENS_REQUISICAO)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsEmails_enviados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EMAILS_ENVIADOS)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsFornecedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FORNECEDORES)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tb_setor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_requisitante;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_cod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tb_excluir;
        private System.Windows.Forms.Button tb_salvar;
        private System.Windows.Forms.Button bt_localizar;
        private System.Windows.Forms.Button tb_novo;
        private System.Windows.Forms.DataGridView dgvItens_requisicao;
        private System.Windows.Forms.TextBox tb_obs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_inserir;
        private System.Windows.Forms.TextBox tb_op;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_data_req;
        private System.Windows.Forms.TextBox tb_descricao_item;
        private System.Windows.Forms.TextBox tb_qtde;
        private System.Windows.Forms.TextBox tb_data_limite;
        private System.Windows.Forms.CheckBox cbUrgente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_cod_item;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datRequisicoes;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Data.DataSet dsRequisicoes;
        private System.Data.DataTable REQUISICOES;
        private System.Data.DataColumn COD_REQUISICAO;
        private System.Data.DataColumn REQUISITANTE_REQUISICAO;
        private System.Data.DataColumn SETOR_REQUISICAO;
        private System.Data.DataColumn OBS_REQUISICAO;
        private System.Data.DataColumn DATA_REQUISICAO;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbRequisicoes;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datItens_req;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand8;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand6;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand5;
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
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbItens_req;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_unidade;
        private System.Windows.Forms.Button button1;
        private System.Data.DataColumn dataColumn1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox tb_email_3;
        private System.Windows.Forms.TextBox tb_email_2;
        private System.Windows.Forms.TextBox tb_email_1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand9;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand10;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand11;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand12;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datEmails_enviados;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand16;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand14;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand13;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand15;
        private System.Data.DataSet dsEmails_enviados;
        private System.Data.DataTable EMAILS_ENVIADOS;
        private System.Data.DataColumn COD_EMAIL_ENVIADO;
        private System.Data.DataColumn DESTINATARIO_EMAIL_ENVIADO;
        private System.Data.DataColumn DATA_EMAIL_ENVIADO;
        private System.Data.DataColumn TIPO_EMAIL_ENVIADO;
        private System.Data.DataColumn HORA_EMAIL_ENVIADO;
        private System.Data.DataColumn CAMINHO_ARQUIVO_EMAIL_ENVIADO;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel barra_status;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datFornecedores;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand20;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand18;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand17;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand19;
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
        private FirebirdSql.Data.FirebirdClient.FbCommand comando_select;
        private System.Data.DataColumn dataColumn2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_pos;
        private System.Windows.Forms.TextBox tb_descricao_produto;
        private System.Windows.Forms.Label label13;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox cod_forntextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODREQITEMREQDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPITEMREQDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn POSICAO_ITEM_REQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODESTOQUEITEMREQDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_FORN_ITEM_REQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRICAOITEMREQDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qTDEITEMREQDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uNIDADEITEMREQDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATALIMITEITEMREQDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn uRGENTEITEMREQDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEQUISITANTEITEMREQDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Aut;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_autorizante;
        private System.Windows.Forms.DataGridViewTextBoxColumn sETORITEMREQDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAREQUISICAOITEMREQDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sITUACAOATUALITEMREQDataGridViewTextBoxColumn;
    }
}