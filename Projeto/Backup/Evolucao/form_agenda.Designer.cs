namespace Evolucao
{
    partial class form_agenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_agenda));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.datAgenda_os = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.dsAgenda_os = new System.Data.DataSet();
            this.AGENDA_OS = new System.Data.DataTable();
            this.COD_AGENDA_OS = new System.Data.DataColumn();
            this.OS_AGENDA_OS = new System.Data.DataColumn();
            this.CLIENTE_AGENDA_OS = new System.Data.DataColumn();
            this.DESCRICAO_AGENDA_OS = new System.Data.DataColumn();
            this.DATA_AGENDA_OS = new System.Data.DataColumn();
            this.TIPO_OCORRENCIA_AGENDA_OS = new System.Data.DataColumn();
            this.FINALIZADO_AGENDA_OS = new System.Data.DataColumn();
            this.HORA_AGENDA_OS = new System.Data.DataColumn();
            this.cbAgenda_os = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.btSalvar = new System.Windows.Forms.Button();
            this.bt_excluir = new System.Windows.Forms.Button();
            this.dgvAgenda = new System.Windows.Forms.DataGridView();
            this.oSAGENDAOSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTEAGENDAOSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRICAOAGENDAOSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIPOOCORRENCIAAGENDAOSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAAGENDAOSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.col_cod_agenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label20 = new System.Windows.Forms.Label();
            this.tb_criterio = new System.Windows.Forms.TextBox();
            this.gbPesquisa = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_campo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_imprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dsAgenda_os)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AGENDA_OS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).BeginInit();
            this.gbPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // datAgenda_os
            // 
            this.datAgenda_os.DeleteCommand = this.fbCommand4;
            this.datAgenda_os.InsertCommand = this.fbCommand2;
            this.datAgenda_os.SelectCommand = this.fbCommand1;
            this.datAgenda_os.UpdateCommand = this.fbCommand3;
            // 
            // fbCommand1
            // 
            this.fbCommand1.CommandText = "select * from agenda_os";
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
            // dsAgenda_os
            // 
            this.dsAgenda_os.DataSetName = "dsAgenda_os";
            this.dsAgenda_os.Namespace = "http://www.tempuri.org/dsAgenda_os.xsd";
            this.dsAgenda_os.Tables.AddRange(new System.Data.DataTable[] {
            this.AGENDA_OS});
            // 
            // AGENDA_OS
            // 
            this.AGENDA_OS.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_AGENDA_OS,
            this.OS_AGENDA_OS,
            this.CLIENTE_AGENDA_OS,
            this.DESCRICAO_AGENDA_OS,
            this.DATA_AGENDA_OS,
            this.TIPO_OCORRENCIA_AGENDA_OS,
            this.FINALIZADO_AGENDA_OS,
            this.HORA_AGENDA_OS});
            this.AGENDA_OS.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_AGENDA_OS"}, true)});
            this.AGENDA_OS.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_AGENDA_OS};
            this.AGENDA_OS.TableName = "AGENDA_OS";
            // 
            // COD_AGENDA_OS
            // 
            this.COD_AGENDA_OS.AllowDBNull = false;
            this.COD_AGENDA_OS.ColumnName = "COD_AGENDA_OS";
            this.COD_AGENDA_OS.DataType = typeof(int);
            // 
            // OS_AGENDA_OS
            // 
            this.OS_AGENDA_OS.ColumnName = "OS_AGENDA_OS";
            this.OS_AGENDA_OS.MaxLength = 20;
            // 
            // CLIENTE_AGENDA_OS
            // 
            this.CLIENTE_AGENDA_OS.ColumnName = "CLIENTE_AGENDA_OS";
            this.CLIENTE_AGENDA_OS.MaxLength = 100;
            // 
            // DESCRICAO_AGENDA_OS
            // 
            this.DESCRICAO_AGENDA_OS.ColumnName = "DESCRICAO_AGENDA_OS";
            this.DESCRICAO_AGENDA_OS.MaxLength = 300;
            // 
            // DATA_AGENDA_OS
            // 
            this.DATA_AGENDA_OS.ColumnName = "DATA_AGENDA_OS";
            this.DATA_AGENDA_OS.DataType = typeof(System.DateTime);
            // 
            // TIPO_OCORRENCIA_AGENDA_OS
            // 
            this.TIPO_OCORRENCIA_AGENDA_OS.ColumnName = "TIPO_OCORRENCIA_AGENDA_OS";
            this.TIPO_OCORRENCIA_AGENDA_OS.MaxLength = 50;
            // 
            // FINALIZADO_AGENDA_OS
            // 
            this.FINALIZADO_AGENDA_OS.ColumnName = "FINALIZADO_AGENDA_OS";
            this.FINALIZADO_AGENDA_OS.DataType = typeof(int);
            // 
            // HORA_AGENDA_OS
            // 
            this.HORA_AGENDA_OS.ColumnName = "HORA_AGENDA_OS";
            this.HORA_AGENDA_OS.DataType = typeof(System.DateTime);
            // 
            // cbAgenda_os
            // 
            this.cbAgenda_os.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbAgenda_os.DataAdapter = this.datAgenda_os;
            this.cbAgenda_os.QuotePrefix = "\"";
            this.cbAgenda_os.QuoteSuffix = "\"";
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(12, 144);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(47, 23);
            this.btSalvar.TabIndex = 239;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // bt_excluir
            // 
            this.bt_excluir.Location = new System.Drawing.Point(12, 115);
            this.bt_excluir.Name = "bt_excluir";
            this.bt_excluir.Size = new System.Drawing.Size(47, 23);
            this.bt_excluir.TabIndex = 238;
            this.bt_excluir.Text = "Excluir";
            this.bt_excluir.UseVisualStyleBackColor = true;
            this.bt_excluir.Click += new System.EventHandler(this.bt_excluir_Click);
            // 
            // dgvAgenda
            // 
            this.dgvAgenda.AllowUserToAddRows = false;
            this.dgvAgenda.AllowUserToDeleteRows = false;
            this.dgvAgenda.AutoGenerateColumns = false;
            this.dgvAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oSAGENDAOSDataGridViewTextBoxColumn,
            this.cLIENTEAGENDAOSDataGridViewTextBoxColumn,
            this.dESCRICAOAGENDAOSDataGridViewTextBoxColumn,
            this.tIPOOCORRENCIAAGENDAOSDataGridViewTextBoxColumn,
            this.dATAAGENDAOSDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewCheckBoxColumn1,
            this.col_cod_agenda});
            this.dgvAgenda.DataMember = "AGENDA_OS";
            this.dgvAgenda.DataSource = this.dsAgenda_os;
            this.dgvAgenda.Location = new System.Drawing.Point(65, 115);
            this.dgvAgenda.Name = "dgvAgenda";
            this.dgvAgenda.Size = new System.Drawing.Size(969, 330);
            this.dgvAgenda.TabIndex = 236;
            // 
            // oSAGENDAOSDataGridViewTextBoxColumn
            // 
            this.oSAGENDAOSDataGridViewTextBoxColumn.DataPropertyName = "OS_AGENDA_OS";
            this.oSAGENDAOSDataGridViewTextBoxColumn.HeaderText = "OS";
            this.oSAGENDAOSDataGridViewTextBoxColumn.Name = "oSAGENDAOSDataGridViewTextBoxColumn";
            this.oSAGENDAOSDataGridViewTextBoxColumn.Width = 60;
            // 
            // cLIENTEAGENDAOSDataGridViewTextBoxColumn
            // 
            this.cLIENTEAGENDAOSDataGridViewTextBoxColumn.DataPropertyName = "CLIENTE_AGENDA_OS";
            this.cLIENTEAGENDAOSDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.cLIENTEAGENDAOSDataGridViewTextBoxColumn.Name = "cLIENTEAGENDAOSDataGridViewTextBoxColumn";
            this.cLIENTEAGENDAOSDataGridViewTextBoxColumn.Width = 120;
            // 
            // dESCRICAOAGENDAOSDataGridViewTextBoxColumn
            // 
            this.dESCRICAOAGENDAOSDataGridViewTextBoxColumn.DataPropertyName = "DESCRICAO_AGENDA_OS";
            this.dESCRICAOAGENDAOSDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.dESCRICAOAGENDAOSDataGridViewTextBoxColumn.Name = "dESCRICAOAGENDAOSDataGridViewTextBoxColumn";
            this.dESCRICAOAGENDAOSDataGridViewTextBoxColumn.Width = 350;
            // 
            // tIPOOCORRENCIAAGENDAOSDataGridViewTextBoxColumn
            // 
            this.tIPOOCORRENCIAAGENDAOSDataGridViewTextBoxColumn.DataPropertyName = "TIPO_OCORRENCIA_AGENDA_OS";
            this.tIPOOCORRENCIAAGENDAOSDataGridViewTextBoxColumn.HeaderText = "Tipo Ocorrência";
            this.tIPOOCORRENCIAAGENDAOSDataGridViewTextBoxColumn.Name = "tIPOOCORRENCIAAGENDAOSDataGridViewTextBoxColumn";
            this.tIPOOCORRENCIAAGENDAOSDataGridViewTextBoxColumn.Width = 150;
            // 
            // dATAAGENDAOSDataGridViewTextBoxColumn
            // 
            this.dATAAGENDAOSDataGridViewTextBoxColumn.DataPropertyName = "DATA_AGENDA_OS";
            this.dATAAGENDAOSDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dATAAGENDAOSDataGridViewTextBoxColumn.Name = "dATAAGENDAOSDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "HORA_AGENDA_OS";
            dataGridViewCellStyle5.Format = "t";
            dataGridViewCellStyle5.NullValue = null;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn1.HeaderText = "Hora";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "FINALIZADO_AGENDA_OS";
            this.dataGridViewCheckBoxColumn1.FalseValue = "0";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Ok";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewCheckBoxColumn1.TrueValue = "1";
            this.dataGridViewCheckBoxColumn1.Width = 50;
            // 
            // col_cod_agenda
            // 
            this.col_cod_agenda.DataPropertyName = "COD_AGENDA_OS";
            this.col_cod_agenda.HeaderText = "Cód.";
            this.col_cod_agenda.Name = "col_cod_agenda";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label20.Location = new System.Drawing.Point(12, 9);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(190, 46);
            this.label20.TabIndex = 240;
            this.label20.Text = "AGENDA";
            // 
            // tb_criterio
            // 
            this.tb_criterio.Location = new System.Drawing.Point(140, 51);
            this.tb_criterio.Name = "tb_criterio";
            this.tb_criterio.Size = new System.Drawing.Size(146, 20);
            this.tb_criterio.TabIndex = 241;
            this.tb_criterio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_criterio_KeyPress);
            // 
            // gbPesquisa
            // 
            this.gbPesquisa.Controls.Add(this.label3);
            this.gbPesquisa.Controls.Add(this.label2);
            this.gbPesquisa.Controls.Add(this.cb_campo);
            this.gbPesquisa.Controls.Add(this.label1);
            this.gbPesquisa.Controls.Add(this.tb_criterio);
            this.gbPesquisa.Location = new System.Drawing.Point(300, 5);
            this.gbPesquisa.Name = "gbPesquisa";
            this.gbPesquisa.Size = new System.Drawing.Size(338, 101);
            this.gbPesquisa.TabIndex = 242;
            this.gbPesquisa.TabStop = false;
            this.gbPesquisa.Text = "Pesquisa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 13);
            this.label1.TabIndex = 242;
            this.label1.Text = "Para pesquisar, clique no campo, digite o critério e tecle ENTER";
            // 
            // cb_campo
            // 
            this.cb_campo.FormattingEnabled = true;
            this.cb_campo.Items.AddRange(new object[] {
            "OS",
            "CLIENTE",
            "DESCRICAO",
            "TIPO_OCORRENCIA",
            "DATA"});
            this.cb_campo.Location = new System.Drawing.Point(13, 51);
            this.cb_campo.Name = "cb_campo";
            this.cb_campo.Size = new System.Drawing.Size(121, 21);
            this.cb_campo.TabIndex = 243;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 244;
            this.label2.Text = "Critério";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 245;
            this.label3.Text = "Campo";
            // 
            // bt_imprimir
            // 
            this.bt_imprimir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_imprimir.BackgroundImage")));
            this.bt_imprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_imprimir.Location = new System.Drawing.Point(660, 50);
            this.bt_imprimir.Name = "bt_imprimir";
            this.bt_imprimir.Size = new System.Drawing.Size(58, 56);
            this.bt_imprimir.TabIndex = 246;
            this.bt_imprimir.UseVisualStyleBackColor = true;
            this.bt_imprimir.Click += new System.EventHandler(this.bt_imprimir_Click);
            // 
            // form_agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 482);
            this.Controls.Add(this.bt_imprimir);
            this.Controls.Add(this.gbPesquisa);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.bt_excluir);
            this.Controls.Add(this.dgvAgenda);
            this.Name = "form_agenda";
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.form_agenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsAgenda_os)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AGENDA_OS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).EndInit();
            this.gbPesquisa.ResumeLayout(false);
            this.gbPesquisa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datAgenda_os;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Data.DataSet dsAgenda_os;
        private System.Data.DataTable AGENDA_OS;
        private System.Data.DataColumn COD_AGENDA_OS;
        private System.Data.DataColumn OS_AGENDA_OS;
        private System.Data.DataColumn CLIENTE_AGENDA_OS;
        private System.Data.DataColumn DESCRICAO_AGENDA_OS;
        private System.Data.DataColumn DATA_AGENDA_OS;
        private System.Data.DataColumn TIPO_OCORRENCIA_AGENDA_OS;
        private System.Data.DataColumn FINALIZADO_AGENDA_OS;
        private System.Data.DataColumn HORA_AGENDA_OS;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbAgenda_os;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button bt_excluir;
        private System.Windows.Forms.DataGridView dgvAgenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn oSAGENDAOSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTEAGENDAOSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRICAOAGENDAOSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIPOOCORRENCIAAGENDAOSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAAGENDAOSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod_agenda;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tb_criterio;
        private System.Windows.Forms.GroupBox gbPesquisa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_campo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_imprimir;
    }
}