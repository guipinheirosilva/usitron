using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Runtime.InteropServices;

/*using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.IO;
using System.Xml;
using System.Data.OleDb;
using System.Collections;
using System.Runtime.InteropServices;
using System.Diagnostics;*/

namespace Evolucao
{
    public partial class form_pesquisa_nf : Form
    {
        [DllImport("kernel32.dll")]
        private static extern int SetProcessWorkingSetSize(IntPtr process, int minimumWorkingSetSize, int maximumWorkingSetSize);

        public string _cod_banco, _agencia, _dig_agencia, _cc, _dig_cc, _carteira, _multa, _mora, _dias_protesto, _codigo_no_banco, _descricao_banco, _cod_interno_banco;
        public string nf_escolhida;
        public string cod_nf_escolhida;
        public bool pesquisa;
        NFe_Util_2G.Util util2 = new NFe_Util_2G.Util();
        //empresa
        string razao_social_empresa = "", nome_fantasia_empresa = "", cnpj_empresa, ie_empresa = "", im_empresa = "", cnae_empresa = "", endereco_empresa = "", n_endereco_empresa = "",
           complemento_empresa = "", bairro_empresa = "", cidade_empresa = "", estado_empresa = "", cep_empresa = "", telefone_empresa = "", cod_cidade_empresa = "", pais_empresa = "",
           cod_pais_empresa = "", licenca_dll_nfe_empresa = "", nome_certificado_nfe_empresa = "", assunto_nfe_email_empresa = "", smtp_nfe_empresa = "", email_nfe_empresa = "",
           senha_email_nfe_empresa = "", logotipo_empresa = "", proxy_empresa = "", usuario_proxy_empresa = "", senha_proxy_empresa = "", crt_empresa = "", portaEmailEmpresa = "",
           sslEmpresa = "", serie_empresa = "", boleto_pedido_empresa = "";


        public form_pesquisa_nf(string cnpj_empresa)
        {
            this.cnpj_empresa = cnpj_empresa;
            InitializeComponent();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            selecionar();

        }

        private void selecionar()
        { 
            DateTime inicio = DateTime.Now;
            try
            {
                string _where = "";
                if (rbXml.Checked)
                    _where = " AND UPPER(STATUS_NFE) LIKE UPPER('%XML%') ";
                if (rbEnviadas.Checked)
                    _where = " AND UPPER(STATUS_NFE) LIKE UPPER('%ENVIADA%') ";
                if (rbAutorizadas.Checked)
                    _where = " AND UPPER(STATUS_NFE) LIKE UPPER('%AUTORIZADA%') ";
                if (rbCanceladas.Checked)
                    _where = " AND UPPER(STATUS_NFE) LIKE UPPER('%CANCELADA%') ";
                dsNota_fiscal.Clear();
                this.datNota_fiscal.SelectCommand.CommandText =
                        //"SELECT n.*, pv.vendedor_ped_venda, c.NOME_FANTASIA, pv.COD_PED_VENDA, c.cod_roteiro_cliente " +
                        //"FROM NOTA_FISCAL n " +
                        //"inner join clientes c on n.CNPJ_CLIENTE_FORN = c.CNPJ " + 
                        //"INNER JOIN pedidos_nf pnf " +
                        //"ON pnf.COD_SISTEMA_PEDIDO_NF = n.COD_SISTEMA_NF " +
                        //"INNER JOIN pedidos_venda pv " +
                        //"ON pv.cod_ped_venda = pnf.n_pedido_nf " +
                        //"WHERE cnpj_emissor_nf = '" + cnpj_empresa + "' AND n.DATA_EMISSAO_NF >= '" + Convert.ToDateTime(dtInicio.Text).ToShortDateString().Replace("/", ".") +
                        //"' AND n.DATA_EMISSAO_NF <= '" + Convert.ToDateTime(dtTermino.Text).ToShortDateString().Replace("/", ".") + "' " +
                        //_where +
                        //"ORDER BY n.DATA_EMISSAO_NF DESC";
                        "SELECT n.* " +
                        "FROM NOTA_FISCAL n " +
                        "inner join clientes c on n.CNPJ_CLIENTE_FORN = c.CNPJ " +
                        "WHERE cnpj_emissor_nf = '" + cnpj_empresa + "' AND n.DATA_EMISSAO_NF >= '" + Convert.ToDateTime(dtInicio.Text).ToShortDateString().Replace("/", ".") +
                        "' AND n.DATA_EMISSAO_NF <= '" + Convert.ToDateTime(dtTermino.Text).ToShortDateString().Replace("/", ".") + "' " +
                        _where +
                        "ORDER BY n.DATA_EMISSAO_NF DESC";
                this.fbConnection1.Open();
                this.datNota_fiscal.SelectCommand.Connection = fbConnection1;
                this.datNota_fiscal.SelectCommand.ExecuteNonQuery();
                datNota_fiscal.Fill(NOTA_FISCAL);
                this.fbConnection1.Close();
            }
            catch
            {
                fbConnection1.Close();
            }
                cores();
                somar_valores();
              // DateTime fim = DateTime.Now;
              //  TimeSpan tempo = fim - inicio;
               // MessageBox.Show(tempo.ToString());
        }

