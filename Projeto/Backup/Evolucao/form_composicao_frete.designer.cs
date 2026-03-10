namespace Evolucao
{
    partial class form_composicao_frete
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_composicao_frete));
            this.dgvCte_frete_composicao = new System.Windows.Forms.DataGridView();
            this.col_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODCTECFCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsCte_frete_composicao = new System.Data.DataSet();
            this.CTE_FRETE_COMPOSICAO = new System.Data.DataTable();
            this.COD_CFC = new System.Data.DataColumn();
            this.DESCRICAO_CFC = new System.Data.DataColumn();
            this.VALOR_CFC = new System.Data.DataColumn();
            this.COD_CTE_CFC = new System.Data.DataColumn();
            this.datCte_frete_composicao = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_descricao = new System.Windows.Forms.TextBox();
            this.tb_valor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbColeta = new System.Windows.Forms.CheckBox();
            this.label35 = new System.Windows.Forms.Label();
            this.tb_aliquota = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cbCubagem = new System.Windows.Forms.CheckBox();
            this.label33 = new System.Windows.Forms.Label();
            this.tb_valor_total_cte = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.tb_valor_icms = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.tb_base_calculo = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.tb_subtotal = new System.Windows.Forms.TextBox();
            this.cbCte_frete_composicao = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCte_frete_composicao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCte_frete_composicao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CTE_FRETE_COMPOSICAO)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCte_frete_composicao
            // 
            this.dgvCte_frete_composicao.AllowUserToAddRows = false;
            this.dgvCte_frete_composicao.AutoGenerateColumns = false;
            this.dgvCte_frete_composicao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCte_frete_composicao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_cod,
            this.col_descricao,
            this.col_valor,
            this.cODCTECFCDataGridViewTextBoxColumn});
            this.dgvCte_frete_composicao.DataMember = "CTE_FRETE_COMPOSICAO";
            this.dgvCte_frete_composicao.DataSource = this.dsCte_frete_composicao;
            this.dgvCte_frete_composicao.Location = new System.Drawing.Point(12, 110);
            this.dgvCte_frete_composicao.Name = "dgvCte_frete_composicao";
            this.dgvCte_frete_composicao.Size = new System.Drawing.Size(374, 269);
            this.dgvCte_frete_composicao.TabIndex = 0;
            // 
            // col_cod
            // 
            this.col_cod.DataPropertyName = "COD_CFC";
            this.col_cod.HeaderText = "COD_CFC";
            this.col_cod.Name = "col_cod";
            this.col_cod.Visible = false;
            // 
            // col_descricao
            // 
            this.col_descricao.DataPropertyName = "DESCRICAO_CFC";
            this.col_descricao.HeaderText = "Descrição";
            this.col_descricao.Name = "col_descricao";
            this.col_descricao.Width = 200;
            // 
            // col_valor
            // 
            this.col_valor.DataPropertyName = "VALOR_CFC";
            dataGridViewCellStyle1.Format = "N2";
            this.col_valor.DefaultCellStyle = dataGridViewCellStyle1;
            this.col_valor.HeaderText = "Valor";
            this.col_valor.Name = "col_valor";
            // 
            // cODCTECFCDataGridViewTextBoxColumn
            // 
            this.cODCTECFCDataGridViewTextBoxColumn.DataPropertyName = "COD_CTE_CFC";
            this.cODCTECFCDataGridViewTextBoxColumn.HeaderText = "COD_CTE_CFC";
            this.cODCTECFCDataGridViewTextBoxColumn.Name = "cODCTECFCDataGridViewTextBoxColumn";
            this.cODCTECFCDataGridViewTextBoxColumn.Visible = false;
            // 
            // dsCte_frete_composicao
            // 
            this.dsCte_frete_composicao.DataSetName = "dsCte_frete_composicao";
            this.dsCte_frete_composicao.Namespace = "http://www.tempuri.org/dsCte_frete_composicao.xsd";
            this.dsCte_frete_composicao.Tables.AddRange(new System.Data.DataTable[] {
            this.CTE_FRETE_COMPOSICAO});
            // 
            // CTE_FRETE_COMPOSICAO
            // 
            this.CTE_FRETE_COMPOSICAO.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_CFC,
            this.DESCRICAO_CFC,
            this.VALOR_CFC,
            this.COD_CTE_CFC});
            this.CTE_FRETE_COMPOSICAO.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_CFC"}, true)});
            this.CTE_FRETE_COMPOSICAO.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_CFC};
            this.CTE_FRETE_COMPOSICAO.TableName = "CTE_FRETE_COMPOSICAO";
            // 
            // COD_CFC
            // 
            this.COD_CFC.AllowDBNull = false;
            this.COD_CFC.ColumnName = "COD_CFC";
            this.COD_CFC.DataType = typeof(int);
            // 
            // DESCRICAO_CFC
            // 
            this.DESCRICAO_CFC.ColumnName = "DESCRICAO_CFC";
            this.DESCRICAO_CFC.MaxLength = 200;
            // 
            // VALOR_CFC
            // 
            this.VALOR_CFC.ColumnName = "VALOR_CFC";
            this.VALOR_CFC.DataType = typeof(double);
            // 
            // COD_CTE_CFC
            // 
            this.COD_CTE_CFC.ColumnName = "COD_CTE_CFC";
            this.COD_CTE_CFC.DataType = typeof(int);
            // 
            // datCte_frete_composicao
            // 
            this.datCte_frete_composicao.DeleteCommand = this.fbCommand4;
            this.datCte_frete_composicao.InsertCommand = this.fbCommand2;
            this.datCte_frete_composicao.SelectCommand = this.fbCommand1;
            this.datCte_frete_composicao.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * from cte_frete_composicao";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descrição:";
            // 
            // tb_descricao
            // 
            this.tb_descricao.Location = new System.Drawing.Point(79, 9);
            this.tb_descricao.Name = "tb_descricao";
            this.tb_descricao.Size = new System.Drawing.Size(235, 20);
            this.tb_descricao.TabIndex = 2;
            // 
            // tb_valor
            // 
            this.tb_valor.Location = new System.Drawing.Point(79, 35);
            this.tb_valor.Name = "tb_valor";
            this.tb_valor.Size = new System.Drawing.Size(114, 20);
            this.tb_valor.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valor:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(199, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 20);
            this.button1.TabIndex = 5;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.cbColeta);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.tb_valor);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tb_descricao);
            this.panel1.Controls.Add(this.label35);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tb_aliquota);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(32, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 92);
            this.panel1.TabIndex = 6;
            // 
            // cbColeta
            // 
            this.cbColeta.AutoSize = true;
            this.cbColeta.Location = new System.Drawing.Point(279, 61);
            this.cbColeta.Name = "cbColeta";
            this.cbColeta.Size = new System.Drawing.Size(56, 17);
            this.cbColeta.TabIndex = 10;
            this.cbColeta.Text = "Coleta";
            this.cbColeta.UseVisualStyleBackColor = true;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(17, 64);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(59, 13);
            this.label35.TabIndex = 30;
            this.label35.Text = "Aliq. ICMS:";
            // 
            // tb_aliquota
            // 
            this.tb_aliquota.Location = new System.Drawing.Point(79, 61);
            this.tb_aliquota.Name = "tb_aliquota";
            this.tb_aliquota.Size = new System.Drawing.Size(77, 20);
            this.tb_aliquota.TabIndex = 29;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button3.Location = new System.Drawing.Point(166, 61);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 20);
            this.button3.TabIndex = 9;
            this.button3.Text = "Buscar da Tabela";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button2.Location = new System.Drawing.Point(15, 388);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 40);
            this.button2.TabIndex = 7;
            this.button2.Text = "Salvar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbCubagem
            // 
            this.cbCubagem.AutoSize = true;
            this.cbCubagem.Location = new System.Drawing.Point(15, 485);
            this.cbCubagem.Name = "cbCubagem";
            this.cbCubagem.Size = new System.Drawing.Size(71, 17);
            this.cbCubagem.TabIndex = 8;
            this.cbCubagem.Text = "Cubagem";
            this.cbCubagem.UseVisualStyleBackColor = true;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(218, 458);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(61, 13);
            this.label33.TabIndex = 34;
            this.label33.Text = "Valor Total:";
            // 
            // tb_valor_total_cte
            // 
            this.tb_valor_total_cte.Location = new System.Drawing.Point(307, 455);
            this.tb_valor_total_cte.Name = "tb_valor_total_cte";
            this.tb_valor_total_cte.Size = new System.Drawing.Size(77, 20);
            this.tb_valor_total_cte.TabIndex = 33;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(218, 435);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(63, 13);
            this.label34.TabIndex = 32;
            this.label34.Text = "Valor ICMS:";
            // 
            // tb_valor_icms
            // 
            this.tb_valor_icms.Location = new System.Drawing.Point(307, 432);
            this.tb_valor_icms.Name = "tb_valor_icms";
            this.tb_valor_icms.Size = new System.Drawing.Size(77, 20);
            this.tb_valor_icms.TabIndex = 31;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(218, 411);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(87, 13);
            this.label36.TabIndex = 28;
            this.label36.Text = "Base de Cálculo:";
            // 
            // tb_base_calculo
            // 
            this.tb_base_calculo.Location = new System.Drawing.Point(307, 408);
            this.tb_base_calculo.Name = "tb_base_calculo";
            this.tb_base_calculo.Size = new System.Drawing.Size(77, 20);
            this.tb_base_calculo.TabIndex = 27;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(218, 388);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(52, 13);
            this.label37.TabIndex = 26;
            this.label37.Text = "Sub-total:";
            // 
            // tb_subtotal
            // 
            this.tb_subtotal.Location = new System.Drawing.Point(307, 385);
            this.tb_subtotal.Name = "tb_subtotal";
            this.tb_subtotal.Size = new System.Drawing.Size(77, 20);
            this.tb_subtotal.TabIndex = 25;
            // 
            // cbCte_frete_composicao
            // 
            this.cbCte_frete_composicao.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbCte_frete_composicao.DataAdapter = this.datCte_frete_composicao;
            this.cbCte_frete_composicao.QuotePrefix = "\"";
            this.cbCte_frete_composicao.QuoteSuffix = "\"";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button4.Location = new System.Drawing.Point(15, 430);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 40);
            this.button4.TabIndex = 35;
            this.button4.Text = "Recalcular";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // form_composicao_frete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 516);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.tb_valor_total_cte);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.tb_valor_icms);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.tb_base_calculo);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.tb_subtotal);
            this.Controls.Add(this.cbCubagem);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvCte_frete_composicao);
            this.Name = "form_composicao_frete";
            this.Text = "Composição do Frete";
            this.Load += new System.EventHandler(this.form_composicao_frete_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.form_composicao_frete_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCte_frete_composicao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCte_frete_composicao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CTE_FRETE_COMPOSICAO)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCte_frete_composicao;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datCte_frete_composicao;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_descricao;
        private System.Windows.Forms.TextBox tb_valor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox cbCubagem;
        private System.Windows.Forms.Button button3;
        private System.Data.DataSet dsCte_frete_composicao;
        private System.Data.DataTable CTE_FRETE_COMPOSICAO;
        private System.Data.DataColumn COD_CFC;
        private System.Data.DataColumn DESCRICAO_CFC;
        private System.Data.DataColumn VALOR_CFC;
        private System.Data.DataColumn COD_CTE_CFC;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox tb_valor_total_cte;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox tb_valor_icms;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox tb_aliquota;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox tb_base_calculo;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox tb_subtotal;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbCte_frete_composicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODCTECFCDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox cbColeta;
    }
}