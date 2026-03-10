namespace Evolucao
{
    partial class form_operacoes_peso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_operacoes_peso));
            this.button1 = new System.Windows.Forms.Button();
            this.tb_peso = new System.Windows.Forms.TextBox();
            this.dgvOperacoesPeso = new System.Windows.Forms.DataGridView();
            this.cODVALOROPERACAOPESODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPERACAOVALOROPERACAOPESODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEQUENCIAVALOROPERACAOPESODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HORA_VALOR_OPERACAO_PESO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COD_PESO_OPERACAO_PESO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRICAO_PESO_OPERACAO_PESO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsOperacoesPeso = new System.Data.DataSet();
            this.VALOR_OPERACAO_PESO = new System.Data.DataTable();
            this.COD_VALOR_OPERACAO_PESO = new System.Data.DataColumn();
            this.OPERACAO_VALOR_OPERACAO_PESO = new System.Data.DataColumn();
            this.VALOR_VALOR_OPERACAO_PESO = new System.Data.DataColumn();
            this.SEQUENCIA_VALOR_OPERACAO_PESO = new System.Data.DataColumn();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.button6 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.datOperacoesPeso = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.cbOperacoesPeso = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.tb_cod_peso = new System.Windows.Forms.TextBox();
            this.dgvMateriaPrimaPeso = new System.Windows.Forms.DataGridView();
            this.dsMateriaPrimaPeso = new System.Data.DataSet();
            this.VALOR_MATERIA_PRIMA_PESO = new System.Data.DataTable();
            this.COD_VALOR_MP_PESO = new System.Data.DataColumn();
            this.COD_MP_VALOR_MP_PESO = new System.Data.DataColumn();
            this.DESCRICAO_VALOR_MP_PESO = new System.Data.DataColumn();
            this.VALOR_VALOR_MP_PESO = new System.Data.DataColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dgvOutrosServicosPeso = new System.Windows.Forms.DataGridView();
            this.cODOUTROSSERVPESODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODOUTROSOUTROSSERVPESODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRICAOOUTROSSERVPESODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALOROUTROSSERVPESODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsOutrosServicosPeso = new System.Data.DataSet();
            this.VALOR_OUTROS_SERVICOS_PESO = new System.Data.DataTable();
            this.COD_OUTROS_SERV_PESO = new System.Data.DataColumn();
            this.COD_OUTROS_OUTROS_SERV_PESO = new System.Data.DataColumn();
            this.DESCRICAO_OUTROS_SERV_PESO = new System.Data.DataColumn();
            this.VALOR_OUTROS_SERV_PESO = new System.Data.DataColumn();
            this.datMateriaPrimaPeso = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand8 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand6 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand5 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand7 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.cbMateriaPrimaPeso = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.datOutrosServicosPeso = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand12 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand10 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand9 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand11 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.cbOutrosServicosPeso = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.dgvPesoMoldes = new System.Windows.Forms.DataGridView();
            this.cODPESOMOLDESPECASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRICAOPESOMOLDESPECASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pESOMINIMOMOLDESPECASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pESOMAXIMOMOLDESPECASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRECOMOLDESPECASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsPesoMoldes = new System.Data.DataSet();
            this.PESO_MOLDES_PECAS = new System.Data.DataTable();
            this.COD_PESO_MOLDES_PECAS = new System.Data.DataColumn();
            this.DESCRICAO_PESO_MOLDES_PECAS = new System.Data.DataColumn();
            this.PESO_MINIMO_MOLDES_PECAS = new System.Data.DataColumn();
            this.PESO_MAXIMO_MOLDES_PECAS = new System.Data.DataColumn();
            this.PRECO_MOLDES_PECAS = new System.Data.DataColumn();
            this.datPesoMoldes = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand16 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand14 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand13 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand15 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPesoMoldes = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.dataColumn3 = new System.Data.DataColumn();
            this.cODVALORMPPESODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODMPVALORMPPESODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRICAOVALORMPPESODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UN_VALOR_MP_PESO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORVALORMPPESODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperacoesPeso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOperacoesPeso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VALOR_OPERACAO_PESO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriaPrimaPeso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMateriaPrimaPeso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VALOR_MATERIA_PRIMA_PESO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutrosServicosPeso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOutrosServicosPeso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VALOR_OUTROS_SERVICOS_PESO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesoMoldes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPesoMoldes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PESO_MOLDES_PECAS)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Selecionar Peso";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_peso
            // 
            this.tb_peso.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_peso.Location = new System.Drawing.Point(154, 15);
            this.tb_peso.Name = "tb_peso";
            this.tb_peso.ReadOnly = true;
            this.tb_peso.Size = new System.Drawing.Size(218, 38);
            this.tb_peso.TabIndex = 1;
            // 
            // dgvOperacoesPeso
            // 
            this.dgvOperacoesPeso.AllowUserToAddRows = false;
            this.dgvOperacoesPeso.AutoGenerateColumns = false;
            this.dgvOperacoesPeso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOperacoesPeso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODVALOROPERACAOPESODataGridViewTextBoxColumn,
            this.oPERACAOVALOROPERACAOPESODataGridViewTextBoxColumn,
            this.sEQUENCIAVALOROPERACAOPESODataGridViewTextBoxColumn,
            this.HORA_VALOR_OPERACAO_PESO,
            this.COD_PESO_OPERACAO_PESO,
            this.DESCRICAO_PESO_OPERACAO_PESO});
            this.dgvOperacoesPeso.DataMember = "VALOR_OPERACAO_PESO";
            this.dgvOperacoesPeso.DataSource = this.dsOperacoesPeso;
            this.dgvOperacoesPeso.Location = new System.Drawing.Point(12, 106);
            this.dgvOperacoesPeso.Name = "dgvOperacoesPeso";
            this.dgvOperacoesPeso.Size = new System.Drawing.Size(466, 400);
            this.dgvOperacoesPeso.TabIndex = 2;
            // 
            // cODVALOROPERACAOPESODataGridViewTextBoxColumn
            // 
            this.cODVALOROPERACAOPESODataGridViewTextBoxColumn.DataPropertyName = "COD_VALOR_OPERACAO_PESO";
            this.cODVALOROPERACAOPESODataGridViewTextBoxColumn.HeaderText = "Cod.";
            this.cODVALOROPERACAOPESODataGridViewTextBoxColumn.Name = "cODVALOROPERACAOPESODataGridViewTextBoxColumn";
            // 
            // oPERACAOVALOROPERACAOPESODataGridViewTextBoxColumn
            // 
            this.oPERACAOVALOROPERACAOPESODataGridViewTextBoxColumn.DataPropertyName = "OPERACAO_VALOR_OPERACAO_PESO";
            this.oPERACAOVALOROPERACAOPESODataGridViewTextBoxColumn.HeaderText = "Operação";
            this.oPERACAOVALOROPERACAOPESODataGridViewTextBoxColumn.Name = "oPERACAOVALOROPERACAOPESODataGridViewTextBoxColumn";
            this.oPERACAOVALOROPERACAOPESODataGridViewTextBoxColumn.Width = 180;
            // 
            // sEQUENCIAVALOROPERACAOPESODataGridViewTextBoxColumn
            // 
            this.sEQUENCIAVALOROPERACAOPESODataGridViewTextBoxColumn.DataPropertyName = "SEQUENCIA_VALOR_OPERACAO_PESO";
            this.sEQUENCIAVALOROPERACAOPESODataGridViewTextBoxColumn.HeaderText = "Sequencia";
            this.sEQUENCIAVALOROPERACAOPESODataGridViewTextBoxColumn.Name = "sEQUENCIAVALOROPERACAOPESODataGridViewTextBoxColumn";
            this.sEQUENCIAVALOROPERACAOPESODataGridViewTextBoxColumn.Width = 75;
            // 
            // HORA_VALOR_OPERACAO_PESO
            // 
            this.HORA_VALOR_OPERACAO_PESO.DataPropertyName = "HORA_VALOR_OPERACAO_PESO";
            this.HORA_VALOR_OPERACAO_PESO.HeaderText = "Horas";
            this.HORA_VALOR_OPERACAO_PESO.Name = "HORA_VALOR_OPERACAO_PESO";
            this.HORA_VALOR_OPERACAO_PESO.Width = 50;
            // 
            // COD_PESO_OPERACAO_PESO
            // 
            this.COD_PESO_OPERACAO_PESO.DataPropertyName = "COD_PESO_OPERACAO_PESO";
            this.COD_PESO_OPERACAO_PESO.HeaderText = "COD_PESO_OPERACAO_PESO";
            this.COD_PESO_OPERACAO_PESO.Name = "COD_PESO_OPERACAO_PESO";
            // 
            // DESCRICAO_PESO_OPERACAO_PESO
            // 
            this.DESCRICAO_PESO_OPERACAO_PESO.DataPropertyName = "DESCRICAO_PESO_OPERACAO_PESO";
            this.DESCRICAO_PESO_OPERACAO_PESO.HeaderText = "DESCRICAO_PESO_OPERACAO_PESO";
            this.DESCRICAO_PESO_OPERACAO_PESO.Name = "DESCRICAO_PESO_OPERACAO_PESO";
            // 
            // dsOperacoesPeso
            // 
            this.dsOperacoesPeso.DataSetName = "dsOperacoesPeso";
            this.dsOperacoesPeso.Namespace = "http://www.tempuri.org/dsOperacoesPeso.xsd";
            this.dsOperacoesPeso.Tables.AddRange(new System.Data.DataTable[] {
            this.VALOR_OPERACAO_PESO});
            // 
            // VALOR_OPERACAO_PESO
            // 
            this.VALOR_OPERACAO_PESO.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_VALOR_OPERACAO_PESO,
            this.OPERACAO_VALOR_OPERACAO_PESO,
            this.VALOR_VALOR_OPERACAO_PESO,
            this.SEQUENCIA_VALOR_OPERACAO_PESO,
            this.dataColumn1,
            this.dataColumn2});
            this.VALOR_OPERACAO_PESO.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_VALOR_OPERACAO_PESO"}, true)});
            this.VALOR_OPERACAO_PESO.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_VALOR_OPERACAO_PESO};
            this.VALOR_OPERACAO_PESO.TableName = "VALOR_OPERACAO_PESO";
            // 
            // COD_VALOR_OPERACAO_PESO
            // 
            this.COD_VALOR_OPERACAO_PESO.AllowDBNull = false;
            this.COD_VALOR_OPERACAO_PESO.ColumnName = "COD_VALOR_OPERACAO_PESO";
            this.COD_VALOR_OPERACAO_PESO.DataType = typeof(int);
            // 
            // OPERACAO_VALOR_OPERACAO_PESO
            // 
            this.OPERACAO_VALOR_OPERACAO_PESO.ColumnName = "OPERACAO_VALOR_OPERACAO_PESO";
            this.OPERACAO_VALOR_OPERACAO_PESO.MaxLength = 200;
            // 
            // VALOR_VALOR_OPERACAO_PESO
            // 
            this.VALOR_VALOR_OPERACAO_PESO.ColumnName = "HORA_VALOR_OPERACAO_PESO";
            this.VALOR_VALOR_OPERACAO_PESO.DataType = typeof(double);
            // 
            // SEQUENCIA_VALOR_OPERACAO_PESO
            // 
            this.SEQUENCIA_VALOR_OPERACAO_PESO.ColumnName = "SEQUENCIA_VALOR_OPERACAO_PESO";
            this.SEQUENCIA_VALOR_OPERACAO_PESO.DataType = typeof(int);
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "COD_PESO_OPERACAO_PESO";
            this.dataColumn1.DataType = typeof(int);
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "DESCRICAO_PESO_OPERACAO_PESO";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 77);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(105, 23);
            this.button6.TabIndex = 4;
            this.button6.Text = "Inserir Operação";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(355, 512);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Salvar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // datOperacoesPeso
            // 
            this.datOperacoesPeso.DeleteCommand = this.fbCommand4;
            this.datOperacoesPeso.InsertCommand = this.fbCommand2;
            this.datOperacoesPeso.SelectCommand = this.fbCommand1;
            this.datOperacoesPeso.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * from VALOR_OPERACAO_PESO";
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
            // cbOperacoesPeso
            // 
            this.cbOperacoesPeso.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbOperacoesPeso.DataAdapter = this.datOperacoesPeso;
            this.cbOperacoesPeso.QuotePrefix = "\"";
            this.cbOperacoesPeso.QuoteSuffix = "\"";
            // 
            // tb_cod_peso
            // 
            this.tb_cod_peso.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cod_peso.Location = new System.Drawing.Point(93, 15);
            this.tb_cod_peso.Name = "tb_cod_peso";
            this.tb_cod_peso.ReadOnly = true;
            this.tb_cod_peso.Size = new System.Drawing.Size(55, 38);
            this.tb_cod_peso.TabIndex = 6;
            // 
            // dgvMateriaPrimaPeso
            // 
            this.dgvMateriaPrimaPeso.AllowUserToAddRows = false;
            this.dgvMateriaPrimaPeso.AutoGenerateColumns = false;
            this.dgvMateriaPrimaPeso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMateriaPrimaPeso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODVALORMPPESODataGridViewTextBoxColumn,
            this.cODMPVALORMPPESODataGridViewTextBoxColumn,
            this.dESCRICAOVALORMPPESODataGridViewTextBoxColumn,
            this.UN_VALOR_MP_PESO,
            this.vALORVALORMPPESODataGridViewTextBoxColumn});
            this.dgvMateriaPrimaPeso.DataMember = "VALOR_MATERIA_PRIMA_PESO";
            this.dgvMateriaPrimaPeso.DataSource = this.dsMateriaPrimaPeso;
            this.dgvMateriaPrimaPeso.Location = new System.Drawing.Point(484, 106);
            this.dgvMateriaPrimaPeso.Name = "dgvMateriaPrimaPeso";
            this.dgvMateriaPrimaPeso.Size = new System.Drawing.Size(286, 143);
            this.dgvMateriaPrimaPeso.TabIndex = 7;
            // 
            // dsMateriaPrimaPeso
            // 
            this.dsMateriaPrimaPeso.DataSetName = "dsMateriaPrimaPeso";
            this.dsMateriaPrimaPeso.Namespace = "http://www.tempuri.org/dsMateriaPrimaPeso.xsd";
            this.dsMateriaPrimaPeso.Tables.AddRange(new System.Data.DataTable[] {
            this.VALOR_MATERIA_PRIMA_PESO});
            // 
            // VALOR_MATERIA_PRIMA_PESO
            // 
            this.VALOR_MATERIA_PRIMA_PESO.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_VALOR_MP_PESO,
            this.COD_MP_VALOR_MP_PESO,
            this.DESCRICAO_VALOR_MP_PESO,
            this.VALOR_VALOR_MP_PESO,
            this.dataColumn3});
            this.VALOR_MATERIA_PRIMA_PESO.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_VALOR_MP_PESO"}, true)});
            this.VALOR_MATERIA_PRIMA_PESO.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_VALOR_MP_PESO};
            this.VALOR_MATERIA_PRIMA_PESO.TableName = "VALOR_MATERIA_PRIMA_PESO";
            // 
            // COD_VALOR_MP_PESO
            // 
            this.COD_VALOR_MP_PESO.AllowDBNull = false;
            this.COD_VALOR_MP_PESO.ColumnName = "COD_VALOR_MP_PESO";
            this.COD_VALOR_MP_PESO.DataType = typeof(int);
            // 
            // COD_MP_VALOR_MP_PESO
            // 
            this.COD_MP_VALOR_MP_PESO.ColumnName = "COD_MP_VALOR_MP_PESO";
            this.COD_MP_VALOR_MP_PESO.DataType = typeof(int);
            // 
            // DESCRICAO_VALOR_MP_PESO
            // 
            this.DESCRICAO_VALOR_MP_PESO.ColumnName = "DESCRICAO_VALOR_MP_PESO";
            // 
            // VALOR_VALOR_MP_PESO
            // 
            this.VALOR_VALOR_MP_PESO.ColumnName = "VALOR_VALOR_MP_PESO";
            this.VALOR_VALOR_MP_PESO.DataType = typeof(double);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(484, 77);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Inserir MP";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(485, 255);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Inserir Outros Serv.";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dgvOutrosServicosPeso
            // 
            this.dgvOutrosServicosPeso.AllowUserToAddRows = false;
            this.dgvOutrosServicosPeso.AutoGenerateColumns = false;
            this.dgvOutrosServicosPeso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutrosServicosPeso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODOUTROSSERVPESODataGridViewTextBoxColumn,
            this.cODOUTROSOUTROSSERVPESODataGridViewTextBoxColumn,
            this.dESCRICAOOUTROSSERVPESODataGridViewTextBoxColumn,
            this.vALOROUTROSSERVPESODataGridViewTextBoxColumn});
            this.dgvOutrosServicosPeso.DataMember = "VALOR_OUTROS_SERVICOS_PESO";
            this.dgvOutrosServicosPeso.DataSource = this.dsOutrosServicosPeso;
            this.dgvOutrosServicosPeso.Location = new System.Drawing.Point(484, 284);
            this.dgvOutrosServicosPeso.Name = "dgvOutrosServicosPeso";
            this.dgvOutrosServicosPeso.Size = new System.Drawing.Size(286, 222);
            this.dgvOutrosServicosPeso.TabIndex = 10;
            // 
            // cODOUTROSSERVPESODataGridViewTextBoxColumn
            // 
            this.cODOUTROSSERVPESODataGridViewTextBoxColumn.DataPropertyName = "COD_OUTROS_SERV_PESO";
            this.cODOUTROSSERVPESODataGridViewTextBoxColumn.HeaderText = "Cod.";
            this.cODOUTROSSERVPESODataGridViewTextBoxColumn.Name = "cODOUTROSSERVPESODataGridViewTextBoxColumn";
            this.cODOUTROSSERVPESODataGridViewTextBoxColumn.Width = 50;
            // 
            // cODOUTROSOUTROSSERVPESODataGridViewTextBoxColumn
            // 
            this.cODOUTROSOUTROSSERVPESODataGridViewTextBoxColumn.DataPropertyName = "COD_OUTROS_OUTROS_SERV_PESO";
            this.cODOUTROSOUTROSSERVPESODataGridViewTextBoxColumn.HeaderText = "COD_OUTROS_OUTROS_SERV_PESO";
            this.cODOUTROSOUTROSSERVPESODataGridViewTextBoxColumn.Name = "cODOUTROSOUTROSSERVPESODataGridViewTextBoxColumn";
            this.cODOUTROSOUTROSSERVPESODataGridViewTextBoxColumn.Visible = false;
            // 
            // dESCRICAOOUTROSSERVPESODataGridViewTextBoxColumn
            // 
            this.dESCRICAOOUTROSSERVPESODataGridViewTextBoxColumn.DataPropertyName = "DESCRICAO_OUTROS_SERV_PESO";
            this.dESCRICAOOUTROSSERVPESODataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.dESCRICAOOUTROSSERVPESODataGridViewTextBoxColumn.Name = "dESCRICAOOUTROSSERVPESODataGridViewTextBoxColumn";
            this.dESCRICAOOUTROSSERVPESODataGridViewTextBoxColumn.Width = 125;
            // 
            // vALOROUTROSSERVPESODataGridViewTextBoxColumn
            // 
            this.vALOROUTROSSERVPESODataGridViewTextBoxColumn.DataPropertyName = "VALOR_OUTROS_SERV_PESO";
            this.vALOROUTROSSERVPESODataGridViewTextBoxColumn.HeaderText = "Valor";
            this.vALOROUTROSSERVPESODataGridViewTextBoxColumn.Name = "vALOROUTROSSERVPESODataGridViewTextBoxColumn";
            this.vALOROUTROSSERVPESODataGridViewTextBoxColumn.Width = 75;
            // 
            // dsOutrosServicosPeso
            // 
            this.dsOutrosServicosPeso.DataSetName = "dsOutrosServicosPeso";
            this.dsOutrosServicosPeso.Namespace = "http://www.tempuri.org/dsOutrosServicosPeso.xsd";
            this.dsOutrosServicosPeso.Tables.AddRange(new System.Data.DataTable[] {
            this.VALOR_OUTROS_SERVICOS_PESO});
            // 
            // VALOR_OUTROS_SERVICOS_PESO
            // 
            this.VALOR_OUTROS_SERVICOS_PESO.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_OUTROS_SERV_PESO,
            this.COD_OUTROS_OUTROS_SERV_PESO,
            this.DESCRICAO_OUTROS_SERV_PESO,
            this.VALOR_OUTROS_SERV_PESO});
            this.VALOR_OUTROS_SERVICOS_PESO.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_OUTROS_SERV_PESO"}, true)});
            this.VALOR_OUTROS_SERVICOS_PESO.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_OUTROS_SERV_PESO};
            this.VALOR_OUTROS_SERVICOS_PESO.TableName = "VALOR_OUTROS_SERVICOS_PESO";
            // 
            // COD_OUTROS_SERV_PESO
            // 
            this.COD_OUTROS_SERV_PESO.AllowDBNull = false;
            this.COD_OUTROS_SERV_PESO.ColumnName = "COD_OUTROS_SERV_PESO";
            this.COD_OUTROS_SERV_PESO.DataType = typeof(int);
            // 
            // COD_OUTROS_OUTROS_SERV_PESO
            // 
            this.COD_OUTROS_OUTROS_SERV_PESO.ColumnName = "COD_OUTROS_OUTROS_SERV_PESO";
            this.COD_OUTROS_OUTROS_SERV_PESO.DataType = typeof(int);
            // 
            // DESCRICAO_OUTROS_SERV_PESO
            // 
            this.DESCRICAO_OUTROS_SERV_PESO.ColumnName = "DESCRICAO_OUTROS_SERV_PESO";
            // 
            // VALOR_OUTROS_SERV_PESO
            // 
            this.VALOR_OUTROS_SERV_PESO.ColumnName = "VALOR_OUTROS_SERV_PESO";
            this.VALOR_OUTROS_SERV_PESO.DataType = typeof(double);
            // 
            // datMateriaPrimaPeso
            // 
            this.datMateriaPrimaPeso.DeleteCommand = this.fbCommand8;
            this.datMateriaPrimaPeso.InsertCommand = this.fbCommand6;
            this.datMateriaPrimaPeso.SelectCommand = this.fbCommand5;
            this.datMateriaPrimaPeso.UpdateCommand = this.fbCommand7;
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
            this.fbCommand5.CommandText = "SELECT * FROM VALOR_MATERIA_PRIMA_PESO";
            this.fbCommand5.CommandTimeout = 30;
            this.fbCommand5.Connection = this.fbConnection1;
            // 
            // fbCommand7
            // 
            this.fbCommand7.CommandTimeout = 30;
            // 
            // cbMateriaPrimaPeso
            // 
            this.cbMateriaPrimaPeso.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbMateriaPrimaPeso.DataAdapter = this.datMateriaPrimaPeso;
            this.cbMateriaPrimaPeso.QuotePrefix = "\"";
            this.cbMateriaPrimaPeso.QuoteSuffix = "\"";
            // 
            // datOutrosServicosPeso
            // 
            this.datOutrosServicosPeso.DeleteCommand = this.fbCommand12;
            this.datOutrosServicosPeso.InsertCommand = this.fbCommand10;
            this.datOutrosServicosPeso.SelectCommand = this.fbCommand9;
            this.datOutrosServicosPeso.UpdateCommand = this.fbCommand11;
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
            this.fbCommand9.CommandText = "SELECT * FROM VALOR_OUTROS_SERVICOS_PESO";
            this.fbCommand9.CommandTimeout = 30;
            this.fbCommand9.Connection = this.fbConnection1;
            // 
            // fbCommand11
            // 
            this.fbCommand11.CommandTimeout = 30;
            // 
            // cbOutrosServicosPeso
            // 
            this.cbOutrosServicosPeso.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbOutrosServicosPeso.DataAdapter = this.datOutrosServicosPeso;
            this.cbOutrosServicosPeso.QuotePrefix = "\"";
            this.cbOutrosServicosPeso.QuoteSuffix = "\"";
            // 
            // dgvPesoMoldes
            // 
            this.dgvPesoMoldes.AllowUserToAddRows = false;
            this.dgvPesoMoldes.AllowUserToDeleteRows = false;
            this.dgvPesoMoldes.AutoGenerateColumns = false;
            this.dgvPesoMoldes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesoMoldes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODPESOMOLDESPECASDataGridViewTextBoxColumn,
            this.dESCRICAOPESOMOLDESPECASDataGridViewTextBoxColumn,
            this.pESOMINIMOMOLDESPECASDataGridViewTextBoxColumn,
            this.pESOMAXIMOMOLDESPECASDataGridViewTextBoxColumn,
            this.pRECOMOLDESPECASDataGridViewTextBoxColumn});
            this.dgvPesoMoldes.DataMember = "PESO_MOLDES_PECAS";
            this.dgvPesoMoldes.DataSource = this.dsPesoMoldes;
            this.dgvPesoMoldes.Location = new System.Drawing.Point(596, 34);
            this.dgvPesoMoldes.Name = "dgvPesoMoldes";
            this.dgvPesoMoldes.Size = new System.Drawing.Size(174, 49);
            this.dgvPesoMoldes.TabIndex = 11;
            this.dgvPesoMoldes.Visible = false;
            // 
            // cODPESOMOLDESPECASDataGridViewTextBoxColumn
            // 
            this.cODPESOMOLDESPECASDataGridViewTextBoxColumn.DataPropertyName = "COD_PESO_MOLDES_PECAS";
            this.cODPESOMOLDESPECASDataGridViewTextBoxColumn.HeaderText = "COD_PESO_MOLDES_PECAS";
            this.cODPESOMOLDESPECASDataGridViewTextBoxColumn.Name = "cODPESOMOLDESPECASDataGridViewTextBoxColumn";
            this.cODPESOMOLDESPECASDataGridViewTextBoxColumn.Visible = false;
            // 
            // dESCRICAOPESOMOLDESPECASDataGridViewTextBoxColumn
            // 
            this.dESCRICAOPESOMOLDESPECASDataGridViewTextBoxColumn.DataPropertyName = "DESCRICAO_PESO_MOLDES_PECAS";
            this.dESCRICAOPESOMOLDESPECASDataGridViewTextBoxColumn.HeaderText = "DESCRICAO_PESO_MOLDES_PECAS";
            this.dESCRICAOPESOMOLDESPECASDataGridViewTextBoxColumn.Name = "dESCRICAOPESOMOLDESPECASDataGridViewTextBoxColumn";
            this.dESCRICAOPESOMOLDESPECASDataGridViewTextBoxColumn.Visible = false;
            // 
            // pESOMINIMOMOLDESPECASDataGridViewTextBoxColumn
            // 
            this.pESOMINIMOMOLDESPECASDataGridViewTextBoxColumn.DataPropertyName = "PESO_MINIMO_MOLDES_PECAS";
            this.pESOMINIMOMOLDESPECASDataGridViewTextBoxColumn.HeaderText = "PESO_MINIMO_MOLDES_PECAS";
            this.pESOMINIMOMOLDESPECASDataGridViewTextBoxColumn.Name = "pESOMINIMOMOLDESPECASDataGridViewTextBoxColumn";
            this.pESOMINIMOMOLDESPECASDataGridViewTextBoxColumn.Visible = false;
            // 
            // pESOMAXIMOMOLDESPECASDataGridViewTextBoxColumn
            // 
            this.pESOMAXIMOMOLDESPECASDataGridViewTextBoxColumn.DataPropertyName = "PESO_MAXIMO_MOLDES_PECAS";
            this.pESOMAXIMOMOLDESPECASDataGridViewTextBoxColumn.HeaderText = "PESO_MAXIMO_MOLDES_PECAS";
            this.pESOMAXIMOMOLDESPECASDataGridViewTextBoxColumn.Name = "pESOMAXIMOMOLDESPECASDataGridViewTextBoxColumn";
            this.pESOMAXIMOMOLDESPECASDataGridViewTextBoxColumn.Visible = false;
            // 
            // pRECOMOLDESPECASDataGridViewTextBoxColumn
            // 
            this.pRECOMOLDESPECASDataGridViewTextBoxColumn.DataPropertyName = "PRECO_MOLDES_PECAS";
            this.pRECOMOLDESPECASDataGridViewTextBoxColumn.HeaderText = "Preço";
            this.pRECOMOLDESPECASDataGridViewTextBoxColumn.Name = "pRECOMOLDESPECASDataGridViewTextBoxColumn";
            // 
            // dsPesoMoldes
            // 
            this.dsPesoMoldes.DataSetName = "dsPesoMoldes";
            this.dsPesoMoldes.Namespace = "http://www.tempuri.org/dsPesoMoldes.xsd";
            this.dsPesoMoldes.Tables.AddRange(new System.Data.DataTable[] {
            this.PESO_MOLDES_PECAS});
            // 
            // PESO_MOLDES_PECAS
            // 
            this.PESO_MOLDES_PECAS.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_PESO_MOLDES_PECAS,
            this.DESCRICAO_PESO_MOLDES_PECAS,
            this.PESO_MINIMO_MOLDES_PECAS,
            this.PESO_MAXIMO_MOLDES_PECAS,
            this.PRECO_MOLDES_PECAS});
            this.PESO_MOLDES_PECAS.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_PESO_MOLDES_PECAS"}, true)});
            this.PESO_MOLDES_PECAS.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_PESO_MOLDES_PECAS};
            this.PESO_MOLDES_PECAS.TableName = "PESO_MOLDES_PECAS";
            // 
            // COD_PESO_MOLDES_PECAS
            // 
            this.COD_PESO_MOLDES_PECAS.AllowDBNull = false;
            this.COD_PESO_MOLDES_PECAS.ColumnName = "COD_PESO_MOLDES_PECAS";
            this.COD_PESO_MOLDES_PECAS.DataType = typeof(int);
            // 
            // DESCRICAO_PESO_MOLDES_PECAS
            // 
            this.DESCRICAO_PESO_MOLDES_PECAS.ColumnName = "DESCRICAO_PESO_MOLDES_PECAS";
            this.DESCRICAO_PESO_MOLDES_PECAS.MaxLength = 200;
            // 
            // PESO_MINIMO_MOLDES_PECAS
            // 
            this.PESO_MINIMO_MOLDES_PECAS.ColumnName = "PESO_MINIMO_MOLDES_PECAS";
            this.PESO_MINIMO_MOLDES_PECAS.DataType = typeof(double);
            // 
            // PESO_MAXIMO_MOLDES_PECAS
            // 
            this.PESO_MAXIMO_MOLDES_PECAS.ColumnName = "PESO_MAXIMO_MOLDES_PECAS";
            this.PESO_MAXIMO_MOLDES_PECAS.DataType = typeof(double);
            // 
            // PRECO_MOLDES_PECAS
            // 
            this.PRECO_MOLDES_PECAS.ColumnName = "PRECO_MOLDES_PECAS";
            this.PRECO_MOLDES_PECAS.DataType = typeof(double);
            // 
            // datPesoMoldes
            // 
            this.datPesoMoldes.DeleteCommand = this.fbCommand16;
            this.datPesoMoldes.InsertCommand = this.fbCommand14;
            this.datPesoMoldes.SelectCommand = this.fbCommand13;
            this.datPesoMoldes.UpdateCommand = this.fbCommand15;
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
            this.fbCommand13.CommandText = "SELECT * FROM PESO_MOLDES_PECAS";
            this.fbCommand13.CommandTimeout = 30;
            this.fbCommand13.Connection = this.fbConnection1;
            // 
            // fbCommand15
            // 
            this.fbCommand15.CommandTimeout = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(485, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Porta molde";
            this.label1.Visible = false;
            // 
            // cbPesoMoldes
            // 
            this.cbPesoMoldes.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbPesoMoldes.QuotePrefix = "\"";
            this.cbPesoMoldes.QuoteSuffix = "\"";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "UN_VALOR_MP_PESO";
            // 
            // cODVALORMPPESODataGridViewTextBoxColumn
            // 
            this.cODVALORMPPESODataGridViewTextBoxColumn.DataPropertyName = "COD_VALOR_MP_PESO";
            this.cODVALORMPPESODataGridViewTextBoxColumn.HeaderText = "Cod.";
            this.cODVALORMPPESODataGridViewTextBoxColumn.Name = "cODVALORMPPESODataGridViewTextBoxColumn";
            this.cODVALORMPPESODataGridViewTextBoxColumn.Width = 50;
            // 
            // cODMPVALORMPPESODataGridViewTextBoxColumn
            // 
            this.cODMPVALORMPPESODataGridViewTextBoxColumn.DataPropertyName = "COD_MP_VALOR_MP_PESO";
            this.cODMPVALORMPPESODataGridViewTextBoxColumn.HeaderText = "COD_MP_VALOR_MP_PESO";
            this.cODMPVALORMPPESODataGridViewTextBoxColumn.Name = "cODMPVALORMPPESODataGridViewTextBoxColumn";
            this.cODMPVALORMPPESODataGridViewTextBoxColumn.Visible = false;
            // 
            // dESCRICAOVALORMPPESODataGridViewTextBoxColumn
            // 
            this.dESCRICAOVALORMPPESODataGridViewTextBoxColumn.DataPropertyName = "DESCRICAO_VALOR_MP_PESO";
            this.dESCRICAOVALORMPPESODataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.dESCRICAOVALORMPPESODataGridViewTextBoxColumn.Name = "dESCRICAOVALORMPPESODataGridViewTextBoxColumn";
            this.dESCRICAOVALORMPPESODataGridViewTextBoxColumn.Width = 125;
            // 
            // UN_VALOR_MP_PESO
            // 
            this.UN_VALOR_MP_PESO.DataPropertyName = "UN_VALOR_MP_PESO";
            this.UN_VALOR_MP_PESO.HeaderText = "Un";
            this.UN_VALOR_MP_PESO.Name = "UN_VALOR_MP_PESO";
            this.UN_VALOR_MP_PESO.Width = 50;
            // 
            // vALORVALORMPPESODataGridViewTextBoxColumn
            // 
            this.vALORVALORMPPESODataGridViewTextBoxColumn.DataPropertyName = "VALOR_VALOR_MP_PESO";
            this.vALORVALORMPPESODataGridViewTextBoxColumn.HeaderText = "Valor";
            this.vALORVALORMPPESODataGridViewTextBoxColumn.Name = "vALORVALORMPPESODataGridViewTextBoxColumn";
            this.vALORVALORMPPESODataGridViewTextBoxColumn.Width = 75;
            // 
            // form_operacoes_peso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 547);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPesoMoldes);
            this.Controls.Add(this.dgvOutrosServicosPeso);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dgvMateriaPrimaPeso);
            this.Controls.Add(this.tb_cod_peso);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.dgvOperacoesPeso);
            this.Controls.Add(this.tb_peso);
            this.Controls.Add(this.button1);
            this.Name = "form_operacoes_peso";
            this.Text = "Operações por Peso";
            this.Load += new System.EventHandler(this.form_operacoes_peso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperacoesPeso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOperacoesPeso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VALOR_OPERACAO_PESO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriaPrimaPeso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMateriaPrimaPeso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VALOR_MATERIA_PRIMA_PESO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutrosServicosPeso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOutrosServicosPeso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VALOR_OUTROS_SERVICOS_PESO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesoMoldes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPesoMoldes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PESO_MOLDES_PECAS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_peso;
        private System.Windows.Forms.DataGridView dgvOperacoesPeso;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button2;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datOperacoesPeso;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private System.Data.DataSet dsOperacoesPeso;
        private System.Data.DataTable VALOR_OPERACAO_PESO;
        private System.Data.DataColumn COD_VALOR_OPERACAO_PESO;
        private System.Data.DataColumn OPERACAO_VALOR_OPERACAO_PESO;
        private System.Data.DataColumn VALOR_VALOR_OPERACAO_PESO;
        private System.Data.DataColumn SEQUENCIA_VALOR_OPERACAO_PESO;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbOperacoesPeso;
        private System.Windows.Forms.TextBox tb_cod_peso;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODVALOROPERACAOPESODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPERACAOVALOROPERACAOPESODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEQUENCIAVALOROPERACAOPESODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORA_VALOR_OPERACAO_PESO;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_PESO_OPERACAO_PESO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRICAO_PESO_OPERACAO_PESO;
        private System.Windows.Forms.DataGridView dgvMateriaPrimaPeso;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dgvOutrosServicosPeso;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datMateriaPrimaPeso;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand8;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand6;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand5;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand7;
        private System.Data.DataSet dsMateriaPrimaPeso;
        private System.Data.DataTable VALOR_MATERIA_PRIMA_PESO;
        private System.Data.DataColumn COD_VALOR_MP_PESO;
        private System.Data.DataColumn COD_MP_VALOR_MP_PESO;
        private System.Data.DataColumn DESCRICAO_VALOR_MP_PESO;
        private System.Data.DataColumn VALOR_VALOR_MP_PESO;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbMateriaPrimaPeso;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datOutrosServicosPeso;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand12;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand10;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand9;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand11;
        private System.Data.DataSet dsOutrosServicosPeso;
        private System.Data.DataTable VALOR_OUTROS_SERVICOS_PESO;
        private System.Data.DataColumn COD_OUTROS_SERV_PESO;
        private System.Data.DataColumn COD_OUTROS_OUTROS_SERV_PESO;
        private System.Data.DataColumn DESCRICAO_OUTROS_SERV_PESO;
        private System.Data.DataColumn VALOR_OUTROS_SERV_PESO;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbOutrosServicosPeso;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODOUTROSSERVPESODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODOUTROSOUTROSSERVPESODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRICAOOUTROSSERVPESODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALOROUTROSSERVPESODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvPesoMoldes;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODPESOMOLDESPECASDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRICAOPESOMOLDESPECASDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pESOMINIMOMOLDESPECASDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pESOMAXIMOMOLDESPECASDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRECOMOLDESPECASDataGridViewTextBoxColumn;
        private System.Data.DataSet dsPesoMoldes;
        private System.Data.DataTable PESO_MOLDES_PECAS;
        private System.Data.DataColumn COD_PESO_MOLDES_PECAS;
        private System.Data.DataColumn DESCRICAO_PESO_MOLDES_PECAS;
        private System.Data.DataColumn PESO_MINIMO_MOLDES_PECAS;
        private System.Data.DataColumn PESO_MAXIMO_MOLDES_PECAS;
        private System.Data.DataColumn PRECO_MOLDES_PECAS;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datPesoMoldes;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand16;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand14;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand13;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand15;
        private System.Windows.Forms.Label label1;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbPesoMoldes;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODVALORMPPESODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODMPVALORMPPESODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRICAOVALORMPPESODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UN_VALOR_MP_PESO;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORVALORMPPESODataGridViewTextBoxColumn;
        private System.Data.DataColumn dataColumn3;
    }
}