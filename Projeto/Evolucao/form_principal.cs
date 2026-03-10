using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using FirebirdSql.Data.FirebirdClient;

namespace Evolucao
{
    public partial class form_principal : Form
    {
        public string _cod_banco, _agencia, _dig_agencia, _cc, _dig_cc, _carteira, _multa, _mora, _dias_protesto;

        public string usuario_atual;
        public string cod_usuario_atual;
        public string cod_web_service_empresa;
        //Usado para as impressões dos relatórios de estoque
        private FbDataAdapter datEstoque;
        private dsConsulta dsEstoque;
        private FbCommand cmdEstoque;
        private form_imprimir formImp;
        private crEstoqueSintetico relEstoqueSintetico;
        private crEstoqueAnalitico relEstoqueAnalitico;
        //Usado na modifição aplicada apenas na Artesanal Doces
        public static string cnpjArtesanal = "";
        //public string cnpj;
        public form_principal()
        {
            //this.cnpj = cnpj;
            InitializeComponent();
        }

        private void buscar_dados_bancarios()
        {
            _cod_banco = ""; _agencia = ""; _dig_agencia = "";
            _cc = ""; _dig_cc = "";
            _carteira = ""; _multa = "";
            _mora = ""; _dias_protesto = "";

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
                    _cod_banco = dr["CODIGO_NO_BANCO_CC"].ToString();
                    _agencia = dr["AGENCIA_CC"].ToString();
                    _dig_agencia = dr["DIG_AGENCIA_CC"].ToString();
                    _cc = dr["CONTA_CC"].ToString();
                    _dig_cc = dr["DIG_CONTA_CC"].ToString();
                    _multa = dr["MULTA_CC"].ToString();
                    _mora = dr["MORA_DIA_CC"].ToString();
                    _dias_protesto = dr["DIAS_PROTESTO_CC"].ToString();
                    _carteira = dr["CARTEIRA_CC"].ToString();
                }

            }
            catch { fbConnection1.Close();  }
        }

        private void operadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_operadores operadores = new form_operadores();
            try
            {
                operadores.ShowDialog();
            }
            finally
            {
                operadores.Dispose();
            }
        }

        private void tiposDeOperaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_tipos_operacoes tipos_operacoes = new form_tipos_operacoes();
            try
            {
                tipos_operacoes.ShowDialog();
            }
            finally
            {
                tipos_operacoes.Dispose();
            }
        }

        private void tiposDeRefugoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_tipos_refugo tipos_refugo = new form_tipos_refugo();
            try
            {
                tipos_refugo.ShowDialog();
            }
            finally
            {
                tipos_refugo.Dispose();
            }
        }

        private void tiposDeParadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_tipos_parada tipos_parada = new form_tipos_parada();
            try
            {
                tipos_parada.ShowDialog();
            }
            finally
            {
                tipos_parada.Dispose();
            }
        }

        private void opsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            form_op op = new form_op();
            try
            {
                op.ShowDialog();
            }
            finally
            {
                op.Dispose();
            }
        }

        private void desenhosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_peca desenhos = new form_peca();
            try
            {
                desenhos.ShowDialog();
            }
            finally
            {
                desenhos.Dispose();
            }
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            form_crOp rpt = new form_crOp();
            rpt.ShowDialog();
        }

        private void máquinasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_maquinas maq = new form_maquinas();
            maq.ShowDialog();
        }

        private void peçaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            form_peca desenhos = new form_peca();
            try
            {
                desenhos.nova_peca = true;
                desenhos.ShowDialog();
            }
            finally
            {
                desenhos.Dispose();
            }
        }

        private void peçaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_peca desenhos = new form_peca();
            try
            {
                
                desenhos.ShowDialog();
            }
            finally
            {
                desenhos.Dispose();
            }
        }

        private void oPToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            form_peca desenhos = new form_peca();
            try
            {
                desenhos.nova_op = true;
                desenhos.ShowDialog();
            }
            finally
            {
                desenhos.Dispose();
            }
        }

        private void peçaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            form_op desenhos = new form_op();
            desenhos.Show();
            
        }

        private void pesquisaOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_consulta_os nova_consulta = new form_consulta_os();
            nova_consulta.Show();
        }

        private void paradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_recalcula_paradas novo_recalculo = new form_recalcula_paradas();
            novo_recalculo.Show();
        }

        private void rotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_recalcula_horas_rota novo_recalculo = new form_recalcula_horas_rota();
            novo_recalculo.Show();
        }

        private void horasDoPontoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_ponto ponto = new form_ponto();
            ponto.Show();
        }

        private void pesquisaPeloPontoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_consulta_ponto consulta_ponto = new form_consulta_ponto();
            consulta_ponto.Show();
        }

        private void form_principal_Load(object sender, EventArgs e)
        {
            buscar_dados_bancarios();
                form_usuario usuario = new form_usuario();

                try
                {
                    usuario.ShowDialog();
                }
                finally
                {
                    if (usuario.confirmado == true)
                    {
                        usuario_atual = usuario._nome_usuario;
                        cod_usuario_atual = usuario._cod_usuario;
                        status.Text = usuario_atual + " ON-LINE";
                        //form_estoque_mínimo est = new form_estoque_mínimo();
                        //est.ShowDialog();
                        form_selecionar_empresa emp = new form_selecionar_empresa();
                        try
                        {
                            emp.busca_dentro = true;
                            emp.ShowDialog();
                        }
                        finally
                        {
                            empresatoolStripStatusLabel.Text = emp.empresa_emissora;
                            cnpjtoolStripStatusLabel.Text = emp.cnpj_empresa_emissora;
                            cnpjArtesanal = emp.cnpj_empresa_emissora;
                            labelEmpresa.Text = emp.empresa_emissora;
                        }
                        if (emp.cnpj_empresa_emissora != "")
                        {
                            cod_web_service_empresa = buscar_cod_webservice(emp.cnpj_empresa_emissora);

                            definir_acessos(cod_usuario_atual);
                            classe_add_campos add = new classe_add_campos();
                            add.adicionar_campos();
                        }
                        else
                        {
                            MessageBox.Show("Selecione uma empresa por favor");
                            this.Close();
                        }

                    }
                    else
                    {
                        this.Close();
                    }

                }

                #region Codigo Exclusivo Beitute

                if (cnpjArtesanal == "11.328.159/0001-56")
                {
                    importarPedidosToolStripMenuItem.Visible = false;
                }

                #endregion
            
        }

        private string buscar_cod_webservice(string _cnpj)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT COD_WEBSERVICE_EMPRESA FROM EMPRESA WHERE CNPJ_EMPRESA = '" + _cnpj + "'";
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
        private void definir_acessos(string _cod)
        {
            string _cod_usuario = "", _senha = "", _nome_usuario = "", _pcp = "", _faturamento = "", _estoque = "", _compras = "", _financeiro = "", _orcamentos = "", _qualidade = "", _total = "", _transportes = "";
            comando_select.CommandText = "SELECT * " +
                "FROM USUARIOS WHERE COD_USUARIO = '" + _cod + "'";
            DataSet usuario = new DataSet();
            fbConnection1.Open();
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
                try
                {
                    _transportes = dr["TRANSPORTES_USUARIO"].ToString();
                }
                catch { }
                financeiro_limitado = 0;
                try
                {
                    financeiro_limitado = Convert.ToInt32(dr["FINANCEIRO_LIMITADO_USUARIO"].ToString());
                }
                catch { }
            }

            fbConnection1.Close(); 
            //Cadastros Gerais

            if (_pcp == "1")
            {
                PCPToolStripMenuItem.Visible = true;
                btn_pecas.Enabled = true;
            }
            if (_faturamento == "1")
            {
                btn_nf.Enabled = true;
                cadastroToolStripMenuItem.Visible = true;
                relatóriosToolStripMenuItem.Visible = true;
                FaturamentoToolStripMenuItem.Visible = true;
                
            }
            if (_estoque == "1")
            {
                cadastroToolStripMenuItem.Visible = true;
                //relatóriosToolStripMenuItem.Visible = true;
                estoqueToolStripMenuItem.Visible = true;
                btn_estoque.Enabled = true;
            }
            if (_compras == "1")
            {
                btn_pedido_compra.Enabled = true;
                cadastroToolStripMenuItem.Visible = true;
            //relatóriosToolStripMenuItem.Visible = true;
                comprasToolStripMenuItem.Visible = true;
            }
            if (_financeiro == "1")
            {
                btn_planejamento.Enabled = true;
                financeiroToolStripMenuItem.Visible = true;
                cadastroToolStripMenuItem.Visible = true;
                relatóriosToolStripMenuItem.Visible = true;
                if (financeiro_limitado == 1)
                {
                   // planejamentoToolStripMenuItem.Visible = false;
                    travaFinanceiroToolStripMenuItem.Visible = false;
                }
                //Verificando se a empresa é DOKINOS  para ativar o menu de arquivos da JMacedo
                // if (empresatoolStripStatusLabel.Text.Contains("DOKINOS"))
                // {

                // }
            }
            if (_transportes == "1")
            {
                transportesToolStripMenuItem.Visible = true;
                
            }
            if (_orcamentos == "1")
            {
                btn_orcamento.Enabled = true;
                cadastroToolStripMenuItem.Visible = true;
                relatóriosToolStripMenuItem.Visible = true;
                pedidosToolStripMenuItem.Visible = true;
            }

            if (_qualidade == "1")
            {
                //qualidadeToolStripMenuItem.Visible = true;
            }

            if (_total == "1")
            {
                PCPToolStripMenuItem.Visible = true;
                FaturamentoToolStripMenuItem.Visible = true;
                estoqueToolStripMenuItem.Visible = true;
                comprasToolStripMenuItem.Visible = true;
                financeiroToolStripMenuItem.Visible = true;
                transportesToolStripMenuItem.Visible = true;
                pedidosToolStripMenuItem.Visible = true;
                cadastroToolStripMenuItem.Visible = true;
                relatóriosToolStripMenuItem.Visible = true;
                btn_pecas.Enabled = true;
                btn_nf.Enabled = true;
                btn_estoque.Enabled = true;
                btn_nf_entrada.Enabled = true;
                btn_pedido_compra.Enabled = true;
                btn_planejamento.Enabled = true;
                btn_orcamento.Enabled = true;
                //qualidadeToolStripMenuItem.Visible = true;
                usuáriosToolStripMenuItem.Enabled = true;
                if (_cod_usuario.ToString() == "1")
                {
                    empresaToolStripMenuItem.Enabled = true;
                    usuáriosToolStripMenuItem.Enabled = true;
                    manutençãoToolStripMenuItem.Visible = true;
                }

                //Verificando se a empresa é DOKINOS  para ativar o menu de arquivos da JMacedo
                if(empresatoolStripStatusLabel.Text.Contains("CLERM"))
                {
                    pesquisaCliFornToolStripMenuItem2.Visible = false;
                }

            }
            if (empresatoolStripStatusLabel.Text.Contains("CLERM"))
            {
                pesquisaCliFornToolStripMenuItem2.Visible = false;
            }

        }

        private void versãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_versao versao = new form_versao();
            versao.Show();
        }

        private void realinharBancoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_realinha_banco realinha = new form_realinha_banco();
            realinha.Show();
        }

        private void serviçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_servicos servicos = new form_servicos();
            servicos.Show();
        }

        private void cronogramaDetalhadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_cronograma_detalhado_x cronograma = new form_cronograma_detalhado_x();
            cronograma.Show();
        }

        private void horasManuaisAntigasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_maquinas_rodando maq_rod = new form_maquinas_rodando();
            maq_rod.Show();
        }

        private void semanasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void realinharFinalizadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_finalizados finalizados = new form_finalizados();
            finalizados.Show();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_servicos_externos fornecedores = new form_servicos_externos();
            fornecedores.Show();
        }

        private void pesquisaRealinhamentoDeHorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_consulta_os nova_consulta = new form_consulta_os();
            nova_consulta.Show();
        }

        private void excluirTraçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_tira_traco tira = new form_tira_traco();
            tira.Show();
        }

        private void testeConversãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileInfo t = new FileInfo("c:\\evolucao\\teste.TXT");
            t.CopyTo(Path.ChangeExtension(t.FullName, ".htm"), false);

        }

        private void criarOSAutomaticamenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 1600; i < 2025; i++)
            {
                this.datDesenhos.InsertCommand.CommandText =
                           "INSERT INTO DESENHOS (N_OS_PECA)" +
                           "VALUES ('" + i.ToString() + "')";
                this.fbConnection1.Open();
                this.datDesenhos.InsertCommand.Connection = fbConnection1;
                this.datDesenhos.InsertCommand.ExecuteNonQuery();
                this.fbConnection1.Close(); 


            }
        }

        private void despesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_despesas_molde despesas = new form_despesas_molde();
            despesas.Show();
        }

        private void rotasSemanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_verifica_rota_sem_semana rota = new form_verifica_rota_sem_semana();
            rota.Show();
        }

        private void previstoXRealizadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_grafico_iso novo = new form_grafico_iso();
            novo.Show();
        }

        private void porOperaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_semanas semana = new form_semanas();
            semana.Show();
        }

        private void todasAsOperaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_semanas_setores semana = new form_semanas_setores();
            semana.Show();
        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_agenda agenda = new form_agenda();
            agenda.Show();
        }

        private void iniciarSuporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"c:\\evolucao\\TeamViewerQS_pt.exe");
        }

        private void períodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_periodo periodo = new form_periodo();
            periodo.Show();
        }

        private void requisiçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_requisicao requisicao = new form_requisicao(cnpjtoolStripStatusLabel.Text);
            requisicao.Show();
        }

        private void pedidoDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_pedido_compra pedido = new form_pedido_compra(cnpjtoolStripStatusLabel.Text);
            pedido.Show();
        }

        private void nFeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_faturamento fatura = new form_faturamento(cnpjtoolStripStatusLabel.Text);
            try
            {
            //    fatura.CodigoBanco = Convert.ToInt16(_cod_banco);
            }
            catch { }
            fatura.Show();
        }

        private void ultimaNotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_ultima_nota ultima = new form_ultima_nota(cnpjtoolStripStatusLabel.Text);
            ultima.Show();
        }

        private void tRANSPORTADORAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_transportadora trans = new form_transportadora();
            trans.Show();
        }

        private void tributaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_tributacao trib = new form_tributacao();
            trib.Show();
        }

        private void formasDePgtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_forma_pgto pgto = new form_forma_pgto();
            pgto.Show();
        }

        

        private void fornecedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void aliquotaSimplesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_aliquota aliquota = new form_aliquota();
            aliquota.Show();
        }

        private void requisiçõesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            form_requisicao req = new form_requisicao(cnpjtoolStripStatusLabel.Text);
            req.cod_usuario = cod_usuario_atual;
            req.Show();
        }

        private void pedidoDeCompraToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            form_pedido_compra ped = new form_pedido_compra(cnpjtoolStripStatusLabel.Text);
            ped.cnpj_empresa = cnpjtoolStripStatusLabel.Text;
            ped.cod_usuario = cod_usuario_atual;
            ped.Show();
        }

        private void requisiçõesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            form_pesquisa_requisicao req = new form_pesquisa_requisicao(cnpjtoolStripStatusLabel.Text);
            req.cod_usuario = cod_usuario_atual;
            req.Show();
        }

        private void pedidosCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_pesquisa_pedido_compra ped = new form_pesquisa_pedido_compra(cnpjtoolStripStatusLabel.Text);
            ped.cnpj_empresa = cnpjtoolStripStatusLabel.Text;
            ped.cod_usuario = cod_usuario_atual;
            ped.Show();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_cadastro_usuario usuario = new form_cadastro_usuario();
            usuario.Show();
        }

        private void saida_estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_saidas_estoque saida = new form_saidas_estoque(cnpjtoolStripStatusLabel.Text);
            saida.Show();
        }

        private void almoxarifadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_estoque est = new form_estoque(cnpjtoolStripStatusLabel.Text);
            est.Show();
        }

        private void entradaNFToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        public int financeiro_limitado;
        private void contasAPagarEREceberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_cp_cr cr_cp = new form_cp_cr();
            cr_cp.financeiro_limitado = financeiro_limitado;
            
            
            cr_cp.Show();
        }

        private void planosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_planos planos = new form_planos();
            planos.Show();
        }

        private void carteirasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_carteiras carteiras = new form_carteiras();
            carteiras.Show();
        }

        private void caixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_caixa caixa = new form_caixa();
            caixa.Show();
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_crono_excel excel = new form_crono_excel();
            excel.Show();
        }

        private void consultaInserçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
                form_clientes cl = new form_clientes(cnpjtoolStripStatusLabel.Text);
                cl.fornecedor = true;
                cl.Show();
            
            
        }

        private void imprimirListagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dsFornecedores imprimir = new dsFornecedores();
            fbConnection1.Open();
            datFornecedores.Fill(imprimir.FORNECEDORES);

            fbConnection1.Close(); 
            crFornecedores nova_forn = new crFornecedores();
            nova_forn.SetDataSource(imprimir);
            form_imprimir imprime = new form_imprimir(nova_forn);
            imprime.Show();


        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_empresa empresa = new form_empresa();
            empresa.Show();
        }

        private void gruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_grupo_produto grupo = new form_grupo_produto();
            grupo.Show();
        }

        private void subGruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_sub_grupo_produto sub = new form_sub_grupo_produto();
            sub.Show();
        }

        private void unidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_unidade uni = new form_unidade();
            uni.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void pedidosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            form_pedidos ped = new form_pedidos(cnpjtoolStripStatusLabel.Text);
            ped.cod_usuario = cod_usuario_atual;
            ped.cnpj_empresa = cnpjtoolStripStatusLabel.Text;
            ped.Show();
        }

        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_pesquisa_pedido ped = new form_pesquisa_pedido(false, cnpjtoolStripStatusLabel.Text);
            ped.cod_usuario = cod_usuario_atual;
            ped.cnpj_empresa = cnpjtoolStripStatusLabel.Text;
            ped.Show();
        }

        private void atualizarValoresAReceberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_atualiza_cr cr = new form_atualiza_cr();
            cr.Show();
        }

        private void cadastroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            form_produto prod = new form_produto(cnpjtoolStripStatusLabel.Text);
            prod.Show();
        }

        private void pesquisaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            form_localiza_produto localiza_item = new form_localiza_produto(false, cnpjtoolStripStatusLabel.Text);
            localiza_item.Show();
            
        }

        private void cadastroSaídaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_cfo cf = new form_cfo();
            cf.Show();
        }

        private void entradaXSaídaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_cfop_ent_sai cf = new form_cfop_ent_sai();
            cf.Show();
        }

        private void addCamposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_add_campos add = new form_add_campos();
            add.Show();
        }

        private void arquivoJMacedoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void cTeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_cte _cte = new form_cte();
            _cte.empresa_emissora = empresatoolStripStatusLabel.Text;
            _cte.cnpj_empresa_emissora = cnpjtoolStripStatusLabel.Text;
            _cte.funcionario_emissor = cod_usuario_atual;
            _cte.Show();
        }

        private void consultaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            form_pesquisa_cte _cte = new form_pesquisa_cte();
            _cte._cnpj_emitente = cnpjtoolStripStatusLabel.Text;
            _cte.empresa_emissora = empresatoolStripStatusLabel.Text;
            _cte.cod_usuario = cod_usuario_atual;
            _cte.Show();
        }

        private void romaneiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_romaneio_pedido romaneio = new form_romaneio_pedido();
            romaneio.cod_usuario = cod_usuario_atual;
            romaneio.Show();
        }

        private void tabelasComposiçãoPreçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_tabela_composicao_preco preco = new form_tabela_composicao_preco();
            preco.Show();
        }

        private void consultaDetalhadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_pesquisa_faturamento_cte_detalhado cte = new form_pesquisa_faturamento_cte_detalhado();
            cte.Show();
        }

        private void consultaRomaneioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_busca_romaneio buscaRomaneio = new form_busca_romaneio();
            buscaRomaneio.Show();
        }

        private void comissãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void coletasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void entradaDeNotaFiscalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_nf_ent nf = new form_nf_ent();
            nf.Show();
        }

        private void estoqueSintéticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Iniciando os atributos
            datEstoque = new FbDataAdapter();
            dsEstoque = new dsConsulta();
            cmdEstoque = new FbCommand();
            relEstoqueSintetico = new crEstoqueSintetico();
            formImp = new form_imprimir(relEstoqueSintetico);

            try
            {
                //Selecionando os itens de estoque
                cmdEstoque.CommandText =
                    "SELECT * " +
                    "FROM estoque " +
                    "ORDER BY cod_estoque";
                datEstoque.SelectCommand = cmdEstoque;
                datEstoque.SelectCommand.Connection = fbConnection1;
                datEstoque.SelectCommand.Connection.Open();
                datEstoque.SelectCommand.ExecuteNonQuery();
                datEstoque.Fill(dsEstoque.ESTOQUE);
                datEstoque.SelectCommand.Connection.Close();

                //Exibindo o relatório
                relEstoqueSintetico.SetDataSource(dsEstoque);
                formImp.Show();

            }
            catch (Exception a)
            {
                datEstoque.SelectCommand.Connection.Close();
                MessageBox.Show(a.Message);
            }
        }

        private void estoqueAnalíticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formImprimeEstoque estoque = new formImprimeEstoque();
            estoque.Show();
        }

        private void arquivosDeTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formArquivosTexto arquivosTexto = new formArquivosTexto();
            arquivosTexto.Show();
        }

        private void comissãoToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            form_pesquisa_comissao comissao = new form_pesquisa_comissao();
            comissao.Show();
        }

        private void vToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            formVendasFornecedor vendasFornecedor = new formVendasFornecedor();
            vendasFornecedor.Show();
        }

        private void pedidosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            formManutencaoPedidos manutencaoPedidos = new formManutencaoPedidos();
            manutencaoPedidos.Show();
        }

        private void vendasDeProdutosPorFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void arquivoContadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_arquivo_contador arquivoContador = new form_arquivo_contador(cnpjtoolStripStatusLabel.Text);

            arquivoContador.Show();
        }

        private void consultaInserçãoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            form_clientes clientes = new form_clientes(cnpjtoolStripStatusLabel.Text);
           
                clientes.Show();
          
        }

        private void imprimirListagemToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dsClientes clientes = new dsClientes();
            datClientes.Fill(clientes.CLIENTES);

            crClientes listagemClientes = new crClientes();
            listagemClientes.SetDataSource(clientes);

            form_imprimir imprimirListagem = new form_imprimir(listagemClientes);
            imprimirListagem.Show();
        }

        private void estoqueDetalhadoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void arquivoContadorCTeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_arquivo_contador_cte arqContadorCte = new form_arquivo_contador_cte();
            arqContadorCte.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void importarPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_importar_pedidos imp = new form_importar_pedidos();
            imp.cod_webservice_empresa = cod_web_service_empresa;
            imp.Show();
        }

        private void famíliasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_familias_produto fam = new form_familias_produto();
            fam.Show();
        }

        private void vendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_vendedores vend = new form_vendedores();
            vend.Show();
        }

        private void jMacedoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_arquivo_j_macedo j = new form_arquivo_j_macedo();
            j.Show();
        }

        private void vigorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_arquivo_neogrid neo = new form_arquivo_neogrid();
            neo.Show();
        }

        private void contasCorrentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_cc cc = new form_cc(); 
            cc.Show();
        }

        private void pedidosToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            form_pesquisa_vendas ven = new form_pesquisa_vendas(cnpjtoolStripStatusLabel.Text);
            ven.Show();
        }

        private void vendasFaturadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_pesquisa_comissao comissao = new form_pesquisa_comissao();
            comissao.Show();
        }

        private void planejamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_planejamento plan = new form_planejamento();
            plan.financeiro_limitado = financeiro_limitado;
            plan.Show();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_localiza_cliente cli = new form_localiza_cliente(false, "");
            cli.Show();

        }

        private void painelVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_painel_vendas ven = new form_painel_vendas();
            ven.Show();

        }

        private void pontoDeVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_pdv pdv = new form_pdv(cnpjtoolStripStatusLabel.Text);
            pdv.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            form_pesquisa_itens_pedido iped = new form_pesquisa_itens_pedido(cnpjtoolStripStatusLabel.Text);
            iped.Show();
        }

        private void tabelasPreçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_tabelas_produto prod = new form_tabelas_produto(cnpjtoolStripStatusLabel.Text);
            prod.Show();
        }

        private void pesquisaEEnvioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_pesquisa_nf nf = new form_pesquisa_nf(cnpjtoolStripStatusLabel.Text);
            nf.pesquisa = true;
            nf.Show();
        }

        private void pesquisaPDVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_pesquisa_vendas_pdv pdv = new form_pesquisa_vendas_pdv(cnpjtoolStripStatusLabel.Text);
            pdv.Show();
        }

        private void acceraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_arquivos_accera arqa = new form_arquivos_accera();
            arqa.Show();
        }

        private void gruposPlanosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_grupo_planos gp = new form_grupo_planos();
            gp.Show();
        }

        private void lunetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_lunet lunet = new form_lunet();
            lunet.Show();
        }

        private void entradaNotaFiscalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_nf_ent ent = new form_nf_ent();

            ent.Show();
        }

        private void consultaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            form_localiza_produto p = new  form_localiza_produto(false, cnpjtoolStripStatusLabel.Text);
            p.Show();
            //form_busca_item_estoque_mp mp = new form_busca_item_estoque_mp(cnpjtoolStripStatusLabel.Text);
            
            //mp.busca = true;
            //mp.Show();
        }

        private void cadastroToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            form_produto p = new form_produto(cnpjtoolStripStatusLabel.Text);
            p.Show();
            //form_estoque est = new form_estoque(cnpjtoolStripStatusLabel.Text);
           
            //est.Show();
        }

        private void entradaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            form_itens_nf_ent nf = new form_itens_nf_ent();
            nf.usuario_atual = usuario_atual;
            nf.Show();
        }

        private void saídaEExtornoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_saidas_estoque est = new form_saidas_estoque(cnpjtoolStripStatusLabel.Text);
           // form_baixas_conjuntas_estoque est = new form_baixas_conjuntas_estoque(cnpjtoolStripStatusLabel.Text);
            est.Show();
        }

        private void acertoPeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pesquisaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            form_localiza_cliente cl = new form_localiza_cliente(false, "");
            cl.pesquisa_fornecedor = true;
            cl.Show();
        }

        private void criarOpsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_criar_ops op = new form_criar_ops();
            op.Show();
        }

        private void pesquisaOpsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_os_entregues os = new form_os_entregues();
            os.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            form_xmls x = new form_xmls();
            x.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form_selecionar_empresa emp = new form_selecionar_empresa();
            try
            {
                emp.busca_dentro = true;
                emp.ShowDialog();
            }
            finally
            {
                empresatoolStripStatusLabel.Text = emp.empresa_emissora;
                cnpjtoolStripStatusLabel.Text = emp.cnpj_empresa_emissora;
                cnpjArtesanal = emp.cnpj_empresa_emissora;
                labelEmpresa.Text = emp.empresa_emissora;
            }
        }

        private void travaFinanceiroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_trava_financeiro f = new form_trava_financeiro();
            f.Show();
        }

        private void terminalStatusSimplicadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_terminal_simples ter = new form_terminal_simples();
            ter.Show();
        }

        private void romaneioDeSeparaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_separacao sep = new form_separacao(cnpjtoolStripStatusLabel.Text);
            sep.cod_usuario = cod_usuario_atual;
            sep.Show();
        }

        private void camaraQuenteEBicoUenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_camara_quente_bico f = new form_camara_quente_bico();
            f.Show();
        }

        private void cadastroConsultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_orcamentos orc = new form_orcamentos(cnpjtoolStripStatusLabel.Text);
            orc.Show();
        }

        private void gavetasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_gavetas f = new form_gavetas();
            f.Show();
        }

        private void pesosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_pesos_molde f = new form_pesos_molde();
            f.Show();
        }

        private void operaçõesPorPesoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_operacoes_peso f = new form_operacoes_peso();
            f.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            form_tipos_operacoes to = new form_tipos_operacoes();
            to.Show();
        }

        private void máquinasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            form_maquinas m = new form_maquinas();
            m.Show();
        }

        private void orçamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void PCPToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FaturamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nCMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_ncm ncm = new form_ncm();
            ncm.Show();
        }

        private void grupoXOperaçõesPrazoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_grupos_operacoes gp = new form_grupos_operacoes();
            gp.Show();
        }

        private void btn_cliente_Click(object sender, EventArgs e)
        {
            form_clientes form_clientes = new form_clientes(cnpjtoolStripStatusLabel.Text);
            form_clientes.Show();
        }

        private void btn_fornecedor_Click(object sender, EventArgs e)
        {
            form_clientes form_clientes = new form_clientes(cnpjtoolStripStatusLabel.Text);
            form_clientes.fornecedor = true;
            form_clientes.Show();
        }

        private void itensCompradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_pesquisa_itens_pedidos_compra itens = new form_pesquisa_itens_pedidos_compra();
            itens.Show();
        }

        private void geraçãoEmLoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_geracao_tp tp = new form_geracao_tp(cnpjtoolStripStatusLabel.Text);
            tp.Show();
        }

        private void testeGridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_teste_dgv teste = new form_teste_dgv();
            teste.Show();

        }

        private void btn_pecas_Click(object sender, EventArgs e)
        {
            form_produto p = new form_produto(cnpjtoolStripStatusLabel.Text);
            p.Show();
        }

        private void btn_planejamento_Click(object sender, EventArgs e)
        {
            form_planejamento p = new form_planejamento();
            p.Show();
        }

        private void btn_nf_Click(object sender, EventArgs e)
        {
            form_faturamento f = new form_faturamento(cnpjtoolStripStatusLabel.Text);
            f.Show();
        }

        private void btn_estoque_Click(object sender, EventArgs e)
        {
            form_localiza_produto p = new form_localiza_produto(false, cnpjtoolStripStatusLabel.Text);
            p.Show();
        }

        private void btn_nf_entrada_Click(object sender, EventArgs e)
        {
            form_nf_ent n = new form_nf_ent();
            n.Show();
        }

        private void btn_pedido_compra_Click(object sender, EventArgs e)
        {
            form_pedido_compra p = new form_pedido_compra(cnpjtoolStripStatusLabel.Text);
            p.Show();
        }

        private void btn_orcamento_Click(object sender, EventArgs e)
        {
            form_pedidos p = new form_pedidos(cnpjtoolStripStatusLabel.Text);
            p.Show();
        }

        private void recalcularEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_recalcular_estoque rec = new form_recalcular_estoque();
            rec.Show();
        }

        


    }
}