namespace Evolucao
{
    partial class form_periodo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_periodo));
            this.label20 = new System.Windows.Forms.Label();
            this.textbox_cod = new System.Windows.Forms.TextBox();
            this.dsPeriodos = new System.Data.DataSet();
            this.PERIODOS = new System.Data.DataTable();
            this.COD_PERIODO = new System.Data.DataColumn();
            this.DATA_INICIAL_PERIODO = new System.Data.DataColumn();
            this.DATA_FINAL_PERIODO = new System.Data.DataColumn();
            this.DIAS_PERIODO = new System.Data.DataColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dtInicial = new System.Windows.Forms.DateTimePicker();
            this.dtFinal = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.apaga_registro = new System.Windows.Forms.Button();
            this.salva_registro = new System.Windows.Forms.Button();
            this.novo_registro = new System.Windows.Forms.Button();
            this.datPeriodos = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.cbPeriodos = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.vai_anterior = new System.Windows.Forms.Button();
            this.vai_proximo = new System.Windows.Forms.Button();
            this.vai_ultimo = new System.Windows.Forms.Button();
            this.vai_primeiro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dsPeriodos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PERIODOS)).BeginInit();
            this.SuspendLayout();
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label20.Location = new System.Drawing.Point(168, 7);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(179, 46);
            this.label20.TabIndex = 112;
            this.label20.Text = "Períodos";
            // 
            // textbox_cod
            // 
            this.textbox_cod.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPeriodos, "PERIODOS.COD_PERIODO", true));
            this.textbox_cod.Location = new System.Drawing.Point(288, 67);
            this.textbox_cod.Name = "textbox_cod";
            this.textbox_cod.Size = new System.Drawing.Size(52, 20);
            this.textbox_cod.TabIndex = 110;
            // 
            // dsPeriodos
            // 
            this.dsPeriodos.DataSetName = "dsPeriodos";
            this.dsPeriodos.Namespace = "http://www.tempuri.org/dsPeriodos.xsd";
            this.dsPeriodos.Tables.AddRange(new System.Data.DataTable[] {
            this.PERIODOS});
            // 
            // PERIODOS
            // 
            this.PERIODOS.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_PERIODO,
            this.DATA_INICIAL_PERIODO,
            this.DATA_FINAL_PERIODO,
            this.DIAS_PERIODO});
            this.PERIODOS.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_PERIODO"}, true)});
            this.PERIODOS.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_PERIODO};
            this.PERIODOS.TableName = "PERIODOS";
            // 
            // COD_PERIODO
            // 
            this.COD_PERIODO.AllowDBNull = false;
            this.COD_PERIODO.ColumnName = "COD_PERIODO";
            this.COD_PERIODO.DataType = typeof(int);
            // 
            // DATA_INICIAL_PERIODO
            // 
            this.DATA_INICIAL_PERIODO.ColumnName = "DATA_INICIAL_PERIODO";
            this.DATA_INICIAL_PERIODO.DataType = typeof(System.DateTime);
            // 
            // DATA_FINAL_PERIODO
            // 
            this.DATA_FINAL_PERIODO.ColumnName = "DATA_FINAL_PERIODO";
            this.DATA_FINAL_PERIODO.DataType = typeof(System.DateTime);
            // 
            // DIAS_PERIODO
            // 
            this.DIAS_PERIODO.ColumnName = "DIAS_PERIODO";
            this.DIAS_PERIODO.DataType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 111;
            this.label1.Text = "Código do Período:";
            // 
            // dtInicial
            // 
            this.dtInicial.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPeriodos, "PERIODOS.DATA_INICIAL_PERIODO", true));
            this.dtInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicial.Location = new System.Drawing.Point(32, 119);
            this.dtInicial.Name = "dtInicial";
            this.dtInicial.Size = new System.Drawing.Size(200, 20);
            this.dtInicial.TabIndex = 113;
            // 
            // dtFinal
            // 
            this.dtFinal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPeriodos, "PERIODOS.DATA_FINAL_PERIODO", true));
            this.dtFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFinal.Location = new System.Drawing.Point(285, 119);
            this.dtFinal.Name = "dtFinal";
            this.dtFinal.Size = new System.Drawing.Size(200, 20);
            this.dtFinal.TabIndex = 114;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPeriodos, "PERIODOS.DIAS_PERIODO", true));
            this.textBox1.Location = new System.Drawing.Point(258, 157);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(82, 20);
            this.textBox1.TabIndex = 115;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 116;
            this.label2.Text = "Número de Dias:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 117;
            this.label3.Text = "Data Inicial:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 118;
            this.label4.Text = "Data Final:";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(148, 225);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 22);
            this.button3.TabIndex = 132;
            this.button3.Text = "Escolher";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // apaga_registro
            // 
            this.apaga_registro.Location = new System.Drawing.Point(269, 225);
            this.apaga_registro.Name = "apaga_registro";
            this.apaga_registro.Size = new System.Drawing.Size(49, 22);
            this.apaga_registro.TabIndex = 131;
            this.apaga_registro.Text = "Excluir";
            this.apaga_registro.UseVisualStyleBackColor = true;
            this.apaga_registro.Click += new System.EventHandler(this.apaga_registro_Click);
            // 
            // salva_registro
            // 
            this.salva_registro.Location = new System.Drawing.Point(324, 225);
            this.salva_registro.Name = "salva_registro";
            this.salva_registro.Size = new System.Drawing.Size(49, 22);
            this.salva_registro.TabIndex = 130;
            this.salva_registro.Text = "Salvar";
            this.salva_registro.UseVisualStyleBackColor = true;
            this.salva_registro.Click += new System.EventHandler(this.salva_registro_Click);
            // 
            // novo_registro
            // 
            this.novo_registro.Location = new System.Drawing.Point(214, 225);
            this.novo_registro.Name = "novo_registro";
            this.novo_registro.Size = new System.Drawing.Size(49, 22);
            this.novo_registro.TabIndex = 129;
            this.novo_registro.Text = "Novo";
            this.novo_registro.UseVisualStyleBackColor = true;
            this.novo_registro.Click += new System.EventHandler(this.novo_registro_Click);
            // 
            // datPeriodos
            // 
            this.datPeriodos.DeleteCommand = this.fbCommand4;
            this.datPeriodos.InsertCommand = this.fbCommand2;
            this.datPeriodos.SelectCommand = this.fbCommand1;
            this.datPeriodos.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * from periodos";
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
            // cbPeriodos
            // 
            this.cbPeriodos.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbPeriodos.DataAdapter = this.datPeriodos;
            this.cbPeriodos.QuotePrefix = "\"";
            this.cbPeriodos.QuoteSuffix = "\"";
            // 
            // vai_anterior
            // 
            this.vai_anterior.Location = new System.Drawing.Point(212, 197);
            this.vai_anterior.Name = "vai_anterior";
            this.vai_anterior.Size = new System.Drawing.Size(49, 22);
            this.vai_anterior.TabIndex = 136;
            this.vai_anterior.Text = "<";
            this.vai_anterior.UseVisualStyleBackColor = true;
            this.vai_anterior.Click += new System.EventHandler(this.vai_anterior_Click);
            // 
            // vai_proximo
            // 
            this.vai_proximo.Location = new System.Drawing.Point(269, 197);
            this.vai_proximo.Name = "vai_proximo";
            this.vai_proximo.Size = new System.Drawing.Size(49, 22);
            this.vai_proximo.TabIndex = 135;
            this.vai_proximo.Text = ">";
            this.vai_proximo.UseVisualStyleBackColor = true;
            this.vai_proximo.Click += new System.EventHandler(this.vai_proximo_Click);
            // 
            // vai_ultimo
            // 
            this.vai_ultimo.Location = new System.Drawing.Point(324, 197);
            this.vai_ultimo.Name = "vai_ultimo";
            this.vai_ultimo.Size = new System.Drawing.Size(49, 22);
            this.vai_ultimo.TabIndex = 134;
            this.vai_ultimo.Text = ">>";
            this.vai_ultimo.UseVisualStyleBackColor = true;
            this.vai_ultimo.Click += new System.EventHandler(this.vai_ultimo_Click);
            // 
            // vai_primeiro
            // 
            this.vai_primeiro.Location = new System.Drawing.Point(157, 197);
            this.vai_primeiro.Name = "vai_primeiro";
            this.vai_primeiro.Size = new System.Drawing.Size(49, 22);
            this.vai_primeiro.TabIndex = 133;
            this.vai_primeiro.Text = "<<";
            this.vai_primeiro.UseVisualStyleBackColor = true;
            this.vai_primeiro.Click += new System.EventHandler(this.vai_primeiro_Click);
            // 
            // form_periodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 264);
            this.Controls.Add(this.vai_anterior);
            this.Controls.Add(this.vai_proximo);
            this.Controls.Add(this.vai_ultimo);
            this.Controls.Add(this.vai_primeiro);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.apaga_registro);
            this.Controls.Add(this.salva_registro);
            this.Controls.Add(this.novo_registro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtFinal);
            this.Controls.Add(this.dtInicial);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.textbox_cod);
            this.Controls.Add(this.label1);
            this.Name = "form_periodo";
            this.Text = "Períodos";
            this.Load += new System.EventHandler(this.form_periodo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsPeriodos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PERIODOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textbox_cod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtInicial;
        private System.Windows.Forms.DateTimePicker dtFinal;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button apaga_registro;
        private System.Windows.Forms.Button salva_registro;
        private System.Windows.Forms.Button novo_registro;
        private System.Data.DataSet dsPeriodos;
        private System.Data.DataTable PERIODOS;
        private System.Data.DataColumn COD_PERIODO;
        private System.Data.DataColumn DATA_INICIAL_PERIODO;
        private System.Data.DataColumn DATA_FINAL_PERIODO;
        private System.Data.DataColumn DIAS_PERIODO;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datPeriodos;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbPeriodos;
        private System.Windows.Forms.Button vai_anterior;
        private System.Windows.Forms.Button vai_proximo;
        private System.Windows.Forms.Button vai_ultimo;
        private System.Windows.Forms.Button vai_primeiro;
    }
}