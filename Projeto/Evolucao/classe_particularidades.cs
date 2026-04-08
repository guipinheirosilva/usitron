using System;
using System.Collections.Generic;
using System.Text;
using FirebirdSql.Data.FirebirdClient;
using System.Data;

namespace Evolucao
{
    class classe_particularidades
    {
        public string n_nf;
        public string cod_sistema_nf;
        public List<string> EANnaoEncontrado = new List<string>();
        public void executar_particularidades(string nf)
        {
            n_nf = nf;
            baixar_do_estoque();
        }
        public void insere_estoque()
        {
            string codEan;
            
            FbConnection conexao = new FbConnection();
            conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=10.3.3.4;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
            try
            {
                FbCommand comando = new FbCommand();
                comando.Connection = conexao;
                comando.CommandText =
                    "SELECT * FROM ITENS_NOTA_ENT WHERE COD_SISTEMA_NF_ITEM_ENT = '" + n_nf + "'";
                conexao.Open();
                FbDataAdapter itensDataAdapter = new FbDataAdapter();
                itensDataAdapter.SelectCommand = comando;
                DataSet itensDataSet = new DataSet();
                itensDataAdapter.Fill(itensDataSet);
                conexao.Close(); 
                foreach (DataRow dr in itensDataSet.Tables[0].Rows)
                {
                    string cfop = "";
                    try
                    {
                        cfop = dr["CFOP_ITEM_ENT"].ToString();
                        codEan = dr["COD_EAN_ITEM_ENT"].ToString();

                        if (cfop == "5202" || cfop == "5411" || cfop == "6202" || cfop == "6411")
                        {
                        }
                        else
                        {
                            comando = new FbCommand();
                            comando.Connection = conexao;
                            comando.CommandText =
                                "SELECT COD_BARRAS_CAIXA_PRODUTO, COD_BARRAS_PRODUTO, QTDE_UNIDADE_PRODUTO, CNPJ_FORNECEDOR_PRODUTO, COD_PRODUTO " +
                                "FROM PRODUTOS WHERE (COD_BARRAS_CAIXA_PRODUTO = '" + codEan + "' OR COD_BARRAS_PRODUTO = '" + codEan + "')";
                            conexao.Open();
                            FbDataAdapter datTable = new FbDataAdapter();
                            datTable.SelectCommand = comando;
                            DataSet dsTable = new DataSet();
                            datTable.Fill(dsTable);
                            conexao.Close();
                            int i = 0;
                            try
                            {
                                foreach (DataRow drProd in dsTable.Tables[0].Rows)
                                {
                                    //classeEstoque estoque = new classeEstoque();
                                    //estoque.fbConnection1.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=10.3.3.4;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
                                    //estoque.calcular_estoque(drProd[0].ToString(), drProd[1].ToString(), drProd[2].ToString(), drProd[3].ToString(), drProd[4].ToString());
                                    //i++;
                                }
                            }
                            catch
                            {
                                EANnaoEncontrado.Add(codEan);
                            }
                            if(i == 0)
                                EANnaoEncontrado.Add(codEan);

                        }
                    }
                    catch (Exception a)
                    {
                        conexao.Close(); 
                        form_erro erro = new form_erro();
                        erro.erro = a.ToString();
                        erro.ShowDialog();
                    }
                }
            }
            catch (Exception a)
            {
                conexao.Close(); 
                form_erro erro = new form_erro();
                erro.erro = a.ToString();
                erro.ShowDialog();
            }

        }
        public void baixar_do_estoque()
        {
            string codEan;
            FbConnection conexao = new FbConnection();
            conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=10.3.3.4;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
            try
            {
                FbCommand comando = new FbCommand();
                comando.Connection = conexao;
                comando.CommandText =
                 //   "SELECT * FROM ITENS_NOTA WHERE NF_ITEM = '" + n_nf + "'";
                 "SELECT * FROM ITENS_NOTA WHERE COD_SISTEMA_NF_ITEM = '" + cod_sistema_nf + "'";
                conexao.Open();
                FbDataAdapter itensDataAdapter = new FbDataAdapter();
                itensDataAdapter.SelectCommand = comando;
                DataSet itensDataSet = new DataSet();
                itensDataAdapter.Fill(itensDataSet);
                conexao.Close(); 
                foreach (DataRow dr in itensDataSet.Tables[0].Rows)
                {
                    try
                    {
                        try
                        {
                            classeEstoque estoque = new classeEstoque();
                            estoque.fbConnection1.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=10.3.3.4;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
                            estoque.calcular_estoque(dr["COD_ITEM"].ToString());
                        }
                        catch { }
                        if (dr["COD_ITEM_LIBERACAO_ITEM"].ToString() != "")
                        {
                            acertar_status_itens_pedido(dr["COD_ITEM_LIBERACAO_ITEM"].ToString(), dr["COD_ITENS_NOTA"].ToString(), conexao);
                        }
                       
                    }
                    catch (Exception a)
                    {
                        conexao.Close(); 
                        form_erro erro = new form_erro();
                        erro.erro = a.ToString();
                        erro.ShowDialog();
                    }
                }
            }
            catch (Exception a)
            {
                conexao.Close(); 
                form_erro erro = new form_erro();
                erro.erro = a.ToString() ;
                erro.ShowDialog();
            }
        }

