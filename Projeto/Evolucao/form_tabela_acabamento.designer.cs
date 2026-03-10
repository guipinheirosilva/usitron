namespace Evolucao
{
    partial class form_tabela_acabamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_tabela_acabamento));
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvTab_acabamento = new System.Windows.Forms.DataGridView();
            this.cODACABAMENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsTab_acabamento = new System.Data.DataSet();
            this.TAB_ACABAMENTO = new System.Data.DataTable();
            this.COD_ACABAMENTO = new System.Data.DataColumn();
            this.NOME_ACABAMENTO = new System.Data.DataColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand5 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand6 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand7 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand8 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.datTab_acabamento = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand12 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand10 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand9 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand11 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.cbTab_acabamento = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTab_acabamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTab_acabamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TAB_ACABAMENTO)).BeginInit();
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
            this.panel1.Controls.Add(this.dgvTab_acabamento);
            this.panel1.Location = new System.Drawing.Point(10, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 345);
            this.panel1.TabIndex = 5;
            // 
            // dgvTab_acabamento
            // 
            this.dgvTab_acabamento.AutoGenerateColumns = false;
            this.dgvTab_acabamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTab_acabamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODACABAMENTODataGridViewTextBoxColumn,
            this.col_nome});
            this.dgvTab_acabamento.DataMember = "TAB_ACABAMENTO";
            this.dgvTab_acabamento.DataSource = this.dsTab_acabamento;
            this.dgvTab_acabamento.Location = new System.Drawing.Point(13, 13);
            this.dgvTab_acabamento.Name = "dgvTab_acabamento";
            this.dgvTab_acabamento.RowHeadersWidth = 21;
            this.dgvTab_acabamento.Size = new System.Drawing.Size(200, 313);
            this.dgvTab_acabamento.TabIndex = 0;
            this.dgvTab_acabamento.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTab_acabamento_CellDoubleClick);
            // 
            // cODACABAMENTODataGridViewTextBoxColumn
            // 
            this.cODACABAMENTODataGridViewTextBoxColumn.DataPropertyName = "COD_ACABAMENTO";
            this.cODACABAMENTODataGridViewTextBoxColumn.HeaderText = "Cod.";
            this.cODACABAMENTODataGridViewTextBoxColumn.Name = "cODACABAMENTODataGridViewTextBoxColumn";
            this.cODACABAMENTODataGridViewTextBoxColumn.Width = 40;
            // 
            // col_nome
            // 
            this.col_nome.DataPropertyName = "NOME_ACABAMENTO";
            this.col_nome.HeaderText = "Nome";
            this.col_nome.Name = "col_nome";
            this.col_nome.Width = 120;
            // 
            // dsTab_acabamento
            // 
            this.dsTab_acabamento.DataSetName = "dsTab_acabamento";
            this.dsTab_acabamento.Namespace = "http://www.tempuri.org/dsTab_acabamento.xsd";
            this.dsTab_acabamento.Tables.AddRange(new System.Data.DataTable[] {
            this.TAB_ACABAMENTO});
            // 
            // TAB_ACABAMENTO
            // 
            this.TAB_ACABAMENTO.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_ACABAMENTO,
            this.NOME_ACABAMENTO});
            this.TAB_ACABAMENTO.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_ACABAMENTO"}, true)});
            this.TAB_ACABAMENTO.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_ACABAMENTO};
            this.TAB_ACABAMENTO.TableName = "TAB_ACABAMENTO";
            // 
            // COD_ACABAMENTO
            // 
            this.COD_ACABAMENTO.AllowDBNull = false;
            this.COD_ACABAMENTO.AutoIncrement = true;
            this.COD_ACABAMENTO.AutoIncrementSeed = ((long)(1));
            this.COD_ACABAMENTO.ColumnName = "COD_ACABAMENTO";
            this.COD_ACABAMENTO.DataType = typeof(int);
            // 
            // NOME_ACABAMENTO
            // 
            this.NOME_ACABAMENTO.ColumnName = "NOME_ACABAMENTO";
            this.NOME_ACABAMENTO.MaxLength = 100;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 28);
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
            this.fbCommand5.CommandText = "SELECT * FROM TAB_ACABAMENTO";
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
            // datTab_acabamento
            // 
            this.datTab_acabamento.DeleteCommand = this.fbCommand12;
            this.datTab_acabamento.InsertCommand = this.fbCommand10;
            this.datTab_acabamento.SelectCommand = this.fbCommand9;
            this.datTab_acabamento.UpdateCommand = this.fbCommand11;
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
            this.fbCommand9.CommandText = "SELECT * FROM TAB_ACABAMENTO";
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
            // cbTab_acabamento
            // 
            this.cbTab_acabamento.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbTab_acabamento.DataAdapter = this.datTab_acabamento;
            this.cbTab_acabamento.QuotePrefix = "\"";
            this.cbTab_acabamento.QuoteSuffix = "\"";
            // 
            // form_tabela_acabamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 441);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "form_tabela_acabamento";
            this.Text = "Tabela  Acabamento";
            this.Load += new System.EventHandler(this.form_tabela_acabamento_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTab_acabamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTab_acabamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TAB_ACABAMENTO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand8;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand6;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand5;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand7;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datTab_acabamento;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand12;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand10;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand9;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand11;
        private System.Data.DataSet dsTab_acabamento;
        private System.Data.DataTable TAB_ACABAMENTO;
        private System.Data.DataColumn COD_ACABAMENTO;
        private System.Data.DataColumn NOME_ACABAMENTO;
        private System.Windows.Forms.DataGridView dgvTab_acabamento;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbTab_acabamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODACABAMENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nome;
    }
}