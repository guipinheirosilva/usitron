namespace Evolucao
{
    partial class formEstoqueAnalitico
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
            this.btImprimir = new System.Windows.Forms.Button();
            this.dtDataInicial = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtDataFinal = new System.Windows.Forms.DateTimePicker();
            this.gbPesquisa = new System.Windows.Forms.GroupBox();
            this.btBuscarItemEstoque = new System.Windows.Forms.Button();
            this.tbDescricaoItemEstoque = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCodItemEstoque = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbItemEstoque = new System.Windows.Forms.CheckBox();
            this.cbPeriodo = new System.Windows.Forms.CheckBox();
            this.gbPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // btImprimir
            // 
            this.btImprimir.Location = new System.Drawing.Point(149, 114);
            this.btImprimir.Name = "btImprimir";
            this.btImprimir.Size = new System.Drawing.Size(75, 23);
            this.btImprimir.TabIndex = 1;
            this.btImprimir.Text = "&Imprimir";
            this.btImprimir.UseVisualStyleBackColor = true;
            this.btImprimir.Click += new System.EventHandler(this.btImprimir_Click);
            // 
            // dtDataInicial
            // 
            this.dtDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataInicial.Location = new System.Drawing.Point(90, 23);
            this.dtDataInicial.Name = "dtDataInicial";
            this.dtDataInicial.Size = new System.Drawing.Size(83, 20);
            this.dtDataInicial.TabIndex = 2;
            this.dtDataInicial.Value = new System.DateTime(2013, 3, 18, 14, 58, 46, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data Inicial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data Final:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dtDataFinal
            // 
            this.dtDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataFinal.Location = new System.Drawing.Point(269, 23);
            this.dtDataFinal.Name = "dtDataFinal";
            this.dtDataFinal.Size = new System.Drawing.Size(83, 20);
            this.dtDataFinal.TabIndex = 4;
            this.dtDataFinal.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // gbPesquisa
            // 
            this.gbPesquisa.Controls.Add(this.btBuscarItemEstoque);
            this.gbPesquisa.Controls.Add(this.tbDescricaoItemEstoque);
            this.gbPesquisa.Controls.Add(this.label4);
            this.gbPesquisa.Controls.Add(this.tbCodItemEstoque);
            this.gbPesquisa.Controls.Add(this.label3);
            this.gbPesquisa.Controls.Add(this.cbItemEstoque);
            this.gbPesquisa.Controls.Add(this.cbPeriodo);
            this.gbPesquisa.Controls.Add(this.dtDataFinal);
            this.gbPesquisa.Controls.Add(this.label2);
            this.gbPesquisa.Controls.Add(this.label1);
            this.gbPesquisa.Controls.Add(this.dtDataInicial);
            this.gbPesquisa.Location = new System.Drawing.Point(12, 12);
            this.gbPesquisa.Name = "gbPesquisa";
            this.gbPesquisa.Size = new System.Drawing.Size(360, 96);
            this.gbPesquisa.TabIndex = 0;
            this.gbPesquisa.TabStop = false;
            this.gbPesquisa.Text = "Pesquisar por";
            // 
            // btBuscarItemEstoque
            // 
            this.btBuscarItemEstoque.Location = new System.Drawing.Point(323, 56);
            this.btBuscarItemEstoque.Name = "btBuscarItemEstoque";
            this.btBuscarItemEstoque.Size = new System.Drawing.Size(29, 23);
            this.btBuscarItemEstoque.TabIndex = 10;
            this.btBuscarItemEstoque.Text = "+";
            this.btBuscarItemEstoque.UseVisualStyleBackColor = true;
            this.btBuscarItemEstoque.Click += new System.EventHandler(this.btBuscarItemEstoque_Click);
            // 
            // tbDescricaoItemEstoque
            // 
            this.tbDescricaoItemEstoque.Location = new System.Drawing.Point(137, 59);
            this.tbDescricaoItemEstoque.Name = "tbDescricaoItemEstoque";
            this.tbDescricaoItemEstoque.Size = new System.Drawing.Size(180, 20);
            this.tbDescricaoItemEstoque.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Item:";
            // 
            // tbCodItemEstoque
            // 
            this.tbCodItemEstoque.Location = new System.Drawing.Point(56, 58);
            this.tbCodItemEstoque.Name = "tbCodItemEstoque";
            this.tbCodItemEstoque.Size = new System.Drawing.Size(47, 20);
            this.tbCodItemEstoque.TabIndex = 7;
            this.tbCodItemEstoque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCodItemEstoque_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cód:";
            // 
            // cbItemEstoque
            // 
            this.cbItemEstoque.AutoSize = true;
            this.cbItemEstoque.Location = new System.Drawing.Point(6, 61);
            this.cbItemEstoque.Name = "cbItemEstoque";
            this.cbItemEstoque.Size = new System.Drawing.Size(15, 14);
            this.cbItemEstoque.TabIndex = 5;
            this.cbItemEstoque.UseVisualStyleBackColor = true;
            // 
            // cbPeriodo
            // 
            this.cbPeriodo.AutoSize = true;
            this.cbPeriodo.Location = new System.Drawing.Point(6, 26);
            this.cbPeriodo.Name = "cbPeriodo";
            this.cbPeriodo.Size = new System.Drawing.Size(15, 14);
            this.cbPeriodo.TabIndex = 0;
            this.cbPeriodo.UseVisualStyleBackColor = true;
            // 
            // formEstoqueAnalitico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 147);
            this.Controls.Add(this.gbPesquisa);
            this.Controls.Add(this.btImprimir);
            this.Name = "formEstoqueAnalitico";
            this.Text = "Estoque Analítico";
            this.Load += new System.EventHandler(this.formEstoqueAnalitico_Load);
            this.gbPesquisa.ResumeLayout(false);
            this.gbPesquisa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btImprimir;
        private System.Windows.Forms.DateTimePicker dtDataInicial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtDataFinal;
        private System.Windows.Forms.GroupBox gbPesquisa;
        private System.Windows.Forms.CheckBox cbPeriodo;
        private System.Windows.Forms.CheckBox cbItemEstoque;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCodItemEstoque;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btBuscarItemEstoque;
        private System.Windows.Forms.TextBox tbDescricaoItemEstoque;
    }
}