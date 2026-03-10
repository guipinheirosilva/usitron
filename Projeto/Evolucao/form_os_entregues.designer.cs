namespace Evolucao
{
    partial class form_os_entregues
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_os_entregues));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtTermino = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.datOp = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsOp = new System.Data.DataSet();
            this.OP = new System.Data.DataTable();
            this.COD_OP = new System.Data.DataColumn();
            this.DATA_PDF = new System.Data.DataColumn();
            this.ENTREGA_DIA = new System.Data.DataColumn();
            this.ENTREGOU_DIA = new System.Data.DataColumn();
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
            this.ESPESSURA_OP = new System.Data.DataColumn();
            this.FUNCAO_OP = new System.Data.DataColumn();
            this.FERRAMENTA_OP = new System.Data.DataColumn();
            this.CLIENTE_OP = new System.Data.DataColumn();
            this.FINALIZADO_OP = new System.Data.DataColumn();
            this.POSICAO_ATUAL_OP = new System.Data.DataColumn();
            this.REVISAO_OP = new System.Data.DataColumn();
            this.TRAT_TERMICO_OP = new System.Data.DataColumn();
            this.MATERIAL_FORN_OP = new System.Data.DataColumn();
            this.NF_MATERIAL_OP = new System.Data.DataColumn();
            this.DUREZA_SOLIC_OP = new System.Data.DataColumn();
            this.DUREZA_ENC_OP = new System.Data.DataColumn();
            this.NF_SAIDA_OP = new System.Data.DataColumn();
            this.DATA_NF_SAIDA = new System.Data.DataColumn();
            this.PROCESSO_OP = new System.Data.DataColumn();
            this.CODIGO_OP = new System.Data.DataColumn();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataColumn7 = new System.Data.DataColumn();
            this.dataColumn8 = new System.Data.DataColumn();
            this.dgvOp = new System.Windows.Forms.DataGridView();
            this.tb_os = new System.Windows.Forms.TextBox();
            this.tb_ferramenta = new System.Windows.Forms.TextBox();
            this.tb_item = new System.Windows.Forms.TextBox();
            this.comando_select = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.tb_posicao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cb_finalizadas = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCliente = new System.Windows.Forms.Button();
            this.cb_faturado_01 = new System.Windows.Forms.CheckBox();
            this.data_entrada_previstaradioButton = new System.Windows.Forms.RadioButton();
            this.naoentreguesCheckbox = new System.Windows.Forms.CheckBox();
            this.data_entradaradioButton = new System.Windows.Forms.RadioButton();
            this.data_saidaradioButton = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
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
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.cbUrgente = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLote = new System.Windows.Forms.TextBox();
            this.tb_tipo = new System.Windows.Forms.TextBox();
            this.nf_tb = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.btnProducao = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbSimulacao_nota = new System.Windows.Forms.CheckBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNTREGADIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNTREGOUDIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_fin = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.URGENTE_OP = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.col_os = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cod_op = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OP_MAE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_pedido_op = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nPDFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR_TOTAL_PROD_ITEM_VENDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONDPGTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fERRAMENTAOPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qDEPDFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qDEFABDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_pos_atual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODIGOOPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N_ITEM_PEDIDO_OP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nFSAIDAOPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATANFSAIDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAPDFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pESOTOTALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pDFACEITOEMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nFNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qDEESTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qDEEMBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qDECAIXASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mATERIALOPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSPESSURAOPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fUNCAOOPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEVISAOOPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tRATTERMICOOPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mATERIALFORNOPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nFMATERIALOPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dUREZASOLICOPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dUREZAENCOPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROCESSOOPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsOp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOp)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsRotas_campo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ROTAS_CAMPO)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(619, 4);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 110);
            this.button2.TabIndex = 17;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dtTermino);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtInicio);
            this.groupBox2.Location = new System.Drawing.Point(21, 25);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(224, 89);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Intervalos de Datas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Término";
            // 
            // dtTermino
            // 
            this.dtTermino.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTermino.Location = new System.Drawing.Point(76, 53);
            this.dtTermino.Margin = new System.Windows.Forms.Padding(4);
            this.dtTermino.Name = "dtTermino";
            this.dtTermino.Size = new System.Drawing.Size(125, 22);
            this.dtTermino.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inicio";
            // 
            // dtInicio
            // 
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicio.Location = new System.Drawing.Point(76, 23);
            this.dtInicio.Margin = new System.Windows.Forms.Padding(4);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(125, 22);
            this.dtInicio.TabIndex = 0;
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
            this.fbCommand1.CommandText = "select * from op";
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
            this.ESPESSURA_OP,
            this.FUNCAO_OP,
            this.FERRAMENTA_OP,
            this.CLIENTE_OP,
            this.FINALIZADO_OP,
            this.POSICAO_ATUAL_OP,
            this.REVISAO_OP,
            this.TRAT_TERMICO_OP,
            this.MATERIAL_FORN_OP,
            this.NF_MATERIAL_OP,
            this.DUREZA_SOLIC_OP,
            this.DUREZA_ENC_OP,
            this.NF_SAIDA_OP,
            this.DATA_NF_SAIDA,
            this.PROCESSO_OP,
            this.CODIGO_OP,
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn6,
            this.dataColumn7,
            this.dataColumn8});
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
            // COND_PGTO
            // 
            this.COND_PGTO.ColumnName = "COND_PGTO";
            this.COND_PGTO.MaxLength = 50;
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
            // ESPESSURA_OP
            // 
            this.ESPESSURA_OP.ColumnName = "ESPESSURA_OP";
            this.ESPESSURA_OP.MaxLength = 30;
            // 
            // FUNCAO_OP
            // 
            this.FUNCAO_OP.ColumnName = "FUNCAO_OP";
            this.FUNCAO_OP.MaxLength = 50;
            // 
            // FERRAMENTA_OP
            // 
            this.FERRAMENTA_OP.ColumnName = "FERRAMENTA_OP";
            this.FERRAMENTA_OP.MaxLength = 200;
            // 
            // CLIENTE_OP
            // 
            this.CLIENTE_OP.ColumnName = "CLIENTE_OP";
            this.CLIENTE_OP.MaxLength = 3;
            // 
            // FINALIZADO_OP
            // 
            this.FINALIZADO_OP.ColumnName = "FINALIZADO_OP";
            this.FINALIZADO_OP.DataType = typeof(int);
            // 
            // POSICAO_ATUAL_OP
            // 
            this.POSICAO_ATUAL_OP.ColumnName = "POSICAO_ATUAL_OP";
            this.POSICAO_ATUAL_OP.MaxLength = 100;
            // 
            // REVISAO_OP
            // 
            this.REVISAO_OP.ColumnName = "REVISAO_OP";
            this.REVISAO_OP.MaxLength = 30;
            // 
            // TRAT_TERMICO_OP
            // 
            this.TRAT_TERMICO_OP.ColumnName = "TRAT_TERMICO_OP";
            this.TRAT_TERMICO_OP.MaxLength = 50;
            // 
            // MATERIAL_FORN_OP
            // 
            this.MATERIAL_FORN_OP.ColumnName = "MATERIAL_FORN_OP";
            this.MATERIAL_FORN_OP.MaxLength = 100;
            // 
            // NF_MATERIAL_OP
            // 
            this.NF_MATERIAL_OP.ColumnName = "NF_MATERIAL_OP";
            this.NF_MATERIAL_OP.MaxLength = 100;
            // 
            // DUREZA_SOLIC_OP
            // 
            this.DUREZA_SOLIC_OP.ColumnName = "DUREZA_SOLIC_OP";
            this.DUREZA_SOLIC_OP.MaxLength = 30;
            // 
            // DUREZA_ENC_OP
            // 
            this.DUREZA_ENC_OP.ColumnName = "DUREZA_ENC_OP";
            this.DUREZA_ENC_OP.MaxLength = 30;
            // 
            // NF_SAIDA_OP
            // 
            this.NF_SAIDA_OP.ColumnName = "NF_SAIDA_OP";
            this.NF_SAIDA_OP.DataType = typeof(int);
            // 
            // DATA_NF_SAIDA
            // 
            this.DATA_NF_SAIDA.ColumnName = "DATA_NF_SAIDA";
            this.DATA_NF_SAIDA.DataType = typeof(System.DateTime);
            // 
            // PROCESSO_OP
            // 
            this.PROCESSO_OP.ColumnName = "PROCESSO_OP";
            this.PROCESSO_OP.MaxLength = 50;
            // 
            // CODIGO_OP
            // 
            this.CODIGO_OP.ColumnName = "CODIGO_OP";
            this.CODIGO_OP.MaxLength = 20;
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "DATA_ENTRADA_OP";
            this.dataColumn1.DataType = typeof(System.DateTime);
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "PEDIDO_OP";
            this.dataColumn2.MaxLength = 50;
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "N_ITEM_PEDIDO_OP";
            this.dataColumn3.MaxLength = 50;
            // 
            // dataColumn4
            // 
            this.dataColumn4.Caption = "URGENTE_OP";
            this.dataColumn4.ColumnName = "URGENTE_OP";
            this.dataColumn4.DataType = typeof(int);
            // 
            // dataColumn5
            // 
            this.dataColumn5.Caption = "CLIENTE";
            this.dataColumn5.ColumnName = "CLIENTE";
            this.dataColumn5.MaxLength = 500;
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "PRECO_UNIT";
            this.dataColumn6.DataType = typeof(double);
            // 
            // dataColumn7
            // 
            this.dataColumn7.ColumnName = "OP_MAE";
            this.dataColumn7.DataType = typeof(int);
            // 
            // dataColumn8
            // 
            this.dataColumn8.ColumnName = "VALOR_TOTAL_PROD_ITEM_VENDA";
            this.dataColumn8.DataType = typeof(double);
            // 
            // dgvOp
            // 
            this.dgvOp.AllowUserToAddRows = false;
            this.dgvOp.AllowUserToDeleteRows = false;
            this.dgvOp.AutoGenerateColumns = false;
            this.dgvOp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.eNTREGADIADataGridViewTextBoxColumn,
            this.eNTREGOUDIADataGridViewTextBoxColumn,
            this.col_fin,
            this.URGENTE_OP,
            this.col_os,
            this.col_cod_op,
            this.OP_MAE,
            this.col_pedido_op,
            this.nPDFDataGridViewTextBoxColumn,
            this.VALOR_TOTAL_PROD_ITEM_VENDA,
            this.cONDPGTODataGridViewTextBoxColumn,
            this.fERRAMENTAOPDataGridViewTextBoxColumn,
            this.qDEPDFDataGridViewTextBoxColumn,
            this.qDEFABDataGridViewTextBoxColumn,
            this.col_pos_atual,
            this.cODIGOOPDataGridViewTextBoxColumn,
            this.N_ITEM_PEDIDO_OP,
            this.nFSAIDAOPDataGridViewTextBoxColumn,
            this.dATANFSAIDADataGridViewTextBoxColumn,
            this.dATAPDFDataGridViewTextBoxColumn,
            this.pESOTOTALDataGridViewTextBoxColumn,
            this.pDFACEITOEMDataGridViewTextBoxColumn,
            this.nFNDataGridViewTextBoxColumn,
            this.qDEESTDataGridViewTextBoxColumn,
            this.qDEEMBDataGridViewTextBoxColumn,
            this.qDECAIXASDataGridViewTextBoxColumn,
            this.mATERIALOPDataGridViewTextBoxColumn,
            this.eSPESSURAOPDataGridViewTextBoxColumn,
            this.fUNCAOOPDataGridViewTextBoxColumn,
            this.rEVISAOOPDataGridViewTextBoxColumn,
            this.tRATTERMICOOPDataGridViewTextBoxColumn,
            this.mATERIALFORNOPDataGridViewTextBoxColumn,
            this.nFMATERIALOPDataGridViewTextBoxColumn,
            this.dUREZASOLICOPDataGridViewTextBoxColumn,
            this.dUREZAENCOPDataGridViewTextBoxColumn,
            this.pROCESSOOPDataGridViewTextBoxColumn});
            this.dgvOp.DataMember = "OP";
            this.dgvOp.DataSource = this.dsOp;
            this.dgvOp.Location = new System.Drawing.Point(16, 162);
            this.dgvOp.Margin = new System.Windows.Forms.Padding(4);
            this.dgvOp.Name = "dgvOp";
            this.dgvOp.ReadOnly = true;
            this.dgvOp.Size = new System.Drawing.Size(1441, 546);
            this.dgvOp.TabIndex = 18;
            this.dgvOp.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOp_CellDoubleClick);
            // 
            // tb_os
            // 
            this.tb_os.Location = new System.Drawing.Point(79, 11);
            this.tb_os.Margin = new System.Windows.Forms.Padding(4);
            this.tb_os.Name = "tb_os";
            this.tb_os.Size = new System.Drawing.Size(69, 22);
            this.tb_os.TabIndex = 20;
            this.tb_os.TextChanged += new System.EventHandler(this.tb_os_TextChanged);
            // 
            // tb_ferramenta
            // 
            this.tb_ferramenta.Location = new System.Drawing.Point(771, 7);
            this.tb_ferramenta.Margin = new System.Windows.Forms.Padding(4);
            this.tb_ferramenta.Name = "tb_ferramenta";
            this.tb_ferramenta.Size = new System.Drawing.Size(315, 22);
            this.tb_ferramenta.TabIndex = 21;
            this.tb_ferramenta.TextChanged += new System.EventHandler(this.tb_ferramenta_TextChanged);
            // 
            // tb_item
            // 
            this.tb_item.Location = new System.Drawing.Point(423, 7);
            this.tb_item.Margin = new System.Windows.Forms.Padding(4);
            this.tb_item.Name = "tb_item";
            this.tb_item.Size = new System.Drawing.Size(201, 22);
            this.tb_item.TabIndex = 22;
            this.tb_item.TextChanged += new System.EventHandler(this.tb_item_TextChanged);
            // 
            // comando_select
            // 
            this.comando_select.CommandTimeout = 30;
            this.comando_select.Connection = this.fbConnection1;
            // 
            // tb_posicao
            // 
            this.tb_posicao.Location = new System.Drawing.Point(1185, 9);
            this.tb_posicao.Margin = new System.Windows.Forms.Padding(4);
            this.tb_posicao.Name = "tb_posicao";
            this.tb_posicao.Size = new System.Drawing.Size(199, 22);
            this.tb_posicao.TabIndex = 23;
            this.tb_posicao.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Cliente:";
            this.label3.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 80);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(236, 22);
            this.textBox1.TabIndex = 26;
            this.textBox1.Visible = false;
            this.textBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseDoubleClick);
            // 
            // cb_finalizadas
            // 
            this.cb_finalizadas.AutoSize = true;
            this.cb_finalizadas.Location = new System.Drawing.Point(15, 49);
            this.cb_finalizadas.Margin = new System.Windows.Forms.Padding(4);
            this.cb_finalizadas.Name = "cb_finalizadas";
            this.cb_finalizadas.Size = new System.Drawing.Size(153, 21);
            this.cb_finalizadas.TabIndex = 0;
            this.cb_finalizadas.Text = "Apenas Finalizadas";
            this.cb_finalizadas.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(1347, 9);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 59);
            this.button1.TabIndex = 25;
            this.button1.Text = "Faturamento 01 Item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.btnCliente);
            this.panel1.Controls.Add(this.cb_faturado_01);
            this.panel1.Controls.Add(this.data_entrada_previstaradioButton);
            this.panel1.Controls.Add(this.naoentreguesCheckbox);
            this.panel1.Controls.Add(this.data_entradaradioButton);
            this.panel1.Controls.Add(this.data_saidaradioButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cb_finalizadas);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(253, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 119);
            this.panel1.TabIndex = 27;
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(317, 78);
            this.btnCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(36, 28);
            this.btnCliente.TabIndex = 32;
            this.btnCliente.Text = "+";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Visible = false;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // cb_faturado_01
            // 
            this.cb_faturado_01.AutoSize = true;
            this.cb_faturado_01.Location = new System.Drawing.Point(212, 27);
            this.cb_faturado_01.Margin = new System.Windows.Forms.Padding(4);
            this.cb_faturado_01.Name = "cb_faturado_01";
            this.cb_faturado_01.Size = new System.Drawing.Size(107, 21);
            this.cb_faturado_01.TabIndex = 31;
            this.cb_faturado_01.Text = "Faturado 01";
            this.cb_faturado_01.UseVisualStyleBackColor = true;
            this.cb_faturado_01.Visible = false;
            // 
            // data_entrada_previstaradioButton
            // 
            this.data_entrada_previstaradioButton.AutoSize = true;
            this.data_entrada_previstaradioButton.Location = new System.Drawing.Point(15, 26);
            this.data_entrada_previstaradioButton.Margin = new System.Windows.Forms.Padding(4);
            this.data_entrada_previstaradioButton.Name = "data_entrada_previstaradioButton";
            this.data_entrada_previstaradioButton.Size = new System.Drawing.Size(168, 21);
            this.data_entrada_previstaradioButton.TabIndex = 30;
            this.data_entrada_previstaradioButton.TabStop = true;
            this.data_entrada_previstaradioButton.Text = "Data Entrega Prevista";
            this.data_entrada_previstaradioButton.UseVisualStyleBackColor = true;
            this.data_entrada_previstaradioButton.Visible = false;
            // 
            // naoentreguesCheckbox
            // 
            this.naoentreguesCheckbox.AutoSize = true;
            this.naoentreguesCheckbox.Location = new System.Drawing.Point(212, 49);
            this.naoentreguesCheckbox.Margin = new System.Windows.Forms.Padding(4);
            this.naoentreguesCheckbox.Name = "naoentreguesCheckbox";
            this.naoentreguesCheckbox.Size = new System.Drawing.Size(118, 21);
            this.naoentreguesCheckbox.TabIndex = 29;
            this.naoentreguesCheckbox.Text = "Não Entregue";
            this.naoentreguesCheckbox.UseVisualStyleBackColor = true;
            // 
            // data_entradaradioButton
            // 
            this.data_entradaradioButton.AutoSize = true;
            this.data_entradaradioButton.Location = new System.Drawing.Point(212, 5);
            this.data_entradaradioButton.Margin = new System.Windows.Forms.Padding(4);
            this.data_entradaradioButton.Name = "data_entradaradioButton";
            this.data_entradaradioButton.Size = new System.Drawing.Size(113, 21);
            this.data_entradaradioButton.TabIndex = 28;
            this.data_entradaradioButton.TabStop = true;
            this.data_entradaradioButton.Text = "Data Entrada";
            this.data_entradaradioButton.UseVisualStyleBackColor = true;
            // 
            // data_saidaradioButton
            // 
            this.data_saidaradioButton.AutoSize = true;
            this.data_saidaradioButton.Location = new System.Drawing.Point(15, 5);
            this.data_saidaradioButton.Margin = new System.Windows.Forms.Padding(4);
            this.data_saidaradioButton.Name = "data_saidaradioButton";
            this.data_saidaradioButton.Size = new System.Drawing.Size(134, 21);
            this.data_saidaradioButton.TabIndex = 0;
            this.data_saidaradioButton.TabStop = true;
            this.data_saidaradioButton.Text = "Data Finalização";
            this.data_saidaradioButton.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1540, 102);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(59, 21);
            this.button3.TabIndex = 28;
            this.button3.Text = "Atualizar Ops. NÃO CLICAR!!";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(769, 37);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 79);
            this.button4.TabIndex = 29;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
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
            this.fbCommand5.CommandText = "select * from Rotas_campo";
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
            this.CODIGO_OS_CAMPO});
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
            this.CODIGO_OS_CAMPO.MaxLength = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(765, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "Detalhamento";
            this.label4.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.cbUrgente);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtLote);
            this.panel2.Controls.Add(this.tb_tipo);
            this.panel2.Controls.Add(this.nf_tb);
            this.panel2.Controls.Add(this.tb_posicao);
            this.panel2.Controls.Add(this.tb_item);
            this.panel2.Controls.Add(this.tb_ferramenta);
            this.panel2.Controls.Add(this.tb_os);
            this.panel2.Location = new System.Drawing.Point(43, 123);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1415, 39);
            this.panel2.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(43, 16);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 17);
            this.label11.TabIndex = 41;
            this.label11.Text = "OS";
            // 
            // cbUrgente
            // 
            this.cbUrgente.AutoSize = true;
            this.cbUrgente.Location = new System.Drawing.Point(283, 10);
            this.cbUrgente.Margin = new System.Windows.Forms.Padding(4);
            this.cbUrgente.Name = "cbUrgente";
            this.cbUrgente.Size = new System.Drawing.Size(81, 21);
            this.cbUrgente.TabIndex = 33;
            this.cbUrgente.Text = "Urgente";
            this.cbUrgente.UseVisualStyleBackColor = true;
            this.cbUrgente.CheckedChanged += new System.EventHandler(this.cbUrgente_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1124, 12);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 17);
            this.label10.TabIndex = 40;
            this.label10.Text = "Status:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(685, 12);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 17);
            this.label9.TabIndex = 39;
            this.label9.Text = "Descrição:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(372, 11);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 17);
            this.label8.TabIndex = 38;
            this.label8.Text = "Cód. ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(156, 11);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 17);
            this.label7.TabIndex = 37;
            this.label7.Text = "OS";
            // 
            // txtLote
            // 
            this.txtLote.Location = new System.Drawing.Point(193, 7);
            this.txtLote.Margin = new System.Windows.Forms.Padding(4);
            this.txtLote.Name = "txtLote";
            this.txtLote.Size = new System.Drawing.Size(69, 22);
            this.txtLote.TabIndex = 36;
            this.txtLote.TextChanged += new System.EventHandler(this.txtLote_TextChanged);
            // 
            // tb_tipo
            // 
            this.tb_tipo.Location = new System.Drawing.Point(1360, 7);
            this.tb_tipo.Margin = new System.Windows.Forms.Padding(4);
            this.tb_tipo.Name = "tb_tipo";
            this.tb_tipo.Size = new System.Drawing.Size(49, 22);
            this.tb_tipo.TabIndex = 26;
            this.tb_tipo.Visible = false;
            this.tb_tipo.TextChanged += new System.EventHandler(this.tb_tipo_TextChanged);
            // 
            // nf_tb
            // 
            this.nf_tb.Location = new System.Drawing.Point(61, 7);
            this.nf_tb.Margin = new System.Windows.Forms.Padding(4);
            this.nf_tb.Name = "nf_tb";
            this.nf_tb.Size = new System.Drawing.Size(61, 22);
            this.nf_tb.TabIndex = 24;
            this.nf_tb.Visible = false;
            this.nf_tb.TextChanged += new System.EventHandler(this.nf_tb_TextChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1208, 9);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(131, 110);
            this.button5.TabIndex = 32;
            this.button5.Text = "Selecionar para Faturamento";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.Location = new System.Drawing.Point(1347, 75);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(111, 43);
            this.button6.TabIndex = 33;
            this.button6.Text = "Faturamento 01 OS";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(887, 16);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 35;
            this.label5.Text = "Resumo";
            // 
            // button7
            // 
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.Location = new System.Drawing.Point(875, 37);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(97, 79);
            this.button7.TabIndex = 34;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnProducao
            // 
            this.btnProducao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProducao.BackgroundImage")));
            this.btnProducao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProducao.Location = new System.Drawing.Point(980, 37);
            this.btnProducao.Margin = new System.Windows.Forms.Padding(4);
            this.btnProducao.Name = "btnProducao";
            this.btnProducao.Size = new System.Drawing.Size(97, 79);
            this.btnProducao.TabIndex = 36;
            this.btnProducao.UseVisualStyleBackColor = true;
            this.btnProducao.Visible = false;
            this.btnProducao.Click += new System.EventHandler(this.btnProducao_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(996, 17);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 37;
            this.label6.Text = "Produção";
            this.label6.Visible = false;
            // 
            // cbSimulacao_nota
            // 
            this.cbSimulacao_nota.AutoSize = true;
            this.cbSimulacao_nota.Location = new System.Drawing.Point(1096, 79);
            this.cbSimulacao_nota.Margin = new System.Windows.Forms.Padding(4);
            this.cbSimulacao_nota.Name = "cbSimulacao_nota";
            this.cbSimulacao_nota.Size = new System.Drawing.Size(99, 38);
            this.cbSimulacao_nota.TabIndex = 38;
            this.cbSimulacao_nota.Text = "Simulação \r\nNota";
            this.cbSimulacao_nota.UseVisualStyleBackColor = true;
            this.cbSimulacao_nota.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DATA_PDF";
            this.dataGridViewTextBoxColumn1.HeaderText = "Data OS";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // eNTREGADIADataGridViewTextBoxColumn
            // 
            this.eNTREGADIADataGridViewTextBoxColumn.DataPropertyName = "ENTREGA_DIA";
            this.eNTREGADIADataGridViewTextBoxColumn.HeaderText = "Data Entrega";
            this.eNTREGADIADataGridViewTextBoxColumn.Name = "eNTREGADIADataGridViewTextBoxColumn";
            this.eNTREGADIADataGridViewTextBoxColumn.ReadOnly = true;
            this.eNTREGADIADataGridViewTextBoxColumn.Width = 60;
            // 
            // eNTREGOUDIADataGridViewTextBoxColumn
            // 
            this.eNTREGOUDIADataGridViewTextBoxColumn.DataPropertyName = "ENTREGOU_DIA";
            this.eNTREGOUDIADataGridViewTextBoxColumn.HeaderText = "Data Finalização";
            this.eNTREGOUDIADataGridViewTextBoxColumn.Name = "eNTREGOUDIADataGridViewTextBoxColumn";
            this.eNTREGOUDIADataGridViewTextBoxColumn.ReadOnly = true;
            this.eNTREGOUDIADataGridViewTextBoxColumn.Width = 60;
            // 
            // col_fin
            // 
            this.col_fin.DataPropertyName = "FINALIZADO_OP";
            this.col_fin.FalseValue = "0";
            this.col_fin.HeaderText = "Final.";
            this.col_fin.IndeterminateValue = "0";
            this.col_fin.Name = "col_fin";
            this.col_fin.ReadOnly = true;
            this.col_fin.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_fin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_fin.TrueValue = "1";
            this.col_fin.Width = 50;
            // 
            // URGENTE_OP
            // 
            this.URGENTE_OP.DataPropertyName = "URGENTE_OP";
            this.URGENTE_OP.HeaderText = "Urg";
            this.URGENTE_OP.Name = "URGENTE_OP";
            this.URGENTE_OP.ReadOnly = true;
            this.URGENTE_OP.Width = 50;
            // 
            // col_os
            // 
            this.col_os.DataPropertyName = "DESENHO_OP_ATUAL";
            this.col_os.HeaderText = "OS";
            this.col_os.Name = "col_os";
            this.col_os.ReadOnly = true;
            this.col_os.Visible = false;
            this.col_os.Width = 50;
            // 
            // col_cod_op
            // 
            this.col_cod_op.DataPropertyName = "COD_OP";
            this.col_cod_op.HeaderText = "OS";
            this.col_cod_op.Name = "col_cod_op";
            this.col_cod_op.ReadOnly = true;
            this.col_cod_op.Width = 50;
            // 
            // OP_MAE
            // 
            this.OP_MAE.DataPropertyName = "OP_MAE";
            this.OP_MAE.HeaderText = "OP Mãe";
            this.OP_MAE.Name = "OP_MAE";
            this.OP_MAE.ReadOnly = true;
            this.OP_MAE.Visible = false;
            this.OP_MAE.Width = 50;
            // 
            // col_pedido_op
            // 
            this.col_pedido_op.DataPropertyName = "PEDIDO_OP";
            this.col_pedido_op.HeaderText = "Pedido";
            this.col_pedido_op.Name = "col_pedido_op";
            this.col_pedido_op.ReadOnly = true;
            this.col_pedido_op.Visible = false;
            this.col_pedido_op.Width = 70;
            // 
            // nPDFDataGridViewTextBoxColumn
            // 
            this.nPDFDataGridViewTextBoxColumn.DataPropertyName = "N_PDF";
            this.nPDFDataGridViewTextBoxColumn.HeaderText = "Pos.";
            this.nPDFDataGridViewTextBoxColumn.Name = "nPDFDataGridViewTextBoxColumn";
            this.nPDFDataGridViewTextBoxColumn.ReadOnly = true;
            this.nPDFDataGridViewTextBoxColumn.Visible = false;
            this.nPDFDataGridViewTextBoxColumn.Width = 40;
            // 
            // VALOR_TOTAL_PROD_ITEM_VENDA
            // 
            this.VALOR_TOTAL_PROD_ITEM_VENDA.DataPropertyName = "VALOR_TOTAL_PROD_ITEM_VENDA";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.VALOR_TOTAL_PROD_ITEM_VENDA.DefaultCellStyle = dataGridViewCellStyle2;
            this.VALOR_TOTAL_PROD_ITEM_VENDA.HeaderText = "Valor Total";
            this.VALOR_TOTAL_PROD_ITEM_VENDA.Name = "VALOR_TOTAL_PROD_ITEM_VENDA";
            this.VALOR_TOTAL_PROD_ITEM_VENDA.ReadOnly = true;
            this.VALOR_TOTAL_PROD_ITEM_VENDA.Width = 70;
            // 
            // cONDPGTODataGridViewTextBoxColumn
            // 
            this.cONDPGTODataGridViewTextBoxColumn.DataPropertyName = "COND_PGTO";
            this.cONDPGTODataGridViewTextBoxColumn.HeaderText = "Cód. Peça";
            this.cONDPGTODataGridViewTextBoxColumn.Name = "cONDPGTODataGridViewTextBoxColumn";
            this.cONDPGTODataGridViewTextBoxColumn.ReadOnly = true;
            this.cONDPGTODataGridViewTextBoxColumn.Width = 150;
            // 
            // fERRAMENTAOPDataGridViewTextBoxColumn
            // 
            this.fERRAMENTAOPDataGridViewTextBoxColumn.DataPropertyName = "FERRAMENTA_OP";
            this.fERRAMENTAOPDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.fERRAMENTAOPDataGridViewTextBoxColumn.Name = "fERRAMENTAOPDataGridViewTextBoxColumn";
            this.fERRAMENTAOPDataGridViewTextBoxColumn.ReadOnly = true;
            this.fERRAMENTAOPDataGridViewTextBoxColumn.Width = 250;
            // 
            // qDEPDFDataGridViewTextBoxColumn
            // 
            this.qDEPDFDataGridViewTextBoxColumn.DataPropertyName = "QDE_PDF";
            this.qDEPDFDataGridViewTextBoxColumn.HeaderText = "Qtde";
            this.qDEPDFDataGridViewTextBoxColumn.Name = "qDEPDFDataGridViewTextBoxColumn";
            this.qDEPDFDataGridViewTextBoxColumn.ReadOnly = true;
            this.qDEPDFDataGridViewTextBoxColumn.Visible = false;
            this.qDEPDFDataGridViewTextBoxColumn.Width = 50;
            // 
            // qDEFABDataGridViewTextBoxColumn
            // 
            this.qDEFABDataGridViewTextBoxColumn.DataPropertyName = "QDE_FAB";
            this.qDEFABDataGridViewTextBoxColumn.HeaderText = "Qtde";
            this.qDEFABDataGridViewTextBoxColumn.Name = "qDEFABDataGridViewTextBoxColumn";
            this.qDEFABDataGridViewTextBoxColumn.ReadOnly = true;
            this.qDEFABDataGridViewTextBoxColumn.Width = 70;
            // 
            // col_pos_atual
            // 
            this.col_pos_atual.DataPropertyName = "POSICAO_ATUAL_OP";
            this.col_pos_atual.HeaderText = "Status";
            this.col_pos_atual.Name = "col_pos_atual";
            this.col_pos_atual.ReadOnly = true;
            this.col_pos_atual.Width = 150;
            // 
            // cODIGOOPDataGridViewTextBoxColumn
            // 
            this.cODIGOOPDataGridViewTextBoxColumn.DataPropertyName = "CODIGO_OP";
            this.cODIGOOPDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.cODIGOOPDataGridViewTextBoxColumn.Name = "cODIGOOPDataGridViewTextBoxColumn";
            this.cODIGOOPDataGridViewTextBoxColumn.ReadOnly = true;
            this.cODIGOOPDataGridViewTextBoxColumn.Visible = false;
            this.cODIGOOPDataGridViewTextBoxColumn.Width = 40;
            // 
            // N_ITEM_PEDIDO_OP
            // 
            this.N_ITEM_PEDIDO_OP.DataPropertyName = "N_ITEM_PEDIDO_OP";
            this.N_ITEM_PEDIDO_OP.HeaderText = "Nº Item Pedido";
            this.N_ITEM_PEDIDO_OP.Name = "N_ITEM_PEDIDO_OP";
            this.N_ITEM_PEDIDO_OP.ReadOnly = true;
            this.N_ITEM_PEDIDO_OP.Visible = false;
            this.N_ITEM_PEDIDO_OP.Width = 70;
            // 
            // nFSAIDAOPDataGridViewTextBoxColumn
            // 
            this.nFSAIDAOPDataGridViewTextBoxColumn.DataPropertyName = "NF_SAIDA_OP";
            this.nFSAIDAOPDataGridViewTextBoxColumn.HeaderText = "NF Saída";
            this.nFSAIDAOPDataGridViewTextBoxColumn.Name = "nFSAIDAOPDataGridViewTextBoxColumn";
            this.nFSAIDAOPDataGridViewTextBoxColumn.ReadOnly = true;
            this.nFSAIDAOPDataGridViewTextBoxColumn.Visible = false;
            this.nFSAIDAOPDataGridViewTextBoxColumn.Width = 50;
            // 
            // dATANFSAIDADataGridViewTextBoxColumn
            // 
            this.dATANFSAIDADataGridViewTextBoxColumn.DataPropertyName = "DATA_NF_SAIDA";
            this.dATANFSAIDADataGridViewTextBoxColumn.HeaderText = "Data Saída";
            this.dATANFSAIDADataGridViewTextBoxColumn.Name = "dATANFSAIDADataGridViewTextBoxColumn";
            this.dATANFSAIDADataGridViewTextBoxColumn.ReadOnly = true;
            this.dATANFSAIDADataGridViewTextBoxColumn.Visible = false;
            this.dATANFSAIDADataGridViewTextBoxColumn.Width = 60;
            // 
            // dATAPDFDataGridViewTextBoxColumn
            // 
            this.dATAPDFDataGridViewTextBoxColumn.DataPropertyName = "DATA_PDF";
            this.dATAPDFDataGridViewTextBoxColumn.HeaderText = "DATA_PDF";
            this.dATAPDFDataGridViewTextBoxColumn.Name = "dATAPDFDataGridViewTextBoxColumn";
            this.dATAPDFDataGridViewTextBoxColumn.ReadOnly = true;
            this.dATAPDFDataGridViewTextBoxColumn.Visible = false;
            // 
            // pESOTOTALDataGridViewTextBoxColumn
            // 
            this.pESOTOTALDataGridViewTextBoxColumn.DataPropertyName = "PESO_TOTAL";
            this.pESOTOTALDataGridViewTextBoxColumn.HeaderText = "PESO_TOTAL";
            this.pESOTOTALDataGridViewTextBoxColumn.Name = "pESOTOTALDataGridViewTextBoxColumn";
            this.pESOTOTALDataGridViewTextBoxColumn.ReadOnly = true;
            this.pESOTOTALDataGridViewTextBoxColumn.Visible = false;
            // 
            // pDFACEITOEMDataGridViewTextBoxColumn
            // 
            this.pDFACEITOEMDataGridViewTextBoxColumn.DataPropertyName = "PDF_ACEITO_EM";
            this.pDFACEITOEMDataGridViewTextBoxColumn.HeaderText = "PDF_ACEITO_EM";
            this.pDFACEITOEMDataGridViewTextBoxColumn.Name = "pDFACEITOEMDataGridViewTextBoxColumn";
            this.pDFACEITOEMDataGridViewTextBoxColumn.ReadOnly = true;
            this.pDFACEITOEMDataGridViewTextBoxColumn.Visible = false;
            // 
            // nFNDataGridViewTextBoxColumn
            // 
            this.nFNDataGridViewTextBoxColumn.DataPropertyName = "NF_N";
            this.nFNDataGridViewTextBoxColumn.HeaderText = "NF_N";
            this.nFNDataGridViewTextBoxColumn.Name = "nFNDataGridViewTextBoxColumn";
            this.nFNDataGridViewTextBoxColumn.ReadOnly = true;
            this.nFNDataGridViewTextBoxColumn.Visible = false;
            // 
            // qDEESTDataGridViewTextBoxColumn
            // 
            this.qDEESTDataGridViewTextBoxColumn.DataPropertyName = "QDE_EST";
            this.qDEESTDataGridViewTextBoxColumn.HeaderText = "QDE_EST";
            this.qDEESTDataGridViewTextBoxColumn.Name = "qDEESTDataGridViewTextBoxColumn";
            this.qDEESTDataGridViewTextBoxColumn.ReadOnly = true;
            this.qDEESTDataGridViewTextBoxColumn.Visible = false;
            // 
            // qDEEMBDataGridViewTextBoxColumn
            // 
            this.qDEEMBDataGridViewTextBoxColumn.DataPropertyName = "QDE_EMB";
            this.qDEEMBDataGridViewTextBoxColumn.HeaderText = "QDE_EMB";
            this.qDEEMBDataGridViewTextBoxColumn.Name = "qDEEMBDataGridViewTextBoxColumn";
            this.qDEEMBDataGridViewTextBoxColumn.ReadOnly = true;
            this.qDEEMBDataGridViewTextBoxColumn.Visible = false;
            // 
            // qDECAIXASDataGridViewTextBoxColumn
            // 
            this.qDECAIXASDataGridViewTextBoxColumn.DataPropertyName = "QDE_CAIXAS";
            this.qDECAIXASDataGridViewTextBoxColumn.HeaderText = "QDE_CAIXAS";
            this.qDECAIXASDataGridViewTextBoxColumn.Name = "qDECAIXASDataGridViewTextBoxColumn";
            this.qDECAIXASDataGridViewTextBoxColumn.ReadOnly = true;
            this.qDECAIXASDataGridViewTextBoxColumn.Visible = false;
            // 
            // mATERIALOPDataGridViewTextBoxColumn
            // 
            this.mATERIALOPDataGridViewTextBoxColumn.DataPropertyName = "MATERIAL_OP";
            this.mATERIALOPDataGridViewTextBoxColumn.HeaderText = "MATERIAL_OP";
            this.mATERIALOPDataGridViewTextBoxColumn.Name = "mATERIALOPDataGridViewTextBoxColumn";
            this.mATERIALOPDataGridViewTextBoxColumn.ReadOnly = true;
            this.mATERIALOPDataGridViewTextBoxColumn.Visible = false;
            // 
            // eSPESSURAOPDataGridViewTextBoxColumn
            // 
            this.eSPESSURAOPDataGridViewTextBoxColumn.DataPropertyName = "ESPESSURA_OP";
            this.eSPESSURAOPDataGridViewTextBoxColumn.HeaderText = "ESPESSURA_OP";
            this.eSPESSURAOPDataGridViewTextBoxColumn.Name = "eSPESSURAOPDataGridViewTextBoxColumn";
            this.eSPESSURAOPDataGridViewTextBoxColumn.ReadOnly = true;
            this.eSPESSURAOPDataGridViewTextBoxColumn.Visible = false;
            // 
            // fUNCAOOPDataGridViewTextBoxColumn
            // 
            this.fUNCAOOPDataGridViewTextBoxColumn.DataPropertyName = "FUNCAO_OP";
            this.fUNCAOOPDataGridViewTextBoxColumn.HeaderText = "FUNCAO_OP";
            this.fUNCAOOPDataGridViewTextBoxColumn.Name = "fUNCAOOPDataGridViewTextBoxColumn";
            this.fUNCAOOPDataGridViewTextBoxColumn.ReadOnly = true;
            this.fUNCAOOPDataGridViewTextBoxColumn.Visible = false;
            // 
            // rEVISAOOPDataGridViewTextBoxColumn
            // 
            this.rEVISAOOPDataGridViewTextBoxColumn.DataPropertyName = "REVISAO_OP";
            this.rEVISAOOPDataGridViewTextBoxColumn.HeaderText = "REVISAO_OP";
            this.rEVISAOOPDataGridViewTextBoxColumn.Name = "rEVISAOOPDataGridViewTextBoxColumn";
            this.rEVISAOOPDataGridViewTextBoxColumn.ReadOnly = true;
            this.rEVISAOOPDataGridViewTextBoxColumn.Visible = false;
            // 
            // tRATTERMICOOPDataGridViewTextBoxColumn
            // 
            this.tRATTERMICOOPDataGridViewTextBoxColumn.DataPropertyName = "TRAT_TERMICO_OP";
            this.tRATTERMICOOPDataGridViewTextBoxColumn.HeaderText = "TRAT_TERMICO_OP";
            this.tRATTERMICOOPDataGridViewTextBoxColumn.Name = "tRATTERMICOOPDataGridViewTextBoxColumn";
            this.tRATTERMICOOPDataGridViewTextBoxColumn.ReadOnly = true;
            this.tRATTERMICOOPDataGridViewTextBoxColumn.Visible = false;
            // 
            // mATERIALFORNOPDataGridViewTextBoxColumn
            // 
            this.mATERIALFORNOPDataGridViewTextBoxColumn.DataPropertyName = "MATERIAL_FORN_OP";
            this.mATERIALFORNOPDataGridViewTextBoxColumn.HeaderText = "MATERIAL_FORN_OP";
            this.mATERIALFORNOPDataGridViewTextBoxColumn.Name = "mATERIALFORNOPDataGridViewTextBoxColumn";
            this.mATERIALFORNOPDataGridViewTextBoxColumn.ReadOnly = true;
            this.mATERIALFORNOPDataGridViewTextBoxColumn.Visible = false;
            // 
            // nFMATERIALOPDataGridViewTextBoxColumn
            // 
            this.nFMATERIALOPDataGridViewTextBoxColumn.DataPropertyName = "NF_MATERIAL_OP";
            this.nFMATERIALOPDataGridViewTextBoxColumn.HeaderText = "NF_MATERIAL_OP";
            this.nFMATERIALOPDataGridViewTextBoxColumn.Name = "nFMATERIALOPDataGridViewTextBoxColumn";
            this.nFMATERIALOPDataGridViewTextBoxColumn.ReadOnly = true;
            this.nFMATERIALOPDataGridViewTextBoxColumn.Visible = false;
            // 
            // dUREZASOLICOPDataGridViewTextBoxColumn
            // 
            this.dUREZASOLICOPDataGridViewTextBoxColumn.DataPropertyName = "DUREZA_SOLIC_OP";
            this.dUREZASOLICOPDataGridViewTextBoxColumn.HeaderText = "DUREZA_SOLIC_OP";
            this.dUREZASOLICOPDataGridViewTextBoxColumn.Name = "dUREZASOLICOPDataGridViewTextBoxColumn";
            this.dUREZASOLICOPDataGridViewTextBoxColumn.ReadOnly = true;
            this.dUREZASOLICOPDataGridViewTextBoxColumn.Visible = false;
            // 
            // dUREZAENCOPDataGridViewTextBoxColumn
            // 
            this.dUREZAENCOPDataGridViewTextBoxColumn.DataPropertyName = "DUREZA_ENC_OP";
            this.dUREZAENCOPDataGridViewTextBoxColumn.HeaderText = "DUREZA_ENC_OP";
            this.dUREZAENCOPDataGridViewTextBoxColumn.Name = "dUREZAENCOPDataGridViewTextBoxColumn";
            this.dUREZAENCOPDataGridViewTextBoxColumn.ReadOnly = true;
            this.dUREZAENCOPDataGridViewTextBoxColumn.Visible = false;
            // 
            // pROCESSOOPDataGridViewTextBoxColumn
            // 
            this.pROCESSOOPDataGridViewTextBoxColumn.DataPropertyName = "PROCESSO_OP";
            this.pROCESSOOPDataGridViewTextBoxColumn.HeaderText = "PROCESSO_OP";
            this.pROCESSOOPDataGridViewTextBoxColumn.Name = "pROCESSOOPDataGridViewTextBoxColumn";
            this.pROCESSOOPDataGridViewTextBoxColumn.ReadOnly = true;
            this.pROCESSOOPDataGridViewTextBoxColumn.Visible = false;
            // 
            // form_os_entregues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1489, 724);
            this.Controls.Add(this.cbSimulacao_nota);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnProducao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvOp);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form_os_entregues";
            this.Text = "Posição OS";
            this.Load += new System.EventHandler(this.form_os_entregues_Load);
            this.SizeChanged += new System.EventHandler(this.form_os_entregues_SizeChanged);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsOp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOp)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsRotas_campo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ROTAS_CAMPO)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtTermino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datOp;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Data.DataSet dsOp;
        private System.Data.DataTable OP;
        private System.Data.DataColumn COD_OP;
        private System.Data.DataColumn DATA_PDF;
        private System.Data.DataColumn ENTREGA_DIA;
        private System.Data.DataColumn ENTREGOU_DIA;
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
        private System.Data.DataColumn ESPESSURA_OP;
        private System.Data.DataColumn FUNCAO_OP;
        private System.Data.DataColumn FERRAMENTA_OP;
        private System.Data.DataColumn CLIENTE_OP;
        private System.Data.DataColumn FINALIZADO_OP;
        private System.Data.DataColumn POSICAO_ATUAL_OP;
        private System.Data.DataColumn REVISAO_OP;
        private System.Data.DataColumn TRAT_TERMICO_OP;
        private System.Data.DataColumn MATERIAL_FORN_OP;
        private System.Data.DataColumn NF_MATERIAL_OP;
        private System.Data.DataColumn DUREZA_SOLIC_OP;
        private System.Data.DataColumn DUREZA_ENC_OP;
        private System.Data.DataColumn NF_SAIDA_OP;
        private System.Data.DataColumn DATA_NF_SAIDA;
        private System.Data.DataColumn PROCESSO_OP;
        private System.Data.DataColumn CODIGO_OP;
        private System.Windows.Forms.DataGridView dgvOp;
        private System.Windows.Forms.TextBox tb_os;
        private System.Windows.Forms.TextBox tb_ferramenta;
        private System.Windows.Forms.TextBox tb_item;
        private FirebirdSql.Data.FirebirdClient.FbCommand comando_select;
        private System.Windows.Forms.TextBox tb_posicao;
        private System.Windows.Forms.CheckBox cb_finalizadas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton data_entradaradioButton;
        private System.Windows.Forms.RadioButton data_saidaradioButton;
        private System.Windows.Forms.Button button3;
        private System.Data.DataColumn dataColumn1;
        private System.Windows.Forms.Button button4;
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox naoentreguesCheckbox;
        private System.Windows.Forms.RadioButton data_entrada_previstaradioButton;
        private System.Windows.Forms.Panel panel2;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Windows.Forms.Button button5;
        private System.Data.DataColumn dataColumn4;
        private System.Windows.Forms.TextBox tb_tipo;
        private System.Windows.Forms.CheckBox cb_faturado_01;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox txtLote;
        private System.Windows.Forms.Button btnCliente;
        private System.Data.DataColumn dataColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTEOPDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnProducao;
        private System.Windows.Forms.Label label6;
        private System.Data.DataColumn dataColumn6;
        private System.Windows.Forms.CheckBox cbSimulacao_nota;
        private System.Data.DataColumn dataColumn7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cbUrgente;
        private System.Data.DataColumn dataColumn8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox nf_tb;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNTREGADIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNTREGOUDIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_fin;
        private System.Windows.Forms.DataGridViewCheckBoxColumn URGENTE_OP;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_os;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod_op;
        private System.Windows.Forms.DataGridViewTextBoxColumn OP_MAE;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_pedido_op;
        private System.Windows.Forms.DataGridViewTextBoxColumn nPDFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR_TOTAL_PROD_ITEM_VENDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONDPGTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fERRAMENTAOPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qDEPDFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qDEFABDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_pos_atual;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODIGOOPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn N_ITEM_PEDIDO_OP;
        private System.Windows.Forms.DataGridViewTextBoxColumn nFSAIDAOPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATANFSAIDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAPDFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pESOTOTALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pDFACEITOEMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nFNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qDEESTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qDEEMBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qDECAIXASDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mATERIALOPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSPESSURAOPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fUNCAOOPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEVISAOOPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRATTERMICOOPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mATERIALFORNOPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nFMATERIALOPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dUREZASOLICOPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dUREZAENCOPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROCESSOOPDataGridViewTextBoxColumn;
    }
}