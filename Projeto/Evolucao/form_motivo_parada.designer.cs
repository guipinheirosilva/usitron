namespace Evolucao
{
    partial class form_motivo_parada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_motivo_parada));
            this.datTipos_parada = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.dsTipos_parada = new System.Data.DataSet();
            this.TIPOS_PARADA = new System.Data.DataTable();
            this.COD_TIPO_PARADA = new System.Data.DataColumn();
            this.DESCRICAO_TIPO_PARADA = new System.Data.DataColumn();
            this.cbTipo_parada = new System.Windows.Forms.ComboBox();
            this.tb_outros = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsTipos_parada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TIPOS_PARADA)).BeginInit();
            this.SuspendLayout();
            // 
            // datTipos_parada
            // 
            this.datTipos_parada.DeleteCommand = this.fbCommand4;
            this.datTipos_parada.InsertCommand = this.fbCommand2;
            this.datTipos_parada.SelectCommand = this.fbCommand1;
            this.datTipos_parada.UpdateCommand = this.fbCommand3;
            // 
            // fbCommand1
            // 
            this.fbCommand1.CommandText = "select * from tipos_parada";
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
            // dsTipos_parada
            // 
            this.dsTipos_parada.DataSetName = "dsTipos_parada";
            this.dsTipos_parada.Namespace = "http://www.tempuri.org/dsTipos_parada.xsd";
            this.dsTipos_parada.Tables.AddRange(new System.Data.DataTable[] {
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
            this.COD_TIPO_PARADA.ColumnName = "COD_TIPO_PARADA";
            this.COD_TIPO_PARADA.DataType = typeof(int);
            // 
            // DESCRICAO_TIPO_PARADA
            // 
            this.DESCRICAO_TIPO_PARADA.ColumnName = "DESCRICAO_TIPO_PARADA";
            this.DESCRICAO_TIPO_PARADA.MaxLength = 20;
            // 
            // cbTipo_parada
            // 
            this.cbTipo_parada.DataSource = this.dsTipos_parada;
            this.cbTipo_parada.DisplayMember = "TIPOS_PARADA.DESCRICAO_TIPO_PARADA";
            this.cbTipo_parada.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipo_parada.FormattingEnabled = true;
            this.cbTipo_parada.Location = new System.Drawing.Point(11, 68);
            this.cbTipo_parada.Name = "cbTipo_parada";
            this.cbTipo_parada.Size = new System.Drawing.Size(364, 37);
            this.cbTipo_parada.TabIndex = 0;
            this.cbTipo_parada.SelectedValueChanged += new System.EventHandler(this.cbTipo_parada_SelectedValueChanged);
            // 
            // tb_outros
            // 
            this.tb_outros.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_outros.Location = new System.Drawing.Point(11, 196);
            this.tb_outros.Multiline = true;
            this.tb_outros.Name = "tb_outros";
            this.tb_outros.Size = new System.Drawing.Size(365, 92);
            this.tb_outros.TabIndex = 1;
            this.tb_outros.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecione o motivo da parada:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(363, 47);
            this.button1.TabIndex = 3;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(94, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Digite o motivo aqui:";
            // 
            // form_motivo_parada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 300);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_outros);
            this.Controls.Add(this.cbTipo_parada);
            this.Name = "form_motivo_parada";
            this.Text = "Motivo Parada";
            this.Load += new System.EventHandler(this.form_motivo_parada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsTipos_parada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TIPOS_PARADA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datTipos_parada;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Data.DataSet dsTipos_parada;
        private System.Data.DataTable TIPOS_PARADA;
        private System.Data.DataColumn COD_TIPO_PARADA;
        private System.Data.DataColumn DESCRICAO_TIPO_PARADA;
        private System.Windows.Forms.ComboBox cbTipo_parada;
        private System.Windows.Forms.TextBox tb_outros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}