namespace Evolucao
{
    partial class form_malote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_malote));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.datMalotes = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsMalotes = new System.Data.DataSet();
            this.MALOTES = new System.Data.DataTable();
            this.COD_MALOTE = new System.Data.DataColumn();
            this.DESCRICAO_MALOTE = new System.Data.DataColumn();
            this.COD_CC_MALOTE = new System.Data.DataColumn();
            this.DESCRICAO_CC_MALOTE = new System.Data.DataColumn();
            this.DATA_MALOTE = new System.Data.DataColumn();
            this.dataColumn1 = new System.Data.DataColumn();
            this.fbCommand5 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand6 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand7 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand8 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_descricao_cc = new System.Windows.Forms.TextBox();
            this.tb_cod_cc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_cod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_valor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_descricao = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_data = new System.Windows.Forms.TextBox();
            this.apaga_registro = new System.Windows.Forms.Button();
            this.salva_registro = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.novo_registro = new System.Windows.Forms.Button();
            this.dgvCaixa = new System.Windows.Forms.DataGridView();
            this.cODCAIXADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRICAOCAIXADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCCAIXADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODCPCRCAIXADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRICAOCCCAIXADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORCAIXADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATACAIXADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODEXTRATOCAIXADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODFORNCLICAIXADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAZAOCLIFORNCAIXADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dUPLICATACAIXADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nFCAIXADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pLANOCAIXADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cARTEIRACAIXADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dEBITOCAIXADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cREDITOCAIXADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.datCaixa = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand12 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand10 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand9 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand11 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.fbCommand13 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand14 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand15 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand16 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.datContas_a_pagar = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand20 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand18 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand17 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand19 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.datContas_a_receber = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand24 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand22 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand21 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand23 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.comando_select = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.cbMalotes = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.cbCaixa = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.button7 = new System.Windows.Forms.Button();
            this.datPedidos_venda = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand25 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand26 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand27 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand28 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsPedidos_venda = new System.Data.DataSet();
            this.PEDIDOS_VENDA = new System.Data.DataTable();
            this.COD_PED_VENDA = new System.Data.DataColumn();
            this.DATA_PED_VENDA = new System.Data.DataColumn();
            this.DATA_BAIXA_PED_VENDA = new System.Data.DataColumn();
            this.CLIENTE_PED_VENDA = new System.Data.DataColumn();
            this.CNPJ_PED_VENDA = new System.Data.DataColumn();
            this.COND_PGTO_PED_VENDA = new System.Data.DataColumn();
            this.VALOR_TOTAL_PROD_PED_VENDA = new System.Data.DataColumn();
            this.VALOR_TOTAL_PED_VENDA = new System.Data.DataColumn();
            this.VALOR_TOTAL_ICMS_PED_VENDA = new System.Data.DataColumn();
            this.VALOR_TOTAL_IPI_PED_VENDA = new System.Data.DataColumn();
            this.VALOR_DESCONTO_PED_VENDA = new System.Data.DataColumn();
            this.OBS_PED_VENDA = new System.Data.DataColumn();
            this.NF_PED_VENDA = new System.Data.DataColumn();
            this.BAIXADO_ESTOQUE_PED_VENDA = new System.Data.DataColumn();
            this.PAGO_PED_VENDA = new System.Data.DataColumn();
            this.COD_CAIXA_PGTO_PED_VENDA = new System.Data.DataColumn();
            this.VENDEDOR_PED_VENDA = new System.Data.DataColumn();
            this.COD_VENDEDOR_PED_VENDA = new System.Data.DataColumn();
            this.CANCELADO_PED_VENDA = new System.Data.DataColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dsMalotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MALOTES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaixa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCaixa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CAIXA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPedidos_venda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PEDIDOS_VENDA)).BeginInit();
            this.SuspendLayout();
            // 
            // datMalotes
            // 
            this.datMalotes.DeleteCommand = this.fbCommand4;
            this.datMalotes.InsertCommand = this.fbCommand2;
            this.datMalotes.SelectCommand = this.fbCommand1;
            this.datMalotes.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * from malotes";
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
            // dsMalotes
            // 
            this.dsMalotes.DataSetName = "dsMalotes";
            this.dsMalotes.Namespace = "http://www.tempuri.org/dsMalotes.xsd";
            this.dsMalotes.Tables.AddRange(new System.Data.DataTable[] {
            this.MALOTES});
            // 
            // MALOTES
            // 
            this.MALOTES.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_MALOTE,
            this.DESCRICAO_MALOTE,
            this.COD_CC_MALOTE,
            this.DESCRICAO_CC_MALOTE,
            this.DATA_MALOTE,
            this.dataColumn1});
            this.MALOTES.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_MALOTE"}, true)});
            this.MALOTES.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_MALOTE};
            this.MALOTES.TableName = "MALOTES";
            // 
            // COD_MALOTE
            // 
            this.COD_MALOTE.AllowDBNull = false;
            this.COD_MALOTE.ColumnName = "COD_MALOTE";
            this.COD_MALOTE.DataType = typeof(int);
            // 
            // DESCRICAO_MALOTE
            // 
            this.DESCRICAO_MALOTE.ColumnName = "DESCRICAO_MALOTE";
            this.DESCRICAO_MALOTE.MaxLength = 100;
            // 
            // COD_CC_MALOTE
            // 
            this.COD_CC_MALOTE.ColumnName = "COD_CC_MALOTE";
            this.COD_CC_MALOTE.DataType = typeof(int);
            // 
            // DESCRICAO_CC_MALOTE
            // 
            this.DESCRICAO_CC_MALOTE.ColumnName = "DESCRICAO_CC_MALOTE";
            this.DESCRICAO_CC_MALOTE.MaxLength = 100;
            // 
            // DATA_MALOTE
            // 
            this.DATA_MALOTE.ColumnName = "DATA_MALOTE";
            this.DATA_MALOTE.DataType = typeof(System.DateTime);
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "VALOT_TOTAL_MALOTE";
            this.dataColumn1.DataType = typeof(double);
            // 
            // fbCommand5
            // 
            this.fbCommand5.CommandTimeout = 30;
            // 
            // fbCommand6
            // 
            this.fbCommand6.CommandTimeout = 30;
            // 
            // fbCommand7
            // 
            this.fbCommand7.CommandTimeout = 30;
            // 
            // fbCommand8
            // 
            this.fbCommand8.CommandTimeout = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(159, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "MALOTES";
            // 
            // tb_descricao_cc
            // 
            this.tb_descricao_cc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMalotes, "MALOTES.DESCRICAO_CC_MALOTE", true));
            this.tb_descricao_cc.Location = new System.Drawing.Point(155, 86);
            this.tb_descricao_cc.Name = "tb_descricao_cc";
            this.tb_descricao_cc.Size = new System.Drawing.Size(212, 20);
            this.tb_descricao_cc.TabIndex = 88;
            // 
            // tb_cod_cc
            // 
            this.tb_cod_cc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMalotes, "MALOTES.COD_CC_MALOTE", true));
            this.tb_cod_cc.Location = new System.Drawing.Point(96, 86);
            this.tb_cod_cc.Name = "tb_cod_cc";
            this.tb_cod_cc.Size = new System.Drawing.Size(53, 20);
            this.tb_cod_cc.TabIndex = 87;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 98;
            this.label7.Text = "Conta Corrente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 96;
            this.label1.Text = "Cód:";
            // 
            // tb_cod
            // 
            this.tb_cod.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMalotes, "MALOTES.COD_MALOTE", true));
            this.tb_cod.Location = new System.Drawing.Point(73, 61);
            this.tb_cod.Name = "tb_cod";
            this.tb_cod.ReadOnly = true;
            this.tb_cod.Size = new System.Drawing.Size(56, 20);
            this.tb_cod.TabIndex = 97;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 94;
            this.label4.Text = "Valor:";
            // 
            // tb_valor
            // 
            this.tb_valor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMalotes, "MALOTES.VALOT_TOTAL_MALOTE", true));
            this.tb_valor.Location = new System.Drawing.Point(73, 138);
            this.tb_valor.Name = "tb_valor";
            this.tb_valor.Size = new System.Drawing.Size(112, 20);
            this.tb_valor.TabIndex = 92;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 93;
            this.label3.Text = "Descrição:";
            // 
            // tb_descricao
            // 
            this.tb_descricao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMalotes, "MALOTES.DESCRICAO_MALOTE", true));
            this.tb_descricao.Location = new System.Drawing.Point(73, 112);
            this.tb_descricao.Name = "tb_descricao";
            this.tb_descricao.Size = new System.Drawing.Size(294, 20);
            this.tb_descricao.TabIndex = 91;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(373, 84);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(25, 23);
            this.button6.TabIndex = 100;
            this.button6.Text = "+";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(191, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 102;
            this.label5.Text = "Data:";
            // 
            // tb_data
            // 
            this.tb_data.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMalotes, "MALOTES.DATA_MALOTE", true));
            this.tb_data.Location = new System.Drawing.Point(255, 138);
            this.tb_data.Name = "tb_data";
            this.tb_data.Size = new System.Drawing.Size(112, 20);
            this.tb_data.TabIndex = 101;
            // 
            // apaga_registro
            // 
            this.apaga_registro.Location = new System.Drawing.Point(210, 164);
            this.apaga_registro.Name = "apaga_registro";
            this.apaga_registro.Size = new System.Drawing.Size(49, 22);
            this.apaga_registro.TabIndex = 104;
            this.apaga_registro.Text = "Excluir";
            this.apaga_registro.UseVisualStyleBackColor = true;
            // 
            // salva_registro
            // 
            this.salva_registro.Location = new System.Drawing.Point(265, 164);
            this.salva_registro.Name = "salva_registro";
            this.salva_registro.Size = new System.Drawing.Size(49, 22);
            this.salva_registro.TabIndex = 103;
            this.salva_registro.Text = "Salvar";
            this.salva_registro.UseVisualStyleBackColor = true;
            this.salva_registro.Click += new System.EventHandler(this.salva_registro_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(89, 164);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 22);
            this.button3.TabIndex = 106;
            this.button3.Text = "Localizar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // novo_registro
            // 
            this.novo_registro.Location = new System.Drawing.Point(155, 164);
            this.novo_registro.Name = "novo_registro";
            this.novo_registro.Size = new System.Drawing.Size(49, 22);
            this.novo_registro.TabIndex = 105;
            this.novo_registro.Text = "Novo";
            this.novo_registro.UseVisualStyleBackColor = true;
            // 
            // dgvCaixa
            // 
            this.dgvCaixa.AllowUserToAddRows = false;
            this.dgvCaixa.AllowUserToDeleteRows = false;
            this.dgvCaixa.AutoGenerateColumns = false;
            this.dgvCaixa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaixa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODCAIXADataGridViewTextBoxColumn,
            this.dESCRICAOCAIXADataGridViewTextBoxColumn,
            this.cCCAIXADataGridViewTextBoxColumn,
            this.cODCPCRCAIXADataGridViewTextBoxColumn,
            this.dESCRICAOCCCAIXADataGridViewTextBoxColumn,
            this.vALORCAIXADataGridViewTextBoxColumn,
            this.dATACAIXADataGridViewTextBoxColumn,
            this.cODEXTRATOCAIXADataGridViewTextBoxColumn,
            this.cODFORNCLICAIXADataGridViewTextBoxColumn,
            this.rAZAOCLIFORNCAIXADataGridViewTextBoxColumn,
            this.dUPLICATACAIXADataGridViewTextBoxColumn,
            this.nFCAIXADataGridViewTextBoxColumn,
            this.pLANOCAIXADataGridViewTextBoxColumn,
            this.cARTEIRACAIXADataGridViewTextBoxColumn,
            this.dEBITOCAIXADataGridViewTextBoxColumn,
            this.cREDITOCAIXADataGridViewTextBoxColumn});
            this.dgvCaixa.DataMember = "CAIXA";
            this.dgvCaixa.DataSource = this.dsCaixa;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCaixa.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCaixa.Location = new System.Drawing.Point(12, 205);
            this.dgvCaixa.Name = "dgvCaixa";
            this.dgvCaixa.Size = new System.Drawing.Size(355, 264);
            this.dgvCaixa.TabIndex = 107;
            // 
            // cODCAIXADataGridViewTextBoxColumn
            // 
            this.cODCAIXADataGridViewTextBoxColumn.DataPropertyName = "COD_CAIXA";
            this.cODCAIXADataGridViewTextBoxColumn.HeaderText = "COD_CAIXA";
            this.cODCAIXADataGridViewTextBoxColumn.Name = "cODCAIXADataGridViewTextBoxColumn";
            this.cODCAIXADataGridViewTextBoxColumn.Visible = false;
            // 
            // dESCRICAOCAIXADataGridViewTextBoxColumn
            // 
            this.dESCRICAOCAIXADataGridViewTextBoxColumn.DataPropertyName = "DESCRICAO_CAIXA";
            this.dESCRICAOCAIXADataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.dESCRICAOCAIXADataGridViewTextBoxColumn.Name = "dESCRICAOCAIXADataGridViewTextBoxColumn";
            this.dESCRICAOCAIXADataGridViewTextBoxColumn.Width = 150;
            // 
            // cCCAIXADataGridViewTextBoxColumn
            // 
            this.cCCAIXADataGridViewTextBoxColumn.DataPropertyName = "CC_CAIXA";
            this.cCCAIXADataGridViewTextBoxColumn.HeaderText = "CC_CAIXA";
            this.cCCAIXADataGridViewTextBoxColumn.Name = "cCCAIXADataGridViewTextBoxColumn";
            this.cCCAIXADataGridViewTextBoxColumn.Visible = false;
            // 
            // cODCPCRCAIXADataGridViewTextBoxColumn
            // 
            this.cODCPCRCAIXADataGridViewTextBoxColumn.DataPropertyName = "COD_CP_CR_CAIXA";
            this.cODCPCRCAIXADataGridViewTextBoxColumn.HeaderText = "COD_CP_CR_CAIXA";
            this.cODCPCRCAIXADataGridViewTextBoxColumn.Name = "cODCPCRCAIXADataGridViewTextBoxColumn";
            this.cODCPCRCAIXADataGridViewTextBoxColumn.Visible = false;
            // 
            // dESCRICAOCCCAIXADataGridViewTextBoxColumn
            // 
            this.dESCRICAOCCCAIXADataGridViewTextBoxColumn.DataPropertyName = "DESCRICAO_CC_CAIXA";
            this.dESCRICAOCCCAIXADataGridViewTextBoxColumn.HeaderText = "DESCRICAO_CC_CAIXA";
            this.dESCRICAOCCCAIXADataGridViewTextBoxColumn.Name = "dESCRICAOCCCAIXADataGridViewTextBoxColumn";
            this.dESCRICAOCCCAIXADataGridViewTextBoxColumn.Visible = false;
            // 
            // vALORCAIXADataGridViewTextBoxColumn
            // 
            this.vALORCAIXADataGridViewTextBoxColumn.DataPropertyName = "VALOR_CAIXA";
            this.vALORCAIXADataGridViewTextBoxColumn.HeaderText = "Valor";
            this.vALORCAIXADataGridViewTextBoxColumn.Name = "vALORCAIXADataGridViewTextBoxColumn";
            this.vALORCAIXADataGridViewTextBoxColumn.Width = 60;
            // 
            // dATACAIXADataGridViewTextBoxColumn
            // 
            this.dATACAIXADataGridViewTextBoxColumn.DataPropertyName = "DATA_CAIXA";
            this.dATACAIXADataGridViewTextBoxColumn.HeaderText = "DATA_CAIXA";
            this.dATACAIXADataGridViewTextBoxColumn.Name = "dATACAIXADataGridViewTextBoxColumn";
            this.dATACAIXADataGridViewTextBoxColumn.Visible = false;
            // 
            // cODEXTRATOCAIXADataGridViewTextBoxColumn
            // 
            this.cODEXTRATOCAIXADataGridViewTextBoxColumn.DataPropertyName = "COD_EXTRATO_CAIXA";
            this.cODEXTRATOCAIXADataGridViewTextBoxColumn.HeaderText = "COD_EXTRATO_CAIXA";
            this.cODEXTRATOCAIXADataGridViewTextBoxColumn.Name = "cODEXTRATOCAIXADataGridViewTextBoxColumn";
            this.cODEXTRATOCAIXADataGridViewTextBoxColumn.Visible = false;
            // 
            // cODFORNCLICAIXADataGridViewTextBoxColumn
            // 
            this.cODFORNCLICAIXADataGridViewTextBoxColumn.DataPropertyName = "COD_FORN_CLI_CAIXA";
            this.cODFORNCLICAIXADataGridViewTextBoxColumn.HeaderText = "COD_FORN_CLI_CAIXA";
            this.cODFORNCLICAIXADataGridViewTextBoxColumn.Name = "cODFORNCLICAIXADataGridViewTextBoxColumn";
            this.cODFORNCLICAIXADataGridViewTextBoxColumn.Visible = false;
            // 
            // rAZAOCLIFORNCAIXADataGridViewTextBoxColumn
            // 
            this.rAZAOCLIFORNCAIXADataGridViewTextBoxColumn.DataPropertyName = "RAZAO_CLI_FORN_CAIXA";
            this.rAZAOCLIFORNCAIXADataGridViewTextBoxColumn.HeaderText = "Fornecedor";
            this.rAZAOCLIFORNCAIXADataGridViewTextBoxColumn.Name = "rAZAOCLIFORNCAIXADataGridViewTextBoxColumn";
            // 
            // dUPLICATACAIXADataGridViewTextBoxColumn
            // 
            this.dUPLICATACAIXADataGridViewTextBoxColumn.DataPropertyName = "DUPLICATA_CAIXA";
            this.dUPLICATACAIXADataGridViewTextBoxColumn.HeaderText = "Duplicata";
            this.dUPLICATACAIXADataGridViewTextBoxColumn.Name = "dUPLICATACAIXADataGridViewTextBoxColumn";
            this.dUPLICATACAIXADataGridViewTextBoxColumn.Width = 50;
            // 
            // nFCAIXADataGridViewTextBoxColumn
            // 
            this.nFCAIXADataGridViewTextBoxColumn.DataPropertyName = "NF_CAIXA";
            this.nFCAIXADataGridViewTextBoxColumn.HeaderText = "NF";
            this.nFCAIXADataGridViewTextBoxColumn.Name = "nFCAIXADataGridViewTextBoxColumn";
            this.nFCAIXADataGridViewTextBoxColumn.Width = 50;
            // 
            // pLANOCAIXADataGridViewTextBoxColumn
            // 
            this.pLANOCAIXADataGridViewTextBoxColumn.DataPropertyName = "PLANO_CAIXA";
            this.pLANOCAIXADataGridViewTextBoxColumn.HeaderText = "Plano";
            this.pLANOCAIXADataGridViewTextBoxColumn.Name = "pLANOCAIXADataGridViewTextBoxColumn";
            this.pLANOCAIXADataGridViewTextBoxColumn.Width = 80;
            // 
            // cARTEIRACAIXADataGridViewTextBoxColumn
            // 
            this.cARTEIRACAIXADataGridViewTextBoxColumn.DataPropertyName = "CARTEIRA_CAIXA";
            this.cARTEIRACAIXADataGridViewTextBoxColumn.HeaderText = "Carteira";
            this.cARTEIRACAIXADataGridViewTextBoxColumn.Name = "cARTEIRACAIXADataGridViewTextBoxColumn";
            this.cARTEIRACAIXADataGridViewTextBoxColumn.Width = 80;
            // 
            // dEBITOCAIXADataGridViewTextBoxColumn
            // 
            this.dEBITOCAIXADataGridViewTextBoxColumn.DataPropertyName = "DEBITO_CAIXA";
            this.dEBITOCAIXADataGridViewTextBoxColumn.HeaderText = "DEBITO_CAIXA";
            this.dEBITOCAIXADataGridViewTextBoxColumn.Name = "dEBITOCAIXADataGridViewTextBoxColumn";
            this.dEBITOCAIXADataGridViewTextBoxColumn.Visible = false;
            // 
            // cREDITOCAIXADataGridViewTextBoxColumn
            // 
            this.cREDITOCAIXADataGridViewTextBoxColumn.DataPropertyName = "CREDITO_CAIXA";
            this.cREDITOCAIXADataGridViewTextBoxColumn.HeaderText = "CREDITO_CAIXA";
            this.cREDITOCAIXADataGridViewTextBoxColumn.Name = "cREDITOCAIXADataGridViewTextBoxColumn";
            this.cREDITOCAIXADataGridViewTextBoxColumn.Visible = false;
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
            this.CREDITO_CAIXA});
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
            // datCaixa
            // 
            this.datCaixa.DeleteCommand = this.fbCommand12;
            this.datCaixa.InsertCommand = this.fbCommand10;
            this.datCaixa.SelectCommand = this.fbCommand9;
            this.datCaixa.UpdateCommand = this.fbCommand11;
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
            this.fbCommand9.CommandText = "select * from caixa";
            this.fbCommand9.CommandTimeout = 30;
            this.fbCommand9.Connection = this.fbConnection1;
            // 
            // fbCommand11
            // 
            this.fbCommand11.CommandTimeout = 30;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(373, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 22);
            this.button1.TabIndex = 108;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(373, 274);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 22);
            this.button2.TabIndex = 109;
            this.button2.Text = "Excluir";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(373, 302);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 22);
            this.button4.TabIndex = 110;
            this.button4.Text = "Alterar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(373, 205);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(60, 35);
            this.button5.TabIndex = 111;
            this.button5.Text = "Adicionar Todos";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // fbCommand13
            // 
            this.fbCommand13.CommandTimeout = 30;
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
            // datContas_a_pagar
            // 
            this.datContas_a_pagar.DeleteCommand = this.fbCommand20;
            this.datContas_a_pagar.InsertCommand = this.fbCommand18;
            this.datContas_a_pagar.SelectCommand = this.fbCommand17;
            this.datContas_a_pagar.UpdateCommand = this.fbCommand19;
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
            this.fbCommand17.CommandText = "select * from contas_a_pagar";
            this.fbCommand17.CommandTimeout = 30;
            this.fbCommand17.Connection = this.fbConnection1;
            // 
            // fbCommand19
            // 
            this.fbCommand19.CommandTimeout = 30;
            // 
            // datContas_a_receber
            // 
            this.datContas_a_receber.DeleteCommand = this.fbCommand24;
            this.datContas_a_receber.InsertCommand = this.fbCommand22;
            this.datContas_a_receber.SelectCommand = this.fbCommand21;
            this.datContas_a_receber.UpdateCommand = this.fbCommand23;
            // 
            // fbCommand24
            // 
            this.fbCommand24.CommandTimeout = 30;
            // 
            // fbCommand22
            // 
            this.fbCommand22.CommandTimeout = 30;
            // 
            // fbCommand21
            // 
            this.fbCommand21.CommandText = "select * from contas_a_receber";
            this.fbCommand21.CommandTimeout = 30;
            this.fbCommand21.Connection = this.fbConnection1;
            // 
            // fbCommand23
            // 
            this.fbCommand23.CommandTimeout = 30;
            // 
            // comando_select
            // 
            this.comando_select.CommandTimeout = 30;
            this.comando_select.Connection = this.fbConnection1;
            // 
            // cbMalotes
            // 
            this.cbMalotes.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbMalotes.DataAdapter = this.datMalotes;
            this.cbMalotes.QuotePrefix = "\"";
            this.cbMalotes.QuoteSuffix = "\"";
            // 
            // cbCaixa
            // 
            this.cbCaixa.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbCaixa.DataAdapter = this.datCaixa;
            this.cbCaixa.QuotePrefix = "\"";
            this.cbCaixa.QuoteSuffix = "\"";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(320, 164);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(55, 22);
            this.button7.TabIndex = 112;
            this.button7.Text = "Imprimir";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // datPedidos_venda
            // 
            this.datPedidos_venda.DeleteCommand = this.fbCommand28;
            this.datPedidos_venda.InsertCommand = this.fbCommand26;
            this.datPedidos_venda.SelectCommand = this.fbCommand25;
            this.datPedidos_venda.UpdateCommand = this.fbCommand27;
            // 
            // fbCommand25
            // 
            this.fbCommand25.CommandText = "select * from pedidos_venda";
            this.fbCommand25.CommandTimeout = 30;
            this.fbCommand25.Connection = this.fbConnection1;
            // 
            // fbCommand26
            // 
            this.fbCommand26.CommandTimeout = 30;
            // 
            // fbCommand27
            // 
            this.fbCommand27.CommandTimeout = 30;
            // 
            // fbCommand28
            // 
            this.fbCommand28.CommandTimeout = 30;
            // 
            // dsPedidos_venda
            // 
            this.dsPedidos_venda.DataSetName = "dsPedidos_venda";
            this.dsPedidos_venda.Namespace = "http://www.tempuri.org/dsPedidos_venda.xsd";
            this.dsPedidos_venda.Tables.AddRange(new System.Data.DataTable[] {
            this.PEDIDOS_VENDA});
            // 
            // PEDIDOS_VENDA
            // 
            this.PEDIDOS_VENDA.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_PED_VENDA,
            this.DATA_PED_VENDA,
            this.DATA_BAIXA_PED_VENDA,
            this.CLIENTE_PED_VENDA,
            this.CNPJ_PED_VENDA,
            this.COND_PGTO_PED_VENDA,
            this.VALOR_TOTAL_PROD_PED_VENDA,
            this.VALOR_TOTAL_PED_VENDA,
            this.VALOR_TOTAL_ICMS_PED_VENDA,
            this.VALOR_TOTAL_IPI_PED_VENDA,
            this.VALOR_DESCONTO_PED_VENDA,
            this.OBS_PED_VENDA,
            this.NF_PED_VENDA,
            this.BAIXADO_ESTOQUE_PED_VENDA,
            this.PAGO_PED_VENDA,
            this.COD_CAIXA_PGTO_PED_VENDA,
            this.VENDEDOR_PED_VENDA,
            this.COD_VENDEDOR_PED_VENDA,
            this.CANCELADO_PED_VENDA});
            this.PEDIDOS_VENDA.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_PED_VENDA"}, true)});
            this.PEDIDOS_VENDA.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_PED_VENDA};
            this.PEDIDOS_VENDA.TableName = "PEDIDOS_VENDA";
            // 
            // COD_PED_VENDA
            // 
            this.COD_PED_VENDA.AllowDBNull = false;
            this.COD_PED_VENDA.ColumnName = "COD_PED_VENDA";
            this.COD_PED_VENDA.DataType = typeof(int);
            // 
            // DATA_PED_VENDA
            // 
            this.DATA_PED_VENDA.ColumnName = "DATA_PED_VENDA";
            this.DATA_PED_VENDA.DataType = typeof(System.DateTime);
            // 
            // DATA_BAIXA_PED_VENDA
            // 
            this.DATA_BAIXA_PED_VENDA.ColumnName = "DATA_BAIXA_PED_VENDA";
            this.DATA_BAIXA_PED_VENDA.DataType = typeof(System.DateTime);
            // 
            // CLIENTE_PED_VENDA
            // 
            this.CLIENTE_PED_VENDA.ColumnName = "CLIENTE_PED_VENDA";
            this.CLIENTE_PED_VENDA.MaxLength = 200;
            // 
            // CNPJ_PED_VENDA
            // 
            this.CNPJ_PED_VENDA.ColumnName = "CNPJ_PED_VENDA";
            this.CNPJ_PED_VENDA.MaxLength = 30;
            // 
            // COND_PGTO_PED_VENDA
            // 
            this.COND_PGTO_PED_VENDA.ColumnName = "COND_PGTO_PED_VENDA";
            this.COND_PGTO_PED_VENDA.MaxLength = 30;
            // 
            // VALOR_TOTAL_PROD_PED_VENDA
            // 
            this.VALOR_TOTAL_PROD_PED_VENDA.ColumnName = "VALOR_TOTAL_PROD_PED_VENDA";
            this.VALOR_TOTAL_PROD_PED_VENDA.DataType = typeof(double);
            // 
            // VALOR_TOTAL_PED_VENDA
            // 
            this.VALOR_TOTAL_PED_VENDA.ColumnName = "VALOR_TOTAL_PED_VENDA";
            this.VALOR_TOTAL_PED_VENDA.DataType = typeof(double);
            // 
            // VALOR_TOTAL_ICMS_PED_VENDA
            // 
            this.VALOR_TOTAL_ICMS_PED_VENDA.ColumnName = "VALOR_TOTAL_ICMS_PED_VENDA";
            this.VALOR_TOTAL_ICMS_PED_VENDA.DataType = typeof(double);
            // 
            // VALOR_TOTAL_IPI_PED_VENDA
            // 
            this.VALOR_TOTAL_IPI_PED_VENDA.ColumnName = "VALOR_TOTAL_IPI_PED_VENDA";
            this.VALOR_TOTAL_IPI_PED_VENDA.DataType = typeof(double);
            // 
            // VALOR_DESCONTO_PED_VENDA
            // 
            this.VALOR_DESCONTO_PED_VENDA.ColumnName = "VALOR_DESCONTO_PED_VENDA";
            this.VALOR_DESCONTO_PED_VENDA.DataType = typeof(double);
            // 
            // OBS_PED_VENDA
            // 
            this.OBS_PED_VENDA.ColumnName = "OBS_PED_VENDA";
            this.OBS_PED_VENDA.MaxLength = 300;
            // 
            // NF_PED_VENDA
            // 
            this.NF_PED_VENDA.ColumnName = "NF_PED_VENDA";
            this.NF_PED_VENDA.DataType = typeof(int);
            // 
            // BAIXADO_ESTOQUE_PED_VENDA
            // 
            this.BAIXADO_ESTOQUE_PED_VENDA.ColumnName = "BAIXADO_ESTOQUE_PED_VENDA";
            this.BAIXADO_ESTOQUE_PED_VENDA.DataType = typeof(int);
            // 
            // PAGO_PED_VENDA
            // 
            this.PAGO_PED_VENDA.ColumnName = "PAGO_PED_VENDA";
            this.PAGO_PED_VENDA.DataType = typeof(int);
            // 
            // COD_CAIXA_PGTO_PED_VENDA
            // 
            this.COD_CAIXA_PGTO_PED_VENDA.ColumnName = "COD_CAIXA_PGTO_PED_VENDA";
            this.COD_CAIXA_PGTO_PED_VENDA.DataType = typeof(int);
            // 
            // VENDEDOR_PED_VENDA
            // 
            this.VENDEDOR_PED_VENDA.ColumnName = "VENDEDOR_PED_VENDA";
            this.VENDEDOR_PED_VENDA.MaxLength = 100;
            // 
            // COD_VENDEDOR_PED_VENDA
            // 
            this.COD_VENDEDOR_PED_VENDA.ColumnName = "COD_VENDEDOR_PED_VENDA";
            this.COD_VENDEDOR_PED_VENDA.DataType = typeof(int);
            // 
            // CANCELADO_PED_VENDA
            // 
            this.CANCELADO_PED_VENDA.ColumnName = "CANCELADO_PED_VENDA";
            this.CANCELADO_PED_VENDA.DataType = typeof(int);
            // 
            // form_malote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 493);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvCaixa);
            this.Controls.Add(this.apaga_registro);
            this.Controls.Add(this.salva_registro);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.novo_registro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_data);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.tb_descricao_cc);
            this.Controls.Add(this.tb_cod_cc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_cod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_valor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_descricao);
            this.Controls.Add(this.label2);
            this.Name = "form_malote";
            this.Text = "Malotes";
            this.Load += new System.EventHandler(this.form_malote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsMalotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MALOTES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaixa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCaixa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CAIXA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPedidos_venda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PEDIDOS_VENDA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datMalotes;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Data.DataSet dsMalotes;
        private System.Data.DataTable MALOTES;
        private System.Data.DataColumn COD_MALOTE;
        private System.Data.DataColumn DESCRICAO_MALOTE;
        private System.Data.DataColumn COD_CC_MALOTE;
        private System.Data.DataColumn DESCRICAO_CC_MALOTE;
        private System.Data.DataColumn DATA_MALOTE;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand5;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand6;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand7;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_descricao_cc;
        private System.Windows.Forms.TextBox tb_cod_cc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_cod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_valor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_descricao;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_data;
        private System.Windows.Forms.Button apaga_registro;
        private System.Windows.Forms.Button salva_registro;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button novo_registro;
        private System.Windows.Forms.DataGridView dgvCaixa;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datCaixa;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand12;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand10;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand9;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand11;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn cODCAIXADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRICAOCAIXADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCCAIXADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODCPCRCAIXADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRICAOCCCAIXADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORCAIXADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATACAIXADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODEXTRATOCAIXADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODFORNCLICAIXADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAZAOCLIFORNCAIXADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dUPLICATACAIXADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nFCAIXADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLANOCAIXADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cARTEIRACAIXADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dEBITOCAIXADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cREDITOCAIXADataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand13;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand14;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand15;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand16;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datContas_a_pagar;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand20;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand18;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand17;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand19;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datContas_a_receber;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand24;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand22;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand21;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand23;
        private FirebirdSql.Data.FirebirdClient.FbCommand comando_select;
        private System.Data.DataColumn dataColumn1;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbMalotes;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbCaixa;
        private System.Windows.Forms.Button button7;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datPedidos_venda;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand28;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand26;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand25;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand27;
        private System.Data.DataSet dsPedidos_venda;
        private System.Data.DataTable PEDIDOS_VENDA;
        private System.Data.DataColumn COD_PED_VENDA;
        private System.Data.DataColumn DATA_PED_VENDA;
        private System.Data.DataColumn DATA_BAIXA_PED_VENDA;
        private System.Data.DataColumn CLIENTE_PED_VENDA;
        private System.Data.DataColumn CNPJ_PED_VENDA;
        private System.Data.DataColumn COND_PGTO_PED_VENDA;
        private System.Data.DataColumn VALOR_TOTAL_PROD_PED_VENDA;
        private System.Data.DataColumn VALOR_TOTAL_PED_VENDA;
        private System.Data.DataColumn VALOR_TOTAL_ICMS_PED_VENDA;
        private System.Data.DataColumn VALOR_TOTAL_IPI_PED_VENDA;
        private System.Data.DataColumn VALOR_DESCONTO_PED_VENDA;
        private System.Data.DataColumn OBS_PED_VENDA;
        private System.Data.DataColumn NF_PED_VENDA;
        private System.Data.DataColumn BAIXADO_ESTOQUE_PED_VENDA;
        private System.Data.DataColumn PAGO_PED_VENDA;
        private System.Data.DataColumn COD_CAIXA_PGTO_PED_VENDA;
        private System.Data.DataColumn VENDEDOR_PED_VENDA;
        private System.Data.DataColumn COD_VENDEDOR_PED_VENDA;
        private System.Data.DataColumn CANCELADO_PED_VENDA;
    }
}