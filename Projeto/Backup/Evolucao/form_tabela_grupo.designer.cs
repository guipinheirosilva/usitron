namespace Evolucao
{
    partial class form_tabela_grupo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_tabela_grupo));
            this.datTab_grupo = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dgvTab_grupo = new System.Windows.Forms.DataGridView();
            this.cODGRUPODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbTab_grupo = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.NOME_GRUPO = new System.Data.DataColumn();
            this.COD_GRUPO = new System.Data.DataColumn();
            this.TAB_GRUPO = new System.Data.DataTable();
            this.dsTab_grupo = new System.Data.DataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTab_grupo)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TAB_GRUPO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTab_grupo)).BeginInit();
            this.SuspendLayout();
            // 
            // datTab_grupo
            // 
            this.datTab_grupo.DeleteCommand = this.fbCommand4;
            this.datTab_grupo.InsertCommand = this.fbCommand2;
            this.datTab_grupo.SelectCommand = this.fbCommand1;
            this.datTab_grupo.UpdateCommand = this.fbCommand3;
            this.datTab_grupo.RowUpdated += new FirebirdSql.Data.FirebirdClient.FbRowUpdatedEventHandler(this.datTab_grupo_RowUpdated);
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
            this.fbCommand1.CommandText = "SELECT * FROM TAB_GRUPO";
            this.fbCommand1.CommandTimeout = 30;
            this.fbCommand1.Connection = this.fbConnection1;
            // 
            // fbConnection1
            // 
            this.fbConnection1.ConnectionString = resources.GetString("fbConnection1.ConnectionString");
            this.fbConnection1.InfoMessage += new FirebirdSql.Data.FirebirdClient.FbInfoMessageEventHandler(this.fbConnection1_InfoMessage);
            // 
            // fbCommand3
            // 
            this.fbCommand3.CommandTimeout = 30;
            // 
            // dgvTab_grupo
            // 
            this.dgvTab_grupo.AutoGenerateColumns = false;
            this.dgvTab_grupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTab_grupo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODGRUPODataGridViewTextBoxColumn,
            this.col_nome});
            this.dgvTab_grupo.DataMember = "TAB_GRUPO";
            this.dgvTab_grupo.DataSource = this.dsTab_grupo;
            this.dgvTab_grupo.Location = new System.Drawing.Point(13, 13);
            this.dgvTab_grupo.Name = "dgvTab_grupo";
            this.dgvTab_grupo.RowHeadersWidth = 21;
            this.dgvTab_grupo.Size = new System.Drawing.Size(200, 313);
            this.dgvTab_grupo.TabIndex = 0;
            this.dgvTab_grupo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTab_grupo_CellDoubleClick);
            this.dgvTab_grupo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTab_grupo_CellContentClick);
            // 
            // cODGRUPODataGridViewTextBoxColumn
            // 
            this.cODGRUPODataGridViewTextBoxColumn.DataPropertyName = "COD_GRUPO";
            this.cODGRUPODataGridViewTextBoxColumn.HeaderText = "Cod.";
            this.cODGRUPODataGridViewTextBoxColumn.Name = "cODGRUPODataGridViewTextBoxColumn";
            this.cODGRUPODataGridViewTextBoxColumn.Width = 40;
            // 
            // col_nome
            // 
            this.col_nome.DataPropertyName = "NOME_GRUPO";
            this.col_nome.HeaderText = "Nome";
            this.col_nome.Name = "col_nome";
            this.col_nome.Width = 120;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.dgvTab_grupo);
            this.panel1.Location = new System.Drawing.Point(9, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 345);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.tbNome);
            this.panel2.Location = new System.Drawing.Point(9, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 39);
            this.panel2.TabIndex = 2;
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(34, 8);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(155, 20);
            this.tbNome.TabIndex = 0;
            this.tbNome.TextChanged += new System.EventHandler(this.tbNome_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbTab_grupo
            // 
            this.cbTab_grupo.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbTab_grupo.DataAdapter = this.datTab_grupo;
            this.cbTab_grupo.QuotePrefix = "\"";
            this.cbTab_grupo.QuoteSuffix = "\"";
            // 
            // NOME_GRUPO
            // 
            this.NOME_GRUPO.ColumnName = "NOME_GRUPO";
            this.NOME_GRUPO.MaxLength = 100;
            // 
            // COD_GRUPO
            // 
            this.COD_GRUPO.AllowDBNull = false;
            this.COD_GRUPO.AutoIncrement = true;
            this.COD_GRUPO.AutoIncrementSeed = ((long)(1));
            this.COD_GRUPO.ColumnName = "COD_GRUPO";
            this.COD_GRUPO.DataType = typeof(int);
            // 
            // TAB_GRUPO
            // 
            this.TAB_GRUPO.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_GRUPO,
            this.NOME_GRUPO});
            this.TAB_GRUPO.TableName = "TAB_GRUPO";
            // 
            // dsTab_grupo
            // 
            this.dsTab_grupo.DataSetName = "dsTab_grupo";
            this.dsTab_grupo.Namespace = "http://www.tempuri.org/dsTab_grupo.xsd";
            this.dsTab_grupo.Tables.AddRange(new System.Data.DataTable[] {
            this.TAB_GRUPO});
            // 
            // form_tabela_grupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 441);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "form_tabela_grupo";
            this.Text = "Tabela Grupo";
            this.Load += new System.EventHandler(this.form_tabela_grupo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTab_grupo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TAB_GRUPO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTab_grupo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datTab_grupo;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Windows.Forms.DataGridView dgvTab_grupo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Button button1;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbTab_grupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODGRUPODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nome;
        private System.Data.DataColumn NOME_GRUPO;
        private System.Data.DataColumn COD_GRUPO;
        private System.Data.DataTable TAB_GRUPO;
        private System.Data.DataSet dsTab_grupo;
    }
}