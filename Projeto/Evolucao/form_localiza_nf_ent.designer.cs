namespace Evolucao
{
    partial class form_localiza_nf_ent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_localiza_nf_ent));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_cliente = new System.Windows.Forms.TextBox();
            this.tb_n_nf = new System.Windows.Forms.TextBox();
            this.datNota_fiscal_ent = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dgvNota_fiscal_ent = new System.Windows.Forms.DataGridView();
            this.dsNota_fiscal_ent = new System.Data.DataSet();
            this.NOTA_FISCAL_ENT = new System.Data.DataTable();
            this.COD_SISTEMA_NF_ENT = new System.Data.DataColumn();
            this.N_NF_ENT = new System.Data.DataColumn();
            this.ENTRADA_NF_ENT = new System.Data.DataColumn();
            this.SAIDA_NF_ENT = new System.Data.DataColumn();
            this.FORMA_PGTO_NF_ENT = new System.Data.DataColumn();
            this.DATA_ENTR_SAI_NF_ENT = new System.Data.DataColumn();
            this.DATA_EMISSAO_NF_ENT = new System.Data.DataColumn();
            this.DATA_VENCIMENTO_NF_ENT = new System.Data.DataColumn();
            this.CFO_NF_ENT = new System.Data.DataColumn();
            this.CFO_2_NF_ENT = new System.Data.DataColumn();
            this.CLIENTE_FORN_NF_ENT = new System.Data.DataColumn();
            this.ENDERECO_ENTREGA_NF_ENT = new System.Data.DataColumn();
            this.BASE_CALC_ICMS_NF_ENT = new System.Data.DataColumn();
            this.VALOR_ICMS_NF_ENT = new System.Data.DataColumn();
            this.BASE_CALC_ICM_SUBS_ENT = new System.Data.DataColumn();
            this.VALOR_ICM_SUBS_ENT = new System.Data.DataColumn();
            this.VALOR_FRETE_NF_ENT = new System.Data.DataColumn();
            this.VALOR_SEGURO_NF_ENT = new System.Data.DataColumn();
            this.OUTRAS_DESP_NF_ENT = new System.Data.DataColumn();
            this.VALOR_IPI_NF_ENT = new System.Data.DataColumn();
            this.VALOR_TOT_PROD_NF_ENT = new System.Data.DataColumn();
            this.VALOR_NOTA_NF_ENT = new System.Data.DataColumn();
            this.TRANSPORTADORA_NF_ENT = new System.Data.DataColumn();
            this.FRETE_CONTA_NF_ENT = new System.Data.DataColumn();
            this.PLACA_VEICULO_NF_ENT = new System.Data.DataColumn();
            this.ESTADO_VEICULO_NF_ENT = new System.Data.DataColumn();
            this.QTDE_NF_ENT = new System.Data.DataColumn();
            this.ESPECIE_NF_ENT = new System.Data.DataColumn();
            this.MARCA_NF_ENT = new System.Data.DataColumn();
            this.PESO_BRUTO_NF_ENT = new System.Data.DataColumn();
            this.PESO_LIQUIDO_NF_ENT = new System.Data.DataColumn();
            this.INF_COMPL_NF_ENT = new System.Data.DataColumn();
            this.TIPO_MVTO_NF_ENT = new System.Data.DataColumn();
            this.OBS_NF_ENT = new System.Data.DataColumn();
            this.VALOR_EXTENSO_NF_ENT = new System.Data.DataColumn();
            this.TRIBUTADA_NF_ENT = new System.Data.DataColumn();
            this.COBRANCA_NF_ENT = new System.Data.DataColumn();
            this.EXPORTACAO_NF_ENT = new System.Data.DataColumn();
            this.UF_EMBARQUE_EXPORTACAO_ENT = new System.Data.DataColumn();
            this.LOCAL_EMBARQUE_EXPORTACAO_ENT = new System.Data.DataColumn();
            this.BENEFICIAMENTO_NF_ENT = new System.Data.DataColumn();
            this.STATUS_NF_ENT = new System.Data.DataColumn();
            this.CHAVE_ACESSO_NF_ENT = new System.Data.DataColumn();
            this.VALOR_TOTAL_SERVICOS_NF_ENT = new System.Data.DataColumn();
            this.BASE_CALCULO_ISS_NF_ENT = new System.Data.DataColumn();
            this.VALOR_ISS_NF_ENT = new System.Data.DataColumn();
            this.RECIBO_NF_ENT = new System.Data.DataColumn();
            this.ENTRADA_SAIDA_NF_ENT = new System.Data.DataColumn();
            this.NATUREZA_OPERACAO_NF_ENT = new System.Data.DataColumn();
            this.CNPJ_CLIENTE_FORN_ENT = new System.Data.DataColumn();
            this.NFE_TESTE_ENT = new System.Data.DataColumn();
            this.N_PROTOCOLO_AUTORIZACAO_NF_ENT = new System.Data.DataColumn();
            this.MOTIVO_CANCELAMENTO_NF_ENT = new System.Data.DataColumn();
            this.NOTA_STRING_NF_ENT = new System.Data.DataColumn();
            this.END_NUMERO_STRING_NF_ENT = new System.Data.DataColumn();
            this.RAZAO_SOCIAL_CL_NF_ENT = new System.Data.DataColumn();
            this.IE_CL_NF_ENT = new System.Data.DataColumn();
            this.CNPJ_CL_NF_ENT = new System.Data.DataColumn();
            this.BAIRRO_CL_NF_ENT = new System.Data.DataColumn();
            this.CIDADE_CL_NF_ENT = new System.Data.DataColumn();
            this.ESTADO_CL_NF_ENT = new System.Data.DataColumn();
            this.PAIS_CL_NF_ENT = new System.Data.DataColumn();
            this.CEP_CL_NF_ENT = new System.Data.DataColumn();
            this.FONE_CL_NF_ENT = new System.Data.DataColumn();
            this.EMAIL_CL_NF_ENT = new System.Data.DataColumn();
            this.IMPORTACAO_NF_ENT = new System.Data.DataColumn();
            this.DIGITADO_POR_NF_ENT = new System.Data.DataColumn();
            this.CONFERIDO_POR_NF_ENT = new System.Data.DataColumn();
            this.RAZAO_TRANSP_NF_ENT = new System.Data.DataColumn();
            this.ENDERECO_TRANSP_NF_ENT = new System.Data.DataColumn();
            this.IE_TRANSP_NF_ENT = new System.Data.DataColumn();
            this.CNPJ_TRANSP_NF_ENT = new System.Data.DataColumn();
            this.CIDADE_TRANSP_NF_ENT = new System.Data.DataColumn();
            this.UF_TRANSP_NF_ENT = new System.Data.DataColumn();
            this.COD_BARRAS_NF_ENT = new System.Data.DataColumn();
            this.SEM_OP_NF_ENT = new System.Data.DataColumn();
            this.DATA_AUTORIZACAO_NF_ENT = new System.Data.DataColumn();
            this.HORA_AUTORIZACAO_NF_ENT = new System.Data.DataColumn();
            this.ESTADO_CLIENTE_NF_ENT = new System.Data.DataColumn();
            this.REFERENCIADA_NF_ENT = new System.Data.DataColumn();
            this.N_NF_ENT_REFERENCIADA_NF_ENT = new System.Data.DataColumn();
            this.DESCONTO_NF_ENT = new System.Data.DataColumn();
            this.VALOR_SIMPLES_NF_ENT = new System.Data.DataColumn();
            this.ALIQUOTA_SIMPLES_NF_ENT = new System.Data.DataColumn();
            this.BAIXADA_NF_ENT = new System.Data.DataColumn();
            this.cODSISTEMANFENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_n_nf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAENTRSAINFENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTEFORNNFENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORNOTANFENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNota_fiscal_ent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNota_fiscal_ent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NOTA_FISCAL_ENT)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tb_cliente);
            this.panel1.Controls.Add(this.tb_n_nf);
            this.panel1.Location = new System.Drawing.Point(11, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 78);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Forn/Cli:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nº NF:";
            // 
            // tb_cliente
            // 
            this.tb_cliente.Location = new System.Drawing.Point(95, 41);
            this.tb_cliente.Name = "tb_cliente";
            this.tb_cliente.Size = new System.Drawing.Size(370, 20);
            this.tb_cliente.TabIndex = 1;
            this.tb_cliente.TextChanged += new System.EventHandler(this.tb_cliente_TextChanged);
            // 
            // tb_n_nf
            // 
            this.tb_n_nf.Location = new System.Drawing.Point(95, 15);
            this.tb_n_nf.Name = "tb_n_nf";
            this.tb_n_nf.Size = new System.Drawing.Size(100, 20);
            this.tb_n_nf.TabIndex = 0;
            this.tb_n_nf.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // datNota_fiscal_ent
            // 
            this.datNota_fiscal_ent.DeleteCommand = this.fbCommand4;
            this.datNota_fiscal_ent.InsertCommand = this.fbCommand2;
            this.datNota_fiscal_ent.SelectCommand = this.fbCommand1;
            this.datNota_fiscal_ent.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * from nota_fiscal_ent order by DATA_ENTR_SAI_NF_ENT desc";
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
            // dgvNota_fiscal_ent
            // 
            this.dgvNota_fiscal_ent.AutoGenerateColumns = false;
            this.dgvNota_fiscal_ent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNota_fiscal_ent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODSISTEMANFENTDataGridViewTextBoxColumn,
            this.col_n_nf,
            this.dATAENTRSAINFENTDataGridViewTextBoxColumn,
            this.cLIENTEFORNNFENTDataGridViewTextBoxColumn,
            this.vALORNOTANFENTDataGridViewTextBoxColumn,
            this.dataGridViewCheckBoxColumn1});
            this.dgvNota_fiscal_ent.DataMember = "NOTA_FISCAL_ENT";
            this.dgvNota_fiscal_ent.DataSource = this.dsNota_fiscal_ent;
            this.dgvNota_fiscal_ent.Location = new System.Drawing.Point(10, 100);
            this.dgvNota_fiscal_ent.Name = "dgvNota_fiscal_ent";
            this.dgvNota_fiscal_ent.Size = new System.Drawing.Size(661, 407);
            this.dgvNota_fiscal_ent.TabIndex = 1;
            this.dgvNota_fiscal_ent.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNota_fiscal_ent_CellDoubleClick);
            // 
            // dsNota_fiscal_ent
            // 
            this.dsNota_fiscal_ent.DataSetName = "dsNota_fiscal_ent";
            this.dsNota_fiscal_ent.Namespace = "http://www.tempuri.org/dsNota_fiscal_ent.xsd";
            this.dsNota_fiscal_ent.Tables.AddRange(new System.Data.DataTable[] {
            this.NOTA_FISCAL_ENT});
            // 
            // NOTA_FISCAL_ENT
            // 
            this.NOTA_FISCAL_ENT.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_SISTEMA_NF_ENT,
            this.N_NF_ENT,
            this.ENTRADA_NF_ENT,
            this.SAIDA_NF_ENT,
            this.FORMA_PGTO_NF_ENT,
            this.DATA_ENTR_SAI_NF_ENT,
            this.DATA_EMISSAO_NF_ENT,
            this.DATA_VENCIMENTO_NF_ENT,
            this.CFO_NF_ENT,
            this.CFO_2_NF_ENT,
            this.CLIENTE_FORN_NF_ENT,
            this.ENDERECO_ENTREGA_NF_ENT,
            this.BASE_CALC_ICMS_NF_ENT,
            this.VALOR_ICMS_NF_ENT,
            this.BASE_CALC_ICM_SUBS_ENT,
            this.VALOR_ICM_SUBS_ENT,
            this.VALOR_FRETE_NF_ENT,
            this.VALOR_SEGURO_NF_ENT,
            this.OUTRAS_DESP_NF_ENT,
            this.VALOR_IPI_NF_ENT,
            this.VALOR_TOT_PROD_NF_ENT,
            this.VALOR_NOTA_NF_ENT,
            this.TRANSPORTADORA_NF_ENT,
            this.FRETE_CONTA_NF_ENT,
            this.PLACA_VEICULO_NF_ENT,
            this.ESTADO_VEICULO_NF_ENT,
            this.QTDE_NF_ENT,
            this.ESPECIE_NF_ENT,
            this.MARCA_NF_ENT,
            this.PESO_BRUTO_NF_ENT,
            this.PESO_LIQUIDO_NF_ENT,
            this.INF_COMPL_NF_ENT,
            this.TIPO_MVTO_NF_ENT,
            this.OBS_NF_ENT,
            this.VALOR_EXTENSO_NF_ENT,
            this.TRIBUTADA_NF_ENT,
            this.COBRANCA_NF_ENT,
            this.EXPORTACAO_NF_ENT,
            this.UF_EMBARQUE_EXPORTACAO_ENT,
            this.LOCAL_EMBARQUE_EXPORTACAO_ENT,
            this.BENEFICIAMENTO_NF_ENT,
            this.STATUS_NF_ENT,
            this.CHAVE_ACESSO_NF_ENT,
            this.VALOR_TOTAL_SERVICOS_NF_ENT,
            this.BASE_CALCULO_ISS_NF_ENT,
            this.VALOR_ISS_NF_ENT,
            this.RECIBO_NF_ENT,
            this.ENTRADA_SAIDA_NF_ENT,
            this.NATUREZA_OPERACAO_NF_ENT,
            this.CNPJ_CLIENTE_FORN_ENT,
            this.NFE_TESTE_ENT,
            this.N_PROTOCOLO_AUTORIZACAO_NF_ENT,
            this.MOTIVO_CANCELAMENTO_NF_ENT,
            this.NOTA_STRING_NF_ENT,
            this.END_NUMERO_STRING_NF_ENT,
            this.RAZAO_SOCIAL_CL_NF_ENT,
            this.IE_CL_NF_ENT,
            this.CNPJ_CL_NF_ENT,
            this.BAIRRO_CL_NF_ENT,
            this.CIDADE_CL_NF_ENT,
            this.ESTADO_CL_NF_ENT,
            this.PAIS_CL_NF_ENT,
            this.CEP_CL_NF_ENT,
            this.FONE_CL_NF_ENT,
            this.EMAIL_CL_NF_ENT,
            this.IMPORTACAO_NF_ENT,
            this.DIGITADO_POR_NF_ENT,
            this.CONFERIDO_POR_NF_ENT,
            this.RAZAO_TRANSP_NF_ENT,
            this.ENDERECO_TRANSP_NF_ENT,
            this.IE_TRANSP_NF_ENT,
            this.CNPJ_TRANSP_NF_ENT,
            this.CIDADE_TRANSP_NF_ENT,
            this.UF_TRANSP_NF_ENT,
            this.COD_BARRAS_NF_ENT,
            this.SEM_OP_NF_ENT,
            this.DATA_AUTORIZACAO_NF_ENT,
            this.HORA_AUTORIZACAO_NF_ENT,
            this.ESTADO_CLIENTE_NF_ENT,
            this.REFERENCIADA_NF_ENT,
            this.N_NF_ENT_REFERENCIADA_NF_ENT,
            this.DESCONTO_NF_ENT,
            this.VALOR_SIMPLES_NF_ENT,
            this.ALIQUOTA_SIMPLES_NF_ENT,
            this.BAIXADA_NF_ENT});
            this.NOTA_FISCAL_ENT.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_SISTEMA_NF_ENT"}, true)});
            this.NOTA_FISCAL_ENT.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_SISTEMA_NF_ENT};
            this.NOTA_FISCAL_ENT.TableName = "NOTA_FISCAL_ENT";
            // 
            // COD_SISTEMA_NF_ENT
            // 
            this.COD_SISTEMA_NF_ENT.AllowDBNull = false;
            this.COD_SISTEMA_NF_ENT.ColumnName = "COD_SISTEMA_NF_ENT";
            this.COD_SISTEMA_NF_ENT.DataType = typeof(int);
            // 
            // N_NF_ENT
            // 
            this.N_NF_ENT.ColumnName = "N_NF_ENT";
            this.N_NF_ENT.DataType = typeof(int);
            // 
            // ENTRADA_NF_ENT
            // 
            this.ENTRADA_NF_ENT.ColumnName = "ENTRADA_NF_ENT";
            this.ENTRADA_NF_ENT.DataType = typeof(int);
            // 
            // SAIDA_NF_ENT
            // 
            this.SAIDA_NF_ENT.ColumnName = "SAIDA_NF_ENT";
            this.SAIDA_NF_ENT.DataType = typeof(int);
            // 
            // FORMA_PGTO_NF_ENT
            // 
            this.FORMA_PGTO_NF_ENT.ColumnName = "FORMA_PGTO_NF_ENT";
            this.FORMA_PGTO_NF_ENT.MaxLength = 20;
            // 
            // DATA_ENTR_SAI_NF_ENT
            // 
            this.DATA_ENTR_SAI_NF_ENT.ColumnName = "DATA_ENTR_SAI_NF_ENT";
            this.DATA_ENTR_SAI_NF_ENT.DataType = typeof(System.DateTime);
            // 
            // DATA_EMISSAO_NF_ENT
            // 
            this.DATA_EMISSAO_NF_ENT.ColumnName = "DATA_EMISSAO_NF_ENT";
            this.DATA_EMISSAO_NF_ENT.DataType = typeof(System.DateTime);
            // 
            // DATA_VENCIMENTO_NF_ENT
            // 
            this.DATA_VENCIMENTO_NF_ENT.ColumnName = "DATA_VENCIMENTO_NF_ENT";
            this.DATA_VENCIMENTO_NF_ENT.DataType = typeof(System.DateTime);
            // 
            // CFO_NF_ENT
            // 
            this.CFO_NF_ENT.ColumnName = "CFO_NF_ENT";
            this.CFO_NF_ENT.MaxLength = 15;
            // 
            // CFO_2_NF_ENT
            // 
            this.CFO_2_NF_ENT.ColumnName = "CFO_2_NF_ENT";
            this.CFO_2_NF_ENT.MaxLength = 15;
            // 
            // CLIENTE_FORN_NF_ENT
            // 
            this.CLIENTE_FORN_NF_ENT.ColumnName = "CLIENTE_FORN_NF_ENT";
            this.CLIENTE_FORN_NF_ENT.MaxLength = 100;
            // 
            // ENDERECO_ENTREGA_NF_ENT
            // 
            this.ENDERECO_ENTREGA_NF_ENT.ColumnName = "ENDERECO_ENTREGA_NF_ENT";
            this.ENDERECO_ENTREGA_NF_ENT.MaxLength = 100;
            // 
            // BASE_CALC_ICMS_NF_ENT
            // 
            this.BASE_CALC_ICMS_NF_ENT.ColumnName = "BASE_CALC_ICMS_NF_ENT";
            this.BASE_CALC_ICMS_NF_ENT.DataType = typeof(double);
            // 
            // VALOR_ICMS_NF_ENT
            // 
            this.VALOR_ICMS_NF_ENT.ColumnName = "VALOR_ICMS_NF_ENT";
            this.VALOR_ICMS_NF_ENT.DataType = typeof(double);
            // 
            // BASE_CALC_ICM_SUBS_ENT
            // 
            this.BASE_CALC_ICM_SUBS_ENT.ColumnName = "BASE_CALC_ICM_SUBS_ENT";
            this.BASE_CALC_ICM_SUBS_ENT.DataType = typeof(double);
            // 
            // VALOR_ICM_SUBS_ENT
            // 
            this.VALOR_ICM_SUBS_ENT.ColumnName = "VALOR_ICM_SUBS_ENT";
            this.VALOR_ICM_SUBS_ENT.DataType = typeof(double);
            // 
            // VALOR_FRETE_NF_ENT
            // 
            this.VALOR_FRETE_NF_ENT.ColumnName = "VALOR_FRETE_NF_ENT";
            this.VALOR_FRETE_NF_ENT.DataType = typeof(double);
            // 
            // VALOR_SEGURO_NF_ENT
            // 
            this.VALOR_SEGURO_NF_ENT.ColumnName = "VALOR_SEGURO_NF_ENT";
            this.VALOR_SEGURO_NF_ENT.DataType = typeof(double);
            // 
            // OUTRAS_DESP_NF_ENT
            // 
            this.OUTRAS_DESP_NF_ENT.ColumnName = "OUTRAS_DESP_NF_ENT";
            this.OUTRAS_DESP_NF_ENT.DataType = typeof(double);
            // 
            // VALOR_IPI_NF_ENT
            // 
            this.VALOR_IPI_NF_ENT.ColumnName = "VALOR_IPI_NF_ENT";
            this.VALOR_IPI_NF_ENT.DataType = typeof(double);
            // 
            // VALOR_TOT_PROD_NF_ENT
            // 
            this.VALOR_TOT_PROD_NF_ENT.ColumnName = "VALOR_TOT_PROD_NF_ENT";
            this.VALOR_TOT_PROD_NF_ENT.DataType = typeof(double);
            // 
            // VALOR_NOTA_NF_ENT
            // 
            this.VALOR_NOTA_NF_ENT.ColumnName = "VALOR_NOTA_NF_ENT";
            this.VALOR_NOTA_NF_ENT.DataType = typeof(double);
            // 
            // TRANSPORTADORA_NF_ENT
            // 
            this.TRANSPORTADORA_NF_ENT.ColumnName = "TRANSPORTADORA_NF_ENT";
            this.TRANSPORTADORA_NF_ENT.MaxLength = 100;
            // 
            // FRETE_CONTA_NF_ENT
            // 
            this.FRETE_CONTA_NF_ENT.ColumnName = "FRETE_CONTA_NF_ENT";
            this.FRETE_CONTA_NF_ENT.DataType = typeof(int);
            // 
            // PLACA_VEICULO_NF_ENT
            // 
            this.PLACA_VEICULO_NF_ENT.ColumnName = "PLACA_VEICULO_NF_ENT";
            this.PLACA_VEICULO_NF_ENT.MaxLength = 15;
            // 
            // ESTADO_VEICULO_NF_ENT
            // 
            this.ESTADO_VEICULO_NF_ENT.ColumnName = "ESTADO_VEICULO_NF_ENT";
            this.ESTADO_VEICULO_NF_ENT.MaxLength = 15;
            // 
            // QTDE_NF_ENT
            // 
            this.QTDE_NF_ENT.ColumnName = "QTDE_NF_ENT";
            this.QTDE_NF_ENT.DataType = typeof(int);
            // 
            // ESPECIE_NF_ENT
            // 
            this.ESPECIE_NF_ENT.ColumnName = "ESPECIE_NF_ENT";
            this.ESPECIE_NF_ENT.MaxLength = 20;
            // 
            // MARCA_NF_ENT
            // 
            this.MARCA_NF_ENT.ColumnName = "MARCA_NF_ENT";
            this.MARCA_NF_ENT.MaxLength = 20;
            // 
            // PESO_BRUTO_NF_ENT
            // 
            this.PESO_BRUTO_NF_ENT.ColumnName = "PESO_BRUTO_NF_ENT";
            this.PESO_BRUTO_NF_ENT.DataType = typeof(double);
            // 
            // PESO_LIQUIDO_NF_ENT
            // 
            this.PESO_LIQUIDO_NF_ENT.ColumnName = "PESO_LIQUIDO_NF_ENT";
            this.PESO_LIQUIDO_NF_ENT.DataType = typeof(double);
            // 
            // INF_COMPL_NF_ENT
            // 
            this.INF_COMPL_NF_ENT.ColumnName = "INF_COMPL_NF_ENT";
            this.INF_COMPL_NF_ENT.MaxLength = 5000;
            // 
            // TIPO_MVTO_NF_ENT
            // 
            this.TIPO_MVTO_NF_ENT.ColumnName = "TIPO_MVTO_NF_ENT";
            this.TIPO_MVTO_NF_ENT.MaxLength = 50;
            // 
            // OBS_NF_ENT
            // 
            this.OBS_NF_ENT.ColumnName = "OBS_NF_ENT";
            this.OBS_NF_ENT.MaxLength = 50;
            // 
            // VALOR_EXTENSO_NF_ENT
            // 
            this.VALOR_EXTENSO_NF_ENT.ColumnName = "VALOR_EXTENSO_NF_ENT";
            this.VALOR_EXTENSO_NF_ENT.MaxLength = 100;
            // 
            // TRIBUTADA_NF_ENT
            // 
            this.TRIBUTADA_NF_ENT.ColumnName = "TRIBUTADA_NF_ENT";
            this.TRIBUTADA_NF_ENT.DataType = typeof(int);
            // 
            // COBRANCA_NF_ENT
            // 
            this.COBRANCA_NF_ENT.ColumnName = "COBRANCA_NF_ENT";
            this.COBRANCA_NF_ENT.DataType = typeof(int);
            // 
            // EXPORTACAO_NF_ENT
            // 
            this.EXPORTACAO_NF_ENT.ColumnName = "EXPORTACAO_NF_ENT";
            this.EXPORTACAO_NF_ENT.DataType = typeof(int);
            // 
            // UF_EMBARQUE_EXPORTACAO_ENT
            // 
            this.UF_EMBARQUE_EXPORTACAO_ENT.ColumnName = "UF_EMBARQUE_EXPORTACAO_ENT";
            this.UF_EMBARQUE_EXPORTACAO_ENT.MaxLength = 2;
            // 
            // LOCAL_EMBARQUE_EXPORTACAO_ENT
            // 
            this.LOCAL_EMBARQUE_EXPORTACAO_ENT.ColumnName = "LOCAL_EMBARQUE_EXPORTACAO_ENT";
            this.LOCAL_EMBARQUE_EXPORTACAO_ENT.MaxLength = 60;
            // 
            // BENEFICIAMENTO_NF_ENT
            // 
            this.BENEFICIAMENTO_NF_ENT.ColumnName = "BENEFICIAMENTO_NF_ENT";
            this.BENEFICIAMENTO_NF_ENT.DataType = typeof(int);
            // 
            // STATUS_NF_ENT
            // 
            this.STATUS_NF_ENT.ColumnName = "STATUS_NF_ENT";
            this.STATUS_NF_ENT.MaxLength = 200;
            // 
            // CHAVE_ACESSO_NF_ENT
            // 
            this.CHAVE_ACESSO_NF_ENT.ColumnName = "CHAVE_ACESSO_NF_ENT";
            this.CHAVE_ACESSO_NF_ENT.MaxLength = 100;
            // 
            // VALOR_TOTAL_SERVICOS_NF_ENT
            // 
            this.VALOR_TOTAL_SERVICOS_NF_ENT.ColumnName = "VALOR_TOTAL_SERVICOS_NF_ENT";
            this.VALOR_TOTAL_SERVICOS_NF_ENT.DataType = typeof(double);
            // 
            // BASE_CALCULO_ISS_NF_ENT
            // 
            this.BASE_CALCULO_ISS_NF_ENT.ColumnName = "BASE_CALCULO_ISS_NF_ENT";
            this.BASE_CALCULO_ISS_NF_ENT.DataType = typeof(double);
            // 
            // VALOR_ISS_NF_ENT
            // 
            this.VALOR_ISS_NF_ENT.ColumnName = "VALOR_ISS_NF_ENT";
            this.VALOR_ISS_NF_ENT.DataType = typeof(double);
            // 
            // RECIBO_NF_ENT
            // 
            this.RECIBO_NF_ENT.ColumnName = "RECIBO_NF_ENT";
            this.RECIBO_NF_ENT.MaxLength = 100;
            // 
            // ENTRADA_SAIDA_NF_ENT
            // 
            this.ENTRADA_SAIDA_NF_ENT.ColumnName = "ENTRADA_SAIDA_NF_ENT";
            this.ENTRADA_SAIDA_NF_ENT.DataType = typeof(int);
            // 
            // NATUREZA_OPERACAO_NF_ENT
            // 
            this.NATUREZA_OPERACAO_NF_ENT.ColumnName = "NATUREZA_OPERACAO_NF_ENT";
            this.NATUREZA_OPERACAO_NF_ENT.MaxLength = 200;
            // 
            // CNPJ_CLIENTE_FORN_ENT
            // 
            this.CNPJ_CLIENTE_FORN_ENT.ColumnName = "CNPJ_CLIENTE_FORN_ENT";
            this.CNPJ_CLIENTE_FORN_ENT.MaxLength = 30;
            // 
            // NFE_TESTE_ENT
            // 
            this.NFE_TESTE_ENT.ColumnName = "NFE_TESTE_ENT";
            this.NFE_TESTE_ENT.DataType = typeof(int);
            // 
            // N_PROTOCOLO_AUTORIZACAO_NF_ENT
            // 
            this.N_PROTOCOLO_AUTORIZACAO_NF_ENT.ColumnName = "N_PROTOCOLO_AUTORIZACAO_NF_ENT";
            this.N_PROTOCOLO_AUTORIZACAO_NF_ENT.MaxLength = 200;
            // 
            // MOTIVO_CANCELAMENTO_NF_ENT
            // 
            this.MOTIVO_CANCELAMENTO_NF_ENT.ColumnName = "MOTIVO_CANCELAMENTO_NF_ENT";
            this.MOTIVO_CANCELAMENTO_NF_ENT.MaxLength = 200;
            // 
            // NOTA_STRING_NF_ENT
            // 
            this.NOTA_STRING_NF_ENT.ColumnName = "NOTA_STRING_NF_ENT";
            this.NOTA_STRING_NF_ENT.MaxLength = 9;
            // 
            // END_NUMERO_STRING_NF_ENT
            // 
            this.END_NUMERO_STRING_NF_ENT.ColumnName = "END_NUMERO_STRING_NF_ENT";
            this.END_NUMERO_STRING_NF_ENT.MaxLength = 250;
            // 
            // RAZAO_SOCIAL_CL_NF_ENT
            // 
            this.RAZAO_SOCIAL_CL_NF_ENT.ColumnName = "RAZAO_SOCIAL_CL_NF_ENT";
            this.RAZAO_SOCIAL_CL_NF_ENT.MaxLength = 70;
            // 
            // IE_CL_NF_ENT
            // 
            this.IE_CL_NF_ENT.ColumnName = "IE_CL_NF_ENT";
            this.IE_CL_NF_ENT.MaxLength = 70;
            // 
            // CNPJ_CL_NF_ENT
            // 
            this.CNPJ_CL_NF_ENT.ColumnName = "CNPJ_CL_NF_ENT";
            this.CNPJ_CL_NF_ENT.MaxLength = 70;
            // 
            // BAIRRO_CL_NF_ENT
            // 
            this.BAIRRO_CL_NF_ENT.ColumnName = "BAIRRO_CL_NF_ENT";
            this.BAIRRO_CL_NF_ENT.MaxLength = 70;
            // 
            // CIDADE_CL_NF_ENT
            // 
            this.CIDADE_CL_NF_ENT.ColumnName = "CIDADE_CL_NF_ENT";
            this.CIDADE_CL_NF_ENT.MaxLength = 70;
            // 
            // ESTADO_CL_NF_ENT
            // 
            this.ESTADO_CL_NF_ENT.ColumnName = "ESTADO_CL_NF_ENT";
            this.ESTADO_CL_NF_ENT.MaxLength = 70;
            // 
            // PAIS_CL_NF_ENT
            // 
            this.PAIS_CL_NF_ENT.ColumnName = "PAIS_CL_NF_ENT";
            this.PAIS_CL_NF_ENT.MaxLength = 70;
            // 
            // CEP_CL_NF_ENT
            // 
            this.CEP_CL_NF_ENT.ColumnName = "CEP_CL_NF_ENT";
            this.CEP_CL_NF_ENT.MaxLength = 70;
            // 
            // FONE_CL_NF_ENT
            // 
            this.FONE_CL_NF_ENT.ColumnName = "FONE_CL_NF_ENT";
            this.FONE_CL_NF_ENT.MaxLength = 70;
            // 
            // EMAIL_CL_NF_ENT
            // 
            this.EMAIL_CL_NF_ENT.ColumnName = "EMAIL_CL_NF_ENT";
            this.EMAIL_CL_NF_ENT.MaxLength = 70;
            // 
            // IMPORTACAO_NF_ENT
            // 
            this.IMPORTACAO_NF_ENT.ColumnName = "IMPORTACAO_NF_ENT";
            this.IMPORTACAO_NF_ENT.DataType = typeof(int);
            // 
            // DIGITADO_POR_NF_ENT
            // 
            this.DIGITADO_POR_NF_ENT.ColumnName = "DIGITADO_POR_NF_ENT";
            this.DIGITADO_POR_NF_ENT.MaxLength = 50;
            // 
            // CONFERIDO_POR_NF_ENT
            // 
            this.CONFERIDO_POR_NF_ENT.ColumnName = "CONFERIDO_POR_NF_ENT";
            this.CONFERIDO_POR_NF_ENT.MaxLength = 50;
            // 
            // RAZAO_TRANSP_NF_ENT
            // 
            this.RAZAO_TRANSP_NF_ENT.ColumnName = "RAZAO_TRANSP_NF_ENT";
            this.RAZAO_TRANSP_NF_ENT.MaxLength = 100;
            // 
            // ENDERECO_TRANSP_NF_ENT
            // 
            this.ENDERECO_TRANSP_NF_ENT.ColumnName = "ENDERECO_TRANSP_NF_ENT";
            this.ENDERECO_TRANSP_NF_ENT.MaxLength = 100;
            // 
            // IE_TRANSP_NF_ENT
            // 
            this.IE_TRANSP_NF_ENT.ColumnName = "IE_TRANSP_NF_ENT";
            this.IE_TRANSP_NF_ENT.MaxLength = 30;
            // 
            // CNPJ_TRANSP_NF_ENT
            // 
            this.CNPJ_TRANSP_NF_ENT.ColumnName = "CNPJ_TRANSP_NF_ENT";
            this.CNPJ_TRANSP_NF_ENT.MaxLength = 30;
            // 
            // CIDADE_TRANSP_NF_ENT
            // 
            this.CIDADE_TRANSP_NF_ENT.ColumnName = "CIDADE_TRANSP_NF_ENT";
            this.CIDADE_TRANSP_NF_ENT.MaxLength = 50;
            // 
            // UF_TRANSP_NF_ENT
            // 
            this.UF_TRANSP_NF_ENT.ColumnName = "UF_TRANSP_NF_ENT";
            this.UF_TRANSP_NF_ENT.MaxLength = 2;
            // 
            // COD_BARRAS_NF_ENT
            // 
            this.COD_BARRAS_NF_ENT.ColumnName = "COD_BARRAS_NF_ENT";
            this.COD_BARRAS_NF_ENT.DataType = typeof(byte[]);
            // 
            // SEM_OP_NF_ENT
            // 
            this.SEM_OP_NF_ENT.ColumnName = "SEM_OP_NF_ENT";
            this.SEM_OP_NF_ENT.DataType = typeof(int);
            // 
            // DATA_AUTORIZACAO_NF_ENT
            // 
            this.DATA_AUTORIZACAO_NF_ENT.ColumnName = "DATA_AUTORIZACAO_NF_ENT";
            this.DATA_AUTORIZACAO_NF_ENT.DataType = typeof(System.DateTime);
            // 
            // HORA_AUTORIZACAO_NF_ENT
            // 
            this.HORA_AUTORIZACAO_NF_ENT.ColumnName = "HORA_AUTORIZACAO_NF_ENT";
            this.HORA_AUTORIZACAO_NF_ENT.MaxLength = 50;
            // 
            // ESTADO_CLIENTE_NF_ENT
            // 
            this.ESTADO_CLIENTE_NF_ENT.ColumnName = "ESTADO_CLIENTE_NF_ENT";
            this.ESTADO_CLIENTE_NF_ENT.MaxLength = 2;
            // 
            // REFERENCIADA_NF_ENT
            // 
            this.REFERENCIADA_NF_ENT.ColumnName = "REFERENCIADA_NF_ENT";
            this.REFERENCIADA_NF_ENT.DataType = typeof(int);
            // 
            // N_NF_ENT_REFERENCIADA_NF_ENT
            // 
            this.N_NF_ENT_REFERENCIADA_NF_ENT.ColumnName = "N_NF_ENT_REFERENCIADA_NF_ENT";
            this.N_NF_ENT_REFERENCIADA_NF_ENT.MaxLength = 300;
            // 
            // DESCONTO_NF_ENT
            // 
            this.DESCONTO_NF_ENT.ColumnName = "DESCONTO_NF_ENT";
            this.DESCONTO_NF_ENT.DataType = typeof(double);
            // 
            // VALOR_SIMPLES_NF_ENT
            // 
            this.VALOR_SIMPLES_NF_ENT.ColumnName = "VALOR_SIMPLES_NF_ENT";
            this.VALOR_SIMPLES_NF_ENT.DataType = typeof(double);
            // 
            // ALIQUOTA_SIMPLES_NF_ENT
            // 
            this.ALIQUOTA_SIMPLES_NF_ENT.ColumnName = "ALIQUOTA_SIMPLES_NF_ENT";
            this.ALIQUOTA_SIMPLES_NF_ENT.DataType = typeof(double);
            // 
            // BAIXADA_NF_ENT
            // 
            this.BAIXADA_NF_ENT.ColumnName = "BAIXADA_NF_ENT";
            this.BAIXADA_NF_ENT.DataType = typeof(int);
            // 
            // cODSISTEMANFENTDataGridViewTextBoxColumn
            // 
            this.cODSISTEMANFENTDataGridViewTextBoxColumn.DataPropertyName = "COD_SISTEMA_NF_ENT";
            this.cODSISTEMANFENTDataGridViewTextBoxColumn.HeaderText = "COD_SISTEMA_NF_ENT";
            this.cODSISTEMANFENTDataGridViewTextBoxColumn.Name = "cODSISTEMANFENTDataGridViewTextBoxColumn";
            this.cODSISTEMANFENTDataGridViewTextBoxColumn.Visible = false;
            // 
            // col_n_nf
            // 
            this.col_n_nf.DataPropertyName = "N_NF_ENT";
            this.col_n_nf.HeaderText = "Nº NF";
            this.col_n_nf.Name = "col_n_nf";
            // 
            // dATAENTRSAINFENTDataGridViewTextBoxColumn
            // 
            this.dATAENTRSAINFENTDataGridViewTextBoxColumn.DataPropertyName = "DATA_ENTR_SAI_NF_ENT";
            this.dATAENTRSAINFENTDataGridViewTextBoxColumn.HeaderText = "Data Entrada";
            this.dATAENTRSAINFENTDataGridViewTextBoxColumn.Name = "dATAENTRSAINFENTDataGridViewTextBoxColumn";
            // 
            // cLIENTEFORNNFENTDataGridViewTextBoxColumn
            // 
            this.cLIENTEFORNNFENTDataGridViewTextBoxColumn.DataPropertyName = "CLIENTE_FORN_NF_ENT";
            this.cLIENTEFORNNFENTDataGridViewTextBoxColumn.HeaderText = "Cliente/Forn";
            this.cLIENTEFORNNFENTDataGridViewTextBoxColumn.Name = "cLIENTEFORNNFENTDataGridViewTextBoxColumn";
            this.cLIENTEFORNNFENTDataGridViewTextBoxColumn.Width = 200;
            // 
            // vALORNOTANFENTDataGridViewTextBoxColumn
            // 
            this.vALORNOTANFENTDataGridViewTextBoxColumn.DataPropertyName = "VALOR_NOTA_NF_ENT";
            this.vALORNOTANFENTDataGridViewTextBoxColumn.HeaderText = "Valor Nota";
            this.vALORNOTANFENTDataGridViewTextBoxColumn.Name = "vALORNOTANFENTDataGridViewTextBoxColumn";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "BAIXADA_NF_ENT";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Baixada?";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // form_localiza_nf_ent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 521);
            this.Controls.Add(this.dgvNota_fiscal_ent);
            this.Controls.Add(this.panel1);
            this.Name = "form_localiza_nf_ent";
            this.Text = "Localiza NF Entrada";
            this.Load += new System.EventHandler(this.form_localiza_nf_ent_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNota_fiscal_ent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNota_fiscal_ent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NOTA_FISCAL_ENT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datNota_fiscal_ent;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Windows.Forms.DataGridView dgvNota_fiscal_ent;
        private System.Windows.Forms.TextBox tb_cliente;
        private System.Windows.Forms.TextBox tb_n_nf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Data.DataSet dsNota_fiscal_ent;
        private System.Data.DataTable NOTA_FISCAL_ENT;
        private System.Data.DataColumn COD_SISTEMA_NF_ENT;
        private System.Data.DataColumn N_NF_ENT;
        private System.Data.DataColumn ENTRADA_NF_ENT;
        private System.Data.DataColumn SAIDA_NF_ENT;
        private System.Data.DataColumn FORMA_PGTO_NF_ENT;
        private System.Data.DataColumn DATA_ENTR_SAI_NF_ENT;
        private System.Data.DataColumn DATA_EMISSAO_NF_ENT;
        private System.Data.DataColumn DATA_VENCIMENTO_NF_ENT;
        private System.Data.DataColumn CFO_NF_ENT;
        private System.Data.DataColumn CFO_2_NF_ENT;
        private System.Data.DataColumn CLIENTE_FORN_NF_ENT;
        private System.Data.DataColumn ENDERECO_ENTREGA_NF_ENT;
        private System.Data.DataColumn BASE_CALC_ICMS_NF_ENT;
        private System.Data.DataColumn VALOR_ICMS_NF_ENT;
        private System.Data.DataColumn BASE_CALC_ICM_SUBS_ENT;
        private System.Data.DataColumn VALOR_ICM_SUBS_ENT;
        private System.Data.DataColumn VALOR_FRETE_NF_ENT;
        private System.Data.DataColumn VALOR_SEGURO_NF_ENT;
        private System.Data.DataColumn OUTRAS_DESP_NF_ENT;
        private System.Data.DataColumn VALOR_IPI_NF_ENT;
        private System.Data.DataColumn VALOR_TOT_PROD_NF_ENT;
        private System.Data.DataColumn VALOR_NOTA_NF_ENT;
        private System.Data.DataColumn TRANSPORTADORA_NF_ENT;
        private System.Data.DataColumn FRETE_CONTA_NF_ENT;
        private System.Data.DataColumn PLACA_VEICULO_NF_ENT;
        private System.Data.DataColumn ESTADO_VEICULO_NF_ENT;
        private System.Data.DataColumn QTDE_NF_ENT;
        private System.Data.DataColumn ESPECIE_NF_ENT;
        private System.Data.DataColumn MARCA_NF_ENT;
        private System.Data.DataColumn PESO_BRUTO_NF_ENT;
        private System.Data.DataColumn PESO_LIQUIDO_NF_ENT;
        private System.Data.DataColumn INF_COMPL_NF_ENT;
        private System.Data.DataColumn TIPO_MVTO_NF_ENT;
        private System.Data.DataColumn OBS_NF_ENT;
        private System.Data.DataColumn VALOR_EXTENSO_NF_ENT;
        private System.Data.DataColumn TRIBUTADA_NF_ENT;
        private System.Data.DataColumn COBRANCA_NF_ENT;
        private System.Data.DataColumn EXPORTACAO_NF_ENT;
        private System.Data.DataColumn UF_EMBARQUE_EXPORTACAO_ENT;
        private System.Data.DataColumn LOCAL_EMBARQUE_EXPORTACAO_ENT;
        private System.Data.DataColumn BENEFICIAMENTO_NF_ENT;
        private System.Data.DataColumn STATUS_NF_ENT;
        private System.Data.DataColumn CHAVE_ACESSO_NF_ENT;
        private System.Data.DataColumn VALOR_TOTAL_SERVICOS_NF_ENT;
        private System.Data.DataColumn BASE_CALCULO_ISS_NF_ENT;
        private System.Data.DataColumn VALOR_ISS_NF_ENT;
        private System.Data.DataColumn RECIBO_NF_ENT;
        private System.Data.DataColumn ENTRADA_SAIDA_NF_ENT;
        private System.Data.DataColumn NATUREZA_OPERACAO_NF_ENT;
        private System.Data.DataColumn CNPJ_CLIENTE_FORN_ENT;
        private System.Data.DataColumn NFE_TESTE_ENT;
        private System.Data.DataColumn N_PROTOCOLO_AUTORIZACAO_NF_ENT;
        private System.Data.DataColumn MOTIVO_CANCELAMENTO_NF_ENT;
        private System.Data.DataColumn NOTA_STRING_NF_ENT;
        private System.Data.DataColumn END_NUMERO_STRING_NF_ENT;
        private System.Data.DataColumn RAZAO_SOCIAL_CL_NF_ENT;
        private System.Data.DataColumn IE_CL_NF_ENT;
        private System.Data.DataColumn CNPJ_CL_NF_ENT;
        private System.Data.DataColumn BAIRRO_CL_NF_ENT;
        private System.Data.DataColumn CIDADE_CL_NF_ENT;
        private System.Data.DataColumn ESTADO_CL_NF_ENT;
        private System.Data.DataColumn PAIS_CL_NF_ENT;
        private System.Data.DataColumn CEP_CL_NF_ENT;
        private System.Data.DataColumn FONE_CL_NF_ENT;
        private System.Data.DataColumn EMAIL_CL_NF_ENT;
        private System.Data.DataColumn IMPORTACAO_NF_ENT;
        private System.Data.DataColumn DIGITADO_POR_NF_ENT;
        private System.Data.DataColumn CONFERIDO_POR_NF_ENT;
        private System.Data.DataColumn RAZAO_TRANSP_NF_ENT;
        private System.Data.DataColumn ENDERECO_TRANSP_NF_ENT;
        private System.Data.DataColumn IE_TRANSP_NF_ENT;
        private System.Data.DataColumn CNPJ_TRANSP_NF_ENT;
        private System.Data.DataColumn CIDADE_TRANSP_NF_ENT;
        private System.Data.DataColumn UF_TRANSP_NF_ENT;
        private System.Data.DataColumn COD_BARRAS_NF_ENT;
        private System.Data.DataColumn SEM_OP_NF_ENT;
        private System.Data.DataColumn DATA_AUTORIZACAO_NF_ENT;
        private System.Data.DataColumn HORA_AUTORIZACAO_NF_ENT;
        private System.Data.DataColumn ESTADO_CLIENTE_NF_ENT;
        private System.Data.DataColumn REFERENCIADA_NF_ENT;
        private System.Data.DataColumn N_NF_ENT_REFERENCIADA_NF_ENT;
        private System.Data.DataColumn DESCONTO_NF_ENT;
        private System.Data.DataColumn VALOR_SIMPLES_NF_ENT;
        private System.Data.DataColumn ALIQUOTA_SIMPLES_NF_ENT;
        private System.Data.DataColumn BAIXADA_NF_ENT;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODSISTEMANFENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_n_nf;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAENTRSAINFENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTEFORNNFENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORNOTANFENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}