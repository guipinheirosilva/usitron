namespace Evolucao
{
    partial class form_grupo_produto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_grupo_produto));
            this.dgvGrupos = new System.Windows.Forms.DataGridView();
            this.dsGrupos = new System.Data.DataSet();
            this.GRUPOS = new System.Data.DataTable();
            this.COD_GRUPO = new System.Data.DataColumn();
            this.DESCRICAO_GRUPO = new System.Data.DataColumn();
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
            this.col_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_operacoes = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGrupos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRUPOS)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGrupos
            // 
            this.dgvGrupos.AutoGenerateColumns = false;
            this.dgvGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrupos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_cod,
            this.col_descricao,
            this.col_operacoes});
            this.dgvGrupos.DataMember = "GRUPOS";
            this.dgvGrupos.DataSource = this.dsGrupos;
            this.dgvGrupos.Location = new System.Drawing.Point(8, 105);
            this.dgvGrupos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvGrupos.Name = "dgvGrupos";
            this.dgvGrupos.Size = new System.Drawing.Size(505, 379);
            this.dgvGrupos.TabIndex = 0;
            this.dgvGrupos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrupos_CellContentClick);
            this.dgvGrupos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrupos_CellDoubleClick);
            // 
            // dsGrupos
            // 
            this.dsGrupos.DataSetName = "dsGrupos";
            this.dsGrupos.Namespace = "http://www.tempuri.org/dsGrupos.xsd";
            this.dsGrupos.Tables.AddRange(new System.Data.DataTable[] {
            this.GRUPOS});
            // 
            // GRUPOS
            // 
            this.GRUPOS.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_GRUPO,
            this.DESCRICAO_GRUPO});
            this.GRUPOS.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_GRUPO"}, true)});
            this.GRUPOS.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_GRUPO};
            this.GRUPOS.TableName = "GRUPOS";
            // 
            // COD_GRUPO
            // 
            this.COD_GRUPO.AllowDBNull = false;
            this.COD_GRUPO.AutoIncrement = true;
            this.COD_GRUPO.AutoIncrementSeed = ((long)(1));
            this.COD_GRUPO.ColumnName = "COD_GRUPO";
            this.COD_GRUPO.DataType = typeof(int);
            // 
            // DESCRICAO_GRUPO
            // 
            this.DESCRICAO_GRUPO.ColumnName = "DESCRICAO_GRUPO";
            this.DESCRICAO_GRUPO.MaxLength = 100;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(220, 491);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
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
            this.label20.Location = new System.Drawing.Point(169, 9);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(190, 58);
            this.label20.TabIndex = 111;
            this.label20.Text = "Grupos";
            // 
            // tb_descricao
            // 
            this.tb_descricao.Location = new System.Drawing.Point(87, 73);
            this.tb_descricao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_descricao.Name = "tb_descricao";
            this.tb_descricao.Size = new System.Drawing.Size(216, 22);
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
            this.fbCommand1.CommandText = "select * from grupos";
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
            // col_cod
            // 
            this.col_cod.DataPropertyName = "COD_GRUPO";
            this.col_cod.HeaderText = "Cód.";
            this.col_cod.Name = "col_cod";
            this.col_cod.Width = 40;
            // 
            // col_descricao
            // 
            this.col_descricao.DataPropertyName = "DESCRICAO_GRUPO";
            this.col_descricao.HeaderText = "Descrição";
            this.col_descricao.Name = "col_descricao";
            this.col_descricao.Width = 160;
            // 
            // col_operacoes
            // 
            this.col_operacoes.HeaderText = "Operações";
            this.col_operacoes.Name = "col_operacoes";
            this.col_operacoes.Text = "Operações";
            // 
            // form_grupo_produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 532);
            this.Controls.Add(this.tb_descricao);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvGrupos);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "form_grupo_produto";
            this.Text = "Grupos";
            this.Load += new System.EventHandler(this.form_grupo_produto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGrupos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRUPOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGrupos;
        private System.Windows.Forms.Button button1;
        private System.Data.DataSet dsGrupos;
        private System.Data.DataTable GRUPOS;
        private System.Data.DataColumn COD_GRUPO;
        private System.Data.DataColumn DESCRICAO_GRUPO;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tb_descricao;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datGrupos;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbGrupos;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_descricao;
        private System.Windows.Forms.DataGridViewButtonColumn col_operacoes;
    }
}