        private void cores()
        {
            for (int i = 0; i < dgvNota_fiscal.RowCount; i++)
            {
                if (dgvNota_fiscal.Rows[i].Cells["col_status"].Value.ToString().Contains("Autorizada"))
                {
                    dgvNota_fiscal.Rows[i].DefaultCellStyle.BackColor = Color.GreenYellow;
                }
                if (dgvNota_fiscal.Rows[i].Cells["col_status"].Value.ToString().Contains("Cancelada"))
                {
                    dgvNota_fiscal.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
            }

        }

        private void somar_valores()
        {
            double total = 0;
            double ipi = 0;
            for (int i = 0; i < dgvNota_fiscal.RowCount; i++)
            {
                try
                {
                    total = total + Convert.ToDouble(dgvNota_fiscal.Rows[i].Cells["col_valor_total"].Value.ToString());
                    ipi = ipi + Convert.ToDouble(dgvNota_fiscal.Rows[i].Cells["col_ipi"].Value.ToString());
                }
                catch{}
            }
            tb_soma.Text = total.ToString("n2");
            double resultado = total - ipi;
            tb_soma_sem_ipi.Text = resultado.ToString("n2");


            
        }

        private void detectar_dados_empresa(out string razao_social_empresa, out string nome_fantasia_empresa, out string cnpj_empresa, out string ie_empresa, out string im_empresa, out string cnae_empresa, out string endereco_empresa, out string n_endereco_empresa,
                  out string complemento_empresa, out string bairro_empresa, out string cidade_empresa, out string estado_empresa, out string cep_empresa, out string telefone_empresa, out string cod_cidade_empresa, out string pais_empresa,
                  out string cod_pais_empresa, out string licenca_dll_nfe_empresa, out string nome_certificado_nfe_empresa, out string assunto_nfe_email_empresa, out string smtp_nfe_empresa, out string email_nfe_empresa,
                  out string senha_email_nfe_empresa, out string logotipo_empresa, out string proxy_empresa, out string usuario_proxy_empresa, out string senha_proxy_empresa,
          out string crt_empresa, out string portaEmailEmpresa, out string sslEmpresa, out string serie_empresa, out string boleto_pedido_empresa)
        {
            razao_social_empresa = ""; nome_fantasia_empresa = ""; cnpj_empresa = this.cnpj_empresa; ie_empresa = ""; im_empresa = ""; cnae_empresa = ""; endereco_empresa = ""; n_endereco_empresa = "";
            complemento_empresa = ""; bairro_empresa = ""; cidade_empresa = ""; estado_empresa = ""; cep_empresa = ""; telefone_empresa = ""; cod_cidade_empresa = ""; pais_empresa = "";
            cod_pais_empresa = ""; licenca_dll_nfe_empresa = ""; nome_certificado_nfe_empresa = ""; assunto_nfe_email_empresa = ""; smtp_nfe_empresa = ""; email_nfe_empresa = "";
            senha_email_nfe_empresa = ""; logotipo_empresa = ""; proxy_empresa = ""; usuario_proxy_empresa = ""; senha_proxy_empresa = ""; crt_empresa = ""; portaEmailEmpresa = "";
            sslEmpresa = ""; serie_empresa = ""; boleto_pedido_empresa = "";
            try
            {
                FbCommand comando = new FbCommand();
                comando.Connection = fbConnection1;
                comando.CommandText = "SELECT * FROM EMPRESA where LICENCA_DLL_NFE_EMPRESA is not null and CNPJ_EMPRESA = '" + cnpj_empresa + "'";
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
                    //cnpj_empresa = dr["CNPJ_EMPRESA"].ToString().Replace(".", "").Replace("/", "").Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
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
            _codigo_no_banco = ""; _descricao_banco = ""; _cod_interno_banco = "";
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
                }

            }
            catch { fbConnection1.Close(); }
        }

        private void form_pesquisa_nf_Load(object sender, EventArgs e)
        {
            detectar_dados_empresa(out razao_social_empresa, out nome_fantasia_empresa, out cnpj_empresa, out ie_empresa, out im_empresa, out cnae_empresa, out endereco_empresa, out n_endereco_empresa,
out complemento_empresa, out bairro_empresa, out cidade_empresa, out estado_empresa, out cep_empresa, out telefone_empresa, out cod_cidade_empresa, out pais_empresa,
out cod_pais_empresa, out licenca_dll_nfe_empresa, out nome_certificado_nfe_empresa, out assunto_nfe_email_empresa, out smtp_nfe_empresa, out email_nfe_empresa,
out senha_email_nfe_empresa, out logotipo_empresa, out proxy_empresa, out usuario_proxy_empresa, out senha_proxy_empresa, out crt_empresa, out portaEmailEmpresa, out sslEmpresa,
out serie_empresa, out boleto_pedido_empresa);


            dgvNota_fiscal.AutoGenerateColumns = false;
            dgvNota_fiscal.DataSource = dsNota_fiscal.Tables["NOTA_FISCAL"];
           // datNota_fiscal.Fill(NOTA_FISCAL);
            dtInicio.Text = DateTime.Now.AddDays(-7).ToShortDateString();
            selecionar();
            buscar_dados_bancarios();
            try
            {
                /*dsNota_fiscal.Clear();
                this.datNota_fiscal.SelectCommand.CommandText =
                    /*"SELECT * FROM NOTA_FISCAL ORDER BY DATA_EMISSAO_NF DESC";
                        "SELECT n.*, '' vendedor_ped_venda " +
                        "FROM NOTA_FISCAL n " +
                        //"LEFT JOIN pedidos_nf pnf " +
                        //"ON pnf.nf_pedido_nf = n.n_nf " +
                        //"LEFT JOIN pedidos_venda pv " +
                        //"ON pv.cod_ped_venda = pnf.n_pedido_nf " +
                        "WHERE n.data_emissao_nf >= '01.11.2013' " +
                        "ORDER BY n.DATA_EMISSAO_NF DESC";
                this.fbConnection1.Open();
                this.datNota_fiscal.SelectCommand.Connection = fbConnection1;
                this.datNota_fiscal.SelectCommand.ExecuteNonQuery();
                datNota_fiscal.Fill(NOTA_FISCAL);
                this.fbConnection1.Close(); */
            }
            catch
            {
                fbConnection1.Close(); 
            }
        }

        private void dgvNota_fiscal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (pesquisa)
            {
                
                    form_faturamento fat = new form_faturamento(cnpj_empresa);
                    fat.nota_a_abrir = dgvNota_fiscal.Rows[e.RowIndex].Cells["col_n_nf"].Value.ToString();
                    //fat.imprimir_nota_e_boleto = true;
                    fat.Show();
               
            }
            else
            {
                try
                {
                    nf_escolhida = dgvNota_fiscal.Rows[e.RowIndex].Cells["col_n_nf"].Value.ToString();
                    cod_nf_escolhida = dgvNota_fiscal.Rows[e.RowIndex].Cells["col_cod_nf"].Value.ToString();
                }
                catch { }
                this.Close();
            }
        }

