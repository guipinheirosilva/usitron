namespace Evolucao
{
    partial class form_rotas_X
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_rotas_X));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.datRotas_campo = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.rotalabel = new System.Windows.Forms.Label();
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
            this.ULTIMA_MAQUINA = new System.Data.DataColumn();
            this.SERVICO_EXTERNO_INICIO = new System.Data.DataColumn();
            this.HORAS_SERVICO_EXTERNO_INICIO = new System.Data.DataColumn();
            this.ULTIMO_OS_CONJUNTAS = new System.Data.DataColumn();
            this.OS_POS_ULTIMO_OS_CONJUNTAS = new System.Data.DataColumn();
            this.QTDE_ROTA = new System.Data.DataColumn();
            this.QTDE_SERVICO_EXTERNO = new System.Data.DataColumn();
            this.CODIGO_OS_CAMPO = new System.Data.DataColumn();
            this.ABREV_OPERACAO_ROTA = new System.Data.DataColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tb_hora_inicio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_hora_fim = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvApontamentos = new System.Windows.Forms.DataGridView();
            this.cODAPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOTE_AP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAINICIOAPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORAINICIOAPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAQUINAAPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPERADORAPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAFIMAPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORAFIMAPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sALDOHORASAPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTDE_AP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOTIVO_PARADA_AP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sERVICOEXTERNOAPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fORNSERVICOEXTERNOAPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNPJFORNSERVICOEXTERNOAPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORASSERVICOEXTERNOAPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORSERVICOEXTERNOAPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rOTAAPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONJUNTASAPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oSAPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOSICAOAPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPERACAOAPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsApontamentos = new System.Data.DataSet();
            this.APONTAMENTOS = new System.Data.DataTable();
            this.COD_AP = new System.Data.DataColumn();
            this.DATA_INICIO_AP = new System.Data.DataColumn();
            this.HORA_INICIO_AP = new System.Data.DataColumn();
            this.MAQUINA_AP = new System.Data.DataColumn();
            this.OPERADOR_AP = new System.Data.DataColumn();
            this.DATA_FIM_AP = new System.Data.DataColumn();
            this.HORA_FIM_AP = new System.Data.DataColumn();
            this.SERVICO_EXTERNO_AP = new System.Data.DataColumn();
            this.FORN_SERVICO_EXTERNO_AP = new System.Data.DataColumn();
            this.CNPJ_FORN_SERVICO_EXTERNO_AP = new System.Data.DataColumn();
            this.HORAS_SERVICO_EXTERNO_AP = new System.Data.DataColumn();
            this.VALOR_SERVICO_EXTERNO_AP = new System.Data.DataColumn();
            this.ROTA_AP = new System.Data.DataColumn();
            this.CONJUNTAS_AP = new System.Data.DataColumn();
            this.OS_AP = new System.Data.DataColumn();
            this.POSICAO_AP = new System.Data.DataColumn();
            this.OPERACAO_AP = new System.Data.DataColumn();
            this.SALDO_HORAS_AP = new System.Data.DataColumn();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.datApontamentos = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand8 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand6 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand5 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand7 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.button3 = new System.Windows.Forms.Button();
            this.cbRotas_campo = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.cbApontamentos = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            ((System.ComponentModel.ISupportInitialize)(this.dsRotas_campo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ROTAS_CAMPO)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApontamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsApontamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.APONTAMENTOS)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
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
            // rotalabel
            // 
            this.rotalabel.AutoSize = true;
            this.rotalabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRotas_campo, "ROTAS_CAMPO.COD_ROTA_CAMPO", true));
            this.rotalabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rotalabel.ForeColor = System.Drawing.Color.Lime;
            this.rotalabel.Location = new System.Drawing.Point(137, 9);
            this.rotalabel.Name = "rotalabel";
            this.rotalabel.Size = new System.Drawing.Size(105, 46);
            this.rotalabel.TabIndex = 0;
            this.rotalabel.Text = "Rota";
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
            this.INSERIDO_SEMANA,
            this.ULTIMA_MAQUINA,
            this.SERVICO_EXTERNO_INICIO,
            this.HORAS_SERVICO_EXTERNO_INICIO,
            this.ULTIMO_OS_CONJUNTAS,
            this.OS_POS_ULTIMO_OS_CONJUNTAS,
            this.QTDE_ROTA,
            this.QTDE_SERVICO_EXTERNO,
            this.CODIGO_OS_CAMPO,
            this.ABREV_OPERACAO_ROTA});
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
            this.HORA_ENTRADA.DataType = typeof(System.DateTime);
            // 
            // DATA_ENTRADA
            // 
            this.DATA_ENTRADA.ColumnName = "DATA_ENTRADA";
            this.DATA_ENTRADA.DataType = typeof(System.DateTime);
            // 
            // HORA_FECHAMENTO
            // 
            this.HORA_FECHAMENTO.ColumnName = "HORA_FECHAMENTO";
            this.HORA_FECHAMENTO.DataType = typeof(System.DateTime);
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
            this.ULTIMO_OPERADOR.MaxLength = 20;
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
            // ULTIMA_MAQUINA
            // 
            this.ULTIMA_MAQUINA.ColumnName = "ULTIMA_MAQUINA";
            this.ULTIMA_MAQUINA.MaxLength = 5;
            // 
            // SERVICO_EXTERNO_INICIO
            // 
            this.SERVICO_EXTERNO_INICIO.ColumnName = "SERVICO_EXTERNO_INICIO";
            this.SERVICO_EXTERNO_INICIO.DataType = typeof(int);
            // 
            // HORAS_SERVICO_EXTERNO_INICIO
            // 
            this.HORAS_SERVICO_EXTERNO_INICIO.ColumnName = "HORAS_SERVICO_EXTERNO_INICIO";
            this.HORAS_SERVICO_EXTERNO_INICIO.DataType = typeof(double);
            // 
            // ULTIMO_OS_CONJUNTAS
            // 
            this.ULTIMO_OS_CONJUNTAS.ColumnName = "ULTIMO_OS_CONJUNTAS";
            this.ULTIMO_OS_CONJUNTAS.DataType = typeof(int);
            // 
            // OS_POS_ULTIMO_OS_CONJUNTAS
            // 
            this.OS_POS_ULTIMO_OS_CONJUNTAS.ColumnName = "OS_POS_ULTIMO_OS_CONJUNTAS";
            this.OS_POS_ULTIMO_OS_CONJUNTAS.MaxLength = 50;
            // 
            // QTDE_ROTA
            // 
            this.QTDE_ROTA.ColumnName = "QTDE_ROTA";
            this.QTDE_ROTA.DataType = typeof(int);
            // 
            // QTDE_SERVICO_EXTERNO
            // 
            this.QTDE_SERVICO_EXTERNO.ColumnName = "QTDE_SERVICO_EXTERNO";
            this.QTDE_SERVICO_EXTERNO.DataType = typeof(int);
            // 
            // CODIGO_OS_CAMPO
            // 
            this.CODIGO_OS_CAMPO.ColumnName = "CODIGO_OS_CAMPO";
            this.CODIGO_OS_CAMPO.MaxLength = 20;
            // 
            // ABREV_OPERACAO_ROTA
            // 
            this.ABREV_OPERACAO_ROTA.ColumnName = "ABREV_OPERACAO_ROTA";
            this.ABREV_OPERACAO_ROTA.MaxLength = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rota:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 46);
            this.label2.TabIndex = 3;
            this.label2.Text = "Operação:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRotas_campo, "ROTAS_CAMPO.OPERACAO_CAMPO", true));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(232, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 46);
            this.label3.TabIndex = 2;
            this.label3.Text = "Operação";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Data Início:";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRotas_campo, "ROTAS_CAMPO.DATA_ENTRADA", true));
            this.textBox1.Location = new System.Drawing.Point(86, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(110, 23);
            this.textBox1.TabIndex = 5;
            // 
            // tb_hora_inicio
            // 
            this.tb_hora_inicio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRotas_campo, "ROTAS_CAMPO.HORA_ENTRADA", true));
            this.tb_hora_inicio.Location = new System.Drawing.Point(86, 32);
            this.tb_hora_inicio.Name = "tb_hora_inicio";
            this.tb_hora_inicio.Size = new System.Drawing.Size(110, 23);
            this.tb_hora_inicio.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Hora Início:";
            // 
            // tb_hora_fim
            // 
            this.tb_hora_fim.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRotas_campo, "ROTAS_CAMPO.HORA_FECHAMENTO", true));
            this.tb_hora_fim.Location = new System.Drawing.Point(283, 32);
            this.tb_hora_fim.Name = "tb_hora_fim";
            this.tb_hora_fim.Size = new System.Drawing.Size(110, 23);
            this.tb_hora_fim.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(203, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Hora Fim:";
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRotas_campo, "ROTAS_CAMPO.DATA_FECHAMENTO", true));
            this.textBox4.Location = new System.Drawing.Point(283, 6);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(110, 23);
            this.textBox4.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(203, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Data Fim:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.tb_hora_fim);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tb_hora_inicio);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(22, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 59);
            this.panel1.TabIndex = 12;
            // 
            // dgvApontamentos
            // 
            this.dgvApontamentos.AllowUserToAddRows = false;
            this.dgvApontamentos.AutoGenerateColumns = false;
            this.dgvApontamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApontamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODAPDataGridViewTextBoxColumn,
            this.LOTE_AP,
            this.dATAINICIOAPDataGridViewTextBoxColumn,
            this.hORAINICIOAPDataGridViewTextBoxColumn,
            this.mAQUINAAPDataGridViewTextBoxColumn,
            this.oPERADORAPDataGridViewTextBoxColumn,
            this.dATAFIMAPDataGridViewTextBoxColumn,
            this.hORAFIMAPDataGridViewTextBoxColumn,
            this.sALDOHORASAPDataGridViewTextBoxColumn,
            this.QTDE_AP,
            this.MOTIVO_PARADA_AP,
            this.sERVICOEXTERNOAPDataGridViewTextBoxColumn,
            this.fORNSERVICOEXTERNOAPDataGridViewTextBoxColumn,
            this.cNPJFORNSERVICOEXTERNOAPDataGridViewTextBoxColumn,
            this.hORASSERVICOEXTERNOAPDataGridViewTextBoxColumn,
            this.vALORSERVICOEXTERNOAPDataGridViewTextBoxColumn,
            this.rOTAAPDataGridViewTextBoxColumn,
            this.cONJUNTASAPDataGridViewTextBoxColumn,
            this.oSAPDataGridViewTextBoxColumn,
            this.pOSICAOAPDataGridViewTextBoxColumn,
            this.oPERACAOAPDataGridViewTextBoxColumn});
            this.dgvApontamentos.DataMember = "APONTAMENTOS";
            this.dgvApontamentos.DataSource = this.dsApontamentos;
            this.dgvApontamentos.Location = new System.Drawing.Point(9, 28);
            this.dgvApontamentos.Name = "dgvApontamentos";
            this.dgvApontamentos.Size = new System.Drawing.Size(934, 278);
            this.dgvApontamentos.TabIndex = 13;
            // 
            // cODAPDataGridViewTextBoxColumn
            // 
            this.cODAPDataGridViewTextBoxColumn.DataPropertyName = "COD_AP";
            this.cODAPDataGridViewTextBoxColumn.HeaderText = "COD_AP";
            this.cODAPDataGridViewTextBoxColumn.Name = "cODAPDataGridViewTextBoxColumn";
            this.cODAPDataGridViewTextBoxColumn.Visible = false;
            // 
            // LOTE_AP
            // 
            this.LOTE_AP.DataPropertyName = "LOTE_AP";
            this.LOTE_AP.HeaderText = "Pacote";
            this.LOTE_AP.Name = "LOTE_AP";
            this.LOTE_AP.Width = 70;
            // 
            // dATAINICIOAPDataGridViewTextBoxColumn
            // 
            this.dATAINICIOAPDataGridViewTextBoxColumn.DataPropertyName = "DATA_INICIO_AP";
            this.dATAINICIOAPDataGridViewTextBoxColumn.HeaderText = "Data Início";
            this.dATAINICIOAPDataGridViewTextBoxColumn.Name = "dATAINICIOAPDataGridViewTextBoxColumn";
            this.dATAINICIOAPDataGridViewTextBoxColumn.Width = 70;
            // 
            // hORAINICIOAPDataGridViewTextBoxColumn
            // 
            this.hORAINICIOAPDataGridViewTextBoxColumn.DataPropertyName = "HORA_INICIO_AP";
            dataGridViewCellStyle1.Format = "T";
            dataGridViewCellStyle1.NullValue = null;
            this.hORAINICIOAPDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.hORAINICIOAPDataGridViewTextBoxColumn.HeaderText = "Hora Início";
            this.hORAINICIOAPDataGridViewTextBoxColumn.Name = "hORAINICIOAPDataGridViewTextBoxColumn";
            this.hORAINICIOAPDataGridViewTextBoxColumn.Width = 70;
            // 
            // mAQUINAAPDataGridViewTextBoxColumn
            // 
            this.mAQUINAAPDataGridViewTextBoxColumn.DataPropertyName = "MAQUINA_AP";
            this.mAQUINAAPDataGridViewTextBoxColumn.HeaderText = "Máquina";
            this.mAQUINAAPDataGridViewTextBoxColumn.Name = "mAQUINAAPDataGridViewTextBoxColumn";
            this.mAQUINAAPDataGridViewTextBoxColumn.Width = 70;
            // 
            // oPERADORAPDataGridViewTextBoxColumn
            // 
            this.oPERADORAPDataGridViewTextBoxColumn.DataPropertyName = "OPERADOR_AP";
            this.oPERADORAPDataGridViewTextBoxColumn.HeaderText = "Operador";
            this.oPERADORAPDataGridViewTextBoxColumn.Name = "oPERADORAPDataGridViewTextBoxColumn";
            this.oPERADORAPDataGridViewTextBoxColumn.Width = 70;
            // 
            // dATAFIMAPDataGridViewTextBoxColumn
            // 
            this.dATAFIMAPDataGridViewTextBoxColumn.DataPropertyName = "DATA_FIM_AP";
            this.dATAFIMAPDataGridViewTextBoxColumn.HeaderText = "Data Fim";
            this.dATAFIMAPDataGridViewTextBoxColumn.Name = "dATAFIMAPDataGridViewTextBoxColumn";
            this.dATAFIMAPDataGridViewTextBoxColumn.Width = 70;
            // 
            // hORAFIMAPDataGridViewTextBoxColumn
            // 
            this.hORAFIMAPDataGridViewTextBoxColumn.DataPropertyName = "HORA_FIM_AP";
            dataGridViewCellStyle2.Format = "T";
            dataGridViewCellStyle2.NullValue = null;
            this.hORAFIMAPDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.hORAFIMAPDataGridViewTextBoxColumn.HeaderText = "Hora Fim";
            this.hORAFIMAPDataGridViewTextBoxColumn.Name = "hORAFIMAPDataGridViewTextBoxColumn";
            this.hORAFIMAPDataGridViewTextBoxColumn.Width = 70;
            // 
            // sALDOHORASAPDataGridViewTextBoxColumn
            // 
            this.sALDOHORASAPDataGridViewTextBoxColumn.DataPropertyName = "SALDO_HORAS_AP";
            this.sALDOHORASAPDataGridViewTextBoxColumn.HeaderText = "Saldo Horas";
            this.sALDOHORASAPDataGridViewTextBoxColumn.Name = "sALDOHORASAPDataGridViewTextBoxColumn";
            this.sALDOHORASAPDataGridViewTextBoxColumn.Width = 70;
            // 
            // QTDE_AP
            // 
            this.QTDE_AP.DataPropertyName = "QTDE_AP";
            this.QTDE_AP.HeaderText = "Qtde";
            this.QTDE_AP.Name = "QTDE_AP";
            this.QTDE_AP.Width = 40;
            // 
            // MOTIVO_PARADA_AP
            // 
            this.MOTIVO_PARADA_AP.DataPropertyName = "MOTIVO_PARADA_AP";
            this.MOTIVO_PARADA_AP.HeaderText = "Motivo";
            this.MOTIVO_PARADA_AP.Name = "MOTIVO_PARADA_AP";
            // 
            // sERVICOEXTERNOAPDataGridViewTextBoxColumn
            // 
            this.sERVICOEXTERNOAPDataGridViewTextBoxColumn.DataPropertyName = "SERVICO_EXTERNO_AP";
            this.sERVICOEXTERNOAPDataGridViewTextBoxColumn.HeaderText = "SE";
            this.sERVICOEXTERNOAPDataGridViewTextBoxColumn.Name = "sERVICOEXTERNOAPDataGridViewTextBoxColumn";
            this.sERVICOEXTERNOAPDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sERVICOEXTERNOAPDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sERVICOEXTERNOAPDataGridViewTextBoxColumn.Width = 40;
            // 
            // fORNSERVICOEXTERNOAPDataGridViewTextBoxColumn
            // 
            this.fORNSERVICOEXTERNOAPDataGridViewTextBoxColumn.DataPropertyName = "FORN_SERVICO_EXTERNO_AP";
            this.fORNSERVICOEXTERNOAPDataGridViewTextBoxColumn.HeaderText = "Fornecedor";
            this.fORNSERVICOEXTERNOAPDataGridViewTextBoxColumn.Name = "fORNSERVICOEXTERNOAPDataGridViewTextBoxColumn";
            // 
            // cNPJFORNSERVICOEXTERNOAPDataGridViewTextBoxColumn
            // 
            this.cNPJFORNSERVICOEXTERNOAPDataGridViewTextBoxColumn.DataPropertyName = "CNPJ_FORN_SERVICO_EXTERNO_AP";
            this.cNPJFORNSERVICOEXTERNOAPDataGridViewTextBoxColumn.HeaderText = "CNPJ_FORN_SERVICO_EXTERNO_AP";
            this.cNPJFORNSERVICOEXTERNOAPDataGridViewTextBoxColumn.Name = "cNPJFORNSERVICOEXTERNOAPDataGridViewTextBoxColumn";
            this.cNPJFORNSERVICOEXTERNOAPDataGridViewTextBoxColumn.Visible = false;
            // 
            // hORASSERVICOEXTERNOAPDataGridViewTextBoxColumn
            // 
            this.hORASSERVICOEXTERNOAPDataGridViewTextBoxColumn.DataPropertyName = "HORAS_SERVICO_EXTERNO_AP";
            this.hORASSERVICOEXTERNOAPDataGridViewTextBoxColumn.HeaderText = "Horas SE";
            this.hORASSERVICOEXTERNOAPDataGridViewTextBoxColumn.Name = "hORASSERVICOEXTERNOAPDataGridViewTextBoxColumn";
            this.hORASSERVICOEXTERNOAPDataGridViewTextBoxColumn.Width = 70;
            // 
            // vALORSERVICOEXTERNOAPDataGridViewTextBoxColumn
            // 
            this.vALORSERVICOEXTERNOAPDataGridViewTextBoxColumn.DataPropertyName = "VALOR_SERVICO_EXTERNO_AP";
            this.vALORSERVICOEXTERNOAPDataGridViewTextBoxColumn.HeaderText = "Valor SE";
            this.vALORSERVICOEXTERNOAPDataGridViewTextBoxColumn.Name = "vALORSERVICOEXTERNOAPDataGridViewTextBoxColumn";
            // 
            // rOTAAPDataGridViewTextBoxColumn
            // 
            this.rOTAAPDataGridViewTextBoxColumn.DataPropertyName = "ROTA_AP";
            this.rOTAAPDataGridViewTextBoxColumn.HeaderText = "ROTA_AP";
            this.rOTAAPDataGridViewTextBoxColumn.Name = "rOTAAPDataGridViewTextBoxColumn";
            this.rOTAAPDataGridViewTextBoxColumn.Visible = false;
            // 
            // cONJUNTASAPDataGridViewTextBoxColumn
            // 
            this.cONJUNTASAPDataGridViewTextBoxColumn.DataPropertyName = "CONJUNTAS_AP";
            this.cONJUNTASAPDataGridViewTextBoxColumn.HeaderText = "Conj.";
            this.cONJUNTASAPDataGridViewTextBoxColumn.Name = "cONJUNTASAPDataGridViewTextBoxColumn";
            this.cONJUNTASAPDataGridViewTextBoxColumn.Width = 50;
            // 
            // oSAPDataGridViewTextBoxColumn
            // 
            this.oSAPDataGridViewTextBoxColumn.DataPropertyName = "OS_AP";
            this.oSAPDataGridViewTextBoxColumn.HeaderText = "OS_AP";
            this.oSAPDataGridViewTextBoxColumn.Name = "oSAPDataGridViewTextBoxColumn";
            this.oSAPDataGridViewTextBoxColumn.Visible = false;
            this.oSAPDataGridViewTextBoxColumn.Width = 60;
            // 
            // pOSICAOAPDataGridViewTextBoxColumn
            // 
            this.pOSICAOAPDataGridViewTextBoxColumn.DataPropertyName = "POSICAO_AP";
            this.pOSICAOAPDataGridViewTextBoxColumn.HeaderText = "POSICAO_AP";
            this.pOSICAOAPDataGridViewTextBoxColumn.Name = "pOSICAOAPDataGridViewTextBoxColumn";
            this.pOSICAOAPDataGridViewTextBoxColumn.Visible = false;
            // 
            // oPERACAOAPDataGridViewTextBoxColumn
            // 
            this.oPERACAOAPDataGridViewTextBoxColumn.DataPropertyName = "OPERACAO_AP";
            this.oPERACAOAPDataGridViewTextBoxColumn.HeaderText = "OPERACAO_AP";
            this.oPERACAOAPDataGridViewTextBoxColumn.Name = "oPERACAOAPDataGridViewTextBoxColumn";
            this.oPERACAOAPDataGridViewTextBoxColumn.Visible = false;
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
            this.COD_AP,
            this.DATA_INICIO_AP,
            this.HORA_INICIO_AP,
            this.MAQUINA_AP,
            this.OPERADOR_AP,
            this.DATA_FIM_AP,
            this.HORA_FIM_AP,
            this.SERVICO_EXTERNO_AP,
            this.FORN_SERVICO_EXTERNO_AP,
            this.CNPJ_FORN_SERVICO_EXTERNO_AP,
            this.HORAS_SERVICO_EXTERNO_AP,
            this.VALOR_SERVICO_EXTERNO_AP,
            this.ROTA_AP,
            this.CONJUNTAS_AP,
            this.OS_AP,
            this.POSICAO_AP,
            this.OPERACAO_AP,
            this.SALDO_HORAS_AP,
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3});
            this.APONTAMENTOS.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_AP"}, true)});
            this.APONTAMENTOS.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_AP};
            this.APONTAMENTOS.TableName = "APONTAMENTOS";
            // 
            // COD_AP
            // 
            this.COD_AP.AllowDBNull = false;
            this.COD_AP.ColumnName = "COD_AP";
            this.COD_AP.DataType = typeof(int);
            // 
            // DATA_INICIO_AP
            // 
            this.DATA_INICIO_AP.ColumnName = "DATA_INICIO_AP";
            this.DATA_INICIO_AP.DataType = typeof(System.DateTime);
            // 
            // HORA_INICIO_AP
            // 
            this.HORA_INICIO_AP.ColumnName = "HORA_INICIO_AP";
            this.HORA_INICIO_AP.DataType = typeof(System.DateTime);
            // 
            // MAQUINA_AP
            // 
            this.MAQUINA_AP.ColumnName = "MAQUINA_AP";
            this.MAQUINA_AP.MaxLength = 100;
            // 
            // OPERADOR_AP
            // 
            this.OPERADOR_AP.ColumnName = "OPERADOR_AP";
            this.OPERADOR_AP.MaxLength = 100;
            // 
            // DATA_FIM_AP
            // 
            this.DATA_FIM_AP.ColumnName = "DATA_FIM_AP";
            this.DATA_FIM_AP.DataType = typeof(System.DateTime);
            // 
            // HORA_FIM_AP
            // 
            this.HORA_FIM_AP.ColumnName = "HORA_FIM_AP";
            this.HORA_FIM_AP.DataType = typeof(System.DateTime);
            // 
            // SERVICO_EXTERNO_AP
            // 
            this.SERVICO_EXTERNO_AP.ColumnName = "SERVICO_EXTERNO_AP";
            this.SERVICO_EXTERNO_AP.DataType = typeof(int);
            // 
            // FORN_SERVICO_EXTERNO_AP
            // 
            this.FORN_SERVICO_EXTERNO_AP.ColumnName = "FORN_SERVICO_EXTERNO_AP";
            this.FORN_SERVICO_EXTERNO_AP.MaxLength = 100;
            // 
            // CNPJ_FORN_SERVICO_EXTERNO_AP
            // 
            this.CNPJ_FORN_SERVICO_EXTERNO_AP.ColumnName = "CNPJ_FORN_SERVICO_EXTERNO_AP";
            this.CNPJ_FORN_SERVICO_EXTERNO_AP.MaxLength = 100;
            // 
            // HORAS_SERVICO_EXTERNO_AP
            // 
            this.HORAS_SERVICO_EXTERNO_AP.ColumnName = "HORAS_SERVICO_EXTERNO_AP";
            this.HORAS_SERVICO_EXTERNO_AP.DataType = typeof(double);
            // 
            // VALOR_SERVICO_EXTERNO_AP
            // 
            this.VALOR_SERVICO_EXTERNO_AP.ColumnName = "VALOR_SERVICO_EXTERNO_AP";
            this.VALOR_SERVICO_EXTERNO_AP.DataType = typeof(double);
            // 
            // ROTA_AP
            // 
            this.ROTA_AP.ColumnName = "ROTA_AP";
            this.ROTA_AP.DataType = typeof(int);
            // 
            // CONJUNTAS_AP
            // 
            this.CONJUNTAS_AP.ColumnName = "CONJUNTAS_AP";
            this.CONJUNTAS_AP.DataType = typeof(int);
            // 
            // OS_AP
            // 
            this.OS_AP.ColumnName = "OS_AP";
            this.OS_AP.MaxLength = 50;
            // 
            // POSICAO_AP
            // 
            this.POSICAO_AP.ColumnName = "POSICAO_AP";
            this.POSICAO_AP.MaxLength = 50;
            // 
            // OPERACAO_AP
            // 
            this.OPERACAO_AP.ColumnName = "OPERACAO_AP";
            this.OPERACAO_AP.MaxLength = 100;
            // 
            // SALDO_HORAS_AP
            // 
            this.SALDO_HORAS_AP.ColumnName = "SALDO_HORAS_AP";
            this.SALDO_HORAS_AP.DataType = typeof(double);
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "QTDE_AP";
            this.dataColumn1.DataType = typeof(int);
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "MOTIVO_PARADA_AP";
            this.dataColumn2.MaxLength = 200;
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "LOTE_AP";
            this.dataColumn3.DataType = typeof(int);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.dgvApontamentos);
            this.panel2.Location = new System.Drawing.Point(22, 151);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(955, 324);
            this.panel2.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Apontamentos";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(5, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(215, 31);
            this.label9.TabIndex = 16;
            this.label9.Text = "Horas Previstas:";
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRotas_campo, "ROTAS_CAMPO.PREVISAO_PRODUCAO", true));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(195, 2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(207, 31);
            this.label10.TabIndex = 15;
            this.label10.Text = "Horas Previstas";
            this.label10.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(5, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(237, 31);
            this.label11.TabIndex = 18;
            this.label11.Text = "Horas Realizadas:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRotas_campo, "ROTAS_CAMPO.SALDO_HORAS", true));
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(195, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(229, 31);
            this.label12.TabIndex = 17;
            this.label12.Text = "Horas Realizadas";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(430, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 36);
            this.button1.TabIndex = 19;
            this.button1.Text = "Salvar \r\nAlterações";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(597, 86);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(380, 59);
            this.panel3.TabIndex = 20;
            // 
            // datApontamentos
            // 
            this.datApontamentos.DeleteCommand = this.fbCommand8;
            this.datApontamentos.InsertCommand = this.fbCommand6;
            this.datApontamentos.SelectCommand = this.fbCommand5;
            this.datApontamentos.UpdateCommand = this.fbCommand7;
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
            this.fbCommand5.CommandText = "select * from apontamentos";
            this.fbCommand5.CommandTimeout = 30;
            this.fbCommand5.Connection = this.fbConnection1;
            // 
            // fbCommand7
            // 
            this.fbCommand7.CommandTimeout = 30;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(431, 86);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 22);
            this.button3.TabIndex = 22;
            this.button3.Text = "Fazer Lançamento";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cbRotas_campo
            // 
            this.cbRotas_campo.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbRotas_campo.DataAdapter = this.datRotas_campo;
            this.cbRotas_campo.QuotePrefix = "\"";
            this.cbRotas_campo.QuoteSuffix = "\"";
            // 
            // cbApontamentos
            // 
            this.cbApontamentos.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbApontamentos.DataAdapter = this.datApontamentos;
            this.cbApontamentos.QuotePrefix = "\"";
            this.cbApontamentos.QuoteSuffix = "\"";
            // 
            // form_rotas_X
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 498);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rotalabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "form_rotas_X";
            this.Text = "Rotas X";
            this.Load += new System.EventHandler(this.form_rotas_X_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsRotas_campo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ROTAS_CAMPO)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApontamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsApontamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.APONTAMENTOS)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.Label rotalabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tb_hora_inicio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_hora_fim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvApontamentos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datApontamentos;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand8;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand6;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand5;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand7;
        private System.Data.DataSet dsApontamentos;
        private System.Data.DataTable APONTAMENTOS;
        private System.Data.DataColumn COD_AP;
        private System.Data.DataColumn DATA_INICIO_AP;
        private System.Data.DataColumn HORA_INICIO_AP;
        private System.Data.DataColumn MAQUINA_AP;
        private System.Data.DataColumn OPERADOR_AP;
        private System.Data.DataColumn DATA_FIM_AP;
        private System.Data.DataColumn HORA_FIM_AP;
        private System.Data.DataColumn SERVICO_EXTERNO_AP;
        private System.Data.DataColumn FORN_SERVICO_EXTERNO_AP;
        private System.Data.DataColumn CNPJ_FORN_SERVICO_EXTERNO_AP;
        private System.Data.DataColumn HORAS_SERVICO_EXTERNO_AP;
        private System.Data.DataColumn VALOR_SERVICO_EXTERNO_AP;
        private System.Data.DataColumn ROTA_AP;
        private System.Data.DataColumn CONJUNTAS_AP;
        private System.Data.DataColumn OS_AP;
        private System.Data.DataColumn POSICAO_AP;
        private System.Data.DataColumn OPERACAO_AP;
        private System.Data.DataColumn SALDO_HORAS_AP;
        private System.Windows.Forms.Button button3;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbRotas_campo;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbApontamentos;
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
        private System.Data.DataColumn ULTIMA_MAQUINA;
        private System.Data.DataColumn SERVICO_EXTERNO_INICIO;
        private System.Data.DataColumn HORAS_SERVICO_EXTERNO_INICIO;
        private System.Data.DataColumn ULTIMO_OS_CONJUNTAS;
        private System.Data.DataColumn OS_POS_ULTIMO_OS_CONJUNTAS;
        private System.Data.DataColumn QTDE_ROTA;
        private System.Data.DataColumn QTDE_SERVICO_EXTERNO;
        private System.Data.DataColumn CODIGO_OS_CAMPO;
        private System.Data.DataColumn ABREV_OPERACAO_ROTA;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODAPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOTE_AP;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAINICIOAPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORAINICIOAPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAQUINAAPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPERADORAPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAFIMAPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORAFIMAPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sALDOHORASAPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTDE_AP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOTIVO_PARADA_AP;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sERVICOEXTERNOAPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fORNSERVICOEXTERNOAPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPJFORNSERVICOEXTERNOAPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORASSERVICOEXTERNOAPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORSERVICOEXTERNOAPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rOTAAPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONJUNTASAPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oSAPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOSICAOAPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPERACAOAPDataGridViewTextBoxColumn;
        private System.Data.DataColumn dataColumn3;
    }
}