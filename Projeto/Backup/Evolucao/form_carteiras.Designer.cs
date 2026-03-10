namespace Evolucao
{
    partial class form_carteiras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_carteiras));
            this.datCarteiras = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsCarteiras = new System.Data.DataSet();
            this.CARTEIRAS = new System.Data.DataTable();
            this.COD_CARTEIRA = new System.Data.DataColumn();
            this.NOME_CARTEIRA = new System.Data.DataColumn();
            this.OBS_CARTEIRA = new System.Data.DataColumn();
            this.dgvCarteiras = new System.Windows.Forms.DataGridView();
            this.col_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oBSCARTEIRADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.cbCarteiras = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            ((System.ComponentModel.ISupportInitialize)(this.dsCarteiras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CARTEIRAS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarteiras)).BeginInit();
            this.SuspendLayout();
            // 
            // datCarteiras
            // 
            this.datCarteiras.DeleteCommand = this.fbCommand4;
            this.datCarteiras.InsertCommand = this.fbCommand2;
            this.datCarteiras.SelectCommand = this.fbCommand1;
            this.datCarteiras.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * from carteiras";
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
            // dsCarteiras
            // 
            this.dsCarteiras.DataSetName = "dsCarteiras";
            this.dsCarteiras.Namespace = "http://www.tempuri.org/dsCarteiras.xsd";
            this.dsCarteiras.Tables.AddRange(new System.Data.DataTable[] {
            this.CARTEIRAS});
            // 
            // CARTEIRAS
            // 
            this.CARTEIRAS.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_CARTEIRA,
            this.NOME_CARTEIRA,
            this.OBS_CARTEIRA});
            this.CARTEIRAS.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_CARTEIRA"}, true)});
            this.CARTEIRAS.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_CARTEIRA};
            this.CARTEIRAS.TableName = "CARTEIRAS";
            // 
            // COD_CARTEIRA
            // 
            this.COD_CARTEIRA.AllowDBNull = false;
            this.COD_CARTEIRA.AutoIncrement = true;
            this.COD_CARTEIRA.AutoIncrementSeed = ((long)(1));
            this.COD_CARTEIRA.ColumnName = "COD_CARTEIRA";
            this.COD_CARTEIRA.DataType = typeof(int);
            // 
            // NOME_CARTEIRA
            // 
            this.NOME_CARTEIRA.ColumnName = "NOME_CARTEIRA";
            this.NOME_CARTEIRA.MaxLength = 100;
            // 
            // OBS_CARTEIRA
            // 
            this.OBS_CARTEIRA.ColumnName = "OBS_CARTEIRA";
            this.OBS_CARTEIRA.MaxLength = 200;
            // 
            // dgvCarteiras
            // 
            this.dgvCarteiras.AutoGenerateColumns = false;
            this.dgvCarteiras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarteiras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_cod,
            this.col_nome,
            this.oBSCARTEIRADataGridViewTextBoxColumn});
            this.dgvCarteiras.DataMember = "CARTEIRAS";
            this.dgvCarteiras.DataSource = this.dsCarteiras;
            this.dgvCarteiras.Location = new System.Drawing.Point(12, 12);
            this.dgvCarteiras.Name = "dgvCarteiras";
            this.dgvCarteiras.Size = new System.Drawing.Size(367, 373);
            this.dgvCarteiras.TabIndex = 0;
            this.dgvCarteiras.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarteiras_CellDoubleClick);
            // 
            // col_cod
            // 
            this.col_cod.DataPropertyName = "COD_CARTEIRA";
            this.col_cod.HeaderText = "Cód.";
            this.col_cod.Name = "col_cod";
            this.col_cod.Width = 50;
            // 
            // col_nome
            // 
            this.col_nome.DataPropertyName = "NOME_CARTEIRA";
            this.col_nome.HeaderText = "Nome";
            this.col_nome.Name = "col_nome";
            // 
            // oBSCARTEIRADataGridViewTextBoxColumn
            // 
            this.oBSCARTEIRADataGridViewTextBoxColumn.DataPropertyName = "OBS_CARTEIRA";
            this.oBSCARTEIRADataGridViewTextBoxColumn.HeaderText = "Obs";
            this.oBSCARTEIRADataGridViewTextBoxColumn.Name = "oBSCARTEIRADataGridViewTextBoxColumn";
            this.oBSCARTEIRADataGridViewTextBoxColumn.Width = 150;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbCarteiras
            // 
            this.cbCarteiras.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbCarteiras.DataAdapter = this.datCarteiras;
            this.cbCarteiras.QuotePrefix = "\"";
            this.cbCarteiras.QuoteSuffix = "\"";
            // 
            // form_carteiras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 448);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvCarteiras);
            this.Name = "form_carteiras";
            this.Text = "Carteiras";
            this.Load += new System.EventHandler(this.form_carteiras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsCarteiras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CARTEIRAS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarteiras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datCarteiras;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Data.DataSet dsCarteiras;
        private System.Data.DataTable CARTEIRAS;
        private System.Data.DataColumn COD_CARTEIRA;
        private System.Data.DataColumn NOME_CARTEIRA;
        private System.Data.DataColumn OBS_CARTEIRA;
        private System.Windows.Forms.DataGridView dgvCarteiras;
        private System.Windows.Forms.Button button1;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbCarteiras;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn oBSCARTEIRADataGridViewTextBoxColumn;
    }
}