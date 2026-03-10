namespace Evolucao
{
    partial class form_baixa_cp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_baixa_cp));
            this.dt_pgto = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_descricao_cc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_cod_cc = new System.Windows.Forms.TextBox();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.cb_carteira = new System.Windows.Forms.ComboBox();
            this.dsCarteira = new System.Data.DataSet();
            this.CARTEIRAS = new System.Data.DataTable();
            this.COD_CARTEIRA = new System.Data.DataColumn();
            this.NOME_CARTEIRA = new System.Data.DataColumn();
            this.OBS_CARTEIRA = new System.Data.DataColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.datCarteira = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            ((System.ComponentModel.ISupportInitialize)(this.dsCarteira)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CARTEIRAS)).BeginInit();
            this.SuspendLayout();
            // 
            // dt_pgto
            // 
            this.dt_pgto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_pgto.Location = new System.Drawing.Point(15, 31);
            this.dt_pgto.Name = "dt_pgto";
            this.dt_pgto.Size = new System.Drawing.Size(80, 20);
            this.dt_pgto.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data de Pagto";
            // 
            // tb_descricao_cc
            // 
            this.tb_descricao_cc.Location = new System.Drawing.Point(101, 31);
            this.tb_descricao_cc.Name = "tb_descricao_cc";
            this.tb_descricao_cc.ReadOnly = true;
            this.tb_descricao_cc.Size = new System.Drawing.Size(100, 20);
            this.tb_descricao_cc.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "C/C";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(207, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_cod_cc
            // 
            this.tb_cod_cc.Location = new System.Drawing.Point(130, 8);
            this.tb_cod_cc.Name = "tb_cod_cc";
            this.tb_cod_cc.Size = new System.Drawing.Size(10, 20);
            this.tb_cod_cc.TabIndex = 5;
            this.tb_cod_cc.Visible = false;
            // 
            // fbConnection1
            // 
            this.fbConnection1.ConnectionString = resources.GetString("fbConnection1.ConnectionString");
            // 
            // cb_carteira
            // 
            this.cb_carteira.DataSource = this.dsCarteira;
            this.cb_carteira.DisplayMember = "CARTEIRAS.NOME_CARTEIRA";
            this.cb_carteira.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_carteira.FormattingEnabled = true;
            this.cb_carteira.Location = new System.Drawing.Point(254, 31);
            this.cb_carteira.Name = "cb_carteira";
            this.cb_carteira.Size = new System.Drawing.Size(121, 21);
            this.cb_carteira.TabIndex = 6;
            this.cb_carteira.ValueMember = "CARTEIRAS.NOME_CARTEIRA";
            // 
            // dsCarteira
            // 
            this.dsCarteira.DataSetName = "dsCarteira";
            this.dsCarteira.Namespace = "http://www.tempuri.org/dsCarteira.xsd";
            this.dsCarteira.Tables.AddRange(new System.Data.DataTable[] {
            this.CARTEIRAS});
            // 
            // CARTEIRAS
            // 
            this.CARTEIRAS.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_CARTEIRA,
            this.NOME_CARTEIRA,
            this.OBS_CARTEIRA});
            this.CARTEIRAS.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_CARTEIRA"}, true)});
            this.CARTEIRAS.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_CARTEIRA};
            this.CARTEIRAS.TableName = "CARTEIRAS";
            // 
            // COD_CARTEIRA
            // 
            this.COD_CARTEIRA.AllowDBNull = false;
            this.COD_CARTEIRA.ColumnName = "COD_CARTEIRA";
            this.COD_CARTEIRA.DataType = typeof(int);
            // 
            // NOME_CARTEIRA
            // 
            this.NOME_CARTEIRA.ColumnName = "NOME_CARTEIRA";
            this.NOME_CARTEIRA.MaxLength = 100;
            // 
            // OBS_CARTEIRA
            // 
            this.OBS_CARTEIRA.ColumnName = "OBS_CARTEIRA";
            this.OBS_CARTEIRA.MaxLength = 200;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(151, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 29);
            this.button2.TabIndex = 7;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Carteira";
            // 
            // datCarteira
            // 
            this.datCarteira.DeleteCommand = this.fbCommand4;
            this.datCarteira.InsertCommand = this.fbCommand2;
            this.datCarteira.SelectCommand = this.fbCommand1;
            this.datCarteira.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "SELECT * FROM CARTEIRAS";
            this.fbCommand1.CommandTimeout = 30;
            this.fbCommand1.Connection = this.fbConnection1;
            // 
            // fbCommand3
            // 
            this.fbCommand3.CommandTimeout = 30;
            // 
            // form_baixa_cp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 109);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cb_carteira);
            this.Controls.Add(this.tb_cod_cc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_descricao_cc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dt_pgto);
            this.Name = "form_baixa_cp";
            this.Text = "Baixar Contas";
            this.Load += new System.EventHandler(this.form_baixa_cp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsCarteira)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CARTEIRAS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dt_pgto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_descricao_cc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_cod_cc;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private System.Windows.Forms.ComboBox cb_carteira;
        private System.Data.DataSet dsCarteira;
        private System.Data.DataTable CARTEIRAS;
        private System.Data.DataColumn COD_CARTEIRA;
        private System.Data.DataColumn NOME_CARTEIRA;
        private System.Data.DataColumn OBS_CARTEIRA;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datCarteira;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
    }
}