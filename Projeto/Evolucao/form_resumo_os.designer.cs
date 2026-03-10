namespace Evolucao
{
    partial class form_resumo_os
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_resumo_os));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dsItens_ped = new System.Data.DataSet();
            this.ITENS_PEDIDO_COMPRA = new System.Data.DataTable();
            this.COD_ITEM_PED = new System.Data.DataColumn();
            this.N_PEDIDO_ITEM_PED = new System.Data.DataColumn();
            this.COD_ITEM_REQ_ITEM_PED = new System.Data.DataColumn();
            this.OP_ITEM_PED = new System.Data.DataColumn();
            this.QTDE_ITEM_PED = new System.Data.DataColumn();
            this.UNID_ITEM_PED = new System.Data.DataColumn();
            this.VALOR_UNIT_ITEM_PED = new System.Data.DataColumn();
            this.VALOR_TOTAL_ITEM_PED = new System.Data.DataColumn();
            this.DESCRICAO_ITEM_PED = new System.Data.DataColumn();
            this.DATA_LIMITE_ITEM_PED = new System.Data.DataColumn();
            this.COD_ESTOQUE_ITEM_PED = new System.Data.DataColumn();
            this.POSICAO_ITEM_PED = new System.Data.DataColumn();
            this.PESO_ITEM_PED = new System.Data.DataColumn();
            this.CHEGOU_ITEM_PED = new System.Data.DataColumn();
            this.COD_NF_ENTRADA_ITEM_PED = new System.Data.DataColumn();
            this.DATA_ENTRADA_ITEM_PED = new System.Data.DataColumn();
            this.PLANO_ITEM_PED = new System.Data.DataColumn();
            this.ITEM_ITEM_PED = new System.Data.DataColumn();
            this.FORNECEDOR_ITEM_PED = new System.Data.DataColumn();
            this.dataColumn7 = new System.Data.DataColumn();
            this.dataColumn8 = new System.Data.DataColumn();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.datItens_ped = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dgvItens_ped = new System.Windows.Forms.DataGridView();
            this.col_valor_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cod_estoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_qtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_unid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_valor_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Req = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dATALIMITEITEMPEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPITEMPEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_chegou = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.col_nf_entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA_CHEGADA_ITEM_PED = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_lote_compras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_forn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbSomarCompras = new System.Windows.Forms.CheckBox();
            this.tb_valor_compras = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tb_posicoes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvPosicoes = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_valor_terceiros = new System.Windows.Forms.TextBox();
            this.datItens_terceiros = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand5 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand6 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand7 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand8 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsItens_terceiros = new System.Data.DataSet();
            this.ITENS_TERCEIROS = new System.Data.DataTable();
            this.COD_ITEM_TERCEIRO = new System.Data.DataColumn();
            this.OS_ITEM_TERCEIRO = new System.Data.DataColumn();
            this.POSICAO_ITEM_TERCEIRO = new System.Data.DataColumn();
            this.OPERACAO_ITEM_TERCEIRO = new System.Data.DataColumn();
            this.QTDE_ITEM_TERCEIRO = new System.Data.DataColumn();
            this.HORAS_ITEM_TERCEIRO = new System.Data.DataColumn();
            this.DATA_SAIDA_ITEM_TERCEIRO = new System.Data.DataColumn();
            this.HORA_SAIDA_ITEM_TERCEIRO = new System.Data.DataColumn();
            this.DATA_ENTRADA_ITEM_TERCEIRO = new System.Data.DataColumn();
            this.HORA_ENTRADA_ITEM_TERCEIRO = new System.Data.DataColumn();
            this.DATA_PREVISTA_ITEM_TERCEIRO = new System.Data.DataColumn();
            this.COD_FORN_ITEM_TERCEIRO = new System.Data.DataColumn();
            this.NOME_FORN_ITEM_TERCEIRO = new System.Data.DataColumn();
            this.COD_TERCEIRO_ITEM_TERCEIRO = new System.Data.DataColumn();
            this.VALOR_ITEM_TERCEIRO = new System.Data.DataColumn();
            this.DIMENSOES_ITEM_TERCEIRO = new System.Data.DataColumn();
            this.MATERIAL_ITEM_TERCEIRO = new System.Data.DataColumn();
            this.DUREZA_ITEM_TERCEIRO = new System.Data.DataColumn();
            this.N_LOTE_ITEM_TERCEIRO = new System.Data.DataColumn();
            this.DUREZA_ENC_ITEM_TERCEIRO = new System.Data.DataColumn();
            this.OBSERVACAO_ITEM_TERCEIRO = new System.Data.DataColumn();
            this.RESP_MEDICAO_ITEM_TERCEIRO = new System.Data.DataColumn();
            this.ROTA_ITEM_TERCEIRO = new System.Data.DataColumn();
            this.OPERADOR_ITEM_TERCEIRO = new System.Data.DataColumn();
            this.FERRAMENTA_ITEM_TERCEIRO = new System.Data.DataColumn();
            this.ITEM_ITEM_TERCEIRO = new System.Data.DataColumn();
            this.dgvItens_terceiros = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_horas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_operacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_rota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_os = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_posicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_qt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_operador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATASAIDAITEMTERCEIRODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORASAIDAITEMTERCEIRODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAENTRADAITEMTERCEIRODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORAENTRADAITEMTERCEIRODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAPREVISTAITEMTERCEIRODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODFORNITEMTERCEIRODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbSomarTerceiros = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.QTDE_AP = new System.Data.DataColumn();
            this.RETRABALHO_AP = new System.Data.DataColumn();
            this.MOTIVO_PARADA_AP = new System.Data.DataColumn();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.datApontamentos = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbSomarServicos = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_valor_servicos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvApontamentos = new System.Windows.Forms.DataGridView();
            this.fbCommand9 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsSaida_estoque = new System.Data.DataSet();
            this.ESTOQUE_SAIDA = new System.Data.DataTable();
            this.COD_ESTOQUE_SAIDA = new System.Data.DataColumn();
            this.ITEM_ESTOQUE_SAIDA = new System.Data.DataColumn();
            this.COD_ITEM_ESTOQUE_SAIDA = new System.Data.DataColumn();
            this.QTDE_ESTOQUE_SAIDA = new System.Data.DataColumn();
            this.CRACHA_ESTOQUE_SAIDA = new System.Data.DataColumn();
            this.OP_ESTOQUE_SAIDA = new System.Data.DataColumn();
            this.DATA_ESTOQUE_SAIDA = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.datSaida_estoque = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand10 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand11 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cbSomarSaidasEstoque = new System.Windows.Forms.CheckBox();
            this.tb_valor_saidas_estoque = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvSaidas = new System.Windows.Forms.DataGridView();
            this.col_cod_saida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTEMESTOQUESAIDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_qtde_saida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_valor_saida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRACHAESTOQUESAIDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPESTOQUESAIDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAESTOQUESAIDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_lote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.tb_total_os = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dsDesenhos = new System.Data.DataSet();
            this.DESENHOS = new System.Data.DataTable();
            this.COD_PECA = new System.Data.DataColumn();
            this.N_OS_PECA = new System.Data.DataColumn();
            this.REVISAO = new System.Data.DataColumn();
            this.MATERIAL = new System.Data.DataColumn();
            this.ESPESSURA = new System.Data.DataColumn();
            this.CLIENTE = new System.Data.DataColumn();
            this.ROTA = new System.Data.DataColumn();
            this.NOME_PECA = new System.Data.DataColumn();
            this.N_SUB = new System.Data.DataColumn();
            this.N_ROTAS = new System.Data.DataColumn();
            this.POSICAO_PECA = new System.Data.DataColumn();
            this.FUNCAO_PECA = new System.Data.DataColumn();
            this.DATA_ENTREGA_PECA = new System.Data.DataColumn();
            this.OBS_PECA = new System.Data.DataColumn();
            this.PROJETISTA_PECA = new System.Data.DataColumn();
            this.DESPESAS_MOLDE_DES = new System.Data.DataColumn();
            this.RECEITAS_MOLDE_DES = new System.Data.DataColumn();
            this.HORAS_PREV_TORNO_MOLDE = new System.Data.DataColumn();
            this.HORAS_PREV_FRESA_MOLDE = new System.Data.DataColumn();
            this.HORAS_PREV_CNC_DES_MOLDE = new System.Data.DataColumn();
            this.HORAS_PREV_TEMPERA_MOLDE = new System.Data.DataColumn();
            this.HORAS_PREV_RETIFICA_MOLDE = new System.Data.DataColumn();
            this.HORAS_PREV_RET_OPT_MOLDE = new System.Data.DataColumn();
            this.HORAS_PREV_CNC_ACAB_MOLDE = new System.Data.DataColumn();
            this.HORAS_PREV_EROSAO_EDM_MOLDE = new System.Data.DataColumn();
            this.HORAS_PREV_EROSAO_EWC_MOLDE = new System.Data.DataColumn();
            this.HORAS_PREV_POLIMENTO_MOLDE = new System.Data.DataColumn();
            this.HORAS_PREV_PROJETO_MOLDE = new System.Data.DataColumn();
            this.HORAS_PREV_PORTA_MOLDE_MOLDE = new System.Data.DataColumn();
            this.HORAS_PREV_ELETRODO_MOLDE = new System.Data.DataColumn();
            this.HORAS_EXEC_TORNO_MOLDE = new System.Data.DataColumn();
            this.HORAS_EXEC_FRESA_MOLDE = new System.Data.DataColumn();
            this.HORAS_EXEC_CNC_DES_MOLDE = new System.Data.DataColumn();
            this.HORAS_EXEC_TEMPERA_MOLDE = new System.Data.DataColumn();
            this.HORAS_EXEC_RETIFICA_MOLDE = new System.Data.DataColumn();
            this.HORAS_EXEC_RET_OPT_MOLDE = new System.Data.DataColumn();
            this.HORAS_EXEC_CNC_ACAB_MOLDE = new System.Data.DataColumn();
            this.HORAS_EXEC_EROSAO_EDM_MOLDE = new System.Data.DataColumn();
            this.HORAS_EXEC_EROSAO_EWC_MOLDE = new System.Data.DataColumn();
            this.HORAS_EXEC_POLIMENTO_MOLDE = new System.Data.DataColumn();
            this.HORAS_EXEC_PROJETO_MOLDE = new System.Data.DataColumn();
            this.HORAS_EXEC_PORTA_MOLDE_MOLDE = new System.Data.DataColumn();
            this.HORAS_EXEC_ELETRODO_MOLDE = new System.Data.DataColumn();
            this.HORAS_EXEC_DES_PC_ELET_MOLDE = new System.Data.DataColumn();
            this.TOTAL_ITENS_DES = new System.Data.DataColumn();
            this.ITENS_ENTREGUES_DES = new System.Data.DataColumn();
            this.DATA_ABERTURA_PECA = new System.Data.DataColumn();
            this.N_PC_PECA = new System.Data.DataColumn();
            this.PRAZO_ENTREGA_PECA = new System.Data.DataColumn();
            this.N_PROCESSO_PECA = new System.Data.DataColumn();
            this.dataColumn11 = new System.Data.DataColumn();
            this.dataColumn29 = new System.Data.DataColumn();
            this.dataColumn9 = new System.Data.DataColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label58 = new System.Windows.Forms.Label();
            this.tb_peca = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label54 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label53 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.bt_abrir = new System.Windows.Forms.Button();
            this.pb_desenho = new System.Windows.Forms.PictureBox();
            this.button14 = new System.Windows.Forms.Button();
            this.tb_data_abertura = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.tb_pedido = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_prazo_entrega_os = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_cliente = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_os = new System.Windows.Forms.TextBox();
            this.datDesenhos = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand15 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand13 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand12 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand14 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.tb_posicao_selecionada = new System.Windows.Forms.TextBox();
            this.tb_item_selecionado = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dsItens_ped)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITENS_PEDIDO_COMPRA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens_ped)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosicoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsItens_terceiros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITENS_TERCEIROS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens_terceiros)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsApontamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.APONTAMENTOS)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApontamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSaida_estoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ESTOQUE_SAIDA)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaidas)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsDesenhos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DESENHOS)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_desenho)).BeginInit();
            this.SuspendLayout();
            // 
            // dsItens_ped
            // 
            this.dsItens_ped.DataSetName = "dsItens_ped";
            this.dsItens_ped.Namespace = "http://www.tempuri.org/dsItens_ped.xsd";
            this.dsItens_ped.Tables.AddRange(new System.Data.DataTable[] {
            this.ITENS_PEDIDO_COMPRA});
            // 
            // ITENS_PEDIDO_COMPRA
            // 
            this.ITENS_PEDIDO_COMPRA.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_ITEM_PED,
            this.N_PEDIDO_ITEM_PED,
            this.COD_ITEM_REQ_ITEM_PED,
            this.OP_ITEM_PED,
            this.QTDE_ITEM_PED,
            this.UNID_ITEM_PED,
            this.VALOR_UNIT_ITEM_PED,
            this.VALOR_TOTAL_ITEM_PED,
            this.DESCRICAO_ITEM_PED,
            this.DATA_LIMITE_ITEM_PED,
            this.COD_ESTOQUE_ITEM_PED,
            this.POSICAO_ITEM_PED,
            this.PESO_ITEM_PED,
            this.CHEGOU_ITEM_PED,
            this.COD_NF_ENTRADA_ITEM_PED,
            this.DATA_ENTRADA_ITEM_PED,
            this.PLANO_ITEM_PED,
            this.ITEM_ITEM_PED,
            this.FORNECEDOR_ITEM_PED,
            this.dataColumn7,
            this.dataColumn8});
            this.ITENS_PEDIDO_COMPRA.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_ITEM_PED"}, true)});
            this.ITENS_PEDIDO_COMPRA.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_ITEM_PED};
            this.ITENS_PEDIDO_COMPRA.TableName = "ITENS_PEDIDO_COMPRA";
            // 
            // COD_ITEM_PED
            // 
            this.COD_ITEM_PED.AllowDBNull = false;
            this.COD_ITEM_PED.ColumnName = "COD_ITEM_PED";
            this.COD_ITEM_PED.DataType = typeof(int);
            // 
            // N_PEDIDO_ITEM_PED
            // 
            this.N_PEDIDO_ITEM_PED.ColumnName = "N_PEDIDO_ITEM_PED";
            this.N_PEDIDO_ITEM_PED.DataType = typeof(int);
            // 
            // COD_ITEM_REQ_ITEM_PED
            // 
            this.COD_ITEM_REQ_ITEM_PED.ColumnName = "COD_ITEM_REQ_ITEM_PED";
            this.COD_ITEM_REQ_ITEM_PED.DataType = typeof(int);
            // 
            // OP_ITEM_PED
            // 
            this.OP_ITEM_PED.ColumnName = "OP_ITEM_PED";
            this.OP_ITEM_PED.MaxLength = 50;
            // 
            // QTDE_ITEM_PED
            // 
            this.QTDE_ITEM_PED.ColumnName = "QTDE_ITEM_PED";
            this.QTDE_ITEM_PED.DataType = typeof(double);
            // 
            // UNID_ITEM_PED
            // 
            this.UNID_ITEM_PED.ColumnName = "UNID_ITEM_PED";
            this.UNID_ITEM_PED.MaxLength = 10;
            // 
            // VALOR_UNIT_ITEM_PED
            // 
            this.VALOR_UNIT_ITEM_PED.ColumnName = "VALOR_UNIT_ITEM_PED";
            this.VALOR_UNIT_ITEM_PED.DataType = typeof(double);
            // 
            // VALOR_TOTAL_ITEM_PED
            // 
            this.VALOR_TOTAL_ITEM_PED.ColumnName = "VALOR_TOTAL_ITEM_PED";
            this.VALOR_TOTAL_ITEM_PED.DataType = typeof(double);
            // 
            // DESCRICAO_ITEM_PED
            // 
            this.DESCRICAO_ITEM_PED.ColumnName = "DESCRICAO_ITEM_PED";
            this.DESCRICAO_ITEM_PED.MaxLength = 250;
            // 
            // DATA_LIMITE_ITEM_PED
            // 
            this.DATA_LIMITE_ITEM_PED.ColumnName = "DATA_LIMITE_ITEM_PED";
            this.DATA_LIMITE_ITEM_PED.DataType = typeof(System.DateTime);
            // 
            // COD_ESTOQUE_ITEM_PED
            // 
            this.COD_ESTOQUE_ITEM_PED.ColumnName = "COD_ESTOQUE_ITEM_PED";
            this.COD_ESTOQUE_ITEM_PED.DataType = typeof(int);
            // 
            // POSICAO_ITEM_PED
            // 
            this.POSICAO_ITEM_PED.ColumnName = "POSICAO_ITEM_PED";
            this.POSICAO_ITEM_PED.MaxLength = 50;
            // 
            // PESO_ITEM_PED
            // 
            this.PESO_ITEM_PED.ColumnName = "PESO_ITEM_PED";
            this.PESO_ITEM_PED.DataType = typeof(double);
            // 
            // CHEGOU_ITEM_PED
            // 
            this.CHEGOU_ITEM_PED.ColumnName = "CHEGOU_ITEM_PED";
            this.CHEGOU_ITEM_PED.DataType = typeof(int);
            // 
            // COD_NF_ENTRADA_ITEM_PED
            // 
            this.COD_NF_ENTRADA_ITEM_PED.ColumnName = "COD_NF_ENTRADA_ITEM_PED";
            this.COD_NF_ENTRADA_ITEM_PED.MaxLength = 20;
            // 
            // DATA_ENTRADA_ITEM_PED
            // 
            this.DATA_ENTRADA_ITEM_PED.ColumnName = "DATA_CHEGADA_ITEM_PED";
            this.DATA_ENTRADA_ITEM_PED.DataType = typeof(System.DateTime);
            // 
            // PLANO_ITEM_PED
            // 
            this.PLANO_ITEM_PED.ColumnName = "PLANO_ITEM_PED";
            this.PLANO_ITEM_PED.MaxLength = 100;
            // 
            // ITEM_ITEM_PED
            // 
            this.ITEM_ITEM_PED.ColumnName = "ITEM_ITEM_PED";
            this.ITEM_ITEM_PED.MaxLength = 100;
            // 
            // FORNECEDOR_ITEM_PED
            // 
            this.FORNECEDOR_ITEM_PED.ColumnName = "FORNECEDOR_ITEM_PED";
            this.FORNECEDOR_ITEM_PED.MaxLength = 200;
            // 
            // dataColumn7
            // 
            this.dataColumn7.ColumnName = "LOTE_ITEM_ENT";
            // 
            // dataColumn8
            // 
            this.dataColumn8.Caption = "NOME_FORNECEDOR_ITEM_PED";
            this.dataColumn8.ColumnName = "NOME_FORNECEDOR_ITEM_PED";
            this.dataColumn8.MaxLength = 200;
            // 
            // fbConnection1
            // 
            this.fbConnection1.ConnectionString = resources.GetString("fbConnection1.ConnectionString");
            // 
            // datItens_ped
            // 
            this.datItens_ped.DeleteCommand = this.fbCommand4;
            this.datItens_ped.InsertCommand = this.fbCommand2;
            this.datItens_ped.SelectCommand = this.fbCommand1;
            this.datItens_ped.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * from itens_pedido_compra";
            this.fbCommand1.CommandTimeout = 30;
            this.fbCommand1.Connection = this.fbConnection1;
            // 
            // fbCommand3
            // 
            this.fbCommand3.CommandTimeout = 30;
            // 
            // dgvItens_ped
            // 
            this.dgvItens_ped.AllowUserToAddRows = false;
            this.dgvItens_ped.AllowUserToDeleteRows = false;
            this.dgvItens_ped.AllowUserToResizeColumns = false;
            this.dgvItens_ped.AllowUserToResizeRows = false;
            this.dgvItens_ped.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItens_ped.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItens_ped.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens_ped.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_valor_total,
            this.col_pedido,
            this.col_cod_estoque,
            this.col_item,
            this.col_desc,
            this.col_qtde,
            this.col_unid,
            this.col_valor_unit,
            this.Req,
            this.dATALIMITEITEMPEDDataGridViewTextBoxColumn,
            this.oPITEMPEDDataGridViewTextBoxColumn,
            this.col_chegou,
            this.col_nf_entrada,
            this.DATA_CHEGADA_ITEM_PED,
            this.col_lote_compras,
            this.col_forn});
            this.dgvItens_ped.DataMember = "ITENS_PEDIDO_COMPRA";
            this.dgvItens_ped.DataSource = this.dsItens_ped;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItens_ped.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvItens_ped.Location = new System.Drawing.Point(7, 36);
            this.dgvItens_ped.Name = "dgvItens_ped";
            this.dgvItens_ped.Size = new System.Drawing.Size(397, 129);
            this.dgvItens_ped.TabIndex = 110;
            // 
            // col_valor_total
            // 
            this.col_valor_total.DataPropertyName = "VALOR_TOTAL_ITEM_PED";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.col_valor_total.DefaultCellStyle = dataGridViewCellStyle2;
            this.col_valor_total.HeaderText = "Valor Total";
            this.col_valor_total.Name = "col_valor_total";
            this.col_valor_total.Width = 90;
            // 
            // col_pedido
            // 
            this.col_pedido.DataPropertyName = "N_PEDIDO_ITEM_PED";
            this.col_pedido.HeaderText = "Pedido";
            this.col_pedido.Name = "col_pedido";
            // 
            // col_cod_estoque
            // 
            this.col_cod_estoque.DataPropertyName = "COD_ESTOQUE_ITEM_PED";
            this.col_cod_estoque.HeaderText = "Cód. Estoque";
            this.col_cod_estoque.Name = "col_cod_estoque";
            this.col_cod_estoque.Width = 70;
            // 
            // col_item
            // 
            this.col_item.DataPropertyName = "ITEM_ITEM_PED";
            this.col_item.HeaderText = "Item";
            this.col_item.Name = "col_item";
            // 
            // col_desc
            // 
            this.col_desc.DataPropertyName = "DESCRICAO_ITEM_PED";
            this.col_desc.HeaderText = "Descrição";
            this.col_desc.Name = "col_desc";
            this.col_desc.Width = 155;
            // 
            // col_qtde
            // 
            this.col_qtde.DataPropertyName = "QTDE_ITEM_PED";
            this.col_qtde.HeaderText = "Qtde";
            this.col_qtde.Name = "col_qtde";
            this.col_qtde.Width = 40;
            // 
            // col_unid
            // 
            this.col_unid.DataPropertyName = "UNID_ITEM_PED";
            this.col_unid.HeaderText = "Unid.";
            this.col_unid.Name = "col_unid";
            this.col_unid.Width = 40;
            // 
            // col_valor_unit
            // 
            this.col_valor_unit.DataPropertyName = "VALOR_UNIT_ITEM_PED";
            this.col_valor_unit.HeaderText = "Valor Unit.";
            this.col_valor_unit.Name = "col_valor_unit";
            this.col_valor_unit.Width = 90;
            // 
            // Req
            // 
            this.Req.HeaderText = "Req";
            this.Req.Name = "Req";
            this.Req.Text = "Req";
            this.Req.ToolTipText = "Req";
            this.Req.UseColumnTextForButtonValue = true;
            this.Req.Width = 50;
            // 
            // dATALIMITEITEMPEDDataGridViewTextBoxColumn
            // 
            this.dATALIMITEITEMPEDDataGridViewTextBoxColumn.DataPropertyName = "DATA_LIMITE_ITEM_PED";
            this.dATALIMITEITEMPEDDataGridViewTextBoxColumn.HeaderText = "Data Limite ";
            this.dATALIMITEITEMPEDDataGridViewTextBoxColumn.Name = "dATALIMITEITEMPEDDataGridViewTextBoxColumn";
            // 
            // oPITEMPEDDataGridViewTextBoxColumn
            // 
            this.oPITEMPEDDataGridViewTextBoxColumn.DataPropertyName = "OP_ITEM_PED";
            this.oPITEMPEDDataGridViewTextBoxColumn.HeaderText = "OS";
            this.oPITEMPEDDataGridViewTextBoxColumn.Name = "oPITEMPEDDataGridViewTextBoxColumn";
            // 
            // col_chegou
            // 
            this.col_chegou.DataPropertyName = "CHEGOU_ITEM_PED";
            this.col_chegou.FalseValue = "0";
            this.col_chegou.HeaderText = "Chegou?";
            this.col_chegou.IndeterminateValue = "0";
            this.col_chegou.Name = "col_chegou";
            this.col_chegou.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_chegou.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_chegou.TrueValue = "1";
            this.col_chegou.Width = 40;
            // 
            // col_nf_entrada
            // 
            this.col_nf_entrada.DataPropertyName = "COD_NF_ENTRADA_ITEM_PED";
            this.col_nf_entrada.HeaderText = "Cód. NF Entrada";
            this.col_nf_entrada.Name = "col_nf_entrada";
            // 
            // DATA_CHEGADA_ITEM_PED
            // 
            this.DATA_CHEGADA_ITEM_PED.DataPropertyName = "DATA_CHEGADA_ITEM_PED";
            this.DATA_CHEGADA_ITEM_PED.HeaderText = "Data Chegada";
            this.DATA_CHEGADA_ITEM_PED.Name = "DATA_CHEGADA_ITEM_PED";
            // 
            // col_lote_compras
            // 
            this.col_lote_compras.DataPropertyName = "LOTE_ITEM_ENT";
            this.col_lote_compras.HeaderText = "Lote";
            this.col_lote_compras.Name = "col_lote_compras";
            // 
            // col_forn
            // 
            this.col_forn.DataPropertyName = "NOME_FORNECEDOR_ITEM_PED";
            this.col_forn.HeaderText = "Fornecedor";
            this.col_forn.Name = "col_forn";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.cbSomarCompras);
            this.panel1.Controls.Add(this.tb_valor_compras);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dgvItens_ped);
            this.panel1.Location = new System.Drawing.Point(129, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(411, 214);
            this.panel1.TabIndex = 111;
            // 
            // cbSomarCompras
            // 
            this.cbSomarCompras.AutoSize = true;
            this.cbSomarCompras.Checked = true;
            this.cbSomarCompras.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSomarCompras.Location = new System.Drawing.Point(136, 13);
            this.cbSomarCompras.Name = "cbSomarCompras";
            this.cbSomarCompras.Size = new System.Drawing.Size(15, 14);
            this.cbSomarCompras.TabIndex = 275;
            this.cbSomarCompras.UseVisualStyleBackColor = true;
            this.cbSomarCompras.CheckedChanged += new System.EventHandler(this.cbSomarCompras_CheckedChanged);
            // 
            // tb_valor_compras
            // 
            this.tb_valor_compras.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_valor_compras.Location = new System.Drawing.Point(259, 171);
            this.tb_valor_compras.Name = "tb_valor_compras";
            this.tb_valor_compras.Size = new System.Drawing.Size(145, 32);
            this.tb_valor_compras.TabIndex = 274;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 31);
            this.label1.TabIndex = 111;
            this.label1.Text = "Compras";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 26);
            this.label4.TabIndex = 273;
            this.label4.Text = "Valor Total de Compras:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel4.Controls.Add(this.tb_posicoes);
            this.panel4.Location = new System.Drawing.Point(12, 144);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(111, 34);
            this.panel4.TabIndex = 271;
            // 
            // tb_posicoes
            // 
            this.tb_posicoes.Location = new System.Drawing.Point(5, 7);
            this.tb_posicoes.Name = "tb_posicoes";
            this.tb_posicoes.Size = new System.Drawing.Size(101, 20);
            this.tb_posicoes.TabIndex = 266;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(13, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 270;
            this.label6.Text = "POSIÇÕES";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // dgvPosicoes
            // 
            this.dgvPosicoes.AllowUserToAddRows = false;
            this.dgvPosicoes.AllowUserToDeleteRows = false;
            this.dgvPosicoes.AllowUserToResizeColumns = false;
            this.dgvPosicoes.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPosicoes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPosicoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPosicoes.ColumnHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPosicoes.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPosicoes.Location = new System.Drawing.Point(12, 212);
            this.dgvPosicoes.Name = "dgvPosicoes";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPosicoes.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPosicoes.RowHeadersVisible = false;
            this.dgvPosicoes.Size = new System.Drawing.Size(111, 488);
            this.dgvPosicoes.TabIndex = 269;
            this.dgvPosicoes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPosicoes_CellClick);
            this.dgvPosicoes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPosicoes_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 26);
            this.label2.TabIndex = 112;
            this.label2.Text = "Valor Total de Terceiros:";
            // 
            // tb_valor_terceiros
            // 
            this.tb_valor_terceiros.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_valor_terceiros.Location = new System.Drawing.Point(259, 174);
            this.tb_valor_terceiros.Name = "tb_valor_terceiros";
            this.tb_valor_terceiros.Size = new System.Drawing.Size(145, 32);
            this.tb_valor_terceiros.TabIndex = 113;
            // 
            // datItens_terceiros
            // 
            this.datItens_terceiros.DeleteCommand = this.fbCommand5;
            this.datItens_terceiros.InsertCommand = this.fbCommand6;
            this.datItens_terceiros.SelectCommand = this.fbCommand7;
            this.datItens_terceiros.UpdateCommand = this.fbCommand8;
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
            this.fbCommand7.CommandText = "select * from itens_terceiros";
            this.fbCommand7.CommandTimeout = 30;
            this.fbCommand7.Connection = this.fbConnection1;
            // 
            // fbCommand8
            // 
            this.fbCommand8.CommandTimeout = 30;
            // 
            // dsItens_terceiros
            // 
            this.dsItens_terceiros.DataSetName = "dsItens_terceiros";
            this.dsItens_terceiros.Namespace = "http://www.tempuri.org/dsItens_terceiros.xsd";
            this.dsItens_terceiros.Tables.AddRange(new System.Data.DataTable[] {
            this.ITENS_TERCEIROS});
            // 
            // ITENS_TERCEIROS
            // 
            this.ITENS_TERCEIROS.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_ITEM_TERCEIRO,
            this.OS_ITEM_TERCEIRO,
            this.POSICAO_ITEM_TERCEIRO,
            this.OPERACAO_ITEM_TERCEIRO,
            this.QTDE_ITEM_TERCEIRO,
            this.HORAS_ITEM_TERCEIRO,
            this.DATA_SAIDA_ITEM_TERCEIRO,
            this.HORA_SAIDA_ITEM_TERCEIRO,
            this.DATA_ENTRADA_ITEM_TERCEIRO,
            this.HORA_ENTRADA_ITEM_TERCEIRO,
            this.DATA_PREVISTA_ITEM_TERCEIRO,
            this.COD_FORN_ITEM_TERCEIRO,
            this.NOME_FORN_ITEM_TERCEIRO,
            this.COD_TERCEIRO_ITEM_TERCEIRO,
            this.VALOR_ITEM_TERCEIRO,
            this.DIMENSOES_ITEM_TERCEIRO,
            this.MATERIAL_ITEM_TERCEIRO,
            this.DUREZA_ITEM_TERCEIRO,
            this.N_LOTE_ITEM_TERCEIRO,
            this.DUREZA_ENC_ITEM_TERCEIRO,
            this.OBSERVACAO_ITEM_TERCEIRO,
            this.RESP_MEDICAO_ITEM_TERCEIRO,
            this.ROTA_ITEM_TERCEIRO,
            this.OPERADOR_ITEM_TERCEIRO,
            this.FERRAMENTA_ITEM_TERCEIRO,
            this.ITEM_ITEM_TERCEIRO});
            this.ITENS_TERCEIROS.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_ITEM_TERCEIRO"}, true)});
            this.ITENS_TERCEIROS.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_ITEM_TERCEIRO};
            this.ITENS_TERCEIROS.TableName = "ITENS_TERCEIROS";
            // 
            // COD_ITEM_TERCEIRO
            // 
            this.COD_ITEM_TERCEIRO.AllowDBNull = false;
            this.COD_ITEM_TERCEIRO.ColumnName = "COD_ITEM_TERCEIRO";
            this.COD_ITEM_TERCEIRO.DataType = typeof(int);
            // 
            // OS_ITEM_TERCEIRO
            // 
            this.OS_ITEM_TERCEIRO.ColumnName = "OS_ITEM_TERCEIRO";
            this.OS_ITEM_TERCEIRO.MaxLength = 50;
            // 
            // POSICAO_ITEM_TERCEIRO
            // 
            this.POSICAO_ITEM_TERCEIRO.ColumnName = "POSICAO_ITEM_TERCEIRO";
            this.POSICAO_ITEM_TERCEIRO.MaxLength = 50;
            // 
            // OPERACAO_ITEM_TERCEIRO
            // 
            this.OPERACAO_ITEM_TERCEIRO.ColumnName = "OPERACAO_ITEM_TERCEIRO";
            this.OPERACAO_ITEM_TERCEIRO.MaxLength = 100;
            // 
            // QTDE_ITEM_TERCEIRO
            // 
            this.QTDE_ITEM_TERCEIRO.ColumnName = "QTDE_ITEM_TERCEIRO";
            this.QTDE_ITEM_TERCEIRO.DataType = typeof(double);
            // 
            // HORAS_ITEM_TERCEIRO
            // 
            this.HORAS_ITEM_TERCEIRO.ColumnName = "HORAS_ITEM_TERCEIRO";
            this.HORAS_ITEM_TERCEIRO.DataType = typeof(double);
            // 
            // DATA_SAIDA_ITEM_TERCEIRO
            // 
            this.DATA_SAIDA_ITEM_TERCEIRO.ColumnName = "DATA_SAIDA_ITEM_TERCEIRO";
            this.DATA_SAIDA_ITEM_TERCEIRO.DataType = typeof(System.DateTime);
            // 
            // HORA_SAIDA_ITEM_TERCEIRO
            // 
            this.HORA_SAIDA_ITEM_TERCEIRO.ColumnName = "HORA_SAIDA_ITEM_TERCEIRO";
            this.HORA_SAIDA_ITEM_TERCEIRO.DataType = typeof(System.DateTime);
            // 
            // DATA_ENTRADA_ITEM_TERCEIRO
            // 
            this.DATA_ENTRADA_ITEM_TERCEIRO.ColumnName = "DATA_ENTRADA_ITEM_TERCEIRO";
            this.DATA_ENTRADA_ITEM_TERCEIRO.DataType = typeof(System.DateTime);
            // 
            // HORA_ENTRADA_ITEM_TERCEIRO
            // 
            this.HORA_ENTRADA_ITEM_TERCEIRO.ColumnName = "HORA_ENTRADA_ITEM_TERCEIRO";
            this.HORA_ENTRADA_ITEM_TERCEIRO.DataType = typeof(System.DateTime);
            // 
            // DATA_PREVISTA_ITEM_TERCEIRO
            // 
            this.DATA_PREVISTA_ITEM_TERCEIRO.ColumnName = "DATA_PREVISTA_ITEM_TERCEIRO";
            this.DATA_PREVISTA_ITEM_TERCEIRO.DataType = typeof(System.DateTime);
            // 
            // COD_FORN_ITEM_TERCEIRO
            // 
            this.COD_FORN_ITEM_TERCEIRO.ColumnName = "COD_FORN_ITEM_TERCEIRO";
            this.COD_FORN_ITEM_TERCEIRO.MaxLength = 10;
            // 
            // NOME_FORN_ITEM_TERCEIRO
            // 
            this.NOME_FORN_ITEM_TERCEIRO.ColumnName = "NOME_FORN_ITEM_TERCEIRO";
            this.NOME_FORN_ITEM_TERCEIRO.MaxLength = 200;
            // 
            // COD_TERCEIRO_ITEM_TERCEIRO
            // 
            this.COD_TERCEIRO_ITEM_TERCEIRO.ColumnName = "COD_TERCEIRO_ITEM_TERCEIRO";
            this.COD_TERCEIRO_ITEM_TERCEIRO.DataType = typeof(int);
            // 
            // VALOR_ITEM_TERCEIRO
            // 
            this.VALOR_ITEM_TERCEIRO.ColumnName = "VALOR_ITEM_TERCEIRO";
            this.VALOR_ITEM_TERCEIRO.DataType = typeof(double);
            // 
            // DIMENSOES_ITEM_TERCEIRO
            // 
            this.DIMENSOES_ITEM_TERCEIRO.ColumnName = "DIMENSOES_ITEM_TERCEIRO";
            this.DIMENSOES_ITEM_TERCEIRO.MaxLength = 50;
            // 
            // MATERIAL_ITEM_TERCEIRO
            // 
            this.MATERIAL_ITEM_TERCEIRO.ColumnName = "MATERIAL_ITEM_TERCEIRO";
            this.MATERIAL_ITEM_TERCEIRO.MaxLength = 50;
            // 
            // DUREZA_ITEM_TERCEIRO
            // 
            this.DUREZA_ITEM_TERCEIRO.ColumnName = "DUREZA_ITEM_TERCEIRO";
            this.DUREZA_ITEM_TERCEIRO.MaxLength = 50;
            // 
            // N_LOTE_ITEM_TERCEIRO
            // 
            this.N_LOTE_ITEM_TERCEIRO.ColumnName = "N_LOTE_ITEM_TERCEIRO";
            this.N_LOTE_ITEM_TERCEIRO.MaxLength = 50;
            // 
            // DUREZA_ENC_ITEM_TERCEIRO
            // 
            this.DUREZA_ENC_ITEM_TERCEIRO.ColumnName = "DUREZA_ENC_ITEM_TERCEIRO";
            this.DUREZA_ENC_ITEM_TERCEIRO.MaxLength = 50;
            // 
            // OBSERVACAO_ITEM_TERCEIRO
            // 
            this.OBSERVACAO_ITEM_TERCEIRO.ColumnName = "OBSERVACAO_ITEM_TERCEIRO";
            this.OBSERVACAO_ITEM_TERCEIRO.MaxLength = 200;
            // 
            // RESP_MEDICAO_ITEM_TERCEIRO
            // 
            this.RESP_MEDICAO_ITEM_TERCEIRO.ColumnName = "RESP_MEDICAO_ITEM_TERCEIRO";
            this.RESP_MEDICAO_ITEM_TERCEIRO.MaxLength = 50;
            // 
            // ROTA_ITEM_TERCEIRO
            // 
            this.ROTA_ITEM_TERCEIRO.ColumnName = "ROTA_ITEM_TERCEIRO";
            this.ROTA_ITEM_TERCEIRO.DataType = typeof(int);
            // 
            // OPERADOR_ITEM_TERCEIRO
            // 
            this.OPERADOR_ITEM_TERCEIRO.ColumnName = "OPERADOR_ITEM_TERCEIRO";
            this.OPERADOR_ITEM_TERCEIRO.MaxLength = 20;
            // 
            // FERRAMENTA_ITEM_TERCEIRO
            // 
            this.FERRAMENTA_ITEM_TERCEIRO.ColumnName = "FERRAMENTA_ITEM_TERCEIRO";
            this.FERRAMENTA_ITEM_TERCEIRO.MaxLength = 200;
            // 
            // ITEM_ITEM_TERCEIRO
            // 
            this.ITEM_ITEM_TERCEIRO.ColumnName = "ITEM_ITEM_TERCEIRO";
            this.ITEM_ITEM_TERCEIRO.MaxLength = 200;
            // 
            // dgvItens_terceiros
            // 
            this.dgvItens_terceiros.AllowUserToAddRows = false;
            this.dgvItens_terceiros.AllowUserToDeleteRows = false;
            this.dgvItens_terceiros.AutoGenerateColumns = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItens_terceiros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvItens_terceiros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens_terceiros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.col_horas,
            this.col_valor,
            this.col_operacao,
            this.col_rota,
            this.col_os,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.col_posicao,
            this.col_qt,
            this.col_operador,
            this.dATASAIDAITEMTERCEIRODataGridViewTextBoxColumn,
            this.hORASAIDAITEMTERCEIRODataGridViewTextBoxColumn,
            this.dATAENTRADAITEMTERCEIRODataGridViewTextBoxColumn,
            this.hORAENTRADAITEMTERCEIRODataGridViewTextBoxColumn,
            this.dATAPREVISTAITEMTERCEIRODataGridViewTextBoxColumn,
            this.cODFORNITEMTERCEIRODataGridViewTextBoxColumn,
            this.col_nome,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.dgvItens_terceiros.DataMember = "ITENS_TERCEIROS";
            this.dgvItens_terceiros.DataSource = this.dsItens_terceiros;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItens_terceiros.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvItens_terceiros.Location = new System.Drawing.Point(7, 39);
            this.dgvItens_terceiros.Name = "dgvItens_terceiros";
            this.dgvItens_terceiros.Size = new System.Drawing.Size(397, 129);
            this.dgvItens_terceiros.TabIndex = 272;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "COD_TERCEIRO_ITEM_TERCEIRO";
            this.dataGridViewTextBoxColumn1.HeaderText = "Roman.";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // col_horas
            // 
            this.col_horas.DataPropertyName = "HORAS_ITEM_TERCEIRO";
            this.col_horas.HeaderText = "Horas";
            this.col_horas.Name = "col_horas";
            this.col_horas.Width = 40;
            // 
            // col_valor
            // 
            this.col_valor.DataPropertyName = "VALOR_ITEM_TERCEIRO";
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = null;
            this.col_valor.DefaultCellStyle = dataGridViewCellStyle8;
            this.col_valor.HeaderText = "Valor";
            this.col_valor.Name = "col_valor";
            this.col_valor.Width = 60;
            // 
            // col_operacao
            // 
            this.col_operacao.DataPropertyName = "OPERACAO_ITEM_TERCEIRO";
            this.col_operacao.HeaderText = "Operação";
            this.col_operacao.Name = "col_operacao";
            // 
            // col_rota
            // 
            this.col_rota.DataPropertyName = "ROTA_ITEM_TERCEIRO";
            this.col_rota.HeaderText = "Rota";
            this.col_rota.Name = "col_rota";
            this.col_rota.Width = 60;
            // 
            // col_os
            // 
            this.col_os.DataPropertyName = "OS_ITEM_TERCEIRO";
            this.col_os.HeaderText = "OS";
            this.col_os.Name = "col_os";
            this.col_os.Width = 60;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FERRAMENTA_ITEM_TERCEIRO";
            this.dataGridViewTextBoxColumn2.HeaderText = "Ferramenta";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ITEM_ITEM_TERCEIRO";
            this.dataGridViewTextBoxColumn3.HeaderText = "Item";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // col_posicao
            // 
            this.col_posicao.DataPropertyName = "POSICAO_ITEM_TERCEIRO";
            this.col_posicao.HeaderText = "Pos.";
            this.col_posicao.Name = "col_posicao";
            this.col_posicao.Width = 40;
            // 
            // col_qt
            // 
            this.col_qt.DataPropertyName = "QTDE_ITEM_TERCEIRO";
            this.col_qt.HeaderText = "Qtde";
            this.col_qt.Name = "col_qt";
            this.col_qt.Width = 40;
            // 
            // col_operador
            // 
            this.col_operador.DataPropertyName = "OPERADOR_ITEM_TERCEIRO";
            this.col_operador.HeaderText = "Operador";
            this.col_operador.Name = "col_operador";
            this.col_operador.Width = 60;
            // 
            // dATASAIDAITEMTERCEIRODataGridViewTextBoxColumn
            // 
            this.dATASAIDAITEMTERCEIRODataGridViewTextBoxColumn.DataPropertyName = "DATA_SAIDA_ITEM_TERCEIRO";
            this.dATASAIDAITEMTERCEIRODataGridViewTextBoxColumn.HeaderText = "Data Saída";
            this.dATASAIDAITEMTERCEIRODataGridViewTextBoxColumn.Name = "dATASAIDAITEMTERCEIRODataGridViewTextBoxColumn";
            this.dATASAIDAITEMTERCEIRODataGridViewTextBoxColumn.Width = 65;
            // 
            // hORASAIDAITEMTERCEIRODataGridViewTextBoxColumn
            // 
            this.hORASAIDAITEMTERCEIRODataGridViewTextBoxColumn.DataPropertyName = "HORA_SAIDA_ITEM_TERCEIRO";
            dataGridViewCellStyle9.Format = "t";
            dataGridViewCellStyle9.NullValue = null;
            this.hORASAIDAITEMTERCEIRODataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.hORASAIDAITEMTERCEIRODataGridViewTextBoxColumn.HeaderText = "Hora Saída";
            this.hORASAIDAITEMTERCEIRODataGridViewTextBoxColumn.Name = "hORASAIDAITEMTERCEIRODataGridViewTextBoxColumn";
            this.hORASAIDAITEMTERCEIRODataGridViewTextBoxColumn.Visible = false;
            this.hORASAIDAITEMTERCEIRODataGridViewTextBoxColumn.Width = 50;
            // 
            // dATAENTRADAITEMTERCEIRODataGridViewTextBoxColumn
            // 
            this.dATAENTRADAITEMTERCEIRODataGridViewTextBoxColumn.DataPropertyName = "DATA_ENTRADA_ITEM_TERCEIRO";
            this.dATAENTRADAITEMTERCEIRODataGridViewTextBoxColumn.HeaderText = "Data Entrada";
            this.dATAENTRADAITEMTERCEIRODataGridViewTextBoxColumn.Name = "dATAENTRADAITEMTERCEIRODataGridViewTextBoxColumn";
            this.dATAENTRADAITEMTERCEIRODataGridViewTextBoxColumn.Width = 65;
            // 
            // hORAENTRADAITEMTERCEIRODataGridViewTextBoxColumn
            // 
            this.hORAENTRADAITEMTERCEIRODataGridViewTextBoxColumn.DataPropertyName = "HORA_ENTRADA_ITEM_TERCEIRO";
            dataGridViewCellStyle10.Format = "t";
            dataGridViewCellStyle10.NullValue = null;
            this.hORAENTRADAITEMTERCEIRODataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.hORAENTRADAITEMTERCEIRODataGridViewTextBoxColumn.HeaderText = "Hora Entrada";
            this.hORAENTRADAITEMTERCEIRODataGridViewTextBoxColumn.Name = "hORAENTRADAITEMTERCEIRODataGridViewTextBoxColumn";
            this.hORAENTRADAITEMTERCEIRODataGridViewTextBoxColumn.Visible = false;
            this.hORAENTRADAITEMTERCEIRODataGridViewTextBoxColumn.Width = 50;
            // 
            // dATAPREVISTAITEMTERCEIRODataGridViewTextBoxColumn
            // 
            this.dATAPREVISTAITEMTERCEIRODataGridViewTextBoxColumn.DataPropertyName = "DATA_PREVISTA_ITEM_TERCEIRO";
            this.dATAPREVISTAITEMTERCEIRODataGridViewTextBoxColumn.HeaderText = "Data Prevista";
            this.dATAPREVISTAITEMTERCEIRODataGridViewTextBoxColumn.Name = "dATAPREVISTAITEMTERCEIRODataGridViewTextBoxColumn";
            this.dATAPREVISTAITEMTERCEIRODataGridViewTextBoxColumn.Width = 70;
            // 
            // cODFORNITEMTERCEIRODataGridViewTextBoxColumn
            // 
            this.cODFORNITEMTERCEIRODataGridViewTextBoxColumn.DataPropertyName = "COD_FORN_ITEM_TERCEIRO";
            this.cODFORNITEMTERCEIRODataGridViewTextBoxColumn.HeaderText = "Cód. Forn.";
            this.cODFORNITEMTERCEIRODataGridViewTextBoxColumn.Name = "cODFORNITEMTERCEIRODataGridViewTextBoxColumn";
            this.cODFORNITEMTERCEIRODataGridViewTextBoxColumn.Visible = false;
            this.cODFORNITEMTERCEIRODataGridViewTextBoxColumn.Width = 50;
            // 
            // col_nome
            // 
            this.col_nome.DataPropertyName = "NOME_FORN_ITEM_TERCEIRO";
            this.col_nome.HeaderText = "Nome Forn.";
            this.col_nome.Name = "col_nome";
            this.col_nome.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DIMENSOES_ITEM_TERCEIRO";
            this.dataGridViewTextBoxColumn5.HeaderText = "Dimen.";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 40;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "MATERIAL_ITEM_TERCEIRO";
            this.dataGridViewTextBoxColumn6.HeaderText = "Material";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 60;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "DUREZA_ITEM_TERCEIRO";
            this.dataGridViewTextBoxColumn7.HeaderText = "Dur.";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 40;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "N_LOTE_ITEM_TERCEIRO";
            this.dataGridViewTextBoxColumn8.HeaderText = "Nº Lote";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 50;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "DUREZA_ENC_ITEM_TERCEIRO";
            this.dataGridViewTextBoxColumn9.HeaderText = "Dur. Enc.";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 40;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "RESP_MEDICAO_ITEM_TERCEIRO";
            this.dataGridViewTextBoxColumn10.HeaderText = "Resp. Medição";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "OBSERVACAO_ITEM_TERCEIRO";
            this.dataGridViewTextBoxColumn11.HeaderText = "Observações";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 200;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel3.Controls.Add(this.cbSomarTerceiros);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.tb_valor_terceiros);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.dgvItens_terceiros);
            this.panel3.Location = new System.Drawing.Point(546, 124);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(411, 214);
            this.panel3.TabIndex = 273;
            // 
            // cbSomarTerceiros
            // 
            this.cbSomarTerceiros.AutoSize = true;
            this.cbSomarTerceiros.Checked = true;
            this.cbSomarTerceiros.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSomarTerceiros.Location = new System.Drawing.Point(140, 16);
            this.cbSomarTerceiros.Name = "cbSomarTerceiros";
            this.cbSomarTerceiros.Size = new System.Drawing.Size(15, 14);
            this.cbSomarTerceiros.TabIndex = 273;
            this.cbSomarTerceiros.UseVisualStyleBackColor = true;
            this.cbSomarTerceiros.CheckedChanged += new System.EventHandler(this.cbSomarTerceiros_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 31);
            this.label3.TabIndex = 112;
            this.label3.Text = "Terceiros";
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
            this.QTDE_AP,
            this.RETRABALHO_AP,
            this.MOTIVO_PARADA_AP,
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4});
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
            // QTDE_AP
            // 
            this.QTDE_AP.ColumnName = "QTDE_AP";
            this.QTDE_AP.DataType = typeof(int);
            // 
            // RETRABALHO_AP
            // 
            this.RETRABALHO_AP.ColumnName = "RETRABALHO_AP";
            this.RETRABALHO_AP.DataType = typeof(int);
            // 
            // MOTIVO_PARADA_AP
            // 
            this.MOTIVO_PARADA_AP.ColumnName = "MOTIVO_PARADA_AP";
            this.MOTIVO_PARADA_AP.MaxLength = 200;
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "DESENHO_AP";
            this.dataColumn1.MaxLength = 200;
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "ITEM_AP";
            this.dataColumn2.MaxLength = 200;
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "FERRAMENTA_AP";
            this.dataColumn3.MaxLength = 200;
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "LOTE_AP";
            this.dataColumn4.DataType = typeof(int);
            // 
            // datApontamentos
            // 
            this.datApontamentos.DeleteCommand = this.fbCommand4;
            this.datApontamentos.InsertCommand = this.fbCommand2;
            this.datApontamentos.SelectCommand = this.fbCommand1;
            this.datApontamentos.UpdateCommand = this.fbCommand3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel5.Controls.Add(this.cbSomarServicos);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.tb_valor_servicos);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.dgvApontamentos);
            this.panel5.Location = new System.Drawing.Point(129, 344);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(411, 355);
            this.panel5.TabIndex = 274;
            // 
            // cbSomarServicos
            // 
            this.cbSomarServicos.AutoSize = true;
            this.cbSomarServicos.Checked = true;
            this.cbSomarServicos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSomarServicos.Location = new System.Drawing.Point(130, 12);
            this.cbSomarServicos.Name = "cbSomarServicos";
            this.cbSomarServicos.Size = new System.Drawing.Size(15, 14);
            this.cbSomarServicos.TabIndex = 278;
            this.cbSomarServicos.UseVisualStyleBackColor = true;
            this.cbSomarServicos.CheckedChanged += new System.EventHandler(this.cbSomarServicos_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 31);
            this.label7.TabIndex = 277;
            this.label7.Text = "Serviços";
            // 
            // tb_valor_servicos
            // 
            this.tb_valor_servicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_valor_servicos.Location = new System.Drawing.Point(259, 314);
            this.tb_valor_servicos.Name = "tb_valor_servicos";
            this.tb_valor_servicos.Size = new System.Drawing.Size(145, 32);
            this.tb_valor_servicos.TabIndex = 276;
            this.tb_valor_servicos.TextChanged += new System.EventHandler(this.tb_valor_servicos_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(242, 26);
            this.label5.TabIndex = 275;
            this.label5.Text = "Valor Total de Serviços:";
            // 
            // dgvApontamentos
            // 
            this.dgvApontamentos.AllowUserToAddRows = false;
            this.dgvApontamentos.AllowUserToDeleteRows = false;
            this.dgvApontamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvApontamentos.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvApontamentos.Location = new System.Drawing.Point(7, 35);
            this.dgvApontamentos.Name = "dgvApontamentos";
            this.dgvApontamentos.Size = new System.Drawing.Size(397, 273);
            this.dgvApontamentos.TabIndex = 0;
            // 
            // fbCommand9
            // 
            this.fbCommand9.CommandTimeout = 30;
            // 
            // dsSaida_estoque
            // 
            this.dsSaida_estoque.DataSetName = "dsSaida_estoque";
            this.dsSaida_estoque.Namespace = "http://www.tempuri.org/dsSaida_estoque.xsd";
            this.dsSaida_estoque.Tables.AddRange(new System.Data.DataTable[] {
            this.ESTOQUE_SAIDA});
            // 
            // ESTOQUE_SAIDA
            // 
            this.ESTOQUE_SAIDA.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_ESTOQUE_SAIDA,
            this.ITEM_ESTOQUE_SAIDA,
            this.COD_ITEM_ESTOQUE_SAIDA,
            this.QTDE_ESTOQUE_SAIDA,
            this.CRACHA_ESTOQUE_SAIDA,
            this.OP_ESTOQUE_SAIDA,
            this.DATA_ESTOQUE_SAIDA,
            this.dataColumn5,
            this.dataColumn6});
            this.ESTOQUE_SAIDA.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_ESTOQUE_SAIDA"}, true)});
            this.ESTOQUE_SAIDA.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_ESTOQUE_SAIDA};
            this.ESTOQUE_SAIDA.TableName = "ESTOQUE_SAIDA";
            // 
            // COD_ESTOQUE_SAIDA
            // 
            this.COD_ESTOQUE_SAIDA.AllowDBNull = false;
            this.COD_ESTOQUE_SAIDA.ColumnName = "COD_ESTOQUE_SAIDA";
            this.COD_ESTOQUE_SAIDA.DataType = typeof(int);
            // 
            // ITEM_ESTOQUE_SAIDA
            // 
            this.ITEM_ESTOQUE_SAIDA.ColumnName = "ITEM_ESTOQUE_SAIDA";
            this.ITEM_ESTOQUE_SAIDA.MaxLength = 100;
            // 
            // COD_ITEM_ESTOQUE_SAIDA
            // 
            this.COD_ITEM_ESTOQUE_SAIDA.ColumnName = "COD_ITEM_ESTOQUE_SAIDA";
            this.COD_ITEM_ESTOQUE_SAIDA.DataType = typeof(int);
            // 
            // QTDE_ESTOQUE_SAIDA
            // 
            this.QTDE_ESTOQUE_SAIDA.ColumnName = "QTDE_ESTOQUE_SAIDA";
            this.QTDE_ESTOQUE_SAIDA.DataType = typeof(double);
            // 
            // CRACHA_ESTOQUE_SAIDA
            // 
            this.CRACHA_ESTOQUE_SAIDA.ColumnName = "CRACHA_ESTOQUE_SAIDA";
            this.CRACHA_ESTOQUE_SAIDA.DataType = typeof(int);
            // 
            // OP_ESTOQUE_SAIDA
            // 
            this.OP_ESTOQUE_SAIDA.ColumnName = "OP_ESTOQUE_SAIDA";
            this.OP_ESTOQUE_SAIDA.MaxLength = 100;
            // 
            // DATA_ESTOQUE_SAIDA
            // 
            this.DATA_ESTOQUE_SAIDA.ColumnName = "DATA_ESTOQUE_SAIDA";
            this.DATA_ESTOQUE_SAIDA.DataType = typeof(System.DateTime);
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "LOTE_ESTOQUE_SAIDA";
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "NF_ITEM_ENT";
            // 
            // datSaida_estoque
            // 
            this.datSaida_estoque.DeleteCommand = this.fbCommand10;
            this.datSaida_estoque.InsertCommand = this.fbCommand6;
            this.datSaida_estoque.SelectCommand = this.fbCommand5;
            this.datSaida_estoque.UpdateCommand = this.fbCommand11;
            // 
            // fbCommand10
            // 
            this.fbCommand10.CommandTimeout = 30;
            // 
            // fbCommand11
            // 
            this.fbCommand11.CommandTimeout = 30;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel6.Controls.Add(this.cbSomarSaidasEstoque);
            this.panel6.Controls.Add(this.tb_valor_saidas_estoque);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.dgvSaidas);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Location = new System.Drawing.Point(546, 344);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(411, 183);
            this.panel6.TabIndex = 275;
            // 
            // cbSomarSaidasEstoque
            // 
            this.cbSomarSaidasEstoque.AutoSize = true;
            this.cbSomarSaidasEstoque.Checked = true;
            this.cbSomarSaidasEstoque.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSomarSaidasEstoque.Location = new System.Drawing.Point(253, 12);
            this.cbSomarSaidasEstoque.Name = "cbSomarSaidasEstoque";
            this.cbSomarSaidasEstoque.Size = new System.Drawing.Size(15, 14);
            this.cbSomarSaidasEstoque.TabIndex = 282;
            this.cbSomarSaidasEstoque.UseVisualStyleBackColor = true;
            this.cbSomarSaidasEstoque.CheckedChanged += new System.EventHandler(this.cbSomarSaidasEstoque_CheckedChanged);
            // 
            // tb_valor_saidas_estoque
            // 
            this.tb_valor_saidas_estoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_valor_saidas_estoque.Location = new System.Drawing.Point(259, 147);
            this.tb_valor_saidas_estoque.Name = "tb_valor_saidas_estoque";
            this.tb_valor_saidas_estoque.Size = new System.Drawing.Size(145, 32);
            this.tb_valor_saidas_estoque.TabIndex = 281;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 153);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(225, 26);
            this.label12.TabIndex = 280;
            this.label12.Text = "Valor Total de Saídas:";
            // 
            // dgvSaidas
            // 
            this.dgvSaidas.AllowUserToAddRows = false;
            this.dgvSaidas.AllowUserToDeleteRows = false;
            this.dgvSaidas.AutoGenerateColumns = false;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F);
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSaidas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvSaidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_cod_saida,
            this.iTEMESTOQUESAIDADataGridViewTextBoxColumn,
            this.col_qtde_saida,
            this.col_valor_saida,
            this.cRACHAESTOQUESAIDADataGridViewTextBoxColumn,
            this.oPESTOQUESAIDADataGridViewTextBoxColumn,
            this.dATAESTOQUESAIDADataGridViewTextBoxColumn,
            this.col_lote,
            this.col_nf});
            this.dgvSaidas.DataMember = "ESTOQUE_SAIDA";
            this.dgvSaidas.DataSource = this.dsSaida_estoque;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSaidas.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvSaidas.Location = new System.Drawing.Point(7, 35);
            this.dgvSaidas.Name = "dgvSaidas";
            this.dgvSaidas.Size = new System.Drawing.Size(397, 106);
            this.dgvSaidas.TabIndex = 279;
            // 
            // col_cod_saida
            // 
            this.col_cod_saida.DataPropertyName = "COD_ITEM_ESTOQUE_SAIDA";
            this.col_cod_saida.HeaderText = "Cod Item";
            this.col_cod_saida.Name = "col_cod_saida";
            this.col_cod_saida.Width = 40;
            // 
            // iTEMESTOQUESAIDADataGridViewTextBoxColumn
            // 
            this.iTEMESTOQUESAIDADataGridViewTextBoxColumn.DataPropertyName = "ITEM_ESTOQUE_SAIDA";
            this.iTEMESTOQUESAIDADataGridViewTextBoxColumn.HeaderText = "Item";
            this.iTEMESTOQUESAIDADataGridViewTextBoxColumn.Name = "iTEMESTOQUESAIDADataGridViewTextBoxColumn";
            // 
            // col_qtde_saida
            // 
            this.col_qtde_saida.DataPropertyName = "QTDE_ESTOQUE_SAIDA";
            this.col_qtde_saida.HeaderText = "Qtde";
            this.col_qtde_saida.Name = "col_qtde_saida";
            // 
            // col_valor_saida
            // 
            dataGridViewCellStyle14.Format = "N2";
            dataGridViewCellStyle14.NullValue = null;
            this.col_valor_saida.DefaultCellStyle = dataGridViewCellStyle14;
            this.col_valor_saida.HeaderText = "Valor Saída";
            this.col_valor_saida.Name = "col_valor_saida";
            // 
            // cRACHAESTOQUESAIDADataGridViewTextBoxColumn
            // 
            this.cRACHAESTOQUESAIDADataGridViewTextBoxColumn.DataPropertyName = "CRACHA_ESTOQUE_SAIDA";
            this.cRACHAESTOQUESAIDADataGridViewTextBoxColumn.HeaderText = "Crachá";
            this.cRACHAESTOQUESAIDADataGridViewTextBoxColumn.Name = "cRACHAESTOQUESAIDADataGridViewTextBoxColumn";
            // 
            // oPESTOQUESAIDADataGridViewTextBoxColumn
            // 
            this.oPESTOQUESAIDADataGridViewTextBoxColumn.DataPropertyName = "OP_ESTOQUE_SAIDA";
            this.oPESTOQUESAIDADataGridViewTextBoxColumn.HeaderText = "OP";
            this.oPESTOQUESAIDADataGridViewTextBoxColumn.Name = "oPESTOQUESAIDADataGridViewTextBoxColumn";
            // 
            // dATAESTOQUESAIDADataGridViewTextBoxColumn
            // 
            this.dATAESTOQUESAIDADataGridViewTextBoxColumn.DataPropertyName = "DATA_ESTOQUE_SAIDA";
            this.dATAESTOQUESAIDADataGridViewTextBoxColumn.HeaderText = "Data";
            this.dATAESTOQUESAIDADataGridViewTextBoxColumn.Name = "dATAESTOQUESAIDADataGridViewTextBoxColumn";
            // 
            // col_lote
            // 
            this.col_lote.DataPropertyName = "LOTE_ESTOQUE_SAIDA";
            this.col_lote.HeaderText = "Lote";
            this.col_lote.Name = "col_lote";
            // 
            // col_nf
            // 
            this.col_nf.DataPropertyName = "NF_ITEM_ENT";
            this.col_nf.HeaderText = "NF";
            this.col_nf.Name = "col_nf";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(241, 31);
            this.label9.TabIndex = 278;
            this.label9.Text = "Saídas de Estoque";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel7.Controls.Add(this.button2);
            this.panel7.Controls.Add(this.tb_total_os);
            this.panel7.Controls.Add(this.label15);
            this.panel7.Controls.Add(this.label13);
            this.panel7.Location = new System.Drawing.Point(547, 533);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(410, 166);
            this.panel7.TabIndex = 276;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(258, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 58);
            this.button2.TabIndex = 517;
            this.button2.Text = "Finalizar OS";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tb_total_os
            // 
            this.tb_total_os.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_total_os.Location = new System.Drawing.Point(258, 34);
            this.tb_total_os.Name = "tb_total_os";
            this.tb_total_os.Size = new System.Drawing.Size(145, 32);
            this.tb_total_os.TabIndex = 284;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(5, 37);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(238, 26);
            this.label15.TabIndex = 283;
            this.label15.Text = "Total de Gastos da OS:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(5, 1);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 31);
            this.label13.TabIndex = 282;
            this.label13.Text = "Totais";
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
            this.N_OS_PECA,
            this.REVISAO,
            this.MATERIAL,
            this.ESPESSURA,
            this.CLIENTE,
            this.ROTA,
            this.NOME_PECA,
            this.N_SUB,
            this.N_ROTAS,
            this.POSICAO_PECA,
            this.FUNCAO_PECA,
            this.DATA_ENTREGA_PECA,
            this.OBS_PECA,
            this.PROJETISTA_PECA,
            this.DESPESAS_MOLDE_DES,
            this.RECEITAS_MOLDE_DES,
            this.HORAS_PREV_TORNO_MOLDE,
            this.HORAS_PREV_FRESA_MOLDE,
            this.HORAS_PREV_CNC_DES_MOLDE,
            this.HORAS_PREV_TEMPERA_MOLDE,
            this.HORAS_PREV_RETIFICA_MOLDE,
            this.HORAS_PREV_RET_OPT_MOLDE,
            this.HORAS_PREV_CNC_ACAB_MOLDE,
            this.HORAS_PREV_EROSAO_EDM_MOLDE,
            this.HORAS_PREV_EROSAO_EWC_MOLDE,
            this.HORAS_PREV_POLIMENTO_MOLDE,
            this.HORAS_PREV_PROJETO_MOLDE,
            this.HORAS_PREV_PORTA_MOLDE_MOLDE,
            this.HORAS_PREV_ELETRODO_MOLDE,
            this.HORAS_EXEC_TORNO_MOLDE,
            this.HORAS_EXEC_FRESA_MOLDE,
            this.HORAS_EXEC_CNC_DES_MOLDE,
            this.HORAS_EXEC_TEMPERA_MOLDE,
            this.HORAS_EXEC_RETIFICA_MOLDE,
            this.HORAS_EXEC_RET_OPT_MOLDE,
            this.HORAS_EXEC_CNC_ACAB_MOLDE,
            this.HORAS_EXEC_EROSAO_EDM_MOLDE,
            this.HORAS_EXEC_EROSAO_EWC_MOLDE,
            this.HORAS_EXEC_POLIMENTO_MOLDE,
            this.HORAS_EXEC_PROJETO_MOLDE,
            this.HORAS_EXEC_PORTA_MOLDE_MOLDE,
            this.HORAS_EXEC_ELETRODO_MOLDE,
            this.HORAS_EXEC_DES_PC_ELET_MOLDE,
            this.TOTAL_ITENS_DES,
            this.ITENS_ENTREGUES_DES,
            this.DATA_ABERTURA_PECA,
            this.N_PC_PECA,
            this.PRAZO_ENTREGA_PECA,
            this.N_PROCESSO_PECA,
            this.dataColumn11,
            this.dataColumn29,
            this.dataColumn9});
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
            this.COD_PECA.DataType = typeof(int);
            // 
            // N_OS_PECA
            // 
            this.N_OS_PECA.ColumnName = "N_OS_PECA";
            this.N_OS_PECA.MaxLength = 50;
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
            this.CLIENTE.MaxLength = 100;
            // 
            // ROTA
            // 
            this.ROTA.ColumnName = "ROTA";
            this.ROTA.DataType = typeof(int);
            // 
            // NOME_PECA
            // 
            this.NOME_PECA.ColumnName = "NOME_PECA";
            this.NOME_PECA.MaxLength = 100;
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
            // FUNCAO_PECA
            // 
            this.FUNCAO_PECA.ColumnName = "FUNCAO_PECA";
            this.FUNCAO_PECA.MaxLength = 50;
            // 
            // DATA_ENTREGA_PECA
            // 
            this.DATA_ENTREGA_PECA.ColumnName = "DATA_ENTREGA_PECA";
            this.DATA_ENTREGA_PECA.DataType = typeof(System.DateTime);
            // 
            // OBS_PECA
            // 
            this.OBS_PECA.ColumnName = "OBS_PECA";
            this.OBS_PECA.MaxLength = 200;
            // 
            // PROJETISTA_PECA
            // 
            this.PROJETISTA_PECA.ColumnName = "PROJETISTA_PECA";
            this.PROJETISTA_PECA.MaxLength = 100;
            // 
            // DESPESAS_MOLDE_DES
            // 
            this.DESPESAS_MOLDE_DES.ColumnName = "DESPESAS_MOLDE_DES";
            this.DESPESAS_MOLDE_DES.DataType = typeof(double);
            // 
            // RECEITAS_MOLDE_DES
            // 
            this.RECEITAS_MOLDE_DES.ColumnName = "RECEITAS_MOLDE_DES";
            this.RECEITAS_MOLDE_DES.DataType = typeof(double);
            // 
            // HORAS_PREV_TORNO_MOLDE
            // 
            this.HORAS_PREV_TORNO_MOLDE.ColumnName = "HORAS_PREV_TORNO_MOLDE";
            this.HORAS_PREV_TORNO_MOLDE.DataType = typeof(double);
            // 
            // HORAS_PREV_FRESA_MOLDE
            // 
            this.HORAS_PREV_FRESA_MOLDE.ColumnName = "HORAS_PREV_FRESA_MOLDE";
            this.HORAS_PREV_FRESA_MOLDE.DataType = typeof(double);
            // 
            // HORAS_PREV_CNC_DES_MOLDE
            // 
            this.HORAS_PREV_CNC_DES_MOLDE.ColumnName = "HORAS_PREV_CNC_DES_MOLDE";
            this.HORAS_PREV_CNC_DES_MOLDE.DataType = typeof(double);
            // 
            // HORAS_PREV_TEMPERA_MOLDE
            // 
            this.HORAS_PREV_TEMPERA_MOLDE.ColumnName = "HORAS_PREV_TEMPERA_MOLDE";
            this.HORAS_PREV_TEMPERA_MOLDE.DataType = typeof(double);
            // 
            // HORAS_PREV_RETIFICA_MOLDE
            // 
            this.HORAS_PREV_RETIFICA_MOLDE.ColumnName = "HORAS_PREV_RETIFICA_MOLDE";
            this.HORAS_PREV_RETIFICA_MOLDE.DataType = typeof(double);
            // 
            // HORAS_PREV_RET_OPT_MOLDE
            // 
            this.HORAS_PREV_RET_OPT_MOLDE.ColumnName = "HORAS_PREV_RET_OPT_MOLDE";
            this.HORAS_PREV_RET_OPT_MOLDE.DataType = typeof(double);
            // 
            // HORAS_PREV_CNC_ACAB_MOLDE
            // 
            this.HORAS_PREV_CNC_ACAB_MOLDE.ColumnName = "HORAS_PREV_CNC_ACAB_MOLDE";
            this.HORAS_PREV_CNC_ACAB_MOLDE.DataType = typeof(double);
            // 
            // HORAS_PREV_EROSAO_EDM_MOLDE
            // 
            this.HORAS_PREV_EROSAO_EDM_MOLDE.ColumnName = "HORAS_PREV_EROSAO_EDM_MOLDE";
            this.HORAS_PREV_EROSAO_EDM_MOLDE.DataType = typeof(double);
            // 
            // HORAS_PREV_EROSAO_EWC_MOLDE
            // 
            this.HORAS_PREV_EROSAO_EWC_MOLDE.ColumnName = "HORAS_PREV_EROSAO_EWC_MOLDE";
            this.HORAS_PREV_EROSAO_EWC_MOLDE.DataType = typeof(double);
            // 
            // HORAS_PREV_POLIMENTO_MOLDE
            // 
            this.HORAS_PREV_POLIMENTO_MOLDE.ColumnName = "HORAS_PREV_POLIMENTO_MOLDE";
            this.HORAS_PREV_POLIMENTO_MOLDE.DataType = typeof(double);
            // 
            // HORAS_PREV_PROJETO_MOLDE
            // 
            this.HORAS_PREV_PROJETO_MOLDE.ColumnName = "HORAS_PREV_PROJETO_MOLDE";
            this.HORAS_PREV_PROJETO_MOLDE.DataType = typeof(double);
            // 
            // HORAS_PREV_PORTA_MOLDE_MOLDE
            // 
            this.HORAS_PREV_PORTA_MOLDE_MOLDE.ColumnName = "HORAS_PREV_PORTA_MOLDE_MOLDE";
            this.HORAS_PREV_PORTA_MOLDE_MOLDE.DataType = typeof(double);
            // 
            // HORAS_PREV_ELETRODO_MOLDE
            // 
            this.HORAS_PREV_ELETRODO_MOLDE.ColumnName = "HORAS_PREV_ELETRODO_MOLDE";
            this.HORAS_PREV_ELETRODO_MOLDE.DataType = typeof(double);
            // 
            // HORAS_EXEC_TORNO_MOLDE
            // 
            this.HORAS_EXEC_TORNO_MOLDE.ColumnName = "HORAS_EXEC_TORNO_MOLDE";
            this.HORAS_EXEC_TORNO_MOLDE.DataType = typeof(double);
            // 
            // HORAS_EXEC_FRESA_MOLDE
            // 
            this.HORAS_EXEC_FRESA_MOLDE.ColumnName = "HORAS_EXEC_FRESA_MOLDE";
            this.HORAS_EXEC_FRESA_MOLDE.DataType = typeof(double);
            // 
            // HORAS_EXEC_CNC_DES_MOLDE
            // 
            this.HORAS_EXEC_CNC_DES_MOLDE.ColumnName = "HORAS_EXEC_CNC_DES_MOLDE";
            this.HORAS_EXEC_CNC_DES_MOLDE.DataType = typeof(double);
            // 
            // HORAS_EXEC_TEMPERA_MOLDE
            // 
            this.HORAS_EXEC_TEMPERA_MOLDE.ColumnName = "HORAS_EXEC_TEMPERA_MOLDE";
            this.HORAS_EXEC_TEMPERA_MOLDE.DataType = typeof(double);
            // 
            // HORAS_EXEC_RETIFICA_MOLDE
            // 
            this.HORAS_EXEC_RETIFICA_MOLDE.ColumnName = "HORAS_EXEC_RETIFICA_MOLDE";
            this.HORAS_EXEC_RETIFICA_MOLDE.DataType = typeof(double);
            // 
            // HORAS_EXEC_RET_OPT_MOLDE
            // 
            this.HORAS_EXEC_RET_OPT_MOLDE.ColumnName = "HORAS_EXEC_RET_OPT_MOLDE";
            this.HORAS_EXEC_RET_OPT_MOLDE.DataType = typeof(double);
            // 
            // HORAS_EXEC_CNC_ACAB_MOLDE
            // 
            this.HORAS_EXEC_CNC_ACAB_MOLDE.ColumnName = "HORAS_EXEC_CNC_ACAB_MOLDE";
            this.HORAS_EXEC_CNC_ACAB_MOLDE.DataType = typeof(double);
            // 
            // HORAS_EXEC_EROSAO_EDM_MOLDE
            // 
            this.HORAS_EXEC_EROSAO_EDM_MOLDE.ColumnName = "HORAS_EXEC_EROSAO_EDM_MOLDE";
            this.HORAS_EXEC_EROSAO_EDM_MOLDE.DataType = typeof(double);
            // 
            // HORAS_EXEC_EROSAO_EWC_MOLDE
            // 
            this.HORAS_EXEC_EROSAO_EWC_MOLDE.ColumnName = "HORAS_EXEC_EROSAO_EWC_MOLDE";
            this.HORAS_EXEC_EROSAO_EWC_MOLDE.DataType = typeof(double);
            // 
            // HORAS_EXEC_POLIMENTO_MOLDE
            // 
            this.HORAS_EXEC_POLIMENTO_MOLDE.ColumnName = "HORAS_EXEC_POLIMENTO_MOLDE";
            this.HORAS_EXEC_POLIMENTO_MOLDE.DataType = typeof(double);
            // 
            // HORAS_EXEC_PROJETO_MOLDE
            // 
            this.HORAS_EXEC_PROJETO_MOLDE.ColumnName = "HORAS_EXEC_PROJETO_MOLDE";
            this.HORAS_EXEC_PROJETO_MOLDE.DataType = typeof(double);
            // 
            // HORAS_EXEC_PORTA_MOLDE_MOLDE
            // 
            this.HORAS_EXEC_PORTA_MOLDE_MOLDE.ColumnName = "HORAS_EXEC_PORTA_MOLDE_MOLDE";
            this.HORAS_EXEC_PORTA_MOLDE_MOLDE.DataType = typeof(double);
            // 
            // HORAS_EXEC_ELETRODO_MOLDE
            // 
            this.HORAS_EXEC_ELETRODO_MOLDE.ColumnName = "HORAS_EXEC_ELETRODO_MOLDE";
            this.HORAS_EXEC_ELETRODO_MOLDE.DataType = typeof(double);
            // 
            // HORAS_EXEC_DES_PC_ELET_MOLDE
            // 
            this.HORAS_EXEC_DES_PC_ELET_MOLDE.ColumnName = "HORAS_EXEC_DES_PC_ELET_MOLDE";
            this.HORAS_EXEC_DES_PC_ELET_MOLDE.DataType = typeof(double);
            // 
            // TOTAL_ITENS_DES
            // 
            this.TOTAL_ITENS_DES.ColumnName = "TOTAL_ITENS_DES";
            this.TOTAL_ITENS_DES.DataType = typeof(int);
            // 
            // ITENS_ENTREGUES_DES
            // 
            this.ITENS_ENTREGUES_DES.ColumnName = "ITENS_ENTREGUES_DES";
            this.ITENS_ENTREGUES_DES.DataType = typeof(int);
            // 
            // DATA_ABERTURA_PECA
            // 
            this.DATA_ABERTURA_PECA.ColumnName = "DATA_ABERTURA_PECA";
            this.DATA_ABERTURA_PECA.DataType = typeof(System.DateTime);
            // 
            // N_PC_PECA
            // 
            this.N_PC_PECA.ColumnName = "N_PC_PECA";
            this.N_PC_PECA.MaxLength = 50;
            // 
            // PRAZO_ENTREGA_PECA
            // 
            this.PRAZO_ENTREGA_PECA.ColumnName = "PRAZO_ENTREGA_PECA";
            this.PRAZO_ENTREGA_PECA.DataType = typeof(System.DateTime);
            // 
            // N_PROCESSO_PECA
            // 
            this.N_PROCESSO_PECA.ColumnName = "N_PROCESSO_PECA";
            this.N_PROCESSO_PECA.MaxLength = 50;
            // 
            // dataColumn11
            // 
            this.dataColumn11.ColumnName = "DESENHO_PECA";
            this.dataColumn11.DataType = typeof(byte[]);
            // 
            // dataColumn29
            // 
            this.dataColumn29.ColumnName = "RESPONSAVEL_PECA";
            this.dataColumn29.MaxLength = 200;
            // 
            // dataColumn9
            // 
            this.dataColumn9.ColumnName = "HORAS_PREVISTAS_INICIAIS_PECA";
            this.dataColumn9.DataType = typeof(double);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.label58);
            this.panel2.Controls.Add(this.tb_peca);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label55);
            this.panel2.Controls.Add(this.textBox14);
            this.panel2.Controls.Add(this.label54);
            this.panel2.Controls.Add(this.textBox13);
            this.panel2.Controls.Add(this.label53);
            this.panel2.Controls.Add(this.textBox12);
            this.panel2.Controls.Add(this.bt_abrir);
            this.panel2.Controls.Add(this.pb_desenho);
            this.panel2.Controls.Add(this.button14);
            this.panel2.Controls.Add(this.tb_data_abertura);
            this.panel2.Controls.Add(this.label27);
            this.panel2.Controls.Add(this.button10);
            this.panel2.Controls.Add(this.tb_pedido);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.tb_prazo_entrega_os);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.tb_cliente);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.tb_os);
            this.panel2.Location = new System.Drawing.Point(12, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(945, 114);
            this.panel2.TabIndex = 283;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(154, 88);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(138, 13);
            this.label58.TabIndex = 549;
            this.label58.Text = "Horas Prevista Inicialmente:";
            // 
            // tb_peca
            // 
            this.tb_peca.AcceptsReturn = true;
            this.tb_peca.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsDesenhos, "DESENHOS.NOME_PECA", true));
            this.tb_peca.Location = new System.Drawing.Point(300, 7);
            this.tb_peca.Name = "tb_peca";
            this.tb_peca.Size = new System.Drawing.Size(275, 20);
            this.tb_peca.TabIndex = 515;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsDesenhos, "DESENHOS.HORAS_PREVISTAS_INICIAIS_PECA", true));
            this.textBox2.Location = new System.Drawing.Point(291, 85);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(63, 20);
            this.textBox2.TabIndex = 548;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(225, 10);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 13);
            this.label14.TabIndex = 516;
            this.label14.Text = "Nome Peça:";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(722, 38);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(49, 13);
            this.label55.TabIndex = 514;
            this.label55.Text = "Revisão:";
            // 
            // textBox14
            // 
            this.textBox14.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsDesenhos, "DESENHOS.REVISAO", true));
            this.textBox14.Location = new System.Drawing.Point(772, 35);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(63, 20);
            this.textBox14.TabIndex = 513;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(662, 85);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(72, 13);
            this.label54.TabIndex = 512;
            this.label54.Text = "Responsável:";
            // 
            // textBox13
            // 
            this.textBox13.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsDesenhos, "DESENHOS.RESPONSAVEL_PECA", true));
            this.textBox13.Location = new System.Drawing.Point(735, 82);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(100, 20);
            this.textBox13.TabIndex = 511;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(674, 62);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(58, 13);
            this.label53.TabIndex = 510;
            this.label53.Text = "Projestista:";
            // 
            // textBox12
            // 
            this.textBox12.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsDesenhos, "DESENHOS.PROJETISTA_PECA", true));
            this.textBox12.Location = new System.Drawing.Point(735, 58);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 20);
            this.textBox12.TabIndex = 509;
            // 
            // bt_abrir
            // 
            this.bt_abrir.Location = new System.Drawing.Point(658, 35);
            this.bt_abrir.Name = "bt_abrir";
            this.bt_abrir.Size = new System.Drawing.Size(22, 23);
            this.bt_abrir.TabIndex = 508;
            this.bt_abrir.Text = "+";
            this.bt_abrir.UseVisualStyleBackColor = true;
            // 
            // pb_desenho
            // 
            this.pb_desenho.BackColor = System.Drawing.Color.White;
            this.pb_desenho.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.dsDesenhos, "DESENHOS.DESENHO_PECA", true));
            this.pb_desenho.Location = new System.Drawing.Point(557, 35);
            this.pb_desenho.Name = "pb_desenho";
            this.pb_desenho.Size = new System.Drawing.Size(99, 75);
            this.pb_desenho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_desenho.TabIndex = 507;
            this.pb_desenho.TabStop = false;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(819, 7);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(16, 20);
            this.button14.TabIndex = 506;
            this.button14.Text = "+";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // tb_data_abertura
            // 
            this.tb_data_abertura.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsDesenhos, "DESENHOS.DATA_ABERTURA_PECA", true));
            this.tb_data_abertura.Location = new System.Drawing.Point(479, 35);
            this.tb_data_abertura.Name = "tb_data_abertura";
            this.tb_data_abertura.Size = new System.Drawing.Size(66, 20);
            this.tb_data_abertura.TabIndex = 10;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(400, 38);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(76, 13);
            this.label27.TabIndex = 243;
            this.label27.Text = "Data Abertura:";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(81, 54);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(70, 20);
            this.button10.TabIndex = 6;
            this.button10.Text = "Imprimir";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // tb_pedido
            // 
            this.tb_pedido.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsDesenhos, "DESENHOS.N_PC_PECA", true));
            this.tb_pedido.Location = new System.Drawing.Point(492, 82);
            this.tb_pedido.Name = "tb_pedido";
            this.tb_pedido.Size = new System.Drawing.Size(53, 20);
            this.tb_pedido.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(374, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 13);
            this.label11.TabIndex = 173;
            this.label11.Text = "Nº Pedido de Compra:";
            // 
            // tb_prazo_entrega_os
            // 
            this.tb_prazo_entrega_os.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsDesenhos, "DESENHOS.DATA_ENTREGA_PECA", true));
            this.tb_prazo_entrega_os.Location = new System.Drawing.Point(479, 58);
            this.tb_prazo_entrega_os.Name = "tb_prazo_entrega_os";
            this.tb_prazo_entrega_os.Size = new System.Drawing.Size(66, 20);
            this.tb_prazo_entrega_os.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(400, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 171;
            this.label8.Text = "Prazo Entrega:";
            // 
            // tb_cliente
            // 
            this.tb_cliente.AcceptsReturn = true;
            this.tb_cliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsDesenhos, "DESENHOS.CLIENTE", true));
            this.tb_cliente.Location = new System.Drawing.Point(630, 7);
            this.tb_cliente.Name = "tb_cliente";
            this.tb_cliente.ReadOnly = true;
            this.tb_cliente.Size = new System.Drawing.Size(186, 20);
            this.tb_cliente.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(582, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 167;
            this.label10.Text = "Cliente:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 20);
            this.button1.TabIndex = 2;
            this.button1.Text = "Abrir OS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tb_os
            // 
            this.tb_os.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsDesenhos, "DESENHOS.N_OS_PECA", true));
            this.tb_os.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_os.Location = new System.Drawing.Point(4, 6);
            this.tb_os.Name = "tb_os";
            this.tb_os.Size = new System.Drawing.Size(211, 38);
            this.tb_os.TabIndex = 0;
            // 
            // datDesenhos
            // 
            this.datDesenhos.DeleteCommand = this.fbCommand15;
            this.datDesenhos.InsertCommand = this.fbCommand13;
            this.datDesenhos.SelectCommand = this.fbCommand12;
            this.datDesenhos.UpdateCommand = this.fbCommand14;
            // 
            // fbCommand15
            // 
            this.fbCommand15.CommandTimeout = 30;
            // 
            // fbCommand13
            // 
            this.fbCommand13.CommandTimeout = 30;
            // 
            // fbCommand12
            // 
            this.fbCommand12.CommandText = "select * from desenhos";
            this.fbCommand12.CommandTimeout = 30;
            this.fbCommand12.Connection = this.fbConnection1;
            // 
            // fbCommand14
            // 
            this.fbCommand14.CommandTimeout = 30;
            // 
            // tb_posicao_selecionada
            // 
            this.tb_posicao_selecionada.Location = new System.Drawing.Point(70, 186);
            this.tb_posicao_selecionada.Name = "tb_posicao_selecionada";
            this.tb_posicao_selecionada.Size = new System.Drawing.Size(53, 20);
            this.tb_posicao_selecionada.TabIndex = 284;
            this.tb_posicao_selecionada.Visible = false;
            // 
            // tb_item_selecionado
            // 
            this.tb_item_selecionado.Location = new System.Drawing.Point(11, 186);
            this.tb_item_selecionado.Name = "tb_item_selecionado";
            this.tb_item_selecionado.Size = new System.Drawing.Size(53, 20);
            this.tb_item_selecionado.TabIndex = 285;
            this.tb_item_selecionado.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(157, 54);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 20);
            this.button3.TabIndex = 550;
            this.button3.Text = "Planilha";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // form_resumo_os
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 712);
            this.Controls.Add(this.tb_item_selecionado);
            this.Controls.Add(this.tb_posicao_selecionada);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvPosicoes);
            this.Controls.Add(this.panel1);
            this.Name = "form_resumo_os";
            this.Text = "Finalização OS";
            this.Load += new System.EventHandler(this.form_resumo_os_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsItens_ped)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITENS_PEDIDO_COMPRA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens_ped)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosicoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsItens_terceiros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITENS_TERCEIROS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens_terceiros)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsApontamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.APONTAMENTOS)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApontamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSaida_estoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ESTOQUE_SAIDA)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaidas)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsDesenhos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DESENHOS)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_desenho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.DataSet dsItens_ped;
        private System.Data.DataTable ITENS_PEDIDO_COMPRA;
        private System.Data.DataColumn COD_ITEM_PED;
        private System.Data.DataColumn N_PEDIDO_ITEM_PED;
        private System.Data.DataColumn COD_ITEM_REQ_ITEM_PED;
        private System.Data.DataColumn OP_ITEM_PED;
        private System.Data.DataColumn QTDE_ITEM_PED;
        private System.Data.DataColumn UNID_ITEM_PED;
        private System.Data.DataColumn VALOR_UNIT_ITEM_PED;
        private System.Data.DataColumn VALOR_TOTAL_ITEM_PED;
        private System.Data.DataColumn DESCRICAO_ITEM_PED;
        private System.Data.DataColumn DATA_LIMITE_ITEM_PED;
        private System.Data.DataColumn COD_ESTOQUE_ITEM_PED;
        private System.Data.DataColumn POSICAO_ITEM_PED;
        private System.Data.DataColumn PESO_ITEM_PED;
        private System.Data.DataColumn CHEGOU_ITEM_PED;
        private System.Data.DataColumn COD_NF_ENTRADA_ITEM_PED;
        private System.Data.DataColumn DATA_ENTRADA_ITEM_PED;
        private System.Data.DataColumn PLANO_ITEM_PED;
        private System.Data.DataColumn ITEM_ITEM_PED;
        private System.Data.DataColumn FORNECEDOR_ITEM_PED;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datItens_ped;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Windows.Forms.DataGridView dgvItens_ped;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_valor_terceiros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tb_posicoes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvPosicoes;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datItens_terceiros;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand5;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand6;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand7;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand8;
        private System.Data.DataSet dsItens_terceiros;
        private System.Data.DataTable ITENS_TERCEIROS;
        private System.Data.DataColumn COD_ITEM_TERCEIRO;
        private System.Data.DataColumn OS_ITEM_TERCEIRO;
        private System.Data.DataColumn POSICAO_ITEM_TERCEIRO;
        private System.Data.DataColumn OPERACAO_ITEM_TERCEIRO;
        private System.Data.DataColumn QTDE_ITEM_TERCEIRO;
        private System.Data.DataColumn HORAS_ITEM_TERCEIRO;
        private System.Data.DataColumn DATA_SAIDA_ITEM_TERCEIRO;
        private System.Data.DataColumn HORA_SAIDA_ITEM_TERCEIRO;
        private System.Data.DataColumn DATA_ENTRADA_ITEM_TERCEIRO;
        private System.Data.DataColumn HORA_ENTRADA_ITEM_TERCEIRO;
        private System.Data.DataColumn DATA_PREVISTA_ITEM_TERCEIRO;
        private System.Data.DataColumn COD_FORN_ITEM_TERCEIRO;
        private System.Data.DataColumn NOME_FORN_ITEM_TERCEIRO;
        private System.Data.DataColumn COD_TERCEIRO_ITEM_TERCEIRO;
        private System.Data.DataColumn VALOR_ITEM_TERCEIRO;
        private System.Data.DataColumn DIMENSOES_ITEM_TERCEIRO;
        private System.Data.DataColumn MATERIAL_ITEM_TERCEIRO;
        private System.Data.DataColumn DUREZA_ITEM_TERCEIRO;
        private System.Data.DataColumn N_LOTE_ITEM_TERCEIRO;
        private System.Data.DataColumn DUREZA_ENC_ITEM_TERCEIRO;
        private System.Data.DataColumn OBSERVACAO_ITEM_TERCEIRO;
        private System.Data.DataColumn RESP_MEDICAO_ITEM_TERCEIRO;
        private System.Data.DataColumn ROTA_ITEM_TERCEIRO;
        private System.Data.DataColumn OPERADOR_ITEM_TERCEIRO;
        private System.Data.DataColumn FERRAMENTA_ITEM_TERCEIRO;
        private System.Data.DataColumn ITEM_ITEM_TERCEIRO;
        private System.Windows.Forms.TextBox tb_valor_compras;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvItens_terceiros;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
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
        private System.Data.DataColumn QTDE_AP;
        private System.Data.DataColumn RETRABALHO_AP;
        private System.Data.DataColumn MOTIVO_PARADA_AP;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datApontamentos;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_valor_servicos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvApontamentos;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand9;
        private System.Data.DataSet dsSaida_estoque;
        private System.Data.DataTable ESTOQUE_SAIDA;
        private System.Data.DataColumn COD_ESTOQUE_SAIDA;
        private System.Data.DataColumn ITEM_ESTOQUE_SAIDA;
        private System.Data.DataColumn COD_ITEM_ESTOQUE_SAIDA;
        private System.Data.DataColumn QTDE_ESTOQUE_SAIDA;
        private System.Data.DataColumn CRACHA_ESTOQUE_SAIDA;
        private System.Data.DataColumn OP_ESTOQUE_SAIDA;
        private System.Data.DataColumn DATA_ESTOQUE_SAIDA;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datSaida_estoque;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand10;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand11;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_valor_saidas_estoque;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvSaidas;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label13;
        private System.Data.DataSet dsDesenhos;
        private System.Data.DataTable DESENHOS;
        private System.Data.DataColumn COD_PECA;
        private System.Data.DataColumn N_OS_PECA;
        private System.Data.DataColumn REVISAO;
        private System.Data.DataColumn MATERIAL;
        private System.Data.DataColumn ESPESSURA;
        private System.Data.DataColumn CLIENTE;
        private System.Data.DataColumn ROTA;
        private System.Data.DataColumn NOME_PECA;
        private System.Data.DataColumn N_SUB;
        private System.Data.DataColumn N_ROTAS;
        private System.Data.DataColumn POSICAO_PECA;
        private System.Data.DataColumn FUNCAO_PECA;
        private System.Data.DataColumn DATA_ENTREGA_PECA;
        private System.Data.DataColumn OBS_PECA;
        private System.Data.DataColumn PROJETISTA_PECA;
        private System.Data.DataColumn DESPESAS_MOLDE_DES;
        private System.Data.DataColumn RECEITAS_MOLDE_DES;
        private System.Data.DataColumn HORAS_PREV_TORNO_MOLDE;
        private System.Data.DataColumn HORAS_PREV_FRESA_MOLDE;
        private System.Data.DataColumn HORAS_PREV_CNC_DES_MOLDE;
        private System.Data.DataColumn HORAS_PREV_TEMPERA_MOLDE;
        private System.Data.DataColumn HORAS_PREV_RETIFICA_MOLDE;
        private System.Data.DataColumn HORAS_PREV_RET_OPT_MOLDE;
        private System.Data.DataColumn HORAS_PREV_CNC_ACAB_MOLDE;
        private System.Data.DataColumn HORAS_PREV_EROSAO_EDM_MOLDE;
        private System.Data.DataColumn HORAS_PREV_EROSAO_EWC_MOLDE;
        private System.Data.DataColumn HORAS_PREV_POLIMENTO_MOLDE;
        private System.Data.DataColumn HORAS_PREV_PROJETO_MOLDE;
        private System.Data.DataColumn HORAS_PREV_PORTA_MOLDE_MOLDE;
        private System.Data.DataColumn HORAS_PREV_ELETRODO_MOLDE;
        private System.Data.DataColumn HORAS_EXEC_TORNO_MOLDE;
        private System.Data.DataColumn HORAS_EXEC_FRESA_MOLDE;
        private System.Data.DataColumn HORAS_EXEC_CNC_DES_MOLDE;
        private System.Data.DataColumn HORAS_EXEC_TEMPERA_MOLDE;
        private System.Data.DataColumn HORAS_EXEC_RETIFICA_MOLDE;
        private System.Data.DataColumn HORAS_EXEC_RET_OPT_MOLDE;
        private System.Data.DataColumn HORAS_EXEC_CNC_ACAB_MOLDE;
        private System.Data.DataColumn HORAS_EXEC_EROSAO_EDM_MOLDE;
        private System.Data.DataColumn HORAS_EXEC_EROSAO_EWC_MOLDE;
        private System.Data.DataColumn HORAS_EXEC_POLIMENTO_MOLDE;
        private System.Data.DataColumn HORAS_EXEC_PROJETO_MOLDE;
        private System.Data.DataColumn HORAS_EXEC_PORTA_MOLDE_MOLDE;
        private System.Data.DataColumn HORAS_EXEC_ELETRODO_MOLDE;
        private System.Data.DataColumn HORAS_EXEC_DES_PC_ELET_MOLDE;
        private System.Data.DataColumn TOTAL_ITENS_DES;
        private System.Data.DataColumn ITENS_ENTREGUES_DES;
        private System.Data.DataColumn DATA_ABERTURA_PECA;
        private System.Data.DataColumn N_PC_PECA;
        private System.Data.DataColumn PRAZO_ENTREGA_PECA;
        private System.Data.DataColumn N_PROCESSO_PECA;
        private System.Data.DataColumn dataColumn11;
        private System.Data.DataColumn dataColumn29;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tb_peca;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Button bt_abrir;
        private System.Windows.Forms.PictureBox pb_desenho;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.TextBox tb_data_abertura;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox tb_pedido;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_prazo_entrega_os;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_cliente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_os;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datDesenhos;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand15;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand13;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand12;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand14;
        private System.Windows.Forms.TextBox tb_total_os;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tb_posicao_selecionada;
        private System.Windows.Forms.TextBox tb_item_selecionado;
        private System.Windows.Forms.CheckBox cbSomarCompras;
        private System.Windows.Forms.CheckBox cbSomarTerceiros;
        private System.Windows.Forms.CheckBox cbSomarServicos;
        private System.Windows.Forms.CheckBox cbSomarSaidasEstoque;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod_saida;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTEMESTOQUESAIDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_qtde_saida;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_valor_saida;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRACHAESTOQUESAIDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPESTOQUESAIDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAESTOQUESAIDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_lote;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nf;
        private System.Data.DataColumn dataColumn7;
        private System.Data.DataColumn dataColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_valor_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod_estoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_qtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_unid;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_valor_unit;
        private System.Windows.Forms.DataGridViewButtonColumn Req;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATALIMITEITEMPEDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPITEMPEDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_chegou;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nf_entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA_CHEGADA_ITEM_PED;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_lote_compras;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_forn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_horas;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_operacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_rota;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_os;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_posicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_qt;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_operador;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATASAIDAITEMTERCEIRODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORASAIDAITEMTERCEIRODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAENTRADAITEMTERCEIRODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORAENTRADAITEMTERCEIRODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAPREVISTAITEMTERCEIRODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODFORNITEMTERCEIRODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Data.DataColumn dataColumn9;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3;
    }
}