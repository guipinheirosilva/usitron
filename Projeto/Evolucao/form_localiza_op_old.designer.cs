namespace Evolucao
{
    partial class form_localiza_op_old
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_localiza_op_old));
            this.dgvDesenhos = new System.Windows.Forms.DataGridView();
            this.col_os = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsDesenhos = new System.Data.DataSet();
            this.DESENHOS = new System.Data.DataTable();
            this.COD_PECA = new System.Data.DataColumn();
            this.N_OS_PECA = new System.Data.DataColumn();
            this.REVISAO = new System.Data.DataColumn();
            this.MATERIAL = new System.Data.DataColumn();
            this.ESPESSURA = new System.Data.DataColumn();
            this.CLIENTE = new System.Data.DataColumn();
            this.ROTA = new System.Data.DataColumn();
            this.NOME_PECA = new System.Data.DataColumn();
            this.N_SUB = new System.Data.DataColumn();
            this.N_ROTAS = new System.Data.DataColumn();
            this.POSICAO_PECA = new System.Data.DataColumn();
            this.FUNCAO_PECA = new System.Data.DataColumn();
            this.DATA_ENTREGA_PECA = new System.Data.DataColumn();
            this.OBS_PECA = new System.Data.DataColumn();
            this.PROJETISTA_PECA = new System.Data.DataColumn();
            this.DESPESAS_MOLDE_DES = new System.Data.DataColumn();
            this.RECEITAS_MOLDE_DES = new System.Data.DataColumn();
            this.HORAS_PREV_TORNO_MOLDE = new System.Data.DataColumn();
            this.HORAS_PREV_FRESA_MOLDE = new System.Data.DataColumn();
            this.HORAS_PREV_CNC_DES_MOLDE = new System.Data.DataColumn();
            this.HORAS_PREV_TEMPERA_MOLDE = new System.Data.DataColumn();
            this.HORAS_PREV_RETIFICA_MOLDE = new System.Data.DataColumn();
            this.HORAS_PREV_CNC_ACAB_MOLDE = new System.Data.DataColumn();
            this.HORAS_PREV_EROSAO_EDM_MOLDE = new System.Data.DataColumn();
            this.HORAS_PREV_EROSAO_EWC_MOLDE = new System.Data.DataColumn();
            this.HORAS_PREV_POLIMENTO_MOLDE = new System.Data.DataColumn();
            this.HORAS_PREV_PROJETO_MOLDE = new System.Data.DataColumn();
            this.HORAS_PREV_PORTA_MOLDE_MOLDE = new System.Data.DataColumn();
            this.HORAS_PREV_ELETRODO_MOLDE = new System.Data.DataColumn();
            this.HORAS_EXEC_TORNO_MOLDE = new System.Data.DataColumn();
            this.HORAS_EXEC_FRESA_MOLDE = new System.Data.DataColumn();
            this.HORAS_EXEC_CNC_DES_MOLDE = new System.Data.DataColumn();
            this.HORAS_EXEC_TEMPERA_MOLDE = new System.Data.DataColumn();
            this.HORAS_EXEC_RETIFICA_MOLDE = new System.Data.DataColumn();
            this.HORAS_EXEC_CNC_ACAB_MOLDE = new System.Data.DataColumn();
            this.HORAS_EXEC_EROSAO_EDM_MOLDE = new System.Data.DataColumn();
            this.HORAS_EXEC_EROSAO_EWC_MOLDE = new System.Data.DataColumn();
            this.HORAS_EXEC_POLIMENTO_MOLDE = new System.Data.DataColumn();
            this.HORAS_EXEC_PROJETO_MOLDE = new System.Data.DataColumn();
            this.HORAS_EXEC_PORTA_MOLDE_MOLDE = new System.Data.DataColumn();
            this.HORAS_EXEC_ELETRODO_MOLDE = new System.Data.DataColumn();
            this.HORAS_EXEC_DES_PC_ELET_MOLDE = new System.Data.DataColumn();
            this.TOTAL_ITENS_DES = new System.Data.DataColumn();
            this.ITENS_ENTREGUES_DES = new System.Data.DataColumn();
            this.tb_localiza_peca = new System.Windows.Forms.TextBox();
            this.datDesenhos = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDesenhos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDesenhos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DESENHOS)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDesenhos
            // 
            this.dgvDesenhos.AllowUserToAddRows = false;
            this.dgvDesenhos.AllowUserToDeleteRows = false;
            this.dgvDesenhos.AllowUserToResizeColumns = false;
            this.dgvDesenhos.AllowUserToResizeRows = false;
            this.dgvDesenhos.AutoGenerateColumns = false;
            this.dgvDesenhos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDesenhos.ColumnHeadersVisible = false;
            this.dgvDesenhos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_os,
            this.col_cliente});
            this.dgvDesenhos.DataMember = "DESENHOS";
            this.dgvDesenhos.DataSource = this.dsDesenhos;
            this.dgvDesenhos.Location = new System.Drawing.Point(1, 27);
            this.dgvDesenhos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDesenhos.Name = "dgvDesenhos";
            this.dgvDesenhos.ReadOnly = true;
            this.dgvDesenhos.RowHeadersVisible = false;
            this.dgvDesenhos.Size = new System.Drawing.Size(339, 185);
            this.dgvDesenhos.TabIndex = 3;
            this.dgvDesenhos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDesenhos_CellContentClick);
            this.dgvDesenhos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDesenhos_CellMouseClick);
            // 
            // col_os
            // 
            this.col_os.DataPropertyName = "N_OS_PECA";
            this.col_os.HeaderText = "N_OS_PECA";
            this.col_os.Name = "col_os";
            this.col_os.ReadOnly = true;
            // 
            // col_cliente
            // 
            this.col_cliente.DataPropertyName = "CLIENTE";
            this.col_cliente.HeaderText = "CLIENTE";
            this.col_cliente.Name = "col_cliente";
            this.col_cliente.ReadOnly = true;
            this.col_cliente.Width = 200;
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
            this.N_OS_PECA,
            this.REVISAO,
            this.MATERIAL,
            this.ESPESSURA,
            this.CLIENTE,
            this.ROTA,
            this.NOME_PECA,
            this.N_SUB,
            this.N_ROTAS,
            this.POSICAO_PECA,
            this.FUNCAO_PECA,
            this.DATA_ENTREGA_PECA,
            this.OBS_PECA,
            this.PROJETISTA_PECA,
            this.DESPESAS_MOLDE_DES,
            this.RECEITAS_MOLDE_DES,
            this.HORAS_PREV_TORNO_MOLDE,
            this.HORAS_PREV_FRESA_MOLDE,
            this.HORAS_PREV_CNC_DES_MOLDE,
            this.HORAS_PREV_TEMPERA_MOLDE,
            this.HORAS_PREV_RETIFICA_MOLDE,
            this.HORAS_PREV_CNC_ACAB_MOLDE,
            this.HORAS_PREV_EROSAO_EDM_MOLDE,
            this.HORAS_PREV_EROSAO_EWC_MOLDE,
            this.HORAS_PREV_POLIMENTO_MOLDE,
            this.HORAS_PREV_PROJETO_MOLDE,
            this.HORAS_PREV_PORTA_MOLDE_MOLDE,
            this.HORAS_PREV_ELETRODO_MOLDE,
            this.HORAS_EXEC_TORNO_MOLDE,
            this.HORAS_EXEC_FRESA_MOLDE,
            this.HORAS_EXEC_CNC_DES_MOLDE,
            this.HORAS_EXEC_TEMPERA_MOLDE,
            this.HORAS_EXEC_RETIFICA_MOLDE,
            this.HORAS_EXEC_CNC_ACAB_MOLDE,
            this.HORAS_EXEC_EROSAO_EDM_MOLDE,
            this.HORAS_EXEC_EROSAO_EWC_MOLDE,
            this.HORAS_EXEC_POLIMENTO_MOLDE,
            this.HORAS_EXEC_PROJETO_MOLDE,
            this.HORAS_EXEC_PORTA_MOLDE_MOLDE,
            this.HORAS_EXEC_ELETRODO_MOLDE,
            this.HORAS_EXEC_DES_PC_ELET_MOLDE,
            this.TOTAL_ITENS_DES,
            this.ITENS_ENTREGUES_DES});
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
            this.COD_PECA.DataType = typeof(int);
            // 
            // N_OS_PECA
            // 
            this.N_OS_PECA.ColumnName = "N_OS_PECA";
            this.N_OS_PECA.MaxLength = 50;
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
            this.CLIENTE.MaxLength = 100;
            // 
            // ROTA
            // 
            this.ROTA.ColumnName = "ROTA";
            this.ROTA.DataType = typeof(int);
            // 
            // NOME_PECA
            // 
            this.NOME_PECA.ColumnName = "NOME_PECA";
            this.NOME_PECA.MaxLength = 100;
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
            // FUNCAO_PECA
            // 
            this.FUNCAO_PECA.ColumnName = "FUNCAO_PECA";
            this.FUNCAO_PECA.MaxLength = 50;
            // 
            // DATA_ENTREGA_PECA
            // 
            this.DATA_ENTREGA_PECA.ColumnName = "DATA_ENTREGA_PECA";
            this.DATA_ENTREGA_PECA.DataType = typeof(System.DateTime);
            // 
            // OBS_PECA
            // 
            this.OBS_PECA.ColumnName = "OBS_PECA";
            this.OBS_PECA.MaxLength = 200;
            // 
            // PROJETISTA_PECA
            // 
            this.PROJETISTA_PECA.ColumnName = "PROJETISTA_PECA";
            this.PROJETISTA_PECA.MaxLength = 100;
            // 
            // DESPESAS_MOLDE_DES
            // 
            this.DESPESAS_MOLDE_DES.ColumnName = "DESPESAS_MOLDE_DES";
            this.DESPESAS_MOLDE_DES.DataType = typeof(double);
            // 
            // RECEITAS_MOLDE_DES
            // 
            this.RECEITAS_MOLDE_DES.ColumnName = "RECEITAS_MOLDE_DES";
            this.RECEITAS_MOLDE_DES.DataType = typeof(double);
            // 
            // HORAS_PREV_TORNO_MOLDE
            // 
            this.HORAS_PREV_TORNO_MOLDE.ColumnName = "HORAS_PREV_TORNO_MOLDE";
            this.HORAS_PREV_TORNO_MOLDE.DataType = typeof(double);
            // 
            // HORAS_PREV_FRESA_MOLDE
            // 
            this.HORAS_PREV_FRESA_MOLDE.ColumnName = "HORAS_PREV_FRESA_MOLDE";
            this.HORAS_PREV_FRESA_MOLDE.DataType = typeof(double);
            // 
            // HORAS_PREV_CNC_DES_MOLDE
            // 
            this.HORAS_PREV_CNC_DES_MOLDE.ColumnName = "HORAS_PREV_CNC_DES_MOLDE";
            this.HORAS_PREV_CNC_DES_MOLDE.DataType = typeof(double);
            // 
            // HORAS_PREV_TEMPERA_MOLDE
            // 
            this.HORAS_PREV_TEMPERA_MOLDE.ColumnName = "HORAS_PREV_TEMPERA_MOLDE";
            this.HORAS_PREV_TEMPERA_MOLDE.DataType = typeof(double);
            // 
            // HORAS_PREV_RETIFICA_MOLDE
            // 
            this.HORAS_PREV_RETIFICA_MOLDE.ColumnName = "HORAS_PREV_RETIFICA_MOLDE";
            this.HORAS_PREV_RETIFICA_MOLDE.DataType = typeof(double);
            // 
            // HORAS_PREV_CNC_ACAB_MOLDE
            // 
            this.HORAS_PREV_CNC_ACAB_MOLDE.ColumnName = "HORAS_PREV_CNC_ACAB_MOLDE";
            this.HORAS_PREV_CNC_ACAB_MOLDE.DataType = typeof(double);
            // 
            // HORAS_PREV_EROSAO_EDM_MOLDE
            // 
            this.HORAS_PREV_EROSAO_EDM_MOLDE.ColumnName = "HORAS_PREV_EROSAO_EDM_MOLDE";
            this.HORAS_PREV_EROSAO_EDM_MOLDE.DataType = typeof(double);
            // 
            // HORAS_PREV_EROSAO_EWC_MOLDE
            // 
            this.HORAS_PREV_EROSAO_EWC_MOLDE.ColumnName = "HORAS_PREV_EROSAO_EWC_MOLDE";
            this.HORAS_PREV_EROSAO_EWC_MOLDE.DataType = typeof(double);
            // 
            // HORAS_PREV_POLIMENTO_MOLDE
            // 
            this.HORAS_PREV_POLIMENTO_MOLDE.ColumnName = "HORAS_PREV_POLIMENTO_MOLDE";
            this.HORAS_PREV_POLIMENTO_MOLDE.DataType = typeof(double);
            // 
            // HORAS_PREV_PROJETO_MOLDE
            // 
            this.HORAS_PREV_PROJETO_MOLDE.ColumnName = "HORAS_PREV_PROJETO_MOLDE";
            this.HORAS_PREV_PROJETO_MOLDE.DataType = typeof(double);
            // 
            // HORAS_PREV_PORTA_MOLDE_MOLDE
            // 
            this.HORAS_PREV_PORTA_MOLDE_MOLDE.ColumnName = "HORAS_PREV_PORTA_MOLDE_MOLDE";
            this.HORAS_PREV_PORTA_MOLDE_MOLDE.DataType = typeof(double);
            // 
            // HORAS_PREV_ELETRODO_MOLDE
            // 
            this.HORAS_PREV_ELETRODO_MOLDE.ColumnName = "HORAS_PREV_ELETRODO_MOLDE";
            this.HORAS_PREV_ELETRODO_MOLDE.DataType = typeof(double);
            // 
            // HORAS_EXEC_TORNO_MOLDE
            // 
            this.HORAS_EXEC_TORNO_MOLDE.ColumnName = "HORAS_EXEC_TORNO_MOLDE";
            this.HORAS_EXEC_TORNO_MOLDE.DataType = typeof(double);
            // 
            // HORAS_EXEC_FRESA_MOLDE
            // 
            this.HORAS_EXEC_FRESA_MOLDE.ColumnName = "HORAS_EXEC_FRESA_MOLDE";
            this.HORAS_EXEC_FRESA_MOLDE.DataType = typeof(double);
            // 
            // HORAS_EXEC_CNC_DES_MOLDE
            // 
            this.HORAS_EXEC_CNC_DES_MOLDE.ColumnName = "HORAS_EXEC_CNC_DES_MOLDE";
            this.HORAS_EXEC_CNC_DES_MOLDE.DataType = typeof(double);
            // 
            // HORAS_EXEC_TEMPERA_MOLDE
            // 
            this.HORAS_EXEC_TEMPERA_MOLDE.ColumnName = "HORAS_EXEC_TEMPERA_MOLDE";
            this.HORAS_EXEC_TEMPERA_MOLDE.DataType = typeof(double);
            // 
            // HORAS_EXEC_RETIFICA_MOLDE
            // 
            this.HORAS_EXEC_RETIFICA_MOLDE.ColumnName = "HORAS_EXEC_RETIFICA_MOLDE";
            this.HORAS_EXEC_RETIFICA_MOLDE.DataType = typeof(double);
            // 
            // HORAS_EXEC_CNC_ACAB_MOLDE
            // 
            this.HORAS_EXEC_CNC_ACAB_MOLDE.ColumnName = "HORAS_EXEC_CNC_ACAB_MOLDE";
            this.HORAS_EXEC_CNC_ACAB_MOLDE.DataType = typeof(double);
            // 
            // HORAS_EXEC_EROSAO_EDM_MOLDE
            // 
            this.HORAS_EXEC_EROSAO_EDM_MOLDE.ColumnName = "HORAS_EXEC_EROSAO_EDM_MOLDE";
            this.HORAS_EXEC_EROSAO_EDM_MOLDE.DataType = typeof(double);
            // 
            // HORAS_EXEC_EROSAO_EWC_MOLDE
            // 
            this.HORAS_EXEC_EROSAO_EWC_MOLDE.ColumnName = "HORAS_EXEC_EROSAO_EWC_MOLDE";
            this.HORAS_EXEC_EROSAO_EWC_MOLDE.DataType = typeof(double);
            // 
            // HORAS_EXEC_POLIMENTO_MOLDE
            // 
            this.HORAS_EXEC_POLIMENTO_MOLDE.ColumnName = "HORAS_EXEC_POLIMENTO_MOLDE";
            this.HORAS_EXEC_POLIMENTO_MOLDE.DataType = typeof(double);
            // 
            // HORAS_EXEC_PROJETO_MOLDE
            // 
            this.HORAS_EXEC_PROJETO_MOLDE.ColumnName = "HORAS_EXEC_PROJETO_MOLDE";
            this.HORAS_EXEC_PROJETO_MOLDE.DataType = typeof(double);
            // 
            // HORAS_EXEC_PORTA_MOLDE_MOLDE
            // 
            this.HORAS_EXEC_PORTA_MOLDE_MOLDE.ColumnName = "HORAS_EXEC_PORTA_MOLDE_MOLDE";
            this.HORAS_EXEC_PORTA_MOLDE_MOLDE.DataType = typeof(double);
            // 
            // HORAS_EXEC_ELETRODO_MOLDE
            // 
            this.HORAS_EXEC_ELETRODO_MOLDE.ColumnName = "HORAS_EXEC_ELETRODO_MOLDE";
            this.HORAS_EXEC_ELETRODO_MOLDE.DataType = typeof(double);
            // 
            // HORAS_EXEC_DES_PC_ELET_MOLDE
            // 
            this.HORAS_EXEC_DES_PC_ELET_MOLDE.ColumnName = "HORAS_EXEC_DES_PC_ELET_MOLDE";
            this.HORAS_EXEC_DES_PC_ELET_MOLDE.DataType = typeof(double);
            // 
            // TOTAL_ITENS_DES
            // 
            this.TOTAL_ITENS_DES.ColumnName = "TOTAL_ITENS_DES";
            this.TOTAL_ITENS_DES.DataType = typeof(int);
            // 
            // ITENS_ENTREGUES_DES
            // 
            this.ITENS_ENTREGUES_DES.ColumnName = "ITENS_ENTREGUES_DES";
            this.ITENS_ENTREGUES_DES.DataType = typeof(int);
            // 
            // tb_localiza_peca
            // 
            this.tb_localiza_peca.Location = new System.Drawing.Point(1, 2);
            this.tb_localiza_peca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_localiza_peca.Name = "tb_localiza_peca";
            this.tb_localiza_peca.Size = new System.Drawing.Size(337, 22);
            this.tb_localiza_peca.TabIndex = 2;
            this.tb_localiza_peca.TextChanged += new System.EventHandler(this.tb_localiza_peca_TextChanged);
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
            this.fbCommand1.CommandText = "select * from desenhos order by n_os_peca desc";
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
            // form_localiza_op_old
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 219);
            this.Controls.Add(this.dgvDesenhos);
            this.Controls.Add(this.tb_localiza_peca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "form_localiza_op_old";
            this.Text = "form_localiza_op";
            this.Load += new System.EventHandler(this.form_localiza_op_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDesenhos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDesenhos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DESENHOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDesenhos;
        private System.Windows.Forms.TextBox tb_localiza_peca;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datDesenhos;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Data.DataSet dsDesenhos;
        private System.Data.DataTable DESENHOS;
        private System.Data.DataColumn COD_PECA;
        private System.Data.DataColumn N_OS_PECA;
        private System.Data.DataColumn REVISAO;
        private System.Data.DataColumn MATERIAL;
        private System.Data.DataColumn ESPESSURA;
        private System.Data.DataColumn CLIENTE;
        private System.Data.DataColumn ROTA;
        private System.Data.DataColumn NOME_PECA;
        private System.Data.DataColumn N_SUB;
        private System.Data.DataColumn N_ROTAS;
        private System.Data.DataColumn POSICAO_PECA;
        private System.Data.DataColumn FUNCAO_PECA;
        private System.Data.DataColumn DATA_ENTREGA_PECA;
        private System.Data.DataColumn OBS_PECA;
        private System.Data.DataColumn PROJETISTA_PECA;
        private System.Data.DataColumn DESPESAS_MOLDE_DES;
        private System.Data.DataColumn RECEITAS_MOLDE_DES;
        private System.Data.DataColumn HORAS_PREV_TORNO_MOLDE;
        private System.Data.DataColumn HORAS_PREV_FRESA_MOLDE;
        private System.Data.DataColumn HORAS_PREV_CNC_DES_MOLDE;
        private System.Data.DataColumn HORAS_PREV_TEMPERA_MOLDE;
        private System.Data.DataColumn HORAS_PREV_RETIFICA_MOLDE;
        private System.Data.DataColumn HORAS_PREV_CNC_ACAB_MOLDE;
        private System.Data.DataColumn HORAS_PREV_EROSAO_EDM_MOLDE;
        private System.Data.DataColumn HORAS_PREV_EROSAO_EWC_MOLDE;
        private System.Data.DataColumn HORAS_PREV_POLIMENTO_MOLDE;
        private System.Data.DataColumn HORAS_PREV_PROJETO_MOLDE;
        private System.Data.DataColumn HORAS_PREV_PORTA_MOLDE_MOLDE;
        private System.Data.DataColumn HORAS_PREV_ELETRODO_MOLDE;
        private System.Data.DataColumn HORAS_EXEC_TORNO_MOLDE;
        private System.Data.DataColumn HORAS_EXEC_FRESA_MOLDE;
        private System.Data.DataColumn HORAS_EXEC_CNC_DES_MOLDE;
        private System.Data.DataColumn HORAS_EXEC_TEMPERA_MOLDE;
        private System.Data.DataColumn HORAS_EXEC_RETIFICA_MOLDE;
        private System.Data.DataColumn HORAS_EXEC_CNC_ACAB_MOLDE;
        private System.Data.DataColumn HORAS_EXEC_EROSAO_EDM_MOLDE;
        private System.Data.DataColumn HORAS_EXEC_EROSAO_EWC_MOLDE;
        private System.Data.DataColumn HORAS_EXEC_POLIMENTO_MOLDE;
        private System.Data.DataColumn HORAS_EXEC_PROJETO_MOLDE;
        private System.Data.DataColumn HORAS_EXEC_PORTA_MOLDE_MOLDE;
        private System.Data.DataColumn HORAS_EXEC_ELETRODO_MOLDE;
        private System.Data.DataColumn HORAS_EXEC_DES_PC_ELET_MOLDE;
        private System.Data.DataColumn TOTAL_ITENS_DES;
        private System.Data.DataColumn ITENS_ENTREGUES_DES;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_os;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cliente;
    }
}