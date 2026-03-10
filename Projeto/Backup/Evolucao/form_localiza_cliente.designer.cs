namespace Evolucao
{
    partial class form_localiza_cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_localiza_cliente));
            this.tb_localiza = new System.Windows.Forms.TextBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
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
            this.SITUACAO = new System.Data.DataColumn();
            this.TRANSPORTADORA_CLIENTE = new System.Data.DataColumn();
            this.ATIVIDADE_CLIENTE = new System.Data.DataColumn();
            this.BANCO_CLIENTE = new System.Data.DataColumn();
            this.AGENCIA_CLIENTE = new System.Data.DataColumn();
            this.REGIAO = new System.Data.DataColumn();
            this.VENDEDOR_CLIENTE = new System.Data.DataColumn();
            this.DATA_CADASTTRO_CLIENTE = new System.Data.DataColumn();
            this.ETIQUETA = new System.Data.DataColumn();
            this.CLASS_FISCAL_CLIENTE = new System.Data.DataColumn();
            this.ISENCAO_ICM_CLIENTE = new System.Data.DataColumn();
            this.ISENCAO_IPI_CLIENTE = new System.Data.DataColumn();
            this.ENDERECO_COBRANCA_CLIENTE = new System.Data.DataColumn();
            this.ENDERECO_ENTREGA_CLIENTE = new System.Data.DataColumn();
            this.COD_CIDADE_CLIENTE = new System.Data.DataColumn();
            this.COD_PAIS_CLIENTE = new System.Data.DataColumn();
            this.NUMERO_CLIENTE = new System.Data.DataColumn();
            this.VALOR_FRESA_CLIENTE = new System.Data.DataColumn();
            this.VALOR_RETIFICA_CLIENTE = new System.Data.DataColumn();
            this.VALOR_RETIFICA_OPTICA_CLIENTE = new System.Data.DataColumn();
            this.VALOR_EDM_CLIENTE = new System.Data.DataColumn();
            this.VALOR_TORNO_CLIENTE = new System.Data.DataColumn();
            this.VALOR_EWC_CLIENTE = new System.Data.DataColumn();
            this.VALOR_EWC015_CLIENTE = new System.Data.DataColumn();
            this.VALOR_CNC_CLIENTE = new System.Data.DataColumn();
            this.VALOR_BANCADA_CLIENTE = new System.Data.DataColumn();
            this.PORC_BENEFICIAMENTO_CLIENTE = new System.Data.DataColumn();
            this.PORC_VENDA_CLIENTE = new System.Data.DataColumn();
            this.PORC_PRESTACAO_SERV_CLIENTE = new System.Data.DataColumn();
            this.PORC_RETRABALHO_CLIENTE = new System.Data.DataColumn();
            this.PESSOA_FISICA_CLIENTE = new System.Data.DataColumn();
            this.ICMS_CLIENTE = new System.Data.DataColumn();
            this.REDUCAO_CLIENTE = new System.Data.DataColumn();
            this.ICMS_ST_CLIENTE = new System.Data.DataColumn();
            this.IVA_CLIENTE = new System.Data.DataColumn();
            this.IPI_CLIENTE = new System.Data.DataColumn();
            this.PIS_CLIENTE = new System.Data.DataColumn();
            this.COFINS_CLIENTE = new System.Data.DataColumn();
            this.REDUCAO_ST_CLIENTE = new System.Data.DataColumn();
            this.COMPLEMENTO_CLIENTE = new System.Data.DataColumn();
            this.BC_COM_IPI_CLIENTE = new System.Data.DataColumn();
            this.COD_ROTEIRO_CLIENTE = new System.Data.DataColumn();
            this.NOME_ROTEIRO_CLIENTE = new System.Data.DataColumn();
            this.CEP_CLIENTE = new System.Data.DataColumn();
            this.datClientes = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_nome_fantasia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_cnpj = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.col_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_razao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMEFANTASIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIDADEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CLIENTES)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_localiza
            // 
            this.tb_localiza.Location = new System.Drawing.Point(101, 4);
            this.tb_localiza.Name = "tb_localiza";
            this.tb_localiza.Size = new System.Drawing.Size(165, 20);
            this.tb_localiza.TabIndex = 3;
            this.tb_localiza.TextChanged += new System.EventHandler(this.tb_localiza_TextChanged);
            this.tb_localiza.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_localiza_KeyPress);
            // 
            // dgvClientes
            // 
            this.dgvClientes.AutoGenerateColumns = false;
            this.dgvClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.ColumnHeadersVisible = false;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_cod,
            this.col_cnpj,
            this.col_razao,
            this.nOMEFANTASIADataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.cIDADEDataGridViewTextBoxColumn,
            this.col_estado});
            this.dgvClientes.DataMember = "CLIENTES";
            this.dgvClientes.DataSource = this.dsClientes;
            this.dgvClientes.Location = new System.Drawing.Point(1, 119);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.Size = new System.Drawing.Size(885, 338);
            this.dgvClientes.TabIndex = 2;
            this.dgvClientes.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentDoubleClick);
            this.dgvClientes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvClientes_KeyPress);
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentClick);
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
            this.SITUACAO,
            this.TRANSPORTADORA_CLIENTE,
            this.ATIVIDADE_CLIENTE,
            this.BANCO_CLIENTE,
            this.AGENCIA_CLIENTE,
            this.REGIAO,
            this.VENDEDOR_CLIENTE,
            this.DATA_CADASTTRO_CLIENTE,
            this.ETIQUETA,
            this.CLASS_FISCAL_CLIENTE,
            this.ISENCAO_ICM_CLIENTE,
            this.ISENCAO_IPI_CLIENTE,
            this.ENDERECO_COBRANCA_CLIENTE,
            this.ENDERECO_ENTREGA_CLIENTE,
            this.COD_CIDADE_CLIENTE,
            this.COD_PAIS_CLIENTE,
            this.NUMERO_CLIENTE,
            this.VALOR_FRESA_CLIENTE,
            this.VALOR_RETIFICA_CLIENTE,
            this.VALOR_RETIFICA_OPTICA_CLIENTE,
            this.VALOR_EDM_CLIENTE,
            this.VALOR_TORNO_CLIENTE,
            this.VALOR_EWC_CLIENTE,
            this.VALOR_EWC015_CLIENTE,
            this.VALOR_CNC_CLIENTE,
            this.VALOR_BANCADA_CLIENTE,
            this.PORC_BENEFICIAMENTO_CLIENTE,
            this.PORC_VENDA_CLIENTE,
            this.PORC_PRESTACAO_SERV_CLIENTE,
            this.PORC_RETRABALHO_CLIENTE,
            this.PESSOA_FISICA_CLIENTE,
            this.ICMS_CLIENTE,
            this.REDUCAO_CLIENTE,
            this.ICMS_ST_CLIENTE,
            this.IVA_CLIENTE,
            this.IPI_CLIENTE,
            this.PIS_CLIENTE,
            this.COFINS_CLIENTE,
            this.REDUCAO_ST_CLIENTE,
            this.COMPLEMENTO_CLIENTE,
            this.BC_COM_IPI_CLIENTE,
            this.COD_ROTEIRO_CLIENTE,
            this.NOME_ROTEIRO_CLIENTE,
            this.CEP_CLIENTE});
            this.CLIENTES.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "CNPJ"}, true)});
            this.CLIENTES.PrimaryKey = new System.Data.DataColumn[] {
        this.CNPJ};
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
            this.CONTATO1.MaxLength = 40;
            // 
            // FONE1
            // 
            this.FONE1.ColumnName = "FONE1";
            this.FONE1.MaxLength = 100;
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
            this.CNPJ.MaxLength = 30;
            // 
            // SITUACAO
            // 
            this.SITUACAO.ColumnName = "SITUACAO";
            this.SITUACAO.MaxLength = 40;
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
            // DATA_CADASTTRO_CLIENTE
            // 
            this.DATA_CADASTTRO_CLIENTE.ColumnName = "DATA_CADASTTRO_CLIENTE";
            this.DATA_CADASTTRO_CLIENTE.DataType = typeof(System.DateTime);
            // 
            // ETIQUETA
            // 
            this.ETIQUETA.ColumnName = "ETIQUETA";
            this.ETIQUETA.MaxLength = 10;
            // 
            // CLASS_FISCAL_CLIENTE
            // 
            this.CLASS_FISCAL_CLIENTE.ColumnName = "CLASS_FISCAL_CLIENTE";
            this.CLASS_FISCAL_CLIENTE.MaxLength = 50;
            // 
            // ISENCAO_ICM_CLIENTE
            // 
            this.ISENCAO_ICM_CLIENTE.ColumnName = "ISENCAO_ICM_CLIENTE";
            this.ISENCAO_ICM_CLIENTE.MaxLength = 250;
            // 
            // ISENCAO_IPI_CLIENTE
            // 
            this.ISENCAO_IPI_CLIENTE.ColumnName = "ISENCAO_IPI_CLIENTE";
            this.ISENCAO_IPI_CLIENTE.MaxLength = 250;
            // 
            // ENDERECO_COBRANCA_CLIENTE
            // 
            this.ENDERECO_COBRANCA_CLIENTE.ColumnName = "ENDERECO_COBRANCA_CLIENTE";
            this.ENDERECO_COBRANCA_CLIENTE.MaxLength = 80;
            // 
            // ENDERECO_ENTREGA_CLIENTE
            // 
            this.ENDERECO_ENTREGA_CLIENTE.ColumnName = "ENDERECO_ENTREGA_CLIENTE";
            this.ENDERECO_ENTREGA_CLIENTE.MaxLength = 80;
            // 
            // COD_CIDADE_CLIENTE
            // 
            this.COD_CIDADE_CLIENTE.ColumnName = "COD_CIDADE_CLIENTE";
            this.COD_CIDADE_CLIENTE.MaxLength = 10;
            // 
            // COD_PAIS_CLIENTE
            // 
            this.COD_PAIS_CLIENTE.ColumnName = "COD_PAIS_CLIENTE";
            this.COD_PAIS_CLIENTE.MaxLength = 10;
            // 
            // NUMERO_CLIENTE
            // 
            this.NUMERO_CLIENTE.ColumnName = "NUMERO_CLIENTE";
            this.NUMERO_CLIENTE.MaxLength = 20;
            // 
            // VALOR_FRESA_CLIENTE
            // 
            this.VALOR_FRESA_CLIENTE.ColumnName = "VALOR_FRESA_CLIENTE";
            this.VALOR_FRESA_CLIENTE.DataType = typeof(double);
            // 
            // VALOR_RETIFICA_CLIENTE
            // 
            this.VALOR_RETIFICA_CLIENTE.ColumnName = "VALOR_RETIFICA_CLIENTE";
            this.VALOR_RETIFICA_CLIENTE.DataType = typeof(double);
            // 
            // VALOR_RETIFICA_OPTICA_CLIENTE
            // 
            this.VALOR_RETIFICA_OPTICA_CLIENTE.ColumnName = "VALOR_RETIFICA_OPTICA_CLIENTE";
            this.VALOR_RETIFICA_OPTICA_CLIENTE.DataType = typeof(double);
            // 
            // VALOR_EDM_CLIENTE
            // 
            this.VALOR_EDM_CLIENTE.ColumnName = "VALOR_EDM_CLIENTE";
            this.VALOR_EDM_CLIENTE.DataType = typeof(double);
            // 
            // VALOR_TORNO_CLIENTE
            // 
            this.VALOR_TORNO_CLIENTE.ColumnName = "VALOR_TORNO_CLIENTE";
            this.VALOR_TORNO_CLIENTE.DataType = typeof(double);
            // 
            // VALOR_EWC_CLIENTE
            // 
            this.VALOR_EWC_CLIENTE.ColumnName = "VALOR_EWC_CLIENTE";
            this.VALOR_EWC_CLIENTE.DataType = typeof(double);
            // 
            // VALOR_EWC015_CLIENTE
            // 
            this.VALOR_EWC015_CLIENTE.ColumnName = "VALOR_EWC015_CLIENTE";
            this.VALOR_EWC015_CLIENTE.DataType = typeof(double);
            // 
            // VALOR_CNC_CLIENTE
            // 
            this.VALOR_CNC_CLIENTE.ColumnName = "VALOR_CNC_CLIENTE";
            this.VALOR_CNC_CLIENTE.DataType = typeof(double);
            // 
            // VALOR_BANCADA_CLIENTE
            // 
            this.VALOR_BANCADA_CLIENTE.ColumnName = "VALOR_BANCADA_CLIENTE";
            this.VALOR_BANCADA_CLIENTE.DataType = typeof(double);
            // 
            // PORC_BENEFICIAMENTO_CLIENTE
            // 
            this.PORC_BENEFICIAMENTO_CLIENTE.ColumnName = "PORC_BENEFICIAMENTO_CLIENTE";
            this.PORC_BENEFICIAMENTO_CLIENTE.DataType = typeof(double);
            // 
            // PORC_VENDA_CLIENTE
            // 
            this.PORC_VENDA_CLIENTE.ColumnName = "PORC_VENDA_CLIENTE";
            this.PORC_VENDA_CLIENTE.DataType = typeof(double);
            // 
            // PORC_PRESTACAO_SERV_CLIENTE
            // 
            this.PORC_PRESTACAO_SERV_CLIENTE.ColumnName = "PORC_PRESTACAO_SERV_CLIENTE";
            this.PORC_PRESTACAO_SERV_CLIENTE.DataType = typeof(double);
            // 
            // PORC_RETRABALHO_CLIENTE
            // 
            this.PORC_RETRABALHO_CLIENTE.ColumnName = "PORC_RETRABALHO_CLIENTE";
            this.PORC_RETRABALHO_CLIENTE.DataType = typeof(double);
            // 
            // PESSOA_FISICA_CLIENTE
            // 
            this.PESSOA_FISICA_CLIENTE.ColumnName = "PESSOA_FISICA_CLIENTE";
            this.PESSOA_FISICA_CLIENTE.DataType = typeof(int);
            // 
            // ICMS_CLIENTE
            // 
            this.ICMS_CLIENTE.ColumnName = "ICMS_CLIENTE";
            this.ICMS_CLIENTE.DataType = typeof(double);
            // 
            // REDUCAO_CLIENTE
            // 
            this.REDUCAO_CLIENTE.ColumnName = "REDUCAO_CLIENTE";
            this.REDUCAO_CLIENTE.DataType = typeof(double);
            // 
            // ICMS_ST_CLIENTE
            // 
            this.ICMS_ST_CLIENTE.ColumnName = "ICMS_ST_CLIENTE";
            this.ICMS_ST_CLIENTE.DataType = typeof(double);
            // 
            // IVA_CLIENTE
            // 
            this.IVA_CLIENTE.ColumnName = "IVA_CLIENTE";
            this.IVA_CLIENTE.DataType = typeof(double);
            // 
            // IPI_CLIENTE
            // 
            this.IPI_CLIENTE.ColumnName = "IPI_CLIENTE";
            this.IPI_CLIENTE.DataType = typeof(double);
            // 
            // PIS_CLIENTE
            // 
            this.PIS_CLIENTE.ColumnName = "PIS_CLIENTE";
            this.PIS_CLIENTE.DataType = typeof(double);
            // 
            // COFINS_CLIENTE
            // 
            this.COFINS_CLIENTE.ColumnName = "COFINS_CLIENTE";
            this.COFINS_CLIENTE.DataType = typeof(double);
            // 
            // REDUCAO_ST_CLIENTE
            // 
            this.REDUCAO_ST_CLIENTE.ColumnName = "REDUCAO_ST_CLIENTE";
            this.REDUCAO_ST_CLIENTE.DataType = typeof(double);
            // 
            // COMPLEMENTO_CLIENTE
            // 
            this.COMPLEMENTO_CLIENTE.ColumnName = "COMPLEMENTO_CLIENTE";
            this.COMPLEMENTO_CLIENTE.MaxLength = 100;
            // 
            // BC_COM_IPI_CLIENTE
            // 
            this.BC_COM_IPI_CLIENTE.ColumnName = "BC_COM_IPI_CLIENTE";
            this.BC_COM_IPI_CLIENTE.DataType = typeof(int);
            // 
            // COD_ROTEIRO_CLIENTE
            // 
            this.COD_ROTEIRO_CLIENTE.ColumnName = "COD_ROTEIRO_CLIENTE";
            this.COD_ROTEIRO_CLIENTE.DataType = typeof(int);
            // 
            // NOME_ROTEIRO_CLIENTE
            // 
            this.NOME_ROTEIRO_CLIENTE.ColumnName = "NOME_ROTEIRO_CLIENTE";
            this.NOME_ROTEIRO_CLIENTE.MaxLength = 200;
            // 
            // CEP_CLIENTE
            // 
            this.CEP_CLIENTE.ColumnName = "CEP_CLIENTE";
            this.CEP_CLIENTE.MaxLength = 10;
            // 
            // datClientes
            // 
            this.datClientes.DeleteCommand = this.fbCommand4;
            this.datClientes.InsertCommand = this.fbCommand2;
            this.datClientes.SelectCommand = this.fbCommand1;
            this.datClientes.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * from clientes order by razao_social";
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(351, 463);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_nome_fantasia
            // 
            this.tb_nome_fantasia.Location = new System.Drawing.Point(101, 30);
            this.tb_nome_fantasia.Name = "tb_nome_fantasia";
            this.tb_nome_fantasia.Size = new System.Drawing.Size(244, 20);
            this.tb_nome_fantasia.TabIndex = 5;
            this.tb_nome_fantasia.TextChanged += new System.EventHandler(this.tb_nome_fantasia_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Razão Social";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome Fantasia";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tb_cnpj);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tb_nome_fantasia);
            this.panel1.Controls.Add(this.tb_localiza);
            this.panel1.Location = new System.Drawing.Point(31, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 94);
            this.panel1.TabIndex = 8;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(270, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 20);
            this.button4.TabIndex = 11;
            this.button4.Text = "Buscar Razão";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(270, 56);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 20);
            this.button3.TabIndex = 10;
            this.button3.Text = "Buscar CNPJ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "CNPJ";
            // 
            // tb_cnpj
            // 
            this.tb_cnpj.Location = new System.Drawing.Point(101, 56);
            this.tb_cnpj.Name = "tb_cnpj";
            this.tb_cnpj.Size = new System.Drawing.Size(165, 20);
            this.tb_cnpj.TabIndex = 8;
            this.tb_cnpj.TextChanged += new System.EventHandler(this.tb_cnpj_TextChanged);
            this.tb_cnpj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_cnpj_KeyPress);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(455, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 94);
            this.button2.TabIndex = 9;
            this.button2.Text = "Selecionar Todos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // col_cod
            // 
            this.col_cod.DataPropertyName = "COD_CLIENTE";
            this.col_cod.HeaderText = "COD_CLIENTE";
            this.col_cod.Name = "col_cod";
            this.col_cod.ReadOnly = true;
            this.col_cod.Visible = false;
            // 
            // col_cnpj
            // 
            this.col_cnpj.DataPropertyName = "CNPJ";
            this.col_cnpj.HeaderText = "CNPJ";
            this.col_cnpj.Name = "col_cnpj";
            this.col_cnpj.ReadOnly = true;
            this.col_cnpj.Width = 150;
            // 
            // col_razao
            // 
            this.col_razao.DataPropertyName = "RAZAO_SOCIAL";
            this.col_razao.HeaderText = "RAZAO_SOCIAL";
            this.col_razao.Name = "col_razao";
            this.col_razao.ReadOnly = true;
            this.col_razao.Width = 300;
            // 
            // nOMEFANTASIADataGridViewTextBoxColumn
            // 
            this.nOMEFANTASIADataGridViewTextBoxColumn.DataPropertyName = "NOME_FANTASIA";
            this.nOMEFANTASIADataGridViewTextBoxColumn.HeaderText = "NOME_FANTASIA";
            this.nOMEFANTASIADataGridViewTextBoxColumn.Name = "nOMEFANTASIADataGridViewTextBoxColumn";
            this.nOMEFANTASIADataGridViewTextBoxColumn.ReadOnly = true;
            this.nOMEFANTASIADataGridViewTextBoxColumn.Width = 200;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ENDERECO";
            this.dataGridViewTextBoxColumn1.HeaderText = "ENDERECO";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 250;
            // 
            // cIDADEDataGridViewTextBoxColumn
            // 
            this.cIDADEDataGridViewTextBoxColumn.DataPropertyName = "CIDADE";
            this.cIDADEDataGridViewTextBoxColumn.HeaderText = "CIDADE";
            this.cIDADEDataGridViewTextBoxColumn.Name = "cIDADEDataGridViewTextBoxColumn";
            this.cIDADEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col_estado
            // 
            this.col_estado.DataPropertyName = "ESTADO";
            this.col_estado.HeaderText = "ESTADO";
            this.col_estado.Name = "col_estado";
            this.col_estado.ReadOnly = true;
            // 
            // form_localiza_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 498);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "form_localiza_cliente";
            this.Text = "Localiza Cliente";
            this.Load += new System.EventHandler(this.form_localiza_cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CLIENTES)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tb_localiza;
        private System.Windows.Forms.DataGridView dgvClientes;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datClientes;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_nome_fantasia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_cnpj;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
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
        private System.Data.DataColumn SITUACAO;
        private System.Data.DataColumn TRANSPORTADORA_CLIENTE;
        private System.Data.DataColumn ATIVIDADE_CLIENTE;
        private System.Data.DataColumn BANCO_CLIENTE;
        private System.Data.DataColumn AGENCIA_CLIENTE;
        private System.Data.DataColumn REGIAO;
        private System.Data.DataColumn VENDEDOR_CLIENTE;
        private System.Data.DataColumn DATA_CADASTTRO_CLIENTE;
        private System.Data.DataColumn ETIQUETA;
        private System.Data.DataColumn CLASS_FISCAL_CLIENTE;
        private System.Data.DataColumn ISENCAO_ICM_CLIENTE;
        private System.Data.DataColumn ISENCAO_IPI_CLIENTE;
        private System.Data.DataColumn ENDERECO_COBRANCA_CLIENTE;
        private System.Data.DataColumn ENDERECO_ENTREGA_CLIENTE;
        private System.Data.DataColumn COD_CIDADE_CLIENTE;
        private System.Data.DataColumn COD_PAIS_CLIENTE;
        private System.Data.DataColumn NUMERO_CLIENTE;
        private System.Data.DataColumn VALOR_FRESA_CLIENTE;
        private System.Data.DataColumn VALOR_RETIFICA_CLIENTE;
        private System.Data.DataColumn VALOR_RETIFICA_OPTICA_CLIENTE;
        private System.Data.DataColumn VALOR_EDM_CLIENTE;
        private System.Data.DataColumn VALOR_TORNO_CLIENTE;
        private System.Data.DataColumn VALOR_EWC_CLIENTE;
        private System.Data.DataColumn VALOR_EWC015_CLIENTE;
        private System.Data.DataColumn VALOR_CNC_CLIENTE;
        private System.Data.DataColumn VALOR_BANCADA_CLIENTE;
        private System.Data.DataColumn PORC_BENEFICIAMENTO_CLIENTE;
        private System.Data.DataColumn PORC_VENDA_CLIENTE;
        private System.Data.DataColumn PORC_PRESTACAO_SERV_CLIENTE;
        private System.Data.DataColumn PORC_RETRABALHO_CLIENTE;
        private System.Data.DataColumn PESSOA_FISICA_CLIENTE;
        private System.Data.DataColumn ICMS_CLIENTE;
        private System.Data.DataColumn REDUCAO_CLIENTE;
        private System.Data.DataColumn ICMS_ST_CLIENTE;
        private System.Data.DataColumn IVA_CLIENTE;
        private System.Data.DataColumn IPI_CLIENTE;
        private System.Data.DataColumn PIS_CLIENTE;
        private System.Data.DataColumn COFINS_CLIENTE;
        private System.Data.DataColumn REDUCAO_ST_CLIENTE;
        private System.Data.DataColumn COMPLEMENTO_CLIENTE;
        private System.Data.DataColumn BC_COM_IPI_CLIENTE;
        private System.Data.DataColumn COD_ROTEIRO_CLIENTE;
        private System.Data.DataColumn NOME_ROTEIRO_CLIENTE;
        private System.Data.DataColumn CEP_CLIENTE;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_razao;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMEFANTASIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDADEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_estado;
    }
}