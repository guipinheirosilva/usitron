using System;
using System.Collections.Generic;
using System.Text;
using FirebirdSql.Data.FirebirdClient;
using System.Data;

namespace Evolucao
{
    class classeEstoque_pecas
    {
        public FbConnection conexao = new FbConnection();
        

        
        /*
        public int estoque_fisico { get; set; } //QTDE ENTRADAS - QTDE SAIDAS
        public int estoque_disponivel { get; set; } //ESTOQUE_FISICO + QTDE_EM_PRODUCAO - QTDE_RESERVADO
        public int estoque_reservado { get; set; } //ESTOQUE_FISICO - (QTDE_ENT_PA - QTDE_SAI_ENT_PA)
        public int estoque_reservado_edi{ get; set; } // QTDE_RESERVADO_EDI
        public int estoque_producao { get; set; } //QTDE_A_FABRICAR_OP PREVISAO
        */
        public double estoque_fisico;
        public double estoque_disponivel;
        public double estoque_reservado;
        public double estoque_reservado_edi;
        public double estoque_producao;
        public string peca_escolhida;
        public string localizacao;
        public void calcular_estoque(string peca, string rev)
        {
            peca = peca.Replace("'", "");
            rev = rev.Replace("'", "");
            try
            {
                FbDataAdapter datOp = new FbDataAdapter();
                FbDataAdapter datEntrada_pa = new FbDataAdapter();
                FbDataAdapter datSaida_pa = new FbDataAdapter();
                FbDataAdapter datEdi = new FbDataAdapter();
                FbDataAdapter datEstoque_peca = new FbDataAdapter();
                FbDataAdapter datOf = new FbDataAdapter();

                DataSet dsOp = new DataSet();
                DataSet dsEntrada_pa = new DataSet();
                DataSet dsSaida_pa = new DataSet();
                DataSet dsEdi = new DataSet();
                DataSet dsEstoque_peca = new DataSet();
                DataSet dsOf = new DataSet();

                
                //conexao.Open();

                FbCommand comando_select = new FbCommand();
                comando_select.Connection = conexao;


                comando_select.CommandText = "SELECT * FROM OP WHERE COND_PGTO LIKE '" + peca +
                        "' AND REVISAO_OP like '" + rev +
                        "' ORDER BY COD_OP DESC";
                datOp.SelectCommand = comando_select;
                datOp.Fill(dsOp);

                comando_select.CommandText = "SELECT * FROM ENTRADA_PA WHERE PECA_ENT_PA = '" + peca +
                      "' AND REVISAO_ENT_PA like '" + rev +
                      "' ORDER BY COD_ENT_PA DESC";
                datEntrada_pa.SelectCommand = comando_select;
                datEntrada_pa.Fill(dsEntrada_pa);

                comando_select.CommandText = "SELECT * FROM SAIDA_PA WHERE PECA_SAI_PA = '" + peca +
                     "' AND REVISAO_SAI_PA like '" + rev +
                      "' ORDER BY COD_SAI_PA DESC";
                datSaida_pa.SelectCommand = comando_select;
                datSaida_pa.Fill(dsSaida_pa);
                
                comando_select.CommandText = "SELECT * FROM EDI WHERE COD_ITEM_EDI = '" + peca +
                    "' AND N_REVISAO_EDI like '" + rev + // enquanto não tiver revisão no edi
                      "' ORDER BY COD_EDI DESC";
                datEdi.SelectCommand = comando_select;
                datEdi.Fill(dsEdi);
                
                comando_select.CommandText = "SELECT * FROM ESTOQUE_PECAS WHERE PECA_EST_PECA = '" + peca +
                    "' AND REV_EST_PECA like '" + rev + //enquanto não tiver revisão no edi
                      "' ORDER BY COD_EST_PECA";
                datEstoque_peca.SelectCommand = comando_select;
                datEstoque_peca.Fill(dsEstoque_peca);

                comando_select.CommandText = "SELECT * FROM OFS WHERE COD_PECA_OF = '" + peca +
                    "' AND REVISAO_OF like '" + rev + //enquanto não tiver revisão no edi
                      "' AND SIT_ATUAL_OF = 'OF CRIADA' ORDER BY COD_OF";
                datOf.SelectCommand = comando_select;
                datOf.Fill(dsOf);


                double qtde_entradas = 0, qtde_saidas_of = 0, qtde_saidas_estoque = 0, qtde_em_producao_estoque = 0;

                foreach (DataRow entradas in dsEntrada_pa.Tables[0].Rows)
                {
                    try
                    {
                        qtde_entradas = qtde_entradas + Convert.ToDouble(entradas["QTDE_ENT_PA"].ToString());
                        //qtde_saidas_of = qtde_saidas_of + Convert.ToInt32(entradas["QTDE_SAI_ENT_PA"].ToString());
                    }
                    catch { }
                }
                
                foreach (DataRow saidas_of in dsOf.Tables[0].Rows)
                {
                    try
                    {
                        qtde_saidas_of = qtde_saidas_of + Convert.ToDouble(saidas_of["QTDE_PEDIDO_OF"].ToString());
                    }
                    catch
                    { }
                }
                 
                foreach (DataRow saidas in dsSaida_pa.Tables[0].Rows)
                {
                    try
                    {
                        qtde_saidas_estoque = qtde_saidas_estoque + Convert.ToDouble(saidas["QTDE_SAI_PA"].ToString());
                    }
                    catch { }
                }
                foreach (DataRow ops in dsOp.Tables[0].Rows)
                {
                    try
                    {
                        if (ops["COLOCADO_EM_ESTOQUE_OP"].ToString() != "1")// &&
                        //    ops["PREVISAO_OP"].ToString() == "1")
                            qtde_em_producao_estoque = qtde_em_producao_estoque +
                                Convert.ToDouble(ops["QDE_FAB"].ToString());
                    }
                    catch { }
                }
                /*
                foreach (DataRow edi in dsEdi.Tables[0].Rows)
                {
                    try
                    {
                        if(edi["QTDE_RESERVADA_EDI"].ToString() != "")
                            estoque_reservado_edi = estoque_reservado_edi + Convert.ToInt32(edi["QTDE_RESERVADA_EDI"].ToString());
                    }
                    catch { }
                }
                 */

                foreach (DataRow est in dsEstoque_peca.Tables[0].Rows)
                {
                    try
                    {
                        if (est["ESTOQUE_RESERVADO_EDI_PECA"].ToString() != "")// && est["STATUS_EDI"].ToString().Contains("EM ESTOQUE"))
                            estoque_reservado_edi = estoque_reservado_edi + Convert.ToInt32(est["ESTOQUE_RESERVADO_EDI_PECA"].ToString());
                    }
                    catch { }
                }


                double qtde_estoque = qtde_entradas - qtde_saidas_estoque;
                double qtde_reservada = qtde_saidas_of; //qtde_estoque - (qtde_entradas - qtde_saidas_of);
                //int qtde_reservada = qtde_estoque - (qtde_entradas - qtde_saidas_of);
                double qtde_total = qtde_estoque + qtde_em_producao_estoque;
                double qtde_disponivel = qtde_estoque + qtde_em_producao_estoque - qtde_reservada;
                estoque_reservado = qtde_reservada;
                estoque_producao = qtde_em_producao_estoque;
                estoque_disponivel = qtde_disponivel;
                estoque_fisico = qtde_estoque;
                //conexao.Close();
            }
            catch (Exception a)
            {
                conexao.Close();
                form_erro erro = new form_erro();
                erro.erro = a.ToString();
                erro.Opacity = 0;
                erro.Show();
                
            }

        }

