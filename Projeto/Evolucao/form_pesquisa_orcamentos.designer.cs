namespace Evolucao
{
    partial class form_pesquisa_orcamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_pesquisa_orcamentos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtTermino = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.datItens_orcamento = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.rbAprovadas = new System.Windows.Forms.RadioButton();
            this.rbReprovadas = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbEm_aberto = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_cliente = new System.Windows.Forms.TextBox();
            this.tb_cnpj_cliente = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_valor_total = new System.Windows.Forms.TextBox();
            this.dsItens_orcamento = new System.Data.DataSet();
            this.ITENS_ORCAMENTO = new System.Data.DataTable();
            this.COD_ITEM_ORC = new System.Data.DataColumn();
            this.NOME_ITEM_ORC = new System.Data.DataColumn();
            this.QTDE_ITEM_ORC = new System.Data.DataColumn();
            this.HORAS_FRESA_ITEM_ORC = new System.Data.DataColumn();
            this.HORAS_RET_PLANA_ITEM_ORC = new System.Data.DataColumn();
            this.HORAS_RET_CILIN_ITEM_ORC = new System.Data.DataColumn();
            this.HORAS_RET_OVER_ITEM_ORC = new System.Data.DataColumn();
            this.HORAS_RET_CNC_ITEM_ORC = new System.Data.DataColumn();
            this.HORAS_EDM_ITEM_ORC = new System.Data.DataColumn();
            this.HORAS_TORNO_CONV_ITEM_ORC = new System.Data.DataColumn();
            this.HORAS_TORNO_CNC_ITEM_ORC = new System.Data.DataColumn();
            this.HORAS_WEDM_ITEM_ORC = new System.Data.DataColumn();
            this.HORAS_CENTRO_USI_ITEM_ORC = new System.Data.DataColumn();
            this.HORAS_TRAT_TERM_ITEM_ORC = new System.Data.DataColumn();
            this.HORAS_SE1_ITEM_ORC = new System.Data.DataColumn();
            this.HORAS_SE2_ITEM_ORC = new System.Data.DataColumn();
            this.HORAS_SE3_ITEM_ORC = new System.Data.DataColumn();
            this.HORAS_QA_ITEM_ORC = new System.Data.DataColumn();
            this.HORAS_BANCADA_ITEM_ORC = new System.Data.DataColumn();
            this.VALOR_TOTAL_ITEM_ORC = new System.Data.DataColumn();
            this.STATUS_ITEM_ORC = new System.Data.DataColumn();
            this.OBS_ITEM_ORC = new System.Data.DataColumn();
            this.COD_ORCAMENTO_ITEM_ORC = new System.Data.DataColumn();
            this.TOTAL_HORAS_ITEM_ORC = new System.Data.DataColumn();
            this.VALOR_UNIT_ITEM_ORC = new System.Data.DataColumn();
            this.VALOR_MAT_PRI_ITEM_ORC = new System.Data.DataColumn();
            this.dataColumn40 = new System.Data.DataColumn();
            this.dataColumn41 = new System.Data.DataColumn();
            this.dataColumn43 = new System.Data.DataColumn();
            this.dataColumn44 = new System.Data.DataColumn();
            this.dataColumn49 = new System.Data.DataColumn();
            this.dataColumn52 = new System.Data.DataColumn();
            this.dataColumn53 = new System.Data.DataColumn();
            this.dgvItens_orcamento = new System.Windows.Forms.DataGridView();
            this.col_cod_item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ALTERNATIVO_ITEM_ORC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_qtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_valor_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTATUSITEMORCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOTIVO_REJEICAO_ITEM_ORC = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.col_fresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_retifica_plana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_retifica_cilindrica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_retifica_overbeck = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_retifica_cnc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_edm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_torno_convencional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_torno_cnc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_wedm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_centro_usinagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_tratamento_termico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_servico_externo_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_servico_externo_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_servico_externo_3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_qa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_bancada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_materia_prima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRAZO_ENTREGA_ITEM_ORC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_valor_unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_lucro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ipi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_valor_ipi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aprovado = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Reprovado = new System.Windows.Forms.DataGridViewButtonColumn();
            this.oBSITEMORCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODORCAMENTOITEMORCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_total_horas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsItens_orcamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITENS_ORCAMENTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens_orcamento)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dtTermino);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtInicio);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(168, 72);
            this.groupBox2.TabIndex = 14;
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
            // datItens_orcamento
            // 
            this.datItens_orcamento.DeleteCommand = this.fbCommand4;
            this.datItens_orcamento.InsertCommand = this.fbCommand2;
            this.datItens_orcamento.SelectCommand = this.fbCommand1;
            this.datItens_orcamento.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * from itens_orcamento";
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
            // rbAprovadas
            // 
            this.rbAprovadas.AutoSize = true;
            this.rbAprovadas.Location = new System.Drawing.Point(9, 5);
            this.rbAprovadas.Name = "rbAprovadas";
            this.rbAprovadas.Size = new System.Drawing.Size(76, 17);
            this.rbAprovadas.TabIndex = 217;
            this.rbAprovadas.TabStop = true;
            this.rbAprovadas.Text = "Aprovadas";
            this.rbAprovadas.UseVisualStyleBackColor = true;
            // 
            // rbReprovadas
            // 
            this.rbReprovadas.AutoSize = true;
            this.rbReprovadas.Location = new System.Drawing.Point(9, 28);
            this.rbReprovadas.Name = "rbReprovadas";
            this.rbReprovadas.Size = new System.Drawing.Size(83, 17);
            this.rbReprovadas.TabIndex = 218;
            this.rbReprovadas.TabStop = true;
            this.rbReprovadas.Text = "Reprovadas";
            this.rbReprovadas.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.rbEm_aberto);
            this.panel1.Controls.Add(this.rbReprovadas);
            this.panel1.Controls.Add(this.rbAprovadas);
            this.panel1.Location = new System.Drawing.Point(185, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(96, 72);
            this.panel1.TabIndex = 219;
            // 
            // rbEm_aberto
            // 
            this.rbEm_aberto.AutoSize = true;
            this.rbEm_aberto.Location = new System.Drawing.Point(9, 51);
            this.rbEm_aberto.Name = "rbEm_aberto";
            this.rbEm_aberto.Size = new System.Drawing.Size(73, 17);
            this.rbEm_aberto.TabIndex = 219;
            this.rbEm_aberto.TabStop = true;
            this.rbEm_aberto.Text = "Em aberto";
            this.rbEm_aberto.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(302, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 72);
            this.button1.TabIndex = 220;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_cliente
            // 
            this.tb_cliente.Location = new System.Drawing.Point(126, 20);
            this.tb_cliente.Name = "tb_cliente";
            this.tb_cliente.Size = new System.Drawing.Size(212, 20);
            this.tb_cliente.TabIndex = 271;
            // 
            // tb_cnpj_cliente
            // 
            this.tb_cnpj_cliente.Location = new System.Drawing.Point(10, 20);
            this.tb_cnpj_cliente.Name = "tb_cnpj_cliente";
            this.tb_cnpj_cliente.Size = new System.Drawing.Size(113, 20);
            this.tb_cnpj_cliente.TabIndex = 270;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(340, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(21, 23);
            this.button2.TabIndex = 269;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.tb_cliente);
            this.panel2.Controls.Add(this.tb_cnpj_cliente);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(12, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(365, 47);
            this.panel2.TabIndex = 273;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 274;
            this.label4.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 273;
            this.label3.Text = "CNPJ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.textBox3);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Location = new System.Drawing.Point(13, 146);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(841, 41);
            this.panel3.TabIndex = 274;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(275, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Cód:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(339, 11);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(479, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Orçamento:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(543, 11);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Filtro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Descrição:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(146, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(454, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 31);
            this.label8.TabIndex = 6;
            this.label8.Text = "Valor Total:";
            // 
            // tb_valor_total
            // 
            this.tb_valor_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_valor_total.Location = new System.Drawing.Point(613, 50);
            this.tb_valor_total.Name = "tb_valor_total";
            this.tb_valor_total.Size = new System.Drawing.Size(241, 38);
            this.tb_valor_total.TabIndex = 5;
            // 
            // dsItens_orcamento
            // 
            this.dsItens_orcamento.DataSetName = "dsItens_orcamento";
            this.dsItens_orcamento.Namespace = "http://www.tempuri.org/dsItens_orcamento.xsd";
            this.dsItens_orcamento.Tables.AddRange(new System.Data.DataTable[] {
            this.ITENS_ORCAMENTO});
            // 
            // ITENS_ORCAMENTO
            // 
            this.ITENS_ORCAMENTO.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_ITEM_ORC,
            this.NOME_ITEM_ORC,
            this.QTDE_ITEM_ORC,
            this.HORAS_FRESA_ITEM_ORC,
            this.HORAS_RET_PLANA_ITEM_ORC,
            this.HORAS_RET_CILIN_ITEM_ORC,
            this.HORAS_RET_OVER_ITEM_ORC,
            this.HORAS_RET_CNC_ITEM_ORC,
            this.HORAS_EDM_ITEM_ORC,
            this.HORAS_TORNO_CONV_ITEM_ORC,
            this.HORAS_TORNO_CNC_ITEM_ORC,
            this.HORAS_WEDM_ITEM_ORC,
            this.HORAS_CENTRO_USI_ITEM_ORC,
            this.HORAS_TRAT_TERM_ITEM_ORC,
            this.HORAS_SE1_ITEM_ORC,
            this.HORAS_SE2_ITEM_ORC,
            this.HORAS_SE3_ITEM_ORC,
            this.HORAS_QA_ITEM_ORC,
            this.HORAS_BANCADA_ITEM_ORC,
            this.VALOR_TOTAL_ITEM_ORC,
            this.STATUS_ITEM_ORC,
            this.OBS_ITEM_ORC,
            this.COD_ORCAMENTO_ITEM_ORC,
            this.TOTAL_HORAS_ITEM_ORC,
            this.VALOR_UNIT_ITEM_ORC,
            this.VALOR_MAT_PRI_ITEM_ORC,
            this.dataColumn40,
            this.dataColumn41,
            this.dataColumn43,
            this.dataColumn44,
            this.dataColumn49,
            this.dataColumn52,
            this.dataColumn53});
            this.ITENS_ORCAMENTO.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_ITEM_ORC"}, true)});
            this.ITENS_ORCAMENTO.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_ITEM_ORC};
            this.ITENS_ORCAMENTO.TableName = "ITENS_ORCAMENTO";
            // 
            // COD_ITEM_ORC
            // 
            this.COD_ITEM_ORC.AllowDBNull = false;
            this.COD_ITEM_ORC.ColumnName = "COD_ITEM_ORC";
            this.COD_ITEM_ORC.DataType = typeof(int);
            // 
            // NOME_ITEM_ORC
            // 
            this.NOME_ITEM_ORC.ColumnName = "NOME_ITEM_ORC";
            this.NOME_ITEM_ORC.MaxLength = 100;
            // 
            // QTDE_ITEM_ORC
            // 
            this.QTDE_ITEM_ORC.ColumnName = "QTDE_ITEM_ORC";
            this.QTDE_ITEM_ORC.DataType = typeof(int);
            // 
            // HORAS_FRESA_ITEM_ORC
            // 
            this.HORAS_FRESA_ITEM_ORC.ColumnName = "HORAS_FRESA_ITEM_ORC";
            this.HORAS_FRESA_ITEM_ORC.DataType = typeof(double);
            // 
            // HORAS_RET_PLANA_ITEM_ORC
            // 
            this.HORAS_RET_PLANA_ITEM_ORC.ColumnName = "HORAS_RET_PLANA_ITEM_ORC";
            this.HORAS_RET_PLANA_ITEM_ORC.DataType = typeof(double);
            // 
            // HORAS_RET_CILIN_ITEM_ORC
            // 
            this.HORAS_RET_CILIN_ITEM_ORC.ColumnName = "HORAS_RET_CILIN_ITEM_ORC";
            this.HORAS_RET_CILIN_ITEM_ORC.DataType = typeof(double);
            // 
            // HORAS_RET_OVER_ITEM_ORC
            // 
            this.HORAS_RET_OVER_ITEM_ORC.ColumnName = "HORAS_RET_OVER_ITEM_ORC";
            this.HORAS_RET_OVER_ITEM_ORC.DataType = typeof(double);
            // 
            // HORAS_RET_CNC_ITEM_ORC
            // 
            this.HORAS_RET_CNC_ITEM_ORC.ColumnName = "HORAS_RET_CNC_ITEM_ORC";
            this.HORAS_RET_CNC_ITEM_ORC.DataType = typeof(double);
            // 
            // HORAS_EDM_ITEM_ORC
            // 
            this.HORAS_EDM_ITEM_ORC.ColumnName = "HORAS_EDM_ITEM_ORC";
            this.HORAS_EDM_ITEM_ORC.DataType = typeof(double);
            // 
            // HORAS_TORNO_CONV_ITEM_ORC
            // 
            this.HORAS_TORNO_CONV_ITEM_ORC.ColumnName = "HORAS_TORNO_CONV_ITEM_ORC";
            this.HORAS_TORNO_CONV_ITEM_ORC.DataType = typeof(double);
            // 
            // HORAS_TORNO_CNC_ITEM_ORC
            // 
            this.HORAS_TORNO_CNC_ITEM_ORC.ColumnName = "HORAS_TORNO_CNC_ITEM_ORC";
            this.HORAS_TORNO_CNC_ITEM_ORC.DataType = typeof(double);
            // 
            // HORAS_WEDM_ITEM_ORC
            // 
            this.HORAS_WEDM_ITEM_ORC.ColumnName = "HORAS_WEDM_ITEM_ORC";
            this.HORAS_WEDM_ITEM_ORC.DataType = typeof(double);
            // 
            // HORAS_CENTRO_USI_ITEM_ORC
            // 
            this.HORAS_CENTRO_USI_ITEM_ORC.ColumnName = "HORAS_CENTRO_USI_ITEM_ORC";
            this.HORAS_CENTRO_USI_ITEM_ORC.DataType = typeof(double);
            // 
            // HORAS_TRAT_TERM_ITEM_ORC
            // 
            this.HORAS_TRAT_TERM_ITEM_ORC.ColumnName = "HORAS_TRAT_TERM_ITEM_ORC";
            this.HORAS_TRAT_TERM_ITEM_ORC.DataType = typeof(double);
            // 
            // HORAS_SE1_ITEM_ORC
            // 
            this.HORAS_SE1_ITEM_ORC.ColumnName = "HORAS_SE1_ITEM_ORC";
            this.HORAS_SE1_ITEM_ORC.DataType = typeof(double);
            // 
            // HORAS_SE2_ITEM_ORC
            // 
            this.HORAS_SE2_ITEM_ORC.ColumnName = "HORAS_SE2_ITEM_ORC";
            this.HORAS_SE2_ITEM_ORC.DataType = typeof(double);
            // 
            // HORAS_SE3_ITEM_ORC
            // 
            this.HORAS_SE3_ITEM_ORC.ColumnName = "HORAS_SE3_ITEM_ORC";
            this.HORAS_SE3_ITEM_ORC.DataType = typeof(double);
            // 
            // HORAS_QA_ITEM_ORC
            // 
            this.HORAS_QA_ITEM_ORC.ColumnName = "HORAS_QA_ITEM_ORC";
            this.HORAS_QA_ITEM_ORC.DataType = typeof(double);
            // 
            // HORAS_BANCADA_ITEM_ORC
            // 
            this.HORAS_BANCADA_ITEM_ORC.ColumnName = "HORAS_BANCADA_ITEM_ORC";
            this.HORAS_BANCADA_ITEM_ORC.DataType = typeof(double);
            // 
            // VALOR_TOTAL_ITEM_ORC
            // 
            this.VALOR_TOTAL_ITEM_ORC.ColumnName = "VALOR_TOTAL_ITEM_ORC";
            this.VALOR_TOTAL_ITEM_ORC.DataType = typeof(double);
            // 
            // STATUS_ITEM_ORC
            // 
            this.STATUS_ITEM_ORC.ColumnName = "STATUS_ITEM_ORC";
            this.STATUS_ITEM_ORC.MaxLength = 100;
            // 
            // OBS_ITEM_ORC
            // 
            this.OBS_ITEM_ORC.ColumnName = "OBS_ITEM_ORC";
            this.OBS_ITEM_ORC.MaxLength = 100;
            // 
            // COD_ORCAMENTO_ITEM_ORC
            // 
            this.COD_ORCAMENTO_ITEM_ORC.ColumnName = "COD_ORCAMENTO_ITEM_ORC";
            this.COD_ORCAMENTO_ITEM_ORC.DataType = typeof(int);
            // 
            // TOTAL_HORAS_ITEM_ORC
            // 
            this.TOTAL_HORAS_ITEM_ORC.ColumnName = "TOTAL_HORAS_ITEM_ORC";
            this.TOTAL_HORAS_ITEM_ORC.DataType = typeof(double);
            // 
            // VALOR_UNIT_ITEM_ORC
            // 
            this.VALOR_UNIT_ITEM_ORC.ColumnName = "VALOR_UNIT_ITEM_ORC";
            this.VALOR_UNIT_ITEM_ORC.DataType = typeof(double);
            // 
            // VALOR_MAT_PRI_ITEM_ORC
            // 
            this.VALOR_MAT_PRI_ITEM_ORC.ColumnName = "VALOR_MAT_PRI_ITEM_ORC";
            this.VALOR_MAT_PRI_ITEM_ORC.DataType = typeof(double);
            // 
            // dataColumn40
            // 
            this.dataColumn40.ColumnName = "MATERIAL_ITEM_ORC";
            this.dataColumn40.MaxLength = 30;
            // 
            // dataColumn41
            // 
            this.dataColumn41.ColumnName = "PRAZO_ENTREGA_ITEM_ORC";
            this.dataColumn41.MaxLength = 20;
            // 
            // dataColumn43
            // 
            this.dataColumn43.ColumnName = "LUCRATIVIDADE_ITEM_ORC";
            this.dataColumn43.DataType = typeof(double);
            // 
            // dataColumn44
            // 
            this.dataColumn44.ColumnName = "MOTIVO_REJEICAO_ITEM_ORC";
            this.dataColumn44.MaxLength = 50;
            // 
            // dataColumn49
            // 
            this.dataColumn49.ColumnName = "CODIGO_ALTERNATIVO_ITEM_ORC";
            this.dataColumn49.MaxLength = 100;
            // 
            // dataColumn52
            // 
            this.dataColumn52.ColumnName = "PORC_IPI_ITEM_ORC";
            this.dataColumn52.DataType = typeof(double);
            // 
            // dataColumn53
            // 
            this.dataColumn53.ColumnName = "VALOR_IPI_ITEM_ORC";
            this.dataColumn53.DataType = typeof(double);
            // 
            // dgvItens_orcamento
            // 
            this.dgvItens_orcamento.AllowUserToAddRows = false;
            this.dgvItens_orcamento.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItens_orcamento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItens_orcamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens_orcamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_cod_item,
            this.col_item,
            this.col_cod,
            this.CODIGO_ALTERNATIVO_ITEM_ORC,
            this.col_qtde,
            this.col_valor_total,
            this.sTATUSITEMORCDataGridViewTextBoxColumn,
            this.MOTIVO_REJEICAO_ITEM_ORC,
            this.col_fresa,
            this.col_retifica_plana,
            this.col_retifica_cilindrica,
            this.col_retifica_overbeck,
            this.col_retifica_cnc,
            this.col_edm,
            this.col_torno_convencional,
            this.col_torno_cnc,
            this.col_wedm,
            this.col_centro_usinagem,
            this.col_tratamento_termico,
            this.col_servico_externo_1,
            this.col_servico_externo_2,
            this.col_servico_externo_3,
            this.col_qa,
            this.col_bancada,
            this.col_materia_prima,
            this.PRAZO_ENTREGA_ITEM_ORC,
            this.col_valor_unitario,
            this.col_lucro,
            this.col_ipi,
            this.col_valor_ipi,
            this.Aprovado,
            this.Reprovado,
            this.oBSITEMORCDataGridViewTextBoxColumn,
            this.cODORCAMENTOITEMORCDataGridViewTextBoxColumn,
            this.col_total_horas});
            this.dgvItens_orcamento.DataMember = "ITENS_ORCAMENTO";
            this.dgvItens_orcamento.DataSource = this.dsItens_orcamento;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItens_orcamento.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvItens_orcamento.Location = new System.Drawing.Point(12, 193);
            this.dgvItens_orcamento.Name = "dgvItens_orcamento";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItens_orcamento.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvItens_orcamento.Size = new System.Drawing.Size(842, 428);
            this.dgvItens_orcamento.TabIndex = 275;
            this.dgvItens_orcamento.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItens_orcamento_CellDoubleClick);
            // 
            // col_cod_item
            // 
            this.col_cod_item.DataPropertyName = "COD_ITEM_ORC";
            this.col_cod_item.HeaderText = "COD_ITEM_ORC";
            this.col_cod_item.Name = "col_cod_item";
            this.col_cod_item.Visible = false;
            // 
            // col_item
            // 
            this.col_item.DataPropertyName = "NOME_ITEM_ORC";
            this.col_item.HeaderText = "Descrição";
            this.col_item.Name = "col_item";
            this.col_item.Width = 75;
            // 
            // col_cod
            // 
            this.col_cod.DataPropertyName = "MATERIAL_ITEM_ORC";
            this.col_cod.HeaderText = "Cód. ";
            this.col_cod.Name = "col_cod";
            this.col_cod.Width = 40;
            // 
            // CODIGO_ALTERNATIVO_ITEM_ORC
            // 
            this.CODIGO_ALTERNATIVO_ITEM_ORC.DataPropertyName = "CODIGO_ALTERNATIVO_ITEM_ORC";
            this.CODIGO_ALTERNATIVO_ITEM_ORC.HeaderText = "Cód. 2";
            this.CODIGO_ALTERNATIVO_ITEM_ORC.Name = "CODIGO_ALTERNATIVO_ITEM_ORC";
            this.CODIGO_ALTERNATIVO_ITEM_ORC.Width = 40;
            // 
            // col_qtde
            // 
            this.col_qtde.DataPropertyName = "QTDE_ITEM_ORC";
            this.col_qtde.HeaderText = "Qtde";
            this.col_qtde.Name = "col_qtde";
            this.col_qtde.Width = 35;
            // 
            // col_valor_total
            // 
            this.col_valor_total.DataPropertyName = "VALOR_TOTAL_ITEM_ORC";
            this.col_valor_total.HeaderText = "Valor Total";
            this.col_valor_total.Name = "col_valor_total";
            this.col_valor_total.Width = 70;
            // 
            // sTATUSITEMORCDataGridViewTextBoxColumn
            // 
            this.sTATUSITEMORCDataGridViewTextBoxColumn.DataPropertyName = "STATUS_ITEM_ORC";
            this.sTATUSITEMORCDataGridViewTextBoxColumn.HeaderText = "Status";
            this.sTATUSITEMORCDataGridViewTextBoxColumn.Name = "sTATUSITEMORCDataGridViewTextBoxColumn";
            // 
            // MOTIVO_REJEICAO_ITEM_ORC
            // 
            this.MOTIVO_REJEICAO_ITEM_ORC.DataPropertyName = "MOTIVO_REJEICAO_ITEM_ORC";
            this.MOTIVO_REJEICAO_ITEM_ORC.HeaderText = "Motivo Rejeição";
            this.MOTIVO_REJEICAO_ITEM_ORC.Items.AddRange(new object[] {
            "Preço",
            "Prazo Entrega",
            "Prazo Resposta",
            "Outros"});
            this.MOTIVO_REJEICAO_ITEM_ORC.Name = "MOTIVO_REJEICAO_ITEM_ORC";
            this.MOTIVO_REJEICAO_ITEM_ORC.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // col_fresa
            // 
            this.col_fresa.DataPropertyName = "HORAS_FRESA_ITEM_ORC";
            this.col_fresa.HeaderText = "Fresa";
            this.col_fresa.Name = "col_fresa";
            this.col_fresa.Width = 40;
            // 
            // col_retifica_plana
            // 
            this.col_retifica_plana.DataPropertyName = "HORAS_RET_PLANA_ITEM_ORC";
            this.col_retifica_plana.HeaderText = "Retífica Plana";
            this.col_retifica_plana.Name = "col_retifica_plana";
            this.col_retifica_plana.Width = 40;
            // 
            // col_retifica_cilindrica
            // 
            this.col_retifica_cilindrica.DataPropertyName = "HORAS_RET_CILIN_ITEM_ORC";
            this.col_retifica_cilindrica.HeaderText = "Retífica Cilínd.";
            this.col_retifica_cilindrica.Name = "col_retifica_cilindrica";
            this.col_retifica_cilindrica.Width = 40;
            // 
            // col_retifica_overbeck
            // 
            this.col_retifica_overbeck.DataPropertyName = "HORAS_RET_OVER_ITEM_ORC";
            this.col_retifica_overbeck.HeaderText = "Retífica Over.";
            this.col_retifica_overbeck.Name = "col_retifica_overbeck";
            this.col_retifica_overbeck.Width = 40;
            // 
            // col_retifica_cnc
            // 
            this.col_retifica_cnc.DataPropertyName = "HORAS_RET_CNC_ITEM_ORC";
            this.col_retifica_cnc.HeaderText = "Retífica CNC";
            this.col_retifica_cnc.Name = "col_retifica_cnc";
            this.col_retifica_cnc.Width = 40;
            // 
            // col_edm
            // 
            this.col_edm.DataPropertyName = "HORAS_EDM_ITEM_ORC";
            this.col_edm.HeaderText = "EDM";
            this.col_edm.Name = "col_edm";
            this.col_edm.Width = 40;
            // 
            // col_torno_convencional
            // 
            this.col_torno_convencional.DataPropertyName = "HORAS_TORNO_CONV_ITEM_ORC";
            this.col_torno_convencional.HeaderText = "Torno Conv.";
            this.col_torno_convencional.Name = "col_torno_convencional";
            this.col_torno_convencional.Width = 40;
            // 
            // col_torno_cnc
            // 
            this.col_torno_cnc.DataPropertyName = "HORAS_TORNO_CNC_ITEM_ORC";
            this.col_torno_cnc.HeaderText = "Torno CNC";
            this.col_torno_cnc.Name = "col_torno_cnc";
            this.col_torno_cnc.Width = 40;
            // 
            // col_wedm
            // 
            this.col_wedm.DataPropertyName = "HORAS_WEDM_ITEM_ORC";
            this.col_wedm.HeaderText = "WEDM";
            this.col_wedm.Name = "col_wedm";
            this.col_wedm.Width = 40;
            // 
            // col_centro_usinagem
            // 
            this.col_centro_usinagem.DataPropertyName = "HORAS_CENTRO_USI_ITEM_ORC";
            this.col_centro_usinagem.HeaderText = "Centro Usin.";
            this.col_centro_usinagem.Name = "col_centro_usinagem";
            this.col_centro_usinagem.Width = 40;
            // 
            // col_tratamento_termico
            // 
            this.col_tratamento_termico.DataPropertyName = "HORAS_TRAT_TERM_ITEM_ORC";
            this.col_tratamento_termico.HeaderText = "Setup";
            this.col_tratamento_termico.Name = "col_tratamento_termico";
            this.col_tratamento_termico.Width = 40;
            // 
            // col_servico_externo_1
            // 
            this.col_servico_externo_1.DataPropertyName = "HORAS_SE1_ITEM_ORC";
            this.col_servico_externo_1.HeaderText = "Serviço Externo 1";
            this.col_servico_externo_1.Name = "col_servico_externo_1";
            this.col_servico_externo_1.Width = 40;
            // 
            // col_servico_externo_2
            // 
            this.col_servico_externo_2.DataPropertyName = "HORAS_SE2_ITEM_ORC";
            this.col_servico_externo_2.HeaderText = "Serviço Externo 2";
            this.col_servico_externo_2.Name = "col_servico_externo_2";
            this.col_servico_externo_2.Width = 40;
            // 
            // col_servico_externo_3
            // 
            this.col_servico_externo_3.DataPropertyName = "HORAS_SE3_ITEM_ORC";
            this.col_servico_externo_3.HeaderText = "Outros Valores";
            this.col_servico_externo_3.Name = "col_servico_externo_3";
            this.col_servico_externo_3.Width = 40;
            // 
            // col_qa
            // 
            this.col_qa.DataPropertyName = "HORAS_QA_ITEM_ORC";
            this.col_qa.HeaderText = "QA";
            this.col_qa.Name = "col_qa";
            this.col_qa.Width = 40;
            // 
            // col_bancada
            // 
            this.col_bancada.DataPropertyName = "HORAS_BANCADA_ITEM_ORC";
            this.col_bancada.HeaderText = "Banca- da";
            this.col_bancada.Name = "col_bancada";
            this.col_bancada.Width = 40;
            // 
            // col_materia_prima
            // 
            this.col_materia_prima.DataPropertyName = "VALOR_MAT_PRI_ITEM_ORC";
            this.col_materia_prima.HeaderText = "Matéria Prima";
            this.col_materia_prima.Name = "col_materia_prima";
            this.col_materia_prima.Width = 40;
            // 
            // PRAZO_ENTREGA_ITEM_ORC
            // 
            this.PRAZO_ENTREGA_ITEM_ORC.DataPropertyName = "PRAZO_ENTREGA_ITEM_ORC";
            this.PRAZO_ENTREGA_ITEM_ORC.HeaderText = "Prazo Entrega";
            this.PRAZO_ENTREGA_ITEM_ORC.Name = "PRAZO_ENTREGA_ITEM_ORC";
            this.PRAZO_ENTREGA_ITEM_ORC.Width = 40;
            // 
            // col_valor_unitario
            // 
            this.col_valor_unitario.DataPropertyName = "VALOR_UNIT_ITEM_ORC";
            this.col_valor_unitario.HeaderText = "Valor Unit";
            this.col_valor_unitario.Name = "col_valor_unitario";
            // 
            // col_lucro
            // 
            this.col_lucro.DataPropertyName = "LUCRATIVIDADE_ITEM_ORC";
            this.col_lucro.HeaderText = "Lucrat.";
            this.col_lucro.Name = "col_lucro";
            this.col_lucro.Width = 60;
            // 
            // col_ipi
            // 
            this.col_ipi.DataPropertyName = "PORC_IPI_ITEM_ORC";
            this.col_ipi.HeaderText = "IPI";
            this.col_ipi.Name = "col_ipi";
            // 
            // col_valor_ipi
            // 
            this.col_valor_ipi.DataPropertyName = "VALOR_IPI_ITEM_ORC";
            this.col_valor_ipi.HeaderText = "Valor IPI";
            this.col_valor_ipi.Name = "col_valor_ipi";
            // 
            // Aprovado
            // 
            this.Aprovado.HeaderText = "Aprovado";
            this.Aprovado.Name = "Aprovado";
            this.Aprovado.Text = "Aprovado";
            this.Aprovado.ToolTipText = "Aprovado";
            this.Aprovado.UseColumnTextForButtonValue = true;
            this.Aprovado.Width = 60;
            // 
            // Reprovado
            // 
            this.Reprovado.HeaderText = "Reprovado";
            this.Reprovado.Name = "Reprovado";
            this.Reprovado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Reprovado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Reprovado.Text = "Reprovado";
            this.Reprovado.ToolTipText = "Reprovado";
            this.Reprovado.UseColumnTextForButtonValue = true;
            this.Reprovado.Width = 70;
            // 
            // oBSITEMORCDataGridViewTextBoxColumn
            // 
            this.oBSITEMORCDataGridViewTextBoxColumn.DataPropertyName = "OBS_ITEM_ORC";
            this.oBSITEMORCDataGridViewTextBoxColumn.HeaderText = "Observações";
            this.oBSITEMORCDataGridViewTextBoxColumn.Name = "oBSITEMORCDataGridViewTextBoxColumn";
            // 
            // cODORCAMENTOITEMORCDataGridViewTextBoxColumn
            // 
            this.cODORCAMENTOITEMORCDataGridViewTextBoxColumn.DataPropertyName = "COD_ORCAMENTO_ITEM_ORC";
            this.cODORCAMENTOITEMORCDataGridViewTextBoxColumn.HeaderText = "COD_ORCAMENTO_ITEM_ORC";
            this.cODORCAMENTOITEMORCDataGridViewTextBoxColumn.Name = "cODORCAMENTOITEMORCDataGridViewTextBoxColumn";
            // 
            // col_total_horas
            // 
            this.col_total_horas.DataPropertyName = "TOTAL_HORAS_ITEM_ORC";
            this.col_total_horas.HeaderText = "Total Horas";
            this.col_total_horas.Name = "col_total_horas";
            // 
            // form_pesquisa_orcamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 633);
            this.Controls.Add(this.dgvItens_orcamento);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.tb_valor_total);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Name = "form_pesquisa_orcamentos";
            this.Text = "Pesquisa Orçamentos";
            this.Load += new System.EventHandler(this.form_pesquisa_orcamentos_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsItens_orcamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITENS_ORCAMENTO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens_orcamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtTermino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datItens_orcamento;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Windows.Forms.RadioButton rbAprovadas;
        private System.Windows.Forms.RadioButton rbReprovadas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbEm_aberto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_cliente;
        private System.Windows.Forms.TextBox tb_cnpj_cliente;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_valor_total;
        private System.Data.DataSet dsItens_orcamento;
        private System.Data.DataTable ITENS_ORCAMENTO;
        private System.Data.DataColumn COD_ITEM_ORC;
        private System.Data.DataColumn NOME_ITEM_ORC;
        private System.Data.DataColumn QTDE_ITEM_ORC;
        private System.Data.DataColumn HORAS_FRESA_ITEM_ORC;
        private System.Data.DataColumn HORAS_RET_PLANA_ITEM_ORC;
        private System.Data.DataColumn HORAS_RET_CILIN_ITEM_ORC;
        private System.Data.DataColumn HORAS_RET_OVER_ITEM_ORC;
        private System.Data.DataColumn HORAS_RET_CNC_ITEM_ORC;
        private System.Data.DataColumn HORAS_EDM_ITEM_ORC;
        private System.Data.DataColumn HORAS_TORNO_CONV_ITEM_ORC;
        private System.Data.DataColumn HORAS_TORNO_CNC_ITEM_ORC;
        private System.Data.DataColumn HORAS_WEDM_ITEM_ORC;
        private System.Data.DataColumn HORAS_CENTRO_USI_ITEM_ORC;
        private System.Data.DataColumn HORAS_TRAT_TERM_ITEM_ORC;
        private System.Data.DataColumn HORAS_SE1_ITEM_ORC;
        private System.Data.DataColumn HORAS_SE2_ITEM_ORC;
        private System.Data.DataColumn HORAS_SE3_ITEM_ORC;
        private System.Data.DataColumn HORAS_QA_ITEM_ORC;
        private System.Data.DataColumn HORAS_BANCADA_ITEM_ORC;
        private System.Data.DataColumn VALOR_TOTAL_ITEM_ORC;
        private System.Data.DataColumn STATUS_ITEM_ORC;
        private System.Data.DataColumn OBS_ITEM_ORC;
        private System.Data.DataColumn COD_ORCAMENTO_ITEM_ORC;
        private System.Data.DataColumn TOTAL_HORAS_ITEM_ORC;
        private System.Data.DataColumn VALOR_UNIT_ITEM_ORC;
        private System.Data.DataColumn VALOR_MAT_PRI_ITEM_ORC;
        private System.Data.DataColumn dataColumn40;
        private System.Data.DataColumn dataColumn41;
        private System.Data.DataColumn dataColumn43;
        private System.Data.DataColumn dataColumn44;
        private System.Data.DataColumn dataColumn49;
        private System.Data.DataColumn dataColumn52;
        private System.Data.DataColumn dataColumn53;
        private System.Windows.Forms.DataGridView dgvItens_orcamento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ALTERNATIVO_ITEM_ORC;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_qtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_valor_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTATUSITEMORCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn MOTIVO_REJEICAO_ITEM_ORC;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_retifica_plana;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_retifica_cilindrica;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_retifica_overbeck;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_retifica_cnc;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_edm;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_torno_convencional;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_torno_cnc;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_wedm;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_centro_usinagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tratamento_termico;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_servico_externo_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_servico_externo_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_servico_externo_3;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_qa;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_bancada;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_materia_prima;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRAZO_ENTREGA_ITEM_ORC;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_valor_unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_lucro;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ipi;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_valor_ipi;
        private System.Windows.Forms.DataGridViewButtonColumn Aprovado;
        private System.Windows.Forms.DataGridViewButtonColumn Reprovado;
        private System.Windows.Forms.DataGridViewTextBoxColumn oBSITEMORCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODORCAMENTOITEMORCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_total_horas;
    }
}