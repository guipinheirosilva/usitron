namespace Evolucao
{
    partial class form_localiza_cfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_localiza_cfo));
            this.dgvCfo = new System.Windows.Forms.DataGridView();
            this.cODSISTEMACFODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_n_cfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_obs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsCfo = new System.Data.DataSet();
            this.CFO = new System.Data.DataTable();
            this.COD_SISTEMA_CFO = new System.Data.DataColumn();
            this.N_CFO = new System.Data.DataColumn();
            this.DESCRICAO_CFO = new System.Data.DataColumn();
            this.OBSERVACAO_CFO = new System.Data.DataColumn();
            this.tb_localiza = new System.Windows.Forms.TextBox();
            this.datCfo = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CFO)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCfo
            // 
            this.dgvCfo.AllowUserToAddRows = false;
            this.dgvCfo.AutoGenerateColumns = false;
            this.dgvCfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCfo.ColumnHeadersVisible = false;
            this.dgvCfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODSISTEMACFODataGridViewTextBoxColumn,
            this.col_n_cfo,
            this.col_descricao,
            this.col_obs});
            this.dgvCfo.DataMember = "CFO";
            this.dgvCfo.DataSource = this.dsCfo;
            this.dgvCfo.Location = new System.Drawing.Point(0, 21);
            this.dgvCfo.Name = "dgvCfo";
            this.dgvCfo.ReadOnly = true;
            this.dgvCfo.RowHeadersVisible = false;
            this.dgvCfo.Size = new System.Drawing.Size(417, 160);
            this.dgvCfo.TabIndex = 0;
            this.dgvCfo.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCfo_CellContentDoubleClick);
            this.dgvCfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCfo_CellContentClick);
            // 
            // cODSISTEMACFODataGridViewTextBoxColumn
            // 
            this.cODSISTEMACFODataGridViewTextBoxColumn.DataPropertyName = "COD_SISTEMA_CFO";
            this.cODSISTEMACFODataGridViewTextBoxColumn.HeaderText = "COD_SISTEMA_CFO";
            this.cODSISTEMACFODataGridViewTextBoxColumn.Name = "cODSISTEMACFODataGridViewTextBoxColumn";
            this.cODSISTEMACFODataGridViewTextBoxColumn.ReadOnly = true;
            this.cODSISTEMACFODataGridViewTextBoxColumn.Visible = false;
            // 
            // col_n_cfo
            // 
            this.col_n_cfo.DataPropertyName = "N_CFO";
            this.col_n_cfo.HeaderText = "N_CFO";
            this.col_n_cfo.Name = "col_n_cfo";
            this.col_n_cfo.ReadOnly = true;
            this.col_n_cfo.Width = 60;
            // 
            // col_descricao
            // 
            this.col_descricao.DataPropertyName = "DESCRICAO_CFO";
            this.col_descricao.HeaderText = "DESCRICAO_CFO";
            this.col_descricao.Name = "col_descricao";
            this.col_descricao.ReadOnly = true;
            // 
            // col_obs
            // 
            this.col_obs.DataPropertyName = "OBSERVACAO_CFO";
            this.col_obs.HeaderText = "OBSERVACAO_CFO";
            this.col_obs.Name = "col_obs";
            this.col_obs.ReadOnly = true;
            this.col_obs.Width = 250;
            // 
            // dsCfo
            // 
            this.dsCfo.DataSetName = "dsCfo";
            this.dsCfo.Namespace = "http://www.tempuri.org/dsCfo.xsd";
            this.dsCfo.Tables.AddRange(new System.Data.DataTable[] {
            this.CFO});
            // 
            // CFO
            // 
            this.CFO.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_SISTEMA_CFO,
            this.N_CFO,
            this.DESCRICAO_CFO,
            this.OBSERVACAO_CFO});
            this.CFO.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_SISTEMA_CFO"}, true)});
            this.CFO.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_SISTEMA_CFO};
            this.CFO.TableName = "CFO";
            // 
            // COD_SISTEMA_CFO
            // 
            this.COD_SISTEMA_CFO.AllowDBNull = false;
            this.COD_SISTEMA_CFO.ColumnName = "COD_SISTEMA_CFO";
            this.COD_SISTEMA_CFO.DataType = typeof(int);
            // 
            // N_CFO
            // 
            this.N_CFO.ColumnName = "N_CFO";
            this.N_CFO.DataType = typeof(int);
            // 
            // DESCRICAO_CFO
            // 
            this.DESCRICAO_CFO.ColumnName = "DESCRICAO_CFO";
            this.DESCRICAO_CFO.MaxLength = 80;
            // 
            // OBSERVACAO_CFO
            // 
            this.OBSERVACAO_CFO.ColumnName = "OBSERVACAO_CFO";
            this.OBSERVACAO_CFO.MaxLength = 250;
            // 
            // tb_localiza
            // 
            this.tb_localiza.Location = new System.Drawing.Point(0, 1);
            this.tb_localiza.Name = "tb_localiza";
            this.tb_localiza.Size = new System.Drawing.Size(244, 20);
            this.tb_localiza.TabIndex = 1;
            this.tb_localiza.TextChanged += new System.EventHandler(this.tb_cfo_TextChanged);
            // 
            // datCfo
            // 
            this.datCfo.DeleteCommand = this.fbCommand4;
            this.datCfo.InsertCommand = this.fbCommand2;
            this.datCfo.SelectCommand = this.fbCommand1;
            this.datCfo.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * from cfo order by n_cfo";
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
            // form_localiza_cfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 182);
            this.Controls.Add(this.tb_localiza);
            this.Controls.Add(this.dgvCfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "form_localiza_cfo";
            this.Text = "CFOP";
            this.Load += new System.EventHandler(this.form_localiza_cfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CFO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCfo;
        private System.Windows.Forms.TextBox tb_localiza;
        private System.Data.DataSet dsCfo;
        private System.Data.DataTable CFO;
        private System.Data.DataColumn COD_SISTEMA_CFO;
        private System.Data.DataColumn N_CFO;
        private System.Data.DataColumn DESCRICAO_CFO;
        private System.Data.DataColumn OBSERVACAO_CFO;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datCfo;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODSISTEMACFODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_n_cfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_obs;
    }
}