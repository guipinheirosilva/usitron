namespace Evolucao
{
    partial class form_localiza_peca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_localiza_peca));
            this.tb_localiza_peca = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.col_posicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_peca_atual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEVISAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mATERIALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSPESSURADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rOTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMEPECADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nSUBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nROTASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsDesenhos = new System.Data.DataSet();
            this.DESENHOS = new System.Data.DataTable();
            this.COD_PECA = new System.Data.DataColumn();
            this.REVISAO = new System.Data.DataColumn();
            this.MATERIAL = new System.Data.DataColumn();
            this.ESPESSURA = new System.Data.DataColumn();
            this.CLIENTE = new System.Data.DataColumn();
            this.ROTA = new System.Data.DataColumn();
            this.NOME_PECA = new System.Data.DataColumn();
            this.N_SUB = new System.Data.DataColumn();
            this.N_ROTAS = new System.Data.DataColumn();
            this.POSICAO_PECA = new System.Data.DataColumn();
            this.datDesenhos = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDesenhos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DESENHOS)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_localiza_peca
            // 
            this.tb_localiza_peca.Location = new System.Drawing.Point(1, 1);
            this.tb_localiza_peca.Name = "tb_localiza_peca";
            this.tb_localiza_peca.Size = new System.Drawing.Size(254, 20);
            this.tb_localiza_peca.TabIndex = 0;
            this.tb_localiza_peca.TextChanged += new System.EventHandler(this.tb_localiza_peca_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_posicao,
            this.cod_peca_atual,
            this.rEVISAODataGridViewTextBoxColumn,
            this.mATERIALDataGridViewTextBoxColumn,
            this.eSPESSURADataGridViewTextBoxColumn,
            this.cLIENTEDataGridViewTextBoxColumn,
            this.rOTADataGridViewTextBoxColumn,
            this.nOMEPECADataGridViewTextBoxColumn,
            this.nSUBDataGridViewTextBoxColumn,
            this.nROTASDataGridViewTextBoxColumn});
            this.dataGridView1.DataMember = "DESENHOS";
            this.dataGridView1.DataSource = this.dsDesenhos;
            this.dataGridView1.Location = new System.Drawing.Point(1, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(254, 150);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // col_posicao
            // 
            this.col_posicao.DataPropertyName = "POSICAO_PECA";
            this.col_posicao.HeaderText = "Posição";
            this.col_posicao.Name = "col_posicao";
            this.col_posicao.ReadOnly = true;
            this.col_posicao.Width = 50;
            // 
            // cod_peca_atual
            // 
            this.cod_peca_atual.DataPropertyName = "COD_PECA";
            this.cod_peca_atual.HeaderText = "Peça";
            this.cod_peca_atual.Name = "cod_peca_atual";
            this.cod_peca_atual.ReadOnly = true;
            this.cod_peca_atual.Width = 200;
            // 
            // rEVISAODataGridViewTextBoxColumn
            // 
            this.rEVISAODataGridViewTextBoxColumn.DataPropertyName = "REVISAO";
            this.rEVISAODataGridViewTextBoxColumn.HeaderText = "REVISAO";
            this.rEVISAODataGridViewTextBoxColumn.Name = "rEVISAODataGridViewTextBoxColumn";
            this.rEVISAODataGridViewTextBoxColumn.ReadOnly = true;
            this.rEVISAODataGridViewTextBoxColumn.Visible = false;
            // 
            // mATERIALDataGridViewTextBoxColumn
            // 
            this.mATERIALDataGridViewTextBoxColumn.DataPropertyName = "MATERIAL";
            this.mATERIALDataGridViewTextBoxColumn.HeaderText = "MATERIAL";
            this.mATERIALDataGridViewTextBoxColumn.Name = "mATERIALDataGridViewTextBoxColumn";
            this.mATERIALDataGridViewTextBoxColumn.ReadOnly = true;
            this.mATERIALDataGridViewTextBoxColumn.Visible = false;
            // 
            // eSPESSURADataGridViewTextBoxColumn
            // 
            this.eSPESSURADataGridViewTextBoxColumn.DataPropertyName = "ESPESSURA";
            this.eSPESSURADataGridViewTextBoxColumn.HeaderText = "ESPESSURA";
            this.eSPESSURADataGridViewTextBoxColumn.Name = "eSPESSURADataGridViewTextBoxColumn";
            this.eSPESSURADataGridViewTextBoxColumn.ReadOnly = true;
            this.eSPESSURADataGridViewTextBoxColumn.Visible = false;
            // 
            // cLIENTEDataGridViewTextBoxColumn
            // 
            this.cLIENTEDataGridViewTextBoxColumn.DataPropertyName = "CLIENTE";
            this.cLIENTEDataGridViewTextBoxColumn.HeaderText = "CLIENTE";
            this.cLIENTEDataGridViewTextBoxColumn.Name = "cLIENTEDataGridViewTextBoxColumn";
            this.cLIENTEDataGridViewTextBoxColumn.ReadOnly = true;
            this.cLIENTEDataGridViewTextBoxColumn.Visible = false;
            // 
            // rOTADataGridViewTextBoxColumn
            // 
            this.rOTADataGridViewTextBoxColumn.DataPropertyName = "ROTA";
            this.rOTADataGridViewTextBoxColumn.HeaderText = "ROTA";
            this.rOTADataGridViewTextBoxColumn.Name = "rOTADataGridViewTextBoxColumn";
            this.rOTADataGridViewTextBoxColumn.ReadOnly = true;
            this.rOTADataGridViewTextBoxColumn.Visible = false;
            // 
            // nOMEPECADataGridViewTextBoxColumn
            // 
            this.nOMEPECADataGridViewTextBoxColumn.DataPropertyName = "NOME_PECA";
            this.nOMEPECADataGridViewTextBoxColumn.HeaderText = "NOME_PECA";
            this.nOMEPECADataGridViewTextBoxColumn.Name = "nOMEPECADataGridViewTextBoxColumn";
            this.nOMEPECADataGridViewTextBoxColumn.ReadOnly = true;
            this.nOMEPECADataGridViewTextBoxColumn.Visible = false;
            // 
            // nSUBDataGridViewTextBoxColumn
            // 
            this.nSUBDataGridViewTextBoxColumn.DataPropertyName = "N_SUB";
            this.nSUBDataGridViewTextBoxColumn.HeaderText = "N_SUB";
            this.nSUBDataGridViewTextBoxColumn.Name = "nSUBDataGridViewTextBoxColumn";
            this.nSUBDataGridViewTextBoxColumn.ReadOnly = true;
            this.nSUBDataGridViewTextBoxColumn.Visible = false;
            // 
            // nROTASDataGridViewTextBoxColumn
            // 
            this.nROTASDataGridViewTextBoxColumn.DataPropertyName = "N_ROTAS";
            this.nROTASDataGridViewTextBoxColumn.HeaderText = "N_ROTAS";
            this.nROTASDataGridViewTextBoxColumn.Name = "nROTASDataGridViewTextBoxColumn";
            this.nROTASDataGridViewTextBoxColumn.ReadOnly = true;
            this.nROTASDataGridViewTextBoxColumn.Visible = false;
            // 
            // dsDesenhos
            // 
            this.dsDesenhos.DataSetName = "dsDesenhos";
            this.dsDesenhos.Namespace = "http://www.tempuri.org/dsDesenhos.xsd";
            this.dsDesenhos.Tables.AddRange(new System.Data.DataTable[] {
            this.DESENHOS});
            // 
            // DESENHOS
            // 
            this.DESENHOS.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_PECA,
            this.REVISAO,
            this.MATERIAL,
            this.ESPESSURA,
            this.CLIENTE,
            this.ROTA,
            this.NOME_PECA,
            this.N_SUB,
            this.N_ROTAS,
            this.POSICAO_PECA});
            this.DESENHOS.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_PECA"}, true)});
            this.DESENHOS.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_PECA};
            this.DESENHOS.TableName = "DESENHOS";
            // 
            // COD_PECA
            // 
            this.COD_PECA.AllowDBNull = false;
            this.COD_PECA.ColumnName = "COD_PECA";
            this.COD_PECA.MaxLength = 20;
            // 
            // REVISAO
            // 
            this.REVISAO.ColumnName = "REVISAO";
            this.REVISAO.MaxLength = 10;
            // 
            // MATERIAL
            // 
            this.MATERIAL.ColumnName = "MATERIAL";
            this.MATERIAL.MaxLength = 30;
            // 
            // ESPESSURA
            // 
            this.ESPESSURA.ColumnName = "ESPESSURA";
            this.ESPESSURA.MaxLength = 10;
            // 
            // CLIENTE
            // 
            this.CLIENTE.ColumnName = "CLIENTE";
            this.CLIENTE.MaxLength = 40;
            // 
            // ROTA
            // 
            this.ROTA.ColumnName = "ROTA";
            this.ROTA.DataType = typeof(int);
            // 
            // NOME_PECA
            // 
            this.NOME_PECA.ColumnName = "NOME_PECA";
            this.NOME_PECA.MaxLength = 30;
            // 
            // N_SUB
            // 
            this.N_SUB.ColumnName = "N_SUB";
            this.N_SUB.DataType = typeof(int);
            // 
            // N_ROTAS
            // 
            this.N_ROTAS.ColumnName = "N_ROTAS";
            this.N_ROTAS.DataType = typeof(int);
            // 
            // POSICAO_PECA
            // 
            this.POSICAO_PECA.ColumnName = "POSICAO_PECA";
            this.POSICAO_PECA.MaxLength = 15;
            // 
            // datDesenhos
            // 
            this.datDesenhos.DeleteCommand = this.fbCommand4;
            this.datDesenhos.InsertCommand = this.fbCommand2;
            this.datDesenhos.SelectCommand = this.fbCommand1;
            this.datDesenhos.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * from desenhos";
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
            // form_localiza_peca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 173);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tb_localiza_peca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_localiza_peca";
            this.Text = "Localizar Peça";
            this.Load += new System.EventHandler(this.form_localiza_peca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDesenhos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DESENHOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_localiza_peca;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Data.DataSet dsDesenhos;
        private System.Data.DataTable DESENHOS;
        private System.Data.DataColumn COD_PECA;
        private System.Data.DataColumn REVISAO;
        private System.Data.DataColumn MATERIAL;
        private System.Data.DataColumn ESPESSURA;
        private System.Data.DataColumn CLIENTE;
        private System.Data.DataColumn ROTA;
        private System.Data.DataColumn NOME_PECA;
        private System.Data.DataColumn N_SUB;
        private System.Data.DataColumn N_ROTAS;
        private System.Data.DataColumn POSICAO_PECA;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datDesenhos;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_posicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_peca_atual;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEVISAODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mATERIALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSPESSURADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rOTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMEPECADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nSUBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nROTASDataGridViewTextBoxColumn;
    }
}