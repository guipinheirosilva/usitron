namespace Evolucao
{
    partial class form_planejamento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_planejamento));
            this.dgvPlanejamento = new System.Windows.Forms.DataGridView();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.datPlanejamento = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsPlanejamento = new System.Data.DataSet();
            this.Table = new System.Data.DataTable();
            this.ValorCp = new System.Data.DataColumn();
            this.DataPrevistaCp = new System.Data.DataColumn();
            this.RazaoFornecedorCp = new System.Data.DataColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbRomaneio = new System.Windows.Forms.CheckBox();
            this.cbForma_pgto = new System.Windows.Forms.CheckBox();
            this.btnUltimosMeses = new System.Windows.Forms.Button();
            this.dateTimeIr = new System.Windows.Forms.DateTimePicker();
            this.btnIr = new System.Windows.Forms.Button();
            this.ckbVendedor = new System.Windows.Forms.CheckBox();
            this.ckb_naoPago = new System.Windows.Forms.CheckBox();
            this.ckb_pago = new System.Windows.Forms.CheckBox();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbData_venc_original = new System.Windows.Forms.CheckBox();
            this.cbDataPagamento = new System.Windows.Forms.CheckBox();
            this.cbData_emissao = new System.Windows.Forms.CheckBox();
            this.cbData_credito = new System.Windows.Forms.CheckBox();
            this.cbData_criacao = new System.Windows.Forms.CheckBox();
            this.nudAno = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cb_buscar_saldo = new System.Windows.Forms.CheckBox();
            this.tb_saldo_inicial = new System.Windows.Forms.TextBox();
            this.cbxMes = new System.Windows.Forms.CheckBox();
            this.cbPor_data = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtTermino = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.button10 = new System.Windows.Forms.Button();
            this.tb_descricao_cc = new System.Windows.Forms.TextBox();
            this.cbPlanejamento = new System.Windows.Forms.CheckBox();
            this.tb_cod_cc = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_observacoes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_descricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cb_mostrar_apenas_cp = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBoxCr = new System.Windows.Forms.GroupBox();
            this.cb_mostrar_apenas_cr = new System.Windows.Forms.CheckBox();
            this.button9 = new System.Windows.Forms.Button();
            this.bt_baixar_cr = new System.Windows.Forms.Button();
            this.bt_alterar_cr = new System.Windows.Forms.Button();
            this.bt_multiplicar_cr = new System.Windows.Forms.Button();
            this.bt_excluir_cr = new System.Windows.Forms.Button();
            this.bt_adicionar_cr = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtRemanejamento = new System.Windows.Forms.DateTimePicker();
            this.button11 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button19 = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.tb_semana_ano = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.tb_grupo_plano = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tb_status = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tb_cod_plano = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tb_valor = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tb_empresa = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tb_n_titulo = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tb_nf = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_romaneio = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_vendedor = new System.Windows.Forms.TextBox();
            this.tb_forn_cliente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_plano = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button17 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_somatorio = new System.Windows.Forms.TextBox();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbBoletos_a_enviar = new System.Windows.Forms.CheckBox();
            this.cbCancelados = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button16 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.button18 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanejamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanejamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAno)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBoxCr.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPlanejamento
            // 
            this.dgvPlanejamento.AllowUserToAddRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dgvPlanejamento.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPlanejamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPlanejamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPlanejamento.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPlanejamento.Location = new System.Drawing.Point(16, 257);
            this.dgvPlanejamento.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPlanejamento.Name = "dgvPlanejamento";
            this.dgvPlanejamento.Size = new System.Drawing.Size(1753, 412);
            this.dgvPlanejamento.TabIndex = 0;
            this.dgvPlanejamento.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPlanejamento_CellFormatting);
            // 
            // fbConnection1
            // 
            this.fbConnection1.ConnectionString = resources.GetString("fbConnection1.ConnectionString");
            // 
            // datPlanejamento
            // 
            this.datPlanejamento.DeleteCommand = this.fbCommand4;
            this.datPlanejamento.InsertCommand = this.fbCommand2;
            this.datPlanejamento.SelectCommand = this.fbCommand1;
            this.datPlanejamento.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "SELECT VALOR_CP, DATA_PREVISTA_CP, RAZAO_FORNECEDOR_CP FROM CONTAS_A_PAGAR UNION " +
    "SELECT VALOR_CR, DATA_PREVISTA_CR, RAZAO_CLIENTE_CR FROM CONTAS_A_RECEBER";
            this.fbCommand1.CommandTimeout = 30;
            this.fbCommand1.Connection = this.fbConnection1;
            // 
            // fbCommand3
            // 
            this.fbCommand3.CommandTimeout = 30;
            // 
            // dsPlanejamento
            // 
            this.dsPlanejamento.DataSetName = "dsPlanejamento";
            this.dsPlanejamento.Namespace = "http://www.tempuri.org/dsPlanejamento.xsd";
            this.dsPlanejamento.Tables.AddRange(new System.Data.DataTable[] {
            this.Table});
            // 
            // Table
            // 
            this.Table.Columns.AddRange(new System.Data.DataColumn[] {
            this.ValorCp,
            this.DataPrevistaCp,
            this.RazaoFornecedorCp});
            this.Table.TableName = "Table";
            // 
            // ValorCp
            // 
            this.ValorCp.ColumnName = "ValorCp";
            this.ValorCp.DataType = typeof(double);
            // 
            // DataPrevistaCp
            // 
            this.DataPrevistaCp.ColumnName = "DataPrevistaCp";
            this.DataPrevistaCp.DataType = typeof(System.DateTime);
            // 
            // RazaoFornecedorCp
            // 
            this.RazaoFornecedorCp.ColumnName = "RazaoFornecedorCp";
            this.RazaoFornecedorCp.MaxLength = 100;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.Controls.Add(this.cbRomaneio);
            this.panel1.Controls.Add(this.cbForma_pgto);
            this.panel1.Controls.Add(this.btnUltimosMeses);
            this.panel1.Controls.Add(this.dateTimeIr);
            this.panel1.Controls.Add(this.btnIr);
            this.panel1.Controls.Add(this.ckbVendedor);
            this.panel1.Controls.Add(this.ckb_naoPago);
            this.panel1.Controls.Add(this.ckb_pago);
            this.panel1.Controls.Add(this.button13);
            this.panel1.Controls.Add(this.button12);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.tb_descricao_cc);
            this.panel1.Controls.Add(this.cbPlanejamento);
            this.panel1.Controls.Add(this.tb_cod_cc);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(19, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1108, 133);
            this.panel1.TabIndex = 3;
            // 
            // cbRomaneio
            // 
            this.cbRomaneio.Location = new System.Drawing.Point(336, 70);
            this.cbRomaneio.Margin = new System.Windows.Forms.Padding(4);
            this.cbRomaneio.Name = "cbRomaneio";
            this.cbRomaneio.Size = new System.Drawing.Size(120, 31);
            this.cbRomaneio.TabIndex = 77;
            this.cbRomaneio.Text = "Romaneio";
            this.cbRomaneio.UseVisualStyleBackColor = true;
            // 
            // cbForma_pgto
            // 
            this.cbForma_pgto.Location = new System.Drawing.Point(336, 26);
            this.cbForma_pgto.Margin = new System.Windows.Forms.Padding(4);
            this.cbForma_pgto.Name = "cbForma_pgto";
            this.cbForma_pgto.Size = new System.Drawing.Size(171, 28);
            this.cbForma_pgto.TabIndex = 79;
            this.cbForma_pgto.Text = "Forma de Pagamento";
            this.cbForma_pgto.UseVisualStyleBackColor = true;
            // 
            // btnUltimosMeses
            // 
            this.btnUltimosMeses.Location = new System.Drawing.Point(12, 70);
            this.btnUltimosMeses.Margin = new System.Windows.Forms.Padding(4);
            this.btnUltimosMeses.Name = "btnUltimosMeses";
            this.btnUltimosMeses.Size = new System.Drawing.Size(100, 54);
            this.btnUltimosMeses.TabIndex = 78;
            this.btnUltimosMeses.Text = "Ultimos Meses";
            this.btnUltimosMeses.UseVisualStyleBackColor = true;
            this.btnUltimosMeses.Click += new System.EventHandler(this.btnUltimosMeses_Click);
            // 
            // dateTimeIr
            // 
            this.dateTimeIr.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.dateTimeIr.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeIr.Location = new System.Drawing.Point(337, 105);
            this.dateTimeIr.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimeIr.Name = "dateTimeIr";
            this.dateTimeIr.Size = new System.Drawing.Size(95, 21);
            this.dateTimeIr.TabIndex = 77;
            // 
            // btnIr
            // 
            this.btnIr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnIr.Location = new System.Drawing.Point(435, 101);
            this.btnIr.Margin = new System.Windows.Forms.Padding(4);
            this.btnIr.Name = "btnIr";
            this.btnIr.Size = new System.Drawing.Size(73, 27);
            this.btnIr.TabIndex = 76;
            this.btnIr.Text = "Ir Para";
            this.btnIr.UseVisualStyleBackColor = true;
            this.btnIr.Click += new System.EventHandler(this.btnIr_Click);
            // 
            // ckbVendedor
            // 
            this.ckbVendedor.Location = new System.Drawing.Point(336, 48);
            this.ckbVendedor.Margin = new System.Windows.Forms.Padding(4);
            this.ckbVendedor.Name = "ckbVendedor";
            this.ckbVendedor.Size = new System.Drawing.Size(120, 31);
            this.ckbVendedor.TabIndex = 75;
            this.ckbVendedor.Text = "Vendedores";
            this.ckbVendedor.UseVisualStyleBackColor = true;
            this.ckbVendedor.CheckedChanged += new System.EventHandler(this.ckbVendedor_CheckedChanged);
            // 
            // ckb_naoPago
            // 
            this.ckb_naoPago.AutoSize = true;
            this.ckb_naoPago.Location = new System.Drawing.Point(507, 30);
            this.ckb_naoPago.Margin = new System.Windows.Forms.Padding(4);
            this.ckb_naoPago.Name = "ckb_naoPago";
            this.ckb_naoPago.Size = new System.Drawing.Size(139, 21);
            this.ckb_naoPago.TabIndex = 74;
            this.ckb_naoPago.Text = "À Pagar/Receber";
            this.ckb_naoPago.UseVisualStyleBackColor = true;
            this.ckb_naoPago.CheckedChanged += new System.EventHandler(this.ckb_naoPago_CheckedChanged);
            // 
            // ckb_pago
            // 
            this.ckb_pago.AutoSize = true;
            this.ckb_pago.Location = new System.Drawing.Point(507, 6);
            this.ckb_pago.Margin = new System.Windows.Forms.Padding(4);
            this.ckb_pago.Name = "ckb_pago";
            this.ckb_pago.Size = new System.Drawing.Size(127, 21);
            this.ckb_pago.TabIndex = 73;
            this.ckb_pago.Text = "Pago/Recebido";
            this.ckb_pago.UseVisualStyleBackColor = true;
            this.ckb_pago.CheckedChanged += new System.EventHandler(this.ckb_pago_CheckedChanged);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(120, 70);
            this.button13.Margin = new System.Windows.Forms.Padding(4);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(100, 54);
            this.button13.TabIndex = 71;
            this.button13.Text = "Imprimir\r\nPlano";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(228, 70);
            this.button12.Margin = new System.Windows.Forms.Padding(4);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(100, 54);
            this.button12.TabIndex = 0;
            this.button12.Text = "Imprimir\r\nData";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.GreenYellow;
            this.panel2.Controls.Add(this.cbData_venc_original);
            this.panel2.Controls.Add(this.cbDataPagamento);
            this.panel2.Controls.Add(this.cbData_emissao);
            this.panel2.Controls.Add(this.cbData_credito);
            this.panel2.Controls.Add(this.cbData_criacao);
            this.panel2.Controls.Add(this.nudAno);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.cb_buscar_saldo);
            this.panel2.Controls.Add(this.tb_saldo_inicial);
            this.panel2.Controls.Add(this.cbxMes);
            this.panel2.Controls.Add(this.cbPor_data);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.dtTermino);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.dtInicio);
            this.panel2.Location = new System.Drawing.Point(660, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(444, 127);
            this.panel2.TabIndex = 70;
            // 
            // cbData_venc_original
            // 
            this.cbData_venc_original.AutoSize = true;
            this.cbData_venc_original.Location = new System.Drawing.Point(9, 75);
            this.cbData_venc_original.Margin = new System.Windows.Forms.Padding(4);
            this.cbData_venc_original.Name = "cbData_venc_original";
            this.cbData_venc_original.Size = new System.Drawing.Size(135, 21);
            this.cbData_venc_original.TabIndex = 90;
            this.cbData_venc_original.Text = "Data Venc. Orig.";
            this.cbData_venc_original.UseVisualStyleBackColor = true;
            // 
            // cbDataPagamento
            // 
            this.cbDataPagamento.AutoSize = true;
            this.cbDataPagamento.Location = new System.Drawing.Point(153, 74);
            this.cbDataPagamento.Margin = new System.Windows.Forms.Padding(4);
            this.cbDataPagamento.Name = "cbDataPagamento";
            this.cbDataPagamento.Size = new System.Drawing.Size(93, 21);
            this.cbDataPagamento.TabIndex = 89;
            this.cbDataPagamento.Text = "Data Pgto";
            this.cbDataPagamento.UseVisualStyleBackColor = true;
            // 
            // cbData_emissao
            // 
            this.cbData_emissao.AutoSize = true;
            this.cbData_emissao.Location = new System.Drawing.Point(153, 49);
            this.cbData_emissao.Margin = new System.Windows.Forms.Padding(4);
            this.cbData_emissao.Name = "cbData_emissao";
            this.cbData_emissao.Size = new System.Drawing.Size(117, 21);
            this.cbData_emissao.TabIndex = 88;
            this.cbData_emissao.Text = "Data Emissão";
            this.cbData_emissao.UseVisualStyleBackColor = true;
            this.cbData_emissao.Visible = false;
            // 
            // cbData_credito
            // 
            this.cbData_credito.AutoSize = true;
            this.cbData_credito.Location = new System.Drawing.Point(153, 4);
            this.cbData_credito.Margin = new System.Windows.Forms.Padding(4);
            this.cbData_credito.Name = "cbData_credito";
            this.cbData_credito.Size = new System.Drawing.Size(109, 21);
            this.cbData_credito.TabIndex = 87;
            this.cbData_credito.Text = "Data Crédito";
            this.cbData_credito.UseVisualStyleBackColor = true;
            this.cbData_credito.CheckStateChanged += new System.EventHandler(this.cbData_credito_CheckStateChanged);
            // 
            // cbData_criacao
            // 
            this.cbData_criacao.AutoSize = true;
            this.cbData_criacao.Location = new System.Drawing.Point(153, 26);
            this.cbData_criacao.Margin = new System.Windows.Forms.Padding(4);
            this.cbData_criacao.Name = "cbData_criacao";
            this.cbData_criacao.Size = new System.Drawing.Size(142, 21);
            this.cbData_criacao.TabIndex = 86;
            this.cbData_criacao.Text = "Data Lançamento";
            this.cbData_criacao.UseVisualStyleBackColor = true;
            this.cbData_criacao.CheckStateChanged += new System.EventHandler(this.cbData_criacao_CheckStateChanged);
            // 
            // nudAno
            // 
            this.nudAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.nudAno.Location = new System.Drawing.Point(9, 52);
            this.nudAno.Margin = new System.Windows.Forms.Padding(4);
            this.nudAno.Maximum = new decimal(new int[] {
            2099,
            0,
            0,
            0});
            this.nudAno.Minimum = new decimal(new int[] {
            1999,
            0,
            0,
            0});
            this.nudAno.Name = "nudAno";
            this.nudAno.Size = new System.Drawing.Size(67, 21);
            this.nudAno.TabIndex = 85;
            this.nudAno.Value = new decimal(new int[] {
            1999,
            0,
            0,
            0});
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Janeiro",
            "Fevereiro",
            "Março",
            "Abril",
            "Maio",
            "Junho",
            "Julho",
            "Agosto",
            "Setembro",
            "Outubro",
            "Novembro",
            "Dezembro"});
            this.comboBox1.Location = new System.Drawing.Point(9, 26);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(108, 23);
            this.comboBox1.TabIndex = 83;
            // 
            // cb_buscar_saldo
            // 
            this.cb_buscar_saldo.AutoSize = true;
            this.cb_buscar_saldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_buscar_saldo.Location = new System.Drawing.Point(9, 98);
            this.cb_buscar_saldo.Margin = new System.Windows.Forms.Padding(4);
            this.cb_buscar_saldo.Name = "cb_buscar_saldo";
            this.cb_buscar_saldo.Size = new System.Drawing.Size(102, 19);
            this.cb_buscar_saldo.TabIndex = 81;
            this.cb_buscar_saldo.Text = "Buscar Saldo";
            this.cb_buscar_saldo.UseVisualStyleBackColor = true;
            // 
            // tb_saldo_inicial
            // 
            this.tb_saldo_inicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_saldo_inicial.Location = new System.Drawing.Point(259, 95);
            this.tb_saldo_inicial.Margin = new System.Windows.Forms.Padding(4);
            this.tb_saldo_inicial.Name = "tb_saldo_inicial";
            this.tb_saldo_inicial.Size = new System.Drawing.Size(160, 26);
            this.tb_saldo_inicial.TabIndex = 79;
            this.tb_saldo_inicial.TextChanged += new System.EventHandler(this.tb_saldo_inicial_TextChanged);
            // 
            // cbxMes
            // 
            this.cbxMes.AutoSize = true;
            this.cbxMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
            this.cbxMes.Location = new System.Drawing.Point(9, 4);
            this.cbxMes.Margin = new System.Windows.Forms.Padding(4);
            this.cbxMes.Name = "cbxMes";
            this.cbxMes.Size = new System.Drawing.Size(82, 19);
            this.cbxMes.TabIndex = 82;
            this.cbxMes.Text = "Por mês";
            this.cbxMes.UseVisualStyleBackColor = true;
            this.cbxMes.CheckedChanged += new System.EventHandler(this.cbxMes_CheckedChanged);
            // 
            // cbPor_data
            // 
            this.cbPor_data.AutoSize = true;
            this.cbPor_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPor_data.Location = new System.Drawing.Point(299, 6);
            this.cbPor_data.Margin = new System.Windows.Forms.Padding(4);
            this.cbPor_data.Name = "cbPor_data";
            this.cbPor_data.Size = new System.Drawing.Size(104, 19);
            this.cbPor_data.TabIndex = 78;
            this.cbPor_data.Text = "Por período";
            this.cbPor_data.UseVisualStyleBackColor = true;
            this.cbPor_data.CheckedChanged += new System.EventHandler(this.cbPor_data_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(292, 55);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 77;
            this.label5.Text = "Término";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(135, 98);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 20);
            this.label7.TabIndex = 80;
            this.label7.Text = "Saldo Inicial";
            // 
            // dtTermino
            // 
            this.dtTermino.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTermino.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTermino.Location = new System.Drawing.Point(349, 52);
            this.dtTermino.Margin = new System.Windows.Forms.Padding(4);
            this.dtTermino.Name = "dtTermino";
            this.dtTermino.Size = new System.Drawing.Size(87, 21);
            this.dtTermino.TabIndex = 76;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(292, 31);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 15);
            this.label6.TabIndex = 75;
            this.label6.Text = "Inicio";
            // 
            // dtInicio
            // 
            this.dtInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicio.Location = new System.Drawing.Point(349, 28);
            this.dtInicio.Margin = new System.Windows.Forms.Padding(4);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(87, 21);
            this.dtInicio.TabIndex = 74;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(516, 102);
            this.button10.Margin = new System.Windows.Forms.Padding(4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(136, 28);
            this.button10.TabIndex = 69;
            this.button10.Text = "Recalcular";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // tb_descricao_cc
            // 
            this.tb_descricao_cc.Location = new System.Drawing.Point(12, 38);
            this.tb_descricao_cc.Margin = new System.Windows.Forms.Padding(4);
            this.tb_descricao_cc.Name = "tb_descricao_cc";
            this.tb_descricao_cc.Size = new System.Drawing.Size(269, 22);
            this.tb_descricao_cc.TabIndex = 61;
            // 
            // cbPlanejamento
            // 
            this.cbPlanejamento.AutoSize = true;
            this.cbPlanejamento.Location = new System.Drawing.Point(291, 6);
            this.cbPlanejamento.Margin = new System.Windows.Forms.Padding(4);
            this.cbPlanejamento.Name = "cbPlanejamento";
            this.cbPlanejamento.Size = new System.Drawing.Size(116, 21);
            this.cbPlanejamento.TabIndex = 62;
            this.cbPlanejamento.Text = "Planejamento";
            this.cbPlanejamento.UseVisualStyleBackColor = true;
            // 
            // tb_cod_cc
            // 
            this.tb_cod_cc.Location = new System.Drawing.Point(115, 9);
            this.tb_cod_cc.Margin = new System.Windows.Forms.Padding(4);
            this.tb_cod_cc.Name = "tb_cod_cc";
            this.tb_cod_cc.Size = new System.Drawing.Size(127, 22);
            this.tb_cod_cc.TabIndex = 60;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(516, 73);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 28);
            this.button2.TabIndex = 5;
            this.button2.Text = "Filtrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(251, 6);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Conta Corrente:";
            // 
            // tb_observacoes
            // 
            this.tb_observacoes.Location = new System.Drawing.Point(491, 5);
            this.tb_observacoes.Margin = new System.Windows.Forms.Padding(4);
            this.tb_observacoes.Name = "tb_observacoes";
            this.tb_observacoes.Size = new System.Drawing.Size(236, 22);
            this.tb_observacoes.TabIndex = 68;
            this.tb_observacoes.TextChanged += new System.EventHandler(this.tb_observacoes_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(384, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 67;
            this.label4.Text = "Observações:";
            // 
            // tb_descricao
            // 
            this.tb_descricao.Location = new System.Drawing.Point(133, 5);
            this.tb_descricao.Margin = new System.Windows.Forms.Padding(4);
            this.tb_descricao.Name = "tb_descricao";
            this.tb_descricao.Size = new System.Drawing.Size(236, 22);
            this.tb_descricao.TabIndex = 64;
            this.tb_descricao.TextChanged += new System.EventHandler(this.tb_descricao_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 63;
            this.label1.Text = "Descrição:";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox5.Controls.Add(this.cb_mostrar_apenas_cp);
            this.groupBox5.Controls.Add(this.button3);
            this.groupBox5.Controls.Add(this.button8);
            this.groupBox5.Controls.Add(this.button6);
            this.groupBox5.Controls.Add(this.button5);
            this.groupBox5.Controls.Add(this.button4);
            this.groupBox5.Controls.Add(this.button7);
            this.groupBox5.Location = new System.Drawing.Point(1135, 15);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(235, 133);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Operações Contas a Pagar";
            // 
            // cb_mostrar_apenas_cp
            // 
            this.cb_mostrar_apenas_cp.AutoSize = true;
            this.cb_mostrar_apenas_cp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_mostrar_apenas_cp.Location = new System.Drawing.Point(27, 108);
            this.cb_mostrar_apenas_cp.Margin = new System.Windows.Forms.Padding(4);
            this.cb_mostrar_apenas_cp.Name = "cb_mostrar_apenas_cp";
            this.cb_mostrar_apenas_cp.Size = new System.Drawing.Size(151, 19);
            this.cb_mostrar_apenas_cp.TabIndex = 82;
            this.cb_mostrar_apenas_cp.Text = "Mostrar Apenas CP";
            this.cb_mostrar_apenas_cp.UseVisualStyleBackColor = true;
            this.cb_mostrar_apenas_cp.CheckedChanged += new System.EventHandler(this.cb_mostrar_apenas_cp_CheckedChanged);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(120, 78);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 6;
            this.button3.Text = "Baixar Malote";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(120, 48);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(100, 28);
            this.button8.TabIndex = 5;
            this.button8.Text = "Baixar";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(120, 18);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 28);
            this.button6.TabIndex = 3;
            this.button6.Text = "Alterar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 78);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 28);
            this.button5.TabIndex = 2;
            this.button5.Text = "Multiplicar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 48);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 28);
            this.button4.TabIndex = 1;
            this.button4.Text = "Excluir";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 18);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 28);
            this.button7.TabIndex = 0;
            this.button7.Text = "Adicionar";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // groupBoxCr
            // 
            this.groupBoxCr.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBoxCr.Controls.Add(this.cb_mostrar_apenas_cr);
            this.groupBoxCr.Controls.Add(this.button9);
            this.groupBoxCr.Controls.Add(this.bt_baixar_cr);
            this.groupBoxCr.Controls.Add(this.bt_alterar_cr);
            this.groupBoxCr.Controls.Add(this.bt_multiplicar_cr);
            this.groupBoxCr.Controls.Add(this.bt_excluir_cr);
            this.groupBoxCr.Controls.Add(this.bt_adicionar_cr);
            this.groupBoxCr.Location = new System.Drawing.Point(1377, 15);
            this.groupBoxCr.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxCr.Name = "groupBoxCr";
            this.groupBoxCr.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxCr.Size = new System.Drawing.Size(227, 133);
            this.groupBoxCr.TabIndex = 15;
            this.groupBoxCr.TabStop = false;
            this.groupBoxCr.Text = "Operações Contas a Receber";
            // 
            // cb_mostrar_apenas_cr
            // 
            this.cb_mostrar_apenas_cr.AutoSize = true;
            this.cb_mostrar_apenas_cr.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_mostrar_apenas_cr.Location = new System.Drawing.Point(25, 108);
            this.cb_mostrar_apenas_cr.Margin = new System.Windows.Forms.Padding(4);
            this.cb_mostrar_apenas_cr.Name = "cb_mostrar_apenas_cr";
            this.cb_mostrar_apenas_cr.Size = new System.Drawing.Size(152, 19);
            this.cb_mostrar_apenas_cr.TabIndex = 79;
            this.cb_mostrar_apenas_cr.Text = "Mostrar Apenas CR";
            this.cb_mostrar_apenas_cr.UseVisualStyleBackColor = true;
            this.cb_mostrar_apenas_cr.CheckedChanged += new System.EventHandler(this.cb_mostrar_apenas_cr_CheckedChanged);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(116, 79);
            this.button9.Margin = new System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(100, 30);
            this.button9.TabIndex = 7;
            this.button9.Text = "Baixar Malote";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // bt_baixar_cr
            // 
            this.bt_baixar_cr.Location = new System.Drawing.Point(116, 48);
            this.bt_baixar_cr.Margin = new System.Windows.Forms.Padding(4);
            this.bt_baixar_cr.Name = "bt_baixar_cr";
            this.bt_baixar_cr.Size = new System.Drawing.Size(100, 30);
            this.bt_baixar_cr.TabIndex = 5;
            this.bt_baixar_cr.Text = "Baixar";
            this.bt_baixar_cr.UseVisualStyleBackColor = true;
            this.bt_baixar_cr.Click += new System.EventHandler(this.bt_baixar_cr_Click);
            // 
            // bt_alterar_cr
            // 
            this.bt_alterar_cr.Location = new System.Drawing.Point(116, 18);
            this.bt_alterar_cr.Margin = new System.Windows.Forms.Padding(4);
            this.bt_alterar_cr.Name = "bt_alterar_cr";
            this.bt_alterar_cr.Size = new System.Drawing.Size(100, 28);
            this.bt_alterar_cr.TabIndex = 3;
            this.bt_alterar_cr.Text = "Alterar";
            this.bt_alterar_cr.UseVisualStyleBackColor = true;
            this.bt_alterar_cr.Click += new System.EventHandler(this.bt_alterar_cr_Click);
            // 
            // bt_multiplicar_cr
            // 
            this.bt_multiplicar_cr.Location = new System.Drawing.Point(8, 79);
            this.bt_multiplicar_cr.Margin = new System.Windows.Forms.Padding(4);
            this.bt_multiplicar_cr.Name = "bt_multiplicar_cr";
            this.bt_multiplicar_cr.Size = new System.Drawing.Size(100, 28);
            this.bt_multiplicar_cr.TabIndex = 2;
            this.bt_multiplicar_cr.Text = "Multiplicar";
            this.bt_multiplicar_cr.UseVisualStyleBackColor = true;
            this.bt_multiplicar_cr.Click += new System.EventHandler(this.bt_multiplicar_cr_Click);
            // 
            // bt_excluir_cr
            // 
            this.bt_excluir_cr.Location = new System.Drawing.Point(8, 48);
            this.bt_excluir_cr.Margin = new System.Windows.Forms.Padding(4);
            this.bt_excluir_cr.Name = "bt_excluir_cr";
            this.bt_excluir_cr.Size = new System.Drawing.Size(100, 28);
            this.bt_excluir_cr.TabIndex = 1;
            this.bt_excluir_cr.Text = "Excluir";
            this.bt_excluir_cr.UseVisualStyleBackColor = true;
            this.bt_excluir_cr.Click += new System.EventHandler(this.bt_excluir_cr_Click);
            // 
            // bt_adicionar_cr
            // 
            this.bt_adicionar_cr.Location = new System.Drawing.Point(8, 18);
            this.bt_adicionar_cr.Margin = new System.Windows.Forms.Padding(4);
            this.bt_adicionar_cr.Name = "bt_adicionar_cr";
            this.bt_adicionar_cr.Size = new System.Drawing.Size(100, 28);
            this.bt_adicionar_cr.TabIndex = 0;
            this.bt_adicionar_cr.Text = "Adicionar";
            this.bt_adicionar_cr.UseVisualStyleBackColor = true;
            this.bt_adicionar_cr.Click += new System.EventHandler(this.bt_adicionar_cr_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.dtRemanejamento);
            this.groupBox1.Controls.Add(this.button11);
            this.groupBox1.Location = new System.Drawing.Point(1612, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(159, 133);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Remanejar Datas";
            // 
            // dtRemanejamento
            // 
            this.dtRemanejamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtRemanejamento.Location = new System.Drawing.Point(8, 27);
            this.dtRemanejamento.Margin = new System.Windows.Forms.Padding(4);
            this.dtRemanejamento.Name = "dtRemanejamento";
            this.dtRemanejamento.Size = new System.Drawing.Size(137, 22);
            this.dtRemanejamento.TabIndex = 2;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(31, 66);
            this.button11.Margin = new System.Windows.Forms.Padding(4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(100, 28);
            this.button11.TabIndex = 1;
            this.button11.Text = "Remanejar";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.button19);
            this.panel3.Controls.Add(this.label21);
            this.panel3.Controls.Add(this.tb_semana_ano);
            this.panel3.Controls.Add(this.label22);
            this.panel3.Controls.Add(this.tb_grupo_plano);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.tb_status);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.tb_cod_plano);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.tb_valor);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.tb_empresa);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.tb_n_titulo);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.tb_nf);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.tb_romaneio);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.tb_vendedor);
            this.panel3.Controls.Add(this.tb_forn_cliente);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.tb_plano);
            this.panel3.Controls.Add(this.tb_descricao);
            this.panel3.Controls.Add(this.tb_observacoes);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(19, 151);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1751, 98);
            this.panel3.TabIndex = 17;
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(717, 65);
            this.button19.Margin = new System.Windows.Forms.Padding(4);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(35, 28);
            this.button19.TabIndex = 95;
            this.button19.Text = "+";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click_1);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(1308, 70);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(93, 17);
            this.label21.TabIndex = 93;
            this.label21.Text = "Semana Ano:";
            // 
            // tb_semana_ano
            // 
            this.tb_semana_ano.Location = new System.Drawing.Point(1408, 66);
            this.tb_semana_ano.Margin = new System.Windows.Forms.Padding(4);
            this.tb_semana_ano.Name = "tb_semana_ano";
            this.tb_semana_ano.Size = new System.Drawing.Size(120, 22);
            this.tb_semana_ano.TabIndex = 94;
            this.tb_semana_ano.TextChanged += new System.EventHandler(this.tb_semana_ano_TextChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(1083, 70);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(92, 17);
            this.label22.TabIndex = 91;
            this.label22.Text = "Grupo Plano:";
            // 
            // tb_grupo_plano
            // 
            this.tb_grupo_plano.Location = new System.Drawing.Point(1183, 66);
            this.tb_grupo_plano.Margin = new System.Windows.Forms.Padding(4);
            this.tb_grupo_plano.Name = "tb_grupo_plano";
            this.tb_grupo_plano.Size = new System.Drawing.Size(120, 22);
            this.tb_grupo_plano.TabIndex = 92;
            this.tb_grupo_plano.TextChanged += new System.EventHandler(this.tb_grupo_plano_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(28, 73);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(52, 17);
            this.label20.TabIndex = 90;
            this.label20.Text = "Status:";
            // 
            // tb_status
            // 
            this.tb_status.Location = new System.Drawing.Point(173, 69);
            this.tb_status.Margin = new System.Windows.Forms.Padding(4);
            this.tb_status.Name = "tb_status";
            this.tb_status.Size = new System.Drawing.Size(196, 22);
            this.tb_status.TabIndex = 89;
            this.tb_status.TextChanged += new System.EventHandler(this.tb_status_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(388, 70);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(81, 17);
            this.label19.TabIndex = 87;
            this.label19.Text = "Cod. Plano:";
            // 
            // tb_cod_plano
            // 
            this.tb_cod_plano.Location = new System.Drawing.Point(479, 65);
            this.tb_cod_plano.Margin = new System.Windows.Forms.Padding(4);
            this.tb_cod_plano.Name = "tb_cod_plano";
            this.tb_cod_plano.Size = new System.Drawing.Size(43, 22);
            this.tb_cod_plano.TabIndex = 88;
            this.tb_cod_plano.TextChanged += new System.EventHandler(this.tb_cod_plano_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(392, 41);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(45, 17);
            this.label18.TabIndex = 85;
            this.label18.Text = "Valor:";
            // 
            // tb_valor
            // 
            this.tb_valor.Location = new System.Drawing.Point(449, 36);
            this.tb_valor.Margin = new System.Windows.Forms.Padding(4);
            this.tb_valor.Name = "tb_valor";
            this.tb_valor.Size = new System.Drawing.Size(120, 22);
            this.tb_valor.TabIndex = 86;
            this.tb_valor.TextChanged += new System.EventHandler(this.tb_valor_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1339, 39);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 17);
            this.label17.TabIndex = 84;
            this.label17.Text = "Empresa:";
            // 
            // tb_empresa
            // 
            this.tb_empresa.Location = new System.Drawing.Point(1429, 36);
            this.tb_empresa.Margin = new System.Windows.Forms.Padding(4);
            this.tb_empresa.Name = "tb_empresa";
            this.tb_empresa.Size = new System.Drawing.Size(99, 22);
            this.tb_empresa.TabIndex = 83;
            this.tb_empresa.TextChanged += new System.EventHandler(this.tb_empresa_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1339, 9);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 17);
            this.label16.TabIndex = 82;
            this.label16.Text = "No Título:";
            // 
            // tb_n_titulo
            // 
            this.tb_n_titulo.Location = new System.Drawing.Point(1429, 5);
            this.tb_n_titulo.Margin = new System.Windows.Forms.Padding(4);
            this.tb_n_titulo.Name = "tb_n_titulo";
            this.tb_n_titulo.Size = new System.Drawing.Size(99, 22);
            this.tb_n_titulo.TabIndex = 81;
            this.tb_n_titulo.TextChanged += new System.EventHandler(this.tb_n_titulo_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1112, 41);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 17);
            this.label15.TabIndex = 80;
            this.label15.Text = "NF:";
            // 
            // tb_nf
            // 
            this.tb_nf.Location = new System.Drawing.Point(1203, 37);
            this.tb_nf.Margin = new System.Windows.Forms.Padding(4);
            this.tb_nf.Name = "tb_nf";
            this.tb_nf.Size = new System.Drawing.Size(99, 22);
            this.tb_nf.TabIndex = 79;
            this.tb_nf.TextChanged += new System.EventHandler(this.tb_nf_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1112, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 78;
            this.label3.Text = "Romaneio:";
            // 
            // tb_romaneio
            // 
            this.tb_romaneio.Location = new System.Drawing.Point(1203, 4);
            this.tb_romaneio.Margin = new System.Windows.Forms.Padding(4);
            this.tb_romaneio.Name = "tb_romaneio";
            this.tb_romaneio.Size = new System.Drawing.Size(99, 22);
            this.tb_romaneio.TabIndex = 77;
            this.tb_romaneio.TextChanged += new System.EventHandler(this.tb_romaneio_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(752, 9);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 17);
            this.label11.TabIndex = 76;
            this.label11.Text = "Forma Pagamento:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(888, 5);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 22);
            this.textBox1.TabIndex = 75;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(909, 42);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 17);
            this.label9.TabIndex = 74;
            this.label9.Text = "Carteira:";
            // 
            // tb_vendedor
            // 
            this.tb_vendedor.Location = new System.Drawing.Point(979, 36);
            this.tb_vendedor.Margin = new System.Windows.Forms.Padding(4);
            this.tb_vendedor.Name = "tb_vendedor";
            this.tb_vendedor.Size = new System.Drawing.Size(116, 22);
            this.tb_vendedor.TabIndex = 73;
            this.tb_vendedor.TextChanged += new System.EventHandler(this.tb_vendedor_TextChanged);
            // 
            // tb_forn_cliente
            // 
            this.tb_forn_cliente.Location = new System.Drawing.Point(173, 37);
            this.tb_forn_cliente.Margin = new System.Windows.Forms.Padding(4);
            this.tb_forn_cliente.Name = "tb_forn_cliente";
            this.tb_forn_cliente.Size = new System.Drawing.Size(196, 22);
            this.tb_forn_cliente.TabIndex = 70;
            this.tb_forn_cliente.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 39);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 17);
            this.label8.TabIndex = 69;
            this.label8.Text = "Fornecedor/Cliente:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(531, 73);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 17);
            this.label10.TabIndex = 71;
            this.label10.Text = "Plano:";
            // 
            // tb_plano
            // 
            this.tb_plano.Location = new System.Drawing.Point(588, 68);
            this.tb_plano.Margin = new System.Windows.Forms.Padding(4);
            this.tb_plano.Name = "tb_plano";
            this.tb_plano.Size = new System.Drawing.Size(120, 22);
            this.tb_plano.TabIndex = 72;
            this.tb_plano.TextChanged += new System.EventHandler(this.tb_plano_TextChanged);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel4.Controls.Add(this.button17);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.tb_somatorio);
            this.panel4.Location = new System.Drawing.Point(1181, 677);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(425, 100);
            this.panel4.TabIndex = 89;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(167, 62);
            this.button17.Margin = new System.Windows.Forms.Padding(4);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(100, 28);
            this.button17.TabIndex = 88;
            this.button17.Text = "Somar";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(9, 16);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(145, 31);
            this.label14.TabIndex = 87;
            this.label14.Text = "Somatório:";
            // 
            // tb_somatorio
            // 
            this.tb_somatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_somatorio.Location = new System.Drawing.Point(167, 12);
            this.tb_somatorio.Margin = new System.Windows.Forms.Padding(4);
            this.tb_somatorio.Name = "tb_somatorio";
            this.tb_somatorio.Size = new System.Drawing.Size(241, 38);
            this.tb_somatorio.TabIndex = 86;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(28, 41);
            this.button14.Margin = new System.Windows.Forms.Padding(4);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(136, 49);
            this.button14.TabIndex = 90;
            this.button14.Text = "Gerar CNAB";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(172, 41);
            this.button15.Margin = new System.Windows.Forms.Padding(4);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(136, 49);
            this.button15.TabIndex = 91;
            this.button15.Text = "Importar CNAB400";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel5.Controls.Add(this.cbBoletos_a_enviar);
            this.panel5.Controls.Add(this.cbCancelados);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.button16);
            this.panel5.Controls.Add(this.button15);
            this.panel5.Controls.Add(this.button14);
            this.panel5.Location = new System.Drawing.Point(23, 677);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(477, 100);
            this.panel5.TabIndex = 92;
            // 
            // cbBoletos_a_enviar
            // 
            this.cbBoletos_a_enviar.AutoSize = true;
            this.cbBoletos_a_enviar.Location = new System.Drawing.Point(313, 41);
            this.cbBoletos_a_enviar.Margin = new System.Windows.Forms.Padding(4);
            this.cbBoletos_a_enviar.Name = "cbBoletos_a_enviar";
            this.cbBoletos_a_enviar.Size = new System.Drawing.Size(154, 21);
            this.cbBoletos_a_enviar.TabIndex = 96;
            this.cbBoletos_a_enviar.Text = "Boletos para Enviar";
            this.cbBoletos_a_enviar.UseVisualStyleBackColor = true;
            // 
            // cbCancelados
            // 
            this.cbCancelados.AutoSize = true;
            this.cbCancelados.Location = new System.Drawing.Point(313, 66);
            this.cbCancelados.Margin = new System.Windows.Forms.Padding(4);
            this.cbCancelados.Name = "cbCancelados";
            this.cbCancelados.Size = new System.Drawing.Size(155, 21);
            this.cbCancelados.TabIndex = 95;
            this.cbCancelados.Text = "Boletos Cancelados";
            this.cbCancelados.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(123, 5);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(226, 31);
            this.label12.TabIndex = 93;
            this.label12.Text = "CNAB/BOLETOS";
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(316, 4);
            this.button16.Margin = new System.Windows.Forms.Padding(4);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(136, 49);
            this.button16.TabIndex = 92;
            this.button16.Text = "Importar CNAB240";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Visible = false;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.button18);
            this.panel6.Location = new System.Drawing.Point(769, 677);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(404, 100);
            this.panel6.TabIndex = 93;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(164, 4);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 31);
            this.label13.TabIndex = 94;
            this.label13.Text = "DRE";
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(123, 38);
            this.button18.Margin = new System.Windows.Forms.Padding(4);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(160, 54);
            this.button18.TabIndex = 0;
            this.button18.Text = "DRE";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // form_planejamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1773, 784);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxCr);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvPlanejamento);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form_planejamento";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Planejamento Financeiro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.form_planejamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanejamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanejamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAno)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBoxCr.ResumeLayout(false);
            this.groupBoxCr.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPlanejamento;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datPlanejamento;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Data.DataSet dsPlanejamento;
        private System.Data.DataTable Table;
        private System.Data.DataColumn ValorCp;
        private System.Data.DataColumn DataPrevistaCp;
        private System.Data.DataColumn RazaoFornecedorCp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.GroupBox groupBoxCr;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button bt_baixar_cr;
        private System.Windows.Forms.Button bt_alterar_cr;
        private System.Windows.Forms.Button bt_multiplicar_cr;
        private System.Windows.Forms.Button bt_excluir_cr;
        private System.Windows.Forms.Button bt_adicionar_cr;
        private System.Windows.Forms.TextBox tb_descricao_cc;
        private System.Windows.Forms.TextBox tb_cod_cc;
        private System.Windows.Forms.CheckBox cbPlanejamento;
        private System.Windows.Forms.TextBox tb_observacoes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_descricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtRemanejamento;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox cbPor_data;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtTermino;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_saldo_inicial;
        private System.Windows.Forms.CheckBox cb_buscar_saldo;
        private System.Windows.Forms.CheckBox cb_mostrar_apenas_cp;
        private System.Windows.Forms.CheckBox cb_mostrar_apenas_cr;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.TextBox tb_forn_cliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_plano;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.CheckBox cbxMes;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown nudAno;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tb_somatorio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_vendedor;
        private System.Windows.Forms.CheckBox ckb_naoPago;
        private System.Windows.Forms.CheckBox ckb_pago;
        private System.Windows.Forms.DateTimePicker dateTimeIr;
        private System.Windows.Forms.Button btnIr;
        private System.Windows.Forms.Button btnUltimosMeses;
        private System.Windows.Forms.CheckBox ckbVendedor;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.CheckBox cbData_criacao;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.CheckBox cbForma_pgto;
        private System.Windows.Forms.CheckBox cbRomaneio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_romaneio;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.CheckBox cbCancelados;
        private System.Windows.Forms.CheckBox cbBoletos_a_enviar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tb_nf;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tb_n_titulo;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tb_empresa;
        private System.Windows.Forms.CheckBox cbData_credito;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tb_valor;
        private System.Windows.Forms.CheckBox cbData_emissao;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tb_cod_plano;
        private System.Windows.Forms.CheckBox cbDataPagamento;
        private System.Windows.Forms.CheckBox cbData_venc_original;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tb_status;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox tb_grupo_plano;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tb_semana_ano;
        private System.Windows.Forms.Button button19;
    }
}