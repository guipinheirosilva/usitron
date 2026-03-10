namespace Evolucao
{
    partial class form_localiza_tabela_preco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_localiza_tabela_preco));
            this.datTabela_preco = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsTabela_preco = new System.Data.DataSet();
            this.TABELA_PRECO = new System.Data.DataTable();
            this.COD_TABELA_PRECO = new System.Data.DataColumn();
            this.NOME_TABELA_PRECO = new System.Data.DataColumn();
            this.dgvTabela_preco = new System.Windows.Forms.DataGridView();
            this.col_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dsTabela_preco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TABELA_PRECO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabela_preco)).BeginInit();
            this.SuspendLayout();
            // 
            // datTabela_preco
            // 
            this.datTabela_preco.DeleteCommand = this.fbCommand4;
            this.datTabela_preco.InsertCommand = this.fbCommand2;
            this.datTabela_preco.SelectCommand = this.fbCommand1;
            this.datTabela_preco.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * from tabela_preco";
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
            // dsTabela_preco
            // 
            this.dsTabela_preco.DataSetName = "dsTabela_preco";
            this.dsTabela_preco.Namespace = "http://www.tempuri.org/dsTabela_preco.xsd";
            this.dsTabela_preco.Tables.AddRange(new System.Data.DataTable[] {
            this.TABELA_PRECO});
            // 
            // TABELA_PRECO
            // 
            this.TABELA_PRECO.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_TABELA_PRECO,
            this.NOME_TABELA_PRECO});
            this.TABELA_PRECO.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_TABELA_PRECO"}, true)});
            this.TABELA_PRECO.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_TABELA_PRECO};
            this.TABELA_PRECO.TableName = "TABELA_PRECO";
            // 
            // COD_TABELA_PRECO
            // 
            this.COD_TABELA_PRECO.AllowDBNull = false;
            this.COD_TABELA_PRECO.ColumnName = "COD_TABELA_PRECO";
            this.COD_TABELA_PRECO.DataType = typeof(int);
            // 
            // NOME_TABELA_PRECO
            // 
            this.NOME_TABELA_PRECO.ColumnName = "NOME_TABELA_PRECO";
            this.NOME_TABELA_PRECO.MaxLength = 200;
            // 
            // dgvTabela_preco
            // 
            this.dgvTabela_preco.AllowUserToAddRows = false;
            this.dgvTabela_preco.AllowUserToDeleteRows = false;
            this.dgvTabela_preco.AutoGenerateColumns = false;
            this.dgvTabela_preco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabela_preco.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_cod,
            this.col_descricao});
            this.dgvTabela_preco.DataMember = "TABELA_PRECO";
            this.dgvTabela_preco.DataSource = this.dsTabela_preco;
            this.dgvTabela_preco.Location = new System.Drawing.Point(4, 2);
            this.dgvTabela_preco.Name = "dgvTabela_preco";
            this.dgvTabela_preco.RowHeadersVisible = false;
            this.dgvTabela_preco.Size = new System.Drawing.Size(246, 417);
            this.dgvTabela_preco.TabIndex = 0;
            this.dgvTabela_preco.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTabela_preco_CellClick);
            // 
            // col_cod
            // 
            this.col_cod.DataPropertyName = "COD_TABELA_PRECO";
            this.col_cod.HeaderText = "Cód.";
            this.col_cod.Name = "col_cod";
            this.col_cod.Width = 30;
            // 
            // col_descricao
            // 
            this.col_descricao.DataPropertyName = "NOME_TABELA_PRECO";
            this.col_descricao.HeaderText = "Nome";
            this.col_descricao.Name = "col_descricao";
            this.col_descricao.Width = 200;
            // 
            // form_localiza_tabela_preco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 420);
            this.Controls.Add(this.dgvTabela_preco);
            this.Name = "form_localiza_tabela_preco";
            this.Text = "Localiza Tabela Preço";
            this.Load += new System.EventHandler(this.form_localiza_tabela_preco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsTabela_preco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TABELA_PRECO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabela_preco)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datTabela_preco;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Data.DataSet dsTabela_preco;
        private System.Data.DataTable TABELA_PRECO;
        private System.Data.DataColumn COD_TABELA_PRECO;
        private System.Data.DataColumn NOME_TABELA_PRECO;
        private System.Windows.Forms.DataGridView dgvTabela_preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_descricao;
    }
}