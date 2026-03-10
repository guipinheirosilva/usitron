namespace Evolucao
{
    partial class form_localiza_liberacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_localiza_liberacao));
            this.datLiberacao = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsLiberacao = new System.Data.DataSet();
            this.LIBERACAO = new System.Data.DataTable();
            this.COD_LIB = new System.Data.DataColumn();
            this.DATA_LIB = new System.Data.DataColumn();
            this.HORA_LIB = new System.Data.DataColumn();
            this.RESPONSAVEL_LIB = new System.Data.DataColumn();
            this.VALOR_LIB = new System.Data.DataColumn();
            this.QTDE_ITENS_LIB = new System.Data.DataColumn();
            this.DISPONIVEL_LIB = new System.Data.DataColumn();
            this.BAIXADO_LIB = new System.Data.DataColumn();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dgvLiberacao = new System.Windows.Forms.DataGridView();
            this.cODLIBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATALIBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORALIBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rESPONSAVELLIBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORLIBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dISPONIVELLIBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_baixado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.col_ped = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dsLiberacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LIBERACAO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLiberacao)).BeginInit();
            this.SuspendLayout();
            // 
            // datLiberacao
            // 
            this.datLiberacao.DeleteCommand = this.fbCommand4;
            this.datLiberacao.InsertCommand = this.fbCommand2;
            this.datLiberacao.SelectCommand = this.fbCommand1;
            this.datLiberacao.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * from liberacao order by cod_lib desc";
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
            // dsLiberacao
            // 
            this.dsLiberacao.DataSetName = "dsLiberacao";
            this.dsLiberacao.Namespace = "http://www.tempuri.org/dsLiberacao.xsd";
            this.dsLiberacao.Tables.AddRange(new System.Data.DataTable[] {
            this.LIBERACAO});
            // 
            // LIBERACAO
            // 
            this.LIBERACAO.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_LIB,
            this.DATA_LIB,
            this.HORA_LIB,
            this.RESPONSAVEL_LIB,
            this.VALOR_LIB,
            this.QTDE_ITENS_LIB,
            this.DISPONIVEL_LIB,
            this.BAIXADO_LIB,
            this.dataColumn1,
            this.dataColumn2});
            this.LIBERACAO.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_LIB"}, true)});
            this.LIBERACAO.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_LIB};
            this.LIBERACAO.TableName = "LIBERACAO";
            // 
            // COD_LIB
            // 
            this.COD_LIB.AllowDBNull = false;
            this.COD_LIB.ColumnName = "COD_LIB";
            this.COD_LIB.DataType = typeof(int);
            // 
            // DATA_LIB
            // 
            this.DATA_LIB.ColumnName = "DATA_LIB";
            this.DATA_LIB.DataType = typeof(System.DateTime);
            // 
            // HORA_LIB
            // 
            this.HORA_LIB.ColumnName = "HORA_LIB";
            this.HORA_LIB.DataType = typeof(System.DateTime);
            // 
            // RESPONSAVEL_LIB
            // 
            this.RESPONSAVEL_LIB.ColumnName = "RESPONSAVEL_LIB";
            this.RESPONSAVEL_LIB.DataType = typeof(int);
            // 
            // VALOR_LIB
            // 
            this.VALOR_LIB.ColumnName = "VALOR_LIB";
            this.VALOR_LIB.DataType = typeof(double);
            // 
            // QTDE_ITENS_LIB
            // 
            this.QTDE_ITENS_LIB.ColumnName = "QTDE_ITENS_LIB";
            this.QTDE_ITENS_LIB.DataType = typeof(int);
            // 
            // DISPONIVEL_LIB
            // 
            this.DISPONIVEL_LIB.ColumnName = "DISPONIVEL_LIB";
            this.DISPONIVEL_LIB.DataType = typeof(int);
            // 
            // BAIXADO_LIB
            // 
            this.BAIXADO_LIB.ColumnName = "BAIXADO_LIB";
            this.BAIXADO_LIB.DataType = typeof(int);
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "PEDIDO_BAIXA_LIB";
            this.dataColumn1.DataType = typeof(int);
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "Column1";
            // 
            // dgvLiberacao
            // 
            this.dgvLiberacao.AutoGenerateColumns = false;
            this.dgvLiberacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLiberacao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODLIBDataGridViewTextBoxColumn,
            this.dATALIBDataGridViewTextBoxColumn,
            this.hORALIBDataGridViewTextBoxColumn,
            this.rESPONSAVELLIBDataGridViewTextBoxColumn,
            this.vALORLIBDataGridViewTextBoxColumn,
            this.dISPONIVELLIBDataGridViewTextBoxColumn,
            this.col_baixado,
            this.col_ped});
            this.dgvLiberacao.DataMember = "LIBERACAO";
            this.dgvLiberacao.DataSource = this.dsLiberacao;
            this.dgvLiberacao.Location = new System.Drawing.Point(12, 57);
            this.dgvLiberacao.Name = "dgvLiberacao";
            this.dgvLiberacao.Size = new System.Drawing.Size(598, 512);
            this.dgvLiberacao.TabIndex = 0;
            this.dgvLiberacao.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLiberacao_CellDoubleClick);
            // 
            // cODLIBDataGridViewTextBoxColumn
            // 
            this.cODLIBDataGridViewTextBoxColumn.DataPropertyName = "COD_LIB";
            this.cODLIBDataGridViewTextBoxColumn.HeaderText = "Cód.";
            this.cODLIBDataGridViewTextBoxColumn.Name = "cODLIBDataGridViewTextBoxColumn";
            // 
            // dATALIBDataGridViewTextBoxColumn
            // 
            this.dATALIBDataGridViewTextBoxColumn.DataPropertyName = "DATA_LIB";
            this.dATALIBDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dATALIBDataGridViewTextBoxColumn.Name = "dATALIBDataGridViewTextBoxColumn";
            // 
            // hORALIBDataGridViewTextBoxColumn
            // 
            this.hORALIBDataGridViewTextBoxColumn.DataPropertyName = "HORA_LIB";
            this.hORALIBDataGridViewTextBoxColumn.HeaderText = "HORA_LIB";
            this.hORALIBDataGridViewTextBoxColumn.Name = "hORALIBDataGridViewTextBoxColumn";
            this.hORALIBDataGridViewTextBoxColumn.Visible = false;
            // 
            // rESPONSAVELLIBDataGridViewTextBoxColumn
            // 
            this.rESPONSAVELLIBDataGridViewTextBoxColumn.DataPropertyName = "RESPONSAVEL_LIB";
            this.rESPONSAVELLIBDataGridViewTextBoxColumn.HeaderText = "Responsável";
            this.rESPONSAVELLIBDataGridViewTextBoxColumn.Name = "rESPONSAVELLIBDataGridViewTextBoxColumn";
            // 
            // vALORLIBDataGridViewTextBoxColumn
            // 
            this.vALORLIBDataGridViewTextBoxColumn.DataPropertyName = "VALOR_LIB";
            this.vALORLIBDataGridViewTextBoxColumn.HeaderText = "VALOR_LIB";
            this.vALORLIBDataGridViewTextBoxColumn.Name = "vALORLIBDataGridViewTextBoxColumn";
            this.vALORLIBDataGridViewTextBoxColumn.Visible = false;
            // 
            // dISPONIVELLIBDataGridViewTextBoxColumn
            // 
            this.dISPONIVELLIBDataGridViewTextBoxColumn.DataPropertyName = "DISPONIVEL_LIB";
            this.dISPONIVELLIBDataGridViewTextBoxColumn.HeaderText = "DISPONIVEL_LIB";
            this.dISPONIVELLIBDataGridViewTextBoxColumn.Name = "dISPONIVELLIBDataGridViewTextBoxColumn";
            this.dISPONIVELLIBDataGridViewTextBoxColumn.Visible = false;
            // 
            // col_baixado
            // 
            this.col_baixado.DataPropertyName = "BAIXADO_LIB";
            this.col_baixado.FalseValue = "0";
            this.col_baixado.HeaderText = "Baixado";
            this.col_baixado.IndeterminateValue = "0";
            this.col_baixado.Name = "col_baixado";
            this.col_baixado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_baixado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_baixado.TrueValue = "1";
            this.col_baixado.Width = 60;
            // 
            // col_ped
            // 
            this.col_ped.DataPropertyName = "PEDIDO_BAIXA_LIB";
            this.col_ped.HeaderText = "Pedido Baixa";
            this.col_ped.Name = "col_ped";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(211, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Mostrar Todos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // form_localiza_liberacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 591);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvLiberacao);
            this.Name = "form_localiza_liberacao";
            this.Text = "Localiza Liberação";
            this.Load += new System.EventHandler(this.form_localiza_liberacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsLiberacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LIBERACAO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLiberacao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datLiberacao;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Data.DataSet dsLiberacao;
        private System.Data.DataTable LIBERACAO;
        private System.Data.DataColumn COD_LIB;
        private System.Data.DataColumn DATA_LIB;
        private System.Data.DataColumn HORA_LIB;
        private System.Data.DataColumn RESPONSAVEL_LIB;
        private System.Data.DataColumn VALOR_LIB;
        private System.Data.DataColumn QTDE_ITENS_LIB;
        private System.Data.DataColumn DISPONIVEL_LIB;
        private System.Data.DataColumn BAIXADO_LIB;
        private System.Windows.Forms.DataGridView dgvLiberacao;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODLIBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATALIBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORALIBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rESPONSAVELLIBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORLIBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dISPONIVELLIBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_baixado;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ped;
        private System.Windows.Forms.Button button1;
    }
}