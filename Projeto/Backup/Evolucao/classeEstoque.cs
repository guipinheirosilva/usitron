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
        

        public void calcular_estoque(string cod_estoque)
        {
            
            if (cod_estoque != "")
            {
                try
                {
                    //puxando todas as entradas desse item
                    FbCommand select_entradas = new FbCommand();
                    select_entradas.Connection = fbConnection1;
                    fbConnection1.Open();

                    select_entradas.CommandText =
                        "SELECT QTDE_ITEM_ENT, QTDE_LOTE_ITEM_ENT, PRECO_TOTAL_ITEM_ENT FROM ITENS_NOTA_ENT WHERE COD_ITEM_EST_ITEM_ENT = '" + cod_estoque + "' AND BAIXADO_ITEM_ENT = '1' ORDER BY COD_ITENS_NOTA_ENT DESC";
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
                        "SELECT QTDE_ESTOQUE_SAIDA FROM ESTOQUE_SAIDA WHERE COD_ITEM_ESTOQUE_SAIDA = '" + cod_estoque + "'";
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

                    //buscar reservadas
                    FbCommand select_op = new FbCommand();
                    select_op.Connection = fbConnection1;
                    fbConnection1.Open();
                    select_op.CommandText =
                        "SELECT QTDE_MATERIAL_OP FROM OP WHERE COD_MATERIAL_OP = '" + cod_estoque + "' AND (MATERIAL_RETIRADO_OP != '1' OR MATERIAL_RETIRADO_OP IS NULL)";
                    FbDataAdapter opDataAdapter = new FbDataAdapter();
                    opDataAdapter.SelectCommand = select_op;
                    DataSet opDataSet = new DataSet();
                    opDataAdapter.Fill(opDataSet);
                    fbConnection1.Close();
                    double reservadas = 0;
                    foreach (DataRow dr_op in opDataSet.Tables[0].Rows)
                    {
                        try
                        {
                            reservadas = reservadas + Convert.ToDouble(dr_op[0].ToString());
                        }
                        catch { }
                    }

                    //buscar aguardando
                    //buscar reservadas
                    FbCommand select_itens_ped = new FbCommand();
                    select_itens_ped.Connection = fbConnection1;
                    fbConnection1.Open();
                    select_itens_ped.CommandText =
                        "SELECT QTDE_ITEM_PED, QTDE_LOTE_ITEM_PED FROM ITENS_PEDIDO_COMPRA WHERE COD_ESTOQUE_ITEM_PED = '" + cod_estoque + "' AND (CHEGOU_ITEM_PED != '1' OR CHEGOU_ITEM_PED IS NULL)";
                    FbDataAdapter itens_pedDataAdapter = new FbDataAdapter();
                    itens_pedDataAdapter.SelectCommand = select_itens_ped;
                    DataSet itens_pedDataSet = new DataSet();
                    itens_pedDataAdapter.Fill(itens_pedDataSet);
                    fbConnection1.Close();
                    double aguardando = 0;
                    foreach (DataRow dr_itens_ped in itens_pedDataSet.Tables[0].Rows)
                    {
                        try
                        {
                            if (dr_itens_ped[1].ToString() != "")
                            {
                                aguardando = aguardando + Convert.ToDouble(dr_itens_ped[1].ToString());
                            }
                            else
                            {
                                aguardando = aguardando + Convert.ToDouble(dr_itens_ped[0].ToString());
                            }
                        }
                        catch
                        {
                            aguardando = aguardando + Convert.ToDouble(dr_itens_ped[0].ToString());
                        }
                    }


                    //terminar as contas com as entradas, saidas, reservado e aguardando


                    double saldo = 0; //armazenado
                    try
                    {
                        saldo = entradas - saidas;
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
                        "UPDATE ESTOQUE SET ESTOQUE_ATUAL_ESTOQUE = '" + saldo.ToString().Replace(".","").Replace(",",".") + "', " +
                        "ESTOQUE_DISPONIVEL_ESTOQUE = '" + disponivel.ToString().Replace(".", "").Replace(",", ".") + "', " +
                        "ESTOQUE_AGUARDANDO_ESTOQUE = '" + aguardando.ToString().Replace(".", "").Replace(",", ".") + "', " +
                        "ESTOQUE_RESERVADO_ESTOQUE = '" + reservadas.ToString().Replace(".", "").Replace(",", ".") + "', " +
                        "VALOR_ULTIMA_COMPRA_ESTOQUE = '" + ultima_compra.ToString().Replace(".", "").Replace(",", ".") + "' " +
                        "WHERE COD_ESTOQUE = '" + cod_estoque + "'";
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

        public void acertarEstoqueProdutos(string codBarras)
        {

            if (codBarras != "")
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
            else
            {
                erro = true;
                //form_erro erro = new form_erro();
                //erro.erro = "Não existe código de estoque";
                //erro.ShowDialog();
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
