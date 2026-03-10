namespace Evolucao
{
    partial class form_pesquisas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_pesquisas));
            this.datPesquisas = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsPesquisas = new System.Data.DataSet();
            this.PESQUISAS = new System.Data.DataTable();
            this.COD_PESQUISA = new System.Data.DataColumn();
            this.DESCRICAO_PESQUISA = new System.Data.DataColumn();
            this.STRING_PESQUISA = new System.Data.DataColumn();
            this.dgvPesquisas = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.cbPesquisas = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.cODPESQUISADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRICAOPESQUISADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTRINGPESQUISADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dsPesquisas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PESQUISAS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisas)).BeginInit();
            this.SuspendLayout();
            // 
            // datPesquisas
            // 
            this.datPesquisas.DeleteCommand = this.fbCommand4;
            this.datPesquisas.InsertCommand = this.fbCommand2;
            this.datPesquisas.SelectCommand = this.fbCommand1;
            this.datPesquisas.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * from pesquisas";
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
            // dsPesquisas
            // 
            this.dsPesquisas.DataSetName = "dsPesquisas";
            this.dsPesquisas.Namespace = "http://www.tempuri.org/dsPesquisas.xsd";
            this.dsPesquisas.Tables.AddRange(new System.Data.DataTable[] {
            this.PESQUISAS});
            // 
            // PESQUISAS
            // 
            this.PESQUISAS.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_PESQUISA,
            this.DESCRICAO_PESQUISA,
            this.STRING_PESQUISA});
            this.PESQUISAS.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_PESQUISA"}, true)});
            this.PESQUISAS.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_PESQUISA};
            this.PESQUISAS.TableName = "PESQUISAS";
            // 
            // COD_PESQUISA
            // 
            this.COD_PESQUISA.AllowDBNull = false;
            this.COD_PESQUISA.AutoIncrement = true;
            this.COD_PESQUISA.AutoIncrementSeed = ((long)(1));
            this.COD_PESQUISA.ColumnName = "COD_PESQUISA";
            this.COD_PESQUISA.DataType = typeof(int);
            // 
            // DESCRICAO_PESQUISA
            // 
            this.DESCRICAO_PESQUISA.ColumnName = "DESCRICAO_PESQUISA";
            this.DESCRICAO_PESQUISA.MaxLength = 100;
            // 
            // STRING_PESQUISA
            // 
            this.STRING_PESQUISA.ColumnName = "STRING_PESQUISA";
            this.STRING_PESQUISA.MaxLength = 2000;
            // 
            // dgvPesquisas
            // 
            this.dgvPesquisas.AutoGenerateColumns = false;
            this.dgvPesquisas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesquisas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODPESQUISADataGridViewTextBoxColumn,
            this.dESCRICAOPESQUISADataGridViewTextBoxColumn,
            this.sTRINGPESQUISADataGridViewTextBoxColumn});
            this.dgvPesquisas.DataMember = "PESQUISAS";
            this.dgvPesquisas.DataSource = this.dsPesquisas;
            this.dgvPesquisas.Location = new System.Drawing.Point(12, 112);
            this.dgvPesquisas.Name = "dgvPesquisas";
            this.dgvPesquisas.Size = new System.Drawing.Size(804, 452);
            this.dgvPesquisas.TabIndex = 0;
            this.dgvPesquisas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPesquisas_CellDoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(371, 579);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbPesquisas
            // 
            this.cbPesquisas.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbPesquisas.DataAdapter = this.datPesquisas;
            this.cbPesquisas.QuotePrefix = "\"";
            this.cbPesquisas.QuoteSuffix = "\"";
            // 
            // cODPESQUISADataGridViewTextBoxColumn
            // 
            this.cODPESQUISADataGridViewTextBoxColumn.DataPropertyName = "COD_PESQUISA";
            this.cODPESQUISADataGridViewTextBoxColumn.HeaderText = "Cód.";
            this.cODPESQUISADataGridViewTextBoxColumn.Name = "cODPESQUISADataGridViewTextBoxColumn";
            this.cODPESQUISADataGridViewTextBoxColumn.Width = 40;
            // 
            // dESCRICAOPESQUISADataGridViewTextBoxColumn
            // 
            this.dESCRICAOPESQUISADataGridViewTextBoxColumn.DataPropertyName = "DESCRICAO_PESQUISA";
            this.dESCRICAOPESQUISADataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.dESCRICAOPESQUISADataGridViewTextBoxColumn.Name = "dESCRICAOPESQUISADataGridViewTextBoxColumn";
            this.dESCRICAOPESQUISADataGridViewTextBoxColumn.Width = 200;
            // 
            // sTRINGPESQUISADataGridViewTextBoxColumn
            // 
            this.sTRINGPESQUISADataGridViewTextBoxColumn.DataPropertyName = "STRING_PESQUISA";
            this.sTRINGPESQUISADataGridViewTextBoxColumn.FillWeight = 2000F;
            this.sTRINGPESQUISADataGridViewTextBoxColumn.HeaderText = "String";
            this.sTRINGPESQUISADataGridViewTextBoxColumn.MaxInputLength = 2000;
            this.sTRINGPESQUISADataGridViewTextBoxColumn.Name = "sTRINGPESQUISADataGridViewTextBoxColumn";
            this.sTRINGPESQUISADataGridViewTextBoxColumn.Width = 2000;
            // 
            // form_pesquisas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 614);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvPesquisas);
            this.Name = "form_pesquisas";
            this.Text = "Pesquisas";
            this.Load += new System.EventHandler(this.form_pesquisas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsPesquisas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PESQUISAS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datPesquisas;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Data.DataSet dsPesquisas;
        private System.Data.DataTable PESQUISAS;
        private System.Data.DataColumn COD_PESQUISA;
        private System.Data.DataColumn DESCRICAO_PESQUISA;
        private System.Data.DataColumn STRING_PESQUISA;
        private System.Windows.Forms.DataGridView dgvPesquisas;
        private System.Windows.Forms.Button button1;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbPesquisas;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODPESQUISADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRICAOPESQUISADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTRINGPESQUISADataGridViewTextBoxColumn;
    }
}