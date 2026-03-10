namespace Evolucao
{
    partial class form_nova_parada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_nova_parada));
            this.datParadas = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsParadas = new System.Data.DataSet();
            this.PARADAS = new System.Data.DataTable();
            this.COD_PARADA = new System.Data.DataColumn();
            this.TIPO_PARADA = new System.Data.DataColumn();
            this.HORA_INICIO = new System.Data.DataColumn();
            this.DATA_INICIO = new System.Data.DataColumn();
            this.HORA_TERMINO = new System.Data.DataColumn();
            this.DATA_TERMINO = new System.Data.DataColumn();
            this.N_ROTAS_CAMPO = new System.Data.DataColumn();
            this.OBS_PARADA = new System.Data.DataColumn();
            this.PECAS_PRODUZIDAS_PARADA = new System.Data.DataColumn();
            this.OPERADOR = new System.Data.DataColumn();
            this.MAQUINA_PARADA = new System.Data.DataColumn();
            this.PARADA_FINALIZADA = new System.Data.DataColumn();
            this.COD_PARADA_NUM = new System.Data.DataColumn();
            this.OPERADOR_FINALIZADOR_PARADA = new System.Data.DataColumn();
            this.TOTAL_HORAS_PARADA = new System.Data.DataColumn();
            this.ITENS_CONJUNTOS_PARADA = new System.Data.DataColumn();
            this.MAQUINA_REINICIO = new System.Data.DataColumn();
            this.ITENS_CONJUNTOS_REINICIO = new System.Data.DataColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tb_operador = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_maquina = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_data = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_hora = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_rota = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbParadas = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            ((System.ComponentModel.ISupportInitialize)(this.dsParadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PARADAS)).BeginInit();
            this.SuspendLayout();
            // 
            // datParadas
            // 
            this.datParadas.DeleteCommand = this.fbCommand4;
            this.datParadas.InsertCommand = this.fbCommand2;
            this.datParadas.SelectCommand = this.fbCommand1;
            this.datParadas.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * from paradas";
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
            // dsParadas
            // 
            this.dsParadas.DataSetName = "dsParadas";
            this.dsParadas.Namespace = "http://www.tempuri.org/dsParadas.xsd";
            this.dsParadas.Tables.AddRange(new System.Data.DataTable[] {
            this.PARADAS});
            // 
            // PARADAS
            // 
            this.PARADAS.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_PARADA,
            this.TIPO_PARADA,
            this.HORA_INICIO,
            this.DATA_INICIO,
            this.HORA_TERMINO,
            this.DATA_TERMINO,
            this.N_ROTAS_CAMPO,
            this.OBS_PARADA,
            this.PECAS_PRODUZIDAS_PARADA,
            this.OPERADOR,
            this.MAQUINA_PARADA,
            this.PARADA_FINALIZADA,
            this.COD_PARADA_NUM,
            this.OPERADOR_FINALIZADOR_PARADA,
            this.TOTAL_HORAS_PARADA,
            this.ITENS_CONJUNTOS_PARADA,
            this.MAQUINA_REINICIO,
            this.ITENS_CONJUNTOS_REINICIO});
            this.PARADAS.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_PARADA"}, true)});
            this.PARADAS.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_PARADA};
            this.PARADAS.TableName = "PARADAS";
            // 
            // COD_PARADA
            // 
            this.COD_PARADA.AllowDBNull = false;
            this.COD_PARADA.AutoIncrement = true;
            this.COD_PARADA.ColumnName = "COD_PARADA";
            this.COD_PARADA.DataType = typeof(int);
            // 
            // TIPO_PARADA
            // 
            this.TIPO_PARADA.ColumnName = "TIPO_PARADA";
            this.TIPO_PARADA.MaxLength = 30;
            // 
            // HORA_INICIO
            // 
            this.HORA_INICIO.ColumnName = "HORA_INICIO";
            this.HORA_INICIO.MaxLength = 20;
            // 
            // DATA_INICIO
            // 
            this.DATA_INICIO.ColumnName = "DATA_INICIO";
            this.DATA_INICIO.DataType = typeof(System.DateTime);
            // 
            // HORA_TERMINO
            // 
            this.HORA_TERMINO.ColumnName = "HORA_TERMINO";
            this.HORA_TERMINO.MaxLength = 20;
            // 
            // DATA_TERMINO
            // 
            this.DATA_TERMINO.ColumnName = "DATA_TERMINO";
            this.DATA_TERMINO.DataType = typeof(System.DateTime);
            // 
            // N_ROTAS_CAMPO
            // 
            this.N_ROTAS_CAMPO.ColumnName = "N_ROTAS_CAMPO";
            this.N_ROTAS_CAMPO.MaxLength = 30;
            // 
            // OBS_PARADA
            // 
            this.OBS_PARADA.ColumnName = "OBS_PARADA";
            this.OBS_PARADA.MaxLength = 100;
            // 
            // PECAS_PRODUZIDAS_PARADA
            // 
            this.PECAS_PRODUZIDAS_PARADA.ColumnName = "PECAS_PRODUZIDAS_PARADA";
            this.PECAS_PRODUZIDAS_PARADA.DataType = typeof(int);
            // 
            // OPERADOR
            // 
            this.OPERADOR.ColumnName = "OPERADOR";
            this.OPERADOR.MaxLength = 50;
            // 
            // MAQUINA_PARADA
            // 
            this.MAQUINA_PARADA.ColumnName = "MAQUINA_PARADA";
            this.MAQUINA_PARADA.MaxLength = 30;
            // 
            // PARADA_FINALIZADA
            // 
            this.PARADA_FINALIZADA.ColumnName = "PARADA_FINALIZADA";
            this.PARADA_FINALIZADA.MaxLength = 10;
            // 
            // COD_PARADA_NUM
            // 
            this.COD_PARADA_NUM.ColumnName = "COD_PARADA_NUM";
            this.COD_PARADA_NUM.MaxLength = 15;
            // 
            // OPERADOR_FINALIZADOR_PARADA
            // 
            this.OPERADOR_FINALIZADOR_PARADA.ColumnName = "OPERADOR_FINALIZADOR_PARADA";
            this.OPERADOR_FINALIZADOR_PARADA.MaxLength = 30;
            // 
            // TOTAL_HORAS_PARADA
            // 
            this.TOTAL_HORAS_PARADA.ColumnName = "TOTAL_HORAS_PARADA";
            this.TOTAL_HORAS_PARADA.DataType = typeof(double);
            // 
            // ITENS_CONJUNTOS_PARADA
            // 
            this.ITENS_CONJUNTOS_PARADA.ColumnName = "ITENS_CONJUNTOS_PARADA";
            this.ITENS_CONJUNTOS_PARADA.DataType = typeof(int);
            // 
            // MAQUINA_REINICIO
            // 
            this.MAQUINA_REINICIO.ColumnName = "MAQUINA_REINICIO";
            this.MAQUINA_REINICIO.MaxLength = 30;
            // 
            // ITENS_CONJUNTOS_REINICIO
            // 
            this.ITENS_CONJUNTOS_REINICIO.ColumnName = "ITENS_CONJUNTOS_REINICIO";
            this.ITENS_CONJUNTOS_REINICIO.DataType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cod.";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsParadas, "PARADAS.COD_PARADA", true));
            this.textBox1.Location = new System.Drawing.Point(124, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(78, 20);
            this.textBox1.TabIndex = 1;
            // 
            // tb_operador
            // 
            this.tb_operador.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsParadas, "PARADAS.OPERADOR", true));
            this.tb_operador.Location = new System.Drawing.Point(124, 55);
            this.tb_operador.Name = "tb_operador";
            this.tb_operador.Size = new System.Drawing.Size(78, 20);
            this.tb_operador.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Operador";
            // 
            // tb_maquina
            // 
            this.tb_maquina.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsParadas, "PARADAS.MAQUINA_PARADA", true));
            this.tb_maquina.Location = new System.Drawing.Point(124, 81);
            this.tb_maquina.Name = "tb_maquina";
            this.tb_maquina.Size = new System.Drawing.Size(78, 20);
            this.tb_maquina.TabIndex = 5;
            this.tb_maquina.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Máquina";
            // 
            // tb_data
            // 
            this.tb_data.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsParadas, "PARADAS.DATA_INICIO", true));
            this.tb_data.Location = new System.Drawing.Point(124, 107);
            this.tb_data.Name = "tb_data";
            this.tb_data.Size = new System.Drawing.Size(78, 20);
            this.tb_data.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data";
            // 
            // tb_hora
            // 
            this.tb_hora.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsParadas, "PARADAS.HORA_INICIO", true));
            this.tb_hora.Location = new System.Drawing.Point(124, 133);
            this.tb_hora.Name = "tb_hora";
            this.tb_hora.Size = new System.Drawing.Size(78, 20);
            this.tb_hora.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Hora";
            // 
            // tb_rota
            // 
            this.tb_rota.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsParadas, "PARADAS.N_ROTAS_CAMPO", true));
            this.tb_rota.Location = new System.Drawing.Point(124, 159);
            this.tb_rota.Name = "tb_rota";
            this.tb_rota.Size = new System.Drawing.Size(78, 20);
            this.tb_rota.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Rota";
            // 
            // cbParadas
            // 
            this.cbParadas.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            this.cbParadas.DataAdapter = this.datParadas;
            this.cbParadas.QuotePrefix = "\"";
            this.cbParadas.QuoteSuffix = "\"";
            // 
            // form_nova_parada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.tb_rota);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_hora);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_data);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_maquina);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_operador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "form_nova_parada";
            this.Text = "Nova Parada";
            this.Load += new System.EventHandler(this.form_nova_parada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsParadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PARADAS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datParadas;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Data.DataSet dsParadas;
        private System.Data.DataTable PARADAS;
        private System.Data.DataColumn COD_PARADA;
        private System.Data.DataColumn TIPO_PARADA;
        private System.Data.DataColumn HORA_INICIO;
        private System.Data.DataColumn DATA_INICIO;
        private System.Data.DataColumn HORA_TERMINO;
        private System.Data.DataColumn DATA_TERMINO;
        private System.Data.DataColumn N_ROTAS_CAMPO;
        private System.Data.DataColumn OBS_PARADA;
        private System.Data.DataColumn PECAS_PRODUZIDAS_PARADA;
        private System.Data.DataColumn OPERADOR;
        private System.Data.DataColumn MAQUINA_PARADA;
        private System.Data.DataColumn PARADA_FINALIZADA;
        private System.Data.DataColumn COD_PARADA_NUM;
        private System.Data.DataColumn OPERADOR_FINALIZADOR_PARADA;
        private System.Data.DataColumn TOTAL_HORAS_PARADA;
        private System.Data.DataColumn ITENS_CONJUNTOS_PARADA;
        private System.Data.DataColumn MAQUINA_REINICIO;
        private System.Data.DataColumn ITENS_CONJUNTOS_REINICIO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tb_operador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_maquina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_data;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_hora;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_rota;
        private System.Windows.Forms.Label label6;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder cbParadas;
    }
}