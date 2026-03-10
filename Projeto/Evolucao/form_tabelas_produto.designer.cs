namespace Evolucao
{
    partial class form_tabelas_produto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_tabelas_produto));
            this.dgvItens_tp = new System.Windows.Forms.DataGridView();
            this.dsItens_tp = new System.Data.DataSet();
            this.ITENS_TP = new System.Data.DataTable();
            this.COD_ITEM_TP = new System.Data.DataColumn();
            this.COD_TABELA_ITEM_TP = new System.Data.DataColumn();
            this.COD_PRODUTO_ITEM_TP = new System.Data.DataColumn();
            this.DESCRICAO_PRODUTO_ITEM_TP = new System.Data.DataColumn();
            this.PRECO_PRODUTO_ITEM_TP = new System.Data.DataColumn();
            this.dataColumn1 = new System.Data.DataColumn();
            this.tb_cod_tabela = new System.Windows.Forms.TextBox();
            this.dsTabela_preco = new System.Data.DataSet();
            this.TABELA_PRECO = new System.Data.DataTable();
            this.COD_TABELA_PRECO = new System.Data.DataColumn();
            this.NOME_TABELA_PRECO = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNomeTabela = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button9 = new System.Windows.Forms.Button();
            this.cb_forma_pgto = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.btAtualizarTabela = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.datTabela_preco = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.datItens_tp = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand8 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand6 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand5 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand7 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.comando_select = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.datProdutos = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand12 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand10 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand9 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand11 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.cbItens_tp = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.cbTabela_preco = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.fbCommand13 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand14 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand15 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand16 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_porc = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.cODITEMTPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODTABELAITEMTPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODPRODUTOITEMTPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRICAOPRODUTOITEMTPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_preco_minimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR_IPI_ITEM_TP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR_ST_ITEM_TP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens_tp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsItens_tp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITENS_TP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTabela_preco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TABELA_PRECO)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvItens_tp
            // 
            this.dgvItens_tp.AutoGenerateColumns = false;
            this.dgvItens_tp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens_tp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODITEMTPDataGridViewTextBoxColumn,
            this.cODTABELAITEMTPDataGridViewTextBoxColumn,
            this.cODPRODUTOITEMTPDataGridViewTextBoxColumn,
            this.dESCRICAOPRODUTOITEMTPDataGridViewTextBoxColumn,
            this.col_preco,
            this.col_preco_minimo,
            this.VALOR_IPI_ITEM_TP,
            this.VALOR_ST_ITEM_TP});
            this.dgvItens_tp.DataMember = "ITENS_TP";
            this.dgvItens_tp.DataSource = this.dsItens_tp;
            this.dgvItens_tp.Location = new System.Drawing.Point(19, 278);
            this.dgvItens_tp.Name = "dgvItens_tp";
            this.dgvItens_tp.Size = new System.Drawing.Size(564, 364);
            this.dgvItens_tp.TabIndex = 1;
            // 
            // dsItens_tp
            // 
            this.dsItens_tp.DataSetName = "dsItens_tp";
            this.dsItens_tp.Namespace = "http://www.tempuri.org/dsItens_tp.xsd";
            this.dsItens_tp.Tables.AddRange(new System.Data.DataTable[] {
            this.ITENS_TP});
            // 
            // ITENS_TP
            // 
            this.ITENS_TP.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_ITEM_TP,
            this.COD_TABELA_ITEM_TP,
            this.COD_PRODUTO_ITEM_TP,
            this.DESCRICAO_PRODUTO_ITEM_TP,
            this.PRECO_PRODUTO_ITEM_TP,
            this.dataColumn1,
            this.dataColumn3,
            this.dataColumn4});
            this.ITENS_TP.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_ITEM_TP"}, true)});
            this.ITENS_TP.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_ITEM_TP};
            this.ITENS_TP.TableName = "ITENS_TP";
            // 
            // COD_ITEM_TP
            // 
            this.COD_ITEM_TP.AllowDBNull = false;
            this.COD_ITEM_TP.ColumnName = "COD_ITEM_TP";
            this.COD_ITEM_TP.DataType = typeof(int);
            // 
            // COD_TABELA_ITEM_TP
            // 
            this.COD_TABELA_ITEM_TP.ColumnName = "COD_TABELA_ITEM_TP";
            this.COD_TABELA_ITEM_TP.DataType = typeof(int);
            // 
            // COD_PRODUTO_ITEM_TP
            // 
            this.COD_PRODUTO_ITEM_TP.ColumnName = "COD_PRODUTO_ITEM_TP";
            this.COD_PRODUTO_ITEM_TP.DataType = typeof(int);
            // 
            // DESCRICAO_PRODUTO_ITEM_TP
            // 
            this.DESCRICAO_PRODUTO_ITEM_TP.ColumnName = "DESCRICAO_PRODUTO_ITEM_TP";
            this.DESCRICAO_PRODUTO_ITEM_TP.MaxLength = 200;
            // 
            // PRECO_PRODUTO_ITEM_TP
            // 
            this.PRECO_PRODUTO_ITEM_TP.ColumnName = "PRECO_PRODUTO_ITEM_TP";
            this.PRECO_PRODUTO_ITEM_TP.DataType = typeof(double);
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "PRECO_MINIMO_ITEM_TP";
            this.dataColumn1.DataType = typeof(double);
            // 
            // tb_cod_tabela
            // 
            this.tb_cod_tabela.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTabela_preco, "TABELA_PRECO.COD_TABELA_PRECO", true));
            this.tb_cod_tabela.Location = new System.Drawing.Point(104, 15);
            this.tb_cod_tabela.Name = "tb_cod_tabela";
            this.tb_cod_tabela.Size = new System.Drawing.Size(40, 20);
            this.tb_cod_tabela.TabIndex = 2;
            // 
            // dsTabela_preco
            // 
            this.dsTabela_preco.DataSetName = "dsTabela_preco";
            this.dsTabela_preco.Namespace = "http://www.tempuri.org/dsTabela_preco.xsd";
            this.dsTabela_preco.Tables.AddRange(new System.Data.DataTable[] {
            this.TABELA_PRECO});
            // 
            // TABELA_PRECO
            // 
            this.TABELA_PRECO.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_TABELA_PRECO,
            this.NOME_TABELA_PRECO,
            this.dataColumn2,
            this.dataColumn5,
            this.dataColumn6});
            this.TABELA_PRECO.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_TABELA_PRECO"}, true)});
            this.TABELA_PRECO.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_TABELA_PRECO};
            this.TABELA_PRECO.TableName = "TABELA_PRECO";
            // 
            // COD_TABELA_PRECO
            // 
            this.COD_TABELA_PRECO.AllowDBNull = false;
            this.COD_TABELA_PRECO.ColumnName = "COD_TABELA_PRECO";
            this.COD_TABELA_PRECO.DataType = typeof(int);
            // 
            // NOME_TABELA_PRECO
            // 
            this.NOME_TABELA_PRECO.ColumnName = "NOME_TABELA_PRECO";
            this.NOME_TABELA_PRECO.MaxLength = 200;
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "FORMA_PGTO_TABELA_PRECO";
            this.dataColumn2.MaxLength = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cód.:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome da Tabela:";
            // 
            // tbNomeTabela
            // 
            this.tbNomeTabela.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTabela_preco, "TABELA_PRECO.NOME_TABELA_PRECO", true));
            this.tbNomeTabela.Location = new System.Drawing.Point(104, 41);
            this.tbNomeTabela.Name = "tbNomeTabela";
            this.tbNomeTabela.Size = new System.Drawing.Size(234, 20);
            this.tbNomeTabela.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Nova Tabela";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(117, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Excluir Tabela";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(344, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 48);
            this.button3.TabIndex = 8;
            this.button3.Text = "Localizar Tabela";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(223, 9);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Salvar Tabela";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbTipo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbEstado);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.cb_forma_pgto);
            this.groupBox1.Controls.Add(this.label35);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbNomeTabela);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_cod_tabela);
            this.groupBox1.Location = new System.Drawing.Point(19, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(564, 161);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tabela";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(315, 66);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(23, 23);
            this.button9.TabIndex = 223;
            this.button9.Text = "+";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // cb_forma_pgto
            // 
            this.cb_forma_pgto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTabela_preco, "TABELA_PRECO.FORMA_PGTO_TABELA_PRECO", true));
            this.cb_forma_pgto.Location = new System.Drawing.Point(144, 67);
            this.cb_forma_pgto.Name = "cb_forma_pgto";
            this.cb_forma_pgto.ReadOnly = true;
            this.cb_forma_pgto.Size = new System.Drawing.Size(165, 20);
            this.cb_forma_pgto.TabIndex = 221;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(7, 70);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(138, 13);
            this.label35.TabIndex = 222;
            this.label35.Text = "Forma de pagamento: *";
            // 
            // btAtualizarTabela
            // 
            this.btAtualizarTabela.Enabled = false;
            this.btAtualizarTabela.Location = new System.Drawing.Point(329, 9);
            this.btAtualizarTabela.Name = "btAtualizarTabela";
            this.btAtualizarTabela.Size = new System.Drawing.Size(100, 23);
            this.btAtualizarTabela.TabIndex = 10;
            this.btAtualizarTabela.Text = "Atualizar Tabela";
            this.btAtualizarTabela.UseVisualStyleBackColor = true;
            this.btAtualizarTabela.Click += new System.EventHandler(this.btAtualizarTabela_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(11, 9);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "Inserir Produtos";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // datTabela_preco
            // 
            this.datTabela_preco.DeleteCommand = this.fbCommand4;
            this.datTabela_preco.InsertCommand = this.fbCommand2;
            this.datTabela_preco.SelectCommand = this.fbCommand1;
            this.datTabela_preco.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * from tabela_preco";
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
            // datItens_tp
            // 
            this.datItens_tp.DeleteCommand = this.fbCommand8;
            this.datItens_tp.InsertCommand = this.fbCommand6;
            this.datItens_tp.SelectCommand = this.fbCommand5;
            this.datItens_tp.UpdateCommand = this.fbCommand7;
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
            this.fbCommand5.CommandText = "select * from itens_tp";
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
            // datProdutos
            // 
            this.datProdutos.DeleteCommand = this.fbCommand12;
            this.datProdutos.InsertCommand = this.fbCommand10;
            this.datProdutos.SelectCommand = this.fbCommand9;
            this.datProdutos.UpdateCommand = this.fbCommand11;
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
            this.fbCommand9.CommandText = "select * from produtos";
            this.fbCommand9.CommandTimeout = 30;
            this.fbCommand9.Connection = this.fbConnection1;
            // 
            // fbCommand11
            // 
            this.fbCommand11.CommandTimeout = 30;
            // 
            // cbItens_tp
            // 
            this.cbItens_tp.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbItens_tp.DataAdapter = this.datItens_tp;
            this.cbItens_tp.QuotePrefix = "\"";
            this.cbItens_tp.QuoteSuffix = "\"";
            // 
            // cbTabela_preco
            // 
            this.cbTabela_preco.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbTabela_preco.DataAdapter = this.datTabela_preco;
            this.cbTabela_preco.QuotePrefix = "\"";
            this.cbTabela_preco.QuoteSuffix = "\"";
            // 
            // fbCommand13
            // 
            this.fbCommand13.CommandText = "select * from clientes";
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btAtualizarTabela);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(19, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 42);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button5);
            this.panel2.Location = new System.Drawing.Point(19, 229);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(121, 43);
            this.panel2.TabIndex = 12;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.tb_porc);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Location = new System.Drawing.Point(146, 229);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(437, 43);
            this.panel3.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "% Acerto";
            // 
            // tb_porc
            // 
            this.tb_porc.Location = new System.Drawing.Point(67, 11);
            this.tb_porc.Name = "tb_porc";
            this.tb_porc.Size = new System.Drawing.Size(129, 20);
            this.tb_porc.TabIndex = 12;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(202, 9);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 23);
            this.button6.TabIndex = 11;
            this.button6.Text = "Acertar Preços";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // cbTipo
            // 
            this.cbTipo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTabela_preco, "TABELA_PRECO.TIPO_TABELA_PRECO", true));
            this.cbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "",
            "Industrialização",
            "Vendas",
            "Serviços/Prefeitura",
            "Revenda",
            "ConsumidorContribuinte",
            "ConsumidorNaoContribuinte",
            "Atacadista"});
            this.cbTipo.Location = new System.Drawing.Point(12, 114);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(326, 32);
            this.cbTipo.TabIndex = 387;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 386;
            this.label4.Text = "Estado";
            // 
            // cbEstado
            // 
            this.cbEstado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTabela_preco, "TABELA_PRECO.ESTADO_TABELA_PRECO", true));
            this.cbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbEstado.Location = new System.Drawing.Point(351, 114);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(78, 33);
            this.cbEstado.TabIndex = 385;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 384;
            this.label5.Text = "Tipo";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "VALOR_IPI_ITEM_TP";
            this.dataColumn3.DataType = typeof(double);
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "VALOR_ST_ITEM_TP";
            this.dataColumn4.DataType = typeof(double);
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "TIPO_TABELA_PRECO";
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "ESTADO_TABELA_PRECO";
            // 
            // cODITEMTPDataGridViewTextBoxColumn
            // 
            this.cODITEMTPDataGridViewTextBoxColumn.DataPropertyName = "COD_ITEM_TP";
            this.cODITEMTPDataGridViewTextBoxColumn.HeaderText = "Cód.";
            this.cODITEMTPDataGridViewTextBoxColumn.Name = "cODITEMTPDataGridViewTextBoxColumn";
            this.cODITEMTPDataGridViewTextBoxColumn.Visible = false;
            this.cODITEMTPDataGridViewTextBoxColumn.Width = 40;
            // 
            // cODTABELAITEMTPDataGridViewTextBoxColumn
            // 
            this.cODTABELAITEMTPDataGridViewTextBoxColumn.DataPropertyName = "COD_TABELA_ITEM_TP";
            this.cODTABELAITEMTPDataGridViewTextBoxColumn.HeaderText = "COD_TABELA_ITEM_TP";
            this.cODTABELAITEMTPDataGridViewTextBoxColumn.Name = "cODTABELAITEMTPDataGridViewTextBoxColumn";
            this.cODTABELAITEMTPDataGridViewTextBoxColumn.Visible = false;
            // 
            // cODPRODUTOITEMTPDataGridViewTextBoxColumn
            // 
            this.cODPRODUTOITEMTPDataGridViewTextBoxColumn.DataPropertyName = "COD_PRODUTO_ITEM_TP";
            this.cODPRODUTOITEMTPDataGridViewTextBoxColumn.HeaderText = "Cód. Prod.";
            this.cODPRODUTOITEMTPDataGridViewTextBoxColumn.Name = "cODPRODUTOITEMTPDataGridViewTextBoxColumn";
            this.cODPRODUTOITEMTPDataGridViewTextBoxColumn.Width = 40;
            // 
            // dESCRICAOPRODUTOITEMTPDataGridViewTextBoxColumn
            // 
            this.dESCRICAOPRODUTOITEMTPDataGridViewTextBoxColumn.DataPropertyName = "DESCRICAO_PRODUTO_ITEM_TP";
            this.dESCRICAOPRODUTOITEMTPDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.dESCRICAOPRODUTOITEMTPDataGridViewTextBoxColumn.Name = "dESCRICAOPRODUTOITEMTPDataGridViewTextBoxColumn";
            this.dESCRICAOPRODUTOITEMTPDataGridViewTextBoxColumn.Width = 200;
            // 
            // col_preco
            // 
            this.col_preco.DataPropertyName = "PRECO_PRODUTO_ITEM_TP";
            this.col_preco.HeaderText = "Preço Sugerido";
            this.col_preco.Name = "col_preco";
            this.col_preco.Width = 60;
            // 
            // col_preco_minimo
            // 
            this.col_preco_minimo.DataPropertyName = "PRECO_MINIMO_ITEM_TP";
            this.col_preco_minimo.HeaderText = "Preço Mínimo";
            this.col_preco_minimo.Name = "col_preco_minimo";
            this.col_preco_minimo.Width = 60;
            // 
            // VALOR_IPI_ITEM_TP
            // 
            this.VALOR_IPI_ITEM_TP.DataPropertyName = "VALOR_IPI_ITEM_TP";
            this.VALOR_IPI_ITEM_TP.HeaderText = "Valor IPI";
            this.VALOR_IPI_ITEM_TP.Name = "VALOR_IPI_ITEM_TP";
            this.VALOR_IPI_ITEM_TP.Width = 60;
            // 
            // VALOR_ST_ITEM_TP
            // 
            this.VALOR_ST_ITEM_TP.DataPropertyName = "VALOR_ST_ITEM_TP";
            this.VALOR_ST_ITEM_TP.HeaderText = "Valor ST";
            this.VALOR_ST_ITEM_TP.Name = "VALOR_ST_ITEM_TP";
            this.VALOR_ST_ITEM_TP.Width = 60;
            // 
            // form_tabelas_produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 654);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvItens_tp);
            this.Name = "form_tabelas_produto";
            this.Text = "Tabelas Produto";
            this.Load += new System.EventHandler(this.form_tabelas_produto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens_tp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsItens_tp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITENS_TP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTabela_preco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TABELA_PRECO)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvItens_tp;
        private System.Windows.Forms.TextBox tb_cod_tabela;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNomeTabela;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Data.DataSet dsItens_tp;
        private System.Data.DataTable ITENS_TP;
        private System.Data.DataColumn COD_ITEM_TP;
        private System.Data.DataColumn COD_TABELA_ITEM_TP;
        private System.Data.DataColumn COD_PRODUTO_ITEM_TP;
        private System.Data.DataColumn DESCRICAO_PRODUTO_ITEM_TP;
        private System.Data.DataColumn PRECO_PRODUTO_ITEM_TP;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datTabela_preco;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Data.DataSet dsTabela_preco;
        private System.Data.DataTable TABELA_PRECO;
        private System.Data.DataColumn COD_TABELA_PRECO;
        private System.Data.DataColumn NOME_TABELA_PRECO;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datItens_tp;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand8;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand6;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand5;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand7;
        private FirebirdSql.Data.FirebirdClient.FbCommand comando_select;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datProdutos;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand12;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand10;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand9;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand11;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbItens_tp;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbTabela_preco;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand13;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand14;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand15;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand16;
        private System.Windows.Forms.Button btAtualizarTabela;
        private System.Data.DataColumn dataColumn1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_porc;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox cb_forma_pgto;
        private System.Windows.Forms.Label label35;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODITEMTPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODTABELAITEMTPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODPRODUTOITEMTPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRICAOPRODUTOITEMTPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_preco_minimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR_IPI_ITEM_TP;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR_ST_ITEM_TP;
    }
}