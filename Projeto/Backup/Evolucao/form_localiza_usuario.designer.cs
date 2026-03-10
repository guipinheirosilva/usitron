namespace Evolucao
{
    partial class form_localiza_usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_localiza_operador));
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dsUsuarios = new System.Data.DataSet();
            this.USUARIOS = new System.Data.DataTable();
            this.COD_USUARIO = new System.Data.DataColumn();
            this.NOME_USUARIO = new System.Data.DataColumn();
            this.SENHA_USUARIO = new System.Data.DataColumn();
            this.NIVEL_ACESSO_USUARIO = new System.Data.DataColumn();
            this.DESCRICAO_NIVEL_ACESSO_USUARIO = new System.Data.DataColumn();
            this.PCP_USUARIO = new System.Data.DataColumn();
            this.FATURAMENTO_USUARIO = new System.Data.DataColumn();
            this.ESTOQUE_USUARIO = new System.Data.DataColumn();
            this.COMPRAS_USUARIO = new System.Data.DataColumn();
            this.FINANCEIRO_USUARIO = new System.Data.DataColumn();
            this.ORCAMENTOS_USUARIO = new System.Data.DataColumn();
            this.QUALIDADE_USUARIO = new System.Data.DataColumn();
            this.TOTAL_USUARIO = new System.Data.DataColumn();
            this.tb_localiza_operador = new System.Windows.Forms.TextBox();
            this.datUsuarios = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand8 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand6 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand5 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand7 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.col_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMEUSUARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sENHAUSUARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nIVELACESSOUSUARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRICAONIVELACESSOUSUARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pCPUSUARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fATURAMENTOUSUARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSTOQUEUSUARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOMPRASUSUARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fINANCEIROUSUARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRCAMENTOSUSUARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qUALIDADEUSUARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOTALUSUARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.USUARIOS)).BeginInit();
            this.SuspendLayout();
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
            this.fbCommand1.CommandText = "select * from operadores order by nome";
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
            this.col_cod,
            this.nOMEUSUARIODataGridViewTextBoxColumn,
            this.sENHAUSUARIODataGridViewTextBoxColumn,
            this.nIVELACESSOUSUARIODataGridViewTextBoxColumn,
            this.dESCRICAONIVELACESSOUSUARIODataGridViewTextBoxColumn,
            this.pCPUSUARIODataGridViewTextBoxColumn,
            this.fATURAMENTOUSUARIODataGridViewTextBoxColumn,
            this.eSTOQUEUSUARIODataGridViewTextBoxColumn,
            this.cOMPRASUSUARIODataGridViewTextBoxColumn,
            this.fINANCEIROUSUARIODataGridViewTextBoxColumn,
            this.oRCAMENTOSUSUARIODataGridViewTextBoxColumn,
            this.qUALIDADEUSUARIODataGridViewTextBoxColumn,
            this.tOTALUSUARIODataGridViewTextBoxColumn});
            this.dataGridView1.DataMember = "USUARIOS";
            this.dataGridView1.DataSource = this.dsUsuarios;
            this.dataGridView1.Location = new System.Drawing.Point(3, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(254, 150);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // dsUsuarios
            // 
            this.dsUsuarios.DataSetName = "dsUsuarios";
            this.dsUsuarios.Namespace = "http://www.tempuri.org/dsUsuarios.xsd";
            this.dsUsuarios.Tables.AddRange(new System.Data.DataTable[] {
            this.USUARIOS});
            // 
            // USUARIOS
            // 
            this.USUARIOS.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_USUARIO,
            this.NOME_USUARIO,
            this.SENHA_USUARIO,
            this.NIVEL_ACESSO_USUARIO,
            this.DESCRICAO_NIVEL_ACESSO_USUARIO,
            this.PCP_USUARIO,
            this.FATURAMENTO_USUARIO,
            this.ESTOQUE_USUARIO,
            this.COMPRAS_USUARIO,
            this.FINANCEIRO_USUARIO,
            this.ORCAMENTOS_USUARIO,
            this.QUALIDADE_USUARIO,
            this.TOTAL_USUARIO});
            this.USUARIOS.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_USUARIO"}, true)});
            this.USUARIOS.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_USUARIO};
            this.USUARIOS.TableName = "USUARIOS";
            // 
            // COD_USUARIO
            // 
            this.COD_USUARIO.AllowDBNull = false;
            this.COD_USUARIO.ColumnName = "COD_USUARIO";
            this.COD_USUARIO.DataType = typeof(int);
            // 
            // NOME_USUARIO
            // 
            this.NOME_USUARIO.ColumnName = "NOME_USUARIO";
            this.NOME_USUARIO.MaxLength = 50;
            // 
            // SENHA_USUARIO
            // 
            this.SENHA_USUARIO.ColumnName = "SENHA_USUARIO";
            this.SENHA_USUARIO.MaxLength = 20;
            // 
            // NIVEL_ACESSO_USUARIO
            // 
            this.NIVEL_ACESSO_USUARIO.ColumnName = "NIVEL_ACESSO_USUARIO";
            this.NIVEL_ACESSO_USUARIO.DataType = typeof(int);
            // 
            // DESCRICAO_NIVEL_ACESSO_USUARIO
            // 
            this.DESCRICAO_NIVEL_ACESSO_USUARIO.ColumnName = "DESCRICAO_NIVEL_ACESSO_USUARIO";
            this.DESCRICAO_NIVEL_ACESSO_USUARIO.MaxLength = 100;
            // 
            // PCP_USUARIO
            // 
            this.PCP_USUARIO.ColumnName = "PCP_USUARIO";
            this.PCP_USUARIO.DataType = typeof(int);
            // 
            // FATURAMENTO_USUARIO
            // 
            this.FATURAMENTO_USUARIO.ColumnName = "FATURAMENTO_USUARIO";
            this.FATURAMENTO_USUARIO.DataType = typeof(int);
            // 
            // ESTOQUE_USUARIO
            // 
            this.ESTOQUE_USUARIO.ColumnName = "ESTOQUE_USUARIO";
            this.ESTOQUE_USUARIO.DataType = typeof(int);
            // 
            // COMPRAS_USUARIO
            // 
            this.COMPRAS_USUARIO.ColumnName = "COMPRAS_USUARIO";
            this.COMPRAS_USUARIO.DataType = typeof(int);
            // 
            // FINANCEIRO_USUARIO
            // 
            this.FINANCEIRO_USUARIO.ColumnName = "FINANCEIRO_USUARIO";
            this.FINANCEIRO_USUARIO.DataType = typeof(int);
            // 
            // ORCAMENTOS_USUARIO
            // 
            this.ORCAMENTOS_USUARIO.ColumnName = "ORCAMENTOS_USUARIO";
            this.ORCAMENTOS_USUARIO.DataType = typeof(int);
            // 
            // QUALIDADE_USUARIO
            // 
            this.QUALIDADE_USUARIO.ColumnName = "QUALIDADE_USUARIO";
            this.QUALIDADE_USUARIO.DataType = typeof(int);
            // 
            // TOTAL_USUARIO
            // 
            this.TOTAL_USUARIO.ColumnName = "TOTAL_USUARIO";
            this.TOTAL_USUARIO.DataType = typeof(int);
            // 
            // tb_localiza_operador
            // 
            this.tb_localiza_operador.Location = new System.Drawing.Point(3, 4);
            this.tb_localiza_operador.Name = "tb_localiza_operador";
            this.tb_localiza_operador.Size = new System.Drawing.Size(254, 20);
            this.tb_localiza_operador.TabIndex = 4;
            this.tb_localiza_operador.TextChanged += new System.EventHandler(this.tb_localiza_operador_TextChanged);
            // 
            // datUsuarios
            // 
            this.datUsuarios.DeleteCommand = this.fbCommand8;
            this.datUsuarios.InsertCommand = this.fbCommand6;
            this.datUsuarios.SelectCommand = this.fbCommand5;
            this.datUsuarios.UpdateCommand = this.fbCommand7;
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
            this.fbCommand5.CommandText = "select * from usuarios";
            this.fbCommand5.CommandTimeout = 30;
            this.fbCommand5.Connection = this.fbConnection1;
            // 
            // fbCommand7
            // 
            this.fbCommand7.CommandTimeout = 30;
            // 
            // col_cod
            // 
            this.col_cod.DataPropertyName = "COD_USUARIO";
            this.col_cod.HeaderText = "COD_USUARIO";
            this.col_cod.Name = "col_cod";
            this.col_cod.ReadOnly = true;
            this.col_cod.Width = 50;
            // 
            // nOMEUSUARIODataGridViewTextBoxColumn
            // 
            this.nOMEUSUARIODataGridViewTextBoxColumn.DataPropertyName = "NOME_USUARIO";
            this.nOMEUSUARIODataGridViewTextBoxColumn.HeaderText = "NOME_USUARIO";
            this.nOMEUSUARIODataGridViewTextBoxColumn.Name = "nOMEUSUARIODataGridViewTextBoxColumn";
            this.nOMEUSUARIODataGridViewTextBoxColumn.ReadOnly = true;
            this.nOMEUSUARIODataGridViewTextBoxColumn.Width = 150;
            // 
            // sENHAUSUARIODataGridViewTextBoxColumn
            // 
            this.sENHAUSUARIODataGridViewTextBoxColumn.DataPropertyName = "SENHA_USUARIO";
            this.sENHAUSUARIODataGridViewTextBoxColumn.HeaderText = "SENHA_USUARIO";
            this.sENHAUSUARIODataGridViewTextBoxColumn.Name = "sENHAUSUARIODataGridViewTextBoxColumn";
            this.sENHAUSUARIODataGridViewTextBoxColumn.ReadOnly = true;
            this.sENHAUSUARIODataGridViewTextBoxColumn.Visible = false;
            // 
            // nIVELACESSOUSUARIODataGridViewTextBoxColumn
            // 
            this.nIVELACESSOUSUARIODataGridViewTextBoxColumn.DataPropertyName = "NIVEL_ACESSO_USUARIO";
            this.nIVELACESSOUSUARIODataGridViewTextBoxColumn.HeaderText = "NIVEL_ACESSO_USUARIO";
            this.nIVELACESSOUSUARIODataGridViewTextBoxColumn.Name = "nIVELACESSOUSUARIODataGridViewTextBoxColumn";
            this.nIVELACESSOUSUARIODataGridViewTextBoxColumn.ReadOnly = true;
            this.nIVELACESSOUSUARIODataGridViewTextBoxColumn.Visible = false;
            // 
            // dESCRICAONIVELACESSOUSUARIODataGridViewTextBoxColumn
            // 
            this.dESCRICAONIVELACESSOUSUARIODataGridViewTextBoxColumn.DataPropertyName = "DESCRICAO_NIVEL_ACESSO_USUARIO";
            this.dESCRICAONIVELACESSOUSUARIODataGridViewTextBoxColumn.HeaderText = "DESCRICAO_NIVEL_ACESSO_USUARIO";
            this.dESCRICAONIVELACESSOUSUARIODataGridViewTextBoxColumn.Name = "dESCRICAONIVELACESSOUSUARIODataGridViewTextBoxColumn";
            this.dESCRICAONIVELACESSOUSUARIODataGridViewTextBoxColumn.ReadOnly = true;
            this.dESCRICAONIVELACESSOUSUARIODataGridViewTextBoxColumn.Visible = false;
            // 
            // pCPUSUARIODataGridViewTextBoxColumn
            // 
            this.pCPUSUARIODataGridViewTextBoxColumn.DataPropertyName = "PCP_USUARIO";
            this.pCPUSUARIODataGridViewTextBoxColumn.HeaderText = "PCP_USUARIO";
            this.pCPUSUARIODataGridViewTextBoxColumn.Name = "pCPUSUARIODataGridViewTextBoxColumn";
            this.pCPUSUARIODataGridViewTextBoxColumn.ReadOnly = true;
            this.pCPUSUARIODataGridViewTextBoxColumn.Visible = false;
            // 
            // fATURAMENTOUSUARIODataGridViewTextBoxColumn
            // 
            this.fATURAMENTOUSUARIODataGridViewTextBoxColumn.DataPropertyName = "FATURAMENTO_USUARIO";
            this.fATURAMENTOUSUARIODataGridViewTextBoxColumn.HeaderText = "FATURAMENTO_USUARIO";
            this.fATURAMENTOUSUARIODataGridViewTextBoxColumn.Name = "fATURAMENTOUSUARIODataGridViewTextBoxColumn";
            this.fATURAMENTOUSUARIODataGridViewTextBoxColumn.ReadOnly = true;
            this.fATURAMENTOUSUARIODataGridViewTextBoxColumn.Visible = false;
            // 
            // eSTOQUEUSUARIODataGridViewTextBoxColumn
            // 
            this.eSTOQUEUSUARIODataGridViewTextBoxColumn.DataPropertyName = "ESTOQUE_USUARIO";
            this.eSTOQUEUSUARIODataGridViewTextBoxColumn.HeaderText = "ESTOQUE_USUARIO";
            this.eSTOQUEUSUARIODataGridViewTextBoxColumn.Name = "eSTOQUEUSUARIODataGridViewTextBoxColumn";
            this.eSTOQUEUSUARIODataGridViewTextBoxColumn.ReadOnly = true;
            this.eSTOQUEUSUARIODataGridViewTextBoxColumn.Visible = false;
            // 
            // cOMPRASUSUARIODataGridViewTextBoxColumn
            // 
            this.cOMPRASUSUARIODataGridViewTextBoxColumn.DataPropertyName = "COMPRAS_USUARIO";
            this.cOMPRASUSUARIODataGridViewTextBoxColumn.HeaderText = "COMPRAS_USUARIO";
            this.cOMPRASUSUARIODataGridViewTextBoxColumn.Name = "cOMPRASUSUARIODataGridViewTextBoxColumn";
            this.cOMPRASUSUARIODataGridViewTextBoxColumn.ReadOnly = true;
            this.cOMPRASUSUARIODataGridViewTextBoxColumn.Visible = false;
            // 
            // fINANCEIROUSUARIODataGridViewTextBoxColumn
            // 
            this.fINANCEIROUSUARIODataGridViewTextBoxColumn.DataPropertyName = "FINANCEIRO_USUARIO";
            this.fINANCEIROUSUARIODataGridViewTextBoxColumn.HeaderText = "FINANCEIRO_USUARIO";
            this.fINANCEIROUSUARIODataGridViewTextBoxColumn.Name = "fINANCEIROUSUARIODataGridViewTextBoxColumn";
            this.fINANCEIROUSUARIODataGridViewTextBoxColumn.ReadOnly = true;
            this.fINANCEIROUSUARIODataGridViewTextBoxColumn.Visible = false;
            // 
            // oRCAMENTOSUSUARIODataGridViewTextBoxColumn
            // 
            this.oRCAMENTOSUSUARIODataGridViewTextBoxColumn.DataPropertyName = "ORCAMENTOS_USUARIO";
            this.oRCAMENTOSUSUARIODataGridViewTextBoxColumn.HeaderText = "ORCAMENTOS_USUARIO";
            this.oRCAMENTOSUSUARIODataGridViewTextBoxColumn.Name = "oRCAMENTOSUSUARIODataGridViewTextBoxColumn";
            this.oRCAMENTOSUSUARIODataGridViewTextBoxColumn.ReadOnly = true;
            this.oRCAMENTOSUSUARIODataGridViewTextBoxColumn.Visible = false;
            // 
            // qUALIDADEUSUARIODataGridViewTextBoxColumn
            // 
            this.qUALIDADEUSUARIODataGridViewTextBoxColumn.DataPropertyName = "QUALIDADE_USUARIO";
            this.qUALIDADEUSUARIODataGridViewTextBoxColumn.HeaderText = "QUALIDADE_USUARIO";
            this.qUALIDADEUSUARIODataGridViewTextBoxColumn.Name = "qUALIDADEUSUARIODataGridViewTextBoxColumn";
            this.qUALIDADEUSUARIODataGridViewTextBoxColumn.ReadOnly = true;
            this.qUALIDADEUSUARIODataGridViewTextBoxColumn.Visible = false;
            // 
            // tOTALUSUARIODataGridViewTextBoxColumn
            // 
            this.tOTALUSUARIODataGridViewTextBoxColumn.DataPropertyName = "TOTAL_USUARIO";
            this.tOTALUSUARIODataGridViewTextBoxColumn.HeaderText = "TOTAL_USUARIO";
            this.tOTALUSUARIODataGridViewTextBoxColumn.Name = "tOTALUSUARIODataGridViewTextBoxColumn";
            this.tOTALUSUARIODataGridViewTextBoxColumn.ReadOnly = true;
            this.tOTALUSUARIODataGridViewTextBoxColumn.Visible = false;
            // 
            // form_localiza_operador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 178);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tb_localiza_operador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_localiza_operador";
            this.Text = "form_localiza_operador";
            this.Load += new System.EventHandler(this.form_localiza_operador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.USUARIOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tb_localiza_operador;
        private System.Data.DataSet dsUsuarios;
        private System.Data.DataTable USUARIOS;
        private System.Data.DataColumn COD_USUARIO;
        private System.Data.DataColumn NOME_USUARIO;
        private System.Data.DataColumn SENHA_USUARIO;
        private System.Data.DataColumn NIVEL_ACESSO_USUARIO;
        private System.Data.DataColumn DESCRICAO_NIVEL_ACESSO_USUARIO;
        private System.Data.DataColumn PCP_USUARIO;
        private System.Data.DataColumn FATURAMENTO_USUARIO;
        private System.Data.DataColumn ESTOQUE_USUARIO;
        private System.Data.DataColumn COMPRAS_USUARIO;
        private System.Data.DataColumn FINANCEIRO_USUARIO;
        private System.Data.DataColumn ORCAMENTOS_USUARIO;
        private System.Data.DataColumn QUALIDADE_USUARIO;
        private System.Data.DataColumn TOTAL_USUARIO;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datUsuarios;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand8;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand6;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand5;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand7;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMEUSUARIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sENHAUSUARIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIVELACESSOUSUARIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRICAONIVELACESSOUSUARIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pCPUSUARIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fATURAMENTOUSUARIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTOQUEUSUARIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOMPRASUSUARIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fINANCEIROUSUARIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oRCAMENTOSUSUARIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qUALIDADEUSUARIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOTALUSUARIODataGridViewTextBoxColumn;

    }
}