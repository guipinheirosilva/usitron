namespace Evolucao
{
    partial class form_horas_manuais
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_horas_manuais));
            this.tb_os = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_operador = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bt_horas = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.tb_data = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_horas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_rota = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_maquina_nova = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_cod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.cbMaquina_rodando = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
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
            this.SERVICO_EXTERNO_ROTA = new System.Data.DataColumn();
            this.FORNECEDOR_SERVICO_EXTERNO = new System.Data.DataColumn();
            this.ULTIMO_OPERADOR = new System.Data.DataColumn();
            this.datHoras_semana = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand9 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand10 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand11 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand12 = new FirebirdSql.Data.FirebirdClient.FbCommand();
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
            ((System.ComponentModel.ISupportInitialize)(this.dsMaquina_rodando)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MAQUINA_RODANDO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRotas_campo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ROTAS_CAMPO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHoras_semana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HORAS_SEMANA)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_os
            // 
            this.tb_os.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRotas_campo, "ROTAS_CAMPO.OP_ROTA", true));
            this.tb_os.Location = new System.Drawing.Point(167, 99);
            this.tb_os.Name = "tb_os";
            this.tb_os.ReadOnly = true;
            this.tb_os.Size = new System.Drawing.Size(75, 20);
            this.tb_os.TabIndex = 187;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 186;
            this.label7.Text = "OS Sistema:";
            // 
            // tb_operador
            // 
            this.tb_operador.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMaquina_rodando, "MAQUINA_RODANDO.OPERADOR_MAQUINA_RODANDO", true));
            this.tb_operador.Location = new System.Drawing.Point(167, 123);
            this.tb_operador.Name = "tb_operador";
            this.tb_operador.ReadOnly = true;
            this.tb_operador.Size = new System.Drawing.Size(75, 20);
            this.tb_operador.TabIndex = 185;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 184;
            this.label6.Text = "Operador:";
            // 
            // bt_horas
            // 
            this.bt_horas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_horas.Location = new System.Drawing.Point(50, 232);
            this.bt_horas.Name = "bt_horas";
            this.bt_horas.Size = new System.Drawing.Size(177, 40);
            this.bt_horas.TabIndex = 178;
            this.bt_horas.Text = "Registrar Inserção";
            this.bt_horas.UseVisualStyleBackColor = true;
            this.bt_horas.Click += new System.EventHandler(this.bt_horas_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label20.Location = new System.Drawing.Point(26, 20);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(236, 27);
            this.label20.TabIndex = 183;
            this.label20.Text = "Inserção de Horas Manual";
            this.label20.UseCompatibleTextRendering = true;
            // 
            // tb_data
            // 
            this.tb_data.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMaquina_rodando, "MAQUINA_RODANDO.DATA_MAQUINA_TRABALHANDO", true));
            this.tb_data.Location = new System.Drawing.Point(167, 201);
            this.tb_data.Name = "tb_data";
            this.tb_data.Size = new System.Drawing.Size(75, 20);
            this.tb_data.TabIndex = 176;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 180;
            this.label5.Text = "Data do Trabalho:";
            // 
            // tb_horas
            // 
            this.tb_horas.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMaquina_rodando, "MAQUINA_RODANDO.HORAS_TRABALHADAS_MAQUINA", true));
            this.tb_horas.Location = new System.Drawing.Point(167, 175);
            this.tb_horas.Name = "tb_horas";
            this.tb_horas.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tb_horas.Size = new System.Drawing.Size(75, 20);
            this.tb_horas.TabIndex = 174;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 179;
            this.label4.Text = "Horas Trabalhadas:";
            // 
            // tb_rota
            // 
            this.tb_rota.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMaquina_rodando, "MAQUINA_RODANDO.ROTA_MAQUINA_RODANDO", true));
            this.tb_rota.Location = new System.Drawing.Point(167, 75);
            this.tb_rota.Name = "tb_rota";
            this.tb_rota.ReadOnly = true;
            this.tb_rota.Size = new System.Drawing.Size(75, 20);
            this.tb_rota.TabIndex = 181;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 177;
            this.label3.Text = "Rota:";
            // 
            // tb_maquina_nova
            // 
            this.tb_maquina_nova.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMaquina_rodando, "MAQUINA_RODANDO.MAQUINA_ATUAL", true));
            this.tb_maquina_nova.Location = new System.Drawing.Point(167, 149);
            this.tb_maquina_nova.Name = "tb_maquina_nova";
            this.tb_maquina_nova.Size = new System.Drawing.Size(75, 20);
            this.tb_maquina_nova.TabIndex = 173;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 175;
            this.label2.Text = "Máquina:";
            // 
            // tb_cod
            // 
            this.tb_cod.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMaquina_rodando, "MAQUINA_RODANDO.COD_MAQUINA_RODANDO", true));
            this.tb_cod.Location = new System.Drawing.Point(167, 50);
            this.tb_cod.Name = "tb_cod";
            this.tb_cod.ReadOnly = true;
            this.tb_cod.Size = new System.Drawing.Size(75, 20);
            this.tb_cod.TabIndex = 182;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 172;
            this.label1.Text = "Codigo Inserção Manual:";
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
            this.COD_MAQUINA_RODANDO.AutoIncrement = true;
            this.COD_MAQUINA_RODANDO.AutoIncrementSeed = ((long)(1));
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
            // cbMaquina_rodando
            // 
            this.cbMaquina_rodando.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbMaquina_rodando.DataAdapter = this.datMaquina_rodando;
            this.cbMaquina_rodando.QuotePrefix = "\"";
            this.cbMaquina_rodando.QuoteSuffix = "\"";
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
            // datHoras_semana
            // 
            this.datHoras_semana.DeleteCommand = this.fbCommand12;
            this.datHoras_semana.InsertCommand = this.fbCommand10;
            this.datHoras_semana.SelectCommand = this.fbCommand9;
            this.datHoras_semana.UpdateCommand = this.fbCommand11;
            // 
            // fbCommand9
            // 
            this.fbCommand9.CommandText = "select * from horas_semana";
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
            // form_horas_manuais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 304);
            this.Controls.Add(this.tb_os);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_operador);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bt_horas);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.tb_data);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_horas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_rota);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_maquina_nova);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_cod);
            this.Controls.Add(this.label1);
            this.Name = "form_horas_manuais";
            this.Text = "Horas Manuais";
            this.Load += new System.EventHandler(this.form_horas_manuais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsMaquina_rodando)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MAQUINA_RODANDO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRotas_campo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ROTAS_CAMPO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHoras_semana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HORAS_SEMANA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_os;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_operador;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bt_horas;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tb_data;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_horas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_rota;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_maquina_nova;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_cod;
        private System.Windows.Forms.Label label1;
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
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbMaquina_rodando;
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
        private System.Data.DataColumn SERVICO_EXTERNO_ROTA;
        private System.Data.DataColumn FORNECEDOR_SERVICO_EXTERNO;
        private System.Data.DataColumn ULTIMO_OPERADOR;
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
    }
}