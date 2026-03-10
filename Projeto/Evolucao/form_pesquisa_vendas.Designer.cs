namespace Evolucao
{
    partial class form_pesquisa_vendas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_pesquisa_vendas));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtFinal = new System.Windows.Forms.DateTimePicker();
            this.dtInicial = new System.Windows.Forms.DateTimePicker();
            this.dgvSelect = new System.Windows.Forms.DataGridView();
            this.cbPdv = new System.Windows.Forms.CheckBox();
            this.cbPedidos = new System.Windows.Forms.CheckBox();
            this.gpOrigem = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.ckbFornecedor = new System.Windows.Forms.CheckBox();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.txtCodFornecedor = new System.Windows.Forms.TextBox();
            this.btnFornecedor = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.cbBonificacao = new System.Windows.Forms.CheckBox();
            this.cbTroca = new System.Windows.Forms.CheckBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.cbCidade = new System.Windows.Forms.CheckBox();
            this.tb_cidade = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tb_cod_produto = new System.Windows.Forms.TextBox();
            this.cbProduto = new System.Windows.Forms.CheckBox();
            this.tb_descricao_produto = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tb_cod_cliente = new System.Windows.Forms.TextBox();
            this.cb_cliente = new System.Windows.Forms.CheckBox();
            this.tb_nome_cliente = new System.Windows.Forms.TextBox();
            this.btnAddCliente = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cb_vendedor = new System.Windows.Forms.CheckBox();
            this.tb_nome_vendedor = new System.Windows.Forms.TextBox();
            this.tb_cod_vendedor = new System.Windows.Forms.TextBox();
            this.btnAddVendedor = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cbFechados = new System.Windows.Forms.CheckBox();
            this.cbSomatorio = new System.Windows.Forms.CheckBox();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_qtde = new System.Windows.Forms.TextBox();
            this.tb_valor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.cb_data_entrega = new System.Windows.Forms.CheckBox();
            this.cb_data_entrada = new System.Windows.Forms.CheckBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelect)).BeginInit();
            this.gpOrigem.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtFinal);
            this.groupBox2.Controls.Add(this.dtInicial);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(112, 79);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Período";
            // 
            // dtFinal
            // 
            this.dtFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFinal.Location = new System.Drawing.Point(6, 45);
            this.dtFinal.Name = "dtFinal";
            this.dtFinal.Size = new System.Drawing.Size(97, 20);
            this.dtFinal.TabIndex = 1;
            // 
            // dtInicial
            // 
            this.dtInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicial.Location = new System.Drawing.Point(6, 19);
            this.dtInicial.Name = "dtInicial";
            this.dtInicial.Size = new System.Drawing.Size(97, 20);
            this.dtInicial.TabIndex = 0;
            // 
            // dgvSelect
            // 
            this.dgvSelect.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSelect.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSelect.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSelect.Location = new System.Drawing.Point(5, 167);
            this.dgvSelect.Name = "dgvSelect";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSelect.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSelect.Size = new System.Drawing.Size(979, 478);
            this.dgvSelect.TabIndex = 2;
            // 
            // cbPdv
            // 
            this.cbPdv.AutoSize = true;
            this.cbPdv.Location = new System.Drawing.Point(6, 22);
            this.cbPdv.Name = "cbPdv";
            this.cbPdv.Size = new System.Drawing.Size(48, 17);
            this.cbPdv.TabIndex = 3;
            this.cbPdv.Text = "PDV";
            this.cbPdv.UseVisualStyleBackColor = true;
            // 
            // cbPedidos
            // 
            this.cbPedidos.AutoSize = true;
            this.cbPedidos.Location = new System.Drawing.Point(6, 45);
            this.cbPedidos.Name = "cbPedidos";
            this.cbPedidos.Size = new System.Drawing.Size(64, 17);
            this.cbPedidos.TabIndex = 4;
            this.cbPedidos.Text = "Pedidos";
            this.cbPedidos.UseVisualStyleBackColor = true;
            // 
            // gpOrigem
            // 
            this.gpOrigem.Controls.Add(this.cbPedidos);
            this.gpOrigem.Controls.Add(this.cbPdv);
            this.gpOrigem.Location = new System.Drawing.Point(130, 12);
            this.gpOrigem.Name = "gpOrigem";
            this.gpOrigem.Size = new System.Drawing.Size(84, 65);
            this.gpOrigem.TabIndex = 5;
            this.gpOrigem.TabStop = false;
            this.gpOrigem.Text = "Origem";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox10);
            this.groupBox1.Controls.Add(this.groupBox9);
            this.groupBox1.Controls.Add(this.groupBox7);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Location = new System.Drawing.Point(220, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 155);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.lblCnpj);
            this.groupBox10.Controls.Add(this.ckbFornecedor);
            this.groupBox10.Controls.Add(this.txtFornecedor);
            this.groupBox10.Controls.Add(this.txtCodFornecedor);
            this.groupBox10.Controls.Add(this.btnFornecedor);
            this.groupBox10.Location = new System.Drawing.Point(270, 109);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(253, 39);
            this.groupBox10.TabIndex = 283;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Fornecedor";
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.Location = new System.Drawing.Point(207, 23);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(0, 13);
            this.lblCnpj.TabIndex = 283;
            this.lblCnpj.Visible = false;
            // 
            // ckbFornecedor
            // 
            this.ckbFornecedor.AutoSize = true;
            this.ckbFornecedor.Location = new System.Drawing.Point(232, 16);
            this.ckbFornecedor.Name = "ckbFornecedor";
            this.ckbFornecedor.Size = new System.Drawing.Size(15, 14);
            this.ckbFornecedor.TabIndex = 282;
            this.ckbFornecedor.UseVisualStyleBackColor = true;
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.BackColor = System.Drawing.SystemColors.Control;
            this.txtFornecedor.Location = new System.Drawing.Point(59, 13);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(121, 20);
            this.txtFornecedor.TabIndex = 1;
            // 
            // txtCodFornecedor
            // 
            this.txtCodFornecedor.BackColor = System.Drawing.SystemColors.Control;
            this.txtCodFornecedor.Location = new System.Drawing.Point(12, 13);
            this.txtCodFornecedor.Name = "txtCodFornecedor";
            this.txtCodFornecedor.Size = new System.Drawing.Size(41, 20);
            this.txtCodFornecedor.TabIndex = 0;
            // 
            // btnFornecedor
            // 
            this.btnFornecedor.Location = new System.Drawing.Point(186, 11);
            this.btnFornecedor.Name = "btnFornecedor";
            this.btnFornecedor.Size = new System.Drawing.Size(23, 23);
            this.btnFornecedor.TabIndex = 279;
            this.btnFornecedor.Text = "+";
            this.btnFornecedor.UseVisualStyleBackColor = true;
            this.btnFornecedor.Click += new System.EventHandler(this.btnFornecedor_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.cbBonificacao);
            this.groupBox9.Controls.Add(this.cbTroca);
            this.groupBox9.Location = new System.Drawing.Point(6, 104);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(253, 45);
            this.groupBox9.TabIndex = 283;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Tipo";
            // 
            // cbBonificacao
            // 
            this.cbBonificacao.AutoSize = true;
            this.cbBonificacao.Location = new System.Drawing.Point(72, 22);
            this.cbBonificacao.Name = "cbBonificacao";
            this.cbBonificacao.Size = new System.Drawing.Size(82, 17);
            this.cbBonificacao.TabIndex = 1;
            this.cbBonificacao.Text = "Bonificação";
            this.cbBonificacao.UseVisualStyleBackColor = true;
            // 
            // cbTroca
            // 
            this.cbTroca.AutoSize = true;
            this.cbTroca.Location = new System.Drawing.Point(12, 22);
            this.cbTroca.Name = "cbTroca";
            this.cbTroca.Size = new System.Drawing.Size(54, 17);
            this.cbTroca.TabIndex = 0;
            this.cbTroca.Text = "Troca";
            this.cbTroca.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.cbCidade);
            this.groupBox7.Controls.Add(this.tb_cidade);
            this.groupBox7.Location = new System.Drawing.Point(265, 64);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(253, 39);
            this.groupBox7.TabIndex = 283;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Cidade";
            // 
            // cbCidade
            // 
            this.cbCidade.AutoSize = true;
            this.cbCidade.Location = new System.Drawing.Point(232, 16);
            this.cbCidade.Name = "cbCidade";
            this.cbCidade.Size = new System.Drawing.Size(15, 14);
            this.cbCidade.TabIndex = 282;
            this.cbCidade.UseVisualStyleBackColor = true;
            // 
            // tb_cidade
            // 
            this.tb_cidade.BackColor = System.Drawing.SystemColors.Control;
            this.tb_cidade.Location = new System.Drawing.Point(12, 13);
            this.tb_cidade.Name = "tb_cidade";
            this.tb_cidade.Size = new System.Drawing.Size(197, 20);
            this.tb_cidade.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tb_cod_produto);
            this.groupBox5.Controls.Add(this.cbProduto);
            this.groupBox5.Controls.Add(this.tb_descricao_produto);
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Location = new System.Drawing.Point(265, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(253, 39);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Produto";
            // 
            // tb_cod_produto
            // 
            this.tb_cod_produto.BackColor = System.Drawing.SystemColors.Control;
            this.tb_cod_produto.Location = new System.Drawing.Point(12, 14);
            this.tb_cod_produto.Name = "tb_cod_produto";
            this.tb_cod_produto.Size = new System.Drawing.Size(41, 20);
            this.tb_cod_produto.TabIndex = 0;
            // 
            // cbProduto
            // 
            this.cbProduto.AutoSize = true;
            this.cbProduto.Location = new System.Drawing.Point(232, 16);
            this.cbProduto.Name = "cbProduto";
            this.cbProduto.Size = new System.Drawing.Size(15, 14);
            this.cbProduto.TabIndex = 282;
            this.cbProduto.UseVisualStyleBackColor = true;
            // 
            // tb_descricao_produto
            // 
            this.tb_descricao_produto.BackColor = System.Drawing.SystemColors.Control;
            this.tb_descricao_produto.Location = new System.Drawing.Point(59, 13);
            this.tb_descricao_produto.Name = "tb_descricao_produto";
            this.tb_descricao_produto.Size = new System.Drawing.Size(121, 20);
            this.tb_descricao_produto.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(186, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(23, 23);
            this.button2.TabIndex = 279;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tb_cod_cliente);
            this.groupBox3.Controls.Add(this.cb_cliente);
            this.groupBox3.Controls.Add(this.tb_nome_cliente);
            this.groupBox3.Controls.Add(this.btnAddCliente);
            this.groupBox3.Location = new System.Drawing.Point(6, 64);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(253, 39);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cliente";
            // 
            // tb_cod_cliente
            // 
            this.tb_cod_cliente.BackColor = System.Drawing.SystemColors.Control;
            this.tb_cod_cliente.Location = new System.Drawing.Point(12, 14);
            this.tb_cod_cliente.Name = "tb_cod_cliente";
            this.tb_cod_cliente.Size = new System.Drawing.Size(41, 20);
            this.tb_cod_cliente.TabIndex = 0;
            // 
            // cb_cliente
            // 
            this.cb_cliente.AutoSize = true;
            this.cb_cliente.Location = new System.Drawing.Point(232, 16);
            this.cb_cliente.Name = "cb_cliente";
            this.cb_cliente.Size = new System.Drawing.Size(15, 14);
            this.cb_cliente.TabIndex = 282;
            this.cb_cliente.UseVisualStyleBackColor = true;
            // 
            // tb_nome_cliente
            // 
            this.tb_nome_cliente.BackColor = System.Drawing.SystemColors.Control;
            this.tb_nome_cliente.Location = new System.Drawing.Point(59, 13);
            this.tb_nome_cliente.Name = "tb_nome_cliente";
            this.tb_nome_cliente.Size = new System.Drawing.Size(121, 20);
            this.tb_nome_cliente.TabIndex = 1;
            // 
            // btnAddCliente
            // 
            this.btnAddCliente.Location = new System.Drawing.Point(186, 11);
            this.btnAddCliente.Name = "btnAddCliente";
            this.btnAddCliente.Size = new System.Drawing.Size(23, 23);
            this.btnAddCliente.TabIndex = 279;
            this.btnAddCliente.Text = "+";
            this.btnAddCliente.UseVisualStyleBackColor = true;
            this.btnAddCliente.Click += new System.EventHandler(this.btnAddCliente_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cb_vendedor);
            this.groupBox4.Controls.Add(this.tb_nome_vendedor);
            this.groupBox4.Controls.Add(this.tb_cod_vendedor);
            this.groupBox4.Controls.Add(this.btnAddVendedor);
            this.groupBox4.Location = new System.Drawing.Point(6, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(253, 39);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Vendedor";
            // 
            // cb_vendedor
            // 
            this.cb_vendedor.AutoSize = true;
            this.cb_vendedor.Location = new System.Drawing.Point(232, 16);
            this.cb_vendedor.Name = "cb_vendedor";
            this.cb_vendedor.Size = new System.Drawing.Size(15, 14);
            this.cb_vendedor.TabIndex = 282;
            this.cb_vendedor.UseVisualStyleBackColor = true;
            // 
            // tb_nome_vendedor
            // 
            this.tb_nome_vendedor.BackColor = System.Drawing.SystemColors.Control;
            this.tb_nome_vendedor.Location = new System.Drawing.Point(59, 13);
            this.tb_nome_vendedor.Name = "tb_nome_vendedor";
            this.tb_nome_vendedor.Size = new System.Drawing.Size(121, 20);
            this.tb_nome_vendedor.TabIndex = 1;
            // 
            // tb_cod_vendedor
            // 
            this.tb_cod_vendedor.BackColor = System.Drawing.SystemColors.Control;
            this.tb_cod_vendedor.Location = new System.Drawing.Point(12, 13);
            this.tb_cod_vendedor.Name = "tb_cod_vendedor";
            this.tb_cod_vendedor.Size = new System.Drawing.Size(41, 20);
            this.tb_cod_vendedor.TabIndex = 0;
            // 
            // btnAddVendedor
            // 
            this.btnAddVendedor.Location = new System.Drawing.Point(186, 11);
            this.btnAddVendedor.Name = "btnAddVendedor";
            this.btnAddVendedor.Size = new System.Drawing.Size(23, 23);
            this.btnAddVendedor.TabIndex = 279;
            this.btnAddVendedor.Text = "+";
            this.btnAddVendedor.UseVisualStyleBackColor = true;
            this.btnAddVendedor.Click += new System.EventHandler(this.btnAddVendedor_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(749, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 129);
            this.button1.TabIndex = 7;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cbFechados);
            this.groupBox6.Controls.Add(this.cbSomatorio);
            this.groupBox6.Location = new System.Drawing.Point(130, 83);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(84, 65);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Opções";
            // 
            // cbFechados
            // 
            this.cbFechados.AutoSize = true;
            this.cbFechados.Location = new System.Drawing.Point(6, 42);
            this.cbFechados.Name = "cbFechados";
            this.cbFechados.Size = new System.Drawing.Size(73, 17);
            this.cbFechados.TabIndex = 4;
            this.cbFechados.Text = "Fechados";
            this.cbFechados.UseVisualStyleBackColor = true;
            // 
            // cbSomatorio
            // 
            this.cbSomatorio.AutoSize = true;
            this.cbSomatorio.Location = new System.Drawing.Point(6, 22);
            this.cbSomatorio.Name = "cbSomatorio";
            this.cbSomatorio.Size = new System.Drawing.Size(73, 17);
            this.cbSomatorio.TabIndex = 3;
            this.cbSomatorio.Text = "Somatório";
            this.cbSomatorio.UseVisualStyleBackColor = true;
            // 
            // fbConnection1
            // 
            this.fbConnection1.ConnectionString = resources.GetString("fbConnection1.ConnectionString");
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Produtos Vendidos Qtde/Valor",
            "Por Vendedor / Produtos Qtde/Valor",
            "Por Cliente / Produtos Qtde/Valor",
            "Por Cidade / Cliente / Produtos Qtde/Valor"});
            this.comboBox1.Location = new System.Drawing.Point(6, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(148, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.Visible = false;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.button3);
            this.groupBox8.Controls.Add(this.comboBox1);
            this.groupBox8.Location = new System.Drawing.Point(830, 19);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(160, 128);
            this.groupBox8.TabIndex = 9;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Impressão";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 64);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Imprimir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 654);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "Qtde Total:";
            // 
            // tb_qtde
            // 
            this.tb_qtde.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_qtde.Location = new System.Drawing.Point(226, 651);
            this.tb_qtde.Name = "tb_qtde";
            this.tb_qtde.Size = new System.Drawing.Size(198, 32);
            this.tb_qtde.TabIndex = 11;
            // 
            // tb_valor
            // 
            this.tb_valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_valor.Location = new System.Drawing.Point(635, 651);
            this.tb_valor.Name = "tb_valor";
            this.tb_valor.Size = new System.Drawing.Size(209, 32);
            this.tb_valor.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(507, 655);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 26);
            this.label2.TabIndex = 12;
            this.label2.Text = "Valor Total:";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.cb_data_entrega);
            this.groupBox11.Controls.Add(this.cb_data_entrada);
            this.groupBox11.Location = new System.Drawing.Point(12, 92);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(112, 65);
            this.groupBox11.TabIndex = 7;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Tipo Data";
            // 
            // cb_data_entrega
            // 
            this.cb_data_entrega.AutoSize = true;
            this.cb_data_entrega.Location = new System.Drawing.Point(6, 42);
            this.cb_data_entrega.Name = "cb_data_entrega";
            this.cb_data_entrega.Size = new System.Drawing.Size(89, 17);
            this.cb_data_entrega.TabIndex = 4;
            this.cb_data_entrega.Text = "Data Entrega";
            this.cb_data_entrega.UseVisualStyleBackColor = true;
            // 
            // cb_data_entrada
            // 
            this.cb_data_entrada.AutoSize = true;
            this.cb_data_entrada.Location = new System.Drawing.Point(6, 22);
            this.cb_data_entrada.Name = "cb_data_entrada";
            this.cb_data_entrada.Size = new System.Drawing.Size(89, 17);
            this.cb_data_entrada.TabIndex = 3;
            this.cb_data_entrada.Text = "Data Entrada";
            this.cb_data_entrada.UseVisualStyleBackColor = true;
            // 
            // form_pesquisa_vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1001, 692);
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.tb_valor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_qtde);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpOrigem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvSelect);
            this.Name = "form_pesquisa_vendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa Vendas";
            this.Load += new System.EventHandler(this.form_pesquisa_vendas_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelect)).EndInit();
            this.gpOrigem.ResumeLayout(false);
            this.gpOrigem.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtFinal;
        private System.Windows.Forms.DateTimePicker dtInicial;
        private System.Windows.Forms.DataGridView dgvSelect;
        private System.Windows.Forms.CheckBox cbPdv;
        private System.Windows.Forms.CheckBox cbPedidos;
        private System.Windows.Forms.GroupBox gpOrigem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox tb_cod_produto;
        private System.Windows.Forms.CheckBox cbProduto;
        private System.Windows.Forms.TextBox tb_descricao_produto;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tb_cod_cliente;
        private System.Windows.Forms.CheckBox cb_cliente;
        private System.Windows.Forms.TextBox tb_nome_cliente;
        private System.Windows.Forms.Button btnAddCliente;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox cb_vendedor;
        private System.Windows.Forms.TextBox tb_nome_vendedor;
        private System.Windows.Forms.TextBox tb_cod_vendedor;
        private System.Windows.Forms.Button btnAddVendedor;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox cbSomatorio;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.CheckBox cbCidade;
        private System.Windows.Forms.TextBox tb_cidade;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_qtde;
        private System.Windows.Forms.TextBox tb_valor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.CheckBox cbBonificacao;
        private System.Windows.Forms.CheckBox cbTroca;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.CheckBox ckbFornecedor;
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.TextBox txtCodFornecedor;
        private System.Windows.Forms.Button btnFornecedor;
        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.CheckBox cbFechados;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.CheckBox cb_data_entrega;
        private System.Windows.Forms.CheckBox cb_data_entrada;
    }
}