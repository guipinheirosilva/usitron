namespace Evolucao
{
    partial class form_busca_contato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_busca_contato));
            this.button1 = new System.Windows.Forms.Button();
            this.datContatos = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsContatos = new System.Data.DataSet();
            this.CONTATOS = new System.Data.DataTable();
            this.COD_CONTATO = new System.Data.DataColumn();
            this.NOME_CONTATO = new System.Data.DataColumn();
            this.EMAIL_CONTATO = new System.Data.DataColumn();
            this.TEL_1_CONTATO = new System.Data.DataColumn();
            this.TEL_2_CONTATO = new System.Data.DataColumn();
            this.CLIENTE_FORN_CONTATO = new System.Data.DataColumn();
            this.COD_CLIENTE_FORN_CONTATO = new System.Data.DataColumn();
            this.TIPO_CONTATO = new System.Data.DataColumn();
            this.dgvContatos = new System.Windows.Forms.DataGridView();
            this.cODCONTATODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_tel2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTEFORNCONTATODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dsContatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CONTATOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContatos)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(299, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 75;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // datContatos
            // 
            this.datContatos.DeleteCommand = this.fbCommand4;
            this.datContatos.InsertCommand = this.fbCommand2;
            this.datContatos.SelectCommand = this.fbCommand1;
            this.datContatos.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * from contatos";
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
            // dsContatos
            // 
            this.dsContatos.DataSetName = "dsContatos";
            this.dsContatos.Namespace = "http://www.tempuri.org/dsContatos.xsd";
            this.dsContatos.Tables.AddRange(new System.Data.DataTable[] {
            this.CONTATOS});
            // 
            // CONTATOS
            // 
            this.CONTATOS.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_CONTATO,
            this.NOME_CONTATO,
            this.EMAIL_CONTATO,
            this.TEL_1_CONTATO,
            this.TEL_2_CONTATO,
            this.CLIENTE_FORN_CONTATO,
            this.COD_CLIENTE_FORN_CONTATO,
            this.TIPO_CONTATO});
            this.CONTATOS.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_CONTATO"}, true)});
            this.CONTATOS.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_CONTATO};
            this.CONTATOS.TableName = "CONTATOS";
            // 
            // COD_CONTATO
            // 
            this.COD_CONTATO.AllowDBNull = false;
            this.COD_CONTATO.ColumnName = "COD_CONTATO";
            this.COD_CONTATO.DataType = typeof(int);
            // 
            // NOME_CONTATO
            // 
            this.NOME_CONTATO.ColumnName = "NOME_CONTATO";
            this.NOME_CONTATO.MaxLength = 100;
            // 
            // EMAIL_CONTATO
            // 
            this.EMAIL_CONTATO.ColumnName = "EMAIL_CONTATO";
            this.EMAIL_CONTATO.MaxLength = 100;
            // 
            // TEL_1_CONTATO
            // 
            this.TEL_1_CONTATO.ColumnName = "TEL_1_CONTATO";
            this.TEL_1_CONTATO.MaxLength = 100;
            // 
            // TEL_2_CONTATO
            // 
            this.TEL_2_CONTATO.ColumnName = "TEL_2_CONTATO";
            this.TEL_2_CONTATO.MaxLength = 100;
            // 
            // CLIENTE_FORN_CONTATO
            // 
            this.CLIENTE_FORN_CONTATO.ColumnName = "CLIENTE_FORN_CONTATO";
            this.CLIENTE_FORN_CONTATO.MaxLength = 10;
            // 
            // COD_CLIENTE_FORN_CONTATO
            // 
            this.COD_CLIENTE_FORN_CONTATO.ColumnName = "COD_CLIENTE_FORN_CONTATO";
            this.COD_CLIENTE_FORN_CONTATO.DataType = typeof(int);
            // 
            // TIPO_CONTATO
            // 
            this.TIPO_CONTATO.ColumnName = "TIPO_CONTATO";
            this.TIPO_CONTATO.MaxLength = 30;
            // 
            // dgvContatos
            // 
            this.dgvContatos.AllowUserToAddRows = false;
            this.dgvContatos.AutoGenerateColumns = false;
            this.dgvContatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODCONTATODataGridViewTextBoxColumn,
            this.col_nome,
            this.col_email,
            this.col_tel,
            this.col_tel2,
            this.dataGridViewTextBoxColumn1,
            this.cLIENTEFORNCONTATODataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2});
            this.dgvContatos.DataMember = "CONTATOS";
            this.dgvContatos.DataSource = this.dsContatos;
            this.dgvContatos.Location = new System.Drawing.Point(9, 12);
            this.dgvContatos.Name = "dgvContatos";
            this.dgvContatos.Size = new System.Drawing.Size(654, 178);
            this.dgvContatos.TabIndex = 76;
            // 
            // cODCONTATODataGridViewTextBoxColumn
            // 
            this.cODCONTATODataGridViewTextBoxColumn.DataPropertyName = "COD_CONTATO";
            this.cODCONTATODataGridViewTextBoxColumn.HeaderText = "COD_CONTATO";
            this.cODCONTATODataGridViewTextBoxColumn.Name = "cODCONTATODataGridViewTextBoxColumn";
            this.cODCONTATODataGridViewTextBoxColumn.Visible = false;
            // 
            // col_nome
            // 
            this.col_nome.DataPropertyName = "NOME_CONTATO";
            this.col_nome.HeaderText = "Nome";
            this.col_nome.Name = "col_nome";
            this.col_nome.Width = 170;
            // 
            // col_email
            // 
            this.col_email.DataPropertyName = "EMAIL_CONTATO";
            this.col_email.HeaderText = "Email";
            this.col_email.Name = "col_email";
            this.col_email.Width = 140;
            // 
            // col_tel
            // 
            this.col_tel.DataPropertyName = "TEL_1_CONTATO";
            this.col_tel.HeaderText = "Telefone 1";
            this.col_tel.Name = "col_tel";
            this.col_tel.Width = 90;
            // 
            // col_tel2
            // 
            this.col_tel2.DataPropertyName = "TEL_2_CONTATO";
            this.col_tel2.HeaderText = "Telefone 2";
            this.col_tel2.Name = "col_tel2";
            this.col_tel2.Width = 90;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TIPO_CONTATO";
            this.dataGridViewTextBoxColumn1.HeaderText = "Tipo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // cLIENTEFORNCONTATODataGridViewTextBoxColumn
            // 
            this.cLIENTEFORNCONTATODataGridViewTextBoxColumn.DataPropertyName = "CLIENTE_FORN_CONTATO";
            this.cLIENTEFORNCONTATODataGridViewTextBoxColumn.HeaderText = "CLIENTE_FORN_CONTATO";
            this.cLIENTEFORNCONTATODataGridViewTextBoxColumn.Name = "cLIENTEFORNCONTATODataGridViewTextBoxColumn";
            this.cLIENTEFORNCONTATODataGridViewTextBoxColumn.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "COD_CLIENTE_FORN_CONTATO";
            this.dataGridViewTextBoxColumn2.HeaderText = "COD_CLIENTE_FORN_CONTATO";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // form_busca_contato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 262);
            this.Controls.Add(this.dgvContatos);
            this.Controls.Add(this.button1);
            this.Name = "form_busca_contato";
            this.Text = "Busca Contato";
            this.Load += new System.EventHandler(this.form_busca_contato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsContatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CONTATOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datContatos;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private System.Data.DataSet dsContatos;
        private System.Data.DataTable CONTATOS;
        private System.Data.DataColumn COD_CONTATO;
        private System.Data.DataColumn NOME_CONTATO;
        private System.Data.DataColumn EMAIL_CONTATO;
        private System.Data.DataColumn TEL_1_CONTATO;
        private System.Data.DataColumn TEL_2_CONTATO;
        private System.Data.DataColumn CLIENTE_FORN_CONTATO;
        private System.Data.DataColumn COD_CLIENTE_FORN_CONTATO;
        private System.Data.DataColumn TIPO_CONTATO;
        private System.Windows.Forms.DataGridView dgvContatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODCONTATODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTEFORNCONTATODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}