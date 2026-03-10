namespace Evolucao
{
    partial class form_lote_novo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_lote_novo));
            this.datLote_recebimento = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsLote_recebimento = new System.Data.DataSet();
            this.LOTE_RECEBIMENTO = new System.Data.DataTable();
            this.COD_LR = new System.Data.DataColumn();
            this.COD_PRODUTO_LR = new System.Data.DataColumn();
            this.DESCRICAO_LR = new System.Data.DataColumn();
            this.DIMENSOES_LR = new System.Data.DataColumn();
            this.MATERIAL_LR = new System.Data.DataColumn();
            this.CLIENTE_LR = new System.Data.DataColumn();
            this.CNPJ_CLIENTE_LR = new System.Data.DataColumn();
            this.RASTREAMENTO_LR = new System.Data.DataColumn();
            this.QTDE_LR = new System.Data.DataColumn();
            this.DATA_LIBERACAO_LR = new System.Data.DataColumn();
            this.NOTA_FISCAL_LR = new System.Data.DataColumn();
            this.LOCALIDADE_LR = new System.Data.DataColumn();
            this.STATUS_LR = new System.Data.DataColumn();
            this.OPERADOR_CONTROLE_LR = new System.Data.DataColumn();
            this.CERTIFICADO_CONTROLE_LR = new System.Data.DataColumn();
            this.DATA_CONTROLE_LR = new System.Data.DataColumn();
            this.FINALIZADO_CONTROLE_LR = new System.Data.DataColumn();
            this.cbLote_recebimento = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.datPalete_lote = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand8 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand6 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand5 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand7 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsPalete_lote = new System.Data.DataSet();
            this.PALETE_LOTE = new System.Data.DataTable();
            this.LOTE_PALETE_LOTE = new System.Data.DataColumn();
            this.N_PALETE_LOTE = new System.Data.DataColumn();
            this.QTD_PALETE_LOTE = new System.Data.DataColumn();
            this.dataColumn1 = new System.Data.DataColumn();
            this.cbPalete_lote = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_nf = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_data = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_qtde = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_rastreamento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbcod_estoque = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_cod_lote = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvPaletes = new System.Windows.Forms.DataGridView();
            this.col_palete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_qtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_lote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RASTREIO_LOTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.tb_caminho = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label16 = new System.Windows.Forms.Label();
            this.tb_conferente = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dsLote_recebimento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LOTE_RECEBIMENTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPalete_lote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PALETE_LOTE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaletes)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // datLote_recebimento
            // 
            this.datLote_recebimento.DeleteCommand = this.fbCommand4;
            this.datLote_recebimento.InsertCommand = this.fbCommand2;
            this.datLote_recebimento.SelectCommand = this.fbCommand1;
            this.datLote_recebimento.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * from lote_recebimento";
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
            // dsLote_recebimento
            // 
            this.dsLote_recebimento.DataSetName = "dsLote_recebimento";
            this.dsLote_recebimento.Namespace = "http://www.tempuri.org/dsLote_recebimento.xsd";
            this.dsLote_recebimento.Tables.AddRange(new System.Data.DataTable[] {
            this.LOTE_RECEBIMENTO});
            // 
            // LOTE_RECEBIMENTO
            // 
            this.LOTE_RECEBIMENTO.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_LR,
            this.COD_PRODUTO_LR,
            this.DESCRICAO_LR,
            this.DIMENSOES_LR,
            this.MATERIAL_LR,
            this.CLIENTE_LR,
            this.CNPJ_CLIENTE_LR,
            this.RASTREAMENTO_LR,
            this.QTDE_LR,
            this.DATA_LIBERACAO_LR,
            this.NOTA_FISCAL_LR,
            this.LOCALIDADE_LR,
            this.STATUS_LR,
            this.OPERADOR_CONTROLE_LR,
            this.CERTIFICADO_CONTROLE_LR,
            this.DATA_CONTROLE_LR,
            this.FINALIZADO_CONTROLE_LR});
            this.LOTE_RECEBIMENTO.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_LR"}, true)});
            this.LOTE_RECEBIMENTO.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_LR};
            this.LOTE_RECEBIMENTO.TableName = "LOTE_RECEBIMENTO";
            // 
            // COD_LR
            // 
            this.COD_LR.AllowDBNull = false;
            this.COD_LR.ColumnName = "COD_LR";
            this.COD_LR.DataType = typeof(int);
            // 
            // COD_PRODUTO_LR
            // 
            this.COD_PRODUTO_LR.ColumnName = "COD_PRODUTO_LR";
            this.COD_PRODUTO_LR.DataType = typeof(int);
            // 
            // DESCRICAO_LR
            // 
            this.DESCRICAO_LR.ColumnName = "DESCRICAO_LR";
            this.DESCRICAO_LR.MaxLength = 200;
            // 
            // DIMENSOES_LR
            // 
            this.DIMENSOES_LR.ColumnName = "DIMENSOES_LR";
            this.DIMENSOES_LR.MaxLength = 100;
            // 
            // MATERIAL_LR
            // 
            this.MATERIAL_LR.ColumnName = "MATERIAL_LR";
            this.MATERIAL_LR.MaxLength = 100;
            // 
            // CLIENTE_LR
            // 
            this.CLIENTE_LR.ColumnName = "CLIENTE_LR";
            this.CLIENTE_LR.MaxLength = 200;
            // 
            // CNPJ_CLIENTE_LR
            // 
            this.CNPJ_CLIENTE_LR.ColumnName = "CNPJ_CLIENTE_LR";
            this.CNPJ_CLIENTE_LR.MaxLength = 100;
            // 
            // RASTREAMENTO_LR
            // 
            this.RASTREAMENTO_LR.ColumnName = "RASTREAMENTO_LR";
            this.RASTREAMENTO_LR.MaxLength = 100;
            // 
            // QTDE_LR
            // 
            this.QTDE_LR.ColumnName = "QTDE_LR";
            this.QTDE_LR.DataType = typeof(double);
            // 
            // DATA_LIBERACAO_LR
            // 
            this.DATA_LIBERACAO_LR.ColumnName = "DATA_LIBERACAO_LR";
            this.DATA_LIBERACAO_LR.DataType = typeof(System.DateTime);
            // 
            // NOTA_FISCAL_LR
            // 
            this.NOTA_FISCAL_LR.ColumnName = "NOTA_FISCAL_LR";
            this.NOTA_FISCAL_LR.MaxLength = 20;
            // 
            // LOCALIDADE_LR
            // 
            this.LOCALIDADE_LR.ColumnName = "LOCALIDADE_LR";
            this.LOCALIDADE_LR.MaxLength = 100;
            // 
            // STATUS_LR
            // 
            this.STATUS_LR.ColumnName = "STATUS_LR";
            this.STATUS_LR.MaxLength = 100;
            // 
            // OPERADOR_CONTROLE_LR
            // 
            this.OPERADOR_CONTROLE_LR.ColumnName = "OPERADOR_CONTROLE_LR";
            this.OPERADOR_CONTROLE_LR.MaxLength = 100;
            // 
            // CERTIFICADO_CONTROLE_LR
            // 
            this.CERTIFICADO_CONTROLE_LR.ColumnName = "CERTIFICADO_CONTROLE_LR";
            this.CERTIFICADO_CONTROLE_LR.MaxLength = 100;
            // 
            // DATA_CONTROLE_LR
            // 
            this.DATA_CONTROLE_LR.ColumnName = "DATA_CONTROLE_LR";
            this.DATA_CONTROLE_LR.DataType = typeof(System.DateTime);
            // 
            // FINALIZADO_CONTROLE_LR
            // 
            this.FINALIZADO_CONTROLE_LR.ColumnName = "FINALIZADO_CONTROLE_LR";
            this.FINALIZADO_CONTROLE_LR.DataType = typeof(int);
            // 
            // cbLote_recebimento
            // 
            this.cbLote_recebimento.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbLote_recebimento.DataAdapter = this.datLote_recebimento;
            this.cbLote_recebimento.QuotePrefix = "\"";
            this.cbLote_recebimento.QuoteSuffix = "\"";
            // 
            // datPalete_lote
            // 
            this.datPalete_lote.DeleteCommand = this.fbCommand8;
            this.datPalete_lote.InsertCommand = this.fbCommand6;
            this.datPalete_lote.SelectCommand = this.fbCommand5;
            this.datPalete_lote.UpdateCommand = this.fbCommand7;
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
            this.fbCommand5.CommandText = "select * from palete_lote";
            this.fbCommand5.CommandTimeout = 30;
            this.fbCommand5.Connection = this.fbConnection1;
            // 
            // fbCommand7
            // 
            this.fbCommand7.CommandTimeout = 30;
            // 
            // dsPalete_lote
            // 
            this.dsPalete_lote.DataSetName = "dsPalete_lote";
            this.dsPalete_lote.Namespace = "http://www.tempuri.org/dsPalete_lote.xsd";
            this.dsPalete_lote.Tables.AddRange(new System.Data.DataTable[] {
            this.PALETE_LOTE});
            // 
            // PALETE_LOTE
            // 
            this.PALETE_LOTE.Columns.AddRange(new System.Data.DataColumn[] {
            this.LOTE_PALETE_LOTE,
            this.N_PALETE_LOTE,
            this.QTD_PALETE_LOTE,
            this.dataColumn1});
            this.PALETE_LOTE.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "LOTE_PALETE_LOTE",
                        "N_PALETE_LOTE"}, true)});
            this.PALETE_LOTE.PrimaryKey = new System.Data.DataColumn[] {
        this.LOTE_PALETE_LOTE,
        this.N_PALETE_LOTE};
            this.PALETE_LOTE.TableName = "PALETE_LOTE";
            // 
            // LOTE_PALETE_LOTE
            // 
            this.LOTE_PALETE_LOTE.AllowDBNull = false;
            this.LOTE_PALETE_LOTE.ColumnName = "LOTE_PALETE_LOTE";
            this.LOTE_PALETE_LOTE.DataType = typeof(int);
            // 
            // N_PALETE_LOTE
            // 
            this.N_PALETE_LOTE.AllowDBNull = false;
            this.N_PALETE_LOTE.ColumnName = "N_PALETE_LOTE";
            this.N_PALETE_LOTE.DataType = typeof(int);
            // 
            // QTD_PALETE_LOTE
            // 
            this.QTD_PALETE_LOTE.AllowDBNull = false;
            this.QTD_PALETE_LOTE.ColumnName = "QTD_PALETE_LOTE";
            this.QTD_PALETE_LOTE.DataType = typeof(double);
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "RASTREIO_LOTE";
            this.dataColumn1.MaxLength = 100;
            // 
            // cbPalete_lote
            // 
            this.cbPalete_lote.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbPalete_lote.DataAdapter = this.datPalete_lote;
            this.cbPalete_lote.QuotePrefix = "\"";
            this.cbPalete_lote.QuoteSuffix = "\"";
            // 
            // txtStatus
            // 
            this.txtStatus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsLote_recebimento, "LOTE_RECEBIMENTO.STATUS_LR", true));
            this.txtStatus.Location = new System.Drawing.Point(271, 275);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(119, 20);
            this.txtStatus.TabIndex = 57;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(225, 278);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 13);
            this.label14.TabIndex = 56;
            this.label14.Text = "Status:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(231, 226);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 55;
            this.label12.Text = "Localidade:";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsLote_recebimento, "LOTE_RECEBIMENTO.LOCALIDADE_LR", true));
            this.textBox1.Location = new System.Drawing.Point(297, 223);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(93, 20);
            this.textBox1.TabIndex = 54;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 278);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 53;
            this.label11.Text = "Nota Fiscal:";
            // 
            // tb_nf
            // 
            this.tb_nf.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsLote_recebimento, "LOTE_RECEBIMENTO.NOTA_FISCAL_LR", true));
            this.tb_nf.Location = new System.Drawing.Point(126, 275);
            this.tb_nf.Name = "tb_nf";
            this.tb_nf.ReadOnly = true;
            this.tb_nf.Size = new System.Drawing.Size(93, 20);
            this.tb_nf.TabIndex = 52;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 252);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 51;
            this.label10.Text = "Data Liberação:";
            // 
            // tb_data
            // 
            this.tb_data.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsLote_recebimento, "LOTE_RECEBIMENTO.DATA_LIBERACAO_LR", true));
            this.tb_data.Location = new System.Drawing.Point(126, 249);
            this.tb_data.Name = "tb_data";
            this.tb_data.ReadOnly = true;
            this.tb_data.Size = new System.Drawing.Size(93, 20);
            this.tb_data.TabIndex = 50;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 49;
            this.label9.Text = "Qtde:";
            // 
            // tb_qtde
            // 
            this.tb_qtde.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsLote_recebimento, "LOTE_RECEBIMENTO.QTDE_LR", true));
            this.tb_qtde.Location = new System.Drawing.Point(126, 223);
            this.tb_qtde.Name = "tb_qtde";
            this.tb_qtde.ReadOnly = true;
            this.tb_qtde.Size = new System.Drawing.Size(93, 20);
            this.tb_qtde.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "Rastreamento:";
            // 
            // tb_rastreamento
            // 
            this.tb_rastreamento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsLote_recebimento, "LOTE_RECEBIMENTO.RASTREAMENTO_LR", true));
            this.tb_rastreamento.Location = new System.Drawing.Point(126, 197);
            this.tb_rastreamento.Name = "tb_rastreamento";
            this.tb_rastreamento.Size = new System.Drawing.Size(152, 20);
            this.tb_rastreamento.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Nome Cliente:";
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsLote_recebimento, "LOTE_RECEBIMENTO.CLIENTE_LR", true));
            this.textBox7.Location = new System.Drawing.Point(126, 171);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(264, 20);
            this.textBox7.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "CNPJ Cliente:";
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsLote_recebimento, "LOTE_RECEBIMENTO.CNPJ_CLIENTE_LR", true));
            this.textBox6.Location = new System.Drawing.Point(126, 145);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(152, 20);
            this.textBox6.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Material:";
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsLote_recebimento, "LOTE_RECEBIMENTO.MATERIAL_LR", true));
            this.textBox5.Location = new System.Drawing.Point(126, 119);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(152, 20);
            this.textBox5.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Dimensões:";
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsLote_recebimento, "LOTE_RECEBIMENTO.DIMENSOES_LR", true));
            this.textBox4.Location = new System.Drawing.Point(126, 93);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(152, 20);
            this.textBox4.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Descrição:";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsLote_recebimento, "LOTE_RECEBIMENTO.DESCRICAO_LR", true));
            this.textBox3.Location = new System.Drawing.Point(126, 67);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(264, 20);
            this.textBox3.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Cód. Matéria Prima:";
            // 
            // tbcod_estoque
            // 
            this.tbcod_estoque.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsLote_recebimento, "LOTE_RECEBIMENTO.COD_PRODUTO_LR", true));
            this.tbcod_estoque.Location = new System.Drawing.Point(126, 41);
            this.tbcod_estoque.Name = "tbcod_estoque";
            this.tbcod_estoque.ReadOnly = true;
            this.tbcod_estoque.Size = new System.Drawing.Size(152, 20);
            this.tbcod_estoque.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Cód. Lote:";
            // 
            // tb_cod_lote
            // 
            this.tb_cod_lote.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsLote_recebimento, "LOTE_RECEBIMENTO.COD_LR", true));
            this.tb_cod_lote.Location = new System.Drawing.Point(126, 15);
            this.tb_cod_lote.Name = "tb_cod_lote";
            this.tb_cod_lote.ReadOnly = true;
            this.tb_cod_lote.Size = new System.Drawing.Size(52, 20);
            this.tb_cod_lote.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 59;
            this.label13.Text = "Paletes";
            // 
            // dgvPaletes
            // 
            this.dgvPaletes.AutoGenerateColumns = false;
            this.dgvPaletes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaletes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_palete,
            this.col_qtde,
            this.col_lote,
            this.RASTREIO_LOTE});
            this.dgvPaletes.DataMember = "PALETE_LOTE";
            this.dgvPaletes.DataSource = this.dsPalete_lote;
            this.dgvPaletes.Location = new System.Drawing.Point(10, 33);
            this.dgvPaletes.Name = "dgvPaletes";
            this.dgvPaletes.RowHeadersWidth = 20;
            this.dgvPaletes.Size = new System.Drawing.Size(287, 150);
            this.dgvPaletes.TabIndex = 58;
            this.dgvPaletes.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvPaletes_RowsAdded);
            // 
            // col_palete
            // 
            this.col_palete.DataPropertyName = "N_PALETE_LOTE";
            this.col_palete.HeaderText = "Palete";
            this.col_palete.Name = "col_palete";
            this.col_palete.Width = 50;
            // 
            // col_qtde
            // 
            this.col_qtde.DataPropertyName = "QTD_PALETE_LOTE";
            this.col_qtde.HeaderText = "Qtd";
            this.col_qtde.Name = "col_qtde";
            this.col_qtde.Width = 50;
            // 
            // col_lote
            // 
            this.col_lote.DataPropertyName = "LOTE_PALETE_LOTE";
            this.col_lote.HeaderText = "Lote";
            this.col_lote.Name = "col_lote";
            this.col_lote.Width = 50;
            // 
            // RASTREIO_LOTE
            // 
            this.RASTREIO_LOTE.DataPropertyName = "RASTREIO_LOTE";
            this.RASTREIO_LOTE.HeaderText = "Rastreio";
            this.RASTREIO_LOTE.Name = "RASTREIO_LOTE";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(188, 301);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(64, 23);
            this.button4.TabIndex = 63;
            this.button4.Text = "Aprovar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(419, 301);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 62;
            this.button3.Text = "Controle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(107, 301);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 61;
            this.button2.Text = "Excluir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 60;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(145, 198);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(29, 23);
            this.button5.TabIndex = 68;
            this.button5.Text = "+";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 203);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 13);
            this.label15.TabIndex = 67;
            this.label15.Text = "Caminho Certificado:";
            // 
            // tb_caminho
            // 
            this.tb_caminho.Location = new System.Drawing.Point(10, 224);
            this.tb_caminho.Name = "tb_caminho";
            this.tb_caminho.Size = new System.Drawing.Size(164, 20);
            this.tb_caminho.TabIndex = 66;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.tb_caminho);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.dgvPaletes);
            this.panel1.Location = new System.Drawing.Point(409, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 272);
            this.panel1.TabIndex = 69;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(228, 252);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 13);
            this.label16.TabIndex = 72;
            this.label16.Text = "Conferente:";
            // 
            // tb_conferente
            // 
            this.tb_conferente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsLote_recebimento, "LOTE_RECEBIMENTO.OPERADOR_CONTROLE_LR", true));
            this.tb_conferente.Location = new System.Drawing.Point(297, 249);
            this.tb_conferente.Name = "tb_conferente";
            this.tb_conferente.ReadOnly = true;
            this.tb_conferente.Size = new System.Drawing.Size(93, 20);
            this.tb_conferente.TabIndex = 71;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(258, 301);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(64, 23);
            this.button7.TabIndex = 73;
            this.button7.Text = "Reprovar";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(500, 301);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(102, 23);
            this.button6.TabIndex = 70;
            this.button6.Text = "Imprimir Controle";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // form_lote_novo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 337);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.tb_conferente);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tb_nf);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_data);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_qtde);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_rastreamento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbcod_estoque);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_cod_lote);
            this.Name = "form_lote_novo";
            this.Text = "Lote";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_lote_novo_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.form_lote_novo_FormClosed);
            this.Load += new System.EventHandler(this.form_lote_novo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsLote_recebimento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LOTE_RECEBIMENTO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPalete_lote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PALETE_LOTE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaletes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datLote_recebimento;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Data.DataSet dsLote_recebimento;
        private System.Data.DataTable LOTE_RECEBIMENTO;
        private System.Data.DataColumn COD_LR;
        private System.Data.DataColumn COD_PRODUTO_LR;
        private System.Data.DataColumn DESCRICAO_LR;
        private System.Data.DataColumn DIMENSOES_LR;
        private System.Data.DataColumn MATERIAL_LR;
        private System.Data.DataColumn CLIENTE_LR;
        private System.Data.DataColumn CNPJ_CLIENTE_LR;
        private System.Data.DataColumn RASTREAMENTO_LR;
        private System.Data.DataColumn QTDE_LR;
        private System.Data.DataColumn DATA_LIBERACAO_LR;
        private System.Data.DataColumn NOTA_FISCAL_LR;
        private System.Data.DataColumn LOCALIDADE_LR;
        private System.Data.DataColumn STATUS_LR;
        private System.Data.DataColumn OPERADOR_CONTROLE_LR;
        private System.Data.DataColumn CERTIFICADO_CONTROLE_LR;
        private System.Data.DataColumn DATA_CONTROLE_LR;
        private System.Data.DataColumn FINALIZADO_CONTROLE_LR;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbLote_recebimento;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datPalete_lote;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand8;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand6;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand5;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand7;
        private System.Data.DataSet dsPalete_lote;
        private System.Data.DataTable PALETE_LOTE;
        private System.Data.DataColumn LOTE_PALETE_LOTE;
        private System.Data.DataColumn N_PALETE_LOTE;
        private System.Data.DataColumn QTD_PALETE_LOTE;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbPalete_lote;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_nf;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_data;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_qtde;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_rastreamento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbcod_estoque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_cod_lote;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvPaletes;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tb_caminho;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Data.DataColumn dataColumn1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tb_conferente;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_palete;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_qtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_lote;
        private System.Windows.Forms.DataGridViewTextBoxColumn RASTREIO_LOTE;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
    }
}