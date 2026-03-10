namespace Evolucao
{
    partial class form_tabela_material
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_tabela_material));
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvTab_material = new System.Windows.Forms.DataGridView();
            this.cODMATERIALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsTab_material = new System.Data.DataSet();
            this.TAB_MATERIAL = new System.Data.DataTable();
            this.COD_MATERIAL = new System.Data.DataColumn();
            this.NOME_MATERIAL = new System.Data.DataColumn();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand5 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand6 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand7 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand8 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.datTab_material = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand12 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand10 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand9 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand11 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.button1 = new System.Windows.Forms.Button();
            this.cbTab_material = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTab_material)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTab_material)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TAB_MATERIAL)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.tbNome);
            this.panel2.Location = new System.Drawing.Point(12, 12);
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
            this.panel1.Controls.Add(this.dgvTab_material);
            this.panel1.Location = new System.Drawing.Point(10, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 345);
            this.panel1.TabIndex = 4;
            // 
            // dgvTab_material
            // 
            this.dgvTab_material.AutoGenerateColumns = false;
            this.dgvTab_material.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTab_material.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODMATERIALDataGridViewTextBoxColumn,
            this.col_nome});
            this.dgvTab_material.DataMember = "TAB_MATERIAL";
            this.dgvTab_material.DataSource = this.dsTab_material;
            this.dgvTab_material.Location = new System.Drawing.Point(13, 13);
            this.dgvTab_material.Name = "dgvTab_material";
            this.dgvTab_material.RowHeadersWidth = 21;
            this.dgvTab_material.Size = new System.Drawing.Size(200, 313);
            this.dgvTab_material.TabIndex = 0;
            this.dgvTab_material.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTab_material_CellDoubleClick);
            // 
            // cODMATERIALDataGridViewTextBoxColumn
            // 
            this.cODMATERIALDataGridViewTextBoxColumn.DataPropertyName = "COD_MATERIAL";
            this.cODMATERIALDataGridViewTextBoxColumn.HeaderText = "Cod.";
            this.cODMATERIALDataGridViewTextBoxColumn.Name = "cODMATERIALDataGridViewTextBoxColumn";
            this.cODMATERIALDataGridViewTextBoxColumn.Width = 40;
            // 
            // col_nome
            // 
            this.col_nome.DataPropertyName = "NOME_MATERIAL";
            this.col_nome.HeaderText = "Nome";
            this.col_nome.Name = "col_nome";
            this.col_nome.Width = 120;
            // 
            // dsTab_material
            // 
            this.dsTab_material.DataSetName = "dsTab_material";
            this.dsTab_material.Namespace = "http://www.tempuri.org/dsTab_material.xsd";
            this.dsTab_material.Tables.AddRange(new System.Data.DataTable[] {
            this.TAB_MATERIAL});
            // 
            // TAB_MATERIAL
            // 
            this.TAB_MATERIAL.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_MATERIAL,
            this.NOME_MATERIAL});
            this.TAB_MATERIAL.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_MATERIAL"}, true)});
            this.TAB_MATERIAL.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_MATERIAL};
            this.TAB_MATERIAL.TableName = "TAB_MATERIAL";
            // 
            // COD_MATERIAL
            // 
            this.COD_MATERIAL.AllowDBNull = false;
            this.COD_MATERIAL.AutoIncrement = true;
            this.COD_MATERIAL.AutoIncrementSeed = ((long)(1));
            this.COD_MATERIAL.ColumnName = "COD_MATERIAL";
            this.COD_MATERIAL.DataType = typeof(int);
            // 
            // NOME_MATERIAL
            // 
            this.NOME_MATERIAL.ColumnName = "NOME_MATERIAL";
            this.NOME_MATERIAL.MaxLength = 100;
            // 
            // fbCommand1
            // 
            this.fbCommand1.CommandText = "SELECT * FROM TAB_MATERIAL";
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
            this.fbCommand5.CommandText = "SELECT * FROM TAB_MATERIAL";
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
            // datTab_material
            // 
            this.datTab_material.DeleteCommand = this.fbCommand12;
            this.datTab_material.InsertCommand = this.fbCommand10;
            this.datTab_material.SelectCommand = this.fbCommand9;
            this.datTab_material.UpdateCommand = this.fbCommand11;
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
            this.fbCommand9.CommandText = "SELECT * FROM TAB_MATERIAL";
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 42);
            this.button1.TabIndex = 5;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // cbTab_material
            // 
            this.cbTab_material.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbTab_material.DataAdapter = this.datTab_material;
            this.cbTab_material.QuotePrefix = "\"";
            this.cbTab_material.QuoteSuffix = "\"";
            // 
            // form_tabela_material
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 441);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "form_tabela_material";
            this.Text = "Tabela  Material";
            this.Load += new System.EventHandler(this.form_tabela_material_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTab_material)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTab_material)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TAB_MATERIAL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Panel panel1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand8;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand6;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand5;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand7;
        private System.Windows.Forms.DataGridView dgvTab_material;
        private System.Data.DataSet dsTab_material;
        private System.Data.DataTable TAB_MATERIAL;
        private System.Data.DataColumn COD_MATERIAL;
        private System.Data.DataColumn NOME_MATERIAL;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datTab_material;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand12;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand10;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand9;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand11;
        private System.Windows.Forms.Button button1;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbTab_material;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODMATERIALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nome;
    }
}