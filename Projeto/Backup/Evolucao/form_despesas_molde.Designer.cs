namespace Evolucao
{
    partial class form_despesas_molde
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_despesas_molde));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPgtos = new System.Windows.Forms.DataGridView();
            this.cODDESPESADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fORNECEDORDESPESADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_obs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oSDESPESADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsDespesas_molde = new System.Data.DataSet();
            this.DESPESAS_MOLDE = new System.Data.DataTable();
            this.COD_DESPESA = new System.Data.DataColumn();
            this.VALOR_DESPESA = new System.Data.DataColumn();
            this.FORNECEDOR_DESPESA = new System.Data.DataColumn();
            this.OBS_DESPESA = new System.Data.DataColumn();
            this.dataColumn1 = new System.Data.DataColumn();
            this.datDespesas_molde = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.datDesenhos = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand8 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand6 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand5 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand7 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.tb_molde = new System.Windows.Forms.TextBox();
            this.tb_total = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_horas_trab = new System.Windows.Forms.TextBox();
            this.tb_valor_trab = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_por_operacao = new System.Windows.Forms.RadioButton();
            this.rb_media = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bt_nova_despesa = new System.Windows.Forms.Button();
            this.tb_projeto = new System.Windows.Forms.TextBox();
            this.dsDesenhos = new System.Data.DataSet();
            this.DESENHOS = new System.Data.DataTable();
            this.COD_PECA = new System.Data.DataColumn();
            this.N_OS_PECA = new System.Data.DataColumn();
            this.REVISAO = new System.Data.DataColumn();
            this.MATERIAL = new System.Data.DataColumn();
            this.ESPESSURA = new System.Data.DataColumn();
            this.CLIENTE = new System.Data.DataColumn();
            this.ROTA = new System.Data.DataColumn();
            this.NOME_PECA = new System.Data.DataColumn();
            this.N_SUB = new System.Data.DataColumn();
            this.N_ROTAS = new System.Data.DataColumn();
            this.POSICAO_PECA = new System.Data.DataColumn();
            this.FUNCAO_PECA = new System.Data.DataColumn();
            this.DATA_ENTREGA_PECA = new System.Data.DataColumn();
            this.OBS_PECA = new System.Data.DataColumn();
            this.PROJETISTA_PECA = new System.Data.DataColumn();
            this.DESPESAS_MOLDE_DES = new System.Data.DataColumn();
            this.RECEITAS_MOLDE_DES = new System.Data.DataColumn();
            this.HORAS_PREV_TORNO_MOLDE = new System.Data.DataColumn();
            this.HORAS_PREV_FRESA_MOLDE = new System.Data.DataColumn();
            this.HORAS_PREV_CNC_DES_MOLDE = new System.Data.DataColumn();
            this.HORAS_PREV_TEMPERA_MOLDE = new System.Data.DataColumn();
            this.HORAS_PREV_RETIFICA_MOLDE = new System.Data.DataColumn();
            this.HORAS_PREV_CNC_ACAB_MOLDE = new System.Data.DataColumn();
            this.HORAS_PREV_EROSAO_EDM_MOLDE = new System.Data.DataColumn();
            this.HORAS_PREV_EROSAO_EWC_MOLDE = new System.Data.DataColumn();
            this.HORAS_PREV_POLIMENTO_MOLDE = new System.Data.DataColumn();
            this.HORAS_PREV_PROJETO_MOLDE = new System.Data.DataColumn();
            this.HORAS_PREV_PORTA_MOLDE_MOLDE = new System.Data.DataColumn();
            this.HORAS_PREV_ELETRODO_MOLDE = new System.Data.DataColumn();
            this.HORAS_EXEC_TORNO_MOLDE = new System.Data.DataColumn();
            this.HORAS_EXEC_FRESA_MOLDE = new System.Data.DataColumn();
            this.HORAS_EXEC_CNC_DES_MOLDE = new System.Data.DataColumn();
            this.HORAS_EXEC_TEMPERA_MOLDE = new System.Data.DataColumn();
            this.HORAS_EXEC_RETIFICA_MOLDE = new System.Data.DataColumn();
            this.HORAS_EXEC_CNC_ACAB_MOLDE = new System.Data.DataColumn();
            this.HORAS_EXEC_EROSAO_EDM_MOLDE = new System.Data.DataColumn();
            this.HORAS_EXEC_EROSAO_EWC_MOLDE = new System.Data.DataColumn();
            this.HORAS_EXEC_POLIMENTO_MOLDE = new System.Data.DataColumn();
            this.HORAS_EXEC_PROJETO_MOLDE = new System.Data.DataColumn();
            this.HORAS_EXEC_PORTA_MOLDE_MOLDE = new System.Data.DataColumn();
            this.HORAS_EXEC_ELETRODO_MOLDE = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.label17 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_total_erosao_edm = new System.Windows.Forms.TextBox();
            this.tb_valor_hora_erosao_edm = new System.Windows.Forms.TextBox();
            this.dsValor_operacao = new System.Data.DataSet();
            this.VALOR_OPERACAO = new System.Data.DataTable();
            this.COD_VALOR_OPERACAO = new System.Data.DataColumn();
            this.VALOR_FRESA_OPERACAO = new System.Data.DataColumn();
            this.VALOR_TORNO_OPERACAO = new System.Data.DataColumn();
            this.VALOR_DES_PM_ELET_OPERACAO = new System.Data.DataColumn();
            this.VALOR_RETIFICA_OPERACAO = new System.Data.DataColumn();
            this.VALOR_TEMPERA_OPERACAO = new System.Data.DataColumn();
            this.VALOR_ACAB_OPERACAO = new System.Data.DataColumn();
            this.VALOR_EROSAO_EWC_OPERACAO = new System.Data.DataColumn();
            this.VALOR_EROSAO_EDM_OPERACAO = new System.Data.DataColumn();
            this.tb_erosao_edm = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tb_total_erosao_ewc = new System.Windows.Forms.TextBox();
            this.tb_valor_hora_erosao_ewc = new System.Windows.Forms.TextBox();
            this.tb_erosao_ewc = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tb_total_acab = new System.Windows.Forms.TextBox();
            this.tb_valor_hora_acab = new System.Windows.Forms.TextBox();
            this.tb_acab = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_total_retifica = new System.Windows.Forms.TextBox();
            this.tb_valor_hora_retifica = new System.Windows.Forms.TextBox();
            this.tb_retifica = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_total_tempera = new System.Windows.Forms.TextBox();
            this.tb_valor_hora_tempera = new System.Windows.Forms.TextBox();
            this.tb_tempera = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_total_des_pm_elet = new System.Windows.Forms.TextBox();
            this.tb_valor_hora_des_pm_elet = new System.Windows.Forms.TextBox();
            this.tb_des_pm_elet = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_total_torno = new System.Windows.Forms.TextBox();
            this.tb_valor_hora_torno = new System.Windows.Forms.TextBox();
            this.tb_horas_torno = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_total_fresa = new System.Windows.Forms.TextBox();
            this.tb_valor_hora_fresa = new System.Windows.Forms.TextBox();
            this.tb_horas_fresa = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_hora = new System.Windows.Forms.TextBox();
            this.bt_capturar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_total_geral = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvReceitas = new System.Windows.Forms.DataGridView();
            this.cODRECEITADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTERECEITADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oBSRECEITADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_valor_receitas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oSRECEITADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsReceitas_molde = new System.Data.DataSet();
            this.RECEITAS_MOLDE = new System.Data.DataTable();
            this.COD_RECEITA = new System.Data.DataColumn();
            this.VALOR_RECEITA = new System.Data.DataColumn();
            this.CLIENTE_RECEITA = new System.Data.DataColumn();
            this.OBS_RECEITA = new System.Data.DataColumn();
            this.OS_RECEITA = new System.Data.DataColumn();
            this.tb_total_receitas = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_balanco = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.datReceitas_molde = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand12 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand10 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand9 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand11 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.tb_relatorio_financeiro = new System.Windows.Forms.Button();
            this.datValor_operacao = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand16 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand14 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand13 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand15 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.tb_obs = new System.Windows.Forms.TextBox();
            this.label53 = new System.Windows.Forms.Label();
            this.tb_projetista = new System.Windows.Forms.TextBox();
            this.label54 = new System.Windows.Forms.Label();
            this.tb_data = new System.Windows.Forms.TextBox();
            this.label55 = new System.Windows.Forms.Label();
            this.tb_cliente = new System.Windows.Forms.TextBox();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.label56 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPgtos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDespesas_molde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DESPESAS_MOLDE)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsDesenhos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DESENHOS)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsValor_operacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VALOR_OPERACAO)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceitas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReceitas_molde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RECEITAS_MOLDE)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Financeiro do Molde";
            // 
            // dgvPgtos
            // 
            this.dgvPgtos.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPgtos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPgtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPgtos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODDESPESADataGridViewTextBoxColumn,
            this.fORNECEDORDESPESADataGridViewTextBoxColumn,
            this.col_obs,
            this.col_valor,
            this.oSDESPESADataGridViewTextBoxColumn});
            this.dgvPgtos.DataMember = "DESPESAS_MOLDE";
            this.dgvPgtos.DataSource = this.dsDespesas_molde;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPgtos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPgtos.Location = new System.Drawing.Point(3, 3);
            this.dgvPgtos.Name = "dgvPgtos";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPgtos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPgtos.Size = new System.Drawing.Size(510, 143);
            this.dgvPgtos.TabIndex = 237;
            // 
            // cODDESPESADataGridViewTextBoxColumn
            // 
            this.cODDESPESADataGridViewTextBoxColumn.DataPropertyName = "COD_DESPESA";
            this.cODDESPESADataGridViewTextBoxColumn.HeaderText = "Cód.";
            this.cODDESPESADataGridViewTextBoxColumn.Name = "cODDESPESADataGridViewTextBoxColumn";
            this.cODDESPESADataGridViewTextBoxColumn.Width = 50;
            // 
            // fORNECEDORDESPESADataGridViewTextBoxColumn
            // 
            this.fORNECEDORDESPESADataGridViewTextBoxColumn.DataPropertyName = "FORNECEDOR_DESPESA";
            this.fORNECEDORDESPESADataGridViewTextBoxColumn.HeaderText = "Fornecedor";
            this.fORNECEDORDESPESADataGridViewTextBoxColumn.Name = "fORNECEDORDESPESADataGridViewTextBoxColumn";
            this.fORNECEDORDESPESADataGridViewTextBoxColumn.Width = 150;
            // 
            // col_obs
            // 
            this.col_obs.DataPropertyName = "OBS_DESPESA";
            this.col_obs.HeaderText = "Observação";
            this.col_obs.Name = "col_obs";
            this.col_obs.Width = 150;
            // 
            // col_valor
            // 
            this.col_valor.DataPropertyName = "VALOR_DESPESA";
            this.col_valor.HeaderText = "Valor";
            this.col_valor.Name = "col_valor";
            // 
            // oSDESPESADataGridViewTextBoxColumn
            // 
            this.oSDESPESADataGridViewTextBoxColumn.DataPropertyName = "OS_DESPESA";
            this.oSDESPESADataGridViewTextBoxColumn.HeaderText = "OS_DESPESA";
            this.oSDESPESADataGridViewTextBoxColumn.Name = "oSDESPESADataGridViewTextBoxColumn";
            this.oSDESPESADataGridViewTextBoxColumn.Visible = false;
            // 
            // dsDespesas_molde
            // 
            this.dsDespesas_molde.DataSetName = "dsDespesas_molde";
            this.dsDespesas_molde.Namespace = "http://www.tempuri.org/dsDespesas_molde.xsd";
            this.dsDespesas_molde.Tables.AddRange(new System.Data.DataTable[] {
            this.DESPESAS_MOLDE});
            // 
            // DESPESAS_MOLDE
            // 
            this.DESPESAS_MOLDE.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_DESPESA,
            this.VALOR_DESPESA,
            this.FORNECEDOR_DESPESA,
            this.OBS_DESPESA,
            this.dataColumn1});
            this.DESPESAS_MOLDE.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_DESPESA"}, true)});
            this.DESPESAS_MOLDE.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_DESPESA};
            this.DESPESAS_MOLDE.TableName = "DESPESAS_MOLDE";
            // 
            // COD_DESPESA
            // 
            this.COD_DESPESA.AllowDBNull = false;
            this.COD_DESPESA.ColumnName = "COD_DESPESA";
            this.COD_DESPESA.DataType = typeof(int);
            // 
            // VALOR_DESPESA
            // 
            this.VALOR_DESPESA.ColumnName = "VALOR_DESPESA";
            this.VALOR_DESPESA.DataType = typeof(double);
            // 
            // FORNECEDOR_DESPESA
            // 
            this.FORNECEDOR_DESPESA.ColumnName = "FORNECEDOR_DESPESA";
            this.FORNECEDOR_DESPESA.MaxLength = 100;
            // 
            // OBS_DESPESA
            // 
            this.OBS_DESPESA.ColumnName = "OBS_DESPESA";
            this.OBS_DESPESA.MaxLength = 200;
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "OS_DESPESA";
            this.dataColumn1.MaxLength = 30;
            // 
            // datDespesas_molde
            // 
            this.datDespesas_molde.DeleteCommand = this.fbCommand4;
            this.datDespesas_molde.InsertCommand = this.fbCommand2;
            this.datDespesas_molde.SelectCommand = this.fbCommand1;
            this.datDespesas_molde.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * from despesas_molde";
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
            // datDesenhos
            // 
            this.datDesenhos.DeleteCommand = this.fbCommand8;
            this.datDesenhos.InsertCommand = this.fbCommand6;
            this.datDesenhos.SelectCommand = this.fbCommand5;
            this.datDesenhos.UpdateCommand = this.fbCommand7;
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
            this.fbCommand5.CommandText = "select * from desenhos";
            this.fbCommand5.CommandTimeout = 30;
            this.fbCommand5.Connection = this.fbConnection1;
            // 
            // fbCommand7
            // 
            this.fbCommand7.CommandTimeout = 30;
            // 
            // tb_molde
            // 
            this.tb_molde.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_molde.Location = new System.Drawing.Point(242, 6);
            this.tb_molde.Name = "tb_molde";
            this.tb_molde.Size = new System.Drawing.Size(111, 31);
            this.tb_molde.TabIndex = 239;
            // 
            // tb_total
            // 
            this.tb_total.Location = new System.Drawing.Point(380, 185);
            this.tb_total.Name = "tb_total";
            this.tb_total.Size = new System.Drawing.Size(111, 20);
            this.tb_total.TabIndex = 241;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 242;
            this.label3.Text = "Sub-total";
            // 
            // tb_horas_trab
            // 
            this.tb_horas_trab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_horas_trab.Location = new System.Drawing.Point(66, 29);
            this.tb_horas_trab.Name = "tb_horas_trab";
            this.tb_horas_trab.Size = new System.Drawing.Size(110, 26);
            this.tb_horas_trab.TabIndex = 243;
            // 
            // tb_valor_trab
            // 
            this.tb_valor_trab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_valor_trab.Location = new System.Drawing.Point(390, 29);
            this.tb_valor_trab.Name = "tb_valor_trab";
            this.tb_valor_trab.Size = new System.Drawing.Size(131, 26);
            this.tb_valor_trab.TabIndex = 245;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_por_operacao);
            this.groupBox1.Controls.Add(this.rb_media);
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_hora);
            this.groupBox1.Controls.Add(this.bt_capturar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_valor_trab);
            this.groupBox1.Controls.Add(this.tb_horas_trab);
            this.groupBox1.Location = new System.Drawing.Point(18, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 336);
            this.groupBox1.TabIndex = 247;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Despesas";
            // 
            // rb_por_operacao
            // 
            this.rb_por_operacao.AutoSize = true;
            this.rb_por_operacao.Location = new System.Drawing.Point(224, 58);
            this.rb_por_operacao.Name = "rb_por_operacao";
            this.rb_por_operacao.Size = new System.Drawing.Size(117, 17);
            this.rb_por_operacao.TabIndex = 262;
            this.rb_por_operacao.TabStop = true;
            this.rb_por_operacao.Text = "Valor por Operação";
            this.rb_por_operacao.UseVisualStyleBackColor = true;
            // 
            // rb_media
            // 
            this.rb_media.AutoSize = true;
            this.rb_media.Location = new System.Drawing.Point(91, 58);
            this.rb_media.Name = "rb_media";
            this.rb_media.Size = new System.Drawing.Size(129, 17);
            this.rb_media.TabIndex = 261;
            this.rb_media.TabStop = true;
            this.rb_media.Text = "Média das Operações";
            this.rb_media.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(6, 81);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(517, 237);
            this.tabControl1.TabIndex = 260;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bt_nova_despesa);
            this.tabPage1.Controls.Add(this.tb_projeto);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.dgvPgtos);
            this.tabPage1.Controls.Add(this.tb_total);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(509, 211);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Despesas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // bt_nova_despesa
            // 
            this.bt_nova_despesa.Location = new System.Drawing.Point(6, 152);
            this.bt_nova_despesa.Name = "bt_nova_despesa";
            this.bt_nova_despesa.Size = new System.Drawing.Size(91, 26);
            this.bt_nova_despesa.TabIndex = 245;
            this.bt_nova_despesa.Text = "Excluir/Incluir";
            this.bt_nova_despesa.UseVisualStyleBackColor = true;
            this.bt_nova_despesa.Click += new System.EventHandler(this.bt_nova_despesa_Click);
            // 
            // tb_projeto
            // 
            this.tb_projeto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsDesenhos, "DESENHOS.DESPESAS_PROJETO_MOLDE", true));
            this.tb_projeto.Location = new System.Drawing.Point(380, 152);
            this.tb_projeto.Name = "tb_projeto";
            this.tb_projeto.Size = new System.Drawing.Size(111, 20);
            this.tb_projeto.TabIndex = 243;
            // 
            // dsDesenhos
            // 
            this.dsDesenhos.DataSetName = "dsDesenhos";
            this.dsDesenhos.Namespace = "http://www.tempuri.org/dsDesenhos.xsd";
            this.dsDesenhos.Tables.AddRange(new System.Data.DataTable[] {
            this.DESENHOS});
            // 
            // DESENHOS
            // 
            this.DESENHOS.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_PECA,
            this.N_OS_PECA,
            this.REVISAO,
            this.MATERIAL,
            this.ESPESSURA,
            this.CLIENTE,
            this.ROTA,
            this.NOME_PECA,
            this.N_SUB,
            this.N_ROTAS,
            this.POSICAO_PECA,
            this.FUNCAO_PECA,
            this.DATA_ENTREGA_PECA,
            this.OBS_PECA,
            this.PROJETISTA_PECA,
            this.DESPESAS_MOLDE_DES,
            this.RECEITAS_MOLDE_DES,
            this.HORAS_PREV_TORNO_MOLDE,
            this.HORAS_PREV_FRESA_MOLDE,
            this.HORAS_PREV_CNC_DES_MOLDE,
            this.HORAS_PREV_TEMPERA_MOLDE,
            this.HORAS_PREV_RETIFICA_MOLDE,
            this.HORAS_PREV_CNC_ACAB_MOLDE,
            this.HORAS_PREV_EROSAO_EDM_MOLDE,
            this.HORAS_PREV_EROSAO_EWC_MOLDE,
            this.HORAS_PREV_POLIMENTO_MOLDE,
            this.HORAS_PREV_PROJETO_MOLDE,
            this.HORAS_PREV_PORTA_MOLDE_MOLDE,
            this.HORAS_PREV_ELETRODO_MOLDE,
            this.HORAS_EXEC_TORNO_MOLDE,
            this.HORAS_EXEC_FRESA_MOLDE,
            this.HORAS_EXEC_CNC_DES_MOLDE,
            this.HORAS_EXEC_TEMPERA_MOLDE,
            this.HORAS_EXEC_RETIFICA_MOLDE,
            this.HORAS_EXEC_CNC_ACAB_MOLDE,
            this.HORAS_EXEC_EROSAO_EDM_MOLDE,
            this.HORAS_EXEC_EROSAO_EWC_MOLDE,
            this.HORAS_EXEC_POLIMENTO_MOLDE,
            this.HORAS_EXEC_PROJETO_MOLDE,
            this.HORAS_EXEC_PORTA_MOLDE_MOLDE,
            this.HORAS_EXEC_ELETRODO_MOLDE,
            this.dataColumn2,
            this.dataColumn3});
            this.DESENHOS.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_PECA"}, true)});
            this.DESENHOS.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_PECA};
            this.DESENHOS.TableName = "DESENHOS";
            // 
            // COD_PECA
            // 
            this.COD_PECA.AllowDBNull = false;
            this.COD_PECA.ColumnName = "COD_PECA";
            this.COD_PECA.DataType = typeof(int);
            // 
            // N_OS_PECA
            // 
            this.N_OS_PECA.ColumnName = "N_OS_PECA";
            this.N_OS_PECA.MaxLength = 50;
            // 
            // REVISAO
            // 
            this.REVISAO.ColumnName = "REVISAO";
            this.REVISAO.MaxLength = 10;
            // 
            // MATERIAL
            // 
            this.MATERIAL.ColumnName = "MATERIAL";
            this.MATERIAL.MaxLength = 30;
            // 
            // ESPESSURA
            // 
            this.ESPESSURA.ColumnName = "ESPESSURA";
            this.ESPESSURA.MaxLength = 10;
            // 
            // CLIENTE
            // 
            this.CLIENTE.ColumnName = "CLIENTE";
            this.CLIENTE.MaxLength = 100;
            // 
            // ROTA
            // 
            this.ROTA.ColumnName = "ROTA";
            this.ROTA.DataType = typeof(int);
            // 
            // NOME_PECA
            // 
            this.NOME_PECA.ColumnName = "NOME_PECA";
            this.NOME_PECA.MaxLength = 100;
            // 
            // N_SUB
            // 
            this.N_SUB.ColumnName = "N_SUB";
            this.N_SUB.DataType = typeof(int);
            // 
            // N_ROTAS
            // 
            this.N_ROTAS.ColumnName = "N_ROTAS";
            this.N_ROTAS.DataType = typeof(int);
            // 
            // POSICAO_PECA
            // 
            this.POSICAO_PECA.ColumnName = "POSICAO_PECA";
            this.POSICAO_PECA.MaxLength = 15;
            // 
            // FUNCAO_PECA
            // 
            this.FUNCAO_PECA.ColumnName = "FUNCAO_PECA";
            this.FUNCAO_PECA.MaxLength = 50;
            // 
            // DATA_ENTREGA_PECA
            // 
            this.DATA_ENTREGA_PECA.ColumnName = "DATA_ENTREGA_PECA";
            this.DATA_ENTREGA_PECA.DataType = typeof(System.DateTime);
            // 
            // OBS_PECA
            // 
            this.OBS_PECA.ColumnName = "OBS_PECA";
            this.OBS_PECA.MaxLength = 200;
            // 
            // PROJETISTA_PECA
            // 
            this.PROJETISTA_PECA.ColumnName = "PROJETISTA_PECA";
            this.PROJETISTA_PECA.MaxLength = 100;
            // 
            // DESPESAS_MOLDE_DES
            // 
            this.DESPESAS_MOLDE_DES.ColumnName = "DESPESAS_MOLDE_DES";
            this.DESPESAS_MOLDE_DES.DataType = typeof(double);
            // 
            // RECEITAS_MOLDE_DES
            // 
            this.RECEITAS_MOLDE_DES.ColumnName = "RECEITAS_MOLDE_DES";
            this.RECEITAS_MOLDE_DES.DataType = typeof(double);
            // 
            // HORAS_PREV_TORNO_MOLDE
            // 
            this.HORAS_PREV_TORNO_MOLDE.ColumnName = "HORAS_PREV_TORNO_MOLDE";
            this.HORAS_PREV_TORNO_MOLDE.DataType = typeof(double);
            // 
            // HORAS_PREV_FRESA_MOLDE
            // 
            this.HORAS_PREV_FRESA_MOLDE.ColumnName = "HORAS_PREV_FRESA_MOLDE";
            this.HORAS_PREV_FRESA_MOLDE.DataType = typeof(double);
            // 
            // HORAS_PREV_CNC_DES_MOLDE
            // 
            this.HORAS_PREV_CNC_DES_MOLDE.ColumnName = "HORAS_PREV_CNC_DES_MOLDE";
            this.HORAS_PREV_CNC_DES_MOLDE.DataType = typeof(double);
            // 
            // HORAS_PREV_TEMPERA_MOLDE
            // 
            this.HORAS_PREV_TEMPERA_MOLDE.ColumnName = "HORAS_PREV_TEMPERA_MOLDE";
            this.HORAS_PREV_TEMPERA_MOLDE.DataType = typeof(double);
            // 
            // HORAS_PREV_RETIFICA_MOLDE
            // 
            this.HORAS_PREV_RETIFICA_MOLDE.ColumnName = "HORAS_PREV_RETIFICA_MOLDE";
            this.HORAS_PREV_RETIFICA_MOLDE.DataType = typeof(double);
            // 
            // HORAS_PREV_CNC_ACAB_MOLDE
            // 
            this.HORAS_PREV_CNC_ACAB_MOLDE.ColumnName = "HORAS_PREV_CNC_ACAB_MOLDE";
            this.HORAS_PREV_CNC_ACAB_MOLDE.DataType = typeof(double);
            // 
            // HORAS_PREV_EROSAO_EDM_MOLDE
            // 
            this.HORAS_PREV_EROSAO_EDM_MOLDE.ColumnName = "HORAS_PREV_EROSAO_EDM_MOLDE";
            this.HORAS_PREV_EROSAO_EDM_MOLDE.DataType = typeof(double);
            // 
            // HORAS_PREV_EROSAO_EWC_MOLDE
            // 
            this.HORAS_PREV_EROSAO_EWC_MOLDE.ColumnName = "HORAS_PREV_EROSAO_EWC_MOLDE";
            this.HORAS_PREV_EROSAO_EWC_MOLDE.DataType = typeof(double);
            // 
            // HORAS_PREV_POLIMENTO_MOLDE
            // 
            this.HORAS_PREV_POLIMENTO_MOLDE.ColumnName = "HORAS_PREV_POLIMENTO_MOLDE";
            this.HORAS_PREV_POLIMENTO_MOLDE.DataType = typeof(double);
            // 
            // HORAS_PREV_PROJETO_MOLDE
            // 
            this.HORAS_PREV_PROJETO_MOLDE.ColumnName = "HORAS_PREV_PROJETO_MOLDE";
            this.HORAS_PREV_PROJETO_MOLDE.DataType = typeof(double);
            // 
            // HORAS_PREV_PORTA_MOLDE_MOLDE
            // 
            this.HORAS_PREV_PORTA_MOLDE_MOLDE.ColumnName = "HORAS_PREV_PORTA_MOLDE_MOLDE";
            this.HORAS_PREV_PORTA_MOLDE_MOLDE.DataType = typeof(double);
            // 
            // HORAS_PREV_ELETRODO_MOLDE
            // 
            this.HORAS_PREV_ELETRODO_MOLDE.ColumnName = "HORAS_PREV_ELETRODO_MOLDE";
            this.HORAS_PREV_ELETRODO_MOLDE.DataType = typeof(double);
            // 
            // HORAS_EXEC_TORNO_MOLDE
            // 
            this.HORAS_EXEC_TORNO_MOLDE.ColumnName = "HORAS_EXEC_TORNO_MOLDE";
            this.HORAS_EXEC_TORNO_MOLDE.DataType = typeof(double);
            // 
            // HORAS_EXEC_FRESA_MOLDE
            // 
            this.HORAS_EXEC_FRESA_MOLDE.ColumnName = "HORAS_EXEC_FRESA_MOLDE";
            this.HORAS_EXEC_FRESA_MOLDE.DataType = typeof(double);
            // 
            // HORAS_EXEC_CNC_DES_MOLDE
            // 
            this.HORAS_EXEC_CNC_DES_MOLDE.ColumnName = "HORAS_EXEC_CNC_DES_MOLDE";
            this.HORAS_EXEC_CNC_DES_MOLDE.DataType = typeof(double);
            // 
            // HORAS_EXEC_TEMPERA_MOLDE
            // 
            this.HORAS_EXEC_TEMPERA_MOLDE.ColumnName = "HORAS_EXEC_TEMPERA_MOLDE";
            this.HORAS_EXEC_TEMPERA_MOLDE.DataType = typeof(double);
            // 
            // HORAS_EXEC_RETIFICA_MOLDE
            // 
            this.HORAS_EXEC_RETIFICA_MOLDE.ColumnName = "HORAS_EXEC_RETIFICA_MOLDE";
            this.HORAS_EXEC_RETIFICA_MOLDE.DataType = typeof(double);
            // 
            // HORAS_EXEC_CNC_ACAB_MOLDE
            // 
            this.HORAS_EXEC_CNC_ACAB_MOLDE.ColumnName = "HORAS_EXEC_CNC_ACAB_MOLDE";
            this.HORAS_EXEC_CNC_ACAB_MOLDE.DataType = typeof(double);
            // 
            // HORAS_EXEC_EROSAO_EDM_MOLDE
            // 
            this.HORAS_EXEC_EROSAO_EDM_MOLDE.ColumnName = "HORAS_EXEC_EROSAO_EDM_MOLDE";
            this.HORAS_EXEC_EROSAO_EDM_MOLDE.DataType = typeof(double);
            // 
            // HORAS_EXEC_EROSAO_EWC_MOLDE
            // 
            this.HORAS_EXEC_EROSAO_EWC_MOLDE.ColumnName = "HORAS_EXEC_EROSAO_EWC_MOLDE";
            this.HORAS_EXEC_EROSAO_EWC_MOLDE.DataType = typeof(double);
            // 
            // HORAS_EXEC_POLIMENTO_MOLDE
            // 
            this.HORAS_EXEC_POLIMENTO_MOLDE.ColumnName = "HORAS_EXEC_POLIMENTO_MOLDE";
            this.HORAS_EXEC_POLIMENTO_MOLDE.DataType = typeof(double);
            // 
            // HORAS_EXEC_PROJETO_MOLDE
            // 
            this.HORAS_EXEC_PROJETO_MOLDE.ColumnName = "HORAS_EXEC_PROJETO_MOLDE";
            this.HORAS_EXEC_PROJETO_MOLDE.DataType = typeof(double);
            // 
            // HORAS_EXEC_PORTA_MOLDE_MOLDE
            // 
            this.HORAS_EXEC_PORTA_MOLDE_MOLDE.ColumnName = "HORAS_EXEC_PORTA_MOLDE_MOLDE";
            this.HORAS_EXEC_PORTA_MOLDE_MOLDE.DataType = typeof(double);
            // 
            // HORAS_EXEC_ELETRODO_MOLDE
            // 
            this.HORAS_EXEC_ELETRODO_MOLDE.ColumnName = "HORAS_EXEC_ELETRODO_MOLDE";
            this.HORAS_EXEC_ELETRODO_MOLDE.DataType = typeof(double);
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "HORAS_EXEC_DES_PC_ELET_MOLDE";
            this.dataColumn2.DataType = typeof(double);
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "DESPESAS_PROJETO_MOLDE";
            this.dataColumn3.DataType = typeof(double);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(258, 155);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(121, 13);
            this.label17.TabIndex = 244;
            this.label17.Text = "Total Gasto com Projeto";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.tb_total_erosao_edm);
            this.tabPage2.Controls.Add(this.tb_valor_hora_erosao_edm);
            this.tabPage2.Controls.Add(this.tb_erosao_edm);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.tb_total_erosao_ewc);
            this.tabPage2.Controls.Add(this.tb_valor_hora_erosao_ewc);
            this.tabPage2.Controls.Add(this.tb_erosao_ewc);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.tb_total_acab);
            this.tabPage2.Controls.Add(this.tb_valor_hora_acab);
            this.tabPage2.Controls.Add(this.tb_acab);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.tb_total_retifica);
            this.tabPage2.Controls.Add(this.tb_valor_hora_retifica);
            this.tabPage2.Controls.Add(this.tb_retifica);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.tb_total_tempera);
            this.tabPage2.Controls.Add(this.tb_valor_hora_tempera);
            this.tabPage2.Controls.Add(this.tb_tempera);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.tb_total_des_pm_elet);
            this.tabPage2.Controls.Add(this.tb_valor_hora_des_pm_elet);
            this.tabPage2.Controls.Add(this.tb_des_pm_elet);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.tb_total_torno);
            this.tabPage2.Controls.Add(this.tb_valor_hora_torno);
            this.tabPage2.Controls.Add(this.tb_horas_torno);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.tb_total_fresa);
            this.tabPage2.Controls.Add(this.tb_valor_hora_fresa);
            this.tabPage2.Controls.Add(this.tb_horas_fresa);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(509, 211);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Trabalho";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(89, 182);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(61, 25);
            this.button4.TabIndex = 261;
            this.button4.Text = "Atualizar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 154);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Erosão EDM";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // tb_total_erosao_edm
            // 
            this.tb_total_erosao_edm.Location = new System.Drawing.Point(413, 151);
            this.tb_total_erosao_edm.Name = "tb_total_erosao_edm";
            this.tb_total_erosao_edm.Size = new System.Drawing.Size(90, 20);
            this.tb_total_erosao_edm.TabIndex = 30;
            // 
            // tb_valor_hora_erosao_edm
            // 
            this.tb_valor_hora_erosao_edm.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsValor_operacao, "VALOR_OPERACAO.VALOR_EROSAO_EDM_OPERACAO", true));
            this.tb_valor_hora_erosao_edm.Location = new System.Drawing.Point(262, 151);
            this.tb_valor_hora_erosao_edm.Name = "tb_valor_hora_erosao_edm";
            this.tb_valor_hora_erosao_edm.Size = new System.Drawing.Size(58, 20);
            this.tb_valor_hora_erosao_edm.TabIndex = 29;
            // 
            // dsValor_operacao
            // 
            this.dsValor_operacao.DataSetName = "dsValor_operacao";
            this.dsValor_operacao.Namespace = "http://www.tempuri.org/dsValor_operacao.xsd";
            this.dsValor_operacao.Tables.AddRange(new System.Data.DataTable[] {
            this.VALOR_OPERACAO});
            // 
            // VALOR_OPERACAO
            // 
            this.VALOR_OPERACAO.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_VALOR_OPERACAO,
            this.VALOR_FRESA_OPERACAO,
            this.VALOR_TORNO_OPERACAO,
            this.VALOR_DES_PM_ELET_OPERACAO,
            this.VALOR_RETIFICA_OPERACAO,
            this.VALOR_TEMPERA_OPERACAO,
            this.VALOR_ACAB_OPERACAO,
            this.VALOR_EROSAO_EWC_OPERACAO,
            this.VALOR_EROSAO_EDM_OPERACAO});
            this.VALOR_OPERACAO.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_VALOR_OPERACAO"}, true)});
            this.VALOR_OPERACAO.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_VALOR_OPERACAO};
            this.VALOR_OPERACAO.TableName = "VALOR_OPERACAO";
            // 
            // COD_VALOR_OPERACAO
            // 
            this.COD_VALOR_OPERACAO.AllowDBNull = false;
            this.COD_VALOR_OPERACAO.ColumnName = "COD_VALOR_OPERACAO";
            this.COD_VALOR_OPERACAO.DataType = typeof(int);
            // 
            // VALOR_FRESA_OPERACAO
            // 
            this.VALOR_FRESA_OPERACAO.ColumnName = "VALOR_FRESA_OPERACAO";
            this.VALOR_FRESA_OPERACAO.DataType = typeof(double);
            // 
            // VALOR_TORNO_OPERACAO
            // 
            this.VALOR_TORNO_OPERACAO.ColumnName = "VALOR_TORNO_OPERACAO";
            this.VALOR_TORNO_OPERACAO.DataType = typeof(double);
            // 
            // VALOR_DES_PM_ELET_OPERACAO
            // 
            this.VALOR_DES_PM_ELET_OPERACAO.ColumnName = "VALOR_DES_PM_ELET_OPERACAO";
            this.VALOR_DES_PM_ELET_OPERACAO.DataType = typeof(double);
            // 
            // VALOR_RETIFICA_OPERACAO
            // 
            this.VALOR_RETIFICA_OPERACAO.ColumnName = "VALOR_RETIFICA_OPERACAO";
            this.VALOR_RETIFICA_OPERACAO.DataType = typeof(double);
            // 
            // VALOR_TEMPERA_OPERACAO
            // 
            this.VALOR_TEMPERA_OPERACAO.ColumnName = "VALOR_TEMPERA_OPERACAO";
            this.VALOR_TEMPERA_OPERACAO.DataType = typeof(double);
            // 
            // VALOR_ACAB_OPERACAO
            // 
            this.VALOR_ACAB_OPERACAO.ColumnName = "VALOR_ACAB_OPERACAO";
            this.VALOR_ACAB_OPERACAO.DataType = typeof(double);
            // 
            // VALOR_EROSAO_EWC_OPERACAO
            // 
            this.VALOR_EROSAO_EWC_OPERACAO.ColumnName = "VALOR_EROSAO_EWC_OPERACAO";
            this.VALOR_EROSAO_EWC_OPERACAO.DataType = typeof(double);
            // 
            // VALOR_EROSAO_EDM_OPERACAO
            // 
            this.VALOR_EROSAO_EDM_OPERACAO.ColumnName = "VALOR_EROSAO_EDM_OPERACAO";
            this.VALOR_EROSAO_EDM_OPERACAO.DataType = typeof(double);
            // 
            // tb_erosao_edm
            // 
            this.tb_erosao_edm.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsDesenhos, "DESENHOS.HORAS_EXEC_EROSAO_EDM_MOLDE", true));
            this.tb_erosao_edm.Location = new System.Drawing.Point(88, 151);
            this.tb_erosao_edm.Name = "tb_erosao_edm";
            this.tb_erosao_edm.Size = new System.Drawing.Size(62, 20);
            this.tb_erosao_edm.TabIndex = 28;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 133);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "Erosão EWC";
            // 
            // tb_total_erosao_ewc
            // 
            this.tb_total_erosao_ewc.Location = new System.Drawing.Point(413, 130);
            this.tb_total_erosao_ewc.Name = "tb_total_erosao_ewc";
            this.tb_total_erosao_ewc.Size = new System.Drawing.Size(90, 20);
            this.tb_total_erosao_ewc.TabIndex = 26;
            // 
            // tb_valor_hora_erosao_ewc
            // 
            this.tb_valor_hora_erosao_ewc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsValor_operacao, "VALOR_OPERACAO.VALOR_EROSAO_EWC_OPERACAO", true));
            this.tb_valor_hora_erosao_ewc.Location = new System.Drawing.Point(262, 130);
            this.tb_valor_hora_erosao_ewc.Name = "tb_valor_hora_erosao_ewc";
            this.tb_valor_hora_erosao_ewc.Size = new System.Drawing.Size(58, 20);
            this.tb_valor_hora_erosao_ewc.TabIndex = 25;
            // 
            // tb_erosao_ewc
            // 
            this.tb_erosao_ewc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsDesenhos, "DESENHOS.HORAS_EXEC_EROSAO_EWC_MOLDE", true));
            this.tb_erosao_ewc.Location = new System.Drawing.Point(88, 130);
            this.tb_erosao_ewc.Name = "tb_erosao_ewc";
            this.tb_erosao_ewc.Size = new System.Drawing.Size(62, 20);
            this.tb_erosao_ewc.TabIndex = 24;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 112);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(32, 13);
            this.label16.TabIndex = 23;
            this.label16.Text = "Acab";
            // 
            // tb_total_acab
            // 
            this.tb_total_acab.Location = new System.Drawing.Point(413, 109);
            this.tb_total_acab.Name = "tb_total_acab";
            this.tb_total_acab.Size = new System.Drawing.Size(90, 20);
            this.tb_total_acab.TabIndex = 22;
            // 
            // tb_valor_hora_acab
            // 
            this.tb_valor_hora_acab.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsValor_operacao, "VALOR_OPERACAO.VALOR_ACAB_OPERACAO", true));
            this.tb_valor_hora_acab.Location = new System.Drawing.Point(262, 109);
            this.tb_valor_hora_acab.Name = "tb_valor_hora_acab";
            this.tb_valor_hora_acab.Size = new System.Drawing.Size(58, 20);
            this.tb_valor_hora_acab.TabIndex = 21;
            // 
            // tb_acab
            // 
            this.tb_acab.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsDesenhos, "DESENHOS.HORAS_EXEC_CNC_ACAB_MOLDE", true));
            this.tb_acab.Location = new System.Drawing.Point(88, 109);
            this.tb_acab.Name = "tb_acab";
            this.tb_acab.Size = new System.Drawing.Size(62, 20);
            this.tb_acab.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 91);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Retífica";
            // 
            // tb_total_retifica
            // 
            this.tb_total_retifica.Location = new System.Drawing.Point(413, 88);
            this.tb_total_retifica.Name = "tb_total_retifica";
            this.tb_total_retifica.Size = new System.Drawing.Size(90, 20);
            this.tb_total_retifica.TabIndex = 18;
            // 
            // tb_valor_hora_retifica
            // 
            this.tb_valor_hora_retifica.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsValor_operacao, "VALOR_OPERACAO.VALOR_RETIFICA_OPERACAO", true));
            this.tb_valor_hora_retifica.Location = new System.Drawing.Point(262, 88);
            this.tb_valor_hora_retifica.Name = "tb_valor_hora_retifica";
            this.tb_valor_hora_retifica.Size = new System.Drawing.Size(58, 20);
            this.tb_valor_hora_retifica.TabIndex = 17;
            // 
            // tb_retifica
            // 
            this.tb_retifica.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsDesenhos, "DESENHOS.HORAS_EXEC_RETIFICA_MOLDE", true));
            this.tb_retifica.Location = new System.Drawing.Point(88, 88);
            this.tb_retifica.Name = "tb_retifica";
            this.tb_retifica.Size = new System.Drawing.Size(62, 20);
            this.tb_retifica.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Têmpera";
            // 
            // tb_total_tempera
            // 
            this.tb_total_tempera.Location = new System.Drawing.Point(413, 67);
            this.tb_total_tempera.Name = "tb_total_tempera";
            this.tb_total_tempera.Size = new System.Drawing.Size(90, 20);
            this.tb_total_tempera.TabIndex = 14;
            // 
            // tb_valor_hora_tempera
            // 
            this.tb_valor_hora_tempera.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsValor_operacao, "VALOR_OPERACAO.VALOR_TEMPERA_OPERACAO", true));
            this.tb_valor_hora_tempera.Location = new System.Drawing.Point(262, 67);
            this.tb_valor_hora_tempera.Name = "tb_valor_hora_tempera";
            this.tb_valor_hora_tempera.Size = new System.Drawing.Size(58, 20);
            this.tb_valor_hora_tempera.TabIndex = 13;
            // 
            // tb_tempera
            // 
            this.tb_tempera.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsDesenhos, "DESENHOS.HORAS_EXEC_TEMPERA_MOLDE", true));
            this.tb_tempera.Location = new System.Drawing.Point(88, 67);
            this.tb_tempera.Name = "tb_tempera";
            this.tb_tempera.Size = new System.Drawing.Size(62, 20);
            this.tb_tempera.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Des/PM/Elet";
            // 
            // tb_total_des_pm_elet
            // 
            this.tb_total_des_pm_elet.Location = new System.Drawing.Point(413, 46);
            this.tb_total_des_pm_elet.Name = "tb_total_des_pm_elet";
            this.tb_total_des_pm_elet.Size = new System.Drawing.Size(90, 20);
            this.tb_total_des_pm_elet.TabIndex = 10;
            // 
            // tb_valor_hora_des_pm_elet
            // 
            this.tb_valor_hora_des_pm_elet.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsValor_operacao, "VALOR_OPERACAO.VALOR_DES_PM_ELET_OPERACAO", true));
            this.tb_valor_hora_des_pm_elet.Location = new System.Drawing.Point(262, 46);
            this.tb_valor_hora_des_pm_elet.Name = "tb_valor_hora_des_pm_elet";
            this.tb_valor_hora_des_pm_elet.Size = new System.Drawing.Size(58, 20);
            this.tb_valor_hora_des_pm_elet.TabIndex = 9;
            // 
            // tb_des_pm_elet
            // 
            this.tb_des_pm_elet.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsDesenhos, "DESENHOS.HORAS_EXEC_DES_PC_ELET_MOLDE", true));
            this.tb_des_pm_elet.Location = new System.Drawing.Point(88, 46);
            this.tb_des_pm_elet.Name = "tb_des_pm_elet";
            this.tb_des_pm_elet.Size = new System.Drawing.Size(62, 20);
            this.tb_des_pm_elet.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Torno";
            // 
            // tb_total_torno
            // 
            this.tb_total_torno.Location = new System.Drawing.Point(413, 25);
            this.tb_total_torno.Name = "tb_total_torno";
            this.tb_total_torno.Size = new System.Drawing.Size(90, 20);
            this.tb_total_torno.TabIndex = 6;
            // 
            // tb_valor_hora_torno
            // 
            this.tb_valor_hora_torno.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsValor_operacao, "VALOR_OPERACAO.VALOR_TORNO_OPERACAO", true));
            this.tb_valor_hora_torno.Location = new System.Drawing.Point(262, 25);
            this.tb_valor_hora_torno.Name = "tb_valor_hora_torno";
            this.tb_valor_hora_torno.Size = new System.Drawing.Size(58, 20);
            this.tb_valor_hora_torno.TabIndex = 5;
            // 
            // tb_horas_torno
            // 
            this.tb_horas_torno.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsDesenhos, "DESENHOS.HORAS_EXEC_TORNO_MOLDE", true));
            this.tb_horas_torno.Location = new System.Drawing.Point(88, 25);
            this.tb_horas_torno.Name = "tb_horas_torno";
            this.tb_horas_torno.Size = new System.Drawing.Size(62, 20);
            this.tb_horas_torno.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Fresa";
            // 
            // tb_total_fresa
            // 
            this.tb_total_fresa.Location = new System.Drawing.Point(413, 4);
            this.tb_total_fresa.Name = "tb_total_fresa";
            this.tb_total_fresa.Size = new System.Drawing.Size(90, 20);
            this.tb_total_fresa.TabIndex = 2;
            // 
            // tb_valor_hora_fresa
            // 
            this.tb_valor_hora_fresa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsValor_operacao, "VALOR_OPERACAO.VALOR_FRESA_OPERACAO", true));
            this.tb_valor_hora_fresa.Location = new System.Drawing.Point(262, 4);
            this.tb_valor_hora_fresa.Name = "tb_valor_hora_fresa";
            this.tb_valor_hora_fresa.Size = new System.Drawing.Size(58, 20);
            this.tb_valor_hora_fresa.TabIndex = 1;
            // 
            // tb_horas_fresa
            // 
            this.tb_horas_fresa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsDesenhos, "DESENHOS.HORAS_EXEC_FRESA_MOLDE", true));
            this.tb_horas_fresa.Location = new System.Drawing.Point(88, 4);
            this.tb_horas_fresa.Name = "tb_horas_fresa";
            this.tb_horas_fresa.Size = new System.Drawing.Size(62, 20);
            this.tb_horas_fresa.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(300, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 25);
            this.button2.TabIndex = 259;
            this.button2.Text = "Atualizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(387, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 258;
            this.label5.Text = "Valor Trabalhado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 257;
            this.label2.Text = "Valor por Hora";
            // 
            // tb_hora
            // 
            this.tb_hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_hora.Location = new System.Drawing.Point(182, 29);
            this.tb_hora.Name = "tb_hora";
            this.tb_hora.Size = new System.Drawing.Size(110, 26);
            this.tb_hora.TabIndex = 256;
            // 
            // bt_capturar
            // 
            this.bt_capturar.Location = new System.Drawing.Point(402, 59);
            this.bt_capturar.Name = "bt_capturar";
            this.bt_capturar.Size = new System.Drawing.Size(119, 23);
            this.bt_capturar.TabIndex = 238;
            this.bt_capturar.Text = "Capturar Despesas";
            this.bt_capturar.UseVisualStyleBackColor = true;
            this.bt_capturar.Visible = false;
            this.bt_capturar.Click += new System.EventHandler(this.button6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 255;
            this.label4.Text = "Horas Trabalhadas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(154, 472);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 26);
            this.label6.TabIndex = 248;
            this.label6.Text = "Total das Despesas";
            // 
            // tb_total_geral
            // 
            this.tb_total_geral.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_total_geral.ForeColor = System.Drawing.Color.Red;
            this.tb_total_geral.Location = new System.Drawing.Point(363, 469);
            this.tb_total_geral.Name = "tb_total_geral";
            this.tb_total_geral.Size = new System.Drawing.Size(185, 32);
            this.tb_total_geral.TabIndex = 249;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.dgvReceitas);
            this.groupBox2.Location = new System.Drawing.Point(554, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(383, 175);
            this.groupBox2.TabIndex = 250;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Receitas";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(249, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 238;
            this.button1.Text = "Capturar Receitas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvReceitas
            // 
            this.dgvReceitas.AutoGenerateColumns = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReceitas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvReceitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODRECEITADataGridViewTextBoxColumn,
            this.cLIENTERECEITADataGridViewTextBoxColumn,
            this.oBSRECEITADataGridViewTextBoxColumn,
            this.col_valor_receitas,
            this.oSRECEITADataGridViewTextBoxColumn});
            this.dgvReceitas.DataMember = "RECEITAS_MOLDE";
            this.dgvReceitas.DataSource = this.dsReceitas_molde;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReceitas.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvReceitas.Location = new System.Drawing.Point(16, 48);
            this.dgvReceitas.Name = "dgvReceitas";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReceitas.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvReceitas.Size = new System.Drawing.Size(352, 121);
            this.dgvReceitas.TabIndex = 237;
            // 
            // cODRECEITADataGridViewTextBoxColumn
            // 
            this.cODRECEITADataGridViewTextBoxColumn.DataPropertyName = "COD_RECEITA";
            this.cODRECEITADataGridViewTextBoxColumn.HeaderText = "Cód.";
            this.cODRECEITADataGridViewTextBoxColumn.Name = "cODRECEITADataGridViewTextBoxColumn";
            this.cODRECEITADataGridViewTextBoxColumn.Width = 50;
            // 
            // cLIENTERECEITADataGridViewTextBoxColumn
            // 
            this.cLIENTERECEITADataGridViewTextBoxColumn.DataPropertyName = "CLIENTE_RECEITA";
            this.cLIENTERECEITADataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.cLIENTERECEITADataGridViewTextBoxColumn.Name = "cLIENTERECEITADataGridViewTextBoxColumn";
            this.cLIENTERECEITADataGridViewTextBoxColumn.Width = 150;
            // 
            // oBSRECEITADataGridViewTextBoxColumn
            // 
            this.oBSRECEITADataGridViewTextBoxColumn.DataPropertyName = "OBS_RECEITA";
            this.oBSRECEITADataGridViewTextBoxColumn.HeaderText = "Observações";
            this.oBSRECEITADataGridViewTextBoxColumn.Name = "oBSRECEITADataGridViewTextBoxColumn";
            this.oBSRECEITADataGridViewTextBoxColumn.Visible = false;
            this.oBSRECEITADataGridViewTextBoxColumn.Width = 150;
            // 
            // col_valor_receitas
            // 
            this.col_valor_receitas.DataPropertyName = "VALOR_RECEITA";
            this.col_valor_receitas.HeaderText = "Valor";
            this.col_valor_receitas.Name = "col_valor_receitas";
            // 
            // oSRECEITADataGridViewTextBoxColumn
            // 
            this.oSRECEITADataGridViewTextBoxColumn.DataPropertyName = "OS_RECEITA";
            this.oSRECEITADataGridViewTextBoxColumn.HeaderText = "OS_RECEITA";
            this.oSRECEITADataGridViewTextBoxColumn.Name = "oSRECEITADataGridViewTextBoxColumn";
            this.oSRECEITADataGridViewTextBoxColumn.Visible = false;
            // 
            // dsReceitas_molde
            // 
            this.dsReceitas_molde.DataSetName = "dsReceitas_molde";
            this.dsReceitas_molde.Namespace = "http://www.tempuri.org/dsReceitas_molde.xsd";
            this.dsReceitas_molde.Tables.AddRange(new System.Data.DataTable[] {
            this.RECEITAS_MOLDE});
            // 
            // RECEITAS_MOLDE
            // 
            this.RECEITAS_MOLDE.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_RECEITA,
            this.VALOR_RECEITA,
            this.CLIENTE_RECEITA,
            this.OBS_RECEITA,
            this.OS_RECEITA});
            this.RECEITAS_MOLDE.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_RECEITA"}, true)});
            this.RECEITAS_MOLDE.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_RECEITA};
            this.RECEITAS_MOLDE.TableName = "RECEITAS_MOLDE";
            // 
            // COD_RECEITA
            // 
            this.COD_RECEITA.AllowDBNull = false;
            this.COD_RECEITA.ColumnName = "COD_RECEITA";
            this.COD_RECEITA.DataType = typeof(int);
            // 
            // VALOR_RECEITA
            // 
            this.VALOR_RECEITA.ColumnName = "VALOR_RECEITA";
            this.VALOR_RECEITA.DataType = typeof(double);
            // 
            // CLIENTE_RECEITA
            // 
            this.CLIENTE_RECEITA.ColumnName = "CLIENTE_RECEITA";
            this.CLIENTE_RECEITA.MaxLength = 100;
            // 
            // OBS_RECEITA
            // 
            this.OBS_RECEITA.ColumnName = "OBS_RECEITA";
            this.OBS_RECEITA.MaxLength = 200;
            // 
            // OS_RECEITA
            // 
            this.OS_RECEITA.ColumnName = "OS_RECEITA";
            this.OS_RECEITA.MaxLength = 30;
            // 
            // tb_total_receitas
            // 
            this.tb_total_receitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_total_receitas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tb_total_receitas.Location = new System.Drawing.Point(752, 308);
            this.tb_total_receitas.Name = "tb_total_receitas";
            this.tb_total_receitas.Size = new System.Drawing.Size(185, 32);
            this.tb_total_receitas.TabIndex = 252;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(555, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(191, 26);
            this.label8.TabIndex = 251;
            this.label8.Text = "Total das Receitas";
            // 
            // tb_balanco
            // 
            this.tb_balanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_balanco.ForeColor = System.Drawing.Color.Red;
            this.tb_balanco.Location = new System.Drawing.Point(752, 469);
            this.tb_balanco.Name = "tb_balanco";
            this.tb_balanco.Size = new System.Drawing.Size(185, 32);
            this.tb_balanco.TabIndex = 254;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(622, 466);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 31);
            this.label9.TabIndex = 253;
            this.label9.Text = "Balanço";
            // 
            // datReceitas_molde
            // 
            this.datReceitas_molde.DeleteCommand = this.fbCommand12;
            this.datReceitas_molde.InsertCommand = this.fbCommand10;
            this.datReceitas_molde.SelectCommand = this.fbCommand9;
            this.datReceitas_molde.UpdateCommand = this.fbCommand11;
            // 
            // fbCommand12
            // 
            this.fbCommand12.CommandTimeout = 30;
            // 
            // fbCommand10
            // 
            this.fbCommand10.CommandTimeout = 30;
            // 
            // fbCommand9
            // 
            this.fbCommand9.CommandText = "select * from receitas_molde";
            this.fbCommand9.CommandTimeout = 30;
            this.fbCommand9.Connection = this.fbConnection1;
            // 
            // fbCommand11
            // 
            this.fbCommand11.CommandTimeout = 30;
            // 
            // tb_relatorio_financeiro
            // 
            this.tb_relatorio_financeiro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tb_relatorio_financeiro.BackgroundImage")));
            this.tb_relatorio_financeiro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tb_relatorio_financeiro.Location = new System.Drawing.Point(787, 18);
            this.tb_relatorio_financeiro.Name = "tb_relatorio_financeiro";
            this.tb_relatorio_financeiro.Size = new System.Drawing.Size(75, 60);
            this.tb_relatorio_financeiro.TabIndex = 255;
            this.tb_relatorio_financeiro.Tag = "";
            this.tb_relatorio_financeiro.UseVisualStyleBackColor = true;
            this.tb_relatorio_financeiro.Click += new System.EventHandler(this.tb_relatorio_financeiro_Click);
            // 
            // datValor_operacao
            // 
            this.datValor_operacao.DeleteCommand = this.fbCommand16;
            this.datValor_operacao.InsertCommand = this.fbCommand14;
            this.datValor_operacao.SelectCommand = this.fbCommand13;
            this.datValor_operacao.UpdateCommand = this.fbCommand15;
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
            this.fbCommand13.CommandText = "SELECT * FROM VALOR_OPERACAO";
            this.fbCommand13.CommandTimeout = 30;
            this.fbCommand13.Connection = this.fbConnection1;
            // 
            // fbCommand15
            // 
            this.fbCommand15.CommandTimeout = 30;
            // 
            // tb_obs
            // 
            this.tb_obs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsDesenhos, "DESENHOS.OBS_PECA", true));
            this.tb_obs.Location = new System.Drawing.Point(493, 66);
            this.tb_obs.Name = "tb_obs";
            this.tb_obs.Size = new System.Drawing.Size(253, 20);
            this.tb_obs.TabIndex = 265;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(414, 69);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(73, 13);
            this.label53.TabIndex = 264;
            this.label53.Text = "Observações:";
            // 
            // tb_projetista
            // 
            this.tb_projetista.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsDesenhos, "DESENHOS.PROJETISTA_PECA", true));
            this.tb_projetista.Location = new System.Drawing.Point(669, 40);
            this.tb_projetista.Name = "tb_projetista";
            this.tb_projetista.Size = new System.Drawing.Size(77, 20);
            this.tb_projetista.TabIndex = 263;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(590, 43);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(53, 13);
            this.label54.TabIndex = 262;
            this.label54.Text = "Projetista:";
            // 
            // tb_data
            // 
            this.tb_data.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsDesenhos, "DESENHOS.DATA_ENTREGA_PECA", true));
            this.tb_data.Location = new System.Drawing.Point(669, 14);
            this.tb_data.Name = "tb_data";
            this.tb_data.Size = new System.Drawing.Size(77, 20);
            this.tb_data.TabIndex = 261;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(590, 17);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(73, 13);
            this.label55.TabIndex = 260;
            this.label55.Text = "Data Entrega:";
            // 
            // tb_cliente
            // 
            this.tb_cliente.AcceptsReturn = true;
            this.tb_cliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsDesenhos, "DESENHOS.CLIENTE", true));
            this.tb_cliente.Location = new System.Drawing.Point(493, 14);
            this.tb_cliente.Name = "tb_cliente";
            this.tb_cliente.Size = new System.Drawing.Size(91, 20);
            this.tb_cliente.TabIndex = 259;
            // 
            // tb_nome
            // 
            this.tb_nome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsDesenhos, "DESENHOS.NOME_PECA", true));
            this.tb_nome.Location = new System.Drawing.Point(493, 39);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(91, 20);
            this.tb_nome.TabIndex = 258;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(394, 43);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(93, 13);
            this.label56.TabIndex = 257;
            this.label56.Text = "Nome do Produto:";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(444, 17);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(42, 13);
            this.label57.TabIndex = 256;
            this.label57.Text = "Cliente:";
            // 
            // form_despesas_molde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 530);
            this.Controls.Add(this.tb_obs);
            this.Controls.Add(this.label53);
            this.Controls.Add(this.tb_projetista);
            this.Controls.Add(this.label54);
            this.Controls.Add(this.tb_data);
            this.Controls.Add(this.label55);
            this.Controls.Add(this.tb_cliente);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.label56);
            this.Controls.Add(this.label57);
            this.Controls.Add(this.tb_relatorio_financeiro);
            this.Controls.Add(this.tb_balanco);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_total_receitas);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tb_total_geral);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tb_molde);
            this.Controls.Add(this.label1);
            this.Name = "form_despesas_molde";
            this.Text = "Despesas do Molde";
            this.Load += new System.EventHandler(this.form_despesas_molde_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPgtos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDespesas_molde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DESPESAS_MOLDE)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsDesenhos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DESENHOS)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsValor_operacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VALOR_OPERACAO)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceitas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReceitas_molde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RECEITAS_MOLDE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPgtos;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datDespesas_molde;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Data.DataSet dsDespesas_molde;
        private System.Data.DataTable DESPESAS_MOLDE;
        private System.Data.DataColumn COD_DESPESA;
        private System.Data.DataColumn VALOR_DESPESA;
        private System.Data.DataColumn FORNECEDOR_DESPESA;
        private System.Data.DataColumn OBS_DESPESA;
        private System.Data.DataColumn dataColumn1;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datDesenhos;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand8;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand6;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand5;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand7;
        private System.Windows.Forms.TextBox tb_molde;
        private System.Windows.Forms.TextBox tb_total;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_horas_trab;
        private System.Windows.Forms.TextBox tb_valor_trab;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_total_geral;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvReceitas;
        private System.Windows.Forms.TextBox tb_total_receitas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_balanco;
        private System.Windows.Forms.Label label9;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datReceitas_molde;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand12;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand10;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand9;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand11;
        private System.Data.DataSet dsReceitas_molde;
        private System.Data.DataTable RECEITAS_MOLDE;
        private System.Data.DataColumn COD_RECEITA;
        private System.Data.DataColumn VALOR_RECEITA;
        private System.Data.DataColumn CLIENTE_RECEITA;
        private System.Data.DataColumn OBS_RECEITA;
        private System.Data.DataColumn OS_RECEITA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_hora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button tb_relatorio_financeiro;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button bt_capturar;
        private System.Data.DataSet dsDesenhos;
        private System.Data.DataTable DESENHOS;
        private System.Data.DataColumn COD_PECA;
        private System.Data.DataColumn N_OS_PECA;
        private System.Data.DataColumn REVISAO;
        private System.Data.DataColumn MATERIAL;
        private System.Data.DataColumn ESPESSURA;
        private System.Data.DataColumn CLIENTE;
        private System.Data.DataColumn ROTA;
        private System.Data.DataColumn NOME_PECA;
        private System.Data.DataColumn N_SUB;
        private System.Data.DataColumn N_ROTAS;
        private System.Data.DataColumn POSICAO_PECA;
        private System.Data.DataColumn FUNCAO_PECA;
        private System.Data.DataColumn DATA_ENTREGA_PECA;
        private System.Data.DataColumn OBS_PECA;
        private System.Data.DataColumn PROJETISTA_PECA;
        private System.Data.DataColumn DESPESAS_MOLDE_DES;
        private System.Data.DataColumn RECEITAS_MOLDE_DES;
        private System.Data.DataColumn HORAS_PREV_TORNO_MOLDE;
        private System.Data.DataColumn HORAS_PREV_FRESA_MOLDE;
        private System.Data.DataColumn HORAS_PREV_CNC_DES_MOLDE;
        private System.Data.DataColumn HORAS_PREV_TEMPERA_MOLDE;
        private System.Data.DataColumn HORAS_PREV_RETIFICA_MOLDE;
        private System.Data.DataColumn HORAS_PREV_CNC_ACAB_MOLDE;
        private System.Data.DataColumn HORAS_PREV_EROSAO_EDM_MOLDE;
        private System.Data.DataColumn HORAS_PREV_EROSAO_EWC_MOLDE;
        private System.Data.DataColumn HORAS_PREV_POLIMENTO_MOLDE;
        private System.Data.DataColumn HORAS_PREV_PROJETO_MOLDE;
        private System.Data.DataColumn HORAS_PREV_PORTA_MOLDE_MOLDE;
        private System.Data.DataColumn HORAS_PREV_ELETRODO_MOLDE;
        private System.Data.DataColumn HORAS_EXEC_TORNO_MOLDE;
        private System.Data.DataColumn HORAS_EXEC_FRESA_MOLDE;
        private System.Data.DataColumn HORAS_EXEC_CNC_DES_MOLDE;
        private System.Data.DataColumn HORAS_EXEC_TEMPERA_MOLDE;
        private System.Data.DataColumn HORAS_EXEC_RETIFICA_MOLDE;
        private System.Data.DataColumn HORAS_EXEC_CNC_ACAB_MOLDE;
        private System.Data.DataColumn HORAS_EXEC_EROSAO_EDM_MOLDE;
        private System.Data.DataColumn HORAS_EXEC_EROSAO_EWC_MOLDE;
        private System.Data.DataColumn HORAS_EXEC_POLIMENTO_MOLDE;
        private System.Data.DataColumn HORAS_EXEC_PROJETO_MOLDE;
        private System.Data.DataColumn HORAS_EXEC_PORTA_MOLDE_MOLDE;
        private System.Data.DataColumn HORAS_EXEC_ELETRODO_MOLDE;
        private System.Windows.Forms.TextBox tb_valor_hora_fresa;
        private System.Windows.Forms.TextBox tb_horas_fresa;
        private System.Windows.Forms.TextBox tb_total_fresa;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_total_retifica;
        private System.Windows.Forms.TextBox tb_valor_hora_retifica;
        private System.Windows.Forms.TextBox tb_retifica;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_total_tempera;
        private System.Windows.Forms.TextBox tb_valor_hora_tempera;
        private System.Windows.Forms.TextBox tb_tempera;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_total_des_pm_elet;
        private System.Windows.Forms.TextBox tb_valor_hora_des_pm_elet;
        private System.Windows.Forms.TextBox tb_des_pm_elet;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_total_torno;
        private System.Windows.Forms.TextBox tb_valor_hora_torno;
        private System.Windows.Forms.TextBox tb_horas_torno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tb_total_erosao_edm;
        private System.Windows.Forms.TextBox tb_valor_hora_erosao_edm;
        private System.Windows.Forms.TextBox tb_erosao_edm;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tb_total_erosao_ewc;
        private System.Windows.Forms.TextBox tb_valor_hora_erosao_ewc;
        private System.Windows.Forms.TextBox tb_erosao_ewc;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tb_total_acab;
        private System.Windows.Forms.TextBox tb_valor_hora_acab;
        private System.Windows.Forms.TextBox tb_acab;
        private System.Data.DataColumn dataColumn2;
        private System.Windows.Forms.RadioButton rb_por_operacao;
        private System.Windows.Forms.RadioButton rb_media;
        private System.Windows.Forms.Button button4;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datValor_operacao;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand16;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand14;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand13;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand15;
        private System.Data.DataSet dsValor_operacao;
        private System.Data.DataTable VALOR_OPERACAO;
        private System.Data.DataColumn COD_VALOR_OPERACAO;
        private System.Data.DataColumn VALOR_FRESA_OPERACAO;
        private System.Data.DataColumn VALOR_TORNO_OPERACAO;
        private System.Data.DataColumn VALOR_DES_PM_ELET_OPERACAO;
        private System.Data.DataColumn VALOR_RETIFICA_OPERACAO;
        private System.Data.DataColumn VALOR_TEMPERA_OPERACAO;
        private System.Data.DataColumn VALOR_ACAB_OPERACAO;
        private System.Data.DataColumn VALOR_EROSAO_EWC_OPERACAO;
        private System.Data.DataColumn VALOR_EROSAO_EDM_OPERACAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODRECEITADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTERECEITADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oBSRECEITADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_valor_receitas;
        private System.Windows.Forms.DataGridViewTextBoxColumn oSRECEITADataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox tb_obs;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.TextBox tb_projetista;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.TextBox tb_data;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.TextBox tb_cliente;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.TextBox tb_projeto;
        private System.Windows.Forms.Label label17;
        private System.Data.DataColumn dataColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODDESPESADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fORNECEDORDESPESADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_obs;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn oSDESPESADataGridViewTextBoxColumn;
        private System.Windows.Forms.Button bt_nova_despesa;
    }
}