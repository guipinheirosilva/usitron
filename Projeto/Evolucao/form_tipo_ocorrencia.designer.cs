namespace Evolucao
{
    partial class form_tipo_ocorrencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_tipo_ocorrencia));
            this.datOcorrencias = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsOcorrencias = new System.Data.DataSet();
            this.TIPOS_OCORRENCIAS = new System.Data.DataTable();
            this.COD_TIPO_OCORRENCIA = new System.Data.DataColumn();
            this.DESCRICAO_OCORRENCIA = new System.Data.DataColumn();
            this.dgvOcorrencias = new System.Windows.Forms.DataGridView();
            this.cODTIPOOCORRENCIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRICAOOCORRENCIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.cbOcorrencias = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            ((System.ComponentModel.ISupportInitialize)(this.dsOcorrencias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TIPOS_OCORRENCIAS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOcorrencias)).BeginInit();
            this.SuspendLayout();
            // 
            // datOcorrencias
            // 
            this.datOcorrencias.DeleteCommand = this.fbCommand4;
            this.datOcorrencias.InsertCommand = this.fbCommand2;
            this.datOcorrencias.SelectCommand = this.fbCommand1;
            this.datOcorrencias.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * from tipos_ocorrencias";
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
            // dsOcorrencias
            // 
            this.dsOcorrencias.DataSetName = "dsOcorrencias";
            this.dsOcorrencias.Namespace = "http://www.tempuri.org/dsOcorrencias.xsd";
            this.dsOcorrencias.Tables.AddRange(new System.Data.DataTable[] {
            this.TIPOS_OCORRENCIAS});
            // 
            // TIPOS_OCORRENCIAS
            // 
            this.TIPOS_OCORRENCIAS.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_TIPO_OCORRENCIA,
            this.DESCRICAO_OCORRENCIA});
            this.TIPOS_OCORRENCIAS.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_TIPO_OCORRENCIA"}, true)});
            this.TIPOS_OCORRENCIAS.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_TIPO_OCORRENCIA};
            this.TIPOS_OCORRENCIAS.TableName = "TIPOS_OCORRENCIAS";
            // 
            // COD_TIPO_OCORRENCIA
            // 
            this.COD_TIPO_OCORRENCIA.AllowDBNull = false;
            this.COD_TIPO_OCORRENCIA.AutoIncrement = true;
            this.COD_TIPO_OCORRENCIA.AutoIncrementSeed = ((long)(1));
            this.COD_TIPO_OCORRENCIA.ColumnName = "COD_TIPO_OCORRENCIA";
            this.COD_TIPO_OCORRENCIA.DataType = typeof(int);
            // 
            // DESCRICAO_OCORRENCIA
            // 
            this.DESCRICAO_OCORRENCIA.ColumnName = "DESCRICAO_OCORRENCIA";
            this.DESCRICAO_OCORRENCIA.MaxLength = 200;
            // 
            // dgvOcorrencias
            // 
            this.dgvOcorrencias.AutoGenerateColumns = false;
            this.dgvOcorrencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOcorrencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODTIPOOCORRENCIADataGridViewTextBoxColumn,
            this.dESCRICAOOCORRENCIADataGridViewTextBoxColumn});
            this.dgvOcorrencias.DataMember = "TIPOS_OCORRENCIAS";
            this.dgvOcorrencias.DataSource = this.dsOcorrencias;
            this.dgvOcorrencias.Location = new System.Drawing.Point(12, 12);
            this.dgvOcorrencias.Name = "dgvOcorrencias";
            this.dgvOcorrencias.Size = new System.Drawing.Size(430, 397);
            this.dgvOcorrencias.TabIndex = 0;
            this.dgvOcorrencias.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOcorrencias_CellDoubleClick);
            // 
            // cODTIPOOCORRENCIADataGridViewTextBoxColumn
            // 
            this.cODTIPOOCORRENCIADataGridViewTextBoxColumn.DataPropertyName = "COD_TIPO_OCORRENCIA";
            this.cODTIPOOCORRENCIADataGridViewTextBoxColumn.HeaderText = "Cód.";
            this.cODTIPOOCORRENCIADataGridViewTextBoxColumn.Name = "cODTIPOOCORRENCIADataGridViewTextBoxColumn";
            // 
            // dESCRICAOOCORRENCIADataGridViewTextBoxColumn
            // 
            this.dESCRICAOOCORRENCIADataGridViewTextBoxColumn.DataPropertyName = "DESCRICAO_OCORRENCIA";
            this.dESCRICAOOCORRENCIADataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.dESCRICAOOCORRENCIADataGridViewTextBoxColumn.Name = "dESCRICAOOCORRENCIADataGridViewTextBoxColumn";
            this.dESCRICAOOCORRENCIADataGridViewTextBoxColumn.Width = 270;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(200, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbOcorrencias
            // 
            this.cbOcorrencias.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbOcorrencias.DataAdapter = this.datOcorrencias;
            this.cbOcorrencias.QuotePrefix = "\"";
            this.cbOcorrencias.QuoteSuffix = "\"";
            // 
            // form_tipo_ocorrencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 451);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvOcorrencias);
            this.Name = "form_tipo_ocorrencia";
            this.Text = "Tipo de Ocorrência";
            this.Load += new System.EventHandler(this.form_tipo_ocorrencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsOcorrencias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TIPOS_OCORRENCIAS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOcorrencias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datOcorrencias;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private System.Data.DataSet dsOcorrencias;
        private System.Data.DataTable TIPOS_OCORRENCIAS;
        private System.Data.DataColumn COD_TIPO_OCORRENCIA;
        private System.Data.DataColumn DESCRICAO_OCORRENCIA;
        private System.Windows.Forms.DataGridView dgvOcorrencias;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODTIPOOCORRENCIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRICAOOCORRENCIADataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbOcorrencias;
    }
}