        public string[,] buscar_ops_disponiveis(string qtde_of, out int qtde_encontrada, string rev)
        {
            
            rev = rev.Replace("'", "");
            string[,] qtde_comprometida = new string[2, 200];
            int n_linhas_comprometidas = 0;
            int qtde_somada = 0;
            FbDataAdapter datEntrada_pa = new FbDataAdapter();
            DataSet dsEntrada_pa = new DataSet();
            //FbConnection conexao = new FbConnection();
            //conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=10.3.3.4;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
            //conexao.Open();
            FbCommand comando_select = new FbCommand();
            comando_select.Connection = conexao;
            comando_select.CommandText = "SELECT * FROM ENTRADA_PA WHERE PECA_ENT_PA = '" + peca_escolhida +
                     "' AND REVISAO_ENT_PA = '" + rev +
                  "' ORDER BY COD_ENT_PA DESC";
            datEntrada_pa.SelectCommand = comando_select;
            datEntrada_pa.Fill(dsEntrada_pa);


            for (int j = dsEntrada_pa.Tables[0].Rows.Count - 1; j >= 0 && qtde_somada != Convert.ToInt32(qtde_of); j--)
            {
                int qtde_ent, qtde_sai;
                int qtde_comp;
                //pegando a qtde de entrada
                DataRow dr  = dsEntrada_pa.Tables[0].Rows[j];
                try
                {
                    qtde_ent = Convert.ToInt32(dr["QTDE_ENT_PA"].ToString());
                    try
                    {
                        qtde_sai = Convert.ToInt32(dr["QTDE_SAI_ENT_PA"].ToString());
                    }
                    //pegando qtde que ja saiu
                    catch
                    {
                        qtde_sai = 0;
                    }
                    if (qtde_sai < qtde_ent)
                    {
                        qtde_comp = qtde_ent - qtde_sai;
                        qtde_somada = qtde_somada + qtde_comp;
                        //se ultrapassou o pedido
                        if (qtde_somada > Convert.ToInt32(qtde_of))
                        {
                            qtde_comp = qtde_comp - (qtde_somada - Convert.ToInt32(qtde_of));
                            qtde_comprometida[0, n_linhas_comprometidas] = dr["OP_ENT_PA"].ToString();
                            qtde_comprometida[1, n_linhas_comprometidas] = qtde_comp.ToString();
                            qtde_somada = qtde_somada - (qtde_somada - Convert.ToInt32(qtde_of));
                            n_linhas_comprometidas++;
                        }
                        else
                        {
                            qtde_comprometida[0, n_linhas_comprometidas] = dr["OP_ENT_PA"].ToString();
                            qtde_comprometida[1, n_linhas_comprometidas] = qtde_comp.ToString();
                            n_linhas_comprometidas++;
                        }

                    }
                }
                catch(Exception a)
                {
                    conexao.Close();
                    form_erro erro = new form_erro();
                    erro.erro = a.ToString();
                    erro.Opacity = 0;
                    erro.Show();
                    //MessageBox.Show("Não existe quantidade de entrada na linha. Verifique");
                }
            }
            qtde_encontrada = qtde_somada;
            return qtde_comprometida;
        }

