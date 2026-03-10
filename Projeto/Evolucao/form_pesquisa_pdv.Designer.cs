namespace Evolucao
{
    partial class form_pesquisa_pdv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_pesquisa_pdv));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvNfce = new System.Windows.Forms.DataGridView();
            this.dsNfce = new System.Data.DataSet();
            this.NFCE = new System.Data.DataTable();
            this.COD_NFCE = new System.Data.DataColumn();
            this.NATUREZA_NFCE = new System.Data.DataColumn();
            this.CPF_CNPJ_CLIENTE_NFCE = new System.Data.DataColumn();
            this.NOME_CLIENTE_CPF_NFCE = new System.Data.DataColumn();
            this.DATA_EMISSAO_NFCE = new System.Data.DataColumn();
            this.BC_ICMS_NFCE = new System.Data.DataColumn();
            this.VALOR_ICMS_NFCE = new System.Data.DataColumn();
            this.BC_ICMS_ST_NFCE = new System.Data.DataColumn();
            this.VALOR_ICMS_ST_NFCE = new System.Data.DataColumn();
            this.VALOR_PRODUTOS_NFCE = new System.Data.DataColumn();
            this.VALOR_NOTA_NFCE = new System.Data.DataColumn();
            this.VALOR_FRETE_NFCE = new System.Data.DataColumn();
            this.NUMERO_NFCE = new System.Data.DataColumn();
            this.SERIE_NFCE = new System.Data.DataColumn();
            this.RECIBO_NFCE = new System.Data.DataColumn();
            this.CHAVE_ACESSO_NFCE = new System.Data.DataColumn();
            this.PROTOCOLO_NFCE = new System.Data.DataColumn();
            this.XML_NFCE = new System.Data.DataColumn();
            this.VALOR_TOTAL_TRIB_NFCE = new System.Data.DataColumn();
            this.FORMA_PGTO_NFCE = new System.Data.DataColumn();
            this.VALOR_DESCONTO_NFCE = new System.Data.DataColumn();
            this.PEDIDO_NFCE = new System.Data.DataColumn();
            this.PEDIDO_FECHADO_NFCE = new System.Data.DataColumn();
            this.dataColumn1 = new System.Data.DataColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbFechados = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtFinal = new System.Windows.Forms.DateTimePicker();
            this.dtInicial = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_cpf = new System.Windows.Forms.TextBox();
            this.tb_nfce = new System.Windows.Forms.TextBox();
            this.datNfce = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.col_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nATUREZANFCEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nUMERONFCEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFCNPJCLIENTENFCEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMECLIENTECPFNFCEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAEMISSAONFCEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bCICMSNFCEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORICMSNFCEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bCICMSSTNFCEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORICMSSTNFCEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORPRODUTOSNFCEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORNOTANFCEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORFRETENFCEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sERIENFCEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rECIBONFCEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHAVEACESSONFCEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROTOCOLONFCEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xMLNFCEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORTOTALTRIBNFCEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fORMAPGTONFCEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORDESCONTONFCEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pEDIDOFECHADONFCEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNfce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNfce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NFCE)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvNfce
            // 
            this.dgvNfce.AllowUserToAddRows = false;
            this.dgvNfce.AutoGenerateColumns = false;
            this.dgvNfce.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNfce.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_cod,
            this.nATUREZANFCEDataGridViewTextBoxColumn,
            this.nUMERONFCEDataGridViewTextBoxColumn,
            this.col_pedido,
            this.cPFCNPJCLIENTENFCEDataGridViewTextBoxColumn,
            this.nOMECLIENTECPFNFCEDataGridViewTextBoxColumn,
            this.dATAEMISSAONFCEDataGridViewTextBoxColumn,
            this.bCICMSNFCEDataGridViewTextBoxColumn,
            this.vALORICMSNFCEDataGridViewTextBoxColumn,
            this.bCICMSSTNFCEDataGridViewTextBoxColumn,
            this.vALORICMSSTNFCEDataGridViewTextBoxColumn,
            this.vALORPRODUTOSNFCEDataGridViewTextBoxColumn,
            this.vALORNOTANFCEDataGridViewTextBoxColumn,
            this.vALORFRETENFCEDataGridViewTextBoxColumn,
            this.sERIENFCEDataGridViewTextBoxColumn,
            this.rECIBONFCEDataGridViewTextBoxColumn,
            this.cHAVEACESSONFCEDataGridViewTextBoxColumn,
            this.pROTOCOLONFCEDataGridViewTextBoxColumn,
            this.xMLNFCEDataGridViewTextBoxColumn,
            this.vALORTOTALTRIBNFCEDataGridViewTextBoxColumn,
            this.fORMAPGTONFCEDataGridViewTextBoxColumn,
            this.vALORDESCONTONFCEDataGridViewTextBoxColumn,
            this.pEDIDOFECHADONFCEDataGridViewTextBoxColumn});
            this.dgvNfce.DataMember = "NFCE";
            this.dgvNfce.DataSource = this.dsNfce;
            this.dgvNfce.Location = new System.Drawing.Point(6, 128);
            this.dgvNfce.Name = "dgvNfce";
            this.dgvNfce.Size = new System.Drawing.Size(670, 453);
            this.dgvNfce.TabIndex = 0;
            this.dgvNfce.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNfce_CellDoubleClick);
            // 
            // dsNfce
            // 
            this.dsNfce.DataSetName = "dsNfce";
            this.dsNfce.Namespace = "http://www.tempuri.org/dsNfce.xsd";
            this.dsNfce.Tables.AddRange(new System.Data.DataTable[] {
            this.NFCE});
            // 
            // NFCE
            // 
            this.NFCE.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_NFCE,
            this.NATUREZA_NFCE,
            this.CPF_CNPJ_CLIENTE_NFCE,
            this.NOME_CLIENTE_CPF_NFCE,
            this.DATA_EMISSAO_NFCE,
            this.BC_ICMS_NFCE,
            this.VALOR_ICMS_NFCE,
            this.BC_ICMS_ST_NFCE,
            this.VALOR_ICMS_ST_NFCE,
            this.VALOR_PRODUTOS_NFCE,
            this.VALOR_NOTA_NFCE,
            this.VALOR_FRETE_NFCE,
            this.NUMERO_NFCE,
            this.SERIE_NFCE,
            this.RECIBO_NFCE,
            this.CHAVE_ACESSO_NFCE,
            this.PROTOCOLO_NFCE,
            this.XML_NFCE,
            this.VALOR_TOTAL_TRIB_NFCE,
            this.FORMA_PGTO_NFCE,
            this.VALOR_DESCONTO_NFCE,
            this.PEDIDO_NFCE,
            this.PEDIDO_FECHADO_NFCE,
            this.dataColumn1});
            this.NFCE.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_NFCE"}, true)});
            this.NFCE.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_NFCE};
            this.NFCE.TableName = "NFCE";
            // 
            // COD_NFCE
            // 
            this.COD_NFCE.AllowDBNull = false;
            this.COD_NFCE.ColumnName = "COD_NFCE";
            this.COD_NFCE.DataType = typeof(int);
            // 
            // NATUREZA_NFCE
            // 
            this.NATUREZA_NFCE.ColumnName = "NATUREZA_NFCE";
            this.NATUREZA_NFCE.MaxLength = 20;
            // 
            // CPF_CNPJ_CLIENTE_NFCE
            // 
            this.CPF_CNPJ_CLIENTE_NFCE.ColumnName = "CPF_CNPJ_CLIENTE_NFCE";
            this.CPF_CNPJ_CLIENTE_NFCE.MaxLength = 200;
            // 
            // NOME_CLIENTE_CPF_NFCE
            // 
            this.NOME_CLIENTE_CPF_NFCE.ColumnName = "NOME_CLIENTE_CPF_NFCE";
            this.NOME_CLIENTE_CPF_NFCE.MaxLength = 200;
            // 
            // DATA_EMISSAO_NFCE
            // 
            this.DATA_EMISSAO_NFCE.ColumnName = "DATA_EMISSAO_NFCE";
            this.DATA_EMISSAO_NFCE.DataType = typeof(System.DateTime);
            // 
            // BC_ICMS_NFCE
            // 
            this.BC_ICMS_NFCE.ColumnName = "BC_ICMS_NFCE";
            this.BC_ICMS_NFCE.DataType = typeof(double);
            // 
            // VALOR_ICMS_NFCE
            // 
            this.VALOR_ICMS_NFCE.ColumnName = "VALOR_ICMS_NFCE";
            this.VALOR_ICMS_NFCE.DataType = typeof(double);
            // 
            // BC_ICMS_ST_NFCE
            // 
            this.BC_ICMS_ST_NFCE.ColumnName = "BC_ICMS_ST_NFCE";
            this.BC_ICMS_ST_NFCE.DataType = typeof(double);
            // 
            // VALOR_ICMS_ST_NFCE
            // 
            this.VALOR_ICMS_ST_NFCE.ColumnName = "VALOR_ICMS_ST_NFCE";
            this.VALOR_ICMS_ST_NFCE.DataType = typeof(double);
            // 
            // VALOR_PRODUTOS_NFCE
            // 
            this.VALOR_PRODUTOS_NFCE.ColumnName = "VALOR_PRODUTOS_NFCE";
            this.VALOR_PRODUTOS_NFCE.DataType = typeof(double);
            // 
            // VALOR_NOTA_NFCE
            // 
            this.VALOR_NOTA_NFCE.ColumnName = "VALOR_NOTA_NFCE";
            this.VALOR_NOTA_NFCE.DataType = typeof(double);
            // 
            // VALOR_FRETE_NFCE
            // 
            this.VALOR_FRETE_NFCE.ColumnName = "VALOR_FRETE_NFCE";
            this.VALOR_FRETE_NFCE.DataType = typeof(double);
            // 
            // NUMERO_NFCE
            // 
            this.NUMERO_NFCE.ColumnName = "NUMERO_NFCE";
            this.NUMERO_NFCE.DataType = typeof(int);
            // 
            // SERIE_NFCE
            // 
            this.SERIE_NFCE.ColumnName = "SERIE_NFCE";
            this.SERIE_NFCE.DataType = typeof(int);
            // 
            // RECIBO_NFCE
            // 
            this.RECIBO_NFCE.ColumnName = "RECIBO_NFCE";
            this.RECIBO_NFCE.MaxLength = 100;
            // 
            // CHAVE_ACESSO_NFCE
            // 
            this.CHAVE_ACESSO_NFCE.ColumnName = "CHAVE_ACESSO_NFCE";
            this.CHAVE_ACESSO_NFCE.MaxLength = 100;
            // 
            // PROTOCOLO_NFCE
            // 
            this.PROTOCOLO_NFCE.ColumnName = "PROTOCOLO_NFCE";
            this.PROTOCOLO_NFCE.MaxLength = 100;
            // 
            // XML_NFCE
            // 
            this.XML_NFCE.ColumnName = "XML_NFCE";
            this.XML_NFCE.MaxLength = 2147483647;
            // 
            // VALOR_TOTAL_TRIB_NFCE
            // 
            this.VALOR_TOTAL_TRIB_NFCE.ColumnName = "VALOR_TOTAL_TRIB_NFCE";
            this.VALOR_TOTAL_TRIB_NFCE.DataType = typeof(double);
            // 
            // FORMA_PGTO_NFCE
            // 
            this.FORMA_PGTO_NFCE.ColumnName = "FORMA_PGTO_NFCE";
            this.FORMA_PGTO_NFCE.MaxLength = 100;
            // 
            // VALOR_DESCONTO_NFCE
            // 
            this.VALOR_DESCONTO_NFCE.ColumnName = "VALOR_DESCONTO_NFCE";
            this.VALOR_DESCONTO_NFCE.DataType = typeof(double);
            // 
            // PEDIDO_NFCE
            // 
            this.PEDIDO_NFCE.ColumnName = "PEDIDO_NFCE";
            this.PEDIDO_NFCE.DataType = typeof(int);
            // 
            // PEDIDO_FECHADO_NFCE
            // 
            this.PEDIDO_FECHADO_NFCE.ColumnName = "PEDIDO_FECHADO_NFCE";
            this.PEDIDO_FECHADO_NFCE.DataType = typeof(int);
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "MESA_NFCE";
            this.dataColumn1.DataType = typeof(int);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.cbFechados);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tb_cpf);
            this.panel1.Controls.Add(this.tb_nfce);
            this.panel1.Location = new System.Drawing.Point(6, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(670, 109);
            this.panel1.TabIndex = 1;
            // 
            // cbFechados
            // 
            this.cbFechados.AutoSize = true;
            this.cbFechados.Location = new System.Drawing.Point(428, 25);
            this.cbFechados.Name = "cbFechados";
            this.cbFechados.Size = new System.Drawing.Size(152, 17);
            this.cbFechados.TabIndex = 22;
            this.cbFechados.Text = "Mostrar Pedidos Fechados";
            this.cbFechados.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Pedido:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(324, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(92, 20);
            this.textBox1.TabIndex = 18;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(124, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 72);
            this.button1.TabIndex = 17;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtFinal);
            this.groupBox2.Controls.Add(this.dtInicial);
            this.groupBox2.Location = new System.Drawing.Point(6, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(112, 79);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Entre Datas";
            // 
            // dtFinal
            // 
            this.dtFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFinal.Location = new System.Drawing.Point(6, 45);
            this.dtFinal.Name = "dtFinal";
            this.dtFinal.Size = new System.Drawing.Size(97, 20);
            this.dtFinal.TabIndex = 13;
            // 
            // dtInicial
            // 
            this.dtInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicial.Location = new System.Drawing.Point(6, 19);
            this.dtInicial.Name = "dtInicial";
            this.dtInicial.Size = new System.Drawing.Size(97, 20);
            this.dtInicial.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CPF:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nfce.:";
            // 
            // tb_cpf
            // 
            this.tb_cpf.Location = new System.Drawing.Point(324, 73);
            this.tb_cpf.Name = "tb_cpf";
            this.tb_cpf.Size = new System.Drawing.Size(175, 20);
            this.tb_cpf.TabIndex = 1;
            this.tb_cpf.TextChanged += new System.EventHandler(this.tb_cpf_TextChanged);
            // 
            // tb_nfce
            // 
            this.tb_nfce.Location = new System.Drawing.Point(324, 23);
            this.tb_nfce.Name = "tb_nfce";
            this.tb_nfce.Size = new System.Drawing.Size(92, 20);
            this.tb_nfce.TabIndex = 0;
            this.tb_nfce.TextChanged += new System.EventHandler(this.tb_nfce_TextChanged);
            // 
            // datNfce
            // 
            this.datNfce.DeleteCommand = this.fbCommand4;
            this.datNfce.InsertCommand = this.fbCommand2;
            this.datNfce.SelectCommand = this.fbCommand1;
            this.datNfce.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * from nfce";
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
            // col_cod
            // 
            this.col_cod.DataPropertyName = "COD_NFCE";
            this.col_cod.HeaderText = "COD_NFCE";
            this.col_cod.Name = "col_cod";
            this.col_cod.Visible = false;
            // 
            // nATUREZANFCEDataGridViewTextBoxColumn
            // 
            this.nATUREZANFCEDataGridViewTextBoxColumn.DataPropertyName = "NATUREZA_NFCE";
            this.nATUREZANFCEDataGridViewTextBoxColumn.HeaderText = "NATUREZA_NFCE";
            this.nATUREZANFCEDataGridViewTextBoxColumn.Name = "nATUREZANFCEDataGridViewTextBoxColumn";
            this.nATUREZANFCEDataGridViewTextBoxColumn.Visible = false;
            // 
            // nUMERONFCEDataGridViewTextBoxColumn
            // 
            this.nUMERONFCEDataGridViewTextBoxColumn.DataPropertyName = "NUMERO_NFCE";
            this.nUMERONFCEDataGridViewTextBoxColumn.HeaderText = "Número";
            this.nUMERONFCEDataGridViewTextBoxColumn.Name = "nUMERONFCEDataGridViewTextBoxColumn";
            // 
            // col_pedido
            // 
            this.col_pedido.DataPropertyName = "PEDIDO_NFCE";
            this.col_pedido.HeaderText = "Pedido";
            this.col_pedido.Name = "col_pedido";
            // 
            // cPFCNPJCLIENTENFCEDataGridViewTextBoxColumn
            // 
            this.cPFCNPJCLIENTENFCEDataGridViewTextBoxColumn.DataPropertyName = "CPF_CNPJ_CLIENTE_NFCE";
            this.cPFCNPJCLIENTENFCEDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cPFCNPJCLIENTENFCEDataGridViewTextBoxColumn.Name = "cPFCNPJCLIENTENFCEDataGridViewTextBoxColumn";
            // 
            // nOMECLIENTECPFNFCEDataGridViewTextBoxColumn
            // 
            this.nOMECLIENTECPFNFCEDataGridViewTextBoxColumn.DataPropertyName = "NOME_CLIENTE_CPF_NFCE";
            this.nOMECLIENTECPFNFCEDataGridViewTextBoxColumn.HeaderText = "NOME_CLIENTE_CPF_NFCE";
            this.nOMECLIENTECPFNFCEDataGridViewTextBoxColumn.Name = "nOMECLIENTECPFNFCEDataGridViewTextBoxColumn";
            this.nOMECLIENTECPFNFCEDataGridViewTextBoxColumn.Visible = false;
            // 
            // dATAEMISSAONFCEDataGridViewTextBoxColumn
            // 
            this.dATAEMISSAONFCEDataGridViewTextBoxColumn.DataPropertyName = "DATA_EMISSAO_NFCE";
            this.dATAEMISSAONFCEDataGridViewTextBoxColumn.HeaderText = "Data Emissão";
            this.dATAEMISSAONFCEDataGridViewTextBoxColumn.Name = "dATAEMISSAONFCEDataGridViewTextBoxColumn";
            // 
            // bCICMSNFCEDataGridViewTextBoxColumn
            // 
            this.bCICMSNFCEDataGridViewTextBoxColumn.DataPropertyName = "BC_ICMS_NFCE";
            this.bCICMSNFCEDataGridViewTextBoxColumn.HeaderText = "BC_ICMS_NFCE";
            this.bCICMSNFCEDataGridViewTextBoxColumn.Name = "bCICMSNFCEDataGridViewTextBoxColumn";
            this.bCICMSNFCEDataGridViewTextBoxColumn.Visible = false;
            // 
            // vALORICMSNFCEDataGridViewTextBoxColumn
            // 
            this.vALORICMSNFCEDataGridViewTextBoxColumn.DataPropertyName = "VALOR_ICMS_NFCE";
            this.vALORICMSNFCEDataGridViewTextBoxColumn.HeaderText = "VALOR_ICMS_NFCE";
            this.vALORICMSNFCEDataGridViewTextBoxColumn.Name = "vALORICMSNFCEDataGridViewTextBoxColumn";
            this.vALORICMSNFCEDataGridViewTextBoxColumn.Visible = false;
            // 
            // bCICMSSTNFCEDataGridViewTextBoxColumn
            // 
            this.bCICMSSTNFCEDataGridViewTextBoxColumn.DataPropertyName = "BC_ICMS_ST_NFCE";
            this.bCICMSSTNFCEDataGridViewTextBoxColumn.HeaderText = "BC_ICMS_ST_NFCE";
            this.bCICMSSTNFCEDataGridViewTextBoxColumn.Name = "bCICMSSTNFCEDataGridViewTextBoxColumn";
            this.bCICMSSTNFCEDataGridViewTextBoxColumn.Visible = false;
            // 
            // vALORICMSSTNFCEDataGridViewTextBoxColumn
            // 
            this.vALORICMSSTNFCEDataGridViewTextBoxColumn.DataPropertyName = "VALOR_ICMS_ST_NFCE";
            this.vALORICMSSTNFCEDataGridViewTextBoxColumn.HeaderText = "VALOR_ICMS_ST_NFCE";
            this.vALORICMSSTNFCEDataGridViewTextBoxColumn.Name = "vALORICMSSTNFCEDataGridViewTextBoxColumn";
            this.vALORICMSSTNFCEDataGridViewTextBoxColumn.Visible = false;
            // 
            // vALORPRODUTOSNFCEDataGridViewTextBoxColumn
            // 
            this.vALORPRODUTOSNFCEDataGridViewTextBoxColumn.DataPropertyName = "VALOR_PRODUTOS_NFCE";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.vALORPRODUTOSNFCEDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.vALORPRODUTOSNFCEDataGridViewTextBoxColumn.HeaderText = "Valor Produtos";
            this.vALORPRODUTOSNFCEDataGridViewTextBoxColumn.Name = "vALORPRODUTOSNFCEDataGridViewTextBoxColumn";
            // 
            // vALORNOTANFCEDataGridViewTextBoxColumn
            // 
            this.vALORNOTANFCEDataGridViewTextBoxColumn.DataPropertyName = "VALOR_NOTA_NFCE";
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.vALORNOTANFCEDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.vALORNOTANFCEDataGridViewTextBoxColumn.HeaderText = "Valor Nota";
            this.vALORNOTANFCEDataGridViewTextBoxColumn.Name = "vALORNOTANFCEDataGridViewTextBoxColumn";
            // 
            // vALORFRETENFCEDataGridViewTextBoxColumn
            // 
            this.vALORFRETENFCEDataGridViewTextBoxColumn.DataPropertyName = "VALOR_FRETE_NFCE";
            this.vALORFRETENFCEDataGridViewTextBoxColumn.HeaderText = "VALOR_FRETE_NFCE";
            this.vALORFRETENFCEDataGridViewTextBoxColumn.Name = "vALORFRETENFCEDataGridViewTextBoxColumn";
            this.vALORFRETENFCEDataGridViewTextBoxColumn.Visible = false;
            // 
            // sERIENFCEDataGridViewTextBoxColumn
            // 
            this.sERIENFCEDataGridViewTextBoxColumn.DataPropertyName = "SERIE_NFCE";
            this.sERIENFCEDataGridViewTextBoxColumn.HeaderText = "SERIE_NFCE";
            this.sERIENFCEDataGridViewTextBoxColumn.Name = "sERIENFCEDataGridViewTextBoxColumn";
            this.sERIENFCEDataGridViewTextBoxColumn.Visible = false;
            // 
            // rECIBONFCEDataGridViewTextBoxColumn
            // 
            this.rECIBONFCEDataGridViewTextBoxColumn.DataPropertyName = "RECIBO_NFCE";
            this.rECIBONFCEDataGridViewTextBoxColumn.HeaderText = "RECIBO_NFCE";
            this.rECIBONFCEDataGridViewTextBoxColumn.Name = "rECIBONFCEDataGridViewTextBoxColumn";
            this.rECIBONFCEDataGridViewTextBoxColumn.Visible = false;
            // 
            // cHAVEACESSONFCEDataGridViewTextBoxColumn
            // 
            this.cHAVEACESSONFCEDataGridViewTextBoxColumn.DataPropertyName = "CHAVE_ACESSO_NFCE";
            this.cHAVEACESSONFCEDataGridViewTextBoxColumn.HeaderText = "Chave Acesso";
            this.cHAVEACESSONFCEDataGridViewTextBoxColumn.Name = "cHAVEACESSONFCEDataGridViewTextBoxColumn";
            // 
            // pROTOCOLONFCEDataGridViewTextBoxColumn
            // 
            this.pROTOCOLONFCEDataGridViewTextBoxColumn.DataPropertyName = "PROTOCOLO_NFCE";
            this.pROTOCOLONFCEDataGridViewTextBoxColumn.HeaderText = "Protocolo";
            this.pROTOCOLONFCEDataGridViewTextBoxColumn.Name = "pROTOCOLONFCEDataGridViewTextBoxColumn";
            // 
            // xMLNFCEDataGridViewTextBoxColumn
            // 
            this.xMLNFCEDataGridViewTextBoxColumn.DataPropertyName = "XML_NFCE";
            this.xMLNFCEDataGridViewTextBoxColumn.HeaderText = "XML_NFCE";
            this.xMLNFCEDataGridViewTextBoxColumn.Name = "xMLNFCEDataGridViewTextBoxColumn";
            this.xMLNFCEDataGridViewTextBoxColumn.Visible = false;
            // 
            // vALORTOTALTRIBNFCEDataGridViewTextBoxColumn
            // 
            this.vALORTOTALTRIBNFCEDataGridViewTextBoxColumn.DataPropertyName = "VALOR_TOTAL_TRIB_NFCE";
            this.vALORTOTALTRIBNFCEDataGridViewTextBoxColumn.HeaderText = "VALOR_TOTAL_TRIB_NFCE";
            this.vALORTOTALTRIBNFCEDataGridViewTextBoxColumn.Name = "vALORTOTALTRIBNFCEDataGridViewTextBoxColumn";
            this.vALORTOTALTRIBNFCEDataGridViewTextBoxColumn.Visible = false;
            // 
            // fORMAPGTONFCEDataGridViewTextBoxColumn
            // 
            this.fORMAPGTONFCEDataGridViewTextBoxColumn.DataPropertyName = "FORMA_PGTO_NFCE";
            this.fORMAPGTONFCEDataGridViewTextBoxColumn.HeaderText = "FORMA_PGTO_NFCE";
            this.fORMAPGTONFCEDataGridViewTextBoxColumn.Name = "fORMAPGTONFCEDataGridViewTextBoxColumn";
            this.fORMAPGTONFCEDataGridViewTextBoxColumn.Visible = false;
            // 
            // vALORDESCONTONFCEDataGridViewTextBoxColumn
            // 
            this.vALORDESCONTONFCEDataGridViewTextBoxColumn.DataPropertyName = "VALOR_DESCONTO_NFCE";
            this.vALORDESCONTONFCEDataGridViewTextBoxColumn.HeaderText = "VALOR_DESCONTO_NFCE";
            this.vALORDESCONTONFCEDataGridViewTextBoxColumn.Name = "vALORDESCONTONFCEDataGridViewTextBoxColumn";
            this.vALORDESCONTONFCEDataGridViewTextBoxColumn.Visible = false;
            // 
            // pEDIDOFECHADONFCEDataGridViewTextBoxColumn
            // 
            this.pEDIDOFECHADONFCEDataGridViewTextBoxColumn.DataPropertyName = "PEDIDO_FECHADO_NFCE";
            this.pEDIDOFECHADONFCEDataGridViewTextBoxColumn.HeaderText = "Fechado";
            this.pEDIDOFECHADONFCEDataGridViewTextBoxColumn.Name = "pEDIDOFECHADONFCEDataGridViewTextBoxColumn";
            this.pEDIDOFECHADONFCEDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pEDIDOFECHADONFCEDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // form_pesquisa_pdv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 587);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvNfce);
            this.Name = "form_pesquisa_pdv";
            this.Text = "Pesquisa PDV";
            this.Load += new System.EventHandler(this.form_pesquisa_pdv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNfce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNfce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NFCE)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNfce;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_cpf;
        private System.Windows.Forms.TextBox tb_nfce;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtFinal;
        private System.Windows.Forms.DateTimePicker dtInicial;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datNfce;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Data.DataSet dsNfce;
        private System.Data.DataTable NFCE;
        private System.Data.DataColumn COD_NFCE;
        private System.Data.DataColumn NATUREZA_NFCE;
        private System.Data.DataColumn CPF_CNPJ_CLIENTE_NFCE;
        private System.Data.DataColumn NOME_CLIENTE_CPF_NFCE;
        private System.Data.DataColumn DATA_EMISSAO_NFCE;
        private System.Data.DataColumn BC_ICMS_NFCE;
        private System.Data.DataColumn VALOR_ICMS_NFCE;
        private System.Data.DataColumn BC_ICMS_ST_NFCE;
        private System.Data.DataColumn VALOR_ICMS_ST_NFCE;
        private System.Data.DataColumn VALOR_PRODUTOS_NFCE;
        private System.Data.DataColumn VALOR_NOTA_NFCE;
        private System.Data.DataColumn VALOR_FRETE_NFCE;
        private System.Data.DataColumn NUMERO_NFCE;
        private System.Data.DataColumn SERIE_NFCE;
        private System.Data.DataColumn RECIBO_NFCE;
        private System.Data.DataColumn CHAVE_ACESSO_NFCE;
        private System.Data.DataColumn PROTOCOLO_NFCE;
        private System.Data.DataColumn XML_NFCE;
        private System.Data.DataColumn VALOR_TOTAL_TRIB_NFCE;
        private System.Data.DataColumn FORMA_PGTO_NFCE;
        private System.Data.DataColumn VALOR_DESCONTO_NFCE;
        private System.Data.DataColumn PEDIDO_NFCE;
        private System.Data.DataColumn PEDIDO_FECHADO_NFCE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Data.DataColumn dataColumn1;
        private System.Windows.Forms.CheckBox cbFechados;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn nATUREZANFCEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMERONFCEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFCNPJCLIENTENFCEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMECLIENTECPFNFCEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAEMISSAONFCEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bCICMSNFCEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORICMSNFCEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bCICMSSTNFCEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORICMSSTNFCEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORPRODUTOSNFCEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORNOTANFCEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORFRETENFCEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sERIENFCEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rECIBONFCEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHAVEACESSONFCEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROTOCOLONFCEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xMLNFCEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORTOTALTRIBNFCEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fORMAPGTONFCEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORDESCONTONFCEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pEDIDOFECHADONFCEDataGridViewTextBoxColumn;
    }
}