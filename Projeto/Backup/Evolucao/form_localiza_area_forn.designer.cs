namespace Evolucao
{
    partial class form_localiza_area_forn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_localiza_area_forn));
            this.tb_localiza = new System.Windows.Forms.TextBox();
            this.dgvArea = new System.Windows.Forms.DataGridView();
            this.dsArea = new System.Data.DataSet();
            this.AREA_ATUACAO_FORN = new System.Data.DataTable();
            this.COD_AREA_FORN = new System.Data.DataColumn();
            this.DESCRICAO_AREA_FORN = new System.Data.DataColumn();
            this.datArea = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.col_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AREA_ATUACAO_FORN)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_localiza
            // 
            this.tb_localiza.Location = new System.Drawing.Point(2, 2);
            this.tb_localiza.Name = "tb_localiza";
            this.tb_localiza.Size = new System.Drawing.Size(244, 20);
            this.tb_localiza.TabIndex = 7;
            this.tb_localiza.TextChanged += new System.EventHandler(this.tb_localiza_TextChanged);
            // 
            // dgvArea
            // 
            this.dgvArea.AllowUserToAddRows = false;
            this.dgvArea.AutoGenerateColumns = false;
            this.dgvArea.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvArea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArea.ColumnHeadersVisible = false;
            this.dgvArea.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_cod,
            this.col_descricao});
            this.dgvArea.DataMember = "AREA_ATUACAO_FORN";
            this.dgvArea.DataSource = this.dsArea;
            this.dgvArea.Location = new System.Drawing.Point(2, 22);
            this.dgvArea.Name = "dgvArea";
            this.dgvArea.ReadOnly = true;
            this.dgvArea.RowHeadersVisible = false;
            this.dgvArea.Size = new System.Drawing.Size(244, 160);
            this.dgvArea.TabIndex = 6;
            this.dgvArea.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArea_CellContentClick);
            // 
            // dsArea
            // 
            this.dsArea.DataSetName = "dsArea";
            this.dsArea.Namespace = "http://www.tempuri.org/dsArea.xsd";
            this.dsArea.Tables.AddRange(new System.Data.DataTable[] {
            this.AREA_ATUACAO_FORN});
            // 
            // AREA_ATUACAO_FORN
            // 
            this.AREA_ATUACAO_FORN.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_AREA_FORN,
            this.DESCRICAO_AREA_FORN});
            this.AREA_ATUACAO_FORN.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_AREA_FORN"}, true)});
            this.AREA_ATUACAO_FORN.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_AREA_FORN};
            this.AREA_ATUACAO_FORN.TableName = "AREA_ATUACAO_FORN";
            // 
            // COD_AREA_FORN
            // 
            this.COD_AREA_FORN.AllowDBNull = false;
            this.COD_AREA_FORN.ColumnName = "COD_AREA_FORN";
            this.COD_AREA_FORN.DataType = typeof(int);
            // 
            // DESCRICAO_AREA_FORN
            // 
            this.DESCRICAO_AREA_FORN.ColumnName = "DESCRICAO_AREA_FORN";
            this.DESCRICAO_AREA_FORN.MaxLength = 50;
            // 
            // datArea
            // 
            this.datArea.DeleteCommand = this.fbCommand4;
            this.datArea.InsertCommand = this.fbCommand2;
            this.datArea.SelectCommand = this.fbCommand1;
            this.datArea.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * from area_atuacao_forn order by descricao_area_forn";
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
            // col_cod
            // 
            this.col_cod.DataPropertyName = "COD_AREA_FORN";
            this.col_cod.HeaderText = "COD_AREA_FORN";
            this.col_cod.Name = "col_cod";
            this.col_cod.ReadOnly = true;
            this.col_cod.Width = 50;
            // 
            // col_descricao
            // 
            this.col_descricao.DataPropertyName = "DESCRICAO_AREA_FORN";
            this.col_descricao.HeaderText = "DESCRICAO_AREA_FORN";
            this.col_descricao.Name = "col_descricao";
            this.col_descricao.ReadOnly = true;
            this.col_descricao.Width = 130;
            // 
            // form_localiza_area_forn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 188);
            this.Controls.Add(this.tb_localiza);
            this.Controls.Add(this.dgvArea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_localiza_area_forn";
            this.Text = "form_localiza_area_forn";
            this.Load += new System.EventHandler(this.form_localiza_area_forn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AREA_ATUACAO_FORN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_localiza;
        private System.Windows.Forms.DataGridView dgvArea;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datArea;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Data.DataSet dsArea;
        private System.Data.DataTable AREA_ATUACAO_FORN;
        private System.Data.DataColumn COD_AREA_FORN;
        private System.Data.DataColumn DESCRICAO_AREA_FORN;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_descricao;
    }
}