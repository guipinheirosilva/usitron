namespace Evolucao
{
    partial class form_localiza_transportadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_localiza_transportadora));
            this.dgvTransportadora = new System.Windows.Forms.DataGridView();
            this.dsTransportadora = new System.Data.DataSet();
            this.TRANSPORTADORAS = new System.Data.DataTable();
            this.COD_TRANSPORTADORA = new System.Data.DataColumn();
            this.SITUACAO_TRANSPORTADORA = new System.Data.DataColumn();
            this.NOME_TRANSPORTADORA = new System.Data.DataColumn();
            this.RAZAO_SOCIAL_TRANSPORTADORA = new System.Data.DataColumn();
            this.ENDERECO_TRANSPORTADORA = new System.Data.DataColumn();
            this.BAIRRO_TRANSPORTADORA = new System.Data.DataColumn();
            this.CIDADE_TRANSPORTADORA = new System.Data.DataColumn();
            this.ESTADO_TRANSPORTADORA = new System.Data.DataColumn();
            this.PAIS_TRANSPORTADORA = new System.Data.DataColumn();
            this.CNPJ_TRANSPORTADORA = new System.Data.DataColumn();
            this.IE_TRANSPORTADORA = new System.Data.DataColumn();
            this.DATA_INSCRICAO_TRANSPORTADORA = new System.Data.DataColumn();
            this.TEL_1_TRANSPORTADORA = new System.Data.DataColumn();
            this.TEL_2_TRANSPORTADORA = new System.Data.DataColumn();
            this.tb_localiza = new System.Windows.Forms.TextBox();
            this.datTransportadora = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.col_cod_transp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sITUACAOTRANSPORTADORADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMETRANSPORTADORADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_razao_social_transp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNDERECOTRANSPORTADORADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bAIRROTRANSPORTADORADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIDADETRANSPORTADORADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSTADOTRANSPORTADORADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAISTRANSPORTADORADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNPJTRANSPORTADORADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iETRANSPORTADORADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAINSCRICAOTRANSPORTADORADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tEL1TRANSPORTADORADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tEL2TRANSPORTADORADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransportadora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransportadora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRANSPORTADORAS)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTransportadora
            // 
            this.dgvTransportadora.AllowUserToAddRows = false;
            this.dgvTransportadora.AutoGenerateColumns = false;
            this.dgvTransportadora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransportadora.ColumnHeadersVisible = false;
            this.dgvTransportadora.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_cod_transp,
            this.sITUACAOTRANSPORTADORADataGridViewTextBoxColumn,
            this.nOMETRANSPORTADORADataGridViewTextBoxColumn,
            this.col_razao_social_transp,
            this.eNDERECOTRANSPORTADORADataGridViewTextBoxColumn,
            this.bAIRROTRANSPORTADORADataGridViewTextBoxColumn,
            this.cIDADETRANSPORTADORADataGridViewTextBoxColumn,
            this.eSTADOTRANSPORTADORADataGridViewTextBoxColumn,
            this.pAISTRANSPORTADORADataGridViewTextBoxColumn,
            this.cNPJTRANSPORTADORADataGridViewTextBoxColumn,
            this.iETRANSPORTADORADataGridViewTextBoxColumn,
            this.dATAINSCRICAOTRANSPORTADORADataGridViewTextBoxColumn,
            this.tEL1TRANSPORTADORADataGridViewTextBoxColumn,
            this.tEL2TRANSPORTADORADataGridViewTextBoxColumn});
            this.dgvTransportadora.DataMember = "TRANSPORTADORAS";
            this.dgvTransportadora.DataSource = this.dsTransportadora;
            this.dgvTransportadora.Location = new System.Drawing.Point(2, 75);
            this.dgvTransportadora.Name = "dgvTransportadora";
            this.dgvTransportadora.RowHeadersVisible = false;
            this.dgvTransportadora.Size = new System.Drawing.Size(486, 160);
            this.dgvTransportadora.TabIndex = 0;
            this.dgvTransportadora.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransportadora_CellContentClick);
            this.dgvTransportadora.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransportadora_CellContentDoubleClick);
            // 
            // dsTransportadora
            // 
            this.dsTransportadora.DataSetName = "dsTransportadora";
            this.dsTransportadora.Namespace = "http://www.tempuri.org/dsTransportadora.xsd";
            this.dsTransportadora.Tables.AddRange(new System.Data.DataTable[] {
            this.TRANSPORTADORAS});
            // 
            // TRANSPORTADORAS
            // 
            this.TRANSPORTADORAS.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_TRANSPORTADORA,
            this.SITUACAO_TRANSPORTADORA,
            this.NOME_TRANSPORTADORA,
            this.RAZAO_SOCIAL_TRANSPORTADORA,
            this.ENDERECO_TRANSPORTADORA,
            this.BAIRRO_TRANSPORTADORA,
            this.CIDADE_TRANSPORTADORA,
            this.ESTADO_TRANSPORTADORA,
            this.PAIS_TRANSPORTADORA,
            this.CNPJ_TRANSPORTADORA,
            this.IE_TRANSPORTADORA,
            this.DATA_INSCRICAO_TRANSPORTADORA,
            this.TEL_1_TRANSPORTADORA,
            this.TEL_2_TRANSPORTADORA});
            this.TRANSPORTADORAS.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_TRANSPORTADORA"}, true)});
            this.TRANSPORTADORAS.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_TRANSPORTADORA};
            this.TRANSPORTADORAS.TableName = "TRANSPORTADORAS";
            // 
            // COD_TRANSPORTADORA
            // 
            this.COD_TRANSPORTADORA.AllowDBNull = false;
            this.COD_TRANSPORTADORA.ColumnName = "COD_TRANSPORTADORA";
            this.COD_TRANSPORTADORA.DataType = typeof(int);
            // 
            // SITUACAO_TRANSPORTADORA
            // 
            this.SITUACAO_TRANSPORTADORA.ColumnName = "SITUACAO_TRANSPORTADORA";
            this.SITUACAO_TRANSPORTADORA.MaxLength = 10;
            // 
            // NOME_TRANSPORTADORA
            // 
            this.NOME_TRANSPORTADORA.ColumnName = "NOME_TRANSPORTADORA";
            this.NOME_TRANSPORTADORA.MaxLength = 60;
            // 
            // RAZAO_SOCIAL_TRANSPORTADORA
            // 
            this.RAZAO_SOCIAL_TRANSPORTADORA.ColumnName = "RAZAO_SOCIAL_TRANSPORTADORA";
            this.RAZAO_SOCIAL_TRANSPORTADORA.MaxLength = 60;
            // 
            // ENDERECO_TRANSPORTADORA
            // 
            this.ENDERECO_TRANSPORTADORA.ColumnName = "ENDERECO_TRANSPORTADORA";
            this.ENDERECO_TRANSPORTADORA.MaxLength = 60;
            // 
            // BAIRRO_TRANSPORTADORA
            // 
            this.BAIRRO_TRANSPORTADORA.ColumnName = "BAIRRO_TRANSPORTADORA";
            this.BAIRRO_TRANSPORTADORA.MaxLength = 40;
            // 
            // CIDADE_TRANSPORTADORA
            // 
            this.CIDADE_TRANSPORTADORA.ColumnName = "CIDADE_TRANSPORTADORA";
            this.CIDADE_TRANSPORTADORA.MaxLength = 30;
            // 
            // ESTADO_TRANSPORTADORA
            // 
            this.ESTADO_TRANSPORTADORA.ColumnName = "ESTADO_TRANSPORTADORA";
            this.ESTADO_TRANSPORTADORA.MaxLength = 10;
            // 
            // PAIS_TRANSPORTADORA
            // 
            this.PAIS_TRANSPORTADORA.ColumnName = "PAIS_TRANSPORTADORA";
            this.PAIS_TRANSPORTADORA.MaxLength = 40;
            // 
            // CNPJ_TRANSPORTADORA
            // 
            this.CNPJ_TRANSPORTADORA.ColumnName = "CNPJ_TRANSPORTADORA";
            this.CNPJ_TRANSPORTADORA.MaxLength = 25;
            // 
            // IE_TRANSPORTADORA
            // 
            this.IE_TRANSPORTADORA.ColumnName = "IE_TRANSPORTADORA";
            this.IE_TRANSPORTADORA.MaxLength = 25;
            // 
            // DATA_INSCRICAO_TRANSPORTADORA
            // 
            this.DATA_INSCRICAO_TRANSPORTADORA.ColumnName = "DATA_INSCRICAO_TRANSPORTADORA";
            this.DATA_INSCRICAO_TRANSPORTADORA.DataType = typeof(System.DateTime);
            // 
            // TEL_1_TRANSPORTADORA
            // 
            this.TEL_1_TRANSPORTADORA.ColumnName = "TEL_1_TRANSPORTADORA";
            this.TEL_1_TRANSPORTADORA.MaxLength = 20;
            // 
            // TEL_2_TRANSPORTADORA
            // 
            this.TEL_2_TRANSPORTADORA.ColumnName = "TEL_2_TRANSPORTADORA";
            this.TEL_2_TRANSPORTADORA.MaxLength = 20;
            // 
            // tb_localiza
            // 
            this.tb_localiza.Location = new System.Drawing.Point(131, 34);
            this.tb_localiza.Name = "tb_localiza";
            this.tb_localiza.Size = new System.Drawing.Size(244, 20);
            this.tb_localiza.TabIndex = 2;
            this.tb_localiza.TextChanged += new System.EventHandler(this.tb_localiza_TextChanged);
            // 
            // datTransportadora
            // 
            this.datTransportadora.DeleteCommand = this.fbCommand4;
            this.datTransportadora.InsertCommand = this.fbCommand2;
            this.datTransportadora.SelectCommand = this.fbCommand1;
            this.datTransportadora.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * from transportadoras order by nome_transportadora";
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
            // col_cod_transp
            // 
            this.col_cod_transp.DataPropertyName = "COD_TRANSPORTADORA";
            this.col_cod_transp.HeaderText = "COD_TRANSPORTADORA";
            this.col_cod_transp.Name = "col_cod_transp";
            this.col_cod_transp.Width = 50;
            // 
            // sITUACAOTRANSPORTADORADataGridViewTextBoxColumn
            // 
            this.sITUACAOTRANSPORTADORADataGridViewTextBoxColumn.DataPropertyName = "SITUACAO_TRANSPORTADORA";
            this.sITUACAOTRANSPORTADORADataGridViewTextBoxColumn.HeaderText = "SITUACAO_TRANSPORTADORA";
            this.sITUACAOTRANSPORTADORADataGridViewTextBoxColumn.Name = "sITUACAOTRANSPORTADORADataGridViewTextBoxColumn";
            this.sITUACAOTRANSPORTADORADataGridViewTextBoxColumn.Visible = false;
            // 
            // nOMETRANSPORTADORADataGridViewTextBoxColumn
            // 
            this.nOMETRANSPORTADORADataGridViewTextBoxColumn.DataPropertyName = "NOME_TRANSPORTADORA";
            this.nOMETRANSPORTADORADataGridViewTextBoxColumn.HeaderText = "NOME_TRANSPORTADORA";
            this.nOMETRANSPORTADORADataGridViewTextBoxColumn.Name = "nOMETRANSPORTADORADataGridViewTextBoxColumn";
            this.nOMETRANSPORTADORADataGridViewTextBoxColumn.Visible = false;
            this.nOMETRANSPORTADORADataGridViewTextBoxColumn.Width = 160;
            // 
            // col_razao_social_transp
            // 
            this.col_razao_social_transp.DataPropertyName = "RAZAO_SOCIAL_TRANSPORTADORA";
            this.col_razao_social_transp.HeaderText = "RAZAO_SOCIAL_TRANSPORTADORA";
            this.col_razao_social_transp.Name = "col_razao_social_transp";
            this.col_razao_social_transp.Width = 350;
            // 
            // eNDERECOTRANSPORTADORADataGridViewTextBoxColumn
            // 
            this.eNDERECOTRANSPORTADORADataGridViewTextBoxColumn.DataPropertyName = "ENDERECO_TRANSPORTADORA";
            this.eNDERECOTRANSPORTADORADataGridViewTextBoxColumn.HeaderText = "ENDERECO_TRANSPORTADORA";
            this.eNDERECOTRANSPORTADORADataGridViewTextBoxColumn.Name = "eNDERECOTRANSPORTADORADataGridViewTextBoxColumn";
            this.eNDERECOTRANSPORTADORADataGridViewTextBoxColumn.Visible = false;
            // 
            // bAIRROTRANSPORTADORADataGridViewTextBoxColumn
            // 
            this.bAIRROTRANSPORTADORADataGridViewTextBoxColumn.DataPropertyName = "BAIRRO_TRANSPORTADORA";
            this.bAIRROTRANSPORTADORADataGridViewTextBoxColumn.HeaderText = "BAIRRO_TRANSPORTADORA";
            this.bAIRROTRANSPORTADORADataGridViewTextBoxColumn.Name = "bAIRROTRANSPORTADORADataGridViewTextBoxColumn";
            this.bAIRROTRANSPORTADORADataGridViewTextBoxColumn.Visible = false;
            // 
            // cIDADETRANSPORTADORADataGridViewTextBoxColumn
            // 
            this.cIDADETRANSPORTADORADataGridViewTextBoxColumn.DataPropertyName = "CIDADE_TRANSPORTADORA";
            this.cIDADETRANSPORTADORADataGridViewTextBoxColumn.HeaderText = "CIDADE_TRANSPORTADORA";
            this.cIDADETRANSPORTADORADataGridViewTextBoxColumn.Name = "cIDADETRANSPORTADORADataGridViewTextBoxColumn";
            this.cIDADETRANSPORTADORADataGridViewTextBoxColumn.Visible = false;
            // 
            // eSTADOTRANSPORTADORADataGridViewTextBoxColumn
            // 
            this.eSTADOTRANSPORTADORADataGridViewTextBoxColumn.DataPropertyName = "ESTADO_TRANSPORTADORA";
            this.eSTADOTRANSPORTADORADataGridViewTextBoxColumn.HeaderText = "ESTADO_TRANSPORTADORA";
            this.eSTADOTRANSPORTADORADataGridViewTextBoxColumn.Name = "eSTADOTRANSPORTADORADataGridViewTextBoxColumn";
            this.eSTADOTRANSPORTADORADataGridViewTextBoxColumn.Visible = false;
            // 
            // pAISTRANSPORTADORADataGridViewTextBoxColumn
            // 
            this.pAISTRANSPORTADORADataGridViewTextBoxColumn.DataPropertyName = "PAIS_TRANSPORTADORA";
            this.pAISTRANSPORTADORADataGridViewTextBoxColumn.HeaderText = "PAIS_TRANSPORTADORA";
            this.pAISTRANSPORTADORADataGridViewTextBoxColumn.Name = "pAISTRANSPORTADORADataGridViewTextBoxColumn";
            this.pAISTRANSPORTADORADataGridViewTextBoxColumn.Visible = false;
            // 
            // cNPJTRANSPORTADORADataGridViewTextBoxColumn
            // 
            this.cNPJTRANSPORTADORADataGridViewTextBoxColumn.DataPropertyName = "CNPJ_TRANSPORTADORA";
            this.cNPJTRANSPORTADORADataGridViewTextBoxColumn.HeaderText = "CNPJ_TRANSPORTADORA";
            this.cNPJTRANSPORTADORADataGridViewTextBoxColumn.Name = "cNPJTRANSPORTADORADataGridViewTextBoxColumn";
            this.cNPJTRANSPORTADORADataGridViewTextBoxColumn.Visible = false;
            // 
            // iETRANSPORTADORADataGridViewTextBoxColumn
            // 
            this.iETRANSPORTADORADataGridViewTextBoxColumn.DataPropertyName = "IE_TRANSPORTADORA";
            this.iETRANSPORTADORADataGridViewTextBoxColumn.HeaderText = "IE_TRANSPORTADORA";
            this.iETRANSPORTADORADataGridViewTextBoxColumn.Name = "iETRANSPORTADORADataGridViewTextBoxColumn";
            this.iETRANSPORTADORADataGridViewTextBoxColumn.Visible = false;
            // 
            // dATAINSCRICAOTRANSPORTADORADataGridViewTextBoxColumn
            // 
            this.dATAINSCRICAOTRANSPORTADORADataGridViewTextBoxColumn.DataPropertyName = "DATA_INSCRICAO_TRANSPORTADORA";
            this.dATAINSCRICAOTRANSPORTADORADataGridViewTextBoxColumn.HeaderText = "DATA_INSCRICAO_TRANSPORTADORA";
            this.dATAINSCRICAOTRANSPORTADORADataGridViewTextBoxColumn.Name = "dATAINSCRICAOTRANSPORTADORADataGridViewTextBoxColumn";
            this.dATAINSCRICAOTRANSPORTADORADataGridViewTextBoxColumn.Visible = false;
            // 
            // tEL1TRANSPORTADORADataGridViewTextBoxColumn
            // 
            this.tEL1TRANSPORTADORADataGridViewTextBoxColumn.DataPropertyName = "TEL_1_TRANSPORTADORA";
            this.tEL1TRANSPORTADORADataGridViewTextBoxColumn.HeaderText = "TEL_1_TRANSPORTADORA";
            this.tEL1TRANSPORTADORADataGridViewTextBoxColumn.Name = "tEL1TRANSPORTADORADataGridViewTextBoxColumn";
            this.tEL1TRANSPORTADORADataGridViewTextBoxColumn.Visible = false;
            // 
            // tEL2TRANSPORTADORADataGridViewTextBoxColumn
            // 
            this.tEL2TRANSPORTADORADataGridViewTextBoxColumn.DataPropertyName = "TEL_2_TRANSPORTADORA";
            this.tEL2TRANSPORTADORADataGridViewTextBoxColumn.HeaderText = "TEL_2_TRANSPORTADORA";
            this.tEL2TRANSPORTADORADataGridViewTextBoxColumn.Name = "tEL2TRANSPORTADORADataGridViewTextBoxColumn";
            this.tEL2TRANSPORTADORADataGridViewTextBoxColumn.Visible = false;
            // 
            // form_localiza_transportadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 276);
            this.Controls.Add(this.tb_localiza);
            this.Controls.Add(this.dgvTransportadora);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "form_localiza_transportadora";
            this.Text = "Localiza Transportadora";
            this.Load += new System.EventHandler(this.form_localiza_transportadora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransportadora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransportadora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRANSPORTADORAS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTransportadora;
        private System.Windows.Forms.TextBox tb_localiza;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datTransportadora;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private System.Data.DataSet dsTransportadora;
        private System.Data.DataTable TRANSPORTADORAS;
        private System.Data.DataColumn COD_TRANSPORTADORA;
        private System.Data.DataColumn SITUACAO_TRANSPORTADORA;
        private System.Data.DataColumn NOME_TRANSPORTADORA;
        private System.Data.DataColumn RAZAO_SOCIAL_TRANSPORTADORA;
        private System.Data.DataColumn ENDERECO_TRANSPORTADORA;
        private System.Data.DataColumn BAIRRO_TRANSPORTADORA;
        private System.Data.DataColumn CIDADE_TRANSPORTADORA;
        private System.Data.DataColumn ESTADO_TRANSPORTADORA;
        private System.Data.DataColumn PAIS_TRANSPORTADORA;
        private System.Data.DataColumn CNPJ_TRANSPORTADORA;
        private System.Data.DataColumn IE_TRANSPORTADORA;
        private System.Data.DataColumn DATA_INSCRICAO_TRANSPORTADORA;
        private System.Data.DataColumn TEL_1_TRANSPORTADORA;
        private System.Data.DataColumn TEL_2_TRANSPORTADORA;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod_transp;
        private System.Windows.Forms.DataGridViewTextBoxColumn sITUACAOTRANSPORTADORADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMETRANSPORTADORADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_razao_social_transp;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNDERECOTRANSPORTADORADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bAIRROTRANSPORTADORADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDADETRANSPORTADORADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTADOTRANSPORTADORADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAISTRANSPORTADORADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPJTRANSPORTADORADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iETRANSPORTADORADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAINSCRICAOTRANSPORTADORADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tEL1TRANSPORTADORADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tEL2TRANSPORTADORADataGridViewTextBoxColumn;
    }
}