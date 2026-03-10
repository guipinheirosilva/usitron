namespace Evolucao
{
    partial class form_desconto_pontualidade
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
            this.tb_desconto = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rbDesconto_pontualidade = new System.Windows.Forms.RadioButton();
            this.rbDesconto_valor = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o Desconto:";
            // 
            // tb_desconto
            // 
            this.tb_desconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_desconto.Location = new System.Drawing.Point(12, 25);
            this.tb_desconto.Name = "tb_desconto";
            this.tb_desconto.Size = new System.Drawing.Size(251, 53);
            this.tb_desconto.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbDesconto_pontualidade
            // 
            this.rbDesconto_pontualidade.AutoSize = true;
            this.rbDesconto_pontualidade.Location = new System.Drawing.Point(87, 104);
            this.rbDesconto_pontualidade.Name = "rbDesconto_pontualidade";
            this.rbDesconto_pontualidade.Size = new System.Drawing.Size(135, 17);
            this.rbDesconto_pontualidade.TabIndex = 103;
            this.rbDesconto_pontualidade.TabStop = true;
            this.rbDesconto_pontualidade.Text = "Desconto pontualidade";
            this.rbDesconto_pontualidade.UseVisualStyleBackColor = true;
            // 
            // rbDesconto_valor
            // 
            this.rbDesconto_valor.AutoSize = true;
            this.rbDesconto_valor.Location = new System.Drawing.Point(87, 84);
            this.rbDesconto_valor.Name = "rbDesconto_valor";
            this.rbDesconto_valor.Size = new System.Drawing.Size(112, 17);
            this.rbDesconto_valor.TabIndex = 102;
            this.rbDesconto_valor.TabStop = true;
            this.rbDesconto_valor.Text = "Desconto no valor";
            this.rbDesconto_valor.UseVisualStyleBackColor = true;
            // 
            // form_desconto_pontualidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 164);
            this.Controls.Add(this.rbDesconto_pontualidade);
            this.Controls.Add(this.rbDesconto_valor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_desconto);
            this.Controls.Add(this.label1);
            this.Name = "form_desconto_pontualidade";
            this.Text = "Desconto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_desconto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbDesconto_pontualidade;
        private System.Windows.Forms.RadioButton rbDesconto_valor;
    }
}