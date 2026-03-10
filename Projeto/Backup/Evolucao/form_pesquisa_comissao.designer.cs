namespace Evolucao
{
    partial class form_pesquisa_comissao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_pesquisa_comissao));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtFinal = new System.Windows.Forms.DateTimePicker();
            this.dtInicial = new System.Windows.Forms.DateTimePicker();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.tb_valor_total = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.comando_select = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cb_vendedor = new System.Windows.Forms.CheckBox();
            this.tb_nome_vendedor = new System.Windows.Forms.TextBox();
            this.tb_cod_vendedor = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_cliente = new System.Windows.Forms.CheckBox();
            this.tb_nome_cliente = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.fbCommand8 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand6 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand5 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand7 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand9 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand10 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand11 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand12 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand13 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand14 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand15 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand16 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.datPedidos_venda = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand20 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand18 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand17 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand19 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsPedidos_venda = new System.Data.DataSet();
            this.PEDIDOS_VENDA = new System.Data.DataTable();
            this.COD_PED_VENDA = new System.Data.DataColumn();
            this.DATA_PED_VENDA = new System.Data.DataColumn();
            this.DATA_BAIXA_PED_VENDA = new System.Data.DataColumn();
            this.CLIENTE_PED_VENDA = new System.Data.DataColumn();
            this.CNPJ_PED_VENDA = new System.Data.DataColumn();
            this.COND_PGTO_PED_VENDA = new System.Data.DataColumn();
            this.VALOR_TOTAL_PROD_PED_VENDA = new System.Data.DataColumn();
            this.VALOR_TOTAL_PED_VENDA = new System.Data.DataColumn();
            this.VALOR_TOTAL_ICMS_PED_VENDA = new System.Data.DataColumn();
            this.VALOR_TOTAL_IPI_PED_VENDA = new System.Data.DataColumn();
            this.VALOR_DESCONTO_PED_VENDA = new System.Data.DataColumn();
            this.OBS_PED_VENDA = new System.Data.DataColumn();
            this.NF_PED_VENDA = new System.Data.DataColumn();
            this.BAIXADO_ESTOQUE_PED_VENDA = new System.Data.DataColumn();
            this.PAGO_PED_VENDA = new System.Data.DataColumn();
            this.COD_CAIXA_PGTO_PED_VENDA = new System.Data.DataColumn();
            this.VENDEDOR_PED_VENDA = new System.Data.DataColumn();
            this.COD_VENDEDOR_PED_VENDA = new System.Data.DataColumn();
            this.CANCELADO_PED_VENDA = new System.Data.DataColumn();
            this.NOME_CONTATO_PED_VENDA = new System.Data.DataColumn();
            this.TELEFONE_CONTATO_PED_VENDA = new System.Data.DataColumn();
            this.EMAIL_CONTATO_PED_VENDA = new System.Data.DataColumn();
            this.PORC_DESCONTO_PED_VENDA = new System.Data.DataColumn();
            this.fbCommand21 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand22 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand23 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand24 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.cbxGrupo = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cb_fornecedor = new System.Windows.Forms.CheckBox();
            this.tb_nome_fornecedor = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.fbCommand25 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand26 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand27 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand28 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.datEmpresa = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand32 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand30 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand29 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand31 = new FirebirdSql.Data.FirebirdClient.FbCommand();
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
            this.RNTRC_EMPRESA = new System.Data.DataColumn();
            this.LICENCA_DLL_CTE_EMPRESA = new System.Data.DataColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsPedidos_venda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PEDIDOS_VENDA)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EMPRESA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtFinal);
            this.groupBox2.Controls.Add(this.dtInicial);
            this.groupBox2.Location = new System.Drawing.Point(22, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(112, 79);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Entre Datas";
            // 
            // dtFinal
            // 
            this.dtFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFinal.Location = new System.Drawing.Point(6, 45);
            this.dtFinal.Name = "dtFinal";
            this.dtFinal.Size = new System.Drawing.Size(97, 20);
            this.dtFinal.TabIndex = 13;
            // 
            // dtInicial
            // 
            this.dtInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicial.Location = new System.Drawing.Point(6, 19);
            this.dtInicial.Name = "dtInicial";
            this.dtInicial.Size = new System.Drawing.Size(97, 20);
            this.dtInicial.TabIndex = 12;
            this.dtInicial.ValueChanged += new System.EventHandler(this.dtInicial_ValueChanged);
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
            this.fbCommand1.CommandText = "select * from pedidos_venda order by cod_ped_venda desc";
            this.fbCommand1.CommandTimeout = 30;
            this.fbCommand1.Connection = this.fbConnection1;
            // 
            // fbConnection1
            // 
            this.fbConnection1.ConnectionString = resources.GetString("fbConnection1.ConnectionString");
            this.fbConnection1.InfoMessage += new FirebirdSql.Data.FirebirdClient.FbInfoMessageEventHandler(this.fbConnection1_InfoMessage);
            // 
            // fbCommand3
            // 
            this.fbCommand3.CommandTimeout = 30;
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AllowUserToAddRows = false;
            this.dgvPedidos.AllowUserToDeleteRows = false;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Location = new System.Drawing.Point(22, 147);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.ReadOnly = true;
            this.dgvPedidos.Size = new System.Drawing.Size(598, 415);
            this.dgvPedidos.TabIndex = 18;
            this.dgvPedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedidos_CellContentClick);
            // 
            // tb_valor_total
            // 
            this.tb_valor_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_valor_total.Location = new System.Drawing.Point(426, 584);
            this.tb_valor_total.Name = "tb_valor_total";
            this.tb_valor_total.Size = new System.Drawing.Size(166, 31);
            this.tb_valor_total.TabIndex = 21;
            this.tb_valor_total.TextChanged += new System.EventHandler(this.tb_valor_total_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(304, 587);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 26);
            this.label1.TabIndex = 22;
            this.label1.Text = "Valor Total";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(909, 284);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 76);
            this.button2.TabIndex = 23;
            this.button2.Text = "Confirmar\r\nSeleção";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            // 
            // comando_select
            // 
            this.comando_select.CommandTimeout = 30;
            this.comando_select.Connection = this.fbConnection1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cb_vendedor);
            this.groupBox3.Controls.Add(this.tb_nome_vendedor);
            this.groupBox3.Controls.Add(this.tb_cod_vendedor);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Location = new System.Drawing.Point(140, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(253, 39);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Vendedor";
            // 
            // cb_vendedor
            // 
            this.cb_vendedor.AutoSize = true;
            this.cb_vendedor.Location = new System.Drawing.Point(232, 16);
            this.cb_vendedor.Name = "cb_vendedor";
            this.cb_vendedor.Size = new System.Drawing.Size(15, 14);
            this.cb_vendedor.TabIndex = 282;
            this.cb_vendedor.UseVisualStyleBackColor = true;
            this.cb_vendedor.CheckedChanged += new System.EventHandler(this.cb_vendedor_CheckedChanged);
            // 
            // tb_nome_vendedor
            // 
            this.tb_nome_vendedor.Location = new System.Drawing.Point(59, 13);
            this.tb_nome_vendedor.Name = "tb_nome_vendedor";
            this.tb_nome_vendedor.Size = new System.Drawing.Size(121, 20);
            this.tb_nome_vendedor.TabIndex = 281;
            this.tb_nome_vendedor.TextChanged += new System.EventHandler(this.tb_nome_vendedor_TextChanged);
            // 
            // tb_cod_vendedor
            // 
            this.tb_cod_vendedor.Location = new System.Drawing.Point(12, 13);
            this.tb_cod_vendedor.Name = "tb_cod_vendedor";
            this.tb_cod_vendedor.Size = new System.Drawing.Size(41, 20);
            this.tb_cod_vendedor.TabIndex = 280;
            this.tb_cod_vendedor.TextChanged += new System.EventHandler(this.tb_cod_vendedor_TextChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(186, 11);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(23, 23);
            this.button4.TabIndex = 279;
            this.button4.Text = "+";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(531, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 76);
            this.button3.TabIndex = 26;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_cliente);
            this.groupBox1.Controls.Add(this.tb_nome_cliente);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Location = new System.Drawing.Point(140, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 39);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clientes";
            // 
            // cb_cliente
            // 
            this.cb_cliente.AutoSize = true;
            this.cb_cliente.Location = new System.Drawing.Point(232, 16);
            this.cb_cliente.Name = "cb_cliente";
            this.cb_cliente.Size = new System.Drawing.Size(15, 14);
            this.cb_cliente.TabIndex = 282;
            this.cb_cliente.UseVisualStyleBackColor = true;
            this.cb_cliente.CheckedChanged += new System.EventHandler(this.cb_cliente_CheckedChanged);
            // 
            // tb_nome_cliente
            // 
            this.tb_nome_cliente.Location = new System.Drawing.Point(12, 13);
            this.tb_nome_cliente.Name = "tb_nome_cliente";
            this.tb_nome_cliente.Size = new System.Drawing.Size(168, 20);
            this.tb_nome_cliente.TabIndex = 281;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(186, 11);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(23, 23);
            this.button5.TabIndex = 279;
            this.button5.Text = "+";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(399, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(89, 76);
            this.button6.TabIndex = 28;
            this.button6.Text = "Comissão";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_2);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(909, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 76);
            this.button1.TabIndex = 17;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
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
            this.fbCommand5.CommandText = "SELECT * FROM ITENS_NOTA ORDER BY COD_ITENS_NOTA";
            this.fbCommand5.CommandTimeout = 30;
            this.fbCommand5.Connection = this.fbConnection1;
            // 
            // fbCommand7
            // 
            this.fbCommand7.CommandTimeout = 30;
            // 
            // fbCommand9
            // 
            this.fbCommand9.CommandText = "SELECT * FROM PEDIDOS_VENDA";
            this.fbCommand9.CommandTimeout = 30;
            this.fbCommand9.Connection = this.fbConnection1;
            // 
            // fbCommand10
            // 
            this.fbCommand10.CommandTimeout = 30;
            // 
            // fbCommand11
            // 
            this.fbCommand11.CommandTimeout = 30;
            // 
            // fbCommand12
            // 
            this.fbCommand12.CommandTimeout = 30;
            // 
            // fbCommand13
            // 
            this.fbCommand13.CommandText = "select * from pedidos_venda order by cod_ped_venda desc";
            this.fbCommand13.CommandTimeout = 30;
            this.fbCommand13.Connection = this.fbConnection1;
            // 
            // fbCommand14
            // 
            this.fbCommand14.CommandTimeout = 30;
            // 
            // fbCommand15
            // 
            this.fbCommand15.CommandTimeout = 30;
            // 
            // fbCommand16
            // 
            this.fbCommand16.CommandTimeout = 30;
            // 
            // datPedidos_venda
            // 
            this.datPedidos_venda.DeleteCommand = this.fbCommand20;
            this.datPedidos_venda.InsertCommand = this.fbCommand18;
            this.datPedidos_venda.SelectCommand = this.fbCommand17;
            this.datPedidos_venda.UpdateCommand = this.fbCommand19;
            // 
            // fbCommand20
            // 
            this.fbCommand20.CommandTimeout = 30;
            // 
            // fbCommand18
            // 
            this.fbCommand18.CommandTimeout = 30;
            // 
            // fbCommand17
            // 
            this.fbCommand17.CommandText = "select * from pedidos_venda order by cod_ped_venda desc";
            this.fbCommand17.CommandTimeout = 30;
            this.fbCommand17.Connection = this.fbConnection1;
            // 
            // fbCommand19
            // 
            this.fbCommand19.CommandTimeout = 30;
            // 
            // dsPedidos_venda
            // 
            this.dsPedidos_venda.DataSetName = "dsPedidos_venda";
            this.dsPedidos_venda.Namespace = "http://www.tempuri.org/dsPedidos_venda.xsd";
            this.dsPedidos_venda.Tables.AddRange(new System.Data.DataTable[] {
            this.PEDIDOS_VENDA});
            // 
            // PEDIDOS_VENDA
            // 
            this.PEDIDOS_VENDA.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_PED_VENDA,
            this.DATA_PED_VENDA,
            this.DATA_BAIXA_PED_VENDA,
            this.CLIENTE_PED_VENDA,
            this.CNPJ_PED_VENDA,
            this.COND_PGTO_PED_VENDA,
            this.VALOR_TOTAL_PROD_PED_VENDA,
            this.VALOR_TOTAL_PED_VENDA,
            this.VALOR_TOTAL_ICMS_PED_VENDA,
            this.VALOR_TOTAL_IPI_PED_VENDA,
            this.VALOR_DESCONTO_PED_VENDA,
            this.OBS_PED_VENDA,
            this.NF_PED_VENDA,
            this.BAIXADO_ESTOQUE_PED_VENDA,
            this.PAGO_PED_VENDA,
            this.COD_CAIXA_PGTO_PED_VENDA,
            this.VENDEDOR_PED_VENDA,
            this.COD_VENDEDOR_PED_VENDA,
            this.CANCELADO_PED_VENDA,
            this.NOME_CONTATO_PED_VENDA,
            this.TELEFONE_CONTATO_PED_VENDA,
            this.EMAIL_CONTATO_PED_VENDA,
            this.PORC_DESCONTO_PED_VENDA});
            this.PEDIDOS_VENDA.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COD_PED_VENDA"}, true)});
            this.PEDIDOS_VENDA.PrimaryKey = new System.Data.DataColumn[] {
        this.COD_PED_VENDA};
            this.PEDIDOS_VENDA.TableName = "PEDIDOS_VENDA";
            // 
            // COD_PED_VENDA
            // 
            this.COD_PED_VENDA.AllowDBNull = false;
            this.COD_PED_VENDA.ColumnName = "COD_PED_VENDA";
            this.COD_PED_VENDA.DataType = typeof(int);
            // 
            // DATA_PED_VENDA
            // 
            this.DATA_PED_VENDA.ColumnName = "DATA_PED_VENDA";
            this.DATA_PED_VENDA.DataType = typeof(System.DateTime);
            // 
            // DATA_BAIXA_PED_VENDA
            // 
            this.DATA_BAIXA_PED_VENDA.ColumnName = "DATA_BAIXA_PED_VENDA";
            this.DATA_BAIXA_PED_VENDA.DataType = typeof(System.DateTime);
            // 
            // CLIENTE_PED_VENDA
            // 
            this.CLIENTE_PED_VENDA.ColumnName = "CLIENTE_PED_VENDA";
            this.CLIENTE_PED_VENDA.MaxLength = 200;
            // 
            // CNPJ_PED_VENDA
            // 
            this.CNPJ_PED_VENDA.ColumnName = "CNPJ_PED_VENDA";
            this.CNPJ_PED_VENDA.MaxLength = 30;
            // 
            // COND_PGTO_PED_VENDA
            // 
            this.COND_PGTO_PED_VENDA.ColumnName = "COND_PGTO_PED_VENDA";
            this.COND_PGTO_PED_VENDA.MaxLength = 30;
            // 
            // VALOR_TOTAL_PROD_PED_VENDA
            // 
            this.VALOR_TOTAL_PROD_PED_VENDA.ColumnName = "VALOR_TOTAL_PROD_PED_VENDA";
            this.VALOR_TOTAL_PROD_PED_VENDA.DataType = typeof(double);
            // 
            // VALOR_TOTAL_PED_VENDA
            // 
            this.VALOR_TOTAL_PED_VENDA.ColumnName = "VALOR_TOTAL_PED_VENDA";
            this.VALOR_TOTAL_PED_VENDA.DataType = typeof(double);
            // 
            // VALOR_TOTAL_ICMS_PED_VENDA
            // 
            this.VALOR_TOTAL_ICMS_PED_VENDA.ColumnName = "VALOR_TOTAL_ICMS_PED_VENDA";
            this.VALOR_TOTAL_ICMS_PED_VENDA.DataType = typeof(double);
            // 
            // VALOR_TOTAL_IPI_PED_VENDA
            // 
            this.VALOR_TOTAL_IPI_PED_VENDA.ColumnName = "VALOR_TOTAL_IPI_PED_VENDA";
            this.VALOR_TOTAL_IPI_PED_VENDA.DataType = typeof(double);
            // 
            // VALOR_DESCONTO_PED_VENDA
            // 
            this.VALOR_DESCONTO_PED_VENDA.ColumnName = "VALOR_DESCONTO_PED_VENDA";
            this.VALOR_DESCONTO_PED_VENDA.DataType = typeof(double);
            // 
            // OBS_PED_VENDA
            // 
            this.OBS_PED_VENDA.ColumnName = "OBS_PED_VENDA";
            this.OBS_PED_VENDA.MaxLength = 300;
            // 
            // NF_PED_VENDA
            // 
            this.NF_PED_VENDA.ColumnName = "NF_PED_VENDA";
            this.NF_PED_VENDA.DataType = typeof(int);
            // 
            // BAIXADO_ESTOQUE_PED_VENDA
            // 
            this.BAIXADO_ESTOQUE_PED_VENDA.ColumnName = "BAIXADO_ESTOQUE_PED_VENDA";
            this.BAIXADO_ESTOQUE_PED_VENDA.DataType = typeof(int);
            // 
            // PAGO_PED_VENDA
            // 
            this.PAGO_PED_VENDA.ColumnName = "PAGO_PED_VENDA";
            this.PAGO_PED_VENDA.DataType = typeof(int);
            // 
            // COD_CAIXA_PGTO_PED_VENDA
            // 
            this.COD_CAIXA_PGTO_PED_VENDA.ColumnName = "COD_CAIXA_PGTO_PED_VENDA";
            this.COD_CAIXA_PGTO_PED_VENDA.DataType = typeof(int);
            // 
            // VENDEDOR_PED_VENDA
            // 
            this.VENDEDOR_PED_VENDA.ColumnName = "VENDEDOR_PED_VENDA";
            this.VENDEDOR_PED_VENDA.MaxLength = 100;
            // 
            // COD_VENDEDOR_PED_VENDA
            // 
            this.COD_VENDEDOR_PED_VENDA.ColumnName = "COD_VENDEDOR_PED_VENDA";
            this.COD_VENDEDOR_PED_VENDA.DataType = typeof(int);
            // 
            // CANCELADO_PED_VENDA
            // 
            this.CANCELADO_PED_VENDA.ColumnName = "CANCELADO_PED_VENDA";
            this.CANCELADO_PED_VENDA.DataType = typeof(int);
            // 
            // NOME_CONTATO_PED_VENDA
            // 
            this.NOME_CONTATO_PED_VENDA.ColumnName = "NOME_CONTATO_PED_VENDA";
            this.NOME_CONTATO_PED_VENDA.MaxLength = 100;
            // 
            // TELEFONE_CONTATO_PED_VENDA
            // 
            this.TELEFONE_CONTATO_PED_VENDA.ColumnName = "TELEFONE_CONTATO_PED_VENDA";
            this.TELEFONE_CONTATO_PED_VENDA.MaxLength = 100;
            // 
            // EMAIL_CONTATO_PED_VENDA
            // 
            this.EMAIL_CONTATO_PED_VENDA.ColumnName = "EMAIL_CONTATO_PED_VENDA";
            this.EMAIL_CONTATO_PED_VENDA.MaxLength = 100;
            // 
            // PORC_DESCONTO_PED_VENDA
            // 
            this.PORC_DESCONTO_PED_VENDA.ColumnName = "PORC_DESCONTO_PED_VENDA";
            this.PORC_DESCONTO_PED_VENDA.DataType = typeof(double);
            // 
            // fbCommand21
            // 
            this.fbCommand21.CommandText = "select * from produtos";
            this.fbCommand21.CommandTimeout = 30;
            this.fbCommand21.Connection = this.fbConnection1;
            // 
            // fbCommand22
            // 
            this.fbCommand22.CommandTimeout = 30;
            // 
            // fbCommand23
            // 
            this.fbCommand23.CommandTimeout = 30;
            // 
            // fbCommand24
            // 
            this.fbCommand24.CommandTimeout = 30;
            // 
            // cbxGrupo
            // 
            this.cbxGrupo.FormattingEnabled = true;
            this.cbxGrupo.Location = new System.Drawing.Point(12, 13);
            this.cbxGrupo.Name = "cbxGrupo";
            this.cbxGrupo.Size = new System.Drawing.Size(203, 21);
            this.cbxGrupo.TabIndex = 29;
            this.cbxGrupo.SelectedIndexChanged += new System.EventHandler(this.cbxGrupo_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbxGrupo);
            this.groupBox4.Location = new System.Drawing.Point(399, 97);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(221, 39);
            this.groupBox4.TabIndex = 283;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Grupo";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter_1);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cb_fornecedor);
            this.groupBox5.Controls.Add(this.tb_nome_fornecedor);
            this.groupBox5.Controls.Add(this.button8);
            this.groupBox5.Location = new System.Drawing.Point(140, 97);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(253, 39);
            this.groupBox5.TabIndex = 284;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Fornecedores";
            // 
            // cb_fornecedor
            // 
            this.cb_fornecedor.AutoSize = true;
            this.cb_fornecedor.Location = new System.Drawing.Point(232, 16);
            this.cb_fornecedor.Name = "cb_fornecedor";
            this.cb_fornecedor.Size = new System.Drawing.Size(15, 14);
            this.cb_fornecedor.TabIndex = 282;
            this.cb_fornecedor.UseVisualStyleBackColor = true;
            // 
            // tb_nome_fornecedor
            // 
            this.tb_nome_fornecedor.Location = new System.Drawing.Point(12, 13);
            this.tb_nome_fornecedor.Name = "tb_nome_fornecedor";
            this.tb_nome_fornecedor.Size = new System.Drawing.Size(168, 20);
            this.tb_nome_fornecedor.TabIndex = 281;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(186, 11);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(23, 23);
            this.button8.TabIndex = 279;
            this.button8.Text = "+";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click_2);
            // 
            // fbCommand25
            // 
            this.fbCommand25.CommandTimeout = 30;
            // 
            // fbCommand26
            // 
            this.fbCommand26.CommandTimeout = 30;
            // 
            // fbCommand27
            // 
            this.fbCommand27.CommandTimeout = 30;
            // 
            // fbCommand28
            // 
            this.fbCommand28.CommandTimeout = 30;
            // 
            // datEmpresa
            // 
            this.datEmpresa.DeleteCommand = this.fbCommand32;
            this.datEmpresa.InsertCommand = this.fbCommand30;
            this.datEmpresa.SelectCommand = this.fbCommand29;
            this.datEmpresa.UpdateCommand = this.fbCommand31;
            // 
            // fbCommand32
            // 
            this.fbCommand32.CommandTimeout = 30;
            // 
            // fbCommand30
            // 
            this.fbCommand30.CommandTimeout = 30;
            // 
            // fbCommand29
            // 
            this.fbCommand29.CommandText = "select * from empresa";
            this.fbCommand29.CommandTimeout = 30;
            this.fbCommand29.Connection = this.fbConnection1;
            // 
            // fbCommand31
            // 
            this.fbCommand31.CommandTimeout = 30;
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
            this.RNTRC_EMPRESA,
            this.LICENCA_DLL_CTE_EMPRESA});
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
            this.NOME_CERTIFICADO_NFE_EMPRESA.MaxLength = 200;
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
            // RNTRC_EMPRESA
            // 
            this.RNTRC_EMPRESA.ColumnName = "RNTRC_EMPRESA";
            this.RNTRC_EMPRESA.MaxLength = 50;
            // 
            // LICENCA_DLL_CTE_EMPRESA
            // 
            this.LICENCA_DLL_CTE_EMPRESA.ColumnName = "LICENCA_DLL_CTE_EMPRESA";
            this.LICENCA_DLL_CTE_EMPRESA.MaxLength = 500;
            // 
            // form_pesquisa_comissao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 646);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_valor_total);
            this.Controls.Add(this.dgvPedidos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Name = "form_pesquisa_comissao";
            this.Text = "Pesquisa Comissão";
            this.Load += new System.EventHandler(this.form_pesquisa_comissao_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsPedidos_venda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PEDIDOS_VENDA)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EMPRESA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtFinal;
        private System.Windows.Forms.DateTimePicker dtInicial;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.TextBox tb_valor_total;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private FirebirdSql.Data.FirebirdClient.FbCommand comando_select;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tb_nome_vendedor;
        private System.Windows.Forms.TextBox tb_cod_vendedor;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox cb_vendedor;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cb_cliente;
        private System.Windows.Forms.TextBox tb_nome_cliente;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand8;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand6;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand5;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand7;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand12;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand10;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand9;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand11;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand16;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand14;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand13;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand15;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datPedidos_venda;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand20;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand18;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand17;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand19;
        private System.Data.DataSet dsPedidos_venda;
        private System.Data.DataTable PEDIDOS_VENDA;
        private System.Data.DataColumn COD_PED_VENDA;
        private System.Data.DataColumn DATA_PED_VENDA;
        private System.Data.DataColumn DATA_BAIXA_PED_VENDA;
        private System.Data.DataColumn CLIENTE_PED_VENDA;
        private System.Data.DataColumn CNPJ_PED_VENDA;
        private System.Data.DataColumn COND_PGTO_PED_VENDA;
        private System.Data.DataColumn VALOR_TOTAL_PROD_PED_VENDA;
        private System.Data.DataColumn VALOR_TOTAL_PED_VENDA;
        private System.Data.DataColumn VALOR_TOTAL_ICMS_PED_VENDA;
        private System.Data.DataColumn VALOR_TOTAL_IPI_PED_VENDA;
        private System.Data.DataColumn VALOR_DESCONTO_PED_VENDA;
        private System.Data.DataColumn OBS_PED_VENDA;
        private System.Data.DataColumn NF_PED_VENDA;
        private System.Data.DataColumn BAIXADO_ESTOQUE_PED_VENDA;
        private System.Data.DataColumn PAGO_PED_VENDA;
        private System.Data.DataColumn COD_CAIXA_PGTO_PED_VENDA;
        private System.Data.DataColumn VENDEDOR_PED_VENDA;
        private System.Data.DataColumn COD_VENDEDOR_PED_VENDA;
        private System.Data.DataColumn CANCELADO_PED_VENDA;
        private System.Data.DataColumn NOME_CONTATO_PED_VENDA;
        private System.Data.DataColumn TELEFONE_CONTATO_PED_VENDA;
        private System.Data.DataColumn EMAIL_CONTATO_PED_VENDA;
        private System.Data.DataColumn PORC_DESCONTO_PED_VENDA;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand24;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand22;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand21;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand23;
        private System.Windows.Forms.ComboBox cbxGrupo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox cb_fornecedor;
        private System.Windows.Forms.TextBox tb_nome_fornecedor;
        private System.Windows.Forms.Button button8;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand25;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand26;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand27;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand28;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datEmpresa;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand32;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand30;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand29;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand31;
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
        private System.Data.DataColumn RNTRC_EMPRESA;
        private System.Data.DataColumn LICENCA_DLL_CTE_EMPRESA;
    }
}