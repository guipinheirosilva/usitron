namespace Evolucao
{
    partial class form_tipos_parada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_tipos_parada));
            this.apaga_registro = new System.Windows.Forms.Button();
            this.salva_registro = new System.Windows.Forms.Button();
            this.vai_anterior = new System.Windows.Forms.Button();
            this.vai_proximo = new System.Windows.Forms.Button();
            this.vai_ultimo = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.novo_registro = new System.Windows.Forms.Button();
            this.vai_primeiro = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.textbox_tipo_parada = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textbox_cod_parada = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.datTiposdeparada = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommandBuilder1 = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.dsTiposdeparada = new System.Data.DataSet();
            this.TIPOS_PARADA = new System.Data.DataTable();
            this.COD_TIPO_PARADA = new System.Data.DataColumn();
            this.DESCRICAO_TIPO_PARADA = new System.Data.DataColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposdeparada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TIPOS_PARADA)).BeginInit();
            this.SuspendLayout();
            // 
            // apaga_registro
            // 
            this.apaga_registro.Location = new System.Drawing.Point(136, 167);
            this.apaga_registro.Name = "apaga_registro";
            this.apaga_registro.Size = new System.Drawing.Size(49, 22);
            this.apaga_registro.TabIndex = 135;
            this.apaga_registro.Text = "Excluir";
            this.apaga_registro.UseVisualStyleBackColor = true;
            // 
            // salva_registro
            // 
            this.salva_registro.Location = new System.Drawing.Point(191, 167);
            this.salva_registro.Name = "salva_registro";
            this.salva_registro.Size = new System.Drawing.Size(49, 22);
            this.salva_registro.TabIndex = 134;
            this.salva_registro.Text = "Salvar";
            this.salva_registro.UseVisualStyleBackColor = true;
            this.salva_registro.Click += new System.EventHandler(this.salva_registro_Click);
            // 
            // vai_anterior
            // 
            this.vai_anterior.Location = new System.Drawing.Point(77, 139);
            this.vai_anterior.Name = "vai_anterior";
            this.vai_anterior.Size = new System.Drawing.Size(49, 22);
            this.vai_anterior.TabIndex = 133;
            this.vai_anterior.Text = "<";
            this.vai_anterior.UseVisualStyleBackColor = true;
            this.vai_anterior.Click += new System.EventHandler(this.vai_anterior_Click);
            // 
            // vai_proximo
            // 
            this.vai_proximo.Location = new System.Drawing.Point(134, 139);
            this.vai_proximo.Name = "vai_proximo";
            this.vai_proximo.Size = new System.Drawing.Size(49, 22);
            this.vai_proximo.TabIndex = 132;
            this.vai_proximo.Text = ">";
            this.vai_proximo.UseVisualStyleBackColor = true;
            this.vai_proximo.Click += new System.EventHandler(this.vai_proximo_Click);
            // 
            // vai_ultimo
            // 
            this.vai_ultimo.Location = new System.Drawing.Point(189, 139);
            this.vai_ultimo.Name = "vai_ultimo";
            this.vai_ultimo.Size = new System.Drawing.Size(49, 22);
            this.vai_ultimo.TabIndex = 131;
            this.vai_ultimo.Text = ">>";
            this.vai_ultimo.UseVisualStyleBackColor = true;
            this.vai_ultimo.Click += new System.EventHandler(this.vai_ultimo_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(15, 167);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 22);
            this.button3.TabIndex = 130;
            this.button3.Text = "Localizar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // novo_registro
            // 
            this.novo_registro.Location = new System.Drawing.Point(81, 167);
            this.novo_registro.Name = "novo_registro";
            this.novo_registro.Size = new System.Drawing.Size(49, 22);
            this.novo_registro.TabIndex = 129;
            this.novo_registro.Text = "Novo";
            this.novo_registro.UseVisualStyleBackColor = true;
            this.novo_registro.Click += new System.EventHandler(this.novo_registro_Click);
            // 
            // vai_primeiro
            // 
            this.vai_primeiro.Location = new System.Drawing.Point(22, 139);
            this.vai_primeiro.Name = "vai_primeiro";
            this.vai_primeiro.Size = new System.Drawing.Size(49, 22);
            this.vai_primeiro.TabIndex = 128;
            this.vai_primeiro.Text = "<<";
            this.vai_primeiro.UseVisualStyleBackColor = true;
            this.vai_primeiro.Click += new System.EventHandler(this.vai_primeiro_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label20.Location = new System.Drawing.Point(35, 9);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(192, 29);
            this.label20.TabIndex = 125;
            this.label20.Text = "Tipos de Parada";
            // 
            // textbox_tipo_parada
            // 
            this.textbox_tipo_parada.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTiposdeparada, "TIPOS_PARADA.DESCRICAO_TIPO_PARADA", true));
            this.textbox_tipo_parada.Location = new System.Drawing.Point(117, 80);
            this.textbox_tipo_parada.Name = "textbox_tipo_parada";
            this.textbox_tipo_parada.Size = new System.Drawing.Size(136, 20);
            this.textbox_tipo_parada.TabIndex = 124;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 123;
            this.label2.Text = "Tipo de parada:";
            // 
            // textbox_cod_parada
            // 
            this.textbox_cod_parada.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTiposdeparada, "TIPOS_PARADA.COD_TIPO_PARADA", true));
            this.textbox_cod_parada.Location = new System.Drawing.Point(117, 54);
            this.textbox_cod_parada.Name = "textbox_cod_parada";
            this.textbox_cod_parada.Size = new System.Drawing.Size(38, 20);
            this.textbox_cod_parada.TabIndex = 122;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 121;
            this.label1.Text = "Código da Parada:";
            // 
            // fbConnection1
            // 
            this.fbConnection1.ConnectionString = resources.GetString("fbConnection1.ConnectionString");
            // 
            // datTiposdeparada
            // 
            this.datTiposdeparada.DeleteCommand = this.fbCommand4;
            this.datTiposdeparada.InsertCommand = this.fbCommand2;
            this.datTiposdeparada.SelectCommand = this.fbCommand1;
            this.datTiposdeparada.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "SELECT * FROM TIPOS_PARADA";
            this.fbCommand1.CommandTimeout = 30;
            this.fbCommand1.Connection = this.fbConnection1;
            // 
            // fbCommand3
            // 
            this.fbCommand3.CommandTimeout = 30;
            // 
            // fbCommandBuilder1
            // 
            this.fbCommandBuilder1.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.fbCommandBuilder1.DataAdapter = this.datTiposdeparada;
            this.fbCommandBuilder1.QuotePrefix = "\"";
            this.fbCommandBuilder1.QuoteSuffix = "\"";
            // 
            // dsTiposdeparada
            // 
            this.dsTiposdeparada.DataSetName = "dsTiposdeparada";
            this.dsTiposdeparada.Namespace = "http://www.tempuri.org/dsTipos_parada.xsd";
            this.dsTiposdeparada.Tables.AddRange(new System.Data.DataTable[] {
            this.TIPOS_PARADA});
            // 
            // TIPOS_PARADA
            // 
            this.TIPOS_PARADA.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_TIPO_PARADA,
            this.DESCRICAO_TIPO_PARADA});
            this.TIPOS_PARADA.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_TIPO_PARADA"}, true)});
            this.TIPOS_PARADA.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_TIPO_PARADA};
            this.TIPOS_PARADA.TableName = "TIPOS_PARADA";
            // 
            // COD_TIPO_PARADA
            // 
            this.COD_TIPO_PARADA.AllowDBNull = false;
            this.COD_TIPO_PARADA.AutoIncrement = true;
            this.COD_TIPO_PARADA.AutoIncrementSeed = ((long)(1));
            this.COD_TIPO_PARADA.ColumnName = "COD_TIPO_PARADA";
            this.COD_TIPO_PARADA.DataType = typeof(int);
            // 
            // DESCRICAO_TIPO_PARADA
            // 
            this.DESCRICAO_TIPO_PARADA.ColumnName = "DESCRICAO_TIPO_PARADA";
            this.DESCRICAO_TIPO_PARADA.MaxLength = 20;
            // 
            // form_tipos_parada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 207);
            this.Controls.Add(this.apaga_registro);
            this.Controls.Add(this.salva_registro);
            this.Controls.Add(this.vai_anterior);
            this.Controls.Add(this.vai_proximo);
            this.Controls.Add(this.vai_ultimo);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.novo_registro);
            this.Controls.Add(this.vai_primeiro);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.textbox_tipo_parada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textbox_cod_parada);
            this.Controls.Add(this.label1);
            this.Name = "form_tipos_parada";
            this.Text = "Tipos de Parada";
            this.Load += new System.EventHandler(this.form_tipos_parada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposdeparada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TIPOS_PARADA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button apaga_registro;
        private System.Windows.Forms.Button salva_registro;
        private System.Windows.Forms.Button vai_anterior;
        private System.Windows.Forms.Button vai_proximo;
        private System.Windows.Forms.Button vai_ultimo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button novo_registro;
        private System.Windows.Forms.Button vai_primeiro;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textbox_tipo_parada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textbox_cod_parada;
        private System.Windows.Forms.Label label1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datTiposdeparada;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder fbCommandBuilder1;
        private System.Data.DataSet dsTiposdeparada;
        private System.Data.DataTable TIPOS_PARADA;
        private System.Data.DataColumn COD_TIPO_PARADA;
        private System.Data.DataColumn DESCRICAO_TIPO_PARADA;
    }
}