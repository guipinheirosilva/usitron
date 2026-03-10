namespace Evolucao
{
    partial class form_trava_financeiro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_trava_financeiro));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.datTrava_financeiro = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dgvFechamento = new System.Windows.Forms.DataGridView();
            this.dsTrava_financeiro = new System.Data.DataSet();
            this.TRAVA_FINANCEIRO = new System.Data.DataTable();
            this.COD_TF = new System.Data.DataColumn();
            this.DATA_TF = new System.Data.DataColumn();
            this.RESPONSAVEL_TF = new System.Data.DataColumn();
            this.DATA_TRAVAMENTO_TF = new System.Data.DataColumn();
            this.HORA_TRAVAMENTO_TF = new System.Data.DataColumn();
            this.COD_CC_TF = new System.Data.DataColumn();
            this.DESCRICAO_CC_TF = new System.Data.DataColumn();
            this.button6 = new System.Windows.Forms.Button();
            this.tb_descricao_cc = new System.Windows.Forms.TextBox();
            this.tb_cod_cc = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cbTrava_financeiro = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.dataColumn1 = new System.Data.DataColumn();
            this.cODTFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATATFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rESPONSAVELTFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATATRAVAMENTOTFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORATRAVAMENTOTFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODCCTFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRICAOCCTFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR_TF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFechamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTrava_financeiro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRAVA_FINANCEIRO)).BeginInit();
            this.SuspendLayout();
            // 
            // datTrava_financeiro
            // 
            this.datTrava_financeiro.DeleteCommand = this.fbCommand4;
            this.datTrava_financeiro.InsertCommand = this.fbCommand2;
            this.datTrava_financeiro.SelectCommand = this.fbCommand1;
            this.datTrava_financeiro.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * from trava_financeiro";
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
            // dgvFechamento
            // 
            this.dgvFechamento.AllowUserToAddRows = false;
            this.dgvFechamento.AutoGenerateColumns = false;
            this.dgvFechamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFechamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODTFDataGridViewTextBoxColumn,
            this.dATATFDataGridViewTextBoxColumn,
            this.rESPONSAVELTFDataGridViewTextBoxColumn,
            this.dATATRAVAMENTOTFDataGridViewTextBoxColumn,
            this.hORATRAVAMENTOTFDataGridViewTextBoxColumn,
            this.cODCCTFDataGridViewTextBoxColumn,
            this.dESCRICAOCCTFDataGridViewTextBoxColumn,
            this.VALOR_TF});
            this.dgvFechamento.DataMember = "TRAVA_FINANCEIRO";
            this.dgvFechamento.DataSource = this.dsTrava_financeiro;
            this.dgvFechamento.Location = new System.Drawing.Point(12, 76);
            this.dgvFechamento.Name = "dgvFechamento";
            this.dgvFechamento.Size = new System.Drawing.Size(619, 377);
            this.dgvFechamento.TabIndex = 0;
            // 
            // dsTrava_financeiro
            // 
            this.dsTrava_financeiro.DataSetName = "dsTrava_financeiro";
            this.dsTrava_financeiro.Namespace = "http://www.tempuri.org/dsTrava_financeiro.xsd";
            this.dsTrava_financeiro.Tables.AddRange(new System.Data.DataTable[] {
            this.TRAVA_FINANCEIRO});
            // 
            // TRAVA_FINANCEIRO
            // 
            this.TRAVA_FINANCEIRO.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_TF,
            this.DATA_TF,
            this.RESPONSAVEL_TF,
            this.DATA_TRAVAMENTO_TF,
            this.HORA_TRAVAMENTO_TF,
            this.COD_CC_TF,
            this.DESCRICAO_CC_TF,
            this.dataColumn1});
            this.TRAVA_FINANCEIRO.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_TF"}, true)});
            this.TRAVA_FINANCEIRO.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_TF};
            this.TRAVA_FINANCEIRO.TableName = "TRAVA_FINANCEIRO";
            // 
            // COD_TF
            // 
            this.COD_TF.AllowDBNull = false;
            this.COD_TF.ColumnName = "COD_TF";
            this.COD_TF.DataType = typeof(int);
            // 
            // DATA_TF
            // 
            this.DATA_TF.ColumnName = "DATA_TF";
            this.DATA_TF.DataType = typeof(System.DateTime);
            // 
            // RESPONSAVEL_TF
            // 
            this.RESPONSAVEL_TF.ColumnName = "RESPONSAVEL_TF";
            this.RESPONSAVEL_TF.DataType = typeof(int);
            // 
            // DATA_TRAVAMENTO_TF
            // 
            this.DATA_TRAVAMENTO_TF.ColumnName = "DATA_TRAVAMENTO_TF";
            this.DATA_TRAVAMENTO_TF.DataType = typeof(System.DateTime);
            // 
            // HORA_TRAVAMENTO_TF
            // 
            this.HORA_TRAVAMENTO_TF.ColumnName = "HORA_TRAVAMENTO_TF";
            this.HORA_TRAVAMENTO_TF.DataType = typeof(System.DateTime);
            // 
            // COD_CC_TF
            // 
            this.COD_CC_TF.ColumnName = "COD_CC_TF";
            this.COD_CC_TF.DataType = typeof(int);
            // 
            // DESCRICAO_CC_TF
            // 
            this.DESCRICAO_CC_TF.ColumnName = "DESCRICAO_CC_TF";
            this.DESCRICAO_CC_TF.MaxLength = 200;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(377, 23);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(25, 23);
            this.button6.TabIndex = 69;
            this.button6.Text = "+";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // tb_descricao_cc
            // 
            this.tb_descricao_cc.Location = new System.Drawing.Point(164, 25);
            this.tb_descricao_cc.Name = "tb_descricao_cc";
            this.tb_descricao_cc.Size = new System.Drawing.Size(212, 20);
            this.tb_descricao_cc.TabIndex = 68;
            // 
            // tb_cod_cc
            // 
            this.tb_cod_cc.Location = new System.Drawing.Point(105, 25);
            this.tb_cod_cc.Name = "tb_cod_cc";
            this.tb_cod_cc.Size = new System.Drawing.Size(53, 20);
            this.tb_cod_cc.TabIndex = 67;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 13);
            this.label15.TabIndex = 66;
            this.label15.Text = "Conta Corrente:";
            // 
            // dtInicio
            // 
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicio.Location = new System.Drawing.Point(105, 50);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(95, 20);
            this.dtInicio.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 71;
            this.label1.Text = "Data:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(435, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 47);
            this.button1.TabIndex = 72;
            this.button1.Text = "Inserir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(275, 461);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 73;
            this.button2.Text = "Salvar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbTrava_financeiro
            // 
            this.cbTrava_financeiro.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbTrava_financeiro.DataAdapter = this.datTrava_financeiro;
            this.cbTrava_financeiro.QuotePrefix = "\"";
            this.cbTrava_financeiro.QuoteSuffix = "\"";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "VALOR_TF";
            this.dataColumn1.DataType = typeof(double);
            // 
            // cODTFDataGridViewTextBoxColumn
            // 
            this.cODTFDataGridViewTextBoxColumn.DataPropertyName = "COD_TF";
            this.cODTFDataGridViewTextBoxColumn.HeaderText = "COD_TF";
            this.cODTFDataGridViewTextBoxColumn.Name = "cODTFDataGridViewTextBoxColumn";
            this.cODTFDataGridViewTextBoxColumn.Visible = false;
            // 
            // dATATFDataGridViewTextBoxColumn
            // 
            this.dATATFDataGridViewTextBoxColumn.DataPropertyName = "DATA_TF";
            this.dATATFDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dATATFDataGridViewTextBoxColumn.Name = "dATATFDataGridViewTextBoxColumn";
            this.dATATFDataGridViewTextBoxColumn.Width = 150;
            // 
            // rESPONSAVELTFDataGridViewTextBoxColumn
            // 
            this.rESPONSAVELTFDataGridViewTextBoxColumn.DataPropertyName = "RESPONSAVEL_TF";
            this.rESPONSAVELTFDataGridViewTextBoxColumn.HeaderText = "RESPONSAVEL_TF";
            this.rESPONSAVELTFDataGridViewTextBoxColumn.Name = "rESPONSAVELTFDataGridViewTextBoxColumn";
            this.rESPONSAVELTFDataGridViewTextBoxColumn.Visible = false;
            // 
            // dATATRAVAMENTOTFDataGridViewTextBoxColumn
            // 
            this.dATATRAVAMENTOTFDataGridViewTextBoxColumn.DataPropertyName = "DATA_TRAVAMENTO_TF";
            this.dATATRAVAMENTOTFDataGridViewTextBoxColumn.HeaderText = "DATA_TRAVAMENTO_TF";
            this.dATATRAVAMENTOTFDataGridViewTextBoxColumn.Name = "dATATRAVAMENTOTFDataGridViewTextBoxColumn";
            this.dATATRAVAMENTOTFDataGridViewTextBoxColumn.Visible = false;
            // 
            // hORATRAVAMENTOTFDataGridViewTextBoxColumn
            // 
            this.hORATRAVAMENTOTFDataGridViewTextBoxColumn.DataPropertyName = "HORA_TRAVAMENTO_TF";
            this.hORATRAVAMENTOTFDataGridViewTextBoxColumn.HeaderText = "HORA_TRAVAMENTO_TF";
            this.hORATRAVAMENTOTFDataGridViewTextBoxColumn.Name = "hORATRAVAMENTOTFDataGridViewTextBoxColumn";
            this.hORATRAVAMENTOTFDataGridViewTextBoxColumn.Visible = false;
            // 
            // cODCCTFDataGridViewTextBoxColumn
            // 
            this.cODCCTFDataGridViewTextBoxColumn.DataPropertyName = "COD_CC_TF";
            this.cODCCTFDataGridViewTextBoxColumn.HeaderText = "Cód. CC";
            this.cODCCTFDataGridViewTextBoxColumn.Name = "cODCCTFDataGridViewTextBoxColumn";
            // 
            // dESCRICAOCCTFDataGridViewTextBoxColumn
            // 
            this.dESCRICAOCCTFDataGridViewTextBoxColumn.DataPropertyName = "DESCRICAO_CC_TF";
            this.dESCRICAOCCTFDataGridViewTextBoxColumn.HeaderText = "Descrição CC";
            this.dESCRICAOCCTFDataGridViewTextBoxColumn.Name = "dESCRICAOCCTFDataGridViewTextBoxColumn";
            this.dESCRICAOCCTFDataGridViewTextBoxColumn.Width = 200;
            // 
            // VALOR_TF
            // 
            this.VALOR_TF.DataPropertyName = "VALOR_TF";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.VALOR_TF.DefaultCellStyle = dataGridViewCellStyle2;
            this.VALOR_TF.HeaderText = "Valor";
            this.VALOR_TF.Name = "VALOR_TF";
            // 
            // tbValor
            // 
            this.tbValor.Location = new System.Drawing.Point(261, 51);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(115, 20);
            this.tbValor.TabIndex = 75;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 74;
            this.label2.Text = "Valor:";
            // 
            // form_trava_financeiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 496);
            this.Controls.Add(this.tbValor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtInicio);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.tb_descricao_cc);
            this.Controls.Add(this.tb_cod_cc);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dgvFechamento);
            this.Name = "form_trava_financeiro";
            this.Text = "Fechamento Conta";
            this.Load += new System.EventHandler(this.form_trava_financeiro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFechamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTrava_financeiro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRAVA_FINANCEIRO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datTrava_financeiro;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Windows.Forms.DataGridView dgvFechamento;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox tb_descricao_cc;
        private System.Windows.Forms.TextBox tb_cod_cc;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Data.DataSet dsTrava_financeiro;
        private System.Data.DataTable TRAVA_FINANCEIRO;
        private System.Data.DataColumn COD_TF;
        private System.Data.DataColumn DATA_TF;
        private System.Data.DataColumn RESPONSAVEL_TF;
        private System.Data.DataColumn DATA_TRAVAMENTO_TF;
        private System.Data.DataColumn HORA_TRAVAMENTO_TF;
        private System.Data.DataColumn COD_CC_TF;
        private System.Data.DataColumn DESCRICAO_CC_TF;
        private System.Windows.Forms.Button button2;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbTrava_financeiro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODTFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATATFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rESPONSAVELTFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATATRAVAMENTOTFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORATRAVAMENTOTFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODCCTFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRICAOCCTFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR_TF;
        private System.Data.DataColumn dataColumn1;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.Label label2;
    }
}