namespace Evolucao
{
    partial class form_busca_romaneio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_busca_romaneio));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.datRomaneio = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvRomaneios = new System.Windows.Forms.DataGridView();
            this.col_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pLACAVEICULOROMANEIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOTORISTA_ROMANEIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODMOTORISTAROMANEIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ROTEIRO_ROMANEIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAROMANEIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PESO_TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VOLUME_TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUBAGEM_TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR_CTE_TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR_CARGA_TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL_ENTREGUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_qtde_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_qtde_entregue = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalCubagem = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotalEntregue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValorCte = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalCarga = new System.Windows.Forms.TextBox();
            this.txtTotalPeso = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalVolume = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.cbRomaneio = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.dtFim = new System.Windows.Forms.DateTimePicker();
            this.tb_mdfe = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_romaneio = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRomaneios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRomaneio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ROMANEIO)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            // dtInicio
            // 
            this.dtInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicio.Location = new System.Drawing.Point(10, 12);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(117, 29);
            this.dtInicio.TabIndex = 273;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(256, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(136, 29);
            this.btnBuscar.TabIndex = 274;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
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
            this.pLACAVEICULOROMANEIODataGridViewTextBoxColumn,
            this.MOTORISTA_ROMANEIO,
            this.cODMOTORISTAROMANEIODataGridViewTextBoxColumn,
            this.ROTEIRO_ROMANEIO,
            this.dATAROMANEIODataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.PESO_TOTAL,
            this.VOLUME_TOTAL,
            this.CUBAGEM_TOTAL,
            this.VALOR_CTE_TOTAL,
            this.VALOR_CARGA_TOTAL,
            this.TOTAL_ENTREGUE,
            this.col_qtde_total,
            this.col_qtde_entregue});
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
            this.dgvRomaneios.Location = new System.Drawing.Point(7, 40);
            this.dgvRomaneios.Name = "dgvRomaneios";
            this.dgvRomaneios.RowHeadersWidth = 20;
            this.dgvRomaneios.Size = new System.Drawing.Size(1140, 422);
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
            // pLACAVEICULOROMANEIODataGridViewTextBoxColumn
            // 
            this.pLACAVEICULOROMANEIODataGridViewTextBoxColumn.DataPropertyName = "PLACA_VEICULO_ROMANEIO";
            this.pLACAVEICULOROMANEIODataGridViewTextBoxColumn.HeaderText = "Veículo";
            this.pLACAVEICULOROMANEIODataGridViewTextBoxColumn.Name = "pLACAVEICULOROMANEIODataGridViewTextBoxColumn";
            this.pLACAVEICULOROMANEIODataGridViewTextBoxColumn.Width = 60;
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
            // PESO_TOTAL
            // 
            this.PESO_TOTAL.HeaderText = "Peso Total";
            this.PESO_TOTAL.Name = "PESO_TOTAL";
            this.PESO_TOTAL.Width = 60;
            // 
            // VOLUME_TOTAL
            // 
            this.VOLUME_TOTAL.HeaderText = "Volume Total";
            this.VOLUME_TOTAL.Name = "VOLUME_TOTAL";
            this.VOLUME_TOTAL.Width = 60;
            // 
            // CUBAGEM_TOTAL
            // 
            this.CUBAGEM_TOTAL.HeaderText = "Cubagem Total";
            this.CUBAGEM_TOTAL.Name = "CUBAGEM_TOTAL";
            this.CUBAGEM_TOTAL.Width = 60;
            // 
            // VALOR_CTE_TOTAL
            // 
            this.VALOR_CTE_TOTAL.HeaderText = "Valor Total Frete";
            this.VALOR_CTE_TOTAL.Name = "VALOR_CTE_TOTAL";
            this.VALOR_CTE_TOTAL.Width = 60;
            // 
            // VALOR_CARGA_TOTAL
            // 
            this.VALOR_CARGA_TOTAL.HeaderText = "Valor Total Carga";
            this.VALOR_CARGA_TOTAL.Name = "VALOR_CARGA_TOTAL";
            this.VALOR_CARGA_TOTAL.Width = 60;
            // 
            // TOTAL_ENTREGUE
            // 
            this.TOTAL_ENTREGUE.HeaderText = "Valor Total Entregue";
            this.TOTAL_ENTREGUE.Name = "TOTAL_ENTREGUE";
            this.TOTAL_ENTREGUE.Width = 60;
            // 
            // col_qtde_total
            // 
            this.col_qtde_total.HeaderText = "Qtde Total";
            this.col_qtde_total.Name = "col_qtde_total";
            this.col_qtde_total.Width = 60;
            // 
            // col_qtde_entregue
            // 
            this.col_qtde_entregue.HeaderText = "Qtde Entregue";
            this.col_qtde_entregue.Name = "col_qtde_entregue";
            this.col_qtde_entregue.Width = 60;
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
            this.dataColumn5});
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvRomaneios);
            this.panel1.Location = new System.Drawing.Point(10, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1162, 608);
            this.panel1.TabIndex = 276;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTotalCubagem);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtTotalEntregue);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtValorCte);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtTotalCarga);
            this.groupBox1.Controls.Add(this.txtTotalPeso);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTotalVolume);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 468);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 124);
            this.groupBox1.TabIndex = 289;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Totais Período";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 289;
            this.label2.Text = "Cubagem:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 284;
            this.label3.Text = "Peso:";
            // 
            // txtTotalCubagem
            // 
            this.txtTotalCubagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCubagem.Location = new System.Drawing.Point(91, 84);
            this.txtTotalCubagem.Name = "txtTotalCubagem";
            this.txtTotalCubagem.Size = new System.Drawing.Size(124, 26);
            this.txtTotalCubagem.TabIndex = 283;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(221, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 20);
            this.label7.TabIndex = 288;
            this.label7.Text = "Total Entregue:";
            // 
            // txtTotalEntregue
            // 
            this.txtTotalEntregue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalEntregue.Location = new System.Drawing.Point(343, 84);
            this.txtTotalEntregue.Name = "txtTotalEntregue";
            this.txtTotalEntregue.Size = new System.Drawing.Size(132, 26);
            this.txtTotalEntregue.TabIndex = 282;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 285;
            this.label4.Text = "Volume:";
            // 
            // txtValorCte
            // 
            this.txtValorCte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorCte.Location = new System.Drawing.Point(343, 51);
            this.txtValorCte.Name = "txtValorCte";
            this.txtValorCte.Size = new System.Drawing.Size(132, 26);
            this.txtValorCte.TabIndex = 279;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(221, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 287;
            this.label6.Text = "Total Frete:";
            // 
            // txtTotalCarga
            // 
            this.txtTotalCarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCarga.Location = new System.Drawing.Point(343, 18);
            this.txtTotalCarga.Name = "txtTotalCarga";
            this.txtTotalCarga.Size = new System.Drawing.Size(132, 26);
            this.txtTotalCarga.TabIndex = 278;
            // 
            // txtTotalPeso
            // 
            this.txtTotalPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPeso.Location = new System.Drawing.Point(91, 18);
            this.txtTotalPeso.Name = "txtTotalPeso";
            this.txtTotalPeso.Size = new System.Drawing.Size(124, 26);
            this.txtTotalPeso.TabIndex = 280;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(221, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 286;
            this.label5.Text = "Total Carga:";
            // 
            // txtTotalVolume
            // 
            this.txtTotalVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalVolume.Location = new System.Drawing.Point(91, 52);
            this.txtTotalVolume.Name = "txtTotalVolume";
            this.txtTotalVolume.Size = new System.Drawing.Size(124, 26);
            this.txtTotalVolume.TabIndex = 281;
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
            // cbRomaneio
            // 
            this.cbRomaneio.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbRomaneio.DataAdapter = this.datRomaneio;
            this.cbRomaneio.QuotePrefix = "\"";
            this.cbRomaneio.QuoteSuffix = "\"";
            // 
            // dtFim
            // 
            this.dtFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFim.Location = new System.Drawing.Point(133, 12);
            this.dtFim.Name = "dtFim";
            this.dtFim.Size = new System.Drawing.Size(117, 29);
            this.dtFim.TabIndex = 277;
            // 
            // tb_mdfe
            // 
            this.tb_mdfe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_mdfe.Location = new System.Drawing.Point(539, 13);
            this.tb_mdfe.Name = "tb_mdfe";
            this.tb_mdfe.Size = new System.Drawing.Size(100, 29);
            this.tb_mdfe.TabIndex = 278;
            this.tb_mdfe.Visible = false;
            this.tb_mdfe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_mdfe_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(645, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 29);
            this.button1.TabIndex = 279;
            this.button1.Text = "Buscar MDFe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(451, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 20);
            this.label8.TabIndex = 280;
            this.label8.Text = "Nº. MDFe:";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(793, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 20);
            this.label9.TabIndex = 281;
            this.label9.Text = "Nº. Romaneio:";
            // 
            // tb_romaneio
            // 
            this.tb_romaneio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_romaneio.Location = new System.Drawing.Point(910, 12);
            this.tb_romaneio.Name = "tb_romaneio";
            this.tb_romaneio.Size = new System.Drawing.Size(100, 29);
            this.tb_romaneio.TabIndex = 282;
            this.tb_romaneio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_romaneio_KeyPress);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1016, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 29);
            this.button2.TabIndex = 283;
            this.button2.Text = "Buscar Romaneio";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // form_busca_romaneio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 664);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tb_romaneio);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_mdfe);
            this.Controls.Add(this.dtFim);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dtInicio);
            this.Name = "form_busca_romaneio";
            this.Text = "Romaneio de Entrega";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRomaneios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRomaneio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ROMANEIO)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datRomaneio;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.Button btnBuscar;
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
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand8;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand6;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand5;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand7;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand9;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand10;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand11;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand12;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand16;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand14;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand13;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand15;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbRomaneio;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn5;
        private System.Windows.Forms.DateTimePicker dtFim;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotalCubagem;
        private System.Windows.Forms.TextBox txtTotalEntregue;
        private System.Windows.Forms.TextBox txtTotalVolume;
        private System.Windows.Forms.TextBox txtTotalPeso;
        private System.Windows.Forms.TextBox txtValorCte;
        private System.Windows.Forms.TextBox txtTotalCarga;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLACAVEICULOROMANEIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOTORISTA_ROMANEIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODMOTORISTAROMANEIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ROTEIRO_ROMANEIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAROMANEIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PESO_TOTAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn VOLUME_TOTAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUBAGEM_TOTAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR_CTE_TOTAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR_CARGA_TOTAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL_ENTREGUE;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_qtde_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_qtde_entregue;
        private System.Windows.Forms.TextBox tb_mdfe;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_romaneio;
        private System.Windows.Forms.Button button2;
    }
}