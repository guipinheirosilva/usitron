namespace Evolucao
{
    partial class form_cte_carta_correcao_tag
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_cte_carta_correcao_tag));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_cod_cte = new System.Windows.Forms.TextBox();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.cbGrupos = new System.Windows.Forms.ComboBox();
            this.cbCampo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_texto_correcao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_n_item = new System.Windows.Forms.TextBox();
            this.dgvCarta_correcao_tags = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.datCarta_correcao_tags = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsCarta_correcao_tags = new System.Data.DataSet();
            this.CARTA_CORRECAO_TAGS = new System.Data.DataTable();
            this.COD_CCT = new System.Data.DataColumn();
            this.COD_CTE_CCT = new System.Data.DataColumn();
            this.GRUPO_CCT = new System.Data.DataColumn();
            this.CAMPO_CCT = new System.Data.DataColumn();
            this.VALOR_CCT = new System.Data.DataColumn();
            this.N_ITEM_CCT = new System.Data.DataColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_cte = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.cbCarta_correcao_tags = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.cODCCTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_grupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_campo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_texto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_n_item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarta_correcao_tags)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCarta_correcao_tags)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CARTA_CORRECAO_TAGS)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cód. CTE:";
            this.label1.Visible = false;
            // 
            // tb_cod_cte
            // 
            this.tb_cod_cte.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cod_cte.Location = new System.Drawing.Point(233, 40);
            this.tb_cod_cte.Name = "tb_cod_cte";
            this.tb_cod_cte.ReadOnly = true;
            this.tb_cod_cte.Size = new System.Drawing.Size(100, 31);
            this.tb_cod_cte.TabIndex = 1;
            this.tb_cod_cte.Visible = false;
            // 
            // fbConnection1
            // 
            this.fbConnection1.ConnectionString = resources.GetString("fbConnection1.ConnectionString");
            // 
            // cbGrupos
            // 
            this.cbGrupos.FormattingEnabled = true;
            this.cbGrupos.Location = new System.Drawing.Point(8, 24);
            this.cbGrupos.Name = "cbGrupos";
            this.cbGrupos.Size = new System.Drawing.Size(101, 21);
            this.cbGrupos.TabIndex = 2;
            this.cbGrupos.SelectedValueChanged += new System.EventHandler(this.cbGrupos_SelectedValueChanged);
            // 
            // cbCampo
            // 
            this.cbCampo.FormattingEnabled = true;
            this.cbCampo.Location = new System.Drawing.Point(115, 24);
            this.cbCampo.Name = "cbCampo";
            this.cbCampo.Size = new System.Drawing.Size(101, 21);
            this.cbCampo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Grupo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Campo:";
            // 
            // tb_texto_correcao
            // 
            this.tb_texto_correcao.Location = new System.Drawing.Point(227, 23);
            this.tb_texto_correcao.Name = "tb_texto_correcao";
            this.tb_texto_correcao.Size = new System.Drawing.Size(149, 20);
            this.tb_texto_correcao.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Texto Correção:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(393, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "N° Item:";
            // 
            // tb_n_item
            // 
            this.tb_n_item.Location = new System.Drawing.Point(386, 23);
            this.tb_n_item.Name = "tb_n_item";
            this.tb_n_item.Size = new System.Drawing.Size(52, 20);
            this.tb_n_item.TabIndex = 8;
            // 
            // dgvCarta_correcao_tags
            // 
            this.dgvCarta_correcao_tags.AllowUserToAddRows = false;
            this.dgvCarta_correcao_tags.AutoGenerateColumns = false;
            this.dgvCarta_correcao_tags.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarta_correcao_tags.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODCCTDataGridViewTextBoxColumn,
            this.col_grupo,
            this.col_campo,
            this.col_texto,
            this.col_n_item});
            this.dgvCarta_correcao_tags.DataMember = "CARTA_CORRECAO_TAGS";
            this.dgvCarta_correcao_tags.DataSource = this.dsCarta_correcao_tags;
            this.dgvCarta_correcao_tags.Location = new System.Drawing.Point(16, 139);
            this.dgvCarta_correcao_tags.Name = "dgvCarta_correcao_tags";
            this.dgvCarta_correcao_tags.Size = new System.Drawing.Size(526, 414);
            this.dgvCarta_correcao_tags.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(453, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 24);
            this.button1.TabIndex = 11;
            this.button1.Text = "Inserir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // datCarta_correcao_tags
            // 
            this.datCarta_correcao_tags.DeleteCommand = this.fbCommand4;
            this.datCarta_correcao_tags.InsertCommand = this.fbCommand2;
            this.datCarta_correcao_tags.SelectCommand = this.fbCommand1;
            this.datCarta_correcao_tags.UpdateCommand = this.fbCommand3;
            // 
            // fbCommand1
            // 
            this.fbCommand1.CommandText = "select * from CARTA_CORRECAO_TAGS";
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
            // dsCarta_correcao_tags
            // 
            this.dsCarta_correcao_tags.DataSetName = "dsCarta_correcao_tags";
            this.dsCarta_correcao_tags.Namespace = "http://www.tempuri.org/dsCarta_correcao_tags.xsd";
            this.dsCarta_correcao_tags.Tables.AddRange(new System.Data.DataTable[] {
            this.CARTA_CORRECAO_TAGS});
            // 
            // CARTA_CORRECAO_TAGS
            // 
            this.CARTA_CORRECAO_TAGS.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_CCT,
            this.COD_CTE_CCT,
            this.GRUPO_CCT,
            this.CAMPO_CCT,
            this.VALOR_CCT,
            this.N_ITEM_CCT});
            this.CARTA_CORRECAO_TAGS.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_CCT"}, true)});
            this.CARTA_CORRECAO_TAGS.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_CCT};
            this.CARTA_CORRECAO_TAGS.TableName = "CARTA_CORRECAO_TAGS";
            // 
            // COD_CCT
            // 
            this.COD_CCT.AllowDBNull = false;
            this.COD_CCT.ColumnName = "COD_CCT";
            this.COD_CCT.DataType = typeof(int);
            // 
            // COD_CTE_CCT
            // 
            this.COD_CTE_CCT.ColumnName = "COD_CTE_CCT";
            this.COD_CTE_CCT.DataType = typeof(int);
            // 
            // GRUPO_CCT
            // 
            this.GRUPO_CCT.ColumnName = "GRUPO_CCT";
            this.GRUPO_CCT.MaxLength = 200;
            // 
            // CAMPO_CCT
            // 
            this.CAMPO_CCT.ColumnName = "CAMPO_CCT";
            this.CAMPO_CCT.MaxLength = 200;
            // 
            // VALOR_CCT
            // 
            this.VALOR_CCT.ColumnName = "VALOR_CCT";
            this.VALOR_CCT.MaxLength = 200;
            // 
            // N_ITEM_CCT
            // 
            this.N_ITEM_CCT.ColumnName = "N_ITEM_CCT";
            this.N_ITEM_CCT.DataType = typeof(int);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tb_n_item);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tb_texto_correcao);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbCampo);
            this.panel1.Controls.Add(this.cbGrupos);
            this.panel1.Location = new System.Drawing.Point(16, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 55);
            this.panel1.TabIndex = 12;
            // 
            // tb_cte
            // 
            this.tb_cte.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cte.Location = new System.Drawing.Point(233, 3);
            this.tb_cte.Name = "tb_cte";
            this.tb_cte.ReadOnly = true;
            this.tb_cte.Size = new System.Drawing.Size(100, 31);
            this.tb_cte.TabIndex = 14;
            this.tb_cte.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(116, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "CTE:";
            this.label6.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(190, 560);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Salvar e Finalizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbCarta_correcao_tags
            // 
            this.cbCarta_correcao_tags.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbCarta_correcao_tags.DataAdapter = this.datCarta_correcao_tags;
            this.cbCarta_correcao_tags.QuotePrefix = "\"";
            this.cbCarta_correcao_tags.QuoteSuffix = "\"";
            // 
            // cODCCTDataGridViewTextBoxColumn
            // 
            this.cODCCTDataGridViewTextBoxColumn.DataPropertyName = "COD_CCT";
            this.cODCCTDataGridViewTextBoxColumn.HeaderText = "Cód.";
            this.cODCCTDataGridViewTextBoxColumn.Name = "cODCCTDataGridViewTextBoxColumn";
            this.cODCCTDataGridViewTextBoxColumn.Visible = false;
            // 
            // col_grupo
            // 
            this.col_grupo.DataPropertyName = "GRUPO_CCT";
            this.col_grupo.HeaderText = "Grupo";
            this.col_grupo.Name = "col_grupo";
            // 
            // col_campo
            // 
            this.col_campo.DataPropertyName = "CAMPO_CCT";
            this.col_campo.HeaderText = "Campo";
            this.col_campo.Name = "col_campo";
            // 
            // col_texto
            // 
            this.col_texto.DataPropertyName = "VALOR_CCT";
            this.col_texto.HeaderText = "Valor";
            this.col_texto.Name = "col_texto";
            // 
            // col_n_item
            // 
            this.col_n_item.DataPropertyName = "N_ITEM_CCT";
            this.col_n_item.HeaderText = "N° Item";
            this.col_n_item.Name = "col_n_item";
            // 
            // form_cte_carta_correcao_tag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 596);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tb_cte);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvCarta_correcao_tags);
            this.Controls.Add(this.tb_cod_cte);
            this.Controls.Add(this.label1);
            this.Name = "form_cte_carta_correcao_tag";
            this.Text = "CTE Carta de Correção TAG";
            this.Load += new System.EventHandler(this.form_cte_carta_correcao_tag_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarta_correcao_tags)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCarta_correcao_tags)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CARTA_CORRECAO_TAGS)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_cod_cte;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private System.Windows.Forms.ComboBox cbGrupos;
        private System.Windows.Forms.ComboBox cbCampo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_texto_correcao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_n_item;
        private System.Windows.Forms.DataGridView dgvCarta_correcao_tags;
        private System.Windows.Forms.Button button1;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datCarta_correcao_tags;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Data.DataSet dsCarta_correcao_tags;
        private System.Data.DataTable CARTA_CORRECAO_TAGS;
        private System.Data.DataColumn COD_CCT;
        private System.Data.DataColumn COD_CTE_CCT;
        private System.Data.DataColumn GRUPO_CCT;
        private System.Data.DataColumn CAMPO_CCT;
        private System.Data.DataColumn VALOR_CCT;
        private System.Data.DataColumn N_ITEM_CCT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_cte;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbCarta_correcao_tags;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODCCTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_grupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_campo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_texto;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_n_item;
    }
}