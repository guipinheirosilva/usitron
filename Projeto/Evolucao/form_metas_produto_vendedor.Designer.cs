namespace Evolucao
{
    partial class form_metas_produto_vendedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_metas_produto_vendedor));
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
            this.METAS_PRODUTO_VENDEDOR = new System.Data.DataTable();
            this.COD_MPV = new System.Data.DataColumn();
            this.COD_VENDEDOR_MPV = new System.Data.DataColumn();
            this.FAMILIA_MPV = new System.Data.DataColumn();
            this.META_FISICA_MPV = new System.Data.DataColumn();
            this.META_POSITIVACAO_MPV = new System.Data.DataColumn();
            this.META_VALOR_MPV = new System.Data.DataColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cODMPVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODVENDEDORMPVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fAMILIAMPVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mETAFISICAMPVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mETAPOSITIVACAOMPVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mETAVALORMPVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelVendedor = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGrupos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.METAS_PRODUTO_VENDEDOR)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvGrupos
            // 
            this.dgvGrupos.AutoGenerateColumns = false;
            this.dgvGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrupos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODMPVDataGridViewTextBoxColumn,
            this.cODVENDEDORMPVDataGridViewTextBoxColumn,
            this.fAMILIAMPVDataGridViewTextBoxColumn,
            this.mETAFISICAMPVDataGridViewTextBoxColumn,
            this.mETAPOSITIVACAOMPVDataGridViewTextBoxColumn,
            this.mETAVALORMPVDataGridViewTextBoxColumn});
            this.dgvGrupos.DataMember = "METAS_PRODUTO_VENDEDOR";
            this.dgvGrupos.DataSource = this.dsGrupos;
            this.dgvGrupos.Location = new System.Drawing.Point(6, 159);
            this.dgvGrupos.Name = "dgvGrupos";
            this.dgvGrupos.Size = new System.Drawing.Size(872, 491);
            this.dgvGrupos.TabIndex = 0;
            this.dgvGrupos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrupos_CellDoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(404, 656);
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
            this.label20.Location = new System.Drawing.Point(365, 9);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(139, 46);
            this.label20.TabIndex = 111;
            this.label20.Text = "Metas ";
            // 
            // tb_descricao
            // 
            this.tb_descricao.Location = new System.Drawing.Point(16, 8);
            this.tb_descricao.Name = "tb_descricao";
            this.tb_descricao.Size = new System.Drawing.Size(299, 20);
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
            this.METAS_PRODUTO_VENDEDOR});
            // 
            // METAS_PRODUTO_VENDEDOR
            // 
            this.METAS_PRODUTO_VENDEDOR.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_MPV,
            this.COD_VENDEDOR_MPV,
            this.FAMILIA_MPV,
            this.META_FISICA_MPV,
            this.META_POSITIVACAO_MPV,
            this.META_VALOR_MPV});
            this.METAS_PRODUTO_VENDEDOR.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_MPV"}, true)});
            this.METAS_PRODUTO_VENDEDOR.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_MPV};
            this.METAS_PRODUTO_VENDEDOR.TableName = "METAS_PRODUTO_VENDEDOR";
            // 
            // COD_MPV
            // 
            this.COD_MPV.AllowDBNull = false;
            this.COD_MPV.ColumnName = "COD_MPV";
            this.COD_MPV.DataType = typeof(int);
            // 
            // COD_VENDEDOR_MPV
            // 
            this.COD_VENDEDOR_MPV.ColumnName = "COD_VENDEDOR_MPV";
            this.COD_VENDEDOR_MPV.DataType = typeof(int);
            // 
            // FAMILIA_MPV
            // 
            this.FAMILIA_MPV.ColumnName = "FAMILIA_MPV";
            this.FAMILIA_MPV.MaxLength = 100;
            // 
            // META_FISICA_MPV
            // 
            this.META_FISICA_MPV.ColumnName = "META_FISICA_MPV";
            this.META_FISICA_MPV.DataType = typeof(double);
            // 
            // META_POSITIVACAO_MPV
            // 
            this.META_POSITIVACAO_MPV.ColumnName = "META_POSITIVACAO_MPV";
            this.META_POSITIVACAO_MPV.DataType = typeof(double);
            // 
            // META_VALOR_MPV
            // 
            this.META_VALOR_MPV.ColumnName = "META_VALOR_MPV";
            this.META_VALOR_MPV.DataType = typeof(double);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.tb_descricao);
            this.panel1.Location = new System.Drawing.Point(133, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 35);
            this.panel1.TabIndex = 114;
            // 
            // cODMPVDataGridViewTextBoxColumn
            // 
            this.cODMPVDataGridViewTextBoxColumn.DataPropertyName = "COD_MPV";
            this.cODMPVDataGridViewTextBoxColumn.HeaderText = "Cód.";
            this.cODMPVDataGridViewTextBoxColumn.Name = "cODMPVDataGridViewTextBoxColumn";
            // 
            // cODVENDEDORMPVDataGridViewTextBoxColumn
            // 
            this.cODVENDEDORMPVDataGridViewTextBoxColumn.DataPropertyName = "COD_VENDEDOR_MPV";
            this.cODVENDEDORMPVDataGridViewTextBoxColumn.HeaderText = "Cód. Vendedor";
            this.cODVENDEDORMPVDataGridViewTextBoxColumn.Name = "cODVENDEDORMPVDataGridViewTextBoxColumn";
            this.cODVENDEDORMPVDataGridViewTextBoxColumn.Visible = false;
            // 
            // fAMILIAMPVDataGridViewTextBoxColumn
            // 
            this.fAMILIAMPVDataGridViewTextBoxColumn.DataPropertyName = "FAMILIA_MPV";
            this.fAMILIAMPVDataGridViewTextBoxColumn.HeaderText = "Família";
            this.fAMILIAMPVDataGridViewTextBoxColumn.Name = "fAMILIAMPVDataGridViewTextBoxColumn";
            this.fAMILIAMPVDataGridViewTextBoxColumn.Width = 300;
            // 
            // mETAFISICAMPVDataGridViewTextBoxColumn
            // 
            this.mETAFISICAMPVDataGridViewTextBoxColumn.DataPropertyName = "META_FISICA_MPV";
            this.mETAFISICAMPVDataGridViewTextBoxColumn.HeaderText = "Meta Física";
            this.mETAFISICAMPVDataGridViewTextBoxColumn.Name = "mETAFISICAMPVDataGridViewTextBoxColumn";
            // 
            // mETAPOSITIVACAOMPVDataGridViewTextBoxColumn
            // 
            this.mETAPOSITIVACAOMPVDataGridViewTextBoxColumn.DataPropertyName = "META_POSITIVACAO_MPV";
            this.mETAPOSITIVACAOMPVDataGridViewTextBoxColumn.HeaderText = "Meta Positivação";
            this.mETAPOSITIVACAOMPVDataGridViewTextBoxColumn.Name = "mETAPOSITIVACAOMPVDataGridViewTextBoxColumn";
            // 
            // mETAVALORMPVDataGridViewTextBoxColumn
            // 
            this.mETAVALORMPVDataGridViewTextBoxColumn.DataPropertyName = "META_VALOR_MPV";
            this.mETAVALORMPVDataGridViewTextBoxColumn.HeaderText = "Meta Valor";
            this.mETAVALORMPVDataGridViewTextBoxColumn.Name = "mETAVALORMPVDataGridViewTextBoxColumn";
            // 
            // labelVendedor
            // 
            this.labelVendedor.AutoSize = true;
            this.labelVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVendedor.Location = new System.Drawing.Point(12, 9);
            this.labelVendedor.Name = "labelVendedor";
            this.labelVendedor.Size = new System.Drawing.Size(100, 37);
            this.labelVendedor.TabIndex = 115;
            this.labelVendedor.Text = "label1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(254, 656);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 23);
            this.button2.TabIndex = 116;
            this.button2.Text = "Importar Famílias";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // form_metas_produto_vendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 691);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelVendedor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvGrupos);
            this.Name = "form_metas_produto_vendedor";
            this.Text = "Metas";
            this.Load += new System.EventHandler(this.form_grupo_produto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGrupos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.METAS_PRODUTO_VENDEDOR)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Data.DataTable METAS_PRODUTO_VENDEDOR;
        private System.Data.DataColumn COD_MPV;
        private System.Data.DataColumn COD_VENDEDOR_MPV;
        private System.Data.DataColumn FAMILIA_MPV;
        private System.Data.DataColumn META_FISICA_MPV;
        private System.Data.DataColumn META_POSITIVACAO_MPV;
        private System.Data.DataColumn META_VALOR_MPV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODMPVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODVENDEDORMPVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fAMILIAMPVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mETAFISICAMPVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mETAPOSITIVACAOMPVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mETAVALORMPVDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label labelVendedor;
        private System.Windows.Forms.Button button2;
    }
}