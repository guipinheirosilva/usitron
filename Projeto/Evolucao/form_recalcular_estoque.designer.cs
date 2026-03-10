namespace Evolucao
{
    partial class form_recalcular_estoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_recalcular_estoque));
            this.button14 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.SuspendLayout();
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(79, 12);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(108, 56);
            this.button14.TabIndex = 13;
            this.button14.Text = "Recalcular Estoque Produtos";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(4, 74);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(268, 23);
            this.progressBar1.TabIndex = 30;
            // 
            // fbConnection1
            // 
            this.fbConnection1.ConnectionString = resources.GetString("fbConnection1.ConnectionString");
            // 
            // form_recalcular_estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 104);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button14);
            this.Name = "form_recalcular_estoque";
            this.Text = "Recalcular Estoque";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.ProgressBar progressBar1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
    }
}