        private void acertar_status_itens_pedido(string cod_item_liberacao, string cod_item_nota, FbConnection conexao)
        {
            try
            {
                try
                {
                    FbCommand select = new FbCommand();
                    select.Connection = conexao;
                    select.CommandText =
                        @"SELECT ipv.COD_ITEM_VENDA FROM ITENS_LIBERACAO il 
                                inner join ITENS_PEDIDO_VENDA ipv on il.COD_ITEM_PEDIDO_ITEM_LIB = ipv.COD_ITEM_VENDA 
                                WHERE il.COD_ITEM_LIB = '" + cod_item_liberacao + "'";
                    conexao.Open();
                    FbDataAdapter datSelect = new FbDataAdapter();
                    datSelect.SelectCommand = select;
                    DataTable dtSelect = new DataTable();
                    datSelect.Fill(dtSelect);
                    conexao.Close();

                    foreach (DataRow dr in dtSelect.Rows)
                    {
                        FbCommand select1 = new FbCommand();
                        select1.Connection = conexao;
                        select1.CommandText =
                            @"SELECT sum(inf.QTDE_ITEM), ipv.QTDE_ITEM_VENDA, ipv.COD_ITEM_VENDA, ipv.COD_PEDIDO_ITEM_VENDA FROM ITENS_NOTA inf 
                                inner join ITENS_LIBERACAO il on inf.COD_ITEM_LIBERACAO_ITEM = il.COD_ITEM_LIB
                                inner join ITENS_PEDIDO_VENDA ipv on il.COD_ITEM_PEDIDO_ITEM_LIB = ipv.COD_ITEM_VENDA 
                                WHERE ipv.COD_ITEM_VENDA = '" + dr[0].ToString() + "' group by ipv.QTDE_ITEM_VENDA, ipv.COD_ITEM_VENDA, ipv.COD_PEDIDO_ITEM_VENDA ";
                        conexao.Open();
                        FbDataAdapter datSelect1 = new FbDataAdapter();
                        datSelect1.SelectCommand = select1;
                        DataTable dtSelect1 = new DataTable();
                        datSelect1.Fill(dtSelect1);
                        conexao.Close();
                        foreach (DataRow dr1 in dtSelect1.Rows)
                        {
                            string finalizado = "null";
                            try
                            {
                                if (Convert.ToDouble(dr1[0].ToString()) >= Convert.ToDouble(dr1[1].ToString()))
                                    finalizado = "1";

                                FbCommand update = new FbCommand();
                                update.Connection = conexao;
                                update.CommandText =
                                    @"UPDATE ITENS_PEDIDO_VENDA SET FINALIZADO_ITEM_VENDA = " + finalizado + ", QTDE_FATURADA_ITEM_VENDA = '" + 
                                    Convert.ToDouble(dr1[0].ToString()).ToString().Replace(".","").Replace(",",".") + "', ITEM_NOTA_ITEM_VENDA = '" + cod_item_nota + "' WHERE COD_ITEM_VENDA = '" + dr1[2].ToString() + "'";
                                conexao.Open();
                                FbDataAdapter datUpdate = new FbDataAdapter();
                                datUpdate.UpdateCommand = update;
                                datUpdate.UpdateCommand.ExecuteNonQuery();
                                conexao.Close();
                            }
                            catch { conexao.Close(); }

                            FbCommand select2 = new FbCommand();
                            select2.Connection = conexao;
                            select2.CommandText =
                                @"SELECT ipv.COD_ITEM_VENDA, FINALIZADO_ITEM_VENDA FROM ITENS_pedido_venda ipv
                                WHERE ipv.COD_PEDIDO_ITEM_VENDA = '" + dr1[3].ToString() + "'";
                            conexao.Open();
                            FbDataAdapter datSelect2 = new FbDataAdapter();
                            datSelect2.SelectCommand = select2;
                            DataTable dtSelect2 = new DataTable();
                            datSelect2.Fill(dtSelect2);
                            conexao.Close();
                            bool todos_finalizados = true;
                            foreach (DataRow dr2 in dtSelect2.Rows)
                            {
                                if (dr2[1].ToString() != "1")
                                    todos_finalizados = false;
                            }

                            if (todos_finalizados)
                            {
                                try
                                {
                                    FbCommand update1 = new FbCommand();
                                    update1.Connection = conexao;
                                    update1.CommandText =
                                        @"UPDATE PEDIDOS_VENDA SET STATUS_PED_VENDA = 'Faturado' WHERE COD_PED_VENDA = '" + dr1[3].ToString() + "'";
                                    conexao.Open();
                                    FbDataAdapter datUpdate1 = new FbDataAdapter();
                                    datUpdate1.UpdateCommand = update1;
                                    datUpdate1.UpdateCommand.ExecuteNonQuery();
                                    conexao.Close();
                                }
                                catch { conexao.Close(); }
                            }

                        }
                    }

                }
                catch
                {
                    conexao.Close();
                }
            }
            catch (Exception ex)
            {
                conexao.Close();
            }
        }
       
    }
}