        internal void comprometer_estoque_edi(string qtde, string peca, string rev)
        {
            peca = peca.Replace("'", "");
            rev = rev.Replace("'", "");
            //ESTOQUE_RESERVADO_EDI_PECA
            try
            {
                peca = peca.Replace("'", "");
                FbDataAdapter datEstoque_pecas = new FbDataAdapter();
                DataSet dsEstoque_pecas = new DataSet();
                //FbConnection conexao = new FbConnection();
                //conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=10.3.3.4;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
               // conexao.Open();
                FbCommand comando_select = new FbCommand();
                comando_select.Connection = conexao;
                comando_select.CommandText = "UPDATE ESTOQUE_PECAS SET ESTOQUE_RESERVADO_EDI_PECA = " +
                    "ESTOQUE_RESERVADO_EDI_PECA + " + qtde + " WHERE PECA_EST_PECA = '" + peca + "' AND REV_EST_PECA = '" + rev + "'"; 
                datEstoque_pecas.UpdateCommand = comando_select;
                datEstoque_pecas.UpdateCommand.ExecuteNonQuery();



            }
            catch (Exception a)
            {
                conexao.Close();
                form_erro erro = new form_erro();
                erro.erro = a.ToString();
                erro.Opacity = 0;
                erro.Show();
            }

        }

        internal void decrementar_estoque_edi(string peca, string qtde, string rev)
        {
            peca = peca.Replace("'", "");
            rev = rev.Replace("'", "");
            //ESTOQUE_RESERVADO_EDI_PECA
            try
            {
                peca = peca.Replace("'", "");
                FbDataAdapter datEstoque_pecas = new FbDataAdapter();
                DataSet dsEstoque_pecas = new DataSet();
                //FbConnection conexao = new FbConnection();
                //conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=10.3.3.4;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
                //conexao.Open();
                FbCommand comando_select = new FbCommand();
                comando_select.Connection = conexao;
                comando_select.CommandText = "UPDATE ESTOQUE_PECAS SET ESTOQUE_RESERVADO_EDI_PECA = " +
                    "ESTOQUE_RESERVADO_EDI_PECA - " + qtde + " WHERE PECA_EST_PECA = '" + peca + "' AND REV_EST_PECA = '" + rev + "' AND ESTOQUE_RESERVADO_EDI_PECA >= " + qtde; 
                datEstoque_pecas.UpdateCommand = comando_select;
                datEstoque_pecas.UpdateCommand.ExecuteNonQuery();
            }
            catch (Exception a)
            {
                conexao.Close();
                form_erro erro = new form_erro();
                erro.erro = a.ToString();
                erro.Opacity = 0;
                erro.Show();
            }
        }

