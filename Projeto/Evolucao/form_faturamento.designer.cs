using TheArtOfDev.HtmlRenderer.WinForms;
namespace Evolucao
{
    partial class form_faturamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_faturamento));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_n_nf = new System.Windows.Forms.TextBox();
            this.dsNota_fiscal = new System.Data.DataSet();
            this.NOTA_FISCAL = new System.Data.DataTable();
            this.COD_SISTEMA_NF = new System.Data.DataColumn();
            this.N_NF = new System.Data.DataColumn();
            this.FORMA_PGTO_NF = new System.Data.DataColumn();
            this.DATA_ENTR_SAI_NF = new System.Data.DataColumn();
            this.DATA_EMISSAO_NF = new System.Data.DataColumn();
            this.DATA_VENCIMENTO_NF = new System.Data.DataColumn();
            this.CFO_NF = new System.Data.DataColumn();
            this.CFO_2_NF = new System.Data.DataColumn();
            this.CLIENTE_FORN_NF = new System.Data.DataColumn();
            this.ENDERECO_ENTREGA_NF = new System.Data.DataColumn();
            this.BASE_CALC_ICMS_NF = new System.Data.DataColumn();
            this.VALOR_ICMS_NF = new System.Data.DataColumn();
            this.BASE_CALC_ICM_SUBS = new System.Data.DataColumn();
            this.VALOR_ICM_SUBS = new System.Data.DataColumn();
            this.VALOR_FRETE_NF = new System.Data.DataColumn();
            this.VALOR_SEGURO_NF = new System.Data.DataColumn();
            this.OUTRAS_DESP_NF = new System.Data.DataColumn();
            this.VALOR_IPI_NF = new System.Data.DataColumn();
            this.VALOR_TOT_PROD_NF = new System.Data.DataColumn();
            this.VALOR_NOTA_NF = new System.Data.DataColumn();
            this.TRANSPORTADORA_NF = new System.Data.DataColumn();
            this.FRETE_CONTA_NF = new System.Data.DataColumn();
            this.PLACA_VEICULO_NF = new System.Data.DataColumn();
            this.ESTADO_VEICULO_NF = new System.Data.DataColumn();
            this.QTDE_NF = new System.Data.DataColumn();
            this.ESPECIE_NF = new System.Data.DataColumn();
            this.MARCA_NF = new System.Data.DataColumn();
            this.PESO_BRUTO_NF = new System.Data.DataColumn();
            this.PESO_LIQUIDO_NF = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataColumn7 = new System.Data.DataColumn();
            this.dataColumn8 = new System.Data.DataColumn();
            this.dataColumn19 = new System.Data.DataColumn();
            this.dataColumn20 = new System.Data.DataColumn();
            this.dataColumn21 = new System.Data.DataColumn();
            this.dataColumn22 = new System.Data.DataColumn();
            this.dataColumn23 = new System.Data.DataColumn();
            this.dataColumn24 = new System.Data.DataColumn();
            this.dataColumn25 = new System.Data.DataColumn();
            this.dataColumn26 = new System.Data.DataColumn();
            this.dataColumn27 = new System.Data.DataColumn();
            this.dataColumn28 = new System.Data.DataColumn();
            this.dataColumn29 = new System.Data.DataColumn();
            this.dataColumn30 = new System.Data.DataColumn();
            this.dataColumn33 = new System.Data.DataColumn();
            this.dataColumn34 = new System.Data.DataColumn();
            this.dataColumn38 = new System.Data.DataColumn();
            this.dataColumn40 = new System.Data.DataColumn();
            this.dataColumn41 = new System.Data.DataColumn();
            this.dataColumn42 = new System.Data.DataColumn();
            this.dataColumn43 = new System.Data.DataColumn();
            this.dataColumn44 = new System.Data.DataColumn();
            this.dataColumn45 = new System.Data.DataColumn();
            this.dataColumn51 = new System.Data.DataColumn();
            this.dataColumn52 = new System.Data.DataColumn();
            this.dataColumn53 = new System.Data.DataColumn();
            this.dataColumn54 = new System.Data.DataColumn();
            this.dataColumn55 = new System.Data.DataColumn();
            this.dataColumn56 = new System.Data.DataColumn();
            this.dataColumn57 = new System.Data.DataColumn();
            this.dataColumn86 = new System.Data.DataColumn();
            this.dataColumn87 = new System.Data.DataColumn();
            this.dataColumn88 = new System.Data.DataColumn();
            this.dataColumn93 = new System.Data.DataColumn();
            this.dataColumn94 = new System.Data.DataColumn();
            this.dataColumn95 = new System.Data.DataColumn();
            this.dataColumn96 = new System.Data.DataColumn();
            this.dataColumn98 = new System.Data.DataColumn();
            this.dataColumn99 = new System.Data.DataColumn();
            this.dataColumn102 = new System.Data.DataColumn();
            this.dataColumn105 = new System.Data.DataColumn();
            this.dataColumn106 = new System.Data.DataColumn();
            this.dataColumn108 = new System.Data.DataColumn();
            this.dataColumn109 = new System.Data.DataColumn();
            this.tb_saida = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dsClientes = new System.Data.DataSet();
            this.CLIENTES = new System.Data.DataTable();
            this.COD_CLIENTE = new System.Data.DataColumn();
            this.RAZAO_SOCIAL = new System.Data.DataColumn();
            this.NOME_FANTASIA = new System.Data.DataColumn();
            this.IE = new System.Data.DataColumn();
            this.CNPJ = new System.Data.DataColumn();
            this.IM = new System.Data.DataColumn();
            this.ENDERECO = new System.Data.DataColumn();
            this.BAIRRO = new System.Data.DataColumn();
            this.CIDADE = new System.Data.DataColumn();
            this.ESTADO = new System.Data.DataColumn();
            this.PAIS = new System.Data.DataColumn();
            this.CEP_CLIENTE = new System.Data.DataColumn();
            this.FONE = new System.Data.DataColumn();
            this.EMAIL = new System.Data.DataColumn();
            this.CONTATO1 = new System.Data.DataColumn();
            this.FONE1 = new System.Data.DataColumn();
            this.EMAIL1 = new System.Data.DataColumn();
            this.CONTATO2 = new System.Data.DataColumn();
            this.FONE2 = new System.Data.DataColumn();
            this.EMAIL2 = new System.Data.DataColumn();
            this.SITUACAO = new System.Data.DataColumn();
            this.TIPO = new System.Data.DataColumn();
            this.TRANSPORTADORA_CLIENTE = new System.Data.DataColumn();
            this.ATIVIDADE_CLIENTE = new System.Data.DataColumn();
            this.BANCO_CLIENTE = new System.Data.DataColumn();
            this.AGENCIA_CLIENTE = new System.Data.DataColumn();
            this.REGIAO = new System.Data.DataColumn();
            this.VENDEDOR_CLIENTE = new System.Data.DataColumn();
            this.DATA_CADASTRO_CLIENTE = new System.Data.DataColumn();
            this.ETIQUETA = new System.Data.DataColumn();
            this.dataColumn10 = new System.Data.DataColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.dsTransportadoras = new System.Data.DataSet();
            this.TRANSPORTADORAS = new System.Data.DataTable();
            this.COD_TRANSPORTADORA = new System.Data.DataColumn();
            this.SITUACAO_TRANSPORTADORA = new System.Data.DataColumn();
            this.NOME_TRANSPORTADORA = new System.Data.DataColumn();
            this.RAZAO_SOCIAL_TRANSPORTADORA = new System.Data.DataColumn();
            this.ENDERECO_TRANSPORTADORA = new System.Data.DataColumn();
            this.BAIRRO_TRANSPORTADORA = new System.Data.DataColumn();
            this.CIDADE_TRANSPORTADORA = new System.Data.DataColumn();
            this.ESTADO_TRANSPORTADORA = new System.Data.DataColumn();
            this.PAIS_TRANSPORTADORA = new System.Data.DataColumn();
            this.CNPJ_TRANSPORTADORA = new System.Data.DataColumn();
            this.IE_TRANSPORTADORA = new System.Data.DataColumn();
            this.DATA_INSCRICAO_TRANSPORTADORA = new System.Data.DataColumn();
            this.TEL_1_TRANSPORTADORA = new System.Data.DataColumn();
            this.TEL_2_TRANSPORTADORA = new System.Data.DataColumn();
            this.CONTATO_1_TRANSPORTADORA = new System.Data.DataColumn();
            this.CONTATO_2_TRANSPORTADORA = new System.Data.DataColumn();
            this.EMAIL_1_TRANSPORTADORA = new System.Data.DataColumn();
            this.EMAIL_2_TRANSPORTADORA = new System.Data.DataColumn();
            this.FONE_TRANSPORTADORA = new System.Data.DataColumn();
            this.EMAIL_TRANSPORTADORA = new System.Data.DataColumn();
            this.IM_TRANSPORTADORA = new System.Data.DataColumn();
            this.tb_base_calc_icm = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_valor_icm = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_base_cal_icm_st = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_valor_icm_st = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_total_prod = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tb_valor_ipi = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tb_outras_des_ace = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tb_valor_seg = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tb_valor_fre = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tb_total_nota = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.tb_marca = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.tb_especie = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.tb_qtde_volume = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.tb_peso_bruto = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.tb_peso_liquido = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.tb_dados_adicionais = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.tb_data_emissao = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.datItens_nota = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
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
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn9 = new System.Data.DataColumn();
            this.dataColumn15 = new System.Data.DataColumn();
            this.dataColumn14 = new System.Data.DataColumn();
            this.dataColumn31 = new System.Data.DataColumn();
            this.dataColumn36 = new System.Data.DataColumn();
            this.dataColumn39 = new System.Data.DataColumn();
            this.dataColumn49 = new System.Data.DataColumn();
            this.dataColumn50 = new System.Data.DataColumn();
            this.dataColumn58 = new System.Data.DataColumn();
            this.dataColumn59 = new System.Data.DataColumn();
            this.dataColumn60 = new System.Data.DataColumn();
            this.dataColumn61 = new System.Data.DataColumn();
            this.dataColumn62 = new System.Data.DataColumn();
            this.dataColumn63 = new System.Data.DataColumn();
            this.dataColumn64 = new System.Data.DataColumn();
            this.dataColumn65 = new System.Data.DataColumn();
            this.dataColumn66 = new System.Data.DataColumn();
            this.dataColumn67 = new System.Data.DataColumn();
            this.dataColumn68 = new System.Data.DataColumn();
            this.dataColumn69 = new System.Data.DataColumn();
            this.dataColumn70 = new System.Data.DataColumn();
            this.dataColumn71 = new System.Data.DataColumn();
            this.dataColumn72 = new System.Data.DataColumn();
            this.dataColumn73 = new System.Data.DataColumn();
            this.dataColumn74 = new System.Data.DataColumn();
            this.dataColumn75 = new System.Data.DataColumn();
            this.dataColumn76 = new System.Data.DataColumn();
            this.dataColumn77 = new System.Data.DataColumn();
            this.dataColumn78 = new System.Data.DataColumn();
            this.dataColumn79 = new System.Data.DataColumn();
            this.dataColumn80 = new System.Data.DataColumn();
            this.dataColumn81 = new System.Data.DataColumn();
            this.dataColumn82 = new System.Data.DataColumn();
            this.dataColumn83 = new System.Data.DataColumn();
            this.dataColumn84 = new System.Data.DataColumn();
            this.dataColumn85 = new System.Data.DataColumn();
            this.dataColumn89 = new System.Data.DataColumn();
            this.dataColumn90 = new System.Data.DataColumn();
            this.dataColumn91 = new System.Data.DataColumn();
            this.dataColumn92 = new System.Data.DataColumn();
            this.dataColumn32 = new System.Data.DataColumn();
            this.dataColumn35 = new System.Data.DataColumn();
            this.dataColumn97 = new System.Data.DataColumn();
            this.dataColumn100 = new System.Data.DataColumn();
            this.dataColumn101 = new System.Data.DataColumn();
            this.dataColumn104 = new System.Data.DataColumn();
            this.dataColumn110 = new System.Data.DataColumn();
            this.dataColumn111 = new System.Data.DataColumn();
            this.dataColumn112 = new System.Data.DataColumn();
            this.dataColumn37 = new System.Data.DataColumn();
            this.dataColumn113 = new System.Data.DataColumn();
            this.dataColumn114 = new System.Data.DataColumn();
            this.dataColumn115 = new System.Data.DataColumn();
            this.dataColumn116 = new System.Data.DataColumn();
            this.dataColumn117 = new System.Data.DataColumn();
            this.dataColumn118 = new System.Data.DataColumn();
            this.dataColumn120 = new System.Data.DataColumn();
            this.dataColumn121 = new System.Data.DataColumn();
            this.dataColumn119 = new System.Data.DataColumn();
            this.dataColumn122 = new System.Data.DataColumn();
            this.radioEntrada = new System.Windows.Forms.RadioButton();
            this.radioSaida = new System.Windows.Forms.RadioButton();
            this.datNota_fiscal = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand8 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand6 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand5 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand7 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.salva_registro = new System.Windows.Forms.Button();
            this.novo_registro = new System.Windows.Forms.Button();
            this.tb_cod_interno = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.datOp = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand12 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand10 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand9 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand11 = new FirebirdSql.Data.FirebirdClient.FbCommand();
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
            this.DESCRICAO_PECA = new System.Data.DataColumn();
            this.MARCA_PECA = new System.Data.DataColumn();
            this.UNIDADE_PECA = new System.Data.DataColumn();
            this.PESO_PECA = new System.Data.DataColumn();
            this.TRIBUTACAO_PECA = new System.Data.DataColumn();
            this.ICMS_PECA = new System.Data.DataColumn();
            this.IPI_PECA = new System.Data.DataColumn();
            this.PRECO_PECA = new System.Data.DataColumn();
            this.QTDE_ESTOQUE_PECA = new System.Data.DataColumn();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn18 = new System.Data.DataColumn();
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
            this.LOTE = new System.Data.DataColumn();
            this.ESPESSURA_OP = new System.Data.DataColumn();
            this.OBSERVACOES_OP = new System.Data.DataColumn();
            this.REVISAO_OP = new System.Data.DataColumn();
            this.DESCRICAO_PECA_OP = new System.Data.DataColumn();
            this.MARCA_OP = new System.Data.DataColumn();
            this.UNIDADE_OP = new System.Data.DataColumn();
            this.ICMS_OP = new System.Data.DataColumn();
            this.IPI_OP = new System.Data.DataColumn();
            this.dataColumn11 = new System.Data.DataColumn();
            this.dataColumn12 = new System.Data.DataColumn();
            this.dataColumn13 = new System.Data.DataColumn();
            this.dataColumn16 = new System.Data.DataColumn();
            this.dataColumn17 = new System.Data.DataColumn();
            this.datDesenhos = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand16 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand14 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand13 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand15 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsUlt_imp_nf = new System.Data.DataSet();
            this.ULT_IMP_NF = new System.Data.DataTable();
            this.COD_ULT_IMP_NF = new System.Data.DataColumn();
            this.NUM_ULT_NF = new System.Data.DataColumn();
            this.datUlt_imp_nf = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand20 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand18 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand17 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand19 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.cbNota_fiscal = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.cbUlt_imp_nf = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.fbCommand24 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand22 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand21 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand23 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.datClientes = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand28 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand26 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand25 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand27 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.datTransportadoras = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand32 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand30 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand29 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand31 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.datCfo = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand36 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand34 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand33 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand35 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsCfo = new System.Data.DataSet();
            this.CFO = new System.Data.DataTable();
            this.COD_SISTEMA_CFO = new System.Data.DataColumn();
            this.N_CFO = new System.Data.DataColumn();
            this.DESCRICAO_CFO = new System.Data.DataColumn();
            this.OBSERVACAO_CFO = new System.Data.DataColumn();
            this.tb_cnpj_cliente = new System.Windows.Forms.TextBox();
            this.tb_transportadora = new System.Windows.Forms.TextBox();
            this.tb_frete = new System.Windows.Forms.TextBox();
            this.cbItens_nota = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
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
            this.PECAS_APROVADAS = new System.Data.DataColumn();
            this.PECAS_REJEITADAS = new System.Data.DataColumn();
            this.TIPO_REJEICAO = new System.Data.DataColumn();
            this.OPERADOR_FINALIZADOR = new System.Data.DataColumn();
            this.MAQ_FECHA = new System.Data.DataColumn();
            this.RETRABALHO_ROTA = new System.Data.DataColumn();
            this.SALDO_HORAS = new System.Data.DataColumn();
            this.HORAS_OPERADOR = new System.Data.DataColumn();
            this.HORAS_MAQUINA = new System.Data.DataColumn();
            this.PECAS_ADICIONAIS = new System.Data.DataColumn();
            this.datRotas_campo = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand40 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand38 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand37 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand39 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand41 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand42 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand43 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand44 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.tb_descricao_peca = new System.Windows.Forms.TextBox();
            this.tb_cod_peca = new System.Windows.Forms.TextBox();
            this.tb_preco_unit_peca = new System.Windows.Forms.TextBox();
            this.tb_qtde_peca = new System.Windows.Forms.TextBox();
            this.tb_unid_peca = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label35 = new System.Windows.Forms.Label();
            this.fbDataAdapter1 = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand48 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand46 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand45 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand47 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.label37 = new System.Windows.Forms.Label();
            this.tb_ncm_peca = new System.Windows.Forms.TextBox();
            this.cbNfe_teste = new System.Windows.Forms.CheckBox();
            this.tb_local_exportacao = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.tb_uf_exportacao = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbExportacao = new System.Windows.Forms.CheckBox();
            this.bt_imprimirNFe = new System.Windows.Forms.Button();
            this.bt_enviarNFe = new System.Windows.Forms.Button();
            this.bt_gerarXML = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.barra_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.tb_status_nfe = new System.Windows.Forms.TextBox();
            this.comando_select = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.bt_cancelarNFe = new System.Windows.Forms.Button();
            this.br_consultaStatus = new System.Windows.Forms.Button();
            this.gbNfe = new System.Windows.Forms.GroupBox();
            this.tb_n_copias = new System.Windows.Forms.TextBox();
            this.label83 = new System.Windows.Forms.Label();
            this.button19 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.bt_boleto = new System.Windows.Forms.Button();
            this.tb_sequencial_correcao = new System.Windows.Forms.TextBox();
            this.tb_texto_correcao = new System.Windows.Forms.TextBox();
            this.label81 = new System.Windows.Forms.Label();
            this.label80 = new System.Windows.Forms.Label();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_motivo_cancelamento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_protocolo_autorizacao = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label47 = new System.Windows.Forms.Label();
            this.tb_chave_acesso_nfe = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.tb_recibo = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.label46 = new System.Windows.Forms.Label();
            this.tb_ent_sai_nfe = new System.Windows.Forms.TextBox();
            this.datForma_pgto = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand52 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand50 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand49 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand51 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsForma_pgto = new System.Data.DataSet();
            this.FORMA_PGTO = new System.Data.DataTable();
            this.COD_FORMA_PGTO = new System.Data.DataColumn();
            this.DESCRICAO_FORMA_PGTO = new System.Data.DataColumn();
            this.N_PARCELAS_FORMA_PGTO = new System.Data.DataColumn();
            this.PRAZO_1_FORMA_PGTO = new System.Data.DataColumn();
            this.PRAZO_2_FORMA_PGTO = new System.Data.DataColumn();
            this.PRAZO_3_FORMA_PGTO = new System.Data.DataColumn();
            this.PRAZO_4_FORMA_PGTO = new System.Data.DataColumn();
            this.PRAZO_5_FORMA_PGTO = new System.Data.DataColumn();
            this.PRAZO_6_FORMA_PGTO = new System.Data.DataColumn();
            this.cb_forma_pgto = new System.Windows.Forms.TextBox();
            this.tb_cfo_peca = new System.Windows.Forms.TextBox();
            this.tb_natureza_operacao = new System.Windows.Forms.TextBox();
            this.label48 = new System.Windows.Forms.Label();
            this.datFatura_nf = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand56 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand54 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand53 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand55 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.tb_cliente = new System.Windows.Forms.TextBox();
            this.datImp_duplicatas = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand60 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand58 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand57 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand59 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsImp_duplicatas = new System.Data.DataSet();
            this.IMP_DUPLICATAS = new System.Data.DataTable();
            this.COD_IMP_DUPLICATA = new System.Data.DataColumn();
            this.COD_1_IMP_DUPLICATA = new System.Data.DataColumn();
            this.DATA_1_IMP_DUPLICATA = new System.Data.DataColumn();
            this.VALOR_1_IMP_DUPLICATA = new System.Data.DataColumn();
            this.COD_2_IMP_DUPLICATA = new System.Data.DataColumn();
            this.DATA_2_IMP_DUPLICATA = new System.Data.DataColumn();
            this.VALOR_2_IMP_DUPLICATA = new System.Data.DataColumn();
            this.COD_3_IMP_DUPLICATA = new System.Data.DataColumn();
            this.DATA_3_IMP_DUPLICATA = new System.Data.DataColumn();
            this.VALOR_3_IMP_DUPLICATA = new System.Data.DataColumn();
            this.COD_4_IMP_DUPLICATA = new System.Data.DataColumn();
            this.DATA_4_IMP_DUPLICATA = new System.Data.DataColumn();
            this.VALOR_4_IMP_DUPLICATA = new System.Data.DataColumn();
            this.COD_5_IMP_DUPLICATA = new System.Data.DataColumn();
            this.DATA_5_IMP_DUPLICATA = new System.Data.DataColumn();
            this.VALOR_5_IMP_DUPLICATA = new System.Data.DataColumn();
            this.COD_6_IMP_DUPLICATA = new System.Data.DataColumn();
            this.DATA_6_IMP_DUPLICATA = new System.Data.DataColumn();
            this.VALOR_6_IMP_DUPLICATA = new System.Data.DataColumn();
            this.datAliquota = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand64 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand62 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand61 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand63 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsAliquota = new System.Data.DataSet();
            this.ALIQUOTA_SIMPLES = new System.Data.DataTable();
            this.COD_ALIQUOTA = new System.Data.DataColumn();
            this.VALOR_ALIQUOTA = new System.Data.DataColumn();
            this.datContas_a_receber = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand68 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand66 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand65 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand67 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsContas_a_receber = new System.Data.DataSet();
            this.CONTAS_A_RECEBER = new System.Data.DataTable();
            this.COD_CR = new System.Data.DataColumn();
            this.VALOR_CR = new System.Data.DataColumn();
            this.DATA_PREVISTA_CR = new System.Data.DataColumn();
            this.DATA_RECEBIMENTO_CR = new System.Data.DataColumn();
            this.COD_CLIENTE_CR = new System.Data.DataColumn();
            this.RAZAO_CLIENTE_CR = new System.Data.DataColumn();
            this.DESCRICAO_CR = new System.Data.DataColumn();
            this.DUPLICATA_CR = new System.Data.DataColumn();
            this.NF_CR = new System.Data.DataColumn();
            this.RECEBIDO_CR = new System.Data.DataColumn();
            this.COD_CAIXA_CR = new System.Data.DataColumn();
            this.pb_codigo = new System.Windows.Forms.PictureBox();
            this.datEmpresa = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand72 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand70 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand69 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand71 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsEmpresa = new System.Data.DataSet();
            this.EMPRESA = new System.Data.DataTable();
            this.COD_EMPRESA = new System.Data.DataColumn();
            this.RAZAO_SOCIAL_EMPRESA = new System.Data.DataColumn();
            this.NOME_FANTASIA_EMPRESA = new System.Data.DataColumn();
            this.CNPJ_EMPRESA = new System.Data.DataColumn();
            this.IE_EMPRESA = new System.Data.DataColumn();
            this.IM_EMPRESA = new System.Data.DataColumn();
            this.ENDERECO_EMPRESA = new System.Data.DataColumn();
            this.N_ENDERECO_EMPRESA = new System.Data.DataColumn();
            this.COMPLEMENTO_EMPRESA = new System.Data.DataColumn();
            this.BAIRRO_EMPRESA = new System.Data.DataColumn();
            this.CIDADE_EMPRESA = new System.Data.DataColumn();
            this.ESTADO_EMPRESA = new System.Data.DataColumn();
            this.CEP_EMPRESA = new System.Data.DataColumn();
            this.TELEFONE_EMPRESA = new System.Data.DataColumn();
            this.COD_CIDADE_EMPRESA = new System.Data.DataColumn();
            this.PAIS_EMPRESA = new System.Data.DataColumn();
            this.COD_PAIS_EMPRESA = new System.Data.DataColumn();
            this.LICENCA_DLL_NFE_EMPRESA = new System.Data.DataColumn();
            this.NOME_CERTIFICADO_NFE_EMPRESA = new System.Data.DataColumn();
            this.ASSUNTO_NFE_EMAIL_EMPRESA = new System.Data.DataColumn();
            this.SMTP_NFE_EMPRESA = new System.Data.DataColumn();
            this.EMAIL_NFE_EMPRESA = new System.Data.DataColumn();
            this.SENHA_EMAIL_NFE_EMPRESA = new System.Data.DataColumn();
            this.LOGOTIPO_EMPRESA = new System.Data.DataColumn();
            this.dataColumn46 = new System.Data.DataColumn();
            this.dataColumn47 = new System.Data.DataColumn();
            this.dataColumn48 = new System.Data.DataColumn();
            this.datTributacao = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand76 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand74 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand73 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand75 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.datProdutos = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand80 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand78 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand77 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand79 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.tb_desconto = new System.Windows.Forms.TextBox();
            this.label_desconto = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button24 = new System.Windows.Forms.Button();
            this.label84 = new System.Windows.Forms.Label();
            this.tb_finalidade = new System.Windows.Forms.TextBox();
            this.button20 = new System.Windows.Forms.Button();
            this.tb_estado_cliente = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label86 = new System.Windows.Forms.Label();
            this.tb_cl = new System.Windows.Forms.TextBox();
            this.button25 = new System.Windows.Forms.Button();
            this.cbxCfopPadrao = new System.Windows.Forms.CheckBox();
            this.label79 = new System.Windows.Forms.Label();
            this.tb_ean = new System.Windows.Forms.TextBox();
            this.button13 = new System.Windows.Forms.Button();
            this.label64 = new System.Windows.Forms.Label();
            this.tb_mod_bc_st_item = new System.Windows.Forms.TextBox();
            this.button10 = new System.Windows.Forms.Button();
            this.label52 = new System.Windows.Forms.Label();
            this.tb_mod_bc_item = new System.Windows.Forms.TextBox();
            this.label50 = new System.Windows.Forms.Label();
            this.tb_cst = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.tb_origem_peca = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label74 = new System.Windows.Forms.Label();
            this.tb_n_item_pedido_compra = new System.Windows.Forms.TextBox();
            this.label73 = new System.Windows.Forms.Label();
            this.tb_pedido_compra = new System.Windows.Forms.TextBox();
            this.label53 = new System.Windows.Forms.Label();
            this.tb_seguro_item = new System.Windows.Forms.TextBox();
            this.label51 = new System.Windows.Forms.Label();
            this.tb_outras_desp_item = new System.Windows.Forms.TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.tb_desconto_item = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.tb_frete_item = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label65 = new System.Windows.Forms.Label();
            this.tb_reducao_st_item = new System.Windows.Forms.TextBox();
            this.label61 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.tb_iss_item = new System.Windows.Forms.TextBox();
            this.tb_cofins_item = new System.Windows.Forms.TextBox();
            this.label55 = new System.Windows.Forms.Label();
            this.tb_pis_item = new System.Windows.Forms.TextBox();
            this.label56 = new System.Windows.Forms.Label();
            this.tb_ipi_item = new System.Windows.Forms.TextBox();
            this.label57 = new System.Windows.Forms.Label();
            this.tb_iva_item = new System.Windows.Forms.TextBox();
            this.label58 = new System.Windows.Forms.Label();
            this.tb_reducao_item = new System.Windows.Forms.TextBox();
            this.label59 = new System.Windows.Forms.Label();
            this.tb_icms_st = new System.Windows.Forms.TextBox();
            this.label60 = new System.Windows.Forms.Label();
            this.tb_icms_item = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label75 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label87 = new System.Windows.Forms.Label();
            this.tb_vtrib = new System.Windows.Forms.TextBox();
            this.tb_valor_total_iss = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_base_calc_iss = new System.Windows.Forms.TextBox();
            this.tb_aliquota_simples = new System.Windows.Forms.TextBox();
            this.label78 = new System.Windows.Forms.Label();
            this.tb_valor_simples = new System.Windows.Forms.TextBox();
            this.label77 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.button21 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.dgvFatura_nf = new System.Windows.Forms.DataGridView();
            this.cODFATURADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_prazo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cr_fatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nFFATURADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsFatura_nf = new System.Data.DataSet();
            this.FATURA_NF = new System.Data.DataTable();
            this.COD_FATURA = new System.Data.DataColumn();
            this.PRAZO_FATURA = new System.Data.DataColumn();
            this.DATA_VENC_FATURA = new System.Data.DataColumn();
            this.VALOR_FATURA = new System.Data.DataColumn();
            this.NF_FATURA = new System.Data.DataColumn();
            this.dataColumn103 = new System.Data.DataColumn();
            this.fbCommand81 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand82 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.cbFatura_nf = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.label62 = new System.Windows.Forms.Label();
            this.empresalabel = new System.Windows.Forms.Label();
            this.cnpjlabel = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.estadolabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tb_cst_ipi_n_tributado = new System.Windows.Forms.TextBox();
            this.tb_cst_ipi_tributado = new System.Windows.Forms.TextBox();
            this.label66 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.rb_ipi_nao_tributado = new System.Windows.Forms.RadioButton();
            this.rb_ipi_tributado = new System.Windows.Forms.RadioButton();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tb_tipo_cofins = new System.Windows.Forms.TextBox();
            this.label70 = new System.Windows.Forms.Label();
            this.tb_cst_cofins = new System.Windows.Forms.TextBox();
            this.label71 = new System.Windows.Forms.Label();
            this.tb_tipo_pis = new System.Windows.Forms.TextBox();
            this.label69 = new System.Windows.Forms.Label();
            this.tb_cst_pis = new System.Windows.Forms.TextBox();
            this.label68 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tb_tipo_servico = new System.Windows.Forms.TextBox();
            this.label72 = new System.Windows.Forms.Label();
            this.cb_prestacao_servico = new System.Windows.Forms.CheckBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label76 = new System.Windows.Forms.Label();
            this.tb_aliquota_credito = new System.Windows.Forms.TextBox();
            this.cbBC_com_ipi = new System.Windows.Forms.CheckBox();
            this.cbNaoTributada = new System.Windows.Forms.RadioButton();
            this.cbTributada = new System.Windows.Forms.RadioButton();
            this.itemPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button27 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.cbReferenciar = new System.Windows.Forms.CheckBox();
            this.tb_Nfe_refer = new System.Windows.Forms.TextBox();
            this.label_nfe = new System.Windows.Forms.Label();
            this.rb_5910 = new System.Windows.Forms.RadioButton();
            this.fbCommand94 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand92 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand91 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand93 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.datPedidos_venda = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.datItens_pedido_venda = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.cODPEDIDONFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nFPEDIDONFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COD_SISTEMA_PEDIDO_NF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsPedidos_nf = new System.Data.DataSet();
            this.PEDIDOS_NF = new System.Data.DataTable();
            this.COD_PEDIDO_NF = new System.Data.DataColumn();
            this.NF_PEDIDO_NF = new System.Data.DataColumn();
            this.N_PEDIDO_NF = new System.Data.DataColumn();
            this.dataColumn107 = new System.Data.DataColumn();
            this.fbCommand83 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand84 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand85 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand86 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand87 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand88 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand89 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand90 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.rb_1410 = new System.Windows.Forms.RadioButton();
            this.rb_5904 = new System.Windows.Forms.RadioButton();
            this.rb_5202 = new System.Windows.Forms.RadioButton();
            this.datPedidos_nf = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand98 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand96 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand95 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand97 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.cbPedidos_nf = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.rb_5949 = new System.Windows.Forms.RadioButton();
            this.rb_5917 = new System.Windows.Forms.RadioButton();
            this.tb_razao_empresa = new System.Windows.Forms.TextBox();
            this.tb_cnpj_empresa = new System.Windows.Forms.TextBox();
            this.label82 = new System.Windows.Forms.Label();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.cnpjtoolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.empresatoolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.button22 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.rb5124 = new System.Windows.Forms.RadioButton();
            this.rb5101 = new System.Windows.Forms.RadioButton();
            this.button23 = new System.Windows.Forms.Button();
            this.tb_informacoes_fisco = new System.Windows.Forms.TextBox();
            this.label85 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.label88 = new System.Windows.Forms.Label();
            this.tb_aliquota_cbs = new System.Windows.Forms.TextBox();
            this.label89 = new System.Windows.Forms.Label();
            this.tb_aliquota_ibs = new System.Windows.Forms.TextBox();
            this.label90 = new System.Windows.Forms.Label();
            this.tb_classificacao_ibscbs = new System.Windows.Forms.TextBox();
            this.label91 = new System.Windows.Forms.Label();
            this.tb_cst_ibscbs = new System.Windows.Forms.TextBox();
            this.dataColumn123 = new System.Data.DataColumn();
            this.dataColumn124 = new System.Data.DataColumn();
            this.dataColumn125 = new System.Data.DataColumn();
            this.dataColumn126 = new System.Data.DataColumn();
            this.dataColumn127 = new System.Data.DataColumn();
            this.dataColumn128 = new System.Data.DataColumn();
            this.dataColumn129 = new System.Data.DataColumn();
            this.dgvItens_nota = new System.Windows.Forms.DataGridView();
            this.col_cod_op = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_unidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_qtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_preco_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_preco_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ncm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_valor_bc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_icms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_valor_icm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ipi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_valor_ipi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_iss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_valor_iss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_icms_st = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_valor_bc_st = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_valor_st = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_iva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_reducao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_frete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_desconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_seguro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_outras_desp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cofins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_valor_cofins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_pis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_valor_pis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_prestacao_servico = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.col_st = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_origem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_mod_item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_mod_bc_st = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_red_st = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_aliq_cred = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_valor_credito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trib = new System.Windows.Forms.DataGridViewButtonColumn();
            this.col_tipo_servico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_pedido_compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_item_pedido_compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ean = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_porc_trib = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_tot_trib = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PORC_IPI_DEV_ITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR_IPI_DEV_ITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IPI_TRIB_ITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IPI_N_TRIB_ITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CST_IPI_TRIB_ITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CST_IPI_N_TRIB_ITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO_PIS_ITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CST_PIS_ITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO_COFINS_ITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CST_COFINS_ITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BC_IPI_ITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BC_PIS_ITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BC_COFINS_ITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N_NF_ENT_ITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DI_ITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA_DI_ITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOCAL_DES_ITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UF_DES_ITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA_DES_ITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COD_EXP_ITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BC_II_ITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR_II_ITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESP_ADUANEIRAS_ITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IOF_II_ITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CST_IBSCBS_ITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCLASSTRIB_ITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ALIQ_IBS_ITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ALIQ_CBS_ITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR_IBS_ITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR_CBS_ITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BC_IBSCBS_ITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dsNota_fiscal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NOTA_FISCAL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CLIENTES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransportadoras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRANSPORTADORAS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsItens_nota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITENS_NOTA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDesenhos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DESENHOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUlt_imp_nf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ULT_IMP_NF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CFO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRotas_campo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ROTAS_CAMPO)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.gbNfe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsForma_pgto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FORMA_PGTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsImp_duplicatas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMP_DUPLICATAS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAliquota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ALIQUOTA_SIMPLES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsContas_a_receber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CONTAS_A_RECEBER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_codigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EMPRESA)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFatura_nf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFatura_nf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FATURA_NF)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.itemPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPedidos_nf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PEDIDOS_NF)).BeginInit();
            this.statusStrip2.SuspendLayout();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens_nota)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "N.º da Nota Fiscal: *";
            // 
            // tb_n_nf
            // 
            this.tb_n_nf.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsNota_fiscal, "NOTA_FISCAL.N_NF", true));
            this.tb_n_nf.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_n_nf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tb_n_nf.Location = new System.Drawing.Point(6, 62);
            this.tb_n_nf.Name = "tb_n_nf";
            this.tb_n_nf.ReadOnly = true;
            this.tb_n_nf.Size = new System.Drawing.Size(154, 60);
            this.tb_n_nf.TabIndex = 1;
            this.tb_n_nf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_n_nf.TextChanged += new System.EventHandler(this.tb_n_nf_TextChanged);
            this.tb_n_nf.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tb_n_nf_MouseDoubleClick);
            // 
            // dsNota_fiscal
            // 
            this.dsNota_fiscal.DataSetName = "dsNota_fiscal";
            this.dsNota_fiscal.Namespace = "http://www.tempuri.org/dsNota_fiscal.xsd";
            this.dsNota_fiscal.Tables.AddRange(new System.Data.DataTable[] {
            this.NOTA_FISCAL});
            // 
            // NOTA_FISCAL
            // 
            this.NOTA_FISCAL.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_SISTEMA_NF,
            this.N_NF,
            this.FORMA_PGTO_NF,
            this.DATA_ENTR_SAI_NF,
            this.DATA_EMISSAO_NF,
            this.DATA_VENCIMENTO_NF,
            this.CFO_NF,
            this.CFO_2_NF,
            this.CLIENTE_FORN_NF,
            this.ENDERECO_ENTREGA_NF,
            this.BASE_CALC_ICMS_NF,
            this.VALOR_ICMS_NF,
            this.BASE_CALC_ICM_SUBS,
            this.VALOR_ICM_SUBS,
            this.VALOR_FRETE_NF,
            this.VALOR_SEGURO_NF,
            this.OUTRAS_DESP_NF,
            this.VALOR_IPI_NF,
            this.VALOR_TOT_PROD_NF,
            this.VALOR_NOTA_NF,
            this.TRANSPORTADORA_NF,
            this.FRETE_CONTA_NF,
            this.PLACA_VEICULO_NF,
            this.ESTADO_VEICULO_NF,
            this.QTDE_NF,
            this.ESPECIE_NF,
            this.MARCA_NF,
            this.PESO_BRUTO_NF,
            this.PESO_LIQUIDO_NF,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn6,
            this.dataColumn7,
            this.dataColumn8,
            this.dataColumn19,
            this.dataColumn20,
            this.dataColumn21,
            this.dataColumn22,
            this.dataColumn23,
            this.dataColumn24,
            this.dataColumn25,
            this.dataColumn26,
            this.dataColumn27,
            this.dataColumn28,
            this.dataColumn29,
            this.dataColumn30,
            this.dataColumn33,
            this.dataColumn34,
            this.dataColumn38,
            this.dataColumn40,
            this.dataColumn41,
            this.dataColumn42,
            this.dataColumn43,
            this.dataColumn44,
            this.dataColumn45,
            this.dataColumn51,
            this.dataColumn52,
            this.dataColumn53,
            this.dataColumn54,
            this.dataColumn55,
            this.dataColumn56,
            this.dataColumn57,
            this.dataColumn86,
            this.dataColumn87,
            this.dataColumn88,
            this.dataColumn93,
            this.dataColumn94,
            this.dataColumn95,
            this.dataColumn96,
            this.dataColumn98,
            this.dataColumn99,
            this.dataColumn102,
            this.dataColumn105,
            this.dataColumn106,
            this.dataColumn108,
            this.dataColumn109});
            this.NOTA_FISCAL.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "N_NF"}, true)});
            this.NOTA_FISCAL.PrimaryKey = new System.Data.DataColumn[] {
        this.N_NF};
            this.NOTA_FISCAL.TableName = "NOTA_FISCAL";
            // 
            // COD_SISTEMA_NF
            // 
            this.COD_SISTEMA_NF.AutoIncrementSeed = ((long)(1));
            this.COD_SISTEMA_NF.ColumnName = "COD_SISTEMA_NF";
            this.COD_SISTEMA_NF.DataType = typeof(int);
            // 
            // N_NF
            // 
            this.N_NF.AllowDBNull = false;
            this.N_NF.ColumnName = "N_NF";
            this.N_NF.DataType = typeof(int);
            // 
            // FORMA_PGTO_NF
            // 
            this.FORMA_PGTO_NF.ColumnName = "FORMA_PGTO_NF";
            this.FORMA_PGTO_NF.MaxLength = 20;
            // 
            // DATA_ENTR_SAI_NF
            // 
            this.DATA_ENTR_SAI_NF.ColumnName = "DATA_ENTR_SAI_NF";
            this.DATA_ENTR_SAI_NF.DataType = typeof(System.DateTime);
            // 
            // DATA_EMISSAO_NF
            // 
            this.DATA_EMISSAO_NF.ColumnName = "DATA_EMISSAO_NF";
            this.DATA_EMISSAO_NF.DataType = typeof(System.DateTime);
            // 
            // DATA_VENCIMENTO_NF
            // 
            this.DATA_VENCIMENTO_NF.ColumnName = "DATA_VENCIMENTO_NF";
            this.DATA_VENCIMENTO_NF.DataType = typeof(System.DateTime);
            // 
            // CFO_NF
            // 
            this.CFO_NF.ColumnName = "CFO_NF";
            this.CFO_NF.MaxLength = 15;
            // 
            // CFO_2_NF
            // 
            this.CFO_2_NF.ColumnName = "CFO_2_NF";
            this.CFO_2_NF.MaxLength = 15;
            // 
            // CLIENTE_FORN_NF
            // 
            this.CLIENTE_FORN_NF.ColumnName = "CLIENTE_FORN_NF";
            this.CLIENTE_FORN_NF.MaxLength = 100;
            // 
            // ENDERECO_ENTREGA_NF
            // 
            this.ENDERECO_ENTREGA_NF.ColumnName = "ENDERECO_ENTREGA_NF";
            this.ENDERECO_ENTREGA_NF.MaxLength = 100;
            // 
            // BASE_CALC_ICMS_NF
            // 
            this.BASE_CALC_ICMS_NF.ColumnName = "BASE_CALC_ICMS_NF";
            this.BASE_CALC_ICMS_NF.DataType = typeof(double);
            // 
            // VALOR_ICMS_NF
            // 
            this.VALOR_ICMS_NF.ColumnName = "VALOR_ICMS_NF";
            this.VALOR_ICMS_NF.DataType = typeof(double);
            // 
            // BASE_CALC_ICM_SUBS
            // 
            this.BASE_CALC_ICM_SUBS.ColumnName = "BASE_CALC_ICM_SUBS";
            this.BASE_CALC_ICM_SUBS.DataType = typeof(double);
            // 
            // VALOR_ICM_SUBS
            // 
            this.VALOR_ICM_SUBS.ColumnName = "VALOR_ICM_SUBS";
            this.VALOR_ICM_SUBS.DataType = typeof(double);
            // 
            // VALOR_FRETE_NF
            // 
            this.VALOR_FRETE_NF.ColumnName = "VALOR_FRETE_NF";
            this.VALOR_FRETE_NF.DataType = typeof(double);
            // 
            // VALOR_SEGURO_NF
            // 
            this.VALOR_SEGURO_NF.ColumnName = "VALOR_SEGURO_NF";
            this.VALOR_SEGURO_NF.DataType = typeof(double);
            // 
            // OUTRAS_DESP_NF
            // 
            this.OUTRAS_DESP_NF.ColumnName = "OUTRAS_DESP_NF";
            this.OUTRAS_DESP_NF.DataType = typeof(double);
            // 
            // VALOR_IPI_NF
            // 
            this.VALOR_IPI_NF.ColumnName = "VALOR_IPI_NF";
            this.VALOR_IPI_NF.DataType = typeof(double);
            // 
            // VALOR_TOT_PROD_NF
            // 
            this.VALOR_TOT_PROD_NF.ColumnName = "VALOR_TOT_PROD_NF";
            this.VALOR_TOT_PROD_NF.DataType = typeof(double);
            // 
            // VALOR_NOTA_NF
            // 
            this.VALOR_NOTA_NF.ColumnName = "VALOR_NOTA_NF";
            this.VALOR_NOTA_NF.DataType = typeof(double);
            // 
            // TRANSPORTADORA_NF
            // 
            this.TRANSPORTADORA_NF.ColumnName = "TRANSPORTADORA_NF";
            this.TRANSPORTADORA_NF.MaxLength = 100;
            // 
            // FRETE_CONTA_NF
            // 
            this.FRETE_CONTA_NF.ColumnName = "FRETE_CONTA_NF";
            this.FRETE_CONTA_NF.DataType = typeof(int);
            // 
            // PLACA_VEICULO_NF
            // 
            this.PLACA_VEICULO_NF.ColumnName = "PLACA_VEICULO_NF";
            this.PLACA_VEICULO_NF.MaxLength = 15;
            // 
            // ESTADO_VEICULO_NF
            // 
            this.ESTADO_VEICULO_NF.ColumnName = "ESTADO_VEICULO_NF";
            this.ESTADO_VEICULO_NF.MaxLength = 15;
            // 
            // QTDE_NF
            // 
            this.QTDE_NF.ColumnName = "QTDE_NF";
            this.QTDE_NF.DataType = typeof(int);
            // 
            // ESPECIE_NF
            // 
            this.ESPECIE_NF.ColumnName = "ESPECIE_NF";
            this.ESPECIE_NF.MaxLength = 20;
            // 
            // MARCA_NF
            // 
            this.MARCA_NF.ColumnName = "MARCA_NF";
            this.MARCA_NF.MaxLength = 20;
            // 
            // PESO_BRUTO_NF
            // 
            this.PESO_BRUTO_NF.ColumnName = "PESO_BRUTO_NF";
            this.PESO_BRUTO_NF.DataType = typeof(double);
            // 
            // PESO_LIQUIDO_NF
            // 
            this.PESO_LIQUIDO_NF.ColumnName = "PESO_LIQUIDO_NF";
            this.PESO_LIQUIDO_NF.DataType = typeof(double);
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "INF_COMPL_NF";
            this.dataColumn2.MaxLength = 5000;
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "TIPO_MVTO_NF";
            this.dataColumn3.MaxLength = 50;
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "OBS_NF";
            this.dataColumn4.MaxLength = 50;
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "VALOR_EXTENSO_NF";
            this.dataColumn6.MaxLength = 100;
            // 
            // dataColumn7
            // 
            this.dataColumn7.ColumnName = "ENTRADA_NF";
            this.dataColumn7.DataType = typeof(int);
            // 
            // dataColumn8
            // 
            this.dataColumn8.ColumnName = "SAIDA_NF";
            this.dataColumn8.DataType = typeof(int);
            // 
            // dataColumn19
            // 
            this.dataColumn19.ColumnName = "TRIBUTADA_NF";
            this.dataColumn19.DataType = typeof(int);
            // 
            // dataColumn20
            // 
            this.dataColumn20.ColumnName = "COBRANCA_NF";
            this.dataColumn20.DataType = typeof(int);
            // 
            // dataColumn21
            // 
            this.dataColumn21.ColumnName = "EXPORTACAO_NF";
            this.dataColumn21.DataType = typeof(int);
            // 
            // dataColumn22
            // 
            this.dataColumn22.ColumnName = "UF_EMBARQUE_EXPORTACAO";
            this.dataColumn22.MaxLength = 2;
            // 
            // dataColumn23
            // 
            this.dataColumn23.ColumnName = "LOCAL_EMBARQUE_EXPORTACAO";
            this.dataColumn23.MaxLength = 60;
            // 
            // dataColumn24
            // 
            this.dataColumn24.ColumnName = "BENEFICIAMENTO_NF";
            this.dataColumn24.DataType = typeof(int);
            // 
            // dataColumn25
            // 
            this.dataColumn25.ColumnName = "STATUS_NFE";
            this.dataColumn25.MaxLength = 200;
            // 
            // dataColumn26
            // 
            this.dataColumn26.ColumnName = "CHAVE_ACESSO_NFE";
            this.dataColumn26.MaxLength = 100;
            // 
            // dataColumn27
            // 
            this.dataColumn27.ColumnName = "VALOR_TOTAL_SERVICOS_NF";
            this.dataColumn27.DataType = typeof(double);
            // 
            // dataColumn28
            // 
            this.dataColumn28.ColumnName = "BASE_CALCULO_ISS_NF";
            this.dataColumn28.DataType = typeof(double);
            // 
            // dataColumn29
            // 
            this.dataColumn29.ColumnName = "VALOR_ISS_NF";
            this.dataColumn29.DataType = typeof(double);
            // 
            // dataColumn30
            // 
            this.dataColumn30.ColumnName = "RECIBO_NFE";
            this.dataColumn30.MaxLength = 100;
            // 
            // dataColumn33
            // 
            this.dataColumn33.ColumnName = "ENTRADA_SAIDA_NF";
            this.dataColumn33.DataType = typeof(int);
            // 
            // dataColumn34
            // 
            this.dataColumn34.ColumnName = "NATUREZA_OPERACAO_NF";
            this.dataColumn34.MaxLength = 200;
            // 
            // dataColumn38
            // 
            this.dataColumn38.ColumnName = "CNPJ_CLIENTE_FORN";
            this.dataColumn38.MaxLength = 30;
            // 
            // dataColumn40
            // 
            this.dataColumn40.ColumnName = "NFE_TESTE";
            this.dataColumn40.DataType = typeof(int);
            // 
            // dataColumn41
            // 
            this.dataColumn41.ColumnName = "N_PROTOCOLO_AUTORIZACAO_NF";
            this.dataColumn41.MaxLength = 200;
            // 
            // dataColumn42
            // 
            this.dataColumn42.ColumnName = "MOTIVO_CANCELAMENTO_NF";
            this.dataColumn42.MaxLength = 200;
            // 
            // dataColumn43
            // 
            this.dataColumn43.ColumnName = "NOTA_STRING_NF";
            this.dataColumn43.MaxLength = 9;
            // 
            // dataColumn44
            // 
            this.dataColumn44.ColumnName = "END_NUMERO_STRING_NF";
            this.dataColumn44.MaxLength = 250;
            // 
            // dataColumn45
            // 
            this.dataColumn45.ColumnName = "COD_BARRAS_NF";
            this.dataColumn45.DataType = typeof(byte[]);
            // 
            // dataColumn51
            // 
            this.dataColumn51.ColumnName = "NAO_TRIBUTADA_NF";
            this.dataColumn51.DataType = typeof(int);
            // 
            // dataColumn52
            // 
            this.dataColumn52.ColumnName = "PECAS_NF";
            this.dataColumn52.DataType = typeof(int);
            // 
            // dataColumn53
            // 
            this.dataColumn53.ColumnName = "TERMINAL_NF";
            this.dataColumn53.DataType = typeof(int);
            // 
            // dataColumn54
            // 
            this.dataColumn54.ColumnName = "IPI_SUSPENSO_NF";
            this.dataColumn54.DataType = typeof(int);
            // 
            // dataColumn55
            // 
            this.dataColumn55.ColumnName = "SUBST_TRIB_NF";
            this.dataColumn55.DataType = typeof(int);
            // 
            // dataColumn56
            // 
            this.dataColumn56.ColumnName = "ARRUELA_NF";
            this.dataColumn56.DataType = typeof(int);
            // 
            // dataColumn57
            // 
            this.dataColumn57.ColumnName = "DESCONTO_NF";
            this.dataColumn57.DataType = typeof(double);
            // 
            // dataColumn86
            // 
            this.dataColumn86.ColumnName = "DATA_AUTORIZACAO_NF";
            this.dataColumn86.DataType = typeof(System.DateTime);
            // 
            // dataColumn87
            // 
            this.dataColumn87.ColumnName = "HORA_AUTORIZACAO_NF";
            this.dataColumn87.MaxLength = 50;
            // 
            // dataColumn88
            // 
            this.dataColumn88.ColumnName = "ESTADO_CLIENTE_NF";
            this.dataColumn88.MaxLength = 2;
            // 
            // dataColumn93
            // 
            this.dataColumn93.ColumnName = "VALOR_SIMPLES_NF";
            this.dataColumn93.DataType = typeof(double);
            // 
            // dataColumn94
            // 
            this.dataColumn94.ColumnName = "ALIQUOTA_SIMPLES_NF";
            this.dataColumn94.DataType = typeof(double);
            // 
            // dataColumn95
            // 
            this.dataColumn95.ColumnName = "REFERENCIADA_NF";
            this.dataColumn95.DataType = typeof(int);
            // 
            // dataColumn96
            // 
            this.dataColumn96.ColumnName = "N_NF_REFERENCIADA_NF";
            this.dataColumn96.MaxLength = 300;
            // 
            // dataColumn98
            // 
            this.dataColumn98.ColumnName = "SEQUENCIAL_CORRECAO_NF";
            // 
            // dataColumn99
            // 
            this.dataColumn99.ColumnName = "TEXTO_CORRECAO_NF";
            this.dataColumn99.MaxLength = 5000;
            // 
            // dataColumn102
            // 
            this.dataColumn102.Caption = "TOTAL_TRIB_NF";
            this.dataColumn102.ColumnName = "TOTAL_TRIB_NF";
            this.dataColumn102.DataType = typeof(double);
            // 
            // dataColumn105
            // 
            this.dataColumn105.ColumnName = "CNPJ_EMISSOR_NF";
            // 
            // dataColumn106
            // 
            this.dataColumn106.ColumnName = "RAZAO_EMISSOR_NF";
            // 
            // dataColumn108
            // 
            this.dataColumn108.ColumnName = "FINALIDADE_NF";
            this.dataColumn108.MaxLength = 1;
            // 
            // dataColumn109
            // 
            this.dataColumn109.ColumnName = "INF_FISCO_NF";
            this.dataColumn109.MaxLength = 2000;
            // 
            // tb_saida
            // 
            this.tb_saida.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsNota_fiscal, "NOTA_FISCAL.DATA_ENTR_SAI_NF", true));
            this.tb_saida.Location = new System.Drawing.Point(299, 59);
            this.tb_saida.Name = "tb_saida";
            this.tb_saida.Size = new System.Drawing.Size(81, 20);
            this.tb_saida.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(169, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Data Entrada/Saída:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(169, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Cliente/Fornecedor: *";
            // 
            // dsClientes
            // 
            this.dsClientes.DataSetName = "dsClientes";
            this.dsClientes.Namespace = "http://www.tempuri.org/dsClientes.xsd";
            this.dsClientes.Tables.AddRange(new System.Data.DataTable[] {
            this.CLIENTES});
            // 
            // CLIENTES
            // 
            this.CLIENTES.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_CLIENTE,
            this.RAZAO_SOCIAL,
            this.NOME_FANTASIA,
            this.IE,
            this.CNPJ,
            this.IM,
            this.ENDERECO,
            this.BAIRRO,
            this.CIDADE,
            this.ESTADO,
            this.PAIS,
            this.CEP_CLIENTE,
            this.FONE,
            this.EMAIL,
            this.CONTATO1,
            this.FONE1,
            this.EMAIL1,
            this.CONTATO2,
            this.FONE2,
            this.EMAIL2,
            this.SITUACAO,
            this.TIPO,
            this.TRANSPORTADORA_CLIENTE,
            this.ATIVIDADE_CLIENTE,
            this.BANCO_CLIENTE,
            this.AGENCIA_CLIENTE,
            this.REGIAO,
            this.VENDEDOR_CLIENTE,
            this.DATA_CADASTRO_CLIENTE,
            this.ETIQUETA,
            this.dataColumn10});
            this.CLIENTES.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "RAZAO_SOCIAL"}, true)});
            this.CLIENTES.PrimaryKey = new System.Data.DataColumn[] {
        this.RAZAO_SOCIAL};
            this.CLIENTES.TableName = "CLIENTES";
            // 
            // COD_CLIENTE
            // 
            this.COD_CLIENTE.ColumnName = "COD_CLIENTE";
            this.COD_CLIENTE.DataType = typeof(int);
            // 
            // RAZAO_SOCIAL
            // 
            this.RAZAO_SOCIAL.AllowDBNull = false;
            this.RAZAO_SOCIAL.ColumnName = "RAZAO_SOCIAL";
            this.RAZAO_SOCIAL.MaxLength = 50;
            // 
            // NOME_FANTASIA
            // 
            this.NOME_FANTASIA.ColumnName = "NOME_FANTASIA";
            this.NOME_FANTASIA.MaxLength = 50;
            // 
            // IE
            // 
            this.IE.ColumnName = "IE";
            this.IE.MaxLength = 20;
            // 
            // CNPJ
            // 
            this.CNPJ.ColumnName = "CNPJ";
            this.CNPJ.MaxLength = 30;
            // 
            // IM
            // 
            this.IM.ColumnName = "IM";
            this.IM.MaxLength = 20;
            // 
            // ENDERECO
            // 
            this.ENDERECO.ColumnName = "ENDERECO";
            this.ENDERECO.MaxLength = 50;
            // 
            // BAIRRO
            // 
            this.BAIRRO.ColumnName = "BAIRRO";
            this.BAIRRO.MaxLength = 30;
            // 
            // CIDADE
            // 
            this.CIDADE.ColumnName = "CIDADE";
            this.CIDADE.MaxLength = 35;
            // 
            // ESTADO
            // 
            this.ESTADO.ColumnName = "ESTADO";
            this.ESTADO.MaxLength = 2;
            // 
            // PAIS
            // 
            this.PAIS.ColumnName = "PAIS";
            this.PAIS.MaxLength = 20;
            // 
            // CEP_CLIENTE
            // 
            this.CEP_CLIENTE.ColumnName = "CEP_CLIENTE";
            this.CEP_CLIENTE.MaxLength = 18;
            // 
            // FONE
            // 
            this.FONE.ColumnName = "FONE";
            this.FONE.MaxLength = 14;
            // 
            // EMAIL
            // 
            this.EMAIL.ColumnName = "EMAIL";
            this.EMAIL.MaxLength = 30;
            // 
            // CONTATO1
            // 
            this.CONTATO1.ColumnName = "CONTATO1";
            this.CONTATO1.MaxLength = 40;
            // 
            // FONE1
            // 
            this.FONE1.ColumnName = "FONE1";
            this.FONE1.MaxLength = 14;
            // 
            // EMAIL1
            // 
            this.EMAIL1.ColumnName = "EMAIL1";
            this.EMAIL1.MaxLength = 30;
            // 
            // CONTATO2
            // 
            this.CONTATO2.ColumnName = "CONTATO2";
            this.CONTATO2.MaxLength = 40;
            // 
            // FONE2
            // 
            this.FONE2.ColumnName = "FONE2";
            this.FONE2.MaxLength = 14;
            // 
            // EMAIL2
            // 
            this.EMAIL2.ColumnName = "EMAIL2";
            this.EMAIL2.MaxLength = 30;
            // 
            // SITUACAO
            // 
            this.SITUACAO.ColumnName = "SITUACAO";
            this.SITUACAO.MaxLength = 40;
            // 
            // TIPO
            // 
            this.TIPO.ColumnName = "TIPO";
            this.TIPO.MaxLength = 40;
            // 
            // TRANSPORTADORA_CLIENTE
            // 
            this.TRANSPORTADORA_CLIENTE.ColumnName = "TRANSPORTADORA_CLIENTE";
            this.TRANSPORTADORA_CLIENTE.MaxLength = 80;
            // 
            // ATIVIDADE_CLIENTE
            // 
            this.ATIVIDADE_CLIENTE.ColumnName = "ATIVIDADE_CLIENTE";
            this.ATIVIDADE_CLIENTE.MaxLength = 50;
            // 
            // BANCO_CLIENTE
            // 
            this.BANCO_CLIENTE.ColumnName = "BANCO_CLIENTE";
            this.BANCO_CLIENTE.MaxLength = 10;
            // 
            // AGENCIA_CLIENTE
            // 
            this.AGENCIA_CLIENTE.ColumnName = "AGENCIA_CLIENTE";
            this.AGENCIA_CLIENTE.MaxLength = 10;
            // 
            // REGIAO
            // 
            this.REGIAO.ColumnName = "REGIAO";
            this.REGIAO.MaxLength = 20;
            // 
            // VENDEDOR_CLIENTE
            // 
            this.VENDEDOR_CLIENTE.ColumnName = "VENDEDOR_CLIENTE";
            this.VENDEDOR_CLIENTE.MaxLength = 40;
            // 
            // DATA_CADASTRO_CLIENTE
            // 
            this.DATA_CADASTRO_CLIENTE.ColumnName = "DATA_CADASTRO_CLIENTE";
            this.DATA_CADASTRO_CLIENTE.DataType = typeof(System.DateTime);
            // 
            // ETIQUETA
            // 
            this.ETIQUETA.ColumnName = "ETIQUETA";
            this.ETIQUETA.MaxLength = 10;
            // 
            // dataColumn10
            // 
            this.dataColumn10.ColumnName = "CLASS_FISCAL_CLIENTE";
            this.dataColumn10.MaxLength = 50;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Transportadora:";
            // 
            // dsTransportadoras
            // 
            this.dsTransportadoras.DataSetName = "dsTransportadoras";
            this.dsTransportadoras.Namespace = "http://www.tempuri.org/dsTransportadoras.xsd";
            this.dsTransportadoras.Tables.AddRange(new System.Data.DataTable[] {
            this.TRANSPORTADORAS});
            // 
            // TRANSPORTADORAS
            // 
            this.TRANSPORTADORAS.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_TRANSPORTADORA,
            this.SITUACAO_TRANSPORTADORA,
            this.NOME_TRANSPORTADORA,
            this.RAZAO_SOCIAL_TRANSPORTADORA,
            this.ENDERECO_TRANSPORTADORA,
            this.BAIRRO_TRANSPORTADORA,
            this.CIDADE_TRANSPORTADORA,
            this.ESTADO_TRANSPORTADORA,
            this.PAIS_TRANSPORTADORA,
            this.CNPJ_TRANSPORTADORA,
            this.IE_TRANSPORTADORA,
            this.DATA_INSCRICAO_TRANSPORTADORA,
            this.TEL_1_TRANSPORTADORA,
            this.TEL_2_TRANSPORTADORA,
            this.CONTATO_1_TRANSPORTADORA,
            this.CONTATO_2_TRANSPORTADORA,
            this.EMAIL_1_TRANSPORTADORA,
            this.EMAIL_2_TRANSPORTADORA,
            this.FONE_TRANSPORTADORA,
            this.EMAIL_TRANSPORTADORA,
            this.IM_TRANSPORTADORA});
            this.TRANSPORTADORAS.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_TRANSPORTADORA"}, true)});
            this.TRANSPORTADORAS.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_TRANSPORTADORA};
            this.TRANSPORTADORAS.TableName = "TRANSPORTADORAS";
            // 
            // COD_TRANSPORTADORA
            // 
            this.COD_TRANSPORTADORA.AllowDBNull = false;
            this.COD_TRANSPORTADORA.ColumnName = "COD_TRANSPORTADORA";
            this.COD_TRANSPORTADORA.DataType = typeof(int);
            // 
            // SITUACAO_TRANSPORTADORA
            // 
            this.SITUACAO_TRANSPORTADORA.ColumnName = "SITUACAO_TRANSPORTADORA";
            this.SITUACAO_TRANSPORTADORA.DataType = typeof(int);
            // 
            // NOME_TRANSPORTADORA
            // 
            this.NOME_TRANSPORTADORA.ColumnName = "NOME_TRANSPORTADORA";
            this.NOME_TRANSPORTADORA.MaxLength = 60;
            // 
            // RAZAO_SOCIAL_TRANSPORTADORA
            // 
            this.RAZAO_SOCIAL_TRANSPORTADORA.ColumnName = "RAZAO_SOCIAL_TRANSPORTADORA";
            this.RAZAO_SOCIAL_TRANSPORTADORA.MaxLength = 60;
            // 
            // ENDERECO_TRANSPORTADORA
            // 
            this.ENDERECO_TRANSPORTADORA.ColumnName = "ENDERECO_TRANSPORTADORA";
            this.ENDERECO_TRANSPORTADORA.MaxLength = 60;
            // 
            // BAIRRO_TRANSPORTADORA
            // 
            this.BAIRRO_TRANSPORTADORA.ColumnName = "BAIRRO_TRANSPORTADORA";
            this.BAIRRO_TRANSPORTADORA.MaxLength = 40;
            // 
            // CIDADE_TRANSPORTADORA
            // 
            this.CIDADE_TRANSPORTADORA.ColumnName = "CIDADE_TRANSPORTADORA";
            this.CIDADE_TRANSPORTADORA.MaxLength = 30;
            // 
            // ESTADO_TRANSPORTADORA
            // 
            this.ESTADO_TRANSPORTADORA.ColumnName = "ESTADO_TRANSPORTADORA";
            this.ESTADO_TRANSPORTADORA.MaxLength = 10;
            // 
            // PAIS_TRANSPORTADORA
            // 
            this.PAIS_TRANSPORTADORA.ColumnName = "PAIS_TRANSPORTADORA";
            this.PAIS_TRANSPORTADORA.MaxLength = 40;
            // 
            // CNPJ_TRANSPORTADORA
            // 
            this.CNPJ_TRANSPORTADORA.ColumnName = "CNPJ_TRANSPORTADORA";
            this.CNPJ_TRANSPORTADORA.MaxLength = 25;
            // 
            // IE_TRANSPORTADORA
            // 
            this.IE_TRANSPORTADORA.ColumnName = "IE_TRANSPORTADORA";
            this.IE_TRANSPORTADORA.MaxLength = 25;
            // 
            // DATA_INSCRICAO_TRANSPORTADORA
            // 
            this.DATA_INSCRICAO_TRANSPORTADORA.ColumnName = "DATA_INSCRICAO_TRANSPORTADORA";
            this.DATA_INSCRICAO_TRANSPORTADORA.DataType = typeof(System.DateTime);
            // 
            // TEL_1_TRANSPORTADORA
            // 
            this.TEL_1_TRANSPORTADORA.ColumnName = "TEL_1_TRANSPORTADORA";
            this.TEL_1_TRANSPORTADORA.MaxLength = 20;
            // 
            // TEL_2_TRANSPORTADORA
            // 
            this.TEL_2_TRANSPORTADORA.ColumnName = "TEL_2_TRANSPORTADORA";
            this.TEL_2_TRANSPORTADORA.MaxLength = 20;
            // 
            // CONTATO_1_TRANSPORTADORA
            // 
            this.CONTATO_1_TRANSPORTADORA.ColumnName = "CONTATO_1_TRANSPORTADORA";
            this.CONTATO_1_TRANSPORTADORA.MaxLength = 20;
            // 
            // CONTATO_2_TRANSPORTADORA
            // 
            this.CONTATO_2_TRANSPORTADORA.ColumnName = "CONTATO_2_TRANSPORTADORA";
            this.CONTATO_2_TRANSPORTADORA.MaxLength = 20;
            // 
            // EMAIL_1_TRANSPORTADORA
            // 
            this.EMAIL_1_TRANSPORTADORA.ColumnName = "EMAIL_1_TRANSPORTADORA";
            this.EMAIL_1_TRANSPORTADORA.MaxLength = 40;
            // 
            // EMAIL_2_TRANSPORTADORA
            // 
            this.EMAIL_2_TRANSPORTADORA.ColumnName = "EMAIL_2_TRANSPORTADORA";
            this.EMAIL_2_TRANSPORTADORA.MaxLength = 40;
            // 
            // FONE_TRANSPORTADORA
            // 
            this.FONE_TRANSPORTADORA.ColumnName = "FONE_TRANSPORTADORA";
            this.FONE_TRANSPORTADORA.MaxLength = 20;
            // 
            // EMAIL_TRANSPORTADORA
            // 
            this.EMAIL_TRANSPORTADORA.ColumnName = "EMAIL_TRANSPORTADORA";
            this.EMAIL_TRANSPORTADORA.MaxLength = 40;
            // 
            // IM_TRANSPORTADORA
            // 
            this.IM_TRANSPORTADORA.ColumnName = "IM_TRANSPORTADORA";
            this.IM_TRANSPORTADORA.MaxLength = 20;
            // 
            // tb_base_calc_icm
            // 
            this.tb_base_calc_icm.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsNota_fiscal, "NOTA_FISCAL.BASE_CALC_ICMS_NF", true));
            this.tb_base_calc_icm.Location = new System.Drawing.Point(16, 17);
            this.tb_base_calc_icm.Name = "tb_base_calc_icm";
            this.tb_base_calc_icm.Size = new System.Drawing.Size(98, 20);
            this.tb_base_calc_icm.TabIndex = 200;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Base de Cálc. ICMS";
            // 
            // tb_valor_icm
            // 
            this.tb_valor_icm.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsNota_fiscal, "NOTA_FISCAL.VALOR_ICMS_NF", true));
            this.tb_valor_icm.Location = new System.Drawing.Point(120, 17);
            this.tb_valor_icm.Name = "tb_valor_icm";
            this.tb_valor_icm.Size = new System.Drawing.Size(98, 20);
            this.tb_valor_icm.TabIndex = 201;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(117, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Valor do ICMS";
            // 
            // tb_base_cal_icm_st
            // 
            this.tb_base_cal_icm_st.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsNota_fiscal, "NOTA_FISCAL.BASE_CALC_ICM_SUBS", true));
            this.tb_base_cal_icm_st.Location = new System.Drawing.Point(224, 17);
            this.tb_base_cal_icm_st.Name = "tb_base_cal_icm_st";
            this.tb_base_cal_icm_st.Size = new System.Drawing.Size(98, 20);
            this.tb_base_cal_icm_st.TabIndex = 202;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(221, 4);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "B. Calc. ICMS Subs";
            // 
            // tb_valor_icm_st
            // 
            this.tb_valor_icm_st.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsNota_fiscal, "NOTA_FISCAL.VALOR_ICM_SUBS", true));
            this.tb_valor_icm_st.Location = new System.Drawing.Point(328, 17);
            this.tb_valor_icm_st.Name = "tb_valor_icm_st";
            this.tb_valor_icm_st.Size = new System.Drawing.Size(98, 20);
            this.tb_valor_icm_st.TabIndex = 203;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(325, 4);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Valor ICMS Subs";
            // 
            // tb_total_prod
            // 
            this.tb_total_prod.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsNota_fiscal, "NOTA_FISCAL.VALOR_TOT_PROD_NF", true));
            this.tb_total_prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_total_prod.Location = new System.Drawing.Point(439, 19);
            this.tb_total_prod.Name = "tb_total_prod";
            this.tb_total_prod.Size = new System.Drawing.Size(131, 31);
            this.tb_total_prod.TabIndex = 209;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(442, 3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(121, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "Valor Total dos Produtos";
            // 
            // tb_valor_ipi
            // 
            this.tb_valor_ipi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsNota_fiscal, "NOTA_FISCAL.VALOR_IPI_NF", true));
            this.tb_valor_ipi.Location = new System.Drawing.Point(328, 50);
            this.tb_valor_ipi.Name = "tb_valor_ipi";
            this.tb_valor_ipi.Size = new System.Drawing.Size(98, 20);
            this.tb_valor_ipi.TabIndex = 207;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(326, 37);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 13);
            this.label16.TabIndex = 37;
            this.label16.Text = "Valor Total IPI";
            // 
            // tb_outras_des_ace
            // 
            this.tb_outras_des_ace.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsNota_fiscal, "NOTA_FISCAL.OUTRAS_DESP_NF", true));
            this.tb_outras_des_ace.Location = new System.Drawing.Point(224, 50);
            this.tb_outras_des_ace.Name = "tb_outras_des_ace";
            this.tb_outras_des_ace.Size = new System.Drawing.Size(98, 20);
            this.tb_outras_des_ace.TabIndex = 206;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(222, 37);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(97, 13);
            this.label17.TabIndex = 35;
            this.label17.Text = "Outras Desp Acess";
            // 
            // tb_valor_seg
            // 
            this.tb_valor_seg.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsNota_fiscal, "NOTA_FISCAL.VALOR_SEGURO_NF", true));
            this.tb_valor_seg.Location = new System.Drawing.Point(120, 50);
            this.tb_valor_seg.Name = "tb_valor_seg";
            this.tb_valor_seg.Size = new System.Drawing.Size(98, 20);
            this.tb_valor_seg.TabIndex = 205;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(118, 37);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(83, 13);
            this.label18.TabIndex = 33;
            this.label18.Text = "Valor do Seguro";
            // 
            // tb_valor_fre
            // 
            this.tb_valor_fre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsNota_fiscal, "NOTA_FISCAL.VALOR_FRETE_NF", true));
            this.tb_valor_fre.Location = new System.Drawing.Point(16, 50);
            this.tb_valor_fre.Name = "tb_valor_fre";
            this.tb_valor_fre.Size = new System.Drawing.Size(98, 20);
            this.tb_valor_fre.TabIndex = 204;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(14, 37);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 13);
            this.label19.TabIndex = 31;
            this.label19.Text = "Valor do Frete";
            // 
            // tb_total_nota
            // 
            this.tb_total_nota.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsNota_fiscal, "NOTA_FISCAL.VALOR_NOTA_NF", true));
            this.tb_total_nota.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_total_nota.Location = new System.Drawing.Point(440, 69);
            this.tb_total_nota.Name = "tb_total_nota";
            this.tb_total_nota.Size = new System.Drawing.Size(131, 31);
            this.tb_total_nota.TabIndex = 210;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(442, 53);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(96, 13);
            this.label20.TabIndex = 39;
            this.label20.Text = "Valor Total da Nota";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(7, 32);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(108, 13);
            this.label21.TabIndex = 41;
            this.label21.Text = "Frete por Conta: *";
            // 
            // tb_marca
            // 
            this.tb_marca.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsNota_fiscal, "NOTA_FISCAL.MARCA_NF", true));
            this.tb_marca.Location = new System.Drawing.Point(183, 14);
            this.tb_marca.Name = "tb_marca";
            this.tb_marca.Size = new System.Drawing.Size(78, 20);
            this.tb_marca.TabIndex = 23;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(180, 1);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(36, 13);
            this.label23.TabIndex = 47;
            this.label23.Text = "Marca";
            // 
            // tb_especie
            // 
            this.tb_especie.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsNota_fiscal, "NOTA_FISCAL.ESPECIE_NF", true));
            this.tb_especie.Location = new System.Drawing.Point(78, 14);
            this.tb_especie.Name = "tb_especie";
            this.tb_especie.Size = new System.Drawing.Size(94, 20);
            this.tb_especie.TabIndex = 22;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(79, 1);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(44, 13);
            this.label24.TabIndex = 45;
            this.label24.Text = "Espécie";
            // 
            // tb_qtde_volume
            // 
            this.tb_qtde_volume.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsNota_fiscal, "NOTA_FISCAL.QTDE_NF", true));
            this.tb_qtde_volume.Location = new System.Drawing.Point(8, 14);
            this.tb_qtde_volume.Name = "tb_qtde_volume";
            this.tb_qtde_volume.Size = new System.Drawing.Size(59, 20);
            this.tb_qtde_volume.TabIndex = 21;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(5, 1);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(62, 13);
            this.label25.TabIndex = 43;
            this.label25.Text = "Quantidade";
            // 
            // tb_peso_bruto
            // 
            this.tb_peso_bruto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsNota_fiscal, "NOTA_FISCAL.PESO_BRUTO_NF", true));
            this.tb_peso_bruto.Location = new System.Drawing.Point(68, 36);
            this.tb_peso_bruto.Name = "tb_peso_bruto";
            this.tb_peso_bruto.Size = new System.Drawing.Size(58, 20);
            this.tb_peso_bruto.TabIndex = 24;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(4, 40);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(62, 13);
            this.label26.TabIndex = 51;
            this.label26.Text = "Peso Bruto:";
            // 
            // tb_peso_liquido
            // 
            this.tb_peso_liquido.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsNota_fiscal, "NOTA_FISCAL.PESO_LIQUIDO_NF", true));
            this.tb_peso_liquido.Location = new System.Drawing.Point(208, 36);
            this.tb_peso_liquido.Name = "tb_peso_liquido";
            this.tb_peso_liquido.Size = new System.Drawing.Size(53, 20);
            this.tb_peso_liquido.TabIndex = 25;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(132, 40);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(71, 13);
            this.label27.TabIndex = 53;
            this.label27.Text = "Peso Líquido:";
            // 
            // tb_dados_adicionais
            // 
            this.tb_dados_adicionais.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsNota_fiscal, "NOTA_FISCAL.INF_COMPL_NF", true));
            this.tb_dados_adicionais.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_dados_adicionais.Location = new System.Drawing.Point(7, 532);
            this.tb_dados_adicionais.Multiline = true;
            this.tb_dados_adicionais.Name = "tb_dados_adicionais";
            this.tb_dados_adicionais.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_dados_adicionais.Size = new System.Drawing.Size(291, 109);
            this.tb_dados_adicionais.TabIndex = 26;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(6, 516);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(89, 13);
            this.label29.TabIndex = 89;
            this.label29.Text = "Dados Adicionais";
            // 
            // tb_data_emissao
            // 
            this.tb_data_emissao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsNota_fiscal, "NOTA_FISCAL.DATA_EMISSAO_NF", true));
            this.tb_data_emissao.Location = new System.Drawing.Point(299, 37);
            this.tb_data_emissao.Name = "tb_data_emissao";
            this.tb_data_emissao.Size = new System.Drawing.Size(81, 20);
            this.tb_data_emissao.TabIndex = 7;
            this.tb_data_emissao.TextChanged += new System.EventHandler(this.tb_data_emissao_TextChanged);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(169, 40);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(97, 13);
            this.label30.TabIndex = 91;
            this.label30.Text = "Data Emissão: *";
            // 
            // textBox23
            // 
            this.textBox23.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsNota_fiscal, "NOTA_FISCAL.PLACA_VEICULO_NF", true));
            this.textBox23.Location = new System.Drawing.Point(343, 31);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(83, 20);
            this.textBox23.TabIndex = 94;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(303, 34);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(34, 13);
            this.label31.TabIndex = 93;
            this.label31.Text = "Placa";
            // 
            // datItens_nota
            // 
            this.datItens_nota.DeleteCommand = this.fbCommand4;
            this.datItens_nota.InsertCommand = this.fbCommand2;
            this.datItens_nota.SelectCommand = this.fbCommand1;
            this.datItens_nota.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * from itens_nota order by cod_itens_nota";
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
            this.dataColumn5,
            this.dataColumn9,
            this.dataColumn15,
            this.dataColumn14,
            this.dataColumn31,
            this.dataColumn36,
            this.dataColumn39,
            this.dataColumn49,
            this.dataColumn50,
            this.dataColumn58,
            this.dataColumn59,
            this.dataColumn60,
            this.dataColumn61,
            this.dataColumn62,
            this.dataColumn63,
            this.dataColumn64,
            this.dataColumn65,
            this.dataColumn66,
            this.dataColumn67,
            this.dataColumn68,
            this.dataColumn69,
            this.dataColumn70,
            this.dataColumn71,
            this.dataColumn72,
            this.dataColumn73,
            this.dataColumn74,
            this.dataColumn75,
            this.dataColumn76,
            this.dataColumn77,
            this.dataColumn78,
            this.dataColumn79,
            this.dataColumn80,
            this.dataColumn81,
            this.dataColumn82,
            this.dataColumn83,
            this.dataColumn84,
            this.dataColumn85,
            this.dataColumn89,
            this.dataColumn90,
            this.dataColumn91,
            this.dataColumn92,
            this.dataColumn32,
            this.dataColumn35,
            this.dataColumn97,
            this.dataColumn100,
            this.dataColumn101,
            this.dataColumn104,
            this.dataColumn110,
            this.dataColumn111,
            this.dataColumn112,
            this.dataColumn37,
            this.dataColumn113,
            this.dataColumn114,
            this.dataColumn115,
            this.dataColumn116,
            this.dataColumn117,
            this.dataColumn118,
            this.dataColumn120,
            this.dataColumn121,
            this.dataColumn119,
            this.dataColumn122,
            this.dataColumn123,
            this.dataColumn124,
            this.dataColumn125,
            this.dataColumn126,
            this.dataColumn127,
            this.dataColumn128,
            this.dataColumn129});
            this.ITENS_NOTA.TableName = "ITENS_NOTA";
            // 
            // COD_ITENS_NOTA
            // 
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
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "VALOR_IPI_ITEM";
            this.dataColumn5.DataType = typeof(double);
            // 
            // dataColumn9
            // 
            this.dataColumn9.ColumnName = "PEDIDO_COMPRA_ITEM";
            this.dataColumn9.MaxLength = 20;
            // 
            // dataColumn15
            // 
            this.dataColumn15.ColumnName = "MAE_ITEM";
            this.dataColumn15.DataType = typeof(int);
            // 
            // dataColumn14
            // 
            this.dataColumn14.ColumnName = "NCM_ITEM";
            this.dataColumn14.MaxLength = 20;
            // 
            // dataColumn31
            // 
            this.dataColumn31.ColumnName = "CFOP_ITEM";
            this.dataColumn31.MaxLength = 10;
            // 
            // dataColumn36
            // 
            this.dataColumn36.ColumnName = "PRESTACAO_SERVICO_ITEM";
            this.dataColumn36.DataType = typeof(int);
            // 
            // dataColumn39
            // 
            this.dataColumn39.ColumnName = "COD_ITEM";
            this.dataColumn39.MaxLength = 50;
            // 
            // dataColumn49
            // 
            this.dataColumn49.ColumnName = "VALOR_BC_ICMS_ST_ITEM";
            this.dataColumn49.DataType = typeof(double);
            // 
            // dataColumn50
            // 
            this.dataColumn50.ColumnName = "VALOR_ICMS_ST_ITEM";
            this.dataColumn50.DataType = typeof(double);
            // 
            // dataColumn58
            // 
            this.dataColumn58.ColumnName = "VALOR_FRETE_ITEM";
            this.dataColumn58.DataType = typeof(double);
            // 
            // dataColumn59
            // 
            this.dataColumn59.ColumnName = "VALOR_DESCONTO_ITEM";
            this.dataColumn59.DataType = typeof(double);
            // 
            // dataColumn60
            // 
            this.dataColumn60.ColumnName = "VALOR_SEGURO_ITEM";
            this.dataColumn60.DataType = typeof(double);
            // 
            // dataColumn61
            // 
            this.dataColumn61.ColumnName = "VALOR_OUTRAS_DESP_ITEM";
            this.dataColumn61.DataType = typeof(double);
            // 
            // dataColumn62
            // 
            this.dataColumn62.ColumnName = "IVA_ITEM";
            this.dataColumn62.DataType = typeof(double);
            // 
            // dataColumn63
            // 
            this.dataColumn63.ColumnName = "REDUCAO_ITEM";
            this.dataColumn63.DataType = typeof(double);
            // 
            // dataColumn64
            // 
            this.dataColumn64.ColumnName = "COFINS_ITEM";
            this.dataColumn64.DataType = typeof(double);
            // 
            // dataColumn65
            // 
            this.dataColumn65.ColumnName = "VALOR_COFINS_ITEM";
            this.dataColumn65.DataType = typeof(double);
            // 
            // dataColumn66
            // 
            this.dataColumn66.ColumnName = "PIS_ITEM";
            this.dataColumn66.DataType = typeof(double);
            // 
            // dataColumn67
            // 
            this.dataColumn67.ColumnName = "VALOR_PIS_ITEM";
            this.dataColumn67.DataType = typeof(double);
            // 
            // dataColumn68
            // 
            this.dataColumn68.ColumnName = "ORIGEM_ITEM";
            this.dataColumn68.MaxLength = 1;
            // 
            // dataColumn69
            // 
            this.dataColumn69.ColumnName = "MOD_BC_ITEM";
            this.dataColumn69.MaxLength = 100;
            // 
            // dataColumn70
            // 
            this.dataColumn70.ColumnName = "ISS_ITEM";
            this.dataColumn70.DataType = typeof(double);
            // 
            // dataColumn71
            // 
            this.dataColumn71.ColumnName = "MOD_BC_ST_ITEM";
            this.dataColumn71.MaxLength = 100;
            // 
            // dataColumn72
            // 
            this.dataColumn72.ColumnName = "REDUCAO_ST_ITEM";
            this.dataColumn72.DataType = typeof(double);
            // 
            // dataColumn73
            // 
            this.dataColumn73.ColumnName = "ICMS_ST_ITEM";
            this.dataColumn73.DataType = typeof(double);
            // 
            // dataColumn74
            // 
            this.dataColumn74.ColumnName = "ALIQUOTA_CREDITO_ITEM";
            this.dataColumn74.DataType = typeof(double);
            // 
            // dataColumn75
            // 
            this.dataColumn75.ColumnName = "VALOR_CREDITO_ITEM";
            this.dataColumn75.DataType = typeof(double);
            // 
            // dataColumn76
            // 
            this.dataColumn76.ColumnName = "IPI_TRIB_ITEM";
            this.dataColumn76.DataType = typeof(int);
            // 
            // dataColumn77
            // 
            this.dataColumn77.ColumnName = "IPI_N_TRIB_ITEM";
            this.dataColumn77.DataType = typeof(int);
            // 
            // dataColumn78
            // 
            this.dataColumn78.ColumnName = "CST_IPI_TRIB_ITEM";
            this.dataColumn78.MaxLength = 100;
            // 
            // dataColumn79
            // 
            this.dataColumn79.ColumnName = "CST_IPI_N_TRIB_ITEM";
            this.dataColumn79.MaxLength = 100;
            // 
            // dataColumn80
            // 
            this.dataColumn80.ColumnName = "TIPO_PIS_ITEM";
            this.dataColumn80.MaxLength = 100;
            // 
            // dataColumn81
            // 
            this.dataColumn81.ColumnName = "CST_PIS_ITEM";
            this.dataColumn81.MaxLength = 200;
            // 
            // dataColumn82
            // 
            this.dataColumn82.ColumnName = "TIPO_COFINS_ITEM";
            this.dataColumn82.MaxLength = 100;
            // 
            // dataColumn83
            // 
            this.dataColumn83.ColumnName = "CST_COFINS_ITEM";
            this.dataColumn83.MaxLength = 200;
            // 
            // dataColumn84
            // 
            this.dataColumn84.ColumnName = "TIPO_SERVICO_ITEM";
            this.dataColumn84.MaxLength = 100;
            // 
            // dataColumn85
            // 
            this.dataColumn85.ColumnName = "ITEM_PEDIDO_COMPRA_ITEM";
            this.dataColumn85.MaxLength = 100;
            // 
            // dataColumn89
            // 
            this.dataColumn89.ColumnName = "BC_IPI_ITEM";
            this.dataColumn89.DataType = typeof(double);
            // 
            // dataColumn90
            // 
            this.dataColumn90.ColumnName = "BC_PIS_ITEM";
            this.dataColumn90.DataType = typeof(double);
            // 
            // dataColumn91
            // 
            this.dataColumn91.ColumnName = "BC_COFINS_ITEM";
            this.dataColumn91.DataType = typeof(double);
            // 
            // dataColumn92
            // 
            this.dataColumn92.ColumnName = "BC_ISS_ITEM";
            this.dataColumn92.DataType = typeof(double);
            // 
            // dataColumn32
            // 
            this.dataColumn32.ColumnName = "VALOR_ICM_ITEM";
            this.dataColumn32.DataType = typeof(double);
            // 
            // dataColumn35
            // 
            this.dataColumn35.ColumnName = "VALOR_ISS_ITEM";
            this.dataColumn35.DataType = typeof(double);
            // 
            // dataColumn97
            // 
            this.dataColumn97.ColumnName = "COD_EAN_ITEM";
            this.dataColumn97.MaxLength = 100;
            // 
            // dataColumn100
            // 
            this.dataColumn100.Caption = "PORC_TRIB_ITEM";
            this.dataColumn100.ColumnName = "PORC_TRIB_ITEM";
            this.dataColumn100.DataType = typeof(double);
            // 
            // dataColumn101
            // 
            this.dataColumn101.Caption = "TOTAL_TRIB_ITEM";
            this.dataColumn101.ColumnName = "TOTAL_TRIB_ITEM";
            this.dataColumn101.DataType = typeof(double);
            // 
            // dataColumn104
            // 
            this.dataColumn104.ColumnName = "CEST_ITEM";
            this.dataColumn104.MaxLength = 20;
            // 
            // dataColumn110
            // 
            this.dataColumn110.ColumnName = "PORC_IPI_DEV_ITEM";
            this.dataColumn110.DataType = typeof(double);
            // 
            // dataColumn111
            // 
            this.dataColumn111.ColumnName = "VALOR_IPI_DEV_ITEM";
            this.dataColumn111.DataType = typeof(double);
            // 
            // dataColumn112
            // 
            this.dataColumn112.ColumnName = "N_NF_ENT_ITEM";
            this.dataColumn112.DataType = typeof(int);
            // 
            // dataColumn37
            // 
            this.dataColumn37.ColumnName = "VALOR_BC_ITEM";
            this.dataColumn37.DataType = typeof(double);
            // 
            // dataColumn113
            // 
            this.dataColumn113.ColumnName = "DI_ITEM";
            // 
            // dataColumn114
            // 
            this.dataColumn114.ColumnName = "DATA_DI";
            this.dataColumn114.DataType = typeof(System.DateTime);
            // 
            // dataColumn115
            // 
            this.dataColumn115.ColumnName = "LOCAL_DES_ITEM";
            // 
            // dataColumn116
            // 
            this.dataColumn116.ColumnName = "UF_DES_ITEM";
            // 
            // dataColumn117
            // 
            this.dataColumn117.ColumnName = "DATA_DES_ITEM";
            this.dataColumn117.DataType = typeof(System.DateTime);
            // 
            // dataColumn118
            // 
            this.dataColumn118.ColumnName = "COD_EXP_ITEM";
            // 
            // dataColumn120
            // 
            this.dataColumn120.ColumnName = "BC_II_ITEM";
            this.dataColumn120.DataType = typeof(double);
            // 
            // dataColumn121
            // 
            this.dataColumn121.ColumnName = "VALOR_II_ITEM";
            this.dataColumn121.DataType = typeof(double);
            // 
            // dataColumn119
            // 
            this.dataColumn119.ColumnName = "DESP_ADUANEIRAS_ITEM";
            this.dataColumn119.DataType = typeof(double);
            // 
            // dataColumn122
            // 
            this.dataColumn122.ColumnName = "IOF_II_ITEM";
            this.dataColumn122.DataType = typeof(double);
            // 
            // radioEntrada
            // 
            this.radioEntrada.AutoSize = true;
            this.radioEntrada.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsNota_fiscal, "NOTA_FISCAL.ENTRADA_NF", true));
            this.radioEntrada.Location = new System.Drawing.Point(183, 11);
            this.radioEntrada.Name = "radioEntrada";
            this.radioEntrada.Size = new System.Drawing.Size(62, 17);
            this.radioEntrada.TabIndex = 2;
            this.radioEntrada.TabStop = true;
            this.radioEntrada.Text = "Entrada";
            this.radioEntrada.UseVisualStyleBackColor = true;
            this.radioEntrada.CheckedChanged += new System.EventHandler(this.radioEntrada_CheckedChanged);
            // 
            // radioSaida
            // 
            this.radioSaida.AutoSize = true;
            this.radioSaida.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsNota_fiscal, "NOTA_FISCAL.SAIDA_NF", true));
            this.radioSaida.Location = new System.Drawing.Point(251, 11);
            this.radioSaida.Name = "radioSaida";
            this.radioSaida.Size = new System.Drawing.Size(54, 17);
            this.radioSaida.TabIndex = 3;
            this.radioSaida.TabStop = true;
            this.radioSaida.Text = "Saída";
            this.radioSaida.UseVisualStyleBackColor = true;
            this.radioSaida.CheckedChanged += new System.EventHandler(this.radioSaida_CheckedChanged);
            // 
            // datNota_fiscal
            // 
            this.datNota_fiscal.DeleteCommand = this.fbCommand8;
            this.datNota_fiscal.InsertCommand = this.fbCommand6;
            this.datNota_fiscal.SelectCommand = this.fbCommand5;
            this.datNota_fiscal.UpdateCommand = this.fbCommand7;
            // 
            // fbCommand8
            // 
            this.fbCommand8.CommandText = "DELETE FROM \"NOTA_FISCAL\" WHERE ((\"COD_SISTEMA_NF\" = @p1))";
            this.fbCommand8.CommandTimeout = 30;
            this.fbCommand8.Connection = this.fbConnection1;
            this.fbCommand8.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p1", FirebirdSql.Data.FirebirdClient.FbDbType.Integer, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "COD_SISTEMA_NF", System.Data.DataRowVersion.Original, null));
            // 
            // fbCommand6
            // 
            this.fbCommand6.CommandText = resources.GetString("fbCommand6.CommandText");
            this.fbCommand6.CommandTimeout = 30;
            this.fbCommand6.Connection = this.fbConnection1;
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p1", FirebirdSql.Data.FirebirdClient.FbDbType.Integer, 4, "COD_SISTEMA_NF"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p2", FirebirdSql.Data.FirebirdClient.FbDbType.Integer, 4, "N_NF"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p3", FirebirdSql.Data.FirebirdClient.FbDbType.Integer, 4, "ENTRADA_NF"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p4", FirebirdSql.Data.FirebirdClient.FbDbType.Integer, 4, "SAIDA_NF"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p5", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 20, "FORMA_PGTO_NF"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p6", FirebirdSql.Data.FirebirdClient.FbDbType.Date, 4, "DATA_ENTR_SAI_NF"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p7", FirebirdSql.Data.FirebirdClient.FbDbType.Date, 4, "DATA_EMISSAO_NF"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p8", FirebirdSql.Data.FirebirdClient.FbDbType.Date, 4, "DATA_VENCIMENTO_NF"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p9", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 15, "CFO_NF"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p10", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 15, "CFO_2_NF"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p11", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 100, "CLIENTE_FORN_NF"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p12", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 100, "ENDERECO_ENTREGA_NF"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p13", FirebirdSql.Data.FirebirdClient.FbDbType.Double, 8, "BASE_CALC_ICMS_NF"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p14", FirebirdSql.Data.FirebirdClient.FbDbType.Double, 8, "VALOR_ICMS_NF"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p15", FirebirdSql.Data.FirebirdClient.FbDbType.Double, 8, "BASE_CALC_ICM_SUBS"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p16", FirebirdSql.Data.FirebirdClient.FbDbType.Double, 8, "VALOR_ICM_SUBS"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p17", FirebirdSql.Data.FirebirdClient.FbDbType.Double, 8, "VALOR_FRETE_NF"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p18", FirebirdSql.Data.FirebirdClient.FbDbType.Double, 8, "VALOR_SEGURO_NF"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p19", FirebirdSql.Data.FirebirdClient.FbDbType.Double, 8, "OUTRAS_DESP_NF"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p20", FirebirdSql.Data.FirebirdClient.FbDbType.Double, 8, "VALOR_IPI_NF"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p21", FirebirdSql.Data.FirebirdClient.FbDbType.Double, 8, "VALOR_TOT_PROD_NF"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p22", FirebirdSql.Data.FirebirdClient.FbDbType.Double, 8, "VALOR_NOTA_NF"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p23", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 100, "TRANSPORTADORA_NF"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p24", FirebirdSql.Data.FirebirdClient.FbDbType.Integer, 4, "FRETE_CONTA_NF"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p25", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 15, "PLACA_VEICULO_NF"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p26", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 15, "ESTADO_VEICULO_NF"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p27", FirebirdSql.Data.FirebirdClient.FbDbType.Integer, 4, "QTDE_NF"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p28", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 20, "ESPECIE_NF"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p29", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 20, "MARCA_NF"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p30", FirebirdSql.Data.FirebirdClient.FbDbType.Double, 8, "PESO_BRUTO_NF"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p31", FirebirdSql.Data.FirebirdClient.FbDbType.Double, 8, "PESO_LIQUIDO_NF"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p32", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 450, "INF_COMPL_NF"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p33", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 50, "TIPO_MVTO_NF"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p34", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 50, "OBS_NF"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p35", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 100, "VALOR_EXTENSO_NF"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p36", FirebirdSql.Data.FirebirdClient.FbDbType.Integer, 4, "TRIBUTADA_NF"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p37", FirebirdSql.Data.FirebirdClient.FbDbType.Integer, 4, "COBRANCA_NF"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p38", FirebirdSql.Data.FirebirdClient.FbDbType.Integer, 4, "EXPORTACAO_NF"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p39", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 2, "UF_EMBARQUE_EXPORTACAO"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p40", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 60, "LOCAL_EMBARQUE_EXPORTACAO"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p41", FirebirdSql.Data.FirebirdClient.FbDbType.Integer, 4, "BENEFICIAMENTO_NF"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p42", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 200, "STATUS_NFE"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p43", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 100, "CHAVE_ACESSO_NFE"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p44", FirebirdSql.Data.FirebirdClient.FbDbType.Double, 8, "VALOR_TOTAL_SERVICOS_NF"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p45", FirebirdSql.Data.FirebirdClient.FbDbType.Double, 8, "BASE_CALCULO_ISS_NF"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p46", FirebirdSql.Data.FirebirdClient.FbDbType.Double, 8, "VALOR_ISS_NF"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p47", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 100, "RECIBO_NFE"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p48", FirebirdSql.Data.FirebirdClient.FbDbType.Integer, 4, "ENTRADA_SAIDA_NF"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p49", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 200, "NATUREZA_OPERACAO_NF"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p50", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 30, "CNPJ_CLIENTE_FORN"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p51", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 9, "NOTA_STRING_NF"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p52", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 250, "END_NUMERO_STRING_NF"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p53", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 70, "RAZAO_SOCIAL_CL_NF"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p54", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 70, "IE_CL_NF"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p55", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 70, "CNPJ_CL_NF"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p56", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 70, "BAIRRO_CL_NF"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p57", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 70, "CIDADE_CL_NF"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p58", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 70, "ESTADO_CL_NF"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p59", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 70, "PAIS_CL_NF"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p60", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 70, "CEP_CL_NF"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p61", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 70, "FONE_CL_NF"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p62", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 70, "EMAIL_CL_NF"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p63", FirebirdSql.Data.FirebirdClient.FbDbType.Double, 8, "VALOR_SIMPLES_NF"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p64", FirebirdSql.Data.FirebirdClient.FbDbType.Double, 8, "ALIQUOTA_SIMPLES_NF"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p65", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 200, "N_PROTOCOLO_AUTORIZACAO_NF"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p66", FirebirdSql.Data.FirebirdClient.FbDbType.Binary, 2147483647, "COD_BARRAS_NF"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p67", FirebirdSql.Data.FirebirdClient.FbDbType.Integer, 4, "NFE_TESTE"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p68", FirebirdSql.Data.FirebirdClient.FbDbType.Date, 4, "DATA_AUTORIZACAO_NF"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p69", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 50, "HORA_AUTORIZACAO_NF"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p70", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 2, "ESTADO_CLIENTE_NF"));
            // 
            // fbCommand5
            // 
            this.fbCommand5.CommandText = "SELECT * FROM NOTA_FISCAL";
            this.fbCommand5.CommandTimeout = 30;
            this.fbCommand5.Connection = this.fbConnection1;
            // 
            // fbCommand7
            // 
            this.fbCommand7.CommandText = resources.GetString("fbCommand7.CommandText");
            this.fbCommand7.CommandTimeout = 30;
            this.fbCommand7.Connection = this.fbConnection1;
            this.fbCommand7.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p1", FirebirdSql.Data.FirebirdClient.FbDbType.Integer, 4, "COD_SISTEMA_NF"));
            this.fbCommand7.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p2", FirebirdSql.Data.FirebirdClient.FbDbType.Integer, 4, "N_NF"));
            this.fbCommand7.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p3", FirebirdSql.Data.FirebirdClient.FbDbType.Integer, 4, "ENTRADA_NF"));
            this.fbCommand7.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p4", FirebirdSql.Data.FirebirdClient.FbDbType.Integer, 4, "SAIDA_NF"));
            this.fbCommand7.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p5", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 20, "FORMA_PGTO_NF"));
            this.fbCommand7.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p6", FirebirdSql.Data.FirebirdClient.FbDbType.Date, 4, "DATA_ENTR_SAI_NF"));
            this.fbCommand7.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p7", FirebirdSql.Data.FirebirdClient.FbDbType.Date, 4, "DATA_EMISSAO_NF"));
            this.fbCommand7.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p8", FirebirdSql.Data.FirebirdClient.FbDbType.Date, 4, "DATA_VENCIMENTO_NF"));
            this.fbCommand7.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p9", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 15, "CFO_NF"));
            this.fbCommand7.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p10", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 15, "CFO_2_NF"));
            this.fbCommand7.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p11", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 100, "CLIENTE_FORN_NF"));
            this.fbCommand7.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p12", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 100, "ENDERECO_ENTREGA_NF"));
            this.fbCommand7.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p13", FirebirdSql.Data.FirebirdClient.FbDbType.Double, 8, "BASE_CALC_ICMS_NF"));
            this.fbCommand7.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p14", FirebirdSql.Data.FirebirdClient.FbDbType.Double, 8, "VALOR_ICMS_NF"));
            this.fbCommand7.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p15", FirebirdSql.Data.FirebirdClient.FbDbType.Double, 8, "BASE_CALC_ICM_SUBS"));
            this.fbCommand7.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p16", FirebirdSql.Data.FirebirdClient.FbDbType.Double, 8, "VALOR_ICM_SUBS"));
            this.fbCommand7.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p17", FirebirdSql.Data.FirebirdClient.FbDbType.Double, 8, "VALOR_FRETE_NF"));
            this.fbCommand7.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p18", FirebirdSql.Data.FirebirdClient.FbDbType.Double, 8, "VALOR_SEGURO_NF"));
            this.fbCommand7.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p19", FirebirdSql.Data.FirebirdClient.FbDbType.Double, 8, "OUTRAS_DESP_NF"));
            this.fbCommand7.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p20", FirebirdSql.Data.FirebirdClient.FbDbType.Double, 8, "VALOR_IPI_NF"));
            this.fbCommand7.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p21", FirebirdSql.Data.FirebirdClient.FbDbType.Double, 8, "VALOR_TOT_PROD_NF"));
            this.fbCommand7.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p22", FirebirdSql.Data.FirebirdClient.FbDbType.Double, 8, "VALOR_NOTA_NF"));
            this.fbCommand7.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p23", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 100, "TRANSPORTADORA_NF"));
            this.fbCommand7.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p24", FirebirdSql.Data.FirebirdClient.FbDbType.Integer, 4, "FRETE_CONTA_NF"));
            this.fbCommand7.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p25", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 15, "PLACA_VEICULO_NF"));
            this.fbCommand7.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p26", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 15, "ESTADO_VEICULO_NF"));
            this.fbCommand7.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p27", FirebirdSql.Data.FirebirdClient.FbDbType.Integer, 4, "QTDE_NF"));
            this.fbCommand7.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p28", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 20, "ESPECIE_NF"));
            this.fbCommand7.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p29", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 20, "MARCA_NF"));
            this.fbCommand7.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p30", FirebirdSql.Data.FirebirdClient.FbDbType.Double, 8, "PESO_BRUTO_NF"));
            this.fbCommand7.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p31", FirebirdSql.Data.FirebirdClient.FbDbType.Double, 8, "PESO_LIQUIDO_NF"));
            this.fbCommand7.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p32", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 450, "INF_COMPL_NF"));
            this.fbCommand7.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p33", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 50, "TIPO_MVTO_NF"));
            this.fbCommand7.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p34", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 50, "OBS_NF"));
            this.fbCommand7.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p35", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 100, "VALOR_EXTENSO_NF"));
            this.fbCommand7.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p36", FirebirdSql.Data.FirebirdClient.FbDbType.Integer, 4, "TRIBUTADA_NF"));
            this.fbCommand7.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p37", FirebirdSql.Data.FirebirdClient.FbDbType.Integer, 4, "COBRANCA_NF"));
            this.fbCommand7.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p38", FirebirdSql.Data.FirebirdClient.FbDbType.Integer, 4, "EXPORTACAO_NF"));
            this.fbCommand7.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p39", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 2, "UF_EMBARQUE_EXPORTACAO"));
            this.fbCommand7.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p40", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 60, "LOCAL_EMBARQUE_EXPORTACAO"));
            this.fbCommand7.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p41", FirebirdSql.Data.FirebirdClient.FbDbType.Integer, 4, "BENEFICIAMENTO_NF"));
            this.fbCommand7.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p42", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 200, "STATUS_NFE"));
            this.fbCommand7.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p43", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 100, "CHAVE_ACESSO_NFE"));
            this.fbCommand7.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p44", FirebirdSql.Data.FirebirdClient.FbDbType.Double, 8, "VALOR_TOTAL_SERVICOS_NF"));
            this.fbCommand7.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p45", FirebirdSql.Data.FirebirdClient.FbDbType.Double, 8, "BASE_CALCULO_ISS_NF"));
            this.fbCommand7.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p46", FirebirdSql.Data.FirebirdClient.FbDbType.Double, 8, "VALOR_ISS_NF"));
            this.fbCommand7.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p47", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 100, "RECIBO_NFE"));
            this.fbCommand7.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p48", FirebirdSql.Data.FirebirdClient.FbDbType.Integer, 4, "ENTRADA_SAIDA_NF"));
            this.fbCommand7.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p49", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 200, "NATUREZA_OPERACAO_NF"));
            this.fbCommand7.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p50", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 30, "CNPJ_CLIENTE_FORN"));
            this.fbCommand7.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p51", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 9, "NOTA_STRING_NF"));
            this.fbCommand7.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p52", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 250, "END_NUMERO_STRING_NF"));
            this.fbCommand7.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p53", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 70, "RAZAO_SOCIAL_CL_NF"));
            this.fbCommand7.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p54", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 70, "IE_CL_NF"));
            this.fbCommand7.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p55", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 70, "CNPJ_CL_NF"));
            this.fbCommand7.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p56", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 70, "BAIRRO_CL_NF"));
            this.fbCommand7.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p57", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 70, "CIDADE_CL_NF"));
            this.fbCommand7.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p58", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 70, "ESTADO_CL_NF"));
            this.fbCommand7.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p59", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 70, "PAIS_CL_NF"));
            this.fbCommand7.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p60", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 70, "CEP_CL_NF"));
            this.fbCommand7.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p61", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 70, "FONE_CL_NF"));
            this.fbCommand7.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p62", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 70, "EMAIL_CL_NF"));
            this.fbCommand7.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p63", FirebirdSql.Data.FirebirdClient.FbDbType.Double, 8, "VALOR_SIMPLES_NF"));
            this.fbCommand7.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p64", FirebirdSql.Data.FirebirdClient.FbDbType.Double, 8, "ALIQUOTA_SIMPLES_NF"));
            this.fbCommand7.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p65", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 200, "N_PROTOCOLO_AUTORIZACAO_NF"));
            this.fbCommand7.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p66", FirebirdSql.Data.FirebirdClient.FbDbType.Binary, 2147483647, "COD_BARRAS_NF"));
            this.fbCommand7.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p67", FirebirdSql.Data.FirebirdClient.FbDbType.Integer, 4, "NFE_TESTE"));
            this.fbCommand7.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p68", FirebirdSql.Data.FirebirdClient.FbDbType.Date, 4, "DATA_AUTORIZACAO_NF"));
            this.fbCommand7.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p69", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 50, "HORA_AUTORIZACAO_NF"));
            this.fbCommand7.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p70", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 2, "ESTADO_CLIENTE_NF"));
            this.fbCommand7.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p71", FirebirdSql.Data.FirebirdClient.FbDbType.Integer, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "COD_SISTEMA_NF", System.Data.DataRowVersion.Original, null));
            // 
            // salva_registro
            // 
            this.salva_registro.Location = new System.Drawing.Point(459, 12);
            this.salva_registro.Name = "salva_registro";
            this.salva_registro.Size = new System.Drawing.Size(49, 60);
            this.salva_registro.TabIndex = 27;
            this.salva_registro.Text = "Salvar";
            this.salva_registro.UseVisualStyleBackColor = true;
            this.salva_registro.Click += new System.EventHandler(this.salva_registro_Click);
            // 
            // novo_registro
            // 
            this.novo_registro.Location = new System.Drawing.Point(514, 12);
            this.novo_registro.Name = "novo_registro";
            this.novo_registro.Size = new System.Drawing.Size(49, 60);
            this.novo_registro.TabIndex = 114;
            this.novo_registro.Text = "Novo";
            this.novo_registro.UseVisualStyleBackColor = true;
            this.novo_registro.Click += new System.EventHandler(this.novo_registro_Click);
            // 
            // tb_cod_interno
            // 
            this.tb_cod_interno.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsNota_fiscal, "NOTA_FISCAL.COD_SISTEMA_NF", true));
            this.tb_cod_interno.Location = new System.Drawing.Point(5, 17);
            this.tb_cod_interno.Name = "tb_cod_interno";
            this.tb_cod_interno.ReadOnly = true;
            this.tb_cod_interno.Size = new System.Drawing.Size(63, 20);
            this.tb_cod_interno.TabIndex = 128;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(3, 4);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(65, 13);
            this.label34.TabIndex = 127;
            this.label34.Text = "Cód. Interno";
            // 
            // datOp
            // 
            this.datOp.DeleteCommand = this.fbCommand12;
            this.datOp.InsertCommand = this.fbCommand10;
            this.datOp.SelectCommand = this.fbCommand9;
            this.datOp.UpdateCommand = this.fbCommand11;
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
            this.fbCommand9.CommandText = "select * from op order by desenho_op_atual";
            this.fbCommand9.CommandTimeout = 30;
            this.fbCommand9.Connection = this.fbConnection1;
            // 
            // fbCommand11
            // 
            this.fbCommand11.CommandTimeout = 30;
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
            this.DESCRICAO_PECA,
            this.MARCA_PECA,
            this.UNIDADE_PECA,
            this.PESO_PECA,
            this.TRIBUTACAO_PECA,
            this.ICMS_PECA,
            this.IPI_PECA,
            this.PRECO_PECA,
            this.QTDE_ESTOQUE_PECA,
            this.dataColumn1,
            this.dataColumn18});
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
            this.COD_PECA.MaxLength = 100;
            // 
            // REVISAO
            // 
            this.REVISAO.ColumnName = "REVISAO";
            this.REVISAO.MaxLength = 10;
            // 
            // MATERIAL
            // 
            this.MATERIAL.ColumnName = "MATERIAL";
            this.MATERIAL.MaxLength = 100;
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
            // DESCRICAO_PECA
            // 
            this.DESCRICAO_PECA.ColumnName = "DESCRICAO_PECA";
            this.DESCRICAO_PECA.MaxLength = 50;
            // 
            // MARCA_PECA
            // 
            this.MARCA_PECA.ColumnName = "MARCA_PECA";
            this.MARCA_PECA.MaxLength = 30;
            // 
            // UNIDADE_PECA
            // 
            this.UNIDADE_PECA.ColumnName = "UNIDADE_PECA";
            this.UNIDADE_PECA.MaxLength = 30;
            // 
            // PESO_PECA
            // 
            this.PESO_PECA.ColumnName = "PESO_PECA";
            this.PESO_PECA.DataType = typeof(double);
            // 
            // TRIBUTACAO_PECA
            // 
            this.TRIBUTACAO_PECA.ColumnName = "TRIBUTACAO_PECA";
            this.TRIBUTACAO_PECA.MaxLength = 30;
            // 
            // ICMS_PECA
            // 
            this.ICMS_PECA.ColumnName = "ICMS_PECA";
            this.ICMS_PECA.DataType = typeof(double);
            // 
            // IPI_PECA
            // 
            this.IPI_PECA.ColumnName = "IPI_PECA";
            this.IPI_PECA.DataType = typeof(double);
            // 
            // PRECO_PECA
            // 
            this.PRECO_PECA.ColumnName = "PRECO_PECA";
            this.PRECO_PECA.DataType = typeof(double);
            // 
            // QTDE_ESTOQUE_PECA
            // 
            this.QTDE_ESTOQUE_PECA.ColumnName = "QTDE_ESTOQUE_PECA";
            this.QTDE_ESTOQUE_PECA.DataType = typeof(int);
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "SITUACAO_PECA";
            this.dataColumn1.MaxLength = 20;
            // 
            // dataColumn18
            // 
            this.dataColumn18.ColumnName = "NCM_PECA";
            this.dataColumn18.MaxLength = 20;
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
            this.LOTE,
            this.ESPESSURA_OP,
            this.OBSERVACOES_OP,
            this.REVISAO_OP,
            this.DESCRICAO_PECA_OP,
            this.MARCA_OP,
            this.UNIDADE_OP,
            this.ICMS_OP,
            this.IPI_OP,
            this.dataColumn11,
            this.dataColumn12,
            this.dataColumn13,
            this.dataColumn16,
            this.dataColumn17});
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
            this.PRECO_UNIT.DataType = typeof(double);
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
            this.DESCRICAO_PECA_OP.MaxLength = 50;
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
            // dataColumn11
            // 
            this.dataColumn11.ColumnName = "SIT_OP";
            this.dataColumn11.DataType = typeof(double);
            // 
            // dataColumn12
            // 
            this.dataColumn12.ColumnName = "UNID_OP";
            this.dataColumn12.MaxLength = 8;
            // 
            // dataColumn13
            // 
            this.dataColumn13.ColumnName = "OP_MAE";
            this.dataColumn13.DataType = typeof(int);
            // 
            // dataColumn16
            // 
            this.dataColumn16.ColumnName = "SIT_ATUAL_OP";
            this.dataColumn16.MaxLength = 70;
            // 
            // dataColumn17
            // 
            this.dataColumn17.ColumnName = "NCM_OP";
            this.dataColumn17.MaxLength = 20;
            // 
            // datDesenhos
            // 
            this.datDesenhos.DeleteCommand = this.fbCommand16;
            this.datDesenhos.InsertCommand = this.fbCommand14;
            this.datDesenhos.SelectCommand = this.fbCommand13;
            this.datDesenhos.UpdateCommand = this.fbCommand15;
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
            this.fbCommand13.CommandText = "select * from desenhos";
            this.fbCommand13.CommandTimeout = 30;
            this.fbCommand13.Connection = this.fbConnection1;
            // 
            // fbCommand15
            // 
            this.fbCommand15.CommandTimeout = 30;
            // 
            // dsUlt_imp_nf
            // 
            this.dsUlt_imp_nf.DataSetName = "dsUlt_imp_nf";
            this.dsUlt_imp_nf.Namespace = "http://www.tempuri.org/dsUlt_imp_nf.xsd";
            this.dsUlt_imp_nf.Tables.AddRange(new System.Data.DataTable[] {
            this.ULT_IMP_NF});
            // 
            // ULT_IMP_NF
            // 
            this.ULT_IMP_NF.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_ULT_IMP_NF,
            this.NUM_ULT_NF});
            this.ULT_IMP_NF.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_ULT_IMP_NF"}, true)});
            this.ULT_IMP_NF.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_ULT_IMP_NF};
            this.ULT_IMP_NF.TableName = "ULT_IMP_NF";
            // 
            // COD_ULT_IMP_NF
            // 
            this.COD_ULT_IMP_NF.AllowDBNull = false;
            this.COD_ULT_IMP_NF.ColumnName = "COD_ULT_IMP_NF";
            this.COD_ULT_IMP_NF.DataType = typeof(int);
            // 
            // NUM_ULT_NF
            // 
            this.NUM_ULT_NF.ColumnName = "NUM_ULT_NF";
            this.NUM_ULT_NF.DataType = typeof(int);
            // 
            // datUlt_imp_nf
            // 
            this.datUlt_imp_nf.DeleteCommand = this.fbCommand20;
            this.datUlt_imp_nf.InsertCommand = this.fbCommand18;
            this.datUlt_imp_nf.SelectCommand = this.fbCommand17;
            this.datUlt_imp_nf.UpdateCommand = this.fbCommand19;
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
            this.fbCommand17.CommandText = "SELECT * FROM ULT_IMP_NF";
            this.fbCommand17.CommandTimeout = 30;
            this.fbCommand17.Connection = this.fbConnection1;
            // 
            // fbCommand19
            // 
            this.fbCommand19.CommandTimeout = 30;
            // 
            // cbNota_fiscal
            // 
            this.cbNota_fiscal.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbNota_fiscal.DataAdapter = this.datNota_fiscal;
            this.cbNota_fiscal.QuotePrefix = "\"";
            this.cbNota_fiscal.QuoteSuffix = "\"";
            // 
            // cbUlt_imp_nf
            // 
            this.cbUlt_imp_nf.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbUlt_imp_nf.DataAdapter = this.datUlt_imp_nf;
            this.cbUlt_imp_nf.QuotePrefix = "\"";
            this.cbUlt_imp_nf.QuoteSuffix = "\"";
            // 
            // fbCommand24
            // 
            this.fbCommand24.CommandTimeout = 30;
            // 
            // fbCommand22
            // 
            this.fbCommand22.CommandTimeout = 30;
            // 
            // fbCommand21
            // 
            this.fbCommand21.CommandText = "select * from cfo order by n_cfo";
            this.fbCommand21.CommandTimeout = 30;
            this.fbCommand21.Connection = this.fbConnection1;
            // 
            // fbCommand23
            // 
            this.fbCommand23.CommandTimeout = 30;
            // 
            // datClientes
            // 
            this.datClientes.DeleteCommand = this.fbCommand28;
            this.datClientes.InsertCommand = this.fbCommand26;
            this.datClientes.SelectCommand = this.fbCommand25;
            this.datClientes.UpdateCommand = this.fbCommand27;
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
            this.fbCommand25.CommandText = "select * from clientes";
            this.fbCommand25.CommandTimeout = 30;
            this.fbCommand25.Connection = this.fbConnection1;
            // 
            // fbCommand27
            // 
            this.fbCommand27.CommandTimeout = 30;
            // 
            // datTransportadoras
            // 
            this.datTransportadoras.DeleteCommand = this.fbCommand32;
            this.datTransportadoras.InsertCommand = this.fbCommand30;
            this.datTransportadoras.SelectCommand = this.fbCommand29;
            this.datTransportadoras.UpdateCommand = this.fbCommand31;
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
            this.fbCommand29.CommandText = "select * from transportadoras";
            this.fbCommand29.CommandTimeout = 30;
            this.fbCommand29.Connection = this.fbConnection1;
            // 
            // fbCommand31
            // 
            this.fbCommand31.CommandTimeout = 30;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(677, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(21, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(399, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(23, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // datCfo
            // 
            this.datCfo.DeleteCommand = this.fbCommand36;
            this.datCfo.InsertCommand = this.fbCommand34;
            this.datCfo.SelectCommand = this.fbCommand33;
            this.datCfo.UpdateCommand = this.fbCommand35;
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
            this.fbCommand33.CommandText = "select * from cfo order by n_cfo";
            this.fbCommand33.CommandTimeout = 30;
            this.fbCommand33.Connection = this.fbConnection1;
            // 
            // fbCommand35
            // 
            this.fbCommand35.CommandTimeout = 30;
            // 
            // dsCfo
            // 
            this.dsCfo.DataSetName = "dsCfo";
            this.dsCfo.Namespace = "http://www.tempuri.org/dsCfo.xsd";
            this.dsCfo.Tables.AddRange(new System.Data.DataTable[] {
            this.CFO});
            // 
            // CFO
            // 
            this.CFO.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_SISTEMA_CFO,
            this.N_CFO,
            this.DESCRICAO_CFO,
            this.OBSERVACAO_CFO});
            this.CFO.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_SISTEMA_CFO"}, true)});
            this.CFO.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_SISTEMA_CFO};
            this.CFO.TableName = "CFO";
            // 
            // COD_SISTEMA_CFO
            // 
            this.COD_SISTEMA_CFO.AllowDBNull = false;
            this.COD_SISTEMA_CFO.ColumnName = "COD_SISTEMA_CFO";
            this.COD_SISTEMA_CFO.DataType = typeof(int);
            // 
            // N_CFO
            // 
            this.N_CFO.ColumnName = "N_CFO";
            this.N_CFO.DataType = typeof(int);
            // 
            // DESCRICAO_CFO
            // 
            this.DESCRICAO_CFO.ColumnName = "DESCRICAO_CFO";
            this.DESCRICAO_CFO.MaxLength = 20;
            // 
            // OBSERVACAO_CFO
            // 
            this.OBSERVACAO_CFO.ColumnName = "OBSERVACAO_CFO";
            this.OBSERVACAO_CFO.MaxLength = 250;
            // 
            // tb_cnpj_cliente
            // 
            this.tb_cnpj_cliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsNota_fiscal, "NOTA_FISCAL.CNPJ_CLIENTE_FORN", true));
            this.tb_cnpj_cliente.Location = new System.Drawing.Point(299, 103);
            this.tb_cnpj_cliente.Name = "tb_cnpj_cliente";
            this.tb_cnpj_cliente.Size = new System.Drawing.Size(113, 20);
            this.tb_cnpj_cliente.TabIndex = 7;
            this.tb_cnpj_cliente.DoubleClick += new System.EventHandler(this.tb_cliente_DoubleClick);
            // 
            // tb_transportadora
            // 
            this.tb_transportadora.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsNota_fiscal, "NOTA_FISCAL.TRANSPORTADORA_NF", true));
            this.tb_transportadora.Location = new System.Drawing.Point(126, 5);
            this.tb_transportadora.Name = "tb_transportadora";
            this.tb_transportadora.Size = new System.Drawing.Size(269, 20);
            this.tb_transportadora.TabIndex = 159;
            // 
            // tb_frete
            // 
            this.tb_frete.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsNota_fiscal, "NOTA_FISCAL.FRETE_CONTA_NF", true));
            this.tb_frete.Location = new System.Drawing.Point(114, 29);
            this.tb_frete.Name = "tb_frete";
            this.tb_frete.Size = new System.Drawing.Size(16, 20);
            this.tb_frete.TabIndex = 20;
            // 
            // cbItens_nota
            // 
            this.cbItens_nota.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbItens_nota.DataAdapter = this.datItens_nota;
            this.cbItens_nota.QuotePrefix = "\"";
            this.cbItens_nota.QuoteSuffix = "\"";
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
            this.PECAS_APROVADAS,
            this.PECAS_REJEITADAS,
            this.TIPO_REJEICAO,
            this.OPERADOR_FINALIZADOR,
            this.MAQ_FECHA,
            this.RETRABALHO_ROTA,
            this.SALDO_HORAS,
            this.HORAS_OPERADOR,
            this.HORAS_MAQUINA,
            this.PECAS_ADICIONAIS});
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
            this.OBSERVACAO_CAMPO.MaxLength = 200;
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
            // PECAS_APROVADAS
            // 
            this.PECAS_APROVADAS.ColumnName = "PECAS_APROVADAS";
            this.PECAS_APROVADAS.DataType = typeof(int);
            // 
            // PECAS_REJEITADAS
            // 
            this.PECAS_REJEITADAS.ColumnName = "PECAS_REJEITADAS";
            this.PECAS_REJEITADAS.DataType = typeof(int);
            // 
            // TIPO_REJEICAO
            // 
            this.TIPO_REJEICAO.ColumnName = "TIPO_REJEICAO";
            this.TIPO_REJEICAO.MaxLength = 40;
            // 
            // OPERADOR_FINALIZADOR
            // 
            this.OPERADOR_FINALIZADOR.ColumnName = "OPERADOR_FINALIZADOR";
            this.OPERADOR_FINALIZADOR.MaxLength = 30;
            // 
            // MAQ_FECHA
            // 
            this.MAQ_FECHA.ColumnName = "MAQ_FECHA";
            this.MAQ_FECHA.MaxLength = 30;
            // 
            // RETRABALHO_ROTA
            // 
            this.RETRABALHO_ROTA.ColumnName = "RETRABALHO_ROTA";
            this.RETRABALHO_ROTA.DataType = typeof(int);
            // 
            // SALDO_HORAS
            // 
            this.SALDO_HORAS.ColumnName = "SALDO_HORAS";
            this.SALDO_HORAS.DataType = typeof(double);
            // 
            // HORAS_OPERADOR
            // 
            this.HORAS_OPERADOR.ColumnName = "HORAS_OPERADOR";
            this.HORAS_OPERADOR.DataType = typeof(double);
            // 
            // HORAS_MAQUINA
            // 
            this.HORAS_MAQUINA.ColumnName = "HORAS_MAQUINA";
            this.HORAS_MAQUINA.DataType = typeof(double);
            // 
            // PECAS_ADICIONAIS
            // 
            this.PECAS_ADICIONAIS.ColumnName = "PECAS_ADICIONAIS";
            this.PECAS_ADICIONAIS.DataType = typeof(int);
            // 
            // datRotas_campo
            // 
            this.datRotas_campo.DeleteCommand = this.fbCommand40;
            this.datRotas_campo.InsertCommand = this.fbCommand38;
            this.datRotas_campo.SelectCommand = this.fbCommand37;
            this.datRotas_campo.UpdateCommand = this.fbCommand39;
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
            this.fbCommand37.CommandText = "select * from rotas_campo";
            this.fbCommand37.CommandTimeout = 30;
            this.fbCommand37.Connection = this.fbConnection1;
            // 
            // fbCommand39
            // 
            this.fbCommand39.CommandTimeout = 30;
            // 
            // fbCommand41
            // 
            this.fbCommand41.CommandText = "select * from op";
            this.fbCommand41.CommandTimeout = 30;
            this.fbCommand41.Connection = this.fbConnection1;
            // 
            // fbCommand42
            // 
            this.fbCommand42.CommandTimeout = 30;
            // 
            // fbCommand43
            // 
            this.fbCommand43.CommandTimeout = 30;
            // 
            // fbCommand44
            // 
            this.fbCommand44.CommandTimeout = 30;
            // 
            // tb_descricao_peca
            // 
            this.tb_descricao_peca.Location = new System.Drawing.Point(132, 15);
            this.tb_descricao_peca.Name = "tb_descricao_peca";
            this.tb_descricao_peca.Size = new System.Drawing.Size(202, 20);
            this.tb_descricao_peca.TabIndex = 10;
            // 
            // tb_cod_peca
            // 
            this.tb_cod_peca.Location = new System.Drawing.Point(51, 15);
            this.tb_cod_peca.Name = "tb_cod_peca";
            this.tb_cod_peca.Size = new System.Drawing.Size(82, 20);
            this.tb_cod_peca.TabIndex = 9;
            this.tb_cod_peca.DoubleClick += new System.EventHandler(this.tb_cod_peca_DoubleClick);
            this.tb_cod_peca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_cod_peca_KeyPress);
            // 
            // tb_preco_unit_peca
            // 
            this.tb_preco_unit_peca.Location = new System.Drawing.Point(404, 15);
            this.tb_preco_unit_peca.Name = "tb_preco_unit_peca";
            this.tb_preco_unit_peca.Size = new System.Drawing.Size(63, 20);
            this.tb_preco_unit_peca.TabIndex = 13;
            this.tb_preco_unit_peca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_qtde_peca
            // 
            this.tb_qtde_peca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_qtde_peca.Location = new System.Drawing.Point(363, 15);
            this.tb_qtde_peca.Name = "tb_qtde_peca";
            this.tb_qtde_peca.Size = new System.Drawing.Size(42, 20);
            this.tb_qtde_peca.TabIndex = 12;
            this.tb_qtde_peca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_unid_peca
            // 
            this.tb_unid_peca.Location = new System.Drawing.Point(333, 15);
            this.tb_unid_peca.Name = "tb_unid_peca";
            this.tb_unid_peca.Size = new System.Drawing.Size(31, 20);
            this.tb_unid_peca.TabIndex = 11;
            this.tb_unid_peca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(4, 41);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(45, 31);
            this.button5.TabIndex = 16;
            this.button5.Text = "Inserir";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(569, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(49, 60);
            this.button4.TabIndex = 198;
            this.button4.Text = "Excluir";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(587, 18);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(111, 82);
            this.button6.TabIndex = 17;
            this.button6.Text = "Calcular";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(13, 7);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(138, 13);
            this.label35.TabIndex = 207;
            this.label35.Text = "Forma de pagamento: *";
            // 
            // fbDataAdapter1
            // 
            this.fbDataAdapter1.DeleteCommand = this.fbCommand48;
            this.fbDataAdapter1.InsertCommand = this.fbCommand46;
            this.fbDataAdapter1.SelectCommand = this.fbCommand45;
            this.fbDataAdapter1.UpdateCommand = this.fbCommand47;
            // 
            // fbCommand48
            // 
            this.fbCommand48.CommandTimeout = 30;
            // 
            // fbCommand46
            // 
            this.fbCommand46.CommandTimeout = 30;
            // 
            // fbCommand45
            // 
            this.fbCommand45.CommandTimeout = 30;
            // 
            // fbCommand47
            // 
            this.fbCommand47.CommandTimeout = 30;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(136, 31);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(57, 18);
            this.label37.TabIndex = 219;
            this.label37.Text = "0 - Emitente\r\n1 - Destinatário";
            // 
            // tb_ncm_peca
            // 
            this.tb_ncm_peca.Location = new System.Drawing.Point(466, 15);
            this.tb_ncm_peca.Name = "tb_ncm_peca";
            this.tb_ncm_peca.Size = new System.Drawing.Size(71, 20);
            this.tb_ncm_peca.TabIndex = 14;
            this.tb_ncm_peca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbNfe_teste
            // 
            this.cbNfe_teste.AutoSize = true;
            this.cbNfe_teste.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsNota_fiscal, "NOTA_FISCAL.NFE_TESTE", true));
            this.cbNfe_teste.Location = new System.Drawing.Point(216, 512);
            this.cbNfe_teste.Name = "cbNfe_teste";
            this.cbNfe_teste.Size = new System.Drawing.Size(82, 17);
            this.cbNfe_teste.TabIndex = 235;
            this.cbNfe_teste.Text = "NFe Teste?";
            this.cbNfe_teste.UseVisualStyleBackColor = true;
            // 
            // tb_local_exportacao
            // 
            this.tb_local_exportacao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsNota_fiscal, "NOTA_FISCAL.LOCAL_EMBARQUE_EXPORTACAO", true));
            this.tb_local_exportacao.Location = new System.Drawing.Point(50, 25);
            this.tb_local_exportacao.Name = "tb_local_exportacao";
            this.tb_local_exportacao.Size = new System.Drawing.Size(111, 20);
            this.tb_local_exportacao.TabIndex = 238;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(51, 12);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(98, 13);
            this.label33.TabIndex = 237;
            this.label33.Text = "Local de Embarque";
            // 
            // tb_uf_exportacao
            // 
            this.tb_uf_exportacao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsNota_fiscal, "NOTA_FISCAL.UF_EMBARQUE_EXPORTACAO", true));
            this.tb_uf_exportacao.Location = new System.Drawing.Point(10, 25);
            this.tb_uf_exportacao.Name = "tb_uf_exportacao";
            this.tb_uf_exportacao.Size = new System.Drawing.Size(28, 20);
            this.tb_uf_exportacao.TabIndex = 236;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(7, 12);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(20, 13);
            this.label38.TabIndex = 235;
            this.label38.Text = "UF";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbExportacao);
            this.groupBox2.Controls.Add(this.tb_local_exportacao);
            this.groupBox2.Controls.Add(this.label33);
            this.groupBox2.Controls.Add(this.tb_uf_exportacao);
            this.groupBox2.Controls.Add(this.label38);
            this.groupBox2.Location = new System.Drawing.Point(714, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(167, 65);
            this.groupBox2.TabIndex = 239;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Exportação";
            // 
            // cbExportacao
            // 
            this.cbExportacao.AutoSize = true;
            this.cbExportacao.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsNota_fiscal, "NOTA_FISCAL.EXPORTACAO_NF", true));
            this.cbExportacao.Location = new System.Drawing.Point(38, 46);
            this.cbExportacao.Name = "cbExportacao";
            this.cbExportacao.Size = new System.Drawing.Size(86, 17);
            this.cbExportacao.TabIndex = 239;
            this.cbExportacao.Text = "Exportação?";
            this.cbExportacao.UseVisualStyleBackColor = true;
            // 
            // bt_imprimirNFe
            // 
            this.bt_imprimirNFe.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_imprimirNFe.Location = new System.Drawing.Point(425, 50);
            this.bt_imprimirNFe.Name = "bt_imprimirNFe";
            this.bt_imprimirNFe.Size = new System.Drawing.Size(57, 37);
            this.bt_imprimirNFe.TabIndex = 32;
            this.bt_imprimirNFe.Text = "Imprimir Danfe";
            this.bt_imprimirNFe.UseVisualStyleBackColor = true;
            this.bt_imprimirNFe.Click += new System.EventHandler(this.bt_imprimirNFe_Click);
            // 
            // bt_enviarNFe
            // 
            this.bt_enviarNFe.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_enviarNFe.Location = new System.Drawing.Point(481, 14);
            this.bt_enviarNFe.Name = "bt_enviarNFe";
            this.bt_enviarNFe.Size = new System.Drawing.Size(57, 37);
            this.bt_enviarNFe.TabIndex = 30;
            this.bt_enviarNFe.Text = "Enviar\r\n(2)";
            this.bt_enviarNFe.UseVisualStyleBackColor = true;
            this.bt_enviarNFe.Click += new System.EventHandler(this.button8_Click);
            // 
            // bt_gerarXML
            // 
            this.bt_gerarXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_gerarXML.Location = new System.Drawing.Point(425, 14);
            this.bt_gerarXML.Name = "bt_gerarXML";
            this.bt_gerarXML.Size = new System.Drawing.Size(57, 37);
            this.bt_gerarXML.TabIndex = 29;
            this.bt_gerarXML.Text = "Gerar XML\r\n(1)";
            this.bt_gerarXML.UseVisualStyleBackColor = true;
            this.bt_gerarXML.Click += new System.EventHandler(this.button11_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barra_status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 702);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1038, 22);
            this.statusStrip1.TabIndex = 250;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // barra_status
            // 
            this.barra_status.Name = "barra_status";
            this.barra_status.Size = new System.Drawing.Size(70, 17);
            this.barra_status.Text = "Status Atual";
            // 
            // tb_status_nfe
            // 
            this.tb_status_nfe.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsNota_fiscal, "NOTA_FISCAL.STATUS_NFE", true));
            this.tb_status_nfe.Location = new System.Drawing.Point(63, 14);
            this.tb_status_nfe.Name = "tb_status_nfe";
            this.tb_status_nfe.ReadOnly = true;
            this.tb_status_nfe.Size = new System.Drawing.Size(141, 20);
            this.tb_status_nfe.TabIndex = 251;
            // 
            // comando_select
            // 
            this.comando_select.CommandTimeout = 30;
            this.comando_select.Connection = this.fbConnection1;
            // 
            // bt_cancelarNFe
            // 
            this.bt_cancelarNFe.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancelarNFe.Location = new System.Drawing.Point(537, 50);
            this.bt_cancelarNFe.Name = "bt_cancelarNFe";
            this.bt_cancelarNFe.Size = new System.Drawing.Size(57, 37);
            this.bt_cancelarNFe.TabIndex = 35;
            this.bt_cancelarNFe.Text = "Cancelar NFe";
            this.bt_cancelarNFe.UseVisualStyleBackColor = true;
            this.bt_cancelarNFe.Click += new System.EventHandler(this.bt_cancelarNFe_Click);
            // 
            // br_consultaStatus
            // 
            this.br_consultaStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.br_consultaStatus.Location = new System.Drawing.Point(537, 14);
            this.br_consultaStatus.Name = "br_consultaStatus";
            this.br_consultaStatus.Size = new System.Drawing.Size(57, 37);
            this.br_consultaStatus.TabIndex = 31;
            this.br_consultaStatus.Text = "Consulta \r\nStatus (3)";
            this.br_consultaStatus.UseVisualStyleBackColor = true;
            this.br_consultaStatus.Click += new System.EventHandler(this.br_consultaStatus_Click);
            // 
            // gbNfe
            // 
            this.gbNfe.Controls.Add(this.tb_n_copias);
            this.gbNfe.Controls.Add(this.label83);
            this.gbNfe.Controls.Add(this.button19);
            this.gbNfe.Controls.Add(this.button18);
            this.gbNfe.Controls.Add(this.bt_boleto);
            this.gbNfe.Controls.Add(this.tb_sequencial_correcao);
            this.gbNfe.Controls.Add(this.tb_texto_correcao);
            this.gbNfe.Controls.Add(this.label81);
            this.gbNfe.Controls.Add(this.label80);
            this.gbNfe.Controls.Add(this.button16);
            this.gbNfe.Controls.Add(this.button15);
            this.gbNfe.Controls.Add(this.button11);
            this.gbNfe.Controls.Add(this.button14);
            this.gbNfe.Controls.Add(this.label22);
            this.gbNfe.Controls.Add(this.textBox1);
            this.gbNfe.Controls.Add(this.label36);
            this.gbNfe.Controls.Add(this.textBox2);
            this.gbNfe.Controls.Add(this.button7);
            this.gbNfe.Controls.Add(this.label3);
            this.gbNfe.Controls.Add(this.tb_motivo_cancelamento);
            this.gbNfe.Controls.Add(this.label1);
            this.gbNfe.Controls.Add(this.tb_protocolo_autorizacao);
            this.gbNfe.Controls.Add(this.button3);
            this.gbNfe.Controls.Add(this.label47);
            this.gbNfe.Controls.Add(this.tb_chave_acesso_nfe);
            this.gbNfe.Controls.Add(this.label45);
            this.gbNfe.Controls.Add(this.tb_recibo);
            this.gbNfe.Controls.Add(this.label44);
            this.gbNfe.Controls.Add(this.br_consultaStatus);
            this.gbNfe.Controls.Add(this.bt_cancelarNFe);
            this.gbNfe.Controls.Add(this.tb_status_nfe);
            this.gbNfe.Controls.Add(this.bt_imprimirNFe);
            this.gbNfe.Controls.Add(this.bt_enviarNFe);
            this.gbNfe.Controls.Add(this.bt_gerarXML);
            this.gbNfe.Location = new System.Drawing.Point(320, 511);
            this.gbNfe.Name = "gbNfe";
            this.gbNfe.Size = new System.Drawing.Size(711, 130);
            this.gbNfe.TabIndex = 28;
            this.gbNfe.TabStop = false;
            this.gbNfe.Text = "NFe";
            this.gbNfe.Enter += new System.EventHandler(this.gbNfe_Enter);
            // 
            // tb_n_copias
            // 
            this.tb_n_copias.Location = new System.Drawing.Point(447, 87);
            this.tb_n_copias.Name = "tb_n_copias";
            this.tb_n_copias.Size = new System.Drawing.Size(35, 20);
            this.tb_n_copias.TabIndex = 371;
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.Location = new System.Drawing.Point(369, 90);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(76, 13);
            this.label83.TabIndex = 370;
            this.label83.Text = "No. de cópias:";
            // 
            // button19
            // 
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.Location = new System.Drawing.Point(669, 108);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(37, 20);
            this.button19.TabIndex = 282;
            this.button19.Text = "CR";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button18
            // 
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.Location = new System.Drawing.Point(649, 50);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(57, 37);
            this.button18.TabIndex = 280;
            this.button18.Text = "Status Pedido";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // bt_boleto
            // 
            this.bt_boleto.Location = new System.Drawing.Point(649, 14);
            this.bt_boleto.Name = "bt_boleto";
            this.bt_boleto.Size = new System.Drawing.Size(57, 37);
            this.bt_boleto.TabIndex = 279;
            this.bt_boleto.Text = "Gerar Boletos";
            this.bt_boleto.UseVisualStyleBackColor = true;
            this.bt_boleto.Click += new System.EventHandler(this.button17_Click);
            // 
            // tb_sequencial_correcao
            // 
            this.tb_sequencial_correcao.BackColor = System.Drawing.SystemColors.Control;
            this.tb_sequencial_correcao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsNota_fiscal, "NOTA_FISCAL.SEQUENCIAL_CORRECAO_NF", true));
            this.tb_sequencial_correcao.Location = new System.Drawing.Point(619, 108);
            this.tb_sequencial_correcao.Name = "tb_sequencial_correcao";
            this.tb_sequencial_correcao.Size = new System.Drawing.Size(46, 20);
            this.tb_sequencial_correcao.TabIndex = 278;
            // 
            // tb_texto_correcao
            // 
            this.tb_texto_correcao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsNota_fiscal, "NOTA_FISCAL.TEXTO_CORRECAO_NF", true));
            this.tb_texto_correcao.Location = new System.Drawing.Point(355, 109);
            this.tb_texto_correcao.Name = "tb_texto_correcao";
            this.tb_texto_correcao.Size = new System.Drawing.Size(228, 20);
            this.tb_texto_correcao.TabIndex = 277;
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Location = new System.Drawing.Point(589, 112);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(24, 13);
            this.label81.TabIndex = 276;
            this.label81.Text = "SC:";
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Location = new System.Drawing.Point(258, 112);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(98, 13);
            this.label80.TabIndex = 275;
            this.label80.Text = "Texto de Correção:";
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.Location = new System.Drawing.Point(593, 69);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(57, 18);
            this.button16.TabIndex = 274;
            this.button16.Text = "Imp. CC.";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(593, 50);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(57, 18);
            this.button15.TabIndex = 273;
            this.button15.Text = "Carta C.";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(402, 64);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(18, 22);
            this.button11.TabIndex = 270;
            this.button11.Text = "-";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click_1);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(593, 14);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(57, 37);
            this.button14.TabIndex = 272;
            this.button14.Text = "Proc. NFe";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(153, 91);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(29, 13);
            this.label22.TabIndex = 269;
            this.label22.Text = "Hora";
            this.label22.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsNota_fiscal, "NOTA_FISCAL.HORA_AUTORIZACAO_NF", true));
            this.textBox1.Location = new System.Drawing.Point(203, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(87, 20);
            this.textBox1.TabIndex = 268;
            this.textBox1.Visible = false;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(9, 91);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(30, 13);
            this.label36.TabIndex = 267;
            this.label36.Text = "Data";
            this.label36.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsNota_fiscal, "NOTA_FISCAL.DATA_AUTORIZACAO_NF", true));
            this.textBox2.Location = new System.Drawing.Point(63, 87);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(84, 20);
            this.textBox2.TabIndex = 266;
            this.textBox2.Visible = false;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(402, 13);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(18, 22);
            this.button7.TabIndex = 265;
            this.button7.Text = "-";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click_2);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 264;
            this.label3.Text = "Motivo Cancelamento";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_motivo_cancelamento
            // 
            this.tb_motivo_cancelamento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsNota_fiscal, "NOTA_FISCAL.MOTIVO_CANCELAMENTO_NF", true));
            this.tb_motivo_cancelamento.Location = new System.Drawing.Point(124, 109);
            this.tb_motivo_cancelamento.Name = "tb_motivo_cancelamento";
            this.tb_motivo_cancelamento.Size = new System.Drawing.Size(128, 20);
            this.tb_motivo_cancelamento.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 262;
            this.label1.Text = "Nº Protocolo de Autorização:";
            // 
            // tb_protocolo_autorizacao
            // 
            this.tb_protocolo_autorizacao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsNota_fiscal, "NOTA_FISCAL.N_PROTOCOLO_AUTORIZACAO_NF", true));
            this.tb_protocolo_autorizacao.Location = new System.Drawing.Point(153, 65);
            this.tb_protocolo_autorizacao.Name = "tb_protocolo_autorizacao";
            this.tb_protocolo_autorizacao.Size = new System.Drawing.Size(244, 20);
            this.tb_protocolo_autorizacao.TabIndex = 261;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(481, 50);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(57, 37);
            this.button3.TabIndex = 33;
            this.button3.Text = "Reenviar Email";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.Location = new System.Drawing.Point(6, 45);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(90, 13);
            this.label47.TabIndex = 259;
            this.label47.Text = "Chave de Acesso";
            // 
            // tb_chave_acesso_nfe
            // 
            this.tb_chave_acesso_nfe.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsNota_fiscal, "NOTA_FISCAL.CHAVE_ACESSO_NFE", true));
            this.tb_chave_acesso_nfe.Location = new System.Drawing.Point(102, 41);
            this.tb_chave_acesso_nfe.Name = "tb_chave_acesso_nfe";
            this.tb_chave_acesso_nfe.ReadOnly = true;
            this.tb_chave_acesso_nfe.Size = new System.Drawing.Size(318, 20);
            this.tb_chave_acesso_nfe.TabIndex = 258;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.Location = new System.Drawing.Point(214, 19);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(39, 13);
            this.label45.TabIndex = 257;
            this.label45.Text = "Recibo";
            // 
            // tb_recibo
            // 
            this.tb_recibo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsNota_fiscal, "NOTA_FISCAL.RECIBO_NFE", true));
            this.tb_recibo.Location = new System.Drawing.Point(268, 15);
            this.tb_recibo.Name = "tb_recibo";
            this.tb_recibo.ReadOnly = true;
            this.tb_recibo.Size = new System.Drawing.Size(129, 20);
            this.tb_recibo.TabIndex = 256;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(9, 18);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(37, 13);
            this.label44.TabIndex = 255;
            this.label44.Text = "Status";
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(158, 506);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(52, 23);
            this.button12.TabIndex = 271;
            this.button12.Text = "Teste";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Visible = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.Location = new System.Drawing.Point(338, 12);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(42, 18);
            this.label46.TabIndex = 256;
            this.label46.Text = "0 - Entrada\r\n1 - Saída";
            // 
            // tb_ent_sai_nfe
            // 
            this.tb_ent_sai_nfe.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsNota_fiscal, "NOTA_FISCAL.ENTRADA_SAIDA_NF", true));
            this.tb_ent_sai_nfe.Location = new System.Drawing.Point(311, 10);
            this.tb_ent_sai_nfe.Name = "tb_ent_sai_nfe";
            this.tb_ent_sai_nfe.Size = new System.Drawing.Size(16, 20);
            this.tb_ent_sai_nfe.TabIndex = 255;
            // 
            // datForma_pgto
            // 
            this.datForma_pgto.DeleteCommand = this.fbCommand52;
            this.datForma_pgto.InsertCommand = this.fbCommand50;
            this.datForma_pgto.SelectCommand = this.fbCommand49;
            this.datForma_pgto.UpdateCommand = this.fbCommand51;
            // 
            // fbCommand52
            // 
            this.fbCommand52.CommandTimeout = 30;
            // 
            // fbCommand50
            // 
            this.fbCommand50.CommandTimeout = 30;
            // 
            // fbCommand49
            // 
            this.fbCommand49.CommandText = "select * from forma_pgto";
            this.fbCommand49.CommandTimeout = 30;
            this.fbCommand49.Connection = this.fbConnection1;
            // 
            // fbCommand51
            // 
            this.fbCommand51.CommandTimeout = 30;
            // 
            // dsForma_pgto
            // 
            this.dsForma_pgto.DataSetName = "dsForma_pgto";
            this.dsForma_pgto.Namespace = "http://www.tempuri.org/dsForma_pgto.xsd";
            this.dsForma_pgto.Tables.AddRange(new System.Data.DataTable[] {
            this.FORMA_PGTO});
            // 
            // FORMA_PGTO
            // 
            this.FORMA_PGTO.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_FORMA_PGTO,
            this.DESCRICAO_FORMA_PGTO,
            this.N_PARCELAS_FORMA_PGTO,
            this.PRAZO_1_FORMA_PGTO,
            this.PRAZO_2_FORMA_PGTO,
            this.PRAZO_3_FORMA_PGTO,
            this.PRAZO_4_FORMA_PGTO,
            this.PRAZO_5_FORMA_PGTO,
            this.PRAZO_6_FORMA_PGTO});
            this.FORMA_PGTO.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_FORMA_PGTO"}, true)});
            this.FORMA_PGTO.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_FORMA_PGTO};
            this.FORMA_PGTO.TableName = "FORMA_PGTO";
            // 
            // COD_FORMA_PGTO
            // 
            this.COD_FORMA_PGTO.AllowDBNull = false;
            this.COD_FORMA_PGTO.ColumnName = "COD_FORMA_PGTO";
            this.COD_FORMA_PGTO.DataType = typeof(int);
            // 
            // DESCRICAO_FORMA_PGTO
            // 
            this.DESCRICAO_FORMA_PGTO.ColumnName = "DESCRICAO_FORMA_PGTO";
            this.DESCRICAO_FORMA_PGTO.MaxLength = 100;
            // 
            // N_PARCELAS_FORMA_PGTO
            // 
            this.N_PARCELAS_FORMA_PGTO.ColumnName = "N_PARCELAS_FORMA_PGTO";
            this.N_PARCELAS_FORMA_PGTO.DataType = typeof(int);
            // 
            // PRAZO_1_FORMA_PGTO
            // 
            this.PRAZO_1_FORMA_PGTO.ColumnName = "PRAZO_1_FORMA_PGTO";
            this.PRAZO_1_FORMA_PGTO.DataType = typeof(int);
            // 
            // PRAZO_2_FORMA_PGTO
            // 
            this.PRAZO_2_FORMA_PGTO.ColumnName = "PRAZO_2_FORMA_PGTO";
            this.PRAZO_2_FORMA_PGTO.DataType = typeof(int);
            // 
            // PRAZO_3_FORMA_PGTO
            // 
            this.PRAZO_3_FORMA_PGTO.ColumnName = "PRAZO_3_FORMA_PGTO";
            this.PRAZO_3_FORMA_PGTO.DataType = typeof(int);
            // 
            // PRAZO_4_FORMA_PGTO
            // 
            this.PRAZO_4_FORMA_PGTO.ColumnName = "PRAZO_4_FORMA_PGTO";
            this.PRAZO_4_FORMA_PGTO.DataType = typeof(int);
            // 
            // PRAZO_5_FORMA_PGTO
            // 
            this.PRAZO_5_FORMA_PGTO.ColumnName = "PRAZO_5_FORMA_PGTO";
            this.PRAZO_5_FORMA_PGTO.DataType = typeof(int);
            // 
            // PRAZO_6_FORMA_PGTO
            // 
            this.PRAZO_6_FORMA_PGTO.ColumnName = "PRAZO_6_FORMA_PGTO";
            this.PRAZO_6_FORMA_PGTO.DataType = typeof(int);
            // 
            // cb_forma_pgto
            // 
            this.cb_forma_pgto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsNota_fiscal, "NOTA_FISCAL.FORMA_PGTO_NF", true));
            this.cb_forma_pgto.Location = new System.Drawing.Point(150, 4);
            this.cb_forma_pgto.Name = "cb_forma_pgto";
            this.cb_forma_pgto.ReadOnly = true;
            this.cb_forma_pgto.Size = new System.Drawing.Size(95, 20);
            this.cb_forma_pgto.TabIndex = 18;
            // 
            // tb_cfo_peca
            // 
            this.tb_cfo_peca.Location = new System.Drawing.Point(536, 15);
            this.tb_cfo_peca.Name = "tb_cfo_peca";
            this.tb_cfo_peca.Size = new System.Drawing.Size(61, 20);
            this.tb_cfo_peca.TabIndex = 15;
            this.tb_cfo_peca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_cfo_peca.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tb_cfo_peca_MouseDoubleClick);
            // 
            // tb_natureza_operacao
            // 
            this.tb_natureza_operacao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsNota_fiscal, "NOTA_FISCAL.NATUREZA_OPERACAO_NF", true));
            this.tb_natureza_operacao.Location = new System.Drawing.Point(299, 81);
            this.tb_natureza_operacao.Name = "tb_natureza_operacao";
            this.tb_natureza_operacao.Size = new System.Drawing.Size(255, 20);
            this.tb_natureza_operacao.TabIndex = 5;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.Location = new System.Drawing.Point(169, 84);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(130, 13);
            this.label48.TabIndex = 260;
            this.label48.Text = "Natureza Operação: *";
            // 
            // datFatura_nf
            // 
            this.datFatura_nf.DeleteCommand = this.fbCommand56;
            this.datFatura_nf.InsertCommand = this.fbCommand54;
            this.datFatura_nf.SelectCommand = this.fbCommand53;
            this.datFatura_nf.UpdateCommand = this.fbCommand55;
            // 
            // fbCommand56
            // 
            this.fbCommand56.CommandTimeout = 30;
            // 
            // fbCommand54
            // 
            this.fbCommand54.CommandTimeout = 30;
            // 
            // fbCommand53
            // 
            this.fbCommand53.CommandText = "select * from fatura_nf";
            this.fbCommand53.CommandTimeout = 30;
            this.fbCommand53.Connection = this.fbConnection1;
            // 
            // fbCommand55
            // 
            this.fbCommand55.CommandTimeout = 30;
            // 
            // tb_cliente
            // 
            this.tb_cliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsNota_fiscal, "NOTA_FISCAL.CLIENTE_FORN_NF", true));
            this.tb_cliente.Location = new System.Drawing.Point(415, 103);
            this.tb_cliente.Name = "tb_cliente";
            this.tb_cliente.Size = new System.Drawing.Size(212, 20);
            this.tb_cliente.TabIndex = 8;
            // 
            // datImp_duplicatas
            // 
            this.datImp_duplicatas.DeleteCommand = this.fbCommand60;
            this.datImp_duplicatas.InsertCommand = this.fbCommand58;
            this.datImp_duplicatas.SelectCommand = this.fbCommand57;
            this.datImp_duplicatas.UpdateCommand = this.fbCommand59;
            // 
            // fbCommand60
            // 
            this.fbCommand60.CommandTimeout = 30;
            // 
            // fbCommand58
            // 
            this.fbCommand58.CommandTimeout = 30;
            // 
            // fbCommand57
            // 
            this.fbCommand57.CommandText = "select * from imp_duplicatas";
            this.fbCommand57.CommandTimeout = 30;
            this.fbCommand57.Connection = this.fbConnection1;
            // 
            // fbCommand59
            // 
            this.fbCommand59.CommandTimeout = 30;
            // 
            // dsImp_duplicatas
            // 
            this.dsImp_duplicatas.DataSetName = "dsImp_duplicatas";
            this.dsImp_duplicatas.Namespace = "http://www.tempuri.org/dsImp_duplicatas.xsd";
            this.dsImp_duplicatas.Tables.AddRange(new System.Data.DataTable[] {
            this.IMP_DUPLICATAS});
            // 
            // IMP_DUPLICATAS
            // 
            this.IMP_DUPLICATAS.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_IMP_DUPLICATA,
            this.COD_1_IMP_DUPLICATA,
            this.DATA_1_IMP_DUPLICATA,
            this.VALOR_1_IMP_DUPLICATA,
            this.COD_2_IMP_DUPLICATA,
            this.DATA_2_IMP_DUPLICATA,
            this.VALOR_2_IMP_DUPLICATA,
            this.COD_3_IMP_DUPLICATA,
            this.DATA_3_IMP_DUPLICATA,
            this.VALOR_3_IMP_DUPLICATA,
            this.COD_4_IMP_DUPLICATA,
            this.DATA_4_IMP_DUPLICATA,
            this.VALOR_4_IMP_DUPLICATA,
            this.COD_5_IMP_DUPLICATA,
            this.DATA_5_IMP_DUPLICATA,
            this.VALOR_5_IMP_DUPLICATA,
            this.COD_6_IMP_DUPLICATA,
            this.DATA_6_IMP_DUPLICATA,
            this.VALOR_6_IMP_DUPLICATA});
            this.IMP_DUPLICATAS.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_IMP_DUPLICATA"}, true)});
            this.IMP_DUPLICATAS.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_IMP_DUPLICATA};
            this.IMP_DUPLICATAS.TableName = "IMP_DUPLICATAS";
            // 
            // COD_IMP_DUPLICATA
            // 
            this.COD_IMP_DUPLICATA.AllowDBNull = false;
            this.COD_IMP_DUPLICATA.ColumnName = "COD_IMP_DUPLICATA";
            this.COD_IMP_DUPLICATA.DataType = typeof(int);
            // 
            // COD_1_IMP_DUPLICATA
            // 
            this.COD_1_IMP_DUPLICATA.ColumnName = "COD_1_IMP_DUPLICATA";
            this.COD_1_IMP_DUPLICATA.DataType = typeof(int);
            // 
            // DATA_1_IMP_DUPLICATA
            // 
            this.DATA_1_IMP_DUPLICATA.ColumnName = "DATA_1_IMP_DUPLICATA";
            this.DATA_1_IMP_DUPLICATA.DataType = typeof(System.DateTime);
            // 
            // VALOR_1_IMP_DUPLICATA
            // 
            this.VALOR_1_IMP_DUPLICATA.ColumnName = "VALOR_1_IMP_DUPLICATA";
            this.VALOR_1_IMP_DUPLICATA.DataType = typeof(double);
            // 
            // COD_2_IMP_DUPLICATA
            // 
            this.COD_2_IMP_DUPLICATA.ColumnName = "COD_2_IMP_DUPLICATA";
            this.COD_2_IMP_DUPLICATA.DataType = typeof(int);
            // 
            // DATA_2_IMP_DUPLICATA
            // 
            this.DATA_2_IMP_DUPLICATA.ColumnName = "DATA_2_IMP_DUPLICATA";
            this.DATA_2_IMP_DUPLICATA.DataType = typeof(System.DateTime);
            // 
            // VALOR_2_IMP_DUPLICATA
            // 
            this.VALOR_2_IMP_DUPLICATA.ColumnName = "VALOR_2_IMP_DUPLICATA";
            this.VALOR_2_IMP_DUPLICATA.DataType = typeof(double);
            // 
            // COD_3_IMP_DUPLICATA
            // 
            this.COD_3_IMP_DUPLICATA.ColumnName = "COD_3_IMP_DUPLICATA";
            this.COD_3_IMP_DUPLICATA.DataType = typeof(int);
            // 
            // DATA_3_IMP_DUPLICATA
            // 
            this.DATA_3_IMP_DUPLICATA.ColumnName = "DATA_3_IMP_DUPLICATA";
            this.DATA_3_IMP_DUPLICATA.DataType = typeof(System.DateTime);
            // 
            // VALOR_3_IMP_DUPLICATA
            // 
            this.VALOR_3_IMP_DUPLICATA.ColumnName = "VALOR_3_IMP_DUPLICATA";
            this.VALOR_3_IMP_DUPLICATA.DataType = typeof(double);
            // 
            // COD_4_IMP_DUPLICATA
            // 
            this.COD_4_IMP_DUPLICATA.ColumnName = "COD_4_IMP_DUPLICATA";
            this.COD_4_IMP_DUPLICATA.DataType = typeof(int);
            // 
            // DATA_4_IMP_DUPLICATA
            // 
            this.DATA_4_IMP_DUPLICATA.ColumnName = "DATA_4_IMP_DUPLICATA";
            this.DATA_4_IMP_DUPLICATA.DataType = typeof(System.DateTime);
            // 
            // VALOR_4_IMP_DUPLICATA
            // 
            this.VALOR_4_IMP_DUPLICATA.ColumnName = "VALOR_4_IMP_DUPLICATA";
            this.VALOR_4_IMP_DUPLICATA.DataType = typeof(double);
            // 
            // COD_5_IMP_DUPLICATA
            // 
            this.COD_5_IMP_DUPLICATA.ColumnName = "COD_5_IMP_DUPLICATA";
            this.COD_5_IMP_DUPLICATA.DataType = typeof(int);
            // 
            // DATA_5_IMP_DUPLICATA
            // 
            this.DATA_5_IMP_DUPLICATA.ColumnName = "DATA_5_IMP_DUPLICATA";
            this.DATA_5_IMP_DUPLICATA.DataType = typeof(System.DateTime);
            // 
            // VALOR_5_IMP_DUPLICATA
            // 
            this.VALOR_5_IMP_DUPLICATA.ColumnName = "VALOR_5_IMP_DUPLICATA";
            this.VALOR_5_IMP_DUPLICATA.DataType = typeof(double);
            // 
            // COD_6_IMP_DUPLICATA
            // 
            this.COD_6_IMP_DUPLICATA.ColumnName = "COD_6_IMP_DUPLICATA";
            this.COD_6_IMP_DUPLICATA.DataType = typeof(int);
            // 
            // DATA_6_IMP_DUPLICATA
            // 
            this.DATA_6_IMP_DUPLICATA.ColumnName = "DATA_6_IMP_DUPLICATA";
            this.DATA_6_IMP_DUPLICATA.DataType = typeof(System.DateTime);
            // 
            // VALOR_6_IMP_DUPLICATA
            // 
            this.VALOR_6_IMP_DUPLICATA.ColumnName = "VALOR_6_IMP_DUPLICATA";
            this.VALOR_6_IMP_DUPLICATA.DataType = typeof(double);
            // 
            // datAliquota
            // 
            this.datAliquota.DeleteCommand = this.fbCommand64;
            this.datAliquota.InsertCommand = this.fbCommand62;
            this.datAliquota.SelectCommand = this.fbCommand61;
            this.datAliquota.UpdateCommand = this.fbCommand63;
            // 
            // fbCommand64
            // 
            this.fbCommand64.CommandTimeout = 30;
            // 
            // fbCommand62
            // 
            this.fbCommand62.CommandTimeout = 30;
            // 
            // fbCommand61
            // 
            this.fbCommand61.CommandText = "select * from aliquota_simples";
            this.fbCommand61.CommandTimeout = 30;
            this.fbCommand61.Connection = this.fbConnection1;
            // 
            // fbCommand63
            // 
            this.fbCommand63.CommandTimeout = 30;
            // 
            // dsAliquota
            // 
            this.dsAliquota.DataSetName = "dsAliquota";
            this.dsAliquota.Namespace = "http://www.tempuri.org/dsAliquota.xsd";
            this.dsAliquota.Tables.AddRange(new System.Data.DataTable[] {
            this.ALIQUOTA_SIMPLES});
            // 
            // ALIQUOTA_SIMPLES
            // 
            this.ALIQUOTA_SIMPLES.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_ALIQUOTA,
            this.VALOR_ALIQUOTA});
            this.ALIQUOTA_SIMPLES.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_ALIQUOTA"}, true)});
            this.ALIQUOTA_SIMPLES.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_ALIQUOTA};
            this.ALIQUOTA_SIMPLES.TableName = "ALIQUOTA_SIMPLES";
            // 
            // COD_ALIQUOTA
            // 
            this.COD_ALIQUOTA.AllowDBNull = false;
            this.COD_ALIQUOTA.ColumnName = "COD_ALIQUOTA";
            this.COD_ALIQUOTA.DataType = typeof(int);
            // 
            // VALOR_ALIQUOTA
            // 
            this.VALOR_ALIQUOTA.ColumnName = "VALOR_ALIQUOTA";
            this.VALOR_ALIQUOTA.DataType = typeof(double);
            // 
            // datContas_a_receber
            // 
            this.datContas_a_receber.DeleteCommand = this.fbCommand68;
            this.datContas_a_receber.InsertCommand = this.fbCommand66;
            this.datContas_a_receber.SelectCommand = this.fbCommand65;
            this.datContas_a_receber.UpdateCommand = this.fbCommand67;
            // 
            // fbCommand68
            // 
            this.fbCommand68.CommandTimeout = 30;
            // 
            // fbCommand66
            // 
            this.fbCommand66.CommandTimeout = 30;
            // 
            // fbCommand65
            // 
            this.fbCommand65.CommandText = "select * from contas_a_receber";
            this.fbCommand65.CommandTimeout = 30;
            this.fbCommand65.Connection = this.fbConnection1;
            // 
            // fbCommand67
            // 
            this.fbCommand67.CommandTimeout = 30;
            // 
            // dsContas_a_receber
            // 
            this.dsContas_a_receber.DataSetName = "dsContas_a_receber";
            this.dsContas_a_receber.Namespace = "http://www.tempuri.org/dsContas_a_receber.xsd";
            this.dsContas_a_receber.Tables.AddRange(new System.Data.DataTable[] {
            this.CONTAS_A_RECEBER});
            // 
            // CONTAS_A_RECEBER
            // 
            this.CONTAS_A_RECEBER.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_CR,
            this.VALOR_CR,
            this.DATA_PREVISTA_CR,
            this.DATA_RECEBIMENTO_CR,
            this.COD_CLIENTE_CR,
            this.RAZAO_CLIENTE_CR,
            this.DESCRICAO_CR,
            this.DUPLICATA_CR,
            this.NF_CR,
            this.RECEBIDO_CR,
            this.COD_CAIXA_CR});
            this.CONTAS_A_RECEBER.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_CR"}, true)});
            this.CONTAS_A_RECEBER.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_CR};
            this.CONTAS_A_RECEBER.TableName = "CONTAS_A_RECEBER";
            // 
            // COD_CR
            // 
            this.COD_CR.AllowDBNull = false;
            this.COD_CR.ColumnName = "COD_CR";
            this.COD_CR.DataType = typeof(int);
            // 
            // VALOR_CR
            // 
            this.VALOR_CR.ColumnName = "VALOR_CR";
            this.VALOR_CR.DataType = typeof(double);
            // 
            // DATA_PREVISTA_CR
            // 
            this.DATA_PREVISTA_CR.ColumnName = "DATA_PREVISTA_CR";
            this.DATA_PREVISTA_CR.DataType = typeof(System.DateTime);
            // 
            // DATA_RECEBIMENTO_CR
            // 
            this.DATA_RECEBIMENTO_CR.ColumnName = "DATA_RECEBIMENTO_CR";
            this.DATA_RECEBIMENTO_CR.DataType = typeof(System.DateTime);
            // 
            // COD_CLIENTE_CR
            // 
            this.COD_CLIENTE_CR.ColumnName = "COD_CLIENTE_CR";
            this.COD_CLIENTE_CR.DataType = typeof(int);
            // 
            // RAZAO_CLIENTE_CR
            // 
            this.RAZAO_CLIENTE_CR.ColumnName = "RAZAO_CLIENTE_CR";
            this.RAZAO_CLIENTE_CR.MaxLength = 100;
            // 
            // DESCRICAO_CR
            // 
            this.DESCRICAO_CR.ColumnName = "DESCRICAO_CR";
            this.DESCRICAO_CR.MaxLength = 200;
            // 
            // DUPLICATA_CR
            // 
            this.DUPLICATA_CR.ColumnName = "DUPLICATA_CR";
            this.DUPLICATA_CR.MaxLength = 20;
            // 
            // NF_CR
            // 
            this.NF_CR.ColumnName = "NF_CR";
            this.NF_CR.DataType = typeof(int);
            // 
            // RECEBIDO_CR
            // 
            this.RECEBIDO_CR.ColumnName = "RECEBIDO_CR";
            this.RECEBIDO_CR.DataType = typeof(int);
            // 
            // COD_CAIXA_CR
            // 
            this.COD_CAIXA_CR.ColumnName = "COD_CAIXA_CR";
            this.COD_CAIXA_CR.DataType = typeof(int);
            // 
            // pb_codigo
            // 
            this.pb_codigo.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.dsNota_fiscal, "NOTA_FISCAL.COD_BARRAS_NF", true));
            this.pb_codigo.Location = new System.Drawing.Point(74, 23);
            this.pb_codigo.Name = "pb_codigo";
            this.pb_codigo.Size = new System.Drawing.Size(86, 20);
            this.pb_codigo.TabIndex = 266;
            this.pb_codigo.TabStop = false;
            // 
            // datEmpresa
            // 
            this.datEmpresa.DeleteCommand = this.fbCommand72;
            this.datEmpresa.InsertCommand = this.fbCommand70;
            this.datEmpresa.SelectCommand = this.fbCommand69;
            this.datEmpresa.UpdateCommand = this.fbCommand71;
            // 
            // fbCommand72
            // 
            this.fbCommand72.CommandTimeout = 30;
            // 
            // fbCommand70
            // 
            this.fbCommand70.CommandTimeout = 30;
            // 
            // fbCommand69
            // 
            this.fbCommand69.CommandText = "select * from empresa";
            this.fbCommand69.CommandTimeout = 30;
            this.fbCommand69.Connection = this.fbConnection1;
            // 
            // fbCommand71
            // 
            this.fbCommand71.CommandTimeout = 30;
            // 
            // dsEmpresa
            // 
            this.dsEmpresa.DataSetName = "dsEmpresa";
            this.dsEmpresa.Namespace = "http://www.tempuri.org/dsEmpresa.xsd";
            this.dsEmpresa.Tables.AddRange(new System.Data.DataTable[] {
            this.EMPRESA});
            // 
            // EMPRESA
            // 
            this.EMPRESA.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_EMPRESA,
            this.RAZAO_SOCIAL_EMPRESA,
            this.NOME_FANTASIA_EMPRESA,
            this.CNPJ_EMPRESA,
            this.IE_EMPRESA,
            this.IM_EMPRESA,
            this.ENDERECO_EMPRESA,
            this.N_ENDERECO_EMPRESA,
            this.COMPLEMENTO_EMPRESA,
            this.BAIRRO_EMPRESA,
            this.CIDADE_EMPRESA,
            this.ESTADO_EMPRESA,
            this.CEP_EMPRESA,
            this.TELEFONE_EMPRESA,
            this.COD_CIDADE_EMPRESA,
            this.PAIS_EMPRESA,
            this.COD_PAIS_EMPRESA,
            this.LICENCA_DLL_NFE_EMPRESA,
            this.NOME_CERTIFICADO_NFE_EMPRESA,
            this.ASSUNTO_NFE_EMAIL_EMPRESA,
            this.SMTP_NFE_EMPRESA,
            this.EMAIL_NFE_EMPRESA,
            this.SENHA_EMAIL_NFE_EMPRESA,
            this.LOGOTIPO_EMPRESA,
            this.dataColumn46,
            this.dataColumn47,
            this.dataColumn48});
            this.EMPRESA.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_EMPRESA"}, true)});
            this.EMPRESA.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_EMPRESA};
            this.EMPRESA.TableName = "EMPRESA";
            // 
            // COD_EMPRESA
            // 
            this.COD_EMPRESA.AllowDBNull = false;
            this.COD_EMPRESA.ColumnName = "COD_EMPRESA";
            this.COD_EMPRESA.DataType = typeof(int);
            // 
            // RAZAO_SOCIAL_EMPRESA
            // 
            this.RAZAO_SOCIAL_EMPRESA.ColumnName = "RAZAO_SOCIAL_EMPRESA";
            this.RAZAO_SOCIAL_EMPRESA.MaxLength = 200;
            // 
            // NOME_FANTASIA_EMPRESA
            // 
            this.NOME_FANTASIA_EMPRESA.ColumnName = "NOME_FANTASIA_EMPRESA";
            this.NOME_FANTASIA_EMPRESA.MaxLength = 200;
            // 
            // CNPJ_EMPRESA
            // 
            this.CNPJ_EMPRESA.ColumnName = "CNPJ_EMPRESA";
            this.CNPJ_EMPRESA.MaxLength = 30;
            // 
            // IE_EMPRESA
            // 
            this.IE_EMPRESA.ColumnName = "IE_EMPRESA";
            this.IE_EMPRESA.MaxLength = 30;
            // 
            // IM_EMPRESA
            // 
            this.IM_EMPRESA.ColumnName = "IM_EMPRESA";
            this.IM_EMPRESA.MaxLength = 30;
            // 
            // ENDERECO_EMPRESA
            // 
            this.ENDERECO_EMPRESA.ColumnName = "ENDERECO_EMPRESA";
            this.ENDERECO_EMPRESA.MaxLength = 200;
            // 
            // N_ENDERECO_EMPRESA
            // 
            this.N_ENDERECO_EMPRESA.ColumnName = "N_ENDERECO_EMPRESA";
            this.N_ENDERECO_EMPRESA.MaxLength = 20;
            // 
            // COMPLEMENTO_EMPRESA
            // 
            this.COMPLEMENTO_EMPRESA.ColumnName = "COMPLEMENTO_EMPRESA";
            this.COMPLEMENTO_EMPRESA.MaxLength = 50;
            // 
            // BAIRRO_EMPRESA
            // 
            this.BAIRRO_EMPRESA.ColumnName = "BAIRRO_EMPRESA";
            this.BAIRRO_EMPRESA.MaxLength = 50;
            // 
            // CIDADE_EMPRESA
            // 
            this.CIDADE_EMPRESA.ColumnName = "CIDADE_EMPRESA";
            this.CIDADE_EMPRESA.MaxLength = 50;
            // 
            // ESTADO_EMPRESA
            // 
            this.ESTADO_EMPRESA.ColumnName = "ESTADO_EMPRESA";
            this.ESTADO_EMPRESA.MaxLength = 2;
            // 
            // CEP_EMPRESA
            // 
            this.CEP_EMPRESA.ColumnName = "CEP_EMPRESA";
            this.CEP_EMPRESA.MaxLength = 10;
            // 
            // TELEFONE_EMPRESA
            // 
            this.TELEFONE_EMPRESA.ColumnName = "TELEFONE_EMPRESA";
            this.TELEFONE_EMPRESA.MaxLength = 50;
            // 
            // COD_CIDADE_EMPRESA
            // 
            this.COD_CIDADE_EMPRESA.ColumnName = "COD_CIDADE_EMPRESA";
            this.COD_CIDADE_EMPRESA.MaxLength = 7;
            // 
            // PAIS_EMPRESA
            // 
            this.PAIS_EMPRESA.ColumnName = "PAIS_EMPRESA";
            this.PAIS_EMPRESA.MaxLength = 50;
            // 
            // COD_PAIS_EMPRESA
            // 
            this.COD_PAIS_EMPRESA.ColumnName = "COD_PAIS_EMPRESA";
            this.COD_PAIS_EMPRESA.MaxLength = 20;
            // 
            // LICENCA_DLL_NFE_EMPRESA
            // 
            this.LICENCA_DLL_NFE_EMPRESA.ColumnName = "LICENCA_DLL_NFE_EMPRESA";
            this.LICENCA_DLL_NFE_EMPRESA.MaxLength = 200;
            // 
            // NOME_CERTIFICADO_NFE_EMPRESA
            // 
            this.NOME_CERTIFICADO_NFE_EMPRESA.ColumnName = "NOME_CERTIFICADO_NFE_EMPRESA";
            this.NOME_CERTIFICADO_NFE_EMPRESA.MaxLength = 400;
            // 
            // ASSUNTO_NFE_EMAIL_EMPRESA
            // 
            this.ASSUNTO_NFE_EMAIL_EMPRESA.ColumnName = "ASSUNTO_NFE_EMAIL_EMPRESA";
            this.ASSUNTO_NFE_EMAIL_EMPRESA.MaxLength = 200;
            // 
            // SMTP_NFE_EMPRESA
            // 
            this.SMTP_NFE_EMPRESA.ColumnName = "SMTP_NFE_EMPRESA";
            this.SMTP_NFE_EMPRESA.MaxLength = 50;
            // 
            // EMAIL_NFE_EMPRESA
            // 
            this.EMAIL_NFE_EMPRESA.ColumnName = "EMAIL_NFE_EMPRESA";
            this.EMAIL_NFE_EMPRESA.MaxLength = 50;
            // 
            // SENHA_EMAIL_NFE_EMPRESA
            // 
            this.SENHA_EMAIL_NFE_EMPRESA.ColumnName = "SENHA_EMAIL_NFE_EMPRESA";
            this.SENHA_EMAIL_NFE_EMPRESA.MaxLength = 50;
            // 
            // LOGOTIPO_EMPRESA
            // 
            this.LOGOTIPO_EMPRESA.ColumnName = "LOGOTIPO_EMPRESA";
            this.LOGOTIPO_EMPRESA.DataType = typeof(byte[]);
            // 
            // dataColumn46
            // 
            this.dataColumn46.ColumnName = "PROXY_EMPRESA";
            this.dataColumn46.MaxLength = 20;
            // 
            // dataColumn47
            // 
            this.dataColumn47.ColumnName = "USUARIO_PROXY_EMPRESA";
            this.dataColumn47.MaxLength = 50;
            // 
            // dataColumn48
            // 
            this.dataColumn48.ColumnName = "SENHA_PROXY_EMPRESA";
            this.dataColumn48.MaxLength = 50;
            // 
            // datTributacao
            // 
            this.datTributacao.DeleteCommand = this.fbCommand76;
            this.datTributacao.InsertCommand = this.fbCommand74;
            this.datTributacao.SelectCommand = this.fbCommand73;
            this.datTributacao.UpdateCommand = this.fbCommand75;
            // 
            // fbCommand76
            // 
            this.fbCommand76.CommandTimeout = 30;
            // 
            // fbCommand74
            // 
            this.fbCommand74.CommandTimeout = 30;
            // 
            // fbCommand73
            // 
            this.fbCommand73.CommandText = "select * from tributacao";
            this.fbCommand73.CommandTimeout = 30;
            this.fbCommand73.Connection = this.fbConnection1;
            // 
            // fbCommand75
            // 
            this.fbCommand75.CommandTimeout = 30;
            // 
            // datProdutos
            // 
            this.datProdutos.DeleteCommand = this.fbCommand80;
            this.datProdutos.InsertCommand = this.fbCommand78;
            this.datProdutos.SelectCommand = this.fbCommand77;
            this.datProdutos.UpdateCommand = this.fbCommand79;
            // 
            // fbCommand80
            // 
            this.fbCommand80.CommandTimeout = 30;
            // 
            // fbCommand78
            // 
            this.fbCommand78.CommandTimeout = 30;
            // 
            // fbCommand77
            // 
            this.fbCommand77.CommandText = "select * from produtos";
            this.fbCommand77.CommandTimeout = 30;
            this.fbCommand77.Connection = this.fbConnection1;
            // 
            // fbCommand79
            // 
            this.fbCommand79.CommandTimeout = 30;
            // 
            // tb_desconto
            // 
            this.tb_desconto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsNota_fiscal, "NOTA_FISCAL.DESCONTO_NF", true));
            this.tb_desconto.Location = new System.Drawing.Point(224, 83);
            this.tb_desconto.Name = "tb_desconto";
            this.tb_desconto.Size = new System.Drawing.Size(98, 20);
            this.tb_desconto.TabIndex = 271;
            // 
            // label_desconto
            // 
            this.label_desconto.AutoSize = true;
            this.label_desconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_desconto.Location = new System.Drawing.Point(221, 71);
            this.label_desconto.Name = "label_desconto";
            this.label_desconto.Size = new System.Drawing.Size(52, 13);
            this.label_desconto.TabIndex = 270;
            this.label_desconto.Text = "Desconto";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.button24);
            this.panel1.Controls.Add(this.label84);
            this.panel1.Controls.Add(this.tb_finalidade);
            this.panel1.Controls.Add(this.button20);
            this.panel1.Controls.Add(this.tb_estado_cliente);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.tb_cliente);
            this.panel1.Controls.Add(this.tb_natureza_operacao);
            this.panel1.Controls.Add(this.label48);
            this.panel1.Controls.Add(this.label46);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.novo_registro);
            this.panel1.Controls.Add(this.pb_codigo);
            this.panel1.Controls.Add(this.tb_ent_sai_nfe);
            this.panel1.Controls.Add(this.tb_cnpj_cliente);
            this.panel1.Controls.Add(this.salva_registro);
            this.panel1.Controls.Add(this.tb_cod_interno);
            this.panel1.Controls.Add(this.label34);
            this.panel1.Controls.Add(this.radioSaida);
            this.panel1.Controls.Add(this.radioEntrada);
            this.panel1.Controls.Add(this.tb_data_emissao);
            this.panel1.Controls.Add(this.label30);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tb_saida);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tb_n_nf);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(7, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(701, 129);
            this.panel1.TabIndex = 272;
            // 
            // button24
            // 
            this.button24.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button24.Location = new System.Drawing.Point(624, 75);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(72, 20);
            this.button24.TabIndex = 37;
            this.button24.Text = "Importar XLS";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label84.Location = new System.Drawing.Point(96, 11);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(42, 9);
            this.label84.TabIndex = 271;
            this.label84.Text = "Finalidade:";
            // 
            // tb_finalidade
            // 
            this.tb_finalidade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsNota_fiscal, "NOTA_FISCAL.FINALIDADE_NF", true));
            this.tb_finalidade.Location = new System.Drawing.Point(138, 3);
            this.tb_finalidade.Name = "tb_finalidade";
            this.tb_finalidade.Size = new System.Drawing.Size(16, 20);
            this.tb_finalidade.TabIndex = 270;
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button20.Location = new System.Drawing.Point(624, 12);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(72, 60);
            this.button20.TabIndex = 269;
            this.button20.Text = "Criar Nota Devolução";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // tb_estado_cliente
            // 
            this.tb_estado_cliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsNota_fiscal, "NOTA_FISCAL.ESTADO_CLIENTE_NF", true));
            this.tb_estado_cliente.Location = new System.Drawing.Point(630, 103);
            this.tb_estado_cliente.Name = "tb_estado_cliente";
            this.tb_estado_cliente.Size = new System.Drawing.Size(39, 20);
            this.tb_estado_cliente.TabIndex = 268;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(393, 12);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(59, 60);
            this.button8.TabIndex = 267;
            this.button8.Text = "Localizar";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.label86);
            this.panel2.Controls.Add(this.tb_cl);
            this.panel2.Controls.Add(this.button25);
            this.panel2.Controls.Add(this.cbxCfopPadrao);
            this.panel2.Controls.Add(this.label79);
            this.panel2.Controls.Add(this.tb_ean);
            this.panel2.Controls.Add(this.button13);
            this.panel2.Controls.Add(this.label64);
            this.panel2.Controls.Add(this.tb_mod_bc_st_item);
            this.panel2.Controls.Add(this.button10);
            this.panel2.Controls.Add(this.label52);
            this.panel2.Controls.Add(this.tb_mod_bc_item);
            this.panel2.Controls.Add(this.label50);
            this.panel2.Controls.Add(this.tb_cst);
            this.panel2.Controls.Add(this.label43);
            this.panel2.Controls.Add(this.tb_origem_peca);
            this.panel2.Controls.Add(this.label41);
            this.panel2.Controls.Add(this.label40);
            this.panel2.Controls.Add(this.label39);
            this.panel2.Controls.Add(this.label32);
            this.panel2.Controls.Add(this.label28);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.tb_cfo_peca);
            this.panel2.Controls.Add(this.tb_ncm_peca);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.tb_descricao_peca);
            this.panel2.Controls.Add(this.tb_cod_peca);
            this.panel2.Controls.Add(this.tb_preco_unit_peca);
            this.panel2.Controls.Add(this.tb_qtde_peca);
            this.panel2.Controls.Add(this.tb_unid_peca);
            this.panel2.Location = new System.Drawing.Point(1, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(627, 72);
            this.panel2.TabIndex = 273;
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label86.Location = new System.Drawing.Point(593, 37);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(23, 12);
            this.label86.TabIndex = 39;
            this.label86.Text = "C.L.";
            // 
            // tb_cl
            // 
            this.tb_cl.Location = new System.Drawing.Point(589, 49);
            this.tb_cl.Name = "tb_cl";
            this.tb_cl.Size = new System.Drawing.Size(30, 20);
            this.tb_cl.TabIndex = 38;
            this.tb_cl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button25
            // 
            this.button25.Enabled = false;
            this.button25.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button25.Location = new System.Drawing.Point(4, 22);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(45, 20);
            this.button25.TabIndex = 37;
            this.button25.Text = "Roman.";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.button25_Click);
            // 
            // cbxCfopPadrao
            // 
            this.cbxCfopPadrao.AutoSize = true;
            this.cbxCfopPadrao.Location = new System.Drawing.Point(603, 18);
            this.cbxCfopPadrao.Name = "cbxCfopPadrao";
            this.cbxCfopPadrao.Size = new System.Drawing.Size(15, 14);
            this.cbxCfopPadrao.TabIndex = 36;
            this.cbxCfopPadrao.UseVisualStyleBackColor = true;
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label79.Location = new System.Drawing.Point(540, 37);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(25, 12);
            this.label79.TabIndex = 35;
            this.label79.Text = "EAN";
            // 
            // tb_ean
            // 
            this.tb_ean.Location = new System.Drawing.Point(527, 49);
            this.tb_ean.Name = "tb_ean";
            this.tb_ean.Size = new System.Drawing.Size(61, 20);
            this.tb_ean.TabIndex = 34;
            this.tb_ean.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(4, 22);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(45, 20);
            this.button13.TabIndex = 33;
            this.button13.Text = "Prod.";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Visible = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label64.Location = new System.Drawing.Point(375, 37);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(141, 12);
            this.label64.TabIndex = 32;
            this.label64.Text = "Modalidade de Determ. da BC ST";
            // 
            // tb_mod_bc_st_item
            // 
            this.tb_mod_bc_st_item.Location = new System.Drawing.Point(377, 49);
            this.tb_mod_bc_st_item.Name = "tb_mod_bc_st_item";
            this.tb_mod_bc_st_item.Size = new System.Drawing.Size(149, 20);
            this.tb_mod_bc_st_item.TabIndex = 31;
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(4, 3);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(45, 20);
            this.button10.TabIndex = 30;
            this.button10.Text = "Ped.";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click_1);
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.Location = new System.Drawing.Point(224, 37);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(152, 12);
            this.label52.TabIndex = 29;
            this.label52.Text = "Modalidade de Determinação da BC";
            // 
            // tb_mod_bc_item
            // 
            this.tb_mod_bc_item.Location = new System.Drawing.Point(226, 49);
            this.tb_mod_bc_item.Name = "tb_mod_bc_item";
            this.tb_mod_bc_item.Size = new System.Drawing.Size(149, 20);
            this.tb_mod_bc_item.TabIndex = 28;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.Location = new System.Drawing.Point(162, 37);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(59, 12);
            this.label50.TabIndex = 27;
            this.label50.Text = "CST/CSOSN";
            // 
            // tb_cst
            // 
            this.tb_cst.Location = new System.Drawing.Point(163, 49);
            this.tb_cst.Name = "tb_cst";
            this.tb_cst.Size = new System.Drawing.Size(60, 20);
            this.tb_cst.TabIndex = 26;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.Location = new System.Drawing.Point(49, 37);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(69, 12);
            this.label43.TabIndex = 25;
            this.label43.Text = "Origem Produto";
            // 
            // tb_origem_peca
            // 
            this.tb_origem_peca.Location = new System.Drawing.Point(51, 49);
            this.tb_origem_peca.Name = "tb_origem_peca";
            this.tb_origem_peca.Size = new System.Drawing.Size(109, 20);
            this.tb_origem_peca.TabIndex = 24;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(549, 3);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(31, 12);
            this.label41.TabIndex = 23;
            this.label41.Text = "CFOP";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(484, 3);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(28, 12);
            this.label40.TabIndex = 22;
            this.label40.Text = "NCM";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(404, 3);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(63, 12);
            this.label39.TabIndex = 21;
            this.label39.Text = "Preço Unitário";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(373, 3);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(25, 12);
            this.label32.TabIndex = 20;
            this.label32.Text = "Qtde";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(334, 3);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(27, 12);
            this.label28.TabIndex = 19;
            this.label28.Text = "Unid.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(134, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 12);
            this.label9.TabIndex = 18;
            this.label9.Text = "Descrição Produto/Serviço";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(49, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 12);
            this.label7.TabIndex = 17;
            this.label7.Text = "Cód. Prod.";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.label74);
            this.panel3.Controls.Add(this.tb_n_item_pedido_compra);
            this.panel3.Controls.Add(this.label73);
            this.panel3.Controls.Add(this.tb_pedido_compra);
            this.panel3.Controls.Add(this.label53);
            this.panel3.Controls.Add(this.tb_seguro_item);
            this.panel3.Controls.Add(this.label51);
            this.panel3.Controls.Add(this.tb_outras_desp_item);
            this.panel3.Controls.Add(this.label49);
            this.panel3.Controls.Add(this.tb_desconto_item);
            this.panel3.Controls.Add(this.label42);
            this.panel3.Controls.Add(this.tb_frete_item);
            this.panel3.Location = new System.Drawing.Point(3, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(373, 35);
            this.panel3.TabIndex = 274;
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label74.Location = new System.Drawing.Point(340, 1);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(24, 12);
            this.label74.TabIndex = 44;
            this.label74.Text = "Item";
            // 
            // tb_n_item_pedido_compra
            // 
            this.tb_n_item_pedido_compra.Location = new System.Drawing.Point(337, 13);
            this.tb_n_item_pedido_compra.Name = "tb_n_item_pedido_compra";
            this.tb_n_item_pedido_compra.Size = new System.Drawing.Size(33, 20);
            this.tb_n_item_pedido_compra.TabIndex = 43;
            this.tb_n_item_pedido_compra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label73.Location = new System.Drawing.Point(285, 1);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(58, 12);
            this.label73.TabIndex = 42;
            this.label73.Text = "Pedido Com.";
            // 
            // tb_pedido_compra
            // 
            this.tb_pedido_compra.Location = new System.Drawing.Point(287, 13);
            this.tb_pedido_compra.Name = "tb_pedido_compra";
            this.tb_pedido_compra.Size = new System.Drawing.Size(51, 20);
            this.tb_pedido_compra.TabIndex = 41;
            this.tb_pedido_compra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label53.Location = new System.Drawing.Point(226, 1);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(34, 12);
            this.label53.TabIndex = 40;
            this.label53.Text = "Seguro";
            // 
            // tb_seguro_item
            // 
            this.tb_seguro_item.Location = new System.Drawing.Point(211, 13);
            this.tb_seguro_item.Name = "tb_seguro_item";
            this.tb_seguro_item.Size = new System.Drawing.Size(69, 20);
            this.tb_seguro_item.TabIndex = 39;
            this.tb_seguro_item.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label51.Location = new System.Drawing.Point(147, 1);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(60, 12);
            this.label51.TabIndex = 33;
            this.label51.Text = "Outras Desp.";
            // 
            // tb_outras_desp_item
            // 
            this.tb_outras_desp_item.Location = new System.Drawing.Point(143, 13);
            this.tb_outras_desp_item.Name = "tb_outras_desp_item";
            this.tb_outras_desp_item.Size = new System.Drawing.Size(69, 20);
            this.tb_outras_desp_item.TabIndex = 32;
            this.tb_outras_desp_item.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.Location = new System.Drawing.Point(86, 1);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(45, 12);
            this.label49.TabIndex = 29;
            this.label49.Text = "Desconto";
            // 
            // tb_desconto_item
            // 
            this.tb_desconto_item.Location = new System.Drawing.Point(76, 13);
            this.tb_desconto_item.Name = "tb_desconto_item";
            this.tb_desconto_item.Size = new System.Drawing.Size(69, 20);
            this.tb_desconto_item.TabIndex = 28;
            this.tb_desconto_item.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(24, 1);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(27, 12);
            this.label42.TabIndex = 25;
            this.label42.Text = "Frete";
            // 
            // tb_frete_item
            // 
            this.tb_frete_item.Location = new System.Drawing.Point(9, 13);
            this.tb_frete_item.Name = "tb_frete_item";
            this.tb_frete_item.Size = new System.Drawing.Size(69, 20);
            this.tb_frete_item.TabIndex = 24;
            this.tb_frete_item.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel4.Controls.Add(this.label65);
            this.panel4.Controls.Add(this.tb_reducao_st_item);
            this.panel4.Controls.Add(this.label61);
            this.panel4.Controls.Add(this.label54);
            this.panel4.Controls.Add(this.tb_iss_item);
            this.panel4.Controls.Add(this.tb_cofins_item);
            this.panel4.Controls.Add(this.label55);
            this.panel4.Controls.Add(this.tb_pis_item);
            this.panel4.Controls.Add(this.label56);
            this.panel4.Controls.Add(this.tb_ipi_item);
            this.panel4.Controls.Add(this.label57);
            this.panel4.Controls.Add(this.tb_iva_item);
            this.panel4.Controls.Add(this.label58);
            this.panel4.Controls.Add(this.tb_reducao_item);
            this.panel4.Controls.Add(this.label59);
            this.panel4.Controls.Add(this.tb_icms_st);
            this.panel4.Controls.Add(this.label60);
            this.panel4.Controls.Add(this.tb_icms_item);
            this.panel4.Location = new System.Drawing.Point(3, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(376, 35);
            this.panel4.TabIndex = 275;
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label65.Location = new System.Drawing.Point(127, 1);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(38, 12);
            this.label65.TabIndex = 283;
            this.label65.Text = "Red. ST";
            // 
            // tb_reducao_st_item
            // 
            this.tb_reducao_st_item.Location = new System.Drawing.Point(127, 13);
            this.tb_reducao_st_item.Name = "tb_reducao_st_item";
            this.tb_reducao_st_item.Size = new System.Drawing.Size(42, 20);
            this.tb_reducao_st_item.TabIndex = 282;
            this.tb_reducao_st_item.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label61.Location = new System.Drawing.Point(336, 1);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(20, 12);
            this.label61.TabIndex = 281;
            this.label61.Text = "ISS";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54.Location = new System.Drawing.Point(289, 1);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(41, 12);
            this.label54.TabIndex = 37;
            this.label54.Text = "COFINS";
            // 
            // tb_iss_item
            // 
            this.tb_iss_item.Location = new System.Drawing.Point(327, 13);
            this.tb_iss_item.Name = "tb_iss_item";
            this.tb_iss_item.Size = new System.Drawing.Size(42, 20);
            this.tb_iss_item.TabIndex = 280;
            this.tb_iss_item.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_cofins_item
            // 
            this.tb_cofins_item.Location = new System.Drawing.Point(288, 13);
            this.tb_cofins_item.Name = "tb_cofins_item";
            this.tb_cofins_item.Size = new System.Drawing.Size(42, 20);
            this.tb_cofins_item.TabIndex = 36;
            this.tb_cofins_item.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label55.Location = new System.Drawing.Point(256, 1);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(20, 12);
            this.label55.TabIndex = 35;
            this.label55.Text = "PIS";
            // 
            // tb_pis_item
            // 
            this.tb_pis_item.Location = new System.Drawing.Point(247, 13);
            this.tb_pis_item.Name = "tb_pis_item";
            this.tb_pis_item.Size = new System.Drawing.Size(42, 20);
            this.tb_pis_item.TabIndex = 34;
            this.tb_pis_item.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label56.Location = new System.Drawing.Point(215, 1);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(17, 12);
            this.label56.TabIndex = 33;
            this.label56.Text = "IPI";
            // 
            // tb_ipi_item
            // 
            this.tb_ipi_item.Location = new System.Drawing.Point(206, 13);
            this.tb_ipi_item.Name = "tb_ipi_item";
            this.tb_ipi_item.Size = new System.Drawing.Size(42, 20);
            this.tb_ipi_item.TabIndex = 32;
            this.tb_ipi_item.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label57.Location = new System.Drawing.Point(174, 1);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(22, 12);
            this.label57.TabIndex = 31;
            this.label57.Text = "IVA";
            // 
            // tb_iva_item
            // 
            this.tb_iva_item.Location = new System.Drawing.Point(165, 13);
            this.tb_iva_item.Name = "tb_iva_item";
            this.tb_iva_item.Size = new System.Drawing.Size(42, 20);
            this.tb_iva_item.TabIndex = 30;
            this.tb_iva_item.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label58.Location = new System.Drawing.Point(86, 1);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(42, 12);
            this.label58.TabIndex = 29;
            this.label58.Text = "Redução";
            // 
            // tb_reducao_item
            // 
            this.tb_reducao_item.Location = new System.Drawing.Point(86, 13);
            this.tb_reducao_item.Name = "tb_reducao_item";
            this.tb_reducao_item.Size = new System.Drawing.Size(42, 20);
            this.tb_reducao_item.TabIndex = 28;
            this.tb_reducao_item.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label59.Location = new System.Drawing.Point(45, 1);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(43, 12);
            this.label59.TabIndex = 27;
            this.label59.Text = "ICMS ST";
            // 
            // tb_icms_st
            // 
            this.tb_icms_st.Location = new System.Drawing.Point(45, 13);
            this.tb_icms_st.Name = "tb_icms_st";
            this.tb_icms_st.Size = new System.Drawing.Size(42, 20);
            this.tb_icms_st.TabIndex = 26;
            this.tb_icms_st.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label60.Location = new System.Drawing.Point(8, 1);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(30, 12);
            this.label60.TabIndex = 25;
            this.label60.Text = "ICMS";
            // 
            // tb_icms_item
            // 
            this.tb_icms_item.Location = new System.Drawing.Point(4, 13);
            this.tb_icms_item.Name = "tb_icms_item";
            this.tb_icms_item.Size = new System.Drawing.Size(42, 20);
            this.tb_icms_item.TabIndex = 24;
            this.tb_icms_item.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel5.Controls.Add(this.label75);
            this.panel5.Controls.Add(this.label37);
            this.panel5.Controls.Add(this.tb_frete);
            this.panel5.Controls.Add(this.tb_transportadora);
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.textBox23);
            this.panel5.Controls.Add(this.label31);
            this.panel5.Controls.Add(this.label21);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Location = new System.Drawing.Point(7, 447);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(433, 58);
            this.panel5.TabIndex = 276;
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label75.Location = new System.Drawing.Point(199, 31);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(49, 18);
            this.label75.TabIndex = 220;
            this.label75.Text = "2 - Terceiros\r\n9 - Sem frete";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.label87);
            this.panel6.Controls.Add(this.tb_vtrib);
            this.panel6.Controls.Add(this.tb_valor_total_iss);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.tb_base_calc_iss);
            this.panel6.Controls.Add(this.tb_aliquota_simples);
            this.panel6.Controls.Add(this.label78);
            this.panel6.Controls.Add(this.tb_valor_simples);
            this.panel6.Controls.Add(this.label77);
            this.panel6.Controls.Add(this.tb_desconto);
            this.panel6.Controls.Add(this.label_desconto);
            this.panel6.Controls.Add(this.button6);
            this.panel6.Controls.Add(this.tb_total_nota);
            this.panel6.Controls.Add(this.label20);
            this.panel6.Controls.Add(this.tb_valor_ipi);
            this.panel6.Controls.Add(this.label16);
            this.panel6.Controls.Add(this.tb_outras_des_ace);
            this.panel6.Controls.Add(this.label17);
            this.panel6.Controls.Add(this.tb_valor_seg);
            this.panel6.Controls.Add(this.label18);
            this.panel6.Controls.Add(this.tb_valor_fre);
            this.panel6.Controls.Add(this.label19);
            this.panel6.Controls.Add(this.tb_total_prod);
            this.panel6.Controls.Add(this.label15);
            this.panel6.Controls.Add(this.tb_valor_icm_st);
            this.panel6.Controls.Add(this.label14);
            this.panel6.Controls.Add(this.tb_base_cal_icm_st);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.tb_valor_icm);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.tb_base_calc_icm);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Location = new System.Drawing.Point(7, 339);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(708, 105);
            this.panel6.TabIndex = 277;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 285;
            this.label5.Text = "B. Cálc. ISS";
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label87.Location = new System.Drawing.Point(132, 70);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(79, 13);
            this.label87.TabIndex = 284;
            this.label87.Text = "Tot. Aprox. Trib.";
            // 
            // tb_vtrib
            // 
            this.tb_vtrib.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsNota_fiscal, "NOTA_FISCAL.TOTAL_TRIB_NF", true));
            this.tb_vtrib.Location = new System.Drawing.Point(125, 83);
            this.tb_vtrib.Name = "tb_vtrib";
            this.tb_vtrib.Size = new System.Drawing.Size(92, 20);
            this.tb_vtrib.TabIndex = 283;
            // 
            // tb_valor_total_iss
            // 
            this.tb_valor_total_iss.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsNota_fiscal, "NOTA_FISCAL.VALOR_TOTAL_SERVICOS_NF", true));
            this.tb_valor_total_iss.Location = new System.Drawing.Point(70, 83);
            this.tb_valor_total_iss.Name = "tb_valor_total_iss";
            this.tb_valor_total_iss.Size = new System.Drawing.Size(49, 20);
            this.tb_valor_total_iss.TabIndex = 282;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 281;
            this.label4.Text = "V. Total ISS";
            // 
            // tb_base_calc_iss
            // 
            this.tb_base_calc_iss.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsNota_fiscal, "NOTA_FISCAL.BASE_CALCULO_ISS_NF", true));
            this.tb_base_calc_iss.Location = new System.Drawing.Point(19, 83);
            this.tb_base_calc_iss.Name = "tb_base_calc_iss";
            this.tb_base_calc_iss.Size = new System.Drawing.Size(49, 20);
            this.tb_base_calc_iss.TabIndex = 280;
            // 
            // tb_aliquota_simples
            // 
            this.tb_aliquota_simples.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsNota_fiscal, "NOTA_FISCAL.ALIQUOTA_SIMPLES_NF", true));
            this.tb_aliquota_simples.Location = new System.Drawing.Point(377, 83);
            this.tb_aliquota_simples.Name = "tb_aliquota_simples";
            this.tb_aliquota_simples.Size = new System.Drawing.Size(49, 20);
            this.tb_aliquota_simples.TabIndex = 275;
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label78.Location = new System.Drawing.Point(373, 71);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(45, 13);
            this.label78.TabIndex = 274;
            this.label78.Text = "P. Cred.";
            // 
            // tb_valor_simples
            // 
            this.tb_valor_simples.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsNota_fiscal, "NOTA_FISCAL.VALOR_SIMPLES_NF", true));
            this.tb_valor_simples.Location = new System.Drawing.Point(327, 83);
            this.tb_valor_simples.Name = "tb_valor_simples";
            this.tb_valor_simples.Size = new System.Drawing.Size(49, 20);
            this.tb_valor_simples.TabIndex = 273;
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label77.Location = new System.Drawing.Point(323, 71);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(45, 13);
            this.label77.TabIndex = 272;
            this.label77.Text = "V. Cred.";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel7.Controls.Add(this.tb_peso_liquido);
            this.panel7.Controls.Add(this.label27);
            this.panel7.Controls.Add(this.tb_peso_bruto);
            this.panel7.Controls.Add(this.label26);
            this.panel7.Controls.Add(this.tb_marca);
            this.panel7.Controls.Add(this.label23);
            this.panel7.Controls.Add(this.tb_especie);
            this.panel7.Controls.Add(this.label24);
            this.panel7.Controls.Add(this.tb_qtde_volume);
            this.panel7.Controls.Add(this.label25);
            this.panel7.Location = new System.Drawing.Point(446, 447);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(269, 58);
            this.panel7.TabIndex = 278;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel8.Controls.Add(this.button21);
            this.panel8.Controls.Add(this.button17);
            this.panel8.Controls.Add(this.button9);
            this.panel8.Controls.Add(this.dgvFatura_nf);
            this.panel8.Controls.Add(this.cb_forma_pgto);
            this.panel8.Controls.Add(this.label35);
            this.panel8.Location = new System.Drawing.Point(721, 339);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(310, 166);
            this.panel8.TabIndex = 279;
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(284, 53);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(23, 23);
            this.button21.TabIndex = 222;
            this.button21.Text = "C";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(284, 30);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(23, 23);
            this.button17.TabIndex = 221;
            this.button17.Text = "D";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click_2);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(249, 2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(23, 23);
            this.button9.TabIndex = 220;
            this.button9.Text = "+";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // dgvFatura_nf
            // 
            this.dgvFatura_nf.AllowUserToAddRows = false;
            this.dgvFatura_nf.AllowUserToDeleteRows = false;
            this.dgvFatura_nf.AutoGenerateColumns = false;
            this.dgvFatura_nf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFatura_nf.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODFATURADataGridViewTextBoxColumn,
            this.col_prazo,
            this.col_data,
            this.col_valor,
            this.col_cr_fatura,
            this.nFFATURADataGridViewTextBoxColumn});
            this.dgvFatura_nf.DataMember = "FATURA_NF";
            this.dgvFatura_nf.DataSource = this.dsFatura_nf;
            this.dgvFatura_nf.Location = new System.Drawing.Point(16, 30);
            this.dgvFatura_nf.Name = "dgvFatura_nf";
            this.dgvFatura_nf.RowHeadersWidth = 11;
            this.dgvFatura_nf.Size = new System.Drawing.Size(265, 123);
            this.dgvFatura_nf.TabIndex = 208;
            // 
            // cODFATURADataGridViewTextBoxColumn
            // 
            this.cODFATURADataGridViewTextBoxColumn.DataPropertyName = "COD_FATURA";
            this.cODFATURADataGridViewTextBoxColumn.HeaderText = "COD_FATURA";
            this.cODFATURADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cODFATURADataGridViewTextBoxColumn.Name = "cODFATURADataGridViewTextBoxColumn";
            this.cODFATURADataGridViewTextBoxColumn.Visible = false;
            this.cODFATURADataGridViewTextBoxColumn.Width = 125;
            // 
            // col_prazo
            // 
            this.col_prazo.DataPropertyName = "PRAZO_FATURA";
            this.col_prazo.HeaderText = "Prazo";
            this.col_prazo.MinimumWidth = 6;
            this.col_prazo.Name = "col_prazo";
            this.col_prazo.Width = 50;
            // 
            // col_data
            // 
            this.col_data.DataPropertyName = "DATA_VENC_FATURA";
            this.col_data.HeaderText = "Data Vencimento";
            this.col_data.MinimumWidth = 6;
            this.col_data.Name = "col_data";
            this.col_data.Width = 70;
            // 
            // col_valor
            // 
            this.col_valor.DataPropertyName = "VALOR_FATURA";
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.col_valor.DefaultCellStyle = dataGridViewCellStyle1;
            this.col_valor.HeaderText = "Valor";
            this.col_valor.MinimumWidth = 6;
            this.col_valor.Name = "col_valor";
            this.col_valor.Width = 125;
            // 
            // col_cr_fatura
            // 
            this.col_cr_fatura.DataPropertyName = "CR_FATURA";
            this.col_cr_fatura.HeaderText = "CR";
            this.col_cr_fatura.MinimumWidth = 6;
            this.col_cr_fatura.Name = "col_cr_fatura";
            this.col_cr_fatura.Width = 125;
            // 
            // nFFATURADataGridViewTextBoxColumn
            // 
            this.nFFATURADataGridViewTextBoxColumn.DataPropertyName = "NF_FATURA";
            this.nFFATURADataGridViewTextBoxColumn.HeaderText = "NF_FATURA";
            this.nFFATURADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nFFATURADataGridViewTextBoxColumn.Name = "nFFATURADataGridViewTextBoxColumn";
            this.nFFATURADataGridViewTextBoxColumn.Visible = false;
            this.nFFATURADataGridViewTextBoxColumn.Width = 125;
            // 
            // dsFatura_nf
            // 
            this.dsFatura_nf.DataSetName = "dsFatura_nf";
            this.dsFatura_nf.Namespace = "http://www.tempuri.org/dsFatura_nf.xsd";
            this.dsFatura_nf.Tables.AddRange(new System.Data.DataTable[] {
            this.FATURA_NF});
            // 
            // FATURA_NF
            // 
            this.FATURA_NF.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_FATURA,
            this.PRAZO_FATURA,
            this.DATA_VENC_FATURA,
            this.VALOR_FATURA,
            this.NF_FATURA,
            this.dataColumn103});
            this.FATURA_NF.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_FATURA"}, true)});
            this.FATURA_NF.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_FATURA};
            this.FATURA_NF.TableName = "FATURA_NF";
            // 
            // COD_FATURA
            // 
            this.COD_FATURA.AllowDBNull = false;
            this.COD_FATURA.ColumnName = "COD_FATURA";
            this.COD_FATURA.DataType = typeof(int);
            // 
            // PRAZO_FATURA
            // 
            this.PRAZO_FATURA.ColumnName = "PRAZO_FATURA";
            this.PRAZO_FATURA.DataType = typeof(int);
            // 
            // DATA_VENC_FATURA
            // 
            this.DATA_VENC_FATURA.ColumnName = "DATA_VENC_FATURA";
            this.DATA_VENC_FATURA.DataType = typeof(System.DateTime);
            // 
            // VALOR_FATURA
            // 
            this.VALOR_FATURA.ColumnName = "VALOR_FATURA";
            this.VALOR_FATURA.DataType = typeof(double);
            // 
            // NF_FATURA
            // 
            this.NF_FATURA.ColumnName = "NF_FATURA";
            this.NF_FATURA.DataType = typeof(int);
            // 
            // dataColumn103
            // 
            this.dataColumn103.ColumnName = "CR_FATURA";
            this.dataColumn103.DataType = typeof(int);
            // 
            // fbCommand81
            // 
            this.fbCommand81.CommandText = "select * from pedidos_venda";
            this.fbCommand81.CommandTimeout = 30;
            this.fbCommand81.Connection = this.fbConnection1;
            // 
            // fbCommand82
            // 
            this.fbCommand82.CommandText = "select * from fatura_nf";
            this.fbCommand82.CommandTimeout = 30;
            this.fbCommand82.Connection = this.fbConnection1;
            // 
            // cbFatura_nf
            // 
            this.cbFatura_nf.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbFatura_nf.DataAdapter = this.datFatura_nf;
            this.cbFatura_nf.QuotePrefix = "\"";
            this.cbFatura_nf.QuoteSuffix = "\"";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(721, 7);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(51, 13);
            this.label62.TabIndex = 280;
            this.label62.Text = "Empresa:";
            // 
            // empresalabel
            // 
            this.empresalabel.AutoSize = true;
            this.empresalabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsEmpresa, "EMPRESA.RAZAO_SOCIAL_EMPRESA", true));
            this.empresalabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empresalabel.Location = new System.Drawing.Point(778, 7);
            this.empresalabel.Name = "empresalabel";
            this.empresalabel.Size = new System.Drawing.Size(55, 13);
            this.empresalabel.TabIndex = 281;
            this.empresalabel.Text = "Empresa";
            // 
            // cnpjlabel
            // 
            this.cnpjlabel.AutoSize = true;
            this.cnpjlabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsEmpresa, "EMPRESA.CNPJ_EMPRESA", true));
            this.cnpjlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnpjlabel.Location = new System.Drawing.Point(778, 22);
            this.cnpjlabel.Name = "cnpjlabel";
            this.cnpjlabel.Size = new System.Drawing.Size(38, 13);
            this.cnpjlabel.TabIndex = 283;
            this.cnpjlabel.Text = "CNPJ";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(721, 22);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(37, 13);
            this.label.TabIndex = 282;
            this.label.Text = "CNPJ:";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(901, 23);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(43, 13);
            this.label63.TabIndex = 284;
            this.label63.Text = "Estado:";
            // 
            // estadolabel
            // 
            this.estadolabel.AutoSize = true;
            this.estadolabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsEmpresa, "EMPRESA.ESTADO_EMPRESA", true));
            this.estadolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadolabel.Location = new System.Drawing.Point(946, 23);
            this.estadolabel.Name = "estadolabel";
            this.estadolabel.Size = new System.Drawing.Size(46, 13);
            this.estadolabel.TabIndex = 285;
            this.estadolabel.Text = "Estado";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(634, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(390, 72);
            this.tabControl1.TabIndex = 286;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(382, 46);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Valores Adicionais";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(382, 46);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Alíquotas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tb_cst_ipi_n_tributado);
            this.tabPage3.Controls.Add(this.tb_cst_ipi_tributado);
            this.tabPage3.Controls.Add(this.label66);
            this.tabPage3.Controls.Add(this.label67);
            this.tabPage3.Controls.Add(this.rb_ipi_nao_tributado);
            this.tabPage3.Controls.Add(this.rb_ipi_tributado);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(382, 46);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "IPI";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tb_cst_ipi_n_tributado
            // 
            this.tb_cst_ipi_n_tributado.Location = new System.Drawing.Point(120, 24);
            this.tb_cst_ipi_n_tributado.Name = "tb_cst_ipi_n_tributado";
            this.tb_cst_ipi_n_tributado.Size = new System.Drawing.Size(137, 20);
            this.tb_cst_ipi_n_tributado.TabIndex = 116;
            // 
            // tb_cst_ipi_tributado
            // 
            this.tb_cst_ipi_tributado.Location = new System.Drawing.Point(120, 3);
            this.tb_cst_ipi_tributado.Name = "tb_cst_ipi_tributado";
            this.tb_cst_ipi_tributado.Size = new System.Drawing.Size(137, 20);
            this.tb_cst_ipi_tributado.TabIndex = 115;
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(2, 27);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(109, 13);
            this.label66.TabIndex = 114;
            this.label66.Text = "CST do IPI Não Trib.:";
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(2, 6);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(86, 13);
            this.label67.TabIndex = 112;
            this.label67.Text = "CST do IPI Trib.:";
            // 
            // rb_ipi_nao_tributado
            // 
            this.rb_ipi_nao_tributado.AutoSize = true;
            this.rb_ipi_nao_tributado.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsEmpresa, "EMPRESA.IPI_N_TRIB_EMPRESA", true));
            this.rb_ipi_nao_tributado.Location = new System.Drawing.Point(267, 22);
            this.rb_ipi_nao_tributado.Name = "rb_ipi_nao_tributado";
            this.rb_ipi_nao_tributado.Size = new System.Drawing.Size(109, 17);
            this.rb_ipi_nao_tributado.TabIndex = 111;
            this.rb_ipi_nao_tributado.TabStop = true;
            this.rb_ipi_nao_tributado.Text = "IPI Não Tributado";
            this.rb_ipi_nao_tributado.UseVisualStyleBackColor = true;
            // 
            // rb_ipi_tributado
            // 
            this.rb_ipi_tributado.AutoSize = true;
            this.rb_ipi_tributado.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsEmpresa, "EMPRESA.IPI_TRIB_EMPRESA", true));
            this.rb_ipi_tributado.Location = new System.Drawing.Point(267, 4);
            this.rb_ipi_tributado.Name = "rb_ipi_tributado";
            this.rb_ipi_tributado.Size = new System.Drawing.Size(86, 17);
            this.rb_ipi_tributado.TabIndex = 110;
            this.rb_ipi_tributado.TabStop = true;
            this.rb_ipi_tributado.Text = "IPI Tributado";
            this.rb_ipi_tributado.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.tb_tipo_cofins);
            this.tabPage5.Controls.Add(this.label70);
            this.tabPage5.Controls.Add(this.tb_cst_cofins);
            this.tabPage5.Controls.Add(this.label71);
            this.tabPage5.Controls.Add(this.tb_tipo_pis);
            this.tabPage5.Controls.Add(this.label69);
            this.tabPage5.Controls.Add(this.tb_cst_pis);
            this.tabPage5.Controls.Add(this.label68);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(382, 46);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "PIS/COFINS";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tb_tipo_cofins
            // 
            this.tb_tipo_cofins.Location = new System.Drawing.Point(260, 2);
            this.tb_tipo_cofins.Name = "tb_tipo_cofins";
            this.tb_tipo_cofins.Size = new System.Drawing.Size(116, 20);
            this.tb_tipo_cofins.TabIndex = 123;
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(188, 5);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(73, 13);
            this.label70.TabIndex = 122;
            this.label70.Text = "Tipo COFINS:";
            // 
            // tb_cst_cofins
            // 
            this.tb_cst_cofins.Location = new System.Drawing.Point(260, 23);
            this.tb_cst_cofins.Name = "tb_cst_cofins";
            this.tb_cst_cofins.Size = new System.Drawing.Size(116, 20);
            this.tb_cst_cofins.TabIndex = 121;
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(188, 26);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(73, 13);
            this.label71.TabIndex = 120;
            this.label71.Text = "CST COFINS:";
            // 
            // tb_tipo_pis
            // 
            this.tb_tipo_pis.Location = new System.Drawing.Point(57, 2);
            this.tb_tipo_pis.Name = "tb_tipo_pis";
            this.tb_tipo_pis.Size = new System.Drawing.Size(116, 20);
            this.tb_tipo_pis.TabIndex = 119;
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(8, 6);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(51, 13);
            this.label69.TabIndex = 118;
            this.label69.Text = "Tipo PIS:";
            // 
            // tb_cst_pis
            // 
            this.tb_cst_pis.Location = new System.Drawing.Point(57, 23);
            this.tb_cst_pis.Name = "tb_cst_pis";
            this.tb_cst_pis.Size = new System.Drawing.Size(116, 20);
            this.tb_cst_pis.TabIndex = 117;
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(8, 27);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(51, 13);
            this.label68.TabIndex = 116;
            this.label68.Text = "CST PIS:";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.tb_tipo_servico);
            this.tabPage6.Controls.Add(this.label72);
            this.tabPage6.Controls.Add(this.cb_prestacao_servico);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(382, 46);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "ISS";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tb_tipo_servico
            // 
            this.tb_tipo_servico.Location = new System.Drawing.Point(173, 11);
            this.tb_tipo_servico.Name = "tb_tipo_servico";
            this.tb_tipo_servico.Size = new System.Drawing.Size(195, 20);
            this.tb_tipo_servico.TabIndex = 125;
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Location = new System.Drawing.Point(97, 16);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(70, 13);
            this.label72.TabIndex = 124;
            this.label72.Text = "Tipo Serviço:";
            // 
            // cb_prestacao_servico
            // 
            this.cb_prestacao_servico.AutoSize = true;
            this.cb_prestacao_servico.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_prestacao_servico.Location = new System.Drawing.Point(6, 8);
            this.cb_prestacao_servico.Name = "cb_prestacao_servico";
            this.cb_prestacao_servico.Size = new System.Drawing.Size(80, 28);
            this.cb_prestacao_servico.TabIndex = 39;
            this.cb_prestacao_servico.Text = "Prestação de \r\nServiços";
            this.cb_prestacao_servico.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label76);
            this.tabPage4.Controls.Add(this.tb_aliquota_credito);
            this.tabPage4.Controls.Add(this.cbBC_com_ipi);
            this.tabPage4.Controls.Add(this.cbNaoTributada);
            this.tabPage4.Controls.Add(this.cbTributada);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(382, 46);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Outros";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Location = new System.Drawing.Point(283, 9);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(61, 26);
            this.label76.TabIndex = 4;
            this.label76.Text = "Alíquota\r\nCred. ICMS";
            // 
            // tb_aliquota_credito
            // 
            this.tb_aliquota_credito.Location = new System.Drawing.Point(347, 13);
            this.tb_aliquota_credito.Name = "tb_aliquota_credito";
            this.tb_aliquota_credito.Size = new System.Drawing.Size(29, 20);
            this.tb_aliquota_credito.TabIndex = 3;
            // 
            // cbBC_com_ipi
            // 
            this.cbBC_com_ipi.AutoSize = true;
            this.cbBC_com_ipi.Location = new System.Drawing.Point(202, 16);
            this.cbBC_com_ipi.Name = "cbBC_com_ipi";
            this.cbBC_com_ipi.Size = new System.Drawing.Size(79, 17);
            this.cbBC_com_ipi.TabIndex = 2;
            this.cbBC_com_ipi.Text = "BC com IPI";
            this.cbBC_com_ipi.UseVisualStyleBackColor = true;
            // 
            // cbNaoTributada
            // 
            this.cbNaoTributada.AutoSize = true;
            this.cbNaoTributada.Location = new System.Drawing.Point(106, 2);
            this.cbNaoTributada.Name = "cbNaoTributada";
            this.cbNaoTributada.Size = new System.Drawing.Size(99, 43);
            this.cbNaoTributada.TabIndex = 1;
            this.cbNaoTributada.TabStop = true;
            this.cbNaoTributada.Text = "Não Tributada?\r\nIsenta?\r\nSuspensa?";
            this.cbNaoTributada.UseVisualStyleBackColor = true;
            // 
            // cbTributada
            // 
            this.cbTributada.AutoSize = true;
            this.cbTributada.Location = new System.Drawing.Point(19, 15);
            this.cbTributada.Name = "cbTributada";
            this.cbTributada.Size = new System.Drawing.Size(76, 17);
            this.cbTributada.TabIndex = 0;
            this.cbTributada.TabStop = true;
            this.cbTributada.Text = "Tributada?";
            this.cbTributada.UseVisualStyleBackColor = true;
            // 
            // itemPanel
            // 
            this.itemPanel.Controls.Add(this.tabControl1);
            this.itemPanel.Controls.Add(this.panel2);
            this.itemPanel.Location = new System.Drawing.Point(6, 136);
            this.itemPanel.Name = "itemPanel";
            this.itemPanel.Size = new System.Drawing.Size(1025, 80);
            this.itemPanel.TabIndex = 287;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button27);
            this.groupBox1.Controls.Add(this.button26);
            this.groupBox1.Controls.Add(this.cbReferenciar);
            this.groupBox1.Controls.Add(this.tb_Nfe_refer);
            this.groupBox1.Controls.Add(this.label_nfe);
            this.groupBox1.Controls.Add(this.rb_5910);
            this.groupBox1.Location = new System.Drawing.Point(885, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(146, 96);
            this.groupBox1.TabIndex = 288;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "NF Referenciada";
            // 
            // button27
            // 
            this.button27.Location = new System.Drawing.Point(5, 68);
            this.button27.Margin = new System.Windows.Forms.Padding(2);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(128, 19);
            this.button27.TabIndex = 221;
            this.button27.Text = "Visualizar Nfs Referenciadas";
            this.button27.UseVisualStyleBackColor = true;
            this.button27.Click += new System.EventHandler(this.button27_Click);
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(5, 42);
            this.button26.Margin = new System.Windows.Forms.Padding(2);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(128, 19);
            this.button26.TabIndex = 220;
            this.button26.Text = "Referenciar Retorno";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.button26_Click);
            // 
            // cbReferenciar
            // 
            this.cbReferenciar.AutoSize = true;
            this.cbReferenciar.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsNota_fiscal, "NOTA_FISCAL.REFERENCIADA_NF", true));
            this.cbReferenciar.Location = new System.Drawing.Point(19, 23);
            this.cbReferenciar.Name = "cbReferenciar";
            this.cbReferenciar.Size = new System.Drawing.Size(87, 17);
            this.cbReferenciar.TabIndex = 219;
            this.cbReferenciar.Text = "Referenciar?";
            this.cbReferenciar.UseVisualStyleBackColor = true;
            // 
            // tb_Nfe_refer
            // 
            this.tb_Nfe_refer.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsNota_fiscal, "NOTA_FISCAL.N_NF_REFERENCIADA_NF", true));
            this.tb_Nfe_refer.Location = new System.Drawing.Point(6, 70);
            this.tb_Nfe_refer.Multiline = true;
            this.tb_Nfe_refer.Name = "tb_Nfe_refer";
            this.tb_Nfe_refer.Size = new System.Drawing.Size(109, 22);
            this.tb_Nfe_refer.TabIndex = 218;
            this.tb_Nfe_refer.Visible = false;
            // 
            // label_nfe
            // 
            this.label_nfe.AutoSize = true;
            this.label_nfe.Location = new System.Drawing.Point(11, 54);
            this.label_nfe.Name = "label_nfe";
            this.label_nfe.Size = new System.Drawing.Size(107, 13);
            this.label_nfe.TabIndex = 217;
            this.label_nfe.Text = "NFes Referenciadas:";
            this.label_nfe.Visible = false;
            // 
            // rb_5910
            // 
            this.rb_5910.AutoSize = true;
            this.rb_5910.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_5910.Location = new System.Drawing.Point(97, 10);
            this.rb_5910.Name = "rb_5910";
            this.rb_5910.Size = new System.Drawing.Size(49, 17);
            this.rb_5910.TabIndex = 292;
            this.rb_5910.TabStop = true;
            this.rb_5910.Text = "5910";
            this.rb_5910.UseVisualStyleBackColor = true;
            this.rb_5910.Visible = false;
            // 
            // fbCommand94
            // 
            this.fbCommand94.CommandTimeout = 30;
            // 
            // fbCommand92
            // 
            this.fbCommand92.CommandTimeout = 30;
            // 
            // fbCommand91
            // 
            this.fbCommand91.CommandText = "select * from pedidos_nf";
            this.fbCommand91.CommandTimeout = 30;
            this.fbCommand91.Connection = this.fbConnection1;
            // 
            // fbCommand93
            // 
            this.fbCommand93.CommandTimeout = 30;
            // 
            // datPedidos_venda
            // 
            this.datPedidos_venda.InsertCommand = this.fbCommand82;
            this.datPedidos_venda.SelectCommand = this.fbCommand81;
            // 
            // datItens_pedido_venda
            // 
            this.datItens_pedido_venda.DeleteCommand = this.fbCommand80;
            this.datItens_pedido_venda.InsertCommand = this.fbCommand78;
            this.datItens_pedido_venda.SelectCommand = this.fbCommand77;
            this.datItens_pedido_venda.UpdateCommand = this.fbCommand79;
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AllowUserToAddRows = false;
            this.dgvPedidos.AutoGenerateColumns = false;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODPEDIDONFDataGridViewTextBoxColumn,
            this.nFPEDIDONFDataGridViewTextBoxColumn,
            this.col_pedido,
            this.COD_SISTEMA_PEDIDO_NF});
            this.dgvPedidos.DataMember = "PEDIDOS_NF";
            this.dgvPedidos.DataSource = this.dsPedidos_nf;
            this.dgvPedidos.Location = new System.Drawing.Point(913, 214);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.RowHeadersWidth = 15;
            this.dgvPedidos.Size = new System.Drawing.Size(119, 119);
            this.dgvPedidos.TabIndex = 289;
            this.dgvPedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedidos_CellContentClick);
            // 
            // cODPEDIDONFDataGridViewTextBoxColumn
            // 
            this.cODPEDIDONFDataGridViewTextBoxColumn.DataPropertyName = "COD_PEDIDO_NF";
            this.cODPEDIDONFDataGridViewTextBoxColumn.HeaderText = "COD_PEDIDO_NF";
            this.cODPEDIDONFDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cODPEDIDONFDataGridViewTextBoxColumn.Name = "cODPEDIDONFDataGridViewTextBoxColumn";
            this.cODPEDIDONFDataGridViewTextBoxColumn.Visible = false;
            this.cODPEDIDONFDataGridViewTextBoxColumn.Width = 125;
            // 
            // nFPEDIDONFDataGridViewTextBoxColumn
            // 
            this.nFPEDIDONFDataGridViewTextBoxColumn.DataPropertyName = "NF_PEDIDO_NF";
            this.nFPEDIDONFDataGridViewTextBoxColumn.HeaderText = "NF_PEDIDO_NF";
            this.nFPEDIDONFDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nFPEDIDONFDataGridViewTextBoxColumn.Name = "nFPEDIDONFDataGridViewTextBoxColumn";
            this.nFPEDIDONFDataGridViewTextBoxColumn.Visible = false;
            this.nFPEDIDONFDataGridViewTextBoxColumn.Width = 125;
            // 
            // col_pedido
            // 
            this.col_pedido.DataPropertyName = "N_PEDIDO_NF";
            this.col_pedido.HeaderText = "Cod. Interno Pedido";
            this.col_pedido.MinimumWidth = 6;
            this.col_pedido.Name = "col_pedido";
            this.col_pedido.Width = 125;
            // 
            // COD_SISTEMA_PEDIDO_NF
            // 
            this.COD_SISTEMA_PEDIDO_NF.DataPropertyName = "COD_SISTEMA_PEDIDO_NF";
            this.COD_SISTEMA_PEDIDO_NF.HeaderText = "Cod Sistema Pedido";
            this.COD_SISTEMA_PEDIDO_NF.MinimumWidth = 6;
            this.COD_SISTEMA_PEDIDO_NF.Name = "COD_SISTEMA_PEDIDO_NF";
            this.COD_SISTEMA_PEDIDO_NF.Width = 60;
            // 
            // dsPedidos_nf
            // 
            this.dsPedidos_nf.DataSetName = "dsPedidos_nf";
            this.dsPedidos_nf.Namespace = "http://www.tempuri.org/dsPedidos_nf.xsd";
            this.dsPedidos_nf.Tables.AddRange(new System.Data.DataTable[] {
            this.PEDIDOS_NF});
            // 
            // PEDIDOS_NF
            // 
            this.PEDIDOS_NF.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_PEDIDO_NF,
            this.NF_PEDIDO_NF,
            this.N_PEDIDO_NF,
            this.dataColumn107});
            this.PEDIDOS_NF.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_PEDIDO_NF"}, true)});
            this.PEDIDOS_NF.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_PEDIDO_NF};
            this.PEDIDOS_NF.TableName = "PEDIDOS_NF";
            // 
            // COD_PEDIDO_NF
            // 
            this.COD_PEDIDO_NF.AllowDBNull = false;
            this.COD_PEDIDO_NF.ColumnName = "COD_PEDIDO_NF";
            this.COD_PEDIDO_NF.DataType = typeof(int);
            // 
            // NF_PEDIDO_NF
            // 
            this.NF_PEDIDO_NF.ColumnName = "NF_PEDIDO_NF";
            this.NF_PEDIDO_NF.DataType = typeof(int);
            // 
            // N_PEDIDO_NF
            // 
            this.N_PEDIDO_NF.ColumnName = "N_PEDIDO_NF";
            this.N_PEDIDO_NF.DataType = typeof(int);
            // 
            // dataColumn107
            // 
            this.dataColumn107.ColumnName = "COD_SISTEMA_PEDIDO_NF";
            this.dataColumn107.DataType = typeof(int);
            // 
            // fbCommand83
            // 
            this.fbCommand83.CommandText = "select * from pedidos_nf";
            this.fbCommand83.CommandTimeout = 30;
            this.fbCommand83.Connection = this.fbConnection1;
            // 
            // fbCommand84
            // 
            this.fbCommand84.CommandTimeout = 30;
            // 
            // fbCommand85
            // 
            this.fbCommand85.CommandTimeout = 30;
            // 
            // fbCommand86
            // 
            this.fbCommand86.CommandTimeout = 30;
            // 
            // fbCommand87
            // 
            this.fbCommand87.CommandTimeout = 30;
            // 
            // fbCommand88
            // 
            this.fbCommand88.CommandTimeout = 30;
            // 
            // fbCommand89
            // 
            this.fbCommand89.CommandTimeout = 30;
            // 
            // fbCommand90
            // 
            this.fbCommand90.CommandTimeout = 30;
            // 
            // rb_1410
            // 
            this.rb_1410.AutoSize = true;
            this.rb_1410.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_1410.Location = new System.Drawing.Point(717, 103);
            this.rb_1410.Name = "rb_1410";
            this.rb_1410.Size = new System.Drawing.Size(49, 17);
            this.rb_1410.TabIndex = 290;
            this.rb_1410.TabStop = true;
            this.rb_1410.Text = "1410";
            this.rb_1410.UseVisualStyleBackColor = true;
            // 
            // rb_5904
            // 
            this.rb_5904.AutoSize = true;
            this.rb_5904.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_5904.Location = new System.Drawing.Point(717, 118);
            this.rb_5904.Name = "rb_5904";
            this.rb_5904.Size = new System.Drawing.Size(49, 17);
            this.rb_5904.TabIndex = 291;
            this.rb_5904.TabStop = true;
            this.rb_5904.Text = "5904";
            this.rb_5904.UseVisualStyleBackColor = true;
            // 
            // rb_5202
            // 
            this.rb_5202.AutoSize = true;
            this.rb_5202.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_5202.Location = new System.Drawing.Point(775, 118);
            this.rb_5202.Name = "rb_5202";
            this.rb_5202.Size = new System.Drawing.Size(49, 17);
            this.rb_5202.TabIndex = 293;
            this.rb_5202.TabStop = true;
            this.rb_5202.Text = "5202";
            this.rb_5202.UseVisualStyleBackColor = true;
            // 
            // datPedidos_nf
            // 
            this.datPedidos_nf.DeleteCommand = this.fbCommand98;
            this.datPedidos_nf.InsertCommand = this.fbCommand96;
            this.datPedidos_nf.SelectCommand = this.fbCommand95;
            this.datPedidos_nf.UpdateCommand = this.fbCommand97;
            // 
            // fbCommand98
            // 
            this.fbCommand98.CommandTimeout = 30;
            // 
            // fbCommand96
            // 
            this.fbCommand96.CommandTimeout = 30;
            // 
            // fbCommand95
            // 
            this.fbCommand95.CommandText = "select * from pedidos_nf";
            this.fbCommand95.CommandTimeout = 30;
            this.fbCommand95.Connection = this.fbConnection1;
            // 
            // fbCommand97
            // 
            this.fbCommand97.CommandTimeout = 30;
            // 
            // cbPedidos_nf
            // 
            this.cbPedidos_nf.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbPedidos_nf.DataAdapter = this.datPedidos_nf;
            this.cbPedidos_nf.QuotePrefix = "\"";
            this.cbPedidos_nf.QuoteSuffix = "\"";
            // 
            // rb_5949
            // 
            this.rb_5949.AutoSize = true;
            this.rb_5949.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_5949.Location = new System.Drawing.Point(830, 103);
            this.rb_5949.Name = "rb_5949";
            this.rb_5949.Size = new System.Drawing.Size(49, 17);
            this.rb_5949.TabIndex = 294;
            this.rb_5949.TabStop = true;
            this.rb_5949.Text = "5949";
            this.rb_5949.UseVisualStyleBackColor = true;
            this.rb_5949.CheckedChanged += new System.EventHandler(this.rb_5949_CheckedChanged);
            // 
            // rb_5917
            // 
            this.rb_5917.AutoSize = true;
            this.rb_5917.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_5917.Location = new System.Drawing.Point(830, 118);
            this.rb_5917.Name = "rb_5917";
            this.rb_5917.Size = new System.Drawing.Size(49, 17);
            this.rb_5917.TabIndex = 295;
            this.rb_5917.TabStop = true;
            this.rb_5917.Text = "5917";
            this.rb_5917.UseVisualStyleBackColor = true;
            this.rb_5917.Visible = false;
            // 
            // tb_razao_empresa
            // 
            this.tb_razao_empresa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsNota_fiscal, "NOTA_FISCAL.RAZAO_EMISSOR_NF", true));
            this.tb_razao_empresa.Location = new System.Drawing.Point(223, 647);
            this.tb_razao_empresa.Name = "tb_razao_empresa";
            this.tb_razao_empresa.ReadOnly = true;
            this.tb_razao_empresa.Size = new System.Drawing.Size(319, 20);
            this.tb_razao_empresa.TabIndex = 368;
            // 
            // tb_cnpj_empresa
            // 
            this.tb_cnpj_empresa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsNota_fiscal, "NOTA_FISCAL.CNPJ_EMISSOR_NF", true));
            this.tb_cnpj_empresa.Location = new System.Drawing.Point(58, 647);
            this.tb_cnpj_empresa.Name = "tb_cnpj_empresa";
            this.tb_cnpj_empresa.ReadOnly = true;
            this.tb_cnpj_empresa.Size = new System.Drawing.Size(166, 20);
            this.tb_cnpj_empresa.TabIndex = 367;
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Location = new System.Drawing.Point(10, 650);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(51, 13);
            this.label82.TabIndex = 369;
            this.label82.Text = "Empresa:";
            // 
            // statusStrip2
            // 
            this.statusStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cnpjtoolStripStatusLabel,
            this.empresatoolStripStatusLabel});
            this.statusStrip2.Location = new System.Drawing.Point(0, 680);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(1038, 22);
            this.statusStrip2.TabIndex = 370;
            this.statusStrip2.Text = "statusStrip2";
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
            // button22
            // 
            this.button22.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button22.Location = new System.Drawing.Point(969, 640);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(57, 37);
            this.button22.TabIndex = 371;
            this.button22.Text = "XML";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // rb5124
            // 
            this.rb5124.AutoSize = true;
            this.rb5124.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb5124.Location = new System.Drawing.Point(830, 118);
            this.rb5124.Name = "rb5124";
            this.rb5124.Size = new System.Drawing.Size(49, 17);
            this.rb5124.TabIndex = 372;
            this.rb5124.TabStop = true;
            this.rb5124.Text = "5124";
            this.rb5124.UseVisualStyleBackColor = true;
            // 
            // rb5101
            // 
            this.rb5101.AutoSize = true;
            this.rb5101.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb5101.Location = new System.Drawing.Point(717, 118);
            this.rb5101.Name = "rb5101";
            this.rb5101.Size = new System.Drawing.Size(49, 17);
            this.rb5101.TabIndex = 373;
            this.rb5101.TabStop = true;
            this.rb5101.Text = "5101";
            this.rb5101.UseVisualStyleBackColor = true;
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(913, 654);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(53, 23);
            this.button23.TabIndex = 374;
            this.button23.Text = "Teste";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // tb_informacoes_fisco
            // 
            this.tb_informacoes_fisco.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsNota_fiscal, "NOTA_FISCAL.INF_FISCO_NF", true));
            this.tb_informacoes_fisco.Location = new System.Drawing.Point(673, 648);
            this.tb_informacoes_fisco.Name = "tb_informacoes_fisco";
            this.tb_informacoes_fisco.Size = new System.Drawing.Size(228, 20);
            this.tb_informacoes_fisco.TabIndex = 373;
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.Location = new System.Drawing.Point(576, 651);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(96, 13);
            this.label85.TabIndex = 372;
            this.label85.Text = "Informações Fisco:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(775, 103);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(49, 17);
            this.radioButton1.TabIndex = 375;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "5949";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.label88);
            this.tabPage7.Controls.Add(this.tb_aliquota_cbs);
            this.tabPage7.Controls.Add(this.label89);
            this.tabPage7.Controls.Add(this.tb_aliquota_ibs);
            this.tabPage7.Controls.Add(this.label90);
            this.tabPage7.Controls.Add(this.tb_classificacao_ibscbs);
            this.tabPage7.Controls.Add(this.label91);
            this.tabPage7.Controls.Add(this.tb_cst_ibscbs);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(382, 46);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Reforma Trib";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label88.Location = new System.Drawing.Point(296, 17);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(37, 12);
            this.label88.TabIndex = 299;
            this.label88.Text = "% CBS:";
            // 
            // tb_aliquota_cbs
            // 
            this.tb_aliquota_cbs.Location = new System.Drawing.Point(333, 13);
            this.tb_aliquota_cbs.Name = "tb_aliquota_cbs";
            this.tb_aliquota_cbs.Size = new System.Drawing.Size(42, 20);
            this.tb_aliquota_cbs.TabIndex = 298;
            this.tb_aliquota_cbs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.label89.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label89.Location = new System.Drawing.Point(211, 17);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(33, 12);
            this.label89.TabIndex = 297;
            this.label89.Text = "% IBS:";
            // 
            // tb_aliquota_ibs
            // 
            this.tb_aliquota_ibs.Location = new System.Drawing.Point(244, 13);
            this.tb_aliquota_ibs.Name = "tb_aliquota_ibs";
            this.tb_aliquota_ibs.Size = new System.Drawing.Size(42, 20);
            this.tb_aliquota_ibs.TabIndex = 296;
            this.tb_aliquota_ibs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label90.Location = new System.Drawing.Point(91, 17);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(64, 12);
            this.label90.TabIndex = 295;
            this.label90.Text = "Classificação:";
            // 
            // tb_classificacao_ibscbs
            // 
            this.tb_classificacao_ibscbs.Location = new System.Drawing.Point(156, 13);
            this.tb_classificacao_ibscbs.Name = "tb_classificacao_ibscbs";
            this.tb_classificacao_ibscbs.Size = new System.Drawing.Size(50, 20);
            this.tb_classificacao_ibscbs.TabIndex = 294;
            this.tb_classificacao_ibscbs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label91
            // 
            this.label91.AutoSize = true;
            this.label91.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label91.Location = new System.Drawing.Point(7, 17);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(26, 12);
            this.label91.TabIndex = 293;
            this.label91.Text = "CST:";
            // 
            // tb_cst_ibscbs
            // 
            this.tb_cst_ibscbs.Location = new System.Drawing.Point(32, 13);
            this.tb_cst_ibscbs.Name = "tb_cst_ibscbs";
            this.tb_cst_ibscbs.Size = new System.Drawing.Size(56, 20);
            this.tb_cst_ibscbs.TabIndex = 292;
            this.tb_cst_ibscbs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataColumn123
            // 
            this.dataColumn123.ColumnName = "CST_IBSCBS_ITEM";
            // 
            // dataColumn124
            // 
            this.dataColumn124.ColumnName = "CCLASSTRIB_ITEM";
            // 
            // dataColumn125
            // 
            this.dataColumn125.ColumnName = "ALIQ_IBS_ITEM";
            this.dataColumn125.DataType = typeof(double);
            // 
            // dataColumn126
            // 
            this.dataColumn126.ColumnName = "ALIQ_CBS_ITEM";
            this.dataColumn126.DataType = typeof(double);
            // 
            // dataColumn127
            // 
            this.dataColumn127.ColumnName = "VALOR_IBS_ITEM";
            this.dataColumn127.DataType = typeof(double);
            // 
            // dataColumn128
            // 
            this.dataColumn128.ColumnName = "VALOR_CBS_ITEM";
            this.dataColumn128.DataType = typeof(double);
            // 
            // dataColumn129
            // 
            this.dataColumn129.ColumnName = "BC_IBSCBS_ITEM";
            this.dataColumn129.DataType = typeof(double);
            // 
            // dgvItens_nota
            // 
            this.dgvItens_nota.AllowUserToAddRows = false;
            this.dgvItens_nota.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItens_nota.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvItens_nota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens_nota.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_cod_op,
            this.col_descricao,
            this.col_unidade,
            this.col_qtde,
            this.col_preco_unit,
            this.col_preco_total,
            this.col_nf,
            this.col_ncm,
            this.col_cfo,
            this.col_valor_bc,
            this.col_icms,
            this.col_valor_icm,
            this.col_ipi,
            this.col_valor_ipi,
            this.col_iss,
            this.col_valor_iss,
            this.col_icms_st,
            this.col_valor_bc_st,
            this.col_valor_st,
            this.col_iva,
            this.col_reducao,
            this.col_frete,
            this.col_desconto,
            this.col_seguro,
            this.col_outras_desp,
            this.col_cofins,
            this.col_valor_cofins,
            this.col_pis,
            this.col_valor_pis,
            this.col_prestacao_servico,
            this.col_st,
            this.col_origem,
            this.col_mod_item,
            this.col_mod_bc_st,
            this.col_red_st,
            this.col_aliq_cred,
            this.col_valor_credito,
            this.Trib,
            this.col_tipo_servico,
            this.col_pedido_compra,
            this.col_item_pedido_compra,
            this.col_cod,
            this.col_ean,
            this.col_porc_trib,
            this.col_tot_trib,
            this.col_cest,
            this.PORC_IPI_DEV_ITEM,
            this.VALOR_IPI_DEV_ITEM,
            this.IPI_TRIB_ITEM,
            this.IPI_N_TRIB_ITEM,
            this.CST_IPI_TRIB_ITEM,
            this.CST_IPI_N_TRIB_ITEM,
            this.TIPO_PIS_ITEM,
            this.CST_PIS_ITEM,
            this.TIPO_COFINS_ITEM,
            this.CST_COFINS_ITEM,
            this.BC_IPI_ITEM,
            this.BC_PIS_ITEM,
            this.BC_COFINS_ITEM,
            this.N_NF_ENT_ITEM,
            this.DI_ITEM,
            this.DATA_DI_ITEM,
            this.LOCAL_DES_ITEM,
            this.UF_DES_ITEM,
            this.DATA_DES_ITEM,
            this.COD_EXP_ITEM,
            this.BC_II_ITEM,
            this.VALOR_II_ITEM,
            this.DESP_ADUANEIRAS_ITEM,
            this.IOF_II_ITEM,
            this.CST_IBSCBS_ITEM,
            this.CCLASSTRIB_ITEM,
            this.ALIQ_IBS_ITEM,
            this.ALIQ_CBS_ITEM,
            this.VALOR_IBS_ITEM,
            this.VALOR_CBS_ITEM,
            this.BC_IBSCBS_ITEM});
            this.dgvItens_nota.DataMember = "ITENS_NOTA";
            this.dgvItens_nota.DataSource = this.dsItens_nota;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItens_nota.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvItens_nota.Location = new System.Drawing.Point(6, 214);
            this.dgvItens_nota.Name = "dgvItens_nota";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItens_nota.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvItens_nota.RowHeadersWidth = 51;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvItens_nota.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvItens_nota.Size = new System.Drawing.Size(900, 119);
            this.dgvItens_nota.TabIndex = 376;
            // 
            // col_cod_op
            // 
            this.col_cod_op.DataPropertyName = "COD_ITEM";
            this.col_cod_op.Frozen = true;
            this.col_cod_op.HeaderText = "Cod";
            this.col_cod_op.MinimumWidth = 6;
            this.col_cod_op.Name = "col_cod_op";
            this.col_cod_op.Width = 90;
            // 
            // col_descricao
            // 
            this.col_descricao.DataPropertyName = "DESCRICAO_ITEM";
            this.col_descricao.Frozen = true;
            this.col_descricao.HeaderText = "Descrição";
            this.col_descricao.MinimumWidth = 6;
            this.col_descricao.Name = "col_descricao";
            this.col_descricao.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_descricao.Width = 200;
            // 
            // col_unidade
            // 
            this.col_unidade.DataPropertyName = "UNIDADE_ITEM";
            this.col_unidade.HeaderText = "Unidade";
            this.col_unidade.MinimumWidth = 6;
            this.col_unidade.Name = "col_unidade";
            this.col_unidade.Width = 30;
            // 
            // col_qtde
            // 
            this.col_qtde.DataPropertyName = "QTDE_ITEM";
            dataGridViewCellStyle3.Format = "N4";
            dataGridViewCellStyle3.NullValue = null;
            this.col_qtde.DefaultCellStyle = dataGridViewCellStyle3;
            this.col_qtde.HeaderText = "Qtde";
            this.col_qtde.MinimumWidth = 6;
            this.col_qtde.Name = "col_qtde";
            this.col_qtde.Width = 70;
            // 
            // col_preco_unit
            // 
            this.col_preco_unit.DataPropertyName = "PRECO_UNIT_ITEM";
            dataGridViewCellStyle4.Format = "N6";
            dataGridViewCellStyle4.NullValue = null;
            this.col_preco_unit.DefaultCellStyle = dataGridViewCellStyle4;
            this.col_preco_unit.HeaderText = "Preço Unit.";
            this.col_preco_unit.MinimumWidth = 6;
            this.col_preco_unit.Name = "col_preco_unit";
            this.col_preco_unit.Width = 62;
            // 
            // col_preco_total
            // 
            this.col_preco_total.DataPropertyName = "PRECO_TOTAL_ITEM";
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.col_preco_total.DefaultCellStyle = dataGridViewCellStyle5;
            this.col_preco_total.HeaderText = "Preço Total";
            this.col_preco_total.MinimumWidth = 6;
            this.col_preco_total.Name = "col_preco_total";
            this.col_preco_total.Width = 80;
            // 
            // col_nf
            // 
            this.col_nf.DataPropertyName = "NF_ITEM";
            this.col_nf.HeaderText = "NF_ITEM";
            this.col_nf.MinimumWidth = 6;
            this.col_nf.Name = "col_nf";
            this.col_nf.Visible = false;
            this.col_nf.Width = 125;
            // 
            // col_ncm
            // 
            this.col_ncm.DataPropertyName = "NCM_ITEM";
            this.col_ncm.HeaderText = "NCM";
            this.col_ncm.MinimumWidth = 6;
            this.col_ncm.Name = "col_ncm";
            this.col_ncm.Width = 70;
            // 
            // col_cfo
            // 
            this.col_cfo.DataPropertyName = "CFOP_ITEM";
            this.col_cfo.HeaderText = "CFOP";
            this.col_cfo.MinimumWidth = 6;
            this.col_cfo.Name = "col_cfo";
            this.col_cfo.Width = 60;
            // 
            // col_valor_bc
            // 
            this.col_valor_bc.DataPropertyName = "VALOR_BC_ITEM";
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.col_valor_bc.DefaultCellStyle = dataGridViewCellStyle6;
            this.col_valor_bc.HeaderText = "BC ICMS";
            this.col_valor_bc.Name = "col_valor_bc";
            this.col_valor_bc.Width = 70;
            // 
            // col_icms
            // 
            this.col_icms.DataPropertyName = "ICM_ITEM";
            this.col_icms.HeaderText = "ICMS";
            this.col_icms.MinimumWidth = 6;
            this.col_icms.Name = "col_icms";
            this.col_icms.Width = 40;
            // 
            // col_valor_icm
            // 
            this.col_valor_icm.DataPropertyName = "VALOR_ICM_ITEM";
            this.col_valor_icm.HeaderText = "Valor ICMS";
            this.col_valor_icm.MinimumWidth = 6;
            this.col_valor_icm.Name = "col_valor_icm";
            this.col_valor_icm.Width = 50;
            // 
            // col_ipi
            // 
            this.col_ipi.DataPropertyName = "IPI_ITEM";
            this.col_ipi.HeaderText = "IPI";
            this.col_ipi.MinimumWidth = 6;
            this.col_ipi.Name = "col_ipi";
            this.col_ipi.Width = 40;
            // 
            // col_valor_ipi
            // 
            this.col_valor_ipi.DataPropertyName = "VALOR_IPI_ITEM";
            this.col_valor_ipi.HeaderText = "V.IPI";
            this.col_valor_ipi.MinimumWidth = 6;
            this.col_valor_ipi.Name = "col_valor_ipi";
            this.col_valor_ipi.Width = 50;
            // 
            // col_iss
            // 
            this.col_iss.DataPropertyName = "ISS_ITEM";
            this.col_iss.HeaderText = "ISS";
            this.col_iss.MinimumWidth = 6;
            this.col_iss.Name = "col_iss";
            this.col_iss.Width = 40;
            // 
            // col_valor_iss
            // 
            this.col_valor_iss.DataPropertyName = "VALOR_ISS_ITEM";
            this.col_valor_iss.HeaderText = "V. ISS";
            this.col_valor_iss.MinimumWidth = 6;
            this.col_valor_iss.Name = "col_valor_iss";
            this.col_valor_iss.Width = 50;
            // 
            // col_icms_st
            // 
            this.col_icms_st.DataPropertyName = "ICMS_ST_ITEM";
            this.col_icms_st.HeaderText = "ICMS ST";
            this.col_icms_st.MinimumWidth = 6;
            this.col_icms_st.Name = "col_icms_st";
            this.col_icms_st.Width = 125;
            // 
            // col_valor_bc_st
            // 
            this.col_valor_bc_st.DataPropertyName = "VALOR_BC_ICMS_ST_ITEM";
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = null;
            this.col_valor_bc_st.DefaultCellStyle = dataGridViewCellStyle7;
            this.col_valor_bc_st.HeaderText = "Valor BC ST";
            this.col_valor_bc_st.MinimumWidth = 6;
            this.col_valor_bc_st.Name = "col_valor_bc_st";
            this.col_valor_bc_st.Width = 125;
            // 
            // col_valor_st
            // 
            this.col_valor_st.DataPropertyName = "VALOR_ICMS_ST_ITEM";
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = null;
            this.col_valor_st.DefaultCellStyle = dataGridViewCellStyle8;
            this.col_valor_st.HeaderText = "Valor ICMS ST";
            this.col_valor_st.MinimumWidth = 6;
            this.col_valor_st.Name = "col_valor_st";
            this.col_valor_st.Width = 125;
            // 
            // col_iva
            // 
            this.col_iva.DataPropertyName = "IVA_ITEM";
            this.col_iva.HeaderText = "IVA";
            this.col_iva.MinimumWidth = 6;
            this.col_iva.Name = "col_iva";
            this.col_iva.Width = 30;
            // 
            // col_reducao
            // 
            this.col_reducao.DataPropertyName = "REDUCAO_ITEM";
            this.col_reducao.HeaderText = "Redução";
            this.col_reducao.MinimumWidth = 6;
            this.col_reducao.Name = "col_reducao";
            this.col_reducao.Width = 40;
            // 
            // col_frete
            // 
            this.col_frete.DataPropertyName = "VALOR_FRETE_ITEM";
            this.col_frete.HeaderText = "Frete";
            this.col_frete.MinimumWidth = 6;
            this.col_frete.Name = "col_frete";
            this.col_frete.Width = 40;
            // 
            // col_desconto
            // 
            this.col_desconto.DataPropertyName = "VALOR_DESCONTO_ITEM";
            this.col_desconto.HeaderText = "Desc.";
            this.col_desconto.MinimumWidth = 6;
            this.col_desconto.Name = "col_desconto";
            this.col_desconto.Width = 40;
            // 
            // col_seguro
            // 
            this.col_seguro.DataPropertyName = "VALOR_SEGURO_ITEM";
            this.col_seguro.HeaderText = "Seguro";
            this.col_seguro.MinimumWidth = 6;
            this.col_seguro.Name = "col_seguro";
            this.col_seguro.Width = 40;
            // 
            // col_outras_desp
            // 
            this.col_outras_desp.DataPropertyName = "VALOR_OUTRAS_DESP_ITEM";
            this.col_outras_desp.HeaderText = "Outras Desp.";
            this.col_outras_desp.MinimumWidth = 6;
            this.col_outras_desp.Name = "col_outras_desp";
            this.col_outras_desp.Width = 40;
            // 
            // col_cofins
            // 
            this.col_cofins.DataPropertyName = "COFINS_ITEM";
            this.col_cofins.HeaderText = "Cofins";
            this.col_cofins.MinimumWidth = 6;
            this.col_cofins.Name = "col_cofins";
            this.col_cofins.Width = 30;
            // 
            // col_valor_cofins
            // 
            this.col_valor_cofins.DataPropertyName = "VALOR_COFINS_ITEM";
            this.col_valor_cofins.HeaderText = "V. Cofins";
            this.col_valor_cofins.MinimumWidth = 6;
            this.col_valor_cofins.Name = "col_valor_cofins";
            this.col_valor_cofins.Width = 40;
            // 
            // col_pis
            // 
            this.col_pis.DataPropertyName = "PIS_ITEM";
            this.col_pis.HeaderText = "Pis";
            this.col_pis.MinimumWidth = 6;
            this.col_pis.Name = "col_pis";
            this.col_pis.Width = 40;
            // 
            // col_valor_pis
            // 
            this.col_valor_pis.DataPropertyName = "VALOR_PIS_ITEM";
            this.col_valor_pis.HeaderText = "Valor Pis";
            this.col_valor_pis.MinimumWidth = 6;
            this.col_valor_pis.Name = "col_valor_pis";
            this.col_valor_pis.Width = 40;
            // 
            // col_prestacao_servico
            // 
            this.col_prestacao_servico.DataPropertyName = "PRESTACAO_SERVICO_ITEM";
            this.col_prestacao_servico.HeaderText = "Prest. Serv.";
            this.col_prestacao_servico.MinimumWidth = 6;
            this.col_prestacao_servico.Name = "col_prestacao_servico";
            this.col_prestacao_servico.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_prestacao_servico.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_prestacao_servico.Width = 40;
            // 
            // col_st
            // 
            this.col_st.DataPropertyName = "ST_ITEM";
            this.col_st.HeaderText = "St.";
            this.col_st.MinimumWidth = 6;
            this.col_st.Name = "col_st";
            this.col_st.Width = 30;
            // 
            // col_origem
            // 
            this.col_origem.DataPropertyName = "ORIGEM_ITEM";
            this.col_origem.HeaderText = "Orig.";
            this.col_origem.MinimumWidth = 6;
            this.col_origem.Name = "col_origem";
            this.col_origem.Width = 20;
            // 
            // col_mod_item
            // 
            this.col_mod_item.DataPropertyName = "MOD_BC_ITEM";
            this.col_mod_item.HeaderText = "Mod. BC";
            this.col_mod_item.MinimumWidth = 6;
            this.col_mod_item.Name = "col_mod_item";
            this.col_mod_item.Width = 125;
            // 
            // col_mod_bc_st
            // 
            this.col_mod_bc_st.DataPropertyName = "MOD_BC_ST_ITEM";
            this.col_mod_bc_st.HeaderText = "Mod. BC ST";
            this.col_mod_bc_st.MinimumWidth = 6;
            this.col_mod_bc_st.Name = "col_mod_bc_st";
            this.col_mod_bc_st.Width = 125;
            // 
            // col_red_st
            // 
            this.col_red_st.DataPropertyName = "REDUCAO_ST_ITEM";
            this.col_red_st.HeaderText = "Red. ST";
            this.col_red_st.MinimumWidth = 6;
            this.col_red_st.Name = "col_red_st";
            this.col_red_st.Width = 40;
            // 
            // col_aliq_cred
            // 
            this.col_aliq_cred.DataPropertyName = "ALIQUOTA_CREDITO_ITEM";
            this.col_aliq_cred.HeaderText = "Aliq. Cred.";
            this.col_aliq_cred.MinimumWidth = 6;
            this.col_aliq_cred.Name = "col_aliq_cred";
            this.col_aliq_cred.Width = 50;
            // 
            // col_valor_credito
            // 
            this.col_valor_credito.DataPropertyName = "VALOR_CREDITO_ITEM";
            this.col_valor_credito.HeaderText = "Valor Cred.";
            this.col_valor_credito.MinimumWidth = 6;
            this.col_valor_credito.Name = "col_valor_credito";
            this.col_valor_credito.Width = 50;
            // 
            // Trib
            // 
            this.Trib.HeaderText = "Trib";
            this.Trib.MinimumWidth = 6;
            this.Trib.Name = "Trib";
            this.Trib.Text = "Trib";
            this.Trib.ToolTipText = "Trib";
            this.Trib.UseColumnTextForButtonValue = true;
            this.Trib.Width = 125;
            // 
            // col_tipo_servico
            // 
            this.col_tipo_servico.DataPropertyName = "TIPO_SERVICO_ITEM";
            this.col_tipo_servico.HeaderText = "Tipo Serviço";
            this.col_tipo_servico.MinimumWidth = 6;
            this.col_tipo_servico.Name = "col_tipo_servico";
            this.col_tipo_servico.Width = 125;
            // 
            // col_pedido_compra
            // 
            this.col_pedido_compra.DataPropertyName = "PEDIDO_COMPRA_ITEM";
            this.col_pedido_compra.HeaderText = "Ped. Compra";
            this.col_pedido_compra.MinimumWidth = 6;
            this.col_pedido_compra.Name = "col_pedido_compra";
            this.col_pedido_compra.Width = 70;
            // 
            // col_item_pedido_compra
            // 
            this.col_item_pedido_compra.DataPropertyName = "ITEM_PEDIDO_COMPRA_ITEM";
            this.col_item_pedido_compra.HeaderText = "Item Pedido Compra";
            this.col_item_pedido_compra.MinimumWidth = 6;
            this.col_item_pedido_compra.Name = "col_item_pedido_compra";
            this.col_item_pedido_compra.Width = 125;
            // 
            // col_cod
            // 
            this.col_cod.DataPropertyName = "COD_ITENS_NOTA";
            this.col_cod.HeaderText = "Cod";
            this.col_cod.MinimumWidth = 6;
            this.col_cod.Name = "col_cod";
            this.col_cod.Width = 50;
            // 
            // col_ean
            // 
            this.col_ean.DataPropertyName = "COD_EAN_ITEM";
            this.col_ean.HeaderText = "Cod. EAN";
            this.col_ean.MinimumWidth = 6;
            this.col_ean.Name = "col_ean";
            this.col_ean.Width = 125;
            // 
            // col_porc_trib
            // 
            this.col_porc_trib.DataPropertyName = "PORC_TRIB_ITEM";
            this.col_porc_trib.HeaderText = "% Tributos";
            this.col_porc_trib.MinimumWidth = 6;
            this.col_porc_trib.Name = "col_porc_trib";
            this.col_porc_trib.Width = 125;
            // 
            // col_tot_trib
            // 
            this.col_tot_trib.DataPropertyName = "TOTAL_TRIB_ITEM";
            this.col_tot_trib.HeaderText = "Total Tributos";
            this.col_tot_trib.MinimumWidth = 6;
            this.col_tot_trib.Name = "col_tot_trib";
            this.col_tot_trib.Width = 125;
            // 
            // col_cest
            // 
            this.col_cest.DataPropertyName = "CEST_ITEM";
            this.col_cest.HeaderText = "CEST";
            this.col_cest.MinimumWidth = 6;
            this.col_cest.Name = "col_cest";
            this.col_cest.Width = 125;
            // 
            // PORC_IPI_DEV_ITEM
            // 
            this.PORC_IPI_DEV_ITEM.DataPropertyName = "PORC_IPI_DEV_ITEM";
            this.PORC_IPI_DEV_ITEM.HeaderText = "PORC_IPI_DEV_ITEM";
            this.PORC_IPI_DEV_ITEM.MinimumWidth = 6;
            this.PORC_IPI_DEV_ITEM.Name = "PORC_IPI_DEV_ITEM";
            this.PORC_IPI_DEV_ITEM.Width = 125;
            // 
            // VALOR_IPI_DEV_ITEM
            // 
            this.VALOR_IPI_DEV_ITEM.DataPropertyName = "VALOR_IPI_DEV_ITEM";
            this.VALOR_IPI_DEV_ITEM.HeaderText = "VALOR_IPI_DEV_ITEM";
            this.VALOR_IPI_DEV_ITEM.MinimumWidth = 6;
            this.VALOR_IPI_DEV_ITEM.Name = "VALOR_IPI_DEV_ITEM";
            this.VALOR_IPI_DEV_ITEM.Width = 125;
            // 
            // IPI_TRIB_ITEM
            // 
            this.IPI_TRIB_ITEM.DataPropertyName = "IPI_TRIB_ITEM";
            this.IPI_TRIB_ITEM.HeaderText = "IPI_TRIB_ITEM";
            this.IPI_TRIB_ITEM.MinimumWidth = 6;
            this.IPI_TRIB_ITEM.Name = "IPI_TRIB_ITEM";
            this.IPI_TRIB_ITEM.Width = 125;
            // 
            // IPI_N_TRIB_ITEM
            // 
            this.IPI_N_TRIB_ITEM.DataPropertyName = "IPI_N_TRIB_ITEM";
            this.IPI_N_TRIB_ITEM.HeaderText = "IPI_N_TRIB_ITEM";
            this.IPI_N_TRIB_ITEM.MinimumWidth = 6;
            this.IPI_N_TRIB_ITEM.Name = "IPI_N_TRIB_ITEM";
            this.IPI_N_TRIB_ITEM.Width = 125;
            // 
            // CST_IPI_TRIB_ITEM
            // 
            this.CST_IPI_TRIB_ITEM.DataPropertyName = "CST_IPI_TRIB_ITEM";
            this.CST_IPI_TRIB_ITEM.HeaderText = "CST_IPI_TRIB_ITEM";
            this.CST_IPI_TRIB_ITEM.MinimumWidth = 6;
            this.CST_IPI_TRIB_ITEM.Name = "CST_IPI_TRIB_ITEM";
            this.CST_IPI_TRIB_ITEM.Width = 125;
            // 
            // CST_IPI_N_TRIB_ITEM
            // 
            this.CST_IPI_N_TRIB_ITEM.DataPropertyName = "CST_IPI_N_TRIB_ITEM";
            this.CST_IPI_N_TRIB_ITEM.HeaderText = "CST_IPI_N_TRIB_ITEM";
            this.CST_IPI_N_TRIB_ITEM.MinimumWidth = 6;
            this.CST_IPI_N_TRIB_ITEM.Name = "CST_IPI_N_TRIB_ITEM";
            this.CST_IPI_N_TRIB_ITEM.Width = 125;
            // 
            // TIPO_PIS_ITEM
            // 
            this.TIPO_PIS_ITEM.DataPropertyName = "TIPO_PIS_ITEM";
            this.TIPO_PIS_ITEM.HeaderText = "TIPO_PIS_ITEM";
            this.TIPO_PIS_ITEM.MinimumWidth = 6;
            this.TIPO_PIS_ITEM.Name = "TIPO_PIS_ITEM";
            this.TIPO_PIS_ITEM.Width = 125;
            // 
            // CST_PIS_ITEM
            // 
            this.CST_PIS_ITEM.DataPropertyName = "CST_PIS_ITEM";
            this.CST_PIS_ITEM.HeaderText = "CST_PIS_ITEM";
            this.CST_PIS_ITEM.MinimumWidth = 6;
            this.CST_PIS_ITEM.Name = "CST_PIS_ITEM";
            this.CST_PIS_ITEM.Width = 125;
            // 
            // TIPO_COFINS_ITEM
            // 
            this.TIPO_COFINS_ITEM.DataPropertyName = "TIPO_COFINS_ITEM";
            this.TIPO_COFINS_ITEM.HeaderText = "TIPO_COFINS_ITEM";
            this.TIPO_COFINS_ITEM.MinimumWidth = 6;
            this.TIPO_COFINS_ITEM.Name = "TIPO_COFINS_ITEM";
            this.TIPO_COFINS_ITEM.Width = 125;
            // 
            // CST_COFINS_ITEM
            // 
            this.CST_COFINS_ITEM.DataPropertyName = "CST_COFINS_ITEM";
            this.CST_COFINS_ITEM.HeaderText = "CST_COFINS_ITEM";
            this.CST_COFINS_ITEM.MinimumWidth = 6;
            this.CST_COFINS_ITEM.Name = "CST_COFINS_ITEM";
            this.CST_COFINS_ITEM.Width = 125;
            // 
            // BC_IPI_ITEM
            // 
            this.BC_IPI_ITEM.DataPropertyName = "BC_IPI_ITEM";
            this.BC_IPI_ITEM.HeaderText = "BC_IPI_ITEM";
            this.BC_IPI_ITEM.MinimumWidth = 6;
            this.BC_IPI_ITEM.Name = "BC_IPI_ITEM";
            this.BC_IPI_ITEM.Width = 125;
            // 
            // BC_PIS_ITEM
            // 
            this.BC_PIS_ITEM.DataPropertyName = "BC_PIS_ITEM";
            this.BC_PIS_ITEM.HeaderText = "BC_PIS_ITEM";
            this.BC_PIS_ITEM.MinimumWidth = 6;
            this.BC_PIS_ITEM.Name = "BC_PIS_ITEM";
            this.BC_PIS_ITEM.Width = 125;
            // 
            // BC_COFINS_ITEM
            // 
            this.BC_COFINS_ITEM.DataPropertyName = "BC_COFINS_ITEM";
            this.BC_COFINS_ITEM.HeaderText = "BC_COFINS_ITEM";
            this.BC_COFINS_ITEM.MinimumWidth = 6;
            this.BC_COFINS_ITEM.Name = "BC_COFINS_ITEM";
            this.BC_COFINS_ITEM.Width = 125;
            // 
            // N_NF_ENT_ITEM
            // 
            this.N_NF_ENT_ITEM.DataPropertyName = "N_NF_ENT_ITEM";
            this.N_NF_ENT_ITEM.HeaderText = "N_NF_ENT_ITEM";
            this.N_NF_ENT_ITEM.Name = "N_NF_ENT_ITEM";
            // 
            // DI_ITEM
            // 
            this.DI_ITEM.DataPropertyName = "DI_ITEM";
            this.DI_ITEM.HeaderText = "DI_ITEM";
            this.DI_ITEM.Name = "DI_ITEM";
            // 
            // DATA_DI_ITEM
            // 
            this.DATA_DI_ITEM.DataPropertyName = "DATA_DI_ITEM";
            this.DATA_DI_ITEM.HeaderText = "DATA_DI_ITEM";
            this.DATA_DI_ITEM.Name = "DATA_DI_ITEM";
            // 
            // LOCAL_DES_ITEM
            // 
            this.LOCAL_DES_ITEM.DataPropertyName = "LOCAL_DES_ITEM";
            this.LOCAL_DES_ITEM.HeaderText = "LOCAL_DES_ITEM";
            this.LOCAL_DES_ITEM.Name = "LOCAL_DES_ITEM";
            // 
            // UF_DES_ITEM
            // 
            this.UF_DES_ITEM.DataPropertyName = "UF_DES_ITEM";
            this.UF_DES_ITEM.HeaderText = "UF_DES_ITEM";
            this.UF_DES_ITEM.Name = "UF_DES_ITEM";
            // 
            // DATA_DES_ITEM
            // 
            this.DATA_DES_ITEM.DataPropertyName = "DATA_DES_ITEM";
            this.DATA_DES_ITEM.HeaderText = "DATA_DES_ITEM";
            this.DATA_DES_ITEM.Name = "DATA_DES_ITEM";
            // 
            // COD_EXP_ITEM
            // 
            this.COD_EXP_ITEM.DataPropertyName = "COD_EXP_ITEM";
            this.COD_EXP_ITEM.HeaderText = "COD_EXP_ITEM";
            this.COD_EXP_ITEM.Name = "COD_EXP_ITEM";
            // 
            // BC_II_ITEM
            // 
            this.BC_II_ITEM.DataPropertyName = "BC_II_ITEM";
            this.BC_II_ITEM.HeaderText = "BC_II_ITEM";
            this.BC_II_ITEM.Name = "BC_II_ITEM";
            // 
            // VALOR_II_ITEM
            // 
            this.VALOR_II_ITEM.DataPropertyName = "VALOR_II_ITEM";
            this.VALOR_II_ITEM.HeaderText = "VALOR_II_ITEM";
            this.VALOR_II_ITEM.Name = "VALOR_II_ITEM";
            // 
            // DESP_ADUANEIRAS_ITEM
            // 
            this.DESP_ADUANEIRAS_ITEM.DataPropertyName = "DESP_ADUANEIRAS_ITEM";
            this.DESP_ADUANEIRAS_ITEM.HeaderText = "DESP_ADUANEIRAS_ITEM";
            this.DESP_ADUANEIRAS_ITEM.Name = "DESP_ADUANEIRAS_ITEM";
            // 
            // IOF_II_ITEM
            // 
            this.IOF_II_ITEM.DataPropertyName = "IOF_II_ITEM";
            this.IOF_II_ITEM.HeaderText = "IOF_II_ITEM";
            this.IOF_II_ITEM.Name = "IOF_II_ITEM";
            // 
            // CST_IBSCBS_ITEM
            // 
            this.CST_IBSCBS_ITEM.DataPropertyName = "CST_IBSCBS_ITEM";
            this.CST_IBSCBS_ITEM.HeaderText = "CST_IBSCBS_ITEM";
            this.CST_IBSCBS_ITEM.Name = "CST_IBSCBS_ITEM";
            // 
            // CCLASSTRIB_ITEM
            // 
            this.CCLASSTRIB_ITEM.DataPropertyName = "CCLASSTRIB_ITEM";
            this.CCLASSTRIB_ITEM.HeaderText = "CCLASSTRIB_ITEM";
            this.CCLASSTRIB_ITEM.Name = "CCLASSTRIB_ITEM";
            // 
            // ALIQ_IBS_ITEM
            // 
            this.ALIQ_IBS_ITEM.DataPropertyName = "ALIQ_IBS_ITEM";
            this.ALIQ_IBS_ITEM.HeaderText = "ALIQ_IBS_ITEM";
            this.ALIQ_IBS_ITEM.Name = "ALIQ_IBS_ITEM";
            // 
            // ALIQ_CBS_ITEM
            // 
            this.ALIQ_CBS_ITEM.DataPropertyName = "ALIQ_CBS_ITEM";
            this.ALIQ_CBS_ITEM.HeaderText = "ALIQ_CBS_ITEM";
            this.ALIQ_CBS_ITEM.Name = "ALIQ_CBS_ITEM";
            // 
            // VALOR_IBS_ITEM
            // 
            this.VALOR_IBS_ITEM.DataPropertyName = "VALOR_IBS_ITEM";
            this.VALOR_IBS_ITEM.HeaderText = "VALOR_IBS_ITEM";
            this.VALOR_IBS_ITEM.Name = "VALOR_IBS_ITEM";
            // 
            // VALOR_CBS_ITEM
            // 
            this.VALOR_CBS_ITEM.DataPropertyName = "VALOR_CBS_ITEM";
            this.VALOR_CBS_ITEM.HeaderText = "VALOR_CBS_ITEM";
            this.VALOR_CBS_ITEM.Name = "VALOR_CBS_ITEM";
            // 
            // BC_IBSCBS_ITEM
            // 
            this.BC_IBSCBS_ITEM.DataPropertyName = "BC_IBSCBS_ITEM";
            this.BC_IBSCBS_ITEM.HeaderText = "BC_IBSCBS_ITEM";
            this.BC_IBSCBS_ITEM.Name = "BC_IBSCBS_ITEM";
            // 
            // form_faturamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 724);
            this.Controls.Add(this.dgvItens_nota);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.tb_informacoes_fisco);
            this.Controls.Add(this.label85);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.rb5101);
            this.Controls.Add(this.rb5124);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.tb_razao_empresa);
            this.Controls.Add(this.tb_cnpj_empresa);
            this.Controls.Add(this.label82);
            this.Controls.Add(this.rb_5917);
            this.Controls.Add(this.rb_5949);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.rb_5202);
            this.Controls.Add(this.rb_5904);
            this.Controls.Add(this.rb_1410);
            this.Controls.Add(this.dgvPedidos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.itemPanel);
            this.Controls.Add(this.cbNfe_teste);
            this.Controls.Add(this.estadolabel);
            this.Controls.Add(this.label63);
            this.Controls.Add(this.cnpjlabel);
            this.Controls.Add(this.label);
            this.Controls.Add(this.empresalabel);
            this.Controls.Add(this.label62);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbNfe);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tb_dados_adicionais);
            this.Controls.Add(this.label29);
            this.Name = "form_faturamento";
            this.Text = "Faturamento";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.form_faturamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsNota_fiscal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NOTA_FISCAL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CLIENTES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransportadoras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRANSPORTADORAS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsItens_nota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITENS_NOTA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDesenhos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DESENHOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUlt_imp_nf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ULT_IMP_NF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CFO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRotas_campo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ROTAS_CAMPO)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.gbNfe.ResumeLayout(false);
            this.gbNfe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsForma_pgto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FORMA_PGTO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsImp_duplicatas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMP_DUPLICATAS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAliquota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ALIQUOTA_SIMPLES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsContas_a_receber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CONTAS_A_RECEBER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_codigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EMPRESA)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFatura_nf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFatura_nf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FATURA_NF)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.itemPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPedidos_nf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PEDIDOS_NF)).EndInit();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens_nota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
      
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_n_nf;
        private System.Windows.Forms.TextBox tb_saida;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_base_calc_icm;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_valor_icm;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_base_cal_icm_st;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_valor_icm_st;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tb_total_prod;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tb_valor_ipi;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tb_outras_des_ace;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tb_valor_seg;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tb_valor_fre;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tb_total_nota;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tb_marca;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox tb_especie;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox tb_qtde_volume;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox tb_peso_bruto;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox tb_peso_liquido;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox tb_dados_adicionais;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox tb_data_emissao;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.Label label31;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datItens_nota;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
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
        private System.Windows.Forms.RadioButton radioEntrada;
        private System.Windows.Forms.RadioButton radioSaida;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datNota_fiscal;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand8;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand6;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand5;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand7;
        private System.Data.DataSet dsNota_fiscal;
        private System.Data.DataTable NOTA_FISCAL;
        private System.Data.DataColumn COD_SISTEMA_NF;
        private System.Data.DataColumn N_NF;
        private System.Data.DataColumn FORMA_PGTO_NF;
        private System.Data.DataColumn DATA_ENTR_SAI_NF;
        private System.Data.DataColumn DATA_EMISSAO_NF;
        private System.Data.DataColumn DATA_VENCIMENTO_NF;
        private System.Data.DataColumn CFO_NF;
        private System.Data.DataColumn CFO_2_NF;
        private System.Data.DataColumn CLIENTE_FORN_NF;
        private System.Data.DataColumn ENDERECO_ENTREGA_NF;
        private System.Data.DataColumn BASE_CALC_ICMS_NF;
        private System.Data.DataColumn VALOR_ICMS_NF;
        private System.Data.DataColumn BASE_CALC_ICM_SUBS;
        private System.Data.DataColumn VALOR_ICM_SUBS;
        private System.Data.DataColumn VALOR_FRETE_NF;
        private System.Data.DataColumn VALOR_SEGURO_NF;
        private System.Data.DataColumn OUTRAS_DESP_NF;
        private System.Data.DataColumn VALOR_IPI_NF;
        private System.Data.DataColumn VALOR_TOT_PROD_NF;
        private System.Data.DataColumn VALOR_NOTA_NF;
        private System.Data.DataColumn TRANSPORTADORA_NF;
        private System.Data.DataColumn FRETE_CONTA_NF;
        private System.Data.DataColumn PLACA_VEICULO_NF;
        private System.Data.DataColumn ESTADO_VEICULO_NF;
        private System.Data.DataColumn QTDE_NF;
        private System.Data.DataColumn ESPECIE_NF;
        private System.Data.DataColumn MARCA_NF;
        private System.Data.DataColumn PESO_BRUTO_NF;
        private System.Data.DataColumn PESO_LIQUIDO_NF;
        private System.Windows.Forms.Button salva_registro;
        private System.Windows.Forms.Button novo_registro;
        private System.Windows.Forms.TextBox tb_cod_interno;
        private System.Windows.Forms.Label label34;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datOp;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand12;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand10;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand9;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand11;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datDesenhos;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand16;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand14;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand13;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand15;
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
        private System.Data.DataColumn DESCRICAO_PECA;
        private System.Data.DataColumn MARCA_PECA;
        private System.Data.DataColumn UNIDADE_PECA;
        private System.Data.DataColumn PESO_PECA;
        private System.Data.DataColumn TRIBUTACAO_PECA;
        private System.Data.DataColumn ICMS_PECA;
        private System.Data.DataColumn IPI_PECA;
        private System.Data.DataColumn PRECO_PECA;
        private System.Data.DataColumn QTDE_ESTOQUE_PECA;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datUlt_imp_nf;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand20;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand18;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand17;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand19;
        private System.Data.DataSet dsUlt_imp_nf;
        private System.Data.DataTable ULT_IMP_NF;
        private System.Data.DataColumn COD_ULT_IMP_NF;
        private System.Data.DataColumn NUM_ULT_NF;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbNota_fiscal;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbUlt_imp_nf;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand24;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand22;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand21;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand23;
        private System.Data.DataSet dsClientes;
        private System.Data.DataTable CLIENTES;
        private System.Data.DataColumn COD_CLIENTE;
        private System.Data.DataColumn RAZAO_SOCIAL;
        private System.Data.DataColumn NOME_FANTASIA;
        private System.Data.DataColumn IE;
        private System.Data.DataColumn CNPJ;
        private System.Data.DataColumn IM;
        private System.Data.DataColumn ENDERECO;
        private System.Data.DataColumn BAIRRO;
        private System.Data.DataColumn CIDADE;
        private System.Data.DataColumn ESTADO;
        private System.Data.DataColumn PAIS;
        private System.Data.DataColumn CEP_CLIENTE;
        private System.Data.DataColumn FONE;
        private System.Data.DataColumn EMAIL;
        private System.Data.DataColumn CONTATO1;
        private System.Data.DataColumn FONE1;
        private System.Data.DataColumn EMAIL1;
        private System.Data.DataColumn CONTATO2;
        private System.Data.DataColumn FONE2;
        private System.Data.DataColumn EMAIL2;
        private System.Data.DataColumn SITUACAO;
        private System.Data.DataColumn TIPO;
        private System.Data.DataColumn TRANSPORTADORA_CLIENTE;
        private System.Data.DataColumn ATIVIDADE_CLIENTE;
        private System.Data.DataColumn BANCO_CLIENTE;
        private System.Data.DataColumn AGENCIA_CLIENTE;
        private System.Data.DataColumn REGIAO;
        private System.Data.DataColumn VENDEDOR_CLIENTE;
        private System.Data.DataColumn DATA_CADASTRO_CLIENTE;
        private System.Data.DataColumn ETIQUETA;
        private System.Data.DataSet dsTransportadoras;
        private System.Data.DataTable TRANSPORTADORAS;
        private System.Data.DataColumn COD_TRANSPORTADORA;
        private System.Data.DataColumn SITUACAO_TRANSPORTADORA;
        private System.Data.DataColumn NOME_TRANSPORTADORA;
        private System.Data.DataColumn RAZAO_SOCIAL_TRANSPORTADORA;
        private System.Data.DataColumn ENDERECO_TRANSPORTADORA;
        private System.Data.DataColumn BAIRRO_TRANSPORTADORA;
        private System.Data.DataColumn CIDADE_TRANSPORTADORA;
        private System.Data.DataColumn ESTADO_TRANSPORTADORA;
        private System.Data.DataColumn PAIS_TRANSPORTADORA;
        private System.Data.DataColumn CNPJ_TRANSPORTADORA;
        private System.Data.DataColumn IE_TRANSPORTADORA;
        private System.Data.DataColumn DATA_INSCRICAO_TRANSPORTADORA;
        private System.Data.DataColumn TEL_1_TRANSPORTADORA;
        private System.Data.DataColumn TEL_2_TRANSPORTADORA;
        private System.Data.DataColumn CONTATO_1_TRANSPORTADORA;
        private System.Data.DataColumn CONTATO_2_TRANSPORTADORA;
        private System.Data.DataColumn EMAIL_1_TRANSPORTADORA;
        private System.Data.DataColumn EMAIL_2_TRANSPORTADORA;
        private System.Data.DataColumn FONE_TRANSPORTADORA;
        private System.Data.DataColumn EMAIL_TRANSPORTADORA;
        private System.Data.DataColumn IM_TRANSPORTADORA;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datClientes;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand28;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand26;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand25;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand27;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datTransportadoras;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand32;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand30;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand29;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand31;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datCfo;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand36;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand34;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand33;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand35;
        private System.Data.DataSet dsCfo;
        private System.Data.DataTable CFO;
        private System.Data.DataColumn COD_SISTEMA_CFO;
        private System.Data.DataColumn N_CFO;
        private System.Data.DataColumn DESCRICAO_CFO;
        private System.Data.DataColumn OBSERVACAO_CFO;
        private System.Windows.Forms.TextBox tb_cnpj_cliente;
        private System.Windows.Forms.TextBox tb_transportadora;
        private System.Data.DataColumn dataColumn5;
        private System.Windows.Forms.TextBox tb_frete;
        private System.Data.DataColumn dataColumn6;
        private System.Data.DataColumn dataColumn7;
        private System.Data.DataColumn dataColumn8;
        private System.Data.DataColumn dataColumn9;
        private System.Data.DataColumn dataColumn10;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbItens_nota;
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
        private System.Data.DataColumn PECAS_APROVADAS;
        private System.Data.DataColumn PECAS_REJEITADAS;
        private System.Data.DataColumn TIPO_REJEICAO;
        private System.Data.DataColumn OPERADOR_FINALIZADOR;
        private System.Data.DataColumn MAQ_FECHA;
        private System.Data.DataColumn RETRABALHO_ROTA;
        private System.Data.DataColumn SALDO_HORAS;
        private System.Data.DataColumn HORAS_OPERADOR;
        private System.Data.DataColumn HORAS_MAQUINA;
        private System.Data.DataColumn PECAS_ADICIONAIS;
        
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datRotas_campo;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand40;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand38;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand37;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand39;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand41;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand42;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand43;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand44;
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
        private System.Data.DataColumn LOTE;
        private System.Data.DataColumn ESPESSURA_OP;
        private System.Data.DataColumn OBSERVACOES_OP;
        private System.Data.DataColumn REVISAO_OP;
        private System.Data.DataColumn DESCRICAO_PECA_OP;
        private System.Data.DataColumn MARCA_OP;
        private System.Data.DataColumn UNIDADE_OP;
        private System.Data.DataColumn ICMS_OP;
        private System.Data.DataColumn IPI_OP;
        private System.Data.DataColumn dataColumn11;
        private System.Data.DataColumn dataColumn12;
        private System.Windows.Forms.TextBox tb_descricao_peca;
        private System.Windows.Forms.TextBox tb_cod_peca;
        private System.Windows.Forms.TextBox tb_preco_unit_peca;
        private System.Windows.Forms.TextBox tb_qtde_peca;
        private System.Windows.Forms.TextBox tb_unid_peca;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Data.DataColumn dataColumn13;
        private System.Data.DataColumn dataColumn15;
        private System.Data.DataColumn dataColumn16;
        private System.Windows.Forms.Label label35;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter fbDataAdapter1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand48;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand46;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand45;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand47;
        private System.Windows.Forms.Label label37;
        private System.Data.DataColumn dataColumn14;
        private System.Windows.Forms.TextBox tb_ncm_peca;
        private System.Data.DataColumn dataColumn18;
        private System.Data.DataColumn dataColumn17;
        private System.Data.DataColumn dataColumn19;
        private System.Data.DataColumn dataColumn20;
        private System.Data.DataColumn dataColumn21;
        private System.Windows.Forms.TextBox tb_local_exportacao;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox tb_uf_exportacao;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Data.DataColumn dataColumn22;
        private System.Data.DataColumn dataColumn23;
        private System.Data.DataColumn dataColumn24;
        private System.Windows.Forms.Button bt_imprimirNFe;
        private System.Windows.Forms.Button bt_enviarNFe;
        private System.Windows.Forms.Button bt_gerarXML;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel barra_status;
        private System.Data.DataColumn dataColumn25;
        private System.Windows.Forms.TextBox tb_status_nfe;
        private FirebirdSql.Data.FirebirdClient.FbCommand comando_select;
        private System.Windows.Forms.Button bt_cancelarNFe;
        private System.Windows.Forms.Button br_consultaStatus;
        private System.Windows.Forms.GroupBox gbNfe;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.TextBox tb_recibo;
        private System.Windows.Forms.Label label44;
        private System.Data.DataColumn dataColumn26;
        private System.Data.DataColumn dataColumn27;
        private System.Data.DataColumn dataColumn28;
        private System.Data.DataColumn dataColumn29;
        private System.Data.DataColumn dataColumn30;
        private System.Data.DataColumn dataColumn31;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.TextBox tb_ent_sai_nfe;
        private System.Data.DataColumn dataColumn33;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.TextBox tb_chave_acesso_nfe;
        private System.Data.DataSet dsForma_pgto;
        private System.Data.DataTable FORMA_PGTO;
        private System.Data.DataColumn COD_FORMA_PGTO;
        private System.Data.DataColumn DESCRICAO_FORMA_PGTO;
        private System.Data.DataColumn N_PARCELAS_FORMA_PGTO;
        private System.Data.DataColumn PRAZO_1_FORMA_PGTO;
        private System.Data.DataColumn PRAZO_2_FORMA_PGTO;
        private System.Data.DataColumn PRAZO_3_FORMA_PGTO;
        private System.Data.DataColumn PRAZO_4_FORMA_PGTO;
        private System.Data.DataColumn PRAZO_5_FORMA_PGTO;
        private System.Data.DataColumn PRAZO_6_FORMA_PGTO;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datForma_pgto;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand52;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand50;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand49;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand51;
        private System.Windows.Forms.TextBox cb_forma_pgto;
        private System.Windows.Forms.TextBox tb_cfo_peca;
        private System.Data.DataColumn dataColumn34;
        private System.Windows.Forms.TextBox tb_natureza_operacao;
        private System.Windows.Forms.Label label48;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datFatura_nf;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand56;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand54;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand53;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand55;
        private System.Data.DataColumn dataColumn36;
        private System.Windows.Forms.TextBox tb_cliente;
        private System.Data.DataColumn dataColumn38;
        private System.Data.DataColumn dataColumn39;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datImp_duplicatas;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand60;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand58;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand57;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand59;
        private System.Data.DataSet dsImp_duplicatas;
        private System.Data.DataTable IMP_DUPLICATAS;
        private System.Data.DataColumn COD_IMP_DUPLICATA;
        private System.Data.DataColumn COD_1_IMP_DUPLICATA;
        private System.Data.DataColumn DATA_1_IMP_DUPLICATA;
        private System.Data.DataColumn VALOR_1_IMP_DUPLICATA;
        private System.Data.DataColumn COD_2_IMP_DUPLICATA;
        private System.Data.DataColumn DATA_2_IMP_DUPLICATA;
        private System.Data.DataColumn VALOR_2_IMP_DUPLICATA;
        private System.Data.DataColumn COD_3_IMP_DUPLICATA;
        private System.Data.DataColumn DATA_3_IMP_DUPLICATA;
        private System.Data.DataColumn VALOR_3_IMP_DUPLICATA;
        private System.Data.DataColumn COD_4_IMP_DUPLICATA;
        private System.Data.DataColumn DATA_4_IMP_DUPLICATA;
        private System.Data.DataColumn VALOR_4_IMP_DUPLICATA;
        private System.Data.DataColumn COD_5_IMP_DUPLICATA;
        private System.Data.DataColumn DATA_5_IMP_DUPLICATA;
        private System.Data.DataColumn VALOR_5_IMP_DUPLICATA;
        private System.Data.DataColumn COD_6_IMP_DUPLICATA;
        private System.Data.DataColumn DATA_6_IMP_DUPLICATA;
        private System.Data.DataColumn VALOR_6_IMP_DUPLICATA;
        private System.Windows.Forms.Button button3;
        private System.Data.DataColumn dataColumn40;
        private System.Windows.Forms.CheckBox cbNfe_teste;
        private System.Data.DataColumn dataColumn41;
        private System.Windows.Forms.TextBox tb_motivo_cancelamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_protocolo_autorizacao;
        private System.Windows.Forms.Label label3;
        private System.Data.DataColumn dataColumn42;
        private System.Data.DataColumn dataColumn43;
        private System.Data.DataColumn dataColumn44;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datAliquota;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand64;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand62;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand61;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand63;
        private System.Data.DataSet dsAliquota;
        private System.Data.DataTable ALIQUOTA_SIMPLES;
        private System.Data.DataColumn COD_ALIQUOTA;
        private System.Data.DataColumn VALOR_ALIQUOTA;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datContas_a_receber;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand68;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand66;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand65;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand67;
        private System.Data.DataSet dsContas_a_receber;
        private System.Data.DataTable CONTAS_A_RECEBER;
        private System.Data.DataColumn COD_CR;
        private System.Data.DataColumn VALOR_CR;
        private System.Data.DataColumn DATA_PREVISTA_CR;
        private System.Data.DataColumn DATA_RECEBIMENTO_CR;
        private System.Data.DataColumn COD_CLIENTE_CR;
        private System.Data.DataColumn RAZAO_CLIENTE_CR;
        private System.Data.DataColumn DESCRICAO_CR;
        private System.Data.DataColumn DUPLICATA_CR;
        private System.Data.DataColumn NF_CR;
        private System.Data.DataColumn RECEBIDO_CR;
        private System.Data.DataColumn COD_CAIXA_CR;
        private System.Data.DataColumn dataColumn45;
        private System.Windows.Forms.PictureBox pb_codigo;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datEmpresa;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand72;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand70;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand69;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand71;
        private System.Data.DataSet dsEmpresa;
        private System.Data.DataTable EMPRESA;
        private System.Data.DataColumn COD_EMPRESA;
        private System.Data.DataColumn RAZAO_SOCIAL_EMPRESA;
        private System.Data.DataColumn NOME_FANTASIA_EMPRESA;
        private System.Data.DataColumn CNPJ_EMPRESA;
        private System.Data.DataColumn IE_EMPRESA;
        private System.Data.DataColumn IM_EMPRESA;
        private System.Data.DataColumn ENDERECO_EMPRESA;
        private System.Data.DataColumn N_ENDERECO_EMPRESA;
        private System.Data.DataColumn COMPLEMENTO_EMPRESA;
        private System.Data.DataColumn BAIRRO_EMPRESA;
        private System.Data.DataColumn CIDADE_EMPRESA;
        private System.Data.DataColumn ESTADO_EMPRESA;
        private System.Data.DataColumn CEP_EMPRESA;
        private System.Data.DataColumn TELEFONE_EMPRESA;
        private System.Data.DataColumn COD_CIDADE_EMPRESA;
        private System.Data.DataColumn PAIS_EMPRESA;
        private System.Data.DataColumn COD_PAIS_EMPRESA;
        private System.Data.DataColumn LICENCA_DLL_NFE_EMPRESA;
        private System.Data.DataColumn NOME_CERTIFICADO_NFE_EMPRESA;
        private System.Data.DataColumn ASSUNTO_NFE_EMAIL_EMPRESA;
        private System.Data.DataColumn SMTP_NFE_EMPRESA;
        private System.Data.DataColumn EMAIL_NFE_EMPRESA;
        private System.Data.DataColumn SENHA_EMAIL_NFE_EMPRESA;
        private System.Data.DataColumn LOGOTIPO_EMPRESA;
        private System.Windows.Forms.Button button7;
        private System.Data.DataColumn dataColumn46;
        private System.Data.DataColumn dataColumn47;
        private System.Data.DataColumn dataColumn48;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datTributacao;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand76;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand74;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand73;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand75;
        private System.Data.DataColumn dataColumn49;
        private System.Data.DataColumn dataColumn50;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datProdutos;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand80;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand78;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand77;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand79;
        private System.Data.DataColumn dataColumn51;
        private System.Data.DataColumn dataColumn52;
        private System.Data.DataColumn dataColumn53;
        private System.Data.DataColumn dataColumn54;
        private System.Data.DataColumn dataColumn55;
        private System.Data.DataColumn dataColumn56;
        private System.Data.DataColumn dataColumn57;
        private System.Windows.Forms.TextBox tb_desconto;
        private System.Windows.Forms.Label label_desconto;
        private System.Data.DataColumn dataColumn58;
        private System.Data.DataColumn dataColumn59;
        private System.Data.DataColumn dataColumn60;
        private System.Data.DataColumn dataColumn61;
        private System.Data.DataColumn dataColumn62;
        private System.Data.DataColumn dataColumn63;
        private System.Data.DataColumn dataColumn64;
        private System.Data.DataColumn dataColumn65;
        private System.Data.DataColumn dataColumn66;
        private System.Data.DataColumn dataColumn67;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.TextBox tb_desconto_item;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TextBox tb_frete_item;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.TextBox tb_outras_desp_item;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.TextBox tb_cofins_item;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.TextBox tb_pis_item;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.TextBox tb_ipi_item;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.TextBox tb_iva_item;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.TextBox tb_reducao_item;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.TextBox tb_icms_st;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.TextBox tb_icms_item;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.TextBox tb_cst;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.TextBox tb_origem_peca;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.TextBox tb_mod_bc_item;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.TextBox tb_seguro_item;
        private System.Data.DataColumn dataColumn68;
        private System.Data.DataColumn dataColumn69;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.CheckBox cbExportacao;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel8;
        private System.Data.DataSet dsFatura_nf;
        private System.Data.DataTable FATURA_NF;
        private System.Data.DataColumn COD_FATURA;
        private System.Data.DataColumn PRAZO_FATURA;
        private System.Data.DataColumn DATA_VENC_FATURA;
        private System.Data.DataColumn VALOR_FATURA;
        private System.Data.DataColumn NF_FATURA;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand81;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand82;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbFatura_nf;
        private System.Windows.Forms.DataGridView dgvFatura_nf;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.TextBox tb_iss_item;
        private System.Windows.Forms.TextBox tb_estado_cliente;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label empresalabel;
        private System.Windows.Forms.Label cnpjlabel;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label estadolabel;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.TextBox tb_mod_bc_st_item;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.TextBox tb_reducao_st_item;
        private System.Data.DataColumn dataColumn70;
        private System.Data.DataColumn dataColumn71;
        private System.Data.DataColumn dataColumn72;
        private System.Data.DataColumn dataColumn73;
        private System.Data.DataColumn dataColumn74;
        private System.Data.DataColumn dataColumn75;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Data.DataColumn dataColumn76;
        private System.Data.DataColumn dataColumn77;
        private System.Data.DataColumn dataColumn78;
        private System.Data.DataColumn dataColumn79;
        private System.Data.DataColumn dataColumn80;
        private System.Data.DataColumn dataColumn81;
        private System.Data.DataColumn dataColumn82;
        private System.Data.DataColumn dataColumn83;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.RadioButton rb_ipi_nao_tributado;
        private System.Windows.Forms.RadioButton rb_ipi_tributado;
        private System.Windows.Forms.TextBox tb_cst_ipi_n_tributado;
        private System.Windows.Forms.TextBox tb_cst_ipi_tributado;
        private System.Windows.Forms.TextBox tb_tipo_cofins;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.TextBox tb_cst_cofins;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.TextBox tb_tipo_pis;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.TextBox tb_cst_pis;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TextBox tb_tipo_servico;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.CheckBox cb_prestacao_servico;
        private System.Windows.Forms.Panel itemPanel;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.TextBox tb_n_item_pedido_compra;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.TextBox tb_pedido_compra;
        private System.Data.DataColumn dataColumn84;
        private System.Data.DataColumn dataColumn85;
        private System.Data.DataColumn dataColumn86;
        private System.Data.DataColumn dataColumn87;
        private System.Data.DataColumn dataColumn88;
        private System.Windows.Forms.RadioButton cbNaoTributada;
        private System.Windows.Forms.RadioButton cbTributada;
        private System.Data.DataColumn dataColumn89;
        private System.Data.DataColumn dataColumn90;
        private System.Data.DataColumn dataColumn91;
        private System.Data.DataColumn dataColumn92;
        private System.Windows.Forms.CheckBox cbBC_com_ipi;
        private System.Data.DataColumn dataColumn32;
        private System.Data.DataColumn dataColumn35;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.TextBox tb_aliquota_credito;
        private System.Data.DataColumn dataColumn93;
        private System.Data.DataColumn dataColumn94;
        private System.Windows.Forms.TextBox tb_aliquota_simples;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.TextBox tb_valor_simples;
        private System.Windows.Forms.Label label77;
        private System.Data.DataColumn dataColumn95;
        private System.Data.DataColumn dataColumn96;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbReferenciar;
        private System.Windows.Forms.TextBox tb_Nfe_refer;
        private System.Windows.Forms.Label label_nfe;
        private System.Windows.Forms.Button button11;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datPedidos_venda;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datItens_pedido_venda;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand86;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand84;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand83;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand85;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand94;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand92;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand91;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand93;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand90;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand88;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand87;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand89;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.RadioButton rb_1410;
        private System.Windows.Forms.RadioButton rb_5904;
        private System.Data.DataColumn dataColumn97;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.TextBox tb_ean;
        private System.Windows.Forms.RadioButton rb_5202;
        private System.Windows.Forms.RadioButton rb_5910;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.TextBox tb_sequencial_correcao;
        private System.Windows.Forms.TextBox tb_texto_correcao;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.Label label80;
        private System.Data.DataColumn dataColumn98;
        private System.Data.DataColumn dataColumn99;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datPedidos_nf;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand98;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand96;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand95;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand97;
        private System.Data.DataSet dsPedidos_nf;
        private System.Data.DataTable PEDIDOS_NF;
        private System.Data.DataColumn COD_PEDIDO_NF;
        private System.Data.DataColumn NF_PEDIDO_NF;
        private System.Data.DataColumn N_PEDIDO_NF;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbPedidos_nf;
        private System.Windows.Forms.CheckBox cbxCfopPadrao;
        private System.Data.DataColumn dataColumn100;
        private System.Data.DataColumn dataColumn101;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label87;
        private System.Windows.Forms.TextBox tb_vtrib;
        private System.Windows.Forms.TextBox tb_valor_total_iss;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_base_calc_iss;
        private System.Data.DataColumn dataColumn102;
        private System.Windows.Forms.Button bt_boleto;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.RadioButton rb_5949;
        private System.Windows.Forms.RadioButton rb_5917;
        private System.Data.DataColumn dataColumn103;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODFATURADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_prazo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_data;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cr_fatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn nFFATURADataGridViewTextBoxColumn;
        private System.Data.DataColumn dataColumn104;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.TextBox tb_razao_empresa;
        private System.Windows.Forms.TextBox tb_cnpj_empresa;
        private System.Windows.Forms.Label label82;
        private System.Data.DataColumn dataColumn105;
        private System.Data.DataColumn dataColumn106;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel cnpjtoolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel empresatoolStripStatusLabel;
        private System.Data.DataColumn dataColumn107;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODPEDIDONFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nFPEDIDONFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_SISTEMA_PEDIDO_NF;
        private System.Windows.Forms.TextBox tb_n_copias;
        private System.Windows.Forms.Label label83;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.RadioButton rb5124;
        private System.Windows.Forms.RadioButton rb5101;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Label label84;
        private System.Windows.Forms.TextBox tb_finalidade;
        private System.Windows.Forms.TextBox tb_informacoes_fisco;
        private System.Windows.Forms.Label label85;
        private System.Data.DataColumn dataColumn108;
        private System.Data.DataColumn dataColumn109;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Label label86;
        private System.Windows.Forms.TextBox tb_cl;
        private System.Data.DataColumn dataColumn110;
        private System.Data.DataColumn dataColumn111;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Data.DataColumn dataColumn112;
        private System.Data.DataColumn dataColumn37;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Data.DataColumn dataColumn113;
        private System.Data.DataColumn dataColumn114;
        private System.Data.DataColumn dataColumn115;
        private System.Data.DataColumn dataColumn116;
        private System.Data.DataColumn dataColumn117;
        private System.Data.DataColumn dataColumn118;
        private System.Data.DataColumn dataColumn120;
        private System.Data.DataColumn dataColumn121;
        private System.Data.DataColumn dataColumn119;
        private System.Data.DataColumn dataColumn122;
        private System.Data.DataColumn dataColumn123;
        private System.Data.DataColumn dataColumn124;
        private System.Data.DataColumn dataColumn125;
        private System.Data.DataColumn dataColumn126;
        private System.Data.DataColumn dataColumn127;
        private System.Data.DataColumn dataColumn128;
        private System.Data.DataColumn dataColumn129;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Label label88;
        private System.Windows.Forms.TextBox tb_aliquota_cbs;
        private System.Windows.Forms.Label label89;
        private System.Windows.Forms.TextBox tb_aliquota_ibs;
        private System.Windows.Forms.Label label90;
        private System.Windows.Forms.TextBox tb_classificacao_ibscbs;
        private System.Windows.Forms.Label label91;
        private System.Windows.Forms.TextBox tb_cst_ibscbs;
        private System.Windows.Forms.DataGridView dgvItens_nota;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod_op;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_unidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_qtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_preco_unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_preco_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nf;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ncm;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_valor_bc;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_icms;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_valor_icm;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ipi;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_valor_ipi;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_iss;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_valor_iss;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_icms_st;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_valor_bc_st;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_valor_st;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_iva;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_reducao;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_frete;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_desconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_seguro;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_outras_desp;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cofins;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_valor_cofins;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_pis;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_valor_pis;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_prestacao_servico;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_st;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_origem;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_mod_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_mod_bc_st;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_red_st;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_aliq_cred;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_valor_credito;
        private System.Windows.Forms.DataGridViewButtonColumn Trib;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tipo_servico;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_pedido_compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_item_pedido_compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ean;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_porc_trib;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tot_trib;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cest;
        private System.Windows.Forms.DataGridViewTextBoxColumn PORC_IPI_DEV_ITEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR_IPI_DEV_ITEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn IPI_TRIB_ITEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn IPI_N_TRIB_ITEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn CST_IPI_TRIB_ITEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn CST_IPI_N_TRIB_ITEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO_PIS_ITEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn CST_PIS_ITEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO_COFINS_ITEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn CST_COFINS_ITEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn BC_IPI_ITEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn BC_PIS_ITEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn BC_COFINS_ITEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn N_NF_ENT_ITEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn DI_ITEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA_DI_ITEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOCAL_DES_ITEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn UF_DES_ITEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA_DES_ITEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_EXP_ITEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn BC_II_ITEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR_II_ITEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESP_ADUANEIRAS_ITEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn IOF_II_ITEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn CST_IBSCBS_ITEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCLASSTRIB_ITEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ALIQ_IBS_ITEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ALIQ_CBS_ITEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR_IBS_ITEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR_CBS_ITEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn BC_IBSCBS_ITEM;
    }
}