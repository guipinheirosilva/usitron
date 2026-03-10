namespace Evolucao
{
    partial class form_criar_ops
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_criar_ops));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.datProdutos = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button11 = new System.Windows.Forms.Button();
            this.cbUrgente = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_op_suficiente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.col_selecionado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_cod_cliente = new System.Windows.Forms.TextBox();
            this.tb_pedido = new System.Windows.Forms.TextBox();
            this.tb_descricao = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_os = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_os_filtro = new System.Windows.Forms.TextBox();
            this.cbDesenhos_Juntos = new System.Windows.Forms.CheckBox();
            this.btn_imprimir_desenho = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.cbUrgente_filtro = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_produto = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_op = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.tb_pedido_pesquisa = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbTodas = new System.Windows.Forms.RadioButton();
            this.naoentreguesCheckbox = new System.Windows.Forms.CheckBox();
            this.data_entradaradioButton = new System.Windows.Forms.RadioButton();
            this.data_saidaradioButton = new System.Windows.Forms.RadioButton();
            this.cb_finalizadas = new System.Windows.Forms.CheckBox();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtTermino = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvOp = new System.Windows.Forms.DataGridView();
            this.col_cod_op = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OP_MAE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PEDIDO_INTERNO_OP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAPDFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNTREGADIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRECOUNITDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cod_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pESOTOTALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoque_atual_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTOQUE_RESERVADO_PRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTOQUE_RESERVA_FECHADA_PRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTOQUE_ENCOMENDADO_PRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTOQUE_SEPARADO_PRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTOQUE_DISPONIVEL_PRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qDEFABDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pDFACEITOEMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nFNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qDEPDFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qDEESTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qDEEMBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qDECAIXASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nPDFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mATERIALOPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fINALIZADOOPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.URGENTE_OP = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IMPRESSO_OP = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.eNTREGOUDIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oBSERVACOESOPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_os = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dataColumn8 = new System.Data.DataColumn();
            this.dataColumn9 = new System.Data.DataColumn();
            this.dataColumn10 = new System.Data.DataColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.datOp = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand8 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand6 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand5 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand7 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.cbOp = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOp)).BeginInit();
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
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.cbUrgente);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tb_op_suficiente);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.dgvProdutos);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tb_cod_cliente);
            this.panel1.Controls.Add(this.tb_pedido);
            this.panel1.Controls.Add(this.tb_descricao);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1168, 357);
            this.panel1.TabIndex = 1;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(393, 16);
            this.button11.Margin = new System.Windows.Forms.Padding(2);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(122, 24);
            this.button11.TabIndex = 27;
            this.button11.Text = "Marcar Todas OPs";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // cbUrgente
            // 
            this.cbUrgente.AutoSize = true;
            this.cbUrgente.Location = new System.Drawing.Point(767, 32);
            this.cbUrgente.Name = "cbUrgente";
            this.cbUrgente.Size = new System.Drawing.Size(64, 30);
            this.cbUrgente.TabIndex = 26;
            this.cbUrgente.Text = "OP\r\nUrgente";
            this.cbUrgente.UseVisualStyleBackColor = true;
            this.cbUrgente.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1046, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 26);
            this.label7.TabIndex = 25;
            this.label7.Text = "OP Suficiente\r\n*Marcar 1 para estoque";
            // 
            // tb_op_suficiente
            // 
            this.tb_op_suficiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_op_suficiente.Location = new System.Drawing.Point(1049, 37);
            this.tb_op_suficiente.Name = "tb_op_suficiente";
            this.tb_op_suficiente.Size = new System.Drawing.Size(56, 29);
            this.tb_op_suficiente.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(201, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Descrição";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Cód. Produto";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button8.Location = new System.Drawing.Point(834, 19);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(206, 43);
            this.button8.TabIndex = 20;
            this.button8.Text = "Marcar como Produção Não Necessária";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_selecionado});
            this.dgvProdutos.Location = new System.Drawing.Point(8, 72);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(1144, 271);
            this.dgvProdutos.TabIndex = 19;
            this.dgvProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellContentClick);
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
            this.label3.Location = new System.Drawing.Point(9, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 26);
            this.label3.TabIndex = 18;
            this.label3.Text = "Cód. Pedido\r\n Interno:";
            // 
            // tb_cod_cliente
            // 
            this.tb_cod_cliente.Location = new System.Drawing.Point(83, 46);
            this.tb_cod_cliente.Name = "tb_cod_cliente";
            this.tb_cod_cliente.Size = new System.Drawing.Size(105, 20);
            this.tb_cod_cliente.TabIndex = 3;
            this.tb_cod_cliente.TextChanged += new System.EventHandler(this.tb_cod_cliente_TextChanged);
            // 
            // tb_pedido
            // 
            this.tb_pedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_pedido.Location = new System.Drawing.Point(83, 23);
            this.tb_pedido.Name = "tb_pedido";
            this.tb_pedido.Size = new System.Drawing.Size(105, 20);
            this.tb_pedido.TabIndex = 4;
            this.tb_pedido.TextChanged += new System.EventHandler(this.tb_pedido_TextChanged);
            // 
            // tb_descricao
            // 
            this.tb_descricao.Location = new System.Drawing.Point(262, 46);
            this.tb_descricao.Name = "tb_descricao";
            this.tb_descricao.Size = new System.Drawing.Size(254, 20);
            this.tb_descricao.TabIndex = 2;
            this.tb_descricao.TextChanged += new System.EventHandler(this.tb_descricao_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(540, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 43);
            this.button1.TabIndex = 3;
            this.button1.Text = "Crias OS Selecionadas>>>";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.tb_os);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.tb_os_filtro);
            this.panel2.Controls.Add(this.cbDesenhos_Juntos);
            this.panel2.Controls.Add(this.btn_imprimir_desenho);
            this.panel2.Controls.Add(this.button10);
            this.panel2.Controls.Add(this.cbUrgente_filtro);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.tb_produto);
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.tb_op);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.tb_pedido_pesquisa);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.dgvOp);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(4, 366);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1168, 377);
            this.panel2.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(190, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 15);
            this.label11.TabIndex = 42;
            this.label11.Text = "OS:";
            // 
            // tb_os
            // 
            this.tb_os.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_os.Location = new System.Drawing.Point(221, 10);
            this.tb_os.Name = "tb_os";
            this.tb_os.Size = new System.Drawing.Size(68, 21);
            this.tb_os.TabIndex = 41;
            this.tb_os.TextChanged += new System.EventHandler(this.tb_os_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(585, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 15);
            this.label10.TabIndex = 40;
            this.label10.Text = "Filtrar OS:";
            this.label10.Visible = false;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // tb_os_filtro
            // 
            this.tb_os_filtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_os_filtro.Location = new System.Drawing.Point(647, 101);
            this.tb_os_filtro.Name = "tb_os_filtro";
            this.tb_os_filtro.Size = new System.Drawing.Size(68, 21);
            this.tb_os_filtro.TabIndex = 39;
            this.tb_os_filtro.Visible = false;
            this.tb_os_filtro.TextChanged += new System.EventHandler(this.tb_os_filtro_TextChanged);
            // 
            // cbDesenhos_Juntos
            // 
            this.cbDesenhos_Juntos.AutoSize = true;
            this.cbDesenhos_Juntos.Location = new System.Drawing.Point(523, 38);
            this.cbDesenhos_Juntos.Name = "cbDesenhos_Juntos";
            this.cbDesenhos_Juntos.Size = new System.Drawing.Size(152, 17);
            this.cbDesenhos_Juntos.TabIndex = 38;
            this.cbDesenhos_Juntos.Text = "Imprimir Desenhos Juntos?";
            this.cbDesenhos_Juntos.UseVisualStyleBackColor = true;
            this.cbDesenhos_Juntos.Visible = false;
            // 
            // btn_imprimir_desenho
            // 
            this.btn_imprimir_desenho.Location = new System.Drawing.Point(619, 9);
            this.btn_imprimir_desenho.Name = "btn_imprimir_desenho";
            this.btn_imprimir_desenho.Size = new System.Drawing.Size(108, 23);
            this.btn_imprimir_desenho.TabIndex = 37;
            this.btn_imprimir_desenho.Text = "Imprimir Desenhos";
            this.btn_imprimir_desenho.UseVisualStyleBackColor = true;
            this.btn_imprimir_desenho.Click += new System.EventHandler(this.btn_imprimir_desenho_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(997, 71);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(78, 48);
            this.button10.TabIndex = 36;
            this.button10.Text = "Desmarcar como Urgente";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // cbUrgente_filtro
            // 
            this.cbUrgente_filtro.AutoSize = true;
            this.cbUrgente_filtro.Location = new System.Drawing.Point(927, 102);
            this.cbUrgente_filtro.Name = "cbUrgente_filtro";
            this.cbUrgente_filtro.Size = new System.Drawing.Size(64, 17);
            this.cbUrgente_filtro.TabIndex = 35;
            this.cbUrgente_filtro.Text = "Urgente";
            this.cbUrgente_filtro.UseVisualStyleBackColor = true;
            this.cbUrgente_filtro.CheckedChanged += new System.EventHandler(this.cbUrgente_filtro_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(721, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 15);
            this.label9.TabIndex = 34;
            this.label9.Text = "Filtrar Produto:";
            // 
            // tb_produto
            // 
            this.tb_produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_produto.Location = new System.Drawing.Point(818, 100);
            this.tb_produto.Name = "tb_produto";
            this.tb_produto.Size = new System.Drawing.Size(103, 21);
            this.tb_produto.TabIndex = 33;
            this.tb_produto.TextChanged += new System.EventHandler(this.tb_produto_TextChanged);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(1081, 70);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(57, 48);
            this.button9.TabIndex = 32;
            this.button9.Text = "Marcar como Urgente";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(391, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 15);
            this.label8.TabIndex = 31;
            this.label8.Text = "Filtrar OS:";
            // 
            // tb_op
            // 
            this.tb_op.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_op.Location = new System.Drawing.Point(460, 100);
            this.tb_op.Name = "tb_op";
            this.tb_op.Size = new System.Drawing.Size(103, 21);
            this.tb_op.TabIndex = 30;
            this.tb_op.TextChanged += new System.EventHandler(this.tb_op_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(182, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "Filtrar Pedido:";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(451, 43);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(66, 52);
            this.button7.TabIndex = 29;
            this.button7.Text = "Pesquisar";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(401, 9);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(98, 23);
            this.button6.TabIndex = 17;
            this.button6.Text = "Salvar OS";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // tb_pedido_pesquisa
            // 
            this.tb_pedido_pesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_pedido_pesquisa.Location = new System.Drawing.Point(279, 100);
            this.tb_pedido_pesquisa.Name = "tb_pedido_pesquisa";
            this.tb_pedido_pesquisa.Size = new System.Drawing.Size(103, 21);
            this.tb_pedido_pesquisa.TabIndex = 19;
            this.tb_pedido_pesquisa.TextChanged += new System.EventHandler(this.tb_pedido_pesquisa_TextChanged);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button5.Location = new System.Drawing.Point(847, 9);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(108, 23);
            this.button5.TabIndex = 16;
            this.button5.Text = "Finalizar OS";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel3.Controls.Add(this.rbTodas);
            this.panel3.Controls.Add(this.naoentreguesCheckbox);
            this.panel3.Controls.Add(this.data_entradaradioButton);
            this.panel3.Controls.Add(this.data_saidaradioButton);
            this.panel3.Controls.Add(this.cb_finalizadas);
            this.panel3.Location = new System.Drawing.Point(177, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(268, 51);
            this.panel3.TabIndex = 28;
            // 
            // rbTodas
            // 
            this.rbTodas.AutoSize = true;
            this.rbTodas.Location = new System.Drawing.Point(210, 3);
            this.rbTodas.Name = "rbTodas";
            this.rbTodas.Size = new System.Drawing.Size(55, 17);
            this.rbTodas.TabIndex = 30;
            this.rbTodas.TabStop = true;
            this.rbTodas.Text = "Todas";
            this.rbTodas.UseVisualStyleBackColor = true;
            // 
            // naoentreguesCheckbox
            // 
            this.naoentreguesCheckbox.AutoSize = true;
            this.naoentreguesCheckbox.Location = new System.Drawing.Point(159, 27);
            this.naoentreguesCheckbox.Name = "naoentreguesCheckbox";
            this.naoentreguesCheckbox.Size = new System.Drawing.Size(101, 17);
            this.naoentreguesCheckbox.TabIndex = 29;
            this.naoentreguesCheckbox.Text = "Não Finalizadas";
            this.naoentreguesCheckbox.UseVisualStyleBackColor = true;
            // 
            // data_entradaradioButton
            // 
            this.data_entradaradioButton.AutoSize = true;
            this.data_entradaradioButton.Location = new System.Drawing.Point(121, 4);
            this.data_entradaradioButton.Name = "data_entradaradioButton";
            this.data_entradaradioButton.Size = new System.Drawing.Size(88, 17);
            this.data_entradaradioButton.TabIndex = 28;
            this.data_entradaradioButton.TabStop = true;
            this.data_entradaradioButton.Text = "Data Entrada";
            this.data_entradaradioButton.UseVisualStyleBackColor = true;
            // 
            // data_saidaradioButton
            // 
            this.data_saidaradioButton.AutoSize = true;
            this.data_saidaradioButton.Location = new System.Drawing.Point(11, 4);
            this.data_saidaradioButton.Name = "data_saidaradioButton";
            this.data_saidaradioButton.Size = new System.Drawing.Size(104, 17);
            this.data_saidaradioButton.TabIndex = 0;
            this.data_saidaradioButton.TabStop = true;
            this.data_saidaradioButton.Text = "Data Finalização";
            this.data_saidaradioButton.UseVisualStyleBackColor = true;
            // 
            // cb_finalizadas
            // 
            this.cb_finalizadas.AutoSize = true;
            this.cb_finalizadas.Location = new System.Drawing.Point(11, 27);
            this.cb_finalizadas.Name = "cb_finalizadas";
            this.cb_finalizadas.Size = new System.Drawing.Size(117, 17);
            this.cb_finalizadas.TabIndex = 0;
            this.cb_finalizadas.Text = "Apenas Finalizadas";
            this.cb_finalizadas.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button4.Location = new System.Drawing.Point(733, 9);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "Excluir OS";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dtTermino);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtInicio);
            this.groupBox2.Location = new System.Drawing.Point(3, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(168, 72);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Intervalos de Datas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Término";
            // 
            // dtTermino
            // 
            this.dtTermino.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTermino.Location = new System.Drawing.Point(57, 43);
            this.dtTermino.Name = "dtTermino";
            this.dtTermino.Size = new System.Drawing.Size(95, 20);
            this.dtTermino.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inicio";
            // 
            // dtInicio
            // 
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicio.Location = new System.Drawing.Point(57, 19);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(95, 20);
            this.dtInicio.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(505, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Imprimir OP";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgvOp
            // 
            this.dgvOp.AllowUserToAddRows = false;
            this.dgvOp.AllowUserToDeleteRows = false;
            this.dgvOp.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_cod_op,
            this.OP_MAE,
            this.PEDIDO_INTERNO_OP,
            this.dATAPDFDataGridViewTextBoxColumn,
            this.eNTREGADIADataGridViewTextBoxColumn,
            this.col_status,
            this.pRECOUNITDataGridViewTextBoxColumn,
            this.col_cod_produto,
            this.pESOTOTALDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.estoque_atual_produto,
            this.ESTOQUE_RESERVADO_PRODUTO,
            this.ESTOQUE_RESERVA_FECHADA_PRODUTO,
            this.ESTOQUE_ENCOMENDADO_PRODUTO,
            this.ESTOQUE_SEPARADO_PRODUTO,
            this.ESTOQUE_DISPONIVEL_PRODUTO,
            this.qDEFABDataGridViewTextBoxColumn,
            this.pDFACEITOEMDataGridViewTextBoxColumn,
            this.nFNDataGridViewTextBoxColumn,
            this.qDEPDFDataGridViewTextBoxColumn,
            this.qDEESTDataGridViewTextBoxColumn,
            this.qDEEMBDataGridViewTextBoxColumn,
            this.qDECAIXASDataGridViewTextBoxColumn,
            this.nPDFDataGridViewTextBoxColumn,
            this.mATERIALOPDataGridViewTextBoxColumn,
            this.fINALIZADOOPDataGridViewTextBoxColumn,
            this.URGENTE_OP,
            this.IMPRESSO_OP,
            this.eNTREGOUDIADataGridViewTextBoxColumn,
            this.oBSERVACOESOPDataGridViewTextBoxColumn,
            this.col_os});
            this.dgvOp.DataMember = "OP";
            this.dgvOp.DataSource = this.dsOp;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOp.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOp.Location = new System.Drawing.Point(3, 125);
            this.dgvOp.Name = "dgvOp";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOp.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOp.Size = new System.Drawing.Size(1135, 215);
            this.dgvOp.TabIndex = 0;
            this.dgvOp.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOp_CellDoubleClick);
            this.dgvOp.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvOp_RowsRemoved);
            // 
            // col_cod_op
            // 
            this.col_cod_op.DataPropertyName = "COD_OP";
            this.col_cod_op.HeaderText = "OP";
            this.col_cod_op.Name = "col_cod_op";
            this.col_cod_op.ReadOnly = true;
            this.col_cod_op.Width = 30;
            // 
            // OP_MAE
            // 
            this.OP_MAE.DataPropertyName = "OP_MAE";
            this.OP_MAE.HeaderText = "OP Mãe";
            this.OP_MAE.Name = "OP_MAE";
            this.OP_MAE.Visible = false;
            this.OP_MAE.Width = 30;
            // 
            // PEDIDO_INTERNO_OP
            // 
            this.PEDIDO_INTERNO_OP.DataPropertyName = "PEDIDO_INTERNO_OP";
            this.PEDIDO_INTERNO_OP.HeaderText = "Pedido/OS";
            this.PEDIDO_INTERNO_OP.Name = "PEDIDO_INTERNO_OP";
            this.PEDIDO_INTERNO_OP.Width = 50;
            // 
            // dATAPDFDataGridViewTextBoxColumn
            // 
            this.dATAPDFDataGridViewTextBoxColumn.DataPropertyName = "DATA_PDF";
            this.dATAPDFDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dATAPDFDataGridViewTextBoxColumn.Name = "dATAPDFDataGridViewTextBoxColumn";
            this.dATAPDFDataGridViewTextBoxColumn.Width = 60;
            // 
            // eNTREGADIADataGridViewTextBoxColumn
            // 
            this.eNTREGADIADataGridViewTextBoxColumn.DataPropertyName = "ENTREGA_DIA";
            this.eNTREGADIADataGridViewTextBoxColumn.HeaderText = "Data Entrega";
            this.eNTREGADIADataGridViewTextBoxColumn.Name = "eNTREGADIADataGridViewTextBoxColumn";
            this.eNTREGADIADataGridViewTextBoxColumn.Width = 60;
            // 
            // col_status
            // 
            this.col_status.DataPropertyName = "POSICAO_ATUAL_OP";
            this.col_status.HeaderText = "Status";
            this.col_status.Name = "col_status";
            this.col_status.ReadOnly = true;
            // 
            // pRECOUNITDataGridViewTextBoxColumn
            // 
            this.pRECOUNITDataGridViewTextBoxColumn.DataPropertyName = "PRECO_UNIT";
            this.pRECOUNITDataGridViewTextBoxColumn.HeaderText = "PRECO_UNIT";
            this.pRECOUNITDataGridViewTextBoxColumn.Name = "pRECOUNITDataGridViewTextBoxColumn";
            this.pRECOUNITDataGridViewTextBoxColumn.Visible = false;
            // 
            // col_cod_produto
            // 
            this.col_cod_produto.DataPropertyName = "COND_PGTO";
            this.col_cod_produto.HeaderText = "Cód. Produto";
            this.col_cod_produto.Name = "col_cod_produto";
            this.col_cod_produto.ReadOnly = true;
            this.col_cod_produto.Width = 60;
            // 
            // pESOTOTALDataGridViewTextBoxColumn
            // 
            this.pESOTOTALDataGridViewTextBoxColumn.DataPropertyName = "PESO_TOTAL";
            this.pESOTOTALDataGridViewTextBoxColumn.HeaderText = "PESO_TOTAL";
            this.pESOTOTALDataGridViewTextBoxColumn.Name = "pESOTOTALDataGridViewTextBoxColumn";
            this.pESOTOTALDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DESCRICAO_FERRAMENTA_OP";
            this.dataGridViewTextBoxColumn1.HeaderText = "Item";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FERRAMENTA_OP";
            this.dataGridViewTextBoxColumn2.HeaderText = "Ferramenta";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // estoque_atual_produto
            // 
            this.estoque_atual_produto.DataPropertyName = "estoque_atual_produto";
            this.estoque_atual_produto.HeaderText = "Estoque_Atual";
            this.estoque_atual_produto.Name = "estoque_atual_produto";
            this.estoque_atual_produto.Width = 50;
            // 
            // ESTOQUE_RESERVADO_PRODUTO
            // 
            this.ESTOQUE_RESERVADO_PRODUTO.DataPropertyName = "ESTOQUE_RESERVADO_PRODUTO";
            this.ESTOQUE_RESERVADO_PRODUTO.HeaderText = "Necessidade";
            this.ESTOQUE_RESERVADO_PRODUTO.Name = "ESTOQUE_RESERVADO_PRODUTO";
            this.ESTOQUE_RESERVADO_PRODUTO.Width = 50;
            // 
            // ESTOQUE_RESERVA_FECHADA_PRODUTO
            // 
            this.ESTOQUE_RESERVA_FECHADA_PRODUTO.DataPropertyName = "ESTOQUE_RESERVA_FECHADA_PRODUTO";
            this.ESTOQUE_RESERVA_FECHADA_PRODUTO.HeaderText = "Empenhado";
            this.ESTOQUE_RESERVA_FECHADA_PRODUTO.Name = "ESTOQUE_RESERVA_FECHADA_PRODUTO";
            this.ESTOQUE_RESERVA_FECHADA_PRODUTO.Width = 50;
            // 
            // ESTOQUE_ENCOMENDADO_PRODUTO
            // 
            this.ESTOQUE_ENCOMENDADO_PRODUTO.DataPropertyName = "ESTOQUE_ENCOMENDADO_PRODUTO";
            this.ESTOQUE_ENCOMENDADO_PRODUTO.HeaderText = "Producao";
            this.ESTOQUE_ENCOMENDADO_PRODUTO.Name = "ESTOQUE_ENCOMENDADO_PRODUTO";
            this.ESTOQUE_ENCOMENDADO_PRODUTO.Width = 50;
            // 
            // ESTOQUE_SEPARADO_PRODUTO
            // 
            this.ESTOQUE_SEPARADO_PRODUTO.DataPropertyName = "ESTOQUE_SEPARADO_PRODUTO";
            this.ESTOQUE_SEPARADO_PRODUTO.HeaderText = "Separado";
            this.ESTOQUE_SEPARADO_PRODUTO.Name = "ESTOQUE_SEPARADO_PRODUTO";
            this.ESTOQUE_SEPARADO_PRODUTO.Width = 50;
            // 
            // ESTOQUE_DISPONIVEL_PRODUTO
            // 
            this.ESTOQUE_DISPONIVEL_PRODUTO.DataPropertyName = "ESTOQUE_DISPONIVEL_PRODUTO";
            this.ESTOQUE_DISPONIVEL_PRODUTO.HeaderText = "Saldo";
            this.ESTOQUE_DISPONIVEL_PRODUTO.Name = "ESTOQUE_DISPONIVEL_PRODUTO";
            this.ESTOQUE_DISPONIVEL_PRODUTO.Width = 50;
            // 
            // qDEFABDataGridViewTextBoxColumn
            // 
            this.qDEFABDataGridViewTextBoxColumn.DataPropertyName = "QDE_FAB";
            this.qDEFABDataGridViewTextBoxColumn.HeaderText = "Qtde";
            this.qDEFABDataGridViewTextBoxColumn.Name = "qDEFABDataGridViewTextBoxColumn";
            this.qDEFABDataGridViewTextBoxColumn.Width = 50;
            // 
            // pDFACEITOEMDataGridViewTextBoxColumn
            // 
            this.pDFACEITOEMDataGridViewTextBoxColumn.DataPropertyName = "PDF_ACEITO_EM";
            this.pDFACEITOEMDataGridViewTextBoxColumn.HeaderText = "PDF_ACEITO_EM";
            this.pDFACEITOEMDataGridViewTextBoxColumn.Name = "pDFACEITOEMDataGridViewTextBoxColumn";
            this.pDFACEITOEMDataGridViewTextBoxColumn.Visible = false;
            // 
            // nFNDataGridViewTextBoxColumn
            // 
            this.nFNDataGridViewTextBoxColumn.DataPropertyName = "NF_N";
            this.nFNDataGridViewTextBoxColumn.HeaderText = "NF_N";
            this.nFNDataGridViewTextBoxColumn.Name = "nFNDataGridViewTextBoxColumn";
            this.nFNDataGridViewTextBoxColumn.Visible = false;
            // 
            // qDEPDFDataGridViewTextBoxColumn
            // 
            this.qDEPDFDataGridViewTextBoxColumn.DataPropertyName = "QDE_PDF";
            this.qDEPDFDataGridViewTextBoxColumn.HeaderText = "Qtde";
            this.qDEPDFDataGridViewTextBoxColumn.Name = "qDEPDFDataGridViewTextBoxColumn";
            this.qDEPDFDataGridViewTextBoxColumn.Visible = false;
            // 
            // qDEESTDataGridViewTextBoxColumn
            // 
            this.qDEESTDataGridViewTextBoxColumn.DataPropertyName = "QDE_EST";
            this.qDEESTDataGridViewTextBoxColumn.HeaderText = "QDE_EST";
            this.qDEESTDataGridViewTextBoxColumn.Name = "qDEESTDataGridViewTextBoxColumn";
            this.qDEESTDataGridViewTextBoxColumn.Visible = false;
            // 
            // qDEEMBDataGridViewTextBoxColumn
            // 
            this.qDEEMBDataGridViewTextBoxColumn.DataPropertyName = "QDE_EMB";
            this.qDEEMBDataGridViewTextBoxColumn.HeaderText = "QDE_EMB";
            this.qDEEMBDataGridViewTextBoxColumn.Name = "qDEEMBDataGridViewTextBoxColumn";
            this.qDEEMBDataGridViewTextBoxColumn.Visible = false;
            // 
            // qDECAIXASDataGridViewTextBoxColumn
            // 
            this.qDECAIXASDataGridViewTextBoxColumn.DataPropertyName = "QDE_CAIXAS";
            this.qDECAIXASDataGridViewTextBoxColumn.HeaderText = "QDE_CAIXAS";
            this.qDECAIXASDataGridViewTextBoxColumn.Name = "qDECAIXASDataGridViewTextBoxColumn";
            this.qDECAIXASDataGridViewTextBoxColumn.Visible = false;
            // 
            // nPDFDataGridViewTextBoxColumn
            // 
            this.nPDFDataGridViewTextBoxColumn.DataPropertyName = "N_PDF";
            this.nPDFDataGridViewTextBoxColumn.HeaderText = "N_PDF";
            this.nPDFDataGridViewTextBoxColumn.Name = "nPDFDataGridViewTextBoxColumn";
            this.nPDFDataGridViewTextBoxColumn.Visible = false;
            // 
            // mATERIALOPDataGridViewTextBoxColumn
            // 
            this.mATERIALOPDataGridViewTextBoxColumn.DataPropertyName = "MATERIAL_OP";
            this.mATERIALOPDataGridViewTextBoxColumn.HeaderText = "MATERIAL_OP";
            this.mATERIALOPDataGridViewTextBoxColumn.Name = "mATERIALOPDataGridViewTextBoxColumn";
            this.mATERIALOPDataGridViewTextBoxColumn.Visible = false;
            // 
            // fINALIZADOOPDataGridViewTextBoxColumn
            // 
            this.fINALIZADOOPDataGridViewTextBoxColumn.DataPropertyName = "FINALIZADO_OP";
            this.fINALIZADOOPDataGridViewTextBoxColumn.HeaderText = "Finalizado";
            this.fINALIZADOOPDataGridViewTextBoxColumn.Name = "fINALIZADOOPDataGridViewTextBoxColumn";
            this.fINALIZADOOPDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.fINALIZADOOPDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.fINALIZADOOPDataGridViewTextBoxColumn.Width = 30;
            // 
            // URGENTE_OP
            // 
            this.URGENTE_OP.DataPropertyName = "URGENTE_OP";
            this.URGENTE_OP.HeaderText = "Urg.";
            this.URGENTE_OP.Name = "URGENTE_OP";
            this.URGENTE_OP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.URGENTE_OP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.URGENTE_OP.Width = 30;
            // 
            // IMPRESSO_OP
            // 
            this.IMPRESSO_OP.DataPropertyName = "IMPRESSO_OP";
            this.IMPRESSO_OP.FalseValue = "0";
            this.IMPRESSO_OP.HeaderText = "Imp.";
            this.IMPRESSO_OP.IndeterminateValue = "0";
            this.IMPRESSO_OP.Name = "IMPRESSO_OP";
            this.IMPRESSO_OP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IMPRESSO_OP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IMPRESSO_OP.TrueValue = "1";
            this.IMPRESSO_OP.Width = 30;
            // 
            // eNTREGOUDIADataGridViewTextBoxColumn
            // 
            this.eNTREGOUDIADataGridViewTextBoxColumn.DataPropertyName = "ENTREGOU_DIA";
            this.eNTREGOUDIADataGridViewTextBoxColumn.HeaderText = "Data Finalização";
            this.eNTREGOUDIADataGridViewTextBoxColumn.Name = "eNTREGOUDIADataGridViewTextBoxColumn";
            this.eNTREGOUDIADataGridViewTextBoxColumn.ReadOnly = true;
            this.eNTREGOUDIADataGridViewTextBoxColumn.Width = 60;
            // 
            // oBSERVACOESOPDataGridViewTextBoxColumn
            // 
            this.oBSERVACOESOPDataGridViewTextBoxColumn.DataPropertyName = "OBSERVACOES_OP";
            this.oBSERVACOESOPDataGridViewTextBoxColumn.HeaderText = "Observações";
            this.oBSERVACOESOPDataGridViewTextBoxColumn.Name = "oBSERVACOESOPDataGridViewTextBoxColumn";
            this.oBSERVACOESOPDataGridViewTextBoxColumn.Width = 600;
            // 
            // col_os
            // 
            this.col_os.DataPropertyName = "DESENHO_OP_ATUAL";
            this.col_os.HeaderText = "OS";
            this.col_os.Name = "col_os";
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
            this.dataColumn7,
            this.dataColumn8,
            this.dataColumn9,
            this.dataColumn10});
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
            // dataColumn8
            // 
            this.dataColumn8.ColumnName = "ESTOQUE_SEPARADO_PRODUTO";
            this.dataColumn8.DataType = typeof(double);
            // 
            // dataColumn9
            // 
            this.dataColumn9.ColumnName = "URGENTE_OP";
            this.dataColumn9.DataType = typeof(int);
            // 
            // dataColumn10
            // 
            this.dataColumn10.ColumnName = "IMPRESSO_OP";
            this.dataColumn10.DataType = typeof(int);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(297, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Selecionar OS";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // form_criar_ops
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 763);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "form_criar_ops";
            this.Text = "Criar OS";
            this.Load += new System.EventHandler(this.form_criar_ops_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOp)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvOp;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox tb_descricao;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbOp;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtTermino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox naoentreguesCheckbox;
        private System.Windows.Forms.RadioButton data_entradaradioButton;
        private System.Windows.Forms.RadioButton data_saidaradioButton;
        private System.Windows.Forms.CheckBox cb_finalizadas;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.RadioButton rbTodas;
        private System.Windows.Forms.TextBox tb_cod_cliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_pedido_pesquisa;
        private System.Data.DataColumn dataColumn1;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_selecionado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_pedido;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_op_suficiente;
        private System.Data.DataColumn dataColumn7;
        private System.Data.DataColumn dataColumn8;
        private System.Windows.Forms.CheckBox cbUrgente;
        private System.Data.DataColumn dataColumn9;
        private System.Data.DataColumn dataColumn10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_op;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_produto;
        private System.Windows.Forms.CheckBox cbUrgente_filtro;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button btn_imprimir_desenho;
        private System.Windows.Forms.CheckBox cbDesenhos_Juntos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_os_filtro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_os;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod_op;
        private System.Windows.Forms.DataGridViewTextBoxColumn OP_MAE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PEDIDO_INTERNO_OP;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAPDFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNTREGADIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRECOUNITDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn pESOTOTALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoque_atual_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTOQUE_RESERVADO_PRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTOQUE_RESERVA_FECHADA_PRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTOQUE_ENCOMENDADO_PRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTOQUE_SEPARADO_PRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTOQUE_DISPONIVEL_PRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn qDEFABDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pDFACEITOEMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nFNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qDEPDFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qDEESTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qDEEMBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qDECAIXASDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nPDFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mATERIALOPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn fINALIZADOOPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn URGENTE_OP;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IMPRESSO_OP;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNTREGOUDIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oBSERVACOESOPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_os;
    }
}