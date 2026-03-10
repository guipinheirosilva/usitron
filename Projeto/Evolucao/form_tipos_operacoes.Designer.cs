namespace Evolucao
{
    partial class form_tipos_operacoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_tipos_operacoes));
            this.dsTiposdeoperacoes = new System.Data.DataSet();
            this.TIPOS_OPERACOES = new System.Data.DataTable();
            this.COD_TIPO = new System.Data.DataColumn();
            this.QDE_MAQUINAS = new System.Data.DataColumn();
            this.TIPO = new System.Data.DataColumn();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommandBuilder1 = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.datTiposdeoperacoes = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand12 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand10 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand9 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand11 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand5 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand6 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand7 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand8 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.salva_registro = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.dgvTipos_operacoes = new System.Windows.Forms.DataGridView();
            this.dsSetores = new System.Data.DataSet();
            this.SETORES = new System.Data.DataTable();
            this.COD_SETOR = new System.Data.DataColumn();
            this.DESCRICAO_SETOR = new System.Data.DataColumn();
            this.datSetores = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand16 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand14 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand13 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand15 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dataColumn5 = new System.Data.DataColumn();
            this.cODTIPODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qDEMAQUINASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIPODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ABREV_TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SETOR_TIPO = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ORDEM_OPERACAO_TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HORAS_SEMANAIS_DISP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR_OPERACAO_TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposdeoperacoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TIPOS_OPERACOES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipos_operacoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSetores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SETORES)).BeginInit();
            this.SuspendLayout();
            // 
            // dsTiposdeoperacoes
            // 
            this.dsTiposdeoperacoes.DataSetName = "dsTiposdeoperacao";
            this.dsTiposdeoperacoes.Namespace = "http://www.tempuri.org/dsTiposdeoperacao.xsd";
            this.dsTiposdeoperacoes.Tables.AddRange(new System.Data.DataTable[] {
            this.TIPOS_OPERACOES});
            // 
            // TIPOS_OPERACOES
            // 
            this.TIPOS_OPERACOES.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_TIPO,
            this.QDE_MAQUINAS,
            this.TIPO,
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5});
            this.TIPOS_OPERACOES.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_TIPO"}, false)});
            this.TIPOS_OPERACOES.TableName = "TIPOS_OPERACOES";
            // 
            // COD_TIPO
            // 
            this.COD_TIPO.AutoIncrement = true;
            this.COD_TIPO.AutoIncrementSeed = ((long)(1));
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
            this.dataColumn1.ColumnName = "SETOR_TIPO";
            this.dataColumn1.MaxLength = 50;
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "ABREV_TIPO";
            this.dataColumn2.MaxLength = 50;
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "ORDEM_OPERACAO_TIPO";
            this.dataColumn3.DataType = typeof(int);
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "HORAS_SEMANAIS_DISP";
            this.dataColumn4.DataType = typeof(int);
            // 
            // fbConnection1
            // 
            this.fbConnection1.ConnectionString = resources.GetString("fbConnection1.ConnectionString");
            // 
            // fbCommand1
            // 
            this.fbCommand1.CommandText = "select * from tipos_operacoes";
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
            // fbCommandBuilder1
            // 
            this.fbCommandBuilder1.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.fbCommandBuilder1.DataAdapter = this.datTiposdeoperacoes;
            this.fbCommandBuilder1.QuotePrefix = "\"";
            this.fbCommandBuilder1.QuoteSuffix = "\"";
            // 
            // datTiposdeoperacoes
            // 
            this.datTiposdeoperacoes.DeleteCommand = this.fbCommand12;
            this.datTiposdeoperacoes.InsertCommand = this.fbCommand10;
            this.datTiposdeoperacoes.SelectCommand = this.fbCommand9;
            this.datTiposdeoperacoes.UpdateCommand = this.fbCommand11;
            // 
            // fbCommand12
            // 
            this.fbCommand12.CommandTimeout = 30;
            // 
            // fbCommand10
            // 
            this.fbCommand10.CommandTimeout = 30;
            // 
            // fbCommand9
            // 
            this.fbCommand9.CommandText = "select * from tipos_operacoes order by cod_tipo";
            this.fbCommand9.CommandTimeout = 30;
            this.fbCommand9.Connection = this.fbConnection1;
            // 
            // fbCommand11
            // 
            this.fbCommand11.CommandTimeout = 30;
            // 
            // fbCommand5
            // 
            this.fbCommand5.CommandText = "select * from tipos_operacoes";
            this.fbCommand5.CommandTimeout = 30;
            this.fbCommand5.Connection = this.fbConnection1;
            // 
            // fbCommand6
            // 
            this.fbCommand6.CommandTimeout = 30;
            // 
            // fbCommand7
            // 
            this.fbCommand7.CommandTimeout = 30;
            // 
            // fbCommand8
            // 
            this.fbCommand8.CommandTimeout = 30;
            // 
            // salva_registro
            // 
            this.salva_registro.Location = new System.Drawing.Point(360, 359);
            this.salva_registro.Name = "salva_registro";
            this.salva_registro.Size = new System.Drawing.Size(49, 22);
            this.salva_registro.TabIndex = 119;
            this.salva_registro.Text = "Salvar";
            this.salva_registro.UseVisualStyleBackColor = true;
            this.salva_registro.Click += new System.EventHandler(this.salva_registro_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label20.Location = new System.Drawing.Point(283, 9);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(235, 29);
            this.label20.TabIndex = 97;
            this.label20.Text = "Tipos de Operações";
            // 
            // dgvTipos_operacoes
            // 
            this.dgvTipos_operacoes.AutoGenerateColumns = false;
            this.dgvTipos_operacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipos_operacoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODTIPODataGridViewTextBoxColumn,
            this.qDEMAQUINASDataGridViewTextBoxColumn,
            this.tIPODataGridViewTextBoxColumn,
            this.ABREV_TIPO,
            this.SETOR_TIPO,
            this.ORDEM_OPERACAO_TIPO,
            this.HORAS_SEMANAIS_DISP,
            this.VALOR_OPERACAO_TIPO});
            this.dgvTipos_operacoes.DataMember = "TIPOS_OPERACOES";
            this.dgvTipos_operacoes.DataSource = this.dsTiposdeoperacoes;
            this.dgvTipos_operacoes.Location = new System.Drawing.Point(12, 41);
            this.dgvTipos_operacoes.Name = "dgvTipos_operacoes";
            this.dgvTipos_operacoes.Size = new System.Drawing.Size(801, 312);
            this.dgvTipos_operacoes.TabIndex = 120;
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
            // datSetores
            // 
            this.datSetores.DeleteCommand = this.fbCommand16;
            this.datSetores.InsertCommand = this.fbCommand14;
            this.datSetores.SelectCommand = this.fbCommand13;
            this.datSetores.UpdateCommand = this.fbCommand15;
            // 
            // fbCommand16
            // 
            this.fbCommand16.CommandTimeout = 30;
            // 
            // fbCommand14
            // 
            this.fbCommand14.CommandTimeout = 30;
            // 
            // fbCommand13
            // 
            this.fbCommand13.CommandText = "select * from setores";
            this.fbCommand13.CommandTimeout = 30;
            this.fbCommand13.Connection = this.fbConnection1;
            // 
            // fbCommand15
            // 
            this.fbCommand15.CommandTimeout = 30;
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "VALOR_OPERACAO_TIPO";
            this.dataColumn5.DataType = typeof(double);
            // 
            // cODTIPODataGridViewTextBoxColumn
            // 
            this.cODTIPODataGridViewTextBoxColumn.DataPropertyName = "COD_TIPO";
            this.cODTIPODataGridViewTextBoxColumn.HeaderText = "Cód.";
            this.cODTIPODataGridViewTextBoxColumn.Name = "cODTIPODataGridViewTextBoxColumn";
            this.cODTIPODataGridViewTextBoxColumn.Width = 40;
            // 
            // qDEMAQUINASDataGridViewTextBoxColumn
            // 
            this.qDEMAQUINASDataGridViewTextBoxColumn.DataPropertyName = "QDE_MAQUINAS";
            this.qDEMAQUINASDataGridViewTextBoxColumn.HeaderText = "Qtde Máquinas";
            this.qDEMAQUINASDataGridViewTextBoxColumn.Name = "qDEMAQUINASDataGridViewTextBoxColumn";
            this.qDEMAQUINASDataGridViewTextBoxColumn.Width = 70;
            // 
            // tIPODataGridViewTextBoxColumn
            // 
            this.tIPODataGridViewTextBoxColumn.DataPropertyName = "TIPO";
            this.tIPODataGridViewTextBoxColumn.HeaderText = "Operação";
            this.tIPODataGridViewTextBoxColumn.Name = "tIPODataGridViewTextBoxColumn";
            this.tIPODataGridViewTextBoxColumn.Width = 180;
            // 
            // ABREV_TIPO
            // 
            this.ABREV_TIPO.DataPropertyName = "ABREV_TIPO";
            this.ABREV_TIPO.HeaderText = "Abrev";
            this.ABREV_TIPO.Name = "ABREV_TIPO";
            // 
            // SETOR_TIPO
            // 
            this.SETOR_TIPO.DataPropertyName = "SETOR_TIPO";
            this.SETOR_TIPO.DataSource = this.dsSetores;
            this.SETOR_TIPO.DisplayMember = "SETORES.DESCRICAO_SETOR";
            this.SETOR_TIPO.HeaderText = "Setor";
            this.SETOR_TIPO.Name = "SETOR_TIPO";
            this.SETOR_TIPO.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SETOR_TIPO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.SETOR_TIPO.ValueMember = "SETORES.DESCRICAO_SETOR";
            this.SETOR_TIPO.Width = 130;
            // 
            // ORDEM_OPERACAO_TIPO
            // 
            this.ORDEM_OPERACAO_TIPO.DataPropertyName = "ORDEM_OPERACAO_TIPO";
            this.ORDEM_OPERACAO_TIPO.HeaderText = "Ordem";
            this.ORDEM_OPERACAO_TIPO.Name = "ORDEM_OPERACAO_TIPO";
            this.ORDEM_OPERACAO_TIPO.Width = 40;
            // 
            // HORAS_SEMANAIS_DISP
            // 
            this.HORAS_SEMANAIS_DISP.DataPropertyName = "HORAS_SEMANAIS_DISP";
            this.HORAS_SEMANAIS_DISP.HeaderText = "Horas/Semana";
            this.HORAS_SEMANAIS_DISP.Name = "HORAS_SEMANAIS_DISP";
            // 
            // VALOR_OPERACAO_TIPO
            // 
            this.VALOR_OPERACAO_TIPO.DataPropertyName = "VALOR_OPERACAO_TIPO";
            this.VALOR_OPERACAO_TIPO.HeaderText = "Valor Hora";
            this.VALOR_OPERACAO_TIPO.Name = "VALOR_OPERACAO_TIPO";
            this.VALOR_OPERACAO_TIPO.Width = 90;
            // 
            // form_tipos_operacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 413);
            this.Controls.Add(this.dgvTipos_operacoes);
            this.Controls.Add(this.salva_registro);
            this.Controls.Add(this.label20);
            this.Name = "form_tipos_operacoes";
            this.Text = "Tipos de Operações";
            this.Load += new System.EventHandler(this.form__Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposdeoperacoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TIPOS_OPERACOES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipos_operacoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSetores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SETORES)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder fbCommandBuilder1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand8;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand6;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand5;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand7;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datTiposdeoperacoes;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand12;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand10;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand9;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand11;
        private System.Data.DataSet dsTiposdeoperacoes;
        private System.Data.DataTable TIPOS_OPERACOES;
        private System.Data.DataColumn COD_TIPO;
        private System.Data.DataColumn QDE_MAQUINAS;
        private System.Data.DataColumn TIPO;
        private System.Windows.Forms.Button salva_registro;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridView dgvTipos_operacoes;
        private System.Data.DataColumn dataColumn1;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datSetores;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand16;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand14;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand13;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand15;
        private System.Data.DataSet dsSetores;
        private System.Data.DataTable SETORES;
        private System.Data.DataColumn COD_SETOR;
        private System.Data.DataColumn DESCRICAO_SETOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORASSEMANATIPODataGridViewTextBoxColumn;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODTIPODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qDEMAQUINASDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIPODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ABREV_TIPO;
        private System.Windows.Forms.DataGridViewComboBoxColumn SETOR_TIPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORDEM_OPERACAO_TIPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORAS_SEMANAIS_DISP;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR_OPERACAO_TIPO;
    }
}