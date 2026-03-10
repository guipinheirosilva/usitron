namespace Evolucao
{
    partial class form_familias_produto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_familias_produto));
            this.dgvGrupos = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.tb_descricao = new System.Windows.Forms.TextBox();
            this.datGrupos = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.cbGrupos = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.dsGrupos = new System.Data.DataSet();
            this.FAMILIA_PRODUTO = new System.Data.DataTable();
            this.COD_FP = new System.Data.DataColumn();
            this.FAMILIA_FP = new System.Data.DataColumn();
            this.col_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGrupos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FAMILIA_PRODUTO)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGrupos
            // 
            this.dgvGrupos.AutoGenerateColumns = false;
            this.dgvGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrupos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_cod,
            this.col_descricao});
            this.dgvGrupos.DataMember = "FAMILIA_PRODUTO";
            this.dgvGrupos.DataSource = this.dsGrupos;
            this.dgvGrupos.Location = new System.Drawing.Point(6, 85);
            this.dgvGrupos.Name = "dgvGrupos";
            this.dgvGrupos.Size = new System.Drawing.Size(266, 308);
            this.dgvGrupos.TabIndex = 0;
            this.dgvGrupos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrupos_CellDoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label20.Location = new System.Drawing.Point(58, 9);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(168, 46);
            this.label20.TabIndex = 111;
            this.label20.Text = "Familias";
            // 
            // tb_descricao
            // 
            this.tb_descricao.Location = new System.Drawing.Point(86, 59);
            this.tb_descricao.Name = "tb_descricao";
            this.tb_descricao.Size = new System.Drawing.Size(163, 20);
            this.tb_descricao.TabIndex = 112;
            this.tb_descricao.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // datGrupos
            // 
            this.datGrupos.DeleteCommand = this.fbCommand4;
            this.datGrupos.InsertCommand = this.fbCommand2;
            this.datGrupos.SelectCommand = this.fbCommand1;
            this.datGrupos.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * from familia_produto";
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
            // cbGrupos
            // 
            this.cbGrupos.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbGrupos.DataAdapter = this.datGrupos;
            this.cbGrupos.QuotePrefix = "\"";
            this.cbGrupos.QuoteSuffix = "\"";
            // 
            // dsGrupos
            // 
            this.dsGrupos.DataSetName = "dsGrupos";
            this.dsGrupos.Namespace = "http://www.tempuri.org/dsGrupos.xsd";
            this.dsGrupos.Tables.AddRange(new System.Data.DataTable[] {
            this.FAMILIA_PRODUTO});
            // 
            // FAMILIA_PRODUTO
            // 
            this.FAMILIA_PRODUTO.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_FP,
            this.FAMILIA_FP});
            this.FAMILIA_PRODUTO.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_FP"}, true)});
            this.FAMILIA_PRODUTO.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_FP};
            this.FAMILIA_PRODUTO.TableName = "FAMILIA_PRODUTO";
            // 
            // COD_FP
            // 
            this.COD_FP.AllowDBNull = false;
            this.COD_FP.AutoIncrement = true;
            this.COD_FP.ColumnName = "COD_FP";
            this.COD_FP.DataType = typeof(int);
            // 
            // FAMILIA_FP
            // 
            this.FAMILIA_FP.ColumnName = "FAMILIA_FP";
            this.FAMILIA_FP.MaxLength = 100;
            // 
            // col_cod
            // 
            this.col_cod.DataPropertyName = "COD_FP";
            this.col_cod.HeaderText = "Cód.";
            this.col_cod.Name = "col_cod";
            this.col_cod.Width = 50;
            // 
            // col_descricao
            // 
            this.col_descricao.DataPropertyName = "FAMILIA_FP";
            this.col_descricao.HeaderText = "Família";
            this.col_descricao.Name = "col_descricao";
            this.col_descricao.Width = 150;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 400);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 23);
            this.button2.TabIndex = 113;
            this.button2.Text = "Confirmar Seleção";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // form_familias_produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 432);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tb_descricao);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvGrupos);
            this.Name = "form_familias_produto";
            this.Text = "Famílias";
            this.Load += new System.EventHandler(this.form_grupo_produto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGrupos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FAMILIA_PRODUTO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGrupos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tb_descricao;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datGrupos;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbGrupos;
        private System.Data.DataSet dsGrupos;
        private System.Data.DataTable FAMILIA_PRODUTO;
        private System.Data.DataColumn COD_FP;
        private System.Data.DataColumn FAMILIA_FP;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_descricao;
        private System.Windows.Forms.Button button2;
    }
}