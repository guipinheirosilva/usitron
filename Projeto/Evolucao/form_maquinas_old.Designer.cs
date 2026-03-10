namespace Evolucao
{
    partial class form_maquinas_old
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_maquinas_old));
            this.apaga_registro = new System.Windows.Forms.Button();
            this.salva_registro = new System.Windows.Forms.Button();
            this.vai_anterior = new System.Windows.Forms.Button();
            this.vai_proximo = new System.Windows.Forms.Button();
            this.vai_ultimo = new System.Windows.Forms.Button();
            this.novo_registro = new System.Windows.Forms.Button();
            this.vai_primeiro = new System.Windows.Forms.Button();
            this.tb_abreviacao = new System.Windows.Forms.TextBox();
            this.dsMaquinas = new System.Data.DataSet();
            this.MAQUINAS = new System.Data.DataTable();
            this.COD_MAQUINA = new System.Data.DataColumn();
            this.MAQUINA = new System.Data.DataColumn();
            this.ABREVIACAO = new System.Data.DataColumn();
            this.label16 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.tb_maquina = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_cod_maquina = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.datMaquinas = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.cbMaquinas = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaquinas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MAQUINAS)).BeginInit();
            this.SuspendLayout();
            // 
            // apaga_registro
            // 
            this.apaga_registro.Location = new System.Drawing.Point(164, 247);
            this.apaga_registro.Margin = new System.Windows.Forms.Padding(4);
            this.apaga_registro.Name = "apaga_registro";
            this.apaga_registro.Size = new System.Drawing.Size(65, 27);
            this.apaga_registro.TabIndex = 134;
            this.apaga_registro.Text = "Excluir";
            this.apaga_registro.UseVisualStyleBackColor = true;
            // 
            // salva_registro
            // 
            this.salva_registro.Location = new System.Drawing.Point(237, 247);
            this.salva_registro.Margin = new System.Windows.Forms.Padding(4);
            this.salva_registro.Name = "salva_registro";
            this.salva_registro.Size = new System.Drawing.Size(65, 27);
            this.salva_registro.TabIndex = 133;
            this.salva_registro.Text = "Salvar";
            this.salva_registro.UseVisualStyleBackColor = true;
            this.salva_registro.Click += new System.EventHandler(this.salva_registro_Click);
            // 
            // vai_anterior
            // 
            this.vai_anterior.Location = new System.Drawing.Point(123, 213);
            this.vai_anterior.Margin = new System.Windows.Forms.Padding(4);
            this.vai_anterior.Name = "vai_anterior";
            this.vai_anterior.Size = new System.Drawing.Size(65, 27);
            this.vai_anterior.TabIndex = 132;
            this.vai_anterior.Text = "<";
            this.vai_anterior.UseVisualStyleBackColor = true;
            this.vai_anterior.Click += new System.EventHandler(this.vai_anterior_Click);
            // 
            // vai_proximo
            // 
            this.vai_proximo.Location = new System.Drawing.Point(199, 213);
            this.vai_proximo.Margin = new System.Windows.Forms.Padding(4);
            this.vai_proximo.Name = "vai_proximo";
            this.vai_proximo.Size = new System.Drawing.Size(65, 27);
            this.vai_proximo.TabIndex = 131;
            this.vai_proximo.Text = ">";
            this.vai_proximo.UseVisualStyleBackColor = true;
            this.vai_proximo.Click += new System.EventHandler(this.vai_proximo_Click);
            // 
            // vai_ultimo
            // 
            this.vai_ultimo.Location = new System.Drawing.Point(272, 213);
            this.vai_ultimo.Margin = new System.Windows.Forms.Padding(4);
            this.vai_ultimo.Name = "vai_ultimo";
            this.vai_ultimo.Size = new System.Drawing.Size(65, 27);
            this.vai_ultimo.TabIndex = 130;
            this.vai_ultimo.Text = ">>";
            this.vai_ultimo.UseVisualStyleBackColor = true;
            this.vai_ultimo.Click += new System.EventHandler(this.vai_ultimo_Click);
            // 
            // novo_registro
            // 
            this.novo_registro.Location = new System.Drawing.Point(91, 247);
            this.novo_registro.Margin = new System.Windows.Forms.Padding(4);
            this.novo_registro.Name = "novo_registro";
            this.novo_registro.Size = new System.Drawing.Size(65, 27);
            this.novo_registro.TabIndex = 129;
            this.novo_registro.Text = "Novo";
            this.novo_registro.UseVisualStyleBackColor = true;
            this.novo_registro.Click += new System.EventHandler(this.novo_registro_Click);
            // 
            // vai_primeiro
            // 
            this.vai_primeiro.Location = new System.Drawing.Point(49, 213);
            this.vai_primeiro.Margin = new System.Windows.Forms.Padding(4);
            this.vai_primeiro.Name = "vai_primeiro";
            this.vai_primeiro.Size = new System.Drawing.Size(65, 27);
            this.vai_primeiro.TabIndex = 128;
            this.vai_primeiro.Text = "<<";
            this.vai_primeiro.UseVisualStyleBackColor = true;
            this.vai_primeiro.Click += new System.EventHandler(this.vai_primeiro_Click);
            // 
            // tb_abreviacao
            // 
            this.tb_abreviacao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMaquinas, "MAQUINAS.ABREVIACAO", true));
            this.tb_abreviacao.Location = new System.Drawing.Point(181, 172);
            this.tb_abreviacao.Margin = new System.Windows.Forms.Padding(4);
            this.tb_abreviacao.Name = "tb_abreviacao";
            this.tb_abreviacao.Size = new System.Drawing.Size(180, 22);
            this.tb_abreviacao.TabIndex = 127;
            // 
            // dsMaquinas
            // 
            this.dsMaquinas.DataSetName = "dsMaquinas";
            this.dsMaquinas.Namespace = "http://www.tempuri.org/dsMaquinas.xsd";
            this.dsMaquinas.Tables.AddRange(new System.Data.DataTable[] {
            this.MAQUINAS});
            // 
            // MAQUINAS
            // 
            this.MAQUINAS.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_MAQUINA,
            this.MAQUINA,
            this.ABREVIACAO});
            this.MAQUINAS.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_MAQUINA"}, true)});
            this.MAQUINAS.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_MAQUINA};
            this.MAQUINAS.TableName = "MAQUINAS";
            // 
            // COD_MAQUINA
            // 
            this.COD_MAQUINA.AllowDBNull = false;
            this.COD_MAQUINA.AutoIncrement = true;
            this.COD_MAQUINA.ColumnName = "COD_MAQUINA";
            this.COD_MAQUINA.DataType = typeof(int);
            // 
            // MAQUINA
            // 
            this.MAQUINA.ColumnName = "MAQUINA";
            this.MAQUINA.MaxLength = 30;
            // 
            // ABREVIACAO
            // 
            this.ABREVIACAO.ColumnName = "ABREVIACAO";
            this.ABREVIACAO.MaxLength = 30;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(41, 176);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(83, 17);
            this.label16.TabIndex = 126;
            this.label16.Text = "Abreviação:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label20.Location = new System.Drawing.Point(121, 34);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(145, 36);
            this.label20.TabIndex = 125;
            this.label20.Text = "Máquinas";
            // 
            // tb_maquina
            // 
            this.tb_maquina.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMaquinas, "MAQUINAS.MAQUINA", true));
            this.tb_maquina.Location = new System.Drawing.Point(181, 140);
            this.tb_maquina.Margin = new System.Windows.Forms.Padding(4);
            this.tb_maquina.Name = "tb_maquina";
            this.tb_maquina.Size = new System.Drawing.Size(180, 22);
            this.tb_maquina.TabIndex = 124;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 123;
            this.label2.Text = "Nome da Máquina:";
            // 
            // tb_cod_maquina
            // 
            this.tb_cod_maquina.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMaquinas, "MAQUINAS.COD_MAQUINA", true));
            this.tb_cod_maquina.Location = new System.Drawing.Point(181, 108);
            this.tb_cod_maquina.Margin = new System.Windows.Forms.Padding(4);
            this.tb_cod_maquina.Name = "tb_cod_maquina";
            this.tb_cod_maquina.Size = new System.Drawing.Size(49, 22);
            this.tb_cod_maquina.TabIndex = 122;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 121;
            this.label1.Text = "Código da Máquina";
            // 
            // datMaquinas
            // 
            this.datMaquinas.DeleteCommand = this.fbCommand4;
            this.datMaquinas.InsertCommand = this.fbCommand2;
            this.datMaquinas.SelectCommand = this.fbCommand1;
            this.datMaquinas.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * from maquinas";
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
            // cbMaquinas
            // 
            this.cbMaquinas.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbMaquinas.DataAdapter = this.datMaquinas;
            this.cbMaquinas.QuotePrefix = "\"";
            this.cbMaquinas.QuoteSuffix = "\"";
            // 
            // form_maquinas_old
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 330);
            this.Controls.Add(this.apaga_registro);
            this.Controls.Add(this.salva_registro);
            this.Controls.Add(this.vai_anterior);
            this.Controls.Add(this.vai_proximo);
            this.Controls.Add(this.vai_ultimo);
            this.Controls.Add(this.novo_registro);
            this.Controls.Add(this.vai_primeiro);
            this.Controls.Add(this.tb_abreviacao);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.tb_maquina);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_cod_maquina);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form_maquinas_old";
            this.Text = "Máquinas";
            this.Load += new System.EventHandler(this.form_maquinas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsMaquinas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MAQUINAS)).EndInit();
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
        private System.Windows.Forms.TextBox tb_abreviacao;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tb_maquina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_cod_maquina;
        private System.Windows.Forms.Label label1;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datMaquinas;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private System.Data.DataSet dsMaquinas;
        private System.Data.DataTable MAQUINAS;
        private System.Data.DataColumn COD_MAQUINA;
        private System.Data.DataColumn MAQUINA;
        private System.Data.DataColumn ABREVIACAO;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbMaquinas;
    }
}