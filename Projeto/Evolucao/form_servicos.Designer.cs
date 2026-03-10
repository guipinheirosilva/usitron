namespace Evolucao
{
    partial class form_servicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_servicos));
            this.datRotas_campo = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
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
            this.dgvRotas_campo = new System.Windows.Forms.DataGridView();
            this.col_cod_rota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESENHOCAMPODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nPDFCAMPODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_data_saida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_data_entrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_horas_orcadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_horas_executadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oBSERVACAOCAMPODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORAENTRADADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dt_ent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORAFECHAMENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dt_final = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODNUMROTASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODROTAPECADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOSICAOFILACAMPODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOSICAOATUALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pECASPRODUZIDASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fINALIZADODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPERADORCAMPODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPROTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPERACAOCAMPODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAQUINADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPERADORFINALIZADORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORASTOTAISROTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORASPARADASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oSCONJUNTASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rETRABALHOROTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORASOPERADORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAQUINAFECHAMENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oSCONJUNTASFECHAMENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_semana = new System.Windows.Forms.TextBox();
            this.tb_anterior = new System.Windows.Forms.Button();
            this.tb_proximo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.cbOperacoes = new System.Windows.Forms.ComboBox();
            this.dsTipos_operacoes = new System.Data.DataSet();
            this.TIPOS_OPERACOES = new System.Data.DataTable();
            this.COD_TIPO = new System.Data.DataColumn();
            this.QDE_MAQUINAS = new System.Data.DataColumn();
            this.TIPO = new System.Data.DataColumn();
            this.fbCommand5 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand6 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand7 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand8 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand9 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand10 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand11 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand12 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.datTipos_operacoes = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand16 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand14 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand13 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand15 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_horas_orcadas = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_horas_executadas = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_diferenca = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lb_eficiência = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lb_vermelho = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_amarelo = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lb_verde = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lb_total = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_porc_vermelho = new System.Windows.Forms.Label();
            this.lb_porc_amarelo = new System.Windows.Forms.Label();
            this.lb_porc_verde = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsRotas_campo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ROTAS_CAMPO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRotas_campo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTipos_operacoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TIPOS_OPERACOES)).BeginInit();
            this.SuspendLayout();
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
            this.fbCommand1.CommandText = "select * from rotas_campo order by desenho_campo";
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
            this.OS_CONJUNTAS_FECHAMENTO});
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
            // dgvRotas_campo
            // 
            this.dgvRotas_campo.AllowUserToAddRows = false;
            this.dgvRotas_campo.AutoGenerateColumns = false;
            this.dgvRotas_campo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRotas_campo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_cod_rota,
            this.dESENHOCAMPODataGridViewTextBoxColumn,
            this.nPDFCAMPODataGridViewTextBoxColumn,
            this.col_data_saida,
            this.col_data_entrega,
            this.col_horas_orcadas,
            this.col_horas_executadas,
            this.oBSERVACAOCAMPODataGridViewTextBoxColumn,
            this.hORAENTRADADataGridViewTextBoxColumn,
            this.col_dt_ent,
            this.hORAFECHAMENTODataGridViewTextBoxColumn,
            this.col_dt_final,
            this.cODNUMROTASDataGridViewTextBoxColumn,
            this.cODROTAPECADataGridViewTextBoxColumn,
            this.pOSICAOFILACAMPODataGridViewTextBoxColumn,
            this.pOSICAOATUALDataGridViewTextBoxColumn,
            this.pECASPRODUZIDASDataGridViewTextBoxColumn,
            this.fINALIZADODataGridViewTextBoxColumn,
            this.oPERADORCAMPODataGridViewTextBoxColumn,
            this.oPROTADataGridViewTextBoxColumn,
            this.oPERACAOCAMPODataGridViewTextBoxColumn,
            this.mAQUINADataGridViewTextBoxColumn,
            this.oPERADORFINALIZADORDataGridViewTextBoxColumn,
            this.hORASTOTAISROTADataGridViewTextBoxColumn,
            this.hORASPARADASDataGridViewTextBoxColumn,
            this.oSCONJUNTASDataGridViewTextBoxColumn,
            this.rETRABALHOROTADataGridViewTextBoxColumn,
            this.hORASOPERADORDataGridViewTextBoxColumn,
            this.mAQUINAFECHAMENTODataGridViewTextBoxColumn,
            this.oSCONJUNTASFECHAMENTODataGridViewTextBoxColumn});
            this.dgvRotas_campo.DataMember = "ROTAS_CAMPO";
            this.dgvRotas_campo.DataSource = this.dsRotas_campo;
            this.dgvRotas_campo.Location = new System.Drawing.Point(12, 87);
            this.dgvRotas_campo.Name = "dgvRotas_campo";
            this.dgvRotas_campo.Size = new System.Drawing.Size(937, 480);
            this.dgvRotas_campo.TabIndex = 0;
            this.dgvRotas_campo.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRotas_campo_CellMouseDoubleClick);
            this.dgvRotas_campo.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRotas_campo_CellEnter);
            // 
            // col_cod_rota
            // 
            this.col_cod_rota.DataPropertyName = "COD_ROTA_CAMPO";
            this.col_cod_rota.HeaderText = "Cod.";
            this.col_cod_rota.Name = "col_cod_rota";
            this.col_cod_rota.Width = 30;
            // 
            // dESENHOCAMPODataGridViewTextBoxColumn
            // 
            this.dESENHOCAMPODataGridViewTextBoxColumn.DataPropertyName = "DESENHO_CAMPO";
            this.dESENHOCAMPODataGridViewTextBoxColumn.HeaderText = "OS";
            this.dESENHOCAMPODataGridViewTextBoxColumn.Name = "dESENHOCAMPODataGridViewTextBoxColumn";
            this.dESENHOCAMPODataGridViewTextBoxColumn.Width = 70;
            // 
            // nPDFCAMPODataGridViewTextBoxColumn
            // 
            this.nPDFCAMPODataGridViewTextBoxColumn.DataPropertyName = "N_PDF_CAMPO";
            this.nPDFCAMPODataGridViewTextBoxColumn.HeaderText = "Pos";
            this.nPDFCAMPODataGridViewTextBoxColumn.Name = "nPDFCAMPODataGridViewTextBoxColumn";
            this.nPDFCAMPODataGridViewTextBoxColumn.Width = 30;
            // 
            // col_data_saida
            // 
            this.col_data_saida.DataPropertyName = "DATA_ENTRADA_PREV";
            this.col_data_saida.HeaderText = "Data de Saída";
            this.col_data_saida.Name = "col_data_saida";
            this.col_data_saida.Width = 80;
            // 
            // col_data_entrega
            // 
            this.col_data_entrega.DataPropertyName = "DATA_FECHAMENTO_PREV";
            this.col_data_entrega.HeaderText = "Data de Entrega";
            this.col_data_entrega.Name = "col_data_entrega";
            this.col_data_entrega.Width = 80;
            // 
            // col_horas_orcadas
            // 
            this.col_horas_orcadas.DataPropertyName = "PREVISAO_PRODUCAO";
            this.col_horas_orcadas.HeaderText = "Horas Orçadas";
            this.col_horas_orcadas.Name = "col_horas_orcadas";
            this.col_horas_orcadas.Width = 30;
            // 
            // col_horas_executadas
            // 
            this.col_horas_executadas.DataPropertyName = "SALDO_HORAS";
            this.col_horas_executadas.HeaderText = "Horas Exec.";
            this.col_horas_executadas.Name = "col_horas_executadas";
            this.col_horas_executadas.Width = 30;
            // 
            // oBSERVACAOCAMPODataGridViewTextBoxColumn
            // 
            this.oBSERVACAOCAMPODataGridViewTextBoxColumn.DataPropertyName = "OBSERVACAO_CAMPO";
            this.oBSERVACAOCAMPODataGridViewTextBoxColumn.HeaderText = "Observações";
            this.oBSERVACAOCAMPODataGridViewTextBoxColumn.Name = "oBSERVACAOCAMPODataGridViewTextBoxColumn";
            // 
            // hORAENTRADADataGridViewTextBoxColumn
            // 
            this.hORAENTRADADataGridViewTextBoxColumn.DataPropertyName = "HORA_ENTRADA";
            this.hORAENTRADADataGridViewTextBoxColumn.HeaderText = "Hora Entrada";
            this.hORAENTRADADataGridViewTextBoxColumn.Name = "hORAENTRADADataGridViewTextBoxColumn";
            this.hORAENTRADADataGridViewTextBoxColumn.Width = 70;
            // 
            // col_dt_ent
            // 
            this.col_dt_ent.DataPropertyName = "DATA_ENTRADA";
            this.col_dt_ent.HeaderText = "Data Entrada";
            this.col_dt_ent.Name = "col_dt_ent";
            this.col_dt_ent.Width = 70;
            // 
            // hORAFECHAMENTODataGridViewTextBoxColumn
            // 
            this.hORAFECHAMENTODataGridViewTextBoxColumn.DataPropertyName = "HORA_FECHAMENTO";
            this.hORAFECHAMENTODataGridViewTextBoxColumn.HeaderText = "Hora Finaliza";
            this.hORAFECHAMENTODataGridViewTextBoxColumn.Name = "hORAFECHAMENTODataGridViewTextBoxColumn";
            this.hORAFECHAMENTODataGridViewTextBoxColumn.Width = 70;
            // 
            // col_dt_final
            // 
            this.col_dt_final.DataPropertyName = "DATA_FECHAMENTO";
            this.col_dt_final.HeaderText = "Data Finaliza";
            this.col_dt_final.Name = "col_dt_final";
            this.col_dt_final.Width = 70;
            // 
            // cODNUMROTASDataGridViewTextBoxColumn
            // 
            this.cODNUMROTASDataGridViewTextBoxColumn.DataPropertyName = "COD_NUM_ROTAS";
            this.cODNUMROTASDataGridViewTextBoxColumn.HeaderText = "COD_NUM_ROTAS";
            this.cODNUMROTASDataGridViewTextBoxColumn.Name = "cODNUMROTASDataGridViewTextBoxColumn";
            this.cODNUMROTASDataGridViewTextBoxColumn.Visible = false;
            // 
            // cODROTAPECADataGridViewTextBoxColumn
            // 
            this.cODROTAPECADataGridViewTextBoxColumn.DataPropertyName = "COD_ROTA_PECA";
            this.cODROTAPECADataGridViewTextBoxColumn.HeaderText = "COD_ROTA_PECA";
            this.cODROTAPECADataGridViewTextBoxColumn.Name = "cODROTAPECADataGridViewTextBoxColumn";
            this.cODROTAPECADataGridViewTextBoxColumn.Visible = false;
            // 
            // pOSICAOFILACAMPODataGridViewTextBoxColumn
            // 
            this.pOSICAOFILACAMPODataGridViewTextBoxColumn.DataPropertyName = "POSICAO_FILA_CAMPO";
            this.pOSICAOFILACAMPODataGridViewTextBoxColumn.HeaderText = "POSICAO_FILA_CAMPO";
            this.pOSICAOFILACAMPODataGridViewTextBoxColumn.Name = "pOSICAOFILACAMPODataGridViewTextBoxColumn";
            this.pOSICAOFILACAMPODataGridViewTextBoxColumn.Visible = false;
            // 
            // pOSICAOATUALDataGridViewTextBoxColumn
            // 
            this.pOSICAOATUALDataGridViewTextBoxColumn.DataPropertyName = "POSICAO_ATUAL";
            this.pOSICAOATUALDataGridViewTextBoxColumn.HeaderText = "Posição Atual";
            this.pOSICAOATUALDataGridViewTextBoxColumn.Name = "pOSICAOATUALDataGridViewTextBoxColumn";
            this.pOSICAOATUALDataGridViewTextBoxColumn.Width = 70;
            // 
            // pECASPRODUZIDASDataGridViewTextBoxColumn
            // 
            this.pECASPRODUZIDASDataGridViewTextBoxColumn.DataPropertyName = "PECAS_PRODUZIDAS";
            this.pECASPRODUZIDASDataGridViewTextBoxColumn.HeaderText = "PECAS_PRODUZIDAS";
            this.pECASPRODUZIDASDataGridViewTextBoxColumn.Name = "pECASPRODUZIDASDataGridViewTextBoxColumn";
            this.pECASPRODUZIDASDataGridViewTextBoxColumn.Visible = false;
            // 
            // fINALIZADODataGridViewTextBoxColumn
            // 
            this.fINALIZADODataGridViewTextBoxColumn.DataPropertyName = "FINALIZADO";
            this.fINALIZADODataGridViewTextBoxColumn.HeaderText = "FINALIZADO";
            this.fINALIZADODataGridViewTextBoxColumn.Name = "fINALIZADODataGridViewTextBoxColumn";
            this.fINALIZADODataGridViewTextBoxColumn.Visible = false;
            // 
            // oPERADORCAMPODataGridViewTextBoxColumn
            // 
            this.oPERADORCAMPODataGridViewTextBoxColumn.DataPropertyName = "OPERADOR_CAMPO";
            this.oPERADORCAMPODataGridViewTextBoxColumn.HeaderText = "OPERADOR_CAMPO";
            this.oPERADORCAMPODataGridViewTextBoxColumn.Name = "oPERADORCAMPODataGridViewTextBoxColumn";
            this.oPERADORCAMPODataGridViewTextBoxColumn.Visible = false;
            // 
            // oPROTADataGridViewTextBoxColumn
            // 
            this.oPROTADataGridViewTextBoxColumn.DataPropertyName = "OP_ROTA";
            this.oPROTADataGridViewTextBoxColumn.HeaderText = "OP_ROTA";
            this.oPROTADataGridViewTextBoxColumn.Name = "oPROTADataGridViewTextBoxColumn";
            this.oPROTADataGridViewTextBoxColumn.Visible = false;
            // 
            // oPERACAOCAMPODataGridViewTextBoxColumn
            // 
            this.oPERACAOCAMPODataGridViewTextBoxColumn.DataPropertyName = "OPERACAO_CAMPO";
            this.oPERACAOCAMPODataGridViewTextBoxColumn.HeaderText = "Operação";
            this.oPERACAOCAMPODataGridViewTextBoxColumn.Name = "oPERACAOCAMPODataGridViewTextBoxColumn";
            this.oPERACAOCAMPODataGridViewTextBoxColumn.Width = 70;
            // 
            // mAQUINADataGridViewTextBoxColumn
            // 
            this.mAQUINADataGridViewTextBoxColumn.DataPropertyName = "MAQUINA";
            this.mAQUINADataGridViewTextBoxColumn.HeaderText = "MAQUINA";
            this.mAQUINADataGridViewTextBoxColumn.Name = "mAQUINADataGridViewTextBoxColumn";
            this.mAQUINADataGridViewTextBoxColumn.Visible = false;
            // 
            // oPERADORFINALIZADORDataGridViewTextBoxColumn
            // 
            this.oPERADORFINALIZADORDataGridViewTextBoxColumn.DataPropertyName = "OPERADOR_FINALIZADOR";
            this.oPERADORFINALIZADORDataGridViewTextBoxColumn.HeaderText = "OPERADOR_FINALIZADOR";
            this.oPERADORFINALIZADORDataGridViewTextBoxColumn.Name = "oPERADORFINALIZADORDataGridViewTextBoxColumn";
            this.oPERADORFINALIZADORDataGridViewTextBoxColumn.Visible = false;
            // 
            // hORASTOTAISROTADataGridViewTextBoxColumn
            // 
            this.hORASTOTAISROTADataGridViewTextBoxColumn.DataPropertyName = "HORAS_TOTAIS_ROTA";
            this.hORASTOTAISROTADataGridViewTextBoxColumn.HeaderText = "HORAS_TOTAIS_ROTA";
            this.hORASTOTAISROTADataGridViewTextBoxColumn.Name = "hORASTOTAISROTADataGridViewTextBoxColumn";
            this.hORASTOTAISROTADataGridViewTextBoxColumn.Visible = false;
            // 
            // hORASPARADASDataGridViewTextBoxColumn
            // 
            this.hORASPARADASDataGridViewTextBoxColumn.DataPropertyName = "HORAS_PARADAS";
            this.hORASPARADASDataGridViewTextBoxColumn.HeaderText = "HORAS_PARADAS";
            this.hORASPARADASDataGridViewTextBoxColumn.Name = "hORASPARADASDataGridViewTextBoxColumn";
            this.hORASPARADASDataGridViewTextBoxColumn.Visible = false;
            // 
            // oSCONJUNTASDataGridViewTextBoxColumn
            // 
            this.oSCONJUNTASDataGridViewTextBoxColumn.DataPropertyName = "OS_CONJUNTAS";
            this.oSCONJUNTASDataGridViewTextBoxColumn.HeaderText = "OS_CONJUNTAS";
            this.oSCONJUNTASDataGridViewTextBoxColumn.Name = "oSCONJUNTASDataGridViewTextBoxColumn";
            this.oSCONJUNTASDataGridViewTextBoxColumn.Visible = false;
            // 
            // rETRABALHOROTADataGridViewTextBoxColumn
            // 
            this.rETRABALHOROTADataGridViewTextBoxColumn.DataPropertyName = "RETRABALHO_ROTA";
            this.rETRABALHOROTADataGridViewTextBoxColumn.HeaderText = "RETRABALHO_ROTA";
            this.rETRABALHOROTADataGridViewTextBoxColumn.Name = "rETRABALHOROTADataGridViewTextBoxColumn";
            this.rETRABALHOROTADataGridViewTextBoxColumn.Visible = false;
            // 
            // hORASOPERADORDataGridViewTextBoxColumn
            // 
            this.hORASOPERADORDataGridViewTextBoxColumn.DataPropertyName = "HORAS_OPERADOR";
            this.hORASOPERADORDataGridViewTextBoxColumn.HeaderText = "HORAS_OPERADOR";
            this.hORASOPERADORDataGridViewTextBoxColumn.Name = "hORASOPERADORDataGridViewTextBoxColumn";
            this.hORASOPERADORDataGridViewTextBoxColumn.Visible = false;
            // 
            // mAQUINAFECHAMENTODataGridViewTextBoxColumn
            // 
            this.mAQUINAFECHAMENTODataGridViewTextBoxColumn.DataPropertyName = "MAQUINA_FECHAMENTO";
            this.mAQUINAFECHAMENTODataGridViewTextBoxColumn.HeaderText = "MAQUINA_FECHAMENTO";
            this.mAQUINAFECHAMENTODataGridViewTextBoxColumn.Name = "mAQUINAFECHAMENTODataGridViewTextBoxColumn";
            this.mAQUINAFECHAMENTODataGridViewTextBoxColumn.Visible = false;
            // 
            // oSCONJUNTASFECHAMENTODataGridViewTextBoxColumn
            // 
            this.oSCONJUNTASFECHAMENTODataGridViewTextBoxColumn.DataPropertyName = "OS_CONJUNTAS_FECHAMENTO";
            this.oSCONJUNTASFECHAMENTODataGridViewTextBoxColumn.HeaderText = "OS_CONJUNTAS_FECHAMENTO";
            this.oSCONJUNTASFECHAMENTODataGridViewTextBoxColumn.Name = "oSCONJUNTASFECHAMENTODataGridViewTextBoxColumn";
            this.oSCONJUNTASFECHAMENTODataGridViewTextBoxColumn.Visible = false;
            // 
            // tb_semana
            // 
            this.tb_semana.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_semana.Location = new System.Drawing.Point(390, 43);
            this.tb_semana.Name = "tb_semana";
            this.tb_semana.Size = new System.Drawing.Size(68, 38);
            this.tb_semana.TabIndex = 1;
            // 
            // tb_anterior
            // 
            this.tb_anterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_anterior.Location = new System.Drawing.Point(291, 43);
            this.tb_anterior.Name = "tb_anterior";
            this.tb_anterior.Size = new System.Drawing.Size(75, 36);
            this.tb_anterior.TabIndex = 2;
            this.tb_anterior.Text = "ANTERIOR";
            this.tb_anterior.UseVisualStyleBackColor = true;
            this.tb_anterior.Click += new System.EventHandler(this.tb_anterior_Click);
            // 
            // tb_proximo
            // 
            this.tb_proximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_proximo.Location = new System.Drawing.Point(485, 43);
            this.tb_proximo.Name = "tb_proximo";
            this.tb_proximo.Size = new System.Drawing.Size(75, 36);
            this.tb_proximo.TabIndex = 3;
            this.tb_proximo.Text = "PRÓXIMO";
            this.tb_proximo.UseVisualStyleBackColor = true;
            this.tb_proximo.Click += new System.EventHandler(this.tb_proximo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(401, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Semana";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(580, 43);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 36);
            this.button3.TabIndex = 5;
            this.button3.Text = "Pesquisar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cbOperacoes
            // 
            this.cbOperacoes.DataSource = this.dsTipos_operacoes;
            this.cbOperacoes.DisplayMember = "TIPOS_OPERACOES.TIPO";
            this.cbOperacoes.FormattingEnabled = true;
            this.cbOperacoes.Location = new System.Drawing.Point(147, 52);
            this.cbOperacoes.Name = "cbOperacoes";
            this.cbOperacoes.Size = new System.Drawing.Size(121, 21);
            this.cbOperacoes.TabIndex = 6;
            // 
            // dsTipos_operacoes
            // 
            this.dsTipos_operacoes.DataSetName = "dsTipos_operacoes";
            this.dsTipos_operacoes.Namespace = "http://www.tempuri.org/dsTipos_operacoes.xsd";
            this.dsTipos_operacoes.Tables.AddRange(new System.Data.DataTable[] {
            this.TIPOS_OPERACOES});
            // 
            // TIPOS_OPERACOES
            // 
            this.TIPOS_OPERACOES.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_TIPO,
            this.QDE_MAQUINAS,
            this.TIPO});
            this.TIPOS_OPERACOES.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_TIPO"}, false)});
            this.TIPOS_OPERACOES.TableName = "TIPOS_OPERACOES";
            // 
            // COD_TIPO
            // 
            this.COD_TIPO.ColumnName = "COD_TIPO";
            this.COD_TIPO.DataType = typeof(int);
            // 
            // QDE_MAQUINAS
            // 
            this.QDE_MAQUINAS.ColumnName = "QDE_MAQUINAS";
            this.QDE_MAQUINAS.DataType = typeof(int);
            // 
            // TIPO
            // 
            this.TIPO.ColumnName = "TIPO";
            this.TIPO.MaxLength = 40;
            // 
            // fbCommand5
            // 
            this.fbCommand5.CommandTimeout = 30;
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
            // fbCommand9
            // 
            this.fbCommand9.CommandText = "select * from tipos_operacoes";
            this.fbCommand9.CommandTimeout = 30;
            this.fbCommand9.Connection = this.fbConnection1;
            // 
            // fbCommand10
            // 
            this.fbCommand10.CommandTimeout = 30;
            // 
            // fbCommand11
            // 
            this.fbCommand11.CommandTimeout = 30;
            // 
            // fbCommand12
            // 
            this.fbCommand12.CommandTimeout = 30;
            // 
            // datTipos_operacoes
            // 
            this.datTipos_operacoes.DeleteCommand = this.fbCommand16;
            this.datTipos_operacoes.InsertCommand = this.fbCommand14;
            this.datTipos_operacoes.SelectCommand = this.fbCommand13;
            this.datTipos_operacoes.UpdateCommand = this.fbCommand15;
            // 
            // fbCommand16
            // 
            this.fbCommand16.CommandTimeout = 30;
            // 
            // fbCommand14
            // 
            this.fbCommand14.CommandTimeout = 30;
            // 
            // fbCommand13
            // 
            this.fbCommand13.CommandText = "select * from tipos_operacoes order by tipo";
            this.fbCommand13.CommandTimeout = 30;
            this.fbCommand13.Connection = this.fbConnection1;
            // 
            // fbCommand15
            // 
            this.fbCommand15.CommandTimeout = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 579);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Foram orçadas";
            // 
            // lb_horas_orcadas
            // 
            this.lb_horas_orcadas.AutoSize = true;
            this.lb_horas_orcadas.Location = new System.Drawing.Point(217, 579);
            this.lb_horas_orcadas.Name = "lb_horas_orcadas";
            this.lb_horas_orcadas.Size = new System.Drawing.Size(13, 13);
            this.lb_horas_orcadas.TabIndex = 8;
            this.lb_horas_orcadas.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 579);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "horas.              ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(254, 603);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "horas.          ";
            // 
            // lb_horas_executadas
            // 
            this.lb_horas_executadas.AutoSize = true;
            this.lb_horas_executadas.Location = new System.Drawing.Point(217, 603);
            this.lb_horas_executadas.Name = "lb_horas_executadas";
            this.lb_horas_executadas.Size = new System.Drawing.Size(13, 13);
            this.lb_horas_executadas.TabIndex = 11;
            this.lb_horas_executadas.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(117, 603);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Foram executadas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(254, 626);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "horas.          ";
            // 
            // lb_diferenca
            // 
            this.lb_diferenca.AutoSize = true;
            this.lb_diferenca.Location = new System.Drawing.Point(217, 626);
            this.lb_diferenca.Name = "lb_diferenca";
            this.lb_diferenca.Size = new System.Drawing.Size(13, 13);
            this.lb_diferenca.TabIndex = 14;
            this.lb_diferenca.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(117, 626);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Diferença de";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(254, 649);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "%.                 ";
            // 
            // lb_eficiência
            // 
            this.lb_eficiência.AutoSize = true;
            this.lb_eficiência.Location = new System.Drawing.Point(217, 649);
            this.lb_eficiência.Name = "lb_eficiência";
            this.lb_eficiência.Size = new System.Drawing.Size(13, 13);
            this.lb_eficiência.TabIndex = 17;
            this.lb_eficiência.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(117, 649);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Eficiência de";
            // 
            // lb_vermelho
            // 
            this.lb_vermelho.AutoSize = true;
            this.lb_vermelho.Location = new System.Drawing.Point(519, 626);
            this.lb_vermelho.Name = "lb_vermelho";
            this.lb_vermelho.Size = new System.Drawing.Size(13, 13);
            this.lb_vermelho.TabIndex = 24;
            this.lb_vermelho.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(419, 626);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Vermelho";
            // 
            // lb_amarelo
            // 
            this.lb_amarelo.AutoSize = true;
            this.lb_amarelo.Location = new System.Drawing.Point(519, 603);
            this.lb_amarelo.Name = "lb_amarelo";
            this.lb_amarelo.Size = new System.Drawing.Size(13, 13);
            this.lb_amarelo.TabIndex = 22;
            this.lb_amarelo.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Gold;
            this.label13.Location = new System.Drawing.Point(419, 603);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Amarelo";
            // 
            // lb_verde
            // 
            this.lb_verde.AutoSize = true;
            this.lb_verde.Location = new System.Drawing.Point(519, 579);
            this.lb_verde.Name = "lb_verde";
            this.lb_verde.Size = new System.Drawing.Size(13, 13);
            this.lb_verde.TabIndex = 20;
            this.lb_verde.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label15.Location = new System.Drawing.Point(419, 579);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 19;
            this.label15.Text = "Verde";
            // 
            // lb_total
            // 
            this.lb_total.AutoSize = true;
            this.lb_total.Location = new System.Drawing.Point(519, 649);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(13, 13);
            this.lb_total.TabIndex = 26;
            this.lb_total.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(419, 649);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(564, 649);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "100";
            // 
            // lb_porc_vermelho
            // 
            this.lb_porc_vermelho.AutoSize = true;
            this.lb_porc_vermelho.Location = new System.Drawing.Point(564, 626);
            this.lb_porc_vermelho.Name = "lb_porc_vermelho";
            this.lb_porc_vermelho.Size = new System.Drawing.Size(13, 13);
            this.lb_porc_vermelho.TabIndex = 29;
            this.lb_porc_vermelho.Text = "0";
            // 
            // lb_porc_amarelo
            // 
            this.lb_porc_amarelo.AutoSize = true;
            this.lb_porc_amarelo.Location = new System.Drawing.Point(564, 603);
            this.lb_porc_amarelo.Name = "lb_porc_amarelo";
            this.lb_porc_amarelo.Size = new System.Drawing.Size(13, 13);
            this.lb_porc_amarelo.TabIndex = 28;
            this.lb_porc_amarelo.Text = "0";
            // 
            // lb_porc_verde
            // 
            this.lb_porc_verde.AutoSize = true;
            this.lb_porc_verde.Location = new System.Drawing.Point(564, 579);
            this.lb_porc_verde.Name = "lb_porc_verde";
            this.lb_porc_verde.Size = new System.Drawing.Size(13, 13);
            this.lb_porc_verde.TabIndex = 27;
            this.lb_porc_verde.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(599, 579);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(69, 13);
            this.label18.TabIndex = 31;
            this.label18.Text = "%.                 ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(599, 603);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(69, 13);
            this.label19.TabIndex = 32;
            this.label19.Text = "%.                 ";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(599, 626);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(69, 13);
            this.label20.TabIndex = 33;
            this.label20.Text = "%.                 ";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(599, 649);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(69, 13);
            this.label21.TabIndex = 34;
            this.label21.Text = "%.                 ";
            // 
            // form_servicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 697);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lb_porc_vermelho);
            this.Controls.Add(this.lb_porc_amarelo);
            this.Controls.Add(this.lb_porc_verde);
            this.Controls.Add(this.lb_total);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lb_vermelho);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lb_amarelo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lb_verde);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lb_eficiência);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lb_diferenca);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_horas_executadas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_horas_orcadas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbOperacoes);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_proximo);
            this.Controls.Add(this.tb_anterior);
            this.Controls.Add(this.tb_semana);
            this.Controls.Add(this.dgvRotas_campo);
            this.Name = "form_servicos";
            this.Text = "Serviços";
            this.Load += new System.EventHandler(this.form_servicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsRotas_campo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ROTAS_CAMPO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRotas_campo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTipos_operacoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TIPOS_OPERACOES)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datRotas_campo;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
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
        private System.Windows.Forms.DataGridView dgvRotas_campo;
        private System.Windows.Forms.TextBox tb_semana;
        private System.Windows.Forms.Button tb_anterior;
        private System.Windows.Forms.Button tb_proximo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cbOperacoes;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand5;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand6;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand7;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand8;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand12;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand10;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand9;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand11;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datTipos_operacoes;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand16;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand14;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand13;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand15;
        private System.Data.DataSet dsTipos_operacoes;
        private System.Data.DataTable TIPOS_OPERACOES;
        private System.Data.DataColumn COD_TIPO;
        private System.Data.DataColumn QDE_MAQUINAS;
        private System.Data.DataColumn TIPO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_horas_orcadas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_horas_executadas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_diferenca;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lb_eficiência;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod_rota;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESENHOCAMPODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nPDFCAMPODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_data_saida;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_data_entrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_horas_orcadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_horas_executadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn oBSERVACAOCAMPODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORAENTRADADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dt_ent;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORAFECHAMENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dt_final;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODNUMROTASDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODROTAPECADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOSICAOFILACAMPODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOSICAOATUALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pECASPRODUZIDASDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fINALIZADODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPERADORCAMPODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPROTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPERACAOCAMPODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAQUINADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPERADORFINALIZADORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORASTOTAISROTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORASPARADASDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oSCONJUNTASDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rETRABALHOROTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORASOPERADORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAQUINAFECHAMENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oSCONJUNTASFECHAMENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lb_vermelho;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lb_amarelo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lb_verde;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lb_total;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_porc_vermelho;
        private System.Windows.Forms.Label lb_porc_amarelo;
        private System.Windows.Forms.Label lb_porc_verde;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
    }
}