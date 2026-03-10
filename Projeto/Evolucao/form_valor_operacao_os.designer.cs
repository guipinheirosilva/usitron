namespace Evolucao
{
    partial class form_valor_operacao_os
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_valor_operacao_os));
            this.button6 = new System.Windows.Forms.Button();
            this.dgvVoo = new System.Windows.Forms.DataGridView();
            this.dsVoo = new System.Data.DataSet();
            this.VALOR_OPERACAO_OS = new System.Data.DataTable();
            this.COD_VOO = new System.Data.DataColumn();
            this.OPERACAO_VOO = new System.Data.DataColumn();
            this.VALOR_HORA_VOO = new System.Data.DataColumn();
            this.HORAS_PREVISTAS_VOO = new System.Data.DataColumn();
            this.OS_VOO = new System.Data.DataColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.datVoo = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.cbVoo = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.dataColumn1 = new System.Data.DataColumn();
            this.cODVOODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPERACAOVOODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORHORAVOODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORASPREVISTASVOODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_prev_pos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oSVOODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVoo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VALOR_OPERACAO_OS)).BeginInit();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 21);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(105, 23);
            this.button6.TabIndex = 3;
            this.button6.Text = "Inserir Operação";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dgvVoo
            // 
            this.dgvVoo.AllowUserToAddRows = false;
            this.dgvVoo.AutoGenerateColumns = false;
            this.dgvVoo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVoo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODVOODataGridViewTextBoxColumn,
            this.oPERACAOVOODataGridViewTextBoxColumn,
            this.vALORHORAVOODataGridViewTextBoxColumn,
            this.hORASPREVISTASVOODataGridViewTextBoxColumn,
            this.col_prev_pos,
            this.oSVOODataGridViewTextBoxColumn});
            this.dgvVoo.DataMember = "VALOR_OPERACAO_OS";
            this.dgvVoo.DataSource = this.dsVoo;
            this.dgvVoo.Location = new System.Drawing.Point(12, 50);
            this.dgvVoo.Name = "dgvVoo";
            this.dgvVoo.Size = new System.Drawing.Size(632, 534);
            this.dgvVoo.TabIndex = 2;
            // 
            // dsVoo
            // 
            this.dsVoo.DataSetName = "dsVoo";
            this.dsVoo.Namespace = "http://www.tempuri.org/dsVoo.xsd";
            this.dsVoo.Tables.AddRange(new System.Data.DataTable[] {
            this.VALOR_OPERACAO_OS});
            // 
            // VALOR_OPERACAO_OS
            // 
            this.VALOR_OPERACAO_OS.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_VOO,
            this.OPERACAO_VOO,
            this.VALOR_HORA_VOO,
            this.HORAS_PREVISTAS_VOO,
            this.OS_VOO,
            this.dataColumn1});
            this.VALOR_OPERACAO_OS.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_VOO"}, true)});
            this.VALOR_OPERACAO_OS.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_VOO};
            this.VALOR_OPERACAO_OS.TableName = "VALOR_OPERACAO_OS";
            // 
            // COD_VOO
            // 
            this.COD_VOO.AllowDBNull = false;
            this.COD_VOO.ColumnName = "COD_VOO";
            this.COD_VOO.DataType = typeof(int);
            // 
            // OPERACAO_VOO
            // 
            this.OPERACAO_VOO.ColumnName = "OPERACAO_VOO";
            this.OPERACAO_VOO.MaxLength = 200;
            // 
            // VALOR_HORA_VOO
            // 
            this.VALOR_HORA_VOO.ColumnName = "VALOR_HORA_VOO";
            this.VALOR_HORA_VOO.DataType = typeof(double);
            // 
            // HORAS_PREVISTAS_VOO
            // 
            this.HORAS_PREVISTAS_VOO.ColumnName = "HORAS_PREVISTAS_VOO";
            this.HORAS_PREVISTAS_VOO.DataType = typeof(double);
            // 
            // OS_VOO
            // 
            this.OS_VOO.ColumnName = "OS_VOO";
            this.OS_VOO.MaxLength = 50;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(199, 590);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // datVoo
            // 
            this.datVoo.DeleteCommand = this.fbCommand4;
            this.datVoo.InsertCommand = this.fbCommand2;
            this.datVoo.SelectCommand = this.fbCommand1;
            this.datVoo.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * from valor_operacao_os";
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
            // cbVoo
            // 
            this.cbVoo.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbVoo.DataAdapter = this.datVoo;
            this.cbVoo.QuotePrefix = "\"";
            this.cbVoo.QuoteSuffix = "\"";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "HORAS_PREVISTAS_POS_VOO";
            this.dataColumn1.DataType = typeof(double);
            // 
            // cODVOODataGridViewTextBoxColumn
            // 
            this.cODVOODataGridViewTextBoxColumn.DataPropertyName = "COD_VOO";
            this.cODVOODataGridViewTextBoxColumn.HeaderText = "COD_VOO";
            this.cODVOODataGridViewTextBoxColumn.Name = "cODVOODataGridViewTextBoxColumn";
            this.cODVOODataGridViewTextBoxColumn.Visible = false;
            // 
            // oPERACAOVOODataGridViewTextBoxColumn
            // 
            this.oPERACAOVOODataGridViewTextBoxColumn.DataPropertyName = "OPERACAO_VOO";
            this.oPERACAOVOODataGridViewTextBoxColumn.HeaderText = "Operação";
            this.oPERACAOVOODataGridViewTextBoxColumn.Name = "oPERACAOVOODataGridViewTextBoxColumn";
            this.oPERACAOVOODataGridViewTextBoxColumn.Width = 200;
            // 
            // vALORHORAVOODataGridViewTextBoxColumn
            // 
            this.vALORHORAVOODataGridViewTextBoxColumn.DataPropertyName = "VALOR_HORA_VOO";
            this.vALORHORAVOODataGridViewTextBoxColumn.HeaderText = "Valor Hora";
            this.vALORHORAVOODataGridViewTextBoxColumn.Name = "vALORHORAVOODataGridViewTextBoxColumn";
            // 
            // hORASPREVISTASVOODataGridViewTextBoxColumn
            // 
            this.hORASPREVISTASVOODataGridViewTextBoxColumn.DataPropertyName = "HORAS_PREVISTAS_VOO";
            this.hORASPREVISTASVOODataGridViewTextBoxColumn.HeaderText = "Horas Previstas Pré Projeto";
            this.hORASPREVISTASVOODataGridViewTextBoxColumn.Name = "hORASPREVISTASVOODataGridViewTextBoxColumn";
            // 
            // col_prev_pos
            // 
            this.col_prev_pos.DataPropertyName = "HORAS_PREVISTAS_POS_VOO";
            this.col_prev_pos.HeaderText = "Horas Prevista Pós Projeto";
            this.col_prev_pos.Name = "col_prev_pos";
            // 
            // oSVOODataGridViewTextBoxColumn
            // 
            this.oSVOODataGridViewTextBoxColumn.DataPropertyName = "OS_VOO";
            this.oSVOODataGridViewTextBoxColumn.HeaderText = "OS";
            this.oSVOODataGridViewTextBoxColumn.Name = "oSVOODataGridViewTextBoxColumn";
            this.oSVOODataGridViewTextBoxColumn.Visible = false;
            // 
            // form_valor_operacao_os
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 634);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.dgvVoo);
            this.Name = "form_valor_operacao_os";
            this.Text = "Valor Operação OS";
            this.Load += new System.EventHandler(this.form_valor_operacao_os_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVoo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VALOR_OPERACAO_OS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dgvVoo;
        private System.Windows.Forms.Button button1;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datVoo;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Data.DataSet dsVoo;
        private System.Data.DataTable VALOR_OPERACAO_OS;
        private System.Data.DataColumn COD_VOO;
        private System.Data.DataColumn OPERACAO_VOO;
        private System.Data.DataColumn VALOR_HORA_VOO;
        private System.Data.DataColumn HORAS_PREVISTAS_VOO;
        private System.Data.DataColumn OS_VOO;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbVoo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODVOODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPERACAOVOODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORHORAVOODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORASPREVISTASVOODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_prev_pos;
        private System.Windows.Forms.DataGridViewTextBoxColumn oSVOODataGridViewTextBoxColumn;
        private System.Data.DataColumn dataColumn1;
    }
}