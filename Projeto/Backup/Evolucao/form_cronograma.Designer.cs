namespace Evolucao
{
    partial class form_cronograma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_cronograma));
            this.dgvPosicoes = new System.Windows.Forms.DataGridView();
            this.col_cod_peca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEVISAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mATERIALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSPESSURADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rOTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMEPECADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nSUBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nROTASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOSICAOPECADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsDesenhos = new System.Data.DataSet();
            this.DESENHOS = new System.Data.DataTable();
            this.COD_PECA = new System.Data.DataColumn();
            this.REVISAO = new System.Data.DataColumn();
            this.MATERIAL = new System.Data.DataColumn();
            this.ESPESSURA = new System.Data.DataColumn();
            this.CLIENTE = new System.Data.DataColumn();
            this.ROTA = new System.Data.DataColumn();
            this.NOME_PECA = new System.Data.DataColumn();
            this.N_SUB = new System.Data.DataColumn();
            this.N_ROTAS = new System.Data.DataColumn();
            this.POSICAO_PECA = new System.Data.DataColumn();
            this.tb_molde = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btOk = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
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
            this.datDesenhos = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand8 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand6 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand5 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand7 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.datRotas_campo = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand12 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand10 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand9 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand11 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.datTipos_operacoes = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand16 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand14 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand13 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand15 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsTipos_operacoes = new System.Data.DataSet();
            this.TIPOS_OPERACOES = new System.Data.DataTable();
            this.COD_TIPO = new System.Data.DataColumn();
            this.QDE_MAQUINAS = new System.Data.DataColumn();
            this.TIPO = new System.Data.DataColumn();
            this.link_fresa = new System.Windows.Forms.LinkLabel();
            this.link_torno = new System.Windows.Forms.LinkLabel();
            this.link_cnc_desb = new System.Windows.Forms.LinkLabel();
            this.link_tempera = new System.Windows.Forms.LinkLabel();
            this.link_retifica = new System.Windows.Forms.LinkLabel();
            this.link_cnc_acab = new System.Windows.Forms.LinkLabel();
            this.link_erosao_ewc = new System.Windows.Forms.LinkLabel();
            this.link_erosao_edm = new System.Windows.Forms.LinkLabel();
            this.link_polimento = new System.Windows.Forms.LinkLabel();
            this.link_montagem = new System.Windows.Forms.LinkLabel();
            this.cODROTACAMPODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPERACAOCAMPODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAENTRADAPREVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAENTRADADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAFECHAMENTOPREVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAFECHAMENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pREVISAOPRODUCAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sALDOHORASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOSICAOATUALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODNUMROTASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODROTAPECADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oBSERVACAOCAMPODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESENHOCAMPODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOSICAOFILACAMPODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORAENTRADADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORAFECHAMENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pECASPRODUZIDASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fINALIZADODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPERADORCAMPODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPROTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nPDFCAMPODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAQUINADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPERADORFINALIZADORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORASTOTAISROTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORASPARADASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oSCONJUNTASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rETRABALHOROTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORASOPERADORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAQUINAFECHAMENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oSCONJUNTASFECHAMENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosicoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDesenhos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DESENHOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRotas_campo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ROTAS_CAMPO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTipos_operacoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TIPOS_OPERACOES)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPosicoes
            // 
            this.dgvPosicoes.AllowUserToAddRows = false;
            this.dgvPosicoes.AllowUserToDeleteRows = false;
            this.dgvPosicoes.AllowUserToResizeColumns = false;
            this.dgvPosicoes.AllowUserToResizeRows = false;
            this.dgvPosicoes.AutoGenerateColumns = false;
            this.dgvPosicoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPosicoes.ColumnHeadersVisible = false;
            this.dgvPosicoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_cod_peca,
            this.rEVISAODataGridViewTextBoxColumn,
            this.mATERIALDataGridViewTextBoxColumn,
            this.eSPESSURADataGridViewTextBoxColumn,
            this.cLIENTEDataGridViewTextBoxColumn,
            this.rOTADataGridViewTextBoxColumn,
            this.nOMEPECADataGridViewTextBoxColumn,
            this.nSUBDataGridViewTextBoxColumn,
            this.nROTASDataGridViewTextBoxColumn,
            this.pOSICAOPECADataGridViewTextBoxColumn});
            this.dgvPosicoes.DataMember = "DESENHOS";
            this.dgvPosicoes.DataSource = this.dsDesenhos;
            this.dgvPosicoes.Location = new System.Drawing.Point(28, 149);
            this.dgvPosicoes.Name = "dgvPosicoes";
            this.dgvPosicoes.ReadOnly = true;
            this.dgvPosicoes.RowHeadersVisible = false;
            this.dgvPosicoes.Size = new System.Drawing.Size(126, 279);
            this.dgvPosicoes.TabIndex = 0;
            this.dgvPosicoes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPosicoes_CellContentClick);
            // 
            // col_cod_peca
            // 
            this.col_cod_peca.DataPropertyName = "COD_PECA";
            this.col_cod_peca.HeaderText = "COD_PECA";
            this.col_cod_peca.Name = "col_cod_peca";
            this.col_cod_peca.ReadOnly = true;
            this.col_cod_peca.Visible = false;
            // 
            // rEVISAODataGridViewTextBoxColumn
            // 
            this.rEVISAODataGridViewTextBoxColumn.DataPropertyName = "REVISAO";
            this.rEVISAODataGridViewTextBoxColumn.HeaderText = "REVISAO";
            this.rEVISAODataGridViewTextBoxColumn.Name = "rEVISAODataGridViewTextBoxColumn";
            this.rEVISAODataGridViewTextBoxColumn.ReadOnly = true;
            this.rEVISAODataGridViewTextBoxColumn.Visible = false;
            // 
            // mATERIALDataGridViewTextBoxColumn
            // 
            this.mATERIALDataGridViewTextBoxColumn.DataPropertyName = "MATERIAL";
            this.mATERIALDataGridViewTextBoxColumn.HeaderText = "MATERIAL";
            this.mATERIALDataGridViewTextBoxColumn.Name = "mATERIALDataGridViewTextBoxColumn";
            this.mATERIALDataGridViewTextBoxColumn.ReadOnly = true;
            this.mATERIALDataGridViewTextBoxColumn.Visible = false;
            // 
            // eSPESSURADataGridViewTextBoxColumn
            // 
            this.eSPESSURADataGridViewTextBoxColumn.DataPropertyName = "ESPESSURA";
            this.eSPESSURADataGridViewTextBoxColumn.HeaderText = "ESPESSURA";
            this.eSPESSURADataGridViewTextBoxColumn.Name = "eSPESSURADataGridViewTextBoxColumn";
            this.eSPESSURADataGridViewTextBoxColumn.ReadOnly = true;
            this.eSPESSURADataGridViewTextBoxColumn.Visible = false;
            // 
            // cLIENTEDataGridViewTextBoxColumn
            // 
            this.cLIENTEDataGridViewTextBoxColumn.DataPropertyName = "CLIENTE";
            this.cLIENTEDataGridViewTextBoxColumn.HeaderText = "CLIENTE";
            this.cLIENTEDataGridViewTextBoxColumn.Name = "cLIENTEDataGridViewTextBoxColumn";
            this.cLIENTEDataGridViewTextBoxColumn.ReadOnly = true;
            this.cLIENTEDataGridViewTextBoxColumn.Visible = false;
            // 
            // rOTADataGridViewTextBoxColumn
            // 
            this.rOTADataGridViewTextBoxColumn.DataPropertyName = "ROTA";
            this.rOTADataGridViewTextBoxColumn.HeaderText = "ROTA";
            this.rOTADataGridViewTextBoxColumn.Name = "rOTADataGridViewTextBoxColumn";
            this.rOTADataGridViewTextBoxColumn.ReadOnly = true;
            this.rOTADataGridViewTextBoxColumn.Visible = false;
            // 
            // nOMEPECADataGridViewTextBoxColumn
            // 
            this.nOMEPECADataGridViewTextBoxColumn.DataPropertyName = "NOME_PECA";
            this.nOMEPECADataGridViewTextBoxColumn.HeaderText = "NOME_PECA";
            this.nOMEPECADataGridViewTextBoxColumn.Name = "nOMEPECADataGridViewTextBoxColumn";
            this.nOMEPECADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nSUBDataGridViewTextBoxColumn
            // 
            this.nSUBDataGridViewTextBoxColumn.DataPropertyName = "N_SUB";
            this.nSUBDataGridViewTextBoxColumn.HeaderText = "N_SUB";
            this.nSUBDataGridViewTextBoxColumn.Name = "nSUBDataGridViewTextBoxColumn";
            this.nSUBDataGridViewTextBoxColumn.ReadOnly = true;
            this.nSUBDataGridViewTextBoxColumn.Visible = false;
            // 
            // nROTASDataGridViewTextBoxColumn
            // 
            this.nROTASDataGridViewTextBoxColumn.DataPropertyName = "N_ROTAS";
            this.nROTASDataGridViewTextBoxColumn.HeaderText = "N_ROTAS";
            this.nROTASDataGridViewTextBoxColumn.Name = "nROTASDataGridViewTextBoxColumn";
            this.nROTASDataGridViewTextBoxColumn.ReadOnly = true;
            this.nROTASDataGridViewTextBoxColumn.Visible = false;
            // 
            // pOSICAOPECADataGridViewTextBoxColumn
            // 
            this.pOSICAOPECADataGridViewTextBoxColumn.DataPropertyName = "POSICAO_PECA";
            this.pOSICAOPECADataGridViewTextBoxColumn.HeaderText = "POSICAO_PECA";
            this.pOSICAOPECADataGridViewTextBoxColumn.Name = "pOSICAOPECADataGridViewTextBoxColumn";
            this.pOSICAOPECADataGridViewTextBoxColumn.ReadOnly = true;
            this.pOSICAOPECADataGridViewTextBoxColumn.Visible = false;
            // 
            // dsDesenhos
            // 
            this.dsDesenhos.DataSetName = "dsDesenhos";
            this.dsDesenhos.Namespace = "http://www.tempuri.org/dsDesenhos.xsd";
            this.dsDesenhos.Tables.AddRange(new System.Data.DataTable[] {
            this.DESENHOS});
            // 
            // DESENHOS
            // 
            this.DESENHOS.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_PECA,
            this.REVISAO,
            this.MATERIAL,
            this.ESPESSURA,
            this.CLIENTE,
            this.ROTA,
            this.NOME_PECA,
            this.N_SUB,
            this.N_ROTAS,
            this.POSICAO_PECA});
            this.DESENHOS.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_PECA"}, true)});
            this.DESENHOS.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_PECA};
            this.DESENHOS.TableName = "DESENHOS";
            // 
            // COD_PECA
            // 
            this.COD_PECA.AllowDBNull = false;
            this.COD_PECA.ColumnName = "COD_PECA";
            this.COD_PECA.MaxLength = 20;
            // 
            // REVISAO
            // 
            this.REVISAO.ColumnName = "REVISAO";
            this.REVISAO.MaxLength = 10;
            // 
            // MATERIAL
            // 
            this.MATERIAL.ColumnName = "MATERIAL";
            this.MATERIAL.MaxLength = 30;
            // 
            // ESPESSURA
            // 
            this.ESPESSURA.ColumnName = "ESPESSURA";
            this.ESPESSURA.MaxLength = 10;
            // 
            // CLIENTE
            // 
            this.CLIENTE.ColumnName = "CLIENTE";
            this.CLIENTE.MaxLength = 40;
            // 
            // ROTA
            // 
            this.ROTA.ColumnName = "ROTA";
            this.ROTA.DataType = typeof(int);
            // 
            // NOME_PECA
            // 
            this.NOME_PECA.ColumnName = "NOME_PECA";
            this.NOME_PECA.MaxLength = 30;
            // 
            // N_SUB
            // 
            this.N_SUB.ColumnName = "N_SUB";
            this.N_SUB.DataType = typeof(int);
            // 
            // N_ROTAS
            // 
            this.N_ROTAS.ColumnName = "N_ROTAS";
            this.N_ROTAS.DataType = typeof(int);
            // 
            // POSICAO_PECA
            // 
            this.POSICAO_PECA.ColumnName = "POSICAO_PECA";
            this.POSICAO_PECA.MaxLength = 15;
            // 
            // tb_molde
            // 
            this.tb_molde.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_molde.Location = new System.Drawing.Point(28, 62);
            this.tb_molde.Name = "tb_molde";
            this.tb_molde.Size = new System.Drawing.Size(100, 38);
            this.tb_molde.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Molde";
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(134, 62);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(34, 38);
            this.btOk.TabIndex = 3;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Posições";
            // 
            // dgvRotas
            // 
            this.dgvRotas.AllowUserToAddRows = false;
            this.dgvRotas.AutoGenerateColumns = false;
            this.dgvRotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODROTACAMPODataGridViewTextBoxColumn,
            this.oPERACAOCAMPODataGridViewTextBoxColumn,
            this.dATAENTRADAPREVDataGridViewTextBoxColumn,
            this.dATAENTRADADataGridViewTextBoxColumn,
            this.dATAFECHAMENTOPREVDataGridViewTextBoxColumn,
            this.dATAFECHAMENTODataGridViewTextBoxColumn,
            this.pREVISAOPRODUCAODataGridViewTextBoxColumn,
            this.sALDOHORASDataGridViewTextBoxColumn,
            this.pOSICAOATUALDataGridViewTextBoxColumn,
            this.cODNUMROTASDataGridViewTextBoxColumn,
            this.cODROTAPECADataGridViewTextBoxColumn,
            this.oBSERVACAOCAMPODataGridViewTextBoxColumn,
            this.dESENHOCAMPODataGridViewTextBoxColumn,
            this.pOSICAOFILACAMPODataGridViewTextBoxColumn,
            this.hORAENTRADADataGridViewTextBoxColumn,
            this.hORAFECHAMENTODataGridViewTextBoxColumn,
            this.pECASPRODUZIDASDataGridViewTextBoxColumn,
            this.fINALIZADODataGridViewTextBoxColumn,
            this.oPERADORCAMPODataGridViewTextBoxColumn,
            this.oPROTADataGridViewTextBoxColumn,
            this.nPDFCAMPODataGridViewTextBoxColumn,
            this.mAQUINADataGridViewTextBoxColumn,
            this.oPERADORFINALIZADORDataGridViewTextBoxColumn,
            this.hORASTOTAISROTADataGridViewTextBoxColumn,
            this.hORASPARADASDataGridViewTextBoxColumn,
            this.oSCONJUNTASDataGridViewTextBoxColumn,
            this.rETRABALHOROTADataGridViewTextBoxColumn,
            this.hORASOPERADORDataGridViewTextBoxColumn,
            this.mAQUINAFECHAMENTODataGridViewTextBoxColumn,
            this.oSCONJUNTASFECHAMENTODataGridViewTextBoxColumn});
            this.dgvRotas.DataMember = "ROTAS_CAMPO";
            this.dgvRotas.DataSource = this.dsRotas_campo;
            this.dgvRotas.Location = new System.Drawing.Point(175, 149);
            this.dgvRotas.Name = "dgvRotas";
            this.dgvRotas.Size = new System.Drawing.Size(537, 279);
            this.dgvRotas.TabIndex = 5;
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
            // datDesenhos
            // 
            this.datDesenhos.DeleteCommand = this.fbCommand4;
            this.datDesenhos.InsertCommand = this.fbCommand2;
            this.datDesenhos.SelectCommand = this.fbCommand1;
            this.datDesenhos.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * from desenhos order by posicao_peca";
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
            this.fbCommand5.CommandText = "select * from rotas_campo order by cod_rota_campo";
            this.fbCommand5.CommandTimeout = 30;
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
            this.fbCommand9.CommandText = "select * from rotas_campo order by cod_rota_campo";
            this.fbCommand9.CommandTimeout = 30;
            this.fbCommand9.Connection = this.fbConnection1;
            // 
            // fbCommand11
            // 
            this.fbCommand11.CommandTimeout = 30;
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
            this.fbCommand13.CommandText = "select * from tipos_operacoes order by cod_tipo";
            this.fbCommand13.CommandTimeout = 30;
            this.fbCommand13.Connection = this.fbConnection1;
            // 
            // fbCommand15
            // 
            this.fbCommand15.CommandTimeout = 30;
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
            // link_fresa
            // 
            this.link_fresa.AutoSize = true;
            this.link_fresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_fresa.Location = new System.Drawing.Point(178, 131);
            this.link_fresa.Name = "link_fresa";
            this.link_fresa.Size = new System.Drawing.Size(29, 12);
            this.link_fresa.TabIndex = 6;
            this.link_fresa.TabStop = true;
            this.link_fresa.Text = "Fresa";
            this.link_fresa.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_fresa_LinkClicked);
            // 
            // link_torno
            // 
            this.link_torno.AutoSize = true;
            this.link_torno.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_torno.Location = new System.Drawing.Point(213, 131);
            this.link_torno.Name = "link_torno";
            this.link_torno.Size = new System.Drawing.Size(28, 12);
            this.link_torno.TabIndex = 7;
            this.link_torno.TabStop = true;
            this.link_torno.Text = "Torno";
            this.link_torno.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_torno_LinkClicked);
            // 
            // link_cnc_desb
            // 
            this.link_cnc_desb.AutoSize = true;
            this.link_cnc_desb.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_cnc_desb.Location = new System.Drawing.Point(247, 131);
            this.link_cnc_desb.Name = "link_cnc_desb";
            this.link_cnc_desb.Size = new System.Drawing.Size(74, 12);
            this.link_cnc_desb.TabIndex = 8;
            this.link_cnc_desb.TabStop = true;
            this.link_cnc_desb.Text = "CNC (Desbaste)";
            this.link_cnc_desb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_cnc_desb_LinkClicked);
            // 
            // link_tempera
            // 
            this.link_tempera.AutoSize = true;
            this.link_tempera.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_tempera.Location = new System.Drawing.Point(327, 131);
            this.link_tempera.Name = "link_tempera";
            this.link_tempera.Size = new System.Drawing.Size(41, 12);
            this.link_tempera.TabIndex = 9;
            this.link_tempera.TabStop = true;
            this.link_tempera.Text = "Têmpera";
            this.link_tempera.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_tempera_LinkClicked);
            // 
            // link_retifica
            // 
            this.link_retifica.AutoSize = true;
            this.link_retifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_retifica.Location = new System.Drawing.Point(374, 131);
            this.link_retifica.Name = "link_retifica";
            this.link_retifica.Size = new System.Drawing.Size(37, 12);
            this.link_retifica.TabIndex = 10;
            this.link_retifica.TabStop = true;
            this.link_retifica.Text = "Retífica";
            this.link_retifica.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_retifica_LinkClicked);
            // 
            // link_cnc_acab
            // 
            this.link_cnc_acab.AutoSize = true;
            this.link_cnc_acab.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_cnc_acab.Location = new System.Drawing.Point(417, 131);
            this.link_cnc_acab.Name = "link_cnc_acab";
            this.link_cnc_acab.Size = new System.Drawing.Size(59, 12);
            this.link_cnc_acab.TabIndex = 11;
            this.link_cnc_acab.TabStop = true;
            this.link_cnc_acab.Text = "CNC (Acab.)";
            this.link_cnc_acab.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_cnc_acab_LinkClicked);
            // 
            // link_erosao_ewc
            // 
            this.link_erosao_ewc.AutoSize = true;
            this.link_erosao_ewc.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_erosao_ewc.Location = new System.Drawing.Point(482, 131);
            this.link_erosao_ewc.Name = "link_erosao_ewc";
            this.link_erosao_ewc.Size = new System.Drawing.Size(64, 12);
            this.link_erosao_ewc.TabIndex = 12;
            this.link_erosao_ewc.TabStop = true;
            this.link_erosao_ewc.Text = "Erosão (EWC)";
            this.link_erosao_ewc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_erosao_ewc_LinkClicked);
            // 
            // link_erosao_edm
            // 
            this.link_erosao_edm.AutoSize = true;
            this.link_erosao_edm.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_erosao_edm.Location = new System.Drawing.Point(546, 131);
            this.link_erosao_edm.Name = "link_erosao_edm";
            this.link_erosao_edm.Size = new System.Drawing.Size(64, 12);
            this.link_erosao_edm.TabIndex = 13;
            this.link_erosao_edm.TabStop = true;
            this.link_erosao_edm.Text = "Erosão (EDM)";
            this.link_erosao_edm.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_erosao_edm_LinkClicked);
            // 
            // link_polimento
            // 
            this.link_polimento.AutoSize = true;
            this.link_polimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_polimento.Location = new System.Drawing.Point(610, 131);
            this.link_polimento.Name = "link_polimento";
            this.link_polimento.Size = new System.Drawing.Size(46, 12);
            this.link_polimento.TabIndex = 14;
            this.link_polimento.TabStop = true;
            this.link_polimento.Text = "Polimento";
            this.link_polimento.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_erosao_polimento_LinkClicked);
            // 
            // link_montagem
            // 
            this.link_montagem.AutoSize = true;
            this.link_montagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_montagem.Location = new System.Drawing.Point(662, 131);
            this.link_montagem.Name = "link_montagem";
            this.link_montagem.Size = new System.Drawing.Size(50, 12);
            this.link_montagem.TabIndex = 15;
            this.link_montagem.TabStop = true;
            this.link_montagem.Text = "Montagem";
            this.link_montagem.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_montagem_LinkClicked);
            // 
            // cODROTACAMPODataGridViewTextBoxColumn
            // 
            this.cODROTACAMPODataGridViewTextBoxColumn.DataPropertyName = "COD_ROTA_CAMPO";
            this.cODROTACAMPODataGridViewTextBoxColumn.HeaderText = "Cód.";
            this.cODROTACAMPODataGridViewTextBoxColumn.Name = "cODROTACAMPODataGridViewTextBoxColumn";
            this.cODROTACAMPODataGridViewTextBoxColumn.Width = 50;
            // 
            // oPERACAOCAMPODataGridViewTextBoxColumn
            // 
            this.oPERACAOCAMPODataGridViewTextBoxColumn.DataPropertyName = "OPERACAO_CAMPO";
            this.oPERACAOCAMPODataGridViewTextBoxColumn.HeaderText = "Operação";
            this.oPERACAOCAMPODataGridViewTextBoxColumn.Name = "oPERACAOCAMPODataGridViewTextBoxColumn";
            this.oPERACAOCAMPODataGridViewTextBoxColumn.Width = 70;
            // 
            // dATAENTRADAPREVDataGridViewTextBoxColumn
            // 
            this.dATAENTRADAPREVDataGridViewTextBoxColumn.DataPropertyName = "DATA_ENTRADA_PREV";
            this.dATAENTRADAPREVDataGridViewTextBoxColumn.HeaderText = "Inicio Prev";
            this.dATAENTRADAPREVDataGridViewTextBoxColumn.Name = "dATAENTRADAPREVDataGridViewTextBoxColumn";
            this.dATAENTRADAPREVDataGridViewTextBoxColumn.Width = 60;
            // 
            // dATAENTRADADataGridViewTextBoxColumn
            // 
            this.dATAENTRADADataGridViewTextBoxColumn.DataPropertyName = "DATA_ENTRADA";
            this.dATAENTRADADataGridViewTextBoxColumn.HeaderText = "Inicio Real";
            this.dATAENTRADADataGridViewTextBoxColumn.Name = "dATAENTRADADataGridViewTextBoxColumn";
            this.dATAENTRADADataGridViewTextBoxColumn.Width = 60;
            // 
            // dATAFECHAMENTOPREVDataGridViewTextBoxColumn
            // 
            this.dATAFECHAMENTOPREVDataGridViewTextBoxColumn.DataPropertyName = "DATA_FECHAMENTO_PREV";
            this.dATAFECHAMENTOPREVDataGridViewTextBoxColumn.HeaderText = "Fim Prev";
            this.dATAFECHAMENTOPREVDataGridViewTextBoxColumn.Name = "dATAFECHAMENTOPREVDataGridViewTextBoxColumn";
            this.dATAFECHAMENTOPREVDataGridViewTextBoxColumn.Width = 60;
            // 
            // dATAFECHAMENTODataGridViewTextBoxColumn
            // 
            this.dATAFECHAMENTODataGridViewTextBoxColumn.DataPropertyName = "DATA_FECHAMENTO";
            this.dATAFECHAMENTODataGridViewTextBoxColumn.HeaderText = "Fim Real";
            this.dATAFECHAMENTODataGridViewTextBoxColumn.Name = "dATAFECHAMENTODataGridViewTextBoxColumn";
            this.dATAFECHAMENTODataGridViewTextBoxColumn.Width = 60;
            // 
            // pREVISAOPRODUCAODataGridViewTextBoxColumn
            // 
            this.pREVISAOPRODUCAODataGridViewTextBoxColumn.DataPropertyName = "PREVISAO_PRODUCAO";
            this.pREVISAOPRODUCAODataGridViewTextBoxColumn.HeaderText = "Horas Prev";
            this.pREVISAOPRODUCAODataGridViewTextBoxColumn.Name = "pREVISAOPRODUCAODataGridViewTextBoxColumn";
            this.pREVISAOPRODUCAODataGridViewTextBoxColumn.Width = 40;
            // 
            // sALDOHORASDataGridViewTextBoxColumn
            // 
            this.sALDOHORASDataGridViewTextBoxColumn.DataPropertyName = "SALDO_HORAS";
            this.sALDOHORASDataGridViewTextBoxColumn.HeaderText = "Horas Reais";
            this.sALDOHORASDataGridViewTextBoxColumn.Name = "sALDOHORASDataGridViewTextBoxColumn";
            this.sALDOHORASDataGridViewTextBoxColumn.Width = 40;
            // 
            // pOSICAOATUALDataGridViewTextBoxColumn
            // 
            this.pOSICAOATUALDataGridViewTextBoxColumn.DataPropertyName = "POSICAO_ATUAL";
            this.pOSICAOATUALDataGridViewTextBoxColumn.HeaderText = "Posição";
            this.pOSICAOATUALDataGridViewTextBoxColumn.Name = "pOSICAOATUALDataGridViewTextBoxColumn";
            this.pOSICAOATUALDataGridViewTextBoxColumn.Visible = false;
            this.pOSICAOATUALDataGridViewTextBoxColumn.Width = 70;
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
            // hORAENTRADADataGridViewTextBoxColumn
            // 
            this.hORAENTRADADataGridViewTextBoxColumn.DataPropertyName = "HORA_ENTRADA";
            this.hORAENTRADADataGridViewTextBoxColumn.HeaderText = "HORA_ENTRADA";
            this.hORAENTRADADataGridViewTextBoxColumn.Name = "hORAENTRADADataGridViewTextBoxColumn";
            this.hORAENTRADADataGridViewTextBoxColumn.Visible = false;
            // 
            // hORAFECHAMENTODataGridViewTextBoxColumn
            // 
            this.hORAFECHAMENTODataGridViewTextBoxColumn.DataPropertyName = "HORA_FECHAMENTO";
            this.hORAFECHAMENTODataGridViewTextBoxColumn.HeaderText = "HORA_FECHAMENTO";
            this.hORAFECHAMENTODataGridViewTextBoxColumn.Name = "hORAFECHAMENTODataGridViewTextBoxColumn";
            this.hORAFECHAMENTODataGridViewTextBoxColumn.Visible = false;
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
            // nPDFCAMPODataGridViewTextBoxColumn
            // 
            this.nPDFCAMPODataGridViewTextBoxColumn.DataPropertyName = "N_PDF_CAMPO";
            this.nPDFCAMPODataGridViewTextBoxColumn.HeaderText = "Pos";
            this.nPDFCAMPODataGridViewTextBoxColumn.Name = "nPDFCAMPODataGridViewTextBoxColumn";
            this.nPDFCAMPODataGridViewTextBoxColumn.Width = 40;
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
            // form_cronograma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 455);
            this.Controls.Add(this.link_montagem);
            this.Controls.Add(this.link_polimento);
            this.Controls.Add(this.link_erosao_edm);
            this.Controls.Add(this.link_erosao_ewc);
            this.Controls.Add(this.link_cnc_acab);
            this.Controls.Add(this.link_retifica);
            this.Controls.Add(this.link_tempera);
            this.Controls.Add(this.link_cnc_desb);
            this.Controls.Add(this.link_torno);
            this.Controls.Add(this.link_fresa);
            this.Controls.Add(this.dgvRotas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_molde);
            this.Controls.Add(this.dgvPosicoes);
            this.Name = "form_cronograma";
            this.Text = "Cronograma Detalhado";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosicoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDesenhos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DESENHOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRotas_campo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ROTAS_CAMPO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTipos_operacoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TIPOS_OPERACOES)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPosicoes;
        private System.Windows.Forms.TextBox tb_molde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvRotas;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datDesenhos;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Data.DataSet dsDesenhos;
        private System.Data.DataTable DESENHOS;
        private System.Data.DataColumn COD_PECA;
        private System.Data.DataColumn REVISAO;
        private System.Data.DataColumn MATERIAL;
        private System.Data.DataColumn ESPESSURA;
        private System.Data.DataColumn CLIENTE;
        private System.Data.DataColumn ROTA;
        private System.Data.DataColumn NOME_PECA;
        private System.Data.DataColumn N_SUB;
        private System.Data.DataColumn N_ROTAS;
        private System.Data.DataColumn POSICAO_PECA;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand8;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand6;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand5;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand7;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datRotas_campo;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand12;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand10;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand9;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand11;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod_peca;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEVISAODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mATERIALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSPESSURADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rOTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMEPECADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nSUBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nROTASDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOSICAOPECADataGridViewTextBoxColumn;
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
        private System.Windows.Forms.LinkLabel link_fresa;
        private System.Windows.Forms.LinkLabel link_torno;
        private System.Windows.Forms.LinkLabel link_cnc_desb;
        private System.Windows.Forms.LinkLabel link_tempera;
        private System.Windows.Forms.LinkLabel link_retifica;
        private System.Windows.Forms.LinkLabel link_cnc_acab;
        private System.Windows.Forms.LinkLabel link_erosao_ewc;
        private System.Windows.Forms.LinkLabel link_erosao_edm;
        private System.Windows.Forms.LinkLabel link_polimento;
        private System.Windows.Forms.LinkLabel link_montagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODROTACAMPODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPERACAOCAMPODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAENTRADAPREVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAENTRADADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAFECHAMENTOPREVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAFECHAMENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pREVISAOPRODUCAODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sALDOHORASDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOSICAOATUALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODNUMROTASDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODROTAPECADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oBSERVACAOCAMPODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESENHOCAMPODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOSICAOFILACAMPODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORAENTRADADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORAFECHAMENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pECASPRODUZIDASDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fINALIZADODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPERADORCAMPODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPROTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nPDFCAMPODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAQUINADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPERADORFINALIZADORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORASTOTAISROTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORASPARADASDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oSCONJUNTASDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rETRABALHOROTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORASOPERADORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAQUINAFECHAMENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oSCONJUNTASFECHAMENTODataGridViewTextBoxColumn;
    }
}