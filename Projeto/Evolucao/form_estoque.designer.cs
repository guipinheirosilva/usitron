namespace Evolucao
{
    partial class form_estoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_estoque));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.apaga_registro = new System.Windows.Forms.Button();
            this.salva_registro = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.novo_registro = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_cod = new System.Windows.Forms.TextBox();
            this.dsEstoque = new System.Data.DataSet();
            this.ESTOQUE = new System.Data.DataTable();
            this.COD_ESTOQUE = new System.Data.DataColumn();
            this.ITEM_ESTOQUE = new System.Data.DataColumn();
            this.DESCRICAO_ESTOQUE = new System.Data.DataColumn();
            this.GRUPO_ESTOQUE = new System.Data.DataColumn();
            this.CLIENTE_ESTOQUE = new System.Data.DataColumn();
            this.MATERIAL_ESTOQUE = new System.Data.DataColumn();
            this.DIMENSAO_ESTOQUE = new System.Data.DataColumn();
            this.PRAZO_MEDIO_ESTOQUE = new System.Data.DataColumn();
            this.LOCALIZACAO_ESTOQUE = new System.Data.DataColumn();
            this.ESPESSURA_ESTOQUE = new System.Data.DataColumn();
            this.ESTOQUE_MINIMO_ESTOQUE = new System.Data.DataColumn();
            this.ESTOQUE_ATUAL_ESTOQUE = new System.Data.DataColumn();
            this.CHAPA_ESTOQUE = new System.Data.DataColumn();
            this.COD_BARRAS_ITEM_FABRICANTE = new System.Data.DataColumn();
            this.MARCA_ESTOQUE = new System.Data.DataColumn();
            this.OBSERVACOES_ESTOQUE = new System.Data.DataColumn();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
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
            this.dataColumn17 = new System.Data.DataColumn();
            this.dataColumn20 = new System.Data.DataColumn();
            this.dataColumn21 = new System.Data.DataColumn();
            this.dataColumn24 = new System.Data.DataColumn();
            this.dataColumn25 = new System.Data.DataColumn();
            this.tb_item = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_grupo = new System.Windows.Forms.TextBox();
            this.tb_estoque_atual = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_estoque_minimo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_localizacao = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_dimensao = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_espessura = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_material = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dsItens_nf = new System.Data.DataSet();
            this.ITENS_NF_ENTRADA = new System.Data.DataTable();
            this.COD_CONTROLE_ITENS_NF_ENT = new System.Data.DataColumn();
            this.COD_ITENS_NF_ENT = new System.Data.DataColumn();
            this.ITEM_ITENS_NF_ENT = new System.Data.DataColumn();
            this.QTDE_ITENS_NF_ENT = new System.Data.DataColumn();
            this.VALOR_ITENS_NF_ENT = new System.Data.DataColumn();
            this.N_NOTA_ITENS_NF_ENT = new System.Data.DataColumn();
            this.FORN_ITENS_NF_ENT = new System.Data.DataColumn();
            this.DATA_ENT_ITENS_NF_ENT = new System.Data.DataColumn();
            this.PEDIDO_COMPRA_ITENS_NF_ENT = new System.Data.DataColumn();
            this.COD_NOTA_ITENS_NF_ENT = new System.Data.DataColumn();
            this.tb_prazo_medio = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.datEstoque = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.cbEstoque = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.tb_marca = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tb_obs = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.bt_imprimir_cod = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.datItens_nf = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand8 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand6 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand5 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand7 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.label21 = new System.Windows.Forms.Label();
            this.datSaida_estoque = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand12 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand10 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand9 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand11 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsSaida_estoque = new System.Data.DataSet();
            this.ESTOQUE_SAIDA = new System.Data.DataTable();
            this.COD_ESTOQUE_SAIDA = new System.Data.DataColumn();
            this.ITEM_ESTOQUE_SAIDA = new System.Data.DataColumn();
            this.COD_ITEM_ESTOQUE_SAIDA = new System.Data.DataColumn();
            this.QTDE_ESTOQUE_SAIDA = new System.Data.DataColumn();
            this.CRACHA_ESTOQUE_SAIDA = new System.Data.DataColumn();
            this.OP_ESTOQUE_SAIDA = new System.Data.DataColumn();
            this.DATA_ESTOQUE_SAIDA = new System.Data.DataColumn();
            this.dataColumn22 = new System.Data.DataColumn();
            this.dataColumn23 = new System.Data.DataColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.cODESTOQUESAIDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODITEMESTOQUESAIDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTEMESTOQUESAIDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAESTOQUESAIDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qTDEESTOQUESAIDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRACHAESTOQUESAIDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.POS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOTE_ESTOQUE_SAIDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PALETE_ESTOQUE_SAIDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datItens_ped = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand16 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand14 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand13 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand15 = new FirebirdSql.Data.FirebirdClient.FbCommand();
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
            this.CHEGOU_ITEM_PED = new System.Data.DataColumn();
            this.COD_NF_ENTRADA_ITEM_PED = new System.Data.DataColumn();
            this.AUTORIZANTE_ITEM_PED = new System.Data.DataColumn();
            this.DATA_AUTORIZACAO_ITEM_PED = new System.Data.DataColumn();
            this.HORA_AUTORIZACAO_ITEM_PED = new System.Data.DataColumn();
            this.DATA_CHEGADA_ITEM_PED = new System.Data.DataColumn();
            this.dgvItens_ped = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_valor_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_tipo = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_comprimento = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.tb_cliente = new System.Windows.Forms.TextBox();
            this.tb_cnpj_cliente = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.tb_acabamento = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.tb_classificacao = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgvRequisicoes = new System.Windows.Forms.DataGridView();
            this.rEQUISITANTEITEMREQDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODREQITEMREQDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPITEMREQDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qTDEITEMREQDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sETORITEMREQDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAREQUISICAOITEMREQDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sITUACAOATUALITEMREQDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsItens_requisicao = new System.Data.DataSet();
            this.ITENS_REQUISICAO = new System.Data.DataTable();
            this.COD_ITEM_REQ = new System.Data.DataColumn();
            this.COD_REQ_ITEM_REQ = new System.Data.DataColumn();
            this.OP_ITEM_REQ = new System.Data.DataColumn();
            this.QTDE_ITEM_REQ = new System.Data.DataColumn();
            this.UNIDADE_ITEM_REQ = new System.Data.DataColumn();
            this.COD_ESTOQUE_ITEM_REQ = new System.Data.DataColumn();
            this.DESCRICAO_ITEM_REQ = new System.Data.DataColumn();
            this.DATA_LIMITE_ITEM_REQ = new System.Data.DataColumn();
            this.URGENTE_ITEM_REQ = new System.Data.DataColumn();
            this.REQUISITANTE_ITEM_REQ = new System.Data.DataColumn();
            this.SETOR_ITEM_REQ = new System.Data.DataColumn();
            this.DATA_REQUISICAO_ITEM_REQ = new System.Data.DataColumn();
            this.SITUACAO_ATUAL_ITEM_REQ = new System.Data.DataColumn();
            this.AUTORIZADO_POR_ITEM_REQ = new System.Data.DataColumn();
            this.CLIENTE_ITEM_REQ = new System.Data.DataColumn();
            this.FORNECEDOR_ITEM_REQ = new System.Data.DataColumn();
            this.label22 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dgvItens_nota_ent = new System.Windows.Forms.DataGridView();
            this.qTDEITEMENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTDE_LOTE_ITEM_ENT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOTE_ITEM_ENT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nFITEMENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRECOUNITITEMENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNPJCLIENTEITEMENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pEDIDOCOMPRAITEMENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nLINHAPEDITEMENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODITEMREQITEMENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODITEMPEDITEMENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODITEMESTITEMENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsItens_nota_ent = new System.Data.DataSet();
            this.ITENS_NOTA_ENT = new System.Data.DataTable();
            this.COD_ITENS_NOTA_ENT = new System.Data.DataColumn();
            this.DESCRICAO_ITEM_ENT = new System.Data.DataColumn();
            this.UNIDADE_ITEM_ENT = new System.Data.DataColumn();
            this.QTDE_ITEM_ENT = new System.Data.DataColumn();
            this.ST_ITEM_ENT = new System.Data.DataColumn();
            this.PRECO_UNIT_ITEM_ENT = new System.Data.DataColumn();
            this.PRECO_TOTAL_ITEM_ENT = new System.Data.DataColumn();
            this.IPI_ITEM_ENT = new System.Data.DataColumn();
            this.ICM_ITEM_ENT = new System.Data.DataColumn();
            this.NF_ITEM_ENT = new System.Data.DataColumn();
            this.VALOR_IPI_ITEM_ENT = new System.Data.DataColumn();
            this.PEDIDO_COMPRA_ITEM_ENT = new System.Data.DataColumn();
            this.MAE_ITEM_ENT = new System.Data.DataColumn();
            this.COD_ITEM_ENT = new System.Data.DataColumn();
            this.CFOP_ITEM_ENT = new System.Data.DataColumn();
            this.VALOR_ICM_ITEM_ENT = new System.Data.DataColumn();
            this.VALOR_ISS_ITEM_ENT = new System.Data.DataColumn();
            this.PRESTACAO_SERVICO_ITEM_ENT = new System.Data.DataColumn();
            this.VALOR_BC_ITEM_ENT = new System.Data.DataColumn();
            this.COD_COMISSIONARIO_ITEM_ENT = new System.Data.DataColumn();
            this.VALOR_UNIT_COMISSAO_ITEM_ENT = new System.Data.DataColumn();
            this.VALOR_TOTAL_COMISSAO_ITEM_ENT = new System.Data.DataColumn();
            this.DATA_INSERCAO_ITEM_ENT_NOTA = new System.Data.DataColumn();
            this.CNPJ_CLIENTE_ITEM_ENT = new System.Data.DataColumn();
            this.STATUS_ATUAL_NFE_ENT = new System.Data.DataColumn();
            this.PORC_COMISSAO_ITEM_ENT = new System.Data.DataColumn();
            this.N_LINHA_PED_ITEM_ENT = new System.Data.DataColumn();
            this.VALOR_BC_ICMS_ST_ITEM_ENT = new System.Data.DataColumn();
            this.VALOR_ICMS_ST_ITEM_ENT = new System.Data.DataColumn();
            this.VALOR_FRETE_ITEM_ENT = new System.Data.DataColumn();
            this.VALOR_DESCONTO_ITEM_ENT = new System.Data.DataColumn();
            this.VALOR_SEGURO_ITEM_ENT = new System.Data.DataColumn();
            this.VALOR_OUTRAS_DESP_ITEM_ENT = new System.Data.DataColumn();
            this.IVA_ITEM_ENT = new System.Data.DataColumn();
            this.REDUCAO_ITEM_ENT = new System.Data.DataColumn();
            this.COFINS_ITEM_ENT = new System.Data.DataColumn();
            this.VALOR_COFINS_ITEM_ENT = new System.Data.DataColumn();
            this.PIS_ITEM_ENT = new System.Data.DataColumn();
            this.VALOR_PIS_ITEM_ENT = new System.Data.DataColumn();
            this.ORIGEM_ITEM_ENT = new System.Data.DataColumn();
            this.MOD_BC_ITEM_ENT = new System.Data.DataColumn();
            this.ISS_ITEM_ENT = new System.Data.DataColumn();
            this.MOD_BC_ST_ITEM_ENT = new System.Data.DataColumn();
            this.REDUCAO_ST_ITEM_ENT = new System.Data.DataColumn();
            this.ICMS_ST_ITEM_ENT = new System.Data.DataColumn();
            this.ALIQUOTA_CREDITO_ITEM_ENT = new System.Data.DataColumn();
            this.VALOR_CREDITO_ITEM_ENT = new System.Data.DataColumn();
            this.IPI_TRIB_ITEM_ENT = new System.Data.DataColumn();
            this.IPI_N_TRIB_ITEM_ENT = new System.Data.DataColumn();
            this.CST_IPI_TRIB_ITEM_ENT = new System.Data.DataColumn();
            this.CST_IPI_N_TRIB_ITEM_ENT = new System.Data.DataColumn();
            this.TIPO_PIS_ITEM_ENT = new System.Data.DataColumn();
            this.CST_PIS_ITEM_ENT = new System.Data.DataColumn();
            this.TIPO_COFINS_ITEM_ENT = new System.Data.DataColumn();
            this.CST_COFINS_ITEM_ENT = new System.Data.DataColumn();
            this.TIPO_SERVICO_ITEM_ENT = new System.Data.DataColumn();
            this.ITEM_PEDIDO_COMPRA_ITEM_ENT = new System.Data.DataColumn();
            this.BC_IPI_ITEM_ENT = new System.Data.DataColumn();
            this.BC_PIS_ITEM_ENT = new System.Data.DataColumn();
            this.BC_COFINS_ITEM_ENT = new System.Data.DataColumn();
            this.BC_ISS_ITEM_ENT = new System.Data.DataColumn();
            this.BC_COM_IPI_ITEM_ENT = new System.Data.DataColumn();
            this.ST_IMPRESSAO_ITEM_ENT = new System.Data.DataColumn();
            this.ROTA_ITEM_ENT = new System.Data.DataColumn();
            this.DI_ITEM_ENT = new System.Data.DataColumn();
            this.DATA_DI_ITEM_ENT = new System.Data.DataColumn();
            this.LOCAL_DES_ITEM_ENT = new System.Data.DataColumn();
            this.UF_DES_ITEM_ENT = new System.Data.DataColumn();
            this.DATA_DES_ITEM_ENT = new System.Data.DataColumn();
            this.COD_EXP_ITEM_ENT = new System.Data.DataColumn();
            this.COD_ITEM_REQ_ITEM_ENT = new System.Data.DataColumn();
            this.COD_ITEM_PED_ITEM_ENT = new System.Data.DataColumn();
            this.COD_ITEM_EST_ITEM_ENT = new System.Data.DataColumn();
            this.COD_SISTEMA_NF_ITEM_ENT = new System.Data.DataColumn();
            this.NCM_ITEM_ENT = new System.Data.DataColumn();
            this.dataColumn18 = new System.Data.DataColumn();
            this.dataColumn26 = new System.Data.DataColumn();
            this.label27 = new System.Windows.Forms.Label();
            this.datItens_nota_ent = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand20 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand18 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand17 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand19 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand21 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand22 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand23 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand24 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.datItens_requisicao = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand28 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand26 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand25 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand27 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.cbSaida_estoque = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.cbItens_nota_ent = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.button11 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvOp = new System.Windows.Forms.DataGridView();
            this.cODOPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.POSICAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qTDEMATERIALOPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMEPECAOPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mATERIALRETIRADOOPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
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
            this.LOTE = new System.Data.DataColumn();
            this.ESPESSURA_OP = new System.Data.DataColumn();
            this.OBSERVACOES_OP = new System.Data.DataColumn();
            this.REVISAO_OP = new System.Data.DataColumn();
            this.DESCRICAO_PECA_OP = new System.Data.DataColumn();
            this.MARCA_OP = new System.Data.DataColumn();
            this.UNIDADE_OP = new System.Data.DataColumn();
            this.ICMS_OP = new System.Data.DataColumn();
            this.IPI_OP = new System.Data.DataColumn();
            this.SIT_OP = new System.Data.DataColumn();
            this.UNID_OP = new System.Data.DataColumn();
            this.PRECO_UNIT = new System.Data.DataColumn();
            this.OP_MAE = new System.Data.DataColumn();
            this.CLIENTE_OP = new System.Data.DataColumn();
            this.SIT_ATUAL_OP = new System.Data.DataColumn();
            this.PORC_A_MAIS_OP = new System.Data.DataColumn();
            this.NOME_PECA_OP = new System.Data.DataColumn();
            this.NCM_OP = new System.Data.DataColumn();
            this.QTDE_FATURADA_OP = new System.Data.DataColumn();
            this.NFS_FATURADAS_OP = new System.Data.DataColumn();
            this.N_OPERACOES_OP = new System.Data.DataColumn();
            this.DATA_ULT_ALTERACAO_OP = new System.Data.DataColumn();
            this.HORA_ULT_ALTERACAO_OP = new System.Data.DataColumn();
            this.COD_COMISSIONARIO_OP = new System.Data.DataColumn();
            this.NOME_COMISSIONARIO_OP = new System.Data.DataColumn();
            this.VALOR_COMISSAO_OP = new System.Data.DataColumn();
            this.PROJETO_OP = new System.Data.DataColumn();
            this.ITEM_OP = new System.Data.DataColumn();
            this.PORC_COMISSAO_OP = new System.Data.DataColumn();
            this.PREVISAO_OP = new System.Data.DataColumn();
            this.COLOCADO_EM_ESTOQUE_OP = new System.Data.DataColumn();
            this.DATA_EMISSAO_OP = new System.Data.DataColumn();
            this.OPERADOR_CRIADOR_OP = new System.Data.DataColumn();
            this.PORC_SUCATA_OP = new System.Data.DataColumn();
            this.FUNCAO_OP = new System.Data.DataColumn();
            this.FERRAMENTA_OP = new System.Data.DataColumn();
            this.FINALIZADO_OP = new System.Data.DataColumn();
            this.POSICAO_ATUAL_OP = new System.Data.DataColumn();
            this.TRAT_TERMICO_OP = new System.Data.DataColumn();
            this.MATERIAL_FORN_OP = new System.Data.DataColumn();
            this.NF_MATERIAL_OP = new System.Data.DataColumn();
            this.DUREZA_SOLIC_OP = new System.Data.DataColumn();
            this.DUREZA_ENC_OP = new System.Data.DataColumn();
            this.NF_SAIDA_OP = new System.Data.DataColumn();
            this.DATA_NF_SAIDA = new System.Data.DataColumn();
            this.PROCESSO_OP = new System.Data.DataColumn();
            this.CODIGO_OP = new System.Data.DataColumn();
            this.DATA_ENTRADA_OP = new System.Data.DataColumn();
            this.COD_MATERIAL_OP = new System.Data.DataColumn();
            this.QTDE_MATERIAL_OP = new System.Data.DataColumn();
            this.MATERIAL_RETIRADO_OP = new System.Data.DataColumn();
            this.QTDE_EST_POR_MATERIAL_OP = new System.Data.DataColumn();
            this.COD_ACAB_SUP_OP = new System.Data.DataColumn();
            this.DESCRICAO_ACAB_SUP_OP = new System.Data.DataColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.datOp = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand32 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand30 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand29 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand31 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cODLOTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sALDODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsLotes = new System.Data.DataSet();
            this.LOTES = new System.Data.DataTable();
            this.COD_LOTE = new System.Data.DataColumn();
            this.SALDO = new System.Data.DataColumn();
            this.dataColumn19 = new System.Data.DataColumn();
            this.label36 = new System.Windows.Forms.Label();
            this.datLotes = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.gbxControle = new System.Windows.Forms.GroupBox();
            this.button12 = new System.Windows.Forms.Button();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.txtPlanoControle = new System.Windows.Forms.TextBox();
            this.txtCodControle = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label41 = new System.Windows.Forms.Label();
            this.tb_cnpj_forn = new System.Windows.Forms.TextBox();
            this.bt_localizar_forn = new System.Windows.Forms.Button();
            this.label42 = new System.Windows.Forms.Label();
            this.tb_nome_forn = new System.Windows.Forms.TextBox();
            this.dgvEstoque_fornecedor = new System.Windows.Forms.DataGridView();
            this.cODEFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNPJEFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAZAOFORNECEDOREFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODESTOQUEEFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUTOEFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsEstoque_fornecedor = new System.Data.DataSet();
            this.ESTOQUE_FORNECEDOR = new System.Data.DataTable();
            this.COD_EF = new System.Data.DataColumn();
            this.CNPJ_EF = new System.Data.DataColumn();
            this.RAZAO_FORNECEDOR_EF = new System.Data.DataColumn();
            this.COD_ESTOQUE_EF = new System.Data.DataColumn();
            this.PRODUTO_EF = new System.Data.DataColumn();
            this.panel9 = new System.Windows.Forms.Panel();
            this.datEstoque_fornecedor = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand36 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand34 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand33 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand35 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.cbEstoque_fornecedor = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.dgvNFs = new System.Windows.Forms.DataGridView();
            this.nFITEMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODEANITEMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qTDEITEMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFOPITEMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRICAOITEMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uNIDADEITEMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRECOUNITITEMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRECOTOTALITEMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODITEMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsItens_nota = new System.Data.DataSet();
            this.ITENS_NOTA = new System.Data.DataTable();
            this.COD_ITENS_NOTA = new System.Data.DataColumn();
            this.DESCRICAO_ITEM = new System.Data.DataColumn();
            this.UNIDADE_ITEM = new System.Data.DataColumn();
            this.QTDE_ITEM = new System.Data.DataColumn();
            this.ST_ITEM = new System.Data.DataColumn();
            this.PRECO_UNIT_ITEM = new System.Data.DataColumn();
            this.PRECO_TOTAL_ITEM = new System.Data.DataColumn();
            this.IPI_ITEM = new System.Data.DataColumn();
            this.ICM_ITEM = new System.Data.DataColumn();
            this.NF_ITEM = new System.Data.DataColumn();
            this.VALOR_IPI_ITEM = new System.Data.DataColumn();
            this.PEDIDO_COMPRA_ITEM = new System.Data.DataColumn();
            this.MAE_ITEM = new System.Data.DataColumn();
            this.COD_ITEM = new System.Data.DataColumn();
            this.NCM_ITEM = new System.Data.DataColumn();
            this.CFOP_ITEM = new System.Data.DataColumn();
            this.VALOR_ICM_ITEM = new System.Data.DataColumn();
            this.VALOR_ISS_ITEM = new System.Data.DataColumn();
            this.PRESTACAO_SERVICO_ITEM = new System.Data.DataColumn();
            this.VALOR_BC_ITEM = new System.Data.DataColumn();
            this.VALOR_BC_ICMS_ST_ITEM = new System.Data.DataColumn();
            this.VALOR_ICMS_ST_ITEM = new System.Data.DataColumn();
            this.VALOR_FRETE_ITEM = new System.Data.DataColumn();
            this.VALOR_DESCONTO_ITEM = new System.Data.DataColumn();
            this.VALOR_SEGURO_ITEM = new System.Data.DataColumn();
            this.VALOR_OUTRAS_DESP_ITEM = new System.Data.DataColumn();
            this.IVA_ITEM = new System.Data.DataColumn();
            this.REDUCAO_ITEM = new System.Data.DataColumn();
            this.COFINS_ITEM = new System.Data.DataColumn();
            this.VALOR_COFINS_ITEM = new System.Data.DataColumn();
            this.PIS_ITEM = new System.Data.DataColumn();
            this.VALOR_PIS_ITEM = new System.Data.DataColumn();
            this.ORIGEM_ITEM = new System.Data.DataColumn();
            this.MOD_BC_ITEM = new System.Data.DataColumn();
            this.ISS_ITEM = new System.Data.DataColumn();
            this.MOD_BC_ST_ITEM = new System.Data.DataColumn();
            this.REDUCAO_ST_ITEM = new System.Data.DataColumn();
            this.ICMS_ST_ITEM = new System.Data.DataColumn();
            this.ALIQUOTA_CREDITO_ITEM = new System.Data.DataColumn();
            this.VALOR_CREDITO_ITEM = new System.Data.DataColumn();
            this.IPI_TRIB_ITEM = new System.Data.DataColumn();
            this.IPI_N_TRIB_ITEM = new System.Data.DataColumn();
            this.CST_IPI_TRIB_ITEM = new System.Data.DataColumn();
            this.CST_IPI_N_TRIB_ITEM = new System.Data.DataColumn();
            this.TIPO_PIS_ITEM = new System.Data.DataColumn();
            this.CST_PIS_ITEM = new System.Data.DataColumn();
            this.TIPO_COFINS_ITEM = new System.Data.DataColumn();
            this.CST_COFINS_ITEM = new System.Data.DataColumn();
            this.TIPO_SERVICO_ITEM = new System.Data.DataColumn();
            this.ITEM_PEDIDO_COMPRA_ITEM = new System.Data.DataColumn();
            this.BC_IPI_ITEM = new System.Data.DataColumn();
            this.BC_PIS_ITEM = new System.Data.DataColumn();
            this.BC_COFINS_ITEM = new System.Data.DataColumn();
            this.BC_ISS_ITEM = new System.Data.DataColumn();
            this.BC_COM_IPI_ITEM = new System.Data.DataColumn();
            this.ST_IMPRESSAO_ITEM = new System.Data.DataColumn();
            this.COD_EAN_ITEM = new System.Data.DataColumn();
            this.PORC_TRIB_ITEM = new System.Data.DataColumn();
            this.TOTAL_TRIB_ITEM = new System.Data.DataColumn();
            this.PRECO_MINIMO_ITEM = new System.Data.DataColumn();
            this.CUSTO_ITEM = new System.Data.DataColumn();
            this.CEST_ITEM = new System.Data.DataColumn();
            this.COD_SISTEMA_NF_ITEM = new System.Data.DataColumn();
            this.VBCSTRET_ITEM = new System.Data.DataColumn();
            this.PST_ITEM = new System.Data.DataColumn();
            this.VICMSSUBSTITUTO_ITEM = new System.Data.DataColumn();
            this.VICMSSTRET_ITEM = new System.Data.DataColumn();
            this.label43 = new System.Windows.Forms.Label();
            this.datItens_nota = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand40 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand38 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand37 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand39 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvItens_produto = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dsEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ESTOQUE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsItens_nf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITENS_NF_ENTRADA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSaida_estoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ESTOQUE_SAIDA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsItens_ped)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITENS_PEDIDO_COMPRA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens_ped)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequisicoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsItens_requisicao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITENS_REQUISICAO)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens_nota_ent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsItens_nota_ent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITENS_NOTA_ENT)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OP)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LOTES)).BeginInit();
            this.gbxControle.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque_fornecedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEstoque_fornecedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ESTOQUE_FORNECEDOR)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNFs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsItens_nota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITENS_NOTA)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens_produto)).BeginInit();
            this.SuspendLayout();
            // 
            // apaga_registro
            // 
            this.apaga_registro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apaga_registro.Location = new System.Drawing.Point(246, 290);
            this.apaga_registro.Name = "apaga_registro";
            this.apaga_registro.Size = new System.Drawing.Size(57, 81);
            this.apaga_registro.TabIndex = 2;
            this.apaga_registro.Text = "Excluir";
            this.apaga_registro.UseVisualStyleBackColor = true;
            this.apaga_registro.Click += new System.EventHandler(this.apaga_registro_Click);
            // 
            // salva_registro
            // 
            this.salva_registro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salva_registro.Location = new System.Drawing.Point(309, 290);
            this.salva_registro.Name = "salva_registro";
            this.salva_registro.Size = new System.Drawing.Size(60, 81);
            this.salva_registro.TabIndex = 4;
            this.salva_registro.Text = "Salvar";
            this.salva_registro.UseVisualStyleBackColor = true;
            this.salva_registro.Click += new System.EventHandler(this.salva_registro_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(101, 290);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 81);
            this.button3.TabIndex = 0;
            this.button3.Text = "Localizar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // novo_registro
            // 
            this.novo_registro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.novo_registro.Location = new System.Drawing.Point(177, 290);
            this.novo_registro.Name = "novo_registro";
            this.novo_registro.Size = new System.Drawing.Size(63, 81);
            this.novo_registro.TabIndex = 1;
            this.novo_registro.Text = "Novo";
            this.novo_registro.UseVisualStyleBackColor = true;
            this.novo_registro.Click += new System.EventHandler(this.novo_registro_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label20.Location = new System.Drawing.Point(394, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(216, 46);
            this.label20.TabIndex = 49;
            this.label20.Text = "ESTOQUE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Cód.";
            // 
            // tb_cod
            // 
            this.tb_cod.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsEstoque, "ESTOQUE.COD_ESTOQUE", true));
            this.tb_cod.Location = new System.Drawing.Point(85, 23);
            this.tb_cod.Name = "tb_cod";
            this.tb_cod.ReadOnly = true;
            this.tb_cod.Size = new System.Drawing.Size(74, 20);
            this.tb_cod.TabIndex = 51;
            // 
            // dsEstoque
            // 
            this.dsEstoque.DataSetName = "dsEstoque";
            this.dsEstoque.Namespace = "http://www.tempuri.org/dsEstoque.xsd";
            this.dsEstoque.Tables.AddRange(new System.Data.DataTable[] {
            this.ESTOQUE});
            // 
            // ESTOQUE
            // 
            this.ESTOQUE.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_ESTOQUE,
            this.ITEM_ESTOQUE,
            this.DESCRICAO_ESTOQUE,
            this.GRUPO_ESTOQUE,
            this.CLIENTE_ESTOQUE,
            this.MATERIAL_ESTOQUE,
            this.DIMENSAO_ESTOQUE,
            this.PRAZO_MEDIO_ESTOQUE,
            this.LOCALIZACAO_ESTOQUE,
            this.ESPESSURA_ESTOQUE,
            this.ESTOQUE_MINIMO_ESTOQUE,
            this.ESTOQUE_ATUAL_ESTOQUE,
            this.CHAPA_ESTOQUE,
            this.COD_BARRAS_ITEM_FABRICANTE,
            this.MARCA_ESTOQUE,
            this.OBSERVACOES_ESTOQUE,
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5,
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
            this.dataColumn17,
            this.dataColumn20,
            this.dataColumn21,
            this.dataColumn24,
            this.dataColumn25});
            this.ESTOQUE.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_ESTOQUE"}, true)});
            this.ESTOQUE.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_ESTOQUE};
            this.ESTOQUE.TableName = "ESTOQUE";
            // 
            // COD_ESTOQUE
            // 
            this.COD_ESTOQUE.AllowDBNull = false;
            this.COD_ESTOQUE.ColumnName = "COD_ESTOQUE";
            this.COD_ESTOQUE.DataType = typeof(int);
            // 
            // ITEM_ESTOQUE
            // 
            this.ITEM_ESTOQUE.ColumnName = "ITEM_ESTOQUE";
            this.ITEM_ESTOQUE.MaxLength = 100;
            // 
            // DESCRICAO_ESTOQUE
            // 
            this.DESCRICAO_ESTOQUE.ColumnName = "DESCRICAO_ESTOQUE";
            this.DESCRICAO_ESTOQUE.MaxLength = 100;
            // 
            // GRUPO_ESTOQUE
            // 
            this.GRUPO_ESTOQUE.ColumnName = "GRUPO_ESTOQUE";
            this.GRUPO_ESTOQUE.MaxLength = 100;
            // 
            // CLIENTE_ESTOQUE
            // 
            this.CLIENTE_ESTOQUE.ColumnName = "CLIENTE_ESTOQUE";
            this.CLIENTE_ESTOQUE.MaxLength = 100;
            // 
            // MATERIAL_ESTOQUE
            // 
            this.MATERIAL_ESTOQUE.ColumnName = "MATERIAL_ESTOQUE";
            this.MATERIAL_ESTOQUE.MaxLength = 100;
            // 
            // DIMENSAO_ESTOQUE
            // 
            this.DIMENSAO_ESTOQUE.ColumnName = "DIMENSAO_ESTOQUE";
            this.DIMENSAO_ESTOQUE.MaxLength = 100;
            // 
            // PRAZO_MEDIO_ESTOQUE
            // 
            this.PRAZO_MEDIO_ESTOQUE.ColumnName = "PRAZO_MEDIO_ESTOQUE";
            this.PRAZO_MEDIO_ESTOQUE.DataType = typeof(int);
            // 
            // LOCALIZACAO_ESTOQUE
            // 
            this.LOCALIZACAO_ESTOQUE.ColumnName = "LOCALIZACAO_ESTOQUE";
            this.LOCALIZACAO_ESTOQUE.MaxLength = 50;
            // 
            // ESPESSURA_ESTOQUE
            // 
            this.ESPESSURA_ESTOQUE.ColumnName = "ESPESSURA_ESTOQUE";
            this.ESPESSURA_ESTOQUE.MaxLength = 10;
            // 
            // ESTOQUE_MINIMO_ESTOQUE
            // 
            this.ESTOQUE_MINIMO_ESTOQUE.ColumnName = "ESTOQUE_MINIMO_ESTOQUE";
            this.ESTOQUE_MINIMO_ESTOQUE.DataType = typeof(double);
            // 
            // ESTOQUE_ATUAL_ESTOQUE
            // 
            this.ESTOQUE_ATUAL_ESTOQUE.ColumnName = "ESTOQUE_ATUAL_ESTOQUE";
            this.ESTOQUE_ATUAL_ESTOQUE.DataType = typeof(double);
            // 
            // CHAPA_ESTOQUE
            // 
            this.CHAPA_ESTOQUE.ColumnName = "CHAPA_ESTOQUE";
            this.CHAPA_ESTOQUE.DataType = typeof(int);
            // 
            // COD_BARRAS_ITEM_FABRICANTE
            // 
            this.COD_BARRAS_ITEM_FABRICANTE.ColumnName = "COD_BARRAS_ITEM_FABRICANTE";
            this.COD_BARRAS_ITEM_FABRICANTE.MaxLength = 100;
            // 
            // MARCA_ESTOQUE
            // 
            this.MARCA_ESTOQUE.ColumnName = "MARCA_ESTOQUE";
            this.MARCA_ESTOQUE.MaxLength = 100;
            // 
            // OBSERVACOES_ESTOQUE
            // 
            this.OBSERVACOES_ESTOQUE.ColumnName = "OBSERVACOES_ESTOQUE";
            this.OBSERVACOES_ESTOQUE.MaxLength = 200;
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "GRANDEZA_ITEM_ESTOQUE";
            this.dataColumn1.MaxLength = 100;
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "TIPO_ITEM_ESTOQUE";
            this.dataColumn2.MaxLength = 200;
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "UNIDADE_ESTOQUE";
            this.dataColumn3.MaxLength = 100;
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "NCM_ESTOQUE";
            this.dataColumn4.MaxLength = 100;
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "EX_IPI_ESTOQUE";
            this.dataColumn5.MaxLength = 100;
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "COD_GEN_ESTOQUE";
            this.dataColumn6.MaxLength = 100;
            // 
            // dataColumn7
            // 
            this.dataColumn7.ColumnName = "COD_CST_ESTOQUE";
            this.dataColumn7.MaxLength = 100;
            // 
            // dataColumn8
            // 
            this.dataColumn8.ColumnName = "CNPJ_PROPRIETARIO_ESTOQUE";
            this.dataColumn8.MaxLength = 50;
            // 
            // dataColumn9
            // 
            this.dataColumn9.ColumnName = "NOME_PROPRIETARIO_ESTOQUE";
            this.dataColumn9.MaxLength = 200;
            // 
            // dataColumn10
            // 
            this.dataColumn10.ColumnName = "ESTOQUE_DISPONIVEL_ESTOQUE";
            this.dataColumn10.DataType = typeof(double);
            // 
            // dataColumn11
            // 
            this.dataColumn11.ColumnName = "ESTOQUE_AGUARDANDO_ESTOQUE";
            this.dataColumn11.DataType = typeof(double);
            // 
            // dataColumn12
            // 
            this.dataColumn12.ColumnName = "ESTOQUE_RESERVADO_ESTOQUE";
            this.dataColumn12.DataType = typeof(double);
            // 
            // dataColumn13
            // 
            this.dataColumn13.ColumnName = "VALOR_UNIT_ESTOQUE";
            this.dataColumn13.DataType = typeof(double);
            // 
            // dataColumn14
            // 
            this.dataColumn14.ColumnName = "PESO_UNIT_ESTOQUE";
            this.dataColumn14.DataType = typeof(decimal);
            // 
            // dataColumn15
            // 
            this.dataColumn15.ColumnName = "CLASSIFICACAO_ESTOQUE";
            this.dataColumn15.MaxLength = 100;
            // 
            // dataColumn16
            // 
            this.dataColumn16.ColumnName = "ACABAMENTO_ESTOQUE";
            this.dataColumn16.MaxLength = 100;
            // 
            // dataColumn17
            // 
            this.dataColumn17.ColumnName = "COMPRIMENTO_ESTOQUE";
            this.dataColumn17.MaxLength = 100;
            // 
            // dataColumn20
            // 
            this.dataColumn20.ColumnName = "COD_CONTROLE_ESTOQUE";
            this.dataColumn20.DataType = typeof(int);
            // 
            // dataColumn21
            // 
            this.dataColumn21.ColumnName = "PLANO_CONTROLE_ESTOQUE";
            this.dataColumn21.MaxLength = 100;
            // 
            // dataColumn24
            // 
            this.dataColumn24.ColumnName = "DUREZA_MINIMA_ESTOQUE";
            this.dataColumn24.DataType = typeof(double);
            // 
            // dataColumn25
            // 
            this.dataColumn25.ColumnName = "DUREZA_MAXIMA_ESTOQUE";
            this.dataColumn25.DataType = typeof(double);
            // 
            // tb_item
            // 
            this.tb_item.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsEstoque, "ESTOQUE.ITEM_ESTOQUE", true));
            this.tb_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_item.Location = new System.Drawing.Point(257, 7);
            this.tb_item.Name = "tb_item";
            this.tb_item.Size = new System.Drawing.Size(206, 26);
            this.tb_item.TabIndex = 1;
            this.tb_item.TextChanged += new System.EventHandler(this.tb_item_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(201, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 52;
            this.label2.Text = "Item:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-296, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 56;
            this.label4.Text = "Grupo:";
            this.label4.Visible = false;
            // 
            // tb_grupo
            // 
            this.tb_grupo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsEstoque, "ESTOQUE.GRUPO_ESTOQUE", true));
            this.tb_grupo.Location = new System.Drawing.Point(-233, 40);
            this.tb_grupo.Name = "tb_grupo";
            this.tb_grupo.ReadOnly = true;
            this.tb_grupo.Size = new System.Drawing.Size(74, 20);
            this.tb_grupo.TabIndex = 57;
            this.tb_grupo.Visible = false;
            // 
            // tb_estoque_atual
            // 
            this.tb_estoque_atual.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsEstoque, "ESTOQUE.ESTOQUE_ATUAL_ESTOQUE", true));
            this.tb_estoque_atual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_estoque_atual.Location = new System.Drawing.Point(289, 37);
            this.tb_estoque_atual.Name = "tb_estoque_atual";
            this.tb_estoque_atual.ReadOnly = true;
            this.tb_estoque_atual.Size = new System.Drawing.Size(147, 31);
            this.tb_estoque_atual.TabIndex = 59;
            this.tb_estoque_atual.TextChanged += new System.EventHandler(this.tb_estoque_atual_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(296, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 25);
            this.label5.TabIndex = 58;
            this.label5.Text = "Armazenado";
            // 
            // tb_estoque_minimo
            // 
            this.tb_estoque_minimo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsEstoque, "ESTOQUE.ESTOQUE_DISPONIVEL_ESTOQUE", true));
            this.tb_estoque_minimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_estoque_minimo.Location = new System.Drawing.Point(443, 37);
            this.tb_estoque_minimo.Name = "tb_estoque_minimo";
            this.tb_estoque_minimo.ReadOnly = true;
            this.tb_estoque_minimo.Size = new System.Drawing.Size(138, 31);
            this.tb_estoque_minimo.TabIndex = 61;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(456, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 25);
            this.label6.TabIndex = 60;
            this.label6.Text = "Disponível";
            // 
            // tb_localizacao
            // 
            this.tb_localizacao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsEstoque, "ESTOQUE.LOCALIZACAO_ESTOQUE", true));
            this.tb_localizacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_localizacao.Location = new System.Drawing.Point(731, 37);
            this.tb_localizacao.Name = "tb_localizacao";
            this.tb_localizacao.Size = new System.Drawing.Size(128, 31);
            this.tb_localizacao.TabIndex = 63;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(726, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 25);
            this.label7.TabIndex = 62;
            this.label7.Text = "Local:";
            // 
            // tb_dimensao
            // 
            this.tb_dimensao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsEstoque, "ESTOQUE.DIMENSAO_ESTOQUE", true));
            this.tb_dimensao.Location = new System.Drawing.Point(-69, 66);
            this.tb_dimensao.Name = "tb_dimensao";
            this.tb_dimensao.ReadOnly = true;
            this.tb_dimensao.Size = new System.Drawing.Size(74, 20);
            this.tb_dimensao.TabIndex = 71;
            this.tb_dimensao.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(-129, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 70;
            this.label10.Text = "Dimensão:";
            this.label10.Visible = false;
            // 
            // tb_espessura
            // 
            this.tb_espessura.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsEstoque, "ESTOQUE.ESPESSURA_ESTOQUE", true));
            this.tb_espessura.Location = new System.Drawing.Point(-233, 65);
            this.tb_espessura.Name = "tb_espessura";
            this.tb_espessura.ReadOnly = true;
            this.tb_espessura.Size = new System.Drawing.Size(74, 20);
            this.tb_espessura.TabIndex = 69;
            this.tb_espessura.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(-296, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 68;
            this.label11.Text = "Espessura:";
            this.label11.Visible = false;
            // 
            // tb_material
            // 
            this.tb_material.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsEstoque, "ESTOQUE.MATERIAL_ESTOQUE", true));
            this.tb_material.Location = new System.Drawing.Point(-76, 40);
            this.tb_material.Name = "tb_material";
            this.tb_material.ReadOnly = true;
            this.tb_material.Size = new System.Drawing.Size(81, 20);
            this.tb_material.TabIndex = 67;
            this.tb_material.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(-129, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 66;
            this.label12.Text = "Material:";
            this.label12.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(2, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 25);
            this.label13.TabIndex = 75;
            this.label13.Text = "Pedidos ";
            // 
            // dsItens_nf
            // 
            this.dsItens_nf.DataSetName = "dsItens_nf";
            this.dsItens_nf.Namespace = "http://www.tempuri.org/dsItens_nf.xsd";
            this.dsItens_nf.Tables.AddRange(new System.Data.DataTable[] {
            this.ITENS_NF_ENTRADA});
            // 
            // ITENS_NF_ENTRADA
            // 
            this.ITENS_NF_ENTRADA.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_CONTROLE_ITENS_NF_ENT,
            this.COD_ITENS_NF_ENT,
            this.ITEM_ITENS_NF_ENT,
            this.QTDE_ITENS_NF_ENT,
            this.VALOR_ITENS_NF_ENT,
            this.N_NOTA_ITENS_NF_ENT,
            this.FORN_ITENS_NF_ENT,
            this.DATA_ENT_ITENS_NF_ENT,
            this.PEDIDO_COMPRA_ITENS_NF_ENT,
            this.COD_NOTA_ITENS_NF_ENT});
            this.ITENS_NF_ENTRADA.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_CONTROLE_ITENS_NF_ENT"}, true)});
            this.ITENS_NF_ENTRADA.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_CONTROLE_ITENS_NF_ENT};
            this.ITENS_NF_ENTRADA.TableName = "ITENS_NF_ENTRADA";
            // 
            // COD_CONTROLE_ITENS_NF_ENT
            // 
            this.COD_CONTROLE_ITENS_NF_ENT.AllowDBNull = false;
            this.COD_CONTROLE_ITENS_NF_ENT.ColumnName = "COD_CONTROLE_ITENS_NF_ENT";
            this.COD_CONTROLE_ITENS_NF_ENT.DataType = typeof(int);
            // 
            // COD_ITENS_NF_ENT
            // 
            this.COD_ITENS_NF_ENT.ColumnName = "COD_ITENS_NF_ENT";
            this.COD_ITENS_NF_ENT.DataType = typeof(int);
            // 
            // ITEM_ITENS_NF_ENT
            // 
            this.ITEM_ITENS_NF_ENT.ColumnName = "ITEM_ITENS_NF_ENT";
            this.ITEM_ITENS_NF_ENT.MaxLength = 100;
            // 
            // QTDE_ITENS_NF_ENT
            // 
            this.QTDE_ITENS_NF_ENT.ColumnName = "QTDE_ITENS_NF_ENT";
            this.QTDE_ITENS_NF_ENT.DataType = typeof(double);
            // 
            // VALOR_ITENS_NF_ENT
            // 
            this.VALOR_ITENS_NF_ENT.ColumnName = "VALOR_ITENS_NF_ENT";
            this.VALOR_ITENS_NF_ENT.DataType = typeof(double);
            // 
            // N_NOTA_ITENS_NF_ENT
            // 
            this.N_NOTA_ITENS_NF_ENT.ColumnName = "N_NOTA_ITENS_NF_ENT";
            this.N_NOTA_ITENS_NF_ENT.MaxLength = 100;
            // 
            // FORN_ITENS_NF_ENT
            // 
            this.FORN_ITENS_NF_ENT.ColumnName = "FORN_ITENS_NF_ENT";
            this.FORN_ITENS_NF_ENT.MaxLength = 100;
            // 
            // DATA_ENT_ITENS_NF_ENT
            // 
            this.DATA_ENT_ITENS_NF_ENT.ColumnName = "DATA_ENT_ITENS_NF_ENT";
            this.DATA_ENT_ITENS_NF_ENT.DataType = typeof(System.DateTime);
            // 
            // PEDIDO_COMPRA_ITENS_NF_ENT
            // 
            this.PEDIDO_COMPRA_ITENS_NF_ENT.ColumnName = "PEDIDO_COMPRA_ITENS_NF_ENT";
            this.PEDIDO_COMPRA_ITENS_NF_ENT.DataType = typeof(int);
            // 
            // COD_NOTA_ITENS_NF_ENT
            // 
            this.COD_NOTA_ITENS_NF_ENT.ColumnName = "COD_NOTA_ITENS_NF_ENT";
            this.COD_NOTA_ITENS_NF_ENT.DataType = typeof(int);
            // 
            // tb_prazo_medio
            // 
            this.tb_prazo_medio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsEstoque, "ESTOQUE.PRAZO_MEDIO_ESTOQUE", true));
            this.tb_prazo_medio.Location = new System.Drawing.Point(419, 76);
            this.tb_prazo_medio.Name = "tb_prazo_medio";
            this.tb_prazo_medio.Size = new System.Drawing.Size(70, 20);
            this.tb_prazo_medio.TabIndex = 79;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(350, 79);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 13);
            this.label15.TabIndex = 78;
            this.label15.Text = "Prazo Médio:";
            // 
            // datEstoque
            // 
            this.datEstoque.DeleteCommand = this.fbCommand4;
            this.datEstoque.InsertCommand = this.fbCommand2;
            this.datEstoque.SelectCommand = this.fbCommand1;
            this.datEstoque.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * from estoque";
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
            // cbEstoque
            // 
            this.cbEstoque.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbEstoque.DataAdapter = this.datEstoque;
            this.cbEstoque.QuotePrefix = "\"";
            this.cbEstoque.QuoteSuffix = "\"";
            // 
            // tb_marca
            // 
            this.tb_marca.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsEstoque, "ESTOQUE.MARCA_ESTOQUE", true));
            this.tb_marca.Location = new System.Drawing.Point(453, 18);
            this.tb_marca.Name = "tb_marca";
            this.tb_marca.Size = new System.Drawing.Size(74, 20);
            this.tb_marca.TabIndex = 87;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(390, 21);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 13);
            this.label17.TabIndex = 86;
            this.label17.Text = "Marca:";
            // 
            // tb_obs
            // 
            this.tb_obs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsEstoque, "ESTOQUE.OBSERVACOES_ESTOQUE", true));
            this.tb_obs.Location = new System.Drawing.Point(499, 99);
            this.tb_obs.Multiline = true;
            this.tb_obs.Name = "tb_obs";
            this.tb_obs.Size = new System.Drawing.Size(465, 44);
            this.tb_obs.TabIndex = 10;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(422, 102);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(73, 13);
            this.label18.TabIndex = 84;
            this.label18.Text = "Observações:";
            // 
            // bt_imprimir_cod
            // 
            this.bt_imprimir_cod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_imprimir_cod.Location = new System.Drawing.Point(375, 290);
            this.bt_imprimir_cod.Name = "bt_imprimir_cod";
            this.bt_imprimir_cod.Size = new System.Drawing.Size(76, 81);
            this.bt_imprimir_cod.TabIndex = 3;
            this.bt_imprimir_cod.Text = "Imprimir Cód.";
            this.bt_imprimir_cod.UseVisualStyleBackColor = true;
            this.bt_imprimir_cod.Click += new System.EventHandler(this.bt_imprimir_cod_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(322, 55);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(39, 13);
            this.label19.TabIndex = 89;
            this.label19.Text = "Forma:";
            // 
            // datItens_nf
            // 
            this.datItens_nf.DeleteCommand = this.fbCommand8;
            this.datItens_nf.InsertCommand = this.fbCommand6;
            this.datItens_nf.SelectCommand = this.fbCommand5;
            this.datItens_nf.UpdateCommand = this.fbCommand7;
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
            this.fbCommand5.CommandText = "select * from itens_nf_entrada";
            this.fbCommand5.CommandTimeout = 30;
            this.fbCommand5.Connection = this.fbConnection1;
            // 
            // fbCommand7
            // 
            this.fbCommand7.CommandTimeout = 30;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(5, 9);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(78, 25);
            this.label21.TabIndex = 92;
            this.label21.Text = "Saídas";
            this.label21.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // datSaida_estoque
            // 
            this.datSaida_estoque.DeleteCommand = this.fbCommand12;
            this.datSaida_estoque.InsertCommand = this.fbCommand10;
            this.datSaida_estoque.SelectCommand = this.fbCommand9;
            this.datSaida_estoque.UpdateCommand = this.fbCommand11;
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
            this.fbCommand9.CommandText = "select * from estoque_saida";
            this.fbCommand9.CommandTimeout = 30;
            this.fbCommand9.Connection = this.fbConnection1;
            // 
            // fbCommand11
            // 
            this.fbCommand11.CommandTimeout = 30;
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
            this.dataColumn22,
            this.dataColumn23});
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
            // dataColumn22
            // 
            this.dataColumn22.ColumnName = "LOTE_ESTOQUE_SAIDA";
            this.dataColumn22.DataType = typeof(int);
            // 
            // dataColumn23
            // 
            this.dataColumn23.ColumnName = "PALETE_ESTOQUE_SAIDA";
            this.dataColumn23.DataType = typeof(int);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODESTOQUESAIDADataGridViewTextBoxColumn,
            this.cODITEMESTOQUESAIDADataGridViewTextBoxColumn,
            this.iTEMESTOQUESAIDADataGridViewTextBoxColumn,
            this.dATAESTOQUESAIDADataGridViewTextBoxColumn,
            this.qTDEESTOQUESAIDADataGridViewTextBoxColumn,
            this.cRACHAESTOQUESAIDADataGridViewTextBoxColumn,
            this.POS,
            this.LOTE_ESTOQUE_SAIDA,
            this.PALETE_ESTOQUE_SAIDA});
            this.dataGridView3.DataMember = "ESTOQUE_SAIDA";
            this.dataGridView3.DataSource = this.dsSaida_estoque;
            this.dataGridView3.Location = new System.Drawing.Point(3, 37);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 15;
            this.dataGridView3.Size = new System.Drawing.Size(156, 192);
            this.dataGridView3.TabIndex = 157;
            // 
            // cODESTOQUESAIDADataGridViewTextBoxColumn
            // 
            this.cODESTOQUESAIDADataGridViewTextBoxColumn.DataPropertyName = "COD_ESTOQUE_SAIDA";
            this.cODESTOQUESAIDADataGridViewTextBoxColumn.HeaderText = "COD_ESTOQUE_SAIDA";
            this.cODESTOQUESAIDADataGridViewTextBoxColumn.Name = "cODESTOQUESAIDADataGridViewTextBoxColumn";
            this.cODESTOQUESAIDADataGridViewTextBoxColumn.Visible = false;
            // 
            // cODITEMESTOQUESAIDADataGridViewTextBoxColumn
            // 
            this.cODITEMESTOQUESAIDADataGridViewTextBoxColumn.DataPropertyName = "COD_ITEM_ESTOQUE_SAIDA";
            this.cODITEMESTOQUESAIDADataGridViewTextBoxColumn.HeaderText = "Cod Item";
            this.cODITEMESTOQUESAIDADataGridViewTextBoxColumn.Name = "cODITEMESTOQUESAIDADataGridViewTextBoxColumn";
            this.cODITEMESTOQUESAIDADataGridViewTextBoxColumn.Visible = false;
            // 
            // iTEMESTOQUESAIDADataGridViewTextBoxColumn
            // 
            this.iTEMESTOQUESAIDADataGridViewTextBoxColumn.DataPropertyName = "ITEM_ESTOQUE_SAIDA";
            this.iTEMESTOQUESAIDADataGridViewTextBoxColumn.HeaderText = "Item";
            this.iTEMESTOQUESAIDADataGridViewTextBoxColumn.Name = "iTEMESTOQUESAIDADataGridViewTextBoxColumn";
            this.iTEMESTOQUESAIDADataGridViewTextBoxColumn.Visible = false;
            // 
            // dATAESTOQUESAIDADataGridViewTextBoxColumn
            // 
            this.dATAESTOQUESAIDADataGridViewTextBoxColumn.DataPropertyName = "DATA_ESTOQUE_SAIDA";
            this.dATAESTOQUESAIDADataGridViewTextBoxColumn.HeaderText = "Data";
            this.dATAESTOQUESAIDADataGridViewTextBoxColumn.Name = "dATAESTOQUESAIDADataGridViewTextBoxColumn";
            this.dATAESTOQUESAIDADataGridViewTextBoxColumn.Width = 60;
            // 
            // qTDEESTOQUESAIDADataGridViewTextBoxColumn
            // 
            this.qTDEESTOQUESAIDADataGridViewTextBoxColumn.DataPropertyName = "QTDE_ESTOQUE_SAIDA";
            this.qTDEESTOQUESAIDADataGridViewTextBoxColumn.HeaderText = "Qtde";
            this.qTDEESTOQUESAIDADataGridViewTextBoxColumn.Name = "qTDEESTOQUESAIDADataGridViewTextBoxColumn";
            this.qTDEESTOQUESAIDADataGridViewTextBoxColumn.Width = 40;
            // 
            // cRACHAESTOQUESAIDADataGridViewTextBoxColumn
            // 
            this.cRACHAESTOQUESAIDADataGridViewTextBoxColumn.DataPropertyName = "CRACHA_ESTOQUE_SAIDA";
            this.cRACHAESTOQUESAIDADataGridViewTextBoxColumn.HeaderText = "Crachá";
            this.cRACHAESTOQUESAIDADataGridViewTextBoxColumn.Name = "cRACHAESTOQUESAIDADataGridViewTextBoxColumn";
            this.cRACHAESTOQUESAIDADataGridViewTextBoxColumn.Width = 50;
            // 
            // POS
            // 
            this.POS.DataPropertyName = "OP_ESTOQUE_SAIDA";
            this.POS.HeaderText = "POS";
            this.POS.Name = "POS";
            // 
            // LOTE_ESTOQUE_SAIDA
            // 
            this.LOTE_ESTOQUE_SAIDA.DataPropertyName = "LOTE_ESTOQUE_SAIDA";
            this.LOTE_ESTOQUE_SAIDA.HeaderText = "Lote";
            this.LOTE_ESTOQUE_SAIDA.Name = "LOTE_ESTOQUE_SAIDA";
            // 
            // PALETE_ESTOQUE_SAIDA
            // 
            this.PALETE_ESTOQUE_SAIDA.DataPropertyName = "PALETE_ESTOQUE_SAIDA";
            this.PALETE_ESTOQUE_SAIDA.HeaderText = "Palete";
            this.PALETE_ESTOQUE_SAIDA.Name = "PALETE_ESTOQUE_SAIDA";
            // 
            // datItens_ped
            // 
            this.datItens_ped.DeleteCommand = this.fbCommand16;
            this.datItens_ped.InsertCommand = this.fbCommand14;
            this.datItens_ped.SelectCommand = this.fbCommand13;
            this.datItens_ped.UpdateCommand = this.fbCommand15;
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
            this.fbCommand13.CommandText = "select * from itens_pedido_compra";
            this.fbCommand13.CommandTimeout = 30;
            this.fbCommand13.Connection = this.fbConnection1;
            // 
            // fbCommand15
            // 
            this.fbCommand15.CommandTimeout = 30;
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
            this.CHEGOU_ITEM_PED,
            this.COD_NF_ENTRADA_ITEM_PED,
            this.AUTORIZANTE_ITEM_PED,
            this.DATA_AUTORIZACAO_ITEM_PED,
            this.HORA_AUTORIZACAO_ITEM_PED,
            this.DATA_CHEGADA_ITEM_PED});
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
            // CHEGOU_ITEM_PED
            // 
            this.CHEGOU_ITEM_PED.ColumnName = "CHEGOU_ITEM_PED";
            this.CHEGOU_ITEM_PED.DataType = typeof(int);
            // 
            // COD_NF_ENTRADA_ITEM_PED
            // 
            this.COD_NF_ENTRADA_ITEM_PED.ColumnName = "COD_NF_ENTRADA_ITEM_PED";
            this.COD_NF_ENTRADA_ITEM_PED.DataType = typeof(int);
            // 
            // AUTORIZANTE_ITEM_PED
            // 
            this.AUTORIZANTE_ITEM_PED.ColumnName = "AUTORIZANTE_ITEM_PED";
            this.AUTORIZANTE_ITEM_PED.MaxLength = 100;
            // 
            // DATA_AUTORIZACAO_ITEM_PED
            // 
            this.DATA_AUTORIZACAO_ITEM_PED.ColumnName = "DATA_AUTORIZACAO_ITEM_PED";
            this.DATA_AUTORIZACAO_ITEM_PED.DataType = typeof(System.DateTime);
            // 
            // HORA_AUTORIZACAO_ITEM_PED
            // 
            this.HORA_AUTORIZACAO_ITEM_PED.ColumnName = "HORA_AUTORIZACAO_ITEM_PED";
            this.HORA_AUTORIZACAO_ITEM_PED.MaxLength = 15;
            // 
            // DATA_CHEGADA_ITEM_PED
            // 
            this.DATA_CHEGADA_ITEM_PED.ColumnName = "DATA_CHEGADA_ITEM_PED";
            this.DATA_CHEGADA_ITEM_PED.DataType = typeof(System.DateTime);
            // 
            // dgvItens_ped
            // 
            this.dgvItens_ped.AllowUserToAddRows = false;
            this.dgvItens_ped.AllowUserToResizeColumns = false;
            this.dgvItens_ped.AllowUserToResizeRows = false;
            this.dgvItens_ped.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItens_ped.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvItens_ped.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens_ped.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.col_valor_unit});
            this.dgvItens_ped.DataMember = "ITENS_PEDIDO_COMPRA";
            this.dgvItens_ped.DataSource = this.dsItens_ped;
            this.dgvItens_ped.Location = new System.Drawing.Point(3, 37);
            this.dgvItens_ped.Name = "dgvItens_ped";
            this.dgvItens_ped.RowHeadersVisible = false;
            this.dgvItens_ped.Size = new System.Drawing.Size(157, 192);
            this.dgvItens_ped.TabIndex = 158;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "N_PEDIDO_ITEM_PED";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nº Ped.";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 40;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "QTDE_ITEM_PED";
            this.dataGridViewTextBoxColumn2.HeaderText = "Qtde";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 50;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DATA_CHEGADA_ITEM_PED";
            this.dataGridViewTextBoxColumn3.HeaderText = "Data Chegada";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 60;
            // 
            // col_valor_unit
            // 
            this.col_valor_unit.DataPropertyName = "VALOR_UNIT_ITEM_PED";
            this.col_valor_unit.HeaderText = "Valor Unit.";
            this.col_valor_unit.Name = "col_valor_unit";
            this.col_valor_unit.Width = 60;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(38, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 159;
            this.label9.Text = "Tipo:";
            // 
            // cb_tipo
            // 
            this.cb_tipo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsEstoque, "ESTOQUE.TIPO_ITEM_ESTOQUE", true));
            this.cb_tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_tipo.FormattingEnabled = true;
            this.cb_tipo.Items.AddRange(new object[] {
            "00 – Mercadoria para Revenda",
            "01 – Matéria-Prima",
            "02 – Embalagem",
            "03 – Produto em Processo",
            "04 – Produto Acabado",
            "05 – Subproduto",
            "06 – Produto Intermediário",
            "07 – Material de Uso e Consumo",
            "08 – Ativo Imobilizado",
            "09 – Serviços",
            "10 – Outros insumos",
            "99 – Outras"});
            this.cb_tipo.Location = new System.Drawing.Point(77, 99);
            this.cb_tipo.Name = "cb_tipo";
            this.cb_tipo.Size = new System.Drawing.Size(203, 21);
            this.cb_tipo.TabIndex = 8;
            this.cb_tipo.SelectedIndexChanged += new System.EventHandler(this.cb_tipo_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSalmon;
            this.panel1.Controls.Add(this.dgvItens_ped);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Location = new System.Drawing.Point(8, 383);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 236);
            this.panel1.TabIndex = 161;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.dataGridView3);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Location = new System.Drawing.Point(509, 383);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(163, 236);
            this.panel2.TabIndex = 162;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel4.Controls.Add(this.textBox8);
            this.panel4.Controls.Add(this.label31);
            this.panel4.Controls.Add(this.textBox6);
            this.panel4.Controls.Add(this.label29);
            this.panel4.Controls.Add(this.textBox7);
            this.panel4.Controls.Add(this.label30);
            this.panel4.Controls.Add(this.tb_localizacao);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.tb_estoque_minimo);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.tb_estoque_atual);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(8, 201);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(998, 83);
            this.panel4.TabIndex = 164;
            // 
            // textBox8
            // 
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsEstoque, "ESTOQUE.ESTOQUE_MINIMO_ESTOQUE", true));
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(587, 37);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(138, 31);
            this.textBox8.TabIndex = 70;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(591, 9);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(87, 25);
            this.label31.TabIndex = 69;
            this.label31.Text = "Mínimo:";
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsEstoque, "ESTOQUE.ESTOQUE_RESERVADO_ESTOQUE", true));
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(145, 37);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(138, 31);
            this.textBox6.TabIndex = 68;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(156, 9);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(116, 25);
            this.label29.TabIndex = 67;
            this.label29.Text = "Reservado";
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsEstoque, "ESTOQUE.ESTOQUE_AGUARDANDO_ESTOQUE", true));
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(11, 37);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(128, 31);
            this.textBox7.TabIndex = 66;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(6, 9);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(135, 25);
            this.label30.TabIndex = 65;
            this.label30.Text = "Em Compras";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(9, 290);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 81);
            this.button1.TabIndex = 64;
            this.button1.Text = "Recalcular Estoque";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel5.Controls.Add(this.comboBox1);
            this.panel5.Controls.Add(this.textBox11);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.tb_comprimento);
            this.panel5.Controls.Add(this.label35);
            this.panel5.Controls.Add(this.tb_cliente);
            this.panel5.Controls.Add(this.tb_cnpj_cliente);
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.label28);
            this.panel5.Controls.Add(this.textBox3);
            this.panel5.Controls.Add(this.label24);
            this.panel5.Controls.Add(this.textBox4);
            this.panel5.Controls.Add(this.label26);
            this.panel5.Controls.Add(this.label25);
            this.panel5.Controls.Add(this.textBox5);
            this.panel5.Controls.Add(this.textBox2);
            this.panel5.Controls.Add(this.label23);
            this.panel5.Controls.Add(this.cb_tipo);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label19);
            this.panel5.Controls.Add(this.tb_obs);
            this.panel5.Controls.Add(this.label18);
            this.panel5.Controls.Add(this.tb_item);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(8, 49);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(998, 146);
            this.panel5.TabIndex = 165;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsEstoque, "ESTOQUE.GRANDEZA_ITEM_ESTOQUE", true));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "BARRA",
            "CORTADO"});
            this.comboBox1.Location = new System.Drawing.Point(366, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // textBox11
            // 
            this.textBox11.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsEstoque, "ESTOQUE.DESCRICAO_ESTOQUE", true));
            this.textBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox11.Location = new System.Drawing.Point(596, 7);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(368, 26);
            this.textBox11.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(496, 11);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 20);
            this.label14.TabIndex = 192;
            this.label14.Text = "Descrição:";
            // 
            // tb_comprimento
            // 
            this.tb_comprimento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsEstoque, "ESTOQUE.COMPRIMENTO_ESTOQUE", true));
            this.tb_comprimento.Location = new System.Drawing.Point(77, 51);
            this.tb_comprimento.Name = "tb_comprimento";
            this.tb_comprimento.Size = new System.Drawing.Size(81, 20);
            this.tb_comprimento.TabIndex = 3;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(3, 55);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(71, 13);
            this.label35.TabIndex = 189;
            this.label35.Text = "Comprimento:";
            // 
            // tb_cliente
            // 
            this.tb_cliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsEstoque, "ESTOQUE.NOME_PROPRIETARIO_ESTOQUE", true));
            this.tb_cliente.Location = new System.Drawing.Point(813, 51);
            this.tb_cliente.Name = "tb_cliente";
            this.tb_cliente.ReadOnly = true;
            this.tb_cliente.Size = new System.Drawing.Size(151, 20);
            this.tb_cliente.TabIndex = 174;
            this.tb_cliente.TextChanged += new System.EventHandler(this.tb_cliente_TextChanged);
            // 
            // tb_cnpj_cliente
            // 
            this.tb_cnpj_cliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsEstoque, "ESTOQUE.CNPJ_PROPRIETARIO_ESTOQUE", true));
            this.tb_cnpj_cliente.Location = new System.Drawing.Point(742, 51);
            this.tb_cnpj_cliente.Name = "tb_cnpj_cliente";
            this.tb_cnpj_cliente.ReadOnly = true;
            this.tb_cnpj_cliente.Size = new System.Drawing.Size(69, 20);
            this.tb_cnpj_cliente.TabIndex = 173;
            this.tb_cnpj_cliente.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(970, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(21, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(686, 54);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(50, 13);
            this.label28.TabIndex = 171;
            this.label28.Text = "Cliente:";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsEstoque, "ESTOQUE.COD_CST_ESTOQUE", true));
            this.textBox3.Location = new System.Drawing.Point(566, 52);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(112, 20);
            this.textBox3.TabIndex = 6;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(496, 54);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(67, 13);
            this.label24.TabIndex = 167;
            this.label24.Text = "Cód. Cliente:";
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsEstoque, "ESTOQUE.COD_GEN_ESTOQUE", true));
            this.textBox4.Location = new System.Drawing.Point(77, 12);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(98, 20);
            this.textBox4.TabIndex = 0;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(172, 55);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(50, 13);
            this.label26.TabIndex = 169;
            this.label26.Text = "Unidade:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(3, 15);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(68, 13);
            this.label25.TabIndex = 165;
            this.label25.Text = "Cód. Interno:";
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsEstoque, "ESTOQUE.UNIDADE_ESTOQUE", true));
            this.textBox5.Location = new System.Drawing.Point(228, 52);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(81, 20);
            this.textBox5.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsEstoque, "ESTOQUE.NCM_ESTOQUE", true));
            this.textBox2.Location = new System.Drawing.Point(335, 99);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(65, 20);
            this.textBox2.TabIndex = 9;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(295, 102);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(34, 13);
            this.label23.TabIndex = 161;
            this.label23.Text = "NCM:";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(187, 64);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(21, 23);
            this.button10.TabIndex = 191;
            this.button10.Text = "+";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Visible = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(-157, 63);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(21, 23);
            this.button9.TabIndex = 188;
            this.button9.Text = "+";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Visible = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(364, 38);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(21, 23);
            this.button8.TabIndex = 187;
            this.button8.Text = "+";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Visible = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // tb_acabamento
            // 
            this.tb_acabamento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsEstoque, "ESTOQUE.ACABAMENTO_ESTOQUE", true));
            this.tb_acabamento.Location = new System.Drawing.Point(278, 40);
            this.tb_acabamento.Name = "tb_acabamento";
            this.tb_acabamento.ReadOnly = true;
            this.tb_acabamento.Size = new System.Drawing.Size(81, 20);
            this.tb_acabamento.TabIndex = 186;
            this.tb_acabamento.Visible = false;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(209, 43);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(70, 13);
            this.label34.TabIndex = 185;
            this.label34.Text = "Acabamento:";
            this.label34.Visible = false;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(187, 38);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(21, 23);
            this.button7.TabIndex = 184;
            this.button7.Text = "+";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Visible = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // tb_classificacao
            // 
            this.tb_classificacao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsEstoque, "ESTOQUE.CLASSIFICACAO_ESTOQUE", true));
            this.tb_classificacao.Location = new System.Drawing.Point(101, 40);
            this.tb_classificacao.Name = "tb_classificacao";
            this.tb_classificacao.ReadOnly = true;
            this.tb_classificacao.Size = new System.Drawing.Size(81, 20);
            this.tb_classificacao.TabIndex = 183;
            this.tb_classificacao.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(32, 43);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 13);
            this.label16.TabIndex = 182;
            this.label16.Text = "Classificação:";
            this.label16.Visible = false;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(10, 64);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(21, 23);
            this.button6.TabIndex = 181;
            this.button6.Text = "+";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(10, 38);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(21, 23);
            this.button5.TabIndex = 180;
            this.button5.Text = "+";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(-157, 39);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(21, 23);
            this.button4.TabIndex = 179;
            this.button4.Text = "+";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox9
            // 
            this.textBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsEstoque, "ESTOQUE.PESO_UNIT_ESTOQUE", true));
            this.textBox9.Location = new System.Drawing.Point(263, 76);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(78, 20);
            this.textBox9.TabIndex = 178;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(198, 79);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(59, 13);
            this.label32.TabIndex = 177;
            this.label32.Text = "Peso Unit.:";
            // 
            // textBox10
            // 
            this.textBox10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsEstoque, "ESTOQUE.VALOR_UNIT_ESTOQUE", true));
            this.textBox10.Location = new System.Drawing.Point(122, 75);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(70, 20);
            this.textBox10.TabIndex = 176;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(47, 79);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(59, 13);
            this.label33.TabIndex = 175;
            this.label33.Text = "Valor Unit.:";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsEstoque, "ESTOQUE.EX_IPI_ESTOQUE", true));
            this.textBox1.Location = new System.Drawing.Point(454, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(39, 20);
            this.textBox1.TabIndex = 164;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(414, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 163;
            this.label8.Text = "Ex. IPI:";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel6.Controls.Add(this.dgvRequisicoes);
            this.panel6.Controls.Add(this.label22);
            this.panel6.Location = new System.Drawing.Point(174, 383);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(163, 236);
            this.panel6.TabIndex = 162;
            // 
            // dgvRequisicoes
            // 
            this.dgvRequisicoes.AllowUserToAddRows = false;
            this.dgvRequisicoes.AllowUserToResizeColumns = false;
            this.dgvRequisicoes.AllowUserToResizeRows = false;
            this.dgvRequisicoes.AutoGenerateColumns = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRequisicoes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRequisicoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequisicoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rEQUISITANTEITEMREQDataGridViewTextBoxColumn,
            this.cODREQITEMREQDataGridViewTextBoxColumn,
            this.oPITEMREQDataGridViewTextBoxColumn,
            this.qTDEITEMREQDataGridViewTextBoxColumn,
            this.sETORITEMREQDataGridViewTextBoxColumn,
            this.dATAREQUISICAOITEMREQDataGridViewTextBoxColumn,
            this.sITUACAOATUALITEMREQDataGridViewTextBoxColumn});
            this.dgvRequisicoes.DataMember = "ITENS_REQUISICAO";
            this.dgvRequisicoes.DataSource = this.dsItens_requisicao;
            this.dgvRequisicoes.Location = new System.Drawing.Point(3, 37);
            this.dgvRequisicoes.Name = "dgvRequisicoes";
            this.dgvRequisicoes.RowHeadersVisible = false;
            this.dgvRequisicoes.Size = new System.Drawing.Size(157, 192);
            this.dgvRequisicoes.TabIndex = 158;
            // 
            // rEQUISITANTEITEMREQDataGridViewTextBoxColumn
            // 
            this.rEQUISITANTEITEMREQDataGridViewTextBoxColumn.DataPropertyName = "REQUISITANTE_ITEM_REQ";
            this.rEQUISITANTEITEMREQDataGridViewTextBoxColumn.HeaderText = "Requisitante";
            this.rEQUISITANTEITEMREQDataGridViewTextBoxColumn.Name = "rEQUISITANTEITEMREQDataGridViewTextBoxColumn";
            // 
            // cODREQITEMREQDataGridViewTextBoxColumn
            // 
            this.cODREQITEMREQDataGridViewTextBoxColumn.DataPropertyName = "COD_REQ_ITEM_REQ";
            this.cODREQITEMREQDataGridViewTextBoxColumn.HeaderText = "Req.";
            this.cODREQITEMREQDataGridViewTextBoxColumn.Name = "cODREQITEMREQDataGridViewTextBoxColumn";
            // 
            // oPITEMREQDataGridViewTextBoxColumn
            // 
            this.oPITEMREQDataGridViewTextBoxColumn.DataPropertyName = "OP_ITEM_REQ";
            this.oPITEMREQDataGridViewTextBoxColumn.HeaderText = "OP";
            this.oPITEMREQDataGridViewTextBoxColumn.Name = "oPITEMREQDataGridViewTextBoxColumn";
            // 
            // qTDEITEMREQDataGridViewTextBoxColumn
            // 
            this.qTDEITEMREQDataGridViewTextBoxColumn.DataPropertyName = "QTDE_ITEM_REQ";
            this.qTDEITEMREQDataGridViewTextBoxColumn.HeaderText = "Qtde";
            this.qTDEITEMREQDataGridViewTextBoxColumn.Name = "qTDEITEMREQDataGridViewTextBoxColumn";
            // 
            // sETORITEMREQDataGridViewTextBoxColumn
            // 
            this.sETORITEMREQDataGridViewTextBoxColumn.DataPropertyName = "SETOR_ITEM_REQ";
            this.sETORITEMREQDataGridViewTextBoxColumn.HeaderText = "Setor";
            this.sETORITEMREQDataGridViewTextBoxColumn.Name = "sETORITEMREQDataGridViewTextBoxColumn";
            // 
            // dATAREQUISICAOITEMREQDataGridViewTextBoxColumn
            // 
            this.dATAREQUISICAOITEMREQDataGridViewTextBoxColumn.DataPropertyName = "DATA_REQUISICAO_ITEM_REQ";
            this.dATAREQUISICAOITEMREQDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dATAREQUISICAOITEMREQDataGridViewTextBoxColumn.Name = "dATAREQUISICAOITEMREQDataGridViewTextBoxColumn";
            // 
            // sITUACAOATUALITEMREQDataGridViewTextBoxColumn
            // 
            this.sITUACAOATUALITEMREQDataGridViewTextBoxColumn.DataPropertyName = "SITUACAO_ATUAL_ITEM_REQ";
            this.sITUACAOATUALITEMREQDataGridViewTextBoxColumn.HeaderText = "Situação";
            this.sITUACAOATUALITEMREQDataGridViewTextBoxColumn.Name = "sITUACAOATUALITEMREQDataGridViewTextBoxColumn";
            // 
            // dsItens_requisicao
            // 
            this.dsItens_requisicao.DataSetName = "dsItens_requisicao";
            this.dsItens_requisicao.Namespace = "http://www.tempuri.org/dsItens_requisicao.xsd";
            this.dsItens_requisicao.Tables.AddRange(new System.Data.DataTable[] {
            this.ITENS_REQUISICAO});
            // 
            // ITENS_REQUISICAO
            // 
            this.ITENS_REQUISICAO.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_ITEM_REQ,
            this.COD_REQ_ITEM_REQ,
            this.OP_ITEM_REQ,
            this.QTDE_ITEM_REQ,
            this.UNIDADE_ITEM_REQ,
            this.COD_ESTOQUE_ITEM_REQ,
            this.DESCRICAO_ITEM_REQ,
            this.DATA_LIMITE_ITEM_REQ,
            this.URGENTE_ITEM_REQ,
            this.REQUISITANTE_ITEM_REQ,
            this.SETOR_ITEM_REQ,
            this.DATA_REQUISICAO_ITEM_REQ,
            this.SITUACAO_ATUAL_ITEM_REQ,
            this.AUTORIZADO_POR_ITEM_REQ,
            this.CLIENTE_ITEM_REQ,
            this.FORNECEDOR_ITEM_REQ});
            this.ITENS_REQUISICAO.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_ITEM_REQ"}, true)});
            this.ITENS_REQUISICAO.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_ITEM_REQ};
            this.ITENS_REQUISICAO.TableName = "ITENS_REQUISICAO";
            // 
            // COD_ITEM_REQ
            // 
            this.COD_ITEM_REQ.AllowDBNull = false;
            this.COD_ITEM_REQ.ColumnName = "COD_ITEM_REQ";
            this.COD_ITEM_REQ.DataType = typeof(int);
            // 
            // COD_REQ_ITEM_REQ
            // 
            this.COD_REQ_ITEM_REQ.ColumnName = "COD_REQ_ITEM_REQ";
            this.COD_REQ_ITEM_REQ.DataType = typeof(int);
            // 
            // OP_ITEM_REQ
            // 
            this.OP_ITEM_REQ.ColumnName = "OP_ITEM_REQ";
            this.OP_ITEM_REQ.MaxLength = 50;
            // 
            // QTDE_ITEM_REQ
            // 
            this.QTDE_ITEM_REQ.ColumnName = "QTDE_ITEM_REQ";
            this.QTDE_ITEM_REQ.DataType = typeof(double);
            // 
            // UNIDADE_ITEM_REQ
            // 
            this.UNIDADE_ITEM_REQ.ColumnName = "UNIDADE_ITEM_REQ";
            this.UNIDADE_ITEM_REQ.MaxLength = 10;
            // 
            // COD_ESTOQUE_ITEM_REQ
            // 
            this.COD_ESTOQUE_ITEM_REQ.ColumnName = "COD_ESTOQUE_ITEM_REQ";
            this.COD_ESTOQUE_ITEM_REQ.DataType = typeof(int);
            // 
            // DESCRICAO_ITEM_REQ
            // 
            this.DESCRICAO_ITEM_REQ.ColumnName = "DESCRICAO_ITEM_REQ";
            this.DESCRICAO_ITEM_REQ.MaxLength = 200;
            // 
            // DATA_LIMITE_ITEM_REQ
            // 
            this.DATA_LIMITE_ITEM_REQ.ColumnName = "DATA_LIMITE_ITEM_REQ";
            this.DATA_LIMITE_ITEM_REQ.DataType = typeof(System.DateTime);
            // 
            // URGENTE_ITEM_REQ
            // 
            this.URGENTE_ITEM_REQ.ColumnName = "URGENTE_ITEM_REQ";
            this.URGENTE_ITEM_REQ.DataType = typeof(int);
            // 
            // REQUISITANTE_ITEM_REQ
            // 
            this.REQUISITANTE_ITEM_REQ.ColumnName = "REQUISITANTE_ITEM_REQ";
            this.REQUISITANTE_ITEM_REQ.MaxLength = 100;
            // 
            // SETOR_ITEM_REQ
            // 
            this.SETOR_ITEM_REQ.ColumnName = "SETOR_ITEM_REQ";
            this.SETOR_ITEM_REQ.MaxLength = 100;
            // 
            // DATA_REQUISICAO_ITEM_REQ
            // 
            this.DATA_REQUISICAO_ITEM_REQ.ColumnName = "DATA_REQUISICAO_ITEM_REQ";
            this.DATA_REQUISICAO_ITEM_REQ.DataType = typeof(System.DateTime);
            // 
            // SITUACAO_ATUAL_ITEM_REQ
            // 
            this.SITUACAO_ATUAL_ITEM_REQ.ColumnName = "SITUACAO_ATUAL_ITEM_REQ";
            this.SITUACAO_ATUAL_ITEM_REQ.MaxLength = 50;
            // 
            // AUTORIZADO_POR_ITEM_REQ
            // 
            this.AUTORIZADO_POR_ITEM_REQ.ColumnName = "AUTORIZADO_POR_ITEM_REQ";
            this.AUTORIZADO_POR_ITEM_REQ.MaxLength = 50;
            // 
            // CLIENTE_ITEM_REQ
            // 
            this.CLIENTE_ITEM_REQ.ColumnName = "CLIENTE_ITEM_REQ";
            this.CLIENTE_ITEM_REQ.MaxLength = 100;
            // 
            // FORNECEDOR_ITEM_REQ
            // 
            this.FORNECEDOR_ITEM_REQ.ColumnName = "FORNECEDOR_ITEM_REQ";
            this.FORNECEDOR_ITEM_REQ.MaxLength = 100;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(3, 9);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(130, 25);
            this.label22.TabIndex = 75;
            this.label22.Text = "Requisições";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel7.Controls.Add(this.dgvItens_nota_ent);
            this.panel7.Controls.Add(this.label27);
            this.panel7.Location = new System.Drawing.Point(340, 383);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(163, 236);
            this.panel7.TabIndex = 166;
            // 
            // dgvItens_nota_ent
            // 
            this.dgvItens_nota_ent.AllowUserToAddRows = false;
            this.dgvItens_nota_ent.AutoGenerateColumns = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItens_nota_ent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvItens_nota_ent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens_nota_ent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.qTDEITEMENTDataGridViewTextBoxColumn,
            this.QTDE_LOTE_ITEM_ENT,
            this.LOTE_ITEM_ENT,
            this.nFITEMENTDataGridViewTextBoxColumn,
            this.pRECOUNITITEMENTDataGridViewTextBoxColumn,
            this.cNPJCLIENTEITEMENTDataGridViewTextBoxColumn,
            this.pEDIDOCOMPRAITEMENTDataGridViewTextBoxColumn,
            this.nLINHAPEDITEMENTDataGridViewTextBoxColumn,
            this.cODITEMREQITEMENTDataGridViewTextBoxColumn,
            this.cODITEMPEDITEMENTDataGridViewTextBoxColumn,
            this.cODITEMESTITEMENTDataGridViewTextBoxColumn});
            this.dgvItens_nota_ent.DataMember = "ITENS_NOTA_ENT";
            this.dgvItens_nota_ent.DataSource = this.dsItens_nota_ent;
            this.dgvItens_nota_ent.Location = new System.Drawing.Point(3, 37);
            this.dgvItens_nota_ent.Name = "dgvItens_nota_ent";
            this.dgvItens_nota_ent.RowHeadersVisible = false;
            this.dgvItens_nota_ent.Size = new System.Drawing.Size(157, 192);
            this.dgvItens_nota_ent.TabIndex = 79;
            // 
            // qTDEITEMENTDataGridViewTextBoxColumn
            // 
            this.qTDEITEMENTDataGridViewTextBoxColumn.DataPropertyName = "QTDE_ITEM_ENT";
            this.qTDEITEMENTDataGridViewTextBoxColumn.HeaderText = "Qtde";
            this.qTDEITEMENTDataGridViewTextBoxColumn.Name = "qTDEITEMENTDataGridViewTextBoxColumn";
            this.qTDEITEMENTDataGridViewTextBoxColumn.Width = 40;
            // 
            // QTDE_LOTE_ITEM_ENT
            // 
            this.QTDE_LOTE_ITEM_ENT.DataPropertyName = "QTDE_LOTE_ITEM_ENT";
            this.QTDE_LOTE_ITEM_ENT.HeaderText = "Qtde Lote";
            this.QTDE_LOTE_ITEM_ENT.Name = "QTDE_LOTE_ITEM_ENT";
            this.QTDE_LOTE_ITEM_ENT.Width = 40;
            // 
            // LOTE_ITEM_ENT
            // 
            this.LOTE_ITEM_ENT.DataPropertyName = "LOTE_ITEM_ENT";
            this.LOTE_ITEM_ENT.HeaderText = "Lote";
            this.LOTE_ITEM_ENT.Name = "LOTE_ITEM_ENT";
            // 
            // nFITEMENTDataGridViewTextBoxColumn
            // 
            this.nFITEMENTDataGridViewTextBoxColumn.DataPropertyName = "NF_ITEM_ENT";
            this.nFITEMENTDataGridViewTextBoxColumn.HeaderText = "NF";
            this.nFITEMENTDataGridViewTextBoxColumn.Name = "nFITEMENTDataGridViewTextBoxColumn";
            this.nFITEMENTDataGridViewTextBoxColumn.Width = 40;
            // 
            // pRECOUNITITEMENTDataGridViewTextBoxColumn
            // 
            this.pRECOUNITITEMENTDataGridViewTextBoxColumn.DataPropertyName = "PRECO_UNIT_ITEM_ENT";
            this.pRECOUNITITEMENTDataGridViewTextBoxColumn.HeaderText = "Valor Unit.";
            this.pRECOUNITITEMENTDataGridViewTextBoxColumn.Name = "pRECOUNITITEMENTDataGridViewTextBoxColumn";
            this.pRECOUNITITEMENTDataGridViewTextBoxColumn.Width = 50;
            // 
            // cNPJCLIENTEITEMENTDataGridViewTextBoxColumn
            // 
            this.cNPJCLIENTEITEMENTDataGridViewTextBoxColumn.DataPropertyName = "CNPJ_CLIENTE_ITEM_ENT";
            this.cNPJCLIENTEITEMENTDataGridViewTextBoxColumn.HeaderText = "CNPJ";
            this.cNPJCLIENTEITEMENTDataGridViewTextBoxColumn.Name = "cNPJCLIENTEITEMENTDataGridViewTextBoxColumn";
            // 
            // pEDIDOCOMPRAITEMENTDataGridViewTextBoxColumn
            // 
            this.pEDIDOCOMPRAITEMENTDataGridViewTextBoxColumn.DataPropertyName = "PEDIDO_COMPRA_ITEM_ENT";
            this.pEDIDOCOMPRAITEMENTDataGridViewTextBoxColumn.HeaderText = "Pedido";
            this.pEDIDOCOMPRAITEMENTDataGridViewTextBoxColumn.Name = "pEDIDOCOMPRAITEMENTDataGridViewTextBoxColumn";
            this.pEDIDOCOMPRAITEMENTDataGridViewTextBoxColumn.Width = 60;
            // 
            // nLINHAPEDITEMENTDataGridViewTextBoxColumn
            // 
            this.nLINHAPEDITEMENTDataGridViewTextBoxColumn.DataPropertyName = "N_LINHA_PED_ITEM_ENT";
            this.nLINHAPEDITEMENTDataGridViewTextBoxColumn.HeaderText = "Nº Linha";
            this.nLINHAPEDITEMENTDataGridViewTextBoxColumn.Name = "nLINHAPEDITEMENTDataGridViewTextBoxColumn";
            this.nLINHAPEDITEMENTDataGridViewTextBoxColumn.Width = 60;
            // 
            // cODITEMREQITEMENTDataGridViewTextBoxColumn
            // 
            this.cODITEMREQITEMENTDataGridViewTextBoxColumn.DataPropertyName = "COD_ITEM_REQ_ITEM_ENT";
            this.cODITEMREQITEMENTDataGridViewTextBoxColumn.HeaderText = "COD_ITEM_REQ_ITEM_ENT";
            this.cODITEMREQITEMENTDataGridViewTextBoxColumn.Name = "cODITEMREQITEMENTDataGridViewTextBoxColumn";
            this.cODITEMREQITEMENTDataGridViewTextBoxColumn.Visible = false;
            // 
            // cODITEMPEDITEMENTDataGridViewTextBoxColumn
            // 
            this.cODITEMPEDITEMENTDataGridViewTextBoxColumn.DataPropertyName = "COD_ITEM_PED_ITEM_ENT";
            this.cODITEMPEDITEMENTDataGridViewTextBoxColumn.HeaderText = "COD_ITEM_PED_ITEM_ENT";
            this.cODITEMPEDITEMENTDataGridViewTextBoxColumn.Name = "cODITEMPEDITEMENTDataGridViewTextBoxColumn";
            this.cODITEMPEDITEMENTDataGridViewTextBoxColumn.Visible = false;
            // 
            // cODITEMESTITEMENTDataGridViewTextBoxColumn
            // 
            this.cODITEMESTITEMENTDataGridViewTextBoxColumn.DataPropertyName = "COD_ITEM_EST_ITEM_ENT";
            this.cODITEMESTITEMENTDataGridViewTextBoxColumn.HeaderText = "COD_ITEM_EST_ITEM_ENT";
            this.cODITEMESTITEMENTDataGridViewTextBoxColumn.Name = "cODITEMESTITEMENTDataGridViewTextBoxColumn";
            this.cODITEMESTITEMENTDataGridViewTextBoxColumn.Visible = false;
            // 
            // dsItens_nota_ent
            // 
            this.dsItens_nota_ent.DataSetName = "dsItens_nota_ent";
            this.dsItens_nota_ent.Namespace = "http://www.tempuri.org/dsItens_nota_ent.xsd";
            this.dsItens_nota_ent.Tables.AddRange(new System.Data.DataTable[] {
            this.ITENS_NOTA_ENT});
            // 
            // ITENS_NOTA_ENT
            // 
            this.ITENS_NOTA_ENT.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_ITENS_NOTA_ENT,
            this.DESCRICAO_ITEM_ENT,
            this.UNIDADE_ITEM_ENT,
            this.QTDE_ITEM_ENT,
            this.ST_ITEM_ENT,
            this.PRECO_UNIT_ITEM_ENT,
            this.PRECO_TOTAL_ITEM_ENT,
            this.IPI_ITEM_ENT,
            this.ICM_ITEM_ENT,
            this.NF_ITEM_ENT,
            this.VALOR_IPI_ITEM_ENT,
            this.PEDIDO_COMPRA_ITEM_ENT,
            this.MAE_ITEM_ENT,
            this.COD_ITEM_ENT,
            this.CFOP_ITEM_ENT,
            this.VALOR_ICM_ITEM_ENT,
            this.VALOR_ISS_ITEM_ENT,
            this.PRESTACAO_SERVICO_ITEM_ENT,
            this.VALOR_BC_ITEM_ENT,
            this.COD_COMISSIONARIO_ITEM_ENT,
            this.VALOR_UNIT_COMISSAO_ITEM_ENT,
            this.VALOR_TOTAL_COMISSAO_ITEM_ENT,
            this.DATA_INSERCAO_ITEM_ENT_NOTA,
            this.CNPJ_CLIENTE_ITEM_ENT,
            this.STATUS_ATUAL_NFE_ENT,
            this.PORC_COMISSAO_ITEM_ENT,
            this.N_LINHA_PED_ITEM_ENT,
            this.VALOR_BC_ICMS_ST_ITEM_ENT,
            this.VALOR_ICMS_ST_ITEM_ENT,
            this.VALOR_FRETE_ITEM_ENT,
            this.VALOR_DESCONTO_ITEM_ENT,
            this.VALOR_SEGURO_ITEM_ENT,
            this.VALOR_OUTRAS_DESP_ITEM_ENT,
            this.IVA_ITEM_ENT,
            this.REDUCAO_ITEM_ENT,
            this.COFINS_ITEM_ENT,
            this.VALOR_COFINS_ITEM_ENT,
            this.PIS_ITEM_ENT,
            this.VALOR_PIS_ITEM_ENT,
            this.ORIGEM_ITEM_ENT,
            this.MOD_BC_ITEM_ENT,
            this.ISS_ITEM_ENT,
            this.MOD_BC_ST_ITEM_ENT,
            this.REDUCAO_ST_ITEM_ENT,
            this.ICMS_ST_ITEM_ENT,
            this.ALIQUOTA_CREDITO_ITEM_ENT,
            this.VALOR_CREDITO_ITEM_ENT,
            this.IPI_TRIB_ITEM_ENT,
            this.IPI_N_TRIB_ITEM_ENT,
            this.CST_IPI_TRIB_ITEM_ENT,
            this.CST_IPI_N_TRIB_ITEM_ENT,
            this.TIPO_PIS_ITEM_ENT,
            this.CST_PIS_ITEM_ENT,
            this.TIPO_COFINS_ITEM_ENT,
            this.CST_COFINS_ITEM_ENT,
            this.TIPO_SERVICO_ITEM_ENT,
            this.ITEM_PEDIDO_COMPRA_ITEM_ENT,
            this.BC_IPI_ITEM_ENT,
            this.BC_PIS_ITEM_ENT,
            this.BC_COFINS_ITEM_ENT,
            this.BC_ISS_ITEM_ENT,
            this.BC_COM_IPI_ITEM_ENT,
            this.ST_IMPRESSAO_ITEM_ENT,
            this.ROTA_ITEM_ENT,
            this.DI_ITEM_ENT,
            this.DATA_DI_ITEM_ENT,
            this.LOCAL_DES_ITEM_ENT,
            this.UF_DES_ITEM_ENT,
            this.DATA_DES_ITEM_ENT,
            this.COD_EXP_ITEM_ENT,
            this.COD_ITEM_REQ_ITEM_ENT,
            this.COD_ITEM_PED_ITEM_ENT,
            this.COD_ITEM_EST_ITEM_ENT,
            this.COD_SISTEMA_NF_ITEM_ENT,
            this.NCM_ITEM_ENT,
            this.dataColumn18,
            this.dataColumn26});
            this.ITENS_NOTA_ENT.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_ITENS_NOTA_ENT"}, true)});
            this.ITENS_NOTA_ENT.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_ITENS_NOTA_ENT};
            this.ITENS_NOTA_ENT.TableName = "ITENS_NOTA_ENT";
            // 
            // COD_ITENS_NOTA_ENT
            // 
            this.COD_ITENS_NOTA_ENT.AllowDBNull = false;
            this.COD_ITENS_NOTA_ENT.ColumnName = "COD_ITENS_NOTA_ENT";
            this.COD_ITENS_NOTA_ENT.DataType = typeof(int);
            // 
            // DESCRICAO_ITEM_ENT
            // 
            this.DESCRICAO_ITEM_ENT.ColumnName = "DESCRICAO_ITEM_ENT";
            this.DESCRICAO_ITEM_ENT.MaxLength = 120;
            // 
            // UNIDADE_ITEM_ENT
            // 
            this.UNIDADE_ITEM_ENT.ColumnName = "UNIDADE_ITEM_ENT";
            this.UNIDADE_ITEM_ENT.MaxLength = 10;
            // 
            // QTDE_ITEM_ENT
            // 
            this.QTDE_ITEM_ENT.ColumnName = "QTDE_ITEM_ENT";
            this.QTDE_ITEM_ENT.DataType = typeof(double);
            // 
            // ST_ITEM_ENT
            // 
            this.ST_ITEM_ENT.ColumnName = "ST_ITEM_ENT";
            this.ST_ITEM_ENT.MaxLength = 40;
            // 
            // PRECO_UNIT_ITEM_ENT
            // 
            this.PRECO_UNIT_ITEM_ENT.ColumnName = "PRECO_UNIT_ITEM_ENT";
            this.PRECO_UNIT_ITEM_ENT.DataType = typeof(double);
            // 
            // PRECO_TOTAL_ITEM_ENT
            // 
            this.PRECO_TOTAL_ITEM_ENT.ColumnName = "PRECO_TOTAL_ITEM_ENT";
            this.PRECO_TOTAL_ITEM_ENT.DataType = typeof(double);
            // 
            // IPI_ITEM_ENT
            // 
            this.IPI_ITEM_ENT.ColumnName = "IPI_ITEM_ENT";
            this.IPI_ITEM_ENT.DataType = typeof(double);
            // 
            // ICM_ITEM_ENT
            // 
            this.ICM_ITEM_ENT.ColumnName = "ICM_ITEM_ENT";
            this.ICM_ITEM_ENT.DataType = typeof(double);
            // 
            // NF_ITEM_ENT
            // 
            this.NF_ITEM_ENT.ColumnName = "NF_ITEM_ENT";
            this.NF_ITEM_ENT.DataType = typeof(int);
            // 
            // VALOR_IPI_ITEM_ENT
            // 
            this.VALOR_IPI_ITEM_ENT.ColumnName = "VALOR_IPI_ITEM_ENT";
            this.VALOR_IPI_ITEM_ENT.DataType = typeof(double);
            // 
            // PEDIDO_COMPRA_ITEM_ENT
            // 
            this.PEDIDO_COMPRA_ITEM_ENT.ColumnName = "PEDIDO_COMPRA_ITEM_ENT";
            this.PEDIDO_COMPRA_ITEM_ENT.MaxLength = 20;
            // 
            // MAE_ITEM_ENT
            // 
            this.MAE_ITEM_ENT.ColumnName = "MAE_ITEM_ENT";
            this.MAE_ITEM_ENT.DataType = typeof(int);
            // 
            // COD_ITEM_ENT
            // 
            this.COD_ITEM_ENT.ColumnName = "COD_ITEM_ENT";
            this.COD_ITEM_ENT.MaxLength = 20;
            // 
            // CFOP_ITEM_ENT
            // 
            this.CFOP_ITEM_ENT.ColumnName = "CFOP_ITEM_ENT";
            this.CFOP_ITEM_ENT.MaxLength = 10;
            // 
            // VALOR_ICM_ITEM_ENT
            // 
            this.VALOR_ICM_ITEM_ENT.ColumnName = "VALOR_ICM_ITEM_ENT";
            this.VALOR_ICM_ITEM_ENT.DataType = typeof(double);
            // 
            // VALOR_ISS_ITEM_ENT
            // 
            this.VALOR_ISS_ITEM_ENT.ColumnName = "VALOR_ISS_ITEM_ENT";
            this.VALOR_ISS_ITEM_ENT.DataType = typeof(double);
            // 
            // PRESTACAO_SERVICO_ITEM_ENT
            // 
            this.PRESTACAO_SERVICO_ITEM_ENT.ColumnName = "PRESTACAO_SERVICO_ITEM_ENT";
            this.PRESTACAO_SERVICO_ITEM_ENT.DataType = typeof(int);
            // 
            // VALOR_BC_ITEM_ENT
            // 
            this.VALOR_BC_ITEM_ENT.ColumnName = "VALOR_BC_ITEM_ENT";
            this.VALOR_BC_ITEM_ENT.DataType = typeof(double);
            // 
            // COD_COMISSIONARIO_ITEM_ENT
            // 
            this.COD_COMISSIONARIO_ITEM_ENT.ColumnName = "COD_COMISSIONARIO_ITEM_ENT";
            this.COD_COMISSIONARIO_ITEM_ENT.DataType = typeof(int);
            // 
            // VALOR_UNIT_COMISSAO_ITEM_ENT
            // 
            this.VALOR_UNIT_COMISSAO_ITEM_ENT.ColumnName = "VALOR_UNIT_COMISSAO_ITEM_ENT";
            this.VALOR_UNIT_COMISSAO_ITEM_ENT.DataType = typeof(double);
            // 
            // VALOR_TOTAL_COMISSAO_ITEM_ENT
            // 
            this.VALOR_TOTAL_COMISSAO_ITEM_ENT.ColumnName = "VALOR_TOTAL_COMISSAO_ITEM_ENT";
            this.VALOR_TOTAL_COMISSAO_ITEM_ENT.DataType = typeof(double);
            // 
            // DATA_INSERCAO_ITEM_ENT_NOTA
            // 
            this.DATA_INSERCAO_ITEM_ENT_NOTA.ColumnName = "DATA_INSERCAO_ITEM_ENT_NOTA";
            this.DATA_INSERCAO_ITEM_ENT_NOTA.DataType = typeof(System.DateTime);
            // 
            // CNPJ_CLIENTE_ITEM_ENT
            // 
            this.CNPJ_CLIENTE_ITEM_ENT.ColumnName = "CNPJ_CLIENTE_ITEM_ENT";
            this.CNPJ_CLIENTE_ITEM_ENT.MaxLength = 50;
            // 
            // STATUS_ATUAL_NFE_ENT
            // 
            this.STATUS_ATUAL_NFE_ENT.ColumnName = "STATUS_ATUAL_NFE_ENT";
            this.STATUS_ATUAL_NFE_ENT.MaxLength = 100;
            // 
            // PORC_COMISSAO_ITEM_ENT
            // 
            this.PORC_COMISSAO_ITEM_ENT.ColumnName = "PORC_COMISSAO_ITEM_ENT";
            this.PORC_COMISSAO_ITEM_ENT.DataType = typeof(double);
            // 
            // N_LINHA_PED_ITEM_ENT
            // 
            this.N_LINHA_PED_ITEM_ENT.ColumnName = "N_LINHA_PED_ITEM_ENT";
            this.N_LINHA_PED_ITEM_ENT.MaxLength = 100;
            // 
            // VALOR_BC_ICMS_ST_ITEM_ENT
            // 
            this.VALOR_BC_ICMS_ST_ITEM_ENT.ColumnName = "VALOR_BC_ICMS_ST_ITEM_ENT";
            this.VALOR_BC_ICMS_ST_ITEM_ENT.DataType = typeof(double);
            // 
            // VALOR_ICMS_ST_ITEM_ENT
            // 
            this.VALOR_ICMS_ST_ITEM_ENT.ColumnName = "VALOR_ICMS_ST_ITEM_ENT";
            this.VALOR_ICMS_ST_ITEM_ENT.DataType = typeof(double);
            // 
            // VALOR_FRETE_ITEM_ENT
            // 
            this.VALOR_FRETE_ITEM_ENT.ColumnName = "VALOR_FRETE_ITEM_ENT";
            this.VALOR_FRETE_ITEM_ENT.DataType = typeof(double);
            // 
            // VALOR_DESCONTO_ITEM_ENT
            // 
            this.VALOR_DESCONTO_ITEM_ENT.ColumnName = "VALOR_DESCONTO_ITEM_ENT";
            this.VALOR_DESCONTO_ITEM_ENT.DataType = typeof(double);
            // 
            // VALOR_SEGURO_ITEM_ENT
            // 
            this.VALOR_SEGURO_ITEM_ENT.ColumnName = "VALOR_SEGURO_ITEM_ENT";
            this.VALOR_SEGURO_ITEM_ENT.DataType = typeof(double);
            // 
            // VALOR_OUTRAS_DESP_ITEM_ENT
            // 
            this.VALOR_OUTRAS_DESP_ITEM_ENT.ColumnName = "VALOR_OUTRAS_DESP_ITEM_ENT";
            this.VALOR_OUTRAS_DESP_ITEM_ENT.DataType = typeof(double);
            // 
            // IVA_ITEM_ENT
            // 
            this.IVA_ITEM_ENT.ColumnName = "IVA_ITEM_ENT";
            this.IVA_ITEM_ENT.DataType = typeof(double);
            // 
            // REDUCAO_ITEM_ENT
            // 
            this.REDUCAO_ITEM_ENT.ColumnName = "REDUCAO_ITEM_ENT";
            this.REDUCAO_ITEM_ENT.DataType = typeof(double);
            // 
            // COFINS_ITEM_ENT
            // 
            this.COFINS_ITEM_ENT.ColumnName = "COFINS_ITEM_ENT";
            this.COFINS_ITEM_ENT.DataType = typeof(double);
            // 
            // VALOR_COFINS_ITEM_ENT
            // 
            this.VALOR_COFINS_ITEM_ENT.ColumnName = "VALOR_COFINS_ITEM_ENT";
            this.VALOR_COFINS_ITEM_ENT.DataType = typeof(double);
            // 
            // PIS_ITEM_ENT
            // 
            this.PIS_ITEM_ENT.ColumnName = "PIS_ITEM_ENT";
            this.PIS_ITEM_ENT.DataType = typeof(double);
            // 
            // VALOR_PIS_ITEM_ENT
            // 
            this.VALOR_PIS_ITEM_ENT.ColumnName = "VALOR_PIS_ITEM_ENT";
            this.VALOR_PIS_ITEM_ENT.DataType = typeof(double);
            // 
            // ORIGEM_ITEM_ENT
            // 
            this.ORIGEM_ITEM_ENT.ColumnName = "ORIGEM_ITEM_ENT";
            this.ORIGEM_ITEM_ENT.MaxLength = 1;
            // 
            // MOD_BC_ITEM_ENT
            // 
            this.MOD_BC_ITEM_ENT.ColumnName = "MOD_BC_ITEM_ENT";
            this.MOD_BC_ITEM_ENT.MaxLength = 100;
            // 
            // ISS_ITEM_ENT
            // 
            this.ISS_ITEM_ENT.ColumnName = "ISS_ITEM_ENT";
            this.ISS_ITEM_ENT.DataType = typeof(double);
            // 
            // MOD_BC_ST_ITEM_ENT
            // 
            this.MOD_BC_ST_ITEM_ENT.ColumnName = "MOD_BC_ST_ITEM_ENT";
            this.MOD_BC_ST_ITEM_ENT.MaxLength = 100;
            // 
            // REDUCAO_ST_ITEM_ENT
            // 
            this.REDUCAO_ST_ITEM_ENT.ColumnName = "REDUCAO_ST_ITEM_ENT";
            this.REDUCAO_ST_ITEM_ENT.DataType = typeof(double);
            // 
            // ICMS_ST_ITEM_ENT
            // 
            this.ICMS_ST_ITEM_ENT.ColumnName = "ICMS_ST_ITEM_ENT";
            this.ICMS_ST_ITEM_ENT.DataType = typeof(double);
            // 
            // ALIQUOTA_CREDITO_ITEM_ENT
            // 
            this.ALIQUOTA_CREDITO_ITEM_ENT.ColumnName = "ALIQUOTA_CREDITO_ITEM_ENT";
            this.ALIQUOTA_CREDITO_ITEM_ENT.DataType = typeof(double);
            // 
            // VALOR_CREDITO_ITEM_ENT
            // 
            this.VALOR_CREDITO_ITEM_ENT.ColumnName = "VALOR_CREDITO_ITEM_ENT";
            this.VALOR_CREDITO_ITEM_ENT.DataType = typeof(double);
            // 
            // IPI_TRIB_ITEM_ENT
            // 
            this.IPI_TRIB_ITEM_ENT.ColumnName = "IPI_TRIB_ITEM_ENT";
            this.IPI_TRIB_ITEM_ENT.DataType = typeof(int);
            // 
            // IPI_N_TRIB_ITEM_ENT
            // 
            this.IPI_N_TRIB_ITEM_ENT.ColumnName = "IPI_N_TRIB_ITEM_ENT";
            this.IPI_N_TRIB_ITEM_ENT.DataType = typeof(int);
            // 
            // CST_IPI_TRIB_ITEM_ENT
            // 
            this.CST_IPI_TRIB_ITEM_ENT.ColumnName = "CST_IPI_TRIB_ITEM_ENT";
            this.CST_IPI_TRIB_ITEM_ENT.MaxLength = 100;
            // 
            // CST_IPI_N_TRIB_ITEM_ENT
            // 
            this.CST_IPI_N_TRIB_ITEM_ENT.ColumnName = "CST_IPI_N_TRIB_ITEM_ENT";
            this.CST_IPI_N_TRIB_ITEM_ENT.MaxLength = 100;
            // 
            // TIPO_PIS_ITEM_ENT
            // 
            this.TIPO_PIS_ITEM_ENT.ColumnName = "TIPO_PIS_ITEM_ENT";
            this.TIPO_PIS_ITEM_ENT.MaxLength = 100;
            // 
            // CST_PIS_ITEM_ENT
            // 
            this.CST_PIS_ITEM_ENT.ColumnName = "CST_PIS_ITEM_ENT";
            this.CST_PIS_ITEM_ENT.MaxLength = 200;
            // 
            // TIPO_COFINS_ITEM_ENT
            // 
            this.TIPO_COFINS_ITEM_ENT.ColumnName = "TIPO_COFINS_ITEM_ENT";
            this.TIPO_COFINS_ITEM_ENT.MaxLength = 100;
            // 
            // CST_COFINS_ITEM_ENT
            // 
            this.CST_COFINS_ITEM_ENT.ColumnName = "CST_COFINS_ITEM_ENT";
            this.CST_COFINS_ITEM_ENT.MaxLength = 200;
            // 
            // TIPO_SERVICO_ITEM_ENT
            // 
            this.TIPO_SERVICO_ITEM_ENT.ColumnName = "TIPO_SERVICO_ITEM_ENT";
            this.TIPO_SERVICO_ITEM_ENT.MaxLength = 100;
            // 
            // ITEM_PEDIDO_COMPRA_ITEM_ENT
            // 
            this.ITEM_PEDIDO_COMPRA_ITEM_ENT.ColumnName = "ITEM_PEDIDO_COMPRA_ITEM_ENT";
            this.ITEM_PEDIDO_COMPRA_ITEM_ENT.MaxLength = 100;
            // 
            // BC_IPI_ITEM_ENT
            // 
            this.BC_IPI_ITEM_ENT.ColumnName = "BC_IPI_ITEM_ENT";
            this.BC_IPI_ITEM_ENT.DataType = typeof(double);
            // 
            // BC_PIS_ITEM_ENT
            // 
            this.BC_PIS_ITEM_ENT.ColumnName = "BC_PIS_ITEM_ENT";
            this.BC_PIS_ITEM_ENT.DataType = typeof(double);
            // 
            // BC_COFINS_ITEM_ENT
            // 
            this.BC_COFINS_ITEM_ENT.ColumnName = "BC_COFINS_ITEM_ENT";
            this.BC_COFINS_ITEM_ENT.DataType = typeof(double);
            // 
            // BC_ISS_ITEM_ENT
            // 
            this.BC_ISS_ITEM_ENT.ColumnName = "BC_ISS_ITEM_ENT";
            this.BC_ISS_ITEM_ENT.DataType = typeof(double);
            // 
            // BC_COM_IPI_ITEM_ENT
            // 
            this.BC_COM_IPI_ITEM_ENT.ColumnName = "BC_COM_IPI_ITEM_ENT";
            this.BC_COM_IPI_ITEM_ENT.DataType = typeof(int);
            // 
            // ST_IMPRESSAO_ITEM_ENT
            // 
            this.ST_IMPRESSAO_ITEM_ENT.ColumnName = "ST_IMPRESSAO_ITEM_ENT";
            this.ST_IMPRESSAO_ITEM_ENT.MaxLength = 4;
            // 
            // ROTA_ITEM_ENT
            // 
            this.ROTA_ITEM_ENT.ColumnName = "ROTA_ITEM_ENT";
            this.ROTA_ITEM_ENT.MaxLength = 20;
            // 
            // DI_ITEM_ENT
            // 
            this.DI_ITEM_ENT.ColumnName = "DI_ITEM_ENT";
            this.DI_ITEM_ENT.MaxLength = 10;
            // 
            // DATA_DI_ITEM_ENT
            // 
            this.DATA_DI_ITEM_ENT.ColumnName = "DATA_DI_ITEM_ENT";
            this.DATA_DI_ITEM_ENT.DataType = typeof(System.DateTime);
            // 
            // LOCAL_DES_ITEM_ENT
            // 
            this.LOCAL_DES_ITEM_ENT.ColumnName = "LOCAL_DES_ITEM_ENT";
            this.LOCAL_DES_ITEM_ENT.MaxLength = 60;
            // 
            // UF_DES_ITEM_ENT
            // 
            this.UF_DES_ITEM_ENT.ColumnName = "UF_DES_ITEM_ENT";
            this.UF_DES_ITEM_ENT.MaxLength = 2;
            // 
            // DATA_DES_ITEM_ENT
            // 
            this.DATA_DES_ITEM_ENT.ColumnName = "DATA_DES_ITEM_ENT";
            this.DATA_DES_ITEM_ENT.DataType = typeof(System.DateTime);
            // 
            // COD_EXP_ITEM_ENT
            // 
            this.COD_EXP_ITEM_ENT.ColumnName = "COD_EXP_ITEM_ENT";
            this.COD_EXP_ITEM_ENT.MaxLength = 60;
            // 
            // COD_ITEM_REQ_ITEM_ENT
            // 
            this.COD_ITEM_REQ_ITEM_ENT.ColumnName = "COD_ITEM_REQ_ITEM_ENT";
            this.COD_ITEM_REQ_ITEM_ENT.DataType = typeof(int);
            // 
            // COD_ITEM_PED_ITEM_ENT
            // 
            this.COD_ITEM_PED_ITEM_ENT.ColumnName = "COD_ITEM_PED_ITEM_ENT";
            this.COD_ITEM_PED_ITEM_ENT.DataType = typeof(int);
            // 
            // COD_ITEM_EST_ITEM_ENT
            // 
            this.COD_ITEM_EST_ITEM_ENT.ColumnName = "COD_ITEM_EST_ITEM_ENT";
            this.COD_ITEM_EST_ITEM_ENT.DataType = typeof(int);
            // 
            // COD_SISTEMA_NF_ITEM_ENT
            // 
            this.COD_SISTEMA_NF_ITEM_ENT.ColumnName = "COD_SISTEMA_NF_ITEM_ENT";
            this.COD_SISTEMA_NF_ITEM_ENT.DataType = typeof(int);
            // 
            // NCM_ITEM_ENT
            // 
            this.NCM_ITEM_ENT.ColumnName = "NCM_ITEM_ENT";
            this.NCM_ITEM_ENT.MaxLength = 50;
            // 
            // dataColumn18
            // 
            this.dataColumn18.ColumnName = "QTDE_LOTE_ITEM_ENT";
            this.dataColumn18.DataType = typeof(double);
            // 
            // dataColumn26
            // 
            this.dataColumn26.ColumnName = "LOTE_ITEM_ENT";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(8, 9);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(121, 25);
            this.label27.TabIndex = 78;
            this.label27.Text = "NF Entrada";
            // 
            // datItens_nota_ent
            // 
            this.datItens_nota_ent.DeleteCommand = this.fbCommand20;
            this.datItens_nota_ent.InsertCommand = this.fbCommand18;
            this.datItens_nota_ent.SelectCommand = this.fbCommand17;
            this.datItens_nota_ent.UpdateCommand = this.fbCommand19;
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
            this.fbCommand17.CommandText = "select * from itens_nota_ent";
            this.fbCommand17.CommandTimeout = 30;
            this.fbCommand17.Connection = this.fbConnection1;
            // 
            // fbCommand19
            // 
            this.fbCommand19.CommandTimeout = 30;
            // 
            // fbCommand21
            // 
            this.fbCommand21.CommandText = "select * from requisicoes";
            this.fbCommand21.CommandTimeout = 30;
            this.fbCommand21.Connection = this.fbConnection1;
            // 
            // fbCommand22
            // 
            this.fbCommand22.CommandTimeout = 30;
            // 
            // fbCommand23
            // 
            this.fbCommand23.CommandTimeout = 30;
            // 
            // fbCommand24
            // 
            this.fbCommand24.CommandTimeout = 30;
            // 
            // datItens_requisicao
            // 
            this.datItens_requisicao.DeleteCommand = this.fbCommand28;
            this.datItens_requisicao.InsertCommand = this.fbCommand26;
            this.datItens_requisicao.SelectCommand = this.fbCommand25;
            this.datItens_requisicao.UpdateCommand = this.fbCommand27;
            // 
            // fbCommand28
            // 
            this.fbCommand28.CommandTimeout = 30;
            // 
            // fbCommand26
            // 
            this.fbCommand26.CommandTimeout = 30;
            // 
            // fbCommand25
            // 
            this.fbCommand25.CommandText = "select * from itens_requisicao";
            this.fbCommand25.CommandTimeout = 30;
            this.fbCommand25.Connection = this.fbConnection1;
            // 
            // fbCommand27
            // 
            this.fbCommand27.CommandTimeout = 30;
            // 
            // cbSaida_estoque
            // 
            this.cbSaida_estoque.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbSaida_estoque.DataAdapter = this.datSaida_estoque;
            this.cbSaida_estoque.QuotePrefix = "\"";
            this.cbSaida_estoque.QuoteSuffix = "\"";
            // 
            // cbItens_nota_ent
            // 
            this.cbItens_nota_ent.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbItens_nota_ent.DataAdapter = this.datItens_nota_ent;
            this.cbItens_nota_ent.QuotePrefix = "\"";
            this.cbItens_nota_ent.QuoteSuffix = "\"";
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(789, 12);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(176, 23);
            this.button11.TabIndex = 167;
            this.button11.Text = "Imprimir todos códigos";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Visible = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Coral;
            this.panel3.Controls.Add(this.dgvOp);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(678, 383);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(163, 236);
            this.panel3.TabIndex = 168;
            // 
            // dgvOp
            // 
            this.dgvOp.AllowUserToAddRows = false;
            this.dgvOp.AllowUserToDeleteRows = false;
            this.dgvOp.AutoGenerateColumns = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvOp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODOPDataGridViewTextBoxColumn,
            this.POSICAO,
            this.qTDEMATERIALOPDataGridViewTextBoxColumn,
            this.nOMEPECAOPDataGridViewTextBoxColumn,
            this.mATERIALRETIRADOOPDataGridViewTextBoxColumn});
            this.dgvOp.DataMember = "OP";
            this.dgvOp.DataSource = this.dsOp;
            this.dgvOp.Location = new System.Drawing.Point(3, 37);
            this.dgvOp.Name = "dgvOp";
            this.dgvOp.RowHeadersWidth = 15;
            this.dgvOp.Size = new System.Drawing.Size(156, 192);
            this.dgvOp.TabIndex = 157;
            this.dgvOp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOp_CellContentClick);
            // 
            // cODOPDataGridViewTextBoxColumn
            // 
            this.cODOPDataGridViewTextBoxColumn.DataPropertyName = "DESENHO_OP_ATUAL";
            this.cODOPDataGridViewTextBoxColumn.HeaderText = "OS";
            this.cODOPDataGridViewTextBoxColumn.Name = "cODOPDataGridViewTextBoxColumn";
            this.cODOPDataGridViewTextBoxColumn.Width = 30;
            // 
            // POSICAO
            // 
            this.POSICAO.DataPropertyName = "COD_OP";
            this.POSICAO.HeaderText = "POS";
            this.POSICAO.Name = "POSICAO";
            // 
            // qTDEMATERIALOPDataGridViewTextBoxColumn
            // 
            this.qTDEMATERIALOPDataGridViewTextBoxColumn.DataPropertyName = "QTDE_MATERIAL_OP";
            this.qTDEMATERIALOPDataGridViewTextBoxColumn.HeaderText = "Qtde";
            this.qTDEMATERIALOPDataGridViewTextBoxColumn.Name = "qTDEMATERIALOPDataGridViewTextBoxColumn";
            this.qTDEMATERIALOPDataGridViewTextBoxColumn.Width = 40;
            // 
            // nOMEPECAOPDataGridViewTextBoxColumn
            // 
            this.nOMEPECAOPDataGridViewTextBoxColumn.DataPropertyName = "NOME_PECA_OP";
            this.nOMEPECAOPDataGridViewTextBoxColumn.HeaderText = "Peça";
            this.nOMEPECAOPDataGridViewTextBoxColumn.Name = "nOMEPECAOPDataGridViewTextBoxColumn";
            // 
            // mATERIALRETIRADOOPDataGridViewTextBoxColumn
            // 
            this.mATERIALRETIRADOOPDataGridViewTextBoxColumn.DataPropertyName = "MATERIAL_RETIRADO_OP";
            this.mATERIALRETIRADOOPDataGridViewTextBoxColumn.FalseValue = "0";
            this.mATERIALRETIRADOOPDataGridViewTextBoxColumn.HeaderText = "Ret.";
            this.mATERIALRETIRADOOPDataGridViewTextBoxColumn.IndeterminateValue = "0";
            this.mATERIALRETIRADOOPDataGridViewTextBoxColumn.Name = "mATERIALRETIRADOOPDataGridViewTextBoxColumn";
            this.mATERIALRETIRADOOPDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.mATERIALRETIRADOOPDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.mATERIALRETIRADOOPDataGridViewTextBoxColumn.TrueValue = "1";
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
            this.LOTE,
            this.ESPESSURA_OP,
            this.OBSERVACOES_OP,
            this.REVISAO_OP,
            this.DESCRICAO_PECA_OP,
            this.MARCA_OP,
            this.UNIDADE_OP,
            this.ICMS_OP,
            this.IPI_OP,
            this.SIT_OP,
            this.UNID_OP,
            this.PRECO_UNIT,
            this.OP_MAE,
            this.CLIENTE_OP,
            this.SIT_ATUAL_OP,
            this.PORC_A_MAIS_OP,
            this.NOME_PECA_OP,
            this.NCM_OP,
            this.QTDE_FATURADA_OP,
            this.NFS_FATURADAS_OP,
            this.N_OPERACOES_OP,
            this.DATA_ULT_ALTERACAO_OP,
            this.HORA_ULT_ALTERACAO_OP,
            this.COD_COMISSIONARIO_OP,
            this.NOME_COMISSIONARIO_OP,
            this.VALOR_COMISSAO_OP,
            this.PROJETO_OP,
            this.ITEM_OP,
            this.PORC_COMISSAO_OP,
            this.PREVISAO_OP,
            this.COLOCADO_EM_ESTOQUE_OP,
            this.DATA_EMISSAO_OP,
            this.OPERADOR_CRIADOR_OP,
            this.PORC_SUCATA_OP,
            this.FUNCAO_OP,
            this.FERRAMENTA_OP,
            this.FINALIZADO_OP,
            this.POSICAO_ATUAL_OP,
            this.TRAT_TERMICO_OP,
            this.MATERIAL_FORN_OP,
            this.NF_MATERIAL_OP,
            this.DUREZA_SOLIC_OP,
            this.DUREZA_ENC_OP,
            this.NF_SAIDA_OP,
            this.DATA_NF_SAIDA,
            this.PROCESSO_OP,
            this.CODIGO_OP,
            this.DATA_ENTRADA_OP,
            this.COD_MATERIAL_OP,
            this.QTDE_MATERIAL_OP,
            this.MATERIAL_RETIRADO_OP,
            this.QTDE_EST_POR_MATERIAL_OP,
            this.COD_ACAB_SUP_OP,
            this.DESCRICAO_ACAB_SUP_OP});
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
            this.COND_PGTO.MaxLength = 10;
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
            this.MATERIAL_OP.MaxLength = 100;
            // 
            // LOTE
            // 
            this.LOTE.ColumnName = "LOTE";
            this.LOTE.MaxLength = 30;
            // 
            // ESPESSURA_OP
            // 
            this.ESPESSURA_OP.ColumnName = "ESPESSURA_OP";
            this.ESPESSURA_OP.MaxLength = 30;
            // 
            // OBSERVACOES_OP
            // 
            this.OBSERVACOES_OP.ColumnName = "OBSERVACOES_OP";
            this.OBSERVACOES_OP.MaxLength = 300;
            // 
            // REVISAO_OP
            // 
            this.REVISAO_OP.ColumnName = "REVISAO_OP";
            this.REVISAO_OP.MaxLength = 50;
            // 
            // DESCRICAO_PECA_OP
            // 
            this.DESCRICAO_PECA_OP.ColumnName = "DESCRICAO_PECA_OP";
            this.DESCRICAO_PECA_OP.MaxLength = 120;
            // 
            // MARCA_OP
            // 
            this.MARCA_OP.ColumnName = "MARCA_OP";
            this.MARCA_OP.MaxLength = 30;
            // 
            // UNIDADE_OP
            // 
            this.UNIDADE_OP.ColumnName = "UNIDADE_OP";
            this.UNIDADE_OP.MaxLength = 30;
            // 
            // ICMS_OP
            // 
            this.ICMS_OP.ColumnName = "ICMS_OP";
            this.ICMS_OP.DataType = typeof(double);
            // 
            // IPI_OP
            // 
            this.IPI_OP.ColumnName = "IPI_OP";
            this.IPI_OP.DataType = typeof(double);
            // 
            // SIT_OP
            // 
            this.SIT_OP.ColumnName = "SIT_OP";
            this.SIT_OP.DataType = typeof(double);
            // 
            // UNID_OP
            // 
            this.UNID_OP.ColumnName = "UNID_OP";
            this.UNID_OP.MaxLength = 8;
            // 
            // PRECO_UNIT
            // 
            this.PRECO_UNIT.ColumnName = "PRECO_UNIT";
            this.PRECO_UNIT.DataType = typeof(double);
            // 
            // OP_MAE
            // 
            this.OP_MAE.ColumnName = "OP_MAE";
            this.OP_MAE.DataType = typeof(int);
            // 
            // CLIENTE_OP
            // 
            this.CLIENTE_OP.ColumnName = "CLIENTE_OP";
            this.CLIENTE_OP.MaxLength = 100;
            // 
            // SIT_ATUAL_OP
            // 
            this.SIT_ATUAL_OP.ColumnName = "SIT_ATUAL_OP";
            this.SIT_ATUAL_OP.MaxLength = 70;
            // 
            // PORC_A_MAIS_OP
            // 
            this.PORC_A_MAIS_OP.ColumnName = "PORC_A_MAIS_OP";
            this.PORC_A_MAIS_OP.DataType = typeof(int);
            // 
            // NOME_PECA_OP
            // 
            this.NOME_PECA_OP.ColumnName = "NOME_PECA_OP";
            this.NOME_PECA_OP.MaxLength = 150;
            // 
            // NCM_OP
            // 
            this.NCM_OP.ColumnName = "NCM_OP";
            this.NCM_OP.MaxLength = 20;
            // 
            // QTDE_FATURADA_OP
            // 
            this.QTDE_FATURADA_OP.ColumnName = "QTDE_FATURADA_OP";
            this.QTDE_FATURADA_OP.DataType = typeof(double);
            // 
            // NFS_FATURADAS_OP
            // 
            this.NFS_FATURADAS_OP.ColumnName = "NFS_FATURADAS_OP";
            this.NFS_FATURADAS_OP.MaxLength = 100;
            // 
            // N_OPERACOES_OP
            // 
            this.N_OPERACOES_OP.ColumnName = "N_OPERACOES_OP";
            this.N_OPERACOES_OP.DataType = typeof(int);
            // 
            // DATA_ULT_ALTERACAO_OP
            // 
            this.DATA_ULT_ALTERACAO_OP.ColumnName = "DATA_ULT_ALTERACAO_OP";
            this.DATA_ULT_ALTERACAO_OP.DataType = typeof(System.DateTime);
            // 
            // HORA_ULT_ALTERACAO_OP
            // 
            this.HORA_ULT_ALTERACAO_OP.ColumnName = "HORA_ULT_ALTERACAO_OP";
            this.HORA_ULT_ALTERACAO_OP.DataType = typeof(System.DateTime);
            // 
            // COD_COMISSIONARIO_OP
            // 
            this.COD_COMISSIONARIO_OP.ColumnName = "COD_COMISSIONARIO_OP";
            this.COD_COMISSIONARIO_OP.DataType = typeof(int);
            // 
            // NOME_COMISSIONARIO_OP
            // 
            this.NOME_COMISSIONARIO_OP.ColumnName = "NOME_COMISSIONARIO_OP";
            this.NOME_COMISSIONARIO_OP.MaxLength = 200;
            // 
            // VALOR_COMISSAO_OP
            // 
            this.VALOR_COMISSAO_OP.ColumnName = "VALOR_COMISSAO_OP";
            this.VALOR_COMISSAO_OP.DataType = typeof(double);
            // 
            // PROJETO_OP
            // 
            this.PROJETO_OP.ColumnName = "PROJETO_OP";
            this.PROJETO_OP.MaxLength = 100;
            // 
            // ITEM_OP
            // 
            this.ITEM_OP.ColumnName = "ITEM_OP";
            this.ITEM_OP.MaxLength = 20;
            // 
            // PORC_COMISSAO_OP
            // 
            this.PORC_COMISSAO_OP.ColumnName = "PORC_COMISSAO_OP";
            this.PORC_COMISSAO_OP.DataType = typeof(double);
            // 
            // PREVISAO_OP
            // 
            this.PREVISAO_OP.ColumnName = "PREVISAO_OP";
            this.PREVISAO_OP.DataType = typeof(int);
            // 
            // COLOCADO_EM_ESTOQUE_OP
            // 
            this.COLOCADO_EM_ESTOQUE_OP.ColumnName = "COLOCADO_EM_ESTOQUE_OP";
            this.COLOCADO_EM_ESTOQUE_OP.DataType = typeof(int);
            // 
            // DATA_EMISSAO_OP
            // 
            this.DATA_EMISSAO_OP.ColumnName = "DATA_EMISSAO_OP";
            this.DATA_EMISSAO_OP.DataType = typeof(System.DateTime);
            // 
            // OPERADOR_CRIADOR_OP
            // 
            this.OPERADOR_CRIADOR_OP.ColumnName = "OPERADOR_CRIADOR_OP";
            this.OPERADOR_CRIADOR_OP.MaxLength = 100;
            // 
            // PORC_SUCATA_OP
            // 
            this.PORC_SUCATA_OP.ColumnName = "PORC_SUCATA_OP";
            this.PORC_SUCATA_OP.DataType = typeof(double);
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
            // DATA_ENTRADA_OP
            // 
            this.DATA_ENTRADA_OP.ColumnName = "DATA_ENTRADA_OP";
            this.DATA_ENTRADA_OP.DataType = typeof(System.DateTime);
            // 
            // COD_MATERIAL_OP
            // 
            this.COD_MATERIAL_OP.ColumnName = "COD_MATERIAL_OP";
            this.COD_MATERIAL_OP.DataType = typeof(int);
            // 
            // QTDE_MATERIAL_OP
            // 
            this.QTDE_MATERIAL_OP.ColumnName = "QTDE_MATERIAL_OP";
            this.QTDE_MATERIAL_OP.DataType = typeof(double);
            // 
            // MATERIAL_RETIRADO_OP
            // 
            this.MATERIAL_RETIRADO_OP.ColumnName = "MATERIAL_RETIRADO_OP";
            this.MATERIAL_RETIRADO_OP.DataType = typeof(int);
            // 
            // QTDE_EST_POR_MATERIAL_OP
            // 
            this.QTDE_EST_POR_MATERIAL_OP.ColumnName = "QTDE_EST_POR_MATERIAL_OP";
            this.QTDE_EST_POR_MATERIAL_OP.DataType = typeof(double);
            // 
            // COD_ACAB_SUP_OP
            // 
            this.COD_ACAB_SUP_OP.ColumnName = "COD_ACAB_SUP_OP";
            this.COD_ACAB_SUP_OP.DataType = typeof(int);
            // 
            // DESCRICAO_ACAB_SUP_OP
            // 
            this.DESCRICAO_ACAB_SUP_OP.ColumnName = "DESCRICAO_ACAB_SUP_OP";
            this.DESCRICAO_ACAB_SUP_OP.MaxLength = 200;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 92;
            this.label3.Text = "Reservas";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // datOp
            // 
            this.datOp.DeleteCommand = this.fbCommand32;
            this.datOp.InsertCommand = this.fbCommand30;
            this.datOp.SelectCommand = this.fbCommand29;
            this.datOp.UpdateCommand = this.fbCommand31;
            // 
            // fbCommand32
            // 
            this.fbCommand32.CommandTimeout = 30;
            // 
            // fbCommand30
            // 
            this.fbCommand30.CommandTimeout = 30;
            // 
            // fbCommand29
            // 
            this.fbCommand29.CommandText = "select * from op";
            this.fbCommand29.CommandTimeout = 30;
            this.fbCommand29.Connection = this.fbConnection1;
            // 
            // fbCommand31
            // 
            this.fbCommand31.CommandTimeout = 30;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Coral;
            this.panel8.Controls.Add(this.dataGridView1);
            this.panel8.Controls.Add(this.label36);
            this.panel8.Location = new System.Drawing.Point(843, 383);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(163, 236);
            this.panel8.TabIndex = 170;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODLOTEDataGridViewTextBoxColumn,
            this.sALDODataGridViewTextBoxColumn});
            this.dataGridView1.DataMember = "LOTES";
            this.dataGridView1.DataSource = this.dsLotes;
            this.dataGridView1.Location = new System.Drawing.Point(3, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 15;
            this.dataGridView1.Size = new System.Drawing.Size(156, 192);
            this.dataGridView1.TabIndex = 157;
            // 
            // cODLOTEDataGridViewTextBoxColumn
            // 
            this.cODLOTEDataGridViewTextBoxColumn.DataPropertyName = "COD_LOTE";
            this.cODLOTEDataGridViewTextBoxColumn.HeaderText = "Lote";
            this.cODLOTEDataGridViewTextBoxColumn.Name = "cODLOTEDataGridViewTextBoxColumn";
            this.cODLOTEDataGridViewTextBoxColumn.Width = 45;
            // 
            // sALDODataGridViewTextBoxColumn
            // 
            this.sALDODataGridViewTextBoxColumn.DataPropertyName = "SALDO";
            this.sALDODataGridViewTextBoxColumn.HeaderText = "Saldo";
            this.sALDODataGridViewTextBoxColumn.Name = "sALDODataGridViewTextBoxColumn";
            // 
            // dsLotes
            // 
            this.dsLotes.DataSetName = "dsLotes";
            this.dsLotes.Namespace = "http://www.tempuri.org/dsLotes.xsd";
            this.dsLotes.Tables.AddRange(new System.Data.DataTable[] {
            this.LOTES});
            // 
            // LOTES
            // 
            this.LOTES.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_LOTE,
            this.SALDO,
            this.dataColumn19});
            this.LOTES.TableName = "LOTES";
            // 
            // COD_LOTE
            // 
            this.COD_LOTE.AllowDBNull = false;
            this.COD_LOTE.ColumnName = "COD_LOTE";
            this.COD_LOTE.DataType = typeof(int);
            // 
            // SALDO
            // 
            this.SALDO.ColumnName = "SALDO";
            this.SALDO.DataType = typeof(double);
            // 
            // dataColumn19
            // 
            this.dataColumn19.Caption = "PALETE";
            this.dataColumn19.ColumnName = "PALETE";
            this.dataColumn19.DataType = typeof(int);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(4, 9);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(65, 25);
            this.label36.TabIndex = 92;
            this.label36.Text = "Lotes";
            this.label36.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // gbxControle
            // 
            this.gbxControle.Controls.Add(this.button12);
            this.gbxControle.Controls.Add(this.label37);
            this.gbxControle.Controls.Add(this.label38);
            this.gbxControle.Controls.Add(this.txtPlanoControle);
            this.gbxControle.Controls.Add(this.txtCodControle);
            this.gbxControle.Location = new System.Drawing.Point(549, 290);
            this.gbxControle.Name = "gbxControle";
            this.gbxControle.Size = new System.Drawing.Size(165, 81);
            this.gbxControle.TabIndex = 171;
            this.gbxControle.TabStop = false;
            this.gbxControle.Text = "Controle";
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(116, 17);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(21, 23);
            this.button12.TabIndex = 194;
            this.button12.Text = "+";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(11, 22);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(32, 13);
            this.label37.TabIndex = 194;
            this.label37.Text = "Cód.:";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(11, 52);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(37, 13);
            this.label38.TabIndex = 195;
            this.label38.Text = "Plano:";
            // 
            // txtPlanoControle
            // 
            this.txtPlanoControle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsEstoque, "ESTOQUE.PLANO_CONTROLE_ESTOQUE", true));
            this.txtPlanoControle.Location = new System.Drawing.Point(54, 49);
            this.txtPlanoControle.Name = "txtPlanoControle";
            this.txtPlanoControle.ReadOnly = true;
            this.txtPlanoControle.Size = new System.Drawing.Size(100, 20);
            this.txtPlanoControle.TabIndex = 1;
            // 
            // txtCodControle
            // 
            this.txtCodControle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsEstoque, "ESTOQUE.COD_CONTROLE_ESTOQUE", true));
            this.txtCodControle.Location = new System.Drawing.Point(54, 19);
            this.txtCodControle.Name = "txtCodControle";
            this.txtCodControle.ReadOnly = true;
            this.txtCodControle.Size = new System.Drawing.Size(58, 20);
            this.txtCodControle.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label39);
            this.groupBox1.Controls.Add(this.label40);
            this.groupBox1.Controls.Add(this.textBox12);
            this.groupBox1.Controls.Add(this.textBox13);
            this.groupBox1.Location = new System.Drawing.Point(739, 290);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 81);
            this.groupBox1.TabIndex = 172;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dureza";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(11, 22);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(43, 13);
            this.label39.TabIndex = 194;
            this.label39.Text = "Minima:";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(11, 52);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(46, 13);
            this.label40.TabIndex = 195;
            this.label40.Text = "Máxima:";
            // 
            // textBox12
            // 
            this.textBox12.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsEstoque, "ESTOQUE.DUREZA_MAXIMA_ESTOQUE", true));
            this.textBox12.Location = new System.Drawing.Point(71, 49);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(83, 20);
            this.textBox12.TabIndex = 1;
            // 
            // textBox13
            // 
            this.textBox13.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsEstoque, "ESTOQUE.DUREZA_MINIMA_ESTOQUE", true));
            this.textBox13.Location = new System.Drawing.Point(71, 19);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(83, 20);
            this.textBox13.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label41);
            this.groupBox2.Controls.Add(this.tb_cnpj_forn);
            this.groupBox2.Controls.Add(this.bt_localizar_forn);
            this.groupBox2.Controls.Add(this.label42);
            this.groupBox2.Controls.Add(this.tb_nome_forn);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 83);
            this.groupBox2.TabIndex = 173;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fornecedor";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(9, 51);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(37, 13);
            this.label41.TabIndex = 72;
            this.label41.Text = "CNPJ:";
            // 
            // tb_cnpj_forn
            // 
            this.tb_cnpj_forn.Location = new System.Drawing.Point(70, 48);
            this.tb_cnpj_forn.Name = "tb_cnpj_forn";
            this.tb_cnpj_forn.ReadOnly = true;
            this.tb_cnpj_forn.Size = new System.Drawing.Size(174, 20);
            this.tb_cnpj_forn.TabIndex = 6;
            // 
            // bt_localizar_forn
            // 
            this.bt_localizar_forn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_localizar_forn.BackgroundImage")));
            this.bt_localizar_forn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_localizar_forn.Location = new System.Drawing.Point(250, 22);
            this.bt_localizar_forn.Name = "bt_localizar_forn";
            this.bt_localizar_forn.Size = new System.Drawing.Size(47, 46);
            this.bt_localizar_forn.TabIndex = 0;
            this.bt_localizar_forn.UseVisualStyleBackColor = true;
            this.bt_localizar_forn.Click += new System.EventHandler(this.bt_localizar_forn_Click);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(9, 25);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(38, 13);
            this.label42.TabIndex = 61;
            this.label42.Text = "Nome:";
            // 
            // tb_nome_forn
            // 
            this.tb_nome_forn.Location = new System.Drawing.Point(70, 22);
            this.tb_nome_forn.Name = "tb_nome_forn";
            this.tb_nome_forn.ReadOnly = true;
            this.tb_nome_forn.Size = new System.Drawing.Size(174, 20);
            this.tb_nome_forn.TabIndex = 5;
            // 
            // dgvEstoque_fornecedor
            // 
            this.dgvEstoque_fornecedor.AllowUserToAddRows = false;
            this.dgvEstoque_fornecedor.AutoGenerateColumns = false;
            this.dgvEstoque_fornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstoque_fornecedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODEFDataGridViewTextBoxColumn,
            this.cNPJEFDataGridViewTextBoxColumn,
            this.rAZAOFORNECEDOREFDataGridViewTextBoxColumn,
            this.cODESTOQUEEFDataGridViewTextBoxColumn,
            this.pRODUTOEFDataGridViewTextBoxColumn});
            this.dgvEstoque_fornecedor.DataMember = "ESTOQUE_FORNECEDOR";
            this.dgvEstoque_fornecedor.DataSource = this.dsEstoque_fornecedor;
            this.dgvEstoque_fornecedor.Location = new System.Drawing.Point(6, 94);
            this.dgvEstoque_fornecedor.Name = "dgvEstoque_fornecedor";
            this.dgvEstoque_fornecedor.RowHeadersWidth = 20;
            this.dgvEstoque_fornecedor.Size = new System.Drawing.Size(308, 196);
            this.dgvEstoque_fornecedor.TabIndex = 174;
            // 
            // cODEFDataGridViewTextBoxColumn
            // 
            this.cODEFDataGridViewTextBoxColumn.DataPropertyName = "COD_EF";
            this.cODEFDataGridViewTextBoxColumn.HeaderText = "COD_EF";
            this.cODEFDataGridViewTextBoxColumn.Name = "cODEFDataGridViewTextBoxColumn";
            this.cODEFDataGridViewTextBoxColumn.Visible = false;
            // 
            // cNPJEFDataGridViewTextBoxColumn
            // 
            this.cNPJEFDataGridViewTextBoxColumn.DataPropertyName = "CNPJ_EF";
            this.cNPJEFDataGridViewTextBoxColumn.HeaderText = "CNPJ";
            this.cNPJEFDataGridViewTextBoxColumn.Name = "cNPJEFDataGridViewTextBoxColumn";
            this.cNPJEFDataGridViewTextBoxColumn.Width = 120;
            // 
            // rAZAOFORNECEDOREFDataGridViewTextBoxColumn
            // 
            this.rAZAOFORNECEDOREFDataGridViewTextBoxColumn.DataPropertyName = "RAZAO_FORNECEDOR_EF";
            this.rAZAOFORNECEDOREFDataGridViewTextBoxColumn.HeaderText = "Fornecedor";
            this.rAZAOFORNECEDOREFDataGridViewTextBoxColumn.Name = "rAZAOFORNECEDOREFDataGridViewTextBoxColumn";
            this.rAZAOFORNECEDOREFDataGridViewTextBoxColumn.Width = 300;
            // 
            // cODESTOQUEEFDataGridViewTextBoxColumn
            // 
            this.cODESTOQUEEFDataGridViewTextBoxColumn.DataPropertyName = "COD_ESTOQUE_EF";
            this.cODESTOQUEEFDataGridViewTextBoxColumn.HeaderText = "COD_ESTOQUE_EF";
            this.cODESTOQUEEFDataGridViewTextBoxColumn.Name = "cODESTOQUEEFDataGridViewTextBoxColumn";
            this.cODESTOQUEEFDataGridViewTextBoxColumn.Visible = false;
            // 
            // pRODUTOEFDataGridViewTextBoxColumn
            // 
            this.pRODUTOEFDataGridViewTextBoxColumn.DataPropertyName = "PRODUTO_EF";
            this.pRODUTOEFDataGridViewTextBoxColumn.HeaderText = "PRODUTO_EF";
            this.pRODUTOEFDataGridViewTextBoxColumn.Name = "pRODUTOEFDataGridViewTextBoxColumn";
            this.pRODUTOEFDataGridViewTextBoxColumn.Visible = false;
            // 
            // dsEstoque_fornecedor
            // 
            this.dsEstoque_fornecedor.DataSetName = "dsEstoque_fornecedor";
            this.dsEstoque_fornecedor.Namespace = "http://www.tempuri.org/dsEstoque_fornecedor.xsd";
            this.dsEstoque_fornecedor.Tables.AddRange(new System.Data.DataTable[] {
            this.ESTOQUE_FORNECEDOR});
            // 
            // ESTOQUE_FORNECEDOR
            // 
            this.ESTOQUE_FORNECEDOR.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_EF,
            this.CNPJ_EF,
            this.RAZAO_FORNECEDOR_EF,
            this.COD_ESTOQUE_EF,
            this.PRODUTO_EF});
            this.ESTOQUE_FORNECEDOR.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_EF"}, true)});
            this.ESTOQUE_FORNECEDOR.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_EF};
            this.ESTOQUE_FORNECEDOR.TableName = "ESTOQUE_FORNECEDOR";
            // 
            // COD_EF
            // 
            this.COD_EF.AllowDBNull = false;
            this.COD_EF.ColumnName = "COD_EF";
            this.COD_EF.DataType = typeof(int);
            // 
            // CNPJ_EF
            // 
            this.CNPJ_EF.ColumnName = "CNPJ_EF";
            this.CNPJ_EF.MaxLength = 20;
            // 
            // RAZAO_FORNECEDOR_EF
            // 
            this.RAZAO_FORNECEDOR_EF.ColumnName = "RAZAO_FORNECEDOR_EF";
            this.RAZAO_FORNECEDOR_EF.MaxLength = 200;
            // 
            // COD_ESTOQUE_EF
            // 
            this.COD_ESTOQUE_EF.ColumnName = "COD_ESTOQUE_EF";
            this.COD_ESTOQUE_EF.DataType = typeof(int);
            // 
            // PRODUTO_EF
            // 
            this.PRODUTO_EF.ColumnName = "PRODUTO_EF";
            this.PRODUTO_EF.MaxLength = 200;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel9.Controls.Add(this.tabControl1);
            this.panel9.Location = new System.Drawing.Point(1018, 49);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(336, 322);
            this.panel9.TabIndex = 175;
            // 
            // datEstoque_fornecedor
            // 
            this.datEstoque_fornecedor.DeleteCommand = this.fbCommand36;
            this.datEstoque_fornecedor.InsertCommand = this.fbCommand34;
            this.datEstoque_fornecedor.SelectCommand = this.fbCommand33;
            this.datEstoque_fornecedor.UpdateCommand = this.fbCommand35;
            // 
            // fbCommand36
            // 
            this.fbCommand36.CommandTimeout = 30;
            // 
            // fbCommand34
            // 
            this.fbCommand34.CommandTimeout = 30;
            // 
            // fbCommand33
            // 
            this.fbCommand33.CommandText = "select * from estoque_fornecedor";
            this.fbCommand33.CommandTimeout = 30;
            this.fbCommand33.Connection = this.fbConnection1;
            // 
            // fbCommand35
            // 
            this.fbCommand35.CommandTimeout = 30;
            // 
            // cbEstoque_fornecedor
            // 
            this.cbEstoque_fornecedor.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbEstoque_fornecedor.DataAdapter = this.datEstoque_fornecedor;
            this.cbEstoque_fornecedor.QuotePrefix = "\"";
            this.cbEstoque_fornecedor.QuoteSuffix = "\"";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.label16);
            this.panel10.Controls.Add(this.label4);
            this.panel10.Controls.Add(this.button10);
            this.panel10.Controls.Add(this.tb_grupo);
            this.panel10.Controls.Add(this.textBox9);
            this.panel10.Controls.Add(this.label12);
            this.panel10.Controls.Add(this.label32);
            this.panel10.Controls.Add(this.tb_material);
            this.panel10.Controls.Add(this.textBox10);
            this.panel10.Controls.Add(this.button9);
            this.panel10.Controls.Add(this.label33);
            this.panel10.Controls.Add(this.label11);
            this.panel10.Controls.Add(this.button8);
            this.panel10.Controls.Add(this.tb_espessura);
            this.panel10.Controls.Add(this.tb_acabamento);
            this.panel10.Controls.Add(this.label10);
            this.panel10.Controls.Add(this.label34);
            this.panel10.Controls.Add(this.tb_dimensao);
            this.panel10.Controls.Add(this.button7);
            this.panel10.Controls.Add(this.tb_classificacao);
            this.panel10.Controls.Add(this.button4);
            this.panel10.Controls.Add(this.textBox1);
            this.panel10.Controls.Add(this.button6);
            this.panel10.Controls.Add(this.button5);
            this.panel10.Controls.Add(this.label8);
            this.panel10.Controls.Add(this.tb_marca);
            this.panel10.Controls.Add(this.label17);
            this.panel10.Controls.Add(this.tb_prazo_medio);
            this.panel10.Controls.Add(this.label15);
            this.panel10.Location = new System.Drawing.Point(1029, 455);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(546, 100);
            this.panel10.TabIndex = 176;
            this.panel10.Visible = false;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel11.Controls.Add(this.dgvNFs);
            this.panel11.Controls.Add(this.label43);
            this.panel11.Location = new System.Drawing.Point(1008, 383);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(346, 236);
            this.panel11.TabIndex = 177;
            // 
            // dgvNFs
            // 
            this.dgvNFs.AllowUserToAddRows = false;
            this.dgvNFs.AutoGenerateColumns = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNFs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvNFs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNFs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nFITEMDataGridViewTextBoxColumn,
            this.cODEANITEMDataGridViewTextBoxColumn,
            this.qTDEITEMDataGridViewTextBoxColumn,
            this.cFOPITEMDataGridViewTextBoxColumn,
            this.dESCRICAOITEMDataGridViewTextBoxColumn,
            this.uNIDADEITEMDataGridViewTextBoxColumn,
            this.pRECOUNITITEMDataGridViewTextBoxColumn,
            this.pRECOTOTALITEMDataGridViewTextBoxColumn,
            this.cODITEMDataGridViewTextBoxColumn});
            this.dgvNFs.DataMember = "ITENS_NOTA";
            this.dgvNFs.DataSource = this.dsItens_nota;
            this.dgvNFs.Location = new System.Drawing.Point(3, 37);
            this.dgvNFs.Name = "dgvNFs";
            this.dgvNFs.RowHeadersWidth = 15;
            this.dgvNFs.Size = new System.Drawing.Size(326, 192);
            this.dgvNFs.TabIndex = 157;
            // 
            // nFITEMDataGridViewTextBoxColumn
            // 
            this.nFITEMDataGridViewTextBoxColumn.DataPropertyName = "NF_ITEM";
            this.nFITEMDataGridViewTextBoxColumn.HeaderText = "NF";
            this.nFITEMDataGridViewTextBoxColumn.Name = "nFITEMDataGridViewTextBoxColumn";
            this.nFITEMDataGridViewTextBoxColumn.Width = 40;
            // 
            // cODEANITEMDataGridViewTextBoxColumn
            // 
            this.cODEANITEMDataGridViewTextBoxColumn.DataPropertyName = "COD_EAN_ITEM";
            this.cODEANITEMDataGridViewTextBoxColumn.HeaderText = "Lote";
            this.cODEANITEMDataGridViewTextBoxColumn.Name = "cODEANITEMDataGridViewTextBoxColumn";
            this.cODEANITEMDataGridViewTextBoxColumn.Width = 50;
            // 
            // qTDEITEMDataGridViewTextBoxColumn
            // 
            this.qTDEITEMDataGridViewTextBoxColumn.DataPropertyName = "QTDE_ITEM";
            this.qTDEITEMDataGridViewTextBoxColumn.HeaderText = "Qtde";
            this.qTDEITEMDataGridViewTextBoxColumn.Name = "qTDEITEMDataGridViewTextBoxColumn";
            this.qTDEITEMDataGridViewTextBoxColumn.Width = 40;
            // 
            // cFOPITEMDataGridViewTextBoxColumn
            // 
            this.cFOPITEMDataGridViewTextBoxColumn.DataPropertyName = "CFOP_ITEM";
            this.cFOPITEMDataGridViewTextBoxColumn.HeaderText = "CFOP";
            this.cFOPITEMDataGridViewTextBoxColumn.Name = "cFOPITEMDataGridViewTextBoxColumn";
            this.cFOPITEMDataGridViewTextBoxColumn.Width = 40;
            // 
            // dESCRICAOITEMDataGridViewTextBoxColumn
            // 
            this.dESCRICAOITEMDataGridViewTextBoxColumn.DataPropertyName = "DESCRICAO_ITEM";
            this.dESCRICAOITEMDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.dESCRICAOITEMDataGridViewTextBoxColumn.Name = "dESCRICAOITEMDataGridViewTextBoxColumn";
            // 
            // uNIDADEITEMDataGridViewTextBoxColumn
            // 
            this.uNIDADEITEMDataGridViewTextBoxColumn.DataPropertyName = "UNIDADE_ITEM";
            this.uNIDADEITEMDataGridViewTextBoxColumn.HeaderText = "Un";
            this.uNIDADEITEMDataGridViewTextBoxColumn.Name = "uNIDADEITEMDataGridViewTextBoxColumn";
            this.uNIDADEITEMDataGridViewTextBoxColumn.Width = 30;
            // 
            // pRECOUNITITEMDataGridViewTextBoxColumn
            // 
            this.pRECOUNITITEMDataGridViewTextBoxColumn.DataPropertyName = "PRECO_UNIT_ITEM";
            this.pRECOUNITITEMDataGridViewTextBoxColumn.HeaderText = "Vl Unit.";
            this.pRECOUNITITEMDataGridViewTextBoxColumn.Name = "pRECOUNITITEMDataGridViewTextBoxColumn";
            this.pRECOUNITITEMDataGridViewTextBoxColumn.Width = 60;
            // 
            // pRECOTOTALITEMDataGridViewTextBoxColumn
            // 
            this.pRECOTOTALITEMDataGridViewTextBoxColumn.DataPropertyName = "PRECO_TOTAL_ITEM";
            this.pRECOTOTALITEMDataGridViewTextBoxColumn.HeaderText = "Vl. Total";
            this.pRECOTOTALITEMDataGridViewTextBoxColumn.Name = "pRECOTOTALITEMDataGridViewTextBoxColumn";
            this.pRECOTOTALITEMDataGridViewTextBoxColumn.Width = 80;
            // 
            // cODITEMDataGridViewTextBoxColumn
            // 
            this.cODITEMDataGridViewTextBoxColumn.DataPropertyName = "COD_ITEM";
            this.cODITEMDataGridViewTextBoxColumn.HeaderText = "Item";
            this.cODITEMDataGridViewTextBoxColumn.Name = "cODITEMDataGridViewTextBoxColumn";
            // 
            // dsItens_nota
            // 
            this.dsItens_nota.DataSetName = "dsItens_nota";
            this.dsItens_nota.Namespace = "http://www.tempuri.org/dsItens_nota.xsd";
            this.dsItens_nota.Tables.AddRange(new System.Data.DataTable[] {
            this.ITENS_NOTA});
            // 
            // ITENS_NOTA
            // 
            this.ITENS_NOTA.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_ITENS_NOTA,
            this.DESCRICAO_ITEM,
            this.UNIDADE_ITEM,
            this.QTDE_ITEM,
            this.ST_ITEM,
            this.PRECO_UNIT_ITEM,
            this.PRECO_TOTAL_ITEM,
            this.IPI_ITEM,
            this.ICM_ITEM,
            this.NF_ITEM,
            this.VALOR_IPI_ITEM,
            this.PEDIDO_COMPRA_ITEM,
            this.MAE_ITEM,
            this.COD_ITEM,
            this.NCM_ITEM,
            this.CFOP_ITEM,
            this.VALOR_ICM_ITEM,
            this.VALOR_ISS_ITEM,
            this.PRESTACAO_SERVICO_ITEM,
            this.VALOR_BC_ITEM,
            this.VALOR_BC_ICMS_ST_ITEM,
            this.VALOR_ICMS_ST_ITEM,
            this.VALOR_FRETE_ITEM,
            this.VALOR_DESCONTO_ITEM,
            this.VALOR_SEGURO_ITEM,
            this.VALOR_OUTRAS_DESP_ITEM,
            this.IVA_ITEM,
            this.REDUCAO_ITEM,
            this.COFINS_ITEM,
            this.VALOR_COFINS_ITEM,
            this.PIS_ITEM,
            this.VALOR_PIS_ITEM,
            this.ORIGEM_ITEM,
            this.MOD_BC_ITEM,
            this.ISS_ITEM,
            this.MOD_BC_ST_ITEM,
            this.REDUCAO_ST_ITEM,
            this.ICMS_ST_ITEM,
            this.ALIQUOTA_CREDITO_ITEM,
            this.VALOR_CREDITO_ITEM,
            this.IPI_TRIB_ITEM,
            this.IPI_N_TRIB_ITEM,
            this.CST_IPI_TRIB_ITEM,
            this.CST_IPI_N_TRIB_ITEM,
            this.TIPO_PIS_ITEM,
            this.CST_PIS_ITEM,
            this.TIPO_COFINS_ITEM,
            this.CST_COFINS_ITEM,
            this.TIPO_SERVICO_ITEM,
            this.ITEM_PEDIDO_COMPRA_ITEM,
            this.BC_IPI_ITEM,
            this.BC_PIS_ITEM,
            this.BC_COFINS_ITEM,
            this.BC_ISS_ITEM,
            this.BC_COM_IPI_ITEM,
            this.ST_IMPRESSAO_ITEM,
            this.COD_EAN_ITEM,
            this.PORC_TRIB_ITEM,
            this.TOTAL_TRIB_ITEM,
            this.PRECO_MINIMO_ITEM,
            this.CUSTO_ITEM,
            this.CEST_ITEM,
            this.COD_SISTEMA_NF_ITEM,
            this.VBCSTRET_ITEM,
            this.PST_ITEM,
            this.VICMSSUBSTITUTO_ITEM,
            this.VICMSSTRET_ITEM});
            this.ITENS_NOTA.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_ITENS_NOTA"}, true)});
            this.ITENS_NOTA.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_ITENS_NOTA};
            this.ITENS_NOTA.TableName = "ITENS_NOTA";
            // 
            // COD_ITENS_NOTA
            // 
            this.COD_ITENS_NOTA.AllowDBNull = false;
            this.COD_ITENS_NOTA.ColumnName = "COD_ITENS_NOTA";
            this.COD_ITENS_NOTA.DataType = typeof(int);
            // 
            // DESCRICAO_ITEM
            // 
            this.DESCRICAO_ITEM.ColumnName = "DESCRICAO_ITEM";
            this.DESCRICAO_ITEM.MaxLength = 120;
            // 
            // UNIDADE_ITEM
            // 
            this.UNIDADE_ITEM.ColumnName = "UNIDADE_ITEM";
            this.UNIDADE_ITEM.MaxLength = 10;
            // 
            // QTDE_ITEM
            // 
            this.QTDE_ITEM.ColumnName = "QTDE_ITEM";
            this.QTDE_ITEM.DataType = typeof(double);
            // 
            // ST_ITEM
            // 
            this.ST_ITEM.ColumnName = "ST_ITEM";
            this.ST_ITEM.MaxLength = 40;
            // 
            // PRECO_UNIT_ITEM
            // 
            this.PRECO_UNIT_ITEM.ColumnName = "PRECO_UNIT_ITEM";
            this.PRECO_UNIT_ITEM.DataType = typeof(double);
            // 
            // PRECO_TOTAL_ITEM
            // 
            this.PRECO_TOTAL_ITEM.ColumnName = "PRECO_TOTAL_ITEM";
            this.PRECO_TOTAL_ITEM.DataType = typeof(double);
            // 
            // IPI_ITEM
            // 
            this.IPI_ITEM.ColumnName = "IPI_ITEM";
            this.IPI_ITEM.DataType = typeof(double);
            // 
            // ICM_ITEM
            // 
            this.ICM_ITEM.ColumnName = "ICM_ITEM";
            this.ICM_ITEM.DataType = typeof(double);
            // 
            // NF_ITEM
            // 
            this.NF_ITEM.ColumnName = "NF_ITEM";
            this.NF_ITEM.DataType = typeof(int);
            // 
            // VALOR_IPI_ITEM
            // 
            this.VALOR_IPI_ITEM.ColumnName = "VALOR_IPI_ITEM";
            this.VALOR_IPI_ITEM.DataType = typeof(double);
            // 
            // PEDIDO_COMPRA_ITEM
            // 
            this.PEDIDO_COMPRA_ITEM.ColumnName = "PEDIDO_COMPRA_ITEM";
            this.PEDIDO_COMPRA_ITEM.MaxLength = 20;
            // 
            // MAE_ITEM
            // 
            this.MAE_ITEM.ColumnName = "MAE_ITEM";
            this.MAE_ITEM.DataType = typeof(int);
            // 
            // COD_ITEM
            // 
            this.COD_ITEM.ColumnName = "COD_ITEM";
            this.COD_ITEM.MaxLength = 30;
            // 
            // NCM_ITEM
            // 
            this.NCM_ITEM.ColumnName = "NCM_ITEM";
            this.NCM_ITEM.MaxLength = 20;
            // 
            // CFOP_ITEM
            // 
            this.CFOP_ITEM.ColumnName = "CFOP_ITEM";
            this.CFOP_ITEM.MaxLength = 10;
            // 
            // VALOR_ICM_ITEM
            // 
            this.VALOR_ICM_ITEM.ColumnName = "VALOR_ICM_ITEM";
            this.VALOR_ICM_ITEM.DataType = typeof(double);
            // 
            // VALOR_ISS_ITEM
            // 
            this.VALOR_ISS_ITEM.ColumnName = "VALOR_ISS_ITEM";
            this.VALOR_ISS_ITEM.MaxLength = 20;
            // 
            // PRESTACAO_SERVICO_ITEM
            // 
            this.PRESTACAO_SERVICO_ITEM.ColumnName = "PRESTACAO_SERVICO_ITEM";
            this.PRESTACAO_SERVICO_ITEM.DataType = typeof(int);
            // 
            // VALOR_BC_ITEM
            // 
            this.VALOR_BC_ITEM.ColumnName = "VALOR_BC_ITEM";
            this.VALOR_BC_ITEM.DataType = typeof(double);
            // 
            // VALOR_BC_ICMS_ST_ITEM
            // 
            this.VALOR_BC_ICMS_ST_ITEM.ColumnName = "VALOR_BC_ICMS_ST_ITEM";
            this.VALOR_BC_ICMS_ST_ITEM.DataType = typeof(double);
            // 
            // VALOR_ICMS_ST_ITEM
            // 
            this.VALOR_ICMS_ST_ITEM.ColumnName = "VALOR_ICMS_ST_ITEM";
            this.VALOR_ICMS_ST_ITEM.DataType = typeof(double);
            // 
            // VALOR_FRETE_ITEM
            // 
            this.VALOR_FRETE_ITEM.ColumnName = "VALOR_FRETE_ITEM";
            this.VALOR_FRETE_ITEM.DataType = typeof(double);
            // 
            // VALOR_DESCONTO_ITEM
            // 
            this.VALOR_DESCONTO_ITEM.ColumnName = "VALOR_DESCONTO_ITEM";
            this.VALOR_DESCONTO_ITEM.DataType = typeof(double);
            // 
            // VALOR_SEGURO_ITEM
            // 
            this.VALOR_SEGURO_ITEM.ColumnName = "VALOR_SEGURO_ITEM";
            this.VALOR_SEGURO_ITEM.DataType = typeof(double);
            // 
            // VALOR_OUTRAS_DESP_ITEM
            // 
            this.VALOR_OUTRAS_DESP_ITEM.ColumnName = "VALOR_OUTRAS_DESP_ITEM";
            this.VALOR_OUTRAS_DESP_ITEM.DataType = typeof(double);
            // 
            // IVA_ITEM
            // 
            this.IVA_ITEM.ColumnName = "IVA_ITEM";
            this.IVA_ITEM.DataType = typeof(double);
            // 
            // REDUCAO_ITEM
            // 
            this.REDUCAO_ITEM.ColumnName = "REDUCAO_ITEM";
            this.REDUCAO_ITEM.DataType = typeof(double);
            // 
            // COFINS_ITEM
            // 
            this.COFINS_ITEM.ColumnName = "COFINS_ITEM";
            this.COFINS_ITEM.DataType = typeof(double);
            // 
            // VALOR_COFINS_ITEM
            // 
            this.VALOR_COFINS_ITEM.ColumnName = "VALOR_COFINS_ITEM";
            this.VALOR_COFINS_ITEM.DataType = typeof(double);
            // 
            // PIS_ITEM
            // 
            this.PIS_ITEM.ColumnName = "PIS_ITEM";
            this.PIS_ITEM.DataType = typeof(double);
            // 
            // VALOR_PIS_ITEM
            // 
            this.VALOR_PIS_ITEM.ColumnName = "VALOR_PIS_ITEM";
            this.VALOR_PIS_ITEM.DataType = typeof(double);
            // 
            // ORIGEM_ITEM
            // 
            this.ORIGEM_ITEM.ColumnName = "ORIGEM_ITEM";
            this.ORIGEM_ITEM.MaxLength = 1;
            // 
            // MOD_BC_ITEM
            // 
            this.MOD_BC_ITEM.ColumnName = "MOD_BC_ITEM";
            this.MOD_BC_ITEM.MaxLength = 100;
            // 
            // ISS_ITEM
            // 
            this.ISS_ITEM.ColumnName = "ISS_ITEM";
            this.ISS_ITEM.DataType = typeof(double);
            // 
            // MOD_BC_ST_ITEM
            // 
            this.MOD_BC_ST_ITEM.ColumnName = "MOD_BC_ST_ITEM";
            this.MOD_BC_ST_ITEM.MaxLength = 100;
            // 
            // REDUCAO_ST_ITEM
            // 
            this.REDUCAO_ST_ITEM.ColumnName = "REDUCAO_ST_ITEM";
            this.REDUCAO_ST_ITEM.DataType = typeof(double);
            // 
            // ICMS_ST_ITEM
            // 
            this.ICMS_ST_ITEM.ColumnName = "ICMS_ST_ITEM";
            this.ICMS_ST_ITEM.DataType = typeof(double);
            // 
            // ALIQUOTA_CREDITO_ITEM
            // 
            this.ALIQUOTA_CREDITO_ITEM.ColumnName = "ALIQUOTA_CREDITO_ITEM";
            this.ALIQUOTA_CREDITO_ITEM.DataType = typeof(double);
            // 
            // VALOR_CREDITO_ITEM
            // 
            this.VALOR_CREDITO_ITEM.ColumnName = "VALOR_CREDITO_ITEM";
            this.VALOR_CREDITO_ITEM.DataType = typeof(double);
            // 
            // IPI_TRIB_ITEM
            // 
            this.IPI_TRIB_ITEM.ColumnName = "IPI_TRIB_ITEM";
            this.IPI_TRIB_ITEM.DataType = typeof(int);
            // 
            // IPI_N_TRIB_ITEM
            // 
            this.IPI_N_TRIB_ITEM.ColumnName = "IPI_N_TRIB_ITEM";
            this.IPI_N_TRIB_ITEM.DataType = typeof(int);
            // 
            // CST_IPI_TRIB_ITEM
            // 
            this.CST_IPI_TRIB_ITEM.ColumnName = "CST_IPI_TRIB_ITEM";
            this.CST_IPI_TRIB_ITEM.MaxLength = 100;
            // 
            // CST_IPI_N_TRIB_ITEM
            // 
            this.CST_IPI_N_TRIB_ITEM.ColumnName = "CST_IPI_N_TRIB_ITEM";
            this.CST_IPI_N_TRIB_ITEM.MaxLength = 100;
            // 
            // TIPO_PIS_ITEM
            // 
            this.TIPO_PIS_ITEM.ColumnName = "TIPO_PIS_ITEM";
            this.TIPO_PIS_ITEM.MaxLength = 100;
            // 
            // CST_PIS_ITEM
            // 
            this.CST_PIS_ITEM.ColumnName = "CST_PIS_ITEM";
            this.CST_PIS_ITEM.MaxLength = 200;
            // 
            // TIPO_COFINS_ITEM
            // 
            this.TIPO_COFINS_ITEM.ColumnName = "TIPO_COFINS_ITEM";
            this.TIPO_COFINS_ITEM.MaxLength = 100;
            // 
            // CST_COFINS_ITEM
            // 
            this.CST_COFINS_ITEM.ColumnName = "CST_COFINS_ITEM";
            this.CST_COFINS_ITEM.MaxLength = 200;
            // 
            // TIPO_SERVICO_ITEM
            // 
            this.TIPO_SERVICO_ITEM.ColumnName = "TIPO_SERVICO_ITEM";
            this.TIPO_SERVICO_ITEM.MaxLength = 100;
            // 
            // ITEM_PEDIDO_COMPRA_ITEM
            // 
            this.ITEM_PEDIDO_COMPRA_ITEM.ColumnName = "ITEM_PEDIDO_COMPRA_ITEM";
            this.ITEM_PEDIDO_COMPRA_ITEM.MaxLength = 100;
            // 
            // BC_IPI_ITEM
            // 
            this.BC_IPI_ITEM.ColumnName = "BC_IPI_ITEM";
            this.BC_IPI_ITEM.DataType = typeof(double);
            // 
            // BC_PIS_ITEM
            // 
            this.BC_PIS_ITEM.ColumnName = "BC_PIS_ITEM";
            this.BC_PIS_ITEM.DataType = typeof(double);
            // 
            // BC_COFINS_ITEM
            // 
            this.BC_COFINS_ITEM.ColumnName = "BC_COFINS_ITEM";
            this.BC_COFINS_ITEM.DataType = typeof(double);
            // 
            // BC_ISS_ITEM
            // 
            this.BC_ISS_ITEM.ColumnName = "BC_ISS_ITEM";
            this.BC_ISS_ITEM.DataType = typeof(double);
            // 
            // BC_COM_IPI_ITEM
            // 
            this.BC_COM_IPI_ITEM.ColumnName = "BC_COM_IPI_ITEM";
            this.BC_COM_IPI_ITEM.DataType = typeof(int);
            // 
            // ST_IMPRESSAO_ITEM
            // 
            this.ST_IMPRESSAO_ITEM.ColumnName = "ST_IMPRESSAO_ITEM";
            this.ST_IMPRESSAO_ITEM.MaxLength = 4;
            // 
            // COD_EAN_ITEM
            // 
            this.COD_EAN_ITEM.ColumnName = "COD_EAN_ITEM";
            this.COD_EAN_ITEM.MaxLength = 200;
            // 
            // PORC_TRIB_ITEM
            // 
            this.PORC_TRIB_ITEM.ColumnName = "PORC_TRIB_ITEM";
            this.PORC_TRIB_ITEM.DataType = typeof(double);
            // 
            // TOTAL_TRIB_ITEM
            // 
            this.TOTAL_TRIB_ITEM.ColumnName = "TOTAL_TRIB_ITEM";
            this.TOTAL_TRIB_ITEM.DataType = typeof(double);
            // 
            // PRECO_MINIMO_ITEM
            // 
            this.PRECO_MINIMO_ITEM.ColumnName = "PRECO_MINIMO_ITEM";
            this.PRECO_MINIMO_ITEM.DataType = typeof(double);
            // 
            // CUSTO_ITEM
            // 
            this.CUSTO_ITEM.ColumnName = "CUSTO_ITEM";
            this.CUSTO_ITEM.DataType = typeof(double);
            // 
            // CEST_ITEM
            // 
            this.CEST_ITEM.ColumnName = "CEST_ITEM";
            this.CEST_ITEM.MaxLength = 20;
            // 
            // COD_SISTEMA_NF_ITEM
            // 
            this.COD_SISTEMA_NF_ITEM.ColumnName = "COD_SISTEMA_NF_ITEM";
            this.COD_SISTEMA_NF_ITEM.DataType = typeof(int);
            // 
            // VBCSTRET_ITEM
            // 
            this.VBCSTRET_ITEM.ColumnName = "VBCSTRET_ITEM";
            this.VBCSTRET_ITEM.DataType = typeof(double);
            // 
            // PST_ITEM
            // 
            this.PST_ITEM.ColumnName = "PST_ITEM";
            this.PST_ITEM.DataType = typeof(double);
            // 
            // VICMSSUBSTITUTO_ITEM
            // 
            this.VICMSSUBSTITUTO_ITEM.ColumnName = "VICMSSUBSTITUTO_ITEM";
            this.VICMSSUBSTITUTO_ITEM.DataType = typeof(double);
            // 
            // VICMSSTRET_ITEM
            // 
            this.VICMSSTRET_ITEM.ColumnName = "VICMSSTRET_ITEM";
            this.VICMSSTRET_ITEM.DataType = typeof(double);
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.Location = new System.Drawing.Point(5, 9);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(112, 25);
            this.label43.TabIndex = 92;
            this.label43.Text = "Saídas NF";
            this.label43.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // datItens_nota
            // 
            this.datItens_nota.DeleteCommand = this.fbCommand40;
            this.datItens_nota.InsertCommand = this.fbCommand38;
            this.datItens_nota.SelectCommand = this.fbCommand37;
            this.datItens_nota.UpdateCommand = this.fbCommand39;
            // 
            // fbCommand40
            // 
            this.fbCommand40.CommandTimeout = 30;
            // 
            // fbCommand38
            // 
            this.fbCommand38.CommandTimeout = 30;
            // 
            // fbCommand37
            // 
            this.fbCommand37.CommandText = "select * from itens_nota";
            this.fbCommand37.CommandTimeout = 30;
            this.fbCommand37.Connection = this.fbConnection1;
            // 
            // fbCommand39
            // 
            this.fbCommand39.CommandTimeout = 30;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(330, 316);
            this.tabControl1.TabIndex = 175;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvItens_produto);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(322, 290);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "MP de";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.dgvEstoque_fornecedor);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(322, 290);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Fornecedores";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvItens_produto
            // 
            this.dgvItens_produto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens_produto.Location = new System.Drawing.Point(6, 24);
            this.dgvItens_produto.Name = "dgvItens_produto";
            this.dgvItens_produto.Size = new System.Drawing.Size(306, 257);
            this.dgvItens_produto.TabIndex = 0;
            // 
            // form_estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 641);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxControle);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bt_imprimir_cod);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.apaga_registro);
            this.Controls.Add(this.salva_registro);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.novo_registro);
            this.Controls.Add(this.tb_cod);
            this.Controls.Add(this.label1);
            this.Name = "form_estoque";
            this.Text = "Estoque";
            this.Load += new System.EventHandler(this.form_estoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ESTOQUE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsItens_nf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITENS_NF_ENTRADA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSaida_estoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ESTOQUE_SAIDA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsItens_ped)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITENS_PEDIDO_COMPRA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens_ped)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequisicoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsItens_requisicao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITENS_REQUISICAO)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens_nota_ent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsItens_nota_ent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITENS_NOTA_ENT)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OP)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LOTES)).EndInit();
            this.gbxControle.ResumeLayout(false);
            this.gbxControle.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque_fornecedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEstoque_fornecedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ESTOQUE_FORNECEDOR)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNFs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsItens_nota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITENS_NOTA)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens_produto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button apaga_registro;
        private System.Windows.Forms.Button salva_registro;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button novo_registro;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_cod;
        private System.Windows.Forms.TextBox tb_item;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_grupo;
        private System.Windows.Forms.TextBox tb_estoque_atual;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_estoque_minimo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_localizacao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_dimensao;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_espessura;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_material;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_prazo_medio;
        private System.Windows.Forms.Label label15;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datEstoque;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbEstoque;
        private System.Windows.Forms.TextBox tb_marca;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tb_obs;
        private System.Windows.Forms.Label label18;
        private System.Data.DataSet dsEstoque;
        private System.Data.DataTable ESTOQUE;
        private System.Data.DataColumn COD_ESTOQUE;
        private System.Data.DataColumn ITEM_ESTOQUE;
        private System.Data.DataColumn DESCRICAO_ESTOQUE;
        private System.Data.DataColumn GRUPO_ESTOQUE;
        private System.Data.DataColumn CLIENTE_ESTOQUE;
        private System.Data.DataColumn MATERIAL_ESTOQUE;
        private System.Data.DataColumn DIMENSAO_ESTOQUE;
        private System.Data.DataColumn PRAZO_MEDIO_ESTOQUE;
        private System.Data.DataColumn LOCALIZACAO_ESTOQUE;
        private System.Data.DataColumn ESPESSURA_ESTOQUE;
        private System.Data.DataColumn ESTOQUE_MINIMO_ESTOQUE;
        private System.Data.DataColumn ESTOQUE_ATUAL_ESTOQUE;
        private System.Data.DataColumn CHAPA_ESTOQUE;
        private System.Data.DataColumn COD_BARRAS_ITEM_FABRICANTE;
        private System.Data.DataColumn MARCA_ESTOQUE;
        private System.Data.DataColumn OBSERVACOES_ESTOQUE;
        private System.Windows.Forms.Button bt_imprimir_cod;
        private System.Windows.Forms.Label label19;
        private System.Data.DataColumn dataColumn1;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datItens_nf;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand8;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand6;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand5;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand7;
        private System.Data.DataSet dsItens_nf;
        private System.Data.DataTable ITENS_NF_ENTRADA;
        private System.Data.DataColumn COD_CONTROLE_ITENS_NF_ENT;
        private System.Data.DataColumn COD_ITENS_NF_ENT;
        private System.Data.DataColumn ITEM_ITENS_NF_ENT;
        private System.Data.DataColumn QTDE_ITENS_NF_ENT;
        private System.Data.DataColumn VALOR_ITENS_NF_ENT;
        private System.Data.DataColumn N_NOTA_ITENS_NF_ENT;
        private System.Data.DataColumn FORN_ITENS_NF_ENT;
        private System.Data.DataColumn DATA_ENT_ITENS_NF_ENT;
        private System.Data.DataColumn PEDIDO_COMPRA_ITENS_NF_ENT;
        private System.Data.DataColumn COD_NOTA_ITENS_NF_ENT;
        private System.Windows.Forms.Label label21;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datSaida_estoque;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand12;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand10;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand9;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand11;
        private System.Data.DataSet dsSaida_estoque;
        private System.Data.DataTable ESTOQUE_SAIDA;
        private System.Data.DataColumn COD_ESTOQUE_SAIDA;
        private System.Data.DataColumn ITEM_ESTOQUE_SAIDA;
        private System.Data.DataColumn COD_ITEM_ESTOQUE_SAIDA;
        private System.Data.DataColumn QTDE_ESTOQUE_SAIDA;
        private System.Data.DataColumn CRACHA_ESTOQUE_SAIDA;
        private System.Data.DataColumn OP_ESTOQUE_SAIDA;
        private System.Data.DataColumn DATA_ESTOQUE_SAIDA;
        private System.Windows.Forms.DataGridView dataGridView3;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datItens_ped;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand16;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand14;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand13;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand15;
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
        private System.Data.DataColumn CHEGOU_ITEM_PED;
        private System.Data.DataColumn COD_NF_ENTRADA_ITEM_PED;
        private System.Data.DataColumn AUTORIZANTE_ITEM_PED;
        private System.Data.DataColumn DATA_AUTORIZACAO_ITEM_PED;
        private System.Data.DataColumn HORA_AUTORIZACAO_ITEM_PED;
        private System.Data.DataColumn DATA_CHEGADA_ITEM_PED;
        private System.Windows.Forms.DataGridView dgvItens_ped;
        private System.Data.DataColumn dataColumn2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_tipo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dgvRequisicoes;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label25;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Data.DataColumn dataColumn7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView dgvItens_nota_ent;
        private System.Windows.Forms.Label label27;
        private System.Data.DataSet dsItens_nota_ent;
        private System.Data.DataTable ITENS_NOTA_ENT;
        private System.Data.DataColumn COD_ITENS_NOTA_ENT;
        private System.Data.DataColumn DESCRICAO_ITEM_ENT;
        private System.Data.DataColumn UNIDADE_ITEM_ENT;
        private System.Data.DataColumn QTDE_ITEM_ENT;
        private System.Data.DataColumn ST_ITEM_ENT;
        private System.Data.DataColumn PRECO_UNIT_ITEM_ENT;
        private System.Data.DataColumn PRECO_TOTAL_ITEM_ENT;
        private System.Data.DataColumn IPI_ITEM_ENT;
        private System.Data.DataColumn ICM_ITEM_ENT;
        private System.Data.DataColumn NF_ITEM_ENT;
        private System.Data.DataColumn VALOR_IPI_ITEM_ENT;
        private System.Data.DataColumn PEDIDO_COMPRA_ITEM_ENT;
        private System.Data.DataColumn MAE_ITEM_ENT;
        private System.Data.DataColumn COD_ITEM_ENT;
        private System.Data.DataColumn CFOP_ITEM_ENT;
        private System.Data.DataColumn VALOR_ICM_ITEM_ENT;
        private System.Data.DataColumn VALOR_ISS_ITEM_ENT;
        private System.Data.DataColumn PRESTACAO_SERVICO_ITEM_ENT;
        private System.Data.DataColumn VALOR_BC_ITEM_ENT;
        private System.Data.DataColumn COD_COMISSIONARIO_ITEM_ENT;
        private System.Data.DataColumn VALOR_UNIT_COMISSAO_ITEM_ENT;
        private System.Data.DataColumn VALOR_TOTAL_COMISSAO_ITEM_ENT;
        private System.Data.DataColumn DATA_INSERCAO_ITEM_ENT_NOTA;
        private System.Data.DataColumn CNPJ_CLIENTE_ITEM_ENT;
        private System.Data.DataColumn STATUS_ATUAL_NFE_ENT;
        private System.Data.DataColumn PORC_COMISSAO_ITEM_ENT;
        private System.Data.DataColumn N_LINHA_PED_ITEM_ENT;
        private System.Data.DataColumn VALOR_BC_ICMS_ST_ITEM_ENT;
        private System.Data.DataColumn VALOR_ICMS_ST_ITEM_ENT;
        private System.Data.DataColumn VALOR_FRETE_ITEM_ENT;
        private System.Data.DataColumn VALOR_DESCONTO_ITEM_ENT;
        private System.Data.DataColumn VALOR_SEGURO_ITEM_ENT;
        private System.Data.DataColumn VALOR_OUTRAS_DESP_ITEM_ENT;
        private System.Data.DataColumn IVA_ITEM_ENT;
        private System.Data.DataColumn REDUCAO_ITEM_ENT;
        private System.Data.DataColumn COFINS_ITEM_ENT;
        private System.Data.DataColumn VALOR_COFINS_ITEM_ENT;
        private System.Data.DataColumn PIS_ITEM_ENT;
        private System.Data.DataColumn VALOR_PIS_ITEM_ENT;
        private System.Data.DataColumn ORIGEM_ITEM_ENT;
        private System.Data.DataColumn MOD_BC_ITEM_ENT;
        private System.Data.DataColumn ISS_ITEM_ENT;
        private System.Data.DataColumn MOD_BC_ST_ITEM_ENT;
        private System.Data.DataColumn REDUCAO_ST_ITEM_ENT;
        private System.Data.DataColumn ICMS_ST_ITEM_ENT;
        private System.Data.DataColumn ALIQUOTA_CREDITO_ITEM_ENT;
        private System.Data.DataColumn VALOR_CREDITO_ITEM_ENT;
        private System.Data.DataColumn IPI_TRIB_ITEM_ENT;
        private System.Data.DataColumn IPI_N_TRIB_ITEM_ENT;
        private System.Data.DataColumn CST_IPI_TRIB_ITEM_ENT;
        private System.Data.DataColumn CST_IPI_N_TRIB_ITEM_ENT;
        private System.Data.DataColumn TIPO_PIS_ITEM_ENT;
        private System.Data.DataColumn CST_PIS_ITEM_ENT;
        private System.Data.DataColumn TIPO_COFINS_ITEM_ENT;
        private System.Data.DataColumn CST_COFINS_ITEM_ENT;
        private System.Data.DataColumn TIPO_SERVICO_ITEM_ENT;
        private System.Data.DataColumn ITEM_PEDIDO_COMPRA_ITEM_ENT;
        private System.Data.DataColumn BC_IPI_ITEM_ENT;
        private System.Data.DataColumn BC_PIS_ITEM_ENT;
        private System.Data.DataColumn BC_COFINS_ITEM_ENT;
        private System.Data.DataColumn BC_ISS_ITEM_ENT;
        private System.Data.DataColumn BC_COM_IPI_ITEM_ENT;
        private System.Data.DataColumn ST_IMPRESSAO_ITEM_ENT;
        private System.Data.DataColumn ROTA_ITEM_ENT;
        private System.Data.DataColumn DI_ITEM_ENT;
        private System.Data.DataColumn DATA_DI_ITEM_ENT;
        private System.Data.DataColumn LOCAL_DES_ITEM_ENT;
        private System.Data.DataColumn UF_DES_ITEM_ENT;
        private System.Data.DataColumn DATA_DES_ITEM_ENT;
        private System.Data.DataColumn COD_EXP_ITEM_ENT;
        private System.Data.DataColumn COD_ITEM_REQ_ITEM_ENT;
        private System.Data.DataColumn COD_ITEM_PED_ITEM_ENT;
        private System.Data.DataColumn COD_ITEM_EST_ITEM_ENT;
        private System.Data.DataColumn COD_SISTEMA_NF_ITEM_ENT;
        private System.Data.DataColumn NCM_ITEM_ENT;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datItens_nota_ent;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand20;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand18;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand17;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand19;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand24;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand22;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand21;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand23;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEQUISITANTEITEMREQDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODREQITEMREQDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPITEMREQDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qTDEITEMREQDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sETORITEMREQDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAREQUISICAOITEMREQDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sITUACAOATUALITEMREQDataGridViewTextBoxColumn;
        private System.Data.DataSet dsItens_requisicao;
        private System.Data.DataTable ITENS_REQUISICAO;
        private System.Data.DataColumn COD_ITEM_REQ;
        private System.Data.DataColumn COD_REQ_ITEM_REQ;
        private System.Data.DataColumn OP_ITEM_REQ;
        private System.Data.DataColumn QTDE_ITEM_REQ;
        private System.Data.DataColumn UNIDADE_ITEM_REQ;
        private System.Data.DataColumn COD_ESTOQUE_ITEM_REQ;
        private System.Data.DataColumn DESCRICAO_ITEM_REQ;
        private System.Data.DataColumn DATA_LIMITE_ITEM_REQ;
        private System.Data.DataColumn URGENTE_ITEM_REQ;
        private System.Data.DataColumn REQUISITANTE_ITEM_REQ;
        private System.Data.DataColumn SETOR_ITEM_REQ;
        private System.Data.DataColumn DATA_REQUISICAO_ITEM_REQ;
        private System.Data.DataColumn SITUACAO_ATUAL_ITEM_REQ;
        private System.Data.DataColumn AUTORIZADO_POR_ITEM_REQ;
        private System.Data.DataColumn CLIENTE_ITEM_REQ;
        private System.Data.DataColumn FORNECEDOR_ITEM_REQ;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datItens_requisicao;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand28;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand26;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand25;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand27;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbSaida_estoque;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbItens_nota_ent;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox tb_cliente;
        private System.Windows.Forms.TextBox tb_cnpj_cliente;
        private System.Windows.Forms.Button button2;
        private System.Data.DataColumn dataColumn8;
        private System.Data.DataColumn dataColumn9;
        private System.Data.DataColumn dataColumn10;
        private System.Data.DataColumn dataColumn11;
        private System.Data.DataColumn dataColumn12;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label30;
        private System.Data.DataColumn dataColumn13;
        private System.Data.DataColumn dataColumn14;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Data.DataColumn dataColumn15;
        private System.Data.DataColumn dataColumn16;
        private System.Data.DataColumn dataColumn17;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox tb_comprimento;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox tb_acabamento;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox tb_classificacao;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_valor_unit;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvOp;
        private System.Windows.Forms.Label label3;
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
        private System.Data.DataColumn LOTE;
        private System.Data.DataColumn ESPESSURA_OP;
        private System.Data.DataColumn OBSERVACOES_OP;
        private System.Data.DataColumn REVISAO_OP;
        private System.Data.DataColumn DESCRICAO_PECA_OP;
        private System.Data.DataColumn MARCA_OP;
        private System.Data.DataColumn UNIDADE_OP;
        private System.Data.DataColumn ICMS_OP;
        private System.Data.DataColumn IPI_OP;
        private System.Data.DataColumn SIT_OP;
        private System.Data.DataColumn UNID_OP;
        private System.Data.DataColumn PRECO_UNIT;
        private System.Data.DataColumn OP_MAE;
        private System.Data.DataColumn CLIENTE_OP;
        private System.Data.DataColumn SIT_ATUAL_OP;
        private System.Data.DataColumn PORC_A_MAIS_OP;
        private System.Data.DataColumn NOME_PECA_OP;
        private System.Data.DataColumn NCM_OP;
        private System.Data.DataColumn QTDE_FATURADA_OP;
        private System.Data.DataColumn NFS_FATURADAS_OP;
        private System.Data.DataColumn N_OPERACOES_OP;
        private System.Data.DataColumn DATA_ULT_ALTERACAO_OP;
        private System.Data.DataColumn HORA_ULT_ALTERACAO_OP;
        private System.Data.DataColumn COD_COMISSIONARIO_OP;
        private System.Data.DataColumn NOME_COMISSIONARIO_OP;
        private System.Data.DataColumn VALOR_COMISSAO_OP;
        private System.Data.DataColumn PROJETO_OP;
        private System.Data.DataColumn ITEM_OP;
        private System.Data.DataColumn PORC_COMISSAO_OP;
        private System.Data.DataColumn PREVISAO_OP;
        private System.Data.DataColumn COLOCADO_EM_ESTOQUE_OP;
        private System.Data.DataColumn DATA_EMISSAO_OP;
        private System.Data.DataColumn OPERADOR_CRIADOR_OP;
        private System.Data.DataColumn PORC_SUCATA_OP;
        private System.Data.DataColumn FUNCAO_OP;
        private System.Data.DataColumn FERRAMENTA_OP;
        private System.Data.DataColumn FINALIZADO_OP;
        private System.Data.DataColumn POSICAO_ATUAL_OP;
        private System.Data.DataColumn TRAT_TERMICO_OP;
        private System.Data.DataColumn MATERIAL_FORN_OP;
        private System.Data.DataColumn NF_MATERIAL_OP;
        private System.Data.DataColumn DUREZA_SOLIC_OP;
        private System.Data.DataColumn DUREZA_ENC_OP;
        private System.Data.DataColumn NF_SAIDA_OP;
        private System.Data.DataColumn DATA_NF_SAIDA;
        private System.Data.DataColumn PROCESSO_OP;
        private System.Data.DataColumn CODIGO_OP;
        private System.Data.DataColumn DATA_ENTRADA_OP;
        private System.Data.DataColumn COD_MATERIAL_OP;
        private System.Data.DataColumn QTDE_MATERIAL_OP;
        private System.Data.DataColumn MATERIAL_RETIRADO_OP;
        private System.Data.DataColumn QTDE_EST_POR_MATERIAL_OP;
        private System.Data.DataColumn COD_ACAB_SUP_OP;
        private System.Data.DataColumn DESCRICAO_ACAB_SUP_OP;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datOp;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand32;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand30;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand29;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand31;
        private System.Data.DataColumn dataColumn18;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPESTOQUESAIDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODOPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn POSICAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn qTDEMATERIALOPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMEPECAOPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn mATERIALRETIRADOOPDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label36;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datLotes;
        private System.Data.DataSet dsLotes;
        private System.Data.DataTable LOTES;
        private System.Data.DataColumn COD_LOTE;
        private System.Data.DataColumn SALDO;
        private System.Data.DataColumn dataColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODLOTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sALDODataGridViewTextBoxColumn;
        private System.Data.DataColumn dataColumn20;
        private System.Data.DataColumn dataColumn21;
        private System.Windows.Forms.GroupBox gbxControle;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox txtPlanoControle;
        private System.Windows.Forms.TextBox txtCodControle;
        private System.Data.DataColumn dataColumn22;
        private System.Data.DataColumn dataColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODESTOQUESAIDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODITEMESTOQUESAIDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTEMESTOQUESAIDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAESTOQUESAIDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qTDEESTOQUESAIDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRACHAESTOQUESAIDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn POS;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOTE_ESTOQUE_SAIDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PALETE_ESTOQUE_SAIDA;
        private System.Data.DataColumn dataColumn24;
        private System.Data.DataColumn dataColumn25;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox tb_cnpj_forn;
        private System.Windows.Forms.Button bt_localizar_forn;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TextBox tb_nome_forn;
        private System.Windows.Forms.DataGridView dgvEstoque_fornecedor;
        private System.Windows.Forms.Panel panel9;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datEstoque_fornecedor;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand36;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand34;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand33;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand35;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODEFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPJEFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAZAOFORNECEDOREFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODESTOQUEEFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODUTOEFDataGridViewTextBoxColumn;
        private System.Data.DataSet dsEstoque_fornecedor;
        private System.Data.DataTable ESTOQUE_FORNECEDOR;
        private System.Data.DataColumn COD_EF;
        private System.Data.DataColumn CNPJ_EF;
        private System.Data.DataColumn RAZAO_FORNECEDOR_EF;
        private System.Data.DataColumn COD_ESTOQUE_EF;
        private System.Data.DataColumn PRODUTO_EF;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbEstoque_fornecedor;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.DataGridView dgvNFs;
        private System.Data.DataSet dsItens_nota;
        private System.Data.DataTable ITENS_NOTA;
        private System.Data.DataColumn COD_ITENS_NOTA;
        private System.Data.DataColumn DESCRICAO_ITEM;
        private System.Data.DataColumn UNIDADE_ITEM;
        private System.Data.DataColumn QTDE_ITEM;
        private System.Data.DataColumn ST_ITEM;
        private System.Data.DataColumn PRECO_UNIT_ITEM;
        private System.Data.DataColumn PRECO_TOTAL_ITEM;
        private System.Data.DataColumn IPI_ITEM;
        private System.Data.DataColumn ICM_ITEM;
        private System.Data.DataColumn NF_ITEM;
        private System.Data.DataColumn VALOR_IPI_ITEM;
        private System.Data.DataColumn PEDIDO_COMPRA_ITEM;
        private System.Data.DataColumn MAE_ITEM;
        private System.Data.DataColumn COD_ITEM;
        private System.Data.DataColumn NCM_ITEM;
        private System.Data.DataColumn CFOP_ITEM;
        private System.Data.DataColumn VALOR_ICM_ITEM;
        private System.Data.DataColumn VALOR_ISS_ITEM;
        private System.Data.DataColumn PRESTACAO_SERVICO_ITEM;
        private System.Data.DataColumn VALOR_BC_ITEM;
        private System.Data.DataColumn VALOR_BC_ICMS_ST_ITEM;
        private System.Data.DataColumn VALOR_ICMS_ST_ITEM;
        private System.Data.DataColumn VALOR_FRETE_ITEM;
        private System.Data.DataColumn VALOR_DESCONTO_ITEM;
        private System.Data.DataColumn VALOR_SEGURO_ITEM;
        private System.Data.DataColumn VALOR_OUTRAS_DESP_ITEM;
        private System.Data.DataColumn IVA_ITEM;
        private System.Data.DataColumn REDUCAO_ITEM;
        private System.Data.DataColumn COFINS_ITEM;
        private System.Data.DataColumn VALOR_COFINS_ITEM;
        private System.Data.DataColumn PIS_ITEM;
        private System.Data.DataColumn VALOR_PIS_ITEM;
        private System.Data.DataColumn ORIGEM_ITEM;
        private System.Data.DataColumn MOD_BC_ITEM;
        private System.Data.DataColumn ISS_ITEM;
        private System.Data.DataColumn MOD_BC_ST_ITEM;
        private System.Data.DataColumn REDUCAO_ST_ITEM;
        private System.Data.DataColumn ICMS_ST_ITEM;
        private System.Data.DataColumn ALIQUOTA_CREDITO_ITEM;
        private System.Data.DataColumn VALOR_CREDITO_ITEM;
        private System.Data.DataColumn IPI_TRIB_ITEM;
        private System.Data.DataColumn IPI_N_TRIB_ITEM;
        private System.Data.DataColumn CST_IPI_TRIB_ITEM;
        private System.Data.DataColumn CST_IPI_N_TRIB_ITEM;
        private System.Data.DataColumn TIPO_PIS_ITEM;
        private System.Data.DataColumn CST_PIS_ITEM;
        private System.Data.DataColumn TIPO_COFINS_ITEM;
        private System.Data.DataColumn CST_COFINS_ITEM;
        private System.Data.DataColumn TIPO_SERVICO_ITEM;
        private System.Data.DataColumn ITEM_PEDIDO_COMPRA_ITEM;
        private System.Data.DataColumn BC_IPI_ITEM;
        private System.Data.DataColumn BC_PIS_ITEM;
        private System.Data.DataColumn BC_COFINS_ITEM;
        private System.Data.DataColumn BC_ISS_ITEM;
        private System.Data.DataColumn BC_COM_IPI_ITEM;
        private System.Data.DataColumn ST_IMPRESSAO_ITEM;
        private System.Data.DataColumn COD_EAN_ITEM;
        private System.Data.DataColumn PORC_TRIB_ITEM;
        private System.Data.DataColumn TOTAL_TRIB_ITEM;
        private System.Data.DataColumn PRECO_MINIMO_ITEM;
        private System.Data.DataColumn CUSTO_ITEM;
        private System.Data.DataColumn CEST_ITEM;
        private System.Data.DataColumn COD_SISTEMA_NF_ITEM;
        private System.Data.DataColumn VBCSTRET_ITEM;
        private System.Data.DataColumn PST_ITEM;
        private System.Data.DataColumn VICMSSUBSTITUTO_ITEM;
        private System.Data.DataColumn VICMSSTRET_ITEM;
        private System.Windows.Forms.Label label43;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datItens_nota;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand40;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand38;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand37;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand39;
        private System.Windows.Forms.DataGridViewTextBoxColumn nFITEMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODEANITEMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qTDEITEMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFOPITEMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRICAOITEMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uNIDADEITEMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRECOUNITITEMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRECOTOTALITEMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODITEMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qTDEITEMENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTDE_LOTE_ITEM_ENT;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOTE_ITEM_ENT;
        private System.Windows.Forms.DataGridViewTextBoxColumn nFITEMENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRECOUNITITEMENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPJCLIENTEITEMENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pEDIDOCOMPRAITEMENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nLINHAPEDITEMENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODITEMREQITEMENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODITEMPEDITEMENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODITEMESTITEMENTDataGridViewTextBoxColumn;
        private System.Data.DataColumn dataColumn26;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvItens_produto;
    }
}