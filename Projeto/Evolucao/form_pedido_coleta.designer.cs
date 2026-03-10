namespace Evolucao
{
    partial class form_pedido_coleta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_pedido_coleta));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_cnpj_emitente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_nome_emitente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb_cod = new System.Windows.Forms.TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.tb_remetente_cnpj = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tb_remetente_nome = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.tb_destinatario_cnpj = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tb_destinatario_nome = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.button21 = new System.Windows.Forms.Button();
            this.tb_tomador_cnpj = new System.Windows.Forms.TextBox();
            this.label50 = new System.Windows.Forms.Label();
            this.tb_tomador_nome = new System.Windows.Forms.TextBox();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.datPedido_coleta = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.dsPedido_coleta = new System.Data.DataSet();
            this.PEDIDO_COLETA = new System.Data.DataTable();
            this.COD_PC = new System.Data.DataColumn();
            this.EMITENTE_PC = new System.Data.DataColumn();
            this.CNPJ_EMITENTE_PC = new System.Data.DataColumn();
            this.REMETENTE_PC = new System.Data.DataColumn();
            this.CNPJ_REMETENTE_PC = new System.Data.DataColumn();
            this.DESTINATARIO_PC = new System.Data.DataColumn();
            this.CNPJ_DESTINATARIO_PC = new System.Data.DataColumn();
            this.TOMADOR_PC = new System.Data.DataColumn();
            this.CNPJ_TOMADOR_PC = new System.Data.DataColumn();
            this.DATA_EMISSAO_PC = new System.Data.DataColumn();
            this.DATA_AGENDADA_RETIRA_PC = new System.Data.DataColumn();
            this.HORA_AGENDADA_RETIRA_PC = new System.Data.DataColumn();
            this.cbPedido_coleta = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.dataColumn1 = new System.Data.DataColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.tb_recebedor_cnpj = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.tb_recebedor_nome = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.tb_expedidor_cnpj = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tb_expedidor_nome = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsPedido_coleta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PEDIDO_COLETA)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.tb_cnpj_emitente);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tb_nome_emitente);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(989, 30);
            this.panel1.TabIndex = 7;
            // 
            // tb_cnpj_emitente
            // 
            this.tb_cnpj_emitente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPedido_coleta, "PEDIDO_COLETA.CNPJ_EMITENTE_PC", true));
            this.tb_cnpj_emitente.Location = new System.Drawing.Point(815, 5);
            this.tb_cnpj_emitente.Name = "tb_cnpj_emitente";
            this.tb_cnpj_emitente.ReadOnly = true;
            this.tb_cnpj_emitente.Size = new System.Drawing.Size(166, 20);
            this.tb_cnpj_emitente.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(776, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "CNPJ:";
            // 
            // tb_nome_emitente
            // 
            this.tb_nome_emitente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPedido_coleta, "PEDIDO_COLETA.EMITENTE_PC", true));
            this.tb_nome_emitente.Location = new System.Drawing.Point(148, 4);
            this.tb_nome_emitente.Name = "tb_nome_emitente";
            this.tb_nome_emitente.ReadOnly = true;
            this.tb_nome_emitente.Size = new System.Drawing.Size(622, 20);
            this.tb_nome_emitente.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Emitente";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.tb_cod);
            this.panel2.Controls.Add(this.label49);
            this.panel2.Controls.Add(this.textBox8);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(392, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(609, 110);
            this.panel2.TabIndex = 8;
            // 
            // tb_cod
            // 
            this.tb_cod.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPedido_coleta, "PEDIDO_COLETA.COD_PC", true));
            this.tb_cod.Location = new System.Drawing.Point(368, 8);
            this.tb_cod.Name = "tb_cod";
            this.tb_cod.ReadOnly = true;
            this.tb_cod.Size = new System.Drawing.Size(74, 20);
            this.tb_cod.TabIndex = 28;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(263, 11);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(29, 13);
            this.label49.TabIndex = 27;
            this.label49.Text = "Cód:";
            // 
            // textBox8
            // 
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPedido_coleta, "PEDIDO_COLETA.DATA_EMISSAO_PC", true));
            this.textBox8.Location = new System.Drawing.Point(368, 33);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(74, 20);
            this.textBox8.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(263, 36);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "Data Emissão:";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(71, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(57, 93);
            this.button4.TabIndex = 5;
            this.button4.Text = "Salvar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(3, 67);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 31);
            this.button3.TabIndex = 4;
            this.button3.Text = "Localizar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(3, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 31);
            this.button2.TabIndex = 3;
            this.button2.Text = "Excluir";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Novo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel8.Controls.Add(this.label22);
            this.panel8.Controls.Add(this.textBox4);
            this.panel8.Location = new System.Drawing.Point(392, 158);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(609, 166);
            this.panel8.TabIndex = 31;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(4, 3);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(113, 20);
            this.label22.TabIndex = 2;
            this.label22.Text = "Observações";
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPedido_coleta, "PEDIDO_COLETA.OBSERVACOES_PC", true));
            this.textBox4.Location = new System.Drawing.Point(4, 23);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(602, 140);
            this.textBox4.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPedido_coleta, "PEDIDO_COLETA.DATA_AGENDADA_RETIRA_PC", true));
            this.textBox1.Location = new System.Drawing.Point(368, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(74, 20);
            this.textBox1.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(263, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Data Agendada:";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPedido_coleta, "PEDIDO_COLETA.HORA_AGENDADA_RETIRA_PC", true));
            this.textBox2.Location = new System.Drawing.Point(368, 85);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(74, 20);
            this.textBox2.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(263, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Hora Agendada:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.tb_remetente_cnpj);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.tb_remetente_nome);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(12, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(374, 52);
            this.panel3.TabIndex = 32;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(108, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(18, 20);
            this.button6.TabIndex = 9;
            this.button6.Text = "+";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // tb_remetente_cnpj
            // 
            this.tb_remetente_cnpj.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPedido_coleta, "PEDIDO_COLETA.CNPJ_REMETENTE_PC", true));
            this.tb_remetente_cnpj.Location = new System.Drawing.Point(209, 4);
            this.tb_remetente_cnpj.Name = "tb_remetente_cnpj";
            this.tb_remetente_cnpj.ReadOnly = true;
            this.tb_remetente_cnpj.Size = new System.Drawing.Size(145, 20);
            this.tb_remetente_cnpj.TabIndex = 8;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(170, 8);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 13);
            this.label16.TabIndex = 7;
            this.label16.Text = "CNPJ:";
            // 
            // tb_remetente_nome
            // 
            this.tb_remetente_nome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPedido_coleta, "PEDIDO_COLETA.REMETENTE_PC", true));
            this.tb_remetente_nome.Location = new System.Drawing.Point(52, 27);
            this.tb_remetente_nome.Name = "tb_remetente_nome";
            this.tb_remetente_nome.ReadOnly = true;
            this.tb_remetente_nome.Size = new System.Drawing.Size(302, 20);
            this.tb_remetente_nome.TabIndex = 6;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(13, 31);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 13);
            this.label17.TabIndex = 5;
            this.label17.Text = "Nome:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Remetente";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel5.Controls.Add(this.button8);
            this.panel5.Controls.Add(this.tb_destinatario_cnpj);
            this.panel5.Controls.Add(this.label18);
            this.panel5.Controls.Add(this.tb_destinatario_nome);
            this.panel5.Controls.Add(this.label19);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(12, 100);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(374, 52);
            this.panel5.TabIndex = 10;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(117, 5);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(18, 20);
            this.button8.TabIndex = 10;
            this.button8.Text = "+";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // tb_destinatario_cnpj
            // 
            this.tb_destinatario_cnpj.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPedido_coleta, "PEDIDO_COLETA.CNPJ_DESTINATARIO_PC", true));
            this.tb_destinatario_cnpj.Location = new System.Drawing.Point(209, 4);
            this.tb_destinatario_cnpj.Name = "tb_destinatario_cnpj";
            this.tb_destinatario_cnpj.ReadOnly = true;
            this.tb_destinatario_cnpj.Size = new System.Drawing.Size(145, 20);
            this.tb_destinatario_cnpj.TabIndex = 8;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(170, 8);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 13);
            this.label18.TabIndex = 7;
            this.label18.Text = "CNPJ:";
            // 
            // tb_destinatario_nome
            // 
            this.tb_destinatario_nome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPedido_coleta, "PEDIDO_COLETA.DESTINATARIO_PC", true));
            this.tb_destinatario_nome.Location = new System.Drawing.Point(52, 27);
            this.tb_destinatario_nome.Name = "tb_destinatario_nome";
            this.tb_destinatario_nome.ReadOnly = true;
            this.tb_destinatario_nome.Size = new System.Drawing.Size(302, 20);
            this.tb_destinatario_nome.TabIndex = 6;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(13, 31);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(38, 13);
            this.label19.TabIndex = 5;
            this.label19.Text = "Nome:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Destinatário";
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel16.Controls.Add(this.button21);
            this.panel16.Controls.Add(this.tb_tomador_cnpj);
            this.panel16.Controls.Add(this.label50);
            this.panel16.Controls.Add(this.tb_tomador_nome);
            this.panel16.Controls.Add(this.label51);
            this.panel16.Controls.Add(this.label52);
            this.panel16.Location = new System.Drawing.Point(12, 272);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(374, 52);
            this.panel16.TabIndex = 39;
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(107, 5);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(18, 20);
            this.button21.TabIndex = 10;
            this.button21.Text = "+";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // tb_tomador_cnpj
            // 
            this.tb_tomador_cnpj.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPedido_coleta, "PEDIDO_COLETA.CNPJ_TOMADOR_PC", true));
            this.tb_tomador_cnpj.Location = new System.Drawing.Point(209, 5);
            this.tb_tomador_cnpj.Name = "tb_tomador_cnpj";
            this.tb_tomador_cnpj.ReadOnly = true;
            this.tb_tomador_cnpj.Size = new System.Drawing.Size(145, 20);
            this.tb_tomador_cnpj.TabIndex = 8;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(170, 9);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(37, 13);
            this.label50.TabIndex = 7;
            this.label50.Text = "CNPJ:";
            // 
            // tb_tomador_nome
            // 
            this.tb_tomador_nome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPedido_coleta, "PEDIDO_COLETA.TOMADOR_PC", true));
            this.tb_tomador_nome.Location = new System.Drawing.Point(52, 27);
            this.tb_tomador_nome.Name = "tb_tomador_nome";
            this.tb_tomador_nome.ReadOnly = true;
            this.tb_tomador_nome.Size = new System.Drawing.Size(302, 20);
            this.tb_tomador_nome.TabIndex = 6;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(13, 31);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(38, 13);
            this.label51.TabIndex = 5;
            this.label51.Text = "Nome:";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.Location = new System.Drawing.Point(4, 4);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(79, 20);
            this.label52.TabIndex = 1;
            this.label52.Text = "Tomador";
            // 
            // datPedido_coleta
            // 
            this.datPedido_coleta.DeleteCommand = this.fbCommand4;
            this.datPedido_coleta.InsertCommand = this.fbCommand2;
            this.datPedido_coleta.SelectCommand = this.fbCommand1;
            this.datPedido_coleta.UpdateCommand = this.fbCommand3;
            // 
            // fbCommand1
            // 
            this.fbCommand1.CommandText = "select * from pedido_coleta";
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
            // fbConnection1
            // 
            this.fbConnection1.ConnectionString = resources.GetString("fbConnection1.ConnectionString");
            // 
            // dsPedido_coleta
            // 
            this.dsPedido_coleta.DataSetName = "dsPedido_coleta";
            this.dsPedido_coleta.Namespace = "http://www.tempuri.org/dsPedido_coleta.xsd";
            this.dsPedido_coleta.Tables.AddRange(new System.Data.DataTable[] {
            this.PEDIDO_COLETA});
            // 
            // PEDIDO_COLETA
            // 
            this.PEDIDO_COLETA.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_PC,
            this.EMITENTE_PC,
            this.CNPJ_EMITENTE_PC,
            this.REMETENTE_PC,
            this.CNPJ_REMETENTE_PC,
            this.DESTINATARIO_PC,
            this.CNPJ_DESTINATARIO_PC,
            this.TOMADOR_PC,
            this.CNPJ_TOMADOR_PC,
            this.DATA_EMISSAO_PC,
            this.DATA_AGENDADA_RETIRA_PC,
            this.HORA_AGENDADA_RETIRA_PC,
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5});
            this.PEDIDO_COLETA.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_PC"}, true)});
            this.PEDIDO_COLETA.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_PC};
            this.PEDIDO_COLETA.TableName = "PEDIDO_COLETA";
            // 
            // COD_PC
            // 
            this.COD_PC.AllowDBNull = false;
            this.COD_PC.ColumnName = "COD_PC";
            this.COD_PC.DataType = typeof(int);
            // 
            // EMITENTE_PC
            // 
            this.EMITENTE_PC.ColumnName = "EMITENTE_PC";
            this.EMITENTE_PC.MaxLength = 200;
            // 
            // CNPJ_EMITENTE_PC
            // 
            this.CNPJ_EMITENTE_PC.ColumnName = "CNPJ_EMITENTE_PC";
            this.CNPJ_EMITENTE_PC.MaxLength = 20;
            // 
            // REMETENTE_PC
            // 
            this.REMETENTE_PC.ColumnName = "REMETENTE_PC";
            this.REMETENTE_PC.MaxLength = 200;
            // 
            // CNPJ_REMETENTE_PC
            // 
            this.CNPJ_REMETENTE_PC.ColumnName = "CNPJ_REMETENTE_PC";
            this.CNPJ_REMETENTE_PC.MaxLength = 20;
            // 
            // DESTINATARIO_PC
            // 
            this.DESTINATARIO_PC.ColumnName = "DESTINATARIO_PC";
            this.DESTINATARIO_PC.MaxLength = 200;
            // 
            // CNPJ_DESTINATARIO_PC
            // 
            this.CNPJ_DESTINATARIO_PC.ColumnName = "CNPJ_DESTINATARIO_PC";
            this.CNPJ_DESTINATARIO_PC.MaxLength = 20;
            // 
            // TOMADOR_PC
            // 
            this.TOMADOR_PC.ColumnName = "TOMADOR_PC";
            this.TOMADOR_PC.MaxLength = 200;
            // 
            // CNPJ_TOMADOR_PC
            // 
            this.CNPJ_TOMADOR_PC.ColumnName = "CNPJ_TOMADOR_PC";
            this.CNPJ_TOMADOR_PC.MaxLength = 20;
            // 
            // DATA_EMISSAO_PC
            // 
            this.DATA_EMISSAO_PC.ColumnName = "DATA_EMISSAO_PC";
            this.DATA_EMISSAO_PC.DataType = typeof(System.DateTime);
            // 
            // DATA_AGENDADA_RETIRA_PC
            // 
            this.DATA_AGENDADA_RETIRA_PC.ColumnName = "DATA_AGENDADA_RETIRA_PC";
            this.DATA_AGENDADA_RETIRA_PC.DataType = typeof(System.DateTime);
            // 
            // HORA_AGENDADA_RETIRA_PC
            // 
            this.HORA_AGENDADA_RETIRA_PC.ColumnName = "HORA_AGENDADA_RETIRA_PC";
            this.HORA_AGENDADA_RETIRA_PC.DataType = typeof(System.DateTime);
            // 
            // cbPedido_coleta
            // 
            this.cbPedido_coleta.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbPedido_coleta.DataAdapter = this.datPedido_coleta;
            this.cbPedido_coleta.QuotePrefix = "\"";
            this.cbPedido_coleta.QuoteSuffix = "\"";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "OBSERVACOES_PC";
            this.dataColumn1.MaxLength = 2000;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel6.Controls.Add(this.button10);
            this.panel6.Controls.Add(this.tb_recebedor_cnpj);
            this.panel6.Controls.Add(this.label23);
            this.panel6.Controls.Add(this.tb_recebedor_nome);
            this.panel6.Controls.Add(this.label24);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Location = new System.Drawing.Point(12, 216);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(374, 52);
            this.panel6.TabIndex = 41;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(107, 5);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(18, 20);
            this.button10.TabIndex = 10;
            this.button10.Text = "+";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // tb_recebedor_cnpj
            // 
            this.tb_recebedor_cnpj.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPedido_coleta, "PEDIDO_COLETA.CNPJ_RECEBEDOR_PC", true));
            this.tb_recebedor_cnpj.Location = new System.Drawing.Point(209, 5);
            this.tb_recebedor_cnpj.Name = "tb_recebedor_cnpj";
            this.tb_recebedor_cnpj.ReadOnly = true;
            this.tb_recebedor_cnpj.Size = new System.Drawing.Size(145, 20);
            this.tb_recebedor_cnpj.TabIndex = 8;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(170, 9);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(37, 13);
            this.label23.TabIndex = 7;
            this.label23.Text = "CNPJ:";
            // 
            // tb_recebedor_nome
            // 
            this.tb_recebedor_nome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPedido_coleta, "PEDIDO_COLETA.RECEBEDOR_PC", true));
            this.tb_recebedor_nome.Location = new System.Drawing.Point(52, 27);
            this.tb_recebedor_nome.Name = "tb_recebedor_nome";
            this.tb_recebedor_nome.ReadOnly = true;
            this.tb_recebedor_nome.Size = new System.Drawing.Size(302, 20);
            this.tb_recebedor_nome.TabIndex = 6;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(13, 31);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(38, 13);
            this.label24.TabIndex = 5;
            this.label24.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Recebedor";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel7.Controls.Add(this.button9);
            this.panel7.Controls.Add(this.tb_expedidor_cnpj);
            this.panel7.Controls.Add(this.label20);
            this.panel7.Controls.Add(this.tb_expedidor_nome);
            this.panel7.Controls.Add(this.label21);
            this.panel7.Controls.Add(this.label9);
            this.panel7.Location = new System.Drawing.Point(12, 158);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(374, 52);
            this.panel7.TabIndex = 40;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(99, 5);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(18, 20);
            this.button9.TabIndex = 10;
            this.button9.Text = "+";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // tb_expedidor_cnpj
            // 
            this.tb_expedidor_cnpj.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPedido_coleta, "PEDIDO_COLETA.CNPJ_EXPEDIDOR_PC", true));
            this.tb_expedidor_cnpj.Location = new System.Drawing.Point(209, 4);
            this.tb_expedidor_cnpj.Name = "tb_expedidor_cnpj";
            this.tb_expedidor_cnpj.ReadOnly = true;
            this.tb_expedidor_cnpj.Size = new System.Drawing.Size(145, 20);
            this.tb_expedidor_cnpj.TabIndex = 8;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(170, 8);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(37, 13);
            this.label20.TabIndex = 7;
            this.label20.Text = "CNPJ:";
            // 
            // tb_expedidor_nome
            // 
            this.tb_expedidor_nome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPedido_coleta, "PEDIDO_COLETA.EXPEDIDOR_PC", true));
            this.tb_expedidor_nome.Location = new System.Drawing.Point(52, 27);
            this.tb_expedidor_nome.Name = "tb_expedidor_nome";
            this.tb_expedidor_nome.ReadOnly = true;
            this.tb_expedidor_nome.Size = new System.Drawing.Size(302, 20);
            this.tb_expedidor_nome.TabIndex = 6;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(13, 31);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(38, 13);
            this.label21.TabIndex = 5;
            this.label21.Text = "Nome:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Expedidor";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "EXPEDIDOR_PC";
            this.dataColumn2.MaxLength = 200;
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "CNPJ_EXPEDIDOR_PC";
            this.dataColumn3.MaxLength = 20;
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "RECEBEDOR_PC";
            this.dataColumn4.MaxLength = 200;
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "CNPJ_RECEBEDOR_PC";
            this.dataColumn5.MaxLength = 20;
            // 
            // form_pedido_coleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 336);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel16);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "form_pedido_coleta";
            this.Text = "Pedido Coleta";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsPedido_coleta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PEDIDO_COLETA)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_cnpj_emitente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_nome_emitente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tb_cod;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox tb_remetente_cnpj;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tb_remetente_nome;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox tb_destinatario_cnpj;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tb_destinatario_nome;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.TextBox tb_tomador_cnpj;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.TextBox tb_tomador_nome;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label52;
        private System.Data.DataSet dsPedido_coleta;
        private System.Data.DataTable PEDIDO_COLETA;
        private System.Data.DataColumn COD_PC;
        private System.Data.DataColumn EMITENTE_PC;
        private System.Data.DataColumn CNPJ_EMITENTE_PC;
        private System.Data.DataColumn REMETENTE_PC;
        private System.Data.DataColumn CNPJ_REMETENTE_PC;
        private System.Data.DataColumn DESTINATARIO_PC;
        private System.Data.DataColumn CNPJ_DESTINATARIO_PC;
        private System.Data.DataColumn TOMADOR_PC;
        private System.Data.DataColumn CNPJ_TOMADOR_PC;
        private System.Data.DataColumn DATA_EMISSAO_PC;
        private System.Data.DataColumn DATA_AGENDADA_RETIRA_PC;
        private System.Data.DataColumn HORA_AGENDADA_RETIRA_PC;
        private System.Data.DataColumn dataColumn1;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datPedido_coleta;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbPedido_coleta;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox tb_recebedor_cnpj;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox tb_recebedor_nome;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox tb_expedidor_cnpj;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tb_expedidor_nome;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label9;
    }
}