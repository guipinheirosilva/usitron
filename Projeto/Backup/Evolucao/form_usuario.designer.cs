namespace Evolucao
{
    partial class form_usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_usuario));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_usuario = new System.Windows.Forms.TextBox();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.datUsuarios = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsUsuarios = new System.Data.DataSet();
            this.USUARIOS = new System.Data.DataTable();
            this.COD_USUARIO = new System.Data.DataColumn();
            this.NOME_USUARIO = new System.Data.DataColumn();
            this.SENHA_USUARIO = new System.Data.DataColumn();
            this.NIVEL_ACESSO_USUARIO = new System.Data.DataColumn();
            this.DESCRICAO_NIVEL_ACESSO_USUARIO = new System.Data.DataColumn();
            this.comando_select = new FirebirdSql.Data.FirebirdClient.FbCommand();
            ((System.ComponentModel.ISupportInitialize)(this.dsUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.USUARIOS)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cód. Usuário:";
            // 
            // tb_usuario
            // 
            this.tb_usuario.Location = new System.Drawing.Point(84, 7);
            this.tb_usuario.Name = "tb_usuario";
            this.tb_usuario.Size = new System.Drawing.Size(100, 20);
            this.tb_usuario.TabIndex = 1;
            this.tb_usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_senha
            // 
            this.tb_senha.Location = new System.Drawing.Point(84, 33);
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.Size = new System.Drawing.Size(100, 20);
            this.tb_senha.TabIndex = 2;
            this.tb_senha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_senha.UseSystemPasswordChar = true;
            this.tb_senha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_senha_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Senha:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(109, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.DESCRICAO_NIVEL_ACESSO_USUARIO});
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
            // comando_select
            // 
            this.comando_select.CommandTimeout = 30;
            this.comando_select.Connection = this.fbConnection1;
            // 
            // form_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 91);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_senha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_usuario);
            this.Controls.Add(this.label1);
            this.Name = "form_usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.dsUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.USUARIOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_usuario;
        private System.Windows.Forms.TextBox tb_senha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
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
        private FirebirdSql.Data.FirebirdClient.FbCommand comando_select;
    }
}