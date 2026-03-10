namespace Evolucao
{
    partial class form_localiza_op
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_localiza_op));
            this.dgvDesenhos = new System.Windows.Forms.DataGridView();
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
            this.DESENHO_PECA = new System.Data.DataColumn();
            this.RESPONSAVEL_PECA = new System.Data.DataColumn();
            this.FINALIZADA_PECA = new System.Data.DataColumn();
            this.tb_localiza_peca = new System.Windows.Forms.TextBox();
            this.datDesenhos = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_cliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cb_criacao = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtTermino = new System.Windows.Forms.DateTimePicker();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.col_os = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEVISAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMEPECADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAENTREGAPECADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAABERTURAPECADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nPCPECADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fINALIZADAPECADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDesenhos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDesenhos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DESENHOS)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDesenhos
            // 
            this.dgvDesenhos.AllowUserToAddRows = false;
            this.dgvDesenhos.AllowUserToDeleteRows = false;
            this.dgvDesenhos.AllowUserToResizeColumns = false;
            this.dgvDesenhos.AllowUserToResizeRows = false;
            this.dgvDesenhos.AutoGenerateColumns = false;
            this.dgvDesenhos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDesenhos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_os,
            this.rEVISAODataGridViewTextBoxColumn,
            this.cLIENTEDataGridViewTextBoxColumn,
            this.nOMEPECADataGridViewTextBoxColumn,
            this.dATAENTREGAPECADataGridViewTextBoxColumn,
            this.dATAABERTURAPECADataGridViewTextBoxColumn,
            this.nPCPECADataGridViewTextBoxColumn,
            this.fINALIZADAPECADataGridViewTextBoxColumn});
            this.dgvDesenhos.DataMember = "DESENHOS";
            this.dgvDesenhos.DataSource = this.dsDesenhos;
            this.dgvDesenhos.Location = new System.Drawing.Point(1, 126);
            this.dgvDesenhos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDesenhos.Name = "dgvDesenhos";
            this.dgvDesenhos.ReadOnly = true;
            this.dgvDesenhos.RowHeadersWidth = 20;
            this.dgvDesenhos.Size = new System.Drawing.Size(1121, 420);
            this.dgvDesenhos.TabIndex = 3;
            this.dgvDesenhos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDesenhos_CellContentClick);
            this.dgvDesenhos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDesenhos_CellMouseClick);
            this.dgvDesenhos.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDesenhos_CellMouseDoubleClick);
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
            this.DESENHO_PECA,
            this.RESPONSAVEL_PECA,
            this.FINALIZADA_PECA});
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
            // DESENHO_PECA
            // 
            this.DESENHO_PECA.ColumnName = "DESENHO_PECA";
            this.DESENHO_PECA.DataType = typeof(byte[]);
            // 
            // RESPONSAVEL_PECA
            // 
            this.RESPONSAVEL_PECA.ColumnName = "RESPONSAVEL_PECA";
            this.RESPONSAVEL_PECA.MaxLength = 200;
            // 
            // FINALIZADA_PECA
            // 
            this.FINALIZADA_PECA.ColumnName = "FINALIZADA_PECA";
            this.FINALIZADA_PECA.DataType = typeof(int);
            // 
            // tb_localiza_peca
            // 
            this.tb_localiza_peca.Location = new System.Drawing.Point(77, 6);
            this.tb_localiza_peca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_localiza_peca.Name = "tb_localiza_peca";
            this.tb_localiza_peca.Size = new System.Drawing.Size(177, 22);
            this.tb_localiza_peca.TabIndex = 2;
            this.tb_localiza_peca.TextChanged += new System.EventHandler(this.tb_localiza_peca_TextChanged);
            // 
            // datDesenhos
            // 
            this.datDesenhos.DeleteCommand = this.fbCommand4;
            this.datDesenhos.InsertCommand = this.fbCommand2;
            this.datDesenhos.SelectCommand = this.fbCommand1;
            this.datDesenhos.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * from desenhos order by n_os_peca desc";
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tb_nome);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tb_cliente);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tb_localiza_peca);
            this.panel1.Location = new System.Drawing.Point(356, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(517, 100);
            this.panel1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nome:";
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(77, 70);
            this.tb_nome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(383, 22);
            this.tb_nome.TabIndex = 6;
            this.tb_nome.TextChanged += new System.EventHandler(this.tb_nome_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cliente:";
            // 
            // tb_cliente
            // 
            this.tb_cliente.Location = new System.Drawing.Point(77, 38);
            this.tb_cliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_cliente.Name = "tb_cliente";
            this.tb_cliente.Size = new System.Drawing.Size(383, 22);
            this.tb_cliente.TabIndex = 4;
            this.tb_cliente.TextChanged += new System.EventHandler(this.tb_cliente_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "OS:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.cb_criacao);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.dtTermino);
            this.panel2.Controls.Add(this.dtInicio);
            this.panel2.Location = new System.Drawing.Point(1, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(239, 100);
            this.panel2.TabIndex = 5;
            // 
            // cb_criacao
            // 
            this.cb_criacao.AutoSize = true;
            this.cb_criacao.Location = new System.Drawing.Point(55, 73);
            this.cb_criacao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_criacao.Name = "cb_criacao";
            this.cb_criacao.Size = new System.Drawing.Size(138, 21);
            this.cb_criacao.TabIndex = 4;
            this.cb_criacao.Text = "Data de abertura";
            this.cb_criacao.UseVisualStyleBackColor = true;
            this.cb_criacao.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 47);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Término:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Início:";
            // 
            // dtTermino
            // 
            this.dtTermino.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTermino.Location = new System.Drawing.Point(79, 43);
            this.dtTermino.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtTermino.Name = "dtTermino";
            this.dtTermino.Size = new System.Drawing.Size(145, 22);
            this.dtTermino.TabIndex = 1;
            // 
            // dtInicio
            // 
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicio.Location = new System.Drawing.Point(79, 14);
            this.dtInicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(145, 22);
            this.dtInicio.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(248, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 100);
            this.button1.TabIndex = 8;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(893, 15);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 100);
            this.button3.TabIndex = 298;
            this.button3.Tag = "";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // col_os
            // 
            this.col_os.DataPropertyName = "N_OS_PECA";
            this.col_os.HeaderText = "OS";
            this.col_os.Name = "col_os";
            this.col_os.ReadOnly = true;
            this.col_os.Width = 50;
            // 
            // rEVISAODataGridViewTextBoxColumn
            // 
            this.rEVISAODataGridViewTextBoxColumn.DataPropertyName = "REVISAO";
            this.rEVISAODataGridViewTextBoxColumn.HeaderText = "Rev";
            this.rEVISAODataGridViewTextBoxColumn.Name = "rEVISAODataGridViewTextBoxColumn";
            this.rEVISAODataGridViewTextBoxColumn.ReadOnly = true;
            this.rEVISAODataGridViewTextBoxColumn.Width = 50;
            // 
            // cLIENTEDataGridViewTextBoxColumn
            // 
            this.cLIENTEDataGridViewTextBoxColumn.DataPropertyName = "CLIENTE";
            this.cLIENTEDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.cLIENTEDataGridViewTextBoxColumn.Name = "cLIENTEDataGridViewTextBoxColumn";
            this.cLIENTEDataGridViewTextBoxColumn.ReadOnly = true;
            this.cLIENTEDataGridViewTextBoxColumn.Width = 200;
            // 
            // nOMEPECADataGridViewTextBoxColumn
            // 
            this.nOMEPECADataGridViewTextBoxColumn.DataPropertyName = "NOME_PECA";
            this.nOMEPECADataGridViewTextBoxColumn.HeaderText = "Nome Peça";
            this.nOMEPECADataGridViewTextBoxColumn.Name = "nOMEPECADataGridViewTextBoxColumn";
            this.nOMEPECADataGridViewTextBoxColumn.ReadOnly = true;
            this.nOMEPECADataGridViewTextBoxColumn.Width = 200;
            // 
            // dATAENTREGAPECADataGridViewTextBoxColumn
            // 
            this.dATAENTREGAPECADataGridViewTextBoxColumn.DataPropertyName = "DATA_ENTREGA_PECA";
            this.dATAENTREGAPECADataGridViewTextBoxColumn.HeaderText = "Prazo Entrega";
            this.dATAENTREGAPECADataGridViewTextBoxColumn.Name = "dATAENTREGAPECADataGridViewTextBoxColumn";
            this.dATAENTREGAPECADataGridViewTextBoxColumn.ReadOnly = true;
            this.dATAENTREGAPECADataGridViewTextBoxColumn.Width = 70;
            // 
            // dATAABERTURAPECADataGridViewTextBoxColumn
            // 
            this.dATAABERTURAPECADataGridViewTextBoxColumn.DataPropertyName = "DATA_ABERTURA_PECA";
            this.dATAABERTURAPECADataGridViewTextBoxColumn.HeaderText = "Data Abertura";
            this.dATAABERTURAPECADataGridViewTextBoxColumn.Name = "dATAABERTURAPECADataGridViewTextBoxColumn";
            this.dATAABERTURAPECADataGridViewTextBoxColumn.ReadOnly = true;
            this.dATAABERTURAPECADataGridViewTextBoxColumn.Width = 70;
            // 
            // nPCPECADataGridViewTextBoxColumn
            // 
            this.nPCPECADataGridViewTextBoxColumn.DataPropertyName = "N_PC_PECA";
            this.nPCPECADataGridViewTextBoxColumn.HeaderText = "Pedido de Compra";
            this.nPCPECADataGridViewTextBoxColumn.Name = "nPCPECADataGridViewTextBoxColumn";
            this.nPCPECADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fINALIZADAPECADataGridViewTextBoxColumn
            // 
            this.fINALIZADAPECADataGridViewTextBoxColumn.DataPropertyName = "FINALIZADA_PECA";
            this.fINALIZADAPECADataGridViewTextBoxColumn.FalseValue = "0";
            this.fINALIZADAPECADataGridViewTextBoxColumn.HeaderText = "Finalizada?";
            this.fINALIZADAPECADataGridViewTextBoxColumn.IndeterminateValue = "0";
            this.fINALIZADAPECADataGridViewTextBoxColumn.Name = "fINALIZADAPECADataGridViewTextBoxColumn";
            this.fINALIZADAPECADataGridViewTextBoxColumn.ReadOnly = true;
            this.fINALIZADAPECADataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.fINALIZADAPECADataGridViewTextBoxColumn.TrueValue = "1";
            this.fINALIZADAPECADataGridViewTextBoxColumn.Width = 80;
            // 
            // form_localiza_op
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 549);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvDesenhos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "form_localiza_op";
            this.Text = "Localiza Op";
            this.Load += new System.EventHandler(this.form_localiza_op_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDesenhos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDesenhos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DESENHOS)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDesenhos;
        private System.Windows.Forms.TextBox tb_localiza_peca;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datDesenhos;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_cliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_nome;
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
        private System.Data.DataColumn DESENHO_PECA;
        private System.Data.DataColumn RESPONSAVEL_PECA;
        private System.Data.DataColumn FINALIZADA_PECA;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtTermino;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox cb_criacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_os;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEVISAODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMEPECADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAENTREGAPECADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAABERTURAPECADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nPCPECADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn fINALIZADAPECADataGridViewTextBoxColumn;
    }
}