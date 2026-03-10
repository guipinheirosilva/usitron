namespace Evolucao
{
    partial class form_tipos_refugo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_tipos_refugo));
            this.apaga_registro = new System.Windows.Forms.Button();
            this.salva_registro = new System.Windows.Forms.Button();
            this.vai_anterior = new System.Windows.Forms.Button();
            this.vai_proximo = new System.Windows.Forms.Button();
            this.vai_ultimo = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.novo_registro = new System.Windows.Forms.Button();
            this.vai_primeiro = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.textbox_refugo = new System.Windows.Forms.TextBox();
            this.dsTiposderefugo = new System.Data.DataSet();
            this.TIPOS_REFUGO = new System.Data.DataTable();
            this.COD_REFUGO = new System.Data.DataColumn();
            this.REFUGO = new System.Data.DataColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.textbox_cod_refugo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.datTipoderefugo = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommandBuilder1 = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposderefugo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TIPOS_REFUGO)).BeginInit();
            this.SuspendLayout();
            // 
            // apaga_registro
            // 
            this.apaga_registro.Location = new System.Drawing.Point(148, 201);
            this.apaga_registro.Name = "apaga_registro";
            this.apaga_registro.Size = new System.Drawing.Size(49, 22);
            this.apaga_registro.TabIndex = 150;
            this.apaga_registro.Text = "Excluir";
            this.apaga_registro.UseVisualStyleBackColor = true;
            // 
            // salva_registro
            // 
            this.salva_registro.Location = new System.Drawing.Point(203, 201);
            this.salva_registro.Name = "salva_registro";
            this.salva_registro.Size = new System.Drawing.Size(49, 22);
            this.salva_registro.TabIndex = 149;
            this.salva_registro.Text = "Salvar";
            this.salva_registro.UseVisualStyleBackColor = true;
            this.salva_registro.Click += new System.EventHandler(this.salva_registro_Click);
            // 
            // vai_anterior
            // 
            this.vai_anterior.Location = new System.Drawing.Point(89, 173);
            this.vai_anterior.Name = "vai_anterior";
            this.vai_anterior.Size = new System.Drawing.Size(49, 22);
            this.vai_anterior.TabIndex = 148;
            this.vai_anterior.Text = "<";
            this.vai_anterior.UseVisualStyleBackColor = true;
            this.vai_anterior.Click += new System.EventHandler(this.vai_anterior_Click);
            // 
            // vai_proximo
            // 
            this.vai_proximo.Location = new System.Drawing.Point(146, 173);
            this.vai_proximo.Name = "vai_proximo";
            this.vai_proximo.Size = new System.Drawing.Size(49, 22);
            this.vai_proximo.TabIndex = 147;
            this.vai_proximo.Text = ">";
            this.vai_proximo.UseVisualStyleBackColor = true;
            this.vai_proximo.Click += new System.EventHandler(this.vai_proximo_Click);
            // 
            // vai_ultimo
            // 
            this.vai_ultimo.Location = new System.Drawing.Point(201, 173);
            this.vai_ultimo.Name = "vai_ultimo";
            this.vai_ultimo.Size = new System.Drawing.Size(49, 22);
            this.vai_ultimo.TabIndex = 146;
            this.vai_ultimo.Text = ">>";
            this.vai_ultimo.UseVisualStyleBackColor = true;
            this.vai_ultimo.Click += new System.EventHandler(this.vai_ultimo_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(27, 201);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 22);
            this.button3.TabIndex = 145;
            this.button3.Text = "Localizar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // novo_registro
            // 
            this.novo_registro.Location = new System.Drawing.Point(93, 201);
            this.novo_registro.Name = "novo_registro";
            this.novo_registro.Size = new System.Drawing.Size(49, 22);
            this.novo_registro.TabIndex = 144;
            this.novo_registro.Text = "Novo";
            this.novo_registro.UseVisualStyleBackColor = true;
            this.novo_registro.Click += new System.EventHandler(this.novo_registro_Click);
            // 
            // vai_primeiro
            // 
            this.vai_primeiro.Location = new System.Drawing.Point(34, 173);
            this.vai_primeiro.Name = "vai_primeiro";
            this.vai_primeiro.Size = new System.Drawing.Size(49, 22);
            this.vai_primeiro.TabIndex = 143;
            this.vai_primeiro.Text = "<<";
            this.vai_primeiro.UseVisualStyleBackColor = true;
            this.vai_primeiro.Click += new System.EventHandler(this.vai_primeiro_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label20.Location = new System.Drawing.Point(47, 43);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(193, 29);
            this.label20.TabIndex = 140;
            this.label20.Text = "Tipos de Refugo";
            // 
            // textbox_refugo
            // 
            this.textbox_refugo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTiposderefugo, "TIPOS_REFUGO.REFUGO", true));
            this.textbox_refugo.Location = new System.Drawing.Point(129, 114);
            this.textbox_refugo.Name = "textbox_refugo";
            this.textbox_refugo.Size = new System.Drawing.Size(136, 20);
            this.textbox_refugo.TabIndex = 139;
            // 
            // dsTiposderefugo
            // 
            this.dsTiposderefugo.DataSetName = "dsTiposderefugo";
            this.dsTiposderefugo.Namespace = "http://www.tempuri.org/dsTiposderefugo.xsd";
            this.dsTiposderefugo.Tables.AddRange(new System.Data.DataTable[] {
            this.TIPOS_REFUGO});
            // 
            // TIPOS_REFUGO
            // 
            this.TIPOS_REFUGO.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_REFUGO,
            this.REFUGO});
            this.TIPOS_REFUGO.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_REFUGO"}, true)});
            this.TIPOS_REFUGO.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_REFUGO};
            this.TIPOS_REFUGO.TableName = "TIPOS_REFUGO";
            // 
            // COD_REFUGO
            // 
            this.COD_REFUGO.AllowDBNull = false;
            this.COD_REFUGO.AutoIncrement = true;
            this.COD_REFUGO.ColumnName = "COD_REFUGO";
            this.COD_REFUGO.DataType = typeof(int);
            // 
            // REFUGO
            // 
            this.REFUGO.ColumnName = "REFUGO";
            this.REFUGO.MaxLength = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 138;
            this.label2.Text = "Refugo:";
            // 
            // textbox_cod_refugo
            // 
            this.textbox_cod_refugo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTiposderefugo, "TIPOS_REFUGO.COD_REFUGO", true));
            this.textbox_cod_refugo.Location = new System.Drawing.Point(129, 88);
            this.textbox_cod_refugo.Name = "textbox_cod_refugo";
            this.textbox_cod_refugo.Size = new System.Drawing.Size(38, 20);
            this.textbox_cod_refugo.TabIndex = 137;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 136;
            this.label1.Text = "Código do Refugo:";
            // 
            // fbConnection1
            // 
            this.fbConnection1.ConnectionString = resources.GetString("fbConnection1.ConnectionString");
            // 
            // datTipoderefugo
            // 
            this.datTipoderefugo.DeleteCommand = this.fbCommand4;
            this.datTipoderefugo.InsertCommand = this.fbCommand2;
            this.datTipoderefugo.SelectCommand = this.fbCommand1;
            this.datTipoderefugo.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "SELECT * FROM TIPOS_REFUGO";
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
            this.fbCommandBuilder1.DataAdapter = this.datTipoderefugo;
            this.fbCommandBuilder1.QuotePrefix = "\"";
            this.fbCommandBuilder1.QuoteSuffix = "\"";
            // 
            // form_tipos_refugo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 267);
            this.Controls.Add(this.apaga_registro);
            this.Controls.Add(this.salva_registro);
            this.Controls.Add(this.vai_anterior);
            this.Controls.Add(this.vai_proximo);
            this.Controls.Add(this.vai_ultimo);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.novo_registro);
            this.Controls.Add(this.vai_primeiro);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.textbox_refugo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textbox_cod_refugo);
            this.Controls.Add(this.label1);
            this.Name = "form_tipos_refugo";
            this.Text = "Tipos de Refugo";
            this.Load += new System.EventHandler(this.form_tipos_refugo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposderefugo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TIPOS_REFUGO)).EndInit();
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
        private System.Windows.Forms.TextBox textbox_refugo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textbox_cod_refugo;
        private System.Windows.Forms.Label label1;
        private System.Data.DataSet dsTiposderefugo;
        private System.Data.DataTable TIPOS_REFUGO;
        private System.Data.DataColumn COD_REFUGO;
        private System.Data.DataColumn REFUGO;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datTipoderefugo;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder fbCommandBuilder1;
    }
}