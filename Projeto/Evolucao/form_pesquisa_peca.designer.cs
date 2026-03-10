namespace Evolucao
{
    partial class form_pesquisa_peca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_pesquisa_peca));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.datPecas = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsPecas = new System.Data.DataSet();
            this.PECAS = new System.Data.DataTable();
            this.COD_PECA = new System.Data.DataColumn();
            this.DESCRICAO_PECA = new System.Data.DataColumn();
            this.COD_DESENHO_PECA = new System.Data.DataColumn();
            this.CLIENTE_PECA = new System.Data.DataColumn();
            this.CNPJ_CLIENTE_PECA = new System.Data.DataColumn();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dgvPecas = new System.Windows.Forms.DataGridView();
            this.col_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cod_desenho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTEPECADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNPJCLIENTEPECADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COD_ALTERNATIVO1_PECA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tb_cod_desenho = new System.Windows.Forms.TextBox();
            this.bt_modificar_selecao = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_cod_alternativo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dsPecas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PECAS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPecas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // datPecas
            // 
            this.datPecas.DeleteCommand = this.fbCommand4;
            this.datPecas.InsertCommand = this.fbCommand2;
            this.datPecas.SelectCommand = this.fbCommand1;
            this.datPecas.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * from pecas";
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
            // dsPecas
            // 
            this.dsPecas.DataSetName = "dsPecas";
            this.dsPecas.Namespace = "http://www.tempuri.org/dsPecas.xsd";
            this.dsPecas.Tables.AddRange(new System.Data.DataTable[] {
            this.PECAS});
            // 
            // PECAS
            // 
            this.PECAS.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_PECA,
            this.DESCRICAO_PECA,
            this.COD_DESENHO_PECA,
            this.CLIENTE_PECA,
            this.CNPJ_CLIENTE_PECA,
            this.dataColumn1});
            this.PECAS.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_PECA"}, true)});
            this.PECAS.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_PECA};
            this.PECAS.TableName = "PECAS";
            // 
            // COD_PECA
            // 
            this.COD_PECA.AllowDBNull = false;
            this.COD_PECA.ColumnName = "COD_PECA";
            this.COD_PECA.DataType = typeof(int);
            // 
            // DESCRICAO_PECA
            // 
            this.DESCRICAO_PECA.ColumnName = "DESCRICAO_PECA";
            this.DESCRICAO_PECA.MaxLength = 200;
            // 
            // COD_DESENHO_PECA
            // 
            this.COD_DESENHO_PECA.ColumnName = "COD_DESENHO_PECA";
            this.COD_DESENHO_PECA.MaxLength = 200;
            // 
            // CLIENTE_PECA
            // 
            this.CLIENTE_PECA.ColumnName = "CLIENTE_PECA";
            this.CLIENTE_PECA.MaxLength = 200;
            // 
            // CNPJ_CLIENTE_PECA
            // 
            this.CNPJ_CLIENTE_PECA.ColumnName = "CNPJ_CLIENTE_PECA";
            this.CNPJ_CLIENTE_PECA.MaxLength = 200;
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "COD_ALTERNATIVO1_PECA";
            this.dataColumn1.MaxLength = 100;
            // 
            // dgvPecas
            // 
            this.dgvPecas.AllowUserToAddRows = false;
            this.dgvPecas.AllowUserToDeleteRows = false;
            this.dgvPecas.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPecas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPecas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPecas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_cod,
            this.col_descricao,
            this.col_cod_desenho,
            this.cLIENTEPECADataGridViewTextBoxColumn,
            this.cNPJCLIENTEPECADataGridViewTextBoxColumn,
            this.COD_ALTERNATIVO1_PECA});
            this.dgvPecas.DataMember = "PECAS";
            this.dgvPecas.DataSource = this.dsPecas;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPecas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPecas.Location = new System.Drawing.Point(12, 73);
            this.dgvPecas.Name = "dgvPecas";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPecas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPecas.Size = new System.Drawing.Size(663, 464);
            this.dgvPecas.TabIndex = 500;
            this.dgvPecas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPecas_CellDoubleClick);
            this.dgvPecas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvPecas_KeyPress);
            // 
            // col_cod
            // 
            this.col_cod.DataPropertyName = "COD_PECA";
            this.col_cod.HeaderText = "Cód.";
            this.col_cod.Name = "col_cod";
            this.col_cod.Visible = false;
            // 
            // col_descricao
            // 
            this.col_descricao.DataPropertyName = "DESCRICAO_PECA";
            this.col_descricao.HeaderText = "Descrição";
            this.col_descricao.Name = "col_descricao";
            this.col_descricao.Width = 200;
            // 
            // col_cod_desenho
            // 
            this.col_cod_desenho.DataPropertyName = "COD_DESENHO_PECA";
            this.col_cod_desenho.HeaderText = "Cód. Desenho";
            this.col_cod_desenho.Name = "col_cod_desenho";
            this.col_cod_desenho.Width = 200;
            // 
            // cLIENTEPECADataGridViewTextBoxColumn
            // 
            this.cLIENTEPECADataGridViewTextBoxColumn.DataPropertyName = "CLIENTE_PECA";
            this.cLIENTEPECADataGridViewTextBoxColumn.HeaderText = "CLIENTE_PECA";
            this.cLIENTEPECADataGridViewTextBoxColumn.Name = "cLIENTEPECADataGridViewTextBoxColumn";
            this.cLIENTEPECADataGridViewTextBoxColumn.Visible = false;
            // 
            // cNPJCLIENTEPECADataGridViewTextBoxColumn
            // 
            this.cNPJCLIENTEPECADataGridViewTextBoxColumn.DataPropertyName = "CNPJ_CLIENTE_PECA";
            this.cNPJCLIENTEPECADataGridViewTextBoxColumn.HeaderText = "CNPJ_CLIENTE_PECA";
            this.cNPJCLIENTEPECADataGridViewTextBoxColumn.Name = "cNPJCLIENTEPECADataGridViewTextBoxColumn";
            this.cNPJCLIENTEPECADataGridViewTextBoxColumn.Visible = false;
            // 
            // COD_ALTERNATIVO1_PECA
            // 
            this.COD_ALTERNATIVO1_PECA.DataPropertyName = "COD_ALTERNATIVO1_PECA";
            this.COD_ALTERNATIVO1_PECA.HeaderText = "Ferramenta";
            this.COD_ALTERNATIVO1_PECA.Name = "COD_ALTERNATIVO1_PECA";
            this.COD_ALTERNATIVO1_PECA.Width = 200;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tb_cod_desenho
            // 
            this.tb_cod_desenho.Location = new System.Drawing.Point(225, 25);
            this.tb_cod_desenho.Name = "tb_cod_desenho";
            this.tb_cod_desenho.Size = new System.Drawing.Size(200, 20);
            this.tb_cod_desenho.TabIndex = 0;
            this.tb_cod_desenho.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // bt_modificar_selecao
            // 
            this.bt_modificar_selecao.Location = new System.Drawing.Point(163, 543);
            this.bt_modificar_selecao.Name = "bt_modificar_selecao";
            this.bt_modificar_selecao.Size = new System.Drawing.Size(145, 23);
            this.bt_modificar_selecao.TabIndex = 5001;
            this.bt_modificar_selecao.Text = "Abrir Seleção";
            this.bt_modificar_selecao.UseVisualStyleBackColor = true;
            this.bt_modificar_selecao.Click += new System.EventHandler(this.bt_modificar_selecao_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(317, 543);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 23);
            this.button1.TabIndex = 5002;
            this.button1.Text = "Nova Peça";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tb_cod_alternativo);
            this.panel1.Controls.Add(this.tb_cod_desenho);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(27, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(648, 60);
            this.panel1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(423, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ferramenta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cód. Desenho";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Descrição";
            // 
            // tb_cod_alternativo
            // 
            this.tb_cod_alternativo.Location = new System.Drawing.Point(426, 25);
            this.tb_cod_alternativo.Name = "tb_cod_alternativo";
            this.tb_cod_alternativo.Size = new System.Drawing.Size(200, 20);
            this.tb_cod_alternativo.TabIndex = 2;
            this.tb_cod_alternativo.TextChanged += new System.EventHandler(this.tb_cod_alternativo_TextChanged);
            // 
            // form_pesquisa_peca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 581);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_modificar_selecao);
            this.Controls.Add(this.dgvPecas);
            this.Name = "form_pesquisa_peca";
            this.Text = "Pesquisa Peça";
            this.Load += new System.EventHandler(this.form_pesquisa_peca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsPecas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PECAS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPecas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datPecas;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Data.DataSet dsPecas;
        private System.Data.DataTable PECAS;
        private System.Data.DataColumn COD_PECA;
        private System.Data.DataColumn DESCRICAO_PECA;
        private System.Data.DataColumn COD_DESENHO_PECA;
        private System.Data.DataColumn CLIENTE_PECA;
        private System.Data.DataColumn CNPJ_CLIENTE_PECA;
        private System.Windows.Forms.DataGridView dgvPecas;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tb_cod_desenho;
        private System.Windows.Forms.Button bt_modificar_selecao;
        private System.Windows.Forms.Button button1;
        private System.Data.DataColumn dataColumn1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_cod_alternativo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod_desenho;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTEPECADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPJCLIENTEPECADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_ALTERNATIVO1_PECA;
    }
}