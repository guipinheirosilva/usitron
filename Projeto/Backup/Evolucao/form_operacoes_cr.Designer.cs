namespace Evolucao
{
    partial class form_operacoes_cr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_operacoes_cr));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_cod = new System.Windows.Forms.TextBox();
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
            this.dataColumn1 = new System.Data.DataColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_nome_forn = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_cod_forn = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.datContas_a_receber = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.cbContas_a_receber = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.button4 = new System.Windows.Forms.Button();
            this.tb_carteira = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.fbCommand8 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand6 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand5 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand7 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.comando_select = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.datClientes = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand12 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand10 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand9 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand11 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsClientes = new System.Data.DataSet();
            this.CLIENTES = new System.Data.DataTable();
            this.COD_CLIENTE = new System.Data.DataColumn();
            this.RAZAO_SOCIAL = new System.Data.DataColumn();
            this.NOME_FANTASIA = new System.Data.DataColumn();
            this.IE = new System.Data.DataColumn();
            this.IM = new System.Data.DataColumn();
            this.ENDERECO = new System.Data.DataColumn();
            this.BAIRRO = new System.Data.DataColumn();
            this.CIDADE = new System.Data.DataColumn();
            this.ESTADO = new System.Data.DataColumn();
            this.PAIS = new System.Data.DataColumn();
            this.FONE = new System.Data.DataColumn();
            this.EMAIL = new System.Data.DataColumn();
            this.CONTATO1 = new System.Data.DataColumn();
            this.FONE1 = new System.Data.DataColumn();
            this.EMAIL1 = new System.Data.DataColumn();
            this.CONTATO2 = new System.Data.DataColumn();
            this.FONE2 = new System.Data.DataColumn();
            this.EMAIL2 = new System.Data.DataColumn();
            this.CNPJ = new System.Data.DataColumn();
            this.SITUACAO = new System.Data.DataColumn();
            this.TIPO = new System.Data.DataColumn();
            this.TRANSPORTADORA_CLIENTE = new System.Data.DataColumn();
            this.ATIVIDADE_CLIENTE = new System.Data.DataColumn();
            this.BANCO_CLIENTE = new System.Data.DataColumn();
            this.AGENCIA_CLIENTE = new System.Data.DataColumn();
            this.REGIAO = new System.Data.DataColumn();
            this.VENDEDOR_CLIENTE = new System.Data.DataColumn();
            this.DATA_CADASTTRO_CLIENTE = new System.Data.DataColumn();
            this.ETIQUETA = new System.Data.DataColumn();
            this.CLASS_FISCAL_CLIENTE = new System.Data.DataColumn();
            this.ISENCAO_ICM_CLIENTE = new System.Data.DataColumn();
            this.ISENCAO_IPI_CLIENTE = new System.Data.DataColumn();
            this.ENDERECO_COBRANCA_CLIENTE = new System.Data.DataColumn();
            this.ENDERECO_ENTREGA_CLIENTE = new System.Data.DataColumn();
            this.COD_CIDADE_CLIENTE = new System.Data.DataColumn();
            this.COD_PAIS_CLIENTE = new System.Data.DataColumn();
            this.NUMERO_CLIENTE = new System.Data.DataColumn();
            this.CEP_CLIENTE = new System.Data.DataColumn();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_cod_plano = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_planos = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dsContas_a_receber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CONTAS_A_RECEBER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CLIENTES)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(86, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 62);
            this.label1.TabIndex = 51;
            this.label1.Text = "CONTAS A RECEBER\r\nOPERAÇÕES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_cod
            // 
            this.tb_cod.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsContas_a_receber, "CONTAS_A_RECEBER.COD_CR", true));
            this.tb_cod.Location = new System.Drawing.Point(92, 78);
            this.tb_cod.Name = "tb_cod";
            this.tb_cod.ReadOnly = true;
            this.tb_cod.Size = new System.Drawing.Size(56, 20);
            this.tb_cod.TabIndex = 50;
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
            this.dataColumn1});
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
            this.DUPLICATA_CR.MaxLength = 20;
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
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "COD_PLANO_CR";
            this.dataColumn1.DataType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cód:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Descrição:";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsContas_a_receber, "CONTAS_A_RECEBER.DESCRICAO_CR", true));
            this.textBox2.Location = new System.Drawing.Point(92, 104);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(294, 20);
            this.textBox2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Valor:";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsContas_a_receber, "CONTAS_A_RECEBER.VALOR_CR", true));
            this.textBox3.Location = new System.Drawing.Point(92, 130);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(112, 20);
            this.textBox3.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Data Prevista:";
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsContas_a_receber, "CONTAS_A_RECEBER.DATA_PREVISTA_CR", true));
            this.textBox5.Location = new System.Drawing.Point(102, 156);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(102, 20);
            this.textBox5.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(221, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Data Recebimento:";
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsContas_a_receber, "CONTAS_A_RECEBER.DATA_RECEBIMENTO_CR", true));
            this.textBox6.Location = new System.Drawing.Point(326, 156);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(101, 20);
            this.textBox6.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(160, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Cliente:";
            // 
            // tb_nome_forn
            // 
            this.tb_nome_forn.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsContas_a_receber, "CONTAS_A_RECEBER.RAZAO_CLIENTE_CR", true));
            this.tb_nome_forn.Location = new System.Drawing.Point(224, 182);
            this.tb_nome_forn.Name = "tb_nome_forn";
            this.tb_nome_forn.Size = new System.Drawing.Size(162, 20);
            this.tb_nome_forn.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Cód. Cliente:";
            // 
            // tb_cod_forn
            // 
            this.tb_cod_forn.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsContas_a_receber, "CONTAS_A_RECEBER.COD_CLIENTE_CR", true));
            this.tb_cod_forn.Location = new System.Drawing.Point(102, 183);
            this.tb_cod_forn.Name = "tb_cod_forn";
            this.tb_cod_forn.Size = new System.Drawing.Size(56, 20);
            this.tb_cod_forn.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(151, 211);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Pedido:";
            // 
            // textBox9
            // 
            this.textBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsContas_a_receber, "CONTAS_A_RECEBER.NF_CR", true));
            this.textBox9.Location = new System.Drawing.Point(197, 208);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(62, 20);
            this.textBox9.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 211);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Duplicata:";
            // 
            // textBox10
            // 
            this.textBox10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsContas_a_receber, "CONTAS_A_RECEBER.DUPLICATA_CR", true));
            this.textBox10.Location = new System.Drawing.Point(92, 208);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(56, 20);
            this.textBox10.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(260, 211);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Cód. Caixa:";
            // 
            // textBox11
            // 
            this.textBox11.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsContas_a_receber, "CONTAS_A_RECEBER.COD_CAIXA_CR", true));
            this.textBox11.Location = new System.Drawing.Point(324, 208);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(53, 20);
            this.textBox11.TabIndex = 10;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsContas_a_receber, "CONTAS_A_RECEBER.RECEBIDO_CR", true));
            this.checkBox1.Location = new System.Drawing.Point(383, 210);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 17);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Recebido";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(197, 308);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Salvar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(387, 180);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // datContas_a_receber
            // 
            this.datContas_a_receber.DeleteCommand = this.fbCommand4;
            this.datContas_a_receber.InsertCommand = this.fbCommand2;
            this.datContas_a_receber.SelectCommand = this.fbCommand1;
            this.datContas_a_receber.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * from contas_a_RECEBER";
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
            // cbContas_a_receber
            // 
            this.cbContas_a_receber.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbContas_a_receber.DataAdapter = this.datContas_a_receber;
            this.cbContas_a_receber.QuotePrefix = "\"";
            this.cbContas_a_receber.QuoteSuffix = "\"";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(197, 256);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(25, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "+";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tb_carteira
            // 
            this.tb_carteira.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsContas_a_receber, "CONTAS_A_RECEBER.CARTEIRA_CR", true));
            this.tb_carteira.Location = new System.Drawing.Point(92, 258);
            this.tb_carteira.Name = "tb_carteira";
            this.tb_carteira.Size = new System.Drawing.Size(101, 20);
            this.tb_carteira.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(28, 261);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Carteira:";
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
            this.fbCommand5.CommandText = "select * from fornecedores";
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
            // datClientes
            // 
            this.datClientes.DeleteCommand = this.fbCommand12;
            this.datClientes.InsertCommand = this.fbCommand10;
            this.datClientes.SelectCommand = this.fbCommand9;
            this.datClientes.UpdateCommand = this.fbCommand11;
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
            this.fbCommand9.CommandText = "select * from clientes";
            this.fbCommand9.CommandTimeout = 30;
            this.fbCommand9.Connection = this.fbConnection1;
            // 
            // fbCommand11
            // 
            this.fbCommand11.CommandTimeout = 30;
            // 
            // dsClientes
            // 
            this.dsClientes.DataSetName = "dsClientes";
            this.dsClientes.Namespace = "http://www.tempuri.org/dsClientes.xsd";
            this.dsClientes.Tables.AddRange(new System.Data.DataTable[] {
            this.CLIENTES});
            // 
            // CLIENTES
            // 
            this.CLIENTES.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_CLIENTE,
            this.RAZAO_SOCIAL,
            this.NOME_FANTASIA,
            this.IE,
            this.IM,
            this.ENDERECO,
            this.BAIRRO,
            this.CIDADE,
            this.ESTADO,
            this.PAIS,
            this.FONE,
            this.EMAIL,
            this.CONTATO1,
            this.FONE1,
            this.EMAIL1,
            this.CONTATO2,
            this.FONE2,
            this.EMAIL2,
            this.CNPJ,
            this.SITUACAO,
            this.TIPO,
            this.TRANSPORTADORA_CLIENTE,
            this.ATIVIDADE_CLIENTE,
            this.BANCO_CLIENTE,
            this.AGENCIA_CLIENTE,
            this.REGIAO,
            this.VENDEDOR_CLIENTE,
            this.DATA_CADASTTRO_CLIENTE,
            this.ETIQUETA,
            this.CLASS_FISCAL_CLIENTE,
            this.ISENCAO_ICM_CLIENTE,
            this.ISENCAO_IPI_CLIENTE,
            this.ENDERECO_COBRANCA_CLIENTE,
            this.ENDERECO_ENTREGA_CLIENTE,
            this.COD_CIDADE_CLIENTE,
            this.COD_PAIS_CLIENTE,
            this.NUMERO_CLIENTE,
            this.CEP_CLIENTE});
            this.CLIENTES.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "CNPJ"}, true)});
            this.CLIENTES.PrimaryKey = new System.Data.DataColumn[] {
        this.CNPJ};
            this.CLIENTES.TableName = "CLIENTES";
            // 
            // COD_CLIENTE
            // 
            this.COD_CLIENTE.ColumnName = "COD_CLIENTE";
            this.COD_CLIENTE.DataType = typeof(int);
            // 
            // RAZAO_SOCIAL
            // 
            this.RAZAO_SOCIAL.AllowDBNull = false;
            this.RAZAO_SOCIAL.ColumnName = "RAZAO_SOCIAL";
            this.RAZAO_SOCIAL.MaxLength = 50;
            // 
            // NOME_FANTASIA
            // 
            this.NOME_FANTASIA.ColumnName = "NOME_FANTASIA";
            this.NOME_FANTASIA.MaxLength = 50;
            // 
            // IE
            // 
            this.IE.ColumnName = "IE";
            this.IE.MaxLength = 20;
            // 
            // IM
            // 
            this.IM.ColumnName = "IM";
            this.IM.MaxLength = 20;
            // 
            // ENDERECO
            // 
            this.ENDERECO.ColumnName = "ENDERECO";
            this.ENDERECO.MaxLength = 50;
            // 
            // BAIRRO
            // 
            this.BAIRRO.ColumnName = "BAIRRO";
            this.BAIRRO.MaxLength = 30;
            // 
            // CIDADE
            // 
            this.CIDADE.ColumnName = "CIDADE";
            this.CIDADE.MaxLength = 35;
            // 
            // ESTADO
            // 
            this.ESTADO.ColumnName = "ESTADO";
            this.ESTADO.MaxLength = 2;
            // 
            // PAIS
            // 
            this.PAIS.ColumnName = "PAIS";
            this.PAIS.MaxLength = 20;
            // 
            // FONE
            // 
            this.FONE.ColumnName = "FONE";
            this.FONE.MaxLength = 14;
            // 
            // EMAIL
            // 
            this.EMAIL.ColumnName = "EMAIL";
            this.EMAIL.MaxLength = 80;
            // 
            // CONTATO1
            // 
            this.CONTATO1.ColumnName = "CONTATO1";
            this.CONTATO1.MaxLength = 40;
            // 
            // FONE1
            // 
            this.FONE1.ColumnName = "FONE1";
            this.FONE1.MaxLength = 14;
            // 
            // EMAIL1
            // 
            this.EMAIL1.ColumnName = "EMAIL1";
            this.EMAIL1.MaxLength = 80;
            // 
            // CONTATO2
            // 
            this.CONTATO2.ColumnName = "CONTATO2";
            this.CONTATO2.MaxLength = 40;
            // 
            // FONE2
            // 
            this.FONE2.ColumnName = "FONE2";
            this.FONE2.MaxLength = 14;
            // 
            // EMAIL2
            // 
            this.EMAIL2.ColumnName = "EMAIL2";
            this.EMAIL2.MaxLength = 80;
            // 
            // CNPJ
            // 
            this.CNPJ.AllowDBNull = false;
            this.CNPJ.ColumnName = "CNPJ";
            this.CNPJ.MaxLength = 30;
            // 
            // SITUACAO
            // 
            this.SITUACAO.ColumnName = "SITUACAO";
            this.SITUACAO.MaxLength = 40;
            // 
            // TIPO
            // 
            this.TIPO.ColumnName = "TIPO";
            this.TIPO.MaxLength = 40;
            // 
            // TRANSPORTADORA_CLIENTE
            // 
            this.TRANSPORTADORA_CLIENTE.ColumnName = "TRANSPORTADORA_CLIENTE";
            this.TRANSPORTADORA_CLIENTE.MaxLength = 80;
            // 
            // ATIVIDADE_CLIENTE
            // 
            this.ATIVIDADE_CLIENTE.ColumnName = "ATIVIDADE_CLIENTE";
            this.ATIVIDADE_CLIENTE.MaxLength = 50;
            // 
            // BANCO_CLIENTE
            // 
            this.BANCO_CLIENTE.ColumnName = "BANCO_CLIENTE";
            this.BANCO_CLIENTE.MaxLength = 10;
            // 
            // AGENCIA_CLIENTE
            // 
            this.AGENCIA_CLIENTE.ColumnName = "AGENCIA_CLIENTE";
            this.AGENCIA_CLIENTE.MaxLength = 10;
            // 
            // REGIAO
            // 
            this.REGIAO.ColumnName = "REGIAO";
            this.REGIAO.MaxLength = 20;
            // 
            // VENDEDOR_CLIENTE
            // 
            this.VENDEDOR_CLIENTE.ColumnName = "VENDEDOR_CLIENTE";
            this.VENDEDOR_CLIENTE.MaxLength = 40;
            // 
            // DATA_CADASTTRO_CLIENTE
            // 
            this.DATA_CADASTTRO_CLIENTE.ColumnName = "DATA_CADASTTRO_CLIENTE";
            this.DATA_CADASTTRO_CLIENTE.DataType = typeof(System.DateTime);
            // 
            // ETIQUETA
            // 
            this.ETIQUETA.ColumnName = "ETIQUETA";
            this.ETIQUETA.MaxLength = 10;
            // 
            // CLASS_FISCAL_CLIENTE
            // 
            this.CLASS_FISCAL_CLIENTE.ColumnName = "CLASS_FISCAL_CLIENTE";
            this.CLASS_FISCAL_CLIENTE.MaxLength = 50;
            // 
            // ISENCAO_ICM_CLIENTE
            // 
            this.ISENCAO_ICM_CLIENTE.ColumnName = "ISENCAO_ICM_CLIENTE";
            this.ISENCAO_ICM_CLIENTE.MaxLength = 250;
            // 
            // ISENCAO_IPI_CLIENTE
            // 
            this.ISENCAO_IPI_CLIENTE.ColumnName = "ISENCAO_IPI_CLIENTE";
            this.ISENCAO_IPI_CLIENTE.MaxLength = 250;
            // 
            // ENDERECO_COBRANCA_CLIENTE
            // 
            this.ENDERECO_COBRANCA_CLIENTE.ColumnName = "ENDERECO_COBRANCA_CLIENTE";
            this.ENDERECO_COBRANCA_CLIENTE.MaxLength = 80;
            // 
            // ENDERECO_ENTREGA_CLIENTE
            // 
            this.ENDERECO_ENTREGA_CLIENTE.ColumnName = "ENDERECO_ENTREGA_CLIENTE";
            this.ENDERECO_ENTREGA_CLIENTE.MaxLength = 80;
            // 
            // COD_CIDADE_CLIENTE
            // 
            this.COD_CIDADE_CLIENTE.ColumnName = "COD_CIDADE_CLIENTE";
            this.COD_CIDADE_CLIENTE.MaxLength = 10;
            // 
            // COD_PAIS_CLIENTE
            // 
            this.COD_PAIS_CLIENTE.ColumnName = "COD_PAIS_CLIENTE";
            this.COD_PAIS_CLIENTE.MaxLength = 10;
            // 
            // NUMERO_CLIENTE
            // 
            this.NUMERO_CLIENTE.ColumnName = "NUMERO_CLIENTE";
            this.NUMERO_CLIENTE.MaxLength = 20;
            // 
            // CEP_CLIENTE
            // 
            this.CEP_CLIENTE.ColumnName = "CEP_CLIENTE";
            this.CEP_CLIENTE.MaxLength = 18;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(28, 236);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 13);
            this.label14.TabIndex = 58;
            this.label14.Text = "Cód. Plano:";
            // 
            // tb_cod_plano
            // 
            this.tb_cod_plano.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsContas_a_receber, "CONTAS_A_RECEBER.COD_PLANO_CR", true));
            this.tb_cod_plano.Location = new System.Drawing.Point(92, 233);
            this.tb_cod_plano.Name = "tb_cod_plano";
            this.tb_cod_plano.Size = new System.Drawing.Size(56, 20);
            this.tb_cod_plano.TabIndex = 57;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(387, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 23);
            this.button1.TabIndex = 56;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(160, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = "Plano:";
            // 
            // tb_planos
            // 
            this.tb_planos.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsContas_a_receber, "CONTAS_A_RECEBER.PLANO_CR", true));
            this.tb_planos.Location = new System.Drawing.Point(224, 233);
            this.tb_planos.Name = "tb_planos";
            this.tb_planos.Size = new System.Drawing.Size(162, 20);
            this.tb_planos.TabIndex = 55;
            // 
            // form_operacoes_cr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 343);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tb_cod_plano);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_planos);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.tb_carteira);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_nome_forn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_cod_forn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_cod);
            this.Controls.Add(this.label1);
            this.Name = "form_operacoes_cr";
            this.Text = "Operações Contas a Pagar";
            this.Load += new System.EventHandler(this.form_operacoes_cr_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dsContas_a_receber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CONTAS_A_RECEBER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CLIENTES)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_cod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_nome_forn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_cod_forn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datContas_a_receber;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbContas_a_receber;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox tb_carteira;
        private System.Windows.Forms.Label label13;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand8;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand6;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand5;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand7;
        private FirebirdSql.Data.FirebirdClient.FbCommand comando_select;
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
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datClientes;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand12;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand10;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand9;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand11;
        private System.Data.DataSet dsClientes;
        private System.Data.DataTable CLIENTES;
        private System.Data.DataColumn COD_CLIENTE;
        private System.Data.DataColumn RAZAO_SOCIAL;
        private System.Data.DataColumn NOME_FANTASIA;
        private System.Data.DataColumn IE;
        private System.Data.DataColumn IM;
        private System.Data.DataColumn ENDERECO;
        private System.Data.DataColumn BAIRRO;
        private System.Data.DataColumn CIDADE;
        private System.Data.DataColumn ESTADO;
        private System.Data.DataColumn PAIS;
        private System.Data.DataColumn FONE;
        private System.Data.DataColumn EMAIL;
        private System.Data.DataColumn CONTATO1;
        private System.Data.DataColumn FONE1;
        private System.Data.DataColumn EMAIL1;
        private System.Data.DataColumn CONTATO2;
        private System.Data.DataColumn FONE2;
        private System.Data.DataColumn EMAIL2;
        private System.Data.DataColumn CNPJ;
        private System.Data.DataColumn SITUACAO;
        private System.Data.DataColumn TIPO;
        private System.Data.DataColumn TRANSPORTADORA_CLIENTE;
        private System.Data.DataColumn ATIVIDADE_CLIENTE;
        private System.Data.DataColumn BANCO_CLIENTE;
        private System.Data.DataColumn AGENCIA_CLIENTE;
        private System.Data.DataColumn REGIAO;
        private System.Data.DataColumn VENDEDOR_CLIENTE;
        private System.Data.DataColumn DATA_CADASTTRO_CLIENTE;
        private System.Data.DataColumn ETIQUETA;
        private System.Data.DataColumn CLASS_FISCAL_CLIENTE;
        private System.Data.DataColumn ISENCAO_ICM_CLIENTE;
        private System.Data.DataColumn ISENCAO_IPI_CLIENTE;
        private System.Data.DataColumn ENDERECO_COBRANCA_CLIENTE;
        private System.Data.DataColumn ENDERECO_ENTREGA_CLIENTE;
        private System.Data.DataColumn COD_CIDADE_CLIENTE;
        private System.Data.DataColumn COD_PAIS_CLIENTE;
        private System.Data.DataColumn NUMERO_CLIENTE;
        private System.Data.DataColumn CEP_CLIENTE;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tb_cod_plano;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_planos;
        private System.Data.DataColumn dataColumn1;
    }
}