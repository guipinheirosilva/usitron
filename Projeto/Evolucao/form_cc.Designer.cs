namespace Evolucao
{
    partial class form_cc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_cc));
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dgvCc = new System.Windows.Forms.DataGridView();
            this.dsCc = new System.Data.DataSet();
            this.CONTAS_CORRENTES = new System.Data.DataTable();
            this.COD_CC = new System.Data.DataColumn();
            this.DESCRICAO_CC = new System.Data.DataColumn();
            this.BANCO_CC = new System.Data.DataColumn();
            this.CODIGO_BANCO_CC = new System.Data.DataColumn();
            this.AGENCIA_CC = new System.Data.DataColumn();
            this.DIG_AGENCIA_CC = new System.Data.DataColumn();
            this.CONTA_CC = new System.Data.DataColumn();
            this.DIG_CONTA_CC = new System.Data.DataColumn();
            this.MULTA_CC = new System.Data.DataColumn();
            this.MORA_DIA_CC = new System.Data.DataColumn();
            this.DIAS_PROTESTO_CC = new System.Data.DataColumn();
            this.CARTEIRA_CC = new System.Data.DataColumn();
            this.BOLETO_CC = new System.Data.DataColumn();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.cbCc = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.datCc = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.dataColumn4 = new System.Data.DataColumn();
            this.col_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bANCOCCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODIGOBANCOCCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aGENCIACCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIGAGENCIACCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONTACCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIGCONTACCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mULTACCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mORADIACCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIASPROTESTOCCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cARTEIRACCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOLETOCCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CODIGO_NO_BANCO_CC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNPJ_EMISSOR_CC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COD_TRANSMISSAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAO_APARECER_CC = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CONTAS_CORRENTES)).BeginInit();
            this.SuspendLayout();
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
            this.fbCommand1.CommandText = "select * from contas_correntes";
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
            // dgvCc
            // 
            this.dgvCc.AutoGenerateColumns = false;
            this.dgvCc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_cod,
            this.col_descricao,
            this.bANCOCCDataGridViewTextBoxColumn,
            this.cODIGOBANCOCCDataGridViewTextBoxColumn,
            this.aGENCIACCDataGridViewTextBoxColumn,
            this.dIGAGENCIACCDataGridViewTextBoxColumn,
            this.cONTACCDataGridViewTextBoxColumn,
            this.dIGCONTACCDataGridViewTextBoxColumn,
            this.mULTACCDataGridViewTextBoxColumn,
            this.mORADIACCDataGridViewTextBoxColumn,
            this.dIASPROTESTOCCDataGridViewTextBoxColumn,
            this.cARTEIRACCDataGridViewTextBoxColumn,
            this.bOLETOCCDataGridViewTextBoxColumn,
            this.CODIGO_NO_BANCO_CC,
            this.CNPJ_EMISSOR_CC,
            this.COD_TRANSMISSAO,
            this.NAO_APARECER_CC});
            this.dgvCc.DataMember = "CONTAS_CORRENTES";
            this.dgvCc.DataSource = this.dsCc;
            this.dgvCc.Location = new System.Drawing.Point(12, 12);
            this.dgvCc.Name = "dgvCc";
            this.dgvCc.Size = new System.Drawing.Size(1283, 373);
            this.dgvCc.TabIndex = 0;
            this.dgvCc.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarteiras_CellDoubleClick);
            // 
            // dsCc
            // 
            this.dsCc.DataSetName = "dsCc";
            this.dsCc.Namespace = "http://www.tempuri.org/dsCc.xsd";
            this.dsCc.Tables.AddRange(new System.Data.DataTable[] {
            this.CONTAS_CORRENTES});
            // 
            // CONTAS_CORRENTES
            // 
            this.CONTAS_CORRENTES.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_CC,
            this.DESCRICAO_CC,
            this.BANCO_CC,
            this.CODIGO_BANCO_CC,
            this.AGENCIA_CC,
            this.DIG_AGENCIA_CC,
            this.CONTA_CC,
            this.DIG_CONTA_CC,
            this.MULTA_CC,
            this.MORA_DIA_CC,
            this.DIAS_PROTESTO_CC,
            this.CARTEIRA_CC,
            this.BOLETO_CC,
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4});
            this.CONTAS_CORRENTES.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_CC"}, true)});
            this.CONTAS_CORRENTES.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_CC};
            this.CONTAS_CORRENTES.TableName = "CONTAS_CORRENTES";
            // 
            // COD_CC
            // 
            this.COD_CC.AllowDBNull = false;
            this.COD_CC.AutoIncrement = true;
            this.COD_CC.AutoIncrementSeed = ((long)(1));
            this.COD_CC.ColumnName = "COD_CC";
            this.COD_CC.DataType = typeof(int);
            // 
            // DESCRICAO_CC
            // 
            this.DESCRICAO_CC.ColumnName = "DESCRICAO_CC";
            this.DESCRICAO_CC.MaxLength = 200;
            // 
            // BANCO_CC
            // 
            this.BANCO_CC.ColumnName = "BANCO_CC";
            this.BANCO_CC.MaxLength = 200;
            // 
            // CODIGO_BANCO_CC
            // 
            this.CODIGO_BANCO_CC.ColumnName = "CODIGO_BANCO_CC";
            this.CODIGO_BANCO_CC.MaxLength = 10;
            // 
            // AGENCIA_CC
            // 
            this.AGENCIA_CC.ColumnName = "AGENCIA_CC";
            this.AGENCIA_CC.MaxLength = 200;
            // 
            // DIG_AGENCIA_CC
            // 
            this.DIG_AGENCIA_CC.ColumnName = "DIG_AGENCIA_CC";
            this.DIG_AGENCIA_CC.DataType = typeof(int);
            // 
            // CONTA_CC
            // 
            this.CONTA_CC.ColumnName = "CONTA_CC";
            this.CONTA_CC.MaxLength = 60;
            // 
            // DIG_CONTA_CC
            // 
            this.DIG_CONTA_CC.ColumnName = "DIG_CONTA_CC";
            this.DIG_CONTA_CC.DataType = typeof(int);
            // 
            // MULTA_CC
            // 
            this.MULTA_CC.ColumnName = "MULTA_CC";
            this.MULTA_CC.DataType = typeof(double);
            // 
            // MORA_DIA_CC
            // 
            this.MORA_DIA_CC.ColumnName = "MORA_DIA_CC";
            this.MORA_DIA_CC.DataType = typeof(double);
            // 
            // DIAS_PROTESTO_CC
            // 
            this.DIAS_PROTESTO_CC.ColumnName = "DIAS_PROTESTO_CC";
            this.DIAS_PROTESTO_CC.DataType = typeof(int);
            // 
            // CARTEIRA_CC
            // 
            this.CARTEIRA_CC.ColumnName = "CARTEIRA_CC";
            this.CARTEIRA_CC.MaxLength = 4;
            // 
            // BOLETO_CC
            // 
            this.BOLETO_CC.ColumnName = "BOLETO_CC";
            this.BOLETO_CC.DataType = typeof(int);
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "CODIGO_NO_BANCO_CC";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "NAO_APARECER_CC";
            this.dataColumn2.DataType = typeof(int);
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "COD_TRANSMISSAO";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(573, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbCc
            // 
            this.cbCc.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbCc.DataAdapter = this.datCc;
            this.cbCc.QuotePrefix = "\"";
            this.cbCc.QuoteSuffix = "\"";
            // 
            // datCc
            // 
            this.datCc.DeleteCommand = this.fbCommand4;
            this.datCc.InsertCommand = this.fbCommand2;
            this.datCc.SelectCommand = this.fbCommand1;
            this.datCc.UpdateCommand = this.fbCommand3;
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "CNPJ_EMISSOR_CC";
            // 
            // col_cod
            // 
            this.col_cod.DataPropertyName = "COD_CC";
            this.col_cod.HeaderText = "Cód.";
            this.col_cod.Name = "col_cod";
            this.col_cod.Width = 50;
            // 
            // col_descricao
            // 
            this.col_descricao.DataPropertyName = "DESCRICAO_CC";
            this.col_descricao.HeaderText = "Descrição";
            this.col_descricao.Name = "col_descricao";
            this.col_descricao.Width = 200;
            // 
            // bANCOCCDataGridViewTextBoxColumn
            // 
            this.bANCOCCDataGridViewTextBoxColumn.DataPropertyName = "BANCO_CC";
            this.bANCOCCDataGridViewTextBoxColumn.HeaderText = "Banco";
            this.bANCOCCDataGridViewTextBoxColumn.Name = "bANCOCCDataGridViewTextBoxColumn";
            // 
            // cODIGOBANCOCCDataGridViewTextBoxColumn
            // 
            this.cODIGOBANCOCCDataGridViewTextBoxColumn.DataPropertyName = "CODIGO_BANCO_CC";
            this.cODIGOBANCOCCDataGridViewTextBoxColumn.HeaderText = "Cód. Banco";
            this.cODIGOBANCOCCDataGridViewTextBoxColumn.Name = "cODIGOBANCOCCDataGridViewTextBoxColumn";
            this.cODIGOBANCOCCDataGridViewTextBoxColumn.Width = 70;
            // 
            // aGENCIACCDataGridViewTextBoxColumn
            // 
            this.aGENCIACCDataGridViewTextBoxColumn.DataPropertyName = "AGENCIA_CC";
            this.aGENCIACCDataGridViewTextBoxColumn.HeaderText = "Agência";
            this.aGENCIACCDataGridViewTextBoxColumn.Name = "aGENCIACCDataGridViewTextBoxColumn";
            this.aGENCIACCDataGridViewTextBoxColumn.Width = 60;
            // 
            // dIGAGENCIACCDataGridViewTextBoxColumn
            // 
            this.dIGAGENCIACCDataGridViewTextBoxColumn.DataPropertyName = "DIG_AGENCIA_CC";
            this.dIGAGENCIACCDataGridViewTextBoxColumn.HeaderText = "Dig. Ag.";
            this.dIGAGENCIACCDataGridViewTextBoxColumn.Name = "dIGAGENCIACCDataGridViewTextBoxColumn";
            this.dIGAGENCIACCDataGridViewTextBoxColumn.Width = 40;
            // 
            // cONTACCDataGridViewTextBoxColumn
            // 
            this.cONTACCDataGridViewTextBoxColumn.DataPropertyName = "CONTA_CC";
            this.cONTACCDataGridViewTextBoxColumn.HeaderText = "No. Conta";
            this.cONTACCDataGridViewTextBoxColumn.Name = "cONTACCDataGridViewTextBoxColumn";
            this.cONTACCDataGridViewTextBoxColumn.Width = 60;
            // 
            // dIGCONTACCDataGridViewTextBoxColumn
            // 
            this.dIGCONTACCDataGridViewTextBoxColumn.DataPropertyName = "DIG_CONTA_CC";
            this.dIGCONTACCDataGridViewTextBoxColumn.HeaderText = "Dig. Conta";
            this.dIGCONTACCDataGridViewTextBoxColumn.Name = "dIGCONTACCDataGridViewTextBoxColumn";
            this.dIGCONTACCDataGridViewTextBoxColumn.Width = 40;
            // 
            // mULTACCDataGridViewTextBoxColumn
            // 
            this.mULTACCDataGridViewTextBoxColumn.DataPropertyName = "MULTA_CC";
            this.mULTACCDataGridViewTextBoxColumn.HeaderText = "Multa";
            this.mULTACCDataGridViewTextBoxColumn.Name = "mULTACCDataGridViewTextBoxColumn";
            this.mULTACCDataGridViewTextBoxColumn.Width = 60;
            // 
            // mORADIACCDataGridViewTextBoxColumn
            // 
            this.mORADIACCDataGridViewTextBoxColumn.DataPropertyName = "MORA_DIA_CC";
            this.mORADIACCDataGridViewTextBoxColumn.HeaderText = "Mora";
            this.mORADIACCDataGridViewTextBoxColumn.Name = "mORADIACCDataGridViewTextBoxColumn";
            this.mORADIACCDataGridViewTextBoxColumn.Width = 60;
            // 
            // dIASPROTESTOCCDataGridViewTextBoxColumn
            // 
            this.dIASPROTESTOCCDataGridViewTextBoxColumn.DataPropertyName = "DIAS_PROTESTO_CC";
            this.dIASPROTESTOCCDataGridViewTextBoxColumn.HeaderText = "Dias Protesto";
            this.dIASPROTESTOCCDataGridViewTextBoxColumn.Name = "dIASPROTESTOCCDataGridViewTextBoxColumn";
            this.dIASPROTESTOCCDataGridViewTextBoxColumn.Width = 40;
            // 
            // cARTEIRACCDataGridViewTextBoxColumn
            // 
            this.cARTEIRACCDataGridViewTextBoxColumn.DataPropertyName = "CARTEIRA_CC";
            this.cARTEIRACCDataGridViewTextBoxColumn.HeaderText = "Carteira";
            this.cARTEIRACCDataGridViewTextBoxColumn.Name = "cARTEIRACCDataGridViewTextBoxColumn";
            this.cARTEIRACCDataGridViewTextBoxColumn.Width = 50;
            // 
            // bOLETOCCDataGridViewTextBoxColumn
            // 
            this.bOLETOCCDataGridViewTextBoxColumn.DataPropertyName = "BOLETO_CC";
            this.bOLETOCCDataGridViewTextBoxColumn.FalseValue = "0";
            this.bOLETOCCDataGridViewTextBoxColumn.HeaderText = "Boleto";
            this.bOLETOCCDataGridViewTextBoxColumn.IndeterminateValue = "0";
            this.bOLETOCCDataGridViewTextBoxColumn.Name = "bOLETOCCDataGridViewTextBoxColumn";
            this.bOLETOCCDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.bOLETOCCDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.bOLETOCCDataGridViewTextBoxColumn.TrueValue = "1";
            this.bOLETOCCDataGridViewTextBoxColumn.Width = 50;
            // 
            // CODIGO_NO_BANCO_CC
            // 
            this.CODIGO_NO_BANCO_CC.DataPropertyName = "CODIGO_NO_BANCO_CC";
            this.CODIGO_NO_BANCO_CC.HeaderText = "Cód. no Banco";
            this.CODIGO_NO_BANCO_CC.Name = "CODIGO_NO_BANCO_CC";
            this.CODIGO_NO_BANCO_CC.Width = 80;
            // 
            // CNPJ_EMISSOR_CC
            // 
            this.CNPJ_EMISSOR_CC.DataPropertyName = "CNPJ_EMISSOR_CC";
            this.CNPJ_EMISSOR_CC.HeaderText = "CNPJ Emissor";
            this.CNPJ_EMISSOR_CC.Name = "CNPJ_EMISSOR_CC";
            // 
            // COD_TRANSMISSAO
            // 
            this.COD_TRANSMISSAO.DataPropertyName = "COD_TRANSMISSAO";
            this.COD_TRANSMISSAO.HeaderText = "Cód. Transmissão";
            this.COD_TRANSMISSAO.Name = "COD_TRANSMISSAO";
            this.COD_TRANSMISSAO.Width = 130;
            // 
            // NAO_APARECER_CC
            // 
            this.NAO_APARECER_CC.DataPropertyName = "NAO_APARECER_CC";
            this.NAO_APARECER_CC.FalseValue = "0";
            this.NAO_APARECER_CC.HeaderText = "Não Aparecer";
            this.NAO_APARECER_CC.IndeterminateValue = "0";
            this.NAO_APARECER_CC.Name = "NAO_APARECER_CC";
            this.NAO_APARECER_CC.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NAO_APARECER_CC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.NAO_APARECER_CC.TrueValue = "1";
            this.NAO_APARECER_CC.Width = 60;
            // 
            // form_cc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 448);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvCc);
            this.Name = "form_cc";
            this.Text = "Contas Correntes";
            this.Load += new System.EventHandler(this.form_carteiras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CONTAS_CORRENTES)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Windows.Forms.DataGridView dgvCc;
        private System.Windows.Forms.Button button1;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbCc;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datCc;
        private System.Data.DataSet dsCc;
        private System.Data.DataTable CONTAS_CORRENTES;
        private System.Data.DataColumn COD_CC;
        private System.Data.DataColumn DESCRICAO_CC;
        private System.Data.DataColumn BANCO_CC;
        private System.Data.DataColumn CODIGO_BANCO_CC;
        private System.Data.DataColumn AGENCIA_CC;
        private System.Data.DataColumn DIG_AGENCIA_CC;
        private System.Data.DataColumn CONTA_CC;
        private System.Data.DataColumn DIG_CONTA_CC;
        private System.Data.DataColumn MULTA_CC;
        private System.Data.DataColumn MORA_DIA_CC;
        private System.Data.DataColumn DIAS_PROTESTO_CC;
        private System.Data.DataColumn CARTEIRA_CC;
        private System.Data.DataColumn BOLETO_CC;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn bANCOCCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODIGOBANCOCCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aGENCIACCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIGAGENCIACCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONTACCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIGCONTACCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mULTACCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mORADIACCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIASPROTESTOCCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cARTEIRACCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bOLETOCCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_NO_BANCO_CC;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNPJ_EMISSOR_CC;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_TRANSMISSAO;
        private System.Windows.Forms.DataGridViewCheckBoxColumn NAO_APARECER_CC;
        private System.Data.DataColumn dataColumn4;
    }
}