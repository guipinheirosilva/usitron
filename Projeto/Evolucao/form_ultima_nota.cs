using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using FirebirdSql.Data.FirebirdClient;

namespace Evolucao
{
    public partial class form_ultima_nota : Form
    {
        //NFe_Util_PL005a.Util util = new NFe_Util_PL005a.Util();
        NFe_Util_2G.Util util2 = new NFe_Util_2G.Util();
        string cnpj;
        public form_ultima_nota(string cnpj)
        {
            this.cnpj = cnpj;
            InitializeComponent();
        }

        private void form_ultima_nota_Load(object sender, EventArgs e)
        {
            datImp.Fill(ULT_IMP_NF);
            datNf_inutilizadas.Fill(NFS_INUTILIZADAS);
            datEmpresa.Fill(EMPRESA);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsImp, "ULT_IMP_NF"].EndCurrentEdit();
            fbConnection1.Open();
            if (dsImp.HasChanges())
            {
                datImp.UpdateCommand = cbImp.GetUpdateCommand();
                datImp.InsertCommand = cbImp.GetInsertCommand();
                datImp.DeleteCommand = cbImp.GetDeleteCommand();
                datImp.Update(dsImp, "ULT_IMP_NF");
                dsImp.AcceptChanges();
            }
            fbConnection1.Close(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tb_motivo.Text.Length < 15)
                MessageBox.Show("Digite o motivo da inutilização com pelo menos 15 caracteres");
            else
            {
                int ambiente = 1;
                string ano = "";
                ano = DateTime.Now.Year.ToString();
                string ano_2 = ano[2].ToString() + ano[3].ToString();
                //MessageBox.Show(ano_2);
                string razao_social_empresa = "", nome_fantasia_empresa = "", cnpj_empresa = "", ie_empresa = "", im_empresa = "", cnae_empresa = "", endereco_empresa = "", n_endereco_empresa = "",
           complemento_empresa = "", bairro_empresa = "", cidade_empresa = "", estado_empresa = "", cep_empresa = "", telefone_empresa = "", cod_cidade_empresa = "", pais_empresa = "",
           cod_pais_empresa = "", licenca_dll_nfe_empresa = "", nome_certificado_nfe_empresa = "", assunto_nfe_email_empresa = "", smtp_nfe_empresa = "", email_nfe_empresa = "",
           senha_email_nfe_empresa = "", logotipo_empresa = "", proxy_empresa = "", usuario_proxy_empresa = "", senha_proxy_empresa = "", crt_empresa = "", portaEmailEmpresa = "", sslEmpresa = "", serie_empresa = "";


                detectar_dados_empresa(out razao_social_empresa, out nome_fantasia_empresa, out cnpj_empresa, out ie_empresa, out im_empresa, out cnae_empresa, out endereco_empresa, out n_endereco_empresa,
        out complemento_empresa, out bairro_empresa, out cidade_empresa, out estado_empresa, out cep_empresa, out telefone_empresa, out cod_cidade_empresa, out pais_empresa,
        out cod_pais_empresa, out licenca_dll_nfe_empresa, out nome_certificado_nfe_empresa, out assunto_nfe_email_empresa, out smtp_nfe_empresa, out email_nfe_empresa,
        out senha_email_nfe_empresa, out logotipo_empresa, out proxy_empresa, out usuario_proxy_empresa, out senha_proxy_empresa, out crt_empresa, out portaEmailEmpresa, out sslEmpresa, out serie_empresa);
                string proxy = proxy_empresa;
                string usuario = usuario_proxy_empresa;
                string senha = senha_proxy_empresa;
                string licenca = licenca_dll_nfe_empresa;
                string nomeCertificado = nome_certificado_nfe_empresa;
                string nProtocoloInut, dProtocoloInut, _msgCabec, _msgDados, _msgRetWS, _msgResultado;
                int _cStat = 0;

                /*
                string wsuf = "SP3";
                if (estado_empresa != "SP")
                    wsuf = "SVRS";

               // string resultado = util.InutilizaNroNF("SP", ambiente, nomeCertificado, out _msgCabec, out _msgDados, out _msgRetWS, out _msgResultado, "35", ano_2, "00984411000169", "55", "1", tb_inicio.Text, tb_fim.Text, tb_motivo.Text, proxy, usuario, senha, licenca);
            
                
                string resultado = util2.InutilizaNroNF2G(wsuf, ambiente, nomeCertificado, "3.10", out _msgDados, out _msgRetWS,
                    out _cStat, out _msgResultado, cod_cidade_empresa.Remove(2), ano_2, cnpj_empresa, "55", serie_empresa, tb_inicio.Text, 
                    tb_fim.Text, tb_motivo.Text, out nProtocoloInut, out dProtocoloInut, proxy, usuario, senha, licenca);
                /* MODIFICACOAO FEITA EM 15/01/2015
                string resultado = util2.InutilizaNroNF2G("SP", ambiente, nomeCertificado, "2.00", out _msgDados, out _msgRetWS,
                    out _cStat, out _msgResultado, cod_cidade_empresa.Remove(2), ano_2, cnpj_empresa, "55", "1", tb_inicio.Text,
                    tb_fim.Text, tb_motivo.Text, out nProtocoloInut, out dProtocoloInut, proxy, usuario, senha, licenca);
                */
                string wsuf = "SP";
                if (estado_empresa != "SP")
                    wsuf = "SVRS";
                // string resultado = util.InutilizaNroNF("SP", ambiente, nomeCertificado, out _msgCabec, out _msgDados, out _msgRetWS, out _msgResultado, "35", ano_2, "00984411000169", "55", "1", tb_inicio.Text, tb_fim.Text, tb_motivo.Text, proxy, usuario, senha, licenca);
                string resultado = util2.InutilizaNroNF2G(wsuf, ambiente, nomeCertificado, "4.00", out _msgDados, out _msgRetWS,
                out _cStat, out _msgResultado, cod_cidade_empresa.Remove(2), ano_2, cnpj_empresa, "55", serie_empresa, tb_inicio.Text,
                tb_fim.Text, tb_motivo.Text, out nProtocoloInut, out dProtocoloInut, proxy, usuario, senha, licenca);
  
                MessageBox.Show(resultado.ToString());
                if (_cStat == 102)
                {
                    gerar_xml_inutilizada(resultado);
                    inserir_inutilizadas(tb_inicio.Text, tb_fim.Text, tb_motivo.Text);
                    dsNf_inutilizadas.Clear();
                    datNf_inutilizadas.Fill(NFS_INUTILIZADAS);
               }
                else
                {
                    MessageBox.Show(_msgResultado, resultado.ToString());
                }
            }

        }
        private void detectar_dados_empresa(out string razao_social_empresa, out string nome_fantasia_empresa, out string cnpj_empresa, out string ie_empresa, out string im_empresa, out string cnae_empresa, out string endereco_empresa, out string n_endereco_empresa,
                   out string complemento_empresa, out string bairro_empresa, out string cidade_empresa, out string estado_empresa, out string cep_empresa, out string telefone_empresa, out string cod_cidade_empresa, out string pais_empresa,
                   out string cod_pais_empresa, out string licenca_dll_nfe_empresa, out string nome_certificado_nfe_empresa, out string assunto_nfe_email_empresa, out string smtp_nfe_empresa, out string email_nfe_empresa,
                   out string senha_email_nfe_empresa, out string logotipo_empresa, out string proxy_empresa, out string usuario_proxy_empresa, out string senha_proxy_empresa,
           out string crt_empresa, out string portaEmailEmpresa, out string sslEmpresa, out string serie_empresa)
        {
            razao_social_empresa = ""; nome_fantasia_empresa = ""; cnpj_empresa = ""; ie_empresa = ""; im_empresa = ""; cnae_empresa = ""; endereco_empresa = ""; n_endereco_empresa = "";
            complemento_empresa = ""; bairro_empresa = ""; cidade_empresa = ""; estado_empresa = ""; cep_empresa = ""; telefone_empresa = ""; cod_cidade_empresa = ""; pais_empresa = "";
            cod_pais_empresa = ""; licenca_dll_nfe_empresa = ""; nome_certificado_nfe_empresa = ""; assunto_nfe_email_empresa = ""; smtp_nfe_empresa = ""; email_nfe_empresa = "";
            senha_email_nfe_empresa = ""; logotipo_empresa = ""; proxy_empresa = ""; usuario_proxy_empresa = ""; senha_proxy_empresa = ""; crt_empresa = ""; portaEmailEmpresa = "";
            sslEmpresa = ""; serie_empresa = "";
            try
            {
                FbCommand comando = new FbCommand();
                comando.Connection = fbConnection1;
                comando.CommandText = "SELECT * FROM EMPRESA where LICENCA_DLL_NFE_EMPRESA is not null and cnpj_empresa = '" + cnpj + "'";
                DataSet empresa = new DataSet();
                fbConnection1.Open();
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
                }

            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void gerar_xml_inutilizada(string xml_inutilizada)
        {
            try
            {
                
                FileInfo t = new FileInfo("c:\\evolucao\\nfe\\inutilizadas\\" + "NFE" + tb_inicio.Text + "_" + tb_fim.Text + ".xml");
                using (StreamWriter texto = t.CreateText())
                {
                    texto.WriteLine(xml_inutilizada);
                }
            }
            catch { }
        }

        private void inserir_inutilizadas(string ini, string fim, string motivo)
        {
            try
            {
                this.datNf_inutilizadas.InsertCommand.CommandText =
                    "INSERT INTO NFS_INUTILIZADAS (N_INICIO_NF_INUTILIZADA, N_FIM_NF_INUTILIZADA, JUSTIFICATIVA_NF_INUTILIZADA, DATA_NF_INUTILIZADA, CNPJ_EMPRESA_NF_INUTILIZADA) " +
                    "VALUES ('" + ini + "', '" + fim + "','" + tb_motivo.Text + "','" + DateTime.Now.ToShortDateString().Replace("/", ".") + "','" + cnpj + ")";
                this.fbConnection1.Open();
                this.datNf_inutilizadas.InsertCommand.Connection = fbConnection1;
                this.datNf_inutilizadas.InsertCommand.ExecuteNonQuery();
                this.fbConnection1.Close(); 
            }
            catch(Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.BindingContext[dsEmpresa, "EMPRESA"].EndCurrentEdit();
                if (dsEmpresa.HasChanges())
                {
                    //MessageBox.Show("CHEGOU AQUI");
                    fbConnection1.Open();
                    datEmpresa.UpdateCommand = cbEmpresa.GetUpdateCommand();
                    datEmpresa.InsertCommand = cbEmpresa.GetInsertCommand();
                    datEmpresa.DeleteCommand = cbEmpresa.GetDeleteCommand();
                    datEmpresa.Update(dsEmpresa, "EMPRESA");
                    dsEmpresa.AcceptChanges();
                    fbConnection1.Close(); 
                }
            }
            catch (Exception a)
            {
                fbConnection1.Close(); 
                MessageBox.Show(a.ToString());
            }
        }
    }
}