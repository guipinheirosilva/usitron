namespace Evolucao
{
    partial class form_requisicao
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_requisicao));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label20 = new System.Windows.Forms.Label();
            this.tb_setor = new System.Windows.Forms.TextBox();
            this.dsRequisicoes = new System.Data.DataSet();
            this.REQUISICOES = new System.Data.DataTable();
            this.COD_REQUISICAO = new System.Data.DataColumn();
            this.REQUISITANTE_REQUISICAO = new System.Data.DataColumn();
            this.SETOR_REQUISICAO = new System.Data.DataColumn();
            this.OBS_REQUISICAO = new System.Data.DataColumn();
            this.DATA_REQUISICAO = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_requisitante = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_cod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_excluir = new System.Windows.Forms.Button();
            this.tb_salvar = new System.Windows.Forms.Button();
            this.bt_localizar = new System.Windows.Forms.Button();
            this.tb_novo = new System.Windows.Forms.Button();
            this.dgvItens_requisicao = new System.Windows.Forms.DataGridView();
            this.col_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODREQITEMREQDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPITEMREQDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.POSICAO_ITEM_REQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cod_estoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qTDEITEMREQDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uNIDADEITEMREQDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATALIMITEITEMREQDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uRGENTEITEMREQDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.OBS_ITEM_REQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEQUISITANTEITEMREQDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_autorizante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sETORITEMREQDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAREQUISICAOITEMREQDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sITUACAOATUALITEMREQDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aut = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.tb_obs = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_inserir = new System.Windows.Forms.Button();
            this.tb_op = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_data_req = new System.Windows.Forms.TextBox();
            this.tb_descricao_item = new System.Windows.Forms.TextBox();
            this.tb_qtde = new System.Windows.Forms.TextBox();
            this.tb_data_limite = new System.Windows.Forms.TextBox();
            this.cbUrgente = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_cod_item = new System.Windows.Forms.TextBox();
            this.datRequisicoes = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.cbRequisicoes = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.datItens_req = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand8 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand6 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand5 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand7 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.cbItens_req = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_unidade = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tb_email_3 = new System.Windows.Forms.TextBox();
            this.tb_email_2 = new System.Windows.Forms.TextBox();
            this.tb_email_1 = new System.Windows.Forms.TextBox();
            this.fbCommand9 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand10 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand11 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand12 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.datEmails_enviados = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand16 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand14 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand13 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand15 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsEmails_enviados = new System.Data.DataSet();
            this.EMAILS_ENVIADOS = new System.Data.DataTable();
            this.COD_EMAIL_ENVIADO = new System.Data.DataColumn();
            this.DESTINATARIO_EMAIL_ENVIADO = new System.Data.DataColumn();
            this.DATA_EMAIL_ENVIADO = new System.Data.DataColumn();
            this.TIPO_EMAIL_ENVIADO = new System.Data.DataColumn();
            this.HORA_EMAIL_ENVIADO = new System.Data.DataColumn();
            this.CAMINHO_ARQUIVO_EMAIL_ENVIADO = new System.Data.DataColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.barra_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.datFornecedores = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand20 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand18 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand17 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand19 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsFornecedores = new System.Data.DataSet();
            this.FORNECEDORES = new System.Data.DataTable();
            this.COD_FORN = new System.Data.DataColumn();
            this.NOME_FORN = new System.Data.DataColumn();
            this.TEL_FORN = new System.Data.DataColumn();
            this.RAZAO_SOCIAL_FORN = new System.Data.DataColumn();
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
            this.CONTATO_FORN = new System.Data.DataColumn();
            this.TEL_CONTATO_FORN = new System.Data.DataColumn();
            this.EMAIL_CONTATO_FORN = new System.Data.DataColumn();
            this.OUTRAS_INF_FORN = new System.Data.DataColumn();
            this.ISO_FORN = new System.Data.DataColumn();
            this.VALIDADE_ISO_FORN = new System.Data.DataColumn();
            this.CERT_UNI_FORN = new System.Data.DataColumn();
            this.VALIDADE_CERT_UNI_FORN = new System.Data.DataColumn();
            this.NOTA_CERT_UNI_FORN = new System.Data.DataColumn();
            this.comando_select = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_pos = new System.Windows.Forms.TextBox();
            this.tb_item_item = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_ultima_insercao = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dsOrcamentos_item_req = new System.Data.DataSet();
            this.ORCAMENTOS_ITEM_REQ = new System.Data.DataTable();
            this.COD_ORC_ITEM_REQ = new System.Data.DataColumn();
            this.COD_ITEM_ORC_ITEM_REQ = new System.Data.DataColumn();
            this.VALOR_TOTAL_ORC_ITEM_REQ = new System.Data.DataColumn();
            this.FORN_ORC_ITEM_REQ = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.fbCommand21 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.datOrcamentos_item_req = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand22 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand23 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand24 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.cbOrcamentos_item_req = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
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
            this.datItens_ped = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.gbCotacoes = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tb_data_entrega_orc = new System.Windows.Forms.TextBox();
            this.dgvOrcamentos_item_req = new System.Windows.Forms.DataGridView();
            this.col_cod_sis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cod_sistema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fORNORCITEMREQDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORTOTALORCITEMREQDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA_ENTREGA_ORC_ITEM_REQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.tb_valor_cotacao = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tb_forn_cotacao = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvItens_ped = new System.Windows.Forms.DataGridView();
            this.col_n_pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_qtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_data_chegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_valor_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_consumo_medio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label18 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dsRequisicoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.REQUISICOES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens_requisicao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsItens_req)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITENS_REQUISICAO)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsEmails_enviados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EMAILS_ENVIADOS)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsFornecedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FORNECEDORES)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsOrcamentos_item_req)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ORCAMENTOS_ITEM_REQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsItens_ped)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITENS_PEDIDO_COMPRA)).BeginInit();
            this.gbCotacoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrcamentos_item_req)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens_ped)).BeginInit();
            this.SuspendLayout();
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label20.Location = new System.Drawing.Point(331, 5);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(338, 58);
            this.label20.TabIndex = 50;
            this.label20.Text = "REQUISIÇÃO";
            // 
            // tb_setor
            // 
            this.tb_setor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRequisicoes, "REQUISICOES.SETOR_REQUISICAO", true));
            this.tb_setor.Location = new System.Drawing.Point(740, 15);
            this.tb_setor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_setor.Name = "tb_setor";
            this.tb_setor.Size = new System.Drawing.Size(264, 22);
            this.tb_setor.TabIndex = 2;
            // 
            // dsRequisicoes
            // 
            this.dsRequisicoes.DataSetName = "dsRequisicoes";
            this.dsRequisicoes.Namespace = "http://www.tempuri.org/dsRequisicoes.xsd";
            this.dsRequisicoes.Tables.AddRange(new System.Data.DataTable[] {
            this.REQUISICOES});
            // 
            // REQUISICOES
            // 
            this.REQUISICOES.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_REQUISICAO,
            this.REQUISITANTE_REQUISICAO,
            this.SETOR_REQUISICAO,
            this.OBS_REQUISICAO,
            this.DATA_REQUISICAO,
            this.dataColumn4});
            this.REQUISICOES.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_REQUISICAO"}, true)});
            this.REQUISICOES.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_REQUISICAO};
            this.REQUISICOES.TableName = "REQUISICOES";
            // 
            // COD_REQUISICAO
            // 
            this.COD_REQUISICAO.AllowDBNull = false;
            this.COD_REQUISICAO.ColumnName = "COD_REQUISICAO";
            this.COD_REQUISICAO.DataType = typeof(int);
            // 
            // REQUISITANTE_REQUISICAO
            // 
            this.REQUISITANTE_REQUISICAO.ColumnName = "REQUISITANTE_REQUISICAO";
            this.REQUISITANTE_REQUISICAO.MaxLength = 200;
            // 
            // SETOR_REQUISICAO
            // 
            this.SETOR_REQUISICAO.ColumnName = "SETOR_REQUISICAO";
            this.SETOR_REQUISICAO.MaxLength = 200;
            // 
            // OBS_REQUISICAO
            // 
            this.OBS_REQUISICAO.ColumnName = "OBS_REQUISICAO";
            this.OBS_REQUISICAO.MaxLength = 250;
            // 
            // DATA_REQUISICAO
            // 
            this.DATA_REQUISICAO.ColumnName = "DATA_REQUISICAO";
            this.DATA_REQUISICAO.DataType = typeof(System.DateTime);
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "HORA_ULTIMA_REQUISICAO";
            this.dataColumn4.MaxLength = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(685, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 80;
            this.label3.Text = "Setor:";
            // 
            // tb_requisitante
            // 
            this.tb_requisitante.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRequisicoes, "REQUISICOES.REQUISITANTE_REQUISICAO", true));
            this.tb_requisitante.Location = new System.Drawing.Point(341, 15);
            this.tb_requisitante.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_requisitante.Name = "tb_requisitante";
            this.tb_requisitante.Size = new System.Drawing.Size(304, 22);
            this.tb_requisitante.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 78;
            this.label2.Text = "Requisitante:";
            // 
            // tb_cod
            // 
            this.tb_cod.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRequisicoes, "REQUISICOES.COD_REQUISICAO", true));
            this.tb_cod.Location = new System.Drawing.Point(93, 15);
            this.tb_cod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_cod.Name = "tb_cod";
            this.tb_cod.Size = new System.Drawing.Size(97, 22);
            this.tb_cod.TabIndex = 77;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 76;
            this.label1.Text = "Cód.";
            // 
            // tb_excluir
            // 
            this.tb_excluir.Location = new System.Drawing.Point(1184, 15);
            this.tb_excluir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_excluir.Name = "tb_excluir";
            this.tb_excluir.Size = new System.Drawing.Size(65, 27);
            this.tb_excluir.TabIndex = 11;
            this.tb_excluir.Text = "Excluir";
            this.tb_excluir.UseVisualStyleBackColor = true;
            this.tb_excluir.Click += new System.EventHandler(this.tb_excluir_Click);
            // 
            // tb_salvar
            // 
            this.tb_salvar.Location = new System.Drawing.Point(1257, 15);
            this.tb_salvar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_salvar.Name = "tb_salvar";
            this.tb_salvar.Size = new System.Drawing.Size(65, 27);
            this.tb_salvar.TabIndex = 10;
            this.tb_salvar.Text = "Salvar";
            this.tb_salvar.UseVisualStyleBackColor = true;
            this.tb_salvar.Click += new System.EventHandler(this.tb_salvar_Click);
            // 
            // bt_localizar
            // 
            this.bt_localizar.Location = new System.Drawing.Point(1023, 15);
            this.bt_localizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_localizar.Name = "bt_localizar";
            this.bt_localizar.Size = new System.Drawing.Size(80, 27);
            this.bt_localizar.TabIndex = 13;
            this.bt_localizar.Text = "Localizar";
            this.bt_localizar.UseVisualStyleBackColor = true;
            this.bt_localizar.Click += new System.EventHandler(this.bt_localizar_Click);
            // 
            // tb_novo
            // 
            this.tb_novo.Location = new System.Drawing.Point(1111, 15);
            this.tb_novo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_novo.Name = "tb_novo";
            this.tb_novo.Size = new System.Drawing.Size(65, 27);
            this.tb_novo.TabIndex = 12;
            this.tb_novo.Text = "Novo";
            this.tb_novo.UseVisualStyleBackColor = true;
            this.tb_novo.Click += new System.EventHandler(this.tb_novo_Click);
            // 
            // dgvItens_requisicao
            // 
            this.dgvItens_requisicao.AllowUserToAddRows = false;
            this.dgvItens_requisicao.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItens_requisicao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItens_requisicao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens_requisicao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_cod,
            this.cODREQITEMREQDataGridViewTextBoxColumn,
            this.oPITEMREQDataGridViewTextBoxColumn,
            this.POSICAO_ITEM_REQ,
            this.col_cod_estoque,
            this.col_item,
            this.dataGridViewTextBoxColumn1,
            this.qTDEITEMREQDataGridViewTextBoxColumn,
            this.uNIDADEITEMREQDataGridViewTextBoxColumn,
            this.dATALIMITEITEMREQDataGridViewTextBoxColumn,
            this.uRGENTEITEMREQDataGridViewTextBoxColumn,
            this.OBS_ITEM_REQ,
            this.rEQUISITANTEITEMREQDataGridViewTextBoxColumn,
            this.col_autorizante,
            this.sETORITEMREQDataGridViewTextBoxColumn,
            this.dATAREQUISICAOITEMREQDataGridViewTextBoxColumn,
            this.sITUACAOATUALITEMREQDataGridViewTextBoxColumn,
            this.Aut});
            this.dgvItens_requisicao.DataMember = "ITENS_REQUISICAO";
            this.dgvItens_requisicao.DataSource = this.dsItens_req;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItens_requisicao.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvItens_requisicao.Location = new System.Drawing.Point(11, 116);
            this.dgvItens_requisicao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvItens_requisicao.Name = "dgvItens_requisicao";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItens_requisicao.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvItens_requisicao.Size = new System.Drawing.Size(1291, 239);
            this.dgvItens_requisicao.TabIndex = 82;
            this.dgvItens_requisicao.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItens_requisicao_CellClick);
            this.dgvItens_requisicao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItens_requisicao_CellContentClick);
            // 
            // col_cod
            // 
            this.col_cod.DataPropertyName = "COD_ITEM_REQ";
            this.col_cod.HeaderText = "Cód.";
            this.col_cod.Name = "col_cod";
            this.col_cod.Width = 50;
            // 
            // cODREQITEMREQDataGridViewTextBoxColumn
            // 
            this.cODREQITEMREQDataGridViewTextBoxColumn.DataPropertyName = "COD_REQ_ITEM_REQ";
            this.cODREQITEMREQDataGridViewTextBoxColumn.HeaderText = "COD_REQ_ITEM_REQ";
            this.cODREQITEMREQDataGridViewTextBoxColumn.Name = "cODREQITEMREQDataGridViewTextBoxColumn";
            this.cODREQITEMREQDataGridViewTextBoxColumn.Visible = false;
            // 
            // oPITEMREQDataGridViewTextBoxColumn
            // 
            this.oPITEMREQDataGridViewTextBoxColumn.DataPropertyName = "OP_ITEM_REQ";
            this.oPITEMREQDataGridViewTextBoxColumn.HeaderText = "OS";
            this.oPITEMREQDataGridViewTextBoxColumn.Name = "oPITEMREQDataGridViewTextBoxColumn";
            this.oPITEMREQDataGridViewTextBoxColumn.Width = 90;
            // 
            // POSICAO_ITEM_REQ
            // 
            this.POSICAO_ITEM_REQ.DataPropertyName = "POSICAO_ITEM_REQ";
            this.POSICAO_ITEM_REQ.HeaderText = "Pos";
            this.POSICAO_ITEM_REQ.Name = "POSICAO_ITEM_REQ";
            this.POSICAO_ITEM_REQ.Width = 40;
            // 
            // col_cod_estoque
            // 
            this.col_cod_estoque.DataPropertyName = "COD_ESTOQUE_ITEM_REQ";
            this.col_cod_estoque.HeaderText = "Código Estoque";
            this.col_cod_estoque.Name = "col_cod_estoque";
            this.col_cod_estoque.Width = 75;
            // 
            // col_item
            // 
            this.col_item.DataPropertyName = "ITEM_ITEM_REQ";
            this.col_item.HeaderText = "Item";
            this.col_item.Name = "col_item";
            this.col_item.Width = 200;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DESCRICAO_ITEM_REQ";
            this.dataGridViewTextBoxColumn1.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // qTDEITEMREQDataGridViewTextBoxColumn
            // 
            this.qTDEITEMREQDataGridViewTextBoxColumn.DataPropertyName = "QTDE_ITEM_REQ";
            this.qTDEITEMREQDataGridViewTextBoxColumn.HeaderText = "Qtde";
            this.qTDEITEMREQDataGridViewTextBoxColumn.Name = "qTDEITEMREQDataGridViewTextBoxColumn";
            // 
            // uNIDADEITEMREQDataGridViewTextBoxColumn
            // 
            this.uNIDADEITEMREQDataGridViewTextBoxColumn.DataPropertyName = "UNIDADE_ITEM_REQ";
            this.uNIDADEITEMREQDataGridViewTextBoxColumn.HeaderText = "Unidade";
            this.uNIDADEITEMREQDataGridViewTextBoxColumn.Name = "uNIDADEITEMREQDataGridViewTextBoxColumn";
            this.uNIDADEITEMREQDataGridViewTextBoxColumn.Width = 90;
            // 
            // dATALIMITEITEMREQDataGridViewTextBoxColumn
            // 
            this.dATALIMITEITEMREQDataGridViewTextBoxColumn.DataPropertyName = "DATA_LIMITE_ITEM_REQ";
            this.dATALIMITEITEMREQDataGridViewTextBoxColumn.HeaderText = "Data Limite";
            this.dATALIMITEITEMREQDataGridViewTextBoxColumn.Name = "dATALIMITEITEMREQDataGridViewTextBoxColumn";
            // 
            // uRGENTEITEMREQDataGridViewTextBoxColumn
            // 
            this.uRGENTEITEMREQDataGridViewTextBoxColumn.DataPropertyName = "URGENTE_ITEM_REQ";
            this.uRGENTEITEMREQDataGridViewTextBoxColumn.FalseValue = "0";
            this.uRGENTEITEMREQDataGridViewTextBoxColumn.HeaderText = "Urgente";
            this.uRGENTEITEMREQDataGridViewTextBoxColumn.Name = "uRGENTEITEMREQDataGridViewTextBoxColumn";
            this.uRGENTEITEMREQDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.uRGENTEITEMREQDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.uRGENTEITEMREQDataGridViewTextBoxColumn.TrueValue = "1";
            this.uRGENTEITEMREQDataGridViewTextBoxColumn.Width = 50;
            // 
            // OBS_ITEM_REQ
            // 
            this.OBS_ITEM_REQ.DataPropertyName = "OBS_ITEM_REQ";
            this.OBS_ITEM_REQ.HeaderText = "Observações";
            this.OBS_ITEM_REQ.Name = "OBS_ITEM_REQ";
            this.OBS_ITEM_REQ.Width = 200;
            // 
            // rEQUISITANTEITEMREQDataGridViewTextBoxColumn
            // 
            this.rEQUISITANTEITEMREQDataGridViewTextBoxColumn.DataPropertyName = "REQUISITANTE_ITEM_REQ";
            this.rEQUISITANTEITEMREQDataGridViewTextBoxColumn.HeaderText = "REQUISITANTE_ITEM_REQ";
            this.rEQUISITANTEITEMREQDataGridViewTextBoxColumn.Name = "rEQUISITANTEITEMREQDataGridViewTextBoxColumn";
            this.rEQUISITANTEITEMREQDataGridViewTextBoxColumn.Visible = false;
            // 
            // col_autorizante
            // 
            this.col_autorizante.DataPropertyName = "AUTORIZADO_POR_ITEM_REQ";
            this.col_autorizante.HeaderText = "Autorizado por";
            this.col_autorizante.Name = "col_autorizante";
            this.col_autorizante.ReadOnly = true;
            // 
            // sETORITEMREQDataGridViewTextBoxColumn
            // 
            this.sETORITEMREQDataGridViewTextBoxColumn.DataPropertyName = "SETOR_ITEM_REQ";
            this.sETORITEMREQDataGridViewTextBoxColumn.HeaderText = "SETOR_ITEM_REQ";
            this.sETORITEMREQDataGridViewTextBoxColumn.Name = "sETORITEMREQDataGridViewTextBoxColumn";
            this.sETORITEMREQDataGridViewTextBoxColumn.Visible = false;
            // 
            // dATAREQUISICAOITEMREQDataGridViewTextBoxColumn
            // 
            this.dATAREQUISICAOITEMREQDataGridViewTextBoxColumn.DataPropertyName = "DATA_REQUISICAO_ITEM_REQ";
            this.dATAREQUISICAOITEMREQDataGridViewTextBoxColumn.HeaderText = "DATA_REQUISICAO_ITEM_REQ";
            this.dATAREQUISICAOITEMREQDataGridViewTextBoxColumn.Name = "dATAREQUISICAOITEMREQDataGridViewTextBoxColumn";
            this.dATAREQUISICAOITEMREQDataGridViewTextBoxColumn.Visible = false;
            // 
            // sITUACAOATUALITEMREQDataGridViewTextBoxColumn
            // 
            this.sITUACAOATUALITEMREQDataGridViewTextBoxColumn.DataPropertyName = "SITUACAO_ATUAL_ITEM_REQ";
            this.sITUACAOATUALITEMREQDataGridViewTextBoxColumn.HeaderText = "Situação Atual";
            this.sITUACAOATUALITEMREQDataGridViewTextBoxColumn.Name = "sITUACAOATUALITEMREQDataGridViewTextBoxColumn";
            this.sITUACAOATUALITEMREQDataGridViewTextBoxColumn.Width = 250;
            // 
            // Aut
            // 
            this.Aut.HeaderText = "Aut";
            this.Aut.Name = "Aut";
            this.Aut.Text = "Aut";
            this.Aut.ToolTipText = "Aut";
            this.Aut.UseColumnTextForButtonValue = true;
            this.Aut.Width = 50;
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
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn5});
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
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "AUTORIZADO_POR_ITEM_REQ";
            this.dataColumn1.MaxLength = 50;
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "POSICAO_ITEM_REQ";
            this.dataColumn2.MaxLength = 50;
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "ITEM_ITEM_REQ";
            this.dataColumn3.MaxLength = 500;
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "OBS_ITEM_REQ";
            this.dataColumn5.MaxLength = 500;
            // 
            // tb_obs
            // 
            this.tb_obs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRequisicoes, "REQUISICOES.OBS_REQUISICAO", true));
            this.tb_obs.Location = new System.Drawing.Point(341, 47);
            this.tb_obs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_obs.Multiline = true;
            this.tb_obs.Name = "tb_obs";
            this.tb_obs.Size = new System.Drawing.Size(304, 69);
            this.tb_obs.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 47);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 83;
            this.label4.Text = "Observações:";
            // 
            // bt_inserir
            // 
            this.bt_inserir.Location = new System.Drawing.Point(15, 31);
            this.bt_inserir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_inserir.Name = "bt_inserir";
            this.bt_inserir.Size = new System.Drawing.Size(127, 28);
            this.bt_inserir.TabIndex = 11;
            this.bt_inserir.Text = "Inserir";
            this.bt_inserir.UseVisualStyleBackColor = true;
            this.bt_inserir.Click += new System.EventHandler(this.bt_inserir_Click);
            // 
            // tb_op
            // 
            this.tb_op.Location = new System.Drawing.Point(149, 33);
            this.tb_op.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_op.Name = "tb_op";
            this.tb_op.Size = new System.Drawing.Size(99, 22);
            this.tb_op.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(685, 50);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 87;
            this.label5.Text = "Data:";
            // 
            // tb_data_req
            // 
            this.tb_data_req.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRequisicoes, "REQUISICOES.DATA_REQUISICAO", true));
            this.tb_data_req.Location = new System.Drawing.Point(740, 47);
            this.tb_data_req.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_data_req.Name = "tb_data_req";
            this.tb_data_req.ReadOnly = true;
            this.tb_data_req.Size = new System.Drawing.Size(168, 22);
            this.tb_data_req.TabIndex = 88;
            // 
            // tb_descricao_item
            // 
            this.tb_descricao_item.Location = new System.Drawing.Point(411, 80);
            this.tb_descricao_item.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_descricao_item.Name = "tb_descricao_item";
            this.tb_descricao_item.Size = new System.Drawing.Size(335, 22);
            this.tb_descricao_item.TabIndex = 6;
            this.tb_descricao_item.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_descricao_item_KeyDown);
            // 
            // tb_qtde
            // 
            this.tb_qtde.Location = new System.Drawing.Point(755, 33);
            this.tb_qtde.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_qtde.Name = "tb_qtde";
            this.tb_qtde.Size = new System.Drawing.Size(127, 22);
            this.tb_qtde.TabIndex = 7;
            // 
            // tb_data_limite
            // 
            this.tb_data_limite.Location = new System.Drawing.Point(1005, 33);
            this.tb_data_limite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_data_limite.Name = "tb_data_limite";
            this.tb_data_limite.Size = new System.Drawing.Size(133, 22);
            this.tb_data_limite.TabIndex = 9;
            // 
            // cbUrgente
            // 
            this.cbUrgente.AutoSize = true;
            this.cbUrgente.Location = new System.Drawing.Point(1144, 34);
            this.cbUrgente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbUrgente.Name = "cbUrgente";
            this.cbUrgente.Size = new System.Drawing.Size(81, 21);
            this.cbUrgente.TabIndex = 10;
            this.cbUrgente.Text = "Urgente";
            this.cbUrgente.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(155, 14);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 17);
            this.label6.TabIndex = 93;
            this.label6.Text = "OS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(407, 62);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 17);
            this.label7.TabIndex = 94;
            this.label7.Text = "Descrição Item (Aperte F2)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(751, 14);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 17);
            this.label8.TabIndex = 95;
            this.label8.Text = "Quantidade";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1001, 14);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 17);
            this.label9.TabIndex = 96;
            this.label9.Text = "Data Limite (se houver)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(311, 14);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 17);
            this.label10.TabIndex = 98;
            this.label10.Text = "Cód Estoque";
            // 
            // tb_cod_item
            // 
            this.tb_cod_item.Location = new System.Drawing.Point(313, 33);
            this.tb_cod_item.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_cod_item.Name = "tb_cod_item";
            this.tb_cod_item.Size = new System.Drawing.Size(89, 22);
            this.tb_cod_item.TabIndex = 5;
            this.tb_cod_item.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_cod_item_KeyPress);
            // 
            // datRequisicoes
            // 
            this.datRequisicoes.DeleteCommand = this.fbCommand4;
            this.datRequisicoes.InsertCommand = this.fbCommand2;
            this.datRequisicoes.SelectCommand = this.fbCommand1;
            this.datRequisicoes.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * from requisicoes";
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
            // cbRequisicoes
            // 
            this.cbRequisicoes.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbRequisicoes.DataAdapter = this.datRequisicoes;
            this.cbRequisicoes.QuotePrefix = "\"";
            this.cbRequisicoes.QuoteSuffix = "\"";
            // 
            // datItens_req
            // 
            this.datItens_req.DeleteCommand = this.fbCommand8;
            this.datItens_req.InsertCommand = this.fbCommand6;
            this.datItens_req.SelectCommand = this.fbCommand5;
            this.datItens_req.UpdateCommand = this.fbCommand7;
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
            this.fbCommand5.CommandText = "select * from itens_requisicao";
            this.fbCommand5.CommandTimeout = 30;
            this.fbCommand5.Connection = this.fbConnection1;
            // 
            // fbCommand7
            // 
            this.fbCommand7.CommandTimeout = 30;
            // 
            // cbItens_req
            // 
            this.cbItens_req.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbItens_req.DataAdapter = this.datItens_req;
            this.cbItens_req.QuotePrefix = "\"";
            this.cbItens_req.QuoteSuffix = "\"";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(885, 14);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 17);
            this.label11.TabIndex = 100;
            this.label11.Text = "Unidade";
            // 
            // tb_unidade
            // 
            this.tb_unidade.Location = new System.Drawing.Point(889, 33);
            this.tb_unidade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_unidade.Name = "tb_unidade";
            this.tb_unidade.Size = new System.Drawing.Size(107, 22);
            this.tb_unidade.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(937, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 27);
            this.button1.TabIndex = 101;
            this.button1.Text = "Imprimir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1229, 16);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 42);
            this.button2.TabIndex = 102;
            this.button2.Text = "Autorizar\r\nTodos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(123, 95);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 27);
            this.button3.TabIndex = 103;
            this.button3.Text = "Encaminhar Email";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.tb_email_3);
            this.groupBox1.Controls.Add(this.tb_email_2);
            this.groupBox1.Controls.Add(this.tb_email_1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Location = new System.Drawing.Point(1031, 65);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(292, 129);
            this.groupBox1.TabIndex = 104;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Destinatários";
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(259, 71);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(25, 21);
            this.button6.TabIndex = 5;
            this.button6.Text = "3";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(259, 17);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(25, 21);
            this.button5.TabIndex = 4;
            this.button5.Text = "1";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(259, 43);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(25, 21);
            this.button4.TabIndex = 3;
            this.button4.Text = "2";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tb_email_3
            // 
            this.tb_email_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_email_3.Location = new System.Drawing.Point(8, 71);
            this.tb_email_3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_email_3.Name = "tb_email_3";
            this.tb_email_3.Size = new System.Drawing.Size(241, 23);
            this.tb_email_3.TabIndex = 2;
            // 
            // tb_email_2
            // 
            this.tb_email_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_email_2.Location = new System.Drawing.Point(8, 44);
            this.tb_email_2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_email_2.Name = "tb_email_2";
            this.tb_email_2.Size = new System.Drawing.Size(241, 23);
            this.tb_email_2.TabIndex = 1;
            // 
            // tb_email_1
            // 
            this.tb_email_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_email_1.Location = new System.Drawing.Point(8, 18);
            this.tb_email_1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_email_1.Name = "tb_email_1";
            this.tb_email_1.Size = new System.Drawing.Size(241, 23);
            this.tb_email_1.TabIndex = 0;
            // 
            // fbCommand9
            // 
            this.fbCommand9.CommandTimeout = 30;
            // 
            // fbCommand10
            // 
            this.fbCommand10.CommandTimeout = 30;
            // 
            // fbCommand11
            // 
            this.fbCommand11.CommandTimeout = 30;
            // 
            // fbCommand12
            // 
            this.fbCommand12.CommandTimeout = 30;
            // 
            // datEmails_enviados
            // 
            this.datEmails_enviados.DeleteCommand = this.fbCommand16;
            this.datEmails_enviados.InsertCommand = this.fbCommand14;
            this.datEmails_enviados.SelectCommand = this.fbCommand13;
            this.datEmails_enviados.UpdateCommand = this.fbCommand15;
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
            this.fbCommand13.CommandText = "SELECT * FROM EMAILS_ENVIADOS";
            this.fbCommand13.CommandTimeout = 30;
            this.fbCommand13.Connection = this.fbConnection1;
            // 
            // fbCommand15
            // 
            this.fbCommand15.CommandTimeout = 30;
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
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barra_status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 851);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1339, 25);
            this.statusStrip1.TabIndex = 252;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // barra_status
            // 
            this.barra_status.Name = "barra_status";
            this.barra_status.Size = new System.Drawing.Size(88, 20);
            this.barra_status.Text = "Status Atual";
            // 
            // datFornecedores
            // 
            this.datFornecedores.DeleteCommand = this.fbCommand20;
            this.datFornecedores.InsertCommand = this.fbCommand18;
            this.datFornecedores.SelectCommand = this.fbCommand17;
            this.datFornecedores.UpdateCommand = this.fbCommand19;
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
            this.fbCommand17.CommandText = "select * from fornecedores";
            this.fbCommand17.CommandTimeout = 30;
            this.fbCommand17.Connection = this.fbConnection1;
            // 
            // fbCommand19
            // 
            this.fbCommand19.CommandTimeout = 30;
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
            this.NOME_FORN,
            this.TEL_FORN,
            this.RAZAO_SOCIAL_FORN,
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
            // NOME_FORN
            // 
            this.NOME_FORN.ColumnName = "NOME_FORN";
            this.NOME_FORN.MaxLength = 50;
            // 
            // TEL_FORN
            // 
            this.TEL_FORN.ColumnName = "TEL_FORN";
            this.TEL_FORN.MaxLength = 20;
            // 
            // RAZAO_SOCIAL_FORN
            // 
            this.RAZAO_SOCIAL_FORN.ColumnName = "RAZAO_SOCIAL_FORN";
            this.RAZAO_SOCIAL_FORN.MaxLength = 80;
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
            // comando_select
            // 
            this.comando_select.CommandTimeout = 30;
            this.comando_select.Connection = this.fbConnection1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(249, 14);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 17);
            this.label12.TabIndex = 254;
            this.label12.Text = "Pos";
            // 
            // tb_pos
            // 
            this.tb_pos.Location = new System.Drawing.Point(253, 33);
            this.tb_pos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_pos.Name = "tb_pos";
            this.tb_pos.Size = new System.Drawing.Size(51, 22);
            this.tb_pos.TabIndex = 253;
            // 
            // tb_item_item
            // 
            this.tb_item_item.Location = new System.Drawing.Point(411, 33);
            this.tb_item_item.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_item_item.Name = "tb_item_item";
            this.tb_item_item.Size = new System.Drawing.Size(335, 22);
            this.tb_item_item.TabIndex = 255;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(408, 14);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 17);
            this.label13.TabIndex = 256;
            this.label13.Text = "Item";
            // 
            // tb_ultima_insercao
            // 
            this.tb_ultima_insercao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRequisicoes, "REQUISICOES.HORA_ULTIMA_REQUISICAO", true));
            this.tb_ultima_insercao.Location = new System.Drawing.Point(1153, 805);
            this.tb_ultima_insercao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_ultima_insercao.Name = "tb_ultima_insercao";
            this.tb_ultima_insercao.ReadOnly = true;
            this.tb_ultima_insercao.Size = new System.Drawing.Size(168, 22);
            this.tb_ultima_insercao.TabIndex = 258;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(980, 809);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(164, 17);
            this.label14.TabIndex = 257;
            this.label14.Text = "Hora da Ultima Inserção:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.tb_data_req);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tb_obs);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tb_setor);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tb_requisitante);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tb_cod);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(8, 65);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1015, 129);
            this.panel1.TabIndex = 259;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.tb_item_item);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.tb_pos);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.tb_unidade);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.tb_cod_item);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cbUrgente);
            this.panel2.Controls.Add(this.tb_data_limite);
            this.panel2.Controls.Add(this.tb_qtde);
            this.panel2.Controls.Add(this.tb_descricao_item);
            this.panel2.Controls.Add(this.tb_op);
            this.panel2.Controls.Add(this.bt_inserir);
            this.panel2.Controls.Add(this.dgvItens_requisicao);
            this.panel2.Location = new System.Drawing.Point(8, 196);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1315, 366);
            this.panel2.TabIndex = 260;
            // 
            // dsOrcamentos_item_req
            // 
            this.dsOrcamentos_item_req.DataSetName = "dsOrcamento_item_req";
            this.dsOrcamentos_item_req.Namespace = "http://www.tempuri.org/dsOrcamento_item_req.xsd";
            this.dsOrcamentos_item_req.Tables.AddRange(new System.Data.DataTable[] {
            this.ORCAMENTOS_ITEM_REQ});
            // 
            // ORCAMENTOS_ITEM_REQ
            // 
            this.ORCAMENTOS_ITEM_REQ.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_ORC_ITEM_REQ,
            this.COD_ITEM_ORC_ITEM_REQ,
            this.VALOR_TOTAL_ORC_ITEM_REQ,
            this.FORN_ORC_ITEM_REQ,
            this.dataColumn6});
            this.ORCAMENTOS_ITEM_REQ.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_ORC_ITEM_REQ"}, true)});
            this.ORCAMENTOS_ITEM_REQ.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_ORC_ITEM_REQ};
            this.ORCAMENTOS_ITEM_REQ.TableName = "ORCAMENTOS_ITEM_REQ";
            // 
            // COD_ORC_ITEM_REQ
            // 
            this.COD_ORC_ITEM_REQ.AllowDBNull = false;
            this.COD_ORC_ITEM_REQ.ColumnName = "COD_ORC_ITEM_REQ";
            this.COD_ORC_ITEM_REQ.DataType = typeof(int);
            // 
            // COD_ITEM_ORC_ITEM_REQ
            // 
            this.COD_ITEM_ORC_ITEM_REQ.ColumnName = "COD_ITEM_ORC_ITEM_REQ";
            this.COD_ITEM_ORC_ITEM_REQ.DataType = typeof(int);
            // 
            // VALOR_TOTAL_ORC_ITEM_REQ
            // 
            this.VALOR_TOTAL_ORC_ITEM_REQ.ColumnName = "VALOR_TOTAL_ORC_ITEM_REQ";
            this.VALOR_TOTAL_ORC_ITEM_REQ.DataType = typeof(double);
            // 
            // FORN_ORC_ITEM_REQ
            // 
            this.FORN_ORC_ITEM_REQ.ColumnName = "FORN_ORC_ITEM_REQ";
            this.FORN_ORC_ITEM_REQ.MaxLength = 150;
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "DATA_ENTREGA_ORC_ITEM_REQ";
            this.dataColumn6.DataType = typeof(System.DateTime);
            // 
            // fbCommand21
            // 
            this.fbCommand21.CommandTimeout = 30;
            // 
            // datOrcamentos_item_req
            // 
            this.datOrcamentos_item_req.DeleteCommand = this.fbCommand16;
            this.datOrcamentos_item_req.InsertCommand = this.fbCommand22;
            this.datOrcamentos_item_req.SelectCommand = this.fbCommand23;
            this.datOrcamentos_item_req.UpdateCommand = this.fbCommand24;
            // 
            // fbCommand22
            // 
            this.fbCommand22.CommandTimeout = 30;
            // 
            // fbCommand23
            // 
            this.fbCommand23.CommandText = "select * from ORCAMENTOS_ITEM_REQ";
            this.fbCommand23.CommandTimeout = 30;
            this.fbCommand23.Connection = this.fbConnection1;
            // 
            // fbCommand24
            // 
            this.fbCommand24.CommandTimeout = 30;
            // 
            // cbOrcamentos_item_req
            // 
            this.cbOrcamentos_item_req.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbOrcamentos_item_req.DataAdapter = this.datOrcamentos_item_req;
            this.cbOrcamentos_item_req.QuotePrefix = "\"";
            this.cbOrcamentos_item_req.QuoteSuffix = "\"";
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
            // datItens_ped
            // 
            this.datItens_ped.DeleteCommand = this.fbCommand16;
            this.datItens_ped.InsertCommand = this.fbCommand22;
            this.datItens_ped.SelectCommand = this.fbCommand23;
            this.datItens_ped.UpdateCommand = this.fbCommand24;
            // 
            // gbCotacoes
            // 
            this.gbCotacoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gbCotacoes.Controls.Add(this.label17);
            this.gbCotacoes.Controls.Add(this.tb_data_entrega_orc);
            this.gbCotacoes.Controls.Add(this.dgvOrcamentos_item_req);
            this.gbCotacoes.Controls.Add(this.button7);
            this.gbCotacoes.Controls.Add(this.button8);
            this.gbCotacoes.Controls.Add(this.label15);
            this.gbCotacoes.Controls.Add(this.tb_valor_cotacao);
            this.gbCotacoes.Controls.Add(this.label16);
            this.gbCotacoes.Controls.Add(this.tb_forn_cotacao);
            this.gbCotacoes.Location = new System.Drawing.Point(8, 569);
            this.gbCotacoes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbCotacoes.Name = "gbCotacoes";
            this.gbCotacoes.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbCotacoes.Size = new System.Drawing.Size(628, 229);
            this.gbCotacoes.TabIndex = 261;
            this.gbCotacoes.TabStop = false;
            this.gbCotacoes.Text = "Cotações";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(441, 28);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(92, 17);
            this.label17.TabIndex = 119;
            this.label17.Text = "Data Entrega";
            // 
            // tb_data_entrega_orc
            // 
            this.tb_data_entrega_orc.Location = new System.Drawing.Point(445, 48);
            this.tb_data_entrega_orc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_data_entrega_orc.Name = "tb_data_entrega_orc";
            this.tb_data_entrega_orc.Size = new System.Drawing.Size(120, 22);
            this.tb_data_entrega_orc.TabIndex = 2;
            // 
            // dgvOrcamentos_item_req
            // 
            this.dgvOrcamentos_item_req.AllowUserToAddRows = false;
            this.dgvOrcamentos_item_req.AutoGenerateColumns = false;
            this.dgvOrcamentos_item_req.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrcamentos_item_req.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_cod_sis,
            this.col_cod_sistema,
            this.fORNORCITEMREQDataGridViewTextBoxColumn,
            this.vALORTOTALORCITEMREQDataGridViewTextBoxColumn,
            this.DATA_ENTREGA_ORC_ITEM_REQ});
            this.dgvOrcamentos_item_req.DataMember = "ORCAMENTOS_ITEM_REQ";
            this.dgvOrcamentos_item_req.DataSource = this.dsOrcamentos_item_req;
            this.dgvOrcamentos_item_req.Location = new System.Drawing.Point(87, 82);
            this.dgvOrcamentos_item_req.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvOrcamentos_item_req.Name = "dgvOrcamentos_item_req";
            this.dgvOrcamentos_item_req.Size = new System.Drawing.Size(508, 134);
            this.dgvOrcamentos_item_req.TabIndex = 5;
            // 
            // col_cod_sis
            // 
            this.col_cod_sis.DataPropertyName = "COD_ORC_ITEM_REQ";
            this.col_cod_sis.HeaderText = "Cod";
            this.col_cod_sis.Name = "col_cod_sis";
            this.col_cod_sis.Visible = false;
            this.col_cod_sis.Width = 30;
            // 
            // col_cod_sistema
            // 
            this.col_cod_sistema.DataPropertyName = "COD_ITEM_ORC_ITEM_REQ";
            this.col_cod_sistema.HeaderText = "COD_ITEM_ORC_ITEM_REQ";
            this.col_cod_sistema.Name = "col_cod_sistema";
            this.col_cod_sistema.Visible = false;
            // 
            // fORNORCITEMREQDataGridViewTextBoxColumn
            // 
            this.fORNORCITEMREQDataGridViewTextBoxColumn.DataPropertyName = "FORN_ORC_ITEM_REQ";
            this.fORNORCITEMREQDataGridViewTextBoxColumn.HeaderText = "Fornecedor";
            this.fORNORCITEMREQDataGridViewTextBoxColumn.Name = "fORNORCITEMREQDataGridViewTextBoxColumn";
            this.fORNORCITEMREQDataGridViewTextBoxColumn.Width = 130;
            // 
            // vALORTOTALORCITEMREQDataGridViewTextBoxColumn
            // 
            this.vALORTOTALORCITEMREQDataGridViewTextBoxColumn.DataPropertyName = "VALOR_TOTAL_ORC_ITEM_REQ";
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.vALORTOTALORCITEMREQDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.vALORTOTALORCITEMREQDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.vALORTOTALORCITEMREQDataGridViewTextBoxColumn.Name = "vALORTOTALORCITEMREQDataGridViewTextBoxColumn";
            this.vALORTOTALORCITEMREQDataGridViewTextBoxColumn.Width = 110;
            // 
            // DATA_ENTREGA_ORC_ITEM_REQ
            // 
            this.DATA_ENTREGA_ORC_ITEM_REQ.DataPropertyName = "DATA_ENTREGA_ORC_ITEM_REQ";
            this.DATA_ENTREGA_ORC_ITEM_REQ.HeaderText = "Data Entrega";
            this.DATA_ENTREGA_ORC_ITEM_REQ.Name = "DATA_ENTREGA_ORC_ITEM_REQ";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(279, 46);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(29, 28);
            this.button7.TabIndex = 116;
            this.button7.Text = "+";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button8.Location = new System.Drawing.Point(8, 46);
            this.button8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(71, 28);
            this.button8.TabIndex = 3;
            this.button8.Text = "Inserir";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click_1);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(312, 28);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 17);
            this.label15.TabIndex = 113;
            this.label15.Text = "Valor";
            // 
            // tb_valor_cotacao
            // 
            this.tb_valor_cotacao.Location = new System.Drawing.Point(316, 48);
            this.tb_valor_cotacao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_valor_cotacao.Name = "tb_valor_cotacao";
            this.tb_valor_cotacao.Size = new System.Drawing.Size(120, 22);
            this.tb_valor_cotacao.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(120, 30);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 17);
            this.label16.TabIndex = 112;
            this.label16.Text = "Fornecedor";
            // 
            // tb_forn_cotacao
            // 
            this.tb_forn_cotacao.Location = new System.Drawing.Point(115, 49);
            this.tb_forn_cotacao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_forn_cotacao.Name = "tb_forn_cotacao";
            this.tb_forn_cotacao.Size = new System.Drawing.Size(160, 22);
            this.tb_forn_cotacao.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.dgvItens_ped);
            this.groupBox2.Location = new System.Drawing.Point(896, 569);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(427, 229);
            this.groupBox2.TabIndex = 262;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Compras";
            // 
            // dgvItens_ped
            // 
            this.dgvItens_ped.AllowUserToAddRows = false;
            this.dgvItens_ped.AllowUserToResizeColumns = false;
            this.dgvItens_ped.AllowUserToResizeRows = false;
            this.dgvItens_ped.AutoGenerateColumns = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItens_ped.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvItens_ped.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens_ped.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_n_pedido,
            this.col_qtde,
            this.col_data_chegada,
            this.col_valor_unit,
            this.col_consumo_medio,
            this.dataGridViewTextBoxColumn4});
            this.dgvItens_ped.DataMember = "ITENS_PEDIDO_COMPRA";
            this.dgvItens_ped.DataSource = this.dsItens_ped;
            this.dgvItens_ped.Location = new System.Drawing.Point(11, 23);
            this.dgvItens_ped.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvItens_ped.Name = "dgvItens_ped";
            this.dgvItens_ped.RowHeadersVisible = false;
            this.dgvItens_ped.Size = new System.Drawing.Size(408, 198);
            this.dgvItens_ped.TabIndex = 0;
            // 
            // col_n_pedido
            // 
            this.col_n_pedido.DataPropertyName = "N_PEDIDO_ITEM_PED";
            this.col_n_pedido.HeaderText = "Nº Ped.";
            this.col_n_pedido.Name = "col_n_pedido";
            this.col_n_pedido.Width = 40;
            // 
            // col_qtde
            // 
            this.col_qtde.DataPropertyName = "QTDE_ITEM_PED";
            this.col_qtde.HeaderText = "Qtde";
            this.col_qtde.Name = "col_qtde";
            this.col_qtde.Width = 50;
            // 
            // col_data_chegada
            // 
            this.col_data_chegada.DataPropertyName = "DATA_CHEGADA_ITEM_PED";
            this.col_data_chegada.HeaderText = "Data Chegada";
            this.col_data_chegada.Name = "col_data_chegada";
            this.col_data_chegada.Width = 60;
            // 
            // col_valor_unit
            // 
            this.col_valor_unit.DataPropertyName = "VALOR_UNIT_ITEM_PED";
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.col_valor_unit.DefaultCellStyle = dataGridViewCellStyle6;
            this.col_valor_unit.HeaderText = "Valor Unit.";
            this.col_valor_unit.Name = "col_valor_unit";
            this.col_valor_unit.Width = 60;
            // 
            // col_consumo_medio
            // 
            this.col_consumo_medio.HeaderText = "Consumo Médio";
            this.col_consumo_medio.Name = "col_consumo_medio";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "VALOR_TOTAL_ITEM_PED";
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn4.HeaderText = "Valor Total";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(700, 639);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(142, 85);
            this.label18.TabIndex = 264;
            this.label18.Text = "Antes de visualizar \r\nas cotações verifique\r\nse a linha inteira do \r\nitem da requ" +
    "isição \r\nestá selecionada.";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(701, 576);
            this.button9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(140, 58);
            this.button9.TabIndex = 263;
            this.button9.Text = "Visualizar \r\nCotações e \r\nCompras\r\n";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // form_requisicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 876);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.gbCotacoes);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tb_ultima_insercao);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_excluir);
            this.Controls.Add(this.tb_salvar);
            this.Controls.Add(this.bt_localizar);
            this.Controls.Add(this.tb_novo);
            this.Controls.Add(this.label20);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "form_requisicao";
            this.Text = "Requisição";
            this.Load += new System.EventHandler(this.form_requisicao_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.form_requisicao_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dsRequisicoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.REQUISICOES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens_requisicao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsItens_req)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITENS_REQUISICAO)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsEmails_enviados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EMAILS_ENVIADOS)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsFornecedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FORNECEDORES)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsOrcamentos_item_req)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ORCAMENTOS_ITEM_REQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsItens_ped)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITENS_PEDIDO_COMPRA)).EndInit();
            this.gbCotacoes.ResumeLayout(false);
            this.gbCotacoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrcamentos_item_req)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens_ped)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tb_setor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_requisitante;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_cod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tb_excluir;
        private System.Windows.Forms.Button tb_salvar;
        private System.Windows.Forms.Button bt_localizar;
        private System.Windows.Forms.Button tb_novo;
        private System.Windows.Forms.DataGridView dgvItens_requisicao;
        private System.Windows.Forms.TextBox tb_obs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_inserir;
        private System.Windows.Forms.TextBox tb_op;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_data_req;
        private System.Windows.Forms.TextBox tb_descricao_item;
        private System.Windows.Forms.TextBox tb_qtde;
        private System.Windows.Forms.TextBox tb_data_limite;
        private System.Windows.Forms.CheckBox cbUrgente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_cod_item;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datRequisicoes;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Data.DataSet dsRequisicoes;
        private System.Data.DataTable REQUISICOES;
        private System.Data.DataColumn COD_REQUISICAO;
        private System.Data.DataColumn REQUISITANTE_REQUISICAO;
        private System.Data.DataColumn SETOR_REQUISICAO;
        private System.Data.DataColumn OBS_REQUISICAO;
        private System.Data.DataColumn DATA_REQUISICAO;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbRequisicoes;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datItens_req;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand8;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand6;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand5;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand7;
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
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbItens_req;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_unidade;
        private System.Windows.Forms.Button button1;
        private System.Data.DataColumn dataColumn1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox tb_email_3;
        private System.Windows.Forms.TextBox tb_email_2;
        private System.Windows.Forms.TextBox tb_email_1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand9;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand10;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand11;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand12;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datEmails_enviados;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand16;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand14;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand13;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand15;
        private System.Data.DataSet dsEmails_enviados;
        private System.Data.DataTable EMAILS_ENVIADOS;
        private System.Data.DataColumn COD_EMAIL_ENVIADO;
        private System.Data.DataColumn DESTINATARIO_EMAIL_ENVIADO;
        private System.Data.DataColumn DATA_EMAIL_ENVIADO;
        private System.Data.DataColumn TIPO_EMAIL_ENVIADO;
        private System.Data.DataColumn HORA_EMAIL_ENVIADO;
        private System.Data.DataColumn CAMINHO_ARQUIVO_EMAIL_ENVIADO;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel barra_status;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datFornecedores;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand20;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand18;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand17;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand19;
        private System.Data.DataSet dsFornecedores;
        private System.Data.DataTable FORNECEDORES;
        private System.Data.DataColumn COD_FORN;
        private System.Data.DataColumn NOME_FORN;
        private System.Data.DataColumn TEL_FORN;
        private System.Data.DataColumn RAZAO_SOCIAL_FORN;
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
        private System.Data.DataColumn CONTATO_FORN;
        private System.Data.DataColumn TEL_CONTATO_FORN;
        private System.Data.DataColumn EMAIL_CONTATO_FORN;
        private System.Data.DataColumn OUTRAS_INF_FORN;
        private System.Data.DataColumn ISO_FORN;
        private System.Data.DataColumn VALIDADE_ISO_FORN;
        private System.Data.DataColumn CERT_UNI_FORN;
        private System.Data.DataColumn VALIDADE_CERT_UNI_FORN;
        private System.Data.DataColumn NOTA_CERT_UNI_FORN;
        private FirebirdSql.Data.FirebirdClient.FbCommand comando_select;
        private System.Data.DataColumn dataColumn2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_pos;
        private System.Windows.Forms.TextBox tb_item_item;
        private System.Windows.Forms.Label label13;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Windows.Forms.TextBox tb_ultima_insercao;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Data.DataSet dsOrcamentos_item_req;
        private System.Data.DataTable ORCAMENTOS_ITEM_REQ;
        private System.Data.DataColumn COD_ORC_ITEM_REQ;
        private System.Data.DataColumn COD_ITEM_ORC_ITEM_REQ;
        private System.Data.DataColumn VALOR_TOTAL_ORC_ITEM_REQ;
        private System.Data.DataColumn FORN_ORC_ITEM_REQ;
        private System.Data.DataColumn dataColumn6;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand21;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datOrcamentos_item_req;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand22;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand23;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand24;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbOrcamentos_item_req;
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
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datItens_ped;
        private System.Windows.Forms.GroupBox gbCotacoes;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tb_data_entrega_orc;
        private System.Windows.Forms.DataGridView dgvOrcamentos_item_req;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tb_valor_cotacao;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tb_forn_cotacao;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvItens_ped;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button9;
        private System.Data.DataColumn dataColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODREQITEMREQDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPITEMREQDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn POSICAO_ITEM_REQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod_estoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn qTDEITEMREQDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uNIDADEITEMREQDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATALIMITEITEMREQDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn uRGENTEITEMREQDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OBS_ITEM_REQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEQUISITANTEITEMREQDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_autorizante;
        private System.Windows.Forms.DataGridViewTextBoxColumn sETORITEMREQDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAREQUISICAOITEMREQDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sITUACAOATUALITEMREQDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Aut;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod_sis;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod_sistema;
        private System.Windows.Forms.DataGridViewTextBoxColumn fORNORCITEMREQDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORTOTALORCITEMREQDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA_ENTREGA_ORC_ITEM_REQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_n_pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_qtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_data_chegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_valor_unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_consumo_medio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}