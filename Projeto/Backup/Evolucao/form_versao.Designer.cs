namespace Evolucao
{
    partial class form_versao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_versao));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_versao_sistema = new System.Windows.Forms.TextBox();
            this.tb_versao_atual = new System.Windows.Forms.TextBox();
            this.dsVersao = new System.Data.DataSet();
            this.VERSAO = new System.Data.DataTable();
            this.COD_VERSAO = new System.Data.DataColumn();
            this.VERSAO_NUM = new System.Data.DataColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.datVersao = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            ((System.ComponentModel.ISupportInitialize)(this.dsVersao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VERSAO)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Versão Instalada do Sistema é:";
            // 
            // tb_versao_sistema
            // 
            this.tb_versao_sistema.Location = new System.Drawing.Point(197, 56);
            this.tb_versao_sistema.Name = "tb_versao_sistema";
            this.tb_versao_sistema.ReadOnly = true;
            this.tb_versao_sistema.Size = new System.Drawing.Size(50, 20);
            this.tb_versao_sistema.TabIndex = 1;
            this.tb_versao_sistema.Text = "1,36";
            this.tb_versao_sistema.TextChanged += new System.EventHandler(this.tb_versao_sistema_TextChanged);
            // 
            // tb_versao_atual
            // 
            this.tb_versao_atual.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsVersao, "VERSAO.VERSAO_NUM", true));
            this.tb_versao_atual.Location = new System.Drawing.Point(197, 105);
            this.tb_versao_atual.Name = "tb_versao_atual";
            this.tb_versao_atual.ReadOnly = true;
            this.tb_versao_atual.Size = new System.Drawing.Size(50, 20);
            this.tb_versao_atual.TabIndex = 3;
            // 
            // dsVersao
            // 
            this.dsVersao.DataSetName = "dsVersao";
            this.dsVersao.Namespace = "http://www.tempuri.org/dsVersao.xsd";
            this.dsVersao.Tables.AddRange(new System.Data.DataTable[] {
            this.VERSAO});
            // 
            // VERSAO
            // 
            this.VERSAO.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_VERSAO,
            this.VERSAO_NUM});
            this.VERSAO.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_VERSAO"}, true)});
            this.VERSAO.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_VERSAO};
            this.VERSAO.TableName = "VERSAO";
            // 
            // COD_VERSAO
            // 
            this.COD_VERSAO.AllowDBNull = false;
            this.COD_VERSAO.ColumnName = "COD_VERSAO";
            this.COD_VERSAO.DataType = typeof(int);
            // 
            // VERSAO_NUM
            // 
            this.VERSAO_NUM.ColumnName = "VERSAO_NUM";
            this.VERSAO_NUM.MaxLength = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Versão Atualizada do Sistema é:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Desenvolvido por Evolução Informática\r\nTel: (11) 9524-0288";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // datVersao
            // 
            this.datVersao.DeleteCommand = this.fbCommand4;
            this.datVersao.InsertCommand = this.fbCommand2;
            this.datVersao.SelectCommand = this.fbCommand1;
            this.datVersao.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * from versao";
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
            // form_versao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_versao_atual);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_versao_sistema);
            this.Controls.Add(this.label1);
            this.Name = "form_versao";
            this.Text = "Informações do Sistema";
            this.Load += new System.EventHandler(this.form_versao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsVersao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VERSAO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_versao_sistema;
        private System.Windows.Forms.TextBox tb_versao_atual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datVersao;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Data.DataSet dsVersao;
        private System.Data.DataTable VERSAO;
        private System.Data.DataColumn COD_VERSAO;
        private System.Data.DataColumn VERSAO_NUM;
    }
}