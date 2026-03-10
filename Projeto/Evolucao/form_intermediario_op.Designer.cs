namespace Evolucao
{
    partial class form_intermediario_op
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_intermediario_op));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbUrgente = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_op_suficiente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.col_selecionado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_cod_cliente = new System.Windows.Forms.TextBox();
            this.tb_pedido = new System.Windows.Forms.TextBox();
            this.tb_descricao = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.cbUrgente);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tb_op_suficiente);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.dgvProdutos);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tb_cod_cliente);
            this.panel1.Controls.Add(this.tb_pedido);
            this.panel1.Controls.Add(this.tb_descricao);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1557, 734);
            this.panel1.TabIndex = 2;
            // 
            // cbUrgente
            // 
            this.cbUrgente.AutoSize = true;
            this.cbUrgente.Location = new System.Drawing.Point(1023, 39);
            this.cbUrgente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbUrgente.Name = "cbUrgente";
            this.cbUrgente.Size = new System.Drawing.Size(81, 38);
            this.cbUrgente.TabIndex = 26;
            this.cbUrgente.Text = "OP\r\nUrgente";
            this.cbUrgente.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1395, 7);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 34);
            this.label7.TabIndex = 25;
            this.label7.Text = "OP Suficiente\r\n*Marcar 1 para estoque";
            this.label7.Visible = false;
            // 
            // tb_op_suficiente
            // 
            this.tb_op_suficiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_op_suficiente.Location = new System.Drawing.Point(1399, 46);
            this.tb_op_suficiente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_op_suficiente.Name = "tb_op_suficiente";
            this.tb_op_suficiente.Size = new System.Drawing.Size(73, 34);
            this.tb_op_suficiente.TabIndex = 24;
            this.tb_op_suficiente.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(268, 60);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Descrição";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 60);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Cód. Produto";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button8.Location = new System.Drawing.Point(1116, 28);
            this.button8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(275, 53);
            this.button8.TabIndex = 20;
            this.button8.Text = "Marcar como Produção Não Necessária";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Visible = false;
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_selecionado});
            this.dgvProdutos.Location = new System.Drawing.Point(11, 89);
            this.dgvProdutos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(1525, 626);
            this.dgvProdutos.TabIndex = 19;
            // 
            // col_selecionado
            // 
            this.col_selecionado.HeaderText = "OK";
            this.col_selecionado.Name = "col_selecionado";
            this.col_selecionado.Width = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 34);
            this.label3.TabIndex = 18;
            this.label3.Text = "Cód. Pedido\r\n Interno:";
            // 
            // tb_cod_cliente
            // 
            this.tb_cod_cliente.Location = new System.Drawing.Point(111, 57);
            this.tb_cod_cliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_cod_cliente.Name = "tb_cod_cliente";
            this.tb_cod_cliente.Size = new System.Drawing.Size(139, 22);
            this.tb_cod_cliente.TabIndex = 3;
            this.tb_cod_cliente.TextChanged += new System.EventHandler(this.tb_cod_cliente_TextChanged);
            // 
            // tb_pedido
            // 
            this.tb_pedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_pedido.Location = new System.Drawing.Point(111, 28);
            this.tb_pedido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_pedido.Name = "tb_pedido";
            this.tb_pedido.Size = new System.Drawing.Size(139, 23);
            this.tb_pedido.TabIndex = 4;
            this.tb_pedido.TextChanged += new System.EventHandler(this.tb_pedido_TextChanged);
            // 
            // tb_descricao
            // 
            this.tb_descricao.Location = new System.Drawing.Point(349, 57);
            this.tb_descricao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_descricao.Name = "tb_descricao";
            this.tb_descricao.Size = new System.Drawing.Size(337, 22);
            this.tb_descricao.TabIndex = 2;
            this.tb_descricao.TextChanged += new System.EventHandler(this.tb_descricao_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(745, 28);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(275, 53);
            this.button1.TabIndex = 3;
            this.button1.Text = "Crias OPs Selecionadas>>>";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fbConnection1
            // 
            this.fbConnection1.ConnectionString = resources.GetString("fbConnection1.ConnectionString");
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(530, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 34);
            this.button2.TabIndex = 27;
            this.button2.Text = "Marcar Todas Ops";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // form_intermediario_op
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1585, 763);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "form_intermediario_op";
            this.Text = "Explosão Intermediária";
            this.Load += new System.EventHandler(this.form_intermediario_op_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbUrgente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_op_suficiente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_selecionado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_cod_cliente;
        private System.Windows.Forms.TextBox tb_pedido;
        private System.Windows.Forms.TextBox tb_descricao;
        private System.Windows.Forms.Button button1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private System.Windows.Forms.Button button2;
    }
}