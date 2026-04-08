using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Globalization;
using BoletoNet;
using System.IO;
using System.Collections;
using System.Text.RegularExpressions;

namespace Evolucao
{
    public partial class form_planejamento : Form
    {
        string descricao, cliente, plano, observacoes, vendedor, forma_pgto, romaneio, nf, n_titulo, empresa, valor, status, grupo_plano, semana_ano;
        string _filtro;

        public string usuario;
        public string _data, mes_esc, dataIniMes, dataFimMes;
        public int proxM, proxAno, mes_atual, ano_atual;
        DataTable dsContas = new DataTable();
        FbDataAdapter datContas_a_pagar = new FbDataAdapter();

        public string _cod_banco, _agencia, _dig_agencia, _cc, _dig_cc, _carteira, _multa, _mora, _dias_protesto, _codigo_no_banco, _descricao_banco, _cod_interno_banco, _cod_transmissao;
        //empresa
        string razao_social_empresa = "", nome_fantasia_empresa = "", cnpj_empresa = "", ie_empresa = "", im_empresa = "", cnae_empresa = "", endereco_empresa = "", n_endereco_empresa = "",
           complemento_empresa = "", bairro_empresa = "", cidade_empresa = "", estado_empresa = "", cep_empresa = "", telefone_empresa = "", cod_cidade_empresa = "", pais_empresa = "",
           cod_pais_empresa = "", licenca_dll_nfe_empresa = "", nome_certificado_nfe_empresa = "", assunto_nfe_email_empresa = "", smtp_nfe_empresa = "", email_nfe_empresa = "",
           senha_email_nfe_empresa = "", logotipo_empresa = "", proxy_empresa = "", usuario_proxy_empresa = "", senha_proxy_empresa = "", crt_empresa = "", portaEmailEmpresa = "", sslEmpresa = "", serie_empresa = "",
           boleto_pedido_empresa, cliente_inadimplente_empresa;

        public form_planejamento()
        {
            InitializeComponent();
        }

        private void detectar_dados_empresa(out string razao_social_empresa, out string nome_fantasia_empresa, out string cnpj_empresa, out string ie_empresa, out string im_empresa, out string cnae_empresa, out string endereco_empresa, out string n_endereco_empresa,
                 out string complemento_empresa, out string bairro_empresa, out string cidade_empresa, out string estado_empresa, out string cep_empresa, out string telefone_empresa, out string cod_cidade_empresa, out string pais_empresa,
                 out string cod_pais_empresa, out string licenca_dll_nfe_empresa, out string nome_certificado_nfe_empresa, out string assunto_nfe_email_empresa, out string smtp_nfe_empresa, out string email_nfe_empresa,
                 out string senha_email_nfe_empresa, out string logotipo_empresa, out string proxy_empresa, out string usuario_proxy_empresa, out string senha_proxy_empresa,
         out string crt_empresa, out string portaEmailEmpresa, out string sslEmpresa, out string serie_empresa, out string boleto_pedido_empresa, out string cliente_inadimplente_empresa)
        {
            razao_social_empresa = ""; nome_fantasia_empresa = ""; cnpj_empresa = ""; ie_empresa = ""; im_empresa = ""; cnae_empresa = ""; endereco_empresa = ""; n_endereco_empresa = "";
            complemento_empresa = ""; bairro_empresa = ""; cidade_empresa = ""; estado_empresa = ""; cep_empresa = ""; telefone_empresa = ""; cod_cidade_empresa = ""; pais_empresa = "";
            cod_pais_empresa = ""; licenca_dll_nfe_empresa = ""; nome_certificado_nfe_empresa = ""; assunto_nfe_email_empresa = ""; smtp_nfe_empresa = ""; email_nfe_empresa = "";
            senha_email_nfe_empresa = ""; logotipo_empresa = ""; proxy_empresa = ""; usuario_proxy_empresa = ""; senha_proxy_empresa = ""; crt_empresa = ""; portaEmailEmpresa = "";
            sslEmpresa = ""; serie_empresa = ""; boleto_pedido_empresa = ""; cliente_inadimplente_empresa = "";
            try
            {
                FbCommand comando = new FbCommand();
                comando.Connection = fbConnection1;
                comando.CommandText = "SELECT * FROM EMPRESA where LICENCA_DLL_NFE_EMPRESA is not null";
                DataSet empresa = new DataSet();
                fbConnection1.Open();
                FbDataAdapter datEmpresa = new FbDataAdapter();
                datEmpresa.SelectCommand = comando;
                datEmpresa.Fill(empresa);
                fbConnection1.Close();
                foreach (DataRow dr in empresa.Tables[0].Rows)
                {
                    razao_social_empresa = dr["RAZAO_SOCIAL_EMPRESA"].ToString();
                    nome_fantasia_empresa = dr["NOME_FANTASIA_EMPRESA"].ToString();
                    cnpj_empresa = dr["CNPJ_EMPRESA"].ToString().Replace(".", "").Replace("/", "").Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
                    ie_empresa = dr["IE_EMPRESA"].ToString().Replace(".", "").Replace("/", "").Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
                    im_empresa = dr["IM_EMPRESA"].ToString().Replace(".", "").Replace("/", "").Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
                    cnae_empresa = dr["CNAE_EMPRESA"].ToString().Replace(".", "").Replace("/", "").Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
                    endereco_empresa = dr["ENDERECO_EMPRESA"].ToString();
                    n_endereco_empresa = dr["N_ENDERECO_EMPRESA"].ToString();
                    complemento_empresa = dr["COMPLEMENTO_EMPRESA"].ToString();
                    bairro_empresa = dr["BAIRRO_EMPRESA"].ToString();
                    cidade_empresa = dr["CIDADE_EMPRESA"].ToString();
                    estado_empresa = dr["ESTADO_EMPRESA"].ToString();
                    cep_empresa = dr["CEP_EMPRESA"].ToString().Replace(".", "").Replace("/", "").Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
                    telefone_empresa = dr["TELEFONE_EMPRESA"].ToString().Replace(".", "").Replace("/", "").Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
                    cod_cidade_empresa = dr["COD_CIDADE_EMPRESA"].ToString();
                    pais_empresa = dr["PAIS_EMPRESA"].ToString();
                    cod_cidade_empresa = dr["COD_CIDADE_EMPRESA"].ToString();
                    licenca_dll_nfe_empresa = dr["LICENCA_DLL_NFE_EMPRESA"].ToString();
                    nome_certificado_nfe_empresa = dr["NOME_CERTIFICADO_NFE_EMPRESA"].ToString();
                    assunto_nfe_email_empresa = dr["ASSUNTO_NFE_EMAIL_EMPRESA"].ToString();
                    smtp_nfe_empresa = dr["SMTP_NFE_EMPRESA"].ToString();
                    email_nfe_empresa = dr["EMAIL_NFE_EMPRESA"].ToString();
                    senha_email_nfe_empresa = dr["SENHA_EMAIL_NFE_EMPRESA"].ToString();
                    logotipo_empresa = dr["LOGOTIPO_EMPRESA"].ToString();
                    proxy_empresa = dr["PROXY_EMPRESA"].ToString();
                    usuario_proxy_empresa = dr["USUARIO_PROXY_EMPRESA"].ToString();
                    senha_proxy_empresa = dr["SENHA_PROXY_EMPRESA"].ToString();
                    crt_empresa = dr["CRT_EMPRESA"].ToString();
                    try
                    {
                        portaEmailEmpresa = dr["PORTA_EMAIL_EMP"].ToString();
                    }
                    catch { }
                    try
                    {
                        sslEmpresa = dr["SSL_EMP"].ToString();
                    }
                    catch { }

                    serie_empresa = dr["SERIE_NF_EMPRESA"].ToString();
                    try
                    {
                        boleto_pedido_empresa = dr["BOLETO_PEDIDO_EMPRESA"].ToString();
                    }
                    catch { }
                    try
                    {
                        cliente_inadimplente_empresa = dr["CLIENTE_INADIMPLENTE_EMPRESA"].ToString();
                    }
                    catch { }
                }

            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }
        private void buscar_dados_bancarios()
        {
            _cod_banco = ""; _agencia = ""; _dig_agencia = "";
            _cc = ""; _dig_cc = "";
            _carteira = ""; _multa = "";
            _mora = ""; _dias_protesto = "";
            _codigo_no_banco = ""; _descricao_banco = ""; 
            _cod_interno_banco = ""; _cod_transmissao = "";
            try
            {
                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT * FROM CONTAS_CORRENTES WHERE BOLETO_CC = '1'";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    _descricao_banco = dr["DESCRICAO_CC"].ToString();
                    _cod_interno_banco = dr["COD_CC"].ToString();
                    _cod_banco = dr["CODIGO_BANCO_CC"].ToString();
                    _agencia = dr["AGENCIA_CC"].ToString();
                    _dig_agencia = dr["DIG_AGENCIA_CC"].ToString();
                    _cc = dr["CONTA_CC"].ToString();
                    _dig_cc = dr["DIG_CONTA_CC"].ToString();
                    _multa = dr["MULTA_CC"].ToString();
                    _mora = dr["MORA_DIA_CC"].ToString();
                    _dias_protesto = dr["DIAS_PROTESTO_CC"].ToString();
                    _carteira = dr["CARTEIRA_CC"].ToString();
                    _codigo_no_banco = dr["CODIGO_NO_BANCO_CC"].ToString();
                    _cod_transmissao = dr["COD_TRANSMISSAO"].ToString();
                }

            }
            catch { fbConnection1.Close(); }
        }

        public short _codigoBanco;
        public short CodigoBanco
        {
            get { return _codigoBanco; }
            set { _codigoBanco = value; }
        }

        public int financeiro_limitado;
        private void form_planejamento_Load(object sender, EventArgs e)
        {
            if (financeiro_limitado == 1)
            {
                groupBoxCr.Visible = false;
                cb_mostrar_apenas_cp.Checked = true;
                cb_mostrar_apenas_cp.Enabled = false;

            }


            detectar_dados_empresa(out razao_social_empresa, out nome_fantasia_empresa, out cnpj_empresa, out ie_empresa, out im_empresa, out cnae_empresa, out endereco_empresa, out n_endereco_empresa,
       out complemento_empresa, out bairro_empresa, out cidade_empresa, out estado_empresa, out cep_empresa, out telefone_empresa, out cod_cidade_empresa, out pais_empresa,
       out cod_pais_empresa, out licenca_dll_nfe_empresa, out nome_certificado_nfe_empresa, out assunto_nfe_email_empresa, out smtp_nfe_empresa, out email_nfe_empresa,
       out senha_email_nfe_empresa, out logotipo_empresa, out proxy_empresa, out usuario_proxy_empresa, out senha_proxy_empresa, out crt_empresa, out portaEmailEmpresa,
       out sslEmpresa, out serie_empresa, out boleto_pedido_empresa, out cliente_inadimplente_empresa);

            buscar_dados_bancarios();
            try
            {
                CodigoBanco = Convert.ToInt16(_cod_banco);
            }
            catch { }

            try
            {
                //if (verificar_se_existem_boletos_cancelados())
                //{
                //    MessageBox.Show("Existem boletos que foram cancelados. Por favor verifique");
                //}

                dateTimeIr.Value = DateTime.Now;
                mes_atual = DateTime.Now.Month;
                ano_atual = DateTime.Now.Year;
                carregaData();
                comboBox1.SelectedIndex = (mes_atual - 1);
                nudAno.Value = ano_atual;

                string tira_conta_cp = "";
                if (Convert.ToInt32(usuario) > 0) //se for o usuario "POSITIVO"
                    tira_conta_cp = buscar_cc_negativas_cp();

                string tira_conta_cr = "";
                if (Convert.ToInt32(usuario) > 0)
                    tira_conta_cr = buscar_cc_negativas_cr();
                filtrar();
                /*
                string data_cp = "", data_cr = "";
                data_cp = " AND DATA_PREVISTA_CP >= '" + dataIniMes + "' AND DATA_PREVISTA_CP < '" + dataFimMes + "'";
                data_cr = " AND DATA_PREVISTA_CR >= '" + dataIniMes + "' AND DATA_PREVISTA_CR < '" + dataFimMes + "'";
                FbCommand select_Contas_a_pagar = new FbCommand();
                select_Contas_a_pagar.Connection = fbConnection1;
                select_Contas_a_pagar.CommandText =
                    "SELECT COD_CP, DESCRICAO_CC_CP, DUPLICATA_CP, DATA_PREVISTA_CP, PLANO_CP, DESCRICAO_CP, VALOR_CP, PAGO_CP, OBSERVACOES_CP, RAZAO_FORNECEDOR_CP, CARTEIRA_CP, NF_CP FROM CONTAS_A_PAGAR WHERE cod_cp is not null " + tira_conta_cp + data_cp +
                    " UNION " +
                    "SELECT COD_CR, DESCRICAO_CC_CR, DUPLICATA_CR, DATA_PREVISTA_CR, PLANO_CR, DESCRICAO_CR, VALOR_CR, RECEBIDO_CR, OBSERVACOES_CR, RAZAO_CLIENTE_CR, CARTEIRA_CR, NF_CR  FROM CONTAS_A_RECEBER WHERE cod_cr is not null " + tira_conta_cr + data_cr;
                FbDataAdapter datContas_a_pagar = new FbDataAdapter();
                datContas_a_pagar.SelectCommand = select_Contas_a_pagar;
                //DataTable dsContas = new DataTable();
                datContas_a_pagar.Fill(dsContas);
                dgvPlanejamento.DataSource = dsContas;

                acertar_design_calcular_dgv();
                somarTotalFiltro();
                 * */
                //cbxMes.Checked = true;

            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }

            //datPlanejamento.Fill(dsPlanejamento);

        }

