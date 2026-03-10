using System;
using System.Collections.Generic;
using System.Text;
using FirebirdSql.Data.FirebirdClient;
using System.Data;

namespace Evolucao
{
    class classeEstoque
    {
        public FbConnection fbConnection1 = new FbConnection();
        public bool erro = false;

        private string buscar_cod_nf_ent(string nf)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.CommandText =
               "SELECT * FROM NOTA_FISCAL_ENT WHERE N_NF_ENT = '" + nf + "'";
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
                return "0";
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                //MessageBox.Show(a.ToString());
                return "0";
            }
        }

        public void calcular_estoque(string cod_estoque)
        {
            string familia = "";
            
            string cod_sistema_produto = buscar_cod_sistema(cod_estoque, out familia);
            if (cod_estoque != "")
            {
                try
                {
                   
                    double producao = 0, entradas = 0, empenhado = 0, necessidade = 0, fisico = 0, disponivel = 0, separado = 0;
                    //puxando todas as entradas desse item
                    FbCommand select_entradas = new FbCommand();
                    select_entradas.Connection = fbConnection1;
                    fbConnection1.Open();

                    select_entradas.CommandText =
                        "SELECT sum(QDE_FAB) FROM OP WHERE COND_PGTO = '" + cod_estoque +
                        "'  AND FINALIZADO_OP = '1' ";
                    FbDataAdapter entradasDataAdapter = new FbDataAdapter();
                    entradasDataAdapter.SelectCommand = select_entradas;
                    DataSet entradasDataSet = new DataSet();
                    entradasDataAdapter.Fill(entradasDataSet);
                    fbConnection1.Close();
                    
                    foreach (DataRow dr in entradasDataSet.Tables[0].Rows)
                    {
                        try
                        {
                              entradas += Convert.ToDouble(dr[0].ToString());
                        }
                        catch {  }
                    }

                    //9999990
                    string cod_sistema_nf_ent = buscar_cod_nf_ent("9999990");

                    select_entradas.Connection = fbConnection1;
                    fbConnection1.Open();
                    select_entradas.CommandText =
                        "SELECT sum(QTDE_ITEM_ENT) " +
                        "FROM ITENS_NOTA_ENT JOIN NOTA_FISCAL_ENT ON COD_SISTEMA_NF_ITEM_ENT = COD_SISTEMA_NF_ENT " +
                        "WHERE (COD_ITEM_ENT = '" + cod_estoque + "') " +
                        //"AND QTDE_LOTE_ITEM_ENT IS NULL " + //apenas manuais
                        "AND COD_SISTEMA_NF_ITEM_ENT = '" + cod_sistema_nf_ent + "' " + 
                        "AND BAIXADO_ITEM_ENT = '1' ";
                    entradasDataAdapter.SelectCommand = select_entradas;
                    DataSet entradasDataSet2 = new DataSet();
                    entradasDataAdapter.Fill(entradasDataSet2);
                    fbConnection1.Close();
                    foreach (DataRow dr in entradasDataSet2.Tables[0].Rows)
                    {
                        try
                        {
                                entradas = entradas + Convert.ToDouble(dr[0].ToString());
                        }
                        catch { }
                    }

                    //saidas de componentes


                    select_entradas.Connection = fbConnection1;
                    
                    string _select = "SELECT sum(QTDE_ITEM_ENT) " +
                        "FROM ITENS_NOTA_ENT " +
                        "WHERE (COD_ITEM_EST_ITEM_ENT = '" + cod_estoque + "') " +
                        "AND BAIXADO_ITEM_ENT = '1' ";



                    if (familia == "Matéria Prima" || familia == "Componente")
                    {
                        //calculando saldo do lote 
                        double entrada_lote = 0, saida_lote = 0;
                        try
                        {
                            FbCommand selectEntrada_lote = new FbCommand();
                            selectEntrada_lote.Connection = fbConnection1;
                            fbConnection1.Open();
                            selectEntrada_lote.CommandText =
                                @"SELECT sum(QTDE_ITEM_ENT) as qtde, cod_itens_nota_ent 
                            FROM ITENS_NOTA_ENT 
                            WHERE (COD_ITEM_EST_ITEM_ENT = '" + cod_sistema_produto + @"') 
                            AND BAIXADO_ITEM_ENT = '1' group by cod_itens_nota_ent";
                            FbDataAdapter datSelectEntrada = new FbDataAdapter();
                            datSelectEntrada.SelectCommand = selectEntrada_lote;
                            DataTable dtSelectEntrada = new DataTable();
                            datSelectEntrada.Fill(dtSelectEntrada);
                            fbConnection1.Close();
                            foreach (DataRow dr in dtSelectEntrada.Rows)
                            {
                                entrada_lote = Convert.ToDouble(dr[0].ToString());

                                try
                                {
                                    FbCommand selectSaida_lote = new FbCommand();
                                    selectSaida_lote.Connection = fbConnection1;
                                    fbConnection1.Open();
                                    selectSaida_lote.CommandText =
                                        @"select sum(inf.qtde_item) from itens_nota inf
inner join nota_fiscal nf on inf.cod_sistema_nf_item = nf.cod_sistema_nf
inner join nfs_referenciadas nfr on inf.cod_itens_nota = nfr.cod_itens_nota_saida_nfr
inner join itens_nota_ent infe on nfr.cod_itens_nota_ent_nfr = infe.cod_itens_nota_ent
where  infe.cod_itens_nota_ent = '" + dr[1].ToString() + "' and nf.status_nfe like '%Autorizada%'";
                                    var result = selectSaida_lote.ExecuteScalar();
                                    if (result != DBNull.Value)
                                    {
                                        saida_lote = Convert.ToDouble(result);
                                    }
                                    fbConnection1.Close();
                                    double saldo_lote = entrada_lote - saida_lote;

                                    FbCommand updateLote = new FbCommand();
                                    updateLote.CommandText = "UPDATE ITENS_NOTA_ENT SET SALDO_ITEM_ENT = '" +
                                        saldo_lote.ToString().Replace(".", "").Replace(",", ".") + "' WHERE cod_itens_nota_ent = '" + dr[1].ToString() + "'";
                                    updateLote.Connection = fbConnection1;
                                    fbConnection1.Open();
                                    updateLote.ExecuteNonQuery();
                                    fbConnection1.Close();

                                }
                                catch (Exception ex)
                                {
                                    // Tratar exceções aqui, por exemplo, logar o erro
                                    //Console.WriteLine("Erro: " + ex.Message);
                                }
                                finally
                                {
                                    fbConnection1.Close();
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            // Tratar exceções aqui, por exemplo, logar o erro
                            //Console.WriteLine("Erro: " + ex.Message);
                        }
                        finally
                        {
                            fbConnection1.Close();
                        }







                        _select = "SELECT sum(QTDE_LOTE_ITEM_ENT) " +
                        "FROM ITENS_NOTA_ENT " +
                        "WHERE (COD_ITEM_EST_ITEM_ENT = '" + cod_sistema_produto + "') " +
                        "AND BAIXADO_ITEM_ENT = '1' ";
                    }


                    select_entradas.CommandText = _select;
                    fbConnection1.Open();
                    entradasDataAdapter.SelectCommand = select_entradas;
                    DataSet entradasDataSet3 = new DataSet();
                    entradasDataAdapter.Fill(entradasDataSet3);
                    fbConnection1.Close();
                    foreach (DataRow dr in entradasDataSet3.Tables[0].Rows)
                    {
                        try
                        {
                            
                                entradas = entradas + Convert.ToDouble(dr[0].ToString());
                           
                        }
                        catch { }
                    }


                    ////saidas de componentes //verificar se vai usar
                   

                    //select_entradas.Connection = fbConnection1;
                    //fbConnection1.Open();
                    //select_entradas.CommandText =
                    //    "SELECT sum(QTDE_LOTE_ITEM_ENT) " +
                    //    "FROM ITENS_NOTA_ENT " +
                    //    "JOIN OP ON OP_ITEM_ENT = COD_OP " + //apenas saidas de componentes tem essa caracteristicas
                    //    "WHERE (COD_ITEM_ENT = '" + cod_estoque + "') " +
                    //    "AND OP_ITEM_ENT IS NOT NULL " + //apenas saidas de componentes
                    //    "AND BAIXADO_ITEM_ENT = '1' ";
                    //entradasDataAdapter.SelectCommand = select_entradas;
                    //DataSet entradasDataSet3 = new DataSet();
                    //entradasDataAdapter.Fill(entradasDataSet3);
                    //fbConnection1.Close();
                    //foreach (DataRow dr in entradasDataSet3.Tables[0].Rows)
                    //{
                    //    try
                    //    {
                    //        if (dr[0].ToString() != "") //quando é entrada manual
                    //        {
                    //            entradas = entradas + Convert.ToDouble(dr[0].ToString());
                    //        }
                    //    }
                    //    catch { }
                    //}
                    
                    //estoque producao  (encomendado)
                    FbCommand select_producao = new FbCommand();
                    select_producao.Connection = fbConnection1;
                    fbConnection1.Open();

                    select_producao.CommandText =
                        "SELECT sum(QDE_FAB) FROM OP WHERE COND_PGTO = '" + cod_estoque +
                        "'  AND (FINALIZADO_OP = '0' or finalizado_op is null)";
                    FbDataAdapter producaoDataAdapter = new FbDataAdapter();
                    producaoDataAdapter.SelectCommand = select_producao;
                    DataSet producaoDataSet = new DataSet();
                    producaoDataAdapter.Fill(producaoDataSet);
                    fbConnection1.Close();



                    foreach (DataRow dr in producaoDataSet.Tables[0].Rows)
                    {
                        try
                        {
                            producao = Convert.ToDouble(dr[0].ToString());
                        }
                        catch { }
                    }

                    //estoque empenhado  (reserva_fechada)
                    FbCommand select_empenhado = new FbCommand();
                    select_empenhado.Connection = fbConnection1;
                    fbConnection1.Open();

                    select_empenhado.CommandText =
                        "SELECT sum(QTDE_ITEM_VENDA) FROM ITENS_PEDIDO_VENDA ipv " + 
                        "INNER JOIN OP op on ipv.OP_INTERNA_ITEM_VENDA = op.COD_OP " + 
                        "INNER JOIN PEDIDOS_VENDA pv on ipv.COD_PEDIDO_ITEM_VENDA = pv.COD_PED_VENDA " + 
                        "WHERE  ipv.COD_PROD_ITEM_VENDA = '" + cod_estoque +
                        "'  AND (ipv.CONFIRMADO_ITEM_VENDA = '1') AND " + 
                        "ipv.OP_INTERNA_ITEM_VENDA IS NOT NULL AND (op.FINALIZADO_OP = '0' or op.finalizado_op is null) AND " +
                        "pv.STATUS_PED_VENDA != 'Faturado' and ipv.ITEM_LIBERACAO_ITEM_VENDA IS NULL";
                    FbDataAdapter empenhadoDataAdapter = new FbDataAdapter();
                    empenhadoDataAdapter.SelectCommand = select_empenhado;
                    DataSet empenhadoDataSet = new DataSet();
                    empenhadoDataAdapter.Fill(empenhadoDataSet);
                    fbConnection1.Close();



                    foreach (DataRow dr in empenhadoDataSet.Tables[0].Rows)
                    {
                        try
                        {
                            empenhado = Convert.ToDouble(dr[0].ToString());
                        }
                        catch { }
                    }

                    //estoque empenhado componentes  (reserva_fechada)
                    FbCommand select_empenhado_componentes = new FbCommand();
                    select_empenhado_componentes.Connection = fbConnection1;
                    fbConnection1.Open();

                    select_empenhado_componentes.CommandText =
                      "SELECT pk.*, p.COD_FORNECEDOR_PRODUTO as COD_FORN, p.COD_PRODUTO, p.ESTOQUE_RESERVA_FECHADA_PRODUTO, p.DESCRICAO_PRODUTO FROM PRODUTOS p INNER JOIN produtos_KIT pK on pk.COD_kit_PK = p.cod_produto " +
                                        "WHERE pk.COD_PRODUTO_PK = '" + cod_sistema_produto + "'";
                    FbDataAdapter empenhadoComponentesDataAdapter = new FbDataAdapter();
                    empenhadoComponentesDataAdapter.SelectCommand = select_empenhado_componentes;
                    DataSet empenhadoComponentesDataSet = new DataSet();
                    empenhadoComponentesDataAdapter.Fill(empenhadoComponentesDataSet);
                    fbConnection1.Close();
                    foreach (DataRow dr in empenhadoComponentesDataSet.Tables[0].Rows)
                    {
                        try
                        {
                            empenhado = empenhado + (Convert.ToDouble(dr["QTDE_PK"].ToString()) * Convert.ToDouble(dr["ESTOQUE_RESERVADO_PRODUTO"].ToString())); 
                        }
                        catch { }
                    }




                    //estoque necessidade  (reserva)
                    FbCommand select_necessidade = new FbCommand();
                    select_necessidade.Connection = fbConnection1;
                    fbConnection1.Open();

                    select_necessidade.CommandText =
                        "SELECT sum(QTDE_ITEM_VENDA) FROM ITENS_PEDIDO_VENDA ipv " +
                          "INNER JOIN PEDIDOS_VENDA pv on ipv.COD_PEDIDO_ITEM_VENDA = pv.COD_PED_VENDA " +
                        "WHERE  ipv.COD_PROD_ITEM_VENDA = '" + cod_estoque +
                        "'  AND (ipv.CONFIRMADO_ITEM_VENDA = '1') AND ipv.OP_INTERNA_ITEM_VENDA IS NULL AND (ipv.FINALIZADO_ITEM_VENDA = '0' or ipv.FINALIZADO_ITEM_VENDA is null) AND " +
                        "pv.STATUS_PED_VENDA != 'Faturado' and ipv.ITEM_LIBERACAO_ITEM_VENDA IS NULL";
                    FbDataAdapter necessidadeDataAdapter = new FbDataAdapter();
                    necessidadeDataAdapter.SelectCommand = select_necessidade;
                    DataSet necessidadeDataSet = new DataSet();
                    necessidadeDataAdapter.Fill(necessidadeDataSet);
                    fbConnection1.Close();

                    foreach (DataRow dr in necessidadeDataSet.Tables[0].Rows)
                    {
                        try
                        {
                            necessidade = Convert.ToDouble(dr[0].ToString());
                        }
                        catch { }
                    }

                    
                    //estoque necessidade componente  (reserva) BUSCANDO OS RESERVADOS DOS PAIS E MULTIPLICANDO PELA QTDE_PK DOS FILHOS
                    FbCommand select_necessidade_componente = new FbCommand();
                    select_necessidade_componente.Connection = fbConnection1;
                    fbConnection1.Open();
                    
                    select_necessidade_componente.CommandText =
                    "SELECT pk.*, p.COD_FORNECEDOR_PRODUTO as COD_FORN, p.COD_PRODUTO, p.ESTOQUE_RESERVADO_PRODUTO, p.DESCRICAO_PRODUTO FROM PRODUTOS p INNER JOIN produtos_KIT pK on pk.COD_kit_PK = p.cod_produto " +
                                        "WHERE pk.COD_PRODUTO_PK = '" + cod_sistema_produto + "'";
                    FbDataAdapter necessidadeComponenteDataAdapter = new FbDataAdapter();
                    necessidadeComponenteDataAdapter.SelectCommand = select_necessidade_componente;
                    DataSet necessidadeComponenteDataSet = new DataSet();
                    necessidadeComponenteDataAdapter.Fill(necessidadeComponenteDataSet);
                    fbConnection1.Close();

                    foreach (DataRow dr in necessidadeComponenteDataSet.Tables[0].Rows)
                    {
                        try
                        {
                            necessidade = necessidade + (Convert.ToDouble(dr["QTDE_PK"].ToString()) * Convert.ToDouble(dr["ESTOQUE_RESERVADO_PRODUTO"].ToString()));
                        }
                        catch { }
                    }

                    //estoque SEPARADO  
                    FbCommand select_separado = new FbCommand();
                    select_separado.Connection = fbConnection1;
                    fbConnection1.Open();

                    select_separado.CommandText =
                        
                        "SELECT sum(QTDE_ITEM_VENDA) FROM ITENS_PEDIDO_VENDA ipv " +
                        "WHERE  ipv.COD_PROD_ITEM_VENDA = '" + cod_estoque +
                        "'  AND (ipv.CONFIRMADO_ITEM_VENDA = '1') AND ipv.ITEM_LIBERACAO_ITEM_VENDA IS NOT NULL and ipv.FINALIZADO_ITEM_VENDA is null ";
                    FbDataAdapter separadoDataAdapter = new FbDataAdapter();
                    separadoDataAdapter.SelectCommand = select_separado;
                    DataSet separadoDataSet = new DataSet();
                    separadoDataAdapter.Fill(separadoDataSet);
                    fbConnection1.Close();

                    foreach (DataRow dr in separadoDataSet.Tables[0].Rows)
                    {
                        try
                        {
                            separado = Convert.ToDouble(dr[0].ToString());
                        }
                        catch { }
                    }


                    //buscar saidas
                    FbCommand select_saidas = new FbCommand();
                    select_saidas.Connection = fbConnection1;
                    fbConnection1.Open();
                    select_saidas.CommandText =
                        "SELECT SUM(QTDE_ITEM) FROM ITENS_NOTA es " +
                        "INNER JOIN NOTA_FISCAL nf on es.COD_SISTEMA_NF_ITEM = nf.COD_SISTEMA_NF " + 
                        "WHERE nf.DATA_EMISSAO_NF >= '12.08.2021' and es.COD_ITEM = '" + cod_estoque + "' and nf.STATUS_NFE like '%Autorizad%'";
                    //" AND (es.LOTE_ESTOQUE_SAIDA IS NOT NULL " + 
                    //" OR est.TIPO_ITEM_ESTOQUE != '01 – Matéria-Prima')";
                    FbDataAdapter saidasDataAdapter = new FbDataAdapter();
                    saidasDataAdapter.SelectCommand = select_saidas;
                    DataSet saidasDataSet = new DataSet();
                    saidasDataAdapter.Fill(saidasDataSet);
                    fbConnection1.Close();
                    double saidas = 0;
                    foreach (DataRow dr_saidas in saidasDataSet.Tables[0].Rows)
                    {
                        try
                        {
                            saidas = Convert.ToDouble(dr_saidas[0].ToString());
                        }
                        catch { }
                    }
                   
                    double reservadas = 0;
                    double saldo = 0; //armazenado
                    try
                    {
                        saldo = entradas - saidas;
                    }
                    catch { }

                   
                    try
                    {
                        disponivel = saldo + (producao - empenhado) - necessidade - separado;
                    }
                    catch { }

                    //update estoque
                    FbCommand update = new FbCommand();
                    update.Connection = fbConnection1;
                    fbConnection1.Open();
                    update.CommandText =
                        "UPDATE PRODUTOS SET ESTOQUE_ATUAL_PRODUTO = '" + saldo.ToString("n2").Replace(".", "").Replace(",", ".") + "', " +
                        "ESTOQUE_DISPONIVEL_PRODUTO = '" + disponivel.ToString("n2").Replace(".", "").Replace(",", ".") + "', " +
                        "ESTOQUE_ENCOMENDADO_PRODUTO = '" + producao.ToString("n2").Replace(".", "").Replace(",", ".") + "', " +
                        "ESTOQUE_RESERVADO_PRODUTO = '" + necessidade.ToString("n2").Replace(".", "").Replace(",", ".") + "', " +
                        "ESTOQUE_RESERVA_FECHADA_PRODUTO = '" + empenhado.ToString("n2").Replace(".", "").Replace(",", ".") + "', " +
                        "ESTOQUE_SEPARADO_PRODUTO = '" + separado.ToString("n2").Replace(".", "").Replace(",", ".") + "' " +
                        "WHERE COD_PRODUTO = '" + cod_sistema_produto + "'";
                    FbDataAdapter estoqueDataAdapter = new FbDataAdapter();
                    estoqueDataAdapter.UpdateCommand = update;
                    estoqueDataAdapter.UpdateCommand.ExecuteNonQuery();
                    fbConnection1.Close();


                    FbCommand select = new FbCommand();
                    select.Connection = fbConnection1;
                    fbConnection1.Open();
                    select.CommandText =
                            "SELECT pk.*, p.COD_FORNECEDOR_PRODUTO as COD_FORN, p.COD_PRODUTO FROM PRODUTOS_KIT pk INNER JOIN produtos p on pk.COD_PRODUTO_PK = p.cod_produto " +
                            "WHERE pk.COD_KIT_PK = '" + cod_sistema_produto + "'";
                    FbDataAdapter datSelect = new FbDataAdapter();
                    datSelect.SelectCommand = select;
                    DataTable dtSelect = new DataTable();
                    datSelect.Fill(dtSelect);
                    fbConnection1.Close();
                    foreach (DataRow dr in dtSelect.Rows)
                    {
                        calcular_estoque(dr["COD_FORN"].ToString());
                    }

                }
                catch (Exception a)
                {
                    fbConnection1.Close();
                    //form_erro erro = new form_erro();
                    //erro.erro = a.ToString();
                    //erro.ShowDialog();
                }
            }
            else
            {
               
            }
        }

       

        private string buscar_cod_sistema(string cod_estoque, out string familia)
        {
            familia = ""; 
            try
            {
                FbCommand select_saidas = new FbCommand();
                select_saidas.Connection = fbConnection1;
                fbConnection1.Open();
                select_saidas.CommandText =
                    "SELECT COD_PRODUTO, NOME_FAMILIA_PRODUTO FROM PRODUTOS WHERE COD_FORNECEDOR_PRODUTO = '" + cod_estoque + "' and STATUS_PRODUTO = 1";
               
                FbDataAdapter saidasDataAdapter = new FbDataAdapter();
                saidasDataAdapter.SelectCommand = select_saidas;
                DataSet saidasDataSet = new DataSet();
                saidasDataAdapter.Fill(saidasDataSet);
                fbConnection1.Close();
                double saidas = 0;
                foreach (DataRow dr_saidas in saidasDataSet.Tables[0].Rows)
                {
                    familia = dr_saidas[1].ToString();
                   
                    return dr_saidas[0].ToString();
                }
                return "";
            }
            catch (Exception ex)
            {
                fbConnection1.Close();
                return "";
            }
        }

        public void calcular_estoque(string qtdeUnidade, string cnpjFornecedor, string cod_estoque)
        {

            string codBarrasUnidade = "", codBarrasCaixa = "";
            string pedido_venda = "", razao_social = "";
            opcoes_empresa(out pedido_venda, out razao_social);
            if (razao_social.ToUpper().Contains("CLERMA"))
            {
                //  string cod_sistema_nf_ent = buscar_cod_nf_ent("9999990");
                double qtde_pacote = 1;
                //selecionando itens que tem o mesmo codigo ean de entrada (caixa) para distinguir a qtdeUnidade diferente
                FbCommand _select = new FbCommand();
                _select.CommandText =
                    "SELECT * FROM PRODUTOS WHERE COD_PRODUTO = '" + cod_estoque + "'";
                _select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = _select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow _dr in dtSelect.Rows)
                {
                    qtdeUnidade = _dr["QTDE_UNIDADE_PRODUTO"].ToString();
                    cod_estoque = _dr["COD_PRODUTO"].ToString();
                    codBarrasUnidade = _dr["COD_BARRAS_PRODUTO"].ToString();
                    try
                    {
                        qtde_pacote = Convert.ToDouble(_dr["QTDE_PACOTE_SAIDA_PRODUTO"].ToString());
                    }
                    catch { }
                    if (codBarrasCaixa != "" && codBarrasUnidade != "")
                    {
                        try
                        {
                            //BUSCAR A DATA DO ULTIMO INVENTÁRIO DO FORNECEDOR

                            string dataEmissao = "", dataEmissaoInventario = "", dataEmissaoEnt = "";
                            double entradasInventario = 0, entradas = 0;

                            //puxando todas as entradas de notas_fiscais
                            FbCommand select_entradas = new FbCommand();
                            select_entradas.Connection = fbConnection1;
                            fbConnection1.Open();
                            select_entradas.CommandText =
                                "SELECT sum(QTDE_ITEM_ENT) " +//, QTDE_LOTE_ITEM_ENT, PRECO_TOTAL_ITEM_ENT, NF_ITEM_ENT " +
                                "FROM ITENS_NOTA_ENT JOIN NOTA_FISCAL_ENT ON COD_SISTEMA_NF_ITEM_ENT = COD_SISTEMA_NF_ENT " +
                                "WHERE (COD_EAN_ITEM_ENT = '" + codBarrasCaixa + "' OR COD_EAN_ITEM_ENT = '" + codBarrasUnidade + "') " +
                                "AND QTDE_LOTE_ITEM_ENT IS NULL " + //pega o que não é entrada manual
                                // "WHERE (COD_EAN_ITEM_ENT = '" + codBarrasUnidade + "' " +
                                "AND BAIXADO_ITEM_ENT = '1' " +
                                "AND ((CFOP_ITEM_ENT <> '5202' AND CFOP_ITEM_ENT <> '5411' AND CFOP_ITEM_ENT <> '5949' " +
                                "AND CFOP_ITEM_ENT <> '6202' AND CFOP_ITEM_ENT <> '6411' AND CFOP_ITEM_ENT <> '6949'))" +// OR (CFOP_ITEM_ENT IS NULL)) " +
                                dataEmissaoEnt;
                            FbDataAdapter entradasDataAdapter = new FbDataAdapter();
                            entradasDataAdapter.SelectCommand = select_entradas;
                            DataSet entradasDataSet = new DataSet();
                            entradasDataAdapter.Fill(entradasDataSet);
                            fbConnection1.Close();
                            // double ultima_compra = 0;
                            int i = 0;
                            foreach (DataRow dr in entradasDataSet.Tables[0].Rows)
                            {
                                try
                                {

                                    string _qtde_unidade = qtdeUnidade;

                                    entradas = entradas + (Convert.ToDouble(dr[0].ToString()) * Convert.ToDouble(_qtde_unidade));

                                }
                                catch { i++; }
                            }

                            //puxando todas as entradas e saidas de acerto
                            //FbCommand select_entradas = new FbCommand();
                            select_entradas.Connection = fbConnection1;
                            fbConnection1.Open();
                            select_entradas.CommandText =
                                //"SELECT QTDE_ITEM_ENT, QTDE_LOTE_ITEM_ENT, PRECO_TOTAL_ITEM_ENT, NF_ITEM_ENT " + modificado 22022018
                                "SELECT sum(QTDE_LOTE_ITEM_ENT) " +
                                "FROM ITENS_NOTA_ENT JOIN NOTA_FISCAL_ENT ON COD_SISTEMA_NF_ITEM_ENT = COD_SISTEMA_NF_ENT " +
                                //  "WHERE (COD_EAN_ITEM_ENT = '" + codBarrasCaixa + "' OR COD_EAN_ITEM_ENT = '" + codBarrasUnidade + "') " +
                                "WHERE (COD_EAN_ITEM_ENT = '" + codBarrasUnidade + "') " +
                                "AND QTDE_LOTE_ITEM_ENT IS NOT NULL " + //apenas manuais
                                "AND BAIXADO_ITEM_ENT = '1' " +
                                dataEmissaoEnt;
                            //FbDataAdapter entradasDataAdapter = new FbDataAdapter();
                            entradasDataAdapter.SelectCommand = select_entradas;
                            DataSet entradasDataSet2 = new DataSet();
                            entradasDataAdapter.Fill(entradasDataSet2);
                            fbConnection1.Close();
                            // double ultima_compra = 0;
                            foreach (DataRow dr in entradasDataSet2.Tables[0].Rows)
                            {
                                try
                                {

                                    if (dr[0].ToString() != "") //quando é entrada manual
                                    {
                                        entradas = entradas + Convert.ToDouble(dr[0].ToString());
                                    }

                                }
                                catch { }
                            }
                            //}

                            double saidas = 0;
                            //buscar saidas após a data do ultimo inventário

                            try
                            {
                                //buscar saidas após a data do ultimo inventário
                                FbCommand select_saidas_pdv = new FbCommand();
                                select_saidas_pdv.Connection = fbConnection1;
                                fbConnection1.Open();
                                select_saidas_pdv.CommandText =
                                    //    "SELECT item.*,  prod.* " +
                                "select sum(item.qtde_infce) AS QTDE_INFCE " +//, prod.QTDE_PACOTE_SAIDA_PRODUTO " +
                                    "FROM itens_nfce item " +
                                    " INNER JOIN NFCE nf " +
                                    " ON nf.PEDIDO_NFCE = item.COD_PEDIDO_INFCE " +
                                    //  " INNER JOIN PRODUTOS prod on prod.COD_PRODUTO = item.COD_ESTOQUE_INFCE " +
                                    //     "WHERE (prod.COD_BARRAS_PRODUTO like '" + codBarrasUnidade + "' or prod.COD_BARRAS_CAIXA_PRODUTO like '" + codBarrasCaixa + "' ) " +
                                    "WHERE item.EAN_INFCE = '" + codBarrasUnidade + "' " +// or prod.COD_BARRAS_CAIXA_PRODUTO like '" + codBarrasCaixa + "' ) " +    
                                    //         dataEmissao +
                                    "    AND nf.PEDIDO_FECHADO_NFCE = '1' ";
                                //    "group by prod.QTDE_PACOTE_SAIDA_PRODUTO ";
                                FbDataAdapter saidasDataAdapter_pdv = new FbDataAdapter();
                                saidasDataAdapter_pdv.SelectCommand = select_saidas_pdv;
                                DataSet saidasDataSet_pdv = new DataSet();
                                saidasDataAdapter_pdv.Fill(saidasDataSet_pdv);
                                fbConnection1.Close();
                                //double saidas = 0;
                                foreach (DataRow dr_saidas_pdv in saidasDataSet_pdv.Tables[0].Rows)
                                {
                                    try
                                    {
                                        double coeficiente = 1;

                                        try
                                        {
                                            coeficiente = qtde_pacote;
                                        }
                                        catch { }
                                        saidas = saidas + Convert.ToDouble(dr_saidas_pdv["qtde_infce"].ToString()) * coeficiente;
                                    }
                                    catch { }
                                }
                            }
                            catch
                            {
                                fbConnection1.Close();
                            }


                            if (pedido_venda == "1")
                            {
                                try
                                {
                                    //puxando saidas dos pedidos
                                    FbCommand select_saidas_pdv = new FbCommand();
                                    select_saidas_pdv.Connection = fbConnection1;
                                    fbConnection1.Open();
                                    select_saidas_pdv.CommandText =
                                        "SELECT SUM(item.QTDE_ITEM_VENDA) as QTDE_ITEM_VENDA " +//, prod.QTDE_PACOTE_SAIDA_PRODUTO " +
                                        "FROM ITENS_PEDIDO_VENDA item INNER JOIN PEDIDOS_VENDA PED " +
                                        "ON item.COD_PEDIDO_ITEM_VENDA = PED.COD_PED_VENDA " +
                                        //   "INNER JOIN PRODUTOS prod ON prod.COD_PRODUTO = item.COD_SISTEMA_PROD_ITEM_VENDA " +
                                        //  "WHERE (prod.COD_BARRAS_PRODUTO like '" + codBarrasUnidade + "' or prod.COD_BARRAS_CAIXA_PRODUTO like '" + codBarrasCaixa + "' ) " +
                                        "WHERE (item.EAN_ITEM_VENDA like '" + codBarrasUnidade + "') " + // OR  item.EAN_ITEM_VENDA like '" + codBarrasCaixa + "')" +
                                          "AND PED.BAIXADO_ESTOQUE_PED_VENDA = '1' AND " +
                                         "(ped.SAIDA_VENDA_DIRETA_PED_VENDA is null or ped.SAIDA_VENDA_DIRETA_PED_VENDA = 0) ";// + 
                                    //    " group by prod.QTDE_PACOTE_SAIDA_PRODUTO" ;
                                    FbDataAdapter saidasDataAdapter_pdv = new FbDataAdapter();
                                    saidasDataAdapter_pdv.SelectCommand = select_saidas_pdv;
                                    DataSet saidasDataSet_pdv = new DataSet();
                                    saidasDataAdapter_pdv.Fill(saidasDataSet_pdv);
                                    fbConnection1.Close();
                                    //double saidas = 0;
                                    foreach (DataRow dr_saidas_pdv in saidasDataSet_pdv.Tables[0].Rows)
                                    {
                                        try
                                        {
                                            double coeficiente = 1;

                                            try
                                            {

                                                coeficiente = qtde_pacote;
                                                saidas = saidas + Convert.ToDouble(dr_saidas_pdv["QTDE_ITEM_VENDA"].ToString());// *coeficiente;
                                            }
                                            catch { }

                                            if (qtde_pacote != 1)
                                            {
                                                //selecionando os totais do produto na outra unidade
                                                try
                                                {
                                                    FbCommand select_saidas_pdv_2 = new FbCommand();
                                                    select_saidas_pdv_2.Connection = fbConnection1;
                                                    fbConnection1.Open();
                                                    select_saidas_pdv_2.CommandText =
                                                        "SELECT SUM(item.QTDE_ITEM_VENDA) as QTDE_ITEM_VENDA, prod.QTDE_PACOTE_SAIDA_PRODUTO " +
                                                        "FROM ITENS_PEDIDO_VENDA item INNER JOIN PEDIDOS_VENDA PED " +
                                                        "ON item.COD_PEDIDO_ITEM_VENDA = PED.COD_PED_VENDA " +
                                                           "INNER JOIN PRODUTOS prod ON prod.COD_PRODUTO = item.COD_SISTEMA_PROD_ITEM_VENDA " +
                                                          "WHERE (prod.COD_BARRAS_PRODUTO like '" + codBarrasUnidade + "' or prod.COD_BARRAS_CAIXA_PRODUTO like '" + codBarrasCaixa + "' ) " +
                                                        " AND (item.EAN_ITEM_VENDA not like '" + codBarrasUnidade + "') " + // OR  item.EAN_ITEM_VENDA like '" + codBarrasCaixa + "')" +
                                                          "AND PED.BAIXADO_ESTOQUE_PED_VENDA = '1' AND " +
                                                         "(ped.SAIDA_VENDA_DIRETA_PED_VENDA is null or ped.SAIDA_VENDA_DIRETA_PED_VENDA = 0) " +
                                                        " group by prod.QTDE_PACOTE_SAIDA_PRODUTO";
                                                    FbDataAdapter saidasDataAdapter_pdv_2 = new FbDataAdapter();
                                                    saidasDataAdapter_pdv_2.SelectCommand = select_saidas_pdv_2;
                                                    DataSet saidasDataSet_pdv_2 = new DataSet();
                                                    saidasDataAdapter_pdv_2.Fill(saidasDataSet_pdv_2);
                                                    fbConnection1.Close();

                                                    foreach (DataRow dr_saidas_pdv_2 in saidasDataSet_pdv_2.Tables[0].Rows)
                                                    {

                                                        try
                                                        {
                                                            coeficiente = Convert.ToDouble(dr_saidas_pdv_2[1].ToString());
                                                            saidas = saidas + Convert.ToDouble(dr_saidas_pdv_2["QTDE_ITEM_VENDA"].ToString()) * coeficiente;
                                                        }
                                                        catch { }
                                                    }



                                                }
                                                catch
                                                {
                                                    fbConnection1.Close();
                                                }

                                            }


                                        }
                                        catch
                                        {
                                            fbConnection1.Close();
                                        }
                                    }
                                }
                                catch { fbConnection1.Close(); }

                            }
                            else
                            {
                                //puxando saidas das notas
                                FbCommand select_saidas = new FbCommand();
                                select_saidas.Connection = fbConnection1;
                                fbConnection1.Open();
                                select_saidas.CommandText =
                                    "SELECT sum(item.qtde_item) as qtde_item " +//, prod.QTDE_PACOTE_SAIDA_PRODUTO " +
                                    "FROM itens_nota item " +
                                    "    INNER JOIN nota_fiscal nf " +
                                    "        ON nf.n_nf = item.nf_item " +
                                    //  "INNER JOIN produtos prod ON prod.COD_PRODUTO = item.COD_ITEM " +
                                    //   "WHERE (prod.COD_BARRAS_PRODUTO like '" + codBarrasUnidade + "' or prod.COD_BARRAS_CAIXA_PRODUTO like '" + codBarrasCaixa + "' ) " +
                                    "WHERE (item.cod_ean_item = '" + codBarrasUnidade + "') " +//OR item.COD_EAN_ITEM like '" + codBarrasCaixa + "') " + 
                                         dataEmissao +
                                    "    AND nf.status_nfe like 'NFe Autorizada.' and nf.ENTRADA_SAIDA_NF = '1' ";// +
                                //   "GROUP BY prod.QTDE_PACOTE_SAIDA_PRODUTO" ;
                                FbDataAdapter saidasDataAdapter = new FbDataAdapter();
                                saidasDataAdapter.SelectCommand = select_saidas;
                                DataSet saidasDataSet = new DataSet();
                                saidasDataAdapter.Fill(saidasDataSet);
                                fbConnection1.Close();

                                foreach (DataRow dr_saidas in saidasDataSet.Tables[0].Rows)
                                {
                                    try
                                    {
                                        double coeficiente = 1;

                                        try
                                        {

                                            coeficiente = qtde_pacote;

                                        }
                                        catch { }

                                        saidas = saidas + Convert.ToDouble(dr_saidas["qtde_item"].ToString()) * coeficiente;
                                    }
                                    catch { }
                                }
                            }

                            //buscar ENTRADAS das notas de entrada proprias
                            FbCommand select_entradas_nf = new FbCommand();
                            select_entradas_nf.Connection = fbConnection1;
                            fbConnection1.Open();
                            select_entradas_nf.CommandText =
                                 "SELECT sum(item.qtde_item) as qtde_item " + //, prod.QTDE_PACOTE_SAIDA_PRODUTO " +
                                "FROM itens_nota item " +
                                "    INNER JOIN nota_fiscal nf " +
                                "        ON nf.n_nf = item.nf_item " +
                                //   "INNER JOIN produtos prod ON prod.COD_PRODUTO = item.COD_ITEM " +
                                // "WHERE (prod.COD_BARRAS_PRODUTO like '" + codBarrasUnidade + "' or prod.COD_BARRAS_CAIXA_PRODUTO like '" + codBarrasCaixa + "' ) " +
                                "WHERE (item.cod_ean_item = '" + codBarrasUnidade + "') " + //OR item.COD_EAN_ITEM like '" + codBarrasCaixa + "') " + 
                                     dataEmissao +
                                "    AND nf.status_nfe like 'NFe Autorizada.' and nf.ENTRADA_SAIDA_NF = '0' ";// + 
                            //    "  group by prod.QTDE_PACOTE_SAIDA_PRODUTO ";
                            FbDataAdapter entradas_nfDataAdapter = new FbDataAdapter();
                            entradas_nfDataAdapter.SelectCommand = select_entradas_nf;
                            DataSet entradas_nfDataSet = new DataSet();
                            entradas_nfDataAdapter.Fill(entradas_nfDataSet);
                            fbConnection1.Close();
                            //double entradas = 0;
                            foreach (DataRow dr_entradas_nf in entradas_nfDataSet.Tables[0].Rows)
                            {
                                try
                                {
                                    double coeficiente = 1;

                                    try
                                    {
                                        // if (Convert.ToDouble(dr_entradas_nf["QTDE_PACOTE_SAIDA_PRODUTO"].ToString()) != qtde_pacote)
                                        //   {
                                        // coeficiente = Convert.ToDouble(dr_entradas_nf["QTDE_PACOTE_SAIDA_PRODUTO"].ToString());
                                        coeficiente = qtde_pacote;
                                        //   }
                                    }
                                    catch { }

                                    entradas = entradas + Convert.ToDouble(dr_entradas_nf["qtde_item"].ToString()) * coeficiente;
                                }
                                catch { }
                            }


                            //SELECIONANDO O ESTOQUE RESERVADO
                            double _reservadas = 0;
                            // if (pedido_venda != "1")
                            // {
                            FbCommand select_reserva = new FbCommand();
                            select_reserva.Connection = fbConnection1;
                            fbConnection1.Open();
                            select_reserva.CommandText =
                                "SELECT sum(iped.QTDE_ITEM_VENDA) " +//, prod.QTDE_PACOTE_SAIDA_PRODUTO " +
                                "FROM ITENS_PEDIDO_VENDA iped " +
                                "    INNER JOIN PEDIDOS_VENDA ped " +
                                "        ON ped.COD_PED_VENDA = iped.COD_PEDIDO_ITEM_VENDA " +
                                //   "INNER JOIN PRODUTOS prod ON prod.COD_PRODUTO = iped.COD_SISTEMA_PROD_ITEM_VENDA " +
                                //        "WHERE (prod.COD_BARRAS_PRODUTO like '" + codBarrasUnidade + "' or prod.COD_BARRAS_CAIXA_PRODUTO like '" + codBarrasCaixa + "' ) " +
                                "WHERE (iped.EAN_ITEM_VENDA = '" + codBarrasUnidade + "') " +
                              "    AND (ped.NF_PED_VENDA IS NULL OR ped.NF_PED_VENDA = 0) and " +
                                "(ped.SAIDA_VENDA_DIRETA_PED_VENDA is null or ped.SAIDA_VENDA_DIRETA_PED_VENDA = 0) ";// +
                            //       "group by prod.QTDE_PACOTE_SAIDA_PRODUTO";
                            FbDataAdapter reservasDataAdapter = new FbDataAdapter();
                            reservasDataAdapter.SelectCommand = select_reserva;
                            DataSet reservasDataSet = new DataSet();
                            reservasDataAdapter.Fill(reservasDataSet);
                            fbConnection1.Close();

                            foreach (DataRow dr_res in reservasDataSet.Tables[0].Rows)
                            {
                                try
                                {
                                    double coeficiente = 1;

                                    try
                                    {

                                        coeficiente = qtde_pacote;// Convert.ToDouble(dr_res["QTDE_PACOTE_SAIDA_PRODUTO"].ToString());

                                    }
                                    catch { }

                                    _reservadas += (Convert.ToDouble(dr_res[0].ToString()));// * coeficiente);

                                }

                                catch { }
                            }
                            if (qtde_pacote != 1)
                            {
                                //selecionando os totais do produto na outra unidade
                                try
                                {
                                    FbCommand select_saidas_pdv_2 = new FbCommand();
                                    select_saidas_pdv_2.Connection = fbConnection1;
                                    fbConnection1.Open();
                                    select_saidas_pdv_2.CommandText =
                                        "SELECT SUM(item.QTDE_ITEM_VENDA) as QTDE_ITEM_VENDA, prod.QTDE_PACOTE_SAIDA_PRODUTO " +
                                        "FROM ITENS_PEDIDO_VENDA item INNER JOIN PEDIDOS_VENDA PED " +
                                        "ON item.COD_PEDIDO_ITEM_VENDA = PED.COD_PED_VENDA " +
                                           "INNER JOIN PRODUTOS prod ON prod.COD_PRODUTO = item.COD_SISTEMA_PROD_ITEM_VENDA " +
                                          "WHERE (prod.COD_BARRAS_PRODUTO like '" + codBarrasUnidade + "' or prod.COD_BARRAS_CAIXA_PRODUTO like '" + codBarrasCaixa + "' ) " +
                                        " AND (item.EAN_ITEM_VENDA not like '" + codBarrasUnidade + "') " + // OR  item.EAN_ITEM_VENDA like '" + codBarrasCaixa + "')" +
                                        "    AND (ped.NF_PED_VENDA IS NULL OR ped.NF_PED_VENDA = 0) and " +
                                "(ped.SAIDA_VENDA_DIRETA_PED_VENDA is null or ped.SAIDA_VENDA_DIRETA_PED_VENDA = 0) " +
                                        " group by prod.QTDE_PACOTE_SAIDA_PRODUTO";
                                    FbDataAdapter saidasDataAdapter_pdv_2 = new FbDataAdapter();
                                    saidasDataAdapter_pdv_2.SelectCommand = select_saidas_pdv_2;
                                    DataSet saidasDataSet_pdv_2 = new DataSet();
                                    saidasDataAdapter_pdv_2.Fill(saidasDataSet_pdv_2);
                                    fbConnection1.Close();

                                    foreach (DataRow dr_saidas_pdv_2 in saidasDataSet_pdv_2.Tables[0].Rows)
                                    {

                                        try
                                        {
                                            double coeficiente = 1;
                                            coeficiente = Convert.ToDouble(dr_saidas_pdv_2[1].ToString());
                                            _reservadas += Convert.ToDouble(dr_saidas_pdv_2["QTDE_ITEM_VENDA"].ToString()) * coeficiente;
                                        }
                                        catch { }
                                    }



                                }
                                catch
                                {
                                    fbConnection1.Close();
                                }

                            }
                            //    }
                            //SELECIONANDO O ESTOQUE RESERVADO FECHADO
                            FbCommand select_reserva_fechada = new FbCommand();
                            select_reserva_fechada.Connection = fbConnection1;
                            fbConnection1.Open();
                            select_reserva_fechada.CommandText =
                                "SELECT sum(iped.QTDE_ITEM_VENDA) AS QTDE_ITEM_VENDA " + //, prod.QTDE_PACOTE_SAIDA_PRODUTO " +
                                "FROM ITENS_PEDIDO_VENDA iped " +
                                "    INNER JOIN PEDIDOS_VENDA ped " +
                                "        ON ped.COD_PED_VENDA = iped.COD_PEDIDO_ITEM_VENDA " +
                                //     "INNER JOIN PRODUTOS prod ON prod.COD_PRODUTO = iped.COD_SISTEMA_PROD_ITEM_VENDA " +
                                         "WHERE " +
                                // " (prod.COD_BARRAS_PRODUTO like '" + codBarrasUnidade + "' or prod.COD_BARRAS_CAIXA_PRODUTO like '" + codBarrasCaixa + "' ) " +
                                " iped.EAN_ITEM_VENDA = '" + codBarrasUnidade + "' " +
                                "    AND (ped.NF_PED_VENDA IS NULL OR ped.NF_PED_VENDA = 0) AND " +
                                "(ped.BAIXADO_ESTOQUE_PED_VENDA = '1') and (ped.NF_PED_VENDA IS NULL OR ped.NF_PED_VENDA = '0') and (ped.SAIDA_VENDA_DIRETA_PED_VENDA is null or ped.SAIDA_VENDA_DIRETA_PED_VENDA = 0) ";// +
                            //       "group by prod.QTDE_PACOTE_SAIDA_PRODUTO";
                            FbDataAdapter reservas_fechadaDataAdapter = new FbDataAdapter();
                            reservas_fechadaDataAdapter.SelectCommand = select_reserva_fechada;
                            DataSet reservas_fechadaDataSet = new DataSet();
                            reservas_fechadaDataAdapter.Fill(reservas_fechadaDataSet);
                            fbConnection1.Close();
                            double _reservadas_fechada = 0;
                            foreach (DataRow dr_res in reservas_fechadaDataSet.Tables[0].Rows)
                            {
                                try
                                {
                                    double coeficiente = 1;

                                    try
                                    {

                                        coeficiente = qtde_pacote;
                                    }
                                    catch { }

                                    _reservadas_fechada += Convert.ToDouble(dr_res[0].ToString());// *coeficiente;
                                }
                                catch { }
                            }
                            if (qtde_pacote != 1)
                            {
                                //selecionando os totais do produto na outra unidade
                                try
                                {
                                    FbCommand select_saidas_pdv_2 = new FbCommand();
                                    select_saidas_pdv_2.Connection = fbConnection1;
                                    fbConnection1.Open();
                                    select_saidas_pdv_2.CommandText =
                                        "SELECT SUM(item.QTDE_ITEM_VENDA) as QTDE_ITEM_VENDA, prod.QTDE_PACOTE_SAIDA_PRODUTO " +
                                        "FROM ITENS_PEDIDO_VENDA item INNER JOIN PEDIDOS_VENDA PED " +
                                        "ON item.COD_PEDIDO_ITEM_VENDA = PED.COD_PED_VENDA " +
                                           "INNER JOIN PRODUTOS prod ON prod.COD_PRODUTO = item.COD_SISTEMA_PROD_ITEM_VENDA " +
                                          "WHERE (prod.COD_BARRAS_PRODUTO like '" + codBarrasUnidade + "' or prod.COD_BARRAS_CAIXA_PRODUTO like '" + codBarrasCaixa + "' ) " +
                                        " AND (item.EAN_ITEM_VENDA not like '" + codBarrasUnidade + "') " + // OR  item.EAN_ITEM_VENDA like '" + codBarrasCaixa + "')" +
                                         "    AND (ped.NF_PED_VENDA IS NULL OR ped.NF_PED_VENDA = 0) AND " +
                                "(ped.BAIXADO_ESTOQUE_PED_VENDA = '1') and (ped.NF_PED_VENDA IS NULL OR ped.NF_PED_VENDA = '0') AND " +
                                  "(ped.SAIDA_VENDA_DIRETA_PED_VENDA is null or ped.SAIDA_VENDA_DIRETA_PED_VENDA = 0) " +
                                        " group by prod.QTDE_PACOTE_SAIDA_PRODUTO";
                                    FbDataAdapter saidasDataAdapter_pdv_2 = new FbDataAdapter();
                                    saidasDataAdapter_pdv_2.SelectCommand = select_saidas_pdv_2;
                                    DataSet saidasDataSet_pdv_2 = new DataSet();
                                    saidasDataAdapter_pdv_2.Fill(saidasDataSet_pdv_2);
                                    fbConnection1.Close();

                                    foreach (DataRow dr_saidas_pdv_2 in saidasDataSet_pdv_2.Tables[0].Rows)
                                    {

                                        try
                                        {
                                            double coeficiente = 1;
                                            coeficiente = Convert.ToDouble(dr_saidas_pdv_2[1].ToString());
                                            _reservadas_fechada += Convert.ToDouble(dr_saidas_pdv_2["QTDE_ITEM_VENDA"].ToString()) * coeficiente;
                                        }
                                        catch { }
                                    }



                                }
                                catch
                                {
                                    fbConnection1.Close();
                                }

                            }




                            double saldo = 0; //armazenado
                            double aguardando = 0;
                            double reservadas = 0;
                            reservadas = _reservadas;
                            try
                            {
                                saldo = (entradas + entradasInventario) - saidas;
                            }
                            catch { }

                            double disponivel = 0;
                            try
                            {
                                disponivel = saldo + aguardando - reservadas;
                            }
                            catch { }


                            //update estoque
                            FbCommand update = new FbCommand();
                            update.Connection = fbConnection1;
                            fbConnection1.Open();
                            update.CommandText =
                                "UPDATE produtos SET estoque_atual_produto = '" + saldo.ToString("N3").Replace(".", "").Replace(",", ".") + "',  " +
                                "estoque_reservado_produto = '" + reservadas.ToString("N3").Replace(".", "").Replace(",", ".") + "',  " +
                                "estoque_disponivel_produto = '" + disponivel.ToString("N3").Replace(".", "").Replace(",", ".") + "', " +
                                "estoque_reserva_fechada_produto = '" + _reservadas_fechada.ToString("N3").Replace(".", "").Replace(",", ".") + "' " +
                                "WHERE (COD_PRODUTO = '" + cod_estoque + "')";
                            FbDataAdapter estoqueDataAdapter = new FbDataAdapter();
                            estoqueDataAdapter.UpdateCommand = update;
                            estoqueDataAdapter.UpdateCommand.ExecuteNonQuery();
                            fbConnection1.Close();

                        }
                        catch (Exception a)
                        {
                            fbConnection1.Close();
                            form_erro erro = new form_erro();
                            erro.erro = a.ToString();
                            erro.ShowDialog();
                        }

                    }
                    else
                    {
                        erro = true;
                        //form_erro erro = new form_erro();
                        //erro.erro = "Não existe código de estoque";
                        //erro.ShowDialog();
                    }
                }
            }
             
        }

        private void opcoes_empresa(out string pedido_venda, out string razao_social)
        {
            pedido_venda = ""; razao_social = "";

            try
            {                
                FbCommand select = new FbCommand();
                FbDataAdapter datEmpresa = new FbDataAdapter();
                DataTable dtEmpresa = new DataTable();
                select.Connection = fbConnection1;
                select.CommandText = "SELECT * FROM EMPRESA";
                datEmpresa.SelectCommand = select;
                fbConnection1.Open();
                datEmpresa.Fill(dtEmpresa);
                fbConnection1.Close();
                foreach (DataRow d in dtEmpresa.Rows)
                {
                    pedido_venda = d["SAIDA_ESTOQUE_PEDIDO_EMPRESA"].ToString();
                    razao_social = d["RAZAO_SOCIAL_EMPRESA"].ToString();
                }

            }
            catch
            {
                fbConnection1.Close();
            }
        }

        public void acertarEstoqueProdutos(string codBarras)
        {


            try
            {
                //puxando todas as entradas desse item
                FbCommand select_entradas = new FbCommand();
                select_entradas.Connection = fbConnection1;
                fbConnection1.Open();

                select_entradas.CommandText =
                    "SELECT QTDE_ITEM_ENT, QTDE_LOTE_ITEM_ENT, PRECO_TOTAL_ITEM_ENT FROM ITENS_NOTA_ENT WHERE COD_EAN_ITEM_ENT = '" + codBarras + "' AND BAIXADO_ITEM_ENT = '1' ORDER BY COD_ITENS_NOTA_ENT DESC";
                FbDataAdapter entradasDataAdapter = new FbDataAdapter();
                entradasDataAdapter.SelectCommand = select_entradas;
                DataSet entradasDataSet = new DataSet();
                entradasDataAdapter.Fill(entradasDataSet);
                fbConnection1.Close();
                double entradas = 0;
                double ultima_compra = 0;
                int i = 0;
                foreach (DataRow dr in entradasDataSet.Tables[0].Rows)
                {
                    try
                    {
                        if (dr[1].ToString() != "")
                        {
                            entradas = entradas + Convert.ToDouble(dr[1].ToString());
                            if (i == 0)
                            {
                                try
                                {
                                    ultima_compra = Convert.ToDouble(dr[2].ToString()) /
                                        entradas;
                                }
                                catch { }
                            }
                        }
                        else
                        {
                            entradas = entradas + Convert.ToDouble(dr[0].ToString());
                            if (i == 0)
                            {
                                try
                                {
                                    ultima_compra = Convert.ToDouble(dr[2].ToString()) /
                                        entradas;
                                }
                                catch { }
                            }
                        }
                        i++;
                    }
                    catch { i++; }
                }
                //buscar saidas
                FbCommand select_saidas = new FbCommand();
                select_saidas.Connection = fbConnection1;
                fbConnection1.Open();
                select_saidas.CommandText =
                    "SELECT QTDE_ITEM FROM ITENS_NOTA WHERE COD_EAN_ITEM = '" + codBarras + "'";
                FbDataAdapter saidasDataAdapter = new FbDataAdapter();
                saidasDataAdapter.SelectCommand = select_saidas;
                DataSet saidasDataSet = new DataSet();
                saidasDataAdapter.Fill(saidasDataSet);
                fbConnection1.Close();
                double saidas = 0;
                foreach (DataRow dr_saidas in saidasDataSet.Tables[0].Rows)
                {
                    try
                    {
                        saidas = saidas + Convert.ToDouble(dr_saidas[0].ToString());
                    }
                    catch { }
                }



                //terminar as contas com as entradas, saidas, reservado e aguardando
                double saldo = 0; //armazenado
                try
                {
                    saldo = entradas - saidas;
                }
                catch { }


                //update estoque
                FbCommand update = new FbCommand();
                update.Connection = fbConnection1;
                fbConnection1.Open();
                update.CommandText =
                    "UPDATE PRODUTOS SET ESTOQUE_ATUAL_PRODUTO = '" + saldo.ToString().Replace(".", "").Replace(",", ".") + "' " +
                    "WHERE COD_BARRAS_PRODUTO = '" + codBarras + "'";
                FbDataAdapter estoqueDataAdapter = new FbDataAdapter();
                estoqueDataAdapter.UpdateCommand = update;
                estoqueDataAdapter.UpdateCommand.ExecuteNonQuery();
                fbConnection1.Close();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                form_erro erro = new form_erro();
                erro.erro = a.ToString();
                erro.ShowDialog();
            }
            
        }

        public void acertarEstoqueProdutosIni(string codEstoque)
        {

            if (codEstoque != "")
            {
                try
                {
                    //puxando todas as entradas desse item
                    FbCommand select_entradas = new FbCommand();
                    select_entradas.Connection = fbConnection1;
                    fbConnection1.Open();

                    select_entradas.CommandText =
                        "SELECT QTDE_ITEM_ENT, QTDE_LOTE_ITEM_ENT, PRECO_TOTAL_ITEM_ENT FROM ITENS_NOTA_ENT WHERE COD_ITEM_EST_ITEM_ENT = '" + codEstoque + "' AND BAIXADO_ITEM_ENT = '1' ORDER BY COD_ITENS_NOTA_ENT DESC";
                    FbDataAdapter entradasDataAdapter = new FbDataAdapter();
                    entradasDataAdapter.SelectCommand = select_entradas;
                    DataSet entradasDataSet = new DataSet();
                    entradasDataAdapter.Fill(entradasDataSet);
                    fbConnection1.Close(); 
                    double entradas = 0;
                    double ultima_compra = 0;
                    int i = 0;
                    foreach (DataRow dr in entradasDataSet.Tables[0].Rows)
                    {
                        try
                        {
                            if (dr[1].ToString() != "")
                            {
                                entradas = entradas + Convert.ToDouble(dr[1].ToString());
                                if (i == 0)
                                {
                                    try
                                    {
                                        ultima_compra = Convert.ToDouble(dr[2].ToString()) /
                                            entradas;
                                    }
                                    catch { }
                                }
                            }
                            else
                            {
                                entradas = entradas + Convert.ToDouble(dr[0].ToString());
                                if (i == 0)
                                {
                                    try
                                    {
                                        ultima_compra = Convert.ToDouble(dr[2].ToString()) /
                                            entradas;
                                    }
                                    catch { }
                                }
                            }
                            i++;
                        }
                        catch { i++; }
                    }
                    //buscar saidas
                    FbCommand select_saidas = new FbCommand();
                    select_saidas.Connection = fbConnection1;
                    fbConnection1.Open();
                    select_saidas.CommandText =
                        "SELECT QTDE_ITEM FROM ITENS_NOTA WHERE COD_ITEM = '" + codEstoque + "'";
                    FbDataAdapter saidasDataAdapter = new FbDataAdapter();
                    saidasDataAdapter.SelectCommand = select_saidas;
                    DataSet saidasDataSet = new DataSet();
                    saidasDataAdapter.Fill(saidasDataSet);
                    fbConnection1.Close(); 
                    double saidas = 0;
                    foreach (DataRow dr_saidas in saidasDataSet.Tables[0].Rows)
                    {
                        try
                        {
                            saidas = saidas + Convert.ToDouble(dr_saidas[0].ToString());
                        }
                        catch { }
                    }



                    //terminar as contas com as entradas, saidas, reservado e aguardando
                    double saldo = 0; //armazenado
                    try
                    {
                        saldo = entradas - saidas;
                    }
                    catch { }


                    //update estoque
                    FbCommand update = new FbCommand();
                    update.Connection = fbConnection1;
                    fbConnection1.Open();
                    update.CommandText =
                        "UPDATE PRODUTOS SET ESTOQUE_ATUAL_PRODUTO = '" + saldo.ToString().Replace(".", "").Replace(",", ".") + "' " +
                        "WHERE COD_PRODUTO = '" + codEstoque + "'";
                    FbDataAdapter estoqueDataAdapter = new FbDataAdapter();
                    estoqueDataAdapter.UpdateCommand = update;
                    estoqueDataAdapter.UpdateCommand.ExecuteNonQuery();
                    fbConnection1.Close(); 
                }
                catch (Exception a)
                {
                    fbConnection1.Close(); 
                    form_erro erro = new form_erro();
                    erro.erro = a.ToString();
                    erro.ShowDialog();
                }
            }
            else
            {
                erro = true;
                //form_erro erro = new form_erro();
                //erro.erro = "Não existe código de estoque";
                //erro.ShowDialog();
            }
        }
        public void mensagem() 
        {
            form_erro erro = new form_erro();
            erro.Visible = false;
            erro.erro = "Não existe código de estoque";
            erro.ShowDialog();
        }
    }

}
