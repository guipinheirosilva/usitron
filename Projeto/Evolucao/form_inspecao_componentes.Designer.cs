namespace Evolucao
{
    partial class form_inspecao_componentes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_inspecao_componentes));
            this.label1 = new System.Windows.Forms.Label();
            this.labelOP = new System.Windows.Forms.Label();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.dgvComponentes = new System.Windows.Forms.DataGridView();
            this.tb_cod_componente = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComponentes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "OP:";
            // 
            // labelOP
            // 
            this.labelOP.AutoSize = true;
            this.labelOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOP.Location = new System.Drawing.Point(79, 19);
            this.labelOP.Name = "labelOP";
            this.labelOP.Size = new System.Drawing.Size(22, 31);
            this.labelOP.TabIndex = 1;
            this.labelOP.Text = ".";
            // 
            // fbConnection1
            // 
            this.fbConnection1.ConnectionString = resources.GetString("fbConnection1.ConnectionString");
            // 
            // dgvComponentes
            // 
            this.dgvComponentes.AllowUserToAddRows = false;
            this.dgvComponentes.AllowUserToDeleteRows = false;
            this.dgvComponentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComponentes.Location = new System.Drawing.Point(18, 148);
            this.dgvComponentes.Name = "dgvComponentes";
            this.dgvComponentes.ReadOnly = true;
            this.dgvComponentes.Size = new System.Drawing.Size(741, 386);
            this.dgvComponentes.TabIndex = 2;
            // 
            // tb_cod_componente
            // 
            this.tb_cod_componente.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cod_componente.Location = new System.Drawing.Point(125, 82);
            this.tb_cod_componente.Name = "tb_cod_componente";
            this.tb_cod_componente.Size = new System.Drawing.Size(532, 60);
            this.tb_cod_componente.TabIndex = 3;
            this.tb_cod_componente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_cod_componente_KeyPress);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(286, 540);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(242, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Confirmar retirada";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // form_inspecao_componentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 592);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_cod_componente);
            this.Controls.Add(this.dgvComponentes);
            this.Controls.Add(this.labelOP);
            this.Controls.Add(this.label1);
            this.Name = "form_inspecao_componentes";
            this.Text = "Inspeção de Componentes";
            this.Load += new System.EventHandler(this.form_inspecao_componentes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComponentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelOP;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private System.Windows.Forms.DataGridView dgvComponentes;
        private System.Windows.Forms.TextBox tb_cod_componente;
        private System.Windows.Forms.Button button1;
    }
}