namespace Evolucao
{
    partial class form_outros_serviços
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_outros_serviços));
            this.tb_descricao = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.dgvMateria_prima = new System.Windows.Forms.DataGridView();
            this.col_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PADRAO_ORC_OUTRO_SERV = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dsOutrosServicos = new System.Data.DataSet();
            this.OUTROS_SERVICOS = new System.Data.DataTable();
            this.COD_OUTROS_SERV = new System.Data.DataColumn();
            this.DESCRICAO_OUTRO_SERV = new System.Data.DataColumn();
            this.VALOR_OUTRO_SERV = new System.Data.DataColumn();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dsMateria_prima = new System.Data.DataSet();
            this.MATERIA_PRIMA = new System.Data.DataTable();
            this.COD_MATERIA_PRIMA = new System.Data.DataColumn();
            this.DESCRICAO_MATERIA_PRIMA = new System.Data.DataColumn();
            this.VALOR_KG_MATERIA_PRIMA = new System.Data.DataColumn();
            this.cbMateria_prima = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.datMateria_prima = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.button1 = new System.Windows.Forms.Button();
            this.fbDataAdapter1 = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand8 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand6 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand5 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand7 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.datOutrosServicos = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand12 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand10 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand9 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand11 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.cbOutrosServicos = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateria_prima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOutrosServicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OUTROS_SERVICOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMateria_prima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MATERIA_PRIMA)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_descricao
            // 
            this.tb_descricao.Location = new System.Drawing.Point(169, 81);
            this.tb_descricao.Margin = new System.Windows.Forms.Padding(4);
            this.tb_descricao.Name = "tb_descricao";
            this.tb_descricao.Size = new System.Drawing.Size(260, 22);
            this.tb_descricao.TabIndex = 96;
            this.tb_descricao.TextChanged += new System.EventHandler(this.tb_descricao_TextChanged);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label28.Location = new System.Drawing.Point(60, 11);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(479, 54);
            this.label28.TabIndex = 94;
            this.label28.Text = "OUTROS SERVIÇOS";
            // 
            // dgvMateria_prima
            // 
            this.dgvMateria_prima.AutoGenerateColumns = false;
            this.dgvMateria_prima.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMateria_prima.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_cod,
            this.col_descricao,
            this.col_valor,
            this.PADRAO_ORC_OUTRO_SERV});
            this.dgvMateria_prima.DataMember = "OUTROS_SERVICOS";
            this.dgvMateria_prima.DataSource = this.dsOutrosServicos;
            this.dgvMateria_prima.Location = new System.Drawing.Point(16, 113);
            this.dgvMateria_prima.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMateria_prima.Name = "dgvMateria_prima";
            this.dgvMateria_prima.Size = new System.Drawing.Size(676, 506);
            this.dgvMateria_prima.TabIndex = 93;
            this.dgvMateria_prima.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMateria_prima_CellDoubleClick);
            // 
            // col_cod
            // 
            this.col_cod.DataPropertyName = "COD_OUTROS_SERV";
            this.col_cod.HeaderText = "Cod.";
            this.col_cod.Name = "col_cod";
            this.col_cod.Width = 70;
            // 
            // col_descricao
            // 
            this.col_descricao.DataPropertyName = "DESCRICAO_OUTRO_SERV";
            this.col_descricao.HeaderText = "Descrição";
            this.col_descricao.Name = "col_descricao";
            this.col_descricao.Width = 200;
            // 
            // col_valor
            // 
            this.col_valor.DataPropertyName = "VALOR_OUTRO_SERV";
            this.col_valor.HeaderText = "Valor";
            this.col_valor.Name = "col_valor";
            // 
            // PADRAO_ORC_OUTRO_SERV
            // 
            this.PADRAO_ORC_OUTRO_SERV.DataPropertyName = "PADRAO_ORC_OUTRO_SERV";
            this.PADRAO_ORC_OUTRO_SERV.HeaderText = "Padrão Orc.";
            this.PADRAO_ORC_OUTRO_SERV.Name = "PADRAO_ORC_OUTRO_SERV";
            // 
            // dsOutrosServicos
            // 
            this.dsOutrosServicos.DataSetName = "dsOutrosServicos";
            this.dsOutrosServicos.Namespace = "http://www.tempuri.org/dsOutrosServicos.xsd";
            this.dsOutrosServicos.Tables.AddRange(new System.Data.DataTable[] {
            this.OUTROS_SERVICOS});
            // 
            // OUTROS_SERVICOS
            // 
            this.OUTROS_SERVICOS.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_OUTROS_SERV,
            this.DESCRICAO_OUTRO_SERV,
            this.VALOR_OUTRO_SERV,
            this.dataColumn1});
            this.OUTROS_SERVICOS.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_OUTROS_SERV"}, true)});
            this.OUTROS_SERVICOS.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_OUTROS_SERV};
            this.OUTROS_SERVICOS.TableName = "OUTROS_SERVICOS";
            // 
            // COD_OUTROS_SERV
            // 
            this.COD_OUTROS_SERV.AllowDBNull = false;
            this.COD_OUTROS_SERV.AutoIncrement = true;
            this.COD_OUTROS_SERV.ColumnName = "COD_OUTROS_SERV";
            this.COD_OUTROS_SERV.DataType = typeof(int);
            // 
            // DESCRICAO_OUTRO_SERV
            // 
            this.DESCRICAO_OUTRO_SERV.ColumnName = "DESCRICAO_OUTRO_SERV";
            // 
            // VALOR_OUTRO_SERV
            // 
            this.VALOR_OUTRO_SERV.ColumnName = "VALOR_OUTRO_SERV";
            this.VALOR_OUTRO_SERV.DataType = typeof(double);
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "PADRAO_ORC_OUTRO_SERV";
            this.dataColumn1.DataType = typeof(int);
            // 
            // dsMateria_prima
            // 
            this.dsMateria_prima.DataSetName = "dsMateria_prima";
            this.dsMateria_prima.Namespace = "http://www.tempuri.org/dsMateria_prima.xsd";
            this.dsMateria_prima.Tables.AddRange(new System.Data.DataTable[] {
            this.MATERIA_PRIMA});
            // 
            // MATERIA_PRIMA
            // 
            this.MATERIA_PRIMA.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_MATERIA_PRIMA,
            this.DESCRICAO_MATERIA_PRIMA,
            this.VALOR_KG_MATERIA_PRIMA});
            this.MATERIA_PRIMA.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_MATERIA_PRIMA"}, true)});
            this.MATERIA_PRIMA.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_MATERIA_PRIMA};
            this.MATERIA_PRIMA.TableName = "MATERIA_PRIMA";
            // 
            // COD_MATERIA_PRIMA
            // 
            this.COD_MATERIA_PRIMA.AllowDBNull = false;
            this.COD_MATERIA_PRIMA.AutoIncrement = true;
            this.COD_MATERIA_PRIMA.AutoIncrementSeed = ((long)(1));
            this.COD_MATERIA_PRIMA.ColumnName = "COD_MATERIA_PRIMA";
            this.COD_MATERIA_PRIMA.DataType = typeof(int);
            // 
            // DESCRICAO_MATERIA_PRIMA
            // 
            this.DESCRICAO_MATERIA_PRIMA.ColumnName = "DESCRICAO_MATERIA_PRIMA";
            this.DESCRICAO_MATERIA_PRIMA.MaxLength = 200;
            // 
            // VALOR_KG_MATERIA_PRIMA
            // 
            this.VALOR_KG_MATERIA_PRIMA.ColumnName = "VALOR_KG_MATERIA_PRIMA";
            this.VALOR_KG_MATERIA_PRIMA.DataType = typeof(double);
            // 
            // cbMateria_prima
            // 
            this.cbMateria_prima.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbMateria_prima.DataAdapter = this.datMateria_prima;
            this.cbMateria_prima.QuotePrefix = "\"";
            this.cbMateria_prima.QuoteSuffix = "\"";
            // 
            // datMateria_prima
            // 
            this.datMateria_prima.DeleteCommand = this.fbCommand4;
            this.datMateria_prima.InsertCommand = this.fbCommand2;
            this.datMateria_prima.SelectCommand = this.fbCommand1;
            this.datMateria_prima.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * FROM MATERIA_PRIMA";
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
            this.button1.Location = new System.Drawing.Point(492, 627);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 95;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fbDataAdapter1
            // 
            this.fbDataAdapter1.DeleteCommand = this.fbCommand8;
            this.fbDataAdapter1.InsertCommand = this.fbCommand6;
            this.fbDataAdapter1.SelectCommand = this.fbCommand5;
            this.fbDataAdapter1.UpdateCommand = this.fbCommand7;
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
            this.fbCommand5.CommandTimeout = 30;
            // 
            // fbCommand7
            // 
            this.fbCommand7.CommandTimeout = 30;
            // 
            // datOutrosServicos
            // 
            this.datOutrosServicos.DeleteCommand = this.fbCommand12;
            this.datOutrosServicos.InsertCommand = this.fbCommand10;
            this.datOutrosServicos.SelectCommand = this.fbCommand9;
            this.datOutrosServicos.UpdateCommand = this.fbCommand11;
            this.datOutrosServicos.RowUpdated += new FirebirdSql.Data.FirebirdClient.FbRowUpdatedEventHandler(this.datOutrosServicos_RowUpdated);
            // 
            // fbCommand12
            // 
            this.fbCommand12.CommandTimeout = 30;
            // 
            // fbCommand10
            // 
            this.fbCommand10.CommandTimeout = 30;
            // 
            // fbCommand9
            // 
            this.fbCommand9.CommandText = "SELECT * FROM OUTROS_SERVICOS";
            this.fbCommand9.CommandTimeout = 30;
            this.fbCommand9.Connection = this.fbConnection1;
            // 
            // fbCommand11
            // 
            this.fbCommand11.CommandTimeout = 30;
            // 
            // cbOutrosServicos
            // 
            this.cbOutrosServicos.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbOutrosServicos.DataAdapter = this.datOutrosServicos;
            this.cbOutrosServicos.QuotePrefix = "\"";
            this.cbOutrosServicos.QuoteSuffix = "\"";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(223, 626);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 28);
            this.button2.TabIndex = 97;
            this.button2.Text = "Confirmar Seleção";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // form_outros_serviços
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 666);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tb_descricao);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.dgvMateria_prima);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form_outros_serviços";
            this.Text = "OUTROS SERTVIÇOS";
            this.Load += new System.EventHandler(this.form_outros_serviços_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateria_prima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOutrosServicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OUTROS_SERVICOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMateria_prima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MATERIA_PRIMA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_descricao;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.DataGridView dgvMateria_prima;
        private System.Data.DataSet dsMateria_prima;
        private System.Data.DataTable MATERIA_PRIMA;
        private System.Data.DataColumn COD_MATERIA_PRIMA;
        private System.Data.DataColumn DESCRICAO_MATERIA_PRIMA;
        private System.Data.DataColumn VALOR_KG_MATERIA_PRIMA;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbMateria_prima;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datMateria_prima;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODOUTROSSERVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRICAOOUTROSERVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALOROUTROSERVDataGridViewTextBoxColumn;
        private System.Data.DataSet dsOutrosServicos;
        private System.Data.DataTable OUTROS_SERVICOS;
        private System.Data.DataColumn COD_OUTROS_SERV;
        private System.Data.DataColumn DESCRICAO_OUTRO_SERV;
        private System.Data.DataColumn VALOR_OUTRO_SERV;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter fbDataAdapter1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand8;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand6;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand5;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand7;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datOutrosServicos;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand12;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand10;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand9;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand11;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbOutrosServicos;
        private System.Windows.Forms.Button button2;
        private System.Data.DataColumn dataColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_valor;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PADRAO_ORC_OUTRO_SERV;
    }
}