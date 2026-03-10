namespace Evolucao
{
    partial class form_forma_pgto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_forma_pgto));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.datForma_pgto = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsForma_pgto = new System.Data.DataSet();
            this.FORMA_PGTO = new System.Data.DataTable();
            this.COD_FORMA_PGTO = new System.Data.DataColumn();
            this.DESCRICAO_FORMA_PGTO = new System.Data.DataColumn();
            this.N_PARCELAS_FORMA_PGTO = new System.Data.DataColumn();
            this.PRAZO_1_FORMA_PGTO = new System.Data.DataColumn();
            this.PRAZO_2_FORMA_PGTO = new System.Data.DataColumn();
            this.PRAZO_3_FORMA_PGTO = new System.Data.DataColumn();
            this.PRAZO_4_FORMA_PGTO = new System.Data.DataColumn();
            this.PRAZO_5_FORMA_PGTO = new System.Data.DataColumn();
            this.PRAZO_6_FORMA_PGTO = new System.Data.DataColumn();
            this.dgvForma_pgto = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.cbForma_pgto = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.cODFORMAPGTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_n_parcelas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_prazo_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_prazo_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_prazo_3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_prazo_4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_prazo_5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_prazo_6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dsForma_pgto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FORMA_PGTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvForma_pgto)).BeginInit();
            this.SuspendLayout();
            // 
            // datForma_pgto
            // 
            this.datForma_pgto.DeleteCommand = this.fbCommand4;
            this.datForma_pgto.InsertCommand = this.fbCommand2;
            this.datForma_pgto.SelectCommand = this.fbCommand1;
            this.datForma_pgto.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * from forma_pgto";
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
            // dsForma_pgto
            // 
            this.dsForma_pgto.DataSetName = "dsForma_pgto";
            this.dsForma_pgto.Namespace = "http://www.tempuri.org/dsForma_pgto.xsd";
            this.dsForma_pgto.Tables.AddRange(new System.Data.DataTable[] {
            this.FORMA_PGTO});
            // 
            // FORMA_PGTO
            // 
            this.FORMA_PGTO.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_FORMA_PGTO,
            this.DESCRICAO_FORMA_PGTO,
            this.N_PARCELAS_FORMA_PGTO,
            this.PRAZO_1_FORMA_PGTO,
            this.PRAZO_2_FORMA_PGTO,
            this.PRAZO_3_FORMA_PGTO,
            this.PRAZO_4_FORMA_PGTO,
            this.PRAZO_5_FORMA_PGTO,
            this.PRAZO_6_FORMA_PGTO});
            this.FORMA_PGTO.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_FORMA_PGTO"}, true)});
            this.FORMA_PGTO.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_FORMA_PGTO};
            this.FORMA_PGTO.TableName = "FORMA_PGTO";
            // 
            // COD_FORMA_PGTO
            // 
            this.COD_FORMA_PGTO.AllowDBNull = false;
            this.COD_FORMA_PGTO.AutoIncrement = true;
            this.COD_FORMA_PGTO.AutoIncrementSeed = ((long)(1));
            this.COD_FORMA_PGTO.ColumnName = "COD_FORMA_PGTO";
            this.COD_FORMA_PGTO.DataType = typeof(int);
            // 
            // DESCRICAO_FORMA_PGTO
            // 
            this.DESCRICAO_FORMA_PGTO.ColumnName = "DESCRICAO_FORMA_PGTO";
            this.DESCRICAO_FORMA_PGTO.MaxLength = 100;
            // 
            // N_PARCELAS_FORMA_PGTO
            // 
            this.N_PARCELAS_FORMA_PGTO.ColumnName = "N_PARCELAS_FORMA_PGTO";
            this.N_PARCELAS_FORMA_PGTO.DataType = typeof(int);
            // 
            // PRAZO_1_FORMA_PGTO
            // 
            this.PRAZO_1_FORMA_PGTO.ColumnName = "PRAZO_1_FORMA_PGTO";
            this.PRAZO_1_FORMA_PGTO.DataType = typeof(int);
            // 
            // PRAZO_2_FORMA_PGTO
            // 
            this.PRAZO_2_FORMA_PGTO.ColumnName = "PRAZO_2_FORMA_PGTO";
            this.PRAZO_2_FORMA_PGTO.DataType = typeof(int);
            // 
            // PRAZO_3_FORMA_PGTO
            // 
            this.PRAZO_3_FORMA_PGTO.ColumnName = "PRAZO_3_FORMA_PGTO";
            this.PRAZO_3_FORMA_PGTO.DataType = typeof(int);
            // 
            // PRAZO_4_FORMA_PGTO
            // 
            this.PRAZO_4_FORMA_PGTO.ColumnName = "PRAZO_4_FORMA_PGTO";
            this.PRAZO_4_FORMA_PGTO.DataType = typeof(int);
            // 
            // PRAZO_5_FORMA_PGTO
            // 
            this.PRAZO_5_FORMA_PGTO.ColumnName = "PRAZO_5_FORMA_PGTO";
            this.PRAZO_5_FORMA_PGTO.DataType = typeof(int);
            // 
            // PRAZO_6_FORMA_PGTO
            // 
            this.PRAZO_6_FORMA_PGTO.ColumnName = "PRAZO_6_FORMA_PGTO";
            this.PRAZO_6_FORMA_PGTO.DataType = typeof(int);
            // 
            // dgvForma_pgto
            // 
            this.dgvForma_pgto.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvForma_pgto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvForma_pgto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvForma_pgto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODFORMAPGTODataGridViewTextBoxColumn,
            this.col_descricao,
            this.col_n_parcelas,
            this.col_prazo_1,
            this.col_prazo_2,
            this.col_prazo_3,
            this.col_prazo_4,
            this.col_prazo_5,
            this.col_prazo_6});
            this.dgvForma_pgto.DataMember = "FORMA_PGTO";
            this.dgvForma_pgto.DataSource = this.dsForma_pgto;
            this.dgvForma_pgto.Location = new System.Drawing.Point(12, 102);
            this.dgvForma_pgto.Name = "dgvForma_pgto";
            this.dgvForma_pgto.Size = new System.Drawing.Size(549, 150);
            this.dgvForma_pgto.TabIndex = 0;
            this.dgvForma_pgto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvForma_pgto_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(191, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 26);
            this.button1.TabIndex = 1;
            this.button1.Text = "Salvar Alterações";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label28.Location = new System.Drawing.Point(127, 9);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(331, 42);
            this.label28.TabIndex = 89;
            this.label28.Text = "FORMA DE PGTO";
            // 
            // cbForma_pgto
            // 
            this.cbForma_pgto.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbForma_pgto.DataAdapter = this.datForma_pgto;
            this.cbForma_pgto.QuotePrefix = "\"";
            this.cbForma_pgto.QuoteSuffix = "\"";
            // 
            // cODFORMAPGTODataGridViewTextBoxColumn
            // 
            this.cODFORMAPGTODataGridViewTextBoxColumn.DataPropertyName = "COD_FORMA_PGTO";
            this.cODFORMAPGTODataGridViewTextBoxColumn.HeaderText = "Cód.";
            this.cODFORMAPGTODataGridViewTextBoxColumn.Name = "cODFORMAPGTODataGridViewTextBoxColumn";
            this.cODFORMAPGTODataGridViewTextBoxColumn.Width = 50;
            // 
            // col_descricao
            // 
            this.col_descricao.DataPropertyName = "DESCRICAO_FORMA_PGTO";
            this.col_descricao.HeaderText = "Descrição";
            this.col_descricao.Name = "col_descricao";
            this.col_descricao.Width = 80;
            // 
            // col_n_parcelas
            // 
            this.col_n_parcelas.DataPropertyName = "N_PARCELAS_FORMA_PGTO";
            this.col_n_parcelas.HeaderText = "nº Parc";
            this.col_n_parcelas.Name = "col_n_parcelas";
            this.col_n_parcelas.Width = 68;
            // 
            // col_prazo_1
            // 
            this.col_prazo_1.DataPropertyName = "PRAZO_1_FORMA_PGTO";
            this.col_prazo_1.HeaderText = "Prazo 1";
            this.col_prazo_1.Name = "col_prazo_1";
            this.col_prazo_1.Width = 50;
            // 
            // col_prazo_2
            // 
            this.col_prazo_2.DataPropertyName = "PRAZO_2_FORMA_PGTO";
            this.col_prazo_2.HeaderText = "Prazo 2";
            this.col_prazo_2.Name = "col_prazo_2";
            this.col_prazo_2.Width = 50;
            // 
            // col_prazo_3
            // 
            this.col_prazo_3.DataPropertyName = "PRAZO_3_FORMA_PGTO";
            this.col_prazo_3.HeaderText = "Prazo 3";
            this.col_prazo_3.Name = "col_prazo_3";
            this.col_prazo_3.Width = 50;
            // 
            // col_prazo_4
            // 
            this.col_prazo_4.DataPropertyName = "PRAZO_4_FORMA_PGTO";
            this.col_prazo_4.HeaderText = "Prazo 4";
            this.col_prazo_4.Name = "col_prazo_4";
            this.col_prazo_4.Width = 50;
            // 
            // col_prazo_5
            // 
            this.col_prazo_5.DataPropertyName = "PRAZO_5_FORMA_PGTO";
            this.col_prazo_5.HeaderText = "Prazo 5";
            this.col_prazo_5.Name = "col_prazo_5";
            this.col_prazo_5.Width = 50;
            // 
            // col_prazo_6
            // 
            this.col_prazo_6.DataPropertyName = "PRAZO_6_FORMA_PGTO";
            this.col_prazo_6.HeaderText = "Prazo 6";
            this.col_prazo_6.Name = "col_prazo_6";
            this.col_prazo_6.Width = 50;
            // 
            // form_forma_pgto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 264);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvForma_pgto);
            this.Name = "form_forma_pgto";
            this.Text = "Forma de Pagamento";
            this.Load += new System.EventHandler(this.form_forma_pgto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsForma_pgto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FORMA_PGTO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvForma_pgto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datForma_pgto;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Data.DataSet dsForma_pgto;
        private System.Data.DataTable FORMA_PGTO;
        private System.Data.DataColumn COD_FORMA_PGTO;
        private System.Data.DataColumn DESCRICAO_FORMA_PGTO;
        private System.Data.DataColumn N_PARCELAS_FORMA_PGTO;
        private System.Data.DataColumn PRAZO_1_FORMA_PGTO;
        private System.Data.DataColumn PRAZO_2_FORMA_PGTO;
        private System.Data.DataColumn PRAZO_3_FORMA_PGTO;
        private System.Data.DataColumn PRAZO_4_FORMA_PGTO;
        private System.Data.DataColumn PRAZO_5_FORMA_PGTO;
        private System.Data.DataColumn PRAZO_6_FORMA_PGTO;
        private System.Windows.Forms.DataGridView dgvForma_pgto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label28;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbForma_pgto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODFORMAPGTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_n_parcelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_prazo_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_prazo_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_prazo_3;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_prazo_4;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_prazo_5;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_prazo_6;
    }
}