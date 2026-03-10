namespace Evolucao
{
    partial class form_servicos_externos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_servicos_externos));
            this.label20 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_cod = new System.Windows.Forms.TextBox();
            this.dsForn = new System.Data.DataSet();
            this.FORNECEDORES = new System.Data.DataTable();
            this.COD_FORN = new System.Data.DataColumn();
            this.NOME_FORN = new System.Data.DataColumn();
            this.TEL_FORN = new System.Data.DataColumn();
            this.tb_nome_forn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.HORAS_MAQUINA_RODANDO = new System.Data.DataColumn();
            this.SERVICO_EXTERNO_ROTA = new System.Data.DataColumn();
            this.FORNECEDOR_SERVICO_EXTERNO = new System.Data.DataColumn();
            this.apaga_registro = new System.Windows.Forms.Button();
            this.salva_registro = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.novo_registro = new System.Windows.Forms.Button();
            this.datForn = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand8 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand6 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand5 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand7 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommandBuilder1 = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cODROTACAMPODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODNUMROTASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODROTAPECADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oBSERVACAOCAMPODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESENHOCAMPODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.dsForn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FORNECEDORES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRotas_campo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ROTAS_CAMPO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label20.Location = new System.Drawing.Point(138, 9);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(359, 46);
            this.label20.TabIndex = 49;
            this.label20.Text = "FORNECEDORES";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Cód.";
            // 
            // tb_cod
            // 
            this.tb_cod.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsForn, "FORNECEDORES.COD_FORN", true));
            this.tb_cod.Location = new System.Drawing.Point(64, 58);
            this.tb_cod.Name = "tb_cod";
            this.tb_cod.Size = new System.Drawing.Size(56, 20);
            this.tb_cod.TabIndex = 51;
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
            // tb_nome_forn
            // 
            this.tb_nome_forn.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsForn, "FORNECEDORES.NOME_FORN", true));
            this.tb_nome_forn.Location = new System.Drawing.Point(213, 58);
            this.tb_nome_forn.Name = "tb_nome_forn";
            this.tb_nome_forn.Size = new System.Drawing.Size(204, 20);
            this.tb_nome_forn.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Fornecedor:";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsForn, "FORNECEDORES.TEL_FORN", true));
            this.textBox3.Location = new System.Drawing.Point(463, 58);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(110, 20);
            this.textBox3.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(432, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "Tel:";
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
            this.FORNECEDOR_SERVICO_EXTERNO});
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
            // apaga_registro
            // 
            this.apaga_registro.Location = new System.Drawing.Point(306, 84);
            this.apaga_registro.Name = "apaga_registro";
            this.apaga_registro.Size = new System.Drawing.Size(49, 22);
            this.apaga_registro.TabIndex = 60;
            this.apaga_registro.Text = "Excluir";
            this.apaga_registro.UseVisualStyleBackColor = true;
            this.apaga_registro.Click += new System.EventHandler(this.apaga_registro_Click);
            // 
            // salva_registro
            // 
            this.salva_registro.Location = new System.Drawing.Point(361, 84);
            this.salva_registro.Name = "salva_registro";
            this.salva_registro.Size = new System.Drawing.Size(49, 22);
            this.salva_registro.TabIndex = 59;
            this.salva_registro.Text = "Salvar";
            this.salva_registro.UseVisualStyleBackColor = true;
            this.salva_registro.Click += new System.EventHandler(this.salva_registro_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(185, 84);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 22);
            this.button3.TabIndex = 62;
            this.button3.Text = "Localizar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // novo_registro
            // 
            this.novo_registro.Location = new System.Drawing.Point(251, 84);
            this.novo_registro.Name = "novo_registro";
            this.novo_registro.Size = new System.Drawing.Size(49, 22);
            this.novo_registro.TabIndex = 61;
            this.novo_registro.Text = "Novo";
            this.novo_registro.UseVisualStyleBackColor = true;
            this.novo_registro.Click += new System.EventHandler(this.novo_registro_Click);
            // 
            // datForn
            // 
            this.datForn.DeleteCommand = this.fbCommand8;
            this.datForn.InsertCommand = this.fbCommand6;
            this.datForn.SelectCommand = this.fbCommand5;
            this.datForn.UpdateCommand = this.fbCommand7;
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
            this.fbCommand5.CommandText = "select * from fornecedores order by nome_forn";
            this.fbCommand5.CommandTimeout = 30;
            this.fbCommand5.Connection = this.fbConnection1;
            // 
            // fbCommand7
            // 
            this.fbCommand7.CommandTimeout = 30;
            // 
            // fbCommandBuilder1
            // 
            this.fbCommandBuilder1.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.fbCommandBuilder1.DataAdapter = this.datForn;
            this.fbCommandBuilder1.QuotePrefix = "\"";
            this.fbCommandBuilder1.QuoteSuffix = "\"";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 63;
            this.label4.Text = "Serviços";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODROTACAMPODataGridViewTextBoxColumn,
            this.cODNUMROTASDataGridViewTextBoxColumn,
            this.cODROTAPECADataGridViewTextBoxColumn,
            this.oBSERVACAOCAMPODataGridViewTextBoxColumn,
            this.dESENHOCAMPODataGridViewTextBoxColumn,
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
            this.fORNECEDORSERVICOEXTERNODataGridViewTextBoxColumn});
            this.dataGridView1.DataMember = "ROTAS_CAMPO";
            this.dataGridView1.DataSource = this.dsRotas_campo;
            this.dataGridView1.Location = new System.Drawing.Point(16, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(623, 222);
            this.dataGridView1.TabIndex = 64;
            // 
            // cODROTACAMPODataGridViewTextBoxColumn
            // 
            this.cODROTACAMPODataGridViewTextBoxColumn.DataPropertyName = "COD_ROTA_CAMPO";
            this.cODROTACAMPODataGridViewTextBoxColumn.HeaderText = "Cód.";
            this.cODROTACAMPODataGridViewTextBoxColumn.Name = "cODROTACAMPODataGridViewTextBoxColumn";
            this.cODROTACAMPODataGridViewTextBoxColumn.Width = 50;
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
            // oBSERVACAOCAMPODataGridViewTextBoxColumn
            // 
            this.oBSERVACAOCAMPODataGridViewTextBoxColumn.DataPropertyName = "OBSERVACAO_CAMPO";
            this.oBSERVACAOCAMPODataGridViewTextBoxColumn.HeaderText = "OBSERVACAO_CAMPO";
            this.oBSERVACAOCAMPODataGridViewTextBoxColumn.Name = "oBSERVACAOCAMPODataGridViewTextBoxColumn";
            this.oBSERVACAOCAMPODataGridViewTextBoxColumn.Visible = false;
            // 
            // dESENHOCAMPODataGridViewTextBoxColumn
            // 
            this.dESENHOCAMPODataGridViewTextBoxColumn.DataPropertyName = "DESENHO_CAMPO";
            this.dESENHOCAMPODataGridViewTextBoxColumn.HeaderText = "OS";
            this.dESENHOCAMPODataGridViewTextBoxColumn.Name = "dESENHOCAMPODataGridViewTextBoxColumn";
            // 
            // pOSICAOFILACAMPODataGridViewTextBoxColumn
            // 
            this.pOSICAOFILACAMPODataGridViewTextBoxColumn.DataPropertyName = "POSICAO_FILA_CAMPO";
            this.pOSICAOFILACAMPODataGridViewTextBoxColumn.HeaderText = "Pos";
            this.pOSICAOFILACAMPODataGridViewTextBoxColumn.Name = "pOSICAOFILACAMPODataGridViewTextBoxColumn";
            this.pOSICAOFILACAMPODataGridViewTextBoxColumn.Visible = false;
            this.pOSICAOFILACAMPODataGridViewTextBoxColumn.Width = 50;
            // 
            // hORAENTRADADataGridViewTextBoxColumn
            // 
            this.hORAENTRADADataGridViewTextBoxColumn.DataPropertyName = "HORA_ENTRADA";
            this.hORAENTRADADataGridViewTextBoxColumn.HeaderText = "Hora Ent";
            this.hORAENTRADADataGridViewTextBoxColumn.Name = "hORAENTRADADataGridViewTextBoxColumn";
            this.hORAENTRADADataGridViewTextBoxColumn.Width = 70;
            // 
            // dATAENTRADADataGridViewTextBoxColumn
            // 
            this.dATAENTRADADataGridViewTextBoxColumn.DataPropertyName = "DATA_ENTRADA";
            this.dATAENTRADADataGridViewTextBoxColumn.HeaderText = "Data Entrada";
            this.dATAENTRADADataGridViewTextBoxColumn.Name = "dATAENTRADADataGridViewTextBoxColumn";
            this.dATAENTRADADataGridViewTextBoxColumn.Width = 70;
            // 
            // hORAFECHAMENTODataGridViewTextBoxColumn
            // 
            this.hORAFECHAMENTODataGridViewTextBoxColumn.DataPropertyName = "HORA_FECHAMENTO";
            this.hORAFECHAMENTODataGridViewTextBoxColumn.HeaderText = "Hora Fech";
            this.hORAFECHAMENTODataGridViewTextBoxColumn.Name = "hORAFECHAMENTODataGridViewTextBoxColumn";
            this.hORAFECHAMENTODataGridViewTextBoxColumn.Width = 70;
            // 
            // dATAFECHAMENTODataGridViewTextBoxColumn
            // 
            this.dATAFECHAMENTODataGridViewTextBoxColumn.DataPropertyName = "DATA_FECHAMENTO";
            this.dATAFECHAMENTODataGridViewTextBoxColumn.HeaderText = "Data Fech";
            this.dATAFECHAMENTODataGridViewTextBoxColumn.Name = "dATAFECHAMENTODataGridViewTextBoxColumn";
            this.dATAFECHAMENTODataGridViewTextBoxColumn.Width = 70;
            // 
            // pOSICAOATUALDataGridViewTextBoxColumn
            // 
            this.pOSICAOATUALDataGridViewTextBoxColumn.DataPropertyName = "POSICAO_ATUAL";
            this.pOSICAOATUALDataGridViewTextBoxColumn.HeaderText = "Posição";
            this.pOSICAOATUALDataGridViewTextBoxColumn.Name = "pOSICAOATUALDataGridViewTextBoxColumn";
            // 
            // pREVISAOPRODUCAODataGridViewTextBoxColumn
            // 
            this.pREVISAOPRODUCAODataGridViewTextBoxColumn.DataPropertyName = "PREVISAO_PRODUCAO";
            this.pREVISAOPRODUCAODataGridViewTextBoxColumn.HeaderText = "Previsão Horas";
            this.pREVISAOPRODUCAODataGridViewTextBoxColumn.Name = "pREVISAOPRODUCAODataGridViewTextBoxColumn";
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
            // 
            // nPDFCAMPODataGridViewTextBoxColumn
            // 
            this.nPDFCAMPODataGridViewTextBoxColumn.DataPropertyName = "N_PDF_CAMPO";
            this.nPDFCAMPODataGridViewTextBoxColumn.HeaderText = "Pos";
            this.nPDFCAMPODataGridViewTextBoxColumn.Name = "nPDFCAMPODataGridViewTextBoxColumn";
            this.nPDFCAMPODataGridViewTextBoxColumn.Width = 50;
            // 
            // mAQUINADataGridViewTextBoxColumn
            // 
            this.mAQUINADataGridViewTextBoxColumn.DataPropertyName = "MAQUINA";
            this.mAQUINADataGridViewTextBoxColumn.HeaderText = "MAQUINA";
            this.mAQUINADataGridViewTextBoxColumn.Name = "mAQUINADataGridViewTextBoxColumn";
            this.mAQUINADataGridViewTextBoxColumn.Visible = false;
            // 
            // dATAENTRADAPREVDataGridViewTextBoxColumn
            // 
            this.dATAENTRADAPREVDataGridViewTextBoxColumn.DataPropertyName = "DATA_ENTRADA_PREV";
            this.dATAENTRADAPREVDataGridViewTextBoxColumn.HeaderText = "Data Entrada Prev";
            this.dATAENTRADAPREVDataGridViewTextBoxColumn.Name = "dATAENTRADAPREVDataGridViewTextBoxColumn";
            // 
            // dATAFECHAMENTOPREVDataGridViewTextBoxColumn
            // 
            this.dATAFECHAMENTOPREVDataGridViewTextBoxColumn.DataPropertyName = "DATA_FECHAMENTO_PREV";
            this.dATAFECHAMENTOPREVDataGridViewTextBoxColumn.HeaderText = "Data Fecha Prev";
            this.dATAFECHAMENTOPREVDataGridViewTextBoxColumn.Name = "dATAFECHAMENTOPREVDataGridViewTextBoxColumn";
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
            // hORASMAQUINARODANDODataGridViewTextBoxColumn
            // 
            this.hORASMAQUINARODANDODataGridViewTextBoxColumn.DataPropertyName = "HORAS_MAQUINA_RODANDO";
            this.hORASMAQUINARODANDODataGridViewTextBoxColumn.HeaderText = "HORAS_MAQUINA_RODANDO";
            this.hORASMAQUINARODANDODataGridViewTextBoxColumn.Name = "hORASMAQUINARODANDODataGridViewTextBoxColumn";
            this.hORASMAQUINARODANDODataGridViewTextBoxColumn.Visible = false;
            // 
            // sERVICOEXTERNOROTADataGridViewTextBoxColumn
            // 
            this.sERVICOEXTERNOROTADataGridViewTextBoxColumn.DataPropertyName = "SERVICO_EXTERNO_ROTA";
            this.sERVICOEXTERNOROTADataGridViewTextBoxColumn.HeaderText = "SERVICO_EXTERNO_ROTA";
            this.sERVICOEXTERNOROTADataGridViewTextBoxColumn.Name = "sERVICOEXTERNOROTADataGridViewTextBoxColumn";
            this.sERVICOEXTERNOROTADataGridViewTextBoxColumn.Visible = false;
            // 
            // fORNECEDORSERVICOEXTERNODataGridViewTextBoxColumn
            // 
            this.fORNECEDORSERVICOEXTERNODataGridViewTextBoxColumn.DataPropertyName = "FORNECEDOR_SERVICO_EXTERNO";
            this.fORNECEDORSERVICOEXTERNODataGridViewTextBoxColumn.HeaderText = "FORNECEDOR_SERVICO_EXTERNO";
            this.fORNECEDORSERVICOEXTERNODataGridViewTextBoxColumn.Name = "fORNECEDORSERVICOEXTERNODataGridViewTextBoxColumn";
            this.fORNECEDORSERVICOEXTERNODataGridViewTextBoxColumn.Visible = false;
            // 
            // form_fornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 383);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.apaga_registro);
            this.Controls.Add(this.salva_registro);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.novo_registro);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_nome_forn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_cod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label20);
            this.Name = "form_fornecedores";
            this.Text = "form_servicos_externos";
            this.Load += new System.EventHandler(this.form_fornecedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsForn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FORNECEDORES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRotas_campo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ROTAS_CAMPO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_cod;
        private System.Windows.Forms.TextBox tb_nome_forn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
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
        private System.Data.DataColumn HORAS_MAQUINA_RODANDO;
        private System.Data.DataColumn SERVICO_EXTERNO_ROTA;
        private System.Data.DataColumn FORNECEDOR_SERVICO_EXTERNO;
        private System.Windows.Forms.Button apaga_registro;
        private System.Windows.Forms.Button salva_registro;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button novo_registro;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datForn;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand8;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand6;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand5;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand7;
        private System.Data.DataSet dsForn;
        private System.Data.DataTable FORNECEDORES;
        private System.Data.DataColumn COD_FORN;
        private System.Data.DataColumn NOME_FORN;
        private System.Data.DataColumn TEL_FORN;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder fbCommandBuilder1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODROTACAMPODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODNUMROTASDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODROTAPECADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oBSERVACAOCAMPODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESENHOCAMPODataGridViewTextBoxColumn;
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
    }
}