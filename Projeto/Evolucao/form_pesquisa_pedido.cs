using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DFW;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace Evolucao
{
    public partial class form_pesquisa_pedido : Form
    {
        public bool consultaInicial = false;
        public string cod_ped_escolhido;
        public string[] pedidos_selecionados = new string[500];
        public bool consulta; public bool selecao_nf;
        public int numero_pedidos;
        public string cod_usuario;
        bool erro = false;
        bool faturamento = false;

        public string cnpj_empresa;

        public form_pesquisa_pedido(bool faturamento, string cnpj_empresa)
        {
            this.faturamento = faturamento;
            this.cnpj_empresa = cnpj_empresa;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            consultaInicial = false;
            selecionar_pedidos();
            
            contar_pedidos();

        }

        private void contar_pedidos()
        {
            tb_qtde_pedidos.Text = dgvPedidos.RowCount.ToString();
        }
        /*
            try
            {
                if(!faturamento)
                {
                    dsPedidos_venda.Clear();

                    string select = 
                        "select " +
                        "   pv.cod_ped_venda, " +
                        "   pv.data_ped_venda, " +
                        "   pv.data_baixa_ped_venda, " +
                        "   pv.cliente_ped_venda, " +
                        "   pv.cnpj_ped_venda, " +
                        "   pv.cond_pgto_ped_venda, " +
                        "   pv.valor_total_prod_ped_venda, " +
                        "   pv.valor_total_ped_venda, " +
                        "   pv.valor_total_icms_ped_venda, " +
                        "   pv.valor_total_ipi_ped_venda, " +
                        "   pv.valor_desconto_ped_venda, " +
                        "   pv.obs_ped_venda, " +
                        "   pv.nf_ped_venda, " +
                        "   pv.n_nf_ped_venda, " + 
                        "   pv.baixado_estoque_ped_venda, " +
                        "   pv.pago_ped_venda, " +
                        "   pv.cod_caixa_pgto_ped_venda, " +
                        "   pv.vendedor_ped_venda, " +
                        "   pv.cod_vendedor_ped_venda, " +
                        "   pv.cancelado_ped_venda, " +
                        "   pv.nome_contato_ped_venda, " +
                        "   pv.telefone_contato_ped_venda, " +
                        "   pv.email_contato_ped_venda, " +
                        "   pv.porc_desconto_ped_venda, " +
                        "   pv.id_pedido_cel_ped_venda, " +
                        "   pv.impresso_ped_venda " +
                        "from pedidos_venda pv " +
                        "where pv.data_ped_venda >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") + "' " +
                        "   and pv.data_ped_venda <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                        "order by pv.cod_ped_venda desc";
                    this.datPedidos_venda.SelectCommand.CommandText = select;
              
                    this.fbConnection1.Open();
                    this.datPedidos_venda.SelectCommand.Connection = fbConnection1;
                    this.datPedidos_venda.SelectCommand.ExecuteNonQuery();
                    datPedidos_venda.Fill(PEDIDOS_VENDA);
                    this.fbConnection1.Close(); 
                    somar_totais();

                    formatarDgv();
                }
            }
            catch
            {
                fbConnection1.Close(); 
                MessageBox.Show("ERRO");
            }
         
        }
        * */
        private void somar_totais()
        {
            double total = 0;
            for (int i = 0; i < dgvPedidos.RowCount; i++)
            {
                try
                {
                    total = total + Convert.ToDouble(dgvPedidos.Rows[i].Cells["col_valor_total"].Value);
                }
                catch
                { }
            }
            tb_valor_total.Text = total.ToString("n2");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dsPedidos_venda.Tables["PEDIDOS_VENDA"].DefaultView.RowFilter = "CLIENTE_PED_VENDA Like '*" + tb_cliente.Text + "*'";
            somar_totais();
            contar_pedidos();
            formatarDgv();
        }

        private void tb_vendedor_TextChanged(object sender, EventArgs e)
        {
            dsPedidos_venda.Tables["PEDIDOS_VENDA"].DefaultView.RowFilter = "VENDEDOR_PED_VENDA Like '*" + tb_vendedor.Text + "*'";
            somar_totais();
            contar_pedidos();
            formatarDgv();
        }

        string razao_social_empresa = "", nome_fantasia_empresa = "", ie_empresa = "", im_empresa = "", cnae_empresa = "", endereco_empresa = "", n_endereco_empresa = "",
        complemento_empresa = "", bairro_empresa = "", cidade_empresa = "", estado_empresa = "", cep_empresa = "", telefone_empresa = "", cod_cidade_empresa = "", pais_empresa = "",
        cod_pais_empresa = "", licenca_dll_nfe_empresa = "", nome_certificado_nfe_empresa = "", assunto_nfe_email_empresa = "", smtp_nfe_empresa = "", email_nfe_empresa = "",
        senha_email_nfe_empresa = "", logotipo_empresa = "", proxy_empresa = "", usuario_proxy_empresa = "", senha_proxy_empresa = "", crt_empresa = "", portaEmailEmpresa = "",
        sslEmpresa = "", serie_empresa = "", boleto_pedido_empresa = "", cliente_inadimplente_empresa = "";

        private void detectar_dados_empresa(out string razao_social_empresa, out string nome_fantasia_empresa, out string cnpj_empresa, out string ie_empresa, out string im_empresa, out string cnae_empresa, out string endereco_empresa, out string n_endereco_empresa,
               out string complemento_empresa, out string bairro_empresa, out string cidade_empresa, out string estado_empresa, out string cep_empresa, out string telefone_empresa, out string cod_cidade_empresa, out string pais_empresa,
               out string cod_pais_empresa, out string licenca_dll_nfe_empresa, out string nome_certificado_nfe_empresa, out string assunto_nfe_email_empresa, out string smtp_nfe_empresa, out string email_nfe_empresa,
               out string senha_email_nfe_empresa, out string logotipo_empresa, out string proxy_empresa, out string usuario_proxy_empresa, out string senha_proxy_empresa,
       out string crt_empresa, out string portaEmailEmpresa, out string sslEmpresa, out string serie_empresa, out string boleto_pedido_empresa, out string cliente_inadimplente_empresa)
        {
            razao_social_empresa = ""; nome_fantasia_empresa = ""; cnpj_empresa = this.cnpj_empresa; ie_empresa = ""; im_empresa = ""; cnae_empresa = ""; endereco_empresa = ""; n_endereco_empresa = "";
            complemento_empresa = ""; bairro_empresa = ""; cidade_empresa = ""; estado_empresa = ""; cep_empresa = ""; telefone_empresa = ""; cod_cidade_empresa = ""; pais_empresa = "";
            cod_pais_empresa = ""; licenca_dll_nfe_empresa = ""; nome_certificado_nfe_empresa = ""; assunto_nfe_email_empresa = ""; smtp_nfe_empresa = ""; email_nfe_empresa = "";
            senha_email_nfe_empresa = ""; logotipo_empresa = ""; proxy_empresa = ""; usuario_proxy_empresa = ""; senha_proxy_empresa = ""; crt_empresa = ""; portaEmailEmpresa = "";
            sslEmpresa = ""; serie_empresa = ""; boleto_pedido_empresa = ""; cliente_inadimplente_empresa = "";
            try
            {
                FbCommand comando = new FbCommand();
                comando.Connection = fbConnection1;
                comando.CommandText = "SELECT * FROM EMPRESA where LICENCA_DLL_NFE_EMPRESA is not null and CNPJ_EMPRESA = '" + cnpj_empresa + "'" ;
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
                   // cnpj_empresa = dr["CNPJ_EMPRESA"].ToString().Replace(".", "").Replace("/", "").Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
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

                    serie_empresa = dr["SERIE_EMPRESA"].ToString();
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
        private void form_pesquisa_pedido_Load(object sender, EventArgs e)
        {
            consultaInicial = true;
            selecionar_pedidos();
            detectar_dados_empresa(out razao_social_empresa, out nome_fantasia_empresa, out cnpj_empresa, out ie_empresa, out im_empresa, out cnae_empresa, out endereco_empresa, out n_endereco_empresa,
     out complemento_empresa, out bairro_empresa, out cidade_empresa, out estado_empresa, out cep_empresa, out telefone_empresa, out cod_cidade_empresa, out pais_empresa,
     out cod_pais_empresa, out licenca_dll_nfe_empresa, out nome_certificado_nfe_empresa, out assunto_nfe_email_empresa, out smtp_nfe_empresa, out email_nfe_empresa,
     out senha_email_nfe_empresa, out logotipo_empresa, out proxy_empresa, out usuario_proxy_empresa, out senha_proxy_empresa, out crt_empresa, out portaEmailEmpresa, out sslEmpresa, out serie_empresa,
     out boleto_pedido_empresa, out cliente_inadimplente_empresa);
            #region Codigo Exclusivo Artesanal Doces
            if (form_principal.cnpjArtesanal == "04379165000177")
            {
                btnConfirmarPedido.Text = "Confirmar Orçamento(s)";
                labelCodPedido.Text = "Cod. Orçamento";
                labelQTdeOrcamentos.Text = "Qtde \nOrçamentos:";
                //labelObservacaoPedido.Text = "Orçamentos que foram criados pelo celular dos vendedores";
                this.Text = "Pesquisa Orçamentos";
            }
            #endregion
        }

        private void selecionar_pedidos()
        {
            
            try
            {
                string cidade = " , cli.cidade, cli.cod_roteiro_cliente, cli.NOME_FANTASIA, cli.BAIRRO, cli.CEP_CLIENTE ";
                string emissor = " and pv.CNPJ_EMISSOR_PED_VENDA = '" + cnpj_empresa + "'";
                if (!faturamento)
                {
                    string fechados = "", faturados = "", orcamentos = "", cancelados = "";
                    string tipo = "", produto = "", item_produto = "", stringInicial = "";

                    string bombas = "", vendas = "", indust = "";
                    //if (cbBombas.Checked)
                    //    bombas = " AND pv.BOMBAS_PED_VENDA = '1'  ";
                    //if (cbVenda.Checked)
                    //    vendas = " AND pv.VENDAS_PED_VENDA = '1'  ";
                    //if (cbIndustrializacao.Checked)
                    //    indust = " AND pv.indust_PED_VENDA = '1'  ";

                    //if (cbTroca.Checked || cbBonificacao.Checked || cbVenda.Checked || cbDegustacao.Checked || cbDevolucao.Checked)
                    //{
                    //    if (cbTroca.Checked)
                    //    {
                    //        tipo = " AND pv.TROCA_PED_VENDA = '1' ";
                    //    }
                    //    if (cbBonificacao.Checked)
                    //    {
                    //        tipo = " AND pv.BONIFICACAO_PED_VENDA = '1' ";
                    //    }
                    //     if (cbDegustacao.Checked)
                    //    {
                    //        tipo = " AND pv.DEGUSTACAO_PED_VENDA = '1' ";
                    //    }
                    //     if (cbDevolucao.Checked)
                    //     {
                    //         tipo = " AND pv.DEVOLUCAO_PED_VENDA = '1' ";
                    //     }
                    //    if (cbVenda.Checked)
                    //    {
                    //        tipo = " AND ((pv.BONIFICACAO_PED_VENDA = '0' or pv.BONIFICACAO_PED_VENDA is null) and " +
                    //            "(pv.TROCA_PED_VENDA = '0' or pv.TROCA_PED_VENDA is null) and " + 
                    //            "(pv.DEGUSTACAO_PED_VENDA = '0' or pv.DEGUSTACAO_PED_VENDA is null) and " +
                    //            "(pv.DEVOLUCAO_PED_VENDA = '0' or pv.DEVOLUCAO_PED_VENDA is null))";
                    //    }
                       
                    //}

                    if (tb_produto.Text != "")
                    {
                        produto = " INNER JOIN ITENS_PEDIDO_VENDA iped ON iped.COD_PEDIDO_ITEM_VENDA = pv.COD_PED_VENDA ";
                        item_produto = " AND iped.COD_PROD_ITEM_VENDA = '" + tb_produto.Text + "' ";
                    }

                    string op_item = "", pedido_item = "";
                    if (tb_op_cliente.Text != "")
                    {
                        produto = " INNER JOIN ITENS_PEDIDO_VENDA iped ON iped.COD_PEDIDO_ITEM_VENDA = pv.COD_PED_VENDA ";
                        op_item = " AND iped.OP_CLIENTE_ITEM_VENDA = '" + tb_op_cliente.Text + "' ";
                    }

                    if (tb_pedido_cliente.Text != "")
                    {
                        produto = " INNER JOIN ITENS_PEDIDO_VENDA iped ON iped.COD_PEDIDO_ITEM_VENDA = pv.COD_PED_VENDA ";
                        pedido_item = " AND iped.PEDIDO_CLIENTE_ITEM_VENDA = '" + tb_pedido_cliente.Text + "' ";
                    }


                    if (cbFechados.Checked)
                    {
                        fechados = " AND pv.BAIXADO_ESTOQUE_PED_VENDA = '1' ";
                    }
                    else
                    {
                        if (cb_Nao_fechados.Checked)
                        {
                            fechados = " AND (pv.BAIXADO_ESTOQUE_PED_VENDA = '0' OR pv.BAIXADO_ESTOQUE_PED_VENDA IS NULL) ";
                        }
                    }
                   

                    if (cbFaturados.Checked || cbNao_faturados.Checked)
                    {
                        if (cbFaturados.Checked)
                        {
                            faturados = " AND pv.NF_PED_VENDA = '1' ";
                        }
                        else
                        {
                            faturados = " AND (pv.NF_PED_VENDA = '0' OR pv.NF_PED_VENDA IS NULL) ";
                        }
                    }
                    //não aparecer orcamentos e cancelados como default
                    orcamentos = "";// AND (pv.ORCAMENTO_PED_VENDA = '0' OR pv.ORCAMENTO_PED_VENDA IS NULL) ";
                    //if (cbApenas_orcamentos.Checked)
                    //{
                    //    orcamentos = " AND pv.ORCAMENTO_PED_VENDA = '1' ";

                    //}

                    cancelados = "";// AND (pv.CANCELADO_PED_VENDA = '0' OR pv.CANCELADO_PED_VENDA IS NULL) ";
                    //if (cbCancelados.Checked)
                    //{
                    //    cancelados = " AND (pv.CANCELADO_PED_VENDA = '1') ";
                    //}

                    string pv = "";
                    if (cbPv.Checked)
                    {
                        pv = " AND pv.PV_PED_VENDA = '1' ";
                    }
                    string data = "";
                    if (cbData.Checked)
                        data = " AND pv.data_ped_venda >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") + "' " +
                        "   and pv.data_ped_venda <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' ";
                   
                        if (cb_data_prevista.Checked)
                            data += " AND pv.data_ENTREGA_ped_venda >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") + "' " +
                            "   and pv.data_ENTREGA_ped_venda <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' ";

                        if (cbData_entrega.Checked)
                            data += " AND pv.data_BAIXA_ped_venda >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") + "' " +
                            "   and pv.data_BAIXA_ped_venda <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' ";
                   

                    string cliente = "", vendedor = "", cnpj_cliente = "";
                    if (tb_cliente.Text != "")
                    {
                        cliente = " AND UPPER(pv.CLIENTE_PED_VENDA) LIKE UPPER('%" + tb_cliente.Text + "%') ";
                    }

                    if (tb_vendedor.Text != "")
                    {
                        vendedor = " AND UPPER(pv.VENDEDOR_PED_VENDA) LIKE UPPER('%" + tb_vendedor.Text + "%') ";
                    }

                    if (txtCnpj.Text != "")
                    {
                        cnpj_cliente = " AND UPPER(pv.CNPJ_PED_VENDA) LIKE UPPER('%" + txtCnpj.Text + "%') ";
                    }

                    if (consultaInicial == true)
                    {
                        stringInicial = "FIRST 300";
                    }
                    else
                    {
                        stringInicial = "";
                    }

                    string join_clientes = "inner join clientes cli on pv.cnpj_ped_venda = cli.cnpj ";
                   // string cidade = " , cli.cidade, cli.cod_roteiro_cliente, cli.NOME_FANTASIA ";
                    if (cbSem_vendedor.Checked)
                    {
                        join_clientes = "";
                        cidade = "";
                    }

                    string _status = "", _tipo = "";
                    if (cbStatus.Text != "")
                        _status = " AND STATUS_PED_VENDA = '" + cbStatus.Text + "' ";
                    if (cbTipo.Text != "")
                        tipo = " AND TIPO_PED_VENDA = '" + cbTipo.Text + "' ";

                    if (cbConfirmados_aguardando.Checked)
                    {
                        _status = " AND (STATUS_PED_VENDA = 'Confirmado' or STATUS_PED_VENDA = 'Aguardando Confirmação') ";
                    }

                    dsPedidos_venda.Clear();
                    datPedidos_venda.SelectCommand.CommandText =
                        "SELECT "+ stringInicial + " pv.* " + cidade + 
                        "FROM pedidos_venda pv " + 
                        join_clientes + produto +
                        "WHERE 0 = 0 " + emissor +
                        fechados + faturados + orcamentos + cancelados
                        + data + tipo + cliente + vendedor + cnpj_cliente + item_produto + pv + op_item + pedido_item + bombas + indust + vendas + _tipo + _status + 
                        "ORDER BY pv.cod_ped_venda DESC";
                    datPedidos_venda.SelectCommand.Connection = fbConnection1;
                    fbConnection1.Open();
                    datPedidos_venda.SelectCommand.ExecuteNonQuery();
                    datPedidos_venda.Fill(PEDIDOS_VENDA);
                    dgvPedidos.AutoGenerateColumns = false;
                    dgvPedidos.DataSource = dsPedidos_venda.Tables["PEDIDOS_VENDA"];
                    txtCodPedido.Select();
                    fbConnection1.Close(); 

                    formatarDgv();
                    somar_totais();
                    contar_pedidos();
                }
                else
                {
                    try
                    {
                        dsPedidos_venda.Clear();
                        datPedidos_venda.SelectCommand.CommandText =
                            "SELECT pv.* " + cidade +
                            "FROM pedidos_venda pv inner join clientes cli on pv.cnpj_ped_venda = cli.cnpj " +
                            "WHERE (pv.cancelado_ped_venda IS NULL or pv.cancelado_ped_venda = 0) " +
                            "AND pv.STATUS_PED_VENDA = 'Confirmado' " + emissor +
                            "AND (pv.nf_ped_venda IS NULL or pv.nf_ped_venda = 0) " +
                            "ORDER BY pv.cod_ped_venda DESC";
                        datPedidos_venda.SelectCommand.Connection = fbConnection1;
                        fbConnection1.Open();
                        datPedidos_venda.SelectCommand.ExecuteNonQuery();
                        datPedidos_venda.Fill(PEDIDOS_VENDA);
                        dgvPedidos.AutoGenerateColumns = false;
                        dgvPedidos.DataSource = dsPedidos_venda.Tables["PEDIDOS_VENDA"];
                        txtCodPedido.Select();
                        fbConnection1.Close(); 

                        formatarDgv();
                        somar_totais();
                        contar_pedidos();

                    }
                    catch (Exception a)
                    {
                        fbConnection1.Close(); 
                        MessageBox.Show("Houve um erro ao selecionar os pedidos!\nErro: " + a.Message);
                    }
                }
            }
            catch (Exception a)
            {
                fbConnection1.Close(); 
                MessageBox.Show(a.ToString());
            }
        }

        private void formatarDgv()
        {

            //for (int i = 0; i < dgvPedidos.Rows.Count; i++)
            //{
            //    if (dgvPedidos.Rows[i].Cells["colPedidoCel"].Value.ToString() != "")
            //    {
            //        if (dgvPedidos.Rows[i].Cells["col_impressao"].Value.ToString() == "1")
            //        {
            //            dgvPedidos.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
            //        }
            //        else
            //        {
            //            dgvPedidos.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
            //        }

            //    }
            //}
        }

        private void dgvPedidos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (consulta == true)
            {
                cod_ped_escolhido = dgvPedidos.Rows[e.RowIndex].Cells["col_cod"].Value.ToString();
                
                this.Close();
            }
            else
            {
                form_pedidos ped = new form_pedidos(cnpj_empresa);
                try
                {
                    try
                    {
                        ped.cod_usuario = cod_usuario;
                        ped.cnpj_empresa = cnpj_empresa;
                        ped.abrir = true;
                        ped.cod_a_abrir = dgvPedidos.Rows[e.RowIndex].Cells["col_cod"].Value.ToString();
                        ped.ShowDialog();
                    }
                    catch { }
                }
                finally
                {

                    ped.Dispose();
                    selecionar_pedidos();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (selecao_nf == true)
            {
                
                for (int j = 0; j < dgvPedidos.SelectedRows.Count; j++)
                {
                    comando_select.CommandText = "SELECT * FROM PEDIDOS_VENDA WHERE COD_PED_VENDA = '" + dgvPedidos.SelectedRows[j].Cells["col_cod"].Value.ToString() + "'";
                    DataSet pedido = new DataSet();
                    fbConnection1.Open();
                    datPedidos_venda.SelectCommand = comando_select;
                    datPedidos_venda.Fill(pedido);
                    string _nf = "";
                    string _cod = "";
                    foreach (DataRow dr in pedido.Tables[0].Rows)
                    {
                        _cod = dr["COD_PED_VENDA"].ToString();
                        _nf = dr["NF_PED_VENDA"].ToString();
                    }
                    fbConnection1.Close(); 
                    if (_nf == "0" || _nf == "")
                    {

                    }
                    else
                    {
                        MessageBox.Show("O Pedido " + _cod + " já foi faturado");
                        erro = true;
                    }

                    pedidos_selecionados[j] = dgvPedidos.SelectedRows[j].Cells["col_cod"].Value.ToString();
                    numero_pedidos = j + 1;
                }
                if (erro == false)
                    this.Close();
                else
                {
                    pedidos_selecionados = null;
                    numero_pedidos = 0;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            form_localiza_produto localiza_item = new form_localiza_produto(false, cnpj_empresa);
            try
            {
                localiza_item.buscar = true;
                localiza_item.ShowDialog();
            }
            finally
            {
                localiza_item.Dispose();

            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            dsPedidos imprimir = new dsPedidos();
            fbConnection1.Open();
            datPedidos_venda.Fill(imprimir.PEDIDOS_VENDA);
            fbConnection1.Close(); 
            crPesquisa_pedidos novo_ped = new crPesquisa_pedidos();
            novo_ped.SetDataSource(imprimir);
            form_imprimir imprime = new form_imprimir(novo_ped);
            imprime.Show();
        }


        private void tb_valor_total_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtCodPedido_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsPedidos_venda.Tables["PEDIDOS_VENDA"].DefaultView.RowFilter = " COD_PED_VENDA = " + txtCodPedido.Text;
                somar_totais();
                contar_pedidos();
                formatarDgv();
            }
            catch
            {
                dsPedidos_venda.Tables["PEDIDOS_VENDA"].DefaultView.RowFilter = " COD_PED_VENDA IS NOT NULL";
                somar_totais();
                formatarDgv();
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            dsPedidos_venda.Tables["PEDIDOS_VENDA"].DefaultView.RowFilter = "CNPJ_PED_VENDA Like '*" + txtCnpj.Text + "*'";
            somar_totais();
            contar_pedidos();
            formatarDgv();
        }

        private void btnConfirmarPedido_Click(object sender, EventArgs e)
        {
            if (!verificar_se_pedido_ja_esta_em_uma_nota())
            {
                if (selecao_nf == true)
                {

                    for (int j = 0; j < dgvPedidos.SelectedRows.Count; j++)
                    {
                        comando_select.CommandText = "SELECT * FROM PEDIDOS_VENDA WHERE COD_PED_VENDA = '" + dgvPedidos.SelectedRows[j].Cells["col_cod"].Value.ToString() + "'";
                        DataSet pedido = new DataSet();
                        fbConnection1.Open();
                        datPedidos_venda.SelectCommand = comando_select;
                        datPedidos_venda.Fill(pedido);
                        string _nf = "";
                        string _cod = "";
                        foreach (DataRow dr in pedido.Tables[0].Rows)
                        {
                            _cod = dr["COD_PED_VENDA"].ToString();
                            _nf = dr["NF_PED_VENDA"].ToString();
                        }
                        fbConnection1.Close();
                        if (_nf == "0" || _nf == "")
                        {
                            pedidos_selecionados[j] = dgvPedidos.SelectedRows[j].Cells["col_cod"].Value.ToString();
                            numero_pedidos = j + 1;
                        }
                        else
                        {
                            MessageBox.Show("O Pedido " + _cod + " já foi faturado");
                            erro = true;
                        }
                    }
                    if (erro == false)
                        this.Close();
                    else
                    {
                        pedidos_selecionados = null;
                        numero_pedidos = 0;
                    }
                }
            }
        }

        private bool verificar_se_pedido_ja_esta_em_uma_nota()
        {
            try
            {
                for (int i = 0; i < dgvPedidos.SelectedRows.Count; i++)
                {
                    string cod_ped = dgvPedidos.SelectedRows[i].Cells["col_cod"].Value.ToString();
                    try
                    {
                        FbCommand select = new FbCommand();
                        select.CommandText =
                            "SELECT nf.STATUS_NFE, nf.N_NF FROM NOTA_FISCAL nf " +
                            " INNER JOIN PEDIDOS_NF pnf ON nf.N_NF = pnf.NF_PEDIDO_NF " +
                            " WHERE pnf.N_PEDIDO_NF = '" + cod_ped + "'";
                        select.Connection = fbConnection1;
                        fbConnection1.Open();
                        FbDataAdapter datSelect = new FbDataAdapter();
                        datSelect.SelectCommand = select;
                        DataTable dtSelect = new DataTable();
                        datSelect.Fill(dtSelect);
                        fbConnection1.Close();
                        foreach (DataRow dr in dtSelect.Rows)
                        {
                            if (!dr[0].ToString().Contains("Cancelada"))
                            {
                                MessageBox.Show("O Pedido " + cod_ped + " já foi inserido na Nota Fiscal número " + dr[1].ToString());
                                return true;
                            }
                        }
                        //return false;
                    }
                    catch (Exception a)
                    {
                        fbConnection1.Close();
                        MessageBox.Show(a.ToString());
                    }

                }
                return false;
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                return false;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                string fechados = "", faturados = "";
                string tipo = "";

                if (cbTroca.Checked || cbBonificacao.Checked || cbVenda.Checked)
                {
                    if (cbTroca.Checked)
                    {
                        tipo = " AND pv.TROCA_PED_VENDA = '1' ";
                    }
                    if (cbBonificacao.Checked)
                    {
                        tipo = " AND pv.BONIFICACAO_PED_VENDA = '1' ";
                    }
                    if (cbVenda.Checked)
                    {
                        tipo = " AND ((pv.BONIFICACAO_PED_VENDA = '0' or pv.BONIFICACAO_PED_VENDA is null) and " +
                            "(pv.TROCA_PED_VENDA = '0' or pv.TROCA_PED_VENDA is null))";
                    }
                }


                if (cbFechados.Checked || cb_Nao_fechados.Checked)
                {
                    if (cbFechados.Checked)
                    {
                        fechados = " AND pv.BAIXADO_ESTOQUE_PED_VENDA = '1' ";
                    }
                    if (cb_Nao_fechados.Checked)
                    {
                        fechados = " AND (pv.BAIXADO_ESTOQUE_PED_VENDA = '0' OR pv.BAIXADO_ESTOQUE_PED_VENDA IS NULL) ";
                    }
                }

                if (cbFaturados.Checked || cbNao_faturados.Checked)
                {
                    if (cbFaturados.Checked)
                    {
                        faturados = " AND pv.NF_PED_VENDA = '1' ";
                    }
                    if (cbNao_faturados.Checked)
                    {
                        faturados = " AND (pv.NF_PED_VENDA = '0' OR pv.NF_PED_VENDA IS NULL) ";
                    }
                }
                string data = "";
                if (cbData.Checked)
                    data = " AND pv.data_ped_venda >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") + "' " +
                    "   and pv.data_ped_venda <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' ";

                string cliente = "", vendedor = "", cnpj_cliente = "";
                if (tb_cliente.Text != "")
                {
                    cliente = " AND upper(pv.CLIENTE_PED_VENDA) LIKE upper('%" + tb_cliente.Text + "%') ";
                }

                if (tb_vendedor.Text != "")
                {
                    vendedor = " AND upper(pv.VENDEDOR_PED_VENDA) LIKE upper('%" + tb_vendedor.Text + "%') ";
                }

                if (txtCnpj.Text != "")
                {
                    cnpj_cliente = " AND upper(pv.CNPJ_PED_VENDA) LIKE upper('%" + txtCnpj.Text + "%') ";
                }


                // buscando valor total
                double valor_total = 0;
                FbCommand select2 = new FbCommand();
                select2.Connection = fbConnection1;
                fbConnection1.Open();
                select2.CommandText =
                    "SELECT SUM(VALOR_TOTAL_PROD_ITEM_VENDA) FROM ITENS_PEDIDO_VENDA ipv INNER JOIN " +
                    "PEDIDOS_VENDA pv ON ipv.COD_PEDIDO_ITEM_VENDA = pv.COD_PED_VENDA " +
                    "WHERE 0 = 0 AND ((pv.BONIFICACAO_PED_VENDA = '0' or pv.BONIFICACAO_PED_VENDA is null) and " +
                            "(pv.TROCA_PED_VENDA = '0' or pv.TROCA_PED_VENDA is null))" +
                            fechados + faturados + data + tipo + cliente + vendedor + cnpj_cliente;
                              FbDataAdapter datSelect2 = new FbDataAdapter();
                datSelect2.SelectCommand = select2;
                DataTable dtSelect2 = new DataTable();
                datSelect2.Fill(dtSelect2);
                fbConnection1.Close();
                foreach (DataRow dr2 in dtSelect2.Rows)
                {
                    try
                    {
                        valor_total = Convert.ToDouble(dr2[0].ToString());
                    }
                    catch { }
                }

                //buscando valor leite
                double valor_leite = 0;
                FbCommand select4 = new FbCommand();
                select4.Connection = fbConnection1;
                fbConnection1.Open();
                select4.CommandText =
                    "SELECT SUM(VALOR_TOTAL_PROD_ITEM_VENDA) FROM ITENS_PEDIDO_VENDA ipv INNER JOIN " +
                    "PEDIDOS_VENDA pv ON ipv.COD_PEDIDO_ITEM_VENDA = pv.COD_PED_VENDA " +
                    "inner join PRODUTOS prod ON ipv.COD_SISTEMA_PROD_ITEM_VENDA = prod.COD_PRODUTO " +
                    "WHERE 0 = 0 AND prod.NOME_FAMILIA_PRODUTO = 'LEITE UHT' " +
                            fechados + faturados + data + tipo + cliente + vendedor + cnpj_cliente;
                FbDataAdapter datSelect4 = new FbDataAdapter();
                datSelect4.SelectCommand = select4;
                DataTable dtSelect4 = new DataTable();
                datSelect4.Fill(dtSelect4);
                fbConnection1.Close();
                foreach (DataRow dr4 in dtSelect4.Rows)
                {
                    try
                    {
                        valor_leite = Convert.ToDouble(dr4[0].ToString());
                    }
                    catch { }
                }


                //buscando valor troca
                double valor_troca = 0;
                FbCommand select3 = new FbCommand();
                select3.Connection = fbConnection1;
                fbConnection1.Open();
                select3.CommandText =
                    "SELECT SUM(VALOR_TOTAL_PROD_ITEM_VENDA) FROM ITENS_PEDIDO_VENDA ipv INNER JOIN " +
                    "PEDIDOS_VENDA pv ON ipv.COD_PEDIDO_ITEM_VENDA = pv.COD_PED_VENDA " +
                    "WHERE 0 = 0 AND TROCA_PED_VENDA = '1' " +
                            fechados + faturados + data + tipo + cliente + vendedor + cnpj_cliente;
                FbDataAdapter datSelect3 = new FbDataAdapter();
                datSelect3.SelectCommand = select3;
                DataTable dtSelect3 = new DataTable();
                datSelect3.Fill(dtSelect3);
                fbConnection1.Close();
                foreach (DataRow dr3 in dtSelect3.Rows)
                {
                    try
                    {
                        valor_troca = Convert.ToDouble(dr3[0].ToString());
                    }
                    catch { }
                }

                //porc troca
                double porc_troca = (valor_troca / valor_total) * 100;


                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT COD_PEDIDO_ITEM_VENDA, DATA_PED_VENDA, CLIENTE_PED_VENDA, SUM(VALOR_TOTAL_PROD_ITEM_VENDA), VENDEDOR_PED_VENDA," +
                    "SUM(CUSTO_ITEM_VENDA), TROCA_PED_VENDA FROM ITENS_PEDIDO_VENDA ipv INNER JOIN " +
                    "PEDIDOS_VENDA pv ON ipv.COD_PEDIDO_ITEM_VENDA = pv.COD_PED_VENDA " +
                    "WHERE 0 = 0 " +
                            fechados + faturados + data + tipo + cliente + vendedor + cnpj_cliente +
                    "group BY COD_PEDIDO_ITEM_VENDA, DATA_PED_VENDA, CLIENTE_PED_VENDA, VENDEDOR_PED_VENDA, TROCA_PED_VENDA";
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();

                dsPedidos ped = new dsPedidos();
                double soma_perc_lucro = 0;
                int contagem_vendas = 0;
                foreach (DataRow dr in dtSelect.Rows)
                {
                    int troca = 0;
                    try
                    {
                        troca = Convert.ToInt32(dr[6].ToString());
                    }
                    catch { }

                    double valor_venda = 0, valor_custo = 0, perc_lucro = 0, valor_lucro_liquido = 0, perc_lucro_bruto = 0,  valor_lucro_bruto = 0;
                    
                    try
                    {
                        valor_venda = Convert.ToDouble(dr[3].ToString());
                    }
                    catch { }
                    try
                    {
                        valor_custo = Convert.ToDouble(dr[5].ToString());
                    }
                    catch { }
                    if (troca == 0)
                    {
                        perc_lucro = (1 - valor_custo / valor_venda) * 100;


                        try
                        {
                            valor_lucro_liquido = valor_venda * perc_lucro / 100;
                        }
                        catch { }



                        try
                        {
                            perc_lucro_bruto = perc_lucro - porc_troca;
                        }
                        catch { }

                        soma_perc_lucro += perc_lucro_bruto;
                        contagem_vendas++;
                        try
                        {
                            valor_lucro_bruto = valor_venda * perc_lucro_bruto / 100;
                        }
                        catch { }
                    }

                    

                    ped.Lucratividade.AddLucratividadeRow(Convert.ToInt32(dr[0].ToString()), Convert.ToDateTime(dr[1].ToString()), dr[2].ToString(), valor_venda, dr[4].ToString(),
                       valor_custo, perc_lucro, valor_lucro_liquido, porc_troca, perc_lucro_bruto, valor_lucro_bruto, troca);

                }
                double media = soma_perc_lucro / contagem_vendas;
                ped.Totais_Lucrativiade.AddTotais_LucrativiadeRow(valor_total, valor_troca, valor_leite, Convert.ToDateTime(dtInicial.Text), Convert.ToDateTime(dtFinal.Text), media, "Pedidos");

                crLucratividade_pedidos novo_ped = new  crLucratividade_pedidos();
                novo_ped.SetDataSource(ped);
                form_imprimir imprime = new form_imprimir(novo_ped);
                imprime.Show();


            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvPedidos.SelectedRows.Count; i++)
            {
                imprimir_pedido(dgvPedidos.SelectedRows[i].Cells["col_cod"].Value.ToString());
            }
        }

        private string zero(int tamanho_pretendido, string valor)
        {

            int tamanho = valor.Length;
            for (int p = 0; p < tamanho_pretendido - tamanho; p++)
            {
                valor = "0" + valor;
            }
            return valor;
        }

        private void imprimir_pedido(string cod)
        {
           
            try
            {
                Declaracoes.iRetorno = Declaracoes.eBuscarPortaVelocidade_DUAL_DarumaFramework();
                if (Declaracoes.iRetorno != 1)
                {
                    MessageBox.Show("Impressora desligada!", "DarumaFramework");

                }

                Declaracoes.iRetorno = Declaracoes.regTermica_DUAL_DarumaFramework("1");
                Declaracoes.eDefinirProduto_Daruma("DUAL");
                //BUFFER

                Declaracoes.iRetorno = Declaracoes.iImprimirBMP_DUAL_DarumaFramework(@"c:\\evolucao\\logo_nfce.bmp");
                //Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework(@"<tb>texto1</tb><tb><ibmp>c:\\evolucao\\logo_nfce.bmp</ibmp></tb><tb>texto</tb>", 0);

                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT * FROM PEDIDOS_VENDA WHERE COD_PED_VENDA = '" + cod + "'";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    FbCommand select_itens = new FbCommand();
                    select_itens.CommandText =
                        "SELECT * FROM ITENS_PEDIDO_VENDA WHERE COD_PEDIDO_ITEM_VENDA = '" + cod + "'";
                    select_itens.Connection = fbConnection1;
                    fbConnection1.Open();
                    FbDataAdapter datSelect_itens = new FbDataAdapter();
                    datSelect_itens.SelectCommand = select_itens;
                    DataTable dtSelect_itens = new DataTable();
                    datSelect_itens.Fill(dtSelect_itens);
                    fbConnection1.Close();


                    string itens = "";
                    int i = 0;
                    foreach(DataRow dr_itens in dtSelect_itens.Rows)
                    {
                        string codigo = zero(6, dr_itens["COD_PROD_ITEM_VENDA"].ToString());
                        if (codigo == "")
                            codigo = zero(6, dr_itens["COD_PROD_ITEM_VENDA"].ToString());
                        string descricao = dr_itens["DESCRICAO_PROD_ITEM_VENDA"].ToString();
                        if (descricao.Length > 30)
                            descricao = descricao.Remove(30);
                        else
                        {
                            while (descricao.Length != 30)
                                descricao = descricao + " ";
                        }
                        int item = i + 1;
                        //itens = itens + "<l>" + zero(3, item.ToString()) + "<tb><ad>" + codigo + "</ad><tb>" + descricao + "</l>" +
                         //   "<tb><tb>" + Convert.ToDouble(dr_itens["QTDE_ITEM_VENDA"].ToString()).ToString("n3") + "</ad>";
                        itens = itens + "<l>" + codigo + "   " + descricao + " " +
                       "<tb> " + Convert.ToDouble(dr_itens["QTDE_ITEM_VENDA"].ToString()).ToString("n3") + " </ad></l>" +
                        "<l></l>" +
                        "<l></l>" +
                        "<l><tc>_</tc></l>";
                        i++;
                    }
                    Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework(@"<e><ce>SEPARAÇÃO DE PEDIDO</e></ce>" +
@"<l><tc>-</tc></l><b>" +
razao_social_empresa + @"<l>" +
@"CNPJ: " + cnpj_empresa + @"/IE: " + ie_empresa + @"</l></b>" +
@"<l><tc>-</tc></l><b>" +
@"<l><tc>-</tc></l><b>" +
@"<l><b>CLIENTE:</b> " + dr["CLIENTE_PED_VENDA"].ToString() + "</l>" +
@"<l><tc>-</tc></l><b>" +
@"<l><tc>-</tc></l><b>" +
@"<l>Pedido n.: " + dr[0].ToString()  + " " + @" Data:<dt></dt> Hora:<hr></hr></l>" +
@"<l><tc>-</tc></l><b>" +
@"<l><b>Código   Descrição" +
@"<tb><tb><tb>Qtde </l></b>" +
@"<l><tc>-</tc></l><b>" +
@"</b></c>" + itens +
@"<l><tc>-</tc></l><b>" +
@"<l>" + dr["OBS_PED_VENDA"].ToString() + "</l><b>" +
@"<l><tc>-</tc></l><b>" +
@"<l></l>" +
@"<l></l>" +
@"<l></l>" +
@"<l></l>" +
@"<l></l>" +
@"<l></l>" +
@"<l></l>" +
@"<gui></gui>", 0);

                    /*
                    Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework(@"<e><ce>PEDIDO DE VENDA</e></ce>" +
    @"<l><tc>-</tc></l><b>" +
    razao_social_empresa + @"<l>" +
    @"CNPJ: " + cnpj_empresa + @"/IE: " + ie_empresa + @"</l></b>" +
    @"<l><b>CLIENTE:</b> R$ " + dr["CLIENTE_PED_VENDA"].ToString() + "</l>" +
    @"<l><tc>-</tc></l><b>" +
    @"<l><tc>-</tc></l><b>" +
    @"<l>Pedido n.: " + dr[0].ToString() + " " + @" Data:<dt></dt> Hora:<hr></hr></l>" +
    @"<l><tc>-</tc></l><b>" +
    @"<l><b>Item <tb>Código<tb>Descrição dos itens </l>" +
    @"<l><tb>Qtde <tb></l></b>" +
    @"<l><tc>-</tc></l><b>" +
    @"</b></c>" + itens +
    @"<l><tc>-</tc></l><b>" +
    @"<l><tc>-</tc></l><b>" +
    @"<gui></gui>", 0);*/

                    if (Declaracoes.iRetorno == 1)
                    {
                        //MessageBox.Show("Impressao Concluida!", "Daruma_Framework_CSharp", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Erro ao realizar a impressão do BUFFER!", "Daruma_Framework_CSharp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception a) {
                MessageBox.Show(a.ToString());
                fbConnection1.Close();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvPedidos.SelectedRows.Count; i++)
            {
                form_pedidos ped = new form_pedidos(cnpj_empresa);
                try
                {
                    ped.cnpj_empresa = cnpj_empresa;
                    ped.abrir = true;
                    ped.fechar = true;
                    ped.cod_a_abrir = dgvPedidos.SelectedRows[i].Cells["col_cod"].Value.ToString();
                    ped.ShowDialog();
                }
                finally
                {
                    ped.Dispose();
                }
            }
            selecionar_pedidos();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvPedidos.SelectedRows.Count; i++)
            {
                form_pedidos ped = new form_pedidos(cnpj_empresa);
                try
                {
                    ped.cnpj_empresa = cnpj_empresa;
                    ped.abrir = true;
                    ped.imprimir_direto = true;
                    ped.cod_a_abrir = dgvPedidos.SelectedRows[i].Cells["col_cod"].Value.ToString();
                    ped.ShowDialog();
                }
                finally
                {
                    ped.Dispose();
                }
            }
            selecionar_pedidos();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            dsPedidos_venda.Tables["PEDIDOS_VENDA"].DefaultView.RowFilter = "NOME_FANTASIA Like '*" + tb_nome_fantasia.Text + "*'";
            somar_totais();
            contar_pedidos();
            formatarDgv();
        }

        private void tb_roteiro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                
                string[] roteiros = new string[30];
                if (tb_roteiro.Text.Contains(";"))
                {
                    int i = 0; // contador texto
                    int j = 0; // contador vetor
                    while (i < tb_roteiro.Text.Length)
                    {
                        while (tb_roteiro.Text[i].ToString() != ";")
                        {
                            roteiros[j] = roteiros[j] + tb_roteiro.Text[i].ToString();
                            i++;
                        }
                        i++;
                        j++;
                    }
                    string where = "0 = 0";
                    for (int m = 0; m < j; m++)
                    {
                        if (m == 0)
                        {
                            where += " AND (COD_ROTEIRO_CLIENTE = '" + roteiros[m].ToString() + "'";
                        }
                        else
                        {
                            where += " OR COD_ROTEIRO_CLIENTE = '" + roteiros[m].ToString() + "'";
                        }
                    }
                    if (j > 0)
                        where += ")";
                    dsPedidos_venda.Tables["PEDIDOS_VENDA"].DefaultView.RowFilter = where;
                    somar_totais();
                    contar_pedidos();
                    formatarDgv();


                }
                else
                {
                    dsPedidos_venda.Tables["PEDIDOS_VENDA"].DefaultView.RowFilter = "COD_ROTEIRO_CLIENTE = '" + tb_roteiro.Text + "'";
                    somar_totais();
                    contar_pedidos();
                    formatarDgv();
                }
            }
            catch
            {
                dsPedidos_venda.Tables["PEDIDOS_VENDA"].DefaultView.RowFilter = "0 = 0 ";
                somar_totais();
                contar_pedidos();
                formatarDgv();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                dsRomaneio_transporte transp = new dsRomaneio_transporte();
                FbCommand select1 = new FbCommand();
                try
                {

                    select1.Connection = fbConnection1;
                    fbConnection1.Open();
                    select1.CommandText =
                        "SELECT * FROM EMPRESA where CNPJ_EMPRESA = '" + cnpj_empresa + "'";
                    FbDataAdapter datTabela1 = new FbDataAdapter();
                    datTabela1.SelectCommand = select1;
                    datTabela1.Fill(transp.EMPRESA);
                    fbConnection1.Close();

                }
                catch (Exception a)
                {
                    fbConnection1.Close();
                    //MessageBox.Show(a.ToString());
                }

                string where_pedidos = "WHERE 0 = 0";
                for (int i = 0; i < dgvPedidos.Rows.Count; i++)
                {
                    if (i == 0)
                        where_pedidos += " and (iped.COD_PEDIDO_ITEM_VENDA = '" + dgvPedidos.Rows[i].Cells["col_cod"].Value.ToString() + "' ";
                    else
                    {
                        where_pedidos += " or iped.COD_PEDIDO_ITEM_VENDA = '" + dgvPedidos.Rows[i].Cells["col_cod"].Value.ToString() + "' ";
                    }
                }
                if (where_pedidos != "WHERE 0 = 0 ")
                    where_pedidos += ")";

                FbCommand select = new FbCommand();
                select.CommandText =
                      @"select  prod.COD_FORNECEDOR_PRODUTO, prod.descricao_produto, sum(iped.qtde_item_venda), prod.QTDE_UNIDADE_PRODUTO, prod.DESCRICAO_GRUPO_PRODUTO, 
                    pv.N_PED_VENDA, pv.CNPJ_EMISSOR_PED_VENDA, pv.DATA_ENTREGA_PED_VENDA, pv.CLIENTE_PED_VENDA   
                    from itens_pedido_venda iped 
                    inner join pedidos_venda pv on iped.COD_PEDIDO_ITEM_VENDA = pv.COD_PED_VENDA 
                    inner join produtos prod on cast(iped.cod_prod_item_venda as varchar(30)) = cast(prod.COD_FORNECEDOR_PRODUTO as varchar(30)) " +
                        where_pedidos +
                    @"group by prod.DESCRICAO_GRUPO_PRODUTO, prod.descricao_produto,  prod.COD_FORNECEDOR_PRODUTO,  prod.QTDE_UNIDADE_PRODUTO,
                    pv.N_PED_VENDA, pv.CNPJ_EMISSOR_PED_VENDA, pv.DATA_ENTREGA_PED_VENDA, pv.CLIENTE_PED_VENDA
                     ORDER BY 8";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {

                    DateTime data = new DateTime();
                    bool _data = true;
                    try
                    {
                        data = Convert.ToDateTime(dr["DATA_ENTREGA_PED_VENDA"].ToString());

                    }
                    catch { data = Convert.ToDateTime("01/01/2001"); }
                    int qtde_caixas = 0;
                    int sobra = 0;
                    int qtde_por_caixa = 1;
                    double qtde_produto = 0;
                    //  try { qtde_por_caixa = Convert.ToInt32(dr[3].ToString()); }
                    //  catch { }
                    try { qtde_produto = Convert.ToDouble(dr[2].ToString()); }
                    catch { }
                    if (qtde_por_caixa > 0)
                    {
                        double valor = qtde_produto;
                        int parteInteira = (int)valor;
                        double parteFracionaria = valor - parteInteira;
                        parteFracionaria = parteFracionaria * 10;


                        transp.Produtos.AddProdutosRow(dr[0].ToString(), dr[1].ToString(), Convert.ToDouble(dr[2].ToString()),
                            parteInteira.ToString() + " cxs e " + parteFracionaria.ToString("n0") + " unid.", dr[4].ToString(), dr["CNPJ_EMISSOR_PED_VENDA"].ToString(),
                            dr["CLIENTE_PED_VENDA"].ToString(), dr["N_PED_VENDA"].ToString(), data);

                        //   imprimir.Produtos_itens.AddProdutos_itensRow(dr[0].ToString(), dr[1].ToString(),
                        //  Convert.ToDouble(dr[2].ToString()), parteInteira.ToString() + " cxs e " + parteFracionaria.ToString("n0") + " unid.",
                        //  Convert.ToInt32(dr[5].ToString()));
                        //transp.Produtos.AddProdutosRow(dr[0].ToString(), dr[1].ToString(), Convert.ToDouble(dr[2].ToString()), parteInteira.ToString() + " cxs e " + parteFracionaria.ToString("n0") + " unid.");
                    }
                    /*
                    try
                    {
                        int qtde_caixas = 0;
                        int sobra = 0;
                        int qtde_por_caixa = 0;
                        int qtde_produto = 0;
                        try { qtde_por_caixa = Convert.ToInt32(dr[3].ToString()); }
                        catch { }
                        try { qtde_produto = Convert.ToInt32(dr[2].ToString()); }
                        catch { }
                        if (qtde_por_caixa > 0)
                        {
                            qtde_caixas = qtde_produto / qtde_por_caixa;
                            sobra = qtde_produto % qtde_por_caixa;
                        }
                        transp.Produtos.AddProdutosRow(dr[0].ToString(), dr[1].ToString(), Convert.ToDouble(dr[2].ToString()), qtde_caixas.ToString() + " cxs e " + sobra.ToString() + " unid.");
                    }
                    catch { }
                     * */
                }
                crRomaneio_Produtos novo_ped = new crRomaneio_Produtos();
                novo_ped.SetDataSource(transp);
                form_imprimir imprime = new form_imprimir(novo_ped);
                imprime.Show();
            }
            catch (Exception ex)
            {
                fbConnection1.Close();
                MessageBox.Show(ex.Message);
            }

        }

        private void tb_n_pedido_TextChanged(object sender, EventArgs e)
        {

            try
            {
                dsPedidos_venda.Tables["PEDIDOS_VENDA"].DefaultView.RowFilter = " N_PED_VENDA = " + tb_n_pedido.Text + " or COD_PEDIDO_PAI_PED_VENDA = " + tb_n_pedido.Text;
                somar_totais();
                contar_pedidos();
                formatarDgv();
            }
            catch
            {
                dsPedidos_venda.Tables["PEDIDOS_VENDA"].DefaultView.RowFilter = " N_PED_VENDA IS NOT NULL";
                somar_totais();
                formatarDgv();
            }
        }

        private void tb_valor_TextChanged(object sender, EventArgs e)
        {

            try
            {
                dsPedidos_venda.Tables["PEDIDOS_VENDA"].DefaultView.RowFilter = " VALOR_total_ped_venda = " + tb_valor.Text;
                somar_totais();
                contar_pedidos();
                formatarDgv();
            }
            catch
            {
                dsPedidos_venda.Tables["PEDIDOS_VENDA"].DefaultView.RowFilter = " N_PED_VENDA IS NOT NULL";
                somar_totais();
                formatarDgv();
            }
        }

        private void tb_produto_TextChanged(object sender, EventArgs e)
        {

        }

        private void buscar_dados_estoque(string cod_estoque, out string cod_item, out string descricao_item, out string ncm_item, out string unidade_item)
        {
            cod_item = ""; descricao_item = ""; ncm_item = ""; unidade_item = "";
            try
            {
                FbCommand selectLotes = new FbCommand();
                selectLotes.Connection = fbConnection1;
                selectLotes.CommandText =
                    @"SELECT * FROM ESTOQUE 
                    WHERE COD_ESTOQUE = '" + cod_estoque + "'";
                FbDataAdapter datSelectLotes = new FbDataAdapter();
                datSelectLotes.SelectCommand = selectLotes;
                DataTable dtSelectLotes = new DataTable();
                datSelectLotes.Fill(dtSelectLotes);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelectLotes.Rows)
                {
                    cod_item = dr["item_estoque"].ToString();
                    descricao_item = dr["DESCRICAO_ESTOQUE"].ToString();
                    ncm_item = dr["NCM_ESTOQUE"].ToString();
                    unidade_item = dr["UNIDADE_ESTOQUE"].ToString();
                }

            }
            catch { fbConnection1.Close(); }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (cb_Nao_fechados.Checked)
            {
                DataTable dtFaltantes = new DataTable();
                DataColumn col_cod = new DataColumn();
                col_cod.ColumnName = "COD";
                DataColumn col_qtde_necessaria = new DataColumn();
                col_qtde_necessaria.ColumnName = "QTDE_NECESSARIA";
                //table.Columns[2].DataType = typeof (Int32);
                col_qtde_necessaria.DataType = typeof(double);
                DataColumn col_estoque = new DataColumn();
                col_estoque.ColumnName = "ESTOQUE";
                col_estoque.DataType = typeof(double);
                DataColumn col_saldo = new DataColumn();
                col_saldo.ColumnName = "SALDO";
                col_saldo.DataType = typeof(double);
                dtFaltantes.Columns.Add(col_cod);
                dtFaltantes.Columns.Add(col_qtde_necessaria);
                dtFaltantes.Columns.Add(col_estoque);
                dtFaltantes.Columns.Add(col_saldo);

                DataTable dtResumo = new DataTable();
                DataColumn col_cod1 = new DataColumn();
                col_cod1.ColumnName = "COD";
                DataColumn col_qtde_necessaria1 = new DataColumn();
                col_qtde_necessaria1.ColumnName = "QTDE_NECESSARIA";
                col_qtde_necessaria1.DataType = typeof(double);
                DataColumn col_estoque1 = new DataColumn();
                col_estoque1.ColumnName = "ESTOQUE";
                col_estoque1.DataType = typeof(double);
                DataColumn col_saldo1 = new DataColumn();
                col_saldo1.ColumnName = "SALDO";
                col_saldo1.DataType = typeof(double);
                dtResumo.Columns.Add(col_cod1);
                dtResumo.Columns.Add(col_qtde_necessaria1);
                dtResumo.Columns.Add(col_estoque1);
                dtResumo.Columns.Add(col_saldo1);

                bool falta_material = false;
                string where_pedidos = "WHERE 0 = 0";
                for (int i = 0; i < dgvPedidos.Rows.Count; i++)
                {
                    if (i == 0)
                        where_pedidos += " and (iped.COD_PEDIDO_ITEM_VENDA = '" + dgvPedidos.Rows[i].Cells["col_cod"].Value.ToString() + "' ";
                    else
                    {
                        where_pedidos += " or iped.COD_PEDIDO_ITEM_VENDA = '" + dgvPedidos.Rows[i].Cells["col_cod"].Value.ToString() + "' ";
                    }
                }
                if (where_pedidos != "WHERE 0 = 0 ")
                    where_pedidos += ")";

                FbCommand select = new FbCommand();
                select.CommandText =
                      @"select  prod.COD_FORNECEDOR_PRODUTO, prod.descricao_produto, sum(iped.qtde_item_venda)   
                    from itens_pedido_venda iped 
                    inner join pedidos_venda pv on iped.COD_PEDIDO_ITEM_VENDA = pv.COD_PED_VENDA 
                    inner join produtos prod on cast(iped.cod_prod_item_venda as varchar(30)) = cast(prod.COD_FORNECEDOR_PRODUTO as varchar(30)) " +
                        where_pedidos +
                    @"group by prod.descricao_produto,  prod.COD_FORNECEDOR_PRODUTO
                     ORDER BY 1";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    FbCommand selectItens = new FbCommand();
                    selectItens.Connection = fbConnection1;
                    fbConnection1.Open();
                    selectItens.CommandText =
                       @"select  sum(QTDE_ITEM_VENDA) 
from itens_pedido_venda iped
inner join pedidos_venda pv on iped.COD_PEDIDO_ITEM_VENDA = pv.COD_PED_VENDA 
where COD_PROD_ITEM_VENDA = '" + dr["COD_FORNECEDOR_PRODUTO"].ToString() + @"' and (pv.BAIXADO_ESTOQUE_PED_VENDA IS NULL OR pv.BAIXADO_ESTOQUE_PED_VENDA = 0)";

                    FbDataAdapter datSelectItens = new FbDataAdapter();
                    datSelectItens.SelectCommand = selectItens;
                    DataTable dtSelectItens = new DataTable();
                    datSelectItens.Fill(dtSelectItens);
                    fbConnection1.Close();

                    double qtde = 0; // Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_qtde"].Value.ToString());
                    foreach (DataRow dr0 in dtSelectItens.Rows)
                    {
                        try
                        {
                            qtde = Convert.ToDouble(dr0[0].ToString());
                        }
                        catch { }
                    }
                    try
                    {
                        FbCommand select1 = new FbCommand();
                        select1.Connection = fbConnection1;
                        fbConnection1.Open();
                        select1.CommandText =
                           @"select iprod.cod_estoque_ip, sum(iprod.qtde_ip * prok.qtde_pk) as qtde_mp
from produtos prod
left join produtos_kit prok on prod.cod_produto = prok.cod_kit_pk
left join itens_produto iprod on prok.cod_produto_pk = iprod.cod_produto_ip
where  prod.cod_fornecedor_produto = '" + dr["COD_FORNECEDOR_PRODUTO"].ToString() + @"'
group by iprod.cod_estoque_ip";
                        FbDataAdapter datSelect1 = new FbDataAdapter();
                        datSelect1.SelectCommand = select1;
                        DataTable dtSelect1 = new DataTable();
                        datSelect1.Fill(dtSelect1);
                        fbConnection1.Close();
                        foreach (DataRow dr1 in dtSelect1.Rows)
                        {
                            if (dr1["cod_estoque_ip"].ToString() != "")
                            {
                                try
                                {
                                    FbCommand selectLotes = new FbCommand();
                                    selectLotes.Connection = fbConnection1;
                                    selectLotes.CommandText =
                                        @"SELECT SUM(lr.QTDE_LR) as QTDE_LR FROM LOTE_RECEBIMENTO lr 
                    inner join ITENS_NOTA_ENT inf on lr.COD_LR = inf.LOTE_ITEM_ENT 
                    WHERE COD_PRODUTO_LR = '" + dr1["cod_estoque_ip"].ToString() + "'";
                                    FbDataAdapter datSelectLotes = new FbDataAdapter();
                                    datSelectLotes.SelectCommand = selectLotes;
                                    DataTable dtSelectLotes = new DataTable();
                                    datSelectLotes.Fill(dtSelectLotes);

                                    fbConnection1.Close();
                                    decimal qtde_necessaria = Convert.ToDecimal(qtde) * Convert.ToDecimal(dr1["qtde_mp"].ToString());
                                    decimal qtde_mp = Convert.ToDecimal(qtde) * Convert.ToDecimal(dr1["qtde_mp"].ToString());
                                    decimal qtde_empenhada = 0;
                                    decimal qtde_encontrada = 0;
                                    bool finalizado = false;
                                    string cod_item = "", descricao_item = "", qtde_item = "", ncm_item = "", valor_item = "", cfop_item = "", unidade_item = "";
                                    buscar_dados_estoque(dr1["cod_estoque_ip"].ToString(), out cod_item, out descricao_item, out ncm_item, out unidade_item);
                                    decimal estoque = 0;
                                    foreach (DataRow drLotes in dtSelectLotes.Rows)
                                    {
                                        try
                                        {

                                            decimal qtde_a_inserir_do_lote = 0;
                                            qtde_encontrada = Convert.ToDecimal(drLotes["QTDE_LR"].ToString());
                                            estoque = qtde_encontrada;
                                            if (qtde_encontrada >= qtde_necessaria)
                                            {
                                                qtde_empenhada = qtde_necessaria;
                                                qtde_a_inserir_do_lote = qtde_necessaria;

                                                finalizado = true;
                                            }
                                            else
                                            {
                                                qtde_a_inserir_do_lote = qtde_encontrada;
                                                qtde_empenhada += qtde_encontrada;
                                                qtde_necessaria = qtde_necessaria - qtde_encontrada;

                                            }

                                            qtde_item = qtde_a_inserir_do_lote.ToString();


                                            //    unidade_item = "KG";
                                            //if (tb_estado_cliente.Text == estado_empresa)
                                            //    cfop_item = "5902";
                                            //if (tb_estado_cliente.Text != estado_empresa)
                                            //    cfop_item = "6902";

                                            //inserir_itens_retorno(cod_item, descricao_item + " NF: " + drLotes["NOTA_FISCAL_LR"].ToString(), qtde_item, ncm_item, valor_item, cfop_item, drLotes["COD_LR"].ToString(), unidade_item);
                                        }

                                        catch { }

                                    }
                                    if (!finalizado)
                                    {
                                        falta_material = true;

                                        dtFaltantes.Rows.Add(cod_item, Convert.ToDouble(qtde_mp), Convert.ToDouble(estoque), Convert.ToDouble(qtde_necessaria));
                                        // MessageBox.Show("O material " + cod_item + " não tem o estoque necessário. Disponível: " + qtde_empenhada.ToString("n3") + ". Necessária: " + qtde_mp.ToString("n3") + ". Por favor verifique antes de continuar");
                                    }
                                }
                                catch (Exception ex)
                                {
                                    fbConnection1.Close();
                                    MessageBox.Show(ex.Message);
                                }
                            }
                            else
                            {
                               //MessageBox.Show("O Produto " + dr["COD_FORNECEDOR_PRODUTO"].ToString() + " não tem material cadastrado");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        fbConnection1.Close();
                        MessageBox.Show(ex.Message);
                    }

                }

                foreach (DataRow dr in dtFaltantes.Rows)
                {
                    if (dtResumo.Rows.Count == 0 || dtResumo.Select("COD = '" + dr[0].ToString() + "'").Length == 0)
                    {
                        Decimal _qtde_necessaria = Convert.ToDecimal(dtFaltantes.Compute("SUM(QTDE_NECESSARIA)", "COD = '" + dr[0].ToString() + "'"));
                        dtResumo.Rows.Add(dr[0].ToString(), Convert.ToDouble(_qtde_necessaria.ToString()),
                            Convert.ToDouble(dr[2].ToString()), Convert.ToDouble(dr[3].ToString()));
                    }
                }

                if (dtResumo.Rows.Count > 0)
                {
                    MessageBox.Show("Para atender esse pedido serão necessários os materiais adicionais a seguir.");
                    dtResumo.TableName = "MaterialFaltantePedidos" + DateTime.Now.Millisecond.ToString();
                    gerarExcel(dtResumo, @"c:\\evolucao\\excel\" + dtResumo.TableName + ".xlsx");
                    System.Diagnostics.Process.Start(@"c:\\evolucao\\excel\" + dtResumo.TableName + ".xlsx");
                }
                if (!falta_material)
                {
                    MessageBox.Show("Os materiais necessários nesse pedido estão disponíveis");
                }
            }
            else
            {
                MessageBox.Show("Só é possível verificar o Material Necessário em Pedidos não fechado");
            }

        }


        private void gerarExcel(DataTable table, string nomeArquivo)
        {
            if (!Directory.Exists(@"c:\\evolucao\\excel\"))
            {
                Directory.CreateDirectory(@"c:\\evolucao\\excel\");
            }

            //Creae an Excel application instance
            Excel.Application excelApp = new Excel.Application();
            if (criarArquivoExcel(nomeArquivo))
            {
                //Create an Excel workbook instance and open it from the predefined location
                Excel.Workbook excelWorkBook = excelApp.Workbooks.Open(nomeArquivo);

                // foreach (DataTable table in tb)
                // {
                //Add a new worksheet to workbook with the Datatable name
                Excel.Worksheet excelWorkSheet = excelWorkBook.Sheets.Add();
                excelWorkSheet.Name = table.TableName;

                for (int i = 1; i < table.Columns.Count + 1; i++)
                {
                    excelWorkSheet.Cells[1, i] = table.Columns[i - 1].ColumnName;
                }

                for (int j = 0; j < table.Rows.Count; j++)
                {
                    for (int k = 0; k < table.Columns.Count; k++)
                    {

                        bool _double = false;
                        bool _int = false;
                        try
                        {
                            Convert.ToDouble(table.Rows[j].ItemArray[k].ToString());
                            try
                            {
                                Convert.ToInt64(table.Rows[j].ItemArray[k].ToString());
                                _int = true;
                            }
                            catch
                            {
                                _double = true;
                            }
                        }
                        catch { }
                        bool _data = false;
                        try
                        {
                            Convert.ToDateTime(table.Rows[j].ItemArray[k].ToString());
                            _data = true;
                        }
                        catch { }
                        if (_double)
                        {
                            excelWorkSheet.Cells[j + 2, k + 1] = Convert.ToDouble(table.Rows[j].ItemArray[k].ToString()).ToString("n2");
                        }
                        else
                        {
                            if (_int)
                            {
                                excelWorkSheet.Cells[j + 2, k + 1] = Convert.ToInt64(table.Rows[j].ItemArray[k].ToString()).ToString();
                            }
                            else
                            {
                                if (_data)
                                {
                                    excelWorkSheet.Cells[j + 2, k + 1] = Convert.ToDateTime(table.Rows[j].ItemArray[k].ToString()).ToShortDateString();
                                }
                                else
                                {
                                    excelWorkSheet.Cells[j + 2, k + 1] = table.Rows[j].ItemArray[k].ToString();
                                }
                            }
                        }



                    }
                }
                // }

                excelWorkBook.Save();
                excelWorkBook.Close();
                excelApp.Quit();
            }
        }

        private bool criarArquivoExcel(string nomeArquivo)
        {
            try
            {
                Excel.Application xlApp;
                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;

                xlApp = new Excel.Application();
                xlWorkBook = xlApp.Workbooks.Add(misValue);

                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                // xlWorkSheet.Cells[1, 1] = "http://www.macoratti.net";

                xlWorkBook.SaveAs(nomeArquivo, Excel.XlFileFormat.xlOpenXMLWorkbook,
    System.Reflection.Missing.Value, System.Reflection.Missing.Value, false, false,
    Excel.XlSaveAsAccessMode.xlShared, false, false, System.Reflection.Missing.Value,
    System.Reflection.Missing.Value, System.Reflection.Missing.Value);
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();

                liberarObjetos(xlWorkSheet);
                liberarObjetos(xlWorkBook);
                liberarObjetos(xlApp);
                return true;
                // MessageBox.Show("O arquivo Excel foi criado com sucesso. Você pode encontrá-lo em : " + nomeArquivo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
                return false;
            }
        }

        private void liberarObjetos(Object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Ocorreu um erro durante a liberação do objeto " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void cbStatus_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbStatus.Text == "")
            {
                dsPedidos_venda.Tables["PEDIDOS_VENDA"].DefaultView.RowFilter = "STATUS_PED_VENDA = '" + cbStatus.Text + "' or STATUS_PED_VENDA is null";
            }
            else
                dsPedidos_venda.Tables["PEDIDOS_VENDA"].DefaultView.RowFilter = "STATUS_PED_VENDA = '" + cbStatus.Text + "'";
            somar_totais();
            contar_pedidos();
            formatarDgv();
        }

        private void cbTipo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbTipo.Text == "")
            {
                dsPedidos_venda.Tables["PEDIDOS_VENDA"].DefaultView.RowFilter = "TIPO_PED_VENDA = '" + cbTipo.Text + "' or TIPO_PED_VENDA is null";
            }
            else
                dsPedidos_venda.Tables["PEDIDOS_VENDA"].DefaultView.RowFilter = "TIPO_PED_VENDA = '" + cbTipo.Text + "'";
            somar_totais();
            contar_pedidos();
            formatarDgv();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {

                string where_pedidos = "WHERE 0 = 0";
                for (int i = 0; i < dgvPedidos.Rows.Count; i++)
                {
                    if (i == 0)
                        where_pedidos += " and (iped.COD_PEDIDO_ITEM_VENDA = '" + dgvPedidos.Rows[i].Cells["col_cod"].Value.ToString() + "' ";
                    else
                    {
                        where_pedidos += " or iped.COD_PEDIDO_ITEM_VENDA = '" + dgvPedidos.Rows[i].Cells["col_cod"].Value.ToString() + "' ";
                    }
                }
                if (where_pedidos != "WHERE 0 = 0 ")
                    where_pedidos += ")";
                dsPedidos ped = new dsPedidos();
                FbCommand select = new FbCommand();
                select.CommandText =
                      @"select pv.N_PED_VENDA as Pedido, pv.CLIENTE_PED_VENDA as Cliente, iped.cod_prod_item_venda as Cod_Produto, iped.descricao_prod_item_venda as Descricao,
                    iped.UNIDADE_PROD_ITEM_VENDA as Un, iped.qtde_item_venda as Qtde,
                    iped.VALOR_UNIT_PROD_ITEM_VENDA as Valor_Unit, iped.VALOR_TOTAL_PROD_ITEM_VENDA as Valor_Total, 
                    DATA_ENTREGA_ITEM_VENDA as Data_Entrega,  iped.CONFIRMADO_ITEM_VENDA as Confirmado, iped.PEDIDO_CLIENTE_ITEM_VENDA as Pedido_Cliente, iped.ITEM_LIBERACAO_ITEM_VENDA as Item_Separacao, 
                    iped.ITEM_PED_CLIENTE_ITEM_VENDA as Item_Pedido, iped.FINALIZADO_ITEM_VENDA as Finalizado, iped.QTDE_FATURADA_ITEM_VENDA as Qtde_Faturada
                    from itens_pedido_venda iped 
                    inner join pedidos_venda pv on iped.COD_PEDIDO_ITEM_VENDA = pv.COD_PED_VENDA " + 
                        where_pedidos +
                    @" ORDER BY 1";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(ped.ITENS_CONFIRMADOS);
                fbConnection1.Close();
                if (ped.ITENS_CONFIRMADOS.Rows.Count > 0)
                {
                    //dtResumo.TableName = "MaterialFaltantePedidos" + DateTime.Now.Millisecond.ToString();
                    gerarExcel(ped.ITENS_CONFIRMADOS, @"c:\\evolucao\\excel\" + ped.ITENS_CONFIRMADOS.TableName + ".xlsx");
                    System.Diagnostics.Process.Start(@"c:\\evolucao\\excel\" + ped.ITENS_CONFIRMADOS.TableName + ".xlsx");
                }

                
            }
            catch (Exception ex)
            {
                fbConnection1.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvPedidos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                // Certifique-se de que a célula não está no cabeçalho da coluna
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    // Nome da coluna desejada
                    string nomeColuna = "STATUS_PED_VENDA";

                    // Verifica se a célula atual está na coluna desejada
                    if (dgvPedidos.Columns[e.ColumnIndex].Name == nomeColuna)
                    {
                        // Verifica se o valor na célula é "Confirmado"
                        if (e.Value != null && e.Value.ToString() == "Confirmado")
                        {
                            // Define a cor de fundo apenas para essa célula
                            e.CellStyle.BackColor = Color.GreenYellow;
                        }
                        else
                        {
                            if (e.Value != null && e.Value.ToString() == "Orçamento")
                            {
                                // Define a cor de fundo apenas para essa célula
                                e.CellStyle.BackColor = Color.Yellow;
                            }
                            else
                            {
                                if (e.Value != null && e.Value.ToString() == "Declinado")
                                {
                                    // Define a cor de fundo apenas para essa célula
                                    e.CellStyle.BackColor = Color.OrangeRed;
                                }
                                else
                                {
                                    if (e.Value != null && e.Value.ToString() == "Faturado")
                                    {
                                        // Define a cor de fundo apenas para essa célula
                                        e.CellStyle.BackColor = Color.Green;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Lida com exceções, se necessário
                //  MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //    try
        //    {
        //        if (dgvPedidos.Rows[e.RowIndex].Cells["STATUS_PED_VENDA"].Value.ToString() == "Confirmado") // Verifica se a célula pertence a uma linha de dados (e não ao cabeçalho)
        //        {

        //            e.CellStyle.BackColor = Color.GreenYellow;
        //        }
        //        else
        //        {
        //            if (dgvPedidos.Rows[e.RowIndex].Cells["STATUS_PED_VENDA"].Value.ToString() == "Orçamento") // Verifica se a célula pertence a uma linha de dados (e não ao cabeçalho)
        //            {

        //                e.CellStyle.BackColor = Color.Yellow;
        //            }
        //            else
        //            {
        //                if (dgvPedidos.Rows[e.RowIndex].Cells["STATUS_PED_VENDA"].Value.ToString() == "Declinado") // Verifica se a célula pertence a uma linha de dados (e não ao cabeçalho)
        //                {

        //                    e.CellStyle.BackColor = Color.OrangeRed;
        //                }
        //            }
        //        }
        //    }
        //    catch { }
        //}
        

        
    }
}