namespace Evolucao
{
    partial class form_pesquisa_pedido_compra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_pesquisa_pedido_compra));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvPedido_compra = new System.Windows.Forms.DataGridView();
            this.col_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nPEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAEMISSAOPEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMEFORNPEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNPJFORNPEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONDPGTOPEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATARETIRAPEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTOFINANCPEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORPARCIALPEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORIPIPEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORICMSPEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORTOTALPEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aUTORIZADOPEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMEAUTORIZANTEPEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAAUTORIZACAOPEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORAAUTORIZACAOPEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsPedido_compra = new System.Data.DataSet();
            this.PEDIDO_COMPRA = new System.Data.DataTable();
            this.COD_PED = new System.Data.DataColumn();
            this.N_PED = new System.Data.DataColumn();
            this.DATA_EMISSAO_PED = new System.Data.DataColumn();
            this.NOME_FORN_PED = new System.Data.DataColumn();
            this.CNPJ_FORN_PED = new System.Data.DataColumn();
            this.COND_PGTO_PED = new System.Data.DataColumn();
            this.DATA_RETIRA_PED = new System.Data.DataColumn();
            this.CUSTO_FINANC_PED = new System.Data.DataColumn();
            this.VALOR_PARCIAL_PED = new System.Data.DataColumn();
            this.VALOR_IPI_PED = new System.Data.DataColumn();
            this.VALOR_ICMS_PED = new System.Data.DataColumn();
            this.VALOR_TOTAL_PED = new System.Data.DataColumn();
            this.AUTORIZADO_PED = new System.Data.DataColumn();
            this.DATA_AUTORIZACAO_PED = new System.Data.DataColumn();
            this.HORA_AUTORIZACAO_PED = new System.Data.DataColumn();
            this.NOME_AUTORIZANTE_PED = new System.Data.DataColumn();
            this.dataColumn1 = new System.Data.DataColumn();
            this.datPedido_compra = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_autorizante = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_pedido = new System.Windows.Forms.TextBox();
            this.tb_forn = new System.Windows.Forms.TextBox();
            this.comando_select = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand5 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand6 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand7 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand8 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvItens_ped = new System.Windows.Forms.DataGridView();
            this.OK = new System.Windows.Forms.DataGridViewButtonColumn();
            this.col_cod_item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nPEDIDOITEMPEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_item_req = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cod_estoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITEM_ITEM_PED = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRICAOITEMPEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_qtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uNIDITEMPEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_valor_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_valor_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Req = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dATALIMITEITEMPEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPITEMPEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_chegou = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.col_nf_entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsItens_ped = new System.Data.DataSet();
            this.ITENS_PEDIDO_COMPRA = new System.Data.DataTable();
            this.COD_ITEM_PED = new System.Data.DataColumn();
            this.N_PEDIDO_ITEM_PED = new System.Data.DataColumn();
            this.COD_ITEM_REQ_ITEM_PED = new System.Data.DataColumn();
            this.OP_ITEM_PED = new System.Data.DataColumn();
            this.QTDE_ITEM_PED = new System.Data.DataColumn();
            this.UNID_ITEM_PED = new System.Data.DataColumn();
            this.VALOR_UNIT_ITEM_PED = new System.Data.DataColumn();
            this.VALOR_TOTAL_ITEM_PED = new System.Data.DataColumn();
            this.DESCRICAO_ITEM_PED = new System.Data.DataColumn();
            this.DATA_LIMITE_ITEM_PED = new System.Data.DataColumn();
            this.COD_ESTOQUE_ITEM_PED = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.datItens_ped = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand12 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand10 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand9 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand11 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido_compra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPedido_compra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PEDIDO_COMPRA)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens_ped)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsItens_ped)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITENS_PEDIDO_COMPRA)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(228, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 49);
            this.button3.TabIndex = 107;
            this.button3.Text = "Mostrar\r\nNão Autorizados";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(120, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 49);
            this.button2.TabIndex = 106;
            this.button2.Text = "Mostrar\r\nAutorizados";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 49);
            this.button1.TabIndex = 105;
            this.button1.Text = "Mostrar\r\nTodos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvPedido_compra
            // 
            this.dgvPedido_compra.AllowUserToAddRows = false;
            this.dgvPedido_compra.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedido_compra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPedido_compra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido_compra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_cod,
            this.nPEDDataGridViewTextBoxColumn,
            this.dATAEMISSAOPEDDataGridViewTextBoxColumn,
            this.nOMEFORNPEDDataGridViewTextBoxColumn,
            this.cNPJFORNPEDDataGridViewTextBoxColumn,
            this.cONDPGTOPEDDataGridViewTextBoxColumn,
            this.dATARETIRAPEDDataGridViewTextBoxColumn,
            this.cUSTOFINANCPEDDataGridViewTextBoxColumn,
            this.vALORPARCIALPEDDataGridViewTextBoxColumn,
            this.vALORIPIPEDDataGridViewTextBoxColumn,
            this.vALORICMSPEDDataGridViewTextBoxColumn,
            this.vALORTOTALPEDDataGridViewTextBoxColumn,
            this.aUTORIZADOPEDDataGridViewTextBoxColumn,
            this.nOMEAUTORIZANTEPEDDataGridViewTextBoxColumn,
            this.dATAAUTORIZACAOPEDDataGridViewTextBoxColumn,
            this.hORAAUTORIZACAOPEDDataGridViewTextBoxColumn});
            this.dgvPedido_compra.DataMember = "PEDIDO_COMPRA";
            this.dgvPedido_compra.DataSource = this.dsPedido_compra;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPedido_compra.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPedido_compra.Location = new System.Drawing.Point(6, 22);
            this.dgvPedido_compra.Name = "dgvPedido_compra";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedido_compra.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPedido_compra.Size = new System.Drawing.Size(857, 223);
            this.dgvPedido_compra.TabIndex = 104;
            this.dgvPedido_compra.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedido_compra_CellContentDoubleClick);
            this.dgvPedido_compra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedido_compra_CellContentClick);
            // 
            // col_cod
            // 
            this.col_cod.DataPropertyName = "COD_PED";
            this.col_cod.HeaderText = "Cód.";
            this.col_cod.Name = "col_cod";
            this.col_cod.Width = 40;
            // 
            // nPEDDataGridViewTextBoxColumn
            // 
            this.nPEDDataGridViewTextBoxColumn.DataPropertyName = "N_PED";
            this.nPEDDataGridViewTextBoxColumn.HeaderText = "N_PED";
            this.nPEDDataGridViewTextBoxColumn.Name = "nPEDDataGridViewTextBoxColumn";
            this.nPEDDataGridViewTextBoxColumn.Visible = false;
            // 
            // dATAEMISSAOPEDDataGridViewTextBoxColumn
            // 
            this.dATAEMISSAOPEDDataGridViewTextBoxColumn.DataPropertyName = "DATA_EMISSAO_PED";
            this.dATAEMISSAOPEDDataGridViewTextBoxColumn.HeaderText = "Emissão";
            this.dATAEMISSAOPEDDataGridViewTextBoxColumn.Name = "dATAEMISSAOPEDDataGridViewTextBoxColumn";
            this.dATAEMISSAOPEDDataGridViewTextBoxColumn.Width = 80;
            // 
            // nOMEFORNPEDDataGridViewTextBoxColumn
            // 
            this.nOMEFORNPEDDataGridViewTextBoxColumn.DataPropertyName = "NOME_FORN_PED";
            this.nOMEFORNPEDDataGridViewTextBoxColumn.HeaderText = "Fornecedor";
            this.nOMEFORNPEDDataGridViewTextBoxColumn.Name = "nOMEFORNPEDDataGridViewTextBoxColumn";
            this.nOMEFORNPEDDataGridViewTextBoxColumn.Width = 150;
            // 
            // cNPJFORNPEDDataGridViewTextBoxColumn
            // 
            this.cNPJFORNPEDDataGridViewTextBoxColumn.DataPropertyName = "CNPJ_FORN_PED";
            this.cNPJFORNPEDDataGridViewTextBoxColumn.HeaderText = "CNPJ_FORN_PED";
            this.cNPJFORNPEDDataGridViewTextBoxColumn.Name = "cNPJFORNPEDDataGridViewTextBoxColumn";
            this.cNPJFORNPEDDataGridViewTextBoxColumn.Visible = false;
            // 
            // cONDPGTOPEDDataGridViewTextBoxColumn
            // 
            this.cONDPGTOPEDDataGridViewTextBoxColumn.DataPropertyName = "COND_PGTO_PED";
            this.cONDPGTOPEDDataGridViewTextBoxColumn.HeaderText = "Cond. Pgto";
            this.cONDPGTOPEDDataGridViewTextBoxColumn.Name = "cONDPGTOPEDDataGridViewTextBoxColumn";
            this.cONDPGTOPEDDataGridViewTextBoxColumn.Width = 60;
            // 
            // dATARETIRAPEDDataGridViewTextBoxColumn
            // 
            this.dATARETIRAPEDDataGridViewTextBoxColumn.DataPropertyName = "DATA_RETIRA_PED";
            this.dATARETIRAPEDDataGridViewTextBoxColumn.HeaderText = "Retira";
            this.dATARETIRAPEDDataGridViewTextBoxColumn.Name = "dATARETIRAPEDDataGridViewTextBoxColumn";
            this.dATARETIRAPEDDataGridViewTextBoxColumn.Width = 80;
            // 
            // cUSTOFINANCPEDDataGridViewTextBoxColumn
            // 
            this.cUSTOFINANCPEDDataGridViewTextBoxColumn.DataPropertyName = "CUSTO_FINANC_PED";
            this.cUSTOFINANCPEDDataGridViewTextBoxColumn.HeaderText = "CUSTO_FINANC_PED";
            this.cUSTOFINANCPEDDataGridViewTextBoxColumn.Name = "cUSTOFINANCPEDDataGridViewTextBoxColumn";
            this.cUSTOFINANCPEDDataGridViewTextBoxColumn.Visible = false;
            // 
            // vALORPARCIALPEDDataGridViewTextBoxColumn
            // 
            this.vALORPARCIALPEDDataGridViewTextBoxColumn.DataPropertyName = "VALOR_PARCIAL_PED";
            this.vALORPARCIALPEDDataGridViewTextBoxColumn.HeaderText = "VALOR_PARCIAL_PED";
            this.vALORPARCIALPEDDataGridViewTextBoxColumn.Name = "vALORPARCIALPEDDataGridViewTextBoxColumn";
            this.vALORPARCIALPEDDataGridViewTextBoxColumn.Visible = false;
            // 
            // vALORIPIPEDDataGridViewTextBoxColumn
            // 
            this.vALORIPIPEDDataGridViewTextBoxColumn.DataPropertyName = "VALOR_IPI_PED";
            this.vALORIPIPEDDataGridViewTextBoxColumn.HeaderText = "VALOR_IPI_PED";
            this.vALORIPIPEDDataGridViewTextBoxColumn.Name = "vALORIPIPEDDataGridViewTextBoxColumn";
            this.vALORIPIPEDDataGridViewTextBoxColumn.Visible = false;
            // 
            // vALORICMSPEDDataGridViewTextBoxColumn
            // 
            this.vALORICMSPEDDataGridViewTextBoxColumn.DataPropertyName = "VALOR_ICMS_PED";
            this.vALORICMSPEDDataGridViewTextBoxColumn.HeaderText = "VALOR_ICMS_PED";
            this.vALORICMSPEDDataGridViewTextBoxColumn.Name = "vALORICMSPEDDataGridViewTextBoxColumn";
            this.vALORICMSPEDDataGridViewTextBoxColumn.Visible = false;
            // 
            // vALORTOTALPEDDataGridViewTextBoxColumn
            // 
            this.vALORTOTALPEDDataGridViewTextBoxColumn.DataPropertyName = "VALOR_TOTAL_PED";
            this.vALORTOTALPEDDataGridViewTextBoxColumn.HeaderText = "Valor Total";
            this.vALORTOTALPEDDataGridViewTextBoxColumn.Name = "vALORTOTALPEDDataGridViewTextBoxColumn";
            // 
            // aUTORIZADOPEDDataGridViewTextBoxColumn
            // 
            this.aUTORIZADOPEDDataGridViewTextBoxColumn.DataPropertyName = "AUTORIZADO_PED";
            this.aUTORIZADOPEDDataGridViewTextBoxColumn.HeaderText = "AUTORIZADO_PED";
            this.aUTORIZADOPEDDataGridViewTextBoxColumn.Name = "aUTORIZADOPEDDataGridViewTextBoxColumn";
            this.aUTORIZADOPEDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nOMEAUTORIZANTEPEDDataGridViewTextBoxColumn
            // 
            this.nOMEAUTORIZANTEPEDDataGridViewTextBoxColumn.DataPropertyName = "NOME_AUTORIZANTE_PED";
            this.nOMEAUTORIZANTEPEDDataGridViewTextBoxColumn.HeaderText = "Autorizante";
            this.nOMEAUTORIZANTEPEDDataGridViewTextBoxColumn.Name = "nOMEAUTORIZANTEPEDDataGridViewTextBoxColumn";
            this.nOMEAUTORIZANTEPEDDataGridViewTextBoxColumn.Width = 150;
            // 
            // dATAAUTORIZACAOPEDDataGridViewTextBoxColumn
            // 
            this.dATAAUTORIZACAOPEDDataGridViewTextBoxColumn.DataPropertyName = "DATA_AUTORIZACAO_PED";
            this.dATAAUTORIZACAOPEDDataGridViewTextBoxColumn.HeaderText = "Data Autorização";
            this.dATAAUTORIZACAOPEDDataGridViewTextBoxColumn.Name = "dATAAUTORIZACAOPEDDataGridViewTextBoxColumn";
            this.dATAAUTORIZACAOPEDDataGridViewTextBoxColumn.Width = 80;
            // 
            // hORAAUTORIZACAOPEDDataGridViewTextBoxColumn
            // 
            this.hORAAUTORIZACAOPEDDataGridViewTextBoxColumn.DataPropertyName = "HORA_AUTORIZACAO_PED";
            this.hORAAUTORIZACAOPEDDataGridViewTextBoxColumn.HeaderText = "Hora Autorização";
            this.hORAAUTORIZACAOPEDDataGridViewTextBoxColumn.Name = "hORAAUTORIZACAOPEDDataGridViewTextBoxColumn";
            this.hORAAUTORIZACAOPEDDataGridViewTextBoxColumn.Width = 80;
            // 
            // dsPedido_compra
            // 
            this.dsPedido_compra.DataSetName = "dsPedido_compra";
            this.dsPedido_compra.Namespace = "http://www.tempuri.org/dsPedido_compra.xsd";
            this.dsPedido_compra.Tables.AddRange(new System.Data.DataTable[] {
            this.PEDIDO_COMPRA});
            // 
            // PEDIDO_COMPRA
            // 
            this.PEDIDO_COMPRA.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_PED,
            this.N_PED,
            this.DATA_EMISSAO_PED,
            this.NOME_FORN_PED,
            this.CNPJ_FORN_PED,
            this.COND_PGTO_PED,
            this.DATA_RETIRA_PED,
            this.CUSTO_FINANC_PED,
            this.VALOR_PARCIAL_PED,
            this.VALOR_IPI_PED,
            this.VALOR_ICMS_PED,
            this.VALOR_TOTAL_PED,
            this.AUTORIZADO_PED,
            this.DATA_AUTORIZACAO_PED,
            this.HORA_AUTORIZACAO_PED,
            this.NOME_AUTORIZANTE_PED,
            this.dataColumn1});
            this.PEDIDO_COMPRA.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_PED"}, true)});
            this.PEDIDO_COMPRA.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_PED};
            this.PEDIDO_COMPRA.TableName = "PEDIDO_COMPRA";
            // 
            // COD_PED
            // 
            this.COD_PED.AllowDBNull = false;
            this.COD_PED.ColumnName = "COD_PED";
            this.COD_PED.DataType = typeof(int);
            // 
            // N_PED
            // 
            this.N_PED.ColumnName = "N_PED";
            this.N_PED.DataType = typeof(int);
            // 
            // DATA_EMISSAO_PED
            // 
            this.DATA_EMISSAO_PED.ColumnName = "DATA_EMISSAO_PED";
            this.DATA_EMISSAO_PED.DataType = typeof(System.DateTime);
            // 
            // NOME_FORN_PED
            // 
            this.NOME_FORN_PED.ColumnName = "NOME_FORN_PED";
            this.NOME_FORN_PED.MaxLength = 250;
            // 
            // CNPJ_FORN_PED
            // 
            this.CNPJ_FORN_PED.ColumnName = "CNPJ_FORN_PED";
            this.CNPJ_FORN_PED.MaxLength = 30;
            // 
            // COND_PGTO_PED
            // 
            this.COND_PGTO_PED.ColumnName = "COND_PGTO_PED";
            this.COND_PGTO_PED.MaxLength = 50;
            // 
            // DATA_RETIRA_PED
            // 
            this.DATA_RETIRA_PED.ColumnName = "DATA_RETIRA_PED";
            this.DATA_RETIRA_PED.DataType = typeof(System.DateTime);
            // 
            // CUSTO_FINANC_PED
            // 
            this.CUSTO_FINANC_PED.ColumnName = "CUSTO_FINANC_PED";
            this.CUSTO_FINANC_PED.MaxLength = 50;
            // 
            // VALOR_PARCIAL_PED
            // 
            this.VALOR_PARCIAL_PED.ColumnName = "VALOR_PARCIAL_PED";
            this.VALOR_PARCIAL_PED.DataType = typeof(double);
            // 
            // VALOR_IPI_PED
            // 
            this.VALOR_IPI_PED.ColumnName = "VALOR_IPI_PED";
            this.VALOR_IPI_PED.MaxLength = 50;
            // 
            // VALOR_ICMS_PED
            // 
            this.VALOR_ICMS_PED.ColumnName = "VALOR_ICMS_PED";
            this.VALOR_ICMS_PED.MaxLength = 50;
            // 
            // VALOR_TOTAL_PED
            // 
            this.VALOR_TOTAL_PED.ColumnName = "VALOR_TOTAL_PED";
            this.VALOR_TOTAL_PED.DataType = typeof(double);
            // 
            // AUTORIZADO_PED
            // 
            this.AUTORIZADO_PED.ColumnName = "AUTORIZADO_PED";
            this.AUTORIZADO_PED.DataType = typeof(int);
            // 
            // DATA_AUTORIZACAO_PED
            // 
            this.DATA_AUTORIZACAO_PED.ColumnName = "DATA_AUTORIZACAO_PED";
            this.DATA_AUTORIZACAO_PED.DataType = typeof(System.DateTime);
            // 
            // HORA_AUTORIZACAO_PED
            // 
            this.HORA_AUTORIZACAO_PED.ColumnName = "HORA_AUTORIZACAO_PED";
            this.HORA_AUTORIZACAO_PED.MaxLength = 10;
            // 
            // NOME_AUTORIZANTE_PED
            // 
            this.NOME_AUTORIZANTE_PED.ColumnName = "NOME_AUTORIZANTE_PED";
            this.NOME_AUTORIZANTE_PED.MaxLength = 50;
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "EFETUADO_PED";
            this.dataColumn1.DataType = typeof(int);
            // 
            // datPedido_compra
            // 
            this.datPedido_compra.DeleteCommand = this.fbCommand4;
            this.datPedido_compra.InsertCommand = this.fbCommand2;
            this.datPedido_compra.SelectCommand = this.fbCommand1;
            this.datPedido_compra.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * from pedido_compra";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_autorizante);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_pedido);
            this.groupBox1.Controls.Add(this.tb_forn);
            this.groupBox1.Location = new System.Drawing.Point(350, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 99);
            this.groupBox1.TabIndex = 109;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(217, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 109;
            this.label3.Text = "Digite o autorizante:";
            // 
            // tb_autorizante
            // 
            this.tb_autorizante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_autorizante.Location = new System.Drawing.Point(220, 71);
            this.tb_autorizante.Name = "tb_autorizante";
            this.tb_autorizante.Size = new System.Drawing.Size(208, 23);
            this.tb_autorizante.TabIndex = 108;
            this.tb_autorizante.TextChanged += new System.EventHandler(this.tb_autorizante_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 13);
            this.label2.TabIndex = 107;
            this.label2.Text = "Digite o pedido de compra e tecle <Enter>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 106;
            this.label1.Text = "Digite o fornecedor:";
            // 
            // tb_pedido
            // 
            this.tb_pedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_pedido.Location = new System.Drawing.Point(6, 29);
            this.tb_pedido.Name = "tb_pedido";
            this.tb_pedido.Size = new System.Drawing.Size(69, 23);
            this.tb_pedido.TabIndex = 105;
            this.tb_pedido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_requisicao_KeyPress);
            // 
            // tb_forn
            // 
            this.tb_forn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_forn.Location = new System.Drawing.Point(6, 71);
            this.tb_forn.Name = "tb_forn";
            this.tb_forn.Size = new System.Drawing.Size(208, 23);
            this.tb_forn.TabIndex = 104;
            this.tb_forn.TextChanged += new System.EventHandler(this.tb_item_TextChanged);
            // 
            // comando_select
            // 
            this.comando_select.CommandTimeout = 30;
            this.comando_select.Connection = this.fbConnection1;
            // 
            // fbCommand5
            // 
            this.fbCommand5.CommandText = "select * from itens_pedido_compra";
            this.fbCommand5.CommandTimeout = 30;
            this.fbCommand5.Connection = this.fbConnection1;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvPedido_compra);
            this.groupBox2.Location = new System.Drawing.Point(9, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(869, 251);
            this.groupBox2.TabIndex = 110;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pedidos de Compra";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvItens_ped);
            this.groupBox3.Location = new System.Drawing.Point(9, 360);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(872, 207);
            this.groupBox3.TabIndex = 111;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Itens Pedido de Compra";
            // 
            // dgvItens_ped
            // 
            this.dgvItens_ped.AllowUserToAddRows = false;
            this.dgvItens_ped.AllowUserToResizeColumns = false;
            this.dgvItens_ped.AllowUserToResizeRows = false;
            this.dgvItens_ped.AutoGenerateColumns = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItens_ped.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvItens_ped.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens_ped.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OK,
            this.col_cod_item,
            this.nPEDIDOITEMPEDDataGridViewTextBoxColumn,
            this.col_item_req,
            this.col_cod_estoque,
            this.ITEM_ITEM_PED,
            this.dESCRICAOITEMPEDDataGridViewTextBoxColumn,
            this.col_qtde,
            this.uNIDITEMPEDDataGridViewTextBoxColumn,
            this.col_valor_unit,
            this.col_valor_total,
            this.Req,
            this.dATALIMITEITEMPEDDataGridViewTextBoxColumn,
            this.oPITEMPEDDataGridViewTextBoxColumn,
            this.col_chegou,
            this.col_nf_entrada});
            this.dgvItens_ped.DataMember = "ITENS_PEDIDO_COMPRA";
            this.dgvItens_ped.DataSource = this.dsItens_ped;
            this.dgvItens_ped.Location = new System.Drawing.Point(6, 19);
            this.dgvItens_ped.Name = "dgvItens_ped";
            this.dgvItens_ped.Size = new System.Drawing.Size(857, 182);
            this.dgvItens_ped.TabIndex = 108;
            this.dgvItens_ped.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItens_ped_CellContentClick);
            // 
            // OK
            // 
            this.OK.HeaderText = "OK";
            this.OK.Name = "OK";
            this.OK.Text = "OK";
            this.OK.ToolTipText = "OK";
            this.OK.UseColumnTextForButtonValue = true;
            this.OK.Width = 30;
            // 
            // col_cod_item
            // 
            this.col_cod_item.DataPropertyName = "COD_ITEM_PED";
            this.col_cod_item.HeaderText = "Cód.";
            this.col_cod_item.Name = "col_cod_item";
            this.col_cod_item.Width = 30;
            // 
            // nPEDIDOITEMPEDDataGridViewTextBoxColumn
            // 
            this.nPEDIDOITEMPEDDataGridViewTextBoxColumn.DataPropertyName = "N_PEDIDO_ITEM_PED";
            this.nPEDIDOITEMPEDDataGridViewTextBoxColumn.HeaderText = "Nº Item Pedido";
            this.nPEDIDOITEMPEDDataGridViewTextBoxColumn.Name = "nPEDIDOITEMPEDDataGridViewTextBoxColumn";
            this.nPEDIDOITEMPEDDataGridViewTextBoxColumn.Visible = false;
            this.nPEDIDOITEMPEDDataGridViewTextBoxColumn.Width = 85;
            // 
            // col_item_req
            // 
            this.col_item_req.DataPropertyName = "COD_ITEM_REQ_ITEM_PED";
            this.col_item_req.HeaderText = "Nº Item Requisição";
            this.col_item_req.Name = "col_item_req";
            this.col_item_req.Width = 85;
            // 
            // col_cod_estoque
            // 
            this.col_cod_estoque.DataPropertyName = "COD_ESTOQUE_ITEM_PED";
            this.col_cod_estoque.HeaderText = "Cód. Estoque";
            this.col_cod_estoque.Name = "col_cod_estoque";
            this.col_cod_estoque.Width = 70;
            // 
            // ITEM_ITEM_PED
            // 
            this.ITEM_ITEM_PED.DataPropertyName = "ITEM_ITEM_PED";
            this.ITEM_ITEM_PED.HeaderText = "Item";
            this.ITEM_ITEM_PED.Name = "ITEM_ITEM_PED";
            // 
            // dESCRICAOITEMPEDDataGridViewTextBoxColumn
            // 
            this.dESCRICAOITEMPEDDataGridViewTextBoxColumn.DataPropertyName = "DESCRICAO_ITEM_PED";
            this.dESCRICAOITEMPEDDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.dESCRICAOITEMPEDDataGridViewTextBoxColumn.Name = "dESCRICAOITEMPEDDataGridViewTextBoxColumn";
            this.dESCRICAOITEMPEDDataGridViewTextBoxColumn.Width = 155;
            // 
            // col_qtde
            // 
            this.col_qtde.DataPropertyName = "QTDE_ITEM_PED";
            this.col_qtde.HeaderText = "Qtde";
            this.col_qtde.Name = "col_qtde";
            this.col_qtde.Width = 40;
            // 
            // uNIDITEMPEDDataGridViewTextBoxColumn
            // 
            this.uNIDITEMPEDDataGridViewTextBoxColumn.DataPropertyName = "UNID_ITEM_PED";
            this.uNIDITEMPEDDataGridViewTextBoxColumn.HeaderText = "Unid.";
            this.uNIDITEMPEDDataGridViewTextBoxColumn.Name = "uNIDITEMPEDDataGridViewTextBoxColumn";
            this.uNIDITEMPEDDataGridViewTextBoxColumn.Width = 40;
            // 
            // col_valor_unit
            // 
            this.col_valor_unit.DataPropertyName = "VALOR_UNIT_ITEM_PED";
            this.col_valor_unit.HeaderText = "Valor Unit.";
            this.col_valor_unit.Name = "col_valor_unit";
            this.col_valor_unit.Width = 90;
            // 
            // col_valor_total
            // 
            this.col_valor_total.DataPropertyName = "VALOR_TOTAL_ITEM_PED";
            this.col_valor_total.HeaderText = "Valor Total";
            this.col_valor_total.Name = "col_valor_total";
            this.col_valor_total.Width = 90;
            // 
            // Req
            // 
            this.Req.HeaderText = "Req";
            this.Req.Name = "Req";
            this.Req.Text = "Req";
            this.Req.ToolTipText = "Req";
            this.Req.UseColumnTextForButtonValue = true;
            this.Req.Width = 50;
            // 
            // dATALIMITEITEMPEDDataGridViewTextBoxColumn
            // 
            this.dATALIMITEITEMPEDDataGridViewTextBoxColumn.DataPropertyName = "DATA_LIMITE_ITEM_PED";
            this.dATALIMITEITEMPEDDataGridViewTextBoxColumn.HeaderText = "Data Limite ";
            this.dATALIMITEITEMPEDDataGridViewTextBoxColumn.Name = "dATALIMITEITEMPEDDataGridViewTextBoxColumn";
            // 
            // oPITEMPEDDataGridViewTextBoxColumn
            // 
            this.oPITEMPEDDataGridViewTextBoxColumn.DataPropertyName = "OP_ITEM_PED";
            this.oPITEMPEDDataGridViewTextBoxColumn.HeaderText = "OP";
            this.oPITEMPEDDataGridViewTextBoxColumn.Name = "oPITEMPEDDataGridViewTextBoxColumn";
            // 
            // col_chegou
            // 
            this.col_chegou.DataPropertyName = "CHEGOU_ITEM_PED";
            this.col_chegou.FalseValue = "0";
            this.col_chegou.HeaderText = "Chegou?";
            this.col_chegou.IndeterminateValue = "0";
            this.col_chegou.Name = "col_chegou";
            this.col_chegou.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_chegou.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_chegou.TrueValue = "1";
            this.col_chegou.Width = 40;
            // 
            // col_nf_entrada
            // 
            this.col_nf_entrada.DataPropertyName = "COD_NF_ENTRADA_ITEM_PED";
            this.col_nf_entrada.HeaderText = "Cód. NF Entrada";
            this.col_nf_entrada.Name = "col_nf_entrada";
            // 
            // dsItens_ped
            // 
            this.dsItens_ped.DataSetName = "dsItens_ped";
            this.dsItens_ped.Namespace = "http://www.tempuri.org/dsItens_ped.xsd";
            this.dsItens_ped.Tables.AddRange(new System.Data.DataTable[] {
            this.ITENS_PEDIDO_COMPRA});
            // 
            // ITENS_PEDIDO_COMPRA
            // 
            this.ITENS_PEDIDO_COMPRA.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_ITEM_PED,
            this.N_PEDIDO_ITEM_PED,
            this.COD_ITEM_REQ_ITEM_PED,
            this.OP_ITEM_PED,
            this.QTDE_ITEM_PED,
            this.UNID_ITEM_PED,
            this.VALOR_UNIT_ITEM_PED,
            this.VALOR_TOTAL_ITEM_PED,
            this.DESCRICAO_ITEM_PED,
            this.DATA_LIMITE_ITEM_PED,
            this.COD_ESTOQUE_ITEM_PED,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4});
            this.ITENS_PEDIDO_COMPRA.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_ITEM_PED"}, true)});
            this.ITENS_PEDIDO_COMPRA.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_ITEM_PED};
            this.ITENS_PEDIDO_COMPRA.TableName = "ITENS_PEDIDO_COMPRA";
            // 
            // COD_ITEM_PED
            // 
            this.COD_ITEM_PED.AllowDBNull = false;
            this.COD_ITEM_PED.ColumnName = "COD_ITEM_PED";
            this.COD_ITEM_PED.DataType = typeof(int);
            // 
            // N_PEDIDO_ITEM_PED
            // 
            this.N_PEDIDO_ITEM_PED.ColumnName = "N_PEDIDO_ITEM_PED";
            this.N_PEDIDO_ITEM_PED.DataType = typeof(int);
            // 
            // COD_ITEM_REQ_ITEM_PED
            // 
            this.COD_ITEM_REQ_ITEM_PED.ColumnName = "COD_ITEM_REQ_ITEM_PED";
            this.COD_ITEM_REQ_ITEM_PED.DataType = typeof(int);
            // 
            // OP_ITEM_PED
            // 
            this.OP_ITEM_PED.ColumnName = "OP_ITEM_PED";
            this.OP_ITEM_PED.MaxLength = 50;
            // 
            // QTDE_ITEM_PED
            // 
            this.QTDE_ITEM_PED.ColumnName = "QTDE_ITEM_PED";
            this.QTDE_ITEM_PED.DataType = typeof(double);
            // 
            // UNID_ITEM_PED
            // 
            this.UNID_ITEM_PED.ColumnName = "UNID_ITEM_PED";
            this.UNID_ITEM_PED.MaxLength = 10;
            // 
            // VALOR_UNIT_ITEM_PED
            // 
            this.VALOR_UNIT_ITEM_PED.ColumnName = "VALOR_UNIT_ITEM_PED";
            this.VALOR_UNIT_ITEM_PED.DataType = typeof(double);
            // 
            // VALOR_TOTAL_ITEM_PED
            // 
            this.VALOR_TOTAL_ITEM_PED.ColumnName = "VALOR_TOTAL_ITEM_PED";
            this.VALOR_TOTAL_ITEM_PED.DataType = typeof(double);
            // 
            // DESCRICAO_ITEM_PED
            // 
            this.DESCRICAO_ITEM_PED.ColumnName = "DESCRICAO_ITEM_PED";
            this.DESCRICAO_ITEM_PED.MaxLength = 250;
            // 
            // DATA_LIMITE_ITEM_PED
            // 
            this.DATA_LIMITE_ITEM_PED.ColumnName = "DATA_LIMITE_ITEM_PED";
            this.DATA_LIMITE_ITEM_PED.DataType = typeof(System.DateTime);
            // 
            // COD_ESTOQUE_ITEM_PED
            // 
            this.COD_ESTOQUE_ITEM_PED.ColumnName = "COD_ESTOQUE_ITEM_PED";
            this.COD_ESTOQUE_ITEM_PED.DataType = typeof(int);
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "CHEGOU_ITEM_PED";
            this.dataColumn2.DataType = typeof(int);
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "COD_NF_ENTRADA_ITEM_PED";
            this.dataColumn3.DataType = typeof(int);
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "ITEM_ITEM_PED";
            this.dataColumn4.MaxLength = 200;
            // 
            // datItens_ped
            // 
            this.datItens_ped.DeleteCommand = this.fbCommand12;
            this.datItens_ped.InsertCommand = this.fbCommand10;
            this.datItens_ped.SelectCommand = this.fbCommand9;
            this.datItens_ped.UpdateCommand = this.fbCommand11;
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
            this.fbCommand9.CommandText = "select * from itens_pedido_COMPRA";
            this.fbCommand9.CommandTimeout = 30;
            this.fbCommand9.Connection = this.fbConnection1;
            // 
            // fbCommand11
            // 
            this.fbCommand11.CommandTimeout = 30;
            // 
            // form_pesquisa_pedido_compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 575);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "form_pesquisa_pedido_compra";
            this.Text = "Pesquisa Pedido Compra";
            this.Load += new System.EventHandler(this.form_pesquisa_pedido_compra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido_compra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPedido_compra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PEDIDO_COMPRA)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens_ped)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsItens_ped)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITENS_PEDIDO_COMPRA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvPedido_compra;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datPedido_compra;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Data.DataSet dsPedido_compra;
        private System.Data.DataTable PEDIDO_COMPRA;
        private System.Data.DataColumn COD_PED;
        private System.Data.DataColumn N_PED;
        private System.Data.DataColumn DATA_EMISSAO_PED;
        private System.Data.DataColumn NOME_FORN_PED;
        private System.Data.DataColumn CNPJ_FORN_PED;
        private System.Data.DataColumn COND_PGTO_PED;
        private System.Data.DataColumn DATA_RETIRA_PED;
        private System.Data.DataColumn CUSTO_FINANC_PED;
        private System.Data.DataColumn VALOR_PARCIAL_PED;
        private System.Data.DataColumn VALOR_IPI_PED;
        private System.Data.DataColumn VALOR_ICMS_PED;
        private System.Data.DataColumn VALOR_TOTAL_PED;
        private System.Data.DataColumn AUTORIZADO_PED;
        private System.Data.DataColumn DATA_AUTORIZACAO_PED;
        private System.Data.DataColumn HORA_AUTORIZACAO_PED;
        private System.Data.DataColumn NOME_AUTORIZANTE_PED;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_autorizante;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_pedido;
        private System.Windows.Forms.TextBox tb_forn;
        private FirebirdSql.Data.FirebirdClient.FbCommand comando_select;
        private System.Data.DataColumn dataColumn1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand5;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand6;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand7;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datItens_ped;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand12;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand10;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand9;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand11;
        private System.Data.DataSet dsItens_ped;
        private System.Data.DataTable ITENS_PEDIDO_COMPRA;
        private System.Data.DataColumn COD_ITEM_PED;
        private System.Data.DataColumn N_PEDIDO_ITEM_PED;
        private System.Data.DataColumn COD_ITEM_REQ_ITEM_PED;
        private System.Data.DataColumn OP_ITEM_PED;
        private System.Data.DataColumn QTDE_ITEM_PED;
        private System.Data.DataColumn UNID_ITEM_PED;
        private System.Data.DataColumn VALOR_UNIT_ITEM_PED;
        private System.Data.DataColumn VALOR_TOTAL_ITEM_PED;
        private System.Data.DataColumn DESCRICAO_ITEM_PED;
        private System.Data.DataColumn DATA_LIMITE_ITEM_PED;
        private System.Data.DataColumn COD_ESTOQUE_ITEM_PED;
        private System.Windows.Forms.DataGridView dgvItens_ped;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn nPEDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAEMISSAOPEDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMEFORNPEDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPJFORNPEDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONDPGTOPEDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATARETIRAPEDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSTOFINANCPEDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORPARCIALPEDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORIPIPEDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORICMSPEDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORTOTALPEDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aUTORIZADOPEDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMEAUTORIZANTEPEDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAAUTORIZACAOPEDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORAAUTORIZACAOPEDDataGridViewTextBoxColumn;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Windows.Forms.DataGridViewButtonColumn OK;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn nPEDIDOITEMPEDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_item_req;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod_estoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEM_ITEM_PED;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRICAOITEMPEDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_qtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn uNIDITEMPEDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_valor_unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_valor_total;
        private System.Windows.Forms.DataGridViewButtonColumn Req;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATALIMITEITEMPEDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPITEMPEDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_chegou;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nf_entrada;
        private System.Data.DataColumn dataColumn4;
    }
}