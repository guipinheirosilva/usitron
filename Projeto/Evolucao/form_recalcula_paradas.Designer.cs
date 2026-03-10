namespace Evolucao
{
    partial class form_recalcula_paradas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_recalcula_paradas));
            this.button1 = new System.Windows.Forms.Button();
            this.datParadas = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsParadas = new System.Data.DataSet();
            this.PARADAS = new System.Data.DataTable();
            this.COD_PARADA = new System.Data.DataColumn();
            this.TIPO_PARADA = new System.Data.DataColumn();
            this.HORA_INICIO = new System.Data.DataColumn();
            this.DATA_INICIO = new System.Data.DataColumn();
            this.HORA_TERMINO = new System.Data.DataColumn();
            this.DATA_TERMINO = new System.Data.DataColumn();
            this.N_ROTAS_CAMPO = new System.Data.DataColumn();
            this.OBS_PARADA = new System.Data.DataColumn();
            this.PECAS_PRODUZIDAS_PARADA = new System.Data.DataColumn();
            this.OPERADOR = new System.Data.DataColumn();
            this.MAQUINA_PARADA = new System.Data.DataColumn();
            this.PARADA_FINALIZADA = new System.Data.DataColumn();
            this.COD_PARADA_NUM = new System.Data.DataColumn();
            this.OPERADOR_FINALIZADOR_PARADA = new System.Data.DataColumn();
            this.TOTAL_HORAS_PARADA = new System.Data.DataColumn();
            this.datRotas_campo = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand8 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand6 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand5 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand7 = new FirebirdSql.Data.FirebirdClient.FbCommand();
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
            this.dgvParadas = new System.Windows.Forms.DataGridView();
            this.tb_cod_parada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIPOPARADADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_hora_inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_data_inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_hora_termino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_data_termino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_rota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oBSPARADADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pECASPRODUZIDASPARADADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPERADORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAQUINAPARADADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pARADAFINALIZADADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODPARADANUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPERADORFINALIZADORPARADADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOTALHORASPARADADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dsParadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PARADAS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRotas_campo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ROTAS_CAMPO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParadas)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Recalcula horas paradas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // datParadas
            // 
            this.datParadas.DeleteCommand = this.fbCommand4;
            this.datParadas.InsertCommand = this.fbCommand2;
            this.datParadas.SelectCommand = this.fbCommand1;
            this.datParadas.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * from paradas";
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
            // dsParadas
            // 
            this.dsParadas.DataSetName = "dsParadas";
            this.dsParadas.Namespace = "http://www.tempuri.org/dsParadas.xsd";
            this.dsParadas.Tables.AddRange(new System.Data.DataTable[] {
            this.PARADAS});
            // 
            // PARADAS
            // 
            this.PARADAS.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_PARADA,
            this.TIPO_PARADA,
            this.HORA_INICIO,
            this.DATA_INICIO,
            this.HORA_TERMINO,
            this.DATA_TERMINO,
            this.N_ROTAS_CAMPO,
            this.OBS_PARADA,
            this.PECAS_PRODUZIDAS_PARADA,
            this.OPERADOR,
            this.MAQUINA_PARADA,
            this.PARADA_FINALIZADA,
            this.COD_PARADA_NUM,
            this.OPERADOR_FINALIZADOR_PARADA,
            this.TOTAL_HORAS_PARADA});
            this.PARADAS.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_PARADA"}, true)});
            this.PARADAS.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_PARADA};
            this.PARADAS.TableName = "PARADAS";
            // 
            // COD_PARADA
            // 
            this.COD_PARADA.AllowDBNull = false;
            this.COD_PARADA.ColumnName = "COD_PARADA";
            this.COD_PARADA.DataType = typeof(int);
            // 
            // TIPO_PARADA
            // 
            this.TIPO_PARADA.ColumnName = "TIPO_PARADA";
            this.TIPO_PARADA.MaxLength = 30;
            // 
            // HORA_INICIO
            // 
            this.HORA_INICIO.ColumnName = "HORA_INICIO";
            this.HORA_INICIO.MaxLength = 20;
            // 
            // DATA_INICIO
            // 
            this.DATA_INICIO.ColumnName = "DATA_INICIO";
            this.DATA_INICIO.DataType = typeof(System.DateTime);
            // 
            // HORA_TERMINO
            // 
            this.HORA_TERMINO.ColumnName = "HORA_TERMINO";
            this.HORA_TERMINO.MaxLength = 20;
            // 
            // DATA_TERMINO
            // 
            this.DATA_TERMINO.ColumnName = "DATA_TERMINO";
            this.DATA_TERMINO.DataType = typeof(System.DateTime);
            // 
            // N_ROTAS_CAMPO
            // 
            this.N_ROTAS_CAMPO.ColumnName = "N_ROTAS_CAMPO";
            this.N_ROTAS_CAMPO.MaxLength = 30;
            // 
            // OBS_PARADA
            // 
            this.OBS_PARADA.ColumnName = "OBS_PARADA";
            this.OBS_PARADA.MaxLength = 100;
            // 
            // PECAS_PRODUZIDAS_PARADA
            // 
            this.PECAS_PRODUZIDAS_PARADA.ColumnName = "PECAS_PRODUZIDAS_PARADA";
            this.PECAS_PRODUZIDAS_PARADA.DataType = typeof(int);
            // 
            // OPERADOR
            // 
            this.OPERADOR.ColumnName = "OPERADOR";
            this.OPERADOR.MaxLength = 50;
            // 
            // MAQUINA_PARADA
            // 
            this.MAQUINA_PARADA.ColumnName = "MAQUINA_PARADA";
            this.MAQUINA_PARADA.MaxLength = 30;
            // 
            // PARADA_FINALIZADA
            // 
            this.PARADA_FINALIZADA.ColumnName = "PARADA_FINALIZADA";
            this.PARADA_FINALIZADA.MaxLength = 10;
            // 
            // COD_PARADA_NUM
            // 
            this.COD_PARADA_NUM.ColumnName = "COD_PARADA_NUM";
            this.COD_PARADA_NUM.MaxLength = 15;
            // 
            // OPERADOR_FINALIZADOR_PARADA
            // 
            this.OPERADOR_FINALIZADOR_PARADA.ColumnName = "OPERADOR_FINALIZADOR_PARADA";
            this.OPERADOR_FINALIZADOR_PARADA.MaxLength = 30;
            // 
            // TOTAL_HORAS_PARADA
            // 
            this.TOTAL_HORAS_PARADA.ColumnName = "TOTAL_HORAS_PARADA";
            this.TOTAL_HORAS_PARADA.DataType = typeof(double);
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
            this.fbCommand5.CommandText = "select * from rotas_campo";
            this.fbCommand5.CommandTimeout = 30;
            this.fbCommand5.Connection = this.fbConnection1;
            // 
            // fbCommand7
            // 
            this.fbCommand7.CommandTimeout = 30;
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
            // dgvParadas
            // 
            this.dgvParadas.AutoGenerateColumns = false;
            this.dgvParadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tb_cod_parada,
            this.tIPOPARADADataGridViewTextBoxColumn,
            this.tb_hora_inicio,
            this.tb_data_inicio,
            this.tb_hora_termino,
            this.tb_data_termino,
            this.tb_rota,
            this.oBSPARADADataGridViewTextBoxColumn,
            this.pECASPRODUZIDASPARADADataGridViewTextBoxColumn,
            this.oPERADORDataGridViewTextBoxColumn,
            this.mAQUINAPARADADataGridViewTextBoxColumn,
            this.pARADAFINALIZADADataGridViewTextBoxColumn,
            this.cODPARADANUMDataGridViewTextBoxColumn,
            this.oPERADORFINALIZADORPARADADataGridViewTextBoxColumn,
            this.tOTALHORASPARADADataGridViewTextBoxColumn});
            this.dgvParadas.DataMember = "PARADAS";
            this.dgvParadas.DataSource = this.dsParadas;
            this.dgvParadas.Location = new System.Drawing.Point(12, 121);
            this.dgvParadas.Name = "dgvParadas";
            this.dgvParadas.Size = new System.Drawing.Size(533, 150);
            this.dgvParadas.TabIndex = 11;
            // 
            // tb_cod_parada
            // 
            this.tb_cod_parada.DataPropertyName = "COD_PARADA";
            this.tb_cod_parada.HeaderText = "Cód.";
            this.tb_cod_parada.Name = "tb_cod_parada";
            this.tb_cod_parada.Width = 40;
            // 
            // tIPOPARADADataGridViewTextBoxColumn
            // 
            this.tIPOPARADADataGridViewTextBoxColumn.DataPropertyName = "TIPO_PARADA";
            this.tIPOPARADADataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tIPOPARADADataGridViewTextBoxColumn.Name = "tIPOPARADADataGridViewTextBoxColumn";
            this.tIPOPARADADataGridViewTextBoxColumn.Width = 80;
            // 
            // tb_hora_inicio
            // 
            this.tb_hora_inicio.DataPropertyName = "HORA_INICIO";
            this.tb_hora_inicio.HeaderText = "Hora Inicio";
            this.tb_hora_inicio.Name = "tb_hora_inicio";
            this.tb_hora_inicio.Width = 50;
            // 
            // tb_data_inicio
            // 
            this.tb_data_inicio.DataPropertyName = "DATA_INICIO";
            this.tb_data_inicio.HeaderText = "Data Inicio";
            this.tb_data_inicio.Name = "tb_data_inicio";
            this.tb_data_inicio.Width = 70;
            // 
            // tb_hora_termino
            // 
            this.tb_hora_termino.DataPropertyName = "HORA_TERMINO";
            this.tb_hora_termino.HeaderText = "Hora Término";
            this.tb_hora_termino.Name = "tb_hora_termino";
            this.tb_hora_termino.Width = 50;
            // 
            // tb_data_termino
            // 
            this.tb_data_termino.DataPropertyName = "DATA_TERMINO";
            this.tb_data_termino.HeaderText = "Data Término";
            this.tb_data_termino.Name = "tb_data_termino";
            this.tb_data_termino.Width = 70;
            // 
            // tb_rota
            // 
            this.tb_rota.DataPropertyName = "N_ROTAS_CAMPO";
            this.tb_rota.HeaderText = "Rota";
            this.tb_rota.Name = "tb_rota";
            this.tb_rota.Width = 50;
            // 
            // oBSPARADADataGridViewTextBoxColumn
            // 
            this.oBSPARADADataGridViewTextBoxColumn.DataPropertyName = "OBS_PARADA";
            this.oBSPARADADataGridViewTextBoxColumn.HeaderText = "OBS_PARADA";
            this.oBSPARADADataGridViewTextBoxColumn.Name = "oBSPARADADataGridViewTextBoxColumn";
            this.oBSPARADADataGridViewTextBoxColumn.Visible = false;
            // 
            // pECASPRODUZIDASPARADADataGridViewTextBoxColumn
            // 
            this.pECASPRODUZIDASPARADADataGridViewTextBoxColumn.DataPropertyName = "PECAS_PRODUZIDAS_PARADA";
            this.pECASPRODUZIDASPARADADataGridViewTextBoxColumn.HeaderText = "PECAS_PRODUZIDAS_PARADA";
            this.pECASPRODUZIDASPARADADataGridViewTextBoxColumn.Name = "pECASPRODUZIDASPARADADataGridViewTextBoxColumn";
            this.pECASPRODUZIDASPARADADataGridViewTextBoxColumn.Visible = false;
            // 
            // oPERADORDataGridViewTextBoxColumn
            // 
            this.oPERADORDataGridViewTextBoxColumn.DataPropertyName = "OPERADOR";
            this.oPERADORDataGridViewTextBoxColumn.HeaderText = "OPERADOR";
            this.oPERADORDataGridViewTextBoxColumn.Name = "oPERADORDataGridViewTextBoxColumn";
            this.oPERADORDataGridViewTextBoxColumn.Visible = false;
            // 
            // mAQUINAPARADADataGridViewTextBoxColumn
            // 
            this.mAQUINAPARADADataGridViewTextBoxColumn.DataPropertyName = "MAQUINA_PARADA";
            this.mAQUINAPARADADataGridViewTextBoxColumn.HeaderText = "MAQUINA_PARADA";
            this.mAQUINAPARADADataGridViewTextBoxColumn.Name = "mAQUINAPARADADataGridViewTextBoxColumn";
            this.mAQUINAPARADADataGridViewTextBoxColumn.Visible = false;
            // 
            // pARADAFINALIZADADataGridViewTextBoxColumn
            // 
            this.pARADAFINALIZADADataGridViewTextBoxColumn.DataPropertyName = "PARADA_FINALIZADA";
            this.pARADAFINALIZADADataGridViewTextBoxColumn.HeaderText = "PARADA_FINALIZADA";
            this.pARADAFINALIZADADataGridViewTextBoxColumn.Name = "pARADAFINALIZADADataGridViewTextBoxColumn";
            this.pARADAFINALIZADADataGridViewTextBoxColumn.Visible = false;
            // 
            // cODPARADANUMDataGridViewTextBoxColumn
            // 
            this.cODPARADANUMDataGridViewTextBoxColumn.DataPropertyName = "COD_PARADA_NUM";
            this.cODPARADANUMDataGridViewTextBoxColumn.HeaderText = "COD_PARADA_NUM";
            this.cODPARADANUMDataGridViewTextBoxColumn.Name = "cODPARADANUMDataGridViewTextBoxColumn";
            this.cODPARADANUMDataGridViewTextBoxColumn.Visible = false;
            // 
            // oPERADORFINALIZADORPARADADataGridViewTextBoxColumn
            // 
            this.oPERADORFINALIZADORPARADADataGridViewTextBoxColumn.DataPropertyName = "OPERADOR_FINALIZADOR_PARADA";
            this.oPERADORFINALIZADORPARADADataGridViewTextBoxColumn.HeaderText = "OPERADOR_FINALIZADOR_PARADA";
            this.oPERADORFINALIZADORPARADADataGridViewTextBoxColumn.Name = "oPERADORFINALIZADORPARADADataGridViewTextBoxColumn";
            this.oPERADORFINALIZADORPARADADataGridViewTextBoxColumn.Visible = false;
            // 
            // tOTALHORASPARADADataGridViewTextBoxColumn
            // 
            this.tOTALHORASPARADADataGridViewTextBoxColumn.DataPropertyName = "TOTAL_HORAS_PARADA";
            this.tOTALHORASPARADADataGridViewTextBoxColumn.HeaderText = "Total de Horas";
            this.tOTALHORASPARADADataGridViewTextBoxColumn.Name = "tOTALHORASPARADADataGridViewTextBoxColumn";
            this.tOTALHORASPARADADataGridViewTextBoxColumn.Width = 50;
            // 
            // form_recalcula_paradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 281);
            this.Controls.Add(this.dgvParadas);
            this.Controls.Add(this.button1);
            this.Name = "form_recalcula_paradas";
            this.Text = "Recalcula Horas Paradas";
            this.Load += new System.EventHandler(this.form_recalcula_paradas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsParadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PARADAS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRotas_campo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ROTAS_CAMPO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParadas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datParadas;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Data.DataSet dsParadas;
        private System.Data.DataTable PARADAS;
        private System.Data.DataColumn COD_PARADA;
        private System.Data.DataColumn TIPO_PARADA;
        private System.Data.DataColumn HORA_INICIO;
        private System.Data.DataColumn DATA_INICIO;
        private System.Data.DataColumn HORA_TERMINO;
        private System.Data.DataColumn DATA_TERMINO;
        private System.Data.DataColumn N_ROTAS_CAMPO;
        private System.Data.DataColumn OBS_PARADA;
        private System.Data.DataColumn PECAS_PRODUZIDAS_PARADA;
        private System.Data.DataColumn OPERADOR;
        private System.Data.DataColumn MAQUINA_PARADA;
        private System.Data.DataColumn PARADA_FINALIZADA;
        private System.Data.DataColumn COD_PARADA_NUM;
        private System.Data.DataColumn OPERADOR_FINALIZADOR_PARADA;
        private System.Data.DataColumn TOTAL_HORAS_PARADA;
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
        private System.Windows.Forms.DataGridView dgvParadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn tb_cod_parada;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIPOPARADADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tb_hora_inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn tb_data_inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn tb_hora_termino;
        private System.Windows.Forms.DataGridViewTextBoxColumn tb_data_termino;
        private System.Windows.Forms.DataGridViewTextBoxColumn tb_rota;
        private System.Windows.Forms.DataGridViewTextBoxColumn oBSPARADADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pECASPRODUZIDASPARADADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPERADORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAQUINAPARADADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pARADAFINALIZADADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODPARADANUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPERADORFINALIZADORPARADADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOTALHORASPARADADataGridViewTextBoxColumn;
    }
}