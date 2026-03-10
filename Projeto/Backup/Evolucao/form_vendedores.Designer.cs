namespace Evolucao
{
    partial class form_vendedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_vendedores));
            this.datVendedores = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsVendedores = new System.Data.DataSet();
            this.VENDEDORES = new System.Data.DataTable();
            this.COD_VENDEDOR = new System.Data.DataColumn();
            this.NOME_VENDEDOR = new System.Data.DataColumn();
            this.TELEFONE_VENDEDOR = new System.Data.DataColumn();
            this.CELULAR_VENDEDOR = new System.Data.DataColumn();
            this.ENDERECO_VENDEDOR = new System.Data.DataColumn();
            this.dgvVendedores = new System.Windows.Forms.DataGridView();
            this.col_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tELEFONEVENDEDORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cELULARVENDEDORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNDERECOVENDEDORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.cbVendedores = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            ((System.ComponentModel.ISupportInitialize)(this.dsVendedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VENDEDORES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendedores)).BeginInit();
            this.SuspendLayout();
            // 
            // datVendedores
            // 
            this.datVendedores.DeleteCommand = this.fbCommand4;
            this.datVendedores.InsertCommand = this.fbCommand2;
            this.datVendedores.SelectCommand = this.fbCommand1;
            this.datVendedores.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * from vendedores";
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
            // dsVendedores
            // 
            this.dsVendedores.DataSetName = "dsVendedores";
            this.dsVendedores.Namespace = "http://www.tempuri.org/dsVendedores.xsd";
            this.dsVendedores.Tables.AddRange(new System.Data.DataTable[] {
            this.VENDEDORES});
            // 
            // VENDEDORES
            // 
            this.VENDEDORES.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_VENDEDOR,
            this.NOME_VENDEDOR,
            this.TELEFONE_VENDEDOR,
            this.CELULAR_VENDEDOR,
            this.ENDERECO_VENDEDOR});
            this.VENDEDORES.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_VENDEDOR"}, true)});
            this.VENDEDORES.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_VENDEDOR};
            this.VENDEDORES.TableName = "VENDEDORES";
            // 
            // COD_VENDEDOR
            // 
            this.COD_VENDEDOR.AllowDBNull = false;
            this.COD_VENDEDOR.AutoIncrement = true;
            this.COD_VENDEDOR.AutoIncrementSeed = ((long)(1));
            this.COD_VENDEDOR.ColumnName = "COD_VENDEDOR";
            this.COD_VENDEDOR.DataType = typeof(int);
            // 
            // NOME_VENDEDOR
            // 
            this.NOME_VENDEDOR.ColumnName = "NOME_VENDEDOR";
            this.NOME_VENDEDOR.MaxLength = 100;
            // 
            // TELEFONE_VENDEDOR
            // 
            this.TELEFONE_VENDEDOR.ColumnName = "TELEFONE_VENDEDOR";
            this.TELEFONE_VENDEDOR.MaxLength = 100;
            // 
            // CELULAR_VENDEDOR
            // 
            this.CELULAR_VENDEDOR.ColumnName = "CELULAR_VENDEDOR";
            this.CELULAR_VENDEDOR.MaxLength = 100;
            // 
            // ENDERECO_VENDEDOR
            // 
            this.ENDERECO_VENDEDOR.ColumnName = "ENDERECO_VENDEDOR";
            this.ENDERECO_VENDEDOR.MaxLength = 200;
            // 
            // dgvVendedores
            // 
            this.dgvVendedores.AutoGenerateColumns = false;
            this.dgvVendedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_cod,
            this.col_nome,
            this.tELEFONEVENDEDORDataGridViewTextBoxColumn,
            this.cELULARVENDEDORDataGridViewTextBoxColumn,
            this.eNDERECOVENDEDORDataGridViewTextBoxColumn});
            this.dgvVendedores.DataMember = "VENDEDORES";
            this.dgvVendedores.DataSource = this.dsVendedores;
            this.dgvVendedores.Location = new System.Drawing.Point(12, 54);
            this.dgvVendedores.Name = "dgvVendedores";
            this.dgvVendedores.Size = new System.Drawing.Size(648, 347);
            this.dgvVendedores.TabIndex = 0;
            this.dgvVendedores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVendedores_CellDoubleClick);
            // 
            // col_cod
            // 
            this.col_cod.DataPropertyName = "COD_VENDEDOR";
            this.col_cod.HeaderText = "Cód.";
            this.col_cod.Name = "col_cod";
            this.col_cod.Width = 30;
            // 
            // col_nome
            // 
            this.col_nome.DataPropertyName = "NOME_VENDEDOR";
            this.col_nome.HeaderText = "Nome";
            this.col_nome.Name = "col_nome";
            this.col_nome.Width = 150;
            // 
            // tELEFONEVENDEDORDataGridViewTextBoxColumn
            // 
            this.tELEFONEVENDEDORDataGridViewTextBoxColumn.DataPropertyName = "TELEFONE_VENDEDOR";
            this.tELEFONEVENDEDORDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.tELEFONEVENDEDORDataGridViewTextBoxColumn.Name = "tELEFONEVENDEDORDataGridViewTextBoxColumn";
            // 
            // cELULARVENDEDORDataGridViewTextBoxColumn
            // 
            this.cELULARVENDEDORDataGridViewTextBoxColumn.DataPropertyName = "CELULAR_VENDEDOR";
            this.cELULARVENDEDORDataGridViewTextBoxColumn.HeaderText = "Celular";
            this.cELULARVENDEDORDataGridViewTextBoxColumn.Name = "cELULARVENDEDORDataGridViewTextBoxColumn";
            // 
            // eNDERECOVENDEDORDataGridViewTextBoxColumn
            // 
            this.eNDERECOVENDEDORDataGridViewTextBoxColumn.DataPropertyName = "ENDERECO_VENDEDOR";
            this.eNDERECOVENDEDORDataGridViewTextBoxColumn.HeaderText = "Endereço";
            this.eNDERECOVENDEDORDataGridViewTextBoxColumn.Name = "eNDERECOVENDEDORDataGridViewTextBoxColumn";
            this.eNDERECOVENDEDORDataGridViewTextBoxColumn.Width = 200;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(306, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbVendedores
            // 
            this.cbVendedores.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbVendedores.DataAdapter = this.datVendedores;
            this.cbVendedores.QuotePrefix = "\"";
            this.cbVendedores.QuoteSuffix = "\"";
            // 
            // form_vendedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 475);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvVendedores);
            this.Name = "form_vendedores";
            this.Text = "Vendedores";
            this.Load += new System.EventHandler(this.form_vendedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsVendedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VENDEDORES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datVendedores;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Data.DataSet dsVendedores;
        private System.Data.DataTable VENDEDORES;
        private System.Data.DataColumn COD_VENDEDOR;
        private System.Data.DataColumn NOME_VENDEDOR;
        private System.Data.DataColumn TELEFONE_VENDEDOR;
        private System.Data.DataColumn CELULAR_VENDEDOR;
        private System.Data.DataColumn ENDERECO_VENDEDOR;
        private System.Windows.Forms.DataGridView dgvVendedores;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn tELEFONEVENDEDORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cELULARVENDEDORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNDERECOVENDEDORDataGridViewTextBoxColumn;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbVendedores;
    }
}