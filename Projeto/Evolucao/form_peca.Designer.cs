namespace Evolucao
{
    partial class form_peca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_peca));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label20 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
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
            this.label6 = new System.Windows.Forms.Label();
            this.revisao_des = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cod_peca_desenhos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.apaga_registro = new System.Windows.Forms.Button();
            this.salva_registro = new System.Windows.Forms.Button();
            this.vai_anterior = new System.Windows.Forms.Button();
            this.vai_proximo = new System.Windows.Forms.Button();
            this.vai_ultimo = new System.Windows.Forms.Button();
            this.novo_registro = new System.Windows.Forms.Button();
            this.vai_primeiro = new System.Windows.Forms.Button();
            this.fbConnection2 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.cbDesenhos = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.datDesenhos = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand80 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand78 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand77 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand79 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand5 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand6 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand7 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand8 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand9 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand10 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand11 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand12 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand16 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand14 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand13 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand15 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand20 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand18 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand17 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand19 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand21 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand22 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand23 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand24 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand25 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand26 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand27 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand28 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.datClientes = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand32 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand30 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand29 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand31 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsRotas_peca = new System.Data.DataSet();
            this.ROTAS_PECA = new System.Data.DataTable();
            this.COD_ROTA = new System.Data.DataColumn();
            this.OPERACAO = new System.Data.DataColumn();
            this.DESENHO = new System.Data.DataColumn();
            this.POSICAO_FILA = new System.Data.DataColumn();
            this.OBSERVACAO = new System.Data.DataColumn();
            this.dsTiposdeoperacoes = new System.Data.DataSet();
            this.TIPOS_OPERACOES = new System.Data.DataTable();
            this.COD_TIPO = new System.Data.DataColumn();
            this.QDE_MAQUINAS = new System.Data.DataColumn();
            this.TIPO = new System.Data.DataColumn();
            this.material_des = new System.Windows.Forms.TextBox();
            this.tb_posicao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fbCommand36 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand34 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand33 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand35 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.cbSub = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.datTipos_operacoes = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand40 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand38 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand37 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand39 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.datRotas_peca = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand44 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand42 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand41 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand43 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.cbRotas_peca = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.col_posicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_peca_var = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMEPECADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEVISAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mATERIALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSPESSURADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rOTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nSUBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nROTASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_Nsub = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.abre_op = new System.Windows.Forms.Button();
            this.dgvOp = new System.Windows.Forms.DataGridView();
            this.cod_op_coluna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAPDFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNTREGADIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNTREGOUDIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRECOUNITDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pESOTOTALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pDFACEITOEMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nFNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qDEPDFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qDEESTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qDEFABDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qDEEMBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qDECAIXASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESENHOOPATUALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nPDFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONDPGTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.datOp = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand48 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand46 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand45 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand47 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.fbCommand52 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand50 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand49 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand51 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.tbNrotas = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.fbRotas_campo = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.datRotas_campo = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand68 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand66 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand65 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand67 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand56 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand54 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand53 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand55 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.tbN_pdf = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.fbCommand60 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand58 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand57 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand59 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsNum_ops = new System.Data.DataSet();
            this.NUM_OPS = new System.Data.DataTable();
            this.NUMERO_OPS = new System.Data.DataColumn();
            this.N_OPS_CERTO = new System.Data.DataColumn();
            this.datNum_ops = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand64 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand62 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand61 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand63 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.cbNum_ops = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.dsNum_rotas_campo = new System.Data.DataSet();
            this.NUM_ROTAS_CAMPO = new System.Data.DataTable();
            this.COD_NUM_ROTAS_CAMPO = new System.Data.DataColumn();
            this.NUMERO_ROTAS_CAMPO = new System.Data.DataColumn();
            this.datNum_rotas_campo = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand72 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand70 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand69 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand71 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.cbNum_rotas_campo = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
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
            this.tb_posicao_peca = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.datNum_desenhos = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand76 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand74 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand73 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand75 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsNum_desenhos = new System.Data.DataSet();
            this.NUM_DESENHOS = new System.Data.DataTable();
            this.COD_NUM_DESENHOS = new System.Data.DataColumn();
            this.NUMERO_DESENHOS = new System.Data.DataColumn();
            this.tb_num_pecas = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cbNum_desenhos = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
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
            this.datSub = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand84 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand82 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand81 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand83 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.bt_copiar_rota = new System.Windows.Forms.Button();
            this.bt_colar_rota = new System.Windows.Forms.Button();
            this.dgvRota = new System.Windows.Forms.DataGridView();
            this.cODROTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_operacao = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.desenho_coluna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOSICAOFILADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oBSERVACAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btEletrodo = new System.Windows.Forms.Button();
            this.btInserir = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataColumn1 = new System.Data.DataColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dsDesenhos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DESENHOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRotas_peca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ROTAS_PECA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposdeoperacoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TIPOS_OPERACOES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNum_ops)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_OPS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNum_rotas_campo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_ROTAS_CAMPO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRotas_campo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ROTAS_CAMPO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNum_desenhos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_DESENHOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CLIENTES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRota)).BeginInit();
            this.SuspendLayout();
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label20.Location = new System.Drawing.Point(14, 9);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(189, 46);
            this.label20.TabIndex = 81;
            this.label20.Text = "MOLDES";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 147);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 61;
            this.label12.Text = "Cliente:";
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
            this.POSICAO_PECA,
            this.dataColumn1});
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 55;
            this.label6.Text = "Material:";
            // 
            // revisao_des
            // 
            this.revisao_des.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsDesenhos, "DESENHOS.REVISAO", true));
            this.revisao_des.Location = new System.Drawing.Point(109, 116);
            this.revisao_des.Name = "revisao_des";
            this.revisao_des.Size = new System.Drawing.Size(136, 20);
            this.revisao_des.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "Revisão:";
            // 
            // cod_peca_desenhos
            // 
            this.cod_peca_desenhos.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsDesenhos, "DESENHOS.COD_PECA", true));
            this.cod_peca_desenhos.Location = new System.Drawing.Point(109, 90);
            this.cod_peca_desenhos.Name = "cod_peca_desenhos";
            this.cod_peca_desenhos.Size = new System.Drawing.Size(178, 20);
            this.cod_peca_desenhos.TabIndex = 1;
            this.cod_peca_desenhos.DoubleClick += new System.EventHandler(this.cod_peca_desenhos_DoubleClick);
            this.cod_peca_desenhos.TextChanged += new System.EventHandler(this.cod_peca_desenhos_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "OS:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(10, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 26);
            this.label4.TabIndex = 83;
            this.label4.Text = "Rota:";
            // 
            // apaga_registro
            // 
            this.apaga_registro.Location = new System.Drawing.Point(503, 177);
            this.apaga_registro.Name = "apaga_registro";
            this.apaga_registro.Size = new System.Drawing.Size(49, 22);
            this.apaga_registro.TabIndex = 91;
            this.apaga_registro.Text = "Excluir";
            this.apaga_registro.UseVisualStyleBackColor = true;
            // 
            // salva_registro
            // 
            this.salva_registro.Location = new System.Drawing.Point(558, 177);
            this.salva_registro.Name = "salva_registro";
            this.salva_registro.Size = new System.Drawing.Size(49, 22);
            this.salva_registro.TabIndex = 90;
            this.salva_registro.Text = "Salvar";
            this.salva_registro.UseVisualStyleBackColor = true;
            this.salva_registro.Click += new System.EventHandler(this.salva_registro_Click);
            // 
            // vai_anterior
            // 
            this.vai_anterior.Location = new System.Drawing.Point(279, 177);
            this.vai_anterior.Name = "vai_anterior";
            this.vai_anterior.Size = new System.Drawing.Size(49, 22);
            this.vai_anterior.TabIndex = 89;
            this.vai_anterior.Text = "<";
            this.vai_anterior.UseVisualStyleBackColor = true;
            this.vai_anterior.Click += new System.EventHandler(this.vai_anterior_Click);
            // 
            // vai_proximo
            // 
            this.vai_proximo.Location = new System.Drawing.Point(336, 177);
            this.vai_proximo.Name = "vai_proximo";
            this.vai_proximo.Size = new System.Drawing.Size(49, 22);
            this.vai_proximo.TabIndex = 88;
            this.vai_proximo.Text = ">";
            this.vai_proximo.UseVisualStyleBackColor = true;
            this.vai_proximo.Click += new System.EventHandler(this.vai_proximo_Click);
            // 
            // vai_ultimo
            // 
            this.vai_ultimo.Location = new System.Drawing.Point(391, 177);
            this.vai_ultimo.Name = "vai_ultimo";
            this.vai_ultimo.Size = new System.Drawing.Size(49, 22);
            this.vai_ultimo.TabIndex = 87;
            this.vai_ultimo.Text = ">>";
            this.vai_ultimo.UseVisualStyleBackColor = true;
            this.vai_ultimo.Click += new System.EventHandler(this.vai_ultimo_Click);
            // 
            // novo_registro
            // 
            this.novo_registro.Location = new System.Drawing.Point(448, 177);
            this.novo_registro.Name = "novo_registro";
            this.novo_registro.Size = new System.Drawing.Size(49, 22);
            this.novo_registro.TabIndex = 85;
            this.novo_registro.Text = "Novo";
            this.novo_registro.UseVisualStyleBackColor = true;
            this.novo_registro.Click += new System.EventHandler(this.novo_registro_Click);
            // 
            // vai_primeiro
            // 
            this.vai_primeiro.Location = new System.Drawing.Point(224, 177);
            this.vai_primeiro.Name = "vai_primeiro";
            this.vai_primeiro.Size = new System.Drawing.Size(49, 22);
            this.vai_primeiro.TabIndex = 84;
            this.vai_primeiro.Text = "<<";
            this.vai_primeiro.UseVisualStyleBackColor = true;
            this.vai_primeiro.Click += new System.EventHandler(this.vai_primeiro_Click);
            // 
            // fbConnection2
            // 
            this.fbConnection2.ConnectionString = resources.GetString("fbConnection2.ConnectionString");
            this.fbConnection2.InfoMessage += new FirebirdSql.Data.FirebirdClient.FbInfoMessageEventHandler(this.fbConnection2_InfoMessage);
            // 
            // fbCommand4
            // 
            this.fbCommand4.CommandTimeout = 30;
            this.fbCommand4.Connection = this.fbConnection2;
            // 
            // fbCommand2
            // 
            this.fbCommand2.CommandTimeout = 30;
            this.fbCommand2.Connection = this.fbConnection2;
            // 
            // fbCommand1
            // 
            this.fbCommand1.CommandText = "select * from desenhos";
            this.fbCommand1.CommandTimeout = 30;
            this.fbCommand1.Connection = this.fbConnection2;
            // 
            // fbCommand3
            // 
            this.fbCommand3.CommandTimeout = 30;
            this.fbCommand3.Connection = this.fbConnection2;
            // 
            // cbDesenhos
            // 
            this.cbDesenhos.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbDesenhos.DataAdapter = this.datDesenhos;
            this.cbDesenhos.QuotePrefix = "\"";
            this.cbDesenhos.QuoteSuffix = "\"";
            // 
            // datDesenhos
            // 
            this.datDesenhos.DeleteCommand = this.fbCommand80;
            this.datDesenhos.InsertCommand = this.fbCommand78;
            this.datDesenhos.SelectCommand = this.fbCommand77;
            this.datDesenhos.UpdateCommand = this.fbCommand79;
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
            this.fbCommand77.CommandText = "SELECT * FROM DESENHOS";
            this.fbCommand77.CommandTimeout = 30;
            this.fbCommand77.Connection = this.fbConnection2;
            // 
            // fbCommand79
            // 
            this.fbCommand79.CommandTimeout = 30;
            // 
            // fbCommand5
            // 
            this.fbCommand5.CommandText = "select * from rotas";
            this.fbCommand5.CommandTimeout = 30;
            this.fbCommand5.Connection = this.fbConnection2;
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
            // fbCommand16
            // 
            this.fbCommand16.CommandTimeout = 30;
            this.fbCommand16.Connection = this.fbConnection2;
            // 
            // fbCommand14
            // 
            this.fbCommand14.CommandTimeout = 30;
            this.fbCommand14.Connection = this.fbConnection2;
            // 
            // fbCommand13
            // 
            this.fbCommand13.CommandText = "select * from rotas";
            this.fbCommand13.CommandTimeout = 30;
            this.fbCommand13.Connection = this.fbConnection2;
            // 
            // fbCommand15
            // 
            this.fbCommand15.CommandTimeout = 30;
            this.fbCommand15.Connection = this.fbConnection2;
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
            this.fbCommand17.CommandText = "select * from clientes";
            this.fbCommand17.CommandTimeout = 30;
            this.fbCommand17.Connection = this.fbConnection2;
            // 
            // fbCommand19
            // 
            this.fbCommand19.CommandTimeout = 30;
            // 
            // fbCommand21
            // 
            this.fbCommand21.CommandTimeout = 30;
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
            // fbCommand25
            // 
            this.fbCommand25.CommandText = "select * from clientes";
            this.fbCommand25.CommandTimeout = 30;
            this.fbCommand25.Connection = this.fbConnection2;
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
            // datClientes
            // 
            this.datClientes.DeleteCommand = this.fbCommand32;
            this.datClientes.InsertCommand = this.fbCommand30;
            this.datClientes.SelectCommand = this.fbCommand29;
            this.datClientes.UpdateCommand = this.fbCommand31;
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
            this.fbCommand29.CommandText = "select * from clientes";
            this.fbCommand29.CommandTimeout = 30;
            this.fbCommand29.Connection = this.fbConnection2;
            // 
            // fbCommand31
            // 
            this.fbCommand31.CommandTimeout = 30;
            // 
            // dsRotas_peca
            // 
            this.dsRotas_peca.DataSetName = "dsRotas_peca";
            this.dsRotas_peca.Namespace = "http://www.tempuri.org/dsRotas_peca.xsd";
            this.dsRotas_peca.Tables.AddRange(new System.Data.DataTable[] {
            this.ROTAS_PECA});
            // 
            // ROTAS_PECA
            // 
            this.ROTAS_PECA.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_ROTA,
            this.OPERACAO,
            this.DESENHO,
            this.POSICAO_FILA,
            this.OBSERVACAO});
            this.ROTAS_PECA.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_ROTA"}, false)});
            this.ROTAS_PECA.TableName = "ROTAS_PECA";
            // 
            // COD_ROTA
            // 
            this.COD_ROTA.AutoIncrement = true;
            this.COD_ROTA.AutoIncrementSeed = ((long)(1));
            this.COD_ROTA.ColumnName = "COD_ROTA";
            this.COD_ROTA.DataType = typeof(int);
            // 
            // OPERACAO
            // 
            this.OPERACAO.ColumnName = "OPERACAO";
            this.OPERACAO.MaxLength = 30;
            // 
            // DESENHO
            // 
            this.DESENHO.ColumnName = "DESENHO";
            this.DESENHO.MaxLength = 30;
            // 
            // POSICAO_FILA
            // 
            this.POSICAO_FILA.ColumnName = "POSICAO_FILA";
            this.POSICAO_FILA.DataType = typeof(int);
            // 
            // OBSERVACAO
            // 
            this.OBSERVACAO.ColumnName = "OBSERVACAO";
            this.OBSERVACAO.MaxLength = 60;
            // 
            // dsTiposdeoperacoes
            // 
            this.dsTiposdeoperacoes.DataSetName = "dsTiposdeoperacoes";
            this.dsTiposdeoperacoes.Namespace = "http://www.tempuri.org/dsTiposdeoperacoes.xsd";
            this.dsTiposdeoperacoes.Tables.AddRange(new System.Data.DataTable[] {
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
            // material_des
            // 
            this.material_des.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsDesenhos, "DESENHOS.MATERIAL", true));
            this.material_des.Location = new System.Drawing.Point(349, 116);
            this.material_des.Name = "material_des";
            this.material_des.Size = new System.Drawing.Size(136, 20);
            this.material_des.TabIndex = 4;
            // 
            // tb_posicao
            // 
            this.tb_posicao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsDesenhos, "DESENHOS.NOME_PECA", true));
            this.tb_posicao.Location = new System.Drawing.Point(386, 90);
            this.tb_posicao.Name = "tb_posicao";
            this.tb_posicao.Size = new System.Drawing.Size(99, 20);
            this.tb_posicao.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 97;
            this.label1.Text = "Pos/Nome:";
            // 
            // fbCommand36
            // 
            this.fbCommand36.CommandTimeout = 30;
            this.fbCommand36.Connection = this.fbConnection2;
            // 
            // fbCommand34
            // 
            this.fbCommand34.CommandTimeout = 30;
            this.fbCommand34.Connection = this.fbConnection2;
            // 
            // fbCommand33
            // 
            this.fbCommand33.CommandText = "select * from sub";
            this.fbCommand33.CommandTimeout = 30;
            this.fbCommand33.Connection = this.fbConnection2;
            // 
            // fbCommand35
            // 
            this.fbCommand35.CommandTimeout = 30;
            this.fbCommand35.Connection = this.fbConnection2;
            // 
            // cbSub
            // 
            this.cbSub.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbSub.QuotePrefix = "\"";
            this.cbSub.QuoteSuffix = "\"";
            // 
            // datTipos_operacoes
            // 
            this.datTipos_operacoes.DeleteCommand = this.fbCommand40;
            this.datTipos_operacoes.InsertCommand = this.fbCommand38;
            this.datTipos_operacoes.SelectCommand = this.fbCommand37;
            this.datTipos_operacoes.UpdateCommand = this.fbCommand39;
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
            this.fbCommand37.CommandText = "select * from tipos_operacoes order by cod_tipo";
            this.fbCommand37.CommandTimeout = 30;
            this.fbCommand37.Connection = this.fbConnection2;
            // 
            // fbCommand39
            // 
            this.fbCommand39.CommandTimeout = 30;
            // 
            // datRotas_peca
            // 
            this.datRotas_peca.DeleteCommand = this.fbCommand44;
            this.datRotas_peca.InsertCommand = this.fbCommand42;
            this.datRotas_peca.SelectCommand = this.fbCommand41;
            this.datRotas_peca.UpdateCommand = this.fbCommand43;
            // 
            // fbCommand44
            // 
            this.fbCommand44.CommandTimeout = 30;
            // 
            // fbCommand42
            // 
            this.fbCommand42.CommandTimeout = 30;
            // 
            // fbCommand41
            // 
            this.fbCommand41.CommandText = "select * from rotas_peca order by cod_rota";
            this.fbCommand41.CommandTimeout = 30;
            this.fbCommand41.Connection = this.fbConnection2;
            // 
            // fbCommand43
            // 
            this.fbCommand43.CommandTimeout = 30;
            // 
            // cbRotas_peca
            // 
            this.cbRotas_peca.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbRotas_peca.DataAdapter = this.datRotas_peca;
            this.cbRotas_peca.QuotePrefix = "\"";
            this.cbRotas_peca.QuoteSuffix = "\"";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_posicao,
            this.cod_peca_var,
            this.nOMEPECADataGridViewTextBoxColumn,
            this.rEVISAODataGridViewTextBoxColumn,
            this.mATERIALDataGridViewTextBoxColumn,
            this.eSPESSURADataGridViewTextBoxColumn,
            this.cLIENTEDataGridViewTextBoxColumn,
            this.rOTADataGridViewTextBoxColumn,
            this.nSUBDataGridViewTextBoxColumn,
            this.nROTASDataGridViewTextBoxColumn});
            this.dataGridView1.DataMember = "DESENHOS";
            this.dataGridView1.DataSource = this.dsDesenhos;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 481);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(749, 205);
            this.dataGridView1.TabIndex = 100;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // col_posicao
            // 
            this.col_posicao.DataPropertyName = "POSICAO_PECA";
            this.col_posicao.HeaderText = "Cod.";
            this.col_posicao.Name = "col_posicao";
            // 
            // cod_peca_var
            // 
            this.cod_peca_var.DataPropertyName = "COD_PECA";
            this.cod_peca_var.HeaderText = "Peça";
            this.cod_peca_var.Name = "cod_peca_var";
            this.cod_peca_var.Width = 150;
            // 
            // nOMEPECADataGridViewTextBoxColumn
            // 
            this.nOMEPECADataGridViewTextBoxColumn.DataPropertyName = "NOME_PECA";
            this.nOMEPECADataGridViewTextBoxColumn.HeaderText = "Posição";
            this.nOMEPECADataGridViewTextBoxColumn.Name = "nOMEPECADataGridViewTextBoxColumn";
            this.nOMEPECADataGridViewTextBoxColumn.Width = 250;
            // 
            // rEVISAODataGridViewTextBoxColumn
            // 
            this.rEVISAODataGridViewTextBoxColumn.DataPropertyName = "REVISAO";
            this.rEVISAODataGridViewTextBoxColumn.HeaderText = "Revisão";
            this.rEVISAODataGridViewTextBoxColumn.Name = "rEVISAODataGridViewTextBoxColumn";
            this.rEVISAODataGridViewTextBoxColumn.Width = 50;
            // 
            // mATERIALDataGridViewTextBoxColumn
            // 
            this.mATERIALDataGridViewTextBoxColumn.DataPropertyName = "MATERIAL";
            this.mATERIALDataGridViewTextBoxColumn.HeaderText = "MATERIAL";
            this.mATERIALDataGridViewTextBoxColumn.Name = "mATERIALDataGridViewTextBoxColumn";
            this.mATERIALDataGridViewTextBoxColumn.Visible = false;
            // 
            // eSPESSURADataGridViewTextBoxColumn
            // 
            this.eSPESSURADataGridViewTextBoxColumn.DataPropertyName = "ESPESSURA";
            this.eSPESSURADataGridViewTextBoxColumn.HeaderText = "ESPESSURA";
            this.eSPESSURADataGridViewTextBoxColumn.Name = "eSPESSURADataGridViewTextBoxColumn";
            this.eSPESSURADataGridViewTextBoxColumn.Visible = false;
            // 
            // cLIENTEDataGridViewTextBoxColumn
            // 
            this.cLIENTEDataGridViewTextBoxColumn.DataPropertyName = "CLIENTE";
            this.cLIENTEDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.cLIENTEDataGridViewTextBoxColumn.Name = "cLIENTEDataGridViewTextBoxColumn";
            this.cLIENTEDataGridViewTextBoxColumn.Width = 150;
            // 
            // rOTADataGridViewTextBoxColumn
            // 
            this.rOTADataGridViewTextBoxColumn.DataPropertyName = "ROTA";
            this.rOTADataGridViewTextBoxColumn.HeaderText = "ROTA";
            this.rOTADataGridViewTextBoxColumn.Name = "rOTADataGridViewTextBoxColumn";
            this.rOTADataGridViewTextBoxColumn.Visible = false;
            // 
            // nSUBDataGridViewTextBoxColumn
            // 
            this.nSUBDataGridViewTextBoxColumn.DataPropertyName = "N_SUB";
            this.nSUBDataGridViewTextBoxColumn.HeaderText = "N_SUB";
            this.nSUBDataGridViewTextBoxColumn.Name = "nSUBDataGridViewTextBoxColumn";
            this.nSUBDataGridViewTextBoxColumn.Visible = false;
            // 
            // nROTASDataGridViewTextBoxColumn
            // 
            this.nROTASDataGridViewTextBoxColumn.DataPropertyName = "N_ROTAS";
            this.nROTASDataGridViewTextBoxColumn.HeaderText = "N_ROTAS";
            this.nROTASDataGridViewTextBoxColumn.Name = "nROTASDataGridViewTextBoxColumn";
            this.nROTASDataGridViewTextBoxColumn.Visible = false;
            // 
            // tb_Nsub
            // 
            this.tb_Nsub.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsDesenhos, "DESENHOS.N_SUB", true));
            this.tb_Nsub.Location = new System.Drawing.Point(708, 455);
            this.tb_Nsub.Name = "tb_Nsub";
            this.tb_Nsub.Size = new System.Drawing.Size(54, 20);
            this.tb_Nsub.TabIndex = 101;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(570, 457);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 13);
            this.label7.TabIndex = 102;
            this.label7.Text = "N. de Sub-componentes:";
            // 
            // abre_op
            // 
            this.abre_op.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abre_op.Location = new System.Drawing.Point(618, 206);
            this.abre_op.Name = "abre_op";
            this.abre_op.Size = new System.Drawing.Size(203, 43);
            this.abre_op.TabIndex = 126;
            this.abre_op.Text = "Criar OS";
            this.abre_op.UseVisualStyleBackColor = true;
            this.abre_op.Click += new System.EventHandler(this.abre_op_Click);
            // 
            // dgvOp
            // 
            this.dgvOp.AutoGenerateColumns = false;
            this.dgvOp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOp.ColumnHeadersVisible = false;
            this.dgvOp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_op_coluna,
            this.dATAPDFDataGridViewTextBoxColumn,
            this.eNTREGADIADataGridViewTextBoxColumn,
            this.eNTREGOUDIADataGridViewTextBoxColumn,
            this.pRECOUNITDataGridViewTextBoxColumn,
            this.pESOTOTALDataGridViewTextBoxColumn,
            this.pDFACEITOEMDataGridViewTextBoxColumn,
            this.nFNDataGridViewTextBoxColumn,
            this.qDEPDFDataGridViewTextBoxColumn,
            this.qDEESTDataGridViewTextBoxColumn,
            this.qDEFABDataGridViewTextBoxColumn,
            this.qDEEMBDataGridViewTextBoxColumn,
            this.qDECAIXASDataGridViewTextBoxColumn,
            this.dESENHOOPATUALDataGridViewTextBoxColumn,
            this.nPDFDataGridViewTextBoxColumn,
            this.cONDPGTODataGridViewTextBoxColumn});
            this.dgvOp.DataMember = "OP";
            this.dgvOp.DataSource = this.dsOp;
            this.dgvOp.Location = new System.Drawing.Point(618, 316);
            this.dgvOp.Name = "dgvOp";
            this.dgvOp.RowHeadersVisible = false;
            this.dgvOp.Size = new System.Drawing.Size(203, 133);
            this.dgvOp.TabIndex = 127;
            this.dgvOp.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvOp_CellMouseDoubleClick);
            this.dgvOp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOp_CellContentClick);
            // 
            // cod_op_coluna
            // 
            this.cod_op_coluna.DataPropertyName = "COD_OP";
            this.cod_op_coluna.HeaderText = "COD_OP";
            this.cod_op_coluna.Name = "cod_op_coluna";
            this.cod_op_coluna.Width = 30;
            // 
            // dATAPDFDataGridViewTextBoxColumn
            // 
            this.dATAPDFDataGridViewTextBoxColumn.DataPropertyName = "DATA_PDF";
            this.dATAPDFDataGridViewTextBoxColumn.HeaderText = "DATA_PDF";
            this.dATAPDFDataGridViewTextBoxColumn.Name = "dATAPDFDataGridViewTextBoxColumn";
            this.dATAPDFDataGridViewTextBoxColumn.Visible = false;
            // 
            // eNTREGADIADataGridViewTextBoxColumn
            // 
            this.eNTREGADIADataGridViewTextBoxColumn.DataPropertyName = "ENTREGA_DIA";
            this.eNTREGADIADataGridViewTextBoxColumn.HeaderText = "ENTREGA_DIA";
            this.eNTREGADIADataGridViewTextBoxColumn.Name = "eNTREGADIADataGridViewTextBoxColumn";
            this.eNTREGADIADataGridViewTextBoxColumn.Visible = false;
            // 
            // eNTREGOUDIADataGridViewTextBoxColumn
            // 
            this.eNTREGOUDIADataGridViewTextBoxColumn.DataPropertyName = "ENTREGOU_DIA";
            this.eNTREGOUDIADataGridViewTextBoxColumn.HeaderText = "ENTREGOU_DIA";
            this.eNTREGOUDIADataGridViewTextBoxColumn.Name = "eNTREGOUDIADataGridViewTextBoxColumn";
            this.eNTREGOUDIADataGridViewTextBoxColumn.Visible = false;
            // 
            // pRECOUNITDataGridViewTextBoxColumn
            // 
            this.pRECOUNITDataGridViewTextBoxColumn.DataPropertyName = "PRECO_UNIT";
            this.pRECOUNITDataGridViewTextBoxColumn.HeaderText = "PRECO_UNIT";
            this.pRECOUNITDataGridViewTextBoxColumn.Name = "pRECOUNITDataGridViewTextBoxColumn";
            this.pRECOUNITDataGridViewTextBoxColumn.Visible = false;
            // 
            // pESOTOTALDataGridViewTextBoxColumn
            // 
            this.pESOTOTALDataGridViewTextBoxColumn.DataPropertyName = "PESO_TOTAL";
            this.pESOTOTALDataGridViewTextBoxColumn.HeaderText = "PESO_TOTAL";
            this.pESOTOTALDataGridViewTextBoxColumn.Name = "pESOTOTALDataGridViewTextBoxColumn";
            this.pESOTOTALDataGridViewTextBoxColumn.Visible = false;
            // 
            // pDFACEITOEMDataGridViewTextBoxColumn
            // 
            this.pDFACEITOEMDataGridViewTextBoxColumn.DataPropertyName = "PDF_ACEITO_EM";
            this.pDFACEITOEMDataGridViewTextBoxColumn.HeaderText = "PDF_ACEITO_EM";
            this.pDFACEITOEMDataGridViewTextBoxColumn.Name = "pDFACEITOEMDataGridViewTextBoxColumn";
            this.pDFACEITOEMDataGridViewTextBoxColumn.Visible = false;
            // 
            // nFNDataGridViewTextBoxColumn
            // 
            this.nFNDataGridViewTextBoxColumn.DataPropertyName = "NF_N";
            this.nFNDataGridViewTextBoxColumn.HeaderText = "NF_N";
            this.nFNDataGridViewTextBoxColumn.Name = "nFNDataGridViewTextBoxColumn";
            this.nFNDataGridViewTextBoxColumn.Visible = false;
            // 
            // qDEPDFDataGridViewTextBoxColumn
            // 
            this.qDEPDFDataGridViewTextBoxColumn.DataPropertyName = "QDE_PDF";
            this.qDEPDFDataGridViewTextBoxColumn.HeaderText = "QDE_PDF";
            this.qDEPDFDataGridViewTextBoxColumn.Name = "qDEPDFDataGridViewTextBoxColumn";
            this.qDEPDFDataGridViewTextBoxColumn.Visible = false;
            // 
            // qDEESTDataGridViewTextBoxColumn
            // 
            this.qDEESTDataGridViewTextBoxColumn.DataPropertyName = "QDE_EST";
            this.qDEESTDataGridViewTextBoxColumn.HeaderText = "QDE_EST";
            this.qDEESTDataGridViewTextBoxColumn.Name = "qDEESTDataGridViewTextBoxColumn";
            this.qDEESTDataGridViewTextBoxColumn.Visible = false;
            // 
            // qDEFABDataGridViewTextBoxColumn
            // 
            this.qDEFABDataGridViewTextBoxColumn.DataPropertyName = "QDE_FAB";
            this.qDEFABDataGridViewTextBoxColumn.HeaderText = "QDE_FAB";
            this.qDEFABDataGridViewTextBoxColumn.Name = "qDEFABDataGridViewTextBoxColumn";
            this.qDEFABDataGridViewTextBoxColumn.Visible = false;
            // 
            // qDEEMBDataGridViewTextBoxColumn
            // 
            this.qDEEMBDataGridViewTextBoxColumn.DataPropertyName = "QDE_EMB";
            this.qDEEMBDataGridViewTextBoxColumn.HeaderText = "QDE_EMB";
            this.qDEEMBDataGridViewTextBoxColumn.Name = "qDEEMBDataGridViewTextBoxColumn";
            this.qDEEMBDataGridViewTextBoxColumn.Visible = false;
            // 
            // qDECAIXASDataGridViewTextBoxColumn
            // 
            this.qDECAIXASDataGridViewTextBoxColumn.DataPropertyName = "QDE_CAIXAS";
            this.qDECAIXASDataGridViewTextBoxColumn.HeaderText = "QDE_CAIXAS";
            this.qDECAIXASDataGridViewTextBoxColumn.Name = "qDECAIXASDataGridViewTextBoxColumn";
            this.qDECAIXASDataGridViewTextBoxColumn.Visible = false;
            // 
            // dESENHOOPATUALDataGridViewTextBoxColumn
            // 
            this.dESENHOOPATUALDataGridViewTextBoxColumn.DataPropertyName = "DESENHO_OP_ATUAL";
            this.dESENHOOPATUALDataGridViewTextBoxColumn.HeaderText = "DESENHO_OP_ATUAL";
            this.dESENHOOPATUALDataGridViewTextBoxColumn.Name = "dESENHOOPATUALDataGridViewTextBoxColumn";
            this.dESENHOOPATUALDataGridViewTextBoxColumn.Width = 50;
            // 
            // nPDFDataGridViewTextBoxColumn
            // 
            this.nPDFDataGridViewTextBoxColumn.DataPropertyName = "N_PDF";
            this.nPDFDataGridViewTextBoxColumn.HeaderText = "N_PDF";
            this.nPDFDataGridViewTextBoxColumn.Name = "nPDFDataGridViewTextBoxColumn";
            this.nPDFDataGridViewTextBoxColumn.Width = 50;
            // 
            // cONDPGTODataGridViewTextBoxColumn
            // 
            this.cONDPGTODataGridViewTextBoxColumn.DataPropertyName = "COND_PGTO";
            this.cONDPGTODataGridViewTextBoxColumn.HeaderText = "Obs";
            this.cONDPGTODataGridViewTextBoxColumn.Name = "cONDPGTODataGridViewTextBoxColumn";
            this.cONDPGTODataGridViewTextBoxColumn.Width = 65;
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
            this.N_PDF});
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
            this.PRECO_UNIT.MaxLength = 10;
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
            // datOp
            // 
            this.datOp.DeleteCommand = this.fbCommand48;
            this.datOp.InsertCommand = this.fbCommand46;
            this.datOp.SelectCommand = this.fbCommand45;
            this.datOp.UpdateCommand = this.fbCommand47;
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
            this.fbCommand45.CommandText = "select * from op";
            this.fbCommand45.CommandTimeout = 30;
            this.fbCommand45.Connection = this.fbConnection2;
            // 
            // fbCommand47
            // 
            this.fbCommand47.CommandTimeout = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(615, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 13);
            this.label8.TabIndex = 128;
            this.label8.Text = "Para abrir a OS clique abaixo:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 457);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 22);
            this.button1.TabIndex = 99;
            this.button1.Text = "Inserir Sub-componente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fbCommand52
            // 
            this.fbCommand52.CommandTimeout = 30;
            // 
            // fbCommand50
            // 
            this.fbCommand50.CommandText = "INSERT INTO ROTAS_CAMPO (COD_ROTA_PECA, OBSERVACAO_CAMPO) VALUES (\'TESTE1\', \'TEST" +
                "E2\')";
            this.fbCommand50.CommandTimeout = 30;
            this.fbCommand50.Connection = this.fbConnection2;
            // 
            // fbCommand49
            // 
            this.fbCommand49.CommandText = "select * from rotas_campo";
            this.fbCommand49.CommandTimeout = 30;
            this.fbCommand49.Connection = this.fbConnection2;
            // 
            // fbCommand51
            // 
            this.fbCommand51.CommandTimeout = 30;
            // 
            // tbNrotas
            // 
            this.tbNrotas.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsDesenhos, "DESENHOS.N_ROTAS", true));
            this.tbNrotas.Location = new System.Drawing.Point(185, 179);
            this.tbNrotas.Name = "tbNrotas";
            this.tbNrotas.Size = new System.Drawing.Size(33, 20);
            this.tbNrotas.TabIndex = 129;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(87, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 130;
            this.label9.Text = "Nº de Operações:";
            // 
            // fbRotas_campo
            // 
            this.fbRotas_campo.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.fbRotas_campo.DataAdapter = this.datRotas_campo;
            this.fbRotas_campo.QuotePrefix = "\"";
            this.fbRotas_campo.QuoteSuffix = "\"";
            // 
            // datRotas_campo
            // 
            this.datRotas_campo.DeleteCommand = this.fbCommand68;
            this.datRotas_campo.InsertCommand = this.fbCommand66;
            this.datRotas_campo.SelectCommand = this.fbCommand65;
            this.datRotas_campo.UpdateCommand = this.fbCommand67;
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
            this.fbCommand65.CommandText = "select * from rotas_campo";
            this.fbCommand65.CommandTimeout = 30;
            this.fbCommand65.Connection = this.fbConnection2;
            // 
            // fbCommand67
            // 
            this.fbCommand67.CommandTimeout = 30;
            // 
            // fbCommand56
            // 
            this.fbCommand56.CommandTimeout = 30;
            // 
            // fbCommand54
            // 
            this.fbCommand54.CommandText = "INSERT INTO ROTAS_CAMPO (COD_ROTA_CAMPO, COD_ROTA_PECA, OBSERVACAO_CAMPO) VALUES " +
                "()";
            this.fbCommand54.CommandTimeout = 30;
            this.fbCommand54.Connection = this.fbConnection2;
            // 
            // fbCommand53
            // 
            this.fbCommand53.CommandText = "select * from rotas_campo";
            this.fbCommand53.CommandTimeout = 30;
            this.fbCommand53.Connection = this.fbConnection2;
            // 
            // fbCommand55
            // 
            this.fbCommand55.CommandTimeout = 30;
            // 
            // tbN_pdf
            // 
            this.tbN_pdf.Location = new System.Drawing.Point(722, 183);
            this.tbN_pdf.Name = "tbN_pdf";
            this.tbN_pdf.Size = new System.Drawing.Size(99, 20);
            this.tbN_pdf.TabIndex = 131;
            this.tbN_pdf.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(656, 186);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 132;
            this.label10.Text = "Novo PDF:";
            this.label10.Visible = false;
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
            this.fbCommand57.CommandText = "select * from n_ops";
            this.fbCommand57.CommandTimeout = 30;
            this.fbCommand57.Connection = this.fbConnection2;
            // 
            // fbCommand59
            // 
            this.fbCommand59.CommandTimeout = 30;
            // 
            // dsNum_ops
            // 
            this.dsNum_ops.DataSetName = "dsNum_ops";
            this.dsNum_ops.Namespace = "http://www.tempuri.org/dsNum_ops.xsd";
            this.dsNum_ops.Tables.AddRange(new System.Data.DataTable[] {
            this.NUM_OPS});
            // 
            // NUM_OPS
            // 
            this.NUM_OPS.Columns.AddRange(new System.Data.DataColumn[] {
            this.NUMERO_OPS,
            this.N_OPS_CERTO});
            this.NUM_OPS.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "NUMERO_OPS"}, true)});
            this.NUM_OPS.PrimaryKey = new System.Data.DataColumn[] {
        this.NUMERO_OPS};
            this.NUM_OPS.TableName = "NUM_OPS";
            // 
            // NUMERO_OPS
            // 
            this.NUMERO_OPS.AllowDBNull = false;
            this.NUMERO_OPS.ColumnName = "NUMERO_OPS";
            this.NUMERO_OPS.DataType = typeof(int);
            // 
            // N_OPS_CERTO
            // 
            this.N_OPS_CERTO.ColumnName = "N_OPS_CERTO";
            this.N_OPS_CERTO.DataType = typeof(int);
            // 
            // datNum_ops
            // 
            this.datNum_ops.DeleteCommand = this.fbCommand64;
            this.datNum_ops.InsertCommand = this.fbCommand62;
            this.datNum_ops.SelectCommand = this.fbCommand61;
            this.datNum_ops.UpdateCommand = this.fbCommand63;
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
            this.fbCommand61.CommandText = "SELECT * FROM NUM_OPS";
            this.fbCommand61.CommandTimeout = 30;
            this.fbCommand61.Connection = this.fbConnection2;
            // 
            // fbCommand63
            // 
            this.fbCommand63.CommandTimeout = 30;
            // 
            // cbNum_ops
            // 
            this.cbNum_ops.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbNum_ops.DataAdapter = this.datNum_ops;
            this.cbNum_ops.QuotePrefix = "\"";
            this.cbNum_ops.QuoteSuffix = "\"";
            // 
            // dsNum_rotas_campo
            // 
            this.dsNum_rotas_campo.DataSetName = "dsNum_rotas_campo";
            this.dsNum_rotas_campo.Namespace = "http://www.tempuri.org/dsNum_rotas_campo.xsd";
            this.dsNum_rotas_campo.Tables.AddRange(new System.Data.DataTable[] {
            this.NUM_ROTAS_CAMPO});
            // 
            // NUM_ROTAS_CAMPO
            // 
            this.NUM_ROTAS_CAMPO.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_NUM_ROTAS_CAMPO,
            this.NUMERO_ROTAS_CAMPO});
            this.NUM_ROTAS_CAMPO.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_NUM_ROTAS_CAMPO"}, true)});
            this.NUM_ROTAS_CAMPO.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_NUM_ROTAS_CAMPO};
            this.NUM_ROTAS_CAMPO.TableName = "NUM_ROTAS_CAMPO";
            // 
            // COD_NUM_ROTAS_CAMPO
            // 
            this.COD_NUM_ROTAS_CAMPO.AllowDBNull = false;
            this.COD_NUM_ROTAS_CAMPO.ColumnName = "COD_NUM_ROTAS_CAMPO";
            this.COD_NUM_ROTAS_CAMPO.DataType = typeof(int);
            // 
            // NUMERO_ROTAS_CAMPO
            // 
            this.NUMERO_ROTAS_CAMPO.ColumnName = "NUMERO_ROTAS_CAMPO";
            this.NUMERO_ROTAS_CAMPO.DataType = typeof(int);
            // 
            // datNum_rotas_campo
            // 
            this.datNum_rotas_campo.DeleteCommand = this.fbCommand72;
            this.datNum_rotas_campo.InsertCommand = this.fbCommand70;
            this.datNum_rotas_campo.SelectCommand = this.fbCommand69;
            this.datNum_rotas_campo.UpdateCommand = this.fbCommand71;
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
            this.fbCommand69.CommandText = "select * from num_rotas_campo";
            this.fbCommand69.CommandTimeout = 30;
            this.fbCommand69.Connection = this.fbConnection2;
            // 
            // fbCommand71
            // 
            this.fbCommand71.CommandTimeout = 30;
            // 
            // cbNum_rotas_campo
            // 
            this.cbNum_rotas_campo.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbNum_rotas_campo.DataAdapter = this.datNum_rotas_campo;
            this.cbNum_rotas_campo.QuotePrefix = "\"";
            this.cbNum_rotas_campo.QuoteSuffix = "\"";
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
            this.MAQUINA});
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
            // tb_posicao_peca
            // 
            this.tb_posicao_peca.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsDesenhos, "DESENHOS.POSICAO_PECA", true));
            this.tb_posicao_peca.Location = new System.Drawing.Point(246, 60);
            this.tb_posicao_peca.Name = "tb_posicao_peca";
            this.tb_posicao_peca.Size = new System.Drawing.Size(41, 20);
            this.tb_posicao_peca.TabIndex = 137;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(149, 63);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 13);
            this.label14.TabIndex = 138;
            this.label14.Text = "Código Interno:";
            // 
            // datNum_desenhos
            // 
            this.datNum_desenhos.DeleteCommand = this.fbCommand76;
            this.datNum_desenhos.InsertCommand = this.fbCommand74;
            this.datNum_desenhos.SelectCommand = this.fbCommand73;
            this.datNum_desenhos.UpdateCommand = this.fbCommand75;
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
            this.fbCommand73.CommandText = "select * from num_desenhos";
            this.fbCommand73.CommandTimeout = 30;
            this.fbCommand73.Connection = this.fbConnection2;
            // 
            // fbCommand75
            // 
            this.fbCommand75.CommandTimeout = 30;
            // 
            // dsNum_desenhos
            // 
            this.dsNum_desenhos.DataSetName = "dsNum_desenhos";
            this.dsNum_desenhos.Namespace = "http://www.tempuri.org/dsNum_desenhos.xsd";
            this.dsNum_desenhos.Tables.AddRange(new System.Data.DataTable[] {
            this.NUM_DESENHOS});
            // 
            // NUM_DESENHOS
            // 
            this.NUM_DESENHOS.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_NUM_DESENHOS,
            this.NUMERO_DESENHOS});
            this.NUM_DESENHOS.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_NUM_DESENHOS"}, true)});
            this.NUM_DESENHOS.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_NUM_DESENHOS};
            this.NUM_DESENHOS.TableName = "NUM_DESENHOS";
            // 
            // COD_NUM_DESENHOS
            // 
            this.COD_NUM_DESENHOS.AllowDBNull = false;
            this.COD_NUM_DESENHOS.ColumnName = "COD_NUM_DESENHOS";
            this.COD_NUM_DESENHOS.DataType = typeof(int);
            // 
            // NUMERO_DESENHOS
            // 
            this.NUMERO_DESENHOS.ColumnName = "NUMERO_DESENHOS";
            this.NUMERO_DESENHOS.DataType = typeof(int);
            // 
            // tb_num_pecas
            // 
            this.tb_num_pecas.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsNum_desenhos, "NUM_DESENHOS.NUMERO_DESENHOS", true));
            this.tb_num_pecas.Location = new System.Drawing.Point(399, 60);
            this.tb_num_pecas.Name = "tb_num_pecas";
            this.tb_num_pecas.Size = new System.Drawing.Size(41, 20);
            this.tb_num_pecas.TabIndex = 139;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(328, 63);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 13);
            this.label15.TabIndex = 140;
            this.label15.Text = "Num. Peças";
            // 
            // cbNum_desenhos
            // 
            this.cbNum_desenhos.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbNum_desenhos.DataAdapter = this.datNum_desenhos;
            this.cbNum_desenhos.QuotePrefix = "\"";
            this.cbNum_desenhos.QuoteSuffix = "\"";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsDesenhos, "DESENHOS.CLIENTE", true));
            this.comboBox1.DataSource = this.dsClientes;
            this.comboBox1.DisplayMember = "CLIENTES.RAZAO_SOCIAL";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(109, 142);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(177, 21);
            this.comboBox1.TabIndex = 141;
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
            this.CNPJ});
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
            // CNPJ
            // 
            this.CNPJ.ColumnName = "CNPJ";
            this.CNPJ.MaxLength = 30;
            // 
            // datSub
            // 
            this.datSub.DeleteCommand = this.fbCommand84;
            this.datSub.InsertCommand = this.fbCommand82;
            this.datSub.SelectCommand = this.fbCommand81;
            this.datSub.UpdateCommand = this.fbCommand83;
            // 
            // fbCommand84
            // 
            this.fbCommand84.CommandTimeout = 30;
            // 
            // fbCommand82
            // 
            this.fbCommand82.CommandTimeout = 30;
            // 
            // fbCommand81
            // 
            this.fbCommand81.CommandText = "select * from desenhos";
            this.fbCommand81.CommandTimeout = 30;
            this.fbCommand81.Connection = this.fbConnection2;
            // 
            // fbCommand83
            // 
            this.fbCommand83.CommandTimeout = 30;
            // 
            // bt_copiar_rota
            // 
            this.bt_copiar_rota.Location = new System.Drawing.Point(313, 142);
            this.bt_copiar_rota.Name = "bt_copiar_rota";
            this.bt_copiar_rota.Size = new System.Drawing.Size(80, 22);
            this.bt_copiar_rota.TabIndex = 142;
            this.bt_copiar_rota.Text = "Copiar Rota";
            this.bt_copiar_rota.UseVisualStyleBackColor = true;
            this.bt_copiar_rota.Click += new System.EventHandler(this.bt_copiar_rota_Click);
            // 
            // bt_colar_rota
            // 
            this.bt_colar_rota.Location = new System.Drawing.Point(399, 142);
            this.bt_colar_rota.Name = "bt_colar_rota";
            this.bt_colar_rota.Size = new System.Drawing.Size(80, 22);
            this.bt_colar_rota.TabIndex = 143;
            this.bt_colar_rota.Text = "Colar Rota";
            this.bt_colar_rota.UseVisualStyleBackColor = true;
            this.bt_colar_rota.Click += new System.EventHandler(this.bt_colar_rota_Click);
            // 
            // dgvRota
            // 
            this.dgvRota.AllowDrop = true;
            this.dgvRota.AllowUserToAddRows = false;
            this.dgvRota.AutoGenerateColumns = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRota.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRota.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODROTADataGridViewTextBoxColumn,
            this.col_operacao,
            this.desenho_coluna,
            this.pOSICAOFILADataGridViewTextBoxColumn,
            this.oBSERVACAODataGridViewTextBoxColumn});
            this.dgvRota.DataMember = "ROTAS_PECA";
            this.dgvRota.DataSource = this.dsRotas_peca;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRota.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRota.Location = new System.Drawing.Point(63, 214);
            this.dgvRota.Name = "dgvRota";
            this.dgvRota.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRota.Size = new System.Drawing.Size(544, 240);
            this.dgvRota.TabIndex = 144;
            this.dgvRota.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvRota_UserAddedRow_1);
            this.dgvRota.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvRota_RowValidating_1);
            this.dgvRota.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvRota_UserDeletedRow_1);
            // 
            // cODROTADataGridViewTextBoxColumn
            // 
            this.cODROTADataGridViewTextBoxColumn.DataPropertyName = "COD_ROTA";
            this.cODROTADataGridViewTextBoxColumn.HeaderText = "COD_ROTA";
            this.cODROTADataGridViewTextBoxColumn.Name = "cODROTADataGridViewTextBoxColumn";
            this.cODROTADataGridViewTextBoxColumn.Visible = false;
            // 
            // col_operacao
            // 
            this.col_operacao.DataPropertyName = "OPERACAO";
            this.col_operacao.DataSource = this.dsTiposdeoperacoes;
            this.col_operacao.DisplayMember = "TIPOS_OPERACOES.TIPO";
            this.col_operacao.HeaderText = "Operação";
            this.col_operacao.Name = "col_operacao";
            this.col_operacao.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_operacao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_operacao.Width = 150;
            // 
            // desenho_coluna
            // 
            this.desenho_coluna.DataPropertyName = "DESENHO";
            this.desenho_coluna.HeaderText = "Desenho";
            this.desenho_coluna.Name = "desenho_coluna";
            this.desenho_coluna.Visible = false;
            // 
            // pOSICAOFILADataGridViewTextBoxColumn
            // 
            this.pOSICAOFILADataGridViewTextBoxColumn.DataPropertyName = "POSICAO_FILA";
            this.pOSICAOFILADataGridViewTextBoxColumn.HeaderText = "Posição na Fila";
            this.pOSICAOFILADataGridViewTextBoxColumn.Name = "pOSICAOFILADataGridViewTextBoxColumn";
            // 
            // oBSERVACAODataGridViewTextBoxColumn
            // 
            this.oBSERVACAODataGridViewTextBoxColumn.DataPropertyName = "OBSERVACAO";
            this.oBSERVACAODataGridViewTextBoxColumn.HeaderText = "Observação";
            this.oBSERVACAODataGridViewTextBoxColumn.Name = "oBSERVACAODataGridViewTextBoxColumn";
            this.oBSERVACAODataGridViewTextBoxColumn.Width = 300;
            // 
            // btEletrodo
            // 
            this.btEletrodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEletrodo.Location = new System.Drawing.Point(618, 254);
            this.btEletrodo.Name = "btEletrodo";
            this.btEletrodo.Size = new System.Drawing.Size(203, 43);
            this.btEletrodo.TabIndex = 145;
            this.btEletrodo.Text = "Criar OS\r\nEletrodo";
            this.btEletrodo.UseVisualStyleBackColor = true;
            this.btEletrodo.Click += new System.EventHandler(this.btEletrodo_Click);
            // 
            // btInserir
            // 
            this.btInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInserir.Location = new System.Drawing.Point(1, 214);
            this.btInserir.Name = "btInserir";
            this.btInserir.Size = new System.Drawing.Size(59, 35);
            this.btInserir.TabIndex = 146;
            this.btInserir.Text = "Inserir Operação";
            this.btInserir.UseVisualStyleBackColor = true;
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsDesenhos, "DESENHOS.FUNCAO_PECA", true));
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.dsDesenhos, "DESENHOS.FUNCAO_PECA", true));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Cav. Lado Fixo",
            "Cav. Lado Móvel",
            "Postiços",
            "Acessórios",
            "Porta Molde",
            "Montagem",
            "1º Try Out"});
            this.comboBox2.Location = new System.Drawing.Point(574, 116);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(160, 21);
            this.comboBox2.TabIndex = 147;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(506, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 148;
            this.label5.Text = "Função:";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "FUNCAO_PECA";
            this.dataColumn1.MaxLength = 50;
            // 
            // form_peca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 752);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.btInserir);
            this.Controls.Add(this.btEletrodo);
            this.Controls.Add(this.dgvRota);
            this.Controls.Add(this.bt_colar_rota);
            this.Controls.Add(this.bt_copiar_rota);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tb_num_pecas);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tb_posicao_peca);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbN_pdf);
            this.Controls.Add(this.tbNrotas);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvOp);
            this.Controls.Add(this.abre_op);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_Nsub);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_posicao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.apaga_registro);
            this.Controls.Add(this.salva_registro);
            this.Controls.Add(this.vai_anterior);
            this.Controls.Add(this.vai_proximo);
            this.Controls.Add(this.vai_ultimo);
            this.Controls.Add(this.novo_registro);
            this.Controls.Add(this.vai_primeiro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.material_des);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.revisao_des);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cod_peca_desenhos);
            this.Controls.Add(this.label2);
            this.Name = "form_peca";
            this.Text = "Moldes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.form_peca_FormClosed);
            this.Load += new System.EventHandler(this.form_desenhos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsDesenhos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DESENHOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRotas_peca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ROTAS_PECA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposdeoperacoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TIPOS_OPERACOES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNum_ops)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_OPS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNum_rotas_campo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_ROTAS_CAMPO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRotas_campo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ROTAS_CAMPO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNum_desenhos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_DESENHOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CLIENTES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox revisao_des;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cod_peca_desenhos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button apaga_registro;
        private System.Windows.Forms.Button salva_registro;
        private System.Windows.Forms.Button vai_anterior;
        private System.Windows.Forms.Button vai_proximo;
        private System.Windows.Forms.Button vai_ultimo;
        private System.Windows.Forms.Button novo_registro;
        private System.Windows.Forms.Button vai_primeiro;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbDesenhos;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand8;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand6;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand5;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand7;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand12;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand10;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand9;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand11;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand16;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand14;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand13;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand15;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand20;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand18;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand17;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand19;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand21;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand22;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand23;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand24;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand28;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand26;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand25;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand27;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datClientes;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand32;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand30;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand29;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand31;
        private System.Windows.Forms.TextBox material_des;
        private System.Windows.Forms.TextBox tb_posicao;
        private System.Windows.Forms.Label label1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand36;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand34;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand33;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand35;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbSub;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datTipos_operacoes;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand40;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand38;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand37;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand39;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datRotas_peca;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand44;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand42;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand41;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand43;
        private System.Data.DataSet dsRotas_peca;
        private System.Data.DataTable ROTAS_PECA;
        private System.Data.DataColumn COD_ROTA;
        private System.Data.DataColumn OPERACAO;
        private System.Data.DataColumn DESENHO;
        private System.Data.DataColumn POSICAO_FILA;
        private System.Data.DataColumn OBSERVACAO;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbRotas_peca;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tb_Nsub;
        private System.Windows.Forms.Label label7;
        private System.Data.DataSet dsTiposdeoperacoes;
        private System.Data.DataTable TIPOS_OPERACOES;
        private System.Data.DataColumn COD_TIPO;
        private System.Data.DataColumn QDE_MAQUINAS;
        private System.Data.DataColumn TIPO;
        private System.Windows.Forms.Button abre_op;
        private System.Windows.Forms.DataGridView dgvOp;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datOp;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand48;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand46;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand45;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand47;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand52;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand50;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand49;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand51;
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
        private System.Windows.Forms.TextBox tbNrotas;
        private System.Windows.Forms.Label label9;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder fbRotas_campo;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand56;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand54;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand53;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand55;
        private System.Windows.Forms.TextBox tbN_pdf;
        private System.Windows.Forms.Label label10;
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
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand60;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand58;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand57;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand59;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datNum_ops;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand64;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand62;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand61;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand63;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbNum_ops;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datRotas_campo;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand68;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand66;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand65;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand67;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datNum_rotas_campo;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand72;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand70;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand69;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand71;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbNum_rotas_campo;
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
        private System.Data.DataSet dsNum_rotas_campo;
        private System.Data.DataTable NUM_ROTAS_CAMPO;
        private System.Data.DataColumn COD_NUM_ROTAS_CAMPO;
        private System.Data.DataColumn NUMERO_ROTAS_CAMPO;
        private System.Data.DataSet dsNum_ops;
        private System.Data.DataTable NUM_OPS;
        private System.Data.DataColumn NUMERO_OPS;
        private System.Data.DataColumn N_OPS_CERTO;
        private System.Data.DataColumn POSICAO_PECA;
        private System.Windows.Forms.TextBox tb_posicao_peca;
        private System.Windows.Forms.Label label14;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datNum_desenhos;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand76;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand74;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand73;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand75;
        private System.Data.DataSet dsNum_desenhos;
        private System.Data.DataTable NUM_DESENHOS;
        private System.Data.DataColumn COD_NUM_DESENHOS;
        private System.Data.DataColumn NUMERO_DESENHOS;
        private System.Windows.Forms.TextBox tb_num_pecas;
        private System.Windows.Forms.Label label15;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbNum_desenhos;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Data.DataSet dsClientes;
        private System.Data.DataTable CLIENTES;
        private System.Data.DataColumn COD_CLIENTE;
        private System.Data.DataColumn RAZAO_SOCIAL;
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
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datDesenhos;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand80;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand78;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand77;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand79;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datSub;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand84;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand82;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand81;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand83;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_posicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_peca_var;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMEPECADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEVISAODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mATERIALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSPESSURADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rOTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nSUBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nROTASDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button bt_copiar_rota;
        private System.Windows.Forms.Button bt_colar_rota;
        private System.Windows.Forms.DataGridView dgvRota;
        private System.Windows.Forms.Button btEletrodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_op_coluna;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAPDFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNTREGADIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNTREGOUDIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRECOUNITDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pESOTOTALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pDFACEITOEMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nFNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qDEPDFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qDEESTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qDEFABDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qDEEMBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qDECAIXASDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESENHOOPATUALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nPDFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONDPGTODataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btInserir;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODROTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn col_operacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn desenho_coluna;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOSICAOFILADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oBSERVACAODataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Data.DataColumn dataColumn1;
    }
}