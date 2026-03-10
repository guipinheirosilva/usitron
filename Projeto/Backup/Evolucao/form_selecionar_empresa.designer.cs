namespace Evolucao
{
    partial class form_selecionar_empresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_selecionar_empresa));
            this.cbEmpresa = new System.Windows.Forms.ComboBox();
            this.dsEmpresa = new System.Data.DataSet();
            this.EMPRESA = new System.Data.DataTable();
            this.COD_EMPRESA = new System.Data.DataColumn();
            this.RAZAO_SOCIAL_EMPRESA = new System.Data.DataColumn();
            this.NOME_FANTASIA_EMPRESA = new System.Data.DataColumn();
            this.CNPJ_EMPRESA = new System.Data.DataColumn();
            this.IE_EMPRESA = new System.Data.DataColumn();
            this.IM_EMPRESA = new System.Data.DataColumn();
            this.ENDERECO_EMPRESA = new System.Data.DataColumn();
            this.N_ENDERECO_EMPRESA = new System.Data.DataColumn();
            this.COMPLEMENTO_EMPRESA = new System.Data.DataColumn();
            this.BAIRRO_EMPRESA = new System.Data.DataColumn();
            this.CIDADE_EMPRESA = new System.Data.DataColumn();
            this.ESTADO_EMPRESA = new System.Data.DataColumn();
            this.CEP_EMPRESA = new System.Data.DataColumn();
            this.TELEFONE_EMPRESA = new System.Data.DataColumn();
            this.COD_CIDADE_EMPRESA = new System.Data.DataColumn();
            this.PAIS_EMPRESA = new System.Data.DataColumn();
            this.COD_PAIS_EMPRESA = new System.Data.DataColumn();
            this.LICENCA_DLL_NFE_EMPRESA = new System.Data.DataColumn();
            this.NOME_CERTIFICADO_NFE_EMPRESA = new System.Data.DataColumn();
            this.ASSUNTO_NFE_EMAIL_EMPRESA = new System.Data.DataColumn();
            this.SMTP_NFE_EMPRESA = new System.Data.DataColumn();
            this.EMAIL_NFE_EMPRESA = new System.Data.DataColumn();
            this.SENHA_EMAIL_NFE_EMPRESA = new System.Data.DataColumn();
            this.LOGOTIPO_EMPRESA = new System.Data.DataColumn();
            this.PROXY_EMPRESA = new System.Data.DataColumn();
            this.USUARIO_PROXY_EMPRESA = new System.Data.DataColumn();
            this.SENHA_PROXY_EMPRESA = new System.Data.DataColumn();
            this.NOME_CONTATO_EMAIL_NFE = new System.Data.DataColumn();
            this.ICMS_EMPRESA = new System.Data.DataColumn();
            this.REDUCAO_EMPRESA = new System.Data.DataColumn();
            this.ICMS_ST_EMPRESA = new System.Data.DataColumn();
            this.IVA_EMPRESA = new System.Data.DataColumn();
            this.IPI_EMPRESA = new System.Data.DataColumn();
            this.PIS_EMPRESA = new System.Data.DataColumn();
            this.COFINS_EMPRESA = new System.Data.DataColumn();
            this.ORIGEM_EMPRESA = new System.Data.DataColumn();
            this.MOD_BC_EMPRESA = new System.Data.DataColumn();
            this.ISS_EMPRESA = new System.Data.DataColumn();
            this.CST_EMPRESA = new System.Data.DataColumn();
            this.CRT_EMPRESA = new System.Data.DataColumn();
            this.ALIQUOTA_CREDITO_EMPRESA = new System.Data.DataColumn();
            this.MOD_BC_ST_EMPRESA = new System.Data.DataColumn();
            this.REDUCAO_ST_EMPRESA = new System.Data.DataColumn();
            this.IPI_TRIB_EMPRESA = new System.Data.DataColumn();
            this.IPI_N_TRIB_EMPRESA = new System.Data.DataColumn();
            this.CST_IPI_TRIB_EMPRESA = new System.Data.DataColumn();
            this.CST_IPI_N_TRIB_EMPRESA = new System.Data.DataColumn();
            this.TIPO_PIS_EMPRESA = new System.Data.DataColumn();
            this.CST_PIS_EMPRESA = new System.Data.DataColumn();
            this.TIPO_COFINS_EMPRESA = new System.Data.DataColumn();
            this.CST_COFINS_EMPRESA = new System.Data.DataColumn();
            this.TIPO_SERVICO_EMPRESA = new System.Data.DataColumn();
            this.BC_COM_IPI_EMPRESA = new System.Data.DataColumn();
            this.CNAE_EMPRESA = new System.Data.DataColumn();
            this.APENAS_LEITOR_EMPRESA = new System.Data.DataColumn();
            this.CONTROLAR_COTAS_EMPRESA = new System.Data.DataColumn();
            this.HORAS_MAXIMAS_EMPRESA = new System.Data.DataColumn();
            this.QTDE_HORAS_MAXIMAS_EMPRESA = new System.Data.DataColumn();
            this.DETALHAMENTO_TT_EMPRESA = new System.Data.DataColumn();
            this.datEmpresa = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dsEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EMPRESA)).BeginInit();
            this.SuspendLayout();
            // 
            // cbEmpresa
            // 
            this.cbEmpresa.DataSource = this.dsEmpresa;
            this.cbEmpresa.DisplayMember = "EMPRESA.RAZAO_SOCIAL_EMPRESA";
            this.cbEmpresa.FormattingEnabled = true;
            this.cbEmpresa.Location = new System.Drawing.Point(12, 2);
            this.cbEmpresa.Name = "cbEmpresa";
            this.cbEmpresa.Size = new System.Drawing.Size(347, 21);
            this.cbEmpresa.TabIndex = 0;
            this.cbEmpresa.ValueMember = "EMPRESA.CNPJ_EMPRESA";
            // 
            // dsEmpresa
            // 
            this.dsEmpresa.DataSetName = "dsEmpresa";
            this.dsEmpresa.Namespace = "http://www.tempuri.org/dsEmpresa.xsd";
            this.dsEmpresa.Tables.AddRange(new System.Data.DataTable[] {
            this.EMPRESA});
            // 
            // EMPRESA
            // 
            this.EMPRESA.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_EMPRESA,
            this.RAZAO_SOCIAL_EMPRESA,
            this.NOME_FANTASIA_EMPRESA,
            this.CNPJ_EMPRESA,
            this.IE_EMPRESA,
            this.IM_EMPRESA,
            this.ENDERECO_EMPRESA,
            this.N_ENDERECO_EMPRESA,
            this.COMPLEMENTO_EMPRESA,
            this.BAIRRO_EMPRESA,
            this.CIDADE_EMPRESA,
            this.ESTADO_EMPRESA,
            this.CEP_EMPRESA,
            this.TELEFONE_EMPRESA,
            this.COD_CIDADE_EMPRESA,
            this.PAIS_EMPRESA,
            this.COD_PAIS_EMPRESA,
            this.LICENCA_DLL_NFE_EMPRESA,
            this.NOME_CERTIFICADO_NFE_EMPRESA,
            this.ASSUNTO_NFE_EMAIL_EMPRESA,
            this.SMTP_NFE_EMPRESA,
            this.EMAIL_NFE_EMPRESA,
            this.SENHA_EMAIL_NFE_EMPRESA,
            this.LOGOTIPO_EMPRESA,
            this.PROXY_EMPRESA,
            this.USUARIO_PROXY_EMPRESA,
            this.SENHA_PROXY_EMPRESA,
            this.NOME_CONTATO_EMAIL_NFE,
            this.ICMS_EMPRESA,
            this.REDUCAO_EMPRESA,
            this.ICMS_ST_EMPRESA,
            this.IVA_EMPRESA,
            this.IPI_EMPRESA,
            this.PIS_EMPRESA,
            this.COFINS_EMPRESA,
            this.ORIGEM_EMPRESA,
            this.MOD_BC_EMPRESA,
            this.ISS_EMPRESA,
            this.CST_EMPRESA,
            this.CRT_EMPRESA,
            this.ALIQUOTA_CREDITO_EMPRESA,
            this.MOD_BC_ST_EMPRESA,
            this.REDUCAO_ST_EMPRESA,
            this.IPI_TRIB_EMPRESA,
            this.IPI_N_TRIB_EMPRESA,
            this.CST_IPI_TRIB_EMPRESA,
            this.CST_IPI_N_TRIB_EMPRESA,
            this.TIPO_PIS_EMPRESA,
            this.CST_PIS_EMPRESA,
            this.TIPO_COFINS_EMPRESA,
            this.CST_COFINS_EMPRESA,
            this.TIPO_SERVICO_EMPRESA,
            this.BC_COM_IPI_EMPRESA,
            this.CNAE_EMPRESA,
            this.APENAS_LEITOR_EMPRESA,
            this.CONTROLAR_COTAS_EMPRESA,
            this.HORAS_MAXIMAS_EMPRESA,
            this.QTDE_HORAS_MAXIMAS_EMPRESA,
            this.DETALHAMENTO_TT_EMPRESA});
            this.EMPRESA.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_EMPRESA"}, true)});
            this.EMPRESA.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_EMPRESA};
            this.EMPRESA.TableName = "EMPRESA";
            // 
            // COD_EMPRESA
            // 
            this.COD_EMPRESA.AllowDBNull = false;
            this.COD_EMPRESA.ColumnName = "COD_EMPRESA";
            this.COD_EMPRESA.DataType = typeof(int);
            // 
            // RAZAO_SOCIAL_EMPRESA
            // 
            this.RAZAO_SOCIAL_EMPRESA.ColumnName = "RAZAO_SOCIAL_EMPRESA";
            this.RAZAO_SOCIAL_EMPRESA.MaxLength = 200;
            // 
            // NOME_FANTASIA_EMPRESA
            // 
            this.NOME_FANTASIA_EMPRESA.ColumnName = "NOME_FANTASIA_EMPRESA";
            this.NOME_FANTASIA_EMPRESA.MaxLength = 200;
            // 
            // CNPJ_EMPRESA
            // 
            this.CNPJ_EMPRESA.ColumnName = "CNPJ_EMPRESA";
            this.CNPJ_EMPRESA.MaxLength = 30;
            // 
            // IE_EMPRESA
            // 
            this.IE_EMPRESA.ColumnName = "IE_EMPRESA";
            this.IE_EMPRESA.MaxLength = 30;
            // 
            // IM_EMPRESA
            // 
            this.IM_EMPRESA.ColumnName = "IM_EMPRESA";
            this.IM_EMPRESA.MaxLength = 30;
            // 
            // ENDERECO_EMPRESA
            // 
            this.ENDERECO_EMPRESA.ColumnName = "ENDERECO_EMPRESA";
            this.ENDERECO_EMPRESA.MaxLength = 200;
            // 
            // N_ENDERECO_EMPRESA
            // 
            this.N_ENDERECO_EMPRESA.ColumnName = "N_ENDERECO_EMPRESA";
            this.N_ENDERECO_EMPRESA.MaxLength = 20;
            // 
            // COMPLEMENTO_EMPRESA
            // 
            this.COMPLEMENTO_EMPRESA.ColumnName = "COMPLEMENTO_EMPRESA";
            this.COMPLEMENTO_EMPRESA.MaxLength = 50;
            // 
            // BAIRRO_EMPRESA
            // 
            this.BAIRRO_EMPRESA.ColumnName = "BAIRRO_EMPRESA";
            this.BAIRRO_EMPRESA.MaxLength = 50;
            // 
            // CIDADE_EMPRESA
            // 
            this.CIDADE_EMPRESA.ColumnName = "CIDADE_EMPRESA";
            this.CIDADE_EMPRESA.MaxLength = 50;
            // 
            // ESTADO_EMPRESA
            // 
            this.ESTADO_EMPRESA.ColumnName = "ESTADO_EMPRESA";
            this.ESTADO_EMPRESA.MaxLength = 2;
            // 
            // CEP_EMPRESA
            // 
            this.CEP_EMPRESA.ColumnName = "CEP_EMPRESA";
            this.CEP_EMPRESA.MaxLength = 10;
            // 
            // TELEFONE_EMPRESA
            // 
            this.TELEFONE_EMPRESA.ColumnName = "TELEFONE_EMPRESA";
            this.TELEFONE_EMPRESA.MaxLength = 50;
            // 
            // COD_CIDADE_EMPRESA
            // 
            this.COD_CIDADE_EMPRESA.ColumnName = "COD_CIDADE_EMPRESA";
            this.COD_CIDADE_EMPRESA.MaxLength = 7;
            // 
            // PAIS_EMPRESA
            // 
            this.PAIS_EMPRESA.ColumnName = "PAIS_EMPRESA";
            this.PAIS_EMPRESA.MaxLength = 50;
            // 
            // COD_PAIS_EMPRESA
            // 
            this.COD_PAIS_EMPRESA.ColumnName = "COD_PAIS_EMPRESA";
            this.COD_PAIS_EMPRESA.MaxLength = 20;
            // 
            // LICENCA_DLL_NFE_EMPRESA
            // 
            this.LICENCA_DLL_NFE_EMPRESA.ColumnName = "LICENCA_DLL_NFE_EMPRESA";
            this.LICENCA_DLL_NFE_EMPRESA.MaxLength = 200;
            // 
            // NOME_CERTIFICADO_NFE_EMPRESA
            // 
            this.NOME_CERTIFICADO_NFE_EMPRESA.ColumnName = "NOME_CERTIFICADO_NFE_EMPRESA";
            this.NOME_CERTIFICADO_NFE_EMPRESA.MaxLength = 300;
            // 
            // ASSUNTO_NFE_EMAIL_EMPRESA
            // 
            this.ASSUNTO_NFE_EMAIL_EMPRESA.ColumnName = "ASSUNTO_NFE_EMAIL_EMPRESA";
            this.ASSUNTO_NFE_EMAIL_EMPRESA.MaxLength = 200;
            // 
            // SMTP_NFE_EMPRESA
            // 
            this.SMTP_NFE_EMPRESA.ColumnName = "SMTP_NFE_EMPRESA";
            this.SMTP_NFE_EMPRESA.MaxLength = 50;
            // 
            // EMAIL_NFE_EMPRESA
            // 
            this.EMAIL_NFE_EMPRESA.ColumnName = "EMAIL_NFE_EMPRESA";
            this.EMAIL_NFE_EMPRESA.MaxLength = 50;
            // 
            // SENHA_EMAIL_NFE_EMPRESA
            // 
            this.SENHA_EMAIL_NFE_EMPRESA.ColumnName = "SENHA_EMAIL_NFE_EMPRESA";
            this.SENHA_EMAIL_NFE_EMPRESA.MaxLength = 50;
            // 
            // LOGOTIPO_EMPRESA
            // 
            this.LOGOTIPO_EMPRESA.ColumnName = "LOGOTIPO_EMPRESA";
            this.LOGOTIPO_EMPRESA.DataType = typeof(byte[]);
            // 
            // PROXY_EMPRESA
            // 
            this.PROXY_EMPRESA.ColumnName = "PROXY_EMPRESA";
            this.PROXY_EMPRESA.MaxLength = 20;
            // 
            // USUARIO_PROXY_EMPRESA
            // 
            this.USUARIO_PROXY_EMPRESA.ColumnName = "USUARIO_PROXY_EMPRESA";
            this.USUARIO_PROXY_EMPRESA.MaxLength = 50;
            // 
            // SENHA_PROXY_EMPRESA
            // 
            this.SENHA_PROXY_EMPRESA.ColumnName = "SENHA_PROXY_EMPRESA";
            this.SENHA_PROXY_EMPRESA.MaxLength = 50;
            // 
            // NOME_CONTATO_EMAIL_NFE
            // 
            this.NOME_CONTATO_EMAIL_NFE.ColumnName = "NOME_CONTATO_EMAIL_NFE";
            this.NOME_CONTATO_EMAIL_NFE.MaxLength = 200;
            // 
            // ICMS_EMPRESA
            // 
            this.ICMS_EMPRESA.ColumnName = "ICMS_EMPRESA";
            this.ICMS_EMPRESA.DataType = typeof(double);
            // 
            // REDUCAO_EMPRESA
            // 
            this.REDUCAO_EMPRESA.ColumnName = "REDUCAO_EMPRESA";
            this.REDUCAO_EMPRESA.DataType = typeof(double);
            // 
            // ICMS_ST_EMPRESA
            // 
            this.ICMS_ST_EMPRESA.ColumnName = "ICMS_ST_EMPRESA";
            this.ICMS_ST_EMPRESA.DataType = typeof(double);
            // 
            // IVA_EMPRESA
            // 
            this.IVA_EMPRESA.ColumnName = "IVA_EMPRESA";
            this.IVA_EMPRESA.DataType = typeof(double);
            // 
            // IPI_EMPRESA
            // 
            this.IPI_EMPRESA.ColumnName = "IPI_EMPRESA";
            this.IPI_EMPRESA.DataType = typeof(double);
            // 
            // PIS_EMPRESA
            // 
            this.PIS_EMPRESA.ColumnName = "PIS_EMPRESA";
            this.PIS_EMPRESA.DataType = typeof(double);
            // 
            // COFINS_EMPRESA
            // 
            this.COFINS_EMPRESA.ColumnName = "COFINS_EMPRESA";
            this.COFINS_EMPRESA.DataType = typeof(double);
            // 
            // ORIGEM_EMPRESA
            // 
            this.ORIGEM_EMPRESA.ColumnName = "ORIGEM_EMPRESA";
            this.ORIGEM_EMPRESA.MaxLength = 100;
            // 
            // MOD_BC_EMPRESA
            // 
            this.MOD_BC_EMPRESA.ColumnName = "MOD_BC_EMPRESA";
            this.MOD_BC_EMPRESA.MaxLength = 100;
            // 
            // ISS_EMPRESA
            // 
            this.ISS_EMPRESA.ColumnName = "ISS_EMPRESA";
            this.ISS_EMPRESA.DataType = typeof(double);
            // 
            // CST_EMPRESA
            // 
            this.CST_EMPRESA.ColumnName = "CST_EMPRESA";
            this.CST_EMPRESA.MaxLength = 3;
            // 
            // CRT_EMPRESA
            // 
            this.CRT_EMPRESA.ColumnName = "CRT_EMPRESA";
            this.CRT_EMPRESA.MaxLength = 1;
            // 
            // ALIQUOTA_CREDITO_EMPRESA
            // 
            this.ALIQUOTA_CREDITO_EMPRESA.ColumnName = "ALIQUOTA_CREDITO_EMPRESA";
            this.ALIQUOTA_CREDITO_EMPRESA.DataType = typeof(double);
            // 
            // MOD_BC_ST_EMPRESA
            // 
            this.MOD_BC_ST_EMPRESA.ColumnName = "MOD_BC_ST_EMPRESA";
            this.MOD_BC_ST_EMPRESA.MaxLength = 100;
            // 
            // REDUCAO_ST_EMPRESA
            // 
            this.REDUCAO_ST_EMPRESA.ColumnName = "REDUCAO_ST_EMPRESA";
            this.REDUCAO_ST_EMPRESA.DataType = typeof(double);
            // 
            // IPI_TRIB_EMPRESA
            // 
            this.IPI_TRIB_EMPRESA.ColumnName = "IPI_TRIB_EMPRESA";
            this.IPI_TRIB_EMPRESA.DataType = typeof(int);
            // 
            // IPI_N_TRIB_EMPRESA
            // 
            this.IPI_N_TRIB_EMPRESA.ColumnName = "IPI_N_TRIB_EMPRESA";
            this.IPI_N_TRIB_EMPRESA.DataType = typeof(int);
            // 
            // CST_IPI_TRIB_EMPRESA
            // 
            this.CST_IPI_TRIB_EMPRESA.ColumnName = "CST_IPI_TRIB_EMPRESA";
            this.CST_IPI_TRIB_EMPRESA.MaxLength = 100;
            // 
            // CST_IPI_N_TRIB_EMPRESA
            // 
            this.CST_IPI_N_TRIB_EMPRESA.ColumnName = "CST_IPI_N_TRIB_EMPRESA";
            this.CST_IPI_N_TRIB_EMPRESA.MaxLength = 100;
            // 
            // TIPO_PIS_EMPRESA
            // 
            this.TIPO_PIS_EMPRESA.ColumnName = "TIPO_PIS_EMPRESA";
            this.TIPO_PIS_EMPRESA.MaxLength = 100;
            // 
            // CST_PIS_EMPRESA
            // 
            this.CST_PIS_EMPRESA.ColumnName = "CST_PIS_EMPRESA";
            this.CST_PIS_EMPRESA.MaxLength = 200;
            // 
            // TIPO_COFINS_EMPRESA
            // 
            this.TIPO_COFINS_EMPRESA.ColumnName = "TIPO_COFINS_EMPRESA";
            this.TIPO_COFINS_EMPRESA.MaxLength = 100;
            // 
            // CST_COFINS_EMPRESA
            // 
            this.CST_COFINS_EMPRESA.ColumnName = "CST_COFINS_EMPRESA";
            this.CST_COFINS_EMPRESA.MaxLength = 200;
            // 
            // TIPO_SERVICO_EMPRESA
            // 
            this.TIPO_SERVICO_EMPRESA.ColumnName = "TIPO_SERVICO_EMPRESA";
            this.TIPO_SERVICO_EMPRESA.MaxLength = 100;
            // 
            // BC_COM_IPI_EMPRESA
            // 
            this.BC_COM_IPI_EMPRESA.ColumnName = "BC_COM_IPI_EMPRESA";
            this.BC_COM_IPI_EMPRESA.DataType = typeof(int);
            // 
            // CNAE_EMPRESA
            // 
            this.CNAE_EMPRESA.ColumnName = "CNAE_EMPRESA";
            this.CNAE_EMPRESA.MaxLength = 20;
            // 
            // APENAS_LEITOR_EMPRESA
            // 
            this.APENAS_LEITOR_EMPRESA.ColumnName = "APENAS_LEITOR_EMPRESA";
            this.APENAS_LEITOR_EMPRESA.DataType = typeof(int);
            // 
            // CONTROLAR_COTAS_EMPRESA
            // 
            this.CONTROLAR_COTAS_EMPRESA.ColumnName = "CONTROLAR_COTAS_EMPRESA";
            this.CONTROLAR_COTAS_EMPRESA.DataType = typeof(int);
            // 
            // HORAS_MAXIMAS_EMPRESA
            // 
            this.HORAS_MAXIMAS_EMPRESA.ColumnName = "HORAS_MAXIMAS_EMPRESA";
            this.HORAS_MAXIMAS_EMPRESA.DataType = typeof(int);
            // 
            // QTDE_HORAS_MAXIMAS_EMPRESA
            // 
            this.QTDE_HORAS_MAXIMAS_EMPRESA.ColumnName = "QTDE_HORAS_MAXIMAS_EMPRESA";
            this.QTDE_HORAS_MAXIMAS_EMPRESA.DataType = typeof(int);
            // 
            // DETALHAMENTO_TT_EMPRESA
            // 
            this.DETALHAMENTO_TT_EMPRESA.ColumnName = "DETALHAMENTO_TT_EMPRESA";
            this.DETALHAMENTO_TT_EMPRESA.DataType = typeof(int);
            // 
            // datEmpresa
            // 
            this.datEmpresa.DeleteCommand = this.fbCommand4;
            this.datEmpresa.InsertCommand = this.fbCommand2;
            this.datEmpresa.SelectCommand = this.fbCommand1;
            this.datEmpresa.UpdateCommand = this.fbCommand3;
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
            this.fbCommand1.CommandText = "select * from empresa";
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(150, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // form_selecionar_empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 56);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbEmpresa);
            this.Name = "form_selecionar_empresa";
            this.Text = "Selecionar Empresa";
            this.Load += new System.EventHandler(this.form_selecionar_empresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EMPRESA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbEmpresa;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datEmpresa;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Data.DataSet dsEmpresa;
        private System.Data.DataTable EMPRESA;
        private System.Data.DataColumn COD_EMPRESA;
        private System.Data.DataColumn RAZAO_SOCIAL_EMPRESA;
        private System.Data.DataColumn NOME_FANTASIA_EMPRESA;
        private System.Data.DataColumn CNPJ_EMPRESA;
        private System.Data.DataColumn IE_EMPRESA;
        private System.Data.DataColumn IM_EMPRESA;
        private System.Data.DataColumn ENDERECO_EMPRESA;
        private System.Data.DataColumn N_ENDERECO_EMPRESA;
        private System.Data.DataColumn COMPLEMENTO_EMPRESA;
        private System.Data.DataColumn BAIRRO_EMPRESA;
        private System.Data.DataColumn CIDADE_EMPRESA;
        private System.Data.DataColumn ESTADO_EMPRESA;
        private System.Data.DataColumn CEP_EMPRESA;
        private System.Data.DataColumn TELEFONE_EMPRESA;
        private System.Data.DataColumn COD_CIDADE_EMPRESA;
        private System.Data.DataColumn PAIS_EMPRESA;
        private System.Data.DataColumn COD_PAIS_EMPRESA;
        private System.Data.DataColumn LICENCA_DLL_NFE_EMPRESA;
        private System.Data.DataColumn NOME_CERTIFICADO_NFE_EMPRESA;
        private System.Data.DataColumn ASSUNTO_NFE_EMAIL_EMPRESA;
        private System.Data.DataColumn SMTP_NFE_EMPRESA;
        private System.Data.DataColumn EMAIL_NFE_EMPRESA;
        private System.Data.DataColumn SENHA_EMAIL_NFE_EMPRESA;
        private System.Data.DataColumn LOGOTIPO_EMPRESA;
        private System.Data.DataColumn PROXY_EMPRESA;
        private System.Data.DataColumn USUARIO_PROXY_EMPRESA;
        private System.Data.DataColumn SENHA_PROXY_EMPRESA;
        private System.Data.DataColumn NOME_CONTATO_EMAIL_NFE;
        private System.Data.DataColumn ICMS_EMPRESA;
        private System.Data.DataColumn REDUCAO_EMPRESA;
        private System.Data.DataColumn ICMS_ST_EMPRESA;
        private System.Data.DataColumn IVA_EMPRESA;
        private System.Data.DataColumn IPI_EMPRESA;
        private System.Data.DataColumn PIS_EMPRESA;
        private System.Data.DataColumn COFINS_EMPRESA;
        private System.Data.DataColumn ORIGEM_EMPRESA;
        private System.Data.DataColumn MOD_BC_EMPRESA;
        private System.Data.DataColumn ISS_EMPRESA;
        private System.Data.DataColumn CST_EMPRESA;
        private System.Data.DataColumn CRT_EMPRESA;
        private System.Data.DataColumn ALIQUOTA_CREDITO_EMPRESA;
        private System.Data.DataColumn MOD_BC_ST_EMPRESA;
        private System.Data.DataColumn REDUCAO_ST_EMPRESA;
        private System.Data.DataColumn IPI_TRIB_EMPRESA;
        private System.Data.DataColumn IPI_N_TRIB_EMPRESA;
        private System.Data.DataColumn CST_IPI_TRIB_EMPRESA;
        private System.Data.DataColumn CST_IPI_N_TRIB_EMPRESA;
        private System.Data.DataColumn TIPO_PIS_EMPRESA;
        private System.Data.DataColumn CST_PIS_EMPRESA;
        private System.Data.DataColumn TIPO_COFINS_EMPRESA;
        private System.Data.DataColumn CST_COFINS_EMPRESA;
        private System.Data.DataColumn TIPO_SERVICO_EMPRESA;
        private System.Data.DataColumn BC_COM_IPI_EMPRESA;
        private System.Data.DataColumn CNAE_EMPRESA;
        private System.Data.DataColumn APENAS_LEITOR_EMPRESA;
        private System.Data.DataColumn CONTROLAR_COTAS_EMPRESA;
        private System.Data.DataColumn HORAS_MAXIMAS_EMPRESA;
        private System.Data.DataColumn QTDE_HORAS_MAXIMAS_EMPRESA;
        private System.Data.DataColumn DETALHAMENTO_TT_EMPRESA;
        private System.Windows.Forms.Button button1;
    }
}