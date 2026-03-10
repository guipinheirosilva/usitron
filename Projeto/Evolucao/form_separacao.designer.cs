namespace Evolucao
{
    partial class form_separacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_separacao));
            this.datProdutos = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.col_selecionado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_cod_cliente = new System.Windows.Forms.TextBox();
            this.tb_pedido = new System.Windows.Forms.TextBox();
            this.tb_descricao = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbLiberado = new System.Windows.Forms.CheckBox();
            this.dsLiberacao = new System.Data.DataSet();
            this.LIBERACAO = new System.Data.DataTable();
            this.COD_LIB = new System.Data.DataColumn();
            this.DATA_LIB = new System.Data.DataColumn();
            this.HORA_LIB = new System.Data.DataColumn();
            this.RESPONSAVEL_LIB = new System.Data.DataColumn();
            this.VALOR_LIB = new System.Data.DataColumn();
            this.QTDE_ITENS_LIB = new System.Data.DataColumn();
            this.DISPONIVEL_LIB = new System.Data.DataColumn();
            this.BAIXADO_LIB = new System.Data.DataColumn();
            this.PEDIDO_BAIXA_LIB = new System.Data.DataColumn();
            this.CNPJ_CLIENTE_LIB = new System.Data.DataColumn();
            this.RAZAO_CLIENTE_LIB = new System.Data.DataColumn();
            this.COD_INTERNO_NF_LIB = new System.Data.DataColumn();
            this.CNPJ_EMISSOR_LIB = new System.Data.DataColumn();
            this.RAZAO_EMISSOR_LIB = new System.Data.DataColumn();
            this.TIPO_LIB = new System.Data.DataColumn();
            this.dataColumn15 = new System.Data.DataColumn();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.bt_localizar = new System.Windows.Forms.Button();
            this.bt_excluir = new System.Windows.Forms.Button();
            this.bt_salvar = new System.Windows.Forms.Button();
            this.bt_novo = new System.Windows.Forms.Button();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.dsItens_liberacao = new System.Data.DataSet();
            this.ITENS_LIBERACAO = new System.Data.DataTable();
            this.COD_ITEM_LIB = new System.Data.DataColumn();
            this.COD_LIB_ITEM_LIB = new System.Data.DataColumn();
            this.COD_PRODUTO_ITEM_LIB = new System.Data.DataColumn();
            this.COD_PEDIDO_ITEM_LIB = new System.Data.DataColumn();
            this.COD_ITEM_PEDIDO_ITEM_LIB = new System.Data.DataColumn();
            this.QTDE_ITEM_LIB = new System.Data.DataColumn();
            this.DESCRICAO_ITEM_LIB = new System.Data.DataColumn();
            this.COD_IMPRESSO_ITEM_LIB = new System.Data.DataColumn();
            this.dataColumn8 = new System.Data.DataColumn();
            this.dataColumn9 = new System.Data.DataColumn();
            this.dataColumn10 = new System.Data.DataColumn();
            this.dataColumn11 = new System.Data.DataColumn();
            this.dataColumn12 = new System.Data.DataColumn();
            this.dataColumn13 = new System.Data.DataColumn();
            this.dataColumn14 = new System.Data.DataColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.tb_cliente = new System.Windows.Forms.TextBox();
            this.tb_cnpj_cliente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button26 = new System.Windows.Forms.Button();
            this.tb_descricao_empresa = new System.Windows.Forms.TextBox();
            this.tb_cnpj_empresa = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.tb_cod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dsOp = new System.Data.DataSet();
            this.OP = new System.Data.DataTable();
            this.COD_OP = new System.Data.DataColumn();
            this.DATA_PDF = new System.Data.DataColumn();
            this.ENTREGA_DIA = new System.Data.DataColumn();
            this.ENTREGOU_DIA = new System.Data.DataColumn();
            this.PRECO_UNIT = new System.Data.DataColumn();
            this.COND_PGTO = new System.Data.DataColumn();
            this.PESO_TOTAL = new System.Data.DataColumn();
            this.PDF_ACEITO_EM = new System.Data.DataColumn();
            this.NF_N = new System.Data.DataColumn();
            this.QDE_PDF = new System.Data.DataColumn();
            this.QDE_EST = new System.Data.DataColumn();
            this.QDE_FAB = new System.Data.DataColumn();
            this.QDE_EMB = new System.Data.DataColumn();
            this.QDE_CAIXAS = new System.Data.DataColumn();
            this.DESENHO_OP_ATUAL = new System.Data.DataColumn();
            this.N_PDF = new System.Data.DataColumn();
            this.MATERIAL_OP = new System.Data.DataColumn();
            this.LOTE = new System.Data.DataColumn();
            this.ESPESSURA_OP = new System.Data.DataColumn();
            this.FUNCAO_OP = new System.Data.DataColumn();
            this.FERRAMENTA_OP = new System.Data.DataColumn();
            this.CLIENTE_OP = new System.Data.DataColumn();
            this.FINALIZADO_OP = new System.Data.DataColumn();
            this.POSICAO_ATUAL_OP = new System.Data.DataColumn();
            this.REVISAO_OP = new System.Data.DataColumn();
            this.TRAT_TERMICO_OP = new System.Data.DataColumn();
            this.MATERIAL_FORN_OP = new System.Data.DataColumn();
            this.NF_MATERIAL_OP = new System.Data.DataColumn();
            this.DUREZA_SOLIC_OP = new System.Data.DataColumn();
            this.DUREZA_ENC_OP = new System.Data.DataColumn();
            this.NF_SAIDA_OP = new System.Data.DataColumn();
            this.DATA_NF_SAIDA = new System.Data.DataColumn();
            this.PROCESSO_OP = new System.Data.DataColumn();
            this.CODIGO_OP = new System.Data.DataColumn();
            this.CAMINHO_DESENHO_OP = new System.Data.DataColumn();
            this.FOLHA_OP = new System.Data.DataColumn();
            this.DATA_ENTRADA_OP = new System.Data.DataColumn();
            this.DESCRICAO_FERRAMENTA_OP = new System.Data.DataColumn();
            this.PARALIZADA_OP = new System.Data.DataColumn();
            this.COD_MATERIAL_OP = new System.Data.DataColumn();
            this.MATERIAL_RETIRADO_OP = new System.Data.DataColumn();
            this.QTDE_MATERIAL_OP = new System.Data.DataColumn();
            this.ITEM_COMERCIAL_OP = new System.Data.DataColumn();
            this.PRIORIDADE_OP = new System.Data.DataColumn();
            this.MOTIVO_PRIORIDADE_OP = new System.Data.DataColumn();
            this.OBSERVACOES_OP = new System.Data.DataColumn();
            this.CAMINHO_POSICAO_OP = new System.Data.DataColumn();
            this.CAMINHO_POSICAO_2_OP = new System.Data.DataColumn();
            this.DATA_CADASTRO_OP = new System.Data.DataColumn();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataColumn7 = new System.Data.DataColumn();
            this.datOp = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand8 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand6 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand5 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand7 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.cbOp = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.datLiberacao = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand12 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand10 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand9 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand11 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.datItens_liberacao = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand16 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand14 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand13 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand15 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.cbLiberacao = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.cbItens_liberacao = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.N_PEDIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_COD_ITEM_LIB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COD_FORN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODLIBITEMLIBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_COD_PRODUTO_ITEM_LIB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cod_pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_COD_ITEM_PEDIDO_ITEM_LIB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRICAOITEMLIBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qTDEITEMLIBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODIMPRESSOITEMLIBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PEDIDO_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITEM_PEDIDO_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsLiberacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LIBERACAO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsItens_liberacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITENS_LIBERACAO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OP)).BeginInit();
            this.SuspendLayout();
            // 
            // datProdutos
            // 
            this.datProdutos.DeleteCommand = this.fbCommand4;
            this.datProdutos.InsertCommand = this.fbCommand2;
            this.datProdutos.SelectCommand = this.fbCommand1;
            this.datProdutos.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * from produtos";
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dgvProdutos);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tb_cod_cliente);
            this.panel1.Controls.Add(this.tb_pedido);
            this.panel1.Controls.Add(this.tb_descricao);
            this.panel1.Location = new System.Drawing.Point(5, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1557, 439);
            this.panel1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(1039, 28);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(275, 53);
            this.button2.TabIndex = 25;
            this.button2.Text = "Inserir Itens na Liberação";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(553, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 31);
            this.label1.TabIndex = 24;
            this.label1.Text = "Itens Disponíveis para Separação";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(268, 60);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Item";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 60);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Cód. Produto";
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_selecionado});
            this.dgvProdutos.Location = new System.Drawing.Point(11, 89);
            this.dgvProdutos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(1525, 334);
            this.dgvProdutos.TabIndex = 19;
            // 
            // col_selecionado
            // 
            this.col_selecionado.HeaderText = "OK";
            this.col_selecionado.Name = "col_selecionado";
            this.col_selecionado.Width = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 34);
            this.label3.TabIndex = 18;
            this.label3.Text = "Cód. Pedido\r\n Interno:";
            // 
            // tb_cod_cliente
            // 
            this.tb_cod_cliente.Location = new System.Drawing.Point(111, 57);
            this.tb_cod_cliente.Margin = new System.Windows.Forms.Padding(4);
            this.tb_cod_cliente.Name = "tb_cod_cliente";
            this.tb_cod_cliente.Size = new System.Drawing.Size(139, 22);
            this.tb_cod_cliente.TabIndex = 3;
            this.tb_cod_cliente.TextChanged += new System.EventHandler(this.tb_cod_cliente_TextChanged);
            // 
            // tb_pedido
            // 
            this.tb_pedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_pedido.Location = new System.Drawing.Point(111, 28);
            this.tb_pedido.Margin = new System.Windows.Forms.Padding(4);
            this.tb_pedido.Name = "tb_pedido";
            this.tb_pedido.Size = new System.Drawing.Size(139, 23);
            this.tb_pedido.TabIndex = 4;
            this.tb_pedido.TextChanged += new System.EventHandler(this.tb_pedido_TextChanged);
            // 
            // tb_descricao
            // 
            this.tb_descricao.Location = new System.Drawing.Point(349, 57);
            this.tb_descricao.Margin = new System.Windows.Forms.Padding(4);
            this.tb_descricao.Name = "tb_descricao";
            this.tb_descricao.Size = new System.Drawing.Size(337, 22);
            this.tb_descricao.TabIndex = 2;
            this.tb_descricao.TextChanged += new System.EventHandler(this.tb_descricao_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.cbLiberado);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.bt_localizar);
            this.panel2.Controls.Add(this.bt_excluir);
            this.panel2.Controls.Add(this.bt_salvar);
            this.panel2.Controls.Add(this.bt_novo);
            this.panel2.Controls.Add(this.dgvItens);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.cbTipo);
            this.panel2.Controls.Add(this.tb_cliente);
            this.panel2.Controls.Add(this.tb_cnpj_cliente);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.button26);
            this.panel2.Controls.Add(this.tb_descricao_empresa);
            this.panel2.Controls.Add(this.tb_cnpj_empresa);
            this.panel2.Controls.Add(this.label39);
            this.panel2.Controls.Add(this.tb_cod);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(5, 450);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1557, 506);
            this.panel2.TabIndex = 2;
            // 
            // cbLiberado
            // 
            this.cbLiberado.AutoSize = true;
            this.cbLiberado.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsLiberacao, "LIBERACAO.LIBERADO_FATURAMENTO_LIB", true));
            this.cbLiberado.Location = new System.Drawing.Point(1323, 73);
            this.cbLiberado.Margin = new System.Windows.Forms.Padding(4);
            this.cbLiberado.Name = "cbLiberado";
            this.cbLiberado.Size = new System.Drawing.Size(99, 21);
            this.cbLiberado.TabIndex = 393;
            this.cbLiberado.Text = "LIBERADO";
            this.cbLiberado.UseVisualStyleBackColor = true;
            // 
            // dsLiberacao
            // 
            this.dsLiberacao.DataSetName = "dsLiberacao";
            this.dsLiberacao.Namespace = "http://www.tempuri.org/dsLiberacao.xsd";
            this.dsLiberacao.Tables.AddRange(new System.Data.DataTable[] {
            this.LIBERACAO});
            // 
            // LIBERACAO
            // 
            this.LIBERACAO.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_LIB,
            this.DATA_LIB,
            this.HORA_LIB,
            this.RESPONSAVEL_LIB,
            this.VALOR_LIB,
            this.QTDE_ITENS_LIB,
            this.DISPONIVEL_LIB,
            this.BAIXADO_LIB,
            this.PEDIDO_BAIXA_LIB,
            this.CNPJ_CLIENTE_LIB,
            this.RAZAO_CLIENTE_LIB,
            this.COD_INTERNO_NF_LIB,
            this.CNPJ_EMISSOR_LIB,
            this.RAZAO_EMISSOR_LIB,
            this.TIPO_LIB,
            this.dataColumn15});
            this.LIBERACAO.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_LIB"}, true)});
            this.LIBERACAO.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_LIB};
            this.LIBERACAO.TableName = "LIBERACAO";
            // 
            // COD_LIB
            // 
            this.COD_LIB.AllowDBNull = false;
            this.COD_LIB.ColumnName = "COD_LIB";
            this.COD_LIB.DataType = typeof(int);
            // 
            // DATA_LIB
            // 
            this.DATA_LIB.ColumnName = "DATA_LIB";
            this.DATA_LIB.DataType = typeof(System.DateTime);
            // 
            // HORA_LIB
            // 
            this.HORA_LIB.ColumnName = "HORA_LIB";
            this.HORA_LIB.DataType = typeof(System.DateTime);
            // 
            // RESPONSAVEL_LIB
            // 
            this.RESPONSAVEL_LIB.ColumnName = "RESPONSAVEL_LIB";
            this.RESPONSAVEL_LIB.DataType = typeof(int);
            // 
            // VALOR_LIB
            // 
            this.VALOR_LIB.ColumnName = "VALOR_LIB";
            this.VALOR_LIB.DataType = typeof(double);
            // 
            // QTDE_ITENS_LIB
            // 
            this.QTDE_ITENS_LIB.ColumnName = "QTDE_ITENS_LIB";
            this.QTDE_ITENS_LIB.DataType = typeof(int);
            // 
            // DISPONIVEL_LIB
            // 
            this.DISPONIVEL_LIB.ColumnName = "DISPONIVEL_LIB";
            this.DISPONIVEL_LIB.DataType = typeof(int);
            // 
            // BAIXADO_LIB
            // 
            this.BAIXADO_LIB.ColumnName = "BAIXADO_LIB";
            this.BAIXADO_LIB.DataType = typeof(int);
            // 
            // PEDIDO_BAIXA_LIB
            // 
            this.PEDIDO_BAIXA_LIB.ColumnName = "PEDIDO_BAIXA_LIB";
            this.PEDIDO_BAIXA_LIB.DataType = typeof(int);
            // 
            // CNPJ_CLIENTE_LIB
            // 
            this.CNPJ_CLIENTE_LIB.ColumnName = "CNPJ_CLIENTE_LIB";
            this.CNPJ_CLIENTE_LIB.MaxLength = 20;
            // 
            // RAZAO_CLIENTE_LIB
            // 
            this.RAZAO_CLIENTE_LIB.ColumnName = "RAZAO_CLIENTE_LIB";
            this.RAZAO_CLIENTE_LIB.MaxLength = 200;
            // 
            // COD_INTERNO_NF_LIB
            // 
            this.COD_INTERNO_NF_LIB.ColumnName = "COD_INTERNO_NF_LIB";
            this.COD_INTERNO_NF_LIB.DataType = typeof(int);
            // 
            // CNPJ_EMISSOR_LIB
            // 
            this.CNPJ_EMISSOR_LIB.ColumnName = "CNPJ_EMISSOR_LIB";
            this.CNPJ_EMISSOR_LIB.MaxLength = 20;
            // 
            // RAZAO_EMISSOR_LIB
            // 
            this.RAZAO_EMISSOR_LIB.ColumnName = "RAZAO_EMISSOR_LIB";
            this.RAZAO_EMISSOR_LIB.MaxLength = 200;
            // 
            // TIPO_LIB
            // 
            this.TIPO_LIB.ColumnName = "TIPO_LIB";
            this.TIPO_LIB.MaxLength = 100;
            // 
            // dataColumn15
            // 
            this.dataColumn15.ColumnName = "LIBERADO_FATURAMENTO_LIB";
            this.dataColumn15.DataType = typeof(int);
            // 
            // button6
            // 
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(1443, 5);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(108, 60);
            this.button6.TabIndex = 392;
            this.button6.Text = "Imprimir Faturamento";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // button5
            // 
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(1207, 5);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(108, 60);
            this.button5.TabIndex = 391;
            this.button5.Text = "Imprimir Separação";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button4
            // 
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(1323, 6);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 60);
            this.button4.TabIndex = 390;
            this.button4.Text = "Liberar Faturamento";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(4, 166);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(69, 65);
            this.button3.TabIndex = 389;
            this.button3.Text = "Excluir Item";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // bt_localizar
            // 
            this.bt_localizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_localizar.BackgroundImage")));
            this.bt_localizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_localizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_localizar.Location = new System.Drawing.Point(1123, 5);
            this.bt_localizar.Margin = new System.Windows.Forms.Padding(4);
            this.bt_localizar.Name = "bt_localizar";
            this.bt_localizar.Size = new System.Drawing.Size(76, 60);
            this.bt_localizar.TabIndex = 388;
            this.bt_localizar.UseVisualStyleBackColor = true;
            this.bt_localizar.Click += new System.EventHandler(this.bt_localizar_Click);
            // 
            // bt_excluir
            // 
            this.bt_excluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_excluir.BackgroundImage")));
            this.bt_excluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_excluir.Location = new System.Drawing.Point(1039, 5);
            this.bt_excluir.Margin = new System.Windows.Forms.Padding(4);
            this.bt_excluir.Name = "bt_excluir";
            this.bt_excluir.Size = new System.Drawing.Size(76, 60);
            this.bt_excluir.TabIndex = 387;
            this.bt_excluir.UseVisualStyleBackColor = true;
            this.bt_excluir.Click += new System.EventHandler(this.bt_excluir_Click);
            // 
            // bt_salvar
            // 
            this.bt_salvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_salvar.BackgroundImage")));
            this.bt_salvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_salvar.Location = new System.Drawing.Point(871, 5);
            this.bt_salvar.Margin = new System.Windows.Forms.Padding(4);
            this.bt_salvar.Name = "bt_salvar";
            this.bt_salvar.Size = new System.Drawing.Size(76, 60);
            this.bt_salvar.TabIndex = 386;
            this.bt_salvar.UseVisualStyleBackColor = true;
            this.bt_salvar.Click += new System.EventHandler(this.bt_salvar_Click);
            // 
            // bt_novo
            // 
            this.bt_novo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_novo.BackgroundImage")));
            this.bt_novo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_novo.Location = new System.Drawing.Point(955, 5);
            this.bt_novo.Margin = new System.Windows.Forms.Padding(4);
            this.bt_novo.Name = "bt_novo";
            this.bt_novo.Size = new System.Drawing.Size(76, 60);
            this.bt_novo.TabIndex = 385;
            this.bt_novo.UseVisualStyleBackColor = true;
            this.bt_novo.Click += new System.EventHandler(this.bt_novo_Click);
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.AutoGenerateColumns = false;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.N_PEDIDO,
            this.COL_COD_ITEM_LIB,
            this.COD_FORN,
            this.cODLIBITEMLIBDataGridViewTextBoxColumn,
            this.COL_COD_PRODUTO_ITEM_LIB,
            this.col_cod_pedido,
            this.COL_COD_ITEM_PEDIDO_ITEM_LIB,
            this.dESCRICAOITEMLIBDataGridViewTextBoxColumn,
            this.qTDEITEMLIBDataGridViewTextBoxColumn,
            this.cODIMPRESSOITEMLIBDataGridViewTextBoxColumn,
            this.PEDIDO_CLIENTE,
            this.ITEM_PEDIDO_CLIENTE});
            this.dgvItens.DataMember = "ITENS_LIBERACAO";
            this.dgvItens.DataSource = this.dsItens_liberacao;
            this.dgvItens.Location = new System.Drawing.Point(81, 166);
            this.dgvItens.Margin = new System.Windows.Forms.Padding(4);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.Size = new System.Drawing.Size(1455, 308);
            this.dgvItens.TabIndex = 384;
            // 
            // dsItens_liberacao
            // 
            this.dsItens_liberacao.DataSetName = "dsItens_liberacao";
            this.dsItens_liberacao.Namespace = "http://www.tempuri.org/dsItens_liberacao.xsd";
            this.dsItens_liberacao.Tables.AddRange(new System.Data.DataTable[] {
            this.ITENS_LIBERACAO});
            // 
            // ITENS_LIBERACAO
            // 
            this.ITENS_LIBERACAO.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_ITEM_LIB,
            this.COD_LIB_ITEM_LIB,
            this.COD_PRODUTO_ITEM_LIB,
            this.COD_PEDIDO_ITEM_LIB,
            this.COD_ITEM_PEDIDO_ITEM_LIB,
            this.QTDE_ITEM_LIB,
            this.DESCRICAO_ITEM_LIB,
            this.COD_IMPRESSO_ITEM_LIB,
            this.dataColumn8,
            this.dataColumn9,
            this.dataColumn10,
            this.dataColumn11,
            this.dataColumn12,
            this.dataColumn13,
            this.dataColumn14});
            this.ITENS_LIBERACAO.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_ITEM_LIB"}, true)});
            this.ITENS_LIBERACAO.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_ITEM_LIB};
            this.ITENS_LIBERACAO.TableName = "ITENS_LIBERACAO";
            // 
            // COD_ITEM_LIB
            // 
            this.COD_ITEM_LIB.AllowDBNull = false;
            this.COD_ITEM_LIB.ColumnName = "COD_ITEM_LIB";
            this.COD_ITEM_LIB.DataType = typeof(int);
            // 
            // COD_LIB_ITEM_LIB
            // 
            this.COD_LIB_ITEM_LIB.ColumnName = "COD_LIB_ITEM_LIB";
            this.COD_LIB_ITEM_LIB.DataType = typeof(int);
            // 
            // COD_PRODUTO_ITEM_LIB
            // 
            this.COD_PRODUTO_ITEM_LIB.ColumnName = "COD_PRODUTO_ITEM_LIB";
            this.COD_PRODUTO_ITEM_LIB.DataType = typeof(int);
            // 
            // COD_PEDIDO_ITEM_LIB
            // 
            this.COD_PEDIDO_ITEM_LIB.ColumnName = "COD_PEDIDO_ITEM_LIB";
            this.COD_PEDIDO_ITEM_LIB.DataType = typeof(int);
            // 
            // COD_ITEM_PEDIDO_ITEM_LIB
            // 
            this.COD_ITEM_PEDIDO_ITEM_LIB.ColumnName = "COD_ITEM_PEDIDO_ITEM_LIB";
            this.COD_ITEM_PEDIDO_ITEM_LIB.DataType = typeof(int);
            // 
            // QTDE_ITEM_LIB
            // 
            this.QTDE_ITEM_LIB.ColumnName = "QTDE_ITEM_LIB";
            this.QTDE_ITEM_LIB.DataType = typeof(double);
            // 
            // DESCRICAO_ITEM_LIB
            // 
            this.DESCRICAO_ITEM_LIB.ColumnName = "DESCRICAO_ITEM_LIB";
            this.DESCRICAO_ITEM_LIB.MaxLength = 300;
            // 
            // COD_IMPRESSO_ITEM_LIB
            // 
            this.COD_IMPRESSO_ITEM_LIB.ColumnName = "COD_IMPRESSO_ITEM_LIB";
            this.COD_IMPRESSO_ITEM_LIB.DataType = typeof(int);
            // 
            // dataColumn8
            // 
            this.dataColumn8.ColumnName = "COD_FORN";
            this.dataColumn8.MaxLength = 100;
            // 
            // dataColumn9
            // 
            this.dataColumn9.ColumnName = "N_PEDIDO";
            // 
            // dataColumn10
            // 
            this.dataColumn10.ColumnName = "PEDIDO_CLIENTE";
            // 
            // dataColumn11
            // 
            this.dataColumn11.ColumnName = "ITEM_PEDIDO_CLIENTE";
            // 
            // dataColumn12
            // 
            this.dataColumn12.ColumnName = "VALOR_UNIT_ITEM_VENDA";
            this.dataColumn12.DataType = typeof(double);
            // 
            // dataColumn13
            // 
            this.dataColumn13.ColumnName = "VALOR_TOTAL_ITEM_VENDA";
            this.dataColumn13.DataType = typeof(double);
            // 
            // dataColumn14
            // 
            this.dataColumn14.ColumnName = "LOCALIZACAO";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(437, 11);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(312, 31);
            this.label10.TabIndex = 25;
            this.label10.Text = "Romaneio de Separação";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(807, 137);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 17);
            this.label9.TabIndex = 383;
            this.label9.Text = "Tipo:";
            // 
            // cbTipo
            // 
            this.cbTipo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsLiberacao, "LIBERACAO.TIPO_LIB", true));
            this.cbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "",
            "Industrialização",
            "Vendas"});
            this.cbTipo.Location = new System.Drawing.Point(871, 133);
            this.cbTipo.Margin = new System.Windows.Forms.Padding(4);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(456, 25);
            this.cbTipo.TabIndex = 382;
            this.cbTipo.SelectedValueChanged += new System.EventHandler(this.cbTipo_SelectedValueChanged);
            // 
            // tb_cliente
            // 
            this.tb_cliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsLiberacao, "LIBERACAO.RAZAO_CLIENTE_LIB", true));
            this.tb_cliente.Location = new System.Drawing.Point(351, 129);
            this.tb_cliente.Margin = new System.Windows.Forms.Padding(4);
            this.tb_cliente.Name = "tb_cliente";
            this.tb_cliente.Size = new System.Drawing.Size(281, 22);
            this.tb_cliente.TabIndex = 377;
            // 
            // tb_cnpj_cliente
            // 
            this.tb_cnpj_cliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsLiberacao, "LIBERACAO.CNPJ_CLIENTE_LIB", true));
            this.tb_cnpj_cliente.Location = new System.Drawing.Point(196, 129);
            this.tb_cnpj_cliente.Margin = new System.Windows.Forms.Padding(4);
            this.tb_cnpj_cliente.Name = "tb_cnpj_cliente";
            this.tb_cnpj_cliente.Size = new System.Drawing.Size(149, 22);
            this.tb_cnpj_cliente.TabIndex = 376;
            this.tb_cnpj_cliente.TextChanged += new System.EventHandler(this.tb_cnpj_cliente_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 133);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 17);
            this.label8.TabIndex = 378;
            this.label8.Text = "Cliente/Fornecedor: *";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(641, 127);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 28);
            this.button1.TabIndex = 375;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsLiberacao, "LIBERACAO.RESPONSAVEL_LIB", true));
            this.textBox3.Location = new System.Drawing.Point(520, 97);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(121, 22);
            this.textBox3.TabIndex = 374;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(416, 101);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 17);
            this.label7.TabIndex = 373;
            this.label7.Text = "Responsável:";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsLiberacao, "LIBERACAO.DATA_LIB", true));
            this.textBox2.Location = new System.Drawing.Point(275, 97);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(121, 22);
            this.textBox2.TabIndex = 372;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 101);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 371;
            this.label4.Text = "Data:";
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(1520, 98);
            this.button26.Margin = new System.Windows.Forms.Padding(4);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(31, 28);
            this.button26.TabIndex = 367;
            this.button26.Text = "+";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Visible = false;
            // 
            // tb_descricao_empresa
            // 
            this.tb_descricao_empresa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsLiberacao, "LIBERACAO.RAZAO_EMISSOR_LIB", true));
            this.tb_descricao_empresa.Location = new System.Drawing.Point(1091, 101);
            this.tb_descricao_empresa.Margin = new System.Windows.Forms.Padding(4);
            this.tb_descricao_empresa.Name = "tb_descricao_empresa";
            this.tb_descricao_empresa.ReadOnly = true;
            this.tb_descricao_empresa.Size = new System.Drawing.Size(424, 22);
            this.tb_descricao_empresa.TabIndex = 369;
            // 
            // tb_cnpj_empresa
            // 
            this.tb_cnpj_empresa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsLiberacao, "LIBERACAO.CNPJ_EMISSOR_LIB", true));
            this.tb_cnpj_empresa.Location = new System.Drawing.Point(871, 101);
            this.tb_cnpj_empresa.Margin = new System.Windows.Forms.Padding(4);
            this.tb_cnpj_empresa.Name = "tb_cnpj_empresa";
            this.tb_cnpj_empresa.ReadOnly = true;
            this.tb_cnpj_empresa.Size = new System.Drawing.Size(220, 22);
            this.tb_cnpj_empresa.TabIndex = 368;
            this.tb_cnpj_empresa.TextChanged += new System.EventHandler(this.tb_cnpj_empresa_TextChanged);
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(807, 105);
            this.label39.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(68, 17);
            this.label39.TabIndex = 370;
            this.label39.Text = "Empresa:";
            // 
            // tb_cod
            // 
            this.tb_cod.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsLiberacao, "LIBERACAO.COD_LIB", true));
            this.tb_cod.Location = new System.Drawing.Point(129, 97);
            this.tb_cod.Margin = new System.Windows.Forms.Padding(4);
            this.tb_cod.Name = "tb_cod";
            this.tb_cod.ReadOnly = true;
            this.tb_cod.Size = new System.Drawing.Size(67, 22);
            this.tb_cod.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cód. Liberação:";
            // 
            // dsOp
            // 
            this.dsOp.DataSetName = "dsOp";
            this.dsOp.Namespace = "http://www.tempuri.org/dsOp.xsd";
            this.dsOp.Tables.AddRange(new System.Data.DataTable[] {
            this.OP});
            // 
            // OP
            // 
            this.OP.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_OP,
            this.DATA_PDF,
            this.ENTREGA_DIA,
            this.ENTREGOU_DIA,
            this.PRECO_UNIT,
            this.COND_PGTO,
            this.PESO_TOTAL,
            this.PDF_ACEITO_EM,
            this.NF_N,
            this.QDE_PDF,
            this.QDE_EST,
            this.QDE_FAB,
            this.QDE_EMB,
            this.QDE_CAIXAS,
            this.DESENHO_OP_ATUAL,
            this.N_PDF,
            this.MATERIAL_OP,
            this.LOTE,
            this.ESPESSURA_OP,
            this.FUNCAO_OP,
            this.FERRAMENTA_OP,
            this.CLIENTE_OP,
            this.FINALIZADO_OP,
            this.POSICAO_ATUAL_OP,
            this.REVISAO_OP,
            this.TRAT_TERMICO_OP,
            this.MATERIAL_FORN_OP,
            this.NF_MATERIAL_OP,
            this.DUREZA_SOLIC_OP,
            this.DUREZA_ENC_OP,
            this.NF_SAIDA_OP,
            this.DATA_NF_SAIDA,
            this.PROCESSO_OP,
            this.CODIGO_OP,
            this.CAMINHO_DESENHO_OP,
            this.FOLHA_OP,
            this.DATA_ENTRADA_OP,
            this.DESCRICAO_FERRAMENTA_OP,
            this.PARALIZADA_OP,
            this.COD_MATERIAL_OP,
            this.MATERIAL_RETIRADO_OP,
            this.QTDE_MATERIAL_OP,
            this.ITEM_COMERCIAL_OP,
            this.PRIORIDADE_OP,
            this.MOTIVO_PRIORIDADE_OP,
            this.OBSERVACOES_OP,
            this.CAMINHO_POSICAO_OP,
            this.CAMINHO_POSICAO_2_OP,
            this.DATA_CADASTRO_OP,
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn6,
            this.dataColumn7});
            this.OP.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_OP"}, true)});
            this.OP.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_OP};
            this.OP.TableName = "OP";
            // 
            // COD_OP
            // 
            this.COD_OP.AllowDBNull = false;
            this.COD_OP.ColumnName = "COD_OP";
            this.COD_OP.DataType = typeof(int);
            // 
            // DATA_PDF
            // 
            this.DATA_PDF.ColumnName = "DATA_PDF";
            this.DATA_PDF.DataType = typeof(System.DateTime);
            // 
            // ENTREGA_DIA
            // 
            this.ENTREGA_DIA.ColumnName = "ENTREGA_DIA";
            this.ENTREGA_DIA.DataType = typeof(System.DateTime);
            // 
            // ENTREGOU_DIA
            // 
            this.ENTREGOU_DIA.ColumnName = "ENTREGOU_DIA";
            this.ENTREGOU_DIA.DataType = typeof(System.DateTime);
            // 
            // PRECO_UNIT
            // 
            this.PRECO_UNIT.ColumnName = "PRECO_UNIT";
            this.PRECO_UNIT.MaxLength = 10;
            // 
            // COND_PGTO
            // 
            this.COND_PGTO.ColumnName = "COND_PGTO";
            this.COND_PGTO.MaxLength = 50;
            // 
            // PESO_TOTAL
            // 
            this.PESO_TOTAL.ColumnName = "PESO_TOTAL";
            this.PESO_TOTAL.MaxLength = 10;
            // 
            // PDF_ACEITO_EM
            // 
            this.PDF_ACEITO_EM.ColumnName = "PDF_ACEITO_EM";
            this.PDF_ACEITO_EM.DataType = typeof(System.DateTime);
            // 
            // NF_N
            // 
            this.NF_N.ColumnName = "NF_N";
            this.NF_N.DataType = typeof(int);
            // 
            // QDE_PDF
            // 
            this.QDE_PDF.ColumnName = "QDE_PDF";
            this.QDE_PDF.DataType = typeof(int);
            // 
            // QDE_EST
            // 
            this.QDE_EST.ColumnName = "QDE_EST";
            this.QDE_EST.DataType = typeof(int);
            // 
            // QDE_FAB
            // 
            this.QDE_FAB.ColumnName = "QDE_FAB";
            this.QDE_FAB.DataType = typeof(decimal);
            // 
            // QDE_EMB
            // 
            this.QDE_EMB.ColumnName = "QDE_EMB";
            this.QDE_EMB.DataType = typeof(int);
            // 
            // QDE_CAIXAS
            // 
            this.QDE_CAIXAS.ColumnName = "QDE_CAIXAS";
            this.QDE_CAIXAS.DataType = typeof(int);
            // 
            // DESENHO_OP_ATUAL
            // 
            this.DESENHO_OP_ATUAL.ColumnName = "DESENHO_OP_ATUAL";
            this.DESENHO_OP_ATUAL.MaxLength = 40;
            // 
            // N_PDF
            // 
            this.N_PDF.ColumnName = "N_PDF";
            this.N_PDF.MaxLength = 40;
            // 
            // MATERIAL_OP
            // 
            this.MATERIAL_OP.ColumnName = "MATERIAL_OP";
            this.MATERIAL_OP.MaxLength = 30;
            // 
            // LOTE
            // 
            this.LOTE.ColumnName = "LOTE";
            this.LOTE.MaxLength = 30;
            // 
            // ESPESSURA_OP
            // 
            this.ESPESSURA_OP.ColumnName = "ESPESSURA_OP";
            this.ESPESSURA_OP.MaxLength = 30;
            // 
            // FUNCAO_OP
            // 
            this.FUNCAO_OP.ColumnName = "FUNCAO_OP";
            this.FUNCAO_OP.MaxLength = 50;
            // 
            // FERRAMENTA_OP
            // 
            this.FERRAMENTA_OP.ColumnName = "FERRAMENTA_OP";
            this.FERRAMENTA_OP.MaxLength = 200;
            // 
            // CLIENTE_OP
            // 
            this.CLIENTE_OP.ColumnName = "CLIENTE_OP";
            this.CLIENTE_OP.MaxLength = 3;
            // 
            // FINALIZADO_OP
            // 
            this.FINALIZADO_OP.ColumnName = "FINALIZADO_OP";
            this.FINALIZADO_OP.DataType = typeof(int);
            // 
            // POSICAO_ATUAL_OP
            // 
            this.POSICAO_ATUAL_OP.ColumnName = "POSICAO_ATUAL_OP";
            this.POSICAO_ATUAL_OP.MaxLength = 100;
            // 
            // REVISAO_OP
            // 
            this.REVISAO_OP.ColumnName = "REVISAO_OP";
            this.REVISAO_OP.MaxLength = 30;
            // 
            // TRAT_TERMICO_OP
            // 
            this.TRAT_TERMICO_OP.ColumnName = "TRAT_TERMICO_OP";
            this.TRAT_TERMICO_OP.MaxLength = 50;
            // 
            // MATERIAL_FORN_OP
            // 
            this.MATERIAL_FORN_OP.ColumnName = "MATERIAL_FORN_OP";
            this.MATERIAL_FORN_OP.MaxLength = 100;
            // 
            // NF_MATERIAL_OP
            // 
            this.NF_MATERIAL_OP.ColumnName = "NF_MATERIAL_OP";
            this.NF_MATERIAL_OP.MaxLength = 100;
            // 
            // DUREZA_SOLIC_OP
            // 
            this.DUREZA_SOLIC_OP.ColumnName = "DUREZA_SOLIC_OP";
            this.DUREZA_SOLIC_OP.MaxLength = 30;
            // 
            // DUREZA_ENC_OP
            // 
            this.DUREZA_ENC_OP.ColumnName = "DUREZA_ENC_OP";
            this.DUREZA_ENC_OP.MaxLength = 30;
            // 
            // NF_SAIDA_OP
            // 
            this.NF_SAIDA_OP.ColumnName = "NF_SAIDA_OP";
            this.NF_SAIDA_OP.DataType = typeof(int);
            // 
            // DATA_NF_SAIDA
            // 
            this.DATA_NF_SAIDA.ColumnName = "DATA_NF_SAIDA";
            this.DATA_NF_SAIDA.DataType = typeof(System.DateTime);
            // 
            // PROCESSO_OP
            // 
            this.PROCESSO_OP.ColumnName = "PROCESSO_OP";
            this.PROCESSO_OP.MaxLength = 50;
            // 
            // CODIGO_OP
            // 
            this.CODIGO_OP.ColumnName = "CODIGO_OP";
            this.CODIGO_OP.MaxLength = 30;
            // 
            // CAMINHO_DESENHO_OP
            // 
            this.CAMINHO_DESENHO_OP.ColumnName = "CAMINHO_DESENHO_OP";
            this.CAMINHO_DESENHO_OP.MaxLength = 100;
            // 
            // FOLHA_OP
            // 
            this.FOLHA_OP.ColumnName = "FOLHA_OP";
            this.FOLHA_OP.MaxLength = 200;
            // 
            // DATA_ENTRADA_OP
            // 
            this.DATA_ENTRADA_OP.ColumnName = "DATA_ENTRADA_OP";
            this.DATA_ENTRADA_OP.DataType = typeof(System.DateTime);
            // 
            // DESCRICAO_FERRAMENTA_OP
            // 
            this.DESCRICAO_FERRAMENTA_OP.ColumnName = "DESCRICAO_FERRAMENTA_OP";
            this.DESCRICAO_FERRAMENTA_OP.MaxLength = 300;
            // 
            // PARALIZADA_OP
            // 
            this.PARALIZADA_OP.ColumnName = "PARALIZADA_OP";
            this.PARALIZADA_OP.DataType = typeof(int);
            // 
            // COD_MATERIAL_OP
            // 
            this.COD_MATERIAL_OP.ColumnName = "COD_MATERIAL_OP";
            this.COD_MATERIAL_OP.DataType = typeof(int);
            // 
            // MATERIAL_RETIRADO_OP
            // 
            this.MATERIAL_RETIRADO_OP.ColumnName = "MATERIAL_RETIRADO_OP";
            this.MATERIAL_RETIRADO_OP.DataType = typeof(int);
            // 
            // QTDE_MATERIAL_OP
            // 
            this.QTDE_MATERIAL_OP.ColumnName = "QTDE_MATERIAL_OP";
            this.QTDE_MATERIAL_OP.DataType = typeof(int);
            // 
            // ITEM_COMERCIAL_OP
            // 
            this.ITEM_COMERCIAL_OP.ColumnName = "ITEM_COMERCIAL_OP";
            this.ITEM_COMERCIAL_OP.DataType = typeof(int);
            // 
            // PRIORIDADE_OP
            // 
            this.PRIORIDADE_OP.ColumnName = "PRIORIDADE_OP";
            this.PRIORIDADE_OP.MaxLength = 100;
            // 
            // MOTIVO_PRIORIDADE_OP
            // 
            this.MOTIVO_PRIORIDADE_OP.ColumnName = "MOTIVO_PRIORIDADE_OP";
            this.MOTIVO_PRIORIDADE_OP.MaxLength = 200;
            // 
            // OBSERVACOES_OP
            // 
            this.OBSERVACOES_OP.ColumnName = "OBSERVACOES_OP";
            this.OBSERVACOES_OP.MaxLength = 200;
            // 
            // CAMINHO_POSICAO_OP
            // 
            this.CAMINHO_POSICAO_OP.ColumnName = "CAMINHO_POSICAO_OP";
            this.CAMINHO_POSICAO_OP.MaxLength = 400;
            // 
            // CAMINHO_POSICAO_2_OP
            // 
            this.CAMINHO_POSICAO_2_OP.ColumnName = "CAMINHO_POSICAO_2_OP";
            this.CAMINHO_POSICAO_2_OP.MaxLength = 400;
            // 
            // DATA_CADASTRO_OP
            // 
            this.DATA_CADASTRO_OP.ColumnName = "DATA_CADASTRO_OP";
            this.DATA_CADASTRO_OP.DataType = typeof(System.DateTime);
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "PEDIDO_INTERNO_OP";
            this.dataColumn1.DataType = typeof(int);
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "ESTOQUE_RESERVADO_PRODUTO";
            this.dataColumn2.DataType = typeof(double);
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "estoque_atual_produto";
            this.dataColumn3.DataType = typeof(double);
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "ESTOQUE_RESERVA_FECHADA_PRODUTO";
            this.dataColumn4.DataType = typeof(double);
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "ESTOQUE_ENCOMENDADO_PRODUTO";
            this.dataColumn5.DataType = typeof(int);
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "ESTOQUE_DISPONIVEL_PRODUTO";
            this.dataColumn6.DataType = typeof(int);
            // 
            // dataColumn7
            // 
            this.dataColumn7.ColumnName = "OP_MAE";
            this.dataColumn7.DataType = typeof(int);
            // 
            // datOp
            // 
            this.datOp.DeleteCommand = this.fbCommand8;
            this.datOp.InsertCommand = this.fbCommand6;
            this.datOp.SelectCommand = this.fbCommand5;
            this.datOp.UpdateCommand = this.fbCommand7;
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
            this.fbCommand5.CommandText = "select * from op";
            this.fbCommand5.CommandTimeout = 30;
            this.fbCommand5.Connection = this.fbConnection1;
            // 
            // fbCommand7
            // 
            this.fbCommand7.CommandTimeout = 30;
            // 
            // cbOp
            // 
            this.cbOp.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbOp.DataAdapter = this.datOp;
            this.cbOp.QuotePrefix = "\"";
            this.cbOp.QuoteSuffix = "\"";
            // 
            // datLiberacao
            // 
            this.datLiberacao.DeleteCommand = this.fbCommand12;
            this.datLiberacao.InsertCommand = this.fbCommand10;
            this.datLiberacao.SelectCommand = this.fbCommand9;
            this.datLiberacao.UpdateCommand = this.fbCommand11;
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
            this.fbCommand9.CommandText = "select * from liberacao";
            this.fbCommand9.CommandTimeout = 30;
            this.fbCommand9.Connection = this.fbConnection1;
            // 
            // fbCommand11
            // 
            this.fbCommand11.CommandTimeout = 30;
            // 
            // datItens_liberacao
            // 
            this.datItens_liberacao.DeleteCommand = this.fbCommand16;
            this.datItens_liberacao.InsertCommand = this.fbCommand14;
            this.datItens_liberacao.SelectCommand = this.fbCommand13;
            this.datItens_liberacao.UpdateCommand = this.fbCommand15;
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
            this.fbCommand13.CommandText = "select * from itens_liberacao";
            this.fbCommand13.CommandTimeout = 30;
            this.fbCommand13.Connection = this.fbConnection1;
            // 
            // fbCommand15
            // 
            this.fbCommand15.CommandTimeout = 30;
            // 
            // cbLiberacao
            // 
            this.cbLiberacao.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbLiberacao.DataAdapter = this.datLiberacao;
            this.cbLiberacao.QuotePrefix = "\"";
            this.cbLiberacao.QuoteSuffix = "\"";
            // 
            // cbItens_liberacao
            // 
            this.cbItens_liberacao.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbItens_liberacao.DataAdapter = this.datItens_liberacao;
            this.cbItens_liberacao.QuotePrefix = "\"";
            this.cbItens_liberacao.QuoteSuffix = "\"";
            // 
            // N_PEDIDO
            // 
            this.N_PEDIDO.DataPropertyName = "N_PEDIDO";
            this.N_PEDIDO.HeaderText = "Pedido";
            this.N_PEDIDO.Name = "N_PEDIDO";
            this.N_PEDIDO.ReadOnly = true;
            // 
            // COL_COD_ITEM_LIB
            // 
            this.COL_COD_ITEM_LIB.DataPropertyName = "COD_ITEM_LIB";
            this.COL_COD_ITEM_LIB.HeaderText = "COD_ITEM_LIB";
            this.COL_COD_ITEM_LIB.Name = "COL_COD_ITEM_LIB";
            this.COL_COD_ITEM_LIB.ReadOnly = true;
            this.COL_COD_ITEM_LIB.Visible = false;
            // 
            // COD_FORN
            // 
            this.COD_FORN.DataPropertyName = "COD_FORN";
            this.COD_FORN.HeaderText = "Cód. Produto";
            this.COD_FORN.Name = "COD_FORN";
            this.COD_FORN.ReadOnly = true;
            this.COD_FORN.Width = 200;
            // 
            // cODLIBITEMLIBDataGridViewTextBoxColumn
            // 
            this.cODLIBITEMLIBDataGridViewTextBoxColumn.DataPropertyName = "COD_LIB_ITEM_LIB";
            this.cODLIBITEMLIBDataGridViewTextBoxColumn.HeaderText = "COD_LIB_ITEM_LIB";
            this.cODLIBITEMLIBDataGridViewTextBoxColumn.Name = "cODLIBITEMLIBDataGridViewTextBoxColumn";
            this.cODLIBITEMLIBDataGridViewTextBoxColumn.ReadOnly = true;
            this.cODLIBITEMLIBDataGridViewTextBoxColumn.Visible = false;
            // 
            // COL_COD_PRODUTO_ITEM_LIB
            // 
            this.COL_COD_PRODUTO_ITEM_LIB.DataPropertyName = "COD_PRODUTO_ITEM_LIB";
            this.COL_COD_PRODUTO_ITEM_LIB.HeaderText = "Cód. Produto";
            this.COL_COD_PRODUTO_ITEM_LIB.Name = "COL_COD_PRODUTO_ITEM_LIB";
            this.COL_COD_PRODUTO_ITEM_LIB.ReadOnly = true;
            this.COL_COD_PRODUTO_ITEM_LIB.Visible = false;
            // 
            // col_cod_pedido
            // 
            this.col_cod_pedido.DataPropertyName = "COD_PEDIDO_ITEM_LIB";
            this.col_cod_pedido.HeaderText = "Cod. Pedido Interno";
            this.col_cod_pedido.Name = "col_cod_pedido";
            this.col_cod_pedido.ReadOnly = true;
            this.col_cod_pedido.Visible = false;
            // 
            // COL_COD_ITEM_PEDIDO_ITEM_LIB
            // 
            this.COL_COD_ITEM_PEDIDO_ITEM_LIB.DataPropertyName = "COD_ITEM_PEDIDO_ITEM_LIB";
            this.COL_COD_ITEM_PEDIDO_ITEM_LIB.HeaderText = "COD_ITEM_PEDIDO_ITEM_LIB";
            this.COL_COD_ITEM_PEDIDO_ITEM_LIB.Name = "COL_COD_ITEM_PEDIDO_ITEM_LIB";
            this.COL_COD_ITEM_PEDIDO_ITEM_LIB.ReadOnly = true;
            this.COL_COD_ITEM_PEDIDO_ITEM_LIB.Visible = false;
            // 
            // dESCRICAOITEMLIBDataGridViewTextBoxColumn
            // 
            this.dESCRICAOITEMLIBDataGridViewTextBoxColumn.DataPropertyName = "DESCRICAO_ITEM_LIB";
            this.dESCRICAOITEMLIBDataGridViewTextBoxColumn.HeaderText = "Item";
            this.dESCRICAOITEMLIBDataGridViewTextBoxColumn.Name = "dESCRICAOITEMLIBDataGridViewTextBoxColumn";
            this.dESCRICAOITEMLIBDataGridViewTextBoxColumn.ReadOnly = true;
            this.dESCRICAOITEMLIBDataGridViewTextBoxColumn.Width = 300;
            // 
            // qTDEITEMLIBDataGridViewTextBoxColumn
            // 
            this.qTDEITEMLIBDataGridViewTextBoxColumn.DataPropertyName = "QTDE_ITEM_LIB";
            this.qTDEITEMLIBDataGridViewTextBoxColumn.HeaderText = "Qtde";
            this.qTDEITEMLIBDataGridViewTextBoxColumn.Name = "qTDEITEMLIBDataGridViewTextBoxColumn";
            this.qTDEITEMLIBDataGridViewTextBoxColumn.ReadOnly = true;
            this.qTDEITEMLIBDataGridViewTextBoxColumn.Width = 80;
            // 
            // cODIMPRESSOITEMLIBDataGridViewTextBoxColumn
            // 
            this.cODIMPRESSOITEMLIBDataGridViewTextBoxColumn.DataPropertyName = "COD_IMPRESSO_ITEM_LIB";
            this.cODIMPRESSOITEMLIBDataGridViewTextBoxColumn.HeaderText = "COD_IMPRESSO_ITEM_LIB";
            this.cODIMPRESSOITEMLIBDataGridViewTextBoxColumn.Name = "cODIMPRESSOITEMLIBDataGridViewTextBoxColumn";
            this.cODIMPRESSOITEMLIBDataGridViewTextBoxColumn.ReadOnly = true;
            this.cODIMPRESSOITEMLIBDataGridViewTextBoxColumn.Visible = false;
            // 
            // PEDIDO_CLIENTE
            // 
            this.PEDIDO_CLIENTE.DataPropertyName = "PEDIDO_CLIENTE";
            this.PEDIDO_CLIENTE.HeaderText = "Pedido Cliente";
            this.PEDIDO_CLIENTE.Name = "PEDIDO_CLIENTE";
            this.PEDIDO_CLIENTE.ReadOnly = true;
            // 
            // ITEM_PEDIDO_CLIENTE
            // 
            this.ITEM_PEDIDO_CLIENTE.DataPropertyName = "ITEM_PEDIDO_CLIENTE";
            this.ITEM_PEDIDO_CLIENTE.HeaderText = "Item Pedido Cliente";
            this.ITEM_PEDIDO_CLIENTE.Name = "ITEM_PEDIDO_CLIENTE";
            this.ITEM_PEDIDO_CLIENTE.ReadOnly = true;
            // 
            // form_separacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1579, 939);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form_separacao";
            this.Text = "Romaneio de Liberação";
            this.Load += new System.EventHandler(this.form_criar_ops_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsLiberacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LIBERACAO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsItens_liberacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITENS_LIBERACAO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datProdutos;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Data.DataSet dsOp;
        private System.Data.DataTable OP;
        private System.Data.DataColumn COD_OP;
        private System.Data.DataColumn DATA_PDF;
        private System.Data.DataColumn ENTREGA_DIA;
        private System.Data.DataColumn ENTREGOU_DIA;
        private System.Data.DataColumn PRECO_UNIT;
        private System.Data.DataColumn COND_PGTO;
        private System.Data.DataColumn PESO_TOTAL;
        private System.Data.DataColumn PDF_ACEITO_EM;
        private System.Data.DataColumn NF_N;
        private System.Data.DataColumn QDE_PDF;
        private System.Data.DataColumn QDE_EST;
        private System.Data.DataColumn QDE_FAB;
        private System.Data.DataColumn QDE_EMB;
        private System.Data.DataColumn QDE_CAIXAS;
        private System.Data.DataColumn DESENHO_OP_ATUAL;
        private System.Data.DataColumn N_PDF;
        private System.Data.DataColumn MATERIAL_OP;
        private System.Data.DataColumn LOTE;
        private System.Data.DataColumn ESPESSURA_OP;
        private System.Data.DataColumn FUNCAO_OP;
        private System.Data.DataColumn FERRAMENTA_OP;
        private System.Data.DataColumn CLIENTE_OP;
        private System.Data.DataColumn FINALIZADO_OP;
        private System.Data.DataColumn POSICAO_ATUAL_OP;
        private System.Data.DataColumn REVISAO_OP;
        private System.Data.DataColumn TRAT_TERMICO_OP;
        private System.Data.DataColumn MATERIAL_FORN_OP;
        private System.Data.DataColumn NF_MATERIAL_OP;
        private System.Data.DataColumn DUREZA_SOLIC_OP;
        private System.Data.DataColumn DUREZA_ENC_OP;
        private System.Data.DataColumn NF_SAIDA_OP;
        private System.Data.DataColumn DATA_NF_SAIDA;
        private System.Data.DataColumn PROCESSO_OP;
        private System.Data.DataColumn CODIGO_OP;
        private System.Data.DataColumn CAMINHO_DESENHO_OP;
        private System.Data.DataColumn FOLHA_OP;
        private System.Data.DataColumn DATA_ENTRADA_OP;
        private System.Data.DataColumn DESCRICAO_FERRAMENTA_OP;
        private System.Data.DataColumn PARALIZADA_OP;
        private System.Data.DataColumn COD_MATERIAL_OP;
        private System.Data.DataColumn MATERIAL_RETIRADO_OP;
        private System.Data.DataColumn QTDE_MATERIAL_OP;
        private System.Data.DataColumn ITEM_COMERCIAL_OP;
        private System.Data.DataColumn PRIORIDADE_OP;
        private System.Data.DataColumn MOTIVO_PRIORIDADE_OP;
        private System.Data.DataColumn OBSERVACOES_OP;
        private System.Data.DataColumn CAMINHO_POSICAO_OP;
        private System.Data.DataColumn CAMINHO_POSICAO_2_OP;
        private System.Data.DataColumn DATA_CADASTRO_OP;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datOp;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand8;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand6;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand5;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand7;
        private System.Windows.Forms.TextBox tb_descricao;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbOp;
        private System.Windows.Forms.TextBox tb_cod_cliente;
        private System.Data.DataColumn dataColumn1;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_selecionado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_pedido;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Data.DataColumn dataColumn7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_cod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.TextBox tb_descricao_empresa;
        private System.Windows.Forms.TextBox tb_cnpj_empresa;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_cliente;
        private System.Windows.Forms.TextBox tb_cnpj_cliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Button bt_localizar;
        private System.Windows.Forms.Button bt_excluir;
        private System.Windows.Forms.Button bt_salvar;
        private System.Windows.Forms.Button bt_novo;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datLiberacao;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand12;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand10;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand9;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand11;
        private System.Data.DataSet dsLiberacao;
        private System.Data.DataTable LIBERACAO;
        private System.Data.DataColumn COD_LIB;
        private System.Data.DataColumn DATA_LIB;
        private System.Data.DataColumn HORA_LIB;
        private System.Data.DataColumn RESPONSAVEL_LIB;
        private System.Data.DataColumn VALOR_LIB;
        private System.Data.DataColumn QTDE_ITENS_LIB;
        private System.Data.DataColumn DISPONIVEL_LIB;
        private System.Data.DataColumn BAIXADO_LIB;
        private System.Data.DataColumn PEDIDO_BAIXA_LIB;
        private System.Data.DataColumn CNPJ_CLIENTE_LIB;
        private System.Data.DataColumn RAZAO_CLIENTE_LIB;
        private System.Data.DataColumn COD_INTERNO_NF_LIB;
        private System.Data.DataColumn CNPJ_EMISSOR_LIB;
        private System.Data.DataColumn RAZAO_EMISSOR_LIB;
        private System.Data.DataColumn TIPO_LIB;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datItens_liberacao;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand16;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand14;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand13;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand15;
        private System.Data.DataSet dsItens_liberacao;
        private System.Data.DataTable ITENS_LIBERACAO;
        private System.Data.DataColumn COD_ITEM_LIB;
        private System.Data.DataColumn COD_LIB_ITEM_LIB;
        private System.Data.DataColumn COD_PRODUTO_ITEM_LIB;
        private System.Data.DataColumn COD_PEDIDO_ITEM_LIB;
        private System.Data.DataColumn COD_ITEM_PEDIDO_ITEM_LIB;
        private System.Data.DataColumn QTDE_ITEM_LIB;
        private System.Data.DataColumn DESCRICAO_ITEM_LIB;
        private System.Data.DataColumn COD_IMPRESSO_ITEM_LIB;
        private System.Windows.Forms.Button button2;
        private System.Data.DataColumn dataColumn8;
        private System.Data.DataColumn dataColumn9;
        private System.Data.DataColumn dataColumn10;
        private System.Data.DataColumn dataColumn11;
        private System.Windows.Forms.Button button3;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbLiberacao;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbItens_liberacao;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox cbLiberado;
        private System.Data.DataColumn dataColumn12;
        private System.Data.DataColumn dataColumn13;
        private System.Data.DataColumn dataColumn14;
        private System.Data.DataColumn dataColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn N_PEDIDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_COD_ITEM_LIB;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_FORN;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODLIBITEMLIBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_COD_PRODUTO_ITEM_LIB;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod_pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_COD_ITEM_PEDIDO_ITEM_LIB;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRICAOITEMLIBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qTDEITEMLIBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODIMPRESSOITEMLIBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PEDIDO_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEM_PEDIDO_CLIENTE;
    }
}