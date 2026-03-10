
namespace Evolucao
{
    partial class form_nfs_referenciadas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_nfs_referenciadas));
            this.datNfs_referenciadas = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dgvNfs_referenciadas = new System.Windows.Forms.DataGridView();
            this.dsNfs_referenciadas = new System.Data.DataSet();
            this.NFS_REFERENCIADAS = new System.Data.DataTable();
            this.COD_NFR = new System.Data.DataColumn();
            this.COD_SISTEMA_NFENT_NFR = new System.Data.DataColumn();
            this.N_NF_NF_ENT_NFR = new System.Data.DataColumn();
            this.CHAVE_NFENT_NFR = new System.Data.DataColumn();
            this.COD_ITENS_NOTA_SAIDA_NFR = new System.Data.DataColumn();
            this.COD_SISTEMA_NF_SAIDA_NFR = new System.Data.DataColumn();
            this.dataColumn1 = new System.Data.DataColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_chave = new System.Windows.Forms.TextBox();
            this.cODNFRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODSISTEMANFENTNFRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nNFNFENTNFRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHAVENFENTNFRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODITENSNOTASAIDANFRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODSISTEMANFSAIDANFRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNfs_referenciadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNfs_referenciadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NFS_REFERENCIADAS)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // datNfs_referenciadas
            // 
            this.datNfs_referenciadas.DeleteCommand = this.fbCommand4;
            this.datNfs_referenciadas.InsertCommand = this.fbCommand2;
            this.datNfs_referenciadas.SelectCommand = this.fbCommand1;
            this.datNfs_referenciadas.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * from nfs_referenciadas";
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
            // dgvNfs_referenciadas
            // 
            this.dgvNfs_referenciadas.AutoGenerateColumns = false;
            this.dgvNfs_referenciadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNfs_referenciadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODNFRDataGridViewTextBoxColumn,
            this.cODSISTEMANFENTNFRDataGridViewTextBoxColumn,
            this.nNFNFENTNFRDataGridViewTextBoxColumn,
            this.cHAVENFENTNFRDataGridViewTextBoxColumn,
            this.cODITENSNOTASAIDANFRDataGridViewTextBoxColumn,
            this.cODSISTEMANFSAIDANFRDataGridViewTextBoxColumn});
            this.dgvNfs_referenciadas.DataMember = "NFS_REFERENCIADAS";
            this.dgvNfs_referenciadas.DataSource = this.dsNfs_referenciadas;
            this.dgvNfs_referenciadas.Location = new System.Drawing.Point(12, 113);
            this.dgvNfs_referenciadas.Name = "dgvNfs_referenciadas";
            this.dgvNfs_referenciadas.RowHeadersWidth = 51;
            this.dgvNfs_referenciadas.RowTemplate.Height = 24;
            this.dgvNfs_referenciadas.Size = new System.Drawing.Size(776, 418);
            this.dgvNfs_referenciadas.TabIndex = 0;
            // 
            // dsNfs_referenciadas
            // 
            this.dsNfs_referenciadas.DataSetName = "dsNfs_referenciadas";
            this.dsNfs_referenciadas.Namespace = "http://www.tempuri.org/dsNfs_referenciadas.xsd";
            this.dsNfs_referenciadas.Tables.AddRange(new System.Data.DataTable[] {
            this.NFS_REFERENCIADAS});
            // 
            // NFS_REFERENCIADAS
            // 
            this.NFS_REFERENCIADAS.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_NFR,
            this.COD_SISTEMA_NFENT_NFR,
            this.N_NF_NF_ENT_NFR,
            this.CHAVE_NFENT_NFR,
            this.COD_ITENS_NOTA_SAIDA_NFR,
            this.COD_SISTEMA_NF_SAIDA_NFR,
            this.dataColumn1});
            this.NFS_REFERENCIADAS.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_NFR"}, true)});
            this.NFS_REFERENCIADAS.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_NFR};
            this.NFS_REFERENCIADAS.TableName = "NFS_REFERENCIADAS";
            // 
            // COD_NFR
            // 
            this.COD_NFR.AllowDBNull = false;
            this.COD_NFR.ColumnName = "COD_NFR";
            this.COD_NFR.DataType = typeof(int);
            // 
            // COD_SISTEMA_NFENT_NFR
            // 
            this.COD_SISTEMA_NFENT_NFR.ColumnName = "COD_SISTEMA_NFENT_NFR";
            this.COD_SISTEMA_NFENT_NFR.DataType = typeof(int);
            // 
            // N_NF_NF_ENT_NFR
            // 
            this.N_NF_NF_ENT_NFR.ColumnName = "N_NF_NF_ENT_NFR";
            this.N_NF_NF_ENT_NFR.DataType = typeof(int);
            // 
            // CHAVE_NFENT_NFR
            // 
            this.CHAVE_NFENT_NFR.ColumnName = "CHAVE_NFENT_NFR";
            this.CHAVE_NFENT_NFR.MaxLength = 44;
            // 
            // COD_ITENS_NOTA_SAIDA_NFR
            // 
            this.COD_ITENS_NOTA_SAIDA_NFR.ColumnName = "COD_ITENS_NOTA_SAIDA_NFR";
            this.COD_ITENS_NOTA_SAIDA_NFR.DataType = typeof(int);
            // 
            // COD_SISTEMA_NF_SAIDA_NFR
            // 
            this.COD_SISTEMA_NF_SAIDA_NFR.ColumnName = "COD_SISTEMA_NF_SAIDA_NFR";
            this.COD_SISTEMA_NF_SAIDA_NFR.DataType = typeof(int);
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "COD_ITENS_NOTA_ENT_NFR";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 62);
            this.button1.TabIndex = 1;
            this.button1.Text = "Adicionar Manualmente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tb_chave);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(11, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 92);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chave de Acesso:";
            // 
            // tb_chave
            // 
            this.tb_chave.Location = new System.Drawing.Point(286, 33);
            this.tb_chave.Name = "tb_chave";
            this.tb_chave.Size = new System.Drawing.Size(446, 22);
            this.tb_chave.TabIndex = 2;
            // 
            // cODNFRDataGridViewTextBoxColumn
            // 
            this.cODNFRDataGridViewTextBoxColumn.DataPropertyName = "COD_NFR";
            this.cODNFRDataGridViewTextBoxColumn.HeaderText = "COD_NFR";
            this.cODNFRDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cODNFRDataGridViewTextBoxColumn.Name = "cODNFRDataGridViewTextBoxColumn";
            this.cODNFRDataGridViewTextBoxColumn.Visible = false;
            this.cODNFRDataGridViewTextBoxColumn.Width = 125;
            // 
            // cODSISTEMANFENTNFRDataGridViewTextBoxColumn
            // 
            this.cODSISTEMANFENTNFRDataGridViewTextBoxColumn.DataPropertyName = "COD_SISTEMA_NFENT_NFR";
            this.cODSISTEMANFENTNFRDataGridViewTextBoxColumn.HeaderText = "COD_SISTEMA_NFENT_NFR";
            this.cODSISTEMANFENTNFRDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cODSISTEMANFENTNFRDataGridViewTextBoxColumn.Name = "cODSISTEMANFENTNFRDataGridViewTextBoxColumn";
            this.cODSISTEMANFENTNFRDataGridViewTextBoxColumn.Visible = false;
            this.cODSISTEMANFENTNFRDataGridViewTextBoxColumn.Width = 125;
            // 
            // nNFNFENTNFRDataGridViewTextBoxColumn
            // 
            this.nNFNFENTNFRDataGridViewTextBoxColumn.DataPropertyName = "N_NF_NF_ENT_NFR";
            this.nNFNFENTNFRDataGridViewTextBoxColumn.HeaderText = "NF";
            this.nNFNFENTNFRDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nNFNFENTNFRDataGridViewTextBoxColumn.Name = "nNFNFENTNFRDataGridViewTextBoxColumn";
            this.nNFNFENTNFRDataGridViewTextBoxColumn.Width = 80;
            // 
            // cHAVENFENTNFRDataGridViewTextBoxColumn
            // 
            this.cHAVENFENTNFRDataGridViewTextBoxColumn.DataPropertyName = "CHAVE_NFENT_NFR";
            this.cHAVENFENTNFRDataGridViewTextBoxColumn.HeaderText = "Chave de Acesso";
            this.cHAVENFENTNFRDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cHAVENFENTNFRDataGridViewTextBoxColumn.Name = "cHAVENFENTNFRDataGridViewTextBoxColumn";
            this.cHAVENFENTNFRDataGridViewTextBoxColumn.Width = 500;
            // 
            // cODITENSNOTASAIDANFRDataGridViewTextBoxColumn
            // 
            this.cODITENSNOTASAIDANFRDataGridViewTextBoxColumn.DataPropertyName = "COD_ITENS_NOTA_SAIDA_NFR";
            this.cODITENSNOTASAIDANFRDataGridViewTextBoxColumn.HeaderText = "Cód. Itens Nota";
            this.cODITENSNOTASAIDANFRDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cODITENSNOTASAIDANFRDataGridViewTextBoxColumn.Name = "cODITENSNOTASAIDANFRDataGridViewTextBoxColumn";
            this.cODITENSNOTASAIDANFRDataGridViewTextBoxColumn.Width = 125;
            // 
            // cODSISTEMANFSAIDANFRDataGridViewTextBoxColumn
            // 
            this.cODSISTEMANFSAIDANFRDataGridViewTextBoxColumn.DataPropertyName = "COD_SISTEMA_NF_SAIDA_NFR";
            this.cODSISTEMANFSAIDANFRDataGridViewTextBoxColumn.HeaderText = "COD_SISTEMA_NF_SAIDA_NFR";
            this.cODSISTEMANFSAIDANFRDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cODSISTEMANFSAIDANFRDataGridViewTextBoxColumn.Name = "cODSISTEMANFSAIDANFRDataGridViewTextBoxColumn";
            this.cODSISTEMANFSAIDANFRDataGridViewTextBoxColumn.Visible = false;
            this.cODSISTEMANFSAIDANFRDataGridViewTextBoxColumn.Width = 125;
            // 
            // form_nfs_referenciadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 543);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvNfs_referenciadas);
            this.Name = "form_nfs_referenciadas";
            this.Text = "NFs Referenciadas";
            this.Load += new System.EventHandler(this.form_nfs_referenciadas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNfs_referenciadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNfs_referenciadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NFS_REFERENCIADAS)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datNfs_referenciadas;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Windows.Forms.DataGridView dgvNfs_referenciadas;
        private System.Data.DataSet dsNfs_referenciadas;
        private System.Data.DataTable NFS_REFERENCIADAS;
        private System.Data.DataColumn COD_NFR;
        private System.Data.DataColumn COD_SISTEMA_NFENT_NFR;
        private System.Data.DataColumn N_NF_NF_ENT_NFR;
        private System.Data.DataColumn CHAVE_NFENT_NFR;
        private System.Data.DataColumn COD_ITENS_NOTA_SAIDA_NFR;
        private System.Data.DataColumn COD_SISTEMA_NF_SAIDA_NFR;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_chave;
        private System.Data.DataColumn dataColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODNFRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODSISTEMANFENTNFRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nNFNFENTNFRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHAVENFENTNFRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODITENSNOTASAIDANFRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODSISTEMANFSAIDANFRDataGridViewTextBoxColumn;
    }
}