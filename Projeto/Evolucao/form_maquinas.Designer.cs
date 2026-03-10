namespace Evolucao
{
    partial class form_maquinas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_maquinas));
            this.salva_registro = new System.Windows.Forms.Button();
            this.dsMaquinas = new System.Data.DataSet();
            this.MAQUINAS = new System.Data.DataTable();
            this.COD_MAQUINA = new System.Data.DataColumn();
            this.MAQUINA = new System.Data.DataColumn();
            this.ABREVIACAO = new System.Data.DataColumn();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.label20 = new System.Windows.Forms.Label();
            this.datMaquinas = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.cbMaquinas = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.dgvMaquinas = new System.Windows.Forms.DataGridView();
            this.codMaquina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAQUINA_MAQUINA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_abreviacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sETORMAQUINADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsSetores = new System.Data.DataSet();
            this.SETORES = new System.Data.DataTable();
            this.COD_SETOR = new System.Data.DataColumn();
            this.DESCRICAO_SETOR = new System.Data.DataColumn();
            this.hORASSEMANAMAQUINADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datSetores = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand8 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand6 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand5 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand7 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaquinas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MAQUINAS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaquinas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSetores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SETORES)).BeginInit();
            this.SuspendLayout();
            // 
            // salva_registro
            // 
            this.salva_registro.Location = new System.Drawing.Point(389, 709);
            this.salva_registro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.salva_registro.Name = "salva_registro";
            this.salva_registro.Size = new System.Drawing.Size(65, 27);
            this.salva_registro.TabIndex = 133;
            this.salva_registro.Text = "Salvar";
            this.salva_registro.UseVisualStyleBackColor = true;
            this.salva_registro.Click += new System.EventHandler(this.salva_registro_Click);
            // 
            // dsMaquinas
            // 
            this.dsMaquinas.DataSetName = "dsMaquinas";
            this.dsMaquinas.Namespace = "http://www.tempuri.org/dsMaquinas.xsd";
            this.dsMaquinas.Tables.AddRange(new System.Data.DataTable[] {
            this.MAQUINAS});
            // 
            // MAQUINAS
            // 
            this.MAQUINAS.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_MAQUINA,
            this.MAQUINA,
            this.ABREVIACAO,
            this.dataColumn1,
            this.dataColumn2});
            this.MAQUINAS.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_MAQUINA"}, true)});
            this.MAQUINAS.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_MAQUINA};
            this.MAQUINAS.TableName = "MAQUINAS";
            // 
            // COD_MAQUINA
            // 
            this.COD_MAQUINA.AllowDBNull = false;
            this.COD_MAQUINA.AutoIncrement = true;
            this.COD_MAQUINA.ColumnName = "COD_MAQUINA";
            this.COD_MAQUINA.DataType = typeof(int);
            // 
            // MAQUINA
            // 
            this.MAQUINA.ColumnName = "MAQUINA_MAQUINA";
            this.MAQUINA.MaxLength = 30;
            // 
            // ABREVIACAO
            // 
            this.ABREVIACAO.ColumnName = "ABREVIACAO_MAQUINA";
            this.ABREVIACAO.MaxLength = 30;
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "SETOR_MAQUINA";
            this.dataColumn1.MaxLength = 50;
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "HORAS_SEMANA_MAQUINA";
            this.dataColumn2.DataType = typeof(double);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label20.Location = new System.Drawing.Point(361, 0);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(145, 36);
            this.label20.TabIndex = 125;
            this.label20.Text = "Máquinas";
            // 
            // datMaquinas
            // 
            this.datMaquinas.DeleteCommand = this.fbCommand4;
            this.datMaquinas.InsertCommand = this.fbCommand2;
            this.datMaquinas.SelectCommand = this.fbCommand1;
            this.datMaquinas.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * from maquinas order by cod_maquina";
            this.fbCommand1.CommandTimeout = 30;
            // 
            // fbCommand3
            // 
            this.fbCommand3.CommandTimeout = 30;
            // 
            // cbMaquinas
            // 
            this.cbMaquinas.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbMaquinas.DataAdapter = this.datMaquinas;
            this.cbMaquinas.QuotePrefix = "\"";
            this.cbMaquinas.QuoteSuffix = "\"";
            // 
            // dgvMaquinas
            // 
            this.dgvMaquinas.AutoGenerateColumns = false;
            this.dgvMaquinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaquinas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codMaquina,
            this.MAQUINA_MAQUINA,
            this.col_abreviacao,
            this.sETORMAQUINADataGridViewTextBoxColumn,
            this.hORASSEMANAMAQUINADataGridViewTextBoxColumn});
            this.dgvMaquinas.DataMember = "MAQUINAS";
            this.dgvMaquinas.DataSource = this.dsMaquinas;
            this.dgvMaquinas.Location = new System.Drawing.Point(16, 50);
            this.dgvMaquinas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvMaquinas.Name = "dgvMaquinas";
            this.dgvMaquinas.Size = new System.Drawing.Size(848, 651);
            this.dgvMaquinas.TabIndex = 134;
            this.dgvMaquinas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaquinas_CellDoubleClick);
            // 
            // codMaquina
            // 
            this.codMaquina.DataPropertyName = "COD_MAQUINA";
            this.codMaquina.HeaderText = "COD_MAQUINA";
            this.codMaquina.Name = "codMaquina";
            this.codMaquina.Visible = false;
            // 
            // MAQUINA_MAQUINA
            // 
            this.MAQUINA_MAQUINA.DataPropertyName = "MAQUINA_MAQUINA";
            this.MAQUINA_MAQUINA.HeaderText = "Maquina";
            this.MAQUINA_MAQUINA.Name = "MAQUINA_MAQUINA";
            // 
            // col_abreviacao
            // 
            this.col_abreviacao.DataPropertyName = "ABREVIACAO_MAQUINA";
            this.col_abreviacao.HeaderText = "Abreviação";
            this.col_abreviacao.Name = "col_abreviacao";
            // 
            // sETORMAQUINADataGridViewTextBoxColumn
            // 
            this.sETORMAQUINADataGridViewTextBoxColumn.DataPropertyName = "SETOR_MAQUINA";
            this.sETORMAQUINADataGridViewTextBoxColumn.DataSource = this.dsSetores;
            this.sETORMAQUINADataGridViewTextBoxColumn.DisplayMember = "SETORES.DESCRICAO_SETOR";
            this.sETORMAQUINADataGridViewTextBoxColumn.HeaderText = "Setor";
            this.sETORMAQUINADataGridViewTextBoxColumn.Name = "sETORMAQUINADataGridViewTextBoxColumn";
            this.sETORMAQUINADataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sETORMAQUINADataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sETORMAQUINADataGridViewTextBoxColumn.ValueMember = "SETORES.DESCRICAO_SETOR";
            this.sETORMAQUINADataGridViewTextBoxColumn.Width = 150;
            // 
            // dsSetores
            // 
            this.dsSetores.DataSetName = "dsSetores";
            this.dsSetores.Namespace = "http://www.tempuri.org/dsSetores.xsd";
            this.dsSetores.Tables.AddRange(new System.Data.DataTable[] {
            this.SETORES});
            // 
            // SETORES
            // 
            this.SETORES.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_SETOR,
            this.DESCRICAO_SETOR});
            this.SETORES.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_SETOR"}, true)});
            this.SETORES.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_SETOR};
            this.SETORES.TableName = "SETORES";
            // 
            // COD_SETOR
            // 
            this.COD_SETOR.AllowDBNull = false;
            this.COD_SETOR.ColumnName = "COD_SETOR";
            this.COD_SETOR.DataType = typeof(int);
            // 
            // DESCRICAO_SETOR
            // 
            this.DESCRICAO_SETOR.ColumnName = "DESCRICAO_SETOR";
            this.DESCRICAO_SETOR.MaxLength = 50;
            // 
            // hORASSEMANAMAQUINADataGridViewTextBoxColumn
            // 
            this.hORASSEMANAMAQUINADataGridViewTextBoxColumn.DataPropertyName = "HORAS_SEMANA_MAQUINA";
            this.hORASSEMANAMAQUINADataGridViewTextBoxColumn.HeaderText = "Horas Semana";
            this.hORASSEMANAMAQUINADataGridViewTextBoxColumn.Name = "hORASSEMANAMAQUINADataGridViewTextBoxColumn";
            // 
            // datSetores
            // 
            this.datSetores.DeleteCommand = this.fbCommand8;
            this.datSetores.InsertCommand = this.fbCommand6;
            this.datSetores.SelectCommand = this.fbCommand5;
            this.datSetores.UpdateCommand = this.fbCommand7;
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
            this.fbCommand5.CommandText = "select * from setores";
            this.fbCommand5.CommandTimeout = 30;
            // 
            // fbCommand7
            // 
            this.fbCommand7.CommandTimeout = 30;
            // 
            // fbConnection1
            // 
            this.fbConnection1.ConnectionString = resources.GetString("fbConnection1.ConnectionString");
            // 
            // form_maquinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 737);
            this.Controls.Add(this.dgvMaquinas);
            this.Controls.Add(this.salva_registro);
            this.Controls.Add(this.label20);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "form_maquinas";
            this.Text = "Máquinas";
            this.Load += new System.EventHandler(this.form_maquinas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsMaquinas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MAQUINAS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaquinas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSetores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SETORES)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button salva_registro;
        private System.Windows.Forms.Label label20;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datMaquinas;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Data.DataSet dsMaquinas;
        private System.Data.DataTable MAQUINAS;
        private System.Data.DataColumn COD_MAQUINA;
        private System.Data.DataColumn MAQUINA;
        private System.Data.DataColumn ABREVIACAO;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbMaquinas;
        private System.Windows.Forms.DataGridView dgvMaquinas;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datSetores;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand8;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand6;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand5;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand7;
        private System.Data.DataSet dsSetores;
        private System.Data.DataTable SETORES;
        private System.Data.DataColumn COD_SETOR;
        private System.Data.DataColumn DESCRICAO_SETOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn codMaquina;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAQUINA_MAQUINA;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_abreviacao;
        private System.Windows.Forms.DataGridViewComboBoxColumn sETORMAQUINADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORASSEMANAMAQUINADataGridViewTextBoxColumn;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
    }
}