namespace Evolucao
{
    partial class form_crono_excel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_crono_excel));
            this.dgvCrono = new System.Windows.Forms.DataGridView();
            this.datContas_a_pagar = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
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
            this.cbContas_a_pagar = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.button1 = new System.Windows.Forms.Button();
            this.datProdutos = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand8 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand6 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand5 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand7 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.datItens_nf_entrada = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand12 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand10 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand9 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand11 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button46 = new System.Windows.Forms.Button();
            this.button45 = new System.Windows.Forms.Button();
            this.button44 = new System.Windows.Forms.Button();
            this.button43 = new System.Windows.Forms.Button();
            this.button39 = new System.Windows.Forms.Button();
            this.button42 = new System.Windows.Forms.Button();
            this.btnInativarClientes = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button47 = new System.Windows.Forms.Button();
            this.button38 = new System.Windows.Forms.Button();
            this.btnRecalcularEstoqueJmacedo = new System.Windows.Forms.Button();
            this.btnRecalcularEstoqueHarald = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button26 = new System.Windows.Forms.Button();
            this.btnAtualizarPrecoCuto = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btnInativarProdutos = new System.Windows.Forms.Button();
            this.btnMarcarBarrinhasHarald = new System.Windows.Forms.Button();
            this.btnAtualizarCodBarrasHarald = new System.Windows.Forms.Button();
            this.btnImportarQtdeUnidade = new System.Windows.Forms.Button();
            this.btnClassificarMixJmacedo = new System.Windows.Forms.Button();
            this.btnClassificarFarinhasJmacedo = new System.Windows.Forms.Button();
            this.btnClassificarJmacedo = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.tb_cnpj = new System.Windows.Forms.TextBox();
            this.tb_razao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button27 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.button35 = new System.Windows.Forms.Button();
            this.button36 = new System.Windows.Forms.Button();
            this.button37 = new System.Windows.Forms.Button();
            this.button40 = new System.Windows.Forms.Button();
            this.button41 = new System.Windows.Forms.Button();
            this.button48 = new System.Windows.Forms.Button();
            this.button49 = new System.Windows.Forms.Button();
            this.button50 = new System.Windows.Forms.Button();
            this.button51 = new System.Windows.Forms.Button();
            this.button52 = new System.Windows.Forms.Button();
            this.button53 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCrono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsContas_a_pagar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CONTAS_A_PAGAR)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCrono
            // 
            this.dgvCrono.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCrono.Location = new System.Drawing.Point(2, 12);
            this.dgvCrono.Name = "dgvCrono";
            this.dgvCrono.Size = new System.Drawing.Size(45, 21);
            this.dgvCrono.TabIndex = 0;
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
            // cbContas_a_pagar
            // 
            this.cbContas_a_pagar.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbContas_a_pagar.QuotePrefix = "\"";
            this.cbContas_a_pagar.QuoteSuffix = "\"";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // datProdutos
            // 
            this.datProdutos.DeleteCommand = this.fbCommand8;
            this.datProdutos.InsertCommand = this.fbCommand6;
            this.datProdutos.SelectCommand = this.fbCommand5;
            this.datProdutos.UpdateCommand = this.fbCommand7;
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
            this.fbCommand5.CommandText = "select * from produtos";
            this.fbCommand5.CommandTimeout = 30;
            this.fbCommand5.Connection = this.fbConnection1;
            // 
            // fbCommand7
            // 
            this.fbCommand7.CommandTimeout = 30;
            // 
            // datItens_nf_entrada
            // 
            this.datItens_nf_entrada.DeleteCommand = this.fbCommand12;
            this.datItens_nf_entrada.InsertCommand = this.fbCommand10;
            this.datItens_nf_entrada.SelectCommand = this.fbCommand9;
            this.datItens_nf_entrada.UpdateCommand = this.fbCommand11;
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
            this.fbCommand9.CommandText = "select * from itens_nf_entrada";
            this.fbCommand9.CommandTimeout = 30;
            this.fbCommand9.Connection = this.fbConnection1;
            // 
            // fbCommand11
            // 
            this.fbCommand11.CommandTimeout = 30;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(6, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 50);
            this.panel1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Produtos JMacedo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.button3);
            this.panel2.Location = new System.Drawing.Point(6, 129);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 50);
            this.panel2.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(15, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Tirar ponto CNPJ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button46);
            this.groupBox1.Controls.Add(this.button45);
            this.groupBox1.Controls.Add(this.button44);
            this.groupBox1.Controls.Add(this.button43);
            this.groupBox1.Controls.Add(this.button39);
            this.groupBox1.Controls.Add(this.button42);
            this.groupBox1.Controls.Add(this.btnInativarClientes);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Location = new System.Drawing.Point(244, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(138, 246);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clientes";
            // 
            // button46
            // 
            this.button46.Location = new System.Drawing.Point(6, 50);
            this.button46.Name = "button46";
            this.button46.Size = new System.Drawing.Size(130, 23);
            this.button46.TabIndex = 46;
            this.button46.Text = "recalcular estoque MP";
            this.button46.UseVisualStyleBackColor = true;
            this.button46.Click += new System.EventHandler(this.button46_Click);
            // 
            // button45
            // 
            this.button45.Location = new System.Drawing.Point(8, 79);
            this.button45.Name = "button45";
            this.button45.Size = new System.Drawing.Size(130, 23);
            this.button45.TabIndex = 45;
            this.button45.Text = "recalcular lotes ";
            this.button45.UseVisualStyleBackColor = true;
            this.button45.Click += new System.EventHandler(this.button45_Click);
            // 
            // button44
            // 
            this.button44.Location = new System.Drawing.Point(8, 191);
            this.button44.Name = "button44";
            this.button44.Size = new System.Drawing.Size(131, 23);
            this.button44.TabIndex = 44;
            this.button44.Text = "lotes";
            this.button44.UseVisualStyleBackColor = true;
            this.button44.Click += new System.EventHandler(this.button44_Click);
            // 
            // button43
            // 
            this.button43.Location = new System.Drawing.Point(7, 140);
            this.button43.Name = "button43";
            this.button43.Size = new System.Drawing.Size(131, 25);
            this.button43.TabIndex = 43;
            this.button43.Text = "Componentes";
            this.button43.UseVisualStyleBackColor = true;
            this.button43.Click += new System.EventHandler(this.button43_Click);
            // 
            // button39
            // 
            this.button39.Location = new System.Drawing.Point(7, 108);
            this.button39.Name = "button39";
            this.button39.Size = new System.Drawing.Size(131, 26);
            this.button39.TabIndex = 41;
            this.button39.Text = "Importar estoque";
            this.button39.UseVisualStyleBackColor = true;
            this.button39.Click += new System.EventHandler(this.button39_Click);
            // 
            // button42
            // 
            this.button42.Location = new System.Drawing.Point(7, 167);
            this.button42.Name = "button42";
            this.button42.Size = new System.Drawing.Size(126, 23);
            this.button42.TabIndex = 2;
            this.button42.Text = "Importar MP";
            this.button42.UseVisualStyleBackColor = true;
            this.button42.Click += new System.EventHandler(this.button42_Click);
            // 
            // btnInativarClientes
            // 
            this.btnInativarClientes.Location = new System.Drawing.Point(6, 48);
            this.btnInativarClientes.Name = "btnInativarClientes";
            this.btnInativarClientes.Size = new System.Drawing.Size(126, 23);
            this.btnInativarClientes.TabIndex = 1;
            this.btnInativarClientes.Text = "Inativar Clientes";
            this.btnInativarClientes.UseVisualStyleBackColor = true;
            this.btnInativarClientes.Click += new System.EventHandler(this.btnInativarClientes_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(126, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "Classificar clientes";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button47);
            this.groupBox2.Controls.Add(this.button38);
            this.groupBox2.Controls.Add(this.btnRecalcularEstoqueJmacedo);
            this.groupBox2.Controls.Add(this.btnRecalcularEstoqueHarald);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Location = new System.Drawing.Point(388, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(147, 246);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estoque";
            // 
            // button47
            // 
            this.button47.Location = new System.Drawing.Point(6, 142);
            this.button47.Name = "button47";
            this.button47.Size = new System.Drawing.Size(131, 25);
            this.button47.TabIndex = 47;
            this.button47.Text = "Criar Links";
            this.button47.UseVisualStyleBackColor = true;
            this.button47.Click += new System.EventHandler(this.button47_Click);
            // 
            // button38
            // 
            this.button38.Location = new System.Drawing.Point(6, 184);
            this.button38.Name = "button38";
            this.button38.Size = new System.Drawing.Size(108, 56);
            this.button38.TabIndex = 41;
            this.button38.Text = "Importar Transportadoras";
            this.button38.UseVisualStyleBackColor = true;
            this.button38.Click += new System.EventHandler(this.button38_Click);
            // 
            // btnRecalcularEstoqueJmacedo
            // 
            this.btnRecalcularEstoqueJmacedo.Location = new System.Drawing.Point(6, 94);
            this.btnRecalcularEstoqueJmacedo.Name = "btnRecalcularEstoqueJmacedo";
            this.btnRecalcularEstoqueJmacedo.Size = new System.Drawing.Size(135, 40);
            this.btnRecalcularEstoqueJmacedo.TabIndex = 2;
            this.btnRecalcularEstoqueJmacedo.Text = "Recalcular Estoque JMacedo";
            this.btnRecalcularEstoqueJmacedo.UseVisualStyleBackColor = true;
            this.btnRecalcularEstoqueJmacedo.Click += new System.EventHandler(this.btnRecalcularEstoqueJmacedo_Click);
            // 
            // btnRecalcularEstoqueHarald
            // 
            this.btnRecalcularEstoqueHarald.Location = new System.Drawing.Point(6, 48);
            this.btnRecalcularEstoqueHarald.Name = "btnRecalcularEstoqueHarald";
            this.btnRecalcularEstoqueHarald.Size = new System.Drawing.Size(135, 40);
            this.btnRecalcularEstoqueHarald.TabIndex = 1;
            this.btnRecalcularEstoqueHarald.Text = "Recalcular Estoque Harald";
            this.btnRecalcularEstoqueHarald.UseVisualStyleBackColor = true;
            this.btnRecalcularEstoqueHarald.Click += new System.EventHandler(this.btnRecalcularEstoqueHarald_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 19);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(135, 23);
            this.button5.TabIndex = 0;
            this.button5.Text = "Entrada Inicial";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button26);
            this.groupBox3.Controls.Add(this.btnAtualizarPrecoCuto);
            this.groupBox3.Controls.Add(this.button10);
            this.groupBox3.Controls.Add(this.button9);
            this.groupBox3.Controls.Add(this.button7);
            this.groupBox3.Controls.Add(this.btnInativarProdutos);
            this.groupBox3.Controls.Add(this.btnMarcarBarrinhasHarald);
            this.groupBox3.Controls.Add(this.btnAtualizarCodBarrasHarald);
            this.groupBox3.Controls.Add(this.btnImportarQtdeUnidade);
            this.groupBox3.Controls.Add(this.btnClassificarMixJmacedo);
            this.groupBox3.Controls.Add(this.btnClassificarFarinhasJmacedo);
            this.groupBox3.Controls.Add(this.btnClassificarJmacedo);
            this.groupBox3.Location = new System.Drawing.Point(541, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(187, 413);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Produtos";
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(6, 380);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(175, 23);
            this.button26.TabIndex = 10;
            this.button26.Text = "Importar NCM";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.button26_Click);
            // 
            // btnAtualizarPrecoCuto
            // 
            this.btnAtualizarPrecoCuto.Location = new System.Drawing.Point(6, 223);
            this.btnAtualizarPrecoCuto.Name = "btnAtualizarPrecoCuto";
            this.btnAtualizarPrecoCuto.Size = new System.Drawing.Size(175, 23);
            this.btnAtualizarPrecoCuto.TabIndex = 9;
            this.btnAtualizarPrecoCuto.Text = "Atualizar preco de custo";
            this.btnAtualizarPrecoCuto.UseVisualStyleBackColor = true;
            this.btnAtualizarPrecoCuto.Click += new System.EventHandler(this.btnAtualizarPrecoCuto_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(6, 337);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(175, 37);
            this.button10.TabIndex = 8;
            this.button10.Text = "2 - Puxar Famílias (14/11/2014)";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(6, 294);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(175, 37);
            this.button9.TabIndex = 7;
            this.button9.Text = "1 - Atualizações Produtos (14/11/2014)";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(6, 265);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(175, 23);
            this.button7.TabIndex = 2;
            this.button7.Text = "Buscar Codigo de Barras";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnInativarProdutos
            // 
            this.btnInativarProdutos.Location = new System.Drawing.Point(6, 193);
            this.btnInativarProdutos.Name = "btnInativarProdutos";
            this.btnInativarProdutos.Size = new System.Drawing.Size(175, 23);
            this.btnInativarProdutos.TabIndex = 6;
            this.btnInativarProdutos.Text = "Inativar produtos";
            this.btnInativarProdutos.UseVisualStyleBackColor = true;
            this.btnInativarProdutos.Click += new System.EventHandler(this.btnInativarProdutos_Click);
            // 
            // btnMarcarBarrinhasHarald
            // 
            this.btnMarcarBarrinhasHarald.Location = new System.Drawing.Point(6, 164);
            this.btnMarcarBarrinhasHarald.Name = "btnMarcarBarrinhasHarald";
            this.btnMarcarBarrinhasHarald.Size = new System.Drawing.Size(175, 23);
            this.btnMarcarBarrinhasHarald.TabIndex = 5;
            this.btnMarcarBarrinhasHarald.Text = "Classificar barrinhas de chocolate";
            this.btnMarcarBarrinhasHarald.UseVisualStyleBackColor = true;
            this.btnMarcarBarrinhasHarald.Click += new System.EventHandler(this.btnMarcarBarrinhasHarald_Click);
            // 
            // btnAtualizarCodBarrasHarald
            // 
            this.btnAtualizarCodBarrasHarald.Location = new System.Drawing.Point(6, 135);
            this.btnAtualizarCodBarrasHarald.Name = "btnAtualizarCodBarrasHarald";
            this.btnAtualizarCodBarrasHarald.Size = new System.Drawing.Size(175, 23);
            this.btnAtualizarCodBarrasHarald.TabIndex = 4;
            this.btnAtualizarCodBarrasHarald.Text = "Atualizar cod barras cx";
            this.btnAtualizarCodBarrasHarald.UseVisualStyleBackColor = true;
            this.btnAtualizarCodBarrasHarald.Click += new System.EventHandler(this.btnAtualizarCodBarrasHarald_Click);
            // 
            // btnImportarQtdeUnidade
            // 
            this.btnImportarQtdeUnidade.Location = new System.Drawing.Point(6, 106);
            this.btnImportarQtdeUnidade.Name = "btnImportarQtdeUnidade";
            this.btnImportarQtdeUnidade.Size = new System.Drawing.Size(175, 23);
            this.btnImportarQtdeUnidade.TabIndex = 3;
            this.btnImportarQtdeUnidade.Text = "Importar qtde da unidade";
            this.btnImportarQtdeUnidade.UseVisualStyleBackColor = true;
            this.btnImportarQtdeUnidade.Click += new System.EventHandler(this.btnImportarQtdeUnidade_Click);
            // 
            // btnClassificarMixJmacedo
            // 
            this.btnClassificarMixJmacedo.Location = new System.Drawing.Point(6, 77);
            this.btnClassificarMixJmacedo.Name = "btnClassificarMixJmacedo";
            this.btnClassificarMixJmacedo.Size = new System.Drawing.Size(175, 23);
            this.btnClassificarMixJmacedo.TabIndex = 2;
            this.btnClassificarMixJmacedo.Text = "Classificar Mix Jmacedo";
            this.btnClassificarMixJmacedo.UseVisualStyleBackColor = true;
            this.btnClassificarMixJmacedo.Click += new System.EventHandler(this.btnClassificarMixJmacedo_Click);
            // 
            // btnClassificarFarinhasJmacedo
            // 
            this.btnClassificarFarinhasJmacedo.Location = new System.Drawing.Point(6, 48);
            this.btnClassificarFarinhasJmacedo.Name = "btnClassificarFarinhasJmacedo";
            this.btnClassificarFarinhasJmacedo.Size = new System.Drawing.Size(175, 23);
            this.btnClassificarFarinhasJmacedo.TabIndex = 1;
            this.btnClassificarFarinhasJmacedo.Text = "Classificar Farinhas Jmacedo";
            this.btnClassificarFarinhasJmacedo.UseVisualStyleBackColor = true;
            this.btnClassificarFarinhasJmacedo.Click += new System.EventHandler(this.btnClassificarFarinhasJmacedo_Click);
            // 
            // btnClassificarJmacedo
            // 
            this.btnClassificarJmacedo.Location = new System.Drawing.Point(6, 19);
            this.btnClassificarJmacedo.Name = "btnClassificarJmacedo";
            this.btnClassificarJmacedo.Size = new System.Drawing.Size(175, 23);
            this.btnClassificarJmacedo.TabIndex = 0;
            this.btnClassificarJmacedo.Text = "Classificar JMacedo";
            this.btnClassificarJmacedo.UseVisualStyleBackColor = true;
            this.btnClassificarJmacedo.Click += new System.EventHandler(this.btnClassificarJmacedo_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 185);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(88, 52);
            this.button6.TabIndex = 7;
            this.button6.Text = "Tirar espaços da chave da NF vinculada";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(767, 31);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(182, 23);
            this.button8.TabIndex = 8;
            this.button8.Text = "Correção Produto Celular";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(12, 465);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(108, 56);
            this.button11.TabIndex = 9;
            this.button11.Text = "Importar Produtos Vigor";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(12, 403);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(108, 56);
            this.button12.TabIndex = 10;
            this.button12.Text = "Importar Clientes Vigor";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(12, 341);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(108, 56);
            this.button13.TabIndex = 11;
            this.button13.Text = "Importar Classificação Vigor";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(151, 465);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(108, 56);
            this.button14.TabIndex = 12;
            this.button14.Text = "Recalcular Estoque Produtos";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(151, 403);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(108, 56);
            this.button15.TabIndex = 13;
            this.button15.Text = "Importar Produtos Vigor Novo";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(274, 403);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(108, 56);
            this.button16.TabIndex = 14;
            this.button16.Text = "Importar Produtos Carolina Novo";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(274, 465);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(108, 56);
            this.button17.TabIndex = 15;
            this.button17.Text = "Importar Familias";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(394, 465);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(108, 56);
            this.button18.TabIndex = 16;
            this.button18.Text = "Importar Preços Novos";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(394, 403);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(108, 56);
            this.button19.TabIndex = 17;
            this.button19.Text = "Importar Dia Visita";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(394, 341);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(108, 56);
            this.button20.TabIndex = 18;
            this.button20.Text = "Vincular EAN";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(10, 6);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(108, 56);
            this.button21.TabIndex = 19;
            this.button21.Text = "Importar Produtos outros fornecedores";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(20, 277);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(108, 43);
            this.button22.TabIndex = 20;
            this.button22.Text = "Importar Clientes PPA";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(151, 277);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(108, 43);
            this.button23.TabIndex = 21;
            this.button23.Text = "Importar Produtos PPA";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // tb_cnpj
            // 
            this.tb_cnpj.Location = new System.Drawing.Point(160, 13);
            this.tb_cnpj.Name = "tb_cnpj";
            this.tb_cnpj.Size = new System.Drawing.Size(83, 20);
            this.tb_cnpj.TabIndex = 22;
            // 
            // tb_razao
            // 
            this.tb_razao.Location = new System.Drawing.Point(160, 39);
            this.tb_razao.Name = "tb_razao";
            this.tb_razao.Size = new System.Drawing.Size(83, 20);
            this.tb_razao.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "CNPJ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Razao";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.OliveDrab;
            this.panel3.Controls.Add(this.button21);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.tb_cnpj);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.tb_razao);
            this.panel3.Location = new System.Drawing.Point(142, 326);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(246, 71);
            this.panel3.TabIndex = 26;
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(394, 279);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(108, 56);
            this.button24.TabIndex = 27;
            this.button24.Text = "Importar Preços Custos";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(274, 264);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(108, 56);
            this.button25.TabIndex = 28;
            this.button25.Text = "Gerar contas a pagar ficticias";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.button25_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(534, 498);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(415, 23);
            this.progressBar1.TabIndex = 29;
            // 
            // button27
            // 
            this.button27.Location = new System.Drawing.Point(534, 421);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(113, 23);
            this.button27.TabIndex = 30;
            this.button27.Text = "Custos LLOC";
            this.button27.UseVisualStyleBackColor = true;
            this.button27.Click += new System.EventHandler(this.button27_Click);
            // 
            // button28
            // 
            this.button28.Location = new System.Drawing.Point(734, 241);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(129, 59);
            this.button28.TabIndex = 31;
            this.button28.Text = "Vincular EAN do Produto nas NF Entrada";
            this.button28.UseVisualStyleBackColor = true;
            this.button28.Click += new System.EventHandler(this.button28_Click);
            // 
            // button29
            // 
            this.button29.Location = new System.Drawing.Point(734, 200);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(129, 23);
            this.button29.TabIndex = 32;
            this.button29.Text = "Clientes Simples";
            this.button29.UseVisualStyleBackColor = true;
            this.button29.Click += new System.EventHandler(this.button29_Click);
            // 
            // button30
            // 
            this.button30.Location = new System.Drawing.Point(734, 320);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(108, 56);
            this.button30.TabIndex = 33;
            this.button30.Text = "Importar Fornecedores";
            this.button30.UseVisualStyleBackColor = true;
            this.button30.Click += new System.EventHandler(this.button30_Click);
            // 
            // button31
            // 
            this.button31.Location = new System.Drawing.Point(734, 402);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(113, 40);
            this.button31.TabIndex = 34;
            this.button31.Text = "Data Fechamento PEdido";
            this.button31.UseVisualStyleBackColor = true;
            this.button31.Click += new System.EventHandler(this.button31_Click);
            // 
            // button32
            // 
            this.button32.Location = new System.Drawing.Point(130, 200);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(108, 56);
            this.button32.TabIndex = 35;
            this.button32.Text = "Importar Produtos Dale";
            this.button32.UseVisualStyleBackColor = true;
            this.button32.Click += new System.EventHandler(this.button32_Click);
            // 
            // button33
            // 
            this.button33.Location = new System.Drawing.Point(738, 452);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(103, 32);
            this.button33.TabIndex = 36;
            this.button33.Text = "Importar Roteiros";
            this.button33.UseVisualStyleBackColor = true;
            this.button33.Click += new System.EventHandler(this.button33_Click);
            // 
            // button34
            // 
            this.button34.Location = new System.Drawing.Point(846, 435);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(103, 49);
            this.button34.TabIndex = 37;
            this.button34.Text = "Importar forma pgto no cr";
            this.button34.UseVisualStyleBackColor = true;
            this.button34.Click += new System.EventHandler(this.button34_Click);
            // 
            // button35
            // 
            this.button35.Location = new System.Drawing.Point(846, 320);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(103, 55);
            this.button35.TabIndex = 38;
            this.button35.Text = "Unidade > Caixa";
            this.button35.UseVisualStyleBackColor = true;
            this.button35.Click += new System.EventHandler(this.button35_Click);
            // 
            // button36
            // 
            this.button36.Location = new System.Drawing.Point(734, 73);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(103, 55);
            this.button36.TabIndex = 39;
            this.button36.Text = "NF > COD_NF";
            this.button36.UseVisualStyleBackColor = true;
            this.button36.Click += new System.EventHandler(this.button36_Click);
            // 
            // button37
            // 
            this.button37.Location = new System.Drawing.Point(734, 134);
            this.button37.Name = "button37";
            this.button37.Size = new System.Drawing.Size(103, 55);
            this.button37.TabIndex = 40;
            this.button37.Text = "Importar Forma Pgto";
            this.button37.UseVisualStyleBackColor = true;
            this.button37.Click += new System.EventHandler(this.button37_Click);
            // 
            // button40
            // 
            this.button40.Location = new System.Drawing.Point(869, 235);
            this.button40.Name = "button40";
            this.button40.Size = new System.Drawing.Size(75, 55);
            this.button40.TabIndex = 42;
            this.button40.Text = "Importar SubGrupos";
            this.button40.UseVisualStyleBackColor = true;
            this.button40.Click += new System.EventHandler(this.button40_Click);
            // 
            // button41
            // 
            this.button41.Location = new System.Drawing.Point(534, 457);
            this.button41.Name = "button41";
            this.button41.Size = new System.Drawing.Size(113, 23);
            this.button41.TabIndex = 43;
            this.button41.Text = "Importar CR CP";
            this.button41.UseVisualStyleBackColor = true;
            this.button41.Click += new System.EventHandler(this.button41_Click);
            // 
            // button48
            // 
            this.button48.Location = new System.Drawing.Point(869, 180);
            this.button48.Name = "button48";
            this.button48.Size = new System.Drawing.Size(75, 55);
            this.button48.TabIndex = 44;
            this.button48.Text = "Acertar Cod Produto";
            this.button48.UseVisualStyleBackColor = true;
            this.button48.Click += new System.EventHandler(this.button48_Click);
            // 
            // button49
            // 
            this.button49.Location = new System.Drawing.Point(848, 73);
            this.button49.Name = "button49";
            this.button49.Size = new System.Drawing.Size(103, 49);
            this.button49.TabIndex = 45;
            this.button49.Text = "Importar grupo x dias";
            this.button49.UseVisualStyleBackColor = true;
            this.button49.Click += new System.EventHandler(this.button49_Click);
            // 
            // button50
            // 
            this.button50.Location = new System.Drawing.Point(848, 124);
            this.button50.Name = "button50";
            this.button50.Size = new System.Drawing.Size(103, 49);
            this.button50.TabIndex = 46;
            this.button50.Text = "Importar grupo ";
            this.button50.UseVisualStyleBackColor = true;
            this.button50.Click += new System.EventHandler(this.button50_Click);
            // 
            // button51
            // 
            this.button51.Location = new System.Drawing.Point(854, 382);
            this.button51.Name = "button51";
            this.button51.Size = new System.Drawing.Size(94, 21);
            this.button51.TabIndex = 47;
            this.button51.Text = "EAN";
            this.button51.UseVisualStyleBackColor = true;
            this.button51.Click += new System.EventHandler(this.button51_Click);
            // 
            // button52
            // 
            this.button52.Location = new System.Drawing.Point(854, 404);
            this.button52.Name = "button52";
            this.button52.Size = new System.Drawing.Size(94, 21);
            this.button52.TabIndex = 48;
            this.button52.Text = "Caract";
            this.button52.UseVisualStyleBackColor = true;
            this.button52.Click += new System.EventHandler(this.button52_Click);
            // 
            // button53
            // 
            this.button53.Location = new System.Drawing.Point(653, 416);
            this.button53.Name = "button53";
            this.button53.Size = new System.Drawing.Size(79, 76);
            this.button53.TabIndex = 49;
            this.button53.Text = "Acerto Empresa Emissora Pedido CR";
            this.button53.UseVisualStyleBackColor = true;
            this.button53.Click += new System.EventHandler(this.button53_Click);
            // 
            // form_crono_excel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 533);
            this.Controls.Add(this.button53);
            this.Controls.Add(this.button52);
            this.Controls.Add(this.button51);
            this.Controls.Add(this.button50);
            this.Controls.Add(this.button49);
            this.Controls.Add(this.button48);
            this.Controls.Add(this.button41);
            this.Controls.Add(this.button40);
            this.Controls.Add(this.button37);
            this.Controls.Add(this.button36);
            this.Controls.Add(this.button35);
            this.Controls.Add(this.button34);
            this.Controls.Add(this.button33);
            this.Controls.Add(this.button32);
            this.Controls.Add(this.button31);
            this.Controls.Add(this.button30);
            this.Controls.Add(this.button29);
            this.Controls.Add(this.button28);
            this.Controls.Add(this.button27);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvCrono);
            this.Name = "form_crono_excel";
            this.Text = "Tirar espaços da Chave da NF Vinculada";
            this.Load += new System.EventHandler(this.form_crono_excel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCrono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsContas_a_pagar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CONTAS_A_PAGAR)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCrono;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datContas_a_pagar;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
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
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbContas_a_pagar;
        private System.Windows.Forms.Button button1;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datProdutos;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand8;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand6;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand5;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand7;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datItens_nf_entrada;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand12;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand10;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand9;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnClassificarJmacedo;
        private System.Windows.Forms.Button btnClassificarFarinhasJmacedo;
        private System.Windows.Forms.Button btnClassificarMixJmacedo;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnImportarQtdeUnidade;
        private System.Windows.Forms.Button btnAtualizarCodBarrasHarald;
        private System.Windows.Forms.Button btnRecalcularEstoqueHarald;
        private System.Windows.Forms.Button btnMarcarBarrinhasHarald;
        private System.Windows.Forms.Button btnRecalcularEstoqueJmacedo;
        private System.Windows.Forms.Button btnInativarProdutos;
        private System.Windows.Forms.Button btnInativarClientes;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.TextBox tb_cnpj;
        private System.Windows.Forms.TextBox tb_razao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAtualizarPrecoCuto;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.Button button35;
        private System.Windows.Forms.Button button36;
        private System.Windows.Forms.Button button37;
        private System.Windows.Forms.Button button38;
        private System.Windows.Forms.Button button39;
        private System.Windows.Forms.Button button40;
        private System.Windows.Forms.Button button41;
        private System.Windows.Forms.Button button42;
        private System.Windows.Forms.Button button43;
        private System.Windows.Forms.Button button44;
        private System.Windows.Forms.Button button45;
        private System.Windows.Forms.Button button46;
        private System.Windows.Forms.Button button47;
        private System.Windows.Forms.Button button48;
        private System.Windows.Forms.Button button49;
        private System.Windows.Forms.Button button50;
        private System.Windows.Forms.Button button51;
        private System.Windows.Forms.Button button52;
        private System.Windows.Forms.Button button53;
    }
}