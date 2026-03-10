namespace Evolucao
{
    partial class form_operacoes_cp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_operacoes_cp));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_cod = new System.Windows.Forms.TextBox();
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
            this.dataColumn1 = new System.Data.DataColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_planos = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
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
            this.datContas_a_pagar = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.cbContas_a_pagar = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.button4 = new System.Windows.Forms.Button();
            this.tb_carteira = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.datForn = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand8 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand6 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand5 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand7 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.comando_select = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_cod_plano = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dsContas_a_pagar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CONTAS_A_PAGAR)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(-3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 31);
            this.label1.TabIndex = 50;
            this.label1.Text = "CONTAS A PAGAR - OPERAÇÕES";
            // 
            // tb_cod
            // 
            this.tb_cod.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsContas_a_pagar, "CONTAS_A_PAGAR.COD_CP", true));
            this.tb_cod.Location = new System.Drawing.Point(92, 78);
            this.tb_cod.Name = "tb_cod";
            this.tb_cod.ReadOnly = true;
            this.tb_cod.Size = new System.Drawing.Size(56, 20);
            this.tb_cod.TabIndex = 51;
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
            this.CARTEIRA_CP,
            this.dataColumn1});
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
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "COD_PLANO_CP";
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
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsContas_a_pagar, "CONTAS_A_PAGAR.DESCRICAO_CP", true));
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
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsContas_a_pagar, "CONTAS_A_PAGAR.VALOR_CP", true));
            this.textBox3.Location = new System.Drawing.Point(92, 130);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(112, 20);
            this.textBox3.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(160, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Plano:";
            // 
            // tb_planos
            // 
            this.tb_planos.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsContas_a_pagar, "CONTAS_A_PAGAR.PLANO_CP", true));
            this.tb_planos.Location = new System.Drawing.Point(224, 234);
            this.tb_planos.Name = "tb_planos";
            this.tb_planos.Size = new System.Drawing.Size(162, 20);
            this.tb_planos.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(387, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsContas_a_pagar, "CONTAS_A_PAGAR.DATA_PREVISTA_CP", true));
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
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Data Pgto:";
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsContas_a_pagar, "CONTAS_A_PAGAR.DATA_PAGAMENTO_CP", true));
            this.textBox6.Location = new System.Drawing.Point(285, 156);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(101, 20);
            this.textBox6.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(160, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Fornecedor:";
            // 
            // tb_nome_forn
            // 
            this.tb_nome_forn.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsContas_a_pagar, "CONTAS_A_PAGAR.RAZAO_FORNECEDOR_CP", true));
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
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Cód. Forn:";
            // 
            // tb_cod_forn
            // 
            this.tb_cod_forn.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsContas_a_pagar, "CONTAS_A_PAGAR.COD_FORNECEDOR_CP", true));
            this.tb_cod_forn.Location = new System.Drawing.Point(92, 182);
            this.tb_cod_forn.Name = "tb_cod_forn";
            this.tb_cod_forn.Size = new System.Drawing.Size(56, 20);
            this.tb_cod_forn.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(160, 211);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "NF:";
            // 
            // textBox9
            // 
            this.textBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsContas_a_pagar, "CONTAS_A_PAGAR.NF_CP", true));
            this.textBox9.Location = new System.Drawing.Point(190, 208);
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
            this.textBox10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsContas_a_pagar, "CONTAS_A_PAGAR.DUPLICATA_CP", true));
            this.textBox10.Location = new System.Drawing.Point(92, 208);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(56, 20);
            this.textBox10.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(266, 211);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Cód. Caixa:";
            // 
            // textBox11
            // 
            this.textBox11.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsContas_a_pagar, "CONTAS_A_PAGAR.COD_CAIXA_CP", true));
            this.textBox11.Location = new System.Drawing.Point(333, 208);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(53, 20);
            this.textBox11.TabIndex = 10;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsContas_a_pagar, "CONTAS_A_PAGAR.PAGO_CP", true));
            this.checkBox1.Location = new System.Drawing.Point(392, 210);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(51, 17);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Pago";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(190, 305);
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
            // datContas_a_pagar
            // 
            this.datContas_a_pagar.DeleteCommand = this.fbCommand4;
            this.datContas_a_pagar.InsertCommand = this.fbCommand2;
            this.datContas_a_pagar.SelectCommand = this.fbCommand1;
            this.datContas_a_pagar.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * from contas_a_pagar";
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
            // cbContas_a_pagar
            // 
            this.cbContas_a_pagar.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbContas_a_pagar.DataAdapter = this.datContas_a_pagar;
            this.cbContas_a_pagar.QuotePrefix = "\"";
            this.cbContas_a_pagar.QuoteSuffix = "\"";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(196, 258);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(25, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "+";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tb_carteira
            // 
            this.tb_carteira.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsContas_a_pagar, "CONTAS_A_PAGAR.CARTEIRA_CP", true));
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
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(28, 237);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 13);
            this.label14.TabIndex = 53;
            this.label14.Text = "Cód. Plano:";
            // 
            // tb_cod_plano
            // 
            this.tb_cod_plano.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsContas_a_pagar, "CONTAS_A_PAGAR.COD_PLANO_CP", true));
            this.tb_cod_plano.Location = new System.Drawing.Point(92, 234);
            this.tb_cod_plano.Name = "tb_cod_plano";
            this.tb_cod_plano.Size = new System.Drawing.Size(56, 20);
            this.tb_cod_plano.TabIndex = 52;
            // 
            // form_operacoes_cp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 340);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tb_cod_plano);
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
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_planos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_cod);
            this.Controls.Add(this.label1);
            this.Name = "form_operacoes_cp";
            this.Text = "Operações Contas a Pagar";
            this.Load += new System.EventHandler(this.form_operacoes_cp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsContas_a_pagar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CONTAS_A_PAGAR)).EndInit();
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_planos;
        private System.Windows.Forms.Button button1;
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
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datContas_a_pagar;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbContas_a_pagar;
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
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox tb_carteira;
        private System.Windows.Forms.Label label13;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datForn;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand8;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand6;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand5;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand7;
        private FirebirdSql.Data.FirebirdClient.FbCommand comando_select;
        private System.Data.DataColumn dataColumn1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tb_cod_plano;
    }
}