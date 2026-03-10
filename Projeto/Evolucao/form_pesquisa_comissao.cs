using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.IO;
using System.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO.Compression;
using Microsoft.CSharp.RuntimeBinder;
namespace Evolucao
{
    public partial class form_pesquisa_comissao : Form
    {
        DataTable dtSelect_metas = new DataTable();
        public string cod_ped_escolhido;
        public string[] pedidos_selecionados = new string[500];
        public bool consulta; public bool selecao_nf;
        public int numero_pedidos;
        bool erro = false;
        ArrayList vendedores;
        public string usuario;

        public form_pesquisa_comissao()
        {
            InitializeComponent();
        }




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



        private void button3_Click(object sender, EventArgs e)
        {
            form_localiza_produto localiza_item = new form_localiza_produto(false,cnpj_empresa);
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

        private void button4_Click(object sender, EventArgs e)
        {
            form_vendedores vend = new form_vendedores();
            try
            {
                //vend.usuario = usuario;
               // vend.empresa = razao_social_empresa;
                vend.ShowDialog();
            }
            finally
            {
                vend.Dispose();
                tb_cod_vendedor.Text = vend.cod_vendedor_escolhido;
                tb_nome_vendedor.Text = vend.vendedor_escolhido;
            }
        }

        private void cb_vendedor_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_vendedor.Checked == false)
            {
                tb_cod_vendedor.Text =  "";
                tb_nome_vendedor.Text =  "";
            }
        }



        private void button5_Click(object sender, EventArgs e)
        {
            form_localiza_cliente localiza_cliente = new form_localiza_cliente(true, cnpj_empresa);
            try
            {
                //localiza_cliente.usuario = usuario;
                localiza_cliente.ShowDialog();
            }
            finally
            {
                localiza_cliente.Dispose();
                tb_nome_cliente.Text = localiza_cliente.cliente_escolhido;
                tb_cod_cliente.Text = localiza_cliente.cod_escolhido;
                tb_cnpj.Text = localiza_cliente.cnpj_escolhido;
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            form_vendedores vend = new form_vendedores();
            try
            {
                //vend.usuario = usuario;
                //vend.empresa = razao_social_empresa;
                vend.ShowDialog();
            }
            finally
            {
                tb_nome_vendedor.Text = vend.vendedor_escolhido;
            }
        }

        private void tb_nome_vendedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {

        }

        private void dtInicial_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click_2(object sender, EventArgs e)
        {
            try
            {
                dsPedidos_venda.Clear();

                //string grupo = cbxGrupo.SelectedItem.ToString();

                string vendedor = "", cliente = "", fornecedor = "", _familia =  "";

                if (tbFamilia.Text != "")
                    _familia = " AND p.NOME_FAMILIA_PRODUTO = '" + tbFamilia.Text + "' ";


                if (cb_vendedor.Checked == true)
                {
                    vendedor = " and pv.cod_vendedor_ped_venda = '" + tb_cod_vendedor.Text + "' ";
                }
                if (cb_cliente.Checked == true)
                {
                    cliente = " AND nf.CLIENTE_FORN_NF = '" + tb_nome_cliente.Text + "'";
                }
                if (cb_fornecedor.Checked == true)
                {
                    fornecedor = " and p.nome_fornecedor_produto = '" + tb_nome_fornecedor.Text + "' ";
                }
                string pis =  "";
                if (cb_com_pis.Checked)
                    pis = " AND p.PIS_COFINS_PRODUTO = '1'";

                string produto =  "";
                if (cbProduto.Checked)
                {
                    produto = " AND p.cod_produto = '" + tb_cod_produto.Text + "'";
                }

                string _cfop = " and (item.cfop_item like '_1__'	" +
                   "	or item.cfop_item like '_4__') ";
                   
                if (cbCfop.Checked)
                {
                    _cfop = "  and (item.cfop_item = '" + tb_n_cfop.Text + "'	" +
                    "	or item.cfop_item = '6" + tb_n_cfop.Text.Substring(1, 3) + "' ) ";
                }



                FbCommand select = new FbCommand();
                FbDataAdapter datSelect = new FbDataAdapter();
                DataTable dtSelect = new DataTable();

                select.CommandText =

                   // "select" +
                    // "   pv.vendedor_ped_venda vendedor, " +
                    // "   p.descricao_grupo_produto grupo, " +
                    // "   p.descricao_sub_grupo_produto subgrupo, " + 
                    // "   sum(item.preco_total_item)total " +
                    // "from itens_nota item " +
                    // "   inner join nota_fiscal nf " +
                    // "       on nf.n_nf = item.nf_item " +
                    // "   inner join pedidos_nf pnf " + 
                    // "       on pnf.nf_pedido_nf = nf.n_nf " +
                    // "   inner join pedidos_venda pv " +
                    // "       on pv.cod_ped_venda = pnf.n_pedido_nf " +
                    // "   inner join produtos p " +
                    // "       on (CAST(p.cod_produto AS VARCHAR(50)) = CAST(item.cod_item AS VARCHAR(50)) " + 
                    // " or CAST(p.cod_fornecedor_produto AS VARCHAR(50)) = CAST(item.cod_item AS VARCHAR(50)))" +
                    // "   inner join cfo " +
                    // "       on cfo.n_cfo = item.cfop_item " +
                    // "where nf.data_emissao_nf >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") + "' " +
                    // "   and nf.data_emissao_nf <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                    // cliente + 
                    // vendedor + 
                    // fornecedor +
                    // pis +
                    // produto +
                    // "   and nf.status_nfe like '%Autorizada%' " +
                    //_cfop +
                    // " group by " +
                    // "   pv.vendedor_ped_venda, " +
                    // "   p.descricao_grupo_produto, " +
                    // "   p.descricao_sub_grupo_produto";

                   "select" +
                    "   pv.vendedor_ped_venda vendedor, " +
                    "   sum(item.preco_total_item)total " +
                    "from itens_nota item " +
                    "   inner join nota_fiscal nf " +
                    "       on nf.n_nf = item.nf_item " +
                    "   inner join pedidos_nf pnf " +
                    "       on pnf.nf_pedido_nf = nf.n_nf " +
                    "   inner join pedidos_venda pv " +
                    "       on pv.cod_ped_venda = pnf.n_pedido_nf " +
                    "   inner join produtos p " +
                    "       on CAST(p.cod_fornecedor_produto AS VARCHAR(50)) = CAST(item.cod_item AS VARCHAR(50))" +
                    "where nf.data_emissao_nf >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") + "' " +
                    "   and nf.data_emissao_nf <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                    cliente +
                    vendedor +
                    fornecedor +
                    pis +
                    produto +
                    _familia +
                    "   and nf.status_nfe like '%Autorizada%' " +
                   _cfop +
                    " group by " +
                    "   pv.vendedor_ped_venda";

                select.Connection = fbConnection1;
                fbConnection1.Open();
                datSelect.SelectCommand = select;
                datSelect.Fill(dtSelect);
                fbConnection1.Close();

                dgvPedidos.DataSource = dtSelect;
                acertar_dgv();
                somar_total();

                /*AJUSTAR DADOS PARA O RELATÓRIO*/
                /*vendedores = new ArrayList();
                string vendedorAnterior =  "";
                int i = 0;
                
                foreach(DataRow dr in dtSelect.Rows)
                {
                    if (vendedorAnterior == "")
                    {
                        vendedores.Add(new ArrayList() { 
                            dr[0].ToString(),
                            dr[1].ToString() == "FARINHA" ? Convert.ToDouble(dr[3].ToString()) : 0,
                            dr[1].ToString() == "MIX" ? Convert.ToDouble(dr[3].ToString()) : 0,
                            //CHOCOLATES
                            new ArrayList()
                            {
                              dr[2].ToString() == "BARRINHAS" ? Convert.ToDouble(dr[3].ToString()) : 0,  
                              dr[2].ToString() == "OUTROS" ? Convert.ToDouble(dr[3].ToString()) : 0
                            },
                            dr[1].ToString() == "OUTROS" ? Convert.ToDouble(dr[3].ToString()) : 0,
                            dr[1].ToString() == "PATES" ? Convert.ToDouble(dr[3].ToString()) : 0,
                            dr[1].ToString() == "CAFÉ" ? Convert.ToDouble(dr[3].ToString()) : 0,
                            new ArrayList()
                            {
                              dr[2].ToString() == "AZEITE" ? Convert.ToDouble(dr[3].ToString()) : 0,  
                              dr[2].ToString() == "DIV.LAV." ? Convert.ToDouble(dr[3].ToString()) : 0
                            },
                            dr[1].ToString() == "VINAGRE" ? Convert.ToDouble(dr[3].ToString()) : 0,
                            0
                        });

                        ((ArrayList)vendedores[i])[9] = 
                            Convert.ToDouble(((ArrayList)vendedores[i])[1].ToString()) +
                            Convert.ToDouble(((ArrayList)vendedores[i])[2].ToString()) +
                            Convert.ToDouble(((ArrayList)((ArrayList)vendedores[i])[3])[0].ToString()) +
                            Convert.ToDouble(((ArrayList)((ArrayList)vendedores[i])[3])[1].ToString()) +
                            Convert.ToDouble(((ArrayList)vendedores[i])[4].ToString()) +
                            Convert.ToDouble(((ArrayList)vendedores[i])[5].ToString()) +
                             Convert.ToDouble(((ArrayList)vendedores[i])[6].ToString()) +
                             Convert.ToDouble(((ArrayList)((ArrayList)vendedores[i])[7])[0].ToString()) +
                            Convert.ToDouble(((ArrayList)((ArrayList)vendedores[i])[7])[1].ToString()) +
                            Convert.ToDouble(((ArrayList)vendedores[i])[8].ToString())
                            ;

                        vendedorAnterior = dr[0].ToString();
                    }
                    else
                    {
                        if (dr[0].ToString() == vendedorAnterior)
                        {
                            ((ArrayList)vendedores[i])[1] = dr[1].ToString() == "FARINHA" ? Convert.ToDouble(dr[3].ToString()) : ((ArrayList)vendedores[i])[1];
                            ((ArrayList)vendedores[i])[2] = dr[1].ToString() == "MIX" ? Convert.ToDouble(dr[3].ToString()) : ((ArrayList)vendedores[i])[2];
                            ((ArrayList)((ArrayList)vendedores[i])[3])[0] = dr[2].ToString() == "BARRINHAS" ? Convert.ToDouble(dr[3].ToString()) : ((ArrayList)((ArrayList)vendedores[i])[3])[0];
                            ((ArrayList)((ArrayList)vendedores[i])[3])[1] = dr[2].ToString() == "OUTROS" ? Convert.ToDouble(dr[3].ToString()) : ((ArrayList)((ArrayList)vendedores[i])[3])[1];
                            ((ArrayList)vendedores[i])[4] = dr[1].ToString() == "OUTROS" ? Convert.ToDouble(dr[3].ToString()) : ((ArrayList)vendedores[i])[4];
                            ((ArrayList)vendedores[i])[5] = dr[1].ToString() == "PATES" ? Convert.ToDouble(dr[3].ToString()) : ((ArrayList)vendedores[i])[5];
                            ((ArrayList)vendedores[i])[6] = dr[1].ToString() == "CAFÉ" ? Convert.ToDouble(dr[3].ToString()) : ((ArrayList)vendedores[i])[6];
                            ((ArrayList)((ArrayList)vendedores[i])[7])[0] = dr[2].ToString() == "AZEITE" ? Convert.ToDouble(dr[3].ToString()) : ((ArrayList)((ArrayList)vendedores[i])[7])[0];
                            ((ArrayList)((ArrayList)vendedores[i])[7])[1] = dr[2].ToString() == "DIV.LAV." ? Convert.ToDouble(dr[3].ToString()) : ((ArrayList)((ArrayList)vendedores[i])[7])[1];
                            ((ArrayList)vendedores[i])[8] = dr[1].ToString() == "VINAGRE" ? Convert.ToDouble(dr[3].ToString()) : ((ArrayList)vendedores[i])[8];

                            ((ArrayList)vendedores[i])[9] =
                            Convert.ToDouble(((ArrayList)vendedores[i])[1].ToString()) +
                            Convert.ToDouble(((ArrayList)vendedores[i])[2].ToString()) +
                            Convert.ToDouble(((ArrayList)((ArrayList)vendedores[i])[3])[0].ToString()) +
                            Convert.ToDouble(((ArrayList)((ArrayList)vendedores[i])[3])[1].ToString()) +
                            Convert.ToDouble(((ArrayList)vendedores[i])[4].ToString()) +
                            Convert.ToDouble(((ArrayList)vendedores[i])[5].ToString()) +
                             Convert.ToDouble(((ArrayList)vendedores[i])[6].ToString()) +
                             Convert.ToDouble(((ArrayList)((ArrayList)vendedores[i])[7])[0].ToString()) +
                            Convert.ToDouble(((ArrayList)((ArrayList)vendedores[i])[7])[1].ToString()) +
                            Convert.ToDouble(((ArrayList)vendedores[i])[8].ToString())
                            ;
                            vendedorAnterior = dr[0].ToString();                        
                        }
                        else
                        {
                            i++;
                            vendedores.Add(new ArrayList() { 
                            dr[0].ToString(),
                            dr[1].ToString() == "FARINHA" ? Convert.ToDouble(dr[3].ToString()) : 0,
                            dr[1].ToString() == "MIX" ? Convert.ToDouble(dr[3].ToString()) : 0,
                            //CHOCOLATES
                            new ArrayList()
                            {
                              dr[2].ToString() == "BARRINHAS" ? Convert.ToDouble(dr[3].ToString()) : 0,  
                              dr[2].ToString() == "OUTROS" ? Convert.ToDouble(dr[3].ToString()) : 0
                            },
                            dr[1].ToString() == "OUTROS" ? Convert.ToDouble(dr[3].ToString()) : 0,
                            dr[1].ToString() == "PATES" ? Convert.ToDouble(dr[3].ToString()) : 0,
                            dr[1].ToString() == "CAFÉ" ? Convert.ToDouble(dr[3].ToString()) : 0,
                            new ArrayList()
                            {
                              dr[2].ToString() == "AZEITE" ? Convert.ToDouble(dr[3].ToString()) : 0,  
                              dr[2].ToString() == "DIV.LAV." ? Convert.ToDouble(dr[3].ToString()) : 0
                            },
                            dr[1].ToString() == "VINAGRE" ? Convert.ToDouble(dr[3].ToString()) : 0,
                            0

                        });

                            ((ArrayList)vendedores[i])[9] =
                             Convert.ToDouble(((ArrayList)vendedores[i])[1].ToString()) +
                             Convert.ToDouble(((ArrayList)vendedores[i])[2].ToString()) +
                             Convert.ToDouble(((ArrayList)((ArrayList)vendedores[i])[3])[0].ToString()) +
                             Convert.ToDouble(((ArrayList)((ArrayList)vendedores[i])[3])[1].ToString()) +
                             Convert.ToDouble(((ArrayList)vendedores[i])[4].ToString()) +
                             Convert.ToDouble(((ArrayList)vendedores[i])[5].ToString()) +
                              Convert.ToDouble(((ArrayList)vendedores[i])[6].ToString()) +
                              Convert.ToDouble(((ArrayList)((ArrayList)vendedores[i])[7])[0].ToString()) +
                             Convert.ToDouble(((ArrayList)((ArrayList)vendedores[i])[7])[1].ToString()) +
                             Convert.ToDouble(((ArrayList)vendedores[i])[8].ToString())
                             ;
                            vendedorAnterior = dr[0].ToString();                        
                        }
                    }
                }*/
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show("Houve um erro ao buscar os valores!\nErro: " + a.Message);
            }
        }

        private void acertar_dgv()
        {
            try
            {
                dgvPedidos.Columns[0].Width = 300;
                dgvPedidos.Columns[0].HeaderText = "Vendedor";

                //dgvPedidos.Columns[1].Width = 200; 
                //dgvPedidos.Columns[1].HeaderText = "Grupo";

                //dgvPedidos.Columns[2].Width = 200;
                //dgvPedidos.Columns[2].HeaderText = "Sub-Grupo";

                dgvPedidos.Columns[1].Width = 100;
                dgvPedidos.Columns[1].HeaderText = "Total";
                dgvPedidos.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvPedidos.Columns[1].DefaultCellStyle.Format = "n2";

                dgvPedidos.Sort(dgvPedidos.Columns[0], ListSortDirection.Ascending);

            }
            catch { }

        }

        private void somar_total()
        {
            double total = 0;
            for (int i = 0; i < dgvPedidos.RowCount; i++)
            {
                try
                {
                    total = total + Convert.ToDouble(dgvPedidos.Rows[i].Cells[1].Value);
                }
                catch
                { }
            }
            tb_valor_total.Text = total.ToString("n2");
        }

        private void fbConnection1_InfoMessage(object sender, FirebirdSql.Data.FirebirdClient.FbInfoMessageEventArgs e)
        {

        }

       
        private void dgvPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void definir_acessos(string _cod)
        {
            try
            {
                string _cod_usuario = "", _senha = "", _nome_usuario = "", _pcp = "", _faturamento = "", _estoque = "",
                    _compras = "", _financeiro = "", _orcamentos = "", _qualidade = "", _total = "", _transportes = "", _nivel_acesso = "";
                comando_select.Connection = fbConnection1;
                comando_select.CommandText = "SELECT * " +
                    "FROM USUARIOS WHERE COD_USUARIO = '" + _cod + "'";
                DataSet usuario = new DataSet();
                fbConnection1.Open();
                FbDataAdapter datUsuarios = new FbDataAdapter();
                datUsuarios.SelectCommand = comando_select;
                datUsuarios.Fill(usuario);

                foreach (DataRow dr in usuario.Tables[0].Rows)
                {
                    _nome_usuario = dr["NOME_USUARIO"].ToString();
                    _cod_usuario = dr["COD_USUARIO"].ToString();
                    _pcp = dr["PCP_USUARIO"].ToString();
                    _faturamento = dr["FATURAMENTO_USUARIO"].ToString();
                    _estoque = dr["ESTOQUE_USUARIO"].ToString();
                    _compras = dr["COMPRAS_USUARIO"].ToString();
                    _financeiro = dr["FINANCEIRO_USUARIO"].ToString();
                    _orcamentos = dr["ORCAMENTOS_USUARIO"].ToString();
                    _qualidade = dr["QUALIDADE_USUARIO"].ToString();
                    _total = dr["TOTAL_USUARIO"].ToString();
                    _nivel_acesso = dr["NIVEL_ACESSO_USUARIO"].ToString();
                    try
                    {
                        _transportes = dr["TRANSPORTES_USUARIO"].ToString();
                    }
                    catch { }
                }

                fbConnection1.Close();
                //Cadastros Gerais


                if (_nivel_acesso == "2")
                {
                    supervisor = " and v.SUPERVISOR_VENDEDOR = '" + _cod + "' ";
                    bt_cli_lucratividade.Visible = false;
                    bt_clientes_lucratividade.Visible = false;
                    bt_comissao_produto.Visible = false;
                    bt_comissao_recebimento.Visible = false;
                    bt_nfs_lucratividade.Visible = false;
                    bt_prod_lucratividade.Visible = false;
                    bt_vend_lucra_custo.Visible = false;
                    bt_cliente_lucra_custo.Visible = false;
                }
            }
            catch { fbConnection1.Close(); }
           

        }

        string supervisor =  "";
        private void form_pesquisa_comissao_Load(object sender, EventArgs e)
        {
            detectar_dados_empresa(out razao_social_empresa, out nome_fantasia_empresa, out cnpj_empresa, out ie_empresa, out im_empresa, out cnae_empresa, out endereco_empresa, out n_endereco_empresa,
      out complemento_empresa, out bairro_empresa, out cidade_empresa, out estado_empresa, out cep_empresa, out telefone_empresa, out cod_cidade_empresa, out pais_empresa,
      out cod_pais_empresa, out licenca_dll_nfe_empresa, out nome_certificado_nfe_empresa, out assunto_nfe_email_empresa, out smtp_nfe_empresa, out email_nfe_empresa,
      out senha_email_nfe_empresa, out logotipo_empresa, out proxy_empresa, out usuario_proxy_empresa, out senha_proxy_empresa, out crt_empresa, out portaEmailEmpresa, out sslEmpresa,
out serie_empresa, out boleto_pedido_empresa, out saida_estoque_pedido_empresa, out cod_forn_empresa, out cst_pis_empresa, out tipo_pis_empresa, out cst_cofins_empresa, out tipo_cofins_empresa);
            
            definir_acessos(usuario);
            //if (usuario == "5" && razao_social_empresa.Contains("LLOC")) //PETERSON
            //{
            //    supervisor = " and v.SUPERVISOR_VENDEDOR = '5' ";
            //    bt_cli_lucratividade.Visible = false;
            //    bt_clientes_lucratividade.Visible = false;
            //    bt_comissao_produto.Visible = false;
            //    bt_comissao_recebimento.Visible = false;
            //    bt_nfs_lucratividade.Visible = false;
            //    bt_prod_lucratividade.Visible = false;
                
            //}
            //carregaCombo();
        }

        //empresa
        string razao_social_empresa = "", nome_fantasia_empresa = "", cnpj_empresa = "", ie_empresa = "", im_empresa = "", cnae_empresa = "", endereco_empresa = "", n_endereco_empresa = "",
           complemento_empresa = "", bairro_empresa = "", cidade_empresa = "", estado_empresa = "", cep_empresa = "", telefone_empresa = "", cod_cidade_empresa = "", pais_empresa = "",
           cod_pais_empresa = "", licenca_dll_nfe_empresa = "", nome_certificado_nfe_empresa = "", assunto_nfe_email_empresa = "", smtp_nfe_empresa = "", email_nfe_empresa = "",
           senha_email_nfe_empresa = "", logotipo_empresa = "", proxy_empresa = "", usuario_proxy_empresa = "", senha_proxy_empresa = "", crt_empresa = "", portaEmailEmpresa = "",
           sslEmpresa = "", serie_empresa = "", boleto_pedido_empresa = "", saida_estoque_pedido_empresa = "", cod_forn_empresa = "", cst_pis_empresa = "", tipo_pis_empresa = "", cst_cofins_empresa = "", tipo_cofins_empresa =  "";


        private void detectar_dados_empresa(out string razao_social_empresa, out string nome_fantasia_empresa, out string cnpj_empresa, out string ie_empresa, out string im_empresa, out string cnae_empresa, out string endereco_empresa, out string n_endereco_empresa,
                  out string complemento_empresa, out string bairro_empresa, out string cidade_empresa, out string estado_empresa, out string cep_empresa, out string telefone_empresa, out string cod_cidade_empresa, out string pais_empresa,
                  out string cod_pais_empresa, out string licenca_dll_nfe_empresa, out string nome_certificado_nfe_empresa, out string assunto_nfe_email_empresa, out string smtp_nfe_empresa, out string email_nfe_empresa,
                  out string senha_email_nfe_empresa, out string logotipo_empresa, out string proxy_empresa, out string usuario_proxy_empresa, out string senha_proxy_empresa,
          out string crt_empresa, out string portaEmailEmpresa, out string sslEmpresa, out string serie_empresa, out string boleto_pedido_empresa, out string saida_estoque_pedido_empresa,
          out string cod_forn_empresa, out string cst_pis_empresa, out string tipo_pis_empresa, out string cst_cofins_empresa, out string tipo_cofins_empresa)
        {
            razao_social_empresa =  ""; nome_fantasia_empresa =  ""; cnpj_empresa =  ""; ie_empresa =  ""; im_empresa =  ""; cnae_empresa =  ""; endereco_empresa =  ""; n_endereco_empresa =  "";
            complemento_empresa =  ""; bairro_empresa =  ""; cidade_empresa =  ""; estado_empresa =  ""; cep_empresa =  ""; telefone_empresa =  ""; cod_cidade_empresa =  ""; pais_empresa =  "";
            cod_pais_empresa =  ""; licenca_dll_nfe_empresa =  ""; nome_certificado_nfe_empresa =  ""; assunto_nfe_email_empresa =  ""; smtp_nfe_empresa =  ""; email_nfe_empresa =  "";
            senha_email_nfe_empresa =  ""; logotipo_empresa =  ""; proxy_empresa =  ""; usuario_proxy_empresa =  ""; senha_proxy_empresa =  ""; crt_empresa =  ""; portaEmailEmpresa =  "";
            sslEmpresa =  ""; serie_empresa =  ""; boleto_pedido_empresa =  ""; saida_estoque_pedido_empresa =  ""; cod_forn_empresa =  ""; cst_pis_empresa =  ""; tipo_pis_empresa =  ""; cst_cofins_empresa =  ""; tipo_cofins_empresa =  "";
            try
            {
                FbCommand comando = new FbCommand();
                comando.Connection = fbConnection1;
                comando.CommandText = "SELECT * FROM EMPRESA where LICENCA_DLL_NFE_EMPRESA is not null";
                DataSet empresa = new DataSet();
                fbConnection1.Open();
                datEmpresa.SelectCommand = comando;
                datEmpresa.Fill(empresa);
                fbConnection1.Close();
                foreach (DataRow dr in empresa.Tables[0].Rows)
                {
                    razao_social_empresa = dr["RAZAO_SOCIAL_EMPRESA"].ToString();
                    nome_fantasia_empresa = dr["NOME_FANTASIA_EMPRESA"].ToString();
                    cnpj_empresa = dr["CNPJ_EMPRESA"].ToString().Replace(".","").Replace("/", "").Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
                    ie_empresa = dr["IE_EMPRESA"].ToString().Replace(".","").Replace("/", "").Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
                    im_empresa = dr["IM_EMPRESA"].ToString().Replace(".","").Replace("/", "").Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
                    cnae_empresa = dr["CNAE_EMPRESA"].ToString().Replace(".","").Replace("/", "").Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
                    endereco_empresa = dr["ENDERECO_EMPRESA"].ToString();
                    n_endereco_empresa = dr["N_ENDERECO_EMPRESA"].ToString();
                    complemento_empresa = dr["COMPLEMENTO_EMPRESA"].ToString();
                    bairro_empresa = dr["BAIRRO_EMPRESA"].ToString();
                    cidade_empresa = dr["CIDADE_EMPRESA"].ToString();
                    estado_empresa = dr["ESTADO_EMPRESA"].ToString();
                    cep_empresa = dr["CEP_EMPRESA"].ToString().Replace(".","").Replace("/", "").Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
                    telefone_empresa = dr["TELEFONE_EMPRESA"].ToString().Replace(".","").Replace("/", "").Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
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
                    try
                    {
                        cst_pis_empresa = dr["CST_PIS_EMPRESA"].ToString();
                        tipo_pis_empresa = dr["TIPO_PIS_EMPRESA"].ToString();
                        cst_cofins_empresa = dr["CST_COFINS_EMPRESA"].ToString();
                        tipo_cofins_empresa = dr["TIPO_COFINS_EMPRESA"].ToString();
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
        /*private void carregaCombo()
        {
            try
            {
                cbxGrupo.Items.Clear();
                FbCommand selectPlano = new FbCommand();
                selectPlano.CommandText =
                    "SELECT DISTINCT(DESCRICAO_GRUPO_PRODUTO) FROM PRODUTOS WHERE DESCRICAO_GRUPO_PRODUTO IS NOT NULL";
                selectPlano.Connection = fbConnection1;
                FbDataAdapter datTabela = new FbDataAdapter();
                DataSet dsTabela = new DataSet();
                fbConnection1.Open();
                datTabela.SelectCommand = selectPlano;
                datTabela.Fill(dsTabela);
                fbConnection1.Close(); 
                foreach (DataRow dr in dsTabela.Tables[0].Rows)
                {
                    cbxGrupo.Items.Add(dr[0].ToString());
                }

                    //cbxGrupo.SelectedIndex = 0;
            
            }
            catch
            {
                fbConnection1.Close(); 
            }
        }*/

        private void tb_vendedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_cliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter_1(object sender, EventArgs e)
        {

        }

        private void cb_cliente_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_cliente.Checked == false)
            {
                tb_nome_cliente.Text =  "";
                tb_cod_cliente.Text =  "";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_fornecedor_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {


        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            /*dsComissao pv = new dsComissao();

            for (int i = 0; i < vendedores.Count; i++ )
            {
                pv.Tables["DT_COMISSAO"].Rows.Add(vendedores[i]);

                pv.Tables["DT_COMISSAO"].Rows[i][0] = ((ArrayList)vendedores[i])[0].ToString();
                pv.Tables["DT_COMISSAO"].Rows[i][1] = ((ArrayList)vendedores[i])[1].ToString();
                pv.Tables["DT_COMISSAO"].Rows[i][2] = ((ArrayList)vendedores[i])[2].ToString();
                pv.Tables["DT_COMISSAO"].Rows[i][4] = ((ArrayList)vendedores[i])[4].ToString();
                pv.Tables["DT_COMISSAO"].Rows[i][5] = ((ArrayList)vendedores[i])[9].ToString();
                pv.Tables["DT_COMISSAO"].Rows[i][6] = ((ArrayList)((ArrayList)vendedores[i])[3])[0].ToString();
                pv.Tables["DT_COMISSAO"].Rows[i][7] = ((ArrayList)((ArrayList)vendedores[i])[3])[1].ToString();
                pv.Tables["DT_COMISSAO"].Rows[i][8] = ((ArrayList)vendedores[i])[5].ToString();
                pv.Tables["DT_COMISSAO"].Rows[i][9] = ((ArrayList)vendedores[i])[6].ToString();
                pv.Tables["DT_COMISSAO"].Rows[i][10] = ((ArrayList)((ArrayList)vendedores[i])[7])[0].ToString();
                pv.Tables["DT_COMISSAO"].Rows[i][11] = ((ArrayList)((ArrayList)vendedores[i])[7])[1].ToString();
                pv.Tables["DT_COMISSAO"].Rows[i][12] = ((ArrayList)vendedores[i])[8].ToString();*/

            try
            {

                dsPedidos_venda.Clear();

                //string grupo = cbxGrupo.SelectedItem.ToString();

                string vendedor = "", cliente = "", fornecedor =  "";

                if (cb_vendedor.Checked == true)
                {
                    vendedor = " and pv.cod_vendedor_ped_venda = '" + tb_cod_vendedor.Text + "' ";
                }
                if (cb_cliente.Checked == true)
                {
                    cliente = " and pv.cliente_ped_venda = '" + tb_nome_cliente.Text + "' ";
                }
                if (cb_fornecedor.Checked == true)
                {
                    fornecedor = " and p.nome_fornecedor_produto = '" + tb_nome_fornecedor.Text + "' ";
                }
                string pis =  "";
                if (cb_com_pis.Checked)
                    pis = " AND p.PIS_COFINS_PRODUTO = '1'";

                string produto =  "";
                if (cbProduto.Checked)
                {
                    produto = " AND p.cod_produto = '" + tb_cod_produto.Text + "'";
                }

                string _cfop = " and (item.cfop_item like '_1__'	" +
                    "	or item.cfop_item like '_4__') ";
                if (cbCfop.Checked)
                {
                    _cfop = "  and (item.cfop_item = '" + tb_n_cfop.Text + "'	" +
                    "	or item.cfop_item = '6" + tb_n_cfop.Text.Substring(1, 3) + "' ) ";
                }

                FbCommand select = new FbCommand();
                FbDataAdapter datSelect = new FbDataAdapter();
                DataTable dtSelect = new DataTable();
                dsComissao pv = new dsComissao();

                select.CommandText =

                    "select" +
                    "   pv.vendedor_ped_venda vendedor, " +
                    "   p.descricao_grupo_produto grupo, " +
                    "   p.descricao_sub_grupo_produto subgrupo, " +
                    "   p.nome_fornecedor_produto, p.nome_familia_produto, " +
                    "   sum(item.preco_total_item)total " +
                    "from itens_nota item " +
                    "   inner join nota_fiscal nf " +
                    "       on nf.n_nf = item.nf_item " +
                    "   inner join pedidos_nf pnf " +
                    "       on pnf.nf_pedido_nf = nf.n_nf " +
                    "   inner join pedidos_venda pv " +
                    "       on pv.cod_ped_venda = pnf.n_pedido_nf " +
                    "   inner join produtos p " +
                    "       on (CAST(p.cod_produto AS VARCHAR(50)) = CAST(item.cod_item AS VARCHAR(50)) " +
                    " or CAST(p.cod_fornecedor_produto AS VARCHAR(50)) = CAST(item.cod_item AS VARCHAR(50)))" +
                    "   inner join cfo " +
                    "       on cfo.n_cfo = item.cfop_item " +
                    "where nf.data_emissao_nf >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") + "' " +
                    "   and nf.data_emissao_nf <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                    cliente +
                    vendedor +
                    fornecedor +
                    pis +
                    produto +
                    "   and nf.status_nfe like '%Autorizada%' " +
                   _cfop +
                    "   and cfo.tributada_cfo = '1' " +
                    "group by " +
                    "   pv.vendedor_ped_venda, " +
                    "   p.descricao_grupo_produto, " +
                    "   p.descricao_sub_grupo_produto, p.nome_fornecedor_produto,p.nome_familia_produto";

                select.Connection = fbConnection1;
                fbConnection1.Open();
                datSelect.SelectCommand = select;
                datSelect.Fill(dtSelect);
                fbConnection1.Close();

                string vendedor_anterior = "VARIAVEL_NULL";
                string grupo_anterior = "VARIAVEL_NULL";
                double somatorio_por_vendedor = 0;
                double somatorio_por_grupo = 0;
                double somatorio_laviotera_outros = 0;

                DataRow row = pv.DT_COMISSAO.NewRow();

                foreach (DataRow dr in dtSelect.Rows)
                {
                    if (pv.DT_COMISSAO.Columns.Contains(dr[1].ToString()))
                    {
                        string vendedor_atual = dr[0].ToString();
                        string grupo_atual = dr[1].ToString();

                        if (vendedor_anterior != vendedor_atual && vendedor_anterior != "VARIAVEL_NULL")
                        {
                            row["VENDEDOR"] = vendedor_anterior;
                            row["TOTAL"] = somatorio_por_vendedor.ToString("N2");

                            pv.DT_COMISSAO.Rows.Add(row);
                            somatorio_por_vendedor = 0;
                            row = pv.DT_COMISSAO.NewRow();
                            somatorio_laviotera_outros = 0;
                            DataTable teste1 = pv.DT_COMISSAO;
                        }

                        somatorio_por_vendedor += Convert.ToDouble(dr[5].ToString());
                        if (grupo_anterior != grupo_atual) somatorio_por_grupo = 0;
                        somatorio_por_grupo += Convert.ToDouble(dr[5].ToString());

                        if (dr[1].ToString() == "LA VIOLETERA")
                        {
                            if (dr[4].ToString() == "AZEITE")
                            {
                                row[dr[4].ToString()] = dr[5].ToString();
                            }
                            else
                            {
                                somatorio_laviotera_outros += Convert.ToDouble(dr[5].ToString());
                                row["DIVERSOS"] = somatorio_laviotera_outros;
                            }
                            somatorio_por_grupo = 0;
                        }
                        else
                        {

                            row[dr[1].ToString()] = somatorio_por_grupo;
                        }
                        vendedor_anterior = dr[0].ToString();
                        grupo_anterior = dr[1].ToString();
                    }
                }

                if (row["VENDEDOR"] != null || row["VENDEDOR"] != "")
                {
                    row["VENDEDOR"] = vendedor_anterior;
                    row["TOTAL"] = somatorio_por_vendedor.ToString("N2");
                    pv.DT_COMISSAO.Rows.Add(row);
                }


                crComissao cr = new crComissao();
                cr.SetDataSource(pv);

                cr.SetParameterValue(cr.Parameter_diaInicio.ParameterFieldName.ToString(), dtInicial.Text.ToString().Substring(0, 2));
                cr.SetParameterValue(cr.Parameter_anoPeriodo.ParameterFieldName.ToString(), dtInicial.Text.ToString().Substring(6, 4));
                cr.SetParameterValue(cr.Parameter_mesPeriodo.ParameterFieldName.ToString(), dtInicial.Text.ToString().Substring(3, 2));

                form_imprimir imprimir = new form_imprimir(cr);
                imprimir.Show();
            }
            catch (Exception sEx)
            {
                MessageBox.Show(sEx.Message);
            }
            finally
            {
                fbConnection1.Close();
            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            form_fornecedores forn = new form_fornecedores(true, "", cnpj_empresa);

            try
            {
                forn.ShowDialog();
            }
            finally
            {
                forn.Dispose();
                //tb_nome_fornecedor.Text = forn.form_fornecedores;
            }
        }

        private void tb_valor_total_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click_2(object sender, EventArgs e)
        {
            form_localiza_forn fornecedores = new form_localiza_forn(false, cnpj_empresa);

            try
            {
                fornecedores.ShowDialog();
            }
            finally
            {
                fornecedores.Dispose();
                tb_nome_fornecedor.Text = fornecedores.razao_forn_escolhido;
                tb_cod_fornecedor.Text = fornecedores.cod_escolhido;
            }
        }

        private void tb_cod_vendedor_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void cb_fornecedor_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cb_fornecedor.Checked == false)
            {
                tb_nome_fornecedor.Text =  "";
                tb_cod_fornecedor.Text =  "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string _vendedor = "", _fornecedor = "", _cliente = "", _familia =  "";

                if (tbGrupo.Text != "")
                    _familia = " AND prod.DESCRICAO_GRUPO_PRODUTO = '" + tbGrupo.Text + "' ";
                if (tb_nome_produto.Text != "")
                    _familia = " AND prod.COD_PRODUTO = '" + tb_cod_produto.Text + "' ";

                if (tbFamilia.Text != "")
                    _familia = " AND prod.NOME_FAMILIA_PRODUTO = '" + tbFamilia.Text + "' ";

                if (tb_nome_vendedor.Text != "")
                    _vendedor = " AND ped.VENDEDOR_PED_VENDA = '" + tb_nome_vendedor.Text + "' ";

                if (tb_nome_fornecedor.Text != "")
                    _fornecedor = " AND prod.NOME_FORNECEDOR_PRODUTO = '" + tb_nome_fornecedor.Text + "' ";

                if (tb_nome_cliente.Text != "")
                    _cliente = " AND nf.CNPJ_CLIENTE_FORN = '" + tb_cnpj.Text + "' ";


                string _cfop = " and (item.cfop_item like '_1__'	" +
                    "	or item.cfop_item like '_4__') ";
                if (cbCfop.Checked)
                {
                    _cfop = "  and (item.cfop_item = '" + tb_n_cfop.Text + "'	" +
                    "	or item.cfop_item = '6" + tb_n_cfop.Text.Substring(1, 3) + "' ) ";
                }
                string dataIni = Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".");
                string dataFim = Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".");
                dsClientesxproduto cli = new dsClientesxproduto();
                FbCommand select = new FbCommand();
                select.CommandText =
                      "select sum(item.qtde_item), prod.COD_PRODUTO, nf.CNPJ_CLIENTE_FORN, ped.VENDEDOR_PED_VENDA, " +
                    "sum(item.PRECO_TOTAL_ITEM), sum(item.CUSTO_ITEM) from itens_nota item " +
                    "inner join produtos prod on prod.cod_fornecedor_produto = item.cod_item " +
                    "INNER JOIN nota_fiscal nf ON ITEM.NF_ITEM = NF.N_NF " +
                    "INNER JOIN PEDIDOS_NF ped_nf on nf.n_nf = ped_nf.nf_pedido_nf " +
                    "inner join pedidos_venda ped on ped.cod_ped_venda = ped_nf.n_pedido_nf " +
                    "inner join vendedores v on ped.COD_VENDEDOR_PED_VENDA = V.COD_VENDEDOR " +
                    "where " +
                    "nf.STATUS_NFE LIKE ('%Autorizada%') " +
                     _cfop +
                    " AND nf.data_emissao_nf >= '" + dataIni +
                    "' and nf.data_emissao_nf <= '" + dataFim + "' " +
                    _vendedor + _fornecedor + _cliente + _familia + supervisor +
                    "group by ped.VENDEDOR_PED_VENDA, nf.CNPJ_CLIENTE_FORN, prod.COD_PRODUTO ";
                    //"select sum(item.qtde_item), prod.COD_PRODUTO, nf.CNPJ_CLIENTE_FORN, ped.VENDEDOR_PED_VENDA, sum(item.PRECO_TOTAL_ITEM), sum(item.CUSTO_ITEM) from itens_nota item " +
                    //"inner join produtos prod on prod.cod_fornecedor_produto = item.cod_item " +
                    //"INNER JOIN nota_fiscal nf ON ITEM.NF_ITEM = NF.N_NF " +
                    //"INNER JOIN PEDIDOS_NF ped_nf on nf.n_nf = ped_nf.nf_pedido_nf " +
                    //"inner join pedidos_venda ped on ped.cod_ped_venda = ped_nf.n_pedido_nf " +
                    //"inner join vendedores v on ped.COD_VENDEDOR_PED_VENDA = V.COD_VENDEDOR " +
                    //"where " +
                    //"nf.STATUS_NFE LIKE ('%Autorizada%') " +
                    // _cfop +
                    //" AND nf.data_emissao_nf >= '" + dataIni +
                    //"' and nf.data_emissao_nf <= '" + dataFim + "' " +
                    //_vendedor + _fornecedor + _cliente + _familia + supervisor + 
                    //"group by ped.VENDEDOR_PED_VENDA, nf.CNPJ_CLIENTE_FORN, prod.COD_PRODUTO ";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    double custo = 0;
                    double trocas = 0, valor_trocas = 0;
                    try
                    {
                        custo = Convert.ToDouble(dr[5].ToString());
                    }
                    catch { }
                    try
                    {
                        cli.VendedorxClientesxProdutos.AddVendedorxClientesxProdutosRow(Convert.ToDouble(dr[0].ToString()), Convert.ToInt32(dr[1].ToString()),
                            dr[2].ToString(), dr[3].ToString(), Convert.ToDouble(dr[4].ToString()), custo, trocas, valor_trocas, 0, 0, 0, 0);
                    }
                    catch { }
                }

                FbCommand select_clientes = new FbCommand();
                select_clientes.CommandText =
                    "SELECT * from clientes";
                select_clientes.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect_clientes = new FbDataAdapter();
                datSelect_clientes.SelectCommand = select_clientes;
                datSelect_clientes.Fill(cli.CLIENTES);
                fbConnection1.Close();

                FbCommand select_produtos = new FbCommand();
                select_produtos.CommandText =
                    "SELECT * from produtos";
                select_produtos.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect_produtos = new FbDataAdapter();
                datSelect_produtos.SelectCommand = select_produtos;
                datSelect_produtos.Fill(cli.PRODUTOS);
                fbConnection1.Close();


                cli.Dados.AddDadosRow(tb_nome_fornecedor.Text, Convert.ToDateTime(dtInicial.Text), Convert.ToDateTime(dtFinal.Text),
                    tb_nome_vendedor.Text, "", "",0);


                crVendedorxClientesxProdutosNovo cr = new crVendedorxClientesxProdutosNovo();
                cr.SetDataSource(cli);
                form_imprimir imprime = new form_imprimir(cr);
                imprime.Show();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        //private double buscar_trocas(string p, string _cfop, string dataIni, string dataFim, string _vendedor, string _fornecedor,string cnpj)
        //{
        //    double troca = 0;
        //    try
        //    {
        //        FbCommand select = new FbCommand();
        //        select.CommandText =
        //            "select sum(item.qtde_item) from itens_nota item " +
        //            "inner join produtos prod on prod.cod_produto = item.cod_item " +
        //            "INNER JOIN nota_fiscal nf ON ITEM.NF_ITEM = NF.N_NF " +
        //            "INNER JOIN PEDIDOS_NF ped_nf on nf.n_nf = ped_nf.nf_pedido_nf " +
        //            "inner join pedidos_venda ped on ped.cod_ped_venda = ped_nf.n_pedido_nf " +
        //            "where prod.cod_produto = " + p + " AND nf.CNPJ_CLIENTE_FORN = '" + cnpj + "' " +
        //            "and nf.STATUS_NFE LIKE ('%Autorizada%') " +
        //            " AND nf.data_emissao_nf >= '" + dataIni +
        //            "' and nf.data_emissao_nf <= '" + dataFim + "' " +
        //            _vendedor + _fornecedor +
        //            " AND ped.TROCA_PED_VENDA = '1'";
        //        select.Connection = fbConnection1;
        //        fbConnection1.Open();
        //        FbDataAdapter datSelect = new FbDataAdapter();
        //        datSelect.SelectCommand = select;
        //        DataTable dtSelect = new DataTable();
        //        datSelect.Fill(dtSelect);
        //        fbConnection1.Close();
        //        foreach (DataRow dr in dtSelect.Rows)
        //        {
        //            try
        //            {
        //                troca = Convert.ToDouble(dr[0].ToString());
        //            }
        //            catch { }
        //        }
        //        return troca;
        //    }
        //    catch
        //    {
        //        fbConnection1.Close();
        //        return troca;
        //    }
        //}



        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string _vendedor = "", _fornecedor = "", _cliente = "", _produto = "", _familia = "";

                if (tbGrupo.Text != "")
                    _familia = " AND prod.DESCRICAO_GRUPO_PRODUTO = '" + tbGrupo.Text + "' ";
                if (tbdescricaoSubgrupo.Text != "")
                    _familia = " AND prod.DESCRICAO_SUB_GRUPO_PRODUTO = '" + tbdescricaoSubgrupo.Text + "' ";
                if (tb_nome_produto.Text != "")
                    _familia = " AND prod.COD_PRODUTO = '" + tb_cod_produto.Text + "' ";

                if (tbFamilia.Text != "")
                    _familia += " AND prod.NOME_FAMILIA_PRODUTO = '" + tbFamilia.Text + "' ";
                if (tb_nome_vendedor.Text != "")
                    _vendedor = " AND ped.VENDEDOR_PED_VENDA = '" + tb_nome_vendedor.Text + "' ";

                if (tb_nome_fornecedor.Text != "")
                    _fornecedor = " AND prod.NOME_FORNECEDOR_PRODUTO = '" + tb_nome_fornecedor.Text + "' ";

                if (tb_nome_cliente.Text != "")
                    _cliente = " AND nf.CNPJ_CLIENTE_FORN = '" + tb_cnpj.Text + "' ";

                if (tb_cod_matriz.Text != "")
                    _cliente = " AND c.COD_MATRIZ_CLIENTE = '" + tb_cod_matriz.Text + "' ";

                string _cfop = " and (item.cfop_item like '_1__'	" +
                   "	or item.cfop_item like '_4__') ";
                if (cbCfop.Checked)
                {
                    _cfop = "  and (item.cfop_item = '" + tb_n_cfop.Text + "'	" +
                    "	or item.cfop_item = '6" + tb_n_cfop.Text.Substring(1, 3) + "' ) ";
                }
                dsClientesxproduto cli = new dsClientesxproduto();
                FbCommand select = new FbCommand();
                select.CommandText =
                    "select sum(item.qtde_item), prod.COD_PRODUTO, nf.CNPJ_CLIENTE_FORN, ped.VENDEDOR_PED_VENDA, sum(item.PRECO_TOTAL_ITEM), SUM(item.CUSTO_ITEM) from itens_nota item " +
                    "inner join produtos prod on prod.cod_fornecedor_produto = item.cod_item " +
                    "INNER JOIN nota_fiscal nf ON ITEM.NF_ITEM = NF.N_NF " +
                    "INNER JOIN PEDIDOS_NF ped_nf on nf.n_nf = ped_nf.nf_pedido_nf " +
                    "inner join pedidos_venda ped on ped.cod_ped_venda = ped_nf.n_pedido_nf " +
                    "inner join vendedores v on ped.COD_VENDEDOR_PED_VENDA = V.COD_VENDEDOR " +
                    "inner join clientes c on nf.CNPJ_CLIENTE_FORN = c.CNPJ " + 
                    "where " +
                    "nf.STATUS_NFE LIKE ('%Autorizada%') " + _cfop + " AND " +
                    "nf.data_emissao_nf >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") +
                    "' and nf.data_emissao_nf <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                    _vendedor + _fornecedor + _cliente + _produto + _familia + supervisor + 
                    "group by ped.VENDEDOR_PED_VENDA, nf.CNPJ_CLIENTE_FORN, prod.COD_PRODUTO";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    double custo = 0;
                    try
                    {
                        custo = Convert.ToDouble(dr[5].ToString());
                    }
                    catch { }
                    try
                    {
                        cli.VendedorxClientesxProdutos.AddVendedorxClientesxProdutosRow(Convert.ToDouble(dr[0].ToString()), Convert.ToInt32(dr[1].ToString()),
                            dr[2].ToString(), dr[3].ToString(), Convert.ToDouble(dr[4].ToString()), custo, 0, 0, 0, 0, 0, 0);
                    }
                    catch { }
                }

                FbCommand select_clientes = new FbCommand();
                select_clientes.CommandText =
                    "SELECT * from clientes";
                select_clientes.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect_clientes = new FbDataAdapter();
                datSelect_clientes.SelectCommand = select_clientes;
                datSelect_clientes.Fill(cli.CLIENTES);
                fbConnection1.Close();

                FbCommand select_produtos = new FbCommand();
                select_produtos.CommandText =
                    "SELECT * from produtos";
                select_produtos.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect_produtos = new FbDataAdapter();
                datSelect_produtos.SelectCommand = select_produtos;
                datSelect_produtos.Fill(cli.PRODUTOS);
                fbConnection1.Close();


                cli.Dados.AddDadosRow(tb_nome_fornecedor.Text, Convert.ToDateTime(dtInicial.Text), Convert.ToDateTime(dtFinal.Text),
                    tb_nome_vendedor.Text, "", "",0);


                crVendedorxClientes cr = new crVendedorxClientes();
                cr.SetDataSource(cli);
                form_imprimir imprime = new form_imprimir(cr);
                imprime.Show();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                string _vendedor = "", _fornecedor = "", _cliente = "", _familia =  "";

                if (tbGrupo.Text != "")
                    _familia = " AND prod.DESCRICAO_GRUPO_PRODUTO = '" + tbGrupo.Text + "' ";
                if (tbdescricaoSubgrupo.Text != "")
                    _familia = " AND prod.DESCRICAO_SUB_GRUPO_PRODUTO = '" + tbdescricaoSubgrupo.Text + "' ";
                if (tb_nome_produto.Text != "")
                    _familia = " AND prod.COD_PRODUTO = '" + tb_cod_produto.Text + "' ";

                if (tbFamilia.Text != "")
                    _familia += " AND prod.NOME_FAMILIA_PRODUTO = '" + tbFamilia.Text + "'";
                //if (tbFamilia.Text != "")
               //     _familia = " AND prod.NOME_FAMILIA_PRODUTO = '" + tbFamilia.Text + "' ";

                if (tb_nome_vendedor.Text != "")
                    _vendedor = " AND ped.VENDEDOR_PED_VENDA = '" + tb_nome_vendedor.Text + "' ";

                if (tb_nome_fornecedor.Text != "")
                    _fornecedor = " AND prod.NOME_FORNECEDOR_PRODUTO = '" + tb_nome_fornecedor.Text + "' ";

                if (tb_nome_cliente.Text != "")
                    _cliente = " AND nf.CNPJ_CLIENTE_FORN = '" + tb_cnpj.Text + "' ";
                if (tb_cod_matriz.Text != "")
                    _cliente = " AND c.COD_MATRIZ_CLIENTE = '" + tb_cod_matriz.Text + "' ";

                string _cfop = " and (item.cfop_item like '_1__'	" +
                   "	or item.cfop_item like '_4__') ";
                if (cbCfop.Checked)
                {
                    _cfop = "  and (item.cfop_item = '" + tb_n_cfop.Text + "'	" +
                    "	or item.cfop_item = '6" + tb_n_cfop.Text.Substring(1, 3) + "' ) ";
                }
                dsClientesxproduto cli = new dsClientesxproduto();
                FbCommand select = new FbCommand();
                select.CommandText =
                    "select sum(item.qtde_item), prod.COD_PRODUTO, '', ped.VENDEDOR_PED_VENDA, sum(item.PRECO_TOTAL_ITEM), sum(item.CUSTO_ITEM) from itens_nota item " +
                    "inner join produtos prod on prod.cod_fornecedor_produto = item.cod_item " +
                    "INNER JOIN nota_fiscal nf ON ITEM.NF_ITEM = NF.N_NF " +
                    "INNER JOIN PEDIDOS_NF ped_nf on nf.n_nf = ped_nf.nf_pedido_nf " +
                    "inner join pedidos_venda ped on ped.cod_ped_venda = ped_nf.n_pedido_nf " +
                     "inner join vendedores v on ped.COD_VENDEDOR_PED_VENDA = V.COD_VENDEDOR " +
                      "inner join clientes c on nf.CNPJ_CLIENTE_FORN = c.CNPJ " + 
                    "where " +
                    "nf.STATUS_NFE LIKE ('%Autorizada%') AND " +
                    "nf.data_emissao_nf >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") +
                    "' and nf.data_emissao_nf <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                    _vendedor + _fornecedor + _cliente + _familia + supervisor +
                    _cfop +
                    "group by ped.VENDEDOR_PED_VENDA, prod.COD_PRODUTO ";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    double custo = 0;
                    try
                    {
                        custo = Convert.ToDouble(dr[5].ToString());
                    }
                    catch { }
                    try
                    {
                        cli.VendedorxClientesxProdutos.AddVendedorxClientesxProdutosRow(Convert.ToDouble(dr[0].ToString()), Convert.ToInt32(dr[1].ToString()),
                            dr[2].ToString(), dr[3].ToString(), Convert.ToDouble(dr[4].ToString()), custo, 0, 0, 0, 0, 0, 0);
                    }
                    catch { }
                }

                FbCommand select_clientes = new FbCommand();
                select_clientes.CommandText =
                    "SELECT * from clientes";
                select_clientes.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect_clientes = new FbDataAdapter();
                datSelect_clientes.SelectCommand = select_clientes;
                datSelect_clientes.Fill(cli.CLIENTES);
                fbConnection1.Close();

                FbCommand select_produtos = new FbCommand();
                select_produtos.CommandText =
                    "SELECT * from produtos";
                select_produtos.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect_produtos = new FbDataAdapter();
                datSelect_produtos.SelectCommand = select_produtos;
                datSelect_produtos.Fill(cli.PRODUTOS);
                fbConnection1.Close();

                cli.Dados.AddDadosRow(tb_nome_fornecedor.Text, Convert.ToDateTime(dtInicial.Text), Convert.ToDateTime(dtFinal.Text),
                    tb_nome_vendedor.Text, "", "",0);


                crVendedorxProdutos cr = new crVendedorxProdutos();
                cr.SetDataSource(cli);
                form_imprimir imprime = new form_imprimir(cr);
                imprime.Show();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            try
            {
                string _vendedor = "", _fornecedor = "", _cliente = "", _familia =  "";

                if (tbGrupo.Text != "")
                    _familia = " AND prod.DESCRICAO_GRUPO_PRODUTO = '" + tbGrupo.Text + "' ";
                if (tbdescricaoSubgrupo.Text != "")
                    _familia = " AND prod.DESCRICAO_SUB_GRUPO_PRODUTO = '" + tbdescricaoSubgrupo.Text + "' ";
                if (tb_nome_produto.Text != "")
                    _familia = " AND prod.COD_PRODUTO = '" + tb_cod_produto.Text + "' ";

                if (tbFamilia.Text != "")
                    _familia += " AND prod.NOME_FAMILIA_PRODUTO = '" + tbFamilia.Text + "'";

              
                if (tb_nome_vendedor.Text != "")
                    _vendedor = " AND ped.VENDEDOR_PED_VENDA = '" + tb_nome_vendedor.Text + "' ";

                if (tb_nome_fornecedor.Text != "")
                    _fornecedor = " AND prod.NOME_FORNECEDOR_PRODUTO = '" + tb_nome_fornecedor.Text + "' ";

                if (tb_nome_cliente.Text != "")
                    _cliente = " AND nf.CNPJ_CLIENTE_FORN = '" + tb_cnpj.Text + "' ";

                if (tb_cod_matriz.Text != "")
                    _cliente = " AND c.COD_MATRIZ_CLIENTE = '" + tb_cod_matriz.Text + "' ";

                string _cfop = " and (item.cfop_item like '_1__'	" +
                   "	or item.cfop_item like '_4__') ";
                if (cbCfop.Checked)
                {
                    _cfop = "  and (item.cfop_item = '" + tb_n_cfop.Text + "'	" +
                    "	or item.cfop_item = '6" + tb_n_cfop.Text.Substring(1, 3) + "' ) ";
                }
                dsClientesxproduto cli = new dsClientesxproduto();
                FbCommand select = new FbCommand();
                select.CommandText =
                    "select sum(item.qtde_item), prod.COD_PRODUTO, nf.CNPJ_CLIENTE_FORN, ped.VENDEDOR_PED_VENDA, sum(item.PRECO_TOTAL_ITEM) from itens_nota item " +
                    "inner join produtos prod on prod.cod_fornecedor_produto = item.cod_item " +
                    "INNER JOIN nota_fiscal nf ON ITEM.NF_ITEM = NF.N_NF " +
                    "INNER JOIN PEDIDOS_NF ped_nf on nf.n_nf = ped_nf.nf_pedido_nf " +
                    "inner join pedidos_venda ped on ped.cod_ped_venda = ped_nf.n_pedido_nf " +
                     "inner join vendedores v on ped.COD_VENDEDOR_PED_VENDA = V.COD_VENDEDOR " +
                      "inner join clientes c on nf.CNPJ_CLIENTE_FORN = c.CNPJ " + 
                    "where " +
                    "nf.STATUS_NFE LIKE ('%Autorizada%') AND " +
                    "nf.data_emissao_nf >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") +
                    "' and nf.data_emissao_nf <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                    _vendedor + _fornecedor + _cfop + _cliente + _familia + supervisor +
                    "group by ped.VENDEDOR_PED_VENDA, nf.CNPJ_CLIENTE_FORN, prod.COD_PRODUTO ";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    try
                    {
                        cli.VendedorxClientesxProdutosxvalor.AddVendedorxClientesxProdutosxvalorRow(Convert.ToDouble(dr[0].ToString()), Convert.ToInt32(dr[1].ToString()),
                            dr[2].ToString(), dr[3].ToString(), Convert.ToDouble(dr[4].ToString()));
                    }
                    catch { }
                }

                FbCommand select_clientes = new FbCommand();
                select_clientes.CommandText =
                    "SELECT * from clientes";
                select_clientes.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect_clientes = new FbDataAdapter();
                datSelect_clientes.SelectCommand = select_clientes;
                datSelect_clientes.Fill(cli.CLIENTES);
                fbConnection1.Close();

                FbCommand select_produtos = new FbCommand();
                select_produtos.CommandText =
                    "SELECT * from produtos";
                select_produtos.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect_produtos = new FbDataAdapter();
                datSelect_produtos.SelectCommand = select_produtos;
                datSelect_produtos.Fill(cli.PRODUTOS);
                fbConnection1.Close();


                cli.Dados.AddDadosRow(tb_nome_fornecedor.Text, Convert.ToDateTime(dtInicial.Text), Convert.ToDateTime(dtFinal.Text),
                    tb_nome_vendedor.Text, "", "",0);


                crVendedorxCidades cr = new crVendedorxCidades();
                cr.SetDataSource(cli);
                form_imprimir imprime = new form_imprimir(cr);
                imprime.Show();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void compilar_todos_vendedores(string tipo)
        {
            try
            {
                dsCreditoxDebitoxVendedor ds = new dsCreditoxDebitoxVendedor();

                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT COD_VENDEDOR, NOME_VENDEDOR FROM VENDEDORES";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    try
                    {
                        try
                        {
                            if (tipo == "metas")
                                metas(dr[0].ToString());
                            if (tipo == "comissoes")
                                comissoes(dr[0].ToString());
                        }
                        finally
                        {
                            ds.Vendedores.AddVendedoresRow(dr[1].ToString(), Convert.ToDouble(tb_valor_total.Text), Convert.ToDouble(tb_diferenca_total.Text));
                        }
                    }
                    catch { }
                }

                crCreditoxDebitoxVendedor cr = new crCreditoxDebitoxVendedor();
                cr.SetDataSource(ds);
                form_imprimir imprimir = new form_imprimir(cr);
                imprimir.Show();



            }
            catch (Exception a)
            {
                fbConnection1.Close();
            }
        }


        private void button7_Click_1(object sender, EventArgs e)
        {
            if (tb_nome_vendedor.Text == "*")
            {
                dtInicial.Text = "01.10.2015";
                dtFinal.Text = "01.01.2100";
            }
            if (tb_nome_vendedor.Text == "*")
            {
                compilar_todos_vendedores("metas");
            }
            else
            {
                metas(tb_cod_vendedor.Text);
            }


        }




        private void metas(string _vendedor)
        {
            try
            {
                if (_vendedor != "")
                {
                    dsMetas metas = new dsMetas();
                    //selecionando metas

                    string vendedor = "", cliente = "", fornecedor =  "";

                    if (cb_vendedor.Checked == true)
                    {
                        vendedor = " and pv.cod_vendedor_ped_venda = '" + _vendedor + "' ";
                    }
                    if (cb_cliente.Checked == true)
                    {
                        cliente = " and pv.cliente_ped_venda = '" + tb_nome_cliente.Text + "' ";
                    }
                    if (cb_fornecedor.Checked == true)
                    {
                        fornecedor = " and p.nome_fornecedor_produto = '" + tb_nome_fornecedor.Text + "' ";
                    }

                    FbCommand select = new FbCommand();
                    select.CommandText =


//QTDE
"select   pv.vendedor_ped_venda vendedor,    p.nome_familia_produto, '0' as Meta_Fisica, " +
"(select sum(inf1.QTDE_ITEM) " +
                    "from itens_nota inf1   inner join nota_fiscal nf1        on nf1.n_nf = inf1.nf_item " +
 " inner join pedidos_nf pnf1        on pnf1.nf_pedido_nf = nf1.n_nf " +
"  inner join pedidos_venda pv1        on pv1.cod_ped_venda = pnf1.n_pedido_nf " +
"   inner join produtos p1 on (CAST(p1.cod_produto AS VARCHAR(50)) = CAST(inf1.cod_item AS VARCHAR(50))  or CAST(p1.cod_fornecedor_produto AS VARCHAR(50)) = CAST(inf1.cod_item AS VARCHAR(50))) " +
"   inner join cfo cfo1 on cfo1.n_cfo = inf1.cfop_item " +
 "    inner join metas_produto_vendedor m1 on m1.COD_VENDEDOR_MPV = pv1.cod_vendedor_ped_venda and m1.familia_mpv = p1.NOME_FAMILIA_PRODUTO " +
"     where nf1.data_emissao_nf >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") + "' " +
                    " and nf1.data_emissao_nf <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
  "     and pv1.cod_vendedor_ped_venda = '" + _vendedor + "'    and nf1.status_nfe like '%Autorizada%' " +
  "       and (inf1.cfop_item = '5102'	" +
"	or inf1.cfop_item = '5405')  and cfo1.tributada_cfo = '1' " +
 "          and p1.nome_familia_produto = p.nome_familia_produto) as Resultado_Fisico, " +
 "'0' as Meta_Positivacao, '0' as Resultado_Positivacao, " +
" '0' as Meta_Valor, " +
                        //VALOR VENDA
" (select sum(inf2.PRECO_TOTAL_item) " +
                    "from itens_nota inf2   inner join nota_fiscal nf2        on nf2.n_nf = inf2.nf_item " +
 " inner join pedidos_nf pnf2        on pnf2.nf_pedido_nf = nf2.n_nf " +
"  inner join pedidos_venda pv2        on pv2.cod_ped_venda = pnf2.n_pedido_nf " +
"   inner join produtos p2 on (CAST(p2.cod_produto AS VARCHAR(50)) = CAST(inf2.cod_item AS VARCHAR(50))  or CAST(p2.cod_fornecedor_produto AS VARCHAR(50)) = CAST(inf2.cod_item AS VARCHAR(50))) " +
"   inner join cfo cfo2 on cfo2.n_cfo = inf2.cfop_item " +
 "    inner join metas_produto_vendedor m2 on m2.COD_VENDEDOR_MPV = pv2.cod_vendedor_ped_venda and m2.familia_mpv = p2.NOME_FAMILIA_PRODUTO " +
"     where nf2.data_emissao_nf >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") + "' " +
                    " and nf2.data_emissao_nf <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
  "     and pv2.cod_vendedor_ped_venda = '" + _vendedor + "'    and nf2.status_nfe like '%Autorizada%' " +
  "        and (inf2.cfop_item = '5102'	" +
"	or inf2.cfop_item = '5405')  and cfo2.tributada_cfo = '1' " +
 "          and p2.nome_familia_produto = p.nome_familia_produto) as Valor_Total " +

" from itens_nota item" +
" inner join nota_fiscal nf        on nf.n_nf = item.nf_item " +
 "inner join pedidos_nf pnf        on pnf.nf_pedido_nf = nf.n_nf " +
" inner join pedidos_venda pv        on pv.cod_ped_venda = pnf.n_pedido_nf " +
" inner join produtos p        on (CAST(p.cod_produto AS VARCHAR(50)) = CAST(item.cod_item AS VARCHAR(50)) " +
" or CAST(p.cod_fornecedor_produto AS VARCHAR(50)) = CAST(item.cod_item AS VARCHAR(50))) " +
" inner join cfo on cfo.n_cfo = item.cfop_item " +
" inner join metas_produto_vendedor m on m.COD_VENDEDOR_MPV = pv.cod_vendedor_ped_venda and m.familia_mpv = p.NOME_FAMILIA_PRODUTO " +
"where nf.data_emissao_nf >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") + "' " +
                            "   and nf.data_emissao_nf <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                            cliente +
                            vendedor +
                            fornecedor +
                            "   and nf.status_nfe like '%Autorizada%' " +
                            "   and cfo.tributada_cfo = '1' " +
                            "group by " +
                            "   pv.vendedor_ped_venda, p.nome_familia_produto";
                    select.Connection = fbConnection1;
                    FbDataAdapter datSelect = new FbDataAdapter();
                    datSelect.SelectCommand = select;
                    dtSelect_metas.Clear();
                    datSelect.Fill(dtSelect_metas);
                    fbConnection1.Close();

                    dgvPedidos.DataSource = dtSelect_metas;

                    buscar_informacoes_meta(_vendedor, false);
                    somar_totais_meta();

                }
                else
                    MessageBox.Show("Para essa pesquisa, por favor, selecione o vendedor");
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }

        }

        private void comissoes(string _vendedor)
        {
            try
            {
                if (_vendedor != "")
                {
                    dsMetas metas = new dsMetas();
                    //selecionando metas

                    string vendedor = "", cliente = "", fornecedor =  "";

                    if (cb_vendedor.Checked == true)
                    {
                        vendedor = " and pv.cod_vendedor_ped_venda = '" + _vendedor + "' ";
                    }
                    if (cb_cliente.Checked == true)
                    {
                        cliente = " and pv.cliente_ped_venda = '" + tb_nome_cliente.Text + "' ";
                    }
                    if (cb_fornecedor.Checked == true)
                    {
                        fornecedor = " and p.nome_fornecedor_produto = '" + tb_nome_fornecedor.Text + "' ";
                    }

                    FbCommand select = new FbCommand();
                    select.CommandText =

/*
                    "select   pv.vendedor_ped_venda vendedor,    p.nome_familia_produto, " + 
"'0' as Meta_Fisica, sum(item.QTDE_ITEM) as Resultado_Fisico, "+
"'0' as Meta_Positivacao, '0' as Resultado_Positivacao,  " +
" '0' as Preco_Medio_Venda, sum(item.PRECO_TOTAL_item) as Valor_Total, p.VALOR_PROMOCAO_PRODUTO as Valor_Minimo_Venda, sum(PRECO_MINIMO_ITEM) as Total_Minimo_Venda, " + 
"(select sum(inf2.PRECO_TOTAL_item) "+ 
"  from itens_nota inf2 " + 
"  inner join nota_fiscal nf2        on nf2.n_nf = inf2.nf_item  " + 
"  inner join pedidos_nf pnf2        on pnf2.nf_pedido_nf = nf2.n_nf " + 
"  inner join pedidos_venda pv2        on pv2.cod_ped_venda = pnf2.n_pedido_nf " + 
"  inner join produtos p2 on (CAST(p2.cod_produto AS VARCHAR(50)) = CAST(inf2.cod_item AS VARCHAR(50))  or CAST(p2.cod_fornecedor_produto AS VARCHAR(50)) = CAST(inf2.cod_item AS VARCHAR(50))) " + 
" inner join cfo cfo2 on cfo2.n_cfo = inf2.cfop_item " + 
"   inner join metas_produto_vendedor m2 on m2.COD_VENDEDOR_MPV = pv2.cod_vendedor_ped_venda and m2.familia_mpv = p2.NOME_FAMILIA_PRODUTO " +
"   where nf2.data_emissao_nf >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") + "'    and nf2.data_emissao_nf <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
"    and pv2.cod_vendedor_ped_venda = '" + _vendedor + "'    and nf2.status_nfe like '%Autorizada%' " + 
"    and (inf2.cfop_item = '5910'    or inf2.cfop_item = '6910') "+ 
"    and p2.nome_familia_produto = p.nome_familia_produto) as Bonificacoes, " + */

//VALOR_VENDA
"select   pv.vendedor_ped_venda vendedor,    p.nome_familia_produto, '0' as Meta_Fisica, " +
"(select sum(inf1.QTDE_ITEM) " +
                    "from itens_nota inf1   inner join nota_fiscal nf1        on nf1.n_nf = inf1.nf_item " +
 " inner join pedidos_nf pnf1        on pnf1.nf_pedido_nf = nf1.n_nf " +
"  inner join pedidos_venda pv1        on pv1.cod_ped_venda = pnf1.n_pedido_nf " +
"   inner join produtos p1 on (CAST(p1.cod_produto AS VARCHAR(50)) = CAST(inf1.cod_item AS VARCHAR(50))  or CAST(p1.cod_fornecedor_produto AS VARCHAR(50)) = CAST(inf1.cod_item AS VARCHAR(50))) " +
"   inner join cfo cfo1 on cfo1.n_cfo = inf1.cfop_item " +
 "    inner join metas_produto_vendedor m1 on m1.COD_VENDEDOR_MPV = pv1.cod_vendedor_ped_venda and m1.familia_mpv = p1.NOME_FAMILIA_PRODUTO " +
"     where nf1.data_emissao_nf >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") + "' " +
                    " and nf1.data_emissao_nf <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
  "     and pv1.cod_vendedor_ped_venda = '" + _vendedor + "'    and nf1.status_nfe like '%Autorizada%' " +
  "       and (inf1.cfop_item = '5102'	" +
"	or inf1.cfop_item = '5405')  and cfo1.tributada_cfo = '1' " +
 "          and p1.nome_familia_produto = p.nome_familia_produto) as Resultado_Fisico, '0' as Meta_Positivacao, '0' as Resultado_Positivacao, " +
" '0' as Preco_Medio_Venda, " +
" (select sum(inf2.PRECO_TOTAL_item) " +
                    "from itens_nota inf2   inner join nota_fiscal nf2        on nf2.n_nf = inf2.nf_item " +
 " inner join pedidos_nf pnf2        on pnf2.nf_pedido_nf = nf2.n_nf " +
"  inner join pedidos_venda pv2        on pv2.cod_ped_venda = pnf2.n_pedido_nf " +
"   inner join produtos p2 on (CAST(p2.cod_produto AS VARCHAR(50)) = CAST(inf2.cod_item AS VARCHAR(50))  or CAST(p2.cod_fornecedor_produto AS VARCHAR(50)) = CAST(inf2.cod_item AS VARCHAR(50))) " +
"   inner join cfo cfo2 on cfo2.n_cfo = inf2.cfop_item " +
 "    inner join metas_produto_vendedor m2 on m2.COD_VENDEDOR_MPV = pv2.cod_vendedor_ped_venda and m2.familia_mpv = p2.NOME_FAMILIA_PRODUTO " +
"     where nf2.data_emissao_nf >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") + "' " +
                    " and nf2.data_emissao_nf <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
  "     and pv2.cod_vendedor_ped_venda = '" + _vendedor + "'    and nf2.status_nfe like '%Autorizada%' " +
  "        and (inf2.cfop_item = '5102'	" +
"	or inf2.cfop_item = '5405')  and cfo2.tributada_cfo = '1' " +
 "          and p2.nome_familia_produto = p.nome_familia_produto) as Valor_Total, " +

 " p.VALOR_PROMOCAO_PRODUTO as Valor_Minimo_Venda, " +
                        //VALOR_VENDA_MINIMO
"  (select sum(inf3.PRECO_MINIMO_ITEM) " +
"  from itens_nota inf3   inner join nota_fiscal nf3        on nf3.n_nf = inf3.nf_item " +
"  inner join pedidos_nf pnf3        on pnf3.nf_pedido_nf = nf3.n_nf " +
"  inner join pedidos_venda pv3        on pv3.cod_ped_venda = pnf3.n_pedido_nf " +
"  inner join produtos p3 on (CAST(p3.cod_produto AS VARCHAR(50)) = CAST(inf3.cod_item AS VARCHAR(50))  or CAST(p3.cod_fornecedor_produto AS VARCHAR(50)) = CAST(inf3.cod_item AS VARCHAR(50))) " +
"   inner join cfo cfo3 on cfo3.n_cfo = inf3.cfop_item " +
"     inner join metas_produto_vendedor m3 on m3.COD_VENDEDOR_MPV = pv3.cod_vendedor_ped_venda and m3.familia_mpv = p3.NOME_FAMILIA_PRODUTO " +
"     where nf3.data_emissao_nf >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") + "' " +
                    " and nf3.data_emissao_nf <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
"       and pv3.cod_vendedor_ped_venda = '" + _vendedor + "'   and nf3.status_nfe like '%Autorizada%' " +
 "         and (inf3.cfop_item = '5102'	" +
"	or inf3.cfop_item = '5405')" +
 "          and p3.nome_familia_produto = p.nome_familia_produto) as Total_Minimo_Venda, " +
                        //BONIFICACOES
 "(select sum(inf4.PRECO_TOTAL_item) " +
"  from itens_nota inf4   inner join nota_fiscal nf4        on nf4.n_nf = inf4.nf_item " +
"  inner join pedidos_nf pnf4        on pnf4.nf_pedido_nf = nf4.n_nf " +
"  inner join pedidos_venda pv4       on pv4.cod_ped_venda = pnf4.n_pedido_nf " +
"   inner join produtos p4 on (CAST(p4.cod_produto AS VARCHAR(50)) = CAST(inf4.cod_item AS VARCHAR(50))  or CAST(p4.cod_fornecedor_produto AS VARCHAR(50)) = CAST(inf4.cod_item AS VARCHAR(50))) " +
"   inner join cfo cfo4 on cfo4.n_cfo = inf4.cfop_item " +
"     inner join metas_produto_vendedor m4 on m4.COD_VENDEDOR_MPV = pv4.cod_vendedor_ped_venda and m4.familia_mpv = p4.NOME_FAMILIA_PRODUTO " +
" where nf4.data_emissao_nf >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") + "' " +
                    " and nf4.data_emissao_nf <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
"       and pv4.cod_vendedor_ped_venda = '" + _vendedor + "'   and nf4.status_nfe like '%Autorizada%' " +
"and (inf4.cfop_item = '5910'    or inf4.cfop_item = '6910') " +
 "          and p4.nome_familia_produto = p.nome_familia_produto) as Bonificacoes, " +

"'0' as Diferenca " +
" from itens_nota item " +
" inner join nota_fiscal nf        on nf.n_nf = item.nf_item " +
 "inner join pedidos_nf pnf        on pnf.nf_pedido_nf = nf.n_nf " +
" inner join pedidos_venda pv        on pv.cod_ped_venda = pnf.n_pedido_nf " +
" inner join produtos p        on (CAST(p.cod_produto AS VARCHAR(50)) = CAST(item.cod_item AS VARCHAR(50)) " +
" or CAST(p.cod_fornecedor_produto AS VARCHAR(50)) = CAST(item.cod_item AS VARCHAR(50))) " +
" inner join cfo on cfo.n_cfo = item.cfop_item " +
" inner join metas_produto_vendedor m on m.COD_VENDEDOR_MPV = pv.cod_vendedor_ped_venda and m.familia_mpv = p.NOME_FAMILIA_PRODUTO " +
"where nf.data_emissao_nf >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") + "' " +
                            "   and nf.data_emissao_nf <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                            cliente +
                            vendedor +
                            fornecedor +
                            "   and nf.status_nfe like '%Autorizada%' " +
                        //  "   and item.cfop_item <> '5910' " +
                        //    "   and item.cfop_item <> '6910' " +
                            "   and cfo.tributada_cfo = '1' " +
                            "group by " +
                            "   pv.vendedor_ped_venda, p.nome_familia_produto, p.VALOR_PROMOCAO_PRODUTO";
                    select.Connection = fbConnection1;
                    FbDataAdapter datSelect = new FbDataAdapter();
                    datSelect.SelectCommand = select;
                    dtSelect_metas.Clear();
                    datSelect.Fill(dtSelect_metas);
                    fbConnection1.Close();

                    dgvPedidos.DataSource = dtSelect_metas;

                    buscar_informacoes_meta(_vendedor, true);
                    somar_totais_meta();

                }
                else
                    MessageBox.Show("Para essa pesquisa, por favor, selecione o vendedor");
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }

        }

        private void somar_totais_meta()
        {

        }

        private void buscar_informacoes_meta(string _vendedor, bool credito)
        {
            try
            {
                //buscando_totalizadores_positivacao

                string vendedor = "", cliente = "", fornecedor =  "";

                if (cb_vendedor.Checked == true)
                {
                    vendedor = " and pv.cod_vendedor_ped_venda = '" + _vendedor + "' ";
                }
                if (cb_cliente.Checked == true)
                {
                    cliente = " and pv.cliente_ped_venda = '" + tb_nome_cliente.Text + "' ";
                }
                if (cb_fornecedor.Checked == true)
                {
                    fornecedor = " and p.nome_fornecedor_produto = '" + tb_nome_fornecedor.Text + "' ";
                }



                FbCommand select_positivacao = new FbCommand();
                select_positivacao.CommandText =
                "select  pv.vendedor_ped_venda as vendedor,    p.nome_familia_produto as familia, " +
                "COUNT(DISTINCT(nf.CNPJ_CLIENTE_FORN)) as cont " +

    " from itens_nota item " +
    " inner join nota_fiscal nf        on nf.n_nf = item.nf_item " +
    "inner join pedidos_nf pnf        on pnf.nf_pedido_nf = nf.n_nf " +
    " inner join pedidos_venda pv        on pv.cod_ped_venda = pnf.n_pedido_nf " +
    " inner join produtos p        on (CAST(p.cod_produto AS VARCHAR(50)) = CAST(item.cod_item AS VARCHAR(50)) " +
                "or CAST(p.cod_fornecedor_produto AS VARCHAR(50)) = CAST(item.cod_item AS VARCHAR(50))) " +
    " inner join cfo        on cfo.n_cfo = item.cfop_item " +
    " inner join metas_produto_vendedor m        on m.COD_VENDEDOR_MPV = pv.cod_vendedor_ped_venda and m.familia_mpv = p.NOME_FAMILIA_PRODUTO " +
    "where nf.data_emissao_nf >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") + "' " +
                        "   and nf.data_emissao_nf <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                        cliente +
                        vendedor +
                        fornecedor +
                        "   and nf.status_nfe like '%Autorizada%' " +
                       "and (item.cfop_item like '_1__'	" +
"	or item.cfop_item like '_4__')	" +
                        "   and cfo.tributada_cfo = '1' " +
                        "group by " +
                        "   pv.vendedor_ped_venda, p.nome_familia_produto";
                select_positivacao.Connection = fbConnection1;
                FbDataAdapter datSelect_positivacao = new FbDataAdapter();
                datSelect_positivacao.SelectCommand = select_positivacao;
                DataTable dtSelect_positivacao = new DataTable();
                datSelect_positivacao.Fill(dtSelect_positivacao);
                fbConnection1.Close();

                double valor_total = 0;

                for (int i = 0; i < dgvPedidos.RowCount; i++)
                {

                    try
                    {
                        double valor_familia = 0;
                        try
                        {
                            valor_familia = Convert.ToDouble(dgvPedidos.Rows[i].Cells[7].Value.ToString());
                        }
                        catch { }
                        valor_total = valor_total + valor_familia;

                        FbCommand select = new FbCommand();
                        select.CommandText =
                            "SELECT META_FISICA_MPV, META_POSITIVACAO_MPV, META_VALOR_MPV FROM METAS_PRODUTO_VENDEDOR m INNER JOIN VENDEDORES v ON m.COD_VENDEDOR_MPV = v.COD_VENDEDOR " +
                        "WHERE NOME_VENDEDOR = '" + dgvPedidos.Rows[i].Cells[0].Value.ToString() +
                        "' AND FAMILIA_MPV = '" + dgvPedidos.Rows[i].Cells[1].Value.ToString() + "'";
                        select.Connection = fbConnection1;
                        fbConnection1.Open();
                        FbDataAdapter datSelect = new FbDataAdapter();
                        datSelect.SelectCommand = select;
                        DataTable dtSelect = new DataTable();
                        datSelect.Fill(dtSelect);
                        fbConnection1.Close();
                        foreach (DataRow dr in dtSelect.Rows)
                        {
                            dgvPedidos.Rows[i].Cells[2].Value = dr[0].ToString();
                            dgvPedidos.Rows[i].Cells[4].Value = dr[1].ToString();
                            dgvPedidos.Rows[i].Cells[6].Value = dr[2].ToString();

                        }
                        foreach (DataRow dr_pos in dtSelect_positivacao.Select("vendedor = '" + dgvPedidos.Rows[i].Cells[0].Value.ToString() +
                        "' AND familia = '" + dgvPedidos.Rows[i].Cells[1].Value.ToString() + "'"))
                        {
                            dgvPedidos.Rows[i].Cells[5].Value = dr_pos[2].ToString();
                        }

                        if (credito)
                            buscar_credito(valor_familia, i);
                    }
                    catch { }
                }
                tb_valor_total.Text = valor_total.ToString("n2");

            }
            catch { }
        }

        private void buscar_credito(double valor_familia, int i)
        {
            double total_diferenca = 0;
            double preco_medio = 0;
            try
            {
                try
                {
                    preco_medio = valor_familia / Convert.ToDouble(dgvPedidos.Rows[i].Cells[3].Value.ToString());
                }
                catch { }
                dgvPedidos.Rows[i].Cells[6].Value = preco_medio.ToString("n2");


                double preco_minimo = 0;
                try { preco_minimo = Convert.ToDouble(dgvPedidos.Rows[i].Cells[8].Value.ToString()); }
                catch { }

                double total_minimo = 0; try { total_minimo = Convert.ToDouble(dgvPedidos.Rows[i].Cells[9].Value.ToString()); }
                catch { }


                double total_medio = 0; try { total_medio = Convert.ToDouble(dgvPedidos.Rows[i].Cells[7].Value.ToString()); }
                catch { }
                double total_boni = 0; try { total_boni = Convert.ToDouble(dgvPedidos.Rows[i].Cells[10].Value.ToString()); }
                catch { }
                double diferenca = total_medio - total_minimo - total_boni;
                dgvPedidos.Rows[i].Cells[9].Value = total_minimo.ToString("n2").Replace(".","");
                dgvPedidos.Rows[i].Cells[11].Value = diferenca.ToString("n2").Replace(".","");
                total_diferenca = total_diferenca + diferenca;
                if (diferenca < 0)
                    dgvPedidos.Rows[i].Cells[11].Style.BackColor = Color.Red;
                else
                    dgvPedidos.Rows[i].Cells[11].Style.BackColor = Color.GreenYellow;

            }
            catch (Exception a)
            {
                fbConnection1.Close();
                // MessageBox.Show(a.ToString());
            }




        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button8_Click_3(object sender, EventArgs e)
        {
            form_localiza_produto prod = new form_localiza_produto(true, cnpj_empresa);
            try
            {
                prod.buscar = true;
                //prod.usuario = usuario;
                prod.ShowDialog();

            }
            finally
            {
                tb_cod_produto.Text = prod.cod_produto_escolhido;
                tb_nome_produto.Text = prod.descricao_produto_escolhido;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dsComissao com = new dsComissao();

            for (int i = 0; i < dgvPedidos.RowCount; i++)
            {
                double meta_fisica = 0, resultado_fisico = 0, meta_positivacao = 0, resultado_positivacao = 0, preco_medio = 0, valor_total = 0,
                    valor_minimo = 0, total_minimo = 0, bonificacoes = 0, resultado = 0;

                try
                {
                    meta_fisica = Convert.ToDouble(dgvPedidos.Rows[i].Cells[2].Value.ToString());
                }
                catch { }
                try
                {
                    resultado_fisico = Convert.ToDouble(dgvPedidos.Rows[i].Cells[3].Value.ToString());
                }
                catch { }
                try
                {
                    meta_positivacao = Convert.ToDouble(dgvPedidos.Rows[i].Cells[4].Value.ToString());
                }
                catch { }
                try
                {
                    resultado_positivacao = Convert.ToDouble(dgvPedidos.Rows[i].Cells[5].Value.ToString());
                }
                catch { }
                try
                {
                    preco_medio = Convert.ToDouble(dgvPedidos.Rows[i].Cells[6].Value.ToString());
                }
                catch { }
                try
                {
                    valor_total = Convert.ToDouble(dgvPedidos.Rows[i].Cells[7].Value.ToString());
                }
                catch { }
                try
                {
                    valor_minimo = Convert.ToDouble(dgvPedidos.Rows[i].Cells[8].Value.ToString());
                }
                catch { }
                try
                {
                    total_minimo = Convert.ToDouble(dgvPedidos.Rows[i].Cells[9].Value.ToString());
                }
                catch { }
                try
                {
                    bonificacoes = Convert.ToDouble(dgvPedidos.Rows[i].Cells[10].Value.ToString());
                }
                catch { }
                try
                {
                    resultado = Convert.ToDouble(dgvPedidos.Rows[i].Cells[11].Value.ToString());
                }
                catch { }
                com.METAS.AddMETASRow(dgvPedidos.Rows[i].Cells[0].Value.ToString(), dgvPedidos.Rows[i].Cells[1].Value.ToString(),
                    meta_fisica, resultado_fisico, meta_positivacao, resultado_positivacao, preco_medio, valor_total, valor_minimo, total_minimo, bonificacoes, resultado);

            }
            crComissao cr = new crComissao();
            cr.SetDataSource(com);

            form_imprimir imprimir = new form_imprimir(cr);
            imprimir.Show();



        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                string _vendedor = "", _fornecedor = "", _cliente =  "";
                if (tb_nome_vendedor.Text != "")
                    _vendedor = " AND ped.VENDEDOR_PED_VENDA = '" + tb_nome_vendedor.Text + "' ";

                if (tb_nome_fornecedor.Text != "")
                    _fornecedor = " AND prod.NOME_FORNECEDOR_PRODUTO = '" + tb_nome_fornecedor.Text + "' ";

                if (tb_nome_cliente.Text != "")
                    _cliente = " AND nf.CNPJ_CLIENTE_FORN = '" + tb_cnpj.Text + "' ";

                string _cfop = " and (item.cfop_item like '_1__'	" +
                   "	or item.cfop_item like '_4__') ";
                if (cbCfop.Checked)
                {
                    _cfop = "  and (item.cfop_item = '" + tb_n_cfop.Text + "'	" +
                    "	or item.cfop_item = '6" + tb_n_cfop.Text.Substring(1, 3) + "' ) ";
                }

                List<string> lVendedor = new List<string>();

                dsClientesxproduto cli = new dsClientesxproduto();
                FbCommand select = new FbCommand();
                select.CommandText =
                    "select sum(item.qtde_item), prod.COD_PRODUTO, '', ped.VENDEDOR_PED_VENDA, sum(item.PRECO_TOTAL_ITEM), SUM(item.CUSTO_ITEM) from itens_nota item " +
                    "inner join produtos prod on prod.cod_fornecedor_produto = item.cod_item " +
                    "INNER JOIN nota_fiscal nf ON ITEM.NF_ITEM = NF.N_NF " +
                    "INNER JOIN PEDIDOS_NF ped_nf on nf.n_nf = ped_nf.nf_pedido_nf " +
                    "inner join pedidos_venda ped on ped.cod_ped_venda = ped_nf.n_pedido_nf " +
                    "where " +
                    "nf.STATUS_NFE LIKE ('%Autorizada%') AND " +
                    "nf.data_emissao_nf >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") +
                    "' and nf.data_emissao_nf <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                    _vendedor + _fornecedor + _cliente +
                    _cfop +
                    "group by ped.VENDEDOR_PED_VENDA, prod.COD_PRODUTO";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {

                    lVendedor.Add(dr[3].ToString());

                    double custo = 0;
                    try
                    {
                        custo = Convert.ToDouble(dr[5].ToString());
                    }
                    catch { }
                    try
                    {
                        cli.VendedorxClientesxProdutos.AddVendedorxClientesxProdutosRow(Convert.ToDouble(dr[0].ToString()), Convert.ToInt32(dr[1].ToString()),
                            dr[2].ToString(), dr[3].ToString(), Convert.ToDouble(dr[4].ToString()), custo, 0, 0, 0, 0, 0, 0);
                    }
                    catch { }
                }

                var y = lVendedor.Distinct<string>();

                var listaVendedor = y.ToList<string>();


                for (int i = 0; i < listaVendedor.Count; i++)
                {
                    double valor_trocas = 0;
                    try
                    {
                        //buscando valor_troca
                        FbCommand select_troca = new FbCommand();
                        select_troca.CommandText =
                      "select sum(item.qtde_item), prod.COD_PRODUTO, '', ped.VENDEDOR_PED_VENDA, (sum(item.PRECO_TOTAL_ITEM)*-1), " +
                      "SUM(item.CUSTO_ITEM) from itens_nota item " +
                      "inner join produtos prod on prod.cod_fornecedor_produto = item.cod_item " +
                      "INNER JOIN nota_fiscal nf ON ITEM.NF_ITEM = NF.N_NF " +
                      "INNER JOIN PEDIDOS_NF ped_nf on nf.n_nf = ped_nf.nf_pedido_nf " +
                      "inner join pedidos_venda ped on ped.cod_ped_venda = ped_nf.n_pedido_nf " +
                      "where " +
                      "nf.STATUS_NFE LIKE ('%Autorizada%') AND " +
                      "nf.data_emissao_nf >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") +
                      "' and nf.data_emissao_nf <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                       " AND item.cfop_item <> '5102'	" +
                       "	AND item.cfop_item <> '5405' and item.cfop_item <> '5910'" +
                            // " AND (ped.TROCA_PED_VENDA = 1) " +
                      " AND ped.VENDEDOR_PED_VENDA = '" + listaVendedor[i].ToString() + "' " +
                      "group by ped.VENDEDOR_PED_VENDA, prod.COD_PRODUTO ";


                        select_troca.Connection = fbConnection1;
                        fbConnection1.Open();
                        FbDataAdapter datSelect_troca = new FbDataAdapter();
                        datSelect_troca.SelectCommand = select_troca;
                        DataTable dtSelect_troca = new DataTable();
                        datSelect_troca.Fill(dtSelect_troca);
                        fbConnection1.Close();

                        foreach (DataRow dr_troca in dtSelect_troca.Rows)
                        {
                            try
                            {
                                valor_trocas = valor_trocas + Convert.ToDouble(dr_troca[0].ToString());
                            }
                            catch { }


                            cli.VendedorxClientesxProdutos.AddVendedorxClientesxProdutosRow(Convert.ToDouble(dr_troca[0].ToString()), Convert.ToInt32(dr_troca[1].ToString()),
                                dr_troca[2].ToString(), dr_troca[3].ToString(), Convert.ToDouble(dr_troca[4].ToString()), 0, 0, 0, 0, 0, 0, 0);
                        }
                    }
                    catch (Exception a)
                    {
                        fbConnection1.Close();

                    }
                }


                FbCommand select_clientes = new FbCommand();
                select_clientes.CommandText =
                    "SELECT * from clientes";
                select_clientes.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect_clientes = new FbDataAdapter();
                datSelect_clientes.SelectCommand = select_clientes;
                datSelect_clientes.Fill(cli.CLIENTES);
                fbConnection1.Close();

                FbCommand select_produtos = new FbCommand();
                select_produtos.CommandText =
                    "SELECT * from produtos";
                select_produtos.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect_produtos = new FbDataAdapter();
                datSelect_produtos.SelectCommand = select_produtos;
                datSelect_produtos.Fill(cli.PRODUTOS);
                fbConnection1.Close();


                FbCommand select_comissao = new FbCommand();
                select_comissao.CommandText =
                    "SELECT * from COMISSAO_PRODUTO_VENDEDOR";
                select_comissao.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect_comissao = new FbDataAdapter();
                datSelect_comissao.SelectCommand = select_comissao;
                datSelect_comissao.Fill(cli.COMISSAO_PRODUTO_VENDEDOR);
                fbConnection1.Close();


                cli.Dados.AddDadosRow(tb_nome_fornecedor.Text, Convert.ToDateTime(dtInicial.Text), Convert.ToDateTime(dtFinal.Text),
                    tb_nome_vendedor.Text, "", "",0);

                crVendedorxProdutosxComissaoporvendedor cr = new crVendedorxProdutosxComissaoporvendedor();
                cr.SetDataSource(cli);
                form_imprimir imprime = new form_imprimir(cr);
                imprime.Show();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (tb_nome_vendedor.Text == "*")
            {
                dtInicial.Text = "01.10.2015";
                dtFinal.Text = "01.01.2100";
            }
            if (tb_nome_vendedor.Text == "*")
            {
                compilar_todos_vendedores("comissoes");
            }
            else
            {
                comissoes(tb_cod_vendedor.Text);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                string _vendedor = "", _fornecedor = "", _cliente = "", _familia =  "";

                if (tbGrupo.Text != "")
                    _familia = " AND prod.DESCRICAO_GRUPO_PRODUTO = '" + tbGrupo.Text + "' ";
                if (tbdescricaoSubgrupo.Text != "")
                    _familia = " AND prod.DESCRICAO_SUB_GRUPO_PRODUTO = '" + tbdescricaoSubgrupo.Text + "' ";
                if (tb_nome_produto.Text != "")
                    _familia = " AND prod.COD_PRODUTO = '" + tb_cod_produto.Text + "' ";

                if (tbFamilia.Text != "")
                    _familia += " AND prod.NOME_FAMILIA_PRODUTO = '" + tbFamilia.Text + "'";

                if (tb_nome_vendedor.Text != "")
                    _vendedor = " AND ped.VENDEDOR_PED_VENDA = '" + tb_nome_vendedor.Text + "' ";

                if (tb_nome_fornecedor.Text != "")
                    _fornecedor = " AND prod.NOME_FORNECEDOR_PRODUTO = '" + tb_nome_fornecedor.Text + "' ";

                if (tb_nome_cliente.Text != "")
                    _cliente = " AND nf.CNPJ_CLIENTE_FORN = '" + tb_cnpj.Text + "' ";
                if (tb_cod_matriz.Text != "")
                    _cliente = " AND c.COD_MATRIZ_CLIENTE = '" + tb_cod_matriz.Text + "' ";
 

                string _cfop = " and (item.cfop_item like '_1__'	" +
                   "	or item.cfop_item like '_4__') ";
                if (cbCfop.Checked)
                {
                    _cfop = "  and (item.cfop_item = '" + tb_n_cfop.Text + "'	" +
                    "	or item.cfop_item = '6" + tb_n_cfop.Text.Substring(1, 3) + "' ) ";
                }
                dsClientesxproduto cli = new dsClientesxproduto();
                FbCommand select = new FbCommand();
                select.CommandText =
                    //"select sum(item.qtde_item), prod.COD_PRODUTO, '', ped.VENDEDOR_PED_VENDA, sum(item.PRECO_TOTAL_ITEM) 
                    "select sum(item.qtde_item), prod.COD_PRODUTO, '', '', sum(item.PRECO_TOTAL_ITEM), " + 
                    "sum(item.CUSTO_ITEM), prod.CUSTO_MED_PRODUTO from itens_nota item " +
                    "inner join produtos prod on prod.cod_fornecedor_produto = item.cod_item " +
                    "INNER JOIN nota_fiscal nf ON ITEM.NF_ITEM = NF.N_NF " +
                    "INNER JOIN PEDIDOS_NF ped_nf on nf.n_nf = ped_nf.nf_pedido_nf " +
                    "inner join pedidos_venda ped on ped.cod_ped_venda = ped_nf.n_pedido_nf " +
                     "inner join clientes c on nf.CNPJ_CLIENTE_FORN = c.CNPJ " + 
                    "where " +
                    "nf.STATUS_NFE LIKE ('%Autorizada%') AND " +
                    "nf.data_emissao_nf >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") +
                    "' and nf.data_emissao_nf <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                    _vendedor + _fornecedor + _cliente + _familia +
                    _cfop +
                      "group by prod.COD_PRODUTO, prod.CUSTO_MED_PRODUTO " +
                    "ORDER BY 5 DESC";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    double custo = 0, ultima_nf = 0;
                    try
                    {
                        custo = Convert.ToDouble(dr[5].ToString());
                        
                    }
                    catch { }
                    try{
                        ultima_nf = Convert.ToDouble(dr[6].ToString());
                    }
                    catch{
                    }
                    try
                    {
                        cli.VendedorxClientesxProdutos.AddVendedorxClientesxProdutosRow(Convert.ToDouble(dr[0].ToString()), Convert.ToInt32(dr[1].ToString()),
                            dr[2].ToString(), dr[3].ToString(), Convert.ToDouble(dr[4].ToString()), custo, ultima_nf, 0, 0, 0, 0, 0);
                    }
                    catch { }
                }

                //FbCommand select_clientes = new FbCommand();
                //select_clientes.CommandText =
                //    "SELECT * from clientes";
                //select_clientes.Connection = fbConnection1;
                //fbConnection1.Open();
                //FbDataAdapter datSelect_clientes = new FbDataAdapter();
                //datSelect_clientes.SelectCommand = select_clientes;
                //datSelect_clientes.Fill(cli.CLIENTES);
                //fbConnection1.Close();

                FbCommand select_produtos = new FbCommand();
                select_produtos.CommandText =
                    "SELECT * from produtos";
                select_produtos.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect_produtos = new FbDataAdapter();
                datSelect_produtos.SelectCommand = select_produtos;
                datSelect_produtos.Fill(cli.PRODUTOS);
                fbConnection1.Close();

                cli.Dados.AddDadosRow(tb_nome_fornecedor.Text, Convert.ToDateTime(dtInicial.Text), Convert.ToDateTime(dtFinal.Text),
                    tb_nome_vendedor.Text, "", "",0);


                crProdutosxlucratividade cr = new crProdutosxlucratividade();
                cr.SetDataSource(cli);
                form_imprimir imprime = new form_imprimir(cr);
                imprime.Show();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            try
            {
                string _vendedor = "", _fornecedor = "", _cliente = "", _familia =  "";
                //DESCRICAO_GRUPO_PRODUTO
                if (tbGrupo.Text != "")
                    _familia = " AND prod.DESCRICAO_GRUPO_PRODUTO = '" + tbGrupo.Text + "' ";
                if (tbdescricaoSubgrupo.Text != "")
                    _familia = " AND prod.DESCRICAO_SUB_GRUPO_PRODUTO = '" + tbdescricaoSubgrupo.Text + "' ";
                if (tb_nome_produto.Text != "")
                    _familia = " AND prod.COD_PRODUTO = '" + tb_cod_produto.Text + "' ";

                if (tbFamilia.Text != "")
                    _familia += " AND prod.NOME_FAMILIA_PRODUTO = '" + tbFamilia.Text + "' ";

                if (tb_nome_vendedor.Text != "")
                    _vendedor = " AND ped.VENDEDOR_PED_VENDA = '" + tb_nome_vendedor.Text + "' ";

                if (tb_nome_fornecedor.Text != "")
                    _fornecedor = " AND prod.NOME_FORNECEDOR_PRODUTO = '" + tb_nome_fornecedor.Text + "' ";

                if (tb_nome_cliente.Text != "")
                    _cliente = " AND nf.CNPJ_CLIENTE_FORN = '" + tb_cnpj.Text + "' ";
                if (tb_cod_matriz.Text != "")
                    _cliente = " AND c.COD_MATRIZ_CLIENTE = '" + tb_cod_matriz.Text + "' ";
 

                string _cfop = " and (item.cfop_item like '_1__'	" +
                   "	or item.cfop_item like '_4__') ";
                if (cbCfop.Checked)
                {
                    _cfop = "  and (item.cfop_item = '" + tb_n_cfop.Text + "'	" +
                    "	or item.cfop_item = '6" + tb_n_cfop.Text.Substring(1, 3) + "' ) ";
                }
                dsClientesxproduto cli = new dsClientesxproduto();
                FbCommand select = new FbCommand();
                select.CommandText =
                //"select sum(item.qtde_item), prod.COD_PRODUTO, '', ped.VENDEDOR_PED_VENDA, sum(item.PRECO_TOTAL_ITEM) 
                "select sum(item.qtde_item), prod.COD_PRODUTO, '', '', sum(item.PRECO_TOTAL_ITEM), SUM(item.CUSTO_ITEM) from itens_nota item " +
                "inner join produtos prod on prod.cod_fornecedor_produto = item.cod_item " +
                "INNER JOIN nota_fiscal nf ON ITEM.NF_ITEM = NF.N_NF " +
                "INNER JOIN PEDIDOS_NF ped_nf on nf.n_nf = ped_nf.nf_pedido_nf " +
                "inner join pedidos_venda ped on ped.cod_ped_venda = ped_nf.n_pedido_nf " +
                 "inner join vendedores v on ped.COD_VENDEDOR_PED_VENDA = V.COD_VENDEDOR " +
                  "inner join clientes c on nf.CNPJ_CLIENTE_FORN = c.CNPJ " + 
                "where " +
                "nf.STATUS_NFE LIKE ('%Autorizada%') AND " +
                "nf.data_emissao_nf >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") +
                "' and nf.data_emissao_nf <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                _vendedor + _fornecedor + _cliente + _familia + supervisor + 
                _cfop +
                "group by prod.COD_PRODUTO " +
                " ORDER BY 1 desc "; 
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    double custo = 0;
                    try
                    {
                        custo = Convert.ToDouble(dr[5].ToString());
                    }
                    catch { }
                    try
                    {
                        cli.VendedorxClientesxProdutos.AddVendedorxClientesxProdutosRow(Convert.ToDouble(dr[0].ToString()), Convert.ToInt32(dr[1].ToString()),
                            dr[2].ToString(), dr[3].ToString(), Convert.ToDouble(dr[4].ToString()), custo, 0, 0, 0, 0, 0, 0);
                    }
                    catch { }
                }

                /*
                FbCommand select_clientes = new FbCommand();
                select_clientes.CommandText =
                    "SELECT * from clientes";
                select_clientes.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect_clientes = new FbDataAdapter();
                datSelect_clientes.SelectCommand = select_clientes;
                datSelect_clientes.Fill(cli.CLIENTES);
                fbConnection1.Close();
                */ 
                FbCommand select_produtos = new FbCommand();
                select_produtos.CommandText =
                    "SELECT * from produtos";
                select_produtos.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect_produtos = new FbDataAdapter();
                datSelect_produtos.SelectCommand = select_produtos;
                datSelect_produtos.Fill(cli.PRODUTOS);
                fbConnection1.Close();

                cli.Dados.AddDadosRow(tb_nome_fornecedor.Text, Convert.ToDateTime(dtInicial.Text), Convert.ToDateTime(dtFinal.Text),
                    tb_nome_vendedor.Text, "", "",0);


                crProdutosxABC cr = new crProdutosxABC();
                cr.SetDataSource(cli);
                form_imprimir imprime = new form_imprimir(cr);
                imprime.Show();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                string fechados = "", faturados =  "";
                string tipo =  "";

                string data =  "";
                string _vendedor = "", _fornecedor = "", _cliente = "", _cliente_ent = "", _vendedor_ent =  "";
                if (tb_nome_vendedor.Text != "")
                {
                    _vendedor = " AND ped.VENDEDOR_PED_VENDA = '" + tb_nome_vendedor.Text + "' ";
                    _vendedor_ent = "AND vc.NOME_VENDEDOR_VC = '" + tb_nome_vendedor.Text + "' ";
                }

                string _fornecedor_ent =  "";
                if (tb_nome_fornecedor.Text != "")
                {
                    _fornecedor = " AND prod.NOME_FORNECEDOR_PRODUTO = '" + tb_nome_fornecedor.Text + "' ";
                    _fornecedor_ent = " AND prod.NOME_FORNECEDOR_PRODUTO = '" + tb_nome_fornecedor.Text + "' ";
                }

                if (tb_nome_cliente.Text != "")
                {
                    _cliente = " AND nf.CNPJ_CLIENTE_FORN = '" + tb_cnpj.Text + "' ";
                    _cliente_ent = " AND nfe.CNPJ_CLIENTE_FORN_ENT = '" + tb_cnpj.Text + "' ";
                }

                if (tb_cod_matriz.Text != "")
                {
                    _cliente = " AND c.COD_MATRIZ_CLIENTE = '" + tb_cod_matriz.Text + "' ";
                    _cliente_ent = " AND c.COD_MATRIZ_CLIENTE = '" + tb_cod_matriz.Text + "' ";
                }

                string _cfop = " and (item.cfop_item like '_1__'	" +
                  "	or item.cfop_item like '_4__') ";
                if (cbCfop.Checked)
                {
                    _cfop = "  and (item.cfop_item = '" + tb_n_cfop.Text + "'	" +
                    "	or item.cfop_item = '6" + tb_n_cfop.Text.Substring(1, 3) + "' ) ";
                }
                /*

                string _cfop =  "";
                if (cbCfop.Checked)
                {
                    _cfop = "  and (item.cfop_item = '" + tb_n_cfop.Text + "'	" +
                    "	or item.cfop_item = '6" + tb_n_cfop.Text.Substring(1, 3) + "' ) ";
                }
              
                */

                // buscando valor total
                double valor_total = 0;
                FbCommand select2 = new FbCommand();
                select2.Connection = fbConnection1;
                fbConnection1.Open();
                select2.CommandText =
                                "select sum(item.PRECO_TOTAL_ITEM) from itens_nota item " +
                    "inner join produtos prod on prod.cod_fornecedor_produto = item.cod_item " +
                    "INNER JOIN nota_fiscal nf ON ITEM.NF_ITEM = NF.N_NF " +
                    "INNER JOIN PEDIDOS_NF ped_nf on nf.n_nf = ped_nf.nf_pedido_nf " +
                    "inner join pedidos_venda ped on ped.cod_ped_venda = ped_nf.n_pedido_nf " +
                     "inner join clientes c on nf.CNPJ_CLIENTE_FORN = c.CNPJ " + 
                    "where " +
                    "nf.STATUS_NFE LIKE ('%Autorizada%') AND " +
                    "nf.data_emissao_nf >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") +
                    "' and nf.data_emissao_nf <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                    _vendedor + _fornecedor + _cliente +
                    _cfop;
                //  " AND ((ped.BONIFICACAO_PED_VENDA = '0' or ped.BONIFICACAO_PED_VENDA is null) and " +
                //            "(ped.TROCA_PED_VENDA = '0' or ped.TROCA_PED_VENDA is null))";
                //"SELECT SUM(VALOR_TOTAL_PROD_ITEM_VENDA) FROM ITENS_PEDIDO_VENDA ipv INNER JOIN " +
                //"PEDIDOS_VENDA pv ON ipv.COD_PEDIDO_ITEM_VENDA = pv.COD_PED_VENDA " +
                //"WHERE 0 = 0 AND ((pv.BONIFICACAO_PED_VENDA = '0' or pv.BONIFICACAO_PED_VENDA is null) and " +
                //        "(pv.TROCA_PED_VENDA = '0' or pv.TROCA_PED_VENDA is null))" +
                //        fechados + faturados + data + tipo + cliente + vendedor + cnpj_cliente;
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
                    "select sum(item.PRECO_TOTAL_ITEM) from itens_nota item " +
                    "inner join produtos prod on prod.cod_fornecedor_produto = item.cod_item " +
                    "INNER JOIN nota_fiscal nf ON ITEM.NF_ITEM = NF.N_NF " +
                    "INNER JOIN PEDIDOS_NF ped_nf on nf.n_nf = ped_nf.nf_pedido_nf " +
                    "inner join pedidos_venda ped on ped.cod_ped_venda = ped_nf.n_pedido_nf " +
                     "inner join clientes c on nf.CNPJ_CLIENTE_FORN = c.CNPJ " + 
                    "where " +
                    "nf.STATUS_NFE LIKE ('%Autorizada%') AND " +
                    "nf.data_emissao_nf >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") +
                    "' and nf.data_emissao_nf <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                    _vendedor + _fornecedor + _cliente +
                    //_cfop +
                    //" AND ped.BONIFICACAO_PED_VENDA = '1' " +
                    " and item.cfop_item like '_910'	" +

                    "group by nf.N_NF, nf.DATA_EMISSAO_NF, nf.CLIENTE_FORN_NF";
                //"SELECT SUM(VALOR_TOTAL_PROD_ITEM_VENDA) FROM ITENS_PEDIDO_VENDA ipv INNER JOIN " +
                //"PEDIDOS_VENDA pv ON ipv.COD_PEDIDO_ITEM_VENDA = pv.COD_PED_VENDA " +
                //"inner join PRODUTOS prod ON ipv.COD_SISTEMA_PROD_ITEM_VENDA = prod.COD_PRODUTO " +
                //"WHERE 0 = 0 AND prod.NOME_FAMILIA_PRODUTO LIKE '%LEITE%' " +
                //        fechados + faturados + data + tipo + cliente + vendedor + cnpj_cliente;
                FbDataAdapter datSelect4 = new FbDataAdapter();
                datSelect4.SelectCommand = select4;
                DataTable dtSelect4 = new DataTable();
                datSelect4.Fill(dtSelect4);
                fbConnection1.Close();
                foreach (DataRow dr4 in dtSelect4.Rows)
                {
                    try
                    {
                        valor_leite += Convert.ToDouble(dr4[0].ToString());
                    }
                    catch { }
                }


                //buscando valor troca
                double valor_troca = 0;
                FbCommand select3 = new FbCommand();
                select3.Connection = fbConnection1;
                fbConnection1.Open();
                select3.CommandText =
                              "select sum(item.PRECO_TOTAL_ITEM) from itens_nota item " +
                    "inner join produtos prod on prod.cod_fornecedor_produto = item.cod_item " +
                    "INNER JOIN nota_fiscal nf ON ITEM.NF_ITEM = NF.N_NF " +
                    "INNER JOIN PEDIDOS_NF ped_nf on nf.n_nf = ped_nf.nf_pedido_nf " +
                    "inner join pedidos_venda ped on ped.cod_ped_venda = ped_nf.n_pedido_nf " +
                     "inner join clientes c on nf.CNPJ_CLIENTE_FORN = c.CNPJ " + 
                    "where " +
                    "nf.STATUS_NFE LIKE ('%Autorizada%') AND " +
                    "nf.data_emissao_nf >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") +
                    "' and nf.data_emissao_nf <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                    _vendedor + _fornecedor + _cliente +
                     " and item.cfop_item like '_949'	";
                //_cfop +
                //" AND ped.TROCA_PED_VENDA = '1' ";

                //"SELECT SUM(VALOR_TOTAL_PROD_ITEM_VENDA) FROM ITENS_PEDIDO_VENDA ipv INNER JOIN " +
                //"PEDIDOS_VENDA pv ON ipv.COD_PEDIDO_ITEM_VENDA = pv.COD_PED_VENDA " +
                //"WHERE 0 = 0 AND TROCA_PED_VENDA = '1' " +
                //        fechados + faturados + data + tipo + cliente + vendedor + cnpj_cliente;
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

                FbCommand sel9 = new FbCommand();
                FbDataAdapter datSel9 = new FbDataAdapter();
                DataTable dt9 = new DataTable();
                sel9.Connection = fbConnection1;
                sel9.CommandText =
                    "select sum(ent.preco_total_item_ent) from itens_nota_ent ent inner join " +
                    "nota_fiscal_ent nfe on ent.nf_item_ent = nfe.n_nf_ent " +
                    "inner join produtos prod on prod.COD_BARRAS_PRODUTO = ent.COD_EAN_ITEM_ENT " +
                     "inner join clientes c on nfe.CNPJ_CLIENTE_FORN_ENT = c.CNPJ " +
                "INNER JOIN vendedores_cliente vc on c.COD_CLIENTE = vc.COD_CLIENTE_VC " +
                    "where (ent.cfop_item_ent = '5202' or " +
                    "ent.cfop_item_ent = '6202' or ent.cfop_item_ent = '5411' or ent.cfop_item_ent = '6411') " +
                    "AND nfe.data_emissao_nf_ent >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") + "' " +
                    "and nfe.data_emissao_nf_ent <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                    "and nfe.baixada_nf_ent = 1 " + _cliente_ent + _vendedor_ent + _fornecedor_ent +
                    "group by nfe.n_nf_ent, nfe.data_emissao_nf_ent, nfe.cliente_forn_nf_ent";
                datSel9.SelectCommand = sel9;
                fbConnection1.Open();
                datSel9.Fill(dt9);
                fbConnection1.Close();
                foreach (DataRow dr9 in dt9.Rows)
                {
                    try
                    {
                        valor_troca += Convert.ToDouble(dr9[0].ToString());
                    }
                    catch { }
                }

                //porc troca
               


                FbCommand select = new FbCommand();
                select.CommandText =
                    //"select sum(item.qtde_item), prod.COD_PRODUTO, '', ped.VENDEDOR_PED_VENDA, sum(item.PRECO_TOTAL_ITEM) 
                    "select nf.N_NF, nf.DATA_EMISSAO_NF, nf.CLIENTE_FORN_NF, sum(item.PRECO_TOTAL_ITEM), ped.VENDEDOR_PED_VENDA, " +
                    "sum(item.CUSTO_ITEM), ped.TROCA_PED_VENDA from itens_nota item " +
                    "inner join produtos prod on prod.cod_fornecedor_produto = item.cod_item " +
                    "INNER JOIN nota_fiscal nf ON ITEM.NF_ITEM = NF.N_NF " +
                    "INNER JOIN PEDIDOS_NF ped_nf on nf.n_nf = ped_nf.nf_pedido_nf " +
                    "inner join pedidos_venda ped on ped.cod_ped_venda = ped_nf.n_pedido_nf " +
                     "inner join clientes c on nf.CNPJ_CLIENTE_FORN = c.CNPJ " + 
                    "where " +
                    "nf.STATUS_NFE LIKE ('%Autorizada%') AND " +
                    "nf.data_emissao_nf >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") +
                    "' and nf.data_emissao_nf <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                    _vendedor + _fornecedor + _cliente +
                    //_cfop +
                    " AND (ped.BONIFICACAO_PED_VENDA = '0' or ped.BONIFICACAO_PED_VENDA is null) " +
                    "group by nf.N_NF, nf.DATA_EMISSAO_NF, nf.CLIENTE_FORN_NF, ped.VENDEDOR_PED_VENDA, " +
                    " ped.TROCA_PED_VENDA " +
                    "union " + //PESQUISANDO AS NOTAS DE TROCA INSERIDAS PELA NF ENTRADA
                    "select nfe.n_nf_ent, nfe.data_emissao_nf_ent, nfe.cliente_forn_nf_ent, " +
                    "sum(ent.preco_total_item_ent), 'NF DE TROCA',0, 1 from itens_nota_ent ent inner join " +
                    "nota_fiscal_ent nfe on ent.nf_item_ent = nfe.n_nf_ent " +
                    "inner join produtos prod on prod.COD_BARRAS_PRODUTO = ent.COD_EAN_ITEM_ENT " +
                     "inner join clientes c on nfe.CNPJ_CLIENTE_FORN_ENT = c.CNPJ " +
                "INNER JOIN vendedores_cliente vc on c.COD_CLIENTE = vc.COD_CLIENTE_VC " +
                    "where (ent.cfop_item_ent = '5202' or " +
                    "ent.cfop_item_ent = '6202' or ent.cfop_item_ent = '5411' or ent.cfop_item_ent = '6411') " +
                    "AND nfe.data_emissao_nf_ent >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") + "' " +
                    "and nfe.data_emissao_nf_ent <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                    "and nfe.baixada_nf_ent = 1 " + _cliente_ent + _vendedor_ent + _fornecedor_ent +
                    "group by nfe.n_nf_ent, nfe.data_emissao_nf_ent, nfe.cliente_forn_nf_ent " +
                    "union " +//PESQUISANDO AS NOTAS DE BONIFICAÇÃO
                    "select nf.N_NF, nf.DATA_EMISSAO_NF, nf.CLIENTE_FORN_NF, sum(item.PRECO_TOTAL_ITEM), 'NF DE BONIFICAÇÃO', " +
                    "0, 1 from itens_nota item " +
                    "inner join produtos prod on prod.cod_fornecedor_produto = item.cod_item " +
                    "INNER JOIN nota_fiscal nf ON ITEM.NF_ITEM = NF.N_NF " +
                    "INNER JOIN PEDIDOS_NF ped_nf on nf.n_nf = ped_nf.nf_pedido_nf " +
                    "inner join pedidos_venda ped on ped.cod_ped_venda = ped_nf.n_pedido_nf " +
                     "inner join clientes c on nf.CNPJ_CLIENTE_FORN = c.CNPJ " + 
                    "where " +
                    "nf.STATUS_NFE LIKE ('%Autorizada%') AND " +
                    "nf.data_emissao_nf >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") +
                    "' and nf.data_emissao_nf <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                    _vendedor + _fornecedor + _cliente +
                    //_cfop +
                    " AND ped.BONIFICACAO_PED_VENDA = '1' " +
                    "group by nf.N_NF, nf.DATA_EMISSAO_NF, nf.CLIENTE_FORN_NF";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();


                FbCommand select10 = new FbCommand();
                select10.Connection = fbConnection1;
                fbConnection1.Open();
                select10.CommandText =
                              "select sum(item.PRECO_TOTAL_ITEM) from itens_nota item " +
                    "inner join produtos prod on prod.cod_fornecedor_produto = item.cod_item " +
                    "INNER JOIN nota_fiscal nf ON ITEM.NF_ITEM = NF.N_NF " +
                    "INNER JOIN PEDIDOS_NF ped_nf on nf.n_nf = ped_nf.nf_pedido_nf " +
                    "inner join pedidos_venda ped on ped.cod_ped_venda = ped_nf.n_pedido_nf " +
                    "where " +
                    "nf.STATUS_NFE LIKE ('%Autorizada%') AND " +
                    "nf.data_emissao_nf >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") +
                    "' and nf.data_emissao_nf <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                    _vendedor + _fornecedor + _cliente +
                     " and item.cfop_item like '_910'	";
                //_cfop +
                //" AND ped.TROCA_PED_VENDA = '1' ";

                //"SELECT SUM(VALOR_TOTAL_PROD_ITEM_VENDA) FROM ITENS_PEDIDO_VENDA ipv INNER JOIN " +
                //"PEDIDOS_VENDA pv ON ipv.COD_PEDIDO_ITEM_VENDA = pv.COD_PED_VENDA " +
                //"WHERE 0 = 0 AND TROCA_PED_VENDA = '1' " +
                //        fechados + faturados + data + tipo + cliente + vendedor + cnpj_cliente;
                FbDataAdapter datSelect10 = new FbDataAdapter();
                datSelect10.SelectCommand = select10;
                DataTable dtSelect10 = new DataTable();
                datSelect10.Fill(dtSelect10);
                fbConnection1.Close();
                double valor_boni = 0;
                foreach (DataRow dr10 in dtSelect10.Rows)
                {
                    try
                    {
                        valor_boni += Convert.ToDouble(dr10[0].ToString());
                    }
                    catch { }
                }
                 double porc_troca = ((valor_troca + valor_boni) / valor_total) * 100;
               
                /*FbCommand select = new FbCommand();
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
                */
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

                    double valor_venda = 0, valor_custo = 0, perc_lucro = 0, valor_lucro_liquido = 0, 
                        perc_lucro_bruto = 0, valor_lucro_bruto = 0;

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
                ped.Totais_Lucrativiade.AddTotais_LucrativiadeRow(valor_total, valor_troca, valor_leite, Convert.ToDateTime(dtInicial.Text), Convert.ToDateTime(dtFinal.Text), media, "NF");

                crLucratividade_pedidos novo_ped = new crLucratividade_pedidos();
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

        private void button15_Click(object sender, EventArgs e)
        {

            if (tb_nome_produto.Text != "" || tbFamilia.Text != "")
                MessageBox.Show("Esse relatório não funciona com produto e família");
            else
            {
                //RELATORIO COM PROBLEMA POIS SAI NO VALOR DE VENDA UM SOMATÓRIO QUE INCLUI VENDAS, TROCAS E BONIFICAÇÕES. TERIA QUE MUDAR O CONCEITO DO RELATORIO POR ISSO OCULTEI O BOTÃO
                try
                {
                    string _vendedor = "", _fornecedor = "", _cliente = "", _cliente_ent = "", _vendedor_ent =  "";
                    if (tb_nome_vendedor.Text != "")
                    {
                        _vendedor = " AND ped.VENDEDOR_PED_VENDA = '" + tb_nome_vendedor.Text + "' ";
                        _vendedor_ent = "AND vc.NOME_VENDEDOR_VC = '" + tb_nome_vendedor.Text + "' ";
                    
                    }

                    string _fornecedor_ent =  "";
                    if (tb_nome_fornecedor.Text != "")
                    {
                        _fornecedor = " AND prod.NOME_FORNECEDOR_PRODUTO = '" + tb_nome_fornecedor.Text + "' ";
                        _fornecedor_ent = " AND prod.NOME_FORNECEDOR_PRODUTO = '" + tb_nome_fornecedor.Text + "' ";
                    }

                    if (tb_nome_cliente.Text != "")
                    {
                        _cliente = " AND nf.CNPJ_CLIENTE_FORN = '" + tb_cnpj.Text + "' ";
                        _cliente_ent = " AND nfe.CNPJ_CLIENTE_FORN_ENT = '" + tb_cnpj.Text + "' ";
                    }



                    if (tb_cod_matriz.Text != "")
                    {
                        _cliente = " AND c.COD_MATRIZ_CLIENTE = '" + tb_cod_matriz.Text + "' ";
                        _cliente_ent = " AND c.COD_MATRIZ_CLIENTE = '" + tb_cod_matriz.Text + "' ";
                    }
                    string _cfop = " and (item.cfop_item like '_1__'	" +
                       "	or item.cfop_item like '_4__') ";
                    if (cbCfop.Checked)
                    {
                        _cfop = "  and (item.cfop_item = '" + tb_n_cfop.Text + "'	" +
                        "	or item.cfop_item = '6" + tb_n_cfop.Text.Substring(1, 3) + "' ) ";
                    }
                    dsClientesxproduto cli = new dsClientesxproduto();
                    FbCommand select = new FbCommand();
                    select.CommandText =
                        //"select sum(item.qtde_item), prod.COD_PRODUTO, '', ped.VENDEDOR_PED_VENDA, sum(item.PRECO_TOTAL_ITEM) 
                        "select sum(item.qtde_item), '0', nf.CNPJ_CLIENTE_FORN, '', sum(item.PRECO_TOTAL_ITEM) AS VALOR, sum(item.CUSTO_ITEM) from itens_nota item " +
                        "inner join produtos prod on prod.cod_fornecedor_produto = item.cod_item " +
                        "INNER JOIN nota_fiscal nf ON ITEM.NF_ITEM = NF.N_NF " +
                        "INNER JOIN PEDIDOS_NF ped_nf on nf.n_nf = ped_nf.nf_pedido_nf " +
                        "inner join pedidos_venda ped on ped.cod_ped_venda = ped_nf.n_pedido_nf " +
                         "inner join clientes c on nf.CNPJ_CLIENTE_FORN = c.CNPJ " + 
                        "where " +
                        "nf.STATUS_NFE LIKE ('%Autorizada%') AND " +
                        "nf.data_emissao_nf >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") +
                        "' and nf.data_emissao_nf <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                        _vendedor + _fornecedor + _cliente +
                        _cfop +
                        "group by nf.CNPJ_CLIENTE_FORN order by VALOR DESC";
                    select.Connection = fbConnection1;
                    fbConnection1.Open();
                    FbDataAdapter datSelect = new FbDataAdapter();
                    datSelect.SelectCommand = select;
                    DataTable dtSelect = new DataTable();
                    datSelect.Fill(dtSelect);
                    fbConnection1.Close();


                    //buscando valor_troca
                    FbCommand select_troca = new FbCommand();
                    select_troca.CommandText =
                    "select sum(item.PRECO_TOTAL_ITEM), nf.CNPJ_CLIENTE_FORN as cnpj from itens_nota item " +
                  "inner join produtos prod on prod.cod_fornecedor_produto = item.cod_item " +
                  "INNER JOIN nota_fiscal nf ON ITEM.NF_ITEM = NF.N_NF " +
                  "INNER JOIN PEDIDOS_NF ped_nf on nf.n_nf = ped_nf.nf_pedido_nf " +
                  "inner join pedidos_venda ped on ped.cod_ped_venda = ped_nf.n_pedido_nf " +
                   "inner join clientes c on nf.CNPJ_CLIENTE_FORN = c.CNPJ " + 
                  "where " +
                  "nf.STATUS_NFE LIKE ('%Autorizada%') AND " +
                  "nf.data_emissao_nf >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") +
                  "' and nf.data_emissao_nf <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                  _vendedor + _fornecedor + _cliente +
                  " AND item.cfop_item like '_949' group by nf.CNPJ_CLIENTE_FORN " + // and nf.CNPJ_CLIENTE_FORN = '" + dr[2].ToString() + "'" +
                    "union " + //PESQUISANDO AS NOTAS DE TROCA INSERIDAS PELA NF ENTRADA
                "select sum(ent.preco_total_item_ent), nfe.CNPJ_CLIENTE_FORN_ENT as cnpj from itens_nota_ent ent inner join " +
                "nota_fiscal_ent nfe on ent.nf_item_ent = nfe.n_nf_ent " +
                "inner join produtos prod on prod.COD_BARRAS_PRODUTO = ent.COD_EAN_ITEM_ENT " +
                "inner join clientes c on nfe.CNPJ_CLIENTE_FORN_ENT = c.CNPJ " +
                "INNER JOIN vendedores_cliente vc on c.COD_CLIENTE = vc.COD_CLIENTE_VC " +
                "where (ent.cfop_item_ent = '5202' or " +
                "ent.cfop_item_ent = '6202' or ent.cfop_item_ent = '5411' or ent.cfop_item_ent = '6411') " +
                "AND nfe.data_emissao_nf_ent >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") + "' " +
                "and nfe.data_emissao_nf_ent <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                _cliente_ent + _vendedor_ent + _fornecedor_ent +
                "and nfe.baixada_nf_ent = 1 group by nfe.CNPJ_CLIENTE_FORN_ENT ";
                    // "and nfe.CNPJ_CLIENTE_FORN_ENT = '" + dr[2].ToString() + "'";

                    select_troca.Connection = fbConnection1;
                    fbConnection1.Open();
                    FbDataAdapter datSelect_troca = new FbDataAdapter();
                    datSelect_troca.SelectCommand = select_troca;
                    DataTable dtSelect_troca = new DataTable();
                    datSelect_troca.Fill(dtSelect_troca);
                    fbConnection1.Close();

                    DataTable dtClientes_com_venda_e_troca = new DataTable();
                    DataColumn col1 = new DataColumn();
                    col1.ColumnName = "cnpj";
                    dtClientes_com_venda_e_troca.Columns.Add(col1);
                    //string[] clientes_com_venda_e_troca = new string[10000];
                    //int i = 0;
                    foreach (DataRow dr in dtSelect.Rows)
                    {
                        double valor_trocas = 0;

                        foreach (DataRow dr_troca in dtSelect_troca.Select("cnpj = '" + dr[2].ToString() + "'"))
                        {

                            try
                            {
                                valor_trocas = valor_trocas + Convert.ToDouble(dr_troca[0].ToString());
                                dtClientes_com_venda_e_troca.Rows.Add(dr_troca["cnpj"].ToString());
                            }
                            catch { }
                        }

                        double custo = 0;
                        try
                        {
                            custo = Convert.ToDouble(dr[5].ToString());
                        }
                        catch { }
                        bool incluir = true;
                        if (cbApenas_troca.Checked)
                        {
                            if (valor_trocas == 0)
                                incluir = false;
                        }
                        if (incluir)
                        {
                            try
                            {
                                cli.VendedorxClientesxProdutos.AddVendedorxClientesxProdutosRow(Convert.ToDouble(dr[0].ToString()), Convert.ToInt32(dr[1].ToString()),
                                    dr[2].ToString(), dr[3].ToString(), Convert.ToDouble(dr[4].ToString()), custo, valor_trocas, 0, 0, 0, 0, 0);
                            }
                            catch { }
                        }
                    }
                    foreach (DataRow dr_troca in dtSelect_troca.Rows)
                    {
                        bool ja_entrou = false;
                        foreach (DataRow dr_vendas_e_trocas in dtClientes_com_venda_e_troca.Select("cnpj = '" + dr_troca["cnpj"].ToString() + "'"))
                        {
                            ja_entrou = true;
                        }
                        if (!ja_entrou)
                        {
                            double valor_trocas = 0;
                            try
                            {
                                valor_trocas = valor_trocas + Convert.ToDouble(dr_troca[0].ToString());
                                try
                                {
                                    cli.VendedorxClientesxProdutos.AddVendedorxClientesxProdutosRow(0, 0,
                                        dr_troca["cnpj"].ToString(), "", 0.00001, 0.00001, valor_trocas, 0.00001, 0, 0, 0, 0);
                                }
                                catch { }
                            }
                            catch { }
                        }
                    }




                    FbCommand select_clientes = new FbCommand();
                    select_clientes.CommandText =
                        "SELECT * from clientes";
                    select_clientes.Connection = fbConnection1;
                    fbConnection1.Open();
                    FbDataAdapter datSelect_clientes = new FbDataAdapter();
                    datSelect_clientes.SelectCommand = select_clientes;
                    datSelect_clientes.Fill(cli.CLIENTES);
                    fbConnection1.Close();

                    /*
                    FbCommand select_produtos = new FbCommand();
                    select_produtos.CommandText =
                        "SELECT * from produtos";
                    select_produtos.Connection = fbConnection1;
                    fbConnection1.Open();
                    FbDataAdapter datSelect_produtos = new FbDataAdapter();
                    datSelect_produtos.SelectCommand = select_produtos;
                    datSelect_produtos.Fill(cli.PRODUTOS);
                    fbConnection1.Close();
                    */
                    cli.Dados.AddDadosRow(tb_nome_fornecedor.Text, Convert.ToDateTime(dtInicial.Text), Convert.ToDateTime(dtFinal.Text),
                        tb_nome_vendedor.Text, "", "",0);


                    crClientesxlucratividade cr = new crClientesxlucratividade();
                    cr.SetDataSource(cli);
                    form_imprimir imprime = new form_imprimir(cr);
                    imprime.Show();
                }
                catch (Exception a)
                {
                    fbConnection1.Close();
                    MessageBox.Show(a.ToString());
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {

                dtInicial.Text = "01/01/" + Convert.ToDateTime(dtFinal.Text).Year.ToString();
                string _vendedor = "", _fornecedor = "", _cliente = "", _produto = "", _familia =  "";
                if (tb_nome_vendedor.Text != "")
                    _vendedor = " AND ped.VENDEDOR_PED_VENDA = '" + tb_nome_vendedor.Text + "' ";

                if (tb_nome_fornecedor.Text != "")
                    _fornecedor = " AND prod.NOME_FORNECEDOR_PRODUTO = '" + tb_nome_fornecedor.Text + "' ";

                if (tb_nome_cliente.Text != "")
                    _cliente = " AND nf.CNPJ_CLIENTE_FORN = '" + tb_cnpj.Text + "' ";
                if (tb_cod_matriz.Text != "")
                    _cliente = " AND c.COD_MATRIZ_CLIENTE = '" + tb_cod_matriz.Text + "' ";

                if (tbGrupo.Text != "")
                    _familia = " AND prod.DESCRICAO_GRUPO_PRODUTO = '" + tbGrupo.Text + "' ";
                if (tbdescricaoSubgrupo.Text != "")
                    _familia = " AND prod.DESCRICAO_SUB_GRUPO_PRODUTO = '" + tbdescricaoSubgrupo.Text + "' ";
                if (tb_nome_produto.Text != "")
                    _familia = " AND prod.COD_PRODUTO = '" + tb_cod_produto.Text + "' ";

                if (tbFamilia.Text != "")
                    _familia += " AND prod.NOME_FAMILIA_PRODUTO = '" + tbFamilia.Text + "'";


                string _cfop = " and (item.cfop_item like '_1__'	" +
                   "	or item.cfop_item like '_4__') ";
                if (cbCfop.Checked)
                {
                    _cfop = "  and (item.cfop_item = '" + tb_n_cfop.Text + "'	" +
                    "	or item.cfop_item = '6" + tb_n_cfop.Text.Substring(1, 3) + "' ) ";
                }
                dsClientesxproduto cli = new dsClientesxproduto();
                FbCommand select = new FbCommand();
                //selecionando mes a mes
                select.CommandText =
                    "select  extract(month from nf.data_emissao_nf), nf.cnpj_cliente_forn as CNPJ, sum(item.PRECO_TOTAL_ITEM) from itens_nota item " +
                    "inner join produtos prod on prod.cod_fornecedor_produto = item.cod_item " +
                    "INNER JOIN nota_fiscal nf ON ITEM.NF_ITEM = NF.N_NF " +
                    "INNER JOIN PEDIDOS_NF ped_nf on nf.n_nf = ped_nf.nf_pedido_nf " +
                    "inner join pedidos_venda ped on ped.cod_ped_venda = ped_nf.n_pedido_nf " +
                    "inner join vendedores v on ped.COD_VENDEDOR_PED_VENDA = V.COD_VENDEDOR " +
                    "inner join clientes c on nf.CNPJ_CLIENTE_FORN = c.CNPJ " + 
                    "where " +
                    "nf.STATUS_NFE LIKE ('%Autorizada%') " + _cfop + " AND " +
                    "nf.data_emissao_nf >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") +
                    "' and nf.data_emissao_nf <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                    _vendedor + _fornecedor + _cliente + _produto + supervisor + _familia +
                    "group by 1, nf.cnpj_cliente_forn";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();

                //selecionando cnpjs dos clientes
                FbCommand select_cnpjs = new FbCommand();
                select_cnpjs.CommandText =
                    "select distinct(nf.cnpj_cliente_forn) from itens_nota item " +
                    "inner join produtos prod on prod.cod_fornecedor_produto = item.cod_item " +
                    "INNER JOIN nota_fiscal nf ON ITEM.NF_ITEM = NF.N_NF " +
                    "INNER JOIN PEDIDOS_NF ped_nf on nf.n_nf = ped_nf.nf_pedido_nf " +
                    "inner join pedidos_venda ped on ped.cod_ped_venda = ped_nf.n_pedido_nf " +
                    "inner join vendedores v on ped.COD_VENDEDOR_PED_VENDA = v.COD_VENDEDOR " +
                     "inner join clientes c on nf.CNPJ_CLIENTE_FORN = c.CNPJ " + 
                    "where " +
                    "nf.STATUS_NFE LIKE ('%Autorizada%') " + _cfop + " AND " +
                    "nf.data_emissao_nf >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") +
                    "' and nf.data_emissao_nf <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                    _vendedor + _fornecedor + _cliente + _produto + supervisor;
                //"group by 1, nf.cnpj_cliente_forn";
                select_cnpjs.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect_cnpjs = new FbDataAdapter();
                datSelect_cnpjs.SelectCommand = select_cnpjs;
                DataTable dtSelect_cnpjs = new DataTable();
                datSelect_cnpjs.Fill(dtSelect_cnpjs);
                fbConnection1.Close();

                foreach (DataRow dr_cnpjs in dtSelect_cnpjs.Rows)
                {
                    double _01 = 0, _02 = 0, _03 = 0, _04 = 0, _05 = 0, _06 = 0, _07 = 0, _08 = 0, _09 = 0, _10 = 0, _11 = 0, _12 = 0;
                    double total = 0;
                    foreach (DataRow dr in dtSelect.Select("CNPJ = '" + dr_cnpjs[0].ToString() + "'"))
                    {

                        if (dr[0].ToString() == "1")
                        {
                            try
                            {
                                _01 = Convert.ToDouble(dr[2].ToString());
                            }
                            catch { }
                        }
                        if (dr[0].ToString() == "2")
                        {
                            try
                            {
                                _02 = Convert.ToDouble(dr[2].ToString());
                            }
                            catch { }
                        }
                        if (dr[0].ToString() == "3")
                        {
                            try
                            {
                                _03 = Convert.ToDouble(dr[2].ToString());
                            }
                            catch { }
                        }
                        if (dr[0].ToString() == "4")
                        {
                            try
                            {
                                _04 = Convert.ToDouble(dr[2].ToString());
                            }
                            catch { }
                        }
                        if (dr[0].ToString() == "5")
                        {
                            try
                            {
                                _05 = Convert.ToDouble(dr[2].ToString());
                            }
                            catch { }
                        }
                        if (dr[0].ToString() == "6")
                        {
                            try
                            {
                                _06 = Convert.ToDouble(dr[2].ToString());
                            }
                            catch { }
                        }
                        if (dr[0].ToString() == "7")
                        {
                            try
                            {
                                _07 = Convert.ToDouble(dr[2].ToString());
                            }
                            catch { }
                        }
                        if (dr[0].ToString() == "8")
                        {
                            try
                            {
                                _08 = Convert.ToDouble(dr[2].ToString());
                            }
                            catch { }
                        }
                        if (dr[0].ToString() == "9")
                        {
                            try
                            {
                                _09 = Convert.ToDouble(dr[2].ToString());
                            }
                            catch { }
                        }
                        if (dr[0].ToString() == "10")
                        {
                            try
                            {
                                _10 = Convert.ToDouble(dr[2].ToString());
                            }
                            catch { }
                        }
                        if (dr[0].ToString() == "11")
                        {
                            try
                            {
                                _11 = Convert.ToDouble(dr[2].ToString());
                            }
                            catch { }
                        }
                        if (dr[0].ToString() == "12")
                        {
                            try
                            {
                                _12 = Convert.ToDouble(dr[2].ToString());
                            }
                            catch { }
                        }
                        try
                        {
                            total = total + Convert.ToDouble(dr[2].ToString());
                        }
                        catch { }

                    }
                    try
                    {
                        cli.ABC.AddABCRow(dr_cnpjs[0].ToString(), _01, _02, _03, _04, _05, _06, _07, _08, _09, _10, _11, _12, total);
                    }
                    catch { }
                }

                FbCommand select_clientes = new FbCommand();
                select_clientes.CommandText =
                    "SELECT * from clientes";
                select_clientes.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect_clientes = new FbDataAdapter();
                datSelect_clientes.SelectCommand = select_clientes;
                datSelect_clientes.Fill(cli.CLIENTES);
                fbConnection1.Close();

                cli.Dados.AddDadosRow(tb_nome_fornecedor.Text, Convert.ToDateTime(dtInicial.Text), Convert.ToDateTime(dtFinal.Text),
                    tb_nome_vendedor.Text, "", tb_nome_produto.Text,0);


                crABC cr = new crABC();
                cr.SetDataSource(cli);
                form_imprimir imprime = new form_imprimir(cr);
                imprime.Show();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                dsClientesxproduto cli = new dsClientesxproduto();
                FbCommand select = new FbCommand();
                select.CommandText =
                    //"select sum(item.qtde_item), prod.COD_PRODUTO, '', ped.VENDEDOR_PED_VENDA, sum(item.PRECO_TOTAL_ITEM) 
                    "select sum(item.qtde_infce), prod.COD_PRODUTO, '', '', sum(item.VALOR_TOTAL_INFCE), sum(item.CUSTO_INFCE) from itens_NFCE item " +
                    "inner join produtos prod on prod.cod_produto = item.COD_ESTOQUE_INFCE " +
                    "INNER JOIN NFCE nf ON item.COD_PEDIDO_INFCE = nf.PEDIDO_NFCE " +
                    "where " +
                    "nf.PEDIDO_FECHADO_NFCE = 1 AND " +
                    "nf.data_emissao_nfce >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") +
                    "' and nf.data_emissao_nfce <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                    "group by prod.COD_PRODUTO " +
                    "ORDER BY 5 DESC";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    double custo = 0;
                    try
                    {
                        custo = Convert.ToDouble(dr[5].ToString());
                    }
                    catch { }
                    try
                    {
                        cli.VendedorxClientesxProdutos.AddVendedorxClientesxProdutosRow(Convert.ToDouble(dr[0].ToString()), Convert.ToInt32(dr[1].ToString()),
                            dr[2].ToString(), dr[3].ToString(), Convert.ToDouble(dr[4].ToString()), custo, 0, 0, 0, 0, 0, 0);
                    }
                    catch { }
                }

                FbCommand select_produtos = new FbCommand();
                select_produtos.CommandText =
                    "SELECT * from produtos";
                select_produtos.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect_produtos = new FbDataAdapter();
                datSelect_produtos.SelectCommand = select_produtos;
                datSelect_produtos.Fill(cli.PRODUTOS);
                fbConnection1.Close();

                cli.Dados.AddDadosRow(tb_nome_fornecedor.Text, Convert.ToDateTime(dtInicial.Text), Convert.ToDateTime(dtFinal.Text),
                    tb_nome_vendedor.Text, "PDV", "",0);


                crProdutosxlucratividade_familia cr = new crProdutosxlucratividade_familia();
                cr.SetDataSource(cli);
                form_imprimir imprime = new form_imprimir(cr);
                imprime.Show();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                string _vendedor =  "";
                string _dataInicial = dtInicial.Text.Replace("/", ".");
                string _dataFinal = dtFinal.Text.Replace("/", ".");
                if (tb_nome_vendedor.Text != "")
                    _vendedor = " AND pv.cod_vendedor_ped_venda = '" + tb_cod_vendedor.Text + "' ";

                if (_vendedor == "")
                {
                    MessageBox.Show("Selecione o Vendedor");
                }
                else
                {
                    dsVendedorxNFe cli = new dsVendedorxNFe();
                    FbCommand select = new FbCommand();
                    select.CommandText =
                        "select distinct fnf.*, pv.cod_vendedor_ped_venda, pv.vendedor_ped_venda, nf.data_emissao_nf from fatura_nf fnf "
                        + "inner join nota_fiscal nf on  fnf.nf_fatura = nf.n_nf "
                        + "inner join pedidos_nf pnf on pnf.nf_pedido_nf = fnf.nf_fatura "
                        + "inner join pedidos_venda pv on pv.cod_ped_venda = pnf.n_pedido_nf "
                        + "inner join vendedores v on pv.COD_VENDEDOR_PED_VENDA = v.COD_VENDEDOR " 
                        + "where nf.data_emissao_nf >= '" + _dataInicial +
                        "' and nf.data_emissao_nf <= '" + dtFinal.Text.Replace("/", ".") + "' AND nf.STATUS_NFE like 'NFe Autorizada.'" + _vendedor + supervisor 
                        + "order by nf.data_emissao_nf";
                    select.Connection = fbConnection1;
                    fbConnection1.Open();
                    FbDataAdapter datSelect = new FbDataAdapter();
                    datSelect.SelectCommand = select;
                    DataTable dtSelect = new DataTable();
                    datSelect.Fill(dtSelect);
                    fbConnection1.Close();
                    foreach (DataRow dr in dtSelect.Rows)
                    {
                        try
                        {
                            cli.VendedorxNFe.AddVendedorxNFeRow(dr[7].ToString(), Convert.ToInt32(dr[4].ToString()),
                            Convert.ToDouble(dr[3].ToString()), Convert.ToDateTime(dr[2].ToString()).ToShortDateString().Replace(".", "/"),
                            Convert.ToDateTime(dr[8].ToString()).ToShortDateString().Replace(".", "/"));
                        }
                        catch { }
                    }
                    cli.Dados.AddDadosRow(_dataInicial.Replace(".", "/"), _dataFinal.Replace(".", "/"));
                    crVendedorxNfe cr = new crVendedorxNfe();
                    cr.SetDataSource(cli);
                    form_imprimir imprime = new form_imprimir(cr);
                    imprime.Show();
                }

            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private DataSet consutarVPC()
        {
            dsVendedorXProdutoXCliente dt = new dsVendedorXProdutoXCliente();
            string produto =  "";

            if (cbProduto.Checked)
            {
                produto = "and prod.cod_produto = @PROD ";
            }
            try
            {
                FbCommand sel = new FbCommand();
                FbDataAdapter da = new FbDataAdapter();
                sel.CommandText =
                    "select prod.cod_fornecedor_produto as \"Cod\", " +
                "prod.descricao_produto as \"Produto\", " +
                "SUM(inf.qtde_item) AS \"Quantidade vendida\", " +
                "count(distinct(nf.cnpj_cliente_forn)) as \"Quantidade de clientes\",v.nome_vendedor as \"Vendedor\" " +
                @"from itens_nota inf
            inner join produtos prod on prod.cod_fornecedor_produto = inf.cod_item
            inner join nota_fiscal nf on inf.nf_item = nf.n_nf
            inner join pedidos_nf pnf on pnf.nf_pedido_nf = nf.n_nf
            inner join pedidos_venda pv on pnf.n_pedido_nf = pv.cod_ped_venda
            inner join vendedores v on pv.cod_vendedor_ped_venda = v.cod_vendedor
            where nf.data_emissao_nf >= @DAT_I AND nf.data_emissao_nf <= @DAT_F
            and v.nome_vendedor like @VEND " + produto + supervisor +
            "and nf.STATUS_NFE LIKE ('%Autorizada%') " +
            "and (inf.cfop_item = '5102' or inf .cfop_item = '5405') " +
            "group by v.nome_vendedor,pv.VENDEDOR_PED_VENDA,prod.descricao_produto, prod.cod_fornecedor_produto " +
            "order by \"Quantidade de clientes\" DESC";
                sel.Connection = fbConnection1;
                sel.Parameters.AddWithValue("@DAT_I", Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", "."));
                sel.Parameters.AddWithValue("@DAT_F", Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", "."));
                sel.Parameters.AddWithValue("@VEND", "%" + tb_nome_vendedor.Text + "%");
                if (cbProduto.Checked)
                {
                    sel.Parameters.AddWithValue("@PROD", tb_cod_produto.Text);
                }
                da.SelectCommand = sel;
                fbConnection1.Open();
                da.Fill(dt.Consulta);
                fbConnection1.Close();

                dt.INFORMACOES.AddINFORMACOESRow(Convert.ToDateTime(dtInicial.Text), Convert.ToDateTime(dtFinal.Text));
                return dt;
            }
            catch
            {
                return dt;
            }
        }
        private void btnVPC_Click(object sender, EventArgs e)
        {
            //Passar a consuta para uma impressão
            dgvPedidos.DataSource = consutarVPC().Tables[0];
            crVendedorXProdutoXCliente cr = new crVendedorXProdutoXCliente();
            cr.SetDataSource(consutarVPC());
            form_imprimir imp = new form_imprimir(cr);
            imp.ShowDialog();
        }

        private void button19_Click(object sender, EventArgs e)
        {

            if (tb_nome_produto.Text != "" || tbFamilia.Text != "")
                MessageBox.Show("Esse relatório não funciona com produto e família");
            else
            {
                try
                {
                    string _vendedor = "", _fornecedor = "", _cliente = "", _cliente_ent = "", _vendedor_ent = "";
                    if (tb_nome_vendedor.Text != "")
                    {
                        _vendedor = " AND ped.VENDEDOR_PED_VENDA = '" + tb_nome_vendedor.Text + "' ";
                        _vendedor_ent = "AND vc.NOME_VENDEDOR_VC = '" + tb_nome_vendedor.Text + "' ";
                    }

                    string _fornecedor_ent = "";
                    if (tb_nome_fornecedor.Text != "")
                    {
                        _fornecedor = " AND prod.NOME_FORNECEDOR_PRODUTO = '" + tb_nome_fornecedor.Text + "' ";
                        _fornecedor_ent = " AND prod.NOME_FORNECEDOR_PRODUTO = '" + tb_nome_fornecedor.Text + "' ";
                    }

                    if (tb_nome_cliente.Text != "")
                    {
                        _cliente = " AND nf.CNPJ_CLIENTE_FORN = '" + tb_cnpj.Text + "' ";
                        _cliente_ent = " AND nfe.CNPJ_CLIENTE_FORN_ENT = '" + tb_cnpj.Text + "' ";
                    }
                    if (tb_cod_matriz.Text != "")
                    {
                        _cliente = " AND c.COD_MATRIZ_CLIENTE = '" + tb_cod_matriz.Text + "' ";
                        _cliente_ent = " AND c.COD_MATRIZ_CLIENTE = '" + tb_cod_matriz.Text + "' ";
                    }


                    string _cfop = " and (item.cfop_item like '_1__'	" +
                       "	or item.cfop_item like '_4__') ";
                    if (cbCfop.Checked)
                    {
                        _cfop = "  and (item.cfop_item = '" + tb_n_cfop.Text + "'	" +
                        "	or item.cfop_item = '6" + tb_n_cfop.Text.Substring(1, 3) + "' ) ";
                    }
                    dsClientesxproduto cli = new dsClientesxproduto();

                    //buscar outras cfops diferentes de vendas
                    FbCommand select1 = new FbCommand();
                    select1.CommandText =
                        //"select sum(item.qtde_item), prod.COD_PRODUTO, '', ped.VENDEDOR_PED_VENDA, sum(item.PRECO_TOTAL_ITEM) 
                        "select nf.CNPJ_CLIENTE_FORN as cnpj, item.PRECO_TOTAL_ITEM AS VALOR,  nf.n_nf as nf, item.COD_EAN_ITEM as ean  from itens_nota item " +
                        "inner join produtos prod on prod.cod_fornecedor_produto = item.cod_item " +
                        "INNER JOIN nota_fiscal nf ON ITEM.NF_ITEM = NF.N_NF " +
                          "INNER JOIN PEDIDOS_NF ped_nf on nf.n_nf = ped_nf.nf_pedido_nf " +
                             "inner join pedidos_venda ped on ped.cod_ped_venda = ped_nf.n_pedido_nf " +
                             "inner join vendedores v on ped.COD_VENDEDOR_PED_VENDA = V.COD_VENDEDOR " +
                              "inner join clientes c on nf.CNPJ_CLIENTE_FORN = c.CNPJ " + 
                        "where " +
                        "nf.STATUS_NFE LIKE ('%Autorizada%') AND " +
                        "nf.data_emissao_nf >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") +
                        "' and nf.data_emissao_nf <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                        _vendedor + _fornecedor + _cliente + supervisor +
                        //_cfop +
                        //" AND item.cfop_item <> '5102'	" +
                        // "	AND item.cfop_item <> '5405' " +
                        " and (item.cfop_item like '_949' or item.cfop_item like '_910') " +
                        //"group by nf.CNPJ_CLIENTE_FORN " +
                         "union " + //PESQUISANDO AS NOTAS DE TROCA INSERIDAS PELA NF ENTRADA
                        //"select nfe.CNPJ_CLIENTE_FORN_ENT as cnpj, sum(ent.preco_total_item_ent) as VALOR from itens_nota_ent ent inner join " +
                        "select distinct(nfe.CNPJ_CLIENTE_FORN_ENT) as cnpj, ent.preco_total_item_ent as VALOR, nfe.n_nf_ent as nf, ent.cod_ean_item_ent as ean  from itens_nota_ent ent inner join " +
                        "nota_fiscal_ent nfe on ent.nf_item_ent = nfe.n_nf_ent " +
                         "left join produtos prod on prod.COD_BARRAS_PRODUTO = ent.COD_EAN_ITEM_ENT " +
                        "inner join clientes c on nfe.CNPJ_CLIENTE_FORN_ENT = c.CNPJ " +
                "INNER JOIN vendedores_cliente vc on c.COD_CLIENTE = vc.COD_CLIENTE_VC " +
                 "inner join vendedores v on vc.COD_VENDEDOR_VC = v.COD_VENDEDOR " +
                        "where (ent.cfop_item_ent = '5202' or " +
                        "ent.cfop_item_ent = '6202' or ent.cfop_item_ent = '5411' or ent.cfop_item_ent = '6411') " +
                        "AND nfe.data_emissao_nf_ent >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") + "' " +
                        "and nfe.data_emissao_nf_ent <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                        _cliente_ent + _vendedor_ent + _fornecedor_ent + supervisor +
                        "and nfe.baixada_nf_ent = 1 ";//group by nfe.CNPJ_CLIENTE_FORN_ENT";
                    select1.Connection = fbConnection1;
                    fbConnection1.Open();
                    FbDataAdapter datSelect1 = new FbDataAdapter();
                    datSelect1.SelectCommand = select1;
                    DataTable dtSelect1 = new DataTable();
                    datSelect1.Fill(dtSelect1);
                    fbConnection1.Close();

                    FbCommand select = new FbCommand();
                    select.CommandText =
                        //"select sum(item.qtde_item), prod.COD_PRODUTO, '', ped.VENDEDOR_PED_VENDA, sum(item.PRECO_TOTAL_ITEM) 
                        "select sum(item.qtde_item), '0', nf.CNPJ_CLIENTE_FORN, '', sum(item.PRECO_TOTAL_ITEM) AS VALOR, sum(item.CUSTO_ITEM) from itens_nota item " +
                        "inner join produtos prod on prod.cod_fornecedor_produto = item.cod_item " +
                        "INNER JOIN nota_fiscal nf ON ITEM.NF_ITEM = NF.N_NF " +
                        "INNER JOIN PEDIDOS_NF ped_nf on nf.n_nf = ped_nf.nf_pedido_nf " +
                        "inner join pedidos_venda ped on ped.cod_ped_venda = ped_nf.n_pedido_nf " +
                         "inner join vendedores v on ped.COD_VENDEDOR_PED_VENDA = V.COD_VENDEDOR " +
                        "where " +
                        "nf.STATUS_NFE LIKE ('%Autorizada%') AND " +
                        "nf.data_emissao_nf >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") +
                        "' and nf.data_emissao_nf <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                        _vendedor + _fornecedor + _cliente + supervisor +
                        _cfop +
                        "group by nf.CNPJ_CLIENTE_FORN order by VALOR DESC";
                    select.Connection = fbConnection1;
                    fbConnection1.Open();
                    FbDataAdapter datSelect = new FbDataAdapter();
                    datSelect.SelectCommand = select;
                    DataTable dtSelect = new DataTable();
                    datSelect.Fill(dtSelect);
                    fbConnection1.Close();

                    DataTable dtClientes_com_venda_e_troca = new DataTable();
                    DataColumn col1 = new DataColumn();
                    col1.ColumnName = "cnpj";
                    dtClientes_com_venda_e_troca.Columns.Add(col1);
                    foreach (DataRow dr in dtSelect.Rows)
                    {
                        double valor_trocas = 0;
                        // try
                        //{
                        bool cliente_adicionado = false;
                        foreach (DataRow dr_troca in dtSelect1.Select("cnpj = '" + dr[2].ToString() + "'"))
                        {
                            try
                            {
                                valor_trocas = valor_trocas + Convert.ToDouble(dr_troca[1].ToString());
                                if (!cliente_adicionado)
                                {
                                    dtClientes_com_venda_e_troca.Rows.Add(dr_troca["cnpj"].ToString());
                                    cliente_adicionado = true;
                                }

                            }
                            catch { }
                        }

                        double custo = 0;
                        try
                        {
                            custo = Convert.ToDouble(dr[5].ToString());
                        }
                        catch { }
                        bool incluir = true;
                        if (cbApenas_troca.Checked)
                        {
                            if (valor_trocas == 0)
                                incluir = false;
                        }
                        if (incluir)
                        {
                            try
                            {
                                cli.VendedorxClientesxProdutos.AddVendedorxClientesxProdutosRow(Convert.ToDouble(dr[0].ToString()), Convert.ToInt32(dr[1].ToString()),
                                    dr[2].ToString(), dr[3].ToString(), Convert.ToDouble(dr[4].ToString()), custo, valor_trocas, 0, 0, 0, 0, 0);
                            }
                            catch { }
                        }
                    }
                    DataTable dtClientes_troca = new DataTable();
                    DataColumn col2 = new DataColumn();
                    col2.ColumnName = "cnpj";
                    dtClientes_troca.Columns.Add(col2);
                    foreach (DataRow dr_troca in dtSelect1.Rows)
                    {
                        bool ja_entrou = false;

                        foreach (DataRow dr_vendas_e_trocas in dtClientes_com_venda_e_troca.Select("cnpj = '" + dr_troca["cnpj"].ToString() + "'"))
                        {
                            ja_entrou = true;
                        }
                        foreach (DataRow dr_vendas_e_trocas in dtClientes_troca.Select("cnpj = '" + dr_troca["cnpj"].ToString() + "'"))
                        {
                            ja_entrou = true;
                        }
                        if (!ja_entrou)
                        {

                            double valor_trocas = 0;
                            foreach (DataRow dr in dtSelect1.Select("cnpj = '" + dr_troca["cnpj"].ToString() + "'"))
                            {
                                try
                                {
                                    valor_trocas = valor_trocas + Convert.ToDouble(dr["VALOR"].ToString());

                                }
                                catch { }
                            }
                            try
                            {
                                cli.VendedorxClientesxProdutos.AddVendedorxClientesxProdutosRow(0, 0,
                                    dr_troca["cnpj"].ToString(), "", 0.00001, 0.00001, valor_trocas, 0.00001, 0, 0, 0, 0);
                                dtClientes_troca.Rows.Add(dr_troca["cnpj"].ToString());
                            }
                            catch { }
                        }
                    }



                    FbCommand select_clientes = new FbCommand();
                    select_clientes.CommandText =
                        "SELECT * from clientes";
                    select_clientes.Connection = fbConnection1;
                    fbConnection1.Open();
                    FbDataAdapter datSelect_clientes = new FbDataAdapter();
                    datSelect_clientes.SelectCommand = select_clientes;
                    datSelect_clientes.Fill(cli.CLIENTES);
                    fbConnection1.Close();

                    cli.Dados.AddDadosRow(tb_nome_fornecedor.Text, Convert.ToDateTime(dtInicial.Text), Convert.ToDateTime(dtFinal.Text),
                        tb_nome_vendedor.Text, "", "", 0);


                    crClientesxtroca cr = new crClientesxtroca();
                    cr.SetDataSource(cli);
                    form_imprimir imprime = new form_imprimir(cr);
                    imprime.Show();
                }
                catch (Exception a)
                {
                    fbConnection1.Close();
                    MessageBox.Show(a.ToString());
                }
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    string _vendedor = "", _fornecedor = "", _cliente =  "";
                    if (tb_nome_vendedor.Text != "")
                        _vendedor = " AND ped.VENDEDOR_PED_VENDA = '" + tb_nome_vendedor.Text + "' ";

                    if (tb_nome_fornecedor.Text != "")
                        _fornecedor = " AND prod.NOME_FORNECEDOR_PRODUTO = '" + tb_nome_fornecedor.Text + "' ";

                    if (tb_nome_cliente.Text != "")
                        _cliente = " AND nf.CNPJ_CLIENTE_FORN = '" + tb_cnpj.Text + "' ";


                    string _cfop = " and (item.cfop_item like '_1__'	" +
                       "	or item.cfop_item like '_4__') ";
                    if (cbCfop.Checked)
                    {
                        _cfop = "  and (item.cfop_item = '" + tb_n_cfop.Text + "'	" +
                        "	or item.cfop_item = '6" + tb_n_cfop.Text.Substring(1, 3) + "' ) ";
                    }
                    dsClientesxproduto cli = new dsClientesxproduto();
                    FbCommand select = new FbCommand();
                    select.CommandText =
                        //"select sum(item.qtde_item), prod.COD_PRODUTO, '', ped.VENDEDOR_PED_VENDA, sum(item.PRECO_TOTAL_ITEM) 
                        "select sum(item.qtde_item), prod.COD_PRODUTO, '', '', sum(item.PRECO_TOTAL_ITEM), sum(item.CUSTO_ITEM) from itens_nota item " +
                        "inner join produtos prod on prod.cod_fornecedor_produto = item.cod_item " +
                        "INNER JOIN nota_fiscal nf ON ITEM.NF_ITEM = NF.N_NF " +
                        "INNER JOIN PEDIDOS_NF ped_nf on nf.n_nf = ped_nf.nf_pedido_nf " +
                        "inner join pedidos_venda ped on ped.cod_ped_venda = ped_nf.n_pedido_nf " +
                        "where " +
                        "nf.STATUS_NFE LIKE ('%Autorizada%') AND " +
                        "nf.data_emissao_nf >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") +
                        "' and nf.data_emissao_nf <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                        _vendedor + _fornecedor + _cliente +
                        _cfop +
                          "group by prod.COD_PRODUTO " +
                        "ORDER BY 5 DESC";
                    select.Connection = fbConnection1;
                    fbConnection1.Open();
                    FbDataAdapter datSelect = new FbDataAdapter();
                    datSelect.SelectCommand = select;
                    DataTable dtSelect = new DataTable();
                    datSelect.Fill(dtSelect);
                    fbConnection1.Close();
                    foreach (DataRow dr in dtSelect.Rows)
                    {
                        double custo = 0;
                        try
                        {
                            custo = Convert.ToDouble(dr[5].ToString());
                        }
                        catch { }
                        try
                        {
                            cli.VendedorxClientesxProdutos.AddVendedorxClientesxProdutosRow(Convert.ToDouble(dr[0].ToString()), Convert.ToInt32(dr[1].ToString()),
                                dr[2].ToString(), dr[3].ToString(), Convert.ToDouble(dr[4].ToString()), custo, 0, 0, 0, 0, 0, 0);
                        }
                        catch { }
                    }

                    FbCommand select_clientes = new FbCommand();
                    select_clientes.CommandText =
                        "SELECT * from clientes";
                    select_clientes.Connection = fbConnection1;
                    fbConnection1.Open();
                    FbDataAdapter datSelect_clientes = new FbDataAdapter();
                    datSelect_clientes.SelectCommand = select_clientes;
                    datSelect_clientes.Fill(cli.CLIENTES);
                    fbConnection1.Close();

                    FbCommand select_produtos = new FbCommand();
                    select_produtos.CommandText =
                        "SELECT * from produtos";
                    select_produtos.Connection = fbConnection1;
                    fbConnection1.Open();
                    FbDataAdapter datSelect_produtos = new FbDataAdapter();
                    datSelect_produtos.SelectCommand = select_produtos;
                    datSelect_produtos.Fill(cli.PRODUTOS);
                    fbConnection1.Close();

                    cli.Dados.AddDadosRow(tb_nome_fornecedor.Text, Convert.ToDateTime(dtInicial.Text), Convert.ToDateTime(dtFinal.Text),
                        tb_nome_vendedor.Text, "", "",0);


                    crProdutosxlucratividadeSemCusto cr = new crProdutosxlucratividadeSemCusto();
                    cr.SetDataSource(cli);
                    form_imprimir imprime = new form_imprimir(cr);
                    imprime.Show();
                }
                catch (Exception a)
                {
                    fbConnection1.Close();
                    MessageBox.Show(a.ToString());
                }
            }

        }

        private void dgvPedidos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {


        }

        private void button21_Click(object sender, EventArgs e)
        {
            try
            {

                dtInicial.Text = "01/01/" + Convert.ToDateTime(dtFinal.Text).Year.ToString();
                string _vendedor = "", _fornecedor = "", _cliente = "", _produto =  "";
                if (tb_nome_vendedor.Text != "")
                    _vendedor = " AND vc.NOME_VENDEDOR_VC = '" + tb_nome_vendedor.Text + "' ";

                if (tb_nome_fornecedor.Text != "")
                    _fornecedor = " AND prod.NOME_FORNECEDOR_PRODUTO = '" + tb_nome_fornecedor.Text + "' ";

                if (tb_nome_cliente.Text != "")
                    _cliente = " AND nf.CNPJ_CLIENTE_FORN = '" + tb_cnpj.Text + "' ";

                if (tb_nome_produto.Text != "")
                    _produto = " AND prod.COD_PRODUTO = '" + tb_cod_produto.Text + "'";


                string _cfop = " and (item.cfop_item like '_1__'	" +
                   "	or item.cfop_item like '_4__') ";
                if (cbCfop.Checked)
                {
                    _cfop = "  and (item.cfop_item = '" + tb_n_cfop.Text + "'	" +
                    "	or item.cfop_item = '6" + tb_n_cfop.Text.Substring(1, 3) + "' ) ";
                }
                dsClientesxproduto cli = new dsClientesxproduto();
                FbCommand select = new FbCommand();
                //selecionando mes a mes
                select.CommandText =
                    "select  extract(month from nf.data_emissao_nf), nf.cnpj_cliente_forn as CNPJ, sum(item.PRECO_TOTAL_ITEM) from itens_nota item " +
                    "inner join produtos prod on prod.cod_fornecedor_produto = item.cod_item " +
                    "INNER JOIN nota_fiscal nf ON ITEM.NF_ITEM = NF.N_NF " +
                    "INNER JOIN CLIENTES cl on nf.CNPJ_CLIENTE_FORN = cl.CNPJ " +
                    //  "INNER JOIN vendedores_cliente vc ON cl.cod_cliente = vc.COD_CLIENTE_VC " + 
                    "INNER JOIN PEDIDOS_NF ped_nf on nf.n_nf = ped_nf.nf_pedido_nf " +
                    "inner join pedidos_venda ped on ped.cod_ped_venda = ped_nf.n_pedido_nf " +

                    "where " +
                    "nf.STATUS_NFE LIKE ('%Autorizada%') " + _cfop + " AND " +
                    "nf.data_emissao_nf >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") +
                    "' and nf.data_emissao_nf <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                    _vendedor + _fornecedor + _cliente + _produto +
                    "group by 1, nf.cnpj_cliente_forn";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();

                //selecionando cnpjs dos clientes
                FbCommand select_cnpjs = new FbCommand();
                select_cnpjs.CommandText =
                    "select distinct(nf.cnpj_cliente_forn) from itens_nota item " +
                    "inner join produtos prod on prod.cod_fornecedor_produto = item.cod_item " +
                    "INNER JOIN nota_fiscal nf ON ITEM.NF_ITEM = NF.N_NF " +
                    "INNER JOIN PEDIDOS_NF ped_nf on nf.n_nf = ped_nf.nf_pedido_nf " +
                    "inner join pedidos_venda ped on ped.cod_ped_venda = ped_nf.n_pedido_nf " +
                    "INNER JOIN CLIENTES cl on nf.CNPJ_CLIENTE_FORN = cl.CNPJ " +
                    //      "INNER JOIN vendedores_cliente vc ON cl.cod_cliente = vc.COD_CLIENTE_VC " + 
                    "where " +
                    "nf.STATUS_NFE LIKE ('%Autorizada%') " + _cfop + " AND " +
                    "nf.data_emissao_nf >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") +
                    "' and nf.data_emissao_nf <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                    _vendedor + _fornecedor + _cliente + _produto;
                //"group by 1, nf.cnpj_cliente_forn";
                select_cnpjs.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect_cnpjs = new FbDataAdapter();
                datSelect_cnpjs.SelectCommand = select_cnpjs;
                DataTable dtSelect_cnpjs = new DataTable();
                datSelect_cnpjs.Fill(dtSelect_cnpjs);
                fbConnection1.Close();

                foreach (DataRow dr_cnpjs in dtSelect_cnpjs.Rows)
                {
                    double _01 = 0, _02 = 0, _03 = 0, _04 = 0, _05 = 0, _06 = 0, _07 = 0, _08 = 0, _09 = 0, _10 = 0, _11 = 0, _12 = 0;
                    double total = 0;
                    foreach (DataRow dr in dtSelect.Select("CNPJ = '" + dr_cnpjs[0].ToString() + "'"))
                    {

                        if (dr[0].ToString() == "1")
                        {
                            try
                            {
                                _01 = Convert.ToDouble(dr[2].ToString());
                            }
                            catch { }
                        }
                        if (dr[0].ToString() == "2")
                        {
                            try
                            {
                                _02 = Convert.ToDouble(dr[2].ToString());
                            }
                            catch { }
                        }
                        if (dr[0].ToString() == "3")
                        {
                            try
                            {
                                _03 = Convert.ToDouble(dr[2].ToString());
                            }
                            catch { }
                        }
                        if (dr[0].ToString() == "4")
                        {
                            try
                            {
                                _04 = Convert.ToDouble(dr[2].ToString());
                            }
                            catch { }
                        }
                        if (dr[0].ToString() == "5")
                        {
                            try
                            {
                                _05 = Convert.ToDouble(dr[2].ToString());
                            }
                            catch { }
                        }
                        if (dr[0].ToString() == "6")
                        {
                            try
                            {
                                _06 = Convert.ToDouble(dr[2].ToString());
                            }
                            catch { }
                        }
                        if (dr[0].ToString() == "7")
                        {
                            try
                            {
                                _07 = Convert.ToDouble(dr[2].ToString());
                            }
                            catch { }
                        }
                        if (dr[0].ToString() == "8")
                        {
                            try
                            {
                                _08 = Convert.ToDouble(dr[2].ToString());
                            }
                            catch { }
                        }
                        if (dr[0].ToString() == "9")
                        {
                            try
                            {
                                _09 = Convert.ToDouble(dr[2].ToString());
                            }
                            catch { }
                        }
                        if (dr[0].ToString() == "10")
                        {
                            try
                            {
                                _10 = Convert.ToDouble(dr[2].ToString());
                            }
                            catch { }
                        }
                        if (dr[0].ToString() == "11")
                        {
                            try
                            {
                                _11 = Convert.ToDouble(dr[2].ToString());
                            }
                            catch { }
                        }
                        if (dr[0].ToString() == "12")
                        {
                            try
                            {
                                _12 = Convert.ToDouble(dr[2].ToString());
                            }
                            catch { }
                        }
                        try
                        {
                            total = total + Convert.ToDouble(dr[2].ToString());
                        }
                        catch { }

                    }
                    try
                    {
                        cli.ABC.AddABCRow(dr_cnpjs[0].ToString(), _01, _02, _03, _04, _05, _06, _07, _08, _09, _10, _11, _12, total);
                    }
                    catch { }
                }

                FbCommand select_clientes = new FbCommand();
                select_clientes.CommandText =
                    "SELECT * from clientes";
                select_clientes.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect_clientes = new FbDataAdapter();
                datSelect_clientes.SelectCommand = select_clientes;
                datSelect_clientes.Fill(cli.CLIENTES);
                fbConnection1.Close();

                cli.Dados.AddDadosRow(tb_nome_fornecedor.Text, Convert.ToDateTime(dtInicial.Text), Convert.ToDateTime(dtFinal.Text),
                    tb_nome_vendedor.Text, "", "",0);


                crABC cr = new crABC();
                cr.SetDataSource(cli);
                form_imprimir imprime = new form_imprimir(cr);
                imprime.Show();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            form_familias_produto fam = new form_familias_produto();
            try
            {
                fam.busca = true;
                fam.ShowDialog();
            }
            finally
            {
                tbCodFamilia.Text = fam.cod;
                tbFamilia.Text = fam.descricao;
            }
        }

        private void button45_Click(object sender, EventArgs e)
        {
            try
            {
                string _vendedor = "", _fornecedor = "", _cliente = "", _familia = "";
                //DESCRICAO_GRUPO_PRODUTO
                if (tbGrupo.Text != "")
                    _familia = " AND prod.DESCRICAO_GRUPO_PRODUTO = '" + tbGrupo.Text + "' ";
                if (tbdescricaoSubgrupo.Text != "")
                    _familia = " AND prod.DESCRICAO_SUB_GRUPO_PRODUTO = '" + tbdescricaoSubgrupo.Text + "' ";
                if (tb_nome_produto.Text != "")
                    _familia = " AND prod.COD_PRODUTO = '" + tb_cod_produto.Text + "' ";

                if (tbFamilia.Text != "")
                    _familia += " AND prod.NOME_FAMILIA_PRODUTO = '" + tbFamilia.Text + "' ";

                if (tb_nome_vendedor.Text != "")
                    _vendedor = " AND ped.VENDEDOR_PED_VENDA = '" + tb_nome_vendedor.Text + "' ";

                if (tb_nome_fornecedor.Text != "")
                    _fornecedor = " AND prod.NOME_FORNECEDOR_PRODUTO = '" + tb_nome_fornecedor.Text + "' ";

                if (tb_nome_cliente.Text != "")
                    _cliente = " AND nf.CNPJ_CLIENTE_FORN = '" + tb_cnpj.Text + "' ";
                if (tb_cod_matriz.Text != "")
                    _cliente = " AND c.COD_MATRIZ_CLIENTE = '" + tb_cod_matriz.Text + "' ";


                string _cfop = " and (item.cfop_item like '_1__'	" +
                   "	or item.cfop_item like '_4__') ";
                if (cbCfop.Checked)
                {
                    _cfop = "  and (item.cfop_item = '" + tb_n_cfop.Text + "'	" +
                    "	or item.cfop_item = '6" + tb_n_cfop.Text.Substring(1, 3) + "' ) ";
                }
                dsClientesxproduto cli = new dsClientesxproduto();
                FbCommand select = new FbCommand();
                select.CommandText =
                    //"select sum(item.qtde_item), prod.COD_PRODUTO, '', ped.VENDEDOR_PED_VENDA, sum(item.PRECO_TOTAL_ITEM) 
                    "select prod.NOME_FORNECEDOR_PRODUTO, sum(item.qtde_item), sum(item.PRECO_TOTAL_ITEM), SUM(item.CUSTO_ITEM) from itens_nota item " +
                    "inner join produtos prod on prod.cod_fornecedor_produto = item.cod_item " +
                    "INNER JOIN nota_fiscal nf ON ITEM.NF_ITEM = NF.N_NF " +
                    "INNER JOIN PEDIDOS_NF ped_nf on nf.n_nf = ped_nf.nf_pedido_nf " +
                    "inner join pedidos_venda ped on ped.cod_ped_venda = ped_nf.n_pedido_nf " +
                     "inner join vendedores v on ped.COD_VENDEDOR_PED_VENDA = V.COD_VENDEDOR " +
                      "inner join clientes c on nf.CNPJ_CLIENTE_FORN = c.CNPJ " +
                    "where " +
                    "nf.STATUS_NFE LIKE ('%Autorizada%') AND " +
                    "nf.data_emissao_nf >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") +
                    "' and nf.data_emissao_nf <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                    _vendedor + _fornecedor + _cliente + _familia + supervisor +
                    _cfop +
                    "group by prod.COD_PRODUTO " +
                    " ORDER BY 1 desc ";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    double custo = 0;
                    try
                    {
                        custo = Convert.ToDouble(dr[3].ToString());
                    }
                    catch { }
                    try
                    {
                        cli.GRUPOSXVENDAS.AddGRUPOSXVENDASRow(dr[0].ToString(), Convert.ToDouble(dr[2].ToString()), Convert.ToDouble(dr[3].ToString()),
                           custo);
                    }
                    catch { }
                }

                

                cli.Dados.AddDadosRow(tb_nome_fornecedor.Text, Convert.ToDateTime(dtInicial.Text), Convert.ToDateTime(dtFinal.Text),
                    tb_nome_vendedor.Text, "", "", 0);


                crProdutosxABC cr = new crProdutosxABC();
                cr.SetDataSource(cli);
                form_imprimir imprime = new form_imprimir(cr);
                imprime.Show();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            try
            {

                dtInicial.Text = "01/01/" + Convert.ToDateTime(dtFinal.Text).Year.ToString();
                string _vendedor = "", _fornecedor = "", _cliente = "", _familia =  "";
                if (tb_nome_vendedor.Text != "")
                    _vendedor = " AND ped.VENDEDOR_PED_VENDA = '" + tb_nome_vendedor.Text + "' ";

                if (tb_nome_fornecedor.Text != "")
                    _fornecedor = " AND prod.NOME_FORNECEDOR_PRODUTO = '" + tb_nome_fornecedor.Text + "' ";

                if (tb_nome_cliente.Text != "")
                    _cliente = " AND nf.CNPJ_CLIENTE_FORN = '" + tb_cnpj.Text + "' ";
                if (tb_cod_matriz.Text != "")
                    _cliente = " AND c.COD_MATRIZ_CLIENTE = '" + tb_cod_matriz.Text + "' ";

                if (tbGrupo.Text != "")
                    _familia = " AND prod.DESCRICAO_GRUPO_PRODUTO = '" + tbGrupo.Text + "' ";
                if (tbdescricaoSubgrupo.Text != "")
                    _familia = " AND prod.DESCRICAO_SUB_GRUPO_PRODUTO = '" + tbdescricaoSubgrupo.Text + "' ";
                if (tb_nome_produto.Text != "")
                    _familia = " AND prod.COD_PRODUTO = '" + tb_cod_produto.Text + "' ";
                if (tbFamilia.Text != "")
                    _familia += " AND prod.NOME_FAMILIA_PRODUTO = '" + tbFamilia.Text + "'";


                string _cfop = " and (item.cfop_item like '_1__'	" +
                   "	or item.cfop_item like '_4__') ";
                if (cbCfop.Checked)
                {
                    _cfop = "  and (item.cfop_item = '" + tb_n_cfop.Text + "'	" +
                    "	or item.cfop_item = '6" + tb_n_cfop.Text.Substring(1, 3) + "' ) ";
                }
                dsClientesxproduto cli = new dsClientesxproduto();
                FbCommand select = new FbCommand();
                //selecionando mes a mes
                select.CommandText =
                    "select  extract(month from nf.data_emissao_nf), nf.cnpj_cliente_forn as CNPJ, count(distinct(item.COD_ITEM)) from itens_nota item " +
                    "inner join produtos prod on prod.cod_fornecedor_produto = item.cod_item " +
                    "INNER JOIN nota_fiscal nf ON ITEM.NF_ITEM = NF.N_NF " +
                    "INNER JOIN PEDIDOS_NF ped_nf on nf.n_nf = ped_nf.nf_pedido_nf " +
                    "inner join pedidos_venda ped on ped.cod_ped_venda = ped_nf.n_pedido_nf " +
                    "inner join vendedores v on ped.COD_VENDEDOR_PED_VENDA = V.COD_VENDEDOR " + 
                    "inner join clientes c on nf.CNPJ_CLIENTE_FORN = c.CNPJ " + 
                    "where " +
                    "nf.STATUS_NFE LIKE ('%Autorizada%') " + _cfop + " AND " +
                    "nf.data_emissao_nf >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") +
                    "' and nf.data_emissao_nf <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                    _vendedor + _fornecedor + _cliente + _familia + supervisor + 
                    "group by 1, nf.cnpj_cliente_forn";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();

                //selecionando cnpjs dos clientes
                FbCommand select_cnpjs = new FbCommand();
                select_cnpjs.CommandText =
                    "select distinct(nf.cnpj_cliente_forn) from itens_nota item " +
                    "inner join produtos prod on prod.cod_fornecedor_produto = item.cod_item " +
                    "INNER JOIN nota_fiscal nf ON ITEM.NF_ITEM = NF.N_NF " +
                    "INNER JOIN PEDIDOS_NF ped_nf on nf.n_nf = ped_nf.nf_pedido_nf " +
                    "inner join pedidos_venda ped on ped.cod_ped_venda = ped_nf.n_pedido_nf " +
                    "inner join vendedores v on ped.COD_VENDEDOR_PED_VENDA = v.COD_VENDEDOR " +
                     "inner join clientes c on nf.CNPJ_CLIENTE_FORN = c.CNPJ " + 
                    "where " +
                    "nf.STATUS_NFE LIKE ('%Autorizada%') " + _cfop + " AND " +
                    "nf.data_emissao_nf >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") +
                    "' and nf.data_emissao_nf <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                    _vendedor + _fornecedor + _cliente + _familia + supervisor;
                //"group by 1, nf.cnpj_cliente_forn";
                select_cnpjs.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect_cnpjs = new FbDataAdapter();
                datSelect_cnpjs.SelectCommand = select_cnpjs;
                DataTable dtSelect_cnpjs = new DataTable();
                datSelect_cnpjs.Fill(dtSelect_cnpjs);
                fbConnection1.Close();

                foreach (DataRow dr_cnpjs in dtSelect_cnpjs.Rows)
                {
                    double _01 = 0, _02 = 0, _03 = 0, _04 = 0, _05 = 0, _06 = 0, _07 = 0, _08 = 0, _09 = 0, _10 = 0, _11 = 0, _12 = 0;


                    double total = 0;
                    foreach (DataRow dr in dtSelect.Select("CNPJ = '" + dr_cnpjs[0].ToString() + "'"))
                    {

                        if (dr[0].ToString() == "1")
                        {
                            try
                            {
                                _01 = Convert.ToDouble(dr[2].ToString());

                            }
                            catch { }
                        }
                        if (dr[0].ToString() == "2")
                        {
                            try
                            {
                                _02 = Convert.ToDouble(dr[2].ToString());
                            }
                            catch { }
                        }
                        if (dr[0].ToString() == "3")
                        {
                            try
                            {
                                _03 = Convert.ToDouble(dr[2].ToString());
                            }
                            catch { }
                        }
                        if (dr[0].ToString() == "4")
                        {
                            try
                            {
                                _04 = Convert.ToDouble(dr[2].ToString());
                            }
                            catch { }
                        }
                        if (dr[0].ToString() == "5")
                        {
                            try
                            {
                                _05 = Convert.ToDouble(dr[2].ToString());
                            }
                            catch { }
                        }
                        if (dr[0].ToString() == "6")
                        {
                            try
                            {
                                _06 = Convert.ToDouble(dr[2].ToString());
                            }
                            catch { }
                        }
                        if (dr[0].ToString() == "7")
                        {
                            try
                            {
                                _07 = Convert.ToDouble(dr[2].ToString());
                            }
                            catch { }
                        }
                        if (dr[0].ToString() == "8")
                        {
                            try
                            {
                                _08 = Convert.ToDouble(dr[2].ToString());
                            }
                            catch { }
                        }
                        if (dr[0].ToString() == "9")
                        {
                            try
                            {
                                _09 = Convert.ToDouble(dr[2].ToString());
                            }
                            catch { }
                        }
                        if (dr[0].ToString() == "10")
                        {
                            try
                            {
                                _10 = Convert.ToDouble(dr[2].ToString());
                            }
                            catch { }
                        }
                        if (dr[0].ToString() == "11")
                        {
                            try
                            {
                                _11 = Convert.ToDouble(dr[2].ToString());
                            }
                            catch { }
                        }
                        if (dr[0].ToString() == "12")
                        {
                            try
                            {
                                _12 = Convert.ToDouble(dr[2].ToString());
                            }
                            catch { }
                        }
                        try
                        {
                            total = total + Convert.ToDouble(dr[2].ToString());

                        }
                        catch { }

                    }
                    try
                    {
                        total = total / Convert.ToDateTime(dtFinal.Text).Month;
                        cli.ABC.AddABCRow(dr_cnpjs[0].ToString(), _01, _02, _03, _04, _05, _06, _07, _08, _09, _10, _11, _12, total);
                    }
                    catch { }
                }

                FbCommand select_clientes = new FbCommand();
                select_clientes.CommandText =
                    "SELECT * from clientes";
                select_clientes.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect_clientes = new FbDataAdapter();
                datSelect_clientes.SelectCommand = select_clientes;
                datSelect_clientes.Fill(cli.CLIENTES);
                fbConnection1.Close();

                cli.Dados.AddDadosRow(tb_nome_fornecedor.Text, Convert.ToDateTime(dtInicial.Text), Convert.ToDateTime(dtFinal.Text),
                    tb_nome_vendedor.Text, "", tb_nome_produto.Text,0);


                crABC_skus cr = new crABC_skus();
                cr.SetDataSource(cli);
                form_imprimir imprime = new form_imprimir(cr);
                imprime.Show();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            try
            {
                string _vendedor = "", _fornecedor = "", _cliente = "", _cliente_ent = "", _familia =  "";

                if (tbGrupo.Text != "")
                    _familia = " AND prod.DESCRICAO_GRUPO_PRODUTO = '" + tbGrupo.Text + "' ";
                if (tbdescricaoSubgrupo.Text != "")
                    _familia = " AND prod.DESCRICAO_SUB_GRUPO_PRODUTO = '" + tbdescricaoSubgrupo.Text + "' ";
                if (tb_nome_produto.Text != "")
                    _familia = " AND prod.COD_PRODUTO = '" + tb_cod_produto.Text + "' ";

                if (tbFamilia.Text != "")
                    _familia += " AND prod.NOME_FAMILIA_PRODUTO = '" + tbFamilia.Text + "'";

                if (tb_nome_vendedor.Text != "")
                    _vendedor = " AND pv.VENDEDOR_PED_VENDA = '" + tb_nome_vendedor.Text + "' ";

                if (tb_nome_fornecedor.Text != "")
                    _fornecedor = " AND prod.NOME_FORNECEDOR_PRODUTO = '" + tb_nome_fornecedor.Text + "' ";

                if (tb_nome_cliente.Text != "")
                {
                    _cliente = " AND nf.CNPJ_CLIENTE_FORN = '" + tb_cnpj.Text + "' ";
                    _cliente_ent = " AND nfe.CNPJ_CLIENTE_FORN_ENT = '" + tb_cnpj.Text + "' ";
                }
                if (tb_cod_matriz.Text != "")
                {
                    _cliente = " AND cl.COD_MATRIZ_CLIENTE = '" + tb_cod_matriz.Text + "' ";
                    _cliente_ent = " AND cl.COD_MATRIZ_CLIENTE = '" + tb_cod_matriz.Text + "' ";
                }

                string _cfop =  "";
                if (cbCfop.Checked)
                {
                    _cfop = "  and (inf.cfop_item = '" + tb_n_cfop.Text + "'	" +
                    "	or inf.cfop_item = '6" + tb_n_cfop.Text.Substring(1, 3) + "' ) ";
                }

                FbCommand select = new FbCommand();
                select.CommandText =
                    @"select pv.vendedor_ped_venda, upper(cl.cidade) as cidade, inf.cfop_item, sum(inf.preco_total_item) as valor_total, sum(inf.qtde_item) as qtde_total, 'S' as tipo from itens_nota inf
inner join nota_fiscal nf on inf.nf_item = nf.n_nf
inner join clientes cl on nf.cnpj_cliente_forn = cl.cnpj
inner join pedidos_nf pnf on nf.n_nf = pnf.nf_pedido_nf
inner join pedidos_venda pv on pnf.n_pedido_nf = pv.cod_ped_venda
inner join produtos prod on inf.cod_item = prod.cod_fornecedor_produto
inner join vendedores v on pv.COD_VENDEDOR_PED_VENDA = V.COD_VENDEDOR
where nf.STATUS_NFE LIKE ('%Autorizada%') AND " +
                    "nf.data_emissao_nf >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") +
                    @"' and nf.data_emissao_nf <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + @"' " +
                    _vendedor + _fornecedor + _cfop + _cliente + _familia + supervisor + @"
group by pv.vendedor_ped_venda, cl.cidade, inf.cfop_item " +
                    "union " + //PESQUISANDO AS NOTAS DE TROCA INSERIDAS PELA NF ENTRADA
                    "select vcl.nome_vendedor_vc as vendedor_ped_venda, upper(cl.cidade) as cidade, ent.cfop_item_ent as cfop_item,  sum(ent.preco_total_item_ent), sum(ent.qtde_item_ent), 'E' as tipo from itens_nota_ent ent inner join " +
                    "nota_fiscal_ent nfe on ent.nf_item_ent = nfe.n_nf_ent " +
                    "inner join clientes cl on nfe.CNPJ_CLIENTE_FORN_ENT = cl.CNPJ " +
                    "inner join vendedores_cliente vcl on cl.cod_cliente = vcl.cod_cliente_vc " +
                    "inner join vendedores v on vcl.COD_VENDEDOR_VC = V.COD_VENDEDOR " +
                    "where (ent.cfop_item_ent = '5202' or " +
                    "ent.cfop_item_ent = '6202' or ent.cfop_item_ent = '5411' or ent.cfop_item_ent = '6411') " +
                    "AND nfe.data_emissao_nf_ent >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") + "' " +
                    "and nfe.data_emissao_nf_ent <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                    _cliente_ent + supervisor +
                    "and nfe.baixada_nf_ent = 1 group by vcl.nome_vendedor_vc, upper(cl.cidade), ENT.cfop_item_ent ";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();



                //CLIENTES ATIVOS
                select.CommandText =
                    @"select vcl.nome_vendedor_vc, upper(cl.cidade) as cidade, count(distinct(cl.cnpj)) as clientes from clientes cl
inner join vendedores_cliente vcl on cl.cod_cliente = vcl.cod_cliente_vc
inner join vendedores v on vcl.COD_VENDEDOR_VC = V.COD_VENDEDOR 
where 0=0  " + supervisor + " group by vcl.nome_vendedor_vc, upper(cl.cidade)";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect_cidades = new FbDataAdapter();
                datSelect_cidades.SelectCommand = select;
                DataTable dtSelect_cidades = new DataTable();
                datSelect_cidades.Fill(dtSelect_cidades);
                fbConnection1.Close();


                _cfop = " and (inf.cfop_item = '5102'	" +
                  "	or inf.cfop_item = '5405') ";
                //CLIENTES POSITIVADOS
                select.CommandText =
                    @"select pv.vendedor_ped_venda, upper(cl.cidade) as cidade, count(distinct(cl.cnpj)) as clientes from itens_nota inf
inner join nota_fiscal nf on inf.nf_item = nf.n_nf
inner join clientes cl on nf.cnpj_cliente_forn = cl.cnpj
inner join pedidos_nf pnf on nf.n_nf = pnf.nf_pedido_nf
inner join pedidos_venda pv on pnf.n_pedido_nf = pv.cod_ped_venda
inner join produtos prod on inf.cod_item = prod.cod_fornecedor_produto
inner join vendedores v on pv.COD_VENDEDOR_PED_VENDA = V.COD_VENDEDOR 
where nf.STATUS_NFE LIKE ('%Autorizada%') AND " +
                    "nf.data_emissao_nf >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") +
                    @"' and nf.data_emissao_nf <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + @"' " +
                    _vendedor + _fornecedor + _cfop + _cliente + _familia+ supervisor + @"
group by pv.vendedor_ped_venda, upper(cl.cidade)";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect_positivados = new FbDataAdapter();
                datSelect_positivados.SelectCommand = select;
                DataTable dtSelect_positivados = new DataTable();
                datSelect_positivados.Fill(dtSelect_positivados);
                fbConnection1.Close();


                select.CommandText =
                    @"select distinct(pv.vendedor_ped_venda) as nome_vendedor_vc, upper(cl.cidade) as cidade from itens_nota inf
inner join nota_fiscal nf on inf.nf_item = nf.n_nf
inner join clientes cl on nf.cnpj_cliente_forn = cl.cnpj
inner join pedidos_nf pnf on nf.n_nf = pnf.nf_pedido_nf
inner join pedidos_venda pv on pnf.n_pedido_nf = pv.cod_ped_venda
inner join produtos prod on inf.cod_item = prod.cod_fornecedor_produto
inner join vendedores v on pv.COD_VENDEDOR_PED_VENDA = v.COD_VENDEDOR
where nf.STATUS_NFE LIKE ('%Autorizada%') AND " +
                    "nf.data_emissao_nf >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") +
                    @"' and nf.data_emissao_nf <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + @"' " +
                    _vendedor + _fornecedor + _cfop + _cliente + _familia + supervisor + @"
group by pv.vendedor_ped_venda, upper(cl.cidade), inf.cfop_item ";

                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect_todos = new FbDataAdapter();
                datSelect_todos.SelectCommand = select;
                DataTable dtSelect_todos = new DataTable();
                datSelect_todos.Fill(dtSelect_todos);
                fbConnection1.Close();


                dsClientesxproduto c = new dsClientesxproduto();
                foreach (DataRow dr_todos in dtSelect_todos.Rows)
                {
                    try
                    {
                        double valor_venda = 0, valor_troca = 0, qtde_venda = 0;
                        int clientes = 0;

                        foreach (DataRow dr_cidades in dtSelect_cidades.Select("nome_vendedor_vc = '" + dr_todos["nome_vendedor_vc"].ToString() + "' AND " +
                           "cidade = '" + dr_todos["cidade"].ToString() + "'"))
                        {
                            try
                            {
                                clientes = Convert.ToInt32(dr_cidades["clientes"].ToString());
                            }
                            catch { }
                        }
                        int clientes_positivados = 0;
                        foreach (DataRow dr_positivados in dtSelect_positivados.Select("vendedor_ped_venda = '" + dr_todos["nome_vendedor_vc"].ToString() + "' AND " +
                            "cidade = '" + dr_todos["cidade"].ToString() + "'"))
                        {
                            clientes_positivados += Convert.ToInt32(dr_positivados["clientes"].ToString());
                        }


                        foreach (DataRow dr_valores in dtSelect.Select("vendedor_ped_venda = '" + dr_todos["nome_vendedor_vc"].ToString() + "' AND " +
                            "cidade = '" + dr_todos["cidade"].ToString() + "'"))
                        {
                            if (dr_valores["cfop_item"].ToString() == "5102" || dr_valores["cfop_item"].ToString() == "5405")
                            {
                                valor_venda += Convert.ToDouble(dr_valores["valor_total"].ToString());
                                qtde_venda += Convert.ToDouble(dr_valores["qtde_total"].ToString());
                            }
                            else
                            {
                                if (dr_valores["cfop_item"].ToString() == "5910" || dr_valores["cfop_item"].ToString() == "5949"
                                    || dr_valores["cfop_item"].ToString() == "6910" || dr_valores["cfop_item"].ToString() == "6949")
                                    valor_troca += Convert.ToDouble(dr_valores["valor_total"].ToString());
                                else
                                    if (dr_valores["cfop_item"].ToString() == "5202" || dr_valores["cfop_item"].ToString() == "6202" ||
                                        dr_valores["cfop_item"].ToString() == "5411" || dr_valores["cfop_item"].ToString() == "6411")
                                        valor_troca += Convert.ToDouble(dr_valores["valor_total"].ToString());
                            }
                        }

                        c.VendedorxCidadesxPositivacao.AddVendedorxCidadesxPositivacaoRow(dr_todos["nome_vendedor_vc"].ToString(),
                            dr_todos["cidade"].ToString(), clientes, clientes_positivados, qtde_venda, valor_venda, valor_troca);
                    }
                    catch (Exception a)
                    {
                        MessageBox.Show(a.ToString());
                    }
                }
                c.Dados.AddDadosRow(tb_nome_fornecedor.Text, Convert.ToDateTime(dtInicial.Text), Convert.ToDateTime(dtFinal.Text),
                  tb_nome_vendedor.Text, "", "",0);


                crVendedorxCidadexPositivacao cr = new crVendedorxCidadexPositivacao();
                cr.SetDataSource(c);
                form_imprimir imprime = new form_imprimir(cr);
                imprime.Show();



            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            try
            {
                string _vendedor = "", _fornecedor = "", _cliente = "", _cliente_ent = "", _familia =  "";

                if (tbGrupo.Text != "")
                    _familia = " AND prod.DESCRICAO_GRUPO_PRODUTO = '" + tbGrupo.Text + "' ";
                if (tbdescricaoSubgrupo.Text != "")
                    _familia = " AND prod.DESCRICAO_SUB_GRUPO_PRODUTO = '" + tbdescricaoSubgrupo.Text + "' ";
                if (tb_nome_produto.Text != "")
                    _familia = " AND prod.COD_PRODUTO = '" + tb_cod_produto.Text + "' ";

                if (tbFamilia.Text != "")
                    _familia += " AND prod.NOME_FAMILIA_PRODUTO = '" + tbFamilia.Text + "'";

                if (tb_nome_vendedor.Text != "")
                    _vendedor = " AND ped.VENDEDOR_PED_VENDA = '" + tb_nome_vendedor.Text + "' ";

                if (tb_nome_fornecedor.Text != "")
                    _fornecedor = " AND prod.NOME_FORNECEDOR_PRODUTO = '" + tb_nome_fornecedor.Text + "' ";

                if (tb_nome_cliente.Text != "")
                {
                    _cliente = " AND nf.CNPJ_CLIENTE_FORN = '" + tb_cnpj.Text + "' ";
                    _cliente_ent = " AND nfe.CNPJ_CLIENTE_FORN_ENT = '" + tb_cnpj.Text + "' ";
                }
                if (tb_cod_matriz.Text != "")
                {
                    _cliente = " AND cl.COD_MATRIZ_CLIENTE = '" + tb_cod_matriz.Text + "' ";
                    _cliente_ent = " AND cl.COD_MATRIZ_CLIENTE = '" + tb_cod_matriz.Text + "' ";
                }

                string _cfop =  "";
                if (cbCfop.Checked)
                {
                    _cfop = "  and (inf.cfop_item = '" + tb_n_cfop.Text + "'	" +
                    "	or inf.cfop_item = '6" + tb_n_cfop.Text.Substring(1, 3) + "' ) ";
                }

                FbCommand select = new FbCommand();
                select.CommandText =
                    @"select upper(cl.cidade) as cidade, inf.cfop_item, sum(inf.preco_total_item) as valor_total, sum(inf.qtde_item) as qtde_total from itens_nota inf
inner join nota_fiscal nf on inf.nf_item = nf.n_nf
inner join clientes cl on nf.cnpj_cliente_forn = cl.cnpj
inner join pedidos_nf pnf on nf.n_nf = pnf.nf_pedido_nf
inner join pedidos_venda pv on pnf.n_pedido_nf = pv.cod_ped_venda
inner join produtos prod on inf.cod_item = prod.cod_fornecedor_produto
inner join vendedores v on pv.COD_VENDEDOR_PED_VENDA = v.COD_VENDEDOR
where nf.STATUS_NFE LIKE ('%Autorizada%') AND " +
                    "nf.data_emissao_nf >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") +
                    @"' and nf.data_emissao_nf <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + @"' " +
                    _vendedor + _fornecedor + _cfop + _cliente + supervisor + _familia + @"
group by pv.vendedor_ped_venda, cl.cidade, inf.cfop_item " +
                    "union " + //PESQUISANDO AS NOTAS DE TROCA INSERIDAS PELA NF ENTRADA
                    "select upper(cl.cidade) as cidade, ent.cfop_item_ent as cfop_item,  sum(ent.preco_total_item_ent), sum(ent.qtde_item_ent) from itens_nota_ent ent inner join " +
                    "nota_fiscal_ent nfe on ent.nf_item_ent = nfe.n_nf_ent " +
                    "inner join clientes cl on nfe.CNPJ_CLIENTE_FORN_ENT = cl.CNPJ " +
                    "inner join vendedores_cliente vcl on cl.cod_cliente = vcl.cod_cliente_vc " +
                    "inner join vendedores v on vcl.COD_VENDEDOR_VC = v.COD_VENDEDOR " +
                    "where (ent.cfop_item_ent = '5202' or " +
                    "ent.cfop_item_ent = '6202' or ent.cfop_item_ent = '5411' or ent.cfop_item_ent = '6411') " +
                    "AND nfe.data_emissao_nf_ent >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") + "' " +
                    "and nfe.data_emissao_nf_ent <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                    _cliente_ent +
                    "and nfe.baixada_nf_ent = 1 group by upper(cl.cidade), ent.cfop_item_ent ";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();



                //CLIENTES ATIVOS
                select.CommandText =
                    @"select upper(cl.cidade) as cidade, count(distinct(cl.cnpj)) as clientes from clientes cl
inner join vendedores_cliente vcl on cl.cod_cliente = vcl.cod_cliente_vc
inner join vendedores v on vcl.COD_VENDEDOR_VC = v.COD_VENDEDOR
where 0=0 " + supervisor + " group by upper(cl.cidade)";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect_cidades = new FbDataAdapter();
                datSelect_cidades.SelectCommand = select;
                DataTable dtSelect_cidades = new DataTable();
                datSelect_cidades.Fill(dtSelect_cidades);
                fbConnection1.Close();


                _cfop = " and (inf.cfop_item = '5102'	" +
                  "	or inf.cfop_item = '5405') ";
                //CLIENTES POSITIVADOS
                select.CommandText =
                    @"select upper(cl.cidade) as cidade, count(distinct(cl.cnpj)) as clientes from itens_nota inf
inner join nota_fiscal nf on inf.nf_item = nf.n_nf
inner join clientes cl on nf.cnpj_cliente_forn = cl.cnpj
inner join pedidos_nf pnf on nf.n_nf = pnf.nf_pedido_nf
inner join pedidos_venda pv on pnf.n_pedido_nf = pv.cod_ped_venda
inner join produtos prod on inf.cod_item = prod.cod_fornecedor_produto
inner join vendedores v on pv.COD_VENDEDOR_PED_VENDA = v.COD_VENDEDOR
where nf.STATUS_NFE LIKE ('%Autorizada%') AND " +
                    "nf.data_emissao_nf >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") +
                    @"' and nf.data_emissao_nf <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + @"' " +
                    _vendedor + _fornecedor + _cfop + _cliente + supervisor + _familia + @"
group by upper(cl.cidade)";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect_positivados = new FbDataAdapter();
                datSelect_positivados.SelectCommand = select;
                DataTable dtSelect_positivados = new DataTable();
                datSelect_positivados.Fill(dtSelect_positivados);
                fbConnection1.Close();


                select.CommandText =
                    @"select upper(cl.cidade) as cidade from itens_nota inf
inner join nota_fiscal nf on inf.nf_item = nf.n_nf
inner join clientes cl on nf.cnpj_cliente_forn = cl.cnpj
inner join pedidos_nf pnf on nf.n_nf = pnf.nf_pedido_nf
inner join pedidos_venda pv on pnf.n_pedido_nf = pv.cod_ped_venda
inner join produtos prod on inf.cod_item = prod.cod_fornecedor_produto
inner join vendedores v on pv.COD_VENDEDOR_PED_VENDA = v.COD_VENDEDOR
where nf.STATUS_NFE LIKE ('%Autorizada%') AND " +
                    "nf.data_emissao_nf >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") +
                    @"' and nf.data_emissao_nf <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + @"' " +
                    _vendedor + _fornecedor + _cfop + _cliente + supervisor + _familia + @"
group by upper(cl.cidade) ";

                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect_todos = new FbDataAdapter();
                datSelect_todos.SelectCommand = select;
                DataTable dtSelect_todos = new DataTable();
                datSelect_todos.Fill(dtSelect_todos);
                fbConnection1.Close();


                dsClientesxproduto c = new dsClientesxproduto();
                foreach (DataRow dr_todos in dtSelect_todos.Rows)
                {
                    try
                    {
                        double valor_venda = 0, valor_troca = 0, qtde_venda = 0;
                        int clientes = 0;

                        foreach (DataRow dr_cidades in dtSelect_cidades.Select("cidade = '" + dr_todos["cidade"].ToString() + "'"))
                        {
                            try
                            {
                                clientes = Convert.ToInt32(dr_cidades["clientes"].ToString());
                            }
                            catch { }
                        }
                        int clientes_positivados = 0;
                        foreach (DataRow dr_positivados in dtSelect_positivados.Select("cidade = '" + dr_todos["cidade"].ToString() + "'"))
                        {
                            clientes_positivados += Convert.ToInt32(dr_positivados["clientes"].ToString());
                        }


                        foreach (DataRow dr_valores in dtSelect.Select("cidade = '" + dr_todos["cidade"].ToString() + "'"))
                        {
                            if (dr_valores["cfop_item"].ToString() == "5102" || dr_valores["cfop_item"].ToString() == "5405")
                            {
                                valor_venda += Convert.ToDouble(dr_valores["valor_total"].ToString());
                                qtde_venda += Convert.ToDouble(dr_valores["qtde_total"].ToString());
                            }
                            else
                            {
                                if (dr_valores["cfop_item"].ToString() != "5910")
                                    valor_troca += Convert.ToDouble(dr_valores["valor_total"].ToString());
                            }
                        }

                        c.VendedorxCidadesxPositivacao.AddVendedorxCidadesxPositivacaoRow("",
                            dr_todos["cidade"].ToString(), clientes, clientes_positivados, qtde_venda, valor_venda, valor_troca);
                    }
                    catch (Exception a)
                    {
                        MessageBox.Show(a.ToString());
                    }
                }
                c.Dados.AddDadosRow(tb_nome_fornecedor.Text, Convert.ToDateTime(dtInicial.Text), Convert.ToDateTime(dtFinal.Text),
                 tb_nome_vendedor.Text, "", "",0);

                crVendedorxCidadexPositivacao cr = new crVendedorxCidadexPositivacao();
                cr.SetDataSource(c);
                form_imprimir imprime = new form_imprimir(cr);
                imprime.Show();



            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }

        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (tb_nome_produto.Text != "" || tbFamilia.Text != "")
                MessageBox.Show("Esse relatório não funciona com produto e família");
            else
            {
                try
                {
                    string _vendedor = "", _fornecedor = "", _cliente = "", _cliente_ent = "", _vendedor_ent =  "";
                    if (tb_nome_vendedor.Text != "")
                    {
                        _vendedor = " AND ped.VENDEDOR_PED_VENDA = '" + tb_nome_vendedor.Text + "' ";
                        _vendedor_ent = "AND vc.NOME_VENDEDOR_VC = '" + tb_nome_vendedor.Text + "' ";
                    }

                    string _fornecedor_ent =  "";
                    if (tb_nome_fornecedor.Text != "")
                    {
                        _fornecedor = " AND prod.NOME_FORNECEDOR_PRODUTO = '" + tb_nome_fornecedor.Text + "' ";
                        _fornecedor_ent = " AND prod.NOME_FORNECEDOR_PRODUTO = '" + tb_nome_fornecedor.Text + "' ";
                    }

                    if (tb_nome_cliente.Text != "")
                    {
                        _cliente = " AND nf.CNPJ_CLIENTE_FORN = '" + tb_cnpj.Text + "' ";
                        _cliente_ent = " AND nfe.CNPJ_CLIENTE_FORN_ENT = '" + tb_cnpj.Text + "' ";
                    }
                    if (tb_cod_matriz.Text != "")
                    {
                        _cliente = " AND c.COD_MATRIZ_CLIENTE = '" + tb_cod_matriz.Text + "' ";
                        _cliente_ent = " AND c.COD_MATRIZ_CLIENTE = '" + tb_cod_matriz.Text + "' ";
                    }

                    string _cfop = " and (item.cfop_item like '_1__'	" +
                       "	or item.cfop_item like '_4__') ";
                    if (cbCfop.Checked)
                    {
                        _cfop = "  and (item.cfop_item = '" + tb_n_cfop.Text + "'	" +
                        "	or item.cfop_item = '6" + tb_n_cfop.Text.Substring(1, 3) + "' ) ";
                    }
                    dsClientesxproduto cli = new dsClientesxproduto();
                    FbCommand select = new FbCommand();
                    select.CommandText =
                        //"select sum(item.qtde_item), prod.COD_PRODUTO, '', ped.VENDEDOR_PED_VENDA, sum(item.PRECO_TOTAL_ITEM) 
                        "select sum(item.qtde_item), '0', nf.CNPJ_CLIENTE_FORN, '', sum(item.PRECO_TOTAL_ITEM) AS VALOR, sum(item.CUSTO_ITEM) from itens_nota item " +
                        "inner join produtos prod on prod.cod_fornecedor_produto = item.cod_item " +
                        "INNER JOIN nota_fiscal nf ON ITEM.NF_ITEM = NF.N_NF " +
                        "INNER JOIN PEDIDOS_NF ped_nf on nf.n_nf = ped_nf.nf_pedido_nf " +
                        "inner join pedidos_venda ped on ped.cod_ped_venda = ped_nf.n_pedido_nf " +
                         "inner join clientes c on nf.CNPJ_CLIENTE_FORN = c.CNPJ " + 
                        "where " +
                        "nf.STATUS_NFE LIKE ('%Autorizada%') AND " +
                        "nf.data_emissao_nf >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") +
                        "' and nf.data_emissao_nf <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                        _vendedor + _fornecedor + _cliente +
                        _cfop +
                        // " and (item.cfop_item like '_949' or item.cfop_item like '_910') " +
                        "group by nf.CNPJ_CLIENTE_FORN order by VALOR DESC";
                    select.Connection = fbConnection1;
                    fbConnection1.Open();
                    FbDataAdapter datSelect = new FbDataAdapter();
                    datSelect.SelectCommand = select;
                    DataTable dtSelect = new DataTable();
                    datSelect.Fill(dtSelect);
                    fbConnection1.Close();


                    //buscando valor_troca
                    FbCommand select_troca = new FbCommand();
                    select_troca.CommandText =
                    "select sum(item.PRECO_TOTAL_ITEM), nf.CNPJ_CLIENTE_FORN as cnpj from itens_nota item " +
                  "inner join produtos prod on prod.cod_fornecedor_produto = item.cod_item " +
                  "INNER JOIN nota_fiscal nf ON ITEM.NF_ITEM = NF.N_NF " +
                  "INNER JOIN PEDIDOS_NF ped_nf on nf.n_nf = ped_nf.nf_pedido_nf " +
                  "inner join pedidos_venda ped on ped.cod_ped_venda = ped_nf.n_pedido_nf " +
                   "inner join clientes c on nf.CNPJ_CLIENTE_FORN = c.CNPJ " + 
                  "where " +
                  "nf.STATUS_NFE LIKE ('%Autorizada%') AND " +
                  "nf.data_emissao_nf >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") +
                  "' and nf.data_emissao_nf <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                  _vendedor + _fornecedor + _cliente + 
                  " AND (item.cfop_item like '_949' or item.cfop_item like '_910')  group by nf.CNPJ_CLIENTE_FORN " + // and nf.CNPJ_CLIENTE_FORN = '" + dr[2].ToString() + "'" +
                    "union " + //PESQUISANDO AS NOTAS DE TROCA INSERIDAS PELA NF ENTRADA
                "select sum(ent.preco_total_item_ent), nfe.CNPJ_CLIENTE_FORN_ENT as cnpj from itens_nota_ent ent inner join " +
                "nota_fiscal_ent nfe on ent.nf_item_ent = nfe.n_nf_ent " +
                "inner join produtos prod on prod.COD_BARRAS_PRODUTO = ent.COD_EAN_ITEM_ENT " +
                "inner join clientes c on nfe.CNPJ_CLIENTE_FORN_ENT = c.CNPJ " + 
                "INNER JOIN vendedores_cliente vc on c.COD_CLIENTE = vc.COD_CLIENTE_VC " + 
                "where (ent.cfop_item_ent = '5202' or " +
                "ent.cfop_item_ent = '6202' or ent.cfop_item_ent = '5411' or ent.cfop_item_ent = '6411') " +
                "AND nfe.data_emissao_nf_ent >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") + "' " +
                "and nfe.data_emissao_nf_ent <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                _cliente_ent + _vendedor_ent + _fornecedor_ent +
                "and nfe.baixada_nf_ent = 1 group by nfe.CNPJ_CLIENTE_FORN_ENT ";
                    // "and nfe.CNPJ_CLIENTE_FORN_ENT = '" + dr[2].ToString() + "'";

                    select_troca.Connection = fbConnection1;
                    fbConnection1.Open();
                    FbDataAdapter datSelect_troca = new FbDataAdapter();
                    datSelect_troca.SelectCommand = select_troca;
                    DataTable dtSelect_troca = new DataTable();
                    datSelect_troca.Fill(dtSelect_troca);
                    fbConnection1.Close();

                    DataTable dtClientes_com_venda_e_troca = new DataTable();
                    DataColumn col1 = new DataColumn();
                    col1.ColumnName = "cnpj";
                    dtClientes_com_venda_e_troca.Columns.Add(col1);
                    //string[] clientes_com_venda_e_troca = new string[10000];
                    //int i = 0;
                    foreach (DataRow dr in dtSelect.Rows)
                    {
                        double valor_trocas = 0;

                        foreach (DataRow dr_troca in dtSelect_troca.Select("cnpj = '" + dr[2].ToString() + "'"))
                        {

                            try
                            {
                                valor_trocas = valor_trocas + Convert.ToDouble(dr_troca[0].ToString());
                                dtClientes_com_venda_e_troca.Rows.Add(dr_troca["cnpj"].ToString());
                            }
                            catch { }
                        }

                        double custo = 0;
                        try
                        {
                            custo = Convert.ToDouble(dr[5].ToString());
                        }
                        catch { }
                        bool incluir = true;
                        if (cbApenas_troca.Checked)
                        {
                            if (valor_trocas == 0)
                                incluir = false;
                        }
                        if (incluir)
                        {
                            try
                            {
                                cli.VendedorxClientesxProdutos.AddVendedorxClientesxProdutosRow(Convert.ToDouble(dr[0].ToString()), Convert.ToInt32(dr[1].ToString()),
                                    dr[2].ToString(), dr[3].ToString(), Convert.ToDouble(dr[4].ToString()), custo, valor_trocas, 0, 0, 0, 0, 0);
                            }
                            catch { }
                        }
                    }
                    foreach (DataRow dr_troca in dtSelect_troca.Rows)
                    {
                        bool ja_entrou = false;
                        foreach (DataRow dr_vendas_e_trocas in dtClientes_com_venda_e_troca.Select("cnpj = '" + dr_troca["cnpj"].ToString() + "'"))
                        {
                            ja_entrou = true;
                        }
                        if (!ja_entrou)
                        {
                            double valor_trocas = 0;
                            try
                            {
                                valor_trocas = valor_trocas + Convert.ToDouble(dr_troca[0].ToString());
                                try
                                {
                                    cli.VendedorxClientesxProdutos.AddVendedorxClientesxProdutosRow(0, 0,
                                        dr_troca["cnpj"].ToString(), "", 0.00001, 0.00001, valor_trocas, 0.00001, 0, 0, 0, 0);
                                }
                                catch { }
                            }
                            catch { }
                        }
                    }




                    FbCommand select_clientes = new FbCommand();
                    select_clientes.CommandText =
                        "SELECT * from clientes";
                    select_clientes.Connection = fbConnection1;
                    fbConnection1.Open();
                    FbDataAdapter datSelect_clientes = new FbDataAdapter();
                    datSelect_clientes.SelectCommand = select_clientes;
                    datSelect_clientes.Fill(cli.CLIENTES);
                    fbConnection1.Close();

                    /*
                    FbCommand select_produtos = new FbCommand();
                    select_produtos.CommandText =
                        "SELECT * from produtos";
                    select_produtos.Connection = fbConnection1;
                    fbConnection1.Open();
                    FbDataAdapter datSelect_produtos = new FbDataAdapter();
                    datSelect_produtos.SelectCommand = select_produtos;
                    datSelect_produtos.Fill(cli.PRODUTOS);
                    fbConnection1.Close();
                    */
                    cli.Dados.AddDadosRow(tb_nome_fornecedor.Text, Convert.ToDateTime(dtInicial.Text), Convert.ToDateTime(dtFinal.Text),
                        tb_nome_vendedor.Text, "", "",0);


                    crClientesxlucratividade cr = new crClientesxlucratividade();
                    cr.SetDataSource(cli);
                    form_imprimir imprime = new form_imprimir(cr);
                    imprime.Show();
                }
                catch (Exception a)
                {
                    fbConnection1.Close();
                    MessageBox.Show(a.ToString());
                }
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {

            if (tb_nome_produto.Text != "" || tbFamilia.Text != "")
                MessageBox.Show("Esse relatório não funciona com produto e família");
            else
            {
                try
                {
                    string _vendedor = "", _fornecedor = "", _cliente = "", _cliente_ent = "", _vendedor_ent =  "";
                    if (tb_nome_vendedor.Text != "")
                    {
                        _vendedor = " AND ped.VENDEDOR_PED_VENDA = '" + tb_nome_vendedor.Text + "' ";
                        _vendedor_ent = "AND vc.NOME_VENDEDOR_VC = '" + tb_nome_vendedor.Text + "' ";
                    }

                    string _fornecedor_ent =  "";
                    if (tb_nome_fornecedor.Text != "")
                    {
                        _fornecedor = " AND prod.NOME_FORNECEDOR_PRODUTO = '" + tb_nome_fornecedor.Text + "' ";
                        _fornecedor_ent = " AND prod.NOME_FORNECEDOR_PRODUTO = '" + tb_nome_fornecedor.Text + "' ";
                    }
					

                    if (tb_nome_cliente.Text != "")
                    {
                        _cliente = " AND nf.CNPJ_CLIENTE_FORN = '" + tb_cnpj.Text + "' ";
                        _cliente_ent = " AND nfe.CNPJ_CLIENTE_FORN_ENT = '" + tb_cnpj.Text + "' ";
                    }

                    if (tb_cod_matriz.Text != "")
                    {
                        _cliente = " AND c.COD_MATRIZ_CLIENTE = '" + tb_cod_matriz.Text + "' ";
                        _cliente_ent = " AND c.COD_MATRIZ_CLIENTE = '" + tb_cod_matriz.Text + "' ";
                    }

                    string _cfop = " and (item.cfop_item like '_1__'	" +
                       "	or item.cfop_item like '_4__') ";
                    if (cbCfop.Checked)
                    {
                        _cfop = "  and (item.cfop_item = '" + tb_n_cfop.Text + "'	" +
                        "	or item.cfop_item = '6" + tb_n_cfop.Text.Substring(1, 3) + "' ) ";
                    }
                    dsClientesxproduto cli = new dsClientesxproduto();

                    //buscar outras cfops diferentes de vendas
                    FbCommand select1 = new FbCommand();
                    select1.CommandText =
                        //"select sum(item.qtde_item), prod.COD_PRODUTO, '', ped.VENDEDOR_PED_VENDA, sum(item.PRECO_TOTAL_ITEM) 
                        "select nf.CNPJ_CLIENTE_FORN as cnpj, sum(item.PRECO_TOTAL_ITEM) AS VALOR from itens_nota item " +
                        "inner join produtos prod on prod.cod_fornecedor_produto = item.cod_item " +
                        "INNER JOIN nota_fiscal nf ON ITEM.NF_ITEM = NF.N_NF " +
                          "INNER JOIN PEDIDOS_NF ped_nf on nf.n_nf = ped_nf.nf_pedido_nf " +
                             "inner join pedidos_venda ped on ped.cod_ped_venda = ped_nf.n_pedido_nf " +
                              "inner join vendedores v on ped.COD_VENDEDOR_PED_VENDA = V.COD_VENDEDOR " +
                               "inner join clientes c on nf.CNPJ_CLIENTE_FORN = c.CNPJ " + 
                        "where " +
                        "nf.STATUS_NFE LIKE ('%Autorizada%') AND " +
                        "nf.data_emissao_nf >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") +
                        "' and nf.data_emissao_nf <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                        _vendedor + _fornecedor + _cliente + supervisor + 
                        //_cfop +
                        //" AND item.cfop_item <> '5102'	" +
                        // "	AND item.cfop_item <> '5405' " +
                        " and (item.cfop_item like '_949') " +
                        "group by nf.CNPJ_CLIENTE_FORN " +
                         "union " + //PESQUISANDO AS NOTAS DE TROCA INSERIDAS PELA NF ENTRADA
                        "select nfe.CNPJ_CLIENTE_FORN_ENT as cnpj, sum(ent.preco_total_item_ent) as VALOR from itens_nota_ent ent inner join " +
                        "nota_fiscal_ent nfe on ent.nf_item_ent = nfe.n_nf_ent " +
                         "inner join produtos prod on prod.COD_BARRAS_PRODUTO = ent.COD_EAN_ITEM_ENT " +
                        "inner join clientes c on nfe.CNPJ_CLIENTE_FORN_ENT = c.CNPJ " +
                "INNER JOIN vendedores_cliente vc on c.COD_CLIENTE = vc.COD_CLIENTE_VC " +
                 "inner join vendedores v on vc.COD_VENDEDOR_VC = v.COD_VENDEDOR " +
                        "where (ent.cfop_item_ent = '5202' or " +
                        "ent.cfop_item_ent = '6202' or ent.cfop_item_ent = '5411' or ent.cfop_item_ent = '6411') " +
                        "AND nfe.data_emissao_nf_ent >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") + "' " +
                        "and nfe.data_emissao_nf_ent <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                        _cliente_ent + _vendedor_ent + _fornecedor_ent + supervisor +
                        "and nfe.baixada_nf_ent = 1 group by nfe.CNPJ_CLIENTE_FORN_ENT";
                    select1.Connection = fbConnection1;
                    fbConnection1.Open();
                    FbDataAdapter datSelect1 = new FbDataAdapter();
                    datSelect1.SelectCommand = select1;
                    DataTable dtSelect1 = new DataTable();
                    datSelect1.Fill(dtSelect1);
                    fbConnection1.Close();

                    /*
                     * 
                     * "select sum(item.qtde_item), '0', nf.CNPJ_CLIENTE_FORN, '', sum(item.PRECO_TOTAL_ITEM) AS VALOR, sum(item.CUSTO_ITEM) from itens_nota item " +
                        "inner join produtos prod on prod.cod_fornecedor_produto = item.cod_item " +
                        "INNER JOIN nota_fiscal nf ON ITEM.NF_ITEM = NF.N_NF " +
                        "INNER JOIN PEDIDOS_NF ped_nf on nf.n_nf = ped_nf.nf_pedido_nf " +
                        "inner join pedidos_venda ped on ped.cod_ped_venda = ped_nf.n_pedido_nf " +
                        "where " +
                        "nf.STATUS_NFE LIKE ('%Autorizada%') AND " +
                        "nf.data_emissao_nf >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") +
                        "' and nf.data_emissao_nf <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                        _vendedor + _fornecedor + _cliente +
                        _cfop +
                        "group by nf.CNPJ_CLIENTE_FORN order by VALOR DESC";*/

                    FbCommand select = new FbCommand();
                    select.CommandText =
                        //"select sum(item.qtde_item), prod.COD_PRODUTO, '', ped.VENDEDOR_PED_VENDA, sum(item.PRECO_TOTAL_ITEM) 
                        "select sum(item.qtde_item), '0', nf.CNPJ_CLIENTE_FORN, '', sum(item.PRECO_TOTAL_ITEM) AS VALOR, sum(item.CUSTO_ITEM) from itens_nota item " +
                        "inner join produtos prod on prod.cod_fornecedor_produto = item.cod_item " +
                        "INNER JOIN nota_fiscal nf ON ITEM.NF_ITEM = NF.N_NF " +
                        "INNER JOIN PEDIDOS_NF ped_nf on nf.n_nf = ped_nf.nf_pedido_nf " +
                        "inner join pedidos_venda ped on ped.cod_ped_venda = ped_nf.n_pedido_nf " +
                         "inner join vendedores v on ped.COD_VENDEDOR_PED_VENDA = v.COD_VENDEDOR " +
                          "inner join clientes c on nf.CNPJ_CLIENTE_FORN = c.CNPJ " + 
                        "where " +
                        "nf.STATUS_NFE LIKE ('%Autorizada%') AND " +
                        "nf.data_emissao_nf >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") +
                        "' and nf.data_emissao_nf <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                        _vendedor + _fornecedor + _cliente + supervisor +
                        _cfop +
                        "group by nf.CNPJ_CLIENTE_FORN order by VALOR DESC";
                    select.Connection = fbConnection1;
                    fbConnection1.Open();
                    FbDataAdapter datSelect = new FbDataAdapter();
                    datSelect.SelectCommand = select;
                    DataTable dtSelect = new DataTable();
                    datSelect.Fill(dtSelect);
                    fbConnection1.Close();

                    DataTable dtClientes_com_venda_e_troca = new DataTable();
                    DataColumn col1 = new DataColumn();
                    col1.ColumnName = "cnpj";
                    dtClientes_com_venda_e_troca.Columns.Add(col1);

                    foreach (DataRow dr in dtSelect.Rows)
                    {
                        double valor_trocas = 0;
                        // try
                        //{
                        foreach (DataRow dr_troca in dtSelect1.Select("cnpj = '" + dr[2].ToString() + "'"))
                        {
                            try
                            {
                                valor_trocas = valor_trocas + Convert.ToDouble(dr_troca[1].ToString());
                                dtClientes_com_venda_e_troca.Rows.Add(dr_troca["cnpj"].ToString());
                            }
                            catch { }
                        }
                        double custo = 0;
                        try
                        {
                            custo = Convert.ToDouble(dr[5].ToString());
                        }
                        catch { }
                        bool incluir = true;
                        if (cbApenas_troca.Checked)
                        {
                            if (valor_trocas == 0)
                                incluir = false;
                        }
                        if (incluir)
                        {
                            try
                            {
                                cli.VendedorxClientesxProdutos.AddVendedorxClientesxProdutosRow(Convert.ToDouble(dr[0].ToString()), Convert.ToInt32(dr[1].ToString()),
                                    dr[2].ToString(), dr[3].ToString(), Convert.ToDouble(dr[4].ToString()), custo, valor_trocas, 0, 0, 0, 0, 0);
                            }
                            catch { }
                        }
                    }
                    foreach (DataRow dr_troca in dtSelect1.Rows)
                    {
                        bool ja_entrou = false;
                        foreach (DataRow dr_vendas_e_trocas in dtClientes_com_venda_e_troca.Select("cnpj = '" + dr_troca["cnpj"].ToString() + "'"))
                        {
                            ja_entrou = true;
                        }
                        if (!ja_entrou)
                        {
                            double valor_trocas = 0;
                            try
                            {
                                valor_trocas = valor_trocas + Convert.ToDouble(dr_troca["VALOR"].ToString());
                                try
                                {
                                    cli.VendedorxClientesxProdutos.AddVendedorxClientesxProdutosRow(0, 0,
                                        dr_troca["cnpj"].ToString(), "", 0.00001, 0.00001, valor_trocas, 0.00001, 0, 0, 0, 0);
                                }
                                catch { }
                            }
                            catch { }
                        }
                    }




                    FbCommand select_clientes = new FbCommand();
                    select_clientes.CommandText =
                        "SELECT * from clientes";
                    select_clientes.Connection = fbConnection1;
                    fbConnection1.Open();
                    FbDataAdapter datSelect_clientes = new FbDataAdapter();
                    datSelect_clientes.SelectCommand = select_clientes;
                    datSelect_clientes.Fill(cli.CLIENTES);
                    fbConnection1.Close();

                    cli.Dados.AddDadosRow(tb_nome_fornecedor.Text, Convert.ToDateTime(dtInicial.Text), Convert.ToDateTime(dtFinal.Text),
                        tb_nome_vendedor.Text, "", "",0);


                    crClientesxtroca cr = new crClientesxtroca();
                    cr.SetDataSource(cli);
                    form_imprimir imprime = new form_imprimir(cr);
                    imprime.Show();
                }
                catch (Exception a)
                {
                    fbConnection1.Close();
                    MessageBox.Show(a.ToString());
                }
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            try
            {
                string fechados = "", faturados =  "";
                string tipo =  "";

                string data =  "";
                string _vendedor = "", _fornecedor = "", _cliente = "", _cliente_ent =  "";
                if (tb_nome_vendedor.Text != "")
                    _vendedor = " AND ped.VENDEDOR_PED_VENDA = '" + tb_nome_vendedor.Text + "' ";

                if (tb_nome_fornecedor.Text != "")
                    _fornecedor = " AND prod.NOME_FORNECEDOR_PRODUTO = '" + tb_nome_fornecedor.Text + "' ";

                if (tb_nome_cliente.Text != "")
                {
                    _cliente = " AND nf.CNPJ_CLIENTE_FORN = '" + tb_cnpj.Text + "' ";
                    _cliente_ent = " AND nfe.CNPJ_CLIENTE_FORN_ENT = '" + tb_cnpj.Text + "' ";
                }


                string _cfop = " and (item.cfop_item like '_1__'	" +
                  "	or item.cfop_item like '_4__') ";
                if (cbCfop.Checked)
                {
                    _cfop = "  and (item.cfop_item = '" + tb_n_cfop.Text + "'	" +
                    "	or item.cfop_item = '6" + tb_n_cfop.Text.Substring(1, 3) + "' ) ";
                }
                /*

                string _cfop =  "";
                if (cbCfop.Checked)
                {
                    _cfop = "  and (item.cfop_item = '" + tb_n_cfop.Text + "'	" +
                    "	or item.cfop_item = '6" + tb_n_cfop.Text.Substring(1, 3) + "' ) ";
                }
              
                */

                // buscando valor total
                double valor_total = 0;
                FbCommand select2 = new FbCommand();
                select2.Connection = fbConnection1;
                fbConnection1.Open();
                select2.CommandText =
                                "select sum(item.PRECO_TOTAL_ITEM) from itens_nota item " +
                    "inner join produtos prod on prod.cod_fornecedor_produto = item.cod_item " +
                    "INNER JOIN nota_fiscal nf ON ITEM.NF_ITEM = NF.N_NF " +
                    "INNER JOIN PEDIDOS_NF ped_nf on nf.n_nf = ped_nf.nf_pedido_nf " +
                    "inner join pedidos_venda ped on ped.cod_ped_venda = ped_nf.n_pedido_nf " +
                    "where " +
                    "nf.STATUS_NFE LIKE ('%Autorizada%') AND " +
                    "nf.data_emissao_nf >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") +
                    "' and nf.data_emissao_nf <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                    _vendedor + _fornecedor + _cliente +
                    _cfop;
                //  " AND ((ped.BONIFICACAO_PED_VENDA = '0' or ped.BONIFICACAO_PED_VENDA is null) and " +
                //            "(ped.TROCA_PED_VENDA = '0' or ped.TROCA_PED_VENDA is null))";
                //"SELECT SUM(VALOR_TOTAL_PROD_ITEM_VENDA) FROM ITENS_PEDIDO_VENDA ipv INNER JOIN " +
                //"PEDIDOS_VENDA pv ON ipv.COD_PEDIDO_ITEM_VENDA = pv.COD_PED_VENDA " +
                //"WHERE 0 = 0 AND ((pv.BONIFICACAO_PED_VENDA = '0' or pv.BONIFICACAO_PED_VENDA is null) and " +
                //        "(pv.TROCA_PED_VENDA = '0' or pv.TROCA_PED_VENDA is null))" +
                //        fechados + faturados + data + tipo + cliente + vendedor + cnpj_cliente;
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
                    "select sum(item.PRECO_TOTAL_ITEM) from itens_nota item " +
                    "inner join produtos prod on prod.cod_fornecedor_produto = item.cod_item " +
                    "INNER JOIN nota_fiscal nf ON ITEM.NF_ITEM = NF.N_NF " +
                    "INNER JOIN PEDIDOS_NF ped_nf on nf.n_nf = ped_nf.nf_pedido_nf " +
                    "inner join pedidos_venda ped on ped.cod_ped_venda = ped_nf.n_pedido_nf " +
                    "where " +
                    "nf.STATUS_NFE LIKE ('%Autorizada%') AND " +
                    "nf.data_emissao_nf >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") +
                    "' and nf.data_emissao_nf <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                    _vendedor + _fornecedor + _cliente +
                    //_cfop +
                    //" AND ped.BONIFICACAO_PED_VENDA = '1' " +
                    " and item.cfop_item like '_910'	" +

                    "group by nf.N_NF, nf.DATA_EMISSAO_NF, nf.CLIENTE_FORN_NF";
                //"SELECT SUM(VALOR_TOTAL_PROD_ITEM_VENDA) FROM ITENS_PEDIDO_VENDA ipv INNER JOIN " +
                //"PEDIDOS_VENDA pv ON ipv.COD_PEDIDO_ITEM_VENDA = pv.COD_PED_VENDA " +
                //"inner join PRODUTOS prod ON ipv.COD_SISTEMA_PROD_ITEM_VENDA = prod.COD_PRODUTO " +
                //"WHERE 0 = 0 AND prod.NOME_FAMILIA_PRODUTO LIKE '%LEITE%' " +
                //        fechados + faturados + data + tipo + cliente + vendedor + cnpj_cliente;
                FbDataAdapter datSelect4 = new FbDataAdapter();
                datSelect4.SelectCommand = select4;
                DataTable dtSelect4 = new DataTable();
                datSelect4.Fill(dtSelect4);
                fbConnection1.Close();
                foreach (DataRow dr4 in dtSelect4.Rows)
                {
                    try
                    {
                        valor_leite += Convert.ToDouble(dr4[0].ToString());
                    }
                    catch { }
                }


                //buscando valor troca
                double valor_troca = 0;
                FbCommand select3 = new FbCommand();
                select3.Connection = fbConnection1;
                fbConnection1.Open();
                select3.CommandText =
                              "select sum(item.PRECO_TOTAL_ITEM) from itens_nota item " +
                    "inner join produtos prod on prod.cod_fornecedor_produto = item.cod_item " +
                    "INNER JOIN nota_fiscal nf ON ITEM.NF_ITEM = NF.N_NF " +
                    "INNER JOIN PEDIDOS_NF ped_nf on nf.n_nf = ped_nf.nf_pedido_nf " +
                    "inner join pedidos_venda ped on ped.cod_ped_venda = ped_nf.n_pedido_nf " +
                    "where " +
                    "nf.STATUS_NFE LIKE ('%Autorizada%') AND " +
                    "nf.data_emissao_nf >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") +
                    "' and nf.data_emissao_nf <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                    _vendedor + _fornecedor + _cliente +
                     " and item.cfop_item like '_949'	";
                //_cfop +
                //" AND ped.TROCA_PED_VENDA = '1' ";

                //"SELECT SUM(VALOR_TOTAL_PROD_ITEM_VENDA) FROM ITENS_PEDIDO_VENDA ipv INNER JOIN " +
                //"PEDIDOS_VENDA pv ON ipv.COD_PEDIDO_ITEM_VENDA = pv.COD_PED_VENDA " +
                //"WHERE 0 = 0 AND TROCA_PED_VENDA = '1' " +
                //        fechados + faturados + data + tipo + cliente + vendedor + cnpj_cliente;
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

                FbCommand sel9 = new FbCommand();
                FbDataAdapter datSel9 = new FbDataAdapter();
                DataTable dt9 = new DataTable();
                sel9.Connection = fbConnection1;
                sel9.CommandText =
                    "select sum(ent.preco_total_item_ent) from itens_nota_ent ent inner join " +
                    "nota_fiscal_ent nfe on ent.nf_item_ent = nfe.n_nf_ent where (ent.cfop_item_ent = '5202' or " +
                    "ent.cfop_item_ent = '6202' or ent.cfop_item_ent = '5411' or ent.cfop_item_ent = '6411') " +
                    "AND nfe.data_emissao_nf_ent >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") + "' " +
                    "and nfe.data_emissao_nf_ent <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                    "and nfe.baixada_nf_ent = 1 " + _cliente_ent +
                    "group by nfe.n_nf_ent, nfe.data_emissao_nf_ent, nfe.cliente_forn_nf_ent";
                datSel9.SelectCommand = sel9;
                fbConnection1.Open();
                datSel9.Fill(dt9);
                fbConnection1.Close();
                foreach (DataRow dr9 in dt9.Rows)
                {
                    try
                    {
                        valor_troca += Convert.ToDouble(dr9[0].ToString());
                    }
                    catch { }
                }

                //porc troca
                double porc_troca = (valor_troca / valor_total) * 100;


                FbCommand select = new FbCommand();
                select.CommandText =
                    //"select sum(item.qtde_item), prod.COD_PRODUTO, '', ped.VENDEDOR_PED_VENDA, sum(item.PRECO_TOTAL_ITEM) 
                    "select nf.N_NF, nf.DATA_EMISSAO_NF, nf.CLIENTE_FORN_NF, sum(item.PRECO_TOTAL_ITEM), ped.VENDEDOR_PED_VENDA, " +
                    "sum(item.CUSTO_ITEM), ped.TROCA_PED_VENDA from itens_nota item " +
                    "inner join produtos prod on prod.cod_fornecedor_produto = item.cod_item " +
                    "INNER JOIN nota_fiscal nf ON ITEM.NF_ITEM = NF.N_NF " +
                    "INNER JOIN PEDIDOS_NF ped_nf on nf.n_nf = ped_nf.nf_pedido_nf " +
                    "inner join pedidos_venda ped on ped.cod_ped_venda = ped_nf.n_pedido_nf " +
                    "where " +
                    "nf.STATUS_NFE LIKE ('%Autorizada%') AND " +
                    "nf.data_emissao_nf >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") +
                    "' and nf.data_emissao_nf <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                    _vendedor + _fornecedor + _cliente +
                    //_cfop +
                    " AND (ped.BONIFICACAO_PED_VENDA = '0' or ped.BONIFICACAO_PED_VENDA is null) " +
                    "group by nf.N_NF, nf.DATA_EMISSAO_NF, nf.CLIENTE_FORN_NF, ped.VENDEDOR_PED_VENDA, " +
                    " ped.TROCA_PED_VENDA " +
                    "union " + //PESQUISANDO AS NOTAS DE TROCA INSERIDAS PELA NF ENTRADA
                    "select nfe.n_nf_ent, nfe.data_emissao_nf_ent, nfe.cliente_forn_nf_ent, " +
                    "sum(ent.preco_total_item_ent), 'NF DE TROCA',0, 1 from itens_nota_ent ent inner join " +
                    "nota_fiscal_ent nfe on ent.nf_item_ent = nfe.n_nf_ent where (ent.cfop_item_ent = '5202' or " +
                    "ent.cfop_item_ent = '6202' or ent.cfop_item_ent = '5411' or ent.cfop_item_ent = '6411') " +
                    "AND nfe.data_emissao_nf_ent >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") + "' " +
                    "and nfe.data_emissao_nf_ent <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                    "and nfe.baixada_nf_ent = 1 " + _cliente_ent +
                    "group by nfe.n_nf_ent, nfe.data_emissao_nf_ent, nfe.cliente_forn_nf_ent " +
                    "union " +//PESQUISANDO AS NOTAS DE BONIFICAÇÃO
                    "select nf.N_NF, nf.DATA_EMISSAO_NF, nf.CLIENTE_FORN_NF, sum(item.PRECO_TOTAL_ITEM), 'NF DE BONIFICAÇÃO', " +
                    "0, 1 from itens_nota item " +
                    "inner join produtos prod on prod.cod_fornecedor_produto = item.cod_item " +
                    "INNER JOIN nota_fiscal nf ON ITEM.NF_ITEM = NF.N_NF " +
                    "INNER JOIN PEDIDOS_NF ped_nf on nf.n_nf = ped_nf.nf_pedido_nf " +
                    "inner join pedidos_venda ped on ped.cod_ped_venda = ped_nf.n_pedido_nf " +
                    "where " +
                    "nf.STATUS_NFE LIKE ('%Autorizada%') AND " +
                    "nf.data_emissao_nf >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") +
                    "' and nf.data_emissao_nf <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                    _vendedor + _fornecedor + _cliente +
                    //_cfop +
                    " AND ped.BONIFICACAO_PED_VENDA = '1' " +
                    "group by nf.N_NF, nf.DATA_EMISSAO_NF, nf.CLIENTE_FORN_NF";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();

                /*
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
                */
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

                    double valor_venda = 0, valor_custo = 0, perc_lucro = 0, valor_lucro_liquido = 0, perc_lucro_bruto = 0, valor_lucro_bruto = 0;

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
                ped.Totais_Lucrativiade.AddTotais_LucrativiadeRow(valor_total, valor_troca, valor_leite, Convert.ToDateTime(dtInicial.Text), Convert.ToDateTime(dtFinal.Text), media, "NF");

                crLucratividade_pedidos novo_ped = new crLucratividade_pedidos();
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

        private void button28_Click_1(object sender, EventArgs e)
        {

        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (tb_cod_vendedor.Text == "")
                MessageBox.Show("Esse relatório só funciona se um vendedor for selecionado");
            else
            {
            if (tb_cod_cliente.Text != "" ||
                tb_cod_fornecedor.Text != "" ||
                tb_cod_produto.Text != "" ||
                tbCodFamilia.Text != "" || tbGrupo.Text != "")
                MessageBox.Show("Essa pesquisa não atende filtro de Clientes, Fornecedores, Produtos e Famílias");
            List<string> produtosSemComissao = new List<string>();
            if (verificar_se_existem_produtos_sem_lancamento_de_comissao(tb_cod_vendedor.Text, out produtosSemComissao))
            {
                string produtos =  "";
                foreach (var i in produtosSemComissao)
                {
                    produtos += i.ToString() + "\n";
                }

                MessageBox.Show("Existem produtos que não contém cadastro de comissão para esse vendedor. \n" + produtos);
            }
            
                try
                {
                    FbCommand select = new FbCommand();
                    select.Connection = fbConnection1;
                    select.CommandText =
                        @"select sum(inf.preco_total_item) AS VALOR_VENDA, cpv.porc_comissao_cpv as comissao,
cr.nf_cr AS NF, nf.cliente_forn_nf AS CLIENTE,
nf.data_emissao_nf as Data_NF,
cr.data_prevista_cr as Data_Pgto
 from itens_nota inf
  inner join  nota_fiscal nf  on inf.nf_item = nf.n_nf
 inner join pedidos_nf pnf on nf.n_nf = pnf.nf_pedido_nf
 inner join pedidos_venda pv on pnf.n_pedido_nf = pv.cod_ped_venda
 inner join produtos p on cast(inf.cod_item as varchar(100)) =
    cast(p.cod_produto as varchar(100))

 inner join comissao_produto_vendedor cpv on
        p.cod_produto = cpv.cod_produto_cpv and
        pv.cod_vendedor_ped_venda = cpv.cod_vendedor_cpv
inner join contas_a_receber cr on nf.n_nf = cr.nf_cr
where cr.data_prevista_cr >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") + @"'
and cr.data_prevista_cr  <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + @"'
and (inf.cfop_item like '_1__' or inf.cfop_item like '_4__')
and nf.status_nfe like '%Autorizada%'
and cr.recebido_cr = 1 and pv.cod_vendedor_ped_venda = '" + tb_cod_vendedor.Text + @"'


group by cr.nf_cr, 2, nf.cliente_forn_nf,
nf.data_emissao_nf,
cr.data_prevista_cr 

 union

 select (sum(inf.preco_total_item) * -1) AS VALOR_VENDA, cpv.porc_comissao_cpv AS COMISSAO,
nf.n_nf AS NF, nf.cliente_forn_nf AS CLIENTE,
nf.data_emissao_nf AS DATA_NF,
nf.data_emissao_nf AS DATA_PGTO
 from itens_nota inf
  inner join  nota_fiscal nf  on inf.nf_item = nf.n_nf
 inner join pedidos_nf pnf on nf.n_nf = pnf.nf_pedido_nf
 inner join pedidos_venda pv on pnf.n_pedido_nf = pv.cod_ped_venda
 inner join produtos p on cast(inf.cod_item as varchar(100)) =
    cast(p.cod_produto as varchar(100))

 inner join comissao_produto_vendedor cpv on
        p.cod_produto = cpv.cod_produto_cpv and
        pv.cod_vendedor_ped_venda = cpv.cod_vendedor_cpv

where nf.data_emissao_nf >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") + @"'
and nf.data_emissao_nf <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + @"'
and (inf.cfop_item like '_9__')
and nf.status_nfe like '%Autorizada%'
and pv.cod_vendedor_ped_venda = '" + tb_cod_vendedor.Text + @"'

group by nf.N_NF, nf.cliente_forn_nf,
nf.data_emissao_nf, cpv.porc_comissao_cpv



";
                    fbConnection1.Open();
                    DataTable dtSelect = new DataTable();

                    FbDataAdapter datSelect = new FbDataAdapter();
                    datSelect.SelectCommand = select;
                    datSelect.Fill(dtSelect);
                    fbConnection1.Close();
                    dsComissao comissao = new dsComissao();
                    foreach (DataRow dr in dtSelect.Rows)
                    {
                        comissao.ComissaoPagamento.AddComissaoPagamentoRow(Convert.ToInt32(dr["NF"].ToString()), dr["CLIENTE"].ToString(), Convert.ToDateTime(dr["DATA_NF"].ToString()),
                            Convert.ToDouble(dr["VALOR_VENDA"].ToString()), Convert.ToDouble(dr["COMISSAO"].ToString()),
                             Convert.ToDouble(dr["VALOR_VENDA"].ToString()) * Convert.ToDouble(dr["COMISSAO"].ToString()) / 100,
                             Convert.ToDateTime(dr["DATA_PGTO"].ToString()));
                    }
                    comissao.Informações.AddInformaçõesRow(tb_nome_vendedor.Text, Convert.ToDateTime(dtInicial.Text), Convert.ToDateTime(dtFinal.Text));

                    crComissaoPgto crCom = new crComissaoPgto();
                    crCom.SetDataSource(comissao);
                    form_imprimir imp = new form_imprimir(crCom);
                    imp.Show();



                }
                catch (Exception ex)
                {
                    fbConnection1.Close();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private bool verificar_se_existem_produtos_sem_lancamento_de_comissao(string cod_vendedor, out List<String> produtos)
        {
            produtos = new List<string>();
            try
            {
                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT p.COD_PRODUTO, p.DESCRICAO_PRODUTO FROM PRODUTOS p";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);

                FbCommand selectComissao = new FbCommand();
                selectComissao.CommandText =
                    "SELECT * FROM COMISSAO_PRODUTO_VENDEDOR";
                selectComissao.Connection = fbConnection1;
               // fbConnection1.Open();
                FbDataAdapter datSelectComissao = new FbDataAdapter();
                datSelectComissao.SelectCommand = selectComissao;
                DataTable dtSelectComissao = new DataTable();
                datSelectComissao.Fill(dtSelectComissao);
                fbConnection1.Close();
                bool existeAlgum = false;
                foreach (DataRow dr in dtSelect.Rows)
                {
                    bool existe = false;
                    foreach (DataRow drC in dtSelectComissao.Select("COD_VENDEDOR_CPV = '" + cod_vendedor + "' and " + 
                        "COD_PRODUTO_CPV = '" + dr["COD_PRODUTO"].ToString() + "'"))
                    {
                        existe = true;
                    }
                    if (!existe)
                    {
                        produtos.Add(dr[0].ToString() + " - " + dr[1].ToString());
                        existeAlgum = true;
                    }
                }
                return existeAlgum;
            }
            catch(Exception ex)
            {
                fbConnection1.Close();
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            try
            {
                string _vendedor = "", _fornecedor = "", _cliente = "", _familia =  "";

                if (tbGrupo.Text != "")
                    _familia = " AND prod.DESCRICAO_GRUPO_PRODUTO = '" + tbGrupo.Text + "' ";
                if (tbdescricaoSubgrupo.Text != "")
                    _familia = " AND prod.DESCRICAO_SUB_GRUPO_PRODUTO = '" + tbdescricaoSubgrupo.Text + "' ";
                if (tb_nome_produto.Text != "")
                    _familia = " AND prod.COD_PRODUTO = '" + tb_cod_produto.Text + "' ";

                if (tb_nome_vendedor.Text != "")
                    _vendedor = " AND ped.VENDEDOR_PED_VENDA = '" + tb_nome_vendedor.Text + "' ";

                if (tb_nome_fornecedor.Text != "")
                    _fornecedor = " AND prod.NOME_FORNECEDOR_PRODUTO = '" + tb_nome_fornecedor.Text + "' ";

                if (tb_nome_cliente.Text != "")
                    _cliente = " AND nf.CNPJ_CLIENTE_FORN = '" + tb_cnpj.Text + "' ";

                if (tb_cod_matriz.Text != "")
                    _cliente = " AND c.COD_MATRIZ_CLIENTE = '" + tb_cod_matriz.Text + "' ";

                string _cfop = " and (item.cfop_item like '_1__'	" +
                    "	or item.cfop_item like '_4__') ";
                if (cbCfop.Checked)
                {
                    _cfop = "  and (item.cfop_item = '" + tb_n_cfop.Text + "'	" +
                    "	or item.cfop_item = '6" + tb_n_cfop.Text.Substring(1, 3) + "' ) ";
                }
                string dataIni = Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".");
                string dataFim = Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".");
                dsClientesxproduto cli = new dsClientesxproduto();
                FbCommand select = new FbCommand();
                select.CommandText =
                    "select sum(item.qtde_item), prod.COD_PRODUTO, nf.N_NF, ped.VENDEDOR_PED_VENDA, case   when sum(item.VALOR_FRETE_ITEM)  > 0 then (sum(item.VALOR_FRETE_ITEM) + sum(item.PRECO_TOTAL_ITEM)) else sum(item.PRECO_TOTAL_ITEM) end as SOMA, sum(item.CUSTO_ITEM) from itens_nota item " +
                    "inner join produtos prod on CAST(prod.cod_produto AS VARCHAR(50)) = CAST(item.cod_item AS VARCHAR(50)) " +
                    "INNER JOIN nota_fiscal nf ON ITEM.NF_ITEM = NF.N_NF " +
                    "INNER JOIN PEDIDOS_NF ped_nf on nf.n_nf = ped_nf.nf_pedido_nf " +
                    "inner join pedidos_venda ped on ped.cod_ped_venda = ped_nf.n_pedido_nf " +
                    "inner join vendedores v on ped.COD_VENDEDOR_PED_VENDA = v.COD_VENDEDOR " +
                     "inner join clientes c on nf.CNPJ_CLIENTE_FORN = c.CNPJ " + 
                    "where " +
                    "nf.STATUS_NFE LIKE ('%Autorizada%') " +
                     _cfop +
                    " AND nf.data_emissao_nf >= '" + dataIni +
                    "' and nf.data_emissao_nf <= '" + dataFim + "' " +
                    _vendedor + _fornecedor + _cliente + _familia + supervisor + 
                    "group by ped.VENDEDOR_PED_VENDA, nf.N_NF, prod.COD_PRODUTO ";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    double custo = 0;
                    //double troca = buscar_trocas(dr[1].ToString(), _cfop, dataIni,dataFim, _vendedor, _fornecedor, dr[2].ToString());
                    double trocas = 0;
                    double valor_trocas = 0;

                    //FbCommand select = new FbCommand();
                    //select.CommandText =
                    //    "select sum(item.qtde_item), prod.COD_PRODUTO, nf.CNPJ_CLIENTE_FORN, ped.VENDEDOR_PED_VENDA, case   when sum(item.VALOR_FRETE_ITEM)  > 0 then (sum(item.VALOR_FRETE_ITEM) + sum(item.PRECO_TOTAL_ITEM)) else sum(item.PRECO_TOTAL_ITEM) end as SOMA, sum(item.CUSTO_ITEM) from itens_nota item " +
                    //    "inner join produtos prod on prod.cod_produto = item.cod_item " +
                    //    "INNER JOIN nota_fiscal nf ON ITEM.NF_ITEM = NF.N_NF " +
                    //    "INNER JOIN PEDIDOS_NF ped_nf on nf.n_nf = ped_nf.nf_pedido_nf " +
                    //    "inner join pedidos_venda ped on ped.cod_ped_venda = ped_nf.n_pedido_nf " +
                    //    "where " +
                    //    "nf.STATUS_NFE LIKE ('%Autorizada%') " + 
                    //     _cfop +
                    //    " AND nf.data_emissao_nf >= '" + dataIni + 
                    //    "' and nf.data_emissao_nf <= '" + dataFim + "' " +
                    //    _vendedor + _fornecedor + _cliente +
                    //    "group by ped.VENDEDOR_PED_VENDA, nf.CNPJ_CLIENTE_FORN, prod.COD_PRODUTO ";
                    //select.Connection = fbConnection1;
                    //fbConnection1.Open();
                    //FbDataAdapter datSelect = new FbDataAdapter();
                    //datSelect.SelectCommand = select;
                    //DataTable dtSelect = new DataTable();
                    //datSelect.Fill(dtSelect);
                    //fbConnection1.Close(); 

                    try
                    {
                        //buscando valor_troca
                        FbCommand select_troca = new FbCommand();
                        select_troca.CommandText =
                        "select sum(item.qtde_item), case   when sum(item.VALOR_FRETE_ITEM)  > 0 then (sum(item.VALOR_FRETE_ITEM) + sum(item.PRECO_TOTAL_ITEM)) else sum(item.PRECO_TOTAL_ITEM) end as SOMA from itens_nota item " +
                      "inner join produtos prod on CAST(prod.cod_produto AS VARCHAR(50)) = CAST(item.cod_item AS VARCHAR(50)) " +
                      "INNER JOIN nota_fiscal nf ON ITEM.NF_ITEM = NF.N_NF " +
                      "INNER JOIN PEDIDOS_NF ped_nf on nf.n_nf = ped_nf.nf_pedido_nf " +
                      "inner join pedidos_venda ped on ped.cod_ped_venda = ped_nf.n_pedido_nf " +
                      "inner join vendedores v on ped.COD_VENDEDOR_PED_VENDA = v.COD_VENDEDOR " + 
                      "where prod.cod_produto = " + dr[1].ToString() + supervisor +
                      " and nf.STATUS_NFE LIKE ('%Autorizada%') AND " +
                      "nf.data_emissao_nf >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") +
                      "' and nf.data_emissao_nf <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                      " AND ped.TROCA_PED_VENDA = '1' and nf.CNPJ_CLIENTE_FORN = '" + dr[2].ToString() + "' " +
                      "union " + //PESQUISANDO AS NOTAS DE TROCA INSERIDAS PELA NF ENTRADA
                    "select sum(ent.qtde_item_ent), sum(ent.preco_total_item_ent) from itens_nota_ent ent inner join " +
                    "nota_fiscal_ent nfe on ent.nf_item_ent = nfe.n_nf_ent " +
                    "inner join produtos prod on prod.cod_barras_produto = ent.cod_ean_item_ent " +
                     "inner join clientes cl on nfe.CNPJ_CLIENTE_FORN_ENT = cl.CNPJ " +
                    "inner join vendedores_cliente vcl on cl.cod_cliente = vcl.cod_cliente_vc " +
                    "inner join vendedores v on vcl.COD_VENDEDOR_VC = V.COD_VENDEDOR " +
                    "where (ent.cfop_item_ent = '5202' or " +
                    "ent.cfop_item_ent = '6202' or ent.cfop_item_ent = '5411' or ent.cfop_item_ent = '6411') " +
                    "and prod.cod_produto = " + dr[1].ToString() + supervisor +
                    " AND nfe.data_emissao_nf_ent >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") + "' " +
                    "and nfe.data_emissao_nf_ent <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                    "and nfe.baixada_nf_ent = 1 " +
                    "and nfe.CNPJ_CLIENTE_FORN_ENT = '" + dr[2].ToString() + "'";

                        select_troca.Connection = fbConnection1;
                        fbConnection1.Open();
                        FbDataAdapter datSelect_troca = new FbDataAdapter();
                        datSelect_troca.SelectCommand = select_troca;
                        DataTable dtSelect_troca = new DataTable();
                        datSelect_troca.Fill(dtSelect_troca);
                        fbConnection1.Close();

                        foreach (DataRow dr_troca in dtSelect_troca.Rows)
                        {
                            try
                            {
                                trocas = Convert.ToDouble(dr_troca[0].ToString());
                                valor_trocas = Convert.ToDouble(dr_troca[1].ToString());
                            }
                            catch { }
                        }
                    }
                    catch (Exception a)
                    {
                        fbConnection1.Close();
                    }
                    try
                    {
                        custo = Convert.ToDouble(dr[5].ToString());
                    }
                    catch { }
                    try
                    {
                        cli.VendedorxClientesxProdutos.AddVendedorxClientesxProdutosRow(Convert.ToDouble(dr[0].ToString()), Convert.ToInt32(dr[1].ToString()),
                            dr[2].ToString(), dr[3].ToString(), Convert.ToDouble(dr[4].ToString()) / Convert.ToDouble(dr[0].ToString()), custo, trocas, valor_trocas, 
                            0, 0, 0, 0);
                    }
                    catch { }
                }

                FbCommand select_clientes = new FbCommand();
                select_clientes.CommandText =
                    "SELECT * from clientes";
                select_clientes.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect_clientes = new FbDataAdapter();
                datSelect_clientes.SelectCommand = select_clientes;
                datSelect_clientes.Fill(cli.CLIENTES);
                fbConnection1.Close();

                FbCommand select_produtos = new FbCommand();
                select_produtos.CommandText =
                    "SELECT * from produtos";
                select_produtos.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect_produtos = new FbDataAdapter();
                datSelect_produtos.SelectCommand = select_produtos;
                datSelect_produtos.Fill(cli.PRODUTOS);
                fbConnection1.Close();


                cli.Dados.AddDadosRow(tb_nome_fornecedor.Text, Convert.ToDateTime(dtInicial.Text), Convert.ToDateTime(dtFinal.Text),
                    tb_nome_vendedor.Text, "", "",0);


                crVendedorxNFSxProdutos cr = new crVendedorxNFSxProdutos();
                cr.SetDataSource(cli);
                form_imprimir imprime = new form_imprimir(cr);
                imprime.Show();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            try
            {

                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                        "SELECT CNPJ, RAZAO_SOCIAL FROM CLIENTES";
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();

                string _vendedor = "", _fornecedor =  "", _cliente = "";
                if (tb_nome_vendedor.Text != "")
                    _vendedor = " AND ped.VENDEDOR_PED_VENDA = '" + tb_nome_vendedor.Text + "' ";

                if (tb_nome_fornecedor.Text != "")
                    _fornecedor = " AND prod.NOME_FORNECEDOR_PRODUTO = '" + tb_nome_fornecedor.Text + "' ";

                if (tb_nome_cliente.Text != "")
                    _cliente = " AND ped.CLIENTE_PED_VENDA = '" + tb_nome_cliente.Text + "' ";
                if (tb_cod_matriz.Text != "")
                    _cliente = " AND c.COD_MATRIZ_CLIENTE = '" + tb_cod_matriz.Text + "' ";

                FbCommand select1 = new FbCommand();
                select1.Connection = fbConnection1;
                fbConnection1.Open();
                select1.CommandText =
                        "SELECT nf.CNPJ_CLIENTE_FORN, nf.N_NF, nf.DATA_EMISSAO_NF, sum(item.PRECO_TOTAL_ITEM), V.NOME_VENDEDOR FROM NOTA_FISCAL nf " +
                        "inner join itens_nota item on nf.n_nf = item.NF_ITEM " +
                        "inner join produtos prod on prod.cod_fornecedor_produto = item.cod_item " +
                        "INNER JOIN PEDIDOS_NF ped_nf on nf.n_nf = ped_nf.nf_pedido_nf " +
                        "inner join pedidos_venda ped on ped.cod_ped_venda = ped_nf.n_pedido_nf " +
                        "inner join vendedores v on ped.COD_VENDEDOR_PED_VENDA = v.COD_VENDEDOR " +
                         "inner join clientes c on nf.CNPJ_CLIENTE_FORN = c.CNPJ " + 
                        "WHERE nf.DATA_EMISSAO_NF >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") + "' AND " +
                        "nf.DATA_EMISSAO_NF <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                        _vendedor + supervisor + _fornecedor + _cliente +
                        "group by  nf.CNPJ_CLIENTE_FORN, nf.N_NF, nf.DATA_EMISSAO_NF, V.NOME_VENDEDOR ORDER BY DATA_EMISSAO_NF DESC";
                FbDataAdapter datSelectNf = new FbDataAdapter();
                datSelectNf.SelectCommand = select1;
                DataTable dtSelectNf = new DataTable();
                datSelectNf.Fill(dtSelectNf);
                fbConnection1.Close();

                dsClientesxVendas cl = new dsClientesxVendas();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    foreach (DataRow drNf in dtSelectNf.Select("CNPJ_CLIENTE_FORN = '" + dr[0].ToString() + "'"))
                    {
                        cl.ClientesxNF.AddClientesxNFRow(dr[0].ToString(), dr[1].ToString(),
                            Convert.ToInt32(drNf[1].ToString()), Convert.ToDateTime(drNf[2].ToString()),
                            Convert.ToDecimal(drNf[3].ToString()), drNf[4].ToString());
                        break;
                    }
                }
                //fileTransferDetail.Tables[0].DefaultView.Sort = "ID DESC";
                cl.ClientesxNF.DefaultView.Sort = "DATA DESC";
                cl.Informacoes.AddInformacoesRow(Convert.ToDateTime(dtInicial.Text), Convert.ToDateTime(dtFinal.Text), tb_nome_vendedor.Text);

                crUltimaVenda cr = new crUltimaVenda();
                cr.SetDataSource(cl);
                form_imprimir imprime = new form_imprimir(cr);
                imprime.Show();




            }
            catch (Exception a)
            {
                fbConnection1.Close();
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
              try
            {
                string _vendedor = "", _vendedor_cliente = "", _fornecedor =  "";

                if (tb_nome_vendedor.Text != "")
                {
                    _vendedor = " AND ped.VENDEDOR_PED_VENDA = '" + tb_nome_vendedor.Text + "' ";
                    _vendedor_cliente = " AND vc.COD_VENDEDOR_VC = '" + tb_cod_vendedor.Text + "' ";
                }

                if (tb_nome_fornecedor.Text != "")
                    _fornecedor = " AND prod.NOME_FORNECEDOR_PRODUTO = '" + tb_nome_fornecedor.Text + "' ";


                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                        "SELECT c.CNPJ, c.RAZAO_SOCIAL, vc.NOME_VENDEDOR_VC FROM CLIENTES c " +
                        "INNER JOIN VENDEDORES_CLIENTE vc on c.COD_CLIENTE = vc.COD_CLIENTE_VC " +
                        "inner join vendedores v on vc.COD_VENDEDOR_VC = v.COD_VENDEDOR " +
                        "where ATIVO_CLIENTE = 1 " + supervisor +
                         _vendedor_cliente;
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();

              

                FbCommand select1 = new FbCommand();
                select1.Connection = fbConnection1;
                fbConnection1.Open();
                select1.CommandText =
                        "SELECT nf.CNPJ_CLIENTE_FORN, nf.N_NF, nf.DATA_EMISSAO_NF, nf.VALOR_NOTA_NF FROM NOTA_FISCAL nf " +
                        "inner join itens_nota item on nf.n_nf = item.NF_ITEM " + 
                        "inner join produtos prod on prod.cod_fornecedor_produto = item.cod_item " +
                        "INNER JOIN PEDIDOS_NF ped_nf on nf.n_nf = ped_nf.nf_pedido_nf " +
                        "inner join pedidos_venda ped on ped.cod_ped_venda = ped_nf.n_pedido_nf " +
                        "inner join vendedores v on ped.COD_VENDEDOR_PED_VENDA = v.COD_VENDEDOR " + 
                        "WHERE nf.DATA_EMISSAO_NF >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/",".") + "' AND " +
                        "nf.DATA_EMISSAO_NF <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " + 
                        _vendedor + supervisor + _fornecedor + 
                        "ORDER BY DATA_EMISSAO_NF DESC";
                FbDataAdapter datSelectNf = new FbDataAdapter();
                datSelectNf.SelectCommand = select1;
                DataTable dtSelectNf = new DataTable();
                datSelectNf.Fill(dtSelectNf);
                fbConnection1.Close();

                dsClientesxVendas cl = new dsClientesxVendas();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    bool existe = false;
                    foreach(DataRow drNf in dtSelectNf.Select("CNPJ_CLIENTE_FORN = '" + dr[0].ToString() + "'"))
                    {
                        existe = true;
                    }
                    if (!existe)
                    {
                        cl.ClientesxNF.AddClientesxNFRow(dr[0].ToString(), dr[1].ToString(), 0, Convert.ToDateTime("01/01/2001"), 0, "");
                    }
                }
                //fileTransferDetail.Tables[0].DefaultView.Sort = "ID DESC";
                cl.ClientesxNF.DefaultView.Sort = "DATA DESC";
                cl.Informacoes.AddInformacoesRow(Convert.ToDateTime(dtInicial.Text), Convert.ToDateTime(dtFinal.Text), tb_nome_vendedor.Text);

                crClientesNaoAtendidos cr = new crClientesNaoAtendidos();
                cr.SetDataSource(cl);
                form_imprimir imprime = new form_imprimir(cr);
                imprime.Show();

                     


            }
            catch (Exception a)
            {
                fbConnection1.Close();
            }
        
        
        }

        private void button34_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbProduto.Checked)
                    MessageBox.Show("Não é possível selecionar o produto nessa pesquisa");
                else
                {
                    if (cb_Personalizada.Checked)
                    {


                        FbCommand sel = new FbCommand();
                        FbDataAdapter da = new FbDataAdapter();
                        sel.CommandText = buscar_string(tb_cod_pesquisa.Text);

                        string _vendedor = "%", _fornecedor = "%", _cliente = "%", _familia = "%";
                      
                        string _cfop_1 = "_1__", _cfop_4 = "_4__";

                        if (cbCfop.Checked)
                        {
                            _cfop_1 = tb_n_cfop.Text; _cfop_4 = tb_n_cfop.Text;
                        }
                        sel.Connection = fbConnection1;
                        sel.Parameters.AddWithValue("@DAT_I", Convert.ToDateTime(dtInicial.Text));
                        sel.Parameters.AddWithValue("@DAT_F", Convert.ToDateTime(dtFinal.Text));
                        sel.Parameters.AddWithValue("@familia", "%" + tbFamilia.Text + "%");
                        sel.Parameters.AddWithValue("@vendedor", "%" + tb_nome_vendedor.Text + "%");
                        sel.Parameters.AddWithValue("@cliente", "%" + tb_cnpj.Text + "%");
                        sel.Parameters.AddWithValue("@fornecedor", "%" + tb_nome_fornecedor.Text + "%");
                        sel.Parameters.AddWithValue("@_1", "" + _cfop_1 + "");
                        sel.Parameters.AddWithValue("@_4", "" + _cfop_4 + "");



                        DataTable dt = new DataTable();
                        da.SelectCommand = sel;
                        fbConnection1.Open();
                        da.Fill(dt);
                        fbConnection1.Close();
                        dt.TableName = tb_descricao_pesquisa.Text;
                        try
                        {
                           // dtEstoque.TableName = "ESTOQUE";
                            dt.WriteXml(@"c:\\evolucao\\" + tb_descricao_pesquisa.Text + ".xml");
                            System.Diagnostics.Process.Start("excel", @"c:\\evolucao\\" + tb_descricao_pesquisa.Text + ".xml");
                        }
                        catch(Exception ex)
                        { }
                        //dgvPedidos.DataSource = dt;
                       // gerarExcel(dt, @"c:\\evolucao\\excel\" + tb_descricao_pesquisa.Text + ".xlsx");
                       // System.Diagnostics.Process.Start(@"c:\\evolucao\\excel\" + tb_descricao_pesquisa.Text + ".xlsx");
                    }
                    else
                    {
                        MessageBox.Show("A opção personalizada tem que estar marcada");
                    }
                }

            }
            catch (Exception ex)
            {
                fbConnection1.Close();
                MessageBox.Show(ex.Message);
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
                        try
                        {
                            Convert.ToDouble(table.Rows[j].ItemArray[k].ToString());
                            _double = true;
                        }
                        catch {}
                        bool _data = false;
                        try
                        {
                            Convert.ToDateTime(table.Rows[j].ItemArray[k].ToString());
                            _data = true;
                        }
                        catch {}
                        if (_double)
                        {
                            excelWorkSheet.Cells[j + 2, k + 1] = Convert.ToDouble(table.Rows[j].ItemArray[k].ToString()).ToString("n2");
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

        private string buscar_string(string cod)
        {
             try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText = 
                        "SELECT STRING_PESQUISA FROM PESQUISAS WHERE COD_PESQUISA = '" + cod + "'";
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    return dr[0].ToString();
                }
                return  "";
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                return  "";
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            form_pesquisas p = new form_pesquisas();
            try
            {
                p.ShowDialog();
            }
            finally
            {
                tb_cod_pesquisa.Text = p.cod;
                tb_descricao_pesquisa.Text = p.descricao;
            }
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            form_grupo_produto grup = new form_grupo_produto();
            try
            {
                grup.busca = true;
                grup.ShowDialog();
            }
            finally
            {
                tbCodGrupo.Text = grup.cod;
                tbGrupo.Text = grup.descricao;
            }
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            try
            {
                string _vendedor = "", _fornecedor = "", _cliente = "", _cliente_ent = "", _familia =  "";

                if (tbGrupo.Text != "")
                    _familia = " AND prod.DESCRICAO_GRUPO_PRODUTO = '" + tbGrupo.Text + "' ";
                if (tbdescricaoSubgrupo.Text != "")
                    _familia = " AND prod.DESCRICAO_SUB_GRUPO_PRODUTO = '" + tbdescricaoSubgrupo.Text + "' ";
                if (tbdescricaoSubgrupo.Text != "")
                    _familia = " AND prod.DESCRICAO_SUB_GRUPO_PRODUTO = '" + tbdescricaoSubgrupo.Text + "' ";
                if (tb_nome_produto.Text != "")
                    _familia = " AND prod.COD_PRODUTO = '" + tb_cod_produto.Text + "' ";

                if (tbFamilia.Text != "")
                    _familia += " AND prod.NOME_FAMILIA_PRODUTO = '" + tbFamilia.Text + "'";

                if (tb_nome_vendedor.Text != "")
                    _vendedor = " AND ped.VENDEDOR_PED_VENDA = '" + tb_nome_vendedor.Text + "' ";

                if (tb_nome_fornecedor.Text != "")
                    _fornecedor = " AND prod.NOME_FORNECEDOR_PRODUTO = '" + tb_nome_fornecedor.Text + "' ";

                if (tb_nome_cliente.Text != "")
                {
                    _cliente = " AND nf.CNPJ_CLIENTE_FORN = '" + tb_cnpj.Text + "' ";
                    _cliente_ent = " AND nfe.CNPJ_CLIENTE_FORN_ENT = '" + tb_cnpj.Text + "' ";
                }
                if (tb_cod_matriz.Text != "")
                {
                    _cliente = " AND cl.COD_MATRIZ_CLIENTE = '" + tb_cod_matriz.Text + "' ";
                    _cliente_ent = " AND cl.COD_MATRIZ_CLIENTE = '" + tb_cod_matriz.Text + "' ";
                }

                string _cfop =  "";
                if (cbCfop.Checked)
                {
                    _cfop = "  and (inf.cfop_item = '" + tb_n_cfop.Text + "'	" +
                    "	or inf.cfop_item = '6" + tb_n_cfop.Text.Substring(1, 3) + "' ) ";
                }

                FbCommand select = new FbCommand();
                select.CommandText =
                    @"select pv.vendedor_ped_venda, prod.NOME_FORNECEDOR_PRODUTO as fornecedor, inf.cfop_item, sum(inf.preco_total_item) as valor_total, sum(inf.qtde_item) as qtde_total, 'S' as tipo from itens_nota inf
inner join nota_fiscal nf on inf.nf_item = nf.n_nf
inner join clientes cl on nf.cnpj_cliente_forn = cl.cnpj
inner join pedidos_nf pnf on nf.n_nf = pnf.nf_pedido_nf
inner join pedidos_venda pv on pnf.n_pedido_nf = pv.cod_ped_venda
inner join produtos prod on inf.cod_item = prod.cod_fornecedor_produto
inner join vendedores v on pv.COD_VENDEDOR_PED_VENDA = V.COD_VENDEDOR
where nf.STATUS_NFE LIKE ('%Autorizada%') AND " +
                    "nf.data_emissao_nf >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") +
                    @"' and nf.data_emissao_nf <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + @"' " +
                    _vendedor + _fornecedor + _cfop + _cliente + _familia + supervisor + @"
group by pv.vendedor_ped_venda,prod.NOME_FORNECEDOR_PRODUTO, inf.cfop_item " +
                    "union " + //PESQUISANDO AS NOTAS DE TROCA INSERIDAS PELA NF ENTRADA
                    "select vcl.nome_vendedor_vc as vendedor_ped_venda,  prod.NOME_FORNECEDOR_PRODUTO as fornecedor, ent.cfop_item_ent as cfop_item,  sum(ent.preco_total_item_ent), sum(ent.qtde_item_ent), 'E' as tipo from itens_nota_ent ent inner join " +
                    "nota_fiscal_ent nfe on ent.nf_item_ent = nfe.n_nf_ent " +
                    "inner join clientes cl on nfe.CNPJ_CLIENTE_FORN_ENT = cl.CNPJ " +
                    "inner join vendedores_cliente vcl on cl.cod_cliente = vcl.cod_cliente_vc " +
                    "inner join vendedores v on vcl.COD_VENDEDOR_VC = V.COD_VENDEDOR " +
                    "inner join produtos prod on ent.COD_EAN_ITEM_ENT = prod.COD_BARRAS_CAIXA_PRODUTO " + 
                    "where (ent.cfop_item_ent = '5202' or " +
                    "ent.cfop_item_ent = '6202' or ent.cfop_item_ent = '5411' or ent.cfop_item_ent = '6411') " +
                    "AND nfe.data_emissao_nf_ent >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") + "' " +
                    "and nfe.data_emissao_nf_ent <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                    _cliente_ent + supervisor +
                    "and nfe.baixada_nf_ent = 1 group by vcl.nome_vendedor_vc, prod.NOME_FORNECEDOR_PRODUTO, ENT.cfop_item_ent ";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();



                //CLIENTES ATIVOS
                select.CommandText =
                      @"select vcl.nome_vendedor_vc, count(distinct(cl.cnpj)) as clientes from clientes cl
                    inner join vendedores_cliente vcl on cl.cod_cliente = vcl.cod_cliente_vc
                    inner join vendedores v on vcl.COD_VENDEDOR_VC = V.COD_VENDEDOR 
                    where 0=0  " + supervisor + " group by vcl.nome_vendedor_vc";
                    //"SELECT DISTINCT(prod.CNPJ_FORNECEDOR_PRODUTO) as cnpj, prod.NOME_FORNECEDOR_PRODUTO as cidade, '0' as clientes FROM PRODUTOS";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect_cidades = new FbDataAdapter();
                datSelect_cidades.SelectCommand = select;
                DataTable dtSelect_cidades = new DataTable();
                datSelect_cidades.Fill(dtSelect_cidades);
                fbConnection1.Close();


                _cfop = " and (inf.cfop_item = '5102'	" +
                  "	or inf.cfop_item = '5405') ";
                //CLIENTES POSITIVADOS
                select.CommandText =
                    @"select pv.vendedor_ped_venda, prod.NOME_FORNECEDOR_PRODUTO as fornecedor, count(distinct(cl.cnpj)) as clientes from itens_nota inf
inner join nota_fiscal nf on inf.nf_item = nf.n_nf
inner join clientes cl on nf.cnpj_cliente_forn = cl.cnpj
inner join pedidos_nf pnf on nf.n_nf = pnf.nf_pedido_nf
inner join pedidos_venda pv on pnf.n_pedido_nf = pv.cod_ped_venda
inner join produtos prod on inf.cod_item = prod.cod_fornecedor_produto
inner join vendedores v on pv.COD_VENDEDOR_PED_VENDA = V.COD_VENDEDOR 
where nf.STATUS_NFE LIKE ('%Autorizada%') AND " +
                    "nf.data_emissao_nf >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") +
                    @"' and nf.data_emissao_nf <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + @"' " +
                    _vendedor + _fornecedor + _cfop + _cliente + _familia + supervisor + @"
group by pv.vendedor_ped_venda, prod.NOME_FORNECEDOR_PRODUTO";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect_positivados = new FbDataAdapter();
                datSelect_positivados.SelectCommand = select;
                DataTable dtSelect_positivados = new DataTable();
                datSelect_positivados.Fill(dtSelect_positivados);
                fbConnection1.Close();


                select.CommandText =
                    @"select distinct(pv.vendedor_ped_venda) as nome_vendedor_vc,prod.NOME_FORNECEDOR_PRODUTO as fornecedor from itens_nota inf
inner join nota_fiscal nf on inf.nf_item = nf.n_nf
inner join clientes cl on nf.cnpj_cliente_forn = cl.cnpj
inner join pedidos_nf pnf on nf.n_nf = pnf.nf_pedido_nf
inner join pedidos_venda pv on pnf.n_pedido_nf = pv.cod_ped_venda
inner join produtos prod on inf.cod_item = prod.cod_fornecedor_produto
inner join vendedores v on pv.COD_VENDEDOR_PED_VENDA = v.COD_VENDEDOR
where nf.STATUS_NFE LIKE ('%Autorizada%') AND " +
                    "nf.data_emissao_nf >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") +
                    @"' and nf.data_emissao_nf <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + @"' " +
                    _vendedor + _fornecedor + _cfop + _cliente + _familia + supervisor + @"
group by pv.vendedor_ped_venda, prod.NOME_FORNECEDOR_PRODUTO, inf.cfop_item ";

                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect_todos = new FbDataAdapter();
                datSelect_todos.SelectCommand = select;
                DataTable dtSelect_todos = new DataTable();
                datSelect_todos.Fill(dtSelect_todos);
                fbConnection1.Close();

                int clientes_totais_ativos = 0, contador = 0;
                dsClientesxproduto c = new dsClientesxproduto();
                foreach (DataRow dr_todos in dtSelect_todos.Rows)
                {
                    try
                    {
                        double valor_venda = 0, valor_troca = 0, qtde_venda = 0;
                        int clientes = 0;

                        foreach (DataRow dr_cidades in dtSelect_cidades.Select("nome_vendedor_vc = '" + dr_todos["nome_vendedor_vc"].ToString() + "' "))
                        {
                            try
                            {
                                clientes = Convert.ToInt32(dr_cidades["clientes"].ToString());

                                if (contador != clientes)
                                {
                                    clientes_totais_ativos += clientes;
                                    contador = clientes;
                                }
                            }
                            catch { }
                        }
                        int clientes_positivados = 0;
                        foreach (DataRow dr_positivados in dtSelect_positivados.Select("vendedor_ped_venda = '" + dr_todos["nome_vendedor_vc"].ToString() + "' AND " +
                            "fornecedor = '" + dr_todos["fornecedor"].ToString() + "'"))
                        {
                            clientes_positivados += Convert.ToInt32(dr_positivados["clientes"].ToString());
                        }


                        foreach (DataRow dr_valores in dtSelect.Select("vendedor_ped_venda = '" + dr_todos["nome_vendedor_vc"].ToString() + "' AND " +
                            "fornecedor = '" + dr_todos["fornecedor"].ToString() + "'"))
                        {
                            if (dr_valores["cfop_item"].ToString() == "5102" || dr_valores["cfop_item"].ToString() == "5405")
                            {
                                valor_venda += Convert.ToDouble(dr_valores["valor_total"].ToString());
                                qtde_venda += Convert.ToDouble(dr_valores["qtde_total"].ToString());
                            }
                            else
                            {
                                if (dr_valores["cfop_item"].ToString() == "5910" || dr_valores["cfop_item"].ToString() == "5949"
                                    || dr_valores["cfop_item"].ToString() == "6910" || dr_valores["cfop_item"].ToString() == "6949")
                                    valor_troca += Convert.ToDouble(dr_valores["valor_total"].ToString());
                                else
                                    if (dr_valores["cfop_item"].ToString() == "5202" || dr_valores["cfop_item"].ToString() == "6202" ||
                                        dr_valores["cfop_item"].ToString() == "5411" || dr_valores["cfop_item"].ToString() == "6411")
                                        valor_troca += Convert.ToDouble(dr_valores["valor_total"].ToString());
                            }
                        }

                        c.VendedorxCidadesxPositivacao.AddVendedorxCidadesxPositivacaoRow(dr_todos["nome_vendedor_vc"].ToString(),
                            dr_todos["fornecedor"].ToString(), clientes, clientes_positivados, qtde_venda, valor_venda, valor_troca);
                    }
                    catch (Exception a)
                    {
                        MessageBox.Show(a.ToString());
                    }
                }
                c.Dados.AddDadosRow(tb_nome_fornecedor.Text, Convert.ToDateTime(dtInicial.Text), Convert.ToDateTime(dtFinal.Text),
                  tb_nome_vendedor.Text, "", "",clientes_totais_ativos);


                crVendedorxFornecedorxPositivacao cr = new crVendedorxFornecedorxPositivacao();
                cr.SetDataSource(c);
                form_imprimir imprime = new form_imprimir(cr);
                imprime.Show();



            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void button27_Click_1(object sender, EventArgs e)
        {
            if (tb_nome_produto.Text != "" || tbFamilia.Text != "")
                MessageBox.Show("Esse relatório não funciona com produto e família");
            else
            {
                //RELATORIO COM PROBLEMA POIS SAI NO VALOR DE VENDA UM SOMATÓRIO QUE INCLUI VENDAS, TROCAS E BONIFICAÇÕES. TERIA QUE MUDAR O CONCEITO DO RELATORIO POR ISSO OCULTEI O BOTÃO
                try
                {
                    string _vendedor = "", _fornecedor = "", _cliente = "", _cliente_ent = "", _vendedor_ent =  "";
                    if (tb_nome_vendedor.Text != "")
                    {
                        _vendedor = " AND ped.VENDEDOR_PED_VENDA = '" + tb_nome_vendedor.Text + "' ";
                        _vendedor_ent = "AND vc.NOME_VENDEDOR_VC = '" + tb_nome_vendedor.Text + "' ";

                    }

                    string _fornecedor_ent =  "";
                    if (tb_nome_fornecedor.Text != "")
                    {
                        _fornecedor = " AND prod.NOME_FORNECEDOR_PRODUTO = '" + tb_nome_fornecedor.Text + "' ";
                        _fornecedor_ent = " AND prod.NOME_FORNECEDOR_PRODUTO = '" + tb_nome_fornecedor.Text + "' ";
                    }

                    if (tb_nome_cliente.Text != "")
                    {
                        _cliente = " AND nf.CNPJ_CLIENTE_FORN = '" + tb_cnpj.Text + "' ";
                        _cliente_ent = " AND nfe.CNPJ_CLIENTE_FORN_ENT = '" + tb_cnpj.Text + "' ";
                    }

                    if (tb_cod_matriz.Text != "")
                    {
                        _cliente = " AND c.COD_MATRIZ_CLIENTE = '" + tb_cod_matriz.Text + "' ";
                        _cliente_ent = " AND c.COD_MATRIZ_CLIENTE = '" + tb_cod_matriz.Text + "' ";
                    }


                    string _cfop = " and (item.cfop_item like '_1__'	" +
                       "	or item.cfop_item like '_4__') ";
                    if (cbCfop.Checked)
                    {
                        _cfop = "  and (item.cfop_item = '" + tb_n_cfop.Text + "'	" +
                        "	or item.cfop_item = '6" + tb_n_cfop.Text.Substring(1, 3) + "' ) ";
                    }
                    dsClientesxproduto cli = new dsClientesxproduto();
                    FbCommand select = new FbCommand();
                    select.CommandText =
                        //"select sum(item.qtde_item), prod.COD_PRODUTO, '', ped.VENDEDOR_PED_VENDA, sum(item.PRECO_TOTAL_ITEM) 
                        "select sum(item.qtde_item), '0', nf.CNPJ_CLIENTE_FORN, '', sum(item.PRECO_TOTAL_ITEM) AS VALOR, sum(item.CUSTO_ITEM) from itens_nota item " +
                        "inner join produtos prod on prod.cod_fornecedor_produto = item.cod_item " +
                        "INNER JOIN nota_fiscal nf ON ITEM.NF_ITEM = NF.N_NF " +
                        "INNER JOIN PEDIDOS_NF ped_nf on nf.n_nf = ped_nf.nf_pedido_nf " +
                        "inner join pedidos_venda ped on ped.cod_ped_venda = ped_nf.n_pedido_nf " +
                         "inner join clientes c on nf.CNPJ_CLIENTE_FORN = c.CNPJ " + 
                        "where " +
                        "nf.STATUS_NFE LIKE ('%Autorizada%') AND " +
                        "nf.data_emissao_nf >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") +
                        "' and nf.data_emissao_nf <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                        _vendedor + _fornecedor + _cliente +
                        _cfop +
                        "group by nf.CNPJ_CLIENTE_FORN order by VALOR DESC";
                    select.Connection = fbConnection1;
                    fbConnection1.Open();
                    FbDataAdapter datSelect = new FbDataAdapter();
                    datSelect.SelectCommand = select;
                    DataTable dtSelect = new DataTable();
                    datSelect.Fill(dtSelect);
                    fbConnection1.Close();


                    //buscando valor_troca
                    FbCommand select_troca = new FbCommand();
                    select_troca.CommandText =
                    "select sum(item.PRECO_TOTAL_ITEM), nf.CNPJ_CLIENTE_FORN as cnpj from itens_nota item " +
                  "inner join produtos prod on prod.cod_fornecedor_produto = item.cod_item " +
                  "INNER JOIN nota_fiscal nf ON ITEM.NF_ITEM = NF.N_NF " +
                  "INNER JOIN PEDIDOS_NF ped_nf on nf.n_nf = ped_nf.nf_pedido_nf " +
                  "inner join pedidos_venda ped on ped.cod_ped_venda = ped_nf.n_pedido_nf " +
                   "inner join clientes c on nf.CNPJ_CLIENTE_FORN = c.CNPJ " + 
                  "where " +
                  "nf.STATUS_NFE LIKE ('%Autorizada%') AND " +
                  "nf.data_emissao_nf >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") +
                  "' and nf.data_emissao_nf <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                  _vendedor + _fornecedor + _cliente +
                  " AND item.cfop_item like '_949' group by nf.CNPJ_CLIENTE_FORN " + // and nf.CNPJ_CLIENTE_FORN = '" + dr[2].ToString() + "'" +
                    "union " + //PESQUISANDO AS NOTAS DE TROCA INSERIDAS PELA NF ENTRADA
                "select sum(ent.preco_total_item_ent), nfe.CNPJ_CLIENTE_FORN_ENT as cnpj from itens_nota_ent ent inner join " +
                "nota_fiscal_ent nfe on ent.nf_item_ent = nfe.n_nf_ent " +
                "inner join produtos prod on prod.COD_BARRAS_PRODUTO = ent.COD_EAN_ITEM_ENT " +
                "inner join clientes c on nfe.CNPJ_CLIENTE_FORN_ENT = c.CNPJ " +
                "INNER JOIN vendedores_cliente vc on c.COD_CLIENTE = vc.COD_CLIENTE_VC " +
                "where (ent.cfop_item_ent = '5202' or " +
                "ent.cfop_item_ent = '6202' or ent.cfop_item_ent = '5411' or ent.cfop_item_ent = '6411') " +
                "AND nfe.data_emissao_nf_ent >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") + "' " +
                "and nfe.data_emissao_nf_ent <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                _cliente_ent + _vendedor_ent + _fornecedor_ent +
                "and nfe.baixada_nf_ent = 1 group by nfe.CNPJ_CLIENTE_FORN_ENT ";
                    // "and nfe.CNPJ_CLIENTE_FORN_ENT = '" + dr[2].ToString() + "'";

                    select_troca.Connection = fbConnection1;
                    fbConnection1.Open();
                    FbDataAdapter datSelect_troca = new FbDataAdapter();
                    datSelect_troca.SelectCommand = select_troca;
                    DataTable dtSelect_troca = new DataTable();
                    datSelect_troca.Fill(dtSelect_troca);
                    fbConnection1.Close();

                    DataTable dtClientes_com_venda_e_troca = new DataTable();
                    DataColumn col1 = new DataColumn();
                    col1.ColumnName = "cnpj";
                    dtClientes_com_venda_e_troca.Columns.Add(col1);
                    //string[] clientes_com_venda_e_troca = new string[10000];
                    //int i = 0;
                    foreach (DataRow dr in dtSelect.Rows)
                    {
                        double valor_trocas = 0;

                        foreach (DataRow dr_troca in dtSelect_troca.Select("cnpj = '" + dr[2].ToString() + "'"))
                        {

                            try
                            {
                                valor_trocas = valor_trocas + Convert.ToDouble(dr_troca[0].ToString());
                                dtClientes_com_venda_e_troca.Rows.Add(dr_troca["cnpj"].ToString());
                            }
                            catch { }
                        }

                        double custo = 0;
                        try
                        {
                            custo = Convert.ToDouble(dr[5].ToString());
                        }
                        catch { }
                        bool incluir = true;
                        if (cbApenas_troca.Checked)
                        {
                            if (valor_trocas == 0)
                                incluir = false;
                        }
                        if (incluir)
                        {
                            try
                            {
                                cli.VendedorxClientesxProdutos.AddVendedorxClientesxProdutosRow(Convert.ToDouble(dr[0].ToString()), Convert.ToInt32(dr[1].ToString()),
                                    dr[2].ToString(), dr[3].ToString(), Convert.ToDouble(dr[4].ToString()), custo, valor_trocas, 0, 0, 0, 0, 0);
                            }
                            catch { }
                        }
                    }
                    foreach (DataRow dr_troca in dtSelect_troca.Rows)
                    {
                        bool ja_entrou = false;
                        foreach (DataRow dr_vendas_e_trocas in dtClientes_com_venda_e_troca.Select("cnpj = '" + dr_troca["cnpj"].ToString() + "'"))
                        {
                            ja_entrou = true;
                        }
                        if (!ja_entrou)
                        {
                            double valor_trocas = 0;
                            try
                            {
                                valor_trocas = valor_trocas + Convert.ToDouble(dr_troca[0].ToString());
                                try
                                {
                                    cli.VendedorxClientesxProdutos.AddVendedorxClientesxProdutosRow(0, 0,
                                        dr_troca["cnpj"].ToString(), "", 0.00001, 0.00001, valor_trocas, 0.00001, 0, 0, 0, 0);
                                }
                                catch { }
                            }
                            catch { }
                        }
                    }




                    FbCommand select_clientes = new FbCommand();
                    select_clientes.CommandText =
                        "SELECT * from clientes";
                    select_clientes.Connection = fbConnection1;
                    fbConnection1.Open();
                    FbDataAdapter datSelect_clientes = new FbDataAdapter();
                    datSelect_clientes.SelectCommand = select_clientes;
                    datSelect_clientes.Fill(cli.CLIENTES);
                    fbConnection1.Close();

                    /*
                    FbCommand select_produtos = new FbCommand();
                    select_produtos.CommandText =
                        "SELECT * from produtos";
                    select_produtos.Connection = fbConnection1;
                    fbConnection1.Open();
                    FbDataAdapter datSelect_produtos = new FbDataAdapter();
                    datSelect_produtos.SelectCommand = select_produtos;
                    datSelect_produtos.Fill(cli.PRODUTOS);
                    fbConnection1.Close();
                    */
                    cli.Dados.AddDadosRow(tb_nome_fornecedor.Text, Convert.ToDateTime(dtInicial.Text), Convert.ToDateTime(dtFinal.Text),
                        tb_nome_vendedor.Text, "", "",0);


                    crClientesxlucratividade cr = new crClientesxlucratividade();
                    cr.SetDataSource(cli);
                    form_imprimir imprime = new form_imprimir(cr);
                    imprime.Show();
                }
                catch (Exception a)
                {
                    fbConnection1.Close();
                    MessageBox.Show(a.ToString());
                }
            }
        }

        private void button10_Click_1(object sender, EventArgs e)
        {

        }

        private void button29_Click_1(object sender, EventArgs e)
        {
            try
            {
                string _vendedor = "", _cliente = "";
              
                if (tb_nome_vendedor.Text != "")
                    _vendedor = " AND NOME_VENDEDOR_MNV = '" + tb_nome_vendedor.Text + "' ";

                if (tb_nome_cliente.Text != "")
                    _cliente = " AND CNPJ_CLIENTE_MNV = '" + tb_cnpj.Text + "' ";

                dsClientesxVendas cli = new dsClientesxVendas();
                FbCommand select = new FbCommand();
                select.CommandText =
                    //"select sum(item.qtde_item), prod.COD_PRODUTO, '', ped.VENDEDOR_PED_VENDA, sum(item.PRECO_TOTAL_ITEM) 
                    "select * from MOTIVO_NAO_VENDA " +
                    "where " +
                    "DATA_MNV >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") +
                    "' and DATA_MNV <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                    _vendedor + _cliente;
                  
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(cli.MOTIVO_NAO_VENDA);
                fbConnection1.Close();
                
                cli.Informacoes.AddInformacoesRow(Convert.ToDateTime(dtInicial.Text), Convert.ToDateTime(dtFinal.Text),
                    tb_nome_vendedor.Text);


                crMotivo_nao_venda cr = new crMotivo_nao_venda();
                cr.SetDataSource(cli);
                form_imprimir imprime = new form_imprimir(cr);
                imprime.Show();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
        //{     "select sum(item.qtde_infce), prod.COD_PRODUTO, '', NF.NOME_VENDEDOR_NFCE, sum(item.VALOR_TOTAL_INFCE), " + 
        //            "SUM(item.CUSTO_INFCE) from itens_nfce item " +
        //            "inner join produtos prod on prod.cod_fornecedor_produto = item.COD_ESTOQUE_INFCE " +
        //            "INNER JOIN NFCE nf ON ITEM.COD_NFCE_INFCE = NF.COD_NFCE " +
        //            "where " +
        //            "nf.PEDIDO_FECHADO_NFCE = 1 AND " +
        //            "nf.DATA_EMISSAO_NFCE >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") +
        //            "' and nf.DATA_EMISSAO_NFCE <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
        //            _vendedor + _fornecedor + _cliente +
        //            _cfop +
        //            "group by NF.NOME_VENDEDOR_NFCE, prod.COD_PRODUTO";
            try
            {
                string _vendedor = "", _fornecedor = "", _cliente = "", _familia = "";

                if (tbGrupo.Text != "")
                    _familia = " AND prod.DESCRICAO_GRUPO_PRODUTO = '" + tbGrupo.Text + "' ";
                if (tb_nome_produto.Text != "")
                    _familia = " AND prod.COD_PRODUTO = '" + tb_cod_produto.Text + "' ";
                if (tbdescricaoSubgrupo.Text != "")
                    _familia = " AND prod.DESCRICAO_SUB_GRUPO_PRODUTO = '" + tbdescricaoSubgrupo.Text + "' ";

                if (tbFamilia.Text != "")
                    _familia += " AND prod.NOME_FAMILIA_PRODUTO = '" + tbFamilia.Text + "'";
                //if (tbFamilia.Text != "")
                //     _familia = " AND prod.NOME_FAMILIA_PRODUTO = '" + tbFamilia.Text + "' ";

                if (tb_nome_vendedor.Text != "")
                    _vendedor = " AND NF.NOME_VENDEDOR_NFCE = '" + tb_nome_vendedor.Text + "' ";

                if (tb_nome_fornecedor.Text != "")
                    _fornecedor = " AND prod.NOME_FORNECEDOR_PRODUTO = '" + tb_nome_fornecedor.Text + "' ";

                
                string _cfop = " ";
                if (cbCfop.Checked)
                {
                    _cfop = "";
                }
                dsClientesxproduto cli = new dsClientesxproduto();
                FbCommand select = new FbCommand();
                select.CommandText =
                    "select sum(item.qtde_infce), prod.COD_PRODUTO, '', NF.NOME_VENDEDOR_NFCE, sum(item.VALOR_TOTAL_INFCE), " +
                                "SUM(item.CUSTO_INFCE) from itens_nfce item " +
                                "inner join produtos prod on prod.COD_PRODUTO = item.COD_ESTOQUE_INFCE " +
                                "INNER JOIN NFCE nf ON ITEM.COD_pedido_INFCE = NF.pedido_nfce " + 
                                "where " +
                                "nf.PEDIDO_FECHADO_NFCE = 1 AND " +
                                "nf.DATA_EMISSAO_NFCE >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") +
                                "' and nf.DATA_EMISSAO_NFCE <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                                _vendedor + _fornecedor + _familia +
                                _cfop +
                                "group by NF.NOME_VENDEDOR_NFCE, prod.COD_PRODUTO";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    double custo = 0;
                    try
                    {
                        custo = Convert.ToDouble(dr[5].ToString());
                    }
                    catch { }
                    try
                    {
                        cli.VendedorxClientesxProdutos.AddVendedorxClientesxProdutosRow(Convert.ToDouble(dr[0].ToString()), Convert.ToInt32(dr[1].ToString()),
                            dr[2].ToString(), dr[3].ToString(), Convert.ToDouble(dr[4].ToString()), custo, 0, 0, 0, 0, 0, 0);
                    }
                    catch { }
                }

                FbCommand select_clientes = new FbCommand();
                select_clientes.CommandText =
                    "SELECT * from clientes";
                select_clientes.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect_clientes = new FbDataAdapter();
                datSelect_clientes.SelectCommand = select_clientes;
                datSelect_clientes.Fill(cli.CLIENTES);
                fbConnection1.Close();

                FbCommand select_produtos = new FbCommand();
                select_produtos.CommandText =
                    "SELECT * from produtos";
                select_produtos.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect_produtos = new FbDataAdapter();
                datSelect_produtos.SelectCommand = select_produtos;
                datSelect_produtos.Fill(cli.PRODUTOS);
                fbConnection1.Close();

                cli.Dados.AddDadosRow(tb_nome_fornecedor.Text, Convert.ToDateTime(dtInicial.Text), Convert.ToDateTime(dtFinal.Text),
                    tb_nome_vendedor.Text, "", "",0);


                crVendedorxProdutos cr = new crVendedorxProdutos();
                cr.SetDataSource(cli);
                form_imprimir imprime = new form_imprimir(cr);
                imprime.Show();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            try
            {
                string _vendedor = "", _fornecedor = "", _cliente = "", _cliente_ent = "", _familia = "";

                if (tbGrupo.Text != "")
                    _familia = " AND prod.DESCRICAO_GRUPO_PRODUTO = '" + tbGrupo.Text + "' ";
                if (tbdescricaoSubgrupo.Text != "")
                    _familia = " AND prod.DESCRICAO_SUB_GRUPO_PRODUTO = '" + tbdescricaoSubgrupo.Text + "' ";
                if (tb_nome_produto.Text != "")
                    _familia = " AND prod.COD_PRODUTO = '" + tb_cod_produto.Text + "' ";

                if (tbFamilia.Text != "")
                    _familia += " AND prod.NOME_FAMILIA_PRODUTO = '" + tbFamilia.Text + "'";

                if (tb_nome_vendedor.Text != "")
                    _vendedor = " AND pv.VENDEDOR_PED_VENDA = '" + tb_nome_vendedor.Text + "' ";

                if (tb_nome_fornecedor.Text != "")
                    _fornecedor = " AND prod.NOME_FORNECEDOR_PRODUTO = '" + tb_nome_fornecedor.Text + "' ";

                if (tb_nome_cliente.Text != "")
                {
                    _cliente = " AND nf.CNPJ_CLIENTE_FORN = '" + tb_cnpj.Text + "' ";
                    _cliente_ent = " AND nfe.CNPJ_CLIENTE_FORN_ENT = '" + tb_cnpj.Text + "' ";
                }
                if (tb_cod_matriz.Text != "")
                {
                    _cliente = " AND cl.COD_MATRIZ_CLIENTE = '" + tb_cod_matriz.Text + "' ";
                    _cliente_ent = " AND cl.COD_MATRIZ_CLIENTE = '" + tb_cod_matriz.Text + "' ";
                }

                string _cfop = "";
                if (cbCfop.Checked)
                {
                    _cfop = "  and (inf.cfop_item = '" + tb_n_cfop.Text + "'	" +
                    "	or inf.cfop_item = '6" + tb_n_cfop.Text.Substring(1, 3) + "' ) ";
                }

                FbCommand select = new FbCommand();
                select.CommandText =
                    @"select pv.vendedor_ped_venda, inf.cfop_item, sum(inf.preco_total_item) as valor_total, sum(inf.qtde_item) as qtde_total, 'S' as tipo from itens_nota inf
inner join nota_fiscal nf on inf.nf_item = nf.n_nf
inner join clientes cl on nf.cnpj_cliente_forn = cl.cnpj
inner join pedidos_nf pnf on nf.n_nf = pnf.nf_pedido_nf
inner join pedidos_venda pv on pnf.n_pedido_nf = pv.cod_ped_venda
inner join produtos prod on inf.cod_item = prod.cod_fornecedor_produto
inner join vendedores v on pv.COD_VENDEDOR_PED_VENDA = V.COD_VENDEDOR
where nf.STATUS_NFE LIKE ('%Autorizada%') AND " +
                    "nf.data_emissao_nf >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") +
                    @"' and nf.data_emissao_nf <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + @"' " +
                    _vendedor + _fornecedor + _cfop + _cliente + _familia + supervisor + @"
group by pv.vendedor_ped_venda, inf.cfop_item " +
                    "union " + //PESQUISANDO AS NOTAS DE TROCA INSERIDAS PELA NF ENTRADA
                    "select vcl.nome_vendedor_vc as vendedor_ped_venda, ent.cfop_item_ent as cfop_item,  sum(ent.preco_total_item_ent), sum(ent.qtde_item_ent), 'E' as tipo from itens_nota_ent ent inner join " +
                    "nota_fiscal_ent nfe on ent.nf_item_ent = nfe.n_nf_ent " +
                    "inner join clientes cl on nfe.CNPJ_CLIENTE_FORN_ENT = cl.CNPJ " +
                    "inner join vendedores_cliente vcl on cl.cod_cliente = vcl.cod_cliente_vc " +
                    "inner join vendedores v on vcl.COD_VENDEDOR_VC = V.COD_VENDEDOR " +
                    "where (ent.cfop_item_ent = '5202' or " +
                    "ent.cfop_item_ent = '6202' or ent.cfop_item_ent = '5411' or ent.cfop_item_ent = '6411') " +
                    "AND nfe.data_emissao_nf_ent >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") + "' " +
                    "and nfe.data_emissao_nf_ent <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                    _cliente_ent + supervisor +
                    "and nfe.baixada_nf_ent = 1 group by vcl.nome_vendedor_vc, ENT.cfop_item_ent ";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();



                //CLIENTES ATIVOS
                select.CommandText =
                    @"select vcl.nome_vendedor_vc, count(distinct(cl.cnpj)) as clientes from clientes cl
inner join vendedores_cliente vcl on cl.cod_cliente = vcl.cod_cliente_vc
inner join vendedores v on vcl.COD_VENDEDOR_VC = V.COD_VENDEDOR 
where 0=0  " + supervisor + " group by vcl.nome_vendedor_vc";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect_cidades = new FbDataAdapter();
                datSelect_cidades.SelectCommand = select;
                DataTable dtSelect_cidades = new DataTable();
                datSelect_cidades.Fill(dtSelect_cidades);
                fbConnection1.Close();


                _cfop = " and (inf.cfop_item = '5102'	" +
                  "	or inf.cfop_item = '5405') ";
                //CLIENTES POSITIVADOS
                select.CommandText =
                    @"select pv.vendedor_ped_venda, count(distinct(cl.cnpj)) as clientes from itens_nota inf
inner join nota_fiscal nf on inf.nf_item = nf.n_nf
inner join clientes cl on nf.cnpj_cliente_forn = cl.cnpj
inner join pedidos_nf pnf on nf.n_nf = pnf.nf_pedido_nf
inner join pedidos_venda pv on pnf.n_pedido_nf = pv.cod_ped_venda
inner join produtos prod on inf.cod_item = prod.cod_fornecedor_produto
inner join vendedores v on pv.COD_VENDEDOR_PED_VENDA = V.COD_VENDEDOR 
where nf.STATUS_NFE LIKE ('%Autorizada%') AND " +
                    "nf.data_emissao_nf >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") +
                    @"' and nf.data_emissao_nf <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + @"' " +
                    _vendedor + _fornecedor + _cfop + _cliente + _familia + supervisor + @"
group by pv.vendedor_ped_venda";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect_positivados = new FbDataAdapter();
                datSelect_positivados.SelectCommand = select;
                DataTable dtSelect_positivados = new DataTable();
                datSelect_positivados.Fill(dtSelect_positivados);
                fbConnection1.Close();


                select.CommandText =
                    @"select distinct(pv.vendedor_ped_venda) as nome_vendedor_vc from itens_nota inf
inner join nota_fiscal nf on inf.nf_item = nf.n_nf
inner join clientes cl on nf.cnpj_cliente_forn = cl.cnpj
inner join pedidos_nf pnf on nf.n_nf = pnf.nf_pedido_nf
inner join pedidos_venda pv on pnf.n_pedido_nf = pv.cod_ped_venda
inner join produtos prod on inf.cod_item = prod.cod_fornecedor_produto
inner join vendedores v on pv.COD_VENDEDOR_PED_VENDA = v.COD_VENDEDOR
where nf.STATUS_NFE LIKE ('%Autorizada%') AND " +
                    "nf.data_emissao_nf >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") +
                    @"' and nf.data_emissao_nf <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + @"' " +
                    _vendedor + _fornecedor + _cfop + _cliente + _familia + supervisor + @"
group by pv.vendedor_ped_venda, inf.cfop_item ";

                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect_todos = new FbDataAdapter();
                datSelect_todos.SelectCommand = select;
                DataTable dtSelect_todos = new DataTable();
                datSelect_todos.Fill(dtSelect_todos);
                fbConnection1.Close();


                dsClientesxproduto c = new dsClientesxproduto();
                foreach (DataRow dr_todos in dtSelect_todos.Rows)
                {
                    try
                    {
                        double valor_venda = 0, valor_troca = 0, qtde_venda = 0;
                        int clientes = 0;

                        foreach (DataRow dr_cidades in dtSelect_cidades.Select("nome_vendedor_vc = '" + dr_todos["nome_vendedor_vc"].ToString() + "'"))
                        {
                            try
                            {
                                clientes = Convert.ToInt32(dr_cidades["clientes"].ToString());
                            }
                            catch { }
                        }
                        int clientes_positivados = 0;
                        foreach (DataRow dr_positivados in dtSelect_positivados.Select("vendedor_ped_venda = '" + dr_todos["nome_vendedor_vc"].ToString() + "' "))
                        {
                            clientes_positivados += Convert.ToInt32(dr_positivados["clientes"].ToString());
                        }


                        foreach (DataRow dr_valores in dtSelect.Select("vendedor_ped_venda = '" + dr_todos["nome_vendedor_vc"].ToString() + "' "))
                        {
                            if (dr_valores["cfop_item"].ToString() == "5102" || dr_valores["cfop_item"].ToString() == "5405")
                            {
                                valor_venda += Convert.ToDouble(dr_valores["valor_total"].ToString());
                                qtde_venda += Convert.ToDouble(dr_valores["qtde_total"].ToString());
                            }
                            else
                            {
                                if (dr_valores["cfop_item"].ToString() == "5910" || dr_valores["cfop_item"].ToString() == "5949"
                                    || dr_valores["cfop_item"].ToString() == "6910" || dr_valores["cfop_item"].ToString() == "6949")
                                    valor_troca += Convert.ToDouble(dr_valores["valor_total"].ToString());
                                else
                                    if (dr_valores["cfop_item"].ToString() == "5202" || dr_valores["cfop_item"].ToString() == "6202" ||
                                        dr_valores["cfop_item"].ToString() == "5411" || dr_valores["cfop_item"].ToString() == "6411")
                                        valor_troca += Convert.ToDouble(dr_valores["valor_total"].ToString());
                            }
                        }

                        c.VendedorxCidadesxPositivacao.AddVendedorxCidadesxPositivacaoRow(dr_todos["nome_vendedor_vc"].ToString(),
                            "", clientes, clientes_positivados, qtde_venda, valor_venda, valor_troca);
                    }
                    catch (Exception a)
                    {
                        MessageBox.Show(a.ToString());
                    }
                }
                c.Dados.AddDadosRow(tb_nome_fornecedor.Text, Convert.ToDateTime(dtInicial.Text), Convert.ToDateTime(dtFinal.Text),
                  tb_nome_vendedor.Text, "", "",0);


                crVendedorxPositivacao cr = new crVendedorxPositivacao();
                cr.SetDataSource(c);
                form_imprimir imprime = new form_imprimir(cr);
                imprime.Show();



            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            try
            {
                string _vendedor = "", _fornecedor = "", _cliente = "", _produto = "", _familia = "";

                if (tbGrupo.Text != "")
                    _familia = " AND prod.DESCRICAO_GRUPO_PRODUTO = '" + tbGrupo.Text + "' ";
                if (tb_nome_produto.Text != "")
                    _familia = " AND prod.COD_PRODUTO = '" + tb_cod_produto.Text + "' ";
                if (tbdescricaoSubgrupo.Text != "")
                    _familia = " AND prod.DESCRICAO_SUB_GRUPO_PRODUTO = '" + tbdescricaoSubgrupo.Text + "' ";

                if (tbFamilia.Text != "")
                    _familia += " AND prod.NOME_FAMILIA_PRODUTO = '" + tbFamilia.Text + "' ";
                if (tb_nome_vendedor.Text != "")
                    _vendedor = " AND ped.VENDEDOR_PED_VENDA = '" + tb_nome_vendedor.Text + "' ";

                if (tb_nome_fornecedor.Text != "")
                    _fornecedor = " AND prod.NOME_FORNECEDOR_PRODUTO = '" + tb_nome_fornecedor.Text + "' ";

                if (tb_nome_cliente.Text != "")
                    _cliente = " AND ped.CNPJ_PED_VENDA = '" + tb_cnpj.Text + "' ";
                if (tb_cod_matriz.Text != "")
                    _cliente = " AND c.COD_MATRIZ_CLIENTE = '" + tb_cod_matriz.Text + "' ";

                dsClientesxproduto cli = new dsClientesxproduto();
                FbCommand select = new FbCommand();
                select.CommandText =
                    "select sum(item.qtde_item_venda), prod.COD_PRODUTO, ped.CNPJ_PED_VENDA, ped.VENDEDOR_PED_VENDA, sum(item.VALOR_TOTAL_PROD_ITEM_VENDA), " +
                    "SUM(item.CUSTO_ITEM_VENDA) from itens_pedido_venda item " +
                    "inner join produtos prod on prod.cod_fornecedor_produto = item.COD_PROD_ITEM_VENDA " +
                    "inner join pedidos_venda ped on ped.cod_ped_venda = item.COD_PEDIDO_ITEM_VENDA " +
                    "inner join vendedores v on ped.COD_VENDEDOR_PED_VENDA = V.COD_VENDEDOR " +
                     "inner join clientes c on nf.CNPJ_CLIENTE_FORN = c.CNPJ " + 
                    "where " +
                    "ped.BAIXADO_ESTOQUE_PED_VENDA = 1 AND " +
                    "(ped.TROCA_PED_VENDA = 0 or ped.TROCA_PED_VENDA is null) and" +
                    "(ped.BONIFICACAO_PED_VENDA = 0 or ped.BONIFICACAO_PED_VENDA is null) and " +
                    "ped.DATA_PED_VENDA >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") +
                    "' and ped.DATA_PED_VENDA <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                    _vendedor + _fornecedor + _cliente + _produto + _familia + supervisor +
                    "group by ped.VENDEDOR_PED_VENDA, ped.CNPJ_PED_VENDA, prod.COD_PRODUTO";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    double custo = 0;
                    try
                    {
                        custo = Convert.ToDouble(dr[5].ToString());
                    }
                    catch { }
                    try
                    {
                        cli.VendedorxClientesxProdutos.AddVendedorxClientesxProdutosRow(Convert.ToDouble(dr[0].ToString()), Convert.ToInt32(dr[1].ToString()),
                            dr[2].ToString(), dr[3].ToString(), Convert.ToDouble(dr[4].ToString()), custo, 0, 0, 0, 0, 0, 0);
                    }
                    catch { }
                }

                FbCommand select_clientes = new FbCommand();
                select_clientes.CommandText =
                    "SELECT * from clientes";
                select_clientes.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect_clientes = new FbDataAdapter();
                datSelect_clientes.SelectCommand = select_clientes;
                datSelect_clientes.Fill(cli.CLIENTES);
                fbConnection1.Close();

                FbCommand select_produtos = new FbCommand();
                select_produtos.CommandText =
                    "SELECT * from produtos";
                select_produtos.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect_produtos = new FbDataAdapter();
                datSelect_produtos.SelectCommand = select_produtos;
                datSelect_produtos.Fill(cli.PRODUTOS);
                fbConnection1.Close();


                cli.Dados.AddDadosRow(tb_nome_fornecedor.Text, Convert.ToDateTime(dtInicial.Text), Convert.ToDateTime(dtFinal.Text),
                    tb_nome_vendedor.Text, "", "",0);


                crVendedorxClientes cr = new crVendedorxClientes();
                cr.SetDataSource(cli);
                form_imprimir imprime = new form_imprimir(cr);
                imprime.Show();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            if (tb_nome_produto.Text != "" || tbFamilia.Text != "")
                MessageBox.Show("Esse relatório não funciona com produto e família");
            else
            {
                
                try
                {
                    string _vendedor = "", _fornecedor = "", _cliente = "", _cliente_ent = "", _vendedor_ent = "";
                    if (tb_nome_vendedor.Text != "")
                    {
                        _vendedor = " AND ped.VENDEDOR_PED_VENDA = '" + tb_nome_vendedor.Text + "' ";
                        _vendedor_ent = "AND vc.NOME_VENDEDOR_VC = '" + tb_nome_vendedor.Text + "' ";

                    }

                    string _fornecedor_ent = "";
                    if (tb_nome_fornecedor.Text != "")
                    {
                        _fornecedor = " AND prod.NOME_FORNECEDOR_PRODUTO = '" + tb_nome_fornecedor.Text + "' ";
                        _fornecedor_ent = " AND prod.NOME_FORNECEDOR_PRODUTO = '" + tb_nome_fornecedor.Text + "' ";
                    }

                    if (tb_nome_cliente.Text != "")
                    {
                        _cliente = " AND nf.CNPJ_CLIENTE_FORN = '" + tb_cnpj.Text + "' ";
                        _cliente_ent = " AND nfe.CNPJ_CLIENTE_FORN_ENT = '" + tb_cnpj.Text + "' ";
                    }

                    if (tb_cod_matriz.Text != "")
                    {
                        _cliente = " AND c.COD_MATRIZ_CLIENTE = '" + tb_cod_matriz.Text + "' ";
                        _cliente_ent = " AND c.COD_MATRIZ_CLIENTE = '" + tb_cod_matriz.Text + "' ";
                    }

                    string _cfop = " and (item.cfop_item like '_102'	" +
                       "	or item.cfop_item like '_405') ";
                    if (cbCfop.Checked)
                    {
                        _cfop = "  and (item.cfop_item = '" + tb_n_cfop.Text + "'	" +
                        "	or item.cfop_item = '6" + tb_n_cfop.Text.Substring(1, 3) + "' ) ";
                    }
                    dsClientesxproduto cli = new dsClientesxproduto();
                    FbCommand select = new FbCommand();
                    select.CommandText =
                        //"select sum(item.qtde_item), prod.COD_PRODUTO, '', ped.VENDEDOR_PED_VENDA, sum(item.PRECO_TOTAL_ITEM) 
                        "select sum(item.qtde_item), '0', ped.vendedor_ped_venda, '', sum(item.PRECO_TOTAL_ITEM) AS VALOR, sum(item.CUSTO_ITEM) from itens_nota item " +
                        "inner join produtos prod on prod.cod_fornecedor_produto = item.cod_item " +
                        "INNER JOIN nota_fiscal nf ON ITEM.NF_ITEM = NF.N_NF " +
                        "INNER JOIN PEDIDOS_NF ped_nf on nf.n_nf = ped_nf.nf_pedido_nf " +
                        "inner join pedidos_venda ped on ped.cod_ped_venda = ped_nf.n_pedido_nf " +
                         "inner join clientes c on nf.CNPJ_CLIENTE_FORN = c.CNPJ " + 
                        "where " +
                        "nf.STATUS_NFE LIKE ('%Autorizada%') AND " +
                        "nf.data_emissao_nf >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") +
                        "' and nf.data_emissao_nf <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                        _vendedor + _fornecedor + _cliente +
                        _cfop +
                        "group by ped.vendedor_ped_venda order by VALOR DESC";
                    select.Connection = fbConnection1;
                    fbConnection1.Open();
                    FbDataAdapter datSelect = new FbDataAdapter();
                    datSelect.SelectCommand = select;
                    DataTable dtSelect = new DataTable();
                    datSelect.Fill(dtSelect);
                    fbConnection1.Close();


                    //buscando valor_troca
                    FbCommand select_troca = new FbCommand();
                    select_troca.CommandText =
                    "select sum(item.PRECO_TOTAL_ITEM), ped.vendedor_ped_venda as cnpj from itens_nota item " +
                  "inner join produtos prod on prod.cod_fornecedor_produto = item.cod_item " +
                  "INNER JOIN nota_fiscal nf ON ITEM.NF_ITEM = NF.N_NF " +
                  "INNER JOIN PEDIDOS_NF ped_nf on nf.n_nf = ped_nf.nf_pedido_nf " +
                  "inner join pedidos_venda ped on ped.cod_ped_venda = ped_nf.n_pedido_nf " +
                   "inner join clientes c on nf.CNPJ_CLIENTE_FORN = c.CNPJ " + 
                  "where " +
                  "nf.STATUS_NFE LIKE ('%Autorizada%') AND " +
                  "nf.data_emissao_nf >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") +
                  "' and nf.data_emissao_nf <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                  _vendedor + _fornecedor + _cliente +
                  " AND (item.cfop_item like '_949' or item.cfop_item like '_910') group by ped.vendedor_ped_venda " + // mudei conforme para incluir Bonificação
                    "union " + //PESQUISANDO AS NOTAS DE TROCA INSERIDAS PELA NF ENTRADA
                "select sum(ent.preco_total_item_ent), vc.NOME_VENDEDOR_VC as cnpj from itens_nota_ent ent inner join " +
                "nota_fiscal_ent nfe on ent.nf_item_ent = nfe.n_nf_ent " +
                "inner join produtos prod on prod.COD_BARRAS_PRODUTO = ent.COD_EAN_ITEM_ENT " +
                "inner join clientes c on nfe.CNPJ_CLIENTE_FORN_ENT = c.CNPJ " +
                "INNER JOIN vendedores_cliente vc on c.COD_CLIENTE = vc.COD_CLIENTE_VC " +
                "where (ent.cfop_item_ent = '5202' or " +
                "ent.cfop_item_ent = '6202' or ent.cfop_item_ent = '5411' or ent.cfop_item_ent = '6411') " +
                "AND nfe.data_emissao_nf_ent >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") + "' " +
                "and nfe.data_emissao_nf_ent <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                _cliente_ent + _vendedor_ent + _fornecedor_ent +
                "and nfe.baixada_nf_ent = 1 group by vc.NOME_VENDEDOR_VC ";
                    // "and nfe.CNPJ_CLIENTE_FORN_ENT = '" + dr[2].ToString() + "'";

                    select_troca.Connection = fbConnection1;
                    fbConnection1.Open();
                    FbDataAdapter datSelect_troca = new FbDataAdapter();
                    datSelect_troca.SelectCommand = select_troca;
                    DataTable dtSelect_troca = new DataTable();
                    datSelect_troca.Fill(dtSelect_troca);
                    fbConnection1.Close();



                   
                    //string[] clientes_com_venda_e_troca = new string[10000];
                    //int i = 0;

                    //buscando POSITIVACAO E MIX
                    FbCommand select_positivacao = new FbCommand();
                    select_positivacao.CommandText =
                    "select count(distinct(nf.CNPJ_CLIENTE_FORN)), count(distinct(prod.COD_PRODUTO)), ped.vendedor_ped_venda as cnpj from itens_nota item " +
                  "inner join produtos prod on prod.cod_fornecedor_produto = item.cod_item " +
                  "INNER JOIN nota_fiscal nf ON ITEM.NF_ITEM = NF.N_NF " +
                  "INNER JOIN PEDIDOS_NF ped_nf on nf.n_nf = ped_nf.nf_pedido_nf " +
                  "inner join pedidos_venda ped on ped.cod_ped_venda = ped_nf.n_pedido_nf " +
                   "inner join clientes c on nf.CNPJ_CLIENTE_FORN = c.CNPJ " + 
                  "where " +
                  "nf.STATUS_NFE LIKE ('%Autorizada%') AND " +
                  "nf.data_emissao_nf >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") +
                  "' and nf.data_emissao_nf <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                  _vendedor + _fornecedor + _cliente + _cfop +
                  " group by ped.vendedor_ped_venda ";

                    select_positivacao.Connection = fbConnection1;
                    fbConnection1.Open();
                    FbDataAdapter datSelect_positivacao = new FbDataAdapter();
                    datSelect_positivacao.SelectCommand = select_positivacao;
                    DataTable dtSelect_positivacao = new DataTable();
                    datSelect_positivacao.Fill(dtSelect_positivacao);
                    fbConnection1.Close();

                    //buscando novos clientes
                    FbCommand select_clientes = new FbCommand();
                    select_clientes.CommandText =
                         @"select count(distinct(c.cod_cliente)), ped.VENDEDOR_PED_VENDA as cnpj from clientes c " +
                        //@"select count(c.cod_cliente), vcl.nome_vendedor_vc as cnpj from clientes c " + 
                        //inner join vendedores_cliente vcl on c.cod_cliente = vcl.cod_cliente_vc
@"inner join nota_fiscal nf on c.cnpj = nf.cnpj_cliente_forn 
INNER JOIN PEDIDOS_NF ped_nf on nf.n_nf = ped_nf.nf_pedido_nf
inner join pedidos_venda ped on ped.cod_ped_venda = ped_nf.n_pedido_nf 
where 
nf.status_nfe like ('%Autorizada%')
 and c.data_inclusao_cliente >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") +
                  "' and c.data_inclusao_cliente <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") +
                  "' and nf.data_emissao_nf >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") +
                  "' and nf.data_emissao_nf <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + @"' " +
                        //group by  vcl.nome_vendedor_vc ";
"group by ped.VENDEDOR_PED_VENDA";
                    select_clientes.Connection = fbConnection1;
                    fbConnection1.Open();
                    FbDataAdapter datSelect_clientes = new FbDataAdapter();
                    datSelect_clientes.SelectCommand = select_clientes;
                    DataTable dtSelect_clientes = new DataTable();
                    datSelect_clientes.Fill(dtSelect_clientes);
                    fbConnection1.Close();

                    DataTable dtClientes_com_venda_e_troca = new DataTable();
                    DataColumn col1 = new DataColumn();
                    col1.ColumnName = "cnpj";
                    dtClientes_com_venda_e_troca.Columns.Add(col1);

                    foreach (DataRow dr in dtSelect.Rows)
                    {
                        double valor_trocas = 0;

                        foreach (DataRow dr_troca in dtSelect_troca.Select("cnpj = '" + dr[2].ToString() + "'"))
                        {

                            try
                            {
                                valor_trocas = valor_trocas + Convert.ToDouble(dr_troca[0].ToString());
                                dtClientes_com_venda_e_troca.Rows.Add(dr_troca["cnpj"].ToString());
                            }
                            catch { }
                        }
                        double positivacao = 0, mix = 0, novos_clientes = 0;
                        foreach (DataRow drPos in dtSelect_positivacao.Select("cnpj = '" + dr[2].ToString() + "'"))
                        {

                            try
                            {
                                positivacao = positivacao + Convert.ToDouble(drPos[0].ToString());
                                mix = mix + Convert.ToDouble(drPos[1].ToString());
                                
                            }
                            catch { }
                        }
                        
                        foreach (DataRow drNovos in dtSelect_clientes.Select("cnpj = '" + dr[2].ToString() + "'"))
                        {

                            try
                            {
                                novos_clientes = novos_clientes + Convert.ToDouble(drNovos[0].ToString());
                            }
                            catch { }
                        }
                        double custo = 0;
                        try
                        {
                            custo = Convert.ToDouble(dr[5].ToString());
                        }
                        catch { }
                        bool incluir = true;
                        if (cbApenas_troca.Checked)
                        {
                            if (valor_trocas == 0)
                                incluir = false;
                        }
                        if (incluir)
                        {
                            try
                            {
                                cli.VendedorxClientesxProdutos.AddVendedorxClientesxProdutosRow(Convert.ToDouble(dr[0].ToString()), Convert.ToInt32(dr[1].ToString()),
                                    dr[2].ToString(), dr[3].ToString(), Convert.ToDouble(dr[4].ToString()), custo, valor_trocas, 0, positivacao, mix, novos_clientes, 0);
                            }
                            catch { }
                        }
                    }
                    foreach (DataRow dr_troca in dtSelect_troca.Rows)
                    {
                        bool ja_entrou = false;
                        foreach (DataRow dr_vendas_e_trocas in dtClientes_com_venda_e_troca.Select("cnpj = '" + dr_troca["cnpj"].ToString() + "'"))
                        {
                            ja_entrou = true;
                        }
                        if (!ja_entrou)
                        {
                            double valor_trocas = 0;
                            try
                            {
                                valor_trocas = valor_trocas + Convert.ToDouble(dr_troca[0].ToString());
                                try
                                {
                                    cli.VendedorxClientesxProdutos.AddVendedorxClientesxProdutosRow(0, 0,
                                        dr_troca["cnpj"].ToString(), "", 0.00001, 0.00001, valor_trocas, 0.00001, 0, 0, 0, 0);
                                }
                                catch { }
                            }
                            catch { }
                        }
                    }




                    //FbCommand select_clientes = new FbCommand();
                    //select_clientes.CommandText =
                    //    "SELECT * from clientes";
                    //select_clientes.Connection = fbConnection1;
                    //fbConnection1.Open();
                    //FbDataAdapter datSelect_clientes = new FbDataAdapter();
                    //datSelect_clientes.SelectCommand = select_clientes;
                    //datSelect_clientes.Fill(cli.CLIENTES);
                    //fbConnection1.Close();

                    /*
                    FbCommand select_produtos = new FbCommand();
                    select_produtos.CommandText =
                        "SELECT * from produtos";
                    select_produtos.Connection = fbConnection1;
                    fbConnection1.Open();
                    FbDataAdapter datSelect_produtos = new FbDataAdapter();
                    datSelect_produtos.SelectCommand = select_produtos;
                    datSelect_produtos.Fill(cli.PRODUTOS);
                    fbConnection1.Close();
                    */
                    cli.Dados.AddDadosRow(tb_nome_fornecedor.Text, Convert.ToDateTime(dtInicial.Text), Convert.ToDateTime(dtFinal.Text),
                        tb_nome_vendedor.Text, "", "",0);



                    crVendedoresxlucratividade cr = new crVendedoresxlucratividade();
                    cr.SetDataSource(cli);
                    form_imprimir imprime = new form_imprimir(cr);
                    imprime.Show();
                }
                catch (Exception a)
                {
                    fbConnection1.Close();
                    MessageBox.Show(a.ToString());
                }
            }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            try
            {
                string _vendedor = "", _fornecedor = "", _cliente = "", _familia = "", _vendedor_cliente = "";
                //DESCRICAO_GRUPO_PRODUTO
                if (tbGrupo.Text != "")
                    _familia = " AND prod.DESCRICAO_GRUPO_PRODUTO = '" + tbGrupo.Text + "' ";
                if (tbdescricaoSubgrupo.Text != "")
                    _familia = " AND prod.DESCRICAO_SUB_GRUPO_PRODUTO = '" + tbdescricaoSubgrupo.Text + "' ";
                if (tb_nome_produto.Text != "")
                    _familia = " AND prod.COD_PRODUTO = '" + tb_cod_produto.Text + "' ";

                if (tbFamilia.Text != "")
                    _familia += " AND prod.NOME_FAMILIA_PRODUTO = '" + tbFamilia.Text + "' ";

                if (tb_nome_fornecedor.Text != "")
                    _fornecedor = " AND prod.NOME_FORNECEDOR_PRODUTO = '" + tb_nome_fornecedor.Text + "' ";

                if (tb_nome_cliente.Text != "")
                    _cliente = " AND nf.CNPJ_CLIENTE_FORN = '" + tb_cnpj.Text + "' ";
                if (tb_cod_matriz.Text != "")
                    _cliente = " AND c.COD_MATRIZ_CLIENTE = '" + tb_cod_matriz.Text + "' ";

                if (tb_nome_vendedor.Text != "")
                {
                    _vendedor = " AND ped.VENDEDOR_PED_VENDA = '" + tb_nome_vendedor.Text + "' ";
                    _vendedor_cliente = " AND vc.COD_VENDEDOR_VC = '" + tb_cod_vendedor.Text + "' ";
                }

              


                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                        "SELECT prod.COD_FORNECEDOR_PRODUTO, prod.DESCRICAO_PRODUTO, prod.NOME_FAMILIA_PRODUTO, prod.NOME_FORNECEDOR_PRODUTO FROM PRODUTOS prod " +
                        "where STATUS_PRODUTO = 1 " + _familia + _fornecedor;
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();



                FbCommand select1 = new FbCommand();
                select1.Connection = fbConnection1;
                fbConnection1.Open();
                select1.CommandText =
                        "SELECT distinct(item.COD_ITEM), prod.DESCRICAO_PRODUTO, prod.NOME_FAMILIA_PRODUTO, prod.NOME_FORNECEDOR_PRODUTO FROM NOTA_FISCAL nf " +
                        "inner join itens_nota item on nf.n_nf = item.NF_ITEM " +
                        "inner join produtos prod on prod.cod_fornecedor_produto = item.cod_item " +
                        "INNER JOIN PEDIDOS_NF ped_nf on nf.n_nf = ped_nf.nf_pedido_nf " +
                        "inner join pedidos_venda ped on ped.cod_ped_venda = ped_nf.n_pedido_nf " +
                        "inner join vendedores v on ped.COD_VENDEDOR_PED_VENDA = v.COD_VENDEDOR " +
                         "inner join clientes c on nf.CNPJ_CLIENTE_FORN = c.CNPJ " + 
                        "WHERE nf.DATA_EMISSAO_NF >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") + "' AND " +
                        "nf.DATA_EMISSAO_NF <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                        _vendedor + supervisor + _fornecedor + _familia + 
                        "ORDER BY DATA_EMISSAO_NF DESC";
                FbDataAdapter datSelectNf = new FbDataAdapter();
                datSelectNf.SelectCommand = select1;
                DataTable dtSelectNf = new DataTable();
                datSelectNf.Fill(dtSelectNf);
                fbConnection1.Close();

                dsClientesxVendas cl = new dsClientesxVendas();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    try
                    {
                        bool existe = false;
                        foreach (DataRow drNf in dtSelectNf.Select("COD_ITEM = '" + dr[0].ToString() + "'"))
                        {
                            existe = true;
                        }
                        if (!existe)
                        {
                            cl.Produtos.AddProdutosRow(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
                        }
                    }
                    catch { }
                    
                }
                //fileTransferDetail.Tables[0].DefaultView.Sort = "ID DESC";
                cl.ClientesxNF.DefaultView.Sort = "DATA DESC";
                cl.Informacoes.AddInformacoesRow(Convert.ToDateTime(dtInicial.Text), Convert.ToDateTime(dtFinal.Text), tb_nome_vendedor.Text);

                crProdutosNaoAtendidos cr = new crProdutosNaoAtendidos();
                cr.SetDataSource(cl);
                form_imprimir imprime = new form_imprimir(cr);
                imprime.Show();




            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void button27_Click_2(object sender, EventArgs e)
        {
            form_sub_grupo_produto grup = new form_sub_grupo_produto();
            try
            {
                grup.busca = true;
                grup.ShowDialog();
            }
            finally
            {
                tbcodSubgrupo.Text = grup.cod;
                tbdescricaoSubgrupo.Text = grup.descricao;
            }
        }

        private void button12_Click_1(object sender, EventArgs e)
        {

        }

        private void button38_Click_1(object sender, EventArgs e)
        {
            form_localiza_cliente localiza_cliente = new form_localiza_cliente(true, cnpj_empresa);
            try
            {
                localiza_cliente.ShowDialog();
            }
            finally
            {
                localiza_cliente.Dispose();
                tb_razao_matriz.Text = localiza_cliente.cliente_escolhido;
                tb_cod_matriz.Text = localiza_cliente.cod_escolhido;

            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            try
            {

                string _vendedor = "", _fornecedor = "", _cliente = "", join = "", _supervisor = "";
                if (txtCodSupervisor.Text != "")
                {
                    join = "inner join vendedores v on ctv.COD_VENDEDOR_CTV = v.SUPERVISOR_VENDEDOR ";
                    _supervisor = " AND v.SUPERVISOR_VENDEDOR  = '" + txtCodSupervisor.Text + "' ";
                }
                
                if (tb_nome_vendedor.Text != "")
                    _vendedor = " AND ped.VENDEDOR_PED_VENDA = '" + tb_nome_vendedor.Text + "' ";
                
                if (tb_nome_fornecedor.Text != "")
                    _fornecedor = " AND prod.NOME_FORNECEDOR_PRODUTO = '" + tb_nome_fornecedor.Text + "' ";

                if (tb_nome_cliente.Text != "")
                    _cliente = " AND nf.CNPJ_CLIENTE_FORN = '" + tb_cnpj.Text + "' ";

                string _cfop = " and (item.cfop_item like '_1__'	" +
                   "	or item.cfop_item like '_4__') ";
                if (cbCfop.Checked)
                {
                    _cfop = "  and (item.cfop_item = '" + tb_n_cfop.Text + "'	" +
                    "	or item.cfop_item = '6" + tb_n_cfop.Text.Substring(1, 3) + "' ) ";
                }


                List<string> lVendedor = new List<string>();

                dsClientesxproduto cli = new dsClientesxproduto();
                FbCommand select = new FbCommand();
                select.CommandText =
                    "select sum(item.qtde_item), prod.COD_PRODUTO, '', ped.VENDEDOR_PED_VENDA, sum(item.PRECO_TOTAL_ITEM), SUM(item.CUSTO_ITEM), ctv.PORC_COMISSAO_CTV from itens_nota item " +
                    "inner join produtos prod on prod.cod_fornecedor_produto = item.cod_item " +
                    "INNER JOIN nota_fiscal nf ON ITEM.NF_ITEM = NF.N_NF " +
                    "INNER JOIN PEDIDOS_NF ped_nf on nf.n_nf = ped_nf.nf_pedido_nf " +
                    "inner join pedidos_venda ped on ped.cod_ped_venda = ped_nf.n_pedido_nf " +
                    "inner join COMISSAO_TABELA_VENDEDOR ctv on (ped.COD_TP_PED_VENDA = ctv.COD_TABELA_CTV AND ped.cod_vendedor_ped_venda = ctv.COD_VENDEDOR_CTV) " +
                  join +
                    "where " +
                    "nf.STATUS_NFE LIKE ('%Autorizada%') AND " +
                    "nf.data_emissao_nf >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") +
                    "' and nf.data_emissao_nf <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                    _vendedor + _fornecedor + _cliente +
                    _cfop +
                    "group by ped.VENDEDOR_PED_VENDA, prod.COD_PRODUTO, ctv.PORC_COMISSAO_CTV";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {

                    lVendedor.Add(dr[3].ToString());

                    double custo = 0;
                    try
                    {
                        custo = Convert.ToDouble(dr[5].ToString());
                    }
                    catch { }
                    decimal comissao = 0;
                    try
                    {
                        comissao = Convert.ToDecimal(dr["PORC_COMISSAO_CTV"].ToString());
                    }
                    catch { }
                    try
                    {
                        cli.VendedorxClientesxProdutos.AddVendedorxClientesxProdutosRow(Convert.ToDouble(dr[0].ToString()), Convert.ToInt32(dr[1].ToString()),
                            dr[2].ToString(), dr[3].ToString(), Convert.ToDouble(dr[4].ToString()), custo, 0, 0, 0, 0, 0, comissao);
                    }
                    catch { }
                }

                var y = lVendedor.Distinct<string>();

                var listaVendedor = y.ToList<string>();


                for (int i = 0; i < listaVendedor.Count; i++)
                {
                    double valor_trocas = 0;
                    try
                    {
                        //buscando valor_troca
                        FbCommand select_troca = new FbCommand();
                        select_troca.CommandText =
                      "select sum(item.qtde_item), prod.COD_PRODUTO, '', ped.VENDEDOR_PED_VENDA, (sum(item.PRECO_TOTAL_ITEM)*-1), " +
                      "SUM(item.CUSTO_ITEM) from itens_nota item " +
                      "inner join produtos prod on prod.cod_fornecedor_produto = item.cod_item " +
                      
                      "INNER JOIN nota_fiscal nf ON ITEM.NF_ITEM = NF.N_NF " +
                      "INNER JOIN PEDIDOS_NF ped_nf on nf.n_nf = ped_nf.nf_pedido_nf " +
                      "inner join pedidos_venda ped on ped.cod_ped_venda = ped_nf.n_pedido_nf " +
                     
                      "where " +
                      "nf.STATUS_NFE LIKE ('%Autorizada%') AND " +
                      "nf.data_emissao_nf >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") +
                      "' and nf.data_emissao_nf <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                       " AND item.cfop_item <> '5102'	" +
                       "	AND item.cfop_item <> '5405' and item.cfop_item <> '5910'" +
                            // " AND (ped.TROCA_PED_VENDA = 1) " +
                      " AND ped.VENDEDOR_PED_VENDA = '" + listaVendedor[i].ToString() + "' " +
                      "group by ped.VENDEDOR_PED_VENDA, prod.COD_PRODUTO ";


                        select_troca.Connection = fbConnection1;
                        fbConnection1.Open();
                        FbDataAdapter datSelect_troca = new FbDataAdapter();
                        datSelect_troca.SelectCommand = select_troca;
                        DataTable dtSelect_troca = new DataTable();
                        datSelect_troca.Fill(dtSelect_troca);
                        fbConnection1.Close();

                        foreach (DataRow dr_troca in dtSelect_troca.Rows)
                        {
                            try
                            {
                                valor_trocas = valor_trocas + Convert.ToDouble(dr_troca[0].ToString());
                            }
                            catch { }


                            cli.VendedorxClientesxProdutos.AddVendedorxClientesxProdutosRow(Convert.ToDouble(dr_troca[0].ToString()), Convert.ToInt32(dr_troca[1].ToString()),
                                dr_troca[2].ToString(), dr_troca[3].ToString(), Convert.ToDouble(dr_troca[4].ToString()), 0, 0, 0, 0, 0, 0, 0);
                        }
                    }
                    catch (Exception a)
                    {
                        fbConnection1.Close();

                    }
                }


                FbCommand select_clientes = new FbCommand();
                select_clientes.CommandText =
                    "SELECT * from clientes";
                select_clientes.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect_clientes = new FbDataAdapter();
                datSelect_clientes.SelectCommand = select_clientes;
                datSelect_clientes.Fill(cli.CLIENTES);
                fbConnection1.Close();

                FbCommand select_produtos = new FbCommand();
                select_produtos.CommandText =
                    "SELECT * from produtos";
                select_produtos.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect_produtos = new FbDataAdapter();
                datSelect_produtos.SelectCommand = select_produtos;
                datSelect_produtos.Fill(cli.PRODUTOS);
                fbConnection1.Close();


                FbCommand select_comissao = new FbCommand();
                select_comissao.CommandText =
                    "SELECT * from COMISSAO_PRODUTO_VENDEDOR";
                select_comissao.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect_comissao = new FbDataAdapter();
                datSelect_comissao.SelectCommand = select_comissao;
                datSelect_comissao.Fill(cli.COMISSAO_PRODUTO_VENDEDOR);
                fbConnection1.Close();


                cli.Dados.AddDadosRow(tb_nome_fornecedor.Text, Convert.ToDateTime(dtInicial.Text), Convert.ToDateTime(dtFinal.Text),
                    tb_nome_vendedor.Text, "", "", 0);

                crVendedorxProdutosxComissaoporTabela cr = new crVendedorxProdutosxComissaoporTabela();
                cr.SetDataSource(cli);
                form_imprimir imprime = new form_imprimir(cr);
                imprime.Show();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            form_localiza_usuario localiza_usuario = new form_localiza_usuario();
            try
            {
                localiza_usuario.ShowDialog();
            }
            finally
            {
                txtCodSupervisor.Text = localiza_usuario.usuario_escolhido;
                //txtNomeSupervisor.Text = localiza_usuario.nome_usuario;
            }
        }

        private void button42_Click(object sender, EventArgs e)
        {
            if (txtCodSupervisor.Text == "")
                MessageBox.Show("Essa pesquisa só funciona com um supervisor selecionado");
            else
            {
                string _supervisor = "";
                try
                {

                    string _vendedor = "", _fornecedor = "", _cliente = "", join = "";
                    if (txtCodSupervisor.Text != "")
                    {
                        _supervisor = " AND v.SUPERVISOR_VENDEDOR  = '" + txtCodSupervisor.Text + "' ";
                    }

                    if (tb_nome_vendedor.Text != "")
                        _vendedor = " AND ped.VENDEDOR_PED_VENDA = '" + tb_nome_vendedor.Text + "' ";

                    if (tb_nome_fornecedor.Text != "")
                        _fornecedor = " AND prod.NOME_FORNECEDOR_PRODUTO = '" + tb_nome_fornecedor.Text + "' ";

                    if (tb_nome_cliente.Text != "")
                        _cliente = " AND nf.CNPJ_CLIENTE_FORN = '" + tb_cnpj.Text + "' ";

                    string _cfop = " and (item.cfop_item like '_1__'	" +
                       "	or item.cfop_item like '_4__') ";
                    if (cbCfop.Checked)
                    {
                        _cfop = "  and (item.cfop_item = '" + tb_n_cfop.Text + "'	" +
                        "	or item.cfop_item = '6" + tb_n_cfop.Text.Substring(1, 3) + "' ) ";
                    }


                    List<string> lVendedor = new List<string>();

                    dsClientesxproduto cli = new dsClientesxproduto();
                    FbCommand select = new FbCommand();
                    select.CommandText =
                        "select sum(item.qtde_item), prod.COD_PRODUTO, '', ped.VENDEDOR_PED_VENDA, sum(item.PRECO_TOTAL_ITEM), SUM(item.CUSTO_ITEM), ctv.PORC_COMISSAO_CTV, " +
                        "ctv.COD_TABELA_CTV from itens_nota item " +
                        "inner join produtos prod on prod.cod_fornecedor_produto = item.cod_item " +
                        "INNER JOIN nota_fiscal nf ON ITEM.NF_ITEM = NF.N_NF " +
                        "INNER JOIN PEDIDOS_NF ped_nf on nf.n_nf = ped_nf.nf_pedido_nf " +
                        "inner join pedidos_venda ped on ped.cod_ped_venda = ped_nf.n_pedido_nf " +
                        "inner join COMISSAO_TABELA_VENDEDOR ctv on (ped.COD_TP_PED_VENDA = ctv.COD_TABELA_CTV AND ped.cod_vendedor_ped_venda = ctv.COD_VENDEDOR_CTV) " +
                        "inner join vendedores v on ctv.COD_VENDEDOR_CTV = v.cod_vendedor " + 
                      join +
                        "where " +
                        "nf.STATUS_NFE LIKE ('%Autorizada%') AND " +
                        "nf.data_emissao_nf >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") +
                        "' and nf.data_emissao_nf <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                        _vendedor + _fornecedor + _cliente +
                        _cfop + _supervisor +
                        "group by ped.VENDEDOR_PED_VENDA, prod.COD_PRODUTO, ctv.PORC_COMISSAO_CTV, ctv.COD_TABELA_CTV ";
                    select.Connection = fbConnection1;
                    fbConnection1.Open();
                    FbDataAdapter datSelect = new FbDataAdapter();
                    datSelect.SelectCommand = select;
                    DataTable dtSelect = new DataTable();
                    datSelect.Fill(dtSelect);
                    fbConnection1.Close();
                    foreach (DataRow dr in dtSelect.Rows)
                    {


                        lVendedor.Add(dr[3].ToString());

                        double custo = 0;
                        try
                        {
                            custo = Convert.ToDouble(dr[5].ToString());
                        }
                        catch { }
                        decimal comissao = 0;
                        try
                        {
                            comissao = buscar_comissao_supervisor(txtCodSupervisor.Text, dr["COD_TABELA_CTV"].ToString());
                        }
                        catch { }
                        try
                        {
                            cli.VendedorxClientesxProdutos.AddVendedorxClientesxProdutosRow(Convert.ToDouble(dr[0].ToString()), Convert.ToInt32(dr[1].ToString()),
                                dr[2].ToString(), dr[3].ToString(), Convert.ToDouble(dr[4].ToString()), custo, 0, 0, 0, 0, 0, comissao);
                        }
                        catch { }
                    }

                    var y = lVendedor.Distinct<string>();

                    var listaVendedor = y.ToList<string>();


                    for (int i = 0; i < listaVendedor.Count; i++)
                    {
                        double valor_trocas = 0;
                        try
                        {
                            //buscando valor_troca
                            FbCommand select_troca = new FbCommand();
                            select_troca.CommandText =
                          "select sum(item.qtde_item), prod.COD_PRODUTO, '', ped.VENDEDOR_PED_VENDA, (sum(item.PRECO_TOTAL_ITEM)*-1), " +
                          "SUM(item.CUSTO_ITEM) from itens_nota item " +
                          "inner join produtos prod on prod.cod_fornecedor_produto = item.cod_item " +

                          "INNER JOIN nota_fiscal nf ON ITEM.NF_ITEM = NF.N_NF " +
                          "INNER JOIN PEDIDOS_NF ped_nf on nf.n_nf = ped_nf.nf_pedido_nf " +
                          "inner join pedidos_venda ped on ped.cod_ped_venda = ped_nf.n_pedido_nf " +
                          "inner join vendedores v on ped.COD_VENDEDOR_PED_VENDA = v.cod_vendedor" + 
                          "where " +
                          "nf.STATUS_NFE LIKE ('%Autorizada%') AND " +
                          "nf.data_emissao_nf >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") +
                          "' and nf.data_emissao_nf <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                           " AND item.cfop_item <> '5102'	" +
                           "	AND item.cfop_item <> '5405' and item.cfop_item <> '5910'" +
                                // " AND (ped.TROCA_PED_VENDA = 1) " +
                          " AND ped.VENDEDOR_PED_VENDA = '" + listaVendedor[i].ToString() + "' " +
                          _supervisor + 
                          "group by ped.VENDEDOR_PED_VENDA, prod.COD_PRODUTO ";


                            select_troca.Connection = fbConnection1;
                            fbConnection1.Open();
                            FbDataAdapter datSelect_troca = new FbDataAdapter();
                            datSelect_troca.SelectCommand = select_troca;
                            DataTable dtSelect_troca = new DataTable();
                            datSelect_troca.Fill(dtSelect_troca);
                            fbConnection1.Close();

                            foreach (DataRow dr_troca in dtSelect_troca.Rows)
                            {
                                try
                                {
                                    valor_trocas = valor_trocas + Convert.ToDouble(dr_troca[0].ToString());
                                }
                                catch { }


                                cli.VendedorxClientesxProdutos.AddVendedorxClientesxProdutosRow(Convert.ToDouble(dr_troca[0].ToString()), Convert.ToInt32(dr_troca[1].ToString()),
                                    dr_troca[2].ToString(), dr_troca[3].ToString(), Convert.ToDouble(dr_troca[4].ToString()), 0, 0, 0, 0, 0, 0, 0);
                            }
                        }
                        catch (Exception a)
                        {
                            fbConnection1.Close();

                        }
                    }


                    FbCommand select_clientes = new FbCommand();
                    select_clientes.CommandText =
                        "SELECT * from clientes";
                    select_clientes.Connection = fbConnection1;
                    fbConnection1.Open();
                    FbDataAdapter datSelect_clientes = new FbDataAdapter();
                    datSelect_clientes.SelectCommand = select_clientes;
                    datSelect_clientes.Fill(cli.CLIENTES);
                    fbConnection1.Close();

                    FbCommand select_produtos = new FbCommand();
                    select_produtos.CommandText =
                        "SELECT * from produtos";
                    select_produtos.Connection = fbConnection1;
                    fbConnection1.Open();
                    FbDataAdapter datSelect_produtos = new FbDataAdapter();
                    datSelect_produtos.SelectCommand = select_produtos;
                    datSelect_produtos.Fill(cli.PRODUTOS);
                    fbConnection1.Close();


                    FbCommand select_comissao = new FbCommand();
                    select_comissao.CommandText =
                        "SELECT * from COMISSAO_PRODUTO_VENDEDOR";
                    select_comissao.Connection = fbConnection1;
                    fbConnection1.Open();
                    FbDataAdapter datSelect_comissao = new FbDataAdapter();
                    datSelect_comissao.SelectCommand = select_comissao;
                    datSelect_comissao.Fill(cli.COMISSAO_PRODUTO_VENDEDOR);
                    fbConnection1.Close();


                    cli.Dados.AddDadosRow(tb_nome_fornecedor.Text, Convert.ToDateTime(dtInicial.Text), Convert.ToDateTime(dtFinal.Text),
                        tb_nome_vendedor.Text, "", "", 0);

                    crVendedorxProdutosxComissaoporTabela cr = new crVendedorxProdutosxComissaoporTabela();
                    cr.SetDataSource(cli);
                    form_imprimir imprime = new form_imprimir(cr);
                    imprime.Show();
                }
                catch (Exception a)
                {
                    fbConnection1.Close();
                    MessageBox.Show(a.ToString());
                }
            }
        }

        private decimal buscar_comissao_supervisor(string supervisor, string tabela)
        {
            decimal retorno = 0;
            try
            {
                FbCommand select_comissao = new FbCommand();
                select_comissao.CommandText =
                    "SELECT PORC_COMISSAO_CTV from COMISSAO_TABELA_VENDEDOR ctv where ctv.COD_TABELA_CTV  = '" + tabela + "' AND ctv.COD_VENDEDOR_CTV = " + supervisor + " AND ctv.SUPERVISOR_CTV = 1";
                //"COMISSAO_TABELA_VENDEDOR ctv on (ped.COD_TP_PED_VENDA = ctv.COD_TABELA_CTV AND ped.cod_vendedor_ped_venda = ctv.COD_VENDEDOR_CTV) ";
                select_comissao.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect_comissao = new FbDataAdapter();
                datSelect_comissao.SelectCommand = select_comissao;
                DataTable dtComissao = new DataTable();
                datSelect_comissao.Fill(dtComissao);
                fbConnection1.Close();
                foreach (DataRow dr in dtComissao.Rows)
                {
                    try
                    {
                        retorno = Convert.ToDecimal(dr[0].ToString());
                    }
                    catch { }
                }

                return retorno;
            }
            catch (Exception ex)
            {
                fbConnection1.Close();
                MessageBox.Show(ex.ToString());
                return retorno;
            }
        }

        private void button43_Click(object sender, EventArgs e)
        {
            try
            {
                string _vendedor = "", _fornecedor = "", _cliente = "", _familia = "";

                if (tbGrupo.Text != "")
                    _familia = " AND prod.DESCRICAO_GRUPO_PRODUTO = '" + tbGrupo.Text + "' ";
                if (tb_nome_produto.Text != "")
                    _familia = " AND prod.COD_PRODUTO = '" + tb_cod_produto.Text + "' ";
                if (tbdescricaoSubgrupo.Text != "")
                    _familia = " AND prod.DESCRICAO_SUB_GRUPO_PRODUTO = '" + tbdescricaoSubgrupo.Text + "' ";

                if (tbFamilia.Text != "")
                    _familia += " AND prod.NOME_FAMILIA_PRODUTO = '" + tbFamilia.Text + "'";
                //if (tbFamilia.Text != "")
                //     _familia = " AND prod.NOME_FAMILIA_PRODUTO = '" + tbFamilia.Text + "' ";

                if (tb_nome_vendedor.Text != "")
                    _vendedor = " AND NF.NOME_VENDEDOR_NFCE = '" + tb_nome_vendedor.Text + "' ";

                if (tb_nome_fornecedor.Text != "")
                    _fornecedor = " AND prod.NOME_FORNECEDOR_PRODUTO = '" + tb_nome_fornecedor.Text + "' ";


                string _cfop = " ";
                if (cbCfop.Checked)
                {
                    _cfop = "";
                }
                dsClientesxproduto cli = new dsClientesxproduto();
                FbCommand select = new FbCommand();
                select.CommandText =
                    "select sum(item.qtde_infce), prod.cnpj_FORNECEDOR_PRODUTO, prod.NOME_FORNECEDOR_PRODUTO, '', NF.NOME_VENDEDOR_NFCE, sum(item.VALOR_TOTAL_INFCE), " +
                                "SUM(item.CUSTO_INFCE) from itens_nfce item " +
                                "inner join produtos prod on prod.COD_PRODUTO = item.COD_ESTOQUE_INFCE " +
                                "INNER JOIN NFCE nf ON ITEM.COD_pedido_INFCE = NF.pedido_nfce " +
                                "where " +
                                "nf.PEDIDO_FECHADO_NFCE = 1 AND " +
                                "nf.DATA_EMISSAO_NFCE >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") +
                                "' and nf.DATA_EMISSAO_NFCE <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                                _vendedor + _fornecedor + _familia +
                                _cfop +
                                "group by NF.NOME_VENDEDOR_NFCE, prod.cnpj_FORNECEDOR_PRODUTO, prod.NOME_FORNECEDOR_PRODUTO";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    double custo = 0;
                    try
                    {
                        custo = Convert.ToDouble(dr[6].ToString());
                    }
                    catch { }
                    try
                    {
                        cli.VendedorxClientesxFornecedor.AddVendedorxClientesxFornecedorRow(Convert.ToDouble(dr[0].ToString()), dr[1].ToString(), dr[2].ToString(),
                            dr[3].ToString(), dr[4].ToString(), Convert.ToDouble(dr[5].ToString()), custo, 0, 0, 0, 0, 0, 0);
                    }
                    catch { }
                }

             
                cli.Dados.AddDadosRow(tb_nome_fornecedor.Text, Convert.ToDateTime(dtInicial.Text), Convert.ToDateTime(dtFinal.Text),
                    tb_nome_vendedor.Text, "", "", 0);


                crVendedorxFornecedor cr = new crVendedorxFornecedor();
                cr.SetDataSource(cli);
                form_imprimir imprime = new form_imprimir(cr);
                imprime.Show();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void button44_Click(object sender, EventArgs e)
        {
            /*
            try
            {
                string _vendedor = "", _fornecedor = "", _cliente = "", join = "";
               
                if (tb_nome_vendedor.Text != "")
                    _vendedor = " AND ped.VENDEDOR_PED_VENDA = '" + tb_nome_vendedor.Text + "' ";

             

                DataTable dtExtratoFlex = new DataTable();
                dtExtratoFlex.Clear();
               
                FbCommand select = new FbCommand();
                select.CommandText =
                    //"select sum(item.qtde_item), prod.COD_PRODUTO, '', ped.VENDEDOR_PED_VENDA, sum(item.PRECO_TOTAL_ITEM) 
                    "select ped.VENDEDOR_PED_VENDA, prod.COD_PRODUTO, prod.DESCRICAO_PRODUTO, item.qtde_item, prod.VALOR_PROMOCAO_PRODUTO, item.PRECO_UNIT_ITEM,  item.PRECO_TOTAL_ITEM," +
                    "item.NF_ITEM, nf.CLIENTE_FORN_NF, nf.DATA_EMISSAO_nf, item.CFOP_ITEM  from itens_nota item " +
                    "inner join produtos prod on prod.cod_fornecedor_produto = item.cod_item " +
                    "INNER JOIN nota_fiscal nf ON ITEM.NF_ITEM = NF.N_NF " +
                    "INNER JOIN PEDIDOS_NF ped_nf on nf.n_nf = ped_nf.nf_pedido_nf " +
                    "inner join pedidos_venda ped on ped.cod_ped_venda = ped_nf.n_pedido_nf " +
                     "inner join vendedores v on ped.COD_VENDEDOR_PED_VENDA = V.COD_VENDEDOR " +
                    "where " +
                    "nf.STATUS_NFE LIKE ('%Autorizada%') and " +
                    "nf.data_emissao_nf >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") + "' and " +
                    "nf.data_emissao_nf <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                     _vendedor + 
                    " ORDER BY nf.DATA_EMISSAO_nf ";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtExtratoFlex);
                fbConnection1.Close();

               dsPainel_vendas painel = new dsPainel_vendas();
           
                    try
                    {
                        decimal saldo = 0;
                        foreach (DataRow dr in dtExtratoFlex.Rows)
                        {
                            decimal valor_debito_credito = 0;
                            if (dr["CFOP_ITEM"].ToString().Contains("910"))  //BONIFICACAO
                            {
                                valor_debito_credito = Convert.ToDecimal(dr["PRECO_UNIT_ITEM"].ToString()) *
                                    Convert.ToDecimal(dr["QTDE_ITEM"].ToString()) * -1;
                            }
                            if (dr["CFOP_ITEM"].ToString()[1].ToString() == "1" || dr["CFOP_ITEM"].ToString()[1].ToString() == "4") //VENDAS
                            {
                                valor_debito_credito = (Convert.ToDecimal(dr["PRECO_UNIT_ITEM"].ToString()) *
                                    Convert.ToDecimal(dr["QTDE_ITEM"].ToString()) - Convert.ToDecimal(dr["VALOR_PROMOCAO_PRODUTO"].ToString()) *
                                    Convert.ToDecimal(dr["QTDE_ITEM"].ToString())) * Convert.ToDecimal("0,75");
                                if (valor_debito_credito < 0)
                                    valor_debito_credito = 0;
                            }
                            if (valor_debito_credito != 0)
                            {
                                saldo += valor_debito_credito;
                                painel.dsExtratoFlex.AdddsExtratoFlexRow(dr["VENDEDOR_PED_VENDA"].ToString(), dr["COD_PRODUTO"].ToString(), dr["DESCRICAO_PRODUTO"].ToString(),
                                    Convert.ToDecimal(dr["QTDE_ITEM"].ToString()), Convert.ToDecimal(dr["VALOR_PROMOCAO_PRODUTO"].ToString()), Convert.ToDecimal(dr["PRECO_UNIT_ITEM"].ToString()),
                                    Convert.ToDecimal(dr["PRECO_TOTAL_ITEM"].ToString()), dr["NF_ITEM"].ToString(), dr["CLIENTE_FORN_NF"].ToString(),
                                    Convert.ToDateTime(dr["DATA_EMISSAO_NF"].ToString()), dr["CFOP_ITEM"].ToString(), valor_debito_credito, saldo);

                            }
                        }
                    }
                    catch { }

                   crPainel_extratoFlex cr = new crPainel_extratoFlex();
                cr.SetDataSource(painel);
                form_imprimir imprime = new form_imprimir(cr);
                imprime.Show();
            

            }
            catch { fbConnection1.Close(); }
            */
        }
     }
}
            
        
        
