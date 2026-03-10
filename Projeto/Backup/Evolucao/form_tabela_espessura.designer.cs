namespace Evolucao
{
    partial class form_tabela_espessura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_tabela_espessura));
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvTab_espessura = new System.Windows.Forms.DataGridView();
            this.dsTab_espessura = new System.Data.DataSet();
            this.TAB_ESPESSURA = new System.Data.DataTable();
            this.COD_ESPESSURA = new System.Data.DataColumn();
            this.NOME_ESPESSURA = new System.Data.DataColumn();
            this.datTab_espessura = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.cbTab_espessura = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.button1 = new System.Windows.Forms.Button();
            this.cODESPESSURADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTab_espessura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTab_espessura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TAB_ESPESSURA)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.tbNome);
            this.panel2.Location = new System.Drawing.Point(10, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 39);
            this.panel2.TabIndex = 3;
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
            this.panel1.Controls.Add(this.dgvTab_espessura);
            this.panel1.Location = new System.Drawing.Point(10, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 345);
            this.panel1.TabIndex = 4;
            // 
            // dgvTab_espessura
            // 
            this.dgvTab_espessura.AutoGenerateColumns = false;
            this.dgvTab_espessura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTab_espessura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODESPESSURADataGridViewTextBoxColumn,
            this.col_nome});
            this.dgvTab_espessura.DataMember = "TAB_ESPESSURA";
            this.dgvTab_espessura.DataSource = this.dsTab_espessura;
            this.dgvTab_espessura.Location = new System.Drawing.Point(13, 13);
            this.dgvTab_espessura.Name = "dgvTab_espessura";
            this.dgvTab_espessura.RowHeadersWidth = 21;
            this.dgvTab_espessura.Size = new System.Drawing.Size(200, 313);
            this.dgvTab_espessura.TabIndex = 0;
            this.dgvTab_espessura.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTab_espessura_CellDoubleClick);
            // 
            // dsTab_espessura
            // 
            this.dsTab_espessura.DataSetName = "dsTab_espessura";
            this.dsTab_espessura.Namespace = "http://www.tempuri.org/dsTab_espessura.xsd";
            this.dsTab_espessura.Tables.AddRange(new System.Data.DataTable[] {
            this.TAB_ESPESSURA});
            // 
            // TAB_ESPESSURA
            // 
            this.TAB_ESPESSURA.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_ESPESSURA,
            this.NOME_ESPESSURA});
            this.TAB_ESPESSURA.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_ESPESSURA"}, true)});
            this.TAB_ESPESSURA.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_ESPESSURA};
            this.TAB_ESPESSURA.TableName = "TAB_ESPESSURA";
            // 
            // COD_ESPESSURA
            // 
            this.COD_ESPESSURA.AllowDBNull = false;
            this.COD_ESPESSURA.AutoIncrement = true;
            this.COD_ESPESSURA.AutoIncrementSeed = ((long)(1));
            this.COD_ESPESSURA.ColumnName = "COD_ESPESSURA";
            this.COD_ESPESSURA.DataType = typeof(int);
            // 
            // NOME_ESPESSURA
            // 
            this.NOME_ESPESSURA.ColumnName = "NOME_ESPESSURA";
            this.NOME_ESPESSURA.MaxLength = 100;
            // 
            // datTab_espessura
            // 
            this.datTab_espessura.DeleteCommand = this.fbCommand4;
            this.datTab_espessura.InsertCommand = this.fbCommand2;
            this.datTab_espessura.SelectCommand = this.fbCommand1;
            this.datTab_espessura.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "SELECT * FROM TAB_ESPESSURA";
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
            // cbTab_espessura
            // 
            this.cbTab_espessura.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbTab_espessura.DataAdapter = this.datTab_espessura;
            this.cbTab_espessura.QuotePrefix = "\"";
            this.cbTab_espessura.QuoteSuffix = "\"";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cODESPESSURADataGridViewTextBoxColumn
            // 
            this.cODESPESSURADataGridViewTextBoxColumn.DataPropertyName = "COD_ESPESSURA";
            this.cODESPESSURADataGridViewTextBoxColumn.HeaderText = "Cod.";
            this.cODESPESSURADataGridViewTextBoxColumn.Name = "cODESPESSURADataGridViewTextBoxColumn";
            this.cODESPESSURADataGridViewTextBoxColumn.Width = 40;
            // 
            // col_nome
            // 
            this.col_nome.DataPropertyName = "NOME_ESPESSURA";
            this.col_nome.HeaderText = "Nome";
            this.col_nome.Name = "col_nome";
            this.col_nome.Width = 120;
            // 
            // form_tabela_espessura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 441);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "form_tabela_espessura";
            this.Text = "Tabela  Espessura";
            this.Load += new System.EventHandler(this.form_tabela_espessura_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTab_espessura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTab_espessura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TAB_ESPESSURA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Panel panel1;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datTab_espessura;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Data.DataSet dsTab_espessura;
        private System.Data.DataTable TAB_ESPESSURA;
        private System.Data.DataColumn COD_ESPESSURA;
        private System.Data.DataColumn NOME_ESPESSURA;
        private System.Windows.Forms.DataGridView dgvTab_espessura;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbTab_espessura;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODESPESSURADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nome;
    }
}