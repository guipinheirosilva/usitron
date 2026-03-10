namespace Evolucao
{
    partial class form_pesquisa_cte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_pesquisa_cte));
            this.dgvPesquisa = new System.Windows.Forms.DataGridView();
            this.col_nao_faturar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.NUMERO_LOTE_ENVIO_CTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_emitente_cnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_remetente_cnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_destinatario_cnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_expedidor_cnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_recebedor_cnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_n_cte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_data_emissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_remetente_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_destinatario_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_recebedor_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_tomador_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_tomador_cnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORMERCADOCTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_valor_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIPOFRETECTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PLACA_VEICULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHAVEACESSOCTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_protocolo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTATUSINTERNOCTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNTREGUECTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cODROMANEIOCTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMITIDOPORCTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_valor_mercado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cod_cte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nFATURACTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rECEBIDOCTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cnpj_emitente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nome_emitente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsCte = new System.Data.DataSet();
            this.CTE = new System.Data.DataTable();
            this.COD_CTE = new System.Data.DataColumn();
            this.N_CTE = new System.Data.DataColumn();
            this.DATA_EMISSAO_CTE = new System.Data.DataColumn();
            this.HORA_EMISSAO_CTE = new System.Data.DataColumn();
            this.CFOP_CTE = new System.Data.DataColumn();
            this.NATUREZA_OPERACAO_CTE = new System.Data.DataColumn();
            this.EMITENTE_NOME_CTE = new System.Data.DataColumn();
            this.EMITENTE_CNPJ_CTE = new System.Data.DataColumn();
            this.REMETENTE_NOME_CTE = new System.Data.DataColumn();
            this.REMETENTE_CNPJ_CTE = new System.Data.DataColumn();
            this.DESTINATARIO_NOME_CTE = new System.Data.DataColumn();
            this.DESTINATARIO_CNPJ_CTE = new System.Data.DataColumn();
            this.EXPEDIDOR_NOME_CTE = new System.Data.DataColumn();
            this.EXPEDIDOR_CNPJ_CTE = new System.Data.DataColumn();
            this.RECEBEDOR_NOME_CTE = new System.Data.DataColumn();
            this.RECEBEDOR_CNPJ_CTE = new System.Data.DataColumn();
            this.TOMADOR_NOME_CTE = new System.Data.DataColumn();
            this.TOMADOR_CNPJ_CTE = new System.Data.DataColumn();
            this.PESO_CTE = new System.Data.DataColumn();
            this.PESO_AFERIDO_CTE = new System.Data.DataColumn();
            this.CUBAGEM_CTE = new System.Data.DataColumn();
            this.QTDE_VOLUMES_CTE = new System.Data.DataColumn();
            this.VALOR_MERCADO_CTE = new System.Data.DataColumn();
            this.AGENDAMENTO_CTE = new System.Data.DataColumn();
            this.SUB_TOTAL_CTE = new System.Data.DataColumn();
            this.BC_CTE = new System.Data.DataColumn();
            this.ALIQ_ICMS_CTE = new System.Data.DataColumn();
            this.VALOR_ICMS_CTE = new System.Data.DataColumn();
            this.VALOR_TOTAL_CTE = new System.Data.DataColumn();
            this.TIPO_FRETE_CTE = new System.Data.DataColumn();
            this.VEICULO_CTE = new System.Data.DataColumn();
            this.PLACA_CTE = new System.Data.DataColumn();
            this.UF_CTE = new System.Data.DataColumn();
            this.OBSERVACOES_CTE = new System.Data.DataColumn();
            this.STATUS_CTE = new System.Data.DataColumn();
            this.CCT_CTE = new System.Data.DataColumn();
            this.CDV_CTE = new System.Data.DataColumn();
            this.CHAVE_ACESSO_CTE = new System.Data.DataColumn();
            this.RECIBO_CTE = new System.Data.DataColumn();
            this.PROTOCOLO_CTE = new System.Data.DataColumn();
            this.MOTIVO_CANCELA_CTE = new System.Data.DataColumn();
            this.STATUS_INTERNO_CTE = new System.Data.DataColumn();
            this.ENTREGUE_CTE = new System.Data.DataColumn();
            this.COD_ROMANEIO_CTE = new System.Data.DataColumn();
            this.COD_BARRAS_CTE = new System.Data.DataColumn();
            this.TIPO_CTE = new System.Data.DataColumn();
            this.ORIGEM_CTE = new System.Data.DataColumn();
            this.DESTINO_CTE = new System.Data.DataColumn();
            this.EMITIDO_POR_CTE = new System.Data.DataColumn();
            this.N_FATURA_CTE = new System.Data.DataColumn();
            this.RECEBIDO_CTE = new System.Data.DataColumn();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button11 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.cbStatus = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbSomar = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button21 = new System.Windows.Forms.Button();
            this.tb_tomador_cnpj = new System.Windows.Forms.TextBox();
            this.cbTomador = new System.Windows.Forms.CheckBox();
            this.label50 = new System.Windows.Forms.Label();
            this.tb_tomador_nome = new System.Windows.Forms.TextBox();
            this.label51 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbData = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtTermino = new System.Windows.Forms.DateTimePicker();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_n_nf = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_tomador = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_recebedor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_remetente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_cte = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.tb_valor_total = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.cnpjtoolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.empresatoolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.fbCommand5 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand6 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand7 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand8 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.datCte = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand12 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand10 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand9 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand11 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.button2 = new System.Windows.Forms.Button();
            this.panelFaturas = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.dtVencimento = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.cbCte = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panelSeguradora = new System.Windows.Forms.Panel();
            this.btnGerarLog = new System.Windows.Forms.Button();
            this.btnGerar = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.cbTeste = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CTE)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panelFaturas.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panelSeguradora.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPesquisa
            // 
            this.dgvPesquisa.AllowUserToAddRows = false;
            this.dgvPesquisa.AutoGenerateColumns = false;
            this.dgvPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesquisa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_nao_faturar,
            this.NUMERO_LOTE_ENVIO_CTE,
            this.col_emitente_cnpj,
            this.col_remetente_cnpj,
            this.col_destinatario_cnpj,
            this.col_expedidor_cnpj,
            this.col_recebedor_cnpj,
            this.col_n_cte,
            this.col_data_emissao,
            this.col_remetente_nome,
            this.col_destinatario_nome,
            this.col_recebedor_nome,
            this.col_tomador_nome,
            this.col_tomador_cnpj,
            this.vALORMERCADOCTEDataGridViewTextBoxColumn,
            this.col_valor_total,
            this.tIPOFRETECTEDataGridViewTextBoxColumn,
            this.PLACA_VEICULO,
            this.col_status,
            this.cHAVEACESSOCTEDataGridViewTextBoxColumn,
            this.col_protocolo,
            this.sTATUSINTERNOCTEDataGridViewTextBoxColumn,
            this.eNTREGUECTEDataGridViewTextBoxColumn,
            this.cODROMANEIOCTEDataGridViewTextBoxColumn,
            this.eMITIDOPORCTEDataGridViewTextBoxColumn,
            this.col_peso,
            this.col_valor_mercado,
            this.col_cod_cte,
            this.nFATURACTEDataGridViewTextBoxColumn,
            this.rECEBIDOCTEDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.col_cnpj_emitente,
            this.col_nome_emitente});
            this.dgvPesquisa.DataMember = "CTE";
            this.dgvPesquisa.DataSource = this.dsCte;
            this.dgvPesquisa.Location = new System.Drawing.Point(13, 181);
            this.dgvPesquisa.Name = "dgvPesquisa";
            this.dgvPesquisa.Size = new System.Drawing.Size(921, 292);
            this.dgvPesquisa.TabIndex = 0;
            this.dgvPesquisa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPesquisa_CellDoubleClick);
            this.dgvPesquisa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPesquisa_CellContentClick);
            // 
            // col_nao_faturar
            // 
            this.col_nao_faturar.DataPropertyName = "NAO_FATURAR_CTE";
            this.col_nao_faturar.FalseValue = "0";
            this.col_nao_faturar.HeaderText = "Não Faturar";
            this.col_nao_faturar.IndeterminateValue = "0";
            this.col_nao_faturar.Name = "col_nao_faturar";
            this.col_nao_faturar.TrueValue = "1";
            this.col_nao_faturar.Width = 50;
            // 
            // NUMERO_LOTE_ENVIO_CTE
            // 
            this.NUMERO_LOTE_ENVIO_CTE.DataPropertyName = "NUMERO_LOTE_ENVIO_CTE";
            this.NUMERO_LOTE_ENVIO_CTE.HeaderText = "Nº Lote Envio";
            this.NUMERO_LOTE_ENVIO_CTE.Name = "NUMERO_LOTE_ENVIO_CTE";
            this.NUMERO_LOTE_ENVIO_CTE.Width = 60;
            // 
            // col_emitente_cnpj
            // 
            this.col_emitente_cnpj.DataPropertyName = "EMITENTE_CNPJ_CTE";
            this.col_emitente_cnpj.HeaderText = "EMITENTE_CNPJ_CTE";
            this.col_emitente_cnpj.Name = "col_emitente_cnpj";
            this.col_emitente_cnpj.Visible = false;
            // 
            // col_remetente_cnpj
            // 
            this.col_remetente_cnpj.DataPropertyName = "REMETENTE_CNPJ_CTE";
            this.col_remetente_cnpj.HeaderText = "REMETENTE_CNPJ_CTE";
            this.col_remetente_cnpj.Name = "col_remetente_cnpj";
            this.col_remetente_cnpj.Visible = false;
            // 
            // col_destinatario_cnpj
            // 
            this.col_destinatario_cnpj.DataPropertyName = "DESTINATARIO_CNPJ_CTE";
            this.col_destinatario_cnpj.HeaderText = "DESTINATARIO_CNPJ_CTE";
            this.col_destinatario_cnpj.Name = "col_destinatario_cnpj";
            this.col_destinatario_cnpj.Visible = false;
            // 
            // col_expedidor_cnpj
            // 
            this.col_expedidor_cnpj.DataPropertyName = "EXPEDIDOR_CNPJ_CTE";
            this.col_expedidor_cnpj.HeaderText = "EXPEDIDOR_CNPJ_CTE";
            this.col_expedidor_cnpj.Name = "col_expedidor_cnpj";
            this.col_expedidor_cnpj.Visible = false;
            // 
            // col_recebedor_cnpj
            // 
            this.col_recebedor_cnpj.DataPropertyName = "RECEBEDOR_CNPJ_CTE";
            this.col_recebedor_cnpj.HeaderText = "RECEBEDOR_CNPJ_CTE";
            this.col_recebedor_cnpj.Name = "col_recebedor_cnpj";
            this.col_recebedor_cnpj.Visible = false;
            // 
            // col_n_cte
            // 
            this.col_n_cte.DataPropertyName = "N_CTE";
            this.col_n_cte.HeaderText = "Nº";
            this.col_n_cte.Name = "col_n_cte";
            this.col_n_cte.ReadOnly = true;
            this.col_n_cte.Width = 50;
            // 
            // col_data_emissao
            // 
            this.col_data_emissao.DataPropertyName = "DATA_EMISSAO_CTE";
            this.col_data_emissao.HeaderText = "Data de Emissão";
            this.col_data_emissao.Name = "col_data_emissao";
            this.col_data_emissao.ReadOnly = true;
            this.col_data_emissao.Width = 80;
            // 
            // col_remetente_nome
            // 
            this.col_remetente_nome.DataPropertyName = "REMETENTE_NOME_CTE";
            this.col_remetente_nome.HeaderText = "Remetente";
            this.col_remetente_nome.Name = "col_remetente_nome";
            this.col_remetente_nome.ReadOnly = true;
            // 
            // col_destinatario_nome
            // 
            this.col_destinatario_nome.DataPropertyName = "DESTINATARIO_NOME_CTE";
            this.col_destinatario_nome.HeaderText = "Destinatário";
            this.col_destinatario_nome.Name = "col_destinatario_nome";
            this.col_destinatario_nome.ReadOnly = true;
            // 
            // col_recebedor_nome
            // 
            this.col_recebedor_nome.DataPropertyName = "RECEBEDOR_NOME_CTE";
            this.col_recebedor_nome.HeaderText = "Recebedor";
            this.col_recebedor_nome.Name = "col_recebedor_nome";
            this.col_recebedor_nome.ReadOnly = true;
            // 
            // col_tomador_nome
            // 
            this.col_tomador_nome.DataPropertyName = "TOMADOR_NOME_CTE";
            this.col_tomador_nome.HeaderText = "Tomador";
            this.col_tomador_nome.Name = "col_tomador_nome";
            this.col_tomador_nome.ReadOnly = true;
            // 
            // col_tomador_cnpj
            // 
            this.col_tomador_cnpj.DataPropertyName = "TOMADOR_CNPJ_CTE";
            this.col_tomador_cnpj.HeaderText = "CNPJ Tomador";
            this.col_tomador_cnpj.Name = "col_tomador_cnpj";
            this.col_tomador_cnpj.ReadOnly = true;
            // 
            // vALORMERCADOCTEDataGridViewTextBoxColumn
            // 
            this.vALORMERCADOCTEDataGridViewTextBoxColumn.DataPropertyName = "VALOR_MERCADO_CTE";
            this.vALORMERCADOCTEDataGridViewTextBoxColumn.HeaderText = "Valor Mercado";
            this.vALORMERCADOCTEDataGridViewTextBoxColumn.Name = "vALORMERCADOCTEDataGridViewTextBoxColumn";
            this.vALORMERCADOCTEDataGridViewTextBoxColumn.ReadOnly = true;
            this.vALORMERCADOCTEDataGridViewTextBoxColumn.Width = 70;
            // 
            // col_valor_total
            // 
            this.col_valor_total.DataPropertyName = "VALOR_TOTAL_CTE";
            this.col_valor_total.HeaderText = "Valor Total";
            this.col_valor_total.Name = "col_valor_total";
            this.col_valor_total.ReadOnly = true;
            this.col_valor_total.Width = 70;
            // 
            // tIPOFRETECTEDataGridViewTextBoxColumn
            // 
            this.tIPOFRETECTEDataGridViewTextBoxColumn.DataPropertyName = "TIPO_FRETE_CTE";
            this.tIPOFRETECTEDataGridViewTextBoxColumn.HeaderText = "Pagamento";
            this.tIPOFRETECTEDataGridViewTextBoxColumn.Name = "tIPOFRETECTEDataGridViewTextBoxColumn";
            this.tIPOFRETECTEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // PLACA_VEICULO
            // 
            this.PLACA_VEICULO.DataPropertyName = "PLACA_CTE";
            this.PLACA_VEICULO.HeaderText = "Placa Veículo";
            this.PLACA_VEICULO.Name = "PLACA_VEICULO";
            // 
            // col_status
            // 
            this.col_status.DataPropertyName = "STATUS_CTE";
            this.col_status.HeaderText = "Status";
            this.col_status.Name = "col_status";
            this.col_status.ReadOnly = true;
            // 
            // cHAVEACESSOCTEDataGridViewTextBoxColumn
            // 
            this.cHAVEACESSOCTEDataGridViewTextBoxColumn.DataPropertyName = "CHAVE_ACESSO_CTE";
            this.cHAVEACESSOCTEDataGridViewTextBoxColumn.HeaderText = "Chave";
            this.cHAVEACESSOCTEDataGridViewTextBoxColumn.Name = "cHAVEACESSOCTEDataGridViewTextBoxColumn";
            this.cHAVEACESSOCTEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col_protocolo
            // 
            this.col_protocolo.DataPropertyName = "PROTOCOLO_CTE";
            this.col_protocolo.HeaderText = "Protocolo";
            this.col_protocolo.Name = "col_protocolo";
            // 
            // sTATUSINTERNOCTEDataGridViewTextBoxColumn
            // 
            this.sTATUSINTERNOCTEDataGridViewTextBoxColumn.DataPropertyName = "STATUS_INTERNO_CTE";
            this.sTATUSINTERNOCTEDataGridViewTextBoxColumn.HeaderText = "Status Interno";
            this.sTATUSINTERNOCTEDataGridViewTextBoxColumn.Name = "sTATUSINTERNOCTEDataGridViewTextBoxColumn";
            this.sTATUSINTERNOCTEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eNTREGUECTEDataGridViewTextBoxColumn
            // 
            this.eNTREGUECTEDataGridViewTextBoxColumn.DataPropertyName = "ENTREGUE_CTE";
            this.eNTREGUECTEDataGridViewTextBoxColumn.HeaderText = "Entregue";
            this.eNTREGUECTEDataGridViewTextBoxColumn.Name = "eNTREGUECTEDataGridViewTextBoxColumn";
            this.eNTREGUECTEDataGridViewTextBoxColumn.ReadOnly = true;
            this.eNTREGUECTEDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.eNTREGUECTEDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.eNTREGUECTEDataGridViewTextBoxColumn.Width = 60;
            // 
            // cODROMANEIOCTEDataGridViewTextBoxColumn
            // 
            this.cODROMANEIOCTEDataGridViewTextBoxColumn.DataPropertyName = "COD_ROMANEIO_CTE";
            this.cODROMANEIOCTEDataGridViewTextBoxColumn.HeaderText = "Cód. Romaneio";
            this.cODROMANEIOCTEDataGridViewTextBoxColumn.Name = "cODROMANEIOCTEDataGridViewTextBoxColumn";
            this.cODROMANEIOCTEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eMITIDOPORCTEDataGridViewTextBoxColumn
            // 
            this.eMITIDOPORCTEDataGridViewTextBoxColumn.DataPropertyName = "EMITIDO_POR_CTE";
            this.eMITIDOPORCTEDataGridViewTextBoxColumn.HeaderText = "Emitido Por";
            this.eMITIDOPORCTEDataGridViewTextBoxColumn.Name = "eMITIDOPORCTEDataGridViewTextBoxColumn";
            this.eMITIDOPORCTEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col_peso
            // 
            this.col_peso.DataPropertyName = "PESO_CTE";
            this.col_peso.HeaderText = "Peso";
            this.col_peso.Name = "col_peso";
            // 
            // col_valor_mercado
            // 
            this.col_valor_mercado.DataPropertyName = "VALOR_MERCADO_CTE";
            this.col_valor_mercado.HeaderText = "Valor Mercado";
            this.col_valor_mercado.Name = "col_valor_mercado";
            // 
            // col_cod_cte
            // 
            this.col_cod_cte.DataPropertyName = "COD_CTE";
            this.col_cod_cte.HeaderText = "Cód.";
            this.col_cod_cte.Name = "col_cod_cte";
            // 
            // nFATURACTEDataGridViewTextBoxColumn
            // 
            this.nFATURACTEDataGridViewTextBoxColumn.DataPropertyName = "N_FATURA_CTE";
            this.nFATURACTEDataGridViewTextBoxColumn.HeaderText = "Nº Fatura";
            this.nFATURACTEDataGridViewTextBoxColumn.Name = "nFATURACTEDataGridViewTextBoxColumn";
            this.nFATURACTEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rECEBIDOCTEDataGridViewTextBoxColumn
            // 
            this.rECEBIDOCTEDataGridViewTextBoxColumn.DataPropertyName = "RECEBIDO_CTE";
            this.rECEBIDOCTEDataGridViewTextBoxColumn.HeaderText = "Recebido";
            this.rECEBIDOCTEDataGridViewTextBoxColumn.Name = "rECEBIDOCTEDataGridViewTextBoxColumn";
            this.rECEBIDOCTEDataGridViewTextBoxColumn.ReadOnly = true;
            this.rECEBIDOCTEDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.rECEBIDOCTEDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.rECEBIDOCTEDataGridViewTextBoxColumn.Width = 60;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ORIGEM_CTE";
            this.dataGridViewTextBoxColumn6.HeaderText = "ORIGEM_CTE";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "DESTINO_CTE";
            this.dataGridViewTextBoxColumn7.HeaderText = "DESTINO_CTE";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // col_cnpj_emitente
            // 
            this.col_cnpj_emitente.DataPropertyName = "EMITENTE_CNPJ_CTE";
            this.col_cnpj_emitente.HeaderText = "CNPJ Emitente";
            this.col_cnpj_emitente.Name = "col_cnpj_emitente";
            // 
            // col_nome_emitente
            // 
            this.col_nome_emitente.DataPropertyName = "EMITENTE_NOME_CTE";
            this.col_nome_emitente.HeaderText = "Nome Emitente";
            this.col_nome_emitente.Name = "col_nome_emitente";
            // 
            // dsCte
            // 
            this.dsCte.DataSetName = "dsCte";
            this.dsCte.Namespace = "http://www.tempuri.org/dsCte.xsd";
            this.dsCte.Tables.AddRange(new System.Data.DataTable[] {
            this.CTE});
            // 
            // CTE
            // 
            this.CTE.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_CTE,
            this.N_CTE,
            this.DATA_EMISSAO_CTE,
            this.HORA_EMISSAO_CTE,
            this.CFOP_CTE,
            this.NATUREZA_OPERACAO_CTE,
            this.EMITENTE_NOME_CTE,
            this.EMITENTE_CNPJ_CTE,
            this.REMETENTE_NOME_CTE,
            this.REMETENTE_CNPJ_CTE,
            this.DESTINATARIO_NOME_CTE,
            this.DESTINATARIO_CNPJ_CTE,
            this.EXPEDIDOR_NOME_CTE,
            this.EXPEDIDOR_CNPJ_CTE,
            this.RECEBEDOR_NOME_CTE,
            this.RECEBEDOR_CNPJ_CTE,
            this.TOMADOR_NOME_CTE,
            this.TOMADOR_CNPJ_CTE,
            this.PESO_CTE,
            this.PESO_AFERIDO_CTE,
            this.CUBAGEM_CTE,
            this.QTDE_VOLUMES_CTE,
            this.VALOR_MERCADO_CTE,
            this.AGENDAMENTO_CTE,
            this.SUB_TOTAL_CTE,
            this.BC_CTE,
            this.ALIQ_ICMS_CTE,
            this.VALOR_ICMS_CTE,
            this.VALOR_TOTAL_CTE,
            this.TIPO_FRETE_CTE,
            this.VEICULO_CTE,
            this.PLACA_CTE,
            this.UF_CTE,
            this.OBSERVACOES_CTE,
            this.STATUS_CTE,
            this.CCT_CTE,
            this.CDV_CTE,
            this.CHAVE_ACESSO_CTE,
            this.RECIBO_CTE,
            this.PROTOCOLO_CTE,
            this.MOTIVO_CANCELA_CTE,
            this.STATUS_INTERNO_CTE,
            this.ENTREGUE_CTE,
            this.COD_ROMANEIO_CTE,
            this.COD_BARRAS_CTE,
            this.TIPO_CTE,
            this.ORIGEM_CTE,
            this.DESTINO_CTE,
            this.EMITIDO_POR_CTE,
            this.N_FATURA_CTE,
            this.RECEBIDO_CTE,
            this.dataColumn1,
            this.dataColumn2});
            this.CTE.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_CTE"}, true)});
            this.CTE.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_CTE};
            this.CTE.TableName = "CTE";
            // 
            // COD_CTE
            // 
            this.COD_CTE.AllowDBNull = false;
            this.COD_CTE.ColumnName = "COD_CTE";
            this.COD_CTE.DataType = typeof(int);
            // 
            // N_CTE
            // 
            this.N_CTE.ColumnName = "N_CTE";
            this.N_CTE.DataType = typeof(int);
            // 
            // DATA_EMISSAO_CTE
            // 
            this.DATA_EMISSAO_CTE.ColumnName = "DATA_EMISSAO_CTE";
            this.DATA_EMISSAO_CTE.DataType = typeof(System.DateTime);
            // 
            // HORA_EMISSAO_CTE
            // 
            this.HORA_EMISSAO_CTE.ColumnName = "HORA_EMISSAO_CTE";
            this.HORA_EMISSAO_CTE.DataType = typeof(System.DateTime);
            // 
            // CFOP_CTE
            // 
            this.CFOP_CTE.ColumnName = "CFOP_CTE";
            this.CFOP_CTE.MaxLength = 50;
            // 
            // NATUREZA_OPERACAO_CTE
            // 
            this.NATUREZA_OPERACAO_CTE.ColumnName = "NATUREZA_OPERACAO_CTE";
            this.NATUREZA_OPERACAO_CTE.MaxLength = 200;
            // 
            // EMITENTE_NOME_CTE
            // 
            this.EMITENTE_NOME_CTE.ColumnName = "EMITENTE_NOME_CTE";
            this.EMITENTE_NOME_CTE.MaxLength = 200;
            // 
            // EMITENTE_CNPJ_CTE
            // 
            this.EMITENTE_CNPJ_CTE.ColumnName = "EMITENTE_CNPJ_CTE";
            this.EMITENTE_CNPJ_CTE.MaxLength = 20;
            // 
            // REMETENTE_NOME_CTE
            // 
            this.REMETENTE_NOME_CTE.ColumnName = "REMETENTE_NOME_CTE";
            this.REMETENTE_NOME_CTE.MaxLength = 200;
            // 
            // REMETENTE_CNPJ_CTE
            // 
            this.REMETENTE_CNPJ_CTE.ColumnName = "REMETENTE_CNPJ_CTE";
            this.REMETENTE_CNPJ_CTE.MaxLength = 20;
            // 
            // DESTINATARIO_NOME_CTE
            // 
            this.DESTINATARIO_NOME_CTE.ColumnName = "DESTINATARIO_NOME_CTE";
            this.DESTINATARIO_NOME_CTE.MaxLength = 200;
            // 
            // DESTINATARIO_CNPJ_CTE
            // 
            this.DESTINATARIO_CNPJ_CTE.ColumnName = "DESTINATARIO_CNPJ_CTE";
            this.DESTINATARIO_CNPJ_CTE.MaxLength = 20;
            // 
            // EXPEDIDOR_NOME_CTE
            // 
            this.EXPEDIDOR_NOME_CTE.ColumnName = "EXPEDIDOR_NOME_CTE";
            this.EXPEDIDOR_NOME_CTE.MaxLength = 200;
            // 
            // EXPEDIDOR_CNPJ_CTE
            // 
            this.EXPEDIDOR_CNPJ_CTE.ColumnName = "EXPEDIDOR_CNPJ_CTE";
            this.EXPEDIDOR_CNPJ_CTE.MaxLength = 20;
            // 
            // RECEBEDOR_NOME_CTE
            // 
            this.RECEBEDOR_NOME_CTE.ColumnName = "RECEBEDOR_NOME_CTE";
            this.RECEBEDOR_NOME_CTE.MaxLength = 200;
            // 
            // RECEBEDOR_CNPJ_CTE
            // 
            this.RECEBEDOR_CNPJ_CTE.ColumnName = "RECEBEDOR_CNPJ_CTE";
            this.RECEBEDOR_CNPJ_CTE.MaxLength = 20;
            // 
            // TOMADOR_NOME_CTE
            // 
            this.TOMADOR_NOME_CTE.ColumnName = "TOMADOR_NOME_CTE";
            this.TOMADOR_NOME_CTE.MaxLength = 200;
            // 
            // TOMADOR_CNPJ_CTE
            // 
            this.TOMADOR_CNPJ_CTE.ColumnName = "TOMADOR_CNPJ_CTE";
            this.TOMADOR_CNPJ_CTE.MaxLength = 20;
            // 
            // PESO_CTE
            // 
            this.PESO_CTE.ColumnName = "PESO_CTE";
            this.PESO_CTE.DataType = typeof(double);
            // 
            // PESO_AFERIDO_CTE
            // 
            this.PESO_AFERIDO_CTE.ColumnName = "PESO_AFERIDO_CTE";
            this.PESO_AFERIDO_CTE.DataType = typeof(double);
            // 
            // CUBAGEM_CTE
            // 
            this.CUBAGEM_CTE.ColumnName = "CUBAGEM_CTE";
            this.CUBAGEM_CTE.DataType = typeof(double);
            // 
            // QTDE_VOLUMES_CTE
            // 
            this.QTDE_VOLUMES_CTE.ColumnName = "QTDE_VOLUMES_CTE";
            this.QTDE_VOLUMES_CTE.DataType = typeof(int);
            // 
            // VALOR_MERCADO_CTE
            // 
            this.VALOR_MERCADO_CTE.ColumnName = "VALOR_MERCADO_CTE";
            this.VALOR_MERCADO_CTE.DataType = typeof(double);
            // 
            // AGENDAMENTO_CTE
            // 
            this.AGENDAMENTO_CTE.ColumnName = "AGENDAMENTO_CTE";
            this.AGENDAMENTO_CTE.MaxLength = 200;
            // 
            // SUB_TOTAL_CTE
            // 
            this.SUB_TOTAL_CTE.ColumnName = "SUB_TOTAL_CTE";
            this.SUB_TOTAL_CTE.DataType = typeof(double);
            // 
            // BC_CTE
            // 
            this.BC_CTE.ColumnName = "BC_CTE";
            this.BC_CTE.DataType = typeof(double);
            // 
            // ALIQ_ICMS_CTE
            // 
            this.ALIQ_ICMS_CTE.ColumnName = "ALIQ_ICMS_CTE";
            this.ALIQ_ICMS_CTE.DataType = typeof(double);
            // 
            // VALOR_ICMS_CTE
            // 
            this.VALOR_ICMS_CTE.ColumnName = "VALOR_ICMS_CTE";
            this.VALOR_ICMS_CTE.DataType = typeof(double);
            // 
            // VALOR_TOTAL_CTE
            // 
            this.VALOR_TOTAL_CTE.ColumnName = "VALOR_TOTAL_CTE";
            this.VALOR_TOTAL_CTE.DataType = typeof(double);
            // 
            // TIPO_FRETE_CTE
            // 
            this.TIPO_FRETE_CTE.ColumnName = "TIPO_FRETE_CTE";
            this.TIPO_FRETE_CTE.MaxLength = 200;
            // 
            // VEICULO_CTE
            // 
            this.VEICULO_CTE.ColumnName = "VEICULO_CTE";
            this.VEICULO_CTE.MaxLength = 200;
            // 
            // PLACA_CTE
            // 
            this.PLACA_CTE.ColumnName = "PLACA_CTE";
            this.PLACA_CTE.MaxLength = 20;
            // 
            // UF_CTE
            // 
            this.UF_CTE.ColumnName = "UF_CTE";
            this.UF_CTE.MaxLength = 2;
            // 
            // OBSERVACOES_CTE
            // 
            this.OBSERVACOES_CTE.ColumnName = "OBSERVACOES_CTE";
            this.OBSERVACOES_CTE.MaxLength = 500;
            // 
            // STATUS_CTE
            // 
            this.STATUS_CTE.ColumnName = "STATUS_CTE";
            this.STATUS_CTE.MaxLength = 200;
            // 
            // CCT_CTE
            // 
            this.CCT_CTE.ColumnName = "CCT_CTE";
            this.CCT_CTE.MaxLength = 8;
            // 
            // CDV_CTE
            // 
            this.CDV_CTE.ColumnName = "CDV_CTE";
            this.CDV_CTE.MaxLength = 1;
            // 
            // CHAVE_ACESSO_CTE
            // 
            this.CHAVE_ACESSO_CTE.ColumnName = "CHAVE_ACESSO_CTE";
            this.CHAVE_ACESSO_CTE.MaxLength = 44;
            // 
            // RECIBO_CTE
            // 
            this.RECIBO_CTE.ColumnName = "RECIBO_CTE";
            this.RECIBO_CTE.MaxLength = 200;
            // 
            // PROTOCOLO_CTE
            // 
            this.PROTOCOLO_CTE.ColumnName = "PROTOCOLO_CTE";
            this.PROTOCOLO_CTE.MaxLength = 200;
            // 
            // MOTIVO_CANCELA_CTE
            // 
            this.MOTIVO_CANCELA_CTE.ColumnName = "MOTIVO_CANCELA_CTE";
            this.MOTIVO_CANCELA_CTE.MaxLength = 200;
            // 
            // STATUS_INTERNO_CTE
            // 
            this.STATUS_INTERNO_CTE.ColumnName = "STATUS_INTERNO_CTE";
            this.STATUS_INTERNO_CTE.MaxLength = 200;
            // 
            // ENTREGUE_CTE
            // 
            this.ENTREGUE_CTE.ColumnName = "ENTREGUE_CTE";
            this.ENTREGUE_CTE.DataType = typeof(int);
            // 
            // COD_ROMANEIO_CTE
            // 
            this.COD_ROMANEIO_CTE.ColumnName = "COD_ROMANEIO_CTE";
            this.COD_ROMANEIO_CTE.DataType = typeof(int);
            // 
            // COD_BARRAS_CTE
            // 
            this.COD_BARRAS_CTE.ColumnName = "COD_BARRAS_CTE";
            this.COD_BARRAS_CTE.DataType = typeof(byte[]);
            // 
            // TIPO_CTE
            // 
            this.TIPO_CTE.ColumnName = "TIPO_CTE";
            this.TIPO_CTE.MaxLength = 200;
            // 
            // ORIGEM_CTE
            // 
            this.ORIGEM_CTE.ColumnName = "ORIGEM_CTE";
            this.ORIGEM_CTE.MaxLength = 200;
            // 
            // DESTINO_CTE
            // 
            this.DESTINO_CTE.ColumnName = "DESTINO_CTE";
            this.DESTINO_CTE.MaxLength = 200;
            // 
            // EMITIDO_POR_CTE
            // 
            this.EMITIDO_POR_CTE.ColumnName = "EMITIDO_POR_CTE";
            this.EMITIDO_POR_CTE.DataType = typeof(int);
            // 
            // N_FATURA_CTE
            // 
            this.N_FATURA_CTE.ColumnName = "N_FATURA_CTE";
            this.N_FATURA_CTE.DataType = typeof(int);
            // 
            // RECEBIDO_CTE
            // 
            this.RECEBIDO_CTE.ColumnName = "RECEBIDO_CTE";
            this.RECEBIDO_CTE.DataType = typeof(int);
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "NAO_FATURAR_CTE";
            this.dataColumn1.DataType = typeof(int);
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "NUMERO_LOTE_ENVIO_CTE";
            this.dataColumn2.DataType = typeof(int);
            // 
            // fbConnection1
            // 
            this.fbConnection1.ConnectionString = resources.GetString("fbConnection1.ConnectionString");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.cbSomar);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvPesquisa);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(949, 486);
            this.panel1.TabIndex = 7;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(876, 70);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(58, 23);
            this.button11.TabIndex = 20;
            this.button11.Text = "Imprimir";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel5.Controls.Add(this.comboStatus);
            this.panel5.Controls.Add(this.cbStatus);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Location = new System.Drawing.Point(634, 7);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(180, 66);
            this.panel5.TabIndex = 9;
            // 
            // comboStatus
            // 
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Items.AddRange(new object[] {
            "CTe Autorizada",
            "CTe Cancelada",
            "CTe Inutilizada"});
            this.comboStatus.Location = new System.Drawing.Point(52, 12);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(125, 21);
            this.comboStatus.TabIndex = 5;
            // 
            // cbStatus
            // 
            this.cbStatus.AutoSize = true;
            this.cbStatus.Location = new System.Drawing.Point(62, 42);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(75, 17);
            this.cbStatus.TabIndex = 4;
            this.cbStatus.Text = "Por Status";
            this.cbStatus.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Status:";
            // 
            // cbSomar
            // 
            this.cbSomar.AutoSize = true;
            this.cbSomar.Location = new System.Drawing.Point(696, 77);
            this.cbSomar.Name = "cbSomar";
            this.cbSomar.Size = new System.Drawing.Size(56, 17);
            this.cbSomar.TabIndex = 19;
            this.cbSomar.Text = "Somar";
            this.cbSomar.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel4.Controls.Add(this.button21);
            this.panel4.Controls.Add(this.tb_tomador_cnpj);
            this.panel4.Controls.Add(this.cbTomador);
            this.panel4.Controls.Add(this.label50);
            this.panel4.Controls.Add(this.tb_tomador_nome);
            this.panel4.Controls.Add(this.label51);
            this.panel4.Location = new System.Drawing.Point(259, 7);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(369, 87);
            this.panel4.TabIndex = 9;
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(196, 7);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(18, 20);
            this.button21.TabIndex = 13;
            this.button21.Text = "+";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // tb_tomador_cnpj
            // 
            this.tb_tomador_cnpj.Location = new System.Drawing.Point(45, 8);
            this.tb_tomador_cnpj.Name = "tb_tomador_cnpj";
            this.tb_tomador_cnpj.Size = new System.Drawing.Size(145, 20);
            this.tb_tomador_cnpj.TabIndex = 12;
            this.tb_tomador_cnpj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_tomador_cnpj_KeyPress);
            // 
            // cbTomador
            // 
            this.cbTomador.AutoSize = true;
            this.cbTomador.Location = new System.Drawing.Point(149, 63);
            this.cbTomador.Name = "cbTomador";
            this.cbTomador.Size = new System.Drawing.Size(87, 17);
            this.cbTomador.TabIndex = 4;
            this.cbTomador.Text = "Por Tomador";
            this.cbTomador.UseVisualStyleBackColor = true;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(6, 12);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(37, 13);
            this.label50.TabIndex = 11;
            this.label50.Text = "CNPJ:";
            // 
            // tb_tomador_nome
            // 
            this.tb_tomador_nome.Location = new System.Drawing.Point(45, 33);
            this.tb_tomador_nome.Name = "tb_tomador_nome";
            this.tb_tomador_nome.ReadOnly = true;
            this.tb_tomador_nome.Size = new System.Drawing.Size(302, 20);
            this.tb_tomador_nome.TabIndex = 10;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(6, 37);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(38, 13);
            this.label51.TabIndex = 9;
            this.label51.Text = "Nome:";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(876, 7);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(58, 59);
            this.button9.TabIndex = 18;
            this.button9.Text = "Imprimir\r\npor\r\nCliente";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(820, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 87);
            this.button1.TabIndex = 9;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.cbData);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.dtTermino);
            this.panel3.Controls.Add(this.dtInicio);
            this.panel3.Location = new System.Drawing.Point(74, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(179, 87);
            this.panel3.TabIndex = 8;
            // 
            // cbData
            // 
            this.cbData.AutoSize = true;
            this.cbData.Location = new System.Drawing.Point(59, 63);
            this.cbData.Name = "cbData";
            this.cbData.Size = new System.Drawing.Size(68, 17);
            this.cbData.TabIndex = 4;
            this.cbData.Text = "Por Data";
            this.cbData.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Término:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Início:";
            // 
            // dtTermino
            // 
            this.dtTermino.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTermino.Location = new System.Drawing.Point(59, 37);
            this.dtTermino.Name = "dtTermino";
            this.dtTermino.Size = new System.Drawing.Size(110, 20);
            this.dtTermino.TabIndex = 1;
            // 
            // dtInicio
            // 
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicio.Location = new System.Drawing.Point(59, 11);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(110, 20);
            this.dtInicio.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.tb_n_nf);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.tb_tomador);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.tb_recebedor);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.tb_remetente);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.tb_cte);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(13, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(921, 75);
            this.panel2.TabIndex = 2;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(174, 47);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(162, 23);
            this.button5.TabIndex = 13;
            this.button5.Text = "Coloque a NF e clique aqui";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 52);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Nº NF";
            // 
            // tb_n_nf
            // 
            this.tb_n_nf.Location = new System.Drawing.Point(61, 49);
            this.tb_n_nf.Name = "tb_n_nf";
            this.tb_n_nf.Size = new System.Drawing.Size(100, 20);
            this.tb_n_nf.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(699, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Cód. Fatura:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(770, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(538, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tomador";
            // 
            // tb_tomador
            // 
            this.tb_tomador.Location = new System.Drawing.Point(593, 23);
            this.tb_tomador.Name = "tb_tomador";
            this.tb_tomador.Size = new System.Drawing.Size(100, 20);
            this.tb_tomador.TabIndex = 7;
            this.tb_tomador.TextChanged += new System.EventHandler(this.tb_tomador_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(352, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Recebedor";
            // 
            // tb_recebedor
            // 
            this.tb_recebedor.Location = new System.Drawing.Point(418, 23);
            this.tb_recebedor.Name = "tb_recebedor";
            this.tb_recebedor.Size = new System.Drawing.Size(100, 20);
            this.tb_recebedor.TabIndex = 5;
            this.tb_recebedor.TextChanged += new System.EventHandler(this.tb_recebedor_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Remetente";
            // 
            // tb_remetente
            // 
            this.tb_remetente.Location = new System.Drawing.Point(236, 23);
            this.tb_remetente.Name = "tb_remetente";
            this.tb_remetente.Size = new System.Drawing.Size(100, 20);
            this.tb_remetente.TabIndex = 3;
            this.tb_remetente.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nº CTe";
            // 
            // tb_cte
            // 
            this.tb_cte.Location = new System.Drawing.Point(61, 23);
            this.tb_cte.Name = "tb_cte";
            this.tb_cte.Size = new System.Drawing.Size(100, 20);
            this.tb_cte.TabIndex = 1;
            this.tb_cte.TextChanged += new System.EventHandler(this.tb_cte_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Filtros";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "CTE";
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
            this.fbCommand1.CommandText = "SELECT * FROM ITENS_ROMANEIO";
            this.fbCommand1.CommandTimeout = 30;
            this.fbCommand1.Connection = this.fbConnection1;
            // 
            // fbCommand3
            // 
            this.fbCommand3.CommandTimeout = 30;
            // 
            // tb_valor_total
            // 
            this.tb_valor_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_valor_total.Location = new System.Drawing.Point(768, 508);
            this.tb_valor_total.Name = "tb_valor_total";
            this.tb_valor_total.Size = new System.Drawing.Size(191, 35);
            this.tb_valor_total.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(632, 511);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 29);
            this.label9.TabIndex = 9;
            this.label9.Text = "Valor Total";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cnpjtoolStripStatusLabel,
            this.empresatoolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 627);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(973, 22);
            this.statusStrip1.TabIndex = 41;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // cnpjtoolStripStatusLabel
            // 
            this.cnpjtoolStripStatusLabel.Name = "cnpjtoolStripStatusLabel";
            this.cnpjtoolStripStatusLabel.Size = new System.Drawing.Size(118, 17);
            this.cnpjtoolStripStatusLabel.Text = "toolStripStatusLabel2";
            // 
            // empresatoolStripStatusLabel
            // 
            this.empresatoolStripStatusLabel.Name = "empresatoolStripStatusLabel";
            this.empresatoolStripStatusLabel.Size = new System.Drawing.Size(118, 17);
            this.empresatoolStripStatusLabel.Text = "toolStripStatusLabel1";
            // 
            // fbCommand5
            // 
            this.fbCommand5.CommandText = "select * from cte";
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
            // datCte
            // 
            this.datCte.DeleteCommand = this.fbCommand12;
            this.datCte.InsertCommand = this.fbCommand10;
            this.datCte.SelectCommand = this.fbCommand9;
            this.datCte.UpdateCommand = this.fbCommand11;
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
            this.fbCommand9.CommandText = "select * from cte";
            this.fbCommand9.CommandTimeout = 30;
            this.fbCommand9.Connection = this.fbConnection1;
            // 
            // fbCommand11
            // 
            this.fbCommand11.CommandTimeout = 30;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(298, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 32);
            this.button2.TabIndex = 42;
            this.button2.Text = "Gerar Faturas";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelFaturas
            // 
            this.panelFaturas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panelFaturas.Controls.Add(this.button3);
            this.panelFaturas.Controls.Add(this.dtVencimento);
            this.panelFaturas.Controls.Add(this.label10);
            this.panelFaturas.Controls.Add(this.button2);
            this.panelFaturas.Location = new System.Drawing.Point(12, 556);
            this.panelFaturas.Name = "panelFaturas";
            this.panelFaturas.Size = new System.Drawing.Size(606, 45);
            this.panelFaturas.TabIndex = 44;
            this.panelFaturas.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(443, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 32);
            this.button3.TabIndex = 46;
            this.button3.Text = "Imprimir Faturas";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            // 
            // dtVencimento
            // 
            this.dtVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtVencimento.Location = new System.Drawing.Point(108, 12);
            this.dtVencimento.Name = "dtVencimento";
            this.dtVencimento.Size = new System.Drawing.Size(93, 20);
            this.dtVencimento.TabIndex = 45;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 13);
            this.label10.TabIndex = 44;
            this.label10.Text = "Data Vencimento:";
            // 
            // cbCte
            // 
            this.cbCte.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbCte.DataAdapter = this.datCte;
            this.cbCte.QuotePrefix = "\"";
            this.cbCte.QuoteSuffix = "\"";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel7.Controls.Add(this.button4);
            this.panel7.Location = new System.Drawing.Point(12, 504);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(145, 49);
            this.panel7.TabIndex = 45;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 8);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(139, 32);
            this.button4.TabIndex = 43;
            this.button4.Text = "Selecionar Ctes";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(20, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(139, 32);
            this.button6.TabIndex = 44;
            this.button6.Text = "Criar Arquivo Seguradora";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panelSeguradora
            // 
            this.panelSeguradora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelSeguradora.Controls.Add(this.btnGerarLog);
            this.panelSeguradora.Controls.Add(this.btnGerar);
            this.panelSeguradora.Controls.Add(this.button6);
            this.panelSeguradora.Location = new System.Drawing.Point(624, 556);
            this.panelSeguradora.Name = "panelSeguradora";
            this.panelSeguradora.Size = new System.Drawing.Size(335, 45);
            this.panelSeguradora.TabIndex = 46;
            this.panelSeguradora.Visible = false;
            // 
            // btnGerarLog
            // 
            this.btnGerarLog.Location = new System.Drawing.Point(235, 22);
            this.btnGerarLog.Name = "btnGerarLog";
            this.btnGerarLog.Size = new System.Drawing.Size(97, 23);
            this.btnGerarLog.TabIndex = 46;
            this.btnGerarLog.Text = "Gerar Log";
            this.btnGerarLog.UseVisualStyleBackColor = true;
            this.btnGerarLog.Click += new System.EventHandler(this.btnGerarLog_Click);
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(235, 0);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(97, 23);
            this.btnGerar.TabIndex = 45;
            this.btnGerar.Text = "Gerar Xml";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel6.Controls.Add(this.button10);
            this.panel6.Controls.Add(this.button8);
            this.panel6.Controls.Add(this.button7);
            this.panel6.Location = new System.Drawing.Point(170, 504);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(448, 49);
            this.panel6.TabIndex = 46;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(303, 4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(139, 41);
            this.button10.TabIndex = 45;
            this.button10.Text = "Imprimir Ctes Selecionados";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(152, 4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(139, 41);
            this.button8.TabIndex = 44;
            this.button8.Text = "Consultar Status Lote";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(3, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(139, 41);
            this.button7.TabIndex = 43;
            this.button7.Text = "Enviar Ctes Selecionados";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // cbTeste
            // 
            this.cbTeste.AutoSize = true;
            this.cbTeste.Location = new System.Drawing.Point(15, 607);
            this.cbTeste.Name = "cbTeste";
            this.cbTeste.Size = new System.Drawing.Size(53, 17);
            this.cbTeste.TabIndex = 47;
            this.cbTeste.Text = "Teste";
            this.cbTeste.UseVisualStyleBackColor = true;
            // 
            // form_pesquisa_cte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 649);
            this.Controls.Add(this.cbTeste);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panelSeguradora);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panelFaturas);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_valor_total);
            this.Controls.Add(this.panel1);
            this.Name = "form_pesquisa_cte";
            this.Text = "Pesquisa CTE";
            this.Load += new System.EventHandler(this.form_pesquisa_cte_e_pedido_coleta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CTE)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panelFaturas.ResumeLayout(false);
            this.panelFaturas.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panelSeguradora.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPesquisa;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_cte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_tomador;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_recebedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_remetente;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtTermino;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox cbTomador;
        private System.Windows.Forms.CheckBox cbData;
        private System.Windows.Forms.TextBox tb_valor_total;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_tomador_cnpj;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.TextBox tb_tomador_nome;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.CheckBox cbSomar;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox comboStatus;
        private System.Windows.Forms.CheckBox cbStatus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel cnpjtoolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel empresatoolStripStatusLabel;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand8;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand6;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand5;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand7;
        private System.Data.DataSet dsCte;
        private System.Data.DataTable CTE;
        private System.Data.DataColumn COD_CTE;
        private System.Data.DataColumn N_CTE;
        private System.Data.DataColumn DATA_EMISSAO_CTE;
        private System.Data.DataColumn HORA_EMISSAO_CTE;
        private System.Data.DataColumn CFOP_CTE;
        private System.Data.DataColumn NATUREZA_OPERACAO_CTE;
        private System.Data.DataColumn EMITENTE_NOME_CTE;
        private System.Data.DataColumn EMITENTE_CNPJ_CTE;
        private System.Data.DataColumn REMETENTE_NOME_CTE;
        private System.Data.DataColumn REMETENTE_CNPJ_CTE;
        private System.Data.DataColumn DESTINATARIO_NOME_CTE;
        private System.Data.DataColumn DESTINATARIO_CNPJ_CTE;
        private System.Data.DataColumn EXPEDIDOR_NOME_CTE;
        private System.Data.DataColumn EXPEDIDOR_CNPJ_CTE;
        private System.Data.DataColumn RECEBEDOR_NOME_CTE;
        private System.Data.DataColumn RECEBEDOR_CNPJ_CTE;
        private System.Data.DataColumn TOMADOR_NOME_CTE;
        private System.Data.DataColumn TOMADOR_CNPJ_CTE;
        private System.Data.DataColumn PESO_CTE;
        private System.Data.DataColumn PESO_AFERIDO_CTE;
        private System.Data.DataColumn CUBAGEM_CTE;
        private System.Data.DataColumn QTDE_VOLUMES_CTE;
        private System.Data.DataColumn VALOR_MERCADO_CTE;
        private System.Data.DataColumn AGENDAMENTO_CTE;
        private System.Data.DataColumn SUB_TOTAL_CTE;
        private System.Data.DataColumn BC_CTE;
        private System.Data.DataColumn ALIQ_ICMS_CTE;
        private System.Data.DataColumn VALOR_ICMS_CTE;
        private System.Data.DataColumn VALOR_TOTAL_CTE;
        private System.Data.DataColumn TIPO_FRETE_CTE;
        private System.Data.DataColumn VEICULO_CTE;
        private System.Data.DataColumn PLACA_CTE;
        private System.Data.DataColumn UF_CTE;
        private System.Data.DataColumn OBSERVACOES_CTE;
        private System.Data.DataColumn STATUS_CTE;
        private System.Data.DataColumn CCT_CTE;
        private System.Data.DataColumn CDV_CTE;
        private System.Data.DataColumn CHAVE_ACESSO_CTE;
        private System.Data.DataColumn RECIBO_CTE;
        private System.Data.DataColumn PROTOCOLO_CTE;
        private System.Data.DataColumn MOTIVO_CANCELA_CTE;
        private System.Data.DataColumn STATUS_INTERNO_CTE;
        private System.Data.DataColumn ENTREGUE_CTE;
        private System.Data.DataColumn COD_ROMANEIO_CTE;
        private System.Data.DataColumn COD_BARRAS_CTE;
        private System.Data.DataColumn TIPO_CTE;
        private System.Data.DataColumn ORIGEM_CTE;
        private System.Data.DataColumn DESTINO_CTE;
        private System.Data.DataColumn EMITIDO_POR_CTE;
        private System.Data.DataColumn N_FATURA_CTE;
        private System.Data.DataColumn RECEBIDO_CTE;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datCte;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand12;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand10;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand9;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand11;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panelFaturas;
        private System.Windows.Forms.DateTimePicker dtVencimento;
        private System.Windows.Forms.Label label10;
        private System.Data.DataColumn dataColumn1;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbCte;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_n_nf;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panelSeguradora;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Button btnGerarLog;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.CheckBox cbTeste;
        private System.Data.DataColumn dataColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_nao_faturar;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMERO_LOTE_ENVIO_CTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_emitente_cnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_remetente_cnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_destinatario_cnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_expedidor_cnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_recebedor_cnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_n_cte;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_data_emissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_remetente_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_destinatario_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_recebedor_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tomador_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tomador_cnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORMERCADOCTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_valor_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIPOFRETECTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PLACA_VEICULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHAVEACESSOCTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_protocolo;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTATUSINTERNOCTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn eNTREGUECTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODROMANEIOCTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMITIDOPORCTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_valor_mercado;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod_cte;
        private System.Windows.Forms.DataGridViewTextBoxColumn nFATURACTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn rECEBIDOCTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cnpj_emitente;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nome_emitente;
        private System.Windows.Forms.Button button11;
    }
}