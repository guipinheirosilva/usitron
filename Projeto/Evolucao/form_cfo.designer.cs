namespace Evolucao
{
    partial class form_cfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_cfo));
            this.apaga_registro = new System.Windows.Forms.Button();
            this.salva_registro = new System.Windows.Forms.Button();
            this.vai_anterior = new System.Windows.Forms.Button();
            this.vai_proximo = new System.Windows.Forms.Button();
            this.vai_ultimo = new System.Windows.Forms.Button();
            this.novo_registro = new System.Windows.Forms.Button();
            this.vai_primeiro = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.tb_descricao = new System.Windows.Forms.TextBox();
            this.dsCfo = new System.Data.DataSet();
            this.CFO = new System.Data.DataTable();
            this.COD_SISTEMA_CFO = new System.Data.DataColumn();
            this.N_CFO = new System.Data.DataColumn();
            this.DESCRICAO_CFO = new System.Data.DataColumn();
            this.OBSERVACAO_CFO = new System.Data.DataColumn();
            this.dataColumn1 = new System.Data.DataColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_n_cfo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_cod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_observacao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.datCfo = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.cbCfo = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dsCfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CFO)).BeginInit();
            this.SuspendLayout();
            // 
            // apaga_registro
            // 
            this.apaga_registro.Location = new System.Drawing.Point(301, 216);
            this.apaga_registro.Name = "apaga_registro";
            this.apaga_registro.Size = new System.Drawing.Size(49, 22);
            this.apaga_registro.TabIndex = 151;
            this.apaga_registro.Text = "Excluir";
            this.apaga_registro.UseVisualStyleBackColor = true;
            this.apaga_registro.Click += new System.EventHandler(this.apaga_registro_Click);
            // 
            // salva_registro
            // 
            this.salva_registro.Location = new System.Drawing.Point(356, 216);
            this.salva_registro.Name = "salva_registro";
            this.salva_registro.Size = new System.Drawing.Size(49, 22);
            this.salva_registro.TabIndex = 150;
            this.salva_registro.Text = "Salvar";
            this.salva_registro.UseVisualStyleBackColor = true;
            this.salva_registro.Click += new System.EventHandler(this.salva_registro_Click);
            // 
            // vai_anterior
            // 
            this.vai_anterior.Location = new System.Drawing.Point(78, 216);
            this.vai_anterior.Name = "vai_anterior";
            this.vai_anterior.Size = new System.Drawing.Size(49, 22);
            this.vai_anterior.TabIndex = 149;
            this.vai_anterior.Text = "<";
            this.vai_anterior.UseVisualStyleBackColor = true;
            this.vai_anterior.Click += new System.EventHandler(this.vai_anterior_Click);
            // 
            // vai_proximo
            // 
            this.vai_proximo.Location = new System.Drawing.Point(135, 216);
            this.vai_proximo.Name = "vai_proximo";
            this.vai_proximo.Size = new System.Drawing.Size(49, 22);
            this.vai_proximo.TabIndex = 148;
            this.vai_proximo.Text = ">";
            this.vai_proximo.UseVisualStyleBackColor = true;
            this.vai_proximo.Click += new System.EventHandler(this.vai_proximo_Click);
            // 
            // vai_ultimo
            // 
            this.vai_ultimo.Location = new System.Drawing.Point(190, 216);
            this.vai_ultimo.Name = "vai_ultimo";
            this.vai_ultimo.Size = new System.Drawing.Size(49, 22);
            this.vai_ultimo.TabIndex = 147;
            this.vai_ultimo.Text = ">>";
            this.vai_ultimo.UseVisualStyleBackColor = true;
            this.vai_ultimo.Click += new System.EventHandler(this.vai_ultimo_Click);
            // 
            // novo_registro
            // 
            this.novo_registro.Location = new System.Drawing.Point(246, 216);
            this.novo_registro.Name = "novo_registro";
            this.novo_registro.Size = new System.Drawing.Size(49, 22);
            this.novo_registro.TabIndex = 146;
            this.novo_registro.Text = "Novo";
            this.novo_registro.UseVisualStyleBackColor = true;
            this.novo_registro.Click += new System.EventHandler(this.novo_registro_Click);
            // 
            // vai_primeiro
            // 
            this.vai_primeiro.Location = new System.Drawing.Point(23, 216);
            this.vai_primeiro.Name = "vai_primeiro";
            this.vai_primeiro.Size = new System.Drawing.Size(49, 22);
            this.vai_primeiro.TabIndex = 145;
            this.vai_primeiro.Text = "<<";
            this.vai_primeiro.UseVisualStyleBackColor = true;
            this.vai_primeiro.Click += new System.EventHandler(this.vai_primeiro_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label20.Location = new System.Drawing.Point(144, 9);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(131, 46);
            this.label20.TabIndex = 141;
            this.label20.Text = "CFOP";
            // 
            // tb_descricao
            // 
            this.tb_descricao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsCfo, "CFO.DESCRICAO_CFO", true));
            this.tb_descricao.Location = new System.Drawing.Point(129, 116);
            this.tb_descricao.Name = "tb_descricao";
            this.tb_descricao.Size = new System.Drawing.Size(185, 20);
            this.tb_descricao.TabIndex = 130;
            // 
            // dsCfo
            // 
            this.dsCfo.DataSetName = "dsCfo";
            this.dsCfo.Namespace = "http://www.tempuri.org/dsCfo.xsd";
            this.dsCfo.Tables.AddRange(new System.Data.DataTable[] {
            this.CFO});
            // 
            // CFO
            // 
            this.CFO.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_SISTEMA_CFO,
            this.N_CFO,
            this.DESCRICAO_CFO,
            this.OBSERVACAO_CFO,
            this.dataColumn1});
            this.CFO.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_SISTEMA_CFO"}, true)});
            this.CFO.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_SISTEMA_CFO};
            this.CFO.TableName = "CFO";
            // 
            // COD_SISTEMA_CFO
            // 
            this.COD_SISTEMA_CFO.AllowDBNull = false;
            this.COD_SISTEMA_CFO.ColumnName = "COD_SISTEMA_CFO";
            this.COD_SISTEMA_CFO.DataType = typeof(int);
            // 
            // N_CFO
            // 
            this.N_CFO.ColumnName = "N_CFO";
            this.N_CFO.DataType = typeof(int);
            // 
            // DESCRICAO_CFO
            // 
            this.DESCRICAO_CFO.ColumnName = "DESCRICAO_CFO";
            this.DESCRICAO_CFO.MaxLength = 80;
            // 
            // OBSERVACAO_CFO
            // 
            this.OBSERVACAO_CFO.ColumnName = "OBSERVACAO_CFO";
            this.OBSERVACAO_CFO.MaxLength = 250;
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "TRIBUTADA_CFO";
            this.dataColumn1.DataType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 138;
            this.label3.Text = "Descrição:";
            // 
            // tb_n_cfo
            // 
            this.tb_n_cfo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsCfo, "CFO.N_CFO", true));
            this.tb_n_cfo.Location = new System.Drawing.Point(129, 90);
            this.tb_n_cfo.Name = "tb_n_cfo";
            this.tb_n_cfo.Size = new System.Drawing.Size(70, 20);
            this.tb_n_cfo.TabIndex = 129;
            this.tb_n_cfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 137;
            this.label2.Text = "N.º da CFO:";
            // 
            // tb_cod
            // 
            this.tb_cod.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsCfo, "CFO.COD_SISTEMA_CFO", true));
            this.tb_cod.Location = new System.Drawing.Point(129, 64);
            this.tb_cod.Name = "tb_cod";
            this.tb_cod.ReadOnly = true;
            this.tb_cod.Size = new System.Drawing.Size(52, 20);
            this.tb_cod.TabIndex = 128;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 136;
            this.label1.Text = "Código Interno:";
            // 
            // tb_observacao
            // 
            this.tb_observacao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsCfo, "CFO.OBSERVACAO_CFO", true));
            this.tb_observacao.Location = new System.Drawing.Point(129, 142);
            this.tb_observacao.Multiline = true;
            this.tb_observacao.Name = "tb_observacao";
            this.tb_observacao.Size = new System.Drawing.Size(277, 63);
            this.tb_observacao.TabIndex = 152;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 153;
            this.label4.Text = "Observação:";
            // 
            // datCfo
            // 
            this.datCfo.DeleteCommand = this.fbCommand4;
            this.datCfo.InsertCommand = this.fbCommand2;
            this.datCfo.SelectCommand = this.fbCommand1;
            this.datCfo.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * from cfo order by n_cfo";
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
            // cbCfo
            // 
            this.cbCfo.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbCfo.DataAdapter = this.datCfo;
            this.cbCfo.QuotePrefix = "\"";
            this.cbCfo.QuoteSuffix = "\"";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsCfo, "CFO.TRIBUTADA_CFO", true));
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.dsCfo, "CFO.TRIBUTADA_CFO", true));
            this.checkBox1.Location = new System.Drawing.Point(215, 66);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(77, 17);
            this.checkBox1.TabIndex = 154;
            this.checkBox1.Text = "Tributada?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // form_cfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 252);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.tb_observacao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.apaga_registro);
            this.Controls.Add(this.salva_registro);
            this.Controls.Add(this.vai_anterior);
            this.Controls.Add(this.vai_proximo);
            this.Controls.Add(this.vai_ultimo);
            this.Controls.Add(this.novo_registro);
            this.Controls.Add(this.vai_primeiro);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.tb_descricao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_n_cfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_cod);
            this.Controls.Add(this.label1);
            this.Name = "form_cfo";
            this.Text = "CFO";
            this.Load += new System.EventHandler(this.form_cfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsCfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CFO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button apaga_registro;
        private System.Windows.Forms.Button salva_registro;
        private System.Windows.Forms.Button vai_anterior;
        private System.Windows.Forms.Button vai_proximo;
        private System.Windows.Forms.Button vai_ultimo;
        private System.Windows.Forms.Button novo_registro;
        private System.Windows.Forms.Button vai_primeiro;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tb_descricao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_n_cfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_cod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_observacao;
        private System.Windows.Forms.Label label4;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datCfo;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Data.DataSet dsCfo;
        private System.Data.DataTable CFO;
        private System.Data.DataColumn COD_SISTEMA_CFO;
        private System.Data.DataColumn N_CFO;
        private System.Data.DataColumn DESCRICAO_CFO;
        private System.Data.DataColumn OBSERVACAO_CFO;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbCfo;
        private System.Data.DataColumn dataColumn1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}