        private bool verificar_se_existem_boletos_cancelados()
        {
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT * FROM CONTAS_A_RECEBER WHERE CANCELADO_CR = 1";
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    return true;
                }
                return false;
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
                return false;
            }
        }

        private void carregaData()
        {
            if (mes_atual == 12)
            {
                proxM = 1;
            }
            else
            {
                proxM = mes_atual + 1;
            }
            if (proxM == 1)
            {
                proxAno = ano_atual + 1;
            }
            else
            {
                proxAno = ano_atual;
            }
            dataIniMes = "1." + mes_atual + "." + ano_atual;
            dataFimMes = "1." + proxM + "." + proxAno;
        }
        private void acertar_design_calcular_dgv()
        {
            /*
            DataGridViewCell cell = new DataGridViewTextBoxCell();
            
            DataGridViewColumn coluna_saldo = new DataGridViewColumn();
            coluna_saldo.HeaderText = "Saldo";
            coluna_saldo.CellTemplate = cell;
            coluna_saldo.Name = "col_saldo";
            dgvPlanejamento.Columns.Add(coluna_saldo);
            */
            



            dgvPlanejamento.Sort(dgvPlanejamento.Columns["DATA_PREVISTA_CP"], ListSortDirection.Ascending);

            dgvPlanejamento.Columns["COD_CR"].Width = 30; dgvPlanejamento.Columns["COD_CR"].HeaderText = "Cód.";
            dgvPlanejamento.Columns["EMPRESA"].Width = 30; dgvPlanejamento.Columns["EMPRESA"].HeaderText = "Emp.";
            dgvPlanejamento.Columns["DESCRICAO_CC_CP"].Width = 100; dgvPlanejamento.Columns["DESCRICAO_CC_CP"].HeaderText = "C/C";
            dgvPlanejamento.Columns["DUPLICATA_CP"].Width = 40; dgvPlanejamento.Columns["DUPLICATA_CP"].HeaderText = "Duplicata";
            dgvPlanejamento.Columns["DATA_PREVISTA_CP"].Width = 80; dgvPlanejamento.Columns["DATA_PREVISTA_CP"].HeaderText = "Vencimento"; dgvPlanejamento.Columns["DATA_PREVISTA_CP"].DefaultCellStyle.Format = "d"; dgvPlanejamento.Columns["DATA_PREVISTA_CP"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPlanejamento.Columns["PLANO_CP"].Width = 160; dgvPlanejamento.Columns["PLANO_CP"].HeaderText = "Plano";
            dgvPlanejamento.Columns["DESCRICAO_CP"].Width = 200; dgvPlanejamento.Columns["DESCRICAO_CP"].HeaderText = "Descrição";
            dgvPlanejamento.Columns["VALOR_CP"].Width = 80; dgvPlanejamento.Columns["VALOR_CP"].HeaderText = "Valor"; dgvPlanejamento.Columns["VALOR_CP"].DefaultCellStyle.Format = "n2"; dgvPlanejamento.Columns["VALOR_CP"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvPlanejamento.Columns["PAGO_CP"].Width = 40; dgvPlanejamento.Columns["PAGO_CP"].HeaderText = "Baixa"; 
            
            dgvPlanejamento.Columns["OBSERVACOES_CP"].Width = 100; dgvPlanejamento.Columns["OBSERVACOES_CP"].HeaderText = "Observações";
            dgvPlanejamento.Columns["RAZAO_FORNECEDOR_CP"].Width = 90; dgvPlanejamento.Columns["RAZAO_FORNECEDOR_CP"].HeaderText = "Cliente/Forn";
            dgvPlanejamento.Columns["COD_FORNECEDOR_CP"].Visible = false;
            dgvPlanejamento.Columns["SALDO"].Width = 65; dgvPlanejamento.Columns["SALDO"].HeaderText = "Saldo"; dgvPlanejamento.Columns["NF_CP"].DefaultCellStyle.Format = "n2"; dgvPlanejamento.Columns["NF_CP"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvPlanejamento.Columns["CARTEIRA_CP"].Width = 85; dgvPlanejamento.Columns["CARTEIRA_CP"].HeaderText = "Carteira";
            dgvPlanejamento.Columns["NF_CP"].Width = 85; dgvPlanejamento.Columns["NF_CP"].HeaderText = "NF"; dgvPlanejamento.Columns["NF_CP"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPlanejamento.Columns["DATA_CRIACAO_CR"].Width = 60; dgvPlanejamento.Columns["DATA_CRIACAO_CR"].HeaderText = "Data Lançamento"; dgvPlanejamento.Columns["DATA_CRIACAO_CR"].DefaultCellStyle.Format = "d"; dgvPlanejamento.Columns["DATA_CRIACAO_CR"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPlanejamento.Columns["DATA_CREDITO_CR"].Width = 60; dgvPlanejamento.Columns["DATA_CREDITO_CR"].HeaderText = "Data Crédito"; dgvPlanejamento.Columns["DATA_CREDITO_CR"].DefaultCellStyle.Format = "d"; dgvPlanejamento.Columns["DATA_CREDITO_CR"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPlanejamento.Columns["DATA_PAGAMENTO_CP"].Width = 60; dgvPlanejamento.Columns["DATA_PAGAMENTO_CP"].HeaderText = "Data Pgto"; dgvPlanejamento.Columns["DATA_PAGAMENTO_CP"].DefaultCellStyle.Format = "d"; dgvPlanejamento.Columns["DATA_PAGAMENTO_CP"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPlanejamento.Columns["DATA_VENC_ORIGINAL_CR"].Width = 60; dgvPlanejamento.Columns["DATA_VENC_ORIGINAL_CR"].HeaderText = "Data Venc. Orig."; dgvPlanejamento.Columns["DATA_VENC_ORIGINAL_CR"].DefaultCellStyle.Format = "d"; dgvPlanejamento.Columns["DATA_VENC_ORIGINAL_CR"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPlanejamento.Columns["CANCELADO_CR"].Width = 50; dgvPlanejamento.Columns["CANCELADO_CR"].HeaderText = "Cancelado";
            dgvPlanejamento.Columns["STATUS"].Width = 120; dgvPlanejamento.Columns["STATUS"].HeaderText = "Status";
            dgvPlanejamento.Columns["VALOR_PAGO"].Width = 80; dgvPlanejamento.Columns["VALOR_PAGO"].HeaderText = "Valor Pago"; dgvPlanejamento.Columns["VALOR_PAGO"].DefaultCellStyle.Format = "n2";
            dgvPlanejamento.Columns["GRUPO_PLANO"].Width = 80; dgvPlanejamento.Columns["GRUPO_PLANO"].HeaderText = "Grupo Plano"; 
            //DATA_VENC_ORIGINAL_CR
            //DATA_PAGAMENTO_CP
            dgvPlanejamento.Columns["EMPRESA"].DisplayIndex = 0; dgvPlanejamento.Columns["EMPRESA"].Width = 15;
            dgvPlanejamento.Columns["DATA_CRIACAO_CR"].DisplayIndex = 15; dgvPlanejamento.Columns["DATA_CRIACAO_CR"].Width = 60;
            dgvPlanejamento.Columns["NF_CP"].DisplayIndex = 1; dgvPlanejamento.Columns["NF_CP"].Width = 70;
            dgvPlanejamento.Columns["DUPLICATA_CP"].DisplayIndex = 2; dgvPlanejamento.Columns["DUPLICATA_CP"].Width = 50;
            dgvPlanejamento.Columns["PLANO_CP"].DisplayIndex = 13; dgvPlanejamento.Columns["PLANO_CP"].Width = 95;
            dgvPlanejamento.Columns["DATA_PAGAMENTO_CP"].DisplayIndex = 9; dgvPlanejamento.Columns["DATA_PAGAMENTO_CP"].Width = 60;
            dgvPlanejamento.Columns["CARTEIRA_CP"].DisplayIndex = 10; dgvPlanejamento.Columns["DESCRICAO_CP"].Width = 68;
            dgvPlanejamento.Columns["DESCRICAO_CP"].DisplayIndex = 19; dgvPlanejamento.Columns["DESCRICAO_CP"].Width = 150;
            dgvPlanejamento.Columns["DATA_PREVISTA_CP"].DisplayIndex = 5; dgvPlanejamento.Columns["DATA_PREVISTA_CP"].Width = 60;
            dgvPlanejamento.Columns["DATA_CREDITO_CR"].DisplayIndex = 18; dgvPlanejamento.Columns["DATA_CREDITO_CR"].Width = 60;
            dgvPlanejamento.Columns["VALOR_CP"].DisplayIndex = 6; dgvPlanejamento.Columns["VALOR_CP"].Width = 65; dgvPlanejamento.Columns["VALOR_CP"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvPlanejamento.Columns["VALOR_ORIGINAL_CR"].DisplayIndex = 4; dgvPlanejamento.Columns["VALOR_ORIGINAL_CR"].Width = 65; dgvPlanejamento.Columns["VALOR_ORIGINAL_CR"].DefaultCellStyle.Format = "n2"; dgvPlanejamento.Columns["VALOR_ORIGINAL_CR"].HeaderText = "Valor Título"; dgvPlanejamento.Columns["VALOR_ORIGINAL_CR"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; dgvPlanejamento.Columns["VALOR_ORIGINAL_CR"].Visible = false;
            dgvPlanejamento.Columns["OBSERVACOES_CP"].DisplayIndex = 16; dgvPlanejamento.Columns["OBSERVACOES_CP"].Width = 60; 
            dgvPlanejamento.Columns["RAZAO_FORNECEDOR_CP"].DisplayIndex = 3;
            dgvPlanejamento.Columns["STATUS"].DisplayIndex = 7; dgvPlanejamento.Columns["STATUS"].Width = 80; 
            dgvPlanejamento.Columns["SALDO"].DisplayIndex = 17; dgvPlanejamento.Columns["SALDO"].Width = 80;
            dgvPlanejamento.Columns["PAGO_CP"].DisplayIndex = 20;
            dgvPlanejamento.Columns["DESCRICAO_CC_CP"].DisplayIndex = 11;
            dgvPlanejamento.Columns["COD_CR"].DisplayIndex = 28;
            dgvPlanejamento.Columns["VALOR_PAGO"].DisplayIndex = 8; dgvPlanejamento.Columns["VALOR_PAGO"].Width = 65; dgvPlanejamento.Columns["VALOR_PAGO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvPlanejamento.Columns["GRUPO_PLANO"].DisplayIndex = 12;
            dgvPlanejamento.Columns["semana_ano"].DisplayIndex = 14; dgvPlanejamento.Columns["semana_ano"].Width = 30; dgvPlanejamento.Columns["semana_ano"].HeaderText = "Semana Ano";
            dgvPlanejamento.Columns["DATA_EMISSAO_CP"].Visible = false;
            /*
             * "SELECT COD_CR, PESSOA_CR AS EMPRESA, DUPLICATA_CR AS DUPLICATA_CP, RECEBIDO_CR AS PAGO_CP, RAZAO_CLIENTE_CR AS RAZAO_FORNECEDOR_CP, " +
                    " DATA_PREVISTA_CR AS DATA_PREVISTA_CP, DATA_CREDITO_CR, DATA_VENC_ORIGINAL_CR, VALOR_CR AS VALOR_CP, '0' AS SALDO, DATA_RECEBIMENTO_CR AS DATA_PAGAMENTO_CP, " +
                    " PLANO_CR AS PLANO_CP, DESCRICAO_CC_CR AS DESCRICAO_CC_CP, STATUS_CR AS STATUS, CARTEIRA_CR AS CARTEIRA_CP, DESCRICAO_CR AS DESCRICAO_CP, NF_CR AS NF_CP, DATA_EMISSAO_CR AS DATA_EMISSAO_CP," +
                    " OBSERVACOES_CR AS OBSERVACOES_CP,  " +
                    "   VALOR_ORIGINAL_CR , COD_CLIENTE_CR AS COD_FORNECEDOR_CP, REMESSA_CR AS REMESSA_CP, DATA_CRIACAO_CR, " +
                    "FORMA_PGTO_CR," + vendedor + ", ROMANEIO_CR AS ROMANEIO, CANCELADO_CR, NOME_FANTASIA, COD_PLANO_CR AS COD_PLANO_CP, VALOR_CR AS VALOR_PAGO, GRUPO_PLANO  " +
            /*
            for (int i = 11; i < dgvPlanejamento.Columns.Count; i++)
            {
                dgvPlanejamento.Columns[i].Visible = false;
            }
            */

            calcular_saldo();
            buscar_linha_de_hoje(DateTime.Now);
        }

        private void buscar_linha_de_hoje(DateTime data)
        {
            try
            {
                int linha = dgvPlanejamento.RowCount; ;
                for (int i = 0; i < dgvPlanejamento.RowCount; i++)
                {
                    try
                    {
                        if (Convert.ToDateTime(dgvPlanejamento.Rows[i].Cells["DATA_PREVISTA_CP"].Value.ToString()) > data)
                        {
                            linha = i - 1;
                            break;
                        }
                    }
                    catch { }
                }
                dgvPlanejamento.Rows[linha].Selected = true;
                dgvPlanejamento.CurrentCell = dgvPlanejamento[0, linha];
            }
            catch { }
        }

        private void calcular_saldo()
        {
            try
            {
                double saldo = 0;
                try
                {
                    saldo = Convert.ToDouble(tb_saldo_inicial.Text);
                }
                catch
                {

                }
                for (int i = 0; i < dgvPlanejamento.RowCount; i++)
                {
                    try
                    {
                        saldo = saldo + Convert.ToDouble(dgvPlanejamento.Rows[i].Cells["VALOR_CP"].Value.ToString());
                        dgvPlanejamento.Rows[i].Cells["Saldo"].Value = saldo.ToString("n2");
                    }
                    catch { }
                }
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form_cc cc = new form_cc();
            try
            {
                cc.ShowDialog();

            }
            finally
            {
                tb_descricao_cc.Text = cc.descricao_escolhido;
                tb_cod_cc.Text = cc.cod_escolhido;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tb_saldo_inicial.Text = "";
            filtrar();
            somarTotalFiltro();

        }

        private void filtrar()
        {
            try
            {


                dsContas.Clear();
                tb_descricao.Text = "";
                //tb_cheque.Text = "";
                tb_observacoes.Text = "";
                dgvPlanejamento.DataSource = null;
                dgvPlanejamento.Columns.Clear();
                string cc_cp = "", cc_cr = "";
                if (cbPlanejamento.Checked)
                {
                    tb_descricao_cc.Text = "";
                    tb_cod_cc.Text = "";
                }

                string nao_aparecer_join_cp = "", nao_aparecer_cp = "", nao_aparecer_join_cr = "", nao_aparecer_cr = "";
                if (tb_descricao_cc.Text == "")
                {
                    
                    nao_aparecer_join_cp = " LEFT JOIN CONTAS_CORRENTES cc on cc.COD_CC = CONTAS_A_PAGAR.CC_CP ";
                    nao_aparecer_cp = " AND (cc.NAO_APARECER_CC = '0' or cc.NAO_APARECER_CC is null)";
                    nao_aparecer_join_cr = " LEFT JOIN CONTAS_CORRENTES cc on cc.COD_CC = CONTAS_A_RECEBER.CC_CR ";
                    nao_aparecer_cr = " AND (cc.NAO_APARECER_CC = '0' or cc.NAO_APARECER_CC is null)";
                     
                }
                string data_cp = "";
                string data_cr = "";
                string baixa_cp = "";
                string baixa_cr = "";
                //string vendedor = "";
                if (cbPor_data.Checked)
                {
                    data_cp = " AND DATA_PREVISTA_CP >= '" + Convert.ToDateTime(dtInicio.Text).ToShortDateString().Replace("/", ".") + "'" +
                        "AND DATA_PREVISTA_CP <= '" + Convert.ToDateTime(dtTermino.Text).ToShortDateString().Replace("/", ".") + "'";
                    data_cr = " AND DATA_PREVISTA_CR >= '" + Convert.ToDateTime(dtInicio.Text).ToShortDateString().Replace("/", ".") + "'" +
                        "AND DATA_PREVISTA_CR <= '" + Convert.ToDateTime(dtTermino.Text).ToShortDateString().Replace("/", ".") + "'";
                    if (cb_buscar_saldo.Checked)
                        tb_saldo_inicial.Text = buscar_saldo_inicial();
                }
                else if (cbxMes.Checked)
                {
                    mes_atual = (comboBox1.SelectedIndex + 1);
                    ano_atual = Convert.ToInt32(nudAno.Value);
                    carregaData();
                    data_cp = " AND DATA_PREVISTA_CP >= '" + dataIniMes + "' AND DATA_PREVISTA_CP < '" + dataFimMes + "'";
                    data_cr = " AND DATA_PREVISTA_CR >= '" + dataIniMes + "' AND DATA_PREVISTA_CR < '" + dataFimMes + "'";
                    if (cb_buscar_saldo.Checked)
                        tb_saldo_inicial.Text = buscar_saldo_inicial();
                }
                if (cbData_criacao.Checked)
                {
                    if (cbPor_data.Checked)
                    {
                        data_cp = " AND DATA_CRIACAO_CP >= '" + Convert.ToDateTime(dtInicio.Text).ToShortDateString().Replace("/", ".") + "'" +
                            "AND DATA_CRIACAO_CP <= '" + Convert.ToDateTime(dtTermino.Text).ToShortDateString().Replace("/", ".") + "'";
                        data_cr = " AND DATA_CRIACAO_CR >= '" + Convert.ToDateTime(dtInicio.Text).ToShortDateString().Replace("/", ".") + "'" +
                            "AND DATA_CRIACAO_CR <= '" + Convert.ToDateTime(dtTermino.Text).ToShortDateString().Replace("/", ".") + "'";
                        if (cb_buscar_saldo.Checked)
                            tb_saldo_inicial.Text = buscar_saldo_inicial();
                    }
                    else if (cbxMes.Checked)
                    {
                        mes_atual = (comboBox1.SelectedIndex + 1);
                        ano_atual = Convert.ToInt32(nudAno.Value);
                        carregaData();
                        data_cp = " AND DATA_CRIACAO_CP >= '" + dataIniMes + "' AND DATA_CRIACAO_CP < '" + dataFimMes + "'";
                        data_cr = " AND DATA_CRIACAO_CR >= '" + dataIniMes + "' AND DATA_CRIACAO_CR < '" + dataFimMes + "'";
                        if (cb_buscar_saldo.Checked)
                            tb_saldo_inicial.Text = buscar_saldo_inicial();
                    }
                }
                if (cbData_emissao.Checked)
                {
                    if (cbPor_data.Checked)
                    {
                        data_cr = //" AND DATA_EMISSAO_CR = '01.01.2001'";//para nao aparecer as CP 
                        "AND DATA_EMISSAO_CR >= '" + Convert.ToDateTime(dtInicio.Text).ToShortDateString().Replace("/", ".") + "'" +
                            "AND DATA_EMISSAO_CR <= '" + Convert.ToDateTime(dtTermino.Text).ToShortDateString().Replace("/", ".") + "'";
                        data_cp = " AND DATA_EMISSAO_CP >= '" + Convert.ToDateTime(dtInicio.Text).ToShortDateString().Replace("/", ".") + "'" +
                            "AND DATA_EMISSAO_CP <= '" + Convert.ToDateTime(dtTermino.Text).ToShortDateString().Replace("/", ".") + "'";
                        if (cb_buscar_saldo.Checked)
                            tb_saldo_inicial.Text = buscar_saldo_inicial();
                    }
                    else if (cbxMes.Checked)
                    {
                        mes_atual = (comboBox1.SelectedIndex + 1);
                        ano_atual = Convert.ToInt32(nudAno.Value);
                        carregaData();
                        data_cr = " AND DATA_EMISSAO_CR >= '" + dataIniMes + "' AND DATA_EMISSAO_CR < '" + dataFimMes + "'";
                        data_cp = " AND DATA_EMISSAO_CP >= '" + dataIniMes + "' AND DATA_EMISSAO_CP < '" + dataFimMes + "'";
                        if (cb_buscar_saldo.Checked)
                            tb_saldo_inicial.Text = buscar_saldo_inicial();
                    }
                }
                if (cbData_credito.Checked)
                {
                    if (cbPor_data.Checked)
                    {
                        data_cp = " AND DATA_CRIACAO_CP = '01.01.2001'";//para nao aparecer as CP 
                        //AND DATA_CREDITO_CR >= '" + Convert.ToDateTime(dtInicio.Text).ToShortDateString().Replace("/", ".") + "'" +
                        //    "AND DATA_CREDITO_CR <= '" + Convert.ToDateTime(dtTermino.Text).ToShortDateString().Replace("/", ".") + "'";
                        data_cr = " AND DATA_CREDITO_CR >= '" + Convert.ToDateTime(dtInicio.Text).ToShortDateString().Replace("/", ".") + "'" +
                            "AND DATA_CREDITO_CR <= '" + Convert.ToDateTime(dtTermino.Text).ToShortDateString().Replace("/", ".") + "'";
                        if (cb_buscar_saldo.Checked)
                            tb_saldo_inicial.Text = buscar_saldo_inicial();
                    }
                    else if (cbxMes.Checked)
                    {
                        mes_atual = (comboBox1.SelectedIndex + 1);
                        ano_atual = Convert.ToInt32(nudAno.Value);
                        carregaData();
                        data_cp = " AND DATA_CRIACAO_CP = '01.01.2001'"; //para nao aparecer as CP
                        data_cr = " AND DATA_CREDITO_CR >= '" + dataIniMes + "' AND DATA_CREDITO_CR < '" + dataFimMes + "'";
                        if (cb_buscar_saldo.Checked)
                            tb_saldo_inicial.Text = buscar_saldo_inicial();
                    }
                }
                if (cbDataPagamento.Checked)
                {
                    if (cbPor_data.Checked)
                    {
                        data_cp = " AND DATA_PAGAMENTO_CP >= '" + Convert.ToDateTime(dtInicio.Text).ToShortDateString().Replace("/", ".") + "'" +
                            "AND DATA_PAGAMENTO_CP <= '" + Convert.ToDateTime(dtTermino.Text).ToShortDateString().Replace("/", ".") + "'";
                        data_cr = " AND DATA_RECEBIMENTO_CR >= '" + Convert.ToDateTime(dtInicio.Text).ToShortDateString().Replace("/", ".") + "'" +
                            "AND DATA_RECEBIMENTO_CR <= '" + Convert.ToDateTime(dtTermino.Text).ToShortDateString().Replace("/", ".") + "'";
                        if (cb_buscar_saldo.Checked)
                            tb_saldo_inicial.Text = buscar_saldo_inicial();
                    }
                    else if (cbxMes.Checked)
                    {
                        mes_atual = (comboBox1.SelectedIndex + 1);
                        ano_atual = Convert.ToInt32(nudAno.Value);
                        carregaData();
                        data_cp = " AND DATA_PAGAMENTO_CP >= '" + dataIniMes + "' AND DATA_PAGAMENTO_CP < '" + dataFimMes + "'";
                        data_cr = " AND DATA_RECEBIMENTO_CR >= '" + dataIniMes + "' AND DATA_RECEBIMENTO_CR < '" + dataFimMes + "'";
                        if (cb_buscar_saldo.Checked)
                            tb_saldo_inicial.Text = buscar_saldo_inicial();
                    }
                }
                if (cbData_venc_original.Checked)
                {

                    if (cbPor_data.Checked)
                    {
                        data_cp = " AND DATA_CRIACAO_CP = '01.01.2001'";//para nao aparecer as CP 
                        //AND DATA_CREDITO_CR >= '" + Convert.ToDateTime(dtInicio.Text).ToShortDateString().Replace("/", ".") + "'" +
                        //    "AND DATA_CREDITO_CR <= '" + Convert.ToDateTime(dtTermino.Text).ToShortDateString().Replace("/", ".") + "'";
                        data_cr = " AND DATA_VENC_ORIGINAL_CR >= '" + Convert.ToDateTime(dtInicio.Text).ToShortDateString().Replace("/", ".") + "'" +
                            "AND DATA_VENC_ORIGINAL_CR <= '" + Convert.ToDateTime(dtTermino.Text).ToShortDateString().Replace("/", ".") + "'";
                        if (cb_buscar_saldo.Checked)
                            tb_saldo_inicial.Text = buscar_saldo_inicial();
                    }
                    else if (cbxMes.Checked)
                    {
                        mes_atual = (comboBox1.SelectedIndex + 1);
                        ano_atual = Convert.ToInt32(nudAno.Value);
                        carregaData();
                        data_cp = " AND DATA_CRIACAO_CP = '01.01.2001'"; //para nao aparecer as CP
                        data_cr = " AND DATA_VENC_ORIGINAL_CR >= '" + dataIniMes + "' AND DATA_VENC_ORIGINAL_CR < '" + dataFimMes + "'";
                        if (cb_buscar_saldo.Checked)
                            tb_saldo_inicial.Text = buscar_saldo_inicial();
                    }
                }
                if (ckb_pago.Checked)
                {
                    baixa_cp = " AND PAGO_CP = '1'";
                    baixa_cr = " AND RECEBIDO_CR = '1'";
                }
                else if (ckb_naoPago.Checked)
                {
                    baixa_cp = " AND (PAGO_CP = '0' OR PAGO_CP IS NULL)";
                    baixa_cr = " AND (RECEBIDO_CR = '0' OR RECEBIDO_CR IS NULL)";
                }
                if (tb_descricao_cc.Text != "")
                {
                    cc_cp = " AND DESCRICAO_CC_CP LIKE '%" + tb_descricao_cc.Text + "%'";
                    cc_cr = " AND DESCRICAO_CC_CR LIKE  '%" + tb_descricao_cc.Text + "%'";
                }

                string tira_conta_cp = "";
                if (Convert.ToInt32(usuario) > 0) //se for o usuario "NEGATIVO"
                    tira_conta_cp = buscar_cc_negativas_cp();

                string tira_conta_cr = "";
                if (Convert.ToInt32(usuario) > 0)
                    tira_conta_cr = buscar_cc_negativas_cr();

                string fatura = "'' AS FORMA_PGTO";
                /*
                if (cbForma_pgto.Checked)
                {
                    fatura = "(SELECT nf.FORMA_PGTO_NF FROM NOTA_FISCAL nf where nf.N_NF = NF_CR) AS FORMA_PGTO";
                    if (boleto_pedido_empresa == "1")
                    {
                        fatura = "(SELECT ped.COND_PGTO_PED_VENDA FROM PEDIDOS_VENDA ped where ped.COD_PED_VENDA = NF_CR) AS FORMA_PGTO ";
                    }
                }
                */
                string vendedor = "'' AS VENDEDOR ";
                if (ckbVendedor.Checked)
                {
                    vendedor = " (SELECT first(1) ped.VENDEDOR_PED_VENDA FROM NOTA_FISCAL nf " +
                        " INNER JOIN PEDIDOS_NF pnf ON pnf.NF_PEDIDO_NF = nf.N_NF " +
                        " INNER JOIN PEDIDOS_VENDA ped ON pnf.N_PEDIDO_NF = ped.COD_PED_VENDA " +
                        " where nf.N_NF = NF_CR) AS VENDEDOR ";
                    if (boleto_pedido_empresa == "1")
                    {
                        vendedor = " (SELECT ped.VENDEDOR_PED_VENDA FROM PEDIDOS_VENDA ped where ped.COD_PED_VENDA = NF_CR) AS VENDEDOR ";
                    }
                }
                string boletos_cancelados = "";
                if (cbCancelados.Checked)
                    boletos_cancelados = " AND CANCELADO_CR = 1 ";
                else
                    boletos_cancelados = " AND (CANCELADO_CR = 0 or CANCELADO_CR IS NULL) ";

                string boletos_a_enviar = "";
                string join_boletos_a_enviar = "";
                //      "SELECT BOLETO_FORMA_PGTO FROM FORMA_PGTO WHERE DESCRICAO_FORMA_PGTO = '" + dgvPlanejamento.SelectedRows[i].Cells["FORMA_PGTO_CR"].Value.ToString() + "'";
                if (cbBoletos_a_enviar.Checked)
                {
                    join_boletos_a_enviar = " INNER JOIN FORMA_PGTO fp ON FORMA_PGTO_CR = fp.DESCRICAO_FORMA_PGTO ";
                    boletos_a_enviar = " AND REMESSA_CR is NULL  AND fp.BOLETO_FORMA_PGTO = 1 and (RECEBIDO_CR = 0 OR RECEBIDO_CR IS NULL) ";
                }

                string romaneio = "";
                if (cbRomaneio.Checked)
                    romaneio = " AND ROMANEIO_CR IS NOT NULL ";

                string union = " UNION ";
                //mudança dia 25/06/2021
                //string select_cp = "SELECT COD_CP as COD_CR, PESSOA_CP as EMPRESA,  DESCRICAO_CC_CP, DUPLICATA_CP, DATA_PREVISTA_CP, '' AS DATA_CREDITO_CR, COD_PLANO_CP, PLANO_CP, DESCRICAO_CP, VALOR_CP, PAGO_CP, OBSERVACOES_CP, RAZAO_FORNECEDOR_CP, " +
                //    "CARTEIRA_CP, NF_CP, '0' AS SALDO, '' AS VALOR_ORIGINAL_CR, COD_FORNECEDOR_CP, '' AS REMESSA_CR, '' AS DATA_CRIACAO_CR, '' AS FORMA_PGTO, '' AS VENDEDOR, '' AS ROMANEIO, '' AS DATA_VENC_ORIGINAL_CR, '' AS CANCELADO_CR FROM CONTAS_A_PAGAR  " +
                //    nao_aparecer_join_cp +
                //    " WHERE COD_CP IS NOT NULL " + cc_cp + tira_conta_cp + data_cp + baixa_cp + nao_aparecer_cp;
                //string select_cr = "SELECT COD_CR, PESSOA_CR AS EMPRESA, DESCRICAO_CC_CR AS DESCRICAO_CC_CP, DUPLICATA_CR AS DUPLICATA_CP, DATA_PREVISTA_CR AS DATA_PREVISTA_CP,  DATA_CREDITO_CR, COD_PLANO_CR AS COD_PLANO_CP, PLANO_CR AS PLANO_CP, DESCRICAO_CR AS DESCRICAO_CP, " +
                //    "VALOR_CR AS VALOR_CP, RECEBIDO_CR AS PAGO_CP, OBSERVACOES_CR AS OBSERVACOES_CP, RAZAO_CLIENTE_CR AS RAZAO_FORNECEDOR_CP, " +
                //    "CARTEIRA_CR AS CARTEIRA_CP, NF_CR AS NF_CP, '0' AS SALDO, VALOR_ORIGINAL_CR , COD_CLIENTE_CR AS COD_FORNECEDOR_CP, REMESSA_CR AS REMESSA_CP, EXTRACT(day FROM DATA_CRIACAO_CR)||'/'|| EXTRACT(month FROM DATA_CRIACAO_CR)||'/' || EXTRACT(year FROM DATA_CRIACAO_CR) AS DATA_CRIACAO_CR, " +
                //    "FORMA_PGTO_CR," + vendedor + ", ROMANEIO_CR AS ROMANEIO, DATA_VENC_ORIGINAL_CR, CANCELADO_CR " +
               // string select_cp = "SELECT COD_CP as COD_CR, PESSOA_CP as EMPRESA, DUPLICATA_CP, PAGO_CP, RAZAO_FORNECEDOR_CP, " +
               //     " DATA_PREVISTA_CP, null AS DATA_CREDITO_CR,  null AS DATA_VENC_ORIGINAL_CR, VALOR_CP, '0' AS SALDO, DATA_PAGAMENTO_CP, " +
               //     "PLANO_CP, DESCRICAO_CC_CP, STATUS_CP AS STATUS, CARTEIRA_CP, DESCRICAO_CP,  NF_CP,  DATA_EMISSAO_CP, OBSERVACOES_CP,  " +
               //" '' AS VALOR_ORIGINAL_CR, COD_FORNECEDOR_CP, '' AS REMESSA_CR, data_criacao_cp AS DATA_CRIACAO_CR, '' AS FORMA_PGTO, '' AS VENDEDOR, " +
               //"'' AS ROMANEIO,'' AS CANCELADO_CR, NOME_FANTASIA, COD_PLANO_CP FROM CONTAS_A_PAGAR  " +
               //"LEFT JOIN CLIENTES ON COD_FORNECEDOR_CP = COD_CLIENTE " + 
               //nao_aparecer_join_cp +
               //" WHERE COD_CP IS NOT NULL " + cc_cp + tira_conta_cp + data_cp + baixa_cp + nao_aparecer_cp;
               // string select_cr = "SELECT COD_CR, PESSOA_CR AS EMPRESA, DUPLICATA_CR AS DUPLICATA_CP, RECEBIDO_CR AS PAGO_CP, RAZAO_CLIENTE_CR AS RAZAO_FORNECEDOR_CP, " +
               //     " DATA_PREVISTA_CR AS DATA_PREVISTA_CP, DATA_CREDITO_CR, DATA_VENC_ORIGINAL_CR, VALOR_CR AS VALOR_CP, '0' AS SALDO, DATA_RECEBIMENTO_CR AS DATA_PAGAMENTO_CP, " +
               //     " PLANO_CR AS PLANO_CP, DESCRICAO_CC_CR AS DESCRICAO_CC_CP, STATUS_CR AS STATUS, CARTEIRA_CR AS CARTEIRA_CP, DESCRICAO_CR AS DESCRICAO_CP, NF_CR AS NF_CP, DATA_EMISSAO_CR AS DATA_EMISSAO_CP," +
               //     " OBSERVACOES_CR AS OBSERVACOES_CP,  " +
               //     "   VALOR_ORIGINAL_CR , COD_CLIENTE_CR AS COD_FORNECEDOR_CP, REMESSA_CR AS REMESSA_CP, DATA_CRIACAO_CR, " +
               //     "FORMA_PGTO_CR," + vendedor + ", ROMANEIO_CR AS ROMANEIO, CANCELADO_CR, NOME_FANTASIA, COD_PLANO_CR AS COD_PLANO_CP " +
               //     "FROM CONTAS_A_RECEBER " +
               //     "LEFT JOIN CLIENTES ON COD_CLIENTE_CR = COD_CLIENTE " + 
               //     nao_aparecer_join_cr +
               //     join_boletos_a_enviar +
               //     " WHERE COD_CR IS NOT NULL " + cc_cr + tira_conta_cr + data_cr + baixa_cr + romaneio + nao_aparecer_cr + boletos_cancelados + boletos_a_enviar;
                string select_cp = "SELECT COD_CP as COD_CR, PESSOA_CP as EMPRESA, DUPLICATA_CP, PAGO_CP, RAZAO_FORNECEDOR_CP, " +
                  " DATA_PREVISTA_CP, null AS DATA_CREDITO_CR,  null AS DATA_VENC_ORIGINAL_CR, VALOR_CP, '0' AS SALDO, DATA_PAGAMENTO_CP, " +
                  "PLANO_CP, DESCRICAO_CC_CP, STATUS_CP AS STATUS, CARTEIRA_CP, DESCRICAO_CP,  NF_CP,  DATA_EMISSAO_CP, OBSERVACOES_CP,  " +
             " VALOR_ORIGINAL_CP AS VALOR_ORIGINAL_CR, COD_FORNECEDOR_CP, '' AS REMESSA_CR, data_criacao_cp AS DATA_CRIACAO_CR, '' AS FORMA_PGTO, '' AS VENDEDOR, " +
             "'' AS ROMANEIO,'' AS CANCELADO_CR, NOME_FANTASIA, COD_PLANO_CP, VALOR_CP AS VALOR_PAGO, GRUPO_PLANO, " + 
             "cast(cast((datediff(day, cast(cast('01.01.' as varchar(10))||cast(extract(year from DATA_PREVISTA_CP) as varchar(4)) as date), DATA_PREVISTA_CP)/ 7) as varchar(10)) || cast(extract(year from DATA_PREVISTA_CP) as varchar(4)) as varchar(10))  as semana_ano " + 
             "FROM CONTAS_A_PAGAR  " +
             "LEFT JOIN CLIENTES ON COD_FORNECEDOR_CP = COD_CLIENTE " +
             "LEFT JOIN PLANOS ON NOME_PLANO = PLANO_CP " + 
             nao_aparecer_join_cp +
             " WHERE COD_CP IS NOT NULL " + cc_cp + tira_conta_cp + data_cp + baixa_cp + nao_aparecer_cp;
                string select_cr = "SELECT COD_CR, PESSOA_CR AS EMPRESA, DUPLICATA_CR AS DUPLICATA_CP, RECEBIDO_CR AS PAGO_CP, RAZAO_CLIENTE_CR AS RAZAO_FORNECEDOR_CP, " +
                    " DATA_PREVISTA_CR AS DATA_PREVISTA_CP, DATA_CREDITO_CR, DATA_VENC_ORIGINAL_CR, VALOR_CR AS VALOR_CP, '0' AS SALDO, DATA_RECEBIMENTO_CR AS DATA_PAGAMENTO_CP, " +
                    " PLANO_CR AS PLANO_CP, DESCRICAO_CC_CR AS DESCRICAO_CC_CP, STATUS_CR AS STATUS, CARTEIRA_CR AS CARTEIRA_CP, DESCRICAO_CR AS DESCRICAO_CP, NF_CR AS NF_CP, DATA_EMISSAO_CR AS DATA_EMISSAO_CP," +
                    " OBSERVACOES_CR AS OBSERVACOES_CP,  " +
                    "   VALOR_ORIGINAL_CR , COD_CLIENTE_CR AS COD_FORNECEDOR_CP, REMESSA_CR AS REMESSA_CP, DATA_CRIACAO_CR, " +
                    "FORMA_PGTO_CR," + vendedor + ", ROMANEIO_CR AS ROMANEIO, CANCELADO_CR, NOME_FANTASIA, COD_PLANO_CR AS COD_PLANO_CP, VALOR_CR AS VALOR_PAGO, GRUPO_PLANO,  " +
                    "cast(cast((datediff(day, cast(cast('01.01.' as varchar(10))||cast(extract(year from DATA_PREVISTA_CR) as varchar(4)) as date), DATA_PREVISTA_CR)/ 7) as varchar(10)) || cast(extract(year from DATA_PREVISTA_CR) as varchar(4)) as varchar(10))  as semana_ano " + 
                    "FROM CONTAS_A_RECEBER " +
                    "LEFT JOIN CLIENTES ON COD_CLIENTE_CR = COD_CLIENTE " +
                    "LEFT JOIN PLANOS ON NOME_PLANO = PLANO_CR " + 
                    nao_aparecer_join_cr +
                    join_boletos_a_enviar +
                    " WHERE COD_CR IS NOT NULL " + cc_cr + tira_conta_cr + data_cr + baixa_cr + romaneio + nao_aparecer_cr + boletos_cancelados + boletos_a_enviar;
                if (cb_mostrar_apenas_cp.Checked || cb_mostrar_apenas_cr.Checked)
                {
                    union = "";
                    if (cb_mostrar_apenas_cp.Checked)
                        select_cr = "";
                    if (cb_mostrar_apenas_cr.Checked)
                        select_cp = "";
                }
                /* dsContas.Columns["DATA_VENC_ORIGINAL_CR"]*/

               


                FbCommand select_Contas_a_pagar = new FbCommand();
                select_Contas_a_pagar.Connection = fbConnection1;
                select_Contas_a_pagar.CommandText =
                    select_cp +
                    union +
                   select_cr;
                //datContas_a_pagar = new FbDataAdapter();
                datContas_a_pagar.SelectCommand = select_Contas_a_pagar;
                DataTable dsContas_novo = new DataTable();

                //DataColumn DATA_VENC_ORIGINAL_CR = new DataColumn();
                //DATA_VENC_ORIGINAL_CR.DataType = System.Type.GetType("System.DateTime");
                //DATA_VENC_ORIGINAL_CR.ColumnName = "DATA_VENC_ORIGINAL_CR";
                //dsContas_novo.Columns.Add(DATA_VENC_ORIGINAL_CR);

                datContas_a_pagar.Fill(dsContas_novo);
                dsContas = dsContas_novo;
                


               
                dgvPlanejamento.DataSource = dsContas;
                acertar_design_calcular_dgv();
                somarTotalFiltro();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private string buscar_cc_negativas_cp()
        {
            string retorno = "";
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT * FROM CONTAS_CORRENTES WHERE COD_CC < 0";
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.SelectCommand = select;
                DataSet dsTabela = new DataSet();
                datTabela.Fill(dsTabela);
                fbConnection1.Close();

                foreach (DataRow dr in dsTabela.Tables[0].Rows)
                {
                    retorno = retorno + " AND (DESCRICAO_CC_CP != '" + dr[1].ToString() + "' OR DESCRICAO_CC_CP IS NULL)";
                }
                return retorno;
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
                return retorno;
            }
        }

        private string buscar_cc_negativas_cr()
        {
            string retorno = "";
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT * FROM CONTAS_CORRENTES WHERE COD_CC < 0";
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.SelectCommand = select;
                DataSet dsTabela = new DataSet();
                datTabela.Fill(dsTabela);
                fbConnection1.Close();

                foreach (DataRow dr in dsTabela.Tables[0].Rows)
                {
                    retorno = retorno + " AND (DESCRICAO_CC_CR != '" + dr[1].ToString() + "' OR DESCRICAO_CC_CR IS NULL)";
                }
                return retorno;
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
                return retorno;
            }
        }

        private string buscar_saldo_inicial()
        {
            try
            {
                double saldo_inicial = 0;
                string cc = "";
                string cc_cp = "", cc_cr = "";
                if (tb_descricao_cc.Text != "")
                {
                    cc_cp = " AND DESCRICAO_CC_CP = '" + tb_descricao_cc.Text + "'";
                    cc_cr = " AND DESCRICAO_CC_CR = '" + tb_descricao_cc.Text + "'";
                }

                string data_cp = "";
                string data_cr = "";
                if (cbPor_data.Checked)
                {
                    data_cp = " AND DATA_PREVISTA_CP < '" + Convert.ToDateTime(dtInicio.Text).ToShortDateString().Replace("/", ".") + "'";
                    data_cr = " AND DATA_PREVISTA_CR < '" + Convert.ToDateTime(dtInicio.Text).ToShortDateString().Replace("/", ".") + "'";
                }
                else if (cbxMes.Checked)
                {
                    mes_atual = (comboBox1.SelectedIndex + 1);
                    ano_atual = Convert.ToInt32(nudAno.Value);
                    carregaData();
                    data_cp = " AND DATA_PREVISTA_CP < '" + dataIniMes + "'";
                    data_cr = " AND DATA_PREVISTA_CR < '" + dataIniMes + "'";
                }
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                select.CommandText =
                    "SELECT VALOR_CP, DATA_PREVISTA_CP FROM CONTAS_A_PAGAR " +
                    //"SELECT * FROM CONTAS_A_PAGAR " +
                    " WHERE PAGO_CP = 1 AND COD_CP IS NOT NULL " + cc_cp + data_cp;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataSet dsSelect = new DataSet();
                datSelect.Fill(dsSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dsSelect.Tables[0].Rows)
                {
                    try
                    {
                        saldo_inicial = saldo_inicial + Convert.ToDouble(dr[0].ToString());
                    }
                    catch { }
                }

                select.Connection = fbConnection1;
                select.CommandText =
                    "SELECT VALOR_CR, DATA_PREVISTA_CR FROM CONTAS_A_RECEBER" +
                    //"SELECT * FROM CONTAS_A_RECEBER" +
                    " WHERE RECEBIDO_CR = 1 AND COD_CR IS NOT NULL " + cc_cr + data_cr;
                fbConnection1.Open();
                datSelect.SelectCommand = select;
                DataSet dsSelect_cr = new DataSet();
                datSelect.Fill(dsSelect_cr);
                fbConnection1.Close();
                foreach (DataRow dr_cr in dsSelect_cr.Tables[0].Rows)
                {
                    try
                    {
                        saldo_inicial = saldo_inicial + Convert.ToDouble(dr_cr[0].ToString());
                    }
                    catch { }
                }





                return saldo_inicial.ToString("n2");
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
                return "0,00";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            /*
             * try
                {
                    form_operacoes_cp op = new form_operacoes_cp();

                    op.cod_a_abrir = dgvPlanejamento.SelectedRows[0].Cells["COD_CR"].Value.ToString();
                    op.alterar = true;
                    op.FormClosed += frm_Closed;
                    op.Show();

                }
                catch (Exception ex)
                {
                    fbConnection1.Close();
                    MessageBox.Show(ex.Message);
                }*/
            form_operacoes_cp op = new form_operacoes_cp();
            try
            {
                op.adicionar = true;
                op.cod_cc = tb_cod_cc.Text;
               // op.FormClosed += frm_Closed;
                op.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("O(s) registro(s) será excluído(s) permanentemente, tem certeza?",
               "Confirma a exclusão?", MessageBoxButtons.YesNo))
            {
                for (int i = 0; i < dgvPlanejamento.SelectedRows.Count; i++)
                {
                    try
                    {
                        if (Convert.ToDouble(dgvPlanejamento.SelectedRows[i].Cells["VALOR_CP"].Value.ToString()) > 0)
                        {
                            MessageBox.Show("Não é possível excluir contas a receber nesse botão");
                        }
                        else
                        {
                            if (Convert.ToDouble(dgvPlanejamento.SelectedRows[i].Cells["VALOR_CP"].Value.ToString()) == 0)
                            {
                                try
                                {
                                    form_operacoes_cr op = new form_operacoes_cr();
                                    try
                                    {
                                        try
                                        {
                                            op.cod_a_abrir = dgvPlanejamento.SelectedRows[i].Cells["COD_CR"].Value.ToString();
                                        }
                                        catch
                                        {
                                            MessageBox.Show("Por favor, selecione a linha inteira");
                                        }
                                        op.excluir = true;
                                        op.ShowDialog();
                                    }
                                    finally
                                    {
                                        // filtrar();
                                    }
                                }
                                catch { }
                                try
                                {
                                    form_operacoes_cp op = new form_operacoes_cp();
                                    try
                                    {
                                        try
                                        {
                                            op.cod_a_abrir = dgvPlanejamento.SelectedRows[i].Cells["COD_CR"].Value.ToString();
                                            op.excluir = true;
                                            op.ShowDialog();
                                        }
                                        catch
                                        {
                                            MessageBox.Show("Por favor, selecione a linha inteira");
                                        }
                                    }
                                    finally
                                    {
                                        // filtrar();
                                    }
                                }
                                catch { }
                            }
                            else
                            {
                                form_operacoes_cp op = new form_operacoes_cp();
                                try
                                {
                                    try
                                    {
                                        op.cod_a_abrir = dgvPlanejamento.SelectedRows[i].Cells["COD_CR"].Value.ToString();
                                        op.excluir = true;
                                        op.ShowDialog();
                                    }
                                    catch
                                    {
                                        MessageBox.Show("Por favor, selecione a linha inteira");
                                    }
                                }
                                finally
                                {
                                    // filtrar();
                                }
                            }
                        }
                    }
                    catch
                    {
                        
                            try
                            {
                                form_operacoes_cr op = new form_operacoes_cr();
                                try
                                {
                                    try
                                    {
                                        op.cod_a_abrir = dgvPlanejamento.SelectedRows[i].Cells["COD_CR"].Value.ToString();
                                    }
                                    catch
                                    {
                                        MessageBox.Show("Por favor, selecione a linha inteira");
                                    }
                                    op.excluir = true;
                                    op.ShowDialog();
                                }
                                finally
                                {
                                    // filtrar();
                                }
                            }
                            catch { }
                            try
                            {
                                form_operacoes_cp op = new form_operacoes_cp();
                                try
                                {
                                    try
                                    {
                                        op.cod_a_abrir = dgvPlanejamento.SelectedRows[i].Cells["COD_CR"].Value.ToString();
                                        op.excluir = true;
                                        op.ShowDialog();
                                    }
                                    catch
                                    {
                                        MessageBox.Show("Por favor, selecione a linha inteira");
                                    }
                                }
                                finally
                                {
                                    // filtrar();
                                }
                            }
                            catch { }
                        
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string _cp_cod = "", _cp_descricao = "", _cp_valor = "", _cp_data_prevista = "", _cp_data_pgto = "", _cp_cod_forn = "", _cp_fornecedor = "", _cp_plano = "", _cp_carteira = "", _cp_nf = "", _cp_cc = "null";
                FbCommand comando_select = new FbCommand();
                comando_select.Connection = fbConnection1;
                comando_select.CommandText = "SELECT * FROM CONTAS_A_PAGAR WHERE COD_CP = '" + dgvPlanejamento.SelectedRows[0].Cells["COD_CR"].Value.ToString() + "'";
                DataSet cp = new DataSet();
                fbConnection1.Open();
                FbDataAdapter datContas_a_pagar = new FbDataAdapter();
                datContas_a_pagar.SelectCommand = comando_select;
                datContas_a_pagar.Fill(cp);
                fbConnection1.Close();
                foreach (DataRow dr in cp.Tables[0].Rows)
                {
                    _cp_cod = dr["COD_CP"].ToString();
                    _cp_descricao = dr["DESCRICAO_CP"].ToString();
                    _cp_valor = dr["VALOR_CP"].ToString();
                    _cp_data_prevista = dr["DATA_PREVISTA_CP"].ToString();
                    _cp_data_pgto = dr["DATA_PAGAMENTO_CP"].ToString();
                    _cp_cod_forn = dr["COD_FORNECEDOR_CP"].ToString();
                    _cp_fornecedor = dr["RAZAO_FORNECEDOR_CP"].ToString();
                    _cp_plano = dr["PLANO_CP"].ToString();
                    _cp_carteira = dr["CARTEIRA_CP"].ToString();
                    _cp_nf = dr["NF_CP"].ToString();
                    _cp_cc = dr["CC_CP"].ToString();
                }
                if (_cp_nf == "")
                {
                    MessageBox.Show("Para fazer a multiplicação é necessário informar uma nota!");

                }else{
                    form_multiplicar_cp_cr cp_cr = new form_multiplicar_cp_cr();
                    try
                    {
                        cp_cr._multiplicar_cp = true;
                        cp_cr._cp_descricao = _cp_descricao;
                        cp_cr._cp_valor = _cp_valor;
                        cp_cr._cp_data_prevista = _cp_data_prevista;
                        cp_cr._cp_data_pgto = _cp_data_pgto;
                        cp_cr._cp_cod_forn = _cp_cod_forn;
                        cp_cr._cp_fornecedor = _cp_fornecedor;
                        cp_cr._cp_plano = _cp_plano;
                        cp_cr._cp_carteira = _cp_carteira;
                        cp_cr._cp_nf = _cp_nf;
                        cp_cr._cp_cc = _cp_cc;
                        cp_cr._cp_cod = _cp_cod;
                        cp_cr.ShowDialog();
                    }
                    finally
                    {
                        filtrar();
                    }
                }
            }
            catch
            {
                fbConnection1.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dgvPlanejamento.SelectedRows.Count > 0 && Convert.ToDecimal(dgvPlanejamento.SelectedRows[0].Cells["VALOR_CP"].Value.ToString()) <= 0)
            {
                try
                {
                    form_operacoes_cp op = new form_operacoes_cp();

                    op.cod_a_abrir = dgvPlanejamento.SelectedRows[0].Cells["COD_CR"].Value.ToString();
                    op.alterar = true;
                    op.FormClosed += frm_Closed;
                    op.Show();

                }
                catch (Exception ex)
                {
                    fbConnection1.Close();
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Selecione uma linha de contas a pagar por favor");
            }
        }

        private void frm_Closed(object sender, EventArgs e)
        {
           // filtrar();
           // filtro();
        }

        private bool verificar_se_sao_positivos(int i)
        {

            if (Convert.ToDouble(dgvPlanejamento.SelectedRows[i].Cells["VALOR_CP"].Value.ToString()) < 0)
                return false;
            else
                return true;
        }


        private void button8_Click(object sender, EventArgs e)
        {
            if (dgvPlanejamento.SelectedRows.Count > 0)
            {
                string carteira = "", cod_cc = "", cc = "", data_pgto = "";
                form_baixa_cp cp = new form_baixa_cp();
                try
                {
                    cp.carteira = dgvPlanejamento.SelectedRows[0].Cells["CARTEIRA_CP"].Value.ToString();
                    cp.ShowDialog();
                }
                finally
                {
                    carteira = cp.carteira;
                    cod_cc = cp.cod_cc;
                    cc = cp.descricao_cc;
                    data_pgto = cp.data.Replace("/", ".");

                    if (cod_cc == "")
                        cod_cc = "null";
                }

                for (int i = 0; i < dgvPlanejamento.SelectedRows.Count; i++)
                {
                    if (verificar_se_sao_positivos(i))
                    {
                        MessageBox.Show("Impossível baixar essa conta");
                    }
                    else
                    {
                        try
                        {
                            FbCommand up = new FbCommand();
                            FbDataAdapter datUp = new FbDataAdapter();
                            up.Connection = fbConnection1;
                            up.CommandText = "UPDATE CONTAS_A_PAGAR SET PAGO_CP = 1, status_cp = 'PAGO', CC_CP = " + cod_cc + ", " +
                                "DESCRICAO_CC_CP = '" + cc + "', CARTEIRA_CP = '" + carteira +
                                "', DATA_PREVISTA_CP = '" + data_pgto + "', DATA_PAGAMENTO_CP = '" + data_pgto + "' WHERE COD_CP = " +
                                dgvPlanejamento.SelectedRows[i].Cells["COD_CR"].Value.ToString();
                            datUp.UpdateCommand = up;
                            fbConnection1.Open();
                            datUp.UpdateCommand.ExecuteNonQuery();
                            fbConnection1.Close();
                        }
                        catch (Exception a)
                        {
                            fbConnection1.Close();
                            MessageBox.Show(a.ToString());
                        }
                    }
                }
                filtrar();

                //if (dgvPlanejamento.SelectedRows[0].Cells["VALOR_CP"].Value.ToString() == "1" && 
                //    !verificar_se_sao_positivos())
                //{
                //    MessageBox.Show("Impossível baixar essa conta");
                //}
                //else
                //{
                //    inserir_baixa_unica_cp();
                //}
            }
            else
            {
                MessageBox.Show("Selecione ao menos uma linha por favor.");
            }
        }

        private bool verificar_se_sao_negativos()
        {
            for (int i = 0; i < dgvPlanejamento.SelectedRows.Count; i++)
            {
                if (Convert.ToDouble(dgvPlanejamento.SelectedRows[i].Cells["VALOR_CP"].Value.ToString()) > 0)
                    return false;
            }
            return true;
        }

        private bool verificar_se_sao_positivos()
        {
            for (int i = 0; i < dgvPlanejamento.SelectedRows.Count; i++)
            {
                if (Convert.ToDouble(dgvPlanejamento.SelectedRows[i].Cells["VALOR_CP"].Value.ToString()) < 0)
                    return false;
            }
            return true;
        }

        private void inserir_baixa_unica_cp()
        {
            form_operacoes_caixa caixa = new form_operacoes_caixa();
            try
            {
                caixa.adicionar = true;
                for (int i = 0; i < dgvPlanejamento.SelectedRows.Count; i++)
                {
                    caixa.cp_cr_a_vincular[i] = dgvPlanejamento.SelectedRows[i].Cells["COD_CR"].Value.ToString();
                }
                caixa.n_baixas = dgvPlanejamento.SelectedRows.Count;
                caixa.debito = true;
                caixa.ShowDialog();
            }
            finally
            {
                filtrar();

            }
        }

        private void bt_adicionar_cr_Click(object sender, EventArgs e)
        {
            form_operacoes_cr op = new form_operacoes_cr();
            try
            {
                op.adicionar = true;
                op.cod_cc = tb_cod_cc.Text;
                //op.FormClosed += frm_Closed;
                op.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bt_excluir_cr_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvPlanejamento.SelectedRows.Count; i++)
            {
                try
                {
                    if (Convert.ToDouble(dgvPlanejamento.SelectedRows[i].Cells["VALOR_CP"].Value.ToString()) < 0)
                    {
                        MessageBox.Show("Não é possível excluir contas a pagar nesse botão");
                    }
                    else
                    {
                        if (Convert.ToDouble(dgvPlanejamento.SelectedRows[i].Cells["VALOR_CP"].Value.ToString()) == 0)
                        {
                            try
                            {
                                form_operacoes_cr op = new form_operacoes_cr();
                                try
                                {
                                    try
                                    {
                                        op.cod_a_abrir = dgvPlanejamento.SelectedRows[i].Cells["COD_CR"].Value.ToString();
                                    }
                                    catch
                                    {
                                        MessageBox.Show("Por favor, selecione a linha inteira");
                                    }
                                    op.excluir = true;
                                    op.ShowDialog();
                                }
                                finally
                                {
                                    // filtrar();
                                }
                            }
                            catch { }
                            try
                            {
                                form_operacoes_cp op = new form_operacoes_cp();
                                try
                                {
                                    try
                                    {
                                        op.cod_a_abrir = dgvPlanejamento.SelectedRows[i].Cells["COD_CR"].Value.ToString();
                                        op.excluir = true;
                                        op.ShowDialog();
                                    }
                                    catch
                                    {
                                        MessageBox.Show("Por favor, selecione a linha inteira");
                                    }
                                }
                                finally
                                {
                                    // filtrar();
                                }
                            }
                            catch { }
                        }
                        else
                        {

                            form_operacoes_cr op = new form_operacoes_cr();
                            try
                            {
                                try
                                {
                                    op.cod_a_abrir = dgvPlanejamento.SelectedRows[i].Cells["COD_CR"].Value.ToString();
                                }
                                catch
                                {
                                    MessageBox.Show("Por favor, selecione a linha inteira");
                                }
                                op.excluir = true;
                                op.ShowDialog();
                            }
                            finally
                            {
                                // filtrar();
                            }
                        }
                    }

                }
                catch
                {

                    try
                    {
                        form_operacoes_cr op = new form_operacoes_cr();
                        try
                        {
                            try
                            {
                                op.cod_a_abrir = dgvPlanejamento.SelectedRows[i].Cells["COD_CR"].Value.ToString();
                            }
                            catch
                            {
                                MessageBox.Show("Por favor, selecione a linha inteira");
                            }
                            op.excluir = true;
                            op.ShowDialog();
                        }
                        finally
                        {
                            // filtrar();
                        }
                    }
                    catch { }
                    try
                    {
                        form_operacoes_cp op = new form_operacoes_cp();
                        try
                        {
                            try
                            {
                                op.cod_a_abrir = dgvPlanejamento.SelectedRows[i].Cells["COD_CR"].Value.ToString();
                                op.excluir = true;
                                op.ShowDialog();
                            }
                            catch
                            {
                                MessageBox.Show("Por favor, selecione a linha inteira");
                            }
                        }
                        finally
                        {
                            // filtrar();
                        }
                    }
                    catch { }
                }
            }
        
        }

        private void bt_multiplicar_cr_Click(object sender, EventArgs e)
        {
            string _cr_cod = "", _cr_descricao = "", _cr_valor = "", _cr_data_prevista = "", _cr_data_pgto = "", _cr_cod_cliente = "", _cr_cliente = "", _cr_plano = "", _cr_carteira = "", _cr_nf = "", _cr_cc = "";
            FbCommand comando_select = new FbCommand();
            comando_select.Connection = fbConnection1;
            comando_select.CommandText = "SELECT * FROM CONTAS_A_RECEBER WHERE COD_CR = '" + dgvPlanejamento.SelectedRows[0].Cells["COD_CR"].Value.ToString() + "'";
            DataSet cr = new DataSet();
            fbConnection1.Open();
            FbDataAdapter datContas_a_receber = new FbDataAdapter();
            datContas_a_receber.SelectCommand = comando_select;
            datContas_a_receber.Fill(cr);
            fbConnection1.Close();
            foreach (DataRow dr in cr.Tables[0].Rows)
            {
                _cr_cod = dr["COD_CR"].ToString();
                _cr_descricao = dr["DESCRICAO_CR"].ToString();
                _cr_valor = dr["VALOR_CR"].ToString();
                _cr_data_prevista = dr["DATA_PREVISTA_CR"].ToString();
                _cr_data_pgto = dr["DATA_RECEBIMENTO_CR"].ToString();
                _cr_cod_cliente = dr["COD_CLIENTE_CR"].ToString();
                _cr_cliente = dr["RAZAO_CLIENTE_CR"].ToString();
                _cr_plano = dr["PLANO_CR"].ToString();
                _cr_carteira = dr["CARTEIRA_CR"].ToString();
                _cr_nf = dr["NF_CR"].ToString();
                _cr_cc = dr["CC_CR"].ToString();
            }

            form_multiplicar_cp_cr cp_cr = new form_multiplicar_cp_cr();
            try
            {
                cp_cr._cr_cod = _cr_cod;
                cp_cr._multiplicar_cr = true;
                cp_cr._cr_descricao = _cr_descricao;
                cp_cr._cr_valor = _cr_valor;
                cp_cr._cr_data_prevista = _cr_data_prevista;
                cp_cr._cr_data_pgto = _cr_data_pgto;
                cp_cr._cr_cod_cliente = _cr_cod_cliente;
                cp_cr._cr_cliente = _cr_cliente;
                cp_cr._cr_plano = _cr_plano;
                cp_cr._cr_carteira = _cr_carteira;
                cp_cr._cr_nf = _cr_nf;
                cp_cr._cr_cc = _cr_cc;
                cp_cr.ShowDialog();
            }
            finally
            {
                filtrar();
            }
        }

        private void bt_alterar_cr_Click(object sender, EventArgs e)
        {
            /*
             * if (dgvPlanejamento.SelectedRows.Count > 0 && Convert.ToDecimal(dgvPlanejamento.SelectedRows[0].Cells["VALOR_CP"].Value.ToString()) <= 0)
            {
                try
                {
                    form_operacoes_cp op = new form_operacoes_cp();

                    op.cod_a_abrir = dgvPlanejamento.SelectedRows[0].Cells["COD_CR"].Value.ToString();
                    op.alterar = true;
                    op.FormClosed += frm_Closed;
                    op.Show();

                }
                catch (Exception ex)
                {
                    fbConnection1.Close();
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Selecione uma linha de contas a pagar por favor");
            }*/
            if (dgvPlanejamento.SelectedRows.Count > 0 && Convert.ToDecimal(dgvPlanejamento.SelectedRows[0].Cells["VALOR_CP"].Value.ToString()) >= 0)
            {
                try
                {
                    form_operacoes_cr op = new form_operacoes_cr();

                    op.cod_a_abrir = dgvPlanejamento.SelectedRows[0].Cells["COD_CR"].Value.ToString();

                    op.alterar = true;
                    op.FormClosed += frm_Closed;
                    op.ShowDialog();
                }
                catch (Exception ex)
                {
                    //filtrar(); 
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Selecione uma linha de contas a receber por favor");
            }
        }

        private bool verificar_se_sao_negativos(int i)
        {
            if (Convert.ToDouble(dgvPlanejamento.SelectedRows[i].Cells["VALOR_CP"].Value.ToString()) > 0)
                return false;
            else
                return true;
        }

        private void bt_baixar_cr_Click(object sender, EventArgs e)
        {
            if (dgvPlanejamento.SelectedRows.Count > 0)
            {
                string carteira = "", cod_cc = "", cc = "", data_pgto = "";
                form_baixa_cp cp = new form_baixa_cp();
                try
                {
                    cp.carteira = dgvPlanejamento.SelectedRows[0].Cells["CARTEIRA_CP"].Value.ToString();
                    cp.ShowDialog();
                }
                finally
                {
                    carteira = cp.carteira;
                    cod_cc = cp.cod_cc;
                    cc = cp.descricao_cc;
                    data_pgto = cp.data.Replace("/", ".");

                    if (cod_cc == "")
                        cod_cc = "null";
                }

                for (int i = 0; i < dgvPlanejamento.SelectedRows.Count; i++)
                {
                    if (verificar_se_sao_negativos(i))
                    {
                        MessageBox.Show("Impossível baixar essa conta");
                    }
                    else
                    {
                        try
                        {
                            string status = "PAGO";
                            if (carteira.ToUpper().Contains("DESCONTAD"))
                                status = "DESCONTADO";
                            FbCommand up = new FbCommand();
                            FbDataAdapter datUp = new FbDataAdapter();
                            up.Connection = fbConnection1;
                            up.CommandText = "UPDATE CONTAS_A_RECEBER SET RECEBIDO_CR = 1, STATUS_CR = '" + status + "', CC_CR = " + cod_cc + ", " +
                                "DESCRICAO_CC_CR = '" + cc + "', CARTEIRA_CR = '" + carteira +
                                "', DATA_PREVISTA_CR = '" + data_pgto + "' WHERE COD_CR = " +
                                dgvPlanejamento.SelectedRows[i].Cells["COD_CR"].Value.ToString();
                            datUp.UpdateCommand = up;
                            fbConnection1.Open();
                            datUp.UpdateCommand.ExecuteNonQuery();
                            fbConnection1.Close();
                        }
                        catch (Exception a)
                        {
                            fbConnection1.Close();
                            MessageBox.Show(a.ToString());
                        }
                    }
                }
               // filtrar();
            }
            else
            {
                MessageBox.Show("Selecione ao menos uma linha por favor.");
            }
        }

        private void inserir_baixa_unica_cr()
        {
            form_operacoes_caixa caixa = new form_operacoes_caixa();
            try
            {
                caixa.adicionar = true;
                for (int i = 0; i < dgvPlanejamento.SelectedRows.Count; i++)
                {
                    caixa.cp_cr_a_vincular[i] = dgvPlanejamento.SelectedRows[i].Cells["COD_CR"].Value.ToString();
                }
                caixa.n_baixas = dgvPlanejamento.SelectedRows.Count;
                caixa.credito = true;
                caixa.ShowDialog();
            }
            finally
            {
                filtrar();
            }
        }

        private void tb_descricao_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tb_descricao.Text != "")
                {
                    descricao = " AND DESCRICAO_CP LIKE '*" + tb_descricao.Text + "*'";
                }
                else
                    descricao = "";
                filtro();
            }
            catch { }
            // try
            //  {
            //      dsContas.DefaultView.RowFilter = "DESCRICAO_CP LIKE '*" + tb_descricao.Text + "*'";
            //  }
            //  catch { }
            //  somarTotalFiltro();
        }

        private void tb_cheque_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_observacoes_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tb_observacoes.Text != "")
                {
                    observacoes = " AND OBSERVACOES_CP LIKE '*" + tb_observacoes.Text + "*'";
                }
                else
                    observacoes = "";
                filtro();
            }
            catch { }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            calcular_saldo();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvPlanejamento.SelectedRows.Count; i++)
            {
                try
                {
                    if (Convert.ToDouble(dgvPlanejamento.SelectedRows[i].Cells["VALOR_CP"].Value.ToString()) > 0)
                    {
                        FbCommand update = new FbCommand();
                        update.Connection = fbConnection1;
                        update.CommandText =
                            "UPDATE CONTAS_A_RECEBER SET DATA_PREVISTA_CR = '" +
                            Convert.ToDateTime(dtRemanejamento.Text).ToShortDateString().Replace("/", ".") + "' " +
                            "WHERE COD_CR = '" + dgvPlanejamento.SelectedRows[i].Cells["COD_CR"].Value.ToString() + "'";
                        FbDataAdapter datContas_a_receber = new FbDataAdapter();
                        datContas_a_receber.UpdateCommand = update;
                        fbConnection1.Open();
                        datContas_a_receber.UpdateCommand.ExecuteNonQuery();
                        fbConnection1.Close();
                    }
                    if (Convert.ToDouble(dgvPlanejamento.SelectedRows[i].Cells["VALOR_CP"].Value.ToString()) < 0)
                    {
                        FbCommand update = new FbCommand();
                        update.Connection = fbConnection1;
                        update.CommandText =
                            "UPDATE CONTAS_A_PAGAR SET DATA_PREVISTA_CP = '" +
                            Convert.ToDateTime(dtRemanejamento.Text).ToShortDateString().Replace("/", ".") + "' " +
                            "WHERE COD_CP = '" + dgvPlanejamento.SelectedRows[i].Cells["COD_CR"].Value.ToString() + "'";

                        datContas_a_pagar.UpdateCommand = update;
                        fbConnection1.Open();
                        datContas_a_pagar.UpdateCommand.ExecuteNonQuery();
                        fbConnection1.Close();
                    }

                }
                catch (Exception a)
                {
                    fbConnection1.Close();
                    MessageBox.Show(a.ToString());
                }
            }
            filtrar();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                dsPlanejamento plan = new dsPlanejamento();
                for (int i = 0; i < dgvPlanejamento.RowCount; i++)
                {
                    try
                    {
                        int baixado = 0;
                        try
                        {
                            baixado = Convert.ToInt32(dgvPlanejamento.Rows[i].Cells[7].Value.ToString());
                        }
                        catch { }


                        plan.Planejamento.AddPlanejamentoRow(dgvPlanejamento.Rows[i].Cells["COD_CR"].Value.ToString(),
                            dgvPlanejamento.Rows[i].Cells["DESCRICAO_CC_CP"].Value.ToString(),
                            dgvPlanejamento.Rows[i].Cells["DUPLICATA_CP"].Value.ToString(),
                            Convert.ToDateTime(dgvPlanejamento.Rows[i].Cells["DATA_PREVISTA_CP"].Value.ToString()),
                            dgvPlanejamento.Rows[i].Cells["PLANO_CP"].Value.ToString(),
                            dgvPlanejamento.Rows[i].Cells["DESCRICAO_CP"].Value.ToString(),
                            Convert.ToDouble(dgvPlanejamento.Rows[i].Cells["VALOR_CP"].Value.ToString()),
                            baixado,
                            dgvPlanejamento.Rows[i].Cells["OBSERVACOES_CP"].Value.ToString(),
                            dgvPlanejamento.Rows[i].Cells["RAZAO_FORNECEDOR_CP"].Value.ToString(),
                            Convert.ToDouble(dgvPlanejamento.Rows[i].Cells["SALDO"].Value.ToString()),
                            dgvPlanejamento.Rows[i].Cells["NF_CP"].Value.ToString());
                    }
                    catch { }
                }

                if (cbPor_data.Checked)
                    plan.Periodo.AddPeriodoRow(Convert.ToDateTime(dtInicio.Text),
                        Convert.ToDateTime(dtTermino.Text));
                else if (cbxMes.Checked)
                    plan.Periodo.AddPeriodoRow(Convert.ToDateTime(dataIniMes),
                        Convert.ToDateTime(dataFimMes));
                crImp_planejamento_geral cr = new crImp_planejamento_geral();
                cr.SetDataSource(plan);

                form_imprimir imprimir = new form_imprimir(cr);
                imprimir.Show();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
               if (tb_forn_cliente.Text != "")
                {
                    cliente = " AND (RAZAO_FORNECEDOR_CP LIKE '*" + tb_forn_cliente.Text + "*' OR NOME_FANTASIA LIKE '*" + tb_forn_cliente.Text + "*') ";
                }
                else
                    cliente = "";
                filtro();
            }
            catch { }

        }

        private void tb_plano_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tb_plano.Text != "")
                {
                    plano = " AND PLANO_CP LIKE '" + tb_plano.Text + "'";
                }
                else
                    plano = "";
                filtro();
            }
            catch { }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvPlanejamento.SelectedRows.Count > 0 && !verificar_se_sao_positivos())
            {
                inserir_malote_cp();
            }
        }

        private void inserir_malote_cp()
        {
            form_malote malote = new form_malote();
            try
            {
                malote.debito = true;
                malote.n_itens_malote = dgvPlanejamento.SelectedRows.Count;
                string[] itens = new string[100];
                for (int i = 0; i < dgvPlanejamento.SelectedRows.Count; i++)
                {
                    try
                    {
                        itens[i] = dgvPlanejamento.SelectedRows[i].Cells["COD_CR"].Value.ToString();
                    }
                    catch { }
                }
                malote._itens = itens;
                malote.novo = true;
                malote.ShowDialog();
            }
            finally
            {
                filtrar();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (dgvPlanejamento.SelectedRows.Count > 0 && !verificar_se_sao_negativos())
            {
                inserir_malote_cr();
            }
        }

        private void inserir_malote_cr()
        {
            form_malote malote = new form_malote();
            try
            {
                malote.credito = true;
                malote.n_itens_malote = dgvPlanejamento.SelectedRows.Count;
                string[] itens = new string[100];
                for (int i = 0; i < dgvPlanejamento.SelectedRows.Count; i++)
                {
                    itens[i] = dgvPlanejamento.SelectedRows[i].Cells["COD_CR"].Value.ToString();
                }
                malote._itens = itens;
                malote.novo = true;
                malote.ShowDialog();
            }
            finally
            {
                filtrar();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                dsPlanejamento plan = new dsPlanejamento();
                for (int i = 0; i < dgvPlanejamento.RowCount; i++)
                {
                    try
                    {
                        int baixado = 0;
                        try
                        {
                            baixado = Convert.ToInt32(dgvPlanejamento.Rows[i].Cells[7].Value.ToString());
                        }
                        catch { }
                        plan.Planejamento.AddPlanejamentoRow(dgvPlanejamento.Rows[i].Cells["COD_CR"].Value.ToString(),
                            dgvPlanejamento.Rows[i].Cells["DESCRICAO_CC_CP"].Value.ToString(),
                            dgvPlanejamento.Rows[i].Cells["DUPLICATA_CP"].Value.ToString(),
                            Convert.ToDateTime(dgvPlanejamento.Rows[i].Cells["DATA_PREVISTA_CP"].Value.ToString()),
                            dgvPlanejamento.Rows[i].Cells["PLANO_CP"].Value.ToString(),
                            dgvPlanejamento.Rows[i].Cells["DESCRICAO_CP"].Value.ToString(),
                            Convert.ToDouble(dgvPlanejamento.Rows[i].Cells["VALOR_CP"].Value.ToString()),
                            baixado,
                            dgvPlanejamento.Rows[i].Cells["OBSERVACOES_CP"].Value.ToString(),
                            dgvPlanejamento.Rows[i].Cells["RAZAO_FORNECEDOR_CP"].Value.ToString(),
                            Convert.ToDouble(dgvPlanejamento.Rows[i].Cells["SALDO"].Value.ToString()),
                            dgvPlanejamento.Rows[i].Cells["NF_CP"].Value.ToString());
                    }
                    catch { }
                }

                if (cbPor_data.Checked)
                    plan.Periodo.AddPeriodoRow(Convert.ToDateTime(dtInicio.Text),
                        Convert.ToDateTime(dtTermino.Text));
                else if (cbxMes.Checked)
                    plan.Periodo.AddPeriodoRow(Convert.ToDateTime(dataIniMes),
                        Convert.ToDateTime(dataFimMes));
                crImp_planejamento_plano cr = new crImp_planejamento_plano();
                cr.SetDataSource(plan);

                form_imprimir imprimir = new form_imprimir(cr);
                imprimir.Show();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void tb_saldo_inicial_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxMes_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxMes.Checked)
            {
                cbPor_data.Checked = false;
            }
        }

        private void cbPor_data_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPor_data.Checked)
            {
                cbxMes.Checked = false;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            somarTotalFiltro();
        }
        private void somarTotalFiltro()
        {
            double soma = 0;
            for (int i = 0; i < dgvPlanejamento.RowCount; i++)
            {
                try
                {
                    soma = soma + Convert.ToDouble(dgvPlanejamento.Rows[i].Cells["VALOR_CP"].Value.ToString());

                }
                catch { }
            }
            tb_somatorio.Text = soma.ToString("n2");
        }

        private void tb_vendedor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tb_vendedor.Text != "")
                {
                    vendedor = " and CARTEIRA_CP LIKE '*" + tb_vendedor.Text + "*'";
                }
                else
                    vendedor = "";
                filtro();
            }
            catch { };

        }

        private void ckb_pago_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_pago.Checked)
                ckb_naoPago.Checked = false;
        }

        private void ckb_naoPago_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_naoPago.Checked)
                ckb_pago.Checked = false;
        }

        private void ckbVendedor_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbVendedor.Checked)
                cb_mostrar_apenas_cr.Checked = true;
        }



        private void btnIr_Click(object sender, EventArgs e)
        {
            buscar_linha_de_hoje(Convert.ToDateTime(dateTimeIr.Value));
        }

        private void cb_mostrar_apenas_cp_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_mostrar_apenas_cp.Checked)
            {
                cb_mostrar_apenas_cr.Checked = false;
                ckbVendedor.Checked = false;
            }
        }

        private void cb_mostrar_apenas_cr_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_mostrar_apenas_cr.Checked)
            {
                cb_mostrar_apenas_cp.Checked = false;
            }
        }

        private void btnUltimosMeses_Click(object sender, EventArgs e)
        {
            int mes = DateTime.Now.Month;
            int ano = DateTime.Now.Year;
            DateTime inicioConsulta = new DateTime(ano, mes, 1);
            DateTime fim = new DateTime();
            dsPlanejamento plan = new dsPlanejamento();
            string[] mesEscrito = new string[5];
            CultureInfo cult = new CultureInfo("pt-BR");
            DateTimeFormatInfo dtf = cult.DateTimeFormat;
            mesEscrito[0] = cult.TextInfo.ToTitleCase(dtf.GetMonthName(inicioConsulta.AddMonths(-5).Month));
            mesEscrito[1] = cult.TextInfo.ToTitleCase(dtf.GetMonthName(inicioConsulta.AddMonths(-4).Month));
            mesEscrito[2] = cult.TextInfo.ToTitleCase(dtf.GetMonthName(inicioConsulta.AddMonths(-3).Month));
            mesEscrito[3] = cult.TextInfo.ToTitleCase(dtf.GetMonthName(inicioConsulta.AddMonths(-2).Month));
            mesEscrito[4] = cult.TextInfo.ToTitleCase(dtf.GetMonthName(inicioConsulta.AddMonths(-1).Month));
            plan.Meses.AddMesesRow(mesEscrito[0], mesEscrito[1], mesEscrito[2], mesEscrito[3], mesEscrito[4]);
            try
            {
                FbCommand selectPlano = new FbCommand();
                selectPlano.Connection = fbConnection1;
                selectPlano.CommandText =
                    "SELECT * FROM PLANOS";
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.SelectCommand = selectPlano;
                fbConnection1.Open();
                DataSet dsTabela = new DataSet();
                datTabela.Fill(dsTabela);
                fbConnection1.Close();
                double total = 0;
                double[] totalPlano = new double[5];
                double totalGeral = 0;
                foreach (DataRow dr in dsTabela.Tables[0].Rows)
                {
                    totalGeral = 0;
                    int j = 0;
                    for (int i = 5; i > 0; i--)
                    {

                        DateTime inicio = inicioConsulta.AddMonths((-(i)));
                        fim = inicio.AddMonths(1);
                        total = 0;
                        try
                        {
                            FbCommand selectValor = new FbCommand();
                            selectValor.Connection = fbConnection1;
                            selectValor.CommandText =
                                "SELECT SUM(VALOR_CP) FROM CONTAS_A_PAGAR WHERE COD_PLANO_CP = '" + dr[0].ToString() + "' " +
                                "AND DATA_PREVISTA_CP >= '" + inicio.ToShortDateString().Replace("/", ".") + "' " +
                                "AND DATA_PREVISTA_CP < '" + fim.ToShortDateString().Replace("/", ".") + "'";
                            fbConnection1.Open();
                            FbDataAdapter datValor = new FbDataAdapter();
                            datValor.SelectCommand = selectValor;
                            DataSet dsValor = new DataSet();
                            datValor.Fill(dsValor);
                            fbConnection1.Close();
                            foreach (DataRow drV in dsValor.Tables[0].Rows)
                            {
                                if (drV[0].ToString() != "")
                                {
                                    total += Convert.ToDouble(drV[0].ToString());
                                }
                            }
                            selectValor = new FbCommand();
                            selectValor.Connection = fbConnection1;
                            selectValor.CommandText =
                                "SELECT SUM(VALOR_CR) FROM CONTAS_A_RECEBER WHERE COD_PLANO_CR = '" + dr[0].ToString() + "' " +
                                "AND DATA_PREVISTA_CR >= '" + inicio.ToShortDateString().Replace("/", ".") + "' " +
                                "AND DATA_PREVISTA_CR < '" + fim.ToShortDateString().Replace("/", ".") + "'";
                            fbConnection1.Open();
                            datValor = new FbDataAdapter();
                            datValor.SelectCommand = selectValor;
                            dsValor = new DataSet();
                            datValor.Fill(dsValor);
                            fbConnection1.Close();
                            foreach (DataRow drV in dsValor.Tables[0].Rows)
                            {
                                if (drV[0].ToString() != "")
                                {
                                    total += Convert.ToDouble(drV[0].ToString());
                                }
                            }
                        }
                        catch (Exception a)
                        {
                            MessageBox.Show(a.Message);
                            fbConnection1.Close();
                        }
                        totalGeral += total;
                        totalPlano[j] = total;
                        j++;
                    }
                    plan.UltimosMeses.AddUltimosMesesRow(dr[1].ToString(), totalPlano[0], totalPlano[1], totalPlano[2], totalPlano[3], totalPlano[4], totalGeral);
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
                fbConnection1.Close();
            }
            crPlanejamentoPlanoUltimosMeses crPlan = new crPlanejamentoPlanoUltimosMeses();
            crPlan.SetDataSource(plan);
            form_imprimir imp = new form_imprimir(crPlan);
            imp.Show();
        }
        private void selecionar_dados_cliente(string cod, out string logradouro, out string bairro, out string cep, out string cidade,
      out string complemento, out string numero, out string uf, out string cnpj)
        {
            logradouro = ""; bairro = ""; cep = ""; cidade = ""; complemento = ""; numero = ""; uf = ""; cnpj = "";
            try
            {
                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT ENDERECO, BAIRRO, CEP_CLIENTE, CIDADE, COMPLEMENTO_CLIENTE, NUMERO_CLIENTE, ESTADO, CNPJ FROM CLIENTES " +
                    " WHERE COD_CLIENTE = '" + cod + "'";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    logradouro = dr[0].ToString();
                    bairro = dr[1].ToString();
                    cep = dr[2].ToString();
                    cidade = dr[3].ToString();
                    complemento = dr[4].ToString();
                    numero = dr[5].ToString();
                    uf = dr[6].ToString();
                    cnpj = dr[7].ToString();
                }

            }
            catch (Exception a)
            {
                fbConnection1.Close();
            }
        }

        private bool verificar_se_e_boleto()
        {
            try
            {
                for (int i = 0; i < dgvPlanejamento.SelectedRows.Count; i++)
                {
                    FbCommand select = new FbCommand();
                    select.CommandText =
                        "SELECT BOLETO_FORMA_PGTO FROM FORMA_PGTO WHERE DESCRICAO_FORMA_PGTO = '" + dgvPlanejamento.SelectedRows[i].Cells["FORMA_PGTO_CR"].Value.ToString() + "'";
                    select.Connection = fbConnection1;
                    fbConnection1.Open();
                    FbDataAdapter datSelect = new FbDataAdapter();
                    datSelect.SelectCommand = select;
                    DataTable dtSelect = new DataTable();
                    datSelect.Fill(dtSelect);
                    fbConnection1.Close();
                    if (dtSelect.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dtSelect.Rows)
                        {
                            if (dr[0].ToString() != "1")
                                return false;
                        }
                    }
                    else
                    {
                        return false;
                    }

                }
                return true;
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
                return false;
            }
        }
        // public short _codigoBanco;
        private void button14_Click(object sender, EventArgs e)
        {
            if (verificar_se_e_boleto())
            {
                if (verificar_cr_com_banco_selecionado())
                {
                    if (CodigoBanco == 237)
                    {
                        gerar_remessa_bradesco();
                    }
                    if (CodigoBanco == 341)
                    {
                        gerar_remessa_itau();
                    }
                    if (CodigoBanco == 104)
                    {
                        gerar_remessa_caixa();
                    }
                    if (CodigoBanco == 33)
                    {
                        gerar_remessa_santander();
                    }
                }
                else
                {
                    MessageBox.Show("Existem linhas selecionadas que não são do Banco: " + _descricao_banco + ". \n Por favor verifique.");
                }

            }
            else
            {
                MessageBox.Show("Analisando a forma de pagamento dos recebíveis, foram identificados itens que não são boletos ou não foi possível identificar a forma de pagamento. Por favor verifique");
            }

        }

        private bool verificar_cr_com_banco_selecionado()
        {
            for (int i = 0; i < dgvPlanejamento.SelectedRows.Count; i++)
            {
                if (dgvPlanejamento.SelectedRows[i].Cells["DESCRICAO_CC_CP"].Value.ToString() != _descricao_banco &&
                    dgvPlanejamento.SelectedRows[i].Cells["DESCRICAO_CC_CP"].Value.ToString() != "")
                    return false;
            }
            return true;
        }

        private string zero_a_esquerda_caixa(int tamanho_pretendido, string valor)
        {
            tamanho_pretendido = tamanho_pretendido - 2; //por causa do 14 na frente (Caixa) 
            int tamanho = valor.Length;
            for (int p = 0; p < tamanho_pretendido - tamanho; p++)
            {
                valor = "0" + valor;
            }
            valor = "14" + valor;
            return valor;
        }

        /*
        private void gerar_remessa_caixa()
        {
            try
            {


                BoletoBancario bb;
                // IBanco _ibanco = new IBanco();
                // _ibanco.
                Boletos boletos = new Boletos();
                //  List<BoletoBancario> boletos = new List<BoletoBancario>();
                //CEDENTE
                Cedente c = new Cedente(cnpj_empresa, razao_social_empresa, _agencia, _dig_agencia, _cc, _dig_cc);
                c.Codigo = _codigo_no_banco;

                //    Boleto _b = new Boleto();

                DataTable dtItens_cr = new DataTable();
                DataColumn coluna_1 = new DataColumn();
                dtItens_cr.Columns.Add(coluna_1);
                for (int i = 0; i < dgvPlanejamento.SelectedRows.Count; i++)
                {

                    //    bb = new BoletoBancario();
                    //      bb.CodigoBanco = _codigoBanco;
                    //     bb.OcultarInstrucoes = true;
                    //      bb.MostrarComprovanteEntrega = true;
                    DateTime vencimento = Convert.ToDateTime(dgvPlanejamento.SelectedRows[i].Cells["DATA_PREVISTA_CP"].Value);

                    //Instrucao_Bradesco item = new Instrucao_Bradesco(6, 5);

                    Instrucao_Caixa item = new Instrucao_Caixa(9, 5);
                    //Instrucao_Caixa item2 = new Instrucao_Caixa(81, 10);




                    //cliente
                    string logradouro, bairro, cep, cidade, complemento, numero, uf, cnpj;
                    selecionar_dados_cliente(dgvPlanejamento.SelectedRows[i].Cells["COD_FORNECEDOR_CP"].Value.ToString(), out logradouro, out bairro, out cep, out cidade, out complemento, out numero, out uf, out cnpj);

                    Endereco end = new Endereco();
                    end.Bairro = bairro;
                    end.CEP = cep;
                    end.Cidade = cidade;
                    end.Complemento = complemento;
                    end.End = logradouro + ", " + numero + " - " + complemento;
                    end.Logradouro = logradouro;
                    end.Numero = numero;
                    end.UF = estado_empresa;


                    string nosso_numero = "";
                    DateTime data_nota = buscar_data_nota(dgvPlanejamento.SelectedRows[i].Cells["NF_CP"].Value.ToString());
                    if (data_nota <= Convert.ToDateTime("23.12.2015"))
                    {
                        nosso_numero = dgvPlanejamento.SelectedRows[i].Cells["NF_CP"].Value.ToString();
                    }
                    else
                    {//cliente + duplicata + nf(pedido)
                        int duplicata = i + 1;
                        nosso_numero = dgvPlanejamento.SelectedRows[i].Cells["COD_FORNECEDOR_CP"].Value.ToString() + duplicata.ToString() +
                            dgvPlanejamento.SelectedRows[i].Cells["NF_CP"].Value.ToString();
                        if (nosso_numero.Length < 10)
                        {
                            nosso_numero = zero_a_esquerda_caixa(17, nosso_numero);
                        }

                    }

                    dtItens_cr.Rows.Add(dgvPlanejamento.SelectedRows[i].Cells["COD_CR"].Value.ToString());

                    int digito = i + 1;
                    Boleto b = new Boleto(vencimento, Convert.ToDecimal(dgvPlanejamento.SelectedRows[i].Cells["VALOR_CP"].Value.ToString()), _carteira, nosso_numero, c);
                    b.NumeroDocumento = nosso_numero;
                    EspecieDocumento especie = new EspecieDocumento(104);
                    especie.Codigo = "01";
                    b.EspecieDocumento = especie;
                    string _nome_sacado = dgvPlanejamento.SelectedRows[i].Cells["RAZAO_FORNECEDOR_CP"].Value.ToString();

                    b.Sacado = new Sacado(cnpj, _nome_sacado);
                    b.Sacado.Endereco = end;
                    b.Banco = new Banco(104);

                    item.Descricao += " *** VALORES EXPRESSOS EM REAIS *** <br>";

                    double mora = 0;
                    try
                    {
                        mora = Convert.ToDouble(dgvPlanejamento.SelectedRows[i].Cells["VALOR_CP"].Value.ToString()) * Convert.ToDouble(_mora);
                    }
                    catch { }
                    string teste = dgvPlanejamento.SelectedRows[i].Cells["VALOR_CP"].Value.ToString();
                    double multa = 0;
                    try
                    {
                        multa = Convert.ToDouble(dgvPlanejamento.SelectedRows[i].Cells["VALOR_CP"].Value.ToString()) * Convert.ToDouble(_multa);
                    }
                    catch { }

                    item.Descricao += " MORA DIA/COM. PERMANÊNCIA ................................. " + mora.ToString("n2") + "<br>";
                    item.Descricao += " APÓS " + vencimento.ToShortDateString() + " MULTA ................................. " + multa.ToString("n2") + "<br>";
                    item.Descricao += " DEPÓSITO BANCÁRIO NÃO QUITA O BOLETO" + "<br>";
                    item.Descricao += " PROTESTO AUTOMÁTICO APÓS " + item.QuantidadeDias.ToString() + " DIAS" + "<br>";
                    b.Instrucoes.Add(item); //"Não Receber após o vencimento");
                   // b.Instrucoes.Add(item2);
                    b.Cedente = c;
                    //         bb.Boleto = b;
                    //        bb.Boleto.Valida();

                    Remessa rem = new Remessa();
                    rem.Ambiente = Remessa.TipoAmbiemte.Producao;
                    b.Remessa = rem;
                    boletos.Add(b);
                    //  _b = b;
                    
                }
                // _b.Banco = new Banco(237);
                boletos.Cedente = c;
               
                BoletoNet.ArquivoRemessa novo = new BoletoNet.ArquivoRemessa(BoletoNet.TipoArquivo.CNAB400);
                int numero_remessa = buscar_numero_remessa();
                //IBanco _banco2 = new IBanco();
                //Banco _banco = new Banco(237);

                //StreamWriter textStream = new StreamWriter(@"c:\\evolucao\\remessas\" + numero_remessa.ToString() + ".rem");
                // Stream arquivo = new Stream();
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string vMsgRetorno = string.Empty;
                    bool vValouOK = novo.ValidarArquivoRemessa(_cod_banco, boletos[0].Banco, c, boletos, 1, out vMsgRetorno);
                    if(!vValouOK)
                   {
                       MessageBox.Show(String.Concat("Foram localizados inconsistências na validação da remessa!", Environment.NewLine, vMsgRetorno),
                                       "Teste",
                                        MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
                   }
                   else
                  {
                        
                        novo.GerarArquivoRemessa(_cod_banco, boletos[0].Banco, c, boletos, saveFileDialog1.OpenFile(), numero_remessa);
                        //arquivo.GerarArquivoRemessa("0", banco, cedente, boletos, saveFileDialog.OpenFile(), 1);
                        //VINCULAR CR A esta remessa
                        vincular_numero_remessa_com_cr(numero_remessa, dtItens_cr);
                        MessageBox.Show("Arquivo gerado com sucesso!", "Teste",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
               }
            }
            catch { }
        }
        */


        public void GeraArquivoCNAB240(IBanco banco, Cedente cedente, Boletos boletos)
        {
            saveFileDialog1.Filter = "Arquivos de Retorno (*.rem)|*.rem|Todos Arquivos (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ArquivoRemessa arquivo = new ArquivoRemessa(TipoArquivo.CNAB240);
                arquivo.GerarArquivoRemessa("1200303001417053", banco, cedente, boletos, saveFileDialog1.OpenFile(), 1);

                MessageBox.Show("Arquivo gerado com sucesso!", "Teste",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }

        private void gerar_remessa_caixa()
        {
            string[] multa_ = new string[1000];
            try
            {

                int numero_remessa = buscar_numero_remessa();

                BoletoBancario bb;

                Boletos boletos = new Boletos();
                ContaBancaria conta = new ContaBancaria();
                conta.OperacaConta = "OPE";
                conta.Agencia = _agencia;
                conta.DigitoAgencia = _dig_agencia;
                conta.Conta = _cc;
                conta.DigitoConta = _dig_cc;


                //CEDENTE
                Cedente c = new Cedente(cnpj_empresa, razao_social_empresa, _agencia, _dig_agencia, _cc, _dig_cc);
                c.Codigo = _codigo_no_banco;
                c.ContaBancaria = conta;
                c.Convenio = Convert.ToInt32(_codigo_no_banco);
                //    Boleto _b = new Boleto();
                c.NumeroSequencial = numero_remessa;
                DataTable dtItens_cr = new DataTable();
                DataColumn coluna_1 = new DataColumn();
                dtItens_cr.Columns.Add(coluna_1);
                for (int i = 0; i < dgvPlanejamento.SelectedRows.Count; i++)
                {

                    DateTime vencimento = Convert.ToDateTime(dgvPlanejamento.SelectedRows[i].Cells["DATA_PREVISTA_CP"].Value);
                    Instrucao_Caixa item = new Instrucao_Caixa(92, 30);

                    //cliente
                    string logradouro, bairro, cep, cidade, complemento, numero, uf, cnpj;
                    selecionar_dados_cliente(dgvPlanejamento.SelectedRows[i].Cells["COD_FORNECEDOR_CP"].Value.ToString(), out logradouro, out bairro, out cep, out cidade, out complemento, out numero, out uf, out cnpj);

                    Endereco end = new Endereco();
                    end.Bairro = bairro;
                    end.CEP = cep;
                    end.Cidade = cidade;
                    end.Complemento = complemento;
                    end.End = logradouro + ", " + numero + " - " + complemento;
                    //  end.Logradouro = logradouro;
                    end.Numero = numero;
                    end.UF = estado_empresa;


                    string nosso_numero = "";
                    DateTime data_nota = buscar_data_nota(dgvPlanejamento.SelectedRows[i].Cells["NF_CP"].Value.ToString());
                    if (data_nota <= Convert.ToDateTime("23.12.2015"))
                    {
                        nosso_numero = dgvPlanejamento.SelectedRows[i].Cells["NF_CP"].Value.ToString();
                    }
                    else
                    {//cliente + duplicata + nf(pedido)
                        int duplicata = 1;
                        try
                        {
                            duplicata = Convert.ToInt16(dgvPlanejamento.SelectedRows[i].Cells["DUPLICATA_CP"].Value.ToString());
                        }
                        catch { }

                        if (boleto_pedido_empresa == "1")
                        {
                            nosso_numero = duplicata.ToString() +
                                dgvPlanejamento.SelectedRows[i].Cells["NF_CP"].Value.ToString();
                        }
                        else
                        {
                            nosso_numero = dgvPlanejamento.SelectedRows[i].Cells["COD_FORNECEDOR_CP"].Value.ToString() + duplicata.ToString() +
                                dgvPlanejamento.SelectedRows[i].Cells["NF_CP"].Value.ToString();
                        }

                        if (nosso_numero.Length < 17)
                        {
                            nosso_numero = zero_a_esquerda_caixa(17, nosso_numero);
                        }

                    }

                    dtItens_cr.Rows.Add(dgvPlanejamento.SelectedRows[i].Cells["COD_CR"].Value.ToString());

                    int digito = i + 1;
                    Boleto b = new Boleto(vencimento, Convert.ToDecimal(dgvPlanejamento.SelectedRows[i].Cells["VALOR_CP"].Value.ToString()), _carteira, nosso_numero, c);
                    b.NossoNumero = nosso_numero;
                    b.NumeroDocumento = dgvPlanejamento.SelectedRows[i].Cells["NF_CP"].Value.ToString();
                    EspecieDocumento especie = new EspecieDocumento(Convert.ToInt16(_cod_banco));
                    especie.Codigo = "01";
                    b.EspecieDocumento = especie;
                    string _nome_sacado = dgvPlanejamento.SelectedRows[i].Cells["RAZAO_FORNECEDOR_CP"].Value.ToString();
                    b.Carteira = _carteira;
                    b.Sacado = new Sacado(cnpj, _nome_sacado);
                    b.Sacado.Endereco = end;
                    b.Banco = new Banco(Convert.ToInt16(_cod_banco));


                    item.Descricao += " *** VALORES EXPRESSOS EM REAIS *** <br>";

                    double mora = 0;
                    try
                    {
                        mora = Convert.ToDouble(dgvPlanejamento.SelectedRows[i].Cells["VALOR_CP"].Value.ToString()) * Convert.ToDouble(_mora);
                    }
                    catch { }
                    string teste = dgvPlanejamento.SelectedRows[i].Cells["VALOR_CP"].Value.ToString();
                    double multa = 0;
                    try
                    {
                        multa = Convert.ToDouble(dgvPlanejamento.SelectedRows[i].Cells["VALOR_CP"].Value.ToString()) * Convert.ToDouble(_multa);
                    }
                    catch { }
                    multa_[i] = multa.ToString("n2").Replace(",", "");
                    b.DataDocumento = DateTime.Now;
                    b.JurosMora = Convert.ToDecimal(mora);
                    b.PercJurosMora = Convert.ToDecimal(_mora);
                    b.DataMulta = vencimento;
                    b.ValorMulta = Convert.ToDecimal(multa);
                    b.PercMulta = Convert.ToDecimal(_multa);
                    b.ValorDesconto = 0;

                    b.Cedente = c;



                    Remessa rem = new Remessa();
                    rem.Ambiente = Remessa.TipoAmbiente.Producao;
                    rem.TipoDocumento = "1";
                    rem.CodigoOcorrencia = string.Empty;
                    b.Instrucoes.Add(item);
                    b.Remessa = rem;
                    boletos.Add(b);
                }
                boletos.Cedente = c;


                BoletoNet.ArquivoRemessa novo = new BoletoNet.ArquivoRemessa(BoletoNet.TipoArquivo.CNAB240);

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string vMsgRetorno = string.Empty;
                    bool vValouOK = novo.ValidarArquivoRemessa(_codigo_no_banco, boletos[0].Banco, c, boletos, numero_remessa, out vMsgRetorno);
                    if (!vValouOK)
                    {
                        MessageBox.Show(String.Concat("Foram localizados inconsistências na validação da remessa!", Environment.NewLine, vMsgRetorno),
                                        "Teste",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    else
                    {

                        novo.GerarArquivoRemessa(_codigo_no_banco, boletos[0].Banco, c, boletos, saveFileDialog1.OpenFile(), numero_remessa);
                        vincular_numero_remessa_com_cr(numero_remessa, dtItens_cr);
                        
                        string caminho = saveFileDialog1.FileName;
                        StreamReader objReader = new StreamReader(caminho);
                        ArrayList arrText = new ArrayList();
                        string arquivo = objReader.ReadToEnd();
                        objReader.Close();
                        string[] texto;
                        texto = Regex.Split(arquivo, "\n");

                        StreamWriter Arquivo;
                        try
                        {
                            Arquivo = new StreamWriter(caminho);
                            Arquivo.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        FileInfo t = new FileInfo(caminho);
                        int p = 0;
                        using (StreamWriter text = t.CreateText())
                        {
                            for (int i = 0; i < texto.Length; i++)
                            {
                                try
                                {
                                    if (texto[i].Substring(13, 1) == "P")
                                    {
                                        texto[i] = texto[i].Remove(40,4);
                                        texto[i] = texto[i].Insert(40, "1400");
                                    }
                                    if (texto[i].Substring(13, 1) == "R")
                                    {                                        
                                        multa_[p] = completar_com_zeros(15, multa_[p]);
                                        texto[i] = texto[i].Remove(74, 15);
                                        texto[i] = texto[i].Insert(74, multa_[p]);
                                        string numero = completar_com_zeros(5, (i - 1).ToString());
                                        texto[i] = texto[i].Remove(8, 5);
                                        texto[i] = texto[i].Insert(8, numero);
                                        texto[i] = texto[i].Remove(17, 48);
                                        texto[i] = texto[i].Insert(17, "000000000000000000000000000000000000000000000000");
                                        texto[i] = texto[i].Insert(238, "  ");
                                        p++;
                                    }
                                    text.Write(texto[i]);
                                }
                                catch { }
                            }
                        }

                        MessageBox.Show("Arquivo gerado com sucesso!", "Teste",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);

                    }
                }
            }
            catch { }
        }

        private string completar_com_zeros(int tamanho, string valor)
        {             
            int i = valor.Length;
            for (int p = 0; p < tamanho - i; p++)
            {
                valor = "0" + valor;
            }
           
            return valor;
        }

        private void gerar_remessa_sicredi()
        {
            try
            {
                Boletos boletos = new Boletos();

                //CEDENTE
                Cedente c = new Cedente(cnpj_empresa, razao_social_empresa, _agencia, _dig_agencia, _cc, _dig_cc);
                c.Codigo = _codigo_no_banco;
                DataTable dtItens_cr = new DataTable();
                DataColumn coluna_1 = new DataColumn();
                dtItens_cr.Columns.Add(coluna_1);
                for (int i = 0; i < dgvPlanejamento.SelectedRows.Count; i++)
                {
                    DateTime vencimento = Convert.ToDateTime(dgvPlanejamento.SelectedRows[i].Cells["DATA_PREVISTA_CP"].Value);
                    Instrucao_Sicredi item = new Instrucao_Sicredi(9, 5);
                    //cliente
                    string logradouro, bairro, cep, cidade, complemento, numero, uf, cnpj;
                    selecionar_dados_cliente(dgvPlanejamento.SelectedRows[i].Cells["COD_FORNECEDOR_CP"].Value.ToString(), out logradouro, out bairro, out cep, out cidade, out complemento, out numero, out uf, out cnpj);

                    Endereco end = new Endereco();
                    end.Bairro = bairro;
                    end.CEP = cep;
                    end.Cidade = cidade;
                    end.Complemento = complemento;
                    end.End = logradouro + ", " + numero + " - " + complemento;
                    end.Numero = numero;
                    end.UF = estado_empresa;

                    string nosso_numero = "";
                    string cliente = "";
                    DateTime data_nota = buscar_data_nota(dgvPlanejamento.SelectedRows[i].Cells["NF_CP"].Value.ToString());

                    int duplicata = 1;
                    try
                    {
                        duplicata = Convert.ToInt16(dgvPlanejamento.SelectedRows[i].Cells["DUPLICATA_CP"].Value.ToString());
                    }
                    catch { }
                    nosso_numero = duplicata.ToString() +
                            dgvPlanejamento.SelectedRows[i].Cells["NF_CP"].Value.ToString();

                    dtItens_cr.Rows.Add(dgvPlanejamento.SelectedRows[i].Cells["COD_CR"].Value.ToString());

                    int digito = i + 1;
                    Boleto b = new Boleto(vencimento, Convert.ToDecimal(dgvPlanejamento.SelectedRows[i].Cells["VALOR_CP"].Value.ToString()), _carteira, nosso_numero, c);
                    b.NumeroDocumento = nosso_numero;
                    EspecieDocumento especie = new EspecieDocumento(CodigoBanco);
                    especie.Codigo = "01";
                    b.EspecieDocumento = especie;
                    string _nome_sacado = dgvPlanejamento.SelectedRows[i].Cells["RAZAO_FORNECEDOR_CP"].Value.ToString();
                    b.DataDocumento = DateTime.Now;
                    b.DataProcessamento = DateTime.Now;
                    b.Sacado = new Sacado(cnpj, _nome_sacado);
                    b.Sacado.Endereco = end;
                    b.Banco = new Banco(CodigoBanco);
                    item.Descricao += " *** VALORES EXPRESSOS EM REAIS *** <br>";
                    double mora = 0;
                    try
                    {
                        mora = Convert.ToDouble(dgvPlanejamento.SelectedRows[i].Cells["VALOR_CP"].Value.ToString()) * Convert.ToDouble(_mora) / 100;
                    }
                    catch { }
                    string teste = dgvPlanejamento.SelectedRows[i].Cells["VALOR_CP"].Value.ToString();
                    double multa = 0;
                    try
                    {
                        multa = Convert.ToDouble(dgvPlanejamento.SelectedRows[i].Cells["VALOR_CP"].Value.ToString()) * Convert.ToDouble(_multa) / 100;
                    }
                    catch { }

                    item.Descricao += " MORA DIA/COM. PERMANÊNCIA ................................. " + mora.ToString("n2") + "<br>";
                    item.Descricao += " APÓS " + vencimento.ToShortDateString() + " MULTA ................................. " + multa.ToString("n2") + "<br>";
                    item.Descricao += " DEPÓSITO BANCÁRIO NÃO QUITA O BOLETO" + "<br>";
                    item.Descricao += " PROTESTO AUTOMÁTICO APÓS " + item.QuantidadeDias.ToString() + " DIAS" + "<br>";
                    b.Instrucoes.Add(item); //"Não Receber após o vencimento");
                    b.Cedente = c;
                    boletos.Add(b);
                }
                boletos.Cedente = c;

                BoletoNet.ArquivoRemessa novo = new BoletoNet.ArquivoRemessa(BoletoNet.TipoArquivo.CNAB400);
                int numero_remessa = buscar_numero_remessa();
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string vMsgRetorno = string.Empty;
                    bool vValouOK = novo.ValidarArquivoRemessa(CodigoBanco.ToString(), boletos[0].Banco, c, boletos, 1, out vMsgRetorno);
                    if (!vValouOK)
                    {
                        MessageBox.Show(String.Concat("Foram localizados inconsistências na validação da remessa!", Environment.NewLine, vMsgRetorno),
                                        "Teste",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    else
                    {
                        novo.GerarArquivoRemessa(CodigoBanco.ToString(), boletos[0].Banco, c, boletos, saveFileDialog1.OpenFile(), numero_remessa);
                        vincular_numero_remessa_com_cr(numero_remessa, dtItens_cr);
                        MessageBox.Show("Arquivo gerado com sucesso!", "Teste",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                }
            }
            catch { }
        }
        private void selecionar_dados_cliente(string cod, out string logradouro, out string bairro, out string cep, out string cidade,
           out string complemento, out string numero, out string uf, out double desconto, out int desconto_valor, out int desconto_pontualidade,
            out string cnpj)
        {
            logradouro = ""; bairro = ""; cep = ""; cidade = ""; complemento = ""; numero = ""; uf = "";
            desconto = 0; desconto_valor = 0; desconto_pontualidade = 0; cnpj = "";
            try
            {
                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT * FROM CLIENTES " +
                    " WHERE COD_CLIENTE = '" + cod + "'";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    cnpj = dr["CNPJ"].ToString();
                    logradouro = dr["ENDERECO"].ToString();
                    bairro = dr["BAIRRO"].ToString();
                    cep = dr["CEP_CLIENTE"].ToString();
                    cidade = dr["CIDADE"].ToString();
                    complemento = dr["COMPLEMENTO_CLIENTE"].ToString();
                    numero = dr["NUMERO_CLIENTE"].ToString();
                    uf = dr["ESTADO"].ToString();
                    try
                    {
                        desconto = Convert.ToDouble(dr["DESCONTO_PONTUALIDADE_CLIENTE"].ToString());
                    }
                    catch { }
                    try
                    {
                        desconto_valor = Convert.ToInt32(dr["DESCONTO_VALOR_CLIENTE"].ToString());
                    }
                    catch { }
                    try
                    {
                        desconto_pontualidade = Convert.ToInt32(dr["DESCONTO_INSTRUCAO_CLIENTE"].ToString());
                    }
                    catch { }
                }


            }
            catch (Exception a)
            {
                fbConnection1.Close();
            }
        }

        private void gerar_remessa_itau()
        {
            try
            {


                BoletoBancario bb;
                // IBanco _ibanco = new IBanco();
                // _ibanco.
                Boletos boletos = new Boletos();
                //  List<BoletoBancario> boletos = new List<BoletoBancario>();
                //CEDENTE
                Cedente c = new Cedente(cnpj_empresa, razao_social_empresa, _agencia, _dig_agencia, _cc, _dig_cc);
                c.Codigo = _codigo_no_banco;

                //    Boleto _b = new Boleto();

                DataTable dtItens_cr = new DataTable();
                DataColumn coluna_1 = new DataColumn();
                dtItens_cr.Columns.Add(coluna_1);

                DataTable dtItens_nao_relacionados = new DataTable();
                DataColumn coluna_2 = new DataColumn();
                dtItens_nao_relacionados.Columns.Add(coluna_2);
                for (int i = 0; i < dgvPlanejamento.SelectedRows.Count; i++)
                {
                    try
                    {
                        //    bb = new BoletoBancario();
                        //      bb.CodigoBanco = _codigoBanco;
                        //     bb.OcultarInstrucoes = true;
                        //      bb.MostrarComprovanteEntrega = true;
                        DateTime vencimento = Convert.ToDateTime(dgvPlanejamento.SelectedRows[i].Cells["DATA_PREVISTA_CP"].Value);

                        Instrucao_Itau item1 = new Instrucao_Itau(9, 5);
                        Instrucao_Itau item2 = new Instrucao_Itau(81, 10);

                        //CEDENTE

                        int dias = Convert.ToInt16(_dias_protesto);

                        Instrucao_Itau item;
                        if (dias > 0)
                            item = new Instrucao_Itau(9, dias); //protesto apenas para o boleto
                        else
                            item = new Instrucao_Itau(10); //sem protesto






                        //cliente
                        string logradouro, bairro, cep, cidade, complemento, numero, uf, cnpj;
                        double desconto;
                        int desconto_valor, desconto_pontualidade;
                        selecionar_dados_cliente(dgvPlanejamento.SelectedRows[i].Cells["COD_FORNECEDOR_CP"].Value.ToString(), out logradouro, out bairro, out cep, out cidade,
                            out complemento, out numero, out uf, out desconto, out desconto_valor, out desconto_pontualidade, out cnpj);
                        // selecionar_dados_cliente(dgvPlanejamento.SelectedRows[i].Cells["COD_FORNECEDOR_CP"].Value.ToString(), out logradouro, out bairro, out cep, out cidade, out complemento, out numero, out uf, out cnpj);

                        Endereco end = new Endereco();
                        end.Bairro = bairro;
                        end.CEP = cep;
                        end.Cidade = cidade;
                        end.Complemento = complemento;
                        end.End = logradouro + ", " + numero + " - " + complemento;
                        //end.Logradouro = logradouro;
                        end.Numero = numero;
                        end.UF = estado_empresa;


                        string nosso_numero = "";
                        string cliente = "";
                        DateTime data_nota = buscar_data_nota(dgvPlanejamento.SelectedRows[i].Cells["NF_CP"].Value.ToString());
                        nosso_numero = dgvPlanejamento.SelectedRows[i].Cells["COD_CR"].Value.ToString();



                        int digito = i + 1;

                        decimal valor_boleto = 0;
                        try
                        {
                            valor_boleto = Convert.ToDecimal(dgvPlanejamento.SelectedRows[i].Cells["VALOR_CP"].Value.ToString());
                        }
                        catch { }

                        if (desconto > 0)
                        {
                            if (desconto_pontualidade == 1)
                            {

                                // valor_boleto = valor_boleto / (1 - Convert.ToDecimal(desconto) / 100); cooreto, verificar valor que está vindo do faturamento que está cheio
                                // valor_boleto = valor_boleto - (valor_boleto * Convert.ToDecimal(desconto) / 100);

                            }
                        }


                        Boleto b = new Boleto(vencimento, valor_boleto, _carteira, nosso_numero, c);
                        b.NumeroDocumento = dgvPlanejamento.SelectedRows[i].Cells["NF_CP"].Value.ToString();
                        EspecieDocumento especie = new EspecieDocumento(237);
                        especie.Codigo = "01";
                        b.EspecieDocumento = especie;
                        string _nome_sacado = dgvPlanejamento.SelectedRows[i].Cells["RAZAO_FORNECEDOR_CP"].Value.ToString();

                        b.DataDocumento = DateTime.Now;
                        b.DataProcessamento = DateTime.Now;
                        b.Sacado = new Sacado(cnpj, _nome_sacado);
                        b.Sacado.Endereco = end;
                        b.Banco = new Banco(341);

                        item.Descricao += " *** VALORES EXPRESSOS EM REAIS *** <br>";


                        string descricao_desconto = "";
                        if (desconto > 0 && desconto_pontualidade == 1)
                        {

                            b.DataDesconto = vencimento;
                            decimal _desconto = Convert.ToDecimal(dgvPlanejamento.SelectedRows[i].Cells["VALOR_CP"].Value.ToString()) * Convert.ToDecimal(desconto) / 100;
                            descricao_desconto = " CONCEDER DESCONTO DE R$ " + _desconto.ToString("n2") + " ATÉ DIA: " + vencimento.ToShortDateString();
                            b.OutrosDescontos = Convert.ToDecimal(dgvPlanejamento.SelectedRows[i].Cells["VALOR_CP"].Value.ToString()) * Convert.ToDecimal(desconto) / 100;
                            b.DataOutrosDescontos = vencimento;
                            b.ValorDesconto = _desconto;
                        }


                        double mora = 0;
                        try
                        {
                            mora = Convert.ToDouble(dgvPlanejamento.SelectedRows[i].Cells["VALOR_CP"].Value.ToString()) * Convert.ToDouble(_mora) / 100;
                        }
                        catch { }
                        string teste = dgvPlanejamento.SelectedRows[i].Cells["VALOR_CP"].Value.ToString();
                        double multa = 0;
                        try
                        {
                            multa = Convert.ToDouble(dgvPlanejamento.SelectedRows[i].Cells["VALOR_CP"].Value.ToString()) * Convert.ToDouble(_multa) / 100;
                        }
                        catch { }

                        b.JurosMora = Convert.ToDecimal(mora);
                        b.PercJurosMora = Convert.ToDecimal(_mora) * 100;
                        b.DataJurosMora = vencimento;

                        b.DataMulta = vencimento;
                        b.PercMulta = Convert.ToDecimal(_multa);


                        //item.Descricao += " MORA DIA/COM. PERMANÊNCIA ................................. " + mora.ToString("n2") + "<br>";
                        //item.Descricao += " APÓS " + vencimento.ToShortDateString() + " MULTA ................................. " + multa.ToString("n2") + "<br>";
                        //item.Descricao += " DEPÓSITO BANCÁRIO NÃO QUITA O BOLETO" + "<br>";
                        //item.Descricao += " PROTESTO AUTOMÁTICO APÓS " + item.QuantidadeDias.ToString() + " DIAS" + "<br>";

                        b.Instrucoes.Add(item); //"Não Receber após o vencimento");
                        b.Cedente = c;
                        //         bb.Boleto = b;
                        //        bb.Boleto.Valida();

                        boletos.Add(b);
                        dtItens_cr.Rows.Add(dgvPlanejamento.SelectedRows[i].Cells["COD_CR"].Value.ToString());
                    }
                    catch
                    {
                        dtItens_nao_relacionados.Rows.Add(dgvPlanejamento.SelectedRows[i].Cells["COD_CR"].Value.ToString());
                    }
                    //  _b = b;
                }
                // _b.Banco = new Banco(237);
                boletos.Cedente = c;

                BoletoNet.ArquivoRemessa novo = new BoletoNet.ArquivoRemessa(BoletoNet.TipoArquivo.CNAB400);
                int numero_remessa = buscar_numero_remessa();
                //IBanco _banco2 = new IBanco();
                //Banco _banco = new Banco(237);

                //StreamWriter textStream = new StreamWriter(@"c:\\evolucao\\remessas\" + numero_remessa.ToString() + ".rem");
                // Stream arquivo = new Stream();
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string vMsgRetorno = string.Empty;
                    bool vValouOK = novo.ValidarArquivoRemessa("341", boletos[0].Banco, c, boletos, 1, out vMsgRetorno);
                    if (!vValouOK)
                    {
                        MessageBox.Show(String.Concat("Foram localizados inconsistências na validação da remessa!", Environment.NewLine, vMsgRetorno),
                                        "Teste",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    else
                    {
                        novo.GerarArquivoRemessa("341", boletos[0].Banco, c, boletos, saveFileDialog1.OpenFile(), numero_remessa);
                        //arquivo.GerarArquivoRemessa("0", banco, cedente, boletos, saveFileDialog.OpenFile(), 1);
                        //VINCULAR CR A esta remessa
                        bool remessa = vincular_numero_remessa_com_cr(numero_remessa, dtItens_cr);
                        if (!remessa)
                        {
                            MessageBox.Show("Existem faturas que não foram relacionadas a Remessa. Verifique.");
                        }
                        if (dtItens_nao_relacionados.Rows.Count > 0)
                        {
                            string faturas = "";
                            foreach (DataRow dr in dtItens_nao_relacionados.Rows)
                            {
                                faturas += dr[0].ToString() + " - ";
                            }
                            MessageBox.Show("As faturas: " + faturas + " não foram inseridas no arquivo. Verifique.");
                        }
                        else
                        {
                            MessageBox.Show("Arquivo gerado com sucesso!", "OK",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Erro na geração da remessa. Verifique");
            }
        }
        private void gerar_remessa_santander()
        {

            try
            {


                BoletoBancario bb;
                // IBanco _ibanco = new IBanco();
                // _ibanco.
                Boletos boletos = new Boletos();
                //  List<BoletoBancario> boletos = new List<BoletoBancario>();
                //CEDENTE
                Cedente c = new Cedente(cnpj_empresa, razao_social_empresa, _agencia, _dig_agencia, _cc, _dig_cc);
                c.Codigo = _codigo_no_banco;
                c.CodigoTransmissao = _cod_transmissao;
                //    Boleto _b = new Boleto();

                DataTable dtItens_cr = new DataTable();
                DataColumn coluna_1 = new DataColumn();
                dtItens_cr.Columns.Add(coluna_1);
                for (int i = 0; i < dgvPlanejamento.SelectedRows.Count; i++)
                {
                    if (dgvPlanejamento.SelectedRows[i].Cells["FORMA_PGTO_CR"].Value.ToString().Substring(0,1) != "0")
                    {

                        //    bb = new BoletoBancario();
                        //      bb.CodigoBanco = _codigoBanco;
                        //     bb.OcultarInstrucoes = true;
                        //      bb.MostrarComprovanteEntrega = true;
                        DateTime vencimento = Convert.ToDateTime(dgvPlanejamento.SelectedRows[i].Cells["DATA_PREVISTA_CP"].Value);

                        Instrucao_Santander item = new Instrucao_Santander(6, Convert.ToInt32(_dias_protesto));
                        if (Convert.ToInt32(_dias_protesto) == 0)
                        {
                            item = new Instrucao_Santander(7);
                        }
                        //cliente
                        string logradouro, bairro, cep, cidade, complemento, numero, uf, cnpj;
                        selecionar_dados_cliente(dgvPlanejamento.SelectedRows[i].Cells["COD_FORNECEDOR_CP"].Value.ToString(), out logradouro, out bairro, out cep, out cidade, out complemento, out numero, out uf, out cnpj);

                        Endereco end = new Endereco();
                        end.Bairro = bairro;
                        end.CEP = cep;
                        end.Cidade = cidade;
                        end.Complemento = complemento;
                        end.End = logradouro + ", " + numero + " - " + complemento;
                        //end.Logradouro = logradouro;
                        end.Numero = numero;
                        end.UF = estado_empresa;


                        int duplicata = Convert.ToInt32(dgvPlanejamento.SelectedRows[i].Cells["COD_CR"].Value.ToString());
                        string nosso_numero = duplicata.ToString();

                        dtItens_cr.Rows.Add(dgvPlanejamento.SelectedRows[i].Cells["COD_CR"].Value.ToString());

                        int digito = i + 1;
                        Boleto b = new Boleto(vencimento, Convert.ToDecimal(dgvPlanejamento.SelectedRows[i].Cells["VALOR_CP"].Value.ToString()), _carteira, nosso_numero, c);
                        b.NumeroDocumento = nosso_numero;
                        EspecieDocumento especie = new EspecieDocumento(Convert.ToInt32(_cod_banco));
                        especie.Codigo = "01";
                        b.EspecieDocumento = especie;
                        string _nome_sacado = dgvPlanejamento.SelectedRows[i].Cells["RAZAO_FORNECEDOR_CP"].Value.ToString();
                        b.DataDocumento = DateTime.Now;
                        b.Sacado = new Sacado(cnpj, _nome_sacado);
                        b.Sacado.Endereco = end;
                        b.Banco = new Banco(Convert.ToInt32(_cod_banco));

                        item.Descricao += " *** VALORES EXPRESSOS EM REAIS *** <br>";

                        double mora = 0;
                        try
                        {
                            mora = Convert.ToDouble(dgvPlanejamento.SelectedRows[i].Cells["VALOR_CP"].Value.ToString()) * Convert.ToDouble(_mora) / 100;
                        }
                        catch { }
                        string teste = dgvPlanejamento.SelectedRows[i].Cells["VALOR_CP"].Value.ToString();
                        double multa = 0;
                        try
                        {
                            multa = Convert.ToDouble(dgvPlanejamento.SelectedRows[i].Cells["VALOR_CP"].Value.ToString()) * Convert.ToDouble(_multa) / 100;
                        }
                        catch { }


                        b.JurosMora = Convert.ToDecimal(mora);
                        double _perc_mora = Convert.ToDouble(_mora);

                        b.PercJurosMora = Convert.ToDecimal(_perc_mora);

                        b.ValorMulta = Convert.ToDecimal(multa);
                        double _perc_multa = Convert.ToDouble(_multa);
                        b.PercMulta = Convert.ToDecimal(_perc_multa);
                        // item.Descricao += " MORA DIA/COM. PERMANÊNCIA ................................. " + mora.ToString("n2") + "<br>";
                        //  item.Descricao += " APÓS " + vencimento.ToShortDateString() + " MULTA ................................. " + multa.ToString("n2") + "<br>";
                        //item.Descricao += " DEPÓSITO BANCÁRIO NÃO QUITA O BOLETO" + "<br>";
                        // item.Descricao += " PROTESTO AUTOMÁTICO APÓS " + item.QuantidadeDias.ToString() + " DIAS" + "<br>";
                        b.Instrucoes.Add(item);
                        //b.Instrucoes.Add(item2);
                        // b.Instrucoes.Add(item3);

                        b.Cedente = c;



                        //         bb.Boleto = b;
                        //        bb.Boleto.Valida();

                        b.Valida();
                        b.NossoNumero = b.NossoNumero.Replace("-", "");
                        b.NossoNumero = b.NossoNumero.Remove(b.NossoNumero.Length - 1);
                        boletos.Add(b);

                        //  _b = b; 
                    }
                }
                // _b.Banco = new Banco(237);

                boletos.Cedente = c;

                BoletoNet.ArquivoRemessa novo = new BoletoNet.ArquivoRemessa(BoletoNet.TipoArquivo.CNAB400);
                int numero_remessa = buscar_numero_remessa();
                //IBanco _banco2 = new IBanco();
                //Banco _banco = new Banco(237);

                //StreamWriter textStream = new StreamWriter(@"c:\\evolucao\\remessas\" + numero_remessa.ToString() + ".rem");
                // Stream arquivo = new Stream();
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string vMsgRetorno = string.Empty;
                    bool vValouOK = novo.ValidarArquivoRemessa(_cod_banco, boletos[0].Banco, c, boletos, 1, out vMsgRetorno);
                    if (!vValouOK)
                    {
                        MessageBox.Show(String.Concat("Foram localizados inconsistências na validação da remessa!", Environment.NewLine, vMsgRetorno),
                                        "Teste",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    else
                    {
                        novo.GerarArquivoRemessa(_cod_banco, boletos[0].Banco, c, boletos, saveFileDialog1.OpenFile(), numero_remessa);
                        //arquivo.GerarArquivoRemessa("0", banco, cedente, boletos, saveFileDialog.OpenFile(), 1);
                        //VINCULAR CR A esta remessa
                        vincular_numero_remessa_com_cr(numero_remessa, dtItens_cr);
                        MessageBox.Show("Arquivo gerado com sucesso!", "Teste",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }


                }
            }
            catch { }
        }
        private void gerar_remessa_bradesco()
        {

            try
            {


                BoletoBancario bb;
                // IBanco _ibanco = new IBanco();
                // _ibanco.
                Boletos boletos = new Boletos();
                //  List<BoletoBancario> boletos = new List<BoletoBancario>();
                //CEDENTE
                Cedente c = new Cedente(cnpj_empresa, razao_social_empresa, _agencia, _dig_agencia, _cc, _dig_cc);
                c.Codigo = _codigo_no_banco;

                //    Boleto _b = new Boleto();

                DataTable dtItens_cr = new DataTable();
                DataColumn coluna_1 = new DataColumn();
                dtItens_cr.Columns.Add(coluna_1);
                for (int i = 0; i < dgvPlanejamento.SelectedRows.Count; i++)
                {

                    //    bb = new BoletoBancario();
                    //      bb.CodigoBanco = _codigoBanco;
                    //     bb.OcultarInstrucoes = true;
                    //      bb.MostrarComprovanteEntrega = true;
                    DateTime vencimento = Convert.ToDateTime(dgvPlanejamento.SelectedRows[i].Cells["DATA_PREVISTA_CP"].Value);

                    int dias_protesto = 0;
                    try
                    {
                        dias_protesto = Convert.ToInt32(_dias_protesto);
                    }
                    catch { }

                    Instrucao_Bradesco item = new Instrucao_Bradesco(81, dias_protesto);
                    //Instrucao_Bradesco item = new Instrucao_Bradesco(6, dias_protesto);
                    Instrucao_Bradesco item2 = new Instrucao_Bradesco(900, Convert.ToDouble(_mora));
                    Instrucao_Bradesco item3 = new Instrucao_Bradesco(901, Convert.ToDouble(_multa) * 100);

                    if (dias_protesto == 0)
                        item = new Instrucao_Bradesco(10, 0);





                    //cliente
                    string logradouro, bairro, cep, cidade, complemento, numero, uf, cnpj;
                    selecionar_dados_cliente(dgvPlanejamento.SelectedRows[i].Cells["COD_FORNECEDOR_CP"].Value.ToString(), out logradouro, out bairro, out cep, out cidade, out complemento, out numero, out uf, out cnpj);

                    Endereco end = new Endereco();
                    end.Bairro = bairro;
                    end.CEP = cep;
                    end.Cidade = cidade;
                    end.Complemento = complemento;
                    end.End = logradouro + ", " + numero + " - " + complemento;
                    //end.Logradouro = logradouro;
                    end.Numero = numero;
                    end.UF = estado_empresa;


                    string nosso_numero = "";
                    // DateTime data_nota = buscar_data_nota(dgvPlanejamento.SelectedRows[i].Cells["NF_CP"].Value.ToString());
                    // if (data_nota <= Convert.ToDateTime("23.12.2015"))
                    // {
                    //     nosso_numero = dgvPlanejamento.SelectedRows[i].Cells["NF_CP"].Value.ToString();
                    //  }
                    //  else
                    //  {//cliente + duplicata + nf(pedido)
                    int duplicata = 1;
                    try
                    {
                        duplicata = Convert.ToInt16(dgvPlanejamento.SelectedRows[i].Cells["DUPLICATA_CP"].Value.ToString());
                    }
                    catch { }
                    if (boleto_pedido_empresa == "1")
                    {
                        nosso_numero = duplicata.ToString() +
                            dgvPlanejamento.SelectedRows[i].Cells["NF_CP"].Value.ToString();
                    }
                    else
                    {
                        nosso_numero = dgvPlanejamento.SelectedRows[i].Cells["COD_FORNECEDOR_CP"].Value.ToString() + duplicata.ToString() +
                            dgvPlanejamento.SelectedRows[i].Cells["NF_CP"].Value.ToString();
                    }
                    //   }

                    dtItens_cr.Rows.Add(dgvPlanejamento.SelectedRows[i].Cells["COD_CR"].Value.ToString());

                    int digito = i + 1;
                    Boleto b = new Boleto(vencimento, Convert.ToDecimal(dgvPlanejamento.SelectedRows[i].Cells["VALOR_CP"].Value.ToString()), _carteira, nosso_numero, c);
                    b.NumeroDocumento = nosso_numero;
                    EspecieDocumento especie = new EspecieDocumento(237);
                    especie.Codigo = "01";
                    especie.Sigla = "DM";
                    b.EspecieDocumento = especie;
                    string _nome_sacado = dgvPlanejamento.SelectedRows[i].Cells["RAZAO_FORNECEDOR_CP"].Value.ToString();

                    b.Sacado = new Sacado(cnpj, _nome_sacado);
                    b.Sacado.Endereco = end;
                    b.Banco = new Banco(237);

                    item.Descricao += " *** VALORES EXPRESSOS EM REAIS *** <br>";

                    double mora = 0;
                    try
                    {
                        mora = Convert.ToDouble(dgvPlanejamento.SelectedRows[i].Cells["VALOR_CP"].Value.ToString()) * Convert.ToDouble(_mora);
                    }
                    catch { }
                    string teste = dgvPlanejamento.SelectedRows[i].Cells["VALOR_CP"].Value.ToString();
                    double multa = 0;
                    try
                    {
                        multa = Convert.ToDouble(dgvPlanejamento.SelectedRows[i].Cells["VALOR_CP"].Value.ToString()) * Convert.ToDouble(_multa);
                    }
                    catch { }
                    b.DataDocumento = DateTime.Now;
                    b.DataProcessamento = DateTime.Now;

                    b.JurosMora = Convert.ToDecimal(mora);
                    b.PercJurosMora = Convert.ToDecimal(_mora) * 100;

                    b.ValorMulta = Convert.ToDecimal(multa);
                    b.PercMulta = Convert.ToDecimal(_multa) * 100;
                    // item.Descricao += " MORA DIA/COM. PERMANÊNCIA ................................. " + mora.ToString("n2") + "<br>";
                    //  item.Descricao += " APÓS " + vencimento.ToShortDateString() + " MULTA ................................. " + multa.ToString("n2") + "<br>";
                    //item.Descricao += " DEPÓSITO BANCÁRIO NÃO QUITA O BOLETO" + "<br>";
                    // item.Descricao += " PROTESTO AUTOMÁTICO APÓS " + item.QuantidadeDias.ToString() + " DIAS" + "<br>";
                    b.Instrucoes.Add(item);
                    b.Instrucoes.Add(item2);
                    b.Instrucoes.Add(item3);

                    b.Cedente = c;
                    //         bb.Boleto = b;
                    //        bb.Boleto.Valida();

                    boletos.Add(b);
                    //  _b = b;
                }
                // _b.Banco = new Banco(237);
                boletos.Cedente = c;

                BoletoNet.ArquivoRemessa novo = new BoletoNet.ArquivoRemessa(BoletoNet.TipoArquivo.CNAB400);
                int numero_remessa = buscar_numero_remessa();
                //IBanco _banco2 = new IBanco();
                //Banco _banco = new Banco(237);

                //StreamWriter textStream = new StreamWriter(@"c:\\evolucao\\remessas\" + numero_remessa.ToString() + ".rem");
                // Stream arquivo = new Stream();
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string vMsgRetorno = string.Empty;
                    bool vValouOK = novo.ValidarArquivoRemessa("237", boletos[0].Banco, c, boletos, 1, out vMsgRetorno);
                    if (!vValouOK)
                    {
                        MessageBox.Show(String.Concat("Foram localizados inconsistências na validação da remessa!", Environment.NewLine, vMsgRetorno),
                                        "Teste",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    else
                    {
                        novo.GerarArquivoRemessa("237", boletos[0].Banco, c, boletos, saveFileDialog1.OpenFile(), numero_remessa);
                        //arquivo.GerarArquivoRemessa("0", banco, cedente, boletos, saveFileDialog.OpenFile(), 1);
                        //VINCULAR CR A esta remessa
                        vincular_numero_remessa_com_cr(numero_remessa, dtItens_cr);
                        MessageBox.Show("Arquivo gerado com sucesso!", "Teste",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);


                    }


                }
            }
            catch { }
        }

        private bool vincular_numero_remessa_com_cr(int numero_remessa, DataTable dtItens_cr)
        {
            bool retorno = true;
            foreach (DataRow dr in dtItens_cr.Rows)
            {
                try
                {
                    if (_cod_interno_banco != "")
                        _cod_interno_banco = "'" + _cod_interno_banco + "'";
                    else
                        _cod_interno_banco = "null";

                    if (_descricao_banco != "")
                        _descricao_banco = "'" + _descricao_banco + "'";
                    else
                        _descricao_banco = "null";

                    FbCommand update = new FbCommand();
                    update.CommandText = "UPDATE CONTAS_A_RECEBER SET REMESSA_CR = '" + numero_remessa.ToString() + "', CC_CR = " + _cod_interno_banco + ", " +
                        "DESCRICAO_CC_CR = " + _descricao_banco + " WHERE COD_CR = '" + dr[0].ToString() + "'";
                    update.Connection = fbConnection1;
                    fbConnection1.Open();
                    FbDataAdapter datUpdate = new FbDataAdapter();
                    datUpdate.UpdateCommand = update;
                    datUpdate.UpdateCommand.ExecuteNonQuery();
                    fbConnection1.Close();

                    _descricao_banco = _descricao_banco.Replace("'", "");
                    _cod_interno_banco = _cod_interno_banco.Replace("'", "");
                }
                catch
                {
                    fbConnection1.Close();
                    retorno = false;
                }


            }

            return retorno;

        }




        private int buscar_numero_remessa()
        {
            int retorno = 0;
            try
            {
                string codigo_banco = buscar_codigo();
                FbCommand insert = new FbCommand();
                insert.Connection = fbConnection1;
                //fbConnection1.Open();
                insert.CommandText =
                    "INSERT INTO REMESSA_CNAB400 (DATA_REMESSA, COD_BANCO_REMESSA) VALUES ('" + DateTime.Now.ToShortDateString().Replace("/", ".") + "','" + codigo_banco + "') RETURNING COD_REMESSA";
                fbConnection1.Open();
                FbDataAdapter datInsert = new FbDataAdapter();
                datInsert.InsertCommand = insert;
                object cod = datInsert.InsertCommand.ExecuteScalar();
                fbConnection1.Close();
                retorno = Convert.ToInt32(cod);

                /*
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText = "SELECT FIRST(1) COD_REMESSA FROM REMESSA_CNAB400 ORDER BY COD_REMESSA DESC";
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    return Convert.ToInt32(dr[0].ToString());
                }

                */
                return retorno;
            }
            catch (Exception a)
            {
                return retorno;
            }
        }

        private string buscar_codigo()
        {
            try
            {
                FbCommand select = new FbCommand();
                select.CommandText = "SELECT COD_CC FROM CONTAS_CORRENTES WHERE BOLETO_CC = '1'";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    return dr[0].ToString();
                }
                return "";
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                return "";
            }
        }

        private DateTime buscar_data_nota(string nf)
        {
            DateTime retorno = Convert.ToDateTime("01.01.2001");
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                select.CommandText =
                    "SELECT DATA_EMISSAO_NF FROM NOTA_FISCAL WHERE N_NF = '" + nf + "'";
                fbConnection1.Open();
                FbDataAdapter datNf = new FbDataAdapter();
                datNf.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datNf.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                    return Convert.ToDateTime(dr[0].ToString());
                return retorno;

            }
            catch (Exception a)
            {
                fbConnection1.Close();
                return retorno;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            LerRetorno(CodigoBanco);
        }

        void cnab400_LinhaDeArquivoLida(object sender, LinhaDeArquivoLidaArgs e)
        {
            // MessageBox.Show(e.Linha);
        }

        void cnab240_LinhaDeArquivoLida(object sender, LinhaDeArquivoLidaArgs e)
        {
            // MessageBox.Show(e.Linha);
        }

        // #region Retorno
        private void LerRetorno(int codigo)
        {
            try
            {
                Banco bco = new Banco(codigo);

                openFileDialog.FileName = "";
                openFileDialog.Title = "Selecione um arquivo de retorno";
                openFileDialog.Filter = "Arquivos de Retorno (*.ret;*.crt)|*.ret;*.crt|Todos Arquivos (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // for (int i = 0; i < openFileDialog.FileNames.Length; i++)
                    // {

                    ArquivoRetornoCNAB400 cnab400 = null;
                    if (openFileDialog.CheckFileExists == true)
                    {
                        cnab400 = new ArquivoRetornoCNAB400();
                        cnab400.LinhaDeArquivoLida += new EventHandler<LinhaDeArquivoLidaArgs>(cnab400_LinhaDeArquivoLida);
                        cnab400.LerArquivoRetorno(bco, openFileDialog.OpenFile());
                    }

                    if (cnab400 == null)
                    {
                        MessageBox.Show("Arquivo não processado!");
                        return;
                    }

                    ListView lstReturnFields = new ListView();


                    lstReturnFields.Items.Clear();

                    bool continuar = true;
                    // foreach (DetalheRetorno detalhe1 in cnab400.ListaDetalhe)
                    // {
                    //     if (detalhe1.CodigoBanco != CodigoBanco)
                    //     {
                    //         MessageBox.Show("O Banco Selecionado: " + CodigoBanco.ToString() + " não é o mesmo do arquivo: " + detalhe1.CodigoBanco.ToString());
                    //           continuar = false;
                    //          break;
                    //      }
                    //  }
                    if (continuar)
                    {
                        DataTable dtItens_cr = new DataTable();
                        DataColumn coluna_1 = new DataColumn();
                        dtItens_cr.Columns.Add(coluna_1);

                        foreach (DetalheRetorno detalhe in cnab400.ListaDetalhe)
                        {
                            string cod_cr = "";
                            string nosso_numero = detalhe.NossoNumero.Replace(" ", "");
                           
                            //PENDENCIA: ACERTAR OCORRENCIAS CONFORME O BANCO
                            if (nosso_numero.Replace(" ", "") == "")
                            {
                                nosso_numero = detalhe.Registro.Substring(67, 14);
                            }

                            if (detalhe.CodigoOcorrencia == 6 || detalhe.CodigoOcorrencia == 8 || detalhe.CodigoOcorrencia == 7 || detalhe.CodigoOcorrencia == 36 ||
                                detalhe.CodigoOcorrencia == 37 || detalhe.CodigoOcorrencia == 38 || detalhe.CodigoOcorrencia == 39 || detalhe.CodigoOcorrencia == 17 || 
                                detalhe.CodigoOcorrencia == 15)
                            {
                                //não esquecer de voltar o exclamação
                                if (!verificar_se_ja_foi_baixado(nosso_numero, out cod_cr))
                                {

                                    if (cod_cr != "")
                                    {
                                        /*
                                        form_operacoes_caixa caixa = new form_operacoes_caixa();
                                        try
                                        {
                                            caixa.adicionar = true;
                                            caixa.cp_cr_a_vincular[0] = cod_cr;
                                            caixa.n_baixas = 1;
                                            caixa.data_baixa = detalhe.DataCredito;
                                            caixa.valor_baixa = detalhe.ValorPago;
                                            caixa.credito = true;
                                            if (detalhe.DataCredito < Convert.ToDateTime("01/01/2010"))
                                                caixa.data_baixa = detalhe.DataOcorrencia;
                                            caixa.ShowDialog();
                                        }
                                        catch { }
                                         * */
                                        try
                                        {
                                            decimal valorPrincipal = 0;
                                            try
                                            {
                                                valorPrincipal = detalhe.ValorPrincipal;
                                            }
                                            catch
                                            { }
                                            if (detalhe.ValorPrincipal == 0)
                                            {
                                                valorPrincipal = detalhe.ValorPago;
                                            }
                                            FbCommand update = new FbCommand();
                                            update.CommandText =
                                                "UPDATE CONTAS_A_RECEBER SET RECEBIDO_CR = 1, CARTEIRA_CR = 'BOLETO', VALOR_CR = '" + 
                                                valorPrincipal.ToString().Replace(".","").Replace(",",".") + "' WHERE COD_CR = '" + cod_cr + "'";
                                            update.Connection = fbConnection1;
                                            fbConnection1.Open();
                                            FbDataAdapter datUpdate = new FbDataAdapter();
                                            datUpdate.UpdateCommand = update;
                                            datUpdate.UpdateCommand.ExecuteNonQuery();
                                            fbConnection1.Close();
                                        }
                                        catch (Exception a)
                                        {
                                            dtItens_cr.Rows.Add(nosso_numero);
                                            fbConnection1.Close();
                                            //MessageBox.Show(a.ToString());
                                        }
                                    }
                                    else
                                    {
                                        dtItens_cr.Rows.Add(nosso_numero);
                                       // MessageBox.Show("O boleto número: " + nosso_numero + " não foi baixado. Verifique.");
                                    }
                                }
                            }
                            if (detalhe.CodigoOcorrencia == 3)
                            {
                                MessageBox.Show("O boleto número: " + nosso_numero + " teve sua entrada rejeitada. Verifique.");
                            }
                            /*
                            ListViewItem li = new ListViewItem(detalhe.NomeSacado.ToString().Trim());
                            li.Tag = detalhe;

                            li.SubItems.Add(detalhe.DataVencimento.ToString("dd/MM/yy"));
                            li.SubItems.Add(detalhe.DataCredito.ToString("dd/MM/yy"));

                            li.SubItems.Add(detalhe.ValorTitulo.ToString("###,###.00"));

                            li.SubItems.Add(detalhe.ValorPago.ToString("###,###.00"));
                            li.SubItems.Add(detalhe.CodigoOcorrencia.ToString());
                            li.SubItems.Add("");
                            li.SubItems.Add(detalhe.NossoNumeroComDV); // = detalhe.NossoNumero.ToString() + "-" + detalhe.DACNossoNumero.ToString());
                            li.SubItems.Add(detalhe.NumeroDocumento);
                            lstReturnFields.Items.Add(li);*/
                        }
                        if (dtItens_cr.Rows.Count > 0)
                        {
                            string numeros = "";
                            foreach (DataRow dr in dtItens_cr.Rows)
                            {
                                numeros += dr[0].ToString() + " - ";
                            } 
                            MessageBox.Show("O(s) boleto(s) com nosso número: " + numeros + " não foram baixados. Verifique.");
                        }
                        else
                        {
                            //    int _arq = i + 1;
                            MessageBox.Show("Arquivo baixado com sucesso!");
                        }
                        // }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao abrir arquivo de retorno.");
            }
        }

        private bool verificar_se_ja_foi_baixado(string nosso_numero, out string cod_cr)
        {
            cod_cr = "";
            try
            {
                if (CodigoBanco == 104)
                    nosso_numero = nosso_numero.Substring(2, nosso_numero.Length - 2);
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                string query = "select RECEBIDO_CR, cod_cr from contas_a_receber " +
               // "where CAST(COD_CLIENTE_CR AS VARCHAR(30)) || CAST(DUPLICATA_CR AS VARCHAR(30)) || CAST(NF_CR AS VARCHAR(30)) = '" + Convert.ToInt64(nosso_numero).ToString() + "'";
                "where COD_CR = '" + Convert.ToInt64(nosso_numero).ToString() + "'";
               
                select.CommandText = query;
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    cod_cr = dr[1].ToString();
                    if (dr[0].ToString() == "1")
                    {
                        return true;
                    }
                }
               
                return false;
            }
            catch
            {
                fbConnection1.Close();
                return false;
            }
        }


        private void filtro()
        {
            _filtro = "0 = 0" + descricao + cliente + plano + observacoes + vendedor + forma_pgto + romaneio + n_titulo + nf + empresa + valor + status + grupo_plano + semana_ano;
            try
            {
                dsContas.DefaultView.RowFilter = _filtro;
            }
            catch { }
            somarTotalFiltro();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {
                    forma_pgto = " AND FORMA_PGTO LIKE '" + textBox1.Text + "*'";
                }
                else
                    forma_pgto = "";
                filtro();
            }
            catch { }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            LerRetorno_cnab240(CodigoBanco);
        }

        private void LerRetorno_cnab240(int codigo)
        {
            try
            {
                Banco bco = new Banco(codigo);

                openFileDialog.FileName = "";
                openFileDialog.Title = "Selecione um arquivo de retorno";
                openFileDialog.Filter = "Arquivos de Retorno (*.ret;*.crt)|*.ret;*.crt|Todos Arquivos (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // for (int i = 0; i < openFileDialog.FileNames.Length; i++)
                    // {

                    ArquivoRetornoCNAB240 cnab240 = null;
                    if (openFileDialog.CheckFileExists == true)
                    {
                        cnab240 = new ArquivoRetornoCNAB240();
                        cnab240.LinhaDeArquivoLida += new EventHandler<LinhaDeArquivoLidaArgs>(cnab240_LinhaDeArquivoLida);
                        cnab240.LerArquivoRetorno(bco, openFileDialog.OpenFile());
                    }

                    if (cnab240 == null)
                    {
                        MessageBox.Show("Arquivo não processado!");
                        return;
                    }

                    ListView lstReturnFields = new ListView();


                    lstReturnFields.Items.Clear();

                    foreach (DetalheRetornoCNAB240 detalhe in cnab240.ListaDetalhes)
                    {
                        /*
                         *  ListViewItem li = new ListViewItem(detalhe.SegmentoT.NomeSacado.Trim());
                            li.Tag = detalhe;

                            li.SubItems.Add(detalhe.SegmentoT.DataVencimento.ToString("dd/MM/yy"));
                            li.SubItems.Add(detalhe.SegmentoU.DataCredito.ToString("dd/MM/yy"));
                            li.SubItems.Add(detalhe.SegmentoT.ValorTitulo.ToString("###,###.00"));
                            li.SubItems.Add(detalhe.SegmentoU.ValorPagoPeloSacado.ToString("###,###.00"));
                            li.SubItems.Add(detalhe.SegmentoU.CodigoOcorrenciaSacado.ToString());.
                            li.SubItems.Add("");
                            li.SubItems.Add(detalhe.SegmentoT.NossoNumero);
                            lstReturnFields.Items.Add(li);
                         * */
                        string cod_cr = "";
                        string codigo_ocorrencia = "";

                        codigo_ocorrencia = detalhe.SegmentoT.Registro.Substring(15, 2);
                        if (codigo_ocorrencia == "06" || codigo_ocorrencia == "08" || codigo_ocorrencia == "07" ||
                            codigo_ocorrencia == "36" || codigo_ocorrencia == "37" || codigo_ocorrencia == "38" ||
                            codigo_ocorrencia == "39")
                        {
                            if (!verificar_se_ja_foi_baixado(detalhe.SegmentoT.NossoNumero.Replace(" ", ""), out cod_cr))
                            {
                                if (cod_cr != "")
                                {
                                    form_operacoes_caixa caixa = new form_operacoes_caixa();
                                    try
                                    {
                                        caixa.adicionar = true;
                                        caixa.cp_cr_a_vincular[0] = cod_cr;
                                        caixa.n_baixas = 1;
                                        caixa.data_baixa = detalhe.SegmentoU.DataCredito;
                                        caixa.valor_baixa = detalhe.SegmentoU.ValorPagoPeloSacado;
                                        caixa.credito = true;
                                        caixa.ShowDialog();
                                    }
                                    catch { }
                                }
                                else
                                    MessageBox.Show("O boleto número: " + detalhe.SegmentoT.NossoNumero.Replace(" ", "") + " não foi baixado. Verifique.");
                            }
                        }
                        if (codigo_ocorrencia == "03")
                        {
                            MessageBox.Show("O boleto número: " + detalhe.SegmentoT.NossoNumero.Replace(" ", "") + " teve sua entrada rejeitada. Verifique.");
                        }
                        /*
                        ListViewItem li = new ListViewItem(detalhe.NomeSacado.ToString().Trim());
                        li.Tag = detalhe;

                        li.SubItems.Add(detalhe.DataVencimento.ToString("dd/MM/yy"));
                        li.SubItems.Add(detalhe.DataCredito.ToString("dd/MM/yy"));

                        li.SubItems.Add(detalhe.ValorTitulo.ToString("###,###.00"));

                        li.SubItems.Add(detalhe.ValorPago.ToString("###,###.00"));
                        li.SubItems.Add(detalhe.CodigoOcorrencia.ToString());
                        li.SubItems.Add("");
                        li.SubItems.Add(detalhe.NossoNumeroComDV); // = detalhe.NossoNumero.ToString() + "-" + detalhe.DACNossoNumero.ToString());
                        li.SubItems.Add(detalhe.NumeroDocumento);
                        lstReturnFields.Items.Add(li);*/
                    }

                    MessageBox.Show("Arquivo baixado com sucesso!");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao abrir arquivo de retorno.");
            }
        }

        private void tb_romaneio_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tb_romaneio.Text != "")
                {
                    romaneio = " AND ROMANEIO = '" + tb_romaneio.Text + "'";
                }
                else
                    romaneio = "";
                filtro();
            }
            catch { }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                string data_cp = "";
                string data_cr = "";
                string data_nf = "";
                string data_pedido = "";
                string baixa_cp = "";
                string baixa_cr = "";
                //string vendedor = "";
                if (cbPor_data.Checked)
                {
                    data_cp = " AND DATA_PREVISTA_CP >= '" + Convert.ToDateTime(dtInicio.Text).ToShortDateString().Replace("/", ".") + "'" +
                        "AND DATA_PREVISTA_CP <= '" + Convert.ToDateTime(dtTermino.Text).ToShortDateString().Replace("/", ".") + "'";
                    data_cr = " AND DATA_PREVISTA_CR >= '" + Convert.ToDateTime(dtInicio.Text).ToShortDateString().Replace("/", ".") + "'" +
                        "AND DATA_PREVISTA_CR <= '" + Convert.ToDateTime(dtTermino.Text).ToShortDateString().Replace("/", ".") + "'";
                    data_nf = " AND DATA_EMISSAO_NF >= '" + Convert.ToDateTime(dtInicio.Text).ToShortDateString().Replace("/", ".") +
                        "' AND DATA_EMISSAO_NF <= '" + Convert.ToDateTime(dtTermino.Text).ToShortDateString().Replace("/", ".") + "' ";
                    data_pedido = " AND DATA_PED_VENDA >= '" + Convert.ToDateTime(dtInicio.Text).ToShortDateString().Replace("/", ".") +
                        "' AND DATA_PED_VENDA <= '" + Convert.ToDateTime(dtTermino.Text).ToShortDateString().Replace("/", ".") + "' ";

                    if (cb_buscar_saldo.Checked)
                        tb_saldo_inicial.Text = buscar_saldo_inicial();
                }
                else if (cbxMes.Checked)
                {
                    mes_atual = (comboBox1.SelectedIndex + 1);
                    ano_atual = Convert.ToInt32(nudAno.Value);
                    carregaData();
                    data_cp = " AND DATA_PREVISTA_CP >= '" + dataIniMes + "' AND DATA_PREVISTA_CP < '" + dataFimMes + "'";
                    data_cr = " AND DATA_PREVISTA_CR >= '" + dataIniMes + "' AND DATA_PREVISTA_CR < '" + dataFimMes + "'";
                    data_nf = " AND DATA_EMISSAO_NF >= '" + dataIniMes + "' AND DATA_EMISSAO_NF < '" + dataFimMes + "' ";
                    data_pedido = " AND DATA_PED_VENDA >= '" + dataIniMes +
                        "' AND DATA_PED_VENDA < '" + dataFimMes + "' ";
                    if (cb_buscar_saldo.Checked)
                        tb_saldo_inicial.Text = buscar_saldo_inicial();
                }
                if (cbData_criacao.Checked)
                {
                    if (cbPor_data.Checked)
                    {
                        data_cp = " AND DATA_CRIACAO_CP >= '" + Convert.ToDateTime(dtInicio.Text).ToShortDateString().Replace("/", ".") + "'" +
                            "AND DATA_CRIACAO_CP <= '" + Convert.ToDateTime(dtTermino.Text).ToShortDateString().Replace("/", ".") + "'";
                        data_cr = " AND DATA_CRIACAO_CR >= '" + Convert.ToDateTime(dtInicio.Text).ToShortDateString().Replace("/", ".") + "'" +
                            "AND DATA_CRIACAO_CR <= '" + Convert.ToDateTime(dtTermino.Text).ToShortDateString().Replace("/", ".") + "'";
                        data_nf = " AND DATA_EMISSAO_NF >= '" + Convert.ToDateTime(dtInicio.Text).ToShortDateString().Replace("/", ".") +
                       "' AND DATA_EMISSAO_NF <= '" + Convert.ToDateTime(dtTermino.Text).ToShortDateString().Replace("/", ".") + "' ";
                        data_pedido = " AND DATA_PED_VENDA >= '" + Convert.ToDateTime(dtInicio.Text).ToShortDateString().Replace("/", ".") +
                       "' AND DATA_PED_VENDA <= '" + Convert.ToDateTime(dtTermino.Text).ToShortDateString().Replace("/", ".") + "' ";

                        if (cb_buscar_saldo.Checked)
                            tb_saldo_inicial.Text = buscar_saldo_inicial();
                    }
                    else if (cbxMes.Checked)
                    {
                        mes_atual = (comboBox1.SelectedIndex + 1);
                        ano_atual = Convert.ToInt32(nudAno.Value);
                        carregaData();
                        data_cp = " AND DATA_CRIACAO_CP >= '" + dataIniMes + "' AND DATA_CRIACAO_CP < '" + dataFimMes + "'";
                        data_cr = " AND DATA_CRIACAO_CR >= '" + dataIniMes + "' AND DATA_CRIACAO_CR < '" + dataFimMes + "'";
                        data_nf = " AND DATA_EMISSAO_NF >= '" + dataIniMes + "' AND DATA_EMISSAO_NF < '" + dataFimMes + "' ";
                        data_pedido = " AND DATA_PED_VENDA >= '" + dataIniMes +
                       "' AND DATA_PED_VENDA < '" + dataFimMes + "' ";
                        if (cb_buscar_saldo.Checked)
                            tb_saldo_inicial.Text = buscar_saldo_inicial();
                    }
                }

                //selecionando as vendas
                /*
                FbCommand select_vendas = new FbCommand();
                select_vendas.Connection = fbConnection1;
                select_vendas.CommandText =
                    "SELECT SUM(inf.PRECO_TOTAL_ITEM), SUM(inf.CUSTO_ITEM) " +
                    " FROM ITENS_NOTA inf INNER JOIN " +
                    " NOTA_FISCAL nf on inf.NF_ITEM = nf.N_NF " +
                    " WHERE 0 = 0 " +
                   data_nf +
                    " AND (inf.CFOP_ITEM LIKE '_1__' OR inf.CFOP_ITEM LIKE '_4__') " +
                    " AND nf.STATUS_NFE LIKE '%Autorizada%' and nf.saida_nf = 1";
                fbConnection1.Open();
                FbDataAdapter datSelect_vendas = new FbDataAdapter();
                datSelect_vendas.SelectCommand = select_vendas;
                DataTable dtSelect_vendas = new DataTable();
                datSelect_vendas.Fill(dtSelect_vendas);
                fbConnection1.Close();
                */
                //selecionando as vendas pedidos
                FbCommand select_vendas_ped = new FbCommand();
                select_vendas_ped.Connection = fbConnection1;
                select_vendas_ped.CommandText =
                    "SELECT SUM(iped.VALOR_TOTAL_PROD_ITEM_VENDA), SUM(iped.CUSTO_ITEM_VENDA) " +
                    " FROM ITENS_PEDIDO_VENDA iped INNER JOIN " +
                    " PEDIDOS_VENDA ped on iped.COD_PEDIDO_ITEM_VENDA = ped.COD_PED_VENDA " +
                    " WHERE 0 = 0 " +
                   data_pedido +
                    " AND ped.BAIXADO_ESTOQUE_PED_VENDA = '1' " + 
                    " AND (ped.BONIFICACAO_PED_VENDA IS NULL or ped.BONIFICACAO_PED_VENDA = 0) " + 
                    "AND (ped.DEGUSTACAO_PED_VENDA IS NULL or ped.DEGUSTACAO_PED_VENDA = 0) " +
                    "AND (ped.TROCA_PED_VENDA IS NULL or ped.TROCA_PED_VENDA = 0) " +
                    "AND (ped.CANCELADO_PED_VENDA IS NULL or ped.CANCELADO_PED_VENDA = 0) " +
                    "AND (ped.DEVOLUCAO_PED_VENDA IS NULL or ped.DEVOLUCAO_PED_VENDA = 0) " +
                    "AND (ped.ORCAMENTO_PED_VENDA IS NULL or ped.ORCAMENTO_PED_VENDA = 0) ";
                fbConnection1.Open();
                FbDataAdapter datSelect_vendas_ped = new FbDataAdapter();
                datSelect_vendas_ped.SelectCommand = select_vendas_ped;
                DataTable dtSelect_vendas_ped = new DataTable();
                datSelect_vendas_ped.Fill(dtSelect_vendas_ped);
                fbConnection1.Close();

                //selecionando os impostos
                FbCommand select_impostos = new FbCommand();
                select_impostos.Connection = fbConnection1;
                select_impostos.CommandText =
                    "SELECT SUM(inf.VALOR_ICM_ITEM) +  SUM(inf.VALOR_PIS_ITEM)  + SUM(inf.VALOR_COFINS_ITEM) " +
                    " FROM ITENS_NOTA inf INNER JOIN " +
                    " NOTA_FISCAL nf on inf.NF_ITEM = nf.N_NF " +
                    " WHERE 0 = 0 " +
                   data_nf +
                    " AND (inf.CFOP_ITEM LIKE '_1__' OR inf.CFOP_ITEM LIKE '_4__')" +
                    " AND nf.STATUS_NFE LIKE '%Autorizada%'";
                fbConnection1.Open();
                FbDataAdapter datSelect_impostos = new FbDataAdapter();
                datSelect_impostos.SelectCommand = select_impostos;
                DataTable dtSelect_impostos = new DataTable();
                datSelect_impostos.Fill(dtSelect_impostos);
                fbConnection1.Close();

                //selecionando as perdas
                FbCommand select_perdas = new FbCommand();
                select_perdas.Connection = fbConnection1;
                select_perdas.CommandText =
                    "SELECT SUM(inf.CUSTO_ITEM) " +
                    " FROM ITENS_NOTA inf INNER JOIN " +
                    " NOTA_FISCAL nf on inf.NF_ITEM = nf.N_NF " +
                    " WHERE 0 = 0 " +
                  data_nf +
                    " AND (inf.CFOP_ITEM LIKE '_9__')" +
                    " AND nf.STATUS_NFE LIKE '%Autorizada%'";
                fbConnection1.Open();
                FbDataAdapter datSelect_perdas = new FbDataAdapter();
                datSelect_perdas.SelectCommand = select_perdas;
                DataTable dtSelect_perdas = new DataTable();
                datSelect_perdas.Fill(dtSelect_perdas);
                fbConnection1.Close();

                //selecionando as devolucoes
                FbCommand select_devolucoes = new FbCommand();
                select_devolucoes.Connection = fbConnection1;
                select_devolucoes.CommandText =
                    "SELECT SUM(inf.PRECO_TOTAL_ITEM) " +
                    " FROM ITENS_NOTA inf INNER JOIN " +
                    " NOTA_FISCAL nf on inf.NF_ITEM = nf.N_NF " +
                   " WHERE 0 = 0 " +
                   data_nf +
                    " AND (inf.CFOP_ITEM LIKE '_1__' OR inf.CFOP_ITEM LIKE '_4__') " +
                    " AND nf.STATUS_NFE LIKE '%Autorizada%' and nf.entrada_nf = 1";
                fbConnection1.Open();
                FbDataAdapter datDevolucoes = new FbDataAdapter();
                datDevolucoes.SelectCommand = select_devolucoes;
                DataTable dtDevolucoes = new DataTable();
                datDevolucoes.Fill(dtDevolucoes);
                fbConnection1.Close();

                //selecionando as perdas de pedidos
                FbCommand select_perdas_2 = new FbCommand();
                select_perdas_2.Connection = fbConnection1;
                select_perdas_2.CommandText =
                    "SELECT SUM(inf.CUSTO_ITEM_VENDA) " +
                    " FROM ITENS_PEDIDO_VENDA inf INNER JOIN " +
                    " PEDIDOS_VENDA ped on inf.COD_PEDIDO_ITEM_VENDA = ped.COD_PED_VENDA " +
                    " WHERE 0 = 0 " +
                  data_pedido +
                 " AND ped.PV_PED_VENDA = '1' " +
                    " AND (ped.BONIFICACAO_PED_VENDA = 1) " +
                    "AND (ped.DEGUSTACAO_PED_VENDA = 1) ";
                fbConnection1.Open();
                FbDataAdapter datSelect_perdas_2 = new FbDataAdapter();
                datSelect_perdas_2.SelectCommand = select_perdas_2;
                DataTable dtSelect_perdas_2 = new DataTable();
                datSelect_perdas_2.Fill(dtSelect_perdas_2);
                fbConnection1.Close();

                //selecionando os descontos 
                FbCommand select_vendas_3 = new FbCommand();
                select_vendas_3.Connection = fbConnection1;
                select_vendas_3.CommandText =
                    "SELECT SUM(inf.PRECO_TOTAL_ITEM), c.DESCONTO_PONTUALIDADE_CLIENTE, c.CNPJ" +
                    " FROM ITENS_NOTA inf INNER JOIN " +
                    " NOTA_FISCAL nf on inf.NF_ITEM = nf.N_NF " +
                    " INNER JOIN CLIENTES c on nf.CNPJ_CLIENTE_FORN = c.CNPJ " + 
                    " WHERE 0 = 0 " +
                   data_nf +
                    " AND (inf.CFOP_ITEM LIKE '_1__' OR inf.CFOP_ITEM LIKE '_4__') " +
                    " AND nf.STATUS_NFE LIKE '%Autorizada%' AND c.DESCONTO_PONTUALIDADE_CLIENTE > 0 GROUP BY c.DESCONTO_PONTUALIDADE_CLIENTE, c.CNPJ";
                fbConnection1.Open();
                FbDataAdapter datSelect_vendas_3 = new FbDataAdapter();
                datSelect_vendas_3.SelectCommand = select_vendas_3;
                DataTable dtSelect_vendas_3 = new DataTable();
                datSelect_vendas_3.Fill(dtSelect_vendas_3);
                fbConnection1.Close();

                //selecionando as contas a pagar
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                select.CommandText =
                    "SELECT pl.GRUPO_PLANO, cp.PLANO_CP, pl.COD_PLANO, SUM(cp.VALOR_CP) " +
                    " FROM CONTAS_A_PAGAR cp INNER JOIN " +
                    " PLANOS pl on cp.PLANO_CP = pl.NOME_PLANO " +
                    " WHERE pl.TIPO_PLANO = 'DESPESAS OPERACIONAIS' " +
                    data_cp +
                    " GROUP BY pl.GRUPO_PLANO , cp.PLANO_CP, pl.COD_PLANO " +
                    " order by pl.GRUPO_PLANO";
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();

                dsDre dre = new dsDre();
                double vendas = 0, custos = 0;
                /*
                foreach (DataRow dr_vendas in dtSelect_vendas.Rows)
                {
                    try
                    {
                        vendas += Convert.ToDouble(dr_vendas[0].ToString());
                        
                    }
                    catch { }
                    try
                    {
                        //não somo os custos pois já sai nas despesas
                       // custos += Convert.ToDouble(dr_vendas[1].ToString());
                    }
                    catch { }
                }
                */
                foreach (DataRow dr_vendas_ped in dtSelect_vendas_ped.Rows)
                {
                    try
                    {
                        vendas += Convert.ToDouble(dr_vendas_ped[0].ToString());

                    }
                    catch { }
                    try
                    {
                        //não somo os custos pois já sai nas despesas
                       // custos += Convert.ToDouble(dr_vendas_ped[1].ToString());
                    }
                    catch { }
                }


                dre.ITENS_DRE.AddITENS_DRERow("RECEITAS", "RECEITA BRUTA DE VENDAS", vendas);
                dre.ITENS_DRE.AddITENS_DRERow("RECEITAS", "CUSTO DAS MERCADORIAS VENDIDAS", custos * -1);
                foreach (DataRow dr_impostos in dtSelect_impostos.Rows)
                {
                    try
                    {
                        dre.ITENS_DRE.AddITENS_DRERow("RECEITAS", "IMPOSTOS (ICMS + PIS + COFINS)", Convert.ToDouble(dr_impostos[0].ToString()) * -1);
                    }
                    catch { }
                }
                double perdas = 0;

                foreach (DataRow dr_perdas in dtDevolucoes.Rows)
                {
                    try
                    {
                        double dev = Convert.ToDouble(dr_perdas[0].ToString());
                        dre.ITENS_DRE.AddITENS_DRERow("RECEITAS", "DEVOLUCOES", dev * -1);
                    }
                    catch { }
                }

                foreach (DataRow dr_perdas in dtSelect_perdas.Rows)
                {
                    try
                    {
                        double trocas  = Convert.ToDouble(dr_perdas[0].ToString());
                        dre.ITENS_DRE.AddITENS_DRERow("RECEITAS", "TROCAS (VALOR DE CUSTO)", trocas * -1);
                    }
                    catch { }
                }

                foreach (DataRow dr_perdas in dtSelect_perdas_2.Rows)
                {
                    try
                    {
                        double boni = Convert.ToDouble(dr_perdas[0].ToString());
                        dre.ITENS_DRE.AddITENS_DRERow("RECEITAS", "BONIFICACAO/DEGUSTACAO (VALOR DE CUSTO)", boni * -1);
                        //perdas += Convert.ToDouble(dr_perdas[0].ToString());
                    }
                    catch { }
                }
                double descontos = 0;
                foreach (DataRow dr_perdas in dtSelect_vendas_3.Rows)
                {
                    try
                    {
                        
                        descontos += Convert.ToDouble(dr_perdas[0].ToString()) * Convert.ToDouble(dr_perdas[1].ToString()) / 100;
                    }
                    catch { }
                }
                dre.ITENS_DRE.AddITENS_DRERow("RECEITAS", "DESCONTOS", descontos * -1);
                
                //dre.ITENS_DRE.AddITENS_DRERow("RECEITAS", "PERDAS / TROCAS / ABATIMENTOS / BONIFICACOES / DEGUSTACOES", perdas * -1);
                foreach (DataRow dr_despesas in dtSelect.Rows)
                {
                    try
                    {
                        dre.ITENS_DRE.AddITENS_DRERow(dr_despesas[0].ToString(), dr_despesas[1].ToString(), Convert.ToDouble(dr_despesas[3].ToString()));
                    }
                    catch { }
                }


                if (cbPor_data.Checked)
                {
                    dre.INFORMACOES.AddINFORMACOESRow(Convert.ToDateTime(dtInicio.Text), Convert.ToDateTime(dtTermino.Text));

                }
                else if (cbxMes.Checked)
                {
                    dre.INFORMACOES.AddINFORMACOESRow(Convert.ToDateTime(dataIniMes), Convert.ToDateTime(dataFimMes).AddDays(-1));
                }

                crDre cr = new crDre();
                cr.SetDataSource(dre);

                form_imprimir imprimir = new form_imprimir(cr);
                imprimir.Show();




            }
            catch (Exception a)
            {
                fbConnection1.Close();
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            
        }

        private void tb_nf_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tb_nf.Text != "")
                {
                    nf = " and NF_CP = '" + tb_nf.Text + "'";
                }
                else
                    nf = "";
                filtro();
            }
            catch { };

        }

        private void tb_n_titulo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tb_n_titulo.Text != "")
                {
                    n_titulo = " and DUPLICATA_CP = '" + tb_n_titulo.Text + "'";
                }
                else
                     n_titulo = "";
                filtro();
            }
            catch { };
        }

        private void tb_empresa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tb_empresa.Text != "")
                {
                    empresa = " and EMPRESA = '" + tb_empresa.Text + "'";
                }
                else
                    empresa = "";
                filtro();
            }
            catch { };
        }

        private void cbData_criacao_CheckStateChanged(object sender, EventArgs e)
        {
            if (cbData_criacao.Checked)
                cbData_credito.Checked = false;
        }

        private void cbData_credito_CheckStateChanged(object sender, EventArgs e)
        {
            if (cbData_credito.Checked)
                cbData_criacao.Checked = false;
        }

        private void tb_valor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tb_valor.Text != "")
                {
                    valor = " AND VALOR_CP = '" +   tb_valor.Text + "'";
                }
                else
                    valor = "";
                filtro();
            }
            catch { }
        }

        private void tb_cod_plano_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tb_cod_plano.Text != "")
                {
                    plano = " AND COD_PLANO_CP = '" + tb_cod_plano.Text + "'";
                }
                else
                    plano = "";
                filtro();
            }
            catch { }
        }

        private void tb_status_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tb_status.Text != "")
                {
                    status = " and STATUS LIKE '*" + tb_status.Text + "*'";
                }
                else
                    status = "";
                filtro();
            }
            catch { };

        }

        private void tb_grupo_plano_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tb_grupo_plano.Text != "")
                {
                    grupo_plano = " AND GRUPO_PLANO LIKE '*" + tb_grupo_plano.Text + "*'";
                }
                else
                    grupo_plano = "";
                filtro();
            }
            catch { }
        }

        private void tb_semana_ano_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tb_semana_ano.Text != "")
                {
                    semana_ano = " AND semana_ano LIKE '" + tb_semana_ano.Text + "'";
                }
                else
                    semana_ano = "";
                filtro();
            }
            catch { }
        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            form_planos planos = new form_planos();
            try
            {
                planos.ShowDialog();

            }
            finally
            {
                tb_plano.Text = planos.nome_escolhido;
                tb_cod_plano.Text = planos.cod_escolhido;
            }
        }

        private void dgvPlanejamento_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (dgvPlanejamento.Rows[e.RowIndex].Cells["STATUS"].Value.ToString() == "PAGO") // Verifica se a célula pertence a uma linha de dados (e não ao cabeçalho)
                {

                    e.CellStyle.BackColor = Color.LightGreen;
                }
                else
                {
                    if (Convert.ToDateTime(Convert.ToDateTime(dgvPlanejamento.Rows[e.RowIndex].Cells["DATA_PREVISTA_CP"].Value.ToString()).ToShortDateString()) 
                        == Convert.ToDateTime(DateTime.Now.ToShortDateString())) // Verifica se a célula pertence a uma linha de dados (e não ao cabeçalho)
                    {
                        e.CellStyle.BackColor = Color.Yellow;
                    }
                    else
                    {
                        if (Convert.ToDateTime(Convert.ToDateTime(dgvPlanejamento.Rows[e.RowIndex].Cells["DATA_PREVISTA_CP"].Value.ToString()).ToShortDateString()) 
                            < Convert.ToDateTime(DateTime.Now.ToShortDateString())) // Verifica se a célula pertence a uma linha de dados (e não ao cabeçalho)
                        {
                            e.CellStyle.BackColor = Color.MistyRose;
                        }
                        //e.CellStyle.BackColor = Color.OrangeRed;
                    }

                }

            }
            catch { }

            try
            {
                if (Convert.ToDouble(dgvPlanejamento.Rows[e.RowIndex].Cells["VALOR_CP"].Value.ToString()) > 0) // Verifica se a célula pertence a uma linha de dados (e não ao cabeçalho)
                {
                    dgvPlanejamento.Rows[e.RowIndex].Cells["VALOR_CP"].Style.BackColor = Color.SkyBlue;
                    
                }
                else
                {
                    dgvPlanejamento.Rows[e.RowIndex].Cells["VALOR_CP"].Style.BackColor = Color.MistyRose;
                }
            }
            catch { }
        }
    }


}