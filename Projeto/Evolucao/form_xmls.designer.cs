namespace Evolucao
{
    partial class form_xmls
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
            this.label3 = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dt_final = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dt_inicial = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Email Contador";
            this.label3.Visible = false;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(35, 123);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(218, 20);
            this.tb_email.TabIndex = 12;
            this.tb_email.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Data Final";
            // 
            // dt_final
            // 
            this.dt_final.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_final.Location = new System.Drawing.Point(155, 61);
            this.dt_final.Name = "dt_final";
            this.dt_final.Size = new System.Drawing.Size(98, 20);
            this.dt_final.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Data Inicial";
            // 
            // dt_inicial
            // 
            this.dt_inicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_inicial.Location = new System.Drawing.Point(35, 61);
            this.dt_inicial.Name = "dt_inicial";
            this.dt_inicial.Size = new System.Drawing.Size(98, 20);
            this.dt_inicial.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Gerar Arquivo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(101, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 24);
            this.button2.TabIndex = 14;
            this.button2.Text = "Email";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // form_xmls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dt_final);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dt_inicial);
            this.Controls.Add(this.button1);
            this.Name = "form_xmls";
            this.Text = "form_xmls";
            this.Load += new System.EventHandler(this.form_xmls_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dt_final;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dt_inicial;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button2;
    }
}