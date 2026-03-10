namespace Evolucao
{
    partial class form_tabela_dimensao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_tabela_dimensao));
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvTab_dimensao = new System.Windows.Forms.DataGridView();
            this.dsTab_dimensao = new System.Data.DataSet();
            this.TAB_DIMENSAO = new System.Data.DataTable();
            this.COD_DIMENSAO = new System.Data.DataColumn();
            this.NOME_DIMENSAO = new System.Data.DataColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.datTab_dimensao = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand8 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand6 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand5 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand7 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.cbTab_dimensao = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.cODDIMENSAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTab_dimensao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTab_dimensao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TAB_DIMENSAO)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.tbNome);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 39);
            this.panel2.TabIndex = 4;
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(34, 8);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(155, 20);
            this.tbNome.TabIndex = 0;
            this.tbNome.TextChanged += new System.EventHandler(this.tbNome_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.dgvTab_dimensao);
            this.panel1.Location = new System.Drawing.Point(10, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 345);
            this.panel1.TabIndex = 5;
            // 
            // dgvTab_dimensao
            // 
            this.dgvTab_dimensao.AutoGenerateColumns = false;
            this.dgvTab_dimensao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTab_dimensao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODDIMENSAODataGridViewTextBoxColumn,
            this.col_nome});
            this.dgvTab_dimensao.DataMember = "TAB_DIMENSAO";
            this.dgvTab_dimensao.DataSource = this.dsTab_dimensao;
            this.dgvTab_dimensao.Location = new System.Drawing.Point(13, 13);
            this.dgvTab_dimensao.Name = "dgvTab_dimensao";
            this.dgvTab_dimensao.RowHeadersWidth = 21;
            this.dgvTab_dimensao.Size = new System.Drawing.Size(200, 313);
            this.dgvTab_dimensao.TabIndex = 0;
            this.dgvTab_dimensao.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTab_dimensao_CellDoubleClick);
            // 
            // dsTab_dimensao
            // 
            this.dsTab_dimensao.DataSetName = "dsTab_dimensao";
            this.dsTab_dimensao.Namespace = "http://www.tempuri.org/dsTab_dimensao.xsd";
            this.dsTab_dimensao.Tables.AddRange(new System.Data.DataTable[] {
            this.TAB_DIMENSAO});
            // 
            // TAB_DIMENSAO
            // 
            this.TAB_DIMENSAO.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_DIMENSAO,
            this.NOME_DIMENSAO});
            this.TAB_DIMENSAO.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_DIMENSAO"}, true)});
            this.TAB_DIMENSAO.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_DIMENSAO};
            this.TAB_DIMENSAO.TableName = "TAB_DIMENSAO";
            // 
            // COD_DIMENSAO
            // 
            this.COD_DIMENSAO.AllowDBNull = false;
            this.COD_DIMENSAO.AutoIncrement = true;
            this.COD_DIMENSAO.AutoIncrementSeed = ((long)(1));
            this.COD_DIMENSAO.ColumnName = "COD_DIMENSAO";
            this.COD_DIMENSAO.DataType = typeof(int);
            // 
            // NOME_DIMENSAO
            // 
            this.NOME_DIMENSAO.ColumnName = "NOME_DIMENSAO";
            this.NOME_DIMENSAO.MaxLength = 100;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fbCommand1
            // 
            this.fbCommand1.CommandTimeout = 30;
            // 
            // fbCommand2
            // 
            this.fbCommand2.CommandTimeout = 30;
            // 
            // fbCommand3
            // 
            this.fbCommand3.CommandTimeout = 30;
            // 
            // fbCommand4
            // 
            this.fbCommand4.CommandTimeout = 30;
            // 
            // datTab_dimensao
            // 
            this.datTab_dimensao.DeleteCommand = this.fbCommand8;
            this.datTab_dimensao.InsertCommand = this.fbCommand6;
            this.datTab_dimensao.SelectCommand = this.fbCommand5;
            this.datTab_dimensao.UpdateCommand = this.fbCommand7;
            // 
            // fbCommand8
            // 
            this.fbCommand8.CommandTimeout = 30;
            // 
            // fbCommand6
            // 
            this.fbCommand6.CommandTimeout = 30;
            // 
            // fbCommand5
            // 
            this.fbCommand5.CommandText = "SELECT * FROM TAB_DIMENSAO";
            this.fbCommand5.CommandTimeout = 30;
            this.fbCommand5.Connection = this.fbConnection1;
            // 
            // fbConnection1
            // 
            this.fbConnection1.ConnectionString = resources.GetString("fbConnection1.ConnectionString");
            // 
            // fbCommand7
            // 
            this.fbCommand7.CommandTimeout = 30;
            // 
            // cbTab_dimensao
            // 
            this.cbTab_dimensao.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbTab_dimensao.DataAdapter = this.datTab_dimensao;
            this.cbTab_dimensao.QuotePrefix = "\"";
            this.cbTab_dimensao.QuoteSuffix = "\"";
            // 
            // cODDIMENSAODataGridViewTextBoxColumn
            // 
            this.cODDIMENSAODataGridViewTextBoxColumn.DataPropertyName = "COD_DIMENSAO";
            this.cODDIMENSAODataGridViewTextBoxColumn.HeaderText = "Cod.";
            this.cODDIMENSAODataGridViewTextBoxColumn.Name = "cODDIMENSAODataGridViewTextBoxColumn";
            this.cODDIMENSAODataGridViewTextBoxColumn.Width = 40;
            // 
            // col_nome
            // 
            this.col_nome.DataPropertyName = "NOME_DIMENSAO";
            this.col_nome.HeaderText = "Nome";
            this.col_nome.Name = "col_nome";
            this.col_nome.Width = 120;
            // 
            // form_tabela_dimensao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 441);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "form_tabela_dimensao";
            this.Text = "Tabela Dimensão";
            this.Load += new System.EventHandler(this.form_tabela_dimensao_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTab_dimensao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTab_dimensao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TAB_DIMENSAO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvTab_dimensao;
        private System.Data.DataSet dsTab_dimensao;
        private System.Data.DataTable TAB_DIMENSAO;
        private System.Data.DataColumn COD_DIMENSAO;
        private System.Data.DataColumn NOME_DIMENSAO;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datTab_dimensao;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand8;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand6;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand5;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand7;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbTab_dimensao;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODDIMENSAODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nome;
    }
}