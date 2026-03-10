namespace Evolucao
{
    partial class form_cc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_cc));
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dgvCc = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.cbCc = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.AGENCIA_CC = new System.Data.DataColumn();
            this.BANCO_CC = new System.Data.DataColumn();
            this.DESCRICAO_CC = new System.Data.DataColumn();
            this.COD_CC = new System.Data.DataColumn();
            this.CONTAS_CORRENTES = new System.Data.DataTable();
            this.dsCc = new System.Data.DataSet();
            this.aGENCIACCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bANCOCCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datCc = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CONTAS_CORRENTES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCc)).BeginInit();
            this.SuspendLayout();
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
            this.fbCommand1.CommandText = "select * from contas_correntes";
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
            // dgvCc
            // 
            this.dgvCc.AutoGenerateColumns = false;
            this.dgvCc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_cod,
            this.col_descricao,
            this.bANCOCCDataGridViewTextBoxColumn,
            this.aGENCIACCDataGridViewTextBoxColumn});
            this.dgvCc.DataMember = "CONTAS_CORRENTES";
            this.dgvCc.DataSource = this.dsCc;
            this.dgvCc.Location = new System.Drawing.Point(12, 12);
            this.dgvCc.Name = "dgvCc";
            this.dgvCc.Size = new System.Drawing.Size(367, 373);
            this.dgvCc.TabIndex = 0;
            this.dgvCc.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarteiras_CellDoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbCc
            // 
            this.cbCc.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbCc.DataAdapter = this.datCc;
            this.cbCc.QuotePrefix = "\"";
            this.cbCc.QuoteSuffix = "\"";
            // 
            // AGENCIA_CC
            // 
            this.AGENCIA_CC.ColumnName = "AGENCIA_CC";
            this.AGENCIA_CC.MaxLength = 200;
            // 
            // BANCO_CC
            // 
            this.BANCO_CC.ColumnName = "BANCO_CC";
            this.BANCO_CC.MaxLength = 200;
            // 
            // DESCRICAO_CC
            // 
            this.DESCRICAO_CC.ColumnName = "DESCRICAO_CC";
            this.DESCRICAO_CC.MaxLength = 200;
            // 
            // COD_CC
            // 
            this.COD_CC.AllowDBNull = false;
            this.COD_CC.AutoIncrement = true;
            this.COD_CC.ColumnName = "COD_CC";
            this.COD_CC.DataType = typeof(int);
            // 
            // CONTAS_CORRENTES
            // 
            this.CONTAS_CORRENTES.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_CC,
            this.DESCRICAO_CC,
            this.BANCO_CC,
            this.AGENCIA_CC});
            this.CONTAS_CORRENTES.TableName = "CONTAS_CORRENTES";
            // 
            // dsCc
            // 
            this.dsCc.DataSetName = "dsCc";
            this.dsCc.Namespace = "http://www.tempuri.org/dsCc.xsd";
            this.dsCc.Tables.AddRange(new System.Data.DataTable[] {
            this.CONTAS_CORRENTES});
            // 
            // aGENCIACCDataGridViewTextBoxColumn
            // 
            this.aGENCIACCDataGridViewTextBoxColumn.DataPropertyName = "AGENCIA_CC";
            this.aGENCIACCDataGridViewTextBoxColumn.HeaderText = "Agência";
            this.aGENCIACCDataGridViewTextBoxColumn.Name = "aGENCIACCDataGridViewTextBoxColumn";
            // 
            // bANCOCCDataGridViewTextBoxColumn
            // 
            this.bANCOCCDataGridViewTextBoxColumn.DataPropertyName = "BANCO_CC";
            this.bANCOCCDataGridViewTextBoxColumn.HeaderText = "Banco";
            this.bANCOCCDataGridViewTextBoxColumn.Name = "bANCOCCDataGridViewTextBoxColumn";
            // 
            // col_descricao
            // 
            this.col_descricao.DataPropertyName = "DESCRICAO_CC";
            this.col_descricao.HeaderText = "Descrição";
            this.col_descricao.Name = "col_descricao";
            this.col_descricao.Width = 150;
            // 
            // col_cod
            // 
            this.col_cod.DataPropertyName = "COD_CC";
            this.col_cod.HeaderText = "Cód.";
            this.col_cod.Name = "col_cod";
            this.col_cod.Width = 30;
            // 
            // datCc
            // 
            this.datCc.DeleteCommand = this.fbCommand4;
            this.datCc.InsertCommand = this.fbCommand2;
            this.datCc.SelectCommand = this.fbCommand1;
            this.datCc.UpdateCommand = this.fbCommand3;
            // 
            // form_cc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 448);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvCc);
            this.Name = "form_cc";
            this.Text = "Contas Correntes";
            this.Load += new System.EventHandler(this.form_carteiras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CONTAS_CORRENTES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Windows.Forms.DataGridView dgvCc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn bANCOCCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aGENCIACCDataGridViewTextBoxColumn;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbCc;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datCc;
        private System.Data.DataColumn AGENCIA_CC;
        private System.Data.DataColumn BANCO_CC;
        private System.Data.DataColumn DESCRICAO_CC;
        private System.Data.DataColumn COD_CC;
        private System.Data.DataTable CONTAS_CORRENTES;
        private System.Data.DataSet dsCc;
    }
}