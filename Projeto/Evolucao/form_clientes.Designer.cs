namespace Evolucao
{
    partial class form_clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_clientes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.label1 = new System.Windows.Forms.Label();
            this.codigo = new System.Windows.Forms.TextBox();
            this.dsClientes = new System.Data.DataSet();
            this.CLIENTES = new System.Data.DataTable();
            this.COD_CLIENTE = new System.Data.DataColumn();
            this.RAZAO_SOCIAL = new System.Data.DataColumn();
            this.NOME_FANTASIA = new System.Data.DataColumn();
            this.IE = new System.Data.DataColumn();
            this.IM = new System.Data.DataColumn();
            this.ENDERECO = new System.Data.DataColumn();
            this.BAIRRO = new System.Data.DataColumn();
            this.CIDADE = new System.Data.DataColumn();
            this.ESTADO = new System.Data.DataColumn();
            this.PAIS = new System.Data.DataColumn();
            this.FONE = new System.Data.DataColumn();
            this.EMAIL = new System.Data.DataColumn();
            this.CONTATO1 = new System.Data.DataColumn();
            this.FONE1 = new System.Data.DataColumn();
            this.EMAIL1 = new System.Data.DataColumn();
            this.CONTATO2 = new System.Data.DataColumn();
            this.FONE2 = new System.Data.DataColumn();
            this.EMAIL2 = new System.Data.DataColumn();
            this.CNPJ = new System.Data.DataColumn();
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
            this.dataColumn18 = new System.Data.DataColumn();
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
            this.dataColumn31 = new System.Data.DataColumn();
            this.dataColumn32 = new System.Data.DataColumn();
            this.dataColumn33 = new System.Data.DataColumn();
            this.dataColumn34 = new System.Data.DataColumn();
            this.dataColumn35 = new System.Data.DataColumn();
            this.dataColumn36 = new System.Data.DataColumn();
            this.dataColumn37 = new System.Data.DataColumn();
            this.dataColumn38 = new System.Data.DataColumn();
            this.dataColumn39 = new System.Data.DataColumn();
            this.dataColumn40 = new System.Data.DataColumn();
            this.dataColumn41 = new System.Data.DataColumn();
            this.dataColumn42 = new System.Data.DataColumn();
            this.dataColumn43 = new System.Data.DataColumn();
            this.dataColumn44 = new System.Data.DataColumn();
            this.dataColumn45 = new System.Data.DataColumn();
            this.dataColumn46 = new System.Data.DataColumn();
            this.dataColumn47 = new System.Data.DataColumn();
            this.dataColumn48 = new System.Data.DataColumn();
            this.razao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.novo_registro = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.salva_registro = new System.Windows.Forms.Button();
            this.apaga_registro = new System.Windows.Forms.Button();
            this.labelNome = new System.Windows.Forms.Label();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.datClientes = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand7 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand5 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand6 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommandBuilder1 = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.dsContatos = new System.Data.DataSet();
            this.CONTATOS = new System.Data.DataTable();
            this.COD_CONTATO = new System.Data.DataColumn();
            this.NOME_CONTATO = new System.Data.DataColumn();
            this.EMAIL_CONTATO = new System.Data.DataColumn();
            this.TEL_1_CONTATO = new System.Data.DataColumn();
            this.TEL_2_CONTATO = new System.Data.DataColumn();
            this.CLIENTE_FORN_CONTATO = new System.Data.DataColumn();
            this.COD_CLIENTE_FORN_CONTATO = new System.Data.DataColumn();
            this.TIPO_CONTATO = new System.Data.DataColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.datContatos = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand10 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand8 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand9 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label37 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.label47 = new System.Windows.Forms.Label();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.label48 = new System.Windows.Forms.Label();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.textBox29 = new System.Windows.Forms.TextBox();
            this.label50 = new System.Windows.Forms.Label();
            this.textBox30 = new System.Windows.Forms.TextBox();
            this.label51 = new System.Windows.Forms.Label();
            this.textBox31 = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.textBox32 = new System.Windows.Forms.TextBox();
            this.label53 = new System.Windows.Forms.Label();
            this.textBox33 = new System.Windows.Forms.TextBox();
            this.label54 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label55 = new System.Windows.Forms.Label();
            this.textBox34 = new System.Windows.Forms.TextBox();
            this.label56 = new System.Windows.Forms.Label();
            this.textBox35 = new System.Windows.Forms.TextBox();
            this.label57 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.textBox36 = new System.Windows.Forms.TextBox();
            this.textBox37 = new System.Windows.Forms.TextBox();
            this.label59 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.textBox38 = new System.Windows.Forms.TextBox();
            this.textBox39 = new System.Windows.Forms.TextBox();
            this.textBox40 = new System.Windows.Forms.TextBox();
            this.textBox41 = new System.Windows.Forms.TextBox();
            this.textBox42 = new System.Windows.Forms.TextBox();
            this.textBox43 = new System.Windows.Forms.TextBox();
            this.textBox44 = new System.Windows.Forms.TextBox();
            this.dsVendedores = new System.Data.DataSet();
            this.VENDEDORES_CLIENTE = new System.Data.DataTable();
            this.COD_VC = new System.Data.DataColumn();
            this.COD_CLIENTE_VC = new System.Data.DataColumn();
            this.COD_VENDEDOR_VC = new System.Data.DataColumn();
            this.NOME_VENDEDOR_VC = new System.Data.DataColumn();
            this.dsItens_tp = new System.Data.DataSet();
            this.ITENS_TP = new System.Data.DataTable();
            this.COD_ITEM_TP = new System.Data.DataColumn();
            this.COD_TABELA_ITEM_TP = new System.Data.DataColumn();
            this.COD_PRODUTO_ITEM_TP = new System.Data.DataColumn();
            this.DESCRICAO_PRODUTO_ITEM_TP = new System.Data.DataColumn();
            this.PRECO_PRODUTO_ITEM_TP = new System.Data.DataColumn();
            this.PRECO_MINIMO_ITEM_TP = new System.Data.DataColumn();
            this.dsItemPedAntigo = new System.Data.DataSet();
            this.ITEMPED = new System.Data.DataTable();
            this.PEDPROD = new System.Data.DataColumn();
            this.DESCRICAO_PROD = new System.Data.DataColumn();
            this.PEDVLUNI = new System.Data.DataColumn();
            this.PC_CLI = new System.Data.DataColumn();
            this.RAZAO_CLI = new System.Data.DataColumn();
            this.PC_EMISSAO = new System.Data.DataColumn();
            this.PC_NRPED = new System.Data.DataColumn();
            this.QT_VEND = new System.Data.DataColumn();
            this.VL_TOTAL = new System.Data.DataColumn();
            this.FP_DESCR = new System.Data.DataColumn();
            this.dsPedidos_venda = new System.Data.DataSet();
            this.PEDIDOS_VENDA = new System.Data.DataTable();
            this.COD_PED_VENDA = new System.Data.DataColumn();
            this.N_PED_VENDA = new System.Data.DataColumn();
            this.DATA_PED_VENDA = new System.Data.DataColumn();
            this.DATA_BAIXA_PED_VENDA = new System.Data.DataColumn();
            this.CLIENTE_PED_VENDA = new System.Data.DataColumn();
            this.CNPJ_PED_VENDA = new System.Data.DataColumn();
            this.COND_PGTO_PED_VENDA = new System.Data.DataColumn();
            this.VALOR_TOTAL_PROD_PED_VENDA = new System.Data.DataColumn();
            this.VALOR_TOTAL_PED_VENDA = new System.Data.DataColumn();
            this.VALOR_TOTAL_ICMS_PED_VENDA = new System.Data.DataColumn();
            this.VALOR_TOTAL_IPI_PED_VENDA = new System.Data.DataColumn();
            this.VALOR_DESCONTO_PED_VENDA = new System.Data.DataColumn();
            this.OBS_PED_VENDA = new System.Data.DataColumn();
            this.NF_PED_VENDA = new System.Data.DataColumn();
            this.BAIXADO_ESTOQUE_PED_VENDA = new System.Data.DataColumn();
            this.PAGO_PED_VENDA = new System.Data.DataColumn();
            this.COD_CAIXA_PGTO_PED_VENDA = new System.Data.DataColumn();
            this.VENDEDOR_PED_VENDA = new System.Data.DataColumn();
            this.COD_VENDEDOR_PED_VENDA = new System.Data.DataColumn();
            this.CANCELADO_PED_VENDA = new System.Data.DataColumn();
            this.NOME_CONTATO_PED_VENDA = new System.Data.DataColumn();
            this.TELEFONE_CONTATO_PED_VENDA = new System.Data.DataColumn();
            this.EMAIL_CONTATO_PED_VENDA = new System.Data.DataColumn();
            this.PORC_DESCONTO_PED_VENDA = new System.Data.DataColumn();
            this.N_NF_PED_VENDA = new System.Data.DataColumn();
            this.ID_PEDIDO_CEL_PED_VENDA = new System.Data.DataColumn();
            this.IMPRESSO_PED_VENDA = new System.Data.DataColumn();
            this.DATA_ENTREGA_PED_VENDA = new System.Data.DataColumn();
            this.QTDE_ITENS_PED_VENDA = new System.Data.DataColumn();
            this.TROCA_PED_VENDA = new System.Data.DataColumn();
            this.BONIFICACAO_PED_VENDA = new System.Data.DataColumn();
            this.SAIDA_VENDA_DIRETA_PED_VENDA = new System.Data.DataColumn();
            this.VENDA_DIRETA_PED_VENDA = new System.Data.DataColumn();
            this.NF_ENTRADA_PED_VENDA = new System.Data.DataColumn();
            this.COD_PEDIDO_PAI_PED_VENDA = new System.Data.DataColumn();
            this.ORCAMENTO_PED_VENDA = new System.Data.DataColumn();
            this.COD_LRW_PED_VENDA = new System.Data.DataColumn();
            this.COD_CAIXA_PED_VENDA = new System.Data.DataColumn();
            this.DATA_NF_PED_VENDA = new System.Data.DataColumn();
            this.QTDE_TOTAL_PED_VENDA = new System.Data.DataColumn();
            this.DATA_EXPORTACAO_PED_VENDA = new System.Data.DataColumn();
            this.HORA_EXPORTACAO_PED_VENDA = new System.Data.DataColumn();
            this.DEGUSTACAO_PED_VENDA = new System.Data.DataColumn();
            this.DEVOLUCAO_PED_VENDA = new System.Data.DataColumn();
            this.PV_PED_VENDA = new System.Data.DataColumn();
            this.COD_TP_PED_VENDA = new System.Data.DataColumn();
            this.DESCRICAO_TP_PED_VENDA = new System.Data.DataColumn();
            this.TRANSPORTADORA_PED_VENDA = new System.Data.DataColumn();
            this.PLACA_TRANSP_PED_VENDA = new System.Data.DataColumn();
            this.CNPJ_EMISSOR_PED_VENDA = new System.Data.DataColumn();
            this.RAZAO_EMISSOR_PED_VENDA = new System.Data.DataColumn();
            this.VALOR_ST_PED_VENDA = new System.Data.DataColumn();
            this.VALOR_TOTAL_DESEJADO_PED_VENDA = new System.Data.DataColumn();
            this.PERC_DESEJADO_PED_VENDA = new System.Data.DataColumn();
            this.label73 = new System.Windows.Forms.Label();
            this.datClassificacaoClientes = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand14 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand12 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand11 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand13 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsClassificacaoClientes = new System.Data.DataSet();
            this.CLASSIFICACAO_CLIENTES = new System.Data.DataTable();
            this.COD = new System.Data.DataColumn();
            this.DESCRICAO = new System.Data.DataColumn();
            this.datFormaPagamento = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand18 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand16 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand15 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand17 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsFormaPagamento = new System.Data.DataSet();
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
            this.fbCommand20 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand21 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand22 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.cbVendedores = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.datVendedores = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand25 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand23 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand19 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand24 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.cbxAtivoCliente = new System.Windows.Forms.CheckBox();
            this.cbContatos = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.dgvContas = new System.Windows.Forms.DataGridView();
            this.cODCRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAPREVISTACRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRICAOCRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nFCRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATARECEBIMENTOCRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODCLIENTECRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAZAOCLIENTECRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dUPLICATACRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rECEBIDOCRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODCAIXACRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pLANOCRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cARTEIRACRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODPLANOCRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORATUALIZADOCRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRICAOCCCRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oBSERVACOESCRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCCRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEMESSACRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATACRIACAOCRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rOMANEIOCRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAVENCORIGINALCRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsContas = new System.Data.DataSet();
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
            this.PLANO_CR = new System.Data.DataColumn();
            this.CARTEIRA_CR = new System.Data.DataColumn();
            this.COD_PLANO_CR = new System.Data.DataColumn();
            this.VALOR_ATUALIZADO_CR = new System.Data.DataColumn();
            this.DESCRICAO_CC_CR = new System.Data.DataColumn();
            this.OBSERVACOES_CR = new System.Data.DataColumn();
            this.CC_CR = new System.Data.DataColumn();
            this.REMESSA_CR = new System.Data.DataColumn();
            this.DATA_CRIACAO_CR = new System.Data.DataColumn();
            this.ROMANEIO_CR = new System.Data.DataColumn();
            this.DATA_VENC_ORIGINAL_CR = new System.Data.DataColumn();
            this.label79 = new System.Windows.Forms.Label();
            this.datContas = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand29 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand27 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand26 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand28 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.label80 = new System.Windows.Forms.Label();
            this.tb_total = new System.Windows.Forms.TextBox();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.label85 = new System.Windows.Forms.Label();
            this.datItens_tp = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand33 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand31 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand30 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand32 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.cbItens_tp = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.fbCommand34 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand35 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand36 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand37 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand38 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand39 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand40 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand41 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.datItemPedAntigo = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand45 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand43 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand42 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand44 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.panelContasaReceber = new System.Windows.Forms.Panel();
            this.datPedidos_venda = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand49 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand47 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand46 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand48 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvValor_cliente = new System.Windows.Forms.DataGridView();
            this.oPERACAOVOCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SEQUENCIA_OPER_VOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORHORAVOCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR_HORA_MOLDE_VOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR_HORA_PECA_VOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNPJCLIENTEVOCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsValor_operacao_cliente = new System.Data.DataSet();
            this.VALOR_OPERACAO_CLIENTE = new System.Data.DataTable();
            this.COD_VOC = new System.Data.DataColumn();
            this.OPERACAO_VOC = new System.Data.DataColumn();
            this.VALOR_HORA_VOC = new System.Data.DataColumn();
            this.CNPJ_CLIENTE_VOC = new System.Data.DataColumn();
            this.dataColumn49 = new System.Data.DataColumn();
            this.dataColumn50 = new System.Data.DataColumn();
            this.dataColumn51 = new System.Data.DataColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox52 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox53 = new System.Windows.Forms.TextBox();
            this.label89 = new System.Windows.Forms.Label();
            this.textBox54 = new System.Windows.Forms.TextBox();
            this.label90 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvPedidos_venda = new System.Windows.Forms.DataGridView();
            this.bAIXADOESTOQUEPEDVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.rAZAOEMISSORPEDVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cod_interno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nPEDVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAPEDVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATABAIXAPEDVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONDPGTOPEDVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORTOTALPRODPEDVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORTOTALPEDVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oBSPEDVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vENDEDORPEDVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageVendas = new System.Windows.Forms.TabPage();
            this.label88 = new System.Windows.Forms.Label();
            this.label87 = new System.Windows.Forms.Label();
            this.label86 = new System.Windows.Forms.Label();
            this.tbFormaPgto = new System.Windows.Forms.TextBox();
            this.tbNPedido = new System.Windows.Forms.TextBox();
            this.tbDescricaoProduto = new System.Windows.Forms.TextBox();
            this.dgvItemPedAntigo = new System.Windows.Forms.DataGridView();
            this.pCNRPEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pCEMISSAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fPDESCRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pEDPRODDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRICAOPRODDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pEDVLUNIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qTVENDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pCCLIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAZAOCLIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vLTOTALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageTabelaPrecos = new System.Windows.Forms.TabPage();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.dgvItens_tp = new System.Windows.Forms.DataGridView();
            this.cODITEMTPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODTABELAITEMTPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODPRODUTOITEMTPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRICAOPRODUTOITEMTPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRECOPRODUTOITEMTPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRECOMINIMOITEMTPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button9 = new System.Windows.Forms.Button();
            this.tabPageOutros = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb_fim_entrega = new System.Windows.Forms.TextBox();
            this.label83 = new System.Windows.Forms.Label();
            this.tb_inicio_entrega = new System.Windows.Forms.TextBox();
            this.label84 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textBox51 = new System.Windows.Forms.TextBox();
            this.tb_dia_visita = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.label82 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.label74 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.cbxClassificacao1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.dgvVendedoresCliente = new System.Windows.Forms.DataGridView();
            this.cODVCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODCLIENTEVCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODVENDEDORVCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMEVENDEDORVCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInserirVendedor = new System.Windows.Forms.Button();
            this.txtNomeVendedor = new System.Windows.Forms.TextBox();
            this.txtCodVendedor = new System.Windows.Forms.TextBox();
            this.cbxFormaPagamento = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tabPageDadosAdicionais = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.label75 = new System.Windows.Forms.Label();
            this.tb_nome_tabela_preco = new System.Windows.Forms.TextBox();
            this.label76 = new System.Windows.Forms.Label();
            this.tb_cod_tabela = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label72 = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.textBox50 = new System.Windows.Forms.TextBox();
            this.textBox49 = new System.Windows.Forms.TextBox();
            this.textBox48 = new System.Windows.Forms.TextBox();
            this.textBox47 = new System.Windows.Forms.TextBox();
            this.textBox46 = new System.Windows.Forms.TextBox();
            this.textBox45 = new System.Windows.Forms.TextBox();
            this.tb_cobranca = new System.Windows.Forms.TextBox();
            this.tb_entrega = new System.Windows.Forms.TextBox();
            this.tb_icm = new System.Windows.Forms.TextBox();
            this.tb_ipi = new System.Windows.Forms.TextBox();
            this.tb_class = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.tabPageDadosComuns = new System.Windows.Forms.TabPage();
            this.tb_obs = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.tb_cod_pais = new System.Windows.Forms.TextBox();
            this.tb_tipo = new System.Windows.Forms.TextBox();
            this.tb_telefone_2 = new System.Windows.Forms.TextBox();
            this.tb_cod_cidade = new System.Windows.Forms.TextBox();
            this.tb_telefone_1 = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_n = new System.Windows.Forms.TextBox();
            this.tb_nome_contato = new System.Windows.Forms.TextBox();
            this.tb_Cep = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.tb_fone = new System.Windows.Forms.TextBox();
            this.tb_pais = new System.Windows.Forms.TextBox();
            this.tb_estado = new System.Windows.Forms.TextBox();
            this.tb_cidade = new System.Windows.Forms.TextBox();
            this.tb_bairro = new System.Windows.Forms.TextBox();
            this.tb_logradouro = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tb_ie = new System.Windows.Forms.TextBox();
            this.tb_cnpj = new System.Windows.Forms.TextBox();
            this.label81 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.cb_pessoa_fisica = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.dgvContatos = new System.Windows.Forms.DataGridView();
            this.cODCONTATODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMECONTATODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILCONTATODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tEL1CONTATODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tEL2CONTATODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTEFORNCONTATODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label24 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.datValor_operacao_cliente = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.cbValor_operacao_cliente = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.dgvPagamentos_caract = new System.Windows.Forms.DataGridView();
            this.cbTipo_pgto = new System.Windows.Forms.ComboBox();
            this.label91 = new System.Windows.Forms.Label();
            this.label92 = new System.Windows.Forms.Label();
            this.tb_n_pgto = new System.Windows.Forms.TextBox();
            this.label93 = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.datPagamentos_caract = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand50 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand51 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand52 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand53 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsPagamentos_caract = new System.Data.DataSet();
            this.PAGAMENTOS_CARACT = new System.Data.DataTable();
            this.COD_PC = new System.Data.DataColumn();
            this.CNPJ_CLIENTE_PC = new System.Data.DataColumn();
            this.NUMERO_PC = new System.Data.DataColumn();
            this.TIPO_PC = new System.Data.DataColumn();
            this.cODPCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNPJCLIENTEPCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nUMEROPCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIPOPCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dsClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CLIENTES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsContatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CONTATOS)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsVendedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VENDEDORES_CLIENTE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsItens_tp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITENS_TP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsItemPedAntigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITEMPED)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPedidos_venda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PEDIDOS_VENDA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsClassificacaoClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CLASSIFICACAO_CLIENTES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFormaPagamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FORMA_PGTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsContas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CONTAS_A_RECEBER)).BeginInit();
            this.panelContasaReceber.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvValor_cliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsValor_operacao_cliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VALOR_OPERACAO_CLIENTE)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos_venda)).BeginInit();
            this.tabPageVendas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemPedAntigo)).BeginInit();
            this.tabPageTabelaPrecos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens_tp)).BeginInit();
            this.tabPageOutros.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendedoresCliente)).BeginInit();
            this.tabPageDadosAdicionais.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPageDadosComuns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContatos)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagamentos_caract)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPagamentos_caract)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PAGAMENTOS_CARACT)).BeginInit();
            this.SuspendLayout();
            // 
            // fbCommand4
            // 
            this.fbCommand4.CommandText = "DELETE FROM \"CLIENTES\" WHERE ((\"COD_CLIENTE\" = @p1))";
            this.fbCommand4.CommandTimeout = 30;
            this.fbCommand4.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p1", FirebirdSql.Data.FirebirdClient.FbDbType.Integer, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "COD_CLIENTE", System.Data.DataRowVersion.Original, null));
            // 
            // fbCommand2
            // 
            this.fbCommand2.CommandText = resources.GetString("fbCommand2.CommandText");
            this.fbCommand2.CommandTimeout = 30;
            this.fbCommand2.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p1", FirebirdSql.Data.FirebirdClient.FbDbType.Integer, 4, "COD_CLIENTE"));
            this.fbCommand2.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p2", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 50, "RAZAO_SOCIAL"));
            this.fbCommand2.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p3", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 50, "NOME_FANTASIA"));
            this.fbCommand2.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p4", FirebirdSql.Data.FirebirdClient.FbDbType.Char, 18, "CNPJ"));
            this.fbCommand2.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p5", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 20, "IE"));
            this.fbCommand2.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p6", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 20, "IM"));
            this.fbCommand2.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p7", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 50, "ENDERECO"));
            this.fbCommand2.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p8", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 30, "BAIRRO"));
            this.fbCommand2.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p9", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 35, "CIDADE"));
            this.fbCommand2.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p10", FirebirdSql.Data.FirebirdClient.FbDbType.Char, 2, "ESTADO"));
            this.fbCommand2.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p11", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 20, "PAIS"));
            this.fbCommand2.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p12", FirebirdSql.Data.FirebirdClient.FbDbType.Char, 14, "FONE"));
            this.fbCommand2.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p13", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 30, "EMAIL"));
            this.fbCommand2.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p14", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 40, "CONTATO1"));
            this.fbCommand2.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p15", FirebirdSql.Data.FirebirdClient.FbDbType.Char, 14, "FONE1"));
            this.fbCommand2.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p16", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 30, "EMAIL1"));
            this.fbCommand2.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p17", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 40, "CONTATO2"));
            this.fbCommand2.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p18", FirebirdSql.Data.FirebirdClient.FbDbType.Char, 14, "FONE2"));
            this.fbCommand2.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p19", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 30, "EMAIL2"));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // codigo
            // 
            this.codigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.COD_CLIENTE", true));
            this.codigo.Location = new System.Drawing.Point(164, 55);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(52, 20);
            this.codigo.TabIndex = 30;
            this.codigo.TextChanged += new System.EventHandler(this.codigo_TextChanged);
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
            this.IM,
            this.ENDERECO,
            this.BAIRRO,
            this.CIDADE,
            this.ESTADO,
            this.PAIS,
            this.FONE,
            this.EMAIL,
            this.CONTATO1,
            this.FONE1,
            this.EMAIL1,
            this.CONTATO2,
            this.FONE2,
            this.EMAIL2,
            this.CNPJ,
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
            this.dataColumn18,
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
            this.dataColumn31,
            this.dataColumn32,
            this.dataColumn33,
            this.dataColumn34,
            this.dataColumn35,
            this.dataColumn36,
            this.dataColumn37,
            this.dataColumn38,
            this.dataColumn39,
            this.dataColumn40,
            this.dataColumn41,
            this.dataColumn42,
            this.dataColumn43,
            this.dataColumn44,
            this.dataColumn45,
            this.dataColumn46,
            this.dataColumn47,
            this.dataColumn48});
            this.CLIENTES.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "CNPJ"}, true)});
            this.CLIENTES.PrimaryKey = new System.Data.DataColumn[] {
        this.CNPJ};
            this.CLIENTES.TableName = "CLIENTES";
            // 
            // COD_CLIENTE
            // 
            this.COD_CLIENTE.AutoIncrement = true;
            this.COD_CLIENTE.ColumnName = "COD_CLIENTE";
            this.COD_CLIENTE.DataType = typeof(int);
            // 
            // RAZAO_SOCIAL
            // 
            this.RAZAO_SOCIAL.AllowDBNull = false;
            this.RAZAO_SOCIAL.ColumnName = "RAZAO_SOCIAL";
            this.RAZAO_SOCIAL.MaxLength = 200;
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
            this.BAIRRO.MaxLength = 100;
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
            // FONE
            // 
            this.FONE.ColumnName = "FONE";
            this.FONE.MaxLength = 100;
            // 
            // EMAIL
            // 
            this.EMAIL.ColumnName = "EMAIL";
            this.EMAIL.MaxLength = 80;
            // 
            // CONTATO1
            // 
            this.CONTATO1.ColumnName = "CONTATO1";
            this.CONTATO1.MaxLength = 100;
            // 
            // FONE1
            // 
            this.FONE1.ColumnName = "FONE1";
            this.FONE1.MaxLength = 14;
            // 
            // EMAIL1
            // 
            this.EMAIL1.ColumnName = "EMAIL1";
            this.EMAIL1.MaxLength = 80;
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
            this.EMAIL2.MaxLength = 80;
            // 
            // CNPJ
            // 
            this.CNPJ.AllowDBNull = false;
            this.CNPJ.ColumnName = "CNPJ";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "CLASS_FISCAL_CLIENTE";
            this.dataColumn1.MaxLength = 50;
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "ISENCAO_ICM_CLIENTE";
            this.dataColumn2.MaxLength = 250;
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "ISENCAO_IPI_CLIENTE";
            this.dataColumn3.MaxLength = 250;
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "CEP_CLIENTE";
            this.dataColumn4.MaxLength = 18;
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "ENDERECO_COBRANCA_CLIENTE";
            this.dataColumn5.MaxLength = 80;
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "ENDERECO_ENTREGA_CLIENTE";
            this.dataColumn6.MaxLength = 80;
            // 
            // dataColumn7
            // 
            this.dataColumn7.ColumnName = "COD_CIDADE_CLIENTE";
            this.dataColumn7.MaxLength = 10;
            // 
            // dataColumn8
            // 
            this.dataColumn8.ColumnName = "COD_PAIS_CLIENTE";
            this.dataColumn8.MaxLength = 10;
            // 
            // dataColumn9
            // 
            this.dataColumn9.ColumnName = "NUMERO_CLIENTE";
            this.dataColumn9.MaxLength = 20;
            // 
            // dataColumn10
            // 
            this.dataColumn10.ColumnName = "PESSOA_FISICA_CLIENTE";
            this.dataColumn10.DataType = typeof(int);
            // 
            // dataColumn11
            // 
            this.dataColumn11.ColumnName = "VALOR_FRESA_CLIENTE";
            this.dataColumn11.DataType = typeof(double);
            // 
            // dataColumn12
            // 
            this.dataColumn12.ColumnName = "VALOR_RETIFICA_CLIENTE";
            this.dataColumn12.DataType = typeof(double);
            // 
            // dataColumn13
            // 
            this.dataColumn13.ColumnName = "VALOR_RETIFICA_OPTICA_CLIENTE";
            this.dataColumn13.DataType = typeof(double);
            // 
            // dataColumn14
            // 
            this.dataColumn14.ColumnName = "VALOR_EDM_CLIENTE";
            this.dataColumn14.DataType = typeof(double);
            // 
            // dataColumn15
            // 
            this.dataColumn15.ColumnName = "VALOR_TORNO_CLIENTE";
            this.dataColumn15.DataType = typeof(double);
            // 
            // dataColumn16
            // 
            this.dataColumn16.ColumnName = "VALOR_EWC_CLIENTE";
            this.dataColumn16.DataType = typeof(double);
            // 
            // dataColumn17
            // 
            this.dataColumn17.ColumnName = "VALOR_EWC015_CLIENTE";
            this.dataColumn17.DataType = typeof(double);
            // 
            // dataColumn18
            // 
            this.dataColumn18.ColumnName = "VALOR_CNC_CLIENTE";
            this.dataColumn18.DataType = typeof(double);
            // 
            // dataColumn19
            // 
            this.dataColumn19.ColumnName = "VALOR_BANCADA_CLIENTE";
            this.dataColumn19.DataType = typeof(double);
            // 
            // dataColumn20
            // 
            this.dataColumn20.ColumnName = "PORC_BENEFICIAMENTO_CLIENTE";
            this.dataColumn20.DataType = typeof(double);
            // 
            // dataColumn21
            // 
            this.dataColumn21.ColumnName = "PORC_VENDA_CLIENTE";
            this.dataColumn21.DataType = typeof(double);
            // 
            // dataColumn22
            // 
            this.dataColumn22.ColumnName = "PORC_PRESTACAO_SERV_CLIENTE";
            // 
            // dataColumn23
            // 
            this.dataColumn23.ColumnName = "PORC_RETRABALHO_CLIENTE";
            this.dataColumn23.DataType = typeof(double);
            // 
            // dataColumn24
            // 
            this.dataColumn24.ColumnName = "ICMS_CLIENTE";
            this.dataColumn24.DataType = typeof(double);
            // 
            // dataColumn25
            // 
            this.dataColumn25.ColumnName = "REDUCAO_CLIENTE";
            this.dataColumn25.DataType = typeof(double);
            // 
            // dataColumn26
            // 
            this.dataColumn26.ColumnName = "ICMS_ST_CLIENTE";
            this.dataColumn26.DataType = typeof(double);
            // 
            // dataColumn27
            // 
            this.dataColumn27.ColumnName = "IVA_CLIENTE";
            this.dataColumn27.DataType = typeof(double);
            // 
            // dataColumn28
            // 
            this.dataColumn28.ColumnName = "PIS_CLIENTE";
            this.dataColumn28.DataType = typeof(double);
            // 
            // dataColumn29
            // 
            this.dataColumn29.ColumnName = "COFINS_CLIENTE";
            this.dataColumn29.DataType = typeof(double);
            // 
            // dataColumn30
            // 
            this.dataColumn30.ColumnName = "IPI_CLIENTE";
            this.dataColumn30.DataType = typeof(double);
            // 
            // dataColumn31
            // 
            this.dataColumn31.ColumnName = "REDUCAO_ST_CLIENTE";
            this.dataColumn31.DataType = typeof(double);
            // 
            // dataColumn32
            // 
            this.dataColumn32.ColumnName = "COMPLEMENTO_CLIENTE";
            this.dataColumn32.MaxLength = 100;
            // 
            // dataColumn33
            // 
            this.dataColumn33.ColumnName = "CLASSIFICACAO_CLIENTES";
            this.dataColumn33.MaxLength = 200;
            // 
            // dataColumn34
            // 
            this.dataColumn34.ColumnName = "FORMA_PAGAMENTO_CLIENTE";
            this.dataColumn34.DataType = typeof(int);
            // 
            // dataColumn35
            // 
            this.dataColumn35.ColumnName = "ATIVO_CLIENTE";
            this.dataColumn35.DataType = typeof(int);
            // 
            // dataColumn36
            // 
            this.dataColumn36.ColumnName = "DESCONTO_PONTUALIDADE_CLIENTE";
            this.dataColumn36.DataType = typeof(double);
            // 
            // dataColumn37
            // 
            this.dataColumn37.ColumnName = "DIA_VISITA_CLIENTE";
            this.dataColumn37.MaxLength = 3;
            // 
            // dataColumn38
            // 
            this.dataColumn38.ColumnName = "COD_TP_CLIENTE";
            this.dataColumn38.DataType = typeof(int);
            // 
            // dataColumn39
            // 
            this.dataColumn39.ColumnName = "DESCRICAO_TP_CLIENTE";
            this.dataColumn39.MaxLength = 100;
            // 
            // dataColumn40
            // 
            this.dataColumn40.ColumnName = "LIMITE_CREDITO_CLIENTE";
            this.dataColumn40.DataType = typeof(double);
            // 
            // dataColumn41
            // 
            this.dataColumn41.ColumnName = "DIA_PAGAMENTO_CLIENTE";
            this.dataColumn41.DataType = typeof(int);
            // 
            // dataColumn42
            // 
            this.dataColumn42.ColumnName = "OBSERVACOES_CLIENTE";
            // 
            // dataColumn43
            // 
            this.dataColumn43.ColumnName = "COD_ROTEIRO_CLIENTE";
            this.dataColumn43.DataType = typeof(int);
            // 
            // dataColumn44
            // 
            this.dataColumn44.ColumnName = "DESCONTO_INSTRUCAO_CLIENTE";
            this.dataColumn44.DataType = typeof(int);
            // 
            // dataColumn45
            // 
            this.dataColumn45.ColumnName = "DESCONTO_VALOR_CLIENTE";
            this.dataColumn45.DataType = typeof(int);
            // 
            // dataColumn46
            // 
            this.dataColumn46.ColumnName = "INICIO_ENTREGA_CLIENTE";
            this.dataColumn46.DataType = typeof(System.DateTime);
            // 
            // dataColumn47
            // 
            this.dataColumn47.ColumnName = "FIM_ENTREGA_CLIENTE";
            this.dataColumn47.DataType = typeof(System.DateTime);
            // 
            // dataColumn48
            // 
            this.dataColumn48.ColumnName = "TIPO_CLIENTE";
            // 
            // razao
            // 
            this.razao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.RAZAO_SOCIAL", true));
            this.razao.Location = new System.Drawing.Point(109, 81);
            this.razao.Name = "razao";
            this.razao.Size = new System.Drawing.Size(265, 20);
            this.razao.TabIndex = 1;
            this.razao.DoubleClick += new System.EventHandler(this.razao_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Razão Social:";
            // 
            // nome
            // 
            this.nome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.NOME_FANTASIA", true));
            this.nome.Location = new System.Drawing.Point(478, 81);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(196, 20);
            this.nome.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(391, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nome Fantasia:";
            // 
            // novo_registro
            // 
            this.novo_registro.Location = new System.Drawing.Point(265, 468);
            this.novo_registro.Name = "novo_registro";
            this.novo_registro.Size = new System.Drawing.Size(49, 22);
            this.novo_registro.TabIndex = 31;
            this.novo_registro.Text = "Novo";
            this.novo_registro.UseVisualStyleBackColor = true;
            this.novo_registro.Click += new System.EventHandler(this.novo_registro_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(199, 468);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 22);
            this.button3.TabIndex = 32;
            this.button3.Text = "Localizar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // salva_registro
            // 
            this.salva_registro.Location = new System.Drawing.Point(375, 468);
            this.salva_registro.Name = "salva_registro";
            this.salva_registro.Size = new System.Drawing.Size(49, 22);
            this.salva_registro.TabIndex = 29;
            this.salva_registro.Text = "Salvar";
            this.salva_registro.UseVisualStyleBackColor = true;
            this.salva_registro.Click += new System.EventHandler(this.salva_registro_Click);
            // 
            // apaga_registro
            // 
            this.apaga_registro.Location = new System.Drawing.Point(320, 468);
            this.apaga_registro.Name = "apaga_registro";
            this.apaga_registro.Size = new System.Drawing.Size(49, 22);
            this.apaga_registro.TabIndex = 30;
            this.apaga_registro.Text = "Excluir";
            this.apaga_registro.UseVisualStyleBackColor = true;
            this.apaga_registro.Click += new System.EventHandler(this.apaga_registro_Click);
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelNome.Location = new System.Drawing.Point(12, 6);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(215, 46);
            this.labelNome.TabIndex = 48;
            this.labelNome.Text = "CLIENTES";
            this.labelNome.Click += new System.EventHandler(this.label20_Click);
            // 
            // fbConnection1
            // 
            this.fbConnection1.ConnectionString = resources.GetString("fbConnection1.ConnectionString");
            this.fbConnection1.InfoMessage += new FirebirdSql.Data.FirebirdClient.FbInfoMessageEventHandler(this.fbConnection1_InfoMessage_1);
            // 
            // datClientes
            // 
            this.datClientes.DeleteCommand = this.fbCommand7;
            this.datClientes.InsertCommand = this.fbCommand5;
            this.datClientes.SelectCommand = this.fbCommand3;
            this.datClientes.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Table", new System.Data.Common.DataColumnMapping[0])});
            this.datClientes.UpdateCommand = this.fbCommand6;
            // 
            // fbCommand7
            // 
            this.fbCommand7.CommandTimeout = 30;
            this.fbCommand7.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p1", FirebirdSql.Data.FirebirdClient.FbDbType.Integer, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "COD_CLIENTE", System.Data.DataRowVersion.Original, null));
            // 
            // fbCommand5
            // 
            this.fbCommand5.CommandTimeout = 30;
            this.fbCommand5.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p1", FirebirdSql.Data.FirebirdClient.FbDbType.Integer, 4, "COD_CLIENTE"));
            this.fbCommand5.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p2", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 50, "RAZAO_SOCIAL"));
            this.fbCommand5.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p3", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 50, "NOME_FANTASIA"));
            this.fbCommand5.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p4", FirebirdSql.Data.FirebirdClient.FbDbType.Char, 18, "CNPJ"));
            this.fbCommand5.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p5", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 20, "IE"));
            this.fbCommand5.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p6", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 20, "IM"));
            this.fbCommand5.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p7", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 50, "ENDERECO"));
            this.fbCommand5.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p8", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 30, "BAIRRO"));
            this.fbCommand5.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p9", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 35, "CIDADE"));
            this.fbCommand5.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p10", FirebirdSql.Data.FirebirdClient.FbDbType.Char, 2, "ESTADO"));
            this.fbCommand5.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p11", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 20, "PAIS"));
            this.fbCommand5.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p12", FirebirdSql.Data.FirebirdClient.FbDbType.Char, 14, "FONE"));
            this.fbCommand5.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p13", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 30, "EMAIL"));
            this.fbCommand5.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p14", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 40, "CONTATO1"));
            this.fbCommand5.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p15", FirebirdSql.Data.FirebirdClient.FbDbType.Char, 14, "FONE1"));
            this.fbCommand5.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p16", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 30, "EMAIL1"));
            this.fbCommand5.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p17", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 40, "CONTATO2"));
            this.fbCommand5.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p18", FirebirdSql.Data.FirebirdClient.FbDbType.Char, 14, "FONE2"));
            this.fbCommand5.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p19", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 30, "EMAIL2"));
            // 
            // fbCommand3
            // 
            this.fbCommand3.CommandText = "select * from clientes order by razao_social";
            this.fbCommand3.CommandTimeout = 30;
            this.fbCommand3.Connection = this.fbConnection1;
            // 
            // fbCommand6
            // 
            this.fbCommand6.CommandTimeout = 30;
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p1", FirebirdSql.Data.FirebirdClient.FbDbType.Integer, 4, "COD_CLIENTE"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p2", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 50, "RAZAO_SOCIAL"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p3", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 50, "NOME_FANTASIA"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p4", FirebirdSql.Data.FirebirdClient.FbDbType.Char, 18, "CNPJ"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p5", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 20, "IE"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p6", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 20, "IM"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p7", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 50, "ENDERECO"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p8", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 30, "BAIRRO"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p9", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 35, "CIDADE"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p10", FirebirdSql.Data.FirebirdClient.FbDbType.Char, 2, "ESTADO"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p11", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 20, "PAIS"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p12", FirebirdSql.Data.FirebirdClient.FbDbType.Char, 14, "FONE"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p13", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 30, "EMAIL"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p14", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 40, "CONTATO1"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p15", FirebirdSql.Data.FirebirdClient.FbDbType.Char, 14, "FONE1"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p16", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 30, "EMAIL1"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p17", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 40, "CONTATO2"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p18", FirebirdSql.Data.FirebirdClient.FbDbType.Char, 14, "FONE2"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p19", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 30, "EMAIL2"));
            this.fbCommand6.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p20", FirebirdSql.Data.FirebirdClient.FbDbType.Integer, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "COD_CLIENTE", System.Data.DataRowVersion.Original, null));
            // 
            // fbCommandBuilder1
            // 
            this.fbCommandBuilder1.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.fbCommandBuilder1.DataAdapter = this.datClientes;
            this.fbCommandBuilder1.QuotePrefix = "\"";
            this.fbCommandBuilder1.QuoteSuffix = "\"";
            // 
            // dsContatos
            // 
            this.dsContatos.DataSetName = "dsContatos";
            this.dsContatos.Namespace = "http://www.tempuri.org/dsContatos.xsd";
            this.dsContatos.Tables.AddRange(new System.Data.DataTable[] {
            this.CONTATOS});
            // 
            // CONTATOS
            // 
            this.CONTATOS.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_CONTATO,
            this.NOME_CONTATO,
            this.EMAIL_CONTATO,
            this.TEL_1_CONTATO,
            this.TEL_2_CONTATO,
            this.CLIENTE_FORN_CONTATO,
            this.COD_CLIENTE_FORN_CONTATO,
            this.TIPO_CONTATO});
            this.CONTATOS.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_CONTATO"}, true)});
            this.CONTATOS.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_CONTATO};
            this.CONTATOS.TableName = "CONTATOS";
            // 
            // COD_CONTATO
            // 
            this.COD_CONTATO.AllowDBNull = false;
            this.COD_CONTATO.ColumnName = "COD_CONTATO";
            this.COD_CONTATO.DataType = typeof(int);
            // 
            // NOME_CONTATO
            // 
            this.NOME_CONTATO.ColumnName = "NOME_CONTATO";
            this.NOME_CONTATO.MaxLength = 100;
            // 
            // EMAIL_CONTATO
            // 
            this.EMAIL_CONTATO.ColumnName = "EMAIL_CONTATO";
            this.EMAIL_CONTATO.MaxLength = 100;
            // 
            // TEL_1_CONTATO
            // 
            this.TEL_1_CONTATO.ColumnName = "TEL_1_CONTATO";
            this.TEL_1_CONTATO.MaxLength = 100;
            // 
            // TEL_2_CONTATO
            // 
            this.TEL_2_CONTATO.ColumnName = "TEL_2_CONTATO";
            this.TEL_2_CONTATO.MaxLength = 100;
            // 
            // CLIENTE_FORN_CONTATO
            // 
            this.CLIENTE_FORN_CONTATO.ColumnName = "CLIENTE_FORN_CONTATO";
            this.CLIENTE_FORN_CONTATO.MaxLength = 10;
            // 
            // COD_CLIENTE_FORN_CONTATO
            // 
            this.COD_CLIENTE_FORN_CONTATO.ColumnName = "COD_CLIENTE_FORN_CONTATO";
            this.COD_CLIENTE_FORN_CONTATO.DataType = typeof(int);
            // 
            // TIPO_CONTATO
            // 
            this.TIPO_CONTATO.ColumnName = "TIPO_CONTATO";
            this.TIPO_CONTATO.MaxLength = 30;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(430, 468);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 22);
            this.button1.TabIndex = 49;
            this.button1.Text = "Imprimir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // datContatos
            // 
            this.datContatos.DeleteCommand = this.fbCommand10;
            this.datContatos.InsertCommand = this.fbCommand8;
            this.datContatos.SelectCommand = this.fbCommand1;
            this.datContatos.UpdateCommand = this.fbCommand9;
            // 
            // fbCommand10
            // 
            this.fbCommand10.CommandTimeout = 30;
            // 
            // fbCommand8
            // 
            this.fbCommand8.CommandTimeout = 30;
            // 
            // fbCommand1
            // 
            this.fbCommand1.CommandText = "select * from contatos";
            this.fbCommand1.CommandTimeout = 30;
            this.fbCommand1.Connection = this.fbConnection1;
            // 
            // fbCommand9
            // 
            this.fbCommand9.CommandTimeout = 30;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label30);
            this.tabPage3.Controls.Add(this.label31);
            this.tabPage3.Controls.Add(this.label32);
            this.tabPage3.Controls.Add(this.label33);
            this.tabPage3.Controls.Add(this.label34);
            this.tabPage3.Controls.Add(this.label35);
            this.tabPage3.Controls.Add(this.label36);
            this.tabPage3.Controls.Add(this.checkBox1);
            this.tabPage3.Controls.Add(this.label37);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Controls.Add(this.label38);
            this.tabPage3.Controls.Add(this.textBox2);
            this.tabPage3.Controls.Add(this.label39);
            this.tabPage3.Controls.Add(this.textBox3);
            this.tabPage3.Controls.Add(this.label40);
            this.tabPage3.Controls.Add(this.textBox5);
            this.tabPage3.Controls.Add(this.label41);
            this.tabPage3.Controls.Add(this.textBox6);
            this.tabPage3.Controls.Add(this.textBox7);
            this.tabPage3.Controls.Add(this.textBox8);
            this.tabPage3.Controls.Add(this.textBox9);
            this.tabPage3.Controls.Add(this.textBox10);
            this.tabPage3.Controls.Add(this.textBox11);
            this.tabPage3.Controls.Add(this.textBox12);
            this.tabPage3.Controls.Add(this.textBox20);
            this.tabPage3.Controls.Add(this.label42);
            this.tabPage3.Controls.Add(this.textBox21);
            this.tabPage3.Controls.Add(this.label43);
            this.tabPage3.Controls.Add(this.textBox22);
            this.tabPage3.Controls.Add(this.label44);
            this.tabPage3.Controls.Add(this.textBox23);
            this.tabPage3.Controls.Add(this.label45);
            this.tabPage3.Controls.Add(this.textBox24);
            this.tabPage3.Controls.Add(this.label46);
            this.tabPage3.Controls.Add(this.textBox25);
            this.tabPage3.Controls.Add(this.label47);
            this.tabPage3.Controls.Add(this.textBox26);
            this.tabPage3.Controls.Add(this.label48);
            this.tabPage3.Controls.Add(this.textBox27);
            this.tabPage3.Controls.Add(this.label49);
            this.tabPage3.Controls.Add(this.textBox28);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(668, 168);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Dados Comuns";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.ForeColor = System.Drawing.Color.Green;
            this.label30.Location = new System.Drawing.Point(4, 142);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(64, 26);
            this.label30.TabIndex = 87;
            this.label30.Text = "Contato 2\r\nOrcamentos\r\n";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.ForeColor = System.Drawing.Color.Green;
            this.label31.Location = new System.Drawing.Point(443, 144);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(44, 13);
            this.label31.TabIndex = 86;
            this.label31.Text = "Email 2:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.ForeColor = System.Drawing.Color.Green;
            this.label32.Location = new System.Drawing.Point(224, 144);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(43, 13);
            this.label32.TabIndex = 85;
            this.label32.Text = "Fone 2:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label33.Location = new System.Drawing.Point(5, 110);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(56, 26);
            this.label33.TabIndex = 84;
            this.label33.Text = "Contato 1 \r\nCompras";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label34.Location = new System.Drawing.Point(443, 118);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(44, 13);
            this.label34.TabIndex = 83;
            this.label34.Text = "Email 1:";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label35.Location = new System.Drawing.Point(224, 118);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(43, 13);
            this.label35.TabIndex = 82;
            this.label35.Text = "Fone 1:";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(224, 85);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(32, 26);
            this.label36.TabIndex = 81;
            this.label36.Text = "Email\r\nNfe";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsClientes, "CLIENTES.PESSOA_FISICA_CLIENTE", true));
            this.checkBox1.Location = new System.Drawing.Point(551, 7);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(93, 17);
            this.checkBox1.TabIndex = 80;
            this.checkBox1.Text = "Pessoa Física";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(6, 11);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(62, 13);
            this.label37.TabIndex = 79;
            this.label37.Text = "CNPJ/CPF:";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.COD_PAIS_CLIENTE", true));
            this.textBox1.Location = new System.Drawing.Point(628, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(37, 20);
            this.textBox1.TabIndex = 17;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(565, 89);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(57, 13);
            this.label38.TabIndex = 78;
            this.label38.Text = "Cód. País:";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.COD_CIDADE_CLIENTE", true));
            this.textBox2.Location = new System.Drawing.Point(513, 86);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(46, 20);
            this.textBox2.TabIndex = 16;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(443, 89);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(68, 13);
            this.label39.TabIndex = 76;
            this.label39.Text = "Cód. Cidade:";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.NUMERO_CLIENTE", true));
            this.textBox3.Location = new System.Drawing.Point(427, 34);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(70, 20);
            this.textBox3.TabIndex = 8;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(397, 37);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(22, 13);
            this.label40.TabIndex = 74;
            this.label40.Text = "Nº:";
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.CEP_CLIENTE", true));
            this.textBox5.Location = new System.Drawing.Point(410, 60);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(87, 20);
            this.textBox5.TabIndex = 12;
            this.textBox5.Text = "00000-000";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(361, 63);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(31, 13);
            this.label41.TabIndex = 72;
            this.label41.Text = "CEP:";
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.CONTATO2", true));
            this.textBox6.Location = new System.Drawing.Point(94, 141);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(114, 20);
            this.textBox6.TabIndex = 21;
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.EMAIL2", true));
            this.textBox7.Location = new System.Drawing.Point(492, 141);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(172, 20);
            this.textBox7.TabIndex = 23;
            // 
            // textBox8
            // 
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.FONE2", true));
            this.textBox8.Location = new System.Drawing.Point(314, 141);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(113, 20);
            this.textBox8.TabIndex = 22;
            // 
            // textBox9
            // 
            this.textBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.CONTATO1", true));
            this.textBox9.Location = new System.Drawing.Point(95, 112);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(113, 20);
            this.textBox9.TabIndex = 18;
            // 
            // textBox10
            // 
            this.textBox10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.EMAIL1", true));
            this.textBox10.Location = new System.Drawing.Point(492, 115);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(172, 20);
            this.textBox10.TabIndex = 20;
            // 
            // textBox11
            // 
            this.textBox11.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.FONE1", true));
            this.textBox11.Location = new System.Drawing.Point(314, 115);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(113, 20);
            this.textBox11.TabIndex = 19;
            // 
            // textBox12
            // 
            this.textBox12.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.EMAIL", true));
            this.textBox12.Location = new System.Drawing.Point(265, 86);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(162, 20);
            this.textBox12.TabIndex = 15;
            // 
            // textBox20
            // 
            this.textBox20.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.FONE", true));
            this.textBox20.Location = new System.Drawing.Point(95, 86);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(113, 20);
            this.textBox20.TabIndex = 14;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(5, 89);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(34, 13);
            this.label42.TabIndex = 63;
            this.label42.Text = "Fone:";
            // 
            // textBox21
            // 
            this.textBox21.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.PAIS", true));
            this.textBox21.Location = new System.Drawing.Point(551, 60);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(114, 20);
            this.textBox21.TabIndex = 13;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(503, 63);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(32, 13);
            this.label43.TabIndex = 62;
            this.label43.Text = "País:";
            // 
            // textBox22
            // 
            this.textBox22.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.ESTADO", true));
            this.textBox22.Location = new System.Drawing.Point(315, 60);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(31, 20);
            this.textBox22.TabIndex = 11;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(266, 63);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(43, 13);
            this.label44.TabIndex = 60;
            this.label44.Text = "Estado:";
            // 
            // textBox23
            // 
            this.textBox23.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.CIDADE", true));
            this.textBox23.Location = new System.Drawing.Point(94, 60);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(149, 20);
            this.textBox23.TabIndex = 10;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(4, 63);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(43, 13);
            this.label45.TabIndex = 58;
            this.label45.Text = "Cidade:";
            // 
            // textBox24
            // 
            this.textBox24.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.BAIRRO", true));
            this.textBox24.Location = new System.Drawing.Point(551, 34);
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(114, 20);
            this.textBox24.TabIndex = 9;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(503, 37);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(37, 13);
            this.label46.TabIndex = 54;
            this.label46.Text = "Bairro:";
            // 
            // textBox25
            // 
            this.textBox25.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.ENDERECO", true));
            this.textBox25.Location = new System.Drawing.Point(95, 34);
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new System.Drawing.Size(294, 20);
            this.textBox25.TabIndex = 7;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(5, 37);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(56, 13);
            this.label47.TabIndex = 52;
            this.label47.Text = "Endereço:";
            // 
            // textBox26
            // 
            this.textBox26.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.IM", true));
            this.textBox26.Location = new System.Drawing.Point(427, 8);
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new System.Drawing.Size(97, 20);
            this.textBox26.TabIndex = 6;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(399, 11);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(22, 13);
            this.label48.TabIndex = 48;
            this.label48.Text = "IM:";
            // 
            // textBox27
            // 
            this.textBox27.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.IE", true));
            this.textBox27.Location = new System.Drawing.Point(262, 8);
            this.textBox27.Name = "textBox27";
            this.textBox27.Size = new System.Drawing.Size(126, 20);
            this.textBox27.TabIndex = 5;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(236, 11);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(20, 13);
            this.label49.TabIndex = 46;
            this.label49.Text = "IE:";
            // 
            // textBox28
            // 
            this.textBox28.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.CNPJ", true));
            this.textBox28.Location = new System.Drawing.Point(94, 8);
            this.textBox28.Name = "textBox28";
            this.textBox28.Size = new System.Drawing.Size(136, 20);
            this.textBox28.TabIndex = 4;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.textBox29);
            this.tabPage4.Controls.Add(this.label50);
            this.tabPage4.Controls.Add(this.textBox30);
            this.tabPage4.Controls.Add(this.label51);
            this.tabPage4.Controls.Add(this.textBox31);
            this.tabPage4.Controls.Add(this.label52);
            this.tabPage4.Controls.Add(this.textBox32);
            this.tabPage4.Controls.Add(this.label53);
            this.tabPage4.Controls.Add(this.textBox33);
            this.tabPage4.Controls.Add(this.label54);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(668, 168);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Dados Adicionais";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // textBox29
            // 
            this.textBox29.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.ENDERECO_COBRANCA_CLIENTE", true));
            this.textBox29.Location = new System.Drawing.Point(142, 121);
            this.textBox29.Name = "textBox29";
            this.textBox29.Size = new System.Drawing.Size(489, 20);
            this.textBox29.TabIndex = 27;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(25, 124);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(120, 13);
            this.label50.TabIndex = 59;
            this.label50.Text = "Endereço de Cobrança:";
            // 
            // textBox30
            // 
            this.textBox30.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.ENDERECO_ENTREGA_CLIENTE", true));
            this.textBox30.Location = new System.Drawing.Point(142, 143);
            this.textBox30.Name = "textBox30";
            this.textBox30.Size = new System.Drawing.Size(489, 20);
            this.textBox30.TabIndex = 28;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(25, 146);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(111, 13);
            this.label51.TabIndex = 57;
            this.label51.Text = "Endereço de Entrega:";
            // 
            // textBox31
            // 
            this.textBox31.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.ISENCAO_ICM_CLIENTE", true));
            this.textBox31.Location = new System.Drawing.Point(142, 76);
            this.textBox31.Multiline = true;
            this.textBox31.Name = "textBox31";
            this.textBox31.Size = new System.Drawing.Size(489, 43);
            this.textBox31.TabIndex = 26;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(24, 78);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(85, 13);
            this.label52.TabIndex = 55;
            this.label52.Text = "Isenção de ICM:";
            // 
            // textBox32
            // 
            this.textBox32.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.ISENCAO_IPI_CLIENTE", true));
            this.textBox32.Location = new System.Drawing.Point(142, 31);
            this.textBox32.Multiline = true;
            this.textBox32.Name = "textBox32";
            this.textBox32.Size = new System.Drawing.Size(489, 43);
            this.textBox32.TabIndex = 25;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(24, 31);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(79, 13);
            this.label53.TabIndex = 53;
            this.label53.Text = "Isenção de IPI:";
            // 
            // textBox33
            // 
            this.textBox33.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.CLASS_FISCAL_CLIENTE", true));
            this.textBox33.Location = new System.Drawing.Point(142, 9);
            this.textBox33.Name = "textBox33";
            this.textBox33.Size = new System.Drawing.Size(136, 20);
            this.textBox33.TabIndex = 24;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(25, 12);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(102, 13);
            this.label54.TabIndex = 52;
            this.label54.Text = "Classificação Fiscal:";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label55);
            this.tabPage5.Controls.Add(this.textBox34);
            this.tabPage5.Controls.Add(this.label56);
            this.tabPage5.Controls.Add(this.textBox35);
            this.tabPage5.Controls.Add(this.label57);
            this.tabPage5.Controls.Add(this.label58);
            this.tabPage5.Controls.Add(this.textBox36);
            this.tabPage5.Controls.Add(this.textBox37);
            this.tabPage5.Controls.Add(this.label59);
            this.tabPage5.Controls.Add(this.label60);
            this.tabPage5.Controls.Add(this.label61);
            this.tabPage5.Controls.Add(this.label62);
            this.tabPage5.Controls.Add(this.label63);
            this.tabPage5.Controls.Add(this.label64);
            this.tabPage5.Controls.Add(this.label65);
            this.tabPage5.Controls.Add(this.textBox38);
            this.tabPage5.Controls.Add(this.textBox39);
            this.tabPage5.Controls.Add(this.textBox40);
            this.tabPage5.Controls.Add(this.textBox41);
            this.tabPage5.Controls.Add(this.textBox42);
            this.tabPage5.Controls.Add(this.textBox43);
            this.tabPage5.Controls.Add(this.textBox44);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(668, 168);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Valores Orçamento";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(254, 129);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(53, 13);
            this.label55.TabIndex = 21;
            this.label55.Text = "Bancada:";
            // 
            // textBox34
            // 
            this.textBox34.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.VALOR_EWC015_CLIENTE", true));
            this.textBox34.Location = new System.Drawing.Point(334, 126);
            this.textBox34.Name = "textBox34";
            this.textBox34.Size = new System.Drawing.Size(100, 20);
            this.textBox34.TabIndex = 37;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(254, 103);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(32, 13);
            this.label56.TabIndex = 19;
            this.label56.Text = "CNC:";
            // 
            // textBox35
            // 
            this.textBox35.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.VALOR_EWC015_CLIENTE", true));
            this.textBox35.Location = new System.Drawing.Point(334, 100);
            this.textBox35.Name = "textBox35";
            this.textBox35.Size = new System.Drawing.Size(100, 20);
            this.textBox35.TabIndex = 36;
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(497, 51);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(52, 13);
            this.label57.TabIndex = 17;
            this.label57.Text = "% Venda:";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(455, 25);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(94, 13);
            this.label58.TabIndex = 16;
            this.label58.Text = "% Beneficiamento:";
            // 
            // textBox36
            // 
            this.textBox36.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.PORC_BENEFICIAMENTO_CLIENTE", true));
            this.textBox36.Location = new System.Drawing.Point(554, 23);
            this.textBox36.Name = "textBox36";
            this.textBox36.Size = new System.Drawing.Size(100, 20);
            this.textBox36.TabIndex = 38;
            // 
            // textBox37
            // 
            this.textBox37.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.PORC_VENDA_CLIENTE", true));
            this.textBox37.Location = new System.Drawing.Point(554, 48);
            this.textBox37.Name = "textBox37";
            this.textBox37.Size = new System.Drawing.Size(100, 20);
            this.textBox37.TabIndex = 39;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(254, 77);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(56, 13);
            this.label59.TabIndex = 13;
            this.label59.Text = "EWC 025:";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(254, 51);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(56, 13);
            this.label60.TabIndex = 12;
            this.label60.Text = "EWC 010:";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(254, 23);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(38, 13);
            this.label61.TabIndex = 11;
            this.label61.Text = "Torno:";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(16, 104);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(34, 13);
            this.label62.TabIndex = 10;
            this.label62.Text = "EDM:";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(16, 77);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(82, 13);
            this.label63.TabIndex = 9;
            this.label63.Text = "Retífica Óptica:";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(16, 52);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(48, 13);
            this.label64.TabIndex = 8;
            this.label64.Text = "Retífica:";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(16, 26);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(36, 13);
            this.label65.TabIndex = 7;
            this.label65.Text = "Fresa:";
            // 
            // textBox38
            // 
            this.textBox38.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.VALOR_EDM_CLIENTE", true));
            this.textBox38.Location = new System.Drawing.Point(99, 101);
            this.textBox38.Name = "textBox38";
            this.textBox38.Size = new System.Drawing.Size(100, 20);
            this.textBox38.TabIndex = 32;
            // 
            // textBox39
            // 
            this.textBox39.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.VALOR_RETIFICA_CLIENTE", true));
            this.textBox39.Location = new System.Drawing.Point(99, 49);
            this.textBox39.Name = "textBox39";
            this.textBox39.Size = new System.Drawing.Size(100, 20);
            this.textBox39.TabIndex = 30;
            // 
            // textBox40
            // 
            this.textBox40.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.VALOR_RETIFICA_OPTICA_CLIENTE", true));
            this.textBox40.Location = new System.Drawing.Point(99, 75);
            this.textBox40.Name = "textBox40";
            this.textBox40.Size = new System.Drawing.Size(100, 20);
            this.textBox40.TabIndex = 31;
            // 
            // textBox41
            // 
            this.textBox41.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.VALOR_TORNO_CLIENTE", true));
            this.textBox41.Location = new System.Drawing.Point(334, 23);
            this.textBox41.Name = "textBox41";
            this.textBox41.Size = new System.Drawing.Size(100, 20);
            this.textBox41.TabIndex = 33;
            // 
            // textBox42
            // 
            this.textBox42.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.VALOR_EWC_CLIENTE", true));
            this.textBox42.Location = new System.Drawing.Point(334, 48);
            this.textBox42.Name = "textBox42";
            this.textBox42.Size = new System.Drawing.Size(100, 20);
            this.textBox42.TabIndex = 34;
            // 
            // textBox43
            // 
            this.textBox43.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.VALOR_EWC015_CLIENTE", true));
            this.textBox43.Location = new System.Drawing.Point(334, 74);
            this.textBox43.Name = "textBox43";
            this.textBox43.Size = new System.Drawing.Size(100, 20);
            this.textBox43.TabIndex = 35;
            // 
            // textBox44
            // 
            this.textBox44.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.VALOR_FRESA_CLIENTE", true));
            this.textBox44.Location = new System.Drawing.Point(99, 23);
            this.textBox44.Name = "textBox44";
            this.textBox44.Size = new System.Drawing.Size(100, 20);
            this.textBox44.TabIndex = 29;
            // 
            // dsVendedores
            // 
            this.dsVendedores.DataSetName = "dsVendedores";
            this.dsVendedores.Namespace = "http://www.tempuri.org/dsVendedores.xsd";
            this.dsVendedores.Tables.AddRange(new System.Data.DataTable[] {
            this.VENDEDORES_CLIENTE});
            // 
            // VENDEDORES_CLIENTE
            // 
            this.VENDEDORES_CLIENTE.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_VC,
            this.COD_CLIENTE_VC,
            this.COD_VENDEDOR_VC,
            this.NOME_VENDEDOR_VC});
            this.VENDEDORES_CLIENTE.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_VC"}, true)});
            this.VENDEDORES_CLIENTE.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_VC};
            this.VENDEDORES_CLIENTE.TableName = "VENDEDORES_CLIENTE";
            // 
            // COD_VC
            // 
            this.COD_VC.AllowDBNull = false;
            this.COD_VC.ColumnName = "COD_VC";
            this.COD_VC.DataType = typeof(int);
            // 
            // COD_CLIENTE_VC
            // 
            this.COD_CLIENTE_VC.AllowDBNull = false;
            this.COD_CLIENTE_VC.ColumnName = "COD_CLIENTE_VC";
            this.COD_CLIENTE_VC.DataType = typeof(int);
            // 
            // COD_VENDEDOR_VC
            // 
            this.COD_VENDEDOR_VC.AllowDBNull = false;
            this.COD_VENDEDOR_VC.ColumnName = "COD_VENDEDOR_VC";
            this.COD_VENDEDOR_VC.DataType = typeof(int);
            // 
            // NOME_VENDEDOR_VC
            // 
            this.NOME_VENDEDOR_VC.ColumnName = "NOME_VENDEDOR_VC";
            this.NOME_VENDEDOR_VC.MaxLength = 100;
            // 
            // dsItens_tp
            // 
            this.dsItens_tp.DataSetName = "dsItens_tp";
            this.dsItens_tp.Namespace = "http://www.tempuri.org/dsItens_tp.xsd";
            this.dsItens_tp.Tables.AddRange(new System.Data.DataTable[] {
            this.ITENS_TP});
            // 
            // ITENS_TP
            // 
            this.ITENS_TP.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_ITEM_TP,
            this.COD_TABELA_ITEM_TP,
            this.COD_PRODUTO_ITEM_TP,
            this.DESCRICAO_PRODUTO_ITEM_TP,
            this.PRECO_PRODUTO_ITEM_TP,
            this.PRECO_MINIMO_ITEM_TP});
            this.ITENS_TP.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_ITEM_TP"}, true)});
            this.ITENS_TP.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_ITEM_TP};
            this.ITENS_TP.TableName = "ITENS_TP";
            // 
            // COD_ITEM_TP
            // 
            this.COD_ITEM_TP.AllowDBNull = false;
            this.COD_ITEM_TP.AutoIncrement = true;
            this.COD_ITEM_TP.ColumnName = "COD_ITEM_TP";
            this.COD_ITEM_TP.DataType = typeof(int);
            // 
            // COD_TABELA_ITEM_TP
            // 
            this.COD_TABELA_ITEM_TP.ColumnName = "COD_TABELA_ITEM_TP";
            this.COD_TABELA_ITEM_TP.DataType = typeof(int);
            // 
            // COD_PRODUTO_ITEM_TP
            // 
            this.COD_PRODUTO_ITEM_TP.ColumnName = "COD_PRODUTO_ITEM_TP";
            this.COD_PRODUTO_ITEM_TP.DataType = typeof(int);
            // 
            // DESCRICAO_PRODUTO_ITEM_TP
            // 
            this.DESCRICAO_PRODUTO_ITEM_TP.ColumnName = "DESCRICAO_PRODUTO_ITEM_TP";
            this.DESCRICAO_PRODUTO_ITEM_TP.MaxLength = 200;
            // 
            // PRECO_PRODUTO_ITEM_TP
            // 
            this.PRECO_PRODUTO_ITEM_TP.ColumnName = "PRECO_PRODUTO_ITEM_TP";
            this.PRECO_PRODUTO_ITEM_TP.DataType = typeof(double);
            // 
            // PRECO_MINIMO_ITEM_TP
            // 
            this.PRECO_MINIMO_ITEM_TP.ColumnName = "PRECO_MINIMO_ITEM_TP";
            this.PRECO_MINIMO_ITEM_TP.DataType = typeof(double);
            // 
            // dsItemPedAntigo
            // 
            this.dsItemPedAntigo.DataSetName = "dsItemPedAntigo";
            this.dsItemPedAntigo.Namespace = "http://www.tempuri.org/dsItemPedAntigo.xsd";
            this.dsItemPedAntigo.Tables.AddRange(new System.Data.DataTable[] {
            this.ITEMPED});
            // 
            // ITEMPED
            // 
            this.ITEMPED.Columns.AddRange(new System.Data.DataColumn[] {
            this.PEDPROD,
            this.DESCRICAO_PROD,
            this.PEDVLUNI,
            this.PC_CLI,
            this.RAZAO_CLI,
            this.PC_EMISSAO,
            this.PC_NRPED,
            this.QT_VEND,
            this.VL_TOTAL,
            this.FP_DESCR});
            this.ITEMPED.TableName = "ITEMPED";
            // 
            // PEDPROD
            // 
            this.PEDPROD.ColumnName = "PEDPROD";
            this.PEDPROD.MaxLength = 100;
            // 
            // DESCRICAO_PROD
            // 
            this.DESCRICAO_PROD.ColumnName = "DESCRICAO_PROD";
            this.DESCRICAO_PROD.MaxLength = 200;
            // 
            // PEDVLUNI
            // 
            this.PEDVLUNI.ColumnName = "PEDVLUNI";
            this.PEDVLUNI.DataType = typeof(decimal);
            // 
            // PC_CLI
            // 
            this.PC_CLI.ColumnName = "PC_CLI";
            this.PC_CLI.MaxLength = 100;
            // 
            // RAZAO_CLI
            // 
            this.RAZAO_CLI.ColumnName = "RAZAO_CLI";
            this.RAZAO_CLI.MaxLength = 200;
            // 
            // PC_EMISSAO
            // 
            this.PC_EMISSAO.ColumnName = "PC_EMISSAO";
            this.PC_EMISSAO.DataType = typeof(System.DateTime);
            // 
            // PC_NRPED
            // 
            this.PC_NRPED.ColumnName = "PC_NRPED";
            this.PC_NRPED.MaxLength = 7;
            // 
            // QT_VEND
            // 
            this.QT_VEND.ColumnName = "QT_VEND";
            this.QT_VEND.DataType = typeof(decimal);
            // 
            // VL_TOTAL
            // 
            this.VL_TOTAL.ColumnName = "VL_TOTAL";
            this.VL_TOTAL.DataType = typeof(decimal);
            // 
            // FP_DESCR
            // 
            this.FP_DESCR.ColumnName = "FP_DESCR";
            this.FP_DESCR.MaxLength = 50;
            // 
            // dsPedidos_venda
            // 
            this.dsPedidos_venda.DataSetName = "dsPedidos_venda";
            this.dsPedidos_venda.Namespace = "http://www.tempuri.org/dsPedidos_venda.xsd";
            this.dsPedidos_venda.Tables.AddRange(new System.Data.DataTable[] {
            this.PEDIDOS_VENDA});
            // 
            // PEDIDOS_VENDA
            // 
            this.PEDIDOS_VENDA.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_PED_VENDA,
            this.N_PED_VENDA,
            this.DATA_PED_VENDA,
            this.DATA_BAIXA_PED_VENDA,
            this.CLIENTE_PED_VENDA,
            this.CNPJ_PED_VENDA,
            this.COND_PGTO_PED_VENDA,
            this.VALOR_TOTAL_PROD_PED_VENDA,
            this.VALOR_TOTAL_PED_VENDA,
            this.VALOR_TOTAL_ICMS_PED_VENDA,
            this.VALOR_TOTAL_IPI_PED_VENDA,
            this.VALOR_DESCONTO_PED_VENDA,
            this.OBS_PED_VENDA,
            this.NF_PED_VENDA,
            this.BAIXADO_ESTOQUE_PED_VENDA,
            this.PAGO_PED_VENDA,
            this.COD_CAIXA_PGTO_PED_VENDA,
            this.VENDEDOR_PED_VENDA,
            this.COD_VENDEDOR_PED_VENDA,
            this.CANCELADO_PED_VENDA,
            this.NOME_CONTATO_PED_VENDA,
            this.TELEFONE_CONTATO_PED_VENDA,
            this.EMAIL_CONTATO_PED_VENDA,
            this.PORC_DESCONTO_PED_VENDA,
            this.N_NF_PED_VENDA,
            this.ID_PEDIDO_CEL_PED_VENDA,
            this.IMPRESSO_PED_VENDA,
            this.DATA_ENTREGA_PED_VENDA,
            this.QTDE_ITENS_PED_VENDA,
            this.TROCA_PED_VENDA,
            this.BONIFICACAO_PED_VENDA,
            this.SAIDA_VENDA_DIRETA_PED_VENDA,
            this.VENDA_DIRETA_PED_VENDA,
            this.NF_ENTRADA_PED_VENDA,
            this.COD_PEDIDO_PAI_PED_VENDA,
            this.ORCAMENTO_PED_VENDA,
            this.COD_LRW_PED_VENDA,
            this.COD_CAIXA_PED_VENDA,
            this.DATA_NF_PED_VENDA,
            this.QTDE_TOTAL_PED_VENDA,
            this.DATA_EXPORTACAO_PED_VENDA,
            this.HORA_EXPORTACAO_PED_VENDA,
            this.DEGUSTACAO_PED_VENDA,
            this.DEVOLUCAO_PED_VENDA,
            this.PV_PED_VENDA,
            this.COD_TP_PED_VENDA,
            this.DESCRICAO_TP_PED_VENDA,
            this.TRANSPORTADORA_PED_VENDA,
            this.PLACA_TRANSP_PED_VENDA,
            this.CNPJ_EMISSOR_PED_VENDA,
            this.RAZAO_EMISSOR_PED_VENDA,
            this.VALOR_ST_PED_VENDA,
            this.VALOR_TOTAL_DESEJADO_PED_VENDA,
            this.PERC_DESEJADO_PED_VENDA});
            this.PEDIDOS_VENDA.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_PED_VENDA"}, true)});
            this.PEDIDOS_VENDA.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_PED_VENDA};
            this.PEDIDOS_VENDA.TableName = "PEDIDOS_VENDA";
            // 
            // COD_PED_VENDA
            // 
            this.COD_PED_VENDA.AllowDBNull = false;
            this.COD_PED_VENDA.ColumnName = "COD_PED_VENDA";
            this.COD_PED_VENDA.DataType = typeof(int);
            // 
            // N_PED_VENDA
            // 
            this.N_PED_VENDA.ColumnName = "N_PED_VENDA";
            this.N_PED_VENDA.DataType = typeof(int);
            // 
            // DATA_PED_VENDA
            // 
            this.DATA_PED_VENDA.ColumnName = "DATA_PED_VENDA";
            this.DATA_PED_VENDA.DataType = typeof(System.DateTime);
            // 
            // DATA_BAIXA_PED_VENDA
            // 
            this.DATA_BAIXA_PED_VENDA.ColumnName = "DATA_BAIXA_PED_VENDA";
            this.DATA_BAIXA_PED_VENDA.DataType = typeof(System.DateTime);
            // 
            // CLIENTE_PED_VENDA
            // 
            this.CLIENTE_PED_VENDA.ColumnName = "CLIENTE_PED_VENDA";
            this.CLIENTE_PED_VENDA.MaxLength = 200;
            // 
            // CNPJ_PED_VENDA
            // 
            this.CNPJ_PED_VENDA.ColumnName = "CNPJ_PED_VENDA";
            this.CNPJ_PED_VENDA.MaxLength = 30;
            // 
            // COND_PGTO_PED_VENDA
            // 
            this.COND_PGTO_PED_VENDA.ColumnName = "COND_PGTO_PED_VENDA";
            this.COND_PGTO_PED_VENDA.MaxLength = 30;
            // 
            // VALOR_TOTAL_PROD_PED_VENDA
            // 
            this.VALOR_TOTAL_PROD_PED_VENDA.ColumnName = "VALOR_TOTAL_PROD_PED_VENDA";
            this.VALOR_TOTAL_PROD_PED_VENDA.DataType = typeof(double);
            // 
            // VALOR_TOTAL_PED_VENDA
            // 
            this.VALOR_TOTAL_PED_VENDA.ColumnName = "VALOR_TOTAL_PED_VENDA";
            this.VALOR_TOTAL_PED_VENDA.DataType = typeof(double);
            // 
            // VALOR_TOTAL_ICMS_PED_VENDA
            // 
            this.VALOR_TOTAL_ICMS_PED_VENDA.ColumnName = "VALOR_TOTAL_ICMS_PED_VENDA";
            this.VALOR_TOTAL_ICMS_PED_VENDA.DataType = typeof(double);
            // 
            // VALOR_TOTAL_IPI_PED_VENDA
            // 
            this.VALOR_TOTAL_IPI_PED_VENDA.ColumnName = "VALOR_TOTAL_IPI_PED_VENDA";
            this.VALOR_TOTAL_IPI_PED_VENDA.DataType = typeof(double);
            // 
            // VALOR_DESCONTO_PED_VENDA
            // 
            this.VALOR_DESCONTO_PED_VENDA.ColumnName = "VALOR_DESCONTO_PED_VENDA";
            this.VALOR_DESCONTO_PED_VENDA.DataType = typeof(double);
            // 
            // OBS_PED_VENDA
            // 
            this.OBS_PED_VENDA.ColumnName = "OBS_PED_VENDA";
            this.OBS_PED_VENDA.MaxLength = 300;
            // 
            // NF_PED_VENDA
            // 
            this.NF_PED_VENDA.ColumnName = "NF_PED_VENDA";
            this.NF_PED_VENDA.DataType = typeof(int);
            // 
            // BAIXADO_ESTOQUE_PED_VENDA
            // 
            this.BAIXADO_ESTOQUE_PED_VENDA.ColumnName = "BAIXADO_ESTOQUE_PED_VENDA";
            this.BAIXADO_ESTOQUE_PED_VENDA.DataType = typeof(int);
            // 
            // PAGO_PED_VENDA
            // 
            this.PAGO_PED_VENDA.ColumnName = "PAGO_PED_VENDA";
            this.PAGO_PED_VENDA.DataType = typeof(int);
            // 
            // COD_CAIXA_PGTO_PED_VENDA
            // 
            this.COD_CAIXA_PGTO_PED_VENDA.ColumnName = "COD_CAIXA_PGTO_PED_VENDA";
            this.COD_CAIXA_PGTO_PED_VENDA.DataType = typeof(int);
            // 
            // VENDEDOR_PED_VENDA
            // 
            this.VENDEDOR_PED_VENDA.ColumnName = "VENDEDOR_PED_VENDA";
            this.VENDEDOR_PED_VENDA.MaxLength = 100;
            // 
            // COD_VENDEDOR_PED_VENDA
            // 
            this.COD_VENDEDOR_PED_VENDA.ColumnName = "COD_VENDEDOR_PED_VENDA";
            this.COD_VENDEDOR_PED_VENDA.DataType = typeof(int);
            // 
            // CANCELADO_PED_VENDA
            // 
            this.CANCELADO_PED_VENDA.ColumnName = "CANCELADO_PED_VENDA";
            this.CANCELADO_PED_VENDA.DataType = typeof(int);
            // 
            // NOME_CONTATO_PED_VENDA
            // 
            this.NOME_CONTATO_PED_VENDA.ColumnName = "NOME_CONTATO_PED_VENDA";
            this.NOME_CONTATO_PED_VENDA.MaxLength = 100;
            // 
            // TELEFONE_CONTATO_PED_VENDA
            // 
            this.TELEFONE_CONTATO_PED_VENDA.ColumnName = "TELEFONE_CONTATO_PED_VENDA";
            this.TELEFONE_CONTATO_PED_VENDA.MaxLength = 100;
            // 
            // EMAIL_CONTATO_PED_VENDA
            // 
            this.EMAIL_CONTATO_PED_VENDA.ColumnName = "EMAIL_CONTATO_PED_VENDA";
            this.EMAIL_CONTATO_PED_VENDA.MaxLength = 100;
            // 
            // PORC_DESCONTO_PED_VENDA
            // 
            this.PORC_DESCONTO_PED_VENDA.ColumnName = "PORC_DESCONTO_PED_VENDA";
            this.PORC_DESCONTO_PED_VENDA.DataType = typeof(double);
            // 
            // N_NF_PED_VENDA
            // 
            this.N_NF_PED_VENDA.ColumnName = "N_NF_PED_VENDA";
            this.N_NF_PED_VENDA.MaxLength = 20;
            // 
            // ID_PEDIDO_CEL_PED_VENDA
            // 
            this.ID_PEDIDO_CEL_PED_VENDA.ColumnName = "ID_PEDIDO_CEL_PED_VENDA";
            this.ID_PEDIDO_CEL_PED_VENDA.DataType = typeof(int);
            // 
            // IMPRESSO_PED_VENDA
            // 
            this.IMPRESSO_PED_VENDA.ColumnName = "IMPRESSO_PED_VENDA";
            this.IMPRESSO_PED_VENDA.DataType = typeof(int);
            // 
            // DATA_ENTREGA_PED_VENDA
            // 
            this.DATA_ENTREGA_PED_VENDA.ColumnName = "DATA_ENTREGA_PED_VENDA";
            this.DATA_ENTREGA_PED_VENDA.DataType = typeof(System.DateTime);
            // 
            // QTDE_ITENS_PED_VENDA
            // 
            this.QTDE_ITENS_PED_VENDA.ColumnName = "QTDE_ITENS_PED_VENDA";
            this.QTDE_ITENS_PED_VENDA.DataType = typeof(int);
            // 
            // TROCA_PED_VENDA
            // 
            this.TROCA_PED_VENDA.ColumnName = "TROCA_PED_VENDA";
            this.TROCA_PED_VENDA.DataType = typeof(int);
            // 
            // BONIFICACAO_PED_VENDA
            // 
            this.BONIFICACAO_PED_VENDA.ColumnName = "BONIFICACAO_PED_VENDA";
            this.BONIFICACAO_PED_VENDA.DataType = typeof(int);
            // 
            // SAIDA_VENDA_DIRETA_PED_VENDA
            // 
            this.SAIDA_VENDA_DIRETA_PED_VENDA.ColumnName = "SAIDA_VENDA_DIRETA_PED_VENDA";
            this.SAIDA_VENDA_DIRETA_PED_VENDA.DataType = typeof(int);
            // 
            // VENDA_DIRETA_PED_VENDA
            // 
            this.VENDA_DIRETA_PED_VENDA.ColumnName = "VENDA_DIRETA_PED_VENDA";
            this.VENDA_DIRETA_PED_VENDA.DataType = typeof(int);
            // 
            // NF_ENTRADA_PED_VENDA
            // 
            this.NF_ENTRADA_PED_VENDA.ColumnName = "NF_ENTRADA_PED_VENDA";
            this.NF_ENTRADA_PED_VENDA.DataType = typeof(int);
            // 
            // COD_PEDIDO_PAI_PED_VENDA
            // 
            this.COD_PEDIDO_PAI_PED_VENDA.ColumnName = "COD_PEDIDO_PAI_PED_VENDA";
            this.COD_PEDIDO_PAI_PED_VENDA.DataType = typeof(int);
            // 
            // ORCAMENTO_PED_VENDA
            // 
            this.ORCAMENTO_PED_VENDA.ColumnName = "ORCAMENTO_PED_VENDA";
            this.ORCAMENTO_PED_VENDA.DataType = typeof(int);
            // 
            // COD_LRW_PED_VENDA
            // 
            this.COD_LRW_PED_VENDA.ColumnName = "COD_LRW_PED_VENDA";
            this.COD_LRW_PED_VENDA.DataType = typeof(int);
            // 
            // COD_CAIXA_PED_VENDA
            // 
            this.COD_CAIXA_PED_VENDA.ColumnName = "COD_CAIXA_PED_VENDA";
            this.COD_CAIXA_PED_VENDA.DataType = typeof(int);
            // 
            // DATA_NF_PED_VENDA
            // 
            this.DATA_NF_PED_VENDA.ColumnName = "DATA_NF_PED_VENDA";
            this.DATA_NF_PED_VENDA.DataType = typeof(System.DateTime);
            // 
            // QTDE_TOTAL_PED_VENDA
            // 
            this.QTDE_TOTAL_PED_VENDA.ColumnName = "QTDE_TOTAL_PED_VENDA";
            this.QTDE_TOTAL_PED_VENDA.DataType = typeof(double);
            // 
            // DATA_EXPORTACAO_PED_VENDA
            // 
            this.DATA_EXPORTACAO_PED_VENDA.ColumnName = "DATA_EXPORTACAO_PED_VENDA";
            this.DATA_EXPORTACAO_PED_VENDA.DataType = typeof(System.DateTime);
            // 
            // HORA_EXPORTACAO_PED_VENDA
            // 
            this.HORA_EXPORTACAO_PED_VENDA.ColumnName = "HORA_EXPORTACAO_PED_VENDA";
            this.HORA_EXPORTACAO_PED_VENDA.DataType = typeof(System.DateTime);
            // 
            // DEGUSTACAO_PED_VENDA
            // 
            this.DEGUSTACAO_PED_VENDA.ColumnName = "DEGUSTACAO_PED_VENDA";
            this.DEGUSTACAO_PED_VENDA.DataType = typeof(int);
            // 
            // DEVOLUCAO_PED_VENDA
            // 
            this.DEVOLUCAO_PED_VENDA.ColumnName = "DEVOLUCAO_PED_VENDA";
            this.DEVOLUCAO_PED_VENDA.DataType = typeof(int);
            // 
            // PV_PED_VENDA
            // 
            this.PV_PED_VENDA.ColumnName = "PV_PED_VENDA";
            this.PV_PED_VENDA.DataType = typeof(int);
            // 
            // COD_TP_PED_VENDA
            // 
            this.COD_TP_PED_VENDA.ColumnName = "COD_TP_PED_VENDA";
            this.COD_TP_PED_VENDA.DataType = typeof(int);
            // 
            // DESCRICAO_TP_PED_VENDA
            // 
            this.DESCRICAO_TP_PED_VENDA.ColumnName = "DESCRICAO_TP_PED_VENDA";
            this.DESCRICAO_TP_PED_VENDA.MaxLength = 200;
            // 
            // TRANSPORTADORA_PED_VENDA
            // 
            this.TRANSPORTADORA_PED_VENDA.ColumnName = "TRANSPORTADORA_PED_VENDA";
            this.TRANSPORTADORA_PED_VENDA.MaxLength = 100;
            // 
            // PLACA_TRANSP_PED_VENDA
            // 
            this.PLACA_TRANSP_PED_VENDA.ColumnName = "PLACA_TRANSP_PED_VENDA";
            this.PLACA_TRANSP_PED_VENDA.MaxLength = 10;
            // 
            // CNPJ_EMISSOR_PED_VENDA
            // 
            this.CNPJ_EMISSOR_PED_VENDA.ColumnName = "CNPJ_EMISSOR_PED_VENDA";
            this.CNPJ_EMISSOR_PED_VENDA.MaxLength = 30;
            // 
            // RAZAO_EMISSOR_PED_VENDA
            // 
            this.RAZAO_EMISSOR_PED_VENDA.ColumnName = "RAZAO_EMISSOR_PED_VENDA";
            this.RAZAO_EMISSOR_PED_VENDA.MaxLength = 100;
            // 
            // VALOR_ST_PED_VENDA
            // 
            this.VALOR_ST_PED_VENDA.ColumnName = "VALOR_ST_PED_VENDA";
            this.VALOR_ST_PED_VENDA.DataType = typeof(double);
            // 
            // VALOR_TOTAL_DESEJADO_PED_VENDA
            // 
            this.VALOR_TOTAL_DESEJADO_PED_VENDA.ColumnName = "VALOR_TOTAL_DESEJADO_PED_VENDA";
            this.VALOR_TOTAL_DESEJADO_PED_VENDA.DataType = typeof(double);
            // 
            // PERC_DESEJADO_PED_VENDA
            // 
            this.PERC_DESEJADO_PED_VENDA.ColumnName = "PERC_DESEJADO_PED_VENDA";
            this.PERC_DESEJADO_PED_VENDA.DataType = typeof(double);
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.ForeColor = System.Drawing.Color.Red;
            this.label73.Location = new System.Drawing.Point(661, 16);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(269, 26);
            this.label73.TabIndex = 50;
            this.label73.Text = "Dica: Coloque o Cep e tecle <ENTER> \r\npara achar o endereço, depois basta colocar" +
    " o número.";
            this.label73.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // datClassificacaoClientes
            // 
            this.datClassificacaoClientes.DeleteCommand = this.fbCommand14;
            this.datClassificacaoClientes.InsertCommand = this.fbCommand12;
            this.datClassificacaoClientes.SelectCommand = this.fbCommand11;
            this.datClassificacaoClientes.UpdateCommand = this.fbCommand13;
            // 
            // fbCommand14
            // 
            this.fbCommand14.CommandTimeout = 30;
            // 
            // fbCommand12
            // 
            this.fbCommand12.CommandTimeout = 30;
            // 
            // fbCommand11
            // 
            this.fbCommand11.CommandText = "select * from classificacao_clientes";
            this.fbCommand11.CommandTimeout = 30;
            this.fbCommand11.Connection = this.fbConnection1;
            // 
            // fbCommand13
            // 
            this.fbCommand13.CommandTimeout = 30;
            // 
            // dsClassificacaoClientes
            // 
            this.dsClassificacaoClientes.DataSetName = "dsClassificacaoClientes";
            this.dsClassificacaoClientes.Namespace = "http://www.tempuri.org/dsClassificacaoClientes.xsd";
            this.dsClassificacaoClientes.Tables.AddRange(new System.Data.DataTable[] {
            this.CLASSIFICACAO_CLIENTES});
            // 
            // CLASSIFICACAO_CLIENTES
            // 
            this.CLASSIFICACAO_CLIENTES.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD,
            this.DESCRICAO});
            this.CLASSIFICACAO_CLIENTES.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD"}, true)});
            this.CLASSIFICACAO_CLIENTES.PrimaryKey = new System.Data.DataColumn[] {
        this.COD};
            this.CLASSIFICACAO_CLIENTES.TableName = "CLASSIFICACAO_CLIENTES";
            // 
            // COD
            // 
            this.COD.AllowDBNull = false;
            this.COD.AutoIncrement = true;
            this.COD.ColumnName = "COD";
            this.COD.DataType = typeof(int);
            // 
            // DESCRICAO
            // 
            this.DESCRICAO.ColumnName = "DESCRICAO";
            this.DESCRICAO.MaxLength = 100;
            // 
            // datFormaPagamento
            // 
            this.datFormaPagamento.DeleteCommand = this.fbCommand18;
            this.datFormaPagamento.InsertCommand = this.fbCommand16;
            this.datFormaPagamento.SelectCommand = this.fbCommand15;
            this.datFormaPagamento.UpdateCommand = this.fbCommand17;
            // 
            // fbCommand18
            // 
            this.fbCommand18.CommandTimeout = 30;
            // 
            // fbCommand16
            // 
            this.fbCommand16.CommandTimeout = 30;
            // 
            // fbCommand15
            // 
            this.fbCommand15.CommandText = "select * from forma_pgto";
            this.fbCommand15.CommandTimeout = 30;
            this.fbCommand15.Connection = this.fbConnection1;
            // 
            // fbCommand17
            // 
            this.fbCommand17.CommandTimeout = 30;
            // 
            // dsFormaPagamento
            // 
            this.dsFormaPagamento.DataSetName = "dsFormaPagamento";
            this.dsFormaPagamento.Namespace = "http://www.tempuri.org/dsFormaPagamento.xsd";
            this.dsFormaPagamento.Tables.AddRange(new System.Data.DataTable[] {
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
            // fbCommand20
            // 
            this.fbCommand20.CommandTimeout = 30;
            // 
            // fbCommand21
            // 
            this.fbCommand21.CommandTimeout = 30;
            // 
            // fbCommand22
            // 
            this.fbCommand22.CommandTimeout = 30;
            // 
            // cbVendedores
            // 
            this.cbVendedores.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbVendedores.DataAdapter = this.datVendedores;
            this.cbVendedores.QuotePrefix = "\"";
            this.cbVendedores.QuoteSuffix = "\"";
            // 
            // datVendedores
            // 
            this.datVendedores.DeleteCommand = this.fbCommand25;
            this.datVendedores.InsertCommand = this.fbCommand23;
            this.datVendedores.SelectCommand = this.fbCommand19;
            this.datVendedores.UpdateCommand = this.fbCommand24;
            // 
            // fbCommand25
            // 
            this.fbCommand25.CommandTimeout = 30;
            // 
            // fbCommand23
            // 
            this.fbCommand23.CommandTimeout = 30;
            // 
            // fbCommand19
            // 
            this.fbCommand19.CommandText = "select * from vendedores_cliente";
            this.fbCommand19.CommandTimeout = 30;
            this.fbCommand19.Connection = this.fbConnection1;
            // 
            // fbCommand24
            // 
            this.fbCommand24.CommandTimeout = 30;
            // 
            // cbxAtivoCliente
            // 
            this.cbxAtivoCliente.AutoSize = true;
            this.cbxAtivoCliente.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsClientes, "CLIENTES.ATIVO_CLIENTE", true));
            this.cbxAtivoCliente.Location = new System.Drawing.Point(478, 54);
            this.cbxAtivoCliente.Name = "cbxAtivoCliente";
            this.cbxAtivoCliente.Size = new System.Drawing.Size(56, 17);
            this.cbxAtivoCliente.TabIndex = 51;
            this.cbxAtivoCliente.Text = "Ativo?";
            this.cbxAtivoCliente.UseVisualStyleBackColor = true;
            // 
            // cbContatos
            // 
            this.cbContatos.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbContatos.DataAdapter = this.datContatos;
            this.cbContatos.QuotePrefix = "\"";
            this.cbContatos.QuoteSuffix = "\"";
            // 
            // dgvContas
            // 
            this.dgvContas.AllowUserToAddRows = false;
            this.dgvContas.AllowUserToDeleteRows = false;
            this.dgvContas.AutoGenerateColumns = false;
            this.dgvContas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODCRDataGridViewTextBoxColumn,
            this.dATAPREVISTACRDataGridViewTextBoxColumn,
            this.dESCRICAOCRDataGridViewTextBoxColumn,
            this.col_valor,
            this.nFCRDataGridViewTextBoxColumn,
            this.dATARECEBIMENTOCRDataGridViewTextBoxColumn,
            this.cODCLIENTECRDataGridViewTextBoxColumn,
            this.rAZAOCLIENTECRDataGridViewTextBoxColumn,
            this.dUPLICATACRDataGridViewTextBoxColumn,
            this.rECEBIDOCRDataGridViewTextBoxColumn,
            this.cODCAIXACRDataGridViewTextBoxColumn,
            this.pLANOCRDataGridViewTextBoxColumn,
            this.cARTEIRACRDataGridViewTextBoxColumn,
            this.cODPLANOCRDataGridViewTextBoxColumn,
            this.vALORATUALIZADOCRDataGridViewTextBoxColumn,
            this.dESCRICAOCCCRDataGridViewTextBoxColumn,
            this.oBSERVACOESCRDataGridViewTextBoxColumn,
            this.cCCRDataGridViewTextBoxColumn,
            this.rEMESSACRDataGridViewTextBoxColumn,
            this.dATACRIACAOCRDataGridViewTextBoxColumn,
            this.rOMANEIOCRDataGridViewTextBoxColumn,
            this.dATAVENCORIGINALCRDataGridViewTextBoxColumn});
            this.dgvContas.DataMember = "CONTAS_A_RECEBER";
            this.dgvContas.DataSource = this.dsContas;
            this.dgvContas.Location = new System.Drawing.Point(7, 33);
            this.dgvContas.Name = "dgvContas";
            this.dgvContas.ReadOnly = true;
            this.dgvContas.RowHeadersVisible = false;
            this.dgvContas.Size = new System.Drawing.Size(338, 309);
            this.dgvContas.TabIndex = 52;
            // 
            // cODCRDataGridViewTextBoxColumn
            // 
            this.cODCRDataGridViewTextBoxColumn.DataPropertyName = "COD_CR";
            this.cODCRDataGridViewTextBoxColumn.HeaderText = "Nº.";
            this.cODCRDataGridViewTextBoxColumn.Name = "cODCRDataGridViewTextBoxColumn";
            this.cODCRDataGridViewTextBoxColumn.ReadOnly = true;
            this.cODCRDataGridViewTextBoxColumn.Visible = false;
            this.cODCRDataGridViewTextBoxColumn.Width = 50;
            // 
            // dATAPREVISTACRDataGridViewTextBoxColumn
            // 
            this.dATAPREVISTACRDataGridViewTextBoxColumn.DataPropertyName = "DATA_PREVISTA_CR";
            this.dATAPREVISTACRDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dATAPREVISTACRDataGridViewTextBoxColumn.Name = "dATAPREVISTACRDataGridViewTextBoxColumn";
            this.dATAPREVISTACRDataGridViewTextBoxColumn.ReadOnly = true;
            this.dATAPREVISTACRDataGridViewTextBoxColumn.Width = 70;
            // 
            // dESCRICAOCRDataGridViewTextBoxColumn
            // 
            this.dESCRICAOCRDataGridViewTextBoxColumn.DataPropertyName = "DESCRICAO_CR";
            this.dESCRICAOCRDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.dESCRICAOCRDataGridViewTextBoxColumn.Name = "dESCRICAOCRDataGridViewTextBoxColumn";
            this.dESCRICAOCRDataGridViewTextBoxColumn.ReadOnly = true;
            this.dESCRICAOCRDataGridViewTextBoxColumn.Width = 190;
            // 
            // col_valor
            // 
            this.col_valor.DataPropertyName = "VALOR_CR";
            this.col_valor.HeaderText = "Valor";
            this.col_valor.Name = "col_valor";
            this.col_valor.ReadOnly = true;
            this.col_valor.Width = 70;
            // 
            // nFCRDataGridViewTextBoxColumn
            // 
            this.nFCRDataGridViewTextBoxColumn.DataPropertyName = "NF_CR";
            this.nFCRDataGridViewTextBoxColumn.HeaderText = "NF";
            this.nFCRDataGridViewTextBoxColumn.Name = "nFCRDataGridViewTextBoxColumn";
            this.nFCRDataGridViewTextBoxColumn.ReadOnly = true;
            this.nFCRDataGridViewTextBoxColumn.Visible = false;
            this.nFCRDataGridViewTextBoxColumn.Width = 50;
            // 
            // dATARECEBIMENTOCRDataGridViewTextBoxColumn
            // 
            this.dATARECEBIMENTOCRDataGridViewTextBoxColumn.DataPropertyName = "DATA_RECEBIMENTO_CR";
            this.dATARECEBIMENTOCRDataGridViewTextBoxColumn.HeaderText = "DATA_RECEBIMENTO_CR";
            this.dATARECEBIMENTOCRDataGridViewTextBoxColumn.Name = "dATARECEBIMENTOCRDataGridViewTextBoxColumn";
            this.dATARECEBIMENTOCRDataGridViewTextBoxColumn.ReadOnly = true;
            this.dATARECEBIMENTOCRDataGridViewTextBoxColumn.Visible = false;
            // 
            // cODCLIENTECRDataGridViewTextBoxColumn
            // 
            this.cODCLIENTECRDataGridViewTextBoxColumn.DataPropertyName = "COD_CLIENTE_CR";
            this.cODCLIENTECRDataGridViewTextBoxColumn.HeaderText = "COD_CLIENTE_CR";
            this.cODCLIENTECRDataGridViewTextBoxColumn.Name = "cODCLIENTECRDataGridViewTextBoxColumn";
            this.cODCLIENTECRDataGridViewTextBoxColumn.ReadOnly = true;
            this.cODCLIENTECRDataGridViewTextBoxColumn.Visible = false;
            // 
            // rAZAOCLIENTECRDataGridViewTextBoxColumn
            // 
            this.rAZAOCLIENTECRDataGridViewTextBoxColumn.DataPropertyName = "RAZAO_CLIENTE_CR";
            this.rAZAOCLIENTECRDataGridViewTextBoxColumn.HeaderText = "RAZAO_CLIENTE_CR";
            this.rAZAOCLIENTECRDataGridViewTextBoxColumn.Name = "rAZAOCLIENTECRDataGridViewTextBoxColumn";
            this.rAZAOCLIENTECRDataGridViewTextBoxColumn.ReadOnly = true;
            this.rAZAOCLIENTECRDataGridViewTextBoxColumn.Visible = false;
            // 
            // dUPLICATACRDataGridViewTextBoxColumn
            // 
            this.dUPLICATACRDataGridViewTextBoxColumn.DataPropertyName = "DUPLICATA_CR";
            this.dUPLICATACRDataGridViewTextBoxColumn.HeaderText = "DUPLICATA_CR";
            this.dUPLICATACRDataGridViewTextBoxColumn.Name = "dUPLICATACRDataGridViewTextBoxColumn";
            this.dUPLICATACRDataGridViewTextBoxColumn.ReadOnly = true;
            this.dUPLICATACRDataGridViewTextBoxColumn.Visible = false;
            // 
            // rECEBIDOCRDataGridViewTextBoxColumn
            // 
            this.rECEBIDOCRDataGridViewTextBoxColumn.DataPropertyName = "RECEBIDO_CR";
            this.rECEBIDOCRDataGridViewTextBoxColumn.HeaderText = "RECEBIDO_CR";
            this.rECEBIDOCRDataGridViewTextBoxColumn.Name = "rECEBIDOCRDataGridViewTextBoxColumn";
            this.rECEBIDOCRDataGridViewTextBoxColumn.ReadOnly = true;
            this.rECEBIDOCRDataGridViewTextBoxColumn.Visible = false;
            // 
            // cODCAIXACRDataGridViewTextBoxColumn
            // 
            this.cODCAIXACRDataGridViewTextBoxColumn.DataPropertyName = "COD_CAIXA_CR";
            this.cODCAIXACRDataGridViewTextBoxColumn.HeaderText = "COD_CAIXA_CR";
            this.cODCAIXACRDataGridViewTextBoxColumn.Name = "cODCAIXACRDataGridViewTextBoxColumn";
            this.cODCAIXACRDataGridViewTextBoxColumn.ReadOnly = true;
            this.cODCAIXACRDataGridViewTextBoxColumn.Visible = false;
            // 
            // pLANOCRDataGridViewTextBoxColumn
            // 
            this.pLANOCRDataGridViewTextBoxColumn.DataPropertyName = "PLANO_CR";
            this.pLANOCRDataGridViewTextBoxColumn.HeaderText = "PLANO_CR";
            this.pLANOCRDataGridViewTextBoxColumn.Name = "pLANOCRDataGridViewTextBoxColumn";
            this.pLANOCRDataGridViewTextBoxColumn.ReadOnly = true;
            this.pLANOCRDataGridViewTextBoxColumn.Visible = false;
            // 
            // cARTEIRACRDataGridViewTextBoxColumn
            // 
            this.cARTEIRACRDataGridViewTextBoxColumn.DataPropertyName = "CARTEIRA_CR";
            this.cARTEIRACRDataGridViewTextBoxColumn.HeaderText = "CARTEIRA_CR";
            this.cARTEIRACRDataGridViewTextBoxColumn.Name = "cARTEIRACRDataGridViewTextBoxColumn";
            this.cARTEIRACRDataGridViewTextBoxColumn.ReadOnly = true;
            this.cARTEIRACRDataGridViewTextBoxColumn.Visible = false;
            // 
            // cODPLANOCRDataGridViewTextBoxColumn
            // 
            this.cODPLANOCRDataGridViewTextBoxColumn.DataPropertyName = "COD_PLANO_CR";
            this.cODPLANOCRDataGridViewTextBoxColumn.HeaderText = "COD_PLANO_CR";
            this.cODPLANOCRDataGridViewTextBoxColumn.Name = "cODPLANOCRDataGridViewTextBoxColumn";
            this.cODPLANOCRDataGridViewTextBoxColumn.ReadOnly = true;
            this.cODPLANOCRDataGridViewTextBoxColumn.Visible = false;
            // 
            // vALORATUALIZADOCRDataGridViewTextBoxColumn
            // 
            this.vALORATUALIZADOCRDataGridViewTextBoxColumn.DataPropertyName = "VALOR_ATUALIZADO_CR";
            this.vALORATUALIZADOCRDataGridViewTextBoxColumn.HeaderText = "VALOR_ATUALIZADO_CR";
            this.vALORATUALIZADOCRDataGridViewTextBoxColumn.Name = "vALORATUALIZADOCRDataGridViewTextBoxColumn";
            this.vALORATUALIZADOCRDataGridViewTextBoxColumn.ReadOnly = true;
            this.vALORATUALIZADOCRDataGridViewTextBoxColumn.Visible = false;
            // 
            // dESCRICAOCCCRDataGridViewTextBoxColumn
            // 
            this.dESCRICAOCCCRDataGridViewTextBoxColumn.DataPropertyName = "DESCRICAO_CC_CR";
            this.dESCRICAOCCCRDataGridViewTextBoxColumn.HeaderText = "DESCRICAO_CC_CR";
            this.dESCRICAOCCCRDataGridViewTextBoxColumn.Name = "dESCRICAOCCCRDataGridViewTextBoxColumn";
            this.dESCRICAOCCCRDataGridViewTextBoxColumn.ReadOnly = true;
            this.dESCRICAOCCCRDataGridViewTextBoxColumn.Visible = false;
            // 
            // oBSERVACOESCRDataGridViewTextBoxColumn
            // 
            this.oBSERVACOESCRDataGridViewTextBoxColumn.DataPropertyName = "OBSERVACOES_CR";
            this.oBSERVACOESCRDataGridViewTextBoxColumn.HeaderText = "OBSERVACOES_CR";
            this.oBSERVACOESCRDataGridViewTextBoxColumn.Name = "oBSERVACOESCRDataGridViewTextBoxColumn";
            this.oBSERVACOESCRDataGridViewTextBoxColumn.ReadOnly = true;
            this.oBSERVACOESCRDataGridViewTextBoxColumn.Visible = false;
            // 
            // cCCRDataGridViewTextBoxColumn
            // 
            this.cCCRDataGridViewTextBoxColumn.DataPropertyName = "CC_CR";
            this.cCCRDataGridViewTextBoxColumn.HeaderText = "CC_CR";
            this.cCCRDataGridViewTextBoxColumn.Name = "cCCRDataGridViewTextBoxColumn";
            this.cCCRDataGridViewTextBoxColumn.ReadOnly = true;
            this.cCCRDataGridViewTextBoxColumn.Visible = false;
            // 
            // rEMESSACRDataGridViewTextBoxColumn
            // 
            this.rEMESSACRDataGridViewTextBoxColumn.DataPropertyName = "REMESSA_CR";
            this.rEMESSACRDataGridViewTextBoxColumn.HeaderText = "REMESSA_CR";
            this.rEMESSACRDataGridViewTextBoxColumn.Name = "rEMESSACRDataGridViewTextBoxColumn";
            this.rEMESSACRDataGridViewTextBoxColumn.ReadOnly = true;
            this.rEMESSACRDataGridViewTextBoxColumn.Visible = false;
            // 
            // dATACRIACAOCRDataGridViewTextBoxColumn
            // 
            this.dATACRIACAOCRDataGridViewTextBoxColumn.DataPropertyName = "DATA_CRIACAO_CR";
            this.dATACRIACAOCRDataGridViewTextBoxColumn.HeaderText = "DATA_CRIACAO_CR";
            this.dATACRIACAOCRDataGridViewTextBoxColumn.Name = "dATACRIACAOCRDataGridViewTextBoxColumn";
            this.dATACRIACAOCRDataGridViewTextBoxColumn.ReadOnly = true;
            this.dATACRIACAOCRDataGridViewTextBoxColumn.Visible = false;
            // 
            // rOMANEIOCRDataGridViewTextBoxColumn
            // 
            this.rOMANEIOCRDataGridViewTextBoxColumn.DataPropertyName = "ROMANEIO_CR";
            this.rOMANEIOCRDataGridViewTextBoxColumn.HeaderText = "ROMANEIO_CR";
            this.rOMANEIOCRDataGridViewTextBoxColumn.Name = "rOMANEIOCRDataGridViewTextBoxColumn";
            this.rOMANEIOCRDataGridViewTextBoxColumn.ReadOnly = true;
            this.rOMANEIOCRDataGridViewTextBoxColumn.Visible = false;
            // 
            // dATAVENCORIGINALCRDataGridViewTextBoxColumn
            // 
            this.dATAVENCORIGINALCRDataGridViewTextBoxColumn.DataPropertyName = "DATA_VENC_ORIGINAL_CR";
            this.dATAVENCORIGINALCRDataGridViewTextBoxColumn.HeaderText = "DATA_VENC_ORIGINAL_CR";
            this.dATAVENCORIGINALCRDataGridViewTextBoxColumn.Name = "dATAVENCORIGINALCRDataGridViewTextBoxColumn";
            this.dATAVENCORIGINALCRDataGridViewTextBoxColumn.ReadOnly = true;
            this.dATAVENCORIGINALCRDataGridViewTextBoxColumn.Visible = false;
            // 
            // dsContas
            // 
            this.dsContas.DataSetName = "dsContas";
            this.dsContas.Namespace = "http://www.tempuri.org/dsContas.xsd";
            this.dsContas.Tables.AddRange(new System.Data.DataTable[] {
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
            this.COD_CAIXA_CR,
            this.PLANO_CR,
            this.CARTEIRA_CR,
            this.COD_PLANO_CR,
            this.VALOR_ATUALIZADO_CR,
            this.DESCRICAO_CC_CR,
            this.OBSERVACOES_CR,
            this.CC_CR,
            this.REMESSA_CR,
            this.DATA_CRIACAO_CR,
            this.ROMANEIO_CR,
            this.DATA_VENC_ORIGINAL_CR});
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
            // PLANO_CR
            // 
            this.PLANO_CR.ColumnName = "PLANO_CR";
            this.PLANO_CR.MaxLength = 50;
            // 
            // CARTEIRA_CR
            // 
            this.CARTEIRA_CR.ColumnName = "CARTEIRA_CR";
            this.CARTEIRA_CR.MaxLength = 50;
            // 
            // COD_PLANO_CR
            // 
            this.COD_PLANO_CR.ColumnName = "COD_PLANO_CR";
            this.COD_PLANO_CR.DataType = typeof(int);
            // 
            // VALOR_ATUALIZADO_CR
            // 
            this.VALOR_ATUALIZADO_CR.ColumnName = "VALOR_ATUALIZADO_CR";
            this.VALOR_ATUALIZADO_CR.DataType = typeof(double);
            // 
            // DESCRICAO_CC_CR
            // 
            this.DESCRICAO_CC_CR.ColumnName = "DESCRICAO_CC_CR";
            this.DESCRICAO_CC_CR.MaxLength = 100;
            // 
            // OBSERVACOES_CR
            // 
            this.OBSERVACOES_CR.ColumnName = "OBSERVACOES_CR";
            this.OBSERVACOES_CR.MaxLength = 500;
            // 
            // CC_CR
            // 
            this.CC_CR.ColumnName = "CC_CR";
            this.CC_CR.DataType = typeof(int);
            // 
            // REMESSA_CR
            // 
            this.REMESSA_CR.ColumnName = "REMESSA_CR";
            this.REMESSA_CR.DataType = typeof(int);
            // 
            // DATA_CRIACAO_CR
            // 
            this.DATA_CRIACAO_CR.ColumnName = "DATA_CRIACAO_CR";
            this.DATA_CRIACAO_CR.DataType = typeof(System.DateTime);
            // 
            // ROMANEIO_CR
            // 
            this.ROMANEIO_CR.ColumnName = "ROMANEIO_CR";
            this.ROMANEIO_CR.DataType = typeof(int);
            // 
            // DATA_VENC_ORIGINAL_CR
            // 
            this.DATA_VENC_ORIGINAL_CR.ColumnName = "DATA_VENC_ORIGINAL_CR";
            this.DATA_VENC_ORIGINAL_CR.DataType = typeof(System.DateTime);
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label79.ForeColor = System.Drawing.Color.Red;
            this.label79.Location = new System.Drawing.Point(54, 5);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(242, 25);
            this.label79.TabIndex = 53;
            this.label79.Text = "CONTAS A RECEBER";
            // 
            // datContas
            // 
            this.datContas.DeleteCommand = this.fbCommand29;
            this.datContas.InsertCommand = this.fbCommand27;
            this.datContas.SelectCommand = this.fbCommand26;
            this.datContas.UpdateCommand = this.fbCommand28;
            // 
            // fbCommand29
            // 
            this.fbCommand29.CommandTimeout = 30;
            // 
            // fbCommand27
            // 
            this.fbCommand27.CommandTimeout = 30;
            // 
            // fbCommand26
            // 
            this.fbCommand26.CommandText = "select * from contas_a_receber";
            this.fbCommand26.CommandTimeout = 30;
            this.fbCommand26.Connection = this.fbConnection1;
            // 
            // fbCommand28
            // 
            this.fbCommand28.CommandTimeout = 30;
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label80.Location = new System.Drawing.Point(178, 351);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(61, 16);
            this.label80.TabIndex = 54;
            this.label80.Text = "TOTAL:";
            // 
            // tb_total
            // 
            this.tb_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_total.Location = new System.Drawing.Point(245, 348);
            this.tb_total.Name = "tb_total";
            this.tb_total.ReadOnly = true;
            this.tb_total.Size = new System.Drawing.Size(100, 22);
            this.tb_total.TabIndex = 55;
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.TIPO_CLIENTE", true));
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Items.AddRange(new object[] {
            "",
            "INDUSTRIALIZAÇÃO",
            "CONSUMO",
            "REVENDA"});
            this.comboBoxTipo.Location = new System.Drawing.Point(775, 81);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(181, 21);
            this.comboBoxTipo.TabIndex = 56;
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.Location = new System.Drawing.Point(703, 84);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(31, 13);
            this.label85.TabIndex = 57;
            this.label85.Text = "Tipo:";
            // 
            // datItens_tp
            // 
            this.datItens_tp.DeleteCommand = this.fbCommand33;
            this.datItens_tp.InsertCommand = this.fbCommand31;
            this.datItens_tp.SelectCommand = this.fbCommand30;
            this.datItens_tp.UpdateCommand = this.fbCommand32;
            // 
            // fbCommand33
            // 
            this.fbCommand33.CommandTimeout = 30;
            // 
            // fbCommand31
            // 
            this.fbCommand31.CommandTimeout = 30;
            // 
            // fbCommand30
            // 
            this.fbCommand30.CommandText = "select * from itens_tp";
            this.fbCommand30.CommandTimeout = 30;
            this.fbCommand30.Connection = this.fbConnection1;
            // 
            // fbCommand32
            // 
            this.fbCommand32.CommandTimeout = 30;
            // 
            // cbItens_tp
            // 
            this.cbItens_tp.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbItens_tp.DataAdapter = this.datItens_tp;
            this.cbItens_tp.QuotePrefix = "\"";
            this.cbItens_tp.QuoteSuffix = "\"";
            // 
            // fbCommand34
            // 
            this.fbCommand34.CommandText = "SELECT * FROM ITEMPED";
            this.fbCommand34.CommandTimeout = 30;
            this.fbCommand34.Connection = this.fbConnection1;
            // 
            // fbCommand35
            // 
            this.fbCommand35.CommandTimeout = 30;
            // 
            // fbCommand36
            // 
            this.fbCommand36.CommandTimeout = 30;
            // 
            // fbCommand37
            // 
            this.fbCommand37.CommandTimeout = 30;
            // 
            // fbCommand38
            // 
            this.fbCommand38.CommandText = "select * from itemped";
            this.fbCommand38.CommandTimeout = 30;
            this.fbCommand38.Connection = this.fbConnection1;
            // 
            // fbCommand39
            // 
            this.fbCommand39.CommandTimeout = 30;
            // 
            // fbCommand40
            // 
            this.fbCommand40.CommandTimeout = 30;
            // 
            // fbCommand41
            // 
            this.fbCommand41.CommandTimeout = 30;
            // 
            // datItemPedAntigo
            // 
            this.datItemPedAntigo.DeleteCommand = this.fbCommand45;
            this.datItemPedAntigo.InsertCommand = this.fbCommand43;
            this.datItemPedAntigo.SelectCommand = this.fbCommand42;
            this.datItemPedAntigo.UpdateCommand = this.fbCommand44;
            // 
            // fbCommand45
            // 
            this.fbCommand45.CommandTimeout = 30;
            // 
            // fbCommand43
            // 
            this.fbCommand43.CommandTimeout = 30;
            // 
            // fbCommand42
            // 
            this.fbCommand42.CommandText = "select * from itemped";
            this.fbCommand42.CommandTimeout = 30;
            this.fbCommand42.Connection = this.fbConnection1;
            // 
            // fbCommand44
            // 
            this.fbCommand44.CommandTimeout = 30;
            // 
            // panelContasaReceber
            // 
            this.panelContasaReceber.Controls.Add(this.tb_total);
            this.panelContasaReceber.Controls.Add(this.label80);
            this.panelContasaReceber.Controls.Add(this.label79);
            this.panelContasaReceber.Controls.Add(this.dgvContas);
            this.panelContasaReceber.Location = new System.Drawing.Point(694, 111);
            this.panelContasaReceber.Name = "panelContasaReceber";
            this.panelContasaReceber.Size = new System.Drawing.Size(356, 379);
            this.panelContasaReceber.TabIndex = 58;
            // 
            // datPedidos_venda
            // 
            this.datPedidos_venda.DeleteCommand = this.fbCommand49;
            this.datPedidos_venda.InsertCommand = this.fbCommand47;
            this.datPedidos_venda.SelectCommand = this.fbCommand46;
            this.datPedidos_venda.UpdateCommand = this.fbCommand48;
            // 
            // fbCommand49
            // 
            this.fbCommand49.CommandTimeout = 30;
            // 
            // fbCommand47
            // 
            this.fbCommand47.CommandTimeout = 30;
            // 
            // fbCommand46
            // 
            this.fbCommand46.CommandText = "select * from pedidos_venda";
            this.fbCommand46.CommandTimeout = 30;
            this.fbCommand46.Connection = this.fbConnection1;
            // 
            // fbCommand48
            // 
            this.fbCommand48.CommandTimeout = 30;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvValor_cliente);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.button12);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(668, 325);
            this.tabPage2.TabIndex = 6;
            this.tabPage2.Text = "Valores Orçamento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvValor_cliente
            // 
            this.dgvValor_cliente.AllowUserToAddRows = false;
            this.dgvValor_cliente.AutoGenerateColumns = false;
            this.dgvValor_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvValor_cliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oPERACAOVOCDataGridViewTextBoxColumn,
            this.SEQUENCIA_OPER_VOC,
            this.vALORHORAVOCDataGridViewTextBoxColumn,
            this.VALOR_HORA_MOLDE_VOC,
            this.VALOR_HORA_PECA_VOC,
            this.cNPJCLIENTEVOCDataGridViewTextBoxColumn});
            this.dgvValor_cliente.DataMember = "VALOR_OPERACAO_CLIENTE";
            this.dgvValor_cliente.DataSource = this.dsValor_operacao_cliente;
            this.dgvValor_cliente.Location = new System.Drawing.Point(8, 38);
            this.dgvValor_cliente.Name = "dgvValor_cliente";
            this.dgvValor_cliente.Size = new System.Drawing.Size(471, 191);
            this.dgvValor_cliente.TabIndex = 77;
            // 
            // oPERACAOVOCDataGridViewTextBoxColumn
            // 
            this.oPERACAOVOCDataGridViewTextBoxColumn.DataPropertyName = "OPERACAO_VOC";
            this.oPERACAOVOCDataGridViewTextBoxColumn.HeaderText = "Operação";
            this.oPERACAOVOCDataGridViewTextBoxColumn.Name = "oPERACAOVOCDataGridViewTextBoxColumn";
            this.oPERACAOVOCDataGridViewTextBoxColumn.Width = 150;
            // 
            // SEQUENCIA_OPER_VOC
            // 
            this.SEQUENCIA_OPER_VOC.DataPropertyName = "SEQUENCIA_OPER_VOC";
            this.SEQUENCIA_OPER_VOC.HeaderText = "Sequência";
            this.SEQUENCIA_OPER_VOC.Name = "SEQUENCIA_OPER_VOC";
            this.SEQUENCIA_OPER_VOC.Width = 75;
            // 
            // vALORHORAVOCDataGridViewTextBoxColumn
            // 
            this.vALORHORAVOCDataGridViewTextBoxColumn.DataPropertyName = "VALOR_HORA_VOC";
            this.vALORHORAVOCDataGridViewTextBoxColumn.HeaderText = "Valor Hora";
            this.vALORHORAVOCDataGridViewTextBoxColumn.Name = "vALORHORAVOCDataGridViewTextBoxColumn";
            this.vALORHORAVOCDataGridViewTextBoxColumn.Visible = false;
            // 
            // VALOR_HORA_MOLDE_VOC
            // 
            this.VALOR_HORA_MOLDE_VOC.DataPropertyName = "VALOR_HORA_MOLDE_VOC";
            this.VALOR_HORA_MOLDE_VOC.HeaderText = "Valor Hora Molde";
            this.VALOR_HORA_MOLDE_VOC.Name = "VALOR_HORA_MOLDE_VOC";
            this.VALOR_HORA_MOLDE_VOC.Visible = false;
            // 
            // VALOR_HORA_PECA_VOC
            // 
            this.VALOR_HORA_PECA_VOC.DataPropertyName = "VALOR_HORA_PECA_VOC";
            this.VALOR_HORA_PECA_VOC.HeaderText = "Valor Hora Peça";
            this.VALOR_HORA_PECA_VOC.Name = "VALOR_HORA_PECA_VOC";
            // 
            // cNPJCLIENTEVOCDataGridViewTextBoxColumn
            // 
            this.cNPJCLIENTEVOCDataGridViewTextBoxColumn.DataPropertyName = "CNPJ_CLIENTE_VOC";
            this.cNPJCLIENTEVOCDataGridViewTextBoxColumn.HeaderText = "CNPJ_CLIENTE_VOC";
            this.cNPJCLIENTEVOCDataGridViewTextBoxColumn.Name = "cNPJCLIENTEVOCDataGridViewTextBoxColumn";
            this.cNPJCLIENTEVOCDataGridViewTextBoxColumn.Visible = false;
            // 
            // dsValor_operacao_cliente
            // 
            this.dsValor_operacao_cliente.DataSetName = "dsValor_operacao_cliente";
            this.dsValor_operacao_cliente.Namespace = "http://www.tempuri.org/dsValor_operacao_cliente.xsd";
            this.dsValor_operacao_cliente.Tables.AddRange(new System.Data.DataTable[] {
            this.VALOR_OPERACAO_CLIENTE});
            // 
            // VALOR_OPERACAO_CLIENTE
            // 
            this.VALOR_OPERACAO_CLIENTE.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_VOC,
            this.OPERACAO_VOC,
            this.VALOR_HORA_VOC,
            this.CNPJ_CLIENTE_VOC,
            this.dataColumn49,
            this.dataColumn50,
            this.dataColumn51});
            this.VALOR_OPERACAO_CLIENTE.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_VOC"}, true)});
            this.VALOR_OPERACAO_CLIENTE.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_VOC};
            this.VALOR_OPERACAO_CLIENTE.TableName = "VALOR_OPERACAO_CLIENTE";
            // 
            // COD_VOC
            // 
            this.COD_VOC.AllowDBNull = false;
            this.COD_VOC.ColumnName = "COD_VOC";
            this.COD_VOC.DataType = typeof(int);
            // 
            // OPERACAO_VOC
            // 
            this.OPERACAO_VOC.ColumnName = "OPERACAO_VOC";
            this.OPERACAO_VOC.MaxLength = 200;
            // 
            // VALOR_HORA_VOC
            // 
            this.VALOR_HORA_VOC.ColumnName = "VALOR_HORA_VOC";
            this.VALOR_HORA_VOC.DataType = typeof(double);
            // 
            // CNPJ_CLIENTE_VOC
            // 
            this.CNPJ_CLIENTE_VOC.ColumnName = "CNPJ_CLIENTE_VOC";
            this.CNPJ_CLIENTE_VOC.MaxLength = 100;
            // 
            // dataColumn49
            // 
            this.dataColumn49.ColumnName = "SEQUENCIA_OPER_VOC";
            this.dataColumn49.DataType = typeof(int);
            // 
            // dataColumn50
            // 
            this.dataColumn50.ColumnName = "VALOR_HORA_MOLDE_VOC";
            this.dataColumn50.DataType = typeof(double);
            // 
            // dataColumn51
            // 
            this.dataColumn51.ColumnName = "VALOR_HORA_PECA_VOC";
            this.dataColumn51.DataType = typeof(double);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.textBox52);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.textBox53);
            this.panel3.Controls.Add(this.label89);
            this.panel3.Controls.Add(this.textBox54);
            this.panel3.Controls.Add(this.label90);
            this.panel3.Location = new System.Drawing.Point(8, 232);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(216, 85);
            this.panel3.TabIndex = 76;
            // 
            // textBox52
            // 
            this.textBox52.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.PORC_BENEFICIAMENTO_CLIENTE", true));
            this.textBox52.Location = new System.Drawing.Point(141, 60);
            this.textBox52.Name = "textBox52";
            this.textBox52.Size = new System.Drawing.Size(68, 20);
            this.textBox52.TabIndex = 73;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 63);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(94, 13);
            this.label20.TabIndex = 74;
            this.label20.Text = "% Industrialização:";
            // 
            // textBox53
            // 
            this.textBox53.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.PORC_PRESTACAO_SERV_CLIENTE", true));
            this.textBox53.Location = new System.Drawing.Point(141, 34);
            this.textBox53.Name = "textBox53";
            this.textBox53.Size = new System.Drawing.Size(68, 20);
            this.textBox53.TabIndex = 70;
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.label89.Location = new System.Drawing.Point(6, 37);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(128, 13);
            this.label89.TabIndex = 72;
            this.label89.Text = "% Prestação de Serviços:";
            // 
            // textBox54
            // 
            this.textBox54.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.PORC_VENDA_CLIENTE", true));
            this.textBox54.Location = new System.Drawing.Point(141, 8);
            this.textBox54.Name = "textBox54";
            this.textBox54.Size = new System.Drawing.Size(68, 20);
            this.textBox54.TabIndex = 69;
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.Location = new System.Drawing.Point(6, 11);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(57, 13);
            this.label90.TabIndex = 71;
            this.label90.Text = "% Vendas:";
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(8, 9);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(105, 23);
            this.button12.TabIndex = 2;
            this.button12.Text = "Inserir Operação";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvPedidos_venda);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(668, 325);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "Pedidos de Venda";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvPedidos_venda
            // 
            this.dgvPedidos_venda.AllowUserToAddRows = false;
            this.dgvPedidos_venda.AutoGenerateColumns = false;
            this.dgvPedidos_venda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos_venda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bAIXADOESTOQUEPEDVENDADataGridViewTextBoxColumn,
            this.rAZAOEMISSORPEDVENDADataGridViewTextBoxColumn,
            this.col_cod_interno,
            this.nPEDVENDADataGridViewTextBoxColumn,
            this.dATAPEDVENDADataGridViewTextBoxColumn,
            this.dATABAIXAPEDVENDADataGridViewTextBoxColumn,
            this.cONDPGTOPEDVENDADataGridViewTextBoxColumn,
            this.vALORTOTALPRODPEDVENDADataGridViewTextBoxColumn,
            this.vALORTOTALPEDVENDADataGridViewTextBoxColumn,
            this.oBSPEDVENDADataGridViewTextBoxColumn,
            this.vENDEDORPEDVENDADataGridViewTextBoxColumn});
            this.dgvPedidos_venda.DataMember = "PEDIDOS_VENDA";
            this.dgvPedidos_venda.DataSource = this.dsPedidos_venda;
            this.dgvPedidos_venda.Location = new System.Drawing.Point(7, 19);
            this.dgvPedidos_venda.Name = "dgvPedidos_venda";
            this.dgvPedidos_venda.Size = new System.Drawing.Size(646, 289);
            this.dgvPedidos_venda.TabIndex = 0;
            this.dgvPedidos_venda.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedidos_venda_CellDoubleClick);
            // 
            // bAIXADOESTOQUEPEDVENDADataGridViewTextBoxColumn
            // 
            this.bAIXADOESTOQUEPEDVENDADataGridViewTextBoxColumn.DataPropertyName = "BAIXADO_ESTOQUE_PED_VENDA";
            this.bAIXADOESTOQUEPEDVENDADataGridViewTextBoxColumn.FalseValue = "0";
            this.bAIXADOESTOQUEPEDVENDADataGridViewTextBoxColumn.HeaderText = "Fechado";
            this.bAIXADOESTOQUEPEDVENDADataGridViewTextBoxColumn.IndeterminateValue = "0";
            this.bAIXADOESTOQUEPEDVENDADataGridViewTextBoxColumn.Name = "bAIXADOESTOQUEPEDVENDADataGridViewTextBoxColumn";
            this.bAIXADOESTOQUEPEDVENDADataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.bAIXADOESTOQUEPEDVENDADataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.bAIXADOESTOQUEPEDVENDADataGridViewTextBoxColumn.TrueValue = "1";
            this.bAIXADOESTOQUEPEDVENDADataGridViewTextBoxColumn.Width = 30;
            // 
            // rAZAOEMISSORPEDVENDADataGridViewTextBoxColumn
            // 
            this.rAZAOEMISSORPEDVENDADataGridViewTextBoxColumn.DataPropertyName = "RAZAO_EMISSOR_PED_VENDA";
            this.rAZAOEMISSORPEDVENDADataGridViewTextBoxColumn.HeaderText = "Emissor";
            this.rAZAOEMISSORPEDVENDADataGridViewTextBoxColumn.Name = "rAZAOEMISSORPEDVENDADataGridViewTextBoxColumn";
            // 
            // col_cod_interno
            // 
            this.col_cod_interno.DataPropertyName = "COD_PED_VENDA";
            this.col_cod_interno.HeaderText = "Cód. Interno";
            this.col_cod_interno.Name = "col_cod_interno";
            this.col_cod_interno.Width = 70;
            // 
            // nPEDVENDADataGridViewTextBoxColumn
            // 
            this.nPEDVENDADataGridViewTextBoxColumn.DataPropertyName = "N_PED_VENDA";
            this.nPEDVENDADataGridViewTextBoxColumn.HeaderText = "No Pedido";
            this.nPEDVENDADataGridViewTextBoxColumn.Name = "nPEDVENDADataGridViewTextBoxColumn";
            this.nPEDVENDADataGridViewTextBoxColumn.Width = 60;
            // 
            // dATAPEDVENDADataGridViewTextBoxColumn
            // 
            this.dATAPEDVENDADataGridViewTextBoxColumn.DataPropertyName = "DATA_PED_VENDA";
            this.dATAPEDVENDADataGridViewTextBoxColumn.HeaderText = "Data Pedido";
            this.dATAPEDVENDADataGridViewTextBoxColumn.Name = "dATAPEDVENDADataGridViewTextBoxColumn";
            this.dATAPEDVENDADataGridViewTextBoxColumn.Width = 70;
            // 
            // dATABAIXAPEDVENDADataGridViewTextBoxColumn
            // 
            this.dATABAIXAPEDVENDADataGridViewTextBoxColumn.DataPropertyName = "DATA_BAIXA_PED_VENDA";
            this.dATABAIXAPEDVENDADataGridViewTextBoxColumn.HeaderText = "Data Baixa";
            this.dATABAIXAPEDVENDADataGridViewTextBoxColumn.Name = "dATABAIXAPEDVENDADataGridViewTextBoxColumn";
            this.dATABAIXAPEDVENDADataGridViewTextBoxColumn.Width = 70;
            // 
            // cONDPGTOPEDVENDADataGridViewTextBoxColumn
            // 
            this.cONDPGTOPEDVENDADataGridViewTextBoxColumn.DataPropertyName = "COND_PGTO_PED_VENDA";
            this.cONDPGTOPEDVENDADataGridViewTextBoxColumn.HeaderText = "Forma Pgto";
            this.cONDPGTOPEDVENDADataGridViewTextBoxColumn.Name = "cONDPGTOPEDVENDADataGridViewTextBoxColumn";
            // 
            // vALORTOTALPRODPEDVENDADataGridViewTextBoxColumn
            // 
            this.vALORTOTALPRODPEDVENDADataGridViewTextBoxColumn.DataPropertyName = "VALOR_TOTAL_PROD_PED_VENDA";
            this.vALORTOTALPRODPEDVENDADataGridViewTextBoxColumn.HeaderText = "Valor Prod.";
            this.vALORTOTALPRODPEDVENDADataGridViewTextBoxColumn.Name = "vALORTOTALPRODPEDVENDADataGridViewTextBoxColumn";
            this.vALORTOTALPRODPEDVENDADataGridViewTextBoxColumn.Width = 70;
            // 
            // vALORTOTALPEDVENDADataGridViewTextBoxColumn
            // 
            this.vALORTOTALPEDVENDADataGridViewTextBoxColumn.DataPropertyName = "VALOR_TOTAL_PED_VENDA";
            this.vALORTOTALPEDVENDADataGridViewTextBoxColumn.HeaderText = "Valor Pedido";
            this.vALORTOTALPEDVENDADataGridViewTextBoxColumn.Name = "vALORTOTALPEDVENDADataGridViewTextBoxColumn";
            this.vALORTOTALPEDVENDADataGridViewTextBoxColumn.Width = 70;
            // 
            // oBSPEDVENDADataGridViewTextBoxColumn
            // 
            this.oBSPEDVENDADataGridViewTextBoxColumn.DataPropertyName = "OBS_PED_VENDA";
            this.oBSPEDVENDADataGridViewTextBoxColumn.HeaderText = "Obs";
            this.oBSPEDVENDADataGridViewTextBoxColumn.Name = "oBSPEDVENDADataGridViewTextBoxColumn";
            // 
            // vENDEDORPEDVENDADataGridViewTextBoxColumn
            // 
            this.vENDEDORPEDVENDADataGridViewTextBoxColumn.DataPropertyName = "VENDEDOR_PED_VENDA";
            this.vENDEDORPEDVENDADataGridViewTextBoxColumn.HeaderText = "Vendedor";
            this.vENDEDORPEDVENDADataGridViewTextBoxColumn.Name = "vENDEDORPEDVENDADataGridViewTextBoxColumn";
            // 
            // tabPageVendas
            // 
            this.tabPageVendas.Controls.Add(this.label88);
            this.tabPageVendas.Controls.Add(this.label87);
            this.tabPageVendas.Controls.Add(this.label86);
            this.tabPageVendas.Controls.Add(this.tbFormaPgto);
            this.tabPageVendas.Controls.Add(this.tbNPedido);
            this.tabPageVendas.Controls.Add(this.tbDescricaoProduto);
            this.tabPageVendas.Controls.Add(this.dgvItemPedAntigo);
            this.tabPageVendas.Location = new System.Drawing.Point(4, 22);
            this.tabPageVendas.Name = "tabPageVendas";
            this.tabPageVendas.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPageVendas.Size = new System.Drawing.Size(668, 325);
            this.tabPageVendas.TabIndex = 4;
            this.tabPageVendas.Text = "Vendas Sistema Antigo";
            this.tabPageVendas.UseVisualStyleBackColor = true;
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.Location = new System.Drawing.Point(307, 4);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(95, 13);
            this.label88.TabIndex = 6;
            this.label88.Text = "Descrição Produto";
            this.label88.Visible = false;
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.Location = new System.Drawing.Point(140, 4);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(61, 13);
            this.label87.TabIndex = 5;
            this.label87.Text = "Forma Pgto";
            this.label87.Visible = false;
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.Location = new System.Drawing.Point(19, 4);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(49, 13);
            this.label86.TabIndex = 4;
            this.label86.Text = "No. Ped.";
            this.label86.Visible = false;
            // 
            // tbFormaPgto
            // 
            this.tbFormaPgto.Location = new System.Drawing.Point(137, 20);
            this.tbFormaPgto.Name = "tbFormaPgto";
            this.tbFormaPgto.Size = new System.Drawing.Size(102, 20);
            this.tbFormaPgto.TabIndex = 3;
            this.tbFormaPgto.Visible = false;
            this.tbFormaPgto.TextChanged += new System.EventHandler(this.tbFormaPgto_TextChanged);
            // 
            // tbNPedido
            // 
            this.tbNPedido.Location = new System.Drawing.Point(15, 20);
            this.tbNPedido.Name = "tbNPedido";
            this.tbNPedido.Size = new System.Drawing.Size(56, 20);
            this.tbNPedido.TabIndex = 2;
            this.tbNPedido.Visible = false;
            this.tbNPedido.TextChanged += new System.EventHandler(this.tbNPedido_TextChanged);
            // 
            // tbDescricaoProduto
            // 
            this.tbDescricaoProduto.Location = new System.Drawing.Point(304, 20);
            this.tbDescricaoProduto.Name = "tbDescricaoProduto";
            this.tbDescricaoProduto.Size = new System.Drawing.Size(203, 20);
            this.tbDescricaoProduto.TabIndex = 1;
            this.tbDescricaoProduto.Visible = false;
            this.tbDescricaoProduto.TextChanged += new System.EventHandler(this.tbDescricaoProduto_TextChanged);
            // 
            // dgvItemPedAntigo
            // 
            this.dgvItemPedAntigo.AutoGenerateColumns = false;
            this.dgvItemPedAntigo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemPedAntigo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pCNRPEDDataGridViewTextBoxColumn,
            this.pCEMISSAODataGridViewTextBoxColumn,
            this.fPDESCRDataGridViewTextBoxColumn,
            this.pEDPRODDataGridViewTextBoxColumn,
            this.dESCRICAOPRODDataGridViewTextBoxColumn,
            this.pEDVLUNIDataGridViewTextBoxColumn,
            this.qTVENDDataGridViewTextBoxColumn,
            this.pCCLIDataGridViewTextBoxColumn,
            this.rAZAOCLIDataGridViewTextBoxColumn,
            this.vLTOTALDataGridViewTextBoxColumn});
            this.dgvItemPedAntigo.DataMember = "ITEMPED";
            this.dgvItemPedAntigo.DataSource = this.dsItemPedAntigo;
            this.dgvItemPedAntigo.Location = new System.Drawing.Point(6, 46);
            this.dgvItemPedAntigo.Name = "dgvItemPedAntigo";
            this.dgvItemPedAntigo.RowHeadersWidth = 10;
            this.dgvItemPedAntigo.Size = new System.Drawing.Size(656, 273);
            this.dgvItemPedAntigo.TabIndex = 0;
            // 
            // pCNRPEDDataGridViewTextBoxColumn
            // 
            this.pCNRPEDDataGridViewTextBoxColumn.DataPropertyName = "PC_NRPED";
            this.pCNRPEDDataGridViewTextBoxColumn.HeaderText = "No. Pedido";
            this.pCNRPEDDataGridViewTextBoxColumn.Name = "pCNRPEDDataGridViewTextBoxColumn";
            this.pCNRPEDDataGridViewTextBoxColumn.Width = 50;
            // 
            // pCEMISSAODataGridViewTextBoxColumn
            // 
            this.pCEMISSAODataGridViewTextBoxColumn.DataPropertyName = "PC_EMISSAO";
            this.pCEMISSAODataGridViewTextBoxColumn.HeaderText = "Data";
            this.pCEMISSAODataGridViewTextBoxColumn.Name = "pCEMISSAODataGridViewTextBoxColumn";
            this.pCEMISSAODataGridViewTextBoxColumn.Width = 70;
            // 
            // fPDESCRDataGridViewTextBoxColumn
            // 
            this.fPDESCRDataGridViewTextBoxColumn.DataPropertyName = "FP_DESCR";
            this.fPDESCRDataGridViewTextBoxColumn.HeaderText = "Forma Pgto";
            this.fPDESCRDataGridViewTextBoxColumn.Name = "fPDESCRDataGridViewTextBoxColumn";
            // 
            // pEDPRODDataGridViewTextBoxColumn
            // 
            this.pEDPRODDataGridViewTextBoxColumn.DataPropertyName = "PEDPROD";
            this.pEDPRODDataGridViewTextBoxColumn.HeaderText = "Cód. Produto";
            this.pEDPRODDataGridViewTextBoxColumn.Name = "pEDPRODDataGridViewTextBoxColumn";
            this.pEDPRODDataGridViewTextBoxColumn.Width = 70;
            // 
            // dESCRICAOPRODDataGridViewTextBoxColumn
            // 
            this.dESCRICAOPRODDataGridViewTextBoxColumn.DataPropertyName = "DESCRICAO_PROD";
            this.dESCRICAOPRODDataGridViewTextBoxColumn.HeaderText = "Descrição Produto";
            this.dESCRICAOPRODDataGridViewTextBoxColumn.Name = "dESCRICAOPRODDataGridViewTextBoxColumn";
            this.dESCRICAOPRODDataGridViewTextBoxColumn.Width = 200;
            // 
            // pEDVLUNIDataGridViewTextBoxColumn
            // 
            this.pEDVLUNIDataGridViewTextBoxColumn.DataPropertyName = "PEDVLUNI";
            this.pEDVLUNIDataGridViewTextBoxColumn.HeaderText = "Valor Unit.";
            this.pEDVLUNIDataGridViewTextBoxColumn.Name = "pEDVLUNIDataGridViewTextBoxColumn";
            this.pEDVLUNIDataGridViewTextBoxColumn.Width = 50;
            // 
            // qTVENDDataGridViewTextBoxColumn
            // 
            this.qTVENDDataGridViewTextBoxColumn.DataPropertyName = "QT_VEND";
            this.qTVENDDataGridViewTextBoxColumn.HeaderText = "Qtde";
            this.qTVENDDataGridViewTextBoxColumn.Name = "qTVENDDataGridViewTextBoxColumn";
            this.qTVENDDataGridViewTextBoxColumn.Width = 40;
            // 
            // pCCLIDataGridViewTextBoxColumn
            // 
            this.pCCLIDataGridViewTextBoxColumn.DataPropertyName = "PC_CLI";
            this.pCCLIDataGridViewTextBoxColumn.HeaderText = "PC_CLI";
            this.pCCLIDataGridViewTextBoxColumn.Name = "pCCLIDataGridViewTextBoxColumn";
            this.pCCLIDataGridViewTextBoxColumn.Visible = false;
            // 
            // rAZAOCLIDataGridViewTextBoxColumn
            // 
            this.rAZAOCLIDataGridViewTextBoxColumn.DataPropertyName = "RAZAO_CLI";
            this.rAZAOCLIDataGridViewTextBoxColumn.HeaderText = "RAZAO_CLI";
            this.rAZAOCLIDataGridViewTextBoxColumn.Name = "rAZAOCLIDataGridViewTextBoxColumn";
            this.rAZAOCLIDataGridViewTextBoxColumn.Visible = false;
            // 
            // vLTOTALDataGridViewTextBoxColumn
            // 
            this.vLTOTALDataGridViewTextBoxColumn.DataPropertyName = "VL_TOTAL";
            this.vLTOTALDataGridViewTextBoxColumn.HeaderText = "Valor Total";
            this.vLTOTALDataGridViewTextBoxColumn.Name = "vLTOTALDataGridViewTextBoxColumn";
            this.vLTOTALDataGridViewTextBoxColumn.Width = 70;
            // 
            // tabPageTabelaPrecos
            // 
            this.tabPageTabelaPrecos.Controls.Add(this.button11);
            this.tabPageTabelaPrecos.Controls.Add(this.button10);
            this.tabPageTabelaPrecos.Controls.Add(this.dgvItens_tp);
            this.tabPageTabelaPrecos.Controls.Add(this.button9);
            this.tabPageTabelaPrecos.Location = new System.Drawing.Point(4, 22);
            this.tabPageTabelaPrecos.Name = "tabPageTabelaPrecos";
            this.tabPageTabelaPrecos.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPageTabelaPrecos.Size = new System.Drawing.Size(668, 325);
            this.tabPageTabelaPrecos.TabIndex = 3;
            this.tabPageTabelaPrecos.Text = "Tabela de Preços";
            this.tabPageTabelaPrecos.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(300, 6);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(140, 23);
            this.button11.TabIndex = 3;
            this.button11.Text = "Copiar Tabela";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(153, 6);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(140, 23);
            this.button10.TabIndex = 2;
            this.button10.Text = "Criar Novo Item";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // dgvItens_tp
            // 
            this.dgvItens_tp.AllowUserToAddRows = false;
            this.dgvItens_tp.AutoGenerateColumns = false;
            this.dgvItens_tp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens_tp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODITEMTPDataGridViewTextBoxColumn,
            this.cODTABELAITEMTPDataGridViewTextBoxColumn,
            this.cODPRODUTOITEMTPDataGridViewTextBoxColumn,
            this.dESCRICAOPRODUTOITEMTPDataGridViewTextBoxColumn,
            this.pRECOPRODUTOITEMTPDataGridViewTextBoxColumn,
            this.pRECOMINIMOITEMTPDataGridViewTextBoxColumn});
            this.dgvItens_tp.DataMember = "ITENS_TP";
            this.dgvItens_tp.DataSource = this.dsItens_tp;
            this.dgvItens_tp.Location = new System.Drawing.Point(6, 35);
            this.dgvItens_tp.Name = "dgvItens_tp";
            this.dgvItens_tp.Size = new System.Drawing.Size(489, 284);
            this.dgvItens_tp.TabIndex = 1;
            // 
            // cODITEMTPDataGridViewTextBoxColumn
            // 
            this.cODITEMTPDataGridViewTextBoxColumn.DataPropertyName = "COD_ITEM_TP";
            this.cODITEMTPDataGridViewTextBoxColumn.HeaderText = "COD_ITEM_TP";
            this.cODITEMTPDataGridViewTextBoxColumn.Name = "cODITEMTPDataGridViewTextBoxColumn";
            this.cODITEMTPDataGridViewTextBoxColumn.Visible = false;
            // 
            // cODTABELAITEMTPDataGridViewTextBoxColumn
            // 
            this.cODTABELAITEMTPDataGridViewTextBoxColumn.DataPropertyName = "COD_TABELA_ITEM_TP";
            this.cODTABELAITEMTPDataGridViewTextBoxColumn.HeaderText = "COD_TABELA_ITEM_TP";
            this.cODTABELAITEMTPDataGridViewTextBoxColumn.Name = "cODTABELAITEMTPDataGridViewTextBoxColumn";
            this.cODTABELAITEMTPDataGridViewTextBoxColumn.Visible = false;
            // 
            // cODPRODUTOITEMTPDataGridViewTextBoxColumn
            // 
            this.cODPRODUTOITEMTPDataGridViewTextBoxColumn.DataPropertyName = "COD_PRODUTO_ITEM_TP";
            this.cODPRODUTOITEMTPDataGridViewTextBoxColumn.HeaderText = "Cód. Produto";
            this.cODPRODUTOITEMTPDataGridViewTextBoxColumn.Name = "cODPRODUTOITEMTPDataGridViewTextBoxColumn";
            this.cODPRODUTOITEMTPDataGridViewTextBoxColumn.Width = 70;
            // 
            // dESCRICAOPRODUTOITEMTPDataGridViewTextBoxColumn
            // 
            this.dESCRICAOPRODUTOITEMTPDataGridViewTextBoxColumn.DataPropertyName = "DESCRICAO_PRODUTO_ITEM_TP";
            this.dESCRICAOPRODUTOITEMTPDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.dESCRICAOPRODUTOITEMTPDataGridViewTextBoxColumn.Name = "dESCRICAOPRODUTOITEMTPDataGridViewTextBoxColumn";
            this.dESCRICAOPRODUTOITEMTPDataGridViewTextBoxColumn.Width = 150;
            // 
            // pRECOPRODUTOITEMTPDataGridViewTextBoxColumn
            // 
            this.pRECOPRODUTOITEMTPDataGridViewTextBoxColumn.DataPropertyName = "PRECO_PRODUTO_ITEM_TP";
            this.pRECOPRODUTOITEMTPDataGridViewTextBoxColumn.HeaderText = "Preço Produto";
            this.pRECOPRODUTOITEMTPDataGridViewTextBoxColumn.Name = "pRECOPRODUTOITEMTPDataGridViewTextBoxColumn";
            // 
            // pRECOMINIMOITEMTPDataGridViewTextBoxColumn
            // 
            this.pRECOMINIMOITEMTPDataGridViewTextBoxColumn.DataPropertyName = "PRECO_MINIMO_ITEM_TP";
            this.pRECOMINIMOITEMTPDataGridViewTextBoxColumn.HeaderText = "Preço Minimo";
            this.pRECOMINIMOITEMTPDataGridViewTextBoxColumn.Name = "pRECOMINIMOITEMTPDataGridViewTextBoxColumn";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(6, 6);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(140, 23);
            this.button9.TabIndex = 0;
            this.button9.Text = "Criar Tabela de Preços";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // tabPageOutros
            // 
            this.tabPageOutros.Controls.Add(this.panel2);
            this.tabPageOutros.Controls.Add(this.radioButton2);
            this.tabPageOutros.Controls.Add(this.radioButton1);
            this.tabPageOutros.Controls.Add(this.textBox51);
            this.tabPageOutros.Controls.Add(this.tb_dia_visita);
            this.tabPageOutros.Controls.Add(this.textBox19);
            this.tabPageOutros.Controls.Add(this.textBox18);
            this.tabPageOutros.Controls.Add(this.textBox17);
            this.tabPageOutros.Controls.Add(this.label82);
            this.tabPageOutros.Controls.Add(this.button7);
            this.tabPageOutros.Controls.Add(this.label74);
            this.tabPageOutros.Controls.Add(this.label78);
            this.tabPageOutros.Controls.Add(this.label77);
            this.tabPageOutros.Controls.Add(this.label19);
            this.tabPageOutros.Controls.Add(this.cbxClassificacao1);
            this.tabPageOutros.Controls.Add(this.groupBox1);
            this.tabPageOutros.Controls.Add(this.cbxFormaPagamento);
            this.tabPageOutros.Controls.Add(this.label17);
            this.tabPageOutros.Controls.Add(this.label16);
            this.tabPageOutros.Location = new System.Drawing.Point(4, 22);
            this.tabPageOutros.Name = "tabPageOutros";
            this.tabPageOutros.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPageOutros.Size = new System.Drawing.Size(668, 325);
            this.tabPageOutros.TabIndex = 2;
            this.tabPageOutros.Text = "Outros";
            this.tabPageOutros.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.tb_fim_entrega);
            this.panel2.Controls.Add(this.label83);
            this.panel2.Controls.Add(this.tb_inicio_entrega);
            this.panel2.Controls.Add(this.label84);
            this.panel2.Location = new System.Drawing.Point(62, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(354, 30);
            this.panel2.TabIndex = 106;
            // 
            // tb_fim_entrega
            // 
            this.tb_fim_entrega.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.FIM_ENTREGA_CLIENTE", true));
            this.tb_fim_entrega.Location = new System.Drawing.Point(254, 5);
            this.tb_fim_entrega.Name = "tb_fim_entrega";
            this.tb_fim_entrega.Size = new System.Drawing.Size(45, 20);
            this.tb_fim_entrega.TabIndex = 105;
            this.tb_fim_entrega.Validating += new System.ComponentModel.CancelEventHandler(this.tb_fim_entrega_Validating);
            this.tb_fim_entrega.Validated += new System.EventHandler(this.tb_fim_entrega_Validated);
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.Location = new System.Drawing.Point(185, 8);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(66, 13);
            this.label83.TabIndex = 104;
            this.label83.Text = "Fim Entrega:";
            // 
            // tb_inicio_entrega
            // 
            this.tb_inicio_entrega.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.INICIO_ENTREGA_CLIENTE", true));
            this.tb_inicio_entrega.Location = new System.Drawing.Point(116, 5);
            this.tb_inicio_entrega.Name = "tb_inicio_entrega";
            this.tb_inicio_entrega.Size = new System.Drawing.Size(45, 20);
            this.tb_inicio_entrega.TabIndex = 103;
            this.tb_inicio_entrega.Validating += new System.ComponentModel.CancelEventHandler(this.tb_inicio_entrega_Validating);
            this.tb_inicio_entrega.Validated += new System.EventHandler(this.tb_inicio_entrega_Validated);
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Location = new System.Drawing.Point(13, 8);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(77, 13);
            this.label84.TabIndex = 102;
            this.label84.Text = "Início Entrega:";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsClientes, "CLIENTES.DESCONTO_INSTRUCAO_CLIENTE", true));
            this.radioButton2.Location = new System.Drawing.Point(472, 99);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(135, 17);
            this.radioButton2.TabIndex = 101;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Desconto pontualidade";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsClientes, "CLIENTES.DESCONTO_VALOR_CLIENTE", true));
            this.radioButton1.Location = new System.Drawing.Point(472, 79);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(112, 17);
            this.radioButton1.TabIndex = 100;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Desconto no valor";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBox51
            // 
            this.textBox51.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.COD_ROTEIRO_CLIENTE", true));
            this.textBox51.Location = new System.Drawing.Point(279, 81);
            this.textBox51.Name = "textBox51";
            this.textBox51.Size = new System.Drawing.Size(45, 20);
            this.textBox51.TabIndex = 99;
            // 
            // tb_dia_visita
            // 
            this.tb_dia_visita.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.DIA_VISITA_CLIENTE", true));
            this.tb_dia_visita.Location = new System.Drawing.Point(379, 81);
            this.tb_dia_visita.Name = "tb_dia_visita";
            this.tb_dia_visita.ReadOnly = true;
            this.tb_dia_visita.Size = new System.Drawing.Size(45, 20);
            this.tb_dia_visita.TabIndex = 95;
            // 
            // textBox19
            // 
            this.textBox19.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.LIMITE_CREDITO_CLIENTE", true));
            this.textBox19.Location = new System.Drawing.Point(547, 122);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(100, 20);
            this.textBox19.TabIndex = 11;
            // 
            // textBox18
            // 
            this.textBox18.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.DIA_PAGAMENTO_CLIENTE", true));
            this.textBox18.Location = new System.Drawing.Point(162, 81);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(45, 20);
            this.textBox18.TabIndex = 9;
            // 
            // textBox17
            // 
            this.textBox17.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.DESCONTO_PONTUALIDADE_CLIENTE", true));
            this.textBox17.Location = new System.Drawing.Point(548, 52);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(100, 20);
            this.textBox17.TabIndex = 7;
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Location = new System.Drawing.Point(210, 84);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(69, 13);
            this.label82.TabIndex = 98;
            this.label82.Text = "Cód. Roteiro:";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(428, 80);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(24, 23);
            this.button7.TabIndex = 97;
            this.button7.Text = "+";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Location = new System.Drawing.Point(326, 84);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(54, 13);
            this.label74.TabIndex = 96;
            this.label74.Text = "Dia Visita:";
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Location = new System.Drawing.Point(454, 125);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(87, 13);
            this.label78.TabIndex = 10;
            this.label78.Text = "Limite de crédito:";
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Location = new System.Drawing.Point(59, 84);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(97, 13);
            this.label77.TabIndex = 8;
            this.label77.Text = "Dia de pagamento:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(455, 55);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(67, 13);
            this.label19.TabIndex = 6;
            this.label19.Text = "Desconto %:";
            // 
            // cbxClassificacao1
            // 
            this.cbxClassificacao1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.CLASSIFICACAO_CLIENTES", true));
            this.cbxClassificacao1.FormattingEnabled = true;
            this.cbxClassificacao1.Items.AddRange(new object[] {
            "100\tACADEMIAS",
            "101\tBICICLETARIAS",
            "102\tACESSORIOS DE MODA",
            "103\tACOUGUE",
            "104\tADEGA/DIST. DE BEBIDAS",
            "105\tAEROPORTO",
            "106\tAGROPECUARIA",
            "107\tAMBULANTE",
            "108\tBAZAR",
            "109\tARMAZEM",
            "110\tARTESANATOS",
            "111\tASSOCIACOES E COLONIAS",
            "112\tVAREJO",
            "113\tATC MEDIO PORTE",
            "114\tATC PEQUENO PORTE",
            "115\tATC GRANDE PORTE",
            "116\tATACAREJO",
            "117\tCOOPERATIVA",
            "118\tAUTO PECAS/VEICULOS",
            "119\tBANCAS / QUIOSQUES",
            "120\tBAR",
            "121\tLANCHONETES",
            "122\tRESTAURANTE",
            "123\tPAPELARIA",
            "124\tOTICA",
            "125\tESTUDIO FOTOGRAFICO",
            "126\tBOMBONIERE / DOCERIAS",
            "127\tBORDADEIRA",
            "128\tBOUTIQUE",
            "129\tLOJA DE BRINQUEDOS",
            "130\tSALAO DE BELEZA",
            "131\tCAFETERIA",
            "132\tCALCADOS",
            "133\tCANTINAS",
            "134\tCASH & CARRY",
            "135\tCHURRASCARIA",
            "136\tCINEMAS",
            "137\tCLINICAS",
            "138\tCLUBES",
            "139\tINSTITUICAO DE ENSINO",
            "140\tCONFECCOES",
            "141\tCONSUMIDOR FINAL",
            "142\tSERVICOS",
            "143\tCOPISTA",
            "144\tCOZINHA INDUSTRIAL",
            "145\tDISTRIBUIDOR",
            "146\tE-COMMERCE",
            "147\tENTIDADE FILANTROPICA",
            "148\tEVENTOS/FESTAS",
            "149\tEXPORTACAO",
            "150\tCORPORATIVO",
            "151\tFARMACIAS E DROGARIAS",
            "152\tFERRAGENS/MAT DE CONSTRUÇÃO",
            "153\tFLORICULTURA",
            "154\tFRUTEIRA",
            "155\tGOVERNO – Licitação",
            "156\tGRAFICAS",
            "157\tHOSPITAIS",
            "158\tHOTEIS/MOTEIS",
            "159\tIGREJAS/FUNERARIAS",
            "160\tINDUSTRIA",
            "161\tINFORMATICA / TECNOLOGIA",
            "162\tLOCADORAS",
            "163\tLOJA INFANTIL",
            "164\tLOJA DE CONVENIENCIA",
            "165\tLOJA DE DEPARTAMENTO",
            "166\tLOJA DE MOVEIS",
            "167\tLOJA DE ARTIGOS ESPORTIVOS",
            "168\tMERCADO E MINI MERCADO",
            "169\tOUTROS",
            "170\tPADARIA",
            "171\tPADARIA E CONFEITARIA",
            "172\tPASTELARIA",
            "173\tPEQUENOS ATCS E DISTS",
            "174\tPIZZARIA",
            "175\tTABACARIA",
            "176\tRODOVIARIA",
            "177\tSORVETERIA",
            "178\tAS – 1 a 5 CHECK OUTS",
            "179\tAS – 6 a 10 CHECK OUTS",
            "180\tAS – 11 a 15 CHECK OUTS",
            "181\tAS – 15 A 20 CHECK OUTS",
            "182\tAS – MAIS DE 20 CHECK OUTS",
            "183\tAS – SEM QUANTIDADE DE CHECK OUT",
            "184\tINSTITUIÇÕES FINANCEIRAS",
            "186\tTELEVENDAS",
            "187\tEQUIPE VENDAS - ATACADO",
            "188\tEQUIPE VENDAS - VAREJO",
            "189\tAS - 1 CHECK-OUT",
            "190\tAS - 2 CHECK-OUTS",
            "191\tAS - 3 CHECK-OUTS",
            "192\tAS - 4 CHECK-OUTS",
            "193\tAS - 5 CHECK-OUTS",
            "194\tAS - 6 CHECK-OUTS",
            "195\tAS - 7 CHECK-OUTS",
            "196\tAS - 8 CHECK-OUTS",
            "197\tAS - 9 CHECK-OUTS",
            "198\tAS - MAIS 9 CHECK-OUTS",
            "199\tATACADO BALCÃO",
            "200\tMERCEARIA"});
            this.cbxClassificacao1.Location = new System.Drawing.Point(162, 21);
            this.cbxClassificacao1.Name = "cbxClassificacao1";
            this.cbxClassificacao1.Size = new System.Drawing.Size(486, 21);
            this.cbxClassificacao1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.dgvVendedoresCliente);
            this.groupBox1.Controls.Add(this.btnInserirVendedor);
            this.groupBox1.Controls.Add(this.txtNomeVendedor);
            this.groupBox1.Controls.Add(this.txtCodVendedor);
            this.groupBox1.Location = new System.Drawing.Point(13, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(640, 171);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vendedores";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(419, 16);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(134, 23);
            this.button6.TabIndex = 17;
            this.button6.Text = "Selecionar Vendedor";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dgvVendedoresCliente
            // 
            this.dgvVendedoresCliente.AllowUserToAddRows = false;
            this.dgvVendedoresCliente.AutoGenerateColumns = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVendedoresCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvVendedoresCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendedoresCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODVCDataGridViewTextBoxColumn,
            this.cODCLIENTEVCDataGridViewTextBoxColumn,
            this.cODVENDEDORVCDataGridViewTextBoxColumn,
            this.nOMEVENDEDORVCDataGridViewTextBoxColumn});
            this.dgvVendedoresCliente.DataMember = "VENDEDORES_CLIENTE";
            this.dgvVendedoresCliente.DataSource = this.dsVendedores;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVendedoresCliente.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvVendedoresCliente.Location = new System.Drawing.Point(8, 45);
            this.dgvVendedoresCliente.Name = "dgvVendedoresCliente";
            this.dgvVendedoresCliente.ReadOnly = true;
            this.dgvVendedoresCliente.Size = new System.Drawing.Size(626, 120);
            this.dgvVendedoresCliente.TabIndex = 3;
            // 
            // cODVCDataGridViewTextBoxColumn
            // 
            this.cODVCDataGridViewTextBoxColumn.DataPropertyName = "COD_VC";
            this.cODVCDataGridViewTextBoxColumn.HeaderText = "COD_VC";
            this.cODVCDataGridViewTextBoxColumn.Name = "cODVCDataGridViewTextBoxColumn";
            this.cODVCDataGridViewTextBoxColumn.ReadOnly = true;
            this.cODVCDataGridViewTextBoxColumn.Visible = false;
            // 
            // cODCLIENTEVCDataGridViewTextBoxColumn
            // 
            this.cODCLIENTEVCDataGridViewTextBoxColumn.DataPropertyName = "COD_CLIENTE_VC";
            this.cODCLIENTEVCDataGridViewTextBoxColumn.HeaderText = "COD_CLIENTE_VC";
            this.cODCLIENTEVCDataGridViewTextBoxColumn.Name = "cODCLIENTEVCDataGridViewTextBoxColumn";
            this.cODCLIENTEVCDataGridViewTextBoxColumn.ReadOnly = true;
            this.cODCLIENTEVCDataGridViewTextBoxColumn.Visible = false;
            // 
            // cODVENDEDORVCDataGridViewTextBoxColumn
            // 
            this.cODVENDEDORVCDataGridViewTextBoxColumn.DataPropertyName = "COD_VENDEDOR_VC";
            this.cODVENDEDORVCDataGridViewTextBoxColumn.HeaderText = "Código do Vendedor";
            this.cODVENDEDORVCDataGridViewTextBoxColumn.Name = "cODVENDEDORVCDataGridViewTextBoxColumn";
            this.cODVENDEDORVCDataGridViewTextBoxColumn.ReadOnly = true;
            this.cODVENDEDORVCDataGridViewTextBoxColumn.Width = 150;
            // 
            // nOMEVENDEDORVCDataGridViewTextBoxColumn
            // 
            this.nOMEVENDEDORVCDataGridViewTextBoxColumn.DataPropertyName = "NOME_VENDEDOR_VC";
            this.nOMEVENDEDORVCDataGridViewTextBoxColumn.HeaderText = "Nome do Vendedor";
            this.nOMEVENDEDORVCDataGridViewTextBoxColumn.Name = "nOMEVENDEDORVCDataGridViewTextBoxColumn";
            this.nOMEVENDEDORVCDataGridViewTextBoxColumn.ReadOnly = true;
            this.nOMEVENDEDORVCDataGridViewTextBoxColumn.Width = 300;
            // 
            // btnInserirVendedor
            // 
            this.btnInserirVendedor.Location = new System.Drawing.Point(559, 16);
            this.btnInserirVendedor.Name = "btnInserirVendedor";
            this.btnInserirVendedor.Size = new System.Drawing.Size(75, 23);
            this.btnInserirVendedor.TabIndex = 2;
            this.btnInserirVendedor.Text = "Inserir";
            this.btnInserirVendedor.UseVisualStyleBackColor = true;
            this.btnInserirVendedor.Click += new System.EventHandler(this.btnInserirVendedor_Click);
            // 
            // txtNomeVendedor
            // 
            this.txtNomeVendedor.Location = new System.Drawing.Point(75, 19);
            this.txtNomeVendedor.Name = "txtNomeVendedor";
            this.txtNomeVendedor.ReadOnly = true;
            this.txtNomeVendedor.Size = new System.Drawing.Size(338, 20);
            this.txtNomeVendedor.TabIndex = 1;
            this.txtNomeVendedor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNomeVendedor_KeyDown);
            this.txtNomeVendedor.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtNomeVendedor_MouseDoubleClick);
            // 
            // txtCodVendedor
            // 
            this.txtCodVendedor.Location = new System.Drawing.Point(8, 19);
            this.txtCodVendedor.Name = "txtCodVendedor";
            this.txtCodVendedor.ReadOnly = true;
            this.txtCodVendedor.Size = new System.Drawing.Size(61, 20);
            this.txtCodVendedor.TabIndex = 0;
            this.txtCodVendedor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodVendedor_KeyDown);
            this.txtCodVendedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodVendedor_KeyPress);
            this.txtCodVendedor.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtCodVendedor_MouseDoubleClick);
            // 
            // cbxFormaPagamento
            // 
            this.cbxFormaPagamento.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsClientes, "CLIENTES.FORMA_PAGAMENTO_CLIENTE", true));
            this.cbxFormaPagamento.FormattingEnabled = true;
            this.cbxFormaPagamento.Location = new System.Drawing.Point(162, 51);
            this.cbxFormaPagamento.Name = "cbxFormaPagamento";
            this.cbxFormaPagamento.Size = new System.Drawing.Size(265, 21);
            this.cbxFormaPagamento.TabIndex = 3;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(43, 54);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(111, 13);
            this.label17.TabIndex = 2;
            this.label17.Text = "Forma de Pagamento:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(11, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(143, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Classificação/Segmentação:";
            // 
            // tabPageDadosAdicionais
            // 
            this.tabPageDadosAdicionais.Controls.Add(this.groupBox2);
            this.tabPageDadosAdicionais.Controls.Add(this.panel1);
            this.tabPageDadosAdicionais.Controls.Add(this.tb_cobranca);
            this.tabPageDadosAdicionais.Controls.Add(this.tb_entrega);
            this.tabPageDadosAdicionais.Controls.Add(this.tb_icm);
            this.tabPageDadosAdicionais.Controls.Add(this.tb_ipi);
            this.tabPageDadosAdicionais.Controls.Add(this.tb_class);
            this.tabPageDadosAdicionais.Controls.Add(this.label26);
            this.tabPageDadosAdicionais.Controls.Add(this.label25);
            this.tabPageDadosAdicionais.Controls.Add(this.label21);
            this.tabPageDadosAdicionais.Controls.Add(this.label22);
            this.tabPageDadosAdicionais.Controls.Add(this.label23);
            this.tabPageDadosAdicionais.Location = new System.Drawing.Point(4, 22);
            this.tabPageDadosAdicionais.Name = "tabPageDadosAdicionais";
            this.tabPageDadosAdicionais.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPageDadosAdicionais.Size = new System.Drawing.Size(668, 325);
            this.tabPageDadosAdicionais.TabIndex = 1;
            this.tabPageDadosAdicionais.Text = "Dados Adicionais";
            this.tabPageDadosAdicionais.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Controls.Add(this.label75);
            this.groupBox2.Controls.Add(this.tb_nome_tabela_preco);
            this.groupBox2.Controls.Add(this.label76);
            this.groupBox2.Controls.Add(this.tb_cod_tabela);
            this.groupBox2.Location = new System.Drawing.Point(395, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(236, 109);
            this.groupBox2.TabIndex = 78;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tabela de Preços";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(65, 80);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(118, 23);
            this.button8.TabIndex = 75;
            this.button8.Text = "Localizar Tabela";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Location = new System.Drawing.Point(1, 57);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(89, 13);
            this.label75.TabIndex = 74;
            this.label75.Text = "Nome da Tabela:";
            // 
            // tb_nome_tabela_preco
            // 
            this.tb_nome_tabela_preco.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.DESCRICAO_TP_CLIENTE", true));
            this.tb_nome_tabela_preco.Location = new System.Drawing.Point(96, 54);
            this.tb_nome_tabela_preco.Name = "tb_nome_tabela_preco";
            this.tb_nome_tabela_preco.ReadOnly = true;
            this.tb_nome_tabela_preco.Size = new System.Drawing.Size(129, 20);
            this.tb_nome_tabela_preco.TabIndex = 73;
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Location = new System.Drawing.Point(53, 31);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(32, 13);
            this.label76.TabIndex = 72;
            this.label76.Text = "Cód.:";
            // 
            // tb_cod_tabela
            // 
            this.tb_cod_tabela.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.COD_TP_CLIENTE", true));
            this.tb_cod_tabela.Location = new System.Drawing.Point(96, 28);
            this.tb_cod_tabela.Name = "tb_cod_tabela";
            this.tb_cod_tabela.ReadOnly = true;
            this.tb_cod_tabela.Size = new System.Drawing.Size(40, 20);
            this.tb_cod_tabela.TabIndex = 71;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.textBox14);
            this.panel1.Controls.Add(this.label72);
            this.panel1.Controls.Add(this.label71);
            this.panel1.Controls.Add(this.label70);
            this.panel1.Controls.Add(this.label69);
            this.panel1.Controls.Add(this.label68);
            this.panel1.Controls.Add(this.label67);
            this.panel1.Controls.Add(this.label66);
            this.panel1.Controls.Add(this.textBox50);
            this.panel1.Controls.Add(this.textBox49);
            this.panel1.Controls.Add(this.textBox48);
            this.panel1.Controls.Add(this.textBox47);
            this.panel1.Controls.Add(this.textBox46);
            this.panel1.Controls.Add(this.textBox45);
            this.panel1.Location = new System.Drawing.Point(27, 169);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 103);
            this.panel1.TabIndex = 67;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(89, 51);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 26);
            this.label14.TabIndex = 75;
            this.label14.Text = "Redução\r\nST";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox14
            // 
            this.textBox14.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.REDUCAO_ST_CLIENTE", true));
            this.textBox14.Location = new System.Drawing.Point(100, 78);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(30, 20);
            this.textBox14.TabIndex = 74;
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label72.Location = new System.Drawing.Point(6, 13);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(143, 31);
            this.label72.TabIndex = 73;
            this.label72.Text = "Tributação";
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label71.Location = new System.Drawing.Point(243, 62);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(45, 13);
            this.label71.TabIndex = 72;
            this.label71.Text = "COFINS";
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label70.Location = new System.Drawing.Point(210, 62);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(24, 13);
            this.label70.TabIndex = 71;
            this.label70.Text = "PIS";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label69.Location = new System.Drawing.Point(178, 62);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(20, 13);
            this.label69.TabIndex = 70;
            this.label69.Text = "IPI";
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label68.Location = new System.Drawing.Point(137, 51);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(33, 26);
            this.label68.TabIndex = 69;
            this.label68.Text = "ICMS\r\nST";
            this.label68.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label67.Location = new System.Drawing.Point(45, 62);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(49, 13);
            this.label67.TabIndex = 68;
            this.label67.Text = "Redução";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label66.Location = new System.Drawing.Point(9, 62);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(33, 13);
            this.label66.TabIndex = 67;
            this.label66.Text = "ICMS";
            // 
            // textBox50
            // 
            this.textBox50.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.COFINS_CLIENTE", true));
            this.textBox50.Location = new System.Drawing.Point(246, 78);
            this.textBox50.Name = "textBox50";
            this.textBox50.Size = new System.Drawing.Size(30, 20);
            this.textBox50.TabIndex = 65;
            // 
            // textBox49
            // 
            this.textBox49.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.PIS_CLIENTE", true));
            this.textBox49.Location = new System.Drawing.Point(210, 78);
            this.textBox49.Name = "textBox49";
            this.textBox49.Size = new System.Drawing.Size(30, 20);
            this.textBox49.TabIndex = 64;
            // 
            // textBox48
            // 
            this.textBox48.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.IPI_CLIENTE", true));
            this.textBox48.Location = new System.Drawing.Point(173, 78);
            this.textBox48.Name = "textBox48";
            this.textBox48.Size = new System.Drawing.Size(30, 20);
            this.textBox48.TabIndex = 63;
            // 
            // textBox47
            // 
            this.textBox47.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.ICMS_ST_CLIENTE", true));
            this.textBox47.Location = new System.Drawing.Point(138, 78);
            this.textBox47.Name = "textBox47";
            this.textBox47.Size = new System.Drawing.Size(30, 20);
            this.textBox47.TabIndex = 62;
            // 
            // textBox46
            // 
            this.textBox46.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.REDUCAO_CLIENTE", true));
            this.textBox46.Location = new System.Drawing.Point(53, 78);
            this.textBox46.Name = "textBox46";
            this.textBox46.Size = new System.Drawing.Size(30, 20);
            this.textBox46.TabIndex = 61;
            // 
            // textBox45
            // 
            this.textBox45.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.ICMS_CLIENTE", true));
            this.textBox45.Location = new System.Drawing.Point(12, 78);
            this.textBox45.Name = "textBox45";
            this.textBox45.Size = new System.Drawing.Size(30, 20);
            this.textBox45.TabIndex = 60;
            // 
            // tb_cobranca
            // 
            this.tb_cobranca.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.ENDERECO_COBRANCA_CLIENTE", true));
            this.tb_cobranca.Location = new System.Drawing.Point(142, 121);
            this.tb_cobranca.Name = "tb_cobranca";
            this.tb_cobranca.Size = new System.Drawing.Size(489, 20);
            this.tb_cobranca.TabIndex = 27;
            // 
            // tb_entrega
            // 
            this.tb_entrega.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.ENDERECO_ENTREGA_CLIENTE", true));
            this.tb_entrega.Location = new System.Drawing.Point(142, 143);
            this.tb_entrega.Name = "tb_entrega";
            this.tb_entrega.Size = new System.Drawing.Size(489, 20);
            this.tb_entrega.TabIndex = 28;
            // 
            // tb_icm
            // 
            this.tb_icm.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.ISENCAO_ICM_CLIENTE", true));
            this.tb_icm.Location = new System.Drawing.Point(142, 76);
            this.tb_icm.Multiline = true;
            this.tb_icm.Name = "tb_icm";
            this.tb_icm.Size = new System.Drawing.Size(489, 43);
            this.tb_icm.TabIndex = 26;
            // 
            // tb_ipi
            // 
            this.tb_ipi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.ISENCAO_IPI_CLIENTE", true));
            this.tb_ipi.Location = new System.Drawing.Point(142, 31);
            this.tb_ipi.Multiline = true;
            this.tb_ipi.Name = "tb_ipi";
            this.tb_ipi.Size = new System.Drawing.Size(489, 43);
            this.tb_ipi.TabIndex = 25;
            // 
            // tb_class
            // 
            this.tb_class.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.CLASS_FISCAL_CLIENTE", true));
            this.tb_class.Location = new System.Drawing.Point(142, 9);
            this.tb_class.Name = "tb_class";
            this.tb_class.Size = new System.Drawing.Size(88, 20);
            this.tb_class.TabIndex = 24;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(25, 124);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(120, 13);
            this.label26.TabIndex = 59;
            this.label26.Text = "Endereço de Cobrança:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(25, 146);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(111, 13);
            this.label25.TabIndex = 57;
            this.label25.Text = "Endereço de Entrega:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(24, 78);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(85, 13);
            this.label21.TabIndex = 55;
            this.label21.Text = "Isenção de ICM:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(24, 31);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(79, 13);
            this.label22.TabIndex = 53;
            this.label22.Text = "Isenção de IPI:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(25, 12);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(34, 13);
            this.label23.TabIndex = 52;
            this.label23.Text = "NCM:";
            // 
            // tabPageDadosComuns
            // 
            this.tabPageDadosComuns.Controls.Add(this.tb_obs);
            this.tabPageDadosComuns.Controls.Add(this.textBox16);
            this.tabPageDadosComuns.Controls.Add(this.textBox15);
            this.tabPageDadosComuns.Controls.Add(this.tb_cod_pais);
            this.tabPageDadosComuns.Controls.Add(this.tb_tipo);
            this.tabPageDadosComuns.Controls.Add(this.tb_telefone_2);
            this.tabPageDadosComuns.Controls.Add(this.tb_cod_cidade);
            this.tabPageDadosComuns.Controls.Add(this.tb_telefone_1);
            this.tabPageDadosComuns.Controls.Add(this.tb_email);
            this.tabPageDadosComuns.Controls.Add(this.tb_n);
            this.tabPageDadosComuns.Controls.Add(this.tb_nome_contato);
            this.tabPageDadosComuns.Controls.Add(this.tb_Cep);
            this.tabPageDadosComuns.Controls.Add(this.textBox13);
            this.tabPageDadosComuns.Controls.Add(this.tb_fone);
            this.tabPageDadosComuns.Controls.Add(this.tb_pais);
            this.tabPageDadosComuns.Controls.Add(this.tb_estado);
            this.tabPageDadosComuns.Controls.Add(this.tb_cidade);
            this.tabPageDadosComuns.Controls.Add(this.tb_bairro);
            this.tabPageDadosComuns.Controls.Add(this.tb_logradouro);
            this.tabPageDadosComuns.Controls.Add(this.textBox4);
            this.tabPageDadosComuns.Controls.Add(this.tb_ie);
            this.tabPageDadosComuns.Controls.Add(this.tb_cnpj);
            this.tabPageDadosComuns.Controls.Add(this.label81);
            this.tabPageDadosComuns.Controls.Add(this.label18);
            this.tabPageDadosComuns.Controls.Add(this.label15);
            this.tabPageDadosComuns.Controls.Add(this.button5);
            this.tabPageDadosComuns.Controls.Add(this.button4);
            this.tabPageDadosComuns.Controls.Add(this.cb_pessoa_fisica);
            this.tabPageDadosComuns.Controls.Add(this.button2);
            this.tabPageDadosComuns.Controls.Add(this.label29);
            this.tabPageDadosComuns.Controls.Add(this.label28);
            this.tabPageDadosComuns.Controls.Add(this.label27);
            this.tabPageDadosComuns.Controls.Add(this.dgvContatos);
            this.tabPageDadosComuns.Controls.Add(this.label24);
            this.tabPageDadosComuns.Controls.Add(this.label13);
            this.tabPageDadosComuns.Controls.Add(this.label7);
            this.tabPageDadosComuns.Controls.Add(this.label8);
            this.tabPageDadosComuns.Controls.Add(this.label9);
            this.tabPageDadosComuns.Controls.Add(this.label10);
            this.tabPageDadosComuns.Controls.Add(this.label11);
            this.tabPageDadosComuns.Controls.Add(this.label12);
            this.tabPageDadosComuns.Controls.Add(this.label4);
            this.tabPageDadosComuns.Controls.Add(this.label5);
            this.tabPageDadosComuns.Controls.Add(this.label6);
            this.tabPageDadosComuns.Location = new System.Drawing.Point(4, 22);
            this.tabPageDadosComuns.Name = "tabPageDadosComuns";
            this.tabPageDadosComuns.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPageDadosComuns.Size = new System.Drawing.Size(668, 325);
            this.tabPageDadosComuns.TabIndex = 0;
            this.tabPageDadosComuns.Text = "Dados Comuns";
            this.tabPageDadosComuns.UseVisualStyleBackColor = true;
            // 
            // tb_obs
            // 
            this.tb_obs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.OBSERVACOES_CLIENTE", true));
            this.tb_obs.Location = new System.Drawing.Point(261, 113);
            this.tb_obs.Multiline = true;
            this.tb_obs.Name = "tb_obs";
            this.tb_obs.Size = new System.Drawing.Size(404, 46);
            this.tb_obs.TabIndex = 101;
            // 
            // textBox16
            // 
            this.textBox16.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.CONTATO1", true));
            this.textBox16.Location = new System.Drawing.Point(95, 112);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(113, 20);
            this.textBox16.TabIndex = 90;
            // 
            // textBox15
            // 
            this.textBox15.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.COMPLEMENTO_CLIENTE", true));
            this.textBox15.Location = new System.Drawing.Point(482, 34);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(34, 20);
            this.textBox15.TabIndex = 88;
            // 
            // tb_cod_pais
            // 
            this.tb_cod_pais.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.COD_PAIS_CLIENTE", true));
            this.tb_cod_pais.Location = new System.Drawing.Point(628, 86);
            this.tb_cod_pais.Name = "tb_cod_pais";
            this.tb_cod_pais.Size = new System.Drawing.Size(37, 20);
            this.tb_cod_pais.TabIndex = 17;
            // 
            // tb_tipo
            // 
            this.tb_tipo.Location = new System.Drawing.Point(540, 165);
            this.tb_tipo.Name = "tb_tipo";
            this.tb_tipo.Size = new System.Drawing.Size(100, 20);
            this.tb_tipo.TabIndex = 85;
            // 
            // tb_telefone_2
            // 
            this.tb_telefone_2.Location = new System.Drawing.Point(450, 165);
            this.tb_telefone_2.Name = "tb_telefone_2";
            this.tb_telefone_2.Size = new System.Drawing.Size(90, 20);
            this.tb_telefone_2.TabIndex = 84;
            // 
            // tb_cod_cidade
            // 
            this.tb_cod_cidade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.COD_CIDADE_CLIENTE", true));
            this.tb_cod_cidade.Location = new System.Drawing.Point(498, 86);
            this.tb_cod_cidade.Name = "tb_cod_cidade";
            this.tb_cod_cidade.Size = new System.Drawing.Size(46, 20);
            this.tb_cod_cidade.TabIndex = 16;
            // 
            // tb_telefone_1
            // 
            this.tb_telefone_1.Location = new System.Drawing.Point(360, 165);
            this.tb_telefone_1.Name = "tb_telefone_1";
            this.tb_telefone_1.Size = new System.Drawing.Size(90, 20);
            this.tb_telefone_1.TabIndex = 83;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(220, 165);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(140, 20);
            this.tb_email.TabIndex = 82;
            // 
            // tb_n
            // 
            this.tb_n.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.NUMERO_CLIENTE", true));
            this.tb_n.Location = new System.Drawing.Point(414, 34);
            this.tb_n.Name = "tb_n";
            this.tb_n.Size = new System.Drawing.Size(25, 20);
            this.tb_n.TabIndex = 8;
            // 
            // tb_nome_contato
            // 
            this.tb_nome_contato.Location = new System.Drawing.Point(50, 165);
            this.tb_nome_contato.Name = "tb_nome_contato";
            this.tb_nome_contato.Size = new System.Drawing.Size(170, 20);
            this.tb_nome_contato.TabIndex = 81;
            // 
            // tb_Cep
            // 
            this.tb_Cep.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.CEP_CLIENTE", true));
            this.tb_Cep.Location = new System.Drawing.Point(398, 60);
            this.tb_Cep.Name = "tb_Cep";
            this.tb_Cep.Size = new System.Drawing.Size(76, 20);
            this.tb_Cep.TabIndex = 12;
            this.tb_Cep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Cep_KeyPress);
            // 
            // textBox13
            // 
            this.textBox13.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.EMAIL", true));
            this.textBox13.Location = new System.Drawing.Point(265, 86);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(162, 20);
            this.textBox13.TabIndex = 15;
            // 
            // tb_fone
            // 
            this.tb_fone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.FONE", true));
            this.tb_fone.Location = new System.Drawing.Point(95, 86);
            this.tb_fone.Name = "tb_fone";
            this.tb_fone.Size = new System.Drawing.Size(113, 20);
            this.tb_fone.TabIndex = 14;
            // 
            // tb_pais
            // 
            this.tb_pais.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.PAIS", true));
            this.tb_pais.Location = new System.Drawing.Point(551, 60);
            this.tb_pais.Name = "tb_pais";
            this.tb_pais.Size = new System.Drawing.Size(114, 20);
            this.tb_pais.TabIndex = 13;
            // 
            // tb_estado
            // 
            this.tb_estado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.ESTADO", true));
            this.tb_estado.Location = new System.Drawing.Point(315, 60);
            this.tb_estado.Name = "tb_estado";
            this.tb_estado.Size = new System.Drawing.Size(31, 20);
            this.tb_estado.TabIndex = 11;
            // 
            // tb_cidade
            // 
            this.tb_cidade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.CIDADE", true));
            this.tb_cidade.Location = new System.Drawing.Point(94, 60);
            this.tb_cidade.Name = "tb_cidade";
            this.tb_cidade.Size = new System.Drawing.Size(149, 20);
            this.tb_cidade.TabIndex = 10;
            // 
            // tb_bairro
            // 
            this.tb_bairro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.BAIRRO", true));
            this.tb_bairro.Location = new System.Drawing.Point(558, 34);
            this.tb_bairro.Name = "tb_bairro";
            this.tb_bairro.Size = new System.Drawing.Size(107, 20);
            this.tb_bairro.TabIndex = 9;
            this.tb_bairro.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // tb_logradouro
            // 
            this.tb_logradouro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.ENDERECO", true));
            this.tb_logradouro.Location = new System.Drawing.Point(95, 34);
            this.tb_logradouro.Name = "tb_logradouro";
            this.tb_logradouro.Size = new System.Drawing.Size(294, 20);
            this.tb_logradouro.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.IM", true));
            this.textBox4.Location = new System.Drawing.Point(427, 8);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(97, 20);
            this.textBox4.TabIndex = 6;
            // 
            // tb_ie
            // 
            this.tb_ie.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.IE", true));
            this.tb_ie.Location = new System.Drawing.Point(262, 8);
            this.tb_ie.Name = "tb_ie";
            this.tb_ie.Size = new System.Drawing.Size(126, 20);
            this.tb_ie.TabIndex = 5;
            // 
            // tb_cnpj
            // 
            this.tb_cnpj.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.CNPJ", true));
            this.tb_cnpj.Location = new System.Drawing.Point(94, 8);
            this.tb_cnpj.Name = "tb_cnpj";
            this.tb_cnpj.Size = new System.Drawing.Size(136, 20);
            this.tb_cnpj.TabIndex = 4;
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Location = new System.Drawing.Point(223, 116);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(32, 13);
            this.label81.TabIndex = 100;
            this.label81.Text = "Obs.:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(5, 115);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(47, 13);
            this.label18.TabIndex = 91;
            this.label18.Text = "Contato:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(440, 37);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 13);
            this.label15.TabIndex = 89;
            this.label15.Text = "Compl.:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(480, 57);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(17, 23);
            this.button5.TabIndex = 87;
            this.button5.Text = "?";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(546, 84);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(17, 23);
            this.button4.TabIndex = 86;
            this.button4.Text = "?";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // cb_pessoa_fisica
            // 
            this.cb_pessoa_fisica.AutoSize = true;
            this.cb_pessoa_fisica.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsClientes, "CLIENTES.PESSOA_FISICA_CLIENTE", true));
            this.cb_pessoa_fisica.Location = new System.Drawing.Point(551, 10);
            this.cb_pessoa_fisica.Name = "cb_pessoa_fisica";
            this.cb_pessoa_fisica.Size = new System.Drawing.Size(93, 17);
            this.cb_pessoa_fisica.TabIndex = 81;
            this.cb_pessoa_fisica.Text = "Pessoa Física";
            this.cb_pessoa_fisica.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 163);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 22);
            this.button2.TabIndex = 79;
            this.button2.Text = "Adic";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(565, 89);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(57, 13);
            this.label29.TabIndex = 78;
            this.label29.Text = "Cód. País:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(433, 89);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(68, 13);
            this.label28.TabIndex = 76;
            this.label28.Text = "Cód. Cidade:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(392, 37);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(22, 13);
            this.label27.TabIndex = 74;
            this.label27.Text = "Nº:";
            // 
            // dgvContatos
            // 
            this.dgvContatos.AllowUserToAddRows = false;
            this.dgvContatos.AutoGenerateColumns = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvContatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODCONTATODataGridViewTextBoxColumn,
            this.nOMECONTATODataGridViewTextBoxColumn,
            this.eMAILCONTATODataGridViewTextBoxColumn,
            this.tEL1CONTATODataGridViewTextBoxColumn,
            this.tEL2CONTATODataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.cLIENTEFORNCONTATODataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2});
            this.dgvContatos.DataMember = "CONTATOS";
            this.dgvContatos.DataSource = this.dsContatos;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvContatos.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvContatos.Location = new System.Drawing.Point(9, 191);
            this.dgvContatos.Name = "dgvContatos";
            this.dgvContatos.Size = new System.Drawing.Size(654, 118);
            this.dgvContatos.TabIndex = 80;
            // 
            // cODCONTATODataGridViewTextBoxColumn
            // 
            this.cODCONTATODataGridViewTextBoxColumn.DataPropertyName = "COD_CONTATO";
            this.cODCONTATODataGridViewTextBoxColumn.HeaderText = "COD_CONTATO";
            this.cODCONTATODataGridViewTextBoxColumn.Name = "cODCONTATODataGridViewTextBoxColumn";
            this.cODCONTATODataGridViewTextBoxColumn.Visible = false;
            // 
            // nOMECONTATODataGridViewTextBoxColumn
            // 
            this.nOMECONTATODataGridViewTextBoxColumn.DataPropertyName = "NOME_CONTATO";
            this.nOMECONTATODataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nOMECONTATODataGridViewTextBoxColumn.Name = "nOMECONTATODataGridViewTextBoxColumn";
            this.nOMECONTATODataGridViewTextBoxColumn.Width = 170;
            // 
            // eMAILCONTATODataGridViewTextBoxColumn
            // 
            this.eMAILCONTATODataGridViewTextBoxColumn.DataPropertyName = "EMAIL_CONTATO";
            this.eMAILCONTATODataGridViewTextBoxColumn.HeaderText = "Email";
            this.eMAILCONTATODataGridViewTextBoxColumn.Name = "eMAILCONTATODataGridViewTextBoxColumn";
            this.eMAILCONTATODataGridViewTextBoxColumn.Width = 140;
            // 
            // tEL1CONTATODataGridViewTextBoxColumn
            // 
            this.tEL1CONTATODataGridViewTextBoxColumn.DataPropertyName = "TEL_1_CONTATO";
            this.tEL1CONTATODataGridViewTextBoxColumn.HeaderText = "Telefone 1";
            this.tEL1CONTATODataGridViewTextBoxColumn.Name = "tEL1CONTATODataGridViewTextBoxColumn";
            this.tEL1CONTATODataGridViewTextBoxColumn.Width = 90;
            // 
            // tEL2CONTATODataGridViewTextBoxColumn
            // 
            this.tEL2CONTATODataGridViewTextBoxColumn.DataPropertyName = "TEL_2_CONTATO";
            this.tEL2CONTATODataGridViewTextBoxColumn.HeaderText = "Telefone 2";
            this.tEL2CONTATODataGridViewTextBoxColumn.Name = "tEL2CONTATODataGridViewTextBoxColumn";
            this.tEL2CONTATODataGridViewTextBoxColumn.Width = 90;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TIPO_CONTATO";
            this.dataGridViewTextBoxColumn1.HeaderText = "Tipo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // cLIENTEFORNCONTATODataGridViewTextBoxColumn
            // 
            this.cLIENTEFORNCONTATODataGridViewTextBoxColumn.DataPropertyName = "CLIENTE_FORN_CONTATO";
            this.cLIENTEFORNCONTATODataGridViewTextBoxColumn.HeaderText = "CLIENTE_FORN_CONTATO";
            this.cLIENTEFORNCONTATODataGridViewTextBoxColumn.Name = "cLIENTEFORNCONTATODataGridViewTextBoxColumn";
            this.cLIENTEFORNCONTATODataGridViewTextBoxColumn.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "COD_CLIENTE_FORN_CONTATO";
            this.dataGridViewTextBoxColumn2.HeaderText = "COD_CLIENTE_FORN_CONTATO";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(361, 63);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(31, 13);
            this.label24.TabIndex = 72;
            this.label24.Text = "CEP:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(224, 89);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 64;
            this.label13.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 63;
            this.label7.Text = "Fone:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(511, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 62;
            this.label8.Text = "País:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(266, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 60;
            this.label9.Text = "Estado:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 58;
            this.label10.Text = "Cidade:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(519, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 54;
            this.label11.Text = "Bairro:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 52;
            this.label12.Text = "Endereço:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(399, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "IM:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(236, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "IE:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "CNPJ/CPF:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageDadosComuns);
            this.tabControl1.Controls.Add(this.tabPageDadosAdicionais);
            this.tabControl1.Controls.Add(this.tabPageOutros);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPageTabelaPrecos);
            this.tabControl1.Controls.Add(this.tabPageVendas);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(16, 111);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(676, 351);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.TabIndexChanged += new System.EventHandler(this.tabControl1_TabIndexChanged);
            // 
            // datValor_operacao_cliente
            // 
            this.datValor_operacao_cliente.DeleteCommand = this.fbCommand14;
            this.datValor_operacao_cliente.InsertCommand = this.fbCommand12;
            this.datValor_operacao_cliente.SelectCommand = this.fbCommand11;
            this.datValor_operacao_cliente.UpdateCommand = this.fbCommand13;
            // 
            // cbValor_operacao_cliente
            // 
            this.cbValor_operacao_cliente.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbValor_operacao_cliente.DataAdapter = this.datValor_operacao_cliente;
            this.cbValor_operacao_cliente.QuotePrefix = "\"";
            this.cbValor_operacao_cliente.QuoteSuffix = "\"";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.button13);
            this.tabPage6.Controls.Add(this.label93);
            this.tabPage6.Controls.Add(this.tb_n_pgto);
            this.tabPage6.Controls.Add(this.label92);
            this.tabPage6.Controls.Add(this.label91);
            this.tabPage6.Controls.Add(this.cbTipo_pgto);
            this.tabPage6.Controls.Add(this.dgvPagamentos_caract);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(668, 325);
            this.tabPage6.TabIndex = 7;
            this.tabPage6.Text = "Pagamento";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // dgvPagamentos_caract
            // 
            this.dgvPagamentos_caract.AllowUserToAddRows = false;
            this.dgvPagamentos_caract.AutoGenerateColumns = false;
            this.dgvPagamentos_caract.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagamentos_caract.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODPCDataGridViewTextBoxColumn,
            this.cNPJCLIENTEPCDataGridViewTextBoxColumn,
            this.nUMEROPCDataGridViewTextBoxColumn,
            this.tIPOPCDataGridViewTextBoxColumn});
            this.dgvPagamentos_caract.DataMember = "PAGAMENTOS_CARACT";
            this.dgvPagamentos_caract.DataSource = this.dsPagamentos_caract;
            this.dgvPagamentos_caract.Location = new System.Drawing.Point(15, 100);
            this.dgvPagamentos_caract.Name = "dgvPagamentos_caract";
            this.dgvPagamentos_caract.Size = new System.Drawing.Size(297, 211);
            this.dgvPagamentos_caract.TabIndex = 0;
            // 
            // cbTipo_pgto
            // 
            this.cbTipo_pgto.FormattingEnabled = true;
            this.cbTipo_pgto.Items.AddRange(new object[] {
            " ",
            "SEMANA",
            "MES"});
            this.cbTipo_pgto.Location = new System.Drawing.Point(105, 68);
            this.cbTipo_pgto.Name = "cbTipo_pgto";
            this.cbTipo_pgto.Size = new System.Drawing.Size(121, 21);
            this.cbTipo_pgto.TabIndex = 1;
            // 
            // label91
            // 
            this.label91.AutoSize = true;
            this.label91.Location = new System.Drawing.Point(104, 52);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(28, 13);
            this.label91.TabIndex = 2;
            this.label91.Text = "Tipo";
            // 
            // label92
            // 
            this.label92.AutoSize = true;
            this.label92.Location = new System.Drawing.Point(14, 53);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(44, 13);
            this.label92.TabIndex = 3;
            this.label92.Text = "Número";
            // 
            // tb_n_pgto
            // 
            this.tb_n_pgto.Location = new System.Drawing.Point(15, 69);
            this.tb_n_pgto.Name = "tb_n_pgto";
            this.tb_n_pgto.Size = new System.Drawing.Size(84, 20);
            this.tb_n_pgto.TabIndex = 4;
            // 
            // label93
            // 
            this.label93.AutoSize = true;
            this.label93.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label93.Location = new System.Drawing.Point(14, 3);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(337, 39);
            this.label93.TabIndex = 5;
            this.label93.Text = "Para tipo MES digite o dia. \r\nPara tipo SEMANA digite o numero correspondente ao " +
    "dia da semana \r\nsendo 1 para Domingo, 2 para Segunda e assim por diante.";
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(237, 66);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 6;
            this.button13.Text = "Inserir";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // datPagamentos_caract
            // 
            this.datPagamentos_caract.DeleteCommand = this.fbCommand53;
            this.datPagamentos_caract.InsertCommand = this.fbCommand51;
            this.datPagamentos_caract.SelectCommand = this.fbCommand50;
            this.datPagamentos_caract.UpdateCommand = this.fbCommand52;
            // 
            // fbCommand50
            // 
            this.fbCommand50.CommandText = "select * from pagamentos_caract";
            this.fbCommand50.CommandTimeout = 30;
            this.fbCommand50.Connection = this.fbConnection1;
            // 
            // fbCommand51
            // 
            this.fbCommand51.CommandTimeout = 30;
            // 
            // fbCommand52
            // 
            this.fbCommand52.CommandTimeout = 30;
            // 
            // fbCommand53
            // 
            this.fbCommand53.CommandTimeout = 30;
            // 
            // dsPagamentos_caract
            // 
            this.dsPagamentos_caract.DataSetName = "dsPagamentos_caract";
            this.dsPagamentos_caract.Namespace = "http://www.tempuri.org/dsPagamentos_caract.xsd";
            this.dsPagamentos_caract.Tables.AddRange(new System.Data.DataTable[] {
            this.PAGAMENTOS_CARACT});
            // 
            // PAGAMENTOS_CARACT
            // 
            this.PAGAMENTOS_CARACT.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_PC,
            this.CNPJ_CLIENTE_PC,
            this.NUMERO_PC,
            this.TIPO_PC});
            this.PAGAMENTOS_CARACT.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_PC"}, true)});
            this.PAGAMENTOS_CARACT.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_PC};
            this.PAGAMENTOS_CARACT.TableName = "PAGAMENTOS_CARACT";
            // 
            // COD_PC
            // 
            this.COD_PC.AllowDBNull = false;
            this.COD_PC.ColumnName = "COD_PC";
            this.COD_PC.DataType = typeof(int);
            // 
            // CNPJ_CLIENTE_PC
            // 
            this.CNPJ_CLIENTE_PC.ColumnName = "CNPJ_CLIENTE_PC";
            this.CNPJ_CLIENTE_PC.MaxLength = 100;
            // 
            // NUMERO_PC
            // 
            this.NUMERO_PC.ColumnName = "NUMERO_PC";
            this.NUMERO_PC.DataType = typeof(int);
            // 
            // TIPO_PC
            // 
            this.TIPO_PC.ColumnName = "TIPO_PC";
            this.TIPO_PC.MaxLength = 100;
            // 
            // cODPCDataGridViewTextBoxColumn
            // 
            this.cODPCDataGridViewTextBoxColumn.DataPropertyName = "COD_PC";
            this.cODPCDataGridViewTextBoxColumn.HeaderText = "COD_PC";
            this.cODPCDataGridViewTextBoxColumn.Name = "cODPCDataGridViewTextBoxColumn";
            this.cODPCDataGridViewTextBoxColumn.Visible = false;
            // 
            // cNPJCLIENTEPCDataGridViewTextBoxColumn
            // 
            this.cNPJCLIENTEPCDataGridViewTextBoxColumn.DataPropertyName = "CNPJ_CLIENTE_PC";
            this.cNPJCLIENTEPCDataGridViewTextBoxColumn.HeaderText = "CNPJ_CLIENTE_PC";
            this.cNPJCLIENTEPCDataGridViewTextBoxColumn.Name = "cNPJCLIENTEPCDataGridViewTextBoxColumn";
            this.cNPJCLIENTEPCDataGridViewTextBoxColumn.Visible = false;
            // 
            // nUMEROPCDataGridViewTextBoxColumn
            // 
            this.nUMEROPCDataGridViewTextBoxColumn.DataPropertyName = "NUMERO_PC";
            this.nUMEROPCDataGridViewTextBoxColumn.HeaderText = "Número";
            this.nUMEROPCDataGridViewTextBoxColumn.Name = "nUMEROPCDataGridViewTextBoxColumn";
            // 
            // tIPOPCDataGridViewTextBoxColumn
            // 
            this.tIPOPCDataGridViewTextBoxColumn.DataPropertyName = "TIPO_PC";
            this.tIPOPCDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tIPOPCDataGridViewTextBoxColumn.Name = "tIPOPCDataGridViewTextBoxColumn";
            // 
            // form_clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 495);
            this.Controls.Add(this.panelContasaReceber);
            this.Controls.Add(this.label85);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.cbxAtivoCliente);
            this.Controls.Add(this.label73);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.apaga_registro);
            this.Controls.Add(this.salva_registro);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.novo_registro);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.razao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.label1);
            this.Name = "form_clientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.form_clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CLIENTES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsContatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CONTATOS)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsVendedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VENDEDORES_CLIENTE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsItens_tp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITENS_TP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsItemPedAntigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITEMPED)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPedidos_venda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PEDIDOS_VENDA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsClassificacaoClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CLASSIFICACAO_CLIENTES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFormaPagamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FORMA_PGTO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsContas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CONTAS_A_RECEBER)).EndInit();
            this.panelContasaReceber.ResumeLayout(false);
            this.panelContasaReceber.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvValor_cliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsValor_operacao_cliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VALOR_OPERACAO_CLIENTE)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos_venda)).EndInit();
            this.tabPageVendas.ResumeLayout(false);
            this.tabPageVendas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemPedAntigo)).EndInit();
            this.tabPageTabelaPrecos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens_tp)).EndInit();
            this.tabPageOutros.ResumeLayout(false);
            this.tabPageOutros.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendedoresCliente)).EndInit();
            this.tabPageDadosAdicionais.ResumeLayout(false);
            this.tabPageDadosAdicionais.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPageDadosComuns.ResumeLayout(false);
            this.tabPageDadosComuns.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContatos)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagamentos_caract)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPagamentos_caract)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PAGAMENTOS_CARACT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox codigo;
        private System.Windows.Forms.TextBox razao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button novo_registro;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button salva_registro;
        private System.Windows.Forms.Button apaga_registro;
        private System.Windows.Forms.Label labelNome;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datClientes;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand7;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand5;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand6;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder fbCommandBuilder1;
        private System.Data.DataSet dsClientes;
        private System.Data.DataTable CLIENTES;
        private System.Data.DataColumn COD_CLIENTE;
        private System.Data.DataColumn NOME_FANTASIA;
        private System.Data.DataColumn IE;
        private System.Data.DataColumn IM;
        private System.Data.DataColumn ENDERECO;
        private System.Data.DataColumn BAIRRO;
        private System.Data.DataColumn CIDADE;
        private System.Data.DataColumn ESTADO;
        private System.Data.DataColumn PAIS;
        private System.Data.DataColumn FONE;
        private System.Data.DataColumn EMAIL;
        private System.Data.DataColumn CONTATO1;
        private System.Data.DataColumn FONE1;
        private System.Data.DataColumn EMAIL1;
        private System.Data.DataColumn CONTATO2;
        private System.Data.DataColumn FONE2;
        private System.Data.DataColumn EMAIL2;
        private System.Data.DataColumn CNPJ;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Data.DataColumn dataColumn7;
        private System.Data.DataColumn dataColumn8;
        private System.Data.DataColumn dataColumn9;
        private System.Data.DataColumn RAZAO_SOCIAL;
        private System.Windows.Forms.Button button1;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datContatos;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand10;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand8;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand9;
        private System.Data.DataSet dsContatos;
        private System.Data.DataTable CONTATOS;
        private System.Data.DataColumn COD_CONTATO;
        private System.Data.DataColumn NOME_CONTATO;
        private System.Data.DataColumn EMAIL_CONTATO;
        private System.Data.DataColumn TEL_1_CONTATO;
        private System.Data.DataColumn TEL_2_CONTATO;
        private System.Data.DataColumn CLIENTE_FORN_CONTATO;
        private System.Data.DataColumn COD_CLIENTE_FORN_CONTATO;
        private System.Data.DataColumn TIPO_CONTATO;
        private System.Data.DataColumn dataColumn10;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.TextBox textBox24;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.TextBox textBox25;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.TextBox textBox26;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.TextBox textBox27;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.TextBox textBox28;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox textBox29;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.TextBox textBox30;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.TextBox textBox31;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.TextBox textBox32;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.TextBox textBox33;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.TextBox textBox34;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.TextBox textBox35;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.TextBox textBox36;
        private System.Windows.Forms.TextBox textBox37;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.TextBox textBox38;
        private System.Windows.Forms.TextBox textBox39;
        private System.Windows.Forms.TextBox textBox40;
        private System.Windows.Forms.TextBox textBox41;
        private System.Windows.Forms.TextBox textBox42;
        private System.Windows.Forms.TextBox textBox43;
        private System.Windows.Forms.TextBox textBox44;
        private System.Data.DataColumn dataColumn11;
        private System.Data.DataColumn dataColumn12;
        private System.Data.DataColumn dataColumn13;
        private System.Data.DataColumn dataColumn14;
        private System.Data.DataColumn dataColumn15;
        private System.Data.DataColumn dataColumn16;
        private System.Data.DataColumn dataColumn17;
        private System.Data.DataColumn dataColumn18;
        private System.Data.DataColumn dataColumn19;
        private System.Data.DataColumn dataColumn20;
        private System.Data.DataColumn dataColumn21;
        private System.Data.DataColumn dataColumn22;
        private System.Data.DataColumn dataColumn23;
        private System.Data.DataColumn dataColumn24;
        private System.Data.DataColumn dataColumn25;
        private System.Data.DataColumn dataColumn26;
        private System.Data.DataColumn dataColumn27;
        private System.Data.DataColumn dataColumn28;
        private System.Data.DataColumn dataColumn29;
        private System.Data.DataColumn dataColumn30;
        private System.Windows.Forms.Label label73;
        private System.Data.DataColumn dataColumn31;
        private System.Data.DataColumn dataColumn32;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datClassificacaoClientes;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand14;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand12;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand11;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand13;
        private System.Data.DataSet dsClassificacaoClientes;
        private System.Data.DataTable CLASSIFICACAO_CLIENTES;
        private System.Data.DataColumn COD;
        private System.Data.DataColumn DESCRICAO;
        private System.Data.DataColumn dataColumn33;
        private System.Data.DataColumn dataColumn34;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datFormaPagamento;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand18;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand16;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand15;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand17;
        private System.Data.DataSet dsFormaPagamento;
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
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand22;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand20;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand21;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbVendedores;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datVendedores;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand25;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand23;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand19;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand24;
        private System.Data.DataSet dsVendedores;
        private System.Data.DataTable VENDEDORES_CLIENTE;
        private System.Data.DataColumn COD_VC;
        private System.Data.DataColumn COD_CLIENTE_VC;
        private System.Data.DataColumn COD_VENDEDOR_VC;
        private System.Data.DataColumn NOME_VENDEDOR_VC;
        private System.Windows.Forms.CheckBox cbxAtivoCliente;
        private System.Data.DataColumn dataColumn35;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbContatos;
        private System.Data.DataColumn dataColumn36;
        private System.Data.DataColumn dataColumn37;
        private System.Data.DataColumn dataColumn38;
        private System.Data.DataColumn dataColumn39;
        private System.Windows.Forms.DataGridView dgvContas;
        private System.Data.DataSet dsContas;
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
        private System.Data.DataColumn PLANO_CR;
        private System.Data.DataColumn CARTEIRA_CR;
        private System.Data.DataColumn COD_PLANO_CR;
        private System.Data.DataColumn VALOR_ATUALIZADO_CR;
        private System.Data.DataColumn DESCRICAO_CC_CR;
        private System.Data.DataColumn OBSERVACOES_CR;
        private System.Data.DataColumn CC_CR;
        private System.Data.DataColumn REMESSA_CR;
        private System.Data.DataColumn DATA_CRIACAO_CR;
        private System.Data.DataColumn ROMANEIO_CR;
        private System.Data.DataColumn DATA_VENC_ORIGINAL_CR;
        private System.Windows.Forms.Label label79;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datContas;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand29;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand27;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand26;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand28;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.TextBox tb_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODCRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAPREVISTACRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRICAOCRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nFCRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATARECEBIMENTOCRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODCLIENTECRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAZAOCLIENTECRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dUPLICATACRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rECEBIDOCRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODCAIXACRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLANOCRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cARTEIRACRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODPLANOCRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORATUALIZADOCRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRICAOCCCRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oBSERVACOESCRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCCRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEMESSACRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATACRIACAOCRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rOMANEIOCRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAVENCORIGINALCRDataGridViewTextBoxColumn;
        private System.Data.DataColumn dataColumn40;
        private System.Data.DataColumn dataColumn41;
        private System.Data.DataColumn dataColumn42;
        private System.Data.DataColumn dataColumn43;
        private System.Data.DataColumn dataColumn44;
        private System.Data.DataColumn dataColumn45;
        private System.Data.DataColumn dataColumn46;
        private System.Data.DataColumn dataColumn47;
        private System.Data.DataColumn dataColumn48;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.Label label85;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datItens_tp;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand33;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand31;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand30;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand32;
        private System.Data.DataSet dsItens_tp;
        private System.Data.DataTable ITENS_TP;
        private System.Data.DataColumn COD_ITEM_TP;
        private System.Data.DataColumn COD_TABELA_ITEM_TP;
        private System.Data.DataColumn COD_PRODUTO_ITEM_TP;
        private System.Data.DataColumn DESCRICAO_PRODUTO_ITEM_TP;
        private System.Data.DataColumn PRECO_PRODUTO_ITEM_TP;
        private System.Data.DataColumn PRECO_MINIMO_ITEM_TP;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbItens_tp;
        private System.Data.DataSet dsItemPedAntigo;
        private System.Data.DataTable ITEMPED;
        private System.Data.DataColumn PEDPROD;
        private System.Data.DataColumn DESCRICAO_PROD;
        private System.Data.DataColumn PEDVLUNI;
        private System.Data.DataColumn PC_CLI;
        private System.Data.DataColumn RAZAO_CLI;
        private System.Data.DataColumn PC_EMISSAO;
        private System.Data.DataColumn PC_NRPED;
        private System.Data.DataColumn QT_VEND;
        private System.Data.DataColumn VL_TOTAL;
        private System.Data.DataColumn FP_DESCR;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand34;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand35;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand36;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand37;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand38;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand39;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand40;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand41;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datItemPedAntigo;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand45;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand43;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand42;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand44;
        private System.Windows.Forms.Panel panelContasaReceber;
        private System.Data.DataSet dsPedidos_venda;
        private System.Data.DataTable PEDIDOS_VENDA;
        private System.Data.DataColumn COD_PED_VENDA;
        private System.Data.DataColumn N_PED_VENDA;
        private System.Data.DataColumn DATA_PED_VENDA;
        private System.Data.DataColumn DATA_BAIXA_PED_VENDA;
        private System.Data.DataColumn CLIENTE_PED_VENDA;
        private System.Data.DataColumn CNPJ_PED_VENDA;
        private System.Data.DataColumn COND_PGTO_PED_VENDA;
        private System.Data.DataColumn VALOR_TOTAL_PROD_PED_VENDA;
        private System.Data.DataColumn VALOR_TOTAL_PED_VENDA;
        private System.Data.DataColumn VALOR_TOTAL_ICMS_PED_VENDA;
        private System.Data.DataColumn VALOR_TOTAL_IPI_PED_VENDA;
        private System.Data.DataColumn VALOR_DESCONTO_PED_VENDA;
        private System.Data.DataColumn OBS_PED_VENDA;
        private System.Data.DataColumn NF_PED_VENDA;
        private System.Data.DataColumn BAIXADO_ESTOQUE_PED_VENDA;
        private System.Data.DataColumn PAGO_PED_VENDA;
        private System.Data.DataColumn COD_CAIXA_PGTO_PED_VENDA;
        private System.Data.DataColumn VENDEDOR_PED_VENDA;
        private System.Data.DataColumn COD_VENDEDOR_PED_VENDA;
        private System.Data.DataColumn CANCELADO_PED_VENDA;
        private System.Data.DataColumn NOME_CONTATO_PED_VENDA;
        private System.Data.DataColumn TELEFONE_CONTATO_PED_VENDA;
        private System.Data.DataColumn EMAIL_CONTATO_PED_VENDA;
        private System.Data.DataColumn PORC_DESCONTO_PED_VENDA;
        private System.Data.DataColumn N_NF_PED_VENDA;
        private System.Data.DataColumn ID_PEDIDO_CEL_PED_VENDA;
        private System.Data.DataColumn IMPRESSO_PED_VENDA;
        private System.Data.DataColumn DATA_ENTREGA_PED_VENDA;
        private System.Data.DataColumn QTDE_ITENS_PED_VENDA;
        private System.Data.DataColumn TROCA_PED_VENDA;
        private System.Data.DataColumn BONIFICACAO_PED_VENDA;
        private System.Data.DataColumn SAIDA_VENDA_DIRETA_PED_VENDA;
        private System.Data.DataColumn VENDA_DIRETA_PED_VENDA;
        private System.Data.DataColumn NF_ENTRADA_PED_VENDA;
        private System.Data.DataColumn COD_PEDIDO_PAI_PED_VENDA;
        private System.Data.DataColumn ORCAMENTO_PED_VENDA;
        private System.Data.DataColumn COD_LRW_PED_VENDA;
        private System.Data.DataColumn COD_CAIXA_PED_VENDA;
        private System.Data.DataColumn DATA_NF_PED_VENDA;
        private System.Data.DataColumn QTDE_TOTAL_PED_VENDA;
        private System.Data.DataColumn DATA_EXPORTACAO_PED_VENDA;
        private System.Data.DataColumn HORA_EXPORTACAO_PED_VENDA;
        private System.Data.DataColumn DEGUSTACAO_PED_VENDA;
        private System.Data.DataColumn DEVOLUCAO_PED_VENDA;
        private System.Data.DataColumn PV_PED_VENDA;
        private System.Data.DataColumn COD_TP_PED_VENDA;
        private System.Data.DataColumn DESCRICAO_TP_PED_VENDA;
        private System.Data.DataColumn TRANSPORTADORA_PED_VENDA;
        private System.Data.DataColumn PLACA_TRANSP_PED_VENDA;
        private System.Data.DataColumn CNPJ_EMISSOR_PED_VENDA;
        private System.Data.DataColumn RAZAO_EMISSOR_PED_VENDA;
        private System.Data.DataColumn VALOR_ST_PED_VENDA;
        private System.Data.DataColumn VALOR_TOTAL_DESEJADO_PED_VENDA;
        private System.Data.DataColumn PERC_DESEJADO_PED_VENDA;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datPedidos_venda;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand49;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand47;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand46;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand48;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox52;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox53;
        private System.Windows.Forms.Label label89;
        private System.Windows.Forms.TextBox textBox54;
        private System.Windows.Forms.Label label90;
        private System.Data.DataSet dsValor_operacao_cliente;
        private System.Data.DataTable VALOR_OPERACAO_CLIENTE;
        private System.Data.DataColumn COD_VOC;
        private System.Data.DataColumn OPERACAO_VOC;
        private System.Data.DataColumn VALOR_HORA_VOC;
        private System.Data.DataColumn CNPJ_CLIENTE_VOC;
        private System.Data.DataColumn dataColumn49;
        private System.Data.DataColumn dataColumn50;
        private System.Data.DataColumn dataColumn51;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvPedidos_venda;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bAIXADOESTOQUEPEDVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAZAOEMISSORPEDVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod_interno;
        private System.Windows.Forms.DataGridViewTextBoxColumn nPEDVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAPEDVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATABAIXAPEDVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONDPGTOPEDVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORTOTALPRODPEDVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORTOTALPEDVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oBSPEDVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vENDEDORPEDVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabPageVendas;
        private System.Windows.Forms.Label label88;
        private System.Windows.Forms.Label label87;
        private System.Windows.Forms.Label label86;
        private System.Windows.Forms.TextBox tbFormaPgto;
        private System.Windows.Forms.TextBox tbNPedido;
        private System.Windows.Forms.TextBox tbDescricaoProduto;
        private System.Windows.Forms.DataGridView dgvItemPedAntigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn pCNRPEDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pCEMISSAODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fPDESCRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pEDPRODDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRICAOPRODDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pEDVLUNIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qTVENDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pCCLIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAZAOCLIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vLTOTALDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabPageTabelaPrecos;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.DataGridView dgvItens_tp;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODITEMTPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODTABELAITEMTPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODPRODUTOITEMTPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRICAOPRODUTOITEMTPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRECOPRODUTOITEMTPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRECOMINIMOITEMTPDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TabPage tabPageOutros;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tb_fim_entrega;
        private System.Windows.Forms.Label label83;
        private System.Windows.Forms.TextBox tb_inicio_entrega;
        private System.Windows.Forms.Label label84;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox textBox51;
        private System.Windows.Forms.TextBox tb_dia_visita;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cbxClassificacao1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dgvVendedoresCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODVCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODCLIENTEVCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODVENDEDORVCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMEVENDEDORVCDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnInserirVendedor;
        private System.Windows.Forms.TextBox txtNomeVendedor;
        private System.Windows.Forms.TextBox txtCodVendedor;
        private System.Windows.Forms.ComboBox cbxFormaPagamento;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TabPage tabPageDadosAdicionais;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.TextBox tb_nome_tabela_preco;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.TextBox tb_cod_tabela;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.TextBox textBox50;
        private System.Windows.Forms.TextBox textBox49;
        private System.Windows.Forms.TextBox textBox48;
        private System.Windows.Forms.TextBox textBox47;
        private System.Windows.Forms.TextBox textBox46;
        private System.Windows.Forms.TextBox textBox45;
        private System.Windows.Forms.TextBox tb_cobranca;
        private System.Windows.Forms.TextBox tb_entrega;
        private System.Windows.Forms.TextBox tb_icm;
        private System.Windows.Forms.TextBox tb_ipi;
        private System.Windows.Forms.TextBox tb_class;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TabPage tabPageDadosComuns;
        private System.Windows.Forms.TextBox tb_obs;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox tb_cod_pais;
        private System.Windows.Forms.TextBox tb_tipo;
        private System.Windows.Forms.TextBox tb_telefone_2;
        private System.Windows.Forms.TextBox tb_cod_cidade;
        private System.Windows.Forms.TextBox tb_telefone_1;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_n;
        private System.Windows.Forms.TextBox tb_nome_contato;
        private System.Windows.Forms.TextBox tb_Cep;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox tb_fone;
        private System.Windows.Forms.TextBox tb_pais;
        private System.Windows.Forms.TextBox tb_estado;
        private System.Windows.Forms.TextBox tb_cidade;
        private System.Windows.Forms.TextBox tb_bairro;
        private System.Windows.Forms.TextBox tb_logradouro;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox tb_ie;
        private System.Windows.Forms.TextBox tb_cnpj;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox cb_pessoa_fisica;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.DataGridView dgvContatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODCONTATODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMECONTATODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILCONTATODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tEL1CONTATODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tEL2CONTATODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTEFORNCONTATODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tabControl1;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datValor_operacao_cliente;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbValor_operacao_cliente;
        private System.Windows.Forms.DataGridView dgvValor_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPERACAOVOCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEQUENCIA_OPER_VOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORHORAVOCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR_HORA_MOLDE_VOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR_HORA_PECA_VOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPJCLIENTEVOCDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Label label93;
        private System.Windows.Forms.TextBox tb_n_pgto;
        private System.Windows.Forms.Label label92;
        private System.Windows.Forms.Label label91;
        private System.Windows.Forms.ComboBox cbTipo_pgto;
        private System.Windows.Forms.DataGridView dgvPagamentos_caract;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODPCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPJCLIENTEPCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMEROPCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIPOPCDataGridViewTextBoxColumn;
        private System.Data.DataSet dsPagamentos_caract;
        private System.Data.DataTable PAGAMENTOS_CARACT;
        private System.Data.DataColumn COD_PC;
        private System.Data.DataColumn CNPJ_CLIENTE_PC;
        private System.Data.DataColumn NUMERO_PC;
        private System.Data.DataColumn TIPO_PC;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datPagamentos_caract;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand53;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand51;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand50;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand52;
    }
}

