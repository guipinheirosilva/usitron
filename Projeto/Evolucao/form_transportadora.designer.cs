namespace Evolucao
{
    partial class form_transportadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_transportadora));
            this.label20 = new System.Windows.Forms.Label();
            this.apaga_registro = new System.Windows.Forms.Button();
            this.salva_registro = new System.Windows.Forms.Button();
            this.vai_anterior = new System.Windows.Forms.Button();
            this.vai_proximo = new System.Windows.Forms.Button();
            this.vai_ultimo = new System.Windows.Forms.Button();
            this.novo_registro = new System.Windows.Forms.Button();
            this.vai_primeiro = new System.Windows.Forms.Button();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.dsTransportadoras = new System.Data.DataSet();
            this.TRANSPORTADORAS = new System.Data.DataTable();
            this.COD_TRANSPORTADORA = new System.Data.DataColumn();
            this.NOME_TRANSPORTADORA = new System.Data.DataColumn();
            this.RAZAO_SOCIAL_TRANSPORTADORA = new System.Data.DataColumn();
            this.ENDERECO_TRANSPORTADORA = new System.Data.DataColumn();
            this.BAIRRO_TRANSPORTADORA = new System.Data.DataColumn();
            this.CIDADE_TRANSPORTADORA = new System.Data.DataColumn();
            this.ESTADO_TRANSPORTADORA = new System.Data.DataColumn();
            this.PAIS_TRANSPORTADORA = new System.Data.DataColumn();
            this.CNPJ_TRANSPORTADORA = new System.Data.DataColumn();
            this.IE_TRANSPORTADORA = new System.Data.DataColumn();
            this.DATA_INSCRICAO_TRANSPORTADORA = new System.Data.DataColumn();
            this.TEL_1_TRANSPORTADORA = new System.Data.DataColumn();
            this.TEL_2_TRANSPORTADORA = new System.Data.DataColumn();
            this.CONTATO_1_TRANSPORTADORA = new System.Data.DataColumn();
            this.CONTATO_2_TRANSPORTADORA = new System.Data.DataColumn();
            this.EMAIL_1_TRANSPORTADORA = new System.Data.DataColumn();
            this.EMAIL_2_TRANSPORTADORA = new System.Data.DataColumn();
            this.FONE_TRANSPORTADORA = new System.Data.DataColumn();
            this.EMAIL_TRANSPORTADORA = new System.Data.DataColumn();
            this.IM_TRANSPORTADORA = new System.Data.DataColumn();
            this.dataColumn1 = new System.Data.DataColumn();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.razao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_cod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.datTransportadoras = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.cbTransportadoras = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransportadoras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRANSPORTADORAS)).BeginInit();
            this.SuspendLayout();
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label20.Location = new System.Drawing.Point(164, 9);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(410, 46);
            this.label20.TabIndex = 95;
            this.label20.Text = "TRANSPORTADORA";
            // 
            // apaga_registro
            // 
            this.apaga_registro.Location = new System.Drawing.Point(283, 279);
            this.apaga_registro.Name = "apaga_registro";
            this.apaga_registro.Size = new System.Drawing.Size(49, 22);
            this.apaga_registro.TabIndex = 94;
            this.apaga_registro.Text = "Excluir";
            this.apaga_registro.UseVisualStyleBackColor = true;
            this.apaga_registro.Click += new System.EventHandler(this.apaga_registro_Click);
            // 
            // salva_registro
            // 
            this.salva_registro.Location = new System.Drawing.Point(338, 279);
            this.salva_registro.Name = "salva_registro";
            this.salva_registro.Size = new System.Drawing.Size(49, 22);
            this.salva_registro.TabIndex = 77;
            this.salva_registro.Text = "Salvar";
            this.salva_registro.UseVisualStyleBackColor = true;
            this.salva_registro.Click += new System.EventHandler(this.salva_registro_Click);
            // 
            // vai_anterior
            // 
            this.vai_anterior.Location = new System.Drawing.Point(60, 279);
            this.vai_anterior.Name = "vai_anterior";
            this.vai_anterior.Size = new System.Drawing.Size(49, 22);
            this.vai_anterior.TabIndex = 93;
            this.vai_anterior.Text = "<";
            this.vai_anterior.UseVisualStyleBackColor = true;
            this.vai_anterior.Visible = false;
            this.vai_anterior.Click += new System.EventHandler(this.vai_anterior_Click);
            // 
            // vai_proximo
            // 
            this.vai_proximo.Location = new System.Drawing.Point(117, 279);
            this.vai_proximo.Name = "vai_proximo";
            this.vai_proximo.Size = new System.Drawing.Size(49, 22);
            this.vai_proximo.TabIndex = 92;
            this.vai_proximo.Text = ">";
            this.vai_proximo.UseVisualStyleBackColor = true;
            this.vai_proximo.Visible = false;
            this.vai_proximo.Click += new System.EventHandler(this.vai_proximo_Click);
            // 
            // vai_ultimo
            // 
            this.vai_ultimo.Location = new System.Drawing.Point(172, 279);
            this.vai_ultimo.Name = "vai_ultimo";
            this.vai_ultimo.Size = new System.Drawing.Size(49, 22);
            this.vai_ultimo.TabIndex = 91;
            this.vai_ultimo.Text = ">>";
            this.vai_ultimo.UseVisualStyleBackColor = true;
            this.vai_ultimo.Visible = false;
            this.vai_ultimo.Click += new System.EventHandler(this.vai_ultimo_Click);
            // 
            // novo_registro
            // 
            this.novo_registro.Location = new System.Drawing.Point(228, 279);
            this.novo_registro.Name = "novo_registro";
            this.novo_registro.Size = new System.Drawing.Size(49, 22);
            this.novo_registro.TabIndex = 79;
            this.novo_registro.Text = "Novo";
            this.novo_registro.UseVisualStyleBackColor = true;
            this.novo_registro.Click += new System.EventHandler(this.novo_registro_Click);
            // 
            // vai_primeiro
            // 
            this.vai_primeiro.Location = new System.Drawing.Point(5, 279);
            this.vai_primeiro.Name = "vai_primeiro";
            this.vai_primeiro.Size = new System.Drawing.Size(49, 22);
            this.vai_primeiro.TabIndex = 89;
            this.vai_primeiro.Text = "<<";
            this.vai_primeiro.UseVisualStyleBackColor = true;
            this.vai_primeiro.Visible = false;
            this.vai_primeiro.Click += new System.EventHandler(this.vai_primeiro_Click);
            // 
            // textBox18
            // 
            this.textBox18.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTransportadoras, "TRANSPORTADORAS.EMAIL_2_TRANSPORTADORA", true));
            this.textBox18.Location = new System.Drawing.Point(505, 240);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(172, 20);
            this.textBox18.TabIndex = 76;
            // 
            // dsTransportadoras
            // 
            this.dsTransportadoras.DataSetName = "dsTransportadoras";
            this.dsTransportadoras.Namespace = "http://www.tempuri.org/dsTransportadoras.xsd";
            this.dsTransportadoras.Tables.AddRange(new System.Data.DataTable[] {
            this.TRANSPORTADORAS});
            // 
            // TRANSPORTADORAS
            // 
            this.TRANSPORTADORAS.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_TRANSPORTADORA,
            this.NOME_TRANSPORTADORA,
            this.RAZAO_SOCIAL_TRANSPORTADORA,
            this.ENDERECO_TRANSPORTADORA,
            this.BAIRRO_TRANSPORTADORA,
            this.CIDADE_TRANSPORTADORA,
            this.ESTADO_TRANSPORTADORA,
            this.PAIS_TRANSPORTADORA,
            this.CNPJ_TRANSPORTADORA,
            this.IE_TRANSPORTADORA,
            this.DATA_INSCRICAO_TRANSPORTADORA,
            this.TEL_1_TRANSPORTADORA,
            this.TEL_2_TRANSPORTADORA,
            this.CONTATO_1_TRANSPORTADORA,
            this.CONTATO_2_TRANSPORTADORA,
            this.EMAIL_1_TRANSPORTADORA,
            this.EMAIL_2_TRANSPORTADORA,
            this.FONE_TRANSPORTADORA,
            this.EMAIL_TRANSPORTADORA,
            this.IM_TRANSPORTADORA,
            this.dataColumn1});
            this.TRANSPORTADORAS.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_TRANSPORTADORA"}, true)});
            this.TRANSPORTADORAS.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_TRANSPORTADORA};
            this.TRANSPORTADORAS.TableName = "TRANSPORTADORAS";
            // 
            // COD_TRANSPORTADORA
            // 
            this.COD_TRANSPORTADORA.AllowDBNull = false;
            this.COD_TRANSPORTADORA.ColumnName = "COD_TRANSPORTADORA";
            this.COD_TRANSPORTADORA.DataType = typeof(int);
            // 
            // NOME_TRANSPORTADORA
            // 
            this.NOME_TRANSPORTADORA.ColumnName = "NOME_TRANSPORTADORA";
            this.NOME_TRANSPORTADORA.MaxLength = 60;
            // 
            // RAZAO_SOCIAL_TRANSPORTADORA
            // 
            this.RAZAO_SOCIAL_TRANSPORTADORA.ColumnName = "RAZAO_SOCIAL_TRANSPORTADORA";
            this.RAZAO_SOCIAL_TRANSPORTADORA.MaxLength = 60;
            // 
            // ENDERECO_TRANSPORTADORA
            // 
            this.ENDERECO_TRANSPORTADORA.ColumnName = "ENDERECO_TRANSPORTADORA";
            this.ENDERECO_TRANSPORTADORA.MaxLength = 60;
            // 
            // BAIRRO_TRANSPORTADORA
            // 
            this.BAIRRO_TRANSPORTADORA.ColumnName = "BAIRRO_TRANSPORTADORA";
            this.BAIRRO_TRANSPORTADORA.MaxLength = 40;
            // 
            // CIDADE_TRANSPORTADORA
            // 
            this.CIDADE_TRANSPORTADORA.ColumnName = "CIDADE_TRANSPORTADORA";
            this.CIDADE_TRANSPORTADORA.MaxLength = 30;
            // 
            // ESTADO_TRANSPORTADORA
            // 
            this.ESTADO_TRANSPORTADORA.ColumnName = "ESTADO_TRANSPORTADORA";
            this.ESTADO_TRANSPORTADORA.MaxLength = 10;
            // 
            // PAIS_TRANSPORTADORA
            // 
            this.PAIS_TRANSPORTADORA.ColumnName = "PAIS_TRANSPORTADORA";
            this.PAIS_TRANSPORTADORA.MaxLength = 40;
            // 
            // CNPJ_TRANSPORTADORA
            // 
            this.CNPJ_TRANSPORTADORA.ColumnName = "CNPJ_TRANSPORTADORA";
            this.CNPJ_TRANSPORTADORA.MaxLength = 25;
            // 
            // IE_TRANSPORTADORA
            // 
            this.IE_TRANSPORTADORA.ColumnName = "IE_TRANSPORTADORA";
            this.IE_TRANSPORTADORA.MaxLength = 25;
            // 
            // DATA_INSCRICAO_TRANSPORTADORA
            // 
            this.DATA_INSCRICAO_TRANSPORTADORA.ColumnName = "DATA_INSCRICAO_TRANSPORTADORA";
            this.DATA_INSCRICAO_TRANSPORTADORA.DataType = typeof(System.DateTime);
            // 
            // TEL_1_TRANSPORTADORA
            // 
            this.TEL_1_TRANSPORTADORA.ColumnName = "TEL_1_TRANSPORTADORA";
            this.TEL_1_TRANSPORTADORA.MaxLength = 20;
            // 
            // TEL_2_TRANSPORTADORA
            // 
            this.TEL_2_TRANSPORTADORA.ColumnName = "TEL_2_TRANSPORTADORA";
            this.TEL_2_TRANSPORTADORA.MaxLength = 20;
            // 
            // CONTATO_1_TRANSPORTADORA
            // 
            this.CONTATO_1_TRANSPORTADORA.ColumnName = "CONTATO_1_TRANSPORTADORA";
            this.CONTATO_1_TRANSPORTADORA.MaxLength = 20;
            // 
            // CONTATO_2_TRANSPORTADORA
            // 
            this.CONTATO_2_TRANSPORTADORA.ColumnName = "CONTATO_2_TRANSPORTADORA";
            this.CONTATO_2_TRANSPORTADORA.MaxLength = 20;
            // 
            // EMAIL_1_TRANSPORTADORA
            // 
            this.EMAIL_1_TRANSPORTADORA.ColumnName = "EMAIL_1_TRANSPORTADORA";
            this.EMAIL_1_TRANSPORTADORA.MaxLength = 40;
            // 
            // EMAIL_2_TRANSPORTADORA
            // 
            this.EMAIL_2_TRANSPORTADORA.ColumnName = "EMAIL_2_TRANSPORTADORA";
            this.EMAIL_2_TRANSPORTADORA.MaxLength = 40;
            // 
            // FONE_TRANSPORTADORA
            // 
            this.FONE_TRANSPORTADORA.ColumnName = "FONE_TRANSPORTADORA";
            this.FONE_TRANSPORTADORA.MaxLength = 100;
            // 
            // EMAIL_TRANSPORTADORA
            // 
            this.EMAIL_TRANSPORTADORA.ColumnName = "EMAIL_TRANSPORTADORA";
            this.EMAIL_TRANSPORTADORA.MaxLength = 100;
            // 
            // IM_TRANSPORTADORA
            // 
            this.IM_TRANSPORTADORA.ColumnName = "IM_TRANSPORTADORA";
            this.IM_TRANSPORTADORA.MaxLength = 20;
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "SITUACAO_TRANSPORTADORA";
            this.dataColumn1.DataType = typeof(int);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(456, 243);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 13);
            this.label18.TabIndex = 87;
            this.label18.Text = "Email 2:";
            // 
            // textBox19
            // 
            this.textBox19.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTransportadoras, "TRANSPORTADORAS.TEL_2_TRANSPORTADORA", true));
            this.textBox19.Location = new System.Drawing.Point(327, 240);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(113, 20);
            this.textBox19.TabIndex = 74;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(237, 243);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(43, 13);
            this.label19.TabIndex = 86;
            this.label19.Text = "Fone 2:";
            // 
            // textBox14
            // 
            this.textBox14.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTransportadoras, "TRANSPORTADORAS.EMAIL_1_TRANSPORTADORA", true));
            this.textBox14.Location = new System.Drawing.Point(505, 214);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(172, 20);
            this.textBox14.TabIndex = 71;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(456, 217);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 84;
            this.label14.Text = "Email 1:";
            // 
            // textBox15
            // 
            this.textBox15.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTransportadoras, "TRANSPORTADORAS.TEL_1_TRANSPORTADORA", true));
            this.textBox15.Location = new System.Drawing.Point(327, 214);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(113, 20);
            this.textBox15.TabIndex = 70;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(237, 217);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 13);
            this.label15.TabIndex = 82;
            this.label15.Text = "Fone 1:";
            // 
            // textBox13
            // 
            this.textBox13.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTransportadoras, "TRANSPORTADORAS.EMAIL_TRANSPORTADORA", true));
            this.textBox13.Location = new System.Drawing.Point(327, 185);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(172, 20);
            this.textBox13.TabIndex = 66;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(237, 188);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 81;
            this.label13.Text = "Email:";
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTransportadoras, "TRANSPORTADORAS.FONE_TRANSPORTADORA", true));
            this.textBox7.Location = new System.Drawing.Point(108, 185);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(113, 20);
            this.textBox7.TabIndex = 65;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 80;
            this.label7.Text = "Fone:";
            // 
            // textBox8
            // 
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTransportadoras, "TRANSPORTADORAS.PAIS_TRANSPORTADORA", true));
            this.textBox8.Location = new System.Drawing.Point(507, 159);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(114, 20);
            this.textBox8.TabIndex = 63;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(417, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 78;
            this.label8.Text = "País:";
            // 
            // textBox9
            // 
            this.textBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTransportadoras, "TRANSPORTADORAS.ESTADO_TRANSPORTADORA", true));
            this.textBox9.Location = new System.Drawing.Point(355, 159);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(31, 20);
            this.textBox9.TabIndex = 62;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(279, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 75;
            this.label9.Text = "Estado:";
            // 
            // textBox10
            // 
            this.textBox10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTransportadoras, "TRANSPORTADORAS.CIDADE_TRANSPORTADORA", true));
            this.textBox10.Location = new System.Drawing.Point(107, 159);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(149, 20);
            this.textBox10.TabIndex = 60;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 162);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 72;
            this.label10.Text = "Cidade:";
            // 
            // textBox11
            // 
            this.textBox11.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTransportadoras, "TRANSPORTADORAS.BAIRRO_TRANSPORTADORA", true));
            this.textBox11.Location = new System.Drawing.Point(507, 133);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(114, 20);
            this.textBox11.TabIndex = 59;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(417, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 69;
            this.label11.Text = "Bairro:";
            // 
            // textBox12
            // 
            this.textBox12.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTransportadoras, "TRANSPORTADORAS.ENDERECO_TRANSPORTADORA", true));
            this.textBox12.Location = new System.Drawing.Point(108, 133);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(294, 20);
            this.textBox12.TabIndex = 57;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 136);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 67;
            this.label12.Text = "Endereço:";
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTransportadoras, "TRANSPORTADORAS.IM_TRANSPORTADORA", true));
            this.textBox4.Location = new System.Drawing.Point(440, 107);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(97, 20);
            this.textBox4.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(412, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 64;
            this.label4.Text = "IM:";
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTransportadoras, "TRANSPORTADORAS.IE_TRANSPORTADORA", true));
            this.textBox5.Location = new System.Drawing.Point(275, 107);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(126, 20);
            this.textBox5.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 61;
            this.label5.Text = "IE:";
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTransportadoras, "TRANSPORTADORAS.CNPJ_TRANSPORTADORA", true));
            this.textBox6.Location = new System.Drawing.Point(107, 107);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(136, 20);
            this.textBox6.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 58;
            this.label6.Text = "CNPJ:";
            // 
            // nome
            // 
            this.nome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTransportadoras, "TRANSPORTADORAS.NOME_TRANSPORTADORA", true));
            this.nome.Location = new System.Drawing.Point(476, 81);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(196, 20);
            this.nome.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(389, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "Nome Fantasia:";
            // 
            // razao
            // 
            this.razao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTransportadoras, "TRANSPORTADORAS.RAZAO_SOCIAL_TRANSPORTADORA", true));
            this.razao.Location = new System.Drawing.Point(107, 81);
            this.razao.Name = "razao";
            this.razao.Size = new System.Drawing.Size(265, 20);
            this.razao.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Razão Social:";
            // 
            // tb_cod
            // 
            this.tb_cod.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTransportadoras, "TRANSPORTADORAS.COD_TRANSPORTADORA", true));
            this.tb_cod.Location = new System.Drawing.Point(169, 55);
            this.tb_cod.Name = "tb_cod";
            this.tb_cod.Size = new System.Drawing.Size(52, 20);
            this.tb_cod.TabIndex = 83;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Código da Transportadora:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsTransportadoras, "TRANSPORTADORAS.SITUACAO_TRANSPORTADORA", true));
            this.checkBox1.Location = new System.Drawing.Point(62, 24);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(50, 17);
            this.checkBox1.TabIndex = 96;
            this.checkBox1.Text = "Ativa";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(18, 214);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 13);
            this.label16.TabIndex = 85;
            this.label16.Text = "Contato 1:";
            // 
            // textBox16
            // 
            this.textBox16.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTransportadoras, "TRANSPORTADORAS.CONTATO_1_TRANSPORTADORA", true));
            this.textBox16.Location = new System.Drawing.Point(108, 211);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(113, 20);
            this.textBox16.TabIndex = 68;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(18, 243);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 13);
            this.label17.TabIndex = 88;
            this.label17.Text = "Contato 2:";
            // 
            // textBox17
            // 
            this.textBox17.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTransportadoras, "TRANSPORTADORAS.CONTATO_2_TRANSPORTADORA", true));
            this.textBox17.Location = new System.Drawing.Point(107, 240);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(114, 20);
            this.textBox17.TabIndex = 73;
            // 
            // datTransportadoras
            // 
            this.datTransportadoras.DeleteCommand = this.fbCommand4;
            this.datTransportadoras.InsertCommand = this.fbCommand2;
            this.datTransportadoras.SelectCommand = this.fbCommand1;
            this.datTransportadoras.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * from transportadoras order by cod_transportadora";
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
            // cbTransportadoras
            // 
            this.cbTransportadoras.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbTransportadoras.DataAdapter = this.datTransportadoras;
            this.cbTransportadoras.QuotePrefix = "\"";
            this.cbTransportadoras.QuoteSuffix = "\"";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(393, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 22);
            this.button1.TabIndex = 97;
            this.button1.Text = "Localizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // form_transportadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 313);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.apaga_registro);
            this.Controls.Add(this.salva_registro);
            this.Controls.Add(this.vai_anterior);
            this.Controls.Add(this.vai_proximo);
            this.Controls.Add(this.vai_ultimo);
            this.Controls.Add(this.novo_registro);
            this.Controls.Add(this.vai_primeiro);
            this.Controls.Add(this.textBox17);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.textBox18);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.textBox19);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.textBox16);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.razao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_cod);
            this.Controls.Add(this.label1);
            this.Name = "form_transportadora";
            this.Text = "Transportadoras";
            this.Load += new System.EventHandler(this.form_transportadora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsTransportadoras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRANSPORTADORAS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button apaga_registro;
        private System.Windows.Forms.Button salva_registro;
        private System.Windows.Forms.Button vai_anterior;
        private System.Windows.Forms.Button vai_proximo;
        private System.Windows.Forms.Button vai_ultimo;
        private System.Windows.Forms.Button novo_registro;
        private System.Windows.Forms.Button vai_primeiro;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox razao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_cod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox17;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datTransportadoras;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Data.DataSet dsTransportadoras;
        private System.Data.DataTable TRANSPORTADORAS;
        private System.Data.DataColumn COD_TRANSPORTADORA;
        private System.Data.DataColumn NOME_TRANSPORTADORA;
        private System.Data.DataColumn RAZAO_SOCIAL_TRANSPORTADORA;
        private System.Data.DataColumn ENDERECO_TRANSPORTADORA;
        private System.Data.DataColumn BAIRRO_TRANSPORTADORA;
        private System.Data.DataColumn CIDADE_TRANSPORTADORA;
        private System.Data.DataColumn ESTADO_TRANSPORTADORA;
        private System.Data.DataColumn PAIS_TRANSPORTADORA;
        private System.Data.DataColumn CNPJ_TRANSPORTADORA;
        private System.Data.DataColumn IE_TRANSPORTADORA;
        private System.Data.DataColumn DATA_INSCRICAO_TRANSPORTADORA;
        private System.Data.DataColumn TEL_1_TRANSPORTADORA;
        private System.Data.DataColumn TEL_2_TRANSPORTADORA;
        private System.Data.DataColumn CONTATO_1_TRANSPORTADORA;
        private System.Data.DataColumn CONTATO_2_TRANSPORTADORA;
        private System.Data.DataColumn EMAIL_1_TRANSPORTADORA;
        private System.Data.DataColumn EMAIL_2_TRANSPORTADORA;
        private System.Data.DataColumn FONE_TRANSPORTADORA;
        private System.Data.DataColumn EMAIL_TRANSPORTADORA;
        private System.Data.DataColumn IM_TRANSPORTADORA;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbTransportadoras;
        private System.Data.DataColumn dataColumn1;
        private System.Windows.Forms.Button button1;
    }
}