namespace Evolucao
{
    partial class form_tabela_classificacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_tabela_classificacao));
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvTab_classificacao = new System.Windows.Forms.DataGridView();
            this.dsTab_classificacao = new System.Data.DataSet();
            this.TAB_CLASSIFICACAO = new System.Data.DataTable();
            this.COD_CLASSIFICACAO = new System.Data.DataColumn();
            this.NOME_CLASSIFICACAO = new System.Data.DataColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.datTab_classificacao = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.cbTab_classificacao = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.cODCLASSIFICACAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTab_classificacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTab_classificacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TAB_CLASSIFICACAO)).BeginInit();
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
            this.panel1.Controls.Add(this.dgvTab_classificacao);
            this.panel1.Location = new System.Drawing.Point(10, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 345);
            this.panel1.TabIndex = 5;
            // 
            // dgvTab_classificacao
            // 
            this.dgvTab_classificacao.AutoGenerateColumns = false;
            this.dgvTab_classificacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTab_classificacao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODCLASSIFICACAODataGridViewTextBoxColumn,
            this.col_nome});
            this.dgvTab_classificacao.DataMember = "TAB_CLASSIFICACAO";
            this.dgvTab_classificacao.DataSource = this.dsTab_classificacao;
            this.dgvTab_classificacao.Location = new System.Drawing.Point(13, 13);
            this.dgvTab_classificacao.Name = "dgvTab_classificacao";
            this.dgvTab_classificacao.RowHeadersWidth = 21;
            this.dgvTab_classificacao.Size = new System.Drawing.Size(200, 313);
            this.dgvTab_classificacao.TabIndex = 0;
            this.dgvTab_classificacao.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTab_classificacao_CellDoubleClick);
            this.dgvTab_classificacao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTab_classificacao_CellContentClick);
            // 
            // dsTab_classificacao
            // 
            this.dsTab_classificacao.DataSetName = "dsTab_classificacao";
            this.dsTab_classificacao.Namespace = "http://www.tempuri.org/dsTab_classificacao.xsd";
            this.dsTab_classificacao.Tables.AddRange(new System.Data.DataTable[] {
            this.TAB_CLASSIFICACAO});
            // 
            // TAB_CLASSIFICACAO
            // 
            this.TAB_CLASSIFICACAO.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_CLASSIFICACAO,
            this.NOME_CLASSIFICACAO});
            this.TAB_CLASSIFICACAO.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_CLASSIFICACAO"}, true)});
            this.TAB_CLASSIFICACAO.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_CLASSIFICACAO};
            this.TAB_CLASSIFICACAO.TableName = "TAB_CLASSIFICACAO";
            // 
            // COD_CLASSIFICACAO
            // 
            this.COD_CLASSIFICACAO.AllowDBNull = false;
            this.COD_CLASSIFICACAO.AutoIncrement = true;
            this.COD_CLASSIFICACAO.AutoIncrementSeed = ((long)(1));
            this.COD_CLASSIFICACAO.ColumnName = "COD_CLASSIFICACAO";
            this.COD_CLASSIFICACAO.DataType = typeof(int);
            // 
            // NOME_CLASSIFICACAO
            // 
            this.NOME_CLASSIFICACAO.ColumnName = "NOME_CLASSIFICACAO";
            this.NOME_CLASSIFICACAO.MaxLength = 100;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // datTab_classificacao
            // 
            this.datTab_classificacao.DeleteCommand = this.fbCommand4;
            this.datTab_classificacao.InsertCommand = this.fbCommand2;
            this.datTab_classificacao.SelectCommand = this.fbCommand1;
            this.datTab_classificacao.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "SELECT * FROM TAB_CLASSIFICACAO";
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
            // cbTab_classificacao
            // 
            this.cbTab_classificacao.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbTab_classificacao.DataAdapter = this.datTab_classificacao;
            this.cbTab_classificacao.QuotePrefix = "\"";
            this.cbTab_classificacao.QuoteSuffix = "\"";
            // 
            // cODCLASSIFICACAODataGridViewTextBoxColumn
            // 
            this.cODCLASSIFICACAODataGridViewTextBoxColumn.DataPropertyName = "COD_CLASSIFICACAO";
            this.cODCLASSIFICACAODataGridViewTextBoxColumn.HeaderText = "Cod.";
            this.cODCLASSIFICACAODataGridViewTextBoxColumn.Name = "cODCLASSIFICACAODataGridViewTextBoxColumn";
            this.cODCLASSIFICACAODataGridViewTextBoxColumn.Width = 40;
            // 
            // col_nome
            // 
            this.col_nome.DataPropertyName = "NOME_CLASSIFICACAO";
            this.col_nome.HeaderText = "Nome";
            this.col_nome.Name = "col_nome";
            this.col_nome.Width = 120;
            // 
            // form_tabela_classificacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 441);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "form_tabela_classificacao";
            this.Text = "Tabela  Classificação";
            this.Load += new System.EventHandler(this.form_tabela_classificacao_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTab_classificacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTab_classificacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TAB_CLASSIFICACAO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datTab_classificacao;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Windows.Forms.DataGridView dgvTab_classificacao;
        private System.Data.DataSet dsTab_classificacao;
        private System.Data.DataTable TAB_CLASSIFICACAO;
        private System.Data.DataColumn COD_CLASSIFICACAO;
        private System.Data.DataColumn NOME_CLASSIFICACAO;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbTab_classificacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODCLASSIFICACAODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nome;
    }
}