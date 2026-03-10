namespace Evolucao
{
    partial class form_semanas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_semanas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle45 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle46 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle47 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle48 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle49 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle50 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle51 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle52 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle53 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle54 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle55 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle56 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle57 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle58 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle59 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle60 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle61 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle62 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle63 = new System.Windows.Forms.DataGridViewCellStyle();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.datSemanas = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand5 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.tb_total_3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_total_4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_total_9 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_total_8 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_total_7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_total_6 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_proximo = new System.Windows.Forms.Button();
            this.tb_anterior = new System.Windows.Forms.Button();
            this.tb_semana = new System.Windows.Forms.TextBox();
            this.dsSemana_ano = new System.Data.DataSet();
            this.SEMANA_ANO = new System.Data.DataTable();
            this.COD_SEMANA_ANO = new System.Data.DataColumn();
            this.SEMANA_SEMANA_ANO = new System.Data.DataColumn();
            this.ANO_SEMANA_ANO = new System.Data.DataColumn();
            this.rbTorno = new System.Windows.Forms.RadioButton();
            this.rbFresa = new System.Windows.Forms.RadioButton();
            this.rbRetifica = new System.Windows.Forms.RadioButton();
            this.rbCnc = new System.Windows.Forms.RadioButton();
            this.rbTempera = new System.Windows.Forms.RadioButton();
            this.rbCnc_acab = new System.Windows.Forms.RadioButton();
            this.rbPolimento = new System.Windows.Forms.RadioButton();
            this.rbErosao_edm = new System.Windows.Forms.RadioButton();
            this.rbErosao_ewc = new System.Windows.Forms.RadioButton();
            this.rbMontagem = new System.Windows.Forms.RadioButton();
            this.label_operacao = new System.Windows.Forms.Label();
            this.dsOperacoes = new System.Data.DataSet();
            this.TIPOS_OPERACOES = new System.Data.DataTable();
            this.COD_TIPO = new System.Data.DataColumn();
            this.QDE_MAQUINAS = new System.Data.DataColumn();
            this.TIPO = new System.Data.DataColumn();
            this.HORAS_SEMANAIS_DISP = new System.Data.DataColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.label_horas = new System.Windows.Forms.Label();
            this.datOperacoes = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand9 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand7 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand6 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand8 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.tb_Ok = new System.Windows.Forms.Button();
            this.tb_total_5 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.dataGridView7 = new System.Windows.Forms.DataGridView();
            this.dataGridView8 = new System.Windows.Forms.DataGridView();
            this.dataGridView9 = new System.Windows.Forms.DataGridView();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.label_semana_3 = new System.Windows.Forms.Label();
            this.label_semana_4 = new System.Windows.Forms.Label();
            this.label_semana_6 = new System.Windows.Forms.Label();
            this.label_semana_7 = new System.Windows.Forms.Label();
            this.label_semana_8 = new System.Windows.Forms.Label();
            this.label_semana_9 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.bt_prox = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tb_atrasados = new System.Windows.Forms.Button();
            this.tb_orc = new System.Windows.Forms.TextBox();
            this.tb_reais = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.fbCommand13 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand11 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand10 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand12 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.cbImp_semana5 = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.datImp_semana5 = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand21 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand19 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand18 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand20 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand17 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand15 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand14 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand16 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.cbImp_semana6 = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.datImp_semana6 = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand25 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand23 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand22 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand24 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsImp_semana5 = new System.Data.DataSet();
            this.IMP_SEMANA5 = new System.Data.DataTable();
            this.COD_SEM_05 = new System.Data.DataColumn();
            this.OS_SEM_05 = new System.Data.DataColumn();
            this.POS_SEM_05 = new System.Data.DataColumn();
            this.DATA_INICIO_SEM_05 = new System.Data.DataColumn();
            this.DATA_FIM_SEM_05 = new System.Data.DataColumn();
            this.HORAS_PREV_SEM_05 = new System.Data.DataColumn();
            this.HORAS_TRAB_SEM_05 = new System.Data.DataColumn();
            this.POS_ATUAL_SEM_05 = new System.Data.DataColumn();
            this.dsImp_semana6 = new System.Data.DataSet();
            this.IMP_SEMANA6 = new System.Data.DataTable();
            this.COD_SEM_06 = new System.Data.DataColumn();
            this.OS_SEM_06 = new System.Data.DataColumn();
            this.POS_SEM_06 = new System.Data.DataColumn();
            this.DATA_INICIO_SEM_06 = new System.Data.DataColumn();
            this.DATA_FIM_SEM_06 = new System.Data.DataColumn();
            this.HORAS_PREV_SEM_06 = new System.Data.DataColumn();
            this.HORAS_TRAB_SEM_06 = new System.Data.DataColumn();
            this.POS_ATUAL_SEM_06 = new System.Data.DataColumn();
            this.datImp_semana7 = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand29 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand27 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand26 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand28 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsImp_semana7 = new System.Data.DataSet();
            this.IMP_SEMANA7 = new System.Data.DataTable();
            this.COD_SEM_07 = new System.Data.DataColumn();
            this.OS_SEM_07 = new System.Data.DataColumn();
            this.POS_SEM_07 = new System.Data.DataColumn();
            this.DATA_INICIO_SEM_07 = new System.Data.DataColumn();
            this.DATA_FIM_SEM_07 = new System.Data.DataColumn();
            this.HORAS_PREV_SEM_07 = new System.Data.DataColumn();
            this.HORAS_TRAB_SEM_07 = new System.Data.DataColumn();
            this.POS_ATUAL_SEM_07 = new System.Data.DataColumn();
            this.cbImp_semana7 = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.datImp_semana8 = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand33 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand31 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand30 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand32 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsImp_semana8 = new System.Data.DataSet();
            this.IMP_SEMANA8 = new System.Data.DataTable();
            this.COD_SEM_08 = new System.Data.DataColumn();
            this.OS_SEM_08 = new System.Data.DataColumn();
            this.POS_SEM_08 = new System.Data.DataColumn();
            this.DATA_INICIO_SEM_08 = new System.Data.DataColumn();
            this.DATA_FIM_SEM_08 = new System.Data.DataColumn();
            this.HORAS_PREV_SEM_08 = new System.Data.DataColumn();
            this.HORAS_TRAB_SEM_08 = new System.Data.DataColumn();
            this.POS_ATUAL_SEM_08 = new System.Data.DataColumn();
            this.cbImp_semana8 = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.datN_semana5 = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand37 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand35 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand34 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand36 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsN_semana5 = new System.Data.DataSet();
            this.N_SEMANA5 = new System.Data.DataTable();
            this.NUMERO_SEMANA5 = new System.Data.DataColumn();
            this.datN_semana6 = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand41 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand39 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand38 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand40 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsN_semana6 = new System.Data.DataSet();
            this.N_SEMANA6 = new System.Data.DataTable();
            this.NUMERO_SEMANA6 = new System.Data.DataColumn();
            this.datN_semana7 = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand45 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand43 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand42 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand44 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsN_semana7 = new System.Data.DataSet();
            this.N_SEMANA7 = new System.Data.DataTable();
            this.NUMERO_SEMANA7 = new System.Data.DataColumn();
            this.fbCommand46 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand47 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand48 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand49 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.datN_semana8 = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand53 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand51 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand50 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand52 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsN_semana8 = new System.Data.DataSet();
            this.N_SEMANA8 = new System.Data.DataTable();
            this.NUMERO_SEMANA8 = new System.Data.DataColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.datSemana_ano = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand57 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand55 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand54 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand56 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.label18 = new System.Windows.Forms.Label();
            this.label_ano = new System.Windows.Forms.Label();
            this.tb_saldo = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.abrirDesenhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comando_select = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.datDesenhos = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand58 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand59 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand60 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand61 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            ((System.ComponentModel.ISupportInitialize)(this.dsSemana_ano)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SEMANA_ANO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOperacoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TIPOS_OPERACOES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsImp_semana5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMP_SEMANA5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsImp_semana6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMP_SEMANA6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsImp_semana7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMP_SEMANA7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsImp_semana8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMP_SEMANA8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsN_semana5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_SEMANA5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsN_semana6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_SEMANA6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsN_semana7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_SEMANA7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsN_semana8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_SEMANA8)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fbConnection1
            // 
            this.fbConnection1.ConnectionString = resources.GetString("fbConnection1.ConnectionString");
            // 
            // fbCommand1
            // 
            this.fbCommand1.CommandTimeout = 30;
            this.fbCommand1.Connection = this.fbConnection1;
            // 
            // datSemanas
            // 
            this.datSemanas.DeleteCommand = this.fbCommand5;
            this.datSemanas.InsertCommand = this.fbCommand3;
            this.datSemanas.SelectCommand = this.fbCommand2;
            this.datSemanas.UpdateCommand = this.fbCommand4;
            // 
            // fbCommand5
            // 
            this.fbCommand5.CommandTimeout = 30;
            // 
            // fbCommand3
            // 
            this.fbCommand3.CommandTimeout = 30;
            // 
            // fbCommand2
            // 
            this.fbCommand2.CommandText = "fbCommand1";
            this.fbCommand2.CommandTimeout = 30;
            this.fbCommand2.Connection = this.fbConnection1;
            // 
            // fbCommand4
            // 
            this.fbCommand4.CommandTimeout = 30;
            // 
            // tb_total_3
            // 
            this.tb_total_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_total_3.Location = new System.Drawing.Point(362, 29);
            this.tb_total_3.Name = "tb_total_3";
            this.tb_total_3.Size = new System.Drawing.Size(46, 24);
            this.tb_total_3.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(359, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 26);
            this.label3.TabIndex = 14;
            this.label3.Text = "Total de \r\nHoras:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_total_4
            // 
            this.tb_total_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_total_4.Location = new System.Drawing.Point(595, 29);
            this.tb_total_4.Name = "tb_total_4";
            this.tb_total_4.Size = new System.Drawing.Size(44, 24);
            this.tb_total_4.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(592, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 26);
            this.label4.TabIndex = 16;
            this.label4.Text = "Total de \r\nHoras:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_total_9
            // 
            this.tb_total_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_total_9.Location = new System.Drawing.Point(593, 514);
            this.tb_total_9.Name = "tb_total_9";
            this.tb_total_9.Size = new System.Drawing.Size(46, 24);
            this.tb_total_9.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(592, 485);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 26);
            this.label5.TabIndex = 24;
            this.label5.Text = "Total de \r\nHoras:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_total_8
            // 
            this.tb_total_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_total_8.Location = new System.Drawing.Point(362, 514);
            this.tb_total_8.Name = "tb_total_8";
            this.tb_total_8.Size = new System.Drawing.Size(46, 24);
            this.tb_total_8.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(359, 485);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 26);
            this.label6.TabIndex = 22;
            this.label6.Text = "Total de \r\nHoras:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_total_7
            // 
            this.tb_total_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_total_7.Location = new System.Drawing.Point(593, 369);
            this.tb_total_7.Name = "tb_total_7";
            this.tb_total_7.Size = new System.Drawing.Size(46, 24);
            this.tb_total_7.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(592, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 26);
            this.label7.TabIndex = 20;
            this.label7.Text = "Total de \r\nHoras:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_total_6
            // 
            this.tb_total_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_total_6.Location = new System.Drawing.Point(362, 369);
            this.tb_total_6.Name = "tb_total_6";
            this.tb_total_6.Size = new System.Drawing.Size(46, 24);
            this.tb_total_6.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(359, 338);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 26);
            this.label8.TabIndex = 18;
            this.label8.Text = "Total de \r\nHoras:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(577, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(243, 58);
            this.label9.TabIndex = 26;
            this.label9.Text = "Controle dos Moldes \r\nFerramentaria";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(403, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Semana";
            // 
            // tb_proximo
            // 
            this.tb_proximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_proximo.Location = new System.Drawing.Point(474, 163);
            this.tb_proximo.Name = "tb_proximo";
            this.tb_proximo.Size = new System.Drawing.Size(75, 36);
            this.tb_proximo.TabIndex = 29;
            this.tb_proximo.Text = "PRÓXIMO";
            this.tb_proximo.UseVisualStyleBackColor = true;
            this.tb_proximo.Click += new System.EventHandler(this.tb_proximo_Click);
            // 
            // tb_anterior
            // 
            this.tb_anterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_anterior.Location = new System.Drawing.Point(302, 163);
            this.tb_anterior.Name = "tb_anterior";
            this.tb_anterior.Size = new System.Drawing.Size(75, 36);
            this.tb_anterior.TabIndex = 28;
            this.tb_anterior.Text = "ANTERIOR";
            this.tb_anterior.UseVisualStyleBackColor = true;
            this.tb_anterior.Click += new System.EventHandler(this.tb_anterior_Click);
            // 
            // tb_semana
            // 
            this.tb_semana.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSemana_ano, "SEMANA_ANO.SEMANA_SEMANA_ANO", true));
            this.tb_semana.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_semana.Location = new System.Drawing.Point(392, 163);
            this.tb_semana.Name = "tb_semana";
            this.tb_semana.Size = new System.Drawing.Size(68, 38);
            this.tb_semana.TabIndex = 1;
            this.tb_semana.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dsSemana_ano
            // 
            this.dsSemana_ano.DataSetName = "dsSemana_ano";
            this.dsSemana_ano.Namespace = "http://www.tempuri.org/dsSemana_ano.xsd";
            this.dsSemana_ano.Tables.AddRange(new System.Data.DataTable[] {
            this.SEMANA_ANO});
            // 
            // SEMANA_ANO
            // 
            this.SEMANA_ANO.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_SEMANA_ANO,
            this.SEMANA_SEMANA_ANO,
            this.ANO_SEMANA_ANO});
            this.SEMANA_ANO.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_SEMANA_ANO"}, true)});
            this.SEMANA_ANO.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_SEMANA_ANO};
            this.SEMANA_ANO.TableName = "SEMANA_ANO";
            // 
            // COD_SEMANA_ANO
            // 
            this.COD_SEMANA_ANO.AllowDBNull = false;
            this.COD_SEMANA_ANO.ColumnName = "COD_SEMANA_ANO";
            this.COD_SEMANA_ANO.DataType = typeof(int);
            // 
            // SEMANA_SEMANA_ANO
            // 
            this.SEMANA_SEMANA_ANO.ColumnName = "SEMANA_SEMANA_ANO";
            this.SEMANA_SEMANA_ANO.DataType = typeof(int);
            // 
            // ANO_SEMANA_ANO
            // 
            this.ANO_SEMANA_ANO.ColumnName = "ANO_SEMANA_ANO";
            this.ANO_SEMANA_ANO.DataType = typeof(int);
            // 
            // rbTorno
            // 
            this.rbTorno.AutoSize = true;
            this.rbTorno.Location = new System.Drawing.Point(302, 243);
            this.rbTorno.Name = "rbTorno";
            this.rbTorno.Size = new System.Drawing.Size(53, 17);
            this.rbTorno.TabIndex = 31;
            this.rbTorno.TabStop = true;
            this.rbTorno.Text = "Torno";
            this.rbTorno.UseVisualStyleBackColor = true;
            this.rbTorno.CheckedChanged += new System.EventHandler(this.rbTorno_CheckedChanged);
            // 
            // rbFresa
            // 
            this.rbFresa.AutoSize = true;
            this.rbFresa.Location = new System.Drawing.Point(399, 243);
            this.rbFresa.Name = "rbFresa";
            this.rbFresa.Size = new System.Drawing.Size(51, 17);
            this.rbFresa.TabIndex = 32;
            this.rbFresa.TabStop = true;
            this.rbFresa.Text = "Fresa";
            this.rbFresa.UseVisualStyleBackColor = true;
            this.rbFresa.CheckedChanged += new System.EventHandler(this.rbFresa_CheckedChanged);
            // 
            // rbRetifica
            // 
            this.rbRetifica.AutoSize = true;
            this.rbRetifica.Location = new System.Drawing.Point(491, 289);
            this.rbRetifica.Name = "rbRetifica";
            this.rbRetifica.Size = new System.Drawing.Size(63, 17);
            this.rbRetifica.TabIndex = 33;
            this.rbRetifica.TabStop = true;
            this.rbRetifica.Text = "Retífica";
            this.rbRetifica.UseVisualStyleBackColor = true;
            this.rbRetifica.CheckedChanged += new System.EventHandler(this.rbRetifica_CheckedChanged);
            // 
            // rbCnc
            // 
            this.rbCnc.AutoSize = true;
            this.rbCnc.Location = new System.Drawing.Point(302, 266);
            this.rbCnc.Name = "rbCnc";
            this.rbCnc.Size = new System.Drawing.Size(101, 17);
            this.rbCnc.TabIndex = 34;
            this.rbCnc.TabStop = true;
            this.rbCnc.Text = "CNC (Desbaste)";
            this.rbCnc.UseVisualStyleBackColor = true;
            this.rbCnc.CheckedChanged += new System.EventHandler(this.rbCnc_CheckedChanged);
            // 
            // rbTempera
            // 
            this.rbTempera.AutoSize = true;
            this.rbTempera.Location = new System.Drawing.Point(399, 312);
            this.rbTempera.Name = "rbTempera";
            this.rbTempera.Size = new System.Drawing.Size(67, 17);
            this.rbTempera.TabIndex = 35;
            this.rbTempera.TabStop = true;
            this.rbTempera.Text = "Têmpera";
            this.rbTempera.UseVisualStyleBackColor = true;
            this.rbTempera.CheckedChanged += new System.EventHandler(this.rbTempera_CheckedChanged);
            // 
            // rbCnc_acab
            // 
            this.rbCnc_acab.AutoSize = true;
            this.rbCnc_acab.Location = new System.Drawing.Point(399, 266);
            this.rbCnc_acab.Name = "rbCnc_acab";
            this.rbCnc_acab.Size = new System.Drawing.Size(84, 17);
            this.rbCnc_acab.TabIndex = 36;
            this.rbCnc_acab.TabStop = true;
            this.rbCnc_acab.Text = "CNC (Acab.)";
            this.rbCnc_acab.UseVisualStyleBackColor = true;
            this.rbCnc_acab.CheckedChanged += new System.EventHandler(this.rbCnc_acab_CheckedChanged);
            // 
            // rbPolimento
            // 
            this.rbPolimento.AutoSize = true;
            this.rbPolimento.Location = new System.Drawing.Point(302, 312);
            this.rbPolimento.Name = "rbPolimento";
            this.rbPolimento.Size = new System.Drawing.Size(71, 17);
            this.rbPolimento.TabIndex = 39;
            this.rbPolimento.TabStop = true;
            this.rbPolimento.Text = "Polimento";
            this.rbPolimento.UseVisualStyleBackColor = true;
            this.rbPolimento.CheckedChanged += new System.EventHandler(this.rbPolimento_CheckedChanged);
            // 
            // rbErosao_edm
            // 
            this.rbErosao_edm.AutoSize = true;
            this.rbErosao_edm.Location = new System.Drawing.Point(399, 289);
            this.rbErosao_edm.Name = "rbErosao_edm";
            this.rbErosao_edm.Size = new System.Drawing.Size(91, 17);
            this.rbErosao_edm.TabIndex = 38;
            this.rbErosao_edm.TabStop = true;
            this.rbErosao_edm.Text = "Erosão (EDM)";
            this.rbErosao_edm.UseVisualStyleBackColor = true;
            this.rbErosao_edm.CheckedChanged += new System.EventHandler(this.rbErosao_edm_CheckedChanged);
            // 
            // rbErosao_ewc
            // 
            this.rbErosao_ewc.AutoSize = true;
            this.rbErosao_ewc.Location = new System.Drawing.Point(302, 289);
            this.rbErosao_ewc.Name = "rbErosao_ewc";
            this.rbErosao_ewc.Size = new System.Drawing.Size(92, 17);
            this.rbErosao_ewc.TabIndex = 37;
            this.rbErosao_ewc.TabStop = true;
            this.rbErosao_ewc.Text = "Erosão (EWC)";
            this.rbErosao_ewc.UseVisualStyleBackColor = true;
            this.rbErosao_ewc.CheckedChanged += new System.EventHandler(this.rbErosao_ewc_CheckedChanged);
            // 
            // rbMontagem
            // 
            this.rbMontagem.AutoSize = true;
            this.rbMontagem.Location = new System.Drawing.Point(491, 312);
            this.rbMontagem.Name = "rbMontagem";
            this.rbMontagem.Size = new System.Drawing.Size(75, 17);
            this.rbMontagem.TabIndex = 40;
            this.rbMontagem.TabStop = true;
            this.rbMontagem.Text = "Montagem";
            this.rbMontagem.UseVisualStyleBackColor = true;
            this.rbMontagem.CheckedChanged += new System.EventHandler(this.rbMontagem_CheckedChanged);
            // 
            // label_operacao
            // 
            this.label_operacao.AutoSize = true;
            this.label_operacao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsOperacoes, "TIPOS_OPERACOES.TIPO", true));
            this.label_operacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_operacao.ForeColor = System.Drawing.Color.Blue;
            this.label_operacao.Location = new System.Drawing.Point(590, 243);
            this.label_operacao.Name = "label_operacao";
            this.label_operacao.Size = new System.Drawing.Size(245, 25);
            this.label_operacao.TabIndex = 41;
            this.label_operacao.Text = "Selecione a Operação";
            this.label_operacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dsOperacoes
            // 
            this.dsOperacoes.DataSetName = "dsOperacoes";
            this.dsOperacoes.Namespace = "http://www.tempuri.org/dsOperacoes.xsd";
            this.dsOperacoes.Tables.AddRange(new System.Data.DataTable[] {
            this.TIPOS_OPERACOES});
            // 
            // TIPOS_OPERACOES
            // 
            this.TIPOS_OPERACOES.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_TIPO,
            this.QDE_MAQUINAS,
            this.TIPO,
            this.HORAS_SEMANAIS_DISP});
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
            // HORAS_SEMANAIS_DISP
            // 
            this.HORAS_SEMANAIS_DISP.ColumnName = "HORAS_SEMANAIS_DISP";
            this.HORAS_SEMANAIS_DISP.DataType = typeof(int);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(592, 270);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 13);
            this.label11.TabIndex = 42;
            this.label11.Text = "Horas Disponíveis:";
            // 
            // label_horas
            // 
            this.label_horas.AutoSize = true;
            this.label_horas.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsOperacoes, "TIPOS_OPERACOES.HORAS_SEMANAIS_DISP", true));
            this.label_horas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_horas.Location = new System.Drawing.Point(695, 265);
            this.label_horas.Name = "label_horas";
            this.label_horas.Size = new System.Drawing.Size(49, 20);
            this.label_horas.TabIndex = 43;
            this.label_horas.Text = "horas";
            // 
            // datOperacoes
            // 
            this.datOperacoes.DeleteCommand = this.fbCommand9;
            this.datOperacoes.InsertCommand = this.fbCommand7;
            this.datOperacoes.SelectCommand = this.fbCommand6;
            this.datOperacoes.UpdateCommand = this.fbCommand8;
            // 
            // fbCommand9
            // 
            this.fbCommand9.CommandTimeout = 30;
            // 
            // fbCommand7
            // 
            this.fbCommand7.CommandTimeout = 30;
            // 
            // fbCommand6
            // 
            this.fbCommand6.CommandText = "select * from tipos_operacoes";
            this.fbCommand6.CommandTimeout = 30;
            this.fbCommand6.Connection = this.fbConnection1;
            // 
            // fbCommand8
            // 
            this.fbCommand8.CommandTimeout = 30;
            // 
            // tb_Ok
            // 
            this.tb_Ok.Location = new System.Drawing.Point(302, 214);
            this.tb_Ok.Name = "tb_Ok";
            this.tb_Ok.Size = new System.Drawing.Size(247, 23);
            this.tb_Ok.TabIndex = 44;
            this.tb_Ok.Text = "OK";
            this.tb_Ok.UseVisualStyleBackColor = true;
            this.tb_Ok.Click += new System.EventHandler(this.tb_Ok_Click);
            // 
            // tb_total_5
            // 
            this.tb_total_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_total_5.Location = new System.Drawing.Point(234, 29);
            this.tb_total_5.Name = "tb_total_5";
            this.tb_total_5.Size = new System.Drawing.Size(77, 40);
            this.tb_total_5.TabIndex = 46;
            this.tb_total_5.TextChanged += new System.EventHandler(this.tb_total_5_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(235, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 13);
            this.label13.TabIndex = 45;
            this.label13.Text = "Total de Horas:";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            dataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle43.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle43.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle43.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle43.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle43.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle43.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle43;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle44.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle44.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle44.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle44.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle44.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle44.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView3.DefaultCellStyle = dataGridViewCellStyle44;
            this.dataGridView3.Location = new System.Drawing.Point(414, 4);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            dataGridViewCellStyle45.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle45.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle45.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle45.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle45.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle45.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle45.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView3.RowHeadersDefaultCellStyle = dataGridViewCellStyle45;
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.Size = new System.Drawing.Size(175, 141);
            this.dataGridView3.TabIndex = 48;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            dataGridViewCellStyle46.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle46.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle46.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle46.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle46.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle46.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle46.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView4.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle46;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle47.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle47.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle47.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle47.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle47.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle47.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle47.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView4.DefaultCellStyle = dataGridViewCellStyle47;
            this.dataGridView4.Location = new System.Drawing.Point(645, 4);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            dataGridViewCellStyle48.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle48.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle48.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle48.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle48.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle48.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle48.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView4.RowHeadersDefaultCellStyle = dataGridViewCellStyle48;
            this.dataGridView4.RowHeadersVisible = false;
            this.dataGridView4.Size = new System.Drawing.Size(175, 141);
            this.dataGridView4.TabIndex = 49;
            // 
            // dataGridView6
            // 
            this.dataGridView6.AllowUserToAddRows = false;
            this.dataGridView6.AllowUserToDeleteRows = false;
            dataGridViewCellStyle49.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle49.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle49.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle49.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle49.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle49.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle49.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView6.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle49;
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle50.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle50.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle50.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle50.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle50.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle50.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle50.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView6.DefaultCellStyle = dataGridViewCellStyle50;
            this.dataGridView6.Location = new System.Drawing.Point(414, 338);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.ReadOnly = true;
            dataGridViewCellStyle51.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle51.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle51.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle51.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle51.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle51.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle51.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView6.RowHeadersDefaultCellStyle = dataGridViewCellStyle51;
            this.dataGridView6.RowHeadersVisible = false;
            this.dataGridView6.Size = new System.Drawing.Size(175, 141);
            this.dataGridView6.TabIndex = 53;
            // 
            // dataGridView7
            // 
            this.dataGridView7.AllowUserToAddRows = false;
            this.dataGridView7.AllowUserToDeleteRows = false;
            dataGridViewCellStyle52.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle52.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle52.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle52.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle52.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle52.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle52.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView7.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle52;
            this.dataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle53.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle53.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle53.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle53.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle53.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle53.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle53.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView7.DefaultCellStyle = dataGridViewCellStyle53;
            this.dataGridView7.Location = new System.Drawing.Point(645, 338);
            this.dataGridView7.Name = "dataGridView7";
            this.dataGridView7.ReadOnly = true;
            dataGridViewCellStyle54.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle54.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle54.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle54.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle54.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle54.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle54.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView7.RowHeadersDefaultCellStyle = dataGridViewCellStyle54;
            this.dataGridView7.RowHeadersVisible = false;
            this.dataGridView7.Size = new System.Drawing.Size(175, 141);
            this.dataGridView7.TabIndex = 52;
            // 
            // dataGridView8
            // 
            this.dataGridView8.AllowUserToAddRows = false;
            this.dataGridView8.AllowUserToDeleteRows = false;
            dataGridViewCellStyle55.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle55.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle55.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle55.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle55.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle55.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle55.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView8.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle55;
            this.dataGridView8.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle56.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle56.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle56.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle56.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle56.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle56.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle56.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView8.DefaultCellStyle = dataGridViewCellStyle56;
            this.dataGridView8.Location = new System.Drawing.Point(414, 485);
            this.dataGridView8.Name = "dataGridView8";
            this.dataGridView8.ReadOnly = true;
            dataGridViewCellStyle57.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle57.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle57.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle57.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle57.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle57.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle57.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView8.RowHeadersDefaultCellStyle = dataGridViewCellStyle57;
            this.dataGridView8.RowHeadersVisible = false;
            this.dataGridView8.Size = new System.Drawing.Size(175, 141);
            this.dataGridView8.TabIndex = 51;
            // 
            // dataGridView9
            // 
            this.dataGridView9.AllowUserToAddRows = false;
            this.dataGridView9.AllowUserToDeleteRows = false;
            dataGridViewCellStyle58.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle58.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle58.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle58.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle58.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle58.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle58.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView9.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle58;
            this.dataGridView9.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle59.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle59.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle59.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle59.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle59.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle59.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle59.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView9.DefaultCellStyle = dataGridViewCellStyle59;
            this.dataGridView9.Location = new System.Drawing.Point(645, 485);
            this.dataGridView9.Name = "dataGridView9";
            this.dataGridView9.ReadOnly = true;
            dataGridViewCellStyle60.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle60.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle60.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle60.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle60.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle60.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle60.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView9.RowHeadersDefaultCellStyle = dataGridViewCellStyle60;
            this.dataGridView9.RowHeadersVisible = false;
            this.dataGridView9.Size = new System.Drawing.Size(175, 141);
            this.dataGridView9.TabIndex = 50;
            // 
            // dataGridView5
            // 
            this.dataGridView5.AllowUserToAddRows = false;
            dataGridViewCellStyle61.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle61.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle61.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle61.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle61.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle61.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle61.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView5.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle61;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle62.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle62.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle62.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle62.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle62.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle62.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle62.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView5.DefaultCellStyle = dataGridViewCellStyle62;
            this.dataGridView5.Location = new System.Drawing.Point(9, 4);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.ReadOnly = true;
            dataGridViewCellStyle63.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle63.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle63.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle63.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle63.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle63.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle63.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView5.RowHeadersDefaultCellStyle = dataGridViewCellStyle63;
            this.dataGridView5.RowHeadersWidth = 21;
            this.dataGridView5.Size = new System.Drawing.Size(219, 588);
            this.dataGridView5.TabIndex = 54;
            this.dataGridView5.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.dataGridView5_CellContextMenuStripNeeded);
            this.dataGridView5.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView5_CellMouseDoubleClick);
            this.dataGridView5.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView5_CellContentClick);
            // 
            // label_semana_3
            // 
            this.label_semana_3.AutoSize = true;
            this.label_semana_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_semana_3.ForeColor = System.Drawing.Color.Blue;
            this.label_semana_3.Location = new System.Drawing.Point(366, 77);
            this.label_semana_3.Name = "label_semana_3";
            this.label_semana_3.Size = new System.Drawing.Size(34, 31);
            this.label_semana_3.TabIndex = 57;
            this.label_semana_3.Text = "N";
            this.label_semana_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_semana_4
            // 
            this.label_semana_4.AutoSize = true;
            this.label_semana_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_semana_4.ForeColor = System.Drawing.Color.Blue;
            this.label_semana_4.Location = new System.Drawing.Point(597, 77);
            this.label_semana_4.Name = "label_semana_4";
            this.label_semana_4.Size = new System.Drawing.Size(34, 31);
            this.label_semana_4.TabIndex = 60;
            this.label_semana_4.Text = "N";
            this.label_semana_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_semana_6
            // 
            this.label_semana_6.AutoSize = true;
            this.label_semana_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_semana_6.ForeColor = System.Drawing.Color.Blue;
            this.label_semana_6.Location = new System.Drawing.Point(366, 419);
            this.label_semana_6.Name = "label_semana_6";
            this.label_semana_6.Size = new System.Drawing.Size(34, 31);
            this.label_semana_6.TabIndex = 63;
            this.label_semana_6.Text = "N";
            this.label_semana_6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_semana_7
            // 
            this.label_semana_7.AutoSize = true;
            this.label_semana_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_semana_7.ForeColor = System.Drawing.Color.Blue;
            this.label_semana_7.Location = new System.Drawing.Point(597, 419);
            this.label_semana_7.Name = "label_semana_7";
            this.label_semana_7.Size = new System.Drawing.Size(34, 31);
            this.label_semana_7.TabIndex = 66;
            this.label_semana_7.Text = "N";
            this.label_semana_7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_semana_8
            // 
            this.label_semana_8.AutoSize = true;
            this.label_semana_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_semana_8.ForeColor = System.Drawing.Color.Blue;
            this.label_semana_8.Location = new System.Drawing.Point(366, 561);
            this.label_semana_8.Name = "label_semana_8";
            this.label_semana_8.Size = new System.Drawing.Size(34, 31);
            this.label_semana_8.TabIndex = 69;
            this.label_semana_8.Text = "N";
            this.label_semana_8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_semana_9
            // 
            this.label_semana_9.AutoSize = true;
            this.label_semana_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_semana_9.ForeColor = System.Drawing.Color.Blue;
            this.label_semana_9.Location = new System.Drawing.Point(597, 561);
            this.label_semana_9.Name = "label_semana_9";
            this.label_semana_9.Size = new System.Drawing.Size(34, 31);
            this.label_semana_9.TabIndex = 72;
            this.label_semana_9.Text = "N";
            this.label_semana_9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(491, 243);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(76, 17);
            this.radioButton1.TabIndex = 73;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Fresa P.M.";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(491, 265);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(79, 17);
            this.radioButton2.TabIndex = 74;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "CNC HAAS";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // bt_prox
            // 
            this.bt_prox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_prox.Location = new System.Drawing.Point(238, 456);
            this.bt_prox.Name = "bt_prox";
            this.bt_prox.Size = new System.Drawing.Size(73, 23);
            this.bt_prox.TabIndex = 75;
            this.bt_prox.Text = ">>";
            this.bt_prox.UseVisualStyleBackColor = true;
            this.bt_prox.Click += new System.EventHandler(this.bt_prox_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.GreenYellow;
            this.panel1.Location = new System.Drawing.Point(12, 640);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(14, 18);
            this.panel1.TabIndex = 77;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 645);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 78;
            this.label1.Text = "Finalizado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 645);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 80;
            this.label2.Text = "Atrasado";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Location = new System.Drawing.Point(92, 640);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(14, 18);
            this.panel2.TabIndex = 79;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(190, 645);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 82;
            this.label12.Text = "Aguardando";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Yellow;
            this.panel3.Location = new System.Drawing.Point(170, 640);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(14, 18);
            this.panel3.TabIndex = 81;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(385, 645);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 84;
            this.label14.Text = "Parada";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Green;
            this.panel4.Location = new System.Drawing.Point(261, 640);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(14, 18);
            this.panel4.TabIndex = 83;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(281, 645);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 13);
            this.label15.TabIndex = 86;
            this.label15.Text = "Em andamento";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Orange;
            this.panel5.Location = new System.Drawing.Point(365, 640);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(14, 18);
            this.panel5.TabIndex = 85;
            // 
            // tb_atrasados
            // 
            this.tb_atrasados.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_atrasados.ForeColor = System.Drawing.Color.Red;
            this.tb_atrasados.Location = new System.Drawing.Point(238, 345);
            this.tb_atrasados.Name = "tb_atrasados";
            this.tb_atrasados.Size = new System.Drawing.Size(73, 36);
            this.tb_atrasados.TabIndex = 87;
            this.tb_atrasados.Text = "Passar Atrasados";
            this.tb_atrasados.UseVisualStyleBackColor = true;
            this.tb_atrasados.Click += new System.EventHandler(this.tb_atrasados_Click);
            // 
            // tb_orc
            // 
            this.tb_orc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_orc.Location = new System.Drawing.Point(156, 598);
            this.tb_orc.Name = "tb_orc";
            this.tb_orc.Size = new System.Drawing.Size(31, 22);
            this.tb_orc.TabIndex = 88;
            // 
            // tb_reais
            // 
            this.tb_reais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_reais.Location = new System.Drawing.Point(193, 598);
            this.tb_reais.Name = "tb_reais";
            this.tb_reais.Size = new System.Drawing.Size(31, 22);
            this.tb_reais.TabIndex = 89;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(154, 621);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(23, 12);
            this.label16.TabIndex = 90;
            this.label16.Text = "Orç.";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(191, 621);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 12);
            this.label17.TabIndex = 91;
            this.label17.Text = "Reais";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(238, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 50);
            this.button1.TabIndex = 92;
            this.button1.Text = "Passar Não\r\nFinalizados";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(238, 556);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 36);
            this.button2.TabIndex = 93;
            this.button2.Text = "Imprimir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // fbCommand13
            // 
            this.fbCommand13.CommandTimeout = 30;
            // 
            // fbCommand11
            // 
            this.fbCommand11.CommandTimeout = 30;
            // 
            // fbCommand10
            // 
            this.fbCommand10.CommandText = "SELECT * FROM IMP_SEMANA5";
            this.fbCommand10.CommandTimeout = 30;
            this.fbCommand10.Connection = this.fbConnection1;
            // 
            // fbCommand12
            // 
            this.fbCommand12.CommandTimeout = 30;
            // 
            // cbImp_semana5
            // 
            this.cbImp_semana5.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbImp_semana5.DataAdapter = this.datImp_semana5;
            this.cbImp_semana5.QuotePrefix = "\"";
            this.cbImp_semana5.QuoteSuffix = "\"";
            // 
            // datImp_semana5
            // 
            this.datImp_semana5.DeleteCommand = this.fbCommand21;
            this.datImp_semana5.InsertCommand = this.fbCommand19;
            this.datImp_semana5.SelectCommand = this.fbCommand18;
            this.datImp_semana5.UpdateCommand = this.fbCommand20;
            // 
            // fbCommand21
            // 
            this.fbCommand21.CommandTimeout = 30;
            // 
            // fbCommand19
            // 
            this.fbCommand19.CommandTimeout = 30;
            // 
            // fbCommand18
            // 
            this.fbCommand18.CommandText = "select * from imp_semana5";
            this.fbCommand18.CommandTimeout = 30;
            this.fbCommand18.Connection = this.fbConnection1;
            // 
            // fbCommand20
            // 
            this.fbCommand20.CommandTimeout = 30;
            // 
            // fbCommand17
            // 
            this.fbCommand17.CommandTimeout = 30;
            // 
            // fbCommand15
            // 
            this.fbCommand15.CommandTimeout = 30;
            // 
            // fbCommand14
            // 
            this.fbCommand14.CommandText = "select * from imp_semana6";
            this.fbCommand14.CommandTimeout = 30;
            this.fbCommand14.Connection = this.fbConnection1;
            // 
            // fbCommand16
            // 
            this.fbCommand16.CommandTimeout = 30;
            // 
            // cbImp_semana6
            // 
            this.cbImp_semana6.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbImp_semana6.DataAdapter = this.datImp_semana6;
            this.cbImp_semana6.QuotePrefix = "\"";
            this.cbImp_semana6.QuoteSuffix = "\"";
            // 
            // datImp_semana6
            // 
            this.datImp_semana6.DeleteCommand = this.fbCommand25;
            this.datImp_semana6.InsertCommand = this.fbCommand23;
            this.datImp_semana6.SelectCommand = this.fbCommand22;
            this.datImp_semana6.UpdateCommand = this.fbCommand24;
            // 
            // fbCommand25
            // 
            this.fbCommand25.CommandTimeout = 30;
            // 
            // fbCommand23
            // 
            this.fbCommand23.CommandTimeout = 30;
            // 
            // fbCommand22
            // 
            this.fbCommand22.CommandText = "select * from imp_semana6";
            this.fbCommand22.CommandTimeout = 30;
            this.fbCommand22.Connection = this.fbConnection1;
            // 
            // fbCommand24
            // 
            this.fbCommand24.CommandTimeout = 30;
            // 
            // dsImp_semana5
            // 
            this.dsImp_semana5.DataSetName = "dsImp_semana5";
            this.dsImp_semana5.Namespace = "http://www.tempuri.org/dsImp_semana5.xsd";
            this.dsImp_semana5.Tables.AddRange(new System.Data.DataTable[] {
            this.IMP_SEMANA5});
            // 
            // IMP_SEMANA5
            // 
            this.IMP_SEMANA5.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_SEM_05,
            this.OS_SEM_05,
            this.POS_SEM_05,
            this.DATA_INICIO_SEM_05,
            this.DATA_FIM_SEM_05,
            this.HORAS_PREV_SEM_05,
            this.HORAS_TRAB_SEM_05,
            this.POS_ATUAL_SEM_05});
            this.IMP_SEMANA5.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_SEM_05"}, true)});
            this.IMP_SEMANA5.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_SEM_05};
            this.IMP_SEMANA5.TableName = "IMP_SEMANA5";
            // 
            // COD_SEM_05
            // 
            this.COD_SEM_05.AllowDBNull = false;
            this.COD_SEM_05.ColumnName = "COD_SEM_05";
            this.COD_SEM_05.DataType = typeof(int);
            // 
            // OS_SEM_05
            // 
            this.OS_SEM_05.ColumnName = "OS_SEM_05";
            this.OS_SEM_05.MaxLength = 30;
            // 
            // POS_SEM_05
            // 
            this.POS_SEM_05.ColumnName = "POS_SEM_05";
            this.POS_SEM_05.MaxLength = 30;
            // 
            // DATA_INICIO_SEM_05
            // 
            this.DATA_INICIO_SEM_05.ColumnName = "DATA_INICIO_SEM_05";
            this.DATA_INICIO_SEM_05.DataType = typeof(System.DateTime);
            // 
            // DATA_FIM_SEM_05
            // 
            this.DATA_FIM_SEM_05.ColumnName = "DATA_FIM_SEM_05";
            this.DATA_FIM_SEM_05.DataType = typeof(System.DateTime);
            // 
            // HORAS_PREV_SEM_05
            // 
            this.HORAS_PREV_SEM_05.ColumnName = "HORAS_PREV_SEM_05";
            this.HORAS_PREV_SEM_05.DataType = typeof(double);
            // 
            // HORAS_TRAB_SEM_05
            // 
            this.HORAS_TRAB_SEM_05.ColumnName = "HORAS_TRAB_SEM_05";
            this.HORAS_TRAB_SEM_05.DataType = typeof(double);
            // 
            // POS_ATUAL_SEM_05
            // 
            this.POS_ATUAL_SEM_05.ColumnName = "POS_ATUAL_SEM_05";
            this.POS_ATUAL_SEM_05.DataType = typeof(int);
            // 
            // dsImp_semana6
            // 
            this.dsImp_semana6.DataSetName = "dsImp_semana6";
            this.dsImp_semana6.Namespace = "http://www.tempuri.org/dsImp_semana6.xsd";
            this.dsImp_semana6.Tables.AddRange(new System.Data.DataTable[] {
            this.IMP_SEMANA6});
            // 
            // IMP_SEMANA6
            // 
            this.IMP_SEMANA6.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_SEM_06,
            this.OS_SEM_06,
            this.POS_SEM_06,
            this.DATA_INICIO_SEM_06,
            this.DATA_FIM_SEM_06,
            this.HORAS_PREV_SEM_06,
            this.HORAS_TRAB_SEM_06,
            this.POS_ATUAL_SEM_06});
            this.IMP_SEMANA6.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_SEM_06"}, true)});
            this.IMP_SEMANA6.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_SEM_06};
            this.IMP_SEMANA6.TableName = "IMP_SEMANA6";
            // 
            // COD_SEM_06
            // 
            this.COD_SEM_06.AllowDBNull = false;
            this.COD_SEM_06.ColumnName = "COD_SEM_06";
            this.COD_SEM_06.DataType = typeof(int);
            // 
            // OS_SEM_06
            // 
            this.OS_SEM_06.ColumnName = "OS_SEM_06";
            this.OS_SEM_06.MaxLength = 30;
            // 
            // POS_SEM_06
            // 
            this.POS_SEM_06.ColumnName = "POS_SEM_06";
            this.POS_SEM_06.MaxLength = 30;
            // 
            // DATA_INICIO_SEM_06
            // 
            this.DATA_INICIO_SEM_06.ColumnName = "DATA_INICIO_SEM_06";
            this.DATA_INICIO_SEM_06.DataType = typeof(System.DateTime);
            // 
            // DATA_FIM_SEM_06
            // 
            this.DATA_FIM_SEM_06.ColumnName = "DATA_FIM_SEM_06";
            this.DATA_FIM_SEM_06.DataType = typeof(System.DateTime);
            // 
            // HORAS_PREV_SEM_06
            // 
            this.HORAS_PREV_SEM_06.ColumnName = "HORAS_PREV_SEM_06";
            this.HORAS_PREV_SEM_06.DataType = typeof(double);
            // 
            // HORAS_TRAB_SEM_06
            // 
            this.HORAS_TRAB_SEM_06.ColumnName = "HORAS_TRAB_SEM_06";
            this.HORAS_TRAB_SEM_06.DataType = typeof(double);
            // 
            // POS_ATUAL_SEM_06
            // 
            this.POS_ATUAL_SEM_06.ColumnName = "POS_ATUAL_SEM_06";
            this.POS_ATUAL_SEM_06.DataType = typeof(int);
            // 
            // datImp_semana7
            // 
            this.datImp_semana7.DeleteCommand = this.fbCommand29;
            this.datImp_semana7.InsertCommand = this.fbCommand27;
            this.datImp_semana7.SelectCommand = this.fbCommand26;
            this.datImp_semana7.UpdateCommand = this.fbCommand28;
            // 
            // fbCommand29
            // 
            this.fbCommand29.CommandTimeout = 30;
            // 
            // fbCommand27
            // 
            this.fbCommand27.CommandTimeout = 30;
            // 
            // fbCommand26
            // 
            this.fbCommand26.CommandText = "select * from imp_semana7";
            this.fbCommand26.CommandTimeout = 30;
            this.fbCommand26.Connection = this.fbConnection1;
            // 
            // fbCommand28
            // 
            this.fbCommand28.CommandTimeout = 30;
            // 
            // dsImp_semana7
            // 
            this.dsImp_semana7.DataSetName = "dsImp_semana7";
            this.dsImp_semana7.Namespace = "http://www.tempuri.org/dsImp_semana7.xsd";
            this.dsImp_semana7.Tables.AddRange(new System.Data.DataTable[] {
            this.IMP_SEMANA7});
            // 
            // IMP_SEMANA7
            // 
            this.IMP_SEMANA7.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_SEM_07,
            this.OS_SEM_07,
            this.POS_SEM_07,
            this.DATA_INICIO_SEM_07,
            this.DATA_FIM_SEM_07,
            this.HORAS_PREV_SEM_07,
            this.HORAS_TRAB_SEM_07,
            this.POS_ATUAL_SEM_07});
            this.IMP_SEMANA7.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_SEM_07"}, true)});
            this.IMP_SEMANA7.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_SEM_07};
            this.IMP_SEMANA7.TableName = "IMP_SEMANA7";
            // 
            // COD_SEM_07
            // 
            this.COD_SEM_07.AllowDBNull = false;
            this.COD_SEM_07.ColumnName = "COD_SEM_07";
            this.COD_SEM_07.DataType = typeof(int);
            // 
            // OS_SEM_07
            // 
            this.OS_SEM_07.ColumnName = "OS_SEM_07";
            this.OS_SEM_07.MaxLength = 30;
            // 
            // POS_SEM_07
            // 
            this.POS_SEM_07.ColumnName = "POS_SEM_07";
            this.POS_SEM_07.MaxLength = 30;
            // 
            // DATA_INICIO_SEM_07
            // 
            this.DATA_INICIO_SEM_07.ColumnName = "DATA_INICIO_SEM_07";
            this.DATA_INICIO_SEM_07.DataType = typeof(System.DateTime);
            // 
            // DATA_FIM_SEM_07
            // 
            this.DATA_FIM_SEM_07.ColumnName = "DATA_FIM_SEM_07";
            this.DATA_FIM_SEM_07.DataType = typeof(System.DateTime);
            // 
            // HORAS_PREV_SEM_07
            // 
            this.HORAS_PREV_SEM_07.ColumnName = "HORAS_PREV_SEM_07";
            this.HORAS_PREV_SEM_07.DataType = typeof(double);
            // 
            // HORAS_TRAB_SEM_07
            // 
            this.HORAS_TRAB_SEM_07.ColumnName = "HORAS_TRAB_SEM_07";
            this.HORAS_TRAB_SEM_07.DataType = typeof(double);
            // 
            // POS_ATUAL_SEM_07
            // 
            this.POS_ATUAL_SEM_07.ColumnName = "POS_ATUAL_SEM_07";
            this.POS_ATUAL_SEM_07.DataType = typeof(int);
            // 
            // cbImp_semana7
            // 
            this.cbImp_semana7.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbImp_semana7.DataAdapter = this.datImp_semana7;
            this.cbImp_semana7.QuotePrefix = "\"";
            this.cbImp_semana7.QuoteSuffix = "\"";
            // 
            // datImp_semana8
            // 
            this.datImp_semana8.DeleteCommand = this.fbCommand33;
            this.datImp_semana8.InsertCommand = this.fbCommand31;
            this.datImp_semana8.SelectCommand = this.fbCommand30;
            this.datImp_semana8.UpdateCommand = this.fbCommand32;
            // 
            // fbCommand33
            // 
            this.fbCommand33.CommandTimeout = 30;
            // 
            // fbCommand31
            // 
            this.fbCommand31.CommandTimeout = 30;
            // 
            // fbCommand30
            // 
            this.fbCommand30.CommandText = "select * from imp_semana8";
            this.fbCommand30.CommandTimeout = 30;
            this.fbCommand30.Connection = this.fbConnection1;
            // 
            // fbCommand32
            // 
            this.fbCommand32.CommandTimeout = 30;
            // 
            // dsImp_semana8
            // 
            this.dsImp_semana8.DataSetName = "dsImp_semana8";
            this.dsImp_semana8.Namespace = "http://www.tempuri.org/dsImp_semana8.xsd";
            this.dsImp_semana8.Tables.AddRange(new System.Data.DataTable[] {
            this.IMP_SEMANA8});
            // 
            // IMP_SEMANA8
            // 
            this.IMP_SEMANA8.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_SEM_08,
            this.OS_SEM_08,
            this.POS_SEM_08,
            this.DATA_INICIO_SEM_08,
            this.DATA_FIM_SEM_08,
            this.HORAS_PREV_SEM_08,
            this.HORAS_TRAB_SEM_08,
            this.POS_ATUAL_SEM_08});
            this.IMP_SEMANA8.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_SEM_08"}, true)});
            this.IMP_SEMANA8.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_SEM_08};
            this.IMP_SEMANA8.TableName = "IMP_SEMANA8";
            // 
            // COD_SEM_08
            // 
            this.COD_SEM_08.AllowDBNull = false;
            this.COD_SEM_08.ColumnName = "COD_SEM_08";
            this.COD_SEM_08.DataType = typeof(int);
            // 
            // OS_SEM_08
            // 
            this.OS_SEM_08.ColumnName = "OS_SEM_08";
            this.OS_SEM_08.MaxLength = 30;
            // 
            // POS_SEM_08
            // 
            this.POS_SEM_08.ColumnName = "POS_SEM_08";
            this.POS_SEM_08.MaxLength = 30;
            // 
            // DATA_INICIO_SEM_08
            // 
            this.DATA_INICIO_SEM_08.ColumnName = "DATA_INICIO_SEM_08";
            this.DATA_INICIO_SEM_08.DataType = typeof(System.DateTime);
            // 
            // DATA_FIM_SEM_08
            // 
            this.DATA_FIM_SEM_08.ColumnName = "DATA_FIM_SEM_08";
            this.DATA_FIM_SEM_08.DataType = typeof(System.DateTime);
            // 
            // HORAS_PREV_SEM_08
            // 
            this.HORAS_PREV_SEM_08.ColumnName = "HORAS_PREV_SEM_08";
            this.HORAS_PREV_SEM_08.DataType = typeof(double);
            // 
            // HORAS_TRAB_SEM_08
            // 
            this.HORAS_TRAB_SEM_08.ColumnName = "HORAS_TRAB_SEM_08";
            this.HORAS_TRAB_SEM_08.DataType = typeof(double);
            // 
            // POS_ATUAL_SEM_08
            // 
            this.POS_ATUAL_SEM_08.ColumnName = "POS_ATUAL_SEM_08";
            this.POS_ATUAL_SEM_08.DataType = typeof(int);
            // 
            // cbImp_semana8
            // 
            this.cbImp_semana8.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbImp_semana8.DataAdapter = this.datImp_semana8;
            this.cbImp_semana8.QuotePrefix = "\"";
            this.cbImp_semana8.QuoteSuffix = "\"";
            // 
            // datN_semana5
            // 
            this.datN_semana5.DeleteCommand = this.fbCommand37;
            this.datN_semana5.InsertCommand = this.fbCommand35;
            this.datN_semana5.SelectCommand = this.fbCommand34;
            this.datN_semana5.UpdateCommand = this.fbCommand36;
            // 
            // fbCommand37
            // 
            this.fbCommand37.CommandTimeout = 30;
            // 
            // fbCommand35
            // 
            this.fbCommand35.CommandTimeout = 30;
            // 
            // fbCommand34
            // 
            this.fbCommand34.CommandText = "select * from n_semana5";
            this.fbCommand34.CommandTimeout = 30;
            this.fbCommand34.Connection = this.fbConnection1;
            // 
            // fbCommand36
            // 
            this.fbCommand36.CommandTimeout = 30;
            // 
            // dsN_semana5
            // 
            this.dsN_semana5.DataSetName = "dsN_semana5";
            this.dsN_semana5.Namespace = "http://www.tempuri.org/dsN_semana5.xsd";
            this.dsN_semana5.Tables.AddRange(new System.Data.DataTable[] {
            this.N_SEMANA5});
            // 
            // N_SEMANA5
            // 
            this.N_SEMANA5.Columns.AddRange(new System.Data.DataColumn[] {
            this.NUMERO_SEMANA5});
            this.N_SEMANA5.TableName = "N_SEMANA5";
            // 
            // NUMERO_SEMANA5
            // 
            this.NUMERO_SEMANA5.ColumnName = "NUMERO_SEMANA5";
            this.NUMERO_SEMANA5.DataType = typeof(int);
            // 
            // datN_semana6
            // 
            this.datN_semana6.DeleteCommand = this.fbCommand41;
            this.datN_semana6.InsertCommand = this.fbCommand39;
            this.datN_semana6.SelectCommand = this.fbCommand38;
            this.datN_semana6.UpdateCommand = this.fbCommand40;
            // 
            // fbCommand41
            // 
            this.fbCommand41.CommandTimeout = 30;
            // 
            // fbCommand39
            // 
            this.fbCommand39.CommandTimeout = 30;
            // 
            // fbCommand38
            // 
            this.fbCommand38.CommandText = "select * from n_semana6";
            this.fbCommand38.CommandTimeout = 30;
            this.fbCommand38.Connection = this.fbConnection1;
            // 
            // fbCommand40
            // 
            this.fbCommand40.CommandTimeout = 30;
            // 
            // dsN_semana6
            // 
            this.dsN_semana6.DataSetName = "dsN_semana6";
            this.dsN_semana6.Namespace = "http://www.tempuri.org/dsN_semana6.xsd";
            this.dsN_semana6.Tables.AddRange(new System.Data.DataTable[] {
            this.N_SEMANA6});
            // 
            // N_SEMANA6
            // 
            this.N_SEMANA6.Columns.AddRange(new System.Data.DataColumn[] {
            this.NUMERO_SEMANA6});
            this.N_SEMANA6.TableName = "N_SEMANA6";
            // 
            // NUMERO_SEMANA6
            // 
            this.NUMERO_SEMANA6.ColumnName = "NUMERO_SEMANA6";
            this.NUMERO_SEMANA6.DataType = typeof(int);
            // 
            // datN_semana7
            // 
            this.datN_semana7.DeleteCommand = this.fbCommand45;
            this.datN_semana7.InsertCommand = this.fbCommand43;
            this.datN_semana7.SelectCommand = this.fbCommand42;
            this.datN_semana7.UpdateCommand = this.fbCommand44;
            // 
            // fbCommand45
            // 
            this.fbCommand45.CommandTimeout = 30;
            // 
            // fbCommand43
            // 
            this.fbCommand43.CommandTimeout = 30;
            // 
            // fbCommand42
            // 
            this.fbCommand42.CommandText = "select * from n_semana7";
            this.fbCommand42.CommandTimeout = 30;
            this.fbCommand42.Connection = this.fbConnection1;
            // 
            // fbCommand44
            // 
            this.fbCommand44.CommandTimeout = 30;
            // 
            // dsN_semana7
            // 
            this.dsN_semana7.DataSetName = "dsN_semana7";
            this.dsN_semana7.Namespace = "http://www.tempuri.org/dsN_semana7.xsd";
            this.dsN_semana7.Tables.AddRange(new System.Data.DataTable[] {
            this.N_SEMANA7});
            // 
            // N_SEMANA7
            // 
            this.N_SEMANA7.Columns.AddRange(new System.Data.DataColumn[] {
            this.NUMERO_SEMANA7});
            this.N_SEMANA7.TableName = "N_SEMANA7";
            // 
            // NUMERO_SEMANA7
            // 
            this.NUMERO_SEMANA7.ColumnName = "NUMERO_SEMANA7";
            this.NUMERO_SEMANA7.DataType = typeof(int);
            // 
            // fbCommand46
            // 
            this.fbCommand46.CommandTimeout = 30;
            // 
            // fbCommand47
            // 
            this.fbCommand47.CommandTimeout = 30;
            // 
            // fbCommand48
            // 
            this.fbCommand48.CommandTimeout = 30;
            // 
            // fbCommand49
            // 
            this.fbCommand49.CommandTimeout = 30;
            // 
            // datN_semana8
            // 
            this.datN_semana8.DeleteCommand = this.fbCommand53;
            this.datN_semana8.InsertCommand = this.fbCommand51;
            this.datN_semana8.SelectCommand = this.fbCommand50;
            this.datN_semana8.UpdateCommand = this.fbCommand52;
            // 
            // fbCommand53
            // 
            this.fbCommand53.CommandTimeout = 30;
            // 
            // fbCommand51
            // 
            this.fbCommand51.CommandTimeout = 30;
            // 
            // fbCommand50
            // 
            this.fbCommand50.CommandText = "select * from n_semana8";
            this.fbCommand50.CommandTimeout = 30;
            this.fbCommand50.Connection = this.fbConnection1;
            // 
            // fbCommand52
            // 
            this.fbCommand52.CommandTimeout = 30;
            // 
            // dsN_semana8
            // 
            this.dsN_semana8.DataSetName = "dsN_semana8";
            this.dsN_semana8.Namespace = "http://www.tempuri.org/dsN_semana8.xsd";
            this.dsN_semana8.Tables.AddRange(new System.Data.DataTable[] {
            this.N_SEMANA8});
            // 
            // N_SEMANA8
            // 
            this.N_SEMANA8.Columns.AddRange(new System.Data.DataColumn[] {
            this.NUMERO_SEMANA8});
            this.N_SEMANA8.TableName = "N_SEMANA8";
            // 
            // NUMERO_SEMANA8
            // 
            this.NUMERO_SEMANA8.ColumnName = "NUMERO_SEMANA8";
            this.NUMERO_SEMANA8.DataType = typeof(int);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(238, 516);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(73, 23);
            this.button3.TabIndex = 94;
            this.button3.Text = "Excluir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // datSemana_ano
            // 
            this.datSemana_ano.DeleteCommand = this.fbCommand57;
            this.datSemana_ano.InsertCommand = this.fbCommand55;
            this.datSemana_ano.SelectCommand = this.fbCommand54;
            this.datSemana_ano.UpdateCommand = this.fbCommand56;
            // 
            // fbCommand57
            // 
            this.fbCommand57.CommandTimeout = 30;
            // 
            // fbCommand55
            // 
            this.fbCommand55.CommandTimeout = 30;
            // 
            // fbCommand54
            // 
            this.fbCommand54.CommandText = "SELECT * FROM SEMANA_ANO order by cod_semana_ano";
            this.fbCommand54.CommandTimeout = 30;
            this.fbCommand54.Connection = this.fbConnection1;
            // 
            // fbCommand56
            // 
            this.fbCommand56.CommandTimeout = 30;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(389, 201);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(26, 13);
            this.label18.TabIndex = 95;
            this.label18.Text = "Ano";
            // 
            // label_ano
            // 
            this.label_ano.AutoSize = true;
            this.label_ano.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSemana_ano, "SEMANA_ANO.ANO_SEMANA_ANO", true));
            this.label_ano.Location = new System.Drawing.Point(434, 201);
            this.label_ano.Name = "label_ano";
            this.label_ano.Size = new System.Drawing.Size(0, 13);
            this.label_ano.TabIndex = 96;
            this.label_ano.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_saldo
            // 
            this.tb_saldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_saldo.Location = new System.Drawing.Point(234, 96);
            this.tb_saldo.Name = "tb_saldo";
            this.tb_saldo.Size = new System.Drawing.Size(77, 40);
            this.tb_saldo.TabIndex = 97;
            this.tb_saldo.TextChanged += new System.EventHandler(this.tb_saldo_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(235, 80);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(37, 13);
            this.label19.TabIndex = 98;
            this.label19.Text = "Saldo:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirDesenhoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(150, 26);
            // 
            // abrirDesenhoToolStripMenuItem
            // 
            this.abrirDesenhoToolStripMenuItem.Name = "abrirDesenhoToolStripMenuItem";
            this.abrirDesenhoToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.abrirDesenhoToolStripMenuItem.Text = "Abrir Desenho";
            this.abrirDesenhoToolStripMenuItem.Click += new System.EventHandler(this.abrirDesenhoToolStripMenuItem_Click);
            // 
            // comando_select
            // 
            this.comando_select.CommandTimeout = 30;
            this.comando_select.Connection = this.fbConnection1;
            // 
            // datDesenhos
            // 
            this.datDesenhos.DeleteCommand = this.fbCommand61;
            this.datDesenhos.InsertCommand = this.fbCommand59;
            this.datDesenhos.SelectCommand = this.fbCommand58;
            this.datDesenhos.UpdateCommand = this.fbCommand60;
            // 
            // fbCommand58
            // 
            this.fbCommand58.CommandText = "select * from desenhos";
            this.fbCommand58.CommandTimeout = 30;
            this.fbCommand58.Connection = this.fbConnection1;
            // 
            // fbCommand59
            // 
            this.fbCommand59.CommandTimeout = 30;
            // 
            // fbCommand60
            // 
            this.fbCommand60.CommandTimeout = 30;
            // 
            // fbCommand61
            // 
            this.fbCommand61.CommandTimeout = 30;
            // 
            // form_semanas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 667);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.label19);
            this.Controls.Add(this.tb_saldo);
            this.Controls.Add(this.label_ano);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.tb_reais);
            this.Controls.Add(this.tb_orc);
            this.Controls.Add(this.tb_atrasados);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bt_prox);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label_semana_9);
            this.Controls.Add(this.label_semana_8);
            this.Controls.Add(this.label_semana_7);
            this.Controls.Add(this.label_semana_6);
            this.Controls.Add(this.label_semana_4);
            this.Controls.Add(this.label_semana_3);
            this.Controls.Add(this.dataGridView5);
            this.Controls.Add(this.dataGridView6);
            this.Controls.Add(this.dataGridView7);
            this.Controls.Add(this.dataGridView8);
            this.Controls.Add(this.dataGridView9);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.tb_total_5);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tb_Ok);
            this.Controls.Add(this.label_horas);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label_operacao);
            this.Controls.Add(this.rbMontagem);
            this.Controls.Add(this.rbPolimento);
            this.Controls.Add(this.rbErosao_edm);
            this.Controls.Add(this.rbErosao_ewc);
            this.Controls.Add(this.rbCnc_acab);
            this.Controls.Add(this.rbTempera);
            this.Controls.Add(this.rbCnc);
            this.Controls.Add(this.rbRetifica);
            this.Controls.Add(this.rbFresa);
            this.Controls.Add(this.rbTorno);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_proximo);
            this.Controls.Add(this.tb_anterior);
            this.Controls.Add(this.tb_semana);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_total_9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_total_8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_total_7);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_total_6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_total_4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_total_3);
            this.Controls.Add(this.label3);
            this.Name = "form_semanas";
            this.Text = "Semanas";
            this.Load += new System.EventHandler(this.form_semanas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsSemana_ano)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SEMANA_ANO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOperacoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TIPOS_OPERACOES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsImp_semana5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMP_SEMANA5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsImp_semana6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMP_SEMANA6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsImp_semana7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMP_SEMANA7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsImp_semana8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMP_SEMANA8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsN_semana5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_SEMANA5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsN_semana6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_SEMANA6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsN_semana7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_SEMANA7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsN_semana8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_SEMANA8)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datSemanas;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand5;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private System.Windows.Forms.TextBox tb_total_3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_total_4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_total_9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_total_8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_total_7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_total_6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button tb_proximo;
        private System.Windows.Forms.Button tb_anterior;
        private System.Windows.Forms.TextBox tb_semana;
        private System.Windows.Forms.RadioButton rbTorno;
        private System.Windows.Forms.RadioButton rbFresa;
        private System.Windows.Forms.RadioButton rbRetifica;
        private System.Windows.Forms.RadioButton rbCnc;
        private System.Windows.Forms.RadioButton rbTempera;
        private System.Windows.Forms.RadioButton rbCnc_acab;
        private System.Windows.Forms.RadioButton rbPolimento;
        private System.Windows.Forms.RadioButton rbErosao_edm;
        private System.Windows.Forms.RadioButton rbErosao_ewc;
        private System.Windows.Forms.RadioButton rbMontagem;
        private System.Windows.Forms.Label label_operacao;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label_horas;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datOperacoes;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand9;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand7;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand6;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand8;
        private System.Data.DataSet dsOperacoes;
        private System.Data.DataTable TIPOS_OPERACOES;
        private System.Data.DataColumn COD_TIPO;
        private System.Data.DataColumn QDE_MAQUINAS;
        private System.Data.DataColumn TIPO;
        private System.Data.DataColumn HORAS_SEMANAIS_DISP;
        private System.Windows.Forms.Button tb_Ok;
        private System.Windows.Forms.TextBox tb_total_5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.DataGridView dataGridView7;
        private System.Windows.Forms.DataGridView dataGridView8;
        private System.Windows.Forms.DataGridView dataGridView9;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.Label label_semana_3;
        private System.Windows.Forms.Label label_semana_4;
        private System.Windows.Forms.Label label_semana_6;
        private System.Windows.Forms.Label label_semana_7;
        private System.Windows.Forms.Label label_semana_8;
        private System.Windows.Forms.Label label_semana_9;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button bt_prox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button tb_atrasados;
        private System.Windows.Forms.TextBox tb_orc;
        private System.Windows.Forms.TextBox tb_reais;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand13;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand11;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand10;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand12;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbImp_semana5;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand17;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand15;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand14;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand16;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbImp_semana6;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datImp_semana5;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand21;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand19;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand18;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand20;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datImp_semana6;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand25;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand23;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand22;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand24;
        private System.Data.DataSet dsImp_semana5;
        private System.Data.DataTable IMP_SEMANA5;
        private System.Data.DataColumn COD_SEM_05;
        private System.Data.DataColumn OS_SEM_05;
        private System.Data.DataColumn POS_SEM_05;
        private System.Data.DataColumn DATA_INICIO_SEM_05;
        private System.Data.DataColumn DATA_FIM_SEM_05;
        private System.Data.DataColumn HORAS_PREV_SEM_05;
        private System.Data.DataColumn HORAS_TRAB_SEM_05;
        private System.Data.DataColumn POS_ATUAL_SEM_05;
        private System.Data.DataSet dsImp_semana6;
        private System.Data.DataTable IMP_SEMANA6;
        private System.Data.DataColumn COD_SEM_06;
        private System.Data.DataColumn OS_SEM_06;
        private System.Data.DataColumn POS_SEM_06;
        private System.Data.DataColumn DATA_INICIO_SEM_06;
        private System.Data.DataColumn DATA_FIM_SEM_06;
        private System.Data.DataColumn HORAS_PREV_SEM_06;
        private System.Data.DataColumn HORAS_TRAB_SEM_06;
        private System.Data.DataColumn POS_ATUAL_SEM_06;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datImp_semana7;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand29;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand27;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand26;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand28;
        private System.Data.DataSet dsImp_semana7;
        private System.Data.DataTable IMP_SEMANA7;
        private System.Data.DataColumn COD_SEM_07;
        private System.Data.DataColumn OS_SEM_07;
        private System.Data.DataColumn POS_SEM_07;
        private System.Data.DataColumn DATA_INICIO_SEM_07;
        private System.Data.DataColumn DATA_FIM_SEM_07;
        private System.Data.DataColumn HORAS_PREV_SEM_07;
        private System.Data.DataColumn HORAS_TRAB_SEM_07;
        private System.Data.DataColumn POS_ATUAL_SEM_07;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbImp_semana7;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datImp_semana8;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand33;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand31;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand30;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand32;
        private System.Data.DataSet dsImp_semana8;
        private System.Data.DataTable IMP_SEMANA8;
        private System.Data.DataColumn COD_SEM_08;
        private System.Data.DataColumn OS_SEM_08;
        private System.Data.DataColumn POS_SEM_08;
        private System.Data.DataColumn DATA_INICIO_SEM_08;
        private System.Data.DataColumn DATA_FIM_SEM_08;
        private System.Data.DataColumn HORAS_PREV_SEM_08;
        private System.Data.DataColumn HORAS_TRAB_SEM_08;
        private System.Data.DataColumn POS_ATUAL_SEM_08;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbImp_semana8;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datN_semana5;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand37;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand35;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand34;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand36;
        private System.Data.DataSet dsN_semana5;
        private System.Data.DataTable N_SEMANA5;
        private System.Data.DataColumn NUMERO_SEMANA5;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datN_semana6;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand41;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand39;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand38;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand40;
        private System.Data.DataSet dsN_semana6;
        private System.Data.DataTable N_SEMANA6;
        private System.Data.DataColumn NUMERO_SEMANA6;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datN_semana7;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand45;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand43;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand42;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand44;
        private System.Data.DataSet dsN_semana7;
        private System.Data.DataTable N_SEMANA7;
        private System.Data.DataColumn NUMERO_SEMANA7;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand46;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand47;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand48;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand49;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datN_semana8;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand53;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand51;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand50;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand52;
        private System.Data.DataSet dsN_semana8;
        private System.Data.DataTable N_SEMANA8;
        private System.Data.DataColumn NUMERO_SEMANA8;
        private System.Windows.Forms.Button button3;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datSemana_ano;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand57;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand55;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand54;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand56;
        private System.Data.DataSet dsSemana_ano;
        private System.Data.DataTable SEMANA_ANO;
        private System.Data.DataColumn COD_SEMANA_ANO;
        private System.Data.DataColumn SEMANA_SEMANA_ANO;
        private System.Data.DataColumn ANO_SEMANA_ANO;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label_ano;
        private System.Windows.Forms.TextBox tb_saldo;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem abrirDesenhoToolStripMenuItem;
        private FirebirdSql.Data.FirebirdClient.FbCommand comando_select;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datDesenhos;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand61;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand59;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand58;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand60;
    }
}