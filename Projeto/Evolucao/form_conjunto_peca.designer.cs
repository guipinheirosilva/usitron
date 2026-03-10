namespace Evolucao
{
    partial class form_conjunto_peca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_conjunto_peca));
            this.datConjunto_peca = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsConjunto_peca = new System.Data.DataSet();
            this.CONJUNTO_PECA = new System.Data.DataTable();
            this.COD_CONJUNTO = new System.Data.DataColumn();
            this.NOME_CONJUNTO = new System.Data.DataColumn();
            this.ORDEM_CONJUNTO = new System.Data.DataColumn();
            this.dgvConjuntos = new System.Windows.Forms.DataGridView();
            this.cODCONJUNTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMECONJUNTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRDEMCONJUNTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.cbConjunto_peca = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            ((System.ComponentModel.ISupportInitialize)(this.dsConjunto_peca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CONJUNTO_PECA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConjuntos)).BeginInit();
            this.SuspendLayout();
            // 
            // datConjunto_peca
            // 
            this.datConjunto_peca.DeleteCommand = this.fbCommand4;
            this.datConjunto_peca.InsertCommand = this.fbCommand2;
            this.datConjunto_peca.SelectCommand = this.fbCommand1;
            this.datConjunto_peca.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * from conjunto_peca";
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
            // dsConjunto_peca
            // 
            this.dsConjunto_peca.DataSetName = "dsConjunto_peca";
            this.dsConjunto_peca.Namespace = "http://www.tempuri.org/dsConjunto_peca.xsd";
            this.dsConjunto_peca.Tables.AddRange(new System.Data.DataTable[] {
            this.CONJUNTO_PECA});
            // 
            // CONJUNTO_PECA
            // 
            this.CONJUNTO_PECA.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_CONJUNTO,
            this.NOME_CONJUNTO,
            this.ORDEM_CONJUNTO});
            this.CONJUNTO_PECA.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_CONJUNTO"}, true)});
            this.CONJUNTO_PECA.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_CONJUNTO};
            this.CONJUNTO_PECA.TableName = "CONJUNTO_PECA";
            // 
            // COD_CONJUNTO
            // 
            this.COD_CONJUNTO.AllowDBNull = false;
            this.COD_CONJUNTO.AutoIncrement = true;
            this.COD_CONJUNTO.AutoIncrementSeed = ((long)(1));
            this.COD_CONJUNTO.ColumnName = "COD_CONJUNTO";
            this.COD_CONJUNTO.DataType = typeof(int);
            // 
            // NOME_CONJUNTO
            // 
            this.NOME_CONJUNTO.ColumnName = "NOME_CONJUNTO";
            this.NOME_CONJUNTO.MaxLength = 100;
            // 
            // ORDEM_CONJUNTO
            // 
            this.ORDEM_CONJUNTO.ColumnName = "ORDEM_CONJUNTO";
            this.ORDEM_CONJUNTO.DataType = typeof(int);
            // 
            // dgvConjuntos
            // 
            this.dgvConjuntos.AutoGenerateColumns = false;
            this.dgvConjuntos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConjuntos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODCONJUNTODataGridViewTextBoxColumn,
            this.nOMECONJUNTODataGridViewTextBoxColumn,
            this.oRDEMCONJUNTODataGridViewTextBoxColumn});
            this.dgvConjuntos.DataMember = "CONJUNTO_PECA";
            this.dgvConjuntos.DataSource = this.dsConjunto_peca;
            this.dgvConjuntos.Location = new System.Drawing.Point(3, 26);
            this.dgvConjuntos.Name = "dgvConjuntos";
            this.dgvConjuntos.Size = new System.Drawing.Size(359, 206);
            this.dgvConjuntos.TabIndex = 0;
            this.dgvConjuntos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConjuntos_CellDoubleClick);
            // 
            // cODCONJUNTODataGridViewTextBoxColumn
            // 
            this.cODCONJUNTODataGridViewTextBoxColumn.DataPropertyName = "COD_CONJUNTO";
            this.cODCONJUNTODataGridViewTextBoxColumn.HeaderText = "Cód.";
            this.cODCONJUNTODataGridViewTextBoxColumn.Name = "cODCONJUNTODataGridViewTextBoxColumn";
            this.cODCONJUNTODataGridViewTextBoxColumn.Visible = false;
            this.cODCONJUNTODataGridViewTextBoxColumn.Width = 50;
            // 
            // nOMECONJUNTODataGridViewTextBoxColumn
            // 
            this.nOMECONJUNTODataGridViewTextBoxColumn.DataPropertyName = "NOME_CONJUNTO";
            this.nOMECONJUNTODataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nOMECONJUNTODataGridViewTextBoxColumn.Name = "nOMECONJUNTODataGridViewTextBoxColumn";
            this.nOMECONJUNTODataGridViewTextBoxColumn.Width = 200;
            // 
            // oRDEMCONJUNTODataGridViewTextBoxColumn
            // 
            this.oRDEMCONJUNTODataGridViewTextBoxColumn.DataPropertyName = "ORDEM_CONJUNTO";
            this.oRDEMCONJUNTODataGridViewTextBoxColumn.HeaderText = "Ordem";
            this.oRDEMCONJUNTODataGridViewTextBoxColumn.Name = "oRDEMCONJUNTODataGridViewTextBoxColumn";
            this.oRDEMCONJUNTODataGridViewTextBoxColumn.Width = 80;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbConjunto_peca
            // 
            this.cbConjunto_peca.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbConjunto_peca.DataAdapter = this.datConjunto_peca;
            this.cbConjunto_peca.QuotePrefix = "\"";
            this.cbConjunto_peca.QuoteSuffix = "\"";
            // 
            // form_conjunto_peca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvConjuntos);
            this.Name = "form_conjunto_peca";
            this.Text = "Conjunto Peças";
            this.Load += new System.EventHandler(this.form_conjunto_peca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsConjunto_peca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CONJUNTO_PECA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConjuntos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datConjunto_peca;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Data.DataSet dsConjunto_peca;
        private System.Data.DataTable CONJUNTO_PECA;
        private System.Data.DataColumn COD_CONJUNTO;
        private System.Data.DataColumn NOME_CONJUNTO;
        private System.Data.DataColumn ORDEM_CONJUNTO;
        private System.Windows.Forms.DataGridView dgvConjuntos;
        private System.Windows.Forms.Button button1;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbConjunto_peca;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODCONJUNTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMECONJUNTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oRDEMCONJUNTODataGridViewTextBoxColumn;
    }
}