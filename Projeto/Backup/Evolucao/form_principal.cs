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
        public string usuario_atual;
        public string cod_usuario_atual;

        //Usado para as impressões dos relatórios de estoque
        private FbDataAdapter datEstoque;
        private dsConsulta dsEstoque;
        private FbCommand cmdEstoque;
        private form_imprimir formImp;
        private crEstoqueSintetico relEstoqueSintetico;
        private crEstoqueAnalitico relEstoqueAnalitico;

        public form_principal()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_clientes clientes = new form_clientes();
            try
            {
                clientes.ShowDialog();
            }
            finally
            {
                clientes.Dispose();
            }
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
                        }

                        definir_acessos(cod_usuario_atual);

                    }
                    else
                    {
                        this.Close();
                    }

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
                _transportes = dr["TRANSPORTES_USUARIO"].ToString();
            }

            fbConnection1.Close();
            //Cadastros Gerais

            if (_pcp == "1")
                PCPToolStripMenuItem.Visible = true;
            if (_faturamento == "1")
                FaturamentoToolStripMenuItem.Visible = true;
            if (_estoque == "1")
                estoqueToolStripMenuItem.Visible = true;
            if (_compras == "1")
                comprasToolStripMenuItem.Visible = true;
            if (_financeiro == "1")
                financeiroToolStripMenuItem.Visible = true;
            if (_transportes == "1")
                transportesToolStripMenuItem.Visible = true;
            if (_orcamentos == "1")
                pedidosToolStripMenuItem.Visible = true;

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

                
                //qualidadeToolStripMenuItem.Visible = true;
                usuáriosToolStripMenuItem.Enabled = true;
                if (_cod_usuario.ToString() == "1")
                {
                    empresaToolStripMenuItem.Enabled = true;
                    usuáriosToolStripMenuItem.Enabled = true;
                    manutençãoToolStripMenuItem.Visible = true;
                }

                //Verificando se a empresa é DOKINOS  para ativar o menu de arquivos da JMacedo
                if(empresatoolStripStatusLabel.Text.Contains("DOKINOS"))
                {
                    arquivoJMacedoToolStripMenuItem.Visible = true;
                }

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
            form_cronograma_detalhado cronograma = new form_cronograma_detalhado();
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
            FileInfo t = new FileInfo("c:\\evolucao_dokinos\\teste.TXT");
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
            System.Diagnostics.Process.Start(@"c:\evolucao_dokinos\TeamViewerQS_pt.exe");
        }

        private void períodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_periodo periodo = new form_periodo();
            periodo.Show();
        }

        private void requisiçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_requisicao requisicao = new form_requisicao();
            requisicao.Show();
        }

        private void pedidoDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_pedido_compra pedido = new form_pedido_compra();
            pedido.Show();
        }

        private void nFeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_faturamento fatura = new form_faturamento();
            fatura.Show();
        }

        private void ultimaNotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_ultima_nota ultima = new form_ultima_nota();
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
            form_requisicao req = new form_requisicao();
            req.Show();
        }

        private void pedidoDeCompraToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            form_pedido_compra ped = new form_pedido_compra();
            ped.Show();
        }

        private void requisiçõesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            form_pesquisa_requisicao req = new form_pesquisa_requisicao();
            req.Show();
        }

        private void pedidosCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_pesquisa_pedido_compra ped = new form_pesquisa_pedido_compra();
            ped.Show();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_cadastro_usuario usuario = new form_cadastro_usuario();
            usuario.Show();
        }

        private void saida_estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_saidas_estoque saida = new form_saidas_estoque();
            saida.Show();
        }

        private void almoxarifadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_estoque est = new form_estoque();
            est.Show();
        }

        private void entradaNFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_nf_entrada ent = new form_nf_entrada();
            ent.Show();
        }

        private void contasAPagarEREceberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_cp_cr cr_cp = new form_cp_cr();
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
            form_fornecedores forn = new form_fornecedores(false,"");
            forn.Show();
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
            form_pedidos ped = new form_pedidos();
            ped.Show();
        }

        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_pesquisa_pedido ped = new form_pesquisa_pedido();
            ped.Show();
        }

        private void atualizarValoresAReceberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_atualiza_cr cr = new form_atualiza_cr();
            cr.Show();
        }

        private void cadastroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            form_produto prod = new form_produto();
            prod.Show();
        }

        private void pesquisaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            form_localiza_produto localiza_item = new form_localiza_produto();
            localiza_item.ShowDialog();
            
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
            form_arquivo_j_macedo j = new form_arquivo_j_macedo();
            j.Show();
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
            form_romaneio romaneio = new form_romaneio();
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
            form_pesquisa_comissao comissao = new form_pesquisa_comissao();
            comissao.Show();
        }

        private void coletasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void entradaDelocalhostToolStripMenuItem_Click(object sender, EventArgs e)
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
            formEstoqueAnalitico estAnalitico = new formEstoqueAnalitico();
            estAnalitico.Show();
        }

        private void arquivosDeTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formArquivosTexto arquivosTexto = new formArquivosTexto();
            arquivosTexto.Show();
        }

        

        


    }
}