        private void tb_n_nf_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsNota_fiscal.Tables["NOTA_FISCAL"].DefaultView.RowFilter = "N_NF = '" + tb_n_nf.Text + "'";
            }
            catch { }
        }

        private void tb_cliente_2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsNota_fiscal.Tables["NOTA_FISCAL"].DefaultView.RowFilter = " NOME_FANTASIA Like '*" + tb_cliente_2.Text + "*' or  CLIENTE_FORN_NF Like '*" + tb_cliente_2.Text + "*'";
                somar_valores();
            }
            catch
            {
                dsNota_fiscal.Tables["NOTA_FISCAL"].DefaultView.RowFilter = " 0 = 0 ";
                somar_valores();
            }
        }

        private void tb_obs_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsNota_fiscal.Tables["NOTA_FISCAL"].DefaultView.RowFilter = "NATUREZA_OPERACAO_NF Like '*" + textBox1.Text + "*'";
                somar_valores();
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvNota_fiscal.RowCount; i++)
            {
                if (dgvNota_fiscal.Rows[i].Cells["col_status"].Value.ToString() == "NFe Autorizada.")
                {
                    classe_particularidades part = new classe_particularidades();
                    part.executar_particularidades(dgvNota_fiscal.Rows[i].Cells["col_n_nf"].Value.ToString());
                }
            }
        }

        private void tb_cnpj_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsNota_fiscal.Tables["NOTA_FISCAL"].DefaultView.RowFilter = "CNPJ_FORN_NF Like '*" + tb_cnpj.Text + "*'";
                somar_valores();
            }
            catch { }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsNota_fiscal.Tables["NOTA_FISCAL"].DefaultView.RowFilter = "VENDEDOR_PED_VENDA Like '*" + txtVendedor.Text + "*'";
                somar_valores();
            }
            catch 
            {
                dsNota_fiscal.Tables["NOTA_FISCAL"].DefaultView.RowFilter = "VENDEDOR_PED_VENDA is not null";
                somar_valores();
            }
        }

        private void dgvNota_fiscal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                dsNota_fiscal.Clear();
                this.datNota_fiscal.SelectCommand.CommandText =
                    /*"SELECT * FROM NOTA_FISCAL WHERE DATA_EMISSAO_NF >= '" + Convert.ToDateTime(dtInicio.Text).ToShortDateString().Replace("/", ".") +
                    "' AND DATA_EMISSAO_NF <= '" + Convert.ToDateTime(dtTermino.Text).ToShortDateString().Replace("/", ".") + "' ORDER BY DATA_EMISSAO_NF DESC";*/
                        "SELECT n.* " +
                        "FROM NOTA_FISCAL n " +
                        "WHERE n.cnpj_emissor_nf = '" + cnpj_empresa + "' and n.DATA_EMISSAO_NF >= '" + 
                        Convert.ToDateTime(dtInicio.Text).ToShortDateString().Replace("/", ".") + 
                        "' AND n.DATA_EMISSAO_NF <= '" + Convert.ToDateTime(dtTermino.Text).ToShortDateString().Replace("/", ".") + "' " +
                        "ORDER BY n.DATA_EMISSAO_NF DESC;";
                this.fbConnection1.Open();
                this.datNota_fiscal.SelectCommand.Connection = fbConnection1;
                this.datNota_fiscal.SelectCommand.ExecuteNonQuery();
                datNota_fiscal.Fill(NOTA_FISCAL);
                this.fbConnection1.Close();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
            }
        }

        private bool verificar_se_existe_alguma_linha_com_lote_enviado(out string erro)
        {
            erro = "";
            for (int i = 0; i < dgvNota_fiscal.SelectedRows.Count; i++)
            {
                if (dgvNota_fiscal.SelectedRows[i].Cells["col_lote"].Value.ToString() != "")
                {
                    erro = "LOTE";
                    return false;
                }
                if(dgvNota_fiscal.SelectedRows[i].Cells["col_protocolo"].Value.ToString() != "")
                {
                    erro = "PROTOCOLO";
                    return false;
                }
                if (!dgvNota_fiscal.SelectedRows[i].Cells["col_status"].Value.ToString().Contains("XML"))
                {
                    erro = "XML";
                    return false;
                }
            }
            return true;
        }

        private string buscar_xml_gerado(string cod)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT XML_GERADO_NF FROM NOTA_FISCAL WHERE N_NF = '" + cod + "'";
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
                MessageBox.Show(a.ToString());
                fbConnection1.Close();
                return "";
            }


        }

        private string gerar_numero_de_lote()
        {
            string retorno = "0";
            try
            {
                FbCommand insert = new FbCommand();
                insert.CommandText =
                    "INSERT INTO LOTE_ENVIO_NFE (MSG_DADOS_LEN) VALUES ('NOVO')";
                insert.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datInsert = new FbDataAdapter();
                datInsert.InsertCommand = insert;
                datInsert.InsertCommand.ExecuteNonQuery();
                fbConnection1.Close();

                //buscando ultimo lote inserido;
                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT FIRST(1) COD_LOTE_ENVIO_NFE FROM LOTE_ENVIO_NFE ORDER BY COD_LOTE_ENVIO_NFE DESC";
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
                return retorno;

            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
                fbConnection1.Close();
                return "0";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //cbTeste.Checked = true;

            if (dgvNota_fiscal.SelectedRows.Count > 50)
                MessageBox.Show("Só é possível enviar 50 NFes por vez");
            else
            {
                string erro = "";
                if (verificar_se_existe_alguma_linha_com_lote_enviado(out erro))
                {
             
                    string proxy = proxy_empresa;
                    string usuario = usuario_proxy_empresa;
                    string senha = senha_proxy_empresa;
                    string licenca = licenca_dll_nfe_empresa;
                    string nomeCertificado = nome_certificado_nfe_empresa;
                    string _nroRecibo, _msgCabec, _msgDados, _msgRetWS, _msgResultado, _NFeAssinada;
                    string _dhRecibo, _tMed;
                    int tipo_ambiente = 1; //1 - PRODUÇÃO 2- HOMOLOGACAO
                    if (cbTeste.Checked)
                        tipo_ambiente = 2;
                    string arquivo = "";
                    for (int i = 0; i < dgvNota_fiscal.SelectedRows.Count; i++)
                    { //GERANDO CONJUNTO DE CTEs
                        arquivo = arquivo + buscar_xml_gerado(dgvNota_fiscal.SelectedRows[i].Cells["col_n_nf"].Value.ToString()) + "\n";
                    }
                    string numero_lote = gerar_numero_de_lote();

                    int quantidadeCTe; int cResultado; string MsgResultado;
                   // string montar_lote = util2.MontaLoteNFe("3.10", numero_lote, arquivo, out quantidadeCTe, out cResultado, out MsgResultado);
                    string montar_lote = util2.MontaLoteNFe("4.00", numero_lote, arquivo, out quantidadeCTe, out cResultado, out MsgResultado);
                    salvar_na_pasta(montar_lote, @"c:\\evolucao\\NFE\LOTE_ENVIADO\LOTE" + numero_lote + ".xml");
                    string wsuf = "SP";
                    if (estado_empresa != "SP")
                        wsuf = "SVRS";

                    int envia = util2.EnviaLoteV3(wsuf, tipo_ambiente, nomeCertificado, "4.00", montar_lote, 0,
                        out _msgRetWS, out _msgResultado, out _nroRecibo, out _dhRecibo, out _tMed, proxy, usuario, senha, licenca);

                    if (envia == 103)
                    {
                        string recibo = "";
                        salvar_na_pasta(_msgRetWS, @"c:\\evolucao\\NFE\LOTE_RECEBIDO\LOTE" + numero_lote + ".xml");

                        StringReader theReader = new StringReader(_msgRetWS);
                        DataSet ds = new DataSet();
                        ds.ReadXml(theReader);
                        foreach (DataRow dr in ds.Tables["infRec"].Rows)
                            recibo = dr["nRec"].ToString();

                        try
                        {
                            //gravar xml assinada e lote de envio no cte
                            //update_coluna_xml_assin(CTeAssinada, tb_cod.Text);
                            for (int i = 0; i < dgvNota_fiscal.SelectedRows.Count; i++)
                            { //update cte
                                update_nfe(dgvNota_fiscal.SelectedRows[i].Cells["col_n_nf"].Value.ToString(), numero_lote, recibo);
                            }

                            update_lote(numero_lote, montar_lote, _msgRetWS, _msgResultado, recibo);
                            MessageBox.Show("Lote Recebido");
                            selecionar();
                        }
                        catch
                        { }

                    }
                    else
                    {
                        MessageBox.Show(envia.ToString() + " " + _msgResultado + " " + _msgRetWS);
                    }
                }
                else
                {
                    if(erro == "XML")
                        MessageBox.Show("Não é possível enviar o lote pois foram selecionados NFes que não tem o XML gerado.");
                    if(erro == "PROTOCOLO")
                        MessageBox.Show("Não é possível enviar o lote pois foram selecionados NFes já autorizadas.");
                    if(erro == "LOTE")
                        MessageBox.Show("Não é possível enviar o lote pois foram selecionados NFes já enviadas.");

                    
                }
            }
        }

        void update_lote(string numero_lote, string montar_lote, string _msgRetWS, string _msgResultado, object recibo)
        {
            try
            {
                fbConnection1.Open();
                FbTransaction trans = fbConnection1.BeginTransaction();
                fbConnection1.Close();
                FbCommand update = new FbCommand(
                    "UPDATE LOTE_ENVIO_NFE SET MSG_RET_WS_LEN = ?, " +
                    "MSG_RESULTADO_LEN = ?, " +
                    "RECIBO_LEN = ?, " +
                    "XML_ENVIO_LEN = ?,  " +
                    "DATA_ENVIO_LEN = ?," +
                    "HORA_ENVIO_LEN = ?" +
                    " WHERE COD_LOTE_ENVIO_NFE = ?", fbConnection1, trans);
                update.Parameters.AddWithValue("MSG_RET_WS_LEN", _msgRetWS);
                update.Parameters.AddWithValue("MSG_RESULTADO_LEN", _msgResultado);
                update.Parameters.AddWithValue("RECIBO_LEN", recibo);
                update.Parameters.AddWithValue("XML_ENVIO_LEN", montar_lote);
                update.Parameters.AddWithValue("DATA_ENVIO_LEN", DateTime.Now.ToShortDateString());
                update.Parameters.AddWithValue("HORA_ENVIO_LEN", DateTime.Now.ToShortTimeString());
                update.Parameters.AddWithValue("COD_LOTE_ENVIO_NFE", numero_lote);
                fbConnection1.Open();
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.UpdateCommand = update;
                datTabela.UpdateCommand.ExecuteNonQuery();
                fbConnection1.Close();

            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void update_nfe(string cod_cte, string numero_lote, string recibo)
        {
            try
            {
                FbCommand update = new FbCommand();
                update.CommandText =
                    "UPDATE NOTA_FISCAL SET LOTE_ENVIO_NF = '" + numero_lote +
                    "', RECIBO_NFE = '" + recibo + "', STATUS_NFE = 'NFe Enviada no lote " +
                    numero_lote + "' WHERE N_NF = '" + cod_cte + "'";
                update.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datUpdate = new FbDataAdapter();
                datUpdate.UpdateCommand = update;
                datUpdate.UpdateCommand.ExecuteNonQuery();
                fbConnection1.Close();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void salvar_na_pasta(string cte, string caminho)
        {
            try
            {
                FileInfo t = new FileInfo(caminho);
                using (StreamWriter texto = t.CreateText())
                {
                    texto.WriteLine(cte);
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
            }
        }

        private string buscar_recibo()
        {
            string retorno = "";
            form_lote_envio_nfe lote = new form_lote_envio_nfe();
            try
            {
                lote.ShowDialog();
            }
            finally
            {
                retorno = lote.numero_recibo;
            }
            return retorno;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                string proxy = proxy_empresa;
                string usuario = usuario_proxy_empresa;
                string senha = senha_proxy_empresa;
                string licenca = licenca_dll_nfe_empresa;
                string nomeCertificado = nome_certificado_nfe_empresa;
                string _msgDados, _msgRetWS, _msgResultado, _cMsg, _xMsg;
                int cStat;
                int tipo_ambiente = 1; //1 - PRODUÇÃO 2- HOMOLOGACAO
                if (cbTeste.Checked)
                    tipo_ambiente = 2;
                string nroRecibo = buscar_recibo();
                //nroRecibo = "351000003575510";
              //  string consulta = util2.BuscaLoteV3("SP3", tipo_ambiente, nomeCertificado, "3.10", out _msgDados, out cStat,
              //      out _msgResultado, nroRecibo, out _cMsg, out _xMsg, proxy, usuario, senha);
                string wsuf = "SP";
                if (estado_empresa != "SP")
                    wsuf = "SVRS";

                string consulta = util2.BuscaLoteV3(wsuf, tipo_ambiente, nomeCertificado, "4.00", out _msgDados, out cStat,
                    out _msgResultado, nroRecibo, out _cMsg, out _xMsg, proxy, usuario, senha);

                if (cStat == 104)
                {
                    salvar_na_pasta(consulta, @"c:\\evolucao\\NFE\LOTE_PROCESSADO\LOTE_RECIBO" + nroRecibo + ".xml");

                    StringReader theReader = new StringReader(consulta);
                    DataSet ds = new DataSet();
                    ds.ReadXml(theReader);

                    

                    //tratar resultado
                    try
                    {
                        foreach (DataRow dr in ds.Tables["infProt"].Rows)
                        {
                            if (dr["nProt"].ToString() != "")
                            {
                                string arquivo = buscar_xml_assinado(dr["chNFe"].ToString(), nomeCertificado);
                                
                                Encoding unicode = Encoding.Unicode;

                                Encoding ansi = Encoding.GetEncoding(1252);

                                Byte[] utf8Bytes = unicode.GetBytes(arquivo);

                                Byte[] ansiBytes = Encoding.Convert(unicode, ansi, utf8Bytes);

                                string ansiContent = ansi.GetString(ansiBytes);
                                string procCTe, nroProtocolo, dAutorizacao;
                                string cancelamento;
                                string msgResultado;
                                int resultado;

                                procCTe = util2.CriaProcNFe2G("SP3", ref ansiContent, out nroProtocolo, out cancelamento, out resultado,
                                    nome_certificado_nfe_empresa, out msgResultado, proxy, usuario, senha);

                                if (resultado == 6201)
                                {
                                    salvar_na_pasta(procCTe, @"c:\\evolucao\\NFE\AUTORIZADAS\\NFE" + dr["chNFe"].ToString() + ".xml");
                                    try
                                    {
                                        update_coluna_xml_aut(procCTe, nroProtocolo, "NFe Autorizada.", dr["chNFe"].ToString());
                                        if (boleto_pedido_empresa != "1")
                                            inserir_duplicatas_cr(dr["chNFe"].ToString());

                                        string nf = buscar_n_nf(dr["chNFe"].ToString());
                                        inserir_status_pedido(nf);
                                        //acertarEstoque();
                                        /*
                                        classe_particularidades part = new classe_particularidades();
                                        part.executar_particularidades(nf);
                                        part.baixar_do_estoque();
                                        */
                                        
                                    }
                                    catch { }
                                }
                                else
                                {
                                    if (resultado == 6216)
                                    {
                                        salvar_na_pasta(procCTe, @"c:\\evolucao\\NFE\CANCELADAS\NFE" + dr["chNFe"].ToString() + ".xml");
                                        try
                                        {
                                            update_coluna_xml_canc(procCTe, nroProtocolo, "NFe Cancelada", dr["chNFe"].ToString());
                                        }
                                        catch { }
                                    }
                                    else
                                    {
                                        MessageBox.Show(resultado.ToString() + " " + msgResultado);
                                    }
                                }
                            }
                        }
                    }
                    catch
                    { }
                }
                else
                {
                    MessageBox.Show(consulta.ToString() + " " + _msgResultado + " " + consulta);
                }
                selecionar();
                MessageBox.Show("Lote Processado");

            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
            
        }

        private void inserir_status_pedido(string nf)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT N_PEDIDO_NF FROM PEDIDOS_NF WHERE NF_PEDIDO_NF = '" + nf + "'";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr_ped in dtSelect.Rows)
                {
                    FbCommand update = new FbCommand();
                    update.Connection = fbConnection1;
                    update.CommandText =
                     //   "UPDATE PEDIDOS_VENDA SET NF_PED_VENDA = '1' WHERE COD_PED_VENDA = '" + dr_ped[0].ToString() + "'";
                        "UPDATE PEDIDOS_VENDA SET NF_PED_VENDA = '1', N_NF_PED_VENDA = '" + nf + "', DATA_NF_PED_VENDA = '" +
                            DateTime.Now.ToShortDateString().Replace("/", ".") + "' WHERE COD_PED_VENDA = '" + dr_ped[0].ToString() + "'";
                    FbDataAdapter datUpdate = new FbDataAdapter();
                    fbConnection1.Open();
                    datUpdate.UpdateCommand = update;
                    datUpdate.UpdateCommand.ExecuteNonQuery();
                    fbConnection1.Close();
                }

            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
       
        }
        private string buscar_n_nf(string chave)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT nf.N_NF FROM NOTA_FISCAL nf " +
                    " where nf.CHAVE_ACESSO_NFE = '" + chave + "'";
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
            catch
            {
                fbConnection1.Close();
                return "";

            }
        }

        private void apagar_itens_cr(string nf)
        {
            try
            {
                /*
                FbCommand delete = new FbCommand();
                delete.CommandText =
                "DELETE FROM CONTAS_A_RECEBER WHERE NF_CR = '" + nf + "'";
                delete.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datDelete = new FbDataAdapter();
                datDelete.DeleteCommand = delete;
                datDelete.DeleteCommand.ExecuteNonQuery();
                fbConnection1.Close();*/
                try
                {
                    FbCommand update1 = new FbCommand();
                    update1.CommandText =
                    "UPDATE CONTAS_A_RECEBER SET CANCELADO_CR = 1, OBSERVACOES_CR = 'CANCELADA PELA PESQUISA NF' WHERE NF_CR = '" + nf + "' AND ORIGEM_CR = 'NF'";
                    fbConnection1.Open();
                    update1.Connection = fbConnection1;
                    FbDataAdapter datUpdate1 = new FbDataAdapter();
                    datUpdate1.UpdateCommand = update1;
                    datUpdate1.UpdateCommand.ExecuteNonQuery();
                    fbConnection1.Close();

                    FbCommand update = new FbCommand();
                    update.Connection = fbConnection1;
                    update.CommandText =
                    "UPDATE FATURA_NF SET CR_FATURA = NULL WHERE NF_FATURA = '" + nf + "'";
                    fbConnection1.Open();
                    FbDataAdapter datUpdate = new FbDataAdapter();
                    datUpdate.UpdateCommand = update;
                    datUpdate.UpdateCommand.ExecuteNonQuery();
                    fbConnection1.Close();

                    /*
                    this.datContas_a_receber.DeleteCommand.CommandText =
                    "DELETE FROM CONTAS_A_RECEBER WHERE NF_CR = '" + tb_n_nf.Text + "' AND ORIGEM_CR = 'NF'";
                    this.fbConnection1.Open();
                    this.datContas_a_receber.DeleteCommand.Connection = fbConnection1;
                    this.datContas_a_receber.DeleteCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                     * */
                }
                catch (Exception a)
                {
                    fbConnection1.Close();
                    MessageBox.Show(a.ToString());
                }
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }
        private void detectar_numero_vencimentos_fatura(out int n_venc, string nf)
        {
            try
            {
                FbCommand comando = new FbCommand();
                comando.Connection = fbConnection1;
                comando.CommandText =
                    "SELECT * " +
                    "FROM FATURA_NF WHERE NF_FATURA = '" + nf + "'";
                DataSet fatura = new DataSet();
                fbConnection1.Open();
                FbDataAdapter datFatura_nf = new FbDataAdapter();
                datFatura_nf.SelectCommand = comando;
                datFatura_nf.Fill(fatura);
                int n = 0;
                foreach (DataRow dr in fatura.Tables[0].Rows)
                {

                    _cod[n] = dr["COD_FATURA"].ToString();
                    _valores[n] = dr["VALOR_FATURA"].ToString();
                    _datas[n] = dr["DATA_VENC_FATURA"].ToString();
                    n++;

                }

                this.fbConnection1.Close();
                n_venc = n;
            }
            catch
            {
                fbConnection1.Close();
                n_venc = 0;
            }

        }

        private void selecionar_dados_cliente(string cnpj, out string logradouro, out string bairro, out string cep, out string cidade,
            out string complemento, out string numero, out string uf, out double desconto, out int desconto_valor, out int desconto_pontualidade)
        {
            logradouro = ""; bairro = ""; cep = ""; cidade = ""; complemento = ""; numero = ""; uf = "";
            desconto = 0; desconto_valor = 0; desconto_pontualidade = 0;
            try
            {
                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT * FROM CLIENTES " +
                    " WHERE CNPJ = '" + cnpj + "'";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
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


        string[] _datas = new string[50];
        string[] _valores = new string[50];
        string[] _cod = new string[50];

        private void inserir_duplicatas_cr(string chave)
        {
            string cod_cliente, cliente, nf, cnpj;
            buscar_dados_nf(chave, out nf, out cod_cliente, out cliente, out cnpj);
            apagar_itens_cr(nf);
            //variaveis detecta_fatura

            string forma_pgto = buscar_forma_pagamento(nf);
            double desconto;
            int desconto_valor, desconto_pontualidade;
            string logradouro, bairro, cep, cidade, complemento, numero, uf;
            selecionar_dados_cliente(cnpj, out logradouro, out bairro, out cep, out cidade,
                out complemento, out numero, out uf, out desconto, out desconto_valor, out desconto_pontualidade);

            int _n_vencimentos;
            //a parada é 6 pois é o numero máximo de parcelas
            for (int i = 0; i < 6; i++)
            {
                _cod[i] = ""; _datas[i] = ""; _valores[i] = "";
            }
            detectar_numero_vencimentos_fatura(out _n_vencimentos, nf);
            for (int i = 0; i < _n_vencimentos; i++)
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




                    double valor_boleto = Convert.ToDouble(_valores[i]);

                    if (desconto > 0 && desconto_valor == 1)
                    {
                        valor_boleto = valor_boleto - (valor_boleto * desconto / 100);
                    }

                    int parcela_n = i + 1;
                    FbCommand insert = new FbCommand();
                    insert.CommandText =
                    "INSERT INTO CONTAS_A_RECEBER (VALOR_CR, DATA_PREVISTA_CR, COD_CLIENTE_CR, " +
                    "RAZAO_CLIENTE_CR, DESCRICAO_CR, DUPLICATA_CR, NF_CR, CC_CR, DESCRICAO_CC_CR, ORIGEM_CR, FORMA_PGTO_CR) " +
                    "VALUES ('" + valor_boleto.ToString().Replace(".", "").Replace(",", ".") + "', '" + Convert.ToDateTime(_datas[i]).ToShortDateString().Replace("/", ".") +
                    "', '" + cod_cliente + "','" + cliente +
                    "', 'PARCELA " + parcela_n.ToString() + "/" + _n_vencimentos.ToString() + " REF. A NF Nº " + nf +
                    "', '" + parcela_n.ToString() + "','" + nf + "'," + _cod_interno_banco + "," + _descricao_banco + ",'NF', '" + forma_pgto + "') RETURNING COD_CR";
                    insert.Connection = fbConnection1;
                    fbConnection1.Open();
                    FbDataAdapter datContas_a_receber = new FbDataAdapter();
                    datContas_a_receber.InsertCommand = insert;
                    object _cod_cr = datContas_a_receber.InsertCommand.ExecuteScalar();
                    this.fbConnection1.Close();

                    _descricao_banco = _descricao_banco.Replace("'", "");
                    _cod_interno_banco = _cod_interno_banco.Replace("'", "");

                    update_cr_fatura(_cod[i], _cod_cr);

                  
                }
                catch
                {
                    MessageBox.Show("Erro na inserção da duplicata " + _cod[i].ToString());
                    fbConnection1.Close();
                }
                /*
                try
                {

                    int parcela_n = i + 1;
                    FbCommand insert = new FbCommand();
                    insert.CommandText =
                    "INSERT INTO CONTAS_A_RECEBER (VALOR_CR, DATA_PREVISTA_CR, COD_CLIENTE_CR, " +
                    "RAZAO_CLIENTE_CR, DESCRICAO_CR, DUPLICATA_CR, NF_CR) " +
                    "VALUES ('" + _valores[i].Replace(".", "").Replace(",", ".") + "', '" + Convert.ToDateTime(_datas[i]).ToShortDateString().Replace("/", ".") +
                    "', '" + cod_cliente + "','" + cliente +
                    "', 'PARCELA " + parcela_n.ToString() + "/" + _n_vencimentos.ToString() + " REF. A NF Nº " + nf +
                    "', '" + parcela_n.ToString() + "','" + nf + "')";
                    insert.Connection = fbConnection1;
                    fbConnection1.Open();
                    FbDataAdapter datContas_a_receber = new FbDataAdapter();
                    datContas_a_receber.InsertCommand = insert;
                    datContas_a_receber.InsertCommand.ExecuteNonQuery();
                    fbConnection1.Close();
                }
                catch
                {
                    MessageBox.Show("Erro na inserção da duplicata " + _cod[i].ToString());
                    fbConnection1.Close();
                }
                 * */
            }

        }

        private string buscar_forma_pagamento(string nf)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT FORMA_PGTO_NF FROM NOTA_FISCAL WHERE N_NF = '" + nf + "'";
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
            catch(Exception a)
            {
                fbConnection1.Close();
                //MessageBox.Show(a.ToString());
                return "";
               
            }
        }

        private void update_cr_fatura(string cod_fatura, object _cod_cr)
        {
            try
            {
                FbCommand update = new FbCommand();
                update.Connection = fbConnection1;
                fbConnection1.Open();
                update.CommandText =
                    "UPDATE FATURA_NF SET CR_FATURA = '" + _cod_cr.ToString() + "' WHERE COD_FATURA = '" + cod_fatura + "'";
                FbDataAdapter datUpdate = new FbDataAdapter();
                datUpdate.UpdateCommand = update;
                datUpdate.UpdateCommand.ExecuteNonQuery();
                fbConnection1.Close();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
            }
        }

        private void buscar_dados_nf(string chave, out string nf, out string cod_cliente, out string cliente, out string cnpj)
        {
            cod_cliente = ""; cliente = ""; nf = ""; cnpj = "";
            try
            {
                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT cli.COD_CLIENTE, cli.RAZAO_SOCIAL, nf.N_NF, cli.CNPJ FROM NOTA_FISCAL nf " +
                    "inner join CLIENTES cli ON nf.CNPJ_CLIENTE_FORN = cli.CNPJ " +
                    " where nf.CHAVE_ACESSO_NFE = '" + chave + "'";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    cod_cliente = dr[0].ToString();
                    cliente = dr[1].ToString();
                    nf = dr[2].ToString();
                    cnpj = dr[3].ToString();
                }
            }
            catch
            {
                fbConnection1.Close();
            }
        }

        private void update_coluna_xml_canc(string procCTe, string nroProtocolo, string status, string chave_acesso)
        {
            try
            {
                fbConnection1.Open();
                FbTransaction trans = fbConnection1.BeginTransaction();
                fbConnection1.Close();
                FbCommand update = new FbCommand("UPDATE NOTA_FISCAL SET XML_CANCELADO_NF = ?, STATUS_NFE = ?, N_PROTOCOLO_AUTORIZACAO_NF = ? " +
                    "WHERE CHAVE_ACESSO_NFE = ?", fbConnection1, trans);
                update.Parameters.AddWithValue("XML_CANCELADO_NF", procCTe);
                update.Parameters.AddWithValue("STATUS_NFE", status);
                update.Parameters.AddWithValue("N_PROTOCOLO_AUTORIZACAO_NF", nroProtocolo);
                update.Parameters.AddWithValue("CHAVE_ACESSO_NFE", chave_acesso);
                fbConnection1.Open();
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.UpdateCommand = update;
                datTabela.UpdateCommand.ExecuteNonQuery();
                fbConnection1.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
                fbConnection1.Close();
            }
        }

        private void update_coluna_xml_aut(string procCTe, string nroProtocolo, string status, string chave_acesso)
        {
            try
            {
                nroProtocolo = nroProtocolo.Remove(15);

                fbConnection1.Open();
                FbTransaction trans = fbConnection1.BeginTransaction();
                fbConnection1.Close();
                FbCommand update = new FbCommand("UPDATE NOTA_FISCAL SET XML_AUTORIZADO_NF = ?, STATUS_NFE = ?, N_PROTOCOLO_AUTORIZACAO_NF = ? " +
                    "WHERE CHAVE_ACESSO_NFE = ?", fbConnection1, trans);
                update.Parameters.AddWithValue("XML_AUTORIZADO_NF", procCTe);
                update.Parameters.AddWithValue("STATUS_NFE", status);
                update.Parameters.AddWithValue("N_PROTOCOLO_AUTORIZACAO_NF", nroProtocolo);
                update.Parameters.AddWithValue("CHAVE_ACESSO_NFE", chave_acesso);
                fbConnection1.Open();
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.UpdateCommand = update;
                datTabela.UpdateCommand.ExecuteNonQuery();
                fbConnection1.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
                fbConnection1.Close();
            }
        }
        private string buscar_xml_assinado(string chave, string Nome)
        {

            try
            {
                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT XML_GERADO_NF FROM NOTA_FISCAL WHERE CHAVE_ACESSO_NFE = '" + chave + "'";
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
                MessageBox.Show(a.ToString());
                fbConnection1.Close();
                return "";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvNota_fiscal.SelectedRows.Count; i++)
            {
                form_faturamento fat = new form_faturamento(cnpj_empresa);
                try
                {
                    if (cb_imp_nfe.Checked)
                    {
                        fat.imprimir_nota = true;
                    }
                    else
                    {
                        fat.imprimir_nota_e_boleto = true;
                    }
                    fat.nota_a_abrir = dgvNota_fiscal.SelectedRows[i].Cells["col_n_nf"].Value.ToString();
                    fat.Opacity = 0;
                    fat.ShowDialog();
                }
                finally
                {
                    fat.Dispose();
                    GC.Collect();
                   // GC.WaitForPendingFinalizers();
                   // if (Environment.OSVersion.Platform == PlatformID.Win32NT)
                   //     SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, -1, -1);
                }
            }
        }

        private void dgvNota_fiscal_SelectionChanged(object sender, EventArgs e)
        {
            int cont = dgvNota_fiscal.SelectedRows.Count;
            tbCont.Text = cont.ToString();

        }
        private string buscar_xml_autorizado(string chave)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT XML_AUTORIZADO_NF FROM NOTA_FISCAL WHERE CHAVE_ACESSO_NFE = '" + chave + "'";
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


        private void button4_Click(object sender, EventArgs e)
        {
            string[] _erros = new string[500];
            int n_erros = 0;
            for (int i = 0; i < dgvNota_fiscal.SelectedRows.Count; i++)
            {

                string chave = dgvNota_fiscal.SelectedRows[i].Cells["col_chave"].Value.ToString();
                string nf = dgvNota_fiscal.SelectedRows[i].Cells["col_n_nf"].Value.ToString();
                double valor_nota = 0;
                try
                {
                    valor_nota = Convert.ToDouble(dgvNota_fiscal.SelectedRows[i].Cells["col_valor_total"].Value.ToString());
                }
                catch { }


                string _caminho_arquivo = "c:\\evolucao\\NFE\\autorizadas\\NFE" + chave + ".xml";
                if (!File.Exists(_caminho_arquivo))
                {
                    string _xml_autorizado = buscar_xml_autorizado(chave);
                    if (_xml_autorizado != "")
                        salvar_na_pasta(_xml_autorizado, @"c:\\evolucao\\NFE\AUTORIZADAS\\NFE" + chave + ".xml");
                    else
                        MessageBox.Show("XML da NF " + nf + " não encontrado");
                }

                string _caminho_danfe = "c:\\evolucao\\NFE\\DANFES\\DANFE_NFE_" + nf + ".pdf";
                string _caminho_boleto = @"c:\\evolucao\\NFE\\BOLETOS\\BOLETO_NFE_" + nf + ".pdf";
                if (razao_social_empresa.ToUpper().Contains("LLOC"))
                {
                    _caminho_boleto = "";
                }
                //var assunto
                string _assunto = assunto_nfe_email_empresa + " " + chave;
                double _valor_total = valor_nota;
                string _mensagem = "<html xmlns:v='urn:schemas-microsoft-com:vml'" +
    "xmlns:o='urn:schemas-microsoft-com:office:office'" +
    "xmlns:w='urn:schemas-microsoft-com:office:word'" +
    "xmlns='http://www.w3.org/TR/REC-html40'>" +

    "<head>" +
    "<meta http-equiv=Content-Type content='text/html; charset=windows-1252'>" +
    "<meta name=ProgId content=Word.Document>" +
    "<meta name=Generator content='Microsoft Word 11'>" +
    "<meta name=Originator content='Microsoft Word 11'>" +
    "<link rel=File-List href='body_arquivos/filelist.xml'>" +
    "<title>Prezado cliente,</title>" +
    "</head>" +
    "<body lang=PT-BR link=blue vlink=purple style='tab-interval:35.4pt' fontface = 'Arial'> " +
    "<div class=Section1> " +
    "<p class=MsoPlainText><span style='font-family:'Comic Sans MS''>Prezado cliente,<o:p></o:p></span></p> " +
    "<p class=MsoPlainText><span style='font-family:'Comic Sans MS''><o:p>&nbsp;</o:p></span></p>" +
    "<p class=MsoPlainText><span style='font-family:'Comic Sans MS''>Segue anexo a Nota Fiscal Eletrônica em XML sob n.: <o:p></o:p></span></p>" +
    "<p class=MsoPlainText><span class=GramE><span style='font-family:'Comic Sans MS';color:red'>" + chave + "</span><span" +
    "style='font-family:'Comic Sans MS''>, série " + serie_empresa + "</span></span><span style='font-family:'Comic Sans MS''> de " + razao_social_empresa +
    ", no valor de R$ <span style='color:red'>" + _valor_total.ToString("n2") + ". </span><br> O DANFE segue em PDF e fisicamente com a mercadoria.<br><br><o:p></o:p></span></p>" +
            "<p class=MsoPlainText><span style='font-family:'Comic Sans MS''>Atenciosamente,<o:p></o:p></span></p>" +
    "<p class=MsoNormal><span style='font-size:10.0pt;font-family:'Comic Sans MS';" +
    "mso-bidi-font-family:Arial'><o:p>&nbsp;</o:p></span></p>" +
    "<p class=MsoNormal><span style='font-size:10.0pt;font-family:'Comic Sans MS';" +
    "mso-no-proof:yes'>_________________________<br>" +
    "Setor de Faturamento<br>" +
    "Tel: " + telefone_empresa + "<br>" +
    "e-mail: <a href='mailto:" + email_nfe_empresa + "'>" + email_nfe_empresa + "</a><br>" +
    "</div>" +
    "</body>" +
    "</html>";
                Email novo_email = new Email();
                bool _erro;
                //var smtp, email, senha_email
                string email = buscar_email_nf(nf);
                novo_email.EnviarEmail(email, _assunto, _mensagem, _caminho_arquivo, _caminho_danfe, _caminho_boleto,
                email_nfe_empresa, senha_email_nfe_empresa, smtp_nfe_empresa, out _erro, dgvNota_fiscal.SelectedRows[i].Cells["col_cnpj"].Value.ToString());

                if (_erro)
                {
                    _erros[n_erros] = "NF: " + nf + " - Email não enviado. Favor verificar dados. ";
                    n_erros++;
                }
            }

            string mensagem = "";
            for (int i = 0; i < n_erros; i++)
            {
                mensagem = mensagem + _erros[i] + "\n";
            }
            if (mensagem == "")
                MessageBox.Show("Emails enviados com sucesso");
            else
                MessageBox.Show(mensagem);

        }
        private string buscar_email_nf(string nf)
        {
            //nf = "";
            try
            {
                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT cli.EMAIL FROM NOTA_FISCAL nf " +
                    "inner join CLIENTES cli ON nf.CNPJ_CLIENTE_FORN = cli.CNPJ " +
                    " where nf.N_NF = '" + nf + "'";
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
            catch
            {
                fbConnection1.Close();
                return "";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DateTime data = DateTime.Now;
            if (tb_data_saida.Text != "")
                data = Convert.ToDateTime(tb_data_saida.Text);

            if (data < DateTime.Now.AddDays(-3))
            {
                MessageBox.Show("A data de saída não pode ser maior que 3 dias anteriores a hoje.");

            }
            else
            {
                form_pesquisa_pedido ped = new form_pesquisa_pedido(true, cnpj_empresa);
                try
                {

                    ped.selecao_nf = true;
                    ped.ShowDialog();


                }
                finally
                {
                    for (int i = 0; i < ped.numero_pedidos; i++)
                    {
                        // ped.pedidos_selecionados[0] 
                        form_faturamento nf = new form_faturamento(cnpj_empresa);
                        try
                        {
                            bool teste = false;
                            if (cbTeste.Checked)
                                teste = true;
                            nf.teste = teste;
                            nf.nova_nota = true;
                            nf.apenas_xml = true;
                            nf.n_pedido = Convert.ToInt32(ped.pedidos_selecionados[i]);
                            nf.data_saida_nf = tb_data_saida.Text;
                            nf.ShowDialog();
                        }
                        finally
                        {

                        }
                    }
                }
                selecionar();
            }
        }

        private void tb_status_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsNota_fiscal.Tables["NOTA_FISCAL"].DefaultView.RowFilter = "STATUS_NFE Like '*" + tb_status.Text + "*'";
                somar_valores();
            }
            catch
            {
                dsNota_fiscal.Tables["NOTA_FISCAL"].DefaultView.RowFilter = "STATUS_NFE is not null";
                somar_valores();
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void tb_lote_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsNota_fiscal.Tables["NOTA_FISCAL"].DefaultView.RowFilter = "LOTE_ENVIO_NF = '" + tb_lote.Text + "'";
                somar_valores();
            }
            catch
            {
                dsNota_fiscal.Tables["NOTA_FISCAL"].DefaultView.RowFilter = "0 = 0";
                somar_valores();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cores();
            somar_valores();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            inserir_duplicatas_cr(dgvNota_fiscal.SelectedRows[0].Cells["col_chave"].Value.ToString());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                dsNfs nf = new dsNfs();

                for (int i = 0; i < dgvNota_fiscal.RowCount; i++)
                {
                    nf.Notas.AddNotasRow(Convert.ToInt32(dgvNota_fiscal.Rows[i].Cells["col_n_nf"].Value.ToString()),
                        dgvNota_fiscal.Rows[i].Cells["col_cliente"].Value.ToString(),
                        Convert.ToDateTime(dgvNota_fiscal.Rows[i].Cells["col_data"].Value.ToString()),
                        dgvNota_fiscal.Rows[i].Cells["col_status"].Value.ToString(),
                        dgvNota_fiscal.Rows[i].Cells["col_natureza"].Value.ToString(),
                        dgvNota_fiscal.Rows[i].Cells["col_forma"].Value.ToString(),
                        Convert.ToDouble(dgvNota_fiscal.Rows[i].Cells["col_valor_total"].Value.ToString()),
                        dgvNota_fiscal.Rows[i].Cells["col_vendedor"].Value.ToString());
                }
                nf.Informacoes.AddInformacoesRow(Convert.ToDateTime(dtInicio.Text), Convert.ToDateTime(dtTermino.Text));

                crNotas_Fiscais nfs = new crNotas_Fiscais();
                nfs.SetDataSource(nf);
                form_imprimir imp = new form_imprimir(nfs);
                imp.Show();
            }
            catch { }
        }



    }

}