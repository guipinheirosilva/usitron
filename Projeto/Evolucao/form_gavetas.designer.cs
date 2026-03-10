namespace Evolucao
{
    partial class form_gavetas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_gavetas));
            this.datGavetas = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsGavetas = new System.Data.DataSet();
            this.GAVETAS = new System.Data.DataTable();
            this.COD_GAVETA = new System.Data.DataColumn();
            this.DIMENSAO_GAVETA = new System.Data.DataColumn();
            this.VALOR_GAVETA = new System.Data.DataColumn();
            this.dgvGavetas = new System.Windows.Forms.DataGridView();
            this.cODGAVETADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIMENSAOGAVETADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORGAVETADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.cbGavetas = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            ((System.ComponentModel.ISupportInitialize)(this.dsGavetas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GAVETAS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGavetas)).BeginInit();
            this.SuspendLayout();
            // 
            // datGavetas
            // 
            this.datGavetas.DeleteCommand = this.fbCommand4;
            this.datGavetas.InsertCommand = this.fbCommand2;
            this.datGavetas.SelectCommand = this.fbCommand1;
            this.datGavetas.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * from gavetas";
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
            // dsGavetas
            // 
            this.dsGavetas.DataSetName = "dsGavetas";
            this.dsGavetas.Namespace = "http://www.tempuri.org/dsGavetas.xsd";
            this.dsGavetas.Tables.AddRange(new System.Data.DataTable[] {
            this.GAVETAS});
            // 
            // GAVETAS
            // 
            this.GAVETAS.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_GAVETA,
            this.DIMENSAO_GAVETA,
            this.VALOR_GAVETA});
            this.GAVETAS.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_GAVETA"}, true)});
            this.GAVETAS.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_GAVETA};
            this.GAVETAS.TableName = "GAVETAS";
            // 
            // COD_GAVETA
            // 
            this.COD_GAVETA.AllowDBNull = false;
            this.COD_GAVETA.AutoIncrement = true;
            this.COD_GAVETA.ColumnName = "COD_GAVETA";
            this.COD_GAVETA.DataType = typeof(int);
            // 
            // DIMENSAO_GAVETA
            // 
            this.DIMENSAO_GAVETA.ColumnName = "DIMENSAO_GAVETA";
            this.DIMENSAO_GAVETA.DataType = typeof(double);
            // 
            // VALOR_GAVETA
            // 
            this.VALOR_GAVETA.ColumnName = "VALOR_GAVETA";
            this.VALOR_GAVETA.DataType = typeof(double);
            // 
            // dgvGavetas
            // 
            this.dgvGavetas.AutoGenerateColumns = false;
            this.dgvGavetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGavetas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODGAVETADataGridViewTextBoxColumn,
            this.dIMENSAOGAVETADataGridViewTextBoxColumn,
            this.vALORGAVETADataGridViewTextBoxColumn});
            this.dgvGavetas.DataMember = "GAVETAS";
            this.dgvGavetas.DataSource = this.dsGavetas;
            this.dgvGavetas.Location = new System.Drawing.Point(16, 15);
            this.dgvGavetas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvGavetas.Name = "dgvGavetas";
            this.dgvGavetas.Size = new System.Drawing.Size(356, 345);
            this.dgvGavetas.TabIndex = 0;
            // 
            // cODGAVETADataGridViewTextBoxColumn
            // 
            this.cODGAVETADataGridViewTextBoxColumn.DataPropertyName = "COD_GAVETA";
            this.cODGAVETADataGridViewTextBoxColumn.HeaderText = "Cod.";
            this.cODGAVETADataGridViewTextBoxColumn.Name = "cODGAVETADataGridViewTextBoxColumn";
            this.cODGAVETADataGridViewTextBoxColumn.Width = 40;
            // 
            // dIMENSAOGAVETADataGridViewTextBoxColumn
            // 
            this.dIMENSAOGAVETADataGridViewTextBoxColumn.DataPropertyName = "DIMENSAO_GAVETA";
            this.dIMENSAOGAVETADataGridViewTextBoxColumn.HeaderText = "Dimensão";
            this.dIMENSAOGAVETADataGridViewTextBoxColumn.Name = "dIMENSAOGAVETADataGridViewTextBoxColumn";
            // 
            // vALORGAVETADataGridViewTextBoxColumn
            // 
            this.vALORGAVETADataGridViewTextBoxColumn.DataPropertyName = "VALOR_GAVETA";
            this.vALORGAVETADataGridViewTextBoxColumn.HeaderText = "Valor";
            this.vALORGAVETADataGridViewTextBoxColumn.Name = "vALORGAVETADataGridViewTextBoxColumn";
            this.vALORGAVETADataGridViewTextBoxColumn.Width = 75;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(147, 367);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 28);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // cbGavetas
            // 
            this.cbGavetas.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbGavetas.DataAdapter = this.datGavetas;
            this.cbGavetas.QuotePrefix = "\"";
            this.cbGavetas.QuoteSuffix = "\"";
            // 
            // form_gavetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 400);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.dgvGavetas);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "form_gavetas";
            this.Text = "Gavetas";
            this.Load += new System.EventHandler(this.form_gavetas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsGavetas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GAVETAS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGavetas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datGavetas;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private System.Data.DataSet dsGavetas;
        private System.Data.DataTable GAVETAS;
        private System.Data.DataColumn COD_GAVETA;
        private System.Data.DataColumn DIMENSAO_GAVETA;
        private System.Data.DataColumn VALOR_GAVETA;
        private System.Windows.Forms.DataGridView dgvGavetas;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODGAVETADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIMENSAOGAVETADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORGAVETADataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnSalvar;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbGavetas;
    }
}