namespace Evolucao
{
    partial class form_operacoes_caixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_operacoes_caixa));
            this.label1 = new System.Windows.Forms.Label();
            this.rb_Debito = new System.Windows.Forms.RadioButton();
            this.dsCaixa = new System.Data.DataSet();
            this.CAIXA = new System.Data.DataTable();
            this.COD_CAIXA = new System.Data.DataColumn();
            this.DESCRICAO_CAIXA = new System.Data.DataColumn();
            this.CC_CAIXA = new System.Data.DataColumn();
            this.COD_CP_CR_CAIXA = new System.Data.DataColumn();
            this.DESCRICAO_CC_CAIXA = new System.Data.DataColumn();
            this.VALOR_CAIXA = new System.Data.DataColumn();
            this.DATA_CAIXA = new System.Data.DataColumn();
            this.COD_EXTRATO_CAIXA = new System.Data.DataColumn();
            this.COD_FORN_CLI_CAIXA = new System.Data.DataColumn();
            this.RAZAO_CLI_FORN_CAIXA = new System.Data.DataColumn();
            this.DUPLICATA_CAIXA = new System.Data.DataColumn();
            this.NF_CAIXA = new System.Data.DataColumn();
            this.PLANO_CAIXA = new System.Data.DataColumn();
            this.CARTEIRA_CAIXA = new System.Data.DataColumn();
            this.DEBITO_CAIXA = new System.Data.DataColumn();
            this.CREDITO_CAIXA = new System.Data.DataColumn();
            this.rb_Credito = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.tb_carteira = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_nf = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_duplicata = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_nome_forn = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_cod_forn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_data = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_valor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_descricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_cod = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_cr_cp = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.datCaixa = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.cbCaixa = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.datContas_a_pagar = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand8 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand6 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand5 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand7 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsContas_a_pagar = new System.Data.DataSet();
            this.CONTAS_A_PAGAR = new System.Data.DataTable();
            this.COD_CP = new System.Data.DataColumn();
            this.VALOR_CP = new System.Data.DataColumn();
            this.DATA_PREVISTA_CP = new System.Data.DataColumn();
            this.DATA_PAGAMENTO_CP = new System.Data.DataColumn();
            this.COD_FORNECEDOR_CP = new System.Data.DataColumn();
            this.RAZAO_FORNECEDOR_CP = new System.Data.DataColumn();
            this.DESCRICAO_CP = new System.Data.DataColumn();
            this.DUPLICATA_CP = new System.Data.DataColumn();
            this.PLANO_CP = new System.Data.DataColumn();
            this.PAGO_CP = new System.Data.DataColumn();
            this.NF_CP = new System.Data.DataColumn();
            this.COD_CAIXA_CP = new System.Data.DataColumn();
            this.CARTEIRA_CP = new System.Data.DataColumn();
            this.datContas_a_receber = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand12 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand10 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand9 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand11 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsContas_a_receber = new System.Data.DataSet();
            this.CONTAS_A_RECEBER = new System.Data.DataTable();
            this.COD_CR = new System.Data.DataColumn();
            this.VALOR_CR = new System.Data.DataColumn();
            this.DATA_PREVISTA_CR = new System.Data.DataColumn();
            this.DATA_RECEBIMENTO_CR = new System.Data.DataColumn();
            this.COD_CLIENTE_CR = new System.Data.DataColumn();
            this.RAZAO_CLIENTE_CR = new System.Data.DataColumn();
            this.DESCRICAO_CR = new System.Data.DataColumn();
            this.DUPLICATA_CR = new System.Data.DataColumn();
            this.NF_CR = new System.Data.DataColumn();
            this.RECEBIDO_CR = new System.Data.DataColumn();
            this.COD_CAIXA_CR = new System.Data.DataColumn();
            this.PLANO_CR = new System.Data.DataColumn();
            this.CARTEIRA_CR = new System.Data.DataColumn();
            this.tb_cod_cc = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.tb_descricao_cc = new System.Windows.Forms.TextBox();
            this.comando_select = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.datClientes = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand16 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand14 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand13 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand15 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.datForn = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand20 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand18 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand17 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand19 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_cod_plano = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_planos = new System.Windows.Forms.TextBox();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dsCaixa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CAIXA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsContas_a_pagar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CONTAS_A_PAGAR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsContas_a_receber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CONTAS_A_RECEBER)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(166, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 31);
            this.label1.TabIndex = 52;
            this.label1.Text = "CAIXA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rb_Debito
            // 
            this.rb_Debito.AutoSize = true;
            this.rb_Debito.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsCaixa, "CAIXA.DEBITO_CAIXA", true));
            this.rb_Debito.Location = new System.Drawing.Point(172, 66);
            this.rb_Debito.Name = "rb_Debito";
            this.rb_Debito.Size = new System.Drawing.Size(56, 17);
            this.rb_Debito.TabIndex = 1;
            this.rb_Debito.TabStop = true;
            this.rb_Debito.Text = "Débito";
            this.rb_Debito.UseVisualStyleBackColor = true;
            // 
            // dsCaixa
            // 
            this.dsCaixa.DataSetName = "dsCaixa";
            this.dsCaixa.Namespace = "http://www.tempuri.org/dsCaixa.xsd";
            this.dsCaixa.Tables.AddRange(new System.Data.DataTable[] {
            this.CAIXA});
            // 
            // CAIXA
            // 
            this.CAIXA.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_CAIXA,
            this.DESCRICAO_CAIXA,
            this.CC_CAIXA,
            this.COD_CP_CR_CAIXA,
            this.DESCRICAO_CC_CAIXA,
            this.VALOR_CAIXA,
            this.DATA_CAIXA,
            this.COD_EXTRATO_CAIXA,
            this.COD_FORN_CLI_CAIXA,
            this.RAZAO_CLI_FORN_CAIXA,
            this.DUPLICATA_CAIXA,
            this.NF_CAIXA,
            this.PLANO_CAIXA,
            this.CARTEIRA_CAIXA,
            this.DEBITO_CAIXA,
            this.CREDITO_CAIXA,
            this.dataColumn1});
            this.CAIXA.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_CAIXA"}, true)});
            this.CAIXA.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_CAIXA};
            this.CAIXA.TableName = "CAIXA";
            // 
            // COD_CAIXA
            // 
            this.COD_CAIXA.AllowDBNull = false;
            this.COD_CAIXA.ColumnName = "COD_CAIXA";
            this.COD_CAIXA.DataType = typeof(int);
            // 
            // DESCRICAO_CAIXA
            // 
            this.DESCRICAO_CAIXA.ColumnName = "DESCRICAO_CAIXA";
            this.DESCRICAO_CAIXA.MaxLength = 200;
            // 
            // CC_CAIXA
            // 
            this.CC_CAIXA.ColumnName = "CC_CAIXA";
            this.CC_CAIXA.DataType = typeof(int);
            // 
            // COD_CP_CR_CAIXA
            // 
            this.COD_CP_CR_CAIXA.ColumnName = "COD_CP_CR_CAIXA";
            this.COD_CP_CR_CAIXA.DataType = typeof(int);
            // 
            // DESCRICAO_CC_CAIXA
            // 
            this.DESCRICAO_CC_CAIXA.ColumnName = "DESCRICAO_CC_CAIXA";
            this.DESCRICAO_CC_CAIXA.MaxLength = 200;
            // 
            // VALOR_CAIXA
            // 
            this.VALOR_CAIXA.ColumnName = "VALOR_CAIXA";
            this.VALOR_CAIXA.DataType = typeof(double);
            // 
            // DATA_CAIXA
            // 
            this.DATA_CAIXA.ColumnName = "DATA_CAIXA";
            this.DATA_CAIXA.DataType = typeof(System.DateTime);
            // 
            // COD_EXTRATO_CAIXA
            // 
            this.COD_EXTRATO_CAIXA.ColumnName = "COD_EXTRATO_CAIXA";
            this.COD_EXTRATO_CAIXA.DataType = typeof(int);
            // 
            // COD_FORN_CLI_CAIXA
            // 
            this.COD_FORN_CLI_CAIXA.ColumnName = "COD_FORN_CLI_CAIXA";
            this.COD_FORN_CLI_CAIXA.DataType = typeof(int);
            // 
            // RAZAO_CLI_FORN_CAIXA
            // 
            this.RAZAO_CLI_FORN_CAIXA.ColumnName = "RAZAO_CLI_FORN_CAIXA";
            this.RAZAO_CLI_FORN_CAIXA.MaxLength = 200;
            // 
            // DUPLICATA_CAIXA
            // 
            this.DUPLICATA_CAIXA.ColumnName = "DUPLICATA_CAIXA";
            this.DUPLICATA_CAIXA.MaxLength = 30;
            // 
            // NF_CAIXA
            // 
            this.NF_CAIXA.ColumnName = "NF_CAIXA";
            this.NF_CAIXA.MaxLength = 40;
            // 
            // PLANO_CAIXA
            // 
            this.PLANO_CAIXA.ColumnName = "PLANO_CAIXA";
            this.PLANO_CAIXA.MaxLength = 100;
            // 
            // CARTEIRA_CAIXA
            // 
            this.CARTEIRA_CAIXA.ColumnName = "CARTEIRA_CAIXA";
            this.CARTEIRA_CAIXA.MaxLength = 100;
            // 
            // DEBITO_CAIXA
            // 
            this.DEBITO_CAIXA.ColumnName = "DEBITO_CAIXA";
            this.DEBITO_CAIXA.DataType = typeof(int);
            // 
            // CREDITO_CAIXA
            // 
            this.CREDITO_CAIXA.ColumnName = "CREDITO_CAIXA";
            this.CREDITO_CAIXA.DataType = typeof(int);
            // 
            // rb_Credito
            // 
            this.rb_Credito.AutoSize = true;
            this.rb_Credito.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsCaixa, "CAIXA.CREDITO_CAIXA", true));
            this.rb_Credito.Location = new System.Drawing.Point(234, 66);
            this.rb_Credito.Name = "rb_Credito";
            this.rb_Credito.Size = new System.Drawing.Size(58, 17);
            this.rb_Credito.TabIndex = 2;
            this.rb_Credito.TabStop = true;
            this.rb_Credito.Text = "Crédito";
            this.rb_Credito.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 302);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 80;
            this.label13.Text = "Carteira:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(188, 297);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(25, 23);
            this.button4.TabIndex = 19;
            this.button4.Text = "+";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tb_carteira
            // 
            this.tb_carteira.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsCaixa, "CAIXA.CARTEIRA_CAIXA", true));
            this.tb_carteira.Location = new System.Drawing.Point(83, 299);
            this.tb_carteira.Name = "tb_carteira";
            this.tb_carteira.Size = new System.Drawing.Size(104, 20);
            this.tb_carteira.TabIndex = 18;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(378, 220);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(142, 251);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 78;
            this.label10.Text = "NF:";
            // 
            // tb_nf
            // 
            this.tb_nf.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsCaixa, "CAIXA.NF_CAIXA", true));
            this.tb_nf.Location = new System.Drawing.Point(172, 248);
            this.tb_nf.Name = "tb_nf";
            this.tb_nf.Size = new System.Drawing.Size(62, 20);
            this.tb_nf.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 251);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 77;
            this.label11.Text = "Duplicata:";
            // 
            // tb_duplicata
            // 
            this.tb_duplicata.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsCaixa, "CAIXA.DUPLICATA_CAIXA", true));
            this.tb_duplicata.Location = new System.Drawing.Point(83, 248);
            this.tb_duplicata.Name = "tb_duplicata";
            this.tb_duplicata.Size = new System.Drawing.Size(56, 20);
            this.tb_duplicata.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(162, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 76;
            this.label8.Text = "Forn/Cli:";
            // 
            // tb_nome_forn
            // 
            this.tb_nome_forn.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsCaixa, "CAIXA.RAZAO_CLI_FORN_CAIXA", true));
            this.tb_nome_forn.Location = new System.Drawing.Point(215, 222);
            this.tb_nome_forn.Name = "tb_nome_forn";
            this.tb_nome_forn.Size = new System.Drawing.Size(162, 20);
            this.tb_nome_forn.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 75;
            this.label9.Text = "Cód. Forn/Cli:";
            // 
            // tb_cod_forn
            // 
            this.tb_cod_forn.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsCaixa, "CAIXA.COD_FORN_CLI_CAIXA", true));
            this.tb_cod_forn.Location = new System.Drawing.Point(89, 222);
            this.tb_cod_forn.Name = "tb_cod_forn";
            this.tb_cod_forn.Size = new System.Drawing.Size(56, 20);
            this.tb_cod_forn.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 13);
            this.label6.TabIndex = 69;
            this.label6.Text = "Data Pagamento/Recebimento:";
            // 
            // tb_data
            // 
            this.tb_data.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsCaixa, "CAIXA.DATA_CAIXA", true));
            this.tb_data.Location = new System.Drawing.Point(183, 196);
            this.tb_data.Name = "tb_data";
            this.tb_data.Size = new System.Drawing.Size(102, 20);
            this.tb_data.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 63;
            this.label4.Text = "Valor:";
            // 
            // tb_valor
            // 
            this.tb_valor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsCaixa, "CAIXA.VALOR_CAIXA", true));
            this.tb_valor.Location = new System.Drawing.Point(83, 170);
            this.tb_valor.Name = "tb_valor";
            this.tb_valor.Size = new System.Drawing.Size(112, 20);
            this.tb_valor.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 60;
            this.label3.Text = "Descrição:";
            // 
            // tb_descricao
            // 
            this.tb_descricao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsCaixa, "CAIXA.DESCRICAO_CAIXA", true));
            this.tb_descricao.Location = new System.Drawing.Point(83, 144);
            this.tb_descricao.Name = "tb_descricao";
            this.tb_descricao.Size = new System.Drawing.Size(294, 20);
            this.tb_descricao.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 81;
            this.label2.Text = "Cód:";
            // 
            // tb_cod
            // 
            this.tb_cod.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsCaixa, "CAIXA.COD_CAIXA", true));
            this.tb_cod.Location = new System.Drawing.Point(83, 67);
            this.tb_cod.Name = "tb_cod";
            this.tb_cod.ReadOnly = true;
            this.tb_cod.Size = new System.Drawing.Size(56, 20);
            this.tb_cod.TabIndex = 82;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 83;
            this.label7.Text = "Conta Corrente:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 121);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 86;
            this.label12.Text = "Cód. Cr/Cp:";
            // 
            // tb_cr_cp
            // 
            this.tb_cr_cp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsCaixa, "CAIXA.COD_CP_CR_CAIXA", true));
            this.tb_cr_cp.Location = new System.Drawing.Point(83, 118);
            this.tb_cr_cp.Name = "tb_cr_cp";
            this.tb_cr_cp.Size = new System.Drawing.Size(53, 20);
            this.tb_cr_cp.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(141, 116);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(183, 344);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 20;
            this.button5.Text = "Salvar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // datCaixa
            // 
            this.datCaixa.DeleteCommand = this.fbCommand4;
            this.datCaixa.InsertCommand = this.fbCommand2;
            this.datCaixa.SelectCommand = this.fbCommand1;
            this.datCaixa.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * from caixa";
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
            // cbCaixa
            // 
            this.cbCaixa.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbCaixa.DataAdapter = this.datCaixa;
            this.cbCaixa.QuotePrefix = "\"";
            this.cbCaixa.QuoteSuffix = "\"";
            // 
            // datContas_a_pagar
            // 
            this.datContas_a_pagar.DeleteCommand = this.fbCommand8;
            this.datContas_a_pagar.InsertCommand = this.fbCommand6;
            this.datContas_a_pagar.SelectCommand = this.fbCommand5;
            this.datContas_a_pagar.UpdateCommand = this.fbCommand7;
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
            this.fbCommand5.CommandText = "select * from contas_a_pagar";
            this.fbCommand5.CommandTimeout = 30;
            this.fbCommand5.Connection = this.fbConnection1;
            // 
            // fbCommand7
            // 
            this.fbCommand7.CommandTimeout = 30;
            // 
            // dsContas_a_pagar
            // 
            this.dsContas_a_pagar.DataSetName = "dsContas_a_pagar";
            this.dsContas_a_pagar.Namespace = "http://www.tempuri.org/dsContas_a_pagar.xsd";
            this.dsContas_a_pagar.Tables.AddRange(new System.Data.DataTable[] {
            this.CONTAS_A_PAGAR});
            // 
            // CONTAS_A_PAGAR
            // 
            this.CONTAS_A_PAGAR.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_CP,
            this.VALOR_CP,
            this.DATA_PREVISTA_CP,
            this.DATA_PAGAMENTO_CP,
            this.COD_FORNECEDOR_CP,
            this.RAZAO_FORNECEDOR_CP,
            this.DESCRICAO_CP,
            this.DUPLICATA_CP,
            this.PLANO_CP,
            this.PAGO_CP,
            this.NF_CP,
            this.COD_CAIXA_CP,
            this.CARTEIRA_CP});
            this.CONTAS_A_PAGAR.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_CP"}, true)});
            this.CONTAS_A_PAGAR.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_CP};
            this.CONTAS_A_PAGAR.TableName = "CONTAS_A_PAGAR";
            // 
            // COD_CP
            // 
            this.COD_CP.AllowDBNull = false;
            this.COD_CP.ColumnName = "COD_CP";
            this.COD_CP.DataType = typeof(int);
            // 
            // VALOR_CP
            // 
            this.VALOR_CP.ColumnName = "VALOR_CP";
            this.VALOR_CP.DataType = typeof(double);
            // 
            // DATA_PREVISTA_CP
            // 
            this.DATA_PREVISTA_CP.ColumnName = "DATA_PREVISTA_CP";
            this.DATA_PREVISTA_CP.DataType = typeof(System.DateTime);
            // 
            // DATA_PAGAMENTO_CP
            // 
            this.DATA_PAGAMENTO_CP.ColumnName = "DATA_PAGAMENTO_CP";
            this.DATA_PAGAMENTO_CP.DataType = typeof(System.DateTime);
            // 
            // COD_FORNECEDOR_CP
            // 
            this.COD_FORNECEDOR_CP.ColumnName = "COD_FORNECEDOR_CP";
            this.COD_FORNECEDOR_CP.DataType = typeof(int);
            // 
            // RAZAO_FORNECEDOR_CP
            // 
            this.RAZAO_FORNECEDOR_CP.ColumnName = "RAZAO_FORNECEDOR_CP";
            this.RAZAO_FORNECEDOR_CP.MaxLength = 100;
            // 
            // DESCRICAO_CP
            // 
            this.DESCRICAO_CP.ColumnName = "DESCRICAO_CP";
            this.DESCRICAO_CP.MaxLength = 200;
            // 
            // DUPLICATA_CP
            // 
            this.DUPLICATA_CP.ColumnName = "DUPLICATA_CP";
            this.DUPLICATA_CP.MaxLength = 50;
            // 
            // PLANO_CP
            // 
            this.PLANO_CP.ColumnName = "PLANO_CP";
            this.PLANO_CP.MaxLength = 50;
            // 
            // PAGO_CP
            // 
            this.PAGO_CP.ColumnName = "PAGO_CP";
            this.PAGO_CP.DataType = typeof(int);
            // 
            // NF_CP
            // 
            this.NF_CP.ColumnName = "NF_CP";
            this.NF_CP.MaxLength = 50;
            // 
            // COD_CAIXA_CP
            // 
            this.COD_CAIXA_CP.ColumnName = "COD_CAIXA_CP";
            this.COD_CAIXA_CP.DataType = typeof(int);
            // 
            // CARTEIRA_CP
            // 
            this.CARTEIRA_CP.ColumnName = "CARTEIRA_CP";
            this.CARTEIRA_CP.MaxLength = 50;
            // 
            // datContas_a_receber
            // 
            this.datContas_a_receber.DeleteCommand = this.fbCommand12;
            this.datContas_a_receber.InsertCommand = this.fbCommand10;
            this.datContas_a_receber.SelectCommand = this.fbCommand9;
            this.datContas_a_receber.UpdateCommand = this.fbCommand11;
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
            this.fbCommand9.CommandText = "select * from contas_a_receber";
            this.fbCommand9.CommandTimeout = 30;
            this.fbCommand9.Connection = this.fbConnection1;
            // 
            // fbCommand11
            // 
            this.fbCommand11.CommandTimeout = 30;
            // 
            // dsContas_a_receber
            // 
            this.dsContas_a_receber.DataSetName = "dsContas_a_receber";
            this.dsContas_a_receber.Namespace = "http://www.tempuri.org/dsContas_a_receber.xsd";
            this.dsContas_a_receber.Tables.AddRange(new System.Data.DataTable[] {
            this.CONTAS_A_RECEBER});
            // 
            // CONTAS_A_RECEBER
            // 
            this.CONTAS_A_RECEBER.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_CR,
            this.VALOR_CR,
            this.DATA_PREVISTA_CR,
            this.DATA_RECEBIMENTO_CR,
            this.COD_CLIENTE_CR,
            this.RAZAO_CLIENTE_CR,
            this.DESCRICAO_CR,
            this.DUPLICATA_CR,
            this.NF_CR,
            this.RECEBIDO_CR,
            this.COD_CAIXA_CR,
            this.PLANO_CR,
            this.CARTEIRA_CR,
            this.dataColumn2});
            this.CONTAS_A_RECEBER.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_CR"}, true)});
            this.CONTAS_A_RECEBER.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_CR};
            this.CONTAS_A_RECEBER.TableName = "CONTAS_A_RECEBER";
            // 
            // COD_CR
            // 
            this.COD_CR.AllowDBNull = false;
            this.COD_CR.ColumnName = "COD_CR";
            this.COD_CR.DataType = typeof(int);
            // 
            // VALOR_CR
            // 
            this.VALOR_CR.ColumnName = "VALOR_CR";
            this.VALOR_CR.DataType = typeof(double);
            // 
            // DATA_PREVISTA_CR
            // 
            this.DATA_PREVISTA_CR.ColumnName = "DATA_PREVISTA_CR";
            this.DATA_PREVISTA_CR.DataType = typeof(System.DateTime);
            // 
            // DATA_RECEBIMENTO_CR
            // 
            this.DATA_RECEBIMENTO_CR.ColumnName = "DATA_RECEBIMENTO_CR";
            this.DATA_RECEBIMENTO_CR.DataType = typeof(System.DateTime);
            // 
            // COD_CLIENTE_CR
            // 
            this.COD_CLIENTE_CR.ColumnName = "COD_CLIENTE_CR";
            this.COD_CLIENTE_CR.DataType = typeof(int);
            // 
            // RAZAO_CLIENTE_CR
            // 
            this.RAZAO_CLIENTE_CR.ColumnName = "RAZAO_CLIENTE_CR";
            this.RAZAO_CLIENTE_CR.MaxLength = 100;
            // 
            // DESCRICAO_CR
            // 
            this.DESCRICAO_CR.ColumnName = "DESCRICAO_CR";
            this.DESCRICAO_CR.MaxLength = 200;
            // 
            // DUPLICATA_CR
            // 
            this.DUPLICATA_CR.ColumnName = "DUPLICATA_CR";
            this.DUPLICATA_CR.DataType = typeof(int);
            // 
            // NF_CR
            // 
            this.NF_CR.ColumnName = "NF_CR";
            this.NF_CR.DataType = typeof(int);
            // 
            // RECEBIDO_CR
            // 
            this.RECEBIDO_CR.ColumnName = "RECEBIDO_CR";
            this.RECEBIDO_CR.DataType = typeof(int);
            // 
            // COD_CAIXA_CR
            // 
            this.COD_CAIXA_CR.ColumnName = "COD_CAIXA_CR";
            this.COD_CAIXA_CR.DataType = typeof(int);
            // 
            // PLANO_CR
            // 
            this.PLANO_CR.ColumnName = "PLANO_CR";
            this.PLANO_CR.MaxLength = 50;
            // 
            // CARTEIRA_CR
            // 
            this.CARTEIRA_CR.ColumnName = "CARTEIRA_CR";
            this.CARTEIRA_CR.MaxLength = 50;
            // 
            // tb_cod_cc
            // 
            this.tb_cod_cc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsCaixa, "CAIXA.CC_CAIXA", true));
            this.tb_cod_cc.Location = new System.Drawing.Point(106, 92);
            this.tb_cod_cc.Name = "tb_cod_cc";
            this.tb_cod_cc.Size = new System.Drawing.Size(53, 20);
            this.tb_cod_cc.TabIndex = 3;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(378, 90);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(25, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "+";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // tb_descricao_cc
            // 
            this.tb_descricao_cc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsCaixa, "CAIXA.DESCRICAO_CC_CAIXA", true));
            this.tb_descricao_cc.Location = new System.Drawing.Point(165, 92);
            this.tb_descricao_cc.Name = "tb_descricao_cc";
            this.tb_descricao_cc.Size = new System.Drawing.Size(212, 20);
            this.tb_descricao_cc.TabIndex = 4;
            // 
            // comando_select
            // 
            this.comando_select.CommandTimeout = 30;
            this.comando_select.Connection = this.fbConnection1;
            // 
            // datClientes
            // 
            this.datClientes.DeleteCommand = this.fbCommand16;
            this.datClientes.InsertCommand = this.fbCommand14;
            this.datClientes.SelectCommand = this.fbCommand13;
            this.datClientes.UpdateCommand = this.fbCommand15;
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
            this.fbCommand13.CommandText = "select * from clientes";
            this.fbCommand13.CommandTimeout = 30;
            this.fbCommand13.Connection = this.fbConnection1;
            // 
            // fbCommand15
            // 
            this.fbCommand15.CommandTimeout = 30;
            // 
            // datForn
            // 
            this.datForn.DeleteCommand = this.fbCommand20;
            this.datForn.InsertCommand = this.fbCommand18;
            this.datForn.SelectCommand = this.fbCommand17;
            this.datForn.UpdateCommand = this.fbCommand19;
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
            this.fbCommand17.CommandText = "select * from Fornecedores";
            this.fbCommand17.CommandTimeout = 30;
            this.fbCommand17.Connection = this.fbConnection1;
            // 
            // fbCommand19
            // 
            this.fbCommand19.CommandTimeout = 30;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 277);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 13);
            this.label14.TabIndex = 91;
            this.label14.Text = "Cód. Plano:";
            // 
            // tb_cod_plano
            // 
            this.tb_cod_plano.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsCaixa, "CAIXA.COD_PLANO_CAIXA", true));
            this.tb_cod_plano.Location = new System.Drawing.Point(83, 274);
            this.tb_cod_plano.Name = "tb_cod_plano";
            this.tb_cod_plano.Size = new System.Drawing.Size(56, 20);
            this.tb_cod_plano.TabIndex = 90;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(378, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 23);
            this.button1.TabIndex = 89;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(151, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 87;
            this.label5.Text = "Plano:";
            // 
            // tb_planos
            // 
            this.tb_planos.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsCaixa, "CAIXA.PLANO_CAIXA", true));
            this.tb_planos.Location = new System.Drawing.Point(215, 274);
            this.tb_planos.Name = "tb_planos";
            this.tb_planos.Size = new System.Drawing.Size(162, 20);
            this.tb_planos.TabIndex = 88;
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "COD_PLANO_CAIXA";
            this.dataColumn1.DataType = typeof(int);
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "COD_PLANO_CR";
            this.dataColumn2.DataType = typeof(int);
            // 
            // form_operacoes_caixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 379);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tb_cod_plano);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_planos);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.tb_descricao_cc);
            this.Controls.Add(this.tb_cod_cc);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tb_cr_cp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_cod);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.tb_carteira);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_nf);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tb_duplicata);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_nome_forn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_cod_forn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_data);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_valor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_descricao);
            this.Controls.Add(this.rb_Credito);
            this.Controls.Add(this.rb_Debito);
            this.Controls.Add(this.label1);
            this.Name = "form_operacoes_caixa";
            this.Text = "Caixa";
            this.Load += new System.EventHandler(this.form_caixa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsCaixa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CAIXA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsContas_a_pagar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CONTAS_A_PAGAR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsContas_a_receber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CONTAS_A_RECEBER)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb_Debito;
        private System.Windows.Forms.RadioButton rb_Credito;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox tb_carteira;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_nf;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_duplicata;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_nome_forn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_cod_forn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_data;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_valor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_descricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_cod;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_cr_cp;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datCaixa;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbCaixa;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datContas_a_pagar;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand8;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand6;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand5;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand7;
        private System.Data.DataSet dsContas_a_pagar;
        private System.Data.DataTable CONTAS_A_PAGAR;
        private System.Data.DataColumn COD_CP;
        private System.Data.DataColumn VALOR_CP;
        private System.Data.DataColumn DATA_PREVISTA_CP;
        private System.Data.DataColumn DATA_PAGAMENTO_CP;
        private System.Data.DataColumn COD_FORNECEDOR_CP;
        private System.Data.DataColumn RAZAO_FORNECEDOR_CP;
        private System.Data.DataColumn DESCRICAO_CP;
        private System.Data.DataColumn DUPLICATA_CP;
        private System.Data.DataColumn PLANO_CP;
        private System.Data.DataColumn PAGO_CP;
        private System.Data.DataColumn NF_CP;
        private System.Data.DataColumn COD_CAIXA_CP;
        private System.Data.DataColumn CARTEIRA_CP;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datContas_a_receber;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand12;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand10;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand9;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand11;
        private System.Data.DataSet dsContas_a_receber;
        private System.Data.DataTable CONTAS_A_RECEBER;
        private System.Data.DataColumn COD_CR;
        private System.Data.DataColumn VALOR_CR;
        private System.Data.DataColumn DATA_PREVISTA_CR;
        private System.Data.DataColumn DATA_RECEBIMENTO_CR;
        private System.Data.DataColumn COD_CLIENTE_CR;
        private System.Data.DataColumn RAZAO_CLIENTE_CR;
        private System.Data.DataColumn DESCRICAO_CR;
        private System.Data.DataColumn DUPLICATA_CR;
        private System.Data.DataColumn NF_CR;
        private System.Data.DataColumn RECEBIDO_CR;
        private System.Data.DataColumn COD_CAIXA_CR;
        private System.Data.DataColumn PLANO_CR;
        private System.Data.DataColumn CARTEIRA_CR;
        private System.Data.DataSet dsCaixa;
        private System.Data.DataTable CAIXA;
        private System.Data.DataColumn COD_CAIXA;
        private System.Data.DataColumn DESCRICAO_CAIXA;
        private System.Data.DataColumn CC_CAIXA;
        private System.Data.DataColumn COD_CP_CR_CAIXA;
        private System.Data.DataColumn DESCRICAO_CC_CAIXA;
        private System.Data.DataColumn VALOR_CAIXA;
        private System.Data.DataColumn DATA_CAIXA;
        private System.Data.DataColumn COD_EXTRATO_CAIXA;
        private System.Data.DataColumn COD_FORN_CLI_CAIXA;
        private System.Data.DataColumn RAZAO_CLI_FORN_CAIXA;
        private System.Data.DataColumn DUPLICATA_CAIXA;
        private System.Data.DataColumn NF_CAIXA;
        private System.Data.DataColumn PLANO_CAIXA;
        private System.Data.DataColumn CARTEIRA_CAIXA;
        private System.Data.DataColumn DEBITO_CAIXA;
        private System.Data.DataColumn CREDITO_CAIXA;
        private System.Windows.Forms.TextBox tb_cod_cc;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox tb_descricao_cc;
        private FirebirdSql.Data.FirebirdClient.FbCommand comando_select;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datClientes;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand16;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand14;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand13;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand15;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datForn;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand20;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand18;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand17;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand19;
        private System.Data.DataColumn dataColumn1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tb_cod_plano;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_planos;
        private System.Data.DataColumn dataColumn2;
    }
}