namespace Evolucao
{
    partial class form_impostos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_impostos));
            this.button2 = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.dgv_impostos = new System.Windows.Forms.DataGridView();
            this.col_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_porc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_padrao_orc = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dsImpostos = new System.Data.DataSet();
            this.IMPOSTOS = new System.Data.DataTable();
            this.COD_IMPOSTO = new System.Data.DataColumn();
            this.DESCRICAO_IMPOSTO = new System.Data.DataColumn();
            this.PORCENTAGEM_IMPOPSTO = new System.Data.DataColumn();
            this.PADRAO_ORC_IMPOSTO = new System.Data.DataColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.datImpostos = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.cbImpostos = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_impostos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsImpostos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMPOSTOS)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(223, 590);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 28);
            this.button2.TabIndex = 102;
            this.button2.Text = "Confirmar Seleção";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label28.Location = new System.Drawing.Point(213, 11);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(271, 54);
            this.label28.TabIndex = 99;
            this.label28.Text = "IMPOSTOS";
            // 
            // dgv_impostos
            // 
            this.dgv_impostos.AutoGenerateColumns = false;
            this.dgv_impostos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_impostos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_cod,
            this.col_descricao,
            this.col_porc,
            this.col_padrao_orc});
            this.dgv_impostos.DataMember = "IMPOSTOS";
            this.dgv_impostos.DataSource = this.dsImpostos;
            this.dgv_impostos.Location = new System.Drawing.Point(16, 76);
            this.dgv_impostos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_impostos.Name = "dgv_impostos";
            this.dgv_impostos.Size = new System.Drawing.Size(676, 506);
            this.dgv_impostos.TabIndex = 98;
            // 
            // col_cod
            // 
            this.col_cod.DataPropertyName = "COD_IMPOSTO";
            this.col_cod.HeaderText = "Cod.";
            this.col_cod.Name = "col_cod";
            this.col_cod.Width = 75;
            // 
            // col_descricao
            // 
            this.col_descricao.DataPropertyName = "DESCRICAO_IMPOSTO";
            this.col_descricao.HeaderText = "Descricão";
            this.col_descricao.Name = "col_descricao";
            this.col_descricao.Width = 180;
            // 
            // col_porc
            // 
            this.col_porc.DataPropertyName = "PORCENTAGEM_IMPOPSTO";
            this.col_porc.HeaderText = "Porcentagem";
            this.col_porc.Name = "col_porc";
            // 
            // col_padrao_orc
            // 
            this.col_padrao_orc.DataPropertyName = "PADRAO_ORC_IMPOSTO";
            this.col_padrao_orc.HeaderText = "Padrão Orc.";
            this.col_padrao_orc.Name = "col_padrao_orc";
            this.col_padrao_orc.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_padrao_orc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dsImpostos
            // 
            this.dsImpostos.DataSetName = "dsImpostos";
            this.dsImpostos.Namespace = "http://www.tempuri.org/dsImpostos.xsd";
            this.dsImpostos.Tables.AddRange(new System.Data.DataTable[] {
            this.IMPOSTOS});
            // 
            // IMPOSTOS
            // 
            this.IMPOSTOS.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_IMPOSTO,
            this.DESCRICAO_IMPOSTO,
            this.PORCENTAGEM_IMPOPSTO,
            this.PADRAO_ORC_IMPOSTO});
            this.IMPOSTOS.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_IMPOSTO"}, true)});
            this.IMPOSTOS.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_IMPOSTO};
            this.IMPOSTOS.TableName = "IMPOSTOS";
            // 
            // COD_IMPOSTO
            // 
            this.COD_IMPOSTO.AllowDBNull = false;
            this.COD_IMPOSTO.AutoIncrement = true;
            this.COD_IMPOSTO.ColumnName = "COD_IMPOSTO";
            this.COD_IMPOSTO.DataType = typeof(int);
            // 
            // DESCRICAO_IMPOSTO
            // 
            this.DESCRICAO_IMPOSTO.ColumnName = "DESCRICAO_IMPOSTO";
            this.DESCRICAO_IMPOSTO.MaxLength = 200;
            // 
            // PORCENTAGEM_IMPOPSTO
            // 
            this.PORCENTAGEM_IMPOPSTO.ColumnName = "PORCENTAGEM_IMPOPSTO";
            this.PORCENTAGEM_IMPOPSTO.DataType = typeof(double);
            // 
            // PADRAO_ORC_IMPOSTO
            // 
            this.PADRAO_ORC_IMPOSTO.ColumnName = "PADRAO_ORC_IMPOSTO";
            this.PADRAO_ORC_IMPOSTO.DataType = typeof(int);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(496, 590);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 100;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fbConnection1
            // 
            this.fbConnection1.ConnectionString = resources.GetString("fbConnection1.ConnectionString");
            // 
            // datImpostos
            // 
            this.datImpostos.DeleteCommand = this.fbCommand4;
            this.datImpostos.InsertCommand = this.fbCommand2;
            this.datImpostos.SelectCommand = this.fbCommand1;
            this.datImpostos.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "SELECT * FROM IMPOSTOS";
            this.fbCommand1.CommandTimeout = 30;
            this.fbCommand1.Connection = this.fbConnection1;
            // 
            // fbCommand3
            // 
            this.fbCommand3.CommandTimeout = 30;
            // 
            // cbImpostos
            // 
            this.cbImpostos.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbImpostos.DataAdapter = this.datImpostos;
            this.cbImpostos.QuotePrefix = "\"";
            this.cbImpostos.QuoteSuffix = "\"";
            // 
            // form_impostos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 626);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.dgv_impostos);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "form_impostos";
            this.Text = "Impostos";
            this.Load += new System.EventHandler(this.form_impostos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_impostos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsImpostos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMPOSTOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.DataGridView dgv_impostos;
        private System.Windows.Forms.Button button1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datImpostos;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Data.DataSet dsImpostos;
        private System.Data.DataTable IMPOSTOS;
        private System.Data.DataColumn COD_IMPOSTO;
        private System.Data.DataColumn DESCRICAO_IMPOSTO;
        private System.Data.DataColumn PORCENTAGEM_IMPOPSTO;
        private System.Data.DataColumn PADRAO_ORC_IMPOSTO;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbImpostos;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_porc;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_padrao_orc;
    }
}