namespace Evolucao
{
    partial class form_localiza_operador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_localiza_operador));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.col_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTPSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATANASCIMENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAADMISSAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATADEMISSAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPERACAOEXECDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsOperador = new System.Data.DataSet();
            this.OPERADORES = new System.Data.DataTable();
            this.COD_OPERADOR = new System.Data.DataColumn();
            this.NOME = new System.Data.DataColumn();
            this.CTPS = new System.Data.DataColumn();
            this.RG = new System.Data.DataColumn();
            this.DATA_NASCIMENTO = new System.Data.DataColumn();
            this.DATA_ADMISSAO = new System.Data.DataColumn();
            this.DATA_DEMISSAO = new System.Data.DataColumn();
            this.OPERACAO_EXEC = new System.Data.DataColumn();
            this.tb_localiza_operador = new System.Windows.Forms.TextBox();
            this.datOperador = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOperador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OPERADORES)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_cod,
            this.col_nome,
            this.cTPSDataGridViewTextBoxColumn,
            this.rGDataGridViewTextBoxColumn,
            this.dATANASCIMENTODataGridViewTextBoxColumn,
            this.dATAADMISSAODataGridViewTextBoxColumn,
            this.dATADEMISSAODataGridViewTextBoxColumn,
            this.oPERACAOEXECDataGridViewTextBoxColumn});
            this.dataGridView1.DataMember = "OPERADORES";
            this.dataGridView1.DataSource = this.dsOperador;
            this.dataGridView1.Location = new System.Drawing.Point(-3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(254, 150);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // col_cod
            // 
            this.col_cod.DataPropertyName = "COD_OPERADOR";
            this.col_cod.HeaderText = "Cód.";
            this.col_cod.Name = "col_cod";
            this.col_cod.ReadOnly = true;
            this.col_cod.Width = 60;
            // 
            // col_nome
            // 
            this.col_nome.DataPropertyName = "NOME";
            this.col_nome.HeaderText = "Nome";
            this.col_nome.Name = "col_nome";
            this.col_nome.ReadOnly = true;
            this.col_nome.Width = 150;
            // 
            // cTPSDataGridViewTextBoxColumn
            // 
            this.cTPSDataGridViewTextBoxColumn.DataPropertyName = "CTPS";
            this.cTPSDataGridViewTextBoxColumn.HeaderText = "CTPS";
            this.cTPSDataGridViewTextBoxColumn.Name = "cTPSDataGridViewTextBoxColumn";
            this.cTPSDataGridViewTextBoxColumn.ReadOnly = true;
            this.cTPSDataGridViewTextBoxColumn.Visible = false;
            // 
            // rGDataGridViewTextBoxColumn
            // 
            this.rGDataGridViewTextBoxColumn.DataPropertyName = "RG";
            this.rGDataGridViewTextBoxColumn.HeaderText = "RG";
            this.rGDataGridViewTextBoxColumn.Name = "rGDataGridViewTextBoxColumn";
            this.rGDataGridViewTextBoxColumn.ReadOnly = true;
            this.rGDataGridViewTextBoxColumn.Visible = false;
            // 
            // dATANASCIMENTODataGridViewTextBoxColumn
            // 
            this.dATANASCIMENTODataGridViewTextBoxColumn.DataPropertyName = "DATA_NASCIMENTO";
            this.dATANASCIMENTODataGridViewTextBoxColumn.HeaderText = "DATA_NASCIMENTO";
            this.dATANASCIMENTODataGridViewTextBoxColumn.Name = "dATANASCIMENTODataGridViewTextBoxColumn";
            this.dATANASCIMENTODataGridViewTextBoxColumn.ReadOnly = true;
            this.dATANASCIMENTODataGridViewTextBoxColumn.Visible = false;
            // 
            // dATAADMISSAODataGridViewTextBoxColumn
            // 
            this.dATAADMISSAODataGridViewTextBoxColumn.DataPropertyName = "DATA_ADMISSAO";
            this.dATAADMISSAODataGridViewTextBoxColumn.HeaderText = "DATA_ADMISSAO";
            this.dATAADMISSAODataGridViewTextBoxColumn.Name = "dATAADMISSAODataGridViewTextBoxColumn";
            this.dATAADMISSAODataGridViewTextBoxColumn.ReadOnly = true;
            this.dATAADMISSAODataGridViewTextBoxColumn.Visible = false;
            // 
            // dATADEMISSAODataGridViewTextBoxColumn
            // 
            this.dATADEMISSAODataGridViewTextBoxColumn.DataPropertyName = "DATA_DEMISSAO";
            this.dATADEMISSAODataGridViewTextBoxColumn.HeaderText = "DATA_DEMISSAO";
            this.dATADEMISSAODataGridViewTextBoxColumn.Name = "dATADEMISSAODataGridViewTextBoxColumn";
            this.dATADEMISSAODataGridViewTextBoxColumn.ReadOnly = true;
            this.dATADEMISSAODataGridViewTextBoxColumn.Visible = false;
            // 
            // oPERACAOEXECDataGridViewTextBoxColumn
            // 
            this.oPERACAOEXECDataGridViewTextBoxColumn.DataPropertyName = "OPERACAO_EXEC";
            this.oPERACAOEXECDataGridViewTextBoxColumn.HeaderText = "OPERACAO_EXEC";
            this.oPERACAOEXECDataGridViewTextBoxColumn.Name = "oPERACAOEXECDataGridViewTextBoxColumn";
            this.oPERACAOEXECDataGridViewTextBoxColumn.ReadOnly = true;
            this.oPERACAOEXECDataGridViewTextBoxColumn.Visible = false;
            // 
            // dsOperador
            // 
            this.dsOperador.DataSetName = "dsOperador";
            this.dsOperador.Namespace = "http://www.tempuri.org/dsOperador.xsd";
            this.dsOperador.Tables.AddRange(new System.Data.DataTable[] {
            this.OPERADORES});
            // 
            // OPERADORES
            // 
            this.OPERADORES.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_OPERADOR,
            this.NOME,
            this.CTPS,
            this.RG,
            this.DATA_NASCIMENTO,
            this.DATA_ADMISSAO,
            this.DATA_DEMISSAO,
            this.OPERACAO_EXEC});
            this.OPERADORES.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_OPERADOR"}, true)});
            this.OPERADORES.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_OPERADOR};
            this.OPERADORES.TableName = "OPERADORES";
            // 
            // COD_OPERADOR
            // 
            this.COD_OPERADOR.AllowDBNull = false;
            this.COD_OPERADOR.ColumnName = "COD_OPERADOR";
            this.COD_OPERADOR.MaxLength = 5;
            // 
            // NOME
            // 
            this.NOME.ColumnName = "NOME";
            this.NOME.MaxLength = 70;
            // 
            // CTPS
            // 
            this.CTPS.ColumnName = "CTPS";
            this.CTPS.MaxLength = 15;
            // 
            // RG
            // 
            this.RG.ColumnName = "RG";
            this.RG.MaxLength = 15;
            // 
            // DATA_NASCIMENTO
            // 
            this.DATA_NASCIMENTO.ColumnName = "DATA_NASCIMENTO";
            this.DATA_NASCIMENTO.DataType = typeof(System.DateTime);
            // 
            // DATA_ADMISSAO
            // 
            this.DATA_ADMISSAO.ColumnName = "DATA_ADMISSAO";
            this.DATA_ADMISSAO.DataType = typeof(System.DateTime);
            // 
            // DATA_DEMISSAO
            // 
            this.DATA_DEMISSAO.ColumnName = "DATA_DEMISSAO";
            this.DATA_DEMISSAO.DataType = typeof(System.DateTime);
            // 
            // OPERACAO_EXEC
            // 
            this.OPERACAO_EXEC.ColumnName = "OPERACAO_EXEC";
            this.OPERACAO_EXEC.DataType = typeof(int);
            // 
            // tb_localiza_operador
            // 
            this.tb_localiza_operador.Location = new System.Drawing.Point(-3, 2);
            this.tb_localiza_operador.Name = "tb_localiza_operador";
            this.tb_localiza_operador.Size = new System.Drawing.Size(254, 20);
            this.tb_localiza_operador.TabIndex = 2;
            this.tb_localiza_operador.TextChanged += new System.EventHandler(this.tb_localiza_operador_TextChanged);
            // 
            // datOperador
            // 
            this.datOperador.DeleteCommand = this.fbCommand4;
            this.datOperador.InsertCommand = this.fbCommand2;
            this.datOperador.SelectCommand = this.fbCommand1;
            this.datOperador.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * from operadores order by cod_operador";
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
            // form_localiza_operador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 190);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tb_localiza_operador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_localiza_operador";
            this.Text = "Localiza Operador";
            this.Load += new System.EventHandler(this.form_localiza_operador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOperador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OPERADORES)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tb_localiza_operador;
        private System.Data.DataSet dsOperador;
        private System.Data.DataTable OPERADORES;
        private System.Data.DataColumn COD_OPERADOR;
        private System.Data.DataColumn NOME;
        private System.Data.DataColumn CTPS;
        private System.Data.DataColumn RG;
        private System.Data.DataColumn DATA_NASCIMENTO;
        private System.Data.DataColumn DATA_ADMISSAO;
        private System.Data.DataColumn DATA_DEMISSAO;
        private System.Data.DataColumn OPERACAO_EXEC;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datOperador;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTPSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATANASCIMENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAADMISSAODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATADEMISSAODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPERACAOEXECDataGridViewTextBoxColumn;
    }
}