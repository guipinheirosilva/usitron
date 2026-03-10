namespace Evolucao
{
    partial class form_sub_grupo_produto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_sub_grupo_produto));
            this.tb_descricao = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.dgvGrupos = new System.Windows.Forms.DataGridView();
            this.dsSub_grupos = new System.Data.DataSet();
            this.SUB_GRUPOS = new System.Data.DataTable();
            this.COD_SUB_GRUPOS = new System.Data.DataColumn();
            this.COD_GRUPO_SUB_GRUPO = new System.Data.DataColumn();
            this.DESCRICAO_GRUPO_SUB_GRUPO = new System.Data.DataColumn();
            this.DESCRICAO_SUB_GRUPO = new System.Data.DataColumn();
            this.dsGrupos = new System.Data.DataSet();
            this.GRUPOS = new System.Data.DataTable();
            this.COD_GRUPO = new System.Data.DataColumn();
            this.DESCRICAO_GRUPO = new System.Data.DataColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.datSub_grupos = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.cbSub_grupos = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.datGrupos = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand8 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand6 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand5 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand7 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dESCRICAOGRUPOSUBGRUPODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.col_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cod_grupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_descricao_grupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSub_grupos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SUB_GRUPOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGrupos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRUPOS)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_descricao
            // 
            this.tb_descricao.Location = new System.Drawing.Point(86, 57);
            this.tb_descricao.Name = "tb_descricao";
            this.tb_descricao.Size = new System.Drawing.Size(143, 20);
            this.tb_descricao.TabIndex = 115;
            this.tb_descricao.TextChanged += new System.EventHandler(this.tb_descricao_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label20.Location = new System.Drawing.Point(53, 8);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(151, 46);
            this.label20.TabIndex = 114;
            this.label20.Text = "Marcas";
            // 
            // dgvGrupos
            // 
            this.dgvGrupos.AutoGenerateColumns = false;
            this.dgvGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrupos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_cod,
            this.col_descricao,
            this.col_cod_grupo,
            this.col_descricao_grupo});
            this.dgvGrupos.DataMember = "SUB_GRUPOS";
            this.dgvGrupos.DataSource = this.dsSub_grupos;
            this.dgvGrupos.Location = new System.Drawing.Point(6, 83);
            this.dgvGrupos.Name = "dgvGrupos";
            this.dgvGrupos.Size = new System.Drawing.Size(243, 308);
            this.dgvGrupos.TabIndex = 113;
            this.dgvGrupos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrupos_CellDoubleClick);
            // 
            // dsSub_grupos
            // 
            this.dsSub_grupos.DataSetName = "dsSub_grupos";
            this.dsSub_grupos.Namespace = "http://www.tempuri.org/dsSub_grupos.xsd";
            this.dsSub_grupos.Tables.AddRange(new System.Data.DataTable[] {
            this.SUB_GRUPOS});
            // 
            // SUB_GRUPOS
            // 
            this.SUB_GRUPOS.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_SUB_GRUPOS,
            this.COD_GRUPO_SUB_GRUPO,
            this.DESCRICAO_GRUPO_SUB_GRUPO,
            this.DESCRICAO_SUB_GRUPO});
            this.SUB_GRUPOS.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_SUB_GRUPOS"}, true)});
            this.SUB_GRUPOS.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_SUB_GRUPOS};
            this.SUB_GRUPOS.TableName = "SUB_GRUPOS";
            // 
            // COD_SUB_GRUPOS
            // 
            this.COD_SUB_GRUPOS.AllowDBNull = false;
            this.COD_SUB_GRUPOS.AutoIncrement = true;
            this.COD_SUB_GRUPOS.AutoIncrementSeed = ((long)(1));
            this.COD_SUB_GRUPOS.ColumnName = "COD_SUB_GRUPOS";
            this.COD_SUB_GRUPOS.DataType = typeof(int);
            // 
            // COD_GRUPO_SUB_GRUPO
            // 
            this.COD_GRUPO_SUB_GRUPO.ColumnName = "COD_GRUPO_SUB_GRUPO";
            this.COD_GRUPO_SUB_GRUPO.DataType = typeof(int);
            // 
            // DESCRICAO_GRUPO_SUB_GRUPO
            // 
            this.DESCRICAO_GRUPO_SUB_GRUPO.ColumnName = "DESCRICAO_GRUPO_SUB_GRUPO";
            this.DESCRICAO_GRUPO_SUB_GRUPO.MaxLength = 100;
            // 
            // DESCRICAO_SUB_GRUPO
            // 
            this.DESCRICAO_SUB_GRUPO.ColumnName = "DESCRICAO_SUB_GRUPO";
            this.DESCRICAO_SUB_GRUPO.MaxLength = 100;
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
            this.button1.Location = new System.Drawing.Point(86, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 116;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // datSub_grupos
            // 
            this.datSub_grupos.DeleteCommand = this.fbCommand4;
            this.datSub_grupos.InsertCommand = this.fbCommand2;
            this.datSub_grupos.SelectCommand = this.fbCommand1;
            this.datSub_grupos.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * from sub_grupos";
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
            // cbSub_grupos
            // 
            this.cbSub_grupos.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbSub_grupos.DataAdapter = this.datSub_grupos;
            this.cbSub_grupos.QuotePrefix = "\"";
            this.cbSub_grupos.QuoteSuffix = "\"";
            // 
            // datGrupos
            // 
            this.datGrupos.DeleteCommand = this.fbCommand8;
            this.datGrupos.InsertCommand = this.fbCommand6;
            this.datGrupos.SelectCommand = this.fbCommand5;
            this.datGrupos.UpdateCommand = this.fbCommand7;
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
            this.fbCommand5.CommandText = "select * from grupos";
            this.fbCommand5.CommandTimeout = 30;
            this.fbCommand5.Connection = this.fbConnection1;
            // 
            // fbCommand7
            // 
            this.fbCommand7.CommandTimeout = 30;
            // 
            // dESCRICAOGRUPOSUBGRUPODataGridViewTextBoxColumn
            // 
            this.dESCRICAOGRUPOSUBGRUPODataGridViewTextBoxColumn.DataPropertyName = "DESCRICAO_GRUPO_SUB_GRUPO";
            this.dESCRICAOGRUPOSUBGRUPODataGridViewTextBoxColumn.DataSource = this.dsSub_grupos;
            this.dESCRICAOGRUPOSUBGRUPODataGridViewTextBoxColumn.HeaderText = "Descrição Grupo";
            this.dESCRICAOGRUPOSUBGRUPODataGridViewTextBoxColumn.Name = "dESCRICAOGRUPOSUBGRUPODataGridViewTextBoxColumn";
            this.dESCRICAOGRUPOSUBGRUPODataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dESCRICAOGRUPOSUBGRUPODataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dESCRICAOGRUPOSUBGRUPODataGridViewTextBoxColumn.Width = 140;
            // 
            // col_cod
            // 
            this.col_cod.DataPropertyName = "COD_SUB_GRUPOS";
            this.col_cod.HeaderText = "Cód.";
            this.col_cod.Name = "col_cod";
            this.col_cod.Width = 40;
            // 
            // col_descricao
            // 
            this.col_descricao.DataPropertyName = "DESCRICAO_SUB_GRUPO";
            this.col_descricao.HeaderText = "Descrição";
            this.col_descricao.Name = "col_descricao";
            this.col_descricao.Width = 140;
            // 
            // col_cod_grupo
            // 
            this.col_cod_grupo.DataPropertyName = "COD_GRUPO_SUB_GRUPO";
            this.col_cod_grupo.HeaderText = "Cód. Grupo";
            this.col_cod_grupo.Name = "col_cod_grupo";
            this.col_cod_grupo.Visible = false;
            this.col_cod_grupo.Width = 50;
            // 
            // col_descricao_grupo
            // 
            this.col_descricao_grupo.DataPropertyName = "DESCRICAO_GRUPO_SUB_GRUPO";
            this.col_descricao_grupo.HeaderText = "Descrição Grupo";
            this.col_descricao_grupo.Name = "col_descricao_grupo";
            this.col_descricao_grupo.Visible = false;
            this.col_descricao_grupo.Width = 150;
            // 
            // form_sub_grupo_produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 426);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_descricao);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.dgvGrupos);
            this.Name = "form_sub_grupo_produto";
            this.Text = "Marcas";
            this.Load += new System.EventHandler(this.form_sub_grupo_produto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSub_grupos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SUB_GRUPOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGrupos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRUPOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_descricao;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridView dgvGrupos;
        private System.Windows.Forms.Button button1;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datSub_grupos;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private System.Data.DataSet dsSub_grupos;
        private System.Data.DataTable SUB_GRUPOS;
        private System.Data.DataColumn COD_SUB_GRUPOS;
        private System.Data.DataColumn COD_GRUPO_SUB_GRUPO;
        private System.Data.DataColumn DESCRICAO_GRUPO_SUB_GRUPO;
        private System.Data.DataColumn DESCRICAO_SUB_GRUPO;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbSub_grupos;
        private System.Data.DataSet dsGrupos;
        private System.Data.DataTable GRUPOS;
        private System.Data.DataColumn COD_GRUPO;
        private System.Data.DataColumn DESCRICAO_GRUPO;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datGrupos;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand8;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand6;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand5;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand7;
        private System.Windows.Forms.DataGridViewComboBoxColumn dESCRICAOGRUPOSUBGRUPODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod_grupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_descricao_grupo;
    }
}