        internal void atualizar_tabela(string peca, string rev)
        {
            try
            {
                peca = peca.Replace("'", "");
                rev = rev.Replace("'", "");
                FbDataAdapter datEstoque_pecas = new FbDataAdapter();
                DataSet dsEstoque_pecas = new DataSet();
                //FbConnection conexao = new FbConnection();
                //conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=10.3.3.4;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
                //conexao.Open();
                string local = "";
                if (localizacao != "'null'" && localizacao != null )
                    local = ", LOCAL_EST_PECA = '" + localizacao.Replace("'","") + "'";

                FbCommand comando_select = new FbCommand();
                comando_select.Connection = conexao;
                comando_select.CommandText = "UPDATE ESTOQUE_PECAS SET ESTOQUE_ATUAL_EST_PECA = " + estoque_fisico.ToString().Replace(".", "").Replace(",", ".") + ", " +
                    " ESTOQUE_PRODUCAO_EST_PECA = " + estoque_producao.ToString().Replace(".","").Replace(",",".") + ", " +
                    " ESTOQUE_RESERVADO_EST_PECA = " + estoque_reservado.ToString().Replace(".", "").Replace(",", ".") + ", " +
                    " ESTOQUE_DISPONIVEL_EST_PECA = " + estoque_disponivel.ToString().Replace(".", "").Replace(",", ".") + "" +
                    local +
                    " WHERE PECA_EST_PECA = '" + peca + "' AND REV_EST_PECA = '" + rev + "'";
                datEstoque_pecas.UpdateCommand = comando_select;
                datEstoque_pecas.UpdateCommand.ExecuteNonQuery();
            }
            catch (Exception a)
            {
                conexao.Close();
                form_erro erro = new form_erro();
                erro.erro = a.ToString();
                erro.Opacity = 0;
                erro.ShowDialog();
            }
               
        }

        internal void verificar_se_existe(string peca, string rev, string local)
        {
            try
            {
                peca = peca.Replace("'", "");
                rev = rev.Replace("'", "");
                FbDataAdapter datEstoque_pecas = new FbDataAdapter();
                //FbConnection conexao = new FbConnection();
                //conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=10.3.3.4;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
                //conexao.Open();
                FbCommand comando_select = new FbCommand();
                comando_select.Connection = conexao;

                comando_select.CommandText = "SELECT * FROM ESTOQUE_PECAS " +
                    "WHERE PECA_EST_PECA = '" + peca + "' AND REV_EST_PECA = '" +
                    rev + "'";
                DataSet est = new DataSet();
                //conexao.Open();
                datEstoque_pecas.SelectCommand = comando_select;
                datEstoque_pecas.Fill(est);
                //conexao.Close();
                if (est.Tables[0].Rows.Count == 0)
                {
                    if (local == "''")
                        local = "null";
                    if (local == "")
                        local = "null";
                    if(local == null)
                        local = "null";
                    comando_select.CommandText = 
                        "INSERT INTO ESTOQUE_PECAS (ESTOQUE_ATUAL_EST_PECA, ESTOQUE_PRODUCAO_EST_PECA, " +
                        "PECA_EST_PECA, REV_EST_PECA, ESTOQUE_RESERVADO_EST_PECA, ESTOQUE_DISPONIVEL_EST_PECA, ESTOQUE_RESERVADO_EDI_PECA, LOCAL_EST_PECA) " +
                        "VALUES ('0','0','" + peca + "','" + rev + "','0','0','0'," + local + ")";
                    //conexao.Open();
                    datEstoque_pecas.InsertCommand = comando_select;
                    comando_select.ExecuteNonQuery();
                    //conexao.Close();
                }
            }
            catch (Exception a)
            {
                conexao.Close();
                form_erro erro = new form_erro();
                erro.erro = a.ToString();
                erro.Opacity = 0;
                erro.ShowDialog();
                
            }
        }
    }




}
