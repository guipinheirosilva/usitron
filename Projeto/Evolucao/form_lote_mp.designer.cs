namespace Evolucao
{
    partial class form_lote_mp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_lote_mp));
            this.datLote_recebimento = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.cbLote_recebimento = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.tb_cod_lote = new System.Windows.Forms.TextBox();
            this.dsLote_recebimento = new System.Data.DataSet();
            this.LOTE_RECEBIMENTO = new System.Data.DataTable();
            this.COD_LR = new System.Data.DataColumn();
            this.COD_PRODUTO_LR = new System.Data.DataColumn();
            this.DESCRICAO_LR = new System.Data.DataColumn();
            this.DIMENSOES_LR = new System.Data.DataColumn();
            this.MATERIAL_LR = new System.Data.DataColumn();
            this.CLIENTE_LR = new System.Data.DataColumn();
            this.CNPJ_CLIENTE_LR = new System.Data.DataColumn();
            this.RASTREAMENTO_LR = new System.Data.DataColumn();
            this.QTDE_LR = new System.Data.DataColumn();
            this.DATA_LIBERACAO_LR = new System.Data.DataColumn();
            this.NOTA_FISCAL_LR = new System.Data.DataColumn();
            this.dataColumn1 = new System.Data.DataColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_rastreamento = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_qtde = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dsLote_recebimento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LOTE_RECEBIMENTO)).BeginInit();
            this.SuspendLayout();
            // 
            // datLote_recebimento
            // 
            this.datLote_recebimento.DeleteCommand = this.fbCommand4;
            this.datLote_recebimento.InsertCommand = this.fbCommand2;
            this.datLote_recebimento.SelectCommand = this.fbCommand1;
            this.datLote_recebimento.UpdateCommand = this.fbCommand3;
            // 
            // fbCommand4
            // 
            this.fbCommand4.CommandTimeout = 30;
            // 
            // fbCommand2
            // 
            this.fbCommand2.CommandTimeout = 30;
            // 
            // fbCommand1
            // 
            this.fbCommand1.CommandText = "select * from lote_recebimento";
            this.fbCommand1.CommandTimeout = 30;
            this.fbCommand1.Connection = this.fbConnection1;
            // 
            // fbConnection1
            // 
            this.fbConnection1.ConnectionString = resources.GetString("fbConnection1.ConnectionString");
            // 
            // fbCommand3
            // 
            this.fbCommand3.CommandTimeout = 30;
            // 
            // cbLote_recebimento
            // 
            this.cbLote_recebimento.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbLote_recebimento.DataAdapter = this.datLote_recebimento;
            this.cbLote_recebimento.QuotePrefix = "\"";
            this.cbLote_recebimento.QuoteSuffix = "\"";
            // 
            // tb_cod_lote
            // 
            this.tb_cod_lote.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsLote_recebimento, "LOTE_RECEBIMENTO.COD_LR", true));
            this.tb_cod_lote.Location = new System.Drawing.Point(117, 9);
            this.tb_cod_lote.Name = "tb_cod_lote";
            this.tb_cod_lote.ReadOnly = true;
            this.tb_cod_lote.Size = new System.Drawing.Size(52, 20);
            this.tb_cod_lote.TabIndex = 0;
            // 
            // dsLote_recebimento
            // 
            this.dsLote_recebimento.DataSetName = "dsLote_recebimento";
            this.dsLote_recebimento.Namespace = "http://www.tempuri.org/dsLote_recebimento.xsd";
            this.dsLote_recebimento.Tables.AddRange(new System.Data.DataTable[] {
            this.LOTE_RECEBIMENTO});
            // 
            // LOTE_RECEBIMENTO
            // 
            this.LOTE_RECEBIMENTO.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_LR,
            this.COD_PRODUTO_LR,
            this.DESCRICAO_LR,
            this.DIMENSOES_LR,
            this.MATERIAL_LR,
            this.CLIENTE_LR,
            this.CNPJ_CLIENTE_LR,
            this.RASTREAMENTO_LR,
            this.QTDE_LR,
            this.DATA_LIBERACAO_LR,
            this.NOTA_FISCAL_LR,
            this.dataColumn1});
            this.LOTE_RECEBIMENTO.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_LR"}, true)});
            this.LOTE_RECEBIMENTO.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_LR};
            this.LOTE_RECEBIMENTO.TableName = "LOTE_RECEBIMENTO";
            // 
            // COD_LR
            // 
            this.COD_LR.AllowDBNull = false;
            this.COD_LR.ColumnName = "COD_LR";
            this.COD_LR.DataType = typeof(int);
            // 
            // COD_PRODUTO_LR
            // 
            this.COD_PRODUTO_LR.ColumnName = "COD_PRODUTO_LR";
            this.COD_PRODUTO_LR.DataType = typeof(int);
            // 
            // DESCRICAO_LR
            // 
            this.DESCRICAO_LR.ColumnName = "DESCRICAO_LR";
            this.DESCRICAO_LR.MaxLength = 200;
            // 
            // DIMENSOES_LR
            // 
            this.DIMENSOES_LR.ColumnName = "DIMENSOES_LR";
            this.DIMENSOES_LR.MaxLength = 100;
            // 
            // MATERIAL_LR
            // 
            this.MATERIAL_LR.ColumnName = "MATERIAL_LR";
            this.MATERIAL_LR.MaxLength = 100;
            // 
            // CLIENTE_LR
            // 
            this.CLIENTE_LR.ColumnName = "CLIENTE_LR";
            this.CLIENTE_LR.MaxLength = 200;
            // 
            // CNPJ_CLIENTE_LR
            // 
            this.CNPJ_CLIENTE_LR.ColumnName = "CNPJ_CLIENTE_LR";
            this.CNPJ_CLIENTE_LR.MaxLength = 100;
            // 
            // RASTREAMENTO_LR
            // 
            this.RASTREAMENTO_LR.ColumnName = "RASTREAMENTO_LR";
            this.RASTREAMENTO_LR.MaxLength = 100;
            // 
            // QTDE_LR
            // 
            this.QTDE_LR.ColumnName = "QTDE_LR";
            this.QTDE_LR.DataType = typeof(double);
            // 
            // DATA_LIBERACAO_LR
            // 
            this.DATA_LIBERACAO_LR.ColumnName = "DATA_LIBERACAO_LR";
            this.DATA_LIBERACAO_LR.DataType = typeof(System.DateTime);
            // 
            // NOTA_FISCAL_LR
            // 
            this.NOTA_FISCAL_LR.ColumnName = "NOTA_FISCAL_LR";
            this.NOTA_FISCAL_LR.MaxLength = 20;
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "LOCALIDADE_LR";
            this.dataColumn1.MaxLength = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cód. Lote:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cód. Matéria Prima:";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsLote_recebimento, "LOTE_RECEBIMENTO.COD_PRODUTO_LR", true));
            this.textBox2.Location = new System.Drawing.Point(117, 35);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(152, 20);
            this.textBox2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Descrição:";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsLote_recebimento, "LOTE_RECEBIMENTO.DESCRICAO_LR", true));
            this.textBox3.Location = new System.Drawing.Point(117, 61);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(264, 20);
            this.textBox3.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Dimensões:";
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsLote_recebimento, "LOTE_RECEBIMENTO.DIMENSOES_LR", true));
            this.textBox4.Location = new System.Drawing.Point(117, 87);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(152, 20);
            this.textBox4.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Material:";
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsLote_recebimento, "LOTE_RECEBIMENTO.MATERIAL_LR", true));
            this.textBox5.Location = new System.Drawing.Point(117, 113);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(152, 20);
            this.textBox5.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "CNPJ Cliente:";
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsLote_recebimento, "LOTE_RECEBIMENTO.CNPJ_CLIENTE_LR", true));
            this.textBox6.Location = new System.Drawing.Point(117, 139);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(152, 20);
            this.textBox6.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Nome Cliente:";
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsLote_recebimento, "LOTE_RECEBIMENTO.CLIENTE_LR", true));
            this.textBox7.Location = new System.Drawing.Point(117, 165);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(264, 20);
            this.textBox7.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Rastreamento:";
            // 
            // tb_rastreamento
            // 
            this.tb_rastreamento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsLote_recebimento, "LOTE_RECEBIMENTO.RASTREAMENTO_LR", true));
            this.tb_rastreamento.Location = new System.Drawing.Point(117, 191);
            this.tb_rastreamento.Name = "tb_rastreamento";
            this.tb_rastreamento.Size = new System.Drawing.Size(152, 20);
            this.tb_rastreamento.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Qtde:";
            // 
            // tb_qtde
            // 
            this.tb_qtde.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsLote_recebimento, "LOTE_RECEBIMENTO.QTDE_LR", true));
            this.tb_qtde.Location = new System.Drawing.Point(117, 217);
            this.tb_qtde.Name = "tb_qtde";
            this.tb_qtde.Size = new System.Drawing.Size(93, 20);
            this.tb_qtde.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 246);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Data Liberação:";
            // 
            // textBox10
            // 
            this.textBox10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsLote_recebimento, "LOTE_RECEBIMENTO.DATA_LIBERACAO_LR", true));
            this.textBox10.Location = new System.Drawing.Point(117, 243);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(93, 20);
            this.textBox10.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 272);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Nota Fiscal:";
            // 
            // textBox11
            // 
            this.textBox11.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsLote_recebimento, "LOTE_RECEBIMENTO.NOTA_FISCAL_LR", true));
            this.textBox11.Location = new System.Drawing.Point(117, 269);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(93, 20);
            this.textBox11.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(222, 220);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Localidade:";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsLote_recebimento, "LOTE_RECEBIMENTO.LOCALIDADE_LR", true));
            this.textBox1.Location = new System.Drawing.Point(288, 217);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(93, 20);
            this.textBox1.TabIndex = 23;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(198, 295);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 25;
            this.button2.Text = "Excluir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // form_lote_mp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 326);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_qtde);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_rastreamento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_cod_lote);
            this.Name = "form_lote_mp";
            this.Text = "Lote Matéria Prima";
            this.Load += new System.EventHandler(this.form_lote_mp_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.form_lote_mp_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dsLote_recebimento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LOTE_RECEBIMENTO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datLote_recebimento;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbLote_recebimento;
        private System.Windows.Forms.TextBox tb_cod_lote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_rastreamento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_qtde;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Button button1;
        private System.Data.DataSet dsLote_recebimento;
        private System.Data.DataTable LOTE_RECEBIMENTO;
        private System.Data.DataColumn COD_LR;
        private System.Data.DataColumn COD_PRODUTO_LR;
        private System.Data.DataColumn DESCRICAO_LR;
        private System.Data.DataColumn DIMENSOES_LR;
        private System.Data.DataColumn MATERIAL_LR;
        private System.Data.DataColumn CLIENTE_LR;
        private System.Data.DataColumn CNPJ_CLIENTE_LR;
        private System.Data.DataColumn RASTREAMENTO_LR;
        private System.Data.DataColumn QTDE_LR;
        private System.Data.DataColumn DATA_LIBERACAO_LR;
        private System.Data.DataColumn NOTA_FISCAL_LR;
        private System.Data.DataColumn dataColumn1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
    }
}