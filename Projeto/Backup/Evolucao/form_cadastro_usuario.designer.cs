namespace Evolucao
{
    partial class form_cadastro_usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_cadastro_usuario));
            this.label20 = new System.Windows.Forms.Label();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.dsUsuarios = new System.Data.DataSet();
            this.USUARIOS = new System.Data.DataTable();
            this.COD_USUARIO = new System.Data.DataColumn();
            this.NOME_USUARIO = new System.Data.DataColumn();
            this.SENHA_USUARIO = new System.Data.DataColumn();
            this.NIVEL_ACESSO_USUARIO = new System.Data.DataColumn();
            this.DESCRICAO_NIVEL_ACESSO_USUARIO = new System.Data.DataColumn();
            this.PCP_USUARIO = new System.Data.DataColumn();
            this.FATURAMENTO_USUARIO = new System.Data.DataColumn();
            this.ESTOQUE_USUARIO = new System.Data.DataColumn();
            this.COMPRAS_USUARIO = new System.Data.DataColumn();
            this.FINANCEIRO_USUARIO = new System.Data.DataColumn();
            this.ORCAMENTOS_USUARIO = new System.Data.DataColumn();
            this.QUALIDADE_USUARIO = new System.Data.DataColumn();
            this.TOTAL_USUARIO = new System.Data.DataColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_codigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.apaga_registro = new System.Windows.Forms.Button();
            this.salva_registro = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.novo_registro = new System.Windows.Forms.Button();
            this.datUsuarios = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.cbUsuarios = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.tb_nivel_acesso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxCte = new System.Windows.Forms.CheckBox();
            this.dataColumn1 = new System.Data.DataColumn();
            this.cbxOrcamentos = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dsUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.USUARIOS)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label20.Location = new System.Drawing.Point(86, 9);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(229, 46);
            this.label20.TabIndex = 49;
            this.label20.Text = "USUÁRIOS";
            // 
            // tb_senha
            // 
            this.tb_senha.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsUsuarios, "USUARIOS.SENHA_USUARIO", true));
            this.tb_senha.Location = new System.Drawing.Point(106, 110);
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.Size = new System.Drawing.Size(83, 20);
            this.tb_senha.TabIndex = 52;
            this.tb_senha.UseSystemPasswordChar = true;
            // 
            // dsUsuarios
            // 
            this.dsUsuarios.DataSetName = "dsUsuarios";
            this.dsUsuarios.Namespace = "http://www.tempuri.org/dsUsuarios.xsd";
            this.dsUsuarios.Tables.AddRange(new System.Data.DataTable[] {
            this.USUARIOS});
            // 
            // USUARIOS
            // 
            this.USUARIOS.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_USUARIO,
            this.NOME_USUARIO,
            this.SENHA_USUARIO,
            this.NIVEL_ACESSO_USUARIO,
            this.DESCRICAO_NIVEL_ACESSO_USUARIO,
            this.PCP_USUARIO,
            this.FATURAMENTO_USUARIO,
            this.ESTOQUE_USUARIO,
            this.COMPRAS_USUARIO,
            this.FINANCEIRO_USUARIO,
            this.ORCAMENTOS_USUARIO,
            this.QUALIDADE_USUARIO,
            this.TOTAL_USUARIO,
            this.dataColumn1});
            this.USUARIOS.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_USUARIO"}, true)});
            this.USUARIOS.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_USUARIO};
            this.USUARIOS.TableName = "USUARIOS";
            // 
            // COD_USUARIO
            // 
            this.COD_USUARIO.AllowDBNull = false;
            this.COD_USUARIO.ColumnName = "COD_USUARIO";
            this.COD_USUARIO.DataType = typeof(int);
            // 
            // NOME_USUARIO
            // 
            this.NOME_USUARIO.ColumnName = "NOME_USUARIO";
            this.NOME_USUARIO.MaxLength = 50;
            // 
            // SENHA_USUARIO
            // 
            this.SENHA_USUARIO.ColumnName = "SENHA_USUARIO";
            this.SENHA_USUARIO.MaxLength = 20;
            // 
            // NIVEL_ACESSO_USUARIO
            // 
            this.NIVEL_ACESSO_USUARIO.ColumnName = "NIVEL_ACESSO_USUARIO";
            this.NIVEL_ACESSO_USUARIO.DataType = typeof(int);
            // 
            // DESCRICAO_NIVEL_ACESSO_USUARIO
            // 
            this.DESCRICAO_NIVEL_ACESSO_USUARIO.ColumnName = "DESCRICAO_NIVEL_ACESSO_USUARIO";
            this.DESCRICAO_NIVEL_ACESSO_USUARIO.MaxLength = 100;
            // 
            // PCP_USUARIO
            // 
            this.PCP_USUARIO.ColumnName = "PCP_USUARIO";
            this.PCP_USUARIO.DataType = typeof(int);
            // 
            // FATURAMENTO_USUARIO
            // 
            this.FATURAMENTO_USUARIO.ColumnName = "FATURAMENTO_USUARIO";
            this.FATURAMENTO_USUARIO.DataType = typeof(int);
            // 
            // ESTOQUE_USUARIO
            // 
            this.ESTOQUE_USUARIO.ColumnName = "ESTOQUE_USUARIO";
            this.ESTOQUE_USUARIO.DataType = typeof(int);
            // 
            // COMPRAS_USUARIO
            // 
            this.COMPRAS_USUARIO.ColumnName = "COMPRAS_USUARIO";
            this.COMPRAS_USUARIO.DataType = typeof(int);
            // 
            // FINANCEIRO_USUARIO
            // 
            this.FINANCEIRO_USUARIO.ColumnName = "FINANCEIRO_USUARIO";
            this.FINANCEIRO_USUARIO.DataType = typeof(int);
            // 
            // ORCAMENTOS_USUARIO
            // 
            this.ORCAMENTOS_USUARIO.ColumnName = "ORCAMENTOS_USUARIO";
            this.ORCAMENTOS_USUARIO.DataType = typeof(int);
            // 
            // QUALIDADE_USUARIO
            // 
            this.QUALIDADE_USUARIO.ColumnName = "QUALIDADE_USUARIO";
            this.QUALIDADE_USUARIO.DataType = typeof(int);
            // 
            // TOTAL_USUARIO
            // 
            this.TOTAL_USUARIO.ColumnName = "TOTAL_USUARIO";
            this.TOTAL_USUARIO.DataType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "Senha:";
            // 
            // tb_nome
            // 
            this.tb_nome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsUsuarios, "USUARIOS.NOME_USUARIO", true));
            this.tb_nome.Location = new System.Drawing.Point(106, 84);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(265, 20);
            this.tb_nome.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "Nome Completo:";
            // 
            // tb_codigo
            // 
            this.tb_codigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsUsuarios, "USUARIOS.COD_USUARIO", true));
            this.tb_codigo.Location = new System.Drawing.Point(106, 58);
            this.tb_codigo.Name = "tb_codigo";
            this.tb_codigo.Size = new System.Drawing.Size(52, 20);
            this.tb_codigo.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Código:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxOrcamentos);
            this.groupBox1.Controls.Add(this.cbxCte);
            this.groupBox1.Controls.Add(this.checkBox7);
            this.groupBox1.Controls.Add(this.checkBox6);
            this.groupBox1.Controls.Add(this.checkBox5);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(19, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 97);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acessos";
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsUsuarios, "USUARIOS.QUALIDADE_USUARIO", true));
            this.checkBox7.Location = new System.Drawing.Point(6, 64);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(74, 17);
            this.checkBox7.TabIndex = 6;
            this.checkBox7.Text = "Qualidade";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsUsuarios, "USUARIOS.FINANCEIRO_USUARIO", true));
            this.checkBox6.Location = new System.Drawing.Point(277, 64);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(75, 17);
            this.checkBox6.TabIndex = 5;
            this.checkBox6.Text = "Financeiro";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsUsuarios, "USUARIOS.COMPRAS_USUARIO", true));
            this.checkBox5.Location = new System.Drawing.Point(161, 64);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(67, 17);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "Compras";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsUsuarios, "USUARIOS.ESTOQUE_USUARIO", true));
            this.checkBox4.Location = new System.Drawing.Point(6, 41);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(65, 17);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Estoque";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsUsuarios, "USUARIOS.FATURAMENTO_USUARIO", true));
            this.checkBox3.Location = new System.Drawing.Point(277, 41);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(85, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Faturamento";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsUsuarios, "USUARIOS.PCP_USUARIO", true));
            this.checkBox2.Location = new System.Drawing.Point(161, 41);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(47, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "PCP";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsUsuarios, "USUARIOS.TOTAL_USUARIO", true));
            this.checkBox1.Location = new System.Drawing.Point(161, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(50, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Total";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // apaga_registro
            // 
            this.apaga_registro.Location = new System.Drawing.Point(211, 277);
            this.apaga_registro.Name = "apaga_registro";
            this.apaga_registro.Size = new System.Drawing.Size(49, 22);
            this.apaga_registro.TabIndex = 58;
            this.apaga_registro.Text = "Excluir";
            this.apaga_registro.UseVisualStyleBackColor = true;
            this.apaga_registro.Click += new System.EventHandler(this.apaga_registro_Click);
            // 
            // salva_registro
            // 
            this.salva_registro.Location = new System.Drawing.Point(266, 277);
            this.salva_registro.Name = "salva_registro";
            this.salva_registro.Size = new System.Drawing.Size(49, 22);
            this.salva_registro.TabIndex = 57;
            this.salva_registro.Text = "Salvar";
            this.salva_registro.UseVisualStyleBackColor = true;
            this.salva_registro.Click += new System.EventHandler(this.salva_registro_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(90, 277);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 22);
            this.button3.TabIndex = 60;
            this.button3.Text = "Localizar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // novo_registro
            // 
            this.novo_registro.Location = new System.Drawing.Point(156, 277);
            this.novo_registro.Name = "novo_registro";
            this.novo_registro.Size = new System.Drawing.Size(49, 22);
            this.novo_registro.TabIndex = 59;
            this.novo_registro.Text = "Novo";
            this.novo_registro.UseVisualStyleBackColor = true;
            this.novo_registro.Click += new System.EventHandler(this.novo_registro_Click);
            // 
            // datUsuarios
            // 
            this.datUsuarios.DeleteCommand = this.fbCommand4;
            this.datUsuarios.InsertCommand = this.fbCommand2;
            this.datUsuarios.SelectCommand = this.fbCommand1;
            this.datUsuarios.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * from usuarios";
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
            // cbUsuarios
            // 
            this.cbUsuarios.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbUsuarios.DataAdapter = this.datUsuarios;
            this.cbUsuarios.QuotePrefix = "\"";
            this.cbUsuarios.QuoteSuffix = "\"";
            // 
            // tb_nivel_acesso
            // 
            this.tb_nivel_acesso.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsUsuarios, "USUARIOS.NIVEL_ACESSO_USUARIO", true));
            this.tb_nivel_acesso.Location = new System.Drawing.Point(106, 136);
            this.tb_nivel_acesso.Name = "tb_nivel_acesso";
            this.tb_nivel_acesso.Size = new System.Drawing.Size(52, 20);
            this.tb_nivel_acesso.TabIndex = 62;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 61;
            this.label4.Text = "Nível Acesso:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(164, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 39);
            this.label5.TabIndex = 63;
            this.label5.Text = "0 - Nenhuma\r\n1 - Todas as Autorizações\r\n2 - Apenas Requisições";
            // 
            // cbxCte
            // 
            this.cbxCte.AutoSize = true;
            this.cbxCte.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsUsuarios, "USUARIOS.TRANSPORTES_USUARIO", true));
            this.cbxCte.Location = new System.Drawing.Point(6, 19);
            this.cbxCte.Name = "cbxCte";
            this.cbxCte.Size = new System.Drawing.Size(82, 17);
            this.cbxCte.TabIndex = 7;
            this.cbxCte.Text = "Transportes";
            this.cbxCte.UseVisualStyleBackColor = true;
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "TRANSPORTES_USUARIO";
            this.dataColumn1.DataType = typeof(int);
            // 
            // cbxOrcamentos
            // 
            this.cbxOrcamentos.AutoSize = true;
            this.cbxOrcamentos.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsUsuarios, "USUARIOS.ORCAMENTOS_USUARIO", true));
            this.cbxOrcamentos.Location = new System.Drawing.Point(277, 19);
            this.cbxOrcamentos.Name = "cbxOrcamentos";
            this.cbxOrcamentos.Size = new System.Drawing.Size(83, 17);
            this.cbxOrcamentos.TabIndex = 8;
            this.cbxOrcamentos.Text = "Orçamentos";
            this.cbxOrcamentos.UseVisualStyleBackColor = true;
            // 
            // form_cadastro_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 311);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_nivel_acesso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.apaga_registro);
            this.Controls.Add(this.salva_registro);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.novo_registro);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tb_senha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_codigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label20);
            this.Name = "form_cadastro_usuario";
            this.Text = "Cadastro Usuários";
            ((System.ComponentModel.ISupportInitialize)(this.dsUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.USUARIOS)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tb_senha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_codigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button apaga_registro;
        private System.Windows.Forms.Button salva_registro;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button novo_registro;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datUsuarios;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Data.DataSet dsUsuarios;
        private System.Data.DataTable USUARIOS;
        private System.Data.DataColumn COD_USUARIO;
        private System.Data.DataColumn NOME_USUARIO;
        private System.Data.DataColumn SENHA_USUARIO;
        private System.Data.DataColumn NIVEL_ACESSO_USUARIO;
        private System.Data.DataColumn DESCRICAO_NIVEL_ACESSO_USUARIO;
        private System.Data.DataColumn PCP_USUARIO;
        private System.Data.DataColumn FATURAMENTO_USUARIO;
        private System.Data.DataColumn ESTOQUE_USUARIO;
        private System.Data.DataColumn COMPRAS_USUARIO;
        private System.Data.DataColumn FINANCEIRO_USUARIO;
        private System.Data.DataColumn ORCAMENTOS_USUARIO;
        private System.Data.DataColumn QUALIDADE_USUARIO;
        private System.Data.DataColumn TOTAL_USUARIO;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbUsuarios;
        private System.Windows.Forms.TextBox tb_nivel_acesso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Data.DataColumn dataColumn1;
        private System.Windows.Forms.CheckBox cbxCte;
        private System.Windows.Forms.CheckBox cbxOrcamentos;
    }
}