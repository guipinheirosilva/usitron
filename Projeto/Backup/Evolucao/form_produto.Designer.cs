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
            this.STATUS_PRODUTO = new System.Data.DataColumn();
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
            this.datItens_ped_venda = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand12 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand10 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand9 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand11 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsItens_ped_venda = new System.Data.DataSet();
            this.ITENS_PEDIDO_VENDA = new System.Data.DataTable();
            this.COD_ITEM_VENDA = new System.Data.DataColumn();
            this.QTDE_ITEM_VENDA = new System.Data.DataColumn();
            this.COD_PROD_ITEM_VENDA = new System.Data.DataColumn();
            this.DESCRICAO_PROD_ITEM_VENDA = new System.Data.DataColumn();
            this.VALOR_UNIT_PROD_ITEM_VENDA = new System.Data.DataColumn();
            this.VALOR_TOTAL_PROD_ITEM_VENDA = new System.Data.DataColumn();
            this.UNIDADE_PROD_ITEM_VENDA = new System.Data.DataColumn();
            this.BC_ICMS_PROD_ITEM_VENDA = new System.Data.DataColumn();
            this.ALIQ_ICMS_PROD_ITEM_VENDA = new System.Data.DataColumn();
            this.VALOR_ICMS_ITEM_VENDA = new System.Data.DataColumn();
            this.BC_IPI_PROD_ITEM_VENDA = new System.Data.DataColumn();
            this.ALIQ_IPI_PROD_ITEM_VENDA = new System.Data.DataColumn();
            this.VALOR_IPI_ITEM_VENDA = new System.Data.DataColumn();
            this.NF_PROD_ITEM_VENDA = new System.Data.DataColumn();
            this.N_NF_PROD_ITEM_VENDA = new System.Data.DataColumn();
            this.OBS_ITEM_VENDA = new System.Data.DataColumn();
            this.COD_PEDIDO_ITEM_VENDA = new System.Data.DataColumn();
            this.dgvItens_nota = new System.Windows.Forms.DataGridView();
            this.col_cod_item_saida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ped = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRICAOPRODITEMVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uNIDADEPRODITEMVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_qtde_saida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORUNITPRODITEMVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_valor_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bCICMSPRODITEMVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aLIQICMSPRODITEMVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bCIPIPRODITEMVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aLIQIPIPRODITEMVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nFPRODITEMVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nNFPRODITEMVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oBSITEMVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datItens_nf_entrada = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand16 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand14 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand13 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand15 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsItens_nf_entrada = new System.Data.DataSet();
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
            this.MATERIAL_ITENS_NF_ENT = new System.Data.DataColumn();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.col_cod_item_entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cod_item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nf_entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_qtde_entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_valor_item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_itens_ped = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fORNITENSNFENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAENTITENSNFENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
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
            this.panel5 = new System.Windows.Forms.Panel();
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
            this.textBox41 = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.textBox31 = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.textBox32 = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.textBox29 = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.textBox30 = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.button3 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_unidade = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_cod_unidade = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBox36 = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label55 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.textBox43 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label48 = new System.Windows.Forms.Label();
            this.cb_origem_mercadoria = new System.Windows.Forms.ComboBox();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dsProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PRODUTOS)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsItens_ped_venda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITENS_PEDIDO_VENDA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens_nota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsItens_nf_entrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITENS_NF_ENTRADA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage4.SuspendLayout();
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
            this.tabPage5.SuspendLayout();
            this.panel6.SuspendLayout();
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
            this.tb_cod.Location = new System.Drawing.Point(112, 44);
            this.tb_cod.Name = "tb_cod";
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
            this.STATUS_PRODUTO,
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
            this.dataColumn23});
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
            this.COD_PRODUTO.DataType = typeof(int);
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
            // STATUS_PRODUTO
            // 
            this.STATUS_PRODUTO.ColumnName = "STATUS_PRODUTO";
            this.STATUS_PRODUTO.MaxLength = 10;
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
            this.dataColumn23.MaxLength = 20;
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
            this.tb_sub_grupo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.MARCA_PRODUTO", true));
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
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 123;
            this.label4.Text = "Marca";
            // 
            // tb_cod_sub_grupo
            // 
            this.tb_cod_sub_grupo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.COD_MARCA_PRODUTO", true));
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
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 121;
            this.label5.Text = "Cód. Marca:";
            // 
            // groupBox1
            // 
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
            this.groupBox1.Size = new System.Drawing.Size(476, 93);
            this.groupBox1.TabIndex = 131;
            this.groupBox1.TabStop = false;
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
            this.label61.Size = new System.Drawing.Size(64, 13);
            this.label61.TabIndex = 128;
            this.label61.Text = "Fornecedor:";
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
            this.label62.Size = new System.Drawing.Size(88, 13);
            this.label62.TabIndex = 126;
            this.label62.Text = "Cnpj Fornecedor:";
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
            this.checkBox1.Location = new System.Drawing.Point(202, 46);
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
            this.tb_descricao.Location = new System.Drawing.Point(140, 162);
            this.tb_descricao.Name = "tb_descricao";
            this.tb_descricao.Size = new System.Drawing.Size(401, 20);
            this.tb_descricao.TabIndex = 131;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 165);
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
            this.bt_localizar.Location = new System.Drawing.Point(765, 424);
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
            this.bt_excluir.Location = new System.Drawing.Point(693, 423);
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
            this.bt_salvar.Location = new System.Drawing.Point(555, 423);
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
            this.bt_novo.Location = new System.Drawing.Point(624, 423);
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
            // datItens_ped_venda
            // 
            this.datItens_ped_venda.DeleteCommand = this.fbCommand12;
            this.datItens_ped_venda.InsertCommand = this.fbCommand10;
            this.datItens_ped_venda.SelectCommand = this.fbCommand9;
            this.datItens_ped_venda.UpdateCommand = this.fbCommand11;
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
            // dsItens_ped_venda
            // 
            this.dsItens_ped_venda.DataSetName = "dsItens_ped_venda";
            this.dsItens_ped_venda.Namespace = "http://www.tempuri.org/dsItens_ped_venda.xsd";
            this.dsItens_ped_venda.Tables.AddRange(new System.Data.DataTable[] {
            this.ITENS_PEDIDO_VENDA});
            // 
            // ITENS_PEDIDO_VENDA
            // 
            this.ITENS_PEDIDO_VENDA.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_ITEM_VENDA,
            this.QTDE_ITEM_VENDA,
            this.COD_PROD_ITEM_VENDA,
            this.DESCRICAO_PROD_ITEM_VENDA,
            this.VALOR_UNIT_PROD_ITEM_VENDA,
            this.VALOR_TOTAL_PROD_ITEM_VENDA,
            this.UNIDADE_PROD_ITEM_VENDA,
            this.BC_ICMS_PROD_ITEM_VENDA,
            this.ALIQ_ICMS_PROD_ITEM_VENDA,
            this.VALOR_ICMS_ITEM_VENDA,
            this.BC_IPI_PROD_ITEM_VENDA,
            this.ALIQ_IPI_PROD_ITEM_VENDA,
            this.VALOR_IPI_ITEM_VENDA,
            this.NF_PROD_ITEM_VENDA,
            this.N_NF_PROD_ITEM_VENDA,
            this.OBS_ITEM_VENDA,
            this.COD_PEDIDO_ITEM_VENDA});
            this.ITENS_PEDIDO_VENDA.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_ITEM_VENDA"}, true)});
            this.ITENS_PEDIDO_VENDA.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_ITEM_VENDA};
            this.ITENS_PEDIDO_VENDA.TableName = "ITENS_PEDIDO_VENDA";
            // 
            // COD_ITEM_VENDA
            // 
            this.COD_ITEM_VENDA.AllowDBNull = false;
            this.COD_ITEM_VENDA.ColumnName = "COD_ITEM_VENDA";
            this.COD_ITEM_VENDA.DataType = typeof(int);
            // 
            // QTDE_ITEM_VENDA
            // 
            this.QTDE_ITEM_VENDA.ColumnName = "QTDE_ITEM_VENDA";
            this.QTDE_ITEM_VENDA.DataType = typeof(int);
            // 
            // COD_PROD_ITEM_VENDA
            // 
            this.COD_PROD_ITEM_VENDA.ColumnName = "COD_PROD_ITEM_VENDA";
            this.COD_PROD_ITEM_VENDA.MaxLength = 50;
            // 
            // DESCRICAO_PROD_ITEM_VENDA
            // 
            this.DESCRICAO_PROD_ITEM_VENDA.ColumnName = "DESCRICAO_PROD_ITEM_VENDA";
            this.DESCRICAO_PROD_ITEM_VENDA.MaxLength = 200;
            // 
            // VALOR_UNIT_PROD_ITEM_VENDA
            // 
            this.VALOR_UNIT_PROD_ITEM_VENDA.ColumnName = "VALOR_UNIT_PROD_ITEM_VENDA";
            this.VALOR_UNIT_PROD_ITEM_VENDA.DataType = typeof(double);
            // 
            // VALOR_TOTAL_PROD_ITEM_VENDA
            // 
            this.VALOR_TOTAL_PROD_ITEM_VENDA.ColumnName = "VALOR_TOTAL_PROD_ITEM_VENDA";
            this.VALOR_TOTAL_PROD_ITEM_VENDA.DataType = typeof(double);
            // 
            // UNIDADE_PROD_ITEM_VENDA
            // 
            this.UNIDADE_PROD_ITEM_VENDA.ColumnName = "UNIDADE_PROD_ITEM_VENDA";
            this.UNIDADE_PROD_ITEM_VENDA.MaxLength = 30;
            // 
            // BC_ICMS_PROD_ITEM_VENDA
            // 
            this.BC_ICMS_PROD_ITEM_VENDA.ColumnName = "BC_ICMS_PROD_ITEM_VENDA";
            this.BC_ICMS_PROD_ITEM_VENDA.DataType = typeof(double);
            // 
            // ALIQ_ICMS_PROD_ITEM_VENDA
            // 
            this.ALIQ_ICMS_PROD_ITEM_VENDA.ColumnName = "ALIQ_ICMS_PROD_ITEM_VENDA";
            this.ALIQ_ICMS_PROD_ITEM_VENDA.DataType = typeof(double);
            // 
            // VALOR_ICMS_ITEM_VENDA
            // 
            this.VALOR_ICMS_ITEM_VENDA.ColumnName = "VALOR_ICMS_ITEM_VENDA";
            this.VALOR_ICMS_ITEM_VENDA.DataType = typeof(double);
            // 
            // BC_IPI_PROD_ITEM_VENDA
            // 
            this.BC_IPI_PROD_ITEM_VENDA.ColumnName = "BC_IPI_PROD_ITEM_VENDA";
            this.BC_IPI_PROD_ITEM_VENDA.DataType = typeof(double);
            // 
            // ALIQ_IPI_PROD_ITEM_VENDA
            // 
            this.ALIQ_IPI_PROD_ITEM_VENDA.ColumnName = "ALIQ_IPI_PROD_ITEM_VENDA";
            this.ALIQ_IPI_PROD_ITEM_VENDA.DataType = typeof(double);
            // 
            // VALOR_IPI_ITEM_VENDA
            // 
            this.VALOR_IPI_ITEM_VENDA.ColumnName = "VALOR_IPI_ITEM_VENDA";
            this.VALOR_IPI_ITEM_VENDA.DataType = typeof(double);
            // 
            // NF_PROD_ITEM_VENDA
            // 
            this.NF_PROD_ITEM_VENDA.ColumnName = "NF_PROD_ITEM_VENDA";
            this.NF_PROD_ITEM_VENDA.DataType = typeof(int);
            // 
            // N_NF_PROD_ITEM_VENDA
            // 
            this.N_NF_PROD_ITEM_VENDA.ColumnName = "N_NF_PROD_ITEM_VENDA";
            this.N_NF_PROD_ITEM_VENDA.DataType = typeof(int);
            // 
            // OBS_ITEM_VENDA
            // 
            this.OBS_ITEM_VENDA.ColumnName = "OBS_ITEM_VENDA";
            this.OBS_ITEM_VENDA.MaxLength = 300;
            // 
            // COD_PEDIDO_ITEM_VENDA
            // 
            this.COD_PEDIDO_ITEM_VENDA.ColumnName = "COD_PEDIDO_ITEM_VENDA";
            this.COD_PEDIDO_ITEM_VENDA.DataType = typeof(int);
            // 
            // dgvItens_nota
            // 
            this.dgvItens_nota.AllowUserToAddRows = false;
            this.dgvItens_nota.AutoGenerateColumns = false;
            this.dgvItens_nota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens_nota.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_cod_item_saida,
            this.col_ped,
            this.col_cod,
            this.dESCRICAOPRODITEMVENDADataGridViewTextBoxColumn,
            this.uNIDADEPRODITEMVENDADataGridViewTextBoxColumn,
            this.col_qtde_saida,
            this.vALORUNITPRODITEMVENDADataGridViewTextBoxColumn,
            this.col_valor_total,
            this.bCICMSPRODITEMVENDADataGridViewTextBoxColumn,
            this.aLIQICMSPRODITEMVENDADataGridViewTextBoxColumn,
            this.bCIPIPRODITEMVENDADataGridViewTextBoxColumn,
            this.aLIQIPIPRODITEMVENDADataGridViewTextBoxColumn,
            this.nFPRODITEMVENDADataGridViewTextBoxColumn,
            this.nNFPRODITEMVENDADataGridViewTextBoxColumn,
            this.oBSITEMVENDADataGridViewTextBoxColumn});
            this.dgvItens_nota.DataMember = "ITENS_PEDIDO_VENDA";
            this.dgvItens_nota.DataSource = this.dsItens_ped_venda;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItens_nota.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItens_nota.Location = new System.Drawing.Point(14, 41);
            this.dgvItens_nota.Name = "dgvItens_nota";
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
            this.dgvItens_nota.Size = new System.Drawing.Size(184, 317);
            this.dgvItens_nota.TabIndex = 270;
            this.dgvItens_nota.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvItens_nota_CellMouseClick);
            this.dgvItens_nota.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItens_nota_CellClick);
            this.dgvItens_nota.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvItens_nota_CellMouseDoubleClick);
            this.dgvItens_nota.EditModeChanged += new System.EventHandler(this.dgvItens_nota_EditModeChanged);
            this.dgvItens_nota.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItens_nota_CellContentClick);
            // 
            // col_cod_item_saida
            // 
            this.col_cod_item_saida.DataPropertyName = "COD_ITEM_VENDA";
            this.col_cod_item_saida.HeaderText = "COD_ITEM_VENDA";
            this.col_cod_item_saida.Name = "col_cod_item_saida";
            this.col_cod_item_saida.Visible = false;
            // 
            // col_ped
            // 
            this.col_ped.DataPropertyName = "COD_PEDIDO_ITEM_VENDA";
            this.col_ped.HeaderText = "Ped";
            this.col_ped.Name = "col_ped";
            this.col_ped.Width = 30;
            // 
            // col_cod
            // 
            this.col_cod.DataPropertyName = "COD_PROD_ITEM_VENDA";
            this.col_cod.HeaderText = "Cód.";
            this.col_cod.Name = "col_cod";
            this.col_cod.Visible = false;
            this.col_cod.Width = 45;
            // 
            // dESCRICAOPRODITEMVENDADataGridViewTextBoxColumn
            // 
            this.dESCRICAOPRODITEMVENDADataGridViewTextBoxColumn.DataPropertyName = "DESCRICAO_PROD_ITEM_VENDA";
            this.dESCRICAOPRODITEMVENDADataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.dESCRICAOPRODITEMVENDADataGridViewTextBoxColumn.Name = "dESCRICAOPRODITEMVENDADataGridViewTextBoxColumn";
            this.dESCRICAOPRODITEMVENDADataGridViewTextBoxColumn.Visible = false;
            this.dESCRICAOPRODITEMVENDADataGridViewTextBoxColumn.Width = 210;
            // 
            // uNIDADEPRODITEMVENDADataGridViewTextBoxColumn
            // 
            this.uNIDADEPRODITEMVENDADataGridViewTextBoxColumn.DataPropertyName = "UNIDADE_PROD_ITEM_VENDA";
            this.uNIDADEPRODITEMVENDADataGridViewTextBoxColumn.HeaderText = "Un.";
            this.uNIDADEPRODITEMVENDADataGridViewTextBoxColumn.Name = "uNIDADEPRODITEMVENDADataGridViewTextBoxColumn";
            this.uNIDADEPRODITEMVENDADataGridViewTextBoxColumn.Visible = false;
            this.uNIDADEPRODITEMVENDADataGridViewTextBoxColumn.Width = 30;
            // 
            // col_qtde_saida
            // 
            this.col_qtde_saida.DataPropertyName = "QTDE_ITEM_VENDA";
            this.col_qtde_saida.HeaderText = "Qtd";
            this.col_qtde_saida.Name = "col_qtde_saida";
            this.col_qtde_saida.Width = 30;
            // 
            // vALORUNITPRODITEMVENDADataGridViewTextBoxColumn
            // 
            this.vALORUNITPRODITEMVENDADataGridViewTextBoxColumn.DataPropertyName = "VALOR_UNIT_PROD_ITEM_VENDA";
            this.vALORUNITPRODITEMVENDADataGridViewTextBoxColumn.HeaderText = "Valor Unit";
            this.vALORUNITPRODITEMVENDADataGridViewTextBoxColumn.Name = "vALORUNITPRODITEMVENDADataGridViewTextBoxColumn";
            this.vALORUNITPRODITEMVENDADataGridViewTextBoxColumn.Width = 40;
            // 
            // col_valor_total
            // 
            this.col_valor_total.DataPropertyName = "VALOR_TOTAL_PROD_ITEM_VENDA";
            this.col_valor_total.HeaderText = "Valor Total";
            this.col_valor_total.Name = "col_valor_total";
            this.col_valor_total.Width = 40;
            // 
            // bCICMSPRODITEMVENDADataGridViewTextBoxColumn
            // 
            this.bCICMSPRODITEMVENDADataGridViewTextBoxColumn.DataPropertyName = "BC_ICMS_PROD_ITEM_VENDA";
            this.bCICMSPRODITEMVENDADataGridViewTextBoxColumn.HeaderText = "BC Icms";
            this.bCICMSPRODITEMVENDADataGridViewTextBoxColumn.Name = "bCICMSPRODITEMVENDADataGridViewTextBoxColumn";
            this.bCICMSPRODITEMVENDADataGridViewTextBoxColumn.Visible = false;
            // 
            // aLIQICMSPRODITEMVENDADataGridViewTextBoxColumn
            // 
            this.aLIQICMSPRODITEMVENDADataGridViewTextBoxColumn.DataPropertyName = "ALIQ_ICMS_PROD_ITEM_VENDA";
            this.aLIQICMSPRODITEMVENDADataGridViewTextBoxColumn.HeaderText = "Aliquota Icms";
            this.aLIQICMSPRODITEMVENDADataGridViewTextBoxColumn.Name = "aLIQICMSPRODITEMVENDADataGridViewTextBoxColumn";
            this.aLIQICMSPRODITEMVENDADataGridViewTextBoxColumn.Visible = false;
            // 
            // bCIPIPRODITEMVENDADataGridViewTextBoxColumn
            // 
            this.bCIPIPRODITEMVENDADataGridViewTextBoxColumn.DataPropertyName = "BC_IPI_PROD_ITEM_VENDA";
            this.bCIPIPRODITEMVENDADataGridViewTextBoxColumn.HeaderText = "BC IPI";
            this.bCIPIPRODITEMVENDADataGridViewTextBoxColumn.Name = "bCIPIPRODITEMVENDADataGridViewTextBoxColumn";
            this.bCIPIPRODITEMVENDADataGridViewTextBoxColumn.Visible = false;
            // 
            // aLIQIPIPRODITEMVENDADataGridViewTextBoxColumn
            // 
            this.aLIQIPIPRODITEMVENDADataGridViewTextBoxColumn.DataPropertyName = "ALIQ_IPI_PROD_ITEM_VENDA";
            this.aLIQIPIPRODITEMVENDADataGridViewTextBoxColumn.HeaderText = "Aliquota IPI";
            this.aLIQIPIPRODITEMVENDADataGridViewTextBoxColumn.Name = "aLIQIPIPRODITEMVENDADataGridViewTextBoxColumn";
            this.aLIQIPIPRODITEMVENDADataGridViewTextBoxColumn.Visible = false;
            // 
            // nFPRODITEMVENDADataGridViewTextBoxColumn
            // 
            this.nFPRODITEMVENDADataGridViewTextBoxColumn.DataPropertyName = "NF_PROD_ITEM_VENDA";
            this.nFPRODITEMVENDADataGridViewTextBoxColumn.HeaderText = "NF?";
            this.nFPRODITEMVENDADataGridViewTextBoxColumn.Name = "nFPRODITEMVENDADataGridViewTextBoxColumn";
            this.nFPRODITEMVENDADataGridViewTextBoxColumn.Width = 30;
            // 
            // nNFPRODITEMVENDADataGridViewTextBoxColumn
            // 
            this.nNFPRODITEMVENDADataGridViewTextBoxColumn.DataPropertyName = "N_NF_PROD_ITEM_VENDA";
            this.nNFPRODITEMVENDADataGridViewTextBoxColumn.HeaderText = "Nº NF";
            this.nNFPRODITEMVENDADataGridViewTextBoxColumn.Name = "nNFPRODITEMVENDADataGridViewTextBoxColumn";
            this.nNFPRODITEMVENDADataGridViewTextBoxColumn.Width = 30;
            // 
            // oBSITEMVENDADataGridViewTextBoxColumn
            // 
            this.oBSITEMVENDADataGridViewTextBoxColumn.DataPropertyName = "OBS_ITEM_VENDA";
            this.oBSITEMVENDADataGridViewTextBoxColumn.HeaderText = "Obs";
            this.oBSITEMVENDADataGridViewTextBoxColumn.Name = "oBSITEMVENDADataGridViewTextBoxColumn";
            this.oBSITEMVENDADataGridViewTextBoxColumn.Visible = false;
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
            this.fbCommand13.CommandText = "select * from itens_nf_entrada";
            this.fbCommand13.CommandTimeout = 30;
            this.fbCommand13.Connection = this.fbConnection1;
            // 
            // fbCommand15
            // 
            this.fbCommand15.CommandTimeout = 30;
            // 
            // dsItens_nf_entrada
            // 
            this.dsItens_nf_entrada.DataSetName = "dsItens_nf_entrada";
            this.dsItens_nf_entrada.Namespace = "http://www.tempuri.org/dsItens_nf_entrada.xsd";
            this.dsItens_nf_entrada.Tables.AddRange(new System.Data.DataTable[] {
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
            this.COD_NOTA_ITENS_NF_ENT,
            this.MATERIAL_ITENS_NF_ENT});
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
            // MATERIAL_ITENS_NF_ENT
            // 
            this.MATERIAL_ITENS_NF_ENT.ColumnName = "MATERIAL_ITENS_NF_ENT";
            this.MATERIAL_ITENS_NF_ENT.MaxLength = 30;
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AutoGenerateColumns = false;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_cod_item_entrada,
            this.col_cod_item,
            this.col_nf_entrada,
            this.col_item,
            this.col_qtde_entrada,
            this.col_valor_item,
            this.col_itens_ped,
            this.fORNITENSNFENTDataGridViewTextBoxColumn,
            this.dATAENTITENSNFENTDataGridViewTextBoxColumn});
            this.dgvItens.DataMember = "ITENS_NF_ENTRADA";
            this.dgvItens.DataSource = this.dsItens_nf_entrada;
            this.dgvItens.Location = new System.Drawing.Point(15, 41);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.RowHeadersWidth = 15;
            this.dgvItens.Size = new System.Drawing.Size(184, 317);
            this.dgvItens.TabIndex = 271;
            this.dgvItens.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItens_CellClick);
            this.dgvItens.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvItens_CellMouseDoubleClick);
            this.dgvItens.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItens_CellContentClick);
            // 
            // col_cod_item_entrada
            // 
            this.col_cod_item_entrada.DataPropertyName = "COD_CONTROLE_ITENS_NF_ENT";
            this.col_cod_item_entrada.HeaderText = "Cód. Controle";
            this.col_cod_item_entrada.Name = "col_cod_item_entrada";
            this.col_cod_item_entrada.Visible = false;
            this.col_cod_item_entrada.Width = 50;
            // 
            // col_cod_item
            // 
            this.col_cod_item.DataPropertyName = "COD_ITENS_NF_ENT";
            this.col_cod_item.HeaderText = "Cód. Item";
            this.col_cod_item.Name = "col_cod_item";
            this.col_cod_item.Visible = false;
            this.col_cod_item.Width = 70;
            // 
            // col_nf_entrada
            // 
            this.col_nf_entrada.DataPropertyName = "N_NOTA_ITENS_NF_ENT";
            this.col_nf_entrada.HeaderText = "NF";
            this.col_nf_entrada.Name = "col_nf_entrada";
            this.col_nf_entrada.Width = 30;
            // 
            // col_item
            // 
            this.col_item.DataPropertyName = "ITEM_ITENS_NF_ENT";
            this.col_item.HeaderText = "Item";
            this.col_item.Name = "col_item";
            this.col_item.Visible = false;
            this.col_item.Width = 250;
            // 
            // col_qtde_entrada
            // 
            this.col_qtde_entrada.DataPropertyName = "QTDE_ITENS_NF_ENT";
            this.col_qtde_entrada.HeaderText = "Qtd";
            this.col_qtde_entrada.Name = "col_qtde_entrada";
            this.col_qtde_entrada.Width = 30;
            // 
            // col_valor_item
            // 
            this.col_valor_item.DataPropertyName = "VALOR_ITENS_NF_ENT";
            this.col_valor_item.HeaderText = "Valor Unit";
            this.col_valor_item.Name = "col_valor_item";
            this.col_valor_item.Width = 40;
            // 
            // col_itens_ped
            // 
            this.col_itens_ped.DataPropertyName = "PEDIDO_COMPRA_ITENS_NF_ENT";
            this.col_itens_ped.HeaderText = "Item Pedido de Compra";
            this.col_itens_ped.Name = "col_itens_ped";
            this.col_itens_ped.Visible = false;
            // 
            // fORNITENSNFENTDataGridViewTextBoxColumn
            // 
            this.fORNITENSNFENTDataGridViewTextBoxColumn.DataPropertyName = "FORN_ITENS_NF_ENT";
            this.fORNITENSNFENTDataGridViewTextBoxColumn.HeaderText = "FORN_ITENS_NF_ENT";
            this.fORNITENSNFENTDataGridViewTextBoxColumn.Name = "fORNITENSNFENTDataGridViewTextBoxColumn";
            this.fORNITENSNFENTDataGridViewTextBoxColumn.Visible = false;
            // 
            // dATAENTITENSNFENTDataGridViewTextBoxColumn
            // 
            this.dATAENTITENSNFENTDataGridViewTextBoxColumn.DataPropertyName = "DATA_ENT_ITENS_NF_ENT";
            this.dATAENTITENSNFENTDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dATAENTITENSNFENTDataGridViewTextBoxColumn.Name = "dATAENTITENSNFENTDataGridViewTextBoxColumn";
            this.dATAENTITENSNFENTDataGridViewTextBoxColumn.Width = 40;
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
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.dgvItens_nota);
            this.groupBox3.Location = new System.Drawing.Point(554, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(215, 374);
            this.groupBox3.TabIndex = 275;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Saídas";
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
            this.groupBox4.Controls.Add(this.button7);
            this.groupBox4.Controls.Add(this.button8);
            this.groupBox4.Controls.Add(this.dgvItens);
            this.groupBox4.Controls.Add(this.button9);
            this.groupBox4.Location = new System.Drawing.Point(773, 9);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(213, 374);
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
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(555, 388);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(430, 23);
            this.button10.TabIndex = 277;
            this.button10.Text = "Recalcular Estoque";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // cbItens_ped_venda
            // 
            this.cbItens_ped_venda.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbItens_ped_venda.DataAdapter = this.datItens_ped_venda;
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
            this.button11.Location = new System.Drawing.Point(840, 424);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(57, 60);
            this.button11.TabIndex = 278;
            this.button11.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.DESCRICAO_ITEM_PRODUTO", true));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(140, 188);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(401, 20);
            this.textBox2.TabIndex = 279;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(24, 191);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(81, 13);
            this.label38.TabIndex = 280;
            this.label38.Text = "Descrição Item:";
            // 
            // txtCodAlternativo
            // 
            this.txtCodAlternativo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.COD_FORNECEDOR_PRODUTO", true));
            this.txtCodAlternativo.Location = new System.Drawing.Point(384, 44);
            this.txtCodAlternativo.Name = "txtCodAlternativo";
            this.txtCodAlternativo.Size = new System.Drawing.Size(108, 20);
            this.txtCodAlternativo.TabIndex = 281;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(304, 46);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(82, 13);
            this.label44.TabIndex = 282;
            this.label44.Text = "Cód Alternativo:";
            // 
            // textBox9
            // 
            this.textBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.LOCALIZACAO_PRODUTO", true));
            this.textBox9.Location = new System.Drawing.Point(140, 214);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(96, 20);
            this.textBox9.TabIndex = 283;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(24, 217);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(107, 13);
            this.label47.TabIndex = 284;
            this.label47.Text = "Localização Produto:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.panel5);
            this.tabPage4.Controls.Add(this.panel4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(525, 258);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Tributação";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.PaleGreen;
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
            this.textBox45.Location = new System.Drawing.Point(149, 154);
            this.textBox45.Name = "textBox45";
            this.textBox45.Size = new System.Drawing.Size(72, 20);
            this.textBox45.TabIndex = 154;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(19, 157);
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
            this.textBox35.Location = new System.Drawing.Point(149, 128);
            this.textBox35.Name = "textBox35";
            this.textBox35.Size = new System.Drawing.Size(72, 20);
            this.textBox35.TabIndex = 148;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(19, 131);
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
            this.tabPage3.Size = new System.Drawing.Size(525, 258);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Valores";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.COMISSAO_PRODUTO", true));
            this.textBox1.Location = new System.Drawing.Point(412, 121);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(72, 20);
            this.textBox1.TabIndex = 141;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(282, 124);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(55, 13);
            this.label37.TabIndex = 142;
            this.label37.Text = "Comissão:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SpringGreen;
            this.panel3.Controls.Add(this.textBox41);
            this.panel3.Controls.Add(this.label43);
            this.panel3.Controls.Add(this.textBox31);
            this.panel3.Controls.Add(this.label33);
            this.panel3.Controls.Add(this.textBox32);
            this.panel3.Controls.Add(this.label34);
            this.panel3.Location = new System.Drawing.Point(263, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(246, 89);
            this.panel3.TabIndex = 153;
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
            // textBox32
            // 
            this.textBox32.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.LUCRO_PRODUTO", true));
            this.textBox32.Location = new System.Drawing.Point(149, 8);
            this.textBox32.Name = "textBox32";
            this.textBox32.Size = new System.Drawing.Size(72, 20);
            this.textBox32.TabIndex = 135;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(19, 11);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(92, 13);
            this.label34.TabIndex = 136;
            this.label34.Text = "Lucro do Produto:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SpringGreen;
            this.panel2.Controls.Add(this.textBox25);
            this.panel2.Controls.Add(this.label27);
            this.panel2.Controls.Add(this.textBox26);
            this.panel2.Controls.Add(this.label28);
            this.panel2.Controls.Add(this.textBox27);
            this.panel2.Controls.Add(this.label29);
            this.panel2.Controls.Add(this.textBox28);
            this.panel2.Controls.Add(this.label30);
            this.panel2.Controls.Add(this.textBox29);
            this.panel2.Controls.Add(this.label31);
            this.panel2.Controls.Add(this.textBox30);
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
            // textBox26
            // 
            this.textBox26.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.VALOR_PROMOCAO_PRODUTO", true));
            this.textBox26.Location = new System.Drawing.Point(149, 112);
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new System.Drawing.Size(72, 20);
            this.textBox26.TabIndex = 143;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(19, 115);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(85, 13);
            this.label28.TabIndex = 144;
            this.label28.Text = "Valor Promoção:";
            // 
            // textBox27
            // 
            this.textBox27.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.VALOR_VENDA_REVEND_PRODUTO", true));
            this.textBox27.Location = new System.Drawing.Point(149, 86);
            this.textBox27.Name = "textBox27";
            this.textBox27.Size = new System.Drawing.Size(72, 20);
            this.textBox27.TabIndex = 141;
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
            // textBox30
            // 
            this.textBox30.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.CUSTO_PRODUTO", true));
            this.textBox30.Location = new System.Drawing.Point(149, 8);
            this.textBox30.Name = "textBox30";
            this.textBox30.Size = new System.Drawing.Size(72, 20);
            this.textBox30.TabIndex = 135;
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
            this.tabPage2.Size = new System.Drawing.Size(525, 258);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Estoque";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.panel1.Size = new System.Drawing.Size(246, 163);
            this.panel1.TabIndex = 143;
            // 
            // tb_estoque_medio
            // 
            this.tb_estoque_medio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.ESTOQUE_MEDIO_PRODUTO", true));
            this.tb_estoque_medio.Location = new System.Drawing.Point(140, 138);
            this.tb_estoque_medio.Name = "tb_estoque_medio";
            this.tb_estoque_medio.Size = new System.Drawing.Size(72, 20);
            this.tb_estoque_medio.TabIndex = 145;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(19, 141);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(81, 13);
            this.label21.TabIndex = 146;
            this.label21.Text = "Estoque Médio:";
            // 
            // textBox20
            // 
            this.textBox20.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.ESTOQUE_MAXIMO_PRODUTO", true));
            this.textBox20.Location = new System.Drawing.Point(140, 112);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(72, 20);
            this.textBox20.TabIndex = 143;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(19, 115);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(88, 13);
            this.label22.TabIndex = 144;
            this.label22.Text = "Estoque Máximo:";
            // 
            // textBox15
            // 
            this.textBox15.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.ESTOQUE_ENCOMENDADO_PRODUTO", true));
            this.textBox15.Location = new System.Drawing.Point(140, 86);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(72, 20);
            this.textBox15.TabIndex = 141;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(19, 89);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(121, 13);
            this.label16.TabIndex = 142;
            this.label16.Text = "Estoque Encomendado:";
            // 
            // textBox16
            // 
            this.textBox16.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.ESTOQUE_MINIMO_PRODUTO", true));
            this.textBox16.Location = new System.Drawing.Point(140, 60);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(72, 20);
            this.textBox16.TabIndex = 139;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(19, 63);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(87, 13);
            this.label17.TabIndex = 140;
            this.label17.Text = "Estoque Mínimo:";
            // 
            // textBox17
            // 
            this.textBox17.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.ESTOQUE_RESERVADO_PRODUTO", true));
            this.textBox17.Location = new System.Drawing.Point(140, 34);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(72, 20);
            this.textBox17.TabIndex = 137;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(19, 37);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(104, 13);
            this.label18.TabIndex = 138;
            this.label18.Text = "Estoque Reservado:";
            // 
            // tb_estoque_atual
            // 
            this.tb_estoque_atual.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.ESTOQUE_ATUAL_PRODUTO", true));
            this.tb_estoque_atual.Location = new System.Drawing.Point(140, 8);
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
            this.tabPage1.Size = new System.Drawing.Size(525, 258);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Descrições";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.textBox8);
            this.groupBox2.Controls.Add(this.textBox7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tb_unidade);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tb_cod_unidade);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(11, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(473, 149);
            this.groupBox2.TabIndex = 132;
            this.groupBox2.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(450, 69);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(15, 23);
            this.button3.TabIndex = 129;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox8
            // 
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.NCM_PRODUTO", true));
            this.textBox8.Location = new System.Drawing.Point(96, 45);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 129;
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.COD_BARRAS_PRODUTO", true));
            this.textBox7.Location = new System.Drawing.Point(97, 97);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(347, 20);
            this.textBox7.TabIndex = 129;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 130;
            this.label8.Text = "Cód. de Barras:";
            // 
            // tb_unidade
            // 
            this.tb_unidade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.DESCRICAO_UNIDADE_PRODUTO", true));
            this.tb_unidade.Location = new System.Drawing.Point(241, 71);
            this.tb_unidade.Name = "tb_unidade";
            this.tb_unidade.Size = new System.Drawing.Size(203, 20);
            this.tb_unidade.TabIndex = 127;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(174, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 128;
            this.label10.Text = "Unidade:";
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
            this.tb_cod_unidade.Location = new System.Drawing.Point(96, 71);
            this.tb_cod_unidade.Name = "tb_cod_unidade";
            this.tb_cod_unidade.Size = new System.Drawing.Size(72, 20);
            this.tb_cod_unidade.TabIndex = 125;
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.CARACT_ADIC_PRODUTO", true));
            this.textBox6.Location = new System.Drawing.Point(97, 19);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(348, 20);
            this.textBox6.TabIndex = 127;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 13);
            this.label11.TabIndex = 126;
            this.label11.Text = "Abrev. Unidade:";
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
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(12, 240);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(533, 284);
            this.tabControl1.TabIndex = 133;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.panel6);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(525, 258);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Informações de Entrada";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.YellowGreen;
            this.panel6.Controls.Add(this.textBox36);
            this.panel6.Controls.Add(this.label52);
            this.panel6.Controls.Add(this.comboBox1);
            this.panel6.Controls.Add(this.label55);
            this.panel6.Controls.Add(this.label56);
            this.panel6.Controls.Add(this.textBox43);
            this.panel6.Location = new System.Drawing.Point(122, 86);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(281, 86);
            this.panel6.TabIndex = 291;
            // 
            // textBox36
            // 
            this.textBox36.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.ST_PRODUTO", true));
            this.textBox36.Location = new System.Drawing.Point(134, 7);
            this.textBox36.Name = "textBox36";
            this.textBox36.Size = new System.Drawing.Size(72, 20);
            this.textBox36.TabIndex = 287;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(14, 10);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(76, 13);
            this.label52.TabIndex = 288;
            this.label52.Text = "ST ENTRADA";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.ORIGEM_PRODUTO", true));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "0 - Nacional",
            "1 - Estrangeira - Importação direta",
            "2 - Estrangeira - Adquirida no mercado interno"});
            this.comboBox1.Location = new System.Drawing.Point(134, 59);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(131, 21);
            this.comboBox1.TabIndex = 286;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(14, 36);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(90, 13);
            this.label55.TabIndex = 284;
            this.label55.Text = "CFOP ENTRADA";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(14, 62);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(114, 13);
            this.label56.TabIndex = 285;
            this.label56.Text = "Origem da Mercadoria:";
            // 
            // textBox43
            // 
            this.textBox43.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProdutos, "PRODUTOS.CFOP_ENTRADA_PRODUTO", true));
            this.textBox43.Location = new System.Drawing.Point(134, 33);
            this.textBox43.Name = "textBox43";
            this.textBox43.Size = new System.Drawing.Size(72, 20);
            this.textBox43.TabIndex = 283;
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
            // form_produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 547);
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
            ((System.ComponentModel.ISupportInitialize)(this.dsItens_ped_venda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITENS_PEDIDO_VENDA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens_nota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsItens_nf_entrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITENS_NF_ENTRADA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
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
            this.tabPage5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
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
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand5;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand6;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand7;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand8;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbProdutos;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datItens_ped_venda;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand12;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand10;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand9;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand11;
        private System.Data.DataSet dsItens_ped_venda;
        private System.Data.DataTable ITENS_PEDIDO_VENDA;
        private System.Data.DataColumn COD_ITEM_VENDA;
        private System.Data.DataColumn QTDE_ITEM_VENDA;
        private System.Data.DataColumn COD_PROD_ITEM_VENDA;
        private System.Data.DataColumn DESCRICAO_PROD_ITEM_VENDA;
        private System.Data.DataColumn VALOR_UNIT_PROD_ITEM_VENDA;
        private System.Data.DataColumn VALOR_TOTAL_PROD_ITEM_VENDA;
        private System.Data.DataColumn UNIDADE_PROD_ITEM_VENDA;
        private System.Data.DataColumn BC_ICMS_PROD_ITEM_VENDA;
        private System.Data.DataColumn ALIQ_ICMS_PROD_ITEM_VENDA;
        private System.Data.DataColumn VALOR_ICMS_ITEM_VENDA;
        private System.Data.DataColumn BC_IPI_PROD_ITEM_VENDA;
        private System.Data.DataColumn ALIQ_IPI_PROD_ITEM_VENDA;
        private System.Data.DataColumn VALOR_IPI_ITEM_VENDA;
        private System.Data.DataColumn NF_PROD_ITEM_VENDA;
        private System.Data.DataColumn N_NF_PROD_ITEM_VENDA;
        private System.Data.DataColumn OBS_ITEM_VENDA;
        private System.Data.DataColumn COD_PEDIDO_ITEM_VENDA;
        private System.Windows.Forms.DataGridView dgvItens_nota;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datItens_nf_entrada;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand16;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand14;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand13;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand15;
        private System.Data.DataSet dsItens_nf_entrada;
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
        private System.Data.DataColumn MATERIAL_ITENS_NF_ENT;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod_item_saida;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ped;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRICAOPRODITEMVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uNIDADEPRODITEMVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_qtde_saida;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORUNITPRODITEMVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_valor_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn bCICMSPRODITEMVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aLIQICMSPRODITEMVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bCIPIPRODITEMVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aLIQIPIPRODITEMVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nFPRODITEMVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nNFPRODITEMVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oBSITEMVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod_item_entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nf_entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_qtde_entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_valor_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_itens_ped;
        private System.Windows.Forms.DataGridViewTextBoxColumn fORNITENSNFENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAENTITENSNFENTDataGridViewTextBoxColumn;
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
        private System.Windows.Forms.TextBox textBox32;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox25;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox textBox26;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox textBox27;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox textBox28;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox textBox29;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox textBox30;
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
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_unidade;
        private System.Windows.Forms.Label label10;
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
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textBox36;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.TextBox textBox43;
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
    }
}