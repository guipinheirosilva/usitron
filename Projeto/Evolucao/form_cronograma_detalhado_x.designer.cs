namespace Evolucao
{
    partial class form_cronograma_detalhado_x
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_cronograma_detalhado_x));
            this.dgvRotas_campo = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_os = new System.Windows.Forms.TextBox();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tb_funcao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvTotais = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRotas_campo)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotais)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRotas_campo
            // 
            this.dgvRotas_campo.AllowUserToAddRows = false;
            this.dgvRotas_campo.AllowUserToDeleteRows = false;
            this.dgvRotas_campo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRotas_campo.Location = new System.Drawing.Point(7, 207);
            this.dgvRotas_campo.Name = "dgvRotas_campo";
            this.dgvRotas_campo.RowHeadersVisible = false;
            this.dgvRotas_campo.Size = new System.Drawing.Size(1365, 443);
            this.dgvRotas_campo.TabIndex = 0;
            this.dgvRotas_campo.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRotas_campo_CellMouseDoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(194, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_os
            // 
            this.tb_os.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_os.Location = new System.Drawing.Point(7, 10);
            this.tb_os.Name = "tb_os";
            this.tb_os.Size = new System.Drawing.Size(181, 47);
            this.tb_os.TabIndex = 2;
            // 
            // fbConnection1
            // 
            this.fbConnection1.ConnectionString = resources.GetString("fbConnection1.ConnectionString");
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1077, 57);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 13);
            this.label15.TabIndex = 290;
            this.label15.Text = "Em andamento";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.GreenYellow;
            this.panel1.Location = new System.Drawing.Point(966, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(14, 18);
            this.panel1.TabIndex = 281;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(986, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 282;
            this.label6.Text = "Finalizado";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Location = new System.Drawing.Point(1162, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(14, 18);
            this.panel2.TabIndex = 283;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1182, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 284;
            this.label5.Text = "Atrasado";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Yellow;
            this.panel3.Location = new System.Drawing.Point(966, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(14, 18);
            this.panel3.TabIndex = 285;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(986, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 286;
            this.label12.Text = "Aguardando";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Green;
            this.panel4.Location = new System.Drawing.Point(1057, 52);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(14, 18);
            this.panel4.TabIndex = 287;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1182, 58);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 288;
            this.label14.Text = "Parada";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Orange;
            this.panel5.Location = new System.Drawing.Point(1162, 52);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(14, 18);
            this.panel5.TabIndex = 289;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel6.Location = new System.Drawing.Point(1058, 14);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(14, 18);
            this.panel6.TabIndex = 291;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1078, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 26);
            this.label7.TabIndex = 292;
            this.label7.Text = "Finalizado \r\nAtrasado";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(225, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(21, 20);
            this.button2.TabIndex = 296;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tb_funcao
            // 
            this.tb_funcao.Location = new System.Drawing.Point(69, 14);
            this.tb_funcao.Name = "tb_funcao";
            this.tb_funcao.Size = new System.Drawing.Size(150, 20);
            this.tb_funcao.TabIndex = 295;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 294;
            this.label1.Text = "Função:";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel7.Controls.Add(this.button4);
            this.panel7.Controls.Add(this.button2);
            this.panel7.Controls.Add(this.tb_funcao);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Location = new System.Drawing.Point(293, 9);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(516, 47);
            this.panel7.TabIndex = 297;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(438, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 41);
            this.button4.TabIndex = 297;
            this.button4.Text = "Limpar Opções";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(815, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(55, 48);
            this.button3.TabIndex = 297;
            this.button3.Tag = "";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgvTotais
            // 
            this.dgvTotais.AllowUserToAddRows = false;
            this.dgvTotais.AllowUserToDeleteRows = false;
            this.dgvTotais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTotais.Location = new System.Drawing.Point(7, 76);
            this.dgvTotais.Name = "dgvTotais";
            this.dgvTotais.RowHeadersVisible = false;
            this.dgvTotais.Size = new System.Drawing.Size(1365, 125);
            this.dgvTotais.TabIndex = 298;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(818, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 299;
            this.label2.Text = "Função";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(879, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 301;
            this.label3.Text = "Posição";
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Location = new System.Drawing.Point(876, 9);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(55, 48);
            this.button5.TabIndex = 300;
            this.button5.Tag = "";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // form_cronograma_detalhado_x
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 662);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvTotais);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_os);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvRotas_campo);
            this.Name = "form_cronograma_detalhado_x";
            this.Text = "Cronograma Detalhado X";
            this.Load += new System.EventHandler(this.form_cronograma_detalhado_x_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRotas_campo)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRotas_campo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_os;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tb_funcao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dgvTotais;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button5;
    }
}