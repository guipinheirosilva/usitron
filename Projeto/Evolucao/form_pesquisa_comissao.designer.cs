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
            this.comando_select = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cb_vendedor = new System.Windows.Forms.CheckBox();
            this.tb_nome_vendedor = new System.Windows.Forms.TextBox();
            this.tb_cod_vendedor = new System.Windows.Forms.TextBox();
            this.btnAddVendedor = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_cod_cliente = new System.Windows.Forms.TextBox();
            this.cb_cliente = new System.Windows.Forms.CheckBox();
            this.tb_nome_cliente = new System.Windows.Forms.TextBox();
            this.btnAddCliente = new System.Windows.Forms.Button();
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tb_cod_fornecedor = new System.Windows.Forms.TextBox();
            this.cb_fornecedor = new System.Windows.Forms.CheckBox();
            this.tb_nome_fornecedor = new System.Windows.Forms.TextBox();
            this.btnAddFornecedores = new System.Windows.Forms.Button();
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
            this.cbxImpDetalhada = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.cb_com_pis = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_diferenca_total = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tb_cod_produto = new System.Windows.Forms.TextBox();
            this.cbProduto = new System.Windows.Forms.CheckBox();
            this.tb_nome_produto = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.bt_comissao_produto = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.bt_prod_lucratividade = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cbCfop = new System.Windows.Forms.CheckBox();
            this.tb_n_cfop = new System.Windows.Forms.TextBox();
            this.button13 = new System.Windows.Forms.Button();
            this.bt_nfs_lucratividade = new System.Windows.Forms.Button();
            this.bt_cli_lucratividade = new System.Windows.Forms.Button();
            this.cbApenas_troca = new System.Windows.Forms.CheckBox();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.btnVPC = new System.Windows.Forms.Button();
            this.tb_cnpj = new System.Windows.Forms.TextBox();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.tbCodFamilia = new System.Windows.Forms.TextBox();
            this.cbFamilia = new System.Windows.Forms.CheckBox();
            this.tbFamilia = new System.Windows.Forms.TextBox();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.bt_clientes_lucratividade = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.bt_comissao_recebimento = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.tb_cod_pesquisa = new System.Windows.Forms.TextBox();
            this.cb_Personalizada = new System.Windows.Forms.CheckBox();
            this.tb_descricao_pesquisa = new System.Windows.Forms.TextBox();
            this.button33 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.tbCodGrupo = new System.Windows.Forms.TextBox();
            this.cbGrupo = new System.Windows.Forms.CheckBox();
            this.tbGrupo = new System.Windows.Forms.TextBox();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.bt_cliente_lucra_custo = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button35 = new System.Windows.Forms.Button();
            this.button36 = new System.Windows.Forms.Button();
            this.button37 = new System.Windows.Forms.Button();
            this.bt_vend_lucra_custo = new System.Windows.Forms.Button();
            this.button39 = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.tbcodSubgrupo = new System.Windows.Forms.TextBox();
            this.cbSubGrupo = new System.Windows.Forms.CheckBox();
            this.tbdescricaoSubgrupo = new System.Windows.Forms.TextBox();
            this.button27 = new System.Windows.Forms.Button();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.tb_cod_matriz = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tb_razao_matriz = new System.Windows.Forms.TextBox();
            this.button38 = new System.Windows.Forms.Button();
            this.button40 = new System.Windows.Forms.Button();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.txtNomeSupervisor = new System.Windows.Forms.TextBox();
            this.txtCodSupervisor = new System.Windows.Forms.TextBox();
            this.button41 = new System.Windows.Forms.Button();
            this.button42 = new System.Windows.Forms.Button();
            this.button43 = new System.Windows.Forms.Button();
            this.button44 = new System.Windows.Forms.Button();
            this.button45 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsPedidos_venda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PEDIDOS_VENDA)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EMPRESA)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtFinal);
            this.groupBox2.Controls.Add(this.dtInicial);
            this.groupBox2.Location = new System.Drawing.Point(22, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(112, 79);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Período";
            // 
            // dtFinal
            // 
            this.dtFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFinal.Location = new System.Drawing.Point(6, 45);
            this.dtFinal.Name = "dtFinal";
            this.dtFinal.Size = new System.Drawing.Size(97, 20);
            this.dtFinal.TabIndex = 1;
            // 
            // dtInicial
            // 
            this.dtInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicial.Location = new System.Drawing.Point(6, 19);
            this.dtInicial.Name = "dtInicial";
            this.dtInicial.Size = new System.Drawing.Size(97, 20);
            this.dtInicial.TabIndex = 0;
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
            this.dgvPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Location = new System.Drawing.Point(22, 385);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.ReadOnly = true;
            this.dgvPedidos.Size = new System.Drawing.Size(1230, 177);
            this.dgvPedidos.TabIndex = 7;
            this.dgvPedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedidos_CellContentClick);
            this.dgvPedidos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPedidos_CellFormatting);
            // 
            // tb_valor_total
            // 
            this.tb_valor_total.Enabled = false;
            this.tb_valor_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_valor_total.Location = new System.Drawing.Point(657, 568);
            this.tb_valor_total.Name = "tb_valor_total";
            this.tb_valor_total.Size = new System.Drawing.Size(166, 31);
            this.tb_valor_total.TabIndex = 21;
            this.tb_valor_total.TextChanged += new System.EventHandler(this.tb_valor_total_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(529, 571);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 26);
            this.label1.TabIndex = 22;
            this.label1.Text = "Valor Total:";
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
            this.groupBox3.Controls.Add(this.btnAddVendedor);
            this.groupBox3.Location = new System.Drawing.Point(140, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(253, 39);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Vendedor";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
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
            this.tb_nome_vendedor.BackColor = System.Drawing.SystemColors.Control;
            this.tb_nome_vendedor.Location = new System.Drawing.Point(59, 13);
            this.tb_nome_vendedor.Name = "tb_nome_vendedor";
            this.tb_nome_vendedor.Size = new System.Drawing.Size(121, 20);
            this.tb_nome_vendedor.TabIndex = 1;
            this.tb_nome_vendedor.TextChanged += new System.EventHandler(this.tb_nome_vendedor_TextChanged);
            // 
            // tb_cod_vendedor
            // 
            this.tb_cod_vendedor.BackColor = System.Drawing.SystemColors.Control;
            this.tb_cod_vendedor.Enabled = false;
            this.tb_cod_vendedor.Location = new System.Drawing.Point(12, 13);
            this.tb_cod_vendedor.Name = "tb_cod_vendedor";
            this.tb_cod_vendedor.Size = new System.Drawing.Size(41, 20);
            this.tb_cod_vendedor.TabIndex = 0;
            // 
            // btnAddVendedor
            // 
            this.btnAddVendedor.Location = new System.Drawing.Point(186, 11);
            this.btnAddVendedor.Name = "btnAddVendedor";
            this.btnAddVendedor.Size = new System.Drawing.Size(23, 23);
            this.btnAddVendedor.TabIndex = 279;
            this.btnAddVendedor.Text = "+";
            this.btnAddVendedor.UseVisualStyleBackColor = true;
            this.btnAddVendedor.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_cod_cliente);
            this.groupBox1.Controls.Add(this.cb_cliente);
            this.groupBox1.Controls.Add(this.tb_nome_cliente);
            this.groupBox1.Controls.Add(this.btnAddCliente);
            this.groupBox1.Location = new System.Drawing.Point(140, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 39);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clientes";
            // 
            // tb_cod_cliente
            // 
            this.tb_cod_cliente.BackColor = System.Drawing.SystemColors.Control;
            this.tb_cod_cliente.Enabled = false;
            this.tb_cod_cliente.Location = new System.Drawing.Point(12, 14);
            this.tb_cod_cliente.Name = "tb_cod_cliente";
            this.tb_cod_cliente.Size = new System.Drawing.Size(41, 20);
            this.tb_cod_cliente.TabIndex = 0;
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
            this.tb_nome_cliente.BackColor = System.Drawing.SystemColors.Control;
            this.tb_nome_cliente.Enabled = false;
            this.tb_nome_cliente.Location = new System.Drawing.Point(59, 13);
            this.tb_nome_cliente.Name = "tb_nome_cliente";
            this.tb_nome_cliente.Size = new System.Drawing.Size(121, 20);
            this.tb_nome_cliente.TabIndex = 1;
            // 
            // btnAddCliente
            // 
            this.btnAddCliente.Location = new System.Drawing.Point(186, 11);
            this.btnAddCliente.Name = "btnAddCliente";
            this.btnAddCliente.Size = new System.Drawing.Size(23, 23);
            this.btnAddCliente.TabIndex = 279;
            this.btnAddCliente.Text = "+";
            this.btnAddCliente.UseVisualStyleBackColor = true;
            this.btnAddCliente.Click += new System.EventHandler(this.button5_Click);
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
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tb_cod_fornecedor);
            this.groupBox5.Controls.Add(this.cb_fornecedor);
            this.groupBox5.Controls.Add(this.tb_nome_fornecedor);
            this.groupBox5.Controls.Add(this.btnAddFornecedores);
            this.groupBox5.Location = new System.Drawing.Point(140, 133);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(253, 39);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Fornecedores";
            // 
            // tb_cod_fornecedor
            // 
            this.tb_cod_fornecedor.BackColor = System.Drawing.SystemColors.Control;
            this.tb_cod_fornecedor.Enabled = false;
            this.tb_cod_fornecedor.Location = new System.Drawing.Point(12, 13);
            this.tb_cod_fornecedor.Name = "tb_cod_fornecedor";
            this.tb_cod_fornecedor.Size = new System.Drawing.Size(41, 20);
            this.tb_cod_fornecedor.TabIndex = 0;
            // 
            // cb_fornecedor
            // 
            this.cb_fornecedor.AutoSize = true;
            this.cb_fornecedor.Location = new System.Drawing.Point(232, 16);
            this.cb_fornecedor.Name = "cb_fornecedor";
            this.cb_fornecedor.Size = new System.Drawing.Size(15, 14);
            this.cb_fornecedor.TabIndex = 282;
            this.cb_fornecedor.UseVisualStyleBackColor = true;
            this.cb_fornecedor.CheckedChanged += new System.EventHandler(this.cb_fornecedor_CheckedChanged_1);
            // 
            // tb_nome_fornecedor
            // 
            this.tb_nome_fornecedor.BackColor = System.Drawing.SystemColors.Control;
            this.tb_nome_fornecedor.Enabled = false;
            this.tb_nome_fornecedor.Location = new System.Drawing.Point(59, 13);
            this.tb_nome_fornecedor.Name = "tb_nome_fornecedor";
            this.tb_nome_fornecedor.Size = new System.Drawing.Size(121, 20);
            this.tb_nome_fornecedor.TabIndex = 1;
            // 
            // btnAddFornecedores
            // 
            this.btnAddFornecedores.Location = new System.Drawing.Point(186, 11);
            this.btnAddFornecedores.Name = "btnAddFornecedores";
            this.btnAddFornecedores.Size = new System.Drawing.Size(23, 23);
            this.btnAddFornecedores.TabIndex = 279;
            this.btnAddFornecedores.Text = "+";
            this.btnAddFornecedores.UseVisualStyleBackColor = true;
            this.btnAddFornecedores.Click += new System.EventHandler(this.button8_Click_2);
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
            // cbxImpDetalhada
            // 
            this.cbxImpDetalhada.AutoSize = true;
            this.cbxImpDetalhada.Enabled = false;
            this.cbxImpDetalhada.Location = new System.Drawing.Point(399, 97);
            this.cbxImpDetalhada.Name = "cbxImpDetalhada";
            this.cbxImpDetalhada.Size = new System.Drawing.Size(124, 17);
            this.cbxImpDetalhada.TabIndex = 24;
            this.cbxImpDetalhada.Text = "Impressão detalhada";
            this.cbxImpDetalhada.UseVisualStyleBackColor = true;
            this.cbxImpDetalhada.Visible = false;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(590, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 49);
            this.button1.TabIndex = 25;
            this.button1.Text = "Vendedor X Clientes  X Produtos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Blue;
            this.button2.Location = new System.Drawing.Point(685, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 49);
            this.button2.TabIndex = 26;
            this.button2.Text = "Vendedor X Clientes";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Blue;
            this.button4.Location = new System.Drawing.Point(780, 17);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 49);
            this.button4.TabIndex = 27;
            this.button4.Text = "Vendedor X Produtos";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button5
            // 
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Blue;
            this.button5.Location = new System.Drawing.Point(590, 71);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(89, 49);
            this.button5.TabIndex = 28;
            this.button5.Text = "Vendedor X Cidades";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::Evolucao.Properties.Resources.lupa2;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button6.Location = new System.Drawing.Point(399, 18);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(89, 76);
            this.button6.TabIndex = 4;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_2);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(494, 18);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 76);
            this.button3.TabIndex = 5;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.Location = new System.Drawing.Point(590, 130);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(89, 54);
            this.button7.TabIndex = 29;
            this.button7.Text = "Vendedor X Metas";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Visible = false;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // cb_com_pis
            // 
            this.cb_com_pis.AutoSize = true;
            this.cb_com_pis.Location = new System.Drawing.Point(399, 118);
            this.cb_com_pis.Name = "cb_com_pis";
            this.cb_com_pis.Size = new System.Drawing.Size(149, 17);
            this.cb_com_pis.TabIndex = 30;
            this.cb_com_pis.Text = "Apenas com PIS/COFINS";
            this.cb_com_pis.UseVisualStyleBackColor = true;
            this.cb_com_pis.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(918, 569);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 26);
            this.label2.TabIndex = 32;
            this.label2.Text = "Diferença Total:";
            // 
            // tb_diferenca_total
            // 
            this.tb_diferenca_total.Enabled = false;
            this.tb_diferenca_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_diferenca_total.Location = new System.Drawing.Point(1086, 566);
            this.tb_diferenca_total.Name = "tb_diferenca_total";
            this.tb_diferenca_total.Size = new System.Drawing.Size(166, 31);
            this.tb_diferenca_total.TabIndex = 31;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tb_cod_produto);
            this.groupBox4.Controls.Add(this.cbProduto);
            this.groupBox4.Controls.Add(this.tb_nome_produto);
            this.groupBox4.Controls.Add(this.button8);
            this.groupBox4.Location = new System.Drawing.Point(140, 174);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(253, 39);
            this.groupBox4.TabIndex = 283;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Produto";
            // 
            // tb_cod_produto
            // 
            this.tb_cod_produto.BackColor = System.Drawing.SystemColors.Control;
            this.tb_cod_produto.Enabled = false;
            this.tb_cod_produto.Location = new System.Drawing.Point(12, 13);
            this.tb_cod_produto.Name = "tb_cod_produto";
            this.tb_cod_produto.Size = new System.Drawing.Size(41, 20);
            this.tb_cod_produto.TabIndex = 0;
            // 
            // cbProduto
            // 
            this.cbProduto.AutoSize = true;
            this.cbProduto.Location = new System.Drawing.Point(232, 16);
            this.cbProduto.Name = "cbProduto";
            this.cbProduto.Size = new System.Drawing.Size(15, 14);
            this.cbProduto.TabIndex = 282;
            this.cbProduto.UseVisualStyleBackColor = true;
            // 
            // tb_nome_produto
            // 
            this.tb_nome_produto.BackColor = System.Drawing.SystemColors.Control;
            this.tb_nome_produto.Enabled = false;
            this.tb_nome_produto.Location = new System.Drawing.Point(59, 13);
            this.tb_nome_produto.Name = "tb_nome_produto";
            this.tb_nome_produto.Size = new System.Drawing.Size(121, 20);
            this.tb_nome_produto.TabIndex = 1;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(186, 11);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(23, 23);
            this.button8.TabIndex = 279;
            this.button8.Text = "+";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click_3);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(685, 130);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(89, 54);
            this.button9.TabIndex = 284;
            this.button9.Text = "Imprimir Metas";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Visible = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // bt_comissao_produto
            // 
            this.bt_comissao_produto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_comissao_produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_comissao_produto.ForeColor = System.Drawing.Color.Blue;
            this.bt_comissao_produto.Location = new System.Drawing.Point(1160, 18);
            this.bt_comissao_produto.Name = "bt_comissao_produto";
            this.bt_comissao_produto.Size = new System.Drawing.Size(112, 48);
            this.bt_comissao_produto.TabIndex = 286;
            this.bt_comissao_produto.Text = "Vendedor X Produtos X Comissao por Produto";
            this.bt_comissao_produto.UseVisualStyleBackColor = true;
            this.bt_comissao_produto.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button11.Location = new System.Drawing.Point(685, 71);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(89, 54);
            this.button11.TabIndex = 287;
            this.button11.Text = "Vendedor X Créditos";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Visible = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // bt_prod_lucratividade
            // 
            this.bt_prod_lucratividade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_prod_lucratividade.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_prod_lucratividade.ForeColor = System.Drawing.Color.Blue;
            this.bt_prod_lucratividade.Location = new System.Drawing.Point(780, 71);
            this.bt_prod_lucratividade.Name = "bt_prod_lucratividade";
            this.bt_prod_lucratividade.Size = new System.Drawing.Size(89, 49);
            this.bt_prod_lucratividade.TabIndex = 288;
            this.bt_prod_lucratividade.Text = "Produtos X Lucratividade";
            this.bt_prod_lucratividade.UseVisualStyleBackColor = true;
            this.bt_prod_lucratividade.Click += new System.EventHandler(this.button12_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cbCfop);
            this.groupBox6.Controls.Add(this.tb_n_cfop);
            this.groupBox6.Location = new System.Drawing.Point(399, 133);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(124, 39);
            this.groupBox6.TabIndex = 284;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "CFOP";
            // 
            // cbCfop
            // 
            this.cbCfop.AutoSize = true;
            this.cbCfop.Location = new System.Drawing.Point(95, 16);
            this.cbCfop.Name = "cbCfop";
            this.cbCfop.Size = new System.Drawing.Size(15, 14);
            this.cbCfop.TabIndex = 282;
            this.cbCfop.UseVisualStyleBackColor = true;
            // 
            // tb_n_cfop
            // 
            this.tb_n_cfop.BackColor = System.Drawing.SystemColors.Control;
            this.tb_n_cfop.Location = new System.Drawing.Point(6, 13);
            this.tb_n_cfop.Name = "tb_n_cfop";
            this.tb_n_cfop.Size = new System.Drawing.Size(83, 20);
            this.tb_n_cfop.TabIndex = 1;
            // 
            // button13
            // 
            this.button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.Color.Blue;
            this.button13.Location = new System.Drawing.Point(685, 71);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(89, 49);
            this.button13.TabIndex = 289;
            this.button13.Text = "Produtos";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click_1);
            // 
            // bt_nfs_lucratividade
            // 
            this.bt_nfs_lucratividade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_nfs_lucratividade.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_nfs_lucratividade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_nfs_lucratividade.Location = new System.Drawing.Point(1065, 126);
            this.bt_nfs_lucratividade.Name = "bt_nfs_lucratividade";
            this.bt_nfs_lucratividade.Size = new System.Drawing.Size(89, 49);
            this.bt_nfs_lucratividade.TabIndex = 290;
            this.bt_nfs_lucratividade.Text = "NFs X Lucrat. X Troca + Boni + Devol.";
            this.bt_nfs_lucratividade.UseVisualStyleBackColor = true;
            this.bt_nfs_lucratividade.Click += new System.EventHandler(this.button14_Click);
            // 
            // bt_cli_lucratividade
            // 
            this.bt_cli_lucratividade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_cli_lucratividade.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cli_lucratividade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_cli_lucratividade.Location = new System.Drawing.Point(875, 126);
            this.bt_cli_lucratividade.Name = "bt_cli_lucratividade";
            this.bt_cli_lucratividade.Size = new System.Drawing.Size(89, 49);
            this.bt_cli_lucratividade.TabIndex = 291;
            this.bt_cli_lucratividade.Text = "Clientes X Lucratividade X Troca + Devol.";
            this.bt_cli_lucratividade.UseVisualStyleBackColor = true;
            this.bt_cli_lucratividade.Click += new System.EventHandler(this.button15_Click);
            // 
            // cbApenas_troca
            // 
            this.cbApenas_troca.AutoSize = true;
            this.cbApenas_troca.Location = new System.Drawing.Point(1065, 197);
            this.cbApenas_troca.Name = "cbApenas_troca";
            this.cbApenas_troca.Size = new System.Drawing.Size(112, 17);
            this.cbApenas_troca.TabIndex = 292;
            this.cbApenas_troca.Text = "Apenas com troca";
            this.cbApenas_troca.UseVisualStyleBackColor = true;
            this.cbApenas_troca.Visible = false;
            // 
            // button16
            // 
            this.button16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.ForeColor = System.Drawing.Color.Blue;
            this.button16.Location = new System.Drawing.Point(1065, 18);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(89, 48);
            this.button16.TabIndex = 293;
            this.button16.Text = "ABC Clientes";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button17
            // 
            this.button17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button17.Location = new System.Drawing.Point(1183, 148);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(89, 54);
            this.button17.TabIndex = 294;
            this.button17.Text = "Lucratividade PDV";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Visible = false;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button18
            // 
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.ForeColor = System.Drawing.Color.Blue;
            this.button18.Location = new System.Drawing.Point(875, 18);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(89, 48);
            this.button18.TabIndex = 296;
            this.button18.Text = "Vendedor \r\nX \r\nNFe";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // btnVPC
            // 
            this.btnVPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVPC.ForeColor = System.Drawing.Color.Blue;
            this.btnVPC.Location = new System.Drawing.Point(780, 126);
            this.btnVPC.Name = "btnVPC";
            this.btnVPC.Size = new System.Drawing.Size(89, 49);
            this.btnVPC.TabIndex = 297;
            this.btnVPC.Text = "Vendedor X Produto X Cliente";
            this.btnVPC.UseVisualStyleBackColor = true;
            this.btnVPC.Click += new System.EventHandler(this.btnVPC_Click);
            // 
            // tb_cnpj
            // 
            this.tb_cnpj.Location = new System.Drawing.Point(25, 95);
            this.tb_cnpj.Name = "tb_cnpj";
            this.tb_cnpj.ReadOnly = true;
            this.tb_cnpj.Size = new System.Drawing.Size(100, 20);
            this.tb_cnpj.TabIndex = 298;
            // 
            // button19
            // 
            this.button19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button19.Location = new System.Drawing.Point(970, 71);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(89, 49);
            this.button19.TabIndex = 299;
            this.button19.Text = "Clientes X Troca + Bonificação + Devoluções";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button20
            // 
            this.button20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button20.Location = new System.Drawing.Point(1183, 230);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(89, 54);
            this.button20.TabIndex = 300;
            this.button20.Text = "Produtos (%)";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Visible = false;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button21
            // 
            this.button21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button21.Location = new System.Drawing.Point(1163, 71);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(89, 49);
            this.button21.TabIndex = 301;
            this.button21.Text = "ABC Historico Clientes";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Visible = false;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.tbCodFamilia);
            this.groupBox7.Controls.Add(this.cbFamilia);
            this.groupBox7.Controls.Add(this.tbFamilia);
            this.groupBox7.Controls.Add(this.button22);
            this.groupBox7.Location = new System.Drawing.Point(140, 214);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(253, 39);
            this.groupBox7.TabIndex = 284;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Familia";
            // 
            // tbCodFamilia
            // 
            this.tbCodFamilia.BackColor = System.Drawing.SystemColors.Control;
            this.tbCodFamilia.Enabled = false;
            this.tbCodFamilia.Location = new System.Drawing.Point(12, 13);
            this.tbCodFamilia.Name = "tbCodFamilia";
            this.tbCodFamilia.Size = new System.Drawing.Size(41, 20);
            this.tbCodFamilia.TabIndex = 0;
            // 
            // cbFamilia
            // 
            this.cbFamilia.AutoSize = true;
            this.cbFamilia.Location = new System.Drawing.Point(232, 16);
            this.cbFamilia.Name = "cbFamilia";
            this.cbFamilia.Size = new System.Drawing.Size(15, 14);
            this.cbFamilia.TabIndex = 282;
            this.cbFamilia.UseVisualStyleBackColor = true;
            // 
            // tbFamilia
            // 
            this.tbFamilia.BackColor = System.Drawing.SystemColors.Control;
            this.tbFamilia.Enabled = false;
            this.tbFamilia.Location = new System.Drawing.Point(59, 13);
            this.tbFamilia.Name = "tbFamilia";
            this.tbFamilia.Size = new System.Drawing.Size(121, 20);
            this.tbFamilia.TabIndex = 1;
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(186, 11);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(23, 23);
            this.button22.TabIndex = 279;
            this.button22.Text = "+";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // button23
            // 
            this.button23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button23.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button23.ForeColor = System.Drawing.Color.Blue;
            this.button23.Location = new System.Drawing.Point(1065, 71);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(89, 49);
            this.button23.TabIndex = 302;
            this.button23.Text = "ABC SKUS";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // button24
            // 
            this.button24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button24.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button24.ForeColor = System.Drawing.Color.Blue;
            this.button24.Location = new System.Drawing.Point(590, 126);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(89, 49);
            this.button24.TabIndex = 303;
            this.button24.Text = "Vendedor X Cidades X Positivação";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // button25
            // 
            this.button25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button25.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button25.ForeColor = System.Drawing.Color.Blue;
            this.button25.Location = new System.Drawing.Point(685, 126);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(89, 49);
            this.button25.TabIndex = 304;
            this.button25.Text = "Cidades X Positivação";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.button25_Click);
            // 
            // button26
            // 
            this.button26.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button26.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button26.Location = new System.Drawing.Point(970, 126);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(89, 49);
            this.button26.TabIndex = 305;
            this.button26.Text = "Clientes X Troca + Devol.";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.button26_Click);
            // 
            // bt_clientes_lucratividade
            // 
            this.bt_clientes_lucratividade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_clientes_lucratividade.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_clientes_lucratividade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_clientes_lucratividade.Location = new System.Drawing.Point(875, 71);
            this.bt_clientes_lucratividade.Name = "bt_clientes_lucratividade";
            this.bt_clientes_lucratividade.Size = new System.Drawing.Size(89, 49);
            this.bt_clientes_lucratividade.TabIndex = 306;
            this.bt_clientes_lucratividade.Text = "Clientes X Lucrat. X Troca + Boni + Devol";
            this.bt_clientes_lucratividade.UseVisualStyleBackColor = true;
            this.bt_clientes_lucratividade.Click += new System.EventHandler(this.button27_Click);
            // 
            // button28
            // 
            this.button28.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button28.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button28.ForeColor = System.Drawing.Color.Blue;
            this.button28.Location = new System.Drawing.Point(970, 18);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(89, 48);
            this.button28.TabIndex = 307;
            this.button28.Text = "ABC Período";
            this.button28.UseVisualStyleBackColor = true;
            this.button28.Visible = false;
            this.button28.Click += new System.EventHandler(this.button28_Click_1);
            // 
            // bt_comissao_recebimento
            // 
            this.bt_comissao_recebimento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_comissao_recebimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_comissao_recebimento.ForeColor = System.Drawing.Color.Blue;
            this.bt_comissao_recebimento.Location = new System.Drawing.Point(1160, 71);
            this.bt_comissao_recebimento.Name = "bt_comissao_recebimento";
            this.bt_comissao_recebimento.Size = new System.Drawing.Size(112, 49);
            this.bt_comissao_recebimento.TabIndex = 308;
            this.bt_comissao_recebimento.Text = "Vendedor X Produtos X Comissao por Recebimento\r\n";
            this.bt_comissao_recebimento.UseVisualStyleBackColor = true;
            this.bt_comissao_recebimento.Click += new System.EventHandler(this.button29_Click);
            // 
            // button32
            // 
            this.button32.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button32.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button32.ForeColor = System.Drawing.Color.Blue;
            this.button32.Location = new System.Drawing.Point(780, 181);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(89, 49);
            this.button32.TabIndex = 314;
            this.button32.Text = "Clientes Não Atendidos";
            this.button32.UseVisualStyleBackColor = true;
            this.button32.Click += new System.EventHandler(this.button32_Click);
            // 
            // button31
            // 
            this.button31.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button31.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button31.ForeColor = System.Drawing.Color.Blue;
            this.button31.Location = new System.Drawing.Point(685, 181);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(89, 49);
            this.button31.TabIndex = 313;
            this.button31.Text = "Ultima Compra";
            this.button31.UseVisualStyleBackColor = true;
            this.button31.Click += new System.EventHandler(this.button31_Click);
            // 
            // button30
            // 
            this.button30.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button30.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button30.ForeColor = System.Drawing.Color.Blue;
            this.button30.Location = new System.Drawing.Point(590, 181);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(89, 49);
            this.button30.TabIndex = 312;
            this.button30.Text = "Vendedor X NFs  X Produtos";
            this.button30.UseVisualStyleBackColor = true;
            this.button30.Click += new System.EventHandler(this.button30_Click);
            // 
            // button34
            // 
            this.button34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button34.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button34.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.button34.ForeColor = System.Drawing.Color.Blue;
            this.button34.Location = new System.Drawing.Point(685, 290);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(89, 47);
            this.button34.TabIndex = 316;
            this.button34.Text = "Personalizada";
            this.button34.UseVisualStyleBackColor = false;
            this.button34.Click += new System.EventHandler(this.button34_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.tb_cod_pesquisa);
            this.groupBox8.Controls.Add(this.cb_Personalizada);
            this.groupBox8.Controls.Add(this.tb_descricao_pesquisa);
            this.groupBox8.Controls.Add(this.button33);
            this.groupBox8.Location = new System.Drawing.Point(420, 295);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(253, 39);
            this.groupBox8.TabIndex = 315;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Pesquisa Personalizada";
            // 
            // tb_cod_pesquisa
            // 
            this.tb_cod_pesquisa.BackColor = System.Drawing.SystemColors.Control;
            this.tb_cod_pesquisa.Enabled = false;
            this.tb_cod_pesquisa.Location = new System.Drawing.Point(12, 13);
            this.tb_cod_pesquisa.Name = "tb_cod_pesquisa";
            this.tb_cod_pesquisa.Size = new System.Drawing.Size(41, 20);
            this.tb_cod_pesquisa.TabIndex = 0;
            // 
            // cb_Personalizada
            // 
            this.cb_Personalizada.AutoSize = true;
            this.cb_Personalizada.Location = new System.Drawing.Point(232, 16);
            this.cb_Personalizada.Name = "cb_Personalizada";
            this.cb_Personalizada.Size = new System.Drawing.Size(15, 14);
            this.cb_Personalizada.TabIndex = 282;
            this.cb_Personalizada.UseVisualStyleBackColor = true;
            // 
            // tb_descricao_pesquisa
            // 
            this.tb_descricao_pesquisa.BackColor = System.Drawing.SystemColors.Control;
            this.tb_descricao_pesquisa.Enabled = false;
            this.tb_descricao_pesquisa.Location = new System.Drawing.Point(59, 13);
            this.tb_descricao_pesquisa.Name = "tb_descricao_pesquisa";
            this.tb_descricao_pesquisa.Size = new System.Drawing.Size(121, 20);
            this.tb_descricao_pesquisa.TabIndex = 1;
            // 
            // button33
            // 
            this.button33.Location = new System.Drawing.Point(186, 11);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(23, 23);
            this.button33.TabIndex = 279;
            this.button33.Text = "+";
            this.button33.UseVisualStyleBackColor = true;
            this.button33.Click += new System.EventHandler(this.button33_Click);
            // 
            // button10
            // 
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.Blue;
            this.button10.Location = new System.Drawing.Point(1065, 289);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(89, 49);
            this.button10.TabIndex = 317;
            this.button10.Text = "Famílias";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Visible = false;
            this.button10.Click += new System.EventHandler(this.button10_Click_1);
            // 
            // button12
            // 
            this.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.Color.Blue;
            this.button12.Location = new System.Drawing.Point(970, 290);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(89, 49);
            this.button12.TabIndex = 318;
            this.button12.Text = "Grupos";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Visible = false;
            this.button12.Click += new System.EventHandler(this.button12_Click_1);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.tbCodGrupo);
            this.groupBox9.Controls.Add(this.cbGrupo);
            this.groupBox9.Controls.Add(this.tbGrupo);
            this.groupBox9.Controls.Add(this.button14);
            this.groupBox9.Location = new System.Drawing.Point(140, 254);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(253, 39);
            this.groupBox9.TabIndex = 319;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Grupo";
            // 
            // tbCodGrupo
            // 
            this.tbCodGrupo.BackColor = System.Drawing.SystemColors.Control;
            this.tbCodGrupo.Enabled = false;
            this.tbCodGrupo.Location = new System.Drawing.Point(12, 13);
            this.tbCodGrupo.Name = "tbCodGrupo";
            this.tbCodGrupo.Size = new System.Drawing.Size(41, 20);
            this.tbCodGrupo.TabIndex = 0;
            // 
            // cbGrupo
            // 
            this.cbGrupo.AutoSize = true;
            this.cbGrupo.Location = new System.Drawing.Point(232, 16);
            this.cbGrupo.Name = "cbGrupo";
            this.cbGrupo.Size = new System.Drawing.Size(15, 14);
            this.cbGrupo.TabIndex = 282;
            this.cbGrupo.UseVisualStyleBackColor = true;
            // 
            // tbGrupo
            // 
            this.tbGrupo.BackColor = System.Drawing.SystemColors.Control;
            this.tbGrupo.Enabled = false;
            this.tbGrupo.Location = new System.Drawing.Point(59, 13);
            this.tbGrupo.Name = "tbGrupo";
            this.tbGrupo.Size = new System.Drawing.Size(121, 20);
            this.tbGrupo.TabIndex = 1;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(186, 11);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(23, 23);
            this.button14.TabIndex = 279;
            this.button14.Text = "+";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click_1);
            // 
            // button15
            // 
            this.button15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.ForeColor = System.Drawing.Color.Blue;
            this.button15.Location = new System.Drawing.Point(590, 236);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(89, 49);
            this.button15.TabIndex = 320;
            this.button15.Text = "Vendedor x Fornecedores Positivação";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click_1);
            // 
            // bt_cliente_lucra_custo
            // 
            this.bt_cliente_lucra_custo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_cliente_lucra_custo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cliente_lucra_custo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_cliente_lucra_custo.Location = new System.Drawing.Point(875, 181);
            this.bt_cliente_lucra_custo.Name = "bt_cliente_lucra_custo";
            this.bt_cliente_lucra_custo.Size = new System.Drawing.Size(89, 62);
            this.bt_cliente_lucra_custo.TabIndex = 321;
            this.bt_cliente_lucra_custo.Text = "Clientes X Lucratividade X Troca + Devol. CUSTO";
            this.bt_cliente_lucra_custo.UseVisualStyleBackColor = true;
            this.bt_cliente_lucra_custo.Click += new System.EventHandler(this.button27_Click_1);
            // 
            // button29
            // 
            this.button29.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button29.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button29.ForeColor = System.Drawing.Color.Red;
            this.button29.Location = new System.Drawing.Point(970, 235);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(89, 49);
            this.button29.TabIndex = 322;
            this.button29.Text = "Motivos de Não Venda";
            this.button29.UseVisualStyleBackColor = true;
            this.button29.Click += new System.EventHandler(this.button29_Click_1);
            // 
            // button35
            // 
            this.button35.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button35.Location = new System.Drawing.Point(1183, 236);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(89, 48);
            this.button35.TabIndex = 323;
            this.button35.Text = "Vendedor X Produtos X PDV";
            this.button35.UseVisualStyleBackColor = true;
            this.button35.Click += new System.EventHandler(this.button35_Click);
            // 
            // button36
            // 
            this.button36.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button36.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button36.ForeColor = System.Drawing.Color.Blue;
            this.button36.Location = new System.Drawing.Point(685, 236);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(89, 49);
            this.button36.TabIndex = 324;
            this.button36.Text = "Vendedor X Positivação";
            this.button36.UseVisualStyleBackColor = true;
            this.button36.Click += new System.EventHandler(this.button36_Click);
            // 
            // button37
            // 
            this.button37.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button37.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button37.ForeColor = System.Drawing.Color.Blue;
            this.button37.Location = new System.Drawing.Point(970, 181);
            this.button37.Name = "button37";
            this.button37.Size = new System.Drawing.Size(89, 49);
            this.button37.TabIndex = 325;
            this.button37.Text = "Vendedor X Clientes por Pedido";
            this.button37.UseVisualStyleBackColor = true;
            this.button37.Click += new System.EventHandler(this.button37_Click);
            // 
            // bt_vend_lucra_custo
            // 
            this.bt_vend_lucra_custo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_vend_lucra_custo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_vend_lucra_custo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_vend_lucra_custo.Location = new System.Drawing.Point(1065, 236);
            this.bt_vend_lucra_custo.Name = "bt_vend_lucra_custo";
            this.bt_vend_lucra_custo.Size = new System.Drawing.Size(112, 48);
            this.bt_vend_lucra_custo.TabIndex = 326;
            this.bt_vend_lucra_custo.Text = "Vendedor X Lucratividade X Troca + Devol. CUSTO";
            this.bt_vend_lucra_custo.UseVisualStyleBackColor = true;
            this.bt_vend_lucra_custo.Click += new System.EventHandler(this.button38_Click);
            // 
            // button39
            // 
            this.button39.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button39.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button39.ForeColor = System.Drawing.Color.Blue;
            this.button39.Location = new System.Drawing.Point(780, 236);
            this.button39.Name = "button39";
            this.button39.Size = new System.Drawing.Size(89, 49);
            this.button39.TabIndex = 327;
            this.button39.Text = "Produtos Não Vendidos";
            this.button39.UseVisualStyleBackColor = true;
            this.button39.Click += new System.EventHandler(this.button39_Click);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.tbcodSubgrupo);
            this.groupBox10.Controls.Add(this.cbSubGrupo);
            this.groupBox10.Controls.Add(this.tbdescricaoSubgrupo);
            this.groupBox10.Controls.Add(this.button27);
            this.groupBox10.Location = new System.Drawing.Point(140, 294);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(253, 39);
            this.groupBox10.TabIndex = 328;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Sub-Grupo";
            // 
            // tbcodSubgrupo
            // 
            this.tbcodSubgrupo.BackColor = System.Drawing.SystemColors.Control;
            this.tbcodSubgrupo.Enabled = false;
            this.tbcodSubgrupo.Location = new System.Drawing.Point(12, 13);
            this.tbcodSubgrupo.Name = "tbcodSubgrupo";
            this.tbcodSubgrupo.Size = new System.Drawing.Size(41, 20);
            this.tbcodSubgrupo.TabIndex = 0;
            // 
            // cbSubGrupo
            // 
            this.cbSubGrupo.AutoSize = true;
            this.cbSubGrupo.Location = new System.Drawing.Point(232, 16);
            this.cbSubGrupo.Name = "cbSubGrupo";
            this.cbSubGrupo.Size = new System.Drawing.Size(15, 14);
            this.cbSubGrupo.TabIndex = 282;
            this.cbSubGrupo.UseVisualStyleBackColor = true;
            // 
            // tbdescricaoSubgrupo
            // 
            this.tbdescricaoSubgrupo.BackColor = System.Drawing.SystemColors.Control;
            this.tbdescricaoSubgrupo.Enabled = false;
            this.tbdescricaoSubgrupo.Location = new System.Drawing.Point(59, 13);
            this.tbdescricaoSubgrupo.Name = "tbdescricaoSubgrupo";
            this.tbdescricaoSubgrupo.Size = new System.Drawing.Size(121, 20);
            this.tbdescricaoSubgrupo.TabIndex = 1;
            // 
            // button27
            // 
            this.button27.Location = new System.Drawing.Point(186, 11);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(23, 23);
            this.button27.TabIndex = 279;
            this.button27.Text = "+";
            this.button27.UseVisualStyleBackColor = true;
            this.button27.Click += new System.EventHandler(this.button27_Click_2);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.tb_cod_matriz);
            this.groupBox11.Controls.Add(this.checkBox1);
            this.groupBox11.Controls.Add(this.tb_razao_matriz);
            this.groupBox11.Controls.Add(this.button38);
            this.groupBox11.Location = new System.Drawing.Point(140, 92);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(253, 39);
            this.groupBox11.TabIndex = 329;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Matriz/Rede";
            // 
            // tb_cod_matriz
            // 
            this.tb_cod_matriz.BackColor = System.Drawing.SystemColors.Control;
            this.tb_cod_matriz.Enabled = false;
            this.tb_cod_matriz.Location = new System.Drawing.Point(12, 14);
            this.tb_cod_matriz.Name = "tb_cod_matriz";
            this.tb_cod_matriz.Size = new System.Drawing.Size(41, 20);
            this.tb_cod_matriz.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(232, 16);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 282;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // tb_razao_matriz
            // 
            this.tb_razao_matriz.BackColor = System.Drawing.SystemColors.Control;
            this.tb_razao_matriz.Enabled = false;
            this.tb_razao_matriz.Location = new System.Drawing.Point(59, 13);
            this.tb_razao_matriz.Name = "tb_razao_matriz";
            this.tb_razao_matriz.Size = new System.Drawing.Size(121, 20);
            this.tb_razao_matriz.TabIndex = 1;
            // 
            // button38
            // 
            this.button38.Location = new System.Drawing.Point(186, 11);
            this.button38.Name = "button38";
            this.button38.Size = new System.Drawing.Size(23, 23);
            this.button38.TabIndex = 279;
            this.button38.Text = "+";
            this.button38.UseVisualStyleBackColor = true;
            this.button38.Click += new System.EventHandler(this.button38_Click_1);
            // 
            // button40
            // 
            this.button40.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button40.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button40.ForeColor = System.Drawing.Color.Blue;
            this.button40.Location = new System.Drawing.Point(1160, 126);
            this.button40.Name = "button40";
            this.button40.Size = new System.Drawing.Size(112, 49);
            this.button40.TabIndex = 330;
            this.button40.Text = "Vendedor X Produtos X Comissao por Tabela de Preço";
            this.button40.UseVisualStyleBackColor = true;
            this.button40.Click += new System.EventHandler(this.button40_Click);
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.checkBox2);
            this.groupBox12.Controls.Add(this.txtNomeSupervisor);
            this.groupBox12.Controls.Add(this.txtCodSupervisor);
            this.groupBox12.Controls.Add(this.button41);
            this.groupBox12.Location = new System.Drawing.Point(140, 340);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(253, 39);
            this.groupBox12.TabIndex = 331;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Supervisor";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(232, 16);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 282;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // txtNomeSupervisor
            // 
            this.txtNomeSupervisor.BackColor = System.Drawing.SystemColors.Control;
            this.txtNomeSupervisor.Location = new System.Drawing.Point(59, 13);
            this.txtNomeSupervisor.Name = "txtNomeSupervisor";
            this.txtNomeSupervisor.Size = new System.Drawing.Size(121, 20);
            this.txtNomeSupervisor.TabIndex = 1;
            // 
            // txtCodSupervisor
            // 
            this.txtCodSupervisor.BackColor = System.Drawing.SystemColors.Control;
            this.txtCodSupervisor.Enabled = false;
            this.txtCodSupervisor.Location = new System.Drawing.Point(12, 13);
            this.txtCodSupervisor.Name = "txtCodSupervisor";
            this.txtCodSupervisor.Size = new System.Drawing.Size(41, 20);
            this.txtCodSupervisor.TabIndex = 0;
            // 
            // button41
            // 
            this.button41.Location = new System.Drawing.Point(186, 11);
            this.button41.Name = "button41";
            this.button41.Size = new System.Drawing.Size(23, 23);
            this.button41.TabIndex = 279;
            this.button41.Text = "+";
            this.button41.UseVisualStyleBackColor = true;
            this.button41.Click += new System.EventHandler(this.button41_Click);
            // 
            // button42
            // 
            this.button42.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button42.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button42.ForeColor = System.Drawing.Color.Blue;
            this.button42.Location = new System.Drawing.Point(1160, 181);
            this.button42.Name = "button42";
            this.button42.Size = new System.Drawing.Size(112, 49);
            this.button42.TabIndex = 332;
            this.button42.Text = "Vendedor X Produtos X Comissao por Tabela de Preço e Supervisor";
            this.button42.UseVisualStyleBackColor = true;
            this.button42.Click += new System.EventHandler(this.button42_Click);
            // 
            // button43
            // 
            this.button43.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button43.Location = new System.Drawing.Point(1183, 286);
            this.button43.Name = "button43";
            this.button43.Size = new System.Drawing.Size(89, 48);
            this.button43.TabIndex = 333;
            this.button43.Text = "Vendedor X Fornecedores X PDV";
            this.button43.UseVisualStyleBackColor = true;
            this.button43.Click += new System.EventHandler(this.button43_Click);
            // 
            // button44
            // 
            this.button44.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button44.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button44.ForeColor = System.Drawing.Color.Blue;
            this.button44.Location = new System.Drawing.Point(875, 244);
            this.button44.Name = "button44";
            this.button44.Size = new System.Drawing.Size(89, 40);
            this.button44.TabIndex = 334;
            this.button44.Text = "Saldo Flex";
            this.button44.UseVisualStyleBackColor = true;
            this.button44.Click += new System.EventHandler(this.button44_Click);
            // 
            // button45
            // 
            this.button45.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button45.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button45.ForeColor = System.Drawing.Color.Blue;
            this.button45.Location = new System.Drawing.Point(875, 290);
            this.button45.Name = "button45";
            this.button45.Size = new System.Drawing.Size(89, 49);
            this.button45.TabIndex = 335;
            this.button45.Text = "Fornecedores";
            this.button45.UseVisualStyleBackColor = true;
            this.button45.Visible = false;
            this.button45.Click += new System.EventHandler(this.button45_Click);
            // 
            // form_pesquisa_comissao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 611);
            this.Controls.Add(this.button45);
            this.Controls.Add(this.button44);
            this.Controls.Add(this.button43);
            this.Controls.Add(this.button42);
            this.Controls.Add(this.groupBox12);
            this.Controls.Add(this.button40);
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.button39);
            this.Controls.Add(this.bt_vend_lucra_custo);
            this.Controls.Add(this.button37);
            this.Controls.Add(this.button36);
            this.Controls.Add(this.button35);
            this.Controls.Add(this.button29);
            this.Controls.Add(this.bt_cliente_lucra_custo);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button34);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.button32);
            this.Controls.Add(this.button31);
            this.Controls.Add(this.button30);
            this.Controls.Add(this.bt_comissao_recebimento);
            this.Controls.Add(this.button28);
            this.Controls.Add(this.bt_clientes_lucratividade);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.tb_cnpj);
            this.Controls.Add(this.btnVPC);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.cbApenas_troca);
            this.Controls.Add(this.bt_cli_lucratividade);
            this.Controls.Add(this.bt_nfs_lucratividade);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.bt_prod_lucratividade);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.bt_comissao_produto);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_diferenca_total);
            this.Controls.Add(this.cb_com_pis);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbxImpDetalhada);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_valor_total);
            this.Controls.Add(this.dgvPedidos);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_pesquisa_comissao";
            this.Text = "Vendas por Vendedor";
            this.Load += new System.EventHandler(this.form_pesquisa_comissao_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsPedidos_venda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PEDIDOS_VENDA)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EMPRESA)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
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
        private FirebirdSql.Data.FirebirdClient.FbCommand comando_select;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tb_nome_vendedor;
        private System.Windows.Forms.TextBox tb_cod_vendedor;
        private System.Windows.Forms.Button btnAddVendedor;
        private System.Windows.Forms.CheckBox cb_vendedor;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cb_cliente;
        private System.Windows.Forms.TextBox tb_nome_cliente;
        private System.Windows.Forms.Button btnAddCliente;
        private System.Windows.Forms.Button button6;
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
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox cb_fornecedor;
        private System.Windows.Forms.TextBox tb_nome_fornecedor;
        private System.Windows.Forms.Button btnAddFornecedores;
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
        private System.Windows.Forms.TextBox tb_cod_cliente;
        private System.Windows.Forms.TextBox tb_cod_fornecedor;
        private System.Windows.Forms.CheckBox cbxImpDetalhada;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.CheckBox cb_com_pis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_diferenca_total;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tb_cod_produto;
        private System.Windows.Forms.CheckBox cbProduto;
        private System.Windows.Forms.TextBox tb_nome_produto;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button bt_comissao_produto;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button bt_prod_lucratividade;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox cbCfop;
        private System.Windows.Forms.TextBox tb_n_cfop;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button bt_nfs_lucratividade;
        private System.Windows.Forms.Button bt_cli_lucratividade;
        private System.Windows.Forms.CheckBox cbApenas_troca;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button btnVPC;
        private System.Windows.Forms.TextBox tb_cnpj;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox tbCodFamilia;
        private System.Windows.Forms.CheckBox cbFamilia;
        private System.Windows.Forms.TextBox tbFamilia;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button bt_clientes_lucratividade;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button bt_comissao_recebimento;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox tb_cod_pesquisa;
        private System.Windows.Forms.CheckBox cb_Personalizada;
        private System.Windows.Forms.TextBox tb_descricao_pesquisa;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox tbCodGrupo;
        private System.Windows.Forms.CheckBox cbGrupo;
        private System.Windows.Forms.TextBox tbGrupo;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button bt_cliente_lucra_custo;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button35;
        private System.Windows.Forms.Button button36;
        private System.Windows.Forms.Button button37;
        private System.Windows.Forms.Button bt_vend_lucra_custo;
        private System.Windows.Forms.Button button39;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TextBox tbcodSubgrupo;
        private System.Windows.Forms.CheckBox cbSubGrupo;
        private System.Windows.Forms.TextBox tbdescricaoSubgrupo;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.TextBox tb_cod_matriz;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox tb_razao_matriz;
        private System.Windows.Forms.Button button38;
        private System.Windows.Forms.Button button40;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox txtNomeSupervisor;
        private System.Windows.Forms.TextBox txtCodSupervisor;
        private System.Windows.Forms.Button button41;
        private System.Windows.Forms.Button button42;
        private System.Windows.Forms.Button button43;
        private System.Windows.Forms.Button button44;
        private System.Windows.Forms.Button button45;
    }
}