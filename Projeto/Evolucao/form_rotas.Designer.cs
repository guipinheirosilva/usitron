namespace Evolucao
{
    partial class form_rotas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_rotas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            this.datRotas = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_codigo_rota = new System.Windows.Forms.TextBox();
            this.dsRotas = new System.Data.DataSet();
            this.ROTAS_CAMPO = new System.Data.DataTable();
            this.COD_ROTA_CAMPO = new System.Data.DataColumn();
            this.COD_NUM_ROTAS = new System.Data.DataColumn();
            this.COD_ROTA_PECA = new System.Data.DataColumn();
            this.OBSERVACAO_CAMPO = new System.Data.DataColumn();
            this.DESENHO_CAMPO = new System.Data.DataColumn();
            this.POSICAO_FILA_CAMPO = new System.Data.DataColumn();
            this.DATA_ENTRADA = new System.Data.DataColumn();
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
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataColumn7 = new System.Data.DataColumn();
            this.dataColumn8 = new System.Data.DataColumn();
            this.dataColumn9 = new System.Data.DataColumn();
            this.dataColumn10 = new System.Data.DataColumn();
            this.dataColumn11 = new System.Data.DataColumn();
            this.dataColumn12 = new System.Data.DataColumn();
            this.dataColumn13 = new System.Data.DataColumn();
            this.dataColumn14 = new System.Data.DataColumn();
            this.dataColumn15 = new System.Data.DataColumn();
            this.dataColumn16 = new System.Data.DataColumn();
            this.dataColumn20 = new System.Data.DataColumn();
            this.dataColumn21 = new System.Data.DataColumn();
            this.dataColumn22 = new System.Data.DataColumn();
            this.dataColumn23 = new System.Data.DataColumn();
            this.dataColumn24 = new System.Data.DataColumn();
            this.tb_operacao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_ent_prev = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_fecha_prev = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_entrada_hora = new System.Windows.Forms.TextBox();
            this.tb_operador = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_n_pdf = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_prev = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_fechamento_data = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_fechamento_hora = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_entrada_data = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_obs = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tb_peca = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tb_codop = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dsParadas = new System.Data.DataSet();
            this.PARADAS = new System.Data.DataTable();
            this.COD_PARADA = new System.Data.DataColumn();
            this.TIPO_PARADA = new System.Data.DataColumn();
            this.DATA_INICIO = new System.Data.DataColumn();
            this.DATA_TERMINO = new System.Data.DataColumn();
            this.N_ROTAS_CAMPO = new System.Data.DataColumn();
            this.OBS_PARADA = new System.Data.DataColumn();
            this.PECAS_PRODUZIDAS_PARADA = new System.Data.DataColumn();
            this.OPERADOR = new System.Data.DataColumn();
            this.MAQUINA_PARADA = new System.Data.DataColumn();
            this.PARADA_FINALIZADA = new System.Data.DataColumn();
            this.COD_PARADA_NUM = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn17 = new System.Data.DataColumn();
            this.dataColumn18 = new System.Data.DataColumn();
            this.dataColumn19 = new System.Data.DataColumn();
            this.dataColumn25 = new System.Data.DataColumn();
            this.dataColumn26 = new System.Data.DataColumn();
            this.datParadas = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand8 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand6 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand5 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand7 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.salva_registro = new System.Windows.Forms.Button();
            this.cbRotas = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.cbParadas = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.tb_operador_final = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tb_maquina_final = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tb_maquina_ini = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tb_situacao = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.datHoras_semana = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand12 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand10 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand9 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand11 = new FirebirdSql.Data.FirebirdClient.FbCommand();
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
            this.tb_horas_trab = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.tb_horas_manuais_reais = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.cb_servico_externo = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dsForn = new System.Data.DataSet();
            this.FORNECEDORES = new System.Data.DataTable();
            this.COD_FORN = new System.Data.DataColumn();
            this.NOME_FORN = new System.Data.DataColumn();
            this.TEL_FORN = new System.Data.DataColumn();
            this.datForn = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand16 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand14 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand13 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand15 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.gb_estado = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.tb_novo_itens_conj = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.tb_nova_maquina = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.tb_nova_hora = new System.Windows.Forms.TextBox();
            this.tb_novo_operador = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.tb_nova_data = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.tb_se = new System.Windows.Forms.TextBox();
            this.btParada_finalizado = new System.Windows.Forms.Button();
            this.btFinalizado_parada = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.tb_itens_ini = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.datMaquina_rodando = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand20 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand18 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand17 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand19 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsMaquina_rodando = new System.Data.DataSet();
            this.MAQUINA_RODANDO = new System.Data.DataTable();
            this.COD_MAQUINA_RODANDO = new System.Data.DataColumn();
            this.MAQUINA_ATUAL = new System.Data.DataColumn();
            this.DATA_MAQUINA_TRABALHANDO = new System.Data.DataColumn();
            this.ROTA_MAQUINA_RODANDO = new System.Data.DataColumn();
            this.OPERADOR_MAQUINA_RODANDO = new System.Data.DataColumn();
            this.HORAS_TRABALHADAS_MAQUINA = new System.Data.DataColumn();
            this.OS_MAQUINA_RODANDO = new System.Data.DataColumn();
            this.tb_retrabalho_rota = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_itens_fecha = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.tb_forn = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.cb_horas_manuais = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_horas_manuais = new System.Windows.Forms.TextBox();
            this.radioParar = new System.Windows.Forms.RadioButton();
            this.radioFinalizar = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbRetrabalho = new System.Windows.Forms.CheckBox();
            this.tb_funcao = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.tb_previsao_semana = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.tb_n_os_conj = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.col_onde_se = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_horas_se = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_se = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_parada_final = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pECASPRODUZIDASPARADADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oBSPARADADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_rotas_campo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_operador_reinicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_maquina_reinicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_itens_reinicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_hora_reinicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_data_reinicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_operador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_maquina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_itens_parada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIPOPARADADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cod_parada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODPARADANUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label41 = new System.Windows.Forms.Label();
            this.cb_se_inicio = new System.Windows.Forms.CheckBox();
            this.tb_horas_se_inicio = new System.Windows.Forms.TextBox();
            this.tb_onde_se_inicio = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.tb_qtde_inicio = new System.Windows.Forms.TextBox();
            this.dataColumn27 = new System.Data.DataColumn();
            this.label42 = new System.Windows.Forms.Label();
            this.tb_qtde = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataColumn28 = new System.Data.DataColumn();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dsRotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ROTAS_CAMPO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsParadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PARADAS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHoras_semana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HORAS_SEMANA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsForn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FORNECEDORES)).BeginInit();
            this.gb_estado.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaquina_rodando)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MAQUINA_RODANDO)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // datRotas
            // 
            this.datRotas.DeleteCommand = this.fbCommand4;
            this.datRotas.InsertCommand = this.fbCommand2;
            this.datRotas.SelectCommand = this.fbCommand1;
            this.datRotas.UpdateCommand = this.fbCommand3;
            this.datRotas.RowUpdated += new FirebirdSql.Data.FirebirdClient.FbRowUpdatedEventHandler(this.datRotas_RowUpdated);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código da Rota:";
            // 
            // tb_codigo_rota
            // 
            this.tb_codigo_rota.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRotas, "ROTAS_CAMPO.COD_ROTA_CAMPO", true));
            this.tb_codigo_rota.Location = new System.Drawing.Point(130, 85);
            this.tb_codigo_rota.Name = "tb_codigo_rota";
            this.tb_codigo_rota.Size = new System.Drawing.Size(62, 20);
            this.tb_codigo_rota.TabIndex = 1;
            this.tb_codigo_rota.TextChanged += new System.EventHandler(this.tb_codigo_rota_TextChanged);
            // 
            // dsRotas
            // 
            this.dsRotas.DataSetName = "dsRotas";
            this.dsRotas.Namespace = "http://www.tempuri.org/dsRotas.xsd";
            this.dsRotas.Tables.AddRange(new System.Data.DataTable[] {
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
            this.DATA_ENTRADA,
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
            this.dataColumn1,
            this.dataColumn6,
            this.dataColumn7,
            this.dataColumn8,
            this.dataColumn9,
            this.dataColumn10,
            this.dataColumn11,
            this.dataColumn12,
            this.dataColumn13,
            this.dataColumn14,
            this.dataColumn15,
            this.dataColumn16,
            this.dataColumn20,
            this.dataColumn21,
            this.dataColumn22,
            this.dataColumn23,
            this.dataColumn24,
            this.dataColumn27,
            this.dataColumn28});
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
            // DATA_ENTRADA
            // 
            this.DATA_ENTRADA.ColumnName = "DATA_ENTRADA";
            this.DATA_ENTRADA.DataType = typeof(System.DateTime);
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
            this.PREVISAO_PRODUCAO.DataType = typeof(double);
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
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "OPERADOR_FINALIZADOR";
            this.dataColumn1.MaxLength = 30;
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "MAQUINA_FECHAMENTO";
            this.dataColumn6.MaxLength = 20;
            // 
            // dataColumn7
            // 
            this.dataColumn7.ColumnName = "SALDO_HORAS";
            this.dataColumn7.DataType = typeof(double);
            // 
            // dataColumn8
            // 
            this.dataColumn8.ColumnName = "HORAS_MAQUINA_RODANDO";
            this.dataColumn8.DataType = typeof(double);
            // 
            // dataColumn9
            // 
            this.dataColumn9.ColumnName = "SERVICO_EXTERNO_ROTA";
            this.dataColumn9.DataType = typeof(int);
            // 
            // dataColumn10
            // 
            this.dataColumn10.ColumnName = "FORNECEDOR_SERVICO_EXTERNO";
            this.dataColumn10.MaxLength = 50;
            // 
            // dataColumn11
            // 
            this.dataColumn11.ColumnName = "OS_CONJUNTAS";
            this.dataColumn11.DataType = typeof(int);
            // 
            // dataColumn12
            // 
            this.dataColumn12.ColumnName = "RETRABALHO_ROTA";
            this.dataColumn12.DataType = typeof(int);
            // 
            // dataColumn13
            // 
            this.dataColumn13.ColumnName = "OS_CONJUNTAS_FECHAMENTO";
            this.dataColumn13.DataType = typeof(int);
            // 
            // dataColumn14
            // 
            this.dataColumn14.ColumnName = "FUNCAO_ROTA";
            this.dataColumn14.MaxLength = 50;
            // 
            // dataColumn15
            // 
            this.dataColumn15.ColumnName = "SERVICO_EXTERNO_INICIO";
            this.dataColumn15.DataType = typeof(int);
            // 
            // dataColumn16
            // 
            this.dataColumn16.ColumnName = "HORAS_SERVICO_EXTERNO_INICIO";
            this.dataColumn16.DataType = typeof(double);
            // 
            // dataColumn20
            // 
            this.dataColumn20.ColumnName = "ULTIMO_OPERADOR";
            this.dataColumn20.MaxLength = 5;
            // 
            // dataColumn21
            // 
            this.dataColumn21.ColumnName = "ULTIMA_MAQUINA";
            this.dataColumn21.MaxLength = 5;
            // 
            // dataColumn22
            // 
            this.dataColumn22.ColumnName = "ULTIMO_OS_CONJUNTAS";
            this.dataColumn22.DataType = typeof(int);
            // 
            // dataColumn23
            // 
            this.dataColumn23.ColumnName = "HORA_ENTRADA";
            this.dataColumn23.DataType = typeof(System.DateTime);
            this.dataColumn23.DateTimeMode = System.Data.DataSetDateTime.Utc;
            // 
            // dataColumn24
            // 
            this.dataColumn24.ColumnName = "HORA_FECHAMENTO";
            this.dataColumn24.DataType = typeof(System.DateTime);
            // 
            // tb_operacao
            // 
            this.tb_operacao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRotas, "ROTAS_CAMPO.OPERACAO_CAMPO", true));
            this.tb_operacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_operacao.Location = new System.Drawing.Point(239, 85);
            this.tb_operacao.Name = "tb_operacao";
            this.tb_operacao.Size = new System.Drawing.Size(294, 38);
            this.tb_operacao.TabIndex = 3;
            this.tb_operacao.TextChanged += new System.EventHandler(this.tb_operacao_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Operação:";
            // 
            // tb_ent_prev
            // 
            this.tb_ent_prev.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRotas, "ROTAS_CAMPO.DATA_ENTRADA_PREV", true));
            this.tb_ent_prev.Location = new System.Drawing.Point(24, 158);
            this.tb_ent_prev.Name = "tb_ent_prev";
            this.tb_ent_prev.Size = new System.Drawing.Size(148, 20);
            this.tb_ent_prev.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Data de Entrada Prevista:";
            // 
            // tb_fecha_prev
            // 
            this.tb_fecha_prev.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRotas, "ROTAS_CAMPO.DATA_FECHAMENTO_PREV", true));
            this.tb_fecha_prev.Location = new System.Drawing.Point(209, 158);
            this.tb_fecha_prev.Name = "tb_fecha_prev";
            this.tb_fecha_prev.Size = new System.Drawing.Size(148, 20);
            this.tb_fecha_prev.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(206, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data de Fechamento Prevista:";
            // 
            // tb_entrada_hora
            // 
            this.tb_entrada_hora.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRotas, "ROTAS_CAMPO.HORA_ENTRADA", true));
            this.tb_entrada_hora.Location = new System.Drawing.Point(121, 261);
            this.tb_entrada_hora.Name = "tb_entrada_hora";
            this.tb_entrada_hora.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tb_entrada_hora.Size = new System.Drawing.Size(70, 20);
            this.tb_entrada_hora.TabIndex = 166;
            // 
            // tb_operador
            // 
            this.tb_operador.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRotas, "ROTAS_CAMPO.OPERADOR_CAMPO", true));
            this.tb_operador.Location = new System.Drawing.Point(121, 208);
            this.tb_operador.Name = "tb_operador";
            this.tb_operador.Size = new System.Drawing.Size(71, 20);
            this.tb_operador.TabIndex = 163;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(26, 211);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 13);
            this.label13.TabIndex = 160;
            this.label13.Text = "Operador Inicial:";
            // 
            // tb_n_pdf
            // 
            this.tb_n_pdf.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRotas, "ROTAS_CAMPO.N_PDF_CAMPO", true));
            this.tb_n_pdf.Location = new System.Drawing.Point(488, 48);
            this.tb_n_pdf.Name = "tb_n_pdf";
            this.tb_n_pdf.Size = new System.Drawing.Size(45, 20);
            this.tb_n_pdf.TabIndex = 159;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(418, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 158;
            this.label11.Text = "Posição:";
            // 
            // tb_prev
            // 
            this.tb_prev.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRotas, "ROTAS_CAMPO.PREVISAO_PRODUCAO", true));
            this.tb_prev.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_prev.Location = new System.Drawing.Point(694, 503);
            this.tb_prev.Name = "tb_prev";
            this.tb_prev.Size = new System.Drawing.Size(150, 31);
            this.tb_prev.TabIndex = 157;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label9.Location = new System.Drawing.Point(691, 487);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 156;
            this.label9.Text = "Horas Previstas:";
            // 
            // tb_fechamento_data
            // 
            this.tb_fechamento_data.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRotas, "ROTAS_CAMPO.DATA_FECHAMENTO", true));
            this.tb_fechamento_data.Location = new System.Drawing.Point(301, 287);
            this.tb_fechamento_data.Name = "tb_fechamento_data";
            this.tb_fechamento_data.Size = new System.Drawing.Size(68, 20);
            this.tb_fechamento_data.TabIndex = 155;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(206, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 154;
            this.label7.Text = "Data Final:";
            // 
            // tb_fechamento_hora
            // 
            this.tb_fechamento_hora.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRotas, "ROTAS_CAMPO.HORA_FECHAMENTO", true));
            this.tb_fechamento_hora.Location = new System.Drawing.Point(301, 261);
            this.tb_fechamento_hora.Name = "tb_fechamento_hora";
            this.tb_fechamento_hora.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tb_fechamento_hora.Size = new System.Drawing.Size(68, 20);
            this.tb_fechamento_hora.TabIndex = 153;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label8.Location = new System.Drawing.Point(206, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 152;
            this.label8.Text = "Hora Final:";
            // 
            // tb_entrada_data
            // 
            this.tb_entrada_data.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRotas, "ROTAS_CAMPO.DATA_ENTRADA", true));
            this.tb_entrada_data.Location = new System.Drawing.Point(121, 287);
            this.tb_entrada_data.Name = "tb_entrada_data";
            this.tb_entrada_data.Size = new System.Drawing.Size(71, 20);
            this.tb_entrada_data.TabIndex = 151;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 150;
            this.label6.Text = "Data Inicial:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 264);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 149;
            this.label10.Text = "Hora Inicial:";
            // 
            // tb_obs
            // 
            this.tb_obs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRotas, "ROTAS_CAMPO.OBSERVACAO_CAMPO", true));
            this.tb_obs.Location = new System.Drawing.Point(648, 48);
            this.tb_obs.Multiline = true;
            this.tb_obs.Name = "tb_obs";
            this.tb_obs.Size = new System.Drawing.Size(196, 34);
            this.tb_obs.TabIndex = 148;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(554, 49);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 13);
            this.label15.TabIndex = 147;
            this.label15.Text = "Observações:";
            // 
            // tb_peca
            // 
            this.tb_peca.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRotas, "ROTAS_CAMPO.DESENHO_CAMPO", true));
            this.tb_peca.Location = new System.Drawing.Point(270, 48);
            this.tb_peca.Name = "tb_peca";
            this.tb_peca.Size = new System.Drawing.Size(99, 20);
            this.tb_peca.TabIndex = 146;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(236, 51);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(25, 13);
            this.label16.TabIndex = 145;
            this.label16.Text = "OS:";
            // 
            // tb_codop
            // 
            this.tb_codop.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRotas, "ROTAS_CAMPO.OP_ROTA", true));
            this.tb_codop.Location = new System.Drawing.Point(130, 58);
            this.tb_codop.Name = "tb_codop";
            this.tb_codop.Size = new System.Drawing.Size(62, 20);
            this.tb_codop.TabIndex = 144;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(21, 62);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 13);
            this.label17.TabIndex = 143;
            this.label17.Text = "Sistema:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label20.Location = new System.Drawing.Point(16, 9);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(125, 46);
            this.label20.TabIndex = 169;
            this.label20.Text = "Rotas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(7, 406);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 26);
            this.label5.TabIndex = 170;
            this.label5.Text = "Paradas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            dataGridViewCellStyle33.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle33;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODPARADANUMDataGridViewTextBoxColumn,
            this.col_cod_parada,
            this.tIPOPARADADataGridViewTextBoxColumn,
            this.col_data,
            this.col_hora,
            this.col_itens_parada,
            this.col_maquina,
            this.col_operador,
            this.col_data_reinicio,
            this.col_hora_reinicio,
            this.col_itens_reinicio,
            this.col_maquina_reinicio,
            this.col_operador_reinicio,
            this.col_rotas_campo,
            this.oBSPARADADataGridViewTextBoxColumn,
            this.pECASPRODUZIDASPARADADataGridViewTextBoxColumn,
            this.col_parada_final,
            this.col_se,
            this.col_horas_se,
            this.col_onde_se});
            this.dataGridView1.DataMember = "PARADAS";
            this.dataGridView1.DataSource = this.dsParadas;
            this.dataGridView1.Location = new System.Drawing.Point(12, 435);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle36.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle36.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle36;
            this.dataGridView1.Size = new System.Drawing.Size(677, 149);
            this.dataGridView1.TabIndex = 171;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.DATA_INICIO,
            this.DATA_TERMINO,
            this.N_ROTAS_CAMPO,
            this.OBS_PARADA,
            this.PECAS_PRODUZIDAS_PARADA,
            this.OPERADOR,
            this.MAQUINA_PARADA,
            this.PARADA_FINALIZADA,
            this.COD_PARADA_NUM,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn17,
            this.dataColumn18,
            this.dataColumn19,
            this.dataColumn25,
            this.dataColumn26});
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
            this.COD_PARADA.AutoIncrement = true;
            this.COD_PARADA.ColumnName = "COD_PARADA";
            this.COD_PARADA.DataType = typeof(int);
            // 
            // TIPO_PARADA
            // 
            this.TIPO_PARADA.ColumnName = "TIPO_PARADA";
            this.TIPO_PARADA.MaxLength = 30;
            // 
            // DATA_INICIO
            // 
            this.DATA_INICIO.ColumnName = "DATA_INICIO";
            this.DATA_INICIO.DataType = typeof(System.DateTime);
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
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "OPERADOR_FINALIZADOR_PARADA";
            this.dataColumn2.MaxLength = 30;
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "ITENS_CONJUNTOS_PARADA";
            this.dataColumn3.DataType = typeof(int);
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "ITENS_CONJUNTOS_REINICIO";
            this.dataColumn4.DataType = typeof(int);
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "MAQUINA_REINICIO";
            this.dataColumn5.MaxLength = 30;
            // 
            // dataColumn17
            // 
            this.dataColumn17.ColumnName = "SERVICO_EXTERNO_REINICIO";
            this.dataColumn17.DataType = typeof(int);
            // 
            // dataColumn18
            // 
            this.dataColumn18.ColumnName = "HORAS_SERVICO_EXTERNO_REINICIO";
            this.dataColumn18.DataType = typeof(double);
            // 
            // dataColumn19
            // 
            this.dataColumn19.ColumnName = "ONDE_SERVICO_EXTERNO_REINICIO";
            this.dataColumn19.MaxLength = 50;
            // 
            // dataColumn25
            // 
            this.dataColumn25.ColumnName = "HORA_TERMINO";
            this.dataColumn25.DataType = typeof(System.DateTime);
            // 
            // dataColumn26
            // 
            this.dataColumn26.ColumnName = "HORA_INICIO";
            this.dataColumn26.DataType = typeof(System.DateTime);
            // 
            // datParadas
            // 
            this.datParadas.DeleteCommand = this.fbCommand8;
            this.datParadas.InsertCommand = this.fbCommand6;
            this.datParadas.SelectCommand = this.fbCommand5;
            this.datParadas.UpdateCommand = this.fbCommand7;
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
            this.fbCommand5.CommandText = "select * from paradas order by cod_parada";
            this.fbCommand5.CommandTimeout = 30;
            this.fbCommand5.Connection = this.fbConnection1;
            // 
            // fbCommand7
            // 
            this.fbCommand7.CommandTimeout = 30;
            // 
            // salva_registro
            // 
            this.salva_registro.Location = new System.Drawing.Point(698, 280);
            this.salva_registro.Name = "salva_registro";
            this.salva_registro.Size = new System.Drawing.Size(70, 35);
            this.salva_registro.TabIndex = 177;
            this.salva_registro.Text = "Salvar";
            this.salva_registro.UseVisualStyleBackColor = true;
            this.salva_registro.Click += new System.EventHandler(this.salva_registro_Click);
            // 
            // cbRotas
            // 
            this.cbRotas.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbRotas.DataAdapter = this.datRotas;
            this.cbRotas.QuotePrefix = "\"";
            this.cbRotas.QuoteSuffix = "\"";
            // 
            // cbParadas
            // 
            this.cbParadas.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbParadas.DataAdapter = this.datParadas;
            this.cbParadas.QuotePrefix = "\"";
            this.cbParadas.QuoteSuffix = "\"";
            // 
            // tb_operador_final
            // 
            this.tb_operador_final.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRotas, "ROTAS_CAMPO.OPERADOR_FINALIZADOR", true));
            this.tb_operador_final.Location = new System.Drawing.Point(301, 209);
            this.tb_operador_final.Name = "tb_operador_final";
            this.tb_operador_final.Size = new System.Drawing.Size(68, 20);
            this.tb_operador_final.TabIndex = 179;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(206, 212);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(79, 13);
            this.label18.TabIndex = 178;
            this.label18.Text = "Operador Final:";
            // 
            // tb_maquina_final
            // 
            this.tb_maquina_final.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRotas, "ROTAS_CAMPO.MAQUINA_FECHAMENTO", true));
            this.tb_maquina_final.Location = new System.Drawing.Point(301, 236);
            this.tb_maquina_final.Name = "tb_maquina_final";
            this.tb_maquina_final.Size = new System.Drawing.Size(68, 20);
            this.tb_maquina_final.TabIndex = 185;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(206, 239);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(76, 13);
            this.label19.TabIndex = 184;
            this.label19.Text = "Máquina Final:";
            // 
            // tb_maquina_ini
            // 
            this.tb_maquina_ini.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRotas, "ROTAS_CAMPO.MAQUINA", true));
            this.tb_maquina_ini.Location = new System.Drawing.Point(121, 235);
            this.tb_maquina_ini.Name = "tb_maquina_ini";
            this.tb_maquina_ini.Size = new System.Drawing.Size(71, 20);
            this.tb_maquina_ini.TabIndex = 183;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(26, 238);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(81, 13);
            this.label21.TabIndex = 182;
            this.label21.Text = "Máquina Inicial:";
            // 
            // tb_situacao
            // 
            this.tb_situacao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRotas, "ROTAS_CAMPO.POSICAO_ATUAL", true));
            this.tb_situacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_situacao.Location = new System.Drawing.Point(542, 343);
            this.tb_situacao.Name = "tb_situacao";
            this.tb_situacao.Size = new System.Drawing.Size(302, 29);
            this.tb_situacao.TabIndex = 187;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(67, 41);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 24);
            this.button3.TabIndex = 188;
            this.button3.Text = "Finalizar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // datHoras_semana
            // 
            this.datHoras_semana.DeleteCommand = this.fbCommand12;
            this.datHoras_semana.InsertCommand = this.fbCommand10;
            this.datHoras_semana.SelectCommand = this.fbCommand9;
            this.datHoras_semana.UpdateCommand = this.fbCommand11;
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
            this.fbCommand9.CommandText = "select * from horas_semana";
            this.fbCommand9.CommandTimeout = 30;
            this.fbCommand9.Connection = this.fbConnection1;
            // 
            // fbCommand11
            // 
            this.fbCommand11.CommandTimeout = 30;
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
            this.OPERACAO_SEMANA.MaxLength = 50;
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
            // tb_horas_trab
            // 
            this.tb_horas_trab.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRotas, "ROTAS_CAMPO.SALDO_HORAS", true));
            this.tb_horas_trab.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_horas_trab.Location = new System.Drawing.Point(694, 553);
            this.tb_horas_trab.Name = "tb_horas_trab";
            this.tb_horas_trab.Size = new System.Drawing.Size(150, 31);
            this.tb_horas_trab.TabIndex = 193;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label25.Location = new System.Drawing.Point(691, 537);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(100, 13);
            this.label25.TabIndex = 192;
            this.label25.Text = "Horas Trabalhadas:";
            // 
            // tb_horas_manuais_reais
            // 
            this.tb_horas_manuais_reais.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRotas, "ROTAS_CAMPO.HORAS_MAQUINA_RODANDO", true));
            this.tb_horas_manuais_reais.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_horas_manuais_reais.Location = new System.Drawing.Point(694, 453);
            this.tb_horas_manuais_reais.Name = "tb_horas_manuais_reais";
            this.tb_horas_manuais_reais.Size = new System.Drawing.Size(150, 31);
            this.tb_horas_manuais_reais.TabIndex = 195;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label26.Location = new System.Drawing.Point(693, 437);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(81, 13);
            this.label26.TabIndex = 194;
            this.label26.Text = "Horas Manuais:";
            // 
            // cb_servico_externo
            // 
            this.cb_servico_externo.AutoSize = true;
            this.cb_servico_externo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cb_servico_externo.Location = new System.Drawing.Point(15, 10);
            this.cb_servico_externo.Name = "cb_servico_externo";
            this.cb_servico_externo.Size = new System.Drawing.Size(101, 17);
            this.cb_servico_externo.TabIndex = 198;
            this.cb_servico_externo.Text = "Serviço Externo";
            this.cb_servico_externo.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(38, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 200;
            this.label12.Text = "Onde?";
            // 
            // dsForn
            // 
            this.dsForn.DataSetName = "dsForn";
            this.dsForn.Namespace = "http://www.tempuri.org/dsForn.xsd";
            this.dsForn.Tables.AddRange(new System.Data.DataTable[] {
            this.FORNECEDORES});
            // 
            // FORNECEDORES
            // 
            this.FORNECEDORES.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_FORN,
            this.NOME_FORN,
            this.TEL_FORN});
            this.FORNECEDORES.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_FORN"}, true)});
            this.FORNECEDORES.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_FORN};
            this.FORNECEDORES.TableName = "FORNECEDORES";
            // 
            // COD_FORN
            // 
            this.COD_FORN.AllowDBNull = false;
            this.COD_FORN.ColumnName = "COD_FORN";
            this.COD_FORN.DataType = typeof(int);
            // 
            // NOME_FORN
            // 
            this.NOME_FORN.ColumnName = "NOME_FORN";
            this.NOME_FORN.MaxLength = 50;
            // 
            // TEL_FORN
            // 
            this.TEL_FORN.ColumnName = "TEL_FORN";
            this.TEL_FORN.MaxLength = 20;
            // 
            // datForn
            // 
            this.datForn.DeleteCommand = this.fbCommand16;
            this.datForn.InsertCommand = this.fbCommand14;
            this.datForn.SelectCommand = this.fbCommand13;
            this.datForn.UpdateCommand = this.fbCommand15;
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
            this.fbCommand13.CommandText = "select * from fornecedores";
            this.fbCommand13.CommandTimeout = 30;
            this.fbCommand13.Connection = this.fbConnection1;
            // 
            // fbCommand15
            // 
            this.fbCommand15.CommandTimeout = 30;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(67, 16);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 24);
            this.button5.TabIndex = 210;
            this.button5.Text = "Parar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(9, 41);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(52, 24);
            this.button6.TabIndex = 211;
            this.button6.Text = "Reiniciar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(9, 17);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(52, 24);
            this.button7.TabIndex = 212;
            this.button7.Text = "Iniciar";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // gb_estado
            // 
            this.gb_estado.Controls.Add(this.label22);
            this.gb_estado.Controls.Add(this.tb_novo_itens_conj);
            this.gb_estado.Controls.Add(this.label29);
            this.gb_estado.Controls.Add(this.label28);
            this.gb_estado.Controls.Add(this.tb_nova_maquina);
            this.gb_estado.Controls.Add(this.label30);
            this.gb_estado.Controls.Add(this.tb_nova_hora);
            this.gb_estado.Controls.Add(this.tb_novo_operador);
            this.gb_estado.Controls.Add(this.label27);
            this.gb_estado.Controls.Add(this.tb_nova_data);
            this.gb_estado.Controls.Add(this.button7);
            this.gb_estado.Controls.Add(this.button6);
            this.gb_estado.Controls.Add(this.button5);
            this.gb_estado.Controls.Add(this.button3);
            this.gb_estado.Location = new System.Drawing.Point(403, 152);
            this.gb_estado.Name = "gb_estado";
            this.gb_estado.Size = new System.Drawing.Size(127, 167);
            this.gb_estado.TabIndex = 213;
            this.gb_estado.TabStop = false;
            this.gb_estado.Text = "Mudança de Estado";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(9, 139);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(50, 24);
            this.label22.TabIndex = 222;
            this.label22.Text = "Itens\r\nConjuntos:";
            // 
            // tb_novo_itens_conj
            // 
            this.tb_novo_itens_conj.Location = new System.Drawing.Point(64, 141);
            this.tb_novo_itens_conj.Name = "tb_novo_itens_conj";
            this.tb_novo_itens_conj.Size = new System.Drawing.Size(55, 20);
            this.tb_novo_itens_conj.TabIndex = 221;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(67, 99);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(41, 12);
            this.label29.TabIndex = 220;
            this.label29.Text = "Máquina";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(67, 65);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(25, 12);
            this.label28.TabIndex = 216;
            this.label28.Text = "Hora";
            // 
            // tb_nova_maquina
            // 
            this.tb_nova_maquina.Location = new System.Drawing.Point(64, 112);
            this.tb_nova_maquina.Name = "tb_nova_maquina";
            this.tb_nova_maquina.Size = new System.Drawing.Size(55, 20);
            this.tb_nova_maquina.TabIndex = 219;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(9, 99);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(43, 12);
            this.label30.TabIndex = 218;
            this.label30.Text = "Operador";
            // 
            // tb_nova_hora
            // 
            this.tb_nova_hora.Location = new System.Drawing.Point(64, 78);
            this.tb_nova_hora.Name = "tb_nova_hora";
            this.tb_nova_hora.Size = new System.Drawing.Size(55, 20);
            this.tb_nova_hora.TabIndex = 215;
            // 
            // tb_novo_operador
            // 
            this.tb_novo_operador.Location = new System.Drawing.Point(6, 112);
            this.tb_novo_operador.Name = "tb_novo_operador";
            this.tb_novo_operador.Size = new System.Drawing.Size(55, 20);
            this.tb_novo_operador.TabIndex = 217;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(9, 65);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(25, 12);
            this.label27.TabIndex = 214;
            this.label27.Text = "Data";
            // 
            // tb_nova_data
            // 
            this.tb_nova_data.Location = new System.Drawing.Point(6, 78);
            this.tb_nova_data.Name = "tb_nova_data";
            this.tb_nova_data.Size = new System.Drawing.Size(55, 20);
            this.tb_nova_data.TabIndex = 213;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(1, 23);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(34, 13);
            this.label31.TabIndex = 215;
            this.label31.Text = "Horas";
            // 
            // tb_se
            // 
            this.tb_se.Location = new System.Drawing.Point(4, 36);
            this.tb_se.Name = "tb_se";
            this.tb_se.Size = new System.Drawing.Size(34, 20);
            this.tb_se.TabIndex = 214;
            // 
            // btParada_finalizado
            // 
            this.btParada_finalizado.Location = new System.Drawing.Point(9, 15);
            this.btParada_finalizado.Name = "btParada_finalizado";
            this.btParada_finalizado.Size = new System.Drawing.Size(107, 20);
            this.btParada_finalizado.TabIndex = 217;
            this.btParada_finalizado.Text = "Parada->Finalizado";
            this.btParada_finalizado.UseVisualStyleBackColor = true;
            this.btParada_finalizado.Click += new System.EventHandler(this.btParada_finalizado_Click);
            // 
            // btFinalizado_parada
            // 
            this.btFinalizado_parada.Location = new System.Drawing.Point(9, 38);
            this.btFinalizado_parada.Name = "btFinalizado_parada";
            this.btFinalizado_parada.Size = new System.Drawing.Size(107, 20);
            this.btFinalizado_parada.TabIndex = 218;
            this.btFinalizado_parada.Text = "Finalizado->Parada";
            this.btFinalizado_parada.UseVisualStyleBackColor = true;
            this.btFinalizado_parada.Click += new System.EventHandler(this.btFinalizado_parada_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.btFinalizado_parada);
            this.groupBox3.Controls.Add(this.btParada_finalizado);
            this.groupBox3.Location = new System.Drawing.Point(538, 257);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(131, 83);
            this.groupBox3.TabIndex = 219;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Inverter";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(9, 60);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 20);
            this.button4.TabIndex = 220;
            this.button4.Text = "Finalizado->Andam.";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // tb_itens_ini
            // 
            this.tb_itens_ini.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRotas, "ROTAS_CAMPO.OS_CONJUNTAS", true));
            this.tb_itens_ini.Location = new System.Drawing.Point(121, 182);
            this.tb_itens_ini.Name = "tb_itens_ini";
            this.tb_itens_ini.Size = new System.Drawing.Size(71, 20);
            this.tb_itens_ini.TabIndex = 222;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(26, 185);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(83, 13);
            this.label32.TabIndex = 221;
            this.label32.Text = "Itens Conjuntos:";
            // 
            // datMaquina_rodando
            // 
            this.datMaquina_rodando.DeleteCommand = this.fbCommand20;
            this.datMaquina_rodando.InsertCommand = this.fbCommand18;
            this.datMaquina_rodando.SelectCommand = this.fbCommand17;
            this.datMaquina_rodando.UpdateCommand = this.fbCommand19;
            // 
            // fbCommand20
            // 
            this.fbCommand20.CommandTimeout = 30;
            // 
            // fbCommand18
            // 
            this.fbCommand18.CommandTimeout = 30;
            // 
            // fbCommand17
            // 
            this.fbCommand17.CommandText = "SELECT * FROM MAQUINA_RODANDO";
            this.fbCommand17.CommandTimeout = 30;
            this.fbCommand17.Connection = this.fbConnection1;
            // 
            // fbCommand19
            // 
            this.fbCommand19.CommandTimeout = 30;
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
            // tb_retrabalho_rota
            // 
            this.tb_retrabalho_rota.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRotas, "ROTAS_CAMPO.RETRABALHO_ROTA", true));
            this.tb_retrabalho_rota.Location = new System.Drawing.Point(130, 111);
            this.tb_retrabalho_rota.Name = "tb_retrabalho_rota";
            this.tb_retrabalho_rota.Size = new System.Drawing.Size(62, 20);
            this.tb_retrabalho_rota.TabIndex = 224;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(21, 115);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(103, 13);
            this.label23.TabIndex = 223;
            this.label23.Text = "Retrabalho da Rota:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(774, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 35);
            this.button1.TabIndex = 225;
            this.button1.Text = "Recalcular\r\nHoras";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tb_itens_fecha
            // 
            this.tb_itens_fecha.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRotas, "ROTAS_CAMPO.OS_CONJUNTAS_FECHAMENTO", true));
            this.tb_itens_fecha.Location = new System.Drawing.Point(301, 182);
            this.tb_itens_fecha.Name = "tb_itens_fecha";
            this.tb_itens_fecha.Size = new System.Drawing.Size(68, 20);
            this.tb_itens_fecha.TabIndex = 227;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(206, 185);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(83, 13);
            this.label24.TabIndex = 226;
            this.label24.Text = "Itens Conjuntos:";
            // 
            // tb_forn
            // 
            this.tb_forn.Location = new System.Drawing.Point(39, 36);
            this.tb_forn.Name = "tb_forn";
            this.tb_forn.Size = new System.Drawing.Size(82, 20);
            this.tb_forn.TabIndex = 228;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(102, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(17, 23);
            this.button2.TabIndex = 229;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // cb_horas_manuais
            // 
            this.cb_horas_manuais.AutoSize = true;
            this.cb_horas_manuais.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cb_horas_manuais.Location = new System.Drawing.Point(4, 26);
            this.cb_horas_manuais.Name = "cb_horas_manuais";
            this.cb_horas_manuais.Size = new System.Drawing.Size(97, 17);
            this.cb_horas_manuais.TabIndex = 230;
            this.cb_horas_manuais.Text = "Horas Manuais";
            this.cb_horas_manuais.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 50);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 13);
            this.label14.TabIndex = 232;
            this.label14.Text = "Horas";
            // 
            // tb_horas_manuais
            // 
            this.tb_horas_manuais.Location = new System.Drawing.Point(46, 49);
            this.tb_horas_manuais.Name = "tb_horas_manuais";
            this.tb_horas_manuais.Size = new System.Drawing.Size(34, 20);
            this.tb_horas_manuais.TabIndex = 231;
            // 
            // radioParar
            // 
            this.radioParar.AutoSize = true;
            this.radioParar.Location = new System.Drawing.Point(9, 81);
            this.radioParar.Name = "radioParar";
            this.radioParar.Size = new System.Drawing.Size(50, 17);
            this.radioParar.TabIndex = 233;
            this.radioParar.TabStop = true;
            this.radioParar.Text = "Parar";
            this.radioParar.UseVisualStyleBackColor = true;
            // 
            // radioFinalizar
            // 
            this.radioFinalizar.AutoSize = true;
            this.radioFinalizar.Location = new System.Drawing.Point(58, 81);
            this.radioFinalizar.Name = "radioFinalizar";
            this.radioFinalizar.Size = new System.Drawing.Size(63, 17);
            this.radioFinalizar.TabIndex = 234;
            this.radioFinalizar.TabStop = true;
            this.radioFinalizar.Text = "Finalizar";
            this.radioFinalizar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioFinalizar);
            this.groupBox1.Controls.Add(this.radioParar);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.tb_horas_manuais);
            this.groupBox1.Controls.Add(this.cb_horas_manuais);
            this.groupBox1.Location = new System.Drawing.Point(538, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(131, 100);
            this.groupBox1.TabIndex = 235;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Horas Manuais";
            // 
            // cbRetrabalho
            // 
            this.cbRetrabalho.AutoSize = true;
            this.cbRetrabalho.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbRetrabalho.Location = new System.Drawing.Point(421, 136);
            this.cbRetrabalho.Name = "cbRetrabalho";
            this.cbRetrabalho.Size = new System.Drawing.Size(78, 17);
            this.cbRetrabalho.TabIndex = 236;
            this.cbRetrabalho.Text = "Retrabalho";
            this.cbRetrabalho.UseVisualStyleBackColor = true;
            // 
            // tb_funcao
            // 
            this.tb_funcao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRotas, "ROTAS_CAMPO.FUNCAO_ROTA", true));
            this.tb_funcao.Location = new System.Drawing.Point(606, 108);
            this.tb_funcao.Name = "tb_funcao";
            this.tb_funcao.Size = new System.Drawing.Size(162, 20);
            this.tb_funcao.TabIndex = 238;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(554, 111);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(46, 13);
            this.label33.TabIndex = 237;
            this.label33.Text = "Função:";
            // 
            // tb_previsao_semana
            // 
            this.tb_previsao_semana.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsHoras_semana, "HORAS_SEMANA.HORAS_OPERACAO_SEMANA", true));
            this.tb_previsao_semana.Location = new System.Drawing.Point(784, 592);
            this.tb_previsao_semana.Name = "tb_previsao_semana";
            this.tb_previsao_semana.Size = new System.Drawing.Size(60, 20);
            this.tb_previsao_semana.TabIndex = 239;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label34.Location = new System.Drawing.Point(628, 595);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(150, 13);
            this.label34.TabIndex = 240;
            this.label34.Text = "Horas Previstas para Semana:";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRotas, "ROTAS_CAMPO.ULTIMO_OPERADOR", true));
            this.textBox1.Location = new System.Drawing.Point(696, 177);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(99, 20);
            this.textBox1.TabIndex = 251;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(693, 161);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(86, 13);
            this.label35.TabIndex = 250;
            this.label35.Text = "Ultimo Operador:";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRotas, "ROTAS_CAMPO.ULTIMA_MAQUINA", true));
            this.textBox2.Location = new System.Drawing.Point(698, 217);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(99, 20);
            this.textBox2.TabIndex = 253;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(695, 201);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(83, 13);
            this.label36.TabIndex = 252;
            this.label36.Text = "Ultima Máquina:";
            // 
            // tb_n_os_conj
            // 
            this.tb_n_os_conj.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRotas, "ROTAS_CAMPO.ULTIMO_OS_CONJUNTAS", true));
            this.tb_n_os_conj.Location = new System.Drawing.Point(698, 257);
            this.tb_n_os_conj.Name = "tb_n_os_conj";
            this.tb_n_os_conj.Size = new System.Drawing.Size(99, 20);
            this.tb_n_os_conj.TabIndex = 255;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(695, 241);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(101, 13);
            this.label39.TabIndex = 254;
            this.label39.Text = "Ultima No. OS Conj.";
            // 
            // col_onde_se
            // 
            this.col_onde_se.DataPropertyName = "ONDE_SERVICO_EXTERNO_REINICIO";
            this.col_onde_se.HeaderText = "Onde SE";
            this.col_onde_se.Name = "col_onde_se";
            // 
            // col_horas_se
            // 
            this.col_horas_se.DataPropertyName = "HORAS_SERVICO_EXTERNO_REINICIO";
            this.col_horas_se.HeaderText = "Horas SE";
            this.col_horas_se.Name = "col_horas_se";
            this.col_horas_se.Width = 40;
            // 
            // col_se
            // 
            this.col_se.DataPropertyName = "SERVICO_EXTERNO_REINICIO";
            this.col_se.HeaderText = "SE";
            this.col_se.Name = "col_se";
            this.col_se.Width = 30;
            // 
            // col_parada_final
            // 
            this.col_parada_final.DataPropertyName = "PARADA_FINALIZADA";
            this.col_parada_final.HeaderText = "Finalizada?";
            this.col_parada_final.Name = "col_parada_final";
            this.col_parada_final.Width = 30;
            // 
            // pECASPRODUZIDASPARADADataGridViewTextBoxColumn
            // 
            this.pECASPRODUZIDASPARADADataGridViewTextBoxColumn.DataPropertyName = "PECAS_PRODUZIDAS_PARADA";
            this.pECASPRODUZIDASPARADADataGridViewTextBoxColumn.HeaderText = "Peças Prod.";
            this.pECASPRODUZIDASPARADADataGridViewTextBoxColumn.Name = "pECASPRODUZIDASPARADADataGridViewTextBoxColumn";
            this.pECASPRODUZIDASPARADADataGridViewTextBoxColumn.Visible = false;
            this.pECASPRODUZIDASPARADADataGridViewTextBoxColumn.Width = 30;
            // 
            // oBSPARADADataGridViewTextBoxColumn
            // 
            this.oBSPARADADataGridViewTextBoxColumn.DataPropertyName = "OBS_PARADA";
            this.oBSPARADADataGridViewTextBoxColumn.HeaderText = "Observações";
            this.oBSPARADADataGridViewTextBoxColumn.Name = "oBSPARADADataGridViewTextBoxColumn";
            this.oBSPARADADataGridViewTextBoxColumn.Visible = false;
            this.oBSPARADADataGridViewTextBoxColumn.Width = 50;
            // 
            // col_rotas_campo
            // 
            this.col_rotas_campo.DataPropertyName = "N_ROTAS_CAMPO";
            this.col_rotas_campo.HeaderText = "N_ROTAS_CAMPO";
            this.col_rotas_campo.Name = "col_rotas_campo";
            this.col_rotas_campo.Visible = false;
            // 
            // col_operador_reinicio
            // 
            this.col_operador_reinicio.DataPropertyName = "OPERADOR_FINALIZADOR_PARADA";
            this.col_operador_reinicio.HeaderText = "Oper. Reinicio";
            this.col_operador_reinicio.Name = "col_operador_reinicio";
            this.col_operador_reinicio.Width = 40;
            // 
            // col_maquina_reinicio
            // 
            this.col_maquina_reinicio.DataPropertyName = "MAQUINA_REINICIO";
            this.col_maquina_reinicio.HeaderText = "Máq. Reinício";
            this.col_maquina_reinicio.Name = "col_maquina_reinicio";
            this.col_maquina_reinicio.Width = 30;
            // 
            // col_itens_reinicio
            // 
            this.col_itens_reinicio.DataPropertyName = "ITENS_CONJUNTOS_REINICIO";
            this.col_itens_reinicio.HeaderText = "ICR";
            this.col_itens_reinicio.Name = "col_itens_reinicio";
            this.col_itens_reinicio.Width = 25;
            // 
            // col_hora_reinicio
            // 
            this.col_hora_reinicio.DataPropertyName = "HORA_TERMINO";
            dataGridViewCellStyle35.Format = "t";
            dataGridViewCellStyle35.NullValue = null;
            this.col_hora_reinicio.DefaultCellStyle = dataGridViewCellStyle35;
            this.col_hora_reinicio.HeaderText = "Hora Reinicio";
            this.col_hora_reinicio.Name = "col_hora_reinicio";
            this.col_hora_reinicio.Width = 60;
            // 
            // col_data_reinicio
            // 
            this.col_data_reinicio.DataPropertyName = "DATA_TERMINO";
            this.col_data_reinicio.HeaderText = "Data Reinicio";
            this.col_data_reinicio.Name = "col_data_reinicio";
            this.col_data_reinicio.Width = 60;
            // 
            // col_operador
            // 
            this.col_operador.DataPropertyName = "OPERADOR";
            this.col_operador.HeaderText = "Oper. Parada";
            this.col_operador.Name = "col_operador";
            this.col_operador.Width = 40;
            // 
            // col_maquina
            // 
            this.col_maquina.DataPropertyName = "MAQUINA_PARADA";
            this.col_maquina.HeaderText = "Máq. Parada";
            this.col_maquina.Name = "col_maquina";
            this.col_maquina.Width = 30;
            // 
            // col_itens_parada
            // 
            this.col_itens_parada.DataPropertyName = "ITENS_CONJUNTOS_PARADA";
            this.col_itens_parada.HeaderText = "ICP";
            this.col_itens_parada.Name = "col_itens_parada";
            this.col_itens_parada.Width = 25;
            // 
            // col_hora
            // 
            this.col_hora.DataPropertyName = "HORA_INICIO";
            dataGridViewCellStyle34.Format = "t";
            dataGridViewCellStyle34.NullValue = null;
            this.col_hora.DefaultCellStyle = dataGridViewCellStyle34;
            this.col_hora.HeaderText = "Hora Parada";
            this.col_hora.Name = "col_hora";
            this.col_hora.Width = 60;
            // 
            // col_data
            // 
            this.col_data.DataPropertyName = "DATA_INICIO";
            this.col_data.HeaderText = "Data Parada";
            this.col_data.Name = "col_data";
            this.col_data.Width = 60;
            // 
            // tIPOPARADADataGridViewTextBoxColumn
            // 
            this.tIPOPARADADataGridViewTextBoxColumn.DataPropertyName = "TIPO_PARADA";
            this.tIPOPARADADataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tIPOPARADADataGridViewTextBoxColumn.Name = "tIPOPARADADataGridViewTextBoxColumn";
            this.tIPOPARADADataGridViewTextBoxColumn.Width = 80;
            // 
            // col_cod_parada
            // 
            this.col_cod_parada.DataPropertyName = "COD_PARADA";
            this.col_cod_parada.HeaderText = "Código";
            this.col_cod_parada.Name = "col_cod_parada";
            this.col_cod_parada.Width = 60;
            // 
            // cODPARADANUMDataGridViewTextBoxColumn
            // 
            this.cODPARADANUMDataGridViewTextBoxColumn.DataPropertyName = "COD_PARADA_NUM";
            this.cODPARADANUMDataGridViewTextBoxColumn.HeaderText = "Código";
            this.cODPARADANUMDataGridViewTextBoxColumn.Name = "cODPARADANUMDataGridViewTextBoxColumn";
            this.cODPARADANUMDataGridViewTextBoxColumn.Visible = false;
            this.cODPARADANUMDataGridViewTextBoxColumn.Width = 50;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_qtde_inicio);
            this.groupBox2.Controls.Add(this.label41);
            this.groupBox2.Controls.Add(this.cb_se_inicio);
            this.groupBox2.Controls.Add(this.tb_horas_se_inicio);
            this.groupBox2.Controls.Add(this.tb_onde_se_inicio);
            this.groupBox2.Controls.Add(this.label37);
            this.groupBox2.Controls.Add(this.label38);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(30, 317);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(167, 80);
            this.groupBox2.TabIndex = 256;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Serviço Externo";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(17, 59);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(28, 12);
            this.label41.TabIndex = 251;
            this.label41.Text = "Qtde:";
            // 
            // cb_se_inicio
            // 
            this.cb_se_inicio.AutoSize = true;
            this.cb_se_inicio.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsRotas, "ROTAS_CAMPO.SERVICO_EXTERNO_INICIO", true));
            this.cb_se_inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_se_inicio.Location = new System.Drawing.Point(19, 17);
            this.cb_se_inicio.Name = "cb_se_inicio";
            this.cb_se_inicio.Size = new System.Drawing.Size(15, 14);
            this.cb_se_inicio.TabIndex = 250;
            this.cb_se_inicio.UseVisualStyleBackColor = true;
            // 
            // tb_horas_se_inicio
            // 
            this.tb_horas_se_inicio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRotas, "ROTAS_CAMPO.HORAS_SERVICO_EXTERNO_INICIO", true));
            this.tb_horas_se_inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_horas_se_inicio.Location = new System.Drawing.Point(110, 16);
            this.tb_horas_se_inicio.Name = "tb_horas_se_inicio";
            this.tb_horas_se_inicio.Size = new System.Drawing.Size(51, 18);
            this.tb_horas_se_inicio.TabIndex = 248;
            // 
            // tb_onde_se_inicio
            // 
            this.tb_onde_se_inicio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRotas, "ROTAS_CAMPO.FORNECEDOR_SERVICO_EXTERNO", true));
            this.tb_onde_se_inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_onde_se_inicio.Location = new System.Drawing.Point(53, 35);
            this.tb_onde_se_inicio.Name = "tb_onde_se_inicio";
            this.tb_onde_se_inicio.Size = new System.Drawing.Size(108, 18);
            this.tb_onde_se_inicio.TabIndex = 243;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(17, 38);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(30, 12);
            this.label37.TabIndex = 242;
            this.label37.Text = "Onde:";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(63, 17);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(33, 12);
            this.label38.TabIndex = 241;
            this.label38.Text = "Horas:";
            // 
            // tb_qtde_inicio
            // 
            this.tb_qtde_inicio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRotas, "ROTAS_CAMPO.QTDE_SERVICO_EXTERNO", true));
            this.tb_qtde_inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_qtde_inicio.Location = new System.Drawing.Point(53, 56);
            this.tb_qtde_inicio.Name = "tb_qtde_inicio";
            this.tb_qtde_inicio.Size = new System.Drawing.Size(60, 18);
            this.tb_qtde_inicio.TabIndex = 253;
            // 
            // dataColumn27
            // 
            this.dataColumn27.ColumnName = "QTDE_SERVICO_EXTERNO";
            this.dataColumn27.DataType = typeof(int);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(554, 88);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(33, 13);
            this.label42.TabIndex = 262;
            this.label42.Text = "Qtde:";
            // 
            // tb_qtde
            // 
            this.tb_qtde.Location = new System.Drawing.Point(39, 71);
            this.tb_qtde.Name = "tb_qtde";
            this.tb_qtde.Size = new System.Drawing.Size(57, 20);
            this.tb_qtde.TabIndex = 265;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(38, 58);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(30, 13);
            this.label40.TabIndex = 264;
            this.label40.Text = "Qtde";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tb_qtde);
            this.groupBox4.Controls.Add(this.label40);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.tb_forn);
            this.groupBox4.Controls.Add(this.label31);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.tb_se);
            this.groupBox4.Controls.Add(this.cb_servico_externo);
            this.groupBox4.Location = new System.Drawing.Point(403, 325);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(127, 96);
            this.groupBox4.TabIndex = 266;
            this.groupBox4.TabStop = false;
            // 
            // dataColumn28
            // 
            this.dataColumn28.ColumnName = "QTDE_ROTA";
            this.dataColumn28.DataType = typeof(int);
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRotas, "ROTAS_CAMPO.QTDE_ROTA", true));
            this.textBox3.Location = new System.Drawing.Point(606, 85);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(83, 20);
            this.textBox3.TabIndex = 267;
            // 
            // form_rotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 618);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label42);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tb_n_os_conj);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.tb_previsao_semana);
            this.Controls.Add(this.tb_funcao);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.cbRetrabalho);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tb_itens_fecha);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_retrabalho_rota);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.tb_itens_ini);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gb_estado);
            this.Controls.Add(this.tb_horas_manuais_reais);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.tb_horas_trab);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.tb_situacao);
            this.Controls.Add(this.tb_maquina_final);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.tb_maquina_ini);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.tb_operador_final);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.salva_registro);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.tb_entrada_hora);
            this.Controls.Add(this.tb_operador);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tb_n_pdf);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tb_prev);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_fechamento_data);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_fechamento_hora);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_entrada_data);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_obs);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tb_peca);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.tb_codop);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.tb_fecha_prev);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_ent_prev);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_operacao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_codigo_rota);
            this.Controls.Add(this.label1);
            this.Name = "form_rotas";
            this.Text = "Rota";
            this.Load += new System.EventHandler(this.form_rotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsRotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ROTAS_CAMPO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsParadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PARADAS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHoras_semana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HORAS_SEMANA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsForn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FORNECEDORES)).EndInit();
            this.gb_estado.ResumeLayout(false);
            this.gb_estado.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsMaquina_rodando)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MAQUINA_RODANDO)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datRotas;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_codigo_rota;
        private System.Windows.Forms.TextBox tb_operacao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_ent_prev;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_fecha_prev;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_entrada_hora;
        private System.Windows.Forms.TextBox tb_operador;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_n_pdf;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_prev;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_fechamento_data;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_fechamento_hora;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_entrada_data;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_obs;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tb_peca;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tb_codop;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datParadas;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand8;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand6;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand5;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand7;
        private System.Data.DataSet dsRotas;
        private System.Data.DataTable ROTAS_CAMPO;
        private System.Data.DataColumn COD_ROTA_CAMPO;
        private System.Data.DataColumn COD_NUM_ROTAS;
        private System.Data.DataColumn COD_ROTA_PECA;
        private System.Data.DataColumn OBSERVACAO_CAMPO;
        private System.Data.DataColumn DESENHO_CAMPO;
        private System.Data.DataColumn POSICAO_FILA_CAMPO;
        private System.Data.DataColumn DATA_ENTRADA;
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
        private System.Data.DataSet dsParadas;
        private System.Data.DataTable PARADAS;
        private System.Data.DataColumn COD_PARADA;
        private System.Data.DataColumn TIPO_PARADA;
        private System.Data.DataColumn DATA_INICIO;
        private System.Data.DataColumn DATA_TERMINO;
        private System.Data.DataColumn N_ROTAS_CAMPO;
        private System.Data.DataColumn OBS_PARADA;
        private System.Data.DataColumn PECAS_PRODUZIDAS_PARADA;
        private System.Data.DataColumn OPERADOR;
        private System.Data.DataColumn MAQUINA_PARADA;
        private System.Data.DataColumn PARADA_FINALIZADA;
        private System.Data.DataColumn COD_PARADA_NUM;
        private System.Windows.Forms.Button salva_registro;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbRotas;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbParadas;
        private System.Data.DataColumn dataColumn1;
        private System.Windows.Forms.TextBox tb_operador_final;
        private System.Windows.Forms.Label label18;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Windows.Forms.TextBox tb_maquina_final;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tb_maquina_ini;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tb_situacao;
        private System.Windows.Forms.Button button3;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datHoras_semana;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand12;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand10;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand9;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand11;
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
        private System.Data.DataColumn dataColumn7;
        private System.Windows.Forms.TextBox tb_horas_trab;
        private System.Windows.Forms.Label label25;
        private System.Data.DataColumn dataColumn8;
        private System.Data.DataColumn dataColumn9;
        private System.Windows.Forms.TextBox tb_horas_manuais_reais;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.CheckBox cb_servico_externo;
        private System.Data.DataColumn dataColumn10;
        private System.Windows.Forms.Label label12;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datForn;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand16;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand14;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand13;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand15;
        private System.Data.DataSet dsForn;
        private System.Data.DataTable FORNECEDORES;
        private System.Data.DataColumn COD_FORN;
        private System.Data.DataColumn NOME_FORN;
        private System.Data.DataColumn TEL_FORN;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.GroupBox gb_estado;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox tb_nova_maquina;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox tb_nova_hora;
        private System.Windows.Forms.TextBox tb_novo_operador;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox tb_nova_data;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox tb_se;
        private System.Windows.Forms.Button btParada_finalizado;
        private System.Windows.Forms.Button btFinalizado_parada;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tb_itens_ini;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox tb_novo_itens_conj;
        private System.Data.DataColumn dataColumn11;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datMaquina_rodando;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand20;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand18;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand17;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand19;
        private System.Data.DataSet dsMaquina_rodando;
        private System.Data.DataTable MAQUINA_RODANDO;
        private System.Data.DataColumn COD_MAQUINA_RODANDO;
        private System.Data.DataColumn MAQUINA_ATUAL;
        private System.Data.DataColumn DATA_MAQUINA_TRABALHANDO;
        private System.Data.DataColumn ROTA_MAQUINA_RODANDO;
        private System.Data.DataColumn OPERADOR_MAQUINA_RODANDO;
        private System.Data.DataColumn HORAS_TRABALHADAS_MAQUINA;
        private System.Data.DataColumn OS_MAQUINA_RODANDO;
        private System.Windows.Forms.TextBox tb_retrabalho_rota;
        private System.Windows.Forms.Label label23;
        private System.Data.DataColumn dataColumn12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_itens_fecha;
        private System.Windows.Forms.Label label24;
        private System.Data.DataColumn dataColumn13;
        private System.Windows.Forms.TextBox tb_forn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox cb_horas_manuais;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tb_horas_manuais;
        private System.Windows.Forms.RadioButton radioParar;
        private System.Windows.Forms.RadioButton radioFinalizar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbRetrabalho;
        private System.Windows.Forms.TextBox tb_funcao;
        private System.Windows.Forms.Label label33;
        private System.Data.DataColumn dataColumn14;
        private System.Windows.Forms.TextBox tb_previsao_semana;
        private System.Windows.Forms.Label label34;
        private System.Data.DataColumn dataColumn15;
        private System.Data.DataColumn dataColumn16;
        private System.Data.DataColumn dataColumn17;
        private System.Data.DataColumn dataColumn18;
        private System.Data.DataColumn dataColumn19;
        private System.Data.DataColumn dataColumn20;
        private System.Data.DataColumn dataColumn21;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label36;
        private System.Data.DataColumn dataColumn22;
        private System.Windows.Forms.TextBox tb_n_os_conj;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Button button4;
        private System.Data.DataColumn dataColumn23;
        private System.Data.DataColumn dataColumn24;
        private System.Data.DataColumn dataColumn25;
        private System.Data.DataColumn dataColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODPARADANUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod_parada;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIPOPARADADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_data;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_itens_parada;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_maquina;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_operador;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_data_reinicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_hora_reinicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_itens_reinicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_maquina_reinicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_operador_reinicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_rotas_campo;
        private System.Windows.Forms.DataGridViewTextBoxColumn oBSPARADADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pECASPRODUZIDASPARADADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_parada_final;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_se;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_horas_se;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_onde_se;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.CheckBox cb_se_inicio;
        private System.Windows.Forms.TextBox tb_horas_se_inicio;
        private System.Windows.Forms.TextBox tb_onde_se_inicio;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox tb_qtde_inicio;
        private System.Data.DataColumn dataColumn27;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TextBox tb_qtde;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Data.DataColumn dataColumn28;
        private System.Windows.Forms.TextBox textBox3;
    }
}