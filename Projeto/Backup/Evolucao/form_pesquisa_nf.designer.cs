namespace Evolucao
{
    partial class form_pesquisa_nf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_pesquisa_nf));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtTermino = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.datNota_fiscal = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsNota_fiscal = new System.Data.DataSet();
            this.NOTA_FISCAL = new System.Data.DataTable();
            this.COD_SISTEMA_NF = new System.Data.DataColumn();
            this.N_NF = new System.Data.DataColumn();
            this.ENTRADA_NF = new System.Data.DataColumn();
            this.SAIDA_NF = new System.Data.DataColumn();
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
            this.INF_COMPL_NF = new System.Data.DataColumn();
            this.TIPO_MVTO_NF = new System.Data.DataColumn();
            this.OBS_NF = new System.Data.DataColumn();
            this.VALOR_EXTENSO_NF = new System.Data.DataColumn();
            this.TRIBUTADA_NF = new System.Data.DataColumn();
            this.COBRANCA_NF = new System.Data.DataColumn();
            this.EXPORTACAO_NF = new System.Data.DataColumn();
            this.UF_EMBARQUE_EXPORTACAO = new System.Data.DataColumn();
            this.LOCAL_EMBARQUE_EXPORTACAO = new System.Data.DataColumn();
            this.BENEFICIAMENTO_NF = new System.Data.DataColumn();
            this.STATUS_NFE = new System.Data.DataColumn();
            this.CHAVE_ACESSO_NFE = new System.Data.DataColumn();
            this.VALOR_TOTAL_SERVICOS_NF = new System.Data.DataColumn();
            this.BASE_CALCULO_ISS_NF = new System.Data.DataColumn();
            this.VALOR_ISS_NF = new System.Data.DataColumn();
            this.RECIBO_NFE = new System.Data.DataColumn();
            this.ENTRADA_SAIDA_NF = new System.Data.DataColumn();
            this.NATUREZA_OPERACAO_NF = new System.Data.DataColumn();
            this.CNPJ_CLIENTE_FORN = new System.Data.DataColumn();
            this.NOTA_STRING_NF = new System.Data.DataColumn();
            this.END_NUMERO_STRING_NF = new System.Data.DataColumn();
            this.RAZAO_SOCIAL_CL_NF = new System.Data.DataColumn();
            this.IE_CL_NF = new System.Data.DataColumn();
            this.CNPJ_CL_NF = new System.Data.DataColumn();
            this.BAIRRO_CL_NF = new System.Data.DataColumn();
            this.CIDADE_CL_NF = new System.Data.DataColumn();
            this.ESTADO_CL_NF = new System.Data.DataColumn();
            this.PAIS_CL_NF = new System.Data.DataColumn();
            this.CEP_CL_NF = new System.Data.DataColumn();
            this.FONE_CL_NF = new System.Data.DataColumn();
            this.EMAIL_CL_NF = new System.Data.DataColumn();
            this.VALOR_SIMPLES_NF = new System.Data.DataColumn();
            this.ALIQUOTA_SIMPLES_NF = new System.Data.DataColumn();
            this.N_PROTOCOLO_AUTORIZACAO_NF = new System.Data.DataColumn();
            this.COD_BARRAS_NF = new System.Data.DataColumn();
            this.NFE_TESTE = new System.Data.DataColumn();
            this.NAO_TRIBUTADA_NF = new System.Data.DataColumn();
            this.PECAS_NF = new System.Data.DataColumn();
            this.TERMINAL_NF = new System.Data.DataColumn();
            this.IPI_SUSPENSO_NF = new System.Data.DataColumn();
            this.SUBST_TRIB_NF = new System.Data.DataColumn();
            this.ARRUELA_NF = new System.Data.DataColumn();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dgvNota_fiscal = new System.Windows.Forms.DataGridView();
            this.dATAEMISSAONFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_n_nf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTEFORNNFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_valor_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VENDEDOR_PED_VENDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODSISTEMANFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNTRADANFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sAIDANFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fORMAPGTONFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAENTRSAINFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAVENCIMENTONFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nATUREZAOPERACAONFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFONFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFO2NFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNDERECOENTREGANFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bASECALCICMSNFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORTOTPRODNFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_obs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNFCOMPLNFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORICMSNFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bASECALCICMSUBSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORICMSUBSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORFRETENFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORSEGURONFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oUTRASDESPNFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ipi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tRANSPORTADORANFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fRETECONTANFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pLACAVEICULONFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSTADOVEICULONFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qTDENFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSPECIENFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mARCANFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pESOBRUTONFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pESOLIQUIDONFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIPOMVTONFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALOREXTENSONFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tRIBUTADANFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOBRANCANFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXPORTACAONFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uFEMBARQUEEXPORTACAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOCALEMBARQUEEXPORTACAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bENEFICIAMENTONFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHAVEACESSONFEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORTOTALSERVICOSNFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bASECALCULOISSNFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORISSNFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rECIBONFEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNTRADASAIDANFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOTASTRINGNFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNDNUMEROSTRINGNFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAZAOSOCIALCLNFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iECLNFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNPJCLNFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bAIRROCLNFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIDADECLNFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSTADOCLNFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAISCLNFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEPCLNFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fONECLNFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILCLNFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORSIMPLESNFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aLIQUOTASIMPLESNFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nPROTOCOLOAUTORIZACAONFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODBARRASNFDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.nFETESTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAOTRIBUTADANFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pECASNFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tERMINALNFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.iPISUSPENSONFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUBSTTRIBNFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aRRUELANFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.tb_cliente_2 = new System.Windows.Forms.TextBox();
            this.tb_n_nf = new System.Windows.Forms.TextBox();
            this.tb_soma = new System.Windows.Forms.TextBox();
            this.cb_faturamento = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_soma_sem_ipi = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_cnpj = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtVendedor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsNota_fiscal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NOTA_FISCAL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNota_fiscal)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dtTermino);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtInicio);
            this.groupBox2.Location = new System.Drawing.Point(13, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(168, 72);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Intervalos de Datas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Término";
            // 
            // dtTermino
            // 
            this.dtTermino.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTermino.Location = new System.Drawing.Point(57, 43);
            this.dtTermino.Name = "dtTermino";
            this.dtTermino.Size = new System.Drawing.Size(95, 20);
            this.dtTermino.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inicio";
            // 
            // dtInicio
            // 
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicio.Location = new System.Drawing.Point(57, 19);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(95, 20);
            this.dtInicio.TabIndex = 0;
            // 
            // datNota_fiscal
            // 
            this.datNota_fiscal.DeleteCommand = this.fbCommand4;
            this.datNota_fiscal.InsertCommand = this.fbCommand2;
            this.datNota_fiscal.SelectCommand = this.fbCommand1;
            this.datNota_fiscal.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = resources.GetString("fbCommand1.CommandText");
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
            this.ENTRADA_NF,
            this.SAIDA_NF,
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
            this.INF_COMPL_NF,
            this.TIPO_MVTO_NF,
            this.OBS_NF,
            this.VALOR_EXTENSO_NF,
            this.TRIBUTADA_NF,
            this.COBRANCA_NF,
            this.EXPORTACAO_NF,
            this.UF_EMBARQUE_EXPORTACAO,
            this.LOCAL_EMBARQUE_EXPORTACAO,
            this.BENEFICIAMENTO_NF,
            this.STATUS_NFE,
            this.CHAVE_ACESSO_NFE,
            this.VALOR_TOTAL_SERVICOS_NF,
            this.BASE_CALCULO_ISS_NF,
            this.VALOR_ISS_NF,
            this.RECIBO_NFE,
            this.ENTRADA_SAIDA_NF,
            this.NATUREZA_OPERACAO_NF,
            this.CNPJ_CLIENTE_FORN,
            this.NOTA_STRING_NF,
            this.END_NUMERO_STRING_NF,
            this.RAZAO_SOCIAL_CL_NF,
            this.IE_CL_NF,
            this.CNPJ_CL_NF,
            this.BAIRRO_CL_NF,
            this.CIDADE_CL_NF,
            this.ESTADO_CL_NF,
            this.PAIS_CL_NF,
            this.CEP_CL_NF,
            this.FONE_CL_NF,
            this.EMAIL_CL_NF,
            this.VALOR_SIMPLES_NF,
            this.ALIQUOTA_SIMPLES_NF,
            this.N_PROTOCOLO_AUTORIZACAO_NF,
            this.COD_BARRAS_NF,
            this.NFE_TESTE,
            this.NAO_TRIBUTADA_NF,
            this.PECAS_NF,
            this.TERMINAL_NF,
            this.IPI_SUSPENSO_NF,
            this.SUBST_TRIB_NF,
            this.ARRUELA_NF,
            this.dataColumn1});
            this.NOTA_FISCAL.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_SISTEMA_NF"}, true)});
            this.NOTA_FISCAL.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_SISTEMA_NF};
            this.NOTA_FISCAL.TableName = "NOTA_FISCAL";
            // 
            // COD_SISTEMA_NF
            // 
            this.COD_SISTEMA_NF.AllowDBNull = false;
            this.COD_SISTEMA_NF.ColumnName = "COD_SISTEMA_NF";
            this.COD_SISTEMA_NF.DataType = typeof(int);
            // 
            // N_NF
            // 
            this.N_NF.ColumnName = "N_NF";
            this.N_NF.DataType = typeof(int);
            // 
            // ENTRADA_NF
            // 
            this.ENTRADA_NF.ColumnName = "ENTRADA_NF";
            this.ENTRADA_NF.DataType = typeof(int);
            // 
            // SAIDA_NF
            // 
            this.SAIDA_NF.ColumnName = "SAIDA_NF";
            this.SAIDA_NF.DataType = typeof(int);
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
            // INF_COMPL_NF
            // 
            this.INF_COMPL_NF.ColumnName = "INF_COMPL_NF";
            this.INF_COMPL_NF.MaxLength = 450;
            // 
            // TIPO_MVTO_NF
            // 
            this.TIPO_MVTO_NF.ColumnName = "TIPO_MVTO_NF";
            this.TIPO_MVTO_NF.MaxLength = 50;
            // 
            // OBS_NF
            // 
            this.OBS_NF.ColumnName = "OBS_NF";
            this.OBS_NF.MaxLength = 50;
            // 
            // VALOR_EXTENSO_NF
            // 
            this.VALOR_EXTENSO_NF.ColumnName = "VALOR_EXTENSO_NF";
            this.VALOR_EXTENSO_NF.MaxLength = 100;
            // 
            // TRIBUTADA_NF
            // 
            this.TRIBUTADA_NF.ColumnName = "TRIBUTADA_NF";
            this.TRIBUTADA_NF.DataType = typeof(int);
            // 
            // COBRANCA_NF
            // 
            this.COBRANCA_NF.ColumnName = "COBRANCA_NF";
            this.COBRANCA_NF.DataType = typeof(int);
            // 
            // EXPORTACAO_NF
            // 
            this.EXPORTACAO_NF.ColumnName = "EXPORTACAO_NF";
            this.EXPORTACAO_NF.DataType = typeof(int);
            // 
            // UF_EMBARQUE_EXPORTACAO
            // 
            this.UF_EMBARQUE_EXPORTACAO.ColumnName = "UF_EMBARQUE_EXPORTACAO";
            this.UF_EMBARQUE_EXPORTACAO.MaxLength = 2;
            // 
            // LOCAL_EMBARQUE_EXPORTACAO
            // 
            this.LOCAL_EMBARQUE_EXPORTACAO.ColumnName = "LOCAL_EMBARQUE_EXPORTACAO";
            this.LOCAL_EMBARQUE_EXPORTACAO.MaxLength = 60;
            // 
            // BENEFICIAMENTO_NF
            // 
            this.BENEFICIAMENTO_NF.ColumnName = "BENEFICIAMENTO_NF";
            this.BENEFICIAMENTO_NF.DataType = typeof(int);
            // 
            // STATUS_NFE
            // 
            this.STATUS_NFE.ColumnName = "STATUS_NFE";
            this.STATUS_NFE.MaxLength = 200;
            // 
            // CHAVE_ACESSO_NFE
            // 
            this.CHAVE_ACESSO_NFE.ColumnName = "CHAVE_ACESSO_NFE";
            this.CHAVE_ACESSO_NFE.MaxLength = 100;
            // 
            // VALOR_TOTAL_SERVICOS_NF
            // 
            this.VALOR_TOTAL_SERVICOS_NF.ColumnName = "VALOR_TOTAL_SERVICOS_NF";
            this.VALOR_TOTAL_SERVICOS_NF.DataType = typeof(double);
            // 
            // BASE_CALCULO_ISS_NF
            // 
            this.BASE_CALCULO_ISS_NF.ColumnName = "BASE_CALCULO_ISS_NF";
            this.BASE_CALCULO_ISS_NF.DataType = typeof(double);
            // 
            // VALOR_ISS_NF
            // 
            this.VALOR_ISS_NF.ColumnName = "VALOR_ISS_NF";
            this.VALOR_ISS_NF.DataType = typeof(double);
            // 
            // RECIBO_NFE
            // 
            this.RECIBO_NFE.ColumnName = "RECIBO_NFE";
            this.RECIBO_NFE.MaxLength = 100;
            // 
            // ENTRADA_SAIDA_NF
            // 
            this.ENTRADA_SAIDA_NF.ColumnName = "ENTRADA_SAIDA_NF";
            this.ENTRADA_SAIDA_NF.DataType = typeof(int);
            // 
            // NATUREZA_OPERACAO_NF
            // 
            this.NATUREZA_OPERACAO_NF.ColumnName = "NATUREZA_OPERACAO_NF";
            this.NATUREZA_OPERACAO_NF.MaxLength = 200;
            // 
            // CNPJ_CLIENTE_FORN
            // 
            this.CNPJ_CLIENTE_FORN.ColumnName = "CNPJ_CLIENTE_FORN";
            this.CNPJ_CLIENTE_FORN.MaxLength = 30;
            // 
            // NOTA_STRING_NF
            // 
            this.NOTA_STRING_NF.ColumnName = "NOTA_STRING_NF";
            this.NOTA_STRING_NF.MaxLength = 9;
            // 
            // END_NUMERO_STRING_NF
            // 
            this.END_NUMERO_STRING_NF.ColumnName = "END_NUMERO_STRING_NF";
            this.END_NUMERO_STRING_NF.MaxLength = 250;
            // 
            // RAZAO_SOCIAL_CL_NF
            // 
            this.RAZAO_SOCIAL_CL_NF.ColumnName = "RAZAO_SOCIAL_CL_NF";
            this.RAZAO_SOCIAL_CL_NF.MaxLength = 70;
            // 
            // IE_CL_NF
            // 
            this.IE_CL_NF.ColumnName = "IE_CL_NF";
            this.IE_CL_NF.MaxLength = 70;
            // 
            // CNPJ_CL_NF
            // 
            this.CNPJ_CL_NF.ColumnName = "CNPJ_CL_NF";
            this.CNPJ_CL_NF.MaxLength = 70;
            // 
            // BAIRRO_CL_NF
            // 
            this.BAIRRO_CL_NF.ColumnName = "BAIRRO_CL_NF";
            this.BAIRRO_CL_NF.MaxLength = 70;
            // 
            // CIDADE_CL_NF
            // 
            this.CIDADE_CL_NF.ColumnName = "CIDADE_CL_NF";
            this.CIDADE_CL_NF.MaxLength = 70;
            // 
            // ESTADO_CL_NF
            // 
            this.ESTADO_CL_NF.ColumnName = "ESTADO_CL_NF";
            this.ESTADO_CL_NF.MaxLength = 70;
            // 
            // PAIS_CL_NF
            // 
            this.PAIS_CL_NF.ColumnName = "PAIS_CL_NF";
            this.PAIS_CL_NF.MaxLength = 70;
            // 
            // CEP_CL_NF
            // 
            this.CEP_CL_NF.ColumnName = "CEP_CL_NF";
            this.CEP_CL_NF.MaxLength = 70;
            // 
            // FONE_CL_NF
            // 
            this.FONE_CL_NF.ColumnName = "FONE_CL_NF";
            this.FONE_CL_NF.MaxLength = 70;
            // 
            // EMAIL_CL_NF
            // 
            this.EMAIL_CL_NF.ColumnName = "EMAIL_CL_NF";
            this.EMAIL_CL_NF.MaxLength = 70;
            // 
            // VALOR_SIMPLES_NF
            // 
            this.VALOR_SIMPLES_NF.ColumnName = "VALOR_SIMPLES_NF";
            this.VALOR_SIMPLES_NF.DataType = typeof(double);
            // 
            // ALIQUOTA_SIMPLES_NF
            // 
            this.ALIQUOTA_SIMPLES_NF.ColumnName = "ALIQUOTA_SIMPLES_NF";
            this.ALIQUOTA_SIMPLES_NF.DataType = typeof(double);
            // 
            // N_PROTOCOLO_AUTORIZACAO_NF
            // 
            this.N_PROTOCOLO_AUTORIZACAO_NF.ColumnName = "N_PROTOCOLO_AUTORIZACAO_NF";
            this.N_PROTOCOLO_AUTORIZACAO_NF.MaxLength = 200;
            // 
            // COD_BARRAS_NF
            // 
            this.COD_BARRAS_NF.ColumnName = "COD_BARRAS_NF";
            this.COD_BARRAS_NF.DataType = typeof(byte[]);
            // 
            // NFE_TESTE
            // 
            this.NFE_TESTE.ColumnName = "NFE_TESTE";
            this.NFE_TESTE.DataType = typeof(int);
            // 
            // NAO_TRIBUTADA_NF
            // 
            this.NAO_TRIBUTADA_NF.ColumnName = "NAO_TRIBUTADA_NF";
            this.NAO_TRIBUTADA_NF.DataType = typeof(int);
            // 
            // PECAS_NF
            // 
            this.PECAS_NF.ColumnName = "PECAS_NF";
            this.PECAS_NF.DataType = typeof(int);
            // 
            // TERMINAL_NF
            // 
            this.TERMINAL_NF.ColumnName = "TERMINAL_NF";
            this.TERMINAL_NF.DataType = typeof(int);
            // 
            // IPI_SUSPENSO_NF
            // 
            this.IPI_SUSPENSO_NF.ColumnName = "IPI_SUSPENSO_NF";
            this.IPI_SUSPENSO_NF.DataType = typeof(int);
            // 
            // SUBST_TRIB_NF
            // 
            this.SUBST_TRIB_NF.ColumnName = "SUBST_TRIB_NF";
            this.SUBST_TRIB_NF.DataType = typeof(int);
            // 
            // ARRUELA_NF
            // 
            this.ARRUELA_NF.ColumnName = "ARRUELA_NF";
            this.ARRUELA_NF.DataType = typeof(int);
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "VENDEDOR_PED_VENDA";
            // 
            // dgvNota_fiscal
            // 
            this.dgvNota_fiscal.AllowUserToAddRows = false;
            this.dgvNota_fiscal.AutoGenerateColumns = false;
            this.dgvNota_fiscal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNota_fiscal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dATAEMISSAONFDataGridViewTextBoxColumn,
            this.col_n_nf,
            this.cLIENTEFORNNFDataGridViewTextBoxColumn,
            this.col_valor_total,
            this.VENDEDOR_PED_VENDA,
            this.cODSISTEMANFDataGridViewTextBoxColumn,
            this.eNTRADANFDataGridViewTextBoxColumn,
            this.sAIDANFDataGridViewTextBoxColumn,
            this.fORMAPGTONFDataGridViewTextBoxColumn,
            this.dATAENTRSAINFDataGridViewTextBoxColumn,
            this.dATAVENCIMENTONFDataGridViewTextBoxColumn,
            this.nATUREZAOPERACAONFDataGridViewTextBoxColumn,
            this.cFONFDataGridViewTextBoxColumn,
            this.cFO2NFDataGridViewTextBoxColumn,
            this.col_cnpj,
            this.eNDERECOENTREGANFDataGridViewTextBoxColumn,
            this.bASECALCICMSNFDataGridViewTextBoxColumn,
            this.vALORTOTPRODNFDataGridViewTextBoxColumn,
            this.col_obs,
            this.iNFCOMPLNFDataGridViewTextBoxColumn,
            this.vALORICMSNFDataGridViewTextBoxColumn,
            this.bASECALCICMSUBSDataGridViewTextBoxColumn,
            this.vALORICMSUBSDataGridViewTextBoxColumn,
            this.vALORFRETENFDataGridViewTextBoxColumn,
            this.vALORSEGURONFDataGridViewTextBoxColumn,
            this.oUTRASDESPNFDataGridViewTextBoxColumn,
            this.col_ipi,
            this.tRANSPORTADORANFDataGridViewTextBoxColumn,
            this.fRETECONTANFDataGridViewTextBoxColumn,
            this.pLACAVEICULONFDataGridViewTextBoxColumn,
            this.eSTADOVEICULONFDataGridViewTextBoxColumn,
            this.qTDENFDataGridViewTextBoxColumn,
            this.eSPECIENFDataGridViewTextBoxColumn,
            this.mARCANFDataGridViewTextBoxColumn,
            this.pESOBRUTONFDataGridViewTextBoxColumn,
            this.pESOLIQUIDONFDataGridViewTextBoxColumn,
            this.tIPOMVTONFDataGridViewTextBoxColumn,
            this.vALOREXTENSONFDataGridViewTextBoxColumn,
            this.tRIBUTADANFDataGridViewTextBoxColumn,
            this.cOBRANCANFDataGridViewTextBoxColumn,
            this.eXPORTACAONFDataGridViewTextBoxColumn,
            this.uFEMBARQUEEXPORTACAODataGridViewTextBoxColumn,
            this.lOCALEMBARQUEEXPORTACAODataGridViewTextBoxColumn,
            this.bENEFICIAMENTONFDataGridViewTextBoxColumn,
            this.col_status,
            this.cHAVEACESSONFEDataGridViewTextBoxColumn,
            this.vALORTOTALSERVICOSNFDataGridViewTextBoxColumn,
            this.bASECALCULOISSNFDataGridViewTextBoxColumn,
            this.vALORISSNFDataGridViewTextBoxColumn,
            this.rECIBONFEDataGridViewTextBoxColumn,
            this.eNTRADASAIDANFDataGridViewTextBoxColumn,
            this.nOTASTRINGNFDataGridViewTextBoxColumn,
            this.eNDNUMEROSTRINGNFDataGridViewTextBoxColumn,
            this.rAZAOSOCIALCLNFDataGridViewTextBoxColumn,
            this.iECLNFDataGridViewTextBoxColumn,
            this.cNPJCLNFDataGridViewTextBoxColumn,
            this.bAIRROCLNFDataGridViewTextBoxColumn,
            this.cIDADECLNFDataGridViewTextBoxColumn,
            this.eSTADOCLNFDataGridViewTextBoxColumn,
            this.pAISCLNFDataGridViewTextBoxColumn,
            this.cEPCLNFDataGridViewTextBoxColumn,
            this.fONECLNFDataGridViewTextBoxColumn,
            this.eMAILCLNFDataGridViewTextBoxColumn,
            this.vALORSIMPLESNFDataGridViewTextBoxColumn,
            this.aLIQUOTASIMPLESNFDataGridViewTextBoxColumn,
            this.nPROTOCOLOAUTORIZACAONFDataGridViewTextBoxColumn,
            this.cODBARRASNFDataGridViewImageColumn,
            this.nFETESTEDataGridViewTextBoxColumn,
            this.nAOTRIBUTADANFDataGridViewTextBoxColumn,
            this.pECASNFDataGridViewTextBoxColumn,
            this.tERMINALNFDataGridViewTextBoxColumn,
            this.iPISUSPENSONFDataGridViewTextBoxColumn,
            this.sUBSTTRIBNFDataGridViewTextBoxColumn,
            this.aRRUELANFDataGridViewTextBoxColumn});
            this.dgvNota_fiscal.DataMember = "NOTA_FISCAL";
            this.dgvNota_fiscal.DataSource = this.dsNota_fiscal;
            this.dgvNota_fiscal.Location = new System.Drawing.Point(14, 141);
            this.dgvNota_fiscal.Name = "dgvNota_fiscal";
            this.dgvNota_fiscal.Size = new System.Drawing.Size(858, 430);
            this.dgvNota_fiscal.TabIndex = 14;
            this.dgvNota_fiscal.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNota_fiscal_CellDoubleClick);
            this.dgvNota_fiscal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNota_fiscal_CellContentClick);
            // 
            // dATAEMISSAONFDataGridViewTextBoxColumn
            // 
            this.dATAEMISSAONFDataGridViewTextBoxColumn.DataPropertyName = "DATA_EMISSAO_NF";
            this.dATAEMISSAONFDataGridViewTextBoxColumn.HeaderText = "Data Emissão";
            this.dATAEMISSAONFDataGridViewTextBoxColumn.Name = "dATAEMISSAONFDataGridViewTextBoxColumn";
            // 
            // col_n_nf
            // 
            this.col_n_nf.DataPropertyName = "N_NF";
            this.col_n_nf.HeaderText = "Número da NF";
            this.col_n_nf.Name = "col_n_nf";
            // 
            // cLIENTEFORNNFDataGridViewTextBoxColumn
            // 
            this.cLIENTEFORNNFDataGridViewTextBoxColumn.DataPropertyName = "CLIENTE_FORN_NF";
            this.cLIENTEFORNNFDataGridViewTextBoxColumn.HeaderText = "Nome Cliente";
            this.cLIENTEFORNNFDataGridViewTextBoxColumn.Name = "cLIENTEFORNNFDataGridViewTextBoxColumn";
            // 
            // col_valor_total
            // 
            this.col_valor_total.DataPropertyName = "VALOR_NOTA_NF";
            this.col_valor_total.HeaderText = "Valor Nota";
            this.col_valor_total.Name = "col_valor_total";
            // 
            // VENDEDOR_PED_VENDA
            // 
            this.VENDEDOR_PED_VENDA.DataPropertyName = "VENDEDOR_PED_VENDA";
            this.VENDEDOR_PED_VENDA.HeaderText = "Vendedor";
            this.VENDEDOR_PED_VENDA.Name = "VENDEDOR_PED_VENDA";
            // 
            // cODSISTEMANFDataGridViewTextBoxColumn
            // 
            this.cODSISTEMANFDataGridViewTextBoxColumn.DataPropertyName = "COD_SISTEMA_NF";
            this.cODSISTEMANFDataGridViewTextBoxColumn.HeaderText = "COD_SISTEMA_NF";
            this.cODSISTEMANFDataGridViewTextBoxColumn.Name = "cODSISTEMANFDataGridViewTextBoxColumn";
            this.cODSISTEMANFDataGridViewTextBoxColumn.Visible = false;
            // 
            // eNTRADANFDataGridViewTextBoxColumn
            // 
            this.eNTRADANFDataGridViewTextBoxColumn.DataPropertyName = "ENTRADA_NF";
            this.eNTRADANFDataGridViewTextBoxColumn.HeaderText = "ENTRADA_NF";
            this.eNTRADANFDataGridViewTextBoxColumn.Name = "eNTRADANFDataGridViewTextBoxColumn";
            this.eNTRADANFDataGridViewTextBoxColumn.Visible = false;
            // 
            // sAIDANFDataGridViewTextBoxColumn
            // 
            this.sAIDANFDataGridViewTextBoxColumn.DataPropertyName = "SAIDA_NF";
            this.sAIDANFDataGridViewTextBoxColumn.HeaderText = "SAIDA_NF";
            this.sAIDANFDataGridViewTextBoxColumn.Name = "sAIDANFDataGridViewTextBoxColumn";
            this.sAIDANFDataGridViewTextBoxColumn.Visible = false;
            // 
            // fORMAPGTONFDataGridViewTextBoxColumn
            // 
            this.fORMAPGTONFDataGridViewTextBoxColumn.DataPropertyName = "FORMA_PGTO_NF";
            this.fORMAPGTONFDataGridViewTextBoxColumn.HeaderText = "FORMA_PGTO_NF";
            this.fORMAPGTONFDataGridViewTextBoxColumn.Name = "fORMAPGTONFDataGridViewTextBoxColumn";
            this.fORMAPGTONFDataGridViewTextBoxColumn.Visible = false;
            // 
            // dATAENTRSAINFDataGridViewTextBoxColumn
            // 
            this.dATAENTRSAINFDataGridViewTextBoxColumn.DataPropertyName = "DATA_ENTR_SAI_NF";
            this.dATAENTRSAINFDataGridViewTextBoxColumn.HeaderText = "Data Entrada/Saída";
            this.dATAENTRSAINFDataGridViewTextBoxColumn.Name = "dATAENTRSAINFDataGridViewTextBoxColumn";
            this.dATAENTRSAINFDataGridViewTextBoxColumn.Visible = false;
            // 
            // dATAVENCIMENTONFDataGridViewTextBoxColumn
            // 
            this.dATAVENCIMENTONFDataGridViewTextBoxColumn.DataPropertyName = "DATA_VENCIMENTO_NF";
            this.dATAVENCIMENTONFDataGridViewTextBoxColumn.HeaderText = "DATA_VENCIMENTO_NF";
            this.dATAVENCIMENTONFDataGridViewTextBoxColumn.Name = "dATAVENCIMENTONFDataGridViewTextBoxColumn";
            this.dATAVENCIMENTONFDataGridViewTextBoxColumn.Visible = false;
            // 
            // nATUREZAOPERACAONFDataGridViewTextBoxColumn
            // 
            this.nATUREZAOPERACAONFDataGridViewTextBoxColumn.DataPropertyName = "NATUREZA_OPERACAO_NF";
            this.nATUREZAOPERACAONFDataGridViewTextBoxColumn.HeaderText = "Natureza Operação";
            this.nATUREZAOPERACAONFDataGridViewTextBoxColumn.Name = "nATUREZAOPERACAONFDataGridViewTextBoxColumn";
            // 
            // cFONFDataGridViewTextBoxColumn
            // 
            this.cFONFDataGridViewTextBoxColumn.DataPropertyName = "CFO_NF";
            this.cFONFDataGridViewTextBoxColumn.HeaderText = "CFOP";
            this.cFONFDataGridViewTextBoxColumn.Name = "cFONFDataGridViewTextBoxColumn";
            this.cFONFDataGridViewTextBoxColumn.Visible = false;
            // 
            // cFO2NFDataGridViewTextBoxColumn
            // 
            this.cFO2NFDataGridViewTextBoxColumn.DataPropertyName = "CFO_2_NF";
            this.cFO2NFDataGridViewTextBoxColumn.HeaderText = "CFO_2_NF";
            this.cFO2NFDataGridViewTextBoxColumn.Name = "cFO2NFDataGridViewTextBoxColumn";
            this.cFO2NFDataGridViewTextBoxColumn.Visible = false;
            // 
            // col_cnpj
            // 
            this.col_cnpj.DataPropertyName = "CNPJ_CLIENTE_FORN";
            this.col_cnpj.HeaderText = "CNPJ Cliente";
            this.col_cnpj.Name = "col_cnpj";
            // 
            // eNDERECOENTREGANFDataGridViewTextBoxColumn
            // 
            this.eNDERECOENTREGANFDataGridViewTextBoxColumn.DataPropertyName = "ENDERECO_ENTREGA_NF";
            this.eNDERECOENTREGANFDataGridViewTextBoxColumn.HeaderText = "ENDERECO_ENTREGA_NF";
            this.eNDERECOENTREGANFDataGridViewTextBoxColumn.Name = "eNDERECOENTREGANFDataGridViewTextBoxColumn";
            this.eNDERECOENTREGANFDataGridViewTextBoxColumn.Visible = false;
            // 
            // bASECALCICMSNFDataGridViewTextBoxColumn
            // 
            this.bASECALCICMSNFDataGridViewTextBoxColumn.DataPropertyName = "BASE_CALC_ICMS_NF";
            this.bASECALCICMSNFDataGridViewTextBoxColumn.HeaderText = "BASE_CALC_ICMS_NF";
            this.bASECALCICMSNFDataGridViewTextBoxColumn.Name = "bASECALCICMSNFDataGridViewTextBoxColumn";
            this.bASECALCICMSNFDataGridViewTextBoxColumn.Visible = false;
            // 
            // vALORTOTPRODNFDataGridViewTextBoxColumn
            // 
            this.vALORTOTPRODNFDataGridViewTextBoxColumn.DataPropertyName = "VALOR_TOT_PROD_NF";
            this.vALORTOTPRODNFDataGridViewTextBoxColumn.HeaderText = "Valor Produtos";
            this.vALORTOTPRODNFDataGridViewTextBoxColumn.Name = "vALORTOTPRODNFDataGridViewTextBoxColumn";
            // 
            // col_obs
            // 
            this.col_obs.DataPropertyName = "OBS_NF";
            this.col_obs.HeaderText = "Obs";
            this.col_obs.Name = "col_obs";
            this.col_obs.Visible = false;
            // 
            // iNFCOMPLNFDataGridViewTextBoxColumn
            // 
            this.iNFCOMPLNFDataGridViewTextBoxColumn.DataPropertyName = "INF_COMPL_NF";
            this.iNFCOMPLNFDataGridViewTextBoxColumn.HeaderText = "Inf Adicionais";
            this.iNFCOMPLNFDataGridViewTextBoxColumn.Name = "iNFCOMPLNFDataGridViewTextBoxColumn";
            // 
            // vALORICMSNFDataGridViewTextBoxColumn
            // 
            this.vALORICMSNFDataGridViewTextBoxColumn.DataPropertyName = "VALOR_ICMS_NF";
            this.vALORICMSNFDataGridViewTextBoxColumn.HeaderText = "ICMS";
            this.vALORICMSNFDataGridViewTextBoxColumn.Name = "vALORICMSNFDataGridViewTextBoxColumn";
            // 
            // bASECALCICMSUBSDataGridViewTextBoxColumn
            // 
            this.bASECALCICMSUBSDataGridViewTextBoxColumn.DataPropertyName = "BASE_CALC_ICM_SUBS";
            this.bASECALCICMSUBSDataGridViewTextBoxColumn.HeaderText = "BASE_CALC_ICM_SUBS";
            this.bASECALCICMSUBSDataGridViewTextBoxColumn.Name = "bASECALCICMSUBSDataGridViewTextBoxColumn";
            this.bASECALCICMSUBSDataGridViewTextBoxColumn.Visible = false;
            // 
            // vALORICMSUBSDataGridViewTextBoxColumn
            // 
            this.vALORICMSUBSDataGridViewTextBoxColumn.DataPropertyName = "VALOR_ICM_SUBS";
            this.vALORICMSUBSDataGridViewTextBoxColumn.HeaderText = "ST";
            this.vALORICMSUBSDataGridViewTextBoxColumn.Name = "vALORICMSUBSDataGridViewTextBoxColumn";
            // 
            // vALORFRETENFDataGridViewTextBoxColumn
            // 
            this.vALORFRETENFDataGridViewTextBoxColumn.DataPropertyName = "VALOR_FRETE_NF";
            this.vALORFRETENFDataGridViewTextBoxColumn.HeaderText = "VALOR_FRETE_NF";
            this.vALORFRETENFDataGridViewTextBoxColumn.Name = "vALORFRETENFDataGridViewTextBoxColumn";
            this.vALORFRETENFDataGridViewTextBoxColumn.Visible = false;
            // 
            // vALORSEGURONFDataGridViewTextBoxColumn
            // 
            this.vALORSEGURONFDataGridViewTextBoxColumn.DataPropertyName = "VALOR_SEGURO_NF";
            this.vALORSEGURONFDataGridViewTextBoxColumn.HeaderText = "VALOR_SEGURO_NF";
            this.vALORSEGURONFDataGridViewTextBoxColumn.Name = "vALORSEGURONFDataGridViewTextBoxColumn";
            this.vALORSEGURONFDataGridViewTextBoxColumn.Visible = false;
            // 
            // oUTRASDESPNFDataGridViewTextBoxColumn
            // 
            this.oUTRASDESPNFDataGridViewTextBoxColumn.DataPropertyName = "OUTRAS_DESP_NF";
            this.oUTRASDESPNFDataGridViewTextBoxColumn.HeaderText = "OUTRAS_DESP_NF";
            this.oUTRASDESPNFDataGridViewTextBoxColumn.Name = "oUTRASDESPNFDataGridViewTextBoxColumn";
            this.oUTRASDESPNFDataGridViewTextBoxColumn.Visible = false;
            // 
            // col_ipi
            // 
            this.col_ipi.DataPropertyName = "VALOR_IPI_NF";
            this.col_ipi.HeaderText = "IPI";
            this.col_ipi.Name = "col_ipi";
            // 
            // tRANSPORTADORANFDataGridViewTextBoxColumn
            // 
            this.tRANSPORTADORANFDataGridViewTextBoxColumn.DataPropertyName = "TRANSPORTADORA_NF";
            this.tRANSPORTADORANFDataGridViewTextBoxColumn.HeaderText = "Transportadora";
            this.tRANSPORTADORANFDataGridViewTextBoxColumn.Name = "tRANSPORTADORANFDataGridViewTextBoxColumn";
            // 
            // fRETECONTANFDataGridViewTextBoxColumn
            // 
            this.fRETECONTANFDataGridViewTextBoxColumn.DataPropertyName = "FRETE_CONTA_NF";
            this.fRETECONTANFDataGridViewTextBoxColumn.HeaderText = "FRETE_CONTA_NF";
            this.fRETECONTANFDataGridViewTextBoxColumn.Name = "fRETECONTANFDataGridViewTextBoxColumn";
            this.fRETECONTANFDataGridViewTextBoxColumn.Visible = false;
            // 
            // pLACAVEICULONFDataGridViewTextBoxColumn
            // 
            this.pLACAVEICULONFDataGridViewTextBoxColumn.DataPropertyName = "PLACA_VEICULO_NF";
            this.pLACAVEICULONFDataGridViewTextBoxColumn.HeaderText = "PLACA_VEICULO_NF";
            this.pLACAVEICULONFDataGridViewTextBoxColumn.Name = "pLACAVEICULONFDataGridViewTextBoxColumn";
            this.pLACAVEICULONFDataGridViewTextBoxColumn.Visible = false;
            // 
            // eSTADOVEICULONFDataGridViewTextBoxColumn
            // 
            this.eSTADOVEICULONFDataGridViewTextBoxColumn.DataPropertyName = "ESTADO_VEICULO_NF";
            this.eSTADOVEICULONFDataGridViewTextBoxColumn.HeaderText = "ESTADO_VEICULO_NF";
            this.eSTADOVEICULONFDataGridViewTextBoxColumn.Name = "eSTADOVEICULONFDataGridViewTextBoxColumn";
            this.eSTADOVEICULONFDataGridViewTextBoxColumn.Visible = false;
            // 
            // qTDENFDataGridViewTextBoxColumn
            // 
            this.qTDENFDataGridViewTextBoxColumn.DataPropertyName = "QTDE_NF";
            this.qTDENFDataGridViewTextBoxColumn.HeaderText = "QTDE_NF";
            this.qTDENFDataGridViewTextBoxColumn.Name = "qTDENFDataGridViewTextBoxColumn";
            this.qTDENFDataGridViewTextBoxColumn.Visible = false;
            // 
            // eSPECIENFDataGridViewTextBoxColumn
            // 
            this.eSPECIENFDataGridViewTextBoxColumn.DataPropertyName = "ESPECIE_NF";
            this.eSPECIENFDataGridViewTextBoxColumn.HeaderText = "ESPECIE_NF";
            this.eSPECIENFDataGridViewTextBoxColumn.Name = "eSPECIENFDataGridViewTextBoxColumn";
            this.eSPECIENFDataGridViewTextBoxColumn.Visible = false;
            // 
            // mARCANFDataGridViewTextBoxColumn
            // 
            this.mARCANFDataGridViewTextBoxColumn.DataPropertyName = "MARCA_NF";
            this.mARCANFDataGridViewTextBoxColumn.HeaderText = "MARCA_NF";
            this.mARCANFDataGridViewTextBoxColumn.Name = "mARCANFDataGridViewTextBoxColumn";
            this.mARCANFDataGridViewTextBoxColumn.Visible = false;
            // 
            // pESOBRUTONFDataGridViewTextBoxColumn
            // 
            this.pESOBRUTONFDataGridViewTextBoxColumn.DataPropertyName = "PESO_BRUTO_NF";
            this.pESOBRUTONFDataGridViewTextBoxColumn.HeaderText = "PESO_BRUTO_NF";
            this.pESOBRUTONFDataGridViewTextBoxColumn.Name = "pESOBRUTONFDataGridViewTextBoxColumn";
            this.pESOBRUTONFDataGridViewTextBoxColumn.Visible = false;
            // 
            // pESOLIQUIDONFDataGridViewTextBoxColumn
            // 
            this.pESOLIQUIDONFDataGridViewTextBoxColumn.DataPropertyName = "PESO_LIQUIDO_NF";
            this.pESOLIQUIDONFDataGridViewTextBoxColumn.HeaderText = "PESO_LIQUIDO_NF";
            this.pESOLIQUIDONFDataGridViewTextBoxColumn.Name = "pESOLIQUIDONFDataGridViewTextBoxColumn";
            this.pESOLIQUIDONFDataGridViewTextBoxColumn.Visible = false;
            // 
            // tIPOMVTONFDataGridViewTextBoxColumn
            // 
            this.tIPOMVTONFDataGridViewTextBoxColumn.DataPropertyName = "TIPO_MVTO_NF";
            this.tIPOMVTONFDataGridViewTextBoxColumn.HeaderText = "TIPO_MVTO_NF";
            this.tIPOMVTONFDataGridViewTextBoxColumn.Name = "tIPOMVTONFDataGridViewTextBoxColumn";
            this.tIPOMVTONFDataGridViewTextBoxColumn.Visible = false;
            // 
            // vALOREXTENSONFDataGridViewTextBoxColumn
            // 
            this.vALOREXTENSONFDataGridViewTextBoxColumn.DataPropertyName = "VALOR_EXTENSO_NF";
            this.vALOREXTENSONFDataGridViewTextBoxColumn.HeaderText = "VALOR_EXTENSO_NF";
            this.vALOREXTENSONFDataGridViewTextBoxColumn.Name = "vALOREXTENSONFDataGridViewTextBoxColumn";
            this.vALOREXTENSONFDataGridViewTextBoxColumn.Visible = false;
            // 
            // tRIBUTADANFDataGridViewTextBoxColumn
            // 
            this.tRIBUTADANFDataGridViewTextBoxColumn.DataPropertyName = "TRIBUTADA_NF";
            this.tRIBUTADANFDataGridViewTextBoxColumn.HeaderText = "TRIBUTADA_NF";
            this.tRIBUTADANFDataGridViewTextBoxColumn.Name = "tRIBUTADANFDataGridViewTextBoxColumn";
            this.tRIBUTADANFDataGridViewTextBoxColumn.Visible = false;
            // 
            // cOBRANCANFDataGridViewTextBoxColumn
            // 
            this.cOBRANCANFDataGridViewTextBoxColumn.DataPropertyName = "COBRANCA_NF";
            this.cOBRANCANFDataGridViewTextBoxColumn.HeaderText = "COBRANCA_NF";
            this.cOBRANCANFDataGridViewTextBoxColumn.Name = "cOBRANCANFDataGridViewTextBoxColumn";
            this.cOBRANCANFDataGridViewTextBoxColumn.Visible = false;
            // 
            // eXPORTACAONFDataGridViewTextBoxColumn
            // 
            this.eXPORTACAONFDataGridViewTextBoxColumn.DataPropertyName = "EXPORTACAO_NF";
            this.eXPORTACAONFDataGridViewTextBoxColumn.HeaderText = "EXPORTACAO_NF";
            this.eXPORTACAONFDataGridViewTextBoxColumn.Name = "eXPORTACAONFDataGridViewTextBoxColumn";
            this.eXPORTACAONFDataGridViewTextBoxColumn.Visible = false;
            // 
            // uFEMBARQUEEXPORTACAODataGridViewTextBoxColumn
            // 
            this.uFEMBARQUEEXPORTACAODataGridViewTextBoxColumn.DataPropertyName = "UF_EMBARQUE_EXPORTACAO";
            this.uFEMBARQUEEXPORTACAODataGridViewTextBoxColumn.HeaderText = "UF_EMBARQUE_EXPORTACAO";
            this.uFEMBARQUEEXPORTACAODataGridViewTextBoxColumn.Name = "uFEMBARQUEEXPORTACAODataGridViewTextBoxColumn";
            this.uFEMBARQUEEXPORTACAODataGridViewTextBoxColumn.Visible = false;
            // 
            // lOCALEMBARQUEEXPORTACAODataGridViewTextBoxColumn
            // 
            this.lOCALEMBARQUEEXPORTACAODataGridViewTextBoxColumn.DataPropertyName = "LOCAL_EMBARQUE_EXPORTACAO";
            this.lOCALEMBARQUEEXPORTACAODataGridViewTextBoxColumn.HeaderText = "LOCAL_EMBARQUE_EXPORTACAO";
            this.lOCALEMBARQUEEXPORTACAODataGridViewTextBoxColumn.Name = "lOCALEMBARQUEEXPORTACAODataGridViewTextBoxColumn";
            this.lOCALEMBARQUEEXPORTACAODataGridViewTextBoxColumn.Visible = false;
            // 
            // bENEFICIAMENTONFDataGridViewTextBoxColumn
            // 
            this.bENEFICIAMENTONFDataGridViewTextBoxColumn.DataPropertyName = "BENEFICIAMENTO_NF";
            this.bENEFICIAMENTONFDataGridViewTextBoxColumn.HeaderText = "BENEFICIAMENTO_NF";
            this.bENEFICIAMENTONFDataGridViewTextBoxColumn.Name = "bENEFICIAMENTONFDataGridViewTextBoxColumn";
            this.bENEFICIAMENTONFDataGridViewTextBoxColumn.Visible = false;
            // 
            // col_status
            // 
            this.col_status.DataPropertyName = "STATUS_NFE";
            this.col_status.HeaderText = "Status";
            this.col_status.Name = "col_status";
            // 
            // cHAVEACESSONFEDataGridViewTextBoxColumn
            // 
            this.cHAVEACESSONFEDataGridViewTextBoxColumn.DataPropertyName = "CHAVE_ACESSO_NFE";
            this.cHAVEACESSONFEDataGridViewTextBoxColumn.HeaderText = "Chave Acesso";
            this.cHAVEACESSONFEDataGridViewTextBoxColumn.Name = "cHAVEACESSONFEDataGridViewTextBoxColumn";
            // 
            // vALORTOTALSERVICOSNFDataGridViewTextBoxColumn
            // 
            this.vALORTOTALSERVICOSNFDataGridViewTextBoxColumn.DataPropertyName = "VALOR_TOTAL_SERVICOS_NF";
            this.vALORTOTALSERVICOSNFDataGridViewTextBoxColumn.HeaderText = "VALOR_TOTAL_SERVICOS_NF";
            this.vALORTOTALSERVICOSNFDataGridViewTextBoxColumn.Name = "vALORTOTALSERVICOSNFDataGridViewTextBoxColumn";
            this.vALORTOTALSERVICOSNFDataGridViewTextBoxColumn.Visible = false;
            // 
            // bASECALCULOISSNFDataGridViewTextBoxColumn
            // 
            this.bASECALCULOISSNFDataGridViewTextBoxColumn.DataPropertyName = "BASE_CALCULO_ISS_NF";
            this.bASECALCULOISSNFDataGridViewTextBoxColumn.HeaderText = "BASE_CALCULO_ISS_NF";
            this.bASECALCULOISSNFDataGridViewTextBoxColumn.Name = "bASECALCULOISSNFDataGridViewTextBoxColumn";
            this.bASECALCULOISSNFDataGridViewTextBoxColumn.Visible = false;
            // 
            // vALORISSNFDataGridViewTextBoxColumn
            // 
            this.vALORISSNFDataGridViewTextBoxColumn.DataPropertyName = "VALOR_ISS_NF";
            this.vALORISSNFDataGridViewTextBoxColumn.HeaderText = "VALOR_ISS_NF";
            this.vALORISSNFDataGridViewTextBoxColumn.Name = "vALORISSNFDataGridViewTextBoxColumn";
            this.vALORISSNFDataGridViewTextBoxColumn.Visible = false;
            // 
            // rECIBONFEDataGridViewTextBoxColumn
            // 
            this.rECIBONFEDataGridViewTextBoxColumn.DataPropertyName = "RECIBO_NFE";
            this.rECIBONFEDataGridViewTextBoxColumn.HeaderText = "Recibo";
            this.rECIBONFEDataGridViewTextBoxColumn.Name = "rECIBONFEDataGridViewTextBoxColumn";
            // 
            // eNTRADASAIDANFDataGridViewTextBoxColumn
            // 
            this.eNTRADASAIDANFDataGridViewTextBoxColumn.DataPropertyName = "ENTRADA_SAIDA_NF";
            this.eNTRADASAIDANFDataGridViewTextBoxColumn.HeaderText = "ENTRADA_SAIDA_NF";
            this.eNTRADASAIDANFDataGridViewTextBoxColumn.Name = "eNTRADASAIDANFDataGridViewTextBoxColumn";
            this.eNTRADASAIDANFDataGridViewTextBoxColumn.Visible = false;
            // 
            // nOTASTRINGNFDataGridViewTextBoxColumn
            // 
            this.nOTASTRINGNFDataGridViewTextBoxColumn.DataPropertyName = "NOTA_STRING_NF";
            this.nOTASTRINGNFDataGridViewTextBoxColumn.HeaderText = "NOTA_STRING_NF";
            this.nOTASTRINGNFDataGridViewTextBoxColumn.Name = "nOTASTRINGNFDataGridViewTextBoxColumn";
            this.nOTASTRINGNFDataGridViewTextBoxColumn.Visible = false;
            // 
            // eNDNUMEROSTRINGNFDataGridViewTextBoxColumn
            // 
            this.eNDNUMEROSTRINGNFDataGridViewTextBoxColumn.DataPropertyName = "END_NUMERO_STRING_NF";
            this.eNDNUMEROSTRINGNFDataGridViewTextBoxColumn.HeaderText = "END_NUMERO_STRING_NF";
            this.eNDNUMEROSTRINGNFDataGridViewTextBoxColumn.Name = "eNDNUMEROSTRINGNFDataGridViewTextBoxColumn";
            this.eNDNUMEROSTRINGNFDataGridViewTextBoxColumn.Visible = false;
            // 
            // rAZAOSOCIALCLNFDataGridViewTextBoxColumn
            // 
            this.rAZAOSOCIALCLNFDataGridViewTextBoxColumn.DataPropertyName = "RAZAO_SOCIAL_CL_NF";
            this.rAZAOSOCIALCLNFDataGridViewTextBoxColumn.HeaderText = "RAZAO_SOCIAL_CL_NF";
            this.rAZAOSOCIALCLNFDataGridViewTextBoxColumn.Name = "rAZAOSOCIALCLNFDataGridViewTextBoxColumn";
            this.rAZAOSOCIALCLNFDataGridViewTextBoxColumn.Visible = false;
            // 
            // iECLNFDataGridViewTextBoxColumn
            // 
            this.iECLNFDataGridViewTextBoxColumn.DataPropertyName = "IE_CL_NF";
            this.iECLNFDataGridViewTextBoxColumn.HeaderText = "IE_CL_NF";
            this.iECLNFDataGridViewTextBoxColumn.Name = "iECLNFDataGridViewTextBoxColumn";
            this.iECLNFDataGridViewTextBoxColumn.Visible = false;
            // 
            // cNPJCLNFDataGridViewTextBoxColumn
            // 
            this.cNPJCLNFDataGridViewTextBoxColumn.DataPropertyName = "CNPJ_CL_NF";
            this.cNPJCLNFDataGridViewTextBoxColumn.HeaderText = "CNPJ_CL_NF";
            this.cNPJCLNFDataGridViewTextBoxColumn.Name = "cNPJCLNFDataGridViewTextBoxColumn";
            this.cNPJCLNFDataGridViewTextBoxColumn.Visible = false;
            // 
            // bAIRROCLNFDataGridViewTextBoxColumn
            // 
            this.bAIRROCLNFDataGridViewTextBoxColumn.DataPropertyName = "BAIRRO_CL_NF";
            this.bAIRROCLNFDataGridViewTextBoxColumn.HeaderText = "BAIRRO_CL_NF";
            this.bAIRROCLNFDataGridViewTextBoxColumn.Name = "bAIRROCLNFDataGridViewTextBoxColumn";
            this.bAIRROCLNFDataGridViewTextBoxColumn.Visible = false;
            // 
            // cIDADECLNFDataGridViewTextBoxColumn
            // 
            this.cIDADECLNFDataGridViewTextBoxColumn.DataPropertyName = "CIDADE_CL_NF";
            this.cIDADECLNFDataGridViewTextBoxColumn.HeaderText = "CIDADE_CL_NF";
            this.cIDADECLNFDataGridViewTextBoxColumn.Name = "cIDADECLNFDataGridViewTextBoxColumn";
            this.cIDADECLNFDataGridViewTextBoxColumn.Visible = false;
            // 
            // eSTADOCLNFDataGridViewTextBoxColumn
            // 
            this.eSTADOCLNFDataGridViewTextBoxColumn.DataPropertyName = "ESTADO_CL_NF";
            this.eSTADOCLNFDataGridViewTextBoxColumn.HeaderText = "ESTADO_CL_NF";
            this.eSTADOCLNFDataGridViewTextBoxColumn.Name = "eSTADOCLNFDataGridViewTextBoxColumn";
            this.eSTADOCLNFDataGridViewTextBoxColumn.Visible = false;
            // 
            // pAISCLNFDataGridViewTextBoxColumn
            // 
            this.pAISCLNFDataGridViewTextBoxColumn.DataPropertyName = "PAIS_CL_NF";
            this.pAISCLNFDataGridViewTextBoxColumn.HeaderText = "PAIS_CL_NF";
            this.pAISCLNFDataGridViewTextBoxColumn.Name = "pAISCLNFDataGridViewTextBoxColumn";
            this.pAISCLNFDataGridViewTextBoxColumn.Visible = false;
            // 
            // cEPCLNFDataGridViewTextBoxColumn
            // 
            this.cEPCLNFDataGridViewTextBoxColumn.DataPropertyName = "CEP_CL_NF";
            this.cEPCLNFDataGridViewTextBoxColumn.HeaderText = "CEP_CL_NF";
            this.cEPCLNFDataGridViewTextBoxColumn.Name = "cEPCLNFDataGridViewTextBoxColumn";
            this.cEPCLNFDataGridViewTextBoxColumn.Visible = false;
            // 
            // fONECLNFDataGridViewTextBoxColumn
            // 
            this.fONECLNFDataGridViewTextBoxColumn.DataPropertyName = "FONE_CL_NF";
            this.fONECLNFDataGridViewTextBoxColumn.HeaderText = "FONE_CL_NF";
            this.fONECLNFDataGridViewTextBoxColumn.Name = "fONECLNFDataGridViewTextBoxColumn";
            this.fONECLNFDataGridViewTextBoxColumn.Visible = false;
            // 
            // eMAILCLNFDataGridViewTextBoxColumn
            // 
            this.eMAILCLNFDataGridViewTextBoxColumn.DataPropertyName = "EMAIL_CL_NF";
            this.eMAILCLNFDataGridViewTextBoxColumn.HeaderText = "EMAIL_CL_NF";
            this.eMAILCLNFDataGridViewTextBoxColumn.Name = "eMAILCLNFDataGridViewTextBoxColumn";
            this.eMAILCLNFDataGridViewTextBoxColumn.Visible = false;
            // 
            // vALORSIMPLESNFDataGridViewTextBoxColumn
            // 
            this.vALORSIMPLESNFDataGridViewTextBoxColumn.DataPropertyName = "VALOR_SIMPLES_NF";
            this.vALORSIMPLESNFDataGridViewTextBoxColumn.HeaderText = "VALOR_SIMPLES_NF";
            this.vALORSIMPLESNFDataGridViewTextBoxColumn.Name = "vALORSIMPLESNFDataGridViewTextBoxColumn";
            this.vALORSIMPLESNFDataGridViewTextBoxColumn.Visible = false;
            // 
            // aLIQUOTASIMPLESNFDataGridViewTextBoxColumn
            // 
            this.aLIQUOTASIMPLESNFDataGridViewTextBoxColumn.DataPropertyName = "ALIQUOTA_SIMPLES_NF";
            this.aLIQUOTASIMPLESNFDataGridViewTextBoxColumn.HeaderText = "ALIQUOTA_SIMPLES_NF";
            this.aLIQUOTASIMPLESNFDataGridViewTextBoxColumn.Name = "aLIQUOTASIMPLESNFDataGridViewTextBoxColumn";
            this.aLIQUOTASIMPLESNFDataGridViewTextBoxColumn.Visible = false;
            // 
            // nPROTOCOLOAUTORIZACAONFDataGridViewTextBoxColumn
            // 
            this.nPROTOCOLOAUTORIZACAONFDataGridViewTextBoxColumn.DataPropertyName = "N_PROTOCOLO_AUTORIZACAO_NF";
            this.nPROTOCOLOAUTORIZACAONFDataGridViewTextBoxColumn.HeaderText = "Protocolo Autorização";
            this.nPROTOCOLOAUTORIZACAONFDataGridViewTextBoxColumn.Name = "nPROTOCOLOAUTORIZACAONFDataGridViewTextBoxColumn";
            // 
            // cODBARRASNFDataGridViewImageColumn
            // 
            this.cODBARRASNFDataGridViewImageColumn.DataPropertyName = "COD_BARRAS_NF";
            this.cODBARRASNFDataGridViewImageColumn.HeaderText = "COD_BARRAS_NF";
            this.cODBARRASNFDataGridViewImageColumn.Name = "cODBARRASNFDataGridViewImageColumn";
            this.cODBARRASNFDataGridViewImageColumn.Visible = false;
            // 
            // nFETESTEDataGridViewTextBoxColumn
            // 
            this.nFETESTEDataGridViewTextBoxColumn.DataPropertyName = "NFE_TESTE";
            this.nFETESTEDataGridViewTextBoxColumn.HeaderText = "NFE_TESTE";
            this.nFETESTEDataGridViewTextBoxColumn.Name = "nFETESTEDataGridViewTextBoxColumn";
            this.nFETESTEDataGridViewTextBoxColumn.Visible = false;
            // 
            // nAOTRIBUTADANFDataGridViewTextBoxColumn
            // 
            this.nAOTRIBUTADANFDataGridViewTextBoxColumn.DataPropertyName = "NAO_TRIBUTADA_NF";
            this.nAOTRIBUTADANFDataGridViewTextBoxColumn.HeaderText = "Não Tributada";
            this.nAOTRIBUTADANFDataGridViewTextBoxColumn.Name = "nAOTRIBUTADANFDataGridViewTextBoxColumn";
            this.nAOTRIBUTADANFDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nAOTRIBUTADANFDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.nAOTRIBUTADANFDataGridViewTextBoxColumn.TrueValue = "1";
            // 
            // pECASNFDataGridViewTextBoxColumn
            // 
            this.pECASNFDataGridViewTextBoxColumn.DataPropertyName = "PECAS_NF";
            this.pECASNFDataGridViewTextBoxColumn.HeaderText = "Peças";
            this.pECASNFDataGridViewTextBoxColumn.Name = "pECASNFDataGridViewTextBoxColumn";
            this.pECASNFDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pECASNFDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // tERMINALNFDataGridViewTextBoxColumn
            // 
            this.tERMINALNFDataGridViewTextBoxColumn.DataPropertyName = "TERMINAL_NF";
            this.tERMINALNFDataGridViewTextBoxColumn.HeaderText = "Terminal";
            this.tERMINALNFDataGridViewTextBoxColumn.Name = "tERMINALNFDataGridViewTextBoxColumn";
            this.tERMINALNFDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tERMINALNFDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // iPISUSPENSONFDataGridViewTextBoxColumn
            // 
            this.iPISUSPENSONFDataGridViewTextBoxColumn.DataPropertyName = "IPI_SUSPENSO_NF";
            this.iPISUSPENSONFDataGridViewTextBoxColumn.HeaderText = "IPI_SUSPENSO_NF";
            this.iPISUSPENSONFDataGridViewTextBoxColumn.Name = "iPISUSPENSONFDataGridViewTextBoxColumn";
            this.iPISUSPENSONFDataGridViewTextBoxColumn.Visible = false;
            // 
            // sUBSTTRIBNFDataGridViewTextBoxColumn
            // 
            this.sUBSTTRIBNFDataGridViewTextBoxColumn.DataPropertyName = "SUBST_TRIB_NF";
            this.sUBSTTRIBNFDataGridViewTextBoxColumn.HeaderText = "SUBST_TRIB_NF";
            this.sUBSTTRIBNFDataGridViewTextBoxColumn.Name = "sUBSTTRIBNFDataGridViewTextBoxColumn";
            this.sUBSTTRIBNFDataGridViewTextBoxColumn.Visible = false;
            // 
            // aRRUELANFDataGridViewTextBoxColumn
            // 
            this.aRRUELANFDataGridViewTextBoxColumn.DataPropertyName = "ARRUELA_NF";
            this.aRRUELANFDataGridViewTextBoxColumn.HeaderText = "ARRUELA_NF";
            this.aRRUELANFDataGridViewTextBoxColumn.Name = "aRRUELANFDataGridViewTextBoxColumn";
            this.aRRUELANFDataGridViewTextBoxColumn.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(278, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 64);
            this.button2.TabIndex = 15;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tb_cliente_2
            // 
            this.tb_cliente_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cliente_2.Location = new System.Drawing.Point(222, 21);
            this.tb_cliente_2.Name = "tb_cliente_2";
            this.tb_cliente_2.Size = new System.Drawing.Size(100, 23);
            this.tb_cliente_2.TabIndex = 105;
            this.tb_cliente_2.TextChanged += new System.EventHandler(this.tb_cliente_2_TextChanged);
            // 
            // tb_n_nf
            // 
            this.tb_n_nf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_n_nf.Location = new System.Drawing.Point(8, 21);
            this.tb_n_nf.Name = "tb_n_nf";
            this.tb_n_nf.Size = new System.Drawing.Size(101, 23);
            this.tb_n_nf.TabIndex = 106;
            this.tb_n_nf.TextChanged += new System.EventHandler(this.tb_n_nf_TextChanged);
            // 
            // tb_soma
            // 
            this.tb_soma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_soma.Location = new System.Drawing.Point(302, 577);
            this.tb_soma.Name = "tb_soma";
            this.tb_soma.Size = new System.Drawing.Size(248, 31);
            this.tb_soma.TabIndex = 108;
            // 
            // cb_faturamento
            // 
            this.cb_faturamento.AutoSize = true;
            this.cb_faturamento.Location = new System.Drawing.Point(187, 51);
            this.cb_faturamento.Name = "cb_faturamento";
            this.cb_faturamento.Size = new System.Drawing.Size(85, 17);
            this.cb_faturamento.TabIndex = 109;
            this.cb_faturamento.Text = "Faturamento";
            this.cb_faturamento.UseVisualStyleBackColor = true;
            this.cb_faturamento.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 580);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 25);
            this.label3.TabIndex = 110;
            this.label3.Text = "VALOR TOTAL COM IPI:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 618);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(265, 25);
            this.label4.TabIndex = 112;
            this.label4.Text = "VALOR TOTAL SEM IPI:";
            // 
            // tb_soma_sem_ipi
            // 
            this.tb_soma_sem_ipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_soma_sem_ipi.Location = new System.Drawing.Point(302, 615);
            this.tb_soma_sem_ipi.Name = "tb_soma_sem_ipi";
            this.tb_soma_sem_ipi.Size = new System.Drawing.Size(248, 31);
            this.tb_soma_sem_ipi.TabIndex = 111;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(115, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(101, 23);
            this.textBox1.TabIndex = 113;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(369, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 64);
            this.button1.TabIndex = 114;
            this.button1.Text = "Baixar Estoque";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_cnpj
            // 
            this.tb_cnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cnpj.Location = new System.Drawing.Point(328, 21);
            this.tb_cnpj.Name = "tb_cnpj";
            this.tb_cnpj.Size = new System.Drawing.Size(100, 23);
            this.tb_cnpj.TabIndex = 115;
            this.tb_cnpj.TextChanged += new System.EventHandler(this.tb_cnpj_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.txtVendedor);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tb_cnpj);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.tb_n_nf);
            this.panel1.Controls.Add(this.tb_cliente_2);
            this.panel1.Location = new System.Drawing.Point(14, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(858, 54);
            this.panel1.TabIndex = 116;
            // 
            // txtVendedor
            // 
            this.txtVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVendedor.Location = new System.Drawing.Point(434, 21);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.Size = new System.Drawing.Size(100, 23);
            this.txtVendedor.TabIndex = 121;
            this.txtVendedor.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(434, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 120;
            this.label9.Text = "Vendedor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(325, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 119;
            this.label8.Text = "CNPJ Forn.:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(219, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 118;
            this.label7.Text = "Cliente:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(112, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 117;
            this.label6.Text = "Natureza de Op.:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 116;
            this.label5.Text = "NF:";
            // 
            // form_pesquisa_nf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 658);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_soma_sem_ipi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_faturamento);
            this.Controls.Add(this.tb_soma);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvNota_fiscal);
            this.Controls.Add(this.groupBox2);
            this.Name = "form_pesquisa_nf";
            this.Text = "Pesquisa NF";
            this.Load += new System.EventHandler(this.form_pesquisa_nf_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsNota_fiscal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NOTA_FISCAL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNota_fiscal)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtTermino;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datNota_fiscal;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private System.Data.DataSet dsNota_fiscal;
        private System.Data.DataTable NOTA_FISCAL;
        private System.Data.DataColumn COD_SISTEMA_NF;
        private System.Data.DataColumn N_NF;
        private System.Data.DataColumn ENTRADA_NF;
        private System.Data.DataColumn SAIDA_NF;
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
        private System.Data.DataColumn INF_COMPL_NF;
        private System.Data.DataColumn TIPO_MVTO_NF;
        private System.Data.DataColumn OBS_NF;
        private System.Data.DataColumn VALOR_EXTENSO_NF;
        private System.Data.DataColumn TRIBUTADA_NF;
        private System.Data.DataColumn COBRANCA_NF;
        private System.Data.DataColumn EXPORTACAO_NF;
        private System.Data.DataColumn UF_EMBARQUE_EXPORTACAO;
        private System.Data.DataColumn LOCAL_EMBARQUE_EXPORTACAO;
        private System.Data.DataColumn BENEFICIAMENTO_NF;
        private System.Data.DataColumn STATUS_NFE;
        private System.Data.DataColumn CHAVE_ACESSO_NFE;
        private System.Data.DataColumn VALOR_TOTAL_SERVICOS_NF;
        private System.Data.DataColumn BASE_CALCULO_ISS_NF;
        private System.Data.DataColumn VALOR_ISS_NF;
        private System.Data.DataColumn RECIBO_NFE;
        private System.Data.DataColumn ENTRADA_SAIDA_NF;
        private System.Data.DataColumn NATUREZA_OPERACAO_NF;
        private System.Data.DataColumn CNPJ_CLIENTE_FORN;
        private System.Data.DataColumn NOTA_STRING_NF;
        private System.Data.DataColumn END_NUMERO_STRING_NF;
        private System.Data.DataColumn RAZAO_SOCIAL_CL_NF;
        private System.Data.DataColumn IE_CL_NF;
        private System.Data.DataColumn CNPJ_CL_NF;
        private System.Data.DataColumn BAIRRO_CL_NF;
        private System.Data.DataColumn CIDADE_CL_NF;
        private System.Data.DataColumn ESTADO_CL_NF;
        private System.Data.DataColumn PAIS_CL_NF;
        private System.Data.DataColumn CEP_CL_NF;
        private System.Data.DataColumn FONE_CL_NF;
        private System.Data.DataColumn EMAIL_CL_NF;
        private System.Data.DataColumn VALOR_SIMPLES_NF;
        private System.Data.DataColumn ALIQUOTA_SIMPLES_NF;
        private System.Data.DataColumn N_PROTOCOLO_AUTORIZACAO_NF;
        private System.Data.DataColumn COD_BARRAS_NF;
        private System.Data.DataColumn NFE_TESTE;
        private System.Data.DataColumn NAO_TRIBUTADA_NF;
        private System.Data.DataColumn PECAS_NF;
        private System.Data.DataColumn TERMINAL_NF;
        private System.Data.DataColumn IPI_SUSPENSO_NF;
        private System.Data.DataColumn SUBST_TRIB_NF;
        private System.Data.DataColumn ARRUELA_NF;
        private System.Windows.Forms.DataGridView dgvNota_fiscal;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tb_cliente_2;
        private System.Windows.Forms.TextBox tb_n_nf;
        private System.Windows.Forms.TextBox tb_soma;
        private System.Windows.Forms.CheckBox cb_faturamento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_soma_sem_ipi;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_cnpj;
        private System.Windows.Forms.Panel panel1;
        private System.Data.DataColumn dataColumn1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAEMISSAONFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_n_nf;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTEFORNNFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_valor_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn VENDEDOR_PED_VENDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODSISTEMANFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNTRADANFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sAIDANFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fORMAPGTONFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAENTRSAINFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAVENCIMENTONFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nATUREZAOPERACAONFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFONFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFO2NFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNDERECOENTREGANFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bASECALCICMSNFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORTOTPRODNFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_obs;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNFCOMPLNFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORICMSNFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bASECALCICMSUBSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORICMSUBSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORFRETENFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORSEGURONFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oUTRASDESPNFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ipi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRANSPORTADORANFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fRETECONTANFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLACAVEICULONFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTADOVEICULONFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qTDENFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSPECIENFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mARCANFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pESOBRUTONFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pESOLIQUIDONFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIPOMVTONFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALOREXTENSONFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRIBUTADANFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOBRANCANFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXPORTACAONFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uFEMBARQUEEXPORTACAODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOCALEMBARQUEEXPORTACAODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bENEFICIAMENTONFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHAVEACESSONFEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORTOTALSERVICOSNFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bASECALCULOISSNFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORISSNFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rECIBONFEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNTRADASAIDANFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOTASTRINGNFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNDNUMEROSTRINGNFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAZAOSOCIALCLNFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iECLNFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPJCLNFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bAIRROCLNFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDADECLNFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTADOCLNFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAISCLNFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEPCLNFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fONECLNFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILCLNFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORSIMPLESNFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aLIQUOTASIMPLESNFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nPROTOCOLOAUTORIZACAONFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn cODBARRASNFDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nFETESTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn nAOTRIBUTADANFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pECASNFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn tERMINALNFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iPISUSPENSONFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUBSTTRIBNFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aRRUELANFDataGridViewTextBoxColumn;
    }
}