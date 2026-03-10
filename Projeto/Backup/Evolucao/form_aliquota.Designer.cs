namespace Evolucao
{
    partial class form_aliquota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_aliquota));
            this.tb_valor_aliquota = new System.Windows.Forms.TextBox();
            this.dsAliquota = new System.Data.DataSet();
            this.ALIQUOTA_SIMPLES = new System.Data.DataTable();
            this.COD_ALIQUOTA = new System.Data.DataColumn();
            this.VALOR_ALIQUOTA = new System.Data.DataColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.datAliquota = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.cbAliquota = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            ((System.ComponentModel.ISupportInitialize)(this.dsAliquota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ALIQUOTA_SIMPLES)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_valor_aliquota
            // 
            this.tb_valor_aliquota.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAliquota, "ALIQUOTA_SIMPLES.VALOR_ALIQUOTA", true));
            this.tb_valor_aliquota.Location = new System.Drawing.Point(55, 29);
            this.tb_valor_aliquota.Name = "tb_valor_aliquota";
            this.tb_valor_aliquota.Size = new System.Drawing.Size(100, 20);
            this.tb_valor_aliquota.TabIndex = 0;
            // 
            // dsAliquota
            // 
            this.dsAliquota.DataSetName = "dsAliquota";
            this.dsAliquota.Namespace = "http://www.tempuri.org/dsAliquota.xsd";
            this.dsAliquota.Tables.AddRange(new System.Data.DataTable[] {
            this.ALIQUOTA_SIMPLES});
            // 
            // ALIQUOTA_SIMPLES
            // 
            this.ALIQUOTA_SIMPLES.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_ALIQUOTA,
            this.VALOR_ALIQUOTA});
            this.ALIQUOTA_SIMPLES.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_ALIQUOTA"}, true)});
            this.ALIQUOTA_SIMPLES.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_ALIQUOTA};
            this.ALIQUOTA_SIMPLES.TableName = "ALIQUOTA_SIMPLES";
            // 
            // COD_ALIQUOTA
            // 
            this.COD_ALIQUOTA.AllowDBNull = false;
            this.COD_ALIQUOTA.ColumnName = "COD_ALIQUOTA";
            this.COD_ALIQUOTA.DataType = typeof(int);
            // 
            // VALOR_ALIQUOTA
            // 
            this.VALOR_ALIQUOTA.ColumnName = "VALOR_ALIQUOTA";
            this.VALOR_ALIQUOTA.DataType = typeof(double);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite a alíquota do mês";
            // 
            // datAliquota
            // 
            this.datAliquota.DeleteCommand = this.fbCommand4;
            this.datAliquota.InsertCommand = this.fbCommand2;
            this.datAliquota.SelectCommand = this.fbCommand1;
            this.datAliquota.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * from aliquota_simples";
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
            // cbAliquota
            // 
            this.cbAliquota.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbAliquota.DataAdapter = this.datAliquota;
            this.cbAliquota.QuotePrefix = "\"";
            this.cbAliquota.QuoteSuffix = "\"";
            // 
            // form_aliquota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 61);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_valor_aliquota);
            this.Name = "form_aliquota";
            this.Text = "Alíquota Simples";
            this.Load += new System.EventHandler(this.form_aliquota_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.form_aliquota_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dsAliquota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ALIQUOTA_SIMPLES)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_valor_aliquota;
        private System.Windows.Forms.Label label1;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datAliquota;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Data.DataSet dsAliquota;
        private System.Data.DataTable ALIQUOTA_SIMPLES;
        private System.Data.DataColumn COD_ALIQUOTA;
        private System.Data.DataColumn VALOR_ALIQUOTA;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbAliquota;
    }
}