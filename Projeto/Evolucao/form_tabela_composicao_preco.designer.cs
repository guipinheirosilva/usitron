namespace Evolucao
{
    partial class form_tabela_composicao_preco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_tabela_composicao_preco));
            this.datTabela_composicao_preco = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsTabela_composicao_preco = new System.Data.DataSet();
            this.TABELA_COMPOSICAO_PRECO = new System.Data.DataTable();
            this.COD_TCP = new System.Data.DataColumn();
            this.CNPJ_CLIENTE_TCP = new System.Data.DataColumn();
            this.NOME_CLIENTE_TCP = new System.Data.DataColumn();
            this.SEGURO_TCP = new System.Data.DataColumn();
            this.COLETA_TCP = new System.Data.DataColumn();
            this.PEDAGIO_TCP = new System.Data.DataColumn();
            this.M3_TCP = new System.Data.DataColumn();
            this.PORC_ALIQ_TCP = new System.Data.DataColumn();
            this.ALIQ_IMP_TCP = new System.Data.DataColumn();
            this.PORC_BASE_TCP = new System.Data.DataColumn();
            this.ACIMA_KGS_BP_TCP = new System.Data.DataColumn();
            this.VALOR_ACIMA_KG_BP_TCP = new System.Data.DataColumn();
            this.CAT_BP_TCP = new System.Data.DataColumn();
            this.DESP_BP_TCP = new System.Data.DataColumn();
            this.ACIMA_KGS_SP_TCP = new System.Data.DataColumn();
            this.VALOR_ACIMA_KG_SP_TCP = new System.Data.DataColumn();
            this.CAT_SP_TCP = new System.Data.DataColumn();
            this.DESP_SP_TCP = new System.Data.DataColumn();
            this.PESO_INICIAL_TCP = new System.Data.DataColumn();
            this.PESO_FINAL_TCP = new System.Data.DataColumn();
            this.VALOR_PESO_TCP = new System.Data.DataColumn();
            this.PORC_OUTRAS_TAXAS_TCP = new System.Data.DataColumn();
            this.DESCRIC_PORC_OUTRAS_TAXAS_TCP = new System.Data.DataColumn();
            this.VALOR_OUTRAS_TAXAS_TCP = new System.Data.DataColumn();
            this.DESCRIC_VALOR_OUTRAS_TAXAS_TCP = new System.Data.DataColumn();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.cbTabela_composicao_preco = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.dgvTabela_composicao_preco = new System.Windows.Forms.DataGridView();
            this.cODTCPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNPJCLIENTETCPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMECLIENTETCPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEGUROTCPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOLETATCPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pEDAGIOTCPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m3TCPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cATBPTCPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESPBPTCPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pESOINICIALTCPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pESOFINALTCPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORPESOTCPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MINIMO_TCP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FRETE_TCP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pORCOUTRASTAXASTCPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRICPORCOUTRASTAXASTCPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALOROUTRASTAXASTCPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRICVALOROUTRASTAXASTCPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_tipo = new System.Windows.Forms.TextBox();
            this.label_cliente = new System.Windows.Forms.Label();
            this.tb_cliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_cnpj = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsTabela_composicao_preco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TABELA_COMPOSICAO_PRECO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabela_composicao_preco)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // datTabela_composicao_preco
            // 
            this.datTabela_composicao_preco.DeleteCommand = this.fbCommand4;
            this.datTabela_composicao_preco.InsertCommand = this.fbCommand2;
            this.datTabela_composicao_preco.SelectCommand = this.fbCommand1;
            this.datTabela_composicao_preco.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * from tabela_composicao_preco";
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
            // dsTabela_composicao_preco
            // 
            this.dsTabela_composicao_preco.DataSetName = "dsTabela_composicao_preco";
            this.dsTabela_composicao_preco.Namespace = "http://www.tempuri.org/dsTabela_composicao_preco.xsd";
            this.dsTabela_composicao_preco.Tables.AddRange(new System.Data.DataTable[] {
            this.TABELA_COMPOSICAO_PRECO});
            // 
            // TABELA_COMPOSICAO_PRECO
            // 
            this.TABELA_COMPOSICAO_PRECO.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_TCP,
            this.CNPJ_CLIENTE_TCP,
            this.NOME_CLIENTE_TCP,
            this.SEGURO_TCP,
            this.COLETA_TCP,
            this.PEDAGIO_TCP,
            this.M3_TCP,
            this.PORC_ALIQ_TCP,
            this.ALIQ_IMP_TCP,
            this.PORC_BASE_TCP,
            this.ACIMA_KGS_BP_TCP,
            this.VALOR_ACIMA_KG_BP_TCP,
            this.CAT_BP_TCP,
            this.DESP_BP_TCP,
            this.ACIMA_KGS_SP_TCP,
            this.VALOR_ACIMA_KG_SP_TCP,
            this.CAT_SP_TCP,
            this.DESP_SP_TCP,
            this.PESO_INICIAL_TCP,
            this.PESO_FINAL_TCP,
            this.VALOR_PESO_TCP,
            this.PORC_OUTRAS_TAXAS_TCP,
            this.DESCRIC_PORC_OUTRAS_TAXAS_TCP,
            this.VALOR_OUTRAS_TAXAS_TCP,
            this.DESCRIC_VALOR_OUTRAS_TAXAS_TCP,
            this.dataColumn1,
            this.dataColumn2});
            this.TABELA_COMPOSICAO_PRECO.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_TCP"}, true)});
            this.TABELA_COMPOSICAO_PRECO.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_TCP};
            this.TABELA_COMPOSICAO_PRECO.TableName = "TABELA_COMPOSICAO_PRECO";
            // 
            // COD_TCP
            // 
            this.COD_TCP.AllowDBNull = false;
            this.COD_TCP.AutoIncrement = true;
            this.COD_TCP.AutoIncrementSeed = ((long)(1));
            this.COD_TCP.ColumnName = "COD_TCP";
            this.COD_TCP.DataType = typeof(int);
            // 
            // CNPJ_CLIENTE_TCP
            // 
            this.CNPJ_CLIENTE_TCP.ColumnName = "CNPJ_CLIENTE_TCP";
            this.CNPJ_CLIENTE_TCP.MaxLength = 100;
            // 
            // NOME_CLIENTE_TCP
            // 
            this.NOME_CLIENTE_TCP.ColumnName = "NOME_CLIENTE_TCP";
            this.NOME_CLIENTE_TCP.MaxLength = 200;
            // 
            // SEGURO_TCP
            // 
            this.SEGURO_TCP.ColumnName = "SEGURO_TCP";
            this.SEGURO_TCP.DataType = typeof(double);
            // 
            // COLETA_TCP
            // 
            this.COLETA_TCP.ColumnName = "COLETA_TCP";
            this.COLETA_TCP.DataType = typeof(double);
            // 
            // PEDAGIO_TCP
            // 
            this.PEDAGIO_TCP.ColumnName = "PEDAGIO_TCP";
            this.PEDAGIO_TCP.DataType = typeof(double);
            // 
            // M3_TCP
            // 
            this.M3_TCP.ColumnName = "M3_TCP";
            this.M3_TCP.DataType = typeof(double);
            // 
            // PORC_ALIQ_TCP
            // 
            this.PORC_ALIQ_TCP.ColumnName = "PORC_ALIQ_TCP";
            this.PORC_ALIQ_TCP.DataType = typeof(double);
            // 
            // ALIQ_IMP_TCP
            // 
            this.ALIQ_IMP_TCP.ColumnName = "ALIQ_IMP_TCP";
            this.ALIQ_IMP_TCP.DataType = typeof(double);
            // 
            // PORC_BASE_TCP
            // 
            this.PORC_BASE_TCP.ColumnName = "PORC_BASE_TCP";
            this.PORC_BASE_TCP.DataType = typeof(double);
            // 
            // ACIMA_KGS_BP_TCP
            // 
            this.ACIMA_KGS_BP_TCP.ColumnName = "ACIMA_KGS_BP_TCP";
            this.ACIMA_KGS_BP_TCP.DataType = typeof(double);
            // 
            // VALOR_ACIMA_KG_BP_TCP
            // 
            this.VALOR_ACIMA_KG_BP_TCP.ColumnName = "VALOR_ACIMA_KG_BP_TCP";
            this.VALOR_ACIMA_KG_BP_TCP.DataType = typeof(double);
            // 
            // CAT_BP_TCP
            // 
            this.CAT_BP_TCP.ColumnName = "CAT_BP_TCP";
            this.CAT_BP_TCP.DataType = typeof(double);
            // 
            // DESP_BP_TCP
            // 
            this.DESP_BP_TCP.ColumnName = "DESP_BP_TCP";
            this.DESP_BP_TCP.DataType = typeof(double);
            // 
            // ACIMA_KGS_SP_TCP
            // 
            this.ACIMA_KGS_SP_TCP.ColumnName = "ACIMA_KGS_SP_TCP";
            this.ACIMA_KGS_SP_TCP.DataType = typeof(double);
            // 
            // VALOR_ACIMA_KG_SP_TCP
            // 
            this.VALOR_ACIMA_KG_SP_TCP.ColumnName = "VALOR_ACIMA_KG_SP_TCP";
            this.VALOR_ACIMA_KG_SP_TCP.DataType = typeof(double);
            // 
            // CAT_SP_TCP
            // 
            this.CAT_SP_TCP.ColumnName = "CAT_SP_TCP";
            this.CAT_SP_TCP.DataType = typeof(double);
            // 
            // DESP_SP_TCP
            // 
            this.DESP_SP_TCP.ColumnName = "DESP_SP_TCP";
            this.DESP_SP_TCP.DataType = typeof(double);
            // 
            // PESO_INICIAL_TCP
            // 
            this.PESO_INICIAL_TCP.ColumnName = "PESO_INICIAL_TCP";
            this.PESO_INICIAL_TCP.DataType = typeof(double);
            // 
            // PESO_FINAL_TCP
            // 
            this.PESO_FINAL_TCP.ColumnName = "PESO_FINAL_TCP";
            this.PESO_FINAL_TCP.DataType = typeof(double);
            // 
            // VALOR_PESO_TCP
            // 
            this.VALOR_PESO_TCP.ColumnName = "VALOR_PESO_TCP";
            this.VALOR_PESO_TCP.DataType = typeof(double);
            // 
            // PORC_OUTRAS_TAXAS_TCP
            // 
            this.PORC_OUTRAS_TAXAS_TCP.ColumnName = "PORC_OUTRAS_TAXAS_TCP";
            this.PORC_OUTRAS_TAXAS_TCP.DataType = typeof(double);
            // 
            // DESCRIC_PORC_OUTRAS_TAXAS_TCP
            // 
            this.DESCRIC_PORC_OUTRAS_TAXAS_TCP.ColumnName = "DESCRIC_PORC_OUTRAS_TAXAS_TCP";
            this.DESCRIC_PORC_OUTRAS_TAXAS_TCP.MaxLength = 200;
            // 
            // VALOR_OUTRAS_TAXAS_TCP
            // 
            this.VALOR_OUTRAS_TAXAS_TCP.ColumnName = "VALOR_OUTRAS_TAXAS_TCP";
            this.VALOR_OUTRAS_TAXAS_TCP.DataType = typeof(double);
            // 
            // DESCRIC_VALOR_OUTRAS_TAXAS_TCP
            // 
            this.DESCRIC_VALOR_OUTRAS_TAXAS_TCP.ColumnName = "DESCRIC_VALOR_OUTRAS_TAXAS_TCP";
            this.DESCRIC_VALOR_OUTRAS_TAXAS_TCP.MaxLength = 200;
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "FRETE_TCP";
            this.dataColumn1.DataType = typeof(double);
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "MINIMO_TCP";
            this.dataColumn2.DataType = typeof(double);
            // 
            // cbTabela_composicao_preco
            // 
            this.cbTabela_composicao_preco.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbTabela_composicao_preco.DataAdapter = this.datTabela_composicao_preco;
            this.cbTabela_composicao_preco.QuotePrefix = "\"";
            this.cbTabela_composicao_preco.QuoteSuffix = "\"";
            // 
            // dgvTabela_composicao_preco
            // 
            this.dgvTabela_composicao_preco.AutoGenerateColumns = false;
            this.dgvTabela_composicao_preco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabela_composicao_preco.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODTCPDataGridViewTextBoxColumn,
            this.cNPJCLIENTETCPDataGridViewTextBoxColumn,
            this.nOMECLIENTETCPDataGridViewTextBoxColumn,
            this.sEGUROTCPDataGridViewTextBoxColumn,
            this.cOLETATCPDataGridViewTextBoxColumn,
            this.pEDAGIOTCPDataGridViewTextBoxColumn,
            this.m3TCPDataGridViewTextBoxColumn,
            this.cATBPTCPDataGridViewTextBoxColumn,
            this.dESPBPTCPDataGridViewTextBoxColumn,
            this.pESOINICIALTCPDataGridViewTextBoxColumn,
            this.pESOFINALTCPDataGridViewTextBoxColumn,
            this.vALORPESOTCPDataGridViewTextBoxColumn,
            this.MINIMO_TCP,
            this.FRETE_TCP,
            this.pORCOUTRASTAXASTCPDataGridViewTextBoxColumn,
            this.dESCRICPORCOUTRASTAXASTCPDataGridViewTextBoxColumn,
            this.vALOROUTRASTAXASTCPDataGridViewTextBoxColumn,
            this.dESCRICVALOROUTRASTAXASTCPDataGridViewTextBoxColumn});
            this.dgvTabela_composicao_preco.DataMember = "TABELA_COMPOSICAO_PRECO";
            this.dgvTabela_composicao_preco.DataSource = this.dsTabela_composicao_preco;
            this.dgvTabela_composicao_preco.Location = new System.Drawing.Point(12, 120);
            this.dgvTabela_composicao_preco.Name = "dgvTabela_composicao_preco";
            this.dgvTabela_composicao_preco.Size = new System.Drawing.Size(897, 463);
            this.dgvTabela_composicao_preco.TabIndex = 0;
            // 
            // cODTCPDataGridViewTextBoxColumn
            // 
            this.cODTCPDataGridViewTextBoxColumn.DataPropertyName = "COD_TCP";
            this.cODTCPDataGridViewTextBoxColumn.HeaderText = "COD_TCP";
            this.cODTCPDataGridViewTextBoxColumn.Name = "cODTCPDataGridViewTextBoxColumn";
            // 
            // cNPJCLIENTETCPDataGridViewTextBoxColumn
            // 
            this.cNPJCLIENTETCPDataGridViewTextBoxColumn.DataPropertyName = "CNPJ_CLIENTE_TCP";
            this.cNPJCLIENTETCPDataGridViewTextBoxColumn.HeaderText = "CNPJ_CLIENTE_TCP";
            this.cNPJCLIENTETCPDataGridViewTextBoxColumn.Name = "cNPJCLIENTETCPDataGridViewTextBoxColumn";
            // 
            // nOMECLIENTETCPDataGridViewTextBoxColumn
            // 
            this.nOMECLIENTETCPDataGridViewTextBoxColumn.DataPropertyName = "NOME_CLIENTE_TCP";
            this.nOMECLIENTETCPDataGridViewTextBoxColumn.HeaderText = "NOME_CLIENTE_TCP";
            this.nOMECLIENTETCPDataGridViewTextBoxColumn.Name = "nOMECLIENTETCPDataGridViewTextBoxColumn";
            // 
            // sEGUROTCPDataGridViewTextBoxColumn
            // 
            this.sEGUROTCPDataGridViewTextBoxColumn.DataPropertyName = "SEGURO_TCP";
            this.sEGUROTCPDataGridViewTextBoxColumn.HeaderText = "SEGURO_TCP";
            this.sEGUROTCPDataGridViewTextBoxColumn.Name = "sEGUROTCPDataGridViewTextBoxColumn";
            // 
            // cOLETATCPDataGridViewTextBoxColumn
            // 
            this.cOLETATCPDataGridViewTextBoxColumn.DataPropertyName = "COLETA_TCP";
            this.cOLETATCPDataGridViewTextBoxColumn.HeaderText = "COLETA_TCP";
            this.cOLETATCPDataGridViewTextBoxColumn.Name = "cOLETATCPDataGridViewTextBoxColumn";
            // 
            // pEDAGIOTCPDataGridViewTextBoxColumn
            // 
            this.pEDAGIOTCPDataGridViewTextBoxColumn.DataPropertyName = "PEDAGIO_TCP";
            this.pEDAGIOTCPDataGridViewTextBoxColumn.HeaderText = "PEDAGIO_TCP";
            this.pEDAGIOTCPDataGridViewTextBoxColumn.Name = "pEDAGIOTCPDataGridViewTextBoxColumn";
            // 
            // m3TCPDataGridViewTextBoxColumn
            // 
            this.m3TCPDataGridViewTextBoxColumn.DataPropertyName = "M3_TCP";
            this.m3TCPDataGridViewTextBoxColumn.HeaderText = "M3_TCP";
            this.m3TCPDataGridViewTextBoxColumn.Name = "m3TCPDataGridViewTextBoxColumn";
            // 
            // cATBPTCPDataGridViewTextBoxColumn
            // 
            this.cATBPTCPDataGridViewTextBoxColumn.DataPropertyName = "CAT_BP_TCP";
            this.cATBPTCPDataGridViewTextBoxColumn.HeaderText = "CAT_BP_TCP";
            this.cATBPTCPDataGridViewTextBoxColumn.Name = "cATBPTCPDataGridViewTextBoxColumn";
            // 
            // dESPBPTCPDataGridViewTextBoxColumn
            // 
            this.dESPBPTCPDataGridViewTextBoxColumn.DataPropertyName = "DESP_BP_TCP";
            this.dESPBPTCPDataGridViewTextBoxColumn.HeaderText = "DESP_BP_TCP";
            this.dESPBPTCPDataGridViewTextBoxColumn.Name = "dESPBPTCPDataGridViewTextBoxColumn";
            // 
            // pESOINICIALTCPDataGridViewTextBoxColumn
            // 
            this.pESOINICIALTCPDataGridViewTextBoxColumn.DataPropertyName = "PESO_INICIAL_TCP";
            this.pESOINICIALTCPDataGridViewTextBoxColumn.HeaderText = "PESO_INICIAL_TCP";
            this.pESOINICIALTCPDataGridViewTextBoxColumn.Name = "pESOINICIALTCPDataGridViewTextBoxColumn";
            // 
            // pESOFINALTCPDataGridViewTextBoxColumn
            // 
            this.pESOFINALTCPDataGridViewTextBoxColumn.DataPropertyName = "PESO_FINAL_TCP";
            this.pESOFINALTCPDataGridViewTextBoxColumn.HeaderText = "PESO_FINAL_TCP";
            this.pESOFINALTCPDataGridViewTextBoxColumn.Name = "pESOFINALTCPDataGridViewTextBoxColumn";
            // 
            // vALORPESOTCPDataGridViewTextBoxColumn
            // 
            this.vALORPESOTCPDataGridViewTextBoxColumn.DataPropertyName = "VALOR_PESO_TCP";
            this.vALORPESOTCPDataGridViewTextBoxColumn.HeaderText = "VALOR_PESO_TCP";
            this.vALORPESOTCPDataGridViewTextBoxColumn.Name = "vALORPESOTCPDataGridViewTextBoxColumn";
            // 
            // MINIMO_TCP
            // 
            this.MINIMO_TCP.DataPropertyName = "MINIMO_TCP";
            this.MINIMO_TCP.HeaderText = "MINIMO_TCP";
            this.MINIMO_TCP.Name = "MINIMO_TCP";
            // 
            // FRETE_TCP
            // 
            this.FRETE_TCP.DataPropertyName = "FRETE_TCP";
            this.FRETE_TCP.HeaderText = "FRETE_TCP";
            this.FRETE_TCP.Name = "FRETE_TCP";
            // 
            // pORCOUTRASTAXASTCPDataGridViewTextBoxColumn
            // 
            this.pORCOUTRASTAXASTCPDataGridViewTextBoxColumn.DataPropertyName = "PORC_OUTRAS_TAXAS_TCP";
            this.pORCOUTRASTAXASTCPDataGridViewTextBoxColumn.HeaderText = "PORC_OUTRAS_TAXAS_TCP";
            this.pORCOUTRASTAXASTCPDataGridViewTextBoxColumn.Name = "pORCOUTRASTAXASTCPDataGridViewTextBoxColumn";
            // 
            // dESCRICPORCOUTRASTAXASTCPDataGridViewTextBoxColumn
            // 
            this.dESCRICPORCOUTRASTAXASTCPDataGridViewTextBoxColumn.DataPropertyName = "DESCRIC_PORC_OUTRAS_TAXAS_TCP";
            this.dESCRICPORCOUTRASTAXASTCPDataGridViewTextBoxColumn.HeaderText = "DESCRIC_PORC_OUTRAS_TAXAS_TCP";
            this.dESCRICPORCOUTRASTAXASTCPDataGridViewTextBoxColumn.Name = "dESCRICPORCOUTRASTAXASTCPDataGridViewTextBoxColumn";
            // 
            // vALOROUTRASTAXASTCPDataGridViewTextBoxColumn
            // 
            this.vALOROUTRASTAXASTCPDataGridViewTextBoxColumn.DataPropertyName = "VALOR_OUTRAS_TAXAS_TCP";
            this.vALOROUTRASTAXASTCPDataGridViewTextBoxColumn.HeaderText = "VALOR_OUTRAS_TAXAS_TCP";
            this.vALOROUTRASTAXASTCPDataGridViewTextBoxColumn.Name = "vALOROUTRASTAXASTCPDataGridViewTextBoxColumn";
            // 
            // dESCRICVALOROUTRASTAXASTCPDataGridViewTextBoxColumn
            // 
            this.dESCRICVALOROUTRASTAXASTCPDataGridViewTextBoxColumn.DataPropertyName = "DESCRIC_VALOR_OUTRAS_TAXAS_TCP";
            this.dESCRICVALOROUTRASTAXASTCPDataGridViewTextBoxColumn.HeaderText = "DESCRIC_VALOR_OUTRAS_TAXAS_TCP";
            this.dESCRICVALOROUTRASTAXASTCPDataGridViewTextBoxColumn.Name = "dESCRICVALOROUTRASTAXASTCPDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(372, 589);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.tb_tipo);
            this.panel2.Controls.Add(this.label_cliente);
            this.panel2.Controls.Add(this.tb_cliente);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.tb_cnpj);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(897, 53);
            this.panel2.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(590, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tipo";
            // 
            // tb_tipo
            // 
            this.tb_tipo.Location = new System.Drawing.Point(629, 29);
            this.tb_tipo.Name = "tb_tipo";
            this.tb_tipo.Size = new System.Drawing.Size(100, 20);
            this.tb_tipo.TabIndex = 5;
            this.tb_tipo.TextChanged += new System.EventHandler(this.tb_tipo_TextChanged);
            // 
            // label_cliente
            // 
            this.label_cliente.AutoSize = true;
            this.label_cliente.Location = new System.Drawing.Point(209, 32);
            this.label_cliente.Name = "label_cliente";
            this.label_cliente.Size = new System.Drawing.Size(39, 13);
            this.label_cliente.TabIndex = 4;
            this.label_cliente.Text = "Cliente";
            // 
            // tb_cliente
            // 
            this.tb_cliente.Location = new System.Drawing.Point(263, 29);
            this.tb_cliente.Name = "tb_cliente";
            this.tb_cliente.Size = new System.Drawing.Size(300, 20);
            this.tb_cliente.TabIndex = 3;
            this.tb_cliente.TextChanged += new System.EventHandler(this.tb_cliente_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "CNPJ";
            // 
            // tb_cnpj
            // 
            this.tb_cnpj.Location = new System.Drawing.Point(61, 29);
            this.tb_cnpj.Name = "tb_cnpj";
            this.tb_cnpj.Size = new System.Drawing.Size(131, 20);
            this.tb_cnpj.TabIndex = 1;
            this.tb_cnpj.TextChanged += new System.EventHandler(this.tb_cnpj_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Filtros";
            // 
            // form_tabela_composicao_preco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 636);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvTabela_composicao_preco);
            this.Name = "form_tabela_composicao_preco";
            this.Text = "Tabela Composição Preço";
            this.Load += new System.EventHandler(this.form_tabela_composicao_preco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsTabela_composicao_preco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TABELA_COMPOSICAO_PRECO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabela_composicao_preco)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datTabela_composicao_preco;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Data.DataSet dsTabela_composicao_preco;
        private System.Data.DataTable TABELA_COMPOSICAO_PRECO;
        private System.Data.DataColumn COD_TCP;
        private System.Data.DataColumn CNPJ_CLIENTE_TCP;
        private System.Data.DataColumn NOME_CLIENTE_TCP;
        private System.Data.DataColumn SEGURO_TCP;
        private System.Data.DataColumn COLETA_TCP;
        private System.Data.DataColumn PEDAGIO_TCP;
        private System.Data.DataColumn M3_TCP;
        private System.Data.DataColumn PORC_ALIQ_TCP;
        private System.Data.DataColumn ALIQ_IMP_TCP;
        private System.Data.DataColumn PORC_BASE_TCP;
        private System.Data.DataColumn ACIMA_KGS_BP_TCP;
        private System.Data.DataColumn VALOR_ACIMA_KG_BP_TCP;
        private System.Data.DataColumn CAT_BP_TCP;
        private System.Data.DataColumn DESP_BP_TCP;
        private System.Data.DataColumn ACIMA_KGS_SP_TCP;
        private System.Data.DataColumn VALOR_ACIMA_KG_SP_TCP;
        private System.Data.DataColumn CAT_SP_TCP;
        private System.Data.DataColumn DESP_SP_TCP;
        private System.Data.DataColumn PESO_INICIAL_TCP;
        private System.Data.DataColumn PESO_FINAL_TCP;
        private System.Data.DataColumn VALOR_PESO_TCP;
        private System.Data.DataColumn PORC_OUTRAS_TAXAS_TCP;
        private System.Data.DataColumn DESCRIC_PORC_OUTRAS_TAXAS_TCP;
        private System.Data.DataColumn VALOR_OUTRAS_TAXAS_TCP;
        private System.Data.DataColumn DESCRIC_VALOR_OUTRAS_TAXAS_TCP;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbTabela_composicao_preco;
        private System.Windows.Forms.DataGridView dgvTabela_composicao_preco;
        private System.Windows.Forms.Button button1;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODTCPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPJCLIENTETCPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMECLIENTETCPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEGUROTCPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOLETATCPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pEDAGIOTCPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn m3TCPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cATBPTCPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESPBPTCPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pESOINICIALTCPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pESOFINALTCPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORPESOTCPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MINIMO_TCP;
        private System.Windows.Forms.DataGridViewTextBoxColumn FRETE_TCP;
        private System.Windows.Forms.DataGridViewTextBoxColumn pORCOUTRASTAXASTCPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRICPORCOUTRASTAXASTCPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALOROUTRASTAXASTCPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRICVALOROUTRASTAXASTCPDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_tipo;
        private System.Windows.Forms.Label label_cliente;
        private System.Windows.Forms.TextBox tb_cliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_cnpj;
        private System.Windows.Forms.Label label2;
    }
}