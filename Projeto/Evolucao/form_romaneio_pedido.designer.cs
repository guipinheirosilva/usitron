namespace Evolucao
{
    partial class form_romaneio_pedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_romaneio_pedido));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button8 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.novo_registro = new System.Windows.Forms.Button();
            this.datRomaneio = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.button1 = new System.Windows.Forms.Button();
            this.dtData_atual = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvRomaneios = new System.Windows.Forms.DataGridView();
            this.col_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR_ROMANEIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pLACAVEICULOROMANEIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VENDEDOR_ROMANEIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOTORISTA_ROMANEIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODMOTORISTAROMANEIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ROTEIRO_ROMANEIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAROMANEIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsRomaneio = new System.Data.DataSet();
            this.ROMANEIO = new System.Data.DataTable();
            this.COD_ROMANEIO = new System.Data.DataColumn();
            this.DATA_ROMANEIO = new System.Data.DataColumn();
            this.PLACA_VEICULO_ROMANEIO = new System.Data.DataColumn();
            this.COD_MOTORISTA_ROMANEIO = new System.Data.DataColumn();
            this.KM_INCIAL_ROMANEIO = new System.Data.DataColumn();
            this.KM_FINAL_ROMANEIO = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn8 = new System.Data.DataColumn();
            this.dataColumn10 = new System.Data.DataColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button23 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtRomaneio = new System.Windows.Forms.TextBox();
            this.button21 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.btnImprimirDia = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button24 = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.tb_vendedor = new System.Windows.Forms.TextBox();
            this.button10 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_nome_motorista = new System.Windows.Forms.TextBox();
            this.button18 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.tb_roteiro = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_placa_novo_romaneio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.salva_registro = new System.Windows.Forms.Button();
            this.tb_romaneio_selecionado = new System.Windows.Forms.TextBox();
            this.labelRomaneio_selecionado = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.tb_valor_entregue = new System.Windows.Forms.TextBox();
            this.button11 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_valor_frete = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tb_chave_cte = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_cod_romaneio = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.tb_valor_total_carga = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_cubagem_total = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_volumes_totais = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_peso_total = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button13 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.button12 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvItens_romaneio = new System.Windows.Forms.DataGridView();
            this.oRDEMENTREGAIRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_devolvido = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.col_ja_devolvido = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.col_cte_coleta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA_CTE_COLETA_IR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEPRECIRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cod_item_romaneio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_romaneio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jUSTIFICATIVARETORNOIRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAENTREGAIRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORAENTREGAIRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rECEBEDORIRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNPJRECEBEDORIRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESTINATARIOIRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNPJDESTINATARIOIRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNDERECORECIRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nRECIRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOMPLEMENTORECIRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bAIRRORECIRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIDADERECIRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_volumes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cubagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_valor_cte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_valor_carga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cnpj_emitente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsItens_romaneio = new System.Data.DataSet();
            this.ITENS_ROMANEIO = new System.Data.DataTable();
            this.COD_ITEM_ROMANEIO = new System.Data.DataColumn();
            this.COD_CTE_IR = new System.Data.DataColumn();
            this.COD_ROMANEIO_IR = new System.Data.DataColumn();
            this.JUSTIFICATIVA_RETORNO_IR = new System.Data.DataColumn();
            this.DATA_ENTREGA_IR = new System.Data.DataColumn();
            this.HORA_ENTREGA_IR = new System.Data.DataColumn();
            this.DESTINATARIO_IR = new System.Data.DataColumn();
            this.CNPJ_DESTINATARIO_IR = new System.Data.DataColumn();
            this.RECEBEDOR_IR = new System.Data.DataColumn();
            this.CNPJ_RECEBEDOR_IR = new System.Data.DataColumn();
            this.ENDERECO_REC_IR = new System.Data.DataColumn();
            this.N_REC_IR = new System.Data.DataColumn();
            this.COMPLEMENTO_REC_IR = new System.Data.DataColumn();
            this.BAIRRO_REC_IR = new System.Data.DataColumn();
            this.CIDADE_REC_IR = new System.Data.DataColumn();
            this.CEP_REC_IR = new System.Data.DataColumn();
            this.PESO_IR = new System.Data.DataColumn();
            this.VOLUMES_IR = new System.Data.DataColumn();
            this.CUBAGEM_IR = new System.Data.DataColumn();
            this.VALOR_CTE_IR = new System.Data.DataColumn();
            this.VALOR_CARGA_IR = new System.Data.DataColumn();
            this.ORDEM_ENTREGA_IR = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataColumn7 = new System.Data.DataColumn();
            this.dataColumn9 = new System.Data.DataColumn();
            this.fbCommand5 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand6 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand7 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand8 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand9 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand10 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand11 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand12 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.datItens_romaneio = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand16 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand14 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand13 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand15 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.cbItens_romaneio = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.cbRomaneio = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.button25 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRomaneios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRomaneio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ROMANEIO)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens_romaneio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsItens_romaneio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITENS_ROMANEIO)).BeginInit();
            this.SuspendLayout();
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(7, 87);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(59, 24);
            this.button8.TabIndex = 271;
            this.button8.Text = "Localizar";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(119, 87);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(49, 24);
            this.button4.TabIndex = 270;
            this.button4.Text = "Excluir";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // novo_registro
            // 
            this.novo_registro.Location = new System.Drawing.Point(4, 1);
            this.novo_registro.Name = "novo_registro";
            this.novo_registro.Size = new System.Drawing.Size(84, 34);
            this.novo_registro.TabIndex = 269;
            this.novo_registro.Text = "Novo Romaneio";
            this.novo_registro.UseVisualStyleBackColor = true;
            this.novo_registro.Click += new System.EventHandler(this.novo_registro_Click);
            // 
            // datRomaneio
            // 
            this.datRomaneio.DeleteCommand = this.fbCommand4;
            this.datRomaneio.InsertCommand = this.fbCommand2;
            this.datRomaneio.SelectCommand = this.fbCommand1;
            this.datRomaneio.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * from romaneio";
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
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(268, 60);
            this.button1.TabIndex = 272;
            this.button1.Text = "Gerar Romaneios do Dia";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dtData_atual
            // 
            this.dtData_atual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtData_atual.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtData_atual.Location = new System.Drawing.Point(12, 78);
            this.dtData_atual.Name = "dtData_atual";
            this.dtData_atual.Size = new System.Drawing.Size(117, 29);
            this.dtData_atual.TabIndex = 273;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(144, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 29);
            this.button2.TabIndex = 274;
            this.button2.Text = "Filtrar Dia";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgvRomaneios
            // 
            this.dgvRomaneios.AllowUserToAddRows = false;
            this.dgvRomaneios.AllowUserToDeleteRows = false;
            this.dgvRomaneios.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRomaneios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRomaneios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRomaneios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_cod,
            this.VALOR_ROMANEIO,
            this.pLACAVEICULOROMANEIODataGridViewTextBoxColumn,
            this.VENDEDOR_ROMANEIO,
            this.MOTORISTA_ROMANEIO,
            this.cODMOTORISTAROMANEIODataGridViewTextBoxColumn,
            this.ROTEIRO_ROMANEIO,
            this.dATAROMANEIODataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1});
            this.dgvRomaneios.DataMember = "ROMANEIO";
            this.dgvRomaneios.DataSource = this.dsRomaneio;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRomaneios.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRomaneios.Location = new System.Drawing.Point(7, 119);
            this.dgvRomaneios.Name = "dgvRomaneios";
            this.dgvRomaneios.RowHeadersWidth = 20;
            this.dgvRomaneios.Size = new System.Drawing.Size(414, 338);
            this.dgvRomaneios.TabIndex = 275;
            this.dgvRomaneios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRomaneios_CellDoubleClick);
            // 
            // col_cod
            // 
            this.col_cod.DataPropertyName = "COD_ROMANEIO";
            this.col_cod.HeaderText = "Cód.";
            this.col_cod.Name = "col_cod";
            this.col_cod.Width = 50;
            // 
            // VALOR_ROMANEIO
            // 
            this.VALOR_ROMANEIO.DataPropertyName = "VALOR_ROMANEIO";
            this.VALOR_ROMANEIO.HeaderText = "Valor Entregue";
            this.VALOR_ROMANEIO.Name = "VALOR_ROMANEIO";
            // 
            // pLACAVEICULOROMANEIODataGridViewTextBoxColumn
            // 
            this.pLACAVEICULOROMANEIODataGridViewTextBoxColumn.DataPropertyName = "PLACA_VEICULO_ROMANEIO";
            this.pLACAVEICULOROMANEIODataGridViewTextBoxColumn.HeaderText = "Veículo";
            this.pLACAVEICULOROMANEIODataGridViewTextBoxColumn.Name = "pLACAVEICULOROMANEIODataGridViewTextBoxColumn";
            this.pLACAVEICULOROMANEIODataGridViewTextBoxColumn.Width = 60;
            // 
            // VENDEDOR_ROMANEIO
            // 
            this.VENDEDOR_ROMANEIO.DataPropertyName = "VENDEDOR_ROMANEIO";
            this.VENDEDOR_ROMANEIO.HeaderText = "Vendedor";
            this.VENDEDOR_ROMANEIO.Name = "VENDEDOR_ROMANEIO";
            // 
            // MOTORISTA_ROMANEIO
            // 
            this.MOTORISTA_ROMANEIO.DataPropertyName = "MOTORISTA_ROMANEIO";
            this.MOTORISTA_ROMANEIO.HeaderText = "Motorista";
            this.MOTORISTA_ROMANEIO.Name = "MOTORISTA_ROMANEIO";
            // 
            // cODMOTORISTAROMANEIODataGridViewTextBoxColumn
            // 
            this.cODMOTORISTAROMANEIODataGridViewTextBoxColumn.DataPropertyName = "COD_MOTORISTA_ROMANEIO";
            this.cODMOTORISTAROMANEIODataGridViewTextBoxColumn.HeaderText = "Cód. Motorista";
            this.cODMOTORISTAROMANEIODataGridViewTextBoxColumn.Name = "cODMOTORISTAROMANEIODataGridViewTextBoxColumn";
            this.cODMOTORISTAROMANEIODataGridViewTextBoxColumn.Visible = false;
            this.cODMOTORISTAROMANEIODataGridViewTextBoxColumn.Width = 70;
            // 
            // ROTEIRO_ROMANEIO
            // 
            this.ROTEIRO_ROMANEIO.DataPropertyName = "ROTEIRO_ROMANEIO";
            this.ROTEIRO_ROMANEIO.HeaderText = "Roteiro";
            this.ROTEIRO_ROMANEIO.Name = "ROTEIRO_ROMANEIO";
            this.ROTEIRO_ROMANEIO.Width = 40;
            // 
            // dATAROMANEIODataGridViewTextBoxColumn
            // 
            this.dATAROMANEIODataGridViewTextBoxColumn.DataPropertyName = "DATA_ROMANEIO";
            this.dATAROMANEIODataGridViewTextBoxColumn.HeaderText = "Data";
            this.dATAROMANEIODataGridViewTextBoxColumn.Name = "dATAROMANEIODataGridViewTextBoxColumn";
            this.dATAROMANEIODataGridViewTextBoxColumn.Width = 80;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "KM_INCIAL_ROMANEIO";
            this.dataGridViewTextBoxColumn1.HeaderText = "Km Inicial";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dsRomaneio
            // 
            this.dsRomaneio.DataSetName = "dsRomaneio";
            this.dsRomaneio.Namespace = "http://www.tempuri.org/dsRomaneio.xsd";
            this.dsRomaneio.Tables.AddRange(new System.Data.DataTable[] {
            this.ROMANEIO});
            // 
            // ROMANEIO
            // 
            this.ROMANEIO.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_ROMANEIO,
            this.DATA_ROMANEIO,
            this.PLACA_VEICULO_ROMANEIO,
            this.COD_MOTORISTA_ROMANEIO,
            this.KM_INCIAL_ROMANEIO,
            this.KM_FINAL_ROMANEIO,
            this.dataColumn3,
            this.dataColumn5,
            this.dataColumn8,
            this.dataColumn10});
            this.ROMANEIO.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_ROMANEIO"}, true)});
            this.ROMANEIO.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_ROMANEIO};
            this.ROMANEIO.TableName = "ROMANEIO";
            // 
            // COD_ROMANEIO
            // 
            this.COD_ROMANEIO.AllowDBNull = false;
            this.COD_ROMANEIO.ColumnName = "COD_ROMANEIO";
            this.COD_ROMANEIO.DataType = typeof(int);
            // 
            // DATA_ROMANEIO
            // 
            this.DATA_ROMANEIO.ColumnName = "DATA_ROMANEIO";
            this.DATA_ROMANEIO.DataType = typeof(System.DateTime);
            // 
            // PLACA_VEICULO_ROMANEIO
            // 
            this.PLACA_VEICULO_ROMANEIO.ColumnName = "PLACA_VEICULO_ROMANEIO";
            this.PLACA_VEICULO_ROMANEIO.MaxLength = 10;
            // 
            // COD_MOTORISTA_ROMANEIO
            // 
            this.COD_MOTORISTA_ROMANEIO.ColumnName = "COD_MOTORISTA_ROMANEIO";
            this.COD_MOTORISTA_ROMANEIO.DataType = typeof(int);
            // 
            // KM_INCIAL_ROMANEIO
            // 
            this.KM_INCIAL_ROMANEIO.ColumnName = "KM_INCIAL_ROMANEIO";
            this.KM_INCIAL_ROMANEIO.DataType = typeof(double);
            // 
            // KM_FINAL_ROMANEIO
            // 
            this.KM_FINAL_ROMANEIO.ColumnName = "KM_FINAL_ROMANEIO";
            this.KM_FINAL_ROMANEIO.DataType = typeof(double);
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "ROTEIRO_ROMANEIO";
            this.dataColumn3.DataType = typeof(int);
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "MOTORISTA_ROMANEIO";
            this.dataColumn5.MaxLength = 100;
            // 
            // dataColumn8
            // 
            this.dataColumn8.ColumnName = "VALOR_ROMANEIO";
            this.dataColumn8.DataType = typeof(double);
            // 
            // dataColumn10
            // 
            this.dataColumn10.ColumnName = "VENDEDOR_ROMANEIO";
            this.dataColumn10.MaxLength = 200;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.button23);
            this.panel1.Controls.Add(this.button22);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.txtRomaneio);
            this.panel1.Controls.Add(this.button21);
            this.panel1.Controls.Add(this.button20);
            this.panel1.Controls.Add(this.button19);
            this.panel1.Controls.Add(this.btnImprimirDia);
            this.panel1.Controls.Add(this.button17);
            this.panel1.Controls.Add(this.button14);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvRomaneios);
            this.panel1.Controls.Add(this.salva_registro);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Location = new System.Drawing.Point(3, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 559);
            this.panel1.TabIndex = 276;
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(303, 470);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(113, 40);
            this.button23.TabIndex = 322;
            this.button23.Text = "Verificar Retorno Venda Direta";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // button22
            // 
            this.button22.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button22.Location = new System.Drawing.Point(109, 470);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(93, 40);
            this.button22.TabIndex = 295;
            this.button22.Text = "Imprimir Romaneio/Itens";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(68, 40);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 23);
            this.btnBuscar.TabIndex = 293;
            this.btnBuscar.Text = "Buscar Romaneio";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtRomaneio
            // 
            this.txtRomaneio.Location = new System.Drawing.Point(9, 41);
            this.txtRomaneio.Name = "txtRomaneio";
            this.txtRomaneio.Size = new System.Drawing.Size(57, 20);
            this.txtRomaneio.TabIndex = 294;
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(10, 470);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(93, 40);
            this.button21.TabIndex = 292;
            this.button21.Text = "Imprimir Troca";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(205, 470);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(93, 40);
            this.button20.TabIndex = 291;
            this.button20.Text = "Imprimir Retornos";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(10, 516);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(93, 40);
            this.button19.TabIndex = 290;
            this.button19.Text = "Imprimir Produtos";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // btnImprimirDia
            // 
            this.btnImprimirDia.Location = new System.Drawing.Point(303, 516);
            this.btnImprimirDia.Name = "btnImprimirDia";
            this.btnImprimirDia.Size = new System.Drawing.Size(113, 40);
            this.btnImprimirDia.TabIndex = 278;
            this.btnImprimirDia.Text = "Imprimir Romaneios do Dia";
            this.btnImprimirDia.UseVisualStyleBackColor = true;
            this.btnImprimirDia.Click += new System.EventHandler(this.btnImprimirDia_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(208, 516);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(90, 40);
            this.button17.TabIndex = 289;
            this.button17.Text = "Finalizar Romaneio";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(109, 516);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(93, 40);
            this.button14.TabIndex = 288;
            this.button14.Text = "Imprimir Romaneio";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel4.Controls.Add(this.button24);
            this.panel4.Controls.Add(this.label19);
            this.panel4.Controls.Add(this.tb_vendedor);
            this.panel4.Controls.Add(this.button10);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.tb_nome_motorista);
            this.panel4.Controls.Add(this.button18);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.tb_roteiro);
            this.panel4.Controls.Add(this.button7);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.tb_placa_novo_romaneio);
            this.panel4.Controls.Add(this.novo_registro);
            this.panel4.Location = new System.Drawing.Point(174, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(247, 107);
            this.panel4.TabIndex = 285;
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(191, 82);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(18, 20);
            this.button24.TabIndex = 296;
            this.button24.Text = "+";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(106, 69);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(102, 13);
            this.label19.TabIndex = 295;
            this.label19.Text = "Nome do Vendedor:";
            // 
            // tb_vendedor
            // 
            this.tb_vendedor.Location = new System.Drawing.Point(106, 82);
            this.tb_vendedor.Name = "tb_vendedor";
            this.tb_vendedor.Size = new System.Drawing.Size(84, 20);
            this.tb_vendedor.TabIndex = 294;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(191, 48);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(18, 20);
            this.button10.TabIndex = 293;
            this.button10.Text = "+";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(106, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 292;
            this.label6.Text = "Nome Motorista:";
            // 
            // tb_nome_motorista
            // 
            this.tb_nome_motorista.Location = new System.Drawing.Point(106, 48);
            this.tb_nome_motorista.Name = "tb_nome_motorista";
            this.tb_nome_motorista.Size = new System.Drawing.Size(84, 20);
            this.tb_nome_motorista.TabIndex = 291;
            this.tb_nome_motorista.TextChanged += new System.EventHandler(this.tb_nome_motorista_TextChanged);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(70, 83);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(18, 20);
            this.button18.TabIndex = 290;
            this.button18.Text = "+";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(15, 69);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 13);
            this.label17.TabIndex = 289;
            this.label17.Text = "Roteiro:";
            // 
            // tb_roteiro
            // 
            this.tb_roteiro.Location = new System.Drawing.Point(4, 83);
            this.tb_roteiro.Name = "tb_roteiro";
            this.tb_roteiro.Size = new System.Drawing.Size(64, 20);
            this.tb_roteiro.TabIndex = 288;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(70, 47);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(18, 20);
            this.button7.TabIndex = 287;
            this.button7.Text = "+";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 284;
            this.label4.Text = "Placa:";
            // 
            // tb_placa_novo_romaneio
            // 
            this.tb_placa_novo_romaneio.Location = new System.Drawing.Point(4, 48);
            this.tb_placa_novo_romaneio.Name = "tb_placa_novo_romaneio";
            this.tb_placa_novo_romaneio.Size = new System.Drawing.Size(64, 20);
            this.tb_placa_novo_romaneio.TabIndex = 283;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 276;
            this.label1.Text = "Romaneios";
            // 
            // salva_registro
            // 
            this.salva_registro.Location = new System.Drawing.Point(68, 87);
            this.salva_registro.Name = "salva_registro";
            this.salva_registro.Size = new System.Drawing.Size(49, 24);
            this.salva_registro.TabIndex = 268;
            this.salva_registro.Text = "Salvar";
            this.salva_registro.UseVisualStyleBackColor = true;
            this.salva_registro.Click += new System.EventHandler(this.salva_registro_Click);
            // 
            // tb_romaneio_selecionado
            // 
            this.tb_romaneio_selecionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_romaneio_selecionado.Location = new System.Drawing.Point(150, 3);
            this.tb_romaneio_selecionado.Name = "tb_romaneio_selecionado";
            this.tb_romaneio_selecionado.ReadOnly = true;
            this.tb_romaneio_selecionado.Size = new System.Drawing.Size(106, 26);
            this.tb_romaneio_selecionado.TabIndex = 289;
            // 
            // labelRomaneio_selecionado
            // 
            this.labelRomaneio_selecionado.AutoSize = true;
            this.labelRomaneio_selecionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRomaneio_selecionado.Location = new System.Drawing.Point(5, 2);
            this.labelRomaneio_selecionado.Name = "labelRomaneio_selecionado";
            this.labelRomaneio_selecionado.Size = new System.Drawing.Size(144, 26);
            this.labelRomaneio_selecionado.TabIndex = 287;
            this.labelRomaneio_selecionado.Text = "Romaneio nº:";
            this.labelRomaneio_selecionado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel5.Controls.Add(this.tb_romaneio_selecionado);
            this.panel5.Controls.Add(this.labelRomaneio_selecionado);
            this.panel5.Location = new System.Drawing.Point(4, 32);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(259, 33);
            this.panel5.TabIndex = 286;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lime;
            this.panel2.Controls.Add(this.button25);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.tb_valor_entregue);
            this.panel2.Controls.Add(this.button11);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.tb_valor_frete);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.tb_chave_cte);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.button16);
            this.panel2.Controls.Add(this.button15);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.tb_valor_total_carga);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.tb_cubagem_total);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.tb_volumes_totais);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.tb_peso_total);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dgvItens_romaneio);
            this.panel2.Location = new System.Drawing.Point(430, 126);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(583, 559);
            this.panel2.TabIndex = 277;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(268, 529);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(135, 20);
            this.label16.TabIndex = 303;
            this.label16.Text = "Valor Entregue:";
            // 
            // tb_valor_entregue
            // 
            this.tb_valor_entregue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_valor_entregue.Location = new System.Drawing.Point(409, 526);
            this.tb_valor_entregue.Name = "tb_valor_entregue";
            this.tb_valor_entregue.Size = new System.Drawing.Size(143, 26);
            this.tb_valor_entregue.TabIndex = 302;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(145, 1);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(118, 29);
            this.button11.TabIndex = 278;
            this.button11.Text = "Selecionar todos Ctes";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Visible = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 529);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 301;
            this.label5.Text = "Valor Frete:";
            // 
            // tb_valor_frete
            // 
            this.tb_valor_frete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_valor_frete.Location = new System.Drawing.Point(122, 526);
            this.tb_valor_frete.Name = "tb_valor_frete";
            this.tb_valor_frete.Size = new System.Drawing.Size(138, 26);
            this.tb_valor_frete.TabIndex = 300;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(16, 102);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(84, 13);
            this.label18.TabIndex = 299;
            this.label18.Text = "Cód. Pedido/NF";
            // 
            // tb_chave_cte
            // 
            this.tb_chave_cte.Location = new System.Drawing.Point(12, 118);
            this.tb_chave_cte.Name = "tb_chave_cte";
            this.tb_chave_cte.Size = new System.Drawing.Size(327, 20);
            this.tb_chave_cte.TabIndex = 298;
            this.tb_chave_cte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_chave_cte_KeyPress);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.button9);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.tb_cod_romaneio);
            this.panel3.Controls.Add(this.button6);
            this.panel3.ForeColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(265, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(100, 61);
            this.panel3.TabIndex = 283;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(78, 38);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(18, 20);
            this.button9.TabIndex = 287;
            this.button9.Text = "+";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 282;
            this.label3.Text = "Cód Romaneio:";
            // 
            // tb_cod_romaneio
            // 
            this.tb_cod_romaneio.Location = new System.Drawing.Point(7, 38);
            this.tb_cod_romaneio.Name = "tb_cod_romaneio";
            this.tb_cod_romaneio.Size = new System.Drawing.Size(70, 20);
            this.tb_cod_romaneio.TabIndex = 281;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(5, 1);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(88, 24);
            this.button6.TabIndex = 280;
            this.button6.Text = "Transferir para:";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(252, 68);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(72, 24);
            this.button16.TabIndex = 297;
            this.button16.Text = "Ordenar";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(141, 68);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(105, 24);
            this.button15.TabIndex = 296;
            this.button15.Text = "Salvar Alterações";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(269, 503);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 13);
            this.label15.TabIndex = 295;
            this.label15.Text = "Valor Total Carga:";
            // 
            // tb_valor_total_carga
            // 
            this.tb_valor_total_carga.Location = new System.Drawing.Point(367, 500);
            this.tb_valor_total_carga.Name = "tb_valor_total_carga";
            this.tb_valor_total_carga.Size = new System.Drawing.Size(90, 20);
            this.tb_valor_total_carga.TabIndex = 294;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(269, 477);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 13);
            this.label14.TabIndex = 293;
            this.label14.Text = "Cubagem Total:";
            // 
            // tb_cubagem_total
            // 
            this.tb_cubagem_total.Location = new System.Drawing.Point(367, 474);
            this.tb_cubagem_total.Name = "tb_cubagem_total";
            this.tb_cubagem_total.Size = new System.Drawing.Size(90, 20);
            this.tb_cubagem_total.TabIndex = 292;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 503);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 13);
            this.label13.TabIndex = 291;
            this.label13.Text = "Volumes Totais:";
            // 
            // tb_volumes_totais
            // 
            this.tb_volumes_totais.Location = new System.Drawing.Point(109, 500);
            this.tb_volumes_totais.Name = "tb_volumes_totais";
            this.tb_volumes_totais.Size = new System.Drawing.Size(100, 20);
            this.tb_volumes_totais.TabIndex = 290;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 477);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 289;
            this.label12.Text = "Peso Total:";
            // 
            // tb_peso_total
            // 
            this.tb_peso_total.Location = new System.Drawing.Point(109, 474);
            this.tb_peso_total.Name = "tb_peso_total";
            this.tb_peso_total.Size = new System.Drawing.Size(100, 20);
            this.tb_peso_total.TabIndex = 288;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.textBox6);
            this.panel6.Controls.Add(this.button13);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.textBox7);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.textBox8);
            this.panel6.Controls.Add(this.button12);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.textBox4);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.textBox5);
            this.panel6.Location = new System.Drawing.Point(371, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(204, 139);
            this.panel6.TabIndex = 287;
            this.panel6.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 299;
            this.label9.Text = "CNPJ Rec.:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(86, 97);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(86, 20);
            this.textBox6.TabIndex = 298;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(176, 74);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(18, 20);
            this.button13.TabIndex = 297;
            this.button13.Text = "+";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 296;
            this.label10.Text = "Recebedor:";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(86, 74);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(86, 20);
            this.textBox7.TabIndex = 295;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 294;
            this.label11.Text = "CNPJ Destin.:";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(86, 51);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(86, 20);
            this.textBox8.TabIndex = 293;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(176, 28);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(18, 20);
            this.button12.TabIndex = 287;
            this.button12.Text = "+";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Destinatário:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(86, 28);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(86, 20);
            this.textBox4.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "CTe:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(86, 5);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(86, 20);
            this.textBox5.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(86, 68);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(49, 24);
            this.button3.TabIndex = 279;
            this.button3.Text = "Excluir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(13, 68);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(67, 24);
            this.button5.TabIndex = 278;
            this.button5.Text = "Adicionar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 276;
            this.label2.Text = "Itens Romaneio";
            // 
            // dgvItens_romaneio
            // 
            this.dgvItens_romaneio.AllowUserToAddRows = false;
            this.dgvItens_romaneio.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvItens_romaneio.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvItens_romaneio.AutoGenerateColumns = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItens_romaneio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvItens_romaneio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens_romaneio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oRDEMENTREGAIRDataGridViewTextBoxColumn,
            this.col_devolvido,
            this.col_ja_devolvido,
            this.col_cte_coleta,
            this.col_nf,
            this.col_tipo,
            this.DATA_CTE_COLETA_IR,
            this.cEPRECIRDataGridViewTextBoxColumn,
            this.col_cod_item_romaneio,
            this.col_romaneio,
            this.jUSTIFICATIVARETORNOIRDataGridViewTextBoxColumn,
            this.dATAENTREGAIRDataGridViewTextBoxColumn,
            this.hORAENTREGAIRDataGridViewTextBoxColumn,
            this.rECEBEDORIRDataGridViewTextBoxColumn,
            this.cNPJRECEBEDORIRDataGridViewTextBoxColumn,
            this.dESTINATARIOIRDataGridViewTextBoxColumn,
            this.cNPJDESTINATARIOIRDataGridViewTextBoxColumn,
            this.eNDERECORECIRDataGridViewTextBoxColumn,
            this.nRECIRDataGridViewTextBoxColumn,
            this.cOMPLEMENTORECIRDataGridViewTextBoxColumn,
            this.bAIRRORECIRDataGridViewTextBoxColumn,
            this.cIDADERECIRDataGridViewTextBoxColumn,
            this.col_peso,
            this.col_volumes,
            this.col_cubagem,
            this.col_valor_cte,
            this.col_valor_carga,
            this.col_cnpj_emitente});
            this.dgvItens_romaneio.DataMember = "ITENS_ROMANEIO";
            this.dgvItens_romaneio.DataSource = this.dsItens_romaneio;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItens_romaneio.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvItens_romaneio.Location = new System.Drawing.Point(12, 144);
            this.dgvItens_romaneio.Name = "dgvItens_romaneio";
            this.dgvItens_romaneio.RowHeadersWidth = 20;
            this.dgvItens_romaneio.Size = new System.Drawing.Size(563, 313);
            this.dgvItens_romaneio.TabIndex = 275;
            this.dgvItens_romaneio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItens_romaneio_CellContentClick);
            // 
            // oRDEMENTREGAIRDataGridViewTextBoxColumn
            // 
            this.oRDEMENTREGAIRDataGridViewTextBoxColumn.DataPropertyName = "ORDEM_ENTREGA_IR";
            this.oRDEMENTREGAIRDataGridViewTextBoxColumn.HeaderText = "Ordem Entrega";
            this.oRDEMENTREGAIRDataGridViewTextBoxColumn.Name = "oRDEMENTREGAIRDataGridViewTextBoxColumn";
            this.oRDEMENTREGAIRDataGridViewTextBoxColumn.Width = 50;
            // 
            // col_devolvido
            // 
            this.col_devolvido.DataPropertyName = "DEVOLVIDO_IR";
            this.col_devolvido.FalseValue = "0";
            this.col_devolvido.HeaderText = "Devol- vido";
            this.col_devolvido.IndeterminateValue = "0";
            this.col_devolvido.Name = "col_devolvido";
            this.col_devolvido.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_devolvido.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_devolvido.TrueValue = "1";
            this.col_devolvido.Width = 50;
            // 
            // col_ja_devolvido
            // 
            this.col_ja_devolvido.DataPropertyName = "JA_DEVOLVIDO_IR";
            this.col_ja_devolvido.FalseValue = "0";
            this.col_ja_devolvido.HeaderText = "Devol- vido Ant.";
            this.col_ja_devolvido.IndeterminateValue = "0";
            this.col_ja_devolvido.Name = "col_ja_devolvido";
            this.col_ja_devolvido.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_ja_devolvido.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_ja_devolvido.TrueValue = "1";
            this.col_ja_devolvido.Width = 50;
            // 
            // col_cte_coleta
            // 
            this.col_cte_coleta.DataPropertyName = "COD_CTE_COLETA_IR";
            this.col_cte_coleta.HeaderText = "Pedido";
            this.col_cte_coleta.Name = "col_cte_coleta";
            this.col_cte_coleta.Width = 70;
            // 
            // col_nf
            // 
            this.col_nf.DataPropertyName = "NF_IR";
            this.col_nf.HeaderText = "NF";
            this.col_nf.Name = "col_nf";
            this.col_nf.Width = 70;
            // 
            // col_tipo
            // 
            this.col_tipo.DataPropertyName = "TIPO_IR";
            this.col_tipo.HeaderText = "Tipo";
            this.col_tipo.Name = "col_tipo";
            this.col_tipo.Width = 70;
            // 
            // DATA_CTE_COLETA_IR
            // 
            this.DATA_CTE_COLETA_IR.DataPropertyName = "DATA_CTE_COLETA_IR";
            this.DATA_CTE_COLETA_IR.HeaderText = "Data CTe/Coleta";
            this.DATA_CTE_COLETA_IR.Name = "DATA_CTE_COLETA_IR";
            this.DATA_CTE_COLETA_IR.Width = 60;
            // 
            // cEPRECIRDataGridViewTextBoxColumn
            // 
            this.cEPRECIRDataGridViewTextBoxColumn.DataPropertyName = "CEP_REC_IR";
            this.cEPRECIRDataGridViewTextBoxColumn.HeaderText = "CEP";
            this.cEPRECIRDataGridViewTextBoxColumn.Name = "cEPRECIRDataGridViewTextBoxColumn";
            this.cEPRECIRDataGridViewTextBoxColumn.Width = 55;
            // 
            // col_cod_item_romaneio
            // 
            this.col_cod_item_romaneio.DataPropertyName = "COD_ITEM_ROMANEIO";
            this.col_cod_item_romaneio.HeaderText = "COD_ITEM_ROMANEIO";
            this.col_cod_item_romaneio.Name = "col_cod_item_romaneio";
            this.col_cod_item_romaneio.Visible = false;
            // 
            // col_romaneio
            // 
            this.col_romaneio.DataPropertyName = "COD_ROMANEIO_IR";
            this.col_romaneio.HeaderText = "COD_ROMANEIO_IR";
            this.col_romaneio.Name = "col_romaneio";
            this.col_romaneio.Visible = false;
            // 
            // jUSTIFICATIVARETORNOIRDataGridViewTextBoxColumn
            // 
            this.jUSTIFICATIVARETORNOIRDataGridViewTextBoxColumn.DataPropertyName = "JUSTIFICATIVA_RETORNO_IR";
            this.jUSTIFICATIVARETORNOIRDataGridViewTextBoxColumn.HeaderText = "Justificativa Retorno";
            this.jUSTIFICATIVARETORNOIRDataGridViewTextBoxColumn.Name = "jUSTIFICATIVARETORNOIRDataGridViewTextBoxColumn";
            // 
            // dATAENTREGAIRDataGridViewTextBoxColumn
            // 
            this.dATAENTREGAIRDataGridViewTextBoxColumn.DataPropertyName = "DATA_ENTREGA_IR";
            this.dATAENTREGAIRDataGridViewTextBoxColumn.HeaderText = "DATA_ENTREGA_IR";
            this.dATAENTREGAIRDataGridViewTextBoxColumn.Name = "dATAENTREGAIRDataGridViewTextBoxColumn";
            this.dATAENTREGAIRDataGridViewTextBoxColumn.Visible = false;
            // 
            // hORAENTREGAIRDataGridViewTextBoxColumn
            // 
            this.hORAENTREGAIRDataGridViewTextBoxColumn.DataPropertyName = "HORA_ENTREGA_IR";
            this.hORAENTREGAIRDataGridViewTextBoxColumn.HeaderText = "HORA_ENTREGA_IR";
            this.hORAENTREGAIRDataGridViewTextBoxColumn.Name = "hORAENTREGAIRDataGridViewTextBoxColumn";
            this.hORAENTREGAIRDataGridViewTextBoxColumn.Visible = false;
            // 
            // rECEBEDORIRDataGridViewTextBoxColumn
            // 
            this.rECEBEDORIRDataGridViewTextBoxColumn.DataPropertyName = "RECEBEDOR_IR";
            this.rECEBEDORIRDataGridViewTextBoxColumn.HeaderText = "Recebedor";
            this.rECEBEDORIRDataGridViewTextBoxColumn.Name = "rECEBEDORIRDataGridViewTextBoxColumn";
            this.rECEBEDORIRDataGridViewTextBoxColumn.Width = 80;
            // 
            // cNPJRECEBEDORIRDataGridViewTextBoxColumn
            // 
            this.cNPJRECEBEDORIRDataGridViewTextBoxColumn.DataPropertyName = "CNPJ_RECEBEDOR_IR";
            this.cNPJRECEBEDORIRDataGridViewTextBoxColumn.HeaderText = "CNPJ Recebedor";
            this.cNPJRECEBEDORIRDataGridViewTextBoxColumn.Name = "cNPJRECEBEDORIRDataGridViewTextBoxColumn";
            this.cNPJRECEBEDORIRDataGridViewTextBoxColumn.Width = 50;
            // 
            // dESTINATARIOIRDataGridViewTextBoxColumn
            // 
            this.dESTINATARIOIRDataGridViewTextBoxColumn.DataPropertyName = "DESTINATARIO_IR";
            this.dESTINATARIOIRDataGridViewTextBoxColumn.HeaderText = "Destinatário";
            this.dESTINATARIOIRDataGridViewTextBoxColumn.Name = "dESTINATARIOIRDataGridViewTextBoxColumn";
            this.dESTINATARIOIRDataGridViewTextBoxColumn.Width = 80;
            // 
            // cNPJDESTINATARIOIRDataGridViewTextBoxColumn
            // 
            this.cNPJDESTINATARIOIRDataGridViewTextBoxColumn.DataPropertyName = "CNPJ_DESTINATARIO_IR";
            this.cNPJDESTINATARIOIRDataGridViewTextBoxColumn.HeaderText = "CNPJ Destinatário";
            this.cNPJDESTINATARIOIRDataGridViewTextBoxColumn.Name = "cNPJDESTINATARIOIRDataGridViewTextBoxColumn";
            this.cNPJDESTINATARIOIRDataGridViewTextBoxColumn.Width = 50;
            // 
            // eNDERECORECIRDataGridViewTextBoxColumn
            // 
            this.eNDERECORECIRDataGridViewTextBoxColumn.DataPropertyName = "ENDERECO_REC_IR";
            this.eNDERECORECIRDataGridViewTextBoxColumn.HeaderText = "Endereço";
            this.eNDERECORECIRDataGridViewTextBoxColumn.Name = "eNDERECORECIRDataGridViewTextBoxColumn";
            this.eNDERECORECIRDataGridViewTextBoxColumn.Width = 75;
            // 
            // nRECIRDataGridViewTextBoxColumn
            // 
            this.nRECIRDataGridViewTextBoxColumn.DataPropertyName = "N_REC_IR";
            this.nRECIRDataGridViewTextBoxColumn.HeaderText = "Nº";
            this.nRECIRDataGridViewTextBoxColumn.Name = "nRECIRDataGridViewTextBoxColumn";
            this.nRECIRDataGridViewTextBoxColumn.Width = 20;
            // 
            // cOMPLEMENTORECIRDataGridViewTextBoxColumn
            // 
            this.cOMPLEMENTORECIRDataGridViewTextBoxColumn.DataPropertyName = "COMPLEMENTO_REC_IR";
            this.cOMPLEMENTORECIRDataGridViewTextBoxColumn.HeaderText = "Complemento";
            this.cOMPLEMENTORECIRDataGridViewTextBoxColumn.Name = "cOMPLEMENTORECIRDataGridViewTextBoxColumn";
            this.cOMPLEMENTORECIRDataGridViewTextBoxColumn.Width = 30;
            // 
            // bAIRRORECIRDataGridViewTextBoxColumn
            // 
            this.bAIRRORECIRDataGridViewTextBoxColumn.DataPropertyName = "BAIRRO_REC_IR";
            this.bAIRRORECIRDataGridViewTextBoxColumn.HeaderText = "Bairro";
            this.bAIRRORECIRDataGridViewTextBoxColumn.Name = "bAIRRORECIRDataGridViewTextBoxColumn";
            this.bAIRRORECIRDataGridViewTextBoxColumn.Width = 70;
            // 
            // cIDADERECIRDataGridViewTextBoxColumn
            // 
            this.cIDADERECIRDataGridViewTextBoxColumn.DataPropertyName = "CIDADE_REC_IR";
            this.cIDADERECIRDataGridViewTextBoxColumn.HeaderText = "Cidade";
            this.cIDADERECIRDataGridViewTextBoxColumn.Name = "cIDADERECIRDataGridViewTextBoxColumn";
            this.cIDADERECIRDataGridViewTextBoxColumn.Width = 70;
            // 
            // col_peso
            // 
            this.col_peso.DataPropertyName = "PESO_IR";
            this.col_peso.HeaderText = "Peso";
            this.col_peso.Name = "col_peso";
            this.col_peso.Width = 35;
            // 
            // col_volumes
            // 
            this.col_volumes.DataPropertyName = "VOLUMES_IR";
            this.col_volumes.HeaderText = "Volumes";
            this.col_volumes.Name = "col_volumes";
            this.col_volumes.Width = 35;
            // 
            // col_cubagem
            // 
            this.col_cubagem.DataPropertyName = "CUBAGEM_IR";
            this.col_cubagem.HeaderText = "Cubagem";
            this.col_cubagem.Name = "col_cubagem";
            this.col_cubagem.Width = 35;
            // 
            // col_valor_cte
            // 
            this.col_valor_cte.DataPropertyName = "VALOR_CTE_IR";
            this.col_valor_cte.HeaderText = "Valor CTE";
            this.col_valor_cte.Name = "col_valor_cte";
            this.col_valor_cte.Width = 50;
            // 
            // col_valor_carga
            // 
            this.col_valor_carga.DataPropertyName = "VALOR_CARGA_IR";
            this.col_valor_carga.HeaderText = "Valor Carga";
            this.col_valor_carga.Name = "col_valor_carga";
            this.col_valor_carga.Width = 50;
            // 
            // col_cnpj_emitente
            // 
            this.col_cnpj_emitente.DataPropertyName = "CNPJ_EMITENTE_IR";
            this.col_cnpj_emitente.HeaderText = "CNPJ_EMITENTE_IR";
            this.col_cnpj_emitente.Name = "col_cnpj_emitente";
            // 
            // dsItens_romaneio
            // 
            this.dsItens_romaneio.DataSetName = "dsItens_romaneio";
            this.dsItens_romaneio.Namespace = "http://www.tempuri.org/dsItens_romaneio.xsd";
            this.dsItens_romaneio.Tables.AddRange(new System.Data.DataTable[] {
            this.ITENS_ROMANEIO});
            // 
            // ITENS_ROMANEIO
            // 
            this.ITENS_ROMANEIO.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_ITEM_ROMANEIO,
            this.COD_CTE_IR,
            this.COD_ROMANEIO_IR,
            this.JUSTIFICATIVA_RETORNO_IR,
            this.DATA_ENTREGA_IR,
            this.HORA_ENTREGA_IR,
            this.DESTINATARIO_IR,
            this.CNPJ_DESTINATARIO_IR,
            this.RECEBEDOR_IR,
            this.CNPJ_RECEBEDOR_IR,
            this.ENDERECO_REC_IR,
            this.N_REC_IR,
            this.COMPLEMENTO_REC_IR,
            this.BAIRRO_REC_IR,
            this.CIDADE_REC_IR,
            this.CEP_REC_IR,
            this.PESO_IR,
            this.VOLUMES_IR,
            this.CUBAGEM_IR,
            this.VALOR_CTE_IR,
            this.VALOR_CARGA_IR,
            this.ORDEM_ENTREGA_IR,
            this.dataColumn2,
            this.dataColumn1,
            this.dataColumn4,
            this.dataColumn6,
            this.dataColumn7,
            this.dataColumn9});
            this.ITENS_ROMANEIO.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_ITEM_ROMANEIO"}, true)});
            this.ITENS_ROMANEIO.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_ITEM_ROMANEIO};
            this.ITENS_ROMANEIO.TableName = "ITENS_ROMANEIO";
            // 
            // COD_ITEM_ROMANEIO
            // 
            this.COD_ITEM_ROMANEIO.AllowDBNull = false;
            this.COD_ITEM_ROMANEIO.ColumnName = "COD_ITEM_ROMANEIO";
            this.COD_ITEM_ROMANEIO.DataType = typeof(int);
            // 
            // COD_CTE_IR
            // 
            this.COD_CTE_IR.ColumnName = "COD_CTE_COLETA_IR";
            this.COD_CTE_IR.DataType = typeof(int);
            // 
            // COD_ROMANEIO_IR
            // 
            this.COD_ROMANEIO_IR.ColumnName = "COD_ROMANEIO_IR";
            this.COD_ROMANEIO_IR.DataType = typeof(int);
            // 
            // JUSTIFICATIVA_RETORNO_IR
            // 
            this.JUSTIFICATIVA_RETORNO_IR.ColumnName = "JUSTIFICATIVA_RETORNO_IR";
            this.JUSTIFICATIVA_RETORNO_IR.DataType = typeof(short);
            // 
            // DATA_ENTREGA_IR
            // 
            this.DATA_ENTREGA_IR.ColumnName = "DATA_ENTREGA_IR";
            this.DATA_ENTREGA_IR.DataType = typeof(System.DateTime);
            // 
            // HORA_ENTREGA_IR
            // 
            this.HORA_ENTREGA_IR.ColumnName = "HORA_ENTREGA_IR";
            this.HORA_ENTREGA_IR.DataType = typeof(System.DateTime);
            // 
            // DESTINATARIO_IR
            // 
            this.DESTINATARIO_IR.ColumnName = "DESTINATARIO_IR";
            this.DESTINATARIO_IR.MaxLength = 200;
            // 
            // CNPJ_DESTINATARIO_IR
            // 
            this.CNPJ_DESTINATARIO_IR.ColumnName = "CNPJ_DESTINATARIO_IR";
            this.CNPJ_DESTINATARIO_IR.MaxLength = 30;
            // 
            // RECEBEDOR_IR
            // 
            this.RECEBEDOR_IR.ColumnName = "RECEBEDOR_IR";
            this.RECEBEDOR_IR.MaxLength = 200;
            // 
            // CNPJ_RECEBEDOR_IR
            // 
            this.CNPJ_RECEBEDOR_IR.ColumnName = "CNPJ_RECEBEDOR_IR";
            this.CNPJ_RECEBEDOR_IR.MaxLength = 30;
            // 
            // ENDERECO_REC_IR
            // 
            this.ENDERECO_REC_IR.ColumnName = "ENDERECO_REC_IR";
            this.ENDERECO_REC_IR.MaxLength = 200;
            // 
            // N_REC_IR
            // 
            this.N_REC_IR.ColumnName = "N_REC_IR";
            this.N_REC_IR.MaxLength = 20;
            // 
            // COMPLEMENTO_REC_IR
            // 
            this.COMPLEMENTO_REC_IR.ColumnName = "COMPLEMENTO_REC_IR";
            this.COMPLEMENTO_REC_IR.MaxLength = 200;
            // 
            // BAIRRO_REC_IR
            // 
            this.BAIRRO_REC_IR.ColumnName = "BAIRRO_REC_IR";
            this.BAIRRO_REC_IR.MaxLength = 200;
            // 
            // CIDADE_REC_IR
            // 
            this.CIDADE_REC_IR.ColumnName = "CIDADE_REC_IR";
            this.CIDADE_REC_IR.MaxLength = 200;
            // 
            // CEP_REC_IR
            // 
            this.CEP_REC_IR.ColumnName = "CEP_REC_IR";
            this.CEP_REC_IR.MaxLength = 20;
            // 
            // PESO_IR
            // 
            this.PESO_IR.ColumnName = "PESO_IR";
            this.PESO_IR.DataType = typeof(double);
            // 
            // VOLUMES_IR
            // 
            this.VOLUMES_IR.ColumnName = "VOLUMES_IR";
            this.VOLUMES_IR.DataType = typeof(double);
            // 
            // CUBAGEM_IR
            // 
            this.CUBAGEM_IR.ColumnName = "CUBAGEM_IR";
            this.CUBAGEM_IR.DataType = typeof(double);
            // 
            // VALOR_CTE_IR
            // 
            this.VALOR_CTE_IR.ColumnName = "VALOR_CTE_IR";
            this.VALOR_CTE_IR.DataType = typeof(double);
            // 
            // VALOR_CARGA_IR
            // 
            this.VALOR_CARGA_IR.ColumnName = "VALOR_CARGA_IR";
            this.VALOR_CARGA_IR.DataType = typeof(double);
            // 
            // ORDEM_ENTREGA_IR
            // 
            this.ORDEM_ENTREGA_IR.ColumnName = "ORDEM_ENTREGA_IR";
            this.ORDEM_ENTREGA_IR.DataType = typeof(int);
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "TIPO_IR";
            this.dataColumn2.MaxLength = 50;
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "DATA_CTE_COLETA_IR";
            this.dataColumn1.DataType = typeof(System.DateTime);
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "CNPJ_EMITENTE_IR";
            this.dataColumn4.MaxLength = 25;
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "DEVOLVIDO_IR";
            this.dataColumn6.DataType = typeof(int);
            // 
            // dataColumn7
            // 
            this.dataColumn7.ColumnName = "JA_DEVOLVIDO_IR";
            this.dataColumn7.DataType = typeof(int);
            // 
            // dataColumn9
            // 
            this.dataColumn9.ColumnName = "NF_IR";
            this.dataColumn9.DataType = typeof(int);
            // 
            // fbCommand5
            // 
            this.fbCommand5.CommandTimeout = 30;
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
            // datItens_romaneio
            // 
            this.datItens_romaneio.DeleteCommand = this.fbCommand16;
            this.datItens_romaneio.InsertCommand = this.fbCommand14;
            this.datItens_romaneio.SelectCommand = this.fbCommand13;
            this.datItens_romaneio.UpdateCommand = this.fbCommand15;
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
            this.fbCommand13.CommandText = "select * from itens_romaneio";
            this.fbCommand13.CommandTimeout = 30;
            this.fbCommand13.Connection = this.fbConnection1;
            // 
            // fbCommand15
            // 
            this.fbCommand15.CommandTimeout = 30;
            // 
            // cbItens_romaneio
            // 
            this.cbItens_romaneio.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbItens_romaneio.DataAdapter = this.datItens_romaneio;
            this.cbItens_romaneio.QuotePrefix = "\"";
            this.cbItens_romaneio.QuoteSuffix = "\"";
            // 
            // cbRomaneio
            // 
            this.cbRomaneio.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbRomaneio.DataAdapter = this.datRomaneio;
            this.cbRomaneio.QuotePrefix = "\"";
            this.cbRomaneio.QuoteSuffix = "\"";
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(141, 91);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(105, 24);
            this.button25.TabIndex = 304;
            this.button25.Text = "Gerar Arquivo";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.button25_Click);
            // 
            // form_romaneio_pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 697);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dtData_atual);
            this.Controls.Add(this.button1);
            this.Name = "form_romaneio_pedido";
            this.Text = "Romaneio de Entrega";
            this.Load += new System.EventHandler(this.form_romaneio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRomaneios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRomaneio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ROMANEIO)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens_romaneio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsItens_romaneio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITENS_ROMANEIO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button novo_registro;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datRomaneio;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtData_atual;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvRomaneios;
        private System.Data.DataSet dsRomaneio;
        private System.Data.DataTable ROMANEIO;
        private System.Data.DataColumn COD_ROMANEIO;
        private System.Data.DataColumn DATA_ROMANEIO;
        private System.Data.DataColumn PLACA_VEICULO_ROMANEIO;
        private System.Data.DataColumn COD_MOTORISTA_ROMANEIO;
        private System.Data.DataColumn KM_INCIAL_ROMANEIO;
        private System.Data.DataColumn KM_FINAL_ROMANEIO;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvItens_romaneio;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand8;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand6;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand5;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand7;
        private System.Windows.Forms.Button salva_registro;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_cod_romaneio;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand9;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand10;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand11;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand12;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datItens_romaneio;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand16;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand14;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand13;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand15;
        private System.Data.DataSet dsItens_romaneio;
        private System.Data.DataTable ITENS_ROMANEIO;
        private System.Data.DataColumn COD_ITEM_ROMANEIO;
        private System.Data.DataColumn COD_CTE_IR;
        private System.Data.DataColumn COD_ROMANEIO_IR;
        private System.Data.DataColumn JUSTIFICATIVA_RETORNO_IR;
        private System.Data.DataColumn DATA_ENTREGA_IR;
        private System.Data.DataColumn HORA_ENTREGA_IR;
        private System.Data.DataColumn DESTINATARIO_IR;
        private System.Data.DataColumn CNPJ_DESTINATARIO_IR;
        private System.Data.DataColumn RECEBEDOR_IR;
        private System.Data.DataColumn CNPJ_RECEBEDOR_IR;
        private System.Data.DataColumn ENDERECO_REC_IR;
        private System.Data.DataColumn N_REC_IR;
        private System.Data.DataColumn COMPLEMENTO_REC_IR;
        private System.Data.DataColumn BAIRRO_REC_IR;
        private System.Data.DataColumn CIDADE_REC_IR;
        private System.Data.DataColumn CEP_REC_IR;
        private System.Data.DataColumn PESO_IR;
        private System.Data.DataColumn VOLUMES_IR;
        private System.Data.DataColumn CUBAGEM_IR;
        private System.Data.DataColumn VALOR_CTE_IR;
        private System.Data.DataColumn VALOR_CARGA_IR;
        private System.Data.DataColumn ORDEM_ENTREGA_IR;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_placa_novo_romaneio;
        private System.Windows.Forms.Label labelRomaneio_selecionado;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox tb_romaneio_selecionado;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tb_valor_total_carga;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tb_cubagem_total;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_volumes_totais;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_peso_total;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbItens_romaneio;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbRomaneio;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn1;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tb_roteiro;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tb_chave_cte;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_valor_frete;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_nome_motorista;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Data.DataColumn dataColumn7;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tb_valor_entregue;
        private System.Windows.Forms.Button btnImprimirDia;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Data.DataColumn dataColumn8;
        private System.Windows.Forms.Button button21;
        private System.Data.DataColumn dataColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn oRDEMENTREGAIRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_devolvido;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_ja_devolvido;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cte_coleta;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nf;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA_CTE_COLETA_IR;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEPRECIRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod_item_romaneio;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_romaneio;
        private System.Windows.Forms.DataGridViewTextBoxColumn jUSTIFICATIVARETORNOIRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAENTREGAIRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORAENTREGAIRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rECEBEDORIRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPJRECEBEDORIRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESTINATARIOIRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPJDESTINATARIOIRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNDERECORECIRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nRECIRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOMPLEMENTORECIRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bAIRRORECIRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDADERECIRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_volumes;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cubagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_valor_cte;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_valor_carga;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cnpj_emitente;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtRomaneio;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR_ROMANEIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLACAVEICULOROMANEIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn VENDEDOR_ROMANEIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOTORISTA_ROMANEIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODMOTORISTAROMANEIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ROTEIRO_ROMANEIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAROMANEIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Data.DataColumn dataColumn10;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tb_vendedor;
        private System.Windows.Forms.Button button25;
    }
}