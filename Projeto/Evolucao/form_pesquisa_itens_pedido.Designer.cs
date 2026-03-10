namespace Evolucao
{
    partial class form_pesquisa_itens_pedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_pesquisa_itens_pedido));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtFinal = new System.Windows.Forms.DateTimePicker();
            this.dtInicial = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_vendedor = new System.Windows.Forms.TextBox();
            this.tb_cod_vendedor = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.tb_cliente = new System.Windows.Forms.TextBox();
            this.tb_cnpj_cliente = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_descricao_produto = new System.Windows.Forms.TextBox();
            this.tb_cod_produto = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.button6 = new System.Windows.Forms.Button();
            this.tb_nome_tabela_preco = new System.Windows.Forms.TextBox();
            this.label75 = new System.Windows.Forms.Label();
            this.tb_cod_tabela = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvPesquisa = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_qtde_total = new System.Windows.Forms.TextBox();
            this.tb_valor_total = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_comissao_total = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dtFinal);
            this.groupBox2.Controls.Add(this.dtInicial);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(112, 118);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Entre Datas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 298;
            this.label3.Text = "Término:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 297;
            this.label2.Text = "Início:";
            // 
            // dtFinal
            // 
            this.dtFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFinal.Location = new System.Drawing.Point(6, 81);
            this.dtFinal.Name = "dtFinal";
            this.dtFinal.Size = new System.Drawing.Size(97, 20);
            this.dtFinal.TabIndex = 13;
            // 
            // dtInicial
            // 
            this.dtInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicial.Location = new System.Drawing.Point(6, 29);
            this.dtInicial.Name = "dtInicial";
            this.dtInicial.Size = new System.Drawing.Size(97, 20);
            this.dtInicial.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 283;
            this.label10.Text = "Vendedor:";
            // 
            // tb_vendedor
            // 
            this.tb_vendedor.Location = new System.Drawing.Point(138, 7);
            this.tb_vendedor.Name = "tb_vendedor";
            this.tb_vendedor.Size = new System.Drawing.Size(121, 20);
            this.tb_vendedor.TabIndex = 282;
            // 
            // tb_cod_vendedor
            // 
            this.tb_cod_vendedor.Location = new System.Drawing.Point(98, 7);
            this.tb_cod_vendedor.Name = "tb_cod_vendedor";
            this.tb_cod_vendedor.Size = new System.Drawing.Size(34, 20);
            this.tb_cod_vendedor.TabIndex = 281;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(262, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(23, 23);
            this.button4.TabIndex = 280;
            this.button4.Text = "+";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tb_cliente
            // 
            this.tb_cliente.Location = new System.Drawing.Point(223, 33);
            this.tb_cliente.Name = "tb_cliente";
            this.tb_cliente.Size = new System.Drawing.Size(319, 20);
            this.tb_cliente.TabIndex = 286;
            // 
            // tb_cnpj_cliente
            // 
            this.tb_cnpj_cliente.Location = new System.Drawing.Point(98, 33);
            this.tb_cnpj_cliente.Name = "tb_cnpj_cliente";
            this.tb_cnpj_cliente.Size = new System.Drawing.Size(124, 20);
            this.tb_cnpj_cliente.TabIndex = 285;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(548, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 284;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 287;
            this.label8.Text = "Cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 290;
            this.label1.Text = "Produto:";
            // 
            // tb_descricao_produto
            // 
            this.tb_descricao_produto.Location = new System.Drawing.Point(223, 59);
            this.tb_descricao_produto.Name = "tb_descricao_produto";
            this.tb_descricao_produto.Size = new System.Drawing.Size(170, 20);
            this.tb_descricao_produto.TabIndex = 289;
            // 
            // tb_cod_produto
            // 
            this.tb_cod_produto.Location = new System.Drawing.Point(98, 59);
            this.tb_cod_produto.Name = "tb_cod_produto";
            this.tb_cod_produto.Size = new System.Drawing.Size(123, 20);
            this.tb_cod_produto.TabIndex = 288;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(386, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(23, 23);
            this.button2.TabIndex = 291;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // fbConnection1
            // 
            this.fbConnection1.ConnectionString = resources.GetString("fbConnection1.ConnectionString");
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(272, 83);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(23, 23);
            this.button6.TabIndex = 296;
            this.button6.Text = "+";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // tb_nome_tabela_preco
            // 
            this.tb_nome_tabela_preco.Location = new System.Drawing.Point(137, 85);
            this.tb_nome_tabela_preco.Name = "tb_nome_tabela_preco";
            this.tb_nome_tabela_preco.Size = new System.Drawing.Size(129, 20);
            this.tb_nome_tabela_preco.TabIndex = 294;
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Location = new System.Drawing.Point(12, 88);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(79, 13);
            this.label75.TabIndex = 293;
            this.label75.Text = "Tabela Preços:";
            // 
            // tb_cod_tabela
            // 
            this.tb_cod_tabela.Location = new System.Drawing.Point(97, 85);
            this.tb_cod_tabela.Name = "tb_cod_tabela";
            this.tb_cod_tabela.Size = new System.Drawing.Size(34, 20);
            this.tb_cod_tabela.TabIndex = 292;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.tb_nome_tabela_preco);
            this.panel1.Controls.Add(this.label75);
            this.panel1.Controls.Add(this.tb_cod_tabela);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tb_descricao_produto);
            this.panel1.Controls.Add(this.tb_cod_produto);
            this.panel1.Controls.Add(this.tb_cliente);
            this.panel1.Controls.Add(this.tb_cnpj_cliente);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.tb_vendedor);
            this.panel1.Controls.Add(this.tb_cod_vendedor);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Location = new System.Drawing.Point(135, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 118);
            this.panel1.TabIndex = 297;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(758, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 118);
            this.button3.TabIndex = 298;
            this.button3.Text = "Pesquisar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgvPesquisa
            // 
            this.dgvPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesquisa.Location = new System.Drawing.Point(12, 149);
            this.dgvPesquisa.Name = "dgvPesquisa";
            this.dgvPesquisa.Size = new System.Drawing.Size(1156, 486);
            this.dgvPesquisa.TabIndex = 299;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 661);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 300;
            this.label4.Text = "Qtde Total:";
            // 
            // tb_qtde_total
            // 
            this.tb_qtde_total.Location = new System.Drawing.Point(302, 658);
            this.tb_qtde_total.Name = "tb_qtde_total";
            this.tb_qtde_total.Size = new System.Drawing.Size(147, 20);
            this.tb_qtde_total.TabIndex = 301;
            // 
            // tb_valor_total
            // 
            this.tb_valor_total.Location = new System.Drawing.Point(557, 658);
            this.tb_valor_total.Name = "tb_valor_total";
            this.tb_valor_total.Size = new System.Drawing.Size(147, 20);
            this.tb_valor_total.TabIndex = 303;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(489, 661);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 302;
            this.label5.Text = "Valor Total:";
            // 
            // tb_comissao_total
            // 
            this.tb_comissao_total.Location = new System.Drawing.Point(828, 658);
            this.tb_comissao_total.Name = "tb_comissao_total";
            this.tb_comissao_total.Size = new System.Drawing.Size(147, 20);
            this.tb_comissao_total.TabIndex = 305;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(740, 661);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 304;
            this.label6.Text = "Comissão Total:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1004, 649);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(163, 28);
            this.button5.TabIndex = 306;
            this.button5.Text = "Somar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(860, 12);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(85, 117);
            this.button7.TabIndex = 307;
            this.button7.Text = "Imprimir";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // form_pesquisa_itens_pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 710);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.tb_comissao_total);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_valor_total);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_qtde_total);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvPesquisa);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Name = "form_pesquisa_itens_pedido";
            this.Text = "Itens Pedido";
            this.Load += new System.EventHandler(this.form_pesquisa_itens_pedido_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtFinal;
        private System.Windows.Forms.DateTimePicker dtInicial;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_vendedor;
        private System.Windows.Forms.TextBox tb_cod_vendedor;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox tb_cliente;
        private System.Windows.Forms.TextBox tb_cnpj_cliente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_descricao_produto;
        private System.Windows.Forms.TextBox tb_cod_produto;
        private System.Windows.Forms.Button button2;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox tb_nome_tabela_preco;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.TextBox tb_cod_tabela;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgvPesquisa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_qtde_total;
        private System.Windows.Forms.TextBox tb_valor_total;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_comissao_total;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
    }
}