namespace Evolucao
{
    partial class form_vendedor_comissao
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
            this.label69 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.tb_comissao = new System.Windows.Forms.TextBox();
            this.button14 = new System.Windows.Forms.Button();
            this.txtNomeVendedor = new System.Windows.Forms.TextBox();
            this.txtCodVendedor = new System.Windows.Forms.TextBox();
            this.label70 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(14, 12);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(60, 13);
            this.label69.TabIndex = 33;
            this.label69.Text = "Cód. Vend:";
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(14, 58);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(69, 13);
            this.label68.TabIndex = 32;
            this.label68.Text = "%. Comissão:";
            // 
            // tb_comissao
            // 
            this.tb_comissao.Location = new System.Drawing.Point(103, 55);
            this.tb_comissao.Name = "tb_comissao";
            this.tb_comissao.Size = new System.Drawing.Size(69, 20);
            this.tb_comissao.TabIndex = 31;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(354, 26);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(23, 23);
            this.button14.TabIndex = 30;
            this.button14.Text = "+";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // txtNomeVendedor
            // 
            this.txtNomeVendedor.Location = new System.Drawing.Point(81, 28);
            this.txtNomeVendedor.Name = "txtNomeVendedor";
            this.txtNomeVendedor.ReadOnly = true;
            this.txtNomeVendedor.Size = new System.Drawing.Size(267, 20);
            this.txtNomeVendedor.TabIndex = 28;
            // 
            // txtCodVendedor
            // 
            this.txtCodVendedor.Location = new System.Drawing.Point(14, 28);
            this.txtCodVendedor.Name = "txtCodVendedor";
            this.txtCodVendedor.ReadOnly = true;
            this.txtCodVendedor.Size = new System.Drawing.Size(61, 20);
            this.txtCodVendedor.TabIndex = 27;
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(86, 12);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(84, 13);
            this.label70.TabIndex = 34;
            this.label70.Text = "Nome Vendedor";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(302, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 35;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // form_vendedor_comissao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 89);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label70);
            this.Controls.Add(this.label69);
            this.Controls.Add(this.label68);
            this.Controls.Add(this.tb_comissao);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.txtNomeVendedor);
            this.Controls.Add(this.txtCodVendedor);
            this.Name = "form_vendedor_comissao";
            this.Text = "Selecione o Vendedor e a comissão";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.TextBox tb_comissao;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.TextBox txtNomeVendedor;
        private System.Windows.Forms.TextBox txtCodVendedor;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.Button button1;
    }
}