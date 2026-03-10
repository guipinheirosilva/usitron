namespace Evolucao
{
    partial class form_sub
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_sub));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dsSub = new System.Data.DataSet();
            this.SUB = new System.Data.DataTable();
            this.COD_SUB = new System.Data.DataColumn();
            this.COD_PECA_SUB = new System.Data.DataColumn();
            this.NOME_PECA_SUB = new System.Data.DataColumn();
            this.REVISAO_SUB = new System.Data.DataColumn();
            this.MATERIAL_SUB = new System.Data.DataColumn();
            this.ESPESSURA_SUB = new System.Data.DataColumn();
            this.CLIENTE_SUB = new System.Data.DataColumn();
            this.ROTA_SUB = new System.Data.DataColumn();
            this.QTDE_CONJUNTO_SUB = new System.Data.DataColumn();
            this.LETRA_SUB = new System.Data.DataColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.apaga_registro = new System.Windows.Forms.Button();
            this.salva_registro = new System.Windows.Forms.Button();
            this.novo_registro = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.espessura_des = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.material_des = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.revisao_des = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cod_peca_desenhos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand5 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand6 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand7 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand8 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand12 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand10 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand9 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand11 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand16 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand14 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand13 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand15 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.tbN_sub = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbRotas = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.datRotas = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand24 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand22 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand21 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand23 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.datTipos_operacoes = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand20 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand18 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand17 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand19 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsTiposdeoperacoes = new System.Data.DataSet();
            this.TIPOS_OPERACOES = new System.Data.DataTable();
            this.COD_TIPO = new System.Data.DataColumn();
            this.QDE_MAQUINAS = new System.Data.DataColumn();
            this.TIPO = new System.Data.DataColumn();
            this.datSub = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand28 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand26 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand25 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand27 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.cbSub = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.fbCommand29 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand30 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand31 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand32 = new FirebirdSql.Data.FirebirdClient.FbCommand();
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
            this.datClientes = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand36 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand34 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand33 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand35 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cODROTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPERACAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.desenho_coluna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOSICAOFILADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oBSERVACAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsRotas = new System.Data.DataSet();
            this.ROTAS = new System.Data.DataTable();
            this.COD_ROTA = new System.Data.DataColumn();
            this.OPERACAO = new System.Data.DataColumn();
            this.OBSERVACAO = new System.Data.DataColumn();
            this.DESENHO = new System.Data.DataColumn();
            this.POSICAO_FILA = new System.Data.DataColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvOp = new System.Windows.Forms.DataGridView();
            this.cod_op_coluna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAPDFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nPDFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNTREGADIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNTREGOUDIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRECOUNITDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONDPGTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pESOTOTALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pDFACEITOEMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nFNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qDEPDFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qDEESTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qDEFABDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qDEEMBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qDECAIXASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desenho_op_atual_coluna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsOp = new System.Data.DataSet();
            this.OP = new System.Data.DataTable();
            this.COD_OP = new System.Data.DataColumn();
            this.DATA_PDF = new System.Data.DataColumn();
            this.N_PDF = new System.Data.DataColumn();
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
            this.abre_op = new System.Windows.Forms.Button();
            this.datOp = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand40 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand38 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand37 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand39 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand41 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand42 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand43 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand44 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            ((System.ComponentModel.ISupportInitialize)(this.dsSub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SUB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposdeoperacoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TIPOS_OPERACOES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CLIENTES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ROTAS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OP)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSub, "SUB.NOME_PECA_SUB", true));
            this.textBox1.Location = new System.Drawing.Point(424, 98);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(273, 20);
            this.textBox1.TabIndex = 2;
            // 
            // dsSub
            // 
            this.dsSub.DataSetName = "DSsUB";
            this.dsSub.Namespace = "http://www.tempuri.org/DSsUB.xsd";
            this.dsSub.Tables.AddRange(new System.Data.DataTable[] {
            this.SUB});
            // 
            // SUB
            // 
            this.SUB.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_SUB,
            this.COD_PECA_SUB,
            this.NOME_PECA_SUB,
            this.REVISAO_SUB,
            this.MATERIAL_SUB,
            this.ESPESSURA_SUB,
            this.CLIENTE_SUB,
            this.ROTA_SUB,
            this.QTDE_CONJUNTO_SUB,
            this.LETRA_SUB});
            this.SUB.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_SUB"}, false)});
            this.SUB.TableName = "SUB";
            // 
            // COD_SUB
            // 
            this.COD_SUB.AutoIncrement = true;
            this.COD_SUB.ColumnName = "COD_SUB";
            this.COD_SUB.DataType = typeof(int);
            // 
            // COD_PECA_SUB
            // 
            this.COD_PECA_SUB.ColumnName = "COD_PECA_SUB";
            this.COD_PECA_SUB.MaxLength = 30;
            // 
            // NOME_PECA_SUB
            // 
            this.NOME_PECA_SUB.ColumnName = "NOME_PECA_SUB";
            this.NOME_PECA_SUB.MaxLength = 60;
            // 
            // REVISAO_SUB
            // 
            this.REVISAO_SUB.ColumnName = "REVISAO_SUB";
            this.REVISAO_SUB.MaxLength = 20;
            // 
            // MATERIAL_SUB
            // 
            this.MATERIAL_SUB.ColumnName = "MATERIAL_SUB";
            this.MATERIAL_SUB.MaxLength = 20;
            // 
            // ESPESSURA_SUB
            // 
            this.ESPESSURA_SUB.ColumnName = "ESPESSURA_SUB";
            this.ESPESSURA_SUB.MaxLength = 20;
            // 
            // CLIENTE_SUB
            // 
            this.CLIENTE_SUB.ColumnName = "CLIENTE_SUB";
            this.CLIENTE_SUB.MaxLength = 50;
            // 
            // ROTA_SUB
            // 
            this.ROTA_SUB.ColumnName = "ROTA_SUB";
            this.ROTA_SUB.DataType = typeof(int);
            // 
            // QTDE_CONJUNTO_SUB
            // 
            this.QTDE_CONJUNTO_SUB.ColumnName = "QTDE_CONJUNTO_SUB";
            this.QTDE_CONJUNTO_SUB.DataType = typeof(int);
            // 
            // LETRA_SUB
            // 
            this.LETRA_SUB.ColumnName = "LETRA_SUB";
            this.LETRA_SUB.MaxLength = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 121;
            this.label1.Text = "Nome da Peça:";
            // 
            // apaga_registro
            // 
            this.apaga_registro.Location = new System.Drawing.Point(68, 485);
            this.apaga_registro.Name = "apaga_registro";
            this.apaga_registro.Size = new System.Drawing.Size(49, 22);
            this.apaga_registro.TabIndex = 118;
            this.apaga_registro.Text = "Excluir";
            this.apaga_registro.UseVisualStyleBackColor = true;
            // 
            // salva_registro
            // 
            this.salva_registro.Location = new System.Drawing.Point(123, 485);
            this.salva_registro.Name = "salva_registro";
            this.salva_registro.Size = new System.Drawing.Size(49, 22);
            this.salva_registro.TabIndex = 117;
            this.salva_registro.Text = "Salvar";
            this.salva_registro.UseVisualStyleBackColor = true;
            this.salva_registro.Click += new System.EventHandler(this.salva_registro_Click);
            // 
            // novo_registro
            // 
            this.novo_registro.Location = new System.Drawing.Point(13, 485);
            this.novo_registro.Name = "novo_registro";
            this.novo_registro.Size = new System.Drawing.Size(49, 22);
            this.novo_registro.TabIndex = 112;
            this.novo_registro.Text = "Novo";
            this.novo_registro.UseVisualStyleBackColor = true;
            this.novo_registro.Click += new System.EventHandler(this.novo_registro_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(12, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 26);
            this.label4.TabIndex = 110;
            this.label4.Text = "Rota:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label20.Location = new System.Drawing.Point(4, 34);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(430, 46);
            this.label20.TabIndex = 109;
            this.label20.Text = "SUB-COMPONENTES";
            // 
            // espessura_des
            // 
            this.espessura_des.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSub, "SUB.ESPESSURA_SUB", true));
            this.espessura_des.Location = new System.Drawing.Point(571, 127);
            this.espessura_des.Name = "espessura_des";
            this.espessura_des.Size = new System.Drawing.Size(126, 20);
            this.espessura_des.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(509, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 106;
            this.label5.Text = "Espessura:";
            // 
            // material_des
            // 
            this.material_des.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSub, "SUB.MATERIAL_SUB", true));
            this.material_des.Location = new System.Drawing.Point(351, 124);
            this.material_des.Name = "material_des";
            this.material_des.Size = new System.Drawing.Size(136, 20);
            this.material_des.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(261, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 104;
            this.label6.Text = "Material:";
            // 
            // revisao_des
            // 
            this.revisao_des.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSub, "SUB.REVISAO_SUB", true));
            this.revisao_des.Location = new System.Drawing.Point(111, 124);
            this.revisao_des.Name = "revisao_des";
            this.revisao_des.Size = new System.Drawing.Size(136, 20);
            this.revisao_des.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 102;
            this.label3.Text = "Revisão:";
            // 
            // cod_peca_desenhos
            // 
            this.cod_peca_desenhos.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSub, "SUB.COD_PECA_SUB", true));
            this.cod_peca_desenhos.Location = new System.Drawing.Point(111, 98);
            this.cod_peca_desenhos.Name = "cod_peca_desenhos";
            this.cod_peca_desenhos.Size = new System.Drawing.Size(178, 20);
            this.cod_peca_desenhos.TabIndex = 1;
            this.cod_peca_desenhos.TextChanged += new System.EventHandler(this.cod_peca_desenhos_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 100;
            this.label2.Text = "Código da Peça:";
            // 
            // fbConnection1
            // 
            this.fbConnection1.ConnectionString = resources.GetString("fbConnection1.ConnectionString");
            // 
            // fbCommand1
            // 
            this.fbCommand1.CommandText = "SELECT * FROM SUB-COMPONENTES";
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
            // fbCommand5
            // 
            this.fbCommand5.CommandText = "SELECT * FROM SUB-COMPONENTES";
            this.fbCommand5.CommandTimeout = 30;
            this.fbCommand5.Connection = this.fbConnection1;
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
            // fbCommand12
            // 
            this.fbCommand12.CommandTimeout = 30;
            this.fbCommand12.Connection = this.fbConnection1;
            // 
            // fbCommand10
            // 
            this.fbCommand10.CommandText = "SELECT * FROM SUB";
            this.fbCommand10.CommandTimeout = 30;
            this.fbCommand10.Connection = this.fbConnection1;
            // 
            // fbCommand9
            // 
            this.fbCommand9.CommandText = "SELECT * FROM SUB";
            this.fbCommand9.CommandTimeout = 30;
            this.fbCommand9.Connection = this.fbConnection1;
            // 
            // fbCommand11
            // 
            this.fbCommand11.CommandText = "SELECT * FROM SUB";
            this.fbCommand11.CommandTimeout = 30;
            this.fbCommand11.Connection = this.fbConnection1;
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
            this.fbCommand13.CommandText = "select * from rotas";
            this.fbCommand13.CommandTimeout = 30;
            this.fbCommand13.Connection = this.fbConnection1;
            // 
            // fbCommand15
            // 
            this.fbCommand15.CommandTimeout = 30;
            // 
            // tbN_sub
            // 
            this.tbN_sub.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSub, "SUB.QTDE_CONJUNTO_SUB", true));
            this.tbN_sub.Location = new System.Drawing.Point(111, 150);
            this.tbN_sub.Name = "tbN_sub";
            this.tbN_sub.Size = new System.Drawing.Size(62, 20);
            this.tbN_sub.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 123;
            this.label7.Text = "Qtde por Conjunto:";
            // 
            // cbRotas
            // 
            this.cbRotas.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbRotas.DataAdapter = this.datRotas;
            this.cbRotas.QuotePrefix = "\"";
            this.cbRotas.QuoteSuffix = "\"";
            // 
            // datRotas
            // 
            this.datRotas.DeleteCommand = this.fbCommand24;
            this.datRotas.InsertCommand = this.fbCommand22;
            this.datRotas.SelectCommand = this.fbCommand21;
            this.datRotas.UpdateCommand = this.fbCommand23;
            // 
            // fbCommand24
            // 
            this.fbCommand24.CommandTimeout = 30;
            this.fbCommand24.Connection = this.fbConnection1;
            // 
            // fbCommand22
            // 
            this.fbCommand22.CommandTimeout = 30;
            this.fbCommand22.Connection = this.fbConnection1;
            // 
            // fbCommand21
            // 
            this.fbCommand21.CommandText = "select * from rotas\r\n";
            this.fbCommand21.CommandTimeout = 30;
            this.fbCommand21.Connection = this.fbConnection1;
            // 
            // fbCommand23
            // 
            this.fbCommand23.CommandTimeout = 30;
            this.fbCommand23.Connection = this.fbConnection1;
            // 
            // datTipos_operacoes
            // 
            this.datTipos_operacoes.DeleteCommand = this.fbCommand20;
            this.datTipos_operacoes.InsertCommand = this.fbCommand18;
            this.datTipos_operacoes.SelectCommand = this.fbCommand17;
            this.datTipos_operacoes.UpdateCommand = this.fbCommand19;
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
            this.fbCommand17.CommandText = "SELECT * FROM TIPOS_OPERACOES";
            this.fbCommand17.CommandTimeout = 30;
            this.fbCommand17.Connection = this.fbConnection1;
            // 
            // fbCommand19
            // 
            this.fbCommand19.CommandTimeout = 30;
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
            // datSub
            // 
            this.datSub.DeleteCommand = this.fbCommand28;
            this.datSub.InsertCommand = this.fbCommand26;
            this.datSub.SelectCommand = this.fbCommand25;
            this.datSub.UpdateCommand = this.fbCommand27;
            // 
            // fbCommand28
            // 
            this.fbCommand28.CommandText = "DELETE FROM \"SUB\" WHERE (((@p1 = 1 AND \"COD_SUB\" IS NULL) OR (\"COD_SUB\" = @p2)))";
            this.fbCommand28.CommandTimeout = 30;
            this.fbCommand28.Connection = this.fbConnection1;
            this.fbCommand28.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p1", FirebirdSql.Data.FirebirdClient.FbDbType.Integer, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "COD_SUB", System.Data.DataRowVersion.Original, 1));
            this.fbCommand28.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p2", FirebirdSql.Data.FirebirdClient.FbDbType.Integer, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "COD_SUB", System.Data.DataRowVersion.Original, ((object)(resources.GetObject("fbCommand28.Parameters")))));
            // 
            // fbCommand26
            // 
            this.fbCommand26.CommandText = resources.GetString("fbCommand26.CommandText");
            this.fbCommand26.CommandTimeout = 30;
            this.fbCommand26.Connection = this.fbConnection1;
            this.fbCommand26.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p1", FirebirdSql.Data.FirebirdClient.FbDbType.Integer, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "COD_SUB", System.Data.DataRowVersion.Current, ((object)(resources.GetObject("fbCommand26.Parameters")))));
            this.fbCommand26.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p2", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "COD_PECA_SUB", System.Data.DataRowVersion.Current, ((object)(resources.GetObject("fbCommand26.Parameters1")))));
            this.fbCommand26.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p3", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 60, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "NOME_PECA_SUB", System.Data.DataRowVersion.Current, ((object)(resources.GetObject("fbCommand26.Parameters2")))));
            this.fbCommand26.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p4", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "REVISAO_SUB", System.Data.DataRowVersion.Current, ((object)(resources.GetObject("fbCommand26.Parameters3")))));
            this.fbCommand26.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p5", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MATERIAL_SUB", System.Data.DataRowVersion.Current, ((object)(resources.GetObject("fbCommand26.Parameters4")))));
            this.fbCommand26.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p6", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ESPESSURA_SUB", System.Data.DataRowVersion.Current, ((object)(resources.GetObject("fbCommand26.Parameters5")))));
            this.fbCommand26.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p7", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CLIENTE_SUB", System.Data.DataRowVersion.Current, ((object)(resources.GetObject("fbCommand26.Parameters6")))));
            this.fbCommand26.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p8", FirebirdSql.Data.FirebirdClient.FbDbType.Integer, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ROTA_SUB", System.Data.DataRowVersion.Current, ((object)(resources.GetObject("fbCommand26.Parameters7")))));
            this.fbCommand26.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p9", FirebirdSql.Data.FirebirdClient.FbDbType.Integer, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "QTDE_CONJUNTO_SUB", System.Data.DataRowVersion.Current, ((object)(resources.GetObject("fbCommand26.Parameters8")))));
            this.fbCommand26.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p10", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LETRA_SUB", System.Data.DataRowVersion.Current, ((object)(resources.GetObject("fbCommand26.Parameters9")))));
            // 
            // fbCommand25
            // 
            this.fbCommand25.CommandText = "SELECT * FROM sub";
            this.fbCommand25.CommandTimeout = 30;
            this.fbCommand25.Connection = this.fbConnection1;
            // 
            // fbCommand27
            // 
            this.fbCommand27.CommandText = resources.GetString("fbCommand27.CommandText");
            this.fbCommand27.CommandTimeout = 30;
            this.fbCommand27.Connection = this.fbConnection1;
            this.fbCommand27.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p1", FirebirdSql.Data.FirebirdClient.FbDbType.Integer, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "COD_SUB", System.Data.DataRowVersion.Current, ((object)(resources.GetObject("fbCommand27.Parameters")))));
            this.fbCommand27.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p2", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "COD_PECA_SUB", System.Data.DataRowVersion.Current, ((object)(resources.GetObject("fbCommand27.Parameters1")))));
            this.fbCommand27.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p3", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 60, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "NOME_PECA_SUB", System.Data.DataRowVersion.Current, ((object)(resources.GetObject("fbCommand27.Parameters2")))));
            this.fbCommand27.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p4", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "REVISAO_SUB", System.Data.DataRowVersion.Current, ((object)(resources.GetObject("fbCommand27.Parameters3")))));
            this.fbCommand27.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p5", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MATERIAL_SUB", System.Data.DataRowVersion.Current, ((object)(resources.GetObject("fbCommand27.Parameters4")))));
            this.fbCommand27.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p6", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ESPESSURA_SUB", System.Data.DataRowVersion.Current, ((object)(resources.GetObject("fbCommand27.Parameters5")))));
            this.fbCommand27.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p7", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CLIENTE_SUB", System.Data.DataRowVersion.Current, ((object)(resources.GetObject("fbCommand27.Parameters6")))));
            this.fbCommand27.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p8", FirebirdSql.Data.FirebirdClient.FbDbType.Integer, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ROTA_SUB", System.Data.DataRowVersion.Current, ((object)(resources.GetObject("fbCommand27.Parameters7")))));
            this.fbCommand27.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p9", FirebirdSql.Data.FirebirdClient.FbDbType.Integer, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "QTDE_CONJUNTO_SUB", System.Data.DataRowVersion.Current, ((object)(resources.GetObject("fbCommand27.Parameters8")))));
            this.fbCommand27.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p10", FirebirdSql.Data.FirebirdClient.FbDbType.VarChar, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LETRA_SUB", System.Data.DataRowVersion.Current, ((object)(resources.GetObject("fbCommand27.Parameters9")))));
            this.fbCommand27.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p11", FirebirdSql.Data.FirebirdClient.FbDbType.Integer, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "COD_SUB", System.Data.DataRowVersion.Original, 1));
            this.fbCommand27.Parameters.Add(new FirebirdSql.Data.FirebirdClient.FbParameter("@p12", FirebirdSql.Data.FirebirdClient.FbDbType.Integer, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "COD_SUB", System.Data.DataRowVersion.Original, ((object)(resources.GetObject("fbCommand27.Parameters10")))));
            // 
            // cbSub
            // 
            this.cbSub.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbSub.DataAdapter = this.datSub;
            this.cbSub.QuotePrefix = "\"";
            this.cbSub.QuoteSuffix = "\"";
            // 
            // fbCommand29
            // 
            this.fbCommand29.CommandText = "select * from desenhos, sub";
            this.fbCommand29.CommandTimeout = 30;
            this.fbCommand29.Connection = this.fbConnection1;
            // 
            // fbCommand30
            // 
            this.fbCommand30.CommandTimeout = 30;
            // 
            // fbCommand31
            // 
            this.fbCommand31.CommandTimeout = 30;
            // 
            // fbCommand32
            // 
            this.fbCommand32.CommandTimeout = 30;
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
            this.CNPJ.DataType = typeof(int);
            // 
            // datClientes
            // 
            this.datClientes.DeleteCommand = this.fbCommand36;
            this.datClientes.InsertCommand = this.fbCommand34;
            this.datClientes.SelectCommand = this.fbCommand33;
            this.datClientes.UpdateCommand = this.fbCommand35;
            // 
            // fbCommand36
            // 
            this.fbCommand36.CommandTimeout = 30;
            // 
            // fbCommand34
            // 
            this.fbCommand34.CommandTimeout = 30;
            // 
            // fbCommand33
            // 
            this.fbCommand33.CommandText = "select * from clientes";
            this.fbCommand33.CommandTimeout = 30;
            this.fbCommand33.Connection = this.fbConnection1;
            // 
            // fbCommand35
            // 
            this.fbCommand35.CommandTimeout = 30;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODROTADataGridViewTextBoxColumn,
            this.oPERACAODataGridViewTextBoxColumn,
            this.desenho_coluna,
            this.pOSICAOFILADataGridViewTextBoxColumn,
            this.oBSERVACAODataGridViewTextBoxColumn});
            this.dataGridView1.DataMember = "ROTAS";
            this.dataGridView1.DataSource = this.dsRotas;
            this.dataGridView1.Location = new System.Drawing.Point(17, 206);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Size = new System.Drawing.Size(602, 174);
            this.dataGridView1.TabIndex = 125;
            this.dataGridView1.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_RowValidating_1);
            // 
            // cODROTADataGridViewTextBoxColumn
            // 
            this.cODROTADataGridViewTextBoxColumn.DataPropertyName = "COD_ROTA";
            this.cODROTADataGridViewTextBoxColumn.HeaderText = "COD_ROTA";
            this.cODROTADataGridViewTextBoxColumn.Name = "cODROTADataGridViewTextBoxColumn";
            this.cODROTADataGridViewTextBoxColumn.Visible = false;
            // 
            // oPERACAODataGridViewTextBoxColumn
            // 
            this.oPERACAODataGridViewTextBoxColumn.DataPropertyName = "OPERACAO";
            this.oPERACAODataGridViewTextBoxColumn.DataSource = this.dsTiposdeoperacoes;
            this.oPERACAODataGridViewTextBoxColumn.DisplayMember = "TIPOS_OPERACOES.TIPO";
            this.oPERACAODataGridViewTextBoxColumn.HeaderText = "Operação";
            this.oPERACAODataGridViewTextBoxColumn.Name = "oPERACAODataGridViewTextBoxColumn";
            this.oPERACAODataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.oPERACAODataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.oPERACAODataGridViewTextBoxColumn.Width = 150;
            // 
            // desenho_coluna
            // 
            this.desenho_coluna.DataPropertyName = "DESENHO";
            this.desenho_coluna.HeaderText = "DESENHO";
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
            // dsRotas
            // 
            this.dsRotas.DataSetName = "dsRotas";
            this.dsRotas.Namespace = "http://www.tempuri.org/dsRotas.xsd";
            this.dsRotas.Tables.AddRange(new System.Data.DataTable[] {
            this.ROTAS});
            // 
            // ROTAS
            // 
            this.ROTAS.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_ROTA,
            this.OPERACAO,
            this.OBSERVACAO,
            this.DESENHO,
            this.POSICAO_FILA});
            this.ROTAS.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_ROTA"}, false)});
            this.ROTAS.TableName = "ROTAS";
            // 
            // COD_ROTA
            // 
            this.COD_ROTA.AutoIncrement = true;
            this.COD_ROTA.ColumnName = "COD_ROTA";
            this.COD_ROTA.DataType = typeof(int);
            // 
            // OPERACAO
            // 
            this.OPERACAO.ColumnName = "OPERACAO";
            this.OPERACAO.MaxLength = 30;
            // 
            // OBSERVACAO
            // 
            this.OBSERVACAO.ColumnName = "OBSERVACAO";
            this.OBSERVACAO.MaxLength = 60;
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(663, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 13);
            this.label8.TabIndex = 131;
            this.label8.Text = "Para abrir a OP clique abaixo:";
            // 
            // dgvOp
            // 
            this.dgvOp.AutoGenerateColumns = false;
            this.dgvOp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOp.ColumnHeadersVisible = false;
            this.dgvOp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_op_coluna,
            this.dATAPDFDataGridViewTextBoxColumn,
            this.nPDFDataGridViewTextBoxColumn,
            this.eNTREGADIADataGridViewTextBoxColumn,
            this.eNTREGOUDIADataGridViewTextBoxColumn,
            this.pRECOUNITDataGridViewTextBoxColumn,
            this.cONDPGTODataGridViewTextBoxColumn,
            this.pESOTOTALDataGridViewTextBoxColumn,
            this.pDFACEITOEMDataGridViewTextBoxColumn,
            this.nFNDataGridViewTextBoxColumn,
            this.qDEPDFDataGridViewTextBoxColumn,
            this.qDEESTDataGridViewTextBoxColumn,
            this.qDEFABDataGridViewTextBoxColumn,
            this.qDEEMBDataGridViewTextBoxColumn,
            this.qDECAIXASDataGridViewTextBoxColumn,
            this.desenho_op_atual_coluna});
            this.dgvOp.DataMember = "OP";
            this.dgvOp.DataSource = this.dsOp;
            this.dgvOp.Location = new System.Drawing.Point(666, 336);
            this.dgvOp.Name = "dgvOp";
            this.dgvOp.RowHeadersVisible = false;
            this.dgvOp.Size = new System.Drawing.Size(203, 44);
            this.dgvOp.TabIndex = 130;
            this.dgvOp.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOp_CellDoubleClick);
            // 
            // cod_op_coluna
            // 
            this.cod_op_coluna.DataPropertyName = "COD_OP";
            this.cod_op_coluna.HeaderText = "COD_OP";
            this.cod_op_coluna.Name = "cod_op_coluna";
            // 
            // dATAPDFDataGridViewTextBoxColumn
            // 
            this.dATAPDFDataGridViewTextBoxColumn.DataPropertyName = "DATA_PDF";
            this.dATAPDFDataGridViewTextBoxColumn.HeaderText = "DATA_PDF";
            this.dATAPDFDataGridViewTextBoxColumn.Name = "dATAPDFDataGridViewTextBoxColumn";
            this.dATAPDFDataGridViewTextBoxColumn.Visible = false;
            // 
            // nPDFDataGridViewTextBoxColumn
            // 
            this.nPDFDataGridViewTextBoxColumn.DataPropertyName = "N_PDF";
            this.nPDFDataGridViewTextBoxColumn.HeaderText = "N_PDF";
            this.nPDFDataGridViewTextBoxColumn.Name = "nPDFDataGridViewTextBoxColumn";
            this.nPDFDataGridViewTextBoxColumn.Visible = false;
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
            // cONDPGTODataGridViewTextBoxColumn
            // 
            this.cONDPGTODataGridViewTextBoxColumn.DataPropertyName = "COND_PGTO";
            this.cONDPGTODataGridViewTextBoxColumn.HeaderText = "COND_PGTO";
            this.cONDPGTODataGridViewTextBoxColumn.Name = "cONDPGTODataGridViewTextBoxColumn";
            this.cONDPGTODataGridViewTextBoxColumn.Visible = false;
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
            // desenho_op_atual_coluna
            // 
            this.desenho_op_atual_coluna.DataPropertyName = "DESENHO_OP_ATUAL";
            this.desenho_op_atual_coluna.HeaderText = "DESENHO_OP_ATUAL";
            this.desenho_op_atual_coluna.Name = "desenho_op_atual_coluna";
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
            this.N_PDF,
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
            this.DESENHO_OP_ATUAL});
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
            // N_PDF
            // 
            this.N_PDF.ColumnName = "N_PDF";
            this.N_PDF.DataType = typeof(int);
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
            // abre_op
            // 
            this.abre_op.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abre_op.Location = new System.Drawing.Point(666, 206);
            this.abre_op.Name = "abre_op";
            this.abre_op.Size = new System.Drawing.Size(203, 91);
            this.abre_op.TabIndex = 129;
            this.abre_op.Text = "Criar OP";
            this.abre_op.UseVisualStyleBackColor = true;
            this.abre_op.Click += new System.EventHandler(this.abre_op_Click);
            // 
            // datOp
            // 
            this.datOp.DeleteCommand = this.fbCommand40;
            this.datOp.InsertCommand = this.fbCommand38;
            this.datOp.SelectCommand = this.fbCommand37;
            this.datOp.UpdateCommand = this.fbCommand39;
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
            this.fbCommand37.CommandText = "select * from op";
            this.fbCommand37.CommandTimeout = 30;
            this.fbCommand37.Connection = this.fbConnection1;
            // 
            // fbCommand39
            // 
            this.fbCommand39.CommandTimeout = 30;
            // 
            // fbCommand41
            // 
            this.fbCommand41.CommandText = "select * from rotas_peca";
            this.fbCommand41.CommandTimeout = 30;
            this.fbCommand41.Connection = this.fbConnection1;
            // 
            // fbCommand42
            // 
            this.fbCommand42.CommandTimeout = 30;
            // 
            // fbCommand43
            // 
            this.fbCommand43.CommandTimeout = 30;
            // 
            // fbCommand44
            // 
            this.fbCommand44.CommandTimeout = 30;
            // 
            // form_sub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 510);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvOp);
            this.Controls.Add(this.abre_op);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbN_sub);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.apaga_registro);
            this.Controls.Add(this.salva_registro);
            this.Controls.Add(this.novo_registro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.espessura_des);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.material_des);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.revisao_des);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cod_peca_desenhos);
            this.Controls.Add(this.label2);
            this.Name = "form_sub";
            this.Text = "Sub-componentes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.form_sub_FormClosed);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_sub_FormClosing);
            this.Load += new System.EventHandler(this.form_sub_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsSub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SUB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposdeoperacoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TIPOS_OPERACOES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CLIENTES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ROTAS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button apaga_registro;
        private System.Windows.Forms.Button salva_registro;
        private System.Windows.Forms.Button novo_registro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox espessura_des;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox material_des;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox revisao_des;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cod_peca_desenhos;
        private System.Windows.Forms.Label label2;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
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
        private System.Windows.Forms.TextBox tbN_sub;
        private System.Windows.Forms.Label label7;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbRotas;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datTipos_operacoes;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand20;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand18;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand17;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand19;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datRotas;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand24;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand22;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand21;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand23;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datSub;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand28;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand26;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand25;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand27;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbSub;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand32;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand30;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand29;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand31;
        private System.Data.DataSet dsSub;
        private System.Data.DataTable SUB;
        private System.Data.DataColumn COD_SUB;
        private System.Data.DataColumn COD_PECA_SUB;
        private System.Data.DataColumn NOME_PECA_SUB;
        private System.Data.DataColumn REVISAO_SUB;
        private System.Data.DataColumn MATERIAL_SUB;
        private System.Data.DataColumn ESPESSURA_SUB;
        private System.Data.DataColumn CLIENTE_SUB;
        private System.Data.DataColumn ROTA_SUB;
        private System.Data.DataColumn QTDE_CONJUNTO_SUB;
        private System.Data.DataColumn LETRA_SUB;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datClientes;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand36;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand34;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand33;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand35;
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
        private System.Data.DataSet dsTiposdeoperacoes;
        private System.Data.DataTable TIPOS_OPERACOES;
        private System.Data.DataColumn COD_TIPO;
        private System.Data.DataColumn QDE_MAQUINAS;
        private System.Data.DataColumn TIPO;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvOp;
        private System.Windows.Forms.Button abre_op;
        private System.Data.DataSet dsOp;
        private System.Data.DataTable OP;
        private System.Data.DataColumn COD_OP;
        private System.Data.DataColumn DATA_PDF;
        private System.Data.DataColumn N_PDF;
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
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datOp;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand40;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand38;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand37;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand39;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_op_coluna;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAPDFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nPDFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNTREGADIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNTREGOUDIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRECOUNITDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONDPGTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pESOTOTALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pDFACEITOEMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nFNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qDEPDFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qDEESTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qDEFABDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qDEEMBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qDECAIXASDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn desenho_op_atual_coluna;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand44;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand42;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand41;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand43;
        private System.Data.DataSet dsRotas;
        private System.Data.DataTable ROTAS;
        private System.Data.DataColumn COD_ROTA;
        private System.Data.DataColumn OPERACAO;
        private System.Data.DataColumn OBSERVACAO;
        private System.Data.DataColumn DESENHO;
        private System.Data.DataColumn POSICAO_FILA;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODROTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn oPERACAODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn desenho_coluna;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOSICAOFILADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oBSERVACAODataGridViewTextBoxColumn;
    }
}