namespace Evolucao
{
    partial class form_pesquisa_faturamento_cte_detalhado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_pesquisa_faturamento_cte_detalhado));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvFatura = new System.Windows.Forms.DataGridView();
            this.dsCte_notas_fiscais = new System.Data.DataSet();
            this.CTE_NOTAS_FISCAIS = new System.Data.DataTable();
            this.COD_CNF = new System.Data.DataColumn();
            this.N_NF_CNF = new System.Data.DataColumn();
            this.CHAVE_NF_CNF = new System.Data.DataColumn();
            this.COD_CTE_CNF = new System.Data.DataColumn();
            this.VALOR_NOTA_CNF = new System.Data.DataColumn();
            this.PESO_NOTA_CNF = new System.Data.DataColumn();
            this.CUBAGEM_NOTA_NF = new System.Data.DataColumn();
            this.VOLUMES_NOTA_CNF = new System.Data.DataColumn();
            this.MODELO_NF_CNF = new System.Data.DataColumn();
            this.SERIE_NF_CNF = new System.Data.DataColumn();
            this.NUMERO_NF_CNF = new System.Data.DataColumn();
            this.DATA_EMISSAO_NF_CNF = new System.Data.DataColumn();
            this.VALOR_BC_ICMS_NF_CNF = new System.Data.DataColumn();
            this.VALOR_TOTAL_ICMS_NF_CNF = new System.Data.DataColumn();
            this.VALOR_BC_ICMS_ST_NF_CNF = new System.Data.DataColumn();
            this.VALOR_TOTAL_ICMS_ST_NF_CNF = new System.Data.DataColumn();
            this.VALOR_TOTAL_PROD_NF_CNF = new System.Data.DataColumn();
            this.VALOR_TOTAL_NF_CNF = new System.Data.DataColumn();
            this.CFOP_NF_CNF = new System.Data.DataColumn();
            this.PESO_TOTAL_KG_NF_CNF = new System.Data.DataColumn();
            this.SUFRAMA_NF_CNF = new System.Data.DataColumn();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.cbStatus = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbSomar = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button21 = new System.Windows.Forms.Button();
            this.tb_tomador_cnpj = new System.Windows.Forms.TextBox();
            this.cbTomador = new System.Windows.Forms.CheckBox();
            this.label50 = new System.Windows.Forms.Label();
            this.tb_tomador_nome = new System.Windows.Forms.TextBox();
            this.label51 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbData = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtTermino = new System.Windows.Forms.DateTimePicker();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_tomador = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_recebedor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_remetente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_cte = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.datCte_notas_fiscais = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand8 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand6 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand5 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand7 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.cODCNFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nNFCNFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHAVENFCNFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODCTECNFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORNOTACNFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pESONOTACNFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUBAGEMNOTANFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vOLUMESNOTACNFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mODELONFCNFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sERIENFCNFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nUMERONFCNFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAEMISSAONFCNFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORBCICMSNFCNFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORTOTALICMSNFCNFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORBCICMSSTNFCNFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORTOTALICMSSTNFCNFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORTOTALPRODNFCNFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORTOTALNFCNFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFOPNFCNFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pESOTOTALKGNFCNFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUFRAMANFCNFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFatura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCte_notas_fiscais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CTE_NOTAS_FISCAIS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.dgvFatura);
            this.panel1.Controls.Add(this.dgvDados);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.cbSomar);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(940, 660);
            this.panel1.TabIndex = 8;
            // 
            // dgvFatura
            // 
            this.dgvFatura.AllowUserToAddRows = false;
            this.dgvFatura.AllowUserToDeleteRows = false;
            this.dgvFatura.AutoGenerateColumns = false;
            this.dgvFatura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFatura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODCNFDataGridViewTextBoxColumn,
            this.nNFCNFDataGridViewTextBoxColumn,
            this.cHAVENFCNFDataGridViewTextBoxColumn,
            this.cODCTECNFDataGridViewTextBoxColumn,
            this.vALORNOTACNFDataGridViewTextBoxColumn,
            this.pESONOTACNFDataGridViewTextBoxColumn,
            this.cUBAGEMNOTANFDataGridViewTextBoxColumn,
            this.vOLUMESNOTACNFDataGridViewTextBoxColumn,
            this.mODELONFCNFDataGridViewTextBoxColumn,
            this.sERIENFCNFDataGridViewTextBoxColumn,
            this.nUMERONFCNFDataGridViewTextBoxColumn,
            this.dATAEMISSAONFCNFDataGridViewTextBoxColumn,
            this.vALORBCICMSNFCNFDataGridViewTextBoxColumn,
            this.vALORTOTALICMSNFCNFDataGridViewTextBoxColumn,
            this.vALORBCICMSSTNFCNFDataGridViewTextBoxColumn,
            this.vALORTOTALICMSSTNFCNFDataGridViewTextBoxColumn,
            this.vALORTOTALPRODNFCNFDataGridViewTextBoxColumn,
            this.vALORTOTALNFCNFDataGridViewTextBoxColumn,
            this.cFOPNFCNFDataGridViewTextBoxColumn,
            this.pESOTOTALKGNFCNFDataGridViewTextBoxColumn,
            this.sUFRAMANFCNFDataGridViewTextBoxColumn});
            this.dgvFatura.DataMember = "CTE_NOTAS_FISCAIS";
            this.dgvFatura.DataSource = this.dsCte_notas_fiscais;
            this.dgvFatura.Location = new System.Drawing.Point(794, 182);
            this.dgvFatura.Name = "dgvFatura";
            this.dgvFatura.ReadOnly = true;
            this.dgvFatura.Size = new System.Drawing.Size(140, 156);
            this.dgvFatura.TabIndex = 21;
            // 
            // dsCte_notas_fiscais
            // 
            this.dsCte_notas_fiscais.DataSetName = "dsCte_notas_fiscais";
            this.dsCte_notas_fiscais.Namespace = "http://www.tempuri.org/dsCte_notas_fiscais.xsd";
            this.dsCte_notas_fiscais.Tables.AddRange(new System.Data.DataTable[] {
            this.CTE_NOTAS_FISCAIS});
            // 
            // CTE_NOTAS_FISCAIS
            // 
            this.CTE_NOTAS_FISCAIS.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_CNF,
            this.N_NF_CNF,
            this.CHAVE_NF_CNF,
            this.COD_CTE_CNF,
            this.VALOR_NOTA_CNF,
            this.PESO_NOTA_CNF,
            this.CUBAGEM_NOTA_NF,
            this.VOLUMES_NOTA_CNF,
            this.MODELO_NF_CNF,
            this.SERIE_NF_CNF,
            this.NUMERO_NF_CNF,
            this.DATA_EMISSAO_NF_CNF,
            this.VALOR_BC_ICMS_NF_CNF,
            this.VALOR_TOTAL_ICMS_NF_CNF,
            this.VALOR_BC_ICMS_ST_NF_CNF,
            this.VALOR_TOTAL_ICMS_ST_NF_CNF,
            this.VALOR_TOTAL_PROD_NF_CNF,
            this.VALOR_TOTAL_NF_CNF,
            this.CFOP_NF_CNF,
            this.PESO_TOTAL_KG_NF_CNF,
            this.SUFRAMA_NF_CNF});
            this.CTE_NOTAS_FISCAIS.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_CNF"}, true)});
            this.CTE_NOTAS_FISCAIS.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_CNF};
            this.CTE_NOTAS_FISCAIS.TableName = "CTE_NOTAS_FISCAIS";
            // 
            // COD_CNF
            // 
            this.COD_CNF.AllowDBNull = false;
            this.COD_CNF.ColumnName = "COD_CNF";
            this.COD_CNF.DataType = typeof(int);
            // 
            // N_NF_CNF
            // 
            this.N_NF_CNF.ColumnName = "N_NF_CNF";
            this.N_NF_CNF.DataType = typeof(int);
            // 
            // CHAVE_NF_CNF
            // 
            this.CHAVE_NF_CNF.ColumnName = "CHAVE_NF_CNF";
            this.CHAVE_NF_CNF.MaxLength = 300;
            // 
            // COD_CTE_CNF
            // 
            this.COD_CTE_CNF.ColumnName = "COD_CTE_CNF";
            this.COD_CTE_CNF.DataType = typeof(int);
            // 
            // VALOR_NOTA_CNF
            // 
            this.VALOR_NOTA_CNF.ColumnName = "VALOR_NOTA_CNF";
            this.VALOR_NOTA_CNF.DataType = typeof(double);
            // 
            // PESO_NOTA_CNF
            // 
            this.PESO_NOTA_CNF.ColumnName = "PESO_NOTA_CNF";
            this.PESO_NOTA_CNF.DataType = typeof(double);
            // 
            // CUBAGEM_NOTA_NF
            // 
            this.CUBAGEM_NOTA_NF.ColumnName = "CUBAGEM_NOTA_NF";
            this.CUBAGEM_NOTA_NF.DataType = typeof(double);
            // 
            // VOLUMES_NOTA_CNF
            // 
            this.VOLUMES_NOTA_CNF.ColumnName = "VOLUMES_NOTA_CNF";
            this.VOLUMES_NOTA_CNF.DataType = typeof(int);
            // 
            // MODELO_NF_CNF
            // 
            this.MODELO_NF_CNF.ColumnName = "MODELO_NF_CNF";
            this.MODELO_NF_CNF.MaxLength = 2;
            // 
            // SERIE_NF_CNF
            // 
            this.SERIE_NF_CNF.ColumnName = "SERIE_NF_CNF";
            this.SERIE_NF_CNF.MaxLength = 3;
            // 
            // NUMERO_NF_CNF
            // 
            this.NUMERO_NF_CNF.ColumnName = "NUMERO_NF_CNF";
            this.NUMERO_NF_CNF.MaxLength = 20;
            // 
            // DATA_EMISSAO_NF_CNF
            // 
            this.DATA_EMISSAO_NF_CNF.ColumnName = "DATA_EMISSAO_NF_CNF";
            this.DATA_EMISSAO_NF_CNF.DataType = typeof(System.DateTime);
            // 
            // VALOR_BC_ICMS_NF_CNF
            // 
            this.VALOR_BC_ICMS_NF_CNF.ColumnName = "VALOR_BC_ICMS_NF_CNF";
            this.VALOR_BC_ICMS_NF_CNF.DataType = typeof(double);
            // 
            // VALOR_TOTAL_ICMS_NF_CNF
            // 
            this.VALOR_TOTAL_ICMS_NF_CNF.ColumnName = "VALOR_TOTAL_ICMS_NF_CNF";
            this.VALOR_TOTAL_ICMS_NF_CNF.DataType = typeof(double);
            // 
            // VALOR_BC_ICMS_ST_NF_CNF
            // 
            this.VALOR_BC_ICMS_ST_NF_CNF.ColumnName = "VALOR_BC_ICMS_ST_NF_CNF";
            this.VALOR_BC_ICMS_ST_NF_CNF.DataType = typeof(double);
            // 
            // VALOR_TOTAL_ICMS_ST_NF_CNF
            // 
            this.VALOR_TOTAL_ICMS_ST_NF_CNF.ColumnName = "VALOR_TOTAL_ICMS_ST_NF_CNF";
            this.VALOR_TOTAL_ICMS_ST_NF_CNF.DataType = typeof(double);
            // 
            // VALOR_TOTAL_PROD_NF_CNF
            // 
            this.VALOR_TOTAL_PROD_NF_CNF.ColumnName = "VALOR_TOTAL_PROD_NF_CNF";
            this.VALOR_TOTAL_PROD_NF_CNF.DataType = typeof(double);
            // 
            // VALOR_TOTAL_NF_CNF
            // 
            this.VALOR_TOTAL_NF_CNF.ColumnName = "VALOR_TOTAL_NF_CNF";
            this.VALOR_TOTAL_NF_CNF.DataType = typeof(double);
            // 
            // CFOP_NF_CNF
            // 
            this.CFOP_NF_CNF.ColumnName = "CFOP_NF_CNF";
            this.CFOP_NF_CNF.MaxLength = 4;
            // 
            // PESO_TOTAL_KG_NF_CNF
            // 
            this.PESO_TOTAL_KG_NF_CNF.ColumnName = "PESO_TOTAL_KG_NF_CNF";
            this.PESO_TOTAL_KG_NF_CNF.DataType = typeof(double);
            // 
            // SUFRAMA_NF_CNF
            // 
            this.SUFRAMA_NF_CNF.ColumnName = "SUFRAMA_NF_CNF";
            this.SUFRAMA_NF_CNF.MaxLength = 9;
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(14, 182);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(774, 455);
            this.dgvDados.TabIndex = 20;
            this.dgvDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellDoubleClick);
            this.dgvDados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellClick);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel5.Controls.Add(this.comboStatus);
            this.panel5.Controls.Add(this.cbStatus);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Location = new System.Drawing.Point(634, 7);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(180, 66);
            this.panel5.TabIndex = 9;
            // 
            // comboStatus
            // 
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Items.AddRange(new object[] {
            "CTe Autorizada",
            "CTe Cancelada",
            "CTe Inutilizada"});
            this.comboStatus.Location = new System.Drawing.Point(52, 12);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(125, 21);
            this.comboStatus.TabIndex = 5;
            // 
            // cbStatus
            // 
            this.cbStatus.AutoSize = true;
            this.cbStatus.Location = new System.Drawing.Point(62, 42);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(75, 17);
            this.cbStatus.TabIndex = 4;
            this.cbStatus.Text = "Por Status";
            this.cbStatus.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Status:";
            // 
            // cbSomar
            // 
            this.cbSomar.AutoSize = true;
            this.cbSomar.Location = new System.Drawing.Point(696, 77);
            this.cbSomar.Name = "cbSomar";
            this.cbSomar.Size = new System.Drawing.Size(56, 17);
            this.cbSomar.TabIndex = 19;
            this.cbSomar.Text = "Somar";
            this.cbSomar.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel4.Controls.Add(this.button21);
            this.panel4.Controls.Add(this.tb_tomador_cnpj);
            this.panel4.Controls.Add(this.cbTomador);
            this.panel4.Controls.Add(this.label50);
            this.panel4.Controls.Add(this.tb_tomador_nome);
            this.panel4.Controls.Add(this.label51);
            this.panel4.Location = new System.Drawing.Point(259, 7);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(369, 87);
            this.panel4.TabIndex = 9;
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(196, 7);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(18, 20);
            this.button21.TabIndex = 13;
            this.button21.Text = "+";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // tb_tomador_cnpj
            // 
            this.tb_tomador_cnpj.Location = new System.Drawing.Point(45, 8);
            this.tb_tomador_cnpj.Name = "tb_tomador_cnpj";
            this.tb_tomador_cnpj.Size = new System.Drawing.Size(145, 20);
            this.tb_tomador_cnpj.TabIndex = 12;
            // 
            // cbTomador
            // 
            this.cbTomador.AutoSize = true;
            this.cbTomador.Location = new System.Drawing.Point(149, 63);
            this.cbTomador.Name = "cbTomador";
            this.cbTomador.Size = new System.Drawing.Size(87, 17);
            this.cbTomador.TabIndex = 4;
            this.cbTomador.Text = "Por Tomador";
            this.cbTomador.UseVisualStyleBackColor = true;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(6, 12);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(37, 13);
            this.label50.TabIndex = 11;
            this.label50.Text = "CNPJ:";
            // 
            // tb_tomador_nome
            // 
            this.tb_tomador_nome.Location = new System.Drawing.Point(45, 33);
            this.tb_tomador_nome.Name = "tb_tomador_nome";
            this.tb_tomador_nome.ReadOnly = true;
            this.tb_tomador_nome.Size = new System.Drawing.Size(302, 20);
            this.tb_tomador_nome.TabIndex = 10;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(6, 37);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(38, 13);
            this.label51.TabIndex = 9;
            this.label51.Text = "Nome:";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(876, 7);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(58, 87);
            this.button9.TabIndex = 18;
            this.button9.Text = "Imprimir\r\npor\r\nCliente";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(820, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 87);
            this.button1.TabIndex = 9;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.cbData);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.dtTermino);
            this.panel3.Controls.Add(this.dtInicio);
            this.panel3.Location = new System.Drawing.Point(74, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(179, 87);
            this.panel3.TabIndex = 8;
            // 
            // cbData
            // 
            this.cbData.AutoSize = true;
            this.cbData.Location = new System.Drawing.Point(59, 63);
            this.cbData.Name = "cbData";
            this.cbData.Size = new System.Drawing.Size(68, 17);
            this.cbData.TabIndex = 4;
            this.cbData.Text = "Por Data";
            this.cbData.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Término:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Início:";
            // 
            // dtTermino
            // 
            this.dtTermino.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTermino.Location = new System.Drawing.Point(59, 37);
            this.dtTermino.Name = "dtTermino";
            this.dtTermino.Size = new System.Drawing.Size(110, 20);
            this.dtTermino.TabIndex = 1;
            // 
            // dtInicio
            // 
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicio.Location = new System.Drawing.Point(59, 11);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(110, 20);
            this.dtInicio.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.tb_tomador);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.tb_recebedor);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.tb_remetente);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.tb_cte);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(13, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(921, 75);
            this.panel2.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(699, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Cód. Fatura:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(770, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(538, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tomador";
            // 
            // tb_tomador
            // 
            this.tb_tomador.Location = new System.Drawing.Point(593, 23);
            this.tb_tomador.Name = "tb_tomador";
            this.tb_tomador.Size = new System.Drawing.Size(100, 20);
            this.tb_tomador.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(352, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Recebedor";
            // 
            // tb_recebedor
            // 
            this.tb_recebedor.Location = new System.Drawing.Point(418, 23);
            this.tb_recebedor.Name = "tb_recebedor";
            this.tb_recebedor.Size = new System.Drawing.Size(100, 20);
            this.tb_recebedor.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Remetente";
            // 
            // tb_remetente
            // 
            this.tb_remetente.Location = new System.Drawing.Point(236, 23);
            this.tb_remetente.Name = "tb_remetente";
            this.tb_remetente.Size = new System.Drawing.Size(100, 20);
            this.tb_remetente.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nº CTe";
            // 
            // tb_cte
            // 
            this.tb_cte.Location = new System.Drawing.Point(61, 23);
            this.tb_cte.Name = "tb_cte";
            this.tb_cte.Size = new System.Drawing.Size(100, 20);
            this.tb_cte.TabIndex = 1;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "CTE";
            // 
            // fbConnection1
            // 
            this.fbConnection1.ConnectionString = resources.GetString("fbConnection1.ConnectionString");
            // 
            // fbCommand1
            // 
            this.fbCommand1.CommandText = "SELECT * FROM FATURA_CTE";
            this.fbCommand1.CommandTimeout = 30;
            this.fbCommand1.Connection = this.fbConnection1;
            // 
            // fbCommand2
            // 
            this.fbCommand2.CommandTimeout = 30;
            // 
            // fbCommand3
            // 
            this.fbCommand3.CommandTimeout = 30;
            // 
            // fbCommand4
            // 
            this.fbCommand4.CommandTimeout = 30;
            // 
            // datCte_notas_fiscais
            // 
            this.datCte_notas_fiscais.DeleteCommand = this.fbCommand8;
            this.datCte_notas_fiscais.InsertCommand = this.fbCommand6;
            this.datCte_notas_fiscais.SelectCommand = this.fbCommand5;
            this.datCte_notas_fiscais.UpdateCommand = this.fbCommand7;
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
            this.fbCommand5.CommandText = "SELECT * FROM CTE_NOTAS_FISCAIS";
            this.fbCommand5.CommandTimeout = 30;
            this.fbCommand5.Connection = this.fbConnection1;
            // 
            // fbCommand7
            // 
            this.fbCommand7.CommandTimeout = 30;
            // 
            // cODCNFDataGridViewTextBoxColumn
            // 
            this.cODCNFDataGridViewTextBoxColumn.DataPropertyName = "COD_CNF";
            this.cODCNFDataGridViewTextBoxColumn.HeaderText = "COD_CNF";
            this.cODCNFDataGridViewTextBoxColumn.Name = "cODCNFDataGridViewTextBoxColumn";
            this.cODCNFDataGridViewTextBoxColumn.ReadOnly = true;
            this.cODCNFDataGridViewTextBoxColumn.Visible = false;
            // 
            // nNFCNFDataGridViewTextBoxColumn
            // 
            this.nNFCNFDataGridViewTextBoxColumn.DataPropertyName = "N_NF_CNF";
            this.nNFCNFDataGridViewTextBoxColumn.HeaderText = "Nº Nota Fiscal";
            this.nNFCNFDataGridViewTextBoxColumn.Name = "nNFCNFDataGridViewTextBoxColumn";
            this.nNFCNFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cHAVENFCNFDataGridViewTextBoxColumn
            // 
            this.cHAVENFCNFDataGridViewTextBoxColumn.DataPropertyName = "CHAVE_NF_CNF";
            this.cHAVENFCNFDataGridViewTextBoxColumn.HeaderText = "CHAVE_NF_CNF";
            this.cHAVENFCNFDataGridViewTextBoxColumn.Name = "cHAVENFCNFDataGridViewTextBoxColumn";
            this.cHAVENFCNFDataGridViewTextBoxColumn.ReadOnly = true;
            this.cHAVENFCNFDataGridViewTextBoxColumn.Visible = false;
            // 
            // cODCTECNFDataGridViewTextBoxColumn
            // 
            this.cODCTECNFDataGridViewTextBoxColumn.DataPropertyName = "COD_CTE_CNF";
            this.cODCTECNFDataGridViewTextBoxColumn.HeaderText = "COD_CTE_CNF";
            this.cODCTECNFDataGridViewTextBoxColumn.Name = "cODCTECNFDataGridViewTextBoxColumn";
            this.cODCTECNFDataGridViewTextBoxColumn.ReadOnly = true;
            this.cODCTECNFDataGridViewTextBoxColumn.Visible = false;
            // 
            // vALORNOTACNFDataGridViewTextBoxColumn
            // 
            this.vALORNOTACNFDataGridViewTextBoxColumn.DataPropertyName = "VALOR_NOTA_CNF";
            this.vALORNOTACNFDataGridViewTextBoxColumn.HeaderText = "VALOR_NOTA_CNF";
            this.vALORNOTACNFDataGridViewTextBoxColumn.Name = "vALORNOTACNFDataGridViewTextBoxColumn";
            this.vALORNOTACNFDataGridViewTextBoxColumn.ReadOnly = true;
            this.vALORNOTACNFDataGridViewTextBoxColumn.Visible = false;
            // 
            // pESONOTACNFDataGridViewTextBoxColumn
            // 
            this.pESONOTACNFDataGridViewTextBoxColumn.DataPropertyName = "PESO_NOTA_CNF";
            this.pESONOTACNFDataGridViewTextBoxColumn.HeaderText = "PESO_NOTA_CNF";
            this.pESONOTACNFDataGridViewTextBoxColumn.Name = "pESONOTACNFDataGridViewTextBoxColumn";
            this.pESONOTACNFDataGridViewTextBoxColumn.ReadOnly = true;
            this.pESONOTACNFDataGridViewTextBoxColumn.Visible = false;
            // 
            // cUBAGEMNOTANFDataGridViewTextBoxColumn
            // 
            this.cUBAGEMNOTANFDataGridViewTextBoxColumn.DataPropertyName = "CUBAGEM_NOTA_NF";
            this.cUBAGEMNOTANFDataGridViewTextBoxColumn.HeaderText = "CUBAGEM_NOTA_NF";
            this.cUBAGEMNOTANFDataGridViewTextBoxColumn.Name = "cUBAGEMNOTANFDataGridViewTextBoxColumn";
            this.cUBAGEMNOTANFDataGridViewTextBoxColumn.ReadOnly = true;
            this.cUBAGEMNOTANFDataGridViewTextBoxColumn.Visible = false;
            // 
            // vOLUMESNOTACNFDataGridViewTextBoxColumn
            // 
            this.vOLUMESNOTACNFDataGridViewTextBoxColumn.DataPropertyName = "VOLUMES_NOTA_CNF";
            this.vOLUMESNOTACNFDataGridViewTextBoxColumn.HeaderText = "VOLUMES_NOTA_CNF";
            this.vOLUMESNOTACNFDataGridViewTextBoxColumn.Name = "vOLUMESNOTACNFDataGridViewTextBoxColumn";
            this.vOLUMESNOTACNFDataGridViewTextBoxColumn.ReadOnly = true;
            this.vOLUMESNOTACNFDataGridViewTextBoxColumn.Visible = false;
            // 
            // mODELONFCNFDataGridViewTextBoxColumn
            // 
            this.mODELONFCNFDataGridViewTextBoxColumn.DataPropertyName = "MODELO_NF_CNF";
            this.mODELONFCNFDataGridViewTextBoxColumn.HeaderText = "MODELO_NF_CNF";
            this.mODELONFCNFDataGridViewTextBoxColumn.Name = "mODELONFCNFDataGridViewTextBoxColumn";
            this.mODELONFCNFDataGridViewTextBoxColumn.ReadOnly = true;
            this.mODELONFCNFDataGridViewTextBoxColumn.Visible = false;
            // 
            // sERIENFCNFDataGridViewTextBoxColumn
            // 
            this.sERIENFCNFDataGridViewTextBoxColumn.DataPropertyName = "SERIE_NF_CNF";
            this.sERIENFCNFDataGridViewTextBoxColumn.HeaderText = "SERIE_NF_CNF";
            this.sERIENFCNFDataGridViewTextBoxColumn.Name = "sERIENFCNFDataGridViewTextBoxColumn";
            this.sERIENFCNFDataGridViewTextBoxColumn.ReadOnly = true;
            this.sERIENFCNFDataGridViewTextBoxColumn.Visible = false;
            // 
            // nUMERONFCNFDataGridViewTextBoxColumn
            // 
            this.nUMERONFCNFDataGridViewTextBoxColumn.DataPropertyName = "NUMERO_NF_CNF";
            this.nUMERONFCNFDataGridViewTextBoxColumn.HeaderText = "NUMERO_NF_CNF";
            this.nUMERONFCNFDataGridViewTextBoxColumn.Name = "nUMERONFCNFDataGridViewTextBoxColumn";
            this.nUMERONFCNFDataGridViewTextBoxColumn.ReadOnly = true;
            this.nUMERONFCNFDataGridViewTextBoxColumn.Visible = false;
            // 
            // dATAEMISSAONFCNFDataGridViewTextBoxColumn
            // 
            this.dATAEMISSAONFCNFDataGridViewTextBoxColumn.DataPropertyName = "DATA_EMISSAO_NF_CNF";
            this.dATAEMISSAONFCNFDataGridViewTextBoxColumn.HeaderText = "DATA_EMISSAO_NF_CNF";
            this.dATAEMISSAONFCNFDataGridViewTextBoxColumn.Name = "dATAEMISSAONFCNFDataGridViewTextBoxColumn";
            this.dATAEMISSAONFCNFDataGridViewTextBoxColumn.ReadOnly = true;
            this.dATAEMISSAONFCNFDataGridViewTextBoxColumn.Visible = false;
            // 
            // vALORBCICMSNFCNFDataGridViewTextBoxColumn
            // 
            this.vALORBCICMSNFCNFDataGridViewTextBoxColumn.DataPropertyName = "VALOR_BC_ICMS_NF_CNF";
            this.vALORBCICMSNFCNFDataGridViewTextBoxColumn.HeaderText = "VALOR_BC_ICMS_NF_CNF";
            this.vALORBCICMSNFCNFDataGridViewTextBoxColumn.Name = "vALORBCICMSNFCNFDataGridViewTextBoxColumn";
            this.vALORBCICMSNFCNFDataGridViewTextBoxColumn.ReadOnly = true;
            this.vALORBCICMSNFCNFDataGridViewTextBoxColumn.Visible = false;
            // 
            // vALORTOTALICMSNFCNFDataGridViewTextBoxColumn
            // 
            this.vALORTOTALICMSNFCNFDataGridViewTextBoxColumn.DataPropertyName = "VALOR_TOTAL_ICMS_NF_CNF";
            this.vALORTOTALICMSNFCNFDataGridViewTextBoxColumn.HeaderText = "VALOR_TOTAL_ICMS_NF_CNF";
            this.vALORTOTALICMSNFCNFDataGridViewTextBoxColumn.Name = "vALORTOTALICMSNFCNFDataGridViewTextBoxColumn";
            this.vALORTOTALICMSNFCNFDataGridViewTextBoxColumn.ReadOnly = true;
            this.vALORTOTALICMSNFCNFDataGridViewTextBoxColumn.Visible = false;
            // 
            // vALORBCICMSSTNFCNFDataGridViewTextBoxColumn
            // 
            this.vALORBCICMSSTNFCNFDataGridViewTextBoxColumn.DataPropertyName = "VALOR_BC_ICMS_ST_NF_CNF";
            this.vALORBCICMSSTNFCNFDataGridViewTextBoxColumn.HeaderText = "VALOR_BC_ICMS_ST_NF_CNF";
            this.vALORBCICMSSTNFCNFDataGridViewTextBoxColumn.Name = "vALORBCICMSSTNFCNFDataGridViewTextBoxColumn";
            this.vALORBCICMSSTNFCNFDataGridViewTextBoxColumn.ReadOnly = true;
            this.vALORBCICMSSTNFCNFDataGridViewTextBoxColumn.Visible = false;
            // 
            // vALORTOTALICMSSTNFCNFDataGridViewTextBoxColumn
            // 
            this.vALORTOTALICMSSTNFCNFDataGridViewTextBoxColumn.DataPropertyName = "VALOR_TOTAL_ICMS_ST_NF_CNF";
            this.vALORTOTALICMSSTNFCNFDataGridViewTextBoxColumn.HeaderText = "VALOR_TOTAL_ICMS_ST_NF_CNF";
            this.vALORTOTALICMSSTNFCNFDataGridViewTextBoxColumn.Name = "vALORTOTALICMSSTNFCNFDataGridViewTextBoxColumn";
            this.vALORTOTALICMSSTNFCNFDataGridViewTextBoxColumn.ReadOnly = true;
            this.vALORTOTALICMSSTNFCNFDataGridViewTextBoxColumn.Visible = false;
            // 
            // vALORTOTALPRODNFCNFDataGridViewTextBoxColumn
            // 
            this.vALORTOTALPRODNFCNFDataGridViewTextBoxColumn.DataPropertyName = "VALOR_TOTAL_PROD_NF_CNF";
            this.vALORTOTALPRODNFCNFDataGridViewTextBoxColumn.HeaderText = "VALOR_TOTAL_PROD_NF_CNF";
            this.vALORTOTALPRODNFCNFDataGridViewTextBoxColumn.Name = "vALORTOTALPRODNFCNFDataGridViewTextBoxColumn";
            this.vALORTOTALPRODNFCNFDataGridViewTextBoxColumn.ReadOnly = true;
            this.vALORTOTALPRODNFCNFDataGridViewTextBoxColumn.Visible = false;
            // 
            // vALORTOTALNFCNFDataGridViewTextBoxColumn
            // 
            this.vALORTOTALNFCNFDataGridViewTextBoxColumn.DataPropertyName = "VALOR_TOTAL_NF_CNF";
            this.vALORTOTALNFCNFDataGridViewTextBoxColumn.HeaderText = "VALOR_TOTAL_NF_CNF";
            this.vALORTOTALNFCNFDataGridViewTextBoxColumn.Name = "vALORTOTALNFCNFDataGridViewTextBoxColumn";
            this.vALORTOTALNFCNFDataGridViewTextBoxColumn.ReadOnly = true;
            this.vALORTOTALNFCNFDataGridViewTextBoxColumn.Visible = false;
            // 
            // cFOPNFCNFDataGridViewTextBoxColumn
            // 
            this.cFOPNFCNFDataGridViewTextBoxColumn.DataPropertyName = "CFOP_NF_CNF";
            this.cFOPNFCNFDataGridViewTextBoxColumn.HeaderText = "CFOP_NF_CNF";
            this.cFOPNFCNFDataGridViewTextBoxColumn.Name = "cFOPNFCNFDataGridViewTextBoxColumn";
            this.cFOPNFCNFDataGridViewTextBoxColumn.ReadOnly = true;
            this.cFOPNFCNFDataGridViewTextBoxColumn.Visible = false;
            // 
            // pESOTOTALKGNFCNFDataGridViewTextBoxColumn
            // 
            this.pESOTOTALKGNFCNFDataGridViewTextBoxColumn.DataPropertyName = "PESO_TOTAL_KG_NF_CNF";
            this.pESOTOTALKGNFCNFDataGridViewTextBoxColumn.HeaderText = "PESO_TOTAL_KG_NF_CNF";
            this.pESOTOTALKGNFCNFDataGridViewTextBoxColumn.Name = "pESOTOTALKGNFCNFDataGridViewTextBoxColumn";
            this.pESOTOTALKGNFCNFDataGridViewTextBoxColumn.ReadOnly = true;
            this.pESOTOTALKGNFCNFDataGridViewTextBoxColumn.Visible = false;
            // 
            // sUFRAMANFCNFDataGridViewTextBoxColumn
            // 
            this.sUFRAMANFCNFDataGridViewTextBoxColumn.DataPropertyName = "SUFRAMA_NF_CNF";
            this.sUFRAMANFCNFDataGridViewTextBoxColumn.HeaderText = "SUFRAMA_NF_CNF";
            this.sUFRAMANFCNFDataGridViewTextBoxColumn.Name = "sUFRAMANFCNFDataGridViewTextBoxColumn";
            this.sUFRAMANFCNFDataGridViewTextBoxColumn.ReadOnly = true;
            this.sUFRAMANFCNFDataGridViewTextBoxColumn.Visible = false;
            // 
            // form_pesquisa_faturamento_cte_detalhado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 666);
            this.Controls.Add(this.panel1);
            this.Name = "form_pesquisa_faturamento_cte_detalhado";
            this.Text = "Faturamento CTe Detalhado";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFatura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCte_notas_fiscais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CTE_NOTAS_FISCAIS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox comboStatus;
        private System.Windows.Forms.CheckBox cbStatus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox cbSomar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.TextBox tb_tomador_cnpj;
        private System.Windows.Forms.CheckBox cbTomador;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.TextBox tb_tomador_nome;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox cbData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtTermino;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_tomador;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_recebedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_remetente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_cte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private System.Windows.Forms.DataGridView dgvFatura;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datCte_notas_fiscais;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand8;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand6;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand5;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand7;
        private System.Data.DataSet dsCte_notas_fiscais;
        private System.Data.DataTable CTE_NOTAS_FISCAIS;
        private System.Data.DataColumn COD_CNF;
        private System.Data.DataColumn N_NF_CNF;
        private System.Data.DataColumn CHAVE_NF_CNF;
        private System.Data.DataColumn COD_CTE_CNF;
        private System.Data.DataColumn VALOR_NOTA_CNF;
        private System.Data.DataColumn PESO_NOTA_CNF;
        private System.Data.DataColumn CUBAGEM_NOTA_NF;
        private System.Data.DataColumn VOLUMES_NOTA_CNF;
        private System.Data.DataColumn MODELO_NF_CNF;
        private System.Data.DataColumn SERIE_NF_CNF;
        private System.Data.DataColumn NUMERO_NF_CNF;
        private System.Data.DataColumn DATA_EMISSAO_NF_CNF;
        private System.Data.DataColumn VALOR_BC_ICMS_NF_CNF;
        private System.Data.DataColumn VALOR_TOTAL_ICMS_NF_CNF;
        private System.Data.DataColumn VALOR_BC_ICMS_ST_NF_CNF;
        private System.Data.DataColumn VALOR_TOTAL_ICMS_ST_NF_CNF;
        private System.Data.DataColumn VALOR_TOTAL_PROD_NF_CNF;
        private System.Data.DataColumn VALOR_TOTAL_NF_CNF;
        private System.Data.DataColumn CFOP_NF_CNF;
        private System.Data.DataColumn PESO_TOTAL_KG_NF_CNF;
        private System.Data.DataColumn SUFRAMA_NF_CNF;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODCNFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nNFCNFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHAVENFCNFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODCTECNFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORNOTACNFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pESONOTACNFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUBAGEMNOTANFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vOLUMESNOTACNFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mODELONFCNFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sERIENFCNFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMERONFCNFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAEMISSAONFCNFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORBCICMSNFCNFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORTOTALICMSNFCNFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORBCICMSSTNFCNFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORTOTALICMSSTNFCNFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORTOTALPRODNFCNFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORTOTALNFCNFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFOPNFCNFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pESOTOTALKGNFCNFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUFRAMANFCNFDataGridViewTextBoxColumn;

    }
}