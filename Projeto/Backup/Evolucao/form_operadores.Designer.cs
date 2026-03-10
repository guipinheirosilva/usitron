namespace Evolucao
{
    partial class form_operadores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_operadores));
            this.textbox_operacao_executada = new System.Windows.Forms.TextBox();
            this.dsOperadores = new System.Data.DataSet();
            this.OPERADORES = new System.Data.DataTable();
            this.COD_OPERADOR = new System.Data.DataColumn();
            this.NOME = new System.Data.DataColumn();
            this.CTPS = new System.Data.DataColumn();
            this.RG = new System.Data.DataColumn();
            this.DATA_NASCIMENTO = new System.Data.DataColumn();
            this.DATA_ADMISSAO = new System.Data.DataColumn();
            this.DATA_DEMISSAO = new System.Data.DataColumn();
            this.OPERACAO_EXEC = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.textbox_data_admissao = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textbox_rg = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.textbox_data_demissao = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textbox_data_nascimento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textbox_ctps = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textbox_nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textbox_cod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.datOperadores = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommandBuilder1 = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.novo_registro = new System.Windows.Forms.Button();
            this.salva_registro = new System.Windows.Forms.Button();
            this.apaga_registro = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.tb_total_horas_extras = new System.Windows.Forms.TextBox();
            this.dsSalario_off = new System.Data.DataSet();
            this.SALARIO_OFF = new System.Data.DataTable();
            this.COD_SAL_OFF = new System.Data.DataColumn();
            this.FUNCIONARIO_SAL_OFF = new System.Data.DataColumn();
            this.DATA_INICIAL_SAL_OFF = new System.Data.DataColumn();
            this.DATA_FINAL_SAL_OFF = new System.Data.DataColumn();
            this.QTDE_DIAS_PERIODO_SAL_OFF = new System.Data.DataColumn();
            this.SALARIO_BASE_SAL_OFF = new System.Data.DataColumn();
            this.SALARIO_BASE_POR_HORA_SAL_OFF = new System.Data.DataColumn();
            this.SALARIO_SAL_OFF = new System.Data.DataColumn();
            this.HORAS_SALARIO_BASE_SAL_OFF = new System.Data.DataColumn();
            this.DSR_SAL_OFF = new System.Data.DataColumn();
            this.HORAS_DSR_SAL_OFF = new System.Data.DataColumn();
            this.TOTAL_HORAS_EXTRAS_SAL_OFF = new System.Data.DataColumn();
            this.EXTRA_50_SAL_OFF = new System.Data.DataColumn();
            this.HORAS_EXTRA_50_SAL_OFF = new System.Data.DataColumn();
            this.EXTRA_60_SAL_OFF = new System.Data.DataColumn();
            this.HORAS_EXTRA_60_SAL_OFF = new System.Data.DataColumn();
            this.EXTRA_80_SAL_OFF = new System.Data.DataColumn();
            this.HORAS_EXTRA_80_SAL_OFF = new System.Data.DataColumn();
            this.EXTRA_100_SAL_OFF = new System.Data.DataColumn();
            this.HORAS_EXTRA_100_SAL_OFF = new System.Data.DataColumn();
            this.OUTROS_VENC_SAL_OFF = new System.Data.DataColumn();
            this.HORAS_OUTROS_SAL_OFF = new System.Data.DataColumn();
            this.DESCRICAO_OUTROS_VENC_SAL_OFF = new System.Data.DataColumn();
            this.AD_NOTURNO_35_SAL_OFF = new System.Data.DataColumn();
            this.HORAS_AD_NOTURNO_35_SAL_OFF = new System.Data.DataColumn();
            this.VALE_TRANSPORTE_SAL_OFF = new System.Data.DataColumn();
            this.QTDE_VALE_TRANSPORTE_SAL_OFF = new System.Data.DataColumn();
            this.ADIANTAMENTO_SAL_OFF = new System.Data.DataColumn();
            this.VALE_TRANSPORTE_DESC_SAL_OFF = new System.Data.DataColumn();
            this.REFEICAO_SAL_OFF = new System.Data.DataColumn();
            this.LANCHE_SAL_OFF = new System.Data.DataColumn();
            this.TOTAL_VENCIMENTOS_SAL_OFF = new System.Data.DataColumn();
            this.TOTAL_DESCONTOS_SAL_OFF = new System.Data.DataColumn();
            this.LIQUIDO_A_REC_SAL_OFF = new System.Data.DataColumn();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.tb_ref_dsr = new System.Windows.Forms.TextBox();
            this.tb_ref_salario = new System.Windows.Forms.TextBox();
            this.tb_ref_80 = new System.Windows.Forms.TextBox();
            this.tb_ref_60 = new System.Windows.Forms.TextBox();
            this.tb_ref_50 = new System.Windows.Forms.TextBox();
            this.tb_ref_vale = new System.Windows.Forms.TextBox();
            this.tb_ref_noturno = new System.Windows.Forms.TextBox();
            this.tb_ref_100 = new System.Windows.Forms.TextBox();
            this.tb_total_liquido = new System.Windows.Forms.TextBox();
            this.tb_total_descontos = new System.Windows.Forms.TextBox();
            this.tb_lanche = new System.Windows.Forms.TextBox();
            this.tb_refeicao = new System.Windows.Forms.TextBox();
            this.tb_vale_desc = new System.Windows.Forms.TextBox();
            this.tb_adiantamento = new System.Windows.Forms.TextBox();
            this.tb_total_venc = new System.Windows.Forms.TextBox();
            this.tb_valor_vale = new System.Windows.Forms.TextBox();
            this.tb_valor_noturno = new System.Windows.Forms.TextBox();
            this.tb_valor_100 = new System.Windows.Forms.TextBox();
            this.tb_valor_80 = new System.Windows.Forms.TextBox();
            this.tb_valor_60 = new System.Windows.Forms.TextBox();
            this.tb_valor_50 = new System.Windows.Forms.TextBox();
            this.tb_valor_dsr = new System.Windows.Forms.TextBox();
            this.tb_valor_salario = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.groupBoxRH = new System.Windows.Forms.GroupBox();
            this.cbVale_transporte = new System.Windows.Forms.CheckBox();
            this.cbAdiantamento = new System.Windows.Forms.CheckBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.tb_valor_outros_desc = new System.Windows.Forms.TextBox();
            this.textBox40 = new System.Windows.Forms.TextBox();
            this.textBox38 = new System.Windows.Forms.TextBox();
            this.tb_valor_outros = new System.Windows.Forms.TextBox();
            this.tb_ref_outros = new System.Windows.Forms.TextBox();
            this.tb_cod_sal_off = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.tb_data_final = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.tb_data_inicial = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.tb_salario_hora_base = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.tb_salario_base = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.datSalarios_off = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand8 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand6 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand5 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand7 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.cbSalario_off = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.datPeriodos = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand12 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand10 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand9 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand11 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsPeriodos = new System.Data.DataSet();
            this.PERIODOS = new System.Data.DataTable();
            this.COD_PERIODO = new System.Data.DataColumn();
            this.DATA_INICIAL_PERIODO = new System.Data.DataColumn();
            this.DATA_FINAL_PERIODO = new System.Data.DataColumn();
            this.DIAS_PERIODO = new System.Data.DataColumn();
            this.tb_nivel_aut = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.tb_ref_excecao = new System.Windows.Forms.TextBox();
            this.dataColumn7 = new System.Data.DataColumn();
            this.tb_outros_2 = new System.Windows.Forms.TextBox();
            this.dataColumn8 = new System.Data.DataColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dsOperadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OPERADORES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSalario_off)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SALARIO_OFF)).BeginInit();
            this.groupBoxRH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsPeriodos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PERIODOS)).BeginInit();
            this.SuspendLayout();
            // 
            // textbox_operacao_executada
            // 
            this.textbox_operacao_executada.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsOperadores, "OPERADORES.OPERACAO_EXEC", true));
            this.textbox_operacao_executada.Location = new System.Drawing.Point(119, 237);
            this.textbox_operacao_executada.Name = "textbox_operacao_executada";
            this.textbox_operacao_executada.Size = new System.Drawing.Size(136, 20);
            this.textbox_operacao_executada.TabIndex = 8;
            // 
            // dsOperadores
            // 
            this.dsOperadores.DataSetName = "dsOperadores";
            this.dsOperadores.Namespace = "http://www.tempuri.org/dsOperadores.xsd";
            this.dsOperadores.Tables.AddRange(new System.Data.DataTable[] {
            this.OPERADORES});
            // 
            // OPERADORES
            // 
            this.OPERADORES.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_OPERADOR,
            this.NOME,
            this.CTPS,
            this.RG,
            this.DATA_NASCIMENTO,
            this.DATA_ADMISSAO,
            this.DATA_DEMISSAO,
            this.OPERACAO_EXEC,
            this.dataColumn6});
            this.OPERADORES.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_OPERADOR"}, true)});
            this.OPERADORES.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_OPERADOR};
            this.OPERADORES.TableName = "OPERADORES";
            // 
            // COD_OPERADOR
            // 
            this.COD_OPERADOR.AllowDBNull = false;
            this.COD_OPERADOR.ColumnName = "COD_OPERADOR";
            this.COD_OPERADOR.MaxLength = 5;
            // 
            // NOME
            // 
            this.NOME.ColumnName = "NOME";
            this.NOME.MaxLength = 70;
            // 
            // CTPS
            // 
            this.CTPS.ColumnName = "CTPS";
            this.CTPS.MaxLength = 15;
            // 
            // RG
            // 
            this.RG.ColumnName = "RG";
            this.RG.MaxLength = 15;
            // 
            // DATA_NASCIMENTO
            // 
            this.DATA_NASCIMENTO.ColumnName = "DATA_NASCIMENTO";
            this.DATA_NASCIMENTO.DataType = typeof(System.DateTime);
            // 
            // DATA_ADMISSAO
            // 
            this.DATA_ADMISSAO.ColumnName = "DATA_ADMISSAO";
            this.DATA_ADMISSAO.DataType = typeof(System.DateTime);
            // 
            // DATA_DEMISSAO
            // 
            this.DATA_DEMISSAO.ColumnName = "DATA_DEMISSAO";
            this.DATA_DEMISSAO.DataType = typeof(System.DateTime);
            // 
            // OPERACAO_EXEC
            // 
            this.OPERACAO_EXEC.ColumnName = "OPERACAO_EXEC";
            this.OPERACAO_EXEC.DataType = typeof(int);
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "NIVEL_AUT_OPERADOR";
            this.dataColumn6.DataType = typeof(int);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 240);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 13);
            this.label10.TabIndex = 118;
            this.label10.Text = "Operação Executada:";
            // 
            // textbox_data_admissao
            // 
            this.textbox_data_admissao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsOperadores, "OPERADORES.DATA_ADMISSAO", true));
            this.textbox_data_admissao.Location = new System.Drawing.Point(119, 211);
            this.textbox_data_admissao.Name = "textbox_data_admissao";
            this.textbox_data_admissao.Size = new System.Drawing.Size(136, 20);
            this.textbox_data_admissao.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 215);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 13);
            this.label13.TabIndex = 116;
            this.label13.Text = "Data de Admissão:";
            // 
            // textbox_rg
            // 
            this.textbox_rg.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsOperadores, "OPERADORES.RG", true));
            this.textbox_rg.Location = new System.Drawing.Point(119, 186);
            this.textbox_rg.Name = "textbox_rg";
            this.textbox_rg.Size = new System.Drawing.Size(136, 20);
            this.textbox_rg.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 189);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 13);
            this.label14.TabIndex = 114;
            this.label14.Text = "RG:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label20.Location = new System.Drawing.Point(12, 4);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(250, 46);
            this.label20.TabIndex = 109;
            this.label20.Text = "Funcionários";
            // 
            // textbox_data_demissao
            // 
            this.textbox_data_demissao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsOperadores, "OPERADORES.DATA_DEMISSAO", true));
            this.textbox_data_demissao.Location = new System.Drawing.Point(119, 160);
            this.textbox_data_demissao.Name = "textbox_data_demissao";
            this.textbox_data_demissao.Size = new System.Drawing.Size(136, 20);
            this.textbox_data_demissao.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 163);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 13);
            this.label12.TabIndex = 107;
            this.label12.Text = "Data de Demissão:";
            // 
            // textbox_data_nascimento
            // 
            this.textbox_data_nascimento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsOperadores, "OPERADORES.DATA_NASCIMENTO", true));
            this.textbox_data_nascimento.Location = new System.Drawing.Point(119, 135);
            this.textbox_data_nascimento.Name = "textbox_data_nascimento";
            this.textbox_data_nascimento.Size = new System.Drawing.Size(136, 20);
            this.textbox_data_nascimento.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 105;
            this.label6.Text = "Data de Nascimento:";
            // 
            // textbox_ctps
            // 
            this.textbox_ctps.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsOperadores, "OPERADORES.CTPS", true));
            this.textbox_ctps.Location = new System.Drawing.Point(119, 109);
            this.textbox_ctps.Name = "textbox_ctps";
            this.textbox_ctps.Size = new System.Drawing.Size(136, 20);
            this.textbox_ctps.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 103;
            this.label3.Text = "CTPS:";
            // 
            // textbox_nome
            // 
            this.textbox_nome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsOperadores, "OPERADORES.NOME", true));
            this.textbox_nome.Location = new System.Drawing.Point(119, 83);
            this.textbox_nome.Name = "textbox_nome";
            this.textbox_nome.Size = new System.Drawing.Size(283, 20);
            this.textbox_nome.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 101;
            this.label2.Text = "Nome:";
            // 
            // textbox_cod
            // 
            this.textbox_cod.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsOperadores, "OPERADORES.COD_OPERADOR", true));
            this.textbox_cod.Location = new System.Drawing.Point(126, 57);
            this.textbox_cod.Name = "textbox_cod";
            this.textbox_cod.Size = new System.Drawing.Size(52, 20);
            this.textbox_cod.TabIndex = 1;
            this.textbox_cod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_cod_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 99;
            this.label1.Text = "Código do Funcionário:";
            // 
            // fbConnection1
            // 
            this.fbConnection1.ConnectionString = resources.GetString("fbConnection1.ConnectionString");
            // 
            // datOperadores
            // 
            this.datOperadores.DeleteCommand = this.fbCommand4;
            this.datOperadores.InsertCommand = this.fbCommand2;
            this.datOperadores.SelectCommand = this.fbCommand1;
            this.datOperadores.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "SELECT * FROM OPERADORES";
            this.fbCommand1.CommandTimeout = 30;
            this.fbCommand1.Connection = this.fbConnection1;
            // 
            // fbCommand3
            // 
            this.fbCommand3.CommandTimeout = 30;
            // 
            // fbCommandBuilder1
            // 
            this.fbCommandBuilder1.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.fbCommandBuilder1.DataAdapter = this.datOperadores;
            this.fbCommandBuilder1.QuotePrefix = "\"";
            this.fbCommandBuilder1.QuoteSuffix = "\"";
            // 
            // novo_registro
            // 
            this.novo_registro.Location = new System.Drawing.Point(73, 304);
            this.novo_registro.Name = "novo_registro";
            this.novo_registro.Size = new System.Drawing.Size(49, 22);
            this.novo_registro.TabIndex = 10;
            this.novo_registro.Text = "Novo";
            this.novo_registro.UseVisualStyleBackColor = true;
            this.novo_registro.Click += new System.EventHandler(this.novo_registro_Click);
            // 
            // salva_registro
            // 
            this.salva_registro.Location = new System.Drawing.Point(183, 304);
            this.salva_registro.Name = "salva_registro";
            this.salva_registro.Size = new System.Drawing.Size(49, 22);
            this.salva_registro.TabIndex = 12;
            this.salva_registro.Text = "Salvar";
            this.salva_registro.UseVisualStyleBackColor = true;
            this.salva_registro.Click += new System.EventHandler(this.salva_registro_Click);
            // 
            // apaga_registro
            // 
            this.apaga_registro.Location = new System.Drawing.Point(128, 304);
            this.apaga_registro.Name = "apaga_registro";
            this.apaga_registro.Size = new System.Drawing.Size(49, 22);
            this.apaga_registro.TabIndex = 11;
            this.apaga_registro.Text = "Excluir";
            this.apaga_registro.UseVisualStyleBackColor = true;
            this.apaga_registro.Click += new System.EventHandler(this.apaga_registro_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(7, 304);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 22);
            this.button3.TabIndex = 9;
            this.button3.Text = "Localizar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 22);
            this.button1.TabIndex = 13;
            this.button1.Text = "Atualizar Arquivo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 135;
            this.label4.Text = "Hora Extra 50%:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 134;
            this.label5.Text = "Total de Horas Extras:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 133;
            this.label7.Text = "DSR:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 132;
            this.label8.Text = "Salário:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 301);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 13);
            this.label9.TabIndex = 139;
            this.label9.Text = "Ad. Noturno 35%:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 276);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 13);
            this.label11.TabIndex = 138;
            this.label11.Text = "Hora Extra 100%:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(20, 250);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 13);
            this.label15.TabIndex = 137;
            this.label15.Text = "Hora Extra 80%:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(20, 224);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(83, 13);
            this.label16.TabIndex = 136;
            this.label16.Text = "Hora Extra 60%:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(181, 595);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(131, 20);
            this.label17.TabIndex = 147;
            this.label17.Text = "Líquido a receber";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(178, 559);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(135, 17);
            this.label18.TabIndex = 146;
            this.label18.Text = "Total de Descontos:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(20, 507);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(46, 13);
            this.label19.TabIndex = 145;
            this.label19.Text = "Lanche:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(20, 481);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(53, 13);
            this.label21.TabIndex = 144;
            this.label21.Text = "Refeição:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(20, 456);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(85, 13);
            this.label22.TabIndex = 143;
            this.label22.Text = "Vale Transporte:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(20, 431);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(75, 13);
            this.label23.TabIndex = 142;
            this.label23.Text = "Adiantamento:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(184, 405);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(129, 17);
            this.label24.TabIndex = 141;
            this.label24.Text = "Total Vencimentos:";
            // 
            // tb_total_horas_extras
            // 
            this.tb_total_horas_extras.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSalario_off, "SALARIO_OFF.TOTAL_HORAS_EXTRAS_SAL_OFF", true));
            this.tb_total_horas_extras.Location = new System.Drawing.Point(177, 171);
            this.tb_total_horas_extras.Name = "tb_total_horas_extras";
            this.tb_total_horas_extras.Size = new System.Drawing.Size(136, 20);
            this.tb_total_horas_extras.TabIndex = 22;
            // 
            // dsSalario_off
            // 
            this.dsSalario_off.DataSetName = "dsSalario_off";
            this.dsSalario_off.Namespace = "http://www.tempuri.org/dsSalario_off.xsd";
            this.dsSalario_off.Tables.AddRange(new System.Data.DataTable[] {
            this.SALARIO_OFF});
            // 
            // SALARIO_OFF
            // 
            this.SALARIO_OFF.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_SAL_OFF,
            this.FUNCIONARIO_SAL_OFF,
            this.DATA_INICIAL_SAL_OFF,
            this.DATA_FINAL_SAL_OFF,
            this.QTDE_DIAS_PERIODO_SAL_OFF,
            this.SALARIO_BASE_SAL_OFF,
            this.SALARIO_BASE_POR_HORA_SAL_OFF,
            this.SALARIO_SAL_OFF,
            this.HORAS_SALARIO_BASE_SAL_OFF,
            this.DSR_SAL_OFF,
            this.HORAS_DSR_SAL_OFF,
            this.TOTAL_HORAS_EXTRAS_SAL_OFF,
            this.EXTRA_50_SAL_OFF,
            this.HORAS_EXTRA_50_SAL_OFF,
            this.EXTRA_60_SAL_OFF,
            this.HORAS_EXTRA_60_SAL_OFF,
            this.EXTRA_80_SAL_OFF,
            this.HORAS_EXTRA_80_SAL_OFF,
            this.EXTRA_100_SAL_OFF,
            this.HORAS_EXTRA_100_SAL_OFF,
            this.OUTROS_VENC_SAL_OFF,
            this.HORAS_OUTROS_SAL_OFF,
            this.DESCRICAO_OUTROS_VENC_SAL_OFF,
            this.AD_NOTURNO_35_SAL_OFF,
            this.HORAS_AD_NOTURNO_35_SAL_OFF,
            this.VALE_TRANSPORTE_SAL_OFF,
            this.QTDE_VALE_TRANSPORTE_SAL_OFF,
            this.ADIANTAMENTO_SAL_OFF,
            this.VALE_TRANSPORTE_DESC_SAL_OFF,
            this.REFEICAO_SAL_OFF,
            this.LANCHE_SAL_OFF,
            this.TOTAL_VENCIMENTOS_SAL_OFF,
            this.TOTAL_DESCONTOS_SAL_OFF,
            this.LIQUIDO_A_REC_SAL_OFF,
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn7,
            this.dataColumn8});
            this.SALARIO_OFF.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_SAL_OFF"}, true)});
            this.SALARIO_OFF.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_SAL_OFF};
            this.SALARIO_OFF.TableName = "SALARIO_OFF";
            // 
            // COD_SAL_OFF
            // 
            this.COD_SAL_OFF.AllowDBNull = false;
            this.COD_SAL_OFF.ColumnName = "COD_SAL_OFF";
            this.COD_SAL_OFF.DataType = typeof(int);
            // 
            // FUNCIONARIO_SAL_OFF
            // 
            this.FUNCIONARIO_SAL_OFF.ColumnName = "FUNCIONARIO_SAL_OFF";
            this.FUNCIONARIO_SAL_OFF.MaxLength = 5;
            // 
            // DATA_INICIAL_SAL_OFF
            // 
            this.DATA_INICIAL_SAL_OFF.ColumnName = "DATA_INICIAL_SAL_OFF";
            this.DATA_INICIAL_SAL_OFF.DataType = typeof(System.DateTime);
            // 
            // DATA_FINAL_SAL_OFF
            // 
            this.DATA_FINAL_SAL_OFF.ColumnName = "DATA_FINAL_SAL_OFF";
            this.DATA_FINAL_SAL_OFF.DataType = typeof(System.DateTime);
            // 
            // QTDE_DIAS_PERIODO_SAL_OFF
            // 
            this.QTDE_DIAS_PERIODO_SAL_OFF.ColumnName = "QTDE_DIAS_PERIODO_SAL_OFF";
            this.QTDE_DIAS_PERIODO_SAL_OFF.DataType = typeof(int);
            // 
            // SALARIO_BASE_SAL_OFF
            // 
            this.SALARIO_BASE_SAL_OFF.ColumnName = "SALARIO_BASE_SAL_OFF";
            this.SALARIO_BASE_SAL_OFF.DataType = typeof(double);
            // 
            // SALARIO_BASE_POR_HORA_SAL_OFF
            // 
            this.SALARIO_BASE_POR_HORA_SAL_OFF.ColumnName = "SALARIO_BASE_POR_HORA_SAL_OFF";
            this.SALARIO_BASE_POR_HORA_SAL_OFF.DataType = typeof(double);
            // 
            // SALARIO_SAL_OFF
            // 
            this.SALARIO_SAL_OFF.ColumnName = "SALARIO_SAL_OFF";
            this.SALARIO_SAL_OFF.DataType = typeof(double);
            // 
            // HORAS_SALARIO_BASE_SAL_OFF
            // 
            this.HORAS_SALARIO_BASE_SAL_OFF.ColumnName = "HORAS_SALARIO_BASE_SAL_OFF";
            this.HORAS_SALARIO_BASE_SAL_OFF.DataType = typeof(double);
            // 
            // DSR_SAL_OFF
            // 
            this.DSR_SAL_OFF.ColumnName = "DSR_SAL_OFF";
            this.DSR_SAL_OFF.DataType = typeof(double);
            // 
            // HORAS_DSR_SAL_OFF
            // 
            this.HORAS_DSR_SAL_OFF.ColumnName = "HORAS_DSR_SAL_OFF";
            this.HORAS_DSR_SAL_OFF.DataType = typeof(double);
            // 
            // TOTAL_HORAS_EXTRAS_SAL_OFF
            // 
            this.TOTAL_HORAS_EXTRAS_SAL_OFF.ColumnName = "TOTAL_HORAS_EXTRAS_SAL_OFF";
            this.TOTAL_HORAS_EXTRAS_SAL_OFF.DataType = typeof(double);
            // 
            // EXTRA_50_SAL_OFF
            // 
            this.EXTRA_50_SAL_OFF.ColumnName = "EXTRA_50_SAL_OFF";
            this.EXTRA_50_SAL_OFF.DataType = typeof(double);
            // 
            // HORAS_EXTRA_50_SAL_OFF
            // 
            this.HORAS_EXTRA_50_SAL_OFF.ColumnName = "HORAS_EXTRA_50_SAL_OFF";
            this.HORAS_EXTRA_50_SAL_OFF.DataType = typeof(double);
            // 
            // EXTRA_60_SAL_OFF
            // 
            this.EXTRA_60_SAL_OFF.ColumnName = "EXTRA_60_SAL_OFF";
            this.EXTRA_60_SAL_OFF.DataType = typeof(double);
            // 
            // HORAS_EXTRA_60_SAL_OFF
            // 
            this.HORAS_EXTRA_60_SAL_OFF.ColumnName = "HORAS_EXTRA_60_SAL_OFF";
            this.HORAS_EXTRA_60_SAL_OFF.DataType = typeof(double);
            // 
            // EXTRA_80_SAL_OFF
            // 
            this.EXTRA_80_SAL_OFF.ColumnName = "EXTRA_80_SAL_OFF";
            this.EXTRA_80_SAL_OFF.DataType = typeof(double);
            // 
            // HORAS_EXTRA_80_SAL_OFF
            // 
            this.HORAS_EXTRA_80_SAL_OFF.ColumnName = "HORAS_EXTRA_80_SAL_OFF";
            this.HORAS_EXTRA_80_SAL_OFF.DataType = typeof(double);
            // 
            // EXTRA_100_SAL_OFF
            // 
            this.EXTRA_100_SAL_OFF.ColumnName = "EXTRA_100_SAL_OFF";
            this.EXTRA_100_SAL_OFF.DataType = typeof(double);
            // 
            // HORAS_EXTRA_100_SAL_OFF
            // 
            this.HORAS_EXTRA_100_SAL_OFF.ColumnName = "HORAS_EXTRA_100_SAL_OFF";
            this.HORAS_EXTRA_100_SAL_OFF.DataType = typeof(double);
            // 
            // OUTROS_VENC_SAL_OFF
            // 
            this.OUTROS_VENC_SAL_OFF.ColumnName = "OUTROS_VENC_SAL_OFF";
            this.OUTROS_VENC_SAL_OFF.DataType = typeof(double);
            // 
            // HORAS_OUTROS_SAL_OFF
            // 
            this.HORAS_OUTROS_SAL_OFF.ColumnName = "HORAS_OUTROS_SAL_OFF";
            this.HORAS_OUTROS_SAL_OFF.DataType = typeof(double);
            // 
            // DESCRICAO_OUTROS_VENC_SAL_OFF
            // 
            this.DESCRICAO_OUTROS_VENC_SAL_OFF.ColumnName = "DESCRICAO_OUTROS_VENC_SAL_OFF";
            this.DESCRICAO_OUTROS_VENC_SAL_OFF.MaxLength = 100;
            // 
            // AD_NOTURNO_35_SAL_OFF
            // 
            this.AD_NOTURNO_35_SAL_OFF.ColumnName = "AD_NOTURNO_35_SAL_OFF";
            this.AD_NOTURNO_35_SAL_OFF.DataType = typeof(double);
            // 
            // HORAS_AD_NOTURNO_35_SAL_OFF
            // 
            this.HORAS_AD_NOTURNO_35_SAL_OFF.ColumnName = "HORAS_AD_NOTURNO_35_SAL_OFF";
            this.HORAS_AD_NOTURNO_35_SAL_OFF.DataType = typeof(double);
            // 
            // VALE_TRANSPORTE_SAL_OFF
            // 
            this.VALE_TRANSPORTE_SAL_OFF.ColumnName = "VALE_TRANSPORTE_SAL_OFF";
            this.VALE_TRANSPORTE_SAL_OFF.DataType = typeof(double);
            // 
            // QTDE_VALE_TRANSPORTE_SAL_OFF
            // 
            this.QTDE_VALE_TRANSPORTE_SAL_OFF.ColumnName = "QTDE_VALE_TRANSPORTE_SAL_OFF";
            this.QTDE_VALE_TRANSPORTE_SAL_OFF.DataType = typeof(double);
            // 
            // ADIANTAMENTO_SAL_OFF
            // 
            this.ADIANTAMENTO_SAL_OFF.ColumnName = "ADIANTAMENTO_SAL_OFF";
            this.ADIANTAMENTO_SAL_OFF.DataType = typeof(double);
            // 
            // VALE_TRANSPORTE_DESC_SAL_OFF
            // 
            this.VALE_TRANSPORTE_DESC_SAL_OFF.ColumnName = "VALE_TRANSPORTE_DESC_SAL_OFF";
            this.VALE_TRANSPORTE_DESC_SAL_OFF.DataType = typeof(double);
            // 
            // REFEICAO_SAL_OFF
            // 
            this.REFEICAO_SAL_OFF.ColumnName = "REFEICAO_SAL_OFF";
            this.REFEICAO_SAL_OFF.DataType = typeof(double);
            // 
            // LANCHE_SAL_OFF
            // 
            this.LANCHE_SAL_OFF.ColumnName = "LANCHE_SAL_OFF";
            this.LANCHE_SAL_OFF.DataType = typeof(double);
            // 
            // TOTAL_VENCIMENTOS_SAL_OFF
            // 
            this.TOTAL_VENCIMENTOS_SAL_OFF.ColumnName = "TOTAL_VENCIMENTOS_SAL_OFF";
            this.TOTAL_VENCIMENTOS_SAL_OFF.DataType = typeof(double);
            // 
            // TOTAL_DESCONTOS_SAL_OFF
            // 
            this.TOTAL_DESCONTOS_SAL_OFF.ColumnName = "TOTAL_DESCONTOS_SAL_OFF";
            this.TOTAL_DESCONTOS_SAL_OFF.DataType = typeof(double);
            // 
            // LIQUIDO_A_REC_SAL_OFF
            // 
            this.LIQUIDO_A_REC_SAL_OFF.ColumnName = "LIQUIDO_A_REC_SAL_OFF";
            this.LIQUIDO_A_REC_SAL_OFF.DataType = typeof(double);
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "OUTROS_DESC_SAL_OFF";
            this.dataColumn1.DataType = typeof(double);
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "HORAS_OUTROS_DESC_SAL_OFF";
            this.dataColumn2.DataType = typeof(double);
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "DESCRICAO_OUTROS_DESC_SAL_OFF";
            this.dataColumn3.MaxLength = 80;
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "ADIANTAMENTOS_SIM_NAO_SAL_OFF";
            this.dataColumn4.DataType = typeof(int);
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "VALE_SIM_NAO_SAL_OFF";
            this.dataColumn5.DataType = typeof(int);
            // 
            // tb_ref_dsr
            // 
            this.tb_ref_dsr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSalario_off, "SALARIO_OFF.HORAS_DSR_SAL_OFF", true));
            this.tb_ref_dsr.Location = new System.Drawing.Point(177, 145);
            this.tb_ref_dsr.Name = "tb_ref_dsr";
            this.tb_ref_dsr.Size = new System.Drawing.Size(136, 20);
            this.tb_ref_dsr.TabIndex = 21;
            this.tb_ref_dsr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ref_dsr_KeyPress);
            // 
            // tb_ref_salario
            // 
            this.tb_ref_salario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSalario_off, "SALARIO_OFF.HORAS_SALARIO_BASE_SAL_OFF", true));
            this.tb_ref_salario.Location = new System.Drawing.Point(177, 119);
            this.tb_ref_salario.Name = "tb_ref_salario";
            this.tb_ref_salario.Size = new System.Drawing.Size(136, 20);
            this.tb_ref_salario.TabIndex = 20;
            this.tb_ref_salario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ref_salario_KeyPress);
            // 
            // tb_ref_80
            // 
            this.tb_ref_80.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSalario_off, "SALARIO_OFF.HORAS_EXTRA_80_SAL_OFF", true));
            this.tb_ref_80.Location = new System.Drawing.Point(177, 247);
            this.tb_ref_80.Name = "tb_ref_80";
            this.tb_ref_80.Size = new System.Drawing.Size(136, 20);
            this.tb_ref_80.TabIndex = 25;
            this.tb_ref_80.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ref_80_KeyPress);
            // 
            // tb_ref_60
            // 
            this.tb_ref_60.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSalario_off, "SALARIO_OFF.HORAS_EXTRA_60_SAL_OFF", true));
            this.tb_ref_60.Location = new System.Drawing.Point(177, 222);
            this.tb_ref_60.Name = "tb_ref_60";
            this.tb_ref_60.Size = new System.Drawing.Size(136, 20);
            this.tb_ref_60.TabIndex = 24;
            this.tb_ref_60.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ref_60_KeyPress);
            // 
            // tb_ref_50
            // 
            this.tb_ref_50.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSalario_off, "SALARIO_OFF.HORAS_EXTRA_50_SAL_OFF", true));
            this.tb_ref_50.Location = new System.Drawing.Point(177, 196);
            this.tb_ref_50.Name = "tb_ref_50";
            this.tb_ref_50.Size = new System.Drawing.Size(136, 20);
            this.tb_ref_50.TabIndex = 23;
            this.tb_ref_50.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ref_50_KeyPress);
            // 
            // tb_ref_vale
            // 
            this.tb_ref_vale.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSalario_off, "SALARIO_OFF.QTDE_VALE_TRANSPORTE_SAL_OFF", true));
            this.tb_ref_vale.Location = new System.Drawing.Point(177, 323);
            this.tb_ref_vale.Name = "tb_ref_vale";
            this.tb_ref_vale.Size = new System.Drawing.Size(136, 20);
            this.tb_ref_vale.TabIndex = 28;
            this.tb_ref_vale.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ref_vale_KeyPress);
            // 
            // tb_ref_noturno
            // 
            this.tb_ref_noturno.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSalario_off, "SALARIO_OFF.HORAS_AD_NOTURNO_35_SAL_OFF", true));
            this.tb_ref_noturno.Location = new System.Drawing.Point(177, 298);
            this.tb_ref_noturno.Name = "tb_ref_noturno";
            this.tb_ref_noturno.Size = new System.Drawing.Size(136, 20);
            this.tb_ref_noturno.TabIndex = 27;
            this.tb_ref_noturno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ref_noturno_KeyPress);
            // 
            // tb_ref_100
            // 
            this.tb_ref_100.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSalario_off, "SALARIO_OFF.HORAS_EXTRA_100_SAL_OFF", true));
            this.tb_ref_100.Location = new System.Drawing.Point(177, 272);
            this.tb_ref_100.Name = "tb_ref_100";
            this.tb_ref_100.Size = new System.Drawing.Size(136, 20);
            this.tb_ref_100.TabIndex = 26;
            this.tb_ref_100.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ref_100_KeyPress);
            // 
            // tb_total_liquido
            // 
            this.tb_total_liquido.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSalario_off, "SALARIO_OFF.LIQUIDO_A_REC_SAL_OFF", true));
            this.tb_total_liquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_total_liquido.Location = new System.Drawing.Point(346, 592);
            this.tb_total_liquido.Name = "tb_total_liquido";
            this.tb_total_liquido.Size = new System.Drawing.Size(136, 26);
            this.tb_total_liquido.TabIndex = 179;
            this.tb_total_liquido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_total_liquido_KeyPress);
            // 
            // tb_total_descontos
            // 
            this.tb_total_descontos.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSalario_off, "SALARIO_OFF.TOTAL_DESCONTOS_SAL_OFF", true));
            this.tb_total_descontos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_total_descontos.Location = new System.Drawing.Point(346, 556);
            this.tb_total_descontos.Name = "tb_total_descontos";
            this.tb_total_descontos.Size = new System.Drawing.Size(136, 23);
            this.tb_total_descontos.TabIndex = 178;
            this.tb_total_descontos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_total_descontos_KeyPress);
            // 
            // tb_lanche
            // 
            this.tb_lanche.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSalario_off, "SALARIO_OFF.LANCHE_SAL_OFF", true));
            this.tb_lanche.Location = new System.Drawing.Point(346, 504);
            this.tb_lanche.Name = "tb_lanche";
            this.tb_lanche.Size = new System.Drawing.Size(136, 20);
            this.tb_lanche.TabIndex = 33;
            this.tb_lanche.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_lanche_KeyPress);
            // 
            // tb_refeicao
            // 
            this.tb_refeicao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSalario_off, "SALARIO_OFF.REFEICAO_SAL_OFF", true));
            this.tb_refeicao.Location = new System.Drawing.Point(346, 478);
            this.tb_refeicao.Name = "tb_refeicao";
            this.tb_refeicao.Size = new System.Drawing.Size(136, 20);
            this.tb_refeicao.TabIndex = 32;
            this.tb_refeicao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_refeicao_KeyPress);
            // 
            // tb_vale_desc
            // 
            this.tb_vale_desc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSalario_off, "SALARIO_OFF.VALE_TRANSPORTE_DESC_SAL_OFF", true));
            this.tb_vale_desc.Location = new System.Drawing.Point(346, 453);
            this.tb_vale_desc.Name = "tb_vale_desc";
            this.tb_vale_desc.Size = new System.Drawing.Size(136, 20);
            this.tb_vale_desc.TabIndex = 31;
            this.tb_vale_desc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_vale_desc_KeyPress);
            // 
            // tb_adiantamento
            // 
            this.tb_adiantamento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSalario_off, "SALARIO_OFF.ADIANTAMENTO_SAL_OFF", true));
            this.tb_adiantamento.Location = new System.Drawing.Point(346, 428);
            this.tb_adiantamento.Name = "tb_adiantamento";
            this.tb_adiantamento.Size = new System.Drawing.Size(136, 20);
            this.tb_adiantamento.TabIndex = 30;
            this.tb_adiantamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_adiantamento_KeyPress);
            // 
            // tb_total_venc
            // 
            this.tb_total_venc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSalario_off, "SALARIO_OFF.TOTAL_VENCIMENTOS_SAL_OFF", true));
            this.tb_total_venc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_total_venc.Location = new System.Drawing.Point(346, 399);
            this.tb_total_venc.Name = "tb_total_venc";
            this.tb_total_venc.Size = new System.Drawing.Size(136, 23);
            this.tb_total_venc.TabIndex = 173;
            this.tb_total_venc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_total_venc_KeyPress);
            // 
            // tb_valor_vale
            // 
            this.tb_valor_vale.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSalario_off, "SALARIO_OFF.VALE_TRANSPORTE_SAL_OFF", true));
            this.tb_valor_vale.Location = new System.Drawing.Point(346, 323);
            this.tb_valor_vale.Name = "tb_valor_vale";
            this.tb_valor_vale.Size = new System.Drawing.Size(136, 20);
            this.tb_valor_vale.TabIndex = 172;
            // 
            // tb_valor_noturno
            // 
            this.tb_valor_noturno.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSalario_off, "SALARIO_OFF.AD_NOTURNO_35_SAL_OFF", true));
            this.tb_valor_noturno.Location = new System.Drawing.Point(346, 298);
            this.tb_valor_noturno.Name = "tb_valor_noturno";
            this.tb_valor_noturno.Size = new System.Drawing.Size(136, 20);
            this.tb_valor_noturno.TabIndex = 171;
            // 
            // tb_valor_100
            // 
            this.tb_valor_100.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSalario_off, "SALARIO_OFF.EXTRA_100_SAL_OFF", true));
            this.tb_valor_100.Location = new System.Drawing.Point(346, 272);
            this.tb_valor_100.Name = "tb_valor_100";
            this.tb_valor_100.Size = new System.Drawing.Size(136, 20);
            this.tb_valor_100.TabIndex = 170;
            // 
            // tb_valor_80
            // 
            this.tb_valor_80.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSalario_off, "SALARIO_OFF.EXTRA_80_SAL_OFF", true));
            this.tb_valor_80.Location = new System.Drawing.Point(346, 247);
            this.tb_valor_80.Name = "tb_valor_80";
            this.tb_valor_80.Size = new System.Drawing.Size(136, 20);
            this.tb_valor_80.TabIndex = 169;
            // 
            // tb_valor_60
            // 
            this.tb_valor_60.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSalario_off, "SALARIO_OFF.EXTRA_60_SAL_OFF", true));
            this.tb_valor_60.Location = new System.Drawing.Point(346, 222);
            this.tb_valor_60.Name = "tb_valor_60";
            this.tb_valor_60.Size = new System.Drawing.Size(136, 20);
            this.tb_valor_60.TabIndex = 168;
            // 
            // tb_valor_50
            // 
            this.tb_valor_50.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSalario_off, "SALARIO_OFF.EXTRA_50_SAL_OFF", true));
            this.tb_valor_50.Location = new System.Drawing.Point(346, 196);
            this.tb_valor_50.Name = "tb_valor_50";
            this.tb_valor_50.Size = new System.Drawing.Size(136, 20);
            this.tb_valor_50.TabIndex = 167;
            // 
            // tb_valor_dsr
            // 
            this.tb_valor_dsr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSalario_off, "SALARIO_OFF.DSR_SAL_OFF", true));
            this.tb_valor_dsr.Location = new System.Drawing.Point(346, 145);
            this.tb_valor_dsr.Name = "tb_valor_dsr";
            this.tb_valor_dsr.Size = new System.Drawing.Size(136, 20);
            this.tb_valor_dsr.TabIndex = 165;
            // 
            // tb_valor_salario
            // 
            this.tb_valor_salario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSalario_off, "SALARIO_OFF.SALARIO_SAL_OFF", true));
            this.tb_valor_salario.Location = new System.Drawing.Point(346, 119);
            this.tb_valor_salario.Name = "tb_valor_salario";
            this.tb_valor_salario.Size = new System.Drawing.Size(136, 20);
            this.tb_valor_salario.TabIndex = 164;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(226, 96);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(43, 20);
            this.label26.TabIndex = 180;
            this.label26.Text = "Ref.";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(390, 96);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(51, 20);
            this.label27.TabIndex = 181;
            this.label27.Text = "Valor";
            // 
            // groupBoxRH
            // 
            this.groupBoxRH.Controls.Add(this.tb_outros_2);
            this.groupBoxRH.Controls.Add(this.tb_ref_excecao);
            this.groupBoxRH.Controls.Add(this.cbVale_transporte);
            this.groupBoxRH.Controls.Add(this.cbAdiantamento);
            this.groupBoxRH.Controls.Add(this.label33);
            this.groupBoxRH.Controls.Add(this.label34);
            this.groupBoxRH.Controls.Add(this.textBox16);
            this.groupBoxRH.Controls.Add(this.tb_valor_outros_desc);
            this.groupBoxRH.Controls.Add(this.textBox40);
            this.groupBoxRH.Controls.Add(this.textBox38);
            this.groupBoxRH.Controls.Add(this.tb_valor_outros);
            this.groupBoxRH.Controls.Add(this.tb_ref_outros);
            this.groupBoxRH.Controls.Add(this.tb_cod_sal_off);
            this.groupBoxRH.Controls.Add(this.label32);
            this.groupBoxRH.Controls.Add(this.button10);
            this.groupBoxRH.Controls.Add(this.tb_data_final);
            this.groupBoxRH.Controls.Add(this.label28);
            this.groupBoxRH.Controls.Add(this.tb_data_inicial);
            this.groupBoxRH.Controls.Add(this.label31);
            this.groupBoxRH.Controls.Add(this.tb_salario_hora_base);
            this.groupBoxRH.Controls.Add(this.label30);
            this.groupBoxRH.Controls.Add(this.button9);
            this.groupBoxRH.Controls.Add(this.tb_salario_base);
            this.groupBoxRH.Controls.Add(this.label29);
            this.groupBoxRH.Controls.Add(this.button2);
            this.groupBoxRH.Controls.Add(this.button4);
            this.groupBoxRH.Controls.Add(this.button5);
            this.groupBoxRH.Controls.Add(this.button6);
            this.groupBoxRH.Controls.Add(this.button7);
            this.groupBoxRH.Controls.Add(this.button8);
            this.groupBoxRH.Controls.Add(this.label27);
            this.groupBoxRH.Controls.Add(this.label26);
            this.groupBoxRH.Controls.Add(this.tb_total_liquido);
            this.groupBoxRH.Controls.Add(this.tb_total_descontos);
            this.groupBoxRH.Controls.Add(this.tb_lanche);
            this.groupBoxRH.Controls.Add(this.tb_refeicao);
            this.groupBoxRH.Controls.Add(this.tb_vale_desc);
            this.groupBoxRH.Controls.Add(this.tb_adiantamento);
            this.groupBoxRH.Controls.Add(this.tb_total_venc);
            this.groupBoxRH.Controls.Add(this.tb_valor_vale);
            this.groupBoxRH.Controls.Add(this.tb_valor_noturno);
            this.groupBoxRH.Controls.Add(this.tb_valor_100);
            this.groupBoxRH.Controls.Add(this.tb_valor_80);
            this.groupBoxRH.Controls.Add(this.tb_valor_60);
            this.groupBoxRH.Controls.Add(this.tb_valor_50);
            this.groupBoxRH.Controls.Add(this.tb_valor_dsr);
            this.groupBoxRH.Controls.Add(this.tb_valor_salario);
            this.groupBoxRH.Controls.Add(this.tb_ref_vale);
            this.groupBoxRH.Controls.Add(this.tb_ref_noturno);
            this.groupBoxRH.Controls.Add(this.tb_ref_100);
            this.groupBoxRH.Controls.Add(this.tb_ref_80);
            this.groupBoxRH.Controls.Add(this.tb_ref_60);
            this.groupBoxRH.Controls.Add(this.tb_ref_50);
            this.groupBoxRH.Controls.Add(this.tb_total_horas_extras);
            this.groupBoxRH.Controls.Add(this.tb_ref_dsr);
            this.groupBoxRH.Controls.Add(this.tb_ref_salario);
            this.groupBoxRH.Controls.Add(this.label17);
            this.groupBoxRH.Controls.Add(this.label18);
            this.groupBoxRH.Controls.Add(this.label19);
            this.groupBoxRH.Controls.Add(this.label21);
            this.groupBoxRH.Controls.Add(this.label22);
            this.groupBoxRH.Controls.Add(this.label23);
            this.groupBoxRH.Controls.Add(this.label24);
            this.groupBoxRH.Controls.Add(this.label9);
            this.groupBoxRH.Controls.Add(this.label11);
            this.groupBoxRH.Controls.Add(this.label15);
            this.groupBoxRH.Controls.Add(this.label16);
            this.groupBoxRH.Controls.Add(this.label4);
            this.groupBoxRH.Controls.Add(this.label5);
            this.groupBoxRH.Controls.Add(this.label7);
            this.groupBoxRH.Controls.Add(this.label8);
            this.groupBoxRH.Location = new System.Drawing.Point(421, 12);
            this.groupBoxRH.Name = "groupBoxRH";
            this.groupBoxRH.Size = new System.Drawing.Size(519, 657);
            this.groupBoxRH.TabIndex = 14;
            this.groupBoxRH.TabStop = false;
            this.groupBoxRH.Text = "RH";
            // 
            // cbVale_transporte
            // 
            this.cbVale_transporte.AutoSize = true;
            this.cbVale_transporte.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsSalario_off, "SALARIO_OFF.VALE_SIM_NAO_SAL_OFF", true));
            this.cbVale_transporte.Location = new System.Drawing.Point(325, 456);
            this.cbVale_transporte.Name = "cbVale_transporte";
            this.cbVale_transporte.Size = new System.Drawing.Size(15, 14);
            this.cbVale_transporte.TabIndex = 212;
            this.cbVale_transporte.UseVisualStyleBackColor = true;
            this.cbVale_transporte.CheckedChanged += new System.EventHandler(this.cbVale_transporte_CheckedChanged);
            // 
            // cbAdiantamento
            // 
            this.cbAdiantamento.AutoSize = true;
            this.cbAdiantamento.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsSalario_off, "SALARIO_OFF.ADIANTAMENTOS_SIM_NAO_SAL_OFF", true));
            this.cbAdiantamento.Location = new System.Drawing.Point(325, 434);
            this.cbAdiantamento.Name = "cbAdiantamento";
            this.cbAdiantamento.Size = new System.Drawing.Size(15, 14);
            this.cbAdiantamento.TabIndex = 211;
            this.cbAdiantamento.UseVisualStyleBackColor = true;
            this.cbAdiantamento.CheckedChanged += new System.EventHandler(this.cbAdiantamento_CheckedChanged);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(182, 456);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(21, 13);
            this.label33.TabIndex = 210;
            this.label33.Text = "6%";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(182, 431);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(27, 13);
            this.label34.TabIndex = 209;
            this.label34.Text = "40%";
            // 
            // textBox16
            // 
            this.textBox16.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSalario_off, "SALARIO_OFF.DESCRICAO_OUTROS_DESC_SAL_OFF", true));
            this.textBox16.Location = new System.Drawing.Point(23, 530);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(136, 20);
            this.textBox16.TabIndex = 208;
            this.textBox16.Text = "Outros";
            // 
            // tb_valor_outros_desc
            // 
            this.tb_valor_outros_desc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSalario_off, "SALARIO_OFF.OUTROS_DESC_SAL_OFF", true));
            this.tb_valor_outros_desc.Location = new System.Drawing.Point(346, 530);
            this.tb_valor_outros_desc.Name = "tb_valor_outros_desc";
            this.tb_valor_outros_desc.Size = new System.Drawing.Size(136, 20);
            this.tb_valor_outros_desc.TabIndex = 35;
            this.tb_valor_outros_desc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_valor_outros_desc_KeyPress);
            // 
            // textBox40
            // 
            this.textBox40.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSalario_off, "SALARIO_OFF.HORAS_OUTROS_DESC_SAL_OFF", true));
            this.textBox40.Location = new System.Drawing.Point(177, 530);
            this.textBox40.Name = "textBox40";
            this.textBox40.Size = new System.Drawing.Size(136, 20);
            this.textBox40.TabIndex = 34;
            // 
            // textBox38
            // 
            this.textBox38.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSalario_off, "SALARIO_OFF.DESCRICAO_OUTROS_VENC_SAL_OFF", true));
            this.textBox38.Location = new System.Drawing.Point(23, 349);
            this.textBox38.Name = "textBox38";
            this.textBox38.Size = new System.Drawing.Size(136, 20);
            this.textBox38.TabIndex = 205;
            this.textBox38.Text = "Outros";
            // 
            // tb_valor_outros
            // 
            this.tb_valor_outros.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSalario_off, "SALARIO_OFF.OUTROS_VENC_SAL_OFF", true));
            this.tb_valor_outros.Location = new System.Drawing.Point(346, 349);
            this.tb_valor_outros.Name = "tb_valor_outros";
            this.tb_valor_outros.Size = new System.Drawing.Size(136, 20);
            this.tb_valor_outros.TabIndex = 204;
            // 
            // tb_ref_outros
            // 
            this.tb_ref_outros.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSalario_off, "SALARIO_OFF.HORAS_OUTROS_SAL_OFF", true));
            this.tb_ref_outros.Location = new System.Drawing.Point(247, 349);
            this.tb_ref_outros.Name = "tb_ref_outros";
            this.tb_ref_outros.Size = new System.Drawing.Size(65, 20);
            this.tb_ref_outros.TabIndex = 207;
            this.tb_ref_outros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ref_outros_KeyPress);
            // 
            // tb_cod_sal_off
            // 
            this.tb_cod_sal_off.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSalario_off, "SALARIO_OFF.COD_SAL_OFF", true));
            this.tb_cod_sal_off.Location = new System.Drawing.Point(51, 33);
            this.tb_cod_sal_off.Name = "tb_cod_sal_off";
            this.tb_cod_sal_off.ReadOnly = true;
            this.tb_cod_sal_off.Size = new System.Drawing.Size(52, 20);
            this.tb_cod_sal_off.TabIndex = 200;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(7, 37);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(43, 13);
            this.label32.TabIndex = 201;
            this.label32.Text = "Código:";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(488, 31);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(18, 23);
            this.button10.TabIndex = 17;
            this.button10.Text = "+";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // tb_data_final
            // 
            this.tb_data_final.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSalario_off, "SALARIO_OFF.DATA_FINAL_SAL_OFF", true));
            this.tb_data_final.Location = new System.Drawing.Point(346, 34);
            this.tb_data_final.Name = "tb_data_final";
            this.tb_data_final.Size = new System.Drawing.Size(136, 20);
            this.tb_data_final.TabIndex = 16;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(343, 18);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(58, 13);
            this.label28.TabIndex = 197;
            this.label28.Text = "Data Final:";
            // 
            // tb_data_inicial
            // 
            this.tb_data_inicial.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSalario_off, "SALARIO_OFF.DATA_INICIAL_SAL_OFF", true));
            this.tb_data_inicial.Location = new System.Drawing.Point(176, 34);
            this.tb_data_inicial.Name = "tb_data_inicial";
            this.tb_data_inicial.Size = new System.Drawing.Size(136, 20);
            this.tb_data_inicial.TabIndex = 15;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(173, 18);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(63, 13);
            this.label31.TabIndex = 195;
            this.label31.Text = "Data Inicial:";
            // 
            // tb_salario_hora_base
            // 
            this.tb_salario_hora_base.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSalario_off, "SALARIO_OFF.SALARIO_BASE_POR_HORA_SAL_OFF", true));
            this.tb_salario_hora_base.Location = new System.Drawing.Point(346, 73);
            this.tb_salario_hora_base.Name = "tb_salario_hora_base";
            this.tb_salario_hora_base.Size = new System.Drawing.Size(136, 20);
            this.tb_salario_hora_base.TabIndex = 19;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(343, 57);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(97, 13);
            this.label30.TabIndex = 193;
            this.label30.Text = "Salário/Hora Base:";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(119, 629);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(60, 22);
            this.button9.TabIndex = 41;
            this.button9.Text = "Copiar";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // tb_salario_base
            // 
            this.tb_salario_base.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSalario_off, "SALARIO_OFF.SALARIO_BASE_SAL_OFF", true));
            this.tb_salario_base.Location = new System.Drawing.Point(176, 73);
            this.tb_salario_base.Name = "tb_salario_base";
            this.tb_salario_base.Size = new System.Drawing.Size(136, 20);
            this.tb_salario_base.TabIndex = 18;
            this.tb_salario_base.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_salario_base_KeyPress);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(173, 57);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(69, 13);
            this.label29.TabIndex = 190;
            this.label29.Text = "Salário Base:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(295, 629);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 22);
            this.button2.TabIndex = 38;
            this.button2.Text = "Imprimir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(416, 629);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(66, 22);
            this.button4.TabIndex = 36;
            this.button4.Text = "Calcular";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(361, 629);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(49, 22);
            this.button5.TabIndex = 37;
            this.button5.Text = "Salvar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(53, 629);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(60, 22);
            this.button6.TabIndex = 42;
            this.button6.Text = "Localizar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(240, 629);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(49, 22);
            this.button7.TabIndex = 39;
            this.button7.Text = "Excluir";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(185, 629);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(49, 22);
            this.button8.TabIndex = 40;
            this.button8.Text = "Novo";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // datSalarios_off
            // 
            this.datSalarios_off.DeleteCommand = this.fbCommand8;
            this.datSalarios_off.InsertCommand = this.fbCommand6;
            this.datSalarios_off.SelectCommand = this.fbCommand5;
            this.datSalarios_off.UpdateCommand = this.fbCommand7;
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
            this.fbCommand5.CommandText = "select * from salario_off";
            this.fbCommand5.CommandTimeout = 30;
            this.fbCommand5.Connection = this.fbConnection1;
            // 
            // fbCommand7
            // 
            this.fbCommand7.CommandTimeout = 30;
            // 
            // cbSalario_off
            // 
            this.cbSalario_off.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbSalario_off.DataAdapter = this.datSalarios_off;
            this.cbSalario_off.QuotePrefix = "\"";
            this.cbSalario_off.QuoteSuffix = "\"";
            // 
            // datPeriodos
            // 
            this.datPeriodos.DeleteCommand = this.fbCommand12;
            this.datPeriodos.InsertCommand = this.fbCommand10;
            this.datPeriodos.SelectCommand = this.fbCommand9;
            this.datPeriodos.UpdateCommand = this.fbCommand11;
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
            this.fbCommand9.CommandText = "select * from periodos";
            this.fbCommand9.CommandTimeout = 30;
            this.fbCommand9.Connection = this.fbConnection1;
            // 
            // fbCommand11
            // 
            this.fbCommand11.CommandTimeout = 30;
            // 
            // dsPeriodos
            // 
            this.dsPeriodos.DataSetName = "dsPeriodos";
            this.dsPeriodos.Namespace = "http://www.tempuri.org/dsPeriodos.xsd";
            this.dsPeriodos.Tables.AddRange(new System.Data.DataTable[] {
            this.PERIODOS});
            // 
            // PERIODOS
            // 
            this.PERIODOS.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_PERIODO,
            this.DATA_INICIAL_PERIODO,
            this.DATA_FINAL_PERIODO,
            this.DIAS_PERIODO});
            this.PERIODOS.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_PERIODO"}, true)});
            this.PERIODOS.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_PERIODO};
            this.PERIODOS.TableName = "PERIODOS";
            // 
            // COD_PERIODO
            // 
            this.COD_PERIODO.AllowDBNull = false;
            this.COD_PERIODO.ColumnName = "COD_PERIODO";
            this.COD_PERIODO.DataType = typeof(int);
            // 
            // DATA_INICIAL_PERIODO
            // 
            this.DATA_INICIAL_PERIODO.ColumnName = "DATA_INICIAL_PERIODO";
            this.DATA_INICIAL_PERIODO.DataType = typeof(System.DateTime);
            // 
            // DATA_FINAL_PERIODO
            // 
            this.DATA_FINAL_PERIODO.ColumnName = "DATA_FINAL_PERIODO";
            this.DATA_FINAL_PERIODO.DataType = typeof(System.DateTime);
            // 
            // DIAS_PERIODO
            // 
            this.DIAS_PERIODO.ColumnName = "DIAS_PERIODO";
            this.DIAS_PERIODO.DataType = typeof(int);
            // 
            // tb_nivel_aut
            // 
            this.tb_nivel_aut.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsOperadores, "OPERADORES.NIVEL_AUT_OPERADOR", true));
            this.tb_nivel_aut.Location = new System.Drawing.Point(119, 262);
            this.tb_nivel_aut.Name = "tb_nivel_aut";
            this.tb_nivel_aut.Size = new System.Drawing.Size(59, 20);
            this.tb_nivel_aut.TabIndex = 119;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(7, 265);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(110, 13);
            this.label35.TabIndex = 120;
            this.label35.Text = "Nível de Autorização:";
            // 
            // tb_ref_excecao
            // 
            this.tb_ref_excecao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSalario_off, "SALARIO_OFF.REF_EXCECAO_SAL_OFF", true));
            this.tb_ref_excecao.Location = new System.Drawing.Point(177, 349);
            this.tb_ref_excecao.Name = "tb_ref_excecao";
            this.tb_ref_excecao.Size = new System.Drawing.Size(65, 20);
            this.tb_ref_excecao.TabIndex = 206;
            // 
            // dataColumn7
            // 
            this.dataColumn7.ColumnName = "REF_EXCECAO_SAL_OFF";
            this.dataColumn7.DataType = typeof(double);
            // 
            // tb_outros_2
            // 
            this.tb_outros_2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSalario_off, "SALARIO_OFF.DESCRICAO_OUTROS_2_VENC_SAL_OFF", true));
            this.tb_outros_2.Location = new System.Drawing.Point(23, 323);
            this.tb_outros_2.Name = "tb_outros_2";
            this.tb_outros_2.Size = new System.Drawing.Size(136, 20);
            this.tb_outros_2.TabIndex = 213;
            this.tb_outros_2.Text = "Vale Transporte";
            // 
            // dataColumn8
            // 
            this.dataColumn8.ColumnName = "DESCRICAO_OUTROS_2_VENC_SAL_OFF";
            this.dataColumn8.MaxLength = 100;
            // 
            // form_operadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 677);
            this.Controls.Add(this.tb_nivel_aut);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.groupBoxRH);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.apaga_registro);
            this.Controls.Add(this.salva_registro);
            this.Controls.Add(this.novo_registro);
            this.Controls.Add(this.textbox_operacao_executada);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textbox_data_admissao);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textbox_rg);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.textbox_data_demissao);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textbox_data_nascimento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textbox_ctps);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textbox_nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textbox_cod);
            this.Controls.Add(this.label1);
            this.Name = "form_operadores";
            this.Text = "Funcionários";
            this.Load += new System.EventHandler(this.form_operadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsOperadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OPERADORES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSalario_off)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SALARIO_OFF)).EndInit();
            this.groupBoxRH.ResumeLayout(false);
            this.groupBoxRH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsPeriodos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PERIODOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textbox_operacao_executada;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textbox_data_admissao;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textbox_rg;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textbox_data_demissao;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textbox_data_nascimento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textbox_ctps;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textbox_nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textbox_cod;
        private System.Windows.Forms.Label label1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datOperadores;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder fbCommandBuilder1;
        private System.Data.DataSet dsOperadores;
        private System.Data.DataTable OPERADORES;
        private System.Data.DataColumn COD_OPERADOR;
        private System.Data.DataColumn NOME;
        private System.Data.DataColumn CTPS;
        private System.Data.DataColumn RG;
        private System.Data.DataColumn DATA_NASCIMENTO;
        private System.Data.DataColumn DATA_ADMISSAO;
        private System.Data.DataColumn DATA_DEMISSAO;
        private System.Data.DataColumn OPERACAO_EXEC;
        private System.Windows.Forms.Button novo_registro;
        private System.Windows.Forms.Button salva_registro;
        private System.Windows.Forms.Button apaga_registro;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox tb_total_horas_extras;
        private System.Windows.Forms.TextBox tb_ref_dsr;
        private System.Windows.Forms.TextBox tb_ref_salario;
        private System.Windows.Forms.TextBox tb_ref_80;
        private System.Windows.Forms.TextBox tb_ref_60;
        private System.Windows.Forms.TextBox tb_ref_50;
        private System.Windows.Forms.TextBox tb_ref_vale;
        private System.Windows.Forms.TextBox tb_ref_noturno;
        private System.Windows.Forms.TextBox tb_ref_100;
        private System.Windows.Forms.TextBox tb_total_liquido;
        private System.Windows.Forms.TextBox tb_total_descontos;
        private System.Windows.Forms.TextBox tb_lanche;
        private System.Windows.Forms.TextBox tb_refeicao;
        private System.Windows.Forms.TextBox tb_vale_desc;
        private System.Windows.Forms.TextBox tb_adiantamento;
        private System.Windows.Forms.TextBox tb_total_venc;
        private System.Windows.Forms.TextBox tb_valor_vale;
        private System.Windows.Forms.TextBox tb_valor_noturno;
        private System.Windows.Forms.TextBox tb_valor_100;
        private System.Windows.Forms.TextBox tb_valor_80;
        private System.Windows.Forms.TextBox tb_valor_60;
        private System.Windows.Forms.TextBox tb_valor_50;
        private System.Windows.Forms.TextBox tb_valor_dsr;
        private System.Windows.Forms.TextBox tb_valor_salario;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.GroupBox groupBoxRH;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox tb_salario_hora_base;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox tb_salario_base;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox tb_data_final;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox tb_data_inicial;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox tb_cod_sal_off;
        private System.Windows.Forms.Label label32;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datSalarios_off;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand8;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand6;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand5;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand7;
        private System.Data.DataSet dsSalario_off;
        private System.Data.DataTable SALARIO_OFF;
        private System.Data.DataColumn COD_SAL_OFF;
        private System.Data.DataColumn FUNCIONARIO_SAL_OFF;
        private System.Data.DataColumn DATA_INICIAL_SAL_OFF;
        private System.Data.DataColumn DATA_FINAL_SAL_OFF;
        private System.Data.DataColumn QTDE_DIAS_PERIODO_SAL_OFF;
        private System.Data.DataColumn SALARIO_BASE_SAL_OFF;
        private System.Data.DataColumn SALARIO_BASE_POR_HORA_SAL_OFF;
        private System.Data.DataColumn SALARIO_SAL_OFF;
        private System.Data.DataColumn HORAS_SALARIO_BASE_SAL_OFF;
        private System.Data.DataColumn DSR_SAL_OFF;
        private System.Data.DataColumn HORAS_DSR_SAL_OFF;
        private System.Data.DataColumn TOTAL_HORAS_EXTRAS_SAL_OFF;
        private System.Data.DataColumn EXTRA_50_SAL_OFF;
        private System.Data.DataColumn HORAS_EXTRA_50_SAL_OFF;
        private System.Data.DataColumn EXTRA_60_SAL_OFF;
        private System.Data.DataColumn HORAS_EXTRA_60_SAL_OFF;
        private System.Data.DataColumn EXTRA_80_SAL_OFF;
        private System.Data.DataColumn HORAS_EXTRA_80_SAL_OFF;
        private System.Data.DataColumn EXTRA_100_SAL_OFF;
        private System.Data.DataColumn HORAS_EXTRA_100_SAL_OFF;
        private System.Data.DataColumn OUTROS_VENC_SAL_OFF;
        private System.Data.DataColumn HORAS_OUTROS_SAL_OFF;
        private System.Data.DataColumn DESCRICAO_OUTROS_VENC_SAL_OFF;
        private System.Data.DataColumn AD_NOTURNO_35_SAL_OFF;
        private System.Data.DataColumn HORAS_AD_NOTURNO_35_SAL_OFF;
        private System.Data.DataColumn VALE_TRANSPORTE_SAL_OFF;
        private System.Data.DataColumn QTDE_VALE_TRANSPORTE_SAL_OFF;
        private System.Data.DataColumn ADIANTAMENTO_SAL_OFF;
        private System.Data.DataColumn VALE_TRANSPORTE_DESC_SAL_OFF;
        private System.Data.DataColumn REFEICAO_SAL_OFF;
        private System.Data.DataColumn LANCHE_SAL_OFF;
        private System.Data.DataColumn TOTAL_VENCIMENTOS_SAL_OFF;
        private System.Data.DataColumn TOTAL_DESCONTOS_SAL_OFF;
        private System.Data.DataColumn LIQUIDO_A_REC_SAL_OFF;
        private System.Windows.Forms.TextBox textBox38;
        private System.Windows.Forms.TextBox tb_valor_outros;
        private System.Windows.Forms.TextBox tb_ref_outros;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox tb_valor_outros_desc;
        private System.Windows.Forms.TextBox textBox40;
        private System.Data.DataColumn dataColumn3;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbSalario_off;
        private System.Windows.Forms.CheckBox cbVale_transporte;
        private System.Windows.Forms.CheckBox cbAdiantamento;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datPeriodos;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand12;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand10;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand9;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand11;
        private System.Data.DataSet dsPeriodos;
        private System.Data.DataTable PERIODOS;
        private System.Data.DataColumn COD_PERIODO;
        private System.Data.DataColumn DATA_INICIAL_PERIODO;
        private System.Data.DataColumn DATA_FINAL_PERIODO;
        private System.Data.DataColumn DIAS_PERIODO;
        private System.Windows.Forms.TextBox tb_nivel_aut;
        private System.Windows.Forms.Label label35;
        private System.Data.DataColumn dataColumn6;
        private System.Data.DataColumn dataColumn7;
        private System.Windows.Forms.TextBox tb_ref_excecao;
        private System.Data.DataColumn dataColumn8;
        private System.Windows.Forms.TextBox tb_outros_2;
    }
}