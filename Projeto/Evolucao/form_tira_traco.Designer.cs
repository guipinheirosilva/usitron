namespace Evolucao
{
    partial class form_tira_traco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_tira_traco));
            this.dgvOp = new System.Windows.Forms.DataGridView();
            this.dsOp = new System.Data.DataSet();
            this.OP = new System.Data.DataTable();
            this.COD_OP = new System.Data.DataColumn();
            this.DATA_PDF = new System.Data.DataColumn();
            this.ENTREGA_DIA = new System.Data.DataColumn();
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
            this.dgvRotas = new System.Windows.Forms.DataGridView();
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
            this.dgvSemana = new System.Windows.Forms.DataGridView();
            this.dsSemana = new System.Data.DataSet();
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
            this.datOp = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.button1 = new System.Windows.Forms.Button();
            this.cbOp = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.button2 = new System.Windows.Forms.Button();
            this.datRotas_campo = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand8 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand6 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand5 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand7 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.cbRotas_campo = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.datSemana = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand12 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand10 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand9 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand11 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.cbSemana = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.dESENHOCAMPODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODROTACAMPODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODNUMROTASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODROTAPECADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oBSERVACAOCAMPODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOSICAOFILACAMPODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORAENTRADADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAENTRADADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORAFECHAMENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAFECHAMENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOSICAOATUALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pREVISAOPRODUCAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pECASPRODUZIDASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fINALIZADODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPERADORCAMPODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPROTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPERACAOCAMPODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_pos = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dESENHOOPATUALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODOPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAPDFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNTREGADIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNTREGOUDIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRECOUNITDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONDPGTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pESOTOTALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pDFACEITOEMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nFNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qDEPDFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qDEESTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qDEFABDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qDEEMBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qDECAIXASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_pos_peca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mATERIALOPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSPESSURAOPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oSSEMANADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODHORASSEMANADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nSEMANADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aNOSEMANADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPERACAOSEMANADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rOTAHORASSEMANADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORASOPERACAOSEMANADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_pos_sem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sITUACAOROTASEMANADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAINICIOSEMANADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAFIMSEMANADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORASREAISOPERACAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRotas_campo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ROTAS_CAMPO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSemana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSemana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HORAS_SEMANA)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOp
            // 
            this.dgvOp.AutoGenerateColumns = false;
            this.dgvOp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dESENHOOPATUALDataGridViewTextBoxColumn,
            this.cODOPDataGridViewTextBoxColumn,
            this.dATAPDFDataGridViewTextBoxColumn,
            this.eNTREGADIADataGridViewTextBoxColumn,
            this.eNTREGOUDIADataGridViewTextBoxColumn,
            this.pRECOUNITDataGridViewTextBoxColumn,
            this.cONDPGTODataGridViewTextBoxColumn,
            this.pESOTOTALDataGridViewTextBoxColumn,
            this.pDFACEITOEMDataGridViewTextBoxColumn,
            this.nFNDataGridViewTextBoxColumn,
            this.qDEPDFDataGridViewTextBoxColumn,
            this.qDEESTDataGridViewTextBoxColumn,
            this.qDEFABDataGridViewTextBoxColumn,
            this.qDEEMBDataGridViewTextBoxColumn,
            this.qDECAIXASDataGridViewTextBoxColumn,
            this.col_pos_peca,
            this.mATERIALOPDataGridViewTextBoxColumn,
            this.lOTEDataGridViewTextBoxColumn,
            this.eSPESSURAOPDataGridViewTextBoxColumn});
            this.dgvOp.DataMember = "OP";
            this.dgvOp.DataSource = this.dsOp;
            this.dgvOp.Location = new System.Drawing.Point(12, 48);
            this.dgvOp.Name = "dgvOp";
            this.dgvOp.Size = new System.Drawing.Size(185, 264);
            this.dgvOp.TabIndex = 0;
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
            // dgvRotas
            // 
            this.dgvRotas.AutoGenerateColumns = false;
            this.dgvRotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dESENHOCAMPODataGridViewTextBoxColumn,
            this.cODROTACAMPODataGridViewTextBoxColumn,
            this.cODNUMROTASDataGridViewTextBoxColumn,
            this.cODROTAPECADataGridViewTextBoxColumn,
            this.oBSERVACAOCAMPODataGridViewTextBoxColumn,
            this.pOSICAOFILACAMPODataGridViewTextBoxColumn,
            this.hORAENTRADADataGridViewTextBoxColumn,
            this.dATAENTRADADataGridViewTextBoxColumn,
            this.hORAFECHAMENTODataGridViewTextBoxColumn,
            this.dATAFECHAMENTODataGridViewTextBoxColumn,
            this.pOSICAOATUALDataGridViewTextBoxColumn,
            this.pREVISAOPRODUCAODataGridViewTextBoxColumn,
            this.pECASPRODUZIDASDataGridViewTextBoxColumn,
            this.fINALIZADODataGridViewTextBoxColumn,
            this.oPERADORCAMPODataGridViewTextBoxColumn,
            this.oPROTADataGridViewTextBoxColumn,
            this.oPERACAOCAMPODataGridViewTextBoxColumn,
            this.col_pos,
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
            this.uLTIMOOPERADORDataGridViewTextBoxColumn});
            this.dgvRotas.DataMember = "ROTAS_CAMPO";
            this.dgvRotas.DataSource = this.dsRotas_campo;
            this.dgvRotas.Location = new System.Drawing.Point(213, 48);
            this.dgvRotas.Name = "dgvRotas";
            this.dgvRotas.Size = new System.Drawing.Size(172, 264);
            this.dgvRotas.TabIndex = 1;
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
            this.ULTIMO_OPERADOR});
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
            // dgvSemana
            // 
            this.dgvSemana.AutoGenerateColumns = false;
            this.dgvSemana.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSemana.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oSSEMANADataGridViewTextBoxColumn,
            this.cODHORASSEMANADataGridViewTextBoxColumn,
            this.nSEMANADataGridViewTextBoxColumn,
            this.aNOSEMANADataGridViewTextBoxColumn,
            this.oPERACAOSEMANADataGridViewTextBoxColumn,
            this.rOTAHORASSEMANADataGridViewTextBoxColumn,
            this.hORASOPERACAOSEMANADataGridViewTextBoxColumn,
            this.col_pos_sem,
            this.sITUACAOROTASEMANADataGridViewTextBoxColumn,
            this.dATAINICIOSEMANADataGridViewTextBoxColumn,
            this.dATAFIMSEMANADataGridViewTextBoxColumn,
            this.hORASREAISOPERACAODataGridViewTextBoxColumn});
            this.dgvSemana.DataMember = "HORAS_SEMANA";
            this.dgvSemana.DataSource = this.dsSemana;
            this.dgvSemana.Location = new System.Drawing.Point(405, 48);
            this.dgvSemana.Name = "dgvSemana";
            this.dgvSemana.Size = new System.Drawing.Size(185, 264);
            this.dgvSemana.TabIndex = 2;
            // 
            // dsSemana
            // 
            this.dsSemana.DataSetName = "dsSemana";
            this.dsSemana.Namespace = "http://www.tempuri.org/dsSemana.xsd";
            this.dsSemana.Tables.AddRange(new System.Data.DataTable[] {
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
            this.HORAS_REAIS_OPERACAO});
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
            // datOp
            // 
            this.datOp.DeleteCommand = this.fbCommand4;
            this.datOp.InsertCommand = this.fbCommand2;
            this.datOp.SelectCommand = this.fbCommand1;
            this.datOp.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select desenho_op_atual, cod_op, n_pdf from op";
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
            this.button1.Location = new System.Drawing.Point(74, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Começar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbOp
            // 
            this.cbOp.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbOp.DataAdapter = this.datOp;
            this.cbOp.QuotePrefix = "\"";
            this.cbOp.QuoteSuffix = "\"";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(259, 337);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Salvar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // datRotas_campo
            // 
            this.datRotas_campo.DeleteCommand = this.fbCommand8;
            this.datRotas_campo.InsertCommand = this.fbCommand6;
            this.datRotas_campo.SelectCommand = this.fbCommand5;
            this.datRotas_campo.UpdateCommand = this.fbCommand7;
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
            this.fbCommand5.CommandText = "select desenho_campo, cod_rota_campo, n_pdf_campo from rotas_campo";
            this.fbCommand5.CommandTimeout = 30;
            this.fbCommand5.Connection = this.fbConnection1;
            // 
            // fbCommand7
            // 
            this.fbCommand7.CommandTimeout = 30;
            // 
            // cbRotas_campo
            // 
            this.cbRotas_campo.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbRotas_campo.DataAdapter = this.datRotas_campo;
            this.cbRotas_campo.QuotePrefix = "\"";
            this.cbRotas_campo.QuoteSuffix = "\"";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(259, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Começar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(466, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Começar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // datSemana
            // 
            this.datSemana.DeleteCommand = this.fbCommand12;
            this.datSemana.InsertCommand = this.fbCommand10;
            this.datSemana.SelectCommand = this.fbCommand9;
            this.datSemana.UpdateCommand = this.fbCommand11;
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
            this.fbCommand9.CommandText = "select os_semana, cod_horas_semana, posicao_os_semana from horas_semana";
            this.fbCommand9.CommandTimeout = 30;
            this.fbCommand9.Connection = this.fbConnection1;
            // 
            // fbCommand11
            // 
            this.fbCommand11.CommandTimeout = 30;
            // 
            // cbSemana
            // 
            this.cbSemana.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbSemana.DataAdapter = this.datSemana;
            this.cbSemana.QuotePrefix = "\"";
            this.cbSemana.QuoteSuffix = "\"";
            // 
            // dESENHOCAMPODataGridViewTextBoxColumn
            // 
            this.dESENHOCAMPODataGridViewTextBoxColumn.DataPropertyName = "DESENHO_CAMPO";
            this.dESENHOCAMPODataGridViewTextBoxColumn.HeaderText = "DESENHO_CAMPO";
            this.dESENHOCAMPODataGridViewTextBoxColumn.Name = "dESENHOCAMPODataGridViewTextBoxColumn";
            // 
            // cODROTACAMPODataGridViewTextBoxColumn
            // 
            this.cODROTACAMPODataGridViewTextBoxColumn.DataPropertyName = "COD_ROTA_CAMPO";
            this.cODROTACAMPODataGridViewTextBoxColumn.HeaderText = "COD_ROTA_CAMPO";
            this.cODROTACAMPODataGridViewTextBoxColumn.Name = "cODROTACAMPODataGridViewTextBoxColumn";
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
            // pOSICAOATUALDataGridViewTextBoxColumn
            // 
            this.pOSICAOATUALDataGridViewTextBoxColumn.DataPropertyName = "POSICAO_ATUAL";
            this.pOSICAOATUALDataGridViewTextBoxColumn.HeaderText = "POSICAO_ATUAL";
            this.pOSICAOATUALDataGridViewTextBoxColumn.Name = "pOSICAOATUALDataGridViewTextBoxColumn";
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
            // col_pos
            // 
            this.col_pos.DataPropertyName = "N_PDF_CAMPO";
            this.col_pos.HeaderText = "N_PDF_CAMPO";
            this.col_pos.Name = "col_pos";
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
            // dESENHOOPATUALDataGridViewTextBoxColumn
            // 
            this.dESENHOOPATUALDataGridViewTextBoxColumn.DataPropertyName = "DESENHO_OP_ATUAL";
            this.dESENHOOPATUALDataGridViewTextBoxColumn.HeaderText = "DESENHO_OP_ATUAL";
            this.dESENHOOPATUALDataGridViewTextBoxColumn.Name = "dESENHOOPATUALDataGridViewTextBoxColumn";
            // 
            // cODOPDataGridViewTextBoxColumn
            // 
            this.cODOPDataGridViewTextBoxColumn.DataPropertyName = "COD_OP";
            this.cODOPDataGridViewTextBoxColumn.HeaderText = "COD_OP";
            this.cODOPDataGridViewTextBoxColumn.Name = "cODOPDataGridViewTextBoxColumn";
            // 
            // dATAPDFDataGridViewTextBoxColumn
            // 
            this.dATAPDFDataGridViewTextBoxColumn.DataPropertyName = "DATA_PDF";
            this.dATAPDFDataGridViewTextBoxColumn.HeaderText = "DATA_PDF";
            this.dATAPDFDataGridViewTextBoxColumn.Name = "dATAPDFDataGridViewTextBoxColumn";
            // 
            // eNTREGADIADataGridViewTextBoxColumn
            // 
            this.eNTREGADIADataGridViewTextBoxColumn.DataPropertyName = "ENTREGA_DIA";
            this.eNTREGADIADataGridViewTextBoxColumn.HeaderText = "ENTREGA_DIA";
            this.eNTREGADIADataGridViewTextBoxColumn.Name = "eNTREGADIADataGridViewTextBoxColumn";
            // 
            // eNTREGOUDIADataGridViewTextBoxColumn
            // 
            this.eNTREGOUDIADataGridViewTextBoxColumn.DataPropertyName = "ENTREGOU_DIA";
            this.eNTREGOUDIADataGridViewTextBoxColumn.HeaderText = "ENTREGOU_DIA";
            this.eNTREGOUDIADataGridViewTextBoxColumn.Name = "eNTREGOUDIADataGridViewTextBoxColumn";
            // 
            // pRECOUNITDataGridViewTextBoxColumn
            // 
            this.pRECOUNITDataGridViewTextBoxColumn.DataPropertyName = "PRECO_UNIT";
            this.pRECOUNITDataGridViewTextBoxColumn.HeaderText = "PRECO_UNIT";
            this.pRECOUNITDataGridViewTextBoxColumn.Name = "pRECOUNITDataGridViewTextBoxColumn";
            // 
            // cONDPGTODataGridViewTextBoxColumn
            // 
            this.cONDPGTODataGridViewTextBoxColumn.DataPropertyName = "COND_PGTO";
            this.cONDPGTODataGridViewTextBoxColumn.HeaderText = "COND_PGTO";
            this.cONDPGTODataGridViewTextBoxColumn.Name = "cONDPGTODataGridViewTextBoxColumn";
            // 
            // pESOTOTALDataGridViewTextBoxColumn
            // 
            this.pESOTOTALDataGridViewTextBoxColumn.DataPropertyName = "PESO_TOTAL";
            this.pESOTOTALDataGridViewTextBoxColumn.HeaderText = "PESO_TOTAL";
            this.pESOTOTALDataGridViewTextBoxColumn.Name = "pESOTOTALDataGridViewTextBoxColumn";
            // 
            // pDFACEITOEMDataGridViewTextBoxColumn
            // 
            this.pDFACEITOEMDataGridViewTextBoxColumn.DataPropertyName = "PDF_ACEITO_EM";
            this.pDFACEITOEMDataGridViewTextBoxColumn.HeaderText = "PDF_ACEITO_EM";
            this.pDFACEITOEMDataGridViewTextBoxColumn.Name = "pDFACEITOEMDataGridViewTextBoxColumn";
            // 
            // nFNDataGridViewTextBoxColumn
            // 
            this.nFNDataGridViewTextBoxColumn.DataPropertyName = "NF_N";
            this.nFNDataGridViewTextBoxColumn.HeaderText = "NF_N";
            this.nFNDataGridViewTextBoxColumn.Name = "nFNDataGridViewTextBoxColumn";
            // 
            // qDEPDFDataGridViewTextBoxColumn
            // 
            this.qDEPDFDataGridViewTextBoxColumn.DataPropertyName = "QDE_PDF";
            this.qDEPDFDataGridViewTextBoxColumn.HeaderText = "QDE_PDF";
            this.qDEPDFDataGridViewTextBoxColumn.Name = "qDEPDFDataGridViewTextBoxColumn";
            // 
            // qDEESTDataGridViewTextBoxColumn
            // 
            this.qDEESTDataGridViewTextBoxColumn.DataPropertyName = "QDE_EST";
            this.qDEESTDataGridViewTextBoxColumn.HeaderText = "QDE_EST";
            this.qDEESTDataGridViewTextBoxColumn.Name = "qDEESTDataGridViewTextBoxColumn";
            // 
            // qDEFABDataGridViewTextBoxColumn
            // 
            this.qDEFABDataGridViewTextBoxColumn.DataPropertyName = "QDE_FAB";
            this.qDEFABDataGridViewTextBoxColumn.HeaderText = "QDE_FAB";
            this.qDEFABDataGridViewTextBoxColumn.Name = "qDEFABDataGridViewTextBoxColumn";
            // 
            // qDEEMBDataGridViewTextBoxColumn
            // 
            this.qDEEMBDataGridViewTextBoxColumn.DataPropertyName = "QDE_EMB";
            this.qDEEMBDataGridViewTextBoxColumn.HeaderText = "QDE_EMB";
            this.qDEEMBDataGridViewTextBoxColumn.Name = "qDEEMBDataGridViewTextBoxColumn";
            // 
            // qDECAIXASDataGridViewTextBoxColumn
            // 
            this.qDECAIXASDataGridViewTextBoxColumn.DataPropertyName = "QDE_CAIXAS";
            this.qDECAIXASDataGridViewTextBoxColumn.HeaderText = "QDE_CAIXAS";
            this.qDECAIXASDataGridViewTextBoxColumn.Name = "qDECAIXASDataGridViewTextBoxColumn";
            // 
            // col_pos_peca
            // 
            this.col_pos_peca.DataPropertyName = "N_PDF";
            this.col_pos_peca.HeaderText = "N_PDF";
            this.col_pos_peca.Name = "col_pos_peca";
            // 
            // mATERIALOPDataGridViewTextBoxColumn
            // 
            this.mATERIALOPDataGridViewTextBoxColumn.DataPropertyName = "MATERIAL_OP";
            this.mATERIALOPDataGridViewTextBoxColumn.HeaderText = "MATERIAL_OP";
            this.mATERIALOPDataGridViewTextBoxColumn.Name = "mATERIALOPDataGridViewTextBoxColumn";
            // 
            // lOTEDataGridViewTextBoxColumn
            // 
            this.lOTEDataGridViewTextBoxColumn.DataPropertyName = "LOTE";
            this.lOTEDataGridViewTextBoxColumn.HeaderText = "LOTE";
            this.lOTEDataGridViewTextBoxColumn.Name = "lOTEDataGridViewTextBoxColumn";
            // 
            // eSPESSURAOPDataGridViewTextBoxColumn
            // 
            this.eSPESSURAOPDataGridViewTextBoxColumn.DataPropertyName = "ESPESSURA_OP";
            this.eSPESSURAOPDataGridViewTextBoxColumn.HeaderText = "ESPESSURA_OP";
            this.eSPESSURAOPDataGridViewTextBoxColumn.Name = "eSPESSURAOPDataGridViewTextBoxColumn";
            // 
            // oSSEMANADataGridViewTextBoxColumn
            // 
            this.oSSEMANADataGridViewTextBoxColumn.DataPropertyName = "OS_SEMANA";
            this.oSSEMANADataGridViewTextBoxColumn.HeaderText = "OS_SEMANA";
            this.oSSEMANADataGridViewTextBoxColumn.Name = "oSSEMANADataGridViewTextBoxColumn";
            // 
            // cODHORASSEMANADataGridViewTextBoxColumn
            // 
            this.cODHORASSEMANADataGridViewTextBoxColumn.DataPropertyName = "COD_HORAS_SEMANA";
            this.cODHORASSEMANADataGridViewTextBoxColumn.HeaderText = "COD_HORAS_SEMANA";
            this.cODHORASSEMANADataGridViewTextBoxColumn.Name = "cODHORASSEMANADataGridViewTextBoxColumn";
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
            // rOTAHORASSEMANADataGridViewTextBoxColumn
            // 
            this.rOTAHORASSEMANADataGridViewTextBoxColumn.DataPropertyName = "ROTA_HORAS_SEMANA";
            this.rOTAHORASSEMANADataGridViewTextBoxColumn.HeaderText = "ROTA_HORAS_SEMANA";
            this.rOTAHORASSEMANADataGridViewTextBoxColumn.Name = "rOTAHORASSEMANADataGridViewTextBoxColumn";
            // 
            // hORASOPERACAOSEMANADataGridViewTextBoxColumn
            // 
            this.hORASOPERACAOSEMANADataGridViewTextBoxColumn.DataPropertyName = "HORAS_OPERACAO_SEMANA";
            this.hORASOPERACAOSEMANADataGridViewTextBoxColumn.HeaderText = "HORAS_OPERACAO_SEMANA";
            this.hORASOPERACAOSEMANADataGridViewTextBoxColumn.Name = "hORASOPERACAOSEMANADataGridViewTextBoxColumn";
            // 
            // col_pos_sem
            // 
            this.col_pos_sem.DataPropertyName = "POSICAO_OS_SEMANA";
            this.col_pos_sem.HeaderText = "POSICAO_OS_SEMANA";
            this.col_pos_sem.Name = "col_pos_sem";
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
            // form_tira_traco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 372);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvSemana);
            this.Controls.Add(this.dgvRotas);
            this.Controls.Add(this.dgvOp);
            this.Name = "form_tira_traco";
            this.Text = "Tira Traço";
            this.Load += new System.EventHandler(this.form_tira_traco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRotas_campo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ROTAS_CAMPO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSemana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSemana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HORAS_SEMANA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOp;
        private System.Windows.Forms.DataGridView dgvRotas;
        private System.Windows.Forms.DataGridView dgvSemana;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datOp;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Windows.Forms.Button button1;
        private System.Data.DataSet dsOp;
        private System.Data.DataTable OP;
        private System.Data.DataColumn COD_OP;
        private System.Data.DataColumn DATA_PDF;
        private System.Data.DataColumn ENTREGA_DIA;
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
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbOp;
        private System.Windows.Forms.Button button2;
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
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datRotas_campo;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand8;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand6;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand5;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand7;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbRotas_campo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Data.DataSet dsSemana;
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
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datSemana;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand12;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand10;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand9;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand11;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbSemana;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESENHOOPATUALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODOPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAPDFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNTREGADIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNTREGOUDIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRECOUNITDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONDPGTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pESOTOTALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pDFACEITOEMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nFNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qDEPDFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qDEESTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qDEFABDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qDEEMBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qDECAIXASDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_pos_peca;
        private System.Windows.Forms.DataGridViewTextBoxColumn mATERIALOPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSPESSURAOPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESENHOCAMPODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODROTACAMPODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODNUMROTASDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODROTAPECADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oBSERVACAOCAMPODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOSICAOFILACAMPODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORAENTRADADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAENTRADADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORAFECHAMENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAFECHAMENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOSICAOATUALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pREVISAOPRODUCAODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pECASPRODUZIDASDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fINALIZADODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPERADORCAMPODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPROTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPERACAOCAMPODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_pos;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn oSSEMANADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODHORASSEMANADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nSEMANADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aNOSEMANADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPERACAOSEMANADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rOTAHORASSEMANADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORASOPERACAOSEMANADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_pos_sem;
        private System.Windows.Forms.DataGridViewTextBoxColumn sITUACAOROTASEMANADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAINICIOSEMANADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAFIMSEMANADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORASREAISOPERACAODataGridViewTextBoxColumn;
    }
}