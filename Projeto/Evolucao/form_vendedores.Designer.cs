namespace Evolucao
{
    partial class form_vendedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_vendedores));
            this.datVendedores = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.button1 = new System.Windows.Forms.Button();
            this.cbVendedores = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.dgvVendedores = new System.Windows.Forms.DataGridView();
            this.col_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPELIDOVENDEDORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tELEFONEVENDEDORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cELULARVENDEDORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILVENDEDORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFVENDEDORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rGVENDEDORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_metas = new System.Windows.Forms.DataGridViewButtonColumn();
            this.eNDERECOVENDEDORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSTADOVENDEDORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rOTEIROVENDEDORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATADEMISSAOVENDEDORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aTIVOVENDEDORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.mETAVALORVENDEDORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsVendedores = new System.Data.DataSet();
            this.VENDEDORES = new System.Data.DataTable();
            this.COD_VENDEDOR = new System.Data.DataColumn();
            this.NOME_VENDEDOR = new System.Data.DataColumn();
            this.TELEFONE_VENDEDOR = new System.Data.DataColumn();
            this.CELULAR_VENDEDOR = new System.Data.DataColumn();
            this.ENDERECO_VENDEDOR = new System.Data.DataColumn();
            this.META_VALOR_VENDEDOR = new System.Data.DataColumn();
            this.ROTEIRO_VENDEDOR = new System.Data.DataColumn();
            this.DATA_DEMISSAO_VENDEDOR = new System.Data.DataColumn();
            this.ATIVO_VENDEDOR = new System.Data.DataColumn();
            this.CPF_VENDEDOR = new System.Data.DataColumn();
            this.RG_VENDEDOR = new System.Data.DataColumn();
            this.ESTADO_VENDEDOR = new System.Data.DataColumn();
            this.APELIDO_VENDEDOR = new System.Data.DataColumn();
            this.EMAIL_VENDEDOR = new System.Data.DataColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVendedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VENDEDORES)).BeginInit();
            this.SuspendLayout();
            // 
            // datVendedores
            // 
            this.datVendedores.DeleteCommand = this.fbCommand4;
            this.datVendedores.InsertCommand = this.fbCommand2;
            this.datVendedores.SelectCommand = this.fbCommand1;
            this.datVendedores.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * from vendedores";
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(652, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbVendedores
            // 
            this.cbVendedores.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbVendedores.DataAdapter = this.datVendedores;
            this.cbVendedores.QuotePrefix = "\"";
            this.cbVendedores.QuoteSuffix = "\"";
            // 
            // dgvVendedores
            // 
            this.dgvVendedores.AutoGenerateColumns = false;
            this.dgvVendedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_cod,
            this.col_nome,
            this.aPELIDOVENDEDORDataGridViewTextBoxColumn,
            this.tELEFONEVENDEDORDataGridViewTextBoxColumn,
            this.cELULARVENDEDORDataGridViewTextBoxColumn,
            this.eMAILVENDEDORDataGridViewTextBoxColumn,
            this.cPFVENDEDORDataGridViewTextBoxColumn,
            this.rGVENDEDORDataGridViewTextBoxColumn,
            this.col_metas,
            this.eNDERECOVENDEDORDataGridViewTextBoxColumn,
            this.eSTADOVENDEDORDataGridViewTextBoxColumn,
            this.rOTEIROVENDEDORDataGridViewTextBoxColumn,
            this.dATADEMISSAOVENDEDORDataGridViewTextBoxColumn,
            this.aTIVOVENDEDORDataGridViewTextBoxColumn,
            this.mETAVALORVENDEDORDataGridViewTextBoxColumn});
            this.dgvVendedores.DataMember = "VENDEDORES";
            this.dgvVendedores.DataSource = this.dsVendedores;
            this.dgvVendedores.Location = new System.Drawing.Point(12, 12);
            this.dgvVendedores.Name = "dgvVendedores";
            this.dgvVendedores.Size = new System.Drawing.Size(1360, 422);
            this.dgvVendedores.TabIndex = 2;
            this.dgvVendedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVendedores_CellContentClick_1);
            this.dgvVendedores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVendedores_CellDoubleClick_1);
            // 
            // col_cod
            // 
            this.col_cod.DataPropertyName = "COD_VENDEDOR";
            this.col_cod.HeaderText = "Cód.";
            this.col_cod.Name = "col_cod";
            this.col_cod.Width = 30;
            // 
            // col_nome
            // 
            this.col_nome.DataPropertyName = "NOME_VENDEDOR";
            this.col_nome.HeaderText = "Nome";
            this.col_nome.Name = "col_nome";
            this.col_nome.Width = 200;
            // 
            // aPELIDOVENDEDORDataGridViewTextBoxColumn
            // 
            this.aPELIDOVENDEDORDataGridViewTextBoxColumn.DataPropertyName = "APELIDO_VENDEDOR";
            this.aPELIDOVENDEDORDataGridViewTextBoxColumn.HeaderText = "Apelido";
            this.aPELIDOVENDEDORDataGridViewTextBoxColumn.Name = "aPELIDOVENDEDORDataGridViewTextBoxColumn";
            // 
            // tELEFONEVENDEDORDataGridViewTextBoxColumn
            // 
            this.tELEFONEVENDEDORDataGridViewTextBoxColumn.DataPropertyName = "TELEFONE_VENDEDOR";
            this.tELEFONEVENDEDORDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.tELEFONEVENDEDORDataGridViewTextBoxColumn.Name = "tELEFONEVENDEDORDataGridViewTextBoxColumn";
            // 
            // cELULARVENDEDORDataGridViewTextBoxColumn
            // 
            this.cELULARVENDEDORDataGridViewTextBoxColumn.DataPropertyName = "CELULAR_VENDEDOR";
            this.cELULARVENDEDORDataGridViewTextBoxColumn.HeaderText = "Celular";
            this.cELULARVENDEDORDataGridViewTextBoxColumn.Name = "cELULARVENDEDORDataGridViewTextBoxColumn";
            // 
            // eMAILVENDEDORDataGridViewTextBoxColumn
            // 
            this.eMAILVENDEDORDataGridViewTextBoxColumn.DataPropertyName = "EMAIL_VENDEDOR";
            this.eMAILVENDEDORDataGridViewTextBoxColumn.HeaderText = "Email";
            this.eMAILVENDEDORDataGridViewTextBoxColumn.Name = "eMAILVENDEDORDataGridViewTextBoxColumn";
            this.eMAILVENDEDORDataGridViewTextBoxColumn.Width = 200;
            // 
            // cPFVENDEDORDataGridViewTextBoxColumn
            // 
            this.cPFVENDEDORDataGridViewTextBoxColumn.DataPropertyName = "CPF_VENDEDOR";
            this.cPFVENDEDORDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cPFVENDEDORDataGridViewTextBoxColumn.Name = "cPFVENDEDORDataGridViewTextBoxColumn";
            // 
            // rGVENDEDORDataGridViewTextBoxColumn
            // 
            this.rGVENDEDORDataGridViewTextBoxColumn.DataPropertyName = "RG_VENDEDOR";
            this.rGVENDEDORDataGridViewTextBoxColumn.HeaderText = "RG";
            this.rGVENDEDORDataGridViewTextBoxColumn.Name = "rGVENDEDORDataGridViewTextBoxColumn";
            // 
            // col_metas
            // 
            this.col_metas.HeaderText = "Meta";
            this.col_metas.Name = "col_metas";
            // 
            // eNDERECOVENDEDORDataGridViewTextBoxColumn
            // 
            this.eNDERECOVENDEDORDataGridViewTextBoxColumn.DataPropertyName = "ENDERECO_VENDEDOR";
            this.eNDERECOVENDEDORDataGridViewTextBoxColumn.HeaderText = "Endereço";
            this.eNDERECOVENDEDORDataGridViewTextBoxColumn.Name = "eNDERECOVENDEDORDataGridViewTextBoxColumn";
            this.eNDERECOVENDEDORDataGridViewTextBoxColumn.Width = 300;
            // 
            // eSTADOVENDEDORDataGridViewTextBoxColumn
            // 
            this.eSTADOVENDEDORDataGridViewTextBoxColumn.DataPropertyName = "ESTADO_VENDEDOR";
            this.eSTADOVENDEDORDataGridViewTextBoxColumn.HeaderText = "UF";
            this.eSTADOVENDEDORDataGridViewTextBoxColumn.Name = "eSTADOVENDEDORDataGridViewTextBoxColumn";
            this.eSTADOVENDEDORDataGridViewTextBoxColumn.Width = 30;
            // 
            // rOTEIROVENDEDORDataGridViewTextBoxColumn
            // 
            this.rOTEIROVENDEDORDataGridViewTextBoxColumn.DataPropertyName = "ROTEIRO_VENDEDOR";
            this.rOTEIROVENDEDORDataGridViewTextBoxColumn.HeaderText = "Roteiro";
            this.rOTEIROVENDEDORDataGridViewTextBoxColumn.Name = "rOTEIROVENDEDORDataGridViewTextBoxColumn";
            // 
            // dATADEMISSAOVENDEDORDataGridViewTextBoxColumn
            // 
            this.dATADEMISSAOVENDEDORDataGridViewTextBoxColumn.DataPropertyName = "DATA_DEMISSAO_VENDEDOR";
            this.dATADEMISSAOVENDEDORDataGridViewTextBoxColumn.HeaderText = "Data Demissão";
            this.dATADEMISSAOVENDEDORDataGridViewTextBoxColumn.Name = "dATADEMISSAOVENDEDORDataGridViewTextBoxColumn";
            // 
            // aTIVOVENDEDORDataGridViewTextBoxColumn
            // 
            this.aTIVOVENDEDORDataGridViewTextBoxColumn.DataPropertyName = "ATIVO_VENDEDOR";
            this.aTIVOVENDEDORDataGridViewTextBoxColumn.HeaderText = "ATIVO_VENDEDOR";
            this.aTIVOVENDEDORDataGridViewTextBoxColumn.Name = "aTIVOVENDEDORDataGridViewTextBoxColumn";
            this.aTIVOVENDEDORDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.aTIVOVENDEDORDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // mETAVALORVENDEDORDataGridViewTextBoxColumn
            // 
            this.mETAVALORVENDEDORDataGridViewTextBoxColumn.DataPropertyName = "META_VALOR_VENDEDOR";
            this.mETAVALORVENDEDORDataGridViewTextBoxColumn.HeaderText = "Meta";
            this.mETAVALORVENDEDORDataGridViewTextBoxColumn.Name = "mETAVALORVENDEDORDataGridViewTextBoxColumn";
            // 
            // dsVendedores
            // 
            this.dsVendedores.DataSetName = "dsVendedores";
            this.dsVendedores.Namespace = "http://www.tempuri.org/dsVendedores.xsd";
            this.dsVendedores.Tables.AddRange(new System.Data.DataTable[] {
            this.VENDEDORES});
            // 
            // VENDEDORES
            // 
            this.VENDEDORES.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_VENDEDOR,
            this.NOME_VENDEDOR,
            this.TELEFONE_VENDEDOR,
            this.CELULAR_VENDEDOR,
            this.ENDERECO_VENDEDOR,
            this.META_VALOR_VENDEDOR,
            this.ROTEIRO_VENDEDOR,
            this.DATA_DEMISSAO_VENDEDOR,
            this.ATIVO_VENDEDOR,
            this.CPF_VENDEDOR,
            this.RG_VENDEDOR,
            this.ESTADO_VENDEDOR,
            this.APELIDO_VENDEDOR,
            this.EMAIL_VENDEDOR});
            this.VENDEDORES.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_VENDEDOR"}, true)});
            this.VENDEDORES.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_VENDEDOR};
            this.VENDEDORES.TableName = "VENDEDORES";
            // 
            // COD_VENDEDOR
            // 
            this.COD_VENDEDOR.AllowDBNull = false;
            this.COD_VENDEDOR.ColumnName = "COD_VENDEDOR";
            this.COD_VENDEDOR.DataType = typeof(int);
            // 
            // NOME_VENDEDOR
            // 
            this.NOME_VENDEDOR.ColumnName = "NOME_VENDEDOR";
            this.NOME_VENDEDOR.MaxLength = 100;
            // 
            // TELEFONE_VENDEDOR
            // 
            this.TELEFONE_VENDEDOR.ColumnName = "TELEFONE_VENDEDOR";
            this.TELEFONE_VENDEDOR.MaxLength = 100;
            // 
            // CELULAR_VENDEDOR
            // 
            this.CELULAR_VENDEDOR.ColumnName = "CELULAR_VENDEDOR";
            this.CELULAR_VENDEDOR.MaxLength = 100;
            // 
            // ENDERECO_VENDEDOR
            // 
            this.ENDERECO_VENDEDOR.ColumnName = "ENDERECO_VENDEDOR";
            this.ENDERECO_VENDEDOR.MaxLength = 200;
            // 
            // META_VALOR_VENDEDOR
            // 
            this.META_VALOR_VENDEDOR.ColumnName = "META_VALOR_VENDEDOR";
            this.META_VALOR_VENDEDOR.DataType = typeof(double);
            // 
            // ROTEIRO_VENDEDOR
            // 
            this.ROTEIRO_VENDEDOR.ColumnName = "ROTEIRO_VENDEDOR";
            this.ROTEIRO_VENDEDOR.DataType = typeof(int);
            // 
            // DATA_DEMISSAO_VENDEDOR
            // 
            this.DATA_DEMISSAO_VENDEDOR.ColumnName = "DATA_DEMISSAO_VENDEDOR";
            this.DATA_DEMISSAO_VENDEDOR.DataType = typeof(System.DateTime);
            // 
            // ATIVO_VENDEDOR
            // 
            this.ATIVO_VENDEDOR.ColumnName = "ATIVO_VENDEDOR";
            this.ATIVO_VENDEDOR.DataType = typeof(int);
            // 
            // CPF_VENDEDOR
            // 
            this.CPF_VENDEDOR.ColumnName = "CPF_VENDEDOR";
            this.CPF_VENDEDOR.MaxLength = 14;
            // 
            // RG_VENDEDOR
            // 
            this.RG_VENDEDOR.ColumnName = "RG_VENDEDOR";
            this.RG_VENDEDOR.MaxLength = 20;
            // 
            // ESTADO_VENDEDOR
            // 
            this.ESTADO_VENDEDOR.ColumnName = "ESTADO_VENDEDOR";
            this.ESTADO_VENDEDOR.MaxLength = 2;
            // 
            // APELIDO_VENDEDOR
            // 
            this.APELIDO_VENDEDOR.ColumnName = "APELIDO_VENDEDOR";
            this.APELIDO_VENDEDOR.MaxLength = 50;
            // 
            // EMAIL_VENDEDOR
            // 
            this.EMAIL_VENDEDOR.ColumnName = "EMAIL_VENDEDOR";
            this.EMAIL_VENDEDOR.MaxLength = 100;
            // 
            // form_vendedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 475);
            this.Controls.Add(this.dgvVendedores);
            this.Controls.Add(this.button1);
            this.Name = "form_vendedores";
            this.Text = "Vendedores";
            this.Load += new System.EventHandler(this.form_vendedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVendedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VENDEDORES)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datVendedores;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Windows.Forms.Button button1;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbVendedores;
        private System.Windows.Forms.DataGridView dgvVendedores;
        private System.Data.DataSet dsVendedores;
        private System.Data.DataTable VENDEDORES;
        private System.Data.DataColumn COD_VENDEDOR;
        private System.Data.DataColumn NOME_VENDEDOR;
        private System.Data.DataColumn TELEFONE_VENDEDOR;
        private System.Data.DataColumn CELULAR_VENDEDOR;
        private System.Data.DataColumn ENDERECO_VENDEDOR;
        private System.Data.DataColumn META_VALOR_VENDEDOR;
        private System.Data.DataColumn ROTEIRO_VENDEDOR;
        private System.Data.DataColumn DATA_DEMISSAO_VENDEDOR;
        private System.Data.DataColumn ATIVO_VENDEDOR;
        private System.Data.DataColumn CPF_VENDEDOR;
        private System.Data.DataColumn RG_VENDEDOR;
        private System.Data.DataColumn ESTADO_VENDEDOR;
        private System.Data.DataColumn APELIDO_VENDEDOR;
        private System.Data.DataColumn EMAIL_VENDEDOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPELIDOVENDEDORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tELEFONEVENDEDORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cELULARVENDEDORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILVENDEDORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFVENDEDORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rGVENDEDORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn col_metas;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNDERECOVENDEDORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTADOVENDEDORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rOTEIROVENDEDORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATADEMISSAOVENDEDORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aTIVOVENDEDORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mETAVALORVENDEDORDataGridViewTextBoxColumn;
    }
}