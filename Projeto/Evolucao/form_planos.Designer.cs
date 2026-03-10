namespace Evolucao
{
    partial class form_planos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_planos));
            this.datPlanos = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dgvPlanos = new System.Windows.Forms.DataGridView();
            this.dsGrupo_planos = new System.Data.DataSet();
            this.GRUPO_PLANOS = new System.Data.DataTable();
            this.COD_GP = new System.Data.DataColumn();
            this.DESCRICAO_GP = new System.Data.DataColumn();
            this.OBSERVACOES_GP = new System.Data.DataColumn();
            this.dsPlanos = new System.Data.DataSet();
            this.PLANOS = new System.Data.DataTable();
            this.COD_PLANO = new System.Data.DataColumn();
            this.NOME_PLANO = new System.Data.DataColumn();
            this.OBS_PLANO = new System.Data.DataColumn();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.cbPlanos = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.datGrupo_planos = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand8 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand6 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand5 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand7 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dataColumn3 = new System.Data.DataColumn();
            this.col_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GRUPO_PLANO = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.col_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oBSPLANODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO_PLANO = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.TIPO_DESPESA_PLANO = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGrupo_planos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRUPO_PLANOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PLANOS)).BeginInit();
            this.SuspendLayout();
            // 
            // datPlanos
            // 
            this.datPlanos.DeleteCommand = this.fbCommand4;
            this.datPlanos.InsertCommand = this.fbCommand2;
            this.datPlanos.SelectCommand = this.fbCommand1;
            this.datPlanos.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * from planos";
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
            // dgvPlanos
            // 
            this.dgvPlanos.AutoGenerateColumns = false;
            this.dgvPlanos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlanos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_cod,
            this.GRUPO_PLANO,
            this.col_nome,
            this.oBSPLANODataGridViewTextBoxColumn,
            this.TIPO_PLANO,
            this.TIPO_DESPESA_PLANO});
            this.dgvPlanos.DataMember = "PLANOS";
            this.dgvPlanos.DataSource = this.dsPlanos;
            this.dgvPlanos.Location = new System.Drawing.Point(12, 49);
            this.dgvPlanos.Name = "dgvPlanos";
            this.dgvPlanos.Size = new System.Drawing.Size(1121, 592);
            this.dgvPlanos.TabIndex = 0;
            this.dgvPlanos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlanos_CellDoubleClick);
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
            // dsPlanos
            // 
            this.dsPlanos.DataSetName = "dsPlanos";
            this.dsPlanos.Namespace = "http://www.tempuri.org/dsPlanos.xsd";
            this.dsPlanos.Tables.AddRange(new System.Data.DataTable[] {
            this.PLANOS});
            // 
            // PLANOS
            // 
            this.PLANOS.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_PLANO,
            this.NOME_PLANO,
            this.OBS_PLANO,
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3});
            this.PLANOS.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_PLANO"}, true)});
            this.PLANOS.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_PLANO};
            this.PLANOS.TableName = "PLANOS";
            // 
            // COD_PLANO
            // 
            this.COD_PLANO.AllowDBNull = false;
            this.COD_PLANO.AutoIncrement = true;
            this.COD_PLANO.AutoIncrementSeed = ((long)(1));
            this.COD_PLANO.ColumnName = "COD_PLANO";
            this.COD_PLANO.DataType = typeof(int);
            // 
            // NOME_PLANO
            // 
            this.NOME_PLANO.ColumnName = "NOME_PLANO";
            this.NOME_PLANO.MaxLength = 100;
            // 
            // OBS_PLANO
            // 
            this.OBS_PLANO.ColumnName = "OBS_PLANO";
            this.OBS_PLANO.MaxLength = 200;
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "GRUPO_PLANO";
            this.dataColumn1.MaxLength = 100;
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "TIPO_PLANO";
            this.dataColumn2.MaxLength = 100;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(541, 647);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbPlanos
            // 
            this.cbPlanos.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbPlanos.DataAdapter = this.datPlanos;
            this.cbPlanos.QuotePrefix = "\"";
            this.cbPlanos.QuoteSuffix = "\"";
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(404, 23);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(297, 20);
            this.tb_nome.TabIndex = 2;
            this.tb_nome.TextChanged += new System.EventHandler(this.tb_nome_TextChanged);
            // 
            // datGrupo_planos
            // 
            this.datGrupo_planos.DeleteCommand = this.fbCommand8;
            this.datGrupo_planos.InsertCommand = this.fbCommand6;
            this.datGrupo_planos.SelectCommand = this.fbCommand5;
            this.datGrupo_planos.UpdateCommand = this.fbCommand7;
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
            this.fbCommand5.CommandText = "SELECT * FROM GRUPO_PLANOS";
            this.fbCommand5.CommandTimeout = 30;
            this.fbCommand5.Connection = this.fbConnection1;
            // 
            // fbCommand7
            // 
            this.fbCommand7.CommandTimeout = 30;
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "TIPO_DESPESA_PLANO";
            this.dataColumn3.MaxLength = 100;
            // 
            // col_cod
            // 
            this.col_cod.DataPropertyName = "COD_PLANO";
            this.col_cod.HeaderText = "Cód.";
            this.col_cod.Name = "col_cod";
            this.col_cod.Width = 50;
            // 
            // GRUPO_PLANO
            // 
            this.GRUPO_PLANO.DataPropertyName = "GRUPO_PLANO";
            this.GRUPO_PLANO.DataSource = this.dsGrupo_planos;
            this.GRUPO_PLANO.DisplayMember = "GRUPO_PLANOS.DESCRICAO_GP";
            this.GRUPO_PLANO.HeaderText = "Grupo";
            this.GRUPO_PLANO.Name = "GRUPO_PLANO";
            this.GRUPO_PLANO.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GRUPO_PLANO.ValueMember = "GRUPO_PLANOS.DESCRICAO_GP";
            this.GRUPO_PLANO.Width = 260;
            // 
            // col_nome
            // 
            this.col_nome.DataPropertyName = "NOME_PLANO";
            this.col_nome.HeaderText = "Nome";
            this.col_nome.Name = "col_nome";
            this.col_nome.Width = 260;
            // 
            // oBSPLANODataGridViewTextBoxColumn
            // 
            this.oBSPLANODataGridViewTextBoxColumn.DataPropertyName = "OBS_PLANO";
            this.oBSPLANODataGridViewTextBoxColumn.HeaderText = "Obs";
            this.oBSPLANODataGridViewTextBoxColumn.Name = "oBSPLANODataGridViewTextBoxColumn";
            this.oBSPLANODataGridViewTextBoxColumn.Width = 180;
            // 
            // TIPO_PLANO
            // 
            this.TIPO_PLANO.DataPropertyName = "TIPO_PLANO";
            this.TIPO_PLANO.HeaderText = "Tipo";
            this.TIPO_PLANO.Items.AddRange(new object[] {
            "",
            "DESPESAS OPERACIONAIS"});
            this.TIPO_PLANO.Name = "TIPO_PLANO";
            this.TIPO_PLANO.Width = 150;
            // 
            // TIPO_DESPESA_PLANO
            // 
            this.TIPO_DESPESA_PLANO.DataPropertyName = "TIPO_DESPESA_PLANO";
            this.TIPO_DESPESA_PLANO.HeaderText = "Tipo Despesa";
            this.TIPO_DESPESA_PLANO.Items.AddRange(new object[] {
            "DESPESA FIXA",
            "DESPESA VARIAVEL"});
            this.TIPO_DESPESA_PLANO.Name = "TIPO_DESPESA_PLANO";
            this.TIPO_DESPESA_PLANO.Width = 150;
            // 
            // form_planos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 678);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvPlanos);
            this.Name = "form_planos";
            this.Text = "Planos";
            this.Load += new System.EventHandler(this.form_planos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGrupo_planos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRUPO_PLANOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PLANOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datPlanos;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Windows.Forms.DataGridView dgvPlanos;
        private System.Windows.Forms.Button button1;
        private System.Data.DataSet dsPlanos;
        private System.Data.DataTable PLANOS;
        private System.Data.DataColumn COD_PLANO;
        private System.Data.DataColumn NOME_PLANO;
        private System.Data.DataColumn OBS_PLANO;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbPlanos;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Data.DataSet dsGrupo_planos;
        private System.Data.DataTable GRUPO_PLANOS;
        private System.Data.DataColumn COD_GP;
        private System.Data.DataColumn DESCRICAO_GP;
        private System.Data.DataColumn OBSERVACOES_GP;
        private System.Data.DataColumn dataColumn1;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datGrupo_planos;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand8;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand6;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand5;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand7;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod;
        private System.Windows.Forms.DataGridViewComboBoxColumn GRUPO_PLANO;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn oBSPLANODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn TIPO_PLANO;
        private System.Windows.Forms.DataGridViewComboBoxColumn TIPO_DESPESA_PLANO;
    }
}