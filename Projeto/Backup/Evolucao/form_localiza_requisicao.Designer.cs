namespace Evolucao
{
    partial class form_localiza_requisicao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_localiza_requisicao));
            this.tb_localiza = new System.Windows.Forms.TextBox();
            this.dgvRequisicao = new System.Windows.Forms.DataGridView();
            this.datRequisicao = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.dsRequisicao = new System.Data.DataSet();
            this.REQUISICAO = new System.Data.DataTable();
            this.COD_REQUISICAO = new System.Data.DataColumn();
            this.REQUISITANTE_REQUISICAO = new System.Data.DataColumn();
            this.SETOR_REQUISICAO = new System.Data.DataColumn();
            this.OBS_REQUISICAO = new System.Data.DataColumn();
            this.DATA_REQUISICAO = new System.Data.DataColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cODREQUISICAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEQUISITANTEREQUISICAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sETORREQUISICAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oBSREQUISICAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAREQUISICAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequisicao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRequisicao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.REQUISICAO)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_localiza
            // 
            this.tb_localiza.Location = new System.Drawing.Point(5, 2);
            this.tb_localiza.Name = "tb_localiza";
            this.tb_localiza.Size = new System.Drawing.Size(244, 20);
            this.tb_localiza.TabIndex = 3;
            this.tb_localiza.TextChanged += new System.EventHandler(this.tb_localiza_TextChanged);
            // 
            // dgvRequisicao
            // 
            this.dgvRequisicao.AllowUserToAddRows = false;
            this.dgvRequisicao.AutoGenerateColumns = false;
            this.dgvRequisicao.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRequisicao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequisicao.ColumnHeadersVisible = false;
            this.dgvRequisicao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODREQUISICAODataGridViewTextBoxColumn,
            this.rEQUISITANTEREQUISICAODataGridViewTextBoxColumn,
            this.sETORREQUISICAODataGridViewTextBoxColumn,
            this.oBSREQUISICAODataGridViewTextBoxColumn,
            this.dATAREQUISICAODataGridViewTextBoxColumn});
            this.dgvRequisicao.DataMember = "REQUISICAO";
            this.dgvRequisicao.DataSource = this.dsRequisicao;
            this.dgvRequisicao.Location = new System.Drawing.Point(5, 22);
            this.dgvRequisicao.Name = "dgvRequisicao";
            this.dgvRequisicao.ReadOnly = true;
            this.dgvRequisicao.RowHeadersVisible = false;
            this.dgvRequisicao.Size = new System.Drawing.Size(417, 160);
            this.dgvRequisicao.TabIndex = 2;
            this.dgvRequisicao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRequisicao_CellContentClick);
            // 
            // datRequisicao
            // 
            this.datRequisicao.DeleteCommand = this.fbCommand4;
            this.datRequisicao.InsertCommand = this.fbCommand2;
            this.datRequisicao.SelectCommand = this.fbCommand1;
            this.datRequisicao.UpdateCommand = this.fbCommand3;
            // 
            // fbCommand1
            // 
            this.fbCommand1.CommandText = "select * from requisicao order by cod_requisicao desc";
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
            // dsRequisicao
            // 
            this.dsRequisicao.DataSetName = "dsRequisicao";
            this.dsRequisicao.Namespace = "http://www.tempuri.org/dsRequisicao.xsd";
            this.dsRequisicao.Tables.AddRange(new System.Data.DataTable[] {
            this.REQUISICAO});
            // 
            // REQUISICAO
            // 
            this.REQUISICAO.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_REQUISICAO,
            this.REQUISITANTE_REQUISICAO,
            this.SETOR_REQUISICAO,
            this.OBS_REQUISICAO,
            this.DATA_REQUISICAO});
            this.REQUISICAO.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_REQUISICAO"}, true)});
            this.REQUISICAO.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_REQUISICAO};
            this.REQUISICAO.TableName = "REQUISICAO";
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
            this.REQUISITANTE_REQUISICAO.MaxLength = 50;
            // 
            // SETOR_REQUISICAO
            // 
            this.SETOR_REQUISICAO.ColumnName = "SETOR_REQUISICAO";
            this.SETOR_REQUISICAO.MaxLength = 50;
            // 
            // OBS_REQUISICAO
            // 
            this.OBS_REQUISICAO.ColumnName = "OBS_REQUISICAO";
            this.OBS_REQUISICAO.MaxLength = 100;
            // 
            // DATA_REQUISICAO
            // 
            this.DATA_REQUISICAO.ColumnName = "DATA_REQUISICAO";
            this.DATA_REQUISICAO.DataType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Digite o nome do requisitante";
            // 
            // cODREQUISICAODataGridViewTextBoxColumn
            // 
            this.cODREQUISICAODataGridViewTextBoxColumn.DataPropertyName = "COD_REQUISICAO";
            this.cODREQUISICAODataGridViewTextBoxColumn.HeaderText = "COD_REQUISICAO";
            this.cODREQUISICAODataGridViewTextBoxColumn.Name = "cODREQUISICAODataGridViewTextBoxColumn";
            this.cODREQUISICAODataGridViewTextBoxColumn.ReadOnly = true;
            this.cODREQUISICAODataGridViewTextBoxColumn.Width = 50;
            // 
            // rEQUISITANTEREQUISICAODataGridViewTextBoxColumn
            // 
            this.rEQUISITANTEREQUISICAODataGridViewTextBoxColumn.DataPropertyName = "REQUISITANTE_REQUISICAO";
            this.rEQUISITANTEREQUISICAODataGridViewTextBoxColumn.HeaderText = "REQUISITANTE_REQUISICAO";
            this.rEQUISITANTEREQUISICAODataGridViewTextBoxColumn.Name = "rEQUISITANTEREQUISICAODataGridViewTextBoxColumn";
            this.rEQUISITANTEREQUISICAODataGridViewTextBoxColumn.ReadOnly = true;
            this.rEQUISITANTEREQUISICAODataGridViewTextBoxColumn.Width = 200;
            // 
            // sETORREQUISICAODataGridViewTextBoxColumn
            // 
            this.sETORREQUISICAODataGridViewTextBoxColumn.DataPropertyName = "SETOR_REQUISICAO";
            this.sETORREQUISICAODataGridViewTextBoxColumn.HeaderText = "SETOR_REQUISICAO";
            this.sETORREQUISICAODataGridViewTextBoxColumn.Name = "sETORREQUISICAODataGridViewTextBoxColumn";
            this.sETORREQUISICAODataGridViewTextBoxColumn.ReadOnly = true;
            this.sETORREQUISICAODataGridViewTextBoxColumn.Width = 80;
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
            this.dATAREQUISICAODataGridViewTextBoxColumn.Width = 80;
            // 
            // form_localiza_requisicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 186);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_localiza);
            this.Controls.Add(this.dgvRequisicao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_localiza_requisicao";
            this.Text = "form_localiza_requisicao";
            this.Load += new System.EventHandler(this.form_localiza_requisicao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequisicao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRequisicao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.REQUISICAO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_localiza;
        private System.Windows.Forms.DataGridView dgvRequisicao;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datRequisicao;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Data.DataSet dsRequisicao;
        private System.Data.DataTable REQUISICAO;
        private System.Data.DataColumn COD_REQUISICAO;
        private System.Data.DataColumn REQUISITANTE_REQUISICAO;
        private System.Data.DataColumn SETOR_REQUISICAO;
        private System.Data.DataColumn OBS_REQUISICAO;
        private System.Data.DataColumn DATA_REQUISICAO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODREQUISICAODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEQUISITANTEREQUISICAODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sETORREQUISICAODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oBSREQUISICAODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAREQUISICAODataGridViewTextBoxColumn;
    }
}