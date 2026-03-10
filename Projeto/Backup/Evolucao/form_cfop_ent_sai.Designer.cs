namespace Evolucao
{
    partial class form_cfop_ent_sai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_cfop_ent_sai));
            this.datCfop_ent_sai = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.dgvCfop_ent_sai = new System.Windows.Forms.DataGridView();
            this.dsCfop_ent_sai = new System.Data.DataSet();
            this.CFOP_ENT_SAI = new System.Data.DataTable();
            this.COD_CFOP_ENT_SAI = new System.Data.DataColumn();
            this.CFOP_ENT = new System.Data.DataColumn();
            this.CFOP_SAI_DE = new System.Data.DataColumn();
            this.CFOP_SAI_FE = new System.Data.DataColumn();
            this.cODCFOPENTSAIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFOPENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFOPSAIDEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFOPSAIFEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.cbCfop_ent_sai = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCfop_ent_sai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCfop_ent_sai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CFOP_ENT_SAI)).BeginInit();
            this.SuspendLayout();
            // 
            // datCfop_ent_sai
            // 
            this.datCfop_ent_sai.DeleteCommand = this.fbCommand4;
            this.datCfop_ent_sai.InsertCommand = this.fbCommand2;
            this.datCfop_ent_sai.SelectCommand = this.fbCommand1;
            this.datCfop_ent_sai.UpdateCommand = this.fbCommand3;
            // 
            // fbCommand1
            // 
            this.fbCommand1.CommandText = "select * from cfop_ent_sai";
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
            // dgvCfop_ent_sai
            // 
            this.dgvCfop_ent_sai.AutoGenerateColumns = false;
            this.dgvCfop_ent_sai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCfop_ent_sai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODCFOPENTSAIDataGridViewTextBoxColumn,
            this.cFOPENTDataGridViewTextBoxColumn,
            this.cFOPSAIDEDataGridViewTextBoxColumn,
            this.cFOPSAIFEDataGridViewTextBoxColumn});
            this.dgvCfop_ent_sai.DataMember = "CFOP_ENT_SAI";
            this.dgvCfop_ent_sai.DataSource = this.dsCfop_ent_sai;
            this.dgvCfop_ent_sai.Location = new System.Drawing.Point(12, 12);
            this.dgvCfop_ent_sai.Name = "dgvCfop_ent_sai";
            this.dgvCfop_ent_sai.Size = new System.Drawing.Size(417, 238);
            this.dgvCfop_ent_sai.TabIndex = 0;
            // 
            // dsCfop_ent_sai
            // 
            this.dsCfop_ent_sai.DataSetName = "dsCfop_ent_sai";
            this.dsCfop_ent_sai.Namespace = "http://www.tempuri.org/dsCfop_ent_sai.xsd";
            this.dsCfop_ent_sai.Tables.AddRange(new System.Data.DataTable[] {
            this.CFOP_ENT_SAI});
            // 
            // CFOP_ENT_SAI
            // 
            this.CFOP_ENT_SAI.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_CFOP_ENT_SAI,
            this.CFOP_ENT,
            this.CFOP_SAI_DE,
            this.CFOP_SAI_FE});
            this.CFOP_ENT_SAI.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_CFOP_ENT_SAI"}, true)});
            this.CFOP_ENT_SAI.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_CFOP_ENT_SAI};
            this.CFOP_ENT_SAI.TableName = "CFOP_ENT_SAI";
            // 
            // COD_CFOP_ENT_SAI
            // 
            this.COD_CFOP_ENT_SAI.AllowDBNull = false;
            this.COD_CFOP_ENT_SAI.AutoIncrement = true;
            this.COD_CFOP_ENT_SAI.AutoIncrementSeed = ((long)(1));
            this.COD_CFOP_ENT_SAI.ColumnName = "COD_CFOP_ENT_SAI";
            this.COD_CFOP_ENT_SAI.DataType = typeof(int);
            // 
            // CFOP_ENT
            // 
            this.CFOP_ENT.ColumnName = "CFOP_ENT";
            this.CFOP_ENT.MaxLength = 10;
            // 
            // CFOP_SAI_DE
            // 
            this.CFOP_SAI_DE.ColumnName = "CFOP_SAI_DE";
            this.CFOP_SAI_DE.MaxLength = 10;
            // 
            // CFOP_SAI_FE
            // 
            this.CFOP_SAI_FE.ColumnName = "CFOP_SAI_FE";
            this.CFOP_SAI_FE.MaxLength = 10;
            // 
            // cODCFOPENTSAIDataGridViewTextBoxColumn
            // 
            this.cODCFOPENTSAIDataGridViewTextBoxColumn.DataPropertyName = "COD_CFOP_ENT_SAI";
            this.cODCFOPENTSAIDataGridViewTextBoxColumn.HeaderText = "Cód.";
            this.cODCFOPENTSAIDataGridViewTextBoxColumn.Name = "cODCFOPENTSAIDataGridViewTextBoxColumn";
            this.cODCFOPENTSAIDataGridViewTextBoxColumn.Width = 50;
            // 
            // cFOPENTDataGridViewTextBoxColumn
            // 
            this.cFOPENTDataGridViewTextBoxColumn.DataPropertyName = "CFOP_ENT";
            this.cFOPENTDataGridViewTextBoxColumn.HeaderText = "CFOP Entrada";
            this.cFOPENTDataGridViewTextBoxColumn.Name = "cFOPENTDataGridViewTextBoxColumn";
            // 
            // cFOPSAIDEDataGridViewTextBoxColumn
            // 
            this.cFOPSAIDEDataGridViewTextBoxColumn.DataPropertyName = "CFOP_SAI_DE";
            this.cFOPSAIDEDataGridViewTextBoxColumn.HeaderText = "CFOP Saída Estado";
            this.cFOPSAIDEDataGridViewTextBoxColumn.Name = "cFOPSAIDEDataGridViewTextBoxColumn";
            // 
            // cFOPSAIFEDataGridViewTextBoxColumn
            // 
            this.cFOPSAIFEDataGridViewTextBoxColumn.DataPropertyName = "CFOP_SAI_FE";
            this.cFOPSAIFEDataGridViewTextBoxColumn.HeaderText = "CFOP Saída Fora Estado";
            this.cFOPSAIFEDataGridViewTextBoxColumn.Name = "cFOPSAIFEDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(184, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbCfop_ent_sai
            // 
            this.cbCfop_ent_sai.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbCfop_ent_sai.DataAdapter = this.datCfop_ent_sai;
            this.cbCfop_ent_sai.QuotePrefix = "\"";
            this.cbCfop_ent_sai.QuoteSuffix = "\"";
            // 
            // form_cfop_ent_sai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 299);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvCfop_ent_sai);
            this.Name = "form_cfop_ent_sai";
            this.Text = "CFOP ENTRADA SAIDA";
            this.Load += new System.EventHandler(this.form_cfop_ent_sai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCfop_ent_sai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCfop_ent_sai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CFOP_ENT_SAI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datCfop_ent_sai;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Windows.Forms.DataGridView dgvCfop_ent_sai;
        private System.Data.DataSet dsCfop_ent_sai;
        private System.Data.DataTable CFOP_ENT_SAI;
        private System.Data.DataColumn COD_CFOP_ENT_SAI;
        private System.Data.DataColumn CFOP_ENT;
        private System.Data.DataColumn CFOP_SAI_DE;
        private System.Data.DataColumn CFOP_SAI_FE;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODCFOPENTSAIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFOPENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFOPSAIDEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFOPSAIFEDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbCfop_ent_sai;
    }
}