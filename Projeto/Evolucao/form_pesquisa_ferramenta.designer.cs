namespace Evolucao
{
    partial class form_pesquisa_ferramenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_pesquisa_ferramenta));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.tb_ferramenta = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvItens_orcamento = new System.Windows.Forms.DataGridView();
            this.nOMEITEMORCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_orc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODITEMORCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_qtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_fresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_retifica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ret_opt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_edm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_torno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ewc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ewc015 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_item_mat_pri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_valor_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aprovado = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Reprovado = new System.Windows.Forms.DataGridViewButtonColumn();
            this.col_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_total_horas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_valor_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsItens_orcamento = new System.Data.DataSet();
            this.ITENS_ORCAMENTO = new System.Data.DataTable();
            this.COD_ITEM_ORC = new System.Data.DataColumn();
            this.NOME_ITEM_ORC = new System.Data.DataColumn();
            this.QTDE_ITEM_ORC = new System.Data.DataColumn();
            this.HORAS_FRESA_ITEM_ORC = new System.Data.DataColumn();
            this.HORAS_RETIFICA_ITEM_ORC = new System.Data.DataColumn();
            this.HORAS_RET_OPT_ITEM_ORC = new System.Data.DataColumn();
            this.HORAS_EDM_ITEM_ORC = new System.Data.DataColumn();
            this.HORAS_TORNO_ITEM_ORC = new System.Data.DataColumn();
            this.HORAS_EWC_ITEM_ORC = new System.Data.DataColumn();
            this.HORAS_EWC015_ITEM_ORC = new System.Data.DataColumn();
            this.VALOR_TOTAL_ITEM_ORC = new System.Data.DataColumn();
            this.STATUS_ITEM_ORC = new System.Data.DataColumn();
            this.OBS_ITEM_ORC = new System.Data.DataColumn();
            this.COD_ORCAMENTO_ITEM_ORC = new System.Data.DataColumn();
            this.TOTAL_HORAS_ITEM_ORC = new System.Data.DataColumn();
            this.VALOR_UNIT_ITEM_ORC = new System.Data.DataColumn();
            this.VALOR_MAT_PRI_ITEM_ORC = new System.Data.DataColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_horas_previstas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_horas_trabalhadas = new System.Windows.Forms.TextBox();
            this.dgvRotas_campo = new System.Windows.Forms.DataGridView();
            this.col_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_operacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_horas_previstas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cod_rota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODROTAPECADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oBSERVACAOCAMPODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESENHOCAMPODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOSICAOFILACAMPODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPERADORCAMPODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORAENTRADADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAENTRADADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORAFECHAMENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAFECHAMENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fINALIZADODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOSICAOATUALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_saldo_horas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPROTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nPDFCAMPODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ok = new System.Windows.Forms.DataGridViewButtonColumn();
            this.col_sem = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dgvPosicoes = new System.Windows.Forms.DataGridView();
            this.dESENHOOPATUALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nPDFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cod_os = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONDPGTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAPDFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNTREGOUDIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qDEPDFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fINALIZADOOPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pOSICAOATUALOPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fERRAMENTAOPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNTREGADIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRECOUNITDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pESOTOTALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pDFACEITOEMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nFNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qDEESTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qDEFABDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qDEEMBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qDECAIXASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mATERIALOPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSPESSURAOPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fUNCAOOPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTEOPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.ESPESSURA_OP = new System.Data.DataColumn();
            this.FUNCAO_OP = new System.Data.DataColumn();
            this.FERRAMENTA_OP = new System.Data.DataColumn();
            this.CLIENTE_OP = new System.Data.DataColumn();
            this.FINALIZADO_OP = new System.Data.DataColumn();
            this.POSICAO_ATUAL_OP = new System.Data.DataColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.datItens_orcamento = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.datOp = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand8 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand6 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand5 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand7 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection2 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.datRotas_campo = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand12 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand10 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand9 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand11 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_item = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens_orcamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsItens_orcamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITENS_ORCAMENTO)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRotas_campo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRotas_campo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ROTAS_CAMPO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosicoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // fbConnection1
            // 
            this.fbConnection1.ConnectionString = resources.GetString("fbConnection1.ConnectionString");
            // 
            // tb_ferramenta
            // 
            this.tb_ferramenta.Location = new System.Drawing.Point(146, 63);
            this.tb_ferramenta.Name = "tb_ferramenta";
            this.tb_ferramenta.Size = new System.Drawing.Size(109, 20);
            this.tb_ferramenta.TabIndex = 0;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label28.Location = new System.Drawing.Point(12, 9);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(301, 42);
            this.label28.TabIndex = 90;
            this.label28.Text = "FERRAMENTAS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 91;
            this.label1.Text = "Código da Ferramenta:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(836, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 92;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvItens_orcamento);
            this.groupBox1.Location = new System.Drawing.Point(19, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(848, 198);
            this.groupBox1.TabIndex = 217;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Orçamentos";
            // 
            // dgvItens_orcamento
            // 
            this.dgvItens_orcamento.AllowUserToAddRows = false;
            this.dgvItens_orcamento.AutoGenerateColumns = false;
            this.dgvItens_orcamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens_orcamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nOMEITEMORCDataGridViewTextBoxColumn,
            this.col_orc,
            this.cODITEMORCDataGridViewTextBoxColumn,
            this.col_qtde,
            this.col_fresa,
            this.col_retifica,
            this.col_ret_opt,
            this.col_edm,
            this.col_torno,
            this.col_ewc,
            this.col_ewc015,
            this.col_item_mat_pri,
            this.col_valor_total,
            this.Aprovado,
            this.Reprovado,
            this.col_status,
            this.dataGridViewTextBoxColumn2,
            this.col_total_horas,
            this.col_valor_unit});
            this.dgvItens_orcamento.DataMember = "ITENS_ORCAMENTO";
            this.dgvItens_orcamento.DataSource = this.dsItens_orcamento;
            this.dgvItens_orcamento.Location = new System.Drawing.Point(9, 24);
            this.dgvItens_orcamento.Name = "dgvItens_orcamento";
            this.dgvItens_orcamento.Size = new System.Drawing.Size(830, 150);
            this.dgvItens_orcamento.TabIndex = 216;
            this.dgvItens_orcamento.Visible = false;
            this.dgvItens_orcamento.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItens_orcamento_CellDoubleClick);
            // 
            // nOMEITEMORCDataGridViewTextBoxColumn
            // 
            this.nOMEITEMORCDataGridViewTextBoxColumn.DataPropertyName = "NOME_ITEM_ORC";
            this.nOMEITEMORCDataGridViewTextBoxColumn.Frozen = true;
            this.nOMEITEMORCDataGridViewTextBoxColumn.HeaderText = "Ferramenta";
            this.nOMEITEMORCDataGridViewTextBoxColumn.Name = "nOMEITEMORCDataGridViewTextBoxColumn";
            // 
            // col_orc
            // 
            this.col_orc.DataPropertyName = "COD_ORCAMENTO_ITEM_ORC";
            this.col_orc.HeaderText = "COD_ORCAMENTO_ITEM_ORC";
            this.col_orc.Name = "col_orc";
            this.col_orc.Visible = false;
            // 
            // cODITEMORCDataGridViewTextBoxColumn
            // 
            this.cODITEMORCDataGridViewTextBoxColumn.DataPropertyName = "COD_ITEM_ORC";
            this.cODITEMORCDataGridViewTextBoxColumn.HeaderText = "COD_ITEM_ORC";
            this.cODITEMORCDataGridViewTextBoxColumn.Name = "cODITEMORCDataGridViewTextBoxColumn";
            this.cODITEMORCDataGridViewTextBoxColumn.Visible = false;
            // 
            // col_qtde
            // 
            this.col_qtde.DataPropertyName = "QTDE_ITEM_ORC";
            this.col_qtde.HeaderText = "Qtde";
            this.col_qtde.Name = "col_qtde";
            this.col_qtde.Width = 50;
            // 
            // col_fresa
            // 
            this.col_fresa.DataPropertyName = "HORAS_FRESA_ITEM_ORC";
            this.col_fresa.HeaderText = "Fresa";
            this.col_fresa.Name = "col_fresa";
            this.col_fresa.Width = 50;
            // 
            // col_retifica
            // 
            this.col_retifica.DataPropertyName = "HORAS_RETIFICA_ITEM_ORC";
            this.col_retifica.HeaderText = "Retífica";
            this.col_retifica.Name = "col_retifica";
            this.col_retifica.Width = 50;
            // 
            // col_ret_opt
            // 
            this.col_ret_opt.DataPropertyName = "HORAS_RET_OPT_ITEM_ORC";
            this.col_ret_opt.HeaderText = "Retífica Óptica";
            this.col_ret_opt.Name = "col_ret_opt";
            this.col_ret_opt.Width = 50;
            // 
            // col_edm
            // 
            this.col_edm.DataPropertyName = "HORAS_EDM_ITEM_ORC";
            this.col_edm.HeaderText = "EDM";
            this.col_edm.Name = "col_edm";
            this.col_edm.Width = 50;
            // 
            // col_torno
            // 
            this.col_torno.DataPropertyName = "HORAS_TORNO_ITEM_ORC";
            this.col_torno.HeaderText = "Torno";
            this.col_torno.Name = "col_torno";
            this.col_torno.Width = 50;
            // 
            // col_ewc
            // 
            this.col_ewc.DataPropertyName = "HORAS_EWC_ITEM_ORC";
            this.col_ewc.HeaderText = "EWC";
            this.col_ewc.Name = "col_ewc";
            this.col_ewc.Width = 50;
            // 
            // col_ewc015
            // 
            this.col_ewc015.DataPropertyName = "HORAS_EWC015_ITEM_ORC";
            this.col_ewc015.HeaderText = "EWC 015";
            this.col_ewc015.Name = "col_ewc015";
            this.col_ewc015.Width = 50;
            // 
            // col_item_mat_pri
            // 
            this.col_item_mat_pri.DataPropertyName = "VALOR_MAT_PRI_ITEM_ORC";
            this.col_item_mat_pri.HeaderText = "Mat. Prima";
            this.col_item_mat_pri.Name = "col_item_mat_pri";
            this.col_item_mat_pri.Width = 50;
            // 
            // col_valor_total
            // 
            this.col_valor_total.DataPropertyName = "VALOR_TOTAL_ITEM_ORC";
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.col_valor_total.DefaultCellStyle = dataGridViewCellStyle1;
            this.col_valor_total.HeaderText = "Valor Total";
            this.col_valor_total.Name = "col_valor_total";
            // 
            // Aprovado
            // 
            this.Aprovado.DataPropertyName = "COD_ITEM_ORC";
            this.Aprovado.HeaderText = "Aprovado";
            this.Aprovado.Name = "Aprovado";
            this.Aprovado.Text = "Aprovado";
            this.Aprovado.ToolTipText = "Aprovado";
            this.Aprovado.UseColumnTextForButtonValue = true;
            this.Aprovado.Width = 60;
            // 
            // Reprovado
            // 
            this.Reprovado.HeaderText = "Reprovado";
            this.Reprovado.Name = "Reprovado";
            this.Reprovado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Reprovado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Reprovado.Text = "Reprovado";
            this.Reprovado.ToolTipText = "Reprovado";
            this.Reprovado.UseColumnTextForButtonValue = true;
            this.Reprovado.Width = 70;
            // 
            // col_status
            // 
            this.col_status.DataPropertyName = "STATUS_ITEM_ORC";
            this.col_status.HeaderText = "Status";
            this.col_status.Name = "col_status";
            this.col_status.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "OBS_ITEM_ORC";
            this.dataGridViewTextBoxColumn2.HeaderText = "Obs";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // col_total_horas
            // 
            this.col_total_horas.DataPropertyName = "TOTAL_HORAS_ITEM_ORC";
            this.col_total_horas.HeaderText = "Total Horas";
            this.col_total_horas.Name = "col_total_horas";
            // 
            // col_valor_unit
            // 
            this.col_valor_unit.DataPropertyName = "VALOR_UNIT_ITEM_ORC";
            this.col_valor_unit.HeaderText = "Valor Unit";
            this.col_valor_unit.Name = "col_valor_unit";
            // 
            // dsItens_orcamento
            // 
            this.dsItens_orcamento.DataSetName = "dsItens_orcamento";
            this.dsItens_orcamento.Namespace = "http://www.tempuri.org/dsItens_orcamento.xsd";
            this.dsItens_orcamento.Tables.AddRange(new System.Data.DataTable[] {
            this.ITENS_ORCAMENTO});
            // 
            // ITENS_ORCAMENTO
            // 
            this.ITENS_ORCAMENTO.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_ITEM_ORC,
            this.NOME_ITEM_ORC,
            this.QTDE_ITEM_ORC,
            this.HORAS_FRESA_ITEM_ORC,
            this.HORAS_RETIFICA_ITEM_ORC,
            this.HORAS_RET_OPT_ITEM_ORC,
            this.HORAS_EDM_ITEM_ORC,
            this.HORAS_TORNO_ITEM_ORC,
            this.HORAS_EWC_ITEM_ORC,
            this.HORAS_EWC015_ITEM_ORC,
            this.VALOR_TOTAL_ITEM_ORC,
            this.STATUS_ITEM_ORC,
            this.OBS_ITEM_ORC,
            this.COD_ORCAMENTO_ITEM_ORC,
            this.TOTAL_HORAS_ITEM_ORC,
            this.VALOR_UNIT_ITEM_ORC,
            this.VALOR_MAT_PRI_ITEM_ORC});
            this.ITENS_ORCAMENTO.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_ITEM_ORC"}, true)});
            this.ITENS_ORCAMENTO.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_ITEM_ORC};
            this.ITENS_ORCAMENTO.TableName = "ITENS_ORCAMENTO";
            // 
            // COD_ITEM_ORC
            // 
            this.COD_ITEM_ORC.AllowDBNull = false;
            this.COD_ITEM_ORC.ColumnName = "COD_ITEM_ORC";
            this.COD_ITEM_ORC.DataType = typeof(int);
            // 
            // NOME_ITEM_ORC
            // 
            this.NOME_ITEM_ORC.ColumnName = "NOME_ITEM_ORC";
            this.NOME_ITEM_ORC.MaxLength = 100;
            // 
            // QTDE_ITEM_ORC
            // 
            this.QTDE_ITEM_ORC.ColumnName = "QTDE_ITEM_ORC";
            this.QTDE_ITEM_ORC.DataType = typeof(int);
            // 
            // HORAS_FRESA_ITEM_ORC
            // 
            this.HORAS_FRESA_ITEM_ORC.ColumnName = "HORAS_FRESA_ITEM_ORC";
            this.HORAS_FRESA_ITEM_ORC.DataType = typeof(double);
            // 
            // HORAS_RETIFICA_ITEM_ORC
            // 
            this.HORAS_RETIFICA_ITEM_ORC.ColumnName = "HORAS_RETIFICA_ITEM_ORC";
            this.HORAS_RETIFICA_ITEM_ORC.DataType = typeof(double);
            // 
            // HORAS_RET_OPT_ITEM_ORC
            // 
            this.HORAS_RET_OPT_ITEM_ORC.ColumnName = "HORAS_RET_OPT_ITEM_ORC";
            this.HORAS_RET_OPT_ITEM_ORC.DataType = typeof(double);
            // 
            // HORAS_EDM_ITEM_ORC
            // 
            this.HORAS_EDM_ITEM_ORC.ColumnName = "HORAS_EDM_ITEM_ORC";
            this.HORAS_EDM_ITEM_ORC.DataType = typeof(double);
            // 
            // HORAS_TORNO_ITEM_ORC
            // 
            this.HORAS_TORNO_ITEM_ORC.ColumnName = "HORAS_TORNO_ITEM_ORC";
            this.HORAS_TORNO_ITEM_ORC.DataType = typeof(double);
            // 
            // HORAS_EWC_ITEM_ORC
            // 
            this.HORAS_EWC_ITEM_ORC.ColumnName = "HORAS_EWC_ITEM_ORC";
            this.HORAS_EWC_ITEM_ORC.DataType = typeof(double);
            // 
            // HORAS_EWC015_ITEM_ORC
            // 
            this.HORAS_EWC015_ITEM_ORC.ColumnName = "HORAS_EWC015_ITEM_ORC";
            this.HORAS_EWC015_ITEM_ORC.DataType = typeof(double);
            // 
            // VALOR_TOTAL_ITEM_ORC
            // 
            this.VALOR_TOTAL_ITEM_ORC.ColumnName = "VALOR_TOTAL_ITEM_ORC";
            this.VALOR_TOTAL_ITEM_ORC.DataType = typeof(double);
            // 
            // STATUS_ITEM_ORC
            // 
            this.STATUS_ITEM_ORC.ColumnName = "STATUS_ITEM_ORC";
            this.STATUS_ITEM_ORC.MaxLength = 100;
            // 
            // OBS_ITEM_ORC
            // 
            this.OBS_ITEM_ORC.ColumnName = "OBS_ITEM_ORC";
            this.OBS_ITEM_ORC.MaxLength = 100;
            // 
            // COD_ORCAMENTO_ITEM_ORC
            // 
            this.COD_ORCAMENTO_ITEM_ORC.ColumnName = "COD_ORCAMENTO_ITEM_ORC";
            this.COD_ORCAMENTO_ITEM_ORC.DataType = typeof(int);
            // 
            // TOTAL_HORAS_ITEM_ORC
            // 
            this.TOTAL_HORAS_ITEM_ORC.ColumnName = "TOTAL_HORAS_ITEM_ORC";
            this.TOTAL_HORAS_ITEM_ORC.DataType = typeof(double);
            // 
            // VALOR_UNIT_ITEM_ORC
            // 
            this.VALOR_UNIT_ITEM_ORC.ColumnName = "VALOR_UNIT_ITEM_ORC";
            this.VALOR_UNIT_ITEM_ORC.DataType = typeof(double);
            // 
            // VALOR_MAT_PRI_ITEM_ORC
            // 
            this.VALOR_MAT_PRI_ITEM_ORC.ColumnName = "VALOR_MAT_PRI_ITEM_ORC";
            this.VALOR_MAT_PRI_ITEM_ORC.DataType = typeof(double);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_horas_previstas);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tb_horas_trabalhadas);
            this.groupBox2.Controls.Add(this.dgvRotas_campo);
            this.groupBox2.Controls.Add(this.dgvPosicoes);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(19, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1044, 288);
            this.groupBox2.TabIndex = 220;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "OS e Rotas";
            // 
            // tb_horas_previstas
            // 
            this.tb_horas_previstas.Location = new System.Drawing.Point(912, 256);
            this.tb_horas_previstas.Name = "tb_horas_previstas";
            this.tb_horas_previstas.Size = new System.Drawing.Size(49, 20);
            this.tb_horas_previstas.TabIndex = 224;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(870, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 223;
            this.label2.Text = "Totais";
            // 
            // tb_horas_trabalhadas
            // 
            this.tb_horas_trabalhadas.Location = new System.Drawing.Point(962, 256);
            this.tb_horas_trabalhadas.Name = "tb_horas_trabalhadas";
            this.tb_horas_trabalhadas.Size = new System.Drawing.Size(63, 20);
            this.tb_horas_trabalhadas.TabIndex = 222;
            // 
            // dgvRotas_campo
            // 
            this.dgvRotas_campo.AllowUserToAddRows = false;
            this.dgvRotas_campo.AllowUserToDeleteRows = false;
            this.dgvRotas_campo.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRotas_campo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRotas_campo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRotas_campo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_cod,
            this.col_operacao,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.col_horas_previstas,
            this.col_cod_rota,
            this.cODROTAPECADataGridViewTextBoxColumn,
            this.oBSERVACAOCAMPODataGridViewTextBoxColumn,
            this.dESENHOCAMPODataGridViewTextBoxColumn,
            this.pOSICAOFILACAMPODataGridViewTextBoxColumn,
            this.oPERADORCAMPODataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.hORAENTRADADataGridViewTextBoxColumn,
            this.dATAENTRADADataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.hORAFECHAMENTODataGridViewTextBoxColumn,
            this.dATAFECHAMENTODataGridViewTextBoxColumn,
            this.fINALIZADODataGridViewTextBoxColumn,
            this.pOSICAOATUALDataGridViewTextBoxColumn,
            this.col_saldo_horas,
            this.oPROTADataGridViewTextBoxColumn,
            this.nPDFCAMPODataGridViewTextBoxColumn,
            this.Ok,
            this.col_sem});
            this.dgvRotas_campo.DataMember = "ROTAS_CAMPO";
            this.dgvRotas_campo.DataSource = this.dsRotas_campo;
            this.dgvRotas_campo.Location = new System.Drawing.Point(710, 26);
            this.dgvRotas_campo.Name = "dgvRotas_campo";
            this.dgvRotas_campo.Size = new System.Drawing.Size(315, 224);
            this.dgvRotas_campo.TabIndex = 221;
            this.dgvRotas_campo.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRotas_campo_CellMouseDoubleClick);
            // 
            // col_cod
            // 
            this.col_cod.DataPropertyName = "COD_ROTA_CAMPO";
            this.col_cod.HeaderText = "Cód. da Rota";
            this.col_cod.Name = "col_cod";
            this.col_cod.Width = 50;
            // 
            // col_operacao
            // 
            this.col_operacao.DataPropertyName = "OPERACAO_CAMPO";
            this.col_operacao.HeaderText = "Operação";
            this.col_operacao.Name = "col_operacao";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DATA_ENTRADA_PREV";
            this.dataGridViewTextBoxColumn1.HeaderText = "Data Ent Prev";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 70;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DATA_FECHAMENTO_PREV";
            this.dataGridViewTextBoxColumn3.HeaderText = "Data Fech Prev";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            this.dataGridViewTextBoxColumn3.Width = 70;
            // 
            // col_horas_previstas
            // 
            this.col_horas_previstas.DataPropertyName = "PREVISAO_PRODUCAO";
            this.col_horas_previstas.HeaderText = "Horas Previstas";
            this.col_horas_previstas.Name = "col_horas_previstas";
            this.col_horas_previstas.Width = 50;
            // 
            // col_cod_rota
            // 
            this.col_cod_rota.DataPropertyName = "COD_NUM_ROTAS";
            this.col_cod_rota.HeaderText = "Código da Rota";
            this.col_cod_rota.Name = "col_cod_rota";
            this.col_cod_rota.Visible = false;
            this.col_cod_rota.Width = 50;
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
            this.oBSERVACAOCAMPODataGridViewTextBoxColumn.HeaderText = "Observação";
            this.oBSERVACAOCAMPODataGridViewTextBoxColumn.Name = "oBSERVACAOCAMPODataGridViewTextBoxColumn";
            this.oBSERVACAOCAMPODataGridViewTextBoxColumn.Visible = false;
            this.oBSERVACAOCAMPODataGridViewTextBoxColumn.Width = 70;
            // 
            // dESENHOCAMPODataGridViewTextBoxColumn
            // 
            this.dESENHOCAMPODataGridViewTextBoxColumn.DataPropertyName = "DESENHO_CAMPO";
            this.dESENHOCAMPODataGridViewTextBoxColumn.HeaderText = "DESENHO_CAMPO";
            this.dESENHOCAMPODataGridViewTextBoxColumn.Name = "dESENHOCAMPODataGridViewTextBoxColumn";
            this.dESENHOCAMPODataGridViewTextBoxColumn.Visible = false;
            // 
            // pOSICAOFILACAMPODataGridViewTextBoxColumn
            // 
            this.pOSICAOFILACAMPODataGridViewTextBoxColumn.DataPropertyName = "POSICAO_FILA_CAMPO";
            this.pOSICAOFILACAMPODataGridViewTextBoxColumn.HeaderText = "POSICAO_FILA_CAMPO";
            this.pOSICAOFILACAMPODataGridViewTextBoxColumn.Name = "pOSICAOFILACAMPODataGridViewTextBoxColumn";
            this.pOSICAOFILACAMPODataGridViewTextBoxColumn.Visible = false;
            // 
            // oPERADORCAMPODataGridViewTextBoxColumn
            // 
            this.oPERADORCAMPODataGridViewTextBoxColumn.DataPropertyName = "OPERADOR_CAMPO";
            this.oPERADORCAMPODataGridViewTextBoxColumn.HeaderText = "Oper. Início";
            this.oPERADORCAMPODataGridViewTextBoxColumn.Name = "oPERADORCAMPODataGridViewTextBoxColumn";
            this.oPERADORCAMPODataGridViewTextBoxColumn.Visible = false;
            this.oPERADORCAMPODataGridViewTextBoxColumn.Width = 40;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MAQUINA";
            this.dataGridViewTextBoxColumn4.HeaderText = "Máq. Início";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            this.dataGridViewTextBoxColumn4.Width = 50;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "OS_CONJUNTAS";
            this.dataGridViewTextBoxColumn5.HeaderText = "OCI";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            this.dataGridViewTextBoxColumn5.Width = 25;
            // 
            // hORAENTRADADataGridViewTextBoxColumn
            // 
            this.hORAENTRADADataGridViewTextBoxColumn.DataPropertyName = "HORA_ENTRADA";
            this.hORAENTRADADataGridViewTextBoxColumn.HeaderText = "Hora da Entrada";
            this.hORAENTRADADataGridViewTextBoxColumn.Name = "hORAENTRADADataGridViewTextBoxColumn";
            this.hORAENTRADADataGridViewTextBoxColumn.Visible = false;
            this.hORAENTRADADataGridViewTextBoxColumn.Width = 60;
            // 
            // dATAENTRADADataGridViewTextBoxColumn
            // 
            this.dATAENTRADADataGridViewTextBoxColumn.DataPropertyName = "DATA_ENTRADA";
            this.dATAENTRADADataGridViewTextBoxColumn.HeaderText = "Data de Entrada";
            this.dATAENTRADADataGridViewTextBoxColumn.Name = "dATAENTRADADataGridViewTextBoxColumn";
            this.dATAENTRADADataGridViewTextBoxColumn.Visible = false;
            this.dATAENTRADADataGridViewTextBoxColumn.Width = 60;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "OPERADOR_FINALIZADOR";
            this.dataGridViewTextBoxColumn6.HeaderText = "Oper. Fim";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Visible = false;
            this.dataGridViewTextBoxColumn6.Width = 40;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "MAQUINA_FECHAMENTO";
            this.dataGridViewTextBoxColumn7.HeaderText = "Máq. Fecha";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Visible = false;
            this.dataGridViewTextBoxColumn7.Width = 50;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "OS_CONJUNTAS_FECHAMENTO";
            this.dataGridViewTextBoxColumn8.HeaderText = "OCF";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Visible = false;
            this.dataGridViewTextBoxColumn8.Width = 25;
            // 
            // hORAFECHAMENTODataGridViewTextBoxColumn
            // 
            this.hORAFECHAMENTODataGridViewTextBoxColumn.DataPropertyName = "HORA_FECHAMENTO";
            this.hORAFECHAMENTODataGridViewTextBoxColumn.HeaderText = "Hora do Fechamento";
            this.hORAFECHAMENTODataGridViewTextBoxColumn.Name = "hORAFECHAMENTODataGridViewTextBoxColumn";
            this.hORAFECHAMENTODataGridViewTextBoxColumn.Visible = false;
            this.hORAFECHAMENTODataGridViewTextBoxColumn.Width = 60;
            // 
            // dATAFECHAMENTODataGridViewTextBoxColumn
            // 
            this.dATAFECHAMENTODataGridViewTextBoxColumn.DataPropertyName = "DATA_FECHAMENTO";
            this.dATAFECHAMENTODataGridViewTextBoxColumn.HeaderText = "Data do Fechamento";
            this.dATAFECHAMENTODataGridViewTextBoxColumn.Name = "dATAFECHAMENTODataGridViewTextBoxColumn";
            this.dATAFECHAMENTODataGridViewTextBoxColumn.Visible = false;
            this.dATAFECHAMENTODataGridViewTextBoxColumn.Width = 60;
            // 
            // fINALIZADODataGridViewTextBoxColumn
            // 
            this.fINALIZADODataGridViewTextBoxColumn.DataPropertyName = "FINALIZADO";
            this.fINALIZADODataGridViewTextBoxColumn.HeaderText = "Finalizado?";
            this.fINALIZADODataGridViewTextBoxColumn.Name = "fINALIZADODataGridViewTextBoxColumn";
            this.fINALIZADODataGridViewTextBoxColumn.Visible = false;
            this.fINALIZADODataGridViewTextBoxColumn.Width = 40;
            // 
            // pOSICAOATUALDataGridViewTextBoxColumn
            // 
            this.pOSICAOATUALDataGridViewTextBoxColumn.DataPropertyName = "POSICAO_ATUAL";
            this.pOSICAOATUALDataGridViewTextBoxColumn.HeaderText = "Posição Atual";
            this.pOSICAOATUALDataGridViewTextBoxColumn.Name = "pOSICAOATUALDataGridViewTextBoxColumn";
            this.pOSICAOATUALDataGridViewTextBoxColumn.Visible = false;
            this.pOSICAOATUALDataGridViewTextBoxColumn.Width = 40;
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
            // nPDFCAMPODataGridViewTextBoxColumn
            // 
            this.nPDFCAMPODataGridViewTextBoxColumn.DataPropertyName = "N_PDF_CAMPO";
            this.nPDFCAMPODataGridViewTextBoxColumn.HeaderText = "N_PDF_CAMPO";
            this.nPDFCAMPODataGridViewTextBoxColumn.Name = "nPDFCAMPODataGridViewTextBoxColumn";
            this.nPDFCAMPODataGridViewTextBoxColumn.Visible = false;
            // 
            // Ok
            // 
            this.Ok.HeaderText = "Ok";
            this.Ok.Name = "Ok";
            this.Ok.Text = "Ok";
            this.Ok.ToolTipText = "Ok";
            this.Ok.UseColumnTextForButtonValue = true;
            this.Ok.Visible = false;
            this.Ok.Width = 40;
            // 
            // col_sem
            // 
            this.col_sem.DataPropertyName = "INSERIDO_SEMANA";
            this.col_sem.HeaderText = "Sem";
            this.col_sem.Name = "col_sem";
            this.col_sem.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_sem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.col_sem.Visible = false;
            this.col_sem.Width = 30;
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
            this.QTDE_SERVICO_EXTERNO});
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
            // dgvPosicoes
            // 
            this.dgvPosicoes.AllowUserToAddRows = false;
            this.dgvPosicoes.AllowUserToDeleteRows = false;
            this.dgvPosicoes.AllowUserToOrderColumns = true;
            this.dgvPosicoes.AllowUserToResizeRows = false;
            this.dgvPosicoes.AutoGenerateColumns = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPosicoes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPosicoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPosicoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dESENHOOPATUALDataGridViewTextBoxColumn,
            this.nPDFDataGridViewTextBoxColumn,
            this.col_cod_os,
            this.cONDPGTODataGridViewTextBoxColumn,
            this.dATAPDFDataGridViewTextBoxColumn,
            this.eNTREGOUDIADataGridViewTextBoxColumn,
            this.qDEPDFDataGridViewTextBoxColumn,
            this.fINALIZADOOPDataGridViewTextBoxColumn,
            this.pOSICAOATUALOPDataGridViewTextBoxColumn,
            this.fERRAMENTAOPDataGridViewTextBoxColumn,
            this.eNTREGADIADataGridViewTextBoxColumn,
            this.pRECOUNITDataGridViewTextBoxColumn,
            this.pESOTOTALDataGridViewTextBoxColumn,
            this.pDFACEITOEMDataGridViewTextBoxColumn,
            this.nFNDataGridViewTextBoxColumn,
            this.qDEESTDataGridViewTextBoxColumn,
            this.qDEFABDataGridViewTextBoxColumn,
            this.qDEEMBDataGridViewTextBoxColumn,
            this.qDECAIXASDataGridViewTextBoxColumn,
            this.mATERIALOPDataGridViewTextBoxColumn,
            this.eSPESSURAOPDataGridViewTextBoxColumn,
            this.fUNCAOOPDataGridViewTextBoxColumn,
            this.cLIENTEOPDataGridViewTextBoxColumn});
            this.dgvPosicoes.DataMember = "OP";
            this.dgvPosicoes.DataSource = this.dsOp;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPosicoes.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPosicoes.Location = new System.Drawing.Point(10, 26);
            this.dgvPosicoes.MultiSelect = false;
            this.dgvPosicoes.Name = "dgvPosicoes";
            this.dgvPosicoes.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPosicoes.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPosicoes.Size = new System.Drawing.Size(694, 224);
            this.dgvPosicoes.TabIndex = 221;
            this.dgvPosicoes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPosicoes_CellClick);
            this.dgvPosicoes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPosicoes_CellContentClick_1);
            this.dgvPosicoes.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPosicoes_RowHeaderMouseClick);
            this.dgvPosicoes.SelectionChanged += new System.EventHandler(this.dgvPosicoes_SelectionChanged);
            // 
            // dESENHOOPATUALDataGridViewTextBoxColumn
            // 
            this.dESENHOOPATUALDataGridViewTextBoxColumn.DataPropertyName = "DESENHO_OP_ATUAL";
            this.dESENHOOPATUALDataGridViewTextBoxColumn.HeaderText = "OS";
            this.dESENHOOPATUALDataGridViewTextBoxColumn.Name = "dESENHOOPATUALDataGridViewTextBoxColumn";
            this.dESENHOOPATUALDataGridViewTextBoxColumn.ReadOnly = true;
            this.dESENHOOPATUALDataGridViewTextBoxColumn.Width = 50;
            // 
            // nPDFDataGridViewTextBoxColumn
            // 
            this.nPDFDataGridViewTextBoxColumn.DataPropertyName = "N_PDF";
            this.nPDFDataGridViewTextBoxColumn.HeaderText = "Pos";
            this.nPDFDataGridViewTextBoxColumn.Name = "nPDFDataGridViewTextBoxColumn";
            this.nPDFDataGridViewTextBoxColumn.ReadOnly = true;
            this.nPDFDataGridViewTextBoxColumn.Width = 40;
            // 
            // col_cod_os
            // 
            this.col_cod_os.DataPropertyName = "COD_OP";
            this.col_cod_os.HeaderText = "COD_OP";
            this.col_cod_os.Name = "col_cod_os";
            this.col_cod_os.ReadOnly = true;
            this.col_cod_os.Visible = false;
            // 
            // cONDPGTODataGridViewTextBoxColumn
            // 
            this.cONDPGTODataGridViewTextBoxColumn.DataPropertyName = "COND_PGTO";
            this.cONDPGTODataGridViewTextBoxColumn.HeaderText = "Item";
            this.cONDPGTODataGridViewTextBoxColumn.Name = "cONDPGTODataGridViewTextBoxColumn";
            this.cONDPGTODataGridViewTextBoxColumn.ReadOnly = true;
            this.cONDPGTODataGridViewTextBoxColumn.Width = 80;
            // 
            // dATAPDFDataGridViewTextBoxColumn
            // 
            this.dATAPDFDataGridViewTextBoxColumn.DataPropertyName = "DATA_PDF";
            this.dATAPDFDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dATAPDFDataGridViewTextBoxColumn.Name = "dATAPDFDataGridViewTextBoxColumn";
            this.dATAPDFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eNTREGOUDIADataGridViewTextBoxColumn
            // 
            this.eNTREGOUDIADataGridViewTextBoxColumn.DataPropertyName = "ENTREGOU_DIA";
            this.eNTREGOUDIADataGridViewTextBoxColumn.HeaderText = "Entrega";
            this.eNTREGOUDIADataGridViewTextBoxColumn.Name = "eNTREGOUDIADataGridViewTextBoxColumn";
            this.eNTREGOUDIADataGridViewTextBoxColumn.ReadOnly = true;
            this.eNTREGOUDIADataGridViewTextBoxColumn.Width = 60;
            // 
            // qDEPDFDataGridViewTextBoxColumn
            // 
            this.qDEPDFDataGridViewTextBoxColumn.DataPropertyName = "QDE_PDF";
            this.qDEPDFDataGridViewTextBoxColumn.HeaderText = "Qtde";
            this.qDEPDFDataGridViewTextBoxColumn.Name = "qDEPDFDataGridViewTextBoxColumn";
            this.qDEPDFDataGridViewTextBoxColumn.ReadOnly = true;
            this.qDEPDFDataGridViewTextBoxColumn.Width = 50;
            // 
            // fINALIZADOOPDataGridViewTextBoxColumn
            // 
            this.fINALIZADOOPDataGridViewTextBoxColumn.DataPropertyName = "FINALIZADO_OP";
            this.fINALIZADOOPDataGridViewTextBoxColumn.FalseValue = "0";
            this.fINALIZADOOPDataGridViewTextBoxColumn.HeaderText = "Finalizado";
            this.fINALIZADOOPDataGridViewTextBoxColumn.IndeterminateValue = "0";
            this.fINALIZADOOPDataGridViewTextBoxColumn.Name = "fINALIZADOOPDataGridViewTextBoxColumn";
            this.fINALIZADOOPDataGridViewTextBoxColumn.ReadOnly = true;
            this.fINALIZADOOPDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.fINALIZADOOPDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.fINALIZADOOPDataGridViewTextBoxColumn.TrueValue = "1";
            this.fINALIZADOOPDataGridViewTextBoxColumn.Width = 60;
            // 
            // pOSICAOATUALOPDataGridViewTextBoxColumn
            // 
            this.pOSICAOATUALOPDataGridViewTextBoxColumn.DataPropertyName = "POSICAO_ATUAL_OP";
            this.pOSICAOATUALOPDataGridViewTextBoxColumn.HeaderText = "Posição Atual";
            this.pOSICAOATUALOPDataGridViewTextBoxColumn.Name = "pOSICAOATUALOPDataGridViewTextBoxColumn";
            this.pOSICAOATUALOPDataGridViewTextBoxColumn.ReadOnly = true;
            this.pOSICAOATUALOPDataGridViewTextBoxColumn.Width = 135;
            // 
            // fERRAMENTAOPDataGridViewTextBoxColumn
            // 
            this.fERRAMENTAOPDataGridViewTextBoxColumn.DataPropertyName = "FERRAMENTA_OP";
            this.fERRAMENTAOPDataGridViewTextBoxColumn.HeaderText = "Ferramenta";
            this.fERRAMENTAOPDataGridViewTextBoxColumn.Name = "fERRAMENTAOPDataGridViewTextBoxColumn";
            this.fERRAMENTAOPDataGridViewTextBoxColumn.ReadOnly = true;
            this.fERRAMENTAOPDataGridViewTextBoxColumn.Width = 175;
            // 
            // eNTREGADIADataGridViewTextBoxColumn
            // 
            this.eNTREGADIADataGridViewTextBoxColumn.DataPropertyName = "ENTREGA_DIA";
            this.eNTREGADIADataGridViewTextBoxColumn.HeaderText = "ENTREGA_DIA";
            this.eNTREGADIADataGridViewTextBoxColumn.Name = "eNTREGADIADataGridViewTextBoxColumn";
            this.eNTREGADIADataGridViewTextBoxColumn.ReadOnly = true;
            this.eNTREGADIADataGridViewTextBoxColumn.Visible = false;
            // 
            // pRECOUNITDataGridViewTextBoxColumn
            // 
            this.pRECOUNITDataGridViewTextBoxColumn.DataPropertyName = "PRECO_UNIT";
            this.pRECOUNITDataGridViewTextBoxColumn.HeaderText = "PRECO_UNIT";
            this.pRECOUNITDataGridViewTextBoxColumn.Name = "pRECOUNITDataGridViewTextBoxColumn";
            this.pRECOUNITDataGridViewTextBoxColumn.ReadOnly = true;
            this.pRECOUNITDataGridViewTextBoxColumn.Visible = false;
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
            // qDEFABDataGridViewTextBoxColumn
            // 
            this.qDEFABDataGridViewTextBoxColumn.DataPropertyName = "QDE_FAB";
            this.qDEFABDataGridViewTextBoxColumn.HeaderText = "QDE_FAB";
            this.qDEFABDataGridViewTextBoxColumn.Name = "qDEFABDataGridViewTextBoxColumn";
            this.qDEFABDataGridViewTextBoxColumn.ReadOnly = true;
            this.qDEFABDataGridViewTextBoxColumn.Visible = false;
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
            // cLIENTEOPDataGridViewTextBoxColumn
            // 
            this.cLIENTEOPDataGridViewTextBoxColumn.DataPropertyName = "CLIENTE_OP";
            this.cLIENTEOPDataGridViewTextBoxColumn.HeaderText = "CLIENTE_OP";
            this.cLIENTEOPDataGridViewTextBoxColumn.Name = "cLIENTEOPDataGridViewTextBoxColumn";
            this.cLIENTEOPDataGridViewTextBoxColumn.ReadOnly = true;
            this.cLIENTEOPDataGridViewTextBoxColumn.Visible = false;
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
            this.ESPESSURA_OP,
            this.FUNCAO_OP,
            this.FERRAMENTA_OP,
            this.CLIENTE_OP,
            this.FINALIZADO_OP,
            this.POSICAO_ATUAL_OP});
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
            this.FERRAMENTA_OP.MaxLength = 50;
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(858, 109);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 223;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // datItens_orcamento
            // 
            this.datItens_orcamento.DeleteCommand = this.fbCommand4;
            this.datItens_orcamento.InsertCommand = this.fbCommand2;
            this.datItens_orcamento.SelectCommand = this.fbCommand1;
            this.datItens_orcamento.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * from itens_orcamento";
            this.fbCommand1.CommandTimeout = 30;
            this.fbCommand1.Connection = this.fbConnection1;
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
            // datRotas_campo
            // 
            this.datRotas_campo.DeleteCommand = this.fbCommand12;
            this.datRotas_campo.InsertCommand = this.fbCommand10;
            this.datRotas_campo.SelectCommand = this.fbCommand9;
            this.datRotas_campo.UpdateCommand = this.fbCommand11;
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
            this.fbCommand9.CommandText = "select * from rotas_campo";
            this.fbCommand9.CommandTimeout = 30;
            this.fbCommand9.Connection = this.fbConnection1;
            // 
            // fbCommand11
            // 
            this.fbCommand11.CommandTimeout = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 222;
            this.label3.Text = "Código do Item:";
            // 
            // tb_item
            // 
            this.tb_item.Location = new System.Drawing.Point(385, 63);
            this.tb_item.Name = "tb_item";
            this.tb_item.Size = new System.Drawing.Size(50, 20);
            this.tb_item.TabIndex = 221;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Evolucao.Properties.Resources.Plus;
            this.pictureBox1.Location = new System.Drawing.Point(261, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 225;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Evolucao.Properties.Resources.Search;
            this.pictureBox2.Location = new System.Drawing.Point(441, 61);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 226;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // form_pesquisa_ferramenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 716);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_item);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.tb_ferramenta);
            this.Name = "form_pesquisa_ferramenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ferramentas";
            this.Load += new System.EventHandler(this.form_pesquisa_ferramenta_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens_orcamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsItens_orcamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITENS_ORCAMENTO)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRotas_campo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRotas_campo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ROTAS_CAMPO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosicoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private System.Windows.Forms.TextBox tb_ferramenta;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datItens_orcamento;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Data.DataSet dsItens_orcamento;
        private System.Data.DataTable ITENS_ORCAMENTO;
        private System.Data.DataColumn COD_ITEM_ORC;
        private System.Data.DataColumn NOME_ITEM_ORC;
        private System.Data.DataColumn QTDE_ITEM_ORC;
        private System.Data.DataColumn HORAS_FRESA_ITEM_ORC;
        private System.Data.DataColumn HORAS_RETIFICA_ITEM_ORC;
        private System.Data.DataColumn HORAS_RET_OPT_ITEM_ORC;
        private System.Data.DataColumn HORAS_EDM_ITEM_ORC;
        private System.Data.DataColumn HORAS_TORNO_ITEM_ORC;
        private System.Data.DataColumn HORAS_EWC_ITEM_ORC;
        private System.Data.DataColumn HORAS_EWC015_ITEM_ORC;
        private System.Data.DataColumn VALOR_TOTAL_ITEM_ORC;
        private System.Data.DataColumn STATUS_ITEM_ORC;
        private System.Data.DataColumn OBS_ITEM_ORC;
        private System.Data.DataColumn COD_ORCAMENTO_ITEM_ORC;
        private System.Data.DataColumn TOTAL_HORAS_ITEM_ORC;
        private System.Data.DataColumn VALOR_UNIT_ITEM_ORC;
        private System.Data.DataColumn VALOR_MAT_PRI_ITEM_ORC;
        private System.Windows.Forms.DataGridView dgvItens_orcamento;
        private System.Windows.Forms.DataGridView dgvRotas_campo;
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
        private System.Windows.Forms.DataGridView dgvPosicoes;
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
        private System.Data.DataColumn ESPESSURA_OP;
        private System.Data.DataColumn FUNCAO_OP;
        private System.Data.DataColumn FERRAMENTA_OP;
        private System.Data.DataColumn CLIENTE_OP;
        private System.Data.DataColumn FINALIZADO_OP;
        private System.Data.DataColumn POSICAO_ATUAL_OP;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datOp;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand8;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand6;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand5;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand7;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection2;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datRotas_campo;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand12;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand10;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand9;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand11;
        private System.Windows.Forms.TextBox tb_horas_previstas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_horas_trabalhadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_operacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_horas_previstas;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod_rota;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODROTAPECADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oBSERVACAOCAMPODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESENHOCAMPODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOSICAOFILACAMPODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPERADORCAMPODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORAENTRADADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAENTRADADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORAFECHAMENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAFECHAMENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fINALIZADODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOSICAOATUALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_saldo_horas;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPROTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nPDFCAMPODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Ok;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_sem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMEITEMORCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_orc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODITEMORCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_qtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_retifica;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ret_opt;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_edm;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_torno;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ewc;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ewc015;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_item_mat_pri;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_valor_total;
        private System.Windows.Forms.DataGridViewButtonColumn Aprovado;
        private System.Windows.Forms.DataGridViewButtonColumn Reprovado;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_total_horas;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_valor_unit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESENHOOPATUALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nPDFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod_os;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONDPGTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAPDFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNTREGOUDIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qDEPDFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn fINALIZADOOPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOSICAOATUALOPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fERRAMENTAOPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNTREGADIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRECOUNITDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pESOTOTALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pDFACEITOEMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nFNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qDEESTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qDEFABDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qDEEMBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qDECAIXASDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mATERIALOPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSPESSURAOPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fUNCAOOPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTEOPDataGridViewTextBoxColumn;
    }
}