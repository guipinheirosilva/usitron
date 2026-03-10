namespace Evolucao
{
    partial class form_produto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_produto));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.datProdutos = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.label20 = new System.Windows.Forms.Label();
            this.tb_cod = new System.Windows.Forms.TextBox();
            this.dsProdutos = new System.Data.DataSet();
            this.PRODUTOS = new System.Data.DataTable();
            this.COD_PRODUTO = new System.Data.DataColumn();
            this.COD_GRUPO_PRODUTO = new System.Data.DataColumn();
            this.DESCRICAO_GRUPO_PRODUTO = new System.Data.DataColumn();
            this.COD_SUB_GRUPO_PRODUTO = new System.Data.DataColumn();
            this.DESCRICAO_SUB_GRUPO_PRODUTO = new System.Data.DataColumn();
            this.DESCRICAO_PRODUTO = new System.Data.DataColumn();
            this.CARACT_ADIC_PRODUTO = new System.Data.DataColumn();
            this.COD_BARRAS_PRODUTO = new System.Data.DataColumn();
            this.COD_ONU_PRODUTO = new System.Data.DataColumn();
            this.CLASSE_TOXIC_PRODUTO = new System.Data.DataColumn();
            this.COD_UNIDADE_PRODUTO = new System.Data.DataColumn();
            this.DESCRICAO_UNIDADE_PRODUTO = new System.Data.DataColumn();
            this.META_ANUAL_PRODUTO = new System.Data.DataColumn();
            this.COD_REDUZIDO_PRODUTO = new System.Data.DataColumn();
            this.TAB_PRODUTO = new System.Data.DataColumn();
            this.META_SEMESTRAL_PRODUTO = new System.Data.DataColumn();
            this.ESTOQUE_ATUAL_PRODUTO = new System.Data.DataColumn();
            this.ESTOQUE_RESERVADO_PRODUTO = new System.Data.DataColumn();
            this.ESTOQUE_MINIMO_PRODUTO = new System.Data.DataColumn();
            this.ESTOQUE_ENCOMENDADO_PRODUTO = new System.Data.DataColumn();
            this.ESTOQUE_MAXIMO_PRODUTO = new System.Data.DataColumn();
            this.ESTOQUE_MEDIO_PRODUTO = new System.Data.DataColumn();
            this.CUSTO_PRODUTO = new System.Data.DataColumn();
            this.CUSTO_MED_PRODUTO = new System.Data.DataColumn();
            this.VALOR_VENDA_PRODUTOR_PRODUTO = new System.Data.DataColumn();
            this.VALOR_VENDA_REVEND_PRODUTO = new System.Data.DataColumn();
            this.VALOR_PROMOCAO_PRODUTO = new System.Data.DataColumn();
            this.OUTRO_VALOR_PRODUTO = new System.Data.DataColumn();
            this.LUCRO_PRODUTO = new System.Data.DataColumn();
            this.ULT_REAJ_PRODUTO = new System.Data.DataColumn();
            this.PROD_RECEITA_PRODUTO = new System.Data.DataColumn();
            this.ICMS_S_N_PRODUTO = new System.Data.DataColumn();
            this.ALIQUOTA_ICMS_PRODUTO = new System.Data.DataColumn();
            this.REDUCAO_FORA_PRODUTO = new System.Data.DataColumn();
            this.ALIQUOTA_IPI_PRODUTO = new System.Data.DataColumn();
            this.PIS_PRODUTO = new System.Data.DataColumn();
            this.COFINS_PRODUTO = new System.Data.DataColumn();
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
            this.dataColumn62 = new System.Data.DataColumn();
            this.dataColumn63 = new System.Data.DataColumn();
            this.dataColumn64 = new System.Data.DataColumn();
            this.dataColumn65 = new System.Data.DataColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_cod_grupo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_grupo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tb_sub_grupo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_cod_sub_grupo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button29 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.tb_familia = new System.Windows.Forms.TextBox();
            this.label65 = new System.Windows.Forms.Label();
            this.btnSelecionarFornecedor = new System.Windows.Forms.Button();
            this.txtNomeFornecedor = new System.Windows.Forms.TextBox();
            this.label61 = new System.Windows.Forms.Label();
            this.txtCnpjFornecedor = new System.Windows.Forms.TextBox();
            this.label62 = new System.Windows.Forms.Label();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.textBox33 = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.textBox34 = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tb_descricao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bt_localizar = new System.Windows.Forms.Button();
            this.bt_excluir = new System.Windows.Forms.Button();
            this.bt_salvar = new System.Windows.Forms.Button();
            this.bt_novo = new System.Windows.Forms.Button();
            this.fbCommand5 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand6 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand7 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand8 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.cbProdutos = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.fbCommand12 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand10 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand9 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand11 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.datItens_nf_entrada = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand16 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand14 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand13 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand15 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.nFITEMENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uNIDADEITEMENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qTDEITEMENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsItens_nf_entrada = new System.Data.DataSet();
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
            this.LOTE_ITEM_ENT = new System.Data.DataColumn();
            this.QTDE_LOTE_ITEM_ENT = new System.Data.DataColumn();
            this.NOME_PROPRIETARIO_ITEM_ENT = new System.Data.DataColumn();
            this.CNPJ_PROPRIETARIO_ITEM = new System.Data.DataColumn();
            this.BAIXADO_ITEM_ENT = new System.Data.DataColumn();
            this.MATERIA_PRIMA_ITEM_ENT = new System.Data.DataColumn();
            this.ALMOXARIFADO_ITEM_ENT = new System.Data.DataColumn();
            this.COD_EAN_ITEM_ENT = new System.Data.DataColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvItens_nota = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsItens_nota = new System.Data.DataSet();
            this.ITENS_NOTA = new System.Data.DataTable();
            this.N_NF = new System.Data.DataColumn();
            this.DATA_EMISSAO_NF = new System.Data.DataColumn();
            this.CLIENTE_FORN_NF = new System.Data.DataColumn();
            this.QTDE_ITEM = new System.Data.DataColumn();
            this.UNIDADE_ITEM = new System.Data.DataColumn();
            this.N_PEDIDO_NF = new System.Data.DataColumn();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.cbItens_ped_venda = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.cbItens_nf_entrada = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.button11 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.txtCodAlternativo = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label47 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label76 = new System.Windows.Forms.Label();
            this.cbPis_cofins = new System.Windows.Forms.CheckBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label77 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label78 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label79 = new System.Windows.Forms.Label();
            this.cb_cod_sit_trib_pis = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox30 = new System.Windows.Forms.TextBox();
            this.label81 = new System.Windows.Forms.Label();
            this.textBox46 = new System.Windows.Forms.TextBox();
            this.label59 = new System.Windows.Forms.Label();
            this.textBox45 = new System.Windows.Forms.TextBox();
            this.label58 = new System.Windows.Forms.Label();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.label50 = new System.Windows.Forms.Label();
            this.textBox35 = new System.Windows.Forms.TextBox();
            this.label51 = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.textBox40 = new System.Windows.Forms.TextBox();
            this.label53 = new System.Windows.Forms.Label();
            this.textBox42 = new System.Windows.Forms.TextBox();
            this.label54 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox47 = new System.Windows.Forms.TextBox();
            this.label60 = new System.Windows.Forms.Label();
            this.textBox44 = new System.Windows.Forms.TextBox();
            this.label57 = new System.Windows.Forms.Label();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.textBox37 = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.textBox38 = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.textBox39 = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button13 = new System.Windows.Forms.Button();
            this.tb_coeficiente = new System.Windows.Forms.TextBox();
            this.label67 = new System.Windows.Forms.Label();
            this.txtDescontoMaximo = new System.Windows.Forms.TextBox();
            this.label63 = new System.Windows.Forms.Label();
            this.textBox41 = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.textBox31 = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.tb_lucro_produto = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.tb_minimo = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.tb_venda = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.textBox29 = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.tb_custo = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox32 = new System.Windows.Forms.TextBox();
            this.label89 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label73 = new System.Windows.Forms.Label();
            this.tb_estoque_medio = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tb_estoque_atual = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.label80 = new System.Windows.Forms.Label();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.label75 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label66 = new System.Windows.Forms.Label();
            this.txtCodBarrasCaixa = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_qtde_caixa = new System.Windows.Forms.TextBox();
            this.label64 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.txtCodBarrasUnit = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_unidade = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_cod_unidade = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.label70 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.tb_comissao = new System.Windows.Forms.TextBox();
            this.button14 = new System.Windows.Forms.Button();
            this.btnInserirVendedor = new System.Windows.Forms.Button();
            this.txtNomeVendedor = new System.Windows.Forms.TextBox();
            this.txtCodVendedor = new System.Windows.Forms.TextBox();
            this.dgvComissao = new System.Windows.Forms.DataGridView();
            this.cODCPVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODVENDEDORCPVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMEVENDEDORCPVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODPRODUTOCPVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pORCCOMISSAOCPVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsCpv = new System.Data.DataSet();
            this.COMISSAO_PRODUTO_VENDEDOR = new System.Data.DataTable();
            this.COD_CPV = new System.Data.DataColumn();
            this.COD_VENDEDOR_CPV = new System.Data.DataColumn();
            this.COD_PRODUTO_CPV = new System.Data.DataColumn();
            this.PORC_COMISSAO_CPV = new System.Data.DataColumn();
            this.NOME_VENDEDOR_CPV = new System.Data.DataColumn();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button33 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.dgvKit = new System.Windows.Forms.DataGridView();
            this.col_cod_pk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COD_FORN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRICAOPKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qTDEPKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORUNITPKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsProdutos_kit = new System.Data.DataSet();
            this.PRODUTOS_KIT = new System.Data.DataTable();
            this.COD_PK = new System.Data.DataColumn();
            this.COD_PRODUTO_PK = new System.Data.DataColumn();
            this.DESCRICAO_PK = new System.Data.DataColumn();
            this.QTDE_PK = new System.Data.DataColumn();
            this.VALOR_UNIT_PK = new System.Data.DataColumn();
            this.COD_KIT_PK = new System.Data.DataColumn();
            this.dataColumn61 = new System.Data.DataColumn();
            this.label83 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.tb_cod_item = new System.Windows.Forms.TextBox();
            this.label72 = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.tb_qtde_kit = new System.Windows.Forms.TextBox();
            this.tb_item_item = new System.Windows.Forms.TextBox();
            this.button15 = new System.Windows.Forms.Button();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.label88 = new System.Windows.Forms.Label();
            this.tb_item = new System.Windows.Forms.TextBox();
            this.label86 = new System.Windows.Forms.Label();
            this.tb_un_componente = new System.Windows.Forms.TextBox();
            this.button16 = new System.Windows.Forms.Button();
            this.label84 = new System.Windows.Forms.Label();
            this.tb_cod_componente = new System.Windows.Forms.TextBox();
            this.label85 = new System.Windows.Forms.Label();
            this.label87 = new System.Windows.Forms.Label();
            this.tb_qtde_componente = new System.Windows.Forms.TextBox();
            this.tb_descricao_componente = new System.Windows.Forms.TextBox();
            this.button30 = new System.Windows.Forms.Button();
            this.dgvItens_produto = new System.Windows.Forms.DataGridView();
            this.cODIPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODESTOQUEIPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRICAOIPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qTDEIPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsItens_produto = new System.Data.DataSet();
            this.ITENS_PRODUTO = new System.Data.DataTable();
            this.COD_IP = new System.Data.DataColumn();
            this.COD_ESTOQUE_IP = new System.Data.DataColumn();
            this.DESCRICAO_IP = new System.Data.DataColumn();
            this.QTDE_IP = new System.Data.DataColumn();
            this.COD_PRODUTO_IP = new System.Data.DataColumn();
            this.UN_IP = new System.Data.DataColumn();
            this.ITEM_IP = new System.Data.DataColumn();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button19 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.label52 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label82 = new System.Windows.Forms.Label();
            this.dgvProd = new System.Windows.Forms.DataGridView();
            this.col_n_etiqueta_prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_op_prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qTDEETIQUETADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_status_prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsEtiquetas = new System.Data.DataSet();
            this.PRODUCAO = new System.Data.DataTable();
            this.dataColumn42 = new System.Data.DataColumn();
            this.dataColumn43 = new System.Data.DataColumn();
            this.dataColumn44 = new System.Data.DataColumn();
            this.dataColumn45 = new System.Data.DataColumn();
            this.ESTOQUE = new System.Data.DataTable();
            this.dataColumn46 = new System.Data.DataColumn();
            this.dataColumn47 = new System.Data.DataColumn();
            this.dataColumn48 = new System.Data.DataColumn();
            this.dataColumn49 = new System.Data.DataColumn();
            this.RESERVA = new System.Data.DataTable();
            this.dataColumn50 = new System.Data.DataColumn();
            this.dataColumn51 = new System.Data.DataColumn();
            this.dataColumn52 = new System.Data.DataColumn();
            this.dataColumn53 = new System.Data.DataColumn();
            this.dataColumn54 = new System.Data.DataColumn();
            this.SAIDA = new System.Data.DataTable();
            this.dataColumn55 = new System.Data.DataColumn();
            this.dataColumn56 = new System.Data.DataColumn();
            this.dataColumn57 = new System.Data.DataColumn();
            this.dataColumn58 = new System.Data.DataColumn();
            this.dataColumn59 = new System.Data.DataColumn();
            this.dataColumn60 = new System.Data.DataColumn();
            this.dgvSaidas = new System.Windows.Forms.DataGridView();
            this.N_ETIQUETA_SAIDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OP_ETIQUETA_SAIDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qTDEETIQUETADataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPSAIDAETIQUETADataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nFSAIDAETIQUETADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTATUSETIQUETADataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvReserva = new System.Windows.Forms.DataGridView();
            this.N_ETIQUETA_RESERVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OP_ETIQUETA_RESERVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qTDEETIQUETADataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPSAIDAETIQUETADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTATUSETIQUETADataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEstoque = new System.Windows.Forms.DataGridView();
            this.N_ETIQUETA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OP_ETIQUETA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTDE_ETIQUETA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTATUSETIQUETADataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.button31 = new System.Windows.Forms.Button();
            this.dgvDesenhos = new System.Windows.Forms.DataGridView();
            this.cODDESPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_abrir_desenho = new System.Windows.Forms.DataGridViewButtonColumn();
            this.col_link = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIPODESPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cODPRODDESPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsDesenhos_produto = new System.Data.DataSet();
            this.DESENHOS_PRODUTO = new System.Data.DataTable();
            this.COD_DES_PRODUTO = new System.Data.DataColumn();
            this.LINK_DES_PRODUTO = new System.Data.DataColumn();
            this.TIPO_DES_PRODUTO = new System.Data.DataColumn();
            this.COD_PROD_DES_PRODUTO = new System.Data.DataColumn();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label48 = new System.Windows.Forms.Label();
            this.cb_origem_mercadoria = new System.Windows.Forms.ComboBox();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.datItens_nota = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand20 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand18 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand17 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand19 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.datCpv = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand24 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand22 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand21 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand23 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.cbCpv = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.button28 = new System.Windows.Forms.Button();
            this.datProdutos_kit = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand28 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand26 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand25 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand27 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.cbProdutos_kit = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.datItens_produto = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand32 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand30 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand29 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand31 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.cbItens_produto = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.datDesenhos_produto = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand36 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand34 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand33 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand35 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cbDesenhos_produto = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.datItens_orcamentos = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand40 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand38 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand37 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand39 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsItens_orcamento = new System.Data.DataSet();
            this.ITENS_ORCAMENTO = new System.Data.DataTable();
            this.COD_ITEM_ORC = new System.Data.DataColumn();
            this.NOME_ITEM_ORC = new System.Data.DataColumn();
            this.QTDE_ITEM_ORC = new System.Data.DataColumn();
            this.HORAS_FRESA_ITEM_ORC = new System.Data.DataColumn();
            this.HORAS_RET_PERFIL_ITEM_ORC = new System.Data.DataColumn();
            this.HORAS_RET_CILIN_ITEM_ORC = new System.Data.DataColumn();
            this.HORAS_EROSAO_PEN_ITEM_ORC = new System.Data.DataColumn();
            this.HORAS_TORNO_CONV_ITEM_ORC = new System.Data.DataColumn();
            this.HORAS_TORNO_CNC_ITEM_ORC = new System.Data.DataColumn();
            this.HORAS_EROSAO_FIO_ITEM_ORC = new System.Data.DataColumn();
            this.HORAS_CENTRO_USI_ITEM_ORC = new System.Data.DataColumn();
            this.HORAS_TRAT_TERM_ITEM_ORC = new System.Data.DataColumn();
            this.HORAS_ELETRODO_CONV_ITEM_ORC = new System.Data.DataColumn();
            this.HORAS_ELETRODO_HIGH_ITEM_ORC = new System.Data.DataColumn();
            this.HORAS_ELETRODO_FIO_ITEM_ORC = new System.Data.DataColumn();
            this.HORAS_HIGH_SPEED_ITEM_ORC = new System.Data.DataColumn();
            this.HORAS_BANCADA_ITEM_ORC = new System.Data.DataColumn();
            this.VALOR_TOTAL_ITEM_ORC = new System.Data.DataColumn();
            this.STATUS_ITEM_ORC = new System.Data.DataColumn();
            this.OBS_ITEM_ORC = new System.Data.DataColumn();
            this.COD_ORCAMENTO_ITEM_ORC = new System.Data.DataColumn();
            this.TOTAL_HORAS_ITEM_ORC = new System.Data.DataColumn();
            this.VALOR_UNIT_ITEM_ORC = new System.Data.DataColumn();
            this.VALOR_MAT_PRI_ITEM_ORC = new System.Data.DataColumn();
            this.PRAZO_ENTREGA_ITEM_ORC = new System.Data.DataColumn();
            this.HORAS_OPER1_ITEM_ORC = new System.Data.DataColumn();
            this.HORAS_OPER2_ITEM_ORC = new System.Data.DataColumn();
            this.HORAS_OPER3_ITEM_ORC = new System.Data.DataColumn();
            this.HORAS_OPER4_ITEM_ORC = new System.Data.DataColumn();
            this.HORAS_OPER5_ITEM_ORC = new System.Data.DataColumn();
            this.HORAS_OPER6_ITEM_ORC = new System.Data.DataColumn();
            this.HORAS_OPER7_ITEM_ORC = new System.Data.DataColumn();
            this.HORAS_OPER8_ITEM_ORC = new System.Data.DataColumn();
            this.HORAS_OPER9_ITEM_ORC = new System.Data.DataColumn();
            this.HORAS_OPER10_ITEM_ORC = new System.Data.DataColumn();
            this.HORAS_OPER11_ITEM_ORC = new System.Data.DataColumn();
            this.HORAS_OPER12_ITEM_ORC = new System.Data.DataColumn();
            this.HORAS_OPER13_ITEM_ORC = new System.Data.DataColumn();
            this.HORAS_OPER14_ITEM_ORC = new System.Data.DataColumn();
            this.COD_ITEM_ITEM_ORC = new System.Data.DataColumn();
            this.HORAS_OPER15_ITEM_ORC = new System.Data.DataColumn();
            this.HORAS_OPER16_ITEM_ORC = new System.Data.DataColumn();
            this.HORAS_OPER17_ITEM_ORC = new System.Data.DataColumn();
            this.HORAS_OPER18_ITEM_ORC = new System.Data.DataColumn();
            this.HORAS_OPER19_ITEM_ORC = new System.Data.DataColumn();
            this.HORAS_OPER20_ITEM_ORC = new System.Data.DataColumn();
            this.HORAS_OPER21_ITEM_ORC = new System.Data.DataColumn();
            this.HORAS_OPER22_ITEM_ORC = new System.Data.DataColumn();
            this.MATERIAL_ITEM_ORC = new System.Data.DataColumn();
            this.KG_PC_ITEM_ORC = new System.Data.DataColumn();
            this.VALOR_MATERIAL_ITEM_ORC = new System.Data.DataColumn();
            this.V_TOTAL_COM_IMPOSTO_ITEM_ORC = new System.Data.DataColumn();
            this.V_UNIT_COM_IMPOSTO_ITEM_ORC = new System.Data.DataColumn();
            this.QTDE_LIBERADA_ITEM_ORC = new System.Data.DataColumn();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.textBox36 = new System.Windows.Forms.TextBox();
            this.label90 = new System.Windows.Forms.Label();
            this.textBox43 = new System.Windows.Forms.TextBox();
            this.label91 = new System.Windows.Forms.Label();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.dataColumn66 = new System.Data.DataColumn();
            this.dataColumn67 = new System.Data.DataColumn();
            this.dataColumn68 = new System.Data.DataColumn();
            this.dataColumn69 = new System.Data.DataColumn();
            this.panel8 = new System.Windows.Forms.Panel();
            this.textBox54 = new System.Windows.Forms.TextBox();
            this.label92 = new System.Windows.Forms.Label();
            this.textBox55 = new System.Windows.Forms.TextBox();
            this.label93 = new System.Windows.Forms.Label();
            this.textBox56 = new System.Windows.Forms.TextBox();
            this.label94 = new System.Windows.Forms.Label();
            this.textBox57 = new System.Windows.Forms.TextBox();
            this.label96 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PRODUTOS)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsItens_nf_entrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITENS_NOTA_ENT)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens_nota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsItens_nota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITENS_NOTA)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComissao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCpv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.COMISSAO_PRODUTO_VENDEDOR)).BeginInit();
            this.tabPage7.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProdutos_kit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PRODUTOS_KIT)).BeginInit();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens_produto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsItens_produto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITENS_PRODUTO)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEtiquetas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PRODUCAO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ESTOQUE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RESERVA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SAIDA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReserva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).BeginInit();
            this.tabPage9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDesenhos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDesenhos_produto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DESENHOS_PRODUTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsItens_orcamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITENS_ORCAMENTO)).BeginInit();
            this.tabPage10.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // datProdutos
            // 
            this.datProdutos.DeleteCommand = this.fbCommand4;
            this.datProdutos.InsertCommand = this.fbCommand2;
            this.datProdutos.SelectCommand = this.fbCommand1;
            this.datProdutos.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * from produtos";
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
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label20.Location = new System.Drawing.Point(194, -4);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(181, 46);
            this.label20.TabIndex = 110;
            this.label20.Text = "Produtos";
            // 
            // tb_cod
            // 
            this.tb_cod.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.COD_PRODUTO", true));
            this.tb_cod.Location = new System.Drawing.Point(56, 45);
            this.tb_cod.Name = "tb_cod";
            this.tb_cod.ReadOnly = true;
            this.tb_cod.Size = new System.Drawing.Size(72, 20);
            this.tb_cod.TabIndex = 111;
            // 
            // dsProdutos
            // 
            this.dsProdutos.DataSetName = "dsProdutos";
            this.dsProdutos.Namespace = "http://www.tempuri.org/dsProdutos.xsd";
            this.dsProdutos.Tables.AddRange(new System.Data.DataTable[] {
            this.PRODUTOS});
            // 
            // PRODUTOS
            // 
            this.PRODUTOS.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_PRODUTO,
            this.COD_GRUPO_PRODUTO,
            this.DESCRICAO_GRUPO_PRODUTO,
            this.COD_SUB_GRUPO_PRODUTO,
            this.DESCRICAO_SUB_GRUPO_PRODUTO,
            this.DESCRICAO_PRODUTO,
            this.CARACT_ADIC_PRODUTO,
            this.COD_BARRAS_PRODUTO,
            this.COD_ONU_PRODUTO,
            this.CLASSE_TOXIC_PRODUTO,
            this.COD_UNIDADE_PRODUTO,
            this.DESCRICAO_UNIDADE_PRODUTO,
            this.META_ANUAL_PRODUTO,
            this.COD_REDUZIDO_PRODUTO,
            this.TAB_PRODUTO,
            this.META_SEMESTRAL_PRODUTO,
            this.ESTOQUE_ATUAL_PRODUTO,
            this.ESTOQUE_RESERVADO_PRODUTO,
            this.ESTOQUE_MINIMO_PRODUTO,
            this.ESTOQUE_ENCOMENDADO_PRODUTO,
            this.ESTOQUE_MAXIMO_PRODUTO,
            this.ESTOQUE_MEDIO_PRODUTO,
            this.CUSTO_PRODUTO,
            this.CUSTO_MED_PRODUTO,
            this.VALOR_VENDA_PRODUTOR_PRODUTO,
            this.VALOR_VENDA_REVEND_PRODUTO,
            this.VALOR_PROMOCAO_PRODUTO,
            this.OUTRO_VALOR_PRODUTO,
            this.LUCRO_PRODUTO,
            this.ULT_REAJ_PRODUTO,
            this.PROD_RECEITA_PRODUTO,
            this.ICMS_S_N_PRODUTO,
            this.ALIQUOTA_ICMS_PRODUTO,
            this.REDUCAO_FORA_PRODUTO,
            this.ALIQUOTA_IPI_PRODUTO,
            this.PIS_PRODUTO,
            this.COFINS_PRODUTO,
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
            this.dataColumn62,
            this.dataColumn63,
            this.dataColumn64,
            this.dataColumn65,
            this.dataColumn66,
            this.dataColumn67,
            this.dataColumn68,
            this.dataColumn69});
            this.PRODUTOS.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_PRODUTO"}, true)});
            this.PRODUTOS.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_PRODUTO};
            this.PRODUTOS.TableName = "PRODUTOS";
            // 
            // COD_PRODUTO
            // 
            this.COD_PRODUTO.AllowDBNull = false;
            this.COD_PRODUTO.ColumnName = "COD_PRODUTO";
            this.COD_PRODUTO.DataType = typeof(long);
            // 
            // COD_GRUPO_PRODUTO
            // 
            this.COD_GRUPO_PRODUTO.ColumnName = "COD_GRUPO_PRODUTO";
            this.COD_GRUPO_PRODUTO.DataType = typeof(int);
            // 
            // DESCRICAO_GRUPO_PRODUTO
            // 
            this.DESCRICAO_GRUPO_PRODUTO.ColumnName = "DESCRICAO_GRUPO_PRODUTO";
            this.DESCRICAO_GRUPO_PRODUTO.MaxLength = 100;
            // 
            // COD_SUB_GRUPO_PRODUTO
            // 
            this.COD_SUB_GRUPO_PRODUTO.ColumnName = "COD_SUB_GRUPO_PRODUTO";
            this.COD_SUB_GRUPO_PRODUTO.DataType = typeof(int);
            // 
            // DESCRICAO_SUB_GRUPO_PRODUTO
            // 
            this.DESCRICAO_SUB_GRUPO_PRODUTO.ColumnName = "DESCRICAO_SUB_GRUPO_PRODUTO";
            this.DESCRICAO_SUB_GRUPO_PRODUTO.MaxLength = 100;
            // 
            // DESCRICAO_PRODUTO
            // 
            this.DESCRICAO_PRODUTO.ColumnName = "DESCRICAO_PRODUTO";
            this.DESCRICAO_PRODUTO.MaxLength = 200;
            // 
            // CARACT_ADIC_PRODUTO
            // 
            this.CARACT_ADIC_PRODUTO.ColumnName = "CARACT_ADIC_PRODUTO";
            this.CARACT_ADIC_PRODUTO.MaxLength = 200;
            // 
            // COD_BARRAS_PRODUTO
            // 
            this.COD_BARRAS_PRODUTO.ColumnName = "COD_BARRAS_PRODUTO";
            this.COD_BARRAS_PRODUTO.MaxLength = 200;
            // 
            // COD_ONU_PRODUTO
            // 
            this.COD_ONU_PRODUTO.ColumnName = "COD_ONU_PRODUTO";
            this.COD_ONU_PRODUTO.MaxLength = 100;
            // 
            // CLASSE_TOXIC_PRODUTO
            // 
            this.CLASSE_TOXIC_PRODUTO.ColumnName = "CLASSE_TOXIC_PRODUTO";
            this.CLASSE_TOXIC_PRODUTO.MaxLength = 100;
            // 
            // COD_UNIDADE_PRODUTO
            // 
            this.COD_UNIDADE_PRODUTO.ColumnName = "COD_UNIDADE_PRODUTO";
            this.COD_UNIDADE_PRODUTO.MaxLength = 10;
            // 
            // DESCRICAO_UNIDADE_PRODUTO
            // 
            this.DESCRICAO_UNIDADE_PRODUTO.ColumnName = "DESCRICAO_UNIDADE_PRODUTO";
            this.DESCRICAO_UNIDADE_PRODUTO.MaxLength = 50;
            // 
            // META_ANUAL_PRODUTO
            // 
            this.META_ANUAL_PRODUTO.ColumnName = "META_ANUAL_PRODUTO";
            this.META_ANUAL_PRODUTO.DataType = typeof(double);
            // 
            // COD_REDUZIDO_PRODUTO
            // 
            this.COD_REDUZIDO_PRODUTO.ColumnName = "COD_REDUZIDO_PRODUTO";
            this.COD_REDUZIDO_PRODUTO.MaxLength = 100;
            // 
            // TAB_PRODUTO
            // 
            this.TAB_PRODUTO.ColumnName = "TAB_PRODUTO";
            this.TAB_PRODUTO.DataType = typeof(int);
            // 
            // META_SEMESTRAL_PRODUTO
            // 
            this.META_SEMESTRAL_PRODUTO.ColumnName = "META_SEMESTRAL_PRODUTO";
            this.META_SEMESTRAL_PRODUTO.DataType = typeof(double);
            // 
            // ESTOQUE_ATUAL_PRODUTO
            // 
            this.ESTOQUE_ATUAL_PRODUTO.ColumnName = "ESTOQUE_ATUAL_PRODUTO";
            this.ESTOQUE_ATUAL_PRODUTO.DataType = typeof(double);
            // 
            // ESTOQUE_RESERVADO_PRODUTO
            // 
            this.ESTOQUE_RESERVADO_PRODUTO.ColumnName = "ESTOQUE_RESERVADO_PRODUTO";
            this.ESTOQUE_RESERVADO_PRODUTO.DataType = typeof(double);
            // 
            // ESTOQUE_MINIMO_PRODUTO
            // 
            this.ESTOQUE_MINIMO_PRODUTO.ColumnName = "ESTOQUE_MINIMO_PRODUTO";
            this.ESTOQUE_MINIMO_PRODUTO.DataType = typeof(double);
            // 
            // ESTOQUE_ENCOMENDADO_PRODUTO
            // 
            this.ESTOQUE_ENCOMENDADO_PRODUTO.ColumnName = "ESTOQUE_ENCOMENDADO_PRODUTO";
            this.ESTOQUE_ENCOMENDADO_PRODUTO.DataType = typeof(double);
            // 
            // ESTOQUE_MAXIMO_PRODUTO
            // 
            this.ESTOQUE_MAXIMO_PRODUTO.ColumnName = "ESTOQUE_MAXIMO_PRODUTO";
            this.ESTOQUE_MAXIMO_PRODUTO.DataType = typeof(double);
            // 
            // ESTOQUE_MEDIO_PRODUTO
            // 
            this.ESTOQUE_MEDIO_PRODUTO.ColumnName = "ESTOQUE_MEDIO_PRODUTO";
            this.ESTOQUE_MEDIO_PRODUTO.DataType = typeof(double);
            // 
            // CUSTO_PRODUTO
            // 
            this.CUSTO_PRODUTO.ColumnName = "CUSTO_PRODUTO";
            this.CUSTO_PRODUTO.DataType = typeof(double);
            // 
            // CUSTO_MED_PRODUTO
            // 
            this.CUSTO_MED_PRODUTO.ColumnName = "CUSTO_MED_PRODUTO";
            this.CUSTO_MED_PRODUTO.DataType = typeof(double);
            // 
            // VALOR_VENDA_PRODUTOR_PRODUTO
            // 
            this.VALOR_VENDA_PRODUTOR_PRODUTO.ColumnName = "VALOR_VENDA_PRODUTOR_PRODUTO";
            this.VALOR_VENDA_PRODUTOR_PRODUTO.DataType = typeof(double);
            // 
            // VALOR_VENDA_REVEND_PRODUTO
            // 
            this.VALOR_VENDA_REVEND_PRODUTO.ColumnName = "VALOR_VENDA_REVEND_PRODUTO";
            this.VALOR_VENDA_REVEND_PRODUTO.DataType = typeof(double);
            // 
            // VALOR_PROMOCAO_PRODUTO
            // 
            this.VALOR_PROMOCAO_PRODUTO.ColumnName = "VALOR_PROMOCAO_PRODUTO";
            this.VALOR_PROMOCAO_PRODUTO.DataType = typeof(double);
            // 
            // OUTRO_VALOR_PRODUTO
            // 
            this.OUTRO_VALOR_PRODUTO.ColumnName = "OUTRO_VALOR_PRODUTO";
            this.OUTRO_VALOR_PRODUTO.DataType = typeof(double);
            // 
            // LUCRO_PRODUTO
            // 
            this.LUCRO_PRODUTO.ColumnName = "LUCRO_PRODUTO";
            this.LUCRO_PRODUTO.DataType = typeof(double);
            // 
            // ULT_REAJ_PRODUTO
            // 
            this.ULT_REAJ_PRODUTO.ColumnName = "ULT_REAJ_PRODUTO";
            this.ULT_REAJ_PRODUTO.DataType = typeof(System.DateTime);
            // 
            // PROD_RECEITA_PRODUTO
            // 
            this.PROD_RECEITA_PRODUTO.ColumnName = "PROD_RECEITA_PRODUTO";
            this.PROD_RECEITA_PRODUTO.DataType = typeof(int);
            // 
            // ICMS_S_N_PRODUTO
            // 
            this.ICMS_S_N_PRODUTO.ColumnName = "ICMS_S_N_PRODUTO";
            this.ICMS_S_N_PRODUTO.DataType = typeof(int);
            // 
            // ALIQUOTA_ICMS_PRODUTO
            // 
            this.ALIQUOTA_ICMS_PRODUTO.ColumnName = "ALIQUOTA_ICMS_PRODUTO";
            this.ALIQUOTA_ICMS_PRODUTO.DataType = typeof(double);
            // 
            // REDUCAO_FORA_PRODUTO
            // 
            this.REDUCAO_FORA_PRODUTO.ColumnName = "REDUCAO_FORA_PRODUTO";
            this.REDUCAO_FORA_PRODUTO.DataType = typeof(double);
            // 
            // ALIQUOTA_IPI_PRODUTO
            // 
            this.ALIQUOTA_IPI_PRODUTO.ColumnName = "ALIQUOTA_IPI_PRODUTO";
            this.ALIQUOTA_IPI_PRODUTO.DataType = typeof(double);
            // 
            // PIS_PRODUTO
            // 
            this.PIS_PRODUTO.ColumnName = "PIS_PRODUTO";
            this.PIS_PRODUTO.DataType = typeof(int);
            // 
            // COFINS_PRODUTO
            // 
            this.COFINS_PRODUTO.ColumnName = "COFINS_PRODUTO";
            this.COFINS_PRODUTO.DataType = typeof(int);
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "COMISSAO_PRODUTO";
            this.dataColumn1.DataType = typeof(double);
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "COD_MARCA_PRODUTO";
            this.dataColumn2.DataType = typeof(int);
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "MARCA_PRODUTO";
            this.dataColumn3.MaxLength = 100;
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "IVA_PRODUTO";
            this.dataColumn4.DataType = typeof(double);
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "NCM_PRODUTO";
            this.dataColumn5.MaxLength = 50;
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "DESCRICAO_ITEM_PRODUTO";
            this.dataColumn6.MaxLength = 200;
            // 
            // dataColumn7
            // 
            this.dataColumn7.ColumnName = "COD_FORNECEDOR_PRODUTO";
            this.dataColumn7.MaxLength = 50;
            // 
            // dataColumn8
            // 
            this.dataColumn8.ColumnName = "CFOP_ENTRADA_PRODUTO";
            this.dataColumn8.MaxLength = 10;
            // 
            // dataColumn9
            // 
            this.dataColumn9.ColumnName = "ORIGEM_PRODUTO";
            this.dataColumn9.MaxLength = 100;
            // 
            // dataColumn10
            // 
            this.dataColumn10.ColumnName = "LOCALIZACAO_PRODUTO";
            this.dataColumn10.MaxLength = 30;
            // 
            // dataColumn11
            // 
            this.dataColumn11.ColumnName = "ST_PRODUTO";
            this.dataColumn11.MaxLength = 10;
            // 
            // dataColumn12
            // 
            this.dataColumn12.ColumnName = "ICMS_FORA_S_N_PRODUTO";
            this.dataColumn12.DataType = typeof(int);
            // 
            // dataColumn13
            // 
            this.dataColumn13.ColumnName = "ALIQUOTA_FORA_ICMS_PRODUTO";
            this.dataColumn13.DataType = typeof(double);
            // 
            // dataColumn14
            // 
            this.dataColumn14.ColumnName = "REDUCAO_ICMS_PRODUTO";
            this.dataColumn14.DataType = typeof(double);
            // 
            // dataColumn15
            // 
            this.dataColumn15.ColumnName = "IVA_FORA_PRODUTO";
            this.dataColumn15.DataType = typeof(double);
            // 
            // dataColumn16
            // 
            this.dataColumn16.ColumnName = "ALIQUOTA_ICMS_ST_PRODUTO";
            this.dataColumn16.DataType = typeof(double);
            // 
            // dataColumn17
            // 
            this.dataColumn17.ColumnName = "ALIQUOTA_ICMS_ST_FORA_PRODUTO";
            this.dataColumn17.DataType = typeof(double);
            // 
            // dataColumn18
            // 
            this.dataColumn18.ColumnName = "ST_SAIDA_PRODUTO";
            this.dataColumn18.MaxLength = 10;
            // 
            // dataColumn19
            // 
            this.dataColumn19.ColumnName = "ST_SAIDA_FORA_PRODUTO";
            this.dataColumn19.MaxLength = 10;
            // 
            // dataColumn20
            // 
            this.dataColumn20.ColumnName = "REDUCAO_ST_PRODUTO";
            this.dataColumn20.DataType = typeof(double);
            // 
            // dataColumn21
            // 
            this.dataColumn21.ColumnName = "REDUCAO_ST_FORA_PRODUTO";
            this.dataColumn21.DataType = typeof(double);
            // 
            // dataColumn22
            // 
            this.dataColumn22.ColumnName = "CNPJ_FORNECEDOR_PRODUTO";
            this.dataColumn22.MaxLength = 20;
            // 
            // dataColumn23
            // 
            this.dataColumn23.ColumnName = "NOME_FORNECEDOR_PRODUTO";
            this.dataColumn23.MaxLength = 100;
            // 
            // dataColumn24
            // 
            this.dataColumn24.ColumnName = "STATUS_PRODUTO";
            this.dataColumn24.DataType = typeof(int);
            // 
            // dataColumn25
            // 
            this.dataColumn25.ColumnName = "DESCONTO_MAXIMO_PRODUTO";
            this.dataColumn25.DataType = typeof(double);
            // 
            // dataColumn26
            // 
            this.dataColumn26.ColumnName = "QTDE_UNIDADE_PRODUTO";
            this.dataColumn26.DataType = typeof(double);
            // 
            // dataColumn27
            // 
            this.dataColumn27.ColumnName = "UNIDADE_PRODUTO";
            // 
            // dataColumn28
            // 
            this.dataColumn28.ColumnName = "COD_BARRAS_CAIXA_PRODUTO";
            this.dataColumn28.MaxLength = 200;
            // 
            // dataColumn29
            // 
            this.dataColumn29.ColumnName = "NOME_FAMILIA_PRODUTO";
            this.dataColumn29.MaxLength = 100;
            // 
            // dataColumn30
            // 
            this.dataColumn30.ColumnName = "PESO_UNIT_PRODUTO";
            this.dataColumn30.DataType = typeof(double);
            // 
            // dataColumn31
            // 
            this.dataColumn31.ColumnName = "PIS_COFINS_PRODUTO";
            this.dataColumn31.DataType = typeof(int);
            // 
            // dataColumn32
            // 
            this.dataColumn32.ColumnName = "COEFICIENTE_LUCRO_PRODUTO";
            this.dataColumn32.DataType = typeof(double);
            // 
            // dataColumn33
            // 
            this.dataColumn33.ColumnName = "CORTAR_SEM_ESTOQUE_PRODUTO";
            this.dataColumn33.DataType = typeof(int);
            // 
            // dataColumn34
            // 
            this.dataColumn34.ColumnName = "ESTOQUE_RESERVA_FECHADA_PRODUTO";
            this.dataColumn34.DataType = typeof(double);
            // 
            // dataColumn35
            // 
            this.dataColumn35.ColumnName = "CEST_PRODUTO";
            this.dataColumn35.MaxLength = 50;
            // 
            // dataColumn36
            // 
            this.dataColumn36.ColumnName = "CST_PIS_PRODUTO";
            this.dataColumn36.MaxLength = 200;
            // 
            // dataColumn37
            // 
            this.dataColumn37.ColumnName = "CST_COFINS_PRODUTO";
            this.dataColumn37.MaxLength = 200;
            // 
            // dataColumn38
            // 
            this.dataColumn38.ColumnName = "TIPO_PIS_PRODUTO";
            this.dataColumn38.MaxLength = 100;
            // 
            // dataColumn39
            // 
            this.dataColumn39.ColumnName = "TIPO_COFINS_PRODUTO";
            this.dataColumn39.MaxLength = 100;
            // 
            // dataColumn40
            // 
            this.dataColumn40.ColumnName = "QTDE_PACOTE_SAIDA_PRODUTO";
            this.dataColumn40.DataType = typeof(double);
            // 
            // dataColumn41
            // 
            this.dataColumn41.ColumnName = "ALIQUOTA_IPI_FORA_PRODUTO";
            this.dataColumn41.DataType = typeof(double);
            // 
            // dataColumn62
            // 
            this.dataColumn62.ColumnName = "ESTOQUE_DISPONIVEL_PRODUTO";
            this.dataColumn62.DataType = typeof(double);
            // 
            // dataColumn63
            // 
            this.dataColumn63.ColumnName = "RATEIO_PRODUTO";
            this.dataColumn63.DataType = typeof(int);
            // 
            // dataColumn64
            // 
            this.dataColumn64.ColumnName = "PORC_RATEIO_PRODUTO";
            this.dataColumn64.DataType = typeof(double);
            // 
            // dataColumn65
            // 
            this.dataColumn65.ColumnName = "COD_ALTERNATIVO_PRODUTO";
            this.dataColumn65.MaxLength = 100;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 114;
            this.label3.Text = "Cód:";
            // 
            // tb_cod_grupo
            // 
            this.tb_cod_grupo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.COD_GRUPO_PRODUTO", true));
            this.tb_cod_grupo.Enabled = false;
            this.tb_cod_grupo.Location = new System.Drawing.Point(95, 40);
            this.tb_cod_grupo.Name = "tb_cod_grupo";
            this.tb_cod_grupo.Size = new System.Drawing.Size(82, 20);
            this.tb_cod_grupo.TabIndex = 115;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 116;
            this.label1.Text = "Cód. Grupo:";
            // 
            // tb_grupo
            // 
            this.tb_grupo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.DESCRICAO_GRUPO_PRODUTO", true));
            this.tb_grupo.Enabled = false;
            this.tb_grupo.Location = new System.Drawing.Point(246, 40);
            this.tb_grupo.Name = "tb_grupo";
            this.tb_grupo.Size = new System.Drawing.Size(203, 20);
            this.tb_grupo.TabIndex = 117;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 118;
            this.label2.Text = "Grupo:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(455, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(15, 23);
            this.button1.TabIndex = 119;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(455, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(15, 23);
            this.button2.TabIndex = 124;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tb_sub_grupo
            // 
            this.tb_sub_grupo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.DESCRICAO_SUB_GRUPO_PRODUTO", true));
            this.tb_sub_grupo.Enabled = false;
            this.tb_sub_grupo.Location = new System.Drawing.Point(246, 66);
            this.tb_sub_grupo.Name = "tb_sub_grupo";
            this.tb_sub_grupo.Size = new System.Drawing.Size(203, 20);
            this.tb_sub_grupo.TabIndex = 122;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 123;
            this.label4.Text = "Sub Grupo:";
            // 
            // tb_cod_sub_grupo
            // 
            this.tb_cod_sub_grupo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.COD_SUB_GRUPO_PRODUTO", true));
            this.tb_cod_sub_grupo.Enabled = false;
            this.tb_cod_sub_grupo.Location = new System.Drawing.Point(95, 66);
            this.tb_cod_sub_grupo.Name = "tb_cod_sub_grupo";
            this.tb_cod_sub_grupo.Size = new System.Drawing.Size(82, 20);
            this.tb_cod_sub_grupo.TabIndex = 120;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 121;
            this.label5.Text = "Cód. Sub-Grupo:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button29);
            this.groupBox1.Controls.Add(this.button12);
            this.groupBox1.Controls.Add(this.tb_familia);
            this.groupBox1.Controls.Add(this.label65);
            this.groupBox1.Controls.Add(this.btnSelecionarFornecedor);
            this.groupBox1.Controls.Add(this.txtNomeFornecedor);
            this.groupBox1.Controls.Add(this.label61);
            this.groupBox1.Controls.Add(this.txtCnpjFornecedor);
            this.groupBox1.Controls.Add(this.label62);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.tb_sub_grupo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_cod_sub_grupo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tb_grupo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_cod_grupo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 129);
            this.groupBox1.TabIndex = 131;
            this.groupBox1.TabStop = false;
            // 
            // button29
            // 
            this.button29.Location = new System.Drawing.Point(366, 90);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(104, 23);
            this.button29.TabIndex = 133;
            this.button29.Text = "Gerar Código";
            this.button29.UseVisualStyleBackColor = true;
            this.button29.Click += new System.EventHandler(this.button29_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(303, 90);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(15, 23);
            this.button12.TabIndex = 132;
            this.button12.Text = "+";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // tb_familia
            // 
            this.tb_familia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.NOME_FAMILIA_PRODUTO", true));
            this.tb_familia.Enabled = false;
            this.tb_familia.Location = new System.Drawing.Point(94, 92);
            this.tb_familia.Name = "tb_familia";
            this.tb_familia.Size = new System.Drawing.Size(203, 20);
            this.tb_familia.TabIndex = 130;
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(7, 95);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(44, 13);
            this.label65.TabIndex = 131;
            this.label65.Text = "Família:";
            // 
            // btnSelecionarFornecedor
            // 
            this.btnSelecionarFornecedor.Location = new System.Drawing.Point(455, 11);
            this.btnSelecionarFornecedor.Name = "btnSelecionarFornecedor";
            this.btnSelecionarFornecedor.Size = new System.Drawing.Size(15, 23);
            this.btnSelecionarFornecedor.TabIndex = 129;
            this.btnSelecionarFornecedor.Text = "+";
            this.btnSelecionarFornecedor.UseVisualStyleBackColor = true;
            this.btnSelecionarFornecedor.Click += new System.EventHandler(this.btnSelecionarFornecedor_Click);
            // 
            // txtNomeFornecedor
            // 
            this.txtNomeFornecedor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.NOME_FORNECEDOR_PRODUTO", true));
            this.txtNomeFornecedor.Enabled = false;
            this.txtNomeFornecedor.Location = new System.Drawing.Point(247, 13);
            this.txtNomeFornecedor.Name = "txtNomeFornecedor";
            this.txtNomeFornecedor.Size = new System.Drawing.Size(203, 20);
            this.txtNomeFornecedor.TabIndex = 127;
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(180, 16);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(42, 13);
            this.label61.TabIndex = 128;
            this.label61.Text = "Cliente:";
            // 
            // txtCnpjFornecedor
            // 
            this.txtCnpjFornecedor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.CNPJ_FORNECEDOR_PRODUTO", true));
            this.txtCnpjFornecedor.Enabled = false;
            this.txtCnpjFornecedor.Location = new System.Drawing.Point(95, 13);
            this.txtCnpjFornecedor.Name = "txtCnpjFornecedor";
            this.txtCnpjFornecedor.Size = new System.Drawing.Size(82, 20);
            this.txtCnpjFornecedor.TabIndex = 125;
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(7, 16);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(66, 13);
            this.label62.TabIndex = 126;
            this.label62.Text = "Cnpj Cliente:";
            // 
            // textBox21
            // 
            this.textBox21.Location = new System.Drawing.Point(149, 138);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(72, 20);
            this.textBox21.TabIndex = 145;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(19, 141);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(41, 13);
            this.label23.TabIndex = 146;
            this.label23.Text = "Outros:";
            // 
            // textBox22
            // 
            this.textBox22.Location = new System.Drawing.Point(149, 112);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(72, 20);
            this.textBox22.TabIndex = 143;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(19, 115);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(85, 13);
            this.label24.TabIndex = 144;
            this.label24.Text = "Valor Promoção:";
            // 
            // textBox23
            // 
            this.textBox23.Location = new System.Drawing.Point(149, 86);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(72, 20);
            this.textBox23.TabIndex = 141;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(19, 89);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(131, 13);
            this.label25.TabIndex = 142;
            this.label25.Text = "Valor VEnda Revendedor:";
            // 
            // textBox24
            // 
            this.textBox24.Location = new System.Drawing.Point(149, 60);
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(72, 20);
            this.textBox24.TabIndex = 139;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(19, 63);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(111, 13);
            this.label26.TabIndex = 140;
            this.label26.Text = "Valor Venda Produtor:";
            // 
            // textBox33
            // 
            this.textBox33.Location = new System.Drawing.Point(149, 34);
            this.textBox33.Name = "textBox33";
            this.textBox33.Size = new System.Drawing.Size(72, 20);
            this.textBox33.TabIndex = 137;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(19, 37);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(69, 13);
            this.label35.TabIndex = 138;
            this.label35.Text = "Custo Medio:";
            // 
            // textBox34
            // 
            this.textBox34.Location = new System.Drawing.Point(149, 8);
            this.textBox34.Name = "textBox34";
            this.textBox34.Size = new System.Drawing.Size(72, 20);
            this.textBox34.TabIndex = 135;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(19, 11);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(92, 13);
            this.label36.TabIndex = 136;
            this.label36.Text = "Custo do Produto:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsProdutos, "PRODUTOS.STATUS_PRODUTO", true));
            this.checkBox1.Location = new System.Drawing.Point(27, 11);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(50, 17);
            this.checkBox1.TabIndex = 134;
            this.checkBox1.Text = "Ativo";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // tb_descricao
            // 
            this.tb_descricao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.DESCRICAO_PRODUTO", true));
            this.tb_descricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_descricao.Location = new System.Drawing.Point(138, 198);
            this.tb_descricao.Name = "tb_descricao";
            this.tb_descricao.Size = new System.Drawing.Size(401, 20);
            this.tb_descricao.TabIndex = 131;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 132;
            this.label6.Text = "Descrição Produto:";
            // 
            // bt_localizar
            // 
            this.bt_localizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_localizar.BackgroundImage")));
            this.bt_localizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_localizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_localizar.Location = new System.Drawing.Point(548, 647);
            this.bt_localizar.Name = "bt_localizar";
            this.bt_localizar.Size = new System.Drawing.Size(57, 60);
            this.bt_localizar.TabIndex = 269;
            this.bt_localizar.UseVisualStyleBackColor = true;
            this.bt_localizar.Click += new System.EventHandler(this.bt_localizar_Click);
            // 
            // bt_excluir
            // 
            this.bt_excluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_excluir.BackgroundImage")));
            this.bt_excluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_excluir.Location = new System.Drawing.Point(476, 646);
            this.bt_excluir.Name = "bt_excluir";
            this.bt_excluir.Size = new System.Drawing.Size(57, 60);
            this.bt_excluir.TabIndex = 268;
            this.bt_excluir.UseVisualStyleBackColor = true;
            this.bt_excluir.Click += new System.EventHandler(this.bt_excluir_Click);
            // 
            // bt_salvar
            // 
            this.bt_salvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_salvar.BackgroundImage")));
            this.bt_salvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_salvar.Location = new System.Drawing.Point(338, 646);
            this.bt_salvar.Name = "bt_salvar";
            this.bt_salvar.Size = new System.Drawing.Size(57, 60);
            this.bt_salvar.TabIndex = 266;
            this.bt_salvar.UseVisualStyleBackColor = true;
            this.bt_salvar.Click += new System.EventHandler(this.bt_salvar_Click);
            // 
            // bt_novo
            // 
            this.bt_novo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_novo.BackgroundImage")));
            this.bt_novo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_novo.Location = new System.Drawing.Point(407, 646);
            this.bt_novo.Name = "bt_novo";
            this.bt_novo.Size = new System.Drawing.Size(57, 60);
            this.bt_novo.TabIndex = 267;
            this.bt_novo.UseVisualStyleBackColor = true;
            this.bt_novo.Click += new System.EventHandler(this.bt_novo_Click);
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
            this.fbCommand7.CommandTimeout = 30;
            // 
            // fbCommand8
            // 
            this.fbCommand8.CommandTimeout = 30;
            // 
            // cbProdutos
            // 
            this.cbProdutos.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbProdutos.DataAdapter = this.datProdutos;
            this.cbProdutos.QuotePrefix = "\"";
            this.cbProdutos.QuoteSuffix = "\"";
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
            this.fbCommand9.CommandText = "select * from itens_pedido_venda";
            this.fbCommand9.CommandTimeout = 30;
            this.fbCommand9.Connection = this.fbConnection1;
            // 
            // fbCommand11
            // 
            this.fbCommand11.CommandTimeout = 30;
            // 
            // datItens_nf_entrada
            // 
            this.datItens_nf_entrada.DeleteCommand = this.fbCommand16;
            this.datItens_nf_entrada.InsertCommand = this.fbCommand14;
            this.datItens_nf_entrada.SelectCommand = this.fbCommand13;
            this.datItens_nf_entrada.UpdateCommand = this.fbCommand15;
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
            this.fbCommand13.CommandText = "select * from itens_nota_ent";
            this.fbCommand13.CommandTimeout = 30;
            this.fbCommand13.Connection = this.fbConnection1;
            // 
            // fbCommand15
            // 
            this.fbCommand15.CommandTimeout = 30;
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.AutoGenerateColumns = false;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nFITEMENTDataGridViewTextBoxColumn,
            this.uNIDADEITEMENTDataGridViewTextBoxColumn,
            this.qTDEITEMENTDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1});
            this.dgvItens.DataMember = "ITENS_NOTA_ENT";
            this.dgvItens.DataSource = this.dsItens_nf_entrada;
            this.dgvItens.Location = new System.Drawing.Point(15, 19);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.RowHeadersWidth = 15;
            this.dgvItens.Size = new System.Drawing.Size(184, 238);
            this.dgvItens.TabIndex = 271;
            this.dgvItens.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItens_CellClick);
            this.dgvItens.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItens_CellContentClick);
            this.dgvItens.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvItens_CellMouseDoubleClick);
            // 
            // nFITEMENTDataGridViewTextBoxColumn
            // 
            this.nFITEMENTDataGridViewTextBoxColumn.DataPropertyName = "NF_ITEM_ENT";
            this.nFITEMENTDataGridViewTextBoxColumn.HeaderText = "NF";
            this.nFITEMENTDataGridViewTextBoxColumn.Name = "nFITEMENTDataGridViewTextBoxColumn";
            this.nFITEMENTDataGridViewTextBoxColumn.ReadOnly = true;
            this.nFITEMENTDataGridViewTextBoxColumn.Width = 50;
            // 
            // uNIDADEITEMENTDataGridViewTextBoxColumn
            // 
            this.uNIDADEITEMENTDataGridViewTextBoxColumn.DataPropertyName = "UNIDADE_ITEM_ENT";
            this.uNIDADEITEMENTDataGridViewTextBoxColumn.HeaderText = "Unid.";
            this.uNIDADEITEMENTDataGridViewTextBoxColumn.Name = "uNIDADEITEMENTDataGridViewTextBoxColumn";
            this.uNIDADEITEMENTDataGridViewTextBoxColumn.ReadOnly = true;
            this.uNIDADEITEMENTDataGridViewTextBoxColumn.Width = 30;
            // 
            // qTDEITEMENTDataGridViewTextBoxColumn
            // 
            this.qTDEITEMENTDataGridViewTextBoxColumn.DataPropertyName = "QTDE_ITEM_ENT";
            this.qTDEITEMENTDataGridViewTextBoxColumn.HeaderText = "Qtde";
            this.qTDEITEMENTDataGridViewTextBoxColumn.Name = "qTDEITEMENTDataGridViewTextBoxColumn";
            this.qTDEITEMENTDataGridViewTextBoxColumn.ReadOnly = true;
            this.qTDEITEMENTDataGridViewTextBoxColumn.Width = 50;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DATA_INSERCAO_ITEM_ENT_NOTA";
            this.dataGridViewTextBoxColumn1.HeaderText = "Data";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dsItens_nf_entrada
            // 
            this.dsItens_nf_entrada.DataSetName = "dsItens_nf_entrada";
            this.dsItens_nf_entrada.Namespace = "http://www.tempuri.org/dsItens_nf_entrada.xsd";
            this.dsItens_nf_entrada.Tables.AddRange(new System.Data.DataTable[] {
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
            this.LOTE_ITEM_ENT,
            this.QTDE_LOTE_ITEM_ENT,
            this.NOME_PROPRIETARIO_ITEM_ENT,
            this.CNPJ_PROPRIETARIO_ITEM,
            this.BAIXADO_ITEM_ENT,
            this.MATERIA_PRIMA_ITEM_ENT,
            this.ALMOXARIFADO_ITEM_ENT,
            this.COD_EAN_ITEM_ENT});
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
            this.COD_ITEM_ENT.MaxLength = 100;
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
            // LOTE_ITEM_ENT
            // 
            this.LOTE_ITEM_ENT.ColumnName = "LOTE_ITEM_ENT";
            this.LOTE_ITEM_ENT.MaxLength = 100;
            // 
            // QTDE_LOTE_ITEM_ENT
            // 
            this.QTDE_LOTE_ITEM_ENT.ColumnName = "QTDE_LOTE_ITEM_ENT";
            this.QTDE_LOTE_ITEM_ENT.DataType = typeof(double);
            // 
            // NOME_PROPRIETARIO_ITEM_ENT
            // 
            this.NOME_PROPRIETARIO_ITEM_ENT.ColumnName = "NOME_PROPRIETARIO_ITEM_ENT";
            this.NOME_PROPRIETARIO_ITEM_ENT.MaxLength = 200;
            // 
            // CNPJ_PROPRIETARIO_ITEM
            // 
            this.CNPJ_PROPRIETARIO_ITEM.ColumnName = "CNPJ_PROPRIETARIO_ITEM";
            this.CNPJ_PROPRIETARIO_ITEM.MaxLength = 100;
            // 
            // BAIXADO_ITEM_ENT
            // 
            this.BAIXADO_ITEM_ENT.ColumnName = "BAIXADO_ITEM_ENT";
            this.BAIXADO_ITEM_ENT.DataType = typeof(int);
            // 
            // MATERIA_PRIMA_ITEM_ENT
            // 
            this.MATERIA_PRIMA_ITEM_ENT.ColumnName = "MATERIA_PRIMA_ITEM_ENT";
            this.MATERIA_PRIMA_ITEM_ENT.DataType = typeof(int);
            // 
            // ALMOXARIFADO_ITEM_ENT
            // 
            this.ALMOXARIFADO_ITEM_ENT.ColumnName = "ALMOXARIFADO_ITEM_ENT";
            this.ALMOXARIFADO_ITEM_ENT.DataType = typeof(int);
            // 
            // COD_EAN_ITEM_ENT
            // 
            this.COD_EAN_ITEM_ENT.ColumnName = "COD_EAN_ITEM_ENT";
            this.COD_EAN_ITEM_ENT.MaxLength = 200;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(13, 16);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(58, 23);
            this.button4.TabIndex = 272;
            this.button4.Text = "Inserir";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(77, 16);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(58, 23);
            this.button5.TabIndex = 273;
            this.button5.Text = "Excluir";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox3.Controls.Add(this.dgvItens_nota);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Location = new System.Drawing.Point(554, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(215, 261);
            this.groupBox3.TabIndex = 275;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Saídas";
            // 
            // dgvItens_nota
            // 
            this.dgvItens_nota.AllowUserToAddRows = false;
            this.dgvItens_nota.AllowUserToDeleteRows = false;
            this.dgvItens_nota.AutoGenerateColumns = false;
            this.dgvItens_nota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens_nota.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn4});
            this.dgvItens_nota.DataMember = "ITENS_NOTA";
            this.dgvItens_nota.DataSource = this.dsItens_nota;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItens_nota.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItens_nota.Location = new System.Drawing.Point(14, 16);
            this.dgvItens_nota.Name = "dgvItens_nota";
            this.dgvItens_nota.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItens_nota.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvItens_nota.RowHeadersWidth = 15;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvItens_nota.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvItens_nota.Size = new System.Drawing.Size(184, 241);
            this.dgvItens_nota.TabIndex = 270;
            this.dgvItens_nota.EditModeChanged += new System.EventHandler(this.dgvItens_nota_EditModeChanged);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DATA_EMISSAO_NF";
            this.dataGridViewTextBoxColumn3.HeaderText = "Data";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 60;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "N_NF";
            this.dataGridViewTextBoxColumn2.HeaderText = "NF";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 50;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "QTDE_ITEM";
            this.dataGridViewTextBoxColumn5.HeaderText = "Qtde";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 50;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "UNIDADE_ITEM";
            this.dataGridViewTextBoxColumn6.HeaderText = "UN";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 40;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "N_PEDIDO_NF";
            this.dataGridViewTextBoxColumn7.HeaderText = "Pedido";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 70;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CLIENTE_FORN_NF";
            this.dataGridViewTextBoxColumn4.HeaderText = "Cliente";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
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
            this.N_NF,
            this.DATA_EMISSAO_NF,
            this.CLIENTE_FORN_NF,
            this.QTDE_ITEM,
            this.UNIDADE_ITEM,
            this.N_PEDIDO_NF});
            this.ITENS_NOTA.TableName = "ITENS_NOTA";
            // 
            // N_NF
            // 
            this.N_NF.ColumnName = "N_NF";
            this.N_NF.DataType = typeof(int);
            // 
            // DATA_EMISSAO_NF
            // 
            this.DATA_EMISSAO_NF.ColumnName = "DATA_EMISSAO_NF";
            this.DATA_EMISSAO_NF.DataType = typeof(System.DateTime);
            // 
            // CLIENTE_FORN_NF
            // 
            this.CLIENTE_FORN_NF.ColumnName = "CLIENTE_FORN_NF";
            this.CLIENTE_FORN_NF.MaxLength = 100;
            // 
            // QTDE_ITEM
            // 
            this.QTDE_ITEM.ColumnName = "QTDE_ITEM";
            this.QTDE_ITEM.DataType = typeof(double);
            // 
            // UNIDADE_ITEM
            // 
            this.UNIDADE_ITEM.ColumnName = "UNIDADE_ITEM";
            this.UNIDADE_ITEM.MaxLength = 10;
            // 
            // N_PEDIDO_NF
            // 
            this.N_PEDIDO_NF.ColumnName = "N_PEDIDO_NF";
            this.N_PEDIDO_NF.DataType = typeof(int);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(140, 16);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(58, 23);
            this.button6.TabIndex = 274;
            this.button6.Text = "Modificar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox4.Controls.Add(this.dgvItens);
            this.groupBox4.Controls.Add(this.button7);
            this.groupBox4.Controls.Add(this.button8);
            this.groupBox4.Controls.Add(this.button9);
            this.groupBox4.Location = new System.Drawing.Point(773, 9);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(213, 261);
            this.groupBox4.TabIndex = 276;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Entradas";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(141, 16);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(58, 23);
            this.button7.TabIndex = 277;
            this.button7.Text = "Modificar";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Visible = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(77, 16);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(58, 23);
            this.button8.TabIndex = 276;
            this.button8.Text = "Excluir";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Visible = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(13, 16);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(58, 23);
            this.button9.TabIndex = 275;
            this.button9.Text = "Inserir";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Visible = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(338, 611);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(339, 23);
            this.button10.TabIndex = 277;
            this.button10.Text = "Recalcular Estoque";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // cbItens_ped_venda
            // 
            this.cbItens_ped_venda.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbItens_ped_venda.QuotePrefix = "\"";
            this.cbItens_ped_venda.QuoteSuffix = "\"";
            // 
            // cbItens_nf_entrada
            // 
            this.cbItens_nf_entrada.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbItens_nf_entrada.DataAdapter = this.datItens_nf_entrada;
            this.cbItens_nf_entrada.QuotePrefix = "\"";
            this.cbItens_nf_entrada.QuoteSuffix = "\"";
            // 
            // button11
            // 
            this.button11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button11.BackgroundImage")));
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(620, 647);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(57, 60);
            this.button11.TabIndex = 278;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Visible = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.DESCRICAO_ITEM_PRODUTO", true));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(138, 224);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(401, 20);
            this.textBox2.TabIndex = 279;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(22, 227);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(81, 13);
            this.label38.TabIndex = 280;
            this.label38.Text = "Descrição Item:";
            // 
            // txtCodAlternativo
            // 
            this.txtCodAlternativo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.COD_FORNECEDOR_PRODUTO", true));
            this.txtCodAlternativo.Location = new System.Drawing.Point(226, 45);
            this.txtCodAlternativo.Name = "txtCodAlternativo";
            this.txtCodAlternativo.Size = new System.Drawing.Size(66, 20);
            this.txtCodAlternativo.TabIndex = 281;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(142, 48);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(79, 13);
            this.label44.TabIndex = 282;
            this.label44.Text = "Cód do Cliente:";
            // 
            // textBox9
            // 
            this.textBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.LOCALIZACAO_PRODUTO", true));
            this.textBox9.Location = new System.Drawing.Point(138, 250);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(96, 20);
            this.textBox9.TabIndex = 283;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(22, 253);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(107, 13);
            this.label47.TabIndex = 284;
            this.label47.Text = "Localização Produto:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.panel7);
            this.tabPage4.Controls.Add(this.panel5);
            this.tabPage4.Controls.Add(this.panel4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(963, 296);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Tributação";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel7.Controls.Add(this.label76);
            this.panel7.Controls.Add(this.cbPis_cofins);
            this.panel7.Controls.Add(this.comboBox2);
            this.panel7.Controls.Add(this.label77);
            this.panel7.Controls.Add(this.comboBox3);
            this.panel7.Controls.Add(this.label78);
            this.panel7.Controls.Add(this.comboBox4);
            this.panel7.Controls.Add(this.label79);
            this.panel7.Controls.Add(this.cb_cod_sit_trib_pis);
            this.panel7.Location = new System.Drawing.Point(11, 230);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(496, 60);
            this.panel7.TabIndex = 291;
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Location = new System.Drawing.Point(293, 9);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(73, 13);
            this.label76.TabIndex = 111;
            this.label76.Text = "Tipo COFINS:";
            // 
            // cbPis_cofins
            // 
            this.cbPis_cofins.AutoSize = true;
            this.cbPis_cofins.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsProdutos, "PRODUTOS.PIS_COFINS_PRODUTO", true));
            this.cbPis_cofins.Location = new System.Drawing.Point(5, 22);
            this.cbPis_cofins.Name = "cbPis_cofins";
            this.cbPis_cofins.Size = new System.Drawing.Size(93, 17);
            this.cbPis_cofins.TabIndex = 290;
            this.cbPis_cofins.Text = "PIS / COFINS";
            this.cbPis_cofins.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.TIPO_COFINS_PRODUTO", true));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1 - Tributado pela Alíquota",
            "2 - Tributado por Qtde",
            "3 - Não tributado",
            "4 - Outras Operações",
            "5 - Substituição Tributária",
            " "});
            this.comboBox2.Location = new System.Drawing.Point(381, 6);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(106, 21);
            this.comboBox2.TabIndex = 110;
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Location = new System.Drawing.Point(293, 36);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(88, 13);
            this.label77.TabIndex = 109;
            this.label77.Text = "CST do COFINS:";
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.CST_COFINS_PRODUTO", true));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "01 - Operação Tributável (base de cálculo = valor da operação alíquota normal (cu" +
                "mulativo/não cumulativo))",
            "02 - Operação Tributável (base de cálculo = valor da operação (alíquota diferenci" +
                "ada))",
            "03 - Operação Tributável (base de cálculo = quantidade vendida x alíquota por uni" +
                "dade de produto);",
            "04 - Operação Tributável (tributação monofásica (alíquota zero))",
            "06 - Operação Tributável (alíquota zero)",
            "07 - Operação Isenta da Contribuição",
            "08 - Operação Sem Incidência da Contribuição",
            "09 - Operação com Suspensão da Contribuição",
            "99 - Outras Operações"});
            this.comboBox3.Location = new System.Drawing.Point(381, 33);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(106, 21);
            this.comboBox3.TabIndex = 108;
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Location = new System.Drawing.Point(113, 9);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(51, 13);
            this.label78.TabIndex = 107;
            this.label78.Text = "Tipo PIS:";
            // 
            // comboBox4
            // 
            this.comboBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.TIPO_PIS_PRODUTO", true));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "1 - Tributado pela Alíquota",
            "2 - Tributado por Qtde",
            "3 - Não Tributado",
            "4 - Outras Operações",
            "5 - Substituição Tributária"});
            this.comboBox4.Location = new System.Drawing.Point(182, 6);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(106, 21);
            this.comboBox4.TabIndex = 106;
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Location = new System.Drawing.Point(113, 36);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(66, 13);
            this.label79.TabIndex = 105;
            this.label79.Text = "CST do PIS:";
            // 
            // cb_cod_sit_trib_pis
            // 
            this.cb_cod_sit_trib_pis.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.CST_PIS_PRODUTO", true));
            this.cb_cod_sit_trib_pis.FormattingEnabled = true;
            this.cb_cod_sit_trib_pis.Items.AddRange(new object[] {
            "01 - Operação Tributável (base de cálculo = valor da operação alíquota normal (cu" +
                "mulativo/não cumulativo))",
            "02 - Operação Tributável (base de cálculo = valor da operação (alíquota diferenci" +
                "ada))",
            "03 - Operação Tributável (base de cálculo = quantidade vendida x alíquota por uni" +
                "dade de produto);",
            "04 - Operação Tributável (tributação monofásica (alíquota zero))",
            "06 - Operação Tributável (alíquota zero)",
            "07 - Operação Isenta da Contribuição",
            "08 - Operação Sem Incidência da Contribuição",
            "09 - Operação com Suspensão da Contribuição",
            "99 - Outras Operações"});
            this.cb_cod_sit_trib_pis.Location = new System.Drawing.Point(182, 33);
            this.cb_cod_sit_trib_pis.Name = "cb_cod_sit_trib_pis";
            this.cb_cod_sit_trib_pis.Size = new System.Drawing.Size(106, 21);
            this.cb_cod_sit_trib_pis.TabIndex = 104;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.PaleGreen;
            this.panel5.Controls.Add(this.textBox30);
            this.panel5.Controls.Add(this.label81);
            this.panel5.Controls.Add(this.textBox46);
            this.panel5.Controls.Add(this.label59);
            this.panel5.Controls.Add(this.textBox45);
            this.panel5.Controls.Add(this.label58);
            this.panel5.Controls.Add(this.textBox19);
            this.panel5.Controls.Add(this.label50);
            this.panel5.Controls.Add(this.textBox35);
            this.panel5.Controls.Add(this.label51);
            this.panel5.Controls.Add(this.checkBox3);
            this.panel5.Controls.Add(this.textBox40);
            this.panel5.Controls.Add(this.label53);
            this.panel5.Controls.Add(this.textBox42);
            this.panel5.Controls.Add(this.label54);
            this.panel5.Location = new System.Drawing.Point(262, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(245, 216);
            this.panel5.TabIndex = 289;
            // 
            // textBox30
            // 
            this.textBox30.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.ALIQUOTA_IPI_FORA_PRODUTO", true));
            this.textBox30.Location = new System.Drawing.Point(149, 128);
            this.textBox30.Name = "textBox30";
            this.textBox30.Size = new System.Drawing.Size(72, 20);
            this.textBox30.TabIndex = 158;
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Location = new System.Drawing.Point(19, 131);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(64, 13);
            this.label81.TabIndex = 159;
            this.label81.Text = "Aliquota IPI:";
            // 
            // textBox46
            // 
            this.textBox46.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.REDUCAO_ST_FORA_PRODUTO", true));
            this.textBox46.Location = new System.Drawing.Point(149, 102);
            this.textBox46.Name = "textBox46";
            this.textBox46.Size = new System.Drawing.Size(72, 20);
            this.textBox46.TabIndex = 156;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(19, 105);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(71, 13);
            this.label59.TabIndex = 157;
            this.label59.Text = "Redução ST:";
            // 
            // textBox45
            // 
            this.textBox45.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.ST_SAIDA_FORA_PRODUTO", true));
            this.textBox45.Location = new System.Drawing.Point(149, 180);
            this.textBox45.Name = "textBox45";
            this.textBox45.Size = new System.Drawing.Size(72, 20);
            this.textBox45.TabIndex = 154;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(19, 183);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(31, 13);
            this.label58.TabIndex = 155;
            this.label58.Text = "CST:";
            // 
            // textBox19
            // 
            this.textBox19.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.ALIQUOTA_ICMS_ST_FORA_PRODUTO", true));
            this.textBox19.Location = new System.Drawing.Point(149, 49);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(72, 20);
            this.textBox19.TabIndex = 150;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(19, 52);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(96, 13);
            this.label50.TabIndex = 151;
            this.label50.Text = "Alíquota ICMS ST:";
            // 
            // textBox35
            // 
            this.textBox35.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.IVA_FORA_PRODUTO", true));
            this.textBox35.Location = new System.Drawing.Point(149, 154);
            this.textBox35.Name = "textBox35";
            this.textBox35.Size = new System.Drawing.Size(72, 20);
            this.textBox35.TabIndex = 148;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(19, 157);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(27, 13);
            this.label51.TabIndex = 149;
            this.label51.Text = "IVA:";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.dsProdutos, "PRODUTOS.ICMS_FORA_S_N_PRODUTO", true));
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(22, 3);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(132, 17);
            this.checkBox3.TabIndex = 147;
            this.checkBox3.Text = "ICMS Fora Estado:";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // textBox40
            // 
            this.textBox40.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.REDUCAO_FORA_PRODUTO", true));
            this.textBox40.Location = new System.Drawing.Point(149, 76);
            this.textBox40.Name = "textBox40";
            this.textBox40.Size = new System.Drawing.Size(72, 20);
            this.textBox40.TabIndex = 139;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(19, 79);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(54, 13);
            this.label53.TabIndex = 140;
            this.label53.Text = "Redução:";
            // 
            // textBox42
            // 
            this.textBox42.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.ALIQUOTA_FORA_ICMS_PRODUTO", true));
            this.textBox42.Location = new System.Drawing.Point(149, 23);
            this.textBox42.Name = "textBox42";
            this.textBox42.Size = new System.Drawing.Size(72, 20);
            this.textBox42.TabIndex = 137;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(19, 26);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(79, 13);
            this.label54.TabIndex = 138;
            this.label54.Text = "Alíquota ICMS:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SpringGreen;
            this.panel4.Controls.Add(this.textBox47);
            this.panel4.Controls.Add(this.label60);
            this.panel4.Controls.Add(this.textBox44);
            this.panel4.Controls.Add(this.label57);
            this.panel4.Controls.Add(this.textBox18);
            this.panel4.Controls.Add(this.label49);
            this.panel4.Controls.Add(this.textBox3);
            this.panel4.Controls.Add(this.label42);
            this.panel4.Controls.Add(this.checkBox2);
            this.panel4.Controls.Add(this.textBox37);
            this.panel4.Controls.Add(this.label39);
            this.panel4.Controls.Add(this.textBox38);
            this.panel4.Controls.Add(this.label40);
            this.panel4.Controls.Add(this.textBox39);
            this.panel4.Controls.Add(this.label41);
            this.panel4.Location = new System.Drawing.Point(11, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(245, 216);
            this.panel4.TabIndex = 153;
            // 
            // textBox47
            // 
            this.textBox47.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.REDUCAO_ST_PRODUTO", true));
            this.textBox47.Location = new System.Drawing.Point(149, 102);
            this.textBox47.Name = "textBox47";
            this.textBox47.Size = new System.Drawing.Size(72, 20);
            this.textBox47.TabIndex = 158;
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(19, 105);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(71, 13);
            this.label60.TabIndex = 159;
            this.label60.Text = "Redução ST:";
            // 
            // textBox44
            // 
            this.textBox44.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.ST_SAIDA_PRODUTO", true));
            this.textBox44.Location = new System.Drawing.Point(149, 180);
            this.textBox44.Name = "textBox44";
            this.textBox44.Size = new System.Drawing.Size(72, 20);
            this.textBox44.TabIndex = 152;
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(19, 183);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(31, 13);
            this.label57.TabIndex = 153;
            this.label57.Text = "CST:";
            // 
            // textBox18
            // 
            this.textBox18.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.ALIQUOTA_ICMS_ST_PRODUTO", true));
            this.textBox18.Location = new System.Drawing.Point(149, 49);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(72, 20);
            this.textBox18.TabIndex = 150;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(19, 52);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(96, 13);
            this.label49.TabIndex = 151;
            this.label49.Text = "Alíquota ICMS ST:";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.IVA_PRODUTO", true));
            this.textBox3.Location = new System.Drawing.Point(149, 154);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(72, 20);
            this.textBox3.TabIndex = 148;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(19, 157);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(27, 13);
            this.label42.TabIndex = 149;
            this.label42.Text = "IVA:";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.dsProdutos, "PRODUTOS.ICMS_S_N_PRODUTO", true));
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(22, 3);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(145, 17);
            this.checkBox2.TabIndex = 147;
            this.checkBox2.Text = "ICMS Dentro Estado:";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // textBox37
            // 
            this.textBox37.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.ALIQUOTA_IPI_PRODUTO", true));
            this.textBox37.Location = new System.Drawing.Point(149, 128);
            this.textBox37.Name = "textBox37";
            this.textBox37.Size = new System.Drawing.Size(72, 20);
            this.textBox37.TabIndex = 141;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(19, 131);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(66, 13);
            this.label39.TabIndex = 142;
            this.label39.Text = "Alíquota IPI:";
            // 
            // textBox38
            // 
            this.textBox38.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.REDUCAO_ICMS_PRODUTO", true));
            this.textBox38.Location = new System.Drawing.Point(149, 76);
            this.textBox38.Name = "textBox38";
            this.textBox38.Size = new System.Drawing.Size(72, 20);
            this.textBox38.TabIndex = 139;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(19, 79);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(54, 13);
            this.label40.TabIndex = 140;
            this.label40.Text = "Redução:";
            // 
            // textBox39
            // 
            this.textBox39.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.ALIQUOTA_ICMS_PRODUTO", true));
            this.textBox39.Location = new System.Drawing.Point(149, 23);
            this.textBox39.Name = "textBox39";
            this.textBox39.Size = new System.Drawing.Size(72, 20);
            this.textBox39.TabIndex = 137;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(19, 26);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(79, 13);
            this.label41.TabIndex = 138;
            this.label41.Text = "Alíquota ICMS:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Controls.Add(this.label37);
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Controls.Add(this.panel2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(963, 296);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Valores";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.COMISSAO_PRODUTO", true));
            this.textBox1.Location = new System.Drawing.Point(406, 149);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(72, 20);
            this.textBox1.TabIndex = 141;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(276, 152);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(55, 13);
            this.label37.TabIndex = 142;
            this.label37.Text = "Comissão:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SpringGreen;
            this.panel3.Controls.Add(this.button13);
            this.panel3.Controls.Add(this.tb_coeficiente);
            this.panel3.Controls.Add(this.label67);
            this.panel3.Controls.Add(this.txtDescontoMaximo);
            this.panel3.Controls.Add(this.label63);
            this.panel3.Controls.Add(this.textBox41);
            this.panel3.Controls.Add(this.label43);
            this.panel3.Controls.Add(this.textBox31);
            this.panel3.Controls.Add(this.label33);
            this.panel3.Controls.Add(this.tb_lucro_produto);
            this.panel3.Controls.Add(this.label34);
            this.panel3.Location = new System.Drawing.Point(263, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(246, 137);
            this.panel3.TabIndex = 153;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(96, 109);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(47, 26);
            this.button13.TabIndex = 145;
            this.button13.Text = "$";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // tb_coeficiente
            // 
            this.tb_coeficiente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.COEFICIENTE_LUCRO_PRODUTO", true));
            this.tb_coeficiente.Location = new System.Drawing.Point(149, 112);
            this.tb_coeficiente.Name = "tb_coeficiente";
            this.tb_coeficiente.Size = new System.Drawing.Size(72, 20);
            this.tb_coeficiente.TabIndex = 144;
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(19, 115);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(63, 13);
            this.label67.TabIndex = 143;
            this.label67.Text = "Coeficiente:";
            // 
            // txtDescontoMaximo
            // 
            this.txtDescontoMaximo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.DESCONTO_MAXIMO_PRODUTO", true));
            this.txtDescontoMaximo.Location = new System.Drawing.Point(149, 86);
            this.txtDescontoMaximo.Name = "txtDescontoMaximo";
            this.txtDescontoMaximo.Size = new System.Drawing.Size(72, 20);
            this.txtDescontoMaximo.TabIndex = 142;
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(19, 89);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(111, 13);
            this.label63.TabIndex = 141;
            this.label63.Text = "Desconto máximo (%):";
            // 
            // textBox41
            // 
            this.textBox41.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.PROD_RECEITA_PRODUTO", true));
            this.textBox41.Location = new System.Drawing.Point(149, 60);
            this.textBox41.Name = "textBox41";
            this.textBox41.Size = new System.Drawing.Size(72, 20);
            this.textBox41.TabIndex = 139;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(19, 63);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(87, 13);
            this.label43.TabIndex = 140;
            this.label43.Text = "Produto Receita:";
            // 
            // textBox31
            // 
            this.textBox31.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.ULT_REAJ_PRODUTO", true));
            this.textBox31.Location = new System.Drawing.Point(149, 34);
            this.textBox31.Name = "textBox31";
            this.textBox31.Size = new System.Drawing.Size(72, 20);
            this.textBox31.TabIndex = 137;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(19, 37);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(84, 13);
            this.label33.TabIndex = 138;
            this.label33.Text = "Ultimo Reajuste:";
            // 
            // tb_lucro_produto
            // 
            this.tb_lucro_produto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.LUCRO_PRODUTO", true));
            this.tb_lucro_produto.Location = new System.Drawing.Point(149, 8);
            this.tb_lucro_produto.Name = "tb_lucro_produto";
            this.tb_lucro_produto.Size = new System.Drawing.Size(72, 20);
            this.tb_lucro_produto.TabIndex = 135;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(19, 11);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(109, 13);
            this.label34.TabIndex = 136;
            this.label34.Text = "Lucro do Produto (%):";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SpringGreen;
            this.panel2.Controls.Add(this.textBox25);
            this.panel2.Controls.Add(this.label27);
            this.panel2.Controls.Add(this.tb_minimo);
            this.panel2.Controls.Add(this.label28);
            this.panel2.Controls.Add(this.tb_venda);
            this.panel2.Controls.Add(this.label29);
            this.panel2.Controls.Add(this.textBox28);
            this.panel2.Controls.Add(this.label30);
            this.panel2.Controls.Add(this.textBox29);
            this.panel2.Controls.Add(this.label31);
            this.panel2.Controls.Add(this.tb_custo);
            this.panel2.Controls.Add(this.label32);
            this.panel2.Location = new System.Drawing.Point(8, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(246, 163);
            this.panel2.TabIndex = 152;
            // 
            // textBox25
            // 
            this.textBox25.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.OUTRO_VALOR_PRODUTO", true));
            this.textBox25.Location = new System.Drawing.Point(149, 138);
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new System.Drawing.Size(72, 20);
            this.textBox25.TabIndex = 145;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(19, 141);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(41, 13);
            this.label27.TabIndex = 146;
            this.label27.Text = "Outros:";
            // 
            // tb_minimo
            // 
            this.tb_minimo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.VALOR_PROMOCAO_PRODUTO", true));
            this.tb_minimo.Location = new System.Drawing.Point(149, 112);
            this.tb_minimo.Name = "tb_minimo";
            this.tb_minimo.Size = new System.Drawing.Size(72, 20);
            this.tb_minimo.TabIndex = 143;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(19, 115);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(72, 13);
            this.label28.TabIndex = 144;
            this.label28.Text = "Valor Mínimo:";
            // 
            // tb_venda
            // 
            this.tb_venda.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.VALOR_VENDA_REVEND_PRODUTO", true));
            this.tb_venda.Location = new System.Drawing.Point(149, 86);
            this.tb_venda.Name = "tb_venda";
            this.tb_venda.Size = new System.Drawing.Size(72, 20);
            this.tb_venda.TabIndex = 141;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(19, 89);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(130, 13);
            this.label29.TabIndex = 142;
            this.label29.Text = "Valor Venda Revendedor:";
            // 
            // textBox28
            // 
            this.textBox28.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.VALOR_VENDA_PRODUTOR_PRODUTO", true));
            this.textBox28.Location = new System.Drawing.Point(149, 60);
            this.textBox28.Name = "textBox28";
            this.textBox28.Size = new System.Drawing.Size(72, 20);
            this.textBox28.TabIndex = 139;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(19, 63);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(68, 13);
            this.label30.TabIndex = 140;
            this.label30.Text = "Valor Venda:";
            // 
            // textBox29
            // 
            this.textBox29.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.CUSTO_MED_PRODUTO", true));
            this.textBox29.Location = new System.Drawing.Point(149, 34);
            this.textBox29.Name = "textBox29";
            this.textBox29.Size = new System.Drawing.Size(72, 20);
            this.textBox29.TabIndex = 137;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(19, 37);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(69, 13);
            this.label31.TabIndex = 138;
            this.label31.Text = "Custo Medio:";
            // 
            // tb_custo
            // 
            this.tb_custo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.CUSTO_PRODUTO", true));
            this.tb_custo.Location = new System.Drawing.Point(149, 8);
            this.tb_custo.Name = "tb_custo";
            this.tb_custo.Size = new System.Drawing.Size(72, 20);
            this.tb_custo.TabIndex = 135;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(19, 11);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(92, 13);
            this.label32.TabIndex = 136;
            this.label32.Text = "Custo do Produto:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.checkBox4);
            this.tabPage2.Controls.Add(this.textBox13);
            this.tabPage2.Controls.Add(this.textBox14);
            this.tabPage2.Controls.Add(this.textBox12);
            this.tabPage2.Controls.Add(this.textBox11);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(963, 296);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Estoque";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsProdutos, "PRODUTOS.CORTAR_SEM_ESTOQUE_PRODUTO", true));
            this.checkBox4.Location = new System.Drawing.Point(56, 235);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(158, 17);
            this.checkBox4.TabIndex = 152;
            this.checkBox4.Text = "Cortar Produto sem Estoque";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // textBox13
            // 
            this.textBox13.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.META_SEMESTRAL_PRODUTO", true));
            this.textBox13.Location = new System.Drawing.Point(406, 90);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(72, 20);
            this.textBox13.TabIndex = 150;
            // 
            // textBox14
            // 
            this.textBox14.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.TAB_PRODUTO", true));
            this.textBox14.Location = new System.Drawing.Point(406, 64);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(72, 20);
            this.textBox14.TabIndex = 148;
            // 
            // textBox12
            // 
            this.textBox12.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.COD_REDUZIDO_PRODUTO", true));
            this.textBox12.Location = new System.Drawing.Point(406, 38);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(72, 20);
            this.textBox12.TabIndex = 146;
            // 
            // textBox11
            // 
            this.textBox11.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.META_ANUAL_PRODUTO", true));
            this.textBox11.Location = new System.Drawing.Point(406, 12);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(72, 20);
            this.textBox11.TabIndex = 144;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(323, 93);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 13);
            this.label14.TabIndex = 151;
            this.label14.Text = "Meta Semestral:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(323, 67);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 13);
            this.label15.TabIndex = 149;
            this.label15.Text = "Tab. Produto:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(323, 41);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 13);
            this.label13.TabIndex = 147;
            this.label13.Text = "Cód. Reduzido:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(323, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 145;
            this.label12.Text = "Meta Anual:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SpringGreen;
            this.panel1.Controls.Add(this.textBox32);
            this.panel1.Controls.Add(this.label89);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.label73);
            this.panel1.Controls.Add(this.tb_estoque_medio);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.textBox20);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.textBox15);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.textBox16);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.textBox17);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.tb_estoque_atual);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 221);
            this.panel1.TabIndex = 143;
            // 
            // textBox32
            // 
            this.textBox32.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.ESTOQUE_ENCOMENDADO_PRODUTO", true));
            this.textBox32.Location = new System.Drawing.Point(162, 112);
            this.textBox32.Name = "textBox32";
            this.textBox32.Size = new System.Drawing.Size(72, 20);
            this.textBox32.TabIndex = 149;
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.label89.Location = new System.Drawing.Point(19, 115);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(61, 13);
            this.label89.TabIndex = 150;
            this.label89.Text = "Disponível:";
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.ESTOQUE_RESERVA_FECHADA_PRODUTO", true));
            this.textBox4.Location = new System.Drawing.Point(162, 60);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(72, 20);
            this.textBox4.TabIndex = 147;
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Location = new System.Drawing.Point(19, 63);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(67, 13);
            this.label73.TabIndex = 148;
            this.label73.Text = "Empenhado:";
            // 
            // tb_estoque_medio
            // 
            this.tb_estoque_medio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.ESTOQUE_MEDIO_PRODUTO", true));
            this.tb_estoque_medio.Location = new System.Drawing.Point(162, 193);
            this.tb_estoque_medio.Name = "tb_estoque_medio";
            this.tb_estoque_medio.Size = new System.Drawing.Size(72, 20);
            this.tb_estoque_medio.TabIndex = 145;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(19, 196);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(75, 13);
            this.label21.TabIndex = 146;
            this.label21.Text = "Estoque Ideal:";
            // 
            // textBox20
            // 
            this.textBox20.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.ESTOQUE_MAXIMO_PRODUTO", true));
            this.textBox20.Location = new System.Drawing.Point(162, 167);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(72, 20);
            this.textBox20.TabIndex = 143;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(19, 170);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(88, 13);
            this.label22.TabIndex = 144;
            this.label22.Text = "Estoque Máximo:";
            // 
            // textBox15
            // 
            this.textBox15.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.ESTOQUE_ENCOMENDADO_PRODUTO", true));
            this.textBox15.Location = new System.Drawing.Point(162, 86);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(72, 20);
            this.textBox15.TabIndex = 141;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(19, 89);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 13);
            this.label16.TabIndex = 142;
            this.label16.Text = "Produção:";
            // 
            // textBox16
            // 
            this.textBox16.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.ESTOQUE_MINIMO_PRODUTO", true));
            this.textBox16.Location = new System.Drawing.Point(162, 141);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(72, 20);
            this.textBox16.TabIndex = 139;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(19, 144);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(87, 13);
            this.label17.TabIndex = 140;
            this.label17.Text = "Estoque Mínimo:";
            // 
            // textBox17
            // 
            this.textBox17.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.ESTOQUE_RESERVADO_PRODUTO", true));
            this.textBox17.Location = new System.Drawing.Point(162, 34);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(72, 20);
            this.textBox17.TabIndex = 137;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(19, 37);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 13);
            this.label18.TabIndex = 138;
            this.label18.Text = "Necessidade:";
            // 
            // tb_estoque_atual
            // 
            this.tb_estoque_atual.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.ESTOQUE_ATUAL_PRODUTO", true));
            this.tb_estoque_atual.Location = new System.Drawing.Point(162, 8);
            this.tb_estoque_atual.Name = "tb_estoque_atual";
            this.tb_estoque_atual.Size = new System.Drawing.Size(72, 20);
            this.tb_estoque_atual.TabIndex = 135;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(19, 11);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(76, 13);
            this.label19.TabIndex = 136;
            this.label19.Text = "Estoque Atual:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(963, 296);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Descrições";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox27);
            this.groupBox2.Controls.Add(this.label80);
            this.groupBox2.Controls.Add(this.textBox26);
            this.groupBox2.Controls.Add(this.label75);
            this.groupBox2.Controls.Add(this.textBox7);
            this.groupBox2.Controls.Add(this.label66);
            this.groupBox2.Controls.Add(this.txtCodBarrasCaixa);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.tb_qtde_caixa);
            this.groupBox2.Controls.Add(this.label64);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.textBox8);
            this.groupBox2.Controls.Add(this.txtCodBarrasUnit);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tb_unidade);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tb_cod_unidade);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(11, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(508, 183);
            this.groupBox2.TabIndex = 132;
            this.groupBox2.TabStop = false;
            // 
            // textBox27
            // 
            this.textBox27.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.QTDE_PACOTE_SAIDA_PRODUTO", true));
            this.textBox27.Location = new System.Drawing.Point(410, 148);
            this.textBox27.Name = "textBox27";
            this.textBox27.Size = new System.Drawing.Size(50, 20);
            this.textBox27.TabIndex = 140;
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Location = new System.Drawing.Point(319, 151);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(85, 13);
            this.label80.TabIndex = 139;
            this.label80.Text = "Qtde no Pacote:";
            // 
            // textBox26
            // 
            this.textBox26.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.CEST_PRODUTO", true));
            this.textBox26.Location = new System.Drawing.Point(361, 45);
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new System.Drawing.Size(100, 20);
            this.textBox26.TabIndex = 138;
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Location = new System.Drawing.Point(317, 48);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(38, 13);
            this.label75.TabIndex = 137;
            this.label75.Text = "CEST:";
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.PESO_UNIT_PRODUTO", true));
            this.textBox7.Location = new System.Drawing.Point(112, 148);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 135;
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(15, 151);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(73, 13);
            this.label66.TabIndex = 136;
            this.label66.Text = "Peso Unitário:";
            // 
            // txtCodBarrasCaixa
            // 
            this.txtCodBarrasCaixa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.COD_BARRAS_CAIXA_PRODUTO", true));
            this.txtCodBarrasCaixa.Location = new System.Drawing.Point(112, 122);
            this.txtCodBarrasCaixa.Name = "txtCodBarrasCaixa";
            this.txtCodBarrasCaixa.Size = new System.Drawing.Size(347, 20);
            this.txtCodBarrasCaixa.TabIndex = 134;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 13);
            this.label10.TabIndex = 133;
            this.label10.Text = "Cód. de Barras Cx:";
            // 
            // tb_qtde_caixa
            // 
            this.tb_qtde_caixa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.QTDE_UNIDADE_PRODUTO", true));
            this.tb_qtde_caixa.Location = new System.Drawing.Point(410, 72);
            this.tb_qtde_caixa.Name = "tb_qtde_caixa";
            this.tb_qtde_caixa.Size = new System.Drawing.Size(50, 20);
            this.tb_qtde_caixa.TabIndex = 132;
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(284, 75);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(120, 13);
            this.label64.TabIndex = 131;
            this.label64.Text = "Qtde Entrada por Caixa:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(263, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(15, 22);
            this.button3.TabIndex = 129;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox8
            // 
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.NCM_PRODUTO", true));
            this.textBox8.Location = new System.Drawing.Point(112, 45);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 129;
            // 
            // txtCodBarrasUnit
            // 
            this.txtCodBarrasUnit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.COD_BARRAS_PRODUTO", true));
            this.txtCodBarrasUnit.Location = new System.Drawing.Point(113, 97);
            this.txtCodBarrasUnit.Name = "txtCodBarrasUnit";
            this.txtCodBarrasUnit.Size = new System.Drawing.Size(347, 20);
            this.txtCodBarrasUnit.TabIndex = 129;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 13);
            this.label8.TabIndex = 130;
            this.label8.Text = "Cód. de Barras Unit:";
            // 
            // tb_unidade
            // 
            this.tb_unidade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.DESCRICAO_UNIDADE_PRODUTO", true));
            this.tb_unidade.Location = new System.Drawing.Point(171, 71);
            this.tb_unidade.Name = "tb_unidade";
            this.tb_unidade.Size = new System.Drawing.Size(91, 20);
            this.tb_unidade.TabIndex = 127;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 130;
            this.label9.Text = "NCM:";
            // 
            // tb_cod_unidade
            // 
            this.tb_cod_unidade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.COD_UNIDADE_PRODUTO", true));
            this.tb_cod_unidade.Location = new System.Drawing.Point(112, 71);
            this.tb_cod_unidade.Name = "tb_cod_unidade";
            this.tb_cod_unidade.Size = new System.Drawing.Size(53, 20);
            this.tb_cod_unidade.TabIndex = 125;
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.CARACT_ADIC_PRODUTO", true));
            this.textBox6.Location = new System.Drawing.Point(113, 19);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(347, 20);
            this.textBox6.TabIndex = 127;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 126;
            this.label11.Text = "Un. Ent.:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 26);
            this.label7.TabIndex = 128;
            this.label7.Text = "Características \r\nAdicionais:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage10);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage9);
            this.tabControl1.Location = new System.Drawing.Point(16, 282);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(971, 322);
            this.tabControl1.TabIndex = 133;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.label70);
            this.tabPage6.Controls.Add(this.label69);
            this.tabPage6.Controls.Add(this.label68);
            this.tabPage6.Controls.Add(this.tb_comissao);
            this.tabPage6.Controls.Add(this.button14);
            this.tabPage6.Controls.Add(this.btnInserirVendedor);
            this.tabPage6.Controls.Add(this.txtNomeVendedor);
            this.tabPage6.Controls.Add(this.txtCodVendedor);
            this.tabPage6.Controls.Add(this.dgvComissao);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(963, 296);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Comissão/Vendedor";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(89, 26);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(84, 13);
            this.label70.TabIndex = 25;
            this.label70.Text = "Nome Vendedor";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(17, 26);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(60, 13);
            this.label69.TabIndex = 24;
            this.label69.Text = "Cód. Vend:";
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(17, 72);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(69, 13);
            this.label68.TabIndex = 23;
            this.label68.Text = "%. Comissão:";
            // 
            // tb_comissao
            // 
            this.tb_comissao.Location = new System.Drawing.Point(106, 69);
            this.tb_comissao.Name = "tb_comissao";
            this.tb_comissao.Size = new System.Drawing.Size(69, 20);
            this.tb_comissao.TabIndex = 22;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(357, 40);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(23, 23);
            this.button14.TabIndex = 21;
            this.button14.Text = "+";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // btnInserirVendedor
            // 
            this.btnInserirVendedor.Location = new System.Drawing.Point(186, 67);
            this.btnInserirVendedor.Name = "btnInserirVendedor";
            this.btnInserirVendedor.Size = new System.Drawing.Size(52, 23);
            this.btnInserirVendedor.TabIndex = 20;
            this.btnInserirVendedor.Text = "Inserir";
            this.btnInserirVendedor.UseVisualStyleBackColor = true;
            this.btnInserirVendedor.Click += new System.EventHandler(this.btnInserirVendedor_Click);
            // 
            // txtNomeVendedor
            // 
            this.txtNomeVendedor.Location = new System.Drawing.Point(84, 42);
            this.txtNomeVendedor.Name = "txtNomeVendedor";
            this.txtNomeVendedor.ReadOnly = true;
            this.txtNomeVendedor.Size = new System.Drawing.Size(267, 20);
            this.txtNomeVendedor.TabIndex = 19;
            // 
            // txtCodVendedor
            // 
            this.txtCodVendedor.Location = new System.Drawing.Point(17, 42);
            this.txtCodVendedor.Name = "txtCodVendedor";
            this.txtCodVendedor.ReadOnly = true;
            this.txtCodVendedor.Size = new System.Drawing.Size(61, 20);
            this.txtCodVendedor.TabIndex = 18;
            // 
            // dgvComissao
            // 
            this.dgvComissao.AllowUserToAddRows = false;
            this.dgvComissao.AutoGenerateColumns = false;
            this.dgvComissao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComissao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODCPVDataGridViewTextBoxColumn,
            this.cODVENDEDORCPVDataGridViewTextBoxColumn,
            this.nOMEVENDEDORCPVDataGridViewTextBoxColumn,
            this.cODPRODUTOCPVDataGridViewTextBoxColumn,
            this.pORCCOMISSAOCPVDataGridViewTextBoxColumn});
            this.dgvComissao.DataMember = "COMISSAO_PRODUTO_VENDEDOR";
            this.dgvComissao.DataSource = this.dsCpv;
            this.dgvComissao.Location = new System.Drawing.Point(14, 105);
            this.dgvComissao.Name = "dgvComissao";
            this.dgvComissao.Size = new System.Drawing.Size(366, 137);
            this.dgvComissao.TabIndex = 0;
            // 
            // cODCPVDataGridViewTextBoxColumn
            // 
            this.cODCPVDataGridViewTextBoxColumn.DataPropertyName = "COD_CPV";
            this.cODCPVDataGridViewTextBoxColumn.HeaderText = "COD_CPV";
            this.cODCPVDataGridViewTextBoxColumn.Name = "cODCPVDataGridViewTextBoxColumn";
            this.cODCPVDataGridViewTextBoxColumn.Visible = false;
            // 
            // cODVENDEDORCPVDataGridViewTextBoxColumn
            // 
            this.cODVENDEDORCPVDataGridViewTextBoxColumn.DataPropertyName = "COD_VENDEDOR_CPV";
            this.cODVENDEDORCPVDataGridViewTextBoxColumn.HeaderText = "Cód. Vendedor";
            this.cODVENDEDORCPVDataGridViewTextBoxColumn.Name = "cODVENDEDORCPVDataGridViewTextBoxColumn";
            this.cODVENDEDORCPVDataGridViewTextBoxColumn.Width = 50;
            // 
            // nOMEVENDEDORCPVDataGridViewTextBoxColumn
            // 
            this.nOMEVENDEDORCPVDataGridViewTextBoxColumn.DataPropertyName = "NOME_VENDEDOR_CPV";
            this.nOMEVENDEDORCPVDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nOMEVENDEDORCPVDataGridViewTextBoxColumn.Name = "nOMEVENDEDORCPVDataGridViewTextBoxColumn";
            // 
            // cODPRODUTOCPVDataGridViewTextBoxColumn
            // 
            this.cODPRODUTOCPVDataGridViewTextBoxColumn.DataPropertyName = "COD_PRODUTO_CPV";
            this.cODPRODUTOCPVDataGridViewTextBoxColumn.HeaderText = "Cód. Prod";
            this.cODPRODUTOCPVDataGridViewTextBoxColumn.Name = "cODPRODUTOCPVDataGridViewTextBoxColumn";
            this.cODPRODUTOCPVDataGridViewTextBoxColumn.Visible = false;
            // 
            // pORCCOMISSAOCPVDataGridViewTextBoxColumn
            // 
            this.pORCCOMISSAOCPVDataGridViewTextBoxColumn.DataPropertyName = "PORC_COMISSAO_CPV";
            this.pORCCOMISSAOCPVDataGridViewTextBoxColumn.HeaderText = "%. Comissão";
            this.pORCCOMISSAOCPVDataGridViewTextBoxColumn.Name = "pORCCOMISSAOCPVDataGridViewTextBoxColumn";
            this.pORCCOMISSAOCPVDataGridViewTextBoxColumn.Width = 60;
            // 
            // dsCpv
            // 
            this.dsCpv.DataSetName = "dsCpv";
            this.dsCpv.Namespace = "http://www.tempuri.org/dsCpv.xsd";
            this.dsCpv.Tables.AddRange(new System.Data.DataTable[] {
            this.COMISSAO_PRODUTO_VENDEDOR});
            // 
            // COMISSAO_PRODUTO_VENDEDOR
            // 
            this.COMISSAO_PRODUTO_VENDEDOR.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_CPV,
            this.COD_VENDEDOR_CPV,
            this.COD_PRODUTO_CPV,
            this.PORC_COMISSAO_CPV,
            this.NOME_VENDEDOR_CPV});
            this.COMISSAO_PRODUTO_VENDEDOR.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_CPV"}, true)});
            this.COMISSAO_PRODUTO_VENDEDOR.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_CPV};
            this.COMISSAO_PRODUTO_VENDEDOR.TableName = "COMISSAO_PRODUTO_VENDEDOR";
            // 
            // COD_CPV
            // 
            this.COD_CPV.AllowDBNull = false;
            this.COD_CPV.ColumnName = "COD_CPV";
            this.COD_CPV.DataType = typeof(int);
            // 
            // COD_VENDEDOR_CPV
            // 
            this.COD_VENDEDOR_CPV.ColumnName = "COD_VENDEDOR_CPV";
            this.COD_VENDEDOR_CPV.DataType = typeof(int);
            // 
            // COD_PRODUTO_CPV
            // 
            this.COD_PRODUTO_CPV.ColumnName = "COD_PRODUTO_CPV";
            this.COD_PRODUTO_CPV.DataType = typeof(int);
            // 
            // PORC_COMISSAO_CPV
            // 
            this.PORC_COMISSAO_CPV.ColumnName = "PORC_COMISSAO_CPV";
            this.PORC_COMISSAO_CPV.DataType = typeof(double);
            // 
            // NOME_VENDEDOR_CPV
            // 
            this.NOME_VENDEDOR_CPV.ColumnName = "NOME_VENDEDOR_CPV";
            this.NOME_VENDEDOR_CPV.MaxLength = 100;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.panel6);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(963, 296);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Componentes";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel6.Controls.Add(this.button33);
            this.panel6.Controls.Add(this.button32);
            this.panel6.Controls.Add(this.dgvKit);
            this.panel6.Controls.Add(this.label83);
            this.panel6.Controls.Add(this.label74);
            this.panel6.Controls.Add(this.tb_cod_item);
            this.panel6.Controls.Add(this.label72);
            this.panel6.Controls.Add(this.label71);
            this.panel6.Controls.Add(this.tb_qtde_kit);
            this.panel6.Controls.Add(this.tb_item_item);
            this.panel6.Controls.Add(this.button15);
            this.panel6.Controls.Add(this.checkBox5);
            this.panel6.Location = new System.Drawing.Point(4, 14);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(771, 267);
            this.panel6.TabIndex = 12;
            // 
            // button33
            // 
            this.button33.Location = new System.Drawing.Point(437, 37);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(124, 31);
            this.button33.TabIndex = 15;
            this.button33.Text = "Excluir Componentes";
            this.button33.UseVisualStyleBackColor = true;
            this.button33.Click += new System.EventHandler(this.button33_Click);
            // 
            // button32
            // 
            this.button32.Location = new System.Drawing.Point(567, 37);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(124, 31);
            this.button32.TabIndex = 14;
            this.button32.Text = "Copiar Componentes";
            this.button32.UseVisualStyleBackColor = true;
            this.button32.Click += new System.EventHandler(this.button32_Click);
            // 
            // dgvKit
            // 
            this.dgvKit.AllowUserToAddRows = false;
            this.dgvKit.AllowUserToDeleteRows = false;
            this.dgvKit.AutoGenerateColumns = false;
            this.dgvKit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_cod_pk,
            this.col_cod,
            this.COD_FORN,
            this.dESCRICAOPKDataGridViewTextBoxColumn,
            this.qTDEPKDataGridViewTextBoxColumn,
            this.vALORUNITPKDataGridViewTextBoxColumn});
            this.dgvKit.DataMember = "PRODUTOS_KIT";
            this.dgvKit.DataSource = this.dsProdutos_kit;
            this.dgvKit.Location = new System.Drawing.Point(8, 78);
            this.dgvKit.Name = "dgvKit";
            this.dgvKit.ReadOnly = true;
            this.dgvKit.Size = new System.Drawing.Size(750, 186);
            this.dgvKit.TabIndex = 13;
            this.dgvKit.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKit_CellDoubleClick);
            // 
            // col_cod_pk
            // 
            this.col_cod_pk.DataPropertyName = "COD_PK";
            this.col_cod_pk.HeaderText = "COD_PK";
            this.col_cod_pk.Name = "col_cod_pk";
            this.col_cod_pk.ReadOnly = true;
            this.col_cod_pk.Visible = false;
            // 
            // col_cod
            // 
            this.col_cod.DataPropertyName = "COD_PRODUTO_PK";
            this.col_cod.HeaderText = "Cód Produto";
            this.col_cod.Name = "col_cod";
            this.col_cod.ReadOnly = true;
            this.col_cod.Width = 70;
            // 
            // COD_FORN
            // 
            this.COD_FORN.DataPropertyName = "COD_FORN";
            this.COD_FORN.HeaderText = "Cod. Int.";
            this.COD_FORN.Name = "COD_FORN";
            this.COD_FORN.ReadOnly = true;
            // 
            // dESCRICAOPKDataGridViewTextBoxColumn
            // 
            this.dESCRICAOPKDataGridViewTextBoxColumn.DataPropertyName = "DESCRICAO_PK";
            this.dESCRICAOPKDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.dESCRICAOPKDataGridViewTextBoxColumn.Name = "dESCRICAOPKDataGridViewTextBoxColumn";
            this.dESCRICAOPKDataGridViewTextBoxColumn.ReadOnly = true;
            this.dESCRICAOPKDataGridViewTextBoxColumn.Width = 230;
            // 
            // qTDEPKDataGridViewTextBoxColumn
            // 
            this.qTDEPKDataGridViewTextBoxColumn.DataPropertyName = "QTDE_PK";
            this.qTDEPKDataGridViewTextBoxColumn.HeaderText = "Qtde";
            this.qTDEPKDataGridViewTextBoxColumn.Name = "qTDEPKDataGridViewTextBoxColumn";
            this.qTDEPKDataGridViewTextBoxColumn.ReadOnly = true;
            this.qTDEPKDataGridViewTextBoxColumn.Width = 60;
            // 
            // vALORUNITPKDataGridViewTextBoxColumn
            // 
            this.vALORUNITPKDataGridViewTextBoxColumn.DataPropertyName = "VALOR_UNIT_PK";
            this.vALORUNITPKDataGridViewTextBoxColumn.HeaderText = "Valor Unit";
            this.vALORUNITPKDataGridViewTextBoxColumn.Name = "vALORUNITPKDataGridViewTextBoxColumn";
            this.vALORUNITPKDataGridViewTextBoxColumn.ReadOnly = true;
            this.vALORUNITPKDataGridViewTextBoxColumn.Width = 70;
            // 
            // dsProdutos_kit
            // 
            this.dsProdutos_kit.DataSetName = "dsProdutos_kit";
            this.dsProdutos_kit.Namespace = "http://www.tempuri.org/dsProdutos_kit.xsd";
            this.dsProdutos_kit.Tables.AddRange(new System.Data.DataTable[] {
            this.PRODUTOS_KIT});
            // 
            // PRODUTOS_KIT
            // 
            this.PRODUTOS_KIT.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_PK,
            this.COD_PRODUTO_PK,
            this.DESCRICAO_PK,
            this.QTDE_PK,
            this.VALOR_UNIT_PK,
            this.COD_KIT_PK,
            this.dataColumn61});
            this.PRODUTOS_KIT.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_PK"}, true)});
            this.PRODUTOS_KIT.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_PK};
            this.PRODUTOS_KIT.TableName = "PRODUTOS_KIT";
            // 
            // COD_PK
            // 
            this.COD_PK.AllowDBNull = false;
            this.COD_PK.ColumnName = "COD_PK";
            this.COD_PK.DataType = typeof(int);
            // 
            // COD_PRODUTO_PK
            // 
            this.COD_PRODUTO_PK.ColumnName = "COD_PRODUTO_PK";
            this.COD_PRODUTO_PK.DataType = typeof(long);
            // 
            // DESCRICAO_PK
            // 
            this.DESCRICAO_PK.ColumnName = "DESCRICAO_PK";
            this.DESCRICAO_PK.MaxLength = 100;
            // 
            // QTDE_PK
            // 
            this.QTDE_PK.ColumnName = "QTDE_PK";
            this.QTDE_PK.DataType = typeof(double);
            // 
            // VALOR_UNIT_PK
            // 
            this.VALOR_UNIT_PK.ColumnName = "VALOR_UNIT_PK";
            this.VALOR_UNIT_PK.DataType = typeof(double);
            // 
            // COD_KIT_PK
            // 
            this.COD_KIT_PK.ColumnName = "COD_KIT_PK";
            this.COD_KIT_PK.DataType = typeof(long);
            // 
            // dataColumn61
            // 
            this.dataColumn61.ColumnName = "COD_FORN";
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label83.Location = new System.Drawing.Point(8, 8);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(83, 13);
            this.label83.TabIndex = 12;
            this.label83.Text = "Componentes";
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Location = new System.Drawing.Point(6, 27);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(32, 13);
            this.label74.TabIndex = 11;
            this.label74.Text = "Cod.:";
            // 
            // tb_cod_item
            // 
            this.tb_cod_item.Location = new System.Drawing.Point(8, 43);
            this.tb_cod_item.Name = "tb_cod_item";
            this.tb_cod_item.Size = new System.Drawing.Size(49, 20);
            this.tb_cod_item.TabIndex = 10;
            this.tb_cod_item.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_cod_item_KeyPress);
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Location = new System.Drawing.Point(255, 27);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(65, 13);
            this.label72.TabIndex = 8;
            this.label72.Text = "Quantidade:";
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(60, 27);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(76, 13);
            this.label71.TabIndex = 7;
            this.label71.Text = "Descrição(F2):";
            // 
            // tb_qtde_kit
            // 
            this.tb_qtde_kit.Location = new System.Drawing.Point(258, 43);
            this.tb_qtde_kit.Name = "tb_qtde_kit";
            this.tb_qtde_kit.Size = new System.Drawing.Size(62, 20);
            this.tb_qtde_kit.TabIndex = 5;
            this.tb_qtde_kit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_qtde_kit_KeyPress);
            // 
            // tb_item_item
            // 
            this.tb_item_item.Location = new System.Drawing.Point(63, 43);
            this.tb_item_item.Name = "tb_item_item";
            this.tb_item_item.Size = new System.Drawing.Size(189, 20);
            this.tb_item_item.TabIndex = 4;
            this.tb_item_item.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox26_KeyDown);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(326, 37);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(86, 31);
            this.button15.TabIndex = 2;
            this.button15.Text = "Inserir Produto";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(6, 37);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(121, 17);
            this.checkBox5.TabIndex = 0;
            this.checkBox5.Text = "Pacote Promocional";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.Visible = false;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.label88);
            this.tabPage8.Controls.Add(this.tb_item);
            this.tabPage8.Controls.Add(this.label86);
            this.tabPage8.Controls.Add(this.tb_un_componente);
            this.tabPage8.Controls.Add(this.button16);
            this.tabPage8.Controls.Add(this.label84);
            this.tabPage8.Controls.Add(this.tb_cod_componente);
            this.tabPage8.Controls.Add(this.label85);
            this.tabPage8.Controls.Add(this.label87);
            this.tabPage8.Controls.Add(this.tb_qtde_componente);
            this.tabPage8.Controls.Add(this.tb_descricao_componente);
            this.tabPage8.Controls.Add(this.button30);
            this.tabPage8.Controls.Add(this.dgvItens_produto);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(963, 296);
            this.tabPage8.TabIndex = 8;
            this.tabPage8.Text = "Matéria Prima/Itens Comerciais";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.Location = new System.Drawing.Point(67, 35);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(30, 13);
            this.label88.TabIndex = 37;
            this.label88.Text = "Item:";
            // 
            // tb_item
            // 
            this.tb_item.Location = new System.Drawing.Point(70, 51);
            this.tb_item.Name = "tb_item";
            this.tb_item.Size = new System.Drawing.Size(110, 20);
            this.tb_item.TabIndex = 36;
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.Location = new System.Drawing.Point(450, 35);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(50, 13);
            this.label86.TabIndex = 35;
            this.label86.Text = "Unidade:";
            // 
            // tb_un_componente
            // 
            this.tb_un_componente.Location = new System.Drawing.Point(453, 51);
            this.tb_un_componente.Name = "tb_un_componente";
            this.tb_un_componente.Size = new System.Drawing.Size(51, 20);
            this.tb_un_componente.TabIndex = 34;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(645, 30);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(63, 41);
            this.button16.TabIndex = 33;
            this.button16.Text = "Localizar Produto";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Visible = false;
            this.button16.Click += new System.EventHandler(this.button16_Click_2);
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Location = new System.Drawing.Point(13, 35);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(32, 13);
            this.label84.TabIndex = 32;
            this.label84.Text = "Cod.:";
            // 
            // tb_cod_componente
            // 
            this.tb_cod_componente.Location = new System.Drawing.Point(15, 51);
            this.tb_cod_componente.Name = "tb_cod_componente";
            this.tb_cod_componente.Size = new System.Drawing.Size(49, 20);
            this.tb_cod_componente.TabIndex = 31;
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.Location = new System.Drawing.Point(507, 35);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(65, 13);
            this.label85.TabIndex = 30;
            this.label85.Text = "Quantidade:";
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.Location = new System.Drawing.Point(183, 35);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(76, 13);
            this.label87.TabIndex = 29;
            this.label87.Text = "Descrição(F2):";
            // 
            // tb_qtde_componente
            // 
            this.tb_qtde_componente.Location = new System.Drawing.Point(510, 51);
            this.tb_qtde_componente.Name = "tb_qtde_componente";
            this.tb_qtde_componente.Size = new System.Drawing.Size(62, 20);
            this.tb_qtde_componente.TabIndex = 28;
            // 
            // tb_descricao_componente
            // 
            this.tb_descricao_componente.Location = new System.Drawing.Point(186, 51);
            this.tb_descricao_componente.Name = "tb_descricao_componente";
            this.tb_descricao_componente.Size = new System.Drawing.Size(261, 20);
            this.tb_descricao_componente.TabIndex = 27;
            this.tb_descricao_componente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_descricao_componente_KeyDown);
            // 
            // button30
            // 
            this.button30.Location = new System.Drawing.Point(579, 30);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(63, 41);
            this.button30.TabIndex = 26;
            this.button30.Text = "Inserir Produto";
            this.button30.UseVisualStyleBackColor = true;
            this.button30.Click += new System.EventHandler(this.button30_Click);
            // 
            // dgvItens_produto
            // 
            this.dgvItens_produto.AllowUserToAddRows = false;
            this.dgvItens_produto.AutoGenerateColumns = false;
            this.dgvItens_produto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens_produto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODIPDataGridViewTextBoxColumn,
            this.cODESTOQUEIPDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn8,
            this.dESCRICAOIPDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn9,
            this.qTDEIPDataGridViewTextBoxColumn});
            this.dgvItens_produto.DataMember = "ITENS_PRODUTO";
            this.dgvItens_produto.DataSource = this.dsItens_produto;
            this.dgvItens_produto.Location = new System.Drawing.Point(15, 82);
            this.dgvItens_produto.Name = "dgvItens_produto";
            this.dgvItens_produto.Size = new System.Drawing.Size(934, 184);
            this.dgvItens_produto.TabIndex = 25;
            // 
            // cODIPDataGridViewTextBoxColumn
            // 
            this.cODIPDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cODIPDataGridViewTextBoxColumn.DataPropertyName = "COD_IP";
            this.cODIPDataGridViewTextBoxColumn.HeaderText = "Cod.";
            this.cODIPDataGridViewTextBoxColumn.Name = "cODIPDataGridViewTextBoxColumn";
            this.cODIPDataGridViewTextBoxColumn.ReadOnly = true;
            this.cODIPDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cODIPDataGridViewTextBoxColumn.Width = 50;
            // 
            // cODESTOQUEIPDataGridViewTextBoxColumn
            // 
            this.cODESTOQUEIPDataGridViewTextBoxColumn.DataPropertyName = "COD_ESTOQUE_IP";
            this.cODESTOQUEIPDataGridViewTextBoxColumn.HeaderText = "Cod. Estoque";
            this.cODESTOQUEIPDataGridViewTextBoxColumn.Name = "cODESTOQUEIPDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ITEM_IP";
            this.dataGridViewTextBoxColumn8.HeaderText = "Item";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dESCRICAOIPDataGridViewTextBoxColumn
            // 
            this.dESCRICAOIPDataGridViewTextBoxColumn.DataPropertyName = "DESCRICAO_IP";
            this.dESCRICAOIPDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.dESCRICAOIPDataGridViewTextBoxColumn.Name = "dESCRICAOIPDataGridViewTextBoxColumn";
            this.dESCRICAOIPDataGridViewTextBoxColumn.Width = 320;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "UN_IP";
            this.dataGridViewTextBoxColumn9.HeaderText = "Unidade";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // qTDEIPDataGridViewTextBoxColumn
            // 
            this.qTDEIPDataGridViewTextBoxColumn.DataPropertyName = "QTDE_IP";
            dataGridViewCellStyle4.Format = "N6";
            dataGridViewCellStyle4.NullValue = null;
            this.qTDEIPDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.qTDEIPDataGridViewTextBoxColumn.HeaderText = "Qtde";
            this.qTDEIPDataGridViewTextBoxColumn.Name = "qTDEIPDataGridViewTextBoxColumn";
            this.qTDEIPDataGridViewTextBoxColumn.Width = 150;
            // 
            // dsItens_produto
            // 
            this.dsItens_produto.DataSetName = "dsItens_produto";
            this.dsItens_produto.Namespace = "http://www.tempuri.org/dsItens_produto.xsd";
            this.dsItens_produto.Tables.AddRange(new System.Data.DataTable[] {
            this.ITENS_PRODUTO});
            // 
            // ITENS_PRODUTO
            // 
            this.ITENS_PRODUTO.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_IP,
            this.COD_ESTOQUE_IP,
            this.DESCRICAO_IP,
            this.QTDE_IP,
            this.COD_PRODUTO_IP,
            this.UN_IP,
            this.ITEM_IP});
            this.ITENS_PRODUTO.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_IP"}, true)});
            this.ITENS_PRODUTO.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_IP};
            this.ITENS_PRODUTO.TableName = "ITENS_PRODUTO";
            // 
            // COD_IP
            // 
            this.COD_IP.AllowDBNull = false;
            this.COD_IP.ColumnName = "COD_IP";
            this.COD_IP.DataType = typeof(int);
            // 
            // COD_ESTOQUE_IP
            // 
            this.COD_ESTOQUE_IP.ColumnName = "COD_ESTOQUE_IP";
            this.COD_ESTOQUE_IP.DataType = typeof(int);
            // 
            // DESCRICAO_IP
            // 
            this.DESCRICAO_IP.ColumnName = "DESCRICAO_IP";
            this.DESCRICAO_IP.MaxLength = 200;
            // 
            // QTDE_IP
            // 
            this.QTDE_IP.ColumnName = "QTDE_IP";
            this.QTDE_IP.DataType = typeof(double);
            // 
            // COD_PRODUTO_IP
            // 
            this.COD_PRODUTO_IP.ColumnName = "COD_PRODUTO_IP";
            this.COD_PRODUTO_IP.DataType = typeof(long);
            // 
            // UN_IP
            // 
            this.UN_IP.ColumnName = "UN_IP";
            this.UN_IP.MaxLength = 20;
            // 
            // ITEM_IP
            // 
            this.ITEM_IP.ColumnName = "ITEM_IP";
            this.ITEM_IP.MaxLength = 100;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.button19);
            this.tabPage5.Controls.Add(this.button17);
            this.tabPage5.Controls.Add(this.button18);
            this.tabPage5.Controls.Add(this.button20);
            this.tabPage5.Controls.Add(this.button21);
            this.tabPage5.Controls.Add(this.button22);
            this.tabPage5.Controls.Add(this.button23);
            this.tabPage5.Controls.Add(this.button24);
            this.tabPage5.Controls.Add(this.button25);
            this.tabPage5.Controls.Add(this.button26);
            this.tabPage5.Controls.Add(this.button27);
            this.tabPage5.Controls.Add(this.label52);
            this.tabPage5.Controls.Add(this.label55);
            this.tabPage5.Controls.Add(this.label56);
            this.tabPage5.Controls.Add(this.label82);
            this.tabPage5.Controls.Add(this.dgvProd);
            this.tabPage5.Controls.Add(this.dgvSaidas);
            this.tabPage5.Controls.Add(this.dgvReserva);
            this.tabPage5.Controls.Add(this.dgvEstoque);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(963, 296);
            this.tabPage5.TabIndex = 7;
            this.tabPage5.Text = "Etiquetas";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.Location = new System.Drawing.Point(337, 69);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(24, 23);
            this.button19.TabIndex = 38;
            this.button19.Text = "<";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.Location = new System.Drawing.Point(213, 69);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(24, 23);
            this.button17.TabIndex = 37;
            this.button17.Text = ">";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.Location = new System.Drawing.Point(183, 69);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(24, 23);
            this.button18.TabIndex = 36;
            this.button18.Text = "-";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20.Location = new System.Drawing.Point(367, 69);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(24, 23);
            this.button20.TabIndex = 35;
            this.button20.Text = "*";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            this.button21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.Location = new System.Drawing.Point(913, 69);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(24, 23);
            this.button21.TabIndex = 34;
            this.button21.Text = "<";
            this.button21.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            this.button22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button22.Location = new System.Drawing.Point(884, 69);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(24, 23);
            this.button22.TabIndex = 33;
            this.button22.Text = "-";
            this.button22.UseVisualStyleBackColor = true;
            // 
            // button23
            // 
            this.button23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button23.Location = new System.Drawing.Point(667, 69);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(24, 23);
            this.button23.TabIndex = 32;
            this.button23.Text = "<";
            this.button23.UseVisualStyleBackColor = true;
            // 
            // button24
            // 
            this.button24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button24.Location = new System.Drawing.Point(637, 69);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(24, 23);
            this.button24.TabIndex = 31;
            this.button24.Text = ">";
            this.button24.UseVisualStyleBackColor = true;
            // 
            // button25
            // 
            this.button25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button25.Location = new System.Drawing.Point(607, 69);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(24, 23);
            this.button25.TabIndex = 30;
            this.button25.Text = "-";
            this.button25.UseVisualStyleBackColor = true;
            // 
            // button26
            // 
            this.button26.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button26.Location = new System.Drawing.Point(427, 69);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(24, 23);
            this.button26.TabIndex = 29;
            this.button26.Text = ">";
            this.button26.UseVisualStyleBackColor = true;
            // 
            // button27
            // 
            this.button27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button27.Location = new System.Drawing.Point(397, 69);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(24, 23);
            this.button27.TabIndex = 28;
            this.button27.Text = "-";
            this.button27.UseVisualStyleBackColor = true;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.Location = new System.Drawing.Point(722, 79);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(41, 13);
            this.label52.TabIndex = 27;
            this.label52.Text = "Saída";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label55.Location = new System.Drawing.Point(491, 79);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(68, 13);
            this.label55.TabIndex = 26;
            this.label55.Text = "Reservada";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label56.Location = new System.Drawing.Point(258, 79);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(53, 13);
            this.label56.TabIndex = 25;
            this.label56.Text = "Estoque";
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label82.Location = new System.Drawing.Point(25, 79);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(61, 13);
            this.label82.TabIndex = 24;
            this.label82.Text = "Produção";
            // 
            // dgvProd
            // 
            this.dgvProd.AllowUserToAddRows = false;
            this.dgvProd.AllowUserToDeleteRows = false;
            this.dgvProd.AutoGenerateColumns = false;
            this.dgvProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_n_etiqueta_prod,
            this.col_op_prod,
            this.qTDEETIQUETADataGridViewTextBoxColumn,
            this.col_status_prod});
            this.dgvProd.DataMember = "PRODUCAO";
            this.dgvProd.DataSource = this.dsEtiquetas;
            this.dgvProd.Location = new System.Drawing.Point(25, 95);
            this.dgvProd.Name = "dgvProd";
            this.dgvProd.ReadOnly = true;
            this.dgvProd.RowHeadersWidth = 20;
            this.dgvProd.Size = new System.Drawing.Size(212, 133);
            this.dgvProd.TabIndex = 23;
            // 
            // col_n_etiqueta_prod
            // 
            this.col_n_etiqueta_prod.DataPropertyName = "N_ETIQUETA";
            this.col_n_etiqueta_prod.HeaderText = "Nº";
            this.col_n_etiqueta_prod.Name = "col_n_etiqueta_prod";
            this.col_n_etiqueta_prod.ReadOnly = true;
            this.col_n_etiqueta_prod.Width = 40;
            // 
            // col_op_prod
            // 
            this.col_op_prod.DataPropertyName = "OP_ETIQUETA";
            this.col_op_prod.HeaderText = "Op";
            this.col_op_prod.Name = "col_op_prod";
            this.col_op_prod.ReadOnly = true;
            this.col_op_prod.Width = 70;
            // 
            // qTDEETIQUETADataGridViewTextBoxColumn
            // 
            this.qTDEETIQUETADataGridViewTextBoxColumn.DataPropertyName = "QTDE_ETIQUETA";
            this.qTDEETIQUETADataGridViewTextBoxColumn.HeaderText = "Qtde";
            this.qTDEETIQUETADataGridViewTextBoxColumn.Name = "qTDEETIQUETADataGridViewTextBoxColumn";
            this.qTDEETIQUETADataGridViewTextBoxColumn.ReadOnly = true;
            this.qTDEETIQUETADataGridViewTextBoxColumn.Width = 70;
            // 
            // col_status_prod
            // 
            this.col_status_prod.DataPropertyName = "STATUS_ETIQUETA";
            this.col_status_prod.HeaderText = "Status";
            this.col_status_prod.Name = "col_status_prod";
            this.col_status_prod.ReadOnly = true;
            // 
            // dsEtiquetas
            // 
            this.dsEtiquetas.DataSetName = "NewDataSet";
            this.dsEtiquetas.Tables.AddRange(new System.Data.DataTable[] {
            this.PRODUCAO,
            this.ESTOQUE,
            this.RESERVA,
            this.SAIDA});
            // 
            // PRODUCAO
            // 
            this.PRODUCAO.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn42,
            this.dataColumn43,
            this.dataColumn44,
            this.dataColumn45});
            this.PRODUCAO.TableName = "PRODUCAO";
            // 
            // dataColumn42
            // 
            this.dataColumn42.Caption = "N_ETIQUETA";
            this.dataColumn42.ColumnName = "N_ETIQUETA";
            this.dataColumn42.MaxLength = 3;
            // 
            // dataColumn43
            // 
            this.dataColumn43.Caption = "OP_ETIQUETA";
            this.dataColumn43.ColumnName = "OP_ETIQUETA";
            this.dataColumn43.MaxLength = 20;
            // 
            // dataColumn44
            // 
            this.dataColumn44.Caption = "QTDE_ETIQUETA";
            this.dataColumn44.ColumnName = "QTDE_ETIQUETA";
            this.dataColumn44.DataType = typeof(double);
            // 
            // dataColumn45
            // 
            this.dataColumn45.Caption = "STATUS_ETIQUETA";
            this.dataColumn45.ColumnName = "STATUS_ETIQUETA";
            this.dataColumn45.MaxLength = 200;
            // 
            // ESTOQUE
            // 
            this.ESTOQUE.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn46,
            this.dataColumn47,
            this.dataColumn48,
            this.dataColumn49});
            this.ESTOQUE.TableName = "ESTOQUE";
            // 
            // dataColumn46
            // 
            this.dataColumn46.Caption = "N_ETIQUETA";
            this.dataColumn46.ColumnName = "N_ETIQUETA";
            this.dataColumn46.MaxLength = 3;
            // 
            // dataColumn47
            // 
            this.dataColumn47.Caption = "OP_ETIQUETA";
            this.dataColumn47.ColumnName = "OP_ETIQUETA";
            this.dataColumn47.MaxLength = 20;
            // 
            // dataColumn48
            // 
            this.dataColumn48.Caption = "QTDE_ETIQUETA";
            this.dataColumn48.ColumnName = "QTDE_ETIQUETA";
            this.dataColumn48.DataType = typeof(double);
            // 
            // dataColumn49
            // 
            this.dataColumn49.Caption = "STATUS_ETIQUETA";
            this.dataColumn49.ColumnName = "STATUS_ETIQUETA";
            this.dataColumn49.MaxLength = 200;
            // 
            // RESERVA
            // 
            this.RESERVA.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn50,
            this.dataColumn51,
            this.dataColumn52,
            this.dataColumn53,
            this.dataColumn54});
            this.RESERVA.TableName = "RESERVA";
            // 
            // dataColumn50
            // 
            this.dataColumn50.Caption = "N_ETIQUETA";
            this.dataColumn50.ColumnName = "N_ETIQUETA";
            this.dataColumn50.MaxLength = 3;
            // 
            // dataColumn51
            // 
            this.dataColumn51.Caption = "OP_ETIQUETA";
            this.dataColumn51.ColumnName = "OP_ETIQUETA";
            this.dataColumn51.MaxLength = 20;
            // 
            // dataColumn52
            // 
            this.dataColumn52.Caption = "QTDE_ETIQUETA";
            this.dataColumn52.ColumnName = "QTDE_ETIQUETA";
            this.dataColumn52.DataType = typeof(double);
            // 
            // dataColumn53
            // 
            this.dataColumn53.Caption = "OP_SAIDA_ETIQUETA";
            this.dataColumn53.ColumnName = "OP_SAIDA_ETIQUETA";
            this.dataColumn53.DataType = typeof(int);
            // 
            // dataColumn54
            // 
            this.dataColumn54.Caption = "STATUS_ETIQUETA";
            this.dataColumn54.ColumnName = "STATUS_ETIQUETA";
            this.dataColumn54.MaxLength = 200;
            // 
            // SAIDA
            // 
            this.SAIDA.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn55,
            this.dataColumn56,
            this.dataColumn57,
            this.dataColumn58,
            this.dataColumn59,
            this.dataColumn60});
            this.SAIDA.TableName = "SAIDA";
            // 
            // dataColumn55
            // 
            this.dataColumn55.Caption = "N_ETIQUETA";
            this.dataColumn55.ColumnName = "N_ETIQUETA";
            this.dataColumn55.MaxLength = 3;
            // 
            // dataColumn56
            // 
            this.dataColumn56.Caption = "OP_ETIQUETA";
            this.dataColumn56.ColumnName = "OP_ETIQUETA";
            this.dataColumn56.MaxLength = 20;
            // 
            // dataColumn57
            // 
            this.dataColumn57.Caption = "QTDE_ETIQUETA";
            this.dataColumn57.ColumnName = "QTDE_ETIQUETA";
            this.dataColumn57.DataType = typeof(double);
            // 
            // dataColumn58
            // 
            this.dataColumn58.Caption = "OP_SAIDA_ETIQUETA";
            this.dataColumn58.ColumnName = "OP_SAIDA_ETIQUETA";
            this.dataColumn58.DataType = typeof(int);
            // 
            // dataColumn59
            // 
            this.dataColumn59.Caption = "NF_SAIDA_ETIQUETA";
            this.dataColumn59.ColumnName = "NF_SAIDA_ETIQUETA";
            this.dataColumn59.DataType = typeof(int);
            // 
            // dataColumn60
            // 
            this.dataColumn60.Caption = "STATUS_ETIQUETA";
            this.dataColumn60.ColumnName = "STATUS_ETIQUETA";
            this.dataColumn60.MaxLength = 200;
            // 
            // dgvSaidas
            // 
            this.dgvSaidas.AllowUserToAddRows = false;
            this.dgvSaidas.AllowUserToDeleteRows = false;
            this.dgvSaidas.AutoGenerateColumns = false;
            this.dgvSaidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.N_ETIQUETA_SAIDA,
            this.OP_ETIQUETA_SAIDA,
            this.qTDEETIQUETADataGridViewTextBoxColumn3,
            this.oPSAIDAETIQUETADataGridViewTextBoxColumn1,
            this.nFSAIDAETIQUETADataGridViewTextBoxColumn,
            this.sTATUSETIQUETADataGridViewTextBoxColumn3});
            this.dgvSaidas.DataMember = "SAIDA";
            this.dgvSaidas.DataSource = this.dsEtiquetas;
            this.dgvSaidas.Location = new System.Drawing.Point(725, 95);
            this.dgvSaidas.Name = "dgvSaidas";
            this.dgvSaidas.ReadOnly = true;
            this.dgvSaidas.RowHeadersWidth = 20;
            this.dgvSaidas.Size = new System.Drawing.Size(212, 133);
            this.dgvSaidas.TabIndex = 22;
            // 
            // N_ETIQUETA_SAIDA
            // 
            this.N_ETIQUETA_SAIDA.DataPropertyName = "N_ETIQUETA";
            this.N_ETIQUETA_SAIDA.HeaderText = "Nº";
            this.N_ETIQUETA_SAIDA.Name = "N_ETIQUETA_SAIDA";
            this.N_ETIQUETA_SAIDA.ReadOnly = true;
            this.N_ETIQUETA_SAIDA.Width = 40;
            // 
            // OP_ETIQUETA_SAIDA
            // 
            this.OP_ETIQUETA_SAIDA.DataPropertyName = "OP_ETIQUETA";
            this.OP_ETIQUETA_SAIDA.HeaderText = "Op";
            this.OP_ETIQUETA_SAIDA.Name = "OP_ETIQUETA_SAIDA";
            this.OP_ETIQUETA_SAIDA.ReadOnly = true;
            this.OP_ETIQUETA_SAIDA.Width = 70;
            // 
            // qTDEETIQUETADataGridViewTextBoxColumn3
            // 
            this.qTDEETIQUETADataGridViewTextBoxColumn3.DataPropertyName = "QTDE_ETIQUETA";
            this.qTDEETIQUETADataGridViewTextBoxColumn3.HeaderText = "Qtde";
            this.qTDEETIQUETADataGridViewTextBoxColumn3.Name = "qTDEETIQUETADataGridViewTextBoxColumn3";
            this.qTDEETIQUETADataGridViewTextBoxColumn3.ReadOnly = true;
            this.qTDEETIQUETADataGridViewTextBoxColumn3.Width = 70;
            // 
            // oPSAIDAETIQUETADataGridViewTextBoxColumn1
            // 
            this.oPSAIDAETIQUETADataGridViewTextBoxColumn1.DataPropertyName = "OP_SAIDA_ETIQUETA";
            this.oPSAIDAETIQUETADataGridViewTextBoxColumn1.HeaderText = "Op Saí";
            this.oPSAIDAETIQUETADataGridViewTextBoxColumn1.Name = "oPSAIDAETIQUETADataGridViewTextBoxColumn1";
            this.oPSAIDAETIQUETADataGridViewTextBoxColumn1.ReadOnly = true;
            this.oPSAIDAETIQUETADataGridViewTextBoxColumn1.Width = 70;
            // 
            // nFSAIDAETIQUETADataGridViewTextBoxColumn
            // 
            this.nFSAIDAETIQUETADataGridViewTextBoxColumn.DataPropertyName = "NF_SAIDA_ETIQUETA";
            this.nFSAIDAETIQUETADataGridViewTextBoxColumn.HeaderText = "NF";
            this.nFSAIDAETIQUETADataGridViewTextBoxColumn.Name = "nFSAIDAETIQUETADataGridViewTextBoxColumn";
            this.nFSAIDAETIQUETADataGridViewTextBoxColumn.ReadOnly = true;
            this.nFSAIDAETIQUETADataGridViewTextBoxColumn.Width = 70;
            // 
            // sTATUSETIQUETADataGridViewTextBoxColumn3
            // 
            this.sTATUSETIQUETADataGridViewTextBoxColumn3.DataPropertyName = "STATUS_ETIQUETA";
            this.sTATUSETIQUETADataGridViewTextBoxColumn3.HeaderText = "Status";
            this.sTATUSETIQUETADataGridViewTextBoxColumn3.Name = "sTATUSETIQUETADataGridViewTextBoxColumn3";
            this.sTATUSETIQUETADataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dgvReserva
            // 
            this.dgvReserva.AllowUserToAddRows = false;
            this.dgvReserva.AllowUserToDeleteRows = false;
            this.dgvReserva.AutoGenerateColumns = false;
            this.dgvReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReserva.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.N_ETIQUETA_RESERVA,
            this.OP_ETIQUETA_RESERVA,
            this.qTDEETIQUETADataGridViewTextBoxColumn2,
            this.oPSAIDAETIQUETADataGridViewTextBoxColumn,
            this.sTATUSETIQUETADataGridViewTextBoxColumn2});
            this.dgvReserva.DataMember = "RESERVA";
            this.dgvReserva.DataSource = this.dsEtiquetas;
            this.dgvReserva.Location = new System.Drawing.Point(481, 95);
            this.dgvReserva.Name = "dgvReserva";
            this.dgvReserva.ReadOnly = true;
            this.dgvReserva.RowHeadersWidth = 20;
            this.dgvReserva.Size = new System.Drawing.Size(212, 133);
            this.dgvReserva.TabIndex = 21;
            // 
            // N_ETIQUETA_RESERVA
            // 
            this.N_ETIQUETA_RESERVA.DataPropertyName = "N_ETIQUETA";
            this.N_ETIQUETA_RESERVA.HeaderText = "Nº";
            this.N_ETIQUETA_RESERVA.Name = "N_ETIQUETA_RESERVA";
            this.N_ETIQUETA_RESERVA.ReadOnly = true;
            this.N_ETIQUETA_RESERVA.Width = 40;
            // 
            // OP_ETIQUETA_RESERVA
            // 
            this.OP_ETIQUETA_RESERVA.DataPropertyName = "OP_ETIQUETA";
            this.OP_ETIQUETA_RESERVA.HeaderText = "Op";
            this.OP_ETIQUETA_RESERVA.Name = "OP_ETIQUETA_RESERVA";
            this.OP_ETIQUETA_RESERVA.ReadOnly = true;
            this.OP_ETIQUETA_RESERVA.Width = 70;
            // 
            // qTDEETIQUETADataGridViewTextBoxColumn2
            // 
            this.qTDEETIQUETADataGridViewTextBoxColumn2.DataPropertyName = "QTDE_ETIQUETA";
            this.qTDEETIQUETADataGridViewTextBoxColumn2.HeaderText = "Qtde";
            this.qTDEETIQUETADataGridViewTextBoxColumn2.Name = "qTDEETIQUETADataGridViewTextBoxColumn2";
            this.qTDEETIQUETADataGridViewTextBoxColumn2.ReadOnly = true;
            this.qTDEETIQUETADataGridViewTextBoxColumn2.Width = 70;
            // 
            // oPSAIDAETIQUETADataGridViewTextBoxColumn
            // 
            this.oPSAIDAETIQUETADataGridViewTextBoxColumn.DataPropertyName = "OP_SAIDA_ETIQUETA";
            this.oPSAIDAETIQUETADataGridViewTextBoxColumn.HeaderText = "Op Saí";
            this.oPSAIDAETIQUETADataGridViewTextBoxColumn.Name = "oPSAIDAETIQUETADataGridViewTextBoxColumn";
            this.oPSAIDAETIQUETADataGridViewTextBoxColumn.ReadOnly = true;
            this.oPSAIDAETIQUETADataGridViewTextBoxColumn.Width = 70;
            // 
            // sTATUSETIQUETADataGridViewTextBoxColumn2
            // 
            this.sTATUSETIQUETADataGridViewTextBoxColumn2.DataPropertyName = "STATUS_ETIQUETA";
            this.sTATUSETIQUETADataGridViewTextBoxColumn2.HeaderText = "Status";
            this.sTATUSETIQUETADataGridViewTextBoxColumn2.Name = "sTATUSETIQUETADataGridViewTextBoxColumn2";
            this.sTATUSETIQUETADataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dgvEstoque
            // 
            this.dgvEstoque.AllowUserToAddRows = false;
            this.dgvEstoque.AllowUserToDeleteRows = false;
            this.dgvEstoque.AutoGenerateColumns = false;
            this.dgvEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstoque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.N_ETIQUETA,
            this.OP_ETIQUETA,
            this.QTDE_ETIQUETA,
            this.sTATUSETIQUETADataGridViewTextBoxColumn1});
            this.dgvEstoque.DataMember = "ESTOQUE";
            this.dgvEstoque.DataSource = this.dsEtiquetas;
            this.dgvEstoque.Location = new System.Drawing.Point(257, 95);
            this.dgvEstoque.Name = "dgvEstoque";
            this.dgvEstoque.RowHeadersWidth = 20;
            this.dgvEstoque.Size = new System.Drawing.Size(194, 133);
            this.dgvEstoque.TabIndex = 20;
            // 
            // N_ETIQUETA
            // 
            this.N_ETIQUETA.DataPropertyName = "N_ETIQUETA";
            this.N_ETIQUETA.HeaderText = "Nº";
            this.N_ETIQUETA.Name = "N_ETIQUETA";
            this.N_ETIQUETA.ReadOnly = true;
            this.N_ETIQUETA.Width = 40;
            // 
            // OP_ETIQUETA
            // 
            this.OP_ETIQUETA.DataPropertyName = "OP_ETIQUETA";
            this.OP_ETIQUETA.HeaderText = "Op";
            this.OP_ETIQUETA.Name = "OP_ETIQUETA";
            this.OP_ETIQUETA.ReadOnly = true;
            this.OP_ETIQUETA.Width = 70;
            // 
            // QTDE_ETIQUETA
            // 
            this.QTDE_ETIQUETA.DataPropertyName = "QTDE_ETIQUETA";
            this.QTDE_ETIQUETA.HeaderText = "Qtde";
            this.QTDE_ETIQUETA.Name = "QTDE_ETIQUETA";
            this.QTDE_ETIQUETA.Width = 70;
            // 
            // sTATUSETIQUETADataGridViewTextBoxColumn1
            // 
            this.sTATUSETIQUETADataGridViewTextBoxColumn1.DataPropertyName = "STATUS_ETIQUETA";
            this.sTATUSETIQUETADataGridViewTextBoxColumn1.HeaderText = "Status";
            this.sTATUSETIQUETADataGridViewTextBoxColumn1.Name = "sTATUSETIQUETADataGridViewTextBoxColumn1";
            this.sTATUSETIQUETADataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.button31);
            this.tabPage9.Controls.Add(this.dgvDesenhos);
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(963, 296);
            this.tabPage9.TabIndex = 9;
            this.tabPage9.Text = "Documentos";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // button31
            // 
            this.button31.Location = new System.Drawing.Point(17, 31);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(75, 23);
            this.button31.TabIndex = 1;
            this.button31.Text = "Adicionar";
            this.button31.UseVisualStyleBackColor = true;
            this.button31.Click += new System.EventHandler(this.button31_Click);
            // 
            // dgvDesenhos
            // 
            this.dgvDesenhos.AllowUserToAddRows = false;
            this.dgvDesenhos.AutoGenerateColumns = false;
            this.dgvDesenhos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDesenhos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODDESPRODUTODataGridViewTextBoxColumn,
            this.col_abrir_desenho,
            this.col_link,
            this.tIPODESPRODUTODataGridViewTextBoxColumn,
            this.cODPRODDESPRODUTODataGridViewTextBoxColumn});
            this.dgvDesenhos.DataMember = "DESENHOS_PRODUTO";
            this.dgvDesenhos.DataSource = this.dsDesenhos_produto;
            this.dgvDesenhos.Location = new System.Drawing.Point(17, 60);
            this.dgvDesenhos.Name = "dgvDesenhos";
            this.dgvDesenhos.Size = new System.Drawing.Size(909, 218);
            this.dgvDesenhos.TabIndex = 0;
            this.dgvDesenhos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDesenhos_CellClick);
            this.dgvDesenhos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDesenhos_CellContentClick);
            // 
            // cODDESPRODUTODataGridViewTextBoxColumn
            // 
            this.cODDESPRODUTODataGridViewTextBoxColumn.DataPropertyName = "COD_DES_PRODUTO";
            this.cODDESPRODUTODataGridViewTextBoxColumn.HeaderText = "COD_DES_PRODUTO";
            this.cODDESPRODUTODataGridViewTextBoxColumn.Name = "cODDESPRODUTODataGridViewTextBoxColumn";
            this.cODDESPRODUTODataGridViewTextBoxColumn.Visible = false;
            // 
            // col_abrir_desenho
            // 
            this.col_abrir_desenho.HeaderText = "Abrir";
            this.col_abrir_desenho.Name = "col_abrir_desenho";
            this.col_abrir_desenho.Text = "Abrir";
            this.col_abrir_desenho.UseColumnTextForButtonValue = true;
            // 
            // col_link
            // 
            this.col_link.DataPropertyName = "LINK_DES_PRODUTO";
            this.col_link.HeaderText = "Link";
            this.col_link.Name = "col_link";
            this.col_link.Width = 400;
            // 
            // tIPODESPRODUTODataGridViewTextBoxColumn
            // 
            this.tIPODESPRODUTODataGridViewTextBoxColumn.DataPropertyName = "TIPO_DES_PRODUTO";
            this.tIPODESPRODUTODataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tIPODESPRODUTODataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "Ficha Técnica",
            "Desenho Técnico",
            "Plano de Inspeção",
            "Instrução de Montagem",
            "Outros"});
            this.tIPODESPRODUTODataGridViewTextBoxColumn.Name = "tIPODESPRODUTODataGridViewTextBoxColumn";
            this.tIPODESPRODUTODataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tIPODESPRODUTODataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // cODPRODDESPRODUTODataGridViewTextBoxColumn
            // 
            this.cODPRODDESPRODUTODataGridViewTextBoxColumn.DataPropertyName = "COD_PROD_DES_PRODUTO";
            this.cODPRODDESPRODUTODataGridViewTextBoxColumn.HeaderText = "COD_PROD_DES_PRODUTO";
            this.cODPRODDESPRODUTODataGridViewTextBoxColumn.Name = "cODPRODDESPRODUTODataGridViewTextBoxColumn";
            this.cODPRODDESPRODUTODataGridViewTextBoxColumn.Visible = false;
            // 
            // dsDesenhos_produto
            // 
            this.dsDesenhos_produto.DataSetName = "dsDesenhos_produto";
            this.dsDesenhos_produto.Namespace = "http://www.tempuri.org/dsDesenhos_produto.xsd";
            this.dsDesenhos_produto.Tables.AddRange(new System.Data.DataTable[] {
            this.DESENHOS_PRODUTO});
            // 
            // DESENHOS_PRODUTO
            // 
            this.DESENHOS_PRODUTO.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_DES_PRODUTO,
            this.LINK_DES_PRODUTO,
            this.TIPO_DES_PRODUTO,
            this.COD_PROD_DES_PRODUTO});
            this.DESENHOS_PRODUTO.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_DES_PRODUTO"}, true)});
            this.DESENHOS_PRODUTO.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_DES_PRODUTO};
            this.DESENHOS_PRODUTO.TableName = "DESENHOS_PRODUTO";
            // 
            // COD_DES_PRODUTO
            // 
            this.COD_DES_PRODUTO.AllowDBNull = false;
            this.COD_DES_PRODUTO.ColumnName = "COD_DES_PRODUTO";
            this.COD_DES_PRODUTO.DataType = typeof(int);
            // 
            // LINK_DES_PRODUTO
            // 
            this.LINK_DES_PRODUTO.ColumnName = "LINK_DES_PRODUTO";
            this.LINK_DES_PRODUTO.MaxLength = 1000;
            // 
            // TIPO_DES_PRODUTO
            // 
            this.TIPO_DES_PRODUTO.ColumnName = "TIPO_DES_PRODUTO";
            this.TIPO_DES_PRODUTO.MaxLength = 100;
            // 
            // COD_PROD_DES_PRODUTO
            // 
            this.COD_PROD_DES_PRODUTO.ColumnName = "COD_PROD_DES_PRODUTO";
            this.COD_PROD_DES_PRODUTO.DataType = typeof(short);
            // 
            // textBox10
            // 
            this.textBox10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.ST_PRODUTO", true));
            this.textBox10.Location = new System.Drawing.Point(134, 7);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(72, 20);
            this.textBox10.TabIndex = 287;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(14, 10);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(76, 13);
            this.label48.TabIndex = 288;
            this.label48.Text = "ST ENTRADA";
            // 
            // cb_origem_mercadoria
            // 
            this.cb_origem_mercadoria.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.ORIGEM_PRODUTO", true));
            this.cb_origem_mercadoria.FormattingEnabled = true;
            this.cb_origem_mercadoria.Items.AddRange(new object[] {
            "0 - Nacional",
            "1 - Estrangeira - Importação direta",
            "2 - Estrangeira - Adquirida no mercado interno"});
            this.cb_origem_mercadoria.Location = new System.Drawing.Point(134, 59);
            this.cb_origem_mercadoria.Name = "cb_origem_mercadoria";
            this.cb_origem_mercadoria.Size = new System.Drawing.Size(131, 21);
            this.cb_origem_mercadoria.TabIndex = 286;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(14, 36);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(90, 13);
            this.label45.TabIndex = 284;
            this.label45.Text = "CFOP ENTRADA";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(14, 62);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(114, 13);
            this.label46.TabIndex = 285;
            this.label46.Text = "Origem da Mercadoria:";
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.CFOP_ENTRADA_PRODUTO", true));
            this.textBox5.Location = new System.Drawing.Point(134, 33);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(72, 20);
            this.textBox5.TabIndex = 283;
            // 
            // datItens_nota
            // 
            this.datItens_nota.DeleteCommand = this.fbCommand20;
            this.datItens_nota.InsertCommand = this.fbCommand18;
            this.datItens_nota.SelectCommand = this.fbCommand17;
            this.datItens_nota.UpdateCommand = this.fbCommand19;
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
            this.fbCommand17.CommandText = resources.GetString("fbCommand17.CommandText");
            this.fbCommand17.CommandTimeout = 30;
            this.fbCommand17.Connection = this.fbConnection1;
            // 
            // fbCommand19
            // 
            this.fbCommand19.CommandTimeout = 30;
            // 
            // datCpv
            // 
            this.datCpv.DeleteCommand = this.fbCommand24;
            this.datCpv.InsertCommand = this.fbCommand22;
            this.datCpv.SelectCommand = this.fbCommand21;
            this.datCpv.UpdateCommand = this.fbCommand23;
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
            this.fbCommand21.CommandText = "select * from COMISSAO_PRODUTO_VENDEDOR";
            this.fbCommand21.CommandTimeout = 30;
            this.fbCommand21.Connection = this.fbConnection1;
            // 
            // fbCommand23
            // 
            this.fbCommand23.CommandTimeout = 30;
            // 
            // cbCpv
            // 
            this.cbCpv.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbCpv.DataAdapter = this.datCpv;
            this.cbCpv.QuotePrefix = "\"";
            this.cbCpv.QuoteSuffix = "\"";
            // 
            // button28
            // 
            this.button28.Location = new System.Drawing.Point(694, 647);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(58, 59);
            this.button28.TabIndex = 285;
            this.button28.Text = "Etiqueta";
            this.button28.UseVisualStyleBackColor = true;
            this.button28.Click += new System.EventHandler(this.button28_Click);
            // 
            // datProdutos_kit
            // 
            this.datProdutos_kit.DeleteCommand = this.fbCommand28;
            this.datProdutos_kit.InsertCommand = this.fbCommand26;
            this.datProdutos_kit.SelectCommand = this.fbCommand25;
            this.datProdutos_kit.UpdateCommand = this.fbCommand27;
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
            this.fbCommand25.CommandText = "select * from produtos_kit";
            this.fbCommand25.CommandTimeout = 30;
            this.fbCommand25.Connection = this.fbConnection1;
            // 
            // fbCommand27
            // 
            this.fbCommand27.CommandTimeout = 30;
            // 
            // cbProdutos_kit
            // 
            this.cbProdutos_kit.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbProdutos_kit.DataAdapter = this.datProdutos_kit;
            this.cbProdutos_kit.QuotePrefix = "\"";
            this.cbProdutos_kit.QuoteSuffix = "\"";
            // 
            // datItens_produto
            // 
            this.datItens_produto.DeleteCommand = this.fbCommand32;
            this.datItens_produto.InsertCommand = this.fbCommand30;
            this.datItens_produto.SelectCommand = this.fbCommand29;
            this.datItens_produto.UpdateCommand = this.fbCommand31;
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
            this.fbCommand29.CommandText = "select * from itens_produto";
            this.fbCommand29.CommandTimeout = 30;
            this.fbCommand29.Connection = this.fbConnection1;
            // 
            // fbCommand31
            // 
            this.fbCommand31.CommandTimeout = 30;
            // 
            // cbItens_produto
            // 
            this.cbItens_produto.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbItens_produto.DataAdapter = this.datItens_produto;
            this.cbItens_produto.QuotePrefix = "\"";
            this.cbItens_produto.QuoteSuffix = "\"";
            // 
            // datDesenhos_produto
            // 
            this.datDesenhos_produto.DeleteCommand = this.fbCommand36;
            this.datDesenhos_produto.InsertCommand = this.fbCommand34;
            this.datDesenhos_produto.SelectCommand = this.fbCommand33;
            this.datDesenhos_produto.UpdateCommand = this.fbCommand35;
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
            this.fbCommand33.CommandText = "select * from desenhos_produto";
            this.fbCommand33.CommandTimeout = 30;
            this.fbCommand33.Connection = this.fbConnection1;
            // 
            // fbCommand35
            // 
            this.fbCommand35.CommandTimeout = 30;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cbDesenhos_produto
            // 
            this.cbDesenhos_produto.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbDesenhos_produto.DataAdapter = this.datDesenhos_produto;
            this.cbDesenhos_produto.QuotePrefix = "\"";
            this.cbDesenhos_produto.QuoteSuffix = "\"";
            // 
            // datItens_orcamentos
            // 
            this.datItens_orcamentos.DeleteCommand = this.fbCommand40;
            this.datItens_orcamentos.InsertCommand = this.fbCommand38;
            this.datItens_orcamentos.SelectCommand = this.fbCommand37;
            this.datItens_orcamentos.UpdateCommand = this.fbCommand39;
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
            this.fbCommand37.CommandText = "SELECT * FROM ITENS_ORCAMENTO";
            this.fbCommand37.CommandTimeout = 30;
            this.fbCommand37.Connection = this.fbConnection1;
            // 
            // fbCommand39
            // 
            this.fbCommand39.CommandTimeout = 30;
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
            this.HORAS_RET_PERFIL_ITEM_ORC,
            this.HORAS_RET_CILIN_ITEM_ORC,
            this.HORAS_EROSAO_PEN_ITEM_ORC,
            this.HORAS_TORNO_CONV_ITEM_ORC,
            this.HORAS_TORNO_CNC_ITEM_ORC,
            this.HORAS_EROSAO_FIO_ITEM_ORC,
            this.HORAS_CENTRO_USI_ITEM_ORC,
            this.HORAS_TRAT_TERM_ITEM_ORC,
            this.HORAS_ELETRODO_CONV_ITEM_ORC,
            this.HORAS_ELETRODO_HIGH_ITEM_ORC,
            this.HORAS_ELETRODO_FIO_ITEM_ORC,
            this.HORAS_HIGH_SPEED_ITEM_ORC,
            this.HORAS_BANCADA_ITEM_ORC,
            this.VALOR_TOTAL_ITEM_ORC,
            this.STATUS_ITEM_ORC,
            this.OBS_ITEM_ORC,
            this.COD_ORCAMENTO_ITEM_ORC,
            this.TOTAL_HORAS_ITEM_ORC,
            this.VALOR_UNIT_ITEM_ORC,
            this.VALOR_MAT_PRI_ITEM_ORC,
            this.PRAZO_ENTREGA_ITEM_ORC,
            this.HORAS_OPER1_ITEM_ORC,
            this.HORAS_OPER2_ITEM_ORC,
            this.HORAS_OPER3_ITEM_ORC,
            this.HORAS_OPER4_ITEM_ORC,
            this.HORAS_OPER5_ITEM_ORC,
            this.HORAS_OPER6_ITEM_ORC,
            this.HORAS_OPER7_ITEM_ORC,
            this.HORAS_OPER8_ITEM_ORC,
            this.HORAS_OPER9_ITEM_ORC,
            this.HORAS_OPER10_ITEM_ORC,
            this.HORAS_OPER11_ITEM_ORC,
            this.HORAS_OPER12_ITEM_ORC,
            this.HORAS_OPER13_ITEM_ORC,
            this.HORAS_OPER14_ITEM_ORC,
            this.COD_ITEM_ITEM_ORC,
            this.HORAS_OPER15_ITEM_ORC,
            this.HORAS_OPER16_ITEM_ORC,
            this.HORAS_OPER17_ITEM_ORC,
            this.HORAS_OPER18_ITEM_ORC,
            this.HORAS_OPER19_ITEM_ORC,
            this.HORAS_OPER20_ITEM_ORC,
            this.HORAS_OPER21_ITEM_ORC,
            this.HORAS_OPER22_ITEM_ORC,
            this.MATERIAL_ITEM_ORC,
            this.KG_PC_ITEM_ORC,
            this.VALOR_MATERIAL_ITEM_ORC,
            this.V_TOTAL_COM_IMPOSTO_ITEM_ORC,
            this.V_UNIT_COM_IMPOSTO_ITEM_ORC,
            this.QTDE_LIBERADA_ITEM_ORC});
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
            // HORAS_RET_PERFIL_ITEM_ORC
            // 
            this.HORAS_RET_PERFIL_ITEM_ORC.ColumnName = "HORAS_RET_PERFIL_ITEM_ORC";
            this.HORAS_RET_PERFIL_ITEM_ORC.DataType = typeof(double);
            // 
            // HORAS_RET_CILIN_ITEM_ORC
            // 
            this.HORAS_RET_CILIN_ITEM_ORC.ColumnName = "HORAS_RET_CILIN_ITEM_ORC";
            this.HORAS_RET_CILIN_ITEM_ORC.DataType = typeof(double);
            // 
            // HORAS_EROSAO_PEN_ITEM_ORC
            // 
            this.HORAS_EROSAO_PEN_ITEM_ORC.ColumnName = "HORAS_EROSAO_PEN_ITEM_ORC";
            this.HORAS_EROSAO_PEN_ITEM_ORC.DataType = typeof(double);
            // 
            // HORAS_TORNO_CONV_ITEM_ORC
            // 
            this.HORAS_TORNO_CONV_ITEM_ORC.ColumnName = "HORAS_TORNO_CONV_ITEM_ORC";
            this.HORAS_TORNO_CONV_ITEM_ORC.DataType = typeof(double);
            // 
            // HORAS_TORNO_CNC_ITEM_ORC
            // 
            this.HORAS_TORNO_CNC_ITEM_ORC.ColumnName = "HORAS_TORNO_CNC_ITEM_ORC";
            this.HORAS_TORNO_CNC_ITEM_ORC.DataType = typeof(double);
            // 
            // HORAS_EROSAO_FIO_ITEM_ORC
            // 
            this.HORAS_EROSAO_FIO_ITEM_ORC.ColumnName = "HORAS_EROSAO_FIO_ITEM_ORC";
            this.HORAS_EROSAO_FIO_ITEM_ORC.DataType = typeof(double);
            // 
            // HORAS_CENTRO_USI_ITEM_ORC
            // 
            this.HORAS_CENTRO_USI_ITEM_ORC.ColumnName = "HORAS_CENTRO_USI_ITEM_ORC";
            this.HORAS_CENTRO_USI_ITEM_ORC.DataType = typeof(double);
            // 
            // HORAS_TRAT_TERM_ITEM_ORC
            // 
            this.HORAS_TRAT_TERM_ITEM_ORC.ColumnName = "HORAS_TRAT_TERM_ITEM_ORC";
            this.HORAS_TRAT_TERM_ITEM_ORC.DataType = typeof(double);
            // 
            // HORAS_ELETRODO_CONV_ITEM_ORC
            // 
            this.HORAS_ELETRODO_CONV_ITEM_ORC.ColumnName = "HORAS_ELETRODO_CONV_ITEM_ORC";
            this.HORAS_ELETRODO_CONV_ITEM_ORC.DataType = typeof(double);
            // 
            // HORAS_ELETRODO_HIGH_ITEM_ORC
            // 
            this.HORAS_ELETRODO_HIGH_ITEM_ORC.ColumnName = "HORAS_ELETRODO_HIGH_ITEM_ORC";
            this.HORAS_ELETRODO_HIGH_ITEM_ORC.DataType = typeof(double);
            // 
            // HORAS_ELETRODO_FIO_ITEM_ORC
            // 
            this.HORAS_ELETRODO_FIO_ITEM_ORC.ColumnName = "HORAS_ELETRODO_FIO_ITEM_ORC";
            this.HORAS_ELETRODO_FIO_ITEM_ORC.DataType = typeof(double);
            // 
            // HORAS_HIGH_SPEED_ITEM_ORC
            // 
            this.HORAS_HIGH_SPEED_ITEM_ORC.ColumnName = "HORAS_HIGH_SPEED_ITEM_ORC";
            this.HORAS_HIGH_SPEED_ITEM_ORC.DataType = typeof(double);
            // 
            // HORAS_BANCADA_ITEM_ORC
            // 
            this.HORAS_BANCADA_ITEM_ORC.ColumnName = "HORAS_BANCADA_ITEM_ORC";
            this.HORAS_BANCADA_ITEM_ORC.DataType = typeof(double);
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
            // PRAZO_ENTREGA_ITEM_ORC
            // 
            this.PRAZO_ENTREGA_ITEM_ORC.ColumnName = "PRAZO_ENTREGA_ITEM_ORC";
            this.PRAZO_ENTREGA_ITEM_ORC.MaxLength = 20;
            // 
            // HORAS_OPER1_ITEM_ORC
            // 
            this.HORAS_OPER1_ITEM_ORC.ColumnName = "HORAS_OPER1_ITEM_ORC";
            this.HORAS_OPER1_ITEM_ORC.DataType = typeof(double);
            // 
            // HORAS_OPER2_ITEM_ORC
            // 
            this.HORAS_OPER2_ITEM_ORC.ColumnName = "HORAS_OPER2_ITEM_ORC";
            this.HORAS_OPER2_ITEM_ORC.DataType = typeof(double);
            // 
            // HORAS_OPER3_ITEM_ORC
            // 
            this.HORAS_OPER3_ITEM_ORC.ColumnName = "HORAS_OPER3_ITEM_ORC";
            this.HORAS_OPER3_ITEM_ORC.DataType = typeof(double);
            // 
            // HORAS_OPER4_ITEM_ORC
            // 
            this.HORAS_OPER4_ITEM_ORC.ColumnName = "HORAS_OPER4_ITEM_ORC";
            this.HORAS_OPER4_ITEM_ORC.DataType = typeof(double);
            // 
            // HORAS_OPER5_ITEM_ORC
            // 
            this.HORAS_OPER5_ITEM_ORC.ColumnName = "HORAS_OPER5_ITEM_ORC";
            this.HORAS_OPER5_ITEM_ORC.DataType = typeof(double);
            // 
            // HORAS_OPER6_ITEM_ORC
            // 
            this.HORAS_OPER6_ITEM_ORC.ColumnName = "HORAS_OPER6_ITEM_ORC";
            this.HORAS_OPER6_ITEM_ORC.DataType = typeof(double);
            // 
            // HORAS_OPER7_ITEM_ORC
            // 
            this.HORAS_OPER7_ITEM_ORC.ColumnName = "HORAS_OPER7_ITEM_ORC";
            this.HORAS_OPER7_ITEM_ORC.DataType = typeof(double);
            // 
            // HORAS_OPER8_ITEM_ORC
            // 
            this.HORAS_OPER8_ITEM_ORC.ColumnName = "HORAS_OPER8_ITEM_ORC";
            this.HORAS_OPER8_ITEM_ORC.DataType = typeof(double);
            // 
            // HORAS_OPER9_ITEM_ORC
            // 
            this.HORAS_OPER9_ITEM_ORC.ColumnName = "HORAS_OPER9_ITEM_ORC";
            this.HORAS_OPER9_ITEM_ORC.DataType = typeof(double);
            // 
            // HORAS_OPER10_ITEM_ORC
            // 
            this.HORAS_OPER10_ITEM_ORC.ColumnName = "HORAS_OPER10_ITEM_ORC";
            this.HORAS_OPER10_ITEM_ORC.DataType = typeof(double);
            // 
            // HORAS_OPER11_ITEM_ORC
            // 
            this.HORAS_OPER11_ITEM_ORC.ColumnName = "HORAS_OPER11_ITEM_ORC";
            this.HORAS_OPER11_ITEM_ORC.DataType = typeof(double);
            // 
            // HORAS_OPER12_ITEM_ORC
            // 
            this.HORAS_OPER12_ITEM_ORC.ColumnName = "HORAS_OPER12_ITEM_ORC";
            this.HORAS_OPER12_ITEM_ORC.DataType = typeof(double);
            // 
            // HORAS_OPER13_ITEM_ORC
            // 
            this.HORAS_OPER13_ITEM_ORC.ColumnName = "HORAS_OPER13_ITEM_ORC";
            this.HORAS_OPER13_ITEM_ORC.DataType = typeof(double);
            // 
            // HORAS_OPER14_ITEM_ORC
            // 
            this.HORAS_OPER14_ITEM_ORC.ColumnName = "HORAS_OPER14_ITEM_ORC";
            this.HORAS_OPER14_ITEM_ORC.DataType = typeof(double);
            // 
            // COD_ITEM_ITEM_ORC
            // 
            this.COD_ITEM_ITEM_ORC.ColumnName = "COD_ITEM_ITEM_ORC";
            this.COD_ITEM_ITEM_ORC.MaxLength = 50;
            // 
            // HORAS_OPER15_ITEM_ORC
            // 
            this.HORAS_OPER15_ITEM_ORC.ColumnName = "HORAS_OPER15_ITEM_ORC";
            this.HORAS_OPER15_ITEM_ORC.DataType = typeof(double);
            // 
            // HORAS_OPER16_ITEM_ORC
            // 
            this.HORAS_OPER16_ITEM_ORC.ColumnName = "HORAS_OPER16_ITEM_ORC";
            this.HORAS_OPER16_ITEM_ORC.DataType = typeof(double);
            // 
            // HORAS_OPER17_ITEM_ORC
            // 
            this.HORAS_OPER17_ITEM_ORC.ColumnName = "HORAS_OPER17_ITEM_ORC";
            this.HORAS_OPER17_ITEM_ORC.DataType = typeof(double);
            // 
            // HORAS_OPER18_ITEM_ORC
            // 
            this.HORAS_OPER18_ITEM_ORC.ColumnName = "HORAS_OPER18_ITEM_ORC";
            this.HORAS_OPER18_ITEM_ORC.DataType = typeof(double);
            // 
            // HORAS_OPER19_ITEM_ORC
            // 
            this.HORAS_OPER19_ITEM_ORC.ColumnName = "HORAS_OPER19_ITEM_ORC";
            this.HORAS_OPER19_ITEM_ORC.DataType = typeof(double);
            // 
            // HORAS_OPER20_ITEM_ORC
            // 
            this.HORAS_OPER20_ITEM_ORC.ColumnName = "HORAS_OPER20_ITEM_ORC";
            this.HORAS_OPER20_ITEM_ORC.DataType = typeof(double);
            // 
            // HORAS_OPER21_ITEM_ORC
            // 
            this.HORAS_OPER21_ITEM_ORC.ColumnName = "HORAS_OPER21_ITEM_ORC";
            this.HORAS_OPER21_ITEM_ORC.DataType = typeof(double);
            // 
            // HORAS_OPER22_ITEM_ORC
            // 
            this.HORAS_OPER22_ITEM_ORC.ColumnName = "HORAS_OPER22_ITEM_ORC";
            this.HORAS_OPER22_ITEM_ORC.DataType = typeof(double);
            // 
            // MATERIAL_ITEM_ORC
            // 
            this.MATERIAL_ITEM_ORC.ColumnName = "MATERIAL_ITEM_ORC";
            this.MATERIAL_ITEM_ORC.MaxLength = 200;
            // 
            // KG_PC_ITEM_ORC
            // 
            this.KG_PC_ITEM_ORC.ColumnName = "KG_PC_ITEM_ORC";
            this.KG_PC_ITEM_ORC.DataType = typeof(double);
            // 
            // VALOR_MATERIAL_ITEM_ORC
            // 
            this.VALOR_MATERIAL_ITEM_ORC.ColumnName = "VALOR_MATERIAL_ITEM_ORC";
            this.VALOR_MATERIAL_ITEM_ORC.DataType = typeof(double);
            // 
            // V_TOTAL_COM_IMPOSTO_ITEM_ORC
            // 
            this.V_TOTAL_COM_IMPOSTO_ITEM_ORC.ColumnName = "V_TOTAL_COM_IMPOSTO_ITEM_ORC";
            this.V_TOTAL_COM_IMPOSTO_ITEM_ORC.DataType = typeof(double);
            // 
            // V_UNIT_COM_IMPOSTO_ITEM_ORC
            // 
            this.V_UNIT_COM_IMPOSTO_ITEM_ORC.ColumnName = "V_UNIT_COM_IMPOSTO_ITEM_ORC";
            this.V_UNIT_COM_IMPOSTO_ITEM_ORC.DataType = typeof(double);
            // 
            // QTDE_LIBERADA_ITEM_ORC
            // 
            this.QTDE_LIBERADA_ITEM_ORC.ColumnName = "QTDE_LIBERADA_ITEM_ORC";
            this.QTDE_LIBERADA_ITEM_ORC.DataType = typeof(double);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsProdutos, "PRODUTOS.RATEIO_PRODUTO", true));
            this.checkBox6.Location = new System.Drawing.Point(466, 11);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(57, 17);
            this.checkBox6.TabIndex = 286;
            this.checkBox6.Text = "Rateio";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // textBox36
            // 
            this.textBox36.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.PORC_RATEIO_PRODUTO", true));
            this.textBox36.Location = new System.Drawing.Point(457, 41);
            this.textBox36.Name = "textBox36";
            this.textBox36.Size = new System.Drawing.Size(66, 20);
            this.textBox36.TabIndex = 287;
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.Location = new System.Drawing.Point(372, 44);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(52, 13);
            this.label90.TabIndex = 288;
            this.label90.Text = "% Rateio:";
            // 
            // textBox43
            // 
            this.textBox43.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.COD_ALTERNATIVO_PRODUTO", true));
            this.textBox43.Location = new System.Drawing.Point(443, 250);
            this.textBox43.Name = "textBox43";
            this.textBox43.Size = new System.Drawing.Size(96, 20);
            this.textBox43.TabIndex = 289;
            // 
            // label91
            // 
            this.label91.AutoSize = true;
            this.label91.Location = new System.Drawing.Point(327, 253);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(82, 13);
            this.label91.TabIndex = 290;
            this.label91.Text = "Cod Alternativo:";
            // 
            // tabPage10
            // 
            this.tabPage10.Controls.Add(this.panel8);
            this.tabPage10.Location = new System.Drawing.Point(4, 22);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10.Size = new System.Drawing.Size(963, 296);
            this.tabPage10.TabIndex = 10;
            this.tabPage10.Text = "Reforma Trib";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // dataColumn66
            // 
            this.dataColumn66.ColumnName = "CST_IBSCBS_PRODUTO";
            // 
            // dataColumn67
            // 
            this.dataColumn67.ColumnName = "CCLASSTRIB_PRODUTO";
            // 
            // dataColumn68
            // 
            this.dataColumn68.ColumnName = "ALIQ_IBS_PRODUTO";
            this.dataColumn68.DataType = typeof(double);
            // 
            // dataColumn69
            // 
            this.dataColumn69.ColumnName = "ALIQ_CBS_PRODUTO";
            this.dataColumn69.DataType = typeof(double);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.SpringGreen;
            this.panel8.Controls.Add(this.textBox54);
            this.panel8.Controls.Add(this.label92);
            this.panel8.Controls.Add(this.textBox55);
            this.panel8.Controls.Add(this.label93);
            this.panel8.Controls.Add(this.textBox56);
            this.panel8.Controls.Add(this.label94);
            this.panel8.Controls.Add(this.textBox57);
            this.panel8.Controls.Add(this.label96);
            this.panel8.Location = new System.Drawing.Point(367, 53);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(229, 191);
            this.panel8.TabIndex = 3;
            // 
            // textBox54
            // 
            this.textBox54.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.ALIQ_CBS_PRODUTO", true));
            this.textBox54.Location = new System.Drawing.Point(123, 130);
            this.textBox54.Name = "textBox54";
            this.textBox54.Size = new System.Drawing.Size(74, 20);
            this.textBox54.TabIndex = 115;
            // 
            // label92
            // 
            this.label92.AutoSize = true;
            this.label92.Location = new System.Drawing.Point(27, 133);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(72, 13);
            this.label92.TabIndex = 114;
            this.label92.Text = "Aliquota CBS:";
            // 
            // textBox55
            // 
            this.textBox55.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.ALIQ_IBS_PRODUTO", true));
            this.textBox55.Location = new System.Drawing.Point(123, 104);
            this.textBox55.Name = "textBox55";
            this.textBox55.Size = new System.Drawing.Size(74, 20);
            this.textBox55.TabIndex = 113;
            // 
            // label93
            // 
            this.label93.AutoSize = true;
            this.label93.Location = new System.Drawing.Point(27, 107);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(68, 13);
            this.label93.TabIndex = 112;
            this.label93.Text = "Aliquota IBS:";
            // 
            // textBox56
            // 
            this.textBox56.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.CCLASSTRIB_PRODUTO", true));
            this.textBox56.Location = new System.Drawing.Point(123, 78);
            this.textBox56.Name = "textBox56";
            this.textBox56.Size = new System.Drawing.Size(74, 20);
            this.textBox56.TabIndex = 111;
            // 
            // label94
            // 
            this.label94.AutoSize = true;
            this.label94.Location = new System.Drawing.Point(27, 81);
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(72, 13);
            this.label94.TabIndex = 110;
            this.label94.Text = "Classificação:";
            // 
            // textBox57
            // 
            this.textBox57.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.CST_IBSCBS_PRODUTO", true));
            this.textBox57.Location = new System.Drawing.Point(123, 52);
            this.textBox57.Name = "textBox57";
            this.textBox57.Size = new System.Drawing.Size(74, 20);
            this.textBox57.TabIndex = 109;
            // 
            // label96
            // 
            this.label96.AutoSize = true;
            this.label96.Location = new System.Drawing.Point(27, 55);
            this.label96.Name = "label96";
            this.label96.Size = new System.Drawing.Size(31, 13);
            this.label96.TabIndex = 108;
            this.label96.Text = "CST:";
            // 
            // form_produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 720);
            this.Controls.Add(this.textBox43);
            this.Controls.Add(this.label91);
            this.Controls.Add(this.textBox36);
            this.Controls.Add(this.label90);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.button28);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label47);
            this.Controls.Add(this.txtCodAlternativo);
            this.Controls.Add(this.label44);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.bt_localizar);
            this.Controls.Add(this.bt_excluir);
            this.Controls.Add(this.bt_salvar);
            this.Controls.Add(this.bt_novo);
            this.Controls.Add(this.tb_descricao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tb_cod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label20);
            this.Name = "form_produto";
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.form_produto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PRODUTOS)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsItens_nf_entrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITENS_NOTA_ENT)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens_nota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsItens_nota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITENS_NOTA)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComissao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCpv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.COMISSAO_PRODUTO_VENDEDOR)).EndInit();
            this.tabPage7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProdutos_kit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PRODUTOS_KIT)).EndInit();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens_produto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsItens_produto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITENS_PRODUTO)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEtiquetas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PRODUCAO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ESTOQUE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RESERVA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SAIDA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReserva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).EndInit();
            this.tabPage9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDesenhos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDesenhos_produto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DESENHOS_PRODUTO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsItens_orcamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITENS_ORCAMENTO)).EndInit();
            this.tabPage10.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datProdutos;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tb_cod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_cod_grupo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_grupo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tb_sub_grupo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_cod_sub_grupo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox textBox24;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox textBox33;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox textBox34;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox tb_descricao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bt_localizar;
        private System.Windows.Forms.Button bt_excluir;
        private System.Windows.Forms.Button bt_salvar;
        private System.Windows.Forms.Button bt_novo;
        private System.Data.DataSet dsProdutos;
        private System.Data.DataTable PRODUTOS;
        private System.Data.DataColumn COD_PRODUTO;
        private System.Data.DataColumn COD_GRUPO_PRODUTO;
        private System.Data.DataColumn DESCRICAO_GRUPO_PRODUTO;
        private System.Data.DataColumn COD_SUB_GRUPO_PRODUTO;
        private System.Data.DataColumn DESCRICAO_SUB_GRUPO_PRODUTO;
        private System.Data.DataColumn DESCRICAO_PRODUTO;
        private System.Data.DataColumn CARACT_ADIC_PRODUTO;
        private System.Data.DataColumn COD_BARRAS_PRODUTO;
        private System.Data.DataColumn COD_ONU_PRODUTO;
        private System.Data.DataColumn CLASSE_TOXIC_PRODUTO;
        private System.Data.DataColumn COD_UNIDADE_PRODUTO;
        private System.Data.DataColumn DESCRICAO_UNIDADE_PRODUTO;
        private System.Data.DataColumn META_ANUAL_PRODUTO;
        private System.Data.DataColumn COD_REDUZIDO_PRODUTO;
        private System.Data.DataColumn TAB_PRODUTO;
        private System.Data.DataColumn META_SEMESTRAL_PRODUTO;
        private System.Data.DataColumn ESTOQUE_ATUAL_PRODUTO;
        private System.Data.DataColumn ESTOQUE_RESERVADO_PRODUTO;
        private System.Data.DataColumn ESTOQUE_MINIMO_PRODUTO;
        private System.Data.DataColumn ESTOQUE_ENCOMENDADO_PRODUTO;
        private System.Data.DataColumn ESTOQUE_MAXIMO_PRODUTO;
        private System.Data.DataColumn ESTOQUE_MEDIO_PRODUTO;
        private System.Data.DataColumn CUSTO_PRODUTO;
        private System.Data.DataColumn CUSTO_MED_PRODUTO;
        private System.Data.DataColumn VALOR_VENDA_PRODUTOR_PRODUTO;
        private System.Data.DataColumn VALOR_VENDA_REVEND_PRODUTO;
        private System.Data.DataColumn VALOR_PROMOCAO_PRODUTO;
        private System.Data.DataColumn OUTRO_VALOR_PRODUTO;
        private System.Data.DataColumn LUCRO_PRODUTO;
        private System.Data.DataColumn ULT_REAJ_PRODUTO;
        private System.Data.DataColumn PROD_RECEITA_PRODUTO;
        private System.Data.DataColumn STATUS_PRODUTO;
        private System.Data.DataColumn ICMS_S_N_PRODUTO;
        private System.Data.DataColumn ALIQUOTA_ICMS_PRODUTO;
        private System.Data.DataColumn REDUCAO_FORA_PRODUTO;
        private System.Data.DataColumn ALIQUOTA_IPI_PRODUTO;
        private System.Data.DataColumn PIS_PRODUTO;
        private System.Data.DataColumn COFINS_PRODUTO;
        private System.Data.DataColumn COMISSAO_PRODUTO;
        private System.Data.DataColumn COD_MARCA_PRODUTO;
        private System.Data.DataColumn MARCA_PRODUTO;
        private System.Data.DataColumn IVA_PRODUTO;
        private System.Data.DataColumn NCM_PRODUTO;
        private System.Data.DataColumn DESCRICAO_ITEM_PRODUTO;
        private System.Data.DataColumn COD_FORNECEDOR_PRODUTO;
        private System.Data.DataColumn CFOP_ENTRADA_PRODUTO;
        private System.Data.DataColumn ORIGEM_PRODUTO;
        private System.Data.DataColumn LOCALIZACAO_PRODUTO;
        private System.Data.DataColumn ST_PRODUTO;
        private System.Data.DataColumn ICMS_FORA_S_N_PRODUTO;
        private System.Data.DataColumn ALIQUOTA_FORA_ICMS_PRODUTO;
        private System.Data.DataColumn REDUCAO_ICMS_PRODUTO;
        private System.Data.DataColumn IVA_FORA_PRODUTO;
        private System.Data.DataColumn ALIQUOTA_ICMS_ST_PRODUTO;
        private System.Data.DataColumn ALIQUOTA_ICMS_ST_FORA_PRODUTO;
        private System.Data.DataColumn ST_SAIDA_PRODUTO; 
        private System.Data.DataColumn ST_SAIDA_FORA_PRODUTO;
        private System.Data.DataColumn MOD_BC_PRODUTO;
        private System.Data.DataColumn IPI_PRODUTO;
        private System.Data.DataColumn ICMS_PRODUTO;
        private System.Data.DataColumn ISS_PRODUTO;
        private System.Data.DataColumn PRESTACAO_SERVICO_PRODUTO;
        private System.Data.DataColumn REDUCAO_PRODUTO;
        private System.Data.DataColumn MOD_BC_ST_PRODUTO;
        private System.Data.DataColumn REDUCAO_ST_PRODUTO;
        private System.Data.DataColumn IPI_TRIB_PRODUTO;
        private System.Data.DataColumn IPI_N_TRIB_PRODUTO;
        private System.Data.DataColumn CST_IPI_TRIB_PRODUTO;
        private System.Data.DataColumn CST_IPI_N_TRIB_PRODUTO;
        private System.Data.DataColumn TIPO_PIS_PRODUTO;
        private System.Data.DataColumn CST_PIS_PRODUTO;
        private System.Data.DataColumn TIPO_COFINS_PRODUTO;
        private System.Data.DataColumn CST_COFINS_PRODUTO;
        private System.Data.DataColumn TIPO_SERVICO_PRODUTO;
        private System.Data.DataColumn BC_COM_IPI_PRODUTO;
        private System.Data.DataColumn REDUCAO_ST_FORA_PRODUTO;
        private System.Data.DataColumn UNIDADE_PRODUTO;
        private System.Data.DataColumn CNPJ_FORNECEDOR_PRODUTO;
        private System.Data.DataColumn NOME_FORNECEDOR_PRODUTO;
        private System.Data.DataColumn DESCONTO_MAXIMO_PRODUTO;
        private System.Data.DataColumn QTDE_UNIDADE_PRODUTO;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand5;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand6;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand7;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand8;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbProdutos;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand12;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand10;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand9;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand11;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datItens_nf_entrada;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand16;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand14;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand13;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand15;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbItens_ped_venda;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbItens_nf_entrada;
        private System.Windows.Forms.Button button11;
        private System.Data.DataColumn dataColumn1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label38;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Data.DataColumn dataColumn7;
        private System.Windows.Forms.TextBox txtCodAlternativo;
        private System.Windows.Forms.Label label44;
        private System.Data.DataColumn dataColumn8;
        private System.Data.DataColumn dataColumn9;
        private System.Data.DataColumn dataColumn10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label47;
        private System.Data.DataColumn dataColumn11;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.TextBox textBox35;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.TextBox textBox40;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.TextBox textBox42;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox textBox37;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox textBox38;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox textBox39;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox41;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.TextBox textBox31;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox tb_lucro_produto;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox25;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox tb_minimo;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox tb_venda;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox textBox28;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox textBox29;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox tb_custo;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_estoque_medio;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tb_estoque_atual;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox txtCodBarrasUnit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_unidade;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_cod_unidade;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Data.DataColumn dataColumn12;
        private System.Data.DataColumn dataColumn13;
        private System.Data.DataColumn dataColumn14;
        private System.Data.DataColumn dataColumn15;
        private System.Data.DataColumn dataColumn16;
        private System.Data.DataColumn dataColumn17;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.ComboBox cb_origem_mercadoria;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.TextBox textBox5;
        private System.Data.DataColumn dataColumn18;
        private System.Data.DataColumn dataColumn19;
        private System.Windows.Forms.TextBox textBox44;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.TextBox textBox45;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.TextBox textBox46;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.TextBox textBox47;
        private System.Windows.Forms.Label label60;
        private System.Data.DataColumn dataColumn20;
        private System.Data.DataColumn dataColumn21;
        private System.Windows.Forms.Button btnSelecionarFornecedor;
        private System.Windows.Forms.TextBox txtNomeFornecedor;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.TextBox txtCnpjFornecedor;
        private System.Windows.Forms.Label label62;
        private System.Data.DataColumn dataColumn22;
        private System.Data.DataColumn dataColumn23;
        private System.Data.DataColumn dataColumn24;
        private System.Data.DataColumn dataColumn25;
        private System.Windows.Forms.TextBox txtDescontoMaximo;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.TextBox tb_qtde_caixa;
        private System.Data.DataColumn dataColumn26;
        private System.Data.DataColumn dataColumn27;
        private System.Windows.Forms.TextBox txtCodBarrasCaixa;
        private System.Windows.Forms.Label label10;
        private System.Data.DataColumn dataColumn28;
        private System.Windows.Forms.DataGridViewTextBoxColumn nFITEMENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uNIDADEITEMENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qTDEITEMENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Data.DataSet dsItens_nf_entrada;
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
        private System.Data.DataColumn LOTE_ITEM_ENT;
        private System.Data.DataColumn QTDE_LOTE_ITEM_ENT;
        private System.Data.DataColumn NOME_PROPRIETARIO_ITEM_ENT;
        private System.Data.DataColumn CNPJ_PROPRIETARIO_ITEM;
        private System.Data.DataColumn BAIXADO_ITEM_ENT;
        private System.Data.DataColumn MATERIA_PRIMA_ITEM_ENT;
        private System.Data.DataColumn ALMOXARIFADO_ITEM_ENT;
        private System.Data.DataColumn COD_EAN_ITEM_ENT;
        private System.Windows.Forms.DataGridView dgvItens_nota;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datItens_nota;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand20;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand18;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand17;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAEMISSAONFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nNFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qTDEITEMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uNIDADEITEMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nPEDIDONFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTEFORNNFDataGridViewTextBoxColumn;
        private System.Data.DataSet dsItens_nota;
        private System.Data.DataTable ITENS_NOTA;
        private System.Data.DataColumn N_NF;
        private System.Data.DataColumn DATA_EMISSAO_NF;
        private System.Data.DataColumn CLIENTE_FORN_NF;
        private System.Data.DataColumn QTDE_ITEM;
        private System.Data.DataColumn UNIDADE_ITEM;
        private System.Data.DataColumn N_PEDIDO_NF;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Data.DataColumn dataColumn29;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.TextBox tb_familia;
        private System.Windows.Forms.Label label65;
        private System.Data.DataColumn dataColumn30;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label66;
        private System.Data.DataColumn dataColumn31;
        private System.Windows.Forms.CheckBox cbPis_cofins;
        private System.Data.DataColumn dataColumn32;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.TextBox tb_coeficiente;
        private System.Windows.Forms.Label label67;
        private System.Data.DataColumn dataColumn33;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DataGridView dgvComissao;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.TextBox tb_comissao;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button btnInserirVendedor;
        private System.Windows.Forms.TextBox txtNomeVendedor;
        private System.Windows.Forms.TextBox txtCodVendedor;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.Label label69;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datCpv;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand24;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand22;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand21;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand23;
        private System.Data.DataSet dsCpv;
        private System.Data.DataTable COMISSAO_PRODUTO_VENDEDOR;
        private System.Data.DataColumn COD_CPV;
        private System.Data.DataColumn COD_VENDEDOR_CPV;
        private System.Data.DataColumn COD_PRODUTO_CPV;
        private System.Data.DataColumn PORC_COMISSAO_CPV;
        private System.Data.DataColumn NOME_VENDEDOR_CPV;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbCpv;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODCPVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODVENDEDORCPVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMEVENDEDORCPVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODPRODUTOCPVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pORCCOMISSAOCPVDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.TextBox tb_qtde_kit;
        private System.Windows.Forms.TextBox tb_item_item;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.TextBox tb_cod_item;
        private System.Data.DataColumn dataColumn34;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label73;
        private System.Data.DataColumn dataColumn35;
        private System.Windows.Forms.TextBox textBox26;
        private System.Windows.Forms.Label label75;
        private System.Data.DataColumn dataColumn36;
        private System.Data.DataColumn dataColumn37;
        private System.Data.DataColumn dataColumn38;
        private System.Data.DataColumn dataColumn39;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.ComboBox cb_cod_sit_trib_pis;
        private System.Data.DataColumn dataColumn40;
        private System.Windows.Forms.TextBox textBox27;
        private System.Windows.Forms.Label label80;
        private System.Data.DataColumn dataColumn41;
        private System.Windows.Forms.TextBox textBox30;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.DataGridView dgvProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_n_etiqueta_prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_op_prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn qTDEETIQUETADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_status_prod;
        private System.Data.DataSet dsEtiquetas;
        private System.Data.DataTable PRODUCAO;
        private System.Data.DataColumn dataColumn42;
        private System.Data.DataColumn dataColumn43;
        private System.Data.DataColumn dataColumn44;
        private System.Data.DataColumn dataColumn45;
        private System.Data.DataTable ESTOQUE;
        private System.Data.DataColumn dataColumn46;
        private System.Data.DataColumn dataColumn47;
        private System.Data.DataColumn dataColumn48;
        private System.Data.DataColumn dataColumn49;
        private System.Data.DataTable RESERVA;
        private System.Data.DataColumn dataColumn50;
        private System.Data.DataColumn dataColumn51;
        private System.Data.DataColumn dataColumn52;
        private System.Data.DataColumn dataColumn53;
        private System.Data.DataColumn dataColumn54;
        private System.Data.DataTable SAIDA;
        private System.Data.DataColumn dataColumn55;
        private System.Data.DataColumn dataColumn56;
        private System.Data.DataColumn dataColumn57;
        private System.Data.DataColumn dataColumn58;
        private System.Data.DataColumn dataColumn59;
        private System.Data.DataColumn dataColumn60;
        private System.Windows.Forms.DataGridView dgvSaidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn N_ETIQUETA_SAIDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn OP_ETIQUETA_SAIDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn qTDEETIQUETADataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPSAIDAETIQUETADataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nFSAIDAETIQUETADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTATUSETIQUETADataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridView dgvReserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn N_ETIQUETA_RESERVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn OP_ETIQUETA_RESERVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn qTDEETIQUETADataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPSAIDAETIQUETADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTATUSETIQUETADataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView dgvEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn N_ETIQUETA;
        private System.Windows.Forms.DataGridViewTextBoxColumn OP_ETIQUETA;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTDE_ETIQUETA;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTATUSETIQUETADataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label83;
        private System.Windows.Forms.DataGridView dgvKit;
        private System.Data.DataSet dsProdutos_kit;
        private System.Data.DataTable PRODUTOS_KIT;
        private System.Data.DataColumn COD_PK;
        private System.Data.DataColumn COD_PRODUTO_PK;
        private System.Data.DataColumn DESCRICAO_PK;
        private System.Data.DataColumn QTDE_PK;
        private System.Data.DataColumn VALOR_UNIT_PK;
        private System.Data.DataColumn COD_KIT_PK;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datProdutos_kit;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand28;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand26;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand25;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand27;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.Label label86;
        private System.Windows.Forms.TextBox tb_un_componente;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Label label84;
        private System.Windows.Forms.TextBox tb_cod_componente;
        private System.Windows.Forms.Label label85;
        private System.Windows.Forms.Label label87;
        private System.Windows.Forms.TextBox tb_qtde_componente;
        private System.Windows.Forms.TextBox tb_descricao_componente;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.DataGridView dgvItens_produto;
        private System.Data.DataSet dsItens_produto;
        private System.Data.DataTable ITENS_PRODUTO;
        private System.Data.DataColumn COD_IP;
        private System.Data.DataColumn COD_ESTOQUE_IP;
        private System.Data.DataColumn DESCRICAO_IP;
        private System.Data.DataColumn QTDE_IP;
        private System.Data.DataColumn COD_PRODUTO_IP;
        private System.Data.DataColumn UN_IP;
        private System.Data.DataColumn ITEM_IP;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbProdutos_kit;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datItens_produto;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand32;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand30;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand29;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand31;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbItens_produto;
        private System.Windows.Forms.Label label88;
        private System.Windows.Forms.TextBox tb_item;
        private System.Data.DataColumn dataColumn61;
        private System.Windows.Forms.TabPage tabPage9;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datDesenhos_produto;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand36;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand34;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand33;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand35;
        private System.Data.DataSet dsDesenhos_produto;
        private System.Data.DataTable DESENHOS_PRODUTO;
        private System.Data.DataColumn COD_DES_PRODUTO;
        private System.Data.DataColumn LINK_DES_PRODUTO;
        private System.Data.DataColumn TIPO_DES_PRODUTO;
        private System.Data.DataColumn COD_PROD_DES_PRODUTO;
        private System.Windows.Forms.DataGridView dgvDesenhos;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbDesenhos_produto;
        private System.Data.DataColumn dataColumn62;
        private System.Windows.Forms.TextBox textBox32;
        private System.Windows.Forms.Label label89;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod_pk;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_FORN;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRICAOPKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qTDEPKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORUNITPKDataGridViewTextBoxColumn;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datItens_orcamentos;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand40;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand38;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand37;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand39;
        private System.Data.DataSet dsItens_orcamento;
        private System.Data.DataTable ITENS_ORCAMENTO;
        private System.Data.DataColumn COD_ITEM_ORC;
        private System.Data.DataColumn NOME_ITEM_ORC;
        private System.Data.DataColumn QTDE_ITEM_ORC;
        private System.Data.DataColumn HORAS_FRESA_ITEM_ORC;
        private System.Data.DataColumn HORAS_RET_PERFIL_ITEM_ORC;
        private System.Data.DataColumn HORAS_RET_CILIN_ITEM_ORC;
        private System.Data.DataColumn HORAS_EROSAO_PEN_ITEM_ORC;
        private System.Data.DataColumn HORAS_TORNO_CONV_ITEM_ORC;
        private System.Data.DataColumn HORAS_TORNO_CNC_ITEM_ORC;
        private System.Data.DataColumn HORAS_EROSAO_FIO_ITEM_ORC;
        private System.Data.DataColumn HORAS_CENTRO_USI_ITEM_ORC;
        private System.Data.DataColumn HORAS_TRAT_TERM_ITEM_ORC;
        private System.Data.DataColumn HORAS_ELETRODO_CONV_ITEM_ORC;
        private System.Data.DataColumn HORAS_ELETRODO_HIGH_ITEM_ORC;
        private System.Data.DataColumn HORAS_ELETRODO_FIO_ITEM_ORC;
        private System.Data.DataColumn HORAS_HIGH_SPEED_ITEM_ORC;
        private System.Data.DataColumn HORAS_BANCADA_ITEM_ORC;
        private System.Data.DataColumn VALOR_TOTAL_ITEM_ORC;
        private System.Data.DataColumn STATUS_ITEM_ORC;
        private System.Data.DataColumn OBS_ITEM_ORC;
        private System.Data.DataColumn COD_ORCAMENTO_ITEM_ORC;
        private System.Data.DataColumn TOTAL_HORAS_ITEM_ORC;
        private System.Data.DataColumn VALOR_UNIT_ITEM_ORC;
        private System.Data.DataColumn VALOR_MAT_PRI_ITEM_ORC;
        private System.Data.DataColumn PRAZO_ENTREGA_ITEM_ORC;
        private System.Data.DataColumn HORAS_OPER1_ITEM_ORC;
        private System.Data.DataColumn HORAS_OPER2_ITEM_ORC;
        private System.Data.DataColumn HORAS_OPER3_ITEM_ORC;
        private System.Data.DataColumn HORAS_OPER4_ITEM_ORC;
        private System.Data.DataColumn HORAS_OPER5_ITEM_ORC;
        private System.Data.DataColumn HORAS_OPER6_ITEM_ORC;
        private System.Data.DataColumn HORAS_OPER7_ITEM_ORC;
        private System.Data.DataColumn HORAS_OPER8_ITEM_ORC;
        private System.Data.DataColumn HORAS_OPER9_ITEM_ORC;
        private System.Data.DataColumn HORAS_OPER10_ITEM_ORC;
        private System.Data.DataColumn HORAS_OPER11_ITEM_ORC;
        private System.Data.DataColumn HORAS_OPER12_ITEM_ORC;
        private System.Data.DataColumn HORAS_OPER13_ITEM_ORC;
        private System.Data.DataColumn HORAS_OPER14_ITEM_ORC;
        private System.Data.DataColumn COD_ITEM_ITEM_ORC;
        private System.Data.DataColumn HORAS_OPER15_ITEM_ORC;
        private System.Data.DataColumn HORAS_OPER16_ITEM_ORC;
        private System.Data.DataColumn HORAS_OPER17_ITEM_ORC;
        private System.Data.DataColumn HORAS_OPER18_ITEM_ORC;
        private System.Data.DataColumn HORAS_OPER19_ITEM_ORC;
        private System.Data.DataColumn HORAS_OPER20_ITEM_ORC;
        private System.Data.DataColumn HORAS_OPER21_ITEM_ORC;
        private System.Data.DataColumn HORAS_OPER22_ITEM_ORC;
        private System.Data.DataColumn MATERIAL_ITEM_ORC;
        private System.Data.DataColumn KG_PC_ITEM_ORC;
        private System.Data.DataColumn VALOR_MATERIAL_ITEM_ORC;
        private System.Data.DataColumn V_TOTAL_COM_IMPOSTO_ITEM_ORC;
        private System.Data.DataColumn V_UNIT_COM_IMPOSTO_ITEM_ORC;
        private System.Data.DataColumn QTDE_LIBERADA_ITEM_ORC;
        private System.Data.DataColumn dataColumn63;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODDESPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn col_abrir_desenho;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_link;
        private System.Windows.Forms.DataGridViewComboBoxColumn tIPODESPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODPRODDESPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODIPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODESTOQUEIPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRICAOIPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn qTDEIPDataGridViewTextBoxColumn;
        private System.Data.DataColumn dataColumn64;
        private System.Windows.Forms.TextBox textBox36;
        private System.Windows.Forms.Label label90;
        private System.Data.DataColumn dataColumn65;
        private System.Windows.Forms.TextBox textBox43;
        private System.Windows.Forms.Label label91;
        private System.Data.DataColumn dataColumn66;
        private System.Data.DataColumn dataColumn67;
        private System.Data.DataColumn dataColumn68;
        private System.Data.DataColumn dataColumn69;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox textBox54;
        private System.Windows.Forms.Label label92;
        private System.Windows.Forms.TextBox textBox55;
        private System.Windows.Forms.Label label93;
        private System.Windows.Forms.TextBox textBox56;
        private System.Windows.Forms.Label label94;
        private System.Windows.Forms.TextBox textBox57;
        private System.Windows.Forms.Label label96;
    }
}