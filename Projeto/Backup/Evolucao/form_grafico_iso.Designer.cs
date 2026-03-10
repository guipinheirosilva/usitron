namespace Evolucao
{
    partial class form_grafico_iso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_grafico_iso));
            this.datDesenhos = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
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
            this.DESPESAS_PROJETO_MOLDE = new System.Data.DataColumn();
            this.dgvDesenhos = new System.Windows.Forms.DataGridView();
            this.cODPECADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOSPECADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEVISAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mATERIALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSPESSURADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rOTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMEPECADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nSUBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nROTASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOSICAOPECADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fUNCAOPECADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAENTREGAPECADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oBSPECADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROJETISTAPECADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESPESASMOLDEDESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rECEITASMOLDEDESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORASPREVTORNOMOLDEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORASPREVFRESAMOLDEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORASPREVCNCDESMOLDEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORASPREVTEMPERAMOLDEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORASPREVRETIFICAMOLDEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORASPREVCNCACABMOLDEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORASPREVEROSAOEDMMOLDEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORASPREVEROSAOEWCMOLDEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORASPREVPOLIMENTOMOLDEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORASPREVPROJETOMOLDEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORASPREVPORTAMOLDEMOLDEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORASPREVELETRODOMOLDEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORASEXECTORNOMOLDEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORASEXECFRESAMOLDEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORASEXECCNCDESMOLDEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORASEXECTEMPERAMOLDEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORASEXECRETIFICAMOLDEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORASEXECCNCACABMOLDEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORASEXECEROSAOEDMMOLDEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORASEXECEROSAOEWCMOLDEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORASEXECPOLIMENTOMOLDEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORASEXECPROJETOMOLDEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORASEXECPORTAMOLDEMOLDEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORASEXECELETRODOMOLDEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORASEXECDESPCELETMOLDEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESPESASPROJETOMOLDEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label20 = new System.Windows.Forms.Label();
            this.tb_mes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_ano = new System.Windows.Forms.TextBox();
            this.bt_ok = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_total_prev = new System.Windows.Forms.TextBox();
            this.label59 = new System.Windows.Forms.Label();
            this.tb_total_trab = new System.Windows.Forms.TextBox();
            this.label58 = new System.Windows.Forms.Label();
            this.bt_grafico = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_meta_iso = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dsDesenhos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DESENHOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDesenhos)).BeginInit();
            this.SuspendLayout();
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
            this.DESPESAS_PROJETO_MOLDE});
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
            // DESPESAS_PROJETO_MOLDE
            // 
            this.DESPESAS_PROJETO_MOLDE.ColumnName = "DESPESAS_PROJETO_MOLDE";
            this.DESPESAS_PROJETO_MOLDE.DataType = typeof(double);
            // 
            // dgvDesenhos
            // 
            this.dgvDesenhos.AutoGenerateColumns = false;
            this.dgvDesenhos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDesenhos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODPECADataGridViewTextBoxColumn,
            this.nOSPECADataGridViewTextBoxColumn,
            this.rEVISAODataGridViewTextBoxColumn,
            this.mATERIALDataGridViewTextBoxColumn,
            this.eSPESSURADataGridViewTextBoxColumn,
            this.cLIENTEDataGridViewTextBoxColumn,
            this.rOTADataGridViewTextBoxColumn,
            this.nOMEPECADataGridViewTextBoxColumn,
            this.nSUBDataGridViewTextBoxColumn,
            this.nROTASDataGridViewTextBoxColumn,
            this.pOSICAOPECADataGridViewTextBoxColumn,
            this.fUNCAOPECADataGridViewTextBoxColumn,
            this.dATAENTREGAPECADataGridViewTextBoxColumn,
            this.oBSPECADataGridViewTextBoxColumn,
            this.pROJETISTAPECADataGridViewTextBoxColumn,
            this.dESPESASMOLDEDESDataGridViewTextBoxColumn,
            this.rECEITASMOLDEDESDataGridViewTextBoxColumn,
            this.hORASPREVTORNOMOLDEDataGridViewTextBoxColumn,
            this.hORASPREVFRESAMOLDEDataGridViewTextBoxColumn,
            this.hORASPREVCNCDESMOLDEDataGridViewTextBoxColumn,
            this.hORASPREVTEMPERAMOLDEDataGridViewTextBoxColumn,
            this.hORASPREVRETIFICAMOLDEDataGridViewTextBoxColumn,
            this.hORASPREVCNCACABMOLDEDataGridViewTextBoxColumn,
            this.hORASPREVEROSAOEDMMOLDEDataGridViewTextBoxColumn,
            this.hORASPREVEROSAOEWCMOLDEDataGridViewTextBoxColumn,
            this.hORASPREVPOLIMENTOMOLDEDataGridViewTextBoxColumn,
            this.hORASPREVPROJETOMOLDEDataGridViewTextBoxColumn,
            this.hORASPREVPORTAMOLDEMOLDEDataGridViewTextBoxColumn,
            this.hORASPREVELETRODOMOLDEDataGridViewTextBoxColumn,
            this.hORASEXECTORNOMOLDEDataGridViewTextBoxColumn,
            this.hORASEXECFRESAMOLDEDataGridViewTextBoxColumn,
            this.hORASEXECCNCDESMOLDEDataGridViewTextBoxColumn,
            this.hORASEXECTEMPERAMOLDEDataGridViewTextBoxColumn,
            this.hORASEXECRETIFICAMOLDEDataGridViewTextBoxColumn,
            this.hORASEXECCNCACABMOLDEDataGridViewTextBoxColumn,
            this.hORASEXECEROSAOEDMMOLDEDataGridViewTextBoxColumn,
            this.hORASEXECEROSAOEWCMOLDEDataGridViewTextBoxColumn,
            this.hORASEXECPOLIMENTOMOLDEDataGridViewTextBoxColumn,
            this.hORASEXECPROJETOMOLDEDataGridViewTextBoxColumn,
            this.hORASEXECPORTAMOLDEMOLDEDataGridViewTextBoxColumn,
            this.hORASEXECELETRODOMOLDEDataGridViewTextBoxColumn,
            this.hORASEXECDESPCELETMOLDEDataGridViewTextBoxColumn,
            this.dESPESASPROJETOMOLDEDataGridViewTextBoxColumn});
            this.dgvDesenhos.DataMember = "DESENHOS";
            this.dgvDesenhos.DataSource = this.dsDesenhos;
            this.dgvDesenhos.Location = new System.Drawing.Point(28, 148);
            this.dgvDesenhos.Name = "dgvDesenhos";
            this.dgvDesenhos.Size = new System.Drawing.Size(928, 314);
            this.dgvDesenhos.TabIndex = 0;
            // 
            // cODPECADataGridViewTextBoxColumn
            // 
            this.cODPECADataGridViewTextBoxColumn.DataPropertyName = "COD_PECA";
            this.cODPECADataGridViewTextBoxColumn.HeaderText = "COD_PECA";
            this.cODPECADataGridViewTextBoxColumn.Name = "cODPECADataGridViewTextBoxColumn";
            // 
            // nOSPECADataGridViewTextBoxColumn
            // 
            this.nOSPECADataGridViewTextBoxColumn.DataPropertyName = "N_OS_PECA";
            this.nOSPECADataGridViewTextBoxColumn.HeaderText = "N_OS_PECA";
            this.nOSPECADataGridViewTextBoxColumn.Name = "nOSPECADataGridViewTextBoxColumn";
            // 
            // rEVISAODataGridViewTextBoxColumn
            // 
            this.rEVISAODataGridViewTextBoxColumn.DataPropertyName = "REVISAO";
            this.rEVISAODataGridViewTextBoxColumn.HeaderText = "REVISAO";
            this.rEVISAODataGridViewTextBoxColumn.Name = "rEVISAODataGridViewTextBoxColumn";
            // 
            // mATERIALDataGridViewTextBoxColumn
            // 
            this.mATERIALDataGridViewTextBoxColumn.DataPropertyName = "MATERIAL";
            this.mATERIALDataGridViewTextBoxColumn.HeaderText = "MATERIAL";
            this.mATERIALDataGridViewTextBoxColumn.Name = "mATERIALDataGridViewTextBoxColumn";
            // 
            // eSPESSURADataGridViewTextBoxColumn
            // 
            this.eSPESSURADataGridViewTextBoxColumn.DataPropertyName = "ESPESSURA";
            this.eSPESSURADataGridViewTextBoxColumn.HeaderText = "ESPESSURA";
            this.eSPESSURADataGridViewTextBoxColumn.Name = "eSPESSURADataGridViewTextBoxColumn";
            // 
            // cLIENTEDataGridViewTextBoxColumn
            // 
            this.cLIENTEDataGridViewTextBoxColumn.DataPropertyName = "CLIENTE";
            this.cLIENTEDataGridViewTextBoxColumn.HeaderText = "CLIENTE";
            this.cLIENTEDataGridViewTextBoxColumn.Name = "cLIENTEDataGridViewTextBoxColumn";
            // 
            // rOTADataGridViewTextBoxColumn
            // 
            this.rOTADataGridViewTextBoxColumn.DataPropertyName = "ROTA";
            this.rOTADataGridViewTextBoxColumn.HeaderText = "ROTA";
            this.rOTADataGridViewTextBoxColumn.Name = "rOTADataGridViewTextBoxColumn";
            // 
            // nOMEPECADataGridViewTextBoxColumn
            // 
            this.nOMEPECADataGridViewTextBoxColumn.DataPropertyName = "NOME_PECA";
            this.nOMEPECADataGridViewTextBoxColumn.HeaderText = "NOME_PECA";
            this.nOMEPECADataGridViewTextBoxColumn.Name = "nOMEPECADataGridViewTextBoxColumn";
            // 
            // nSUBDataGridViewTextBoxColumn
            // 
            this.nSUBDataGridViewTextBoxColumn.DataPropertyName = "N_SUB";
            this.nSUBDataGridViewTextBoxColumn.HeaderText = "N_SUB";
            this.nSUBDataGridViewTextBoxColumn.Name = "nSUBDataGridViewTextBoxColumn";
            // 
            // nROTASDataGridViewTextBoxColumn
            // 
            this.nROTASDataGridViewTextBoxColumn.DataPropertyName = "N_ROTAS";
            this.nROTASDataGridViewTextBoxColumn.HeaderText = "N_ROTAS";
            this.nROTASDataGridViewTextBoxColumn.Name = "nROTASDataGridViewTextBoxColumn";
            // 
            // pOSICAOPECADataGridViewTextBoxColumn
            // 
            this.pOSICAOPECADataGridViewTextBoxColumn.DataPropertyName = "POSICAO_PECA";
            this.pOSICAOPECADataGridViewTextBoxColumn.HeaderText = "POSICAO_PECA";
            this.pOSICAOPECADataGridViewTextBoxColumn.Name = "pOSICAOPECADataGridViewTextBoxColumn";
            // 
            // fUNCAOPECADataGridViewTextBoxColumn
            // 
            this.fUNCAOPECADataGridViewTextBoxColumn.DataPropertyName = "FUNCAO_PECA";
            this.fUNCAOPECADataGridViewTextBoxColumn.HeaderText = "FUNCAO_PECA";
            this.fUNCAOPECADataGridViewTextBoxColumn.Name = "fUNCAOPECADataGridViewTextBoxColumn";
            // 
            // dATAENTREGAPECADataGridViewTextBoxColumn
            // 
            this.dATAENTREGAPECADataGridViewTextBoxColumn.DataPropertyName = "DATA_ENTREGA_PECA";
            this.dATAENTREGAPECADataGridViewTextBoxColumn.HeaderText = "DATA_ENTREGA_PECA";
            this.dATAENTREGAPECADataGridViewTextBoxColumn.Name = "dATAENTREGAPECADataGridViewTextBoxColumn";
            // 
            // oBSPECADataGridViewTextBoxColumn
            // 
            this.oBSPECADataGridViewTextBoxColumn.DataPropertyName = "OBS_PECA";
            this.oBSPECADataGridViewTextBoxColumn.HeaderText = "OBS_PECA";
            this.oBSPECADataGridViewTextBoxColumn.Name = "oBSPECADataGridViewTextBoxColumn";
            // 
            // pROJETISTAPECADataGridViewTextBoxColumn
            // 
            this.pROJETISTAPECADataGridViewTextBoxColumn.DataPropertyName = "PROJETISTA_PECA";
            this.pROJETISTAPECADataGridViewTextBoxColumn.HeaderText = "PROJETISTA_PECA";
            this.pROJETISTAPECADataGridViewTextBoxColumn.Name = "pROJETISTAPECADataGridViewTextBoxColumn";
            // 
            // dESPESASMOLDEDESDataGridViewTextBoxColumn
            // 
            this.dESPESASMOLDEDESDataGridViewTextBoxColumn.DataPropertyName = "DESPESAS_MOLDE_DES";
            this.dESPESASMOLDEDESDataGridViewTextBoxColumn.HeaderText = "DESPESAS_MOLDE_DES";
            this.dESPESASMOLDEDESDataGridViewTextBoxColumn.Name = "dESPESASMOLDEDESDataGridViewTextBoxColumn";
            // 
            // rECEITASMOLDEDESDataGridViewTextBoxColumn
            // 
            this.rECEITASMOLDEDESDataGridViewTextBoxColumn.DataPropertyName = "RECEITAS_MOLDE_DES";
            this.rECEITASMOLDEDESDataGridViewTextBoxColumn.HeaderText = "RECEITAS_MOLDE_DES";
            this.rECEITASMOLDEDESDataGridViewTextBoxColumn.Name = "rECEITASMOLDEDESDataGridViewTextBoxColumn";
            // 
            // hORASPREVTORNOMOLDEDataGridViewTextBoxColumn
            // 
            this.hORASPREVTORNOMOLDEDataGridViewTextBoxColumn.DataPropertyName = "HORAS_PREV_TORNO_MOLDE";
            this.hORASPREVTORNOMOLDEDataGridViewTextBoxColumn.HeaderText = "HORAS_PREV_TORNO_MOLDE";
            this.hORASPREVTORNOMOLDEDataGridViewTextBoxColumn.Name = "hORASPREVTORNOMOLDEDataGridViewTextBoxColumn";
            // 
            // hORASPREVFRESAMOLDEDataGridViewTextBoxColumn
            // 
            this.hORASPREVFRESAMOLDEDataGridViewTextBoxColumn.DataPropertyName = "HORAS_PREV_FRESA_MOLDE";
            this.hORASPREVFRESAMOLDEDataGridViewTextBoxColumn.HeaderText = "HORAS_PREV_FRESA_MOLDE";
            this.hORASPREVFRESAMOLDEDataGridViewTextBoxColumn.Name = "hORASPREVFRESAMOLDEDataGridViewTextBoxColumn";
            // 
            // hORASPREVCNCDESMOLDEDataGridViewTextBoxColumn
            // 
            this.hORASPREVCNCDESMOLDEDataGridViewTextBoxColumn.DataPropertyName = "HORAS_PREV_CNC_DES_MOLDE";
            this.hORASPREVCNCDESMOLDEDataGridViewTextBoxColumn.HeaderText = "HORAS_PREV_CNC_DES_MOLDE";
            this.hORASPREVCNCDESMOLDEDataGridViewTextBoxColumn.Name = "hORASPREVCNCDESMOLDEDataGridViewTextBoxColumn";
            // 
            // hORASPREVTEMPERAMOLDEDataGridViewTextBoxColumn
            // 
            this.hORASPREVTEMPERAMOLDEDataGridViewTextBoxColumn.DataPropertyName = "HORAS_PREV_TEMPERA_MOLDE";
            this.hORASPREVTEMPERAMOLDEDataGridViewTextBoxColumn.HeaderText = "HORAS_PREV_TEMPERA_MOLDE";
            this.hORASPREVTEMPERAMOLDEDataGridViewTextBoxColumn.Name = "hORASPREVTEMPERAMOLDEDataGridViewTextBoxColumn";
            // 
            // hORASPREVRETIFICAMOLDEDataGridViewTextBoxColumn
            // 
            this.hORASPREVRETIFICAMOLDEDataGridViewTextBoxColumn.DataPropertyName = "HORAS_PREV_RETIFICA_MOLDE";
            this.hORASPREVRETIFICAMOLDEDataGridViewTextBoxColumn.HeaderText = "HORAS_PREV_RETIFICA_MOLDE";
            this.hORASPREVRETIFICAMOLDEDataGridViewTextBoxColumn.Name = "hORASPREVRETIFICAMOLDEDataGridViewTextBoxColumn";
            // 
            // hORASPREVCNCACABMOLDEDataGridViewTextBoxColumn
            // 
            this.hORASPREVCNCACABMOLDEDataGridViewTextBoxColumn.DataPropertyName = "HORAS_PREV_CNC_ACAB_MOLDE";
            this.hORASPREVCNCACABMOLDEDataGridViewTextBoxColumn.HeaderText = "HORAS_PREV_CNC_ACAB_MOLDE";
            this.hORASPREVCNCACABMOLDEDataGridViewTextBoxColumn.Name = "hORASPREVCNCACABMOLDEDataGridViewTextBoxColumn";
            // 
            // hORASPREVEROSAOEDMMOLDEDataGridViewTextBoxColumn
            // 
            this.hORASPREVEROSAOEDMMOLDEDataGridViewTextBoxColumn.DataPropertyName = "HORAS_PREV_EROSAO_EDM_MOLDE";
            this.hORASPREVEROSAOEDMMOLDEDataGridViewTextBoxColumn.HeaderText = "HORAS_PREV_EROSAO_EDM_MOLDE";
            this.hORASPREVEROSAOEDMMOLDEDataGridViewTextBoxColumn.Name = "hORASPREVEROSAOEDMMOLDEDataGridViewTextBoxColumn";
            // 
            // hORASPREVEROSAOEWCMOLDEDataGridViewTextBoxColumn
            // 
            this.hORASPREVEROSAOEWCMOLDEDataGridViewTextBoxColumn.DataPropertyName = "HORAS_PREV_EROSAO_EWC_MOLDE";
            this.hORASPREVEROSAOEWCMOLDEDataGridViewTextBoxColumn.HeaderText = "HORAS_PREV_EROSAO_EWC_MOLDE";
            this.hORASPREVEROSAOEWCMOLDEDataGridViewTextBoxColumn.Name = "hORASPREVEROSAOEWCMOLDEDataGridViewTextBoxColumn";
            // 
            // hORASPREVPOLIMENTOMOLDEDataGridViewTextBoxColumn
            // 
            this.hORASPREVPOLIMENTOMOLDEDataGridViewTextBoxColumn.DataPropertyName = "HORAS_PREV_POLIMENTO_MOLDE";
            this.hORASPREVPOLIMENTOMOLDEDataGridViewTextBoxColumn.HeaderText = "HORAS_PREV_POLIMENTO_MOLDE";
            this.hORASPREVPOLIMENTOMOLDEDataGridViewTextBoxColumn.Name = "hORASPREVPOLIMENTOMOLDEDataGridViewTextBoxColumn";
            // 
            // hORASPREVPROJETOMOLDEDataGridViewTextBoxColumn
            // 
            this.hORASPREVPROJETOMOLDEDataGridViewTextBoxColumn.DataPropertyName = "HORAS_PREV_PROJETO_MOLDE";
            this.hORASPREVPROJETOMOLDEDataGridViewTextBoxColumn.HeaderText = "HORAS_PREV_PROJETO_MOLDE";
            this.hORASPREVPROJETOMOLDEDataGridViewTextBoxColumn.Name = "hORASPREVPROJETOMOLDEDataGridViewTextBoxColumn";
            // 
            // hORASPREVPORTAMOLDEMOLDEDataGridViewTextBoxColumn
            // 
            this.hORASPREVPORTAMOLDEMOLDEDataGridViewTextBoxColumn.DataPropertyName = "HORAS_PREV_PORTA_MOLDE_MOLDE";
            this.hORASPREVPORTAMOLDEMOLDEDataGridViewTextBoxColumn.HeaderText = "HORAS_PREV_PORTA_MOLDE_MOLDE";
            this.hORASPREVPORTAMOLDEMOLDEDataGridViewTextBoxColumn.Name = "hORASPREVPORTAMOLDEMOLDEDataGridViewTextBoxColumn";
            // 
            // hORASPREVELETRODOMOLDEDataGridViewTextBoxColumn
            // 
            this.hORASPREVELETRODOMOLDEDataGridViewTextBoxColumn.DataPropertyName = "HORAS_PREV_ELETRODO_MOLDE";
            this.hORASPREVELETRODOMOLDEDataGridViewTextBoxColumn.HeaderText = "HORAS_PREV_ELETRODO_MOLDE";
            this.hORASPREVELETRODOMOLDEDataGridViewTextBoxColumn.Name = "hORASPREVELETRODOMOLDEDataGridViewTextBoxColumn";
            // 
            // hORASEXECTORNOMOLDEDataGridViewTextBoxColumn
            // 
            this.hORASEXECTORNOMOLDEDataGridViewTextBoxColumn.DataPropertyName = "HORAS_EXEC_TORNO_MOLDE";
            this.hORASEXECTORNOMOLDEDataGridViewTextBoxColumn.HeaderText = "HORAS_EXEC_TORNO_MOLDE";
            this.hORASEXECTORNOMOLDEDataGridViewTextBoxColumn.Name = "hORASEXECTORNOMOLDEDataGridViewTextBoxColumn";
            // 
            // hORASEXECFRESAMOLDEDataGridViewTextBoxColumn
            // 
            this.hORASEXECFRESAMOLDEDataGridViewTextBoxColumn.DataPropertyName = "HORAS_EXEC_FRESA_MOLDE";
            this.hORASEXECFRESAMOLDEDataGridViewTextBoxColumn.HeaderText = "HORAS_EXEC_FRESA_MOLDE";
            this.hORASEXECFRESAMOLDEDataGridViewTextBoxColumn.Name = "hORASEXECFRESAMOLDEDataGridViewTextBoxColumn";
            // 
            // hORASEXECCNCDESMOLDEDataGridViewTextBoxColumn
            // 
            this.hORASEXECCNCDESMOLDEDataGridViewTextBoxColumn.DataPropertyName = "HORAS_EXEC_CNC_DES_MOLDE";
            this.hORASEXECCNCDESMOLDEDataGridViewTextBoxColumn.HeaderText = "HORAS_EXEC_CNC_DES_MOLDE";
            this.hORASEXECCNCDESMOLDEDataGridViewTextBoxColumn.Name = "hORASEXECCNCDESMOLDEDataGridViewTextBoxColumn";
            // 
            // hORASEXECTEMPERAMOLDEDataGridViewTextBoxColumn
            // 
            this.hORASEXECTEMPERAMOLDEDataGridViewTextBoxColumn.DataPropertyName = "HORAS_EXEC_TEMPERA_MOLDE";
            this.hORASEXECTEMPERAMOLDEDataGridViewTextBoxColumn.HeaderText = "HORAS_EXEC_TEMPERA_MOLDE";
            this.hORASEXECTEMPERAMOLDEDataGridViewTextBoxColumn.Name = "hORASEXECTEMPERAMOLDEDataGridViewTextBoxColumn";
            // 
            // hORASEXECRETIFICAMOLDEDataGridViewTextBoxColumn
            // 
            this.hORASEXECRETIFICAMOLDEDataGridViewTextBoxColumn.DataPropertyName = "HORAS_EXEC_RETIFICA_MOLDE";
            this.hORASEXECRETIFICAMOLDEDataGridViewTextBoxColumn.HeaderText = "HORAS_EXEC_RETIFICA_MOLDE";
            this.hORASEXECRETIFICAMOLDEDataGridViewTextBoxColumn.Name = "hORASEXECRETIFICAMOLDEDataGridViewTextBoxColumn";
            // 
            // hORASEXECCNCACABMOLDEDataGridViewTextBoxColumn
            // 
            this.hORASEXECCNCACABMOLDEDataGridViewTextBoxColumn.DataPropertyName = "HORAS_EXEC_CNC_ACAB_MOLDE";
            this.hORASEXECCNCACABMOLDEDataGridViewTextBoxColumn.HeaderText = "HORAS_EXEC_CNC_ACAB_MOLDE";
            this.hORASEXECCNCACABMOLDEDataGridViewTextBoxColumn.Name = "hORASEXECCNCACABMOLDEDataGridViewTextBoxColumn";
            // 
            // hORASEXECEROSAOEDMMOLDEDataGridViewTextBoxColumn
            // 
            this.hORASEXECEROSAOEDMMOLDEDataGridViewTextBoxColumn.DataPropertyName = "HORAS_EXEC_EROSAO_EDM_MOLDE";
            this.hORASEXECEROSAOEDMMOLDEDataGridViewTextBoxColumn.HeaderText = "HORAS_EXEC_EROSAO_EDM_MOLDE";
            this.hORASEXECEROSAOEDMMOLDEDataGridViewTextBoxColumn.Name = "hORASEXECEROSAOEDMMOLDEDataGridViewTextBoxColumn";
            // 
            // hORASEXECEROSAOEWCMOLDEDataGridViewTextBoxColumn
            // 
            this.hORASEXECEROSAOEWCMOLDEDataGridViewTextBoxColumn.DataPropertyName = "HORAS_EXEC_EROSAO_EWC_MOLDE";
            this.hORASEXECEROSAOEWCMOLDEDataGridViewTextBoxColumn.HeaderText = "HORAS_EXEC_EROSAO_EWC_MOLDE";
            this.hORASEXECEROSAOEWCMOLDEDataGridViewTextBoxColumn.Name = "hORASEXECEROSAOEWCMOLDEDataGridViewTextBoxColumn";
            // 
            // hORASEXECPOLIMENTOMOLDEDataGridViewTextBoxColumn
            // 
            this.hORASEXECPOLIMENTOMOLDEDataGridViewTextBoxColumn.DataPropertyName = "HORAS_EXEC_POLIMENTO_MOLDE";
            this.hORASEXECPOLIMENTOMOLDEDataGridViewTextBoxColumn.HeaderText = "HORAS_EXEC_POLIMENTO_MOLDE";
            this.hORASEXECPOLIMENTOMOLDEDataGridViewTextBoxColumn.Name = "hORASEXECPOLIMENTOMOLDEDataGridViewTextBoxColumn";
            // 
            // hORASEXECPROJETOMOLDEDataGridViewTextBoxColumn
            // 
            this.hORASEXECPROJETOMOLDEDataGridViewTextBoxColumn.DataPropertyName = "HORAS_EXEC_PROJETO_MOLDE";
            this.hORASEXECPROJETOMOLDEDataGridViewTextBoxColumn.HeaderText = "HORAS_EXEC_PROJETO_MOLDE";
            this.hORASEXECPROJETOMOLDEDataGridViewTextBoxColumn.Name = "hORASEXECPROJETOMOLDEDataGridViewTextBoxColumn";
            // 
            // hORASEXECPORTAMOLDEMOLDEDataGridViewTextBoxColumn
            // 
            this.hORASEXECPORTAMOLDEMOLDEDataGridViewTextBoxColumn.DataPropertyName = "HORAS_EXEC_PORTA_MOLDE_MOLDE";
            this.hORASEXECPORTAMOLDEMOLDEDataGridViewTextBoxColumn.HeaderText = "HORAS_EXEC_PORTA_MOLDE_MOLDE";
            this.hORASEXECPORTAMOLDEMOLDEDataGridViewTextBoxColumn.Name = "hORASEXECPORTAMOLDEMOLDEDataGridViewTextBoxColumn";
            // 
            // hORASEXECELETRODOMOLDEDataGridViewTextBoxColumn
            // 
            this.hORASEXECELETRODOMOLDEDataGridViewTextBoxColumn.DataPropertyName = "HORAS_EXEC_ELETRODO_MOLDE";
            this.hORASEXECELETRODOMOLDEDataGridViewTextBoxColumn.HeaderText = "HORAS_EXEC_ELETRODO_MOLDE";
            this.hORASEXECELETRODOMOLDEDataGridViewTextBoxColumn.Name = "hORASEXECELETRODOMOLDEDataGridViewTextBoxColumn";
            // 
            // hORASEXECDESPCELETMOLDEDataGridViewTextBoxColumn
            // 
            this.hORASEXECDESPCELETMOLDEDataGridViewTextBoxColumn.DataPropertyName = "HORAS_EXEC_DES_PC_ELET_MOLDE";
            this.hORASEXECDESPCELETMOLDEDataGridViewTextBoxColumn.HeaderText = "HORAS_EXEC_DES_PC_ELET_MOLDE";
            this.hORASEXECDESPCELETMOLDEDataGridViewTextBoxColumn.Name = "hORASEXECDESPCELETMOLDEDataGridViewTextBoxColumn";
            // 
            // dESPESASPROJETOMOLDEDataGridViewTextBoxColumn
            // 
            this.dESPESASPROJETOMOLDEDataGridViewTextBoxColumn.DataPropertyName = "DESPESAS_PROJETO_MOLDE";
            this.dESPESASPROJETOMOLDEDataGridViewTextBoxColumn.HeaderText = "DESPESAS_PROJETO_MOLDE";
            this.dESPESASPROJETOMOLDEDataGridViewTextBoxColumn.Name = "dESPESASPROJETOMOLDEDataGridViewTextBoxColumn";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label20.Location = new System.Drawing.Point(358, -4);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(229, 46);
            this.label20.TabIndex = 137;
            this.label20.Text = "Gráfico ISO";
            // 
            // tb_mes
            // 
            this.tb_mes.Location = new System.Drawing.Point(89, 67);
            this.tb_mes.Name = "tb_mes";
            this.tb_mes.Size = new System.Drawing.Size(62, 20);
            this.tb_mes.TabIndex = 138;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 139;
            this.label1.Text = "Mês";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 141;
            this.label2.Text = "Ano";
            // 
            // tb_ano
            // 
            this.tb_ano.Location = new System.Drawing.Point(89, 93);
            this.tb_ano.Name = "tb_ano";
            this.tb_ano.Size = new System.Drawing.Size(62, 20);
            this.tb_ano.TabIndex = 140;
            // 
            // bt_ok
            // 
            this.bt_ok.Location = new System.Drawing.Point(157, 67);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(59, 46);
            this.bt_ok.TabIndex = 142;
            this.bt_ok.Text = "OK";
            this.bt_ok.UseVisualStyleBackColor = true;
            this.bt_ok.Click += new System.EventHandler(this.bt_ok_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 143;
            this.label3.Text = "(* para Todos)";
            // 
            // tb_total_prev
            // 
            this.tb_total_prev.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_total_prev.Location = new System.Drawing.Point(285, 81);
            this.tb_total_prev.Name = "tb_total_prev";
            this.tb_total_prev.Size = new System.Drawing.Size(101, 35);
            this.tb_total_prev.TabIndex = 197;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(303, 52);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(77, 26);
            this.label59.TabIndex = 196;
            this.label59.Text = "Total de Horas\r\nprevistas";
            this.label59.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_total_trab
            // 
            this.tb_total_trab.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_total_trab.Location = new System.Drawing.Point(392, 81);
            this.tb_total_trab.Name = "tb_total_trab";
            this.tb_total_trab.Size = new System.Drawing.Size(99, 35);
            this.tb_total_trab.TabIndex = 195;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(399, 52);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(77, 26);
            this.label58.TabIndex = 194;
            this.label58.Text = "Total de Horas\r\ntrabalhadas";
            this.label58.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_grafico
            // 
            this.bt_grafico.Location = new System.Drawing.Point(222, 67);
            this.bt_grafico.Name = "bt_grafico";
            this.bt_grafico.Size = new System.Drawing.Size(57, 46);
            this.bt_grafico.TabIndex = 198;
            this.bt_grafico.Text = "Gerar Gráfico";
            this.bt_grafico.UseVisualStyleBackColor = true;
            this.bt_grafico.Click += new System.EventHandler(this.bt_grafico_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 200;
            this.label4.Text = "Meta";
            // 
            // tb_meta_iso
            // 
            this.tb_meta_iso.Location = new System.Drawing.Point(89, 119);
            this.tb_meta_iso.Name = "tb_meta_iso";
            this.tb_meta_iso.Size = new System.Drawing.Size(62, 20);
            this.tb_meta_iso.TabIndex = 199;
            // 
            // form_grafico_iso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 551);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_meta_iso);
            this.Controls.Add(this.bt_grafico);
            this.Controls.Add(this.tb_total_prev);
            this.Controls.Add(this.label59);
            this.Controls.Add(this.tb_total_trab);
            this.Controls.Add(this.label58);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bt_ok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_ano);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_mes);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.dgvDesenhos);
            this.Name = "form_grafico_iso";
            this.Text = "Gráfico ISO";
            ((System.ComponentModel.ISupportInitialize)(this.dsDesenhos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DESENHOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDesenhos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datDesenhos;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
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
        private System.Data.DataColumn DESPESAS_PROJETO_MOLDE;
        private System.Windows.Forms.DataGridView dgvDesenhos;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tb_mes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_ano;
        private System.Windows.Forms.Button bt_ok;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODPECADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOSPECADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEVISAODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mATERIALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSPESSURADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rOTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMEPECADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nSUBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nROTASDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOSICAOPECADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fUNCAOPECADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAENTREGAPECADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oBSPECADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROJETISTAPECADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESPESASMOLDEDESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rECEITASMOLDEDESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORASPREVTORNOMOLDEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORASPREVFRESAMOLDEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORASPREVCNCDESMOLDEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORASPREVTEMPERAMOLDEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORASPREVRETIFICAMOLDEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORASPREVCNCACABMOLDEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORASPREVEROSAOEDMMOLDEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORASPREVEROSAOEWCMOLDEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORASPREVPOLIMENTOMOLDEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORASPREVPROJETOMOLDEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORASPREVPORTAMOLDEMOLDEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORASPREVELETRODOMOLDEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORASEXECTORNOMOLDEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORASEXECFRESAMOLDEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORASEXECCNCDESMOLDEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORASEXECTEMPERAMOLDEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORASEXECRETIFICAMOLDEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORASEXECCNCACABMOLDEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORASEXECEROSAOEDMMOLDEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORASEXECEROSAOEWCMOLDEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORASEXECPOLIMENTOMOLDEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORASEXECPROJETOMOLDEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORASEXECPORTAMOLDEMOLDEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORASEXECELETRODOMOLDEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORASEXECDESPCELETMOLDEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESPESASPROJETOMOLDEDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox tb_total_prev;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.TextBox tb_total_trab;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Button bt_grafico;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_meta_iso;
    }
}