namespace Evolucao
{
    partial class form_verifica_rota_sem_semana
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_verifica_rota_sem_semana));
            this.dgvRotas = new System.Windows.Forms.DataGridView();
            this.dgvSemanas = new System.Windows.Forms.DataGridView();
            this.datRotas_campo = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
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
            this.SERVICO_EXTERNO_ROTA = new System.Data.DataColumn();
            this.FORNECEDOR_SERVICO_EXTERNO = new System.Data.DataColumn();
            this.ULTIMO_OPERADOR = new System.Data.DataColumn();
            this.FUNCAO_ROTA = new System.Data.DataColumn();
            this.INSERIDO_SEMANA = new System.Data.DataColumn();
            this.datHoras_semana = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand5 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand6 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand7 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand8 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsHoras_semana = new System.Data.DataSet();
            this.HORAS_SEMANA = new System.Data.DataTable();
            this.COD_HORAS_SEMANA = new System.Data.DataColumn();
            this.N_SEMANA = new System.Data.DataColumn();
            this.ANO_SEMANA = new System.Data.DataColumn();
            this.OPERACAO_SEMANA = new System.Data.DataColumn();
            this.ROTA_HORAS_SEMANA = new System.Data.DataColumn();
            this.HORAS_OPERACAO_SEMANA = new System.Data.DataColumn();
            this.OS_SEMANA = new System.Data.DataColumn();
            this.POSICAO_OS_SEMANA = new System.Data.DataColumn();
            this.SITUACAO_ROTA_SEMANA = new System.Data.DataColumn();
            this.DATA_INICIO_SEMANA = new System.Data.DataColumn();
            this.DATA_FIM_SEMANA = new System.Data.DataColumn();
            this.HORAS_REAIS_OPERACAO = new System.Data.DataColumn();
            this.PASSADO_SEMANA = new System.Data.DataColumn();
            this.OK_ROTA = new System.Data.DataColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cbRotas = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.col_cod_rota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_inserido_semana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODNUMROTASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODROTAPECADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oBSERVACAOCAMPODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESENHOCAMPODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOSICAOFILACAMPODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORAENTRADADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAENTRADADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORAFECHAMENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAFECHAMENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_posicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pREVISAOPRODUCAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pECASPRODUZIDASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fINALIZADODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPERADORCAMPODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPROTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPERACAOCAMPODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nPDFCAMPODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAQUINADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAENTRADAPREVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAFECHAMENTOPREVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPERADORFINALIZADORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORASTOTAISROTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORASPARADASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sALDOHORASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oSCONJUNTASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rETRABALHOROTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORASOPERADORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAQUINAFECHAMENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oSCONJUNTASFECHAMENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORASMAQUINARODANDODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sERVICOEXTERNOROTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fORNECEDORSERVICOEXTERNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uLTIMOOPERADORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fUNCAOROTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODHORASSEMANADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nSEMANADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aNOSEMANADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPERACAOSEMANADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_rota_semana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORASOPERACAOSEMANADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oSSEMANADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOSICAOOSSEMANADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sITUACAOROTASEMANADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAINICIOSEMANADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAFIMSEMANADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORASREAISOPERACAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pASSADOSEMANADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSemanas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRotas_campo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ROTAS_CAMPO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHoras_semana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HORAS_SEMANA)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRotas
            // 
            this.dgvRotas.AutoGenerateColumns = false;
            this.dgvRotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_cod_rota,
            this.col_inserido_semana,
            this.cODNUMROTASDataGridViewTextBoxColumn,
            this.cODROTAPECADataGridViewTextBoxColumn,
            this.oBSERVACAOCAMPODataGridViewTextBoxColumn,
            this.dESENHOCAMPODataGridViewTextBoxColumn,
            this.pOSICAOFILACAMPODataGridViewTextBoxColumn,
            this.hORAENTRADADataGridViewTextBoxColumn,
            this.dATAENTRADADataGridViewTextBoxColumn,
            this.hORAFECHAMENTODataGridViewTextBoxColumn,
            this.dATAFECHAMENTODataGridViewTextBoxColumn,
            this.col_posicao,
            this.pREVISAOPRODUCAODataGridViewTextBoxColumn,
            this.pECASPRODUZIDASDataGridViewTextBoxColumn,
            this.fINALIZADODataGridViewTextBoxColumn,
            this.oPERADORCAMPODataGridViewTextBoxColumn,
            this.oPROTADataGridViewTextBoxColumn,
            this.oPERACAOCAMPODataGridViewTextBoxColumn,
            this.nPDFCAMPODataGridViewTextBoxColumn,
            this.mAQUINADataGridViewTextBoxColumn,
            this.dATAENTRADAPREVDataGridViewTextBoxColumn,
            this.dATAFECHAMENTOPREVDataGridViewTextBoxColumn,
            this.oPERADORFINALIZADORDataGridViewTextBoxColumn,
            this.hORASTOTAISROTADataGridViewTextBoxColumn,
            this.hORASPARADASDataGridViewTextBoxColumn,
            this.sALDOHORASDataGridViewTextBoxColumn,
            this.oSCONJUNTASDataGridViewTextBoxColumn,
            this.rETRABALHOROTADataGridViewTextBoxColumn,
            this.hORASOPERADORDataGridViewTextBoxColumn,
            this.mAQUINAFECHAMENTODataGridViewTextBoxColumn,
            this.oSCONJUNTASFECHAMENTODataGridViewTextBoxColumn,
            this.hORASMAQUINARODANDODataGridViewTextBoxColumn,
            this.sERVICOEXTERNOROTADataGridViewTextBoxColumn,
            this.fORNECEDORSERVICOEXTERNODataGridViewTextBoxColumn,
            this.uLTIMOOPERADORDataGridViewTextBoxColumn,
            this.fUNCAOROTADataGridViewTextBoxColumn});
            this.dgvRotas.DataMember = "ROTAS_CAMPO";
            this.dgvRotas.DataSource = this.dsRotas_campo;
            this.dgvRotas.Location = new System.Drawing.Point(28, 65);
            this.dgvRotas.Name = "dgvRotas";
            this.dgvRotas.Size = new System.Drawing.Size(624, 211);
            this.dgvRotas.TabIndex = 0;
            // 
            // dgvSemanas
            // 
            this.dgvSemanas.AutoGenerateColumns = false;
            this.dgvSemanas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSemanas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODHORASSEMANADataGridViewTextBoxColumn,
            this.col_ok,
            this.nSEMANADataGridViewTextBoxColumn,
            this.aNOSEMANADataGridViewTextBoxColumn,
            this.oPERACAOSEMANADataGridViewTextBoxColumn,
            this.col_rota_semana,
            this.hORASOPERACAOSEMANADataGridViewTextBoxColumn,
            this.oSSEMANADataGridViewTextBoxColumn,
            this.pOSICAOOSSEMANADataGridViewTextBoxColumn,
            this.sITUACAOROTASEMANADataGridViewTextBoxColumn,
            this.dATAINICIOSEMANADataGridViewTextBoxColumn,
            this.dATAFIMSEMANADataGridViewTextBoxColumn,
            this.hORASREAISOPERACAODataGridViewTextBoxColumn,
            this.pASSADOSEMANADataGridViewTextBoxColumn});
            this.dgvSemanas.DataMember = "HORAS_SEMANA";
            this.dgvSemanas.DataSource = this.dsHoras_semana;
            this.dgvSemanas.Location = new System.Drawing.Point(28, 282);
            this.dgvSemanas.Name = "dgvSemanas";
            this.dgvSemanas.Size = new System.Drawing.Size(624, 185);
            this.dgvSemanas.TabIndex = 1;
            // 
            // datRotas_campo
            // 
            this.datRotas_campo.DeleteCommand = this.fbCommand4;
            this.datRotas_campo.InsertCommand = this.fbCommand2;
            this.datRotas_campo.SelectCommand = this.fbCommand1;
            this.datRotas_campo.UpdateCommand = this.fbCommand3;
            // 
            // fbCommand1
            // 
            this.fbCommand1.CommandText = "select * from rotas_campo where cod_rota_campo > 11000 AND COD_NUM_ROTAS = \'*\'  o" +
                "rder by cod_rota_campo";
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
            this.HORAS_MAQUINA_RODANDO,
            this.SERVICO_EXTERNO_ROTA,
            this.FORNECEDOR_SERVICO_EXTERNO,
            this.ULTIMO_OPERADOR,
            this.FUNCAO_ROTA,
            this.INSERIDO_SEMANA});
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
            // SERVICO_EXTERNO_ROTA
            // 
            this.SERVICO_EXTERNO_ROTA.ColumnName = "SERVICO_EXTERNO_ROTA";
            this.SERVICO_EXTERNO_ROTA.DataType = typeof(int);
            // 
            // FORNECEDOR_SERVICO_EXTERNO
            // 
            this.FORNECEDOR_SERVICO_EXTERNO.ColumnName = "FORNECEDOR_SERVICO_EXTERNO";
            this.FORNECEDOR_SERVICO_EXTERNO.MaxLength = 50;
            // 
            // ULTIMO_OPERADOR
            // 
            this.ULTIMO_OPERADOR.ColumnName = "ULTIMO_OPERADOR";
            this.ULTIMO_OPERADOR.MaxLength = 5;
            // 
            // FUNCAO_ROTA
            // 
            this.FUNCAO_ROTA.ColumnName = "FUNCAO_ROTA";
            this.FUNCAO_ROTA.MaxLength = 50;
            // 
            // INSERIDO_SEMANA
            // 
            this.INSERIDO_SEMANA.ColumnName = "INSERIDO_SEMANA";
            this.INSERIDO_SEMANA.DataType = typeof(int);
            // 
            // datHoras_semana
            // 
            this.datHoras_semana.DeleteCommand = this.fbCommand8;
            this.datHoras_semana.InsertCommand = this.fbCommand6;
            this.datHoras_semana.SelectCommand = this.fbCommand5;
            this.datHoras_semana.UpdateCommand = this.fbCommand7;
            // 
            // fbCommand5
            // 
            this.fbCommand5.CommandText = "select * from horas_semana";
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
            // dsHoras_semana
            // 
            this.dsHoras_semana.DataSetName = "dsHoras_semana";
            this.dsHoras_semana.Namespace = "http://www.tempuri.org/dsHoras_semana.xsd";
            this.dsHoras_semana.Tables.AddRange(new System.Data.DataTable[] {
            this.HORAS_SEMANA});
            // 
            // HORAS_SEMANA
            // 
            this.HORAS_SEMANA.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_HORAS_SEMANA,
            this.N_SEMANA,
            this.ANO_SEMANA,
            this.OPERACAO_SEMANA,
            this.ROTA_HORAS_SEMANA,
            this.HORAS_OPERACAO_SEMANA,
            this.OS_SEMANA,
            this.POSICAO_OS_SEMANA,
            this.SITUACAO_ROTA_SEMANA,
            this.DATA_INICIO_SEMANA,
            this.DATA_FIM_SEMANA,
            this.HORAS_REAIS_OPERACAO,
            this.PASSADO_SEMANA,
            this.OK_ROTA});
            this.HORAS_SEMANA.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_HORAS_SEMANA"}, true)});
            this.HORAS_SEMANA.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_HORAS_SEMANA};
            this.HORAS_SEMANA.TableName = "HORAS_SEMANA";
            // 
            // COD_HORAS_SEMANA
            // 
            this.COD_HORAS_SEMANA.AllowDBNull = false;
            this.COD_HORAS_SEMANA.ColumnName = "COD_HORAS_SEMANA";
            this.COD_HORAS_SEMANA.DataType = typeof(int);
            // 
            // N_SEMANA
            // 
            this.N_SEMANA.ColumnName = "N_SEMANA";
            this.N_SEMANA.DataType = typeof(int);
            // 
            // ANO_SEMANA
            // 
            this.ANO_SEMANA.ColumnName = "ANO_SEMANA";
            this.ANO_SEMANA.DataType = typeof(int);
            // 
            // OPERACAO_SEMANA
            // 
            this.OPERACAO_SEMANA.ColumnName = "OPERACAO_SEMANA";
            this.OPERACAO_SEMANA.MaxLength = 20;
            // 
            // ROTA_HORAS_SEMANA
            // 
            this.ROTA_HORAS_SEMANA.ColumnName = "ROTA_HORAS_SEMANA";
            this.ROTA_HORAS_SEMANA.DataType = typeof(int);
            // 
            // HORAS_OPERACAO_SEMANA
            // 
            this.HORAS_OPERACAO_SEMANA.ColumnName = "HORAS_OPERACAO_SEMANA";
            this.HORAS_OPERACAO_SEMANA.DataType = typeof(double);
            // 
            // OS_SEMANA
            // 
            this.OS_SEMANA.ColumnName = "OS_SEMANA";
            this.OS_SEMANA.MaxLength = 20;
            // 
            // POSICAO_OS_SEMANA
            // 
            this.POSICAO_OS_SEMANA.ColumnName = "POSICAO_OS_SEMANA";
            this.POSICAO_OS_SEMANA.MaxLength = 40;
            // 
            // SITUACAO_ROTA_SEMANA
            // 
            this.SITUACAO_ROTA_SEMANA.ColumnName = "SITUACAO_ROTA_SEMANA";
            this.SITUACAO_ROTA_SEMANA.MaxLength = 20;
            // 
            // DATA_INICIO_SEMANA
            // 
            this.DATA_INICIO_SEMANA.ColumnName = "DATA_INICIO_SEMANA";
            this.DATA_INICIO_SEMANA.DataType = typeof(System.DateTime);
            // 
            // DATA_FIM_SEMANA
            // 
            this.DATA_FIM_SEMANA.ColumnName = "DATA_FIM_SEMANA";
            this.DATA_FIM_SEMANA.DataType = typeof(System.DateTime);
            // 
            // HORAS_REAIS_OPERACAO
            // 
            this.HORAS_REAIS_OPERACAO.ColumnName = "HORAS_REAIS_OPERACAO";
            this.HORAS_REAIS_OPERACAO.DataType = typeof(double);
            // 
            // PASSADO_SEMANA
            // 
            this.PASSADO_SEMANA.ColumnName = "PASSADO_SEMANA";
            this.PASSADO_SEMANA.DataType = typeof(int);
            // 
            // OK_ROTA
            // 
            this.OK_ROTA.ColumnName = "OK_ROTA";
            this.OK_ROTA.DataType = typeof(int);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(204, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Iniciar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(345, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 31);
            this.button2.TabIndex = 3;
            this.button2.Text = "Salvar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbRotas
            // 
            this.cbRotas.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbRotas.DataAdapter = this.datRotas_campo;
            this.cbRotas.QuotePrefix = "\"";
            this.cbRotas.QuoteSuffix = "\"";
            // 
            // col_cod_rota
            // 
            this.col_cod_rota.DataPropertyName = "COD_ROTA_CAMPO";
            this.col_cod_rota.HeaderText = "COD_ROTA_CAMPO";
            this.col_cod_rota.Name = "col_cod_rota";
            // 
            // col_inserido_semana
            // 
            this.col_inserido_semana.DataPropertyName = "INSERIDO_SEMANA";
            this.col_inserido_semana.HeaderText = "INSERIDO_SEMANA";
            this.col_inserido_semana.Name = "col_inserido_semana";
            // 
            // cODNUMROTASDataGridViewTextBoxColumn
            // 
            this.cODNUMROTASDataGridViewTextBoxColumn.DataPropertyName = "COD_NUM_ROTAS";
            this.cODNUMROTASDataGridViewTextBoxColumn.HeaderText = "COD_NUM_ROTAS";
            this.cODNUMROTASDataGridViewTextBoxColumn.Name = "cODNUMROTASDataGridViewTextBoxColumn";
            // 
            // cODROTAPECADataGridViewTextBoxColumn
            // 
            this.cODROTAPECADataGridViewTextBoxColumn.DataPropertyName = "COD_ROTA_PECA";
            this.cODROTAPECADataGridViewTextBoxColumn.HeaderText = "COD_ROTA_PECA";
            this.cODROTAPECADataGridViewTextBoxColumn.Name = "cODROTAPECADataGridViewTextBoxColumn";
            // 
            // oBSERVACAOCAMPODataGridViewTextBoxColumn
            // 
            this.oBSERVACAOCAMPODataGridViewTextBoxColumn.DataPropertyName = "OBSERVACAO_CAMPO";
            this.oBSERVACAOCAMPODataGridViewTextBoxColumn.HeaderText = "OBSERVACAO_CAMPO";
            this.oBSERVACAOCAMPODataGridViewTextBoxColumn.Name = "oBSERVACAOCAMPODataGridViewTextBoxColumn";
            // 
            // dESENHOCAMPODataGridViewTextBoxColumn
            // 
            this.dESENHOCAMPODataGridViewTextBoxColumn.DataPropertyName = "DESENHO_CAMPO";
            this.dESENHOCAMPODataGridViewTextBoxColumn.HeaderText = "DESENHO_CAMPO";
            this.dESENHOCAMPODataGridViewTextBoxColumn.Name = "dESENHOCAMPODataGridViewTextBoxColumn";
            // 
            // pOSICAOFILACAMPODataGridViewTextBoxColumn
            // 
            this.pOSICAOFILACAMPODataGridViewTextBoxColumn.DataPropertyName = "POSICAO_FILA_CAMPO";
            this.pOSICAOFILACAMPODataGridViewTextBoxColumn.HeaderText = "POSICAO_FILA_CAMPO";
            this.pOSICAOFILACAMPODataGridViewTextBoxColumn.Name = "pOSICAOFILACAMPODataGridViewTextBoxColumn";
            // 
            // hORAENTRADADataGridViewTextBoxColumn
            // 
            this.hORAENTRADADataGridViewTextBoxColumn.DataPropertyName = "HORA_ENTRADA";
            this.hORAENTRADADataGridViewTextBoxColumn.HeaderText = "HORA_ENTRADA";
            this.hORAENTRADADataGridViewTextBoxColumn.Name = "hORAENTRADADataGridViewTextBoxColumn";
            // 
            // dATAENTRADADataGridViewTextBoxColumn
            // 
            this.dATAENTRADADataGridViewTextBoxColumn.DataPropertyName = "DATA_ENTRADA";
            this.dATAENTRADADataGridViewTextBoxColumn.HeaderText = "DATA_ENTRADA";
            this.dATAENTRADADataGridViewTextBoxColumn.Name = "dATAENTRADADataGridViewTextBoxColumn";
            // 
            // hORAFECHAMENTODataGridViewTextBoxColumn
            // 
            this.hORAFECHAMENTODataGridViewTextBoxColumn.DataPropertyName = "HORA_FECHAMENTO";
            this.hORAFECHAMENTODataGridViewTextBoxColumn.HeaderText = "HORA_FECHAMENTO";
            this.hORAFECHAMENTODataGridViewTextBoxColumn.Name = "hORAFECHAMENTODataGridViewTextBoxColumn";
            // 
            // dATAFECHAMENTODataGridViewTextBoxColumn
            // 
            this.dATAFECHAMENTODataGridViewTextBoxColumn.DataPropertyName = "DATA_FECHAMENTO";
            this.dATAFECHAMENTODataGridViewTextBoxColumn.HeaderText = "DATA_FECHAMENTO";
            this.dATAFECHAMENTODataGridViewTextBoxColumn.Name = "dATAFECHAMENTODataGridViewTextBoxColumn";
            // 
            // col_posicao
            // 
            this.col_posicao.DataPropertyName = "POSICAO_ATUAL";
            this.col_posicao.HeaderText = "POSICAO_ATUAL";
            this.col_posicao.Name = "col_posicao";
            // 
            // pREVISAOPRODUCAODataGridViewTextBoxColumn
            // 
            this.pREVISAOPRODUCAODataGridViewTextBoxColumn.DataPropertyName = "PREVISAO_PRODUCAO";
            this.pREVISAOPRODUCAODataGridViewTextBoxColumn.HeaderText = "PREVISAO_PRODUCAO";
            this.pREVISAOPRODUCAODataGridViewTextBoxColumn.Name = "pREVISAOPRODUCAODataGridViewTextBoxColumn";
            // 
            // pECASPRODUZIDASDataGridViewTextBoxColumn
            // 
            this.pECASPRODUZIDASDataGridViewTextBoxColumn.DataPropertyName = "PECAS_PRODUZIDAS";
            this.pECASPRODUZIDASDataGridViewTextBoxColumn.HeaderText = "PECAS_PRODUZIDAS";
            this.pECASPRODUZIDASDataGridViewTextBoxColumn.Name = "pECASPRODUZIDASDataGridViewTextBoxColumn";
            // 
            // fINALIZADODataGridViewTextBoxColumn
            // 
            this.fINALIZADODataGridViewTextBoxColumn.DataPropertyName = "FINALIZADO";
            this.fINALIZADODataGridViewTextBoxColumn.HeaderText = "FINALIZADO";
            this.fINALIZADODataGridViewTextBoxColumn.Name = "fINALIZADODataGridViewTextBoxColumn";
            // 
            // oPERADORCAMPODataGridViewTextBoxColumn
            // 
            this.oPERADORCAMPODataGridViewTextBoxColumn.DataPropertyName = "OPERADOR_CAMPO";
            this.oPERADORCAMPODataGridViewTextBoxColumn.HeaderText = "OPERADOR_CAMPO";
            this.oPERADORCAMPODataGridViewTextBoxColumn.Name = "oPERADORCAMPODataGridViewTextBoxColumn";
            // 
            // oPROTADataGridViewTextBoxColumn
            // 
            this.oPROTADataGridViewTextBoxColumn.DataPropertyName = "OP_ROTA";
            this.oPROTADataGridViewTextBoxColumn.HeaderText = "OP_ROTA";
            this.oPROTADataGridViewTextBoxColumn.Name = "oPROTADataGridViewTextBoxColumn";
            // 
            // oPERACAOCAMPODataGridViewTextBoxColumn
            // 
            this.oPERACAOCAMPODataGridViewTextBoxColumn.DataPropertyName = "OPERACAO_CAMPO";
            this.oPERACAOCAMPODataGridViewTextBoxColumn.HeaderText = "OPERACAO_CAMPO";
            this.oPERACAOCAMPODataGridViewTextBoxColumn.Name = "oPERACAOCAMPODataGridViewTextBoxColumn";
            // 
            // nPDFCAMPODataGridViewTextBoxColumn
            // 
            this.nPDFCAMPODataGridViewTextBoxColumn.DataPropertyName = "N_PDF_CAMPO";
            this.nPDFCAMPODataGridViewTextBoxColumn.HeaderText = "N_PDF_CAMPO";
            this.nPDFCAMPODataGridViewTextBoxColumn.Name = "nPDFCAMPODataGridViewTextBoxColumn";
            // 
            // mAQUINADataGridViewTextBoxColumn
            // 
            this.mAQUINADataGridViewTextBoxColumn.DataPropertyName = "MAQUINA";
            this.mAQUINADataGridViewTextBoxColumn.HeaderText = "MAQUINA";
            this.mAQUINADataGridViewTextBoxColumn.Name = "mAQUINADataGridViewTextBoxColumn";
            // 
            // dATAENTRADAPREVDataGridViewTextBoxColumn
            // 
            this.dATAENTRADAPREVDataGridViewTextBoxColumn.DataPropertyName = "DATA_ENTRADA_PREV";
            this.dATAENTRADAPREVDataGridViewTextBoxColumn.HeaderText = "DATA_ENTRADA_PREV";
            this.dATAENTRADAPREVDataGridViewTextBoxColumn.Name = "dATAENTRADAPREVDataGridViewTextBoxColumn";
            // 
            // dATAFECHAMENTOPREVDataGridViewTextBoxColumn
            // 
            this.dATAFECHAMENTOPREVDataGridViewTextBoxColumn.DataPropertyName = "DATA_FECHAMENTO_PREV";
            this.dATAFECHAMENTOPREVDataGridViewTextBoxColumn.HeaderText = "DATA_FECHAMENTO_PREV";
            this.dATAFECHAMENTOPREVDataGridViewTextBoxColumn.Name = "dATAFECHAMENTOPREVDataGridViewTextBoxColumn";
            // 
            // oPERADORFINALIZADORDataGridViewTextBoxColumn
            // 
            this.oPERADORFINALIZADORDataGridViewTextBoxColumn.DataPropertyName = "OPERADOR_FINALIZADOR";
            this.oPERADORFINALIZADORDataGridViewTextBoxColumn.HeaderText = "OPERADOR_FINALIZADOR";
            this.oPERADORFINALIZADORDataGridViewTextBoxColumn.Name = "oPERADORFINALIZADORDataGridViewTextBoxColumn";
            // 
            // hORASTOTAISROTADataGridViewTextBoxColumn
            // 
            this.hORASTOTAISROTADataGridViewTextBoxColumn.DataPropertyName = "HORAS_TOTAIS_ROTA";
            this.hORASTOTAISROTADataGridViewTextBoxColumn.HeaderText = "HORAS_TOTAIS_ROTA";
            this.hORASTOTAISROTADataGridViewTextBoxColumn.Name = "hORASTOTAISROTADataGridViewTextBoxColumn";
            // 
            // hORASPARADASDataGridViewTextBoxColumn
            // 
            this.hORASPARADASDataGridViewTextBoxColumn.DataPropertyName = "HORAS_PARADAS";
            this.hORASPARADASDataGridViewTextBoxColumn.HeaderText = "HORAS_PARADAS";
            this.hORASPARADASDataGridViewTextBoxColumn.Name = "hORASPARADASDataGridViewTextBoxColumn";
            // 
            // sALDOHORASDataGridViewTextBoxColumn
            // 
            this.sALDOHORASDataGridViewTextBoxColumn.DataPropertyName = "SALDO_HORAS";
            this.sALDOHORASDataGridViewTextBoxColumn.HeaderText = "SALDO_HORAS";
            this.sALDOHORASDataGridViewTextBoxColumn.Name = "sALDOHORASDataGridViewTextBoxColumn";
            // 
            // oSCONJUNTASDataGridViewTextBoxColumn
            // 
            this.oSCONJUNTASDataGridViewTextBoxColumn.DataPropertyName = "OS_CONJUNTAS";
            this.oSCONJUNTASDataGridViewTextBoxColumn.HeaderText = "OS_CONJUNTAS";
            this.oSCONJUNTASDataGridViewTextBoxColumn.Name = "oSCONJUNTASDataGridViewTextBoxColumn";
            // 
            // rETRABALHOROTADataGridViewTextBoxColumn
            // 
            this.rETRABALHOROTADataGridViewTextBoxColumn.DataPropertyName = "RETRABALHO_ROTA";
            this.rETRABALHOROTADataGridViewTextBoxColumn.HeaderText = "RETRABALHO_ROTA";
            this.rETRABALHOROTADataGridViewTextBoxColumn.Name = "rETRABALHOROTADataGridViewTextBoxColumn";
            // 
            // hORASOPERADORDataGridViewTextBoxColumn
            // 
            this.hORASOPERADORDataGridViewTextBoxColumn.DataPropertyName = "HORAS_OPERADOR";
            this.hORASOPERADORDataGridViewTextBoxColumn.HeaderText = "HORAS_OPERADOR";
            this.hORASOPERADORDataGridViewTextBoxColumn.Name = "hORASOPERADORDataGridViewTextBoxColumn";
            // 
            // mAQUINAFECHAMENTODataGridViewTextBoxColumn
            // 
            this.mAQUINAFECHAMENTODataGridViewTextBoxColumn.DataPropertyName = "MAQUINA_FECHAMENTO";
            this.mAQUINAFECHAMENTODataGridViewTextBoxColumn.HeaderText = "MAQUINA_FECHAMENTO";
            this.mAQUINAFECHAMENTODataGridViewTextBoxColumn.Name = "mAQUINAFECHAMENTODataGridViewTextBoxColumn";
            // 
            // oSCONJUNTASFECHAMENTODataGridViewTextBoxColumn
            // 
            this.oSCONJUNTASFECHAMENTODataGridViewTextBoxColumn.DataPropertyName = "OS_CONJUNTAS_FECHAMENTO";
            this.oSCONJUNTASFECHAMENTODataGridViewTextBoxColumn.HeaderText = "OS_CONJUNTAS_FECHAMENTO";
            this.oSCONJUNTASFECHAMENTODataGridViewTextBoxColumn.Name = "oSCONJUNTASFECHAMENTODataGridViewTextBoxColumn";
            // 
            // hORASMAQUINARODANDODataGridViewTextBoxColumn
            // 
            this.hORASMAQUINARODANDODataGridViewTextBoxColumn.DataPropertyName = "HORAS_MAQUINA_RODANDO";
            this.hORASMAQUINARODANDODataGridViewTextBoxColumn.HeaderText = "HORAS_MAQUINA_RODANDO";
            this.hORASMAQUINARODANDODataGridViewTextBoxColumn.Name = "hORASMAQUINARODANDODataGridViewTextBoxColumn";
            // 
            // sERVICOEXTERNOROTADataGridViewTextBoxColumn
            // 
            this.sERVICOEXTERNOROTADataGridViewTextBoxColumn.DataPropertyName = "SERVICO_EXTERNO_ROTA";
            this.sERVICOEXTERNOROTADataGridViewTextBoxColumn.HeaderText = "SERVICO_EXTERNO_ROTA";
            this.sERVICOEXTERNOROTADataGridViewTextBoxColumn.Name = "sERVICOEXTERNOROTADataGridViewTextBoxColumn";
            // 
            // fORNECEDORSERVICOEXTERNODataGridViewTextBoxColumn
            // 
            this.fORNECEDORSERVICOEXTERNODataGridViewTextBoxColumn.DataPropertyName = "FORNECEDOR_SERVICO_EXTERNO";
            this.fORNECEDORSERVICOEXTERNODataGridViewTextBoxColumn.HeaderText = "FORNECEDOR_SERVICO_EXTERNO";
            this.fORNECEDORSERVICOEXTERNODataGridViewTextBoxColumn.Name = "fORNECEDORSERVICOEXTERNODataGridViewTextBoxColumn";
            // 
            // uLTIMOOPERADORDataGridViewTextBoxColumn
            // 
            this.uLTIMOOPERADORDataGridViewTextBoxColumn.DataPropertyName = "ULTIMO_OPERADOR";
            this.uLTIMOOPERADORDataGridViewTextBoxColumn.HeaderText = "ULTIMO_OPERADOR";
            this.uLTIMOOPERADORDataGridViewTextBoxColumn.Name = "uLTIMOOPERADORDataGridViewTextBoxColumn";
            // 
            // fUNCAOROTADataGridViewTextBoxColumn
            // 
            this.fUNCAOROTADataGridViewTextBoxColumn.DataPropertyName = "FUNCAO_ROTA";
            this.fUNCAOROTADataGridViewTextBoxColumn.HeaderText = "FUNCAO_ROTA";
            this.fUNCAOROTADataGridViewTextBoxColumn.Name = "fUNCAOROTADataGridViewTextBoxColumn";
            // 
            // cODHORASSEMANADataGridViewTextBoxColumn
            // 
            this.cODHORASSEMANADataGridViewTextBoxColumn.DataPropertyName = "COD_HORAS_SEMANA";
            this.cODHORASSEMANADataGridViewTextBoxColumn.HeaderText = "COD_HORAS_SEMANA";
            this.cODHORASSEMANADataGridViewTextBoxColumn.Name = "cODHORASSEMANADataGridViewTextBoxColumn";
            // 
            // col_ok
            // 
            this.col_ok.DataPropertyName = "OK_ROTA";
            this.col_ok.HeaderText = "OK_ROTA";
            this.col_ok.Name = "col_ok";
            // 
            // nSEMANADataGridViewTextBoxColumn
            // 
            this.nSEMANADataGridViewTextBoxColumn.DataPropertyName = "N_SEMANA";
            this.nSEMANADataGridViewTextBoxColumn.HeaderText = "N_SEMANA";
            this.nSEMANADataGridViewTextBoxColumn.Name = "nSEMANADataGridViewTextBoxColumn";
            // 
            // aNOSEMANADataGridViewTextBoxColumn
            // 
            this.aNOSEMANADataGridViewTextBoxColumn.DataPropertyName = "ANO_SEMANA";
            this.aNOSEMANADataGridViewTextBoxColumn.HeaderText = "ANO_SEMANA";
            this.aNOSEMANADataGridViewTextBoxColumn.Name = "aNOSEMANADataGridViewTextBoxColumn";
            // 
            // oPERACAOSEMANADataGridViewTextBoxColumn
            // 
            this.oPERACAOSEMANADataGridViewTextBoxColumn.DataPropertyName = "OPERACAO_SEMANA";
            this.oPERACAOSEMANADataGridViewTextBoxColumn.HeaderText = "OPERACAO_SEMANA";
            this.oPERACAOSEMANADataGridViewTextBoxColumn.Name = "oPERACAOSEMANADataGridViewTextBoxColumn";
            // 
            // col_rota_semana
            // 
            this.col_rota_semana.DataPropertyName = "ROTA_HORAS_SEMANA";
            this.col_rota_semana.HeaderText = "ROTA_HORAS_SEMANA";
            this.col_rota_semana.Name = "col_rota_semana";
            // 
            // hORASOPERACAOSEMANADataGridViewTextBoxColumn
            // 
            this.hORASOPERACAOSEMANADataGridViewTextBoxColumn.DataPropertyName = "HORAS_OPERACAO_SEMANA";
            this.hORASOPERACAOSEMANADataGridViewTextBoxColumn.HeaderText = "HORAS_OPERACAO_SEMANA";
            this.hORASOPERACAOSEMANADataGridViewTextBoxColumn.Name = "hORASOPERACAOSEMANADataGridViewTextBoxColumn";
            // 
            // oSSEMANADataGridViewTextBoxColumn
            // 
            this.oSSEMANADataGridViewTextBoxColumn.DataPropertyName = "OS_SEMANA";
            this.oSSEMANADataGridViewTextBoxColumn.HeaderText = "OS_SEMANA";
            this.oSSEMANADataGridViewTextBoxColumn.Name = "oSSEMANADataGridViewTextBoxColumn";
            // 
            // pOSICAOOSSEMANADataGridViewTextBoxColumn
            // 
            this.pOSICAOOSSEMANADataGridViewTextBoxColumn.DataPropertyName = "POSICAO_OS_SEMANA";
            this.pOSICAOOSSEMANADataGridViewTextBoxColumn.HeaderText = "POSICAO_OS_SEMANA";
            this.pOSICAOOSSEMANADataGridViewTextBoxColumn.Name = "pOSICAOOSSEMANADataGridViewTextBoxColumn";
            // 
            // sITUACAOROTASEMANADataGridViewTextBoxColumn
            // 
            this.sITUACAOROTASEMANADataGridViewTextBoxColumn.DataPropertyName = "SITUACAO_ROTA_SEMANA";
            this.sITUACAOROTASEMANADataGridViewTextBoxColumn.HeaderText = "SITUACAO_ROTA_SEMANA";
            this.sITUACAOROTASEMANADataGridViewTextBoxColumn.Name = "sITUACAOROTASEMANADataGridViewTextBoxColumn";
            // 
            // dATAINICIOSEMANADataGridViewTextBoxColumn
            // 
            this.dATAINICIOSEMANADataGridViewTextBoxColumn.DataPropertyName = "DATA_INICIO_SEMANA";
            this.dATAINICIOSEMANADataGridViewTextBoxColumn.HeaderText = "DATA_INICIO_SEMANA";
            this.dATAINICIOSEMANADataGridViewTextBoxColumn.Name = "dATAINICIOSEMANADataGridViewTextBoxColumn";
            // 
            // dATAFIMSEMANADataGridViewTextBoxColumn
            // 
            this.dATAFIMSEMANADataGridViewTextBoxColumn.DataPropertyName = "DATA_FIM_SEMANA";
            this.dATAFIMSEMANADataGridViewTextBoxColumn.HeaderText = "DATA_FIM_SEMANA";
            this.dATAFIMSEMANADataGridViewTextBoxColumn.Name = "dATAFIMSEMANADataGridViewTextBoxColumn";
            // 
            // hORASREAISOPERACAODataGridViewTextBoxColumn
            // 
            this.hORASREAISOPERACAODataGridViewTextBoxColumn.DataPropertyName = "HORAS_REAIS_OPERACAO";
            this.hORASREAISOPERACAODataGridViewTextBoxColumn.HeaderText = "HORAS_REAIS_OPERACAO";
            this.hORASREAISOPERACAODataGridViewTextBoxColumn.Name = "hORASREAISOPERACAODataGridViewTextBoxColumn";
            // 
            // pASSADOSEMANADataGridViewTextBoxColumn
            // 
            this.pASSADOSEMANADataGridViewTextBoxColumn.DataPropertyName = "PASSADO_SEMANA";
            this.pASSADOSEMANADataGridViewTextBoxColumn.HeaderText = "PASSADO_SEMANA";
            this.pASSADOSEMANADataGridViewTextBoxColumn.Name = "pASSADOSEMANADataGridViewTextBoxColumn";
            // 
            // form_verifica_rota_sem_semana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 479);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvSemanas);
            this.Controls.Add(this.dgvRotas);
            this.Name = "form_verifica_rota_sem_semana";
            this.Text = "form_verifica_rota_sem_semana";
            this.Load += new System.EventHandler(this.form_verifica_rota_sem_semana_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSemanas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRotas_campo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ROTAS_CAMPO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHoras_semana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HORAS_SEMANA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRotas;
        private System.Windows.Forms.DataGridView dgvSemanas;
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
        private System.Data.DataColumn SERVICO_EXTERNO_ROTA;
        private System.Data.DataColumn FORNECEDOR_SERVICO_EXTERNO;
        private System.Data.DataColumn ULTIMO_OPERADOR;
        private System.Data.DataColumn FUNCAO_ROTA;
        private System.Data.DataColumn INSERIDO_SEMANA;
        private System.Data.DataSet dsHoras_semana;
        private System.Data.DataTable HORAS_SEMANA;
        private System.Data.DataColumn COD_HORAS_SEMANA;
        private System.Data.DataColumn N_SEMANA;
        private System.Data.DataColumn ANO_SEMANA;
        private System.Data.DataColumn OPERACAO_SEMANA;
        private System.Data.DataColumn ROTA_HORAS_SEMANA;
        private System.Data.DataColumn HORAS_OPERACAO_SEMANA;
        private System.Data.DataColumn OS_SEMANA;
        private System.Data.DataColumn POSICAO_OS_SEMANA;
        private System.Data.DataColumn SITUACAO_ROTA_SEMANA;
        private System.Data.DataColumn DATA_INICIO_SEMANA;
        private System.Data.DataColumn DATA_FIM_SEMANA;
        private System.Data.DataColumn HORAS_REAIS_OPERACAO;
        private System.Data.DataColumn PASSADO_SEMANA;
        private System.Data.DataColumn OK_ROTA;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datRotas_campo;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datHoras_semana;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand8;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand6;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand5;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbRotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod_rota;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_inserido_semana;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODNUMROTASDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODROTAPECADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oBSERVACAOCAMPODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESENHOCAMPODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOSICAOFILACAMPODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORAENTRADADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAENTRADADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORAFECHAMENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAFECHAMENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_posicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn pREVISAOPRODUCAODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pECASPRODUZIDASDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fINALIZADODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPERADORCAMPODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPROTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPERACAOCAMPODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nPDFCAMPODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAQUINADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAENTRADAPREVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAFECHAMENTOPREVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPERADORFINALIZADORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORASTOTAISROTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORASPARADASDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sALDOHORASDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oSCONJUNTASDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rETRABALHOROTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORASOPERADORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAQUINAFECHAMENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oSCONJUNTASFECHAMENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORASMAQUINARODANDODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sERVICOEXTERNOROTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fORNECEDORSERVICOEXTERNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uLTIMOOPERADORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fUNCAOROTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODHORASSEMANADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ok;
        private System.Windows.Forms.DataGridViewTextBoxColumn nSEMANADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aNOSEMANADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPERACAOSEMANADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_rota_semana;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORASOPERACAOSEMANADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oSSEMANADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOSICAOOSSEMANADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sITUACAOROTASEMANADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAINICIOSEMANADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAFIMSEMANADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORASREAISOPERACAODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pASSADOSEMANADataGridViewTextBoxColumn;
    }
}