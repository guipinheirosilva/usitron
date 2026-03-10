namespace Evolucao
{
    partial class form_consulta_operador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_consulta_operador));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.HORAS_TOTAIS_ROTA = new System.Data.DataColumn();
            this.HORAS_PARADAS = new System.Data.DataColumn();
            this.SALDO_HORAS = new System.Data.DataColumn();
            this.DATA_ENTRADA_PREV = new System.Data.DataColumn();
            this.DATA_FECHAMENTO_PREV = new System.Data.DataColumn();
            this.OPERADOR_FINALIZADOR = new System.Data.DataColumn();
            this.datRotas_campo = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.datOp = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand8 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand6 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand5 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand7 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.DATA_FECHAMENTO = new System.Data.DataColumn();
            this.POSICAO_ATUAL = new System.Data.DataColumn();
            this.PREVISAO_PRODUCAO = new System.Data.DataColumn();
            this.HORA_ENTRADA = new System.Data.DataColumn();
            this.DATA_ENTRADA = new System.Data.DataColumn();
            this.HORA_FECHAMENTO = new System.Data.DataColumn();
            this.PECAS_PRODUZIDAS = new System.Data.DataColumn();
            this.OPERACAO_CAMPO = new System.Data.DataColumn();
            this.N_PDF_CAMPO = new System.Data.DataColumn();
            this.MAQUINA = new System.Data.DataColumn();
            this.FINALIZADO = new System.Data.DataColumn();
            this.OPERADOR_CAMPO = new System.Data.DataColumn();
            this.OP_ROTA = new System.Data.DataColumn();
            this.hORAFECHAMENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAFECHAMENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fINALIZADODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOSICAOFILACAMPODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORAENTRADADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAENTRADADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOSICAOATUALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbRefazer = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbTotal_horas = new System.Windows.Forms.TextBox();
            this.pREVISAOPRODUCAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_saldo_horas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPROTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODROTACAMPODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cod_rota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btIniciar = new System.Windows.Forms.Button();
            this.dESENHOCAMPODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oBSERVACAOCAMPODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPERADORCAMPODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nPDFCAMPODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPERACAOCAMPODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODROTAPECADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COD_OP = new System.Data.DataColumn();
            this.DATA_PDF = new System.Data.DataColumn();
            this.ENTREGA_DIA = new System.Data.DataColumn();
            this.dsOp = new System.Data.DataSet();
            this.OP = new System.Data.DataTable();
            this.ENTREGOU_DIA = new System.Data.DataColumn();
            this.PRECO_UNIT = new System.Data.DataColumn();
            this.COND_PGTO = new System.Data.DataColumn();
            this.PESO_TOTAL = new System.Data.DataColumn();
            this.PDF_ACEITO_EM = new System.Data.DataColumn();
            this.NF_N = new System.Data.DataColumn();
            this.QDE_PDF = new System.Data.DataColumn();
            this.QDE_EST = new System.Data.DataColumn();
            this.QDE_FAB = new System.Data.DataColumn();
            this.QDE_EMB = new System.Data.DataColumn();
            this.QDE_CAIXAS = new System.Data.DataColumn();
            this.DESENHO_OP_ATUAL = new System.Data.DataColumn();
            this.N_PDF = new System.Data.DataColumn();
            this.MATERIAL_OP = new System.Data.DataColumn();
            this.LOTE = new System.Data.DataColumn();
            this.ESPESSURA_OP = new System.Data.DataColumn();
            this.labelDtFinal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtFinal = new System.Windows.Forms.DateTimePicker();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.dsRotas_campo = new System.Data.DataSet();
            this.ROTAS_CAMPO = new System.Data.DataTable();
            this.COD_ROTA_CAMPO = new System.Data.DataColumn();
            this.COD_NUM_ROTAS = new System.Data.DataColumn();
            this.COD_ROTA_PECA = new System.Data.DataColumn();
            this.OBSERVACAO_CAMPO = new System.Data.DataColumn();
            this.DESENHO_CAMPO = new System.Data.DataColumn();
            this.POSICAO_FILA_CAMPO = new System.Data.DataColumn();
            this.label20 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_maquina = new System.Windows.Forms.TextBox();
            this.dtInicial = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tb_operador = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.radioOperacoes_finalizadas = new System.Windows.Forms.RadioButton();
            this.radioOperacoes_previstas = new System.Windows.Forms.RadioButton();
            this.radioOperacoes_atrasadas = new System.Windows.Forms.RadioButton();
            this.cbUm_dia = new System.Windows.Forms.CheckBox();
            this.cbTodas_datas = new System.Windows.Forms.CheckBox();
            this.radioTotalhoras = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dsOp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRotas_campo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ROTAS_CAMPO)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            // datRotas_campo
            // 
            this.datRotas_campo.DeleteCommand = this.fbCommand4;
            this.datRotas_campo.InsertCommand = this.fbCommand2;
            this.datRotas_campo.SelectCommand = this.fbCommand1;
            this.datRotas_campo.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * from rotas_campo";
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
            // datOp
            // 
            this.datOp.DeleteCommand = this.fbCommand8;
            this.datOp.InsertCommand = this.fbCommand6;
            this.datOp.SelectCommand = this.fbCommand5;
            this.datOp.UpdateCommand = this.fbCommand7;
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
            this.fbCommand5.CommandText = "select * from op";
            this.fbCommand5.CommandTimeout = 30;
            this.fbCommand5.Connection = this.fbConnection1;
            // 
            // fbCommand7
            // 
            this.fbCommand7.CommandTimeout = 30;
            // 
            // DATA_FECHAMENTO
            // 
            this.DATA_FECHAMENTO.ColumnName = "DATA_FECHAMENTO";
            this.DATA_FECHAMENTO.DataType = typeof(System.DateTime);
            this.DATA_FECHAMENTO.DateTimeMode = System.Data.DataSetDateTime.Local;
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
            // HORA_ENTRADA
            // 
            this.HORA_ENTRADA.ColumnName = "HORA_ENTRADA";
            this.HORA_ENTRADA.MaxLength = 20;
            // 
            // DATA_ENTRADA
            // 
            this.DATA_ENTRADA.ColumnName = "DATA_ENTRADA";
            this.DATA_ENTRADA.DataType = typeof(System.DateTime);
            this.DATA_ENTRADA.DateTimeMode = System.Data.DataSetDateTime.Local;
            // 
            // HORA_FECHAMENTO
            // 
            this.HORA_FECHAMENTO.ColumnName = "HORA_FECHAMENTO";
            this.HORA_FECHAMENTO.MaxLength = 20;
            // 
            // PECAS_PRODUZIDAS
            // 
            this.PECAS_PRODUZIDAS.ColumnName = "PECAS_PRODUZIDAS";
            this.PECAS_PRODUZIDAS.DataType = typeof(int);
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
            // hORAFECHAMENTODataGridViewTextBoxColumn
            // 
            this.hORAFECHAMENTODataGridViewTextBoxColumn.DataPropertyName = "HORA_FECHAMENTO";
            this.hORAFECHAMENTODataGridViewTextBoxColumn.HeaderText = "Hora do Fechamento";
            this.hORAFECHAMENTODataGridViewTextBoxColumn.Name = "hORAFECHAMENTODataGridViewTextBoxColumn";
            this.hORAFECHAMENTODataGridViewTextBoxColumn.Width = 60;
            // 
            // dATAFECHAMENTODataGridViewTextBoxColumn
            // 
            this.dATAFECHAMENTODataGridViewTextBoxColumn.DataPropertyName = "DATA_FECHAMENTO";
            this.dATAFECHAMENTODataGridViewTextBoxColumn.HeaderText = "Data do Fechamento";
            this.dATAFECHAMENTODataGridViewTextBoxColumn.Name = "dATAFECHAMENTODataGridViewTextBoxColumn";
            this.dATAFECHAMENTODataGridViewTextBoxColumn.Width = 60;
            // 
            // fINALIZADODataGridViewTextBoxColumn
            // 
            this.fINALIZADODataGridViewTextBoxColumn.DataPropertyName = "FINALIZADO";
            this.fINALIZADODataGridViewTextBoxColumn.HeaderText = "Finalizado?";
            this.fINALIZADODataGridViewTextBoxColumn.Name = "fINALIZADODataGridViewTextBoxColumn";
            this.fINALIZADODataGridViewTextBoxColumn.Width = 70;
            // 
            // pOSICAOFILACAMPODataGridViewTextBoxColumn
            // 
            this.pOSICAOFILACAMPODataGridViewTextBoxColumn.DataPropertyName = "POSICAO_FILA_CAMPO";
            this.pOSICAOFILACAMPODataGridViewTextBoxColumn.HeaderText = "POSICAO_FILA_CAMPO";
            this.pOSICAOFILACAMPODataGridViewTextBoxColumn.Name = "pOSICAOFILACAMPODataGridViewTextBoxColumn";
            this.pOSICAOFILACAMPODataGridViewTextBoxColumn.Visible = false;
            // 
            // hORAENTRADADataGridViewTextBoxColumn
            // 
            this.hORAENTRADADataGridViewTextBoxColumn.DataPropertyName = "HORA_ENTRADA";
            this.hORAENTRADADataGridViewTextBoxColumn.HeaderText = "Hora da Entrada";
            this.hORAENTRADADataGridViewTextBoxColumn.Name = "hORAENTRADADataGridViewTextBoxColumn";
            this.hORAENTRADADataGridViewTextBoxColumn.Width = 60;
            // 
            // dATAENTRADADataGridViewTextBoxColumn
            // 
            this.dATAENTRADADataGridViewTextBoxColumn.DataPropertyName = "DATA_ENTRADA";
            this.dATAENTRADADataGridViewTextBoxColumn.HeaderText = "Data de Entrada";
            this.dATAENTRADADataGridViewTextBoxColumn.Name = "dATAENTRADADataGridViewTextBoxColumn";
            this.dATAENTRADADataGridViewTextBoxColumn.Width = 60;
            // 
            // pOSICAOATUALDataGridViewTextBoxColumn
            // 
            this.pOSICAOATUALDataGridViewTextBoxColumn.DataPropertyName = "POSICAO_ATUAL";
            this.pOSICAOATUALDataGridViewTextBoxColumn.HeaderText = "Posição Atual";
            this.pOSICAOATUALDataGridViewTextBoxColumn.Name = "pOSICAOATUALDataGridViewTextBoxColumn";
            this.pOSICAOATUALDataGridViewTextBoxColumn.Width = 60;
            // 
            // tbRefazer
            // 
            this.tbRefazer.Location = new System.Drawing.Point(145, 164);
            this.tbRefazer.Name = "tbRefazer";
            this.tbRefazer.Size = new System.Drawing.Size(75, 23);
            this.tbRefazer.TabIndex = 176;
            this.tbRefazer.Text = "Refazer";
            this.tbRefazer.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(764, 451);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 25);
            this.label9.TabIndex = 175;
            this.label9.Text = "Tempo Total:";
            // 
            // tbTotal_horas
            // 
            this.tbTotal_horas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotal_horas.Location = new System.Drawing.Point(908, 448);
            this.tbTotal_horas.Name = "tbTotal_horas";
            this.tbTotal_horas.Size = new System.Drawing.Size(108, 31);
            this.tbTotal_horas.TabIndex = 174;
            // 
            // pREVISAOPRODUCAODataGridViewTextBoxColumn
            // 
            this.pREVISAOPRODUCAODataGridViewTextBoxColumn.DataPropertyName = "PREVISAO_PRODUCAO";
            this.pREVISAOPRODUCAODataGridViewTextBoxColumn.HeaderText = "Horas Previstas";
            this.pREVISAOPRODUCAODataGridViewTextBoxColumn.Name = "pREVISAOPRODUCAODataGridViewTextBoxColumn";
            this.pREVISAOPRODUCAODataGridViewTextBoxColumn.Width = 50;
            // 
            // col_saldo_horas
            // 
            this.col_saldo_horas.DataPropertyName = "SALDO_HORAS";
            this.col_saldo_horas.HeaderText = "Horas Trabalhadas";
            this.col_saldo_horas.Name = "col_saldo_horas";
            this.col_saldo_horas.Width = 70;
            // 
            // oPROTADataGridViewTextBoxColumn
            // 
            this.oPROTADataGridViewTextBoxColumn.DataPropertyName = "OP_ROTA";
            this.oPROTADataGridViewTextBoxColumn.HeaderText = "OP_ROTA";
            this.oPROTADataGridViewTextBoxColumn.Name = "oPROTADataGridViewTextBoxColumn";
            this.oPROTADataGridViewTextBoxColumn.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MAQUINA";
            this.dataGridViewTextBoxColumn2.HeaderText = "Máquina";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 50;
            // 
            // cODROTACAMPODataGridViewTextBoxColumn
            // 
            this.cODROTACAMPODataGridViewTextBoxColumn.DataPropertyName = "COD_ROTA_CAMPO";
            this.cODROTACAMPODataGridViewTextBoxColumn.HeaderText = "Código da Rota";
            this.cODROTACAMPODataGridViewTextBoxColumn.Name = "cODROTACAMPODataGridViewTextBoxColumn";
            // 
            // col_cod_rota
            // 
            this.col_cod_rota.DataPropertyName = "COD_NUM_ROTAS";
            this.col_cod_rota.HeaderText = "Código da Rota";
            this.col_cod_rota.Name = "col_cod_rota";
            this.col_cod_rota.Visible = false;
            this.col_cod_rota.Width = 50;
            // 
            // btIniciar
            // 
            this.btIniciar.Location = new System.Drawing.Point(52, 164);
            this.btIniciar.Name = "btIniciar";
            this.btIniciar.Size = new System.Drawing.Size(75, 23);
            this.btIniciar.TabIndex = 172;
            this.btIniciar.Text = "Consultar";
            this.btIniciar.UseVisualStyleBackColor = true;
            // 
            // dESENHOCAMPODataGridViewTextBoxColumn
            // 
            this.dESENHOCAMPODataGridViewTextBoxColumn.DataPropertyName = "DESENHO_CAMPO";
            this.dESENHOCAMPODataGridViewTextBoxColumn.HeaderText = "OS";
            this.dESENHOCAMPODataGridViewTextBoxColumn.Name = "dESENHOCAMPODataGridViewTextBoxColumn";
            this.dESENHOCAMPODataGridViewTextBoxColumn.Width = 70;
            // 
            // oBSERVACAOCAMPODataGridViewTextBoxColumn
            // 
            this.oBSERVACAOCAMPODataGridViewTextBoxColumn.DataPropertyName = "OBSERVACAO_CAMPO";
            this.oBSERVACAOCAMPODataGridViewTextBoxColumn.HeaderText = "Observação";
            this.oBSERVACAOCAMPODataGridViewTextBoxColumn.Name = "oBSERVACAOCAMPODataGridViewTextBoxColumn";
            this.oBSERVACAOCAMPODataGridViewTextBoxColumn.Visible = false;
            // 
            // oPERADORCAMPODataGridViewTextBoxColumn
            // 
            this.oPERADORCAMPODataGridViewTextBoxColumn.DataPropertyName = "OPERADOR_CAMPO";
            this.oPERADORCAMPODataGridViewTextBoxColumn.HeaderText = "Oper. Início";
            this.oPERADORCAMPODataGridViewTextBoxColumn.Name = "oPERADORCAMPODataGridViewTextBoxColumn";
            this.oPERADORCAMPODataGridViewTextBoxColumn.Width = 40;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "OPERADOR_FINALIZADOR";
            this.dataGridViewTextBoxColumn1.HeaderText = "Oper. Fim";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 40;
            // 
            // nPDFCAMPODataGridViewTextBoxColumn
            // 
            this.nPDFCAMPODataGridViewTextBoxColumn.DataPropertyName = "N_PDF_CAMPO";
            this.nPDFCAMPODataGridViewTextBoxColumn.HeaderText = "Pos:";
            this.nPDFCAMPODataGridViewTextBoxColumn.Name = "nPDFCAMPODataGridViewTextBoxColumn";
            this.nPDFCAMPODataGridViewTextBoxColumn.Width = 30;
            // 
            // oPERACAOCAMPODataGridViewTextBoxColumn
            // 
            this.oPERACAOCAMPODataGridViewTextBoxColumn.DataPropertyName = "OPERACAO_CAMPO";
            this.oPERACAOCAMPODataGridViewTextBoxColumn.HeaderText = "Operação";
            this.oPERACAOCAMPODataGridViewTextBoxColumn.Name = "oPERACAOCAMPODataGridViewTextBoxColumn";
            // 
            // cODROTAPECADataGridViewTextBoxColumn
            // 
            this.cODROTAPECADataGridViewTextBoxColumn.DataPropertyName = "COD_ROTA_PECA";
            this.cODROTAPECADataGridViewTextBoxColumn.HeaderText = "COD_ROTA_PECA";
            this.cODROTAPECADataGridViewTextBoxColumn.Name = "cODROTAPECADataGridViewTextBoxColumn";
            this.cODROTAPECADataGridViewTextBoxColumn.Visible = false;
            // 
            // COD_OP
            // 
            this.COD_OP.AllowDBNull = false;
            this.COD_OP.ColumnName = "COD_OP";
            this.COD_OP.DataType = typeof(int);
            // 
            // DATA_PDF
            // 
            this.DATA_PDF.ColumnName = "DATA_PDF";
            this.DATA_PDF.DataType = typeof(System.DateTime);
            // 
            // ENTREGA_DIA
            // 
            this.ENTREGA_DIA.ColumnName = "ENTREGA_DIA";
            this.ENTREGA_DIA.DataType = typeof(System.DateTime);
            // 
            // dsOp
            // 
            this.dsOp.DataSetName = "dsOp";
            this.dsOp.Namespace = "http://www.tempuri.org/dsOp.xsd";
            this.dsOp.Tables.AddRange(new System.Data.DataTable[] {
            this.OP});
            // 
            // OP
            // 
            this.OP.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_OP,
            this.DATA_PDF,
            this.ENTREGA_DIA,
            this.ENTREGOU_DIA,
            this.PRECO_UNIT,
            this.COND_PGTO,
            this.PESO_TOTAL,
            this.PDF_ACEITO_EM,
            this.NF_N,
            this.QDE_PDF,
            this.QDE_EST,
            this.QDE_FAB,
            this.QDE_EMB,
            this.QDE_CAIXAS,
            this.DESENHO_OP_ATUAL,
            this.N_PDF,
            this.MATERIAL_OP,
            this.LOTE,
            this.ESPESSURA_OP});
            this.OP.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_OP"}, true)});
            this.OP.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_OP};
            this.OP.TableName = "OP";
            // 
            // ENTREGOU_DIA
            // 
            this.ENTREGOU_DIA.ColumnName = "ENTREGOU_DIA";
            this.ENTREGOU_DIA.DataType = typeof(System.DateTime);
            // 
            // PRECO_UNIT
            // 
            this.PRECO_UNIT.ColumnName = "PRECO_UNIT";
            this.PRECO_UNIT.MaxLength = 10;
            // 
            // COND_PGTO
            // 
            this.COND_PGTO.ColumnName = "COND_PGTO";
            this.COND_PGTO.MaxLength = 10;
            // 
            // PESO_TOTAL
            // 
            this.PESO_TOTAL.ColumnName = "PESO_TOTAL";
            this.PESO_TOTAL.MaxLength = 10;
            // 
            // PDF_ACEITO_EM
            // 
            this.PDF_ACEITO_EM.ColumnName = "PDF_ACEITO_EM";
            this.PDF_ACEITO_EM.DataType = typeof(System.DateTime);
            // 
            // NF_N
            // 
            this.NF_N.ColumnName = "NF_N";
            this.NF_N.DataType = typeof(int);
            // 
            // QDE_PDF
            // 
            this.QDE_PDF.ColumnName = "QDE_PDF";
            this.QDE_PDF.DataType = typeof(int);
            // 
            // QDE_EST
            // 
            this.QDE_EST.ColumnName = "QDE_EST";
            this.QDE_EST.DataType = typeof(int);
            // 
            // QDE_FAB
            // 
            this.QDE_FAB.ColumnName = "QDE_FAB";
            this.QDE_FAB.DataType = typeof(int);
            // 
            // QDE_EMB
            // 
            this.QDE_EMB.ColumnName = "QDE_EMB";
            this.QDE_EMB.DataType = typeof(int);
            // 
            // QDE_CAIXAS
            // 
            this.QDE_CAIXAS.ColumnName = "QDE_CAIXAS";
            this.QDE_CAIXAS.DataType = typeof(int);
            // 
            // DESENHO_OP_ATUAL
            // 
            this.DESENHO_OP_ATUAL.ColumnName = "DESENHO_OP_ATUAL";
            this.DESENHO_OP_ATUAL.MaxLength = 40;
            // 
            // N_PDF
            // 
            this.N_PDF.ColumnName = "N_PDF";
            this.N_PDF.MaxLength = 40;
            // 
            // MATERIAL_OP
            // 
            this.MATERIAL_OP.ColumnName = "MATERIAL_OP";
            this.MATERIAL_OP.MaxLength = 30;
            // 
            // LOTE
            // 
            this.LOTE.ColumnName = "LOTE";
            this.LOTE.MaxLength = 30;
            // 
            // ESPESSURA_OP
            // 
            this.ESPESSURA_OP.ColumnName = "ESPESSURA_OP";
            this.ESPESSURA_OP.MaxLength = 30;
            // 
            // labelDtFinal
            // 
            this.labelDtFinal.AutoSize = true;
            this.labelDtFinal.Location = new System.Drawing.Point(342, 20);
            this.labelDtFinal.Name = "labelDtFinal";
            this.labelDtFinal.Size = new System.Drawing.Size(58, 13);
            this.labelDtFinal.TabIndex = 143;
            this.labelDtFinal.Text = "Data Final:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 141;
            this.label1.Text = "Data Inicial:";
            // 
            // dtFinal
            // 
            this.dtFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFinal.Location = new System.Drawing.Point(424, 16);
            this.dtFinal.Name = "dtFinal";
            this.dtFinal.Size = new System.Drawing.Size(216, 20);
            this.dtFinal.TabIndex = 142;
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsulta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODROTACAMPODataGridViewTextBoxColumn,
            this.col_cod_rota,
            this.dESENHOCAMPODataGridViewTextBoxColumn,
            this.nPDFCAMPODataGridViewTextBoxColumn,
            this.oPERACAOCAMPODataGridViewTextBoxColumn,
            this.cODROTAPECADataGridViewTextBoxColumn,
            this.oBSERVACAOCAMPODataGridViewTextBoxColumn,
            this.oPERADORCAMPODataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.pOSICAOFILACAMPODataGridViewTextBoxColumn,
            this.hORAENTRADADataGridViewTextBoxColumn,
            this.dATAENTRADADataGridViewTextBoxColumn,
            this.hORAFECHAMENTODataGridViewTextBoxColumn,
            this.dATAFECHAMENTODataGridViewTextBoxColumn,
            this.fINALIZADODataGridViewTextBoxColumn,
            this.pOSICAOATUALDataGridViewTextBoxColumn,
            this.pREVISAOPRODUCAODataGridViewTextBoxColumn,
            this.col_saldo_horas,
            this.oPROTADataGridViewTextBoxColumn});
            this.dgvConsulta.DataMember = "ROTAS_CAMPO";
            this.dgvConsulta.DataSource = this.dsRotas_campo;
            this.dgvConsulta.Location = new System.Drawing.Point(12, 193);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.Size = new System.Drawing.Size(971, 249);
            this.dgvConsulta.TabIndex = 173;
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
            this.SALDO_HORAS});
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
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label20.Location = new System.Drawing.Point(34, -54);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(302, 46);
            this.label20.TabIndex = 164;
            this.label20.Text = "Consulta de OS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 144;
            this.label5.Text = "Máquina:";
            // 
            // tb_maquina
            // 
            this.tb_maquina.Location = new System.Drawing.Point(63, 19);
            this.tb_maquina.Name = "tb_maquina";
            this.tb_maquina.Size = new System.Drawing.Size(62, 20);
            this.tb_maquina.TabIndex = 145;
            // 
            // dtInicial
            // 
            this.dtInicial.CustomFormat = "";
            this.dtInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicial.Location = new System.Drawing.Point(101, 16);
            this.dtInicial.Name = "dtInicial";
            this.dtInicial.Size = new System.Drawing.Size(216, 20);
            this.dtInicial.TabIndex = 140;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tb_operador);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.tb_maquina);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(16, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(286, 53);
            this.groupBox3.TabIndex = 171;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Opções";
            // 
            // tb_operador
            // 
            this.tb_operador.Location = new System.Drawing.Point(191, 19);
            this.tb_operador.Name = "tb_operador";
            this.tb_operador.Size = new System.Drawing.Size(62, 20);
            this.tb_operador.TabIndex = 156;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(131, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 155;
            this.label7.Text = "Operador:";
            // 
            // radioOperacoes_finalizadas
            // 
            this.radioOperacoes_finalizadas.AutoSize = true;
            this.radioOperacoes_finalizadas.Location = new System.Drawing.Point(126, 141);
            this.radioOperacoes_finalizadas.Name = "radioOperacoes_finalizadas";
            this.radioOperacoes_finalizadas.Size = new System.Drawing.Size(132, 17);
            this.radioOperacoes_finalizadas.TabIndex = 170;
            this.radioOperacoes_finalizadas.TabStop = true;
            this.radioOperacoes_finalizadas.Text = "Operações Finalizadas";
            this.radioOperacoes_finalizadas.UseVisualStyleBackColor = true;
            // 
            // radioOperacoes_previstas
            // 
            this.radioOperacoes_previstas.AutoSize = true;
            this.radioOperacoes_previstas.Location = new System.Drawing.Point(259, 141);
            this.radioOperacoes_previstas.Name = "radioOperacoes_previstas";
            this.radioOperacoes_previstas.Size = new System.Drawing.Size(123, 17);
            this.radioOperacoes_previstas.TabIndex = 169;
            this.radioOperacoes_previstas.TabStop = true;
            this.radioOperacoes_previstas.Text = "Operações Previstas";
            this.radioOperacoes_previstas.UseVisualStyleBackColor = true;
            // 
            // radioOperacoes_atrasadas
            // 
            this.radioOperacoes_atrasadas.AutoSize = true;
            this.radioOperacoes_atrasadas.Location = new System.Drawing.Point(389, 141);
            this.radioOperacoes_atrasadas.Name = "radioOperacoes_atrasadas";
            this.radioOperacoes_atrasadas.Size = new System.Drawing.Size(127, 17);
            this.radioOperacoes_atrasadas.TabIndex = 168;
            this.radioOperacoes_atrasadas.TabStop = true;
            this.radioOperacoes_atrasadas.Text = "Operações Atrasadas";
            this.radioOperacoes_atrasadas.UseVisualStyleBackColor = true;
            // 
            // cbUm_dia
            // 
            this.cbUm_dia.AutoSize = true;
            this.cbUm_dia.Location = new System.Drawing.Point(153, 48);
            this.cbUm_dia.Name = "cbUm_dia";
            this.cbUm_dia.Size = new System.Drawing.Size(59, 17);
            this.cbUm_dia.TabIndex = 145;
            this.cbUm_dia.Text = "Um dia";
            this.cbUm_dia.UseVisualStyleBackColor = true;
            // 
            // cbTodas_datas
            // 
            this.cbTodas_datas.AutoSize = true;
            this.cbTodas_datas.Location = new System.Drawing.Point(30, 48);
            this.cbTodas_datas.Name = "cbTodas_datas";
            this.cbTodas_datas.Size = new System.Drawing.Size(99, 17);
            this.cbTodas_datas.TabIndex = 144;
            this.cbTodas_datas.Text = "Todas as datas";
            this.cbTodas_datas.UseVisualStyleBackColor = true;
            // 
            // radioTotalhoras
            // 
            this.radioTotalhoras.AutoSize = true;
            this.radioTotalhoras.Location = new System.Drawing.Point(25, 141);
            this.radioTotalhoras.Name = "radioTotalhoras";
            this.radioTotalhoras.Size = new System.Drawing.Size(95, 17);
            this.radioTotalhoras.TabIndex = 167;
            this.radioTotalhoras.TabStop = true;
            this.radioTotalhoras.Text = "Total de Horas";
            this.radioTotalhoras.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbUm_dia);
            this.groupBox2.Controls.Add(this.cbTodas_datas);
            this.groupBox2.Controls.Add(this.labelDtFinal);
            this.groupBox2.Controls.Add(this.dtFinal);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtInicial);
            this.groupBox2.Location = new System.Drawing.Point(16, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(673, 75);
            this.groupBox2.TabIndex = 166;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data";
            // 
            // form_consulta_operador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 444);
            this.Controls.Add(this.tbRefazer);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbTotal_horas);
            this.Controls.Add(this.btIniciar);
            this.Controls.Add(this.dgvConsulta);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.radioOperacoes_finalizadas);
            this.Controls.Add(this.radioOperacoes_previstas);
            this.Controls.Add(this.radioOperacoes_atrasadas);
            this.Controls.Add(this.radioTotalhoras);
            this.Controls.Add(this.groupBox2);
            this.Name = "form_consulta_operador";
            this.Text = "Consulta de Operador";
            ((System.ComponentModel.ISupportInitialize)(this.dsOp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRotas_campo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ROTAS_CAMPO)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.DataColumn HORAS_TOTAIS_ROTA;
        private System.Data.DataColumn HORAS_PARADAS;
        private System.Data.DataColumn SALDO_HORAS;
        private System.Data.DataColumn DATA_ENTRADA_PREV;
        private System.Data.DataColumn DATA_FECHAMENTO_PREV;
        private System.Data.DataColumn OPERADOR_FINALIZADOR;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datRotas_campo;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datOp;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand8;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand6;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand5;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand7;
        private System.Data.DataColumn DATA_FECHAMENTO;
        private System.Data.DataColumn POSICAO_ATUAL;
        private System.Data.DataColumn PREVISAO_PRODUCAO;
        private System.Data.DataColumn HORA_ENTRADA;
        private System.Data.DataColumn DATA_ENTRADA;
        private System.Data.DataColumn HORA_FECHAMENTO;
        private System.Data.DataColumn PECAS_PRODUZIDAS;
        private System.Data.DataColumn OPERACAO_CAMPO;
        private System.Data.DataColumn N_PDF_CAMPO;
        private System.Data.DataColumn MAQUINA;
        private System.Data.DataColumn FINALIZADO;
        private System.Data.DataColumn OPERADOR_CAMPO;
        private System.Data.DataColumn OP_ROTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORAFECHAMENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAFECHAMENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fINALIZADODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOSICAOFILACAMPODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORAENTRADADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAENTRADADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOSICAOATUALDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button tbRefazer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbTotal_horas;
        private System.Windows.Forms.DataGridViewTextBoxColumn pREVISAOPRODUCAODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_saldo_horas;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPROTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODROTACAMPODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod_rota;
        private System.Windows.Forms.Button btIniciar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESENHOCAMPODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oBSERVACAOCAMPODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPERADORCAMPODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nPDFCAMPODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPERACAOCAMPODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODROTAPECADataGridViewTextBoxColumn;
        private System.Data.DataColumn COD_OP;
        private System.Data.DataColumn DATA_PDF;
        private System.Data.DataColumn ENTREGA_DIA;
        private System.Data.DataSet dsOp;
        private System.Data.DataTable OP;
        private System.Data.DataColumn ENTREGOU_DIA;
        private System.Data.DataColumn PRECO_UNIT;
        private System.Data.DataColumn COND_PGTO;
        private System.Data.DataColumn PESO_TOTAL;
        private System.Data.DataColumn PDF_ACEITO_EM;
        private System.Data.DataColumn NF_N;
        private System.Data.DataColumn QDE_PDF;
        private System.Data.DataColumn QDE_EST;
        private System.Data.DataColumn QDE_FAB;
        private System.Data.DataColumn QDE_EMB;
        private System.Data.DataColumn QDE_CAIXAS;
        private System.Data.DataColumn DESENHO_OP_ATUAL;
        private System.Data.DataColumn N_PDF;
        private System.Data.DataColumn MATERIAL_OP;
        private System.Data.DataColumn LOTE;
        private System.Data.DataColumn ESPESSURA_OP;
        private System.Windows.Forms.Label labelDtFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtFinal;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Data.DataSet dsRotas_campo;
        private System.Data.DataTable ROTAS_CAMPO;
        private System.Data.DataColumn COD_ROTA_CAMPO;
        private System.Data.DataColumn COD_NUM_ROTAS;
        private System.Data.DataColumn COD_ROTA_PECA;
        private System.Data.DataColumn OBSERVACAO_CAMPO;
        private System.Data.DataColumn DESENHO_CAMPO;
        private System.Data.DataColumn POSICAO_FILA_CAMPO;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_maquina;
        private System.Windows.Forms.DateTimePicker dtInicial;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tb_operador;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioOperacoes_finalizadas;
        private System.Windows.Forms.RadioButton radioOperacoes_previstas;
        private System.Windows.Forms.RadioButton radioOperacoes_atrasadas;
        private System.Windows.Forms.CheckBox cbUm_dia;
        private System.Windows.Forms.CheckBox cbTodas_datas;
        private System.Windows.Forms.RadioButton radioTotalhoras;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}