namespace Evolucao
{
    partial class form_localiza_nf_entrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_localiza_nf_entrada));
            this.tb_localiza = new System.Windows.Forms.TextBox();
            this.dgvNota_fiscal = new System.Windows.Forms.DataGridView();
            this.datNF_entrada = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.dsNF_entrada = new System.Data.DataSet();
            this.NOTA_FISCAL_ENTRADA = new System.Data.DataTable();
            this.COD_CONTROLE_NF_ENTRADA = new System.Data.DataColumn();
            this.N_NF_ENTRADA = new System.Data.DataColumn();
            this.FORNECEDOR_NF_ENTRADA = new System.Data.DataColumn();
            this.DATA_ENTRADA_NF_ENTRADA = new System.Data.DataColumn();
            this.CONFIRMADA_NF_ENTRADA = new System.Data.DataColumn();
            this.col_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nNFENTRADADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fORNECEDORNFENTRADADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAENTRADANFENTRADADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONFIRMADANFENTRADADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNota_fiscal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNF_entrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NOTA_FISCAL_ENTRADA)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_localiza
            // 
            this.tb_localiza.Location = new System.Drawing.Point(3, 4);
            this.tb_localiza.Name = "tb_localiza";
            this.tb_localiza.Size = new System.Drawing.Size(244, 20);
            this.tb_localiza.TabIndex = 7;
            this.tb_localiza.TextChanged += new System.EventHandler(this.tb_localiza_TextChanged);
            // 
            // dgvNota_fiscal
            // 
            this.dgvNota_fiscal.AllowUserToAddRows = false;
            this.dgvNota_fiscal.AutoGenerateColumns = false;
            this.dgvNota_fiscal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvNota_fiscal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNota_fiscal.ColumnHeadersVisible = false;
            this.dgvNota_fiscal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_cod,
            this.nNFENTRADADataGridViewTextBoxColumn,
            this.fORNECEDORNFENTRADADataGridViewTextBoxColumn,
            this.dATAENTRADANFENTRADADataGridViewTextBoxColumn,
            this.cONFIRMADANFENTRADADataGridViewTextBoxColumn});
            this.dgvNota_fiscal.DataMember = "NOTA_FISCAL_ENTRADA";
            this.dgvNota_fiscal.DataSource = this.dsNF_entrada;
            this.dgvNota_fiscal.Location = new System.Drawing.Point(3, 24);
            this.dgvNota_fiscal.Name = "dgvNota_fiscal";
            this.dgvNota_fiscal.ReadOnly = true;
            this.dgvNota_fiscal.RowHeadersVisible = false;
            this.dgvNota_fiscal.Size = new System.Drawing.Size(244, 160);
            this.dgvNota_fiscal.TabIndex = 6;
            this.dgvNota_fiscal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNota_fiscal_CellContentClick);
            // 
            // datNF_entrada
            // 
            this.datNF_entrada.DeleteCommand = this.fbCommand4;
            this.datNF_entrada.InsertCommand = this.fbCommand2;
            this.datNF_entrada.SelectCommand = this.fbCommand1;
            this.datNF_entrada.UpdateCommand = this.fbCommand3;
            // 
            // fbCommand1
            // 
            this.fbCommand1.CommandText = "select * from nota_fiscal_entrada";
            this.fbCommand1.CommandTimeout = 30;
            this.fbCommand1.Connection = this.fbConnection1;
            // 
            // fbCommand2
            // 
            this.fbCommand2.CommandTimeout = 30;
            // 
            // fbCommand3
            // 
            this.fbCommand3.CommandTimeout = 30;
            // 
            // fbCommand4
            // 
            this.fbCommand4.CommandTimeout = 30;
            // 
            // fbConnection1
            // 
            this.fbConnection1.ConnectionString = resources.GetString("fbConnection1.ConnectionString");
            // 
            // dsNF_entrada
            // 
            this.dsNF_entrada.DataSetName = "dsNF_entrada";
            this.dsNF_entrada.Namespace = "http://www.tempuri.org/dsNF_entrada.xsd";
            this.dsNF_entrada.Tables.AddRange(new System.Data.DataTable[] {
            this.NOTA_FISCAL_ENTRADA});
            // 
            // NOTA_FISCAL_ENTRADA
            // 
            this.NOTA_FISCAL_ENTRADA.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_CONTROLE_NF_ENTRADA,
            this.N_NF_ENTRADA,
            this.FORNECEDOR_NF_ENTRADA,
            this.DATA_ENTRADA_NF_ENTRADA,
            this.CONFIRMADA_NF_ENTRADA});
            this.NOTA_FISCAL_ENTRADA.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_CONTROLE_NF_ENTRADA"}, true)});
            this.NOTA_FISCAL_ENTRADA.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_CONTROLE_NF_ENTRADA};
            this.NOTA_FISCAL_ENTRADA.TableName = "NOTA_FISCAL_ENTRADA";
            // 
            // COD_CONTROLE_NF_ENTRADA
            // 
            this.COD_CONTROLE_NF_ENTRADA.AllowDBNull = false;
            this.COD_CONTROLE_NF_ENTRADA.ColumnName = "COD_CONTROLE_NF_ENTRADA";
            this.COD_CONTROLE_NF_ENTRADA.DataType = typeof(int);
            // 
            // N_NF_ENTRADA
            // 
            this.N_NF_ENTRADA.ColumnName = "N_NF_ENTRADA";
            this.N_NF_ENTRADA.MaxLength = 100;
            // 
            // FORNECEDOR_NF_ENTRADA
            // 
            this.FORNECEDOR_NF_ENTRADA.ColumnName = "FORNECEDOR_NF_ENTRADA";
            this.FORNECEDOR_NF_ENTRADA.MaxLength = 100;
            // 
            // DATA_ENTRADA_NF_ENTRADA
            // 
            this.DATA_ENTRADA_NF_ENTRADA.ColumnName = "DATA_ENTRADA_NF_ENTRADA";
            this.DATA_ENTRADA_NF_ENTRADA.DataType = typeof(System.DateTime);
            // 
            // CONFIRMADA_NF_ENTRADA
            // 
            this.CONFIRMADA_NF_ENTRADA.ColumnName = "CONFIRMADA_NF_ENTRADA";
            this.CONFIRMADA_NF_ENTRADA.DataType = typeof(int);
            // 
            // col_cod
            // 
            this.col_cod.DataPropertyName = "COD_CONTROLE_NF_ENTRADA";
            this.col_cod.HeaderText = "Cod.";
            this.col_cod.Name = "col_cod";
            this.col_cod.ReadOnly = true;
            this.col_cod.Width = 60;
            // 
            // nNFENTRADADataGridViewTextBoxColumn
            // 
            this.nNFENTRADADataGridViewTextBoxColumn.DataPropertyName = "N_NF_ENTRADA";
            this.nNFENTRADADataGridViewTextBoxColumn.HeaderText = "N.º NF";
            this.nNFENTRADADataGridViewTextBoxColumn.Name = "nNFENTRADADataGridViewTextBoxColumn";
            this.nNFENTRADADataGridViewTextBoxColumn.ReadOnly = true;
            this.nNFENTRADADataGridViewTextBoxColumn.Width = 70;
            // 
            // fORNECEDORNFENTRADADataGridViewTextBoxColumn
            // 
            this.fORNECEDORNFENTRADADataGridViewTextBoxColumn.DataPropertyName = "FORNECEDOR_NF_ENTRADA";
            this.fORNECEDORNFENTRADADataGridViewTextBoxColumn.HeaderText = "Fornecedor";
            this.fORNECEDORNFENTRADADataGridViewTextBoxColumn.Name = "fORNECEDORNFENTRADADataGridViewTextBoxColumn";
            this.fORNECEDORNFENTRADADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dATAENTRADANFENTRADADataGridViewTextBoxColumn
            // 
            this.dATAENTRADANFENTRADADataGridViewTextBoxColumn.DataPropertyName = "DATA_ENTRADA_NF_ENTRADA";
            this.dATAENTRADANFENTRADADataGridViewTextBoxColumn.HeaderText = "DATA_ENTRADA_NF_ENTRADA";
            this.dATAENTRADANFENTRADADataGridViewTextBoxColumn.Name = "dATAENTRADANFENTRADADataGridViewTextBoxColumn";
            this.dATAENTRADANFENTRADADataGridViewTextBoxColumn.ReadOnly = true;
            this.dATAENTRADANFENTRADADataGridViewTextBoxColumn.Visible = false;
            // 
            // cONFIRMADANFENTRADADataGridViewTextBoxColumn
            // 
            this.cONFIRMADANFENTRADADataGridViewTextBoxColumn.DataPropertyName = "CONFIRMADA_NF_ENTRADA";
            this.cONFIRMADANFENTRADADataGridViewTextBoxColumn.HeaderText = "CONFIRMADA_NF_ENTRADA";
            this.cONFIRMADANFENTRADADataGridViewTextBoxColumn.Name = "cONFIRMADANFENTRADADataGridViewTextBoxColumn";
            this.cONFIRMADANFENTRADADataGridViewTextBoxColumn.ReadOnly = true;
            this.cONFIRMADANFENTRADADataGridViewTextBoxColumn.Visible = false;
            // 
            // form_localiza_nf_entrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 189);
            this.Controls.Add(this.tb_localiza);
            this.Controls.Add(this.dgvNota_fiscal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_localiza_nf_entrada";
            this.Text = "form_localiza_nf_entrada";
            this.Load += new System.EventHandler(this.form_localiza_nf_entrada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNota_fiscal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNF_entrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NOTA_FISCAL_ENTRADA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_localiza;
        private System.Windows.Forms.DataGridView dgvNota_fiscal;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datNF_entrada;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Data.DataSet dsNF_entrada;
        private System.Data.DataTable NOTA_FISCAL_ENTRADA;
        private System.Data.DataColumn COD_CONTROLE_NF_ENTRADA;
        private System.Data.DataColumn N_NF_ENTRADA;
        private System.Data.DataColumn FORNECEDOR_NF_ENTRADA;
        private System.Data.DataColumn DATA_ENTRADA_NF_ENTRADA;
        private System.Data.DataColumn CONFIRMADA_NF_ENTRADA;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn nNFENTRADADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fORNECEDORNFENTRADADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAENTRADANFENTRADADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONFIRMADANFENTRADADataGridViewTextBoxColumn;
    }
}