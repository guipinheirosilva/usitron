using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace Evolucao
{
    public partial class form_resumo_os : Form
    {
        DataTable posicoes = new DataTable();
        public string _os;
        public form_resumo_os()
        {
            InitializeComponent();
        }

        private void abrir_os(string os, string posicao)
        {
            try
            {
                string nova_os = os;
                dsDesenhos.Clear();
                this.datDesenhos.SelectCommand.CommandText =
                    "SELECT * FROM DESENHOS WHERE N_OS_PECA = '" + nova_os + "'";
                this.fbConnection1.Open();
                this.datDesenhos.SelectCommand.Connection = fbConnection1;
                this.datDesenhos.SelectCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
                datDesenhos.Fill(DESENHOS);
                if (tb_os.Text == "")
                {
                    MessageBox.Show("Essa OS não existe");
                }
                else
                {
                    selecinar_posicoes();
                    selecionar_tabelas("%");
                }
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
            somar_todos_custos();
        }



        private void selecionar_tabelas(string posicao)
        {
            selecionar_apontamentos(posicao);
            selecionar_terceiros(posicao);
            selecionar_compras(posicao);
            selecionar_saidas_estoque(posicao);
        }
        private void selecionar_compras(string _posicao)
        {
            try
            {
                string os = " AND OP_ITEM_PED = '" + tb_os.Text + "'";
                string posicao = " AND (POSICAO_ITEM_PED like '" + _posicao + "' OR POSICAO_ITEM_PED IS NULL)";
                dsItens_ped.Clear();
                datItens_ped.SelectCommand.CommandText =
                   "SELECT ipc.* FROM ITENS_PEDIDO_COMPRA ipc LEFT JOIN itens_nota_ent ine ON ipc.cod_item_ped = ine.cod_item_ped_item_ent WHERE 1 = 1 " +
                   os + posicao +
                   " UNION SELECT ipc.* FROM ITENS_PEDIDO_COMPRA ipc LEFT JOIN itens_nf_entrada ine ON ipc.cod_item_ped = ine.PEDIDO_COMPRA_ITENS_NF_ENT WHERE 1 = 1 " +
                    os + posicao;
                datItens_ped.SelectCommand.Connection = fbConnection1;
                fbConnection1.Open();
                datItens_ped.SelectCommand.ExecuteNonQuery();
                datItens_ped.Fill(ITENS_PEDIDO_COMPRA);
                fbConnection1.Close();
                somar_compras();

            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void somar_compras()
        {
            double valor_compras = 0;
            for (int i = 0; i < dgvItens_ped.RowCount; i++)
            {
                try
                {
                    valor_compras = valor_compras + Convert.ToDouble(dgvItens_ped.Rows[i].Cells["col_valor_total"].Value.ToString());
                }
                catch { }
            }
            tb_valor_compras.Text = valor_compras.ToString("n2");
        }

        private void selecionar_saidas_estoque(string _posicao)
        {
            try
            {
                //AQUI O CAMPO POSICAO PODE ALTERNAR DEPENDENDO DA EMPRESA (COND_PGTO, N_PDF, ETC)
                dsSaida_estoque.Clear();
                this.datSaida_estoque.SelectCommand.CommandText =
                "SELECT estoque.*, ine.nf_item_ent FROM ESTOQUE_SAIDA estoque INNER JOIN OP op ON " +
                "estoque.OP_ESTOQUE_SAIDA = op.COD_OP INNER JOIN itens_nota_ent ine ON " +
                "estoque.lote_estoque_saida = ine.lote_item_ent WHERE op.DESENHO_OP_ATUAL = '" + tb_os.Text + "' " +
                "AND op.N_PDF like '" + _posicao + "' " +
                "ORDER BY estoque.COD_ESTOQUE_SAIDA DESC";
                this.fbConnection1.Open();
                this.datSaida_estoque.SelectCommand.Connection = fbConnection1;
                this.datSaida_estoque.SelectCommand.ExecuteNonQuery();
                datSaida_estoque.Fill(ESTOQUE_SAIDA);
                this.fbConnection1.Close();
                somar_saidas();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void somar_saidas()
        {
            double total_saidas = 0;
            double valor_unit_item = 0;
            double valor_saida = 0;
            int cont = 0;

            for (int i = 0; i < dgvSaidas.RowCount; i++)
            {
                for (int j = 0; j < dgvItens_ped.RowCount; j++)
                {
                    try
                    {
                        if (dgvSaidas.Rows[i].Cells["col_lote"].Value.ToString() == dgvItens_ped.Rows[j].Cells["col_lote_compras"].Value.ToString())
                        {
                            cont++;
                        }
                    }
                    catch
                    { }
                }
                if (cont == 0)
                {
                    valor_unit_item = buscar_valor_item_saida(dgvSaidas.Rows[i].Cells["col_cod_saida"].Value.ToString());
                    valor_saida = valor_unit_item * Convert.ToDouble(dgvSaidas.Rows[i].Cells["col_qtde_saida"].Value.ToString());
                    dgvSaidas.Rows[i].Cells["col_valor_saida"].Value = valor_saida.ToString();
                    total_saidas = total_saidas + valor_saida;
                }
                else
                {
                    valor_unit_item = 0;
                    valor_saida = 0;
                    dgvSaidas.Rows[i].Cells["col_valor_saida"].Value = valor_saida.ToString();
                    total_saidas = total_saidas + valor_saida;
                }
            }
            tb_valor_saidas_estoque.Text = total_saidas.ToString("n2");
        }

        private double buscar_valor_item_saida(string cod)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT VALOR_UNIT_ESTOQUE FROM ESTOQUE WHERE COD_ESTOQUE = '" + cod + "'";
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.SelectCommand = select;
                DataSet dsTabela = new DataSet();
                datTabela.Fill(dsTabela);
                fbConnection1.Close();
                foreach (DataRow dr in dsTabela.Tables[0].Rows)
                {
                    try
                    {
                        return Convert.ToDouble(dr[0].ToString());
                    }
                    catch
                    {
                        return 0;
                    }
                }
                return 0;
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
                return 0;
            }
        }


        private void selecionar_terceiros(string _posicao)
        {
            try
            {
                string op = " AND OS_ITEM_TERCEIRO = '" + tb_os.Text + "'";
                string posicao = " AND POSICAO_ITEM_TERCEIRO like '" + _posicao + "'";

                dsItens_terceiros.Clear();
                datItens_terceiros.SelectCommand.CommandText =
                    "SELECT * FROM ITENS_TERCEIROS INNER JOIN ROTAS_CAMPO ON ITENS_TERCEIROS.ROTA_ITEM_TERCEIRO = ROTAS_CAMPO.COD_ROTA_CAMPO WHERE DATA_ENTRADA_ITEM_TERCEIRO IS NOT NULL" +
                    op + posicao;
                datItens_terceiros.SelectCommand.Connection = fbConnection1;
                fbConnection1.Open();
                datItens_terceiros.SelectCommand.ExecuteNonQuery();
                datItens_terceiros.Fill(ITENS_TERCEIROS);
                fbConnection1.Close();
                somar_terceiros();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void somar_terceiros()
        {
            double valor_terceiros = 0;
            for (int i = 0; i < dgvItens_terceiros.RowCount; i++)
            {
                try
                {
                    valor_terceiros = valor_terceiros + Convert.ToDouble(dgvItens_terceiros.Rows[i].Cells["col_valor"].Value.ToString());
                }
                catch { }
            }
            tb_valor_terceiros.Text = valor_terceiros.ToString("n2");
        }

        private void selecionar_apontamentos(string _posicao)
        {
            try
            {
                double valor_todas_operacoes = 0;
                dgvApontamentos.Rows.Clear();
                //string os = " AND ap.DESENHO_AP = '" + tb_os.Text + "' ";
               // string posicao = " AND ap.POSICAO_AP like '" + _posicao + "' ";
                string os = " AND rotas.DESENHO_CAMPO = '" + tb_os.Text + "' ";
                string posicao = " AND rotas.N_PDF_CAMPO like '" + _posicao + "' ";
                DataGridViewCell cell = new DataGridViewTextBoxCell();
                DataGridViewColumn column1 = new DataGridViewColumn();
                DataGridViewColumn column2 = new DataGridViewColumn();
                DataGridViewColumn column3 = new DataGridViewColumn();
                DataGridViewColumn column4 = new DataGridViewColumn();
                column1.CellTemplate = cell;
                column2.CellTemplate = cell;
                column3.CellTemplate = cell;
                column4.CellTemplate = cell;
                
                dgvApontamentos.Columns.Add(column1);
                dgvApontamentos.Columns.Add(column2);
                dgvApontamentos.Columns.Add(column3);
                dgvApontamentos.Columns.Add(column4);
                dgvApontamentos.Columns[0].Width = 100;
                dgvApontamentos.Columns[0].HeaderText = "Operação";
                dgvApontamentos.Columns[1].Width = 100;
                dgvApontamentos.Columns[1].HeaderText = "Horas";
                dgvApontamentos.Columns[2].Width = 100;
                dgvApontamentos.Columns[2].HeaderText = "Valor Total";
                dgvApontamentos.Columns[3].Width = 100;
                dgvApontamentos.Columns[3].HeaderText = "Horas Previstas";

                try
                {
                    /*
                    FbCommand select = new FbCommand();
                    select.Connection = fbConnection1;
                    fbConnection1.Open();
                    select.CommandText =
                        "SELECT TIPO FROM TIPOS_OPERACOES";
                    FbDataAdapter datTabela = new FbDataAdapter();
                    datTabela.SelectCommand = select;
                    DataSet dsTabela = new DataSet();
                    datTabela.Fill(dsTabela);
                    fbConnection1.Close();
                    
                     * 
                    int i = 0;
                    foreach (DataRow dr in dsTabela.Tables[0].Rows)
                    {
                     * */
                    int i = 0;
                        FbCommand select_operacao = new FbCommand();
                        select_operacao.Connection = fbConnection1;
                        fbConnection1.Open();
                        select_operacao.CommandText =
                            //    "SELECT SUM(ap.SALDO_HORAS_AP),SERVICO_EXTERNO_AP FROM APONTAMENTOS ap WHERE 1 = 1 " +
                            //    os + posicao + " AND OPERACAO_AP like '" + dr[0].ToString() + "' GROUP BY SERVICO_EXTERNO_AP"; 
                            //      "SELECT SUM(ap.SALDO_HORAS_AP), OPERACAO_AP FROM APONTAMENTOS ap INNER JOIN ROTAS_CAMPO rotas ON ap.ROTA_AP = rotas.COD_ROTA_CAMPO WHERE 1 = 1 " +
                            //     os + posicao + " AND (SERVICO_EXTERNO_AP != '1' OR SERVICO_EXTERNO_AP IS NULL) GROUP BY OPERACAO_AP"; 
                        "SELECT SUM(SALDO_HORAS), OPERACAO_CAMPO, SUM(PREVISAO_PRODUCAO) FROM ROTAS_CAMPO rotas WHERE 1 = 1 " +
                        os + posicao + " AND (FORNECEDOR_SERVICO_EXTERNO IS NULL) GROUP BY OPERACAO_CAMPO";
                       FbDataAdapter datOperacao = new FbDataAdapter();
                        datOperacao.SelectCommand = select_operacao;
                        DataSet dsOperacao = new DataSet();
                        datOperacao.Fill(dsOperacao); 
                        fbConnection1.Close();
                        string qtde_horas = "0";
                        
                        foreach (DataRow dr_operacao in dsOperacao.Tables[0].Rows)
                        {
                            try
                            {
                                qtde_horas = dr_operacao[0].ToString();
                                if (Convert.ToDouble(qtde_horas) > 0)
                                {
                                    string valor_hora = buscar_valor_hora(dr_operacao[1].ToString(), tb_cliente.Text);
                                    double valor_total = 0;
                                    try
                                    {
                                      //  if (dr_operacao[1].ToString() != "1")
                                      //  {
                                            valor_total = Convert.ToDouble(valor_hora) * Convert.ToDouble(qtde_horas);
                                        //}
                                       // else
                                       // {
                                      //      valor_total = 0;
                                      //  }
                                    }
                                    catch { }
                                    DataGridViewRow row = new DataGridViewRow();

                                    dgvApontamentos.Rows.Add(row);
                                    valor_todas_operacoes = valor_todas_operacoes + valor_total;
                                    dgvApontamentos.Rows[i].Cells[0].Value = dr_operacao[1].ToString();
                                    dgvApontamentos.Rows[i].Cells[1].Value = dr_operacao[0].ToString();
                                    dgvApontamentos.Rows[i].Cells[2].Value = valor_total.ToString();
                                    dgvApontamentos.Rows[i].Cells[3].Value = dr_operacao[2].ToString();
                                    i++;
                                    //valor_todas_operacoes = valor_todas_operacoes + valor_total;
                                }
                            }
                            catch { }
                        //}
                    }
                }
                catch (Exception a)
                {
                    fbConnection1.Close();
                    MessageBox.Show(a.ToString());
                }
                tb_valor_servicos.Text = valor_todas_operacoes.ToString("n2");
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private string buscar_valor_hora(string _operacao, string _cliente)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT valor.VALOR_HORA_VOC FROM VALOR_OPERACAO_CLIENTE valor INNER JOIN CLIENTES cliente ON " + 
                    " valor.CNPJ_CLIENTE_VOC = cliente.CNPJ WHERE cliente.RAZAO_SOCIAL = '" + _cliente + "'" + 
                    " AND valor.OPERACAO_VOC = '" + _operacao + "'";
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.SelectCommand = select;
                DataSet dsTabela = new DataSet();
                datTabela.Fill(dsTabela);
                fbConnection1.Close();
                foreach (DataRow dr in dsTabela.Tables[0].Rows)
                {
                    return dr[0].ToString();
                }
                return "0";
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
                return "0";
            }
        }

        private void selecinar_posicoes()
        {
            try
            {
                posicoes.Clear();
                FbCommand comando_select = new FbCommand();
                comando_select.Connection = fbConnection1;

                comando_select.CommandText = "SELECT COND_PGTO, FERRAMENTA_OP, N_PDF, COD_OP" +
                " FROM OP WHERE DESENHO_OP_ATUAL LIKE '" + tb_os.Text + //"" + 
                "' ORDER BY COND_PGTO";

                fbConnection1.Open();
                FbDataAdapter opDataAdapter = new FbDataAdapter();
                opDataAdapter.SelectCommand = comando_select;
                opDataAdapter.Fill(posicoes);
                dgvPosicoes.DataSource = posicoes;
                //dgvPosicoes.DataMember = posicoes.TableName;
                dgvPosicoes.Columns[0].Width = 60;
                dgvPosicoes.Columns[1].Width = 60;
                fbConnection1.Close();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            abrir_os(tb_os.Text, "%");
            tb_posicao_selecionada.Text = "%";
        }

        private void somar_todos_custos()
        {
            double compras = 0, terceiros = 0, saidas = 0, servicos = 0;
            try
            {
                compras = Convert.ToDouble(tb_valor_compras.Text);
            }
            catch { }
            try
            {
                terceiros = Convert.ToDouble(tb_valor_terceiros.Text);
            }
            catch { }
            try
            {
                saidas = Convert.ToDouble(tb_valor_saidas_estoque.Text);
            }
            catch { }
            try
            {
                servicos = Convert.ToDouble(tb_valor_servicos.Text);
            }
            catch { }
            double total = compras + terceiros + saidas + servicos;
            tb_total_os.Text = total.ToString("n2");
        }

        private void form_resumo_os_Load(object sender, EventArgs e)
        {
            if (_os != "")
            {
                tb_posicao_selecionada.Text = "%";
                tb_os.Text = _os;
                abrir_os(_os, "%");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                double horas_prev = 0;
                try
                {
                    // horas_prev = Convert.ToDouble(tb_ho
                }
                catch { }
                dsResumo_os resumo = new dsResumo_os();
                resumo.Informacoes.AddInformacoesRow(tb_peca.Text, tb_cliente.Text, tb_os.Text, Convert.ToDouble(tb_valor_servicos.Text),
                    Convert.ToDouble(tb_valor_saidas_estoque.Text), Convert.ToDouble(tb_valor_terceiros.Text),
                    Convert.ToDouble(tb_valor_compras.Text), buscar_valor_outros(), horas_prev);
                for (int i = 0; i < dgvApontamentos.RowCount; i++)
                {
                    double horas = 0, valor = 0, previstas = 0;
                    try
                    {
                        horas = Convert.ToDouble(dgvApontamentos.Rows[i].Cells[1].Value.ToString());
                    }catch{}
                    try
                    {
                        valor = Convert.ToDouble(dgvApontamentos.Rows[i].Cells[2].Value.ToString());
                    }catch{}
                    try
                    {
                        previstas = Convert.ToDouble(dgvApontamentos.Rows[i].Cells[3].Value.ToString());
                    }catch{}

                    resumo.Totais_operacoes.AddTotais_operacoesRow(dgvApontamentos.Rows[i].Cells[0].Value.ToString(),
                        horas,
                        valor, 
                        previstas
                        );
                }

                string op = " AND OS_ITEM_TERCEIRO = '" + tb_os.Text + "'";
    
                FbCommand select = new FbCommand();
                select.CommandText =
                      "SELECT i.OPERACAO_ITEM_TERCEIRO, SUM(i.VALOR_ITEM_TERCEIRO), SUM(i.HORAS_ITEM_TERCEIRO) FROM ITENS_TERCEIROS i INNER JOIN ROTAS_CAMPO ON " + 
                      "i.ROTA_ITEM_TERCEIRO = ROTAS_CAMPO.COD_ROTA_CAMPO " + 
                      "WHERE DATA_ENTRADA_ITEM_TERCEIRO IS NOT NULL" +
                      op + 
                      " GROUP BY i.OPERACAO_ITEM_TERCEIRO ";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach(DataRow dr in dtSelect.Rows)
                {
                    try
                    {
                        double valor = 0;
                        double horas = 0;
                        try
                        {
                            valor = Convert.ToDouble(dr[1].ToString());
                        }
                        catch { }
                        try
                        {
                            horas = Convert.ToDouble(dr[2].ToString());
                        }
                        catch { }
                        resumo.Totais_terceiros.AddTotais_terceirosRow(dr[0].ToString(), 
                            valor, 
                            horas);
                    }
                    catch { }

                }

                crResumo_os cr = new crResumo_os();
                cr.SetDataSource(resumo);
                form_imprimir imprime = new form_imprimir(cr);
                imprime.Show();

                /*Exibir os itens comprados da OS*/
                FbDataAdapter datItensComprados = new FbDataAdapter();
                FbCommand selectItensComprados = new FbCommand();

                try
                {
                    selectItensComprados.CommandText =  
                        "select " +
                        "    pc.cod_ped pedido, " +
                        "    pc.nome_forn_ped fornecedor, " +
                        "    ipc.op_item_ped os, " +
                        "    ipc.posicao_item_ped posicao, " +
                        "    ipc.descricao_item_ped descricao, " +
                        "    ipc.qtde_item_ped qtde, " +
                        "    ipc.unid_item_ped unidade, " +
                        "    ipc.valor_unit_item_ped valor_unitario, " +
                        "    ipc.valor_total_item_ped valor_total " +
                        "from itens_pedido_compra ipc " +
                        "inner join pedido_compra pc on pc.cod_ped = ipc.n_pedido_item_ped " +
                        "where ipc.op_item_ped = '" + tb_os.Text + "' " +
                        "order by ipc.cod_item_ped";
                    datItensComprados.SelectCommand = selectItensComprados;
                    datItensComprados.SelectCommand.Connection = fbConnection1;
                    fbConnection1.Open();
                    datItensComprados.SelectCommand.ExecuteNonQuery();
                    datItensComprados.Fill(resumo.compras);
                    fbConnection1.Close();

                    crItensCompradosResumo itensCompradosResumo = new crItensCompradosResumo();
                    itensCompradosResumo.SetDataSource(resumo);
                    itensCompradosResumo.SetParameterValue(itensCompradosResumo.Parameter_os.ParameterFieldName.ToString(), tb_os.Text);

                    form_imprimir imprime2 = new form_imprimir(itensCompradosResumo);
                    imprime2.Show();
                }
                catch(Exception a)
                {
                    fbConnection1.Close();
                    MessageBox.Show("Houve um erro ao selecionar os itens comprados da OS!\nErro: " + a.Message);
                }
            }
            catch {
                MessageBox.Show("Erro na impressão");
            }
        }

        private double buscar_valor_outros()
        {
            
            try
            {
                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT distinct(COD_PED), ite.op_item_ped, VALOR_REAL_IPI_PED, VALOR_OUTRAS_DESP_PED FROM PEDIDO_COMPRA ped " +
                    "right JOIN itens_pedido_compra ite ON ped.cod_ped = ite.n_pedido_item_ped where ite.op_item_ped = '" + tb_os.Text + "'";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                double outros = 0;
                foreach (DataRow dr in dtSelect.Rows)
                {
                    double despesas = 0, ipi = 0;
                    try
                    {
                        despesas = Convert.ToDouble(dr[3].ToString());
                    } catch{}
                    try
                    {
                        ipi = Convert.ToDouble(dr[2].ToString());
                    } catch{}

                    outros = outros + ipi + despesas;
                }

                return outros;
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
                return 0;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Todas as posições e operações da OS serão finalizados, tem certeza?",
                "Confirma?", MessageBoxButtons.YesNo))
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
                        try
                        {
                            string cod_op = tb_posicao_selecionada.Text;

                            FbCommand update_desenho = new FbCommand();
                            update_desenho.Connection = fbConnection1;
                            fbConnection1.Open();
                            update_desenho.CommandText =
                                "UPDATE DESENHOS SET FINALIZADA_PECA = '1' WHERE N_OS_PECA = '" + tb_os.Text + "'";
                            FbDataAdapter datUpdate_desenho = new FbDataAdapter();
                            datUpdate_desenho.UpdateCommand = update_desenho;
                            datUpdate_desenho.UpdateCommand.ExecuteNonQuery();
                            fbConnection1.Close();
                            

                            finalizar_todas_ops_da_os(tb_os.Text, cod_op);
                            apagar_todos_apontamentos_os(tb_os.Text, cod_op);

                            string where = "";
                            if (cod_op != "%")
                                where = " AND COD_OP = '" + cod_op + "'";

                            FbCommand select_op = new FbCommand();
                            select_op.Connection = fbConnection1;
                            fbConnection1.Open();
                            select_op.CommandText =
                                "SELECT COD_OP FROM OP WHERE DESENHO_OP_ATUAL = '" + tb_os.Text + "' " + where;
                            FbDataAdapter datOp = new FbDataAdapter();
                            datOp.SelectCommand = select_op;
                            DataSet dsOp = new DataSet();
                            datOp.Fill(dsOp);
                            fbConnection1.Close();
                            foreach (DataRow dr_op in dsOp.Tables[0].Rows)
                            {
                                try
                                {
                                    FbCommand select_rotas = new FbCommand();
                                    select_rotas.Connection = fbConnection1;
                                    fbConnection1.Open();
                                    select_rotas.CommandText =
                                        "SELECT COD_ROTA_CAMPO FROM ROTAS_CAMPO WHERE OP_ROTA = '" + dr_op[0].ToString() + "' ";
                                    FbDataAdapter datRotas = new FbDataAdapter();
                                    datRotas.SelectCommand = select_rotas;
                                    DataSet dsRotas = new DataSet();
                                    datRotas.Fill(dsRotas);
                                    fbConnection1.Close();
                                    foreach (DataRow dr_rotas in dsRotas.Tables[0].Rows)
                                    {
                                        DateTime data_fim = DateTime.Now;
                                        DateTime hora_fim = DateTime.Now;
                                        DateTime data_inicio = DateTime.Now;
                                        DateTime hora_inicio = DateTime.Now;
                                        buscar_data_hora_fechamento_no_ultimo_apontamento(dr_rotas[0].ToString(), dr_op[0].ToString(),
                                            out data_fim, out hora_fim, out data_inicio, out hora_inicio);

                                        FbCommand update_rota = new FbCommand();
                                        update_rota.Connection = fbConnection1;
                                        fbConnection1.Open();
                                        update_rota.CommandText =
                                            "UPDATE ROTAS_CAMPO SET HORA_FECHAMENTO = '" + hora_fim.ToShortTimeString() + "', " +
                                            "DATA_FECHAMENTO = '" + data_fim.ToShortDateString().Replace("/", ".") + "', " +
                                            "HORA_ENTRADA = '" + hora_inicio.ToShortTimeString() + "', " +
                                            "DATA_ENTRADA = '" + data_inicio.ToShortDateString().Replace("/", ".") + "', " +
                                            "POSICAO_ATUAL = 'FINALIZADO', OBSERVACAO_CAMPO = OBSERVACAO_CAMPO || ' MODIFICADO PELA FINALIZAÇÃO DE OS' " +
                                            "WHERE COD_ROTA_CAMPO = '" + dr_rotas[0].ToString() + "' AND " +
                                            "(DATA_FECHAMENTO IS NULL OR POSICAO_ATUAL = 'NÃO NECESSÁRIA')";
                                        datRotas.UpdateCommand = update_rota;
                                        datRotas.UpdateCommand.ExecuteNonQuery();
                                        fbConnection1.Close();

                                        FbCommand update_semana = new FbCommand();
                                        update_semana.Connection = fbConnection1;
                                        fbConnection1.Open();
                                        update_semana.CommandText =
                                            "UPDATE HORAS_SEMANA SET SITUACAO_ROTA_SEMANA = 'FINALIZADO'" +
                                            " WHERE ROTA_HORAS_SEMANA = '" + dr_rotas[0].ToString() + "'";
                                        FbDataAdapter datUpdate_semana = new FbDataAdapter();
                                        datUpdate_semana.UpdateCommand = update_semana;
                                        datUpdate_semana.UpdateCommand.ExecuteNonQuery();
                                        fbConnection1.Close();

                                        FbCommand update = new FbCommand();
                                        update.Connection = fbConnection1;
                                        fbConnection1.Open();
                                        update.CommandText =
                                            "UPDATE HORAS_SEMANA SET DATA_EXCLUSAO_SEMANA = '" +
                                            DateTime.Now.ToShortDateString().Replace("/", ".") +
                                            "', EXCLUIDO_ONDE_SEMANA = 'FECHAMENTO OS' WHERE ROTA_HORAS_SEMANA = '" +
                                            dr_rotas[0].ToString() +
                                            "' AND (HORAS_REAIS_OPERACAO IS NULL OR HORAS_REAIS_OPERACAO = 0) " +
                                            "AND DATA_EXCLUSAO_SEMANA IS NULL";
                                        FbDataAdapter datUpdate = new FbDataAdapter();
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
                        }
                        catch (Exception a)
                        {
                            fbConnection1.Close();
                            MessageBox.Show(a.ToString());
                        }
                    }
                }
            }
        }

        private void finalizar_todas_ops_da_os(string os, string cod_op)
        {
            try
            {
                string where = "";
                if (cod_op != "%")
                    where = " AND COD_OP = '" + cod_op + "'";

                FbCommand update_os = new FbCommand();
                update_os.Connection = fbConnection1;
                fbConnection1.Open();
                update_os.CommandText =
                    "UPDATE OP SET POSICAO_ATUAL_OP = 'ITEM_FINALIZADO', FINALIZADO_OP = '1' " +
                " WHERE (FINALIZADO_OP IS NULL OR FINALIZADO_OP = 0) AND DESENHO_OP_ATUAL = '" + os + "' " + where;
                FbDataAdapter datOs = new FbDataAdapter();
                datOs.UpdateCommand = update_os;
                datOs.UpdateCommand.ExecuteNonQuery();
                fbConnection1.Close();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void buscar_data_hora_fechamento_no_ultimo_apontamento(string rota, string cod_op, 
            out DateTime data_fim, out DateTime hora_fim,
            out DateTime data_inicio, out DateTime hora_inicio)
        {
            data_fim = DateTime.Now;
            hora_fim = DateTime.Now;
            data_inicio = DateTime.Now;
            hora_inicio = DateTime.Now;
            try
            {
                //PEGANDO INICIO
                FbCommand select_inicio = new FbCommand();
                select_inicio.Connection = fbConnection1;
                fbConnection1.Open();
                select_inicio.CommandText =
                    "SELECT DATA_INICIO_AP, HORA_INICIO_AP FROM APONTAMENTOS WHERE ROTA_AP = '" + rota + "' ORDER BY 1,2";
                FbDataAdapter datInicio = new FbDataAdapter();
                datInicio.SelectCommand = select_inicio;
                DataSet dsInicio = new DataSet();
                datInicio.Fill(dsInicio);
                fbConnection1.Close();
                foreach (DataRow dr_inicio in dsInicio.Tables[0].Rows)
                {
                    try
                    {
                        data_inicio = Convert.ToDateTime(dr_inicio[0].ToString());
                        hora_inicio = Convert.ToDateTime(dr_inicio[1].ToString());
                        break;
                    }
                    catch { }
                }
                if (dsInicio.Tables[0].Rows.Count == 0)
                { //SE NÃO TIVER APONTAMENTO IRÁ PEGAR A DATA DE FECHAMENTO PREVISTO DA OP COMO DATA DE FECHAMENTO
                    FbCommand select_op_inicio = new FbCommand();
                    select_op_inicio.Connection = fbConnection1;
                    fbConnection1.Open();
                    select_op_inicio.CommandText =
                        "SELECT DATA_ENTRADA_OP FROM OP WHERE COD_OP = '" + cod_op + "'";
                    FbDataAdapter datTabela_op_inicio = new FbDataAdapter();
                    datTabela_op_inicio.SelectCommand = select_op_inicio;
                    DataSet dsTabela_op_inicio = new DataSet();
                    datTabela_op_inicio.Fill(dsTabela_op_inicio);
                    fbConnection1.Close();
                    foreach (DataRow dr_op_inicio in dsTabela_op_inicio.Tables[0].Rows)
                    {
                        try
                        {
                            data_fim = Convert.ToDateTime(dr_op_inicio[0].ToString());
                            hora_fim = Convert.ToDateTime("00:00:00");
                        }
                        catch
                        {
                            data_fim = DateTime.Now;
                            hora_fim = Convert.ToDateTime("00:00:00");

                        }
                    }
                }
                //PEGANDO FINALIZACAO
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT DATA_FIM_AP, HORA_FIM_AP FROM APONTAMENTOS WHERE ROTA_AP = '" + rota + "' ORDER BY 1,2 DESC";
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.SelectCommand = select;
                DataSet dsTabela = new DataSet();
                datTabela.Fill(dsTabela);
                fbConnection1.Close();
                foreach (DataRow dr in dsTabela.Tables[0].Rows)
                {
                    try
                    {
                        data_fim = Convert.ToDateTime(dr[0].ToString());
                        hora_fim = Convert.ToDateTime(dr[1].ToString());
                        break;
                    }
                    catch { }
                }
                if (dsTabela.Tables[0].Rows.Count == 0)
                { //SE NÃO TIVER APONTAMENTO IRÁ PEGAR A DATA DE FECHAMENTO PREVISTO DA OP COMO DATA DE FECHAMENTO
                    FbCommand select_op = new FbCommand();
                    select_op.Connection = fbConnection1;
                    fbConnection1.Open();
                    select_op.CommandText =
                        "SELECT ENTREGA_DIA FROM OP WHERE COD_OP = '" + cod_op + "'";
                    FbDataAdapter datTabela_op = new FbDataAdapter();
                    datTabela_op.SelectCommand = select_op;
                    DataSet dsTabela_op = new DataSet();
                    datTabela_op.Fill(dsTabela_op);
                    fbConnection1.Close();
                    foreach (DataRow dr_op in dsTabela_op.Tables[0].Rows)
                    {
                        try
                        {
                            data_fim = Convert.ToDateTime(dr_op[0].ToString());
                            hora_fim = Convert.ToDateTime("00:00:00");
                        }
                        catch
                        {
                            data_fim = DateTime.Now;
                            hora_fim = Convert.ToDateTime("00:00:00");
                        
                        }
                    }
                }

            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void apagar_todos_apontamentos_os(string os, string cod_op)
        {
            try
            {
                string where = "";
                if (cod_op != "")
                    where = " AND OS_AP = '" + cod_op + "'";

                FbCommand delete = new FbCommand();
                delete.Connection = fbConnection1;
                fbConnection1.Open();
                delete.CommandText =
                    "DELETE FROM APONTAMENTOS WHERE DATA_FIM_AP IS NULL AND DESENHO_AP = '" + os + "' " + where;
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.DeleteCommand = delete;
                datTabela.DeleteCommand.ExecuteNonQuery();
                fbConnection1.Close();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private string buscar_rotas(string cod_op)
        {
            string retorno = "não existe";
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT COD_ROTA_CAMPO FROM ROTAS_CAMPO WHERE OP_ROTA = '" + cod_op + "' ORDER BY COD_ROTA_CAMPO";
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.SelectCommand = select;
                DataSet dsTabela = new DataSet();
                datTabela.Fill(dsTabela);
                fbConnection1.Close();
                bool primeiro = true;
                foreach (DataRow dr in dsTabela.Tables[0].Rows)
                {
                    if (primeiro)
                    {
                        retorno = " AND (ROTA_AP = '" + dr[0].ToString() + "' ";
                        primeiro = false;
                    }
                    else
                    {
                        retorno = retorno + " OR ROTA_AP = '" + dr[0].ToString() + "'";
                    }
                }
                if (!primeiro)
                    retorno = retorno + ")";
                return retorno;

            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
                return retorno;
            }
        }

        private void dgvPosicoes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_posicao_selecionada.Text = dgvPosicoes.Rows[e.RowIndex].Cells[2].Value.ToString();
            tb_item_selecionado.Text = dgvPosicoes.Rows[e.RowIndex].Cells[0].Value.ToString();
            selecionar_tabelas(dgvPosicoes.Rows[e.RowIndex].Cells[2].Value.ToString());
            somar_todos_custos();
        }

        private void dgvPosicoes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void cbSomarCompras_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbSomarCompras.Checked)
                {
                    somar_compras();
                    somar_todos_custos();
                }
                else
                {
                    tb_valor_compras.Text = "0,00";
                    somar_todos_custos();
                }
            }
            catch
            {
                MessageBox.Show("Não foi possível recalcular os custos!\nEntre em contato com o suporte técnico!");
            }
        }

        private void cbSomarTerceiros_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbSomarTerceiros.Checked)
                {
                    somar_terceiros();
                    somar_todos_custos();
                }
                else
                {
                    tb_valor_terceiros.Text = "0,00";
                    somar_todos_custos();
                }
            }
            catch
            {
                MessageBox.Show("Não foi possível recalcular os custos!\nEntre em contato com o suporte técnico!");
            }
        }

        private void cbSomarServicos_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbSomarServicos.Checked)
                {
                    selecionar_apontamentos(tb_posicao_selecionada.Text);
                    somar_todos_custos();
                }
                else
                {
                    tb_valor_servicos.Text = "0,00";
                    somar_todos_custos();
                }
            }
            catch
            {
                MessageBox.Show("Não foi possível recalcular os custos!\nEntre em contato com o suporte técnico!");
            }
        }

        private void tb_valor_servicos_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbSomarSaidasEstoque_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbSomarSaidasEstoque.Checked)
                {
                    somar_saidas();
                    somar_todos_custos();
                }
                else
                {
                    tb_valor_saidas_estoque.Text = "0,00";
                    somar_todos_custos();
                }
            }
            catch
            {
                MessageBox.Show("Não foi possível recalcular os custos!\nEntre em contato com o suporte técnico!");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                dsResumo_os_geral resumo_geral = new dsResumo_os_geral();
                resumo_geral.Informacoes.AddInformacoesRow(tb_peca.Text, tb_cliente.Text, tb_os.Text, Convert.ToDouble(tb_valor_servicos.Text),
                    Convert.ToDouble(tb_valor_saidas_estoque.Text), Convert.ToDouble(tb_valor_terceiros.Text),
                    Convert.ToDouble(tb_valor_compras.Text));
                if (cbSomarServicos.Checked)
                {
                    for (int i = 0; i < dgvApontamentos.RowCount; i++)
                    {
                        resumo_geral.Totais_operacoes.AddTotais_operacoesRow(dgvApontamentos.Rows[i].Cells[0].Value.ToString(),
                            Convert.ToDouble(dgvApontamentos.Rows[i].Cells[1].Value.ToString()),
                            Convert.ToDouble(dgvApontamentos.Rows[i].Cells[2].Value.ToString()));
                    }
                } 
                if (cbSomarCompras.Checked) 
                {
                    string item = "", desc = "", uni = "", chegou = "", ped = "", forn = "";
                    int nf = 0, cheg = 0;
                    double qtde = 0, valorUnit = 0, valorTotal = 0;
                    
                    for (int i = 0; i < dgvItens_ped.RowCount; i++)
                    {
                        chegou = dgvItens_ped.Rows[i].Cells["col_chegou"].Value.ToString();
                        if (chegou.Trim() != "")
                        {
                            cheg = Convert.ToInt32(chegou);
                            nf = Convert.ToInt32(dgvItens_ped.Rows[i].Cells["col_nf_entrada"].Value.ToString());
                        }
                        ped = dgvItens_ped.Rows[i].Cells["col_pedido"].Value.ToString();
                        forn = dgvItens_ped.Rows[i].Cells["col_forn"].Value.ToString();
                        item = dgvItens_ped.Rows[i].Cells["col_item"].Value.ToString();
                        desc = dgvItens_ped.Rows[i].Cells["col_desc"].Value.ToString();
                        uni = dgvItens_ped.Rows[i].Cells["col_unid"].Value.ToString();
                        qtde = Convert.ToDouble(dgvItens_ped.Rows[i].Cells["col_qtde"].Value.ToString());
                        valorUnit = Convert.ToDouble(dgvItens_ped.Rows[i].Cells["col_valor_unit"].Value.ToString());
                        valorTotal = Convert.ToDouble(dgvItens_ped.Rows[i].Cells["col_valor_total"].Value.ToString());
                        resumo_geral.Totais_compras.AddTotais_comprasRow(item, desc, valorUnit, uni, qtde, valorTotal, cheg, nf, ped, forn);
                    }
                }
                if (cbSomarSaidasEstoque.Checked)
                {
                    for (int i = 0; i < dgvSaidas.RowCount; i++)
                    {
                        
                    }
                }
                if (cbSomarTerceiros.Checked)
                {
                    for (int i = 0; i < dgvItens_terceiros.RowCount; i++)
                    {
                        resumo_geral.Totais_terceiros.AddTotais_terceirosRow(
                            dgvItens_terceiros.Rows[i].Cells["col_operacao"].Value.ToString(),
                            Convert.ToDouble(dgvItens_terceiros.Rows[i].Cells["col_qt"].Value.ToString()),
                            dgvItens_terceiros.Rows[i].Cells["col_nome"].Value.ToString(),
                            Convert.ToDouble(dgvItens_terceiros.Rows[i].Cells["col_valor"].Value.ToString()));
                    }
                }
                crResumo_os_compras crC = new crResumo_os_compras();
                crResumo_os_estoque crE = new crResumo_os_estoque();
                crResumo_os_servicos crS = new crResumo_os_servicos();
                crResumo_os_terceiros crT = new crResumo_os_terceiros();
                crC.SetDataSource(resumo_geral);
                crE.SetDataSource(resumo_geral);
                crS.SetDataSource(resumo_geral);
                crT.SetDataSource(resumo_geral);
                crResumo_os2 cr2 = new crResumo_os2();
                cr2.SetDataSource(resumo_geral);
                form_imprimir imprime = new form_imprimir(cr2);
                imprime.Show();
            }
            catch
            {
                MessageBox.Show("Erro na impressão");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                dsPlanilha plan = new dsPlanilha();


                try
                {
                    FbCommand select_compras = new FbCommand();
                    select_compras.CommandText =
                     "SELECT ped.plano_ped, sum(itens.valor_total_item_ped) FROM ITENS_PEDIDO_COMPRA itens " +
                    "INNER JOIN PEDIDO_COMPRA ped ON ped.COD_PED = itens.N_PEDIDO_ITEM_PED " + 
                    "WHERE OP_ITEM_PED = '" + tb_os.Text + "' GROUP BY ped.plano_ped";
                    select_compras.Connection = fbConnection1;
                    fbConnection1.Open();
                    FbDataAdapter datSelect_compras = new FbDataAdapter();
                    datSelect_compras.SelectCommand = select_compras;
                    DataTable dtSelect_compras = new DataTable();
                    datSelect_compras.Fill(dtSelect_compras);
                    fbConnection1.Close();
                    foreach (DataRow dr_compras in dtSelect_compras.Rows)
                    {
                        try
                        {
                            double valor_compras = 0;
                            try
                            {
                                valor_compras = Convert.ToDouble(dr_compras[1].ToString());
                            }
                            catch { }
                            plan.OPERACAO.AddOPERACAORow(dr_compras[0].ToString(), 0, 0, 0, 0, 0, valor_compras, "COMPRAS");

                        }
                        catch
                        {

                        }
                    }

                }
                catch (Exception a)
                {
                    fbConnection1.Close();
                }


                try
                {
                     FbCommand select_ter = new FbCommand();
                    select_ter.CommandText =
                    "SELECT it.OPERACAO_ITEM_TERCEIRO, sum(it.horas_item_terceiro), SUM(it.VALOR_ITEM_TERCEIRO) FROM ITENS_TERCEIROS it " + 
                    "INNER JOIN ROTAS_CAMPO rot ON it.ROTA_ITEM_TERCEIRO = rot.COD_ROTA_CAMPO WHERE DATA_ENTRADA_ITEM_TERCEIRO IS NOT NULL" +
                    " AND OS_ITEM_TERCEIRO = '" + tb_os.Text + "' GROUP BY it.OPERACAO_ITEM_TERCEIRO";
                    select_ter.Connection = fbConnection1;
                    fbConnection1.Open();
                    FbDataAdapter datSelect_ter = new FbDataAdapter();
                    datSelect_ter.SelectCommand = select_ter;
                    DataTable dsSelect_ter = new DataTable();
                    datSelect_ter.Fill(dsSelect_ter);
                    fbConnection1.Close();
                    foreach (DataRow dr in dsSelect_ter.Rows)
                    {
                        try
                        {
                            double horas = 0, valor = 0;
                            try
                            {
                                horas = 0;// Convert.ToDouble(dr[1].ToString());
                            }
                            catch { }
                            try
                            {
                                valor = Convert.ToDouble(dr[2].ToString());
                            }
                            catch { }
                            plan.OPERACAO.AddOPERACAORow(dr[0].ToString(), 0, 0, 0, 0, horas, valor, "TERCEIROS");
                        }
                        catch { }
                    }
                    



                }
                catch (Exception a)
                {
                    fbConnection1.Close();

                } 
                



                FbCommand select = new FbCommand();
                select.CommandText =
                    "select rc.operacao_campo, op.codigo_op, vo.horas_previstas_voo, sum(rc.SALDO_HORAS), sum(rc.previsao_producao) from rotas_campo rc " +
                    "inner join op on op.cod_op = rc.op_rota " +
                    "inner join valor_operacao_os vo on vo.operacao_voo = rc.operacao_campo and vo.os_voo = rc.desenho_campo " +
                    "where 0 = 0 and (rc.FORNECEDOR_SERVICO_EXTERNO IS NULL) and rc.desenho_campo = '" + tb_os.Text + "' group by op.codigo_op, rc.operacao_campo, vo.horas_previstas_voo";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();

                datSelect.SelectCommand = select;
                DataTable dsSelect = new DataTable();
                datSelect.Fill(dsSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dsSelect.Rows)
                {
                    try
                    {
                       
                        double horas_previstas = 0;
                        try
                        {
                            horas_previstas = Convert.ToDouble(dr[2].ToString());
                        }
                        catch { }

                        double horas_prev_pos = 0;
                        try
                        {
                            horas_prev_pos = Convert.ToDouble(dr[4].ToString());
                        }
                        catch { }
                        double horas_reais = 0;
                        try
                        {
                            horas_reais = Convert.ToDouble(dr[3].ToString());
                        }
                        catch { }

                        string tipo = "";
                        if (dr[1].ToString() == "00")
                            tipo = "USINAGEM";
                        else
                        {
                            if (dr[1].ToString() == "02")
                            {
                                tipo = "ELETRODO";
                                horas_previstas = 0;
                            }
                            else
                            {
                                if (dr[1].ToString() == "01")
                                {
                                    tipo = "RETRABALHO";
                                    horas_previstas = 0;
                                    horas_prev_pos = 0;
                                }
                                else
                                    tipo = "OUTROS";
                            }
                        }


                        plan.OPERACAO.AddOPERACAORow(dr[0].ToString(), horas_previstas, 0, horas_prev_pos, 0, horas_reais, 0, tipo);
                    }
                    catch { }
                }
                plan.Informações.AddInformaçõesRow(tb_os.Text);
                crPlanilha_fechamento cr = new crPlanilha_fechamento();
                cr.SetDataSource(plan);
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
}