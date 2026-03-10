namespace Evolucao
{
    partial class form_importar_pedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_importar_pedidos));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.Pedidos_back = new System.ComponentModel.BackgroundWorker();
            this.Estoque_back = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelProgresso = new System.Windows.Forms.Label();
            this.timerPedidos_importando = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(8, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(279, 46);
            this.button1.TabIndex = 47;
            this.button1.Text = "Importar Pedidos Pendentes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(8, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(279, 58);
            this.button2.TabIndex = 48;
            this.button2.Text = "Exportar Clientes, Produtos e Vendas";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // fbConnection1
            // 
            this.fbConnection1.ConnectionString = resources.GetString("fbConnection1.ConnectionString");
            // 
            // Pedidos_back
            // 
            this.Pedidos_back.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Pedidos_back_DoWork);
            // 
            // Estoque_back
            // 
            this.Estoque_back.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Estoque_back_DoWork);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(8, 171);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(279, 23);
            this.progressBar1.TabIndex = 49;
            // 
            // labelProgresso
            // 
            this.labelProgresso.AutoSize = true;
            this.labelProgresso.Location = new System.Drawing.Point(12, 155);
            this.labelProgresso.Name = "labelProgresso";
            this.labelProgresso.Size = new System.Drawing.Size(54, 13);
            this.labelProgresso.TabIndex = 50;
            this.labelProgresso.Text = "Progresso";
            // 
            // timerPedidos_importando
            // 
            this.timerPedidos_importando.Interval = 2000;
            this.timerPedidos_importando.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // form_importar_pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 206);
            this.Controls.Add(this.labelProgresso);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "form_importar_pedidos";
            this.Text = "Comunicação Nuvem";
            this.Load += new System.EventHandler(this.form_importar_pedidos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private System.ComponentModel.BackgroundWorker Pedidos_back;
        private System.ComponentModel.BackgroundWorker Estoque_back;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labelProgresso;
        private System.Windows.Forms.Timer timerPedidos_importando;
    }
}