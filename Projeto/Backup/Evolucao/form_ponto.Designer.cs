namespace Evolucao
{
    partial class form_ponto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_ponto));
            this.button1 = new System.Windows.Forms.Button();
            this.tb_caminho = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.datCaminho_ponto = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.dsCaminho_ponto = new System.Data.DataSet();
            this.CAMINHO_PONTO = new System.Data.DataTable();
            this.COD_CAMINHO = new System.Data.DataColumn();
            this.CAMINHO_COMPLETO_PONTO = new System.Data.DataColumn();
            this.fbCommandBuilder1 = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.datApontamentos = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand5 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand6 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand7 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand8 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsApontamentos = new System.Data.DataSet();
            this.APONTAMENTOS = new System.Data.DataTable();
            this.COD_APONTAMENTO = new System.Data.DataColumn();
            this.OPERADOR_APONTAMENTO = new System.Data.DataColumn();
            this.DATA_ENTRADA_APONTAMENTO = new System.Data.DataColumn();
            this.HORA_ENTRADA_APONTAMENTO = new System.Data.DataColumn();
            this.DATA_FECHAMENTO_APONTAMENTO = new System.Data.DataColumn();
            this.HORA_FECHAMENTO_APONTAMENTO = new System.Data.DataColumn();
            this.HORAS_TOTAIS_APONTAMENTO = new System.Data.DataColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dsCaminho_ponto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CAMINHO_PONTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsApontamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.APONTAMENTOS)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Capturar horas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_caminho
            // 
            this.tb_caminho.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsCaminho_ponto, "CAMINHO_PONTO.CAMINHO_COMPLETO_PONTO", true));
            this.tb_caminho.Location = new System.Drawing.Point(54, 97);
            this.tb_caminho.Name = "tb_caminho";
            this.tb_caminho.Size = new System.Drawing.Size(172, 20);
            this.tb_caminho.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Caminho do Arquivo:";
            // 
            // datCaminho_ponto
            // 
            this.datCaminho_ponto.DeleteCommand = this.fbCommand4;
            this.datCaminho_ponto.InsertCommand = this.fbCommand2;
            this.datCaminho_ponto.SelectCommand = this.fbCommand1;
            this.datCaminho_ponto.UpdateCommand = this.fbCommand3;
            // 
            // fbCommand1
            // 
            this.fbCommand1.CommandText = "select * from caminho_ponto";
            this.fbCommand1.CommandTimeout = 30;
            this.fbCommand1.Connection = this.fbConnection1;
            // 
            // fbCommand2
            // 
            this.fbCommand2.CommandTimeout = 30;
            // 
            // fbCommand3
            // 
            this.fbCommand3.CommandTimeout = 30;
            // 
            // fbCommand4
            // 
            this.fbCommand4.CommandTimeout = 30;
            // 
            // fbConnection1
            // 
            this.fbConnection1.ConnectionString = resources.GetString("fbConnection1.ConnectionString");
            // 
            // dsCaminho_ponto
            // 
            this.dsCaminho_ponto.DataSetName = "dsCaminho_ponto";
            this.dsCaminho_ponto.Namespace = "http://www.tempuri.org/dsCaminho_ponto.xsd";
            this.dsCaminho_ponto.Tables.AddRange(new System.Data.DataTable[] {
            this.CAMINHO_PONTO});
            // 
            // CAMINHO_PONTO
            // 
            this.CAMINHO_PONTO.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_CAMINHO,
            this.CAMINHO_COMPLETO_PONTO});
            this.CAMINHO_PONTO.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_CAMINHO"}, true)});
            this.CAMINHO_PONTO.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_CAMINHO};
            this.CAMINHO_PONTO.TableName = "CAMINHO_PONTO";
            // 
            // COD_CAMINHO
            // 
            this.COD_CAMINHO.AllowDBNull = false;
            this.COD_CAMINHO.ColumnName = "COD_CAMINHO";
            this.COD_CAMINHO.DataType = typeof(int);
            // 
            // CAMINHO_COMPLETO_PONTO
            // 
            this.CAMINHO_COMPLETO_PONTO.ColumnName = "CAMINHO_COMPLETO_PONTO";
            this.CAMINHO_COMPLETO_PONTO.MaxLength = 50;
            // 
            // fbCommandBuilder1
            // 
            this.fbCommandBuilder1.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.fbCommandBuilder1.DataAdapter = this.datCaminho_ponto;
            this.fbCommandBuilder1.QuotePrefix = "\"";
            this.fbCommandBuilder1.QuoteSuffix = "\"";
            // 
            // datApontamentos
            // 
            this.datApontamentos.DeleteCommand = this.fbCommand8;
            this.datApontamentos.InsertCommand = this.fbCommand6;
            this.datApontamentos.SelectCommand = this.fbCommand5;
            this.datApontamentos.UpdateCommand = this.fbCommand7;
            // 
            // fbCommand5
            // 
            this.fbCommand5.CommandText = "select * from apontamentos";
            this.fbCommand5.CommandTimeout = 30;
            this.fbCommand5.Connection = this.fbConnection1;
            // 
            // fbCommand6
            // 
            this.fbCommand6.CommandTimeout = 30;
            // 
            // fbCommand7
            // 
            this.fbCommand7.CommandTimeout = 30;
            // 
            // fbCommand8
            // 
            this.fbCommand8.CommandTimeout = 30;
            // 
            // dsApontamentos
            // 
            this.dsApontamentos.DataSetName = "dsApontamentos";
            this.dsApontamentos.Namespace = "http://www.tempuri.org/dsApontamentos.xsd";
            this.dsApontamentos.Tables.AddRange(new System.Data.DataTable[] {
            this.APONTAMENTOS});
            // 
            // APONTAMENTOS
            // 
            this.APONTAMENTOS.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_APONTAMENTO,
            this.OPERADOR_APONTAMENTO,
            this.DATA_ENTRADA_APONTAMENTO,
            this.HORA_ENTRADA_APONTAMENTO,
            this.DATA_FECHAMENTO_APONTAMENTO,
            this.HORA_FECHAMENTO_APONTAMENTO,
            this.HORAS_TOTAIS_APONTAMENTO});
            this.APONTAMENTOS.TableName = "APONTAMENTOS";
            // 
            // COD_APONTAMENTO
            // 
            this.COD_APONTAMENTO.ColumnName = "COD_APONTAMENTO";
            this.COD_APONTAMENTO.DataType = typeof(int);
            // 
            // OPERADOR_APONTAMENTO
            // 
            this.OPERADOR_APONTAMENTO.ColumnName = "OPERADOR_APONTAMENTO";
            this.OPERADOR_APONTAMENTO.MaxLength = 10;
            // 
            // DATA_ENTRADA_APONTAMENTO
            // 
            this.DATA_ENTRADA_APONTAMENTO.ColumnName = "DATA_ENTRADA_APONTAMENTO";
            this.DATA_ENTRADA_APONTAMENTO.DataType = typeof(System.DateTime);
            // 
            // HORA_ENTRADA_APONTAMENTO
            // 
            this.HORA_ENTRADA_APONTAMENTO.ColumnName = "HORA_ENTRADA_APONTAMENTO";
            this.HORA_ENTRADA_APONTAMENTO.MaxLength = 30;
            // 
            // DATA_FECHAMENTO_APONTAMENTO
            // 
            this.DATA_FECHAMENTO_APONTAMENTO.ColumnName = "DATA_FECHAMENTO_APONTAMENTO";
            this.DATA_FECHAMENTO_APONTAMENTO.DataType = typeof(System.DateTime);
            // 
            // HORA_FECHAMENTO_APONTAMENTO
            // 
            this.HORA_FECHAMENTO_APONTAMENTO.ColumnName = "HORA_FECHAMENTO_APONTAMENTO";
            this.HORA_FECHAMENTO_APONTAMENTO.MaxLength = 30;
            // 
            // HORAS_TOTAIS_APONTAMENTO
            // 
            this.HORAS_TOTAIS_APONTAMENTO.ColumnName = "HORAS_TOTAIS_APONTAMENTO";
            this.HORAS_TOTAIS_APONTAMENTO.DataType = typeof(double);
            // 
            // form_ponto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 267);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_caminho);
            this.Controls.Add(this.button1);
            this.Name = "form_ponto";
            this.Text = "Cartão de Ponto";
            this.Load += new System.EventHandler(this.form_ponto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsCaminho_ponto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CAMINHO_PONTO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsApontamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.APONTAMENTOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_caminho;
        private System.Windows.Forms.Label label1;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datCaminho_ponto;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Data.DataSet dsCaminho_ponto;
        private System.Data.DataTable CAMINHO_PONTO;
        private System.Data.DataColumn COD_CAMINHO;
        private System.Data.DataColumn CAMINHO_COMPLETO_PONTO;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder fbCommandBuilder1;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datApontamentos;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand8;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand6;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand5;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand7;
        private System.Data.DataSet dsApontamentos;
        private System.Data.DataTable APONTAMENTOS;
        private System.Data.DataColumn COD_APONTAMENTO;
        private System.Data.DataColumn OPERADOR_APONTAMENTO;
        private System.Data.DataColumn DATA_ENTRADA_APONTAMENTO;
        private System.Data.DataColumn HORA_ENTRADA_APONTAMENTO;
        private System.Data.DataColumn DATA_FECHAMENTO_APONTAMENTO;
        private System.Data.DataColumn HORA_FECHAMENTO_APONTAMENTO;
        private System.Data.DataColumn HORAS_TOTAIS_APONTAMENTO;
    }
}