namespace Evolucao
{
    partial class form_maquinas_rodando
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_maquinas_rodando));
            this.label10 = new System.Windows.Forms.Label();
            this.dgvMaquinas_trabalhando = new System.Windows.Forms.DataGridView();
            this.datMaquina_rodando = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.dsMaquina_rodando = new System.Data.DataSet();
            this.MAQUINA_RODANDO = new System.Data.DataTable();
            this.COD_MAQUINA_RODANDO = new System.Data.DataColumn();
            this.MAQUINA_ATUAL = new System.Data.DataColumn();
            this.DATA_MAQUINA_TRABALHANDO = new System.Data.DataColumn();
            this.ROTA_MAQUINA_RODANDO = new System.Data.DataColumn();
            this.OPERADOR_MAQUINA_RODANDO = new System.Data.DataColumn();
            this.HORAS_TRABALHADAS_MAQUINA = new System.Data.DataColumn();
            this.OS_MAQUINA_RODANDO = new System.Data.DataColumn();
            this.bt_inserir = new System.Windows.Forms.Button();
            this.datRotas_campo = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand5 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand6 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand7 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand8 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsRotas_campo = new System.Data.DataSet();
            this.ROTAS_CAMPO = new System.Data.DataTable();
            this.COD_ROTA_CAMPO = new System.Data.DataColumn();
            this.COD_NUM_ROTAS = new System.Data.DataColumn();
            this.COD_ROTA_PECA = new System.Data.DataColumn();
            this.OBSERVACAO_CAMPO = new System.Data.DataColumn();
            this.DESENHO_CAMPO = new System.Data.DataColumn();
            this.POSICAO_FILA_CAMPO = new System.Data.DataColumn();
            this.HORA_ENTRADA = new System.Data.DataColumn();
            this.DATA_ENTRADA = new System.Data.DataColumn();
            this.HORA_FECHAMENTO = new System.Data.DataColumn();
            this.DATA_FECHAMENTO = new System.Data.DataColumn();
            this.POSICAO_ATUAL = new System.Data.DataColumn();
            this.PREVISAO_PRODUCAO = new System.Data.DataColumn();
            this.PECAS_PRODUZIDAS = new System.Data.DataColumn();
            this.FINALIZADO = new System.Data.DataColumn();
            this.OPERADOR_CAMPO = new System.Data.DataColumn();
            this.OP_ROTA = new System.Data.DataColumn();
            this.OPERACAO_CAMPO = new System.Data.DataColumn();
            this.N_PDF_CAMPO = new System.Data.DataColumn();
            this.MAQUINA = new System.Data.DataColumn();
            this.DATA_ENTRADA_PREV = new System.Data.DataColumn();
            this.DATA_FECHAMENTO_PREV = new System.Data.DataColumn();
            this.OPERADOR_FINALIZADOR = new System.Data.DataColumn();
            this.HORAS_TOTAIS_ROTA = new System.Data.DataColumn();
            this.HORAS_PARADAS = new System.Data.DataColumn();
            this.SALDO_HORAS = new System.Data.DataColumn();
            this.OS_CONJUNTAS = new System.Data.DataColumn();
            this.RETRABALHO_ROTA = new System.Data.DataColumn();
            this.HORAS_OPERADOR = new System.Data.DataColumn();
            this.MAQUINA_FECHAMENTO = new System.Data.DataColumn();
            this.OS_CONJUNTAS_FECHAMENTO = new System.Data.DataColumn();
            this.HORAS_MAQUINA_RODANDO = new System.Data.DataColumn();
            this.cODMAQUINARODANDODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAQUINAATUALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAMAQUINATRABALHANDODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_rota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPERADORMAQUINARODANDODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_horas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oSMAQUINARODANDODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaquinas_trabalhando)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaquina_rodando)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MAQUINA_RODANDO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRotas_campo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ROTAS_CAMPO)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(17, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(171, 20);
            this.label10.TabIndex = 173;
            this.label10.Text = "Máquinas Trabalhando";
            // 
            // dgvMaquinas_trabalhando
            // 
            this.dgvMaquinas_trabalhando.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMaquinas_trabalhando.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMaquinas_trabalhando.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaquinas_trabalhando.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODMAQUINARODANDODataGridViewTextBoxColumn,
            this.mAQUINAATUALDataGridViewTextBoxColumn,
            this.dATAMAQUINATRABALHANDODataGridViewTextBoxColumn,
            this.col_rota,
            this.oPERADORMAQUINARODANDODataGridViewTextBoxColumn,
            this.col_horas,
            this.oSMAQUINARODANDODataGridViewTextBoxColumn});
            this.dgvMaquinas_trabalhando.DataMember = "MAQUINA_RODANDO";
            this.dgvMaquinas_trabalhando.DataSource = this.dsMaquina_rodando;
            this.dgvMaquinas_trabalhando.Location = new System.Drawing.Point(21, 102);
            this.dgvMaquinas_trabalhando.Name = "dgvMaquinas_trabalhando";
            this.dgvMaquinas_trabalhando.Size = new System.Drawing.Size(428, 83);
            this.dgvMaquinas_trabalhando.TabIndex = 172;
            // 
            // datMaquina_rodando
            // 
            this.datMaquina_rodando.DeleteCommand = this.fbCommand4;
            this.datMaquina_rodando.InsertCommand = this.fbCommand2;
            this.datMaquina_rodando.SelectCommand = this.fbCommand1;
            this.datMaquina_rodando.UpdateCommand = this.fbCommand3;
            // 
            // fbCommand1
            // 
            this.fbCommand1.CommandText = "select * from maquina_rodando";
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
            // fbConnection1
            // 
            this.fbConnection1.ConnectionString = resources.GetString("fbConnection1.ConnectionString");
            // 
            // dsMaquina_rodando
            // 
            this.dsMaquina_rodando.DataSetName = "dsMaquina_rodando";
            this.dsMaquina_rodando.Namespace = "http://www.tempuri.org/dsMaquina_rodando.xsd";
            this.dsMaquina_rodando.Tables.AddRange(new System.Data.DataTable[] {
            this.MAQUINA_RODANDO});
            // 
            // MAQUINA_RODANDO
            // 
            this.MAQUINA_RODANDO.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_MAQUINA_RODANDO,
            this.MAQUINA_ATUAL,
            this.DATA_MAQUINA_TRABALHANDO,
            this.ROTA_MAQUINA_RODANDO,
            this.OPERADOR_MAQUINA_RODANDO,
            this.HORAS_TRABALHADAS_MAQUINA,
            this.OS_MAQUINA_RODANDO});
            this.MAQUINA_RODANDO.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_MAQUINA_RODANDO"}, true)});
            this.MAQUINA_RODANDO.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_MAQUINA_RODANDO};
            this.MAQUINA_RODANDO.TableName = "MAQUINA_RODANDO";
            // 
            // COD_MAQUINA_RODANDO
            // 
            this.COD_MAQUINA_RODANDO.AllowDBNull = false;
            this.COD_MAQUINA_RODANDO.ColumnName = "COD_MAQUINA_RODANDO";
            this.COD_MAQUINA_RODANDO.DataType = typeof(int);
            // 
            // MAQUINA_ATUAL
            // 
            this.MAQUINA_ATUAL.ColumnName = "MAQUINA_ATUAL";
            this.MAQUINA_ATUAL.MaxLength = 30;
            // 
            // DATA_MAQUINA_TRABALHANDO
            // 
            this.DATA_MAQUINA_TRABALHANDO.ColumnName = "DATA_MAQUINA_TRABALHANDO";
            this.DATA_MAQUINA_TRABALHANDO.DataType = typeof(System.DateTime);
            // 
            // ROTA_MAQUINA_RODANDO
            // 
            this.ROTA_MAQUINA_RODANDO.ColumnName = "ROTA_MAQUINA_RODANDO";
            this.ROTA_MAQUINA_RODANDO.DataType = typeof(int);
            // 
            // OPERADOR_MAQUINA_RODANDO
            // 
            this.OPERADOR_MAQUINA_RODANDO.ColumnName = "OPERADOR_MAQUINA_RODANDO";
            this.OPERADOR_MAQUINA_RODANDO.MaxLength = 30;
            // 
            // HORAS_TRABALHADAS_MAQUINA
            // 
            this.HORAS_TRABALHADAS_MAQUINA.ColumnName = "HORAS_TRABALHADAS_MAQUINA";
            this.HORAS_TRABALHADAS_MAQUINA.DataType = typeof(double);
            // 
            // OS_MAQUINA_RODANDO
            // 
            this.OS_MAQUINA_RODANDO.ColumnName = "OS_MAQUINA_RODANDO";
            this.OS_MAQUINA_RODANDO.MaxLength = 30;
            // 
            // bt_inserir
            // 
            this.bt_inserir.Location = new System.Drawing.Point(182, 218);
            this.bt_inserir.Name = "bt_inserir";
            this.bt_inserir.Size = new System.Drawing.Size(99, 23);
            this.bt_inserir.TabIndex = 174;
            this.bt_inserir.Text = "Inserir nas rotas";
            this.bt_inserir.UseVisualStyleBackColor = true;
            this.bt_inserir.Click += new System.EventHandler(this.bt_inserir_Click);
            // 
            // datRotas_campo
            // 
            this.datRotas_campo.DeleteCommand = this.fbCommand8;
            this.datRotas_campo.InsertCommand = this.fbCommand6;
            this.datRotas_campo.SelectCommand = this.fbCommand5;
            this.datRotas_campo.UpdateCommand = this.fbCommand7;
            // 
            // fbCommand5
            // 
            this.fbCommand5.CommandText = "select * from rotas_campo";
            this.fbCommand5.CommandTimeout = 30;
            this.fbCommand5.Connection = this.fbConnection1;
            // 
            // fbCommand6
            // 
            this.fbCommand6.CommandTimeout = 30;
            // 
            // fbCommand7
            // 
            this.fbCommand7.CommandTimeout = 30;
            // 
            // fbCommand8
            // 
            this.fbCommand8.CommandTimeout = 30;
            // 
            // dsRotas_campo
            // 
            this.dsRotas_campo.DataSetName = "dsRotas_campo";
            this.dsRotas_campo.Namespace = "http://www.tempuri.org/dsRotas_campo.xsd";
            this.dsRotas_campo.Tables.AddRange(new System.Data.DataTable[] {
            this.ROTAS_CAMPO});
            // 
            // ROTAS_CAMPO
            // 
            this.ROTAS_CAMPO.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_ROTA_CAMPO,
            this.COD_NUM_ROTAS,
            this.COD_ROTA_PECA,
            this.OBSERVACAO_CAMPO,
            this.DESENHO_CAMPO,
            this.POSICAO_FILA_CAMPO,
            this.HORA_ENTRADA,
            this.DATA_ENTRADA,
            this.HORA_FECHAMENTO,
            this.DATA_FECHAMENTO,
            this.POSICAO_ATUAL,
            this.PREVISAO_PRODUCAO,
            this.PECAS_PRODUZIDAS,
            this.FINALIZADO,
            this.OPERADOR_CAMPO,
            this.OP_ROTA,
            this.OPERACAO_CAMPO,
            this.N_PDF_CAMPO,
            this.MAQUINA,
            this.DATA_ENTRADA_PREV,
            this.DATA_FECHAMENTO_PREV,
            this.OPERADOR_FINALIZADOR,
            this.HORAS_TOTAIS_ROTA,
            this.HORAS_PARADAS,
            this.SALDO_HORAS,
            this.OS_CONJUNTAS,
            this.RETRABALHO_ROTA,
            this.HORAS_OPERADOR,
            this.MAQUINA_FECHAMENTO,
            this.OS_CONJUNTAS_FECHAMENTO,
            this.HORAS_MAQUINA_RODANDO});
            this.ROTAS_CAMPO.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_ROTA_CAMPO"}, true)});
            this.ROTAS_CAMPO.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_ROTA_CAMPO};
            this.ROTAS_CAMPO.TableName = "ROTAS_CAMPO";
            // 
            // COD_ROTA_CAMPO
            // 
            this.COD_ROTA_CAMPO.AllowDBNull = false;
            this.COD_ROTA_CAMPO.ColumnName = "COD_ROTA_CAMPO";
            this.COD_ROTA_CAMPO.DataType = typeof(int);
            // 
            // COD_NUM_ROTAS
            // 
            this.COD_NUM_ROTAS.ColumnName = "COD_NUM_ROTAS";
            this.COD_NUM_ROTAS.MaxLength = 10;
            // 
            // COD_ROTA_PECA
            // 
            this.COD_ROTA_PECA.ColumnName = "COD_ROTA_PECA";
            this.COD_ROTA_PECA.MaxLength = 40;
            // 
            // OBSERVACAO_CAMPO
            // 
            this.OBSERVACAO_CAMPO.ColumnName = "OBSERVACAO_CAMPO";
            this.OBSERVACAO_CAMPO.MaxLength = 100;
            // 
            // DESENHO_CAMPO
            // 
            this.DESENHO_CAMPO.ColumnName = "DESENHO_CAMPO";
            this.DESENHO_CAMPO.MaxLength = 40;
            // 
            // POSICAO_FILA_CAMPO
            // 
            this.POSICAO_FILA_CAMPO.ColumnName = "POSICAO_FILA_CAMPO";
            this.POSICAO_FILA_CAMPO.MaxLength = 4;
            // 
            // HORA_ENTRADA
            // 
            this.HORA_ENTRADA.ColumnName = "HORA_ENTRADA";
            this.HORA_ENTRADA.MaxLength = 20;
            // 
            // DATA_ENTRADA
            // 
            this.DATA_ENTRADA.ColumnName = "DATA_ENTRADA";
            this.DATA_ENTRADA.DataType = typeof(System.DateTime);
            // 
            // HORA_FECHAMENTO
            // 
            this.HORA_FECHAMENTO.ColumnName = "HORA_FECHAMENTO";
            this.HORA_FECHAMENTO.MaxLength = 20;
            // 
            // DATA_FECHAMENTO
            // 
            this.DATA_FECHAMENTO.ColumnName = "DATA_FECHAMENTO";
            this.DATA_FECHAMENTO.DataType = typeof(System.DateTime);
            // 
            // POSICAO_ATUAL
            // 
            this.POSICAO_ATUAL.ColumnName = "POSICAO_ATUAL";
            this.POSICAO_ATUAL.MaxLength = 50;
            // 
            // PREVISAO_PRODUCAO
            // 
            this.PREVISAO_PRODUCAO.ColumnName = "PREVISAO_PRODUCAO";
            this.PREVISAO_PRODUCAO.DataType = typeof(int);
            // 
            // PECAS_PRODUZIDAS
            // 
            this.PECAS_PRODUZIDAS.ColumnName = "PECAS_PRODUZIDAS";
            this.PECAS_PRODUZIDAS.DataType = typeof(int);
            // 
            // FINALIZADO
            // 
            this.FINALIZADO.ColumnName = "FINALIZADO";
            this.FINALIZADO.MaxLength = 10;
            // 
            // OPERADOR_CAMPO
            // 
            this.OPERADOR_CAMPO.ColumnName = "OPERADOR_CAMPO";
            this.OPERADOR_CAMPO.MaxLength = 10;
            // 
            // OP_ROTA
            // 
            this.OP_ROTA.ColumnName = "OP_ROTA";
            this.OP_ROTA.DataType = typeof(int);
            // 
            // OPERACAO_CAMPO
            // 
            this.OPERACAO_CAMPO.ColumnName = "OPERACAO_CAMPO";
            this.OPERACAO_CAMPO.MaxLength = 40;
            // 
            // N_PDF_CAMPO
            // 
            this.N_PDF_CAMPO.ColumnName = "N_PDF_CAMPO";
            this.N_PDF_CAMPO.MaxLength = 40;
            // 
            // MAQUINA
            // 
            this.MAQUINA.ColumnName = "MAQUINA";
            this.MAQUINA.MaxLength = 20;
            // 
            // DATA_ENTRADA_PREV
            // 
            this.DATA_ENTRADA_PREV.ColumnName = "DATA_ENTRADA_PREV";
            this.DATA_ENTRADA_PREV.DataType = typeof(System.DateTime);
            // 
            // DATA_FECHAMENTO_PREV
            // 
            this.DATA_FECHAMENTO_PREV.ColumnName = "DATA_FECHAMENTO_PREV";
            this.DATA_FECHAMENTO_PREV.DataType = typeof(System.DateTime);
            // 
            // OPERADOR_FINALIZADOR
            // 
            this.OPERADOR_FINALIZADOR.ColumnName = "OPERADOR_FINALIZADOR";
            this.OPERADOR_FINALIZADOR.MaxLength = 30;
            // 
            // HORAS_TOTAIS_ROTA
            // 
            this.HORAS_TOTAIS_ROTA.ColumnName = "HORAS_TOTAIS_ROTA";
            this.HORAS_TOTAIS_ROTA.DataType = typeof(double);
            // 
            // HORAS_PARADAS
            // 
            this.HORAS_PARADAS.ColumnName = "HORAS_PARADAS";
            this.HORAS_PARADAS.DataType = typeof(double);
            // 
            // SALDO_HORAS
            // 
            this.SALDO_HORAS.ColumnName = "SALDO_HORAS";
            this.SALDO_HORAS.DataType = typeof(double);
            // 
            // OS_CONJUNTAS
            // 
            this.OS_CONJUNTAS.ColumnName = "OS_CONJUNTAS";
            this.OS_CONJUNTAS.DataType = typeof(int);
            // 
            // RETRABALHO_ROTA
            // 
            this.RETRABALHO_ROTA.ColumnName = "RETRABALHO_ROTA";
            this.RETRABALHO_ROTA.DataType = typeof(int);
            // 
            // HORAS_OPERADOR
            // 
            this.HORAS_OPERADOR.ColumnName = "HORAS_OPERADOR";
            this.HORAS_OPERADOR.DataType = typeof(double);
            // 
            // MAQUINA_FECHAMENTO
            // 
            this.MAQUINA_FECHAMENTO.ColumnName = "MAQUINA_FECHAMENTO";
            this.MAQUINA_FECHAMENTO.MaxLength = 20;
            // 
            // OS_CONJUNTAS_FECHAMENTO
            // 
            this.OS_CONJUNTAS_FECHAMENTO.ColumnName = "OS_CONJUNTAS_FECHAMENTO";
            this.OS_CONJUNTAS_FECHAMENTO.DataType = typeof(int);
            // 
            // HORAS_MAQUINA_RODANDO
            // 
            this.HORAS_MAQUINA_RODANDO.ColumnName = "HORAS_MAQUINA_RODANDO";
            this.HORAS_MAQUINA_RODANDO.DataType = typeof(double);
            // 
            // cODMAQUINARODANDODataGridViewTextBoxColumn
            // 
            this.cODMAQUINARODANDODataGridViewTextBoxColumn.DataPropertyName = "COD_MAQUINA_RODANDO";
            this.cODMAQUINARODANDODataGridViewTextBoxColumn.HeaderText = "COD_MAQUINA_RODANDO";
            this.cODMAQUINARODANDODataGridViewTextBoxColumn.Name = "cODMAQUINARODANDODataGridViewTextBoxColumn";
            // 
            // mAQUINAATUALDataGridViewTextBoxColumn
            // 
            this.mAQUINAATUALDataGridViewTextBoxColumn.DataPropertyName = "MAQUINA_ATUAL";
            this.mAQUINAATUALDataGridViewTextBoxColumn.HeaderText = "MAQUINA_ATUAL";
            this.mAQUINAATUALDataGridViewTextBoxColumn.Name = "mAQUINAATUALDataGridViewTextBoxColumn";
            // 
            // dATAMAQUINATRABALHANDODataGridViewTextBoxColumn
            // 
            this.dATAMAQUINATRABALHANDODataGridViewTextBoxColumn.DataPropertyName = "DATA_MAQUINA_TRABALHANDO";
            this.dATAMAQUINATRABALHANDODataGridViewTextBoxColumn.HeaderText = "DATA_MAQUINA_TRABALHANDO";
            this.dATAMAQUINATRABALHANDODataGridViewTextBoxColumn.Name = "dATAMAQUINATRABALHANDODataGridViewTextBoxColumn";
            // 
            // col_rota
            // 
            this.col_rota.DataPropertyName = "ROTA_MAQUINA_RODANDO";
            this.col_rota.HeaderText = "ROTA_MAQUINA_RODANDO";
            this.col_rota.Name = "col_rota";
            // 
            // oPERADORMAQUINARODANDODataGridViewTextBoxColumn
            // 
            this.oPERADORMAQUINARODANDODataGridViewTextBoxColumn.DataPropertyName = "OPERADOR_MAQUINA_RODANDO";
            this.oPERADORMAQUINARODANDODataGridViewTextBoxColumn.HeaderText = "OPERADOR_MAQUINA_RODANDO";
            this.oPERADORMAQUINARODANDODataGridViewTextBoxColumn.Name = "oPERADORMAQUINARODANDODataGridViewTextBoxColumn";
            // 
            // col_horas
            // 
            this.col_horas.DataPropertyName = "HORAS_TRABALHADAS_MAQUINA";
            this.col_horas.HeaderText = "HORAS_TRABALHADAS_MAQUINA";
            this.col_horas.Name = "col_horas";
            // 
            // oSMAQUINARODANDODataGridViewTextBoxColumn
            // 
            this.oSMAQUINARODANDODataGridViewTextBoxColumn.DataPropertyName = "OS_MAQUINA_RODANDO";
            this.oSMAQUINARODANDODataGridViewTextBoxColumn.HeaderText = "OS_MAQUINA_RODANDO";
            this.oSMAQUINARODANDODataGridViewTextBoxColumn.Name = "oSMAQUINARODANDODataGridViewTextBoxColumn";
            // 
            // form_maquinas_rodando
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 264);
            this.Controls.Add(this.bt_inserir);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvMaquinas_trabalhando);
            this.Name = "form_maquinas_rodando";
            this.Text = "form_maquinas_rodando";
            this.Load += new System.EventHandler(this.form_maquinas_rodando_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaquinas_trabalhando)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaquina_rodando)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MAQUINA_RODANDO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRotas_campo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ROTAS_CAMPO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvMaquinas_trabalhando;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datMaquina_rodando;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Data.DataSet dsMaquina_rodando;
        private System.Data.DataTable MAQUINA_RODANDO;
        private System.Data.DataColumn COD_MAQUINA_RODANDO;
        private System.Data.DataColumn MAQUINA_ATUAL;
        private System.Data.DataColumn DATA_MAQUINA_TRABALHANDO;
        private System.Data.DataColumn ROTA_MAQUINA_RODANDO;
        private System.Data.DataColumn OPERADOR_MAQUINA_RODANDO;
        private System.Data.DataColumn HORAS_TRABALHADAS_MAQUINA;
        private System.Data.DataColumn OS_MAQUINA_RODANDO;
        private System.Windows.Forms.Button bt_inserir;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datRotas_campo;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand8;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand6;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand5;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand7;
        private System.Data.DataSet dsRotas_campo;
        private System.Data.DataTable ROTAS_CAMPO;
        private System.Data.DataColumn COD_ROTA_CAMPO;
        private System.Data.DataColumn COD_NUM_ROTAS;
        private System.Data.DataColumn COD_ROTA_PECA;
        private System.Data.DataColumn OBSERVACAO_CAMPO;
        private System.Data.DataColumn DESENHO_CAMPO;
        private System.Data.DataColumn POSICAO_FILA_CAMPO;
        private System.Data.DataColumn HORA_ENTRADA;
        private System.Data.DataColumn DATA_ENTRADA;
        private System.Data.DataColumn HORA_FECHAMENTO;
        private System.Data.DataColumn DATA_FECHAMENTO;
        private System.Data.DataColumn POSICAO_ATUAL;
        private System.Data.DataColumn PREVISAO_PRODUCAO;
        private System.Data.DataColumn PECAS_PRODUZIDAS;
        private System.Data.DataColumn FINALIZADO;
        private System.Data.DataColumn OPERADOR_CAMPO;
        private System.Data.DataColumn OP_ROTA;
        private System.Data.DataColumn OPERACAO_CAMPO;
        private System.Data.DataColumn N_PDF_CAMPO;
        private System.Data.DataColumn MAQUINA;
        private System.Data.DataColumn DATA_ENTRADA_PREV;
        private System.Data.DataColumn DATA_FECHAMENTO_PREV;
        private System.Data.DataColumn OPERADOR_FINALIZADOR;
        private System.Data.DataColumn HORAS_TOTAIS_ROTA;
        private System.Data.DataColumn HORAS_PARADAS;
        private System.Data.DataColumn SALDO_HORAS;
        private System.Data.DataColumn OS_CONJUNTAS;
        private System.Data.DataColumn RETRABALHO_ROTA;
        private System.Data.DataColumn HORAS_OPERADOR;
        private System.Data.DataColumn MAQUINA_FECHAMENTO;
        private System.Data.DataColumn OS_CONJUNTAS_FECHAMENTO;
        private System.Data.DataColumn HORAS_MAQUINA_RODANDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODMAQUINARODANDODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAQUINAATUALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAMAQUINATRABALHANDODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_rota;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPERADORMAQUINARODANDODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_horas;
        private System.Windows.Forms.DataGridViewTextBoxColumn oSMAQUINARODANDODataGridViewTextBoxColumn;
    }
}