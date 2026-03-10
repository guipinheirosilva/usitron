namespace Evolucao
{
    partial class form_isencao_icm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_isencao_icm));
            this.bt_confirmar = new System.Windows.Forms.Button();
            this.label_cliente = new System.Windows.Forms.Label();
            this.dsClientes = new System.Data.DataSet();
            this.CLIENTES = new System.Data.DataTable();
            this.COD_CLIENTE = new System.Data.DataColumn();
            this.RAZAO_SOCIAL = new System.Data.DataColumn();
            this.NOME_FANTASIA = new System.Data.DataColumn();
            this.IE = new System.Data.DataColumn();
            this.CNPJ = new System.Data.DataColumn();
            this.IM = new System.Data.DataColumn();
            this.ENDERECO = new System.Data.DataColumn();
            this.BAIRRO = new System.Data.DataColumn();
            this.CIDADE = new System.Data.DataColumn();
            this.ESTADO = new System.Data.DataColumn();
            this.PAIS = new System.Data.DataColumn();
            this.CEP_CLIENTE = new System.Data.DataColumn();
            this.FONE = new System.Data.DataColumn();
            this.EMAIL = new System.Data.DataColumn();
            this.CONTATO1 = new System.Data.DataColumn();
            this.FONE1 = new System.Data.DataColumn();
            this.EMAIL1 = new System.Data.DataColumn();
            this.CONTATO2 = new System.Data.DataColumn();
            this.FONE2 = new System.Data.DataColumn();
            this.EMAIL2 = new System.Data.DataColumn();
            this.SITUACAO = new System.Data.DataColumn();
            this.TIPO = new System.Data.DataColumn();
            this.TRANSPORTADORA_CLIENTE = new System.Data.DataColumn();
            this.ATIVIDADE_CLIENTE = new System.Data.DataColumn();
            this.BANCO_CLIENTE = new System.Data.DataColumn();
            this.AGENCIA_CLIENTE = new System.Data.DataColumn();
            this.REGIAO = new System.Data.DataColumn();
            this.VENDEDOR_CLIENTE = new System.Data.DataColumn();
            this.DATA_CADASTRO_CLIENTE = new System.Data.DataColumn();
            this.ETIQUETA = new System.Data.DataColumn();
            this.CLASS_FISCAL_CLIENTE = new System.Data.DataColumn();
            this.ISENCAO_ICM_CLIENTE = new System.Data.DataColumn();
            this.ISENCAO_IPI_CLIENTE = new System.Data.DataColumn();
            this.tb_isencao = new System.Windows.Forms.TextBox();
            this.datClientes = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            ((System.ComponentModel.ISupportInitialize)(this.dsClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CLIENTES)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_confirmar
            // 
            this.bt_confirmar.Location = new System.Drawing.Point(170, 169);
            this.bt_confirmar.Name = "bt_confirmar";
            this.bt_confirmar.Size = new System.Drawing.Size(75, 23);
            this.bt_confirmar.TabIndex = 5;
            this.bt_confirmar.Text = "Confirmar";
            this.bt_confirmar.UseVisualStyleBackColor = true;
            this.bt_confirmar.Click += new System.EventHandler(this.bt_confirmar_Click);
            // 
            // label_cliente
            // 
            this.label_cliente.AutoSize = true;
            this.label_cliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.RAZAO_SOCIAL", true));
            this.label_cliente.Location = new System.Drawing.Point(15, 17);
            this.label_cliente.Name = "label_cliente";
            this.label_cliente.Size = new System.Drawing.Size(39, 13);
            this.label_cliente.TabIndex = 4;
            this.label_cliente.Text = "Cliente";
            // 
            // dsClientes
            // 
            this.dsClientes.DataSetName = "dsClientes";
            this.dsClientes.Namespace = "http://www.tempuri.org/dsClientes.xsd";
            this.dsClientes.Tables.AddRange(new System.Data.DataTable[] {
            this.CLIENTES});
            // 
            // CLIENTES
            // 
            this.CLIENTES.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_CLIENTE,
            this.RAZAO_SOCIAL,
            this.NOME_FANTASIA,
            this.IE,
            this.CNPJ,
            this.IM,
            this.ENDERECO,
            this.BAIRRO,
            this.CIDADE,
            this.ESTADO,
            this.PAIS,
            this.CEP_CLIENTE,
            this.FONE,
            this.EMAIL,
            this.CONTATO1,
            this.FONE1,
            this.EMAIL1,
            this.CONTATO2,
            this.FONE2,
            this.EMAIL2,
            this.SITUACAO,
            this.TIPO,
            this.TRANSPORTADORA_CLIENTE,
            this.ATIVIDADE_CLIENTE,
            this.BANCO_CLIENTE,
            this.AGENCIA_CLIENTE,
            this.REGIAO,
            this.VENDEDOR_CLIENTE,
            this.DATA_CADASTRO_CLIENTE,
            this.ETIQUETA,
            this.CLASS_FISCAL_CLIENTE,
            this.ISENCAO_ICM_CLIENTE,
            this.ISENCAO_IPI_CLIENTE});
            this.CLIENTES.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "RAZAO_SOCIAL"}, true)});
            this.CLIENTES.PrimaryKey = new System.Data.DataColumn[] {
        this.RAZAO_SOCIAL};
            this.CLIENTES.TableName = "CLIENTES";
            // 
            // COD_CLIENTE
            // 
            this.COD_CLIENTE.ColumnName = "COD_CLIENTE";
            this.COD_CLIENTE.DataType = typeof(int);
            // 
            // RAZAO_SOCIAL
            // 
            this.RAZAO_SOCIAL.AllowDBNull = false;
            this.RAZAO_SOCIAL.ColumnName = "RAZAO_SOCIAL";
            this.RAZAO_SOCIAL.MaxLength = 50;
            // 
            // NOME_FANTASIA
            // 
            this.NOME_FANTASIA.ColumnName = "NOME_FANTASIA";
            this.NOME_FANTASIA.MaxLength = 50;
            // 
            // IE
            // 
            this.IE.ColumnName = "IE";
            this.IE.MaxLength = 20;
            // 
            // CNPJ
            // 
            this.CNPJ.ColumnName = "CNPJ";
            this.CNPJ.MaxLength = 30;
            // 
            // IM
            // 
            this.IM.ColumnName = "IM";
            this.IM.MaxLength = 20;
            // 
            // ENDERECO
            // 
            this.ENDERECO.ColumnName = "ENDERECO";
            this.ENDERECO.MaxLength = 50;
            // 
            // BAIRRO
            // 
            this.BAIRRO.ColumnName = "BAIRRO";
            this.BAIRRO.MaxLength = 30;
            // 
            // CIDADE
            // 
            this.CIDADE.ColumnName = "CIDADE";
            this.CIDADE.MaxLength = 35;
            // 
            // ESTADO
            // 
            this.ESTADO.ColumnName = "ESTADO";
            this.ESTADO.MaxLength = 2;
            // 
            // PAIS
            // 
            this.PAIS.ColumnName = "PAIS";
            this.PAIS.MaxLength = 20;
            // 
            // CEP_CLIENTE
            // 
            this.CEP_CLIENTE.ColumnName = "CEP_CLIENTE";
            this.CEP_CLIENTE.MaxLength = 18;
            // 
            // FONE
            // 
            this.FONE.ColumnName = "FONE";
            this.FONE.MaxLength = 14;
            // 
            // EMAIL
            // 
            this.EMAIL.ColumnName = "EMAIL";
            this.EMAIL.MaxLength = 30;
            // 
            // CONTATO1
            // 
            this.CONTATO1.ColumnName = "CONTATO1";
            this.CONTATO1.MaxLength = 40;
            // 
            // FONE1
            // 
            this.FONE1.ColumnName = "FONE1";
            this.FONE1.MaxLength = 14;
            // 
            // EMAIL1
            // 
            this.EMAIL1.ColumnName = "EMAIL1";
            this.EMAIL1.MaxLength = 30;
            // 
            // CONTATO2
            // 
            this.CONTATO2.ColumnName = "CONTATO2";
            this.CONTATO2.MaxLength = 40;
            // 
            // FONE2
            // 
            this.FONE2.ColumnName = "FONE2";
            this.FONE2.MaxLength = 14;
            // 
            // EMAIL2
            // 
            this.EMAIL2.ColumnName = "EMAIL2";
            this.EMAIL2.MaxLength = 30;
            // 
            // SITUACAO
            // 
            this.SITUACAO.ColumnName = "SITUACAO";
            this.SITUACAO.MaxLength = 40;
            // 
            // TIPO
            // 
            this.TIPO.ColumnName = "TIPO";
            this.TIPO.MaxLength = 40;
            // 
            // TRANSPORTADORA_CLIENTE
            // 
            this.TRANSPORTADORA_CLIENTE.ColumnName = "TRANSPORTADORA_CLIENTE";
            this.TRANSPORTADORA_CLIENTE.MaxLength = 80;
            // 
            // ATIVIDADE_CLIENTE
            // 
            this.ATIVIDADE_CLIENTE.ColumnName = "ATIVIDADE_CLIENTE";
            this.ATIVIDADE_CLIENTE.MaxLength = 50;
            // 
            // BANCO_CLIENTE
            // 
            this.BANCO_CLIENTE.ColumnName = "BANCO_CLIENTE";
            this.BANCO_CLIENTE.MaxLength = 10;
            // 
            // AGENCIA_CLIENTE
            // 
            this.AGENCIA_CLIENTE.ColumnName = "AGENCIA_CLIENTE";
            this.AGENCIA_CLIENTE.MaxLength = 10;
            // 
            // REGIAO
            // 
            this.REGIAO.ColumnName = "REGIAO";
            this.REGIAO.MaxLength = 20;
            // 
            // VENDEDOR_CLIENTE
            // 
            this.VENDEDOR_CLIENTE.ColumnName = "VENDEDOR_CLIENTE";
            this.VENDEDOR_CLIENTE.MaxLength = 40;
            // 
            // DATA_CADASTRO_CLIENTE
            // 
            this.DATA_CADASTRO_CLIENTE.ColumnName = "DATA_CADASTRO_CLIENTE";
            this.DATA_CADASTRO_CLIENTE.DataType = typeof(System.DateTime);
            // 
            // ETIQUETA
            // 
            this.ETIQUETA.ColumnName = "ETIQUETA";
            this.ETIQUETA.MaxLength = 10;
            // 
            // CLASS_FISCAL_CLIENTE
            // 
            this.CLASS_FISCAL_CLIENTE.ColumnName = "CLASS_FISCAL_CLIENTE";
            this.CLASS_FISCAL_CLIENTE.MaxLength = 50;
            // 
            // ISENCAO_ICM_CLIENTE
            // 
            this.ISENCAO_ICM_CLIENTE.ColumnName = "ISENCAO_ICM_CLIENTE";
            this.ISENCAO_ICM_CLIENTE.MaxLength = 250;
            // 
            // ISENCAO_IPI_CLIENTE
            // 
            this.ISENCAO_IPI_CLIENTE.ColumnName = "ISENCAO_IPI_CLIENTE";
            this.ISENCAO_IPI_CLIENTE.MaxLength = 250;
            // 
            // tb_isencao
            // 
            this.tb_isencao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsClientes, "CLIENTES.ISENCAO_ICM_CLIENTE", true));
            this.tb_isencao.Location = new System.Drawing.Point(18, 43);
            this.tb_isencao.Multiline = true;
            this.tb_isencao.Name = "tb_isencao";
            this.tb_isencao.Size = new System.Drawing.Size(372, 112);
            this.tb_isencao.TabIndex = 3;
            // 
            // datClientes
            // 
            this.datClientes.DeleteCommand = this.fbCommand4;
            this.datClientes.InsertCommand = this.fbCommand2;
            this.datClientes.SelectCommand = this.fbCommand1;
            this.datClientes.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * from clientes";
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
            // form_isencao_icm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 205);
            this.Controls.Add(this.bt_confirmar);
            this.Controls.Add(this.label_cliente);
            this.Controls.Add(this.tb_isencao);
            this.Name = "form_isencao_icm";
            this.Text = "Isençao ICM";
            this.Load += new System.EventHandler(this.form_isencao_icm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CLIENTES)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_confirmar;
        private System.Windows.Forms.Label label_cliente;
        private System.Windows.Forms.TextBox tb_isencao;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datClientes;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Data.DataSet dsClientes;
        private System.Data.DataTable CLIENTES;
        private System.Data.DataColumn COD_CLIENTE;
        private System.Data.DataColumn RAZAO_SOCIAL;
        private System.Data.DataColumn NOME_FANTASIA;
        private System.Data.DataColumn IE;
        private System.Data.DataColumn CNPJ;
        private System.Data.DataColumn IM;
        private System.Data.DataColumn ENDERECO;
        private System.Data.DataColumn BAIRRO;
        private System.Data.DataColumn CIDADE;
        private System.Data.DataColumn ESTADO;
        private System.Data.DataColumn PAIS;
        private System.Data.DataColumn CEP_CLIENTE;
        private System.Data.DataColumn FONE;
        private System.Data.DataColumn EMAIL;
        private System.Data.DataColumn CONTATO1;
        private System.Data.DataColumn FONE1;
        private System.Data.DataColumn EMAIL1;
        private System.Data.DataColumn CONTATO2;
        private System.Data.DataColumn FONE2;
        private System.Data.DataColumn EMAIL2;
        private System.Data.DataColumn SITUACAO;
        private System.Data.DataColumn TIPO;
        private System.Data.DataColumn TRANSPORTADORA_CLIENTE;
        private System.Data.DataColumn ATIVIDADE_CLIENTE;
        private System.Data.DataColumn BANCO_CLIENTE;
        private System.Data.DataColumn AGENCIA_CLIENTE;
        private System.Data.DataColumn REGIAO;
        private System.Data.DataColumn VENDEDOR_CLIENTE;
        private System.Data.DataColumn DATA_CADASTRO_CLIENTE;
        private System.Data.DataColumn ETIQUETA;
        private System.Data.DataColumn CLASS_FISCAL_CLIENTE;
        private System.Data.DataColumn ISENCAO_ICM_CLIENTE;
        private System.Data.DataColumn ISENCAO_IPI_CLIENTE;
    }
}