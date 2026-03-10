namespace Evolucao
{
    partial class form_nova_nf_cte
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_chave = new System.Windows.Forms.TextBox();
            this.tb_n_nf = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_qtde_volumes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_peso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_valor_nf = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chave de Acesso:";
            // 
            // tb_chave
            // 
            this.tb_chave.Location = new System.Drawing.Point(15, 25);
            this.tb_chave.Name = "tb_chave";
            this.tb_chave.Size = new System.Drawing.Size(430, 20);
            this.tb_chave.TabIndex = 1;
            // 
            // tb_n_nf
            // 
            this.tb_n_nf.Location = new System.Drawing.Point(15, 64);
            this.tb_n_nf.Name = "tb_n_nf";
            this.tb_n_nf.Size = new System.Drawing.Size(103, 20);
            this.tb_n_nf.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nº NF:";
            // 
            // tb_qtde_volumes
            // 
            this.tb_qtde_volumes.Location = new System.Drawing.Point(124, 64);
            this.tb_qtde_volumes.Name = "tb_qtde_volumes";
            this.tb_qtde_volumes.Size = new System.Drawing.Size(103, 20);
            this.tb_qtde_volumes.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Qtde Volumes:";
            // 
            // tb_peso
            // 
            this.tb_peso.Location = new System.Drawing.Point(233, 64);
            this.tb_peso.Name = "tb_peso";
            this.tb_peso.Size = new System.Drawing.Size(103, 20);
            this.tb_peso.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Peso:";
            // 
            // tb_valor_nf
            // 
            this.tb_valor_nf.Location = new System.Drawing.Point(342, 64);
            this.tb_valor_nf.Name = "tb_valor_nf";
            this.tb_valor_nf.Size = new System.Drawing.Size(103, 20);
            this.tb_valor_nf.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(339, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Valor NF:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(189, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Inserir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // form_nova_nf_cte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 117);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_valor_nf);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_peso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_qtde_volumes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_n_nf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_chave);
            this.Controls.Add(this.label1);
            this.Name = "form_nova_nf_cte";
            this.Text = "Nova NF CTe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_chave;
        private System.Windows.Forms.TextBox tb_n_nf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_qtde_volumes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_peso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_valor_nf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}