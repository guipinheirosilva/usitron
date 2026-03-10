namespace Evolucao
{
    partial class form_valor_materia_prima
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_valor_materia_prima));
            this.datMateria_prima = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsMateria_prima = new System.Data.DataSet();
            this.MATERIA_PRIMA = new System.Data.DataTable();
            this.COD_MATERIA_PRIMA = new System.Data.DataColumn();
            this.DESCRICAO_MATERIA_PRIMA = new System.Data.DataColumn();
            this.VALOR_KG_MATERIA_PRIMA = new System.Data.DataColumn();
            this.dataColumn1 = new System.Data.DataColumn();
            this.cbMateria_prima = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.dgvMateria_prima = new System.Windows.Forms.DataGridView();
            this.label28 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_descricao = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataColumn2 = new System.Data.DataColumn();
            this.col_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_un = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PADRAO_ORC_MATERIA_PRIMA = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dsMateria_prima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MATERIA_PRIMA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateria_prima)).BeginInit();
            this.SuspendLayout();
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
            this.VALOR_KG_MATERIA_PRIMA,
            this.dataColumn1,
            this.dataColumn2});
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
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "UNIDADE_MATERIA_PRIMA";
            // 
            // cbMateria_prima
            // 
            this.cbMateria_prima.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbMateria_prima.DataAdapter = this.datMateria_prima;
            this.cbMateria_prima.QuotePrefix = "\"";
            this.cbMateria_prima.QuoteSuffix = "\"";
            // 
            // dgvMateria_prima
            // 
            this.dgvMateria_prima.AutoGenerateColumns = false;
            this.dgvMateria_prima.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMateria_prima.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_cod,
            this.col_descricao,
            this.col_un,
            this.col_valor,
            this.PADRAO_ORC_MATERIA_PRIMA});
            this.dgvMateria_prima.DataMember = "MATERIA_PRIMA";
            this.dgvMateria_prima.DataSource = this.dsMateria_prima;
            this.dgvMateria_prima.Location = new System.Drawing.Point(12, 104);
            this.dgvMateria_prima.Name = "dgvMateria_prima";
            this.dgvMateria_prima.Size = new System.Drawing.Size(555, 411);
            this.dgvMateria_prima.TabIndex = 0;
            this.dgvMateria_prima.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMateria_prima_CellDoubleClick);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label28.Location = new System.Drawing.Point(70, 9);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(310, 42);
            this.label28.TabIndex = 90;
            this.label28.Text = "MATÉRIA PRIMA";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(412, 521);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 91;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_descricao
            // 
            this.tb_descricao.Location = new System.Drawing.Point(127, 69);
            this.tb_descricao.Name = "tb_descricao";
            this.tb_descricao.Size = new System.Drawing.Size(196, 20);
            this.tb_descricao.TabIndex = 92;
            this.tb_descricao.TextChanged += new System.EventHandler(this.tb_descricao_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(186, 521);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 23);
            this.button2.TabIndex = 93;
            this.button2.Text = "Confirmar Seleção";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "PADRAO_ORC_MATERIA_PRIMA";
            this.dataColumn2.DataType = typeof(int);
            // 
            // col_cod
            // 
            this.col_cod.DataPropertyName = "COD_MATERIA_PRIMA";
            this.col_cod.HeaderText = "Cód.";
            this.col_cod.Name = "col_cod";
            this.col_cod.Width = 70;
            // 
            // col_descricao
            // 
            this.col_descricao.DataPropertyName = "DESCRICAO_MATERIA_PRIMA";
            this.col_descricao.HeaderText = "Descrição";
            this.col_descricao.Name = "col_descricao";
            this.col_descricao.Width = 200;
            // 
            // col_un
            // 
            this.col_un.DataPropertyName = "UNIDADE_MATERIA_PRIMA";
            this.col_un.HeaderText = "Unidade";
            this.col_un.Name = "col_un";
            this.col_un.Width = 60;
            // 
            // col_valor
            // 
            this.col_valor.DataPropertyName = "VALOR_KG_MATERIA_PRIMA";
            this.col_valor.HeaderText = "Valor";
            this.col_valor.Name = "col_valor";
            // 
            // PADRAO_ORC_MATERIA_PRIMA
            // 
            this.PADRAO_ORC_MATERIA_PRIMA.DataPropertyName = "PADRAO_ORC_MATERIA_PRIMA";
            this.PADRAO_ORC_MATERIA_PRIMA.HeaderText = "Padrão Orc.";
            this.PADRAO_ORC_MATERIA_PRIMA.Name = "PADRAO_ORC_MATERIA_PRIMA";
            this.PADRAO_ORC_MATERIA_PRIMA.Width = 70;
            // 
            // form_valor_materia_prima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 556);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tb_descricao);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.dgvMateria_prima);
            this.Name = "form_valor_materia_prima";
            this.Text = "Valor Matéria Prima";
            this.Load += new System.EventHandler(this.form_valor_materia_prima_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsMateria_prima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MATERIA_PRIMA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateria_prima)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datMateria_prima;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private System.Data.DataSet dsMateria_prima;
        private System.Data.DataTable MATERIA_PRIMA;
        private System.Data.DataColumn COD_MATERIA_PRIMA;
        private System.Data.DataColumn DESCRICAO_MATERIA_PRIMA;
        private System.Data.DataColumn VALOR_KG_MATERIA_PRIMA;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbMateria_prima;
        private System.Windows.Forms.DataGridView dgvMateria_prima;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_descricao;
        private System.Data.DataColumn dataColumn1;
        private System.Windows.Forms.Button button2;
        private System.Data.DataColumn dataColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_un;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_valor;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PADRAO_ORC_MATERIA_PRIMA;
    }
}