namespace Evolucao
{
    partial class form_tabela_comprimento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_tabela_comprimento));
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvTab_comprimento = new System.Windows.Forms.DataGridView();
            this.dsTab_comprimento = new System.Data.DataSet();
            this.TAB_COMPRIMENTO = new System.Data.DataTable();
            this.COD_COMPRIMENTO = new System.Data.DataColumn();
            this.NOME_COMPRIMENTO = new System.Data.DataColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand5 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand6 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand7 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand8 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.datTab_comprimento = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand12 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand10 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand9 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand11 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.cbTab_comprimento = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.cODCOMPRIMENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTab_comprimento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTab_comprimento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TAB_COMPRIMENTO)).BeginInit();
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
            this.panel1.Controls.Add(this.dgvTab_comprimento);
            this.panel1.Location = new System.Drawing.Point(10, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 345);
            this.panel1.TabIndex = 5;
            // 
            // dgvTab_comprimento
            // 
            this.dgvTab_comprimento.AutoGenerateColumns = false;
            this.dgvTab_comprimento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTab_comprimento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODCOMPRIMENTODataGridViewTextBoxColumn,
            this.col_nome});
            this.dgvTab_comprimento.DataMember = "TAB_COMPRIMENTO";
            this.dgvTab_comprimento.DataSource = this.dsTab_comprimento;
            this.dgvTab_comprimento.Location = new System.Drawing.Point(13, 13);
            this.dgvTab_comprimento.Name = "dgvTab_comprimento";
            this.dgvTab_comprimento.RowHeadersWidth = 21;
            this.dgvTab_comprimento.Size = new System.Drawing.Size(200, 313);
            this.dgvTab_comprimento.TabIndex = 0;
            this.dgvTab_comprimento.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTab_comprimento_CellDoubleClick);
            // 
            // dsTab_comprimento
            // 
            this.dsTab_comprimento.DataSetName = "dsTab_comprimento";
            this.dsTab_comprimento.Namespace = "http://www.tempuri.org/dsTab_comprimento.xsd";
            this.dsTab_comprimento.Tables.AddRange(new System.Data.DataTable[] {
            this.TAB_COMPRIMENTO});
            // 
            // TAB_COMPRIMENTO
            // 
            this.TAB_COMPRIMENTO.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_COMPRIMENTO,
            this.NOME_COMPRIMENTO});
            this.TAB_COMPRIMENTO.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_COMPRIMENTO"}, true)});
            this.TAB_COMPRIMENTO.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_COMPRIMENTO};
            this.TAB_COMPRIMENTO.TableName = "TAB_COMPRIMENTO";
            // 
            // COD_COMPRIMENTO
            // 
            this.COD_COMPRIMENTO.AllowDBNull = false;
            this.COD_COMPRIMENTO.AutoIncrement = true;
            this.COD_COMPRIMENTO.AutoIncrementSeed = ((long)(1));
            this.COD_COMPRIMENTO.ColumnName = "COD_COMPRIMENTO";
            this.COD_COMPRIMENTO.DataType = typeof(int);
            // 
            // NOME_COMPRIMENTO
            // 
            this.NOME_COMPRIMENTO.ColumnName = "NOME_COMPRIMENTO";
            this.NOME_COMPRIMENTO.MaxLength = 100;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 37);
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
            // fbCommand5
            // 
            this.fbCommand5.CommandText = "SELECT * FROM TAB_COMPRIMENTO";
            this.fbCommand5.CommandTimeout = 30;
            // 
            // fbCommand6
            // 
            this.fbCommand6.CommandTimeout = 30;
            // 
            // fbCommand7
            // 
            this.fbCommand7.CommandTimeout = 30;
            // 
            // fbCommand8
            // 
            this.fbCommand8.CommandTimeout = 30;
            // 
            // datTab_comprimento
            // 
            this.datTab_comprimento.DeleteCommand = this.fbCommand12;
            this.datTab_comprimento.InsertCommand = this.fbCommand10;
            this.datTab_comprimento.SelectCommand = this.fbCommand9;
            this.datTab_comprimento.UpdateCommand = this.fbCommand11;
            // 
            // fbCommand12
            // 
            this.fbCommand12.CommandTimeout = 30;
            // 
            // fbCommand10
            // 
            this.fbCommand10.CommandTimeout = 30;
            // 
            // fbCommand9
            // 
            this.fbCommand9.CommandText = "SELECT * FROM TAB_COMPRIMENTO";
            this.fbCommand9.CommandTimeout = 30;
            this.fbCommand9.Connection = this.fbConnection1;
            // 
            // fbConnection1
            // 
            this.fbConnection1.ConnectionString = resources.GetString("fbConnection1.ConnectionString");
            // 
            // fbCommand11
            // 
            this.fbCommand11.CommandTimeout = 30;
            // 
            // cbTab_comprimento
            // 
            this.cbTab_comprimento.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbTab_comprimento.DataAdapter = this.datTab_comprimento;
            this.cbTab_comprimento.QuotePrefix = "\"";
            this.cbTab_comprimento.QuoteSuffix = "\"";
            // 
            // cODCOMPRIMENTODataGridViewTextBoxColumn
            // 
            this.cODCOMPRIMENTODataGridViewTextBoxColumn.DataPropertyName = "COD_COMPRIMENTO";
            this.cODCOMPRIMENTODataGridViewTextBoxColumn.HeaderText = "Cod.";
            this.cODCOMPRIMENTODataGridViewTextBoxColumn.Name = "cODCOMPRIMENTODataGridViewTextBoxColumn";
            this.cODCOMPRIMENTODataGridViewTextBoxColumn.Width = 40;
            // 
            // col_nome
            // 
            this.col_nome.DataPropertyName = "NOME_COMPRIMENTO";
            this.col_nome.HeaderText = "Nome";
            this.col_nome.Name = "col_nome";
            this.col_nome.Width = 120;
            // 
            // form_tabela_comprimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 441);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "form_tabela_comprimento";
            this.Text = "Tabela Comprimento";
            this.Load += new System.EventHandler(this.form_tabela_comprimento_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTab_comprimento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTab_comprimento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TAB_COMPRIMENTO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand8;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand6;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand5;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand7;
        private System.Windows.Forms.DataGridView dgvTab_comprimento;
        private System.Data.DataSet dsTab_comprimento;
        private System.Data.DataTable TAB_COMPRIMENTO;
        private System.Data.DataColumn COD_COMPRIMENTO;
        private System.Data.DataColumn NOME_COMPRIMENTO;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datTab_comprimento;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand12;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand10;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand9;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand11;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbTab_comprimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODCOMPRIMENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nome;
    }
}