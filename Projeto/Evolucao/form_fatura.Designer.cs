namespace Evolucao
{
    partial class form_fatura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_fatura));
            this.datFatura_nf = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.dsFatura_nf = new System.Data.DataSet();
            this.FATURA_NF = new System.Data.DataTable();
            this.COD_FATURA = new System.Data.DataColumn();
            this.PRAZO_FATURA = new System.Data.DataColumn();
            this.DATA_VENC_FATURA = new System.Data.DataColumn();
            this.VALOR_FATURA = new System.Data.DataColumn();
            this.NF_FATURA = new System.Data.DataColumn();
            this.dgvFatura_nf = new System.Windows.Forms.DataGridView();
            this.cODFATURADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRAZOFATURADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAVENCFATURADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORFATURADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nFFATURADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.cbFatura_nf = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            ((System.ComponentModel.ISupportInitialize)(this.dsFatura_nf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FATURA_NF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFatura_nf)).BeginInit();
            this.SuspendLayout();
            // 
            // datFatura_nf
            // 
            this.datFatura_nf.DeleteCommand = this.fbCommand4;
            this.datFatura_nf.InsertCommand = this.fbCommand2;
            this.datFatura_nf.SelectCommand = this.fbCommand1;
            this.datFatura_nf.UpdateCommand = this.fbCommand3;
            // 
            // fbCommand1
            // 
            this.fbCommand1.CommandText = "select * from fatura_nf";
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
            // dsFatura_nf
            // 
            this.dsFatura_nf.DataSetName = "dsFatura_nf";
            this.dsFatura_nf.Namespace = "http://www.tempuri.org/dsFatura_nf.xsd";
            this.dsFatura_nf.Tables.AddRange(new System.Data.DataTable[] {
            this.FATURA_NF});
            // 
            // FATURA_NF
            // 
            this.FATURA_NF.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_FATURA,
            this.PRAZO_FATURA,
            this.DATA_VENC_FATURA,
            this.VALOR_FATURA,
            this.NF_FATURA});
            this.FATURA_NF.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_FATURA"}, true)});
            this.FATURA_NF.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_FATURA};
            this.FATURA_NF.TableName = "FATURA_NF";
            // 
            // COD_FATURA
            // 
            this.COD_FATURA.AllowDBNull = false;
            this.COD_FATURA.ColumnName = "COD_FATURA";
            this.COD_FATURA.DataType = typeof(int);
            // 
            // PRAZO_FATURA
            // 
            this.PRAZO_FATURA.ColumnName = "PRAZO_FATURA";
            this.PRAZO_FATURA.DataType = typeof(int);
            // 
            // DATA_VENC_FATURA
            // 
            this.DATA_VENC_FATURA.ColumnName = "DATA_VENC_FATURA";
            this.DATA_VENC_FATURA.DataType = typeof(System.DateTime);
            // 
            // VALOR_FATURA
            // 
            this.VALOR_FATURA.ColumnName = "VALOR_FATURA";
            this.VALOR_FATURA.DataType = typeof(double);
            // 
            // NF_FATURA
            // 
            this.NF_FATURA.ColumnName = "NF_FATURA";
            this.NF_FATURA.DataType = typeof(int);
            // 
            // dgvFatura_nf
            // 
            this.dgvFatura_nf.AllowUserToAddRows = false;
            this.dgvFatura_nf.AllowUserToDeleteRows = false;
            this.dgvFatura_nf.AutoGenerateColumns = false;
            this.dgvFatura_nf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFatura_nf.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODFATURADataGridViewTextBoxColumn,
            this.pRAZOFATURADataGridViewTextBoxColumn,
            this.dATAVENCFATURADataGridViewTextBoxColumn,
            this.vALORFATURADataGridViewTextBoxColumn,
            this.nFFATURADataGridViewTextBoxColumn});
            this.dgvFatura_nf.DataMember = "FATURA_NF";
            this.dgvFatura_nf.DataSource = this.dsFatura_nf;
            this.dgvFatura_nf.Location = new System.Drawing.Point(12, 85);
            this.dgvFatura_nf.Name = "dgvFatura_nf";
            this.dgvFatura_nf.Size = new System.Drawing.Size(326, 189);
            this.dgvFatura_nf.TabIndex = 0;
            // 
            // cODFATURADataGridViewTextBoxColumn
            // 
            this.cODFATURADataGridViewTextBoxColumn.DataPropertyName = "COD_FATURA";
            this.cODFATURADataGridViewTextBoxColumn.HeaderText = "COD_FATURA";
            this.cODFATURADataGridViewTextBoxColumn.Name = "cODFATURADataGridViewTextBoxColumn";
            this.cODFATURADataGridViewTextBoxColumn.Visible = false;
            // 
            // pRAZOFATURADataGridViewTextBoxColumn
            // 
            this.pRAZOFATURADataGridViewTextBoxColumn.DataPropertyName = "PRAZO_FATURA";
            this.pRAZOFATURADataGridViewTextBoxColumn.HeaderText = "Prazo";
            this.pRAZOFATURADataGridViewTextBoxColumn.Name = "pRAZOFATURADataGridViewTextBoxColumn";
            this.pRAZOFATURADataGridViewTextBoxColumn.Width = 50;
            // 
            // dATAVENCFATURADataGridViewTextBoxColumn
            // 
            this.dATAVENCFATURADataGridViewTextBoxColumn.DataPropertyName = "DATA_VENC_FATURA";
            this.dATAVENCFATURADataGridViewTextBoxColumn.HeaderText = "Data Vencimento";
            this.dATAVENCFATURADataGridViewTextBoxColumn.Name = "dATAVENCFATURADataGridViewTextBoxColumn";
            // 
            // vALORFATURADataGridViewTextBoxColumn
            // 
            this.vALORFATURADataGridViewTextBoxColumn.DataPropertyName = "VALOR_FATURA";
            this.vALORFATURADataGridViewTextBoxColumn.HeaderText = "Valor";
            this.vALORFATURADataGridViewTextBoxColumn.Name = "vALORFATURADataGridViewTextBoxColumn";
            this.vALORFATURADataGridViewTextBoxColumn.Width = 130;
            // 
            // nFFATURADataGridViewTextBoxColumn
            // 
            this.nFFATURADataGridViewTextBoxColumn.DataPropertyName = "NF_FATURA";
            this.nFFATURADataGridViewTextBoxColumn.HeaderText = "NF_FATURA";
            this.nFFATURADataGridViewTextBoxColumn.Name = "nFFATURADataGridViewTextBoxColumn";
            this.nFFATURADataGridViewTextBoxColumn.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(204, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Salvar e Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbFatura_nf
            // 
            this.cbFatura_nf.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbFatura_nf.DataAdapter = this.datFatura_nf;
            this.cbFatura_nf.QuotePrefix = "\"";
            this.cbFatura_nf.QuoteSuffix = "\"";
            // 
            // form_fatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 294);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvFatura_nf);
            this.Name = "form_fatura";
            this.Text = "Cobrança";
            this.Load += new System.EventHandler(this.form_fatura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsFatura_nf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FATURA_NF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFatura_nf)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datFatura_nf;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Data.DataSet dsFatura_nf;
        private System.Data.DataTable FATURA_NF;
        private System.Data.DataColumn COD_FATURA;
        private System.Data.DataColumn PRAZO_FATURA;
        private System.Data.DataColumn DATA_VENC_FATURA;
        private System.Data.DataColumn VALOR_FATURA;
        private System.Data.DataColumn NF_FATURA;
        private System.Windows.Forms.DataGridView dgvFatura_nf;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODFATURADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRAZOFATURADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAVENCFATURADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORFATURADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nFFATURADataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbFatura_nf;
    }
}