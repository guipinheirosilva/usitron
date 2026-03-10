namespace Evolucao
{
    partial class form_localiza_operacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_localiza_operacao));
            this.tb_localiza = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cODTIPODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qDEMAQUINASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_abrev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SETOR_TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsTipos_operacoes = new System.Data.DataSet();
            this.TIPOS_OPERACOES = new System.Data.DataTable();
            this.COD_TIPO = new System.Data.DataColumn();
            this.QDE_MAQUINAS = new System.Data.DataColumn();
            this.TIPO = new System.Data.DataColumn();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.datTipos_operacoes = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTipos_operacoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TIPOS_OPERACOES)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_localiza
            // 
            this.tb_localiza.Location = new System.Drawing.Point(8, 22);
            this.tb_localiza.Name = "tb_localiza";
            this.tb_localiza.Size = new System.Drawing.Size(181, 20);
            this.tb_localiza.TabIndex = 7;
            this.tb_localiza.TextChanged += new System.EventHandler(this.tb_localiza_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODTIPODataGridViewTextBoxColumn,
            this.qDEMAQUINASDataGridViewTextBoxColumn,
            this.col_abrev,
            this.col_tipo,
            this.SETOR_TIPO});
            this.dataGridView1.DataMember = "TIPOS_OPERACOES";
            this.dataGridView1.DataSource = this.dsTipos_operacoes;
            this.dataGridView1.Location = new System.Drawing.Point(2, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(401, 415);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView1_KeyPress);
            // 
            // cODTIPODataGridViewTextBoxColumn
            // 
            this.cODTIPODataGridViewTextBoxColumn.DataPropertyName = "COD_TIPO";
            this.cODTIPODataGridViewTextBoxColumn.HeaderText = "COD_TIPO";
            this.cODTIPODataGridViewTextBoxColumn.Name = "cODTIPODataGridViewTextBoxColumn";
            this.cODTIPODataGridViewTextBoxColumn.Visible = false;
            // 
            // qDEMAQUINASDataGridViewTextBoxColumn
            // 
            this.qDEMAQUINASDataGridViewTextBoxColumn.DataPropertyName = "QDE_MAQUINAS";
            this.qDEMAQUINASDataGridViewTextBoxColumn.HeaderText = "QDE_MAQUINAS";
            this.qDEMAQUINASDataGridViewTextBoxColumn.Name = "qDEMAQUINASDataGridViewTextBoxColumn";
            this.qDEMAQUINASDataGridViewTextBoxColumn.Visible = false;
            // 
            // col_abrev
            // 
            this.col_abrev.DataPropertyName = "ABREV_TIPO";
            this.col_abrev.HeaderText = "ABREV_TIPO";
            this.col_abrev.Name = "col_abrev";
            this.col_abrev.Width = 60;
            // 
            // col_tipo
            // 
            this.col_tipo.DataPropertyName = "TIPO";
            this.col_tipo.HeaderText = "TIPO";
            this.col_tipo.Name = "col_tipo";
            this.col_tipo.Width = 150;
            // 
            // SETOR_TIPO
            // 
            this.SETOR_TIPO.DataPropertyName = "SETOR_TIPO";
            this.SETOR_TIPO.HeaderText = "Setor";
            this.SETOR_TIPO.Name = "SETOR_TIPO";
            // 
            // dsTipos_operacoes
            // 
            this.dsTipos_operacoes.DataSetName = "dsTipos_operacoes";
            this.dsTipos_operacoes.Namespace = "http://www.tempuri.org/dsTipos_operacoes.xsd";
            this.dsTipos_operacoes.Tables.AddRange(new System.Data.DataTable[] {
            this.TIPOS_OPERACOES});
            // 
            // TIPOS_OPERACOES
            // 
            this.TIPOS_OPERACOES.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_TIPO,
            this.QDE_MAQUINAS,
            this.TIPO,
            this.dataColumn1,
            this.dataColumn2});
            this.TIPOS_OPERACOES.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_TIPO"}, false)});
            this.TIPOS_OPERACOES.TableName = "TIPOS_OPERACOES";
            // 
            // COD_TIPO
            // 
            this.COD_TIPO.ColumnName = "COD_TIPO";
            this.COD_TIPO.DataType = typeof(int);
            // 
            // QDE_MAQUINAS
            // 
            this.QDE_MAQUINAS.ColumnName = "QDE_MAQUINAS";
            this.QDE_MAQUINAS.DataType = typeof(int);
            // 
            // TIPO
            // 
            this.TIPO.ColumnName = "TIPO";
            this.TIPO.MaxLength = 40;
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "ABREV_TIPO";
            this.dataColumn1.MaxLength = 50;
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "SETOR_TIPO";
            this.dataColumn2.MaxLength = 50;
            // 
            // datTipos_operacoes
            // 
            this.datTipos_operacoes.DeleteCommand = this.fbCommand4;
            this.datTipos_operacoes.InsertCommand = this.fbCommand2;
            this.datTipos_operacoes.SelectCommand = this.fbCommand1;
            this.datTipos_operacoes.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * from tipos_operacoes order by cod_tipo";
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(147, 509);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Confirmar seleção";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Operação";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Setor";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(215, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tb_localiza);
            this.panel1.Location = new System.Drawing.Point(4, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 54);
            this.panel1.TabIndex = 12;
            // 
            // form_localiza_operacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 537);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "form_localiza_operacao";
            this.Text = "Localiza Operação";
            this.Load += new System.EventHandler(this.form_localiza_operacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTipos_operacoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TIPOS_OPERACOES)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tb_localiza;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datTipos_operacoes;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private System.Data.DataSet dsTipos_operacoes;
        private System.Data.DataTable TIPOS_OPERACOES;
        private System.Data.DataColumn COD_TIPO;
        private System.Data.DataColumn QDE_MAQUINAS;
        private System.Data.DataColumn TIPO;
        private System.Windows.Forms.Button button1;
        private System.Data.DataColumn dataColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODTIPODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qDEMAQUINASDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_abrev;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SETOR_TIPO;
        private System.Data.DataColumn dataColumn2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
    }
}