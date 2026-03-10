namespace Evolucao
{
    partial class form_nova_despesa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_nova_despesa));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tb_molde = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.datDespesas_molde = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.dsDespesas_molde = new System.Data.DataSet();
            this.DESPESAS_MOLDE = new System.Data.DataTable();
            this.COD_DESPESA = new System.Data.DataColumn();
            this.VALOR_DESPESA = new System.Data.DataColumn();
            this.FORNECEDOR_DESPESA = new System.Data.DataColumn();
            this.OBS_DESPESA = new System.Data.DataColumn();
            this.OS_DESPESA = new System.Data.DataColumn();
            this.dgvPgtos = new System.Windows.Forms.DataGridView();
            this.cODDESPESADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fORNECEDORDESPESADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_obs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oSDESPESADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_forn = new System.Windows.Forms.TextBox();
            this.tb_obs = new System.Windows.Forms.TextBox();
            this.tb_valor = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dsDespesas_molde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DESPESAS_MOLDE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPgtos)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_molde
            // 
            this.tb_molde.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_molde.Location = new System.Drawing.Point(232, 14);
            this.tb_molde.Name = "tb_molde";
            this.tb_molde.Size = new System.Drawing.Size(111, 31);
            this.tb_molde.TabIndex = 241;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(22, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 26);
            this.label1.TabIndex = 240;
            this.label1.Text = "Despesas do Molde";
            // 
            // datDespesas_molde
            // 
            this.datDespesas_molde.DeleteCommand = this.fbCommand4;
            this.datDespesas_molde.InsertCommand = this.fbCommand2;
            this.datDespesas_molde.SelectCommand = this.fbCommand1;
            this.datDespesas_molde.UpdateCommand = this.fbCommand3;
            // 
            // fbCommand1
            // 
            this.fbCommand1.CommandText = "select * from despesas_molde";
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
            // dsDespesas_molde
            // 
            this.dsDespesas_molde.DataSetName = "dsDespesas_molde";
            this.dsDespesas_molde.Namespace = "http://www.tempuri.org/dsDespesas_molde.xsd";
            this.dsDespesas_molde.Tables.AddRange(new System.Data.DataTable[] {
            this.DESPESAS_MOLDE});
            // 
            // DESPESAS_MOLDE
            // 
            this.DESPESAS_MOLDE.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_DESPESA,
            this.VALOR_DESPESA,
            this.FORNECEDOR_DESPESA,
            this.OBS_DESPESA,
            this.OS_DESPESA});
            this.DESPESAS_MOLDE.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_DESPESA"}, true)});
            this.DESPESAS_MOLDE.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_DESPESA};
            this.DESPESAS_MOLDE.TableName = "DESPESAS_MOLDE";
            // 
            // COD_DESPESA
            // 
            this.COD_DESPESA.AllowDBNull = false;
            this.COD_DESPESA.ColumnName = "COD_DESPESA";
            this.COD_DESPESA.DataType = typeof(int);
            // 
            // VALOR_DESPESA
            // 
            this.VALOR_DESPESA.ColumnName = "VALOR_DESPESA";
            this.VALOR_DESPESA.DataType = typeof(double);
            // 
            // FORNECEDOR_DESPESA
            // 
            this.FORNECEDOR_DESPESA.ColumnName = "FORNECEDOR_DESPESA";
            this.FORNECEDOR_DESPESA.MaxLength = 100;
            // 
            // OBS_DESPESA
            // 
            this.OBS_DESPESA.ColumnName = "OBS_DESPESA";
            this.OBS_DESPESA.MaxLength = 200;
            // 
            // OS_DESPESA
            // 
            this.OS_DESPESA.ColumnName = "OS_DESPESA";
            this.OS_DESPESA.MaxLength = 30;
            // 
            // dgvPgtos
            // 
            this.dgvPgtos.AutoGenerateColumns = false;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPgtos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvPgtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPgtos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODDESPESADataGridViewTextBoxColumn,
            this.fORNECEDORDESPESADataGridViewTextBoxColumn,
            this.col_obs,
            this.col_valor,
            this.oSDESPESADataGridViewTextBoxColumn});
            this.dgvPgtos.DataMember = "DESPESAS_MOLDE";
            this.dgvPgtos.DataSource = this.dsDespesas_molde;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPgtos.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvPgtos.Location = new System.Drawing.Point(27, 109);
            this.dgvPgtos.Name = "dgvPgtos";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPgtos.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvPgtos.Size = new System.Drawing.Size(510, 143);
            this.dgvPgtos.TabIndex = 242;
            // 
            // cODDESPESADataGridViewTextBoxColumn
            // 
            this.cODDESPESADataGridViewTextBoxColumn.DataPropertyName = "COD_DESPESA";
            this.cODDESPESADataGridViewTextBoxColumn.HeaderText = "Cód.";
            this.cODDESPESADataGridViewTextBoxColumn.Name = "cODDESPESADataGridViewTextBoxColumn";
            this.cODDESPESADataGridViewTextBoxColumn.Width = 50;
            // 
            // fORNECEDORDESPESADataGridViewTextBoxColumn
            // 
            this.fORNECEDORDESPESADataGridViewTextBoxColumn.DataPropertyName = "FORNECEDOR_DESPESA";
            this.fORNECEDORDESPESADataGridViewTextBoxColumn.HeaderText = "Fornecedor";
            this.fORNECEDORDESPESADataGridViewTextBoxColumn.Name = "fORNECEDORDESPESADataGridViewTextBoxColumn";
            this.fORNECEDORDESPESADataGridViewTextBoxColumn.Width = 150;
            // 
            // col_obs
            // 
            this.col_obs.DataPropertyName = "OBS_DESPESA";
            this.col_obs.HeaderText = "Observação";
            this.col_obs.Name = "col_obs";
            this.col_obs.Width = 150;
            // 
            // col_valor
            // 
            this.col_valor.DataPropertyName = "VALOR_DESPESA";
            this.col_valor.HeaderText = "Valor";
            this.col_valor.Name = "col_valor";
            // 
            // oSDESPESADataGridViewTextBoxColumn
            // 
            this.oSDESPESADataGridViewTextBoxColumn.DataPropertyName = "OS_DESPESA";
            this.oSDESPESADataGridViewTextBoxColumn.HeaderText = "OS_DESPESA";
            this.oSDESPESADataGridViewTextBoxColumn.Name = "oSDESPESADataGridViewTextBoxColumn";
            this.oSDESPESADataGridViewTextBoxColumn.Visible = false;
            // 
            // tb_forn
            // 
            this.tb_forn.Location = new System.Drawing.Point(119, 84);
            this.tb_forn.Name = "tb_forn";
            this.tb_forn.Size = new System.Drawing.Size(149, 20);
            this.tb_forn.TabIndex = 243;
            // 
            // tb_obs
            // 
            this.tb_obs.Location = new System.Drawing.Point(268, 84);
            this.tb_obs.Name = "tb_obs";
            this.tb_obs.Size = new System.Drawing.Size(151, 20);
            this.tb_obs.TabIndex = 244;
            // 
            // tb_valor
            // 
            this.tb_valor.Location = new System.Drawing.Point(419, 84);
            this.tb_valor.Name = "tb_valor";
            this.tb_valor.Size = new System.Drawing.Size(101, 20);
            this.tb_valor.TabIndex = 245;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(70, 84);
            this.button1.Margin = new System.Windows.Forms.Padding(1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 19);
            this.button1.TabIndex = 246;
            this.button1.Text = "Incluir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(70, 61);
            this.button2.Margin = new System.Windows.Forms.Padding(1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 19);
            this.button2.TabIndex = 247;
            this.button2.Text = "Excluir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(23, 84);
            this.button3.Margin = new System.Windows.Forms.Padding(1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 19);
            this.button3.TabIndex = 248;
            this.button3.Text = "Alterar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // form_nova_despesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 264);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_valor);
            this.Controls.Add(this.tb_obs);
            this.Controls.Add(this.tb_forn);
            this.Controls.Add(this.dgvPgtos);
            this.Controls.Add(this.tb_molde);
            this.Controls.Add(this.label1);
            this.Name = "form_nova_despesa";
            this.Text = "Inserir despesas";
            this.Load += new System.EventHandler(this.form_nova_despesa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsDespesas_molde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DESPESAS_MOLDE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPgtos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_molde;
        private System.Windows.Forms.Label label1;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datDespesas_molde;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private System.Data.DataSet dsDespesas_molde;
        private System.Data.DataTable DESPESAS_MOLDE;
        private System.Data.DataColumn COD_DESPESA;
        private System.Data.DataColumn VALOR_DESPESA;
        private System.Data.DataColumn FORNECEDOR_DESPESA;
        private System.Data.DataColumn OBS_DESPESA;
        private System.Data.DataColumn OS_DESPESA;
        private System.Windows.Forms.DataGridView dgvPgtos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODDESPESADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fORNECEDORDESPESADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_obs;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn oSDESPESADataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox tb_forn;
        private System.Windows.Forms.TextBox tb_obs;
        private System.Windows.Forms.TextBox tb_valor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}