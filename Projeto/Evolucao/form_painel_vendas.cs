using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_painel_vendas : Form
    {
        DataTable dtMetas_familia = new DataTable();
        DataTable dtMetas_vendedor = new DataTable();
        DataTable dtVendas_cliente = new DataTable();
        DataTable dtFinanceiro = new DataTable();
        DataTable dtVisitas = new DataTable();
        DataTable dtVisitas_dia = new DataTable();
        public form_painel_vendas()
        {
            InitializeComponent();
        }

        private void btnAddVendedor_Click(object sender, EventArgs e)
        {
            form_vendedores vend = new form_vendedores();
            try
            {
                vend.ShowDialog();
            }
            finally
            {
                vend.Dispose();
                tb_cod_vendedor.Text = vend.cod_vendedor_escolhido;
                tb_nome_vendedor.Text = vend.vendedor_escolhido;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!cbFamilia.Checked && !cbClientes.Checked && !cbVendedores.Checked && !cbFinanceiro.Checked && !cbVisitas.Checked)
            {
                cbClientes.Checked = true; cbFamilia.Checked = true; cbFinanceiro.Checked = true; cbVendedores.Checked = true; cbVisitas.Checked = true;
            }
            preencher_parametros();
            if(cbFamilia.Checked)
                preencher_metas_familia();
            if(cbVendedores.Checked)
                preencher_metas_vendedor();
           
            if (cbFinanceiro.Checked)
                preencher_financeiro();
            if (cbVisitas.Checked)
                preencher_visitas();
            if (cbClientes.Checked)
            {
                preencher_vendas_clientes();
                preencher_visitas_hoje();
            }

        }

        private void preencher_visitas_hoje()
        {
            try
            {
                DateTime primeiro_dia_mes = Convert.ToDateTime("01/" + Convert.ToDateTime(dt_hoje.Text).Month.ToString() + "/" + Convert.ToDateTime(dt_hoje.Text).Year.ToString());
                DateTime ultimo_dia_mes = Convert.ToDateTime("01/" + Convert.ToDateTime(dt_hoje.Text).AddMonths(1).Month.ToString() + "/" + Convert.ToDateTime(dt_hoje.Text).AddMonths(1).Year.ToString()).AddDays(-1);

                DateTime dia_atual = Convert.ToDateTime(dt_hoje.Text);

                string vendedor = "%";
                if (tb_cod_vendedor.Text != "" && cb_vendedor.Checked)
                    vendedor = tb_cod_vendedor.Text;


                string numero_dia_semana = buscar_numero_dia_semana(dia_atual);

                FbCommand select = new FbCommand();
                select.CommandText = "SELECT " + /* VISITA_PROGRAMADAS */
"cli.CNPJ, cli.RAZAO_SOCIAL, cli.NOME_FANTASIA, cli.ENDERECO, cli.NUMERO_CLIENTE, cli.BAIRRO, cli.CIDADE  " +
" FROM CLIENTES cli " +
" INNER JOIN VENDEDORES_CLIENTE vcli on cli.COD_CLIENTE = vcli.COD_CLIENTE_VC " +
" WHERE cli.DIA_VISITA_CLIENTE LIKE '" + numero_dia_semana + "__' AND vcli.COD_VENDEDOR_VC LIKE '" + vendedor + "'";
                select.Connection = fbConnection1;
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                dtVisitas_dia.Clear();
                datSelect.Fill(dtVisitas_dia);
                fbConnection1.Close();
                dgvVisitas_dia.DataSource = dtVisitas_dia;
                labelVisitas_hoje.Text = dgvVisitas_dia.RowCount.ToString();

            }
            catch (Exception a)
            {
                fbConnection1.Close();
            }
        }

        private void preencher_visitas()
        {
             try
            {
                DateTime primeiro_dia_mes = Convert.ToDateTime("01/" + Convert.ToDateTime(dt_hoje.Text).Month.ToString() + "/" + Convert.ToDateTime(dt_hoje.Text).Year.ToString());
                DateTime ultimo_dia_mes = Convert.ToDateTime("01/" + Convert.ToDateTime(dt_hoje.Text).AddMonths(1).Month.ToString() + "/" + Convert.ToDateTime(dt_hoje.Text).AddMonths(1).Year.ToString()).AddDays(-1);

                DateTime dia_anterior = buscar_dia_anterior(Convert.ToDateTime(dt_hoje.Text));

                string vendedor = "%";
                if (tb_cod_vendedor.Text != "" && cb_vendedor.Checked)
                    vendedor = tb_cod_vendedor.Text;
                

                string fornecedor = "%";
                if (tb_cod_fornecedor.Text != "" && cb_fornecedor.Checked)
                    fornecedor = tb_cod_fornecedor.Text;

                 string numero_dia_semana = buscar_numero_dia_semana(dia_anterior);

                 string semana_mes = "";
                 string impar_par_semana_me = "";
                 /*
                 if (tb_semana_mes.Text != "")
                 {
                     semana_mes = " AND (c.DIA_VISITA_CLIENTE LIKE '__" + tb_semana_mes.Text + "'";
                     if (tb_semana_mes.Text != "1")
                     {
                         if (numero_dia_semana != "")
                         {
                             semana_mes += " or c.DIA_VISITA_CLIENTE LIKE '" + tb_dia_semana.Text + "1_'";
                         }
                     }
                 }
                  * */



                FbCommand select = new FbCommand();
                select.CommandText = "SELECT " + /* VISITA_PROGRAMADAS */
"COUNT(COD_CLIENTE) AS VISITAS_DIA, " + 
/* positivacao DIA */
"(select COUNT(DISTINCT(nfe1.cnpj_cliente_forn))  from metas_produto_vendedor met1 " + 
" inner join produtos prod1 on  met1.familia_mpv = prod1.NOME_FAMILIA_PRODUTO " + 
"  inner join itens_nota infe1 on (CAST(prod1.cod_produto AS VARCHAR(50)) = CAST(infe1.cod_item AS VARCHAR(50))  or "+ 
"  CAST(prod1.COD_FORNECEDOR_PRODUTO AS VARCHAR(50)) = CAST(infe1.cod_item AS VARCHAR(50))) " + 
"  inner join nota_fiscal nfe1 on infe1.nf_item = nfe1.n_nf " + 
"   inner join pedidos_nf pnf1 on nfe1.n_nf = pnf1.nf_pedido_nf " + 
"    inner join pedidos_venda pv1 on pnf1.n_pedido_nf = pv1.cod_ped_venda and met1.COD_VENDEDOR_MPV = pv1.cod_vendedor_ped_venda " + 
"     where nfe1.data_emissao_nf >= '" + dia_anterior.ToShortDateString().Replace("/",".") + 
"' and nfe1.data_emissao_nf <= '" + dia_anterior.ToShortDateString().Replace("/",".") + "' " + 
"      and pv1.cod_vendedor_ped_venda like '" + vendedor + "' and (infe1.cfop_item like '_1__' or infe1.cfop_item like '_4__') and " +
"      nfe1.status_nfe like '%Autorizada%' " +
"       and prod1.CNPJ_FORNECEDOR_PRODUTO like '" + fornecedor + "' ) AS POSITIVADOS_DIA, " + 
/*POSITIVACAO MES */
"(select COUNT(DISTINCT(nfe6.cnpj_cliente_forn))  from metas_produto_vendedor met6 " + 
" inner join produtos prod6 on  met6.familia_mpv = prod6.NOME_FAMILIA_PRODUTO " + 
"  inner join itens_nota infe6 on (CAST(prod6.cod_produto AS VARCHAR(50)) = CAST(infe6.cod_item AS VARCHAR(50))  or " + 
"  CAST(prod6.COD_FORNECEDOR_PRODUTO AS VARCHAR(50)) = CAST(infe6.cod_item AS VARCHAR(50))) " + 
"  inner join nota_fiscal nfe6 on infe6.nf_item = nfe6.n_nf " + 
"  inner join pedidos_nf pnf6 on nfe6.n_nf = pnf6.nf_pedido_nf " + 
"    inner join pedidos_venda pv6 on pnf6.n_pedido_nf = pv6.cod_ped_venda and met6.COD_VENDEDOR_MPV = pv6.cod_vendedor_ped_venda " + 
"     where nfe6.data_emissao_nf >= '" + primeiro_dia_mes.ToShortDateString().Replace("/",".") +
"' and nfe6.data_emissao_nf <= '" + ultimo_dia_mes.ToShortDateString().Replace("/", ".") + "' " + 
"      and pv6.cod_vendedor_ped_venda like '" + vendedor + "' and (infe6.cfop_item like '_1__' or infe6.cfop_item like '_4__')and " + 
"      nfe6.status_nfe like '%Autorizada%' " + 
"       and prod6.CNPJ_FORNECEDOR_PRODUTO like '" + fornecedor + "' ) AS POSITIVADOS_MES " + 
" FROM CLIENTES cli " + 
" INNER JOIN VENDEDORES_CLIENTE vcli on cli.COD_CLIENTE = vcli.COD_CLIENTE_VC " + 
" WHERE cli.DIA_VISITA_CLIENTE LIKE '" + numero_dia_semana + "__' AND vcli.COD_VENDEDOR_VC LIKE '" + vendedor + "'";
                select.Connection = fbConnection1;
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                dtVisitas.Clear();
                datSelect.Fill(dtVisitas);
                double porc = 0;
                foreach (DataRow dr in dtVisitas.Rows)
                {
                    try
                    {
                        porc = (Convert.ToDouble(dr["POSITIVADOS_DIA"].ToString()) / 
                            Convert.ToDouble(dr["VISITAS_DIA"].ToString())) * 100;
                    }
                    catch { }
                }

                dtVisitas.TableName = "VISITAS";
                dtVisitas.WriteXml(@"c:\\evolucao\\xml\visitas.xml");
                fbConnection1.Close();
                dgvVisitas.DataSource = dtVisitas;
                dgvVisitas.Rows[0].Cells["col_porc_visitas"].Value = porc.ToString("n2");

             }
            catch(Exception a)
             {
                fbConnection1.Close();
            }

        }

        private string buscar_numero_dia_semana(DateTime dia_anterior)
        {
            string dia_semana = "";
            DateTime _dia_semana = dia_anterior;
            if (_dia_semana.DayOfWeek == DayOfWeek.Sunday)
                dia_semana = "1";
            if (_dia_semana.DayOfWeek == DayOfWeek.Monday)
                dia_semana = "2";
            if (_dia_semana.DayOfWeek == DayOfWeek.Tuesday)
                dia_semana = "3";
            if (_dia_semana.DayOfWeek == DayOfWeek.Wednesday)
                dia_semana = "4";
            if (_dia_semana.DayOfWeek == DayOfWeek.Thursday)
                dia_semana = "5";
            if (_dia_semana.DayOfWeek == DayOfWeek.Friday)
                dia_semana = "6";
            if (_dia_semana.DayOfWeek == DayOfWeek.Saturday)
                dia_semana = "7";
            return dia_semana;
        }

        private void preencher_financeiro()
        {
            try
            {
                DateTime primeiro_dia_mes = Convert.ToDateTime("01/" + Convert.ToDateTime(dt_hoje.Text).Month.ToString() + "/" + Convert.ToDateTime(dt_hoje.Text).Year.ToString());
                DateTime ultimo_dia_mes = Convert.ToDateTime("01/" + Convert.ToDateTime(dt_hoje.Text).AddMonths(1).Month.ToString() + "/" + Convert.ToDateTime(dt_hoje.Text).AddMonths(1).Year.ToString()).AddDays(-1);

                DateTime dia_anterior = buscar_dia_anterior(Convert.ToDateTime(dt_hoje.Text));

                string vendedor = "%";
                if (tb_cod_vendedor.Text != "" && cb_vendedor.Checked)
                    vendedor = tb_cod_vendedor.Text;


                string fornecedor = "%";
                if (tb_cod_fornecedor.Text != "" && cb_fornecedor.Checked)
                    fornecedor = tb_cod_fornecedor.Text;


                FbCommand select = new FbCommand();
                select.CommandText = "select DISTINCT('0'), " + 
/*PGTOS DIA ANTERIOR*/
                "(SELECT SUM(cr1.VALOR_CR) FROM CONTAS_A_RECEBER cr1 " +
                "where cr1.data_prevista_cr = '" + dia_anterior.ToShortDateString().Replace("/",".") + 
                "' and cr1.recebido_cr = '1') as PGTO_DIA_ANTERIOR, " + 
/*ATRASADOS*/
                "(SELECT SUM(cr2.VALOR_CR) FROM CONTAS_A_RECEBER cr2 " + 
                "where cr2.data_prevista_cr < '" + Convert.ToDateTime(dt_hoje.Text).ToShortDateString().Replace("/",".") + 
                "' and (cr2.recebido_cr = '0' or cr2.recebido_cr is null) ) as ATRASADOS, " + 
/*A RECEBER NO DIA*/
                "(SELECT SUM(cr3.VALOR_CR) FROM CONTAS_A_RECEBER cr3 " + 
                "where cr3.data_prevista_cr = '" + Convert.ToDateTime(dt_hoje.Text).ToShortDateString().Replace("/",".") + 
                "' and (cr3.recebido_cr = '0' or cr3.recebido_cr is null)) as A_RECEBER_NO_DIA, " +
/*A RECEBER TOTAL*/
                "(SELECT SUM(cr4.VALOR_CR) FROM CONTAS_A_RECEBER cr4 " + 
                "where (cr4.recebido_cr = '0' or cr4.recebido_cr is null)) as A_RECEBER_TOTAL, " +
 /*VALOR ESTOQUE*/
                "(SELECT SUM(prod.valor_promocao_produto * prod.estoque_atual_produto) FROM PRODUTOS prod " + 
                "where prod.status_produto = '1') as VALOR_ESTOQUE " + 
                "from contas_a_receber cr";

                select.Connection = fbConnection1;
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                dtFinanceiro.Clear();
                datSelect.Fill(dtFinanceiro);
                dtFinanceiro.TableName = "FINANCEIRO";
                dtFinanceiro.WriteXml(@"c:\\evolucao\\xml\financeiro.xml");
                fbConnection1.Close();
                dgvFinanceiro.DataSource = dtFinanceiro;
            }
            catch (Exception a)
            {
                fbConnection1.Close();
            }
        }

        private void preencher_parametros()
        {
            int dias_uteis, dias_mes, dias_restantes, dias_decorridos;
            double velocidade;
            string dia_semana = "";
            preencher_dias(out dias_uteis, out dias_mes, out dias_restantes, out dias_decorridos, out velocidade, out dia_semana);
            tb_dias_uteis.Text = dias_uteis.ToString();
            tb_dias_decorridos.Text = dias_decorridos.ToString();
            tb_dias_restantes.Text = dias_restantes.ToString();
            tb_dias_mes.Text = dias_mes.ToString();
            tb_velocidade.Text = velocidade.ToString("n2") + "%";
            tb_hoje.Text = dia_semana;
           
        }

        private void preencher_dias(out int dias_uteis, out int dias_mes, out int dias_restantes, out int dias_decorridos, out double velocidade, out string dia_semana)
        {
            dias_uteis = 0; dias_mes = 0; dias_restantes = 0; dias_decorridos = 0; velocidade = 0; dia_semana = "";
            DateTime ultimo_dia_mes = new DateTime();
            for (DateTime dia_atual = Convert.ToDateTime("01/" + Convert.ToDateTime(dt_hoje.Text).Month.ToString() + "/"+ Convert.ToDateTime(dt_hoje.Text).Year.ToString());
                dia_atual < Convert.ToDateTime("01/" + Convert.ToDateTime(dt_hoje.Text).AddMonths(1).Month.ToString() + "/" + Convert.ToDateTime(dt_hoje.Text).AddMonths(1).Year.ToString());
                dia_atual = dia_atual.AddDays(1))
            {
                if (dia_atual.DayOfWeek != DayOfWeek.Sunday && dia_atual.DayOfWeek != DayOfWeek.Saturday)
                {
                    dias_uteis++;
                    if (dia_atual <= Convert.ToDateTime(dt_hoje.Text))
                        dias_decorridos++;

                }
                dias_mes++;
                ultimo_dia_mes = dia_atual;
                
               

            }
            if (tb_dias_uteis.Text != "")
                dias_uteis = Convert.ToInt16(tb_dias_uteis.Text);

            if (tb_dias_decorridos.Text != "")
                dias_decorridos = Convert.ToInt16(tb_dias_decorridos.Text);

            dias_restantes = dias_uteis - dias_decorridos;
            velocidade = (Convert.ToDouble(dias_decorridos) /Convert.ToDouble(dias_uteis)) * 100;

            DateTime _dia_semana = Convert.ToDateTime(dt_hoje.Text);
            if (_dia_semana.DayOfWeek == DayOfWeek.Sunday)
                dia_semana = "Domingo";
            if (_dia_semana.DayOfWeek == DayOfWeek.Monday)
                dia_semana = "Segunda";
            if (_dia_semana.DayOfWeek == DayOfWeek.Tuesday)
                dia_semana = "Terça";
            if (_dia_semana.DayOfWeek == DayOfWeek.Wednesday)
                dia_semana = "Quarta";
            if (_dia_semana.DayOfWeek == DayOfWeek.Thursday)
                dia_semana = "Quinta";
            if (_dia_semana.DayOfWeek == DayOfWeek.Friday)
                dia_semana = "Sexta";
            if (_dia_semana.DayOfWeek == DayOfWeek.Saturday)
                dia_semana = "Sábado";


        }

        private void detectar_dados_empresa(out string razao_social_empresa, out string nome_fantasia_empresa, out string cnpj_empresa, out string ie_empresa, out string im_empresa, out string cnae_empresa, out string endereco_empresa, out string n_endereco_empresa,
                  out string complemento_empresa, out string bairro_empresa, out string cidade_empresa, out string estado_empresa, out string cep_empresa, out string telefone_empresa, out string cod_cidade_empresa, out string pais_empresa,
                  out string cod_pais_empresa, out string licenca_dll_nfe_empresa, out string nome_certificado_nfe_empresa, out string assunto_nfe_email_empresa, out string smtp_nfe_empresa, out string email_nfe_empresa,
                  out string senha_email_nfe_empresa, out string logotipo_empresa, out string proxy_empresa, out string usuario_proxy_empresa, out string senha_proxy_empresa,
          out string crt_empresa, out string portaEmailEmpresa, out string sslEmpresa, out string serie_empresa, out string boleto_pedido_empresa, out string saida_estoque_pedido_empresa, out string cod_forn_empresa)
        {
            razao_social_empresa = ""; nome_fantasia_empresa = ""; cnpj_empresa = ""; ie_empresa = ""; im_empresa = ""; cnae_empresa = ""; endereco_empresa = ""; n_endereco_empresa = "";
            complemento_empresa = ""; bairro_empresa = ""; cidade_empresa = ""; estado_empresa = ""; cep_empresa = ""; telefone_empresa = ""; cod_cidade_empresa = ""; pais_empresa = "";
            cod_pais_empresa = ""; licenca_dll_nfe_empresa = ""; nome_certificado_nfe_empresa = ""; assunto_nfe_email_empresa = ""; smtp_nfe_empresa = ""; email_nfe_empresa = "";
            senha_email_nfe_empresa = ""; logotipo_empresa = ""; proxy_empresa = ""; usuario_proxy_empresa = ""; senha_proxy_empresa = ""; crt_empresa = ""; portaEmailEmpresa = "";
            sslEmpresa = ""; serie_empresa = ""; boleto_pedido_empresa = ""; saida_estoque_pedido_empresa = ""; cod_forn_empresa = "";
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
                        saida_estoque_pedido_empresa = dr["SAIDA_ESTOQUE_PEDIDO_EMPRESA"].ToString();
                    }
                    catch { }
                    try
                    {
                        cod_forn_empresa = dr["COD_FORN_EMPRESA"].ToString();
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

        //empresa
        string razao_social_empresa = "", nome_fantasia_empresa = "", cnpj_empresa = "", ie_empresa = "", im_empresa = "", cnae_empresa = "", endereco_empresa = "", n_endereco_empresa = "",
           complemento_empresa = "", bairro_empresa = "", cidade_empresa = "", estado_empresa = "", cep_empresa = "", telefone_empresa = "", cod_cidade_empresa = "", pais_empresa = "",
           cod_pais_empresa = "", licenca_dll_nfe_empresa = "", nome_certificado_nfe_empresa = "", assunto_nfe_email_empresa = "", smtp_nfe_empresa = "", email_nfe_empresa = "",
           senha_email_nfe_empresa = "", logotipo_empresa = "", proxy_empresa = "", usuario_proxy_empresa = "", senha_proxy_empresa = "", crt_empresa = "", portaEmailEmpresa = "",
           sslEmpresa = "", serie_empresa = "", boleto_pedido_empresa = "", saida_estoque_pedido_empresa = "", cod_forn_empresa = "";

        private void form_painel_vendas_Load(object sender, EventArgs e)
        {
            detectar_dados_empresa(out razao_social_empresa, out nome_fantasia_empresa, out cnpj_empresa, out ie_empresa, out im_empresa, out cnae_empresa, out endereco_empresa, out n_endereco_empresa,
       out complemento_empresa, out bairro_empresa, out cidade_empresa, out estado_empresa, out cep_empresa, out telefone_empresa, out cod_cidade_empresa, out pais_empresa,
       out cod_pais_empresa, out licenca_dll_nfe_empresa, out nome_certificado_nfe_empresa, out assunto_nfe_email_empresa, out smtp_nfe_empresa, out email_nfe_empresa,
       out senha_email_nfe_empresa, out logotipo_empresa, out proxy_empresa, out usuario_proxy_empresa, out senha_proxy_empresa, out crt_empresa, out portaEmailEmpresa, out sslEmpresa,
out serie_empresa, out boleto_pedido_empresa, out saida_estoque_pedido_empresa, out cod_forn_empresa);
        }

        private void preencher_metas_familia()
        {
            try
            {
                DateTime primeiro_dia_mes = Convert.ToDateTime("01/" + Convert.ToDateTime(dt_hoje.Text).Month.ToString() + "/" + Convert.ToDateTime(dt_hoje.Text).Year.ToString());
                DateTime ultimo_dia_mes = Convert.ToDateTime("01/" + Convert.ToDateTime(dt_hoje.Text).AddMonths(1).Month.ToString() + "/" + Convert.ToDateTime(dt_hoje.Text).AddMonths(1).Year.ToString()).AddDays(-1);

                DateTime dia_anterior = buscar_dia_anterior(Convert.ToDateTime(dt_hoje.Text));

                string vendedor = "%";
                if (tb_cod_vendedor.Text != "" && cb_vendedor.Checked)
                    vendedor = tb_cod_vendedor.Text;

                string fornecedor = "%";
                if (tb_cod_fornecedor.Text != "" && cb_fornecedor.Checked)
                    fornecedor = tb_cod_fornecedor.Text;


                FbCommand select = new FbCommand();
                select.CommandText =
"	select met.familia_mpv,	" +
                    /*METAS VALOR 1*/
"	(select sum(met1.meta_valor_mpv) 	" +
"	from metas_produto_vendedor met1	" +
"	where met1.familia_mpv = met.familia_mpv	" +
"	and met1.cod_vendedor_mpv like '" + vendedor + "') as META_VALOR,	" +
                    /*SOMA DAS VENDAS*/
"	sum(infe.preco_total_item) as VALOR_TOTAL,	" +
                    /*SALDO DIA 2*/
"	(select sum(infe2.preco_total_item)	" +
"	from metas_produto_vendedor met2	" +
"	inner join produtos prod2 on  met2.familia_mpv = prod2.NOME_FAMILIA_PRODUTO	" +
"	inner join itens_nota infe2 on (CAST(prod2.cod_produto AS VARCHAR(50)) = CAST(infe2.cod_item AS VARCHAR(50))  " +
"   or CAST(prod2.COD_FORNECEDOR_PRODUTO AS VARCHAR(50)) = CAST(infe2.cod_item AS VARCHAR(50)))	" +
"	inner join nota_fiscal nfe2 on infe2.nf_item = nfe2.n_nf	" +
"	inner join pedidos_nf pnf2 on nfe2.n_nf = pnf2.nf_pedido_nf	" +
"	inner join pedidos_venda pv2 on pnf2.n_pedido_nf = pv2.cod_ped_venda and met2.COD_VENDEDOR_MPV = pv2.cod_vendedor_ped_venda	" +
"	where nfe2.data_emissao_nf >= '" + Convert.ToDateTime(dt_hoje.Text).ToShortDateString().Replace("/", ".") + "' and nfe2.data_emissao_nf <= '" +
Convert.ToDateTime(dt_hoje.Text).ToShortDateString().Replace("/", ".") + "'	" +
"	and pv2.cod_vendedor_ped_venda like '" + vendedor + "' and (infe2.cfop_item like '_1__' or infe2.cfop_item like '_4__') and nfe2.status_nfe like '%Autorizada%'	" +
"   and prod2.CNPJ_FORNECEDOR_PRODUTO like '" + fornecedor + "' " +
"	AND met2.familia_mpv = met.familia_mpv) as SALDO_DIA,	" +

/*PEDIDO PARADO 3*/
"	(select sum(ipv3.valor_total_prod_item_venda)	" +
"	from metas_produto_vendedor met3	" +
"	inner join produtos prod3 on  met3.familia_mpv = prod3.NOME_FAMILIA_PRODUTO	" +
"	inner join pedidos_venda pv3 on met3.COD_VENDEDOR_MPV = pv3.cod_vendedor_ped_venda	" +
"	inner join itens_pedido_venda ipv3 on (cast(pv3.cod_ped_venda as varchar(50)) = cast(ipv3.cod_pedido_item_venda as varchar(50)) AND cast(prod3.cod_produto as varchar(50)) = cast(ipv3.cod_prod_item_venda as varchar(50)))	" +
"	where (pv3.nf_ped_venda is null or pv3.nf_ped_venda = '0')	" +
"	and pv3.cod_vendedor_ped_venda like '" + vendedor + "'	" +
"   and prod3.CNPJ_FORNECEDOR_PRODUTO like '" + fornecedor + "' " +
"	AND met3.familia_mpv = met.familia_mpv) as PEDIDO_PARADO,	" +
                    /*METAS VOLUME 4*/
"	(select sum(met4.meta_fisica_mpv)	" +
"	from metas_produto_vendedor met4	" +
"	where met4.familia_mpv = met.familia_mpv               	" +
"	and met4.cod_vendedor_mpv like '" + vendedor + "') as META_FISICA,	" +
"	sum(infe.qtde_item) as QTDE_TOTAL,	" +
                    /*METAS POSITIVAÇÃO 5*/
"	(select sum(met5.meta_positivacao_mpv)	" +
"	from metas_produto_vendedor met5	" +
"	where met5.familia_mpv = met.familia_mpv	" +
"	and met5.cod_vendedor_mpv like '" + vendedor + "') as META_POSITIVACAO,	" +
                    /*POSITIVACAO 6*/
"	(select COUNT(DISTINCT(nfe6.cnpj_cliente_forn))	" +
"	from metas_produto_vendedor met6	" +
"	inner join produtos prod6 on  met6.familia_mpv = prod6.NOME_FAMILIA_PRODUTO	" +
"	inner join itens_nota infe6 on (CAST(prod6.cod_produto AS VARCHAR(50)) = CAST(infe6.cod_item AS VARCHAR(50))  or	" +
"	CAST(prod6.COD_FORNECEDOR_PRODUTO AS VARCHAR(50)) = CAST(infe6.cod_item AS VARCHAR(50)))	" +
"	inner join nota_fiscal nfe6 on infe6.nf_item = nfe6.n_nf	" +
"	inner join pedidos_nf pnf6 on nfe6.n_nf = pnf6.nf_pedido_nf	" +
"	inner join pedidos_venda pv6 on pnf6.n_pedido_nf = pv6.cod_ped_venda and met6.COD_VENDEDOR_MPV = pv6.cod_vendedor_ped_venda	" +
"	where nfe6.data_emissao_nf >= '" + primeiro_dia_mes.ToShortDateString().Replace("/", ".") + "' and nfe6.data_emissao_nf <= '" +
Convert.ToDateTime(dt_hoje.Text).ToShortDateString().Replace("/", ".") + "'	" +
"	and pv6.cod_vendedor_ped_venda like '" + vendedor + "' and (infe6.cfop_item like '_1__' or infe6.cfop_item like '_4__')and nfe6.status_nfe like '%Autorizada%'	" +
"   and prod6.CNPJ_FORNECEDOR_PRODUTO like '" + fornecedor + "' " +
"	AND met6.familia_mpv = met.familia_mpv) as POSITIVADOS,	" +
                    /*VENDAS DIA ANTERIOR 7*/
"	(select sum(infe7.preco_total_item)	" +
"	from metas_produto_vendedor met7	" +
"	inner join produtos prod7 on  met7.familia_mpv = prod7.NOME_FAMILIA_PRODUTO	" +
"	inner join itens_nota infe7 on (CAST(prod7.cod_produto AS VARCHAR(50)) = CAST(infe7.cod_item AS VARCHAR(50))  " +
"   or CAST(prod7.COD_FORNECEDOR_PRODUTO AS VARCHAR(50)) = CAST(infe7.cod_item AS VARCHAR(50)))	" +
"	inner join nota_fiscal nfe7 on infe7.nf_item = nfe7.n_nf	" +
"	inner join pedidos_nf pnf7 on nfe7.n_nf = pnf7.nf_pedido_nf	" +
"	inner join pedidos_venda pv7 on pnf7.n_pedido_nf = pv7.cod_ped_venda and met7.COD_VENDEDOR_MPV = pv7.cod_vendedor_ped_venda	" +
"	where nfe7.data_emissao_nf >= '" + dia_anterior.ToShortDateString().Replace("/", ".") +
"' and nfe7.data_emissao_nf <= '" + dia_anterior.ToShortDateString().Replace("/", ".") + "'	" +
"	and pv7.cod_vendedor_ped_venda like '" + vendedor + "' and (infe7.cfop_item like '_1__' or infe7.cfop_item like '_4__') and nfe7.status_nfe like '%Autorizada%'	" +
"   and prod7.CNPJ_FORNECEDOR_PRODUTO like '" + fornecedor + "' " +
"	AND met7.familia_mpv = met.familia_mpv) as DIA_ANTERIOR	" +
                    /*GERAL 0*/
"	from metas_produto_vendedor met	" +
"	inner join produtos prod on  met.familia_mpv = prod.NOME_FAMILIA_PRODUTO	" +
"	inner join itens_nota infe on (CAST(prod.cod_produto AS VARCHAR(50)) = CAST(infe.cod_item AS VARCHAR(50))  or CAST(prod.COD_FORNECEDOR_PRODUTO AS VARCHAR(50)) = CAST(infe.cod_item AS VARCHAR(50)))	" +
"	inner join nota_fiscal nfe on infe.nf_item = nfe.n_nf	" +
"	inner join pedidos_nf pnf on nfe.n_nf = pnf.nf_pedido_nf	" +
"	inner join pedidos_venda pv on pnf.n_pedido_nf = pv.cod_ped_venda and met.COD_VENDEDOR_MPV = pv.cod_vendedor_ped_venda	" +
"	where nfe.data_emissao_nf >= '" + primeiro_dia_mes.ToShortDateString().Replace("/", ".") + "' and nfe.data_emissao_nf <= '" + Convert.ToDateTime(dt_hoje.Text).ToShortDateString().Replace("/", ".") + "'	" +
"	and pv.cod_vendedor_ped_venda like '" + vendedor + "' and (infe.cfop_item like '_1__' or infe.cfop_item like '_4__') " +
"   and prod.CNPJ_FORNECEDOR_PRODUTO like '" + fornecedor + "' " +
"   and nfe.status_nfe like '%Autorizada%'	" +
"	group by met.familia_mpv	";

                select.Connection = fbConnection1;
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                dtMetas_familia.Clear();
                datSelect.Fill(dtMetas_familia);
               // DataRow linha_soma = buscar_somatorio(dtMetas_familia);
               // dtMetas_familia.Rows.Add(linha_soma);
                fbConnection1.Close();
                dtMetas_familia.TableName = "METAS_FAMILIA";
                dtMetas_familia.WriteXml(@"c:\\evolucao\\xml\metas_familia.xml");
                dgvMetas_familia.DataSource = dtMetas_familia;
                preencher_porc_metas();
                
            }
            catch { fbConnection1.Close(); }
            
        }

        private void preencher_metas_vendedor()
        {
            try
            {
                DateTime primeiro_dia_mes = Convert.ToDateTime("01/" + Convert.ToDateTime(dt_hoje.Text).Month.ToString() + "/" + Convert.ToDateTime(dt_hoje.Text).Year.ToString());
                DateTime ultimo_dia_mes = Convert.ToDateTime("01/" + Convert.ToDateTime(dt_hoje.Text).AddMonths(1).Month.ToString() + "/" + Convert.ToDateTime(dt_hoje.Text).AddMonths(1).Year.ToString()).AddDays(-1);

                DateTime dia_anterior = buscar_dia_anterior(Convert.ToDateTime(dt_hoje.Text));
                string vendedor = "%";
                if (tb_cod_vendedor.Text != "")
                    vendedor = tb_cod_vendedor.Text;

                string fornecedor = "%";
                if (tb_cod_fornecedor.Text != "" && cb_fornecedor.Checked)
                    fornecedor = tb_cod_fornecedor.Text;

                string _select_meta_valor = "	(select sum(met1.meta_valor_mpv) " +
    "	from metas_produto_vendedor met1	" +
    "	where met1.COD_VENDEDOR_MPV = met.COD_VENDEDOR_MPV	" +
    "	and met1.cod_vendedor_mpv like '" + vendedor + "') as META_VALOR,	";
                string _select_meta_positivacao = "	(select sum(met5.meta_positivacao_mpv)	" +
"	from metas_produto_vendedor met5	" +
"	where met5.COD_VENDEDOR_MPV = met.COD_VENDEDOR_MPV	" +
"	and met5.cod_vendedor_mpv like '" + vendedor + "') as META_POSITIVACAO,	";

                if (razao_social_empresa.Contains("DISTRI SELL"))
                { //META POR FORNECEDOR
                    string valor_meta_positivacao = "";

                    _select_meta_valor = "(select sum(met1.meta_valor_mfv) " +
    "	from metas_fornecedor_vendedor met1	" +
    "	where met1.COD_VENDEDOR_MFV = met.COD_VENDEDOR_MPV	" +
    "	and met1.cod_vendedor_mfv like '" + vendedor + "' AND met1.CNPJ_FORN_MFV like '" + fornecedor + "') as META_VALOR, ";

                    _select_meta_positivacao = "(select sum(met5.meta_positivacao_mfv) " +
    "	from metas_fornecedor_vendedor met5	" +
    "	where met5.COD_VENDEDOR_MFV = met.COD_VENDEDOR_MPV	" +
    "	and met5.cod_vendedor_mfv like '" + vendedor + "' AND met5.CNPJ_FORN_MFV like '" + fornecedor + "') as META_POSITIVACAO, ";
                }
                /* DIRETO PELA META_VENDEDOR
                if (razao_social_empresa.Contains("DISTRI SELL"))
                {
                    string valor_meta_positivacao = "";
                    string valor_meta = buscar_valor_meta(vendedor, out valor_meta_positivacao);
                    _select_meta_valor = "(select DISTINCT(vend1.META_VALOR_VENDEDOR) " +
    "	from VENDEDORES vend1	" +
    "   INNER JOIN metas_produto_vendedor met1 on met1.COD_VENDEDOR_MPV = vend1.COD_VENDEDOR " + 
    "	where met1.COD_VENDEDOR_MPV = met.COD_VENDEDOR_MPV	" +
    "	and met1.cod_vendedor_mpv like '" + vendedor + "') as META_VALOR, ";

                    _select_meta_positivacao = "(select DISTINCT(vend1.META_POSITIVACAO_VENDEDOR) " +
    "	from VENDEDORES vend1	" +
    "   INNER JOIN metas_produto_vendedor met1 on met1.COD_VENDEDOR_MPV = vend1.COD_VENDEDOR " +
    "	where met1.COD_VENDEDOR_MPV = met.COD_VENDEDOR_MPV	" +
    "	and met1.cod_vendedor_mpv like '" + vendedor + "') as META_POSITIVACAO, ";
                }
               */
                FbCommand select = new FbCommand();
                select.CommandText =
                   "	select vend.NOME_VENDEDOR,	met.COD_VENDEDOR_MPV, " + _select_meta_valor + 
                    /*SOMA DAS VENDAS*/
    "	sum(infe.preco_total_item) as VALOR_TOTAL,	" + 
                    /*TROCAS*/
    "	(select sum(infe8.preco_total_item)	" +
    "	from metas_produto_vendedor met8	" +
    "	inner join produtos prod8 on  met8.familia_mpv = prod8.NOME_FAMILIA_PRODUTO	" +
    "	inner join itens_nota infe8 on (CAST(prod8.cod_produto AS VARCHAR(50)) = CAST(infe8.cod_item AS VARCHAR(50))  " +
    "   or CAST(prod8.COD_FORNECEDOR_PRODUTO AS VARCHAR(50)) = CAST(infe8.cod_item AS VARCHAR(50)))	" +
    "	inner join nota_fiscal nfe8 on infe8.nf_item = nfe8.n_nf	" +
    "	inner join pedidos_nf pnf8 on nfe8.n_nf = pnf8.nf_pedido_nf	" +
    "	inner join pedidos_venda pv8 on pnf8.n_pedido_nf = pv8.cod_ped_venda and met8.COD_VENDEDOR_MPV = pv8.cod_vendedor_ped_venda	" +
    "	where nfe8.data_emissao_nf >= '" + primeiro_dia_mes.ToShortDateString().Replace("/", ".") + "' and nfe8.data_emissao_nf <= '" +
    Convert.ToDateTime(dt_hoje.Text).ToShortDateString().Replace("/", ".") + "'	" +
    "	and pv8.cod_vendedor_ped_venda like '" + vendedor + "' and (infe8.cfop_item like '_9__') and nfe8.status_nfe like '%Autorizada%'	" +
    "   and prod8.CNPJ_FORNECEDOR_PRODUTO like '" + fornecedor + "' " +
    "	AND met8.COD_VENDEDOR_MPV = met.COD_VENDEDOR_MPV) as TROCAS,	" +
                    /*VENDAS_VIGOR*/
    "	(select sum(infe9.preco_total_item)	" +
    "	from metas_produto_vendedor met9	" +
    "	inner join produtos prod9 on  met9.familia_mpv = prod9.NOME_FAMILIA_PRODUTO	" +
    "	inner join itens_nota infe9 on (CAST(prod9.cod_produto AS VARCHAR(50)) = CAST(infe9.cod_item AS VARCHAR(50))  " +
    "   or CAST(prod9.COD_FORNECEDOR_PRODUTO AS VARCHAR(50)) = CAST(infe9.cod_item AS VARCHAR(50)))	" +
    "	inner join nota_fiscal nfe9 on infe9.nf_item = nfe9.n_nf	" +
    "	inner join pedidos_nf pnf9 on nfe9.n_nf = pnf9.nf_pedido_nf	" +
    "	inner join pedidos_venda pv9 on pnf9.n_pedido_nf = pv9.cod_ped_venda and met9.COD_VENDEDOR_MPV = pv9.cod_vendedor_ped_venda	" +
    "	where nfe9.data_emissao_nf >= '" + primeiro_dia_mes.ToShortDateString().Replace("/", ".") + "' and nfe9.data_emissao_nf <= '" +
    Convert.ToDateTime(dt_hoje.Text).ToShortDateString().Replace("/", ".") + "'	" +
    "	and pv9.cod_vendedor_ped_venda like '" + vendedor + "' and (infe9.cfop_item like '_1__' or infe9.cfop_item like '_4__') and nfe9.status_nfe like '%Autorizada%'	" +
    "   and prod9.CNPJ_FORNECEDOR_PRODUTO like '" + fornecedor + "' " +
    "	AND prod9.NOME_FORNECEDOR_PRODUTO LIKE '%VIGOR%'	" +
    "	AND met9.COD_VENDEDOR_MPV = met.COD_VENDEDOR_MPV) as VENDAS_VIGOR,	" +
                    /*SALDO DIA 2*/
    "	(select sum(infe2.preco_total_item)	" +
    "	from metas_produto_vendedor met2	" +
    "	inner join produtos prod2 on  met2.familia_mpv = prod2.NOME_FAMILIA_PRODUTO	" +
    "	inner join itens_nota infe2 on (CAST(prod2.cod_produto AS VARCHAR(50)) = CAST(infe2.cod_item AS VARCHAR(50))  " +
    "   or CAST(prod2.COD_FORNECEDOR_PRODUTO AS VARCHAR(50)) = CAST(infe2.cod_item AS VARCHAR(50)))	" +
    "	inner join nota_fiscal nfe2 on infe2.nf_item = nfe2.n_nf	" +
    "	inner join pedidos_nf pnf2 on nfe2.n_nf = pnf2.nf_pedido_nf	" +
    "	inner join pedidos_venda pv2 on pnf2.n_pedido_nf = pv2.cod_ped_venda and met2.COD_VENDEDOR_MPV = pv2.cod_vendedor_ped_venda	" +
    "	where nfe2.data_emissao_nf >= '" + Convert.ToDateTime(dt_hoje.Text).ToShortDateString().Replace("/", ".") + "' and nfe2.data_emissao_nf <= '" +
    Convert.ToDateTime(dt_hoje.Text).ToShortDateString().Replace("/", ".") + "'	" +
    "	and pv2.cod_vendedor_ped_venda like '" + vendedor + "' and (infe2.cfop_item like '_1__' or infe2.cfop_item like '_4__') and nfe2.status_nfe like '%Autorizada%'	" +
    "   and prod2.CNPJ_FORNECEDOR_PRODUTO like '" + fornecedor + "' " +
    "	AND met2.COD_VENDEDOR_MPV = met.COD_VENDEDOR_MPV) as SALDO_DIA,	" +

    /*PEDIDO PARADO 3*/
    "	(select sum(ipv3.valor_total_prod_item_venda)	" +
    "	from metas_produto_vendedor met3	" +
    "	inner join produtos prod3 on  met3.familia_mpv = prod3.NOME_FAMILIA_PRODUTO	" +
    "	inner join pedidos_venda pv3 on met3.COD_VENDEDOR_MPV = pv3.cod_vendedor_ped_venda	" +
    "	inner join itens_pedido_venda ipv3 on (cast(pv3.cod_ped_venda as varchar(50)) = cast(ipv3.cod_pedido_item_venda as varchar(50)) AND cast(prod3.cod_produto as varchar(50)) = cast(ipv3.cod_prod_item_venda as varchar(50)))	" +
    "	where (pv3.nf_ped_venda is null or pv3.nf_ped_venda = '0')	" +
    "	and pv3.cod_vendedor_ped_venda like '" + vendedor + "'	" +
    "   and prod3.CNPJ_FORNECEDOR_PRODUTO like '" + fornecedor + "' " +
    "	AND met3.COD_VENDEDOR_MPV = met.COD_VENDEDOR_MPV) as PEDIDO_PARADO,	" +
                    /*METAS VOLUME 4*/
    "	(select sum(met4.meta_fisica_mpv)	" +
    "	from metas_produto_vendedor met4	" +
    "	where met4.COD_VENDEDOR_MPV = met.COD_VENDEDOR_MPV               	" +

    "	and met4.cod_vendedor_mpv like '" + vendedor + "') as META_FISICA,	" +
    "	sum(infe.qtde_item) as QTDE_TOTAL,	" +
                    /*METAS POSITIVAÇÃO 5*/ 
_select_meta_positivacao + 
                /*POSITIVACAO 6*/ 
"	(select COUNT(DISTINCT(nfe6.cnpj_cliente_forn))	" +
"	from metas_produto_vendedor met6	" +
"	inner join produtos prod6 on  met6.familia_mpv = prod6.NOME_FAMILIA_PRODUTO	" +
"	inner join itens_nota infe6 on (CAST(prod6.cod_produto AS VARCHAR(50)) = CAST(infe6.cod_item AS VARCHAR(50))  or	" +
"	CAST(prod6.COD_FORNECEDOR_PRODUTO AS VARCHAR(50)) = CAST(infe6.cod_item AS VARCHAR(50)))	" +
"	inner join nota_fiscal nfe6 on infe6.nf_item = nfe6.n_nf	" +
"	inner join pedidos_nf pnf6 on nfe6.n_nf = pnf6.nf_pedido_nf	" +
"	inner join pedidos_venda pv6 on pnf6.n_pedido_nf = pv6.cod_ped_venda and met6.COD_VENDEDOR_MPV = pv6.cod_vendedor_ped_venda	" +
"	where nfe6.data_emissao_nf >= '" + primeiro_dia_mes.ToShortDateString().Replace("/", ".") + "' and nfe6.data_emissao_nf <= '" +
Convert.ToDateTime(dt_hoje.Text).ToShortDateString().Replace("/", ".") + "'	" +
"	and pv6.cod_vendedor_ped_venda like '" + vendedor + "' and (infe6.cfop_item like '_1__' or infe6.cfop_item like '_4__')and nfe6.status_nfe like '%Autorizada%'	" +
"   and prod6.CNPJ_FORNECEDOR_PRODUTO like '" + fornecedor + "' " +
"	AND met6.COD_VENDEDOR_MPV = met.COD_VENDEDOR_MPV) as POSITIVADOS,	" +
                /*VENDAS DIA ANTERIOR 7*/
    "	(select sum(infe7.preco_total_item)	" +
    "	from metas_produto_vendedor met7	" +
    "	inner join produtos prod7 on  met7.familia_mpv = prod7.NOME_FAMILIA_PRODUTO	" +
    "	inner join itens_nota infe7 on (CAST(prod7.cod_produto AS VARCHAR(50)) = CAST(infe7.cod_item AS VARCHAR(50))  " +
    "   or CAST(prod7.COD_FORNECEDOR_PRODUTO AS VARCHAR(50)) = CAST(infe7.cod_item AS VARCHAR(50)))	" +
    "	inner join nota_fiscal nfe7 on infe7.nf_item = nfe7.n_nf	" +
    "	inner join pedidos_nf pnf7 on nfe7.n_nf = pnf7.nf_pedido_nf	" +
    "	inner join pedidos_venda pv7 on pnf7.n_pedido_nf = pv7.cod_ped_venda and met7.COD_VENDEDOR_MPV = pv7.cod_vendedor_ped_venda	" +
    "	where nfe7.data_emissao_nf >= '" + dia_anterior.ToShortDateString().Replace("/", ".") +
    "' and nfe7.data_emissao_nf <= '" + dia_anterior.ToShortDateString().Replace("/", ".") + "'	" +
    "	and pv7.cod_vendedor_ped_venda like '" + vendedor + "' and (infe7.cfop_item like '_1__' or infe7.cfop_item like '_4__') and nfe7.status_nfe like '%Autorizada%'	" +
    "   and prod7.CNPJ_FORNECEDOR_PRODUTO like '" + fornecedor + "' " +
    "	AND met7.COD_VENDEDOR_MPV = met.COD_VENDEDOR_MPV) as DIA_ANTERIOR	" +
                    /*GERAL 0*/
    "	from metas_produto_vendedor met	" +
    "	inner join produtos prod on  met.familia_mpv = prod.NOME_FAMILIA_PRODUTO	" +
    "	inner join itens_nota infe on (CAST(prod.cod_produto AS VARCHAR(50)) = CAST(infe.cod_item AS VARCHAR(50))  or CAST(prod.COD_FORNECEDOR_PRODUTO AS VARCHAR(50)) = CAST(infe.cod_item AS VARCHAR(50)))	" +
    "	inner join nota_fiscal nfe on infe.nf_item = nfe.n_nf	" +
    "	inner join pedidos_nf pnf on nfe.n_nf = pnf.nf_pedido_nf	" +
    "	inner join pedidos_venda pv on pnf.n_pedido_nf = pv.cod_ped_venda and met.COD_VENDEDOR_MPV = pv.cod_vendedor_ped_venda	" +
    "   inner join vendedores vend on vend.COD_VENDEDOR = pv.cod_vendedor_ped_venda " +
    "	where nfe.data_emissao_nf >= '" + primeiro_dia_mes.ToShortDateString().Replace("/", ".") + "' and nfe.data_emissao_nf <= '" + Convert.ToDateTime(dt_hoje.Text).ToShortDateString().Replace("/", ".") + "'	" +
    "	and pv.cod_vendedor_ped_venda like '" + vendedor + "' and (infe.cfop_item like '_1__' or infe.cfop_item like '_4__') and nfe.status_nfe like '%Autorizada%'	" +
    "   and prod.CNPJ_FORNECEDOR_PRODUTO like '" + fornecedor + "' " +
    "	group by met.COD_VENDEDOR_MPV, vend.NOME_VENDEDOR	";

                select.Connection = fbConnection1;
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                dtMetas_vendedor.Clear();
                datSelect.Fill(dtMetas_vendedor);
                fbConnection1.Close();
                DataRow linha_soma = buscar_somatorio(dtMetas_vendedor);
                dtMetas_vendedor.Rows.Add(linha_soma);
                dtMetas_vendedor.TableName = "METAS_VENDEDOR";
                dtMetas_vendedor.WriteXml(@"c:\\evolucao\\xml\metas_vendedor.xml");
                dgvMetas_vendedor.DataSource = dtMetas_vendedor;
                preencher_porc_metas_vendedor();
            }
            catch { fbConnection1.Close(); }

        }

        private string buscar_valor_fornecedor(string vendedor, out string meta_positivacao)
        {
            meta_positivacao = "";
            try
            {
                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT sum(META_VALOR_VENDEDOR), sum(META_POSITIVACAO_VENDEDOR) FROM VENDEDORES WHERE COD_VENDEDOR LIKE '" + vendedor + "'";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    meta_positivacao = dr[1].ToString();
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

        private string buscar_valor_meta(string vendedor, out string meta_positivacao)
        {
            meta_positivacao = "";
            try
            {
                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT META_VALOR_VENDEDOR, META_POSITIVACAO_VENDEDOR FROM VENDEDORES WHERE COD_VENDEDOR LIKE '" + vendedor + "'";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    meta_positivacao = dr[1].ToString();
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

        private DataRow buscar_somatorio(DataTable dtSelect)
        {
            DataRow retorno = dtSelect.NewRow();
            try
            {
                try
                {
                    retorno[0] = "TOTAL";
                    for (int i = 1; i < dtSelect.Columns.Count; i++)
                    {
                        try
                        {
                            double soma = 0;
                            foreach (DataRow dr in dtSelect.Rows)
                            {
                                try
                                {
                                    soma = soma + Convert.ToDouble(dr[i].ToString());
                                }
                                catch { }
                            }
                            retorno[i] = soma;
                        }
                        catch { }
                    }
                }
                catch { }
                return retorno;
            }
            catch { return retorno; }
        }

        private void 
            preencher_vendas_clientes()
        {
            try
            {
                DateTime primeiro_dia_mes = Convert.ToDateTime("01/" + Convert.ToDateTime(dt_hoje.Text).Month.ToString() + "/" + Convert.ToDateTime(dt_hoje.Text).Year.ToString());
                DateTime ultimo_dia_mes = Convert.ToDateTime("01/" + Convert.ToDateTime(dt_hoje.Text).AddMonths(1).Month.ToString() + "/" + Convert.ToDateTime(dt_hoje.Text).AddMonths(1).Year.ToString()).AddDays(-1);

                DateTime dia_anterior = buscar_dia_anterior(Convert.ToDateTime(dt_hoje.Text));

               // string vendedor = "%";
               // if (tb_cod_vendedor.Text != "")
               //     vendedor = tb_cod_vendedor.Text;
                string vendedor = "%";
                if (tb_cod_vendedor.Text != "" && cb_vendedor.Checked)
                    vendedor = tb_cod_vendedor.Text;

                string fornecedor = "%";
                if (tb_nome_fornecedor.Text != "" && cb_fornecedor.Checked)
                    fornecedor = tb_nome_fornecedor.Text;

                //selecionando produtos faturados
                FbCommand select = new FbCommand();
                select.CommandText = 
                    /* TERMINAR URGENTE 26/09/2018 */
                    @"select cli.razao_social, cli.cnpj, cli.cidade, infe.cfop_item as cfop, nfe.data_emissao_nf as data_emissao, 
                    sum(infe.preco_total_item) as valor_total, sum(infe.qtde_item) as qtde,  
                    sum(infe.qtde_item * prod.PESO_UNIT_PRODUTO) as peso 
                    from itens_nota infe
                    inner join produtos prod on CAST(prod.COD_FORNECEDOR_PRODUTO AS VARCHAR(50)) = CAST(infe.cod_item AS VARCHAR(50))
                    inner join nota_fiscal nfe on infe.nf_item = nfe.n_nf
                    inner join pedidos_nf pnf on nfe.n_nf = pnf.nf_pedido_nf	
                    inner join pedidos_venda pv on pnf.n_pedido_nf = pv.cod_ped_venda
                    inner join vendedores vend on vend.COD_VENDEDOR = pv.cod_vendedor_ped_venda 
                    inner join clientes cli on cli.cnpj = nfe.cnpj_cliente_forn	
                    where nfe.data_emissao_nf >= '" + primeiro_dia_mes.ToShortDateString().Replace("/", ".") + @"' and nfe.data_emissao_nf <= '" + Convert.ToDateTime(dt_hoje.Text).ToShortDateString().Replace("/", ".") + @"'	
                    and pv.cod_vendedor_ped_venda like '" + vendedor + @"'
                    and prod.NOME_FORNECEDOR_PRODUTO like '" + fornecedor + @"' 
                    and nfe.status_nfe like '%Autorizada%' 
                    group by  cli.razao_social, cli.cnpj, cli.cidade, infe.cfop_item, nfe.data_emissao_nf order by 5 desc";
                select.Connection = fbConnection1;
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();

                FbCommand select1 = new FbCommand();
                select1.CommandText =
                    //selecionando pedidos em aberto
                    @"select sum(ipv4.valor_total_prod_item_venda) as valor_total, pv4.CNPJ_PED_VENDA from	" +
    "	       itens_pedido_venda ipv4	" +
    "	inner join produtos prod4 on  cast(ipv4.cod_prod_item_venda as varchar(50)) = cast(prod4.cod_produto as varchar(50))	" +
    "	inner join pedidos_venda pv4 on pv4.cod_ped_venda = ipv4.cod_pedido_item_venda	" +
    "	where (pv4.nf_ped_venda is null or pv4.nf_ped_venda = '0')	" +
   " AND (pv4.TROCA_PED_VENDA = '0' OR pv4.TROCA_PED_VENDA IS NULL) AND " + 
                "(pv4.BONIFICACAO_PED_VENDA = '0' OR pv4.BONIFICACAO_PED_VENDA IS NULL) " +
    "	and pv4.cod_vendedor_ped_venda like '" + vendedor + "'	" +
    "   and prod4.NOME_FORNECEDOR_PRODUTO like '" + fornecedor + "' " + 
    "                 group by  pv4.CNPJ_PED_VENDA";
                select1.Connection = fbConnection1;
                FbDataAdapter datSelect1 = new FbDataAdapter();
                datSelect1.SelectCommand = select1;
                DataTable dtSelect1 = new DataTable();
                datSelect1.Fill(dtSelect1);
                fbConnection1.Close();

                FbCommand select2 = new FbCommand();
                select2.CommandText =
                    //selecionando mix
                   " select count(distinct(infe3.cod_item)) as mix, nfe3.cnpj_cliente_forn	" +
    "	        from itens_nota infe3	" +
    "	       inner join produtos prod3 on prod3.COD_FORNECEDOR_PRODUTO = infe3.cod_item	" +
    "	       inner join nota_fiscal nfe3 on infe3.nf_item = nfe3.n_nf	" +
    "	       inner join pedidos_nf pnf3 on nfe3.n_nf = pnf3.nf_pedido_nf	" +
    "	       inner join pedidos_venda pv3 on pnf3.n_pedido_nf = pv3.cod_ped_venda	" +
    "	where nfe3.data_emissao_nf >= '" + primeiro_dia_mes.ToShortDateString().Replace("/", ".") + "' and nfe3.data_emissao_nf <= '" + Convert.ToDateTime(dt_hoje.Text).ToShortDateString().Replace("/", ".") + "'	" +
    "	and pv3.cod_vendedor_ped_venda like '" + vendedor + "' " +
    "   and prod3.NOME_FORNECEDOR_PRODUTO like '" + fornecedor + "' " +
    "	       and (infe3.cfop_item like '_1__' or infe3.cfop_item like '_4__') and nfe3.status_nfe like '%Autorizada%'	" + 
    "   group by nfe3.cnpj_cliente_forn ";
                select2.Connection = fbConnection1;
                FbDataAdapter datSelect2 = new FbDataAdapter();
                datSelect2.SelectCommand = select2;
                DataTable dtSelect2 = new DataTable();
                datSelect2.Fill(dtSelect2);
                fbConnection1.Close();

                DataTable dtVendas = new DataTable();
                DataColumn colunaRazaoSocial = new DataColumn(); colunaRazaoSocial.ColumnName = "RAZAO_SOCIAL"; dtVendas.Columns.Add(colunaRazaoSocial);
                DataColumn colunaCNPJ = new DataColumn(); colunaCNPJ.ColumnName = "CNPJ_CLIENTE_FORN"; dtVendas.Columns.Add(colunaCNPJ);
                DataColumn colunaCidade = new DataColumn(); colunaCidade.ColumnName = "CIDADE"; dtVendas.Columns.Add(colunaCidade);
                DataColumn colunaVendas = new DataColumn(); colunaVendas.ColumnName = "VALOR_TOTAL"; colunaVendas.DataType = System.Type.GetType("System.Double"); dtVendas.Columns.Add(colunaVendas);
                DataColumn colunaBonificado = new DataColumn(); colunaBonificado.ColumnName = "BONIFICADOS"; colunaBonificado.DataType = System.Type.GetType("System.Double"); dtVendas.Columns.Add(colunaBonificado);
                DataColumn colunaTrocas = new DataColumn(); colunaTrocas.ColumnName = "TROCAS"; colunaTrocas.DataType = System.Type.GetType("System.Double"); dtVendas.Columns.Add(colunaTrocas);
                DataColumn colunaSaldoDia = new DataColumn(); colunaSaldoDia.ColumnName = "SALDO_DIA"; colunaSaldoDia.DataType = System.Type.GetType("System.Double"); dtVendas.Columns.Add(colunaSaldoDia);
                DataColumn colunaPedidoParado = new DataColumn(); colunaPedidoParado.ColumnName = "PEDIDO_PARADO"; colunaPedidoParado.DataType = System.Type.GetType("System.Double"); dtVendas.Columns.Add(colunaPedidoParado);
                DataColumn colunaQtde = new DataColumn(); colunaQtde.ColumnName = "QTDE_TOTAL"; colunaQtde.DataType = System.Type.GetType("System.Double"); dtVendas.Columns.Add(colunaQtde);
                DataColumn colunaMix = new DataColumn(); colunaMix.ColumnName = "MIX"; colunaMix.DataType = System.Type.GetType("System.Int32"); dtVendas.Columns.Add(colunaMix);
                DataColumn colunaPeso = new DataColumn(); colunaPeso.ColumnName = "PESO"; colunaPeso.DataType = System.Type.GetType("System.Double"); dtVendas.Columns.Add(colunaPeso);

                foreach (DataRow dr in dtSelect.Rows)
                {
                    double vendas = 0;
                    foreach (DataRow dr1 in dtSelect.Select("CNPJ = '" + dr["CNPJ"].ToString() + "' AND (CFOP = '5102' OR CFOP = '5405')"))
                    {
                        try
                        {
                            vendas += Convert.ToDouble(dr1["valor_total"].ToString());
                        }
                        catch { }
                    }
                    double bonificado = 0;
                    foreach (DataRow dr1 in dtSelect.Select("CNPJ = '" + dr["CNPJ"].ToString() + "' AND (CFOP = '5910')"))
                    {
                        try
                        {
                            bonificado += Convert.ToDouble(dr1["valor_total"].ToString());
                        }
                        catch { }
                    }
                    double trocas = 0;
                    foreach (DataRow dr1 in dtSelect.Select("CNPJ = '" + dr["CNPJ"].ToString() + "' AND (CFOP = '5949')"))
                    {
                        try
                        {
                            trocas += Convert.ToDouble(dr1["valor_total"].ToString());
                        }
                        catch { }
                    }
                    double saldo_dia = 0;
                    foreach (DataRow dr1 in dtSelect.Select("CNPJ = '" + dr["CNPJ"].ToString() + "' AND (data_emissao = '" + Convert.ToDateTime(dt_hoje.Text).ToShortDateString() + "')"))
                    {
                        try
                        {
                            saldo_dia += Convert.ToDouble(dr1["valor_total"].ToString());
                        }
                        catch { }
                    }
                    double pedido_parado = 0;
                    foreach (DataRow dr1 in dtSelect1.Select("CNPJ_PED_VENDA = '" + dr["CNPJ"].ToString() + "'"))
                    {
                        try
                        {
                            pedido_parado += Convert.ToDouble(dr1["valor_total"].ToString());
                        }
                        catch { }
                    }
                    double qtde = 0;
                    foreach (DataRow dr1 in dtSelect.Select("CNPJ = '" + dr["CNPJ"].ToString() + "' AND (CFOP = '5102' OR CFOP = '5405')"))
                    {
                        try
                        {
                            qtde += Convert.ToDouble(dr1["qtde"].ToString());
                        }
                        catch { }
                    }
                    int mix = 0;
                    foreach (DataRow dr1 in dtSelect2.Select("cnpj_cliente_forn = '" + dr["CNPJ"].ToString() + "'"))
                    {
                        try
                        {
                            mix += Convert.ToInt32(dr1["mix"].ToString());
                        }
                        catch { }
                    }
                    double peso = 0;
                    foreach (DataRow dr1 in dtSelect.Select("CNPJ = '" + dr["CNPJ"].ToString() + "' AND (CFOP = '5102' OR CFOP = '5405')"))
                    {
                        try
                        {
                            peso += Convert.ToDouble(dr1["peso"].ToString());
                        }
                        catch { }
                    }
                    if (dtVendas.Select("CNPJ_CLIENTE_FORN = '" + dr[1].ToString() + "'").Length == 0)
                    {
                        dtVendas.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), vendas.ToString("n2"),
                            bonificado.ToString("n2"), trocas.ToString("n2"), saldo_dia.ToString("n2"),
                            pedido_parado.ToString("n2"), qtde.ToString("n2"), mix.ToString("n0"), peso.ToString("n2"));
                    }


                }

               // DataRow linha_soma = buscar_somatorio(dtVendas);
                //dtVendas.Rows.Add(linha_soma);
                dtVendas.TableName = "VENDAS_CLIENTE";
                dtVendas.WriteXml(@"c:\\evolucao\\xml\vendas_cliente.xml");
                fbConnection1.Close();
                dgvVendas_clientes.DataSource = dtVendas;
             //   dataGridView1.Sort(newColumn, direction);
                dgvVendas_clientes.Sort(dgvVendas_clientes.Columns["VALOR_TOTAL"], ListSortDirection.Descending);
              
                





                //FALTA NO SELECT ACIMA O PEDIDO PARADO E O MIX
                    

                    

    //CODIGO ANTIGO 26/09/2018                
    //                               "	    select " +
    //"(select clientes.razao_social from clientes where clientes.cnpj = nfe.cnpj_cliente_forn) AS RAZAO_SOCIAL, nfe.cnpj_cliente_forn AS CNPJ," +
    //"(select clientes.cidade from clientes where clientes.cnpj = nfe.cnpj_cliente_forn) AS CIDADE, " + //sum(infe.preco_total_item) AS VALOR_TOTAL,	" +
    //                /*VALOR_TOTAL */
    //    "	(select sum(infe8.preco_total_item)  	" +
    //"	        from itens_nota infe8	" +
    //"	       inner join produtos prod8 on (CAST(prod8.cod_produto AS VARCHAR(50)) = CAST(infe8.cod_item AS VARCHAR(50))	" +
    //"	       or CAST(prod8.COD_FORNECEDOR_PRODUTO AS VARCHAR(50)) = CAST(infe8.cod_item AS VARCHAR(50)))	" +
    //"	       inner join nota_fiscal nfe8 on infe8.nf_item = nfe8.n_nf	" +
    //"	       inner join pedidos_nf pnf8 on nfe8.n_nf = pnf8.nf_pedido_nf	" +
    //"	       inner join pedidos_venda pv8 on pnf8.n_pedido_nf = pv8.cod_ped_venda	" +
    //"	       inner join vendedores vend8 on vend8.COD_VENDEDOR = pv8.cod_vendedor_ped_venda	" +
    //"	       inner join clientes cli8 on cli8.cnpj = nfe8.cnpj_cliente_forn	" +
    //"	where nfe8.data_emissao_nf >= '" + primeiro_dia_mes.ToShortDateString().Replace("/", ".") + "' and nfe8.data_emissao_nf <= '" + Convert.ToDateTime(dt_hoje.Text).ToShortDateString().Replace("/", ".") + "'	" +
    //"	and pv8.cod_vendedor_ped_venda like '" + vendedor + "' " +
    //"   and prod8.NOME_FORNECEDOR_PRODUTO like '" + fornecedor + "' " +
    //"	        and (infe8.cfop_item like '_1__' or infe8.cfop_item like '_4__') and nfe8.status_nfe like '%Autorizada%'	" +
    //"	       and  nfe8.cnpj_cliente_forn = nfe.cnpj_cliente_forn	" +
    //"	       ) as VALOR_TOTAL,	" +
    //                /*BONIFICADO */
    //    "	(select sum(infe6.preco_total_item)  	" +
    //"	        from itens_nota infe6	" +
    //"	       inner join produtos prod6 on (CAST(prod6.cod_produto AS VARCHAR(50)) = CAST(infe6.cod_item AS VARCHAR(50))	" +
    //"	       or CAST(prod6.COD_FORNECEDOR_PRODUTO AS VARCHAR(50)) = CAST(infe6.cod_item AS VARCHAR(50)))	" +
    //"	       inner join nota_fiscal nfe6 on infe6.nf_item = nfe6.n_nf	" +
    //"	       inner join pedidos_nf pnf6 on nfe6.n_nf = pnf6.nf_pedido_nf	" +
    //"	       inner join pedidos_venda pv6 on pnf6.n_pedido_nf = pv6.cod_ped_venda	" +
    //"	       inner join vendedores vend6 on vend6.COD_VENDEDOR = pv6.cod_vendedor_ped_venda	" +
    //"	       inner join clientes cli6 on cli6.cnpj = nfe6.cnpj_cliente_forn	" +
    //"	where nfe6.data_emissao_nf >= '" + primeiro_dia_mes.ToShortDateString().Replace("/", ".") + "' and nfe6.data_emissao_nf <= '" + Convert.ToDateTime(dt_hoje.Text).ToShortDateString().Replace("/", ".") + "'	" +
    //"	and pv6.cod_vendedor_ped_venda like '" + vendedor + "' " +
    //"   and prod6.NOME_FORNECEDOR_PRODUTO like '" + fornecedor + "' " +
    //"	       and (infe6.cfop_item like '_910') and nfe6.status_nfe like '%Autorizada%'	" +
    //"	       and  nfe6.cnpj_cliente_forn = nfe.cnpj_cliente_forn	" +
    //"	       ) as BONIFICADOS,	" +
    //                /*TROCAS */
    //    "	(select sum(infe7.preco_total_item)  	" +
    //"	        from itens_nota infe7	" +
    //"	       inner join produtos prod7 on (CAST(prod7.cod_produto AS VARCHAR(50)) = CAST(infe7.cod_item AS VARCHAR(50))	" +
    //"	       or CAST(prod7.COD_FORNECEDOR_PRODUTO AS VARCHAR(50)) = CAST(infe7.cod_item AS VARCHAR(50)))	" +
    //"	       inner join nota_fiscal nfe7 on infe7.nf_item = nfe7.n_nf	" +
    //"	       inner join pedidos_nf pnf7 on nfe7.n_nf = pnf7.nf_pedido_nf	" +
    //"	       inner join pedidos_venda pv7 on pnf7.n_pedido_nf = pv7.cod_ped_venda	" +
    //"	       inner join vendedores vend7 on vend7.COD_VENDEDOR = pv7.cod_vendedor_ped_venda	" +
    //"	       inner join clientes cli7 on cli7.cnpj = nfe7.cnpj_cliente_forn	" +
    //"	where nfe7.data_emissao_nf >= '" + primeiro_dia_mes.ToShortDateString().Replace("/", ".") + "' and nfe7.data_emissao_nf <= '" + Convert.ToDateTime(dt_hoje.Text).ToShortDateString().Replace("/", ".") + "'	" +
    //"	and pv7.cod_vendedor_ped_venda like '" + vendedor + "' " +
    //"   and prod7.NOME_FORNECEDOR_PRODUTO like '" + fornecedor + "' " +
    //"	       and (infe7.cfop_item like '_949') and nfe7.status_nfe like '%Autorizada%'	" +
    //"	       and  nfe7.cnpj_cliente_forn = nfe.cnpj_cliente_forn	" +
    //"	       ) as TROCAS,	" +
    //                /* SALDO DIA */
    //"	(select sum(infe1.preco_total_item)  	" +
    //"	        from itens_nota infe1	" +
    //"	       inner join produtos prod1 on (CAST(prod1.cod_produto AS VARCHAR(50)) = CAST(infe1.cod_item AS VARCHAR(50))	" +
    //"	       or CAST(prod1.COD_FORNECEDOR_PRODUTO AS VARCHAR(50)) = CAST(infe1.cod_item AS VARCHAR(50)))	" +
    //"	       inner join nota_fiscal nfe1 on infe1.nf_item = nfe1.n_nf	" +
    //"	       inner join pedidos_nf pnf1 on nfe1.n_nf = pnf1.nf_pedido_nf	" +
    //"	       inner join pedidos_venda pv1 on pnf1.n_pedido_nf = pv1.cod_ped_venda	" +
    //"	       inner join vendedores vend1 on vend1.COD_VENDEDOR = pv1.cod_vendedor_ped_venda	" +
    //"	       inner join clientes cli1 on cli1.cnpj = nfe1.cnpj_cliente_forn	" +
    //"	      where nfe1.data_emissao_nf = '" + Convert.ToDateTime(dt_hoje.Text).ToShortDateString().Replace("/", ".") + "' " +
    //"	and pv1.cod_vendedor_ped_venda like '" + vendedor + "' " +
    //"   and prod1.NOME_FORNECEDOR_PRODUTO like '" + fornecedor + "' " +
    //"	       and (infe1.cfop_item like '_1__' or infe1.cfop_item like '_4__') and nfe1.status_nfe like '%Autorizada%'	" +
    //"	       and  nfe1.cnpj_cliente_forn = nfe.cnpj_cliente_forn	" +
    //"	       ) as SALDO_DIA,	" +

    //                /* PEDIDO PARADO   */
    //"	       (select sum(ipv4.valor_total_prod_item_venda) from	" +
    //"	       itens_pedido_venda ipv4	" +
    //"	inner join produtos prod4 on  cast(ipv4.cod_prod_item_venda as varchar(50)) = cast(prod4.cod_produto as varchar(50))	" +
    //"	inner join pedidos_venda pv4 on pv4.cod_ped_venda = ipv4.cod_pedido_item_venda	" +
    //"	where (pv4.nf_ped_venda is null or pv4.nf_ped_venda = '0')	" +
    //"	and pv4.cod_vendedor_ped_venda like '" + vendedor + "'	" +
    //"   and prod4.NOME_FORNECEDOR_PRODUTO like '" + fornecedor + "' " +
    //"	and pv4.cnpj_ped_venda = nfe.cnpj_cliente_forn) as PEDIDO_PARADO,	" +
    //                /* quantidade total */
    //"	    (select sum(infe2.qtde_item)	" +
    //"	        from itens_nota infe2	" +
    //"	       inner join produtos prod2 on (CAST(prod2.cod_produto AS VARCHAR(50)) = CAST(infe2.cod_item AS VARCHAR(50))	" +
    //"	       or CAST(prod2.COD_FORNECEDOR_PRODUTO AS VARCHAR(50)) = CAST(infe2.cod_item AS VARCHAR(50)))	" +
    //"	       inner join nota_fiscal nfe2 on infe2.nf_item = nfe2.n_nf	" +
    //"	       inner join pedidos_nf pnf2 on nfe2.n_nf = pnf2.nf_pedido_nf	" +
    //"	       inner join pedidos_venda pv2 on pnf2.n_pedido_nf = pv2.cod_ped_venda	" +
    //"	       inner join vendedores vend2 on vend2.COD_VENDEDOR = pv2.cod_vendedor_ped_venda	" +
    //"	       inner join clientes cli2 on cli2.cnpj = nfe2.cnpj_cliente_forn	" +
    //"	where nfe2.data_emissao_nf >= '" + primeiro_dia_mes.ToShortDateString().Replace("/", ".") + "' and nfe2.data_emissao_nf <= '" + Convert.ToDateTime(dt_hoje.Text).ToShortDateString().Replace("/", ".") + "'	" +
    //"	and pv2.cod_vendedor_ped_venda like '" + vendedor + "' " +
    //"   and prod2.NOME_FORNECEDOR_PRODUTO like '" + fornecedor + "' " +
    //"	       and (infe2.cfop_item like '_1__' or infe2.cfop_item like '_4__') and nfe2.status_nfe like '%Autorizada%'	" +
    //"	       and  nfe2.cnpj_cliente_forn = nfe.cnpj_cliente_forn	" +
    //"	       ) as QTDE_TOTAL,	" +
    //                /* produtos positivados */
    //"	  (select count(distinct(infe3.cod_item))	" +
    //"	        from itens_nota infe3	" +
    //"	       inner join produtos prod3 on (CAST(prod3.cod_produto AS VARCHAR(50)) = CAST(infe3.cod_item AS VARCHAR(50))	" +
    //"	       or CAST(prod3.COD_FORNECEDOR_PRODUTO AS VARCHAR(50)) = CAST(infe3.cod_item AS VARCHAR(50)))	" +
    //"	       inner join nota_fiscal nfe3 on infe3.nf_item = nfe3.n_nf	" +
    //"	       inner join pedidos_nf pnf3 on nfe3.n_nf = pnf3.nf_pedido_nf	" +
    //"	       inner join pedidos_venda pv3 on pnf3.n_pedido_nf = pv3.cod_ped_venda	" +
    //"	       inner join vendedores vend3 on vend3.COD_VENDEDOR = pv3.cod_vendedor_ped_venda	" +
    //"	       inner join clientes cli3 on cli3.cnpj = nfe3.cnpj_cliente_forn	" +
    //"	where nfe3.data_emissao_nf >= '" + primeiro_dia_mes.ToShortDateString().Replace("/", ".") + "' and nfe3.data_emissao_nf <= '" + Convert.ToDateTime(dt_hoje.Text).ToShortDateString().Replace("/", ".") + "'	" +
    //"	and pv3.cod_vendedor_ped_venda like '" + vendedor + "' " +
    //"   and prod3.NOME_FORNECEDOR_PRODUTO like '" + fornecedor + "' " +
    //"	       and (infe3.cfop_item like '_1__' or infe3.cfop_item like '_4__') and nfe3.status_nfe like '%Autorizada%'	" +
    //"	       and  nfe3.cnpj_cliente_forn = nfe.cnpj_cliente_forn	" +
    //"	       ) as POSITIVADOS, 	" +
    //                /* peso*/
    //"	    (select sum(infe5.qtde_item * prod5.PESO_UNIT_PRODUTO)	" +
    //"	        from itens_nota infe5	" +
    //"	       inner join produtos prod5 on (CAST(prod5.cod_produto AS VARCHAR(50)) = CAST(infe5.cod_item AS VARCHAR(50))	" +
    //"	       or CAST(prod5.COD_FORNECEDOR_PRODUTO AS VARCHAR(50)) = CAST(infe5.cod_item AS VARCHAR(50)))	" +
    //"	       inner join nota_fiscal nfe5 on infe5.nf_item = nfe5.n_nf	" +
    //"	       inner join pedidos_nf pnf5 on nfe5.n_nf = pnf5.nf_pedido_nf	" +
    //"	       inner join pedidos_venda pv5 on pnf5.n_pedido_nf = pv5.cod_ped_venda	" +
    //"	       inner join vendedores vend5 on vend5.COD_VENDEDOR = pv5.cod_vendedor_ped_venda	" +
    //"	       inner join clientes cli5 on cli5.cnpj = nfe5.cnpj_cliente_forn	" +
    //"	where nfe5.data_emissao_nf >= '" + primeiro_dia_mes.ToShortDateString().Replace("/", ".") + "' and nfe5.data_emissao_nf <= '" + Convert.ToDateTime(dt_hoje.Text).ToShortDateString().Replace("/", ".") + "'	" +
    //"	and pv5.cod_vendedor_ped_venda like '" + vendedor + "' " +
    //"   and prod5.NOME_FORNECEDOR_PRODUTO like '" + fornecedor + "' " +
    //"	       and (infe5.cfop_item like '_1__' or infe5.cfop_item like '_4__') and nfe5.status_nfe like '%Autorizada%'	" +
    //"	       and  nfe5.cnpj_cliente_forn = nfe.cnpj_cliente_forn	" +
    //"	       ) as PESO	" +
    //"	        from itens_nota infe	" +
    //"	       inner join produtos prod on (CAST(prod.cod_produto AS VARCHAR(50)) = CAST(infe.cod_item AS VARCHAR(50))	" +
    //"	       or CAST(prod.COD_FORNECEDOR_PRODUTO AS VARCHAR(50)) = CAST(infe.cod_item AS VARCHAR(50)))	" +
    //"	       inner join nota_fiscal nfe on infe.nf_item = nfe.n_nf	" +
    //"	       inner join pedidos_nf pnf on nfe.n_nf = pnf.nf_pedido_nf	" +
    //"	       inner join pedidos_venda pv on pnf.n_pedido_nf = pv.cod_ped_venda	" +
    //"	       inner join vendedores vend on vend.COD_VENDEDOR = pv.cod_vendedor_ped_venda	" +
    //"	       inner join clientes cli on cli.cnpj = nfe.cnpj_cliente_forn	" +
    //"	where nfe.data_emissao_nf >= '" + primeiro_dia_mes.ToShortDateString().Replace("/", ".") + "' and nfe.data_emissao_nf <= '" + Convert.ToDateTime(dt_hoje.Text).ToShortDateString().Replace("/", ".") + "'	" +
    //"	and pv.cod_vendedor_ped_venda like '" + vendedor + "' " +
    //"   and prod.NOME_FORNECEDOR_PRODUTO like '" + fornecedor + "' " +
    //"	       group by  nfe.cnpj_cliente_forn	" +
    //"	       order by 4 desc";

                //select.Connection = fbConnection1;
                //FbDataAdapter datSelect = new FbDataAdapter();
                //datSelect.SelectCommand = select;
                //dtVendas_cliente.Clear();
                //datSelect.Fill(dtVendas_cliente);
                //DataRow linha_soma = buscar_somatorio(dtVendas_cliente);
                //dtVendas_cliente.Rows.Add(linha_soma);
                //dtVendas_cliente.TableName = "VENDAS_CLIENTE";
                //dtVendas_cliente.WriteXml(@"c:\\evolucao\\xml\vendas_cliente.xml");
                //fbConnection1.Close();
                //10.3.3.4.DataSource = dtVendas_cliente;
            }
            catch { fbConnection1.Close(); }

        }

        private DateTime buscar_dia_anterior(DateTime dia_atual)
        {
            DateTime dia_anterior = dia_atual.AddDays(-1);
            while (dia_anterior.DayOfWeek != DayOfWeek.Monday &&
                dia_anterior.DayOfWeek != DayOfWeek.Tuesday &&
                dia_anterior.DayOfWeek != DayOfWeek.Wednesday &&
                dia_anterior.DayOfWeek != DayOfWeek.Thursday &&
                dia_anterior.DayOfWeek != DayOfWeek.Friday)
            {
                dia_anterior = dia_anterior.AddDays(-1);
            }
            return dia_anterior;
        }

        private void preencher_porc_metas()
        {
            for (int i = 0; i < dgvMetas_familia.RowCount; i++)
            {
                double porc_valor = 0, porc_tend = 0, porc_qtde = 0, porc_posit = 0;
                try
                {
                    porc_valor = Convert.ToDouble(dgvMetas_familia.Rows[i].Cells["VALOR_TOTAL"].Value.ToString()) /
                        Convert.ToDouble(dgvMetas_familia.Rows[i].Cells["META_VALOR"].Value.ToString()) * 100;

                    porc_tend = (Convert.ToDouble(dgvMetas_familia.Rows[i].Cells["VALOR_TOTAL"].Value.ToString()) /
                        Convert.ToDouble(tb_dias_decorridos.Text) *
                        Convert.ToDouble(tb_dias_uteis.Text) /
                        Convert.ToDouble(dgvMetas_familia.Rows[i].Cells["META_VALOR"].Value.ToString())) * 100;
                }
                catch { }
                try
                {
                    if(Convert.ToDouble(dgvMetas_familia.Rows[i].Cells["META_FISICA"].Value.ToString()) > 0)
                        porc_qtde = Convert.ToDouble(dgvMetas_familia.Rows[i].Cells["QTDE_TOTAL"].Value.ToString()) /
                        Convert.ToDouble(dgvMetas_familia.Rows[i].Cells["META_FISICA"].Value.ToString()) * 100;
                }
                catch { }

                try
                {
                    if (Convert.ToDouble(dgvMetas_familia.Rows[i].Cells["META_POSITIVACAO"].Value.ToString()) > 0)
                    porc_posit = Convert.ToDouble(dgvMetas_familia.Rows[i].Cells["POSITIVADOS"].Value.ToString()) /
                        Convert.ToDouble(dgvMetas_familia.Rows[i].Cells["META_POSITIVACAO"].Value.ToString()) * 100;
                }
                catch { }


                dgvMetas_familia.Rows[i].Cells["PORC_ATING"].Value = porc_valor.ToString("n2");
                dgvMetas_familia.Rows[i].Cells["PORC_TEND"].Value = porc_tend.ToString("n2");
                dgvMetas_familia.Rows[i].Cells["PORC_QTDE"].Value = porc_qtde.ToString("n2");
                dgvMetas_familia.Rows[i].Cells["PORC_POSITIVACAO"].Value = porc_posit.ToString("n2");

            }
        }

        private void preencher_porc_metas_vendedor()
        {
            for (int i = 0; i < dgvMetas_vendedor.RowCount; i++)
            {
                double porc_valor = 0, porc_tend = 0, porc_qtde = 0, porc_posit = 0;

                try
                {
                    porc_valor = Convert.ToDouble(dgvMetas_vendedor.Rows[i].Cells["VALOR_TOTAL_VEND"].Value.ToString()) /
                        Convert.ToDouble(dgvMetas_vendedor.Rows[i].Cells["META_VALOR_VEND"].Value.ToString()) * 100;

                    porc_tend = (Convert.ToDouble(dgvMetas_vendedor.Rows[i].Cells["VALOR_TOTAL_VEND"].Value.ToString()) /
                        Convert.ToDouble(tb_dias_decorridos.Text) *
                        Convert.ToDouble(tb_dias_uteis.Text) /
                        Convert.ToDouble(dgvMetas_vendedor.Rows[i].Cells["META_VALOR_VEND"].Value.ToString())) * 100;
                }
                catch { }
                try
                {
                    if (Convert.ToDouble(dgvMetas_vendedor.Rows[i].Cells["META_FISICA_VEND"].Value.ToString()) > 0)
                        porc_qtde = Convert.ToDouble(dgvMetas_vendedor.Rows[i].Cells["QTDE_TOTAL_VEND"].Value.ToString()) /
                        Convert.ToDouble(dgvMetas_vendedor.Rows[i].Cells["META_FISICA_VEND"].Value.ToString()) * 100;
                }
                catch { }

                


                dgvMetas_vendedor.Rows[i].Cells["PORC_VALOR_VEND"].Value = porc_valor.ToString("n2");
                dgvMetas_vendedor.Rows[i].Cells["PORC_TEND_VEND"].Value = porc_tend.ToString("n2");
                dgvMetas_vendedor.Rows[i].Cells["PORC_QTDE_VEND"].Value = porc_qtde.ToString("n2");
               

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                dsPainel_vendas painel = new dsPainel_vendas();

                if (cbFamilia.Checked)
                {
                    int i = 1;
                    foreach (DataRow dr in dtMetas_familia.Rows)
                    {
                        if (i <= dtMetas_familia.Rows.Count)
                        {
                            double meta_valor = 0, valor_total = 0, saldo_dia = 0, pedido_parado = 0, meta_fisica = 0, qtde_total = 0,
                                meta_positivacao = 0, positivados = 0, dia_anterior = 0;
                            try
                            {
                                meta_valor = Convert.ToDouble(dr["META_VALOR"].ToString());
                            }
                            catch { }
                            try
                            {
                                valor_total = Convert.ToDouble(dr["VALOR_TOTAL"].ToString());
                            }
                            catch { }
                            try
                            {
                                saldo_dia = Convert.ToDouble(dr["SALDO_DIA"].ToString());
                            }
                            catch { }
                            try
                            {
                                pedido_parado = Convert.ToDouble(dr["PEDIDO_PARADO"].ToString());
                            }
                            catch { }
                            try
                            {
                                meta_fisica = Convert.ToDouble(dr["META_FISICA"].ToString());
                            }
                            catch { }
                            try
                            {
                                qtde_total = Convert.ToDouble(dr["QTDE_TOTAL"].ToString());
                            }
                            catch { }
                            try
                            {
                                meta_positivacao = Convert.ToDouble(dr["META_POSITIVACAO"].ToString());
                            }
                            catch { }
                            try
                            {
                                positivados = Convert.ToDouble(dr["POSITIVADOS"].ToString());
                            }
                            catch { }
                            try
                            {
                                dia_anterior = Convert.ToDouble(dr["DIA_ANTERIOR"].ToString());
                            }
                            catch { }
                            painel.dsMetas_familia.AdddsMetas_familiaRow(dr[0].ToString(), meta_valor,
                                valor_total, saldo_dia, pedido_parado, meta_fisica, qtde_total, meta_positivacao,
                               positivados, dia_anterior);
                            i++;
                        }
                        
                    }
                }

                if (cbVendedores.Checked)
                {
                    int i = 1;
                    foreach (DataRow dr in dtMetas_vendedor.Rows)
                    {
                        if (i < dtMetas_vendedor.Rows.Count)
                        {

                            double meta_valor = 0, valor_total = 0, saldo_dia = 0, pedido_parado = 0,
                                meta_fisica = 0, qtde_total = 0, dia_anterior = 0, trocas = 0, vendas_vigor = 0, meta_positivacao = 0, positivacao = 0;

                            try { meta_valor = Convert.ToDouble(dr["META_VALOR"].ToString()); }
                            catch { }
                            try { valor_total = Convert.ToDouble(dr["VALOR_TOTAL"].ToString()); }
                            catch { }
                            try { saldo_dia = Convert.ToDouble(dr["SALDO_DIA"].ToString()); }
                            catch { }
                            try { pedido_parado = Convert.ToDouble(dr["PEDIDO_PARADO"].ToString()); }
                            catch { }
                            try { meta_fisica = Convert.ToDouble(dr["META_FISICA"].ToString()); }
                            catch { }
                            try { qtde_total = Convert.ToDouble(dr["QTDE_TOTAL"].ToString()); }
                            catch { }
                            try { dia_anterior = Convert.ToDouble(dr["DIA_ANTERIOR"].ToString()); }
                            catch { }
                            try { trocas = Convert.ToDouble(dr["TROCAS"].ToString()); }
                            catch { }
                            try { vendas_vigor = Convert.ToDouble(dr["VENDAS_VIGOR"].ToString()); }
                            catch { }
                            try { meta_positivacao = Convert.ToDouble(dr["META_POSITIVACAO"].ToString()); }
                            catch { }
                            try { positivacao = Convert.ToDouble(dr["POSITIVADOS"].ToString()); }
                            catch { }


                            painel.dsMetas_vendedor.AdddsMetas_vendedorRow(dr["NOME_VENDEDOR"].ToString(), meta_valor, valor_total, saldo_dia,
                                pedido_parado, meta_fisica, qtde_total, dia_anterior, Convert.ToInt32(dr["COD_VENDEDOR_MPV"].ToString()), trocas, vendas_vigor, 
                                meta_positivacao, positivacao);
                            i++;
                        }
                        
                    }
                }

                if (cbClientes.Checked)
                {
                    int i = 1;
                    foreach (DataRow dr in dtVendas_cliente.Rows)
                    {
                        if (i < dtVendas_cliente.Rows.Count)
                        {
                            double valor_total = 0, saldo_dia = 0, pedido_parado = 0, qtde_total = 0,
                                positivados = 0, trocas = 0, bonificados = 0, peso = 0;

                            try { valor_total = Convert.ToDouble(dr["VALOR_TOTAL"].ToString()); }
                            catch { }
                            try { saldo_dia = Convert.ToDouble(dr["SALDO_DIA"].ToString()); }
                            catch { }
                            try { pedido_parado = Convert.ToDouble(dr["PEDIDO_PARADO"].ToString()); }
                            catch { }
                            try
                            {
                                qtde_total = Convert.ToDouble(dr["QTDE_TOTAL"].ToString());
                            }
                            catch { }
                            try { positivados = Convert.ToDouble(dr["POSITIVADOS"].ToString()); }
                            catch { }
                            try { trocas = Convert.ToDouble(dr["TROCAS"].ToString()); }
                            catch { }
                            try { bonificados = Convert.ToDouble(dr["BONIFICADOS"].ToString()); }
                            catch { }
                            try { peso = Convert.ToDouble(dr["PESO"].ToString()); }
                            catch { }

                            painel.dsVendas_clientes.AdddsVendas_clientesRow(dr["RAZAO_SOCIAL"].ToString(),
                                valor_total, saldo_dia, pedido_parado, qtde_total, positivados, bonificados, trocas, peso);
                            i++;
                        }
                        
                    }
                }

                int cod_vendedor = 0;
                try
                {
                    cod_vendedor = Convert.ToInt32(tb_cod_vendedor.Text);
                }
                catch { }

                    int visitas_dia = 0, positivados_dia = 0, positivados_mes = 0;
                    foreach (DataRow dr_visitas in dtVisitas.Rows)
                    {
                        try
                        {
                            visitas_dia = Convert.ToInt32(dr_visitas["VISITAS_DIA"].ToString());
                        }
                        catch { }
                        try
                        {
                            positivados_dia = Convert.ToInt32(dr_visitas["POSITIVADOS_DIA"].ToString());
                        }
                        catch { }
                        try
                        {
                            positivados_mes = Convert.ToInt32(dr_visitas["POSITIVADOS_MES"].ToString());
                        }
                        catch { }

                    }

                painel.INFORMACOES.AddINFORMACOESRow(Convert.ToDateTime(dt_hoje.Text), Convert.ToDouble(tb_dias_uteis.Text),
                    Convert.ToInt32(tb_dias_decorridos.Text), tb_hoje.Text, Convert.ToDouble(tb_velocidade.Text.Replace("%", "")), Convert.ToDouble(tb_dias_restantes.Text),
                    Convert.ToDouble(tb_dias_mes.Text), cod_vendedor, tb_nome_vendedor.Text, visitas_dia, positivados_dia, tb_nome_fornecedor.Text, positivados_mes);

                try
                {
                    //EMPRESA
                    FbCommand select = new FbCommand();
                    select.CommandText =
                        "SELECT * FROM EMPRESA";
                    select.Connection = fbConnection1;
                    fbConnection1.Open();
                    FbDataAdapter datSelect = new FbDataAdapter();
                    datSelect.SelectCommand = select;
                    datSelect.Fill(painel.EMPRESA);
                    fbConnection1.Close();
                }
                catch { fbConnection1.Close(); }

                crPainel_vendas cr = new crPainel_vendas();
                cr.SetDataSource(painel);
                form_imprimir imprime = new form_imprimir(cr);
                imprime.Show();


            }
            catch { fbConnection1.Close(); }



        }

        private void btnAddVendedor_Click_1(object sender, EventArgs e)
        {
            form_vendedores vend = new form_vendedores();
            try
            {
                vend.ShowDialog();
            }
            finally
            {
                vend.Dispose();
                tb_cod_vendedor.Text = vend.cod_vendedor_escolhido;
                tb_nome_vendedor.Text = vend.vendedor_escolhido;
            }
        }

        private void btnAddFornecedores_Click(object sender, EventArgs e)
        {
            form_localiza_forn fornecedores = new form_localiza_forn(false, "");

            try
            {
                fornecedores.ShowDialog();
            }
            finally
            {
                fornecedores.Dispose();
                tb_nome_fornecedor.Text = fornecedores.razao_forn_escolhido;
                tb_cod_fornecedor.Text = fornecedores.cnpj_escolhido;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!cbFamilia.Checked && !cbClientes.Checked && !cbVendedores.Checked && !cbFinanceiro.Checked && !cbVisitas.Checked)
            {
                cbClientes.Checked = true; cbFamilia.Checked = true; cbFinanceiro.Checked = true; cbVendedores.Checked = true; cbVisitas.Checked = true;

            }
            preencher_parametros();
            if (cbFamilia.Checked)
                preencher_metas_familia_xml();
            if (cbVendedores.Checked)
                preencher_metas_vendedor_xml();
            if (cbClientes.Checked)
                preencher_vendas_clientes_xml();
            if (cbFinanceiro.Checked)
                preencher_financeiro_xml();
            if (cbVisitas.Checked)
                preencher_visitas_xml();
        }

        private void preencher_visitas_xml()
        {
            try
            {
                DataSet ds = new DataSet();
                string caminho = @"c:\\evolucao\\xml\visitas.xml";
                retirar_caractere_xml(caminho);
                ds.ReadXml("c:\\evolucao\\xml\\temp.xml");
                dtVisitas = ds.Tables[0];
                dgvVisitas.DataSource = dtVisitas;
                double porc = 0;
                foreach (DataRow dr in dtVisitas.Rows)
                {
                    try
                    {
                        porc = Convert.ToDouble(dr["POSITIVADOS_DIA"].ToString()) /
                            Convert.ToDouble(dr["VISITAS_DIA"].ToString());
                    }
                    catch { }
                }
               
                dgvVisitas.Rows[0].Cells["col_porc_visitas"].Value = porc.ToString("n2");
            }
            catch { }
        }

        private void preencher_vendas_clientes_xml()
        {
            try
            {
                DataSet ds = new DataSet();
                string caminho = @"c:\\evolucao\\xml\vendas_cliente.xml";
                retirar_caractere_xml(caminho);
                ds.ReadXml("c:\\evolucao\\xml\\temp.xml");
                dtVendas_cliente = ds.Tables[0];
                dgvVendas_clientes.DataSource = dtVendas_cliente;
            }
            catch { }
        }

        private void preencher_metas_vendedor_xml()
        {
            try
            {
                DataSet ds = new DataSet();
                string caminho = @"c:\\evolucao\\xml\metas_vendedor.xml";
                retirar_caractere_xml(caminho);
                ds.ReadXml("c:\\evolucao\\xml\\temp.xml");
                dtMetas_vendedor = ds.Tables[0];
                dgvMetas_vendedor.DataSource = dtMetas_vendedor;
                preencher_porc_metas_vendedor();
            }
            catch { }
        }

        private void preencher_metas_familia_xml()
        {
            try
            {
                DataSet ds = new DataSet();
                string caminho = @"c:\\evolucao\\xml\metas_familia.xml";
                retirar_caractere_xml(caminho);
                ds.ReadXml("c:\\evolucao\\xml\\temp.xml");
                dtMetas_familia = ds.Tables[0];
                dgvMetas_familia.DataSource = dtMetas_familia;
                preencher_porc_metas();
            }
            catch { }
        }

        private void preencher_financeiro_xml()
        {
            try
            {
                DataSet ds = new DataSet();
                string caminho = @"c:\\evolucao\\xml\financeiro.xml";
                retirar_caractere_xml(caminho);
                ds.ReadXml("c:\\evolucao\\xml\\temp.xml");
                dtFinanceiro = ds.Tables[0];
                dgvFinanceiro.DataSource = dtFinanceiro;
            }
            catch { }
        }

        private void retirar_caractere_xml(string caminho)
        {
            string arquivo;
             StreamReader objReader = new StreamReader(caminho);
                ArrayList arrText = new ArrayList();
                arquivo = objReader.ReadToEnd();
                objReader.Close();
                string _rep = arquivo.Replace(".",",").Replace("\"","'").Replace("'1,0'","'1.0'");
                FileInfo t = new FileInfo("c:\\evolucao\\xml\\temp.xml");
                using (StreamWriter texto = t.CreateText())
                {
                    texto.WriteLine(_rep);
                }

        }

        private void cb_vendedor_CheckedChanged(object sender, EventArgs e)
        {
            if (!cb_vendedor.Checked)
            {
                tb_cod_vendedor.Text = "";
                tb_nome_vendedor.Text = "";
            }
        }

        private void cb_fornecedor_CheckedChanged(object sender, EventArgs e)
        {

            if (!cb_fornecedor.Checked)
            {
                tb_cod_fornecedor.Text = "";
                tb_nome_fornecedor.Text = "";
            }
        }
    }
}
