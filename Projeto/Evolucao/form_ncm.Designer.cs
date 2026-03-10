namespace Evolucao
{
    partial class form_ncm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_ncm));
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.datNCM = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsNCM = new System.Data.DataSet();
            this.NCM = new System.Data.DataTable();
            this.COD_NCM = new System.Data.DataColumn();
            this.NCM_NCM = new System.Data.DataColumn();
            this.dgvNCM = new System.Windows.Forms.DataGridView();
            this.col_cod_ncm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ncm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.cbNCM = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsNCM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NCM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCM)).BeginInit();
            this.SuspendLayout();
            // 
            // fbConnection1
            // 
            this.fbConnection1.ConnectionString = resources.GetString("fbConnection1.ConnectionString");
            // 
            // datNCM
            // 
            this.datNCM.DeleteCommand = this.fbCommand4;
            this.datNCM.InsertCommand = this.fbCommand2;
            this.datNCM.SelectCommand = this.fbCommand1;
            this.datNCM.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "SELECT * FROM NCM";
            this.fbCommand1.CommandTimeout = 30;
            this.fbCommand1.Connection = this.fbConnection1;
            // 
            // fbCommand3
            // 
            this.fbCommand3.CommandTimeout = 30;
            // 
            // dsNCM
            // 
            this.dsNCM.DataSetName = "dsNCM";
            this.dsNCM.Namespace = "http://www.tempuri.org/dsNCM.xsd";
            this.dsNCM.Tables.AddRange(new System.Data.DataTable[] {
            this.NCM});
            // 
            // NCM
            // 
            this.NCM.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_NCM,
            this.NCM_NCM});
            this.NCM.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_NCM"}, true)});
            this.NCM.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_NCM};
            this.NCM.TableName = "NCM";
            // 
            // COD_NCM
            // 
            this.COD_NCM.AllowDBNull = false;
            this.COD_NCM.AutoIncrement = true;
            this.COD_NCM.ColumnName = "COD_NCM";
            this.COD_NCM.DataType = typeof(int);
            // 
            // NCM_NCM
            // 
            this.NCM_NCM.ColumnName = "NCM_NCM";
            this.NCM_NCM.DataType = typeof(int);
            // 
            // dgvNCM
            // 
            this.dgvNCM.AutoGenerateColumns = false;
            this.dgvNCM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNCM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_cod_ncm,
            this.col_ncm});
            this.dgvNCM.DataMember = "NCM";
            this.dgvNCM.DataSource = this.dsNCM;
            this.dgvNCM.Location = new System.Drawing.Point(26, 58);
            this.dgvNCM.Name = "dgvNCM";
            this.dgvNCM.RowTemplate.Height = 24;
            this.dgvNCM.Size = new System.Drawing.Size(462, 396);
            this.dgvNCM.TabIndex = 0;
            this.dgvNCM.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvNCM_CellMouseDoubleClick);
            // 
            // col_cod_ncm
            // 
            this.col_cod_ncm.DataPropertyName = "COD_NCM";
            this.col_cod_ncm.HeaderText = "Cód.";
            this.col_cod_ncm.Name = "col_cod_ncm";
            // 
            // col_ncm
            // 
            this.col_ncm.DataPropertyName = "NCM_NCM";
            this.col_ncm.HeaderText = "NCM";
            this.col_ncm.Name = "col_ncm";
            this.col_ncm.Width = 200;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(204, 461);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 96;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbNCM
            // 
            this.cbNCM.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbNCM.DataAdapter = this.datNCM;
            this.cbNCM.QuotePrefix = "\"";
            this.cbNCM.QuoteSuffix = "\"";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(183, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 54);
            this.label1.TabIndex = 97;
            this.label1.Text = "NCM";
            // 
            // form_ncm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 508);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvNCM);
            this.Name = "form_ncm";
            this.Text = "NCM";
            this.Load += new System.EventHandler(this.form_ncm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsNCM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NCM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datNCM;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Data.DataSet dsNCM;
        private System.Data.DataTable NCM;
        private System.Data.DataColumn COD_NCM;
        private System.Data.DataColumn NCM_NCM;
        private System.Windows.Forms.DataGridView dgvNCM;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod_ncm;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ncm;
        private System.Windows.Forms.Button button1;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbNCM;
        private System.Windows.Forms.Label label1;
    }
}