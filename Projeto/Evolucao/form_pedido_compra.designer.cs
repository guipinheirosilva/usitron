namespace Evolucao
{
    partial class form_pedido_compra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_pedido_compra));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label20 = new System.Windows.Forms.Label();
            this.tb_n_pedido = new System.Windows.Forms.TextBox();
            this.dsPedido_compra = new System.Data.DataSet();
            this.PEDIDO_COMPRA = new System.Data.DataTable();
            this.COD_PED = new System.Data.DataColumn();
            this.N_PED = new System.Data.DataColumn();
            this.DATA_EMISSAO_PED = new System.Data.DataColumn();
            this.NOME_FORN_PED = new System.Data.DataColumn();
            this.CNPJ_FORN_PED = new System.Data.DataColumn();
            this.COND_PGTO_PED = new System.Data.DataColumn();
            this.DATA_RETIRA_PED = new System.Data.DataColumn();
            this.CUSTO_FINANC_PED = new System.Data.DataColumn();
            this.VALOR_PARCIAL_PED = new System.Data.DataColumn();
            this.VALOR_IPI_PED = new System.Data.DataColumn();
            this.VALOR_ICMS_PED = new System.Data.DataColumn();
            this.VALOR_TOTAL_PED = new System.Data.DataColumn();
            this.AUTORIZADO_PED = new System.Data.DataColumn();
            this.DATA_AUTORIZACAO_PED = new System.Data.DataColumn();
            this.HORA_AUTORIZACAO_PED = new System.Data.DataColumn();
            this.COD_AUTORIZANTE_PED = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn8 = new System.Data.DataColumn();
            this.dataColumn11 = new System.Data.DataColumn();
            this.dataColumn12 = new System.Data.DataColumn();
            this.dataColumn13 = new System.Data.DataColumn();
            this.dataColumn15 = new System.Data.DataColumn();
            this.dataColumn16 = new System.Data.DataColumn();
            this.dataColumn19 = new System.Data.DataColumn();
            this.dataColumn20 = new System.Data.DataColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_data_emissao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_nome_forn = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_cnpj_forn = new System.Windows.Forms.TextBox();
            this.bt_localizar_forn = new System.Windows.Forms.Button();
            this.bt_imprimir = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.datPedido_compra = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.cbPedido_compra = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.datItens_ped = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand8 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand6 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand5 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand7 = new FirebirdSql.Data.FirebirdClient.FbCommand();
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
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataColumn9 = new System.Data.DataColumn();
            this.dataColumn10 = new System.Data.DataColumn();
            this.dataColumn14 = new System.Data.DataColumn();
            this.dataColumn17 = new System.Data.DataColumn();
            this.dataColumn18 = new System.Data.DataColumn();
            this.dataColumn21 = new System.Data.DataColumn();
            this.cbItens_ped = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_unidade = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_cod_item = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_qtde = new System.Windows.Forms.TextBox();
            this.tb_descricao_item = new System.Windows.Forms.TextBox();
            this.tb_item_n_pedido = new System.Windows.Forms.TextBox();
            this.bt_inserir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_forma_pgto = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tb_valor_total = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_valor_unit = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tb_data_entrega = new System.Windows.Forms.TextBox();
            this.datItens_req = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand12 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand10 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand9 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand11 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.comando_select = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsItens_req = new System.Data.DataSet();
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
            this.dataColumn7 = new System.Data.DataColumn();
            this.datFornecedores = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand16 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand14 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand13 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand15 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsFornecedores = new System.Data.DataSet();
            this.FORNECEDORES = new System.Data.DataTable();
            this.COD_FORN = new System.Data.DataColumn();
            this.RAZAO_SOCIAL_FORN = new System.Data.DataColumn();
            this.NOME_FANTASIA_FORN = new System.Data.DataColumn();
            this.TIPO_MATERIAL = new System.Data.DataColumn();
            this.TIPO_MATERIAL_2 = new System.Data.DataColumn();
            this.TIPO_MATERIAL_3 = new System.Data.DataColumn();
            this.TIPO_MATERIAL_4 = new System.Data.DataColumn();
            this.CNPJ_CPF_FORN = new System.Data.DataColumn();
            this.IE_RG_FORN = new System.Data.DataColumn();
            this.ENDERECO_FORN = new System.Data.DataColumn();
            this.BAIRRO_FORN = new System.Data.DataColumn();
            this.CIDADE_FORN = new System.Data.DataColumn();
            this.CEP_FORN = new System.Data.DataColumn();
            this.ESTADO_FORN = new System.Data.DataColumn();
            this.PAIS_FORN = new System.Data.DataColumn();
            this.EMAIL_FORN = new System.Data.DataColumn();
            this.TEL_FORN = new System.Data.DataColumn();
            this.CONTATO_FORN = new System.Data.DataColumn();
            this.TEL_CONTATO_FORN = new System.Data.DataColumn();
            this.EMAIL_CONTATO_FORN = new System.Data.DataColumn();
            this.OUTRAS_INF_FORN = new System.Data.DataColumn();
            this.ISO_FORN = new System.Data.DataColumn();
            this.VALIDADE_ISO_FORN = new System.Data.DataColumn();
            this.CERT_UNI_FORN = new System.Data.DataColumn();
            this.VALIDADE_CERT_UNI_FORN = new System.Data.DataColumn();
            this.NOTA_CERT_UNI_FORN = new System.Data.DataColumn();
            this.button7 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_nome_autorizante = new System.Windows.Forms.TextBox();
            this.tb_data_autorizacao = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tb_hora_autorizacao = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.cbAutorizado = new System.Windows.Forms.CheckBox();
            this.bt_enviar_email = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button12 = new System.Windows.Forms.Button();
            this.btnLiberar = new System.Windows.Forms.Button();
            this.cb_efetuado = new System.Windows.Forms.CheckBox();
            this.cb_descricai_maior = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_n_requisicao = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.barra_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.label22 = new System.Windows.Forms.Label();
            this.tb_obs = new System.Windows.Forms.TextBox();
            this.datEmails_enviados = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand20 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand18 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand17 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand19 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsEmails_enviados = new System.Data.DataSet();
            this.EMAILS_ENVIADOS = new System.Data.DataTable();
            this.COD_EMAIL_ENVIADO = new System.Data.DataColumn();
            this.DESTINATARIO_EMAIL_ENVIADO = new System.Data.DataColumn();
            this.DATA_EMAIL_ENVIADO = new System.Data.DataColumn();
            this.TIPO_EMAIL_ENVIADO = new System.Data.DataColumn();
            this.HORA_EMAIL_ENVIADO = new System.Data.DataColumn();
            this.CAMINHO_ARQUIVO_EMAIL_ENVIADO = new System.Data.DataColumn();
            this.dgvItens_ped = new System.Windows.Forms.DataGridView();
            this.cODITEMPEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nPEDIDOITEMPEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_item_req = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cod_estoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITEM_ITEM_PED = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRICAOITEMPEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPITEMPEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.POSICAO_ITEM_PED = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_qtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uNIDITEMPEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_valor_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_valor_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_frete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Req = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dATALIMITEITEMPEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_chegou = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.col_nf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_data_chegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_resp_chegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label23 = new System.Windows.Forms.Label();
            this.tb_pos = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.tb_os = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.tb_planos = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.tb_item_item = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_valor_real_ipi = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_valor_outras_desp = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.tb_peso = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.tb_desconto = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.tb_justificativa = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.tb_descricao_empresa = new System.Windows.Forms.TextBox();
            this.tb_cnpj_empresa = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.datFatura_pc = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand24 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand22 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand21 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand23 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsFatura_pc = new System.Data.DataSet();
            this.FATURA_PC = new System.Data.DataTable();
            this.COD_FATURA_PC = new System.Data.DataColumn();
            this.PRAZO_FATURA_PC = new System.Data.DataColumn();
            this.DATA_VENC_FATURA_PC = new System.Data.DataColumn();
            this.VALOR_FATURA_PC = new System.Data.DataColumn();
            this.N_PEDIDO_FATURA_PC = new System.Data.DataColumn();
            this.CR_FATURA_PC = new System.Data.DataColumn();
            this.fbCommand25 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand26 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand27 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand28 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dgvFatura_pc = new System.Windows.Forms.DataGridView();
            this.cODFATURAPCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRAZOFATURAPCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAVENCFATURAPCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORFATURAPCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nPEDIDOFATURAPCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRFATURAPCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbFatura_pc = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            ((System.ComponentModel.ISupportInitialize)(this.dsPedido_compra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PEDIDO_COMPRA)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsItens_ped)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITENS_PEDIDO_COMPRA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsItens_req)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITENS_REQUISICAO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFornecedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FORNECEDORES)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsEmails_enviados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EMAILS_ENVIADOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens_ped)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsFatura_pc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FATURA_PC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFatura_pc)).BeginInit();
            this.SuspendLayout();
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label20.Location = new System.Drawing.Point(24, 9);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(427, 46);
            this.label20.TabIndex = 55;
            this.label20.Text = "PEDIDO DE COMPRA";
            // 
            // tb_n_pedido
            // 
            this.tb_n_pedido.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPedido_compra, "PEDIDO_COMPRA.COD_PED", true));
            this.tb_n_pedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_n_pedido.Location = new System.Drawing.Point(215, 58);
            this.tb_n_pedido.Name = "tb_n_pedido";
            this.tb_n_pedido.ReadOnly = true;
            this.tb_n_pedido.Size = new System.Drawing.Size(214, 35);
            this.tb_n_pedido.TabIndex = 56;
            // 
            // dsPedido_compra
            // 
            this.dsPedido_compra.DataSetName = "dsPedido_compra";
            this.dsPedido_compra.Namespace = "http://www.tempuri.org/dsPedido_compra.xsd";
            this.dsPedido_compra.Tables.AddRange(new System.Data.DataTable[] {
            this.PEDIDO_COMPRA});
            // 
            // PEDIDO_COMPRA
            // 
            this.PEDIDO_COMPRA.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_PED,
            this.N_PED,
            this.DATA_EMISSAO_PED,
            this.NOME_FORN_PED,
            this.CNPJ_FORN_PED,
            this.COND_PGTO_PED,
            this.DATA_RETIRA_PED,
            this.CUSTO_FINANC_PED,
            this.VALOR_PARCIAL_PED,
            this.VALOR_IPI_PED,
            this.VALOR_ICMS_PED,
            this.VALOR_TOTAL_PED,
            this.AUTORIZADO_PED,
            this.DATA_AUTORIZACAO_PED,
            this.HORA_AUTORIZACAO_PED,
            this.COD_AUTORIZANTE_PED,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn8,
            this.dataColumn11,
            this.dataColumn12,
            this.dataColumn13,
            this.dataColumn15,
            this.dataColumn16,
            this.dataColumn19,
            this.dataColumn20});
            this.PEDIDO_COMPRA.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_PED"}, true)});
            this.PEDIDO_COMPRA.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_PED};
            this.PEDIDO_COMPRA.TableName = "PEDIDO_COMPRA";
            // 
            // COD_PED
            // 
            this.COD_PED.AllowDBNull = false;
            this.COD_PED.ColumnName = "COD_PED";
            this.COD_PED.DataType = typeof(int);
            // 
            // N_PED
            // 
            this.N_PED.ColumnName = "N_PED";
            this.N_PED.DataType = typeof(int);
            // 
            // DATA_EMISSAO_PED
            // 
            this.DATA_EMISSAO_PED.ColumnName = "DATA_EMISSAO_PED";
            this.DATA_EMISSAO_PED.DataType = typeof(System.DateTime);
            // 
            // NOME_FORN_PED
            // 
            this.NOME_FORN_PED.ColumnName = "NOME_FORN_PED";
            this.NOME_FORN_PED.MaxLength = 250;
            // 
            // CNPJ_FORN_PED
            // 
            this.CNPJ_FORN_PED.ColumnName = "CNPJ_FORN_PED";
            this.CNPJ_FORN_PED.MaxLength = 30;
            // 
            // COND_PGTO_PED
            // 
            this.COND_PGTO_PED.ColumnName = "COND_PGTO_PED";
            this.COND_PGTO_PED.MaxLength = 50;
            // 
            // DATA_RETIRA_PED
            // 
            this.DATA_RETIRA_PED.ColumnName = "DATA_RETIRA_PED";
            this.DATA_RETIRA_PED.DataType = typeof(System.DateTime);
            // 
            // CUSTO_FINANC_PED
            // 
            this.CUSTO_FINANC_PED.ColumnName = "CUSTO_FINANC_PED";
            this.CUSTO_FINANC_PED.DataType = typeof(double);
            // 
            // VALOR_PARCIAL_PED
            // 
            this.VALOR_PARCIAL_PED.ColumnName = "VALOR_PARCIAL_PED";
            this.VALOR_PARCIAL_PED.DataType = typeof(double);
            // 
            // VALOR_IPI_PED
            // 
            this.VALOR_IPI_PED.ColumnName = "VALOR_IPI_PED";
            this.VALOR_IPI_PED.MaxLength = 50;
            // 
            // VALOR_ICMS_PED
            // 
            this.VALOR_ICMS_PED.ColumnName = "VALOR_ICMS_PED";
            this.VALOR_ICMS_PED.MaxLength = 50;
            // 
            // VALOR_TOTAL_PED
            // 
            this.VALOR_TOTAL_PED.ColumnName = "VALOR_TOTAL_PED";
            this.VALOR_TOTAL_PED.DataType = typeof(double);
            // 
            // AUTORIZADO_PED
            // 
            this.AUTORIZADO_PED.ColumnName = "AUTORIZADO_PED";
            this.AUTORIZADO_PED.DataType = typeof(int);
            // 
            // DATA_AUTORIZACAO_PED
            // 
            this.DATA_AUTORIZACAO_PED.ColumnName = "DATA_AUTORIZACAO_PED";
            this.DATA_AUTORIZACAO_PED.DataType = typeof(System.DateTime);
            // 
            // HORA_AUTORIZACAO_PED
            // 
            this.HORA_AUTORIZACAO_PED.ColumnName = "HORA_AUTORIZACAO_PED";
            this.HORA_AUTORIZACAO_PED.MaxLength = 10;
            // 
            // COD_AUTORIZANTE_PED
            // 
            this.COD_AUTORIZANTE_PED.ColumnName = "NOME_AUTORIZANTE_PED";
            this.COD_AUTORIZANTE_PED.MaxLength = 50;
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "OBS_PEDIDO_COMPRA";
            this.dataColumn2.MaxLength = 300;
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "EFETUADO_PED";
            this.dataColumn3.DataType = typeof(int);
            // 
            // dataColumn8
            // 
            this.dataColumn8.ColumnName = "PLANO_PED";
            this.dataColumn8.MaxLength = 100;
            // 
            // dataColumn11
            // 
            this.dataColumn11.ColumnName = "VALOR_REAL_IPI_PED";
            this.dataColumn11.DataType = typeof(double);
            // 
            // dataColumn12
            // 
            this.dataColumn12.ColumnName = "VALOR_OUTRAS_DESP_PED";
            this.dataColumn12.DataType = typeof(double);
            // 
            // dataColumn13
            // 
            this.dataColumn13.ColumnName = "DESCRICAO_OUTRAS_DESP_PED";
            this.dataColumn13.MaxLength = 50;
            // 
            // dataColumn15
            // 
            this.dataColumn15.ColumnName = "DESCONTO_PED";
            this.dataColumn15.DataType = typeof(double);
            // 
            // dataColumn16
            // 
            this.dataColumn16.ColumnName = "JUSTIFICATIVA_PED";
            this.dataColumn16.MaxLength = 200;
            // 
            // dataColumn19
            // 
            this.dataColumn19.ColumnName = "CNPJ_EMISSOR_PED";
            this.dataColumn19.MaxLength = 30;
            // 
            // dataColumn20
            // 
            this.dataColumn20.ColumnName = "RAZAO_EMISSOR_PED";
            this.dataColumn20.MaxLength = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 24);
            this.label1.TabIndex = 57;
            this.label1.Text = "Número do Pedido:";
            // 
            // tb_data_emissao
            // 
            this.tb_data_emissao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPedido_compra, "PEDIDO_COMPRA.DATA_EMISSAO_PED", true));
            this.tb_data_emissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_data_emissao.Location = new System.Drawing.Point(571, 58);
            this.tb_data_emissao.Name = "tb_data_emissao";
            this.tb_data_emissao.ReadOnly = true;
            this.tb_data_emissao.Size = new System.Drawing.Size(211, 35);
            this.tb_data_emissao.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(436, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 24);
            this.label2.TabIndex = 59;
            this.label2.Text = "Data Emissão:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "Nome:";
            // 
            // tb_nome_forn
            // 
            this.tb_nome_forn.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPedido_compra, "PEDIDO_COMPRA.NOME_FORN_PED", true));
            this.tb_nome_forn.Location = new System.Drawing.Point(70, 22);
            this.tb_nome_forn.Name = "tb_nome_forn";
            this.tb_nome_forn.Size = new System.Drawing.Size(265, 20);
            this.tb_nome_forn.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.tb_cnpj_forn);
            this.groupBox1.Controls.Add(this.bt_localizar_forn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_nome_forn);
            this.groupBox1.Location = new System.Drawing.Point(32, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 83);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fornecedor";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 72;
            this.label11.Text = "CNPJ:";
            // 
            // tb_cnpj_forn
            // 
            this.tb_cnpj_forn.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPedido_compra, "PEDIDO_COMPRA.CNPJ_FORN_PED", true));
            this.tb_cnpj_forn.Location = new System.Drawing.Point(70, 48);
            this.tb_cnpj_forn.Name = "tb_cnpj_forn";
            this.tb_cnpj_forn.Size = new System.Drawing.Size(265, 20);
            this.tb_cnpj_forn.TabIndex = 6;
            // 
            // bt_localizar_forn
            // 
            this.bt_localizar_forn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_localizar_forn.BackgroundImage")));
            this.bt_localizar_forn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_localizar_forn.Location = new System.Drawing.Point(341, 22);
            this.bt_localizar_forn.Name = "bt_localizar_forn";
            this.bt_localizar_forn.Size = new System.Drawing.Size(47, 46);
            this.bt_localizar_forn.TabIndex = 7;
            this.bt_localizar_forn.UseVisualStyleBackColor = true;
            this.bt_localizar_forn.Click += new System.EventHandler(this.bt_localizar_forn_Click);
            // 
            // bt_imprimir
            // 
            this.bt_imprimir.Location = new System.Drawing.Point(397, 15);
            this.bt_imprimir.Name = "bt_imprimir";
            this.bt_imprimir.Size = new System.Drawing.Size(152, 30);
            this.bt_imprimir.TabIndex = 20;
            this.bt_imprimir.Text = "Imprimir";
            this.bt_imprimir.UseVisualStyleBackColor = true;
            this.bt_imprimir.Visible = false;
            this.bt_imprimir.Click += new System.EventHandler(this.bt_imprimir_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(644, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 22);
            this.button2.TabIndex = 2;
            this.button2.Text = "Excluir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(699, 21);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(49, 22);
            this.button3.TabIndex = 3;
            this.button3.Text = "Salvar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(523, 21);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 22);
            this.button4.TabIndex = 4;
            this.button4.Text = "Localizar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(589, 21);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(49, 22);
            this.button5.TabIndex = 1;
            this.button5.Text = "Novo";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // datPedido_compra
            // 
            this.datPedido_compra.DeleteCommand = this.fbCommand4;
            this.datPedido_compra.InsertCommand = this.fbCommand2;
            this.datPedido_compra.SelectCommand = this.fbCommand1;
            this.datPedido_compra.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * from pedido_compra";
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
            // cbPedido_compra
            // 
            this.cbPedido_compra.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbPedido_compra.DataAdapter = this.datPedido_compra;
            this.cbPedido_compra.QuotePrefix = "\"";
            this.cbPedido_compra.QuoteSuffix = "\"";
            // 
            // datItens_ped
            // 
            this.datItens_ped.DeleteCommand = this.fbCommand8;
            this.datItens_ped.InsertCommand = this.fbCommand6;
            this.datItens_ped.SelectCommand = this.fbCommand5;
            this.datItens_ped.UpdateCommand = this.fbCommand7;
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
            this.fbCommand5.CommandText = "select * from itens_pedido_compra";
            this.fbCommand5.CommandTimeout = 30;
            this.fbCommand5.Connection = this.fbConnection1;
            // 
            // fbCommand7
            // 
            this.fbCommand7.CommandTimeout = 30;
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
            this.dataColumn1,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn6,
            this.dataColumn9,
            this.dataColumn10,
            this.dataColumn14,
            this.dataColumn17,
            this.dataColumn18,
            this.dataColumn21});
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
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "COD_ESTOQUE_ITEM_PED";
            this.dataColumn1.DataType = typeof(int);
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "CHEGOU_ITEM_PED";
            this.dataColumn4.DataType = typeof(int);
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "COD_NF_ENTRADA_ITEM_PED";
            this.dataColumn5.DataType = typeof(int);
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "POSICAO_ITEM_PED";
            this.dataColumn6.MaxLength = 50;
            // 
            // dataColumn9
            // 
            this.dataColumn9.ColumnName = "PLANO_ITEM_PED";
            this.dataColumn9.MaxLength = 100;
            // 
            // dataColumn10
            // 
            this.dataColumn10.ColumnName = "ITEM_ITEM_PED";
            this.dataColumn10.MaxLength = 30;
            // 
            // dataColumn14
            // 
            this.dataColumn14.ColumnName = "PESO_ITEM_PED";
            this.dataColumn14.DataType = typeof(double);
            // 
            // dataColumn17
            // 
            this.dataColumn17.ColumnName = "DATA_CHEGADA_ITEM_PED";
            this.dataColumn17.DataType = typeof(System.DateTime);
            // 
            // dataColumn18
            // 
            this.dataColumn18.ColumnName = "RESP_CHEGADA_ITEM_PED";
            this.dataColumn18.MaxLength = 100;
            // 
            // dataColumn21
            // 
            this.dataColumn21.ColumnName = "FRETE_ITEM_PED";
            this.dataColumn21.DataType = typeof(double);
            // 
            // cbItens_ped
            // 
            this.cbItens_ped.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbItens_ped.DataAdapter = this.datItens_ped;
            this.cbItens_ped.QuotePrefix = "\"";
            this.cbItens_ped.QuoteSuffix = "\"";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(653, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 120;
            this.label7.Text = "Unid.";
            // 
            // tb_unidade
            // 
            this.tb_unidade.Location = new System.Drawing.Point(655, 239);
            this.tb_unidade.Name = "tb_unidade";
            this.tb_unidade.Size = new System.Drawing.Size(40, 20);
            this.tb_unidade.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(166, 223);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 119;
            this.label10.Text = "Cód Estoque";
            // 
            // tb_cod_item
            // 
            this.tb_cod_item.Location = new System.Drawing.Point(169, 239);
            this.tb_cod_item.Name = "tb_cod_item";
            this.tb_cod_item.Size = new System.Drawing.Size(68, 20);
            this.tb_cod_item.TabIndex = 109;
            this.tb_cod_item.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_cod_item_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(617, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 117;
            this.label8.Text = "Qtde";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(310, 223);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 13);
            this.label12.TabIndex = 116;
            this.label12.Text = "Descrição Item (Aperte F2)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(84, 223);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 13);
            this.label13.TabIndex = 115;
            this.label13.Text = "Nº Item Requis.";
            // 
            // tb_qtde
            // 
            this.tb_qtde.Location = new System.Drawing.Point(615, 239);
            this.tb_qtde.Name = "tb_qtde";
            this.tb_qtde.Size = new System.Drawing.Size(38, 20);
            this.tb_qtde.TabIndex = 12;
            // 
            // tb_descricao_item
            // 
            this.tb_descricao_item.Location = new System.Drawing.Point(313, 239);
            this.tb_descricao_item.Name = "tb_descricao_item";
            this.tb_descricao_item.Size = new System.Drawing.Size(178, 20);
            this.tb_descricao_item.TabIndex = 8;
            this.tb_descricao_item.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_descricao_item_KeyDown);
            this.tb_descricao_item.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_descricao_item_KeyPress);
            // 
            // tb_item_n_pedido
            // 
            this.tb_item_n_pedido.Location = new System.Drawing.Point(84, 239);
            this.tb_item_n_pedido.Name = "tb_item_n_pedido";
            this.tb_item_n_pedido.Size = new System.Drawing.Size(82, 20);
            this.tb_item_n_pedido.TabIndex = 108;
            // 
            // bt_inserir
            // 
            this.bt_inserir.Location = new System.Drawing.Point(9, 236);
            this.bt_inserir.Name = "bt_inserir";
            this.bt_inserir.Size = new System.Drawing.Size(71, 23);
            this.bt_inserir.TabIndex = 14;
            this.bt_inserir.Text = "Inserir Item";
            this.bt_inserir.UseVisualStyleBackColor = true;
            this.bt_inserir.Click += new System.EventHandler(this.bt_inserir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 454);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 122;
            this.label4.Text = "Forma de Pgto:";
            // 
            // tb_forma_pgto
            // 
            this.tb_forma_pgto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPedido_compra, "PEDIDO_COMPRA.COND_PGTO_PED", true));
            this.tb_forma_pgto.Location = new System.Drawing.Point(122, 451);
            this.tb_forma_pgto.Name = "tb_forma_pgto";
            this.tb_forma_pgto.Size = new System.Drawing.Size(93, 20);
            this.tb_forma_pgto.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(575, 566);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(105, 24);
            this.label15.TabIndex = 130;
            this.label15.Text = "Valor Total:";
            // 
            // tb_valor_total
            // 
            this.tb_valor_total.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPedido_compra, "PEDIDO_COMPRA.VALOR_TOTAL_PED", true));
            this.tb_valor_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_valor_total.Location = new System.Drawing.Point(688, 563);
            this.tb_valor_total.Name = "tb_valor_total";
            this.tb_valor_total.Size = new System.Drawing.Size(138, 29);
            this.tb_valor_total.TabIndex = 129;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(688, 600);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(138, 30);
            this.button6.TabIndex = 20;
            this.button6.Text = "Calcular";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(695, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 202;
            this.label9.Text = "Valor Unitário";
            // 
            // tb_valor_unit
            // 
            this.tb_valor_unit.Location = new System.Drawing.Point(698, 239);
            this.tb_valor_unit.Name = "tb_valor_unit";
            this.tb_valor_unit.Size = new System.Drawing.Size(84, 20);
            this.tb_valor_unit.TabIndex = 14;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(690, 223);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(0, 13);
            this.label17.TabIndex = 204;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 428);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(106, 13);
            this.label18.TabIndex = 206;
            this.label18.Text = "Data Entrega/Retira:";
            // 
            // tb_data_entrega
            // 
            this.tb_data_entrega.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPedido_compra, "PEDIDO_COMPRA.DATA_RETIRA_PED", true));
            this.tb_data_entrega.Location = new System.Drawing.Point(122, 425);
            this.tb_data_entrega.Name = "tb_data_entrega";
            this.tb_data_entrega.Size = new System.Drawing.Size(93, 20);
            this.tb_data_entrega.TabIndex = 17;
            // 
            // datItens_req
            // 
            this.datItens_req.DeleteCommand = this.fbCommand12;
            this.datItens_req.InsertCommand = this.fbCommand10;
            this.datItens_req.SelectCommand = this.fbCommand9;
            this.datItens_req.UpdateCommand = this.fbCommand11;
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
            this.fbCommand9.CommandText = "select * from itens_requisicao";
            this.fbCommand9.CommandTimeout = 30;
            this.fbCommand9.Connection = this.fbConnection1;
            // 
            // fbCommand11
            // 
            this.fbCommand11.CommandTimeout = 30;
            // 
            // comando_select
            // 
            this.comando_select.CommandTimeout = 30;
            this.comando_select.Connection = this.fbConnection1;
            // 
            // dsItens_req
            // 
            this.dsItens_req.DataSetName = "dsItens_req";
            this.dsItens_req.Namespace = "http://www.tempuri.org/dsItens_req.xsd";
            this.dsItens_req.Tables.AddRange(new System.Data.DataTable[] {
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
            this.dataColumn7});
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
            // dataColumn7
            // 
            this.dataColumn7.ColumnName = "POSICAO_ITEM_REQ";
            this.dataColumn7.MaxLength = 50;
            // 
            // datFornecedores
            // 
            this.datFornecedores.DeleteCommand = this.fbCommand16;
            this.datFornecedores.InsertCommand = this.fbCommand14;
            this.datFornecedores.SelectCommand = this.fbCommand13;
            this.datFornecedores.UpdateCommand = this.fbCommand15;
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
            this.fbCommand13.CommandText = "select * from fornecedores";
            this.fbCommand13.CommandTimeout = 30;
            this.fbCommand13.Connection = this.fbConnection1;
            // 
            // fbCommand15
            // 
            this.fbCommand15.CommandTimeout = 30;
            // 
            // dsFornecedores
            // 
            this.dsFornecedores.DataSetName = "dsFornecedores";
            this.dsFornecedores.Namespace = "http://www.tempuri.org/dsFornecedores.xsd";
            this.dsFornecedores.Tables.AddRange(new System.Data.DataTable[] {
            this.FORNECEDORES});
            // 
            // FORNECEDORES
            // 
            this.FORNECEDORES.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_FORN,
            this.RAZAO_SOCIAL_FORN,
            this.NOME_FANTASIA_FORN,
            this.TIPO_MATERIAL,
            this.TIPO_MATERIAL_2,
            this.TIPO_MATERIAL_3,
            this.TIPO_MATERIAL_4,
            this.CNPJ_CPF_FORN,
            this.IE_RG_FORN,
            this.ENDERECO_FORN,
            this.BAIRRO_FORN,
            this.CIDADE_FORN,
            this.CEP_FORN,
            this.ESTADO_FORN,
            this.PAIS_FORN,
            this.EMAIL_FORN,
            this.TEL_FORN,
            this.CONTATO_FORN,
            this.TEL_CONTATO_FORN,
            this.EMAIL_CONTATO_FORN,
            this.OUTRAS_INF_FORN,
            this.ISO_FORN,
            this.VALIDADE_ISO_FORN,
            this.CERT_UNI_FORN,
            this.VALIDADE_CERT_UNI_FORN,
            this.NOTA_CERT_UNI_FORN});
            this.FORNECEDORES.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_FORN"}, true)});
            this.FORNECEDORES.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_FORN};
            this.FORNECEDORES.TableName = "FORNECEDORES";
            // 
            // COD_FORN
            // 
            this.COD_FORN.AllowDBNull = false;
            this.COD_FORN.ColumnName = "COD_FORN";
            this.COD_FORN.DataType = typeof(int);
            // 
            // RAZAO_SOCIAL_FORN
            // 
            this.RAZAO_SOCIAL_FORN.ColumnName = "RAZAO_SOCIAL_FORN";
            this.RAZAO_SOCIAL_FORN.MaxLength = 80;
            // 
            // NOME_FANTASIA_FORN
            // 
            this.NOME_FANTASIA_FORN.ColumnName = "NOME_FANTASIA_FORN";
            this.NOME_FANTASIA_FORN.MaxLength = 80;
            // 
            // TIPO_MATERIAL
            // 
            this.TIPO_MATERIAL.ColumnName = "TIPO_MATERIAL";
            this.TIPO_MATERIAL.MaxLength = 50;
            // 
            // TIPO_MATERIAL_2
            // 
            this.TIPO_MATERIAL_2.ColumnName = "TIPO_MATERIAL_2";
            this.TIPO_MATERIAL_2.MaxLength = 50;
            // 
            // TIPO_MATERIAL_3
            // 
            this.TIPO_MATERIAL_3.ColumnName = "TIPO_MATERIAL_3";
            this.TIPO_MATERIAL_3.MaxLength = 50;
            // 
            // TIPO_MATERIAL_4
            // 
            this.TIPO_MATERIAL_4.ColumnName = "TIPO_MATERIAL_4";
            this.TIPO_MATERIAL_4.MaxLength = 50;
            // 
            // CNPJ_CPF_FORN
            // 
            this.CNPJ_CPF_FORN.ColumnName = "CNPJ_CPF_FORN";
            this.CNPJ_CPF_FORN.MaxLength = 20;
            // 
            // IE_RG_FORN
            // 
            this.IE_RG_FORN.ColumnName = "IE_RG_FORN";
            this.IE_RG_FORN.MaxLength = 20;
            // 
            // ENDERECO_FORN
            // 
            this.ENDERECO_FORN.ColumnName = "ENDERECO_FORN";
            this.ENDERECO_FORN.MaxLength = 80;
            // 
            // BAIRRO_FORN
            // 
            this.BAIRRO_FORN.ColumnName = "BAIRRO_FORN";
            this.BAIRRO_FORN.MaxLength = 50;
            // 
            // CIDADE_FORN
            // 
            this.CIDADE_FORN.ColumnName = "CIDADE_FORN";
            this.CIDADE_FORN.MaxLength = 50;
            // 
            // CEP_FORN
            // 
            this.CEP_FORN.ColumnName = "CEP_FORN";
            this.CEP_FORN.MaxLength = 15;
            // 
            // ESTADO_FORN
            // 
            this.ESTADO_FORN.ColumnName = "ESTADO_FORN";
            this.ESTADO_FORN.MaxLength = 2;
            // 
            // PAIS_FORN
            // 
            this.PAIS_FORN.ColumnName = "PAIS_FORN";
            this.PAIS_FORN.MaxLength = 30;
            // 
            // EMAIL_FORN
            // 
            this.EMAIL_FORN.ColumnName = "EMAIL_FORN";
            this.EMAIL_FORN.MaxLength = 50;
            // 
            // TEL_FORN
            // 
            this.TEL_FORN.ColumnName = "TEL_FORN";
            this.TEL_FORN.MaxLength = 20;
            // 
            // CONTATO_FORN
            // 
            this.CONTATO_FORN.ColumnName = "CONTATO_FORN";
            this.CONTATO_FORN.MaxLength = 50;
            // 
            // TEL_CONTATO_FORN
            // 
            this.TEL_CONTATO_FORN.ColumnName = "TEL_CONTATO_FORN";
            this.TEL_CONTATO_FORN.MaxLength = 20;
            // 
            // EMAIL_CONTATO_FORN
            // 
            this.EMAIL_CONTATO_FORN.ColumnName = "EMAIL_CONTATO_FORN";
            this.EMAIL_CONTATO_FORN.MaxLength = 50;
            // 
            // OUTRAS_INF_FORN
            // 
            this.OUTRAS_INF_FORN.ColumnName = "OUTRAS_INF_FORN";
            this.OUTRAS_INF_FORN.MaxLength = 300;
            // 
            // ISO_FORN
            // 
            this.ISO_FORN.ColumnName = "ISO_FORN";
            this.ISO_FORN.DataType = typeof(int);
            // 
            // VALIDADE_ISO_FORN
            // 
            this.VALIDADE_ISO_FORN.ColumnName = "VALIDADE_ISO_FORN";
            this.VALIDADE_ISO_FORN.DataType = typeof(System.DateTime);
            // 
            // CERT_UNI_FORN
            // 
            this.CERT_UNI_FORN.ColumnName = "CERT_UNI_FORN";
            this.CERT_UNI_FORN.DataType = typeof(int);
            // 
            // VALIDADE_CERT_UNI_FORN
            // 
            this.VALIDADE_CERT_UNI_FORN.ColumnName = "VALIDADE_CERT_UNI_FORN";
            this.VALIDADE_CERT_UNI_FORN.DataType = typeof(System.DateTime);
            // 
            // NOTA_CERT_UNI_FORN
            // 
            this.NOTA_CERT_UNI_FORN.ColumnName = "NOTA_CERT_UNI_FORN";
            this.NOTA_CERT_UNI_FORN.DataType = typeof(double);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(296, 15);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(98, 30);
            this.button7.TabIndex = 19;
            this.button7.Text = "Liberar Pedido";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 208;
            this.label5.Text = "Nome Autorizante:";
            // 
            // tb_nome_autorizante
            // 
            this.tb_nome_autorizante.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPedido_compra, "PEDIDO_COMPRA.NOME_AUTORIZANTE_PED", true));
            this.tb_nome_autorizante.Location = new System.Drawing.Point(12, 70);
            this.tb_nome_autorizante.Name = "tb_nome_autorizante";
            this.tb_nome_autorizante.ReadOnly = true;
            this.tb_nome_autorizante.Size = new System.Drawing.Size(185, 20);
            this.tb_nome_autorizante.TabIndex = 209;
            // 
            // tb_data_autorizacao
            // 
            this.tb_data_autorizacao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPedido_compra, "PEDIDO_COMPRA.DATA_AUTORIZACAO_PED", true));
            this.tb_data_autorizacao.Location = new System.Drawing.Point(203, 70);
            this.tb_data_autorizacao.Name = "tb_data_autorizacao";
            this.tb_data_autorizacao.ReadOnly = true;
            this.tb_data_autorizacao.Size = new System.Drawing.Size(87, 20);
            this.tb_data_autorizacao.TabIndex = 211;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(199, 54);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(91, 13);
            this.label19.TabIndex = 210;
            this.label19.Text = "Data Autorização:";
            // 
            // tb_hora_autorizacao
            // 
            this.tb_hora_autorizacao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPedido_compra, "PEDIDO_COMPRA.HORA_AUTORIZACAO_PED", true));
            this.tb_hora_autorizacao.Location = new System.Drawing.Point(296, 70);
            this.tb_hora_autorizacao.Name = "tb_hora_autorizacao";
            this.tb_hora_autorizacao.ReadOnly = true;
            this.tb_hora_autorizacao.Size = new System.Drawing.Size(87, 20);
            this.tb_hora_autorizacao.TabIndex = 213;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(292, 54);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(90, 13);
            this.label21.TabIndex = 212;
            this.label21.Text = "Hora Autorização:";
            // 
            // cbAutorizado
            // 
            this.cbAutorizado.AutoSize = true;
            this.cbAutorizado.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsPedido_compra, "PEDIDO_COMPRA.AUTORIZADO_PED", true));
            this.cbAutorizado.Location = new System.Drawing.Point(12, 17);
            this.cbAutorizado.Name = "cbAutorizado";
            this.cbAutorizado.Size = new System.Drawing.Size(169, 17);
            this.cbAutorizado.TabIndex = 214;
            this.cbAutorizado.Text = "Pedido de Compra Autorizado:";
            this.cbAutorizado.UseVisualStyleBackColor = true;
            // 
            // bt_enviar_email
            // 
            this.bt_enviar_email.Location = new System.Drawing.Point(397, 51);
            this.bt_enviar_email.Name = "bt_enviar_email";
            this.bt_enviar_email.Size = new System.Drawing.Size(152, 30);
            this.bt_enviar_email.TabIndex = 21;
            this.bt_enviar_email.Text = "Email";
            this.bt_enviar_email.UseVisualStyleBackColor = true;
            this.bt_enviar_email.Visible = false;
            this.bt_enviar_email.Click += new System.EventHandler(this.bt_enviar_email_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button12);
            this.groupBox2.Controls.Add(this.btnLiberar);
            this.groupBox2.Controls.Add(this.cb_efetuado);
            this.groupBox2.Controls.Add(this.bt_enviar_email);
            this.groupBox2.Controls.Add(this.cbAutorizado);
            this.groupBox2.Controls.Add(this.tb_hora_autorizacao);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.tb_data_autorizacao);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.tb_nome_autorizante);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.bt_imprimir);
            this.groupBox2.Location = new System.Drawing.Point(12, 556);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(561, 124);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Liberação";
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(181, 15);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(109, 30);
            this.button12.TabIndex = 217;
            this.button12.Text = "Retirar Autorização";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // btnLiberar
            // 
            this.btnLiberar.Location = new System.Drawing.Point(397, 87);
            this.btnLiberar.Name = "btnLiberar";
            this.btnLiberar.Size = new System.Drawing.Size(152, 31);
            this.btnLiberar.TabIndex = 216;
            this.btnLiberar.Text = "Apagar Liberações";
            this.btnLiberar.UseVisualStyleBackColor = true;
            this.btnLiberar.Click += new System.EventHandler(this.btnLiberar_Click);
            // 
            // cb_efetuado
            // 
            this.cb_efetuado.AutoSize = true;
            this.cb_efetuado.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsPedido_compra, "PEDIDO_COMPRA.EFETUADO_PED", true));
            this.cb_efetuado.Location = new System.Drawing.Point(12, 34);
            this.cb_efetuado.Name = "cb_efetuado";
            this.cb_efetuado.Size = new System.Drawing.Size(162, 17);
            this.cb_efetuado.TabIndex = 215;
            this.cb_efetuado.Text = "Pedido de Compra Efetuado:";
            this.cb_efetuado.UseVisualStyleBackColor = true;
            // 
            // cb_descricai_maior
            // 
            this.cb_descricai_maior.AutoSize = true;
            this.cb_descricai_maior.Location = new System.Drawing.Point(580, 600);
            this.cb_descricai_maior.Name = "cb_descricai_maior";
            this.cb_descricai_maior.Size = new System.Drawing.Size(100, 30);
            this.cb_descricai_maior.TabIndex = 217;
            this.cb_descricai_maior.Text = "Impressão com \r\ndescrição maior";
            this.cb_descricai_maior.UseVisualStyleBackColor = true;
            this.cb_descricai_maior.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(9, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 32);
            this.button1.TabIndex = 207;
            this.button1.Text = "Inserir Requisição Completa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_n_requisicao
            // 
            this.tb_n_requisicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_n_requisicao.Location = new System.Drawing.Point(83, 188);
            this.tb_n_requisicao.Name = "tb_n_requisicao";
            this.tb_n_requisicao.Size = new System.Drawing.Size(151, 32);
            this.tb_n_requisicao.TabIndex = 208;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barra_status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 700);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(850, 22);
            this.statusStrip1.TabIndex = 251;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // barra_status
            // 
            this.barra_status.Name = "barra_status";
            this.barra_status.Size = new System.Drawing.Size(70, 17);
            this.barra_status.Text = "Status Atual";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(440, 102);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(32, 13);
            this.label22.TabIndex = 74;
            this.label22.Text = "Obs.:";
            // 
            // tb_obs
            // 
            this.tb_obs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPedido_compra, "PEDIDO_COMPRA.OBS_PEDIDO_COMPRA", true));
            this.tb_obs.Location = new System.Drawing.Point(506, 99);
            this.tb_obs.Multiline = true;
            this.tb_obs.Name = "tb_obs";
            this.tb_obs.Size = new System.Drawing.Size(307, 38);
            this.tb_obs.TabIndex = 73;
            // 
            // datEmails_enviados
            // 
            this.datEmails_enviados.DeleteCommand = this.fbCommand20;
            this.datEmails_enviados.InsertCommand = this.fbCommand18;
            this.datEmails_enviados.SelectCommand = this.fbCommand17;
            this.datEmails_enviados.UpdateCommand = this.fbCommand19;
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
            this.fbCommand17.CommandText = "select * from emails_enviados";
            this.fbCommand17.CommandTimeout = 30;
            this.fbCommand17.Connection = this.fbConnection1;
            // 
            // fbCommand19
            // 
            this.fbCommand19.CommandTimeout = 30;
            // 
            // dsEmails_enviados
            // 
            this.dsEmails_enviados.DataSetName = "dsEmails_enviados";
            this.dsEmails_enviados.Namespace = "http://www.tempuri.org/dsEmails_enviados.xsd";
            this.dsEmails_enviados.Tables.AddRange(new System.Data.DataTable[] {
            this.EMAILS_ENVIADOS});
            // 
            // EMAILS_ENVIADOS
            // 
            this.EMAILS_ENVIADOS.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_EMAIL_ENVIADO,
            this.DESTINATARIO_EMAIL_ENVIADO,
            this.DATA_EMAIL_ENVIADO,
            this.TIPO_EMAIL_ENVIADO,
            this.HORA_EMAIL_ENVIADO,
            this.CAMINHO_ARQUIVO_EMAIL_ENVIADO});
            this.EMAILS_ENVIADOS.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_EMAIL_ENVIADO"}, true)});
            this.EMAILS_ENVIADOS.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_EMAIL_ENVIADO};
            this.EMAILS_ENVIADOS.TableName = "EMAILS_ENVIADOS";
            // 
            // COD_EMAIL_ENVIADO
            // 
            this.COD_EMAIL_ENVIADO.AllowDBNull = false;
            this.COD_EMAIL_ENVIADO.ColumnName = "COD_EMAIL_ENVIADO";
            this.COD_EMAIL_ENVIADO.DataType = typeof(int);
            // 
            // DESTINATARIO_EMAIL_ENVIADO
            // 
            this.DESTINATARIO_EMAIL_ENVIADO.ColumnName = "DESTINATARIO_EMAIL_ENVIADO";
            this.DESTINATARIO_EMAIL_ENVIADO.MaxLength = 100;
            // 
            // DATA_EMAIL_ENVIADO
            // 
            this.DATA_EMAIL_ENVIADO.ColumnName = "DATA_EMAIL_ENVIADO";
            this.DATA_EMAIL_ENVIADO.DataType = typeof(System.DateTime);
            // 
            // TIPO_EMAIL_ENVIADO
            // 
            this.TIPO_EMAIL_ENVIADO.ColumnName = "TIPO_EMAIL_ENVIADO";
            this.TIPO_EMAIL_ENVIADO.MaxLength = 100;
            // 
            // HORA_EMAIL_ENVIADO
            // 
            this.HORA_EMAIL_ENVIADO.ColumnName = "HORA_EMAIL_ENVIADO";
            this.HORA_EMAIL_ENVIADO.DataType = typeof(System.DateTime);
            // 
            // CAMINHO_ARQUIVO_EMAIL_ENVIADO
            // 
            this.CAMINHO_ARQUIVO_EMAIL_ENVIADO.ColumnName = "CAMINHO_ARQUIVO_EMAIL_ENVIADO";
            this.CAMINHO_ARQUIVO_EMAIL_ENVIADO.MaxLength = 100;
            // 
            // dgvItens_ped
            // 
            this.dgvItens_ped.AllowUserToAddRows = false;
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
            this.cODITEMPEDDataGridViewTextBoxColumn,
            this.nPEDIDOITEMPEDDataGridViewTextBoxColumn,
            this.col_item_req,
            this.col_cod_estoque,
            this.ITEM_ITEM_PED,
            this.dESCRICAOITEMPEDDataGridViewTextBoxColumn,
            this.oPITEMPEDDataGridViewTextBoxColumn,
            this.POSICAO_ITEM_PED,
            this.col_peso,
            this.col_qtde,
            this.uNIDITEMPEDDataGridViewTextBoxColumn,
            this.col_valor_unit,
            this.col_valor_total,
            this.col_frete,
            this.Req,
            this.dATALIMITEITEMPEDDataGridViewTextBoxColumn,
            this.col_chegou,
            this.col_nf,
            this.col_data_chegada,
            this.col_resp_chegada});
            this.dgvItens_ped.DataMember = "ITENS_PEDIDO_COMPRA";
            this.dgvItens_ped.DataSource = this.dsItens_ped;
            this.dgvItens_ped.Location = new System.Drawing.Point(12, 265);
            this.dgvItens_ped.Name = "dgvItens_ped";
            this.dgvItens_ped.Size = new System.Drawing.Size(812, 150);
            this.dgvItens_ped.TabIndex = 100;
            this.dgvItens_ped.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItens_ped_CellContentClick);
            // 
            // cODITEMPEDDataGridViewTextBoxColumn
            // 
            this.cODITEMPEDDataGridViewTextBoxColumn.DataPropertyName = "COD_ITEM_PED";
            this.cODITEMPEDDataGridViewTextBoxColumn.HeaderText = "Cód.";
            this.cODITEMPEDDataGridViewTextBoxColumn.Name = "cODITEMPEDDataGridViewTextBoxColumn";
            this.cODITEMPEDDataGridViewTextBoxColumn.Width = 30;
            // 
            // nPEDIDOITEMPEDDataGridViewTextBoxColumn
            // 
            this.nPEDIDOITEMPEDDataGridViewTextBoxColumn.DataPropertyName = "N_PEDIDO_ITEM_PED";
            this.nPEDIDOITEMPEDDataGridViewTextBoxColumn.HeaderText = "Nº Item Pedido";
            this.nPEDIDOITEMPEDDataGridViewTextBoxColumn.Name = "nPEDIDOITEMPEDDataGridViewTextBoxColumn";
            this.nPEDIDOITEMPEDDataGridViewTextBoxColumn.Visible = false;
            this.nPEDIDOITEMPEDDataGridViewTextBoxColumn.Width = 85;
            // 
            // col_item_req
            // 
            this.col_item_req.DataPropertyName = "COD_ITEM_REQ_ITEM_PED";
            this.col_item_req.HeaderText = "Nº Item Requisição";
            this.col_item_req.Name = "col_item_req";
            this.col_item_req.Width = 85;
            // 
            // col_cod_estoque
            // 
            this.col_cod_estoque.DataPropertyName = "COD_ESTOQUE_ITEM_PED";
            this.col_cod_estoque.HeaderText = "Cód. Estoque";
            this.col_cod_estoque.Name = "col_cod_estoque";
            this.col_cod_estoque.Width = 70;
            // 
            // ITEM_ITEM_PED
            // 
            this.ITEM_ITEM_PED.DataPropertyName = "ITEM_ITEM_PED";
            this.ITEM_ITEM_PED.HeaderText = "Item";
            this.ITEM_ITEM_PED.Name = "ITEM_ITEM_PED";
            this.ITEM_ITEM_PED.Width = 70;
            // 
            // dESCRICAOITEMPEDDataGridViewTextBoxColumn
            // 
            this.dESCRICAOITEMPEDDataGridViewTextBoxColumn.DataPropertyName = "DESCRICAO_ITEM_PED";
            this.dESCRICAOITEMPEDDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.dESCRICAOITEMPEDDataGridViewTextBoxColumn.Name = "dESCRICAOITEMPEDDataGridViewTextBoxColumn";
            this.dESCRICAOITEMPEDDataGridViewTextBoxColumn.Width = 185;
            // 
            // oPITEMPEDDataGridViewTextBoxColumn
            // 
            this.oPITEMPEDDataGridViewTextBoxColumn.DataPropertyName = "OP_ITEM_PED";
            this.oPITEMPEDDataGridViewTextBoxColumn.HeaderText = "OS";
            this.oPITEMPEDDataGridViewTextBoxColumn.Name = "oPITEMPEDDataGridViewTextBoxColumn";
            this.oPITEMPEDDataGridViewTextBoxColumn.Width = 40;
            // 
            // POSICAO_ITEM_PED
            // 
            this.POSICAO_ITEM_PED.DataPropertyName = "POSICAO_ITEM_PED";
            this.POSICAO_ITEM_PED.HeaderText = "Pos";
            this.POSICAO_ITEM_PED.Name = "POSICAO_ITEM_PED";
            this.POSICAO_ITEM_PED.Width = 40;
            // 
            // col_peso
            // 
            this.col_peso.DataPropertyName = "PESO_ITEM_PED";
            this.col_peso.HeaderText = "Peso";
            this.col_peso.Name = "col_peso";
            this.col_peso.Width = 40;
            // 
            // col_qtde
            // 
            this.col_qtde.DataPropertyName = "QTDE_ITEM_PED";
            this.col_qtde.HeaderText = "Qtde";
            this.col_qtde.Name = "col_qtde";
            this.col_qtde.Width = 80;
            // 
            // uNIDITEMPEDDataGridViewTextBoxColumn
            // 
            this.uNIDITEMPEDDataGridViewTextBoxColumn.DataPropertyName = "UNID_ITEM_PED";
            this.uNIDITEMPEDDataGridViewTextBoxColumn.HeaderText = "Unid.";
            this.uNIDITEMPEDDataGridViewTextBoxColumn.Name = "uNIDITEMPEDDataGridViewTextBoxColumn";
            this.uNIDITEMPEDDataGridViewTextBoxColumn.Width = 40;
            // 
            // col_valor_unit
            // 
            this.col_valor_unit.DataPropertyName = "VALOR_UNIT_ITEM_PED";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.col_valor_unit.DefaultCellStyle = dataGridViewCellStyle2;
            this.col_valor_unit.HeaderText = "Valor Unit.";
            this.col_valor_unit.Name = "col_valor_unit";
            this.col_valor_unit.Width = 90;
            // 
            // col_valor_total
            // 
            this.col_valor_total.DataPropertyName = "VALOR_TOTAL_ITEM_PED";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.col_valor_total.DefaultCellStyle = dataGridViewCellStyle3;
            this.col_valor_total.HeaderText = "Valor Total";
            this.col_valor_total.Name = "col_valor_total";
            this.col_valor_total.Width = 90;
            // 
            // col_frete
            // 
            this.col_frete.DataPropertyName = "FRETE_ITEM_PED";
            this.col_frete.HeaderText = "Frete";
            this.col_frete.Name = "col_frete";
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
            // col_nf
            // 
            this.col_nf.DataPropertyName = "COD_NF_ENTRADA_ITEM_PED";
            this.col_nf.HeaderText = "Cód. NF Entrada";
            this.col_nf.Name = "col_nf";
            // 
            // col_data_chegada
            // 
            this.col_data_chegada.DataPropertyName = "DATA_CHEGADA_ITEM_PED";
            this.col_data_chegada.HeaderText = "Data Chegada";
            this.col_data_chegada.Name = "col_data_chegada";
            // 
            // col_resp_chegada
            // 
            this.col_resp_chegada.DataPropertyName = "RESP_CHEGADA_ITEM_PED";
            this.col_resp_chegada.HeaderText = "Resp. Chegada";
            this.col_resp_chegada.Name = "col_resp_chegada";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(532, 223);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(25, 13);
            this.label23.TabIndex = 255;
            this.label23.Text = "Pos";
            // 
            // tb_pos
            // 
            this.tb_pos.Location = new System.Drawing.Point(533, 239);
            this.tb_pos.Name = "tb_pos";
            this.tb_pos.Size = new System.Drawing.Size(40, 20);
            this.tb_pos.TabIndex = 10;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(498, 223);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(22, 13);
            this.label24.TabIndex = 254;
            this.label24.Text = "OS";
            // 
            // tb_os
            // 
            this.tb_os.Location = new System.Drawing.Point(494, 239);
            this.tb_os.Name = "tb_os";
            this.tb_os.Size = new System.Drawing.Size(38, 20);
            this.tb_os.TabIndex = 9;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(440, 165);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(37, 13);
            this.label25.TabIndex = 74;
            this.label25.Text = "Plano:";
            // 
            // tb_planos
            // 
            this.tb_planos.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPedido_compra, "PEDIDO_COMPRA.PLANO_PED", true));
            this.tb_planos.Location = new System.Drawing.Point(506, 162);
            this.tb_planos.Name = "tb_planos";
            this.tb_planos.ReadOnly = true;
            this.tb_planos.Size = new System.Drawing.Size(192, 20);
            this.tb_planos.TabIndex = 73;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(699, 160);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(25, 23);
            this.button8.TabIndex = 256;
            this.button8.Text = "+";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(237, 223);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(27, 13);
            this.label26.TabIndex = 258;
            this.label26.Text = "Item";
            // 
            // tb_item_item
            // 
            this.tb_item_item.Location = new System.Drawing.Point(241, 239);
            this.tb_item_item.Name = "tb_item_item";
            this.tb_item_item.Size = new System.Drawing.Size(68, 20);
            this.tb_item_item.TabIndex = 257;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.tb_valor_real_ipi);
            this.groupBox4.Controls.Add(this.label28);
            this.groupBox4.Controls.Add(this.textBox5);
            this.groupBox4.Location = new System.Drawing.Point(563, 425);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(276, 61);
            this.groupBox4.TabIndex = 261;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "IPI";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 261;
            this.label6.Text = "Valor:";
            // 
            // tb_valor_real_ipi
            // 
            this.tb_valor_real_ipi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPedido_compra, "PEDIDO_COMPRA.VALOR_REAL_IPI_PED", true));
            this.tb_valor_real_ipi.Location = new System.Drawing.Point(125, 35);
            this.tb_valor_real_ipi.Name = "tb_valor_real_ipi";
            this.tb_valor_real_ipi.Size = new System.Drawing.Size(138, 20);
            this.tb_valor_real_ipi.TabIndex = 25;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(15, 16);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(55, 13);
            this.label28.TabIndex = 260;
            this.label28.Text = "Descrição";
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPedido_compra, "PEDIDO_COMPRA.VALOR_IPI_PED", true));
            this.textBox5.Location = new System.Drawing.Point(125, 13);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(138, 20);
            this.textBox5.TabIndex = 24;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.tb_valor_outras_desp);
            this.groupBox3.Controls.Add(this.label27);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Location = new System.Drawing.Point(281, 425);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(276, 61);
            this.groupBox3.TabIndex = 259;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Outras Despesas";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 38);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 13);
            this.label14.TabIndex = 261;
            this.label14.Text = "Valor:";
            // 
            // tb_valor_outras_desp
            // 
            this.tb_valor_outras_desp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPedido_compra, "PEDIDO_COMPRA.VALOR_OUTRAS_DESP_PED", true));
            this.tb_valor_outras_desp.Location = new System.Drawing.Point(125, 35);
            this.tb_valor_outras_desp.Name = "tb_valor_outras_desp";
            this.tb_valor_outras_desp.Size = new System.Drawing.Size(138, 20);
            this.tb_valor_outras_desp.TabIndex = 21;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(15, 16);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(55, 13);
            this.label27.TabIndex = 260;
            this.label27.Text = "Descrição";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPedido_compra, "PEDIDO_COMPRA.DESCRICAO_OUTRAS_DESP_PED", true));
            this.textBox2.Location = new System.Drawing.Point(125, 13);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(138, 20);
            this.textBox2.TabIndex = 20;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(294, 533);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(87, 13);
            this.label29.TabIndex = 262;
            this.label29.Text = "Descrição ICMS:";
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPedido_compra, "PEDIDO_COMPRA.VALOR_ICMS_PED", true));
            this.textBox7.Location = new System.Drawing.Point(406, 530);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(138, 20);
            this.textBox7.TabIndex = 260;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(577, 223);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(31, 13);
            this.label30.TabIndex = 264;
            this.label30.Text = "Peso";
            // 
            // tb_peso
            // 
            this.tb_peso.Location = new System.Drawing.Point(575, 239);
            this.tb_peso.Name = "tb_peso";
            this.tb_peso.Size = new System.Drawing.Size(38, 20);
            this.tb_peso.TabIndex = 11;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(576, 533);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(56, 13);
            this.label31.TabIndex = 266;
            this.label31.Text = "Desconto:";
            // 
            // tb_desconto
            // 
            this.tb_desconto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPedido_compra, "PEDIDO_COMPRA.DESCONTO_PED", true));
            this.tb_desconto.Location = new System.Drawing.Point(688, 530);
            this.tb_desconto.Name = "tb_desconto";
            this.tb_desconto.Size = new System.Drawing.Size(138, 20);
            this.tb_desconto.TabIndex = 265;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(440, 143);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(65, 13);
            this.label32.TabIndex = 268;
            this.label32.Text = "Justificativa:";
            // 
            // tb_justificativa
            // 
            this.tb_justificativa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPedido_compra, "PEDIDO_COMPRA.JUSTIFICATIVA_PED", true));
            this.tb_justificativa.Location = new System.Drawing.Point(506, 140);
            this.tb_justificativa.Name = "tb_justificativa";
            this.tb_justificativa.Size = new System.Drawing.Size(307, 20);
            this.tb_justificativa.TabIndex = 267;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(699, 197);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(125, 23);
            this.button9.TabIndex = 269;
            this.button9.Text = "Replicar Entradas";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(241, 188);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(23, 32);
            this.button10.TabIndex = 270;
            this.button10.Text = "+";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(801, 633);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(23, 23);
            this.button26.TabIndex = 367;
            this.button26.Text = "+";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.button26_Click);
            // 
            // tb_descricao_empresa
            // 
            this.tb_descricao_empresa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPedido_compra, "PEDIDO_COMPRA.RAZAO_EMISSOR_PED", true));
            this.tb_descricao_empresa.Location = new System.Drawing.Point(575, 660);
            this.tb_descricao_empresa.Name = "tb_descricao_empresa";
            this.tb_descricao_empresa.ReadOnly = true;
            this.tb_descricao_empresa.Size = new System.Drawing.Size(249, 20);
            this.tb_descricao_empresa.TabIndex = 369;
            // 
            // tb_cnpj_empresa
            // 
            this.tb_cnpj_empresa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPedido_compra, "PEDIDO_COMPRA.CNPJ_EMISSOR_PED", true));
            this.tb_cnpj_empresa.Location = new System.Drawing.Point(627, 636);
            this.tb_cnpj_empresa.Name = "tb_cnpj_empresa";
            this.tb_cnpj_empresa.ReadOnly = true;
            this.tb_cnpj_empresa.Size = new System.Drawing.Size(166, 20);
            this.tb_cnpj_empresa.TabIndex = 368;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(572, 639);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(51, 13);
            this.label39.TabIndex = 370;
            this.label39.Text = "Empresa:";
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(221, 449);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(25, 23);
            this.button11.TabIndex = 371;
            this.button11.Text = "+";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // datFatura_pc
            // 
            this.datFatura_pc.DeleteCommand = this.fbCommand24;
            this.datFatura_pc.InsertCommand = this.fbCommand22;
            this.datFatura_pc.SelectCommand = this.fbCommand21;
            this.datFatura_pc.UpdateCommand = this.fbCommand23;
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
            this.fbCommand21.CommandText = "SELECT * FROM FATURA_PC";
            this.fbCommand21.CommandTimeout = 30;
            this.fbCommand21.Connection = this.fbConnection1;
            // 
            // fbCommand23
            // 
            this.fbCommand23.CommandTimeout = 30;
            // 
            // dsFatura_pc
            // 
            this.dsFatura_pc.DataSetName = "dsFatura_pc";
            this.dsFatura_pc.Namespace = "http://www.tempuri.org/dsFatura_pc.xsd";
            this.dsFatura_pc.Tables.AddRange(new System.Data.DataTable[] {
            this.FATURA_PC});
            // 
            // FATURA_PC
            // 
            this.FATURA_PC.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_FATURA_PC,
            this.PRAZO_FATURA_PC,
            this.DATA_VENC_FATURA_PC,
            this.VALOR_FATURA_PC,
            this.N_PEDIDO_FATURA_PC,
            this.CR_FATURA_PC});
            this.FATURA_PC.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_FATURA_PC"}, true)});
            this.FATURA_PC.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_FATURA_PC};
            this.FATURA_PC.TableName = "FATURA_PC";
            // 
            // COD_FATURA_PC
            // 
            this.COD_FATURA_PC.AllowDBNull = false;
            this.COD_FATURA_PC.ColumnName = "COD_FATURA_PC";
            this.COD_FATURA_PC.DataType = typeof(int);
            // 
            // PRAZO_FATURA_PC
            // 
            this.PRAZO_FATURA_PC.ColumnName = "PRAZO_FATURA_PC";
            this.PRAZO_FATURA_PC.DataType = typeof(int);
            // 
            // DATA_VENC_FATURA_PC
            // 
            this.DATA_VENC_FATURA_PC.ColumnName = "DATA_VENC_FATURA_PC";
            this.DATA_VENC_FATURA_PC.DataType = typeof(System.DateTime);
            // 
            // VALOR_FATURA_PC
            // 
            this.VALOR_FATURA_PC.ColumnName = "VALOR_FATURA_PC";
            this.VALOR_FATURA_PC.DataType = typeof(double);
            // 
            // N_PEDIDO_FATURA_PC
            // 
            this.N_PEDIDO_FATURA_PC.ColumnName = "N_PEDIDO_FATURA_PC";
            this.N_PEDIDO_FATURA_PC.DataType = typeof(int);
            // 
            // CR_FATURA_PC
            // 
            this.CR_FATURA_PC.ColumnName = "CR_FATURA_PC";
            this.CR_FATURA_PC.DataType = typeof(int);
            // 
            // fbCommand25
            // 
            this.fbCommand25.CommandText = "select * from fatura_pc";
            this.fbCommand25.CommandTimeout = 30;
            this.fbCommand25.Connection = this.fbConnection1;
            // 
            // fbCommand26
            // 
            this.fbCommand26.CommandTimeout = 30;
            // 
            // fbCommand27
            // 
            this.fbCommand27.CommandTimeout = 30;
            // 
            // fbCommand28
            // 
            this.fbCommand28.CommandTimeout = 30;
            // 
            // dgvFatura_pc
            // 
            this.dgvFatura_pc.AllowUserToAddRows = false;
            this.dgvFatura_pc.AutoGenerateColumns = false;
            this.dgvFatura_pc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFatura_pc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODFATURAPCDataGridViewTextBoxColumn,
            this.pRAZOFATURAPCDataGridViewTextBoxColumn,
            this.dATAVENCFATURAPCDataGridViewTextBoxColumn,
            this.vALORFATURAPCDataGridViewTextBoxColumn,
            this.nPEDIDOFATURAPCDataGridViewTextBoxColumn,
            this.cRFATURAPCDataGridViewTextBoxColumn});
            this.dgvFatura_pc.DataMember = "FATURA_PC";
            this.dgvFatura_pc.DataSource = this.dsFatura_pc;
            this.dgvFatura_pc.Location = new System.Drawing.Point(12, 478);
            this.dgvFatura_pc.Name = "dgvFatura_pc";
            this.dgvFatura_pc.RowHeadersWidth = 10;
            this.dgvFatura_pc.Size = new System.Drawing.Size(251, 78);
            this.dgvFatura_pc.TabIndex = 372;
            // 
            // cODFATURAPCDataGridViewTextBoxColumn
            // 
            this.cODFATURAPCDataGridViewTextBoxColumn.DataPropertyName = "COD_FATURA_PC";
            this.cODFATURAPCDataGridViewTextBoxColumn.HeaderText = "COD_FATURA_PC";
            this.cODFATURAPCDataGridViewTextBoxColumn.Name = "cODFATURAPCDataGridViewTextBoxColumn";
            this.cODFATURAPCDataGridViewTextBoxColumn.Visible = false;
            // 
            // pRAZOFATURAPCDataGridViewTextBoxColumn
            // 
            this.pRAZOFATURAPCDataGridViewTextBoxColumn.DataPropertyName = "PRAZO_FATURA_PC";
            this.pRAZOFATURAPCDataGridViewTextBoxColumn.HeaderText = "PRAZO_FATURA_PC";
            this.pRAZOFATURAPCDataGridViewTextBoxColumn.Name = "pRAZOFATURAPCDataGridViewTextBoxColumn";
            this.pRAZOFATURAPCDataGridViewTextBoxColumn.Visible = false;
            // 
            // dATAVENCFATURAPCDataGridViewTextBoxColumn
            // 
            this.dATAVENCFATURAPCDataGridViewTextBoxColumn.DataPropertyName = "DATA_VENC_FATURA_PC";
            this.dATAVENCFATURAPCDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dATAVENCFATURAPCDataGridViewTextBoxColumn.Name = "dATAVENCFATURAPCDataGridViewTextBoxColumn";
            // 
            // vALORFATURAPCDataGridViewTextBoxColumn
            // 
            this.vALORFATURAPCDataGridViewTextBoxColumn.DataPropertyName = "VALOR_FATURA_PC";
            this.vALORFATURAPCDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.vALORFATURAPCDataGridViewTextBoxColumn.Name = "vALORFATURAPCDataGridViewTextBoxColumn";
            this.vALORFATURAPCDataGridViewTextBoxColumn.Width = 85;
            // 
            // nPEDIDOFATURAPCDataGridViewTextBoxColumn
            // 
            this.nPEDIDOFATURAPCDataGridViewTextBoxColumn.DataPropertyName = "N_PEDIDO_FATURA_PC";
            this.nPEDIDOFATURAPCDataGridViewTextBoxColumn.HeaderText = "N_PEDIDO_FATURA_PC";
            this.nPEDIDOFATURAPCDataGridViewTextBoxColumn.Name = "nPEDIDOFATURAPCDataGridViewTextBoxColumn";
            this.nPEDIDOFATURAPCDataGridViewTextBoxColumn.Visible = false;
            // 
            // cRFATURAPCDataGridViewTextBoxColumn
            // 
            this.cRFATURAPCDataGridViewTextBoxColumn.DataPropertyName = "CR_FATURA_PC";
            this.cRFATURAPCDataGridViewTextBoxColumn.HeaderText = "CP";
            this.cRFATURAPCDataGridViewTextBoxColumn.Name = "cRFATURAPCDataGridViewTextBoxColumn";
            this.cRFATURAPCDataGridViewTextBoxColumn.Width = 60;
            // 
            // cbFatura_pc
            // 
            this.cbFatura_pc.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbFatura_pc.DataAdapter = this.datFatura_pc;
            this.cbFatura_pc.QuotePrefix = "\"";
            this.cbFatura_pc.QuoteSuffix = "\"";
            // 
            // form_pedido_compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 722);
            this.Controls.Add(this.dgvFatura_pc);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.tb_descricao_empresa);
            this.Controls.Add(this.tb_cnpj_empresa);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.cb_descricai_maior);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.tb_justificativa);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.tb_desconto);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.tb_peso);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.tb_item_item);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.tb_planos);
            this.Controls.Add(this.tb_pos);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.tb_os);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tb_obs);
            this.Controls.Add(this.tb_n_requisicao);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.tb_data_entrega);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_valor_unit);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tb_valor_total);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_forma_pgto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_unidade);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_cod_item);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tb_qtde);
            this.Controls.Add(this.tb_descricao_item);
            this.Controls.Add(this.tb_item_n_pedido);
            this.Controls.Add(this.bt_inserir);
            this.Controls.Add(this.dgvItens_ped);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_data_emissao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_n_pedido);
            this.Controls.Add(this.label20);
            this.Name = "form_pedido_compra";
            this.Text = "Pedido de Compra";
            this.Load += new System.EventHandler(this.form_pedido_compra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsPedido_compra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PEDIDO_COMPRA)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsItens_ped)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITENS_PEDIDO_COMPRA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsItens_req)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITENS_REQUISICAO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFornecedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FORNECEDORES)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsEmails_enviados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EMAILS_ENVIADOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens_ped)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsFatura_pc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FATURA_PC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFatura_pc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tb_n_pedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_data_emissao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_nome_forn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_localizar_forn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_cnpj_forn;
        private System.Windows.Forms.Button bt_imprimir;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datPedido_compra;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private System.Data.DataSet dsPedido_compra;
        private System.Data.DataTable PEDIDO_COMPRA;
        private System.Data.DataColumn COD_PED;
        private System.Data.DataColumn N_PED;
        private System.Data.DataColumn DATA_EMISSAO_PED;
        private System.Data.DataColumn NOME_FORN_PED;
        private System.Data.DataColumn CNPJ_FORN_PED;
        private System.Data.DataColumn COND_PGTO_PED;
        private System.Data.DataColumn DATA_RETIRA_PED;
        private System.Data.DataColumn CUSTO_FINANC_PED;
        private System.Data.DataColumn VALOR_PARCIAL_PED;
        private System.Data.DataColumn VALOR_IPI_PED;
        private System.Data.DataColumn VALOR_ICMS_PED;
        private System.Data.DataColumn VALOR_TOTAL_PED;
        private System.Data.DataColumn AUTORIZADO_PED;
        private System.Data.DataColumn DATA_AUTORIZACAO_PED;
        private System.Data.DataColumn HORA_AUTORIZACAO_PED;
        private System.Data.DataColumn COD_AUTORIZANTE_PED;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbPedido_compra;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datItens_ped;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand8;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand6;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand5;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand7;
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
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbItens_ped;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_unidade;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_cod_item;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_qtde;
        private System.Windows.Forms.TextBox tb_descricao_item;
        private System.Windows.Forms.TextBox tb_item_n_pedido;
        private System.Windows.Forms.Button bt_inserir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_forma_pgto;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tb_valor_total;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_valor_unit;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tb_data_entrega;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datItens_req;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand12;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand10;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand9;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand11;
        private FirebirdSql.Data.FirebirdClient.FbCommand comando_select;
        private System.Data.DataSet dsItens_req;
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
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datFornecedores;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand16;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand14;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand13;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand15;
        private System.Data.DataSet dsFornecedores;
        private System.Data.DataTable FORNECEDORES;
        private System.Data.DataColumn COD_FORN;
        private System.Data.DataColumn RAZAO_SOCIAL_FORN;
        private System.Data.DataColumn NOME_FANTASIA_FORN;
        private System.Data.DataColumn TIPO_MATERIAL;
        private System.Data.DataColumn TIPO_MATERIAL_2;
        private System.Data.DataColumn TIPO_MATERIAL_3;
        private System.Data.DataColumn TIPO_MATERIAL_4;
        private System.Data.DataColumn CNPJ_CPF_FORN;
        private System.Data.DataColumn IE_RG_FORN;
        private System.Data.DataColumn ENDERECO_FORN;
        private System.Data.DataColumn BAIRRO_FORN;
        private System.Data.DataColumn CIDADE_FORN;
        private System.Data.DataColumn CEP_FORN;
        private System.Data.DataColumn ESTADO_FORN;
        private System.Data.DataColumn PAIS_FORN;
        private System.Data.DataColumn EMAIL_FORN;
        private System.Data.DataColumn TEL_FORN;
        private System.Data.DataColumn CONTATO_FORN;
        private System.Data.DataColumn TEL_CONTATO_FORN;
        private System.Data.DataColumn EMAIL_CONTATO_FORN;
        private System.Data.DataColumn OUTRAS_INF_FORN;
        private System.Data.DataColumn ISO_FORN;
        private System.Data.DataColumn VALIDADE_ISO_FORN;
        private System.Data.DataColumn CERT_UNI_FORN;
        private System.Data.DataColumn VALIDADE_CERT_UNI_FORN;
        private System.Data.DataColumn NOTA_CERT_UNI_FORN;
        private System.Data.DataColumn dataColumn1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_nome_autorizante;
        private System.Windows.Forms.TextBox tb_data_autorizacao;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tb_hora_autorizacao;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.CheckBox cbAutorizado;
        private System.Windows.Forms.Button bt_enviar_email;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_n_requisicao;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel barra_status;
        private System.Data.DataColumn dataColumn2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox tb_obs;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datEmails_enviados;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand20;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand18;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand17;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand19;
        private System.Data.DataSet dsEmails_enviados;
        private System.Data.DataTable EMAILS_ENVIADOS;
        private System.Data.DataColumn COD_EMAIL_ENVIADO;
        private System.Data.DataColumn DESTINATARIO_EMAIL_ENVIADO;
        private System.Data.DataColumn DATA_EMAIL_ENVIADO;
        private System.Data.DataColumn TIPO_EMAIL_ENVIADO;
        private System.Data.DataColumn HORA_EMAIL_ENVIADO;
        private System.Data.DataColumn CAMINHO_ARQUIVO_EMAIL_ENVIADO;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Windows.Forms.DataGridView dgvItens_ped;
        private System.Data.DataColumn dataColumn6;
        private System.Data.DataColumn dataColumn7;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox tb_pos;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox tb_os;
        private System.Windows.Forms.CheckBox cb_efetuado;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox tb_planos;
        private System.Windows.Forms.Button button8;
        private System.Data.DataColumn dataColumn8;
        private System.Data.DataColumn dataColumn9;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox tb_item_item;
        private System.Data.DataColumn dataColumn10;
        private System.Data.DataColumn dataColumn11;
        private System.Data.DataColumn dataColumn12;
        private System.Data.DataColumn dataColumn13;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_valor_real_ipi;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tb_valor_outras_desp;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox textBox7;
        private System.Data.DataColumn dataColumn14;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox tb_peso;
        private System.Windows.Forms.CheckBox cb_descricai_maior;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox tb_desconto;
        private System.Data.DataColumn dataColumn15;
        private System.Data.DataColumn dataColumn16;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox tb_justificativa;
        private System.Windows.Forms.Button btnLiberar;
        private System.Data.DataColumn dataColumn17;
        private System.Data.DataColumn dataColumn18;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.TextBox tb_descricao_empresa;
        private System.Windows.Forms.TextBox tb_cnpj_empresa;
        private System.Windows.Forms.Label label39;
        private System.Data.DataColumn dataColumn19;
        private System.Data.DataColumn dataColumn20;
        private System.Windows.Forms.Button button11;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datFatura_pc;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand24;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand22;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand21;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand23;
        private System.Data.DataSet dsFatura_pc;
        private System.Data.DataTable FATURA_PC;
        private System.Data.DataColumn COD_FATURA_PC;
        private System.Data.DataColumn PRAZO_FATURA_PC;
        private System.Data.DataColumn DATA_VENC_FATURA_PC;
        private System.Data.DataColumn VALOR_FATURA_PC;
        private System.Data.DataColumn N_PEDIDO_FATURA_PC;
        private System.Data.DataColumn CR_FATURA_PC;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand25;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand26;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand27;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand28;
        private System.Windows.Forms.DataGridView dgvFatura_pc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODFATURAPCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRAZOFATURAPCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAVENCFATURAPCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORFATURAPCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nPEDIDOFATURAPCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRFATURAPCDataGridViewTextBoxColumn;
        private System.Data.DataColumn dataColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODITEMPEDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nPEDIDOITEMPEDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_item_req;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod_estoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEM_ITEM_PED;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRICAOITEMPEDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPITEMPEDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn POSICAO_ITEM_PED;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_qtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn uNIDITEMPEDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_valor_unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_valor_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_frete;
        private System.Windows.Forms.DataGridViewButtonColumn Req;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATALIMITEITEMPEDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_chegou;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nf;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_data_chegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_resp_chegada;
        private System.Windows.Forms.Button button12;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbFatura_pc;
    }
}