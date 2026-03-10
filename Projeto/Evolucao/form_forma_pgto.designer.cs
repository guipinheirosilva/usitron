namespace Evolucao
{
    partial class form_forma_pgto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_forma_pgto));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.datForma_pgto = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsForma_pgto = new System.Data.DataSet();
            this.FORMA_PGTO = new System.Data.DataTable();
            this.COD_FORMA_PGTO = new System.Data.DataColumn();
            this.DESCRICAO_FORMA_PGTO = new System.Data.DataColumn();
            this.N_PARCELAS_FORMA_PGTO = new System.Data.DataColumn();
            this.PRAZO_1_FORMA_PGTO = new System.Data.DataColumn();
            this.PRAZO_2_FORMA_PGTO = new System.Data.DataColumn();
            this.PRAZO_3_FORMA_PGTO = new System.Data.DataColumn();
            this.PRAZO_4_FORMA_PGTO = new System.Data.DataColumn();
            this.PRAZO_5_FORMA_PGTO = new System.Data.DataColumn();
            this.PRAZO_6_FORMA_PGTO = new System.Data.DataColumn();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataColumn7 = new System.Data.DataColumn();
            this.dataColumn8 = new System.Data.DataColumn();
            this.dataColumn9 = new System.Data.DataColumn();
            this.dataColumn10 = new System.Data.DataColumn();
            this.dataColumn11 = new System.Data.DataColumn();
            this.dgvForma_pgto = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.cbForma_pgto = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.col_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_n_parcelas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_prazo_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_prazo_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_prazo_3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_prazo_4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_prazo_5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_prazo_6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_prazo_7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_prazo_8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_prazo_9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_prazo_10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_prazo_11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_prazo_12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO_FORMA_PGTO = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.col_carteira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.but_carteira = new System.Windows.Forms.DataGridViewButtonColumn();
            this.col_cod_cc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.but_cc = new System.Windows.Forms.DataGridViewButtonColumn();
            this.JUROS_FORMA_PGTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dsForma_pgto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FORMA_PGTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvForma_pgto)).BeginInit();
            this.SuspendLayout();
            // 
            // datForma_pgto
            // 
            this.datForma_pgto.DeleteCommand = this.fbCommand4;
            this.datForma_pgto.InsertCommand = this.fbCommand2;
            this.datForma_pgto.SelectCommand = this.fbCommand1;
            this.datForma_pgto.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * from forma_pgto";
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
            // dsForma_pgto
            // 
            this.dsForma_pgto.DataSetName = "dsForma_pgto";
            this.dsForma_pgto.Namespace = "http://www.tempuri.org/dsForma_pgto.xsd";
            this.dsForma_pgto.Tables.AddRange(new System.Data.DataTable[] {
            this.FORMA_PGTO});
            // 
            // FORMA_PGTO
            // 
            this.FORMA_PGTO.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_FORMA_PGTO,
            this.DESCRICAO_FORMA_PGTO,
            this.N_PARCELAS_FORMA_PGTO,
            this.PRAZO_1_FORMA_PGTO,
            this.PRAZO_2_FORMA_PGTO,
            this.PRAZO_3_FORMA_PGTO,
            this.PRAZO_4_FORMA_PGTO,
            this.PRAZO_5_FORMA_PGTO,
            this.PRAZO_6_FORMA_PGTO,
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn6,
            this.dataColumn7,
            this.dataColumn8,
            this.dataColumn9,
            this.dataColumn10,
            this.dataColumn11});
            this.FORMA_PGTO.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_FORMA_PGTO"}, true)});
            this.FORMA_PGTO.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_FORMA_PGTO};
            this.FORMA_PGTO.TableName = "FORMA_PGTO";
            // 
            // COD_FORMA_PGTO
            // 
            this.COD_FORMA_PGTO.AllowDBNull = false;
            this.COD_FORMA_PGTO.AutoIncrement = true;
            this.COD_FORMA_PGTO.AutoIncrementSeed = ((long)(1));
            this.COD_FORMA_PGTO.ColumnName = "COD_FORMA_PGTO";
            this.COD_FORMA_PGTO.DataType = typeof(int);
            // 
            // DESCRICAO_FORMA_PGTO
            // 
            this.DESCRICAO_FORMA_PGTO.ColumnName = "DESCRICAO_FORMA_PGTO";
            this.DESCRICAO_FORMA_PGTO.MaxLength = 100;
            // 
            // N_PARCELAS_FORMA_PGTO
            // 
            this.N_PARCELAS_FORMA_PGTO.ColumnName = "N_PARCELAS_FORMA_PGTO";
            this.N_PARCELAS_FORMA_PGTO.DataType = typeof(int);
            // 
            // PRAZO_1_FORMA_PGTO
            // 
            this.PRAZO_1_FORMA_PGTO.ColumnName = "PRAZO_1_FORMA_PGTO";
            this.PRAZO_1_FORMA_PGTO.DataType = typeof(int);
            // 
            // PRAZO_2_FORMA_PGTO
            // 
            this.PRAZO_2_FORMA_PGTO.ColumnName = "PRAZO_2_FORMA_PGTO";
            this.PRAZO_2_FORMA_PGTO.DataType = typeof(int);
            // 
            // PRAZO_3_FORMA_PGTO
            // 
            this.PRAZO_3_FORMA_PGTO.ColumnName = "PRAZO_3_FORMA_PGTO";
            this.PRAZO_3_FORMA_PGTO.DataType = typeof(int);
            // 
            // PRAZO_4_FORMA_PGTO
            // 
            this.PRAZO_4_FORMA_PGTO.ColumnName = "PRAZO_4_FORMA_PGTO";
            this.PRAZO_4_FORMA_PGTO.DataType = typeof(int);
            // 
            // PRAZO_5_FORMA_PGTO
            // 
            this.PRAZO_5_FORMA_PGTO.ColumnName = "PRAZO_5_FORMA_PGTO";
            this.PRAZO_5_FORMA_PGTO.DataType = typeof(int);
            // 
            // PRAZO_6_FORMA_PGTO
            // 
            this.PRAZO_6_FORMA_PGTO.ColumnName = "PRAZO_6_FORMA_PGTO";
            this.PRAZO_6_FORMA_PGTO.DataType = typeof(int);
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "TIPO_FORMA_PGTO";
            this.dataColumn1.MaxLength = 100;
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "CARTEIRA_FORMA_PGTO";
            this.dataColumn2.MaxLength = 100;
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "CC_FORMA_PGTO";
            this.dataColumn3.MaxLength = 100;
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "COD_CC_FORMA_PGTO";
            this.dataColumn4.DataType = typeof(int);
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "JUROS_FORMA_PGTO";
            this.dataColumn5.DataType = typeof(double);
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "PRAZO_7_FORMA_PGTO";
            this.dataColumn6.DataType = typeof(int);
            // 
            // dataColumn7
            // 
            this.dataColumn7.Caption = "PRAZO_8_FORMA_PGTO";
            this.dataColumn7.ColumnName = "PRAZO_8_FORMA_PGTO";
            this.dataColumn7.DataType = typeof(int);
            // 
            // dataColumn8
            // 
            this.dataColumn8.ColumnName = "PRAZO_9_FORMA_PGTO";
            this.dataColumn8.DataType = typeof(int);
            // 
            // dataColumn9
            // 
            this.dataColumn9.ColumnName = "PRAZO_10_FORMA_PGTO";
            this.dataColumn9.DataType = typeof(int);
            // 
            // dataColumn10
            // 
            this.dataColumn10.ColumnName = "PRAZO_11_FORMA_PGTO";
            this.dataColumn10.DataType = typeof(int);
            // 
            // dataColumn11
            // 
            this.dataColumn11.ColumnName = "PRAZO_12_FORMA_PGTO";
            this.dataColumn11.DataType = typeof(int);
            // 
            // dgvForma_pgto
            // 
            this.dgvForma_pgto.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvForma_pgto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvForma_pgto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvForma_pgto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_cod,
            this.col_descricao,
            this.col_n_parcelas,
            this.col_prazo_1,
            this.col_prazo_2,
            this.col_prazo_3,
            this.col_prazo_4,
            this.col_prazo_5,
            this.col_prazo_6,
            this.col_prazo_7,
            this.col_prazo_8,
            this.col_prazo_9,
            this.col_prazo_10,
            this.col_prazo_11,
            this.col_prazo_12,
            this.TIPO_FORMA_PGTO,
            this.col_carteira,
            this.but_carteira,
            this.col_cod_cc,
            this.col_cc,
            this.but_cc,
            this.JUROS_FORMA_PGTO});
            this.dgvForma_pgto.DataMember = "FORMA_PGTO";
            this.dgvForma_pgto.DataSource = this.dsForma_pgto;
            this.dgvForma_pgto.Location = new System.Drawing.Point(12, 102);
            this.dgvForma_pgto.Name = "dgvForma_pgto";
            this.dgvForma_pgto.Size = new System.Drawing.Size(1090, 299);
            this.dgvForma_pgto.TabIndex = 0;
            this.dgvForma_pgto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvForma_pgto_CellClick);
            this.dgvForma_pgto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvForma_pgto_CellContentClick);
            this.dgvForma_pgto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvForma_pgto_CellDoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(439, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 26);
            this.button1.TabIndex = 1;
            this.button1.Text = "Salvar Alterações";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label28.Location = new System.Drawing.Point(358, 9);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(331, 42);
            this.label28.TabIndex = 89;
            this.label28.Text = "FORMA DE PGTO";
            // 
            // cbForma_pgto
            // 
            this.cbForma_pgto.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbForma_pgto.DataAdapter = this.datForma_pgto;
            this.cbForma_pgto.QuotePrefix = "\"";
            this.cbForma_pgto.QuoteSuffix = "\"";
            // 
            // col_cod
            // 
            this.col_cod.DataPropertyName = "COD_FORMA_PGTO";
            this.col_cod.HeaderText = "Cód.";
            this.col_cod.Name = "col_cod";
            this.col_cod.Width = 40;
            // 
            // col_descricao
            // 
            this.col_descricao.DataPropertyName = "DESCRICAO_FORMA_PGTO";
            this.col_descricao.HeaderText = "Descrição";
            this.col_descricao.Name = "col_descricao";
            this.col_descricao.Width = 250;
            // 
            // col_n_parcelas
            // 
            this.col_n_parcelas.DataPropertyName = "N_PARCELAS_FORMA_PGTO";
            this.col_n_parcelas.HeaderText = "nº Parc";
            this.col_n_parcelas.Name = "col_n_parcelas";
            this.col_n_parcelas.Width = 40;
            // 
            // col_prazo_1
            // 
            this.col_prazo_1.DataPropertyName = "PRAZO_1_FORMA_PGTO";
            this.col_prazo_1.HeaderText = "Prazo 1";
            this.col_prazo_1.Name = "col_prazo_1";
            this.col_prazo_1.Width = 40;
            // 
            // col_prazo_2
            // 
            this.col_prazo_2.DataPropertyName = "PRAZO_2_FORMA_PGTO";
            this.col_prazo_2.HeaderText = "Prazo 2";
            this.col_prazo_2.Name = "col_prazo_2";
            this.col_prazo_2.Width = 40;
            // 
            // col_prazo_3
            // 
            this.col_prazo_3.DataPropertyName = "PRAZO_3_FORMA_PGTO";
            this.col_prazo_3.HeaderText = "Prazo 3";
            this.col_prazo_3.Name = "col_prazo_3";
            this.col_prazo_3.Width = 40;
            // 
            // col_prazo_4
            // 
            this.col_prazo_4.DataPropertyName = "PRAZO_4_FORMA_PGTO";
            this.col_prazo_4.HeaderText = "Prazo 4";
            this.col_prazo_4.Name = "col_prazo_4";
            this.col_prazo_4.Width = 40;
            // 
            // col_prazo_5
            // 
            this.col_prazo_5.DataPropertyName = "PRAZO_5_FORMA_PGTO";
            this.col_prazo_5.HeaderText = "Prazo 5";
            this.col_prazo_5.Name = "col_prazo_5";
            this.col_prazo_5.Width = 40;
            // 
            // col_prazo_6
            // 
            this.col_prazo_6.DataPropertyName = "PRAZO_6_FORMA_PGTO";
            this.col_prazo_6.HeaderText = "Prazo 6";
            this.col_prazo_6.Name = "col_prazo_6";
            this.col_prazo_6.Width = 40;
            // 
            // col_prazo_7
            // 
            this.col_prazo_7.DataPropertyName = "PRAZO_7_FORMA_PGTO";
            this.col_prazo_7.HeaderText = "Prazo 7";
            this.col_prazo_7.Name = "col_prazo_7";
            this.col_prazo_7.Width = 40;
            // 
            // col_prazo_8
            // 
            this.col_prazo_8.DataPropertyName = "PRAZO_8_FORMA_PGTO";
            this.col_prazo_8.HeaderText = "Prazo 8";
            this.col_prazo_8.Name = "col_prazo_8";
            this.col_prazo_8.Width = 40;
            // 
            // col_prazo_9
            // 
            this.col_prazo_9.DataPropertyName = "PRAZO_9_FORMA_PGTO";
            this.col_prazo_9.HeaderText = "Prazo 9";
            this.col_prazo_9.Name = "col_prazo_9";
            this.col_prazo_9.Width = 40;
            // 
            // col_prazo_10
            // 
            this.col_prazo_10.DataPropertyName = "PRAZO_10_FORMA_PGTO";
            this.col_prazo_10.HeaderText = "Prazo 10";
            this.col_prazo_10.Name = "col_prazo_10";
            this.col_prazo_10.Width = 40;
            // 
            // col_prazo_11
            // 
            this.col_prazo_11.DataPropertyName = "PRAZO_11_FORMA_PGTO";
            this.col_prazo_11.HeaderText = "Prazo 11";
            this.col_prazo_11.Name = "col_prazo_11";
            this.col_prazo_11.Width = 40;
            // 
            // col_prazo_12
            // 
            this.col_prazo_12.DataPropertyName = "PRAZO_12_FORMA_PGTO";
            this.col_prazo_12.HeaderText = "Prazo 12";
            this.col_prazo_12.Name = "col_prazo_12";
            this.col_prazo_12.Width = 40;
            // 
            // TIPO_FORMA_PGTO
            // 
            this.TIPO_FORMA_PGTO.DataPropertyName = "TIPO_FORMA_PGTO";
            this.TIPO_FORMA_PGTO.HeaderText = "Tipo";
            this.TIPO_FORMA_PGTO.Items.AddRange(new object[] {
            "DINHEIRO",
            "DEPOSITO",
            "CARTAO",
            "BOLETO",
            "CHEQUE",
            "MARCAR",
            "OUTROS",
            "ATIVA"});
            this.TIPO_FORMA_PGTO.Name = "TIPO_FORMA_PGTO";
            // 
            // col_carteira
            // 
            this.col_carteira.DataPropertyName = "CARTEIRA_FORMA_PGTO";
            this.col_carteira.HeaderText = "Carteira";
            this.col_carteira.Name = "col_carteira";
            this.col_carteira.ReadOnly = true;
            this.col_carteira.Visible = false;
            this.col_carteira.Width = 80;
            // 
            // but_carteira
            // 
            this.but_carteira.HeaderText = "Carteira";
            this.but_carteira.Name = "but_carteira";
            this.but_carteira.Text = "Carteira";
            this.but_carteira.ToolTipText = "Carteira";
            this.but_carteira.UseColumnTextForButtonValue = true;
            this.but_carteira.Visible = false;
            this.but_carteira.Width = 60;
            // 
            // col_cod_cc
            // 
            this.col_cod_cc.DataPropertyName = "COD_CC_FORMA_PGTO";
            this.col_cod_cc.HeaderText = "COD_CC_FORMA_PGTO";
            this.col_cod_cc.Name = "col_cod_cc";
            this.col_cod_cc.Visible = false;
            // 
            // col_cc
            // 
            this.col_cc.DataPropertyName = "CC_FORMA_PGTO";
            this.col_cc.HeaderText = "C/C";
            this.col_cc.Name = "col_cc";
            this.col_cc.ReadOnly = true;
            this.col_cc.Visible = false;
            this.col_cc.Width = 80;
            // 
            // but_cc
            // 
            this.but_cc.HeaderText = "C/C";
            this.but_cc.Name = "but_cc";
            this.but_cc.Text = "C/C";
            this.but_cc.ToolTipText = "C/C";
            this.but_cc.UseColumnTextForButtonValue = true;
            this.but_cc.Visible = false;
            this.but_cc.Width = 60;
            // 
            // JUROS_FORMA_PGTO
            // 
            this.JUROS_FORMA_PGTO.DataPropertyName = "JUROS_FORMA_PGTO";
            this.JUROS_FORMA_PGTO.HeaderText = "% Juros";
            this.JUROS_FORMA_PGTO.Name = "JUROS_FORMA_PGTO";
            this.JUROS_FORMA_PGTO.Visible = false;
            this.JUROS_FORMA_PGTO.Width = 70;
            // 
            // form_forma_pgto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 413);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvForma_pgto);
            this.Name = "form_forma_pgto";
            this.Text = "Forma de Pagamento";
            this.Load += new System.EventHandler(this.form_forma_pgto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsForma_pgto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FORMA_PGTO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvForma_pgto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datForma_pgto;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Data.DataSet dsForma_pgto;
        private System.Data.DataTable FORMA_PGTO;
        private System.Data.DataColumn COD_FORMA_PGTO;
        private System.Data.DataColumn DESCRICAO_FORMA_PGTO;
        private System.Data.DataColumn N_PARCELAS_FORMA_PGTO;
        private System.Data.DataColumn PRAZO_1_FORMA_PGTO;
        private System.Data.DataColumn PRAZO_2_FORMA_PGTO;
        private System.Data.DataColumn PRAZO_3_FORMA_PGTO;
        private System.Data.DataColumn PRAZO_4_FORMA_PGTO;
        private System.Data.DataColumn PRAZO_5_FORMA_PGTO;
        private System.Data.DataColumn PRAZO_6_FORMA_PGTO;
        private System.Windows.Forms.DataGridView dgvForma_pgto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label28;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbForma_pgto;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Data.DataColumn dataColumn7;
        private System.Data.DataColumn dataColumn8;
        private System.Data.DataColumn dataColumn9;
        private System.Data.DataColumn dataColumn10;
        private System.Data.DataColumn dataColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_n_parcelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_prazo_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_prazo_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_prazo_3;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_prazo_4;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_prazo_5;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_prazo_6;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_prazo_7;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_prazo_8;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_prazo_9;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_prazo_10;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_prazo_11;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_prazo_12;
        private System.Windows.Forms.DataGridViewComboBoxColumn TIPO_FORMA_PGTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_carteira;
        private System.Windows.Forms.DataGridViewButtonColumn but_carteira;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod_cc;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cc;
        private System.Windows.Forms.DataGridViewButtonColumn but_cc;
        private System.Windows.Forms.DataGridViewTextBoxColumn JUROS_FORMA_PGTO;
    }
}