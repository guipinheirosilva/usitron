namespace Evolucao
{
    partial class form_consulta_ponto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_consulta_ponto));
            this.button1 = new System.Windows.Forms.Button();
            this.datApontamentos = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsApontamentos = new System.Data.DataSet();
            this.APONTAMENTOS = new System.Data.DataTable();
            this.COD_APONTAMENTO = new System.Data.DataColumn();
            this.OPERADOR_APONTAMENTO = new System.Data.DataColumn();
            this.DATA_ENTRADA_APONTAMENTO = new System.Data.DataColumn();
            this.HORA_ENTRADA_APONTAMENTO = new System.Data.DataColumn();
            this.DATA_FECHAMENTO_APONTAMENTO = new System.Data.DataColumn();
            this.HORA_FECHAMENTO_APONTAMENTO = new System.Data.DataColumn();
            this.HORAS_TOTAIS_APONTAMENTO = new System.Data.DataColumn();
            this.POSICAO_APONTAMENTO = new System.Data.DataColumn();
            this.dgvConsulta_ponto = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dtInicial = new System.Windows.Forms.DateTimePicker();
            this.btIniciar = new System.Windows.Forms.Button();
            this.tb_operador = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.Refazer = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cbApontamentos = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.cODAPONTAMENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPERADORAPONTAMENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_data_entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_hora_entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_data_fechamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_hora_fechamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_saldo_horas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOSICAOAPONTAMENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.tbTotal_horas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtFinal = new System.Windows.Forms.DateTimePicker();
            this.cbUm_dia = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dsApontamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.APONTAMENTOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta_ponto)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(270, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Atualizar Apontamentos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // datApontamentos
            // 
            this.datApontamentos.DeleteCommand = this.fbCommand4;
            this.datApontamentos.InsertCommand = this.fbCommand2;
            this.datApontamentos.SelectCommand = this.fbCommand1;
            this.datApontamentos.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * from apontamentos";
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
            // dsApontamentos
            // 
            this.dsApontamentos.DataSetName = "dsApontamentos";
            this.dsApontamentos.Namespace = "http://www.tempuri.org/dsApontamentos.xsd";
            this.dsApontamentos.Tables.AddRange(new System.Data.DataTable[] {
            this.APONTAMENTOS});
            // 
            // APONTAMENTOS
            // 
            this.APONTAMENTOS.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_APONTAMENTO,
            this.OPERADOR_APONTAMENTO,
            this.DATA_ENTRADA_APONTAMENTO,
            this.HORA_ENTRADA_APONTAMENTO,
            this.DATA_FECHAMENTO_APONTAMENTO,
            this.HORA_FECHAMENTO_APONTAMENTO,
            this.HORAS_TOTAIS_APONTAMENTO,
            this.POSICAO_APONTAMENTO});
            this.APONTAMENTOS.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_APONTAMENTO"}, true)});
            this.APONTAMENTOS.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_APONTAMENTO};
            this.APONTAMENTOS.TableName = "APONTAMENTOS";
            // 
            // COD_APONTAMENTO
            // 
            this.COD_APONTAMENTO.AllowDBNull = false;
            this.COD_APONTAMENTO.ColumnName = "COD_APONTAMENTO";
            this.COD_APONTAMENTO.DataType = typeof(int);
            // 
            // OPERADOR_APONTAMENTO
            // 
            this.OPERADOR_APONTAMENTO.ColumnName = "OPERADOR_APONTAMENTO";
            this.OPERADOR_APONTAMENTO.MaxLength = 10;
            // 
            // DATA_ENTRADA_APONTAMENTO
            // 
            this.DATA_ENTRADA_APONTAMENTO.ColumnName = "DATA_ENTRADA_APONTAMENTO";
            this.DATA_ENTRADA_APONTAMENTO.DataType = typeof(System.DateTime);
            // 
            // HORA_ENTRADA_APONTAMENTO
            // 
            this.HORA_ENTRADA_APONTAMENTO.ColumnName = "HORA_ENTRADA_APONTAMENTO";
            this.HORA_ENTRADA_APONTAMENTO.MaxLength = 30;
            // 
            // DATA_FECHAMENTO_APONTAMENTO
            // 
            this.DATA_FECHAMENTO_APONTAMENTO.ColumnName = "DATA_FECHAMENTO_APONTAMENTO";
            this.DATA_FECHAMENTO_APONTAMENTO.DataType = typeof(System.DateTime);
            // 
            // HORA_FECHAMENTO_APONTAMENTO
            // 
            this.HORA_FECHAMENTO_APONTAMENTO.ColumnName = "HORA_FECHAMENTO_APONTAMENTO";
            this.HORA_FECHAMENTO_APONTAMENTO.MaxLength = 30;
            // 
            // HORAS_TOTAIS_APONTAMENTO
            // 
            this.HORAS_TOTAIS_APONTAMENTO.ColumnName = "HORAS_TOTAIS_APONTAMENTO";
            this.HORAS_TOTAIS_APONTAMENTO.DataType = typeof(double);
            // 
            // POSICAO_APONTAMENTO
            // 
            this.POSICAO_APONTAMENTO.ColumnName = "POSICAO_APONTAMENTO";
            this.POSICAO_APONTAMENTO.MaxLength = 10;
            // 
            // dgvConsulta_ponto
            // 
            this.dgvConsulta_ponto.AutoGenerateColumns = false;
            this.dgvConsulta_ponto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta_ponto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODAPONTAMENTODataGridViewTextBoxColumn,
            this.oPERADORAPONTAMENTODataGridViewTextBoxColumn,
            this.col_data_entrada,
            this.col_hora_entrada,
            this.col_data_fechamento,
            this.col_hora_fechamento,
            this.col_saldo_horas,
            this.pOSICAOAPONTAMENTODataGridViewTextBoxColumn});
            this.dgvConsulta_ponto.DataMember = "APONTAMENTOS";
            this.dgvConsulta_ponto.DataSource = this.dsApontamentos;
            this.dgvConsulta_ponto.Location = new System.Drawing.Point(12, 136);
            this.dgvConsulta_ponto.Name = "dgvConsulta_ponto";
            this.dgvConsulta_ponto.Size = new System.Drawing.Size(552, 192);
            this.dgvConsulta_ponto.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 143;
            this.label1.Text = "Data Inicial:";
            // 
            // dtInicial
            // 
            this.dtInicial.CustomFormat = "";
            this.dtInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicial.Location = new System.Drawing.Point(106, 58);
            this.dtInicial.Name = "dtInicial";
            this.dtInicial.Size = new System.Drawing.Size(158, 20);
            this.dtInicial.TabIndex = 142;
            // 
            // btIniciar
            // 
            this.btIniciar.Location = new System.Drawing.Point(29, 106);
            this.btIniciar.Name = "btIniciar";
            this.btIniciar.Size = new System.Drawing.Size(75, 23);
            this.btIniciar.TabIndex = 160;
            this.btIniciar.Text = "Consultar";
            this.btIniciar.UseVisualStyleBackColor = true;
            this.btIniciar.Click += new System.EventHandler(this.btIniciar_Click);
            // 
            // tb_operador
            // 
            this.tb_operador.Location = new System.Drawing.Point(106, 80);
            this.tb_operador.Name = "tb_operador";
            this.tb_operador.Size = new System.Drawing.Size(62, 20);
            this.tb_operador.TabIndex = 162;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 161;
            this.label7.Text = "Operador:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label20.Location = new System.Drawing.Point(20, 9);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(350, 46);
            this.label20.TabIndex = 163;
            this.label20.Text = "Consulta de Ponto";
            // 
            // Refazer
            // 
            this.Refazer.Location = new System.Drawing.Point(108, 106);
            this.Refazer.Name = "Refazer";
            this.Refazer.Size = new System.Drawing.Size(75, 23);
            this.Refazer.TabIndex = 164;
            this.Refazer.Text = "Refazer";
            this.Refazer.UseVisualStyleBackColor = true;
            this.Refazer.Click += new System.EventHandler(this.Refazer_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(189, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 165;
            this.button2.Text = "Salvar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbApontamentos
            // 
            this.cbApontamentos.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbApontamentos.DataAdapter = this.datApontamentos;
            this.cbApontamentos.QuotePrefix = "\"";
            this.cbApontamentos.QuoteSuffix = "\"";
            // 
            // cODAPONTAMENTODataGridViewTextBoxColumn
            // 
            this.cODAPONTAMENTODataGridViewTextBoxColumn.DataPropertyName = "COD_APONTAMENTO";
            this.cODAPONTAMENTODataGridViewTextBoxColumn.HeaderText = "Código";
            this.cODAPONTAMENTODataGridViewTextBoxColumn.Name = "cODAPONTAMENTODataGridViewTextBoxColumn";
            this.cODAPONTAMENTODataGridViewTextBoxColumn.Width = 50;
            // 
            // oPERADORAPONTAMENTODataGridViewTextBoxColumn
            // 
            this.oPERADORAPONTAMENTODataGridViewTextBoxColumn.DataPropertyName = "OPERADOR_APONTAMENTO";
            this.oPERADORAPONTAMENTODataGridViewTextBoxColumn.HeaderText = "Operador";
            this.oPERADORAPONTAMENTODataGridViewTextBoxColumn.Name = "oPERADORAPONTAMENTODataGridViewTextBoxColumn";
            this.oPERADORAPONTAMENTODataGridViewTextBoxColumn.Width = 80;
            // 
            // col_data_entrada
            // 
            this.col_data_entrada.DataPropertyName = "DATA_ENTRADA_APONTAMENTO";
            this.col_data_entrada.HeaderText = "Data Entrada";
            this.col_data_entrada.Name = "col_data_entrada";
            this.col_data_entrada.Width = 70;
            // 
            // col_hora_entrada
            // 
            this.col_hora_entrada.DataPropertyName = "HORA_ENTRADA_APONTAMENTO";
            this.col_hora_entrada.HeaderText = "Hora Entrada";
            this.col_hora_entrada.Name = "col_hora_entrada";
            this.col_hora_entrada.Width = 70;
            // 
            // col_data_fechamento
            // 
            this.col_data_fechamento.DataPropertyName = "DATA_FECHAMENTO_APONTAMENTO";
            this.col_data_fechamento.HeaderText = "Data Fechamento";
            this.col_data_fechamento.Name = "col_data_fechamento";
            this.col_data_fechamento.Width = 70;
            // 
            // col_hora_fechamento
            // 
            this.col_hora_fechamento.DataPropertyName = "HORA_FECHAMENTO_APONTAMENTO";
            this.col_hora_fechamento.HeaderText = "Hora Fechamento";
            this.col_hora_fechamento.Name = "col_hora_fechamento";
            this.col_hora_fechamento.Width = 70;
            // 
            // col_saldo_horas
            // 
            this.col_saldo_horas.DataPropertyName = "HORAS_TOTAIS_APONTAMENTO";
            this.col_saldo_horas.HeaderText = "Horas Totais";
            this.col_saldo_horas.Name = "col_saldo_horas";
            this.col_saldo_horas.Width = 50;
            // 
            // pOSICAOAPONTAMENTODataGridViewTextBoxColumn
            // 
            this.pOSICAOAPONTAMENTODataGridViewTextBoxColumn.DataPropertyName = "POSICAO_APONTAMENTO";
            this.pOSICAOAPONTAMENTODataGridViewTextBoxColumn.HeaderText = "Posição";
            this.pOSICAOAPONTAMENTODataGridViewTextBoxColumn.Name = "pOSICAOAPONTAMENTODataGridViewTextBoxColumn";
            this.pOSICAOAPONTAMENTODataGridViewTextBoxColumn.Width = 50;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(181, 343);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 25);
            this.label9.TabIndex = 167;
            this.label9.Text = "Tempo Total:";
            // 
            // tbTotal_horas
            // 
            this.tbTotal_horas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotal_horas.Location = new System.Drawing.Point(344, 334);
            this.tbTotal_horas.Name = "tbTotal_horas";
            this.tbTotal_horas.Size = new System.Drawing.Size(220, 38);
            this.tbTotal_horas.TabIndex = 166;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 169;
            this.label2.Text = "Data Final:";
            // 
            // dtFinal
            // 
            this.dtFinal.CustomFormat = "";
            this.dtFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFinal.Location = new System.Drawing.Point(362, 58);
            this.dtFinal.Name = "dtFinal";
            this.dtFinal.Size = new System.Drawing.Size(164, 20);
            this.dtFinal.TabIndex = 168;
            // 
            // cbUm_dia
            // 
            this.cbUm_dia.AutoSize = true;
            this.cbUm_dia.Location = new System.Drawing.Point(205, 84);
            this.cbUm_dia.Name = "cbUm_dia";
            this.cbUm_dia.Size = new System.Drawing.Size(59, 17);
            this.cbUm_dia.TabIndex = 170;
            this.cbUm_dia.Text = "Um dia";
            this.cbUm_dia.UseVisualStyleBackColor = true;
            // 
            // form_consulta_ponto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 380);
            this.Controls.Add(this.cbUm_dia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtFinal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbTotal_horas);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Refazer);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.tb_operador);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btIniciar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtInicial);
            this.Controls.Add(this.dgvConsulta_ponto);
            this.Controls.Add(this.button1);
            this.Name = "form_consulta_ponto";
            this.Text = "Consulta Ponto";
            this.Load += new System.EventHandler(this.form_consulta_ponto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsApontamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.APONTAMENTOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta_ponto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datApontamentos;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Data.DataSet dsApontamentos;
        private System.Data.DataTable APONTAMENTOS;
        private System.Data.DataColumn COD_APONTAMENTO;
        private System.Data.DataColumn OPERADOR_APONTAMENTO;
        private System.Data.DataColumn DATA_ENTRADA_APONTAMENTO;
        private System.Data.DataColumn HORA_ENTRADA_APONTAMENTO;
        private System.Data.DataColumn DATA_FECHAMENTO_APONTAMENTO;
        private System.Data.DataColumn HORA_FECHAMENTO_APONTAMENTO;
        private System.Data.DataColumn HORAS_TOTAIS_APONTAMENTO;
        private System.Data.DataColumn POSICAO_APONTAMENTO;
        private System.Windows.Forms.DataGridView dgvConsulta_ponto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtInicial;
        private System.Windows.Forms.Button btIniciar;
        private System.Windows.Forms.TextBox tb_operador;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button Refazer;
        private System.Windows.Forms.Button button2;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbApontamentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODAPONTAMENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPERADORAPONTAMENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_data_entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_hora_entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_data_fechamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_hora_fechamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_saldo_horas;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOSICAOAPONTAMENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbTotal_horas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtFinal;
        private System.Windows.Forms.CheckBox cbUm_dia;
    }
}