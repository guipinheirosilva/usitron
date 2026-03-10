namespace Evolucao
{
    partial class form_grupos_operacoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_grupos_operacoes));
            this.dgvGrupos = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.tb_descricao = new System.Windows.Forms.TextBox();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelGrupo = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.datGrupos_operacoes_prazo = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand8 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand6 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand5 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand7 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsGrupos_operacoes_prazo = new System.Data.DataSet();
            this.GRUPOS_OPERACOES_PRAZO = new System.Data.DataTable();
            this.COD_GOP = new System.Data.DataColumn();
            this.GRUPO_GOP = new System.Data.DataColumn();
            this.OPERACAO_GOP = new System.Data.DataColumn();
            this.DIAS_PRAZO_GOP = new System.Data.DataColumn();
            this.cbGrupos_operacoes_prazo = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.cODGOPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gRUPOGOPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPERACAOGOPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIASPRAZOGOPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsGrupos_operacoes_prazo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRUPOS_OPERACOES_PRAZO)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGrupos
            // 
            this.dgvGrupos.AutoGenerateColumns = false;
            this.dgvGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrupos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODGOPDataGridViewTextBoxColumn,
            this.gRUPOGOPDataGridViewTextBoxColumn,
            this.oPERACAOGOPDataGridViewTextBoxColumn,
            this.dIASPRAZOGOPDataGridViewTextBoxColumn});
            this.dgvGrupos.DataMember = "GRUPOS_OPERACOES_PRAZO";
            this.dgvGrupos.DataSource = this.dsGrupos_operacoes_prazo;
            this.dgvGrupos.Location = new System.Drawing.Point(8, 196);
            this.dgvGrupos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvGrupos.Name = "dgvGrupos";
            this.dgvGrupos.Size = new System.Drawing.Size(634, 498);
            this.dgvGrupos.TabIndex = 0;
            this.dgvGrupos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrupos_CellDoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(396, 702);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
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
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label20.Location = new System.Drawing.Point(13, 9);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(427, 39);
            this.label20.TabIndex = 111;
            this.label20.Text = "Grupos x Operações Prazo";
            // 
            // tb_descricao
            // 
            this.tb_descricao.Location = new System.Drawing.Point(21, 10);
            this.tb_descricao.Margin = new System.Windows.Forms.Padding(4);
            this.tb_descricao.Name = "tb_descricao";
            this.tb_descricao.Size = new System.Drawing.Size(373, 22);
            this.tb_descricao.TabIndex = 112;
            this.tb_descricao.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            this.fbCommand1.CommandText = "select * from metas_produto_vendedor";
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.tb_descricao);
            this.panel1.Location = new System.Drawing.Point(13, 145);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 43);
            this.panel1.TabIndex = 114;
            // 
            // labelGrupo
            // 
            this.labelGrupo.AutoSize = true;
            this.labelGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGrupo.Location = new System.Drawing.Point(26, 83);
            this.labelGrupo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGrupo.Name = "labelGrupo";
            this.labelGrupo.Size = new System.Drawing.Size(126, 46);
            this.labelGrupo.TabIndex = 115;
            this.labelGrupo.Text = "label1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(196, 702);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 28);
            this.button2.TabIndex = 116;
            this.button2.Text = "Importar Operações";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // datGrupos_operacoes_prazo
            // 
            this.datGrupos_operacoes_prazo.DeleteCommand = this.fbCommand8;
            this.datGrupos_operacoes_prazo.InsertCommand = this.fbCommand6;
            this.datGrupos_operacoes_prazo.SelectCommand = this.fbCommand5;
            this.datGrupos_operacoes_prazo.UpdateCommand = this.fbCommand7;
            // 
            // fbCommand8
            // 
            this.fbCommand8.CommandTimeout = 30;
            // 
            // fbCommand6
            // 
            this.fbCommand6.CommandTimeout = 30;
            // 
            // fbCommand5
            // 
            this.fbCommand5.CommandText = "select * from grupos_operacoes_prazo";
            this.fbCommand5.CommandTimeout = 30;
            this.fbCommand5.Connection = this.fbConnection1;
            // 
            // fbCommand7
            // 
            this.fbCommand7.CommandTimeout = 30;
            // 
            // dsGrupos_operacoes_prazo
            // 
            this.dsGrupos_operacoes_prazo.DataSetName = "dsGrupos_operacoes_prazo";
            this.dsGrupos_operacoes_prazo.Namespace = "http://www.tempuri.org/dsGrupos_operacoes_prazo.xsd";
            this.dsGrupos_operacoes_prazo.Tables.AddRange(new System.Data.DataTable[] {
            this.GRUPOS_OPERACOES_PRAZO});
            // 
            // GRUPOS_OPERACOES_PRAZO
            // 
            this.GRUPOS_OPERACOES_PRAZO.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_GOP,
            this.GRUPO_GOP,
            this.OPERACAO_GOP,
            this.DIAS_PRAZO_GOP});
            this.GRUPOS_OPERACOES_PRAZO.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_GOP"}, true)});
            this.GRUPOS_OPERACOES_PRAZO.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_GOP};
            this.GRUPOS_OPERACOES_PRAZO.TableName = "GRUPOS_OPERACOES_PRAZO";
            // 
            // COD_GOP
            // 
            this.COD_GOP.AllowDBNull = false;
            this.COD_GOP.ColumnName = "COD_GOP";
            this.COD_GOP.DataType = typeof(int);
            // 
            // GRUPO_GOP
            // 
            this.GRUPO_GOP.ColumnName = "GRUPO_GOP";
            this.GRUPO_GOP.MaxLength = 200;
            // 
            // OPERACAO_GOP
            // 
            this.OPERACAO_GOP.ColumnName = "OPERACAO_GOP";
            this.OPERACAO_GOP.MaxLength = 200;
            // 
            // DIAS_PRAZO_GOP
            // 
            this.DIAS_PRAZO_GOP.ColumnName = "DIAS_PRAZO_GOP";
            this.DIAS_PRAZO_GOP.DataType = typeof(int);
            // 
            // cbGrupos_operacoes_prazo
            // 
            this.cbGrupos_operacoes_prazo.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbGrupos_operacoes_prazo.DataAdapter = this.datGrupos_operacoes_prazo;
            this.cbGrupos_operacoes_prazo.QuotePrefix = "\"";
            this.cbGrupos_operacoes_prazo.QuoteSuffix = "\"";
            // 
            // cODGOPDataGridViewTextBoxColumn
            // 
            this.cODGOPDataGridViewTextBoxColumn.DataPropertyName = "COD_GOP";
            this.cODGOPDataGridViewTextBoxColumn.HeaderText = "COD_GOP";
            this.cODGOPDataGridViewTextBoxColumn.Name = "cODGOPDataGridViewTextBoxColumn";
            this.cODGOPDataGridViewTextBoxColumn.Visible = false;
            // 
            // gRUPOGOPDataGridViewTextBoxColumn
            // 
            this.gRUPOGOPDataGridViewTextBoxColumn.DataPropertyName = "GRUPO_GOP";
            this.gRUPOGOPDataGridViewTextBoxColumn.HeaderText = "GRUPO_GOP";
            this.gRUPOGOPDataGridViewTextBoxColumn.Name = "gRUPOGOPDataGridViewTextBoxColumn";
            this.gRUPOGOPDataGridViewTextBoxColumn.Visible = false;
            // 
            // oPERACAOGOPDataGridViewTextBoxColumn
            // 
            this.oPERACAOGOPDataGridViewTextBoxColumn.DataPropertyName = "OPERACAO_GOP";
            this.oPERACAOGOPDataGridViewTextBoxColumn.HeaderText = "Operação";
            this.oPERACAOGOPDataGridViewTextBoxColumn.Name = "oPERACAOGOPDataGridViewTextBoxColumn";
            this.oPERACAOGOPDataGridViewTextBoxColumn.Width = 250;
            // 
            // dIASPRAZOGOPDataGridViewTextBoxColumn
            // 
            this.dIASPRAZOGOPDataGridViewTextBoxColumn.DataPropertyName = "DIAS_PRAZO_GOP";
            this.dIASPRAZOGOPDataGridViewTextBoxColumn.HeaderText = "Dias Prazo";
            this.dIASPRAZOGOPDataGridViewTextBoxColumn.Name = "dIASPRAZOGOPDataGridViewTextBoxColumn";
            // 
            // form_grupos_operacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 757);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelGrupo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvGrupos);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form_grupos_operacoes";
            this.Text = "Grupos Operações Prazo";
            this.Load += new System.EventHandler(this.form_grupos_operacoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsGrupos_operacoes_prazo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRUPOS_OPERACOES_PRAZO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGrupos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tb_descricao;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelGrupo;
        private System.Windows.Forms.Button button2;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datGrupos_operacoes_prazo;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand8;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand6;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand5;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand7;
        private System.Data.DataSet dsGrupos_operacoes_prazo;
        private System.Data.DataTable GRUPOS_OPERACOES_PRAZO;
        private System.Data.DataColumn COD_GOP;
        private System.Data.DataColumn GRUPO_GOP;
        private System.Data.DataColumn OPERACAO_GOP;
        private System.Data.DataColumn DIAS_PRAZO_GOP;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbGrupos_operacoes_prazo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODGOPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gRUPOGOPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPERACAOGOPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIASPRAZOGOPDataGridViewTextBoxColumn;
    }
}