namespace Evolucao
{
    partial class form_localiza_ped
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_localiza_ped));
            this.tb_localiza = new System.Windows.Forms.TextBox();
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
            this.dATAAUTORIZACAOPEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORAAUTORIZACAOPEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODAUTORIZANTEPEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.COD_AUTORIZANTE_PED = new System.Data.DataColumn();
            this.datPedido_compra = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido_compra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPedido_compra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PEDIDO_COMPRA)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_localiza
            // 
            this.tb_localiza.Location = new System.Drawing.Point(2, 4);
            this.tb_localiza.Name = "tb_localiza";
            this.tb_localiza.Size = new System.Drawing.Size(77, 20);
            this.tb_localiza.TabIndex = 1;
            this.tb_localiza.TextChanged += new System.EventHandler(this.tb_localiza_TextChanged);
            // 
            // dgvPedido_compra
            // 
            this.dgvPedido_compra.AllowUserToAddRows = false;
            this.dgvPedido_compra.AutoGenerateColumns = false;
            this.dgvPedido_compra.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPedido_compra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido_compra.ColumnHeadersVisible = false;
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
            this.dATAAUTORIZACAOPEDDataGridViewTextBoxColumn,
            this.hORAAUTORIZACAOPEDDataGridViewTextBoxColumn,
            this.cODAUTORIZANTEPEDDataGridViewTextBoxColumn});
            this.dgvPedido_compra.DataMember = "PEDIDO_COMPRA";
            this.dgvPedido_compra.DataSource = this.dsPedido_compra;
            this.dgvPedido_compra.Location = new System.Drawing.Point(2, 24);
            this.dgvPedido_compra.Name = "dgvPedido_compra";
            this.dgvPedido_compra.ReadOnly = true;
            this.dgvPedido_compra.RowHeadersVisible = false;
            this.dgvPedido_compra.Size = new System.Drawing.Size(438, 301);
            this.dgvPedido_compra.TabIndex = 2;
            this.dgvPedido_compra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRequisicoes_CellContentClick);
            // 
            // col_cod
            // 
            this.col_cod.DataPropertyName = "COD_PED";
            this.col_cod.HeaderText = "COD_PED";
            this.col_cod.Name = "col_cod";
            this.col_cod.ReadOnly = true;
            this.col_cod.Width = 50;
            // 
            // nPEDDataGridViewTextBoxColumn
            // 
            this.nPEDDataGridViewTextBoxColumn.DataPropertyName = "N_PED";
            this.nPEDDataGridViewTextBoxColumn.HeaderText = "N_PED";
            this.nPEDDataGridViewTextBoxColumn.Name = "nPEDDataGridViewTextBoxColumn";
            this.nPEDDataGridViewTextBoxColumn.ReadOnly = true;
            this.nPEDDataGridViewTextBoxColumn.Visible = false;
            // 
            // dATAEMISSAOPEDDataGridViewTextBoxColumn
            // 
            this.dATAEMISSAOPEDDataGridViewTextBoxColumn.DataPropertyName = "DATA_EMISSAO_PED";
            this.dATAEMISSAOPEDDataGridViewTextBoxColumn.HeaderText = "DATA_EMISSAO_PED";
            this.dATAEMISSAOPEDDataGridViewTextBoxColumn.Name = "dATAEMISSAOPEDDataGridViewTextBoxColumn";
            this.dATAEMISSAOPEDDataGridViewTextBoxColumn.ReadOnly = true;
            this.dATAEMISSAOPEDDataGridViewTextBoxColumn.Width = 70;
            // 
            // nOMEFORNPEDDataGridViewTextBoxColumn
            // 
            this.nOMEFORNPEDDataGridViewTextBoxColumn.DataPropertyName = "NOME_FORN_PED";
            this.nOMEFORNPEDDataGridViewTextBoxColumn.HeaderText = "NOME_FORN_PED";
            this.nOMEFORNPEDDataGridViewTextBoxColumn.Name = "nOMEFORNPEDDataGridViewTextBoxColumn";
            this.nOMEFORNPEDDataGridViewTextBoxColumn.ReadOnly = true;
            this.nOMEFORNPEDDataGridViewTextBoxColumn.Width = 250;
            // 
            // cNPJFORNPEDDataGridViewTextBoxColumn
            // 
            this.cNPJFORNPEDDataGridViewTextBoxColumn.DataPropertyName = "CNPJ_FORN_PED";
            this.cNPJFORNPEDDataGridViewTextBoxColumn.HeaderText = "CNPJ_FORN_PED";
            this.cNPJFORNPEDDataGridViewTextBoxColumn.Name = "cNPJFORNPEDDataGridViewTextBoxColumn";
            this.cNPJFORNPEDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cNPJFORNPEDDataGridViewTextBoxColumn.Visible = false;
            // 
            // cONDPGTOPEDDataGridViewTextBoxColumn
            // 
            this.cONDPGTOPEDDataGridViewTextBoxColumn.DataPropertyName = "COND_PGTO_PED";
            this.cONDPGTOPEDDataGridViewTextBoxColumn.HeaderText = "COND_PGTO_PED";
            this.cONDPGTOPEDDataGridViewTextBoxColumn.Name = "cONDPGTOPEDDataGridViewTextBoxColumn";
            this.cONDPGTOPEDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cONDPGTOPEDDataGridViewTextBoxColumn.Visible = false;
            // 
            // dATARETIRAPEDDataGridViewTextBoxColumn
            // 
            this.dATARETIRAPEDDataGridViewTextBoxColumn.DataPropertyName = "DATA_RETIRA_PED";
            this.dATARETIRAPEDDataGridViewTextBoxColumn.HeaderText = "DATA_RETIRA_PED";
            this.dATARETIRAPEDDataGridViewTextBoxColumn.Name = "dATARETIRAPEDDataGridViewTextBoxColumn";
            this.dATARETIRAPEDDataGridViewTextBoxColumn.ReadOnly = true;
            this.dATARETIRAPEDDataGridViewTextBoxColumn.Visible = false;
            // 
            // cUSTOFINANCPEDDataGridViewTextBoxColumn
            // 
            this.cUSTOFINANCPEDDataGridViewTextBoxColumn.DataPropertyName = "CUSTO_FINANC_PED";
            this.cUSTOFINANCPEDDataGridViewTextBoxColumn.HeaderText = "CUSTO_FINANC_PED";
            this.cUSTOFINANCPEDDataGridViewTextBoxColumn.Name = "cUSTOFINANCPEDDataGridViewTextBoxColumn";
            this.cUSTOFINANCPEDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cUSTOFINANCPEDDataGridViewTextBoxColumn.Visible = false;
            // 
            // vALORPARCIALPEDDataGridViewTextBoxColumn
            // 
            this.vALORPARCIALPEDDataGridViewTextBoxColumn.DataPropertyName = "VALOR_PARCIAL_PED";
            this.vALORPARCIALPEDDataGridViewTextBoxColumn.HeaderText = "VALOR_PARCIAL_PED";
            this.vALORPARCIALPEDDataGridViewTextBoxColumn.Name = "vALORPARCIALPEDDataGridViewTextBoxColumn";
            this.vALORPARCIALPEDDataGridViewTextBoxColumn.ReadOnly = true;
            this.vALORPARCIALPEDDataGridViewTextBoxColumn.Visible = false;
            // 
            // vALORIPIPEDDataGridViewTextBoxColumn
            // 
            this.vALORIPIPEDDataGridViewTextBoxColumn.DataPropertyName = "VALOR_IPI_PED";
            this.vALORIPIPEDDataGridViewTextBoxColumn.HeaderText = "VALOR_IPI_PED";
            this.vALORIPIPEDDataGridViewTextBoxColumn.Name = "vALORIPIPEDDataGridViewTextBoxColumn";
            this.vALORIPIPEDDataGridViewTextBoxColumn.ReadOnly = true;
            this.vALORIPIPEDDataGridViewTextBoxColumn.Visible = false;
            // 
            // vALORICMSPEDDataGridViewTextBoxColumn
            // 
            this.vALORICMSPEDDataGridViewTextBoxColumn.DataPropertyName = "VALOR_ICMS_PED";
            this.vALORICMSPEDDataGridViewTextBoxColumn.HeaderText = "VALOR_ICMS_PED";
            this.vALORICMSPEDDataGridViewTextBoxColumn.Name = "vALORICMSPEDDataGridViewTextBoxColumn";
            this.vALORICMSPEDDataGridViewTextBoxColumn.ReadOnly = true;
            this.vALORICMSPEDDataGridViewTextBoxColumn.Visible = false;
            // 
            // vALORTOTALPEDDataGridViewTextBoxColumn
            // 
            this.vALORTOTALPEDDataGridViewTextBoxColumn.DataPropertyName = "VALOR_TOTAL_PED";
            this.vALORTOTALPEDDataGridViewTextBoxColumn.HeaderText = "VALOR_TOTAL_PED";
            this.vALORTOTALPEDDataGridViewTextBoxColumn.Name = "vALORTOTALPEDDataGridViewTextBoxColumn";
            this.vALORTOTALPEDDataGridViewTextBoxColumn.ReadOnly = true;
            this.vALORTOTALPEDDataGridViewTextBoxColumn.Visible = false;
            // 
            // aUTORIZADOPEDDataGridViewTextBoxColumn
            // 
            this.aUTORIZADOPEDDataGridViewTextBoxColumn.DataPropertyName = "AUTORIZADO_PED";
            this.aUTORIZADOPEDDataGridViewTextBoxColumn.HeaderText = "AUTORIZADO_PED";
            this.aUTORIZADOPEDDataGridViewTextBoxColumn.Name = "aUTORIZADOPEDDataGridViewTextBoxColumn";
            this.aUTORIZADOPEDDataGridViewTextBoxColumn.ReadOnly = true;
            this.aUTORIZADOPEDDataGridViewTextBoxColumn.Visible = false;
            // 
            // dATAAUTORIZACAOPEDDataGridViewTextBoxColumn
            // 
            this.dATAAUTORIZACAOPEDDataGridViewTextBoxColumn.DataPropertyName = "DATA_AUTORIZACAO_PED";
            this.dATAAUTORIZACAOPEDDataGridViewTextBoxColumn.HeaderText = "DATA_AUTORIZACAO_PED";
            this.dATAAUTORIZACAOPEDDataGridViewTextBoxColumn.Name = "dATAAUTORIZACAOPEDDataGridViewTextBoxColumn";
            this.dATAAUTORIZACAOPEDDataGridViewTextBoxColumn.ReadOnly = true;
            this.dATAAUTORIZACAOPEDDataGridViewTextBoxColumn.Visible = false;
            // 
            // hORAAUTORIZACAOPEDDataGridViewTextBoxColumn
            // 
            this.hORAAUTORIZACAOPEDDataGridViewTextBoxColumn.DataPropertyName = "HORA_AUTORIZACAO_PED";
            this.hORAAUTORIZACAOPEDDataGridViewTextBoxColumn.HeaderText = "HORA_AUTORIZACAO_PED";
            this.hORAAUTORIZACAOPEDDataGridViewTextBoxColumn.Name = "hORAAUTORIZACAOPEDDataGridViewTextBoxColumn";
            this.hORAAUTORIZACAOPEDDataGridViewTextBoxColumn.ReadOnly = true;
            this.hORAAUTORIZACAOPEDDataGridViewTextBoxColumn.Visible = false;
            // 
            // cODAUTORIZANTEPEDDataGridViewTextBoxColumn
            // 
            this.cODAUTORIZANTEPEDDataGridViewTextBoxColumn.DataPropertyName = "COD_AUTORIZANTE_PED";
            this.cODAUTORIZANTEPEDDataGridViewTextBoxColumn.HeaderText = "COD_AUTORIZANTE_PED";
            this.cODAUTORIZANTEPEDDataGridViewTextBoxColumn.Name = "cODAUTORIZANTEPEDDataGridViewTextBoxColumn";
            this.cODAUTORIZANTEPEDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cODAUTORIZANTEPEDDataGridViewTextBoxColumn.Visible = false;
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
            this.COD_AUTORIZANTE_PED});
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
            this.CUSTO_FINANC_PED.DataType = typeof(double);
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
            // COD_AUTORIZANTE_PED
            // 
            this.COD_AUTORIZANTE_PED.ColumnName = "COD_AUTORIZANTE_PED";
            this.COD_AUTORIZANTE_PED.MaxLength = 50;
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
            this.fbCommand1.CommandText = "select * from pedido_compra order by cod_ped desc";
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
            // form_localiza_ped
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 337);
            this.Controls.Add(this.tb_localiza);
            this.Controls.Add(this.dgvPedido_compra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "form_localiza_ped";
            this.Text = "Localiza Pedido de Compra";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.form_localiza_req_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido_compra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPedido_compra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PEDIDO_COMPRA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_localiza;
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
        private System.Data.DataColumn COD_AUTORIZANTE_PED;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAAUTORIZACAOPEDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORAAUTORIZACAOPEDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODAUTORIZANTEPEDDataGridViewTextBoxColumn;
    }
}