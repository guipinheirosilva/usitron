namespace Evolucao
{
    partial class form_camara_quente_bico
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_camara_quente_bico));
            this.tb_valor_bq = new System.Windows.Forms.TextBox();
            this.dsBicoQuente = new System.Data.DataSet();
            this.BICO_QUENTE = new System.Data.DataTable();
            this.COD_BICO_QUENTE = new System.Data.DataColumn();
            this.VALOR_BICO_QUENTE = new System.Data.DataColumn();
            this.label60 = new System.Windows.Forms.Label();
            this.dgvCamara_quente = new System.Windows.Forms.DataGridView();
            this.cODCAMERAQUENTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIMENSAOCAMERAQUENTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORCAMERAQUENTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsCamaraQuente = new System.Data.DataSet();
            this.CAMERA_QUENTE = new System.Data.DataTable();
            this.COD_CAMERA_QUENTE = new System.Data.DataColumn();
            this.DIMENSAO_CAMERA_QUENTE = new System.Data.DataColumn();
            this.VALOR_CAMERA_QUENTE = new System.Data.DataColumn();
            this.datBicoQuente = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.datCameraQuente = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand8 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand6 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand5 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand7 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.cbCamaraQuente = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.cbBicoQuente = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            ((System.ComponentModel.ISupportInitialize)(this.dsBicoQuente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BICO_QUENTE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCamara_quente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCamaraQuente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CAMERA_QUENTE)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_valor_bq
            // 
            this.tb_valor_bq.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsBicoQuente, "BICO_QUENTE.VALOR_BICO_QUENTE", true));
            this.tb_valor_bq.Location = new System.Drawing.Point(89, 42);
            this.tb_valor_bq.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_valor_bq.Name = "tb_valor_bq";
            this.tb_valor_bq.Size = new System.Drawing.Size(87, 22);
            this.tb_valor_bq.TabIndex = 4;
            // 
            // dsBicoQuente
            // 
            this.dsBicoQuente.DataSetName = "dsBicoQuente";
            this.dsBicoQuente.Namespace = "http://www.tempuri.org/dsBicoQuente.xsd";
            this.dsBicoQuente.Tables.AddRange(new System.Data.DataTable[] {
            this.BICO_QUENTE});
            // 
            // BICO_QUENTE
            // 
            this.BICO_QUENTE.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_BICO_QUENTE,
            this.VALOR_BICO_QUENTE});
            this.BICO_QUENTE.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_BICO_QUENTE"}, true)});
            this.BICO_QUENTE.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_BICO_QUENTE};
            this.BICO_QUENTE.TableName = "BICO_QUENTE";
            // 
            // COD_BICO_QUENTE
            // 
            this.COD_BICO_QUENTE.AllowDBNull = false;
            this.COD_BICO_QUENTE.ColumnName = "COD_BICO_QUENTE";
            this.COD_BICO_QUENTE.DataType = typeof(int);
            // 
            // VALOR_BICO_QUENTE
            // 
            this.VALOR_BICO_QUENTE.ColumnName = "VALOR_BICO_QUENTE";
            this.VALOR_BICO_QUENTE.DataType = typeof(double);
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(33, 46);
            this.label60.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(49, 17);
            this.label60.TabIndex = 1;
            this.label60.Text = "Valor :";
            // 
            // dgvCamara_quente
            // 
            this.dgvCamara_quente.AutoGenerateColumns = false;
            this.dgvCamara_quente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCamara_quente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODCAMERAQUENTEDataGridViewTextBoxColumn,
            this.dIMENSAOCAMERAQUENTEDataGridViewTextBoxColumn,
            this.vALORCAMERAQUENTEDataGridViewTextBoxColumn});
            this.dgvCamara_quente.DataMember = "CAMERA_QUENTE";
            this.dgvCamara_quente.DataSource = this.dsCamaraQuente;
            this.dgvCamara_quente.Location = new System.Drawing.Point(8, 37);
            this.dgvCamara_quente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvCamara_quente.Name = "dgvCamara_quente";
            this.dgvCamara_quente.Size = new System.Drawing.Size(352, 231);
            this.dgvCamara_quente.TabIndex = 314;
            // 
            // cODCAMERAQUENTEDataGridViewTextBoxColumn
            // 
            this.cODCAMERAQUENTEDataGridViewTextBoxColumn.DataPropertyName = "COD_CAMERA_QUENTE";
            this.cODCAMERAQUENTEDataGridViewTextBoxColumn.HeaderText = "Cod.";
            this.cODCAMERAQUENTEDataGridViewTextBoxColumn.Name = "cODCAMERAQUENTEDataGridViewTextBoxColumn";
            this.cODCAMERAQUENTEDataGridViewTextBoxColumn.ReadOnly = true;
            this.cODCAMERAQUENTEDataGridViewTextBoxColumn.Width = 40;
            // 
            // dIMENSAOCAMERAQUENTEDataGridViewTextBoxColumn
            // 
            this.dIMENSAOCAMERAQUENTEDataGridViewTextBoxColumn.DataPropertyName = "DIMENSAO_CAMERA_QUENTE";
            this.dIMENSAOCAMERAQUENTEDataGridViewTextBoxColumn.HeaderText = "Dimensão";
            this.dIMENSAOCAMERAQUENTEDataGridViewTextBoxColumn.Name = "dIMENSAOCAMERAQUENTEDataGridViewTextBoxColumn";
            this.dIMENSAOCAMERAQUENTEDataGridViewTextBoxColumn.Width = 75;
            // 
            // vALORCAMERAQUENTEDataGridViewTextBoxColumn
            // 
            this.vALORCAMERAQUENTEDataGridViewTextBoxColumn.DataPropertyName = "VALOR_CAMERA_QUENTE";
            dataGridViewCellStyle1.Format = "N2";
            this.vALORCAMERAQUENTEDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.vALORCAMERAQUENTEDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.vALORCAMERAQUENTEDataGridViewTextBoxColumn.Name = "vALORCAMERAQUENTEDataGridViewTextBoxColumn";
            // 
            // dsCamaraQuente
            // 
            this.dsCamaraQuente.DataSetName = "dsCamaraQuente";
            this.dsCamaraQuente.Namespace = "http://www.tempuri.org/dsCamaraQuente.xsd";
            this.dsCamaraQuente.Tables.AddRange(new System.Data.DataTable[] {
            this.CAMERA_QUENTE});
            // 
            // CAMERA_QUENTE
            // 
            this.CAMERA_QUENTE.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_CAMERA_QUENTE,
            this.DIMENSAO_CAMERA_QUENTE,
            this.VALOR_CAMERA_QUENTE});
            this.CAMERA_QUENTE.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_CAMERA_QUENTE"}, true)});
            this.CAMERA_QUENTE.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_CAMERA_QUENTE};
            this.CAMERA_QUENTE.TableName = "CAMERA_QUENTE";
            // 
            // COD_CAMERA_QUENTE
            // 
            this.COD_CAMERA_QUENTE.AllowDBNull = false;
            this.COD_CAMERA_QUENTE.AutoIncrement = true;
            this.COD_CAMERA_QUENTE.ColumnName = "COD_CAMERA_QUENTE";
            this.COD_CAMERA_QUENTE.DataType = typeof(int);
            // 
            // DIMENSAO_CAMERA_QUENTE
            // 
            this.DIMENSAO_CAMERA_QUENTE.ColumnName = "DIMENSAO_CAMERA_QUENTE";
            this.DIMENSAO_CAMERA_QUENTE.DataType = typeof(double);
            // 
            // VALOR_CAMERA_QUENTE
            // 
            this.VALOR_CAMERA_QUENTE.ColumnName = "VALOR_CAMERA_QUENTE";
            this.VALOR_CAMERA_QUENTE.DataType = typeof(double);
            // 
            // datBicoQuente
            // 
            this.datBicoQuente.DeleteCommand = this.fbCommand4;
            this.datBicoQuente.InsertCommand = this.fbCommand2;
            this.datBicoQuente.SelectCommand = this.fbCommand1;
            this.datBicoQuente.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "SELECT * FROM BICO_QUENTE";
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
            // datCameraQuente
            // 
            this.datCameraQuente.DeleteCommand = this.fbCommand8;
            this.datCameraQuente.InsertCommand = this.fbCommand6;
            this.datCameraQuente.SelectCommand = this.fbCommand5;
            this.datCameraQuente.UpdateCommand = this.fbCommand7;
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
            this.fbCommand5.CommandText = "select * from camera_quente";
            this.fbCommand5.CommandTimeout = 30;
            this.fbCommand5.Connection = this.fbConnection1;
            // 
            // fbCommand7
            // 
            this.fbCommand7.CommandTimeout = 30;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvCamara_quente);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(375, 276);
            this.groupBox1.TabIndex = 315;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Camara Quente";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_valor_bq);
            this.groupBox2.Controls.Add(this.label60);
            this.groupBox2.Location = new System.Drawing.Point(399, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(207, 87);
            this.groupBox2.TabIndex = 316;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bico Quente";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(436, 245);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(140, 46);
            this.btnSalvar.TabIndex = 317;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // cbCamaraQuente
            // 
            this.cbCamaraQuente.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbCamaraQuente.DataAdapter = this.datCameraQuente;
            this.cbCamaraQuente.QuotePrefix = "\"";
            this.cbCamaraQuente.QuoteSuffix = "\"";
            // 
            // cbBicoQuente
            // 
            this.cbBicoQuente.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbBicoQuente.DataAdapter = this.datBicoQuente;
            this.cbBicoQuente.QuotePrefix = "\"";
            this.cbBicoQuente.QuoteSuffix = "\"";
            // 
            // form_camara_quente_bico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 300);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "form_camara_quente_bico";
            this.Text = "form_camara_quente_bico";
            this.Load += new System.EventHandler(this.form_camara_quente_bico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsBicoQuente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BICO_QUENTE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCamara_quente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCamaraQuente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CAMERA_QUENTE)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tb_valor_bq;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.DataGridView dgvCamara_quente;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datBicoQuente;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private System.Data.DataSet dsBicoQuente;
        private System.Data.DataTable BICO_QUENTE;
        private System.Data.DataColumn COD_BICO_QUENTE;
        private System.Data.DataColumn VALOR_BICO_QUENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODCAMERAQUENTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIMENSAOCAMERAQUENTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORCAMERAQUENTEDataGridViewTextBoxColumn;
        private System.Data.DataSet dsCamaraQuente;
        private System.Data.DataTable CAMERA_QUENTE;
        private System.Data.DataColumn COD_CAMERA_QUENTE;
        private System.Data.DataColumn DIMENSAO_CAMERA_QUENTE;
        private System.Data.DataColumn VALOR_CAMERA_QUENTE;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datCameraQuente;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand8;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand6;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand5;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSalvar;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbCamaraQuente;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbBicoQuente;
    }
}