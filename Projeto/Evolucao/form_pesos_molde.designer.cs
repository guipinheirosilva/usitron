namespace Evolucao
{
    partial class form_pesos_molde
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_pesos_molde));
            this.dgvPeso = new System.Windows.Forms.DataGridView();
            this.col_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PESO_MINIMO_MOLDES_PECAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PESO_MAXIMO_MOLDES_PECAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECO_MOLDES_PECAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsPesos = new System.Data.DataSet();
            this.PESO_MOLDES_PECAS = new System.Data.DataTable();
            this.COD_PESO_MOLDES_PECAS = new System.Data.DataColumn();
            this.DESCRICAO_PESO_MOLDES_PECAS = new System.Data.DataColumn();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.datPeso = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.cbPesos = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPesos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PESO_MOLDES_PECAS)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPeso
            // 
            this.dgvPeso.AutoGenerateColumns = false;
            this.dgvPeso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_cod,
            this.col_peso,
            this.PESO_MINIMO_MOLDES_PECAS,
            this.PESO_MAXIMO_MOLDES_PECAS,
            this.PRECO_MOLDES_PECAS});
            this.dgvPeso.DataMember = "PESO_MOLDES_PECAS";
            this.dgvPeso.DataSource = this.dsPesos;
            this.dgvPeso.Location = new System.Drawing.Point(16, 15);
            this.dgvPeso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPeso.Name = "dgvPeso";
            this.dgvPeso.Size = new System.Drawing.Size(717, 420);
            this.dgvPeso.TabIndex = 0;
            this.dgvPeso.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPeso_CellContentDoubleClick);
            // 
            // col_cod
            // 
            this.col_cod.DataPropertyName = "COD_PESO_MOLDES_PECAS";
            this.col_cod.HeaderText = "Cod.";
            this.col_cod.Name = "col_cod";
            // 
            // col_peso
            // 
            this.col_peso.DataPropertyName = "DESCRICAO_PESO_MOLDES_PECAS";
            this.col_peso.HeaderText = "Desrição";
            this.col_peso.Name = "col_peso";
            this.col_peso.Width = 150;
            // 
            // PESO_MINIMO_MOLDES_PECAS
            // 
            this.PESO_MINIMO_MOLDES_PECAS.DataPropertyName = "PESO_MINIMO_MOLDES_PECAS";
            this.PESO_MINIMO_MOLDES_PECAS.HeaderText = "Peso Min.";
            this.PESO_MINIMO_MOLDES_PECAS.Name = "PESO_MINIMO_MOLDES_PECAS";
            this.PESO_MINIMO_MOLDES_PECAS.Width = 75;
            // 
            // PESO_MAXIMO_MOLDES_PECAS
            // 
            this.PESO_MAXIMO_MOLDES_PECAS.DataPropertyName = "PESO_MAXIMO_MOLDES_PECAS";
            this.PESO_MAXIMO_MOLDES_PECAS.HeaderText = "Peso Max.";
            this.PESO_MAXIMO_MOLDES_PECAS.Name = "PESO_MAXIMO_MOLDES_PECAS";
            this.PESO_MAXIMO_MOLDES_PECAS.Width = 75;
            // 
            // PRECO_MOLDES_PECAS
            // 
            this.PRECO_MOLDES_PECAS.DataPropertyName = "PRECO_MOLDES_PECAS";
            this.PRECO_MOLDES_PECAS.HeaderText = "Preço";
            this.PRECO_MOLDES_PECAS.Name = "PRECO_MOLDES_PECAS";
            this.PRECO_MOLDES_PECAS.Width = 75;
            // 
            // dsPesos
            // 
            this.dsPesos.DataSetName = "dsPesos";
            this.dsPesos.Namespace = "http://www.tempuri.org/dsPesos.xsd";
            this.dsPesos.Tables.AddRange(new System.Data.DataTable[] {
            this.PESO_MOLDES_PECAS});
            // 
            // PESO_MOLDES_PECAS
            // 
            this.PESO_MOLDES_PECAS.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_PESO_MOLDES_PECAS,
            this.DESCRICAO_PESO_MOLDES_PECAS,
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3});
            this.PESO_MOLDES_PECAS.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_PESO_MOLDES_PECAS"}, true)});
            this.PESO_MOLDES_PECAS.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_PESO_MOLDES_PECAS};
            this.PESO_MOLDES_PECAS.TableName = "PESO_MOLDES_PECAS";
            // 
            // COD_PESO_MOLDES_PECAS
            // 
            this.COD_PESO_MOLDES_PECAS.AllowDBNull = false;
            this.COD_PESO_MOLDES_PECAS.AutoIncrement = true;
            this.COD_PESO_MOLDES_PECAS.ColumnName = "COD_PESO_MOLDES_PECAS";
            this.COD_PESO_MOLDES_PECAS.DataType = typeof(int);
            // 
            // DESCRICAO_PESO_MOLDES_PECAS
            // 
            this.DESCRICAO_PESO_MOLDES_PECAS.ColumnName = "DESCRICAO_PESO_MOLDES_PECAS";
            this.DESCRICAO_PESO_MOLDES_PECAS.MaxLength = 200;
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "PESO_MINIMO_MOLDES_PECAS";
            this.dataColumn1.DataType = typeof(double);
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "PESO_MAXIMO_MOLDES_PECAS";
            this.dataColumn2.DataType = typeof(double);
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "PRECO_MOLDES_PECAS";
            this.dataColumn3.DataType = typeof(double);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(159, 442);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(104, 28);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // datPeso
            // 
            this.datPeso.DeleteCommand = this.fbCommand4;
            this.datPeso.InsertCommand = this.fbCommand2;
            this.datPeso.SelectCommand = this.fbCommand1;
            this.datPeso.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * from PESO_MOLDES_PECAS";
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
            // cbPesos
            // 
            this.cbPesos.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbPesos.DataAdapter = this.datPeso;
            this.cbPesos.QuotePrefix = "\"";
            this.cbPesos.QuoteSuffix = "\"";
            // 
            // form_pesos_molde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 475);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.dgvPeso);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "form_pesos_molde";
            this.Text = "Pesos Molde";
            this.Load += new System.EventHandler(this.form_pesos_molde_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPesos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PESO_MOLDES_PECAS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPeso;
        private System.Windows.Forms.Button btnSalvar;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datPeso;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private System.Data.DataSet dsPesos;
        private System.Data.DataTable PESO_MOLDES_PECAS;
        private System.Data.DataColumn COD_PESO_MOLDES_PECAS;
        private System.Data.DataColumn DESCRICAO_PESO_MOLDES_PECAS;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbPesos;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn PESO_MINIMO_MOLDES_PECAS;
        private System.Windows.Forms.DataGridViewTextBoxColumn PESO_MAXIMO_MOLDES_PECAS;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECO_MOLDES_PECAS;
        private System.Data.DataColumn dataColumn3;
    }
}