namespace Evolucao
{
    partial class form_material
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_material));
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvCarteiras = new System.Windows.Forms.DataGridView();
            this.datMaterial = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsMaterial = new System.Data.DataSet();
            this.MATERIAL = new System.Data.DataTable();
            this.COD_MATERIAL = new System.Data.DataColumn();
            this.DESCRICAO_MATERIAL = new System.Data.DataColumn();
            this.cbMaterial = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.col_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarteiras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MATERIAL)).BeginInit();
            this.SuspendLayout();
            // 
            // fbConnection1
            // 
            this.fbConnection1.ConnectionString = resources.GetString("fbConnection1.ConnectionString");
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(157, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvCarteiras
            // 
            this.dgvCarteiras.AutoGenerateColumns = false;
            this.dgvCarteiras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarteiras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_cod,
            this.col_nome});
            this.dgvCarteiras.DataMember = "MATERIAL";
            this.dgvCarteiras.DataSource = this.dsMaterial;
            this.dgvCarteiras.Location = new System.Drawing.Point(12, 12);
            this.dgvCarteiras.Name = "dgvCarteiras";
            this.dgvCarteiras.Size = new System.Drawing.Size(367, 373);
            this.dgvCarteiras.TabIndex = 2;
            this.dgvCarteiras.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarteiras_CellContentDoubleClick);
            // 
            // datMaterial
            // 
            this.datMaterial.DeleteCommand = this.fbCommand4;
            this.datMaterial.InsertCommand = this.fbCommand2;
            this.datMaterial.SelectCommand = this.fbCommand1;
            this.datMaterial.UpdateCommand = this.fbCommand3;
            // 
            // fbCommand1
            // 
            this.fbCommand1.CommandText = "SELECT * FROM MATERIAL";
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
            // dsMaterial
            // 
            this.dsMaterial.DataSetName = "dsMaterial";
            this.dsMaterial.Namespace = "http://www.tempuri.org/dsMaterial.xsd";
            this.dsMaterial.Tables.AddRange(new System.Data.DataTable[] {
            this.MATERIAL});
            // 
            // MATERIAL
            // 
            this.MATERIAL.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_MATERIAL,
            this.DESCRICAO_MATERIAL});
            this.MATERIAL.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_MATERIAL"}, true)});
            this.MATERIAL.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_MATERIAL};
            this.MATERIAL.TableName = "MATERIAL";
            // 
            // COD_MATERIAL
            // 
            this.COD_MATERIAL.AllowDBNull = false;
            this.COD_MATERIAL.AutoIncrement = true;
            this.COD_MATERIAL.ColumnName = "COD_MATERIAL";
            this.COD_MATERIAL.DataType = typeof(int);
            // 
            // DESCRICAO_MATERIAL
            // 
            this.DESCRICAO_MATERIAL.ColumnName = "DESCRICAO_MATERIAL";
            this.DESCRICAO_MATERIAL.MaxLength = 200;
            // 
            // cbMaterial
            // 
            this.cbMaterial.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbMaterial.DataAdapter = this.datMaterial;
            this.cbMaterial.QuotePrefix = "\"";
            this.cbMaterial.QuoteSuffix = "\"";
            // 
            // col_cod
            // 
            this.col_cod.DataPropertyName = "COD_MATERIAL";
            this.col_cod.HeaderText = "Cod.";
            this.col_cod.Name = "col_cod";
            // 
            // col_nome
            // 
            this.col_nome.DataPropertyName = "DESCRICAO_MATERIAL";
            this.col_nome.HeaderText = "Material";
            this.col_nome.Name = "col_nome";
            this.col_nome.Width = 200;
            // 
            // form_material
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 421);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvCarteiras);
            this.Name = "form_material";
            this.Text = "Material";
            this.Load += new System.EventHandler(this.form_material_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarteiras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MATERIAL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvCarteiras;
        private System.Data.DataSet dsMaterial;
        private System.Data.DataTable MATERIAL;
        private System.Data.DataColumn COD_MATERIAL;
        private System.Data.DataColumn DESCRICAO_MATERIAL;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datMaterial;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nome;
    }
}