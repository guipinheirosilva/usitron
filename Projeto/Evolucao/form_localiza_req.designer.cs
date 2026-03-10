namespace Evolucao
{
    partial class form_localiza_req
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_localiza_req));
            this.tb_localiza = new System.Windows.Forms.TextBox();
            this.dgvRequisicoes = new System.Windows.Forms.DataGridView();
            this.col_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEQUISITANTEREQUISICAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sETORREQUISICAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oBSREQUISICAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAREQUISICAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsRequisicoes = new System.Data.DataSet();
            this.REQUISICOES = new System.Data.DataTable();
            this.COD_REQUISICAO = new System.Data.DataColumn();
            this.REQUISITANTE_REQUISICAO = new System.Data.DataColumn();
            this.SETOR_REQUISICAO = new System.Data.DataColumn();
            this.OBS_REQUISICAO = new System.Data.DataColumn();
            this.DATA_REQUISICAO = new System.Data.DataColumn();
            this.datRequisicoes = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequisicoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRequisicoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.REQUISICOES)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_localiza
            // 
            this.tb_localiza.Location = new System.Drawing.Point(2, 4);
            this.tb_localiza.Name = "tb_localiza";
            this.tb_localiza.Size = new System.Drawing.Size(244, 20);
            this.tb_localiza.TabIndex = 1;
            this.tb_localiza.TextChanged += new System.EventHandler(this.tb_localiza_TextChanged);
            // 
            // dgvRequisicoes
            // 
            this.dgvRequisicoes.AllowUserToAddRows = false;
            this.dgvRequisicoes.AutoGenerateColumns = false;
            this.dgvRequisicoes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRequisicoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequisicoes.ColumnHeadersVisible = false;
            this.dgvRequisicoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_cod,
            this.rEQUISITANTEREQUISICAODataGridViewTextBoxColumn,
            this.sETORREQUISICAODataGridViewTextBoxColumn,
            this.oBSREQUISICAODataGridViewTextBoxColumn,
            this.dATAREQUISICAODataGridViewTextBoxColumn});
            this.dgvRequisicoes.DataMember = "REQUISICOES";
            this.dgvRequisicoes.DataSource = this.dsRequisicoes;
            this.dgvRequisicoes.Location = new System.Drawing.Point(2, 24);
            this.dgvRequisicoes.Name = "dgvRequisicoes";
            this.dgvRequisicoes.ReadOnly = true;
            this.dgvRequisicoes.RowHeadersVisible = false;
            this.dgvRequisicoes.Size = new System.Drawing.Size(244, 160);
            this.dgvRequisicoes.TabIndex = 2;
            this.dgvRequisicoes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRequisicoes_CellContentClick);
            // 
            // col_cod
            // 
            this.col_cod.DataPropertyName = "COD_REQUISICAO";
            this.col_cod.HeaderText = "COD_REQUISICAO";
            this.col_cod.Name = "col_cod";
            this.col_cod.ReadOnly = true;
            this.col_cod.Width = 30;
            // 
            // rEQUISITANTEREQUISICAODataGridViewTextBoxColumn
            // 
            this.rEQUISITANTEREQUISICAODataGridViewTextBoxColumn.DataPropertyName = "REQUISITANTE_REQUISICAO";
            this.rEQUISITANTEREQUISICAODataGridViewTextBoxColumn.HeaderText = "REQUISITANTE_REQUISICAO";
            this.rEQUISITANTEREQUISICAODataGridViewTextBoxColumn.Name = "rEQUISITANTEREQUISICAODataGridViewTextBoxColumn";
            this.rEQUISITANTEREQUISICAODataGridViewTextBoxColumn.ReadOnly = true;
            this.rEQUISITANTEREQUISICAODataGridViewTextBoxColumn.Width = 150;
            // 
            // sETORREQUISICAODataGridViewTextBoxColumn
            // 
            this.sETORREQUISICAODataGridViewTextBoxColumn.DataPropertyName = "SETOR_REQUISICAO";
            this.sETORREQUISICAODataGridViewTextBoxColumn.HeaderText = "SETOR_REQUISICAO";
            this.sETORREQUISICAODataGridViewTextBoxColumn.Name = "sETORREQUISICAODataGridViewTextBoxColumn";
            this.sETORREQUISICAODataGridViewTextBoxColumn.ReadOnly = true;
            this.sETORREQUISICAODataGridViewTextBoxColumn.Visible = false;
            // 
            // oBSREQUISICAODataGridViewTextBoxColumn
            // 
            this.oBSREQUISICAODataGridViewTextBoxColumn.DataPropertyName = "OBS_REQUISICAO";
            this.oBSREQUISICAODataGridViewTextBoxColumn.HeaderText = "OBS_REQUISICAO";
            this.oBSREQUISICAODataGridViewTextBoxColumn.Name = "oBSREQUISICAODataGridViewTextBoxColumn";
            this.oBSREQUISICAODataGridViewTextBoxColumn.ReadOnly = true;
            this.oBSREQUISICAODataGridViewTextBoxColumn.Visible = false;
            // 
            // dATAREQUISICAODataGridViewTextBoxColumn
            // 
            this.dATAREQUISICAODataGridViewTextBoxColumn.DataPropertyName = "DATA_REQUISICAO";
            this.dATAREQUISICAODataGridViewTextBoxColumn.HeaderText = "DATA_REQUISICAO";
            this.dATAREQUISICAODataGridViewTextBoxColumn.Name = "dATAREQUISICAODataGridViewTextBoxColumn";
            this.dATAREQUISICAODataGridViewTextBoxColumn.ReadOnly = true;
            this.dATAREQUISICAODataGridViewTextBoxColumn.Width = 60;
            // 
            // dsRequisicoes
            // 
            this.dsRequisicoes.DataSetName = "dsRequisicoes";
            this.dsRequisicoes.Namespace = "http://www.tempuri.org/dsRequisicoes.xsd";
            this.dsRequisicoes.Tables.AddRange(new System.Data.DataTable[] {
            this.REQUISICOES});
            // 
            // REQUISICOES
            // 
            this.REQUISICOES.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_REQUISICAO,
            this.REQUISITANTE_REQUISICAO,
            this.SETOR_REQUISICAO,
            this.OBS_REQUISICAO,
            this.DATA_REQUISICAO});
            this.REQUISICOES.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_REQUISICAO"}, true)});
            this.REQUISICOES.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_REQUISICAO};
            this.REQUISICOES.TableName = "REQUISICOES";
            // 
            // COD_REQUISICAO
            // 
            this.COD_REQUISICAO.AllowDBNull = false;
            this.COD_REQUISICAO.ColumnName = "COD_REQUISICAO";
            this.COD_REQUISICAO.DataType = typeof(int);
            // 
            // REQUISITANTE_REQUISICAO
            // 
            this.REQUISITANTE_REQUISICAO.ColumnName = "REQUISITANTE_REQUISICAO";
            this.REQUISITANTE_REQUISICAO.MaxLength = 200;
            // 
            // SETOR_REQUISICAO
            // 
            this.SETOR_REQUISICAO.ColumnName = "SETOR_REQUISICAO";
            this.SETOR_REQUISICAO.MaxLength = 200;
            // 
            // OBS_REQUISICAO
            // 
            this.OBS_REQUISICAO.ColumnName = "OBS_REQUISICAO";
            this.OBS_REQUISICAO.MaxLength = 250;
            // 
            // DATA_REQUISICAO
            // 
            this.DATA_REQUISICAO.ColumnName = "DATA_REQUISICAO";
            this.DATA_REQUISICAO.DataType = typeof(System.DateTime);
            // 
            // datRequisicoes
            // 
            this.datRequisicoes.DeleteCommand = this.fbCommand4;
            this.datRequisicoes.InsertCommand = this.fbCommand2;
            this.datRequisicoes.SelectCommand = this.fbCommand1;
            this.datRequisicoes.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * from requisicoes order by cod_requisicao desc";
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
            // form_localiza_req
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 190);
            this.Controls.Add(this.tb_localiza);
            this.Controls.Add(this.dgvRequisicoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "form_localiza_req";
            this.Text = "Localiza";
            this.Load += new System.EventHandler(this.form_localiza_req_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequisicoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRequisicoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.REQUISICOES)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_localiza;
        private System.Windows.Forms.DataGridView dgvRequisicoes;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datRequisicoes;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Data.DataSet dsRequisicoes;
        private System.Data.DataTable REQUISICOES;
        private System.Data.DataColumn COD_REQUISICAO;
        private System.Data.DataColumn REQUISITANTE_REQUISICAO;
        private System.Data.DataColumn SETOR_REQUISICAO;
        private System.Data.DataColumn OBS_REQUISICAO;
        private System.Data.DataColumn DATA_REQUISICAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEQUISITANTEREQUISICAODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sETORREQUISICAODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oBSREQUISICAODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAREQUISICAODataGridViewTextBoxColumn;
    }
}