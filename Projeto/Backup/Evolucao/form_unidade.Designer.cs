namespace Evolucao
{
    partial class form_unidade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_unidade));
            this.button1 = new System.Windows.Forms.Button();
            this.tb_descricao = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.dgvUnidades = new System.Windows.Forms.DataGridView();
            this.col_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_abreviacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsUnidades = new System.Data.DataSet();
            this.UNIDADES = new System.Data.DataTable();
            this.COD_UNIDADE = new System.Data.DataColumn();
            this.ABREVIACAO_UNIDADE = new System.Data.DataColumn();
            this.DESCRICAO_UNIDADE = new System.Data.DataColumn();
            this.datUnidades = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.cbUnidades = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UNIDADES)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(109, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 120;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_descricao
            // 
            this.tb_descricao.Location = new System.Drawing.Point(89, 62);
            this.tb_descricao.Name = "tb_descricao";
            this.tb_descricao.Size = new System.Drawing.Size(64, 20);
            this.tb_descricao.TabIndex = 119;
            this.tb_descricao.TextChanged += new System.EventHandler(this.tb_descricao_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label20.Location = new System.Drawing.Point(49, -1);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(188, 46);
            this.label20.TabIndex = 118;
            this.label20.Text = "Unidades";
            // 
            // dgvUnidades
            // 
            this.dgvUnidades.AutoGenerateColumns = false;
            this.dgvUnidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_cod,
            this.col_abreviacao,
            this.col_descricao});
            this.dgvUnidades.DataMember = "UNIDADES";
            this.dgvUnidades.DataSource = this.dsUnidades;
            this.dgvUnidades.Location = new System.Drawing.Point(9, 88);
            this.dgvUnidades.Name = "dgvUnidades";
            this.dgvUnidades.Size = new System.Drawing.Size(266, 308);
            this.dgvUnidades.TabIndex = 117;
            this.dgvUnidades.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUnidades_CellDoubleClick);
            // 
            // col_cod
            // 
            this.col_cod.DataPropertyName = "COD_UNIDADE";
            this.col_cod.HeaderText = "Cód.";
            this.col_cod.Name = "col_cod";
            this.col_cod.Width = 40;
            // 
            // col_abreviacao
            // 
            this.col_abreviacao.DataPropertyName = "ABREVIACAO_UNIDADE";
            this.col_abreviacao.HeaderText = "Abrev.";
            this.col_abreviacao.Name = "col_abreviacao";
            this.col_abreviacao.Width = 60;
            // 
            // col_descricao
            // 
            this.col_descricao.DataPropertyName = "DESCRICAO_UNIDADE";
            this.col_descricao.HeaderText = "Descrição";
            this.col_descricao.Name = "col_descricao";
            // 
            // dsUnidades
            // 
            this.dsUnidades.DataSetName = "dsUnidades";
            this.dsUnidades.Namespace = "http://www.tempuri.org/dsUnidades.xsd";
            this.dsUnidades.Tables.AddRange(new System.Data.DataTable[] {
            this.UNIDADES});
            // 
            // UNIDADES
            // 
            this.UNIDADES.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_UNIDADE,
            this.ABREVIACAO_UNIDADE,
            this.DESCRICAO_UNIDADE});
            this.UNIDADES.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_UNIDADE"}, true)});
            this.UNIDADES.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_UNIDADE};
            this.UNIDADES.TableName = "UNIDADES";
            // 
            // COD_UNIDADE
            // 
            this.COD_UNIDADE.AllowDBNull = false;
            this.COD_UNIDADE.AutoIncrement = true;
            this.COD_UNIDADE.AutoIncrementSeed = ((long)(1));
            this.COD_UNIDADE.ColumnName = "COD_UNIDADE";
            this.COD_UNIDADE.DataType = typeof(int);
            // 
            // ABREVIACAO_UNIDADE
            // 
            this.ABREVIACAO_UNIDADE.ColumnName = "ABREVIACAO_UNIDADE";
            this.ABREVIACAO_UNIDADE.MaxLength = 10;
            // 
            // DESCRICAO_UNIDADE
            // 
            this.DESCRICAO_UNIDADE.ColumnName = "DESCRICAO_UNIDADE";
            this.DESCRICAO_UNIDADE.MaxLength = 50;
            // 
            // datUnidades
            // 
            this.datUnidades.DeleteCommand = this.fbCommand4;
            this.datUnidades.InsertCommand = this.fbCommand2;
            this.datUnidades.SelectCommand = this.fbCommand1;
            this.datUnidades.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * from unidades";
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
            // cbUnidades
            // 
            this.cbUnidades.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbUnidades.DataAdapter = this.datUnidades;
            this.cbUnidades.QuotePrefix = "\"";
            this.cbUnidades.QuoteSuffix = "\"";
            // 
            // form_unidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 429);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_descricao);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.dgvUnidades);
            this.Name = "form_unidade";
            this.Text = "form_unidade";
            this.Load += new System.EventHandler(this.form_unidade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UNIDADES)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_descricao;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridView dgvUnidades;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datUnidades;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Data.DataSet dsUnidades;
        private System.Data.DataTable UNIDADES;
        private System.Data.DataColumn COD_UNIDADE;
        private System.Data.DataColumn ABREVIACAO_UNIDADE;
        private System.Data.DataColumn DESCRICAO_UNIDADE;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_abreviacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_descricao;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbUnidades;
    }
}