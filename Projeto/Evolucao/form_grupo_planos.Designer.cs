namespace Evolucao
{
    partial class form_grupo_planos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_grupo_planos));
            this.datGrupo_planos = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.dsGrupo_planos = new System.Data.DataSet();
            this.GRUPO_PLANOS = new System.Data.DataTable();
            this.COD_GP = new System.Data.DataColumn();
            this.DESCRICAO_GP = new System.Data.DataColumn();
            this.OBSERVACOES_GP = new System.Data.DataColumn();
            this.dgvGrupo_planos = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.cODGPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRICAOGPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oBSERVACOESGPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbGrupo_planos = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            ((System.ComponentModel.ISupportInitialize)(this.dsGrupo_planos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRUPO_PLANOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupo_planos)).BeginInit();
            this.SuspendLayout();
            // 
            // datGrupo_planos
            // 
            this.datGrupo_planos.DeleteCommand = this.fbCommand4;
            this.datGrupo_planos.InsertCommand = this.fbCommand2;
            this.datGrupo_planos.SelectCommand = this.fbCommand1;
            this.datGrupo_planos.UpdateCommand = this.fbCommand3;
            // 
            // fbCommand1
            // 
            this.fbCommand1.CommandText = "select * from grupo_planos";
            this.fbCommand1.CommandTimeout = 30;
            this.fbCommand1.Connection = this.fbConnection1;
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
            // fbConnection1
            // 
            this.fbConnection1.ConnectionString = resources.GetString("fbConnection1.ConnectionString");
            // 
            // dsGrupo_planos
            // 
            this.dsGrupo_planos.DataSetName = "dsGrupo_planos";
            this.dsGrupo_planos.Namespace = "http://www.tempuri.org/dsGrupo_planos.xsd";
            this.dsGrupo_planos.Tables.AddRange(new System.Data.DataTable[] {
            this.GRUPO_PLANOS});
            // 
            // GRUPO_PLANOS
            // 
            this.GRUPO_PLANOS.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_GP,
            this.DESCRICAO_GP,
            this.OBSERVACOES_GP});
            this.GRUPO_PLANOS.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_GP"}, true)});
            this.GRUPO_PLANOS.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_GP};
            this.GRUPO_PLANOS.TableName = "GRUPO_PLANOS";
            // 
            // COD_GP
            // 
            this.COD_GP.AllowDBNull = false;
            this.COD_GP.AutoIncrement = true;
            this.COD_GP.AutoIncrementSeed = ((long)(1));
            this.COD_GP.ColumnName = "COD_GP";
            this.COD_GP.DataType = typeof(int);
            // 
            // DESCRICAO_GP
            // 
            this.DESCRICAO_GP.ColumnName = "DESCRICAO_GP";
            this.DESCRICAO_GP.MaxLength = 100;
            // 
            // OBSERVACOES_GP
            // 
            this.OBSERVACOES_GP.ColumnName = "OBSERVACOES_GP";
            this.OBSERVACOES_GP.MaxLength = 500;
            // 
            // dgvGrupo_planos
            // 
            this.dgvGrupo_planos.AutoGenerateColumns = false;
            this.dgvGrupo_planos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrupo_planos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODGPDataGridViewTextBoxColumn,
            this.dESCRICAOGPDataGridViewTextBoxColumn,
            this.oBSERVACOESGPDataGridViewTextBoxColumn});
            this.dgvGrupo_planos.DataMember = "GRUPO_PLANOS";
            this.dgvGrupo_planos.DataSource = this.dsGrupo_planos;
            this.dgvGrupo_planos.Location = new System.Drawing.Point(12, 28);
            this.dgvGrupo_planos.Name = "dgvGrupo_planos";
            this.dgvGrupo_planos.Size = new System.Drawing.Size(339, 314);
            this.dgvGrupo_planos.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cODGPDataGridViewTextBoxColumn
            // 
            this.cODGPDataGridViewTextBoxColumn.DataPropertyName = "COD_GP";
            this.cODGPDataGridViewTextBoxColumn.HeaderText = "Cód. ";
            this.cODGPDataGridViewTextBoxColumn.Name = "cODGPDataGridViewTextBoxColumn";
            this.cODGPDataGridViewTextBoxColumn.Width = 50;
            // 
            // dESCRICAOGPDataGridViewTextBoxColumn
            // 
            this.dESCRICAOGPDataGridViewTextBoxColumn.DataPropertyName = "DESCRICAO_GP";
            this.dESCRICAOGPDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.dESCRICAOGPDataGridViewTextBoxColumn.Name = "dESCRICAOGPDataGridViewTextBoxColumn";
            // 
            // oBSERVACOESGPDataGridViewTextBoxColumn
            // 
            this.oBSERVACOESGPDataGridViewTextBoxColumn.DataPropertyName = "OBSERVACOES_GP";
            this.oBSERVACOESGPDataGridViewTextBoxColumn.HeaderText = "Obrservações";
            this.oBSERVACOESGPDataGridViewTextBoxColumn.Name = "oBSERVACOESGPDataGridViewTextBoxColumn";
            this.oBSERVACOESGPDataGridViewTextBoxColumn.Width = 200;
            // 
            // cbGrupo_planos
            // 
            this.cbGrupo_planos.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbGrupo_planos.DataAdapter = this.datGrupo_planos;
            this.cbGrupo_planos.QuotePrefix = "\"";
            this.cbGrupo_planos.QuoteSuffix = "\"";
            // 
            // form_grupo_planos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 398);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvGrupo_planos);
            this.Name = "form_grupo_planos";
            this.Text = "Grupo Planos";
            this.Load += new System.EventHandler(this.form_grupo_planos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsGrupo_planos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRUPO_PLANOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupo_planos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datGrupo_planos;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private System.Data.DataSet dsGrupo_planos;
        private System.Data.DataTable GRUPO_PLANOS;
        private System.Data.DataColumn COD_GP;
        private System.Data.DataColumn DESCRICAO_GP;
        private System.Data.DataColumn OBSERVACOES_GP;
        private System.Windows.Forms.DataGridView dgvGrupo_planos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODGPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRICAOGPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oBSERVACOESGPDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbGrupo_planos;
    }
}