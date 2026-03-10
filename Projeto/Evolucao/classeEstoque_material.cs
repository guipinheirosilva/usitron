using System;
using System.Collections.Generic;
using System.Text;
using FirebirdSql.Data.FirebirdClient;
using System.Data;

namespace Evolucao
{
    class classeEstoque_material
    {
        public FbConnection fbConnection1 = new FbConnection();
        

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
                        "SELECT QTDE_LOTE_ITEM_ENT, PRECO_TOTAL_ITEM_ENT FROM ITENS_NOTA_ENT " +
                        "WHERE COD_ITEM_EST_ITEM_ENT = '" + cod_estoque + 
                        "' AND BAIXADO_ITEM_ENT = '1' ORDER BY COD_ITENS_NOTA_ENT DESC";
                    FbDataAdapter entradasDataAdapter = new FbDataAdapter();
                    entradasDataAdapter.SelectCommand = select_entradas;
                    DataSet entradasDataSet = new DataSet();
                    entradasDataAdapter.Fill(entradasDataSet);
                    fbConnection1.Close();
                    double entradas = 0;
                    foreach (DataRow dr in entradasDataSet.Tables[0].Rows)
                    {
                        try
                        {
                            entradas = entradas + Convert.ToDouble(dr[0].ToString());
                        }
                        catch { }
                    }
                     
                    //buscar saidas
                    FbCommand select_saidas = new FbCommand();
                    select_saidas.Connection = fbConnection1;
                    fbConnection1.Open();
                    select_saidas.CommandText =
                        "SELECT QTDE_ESTOQUE_SAIDA FROM ESTOQUE_SAIDA WHERE COD_ITEM_ESTOQUE_SAIDA = '" + cod_estoque + "' ";//ULTIMO INVENTÁRIO DIA 01/08/2017 - GUILHERME/ANDRÉ
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
                    /*
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
                    
                    //buscar entradas
                    FbCommand select_itens_ped = new FbCommand();
                    select_itens_ped.Connection = fbConnection1;
                    fbConnection1.Open();
                    select_itens_ped.CommandText =
                        "SELECT QTDE_ITEM_PED FROM ITENS_PEDIDO_COMPRA WHERE ITEM_ITEM_PED = '" + cod_estoque + "' AND (CHEGOU_ITEM_PED = '1')";
                    FbDataAdapter itens_pedDataAdapter = new FbDataAdapter();
                    itens_pedDataAdapter.SelectCommand = select_itens_ped;
                    DataSet itens_pedDataSet = new DataSet();
                    itens_pedDataAdapter.Fill(itens_pedDataSet);
                    fbConnection1.Close();
                    double entradas = 0;
                    foreach (DataRow dr_itens_ped in itens_pedDataSet.Tables[0].Rows)
                    {
                        try
                        {
                            entradas = entradas + Convert.ToDouble(dr_itens_ped[0].ToString());
                        }
                        catch
                        {
                            
                        }
                    }
                    */

                    //terminar as contas com as entradas, saidas, reservado e aguardando


                    double saldo = 0; //armazenado
                    try
                    {
                        saldo = entradas - saidas;
                        //string.Format("{0:N}", saldo);
                    }
                    catch { }


                    //update estoque
                    FbCommand update = new FbCommand();
                    update.Connection = fbConnection1;
                    fbConnection1.Open();
                    update.CommandText =
                        "UPDATE ESTOQUE SET ESTOQUE_ATUAL_ESTOQUE = '" + saldo.ToString("n5").Replace(".","").Replace(",",".") + "' " +
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
                /*
                form_erro erro = new form_erro();
                erro.erro = "Não existe código de estoque";
                erro.ShowDialog();
                 * */
            }
        }
    }

}
