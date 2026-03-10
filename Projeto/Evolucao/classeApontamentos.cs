using System;
using System.Collections.Generic;
using System.Text;
using FirebirdSql.Data.FirebirdClient;
using System.Data;

namespace Evolucao
{
    class classeApontamentos
    {
        public string lote;
        public bool ok = true;
        public string operador;
        public string maquina;
        public string[,] rotas = new string[2000,2];
        public string[] apontamentos_a_parar = new string[2000];
        public string rota;
        public int rotas_conjuntas;
        public bool servico_externo;
        public string _fornecedor_se;
        public string _cnpj_fornecedor_se;
        public double _horas_se;
        public double _valor_se;

        public FbConnection fbConnection1 = new FbConnection();
        
        internal bool verificar_operador()
        {
            try
            {
                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT COD_OPERADOR FROM OPERADORES WHERE COD_OPERADOR = '" + operador + "'";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datOperadores = new FbDataAdapter();
                datOperadores.SelectCommand = select;
                DataSet dsOperadores = new DataSet();
                datOperadores.Fill(dsOperadores);
                fbConnection1.Close();
                if (dsOperadores.Tables[0].Rows.Count > 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                fbConnection1.Close();
                return false;
            }
        }

        internal bool verificar_maquina()
        {
            try
            {
                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT ABREVIACAO_MAQUINA FROM MAQUINAS WHERE ABREVIACAO_MAQUINA = '" + maquina + "'";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datMaquinas = new FbDataAdapter();
                datMaquinas.SelectCommand = select;
                DataSet dsMaquinas = new DataSet();
                datMaquinas.Fill(dsMaquinas);
                fbConnection1.Close();
                if (dsMaquinas.Tables[0].Rows.Count > 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                fbConnection1.Close();
                return false;
            }
        }

        internal bool verificar_rota()
        {
            try
            {
                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT COD_ROTA_CAMPO FROM ROTAS_CAMPO WHERE COD_ROTA_CAMPO = '" + rota + "'";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datRotas = new FbDataAdapter();
                datRotas.SelectCommand = select;
                DataSet dsRotas = new DataSet();
                datRotas.Fill(dsRotas);
                fbConnection1.Close();
                if (dsRotas.Tables[0].Rows.Count > 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                fbConnection1.Close();
                return false;
            }
        }

        internal void inserir_inicio()
        {
            
            for (int i = 0; i < rotas_conjuntas; i++)
            {
                if (verificar_se_nao_tem_apontamento_no_sistema_antigo(rotas[i, 0]))
                {
                    if (!verificar_se_ja_existe_inicio_na_rota(rotas[i, 0]))
                    {
                        update_entrada_rota(rotas[i, 0]);
                    }
                    else
                    {
                        update_fechamento_rota(rotas[i, 0]);
                    }
                    double horas_manuais = 0;
                    try
                    {
                        if (Convert.ToDouble(rotas[i, 1]) > 0)
                            horas_manuais = Convert.ToDouble(rotas[i, 1]);
                    }
                    catch { }
                    if (horas_manuais > 0)
                    {
                        DateTime ultima_parada = buscar_ultima_parada(maquina, rotas[i,0]);
                        if (ultima_parada.ToShortDateString() != Convert.ToDateTime("01/01/2001").ToShortDateString())
                        {
                            inserir_reinicio_manual(ultima_parada, rotas[i, 0]);
                            int numero_dias_depois = 0; DateTime inicio = new DateTime();
                            if (verificar_se_agora_maior_data_entrada(rotas[i, 0], out numero_dias_depois, out inicio, ultima_parada.AddHours(horas_manuais)))
                            {

                                for (int j = 1; j <= numero_dias_depois; j++)
                                {
                                    inserir_parada_do_dia(inicio, rotas[i, 0]);
                                    inserir_reinicio_do_proximo_dia(inicio.AddDays(1), rotas[i, 0]);
                                    inicio = inicio.AddDays(1);
                                }
                            }
                            inserir_parada_manual(ultima_parada.AddHours(horas_manuais), rotas[i, 0]);
                            atualizar_situacao_atual(rotas[i, 0]);
                            calcular_horas(rotas[i, 0]);
                            

                            FbCommand update_semana = new FbCommand();
                            update_semana.Connection = fbConnection1;
                            fbConnection1.Open();
                            update_semana.CommandText =
                                "UPDATE HORAS_SEMANA SET SITUACAO_ROTA_SEMANA = 'EM ANDAMENTO'" +
                                " WHERE ROTA_HORAS_SEMANA = '" + rotas[i, 0] + "'";
                            FbDataAdapter datUpdate_semana = new FbDataAdapter();
                            datUpdate_semana.UpdateCommand = update_semana;
                            datUpdate_semana.UpdateCommand.ExecuteNonQuery();
                            fbConnection1.Close();
                        }
                        else
                        {
                            form_erro erro = new form_erro();
                            erro.erro = "Não existe parada para esta máquina";
                            erro.ShowDialog();
                        }
                    }
                    else
                    {
                        inserir_inicio(rotas[i, 0]);
                        atualizar_situacao_atual(rotas[i, 0]);

                        FbCommand update_semana = new FbCommand();
                        update_semana.Connection = fbConnection1;
                        fbConnection1.Open();
                        update_semana.CommandText =
                            "UPDATE HORAS_SEMANA SET SITUACAO_ROTA_SEMANA = 'EM ANDAMENTO'" +
                            " WHERE ROTA_HORAS_SEMANA = '" + rotas[i, 0] + "'";
                        FbDataAdapter datUpdate_semana = new FbDataAdapter();
                        datUpdate_semana.UpdateCommand = update_semana;
                        datUpdate_semana.UpdateCommand.ExecuteNonQuery();
                        fbConnection1.Close();
                    }
                }
                else
                {
                    form_erro erro = new form_erro();
                    erro.erro = "Esse apontamento foi iniciado no sistema antigo, favor apontá-lo no sistema antigo";
                    erro.ShowDialog();
                }
            }
        }

        private void update_fechamento_rota(string _rota)
        {
            try
            {
                FbCommand update_rota = new FbCommand();
                update_rota.Connection = fbConnection1;
                fbConnection1.Open();
                update_rota.CommandText =
                    "UPDATE ROTAS_CAMPO SET HORA_FECHAMENTO = null, " +
                    "DATA_FECHAMENTO = null WHERE " +
                    "COD_ROTA_CAMPO = '" + _rota + "'";
                FbDataAdapter datRotas = new FbDataAdapter();
                datRotas.UpdateCommand = update_rota;
                datRotas.UpdateCommand.ExecuteNonQuery();
                fbConnection1.Close();
            }
            catch (Exception a)
            {
                ok = false;
                fbConnection1.Close();
                form_erro erro = new form_erro();
                erro.erro = a.ToString();

                erro.ShowDialog();
            }
        }

        

        private DateTime buscar_ultima_parada(string maquina, string _rota)
        {
            DateTime retorno = Convert.ToDateTime("01/01/2001");
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                select.CommandText = 
                    "SELECT DATA_FIM_AP, HORA_FIM_AP FROM APONTAMENTOS WHERE " + 
                    "MAQUINA_AP = '" + maquina + "' AND ROTA_AP = '" + _rota + "' " +
                    "ORDER BY COD_AP DESC";
                fbConnection1.Open();
                FbDataAdapter datAp = new FbDataAdapter();
                datAp.SelectCommand = select;
                DataSet dsAp = new DataSet();
                datAp.Fill(dsAp);
                fbConnection1.Close();
                DataRow dr = dsAp.Tables[0].Rows[0];
                retorno = Convert.ToDateTime(Convert.ToDateTime(dr[0].ToString()).ToShortDateString() + " " +
                    Convert.ToDateTime(dr[1].ToString()).ToShortTimeString());
                return retorno;

            }
            catch
            {
                ok = false;
                fbConnection1.Close();
                return retorno;
            }

        }

        private bool verificar_se_nao_tem_apontamento_no_sistema_antigo(string _rota)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT OPERADOR_CAMPO, DESENHO_CAMPO, SERVICO_EXTERNO_INICIO, N_PDF_CAMPO FROM ROTAS_CAMPO WHERE COD_ROTA_CAMPO = '" + _rota + "'";
                FbDataAdapter datRotas = new FbDataAdapter();
                datRotas.SelectCommand = select;
                DataSet dsRotas = new DataSet();
                datRotas.Fill(dsRotas);
                fbConnection1.Close();
                foreach (DataRow dr in dsRotas.Tables[0].Rows)
                {
                    if (dr[0].ToString() == "" || dr[0].ToString() == null || 
                        dr[1].ToString() == "PESSOAL" || dr[2].ToString() == "1" ||
                        dr[3].ToString() == "ELETRODO") //PESSOAL usado na reibrag //ELETRODO É NO BALDI
                        return true;
                    else
                        return false;
                }
                return false;
            }
            catch(Exception a)
            {
                ok = false;
                fbConnection1.Close();
                form_erro erro = new form_erro();
                erro.erro = a.ToString();
                erro.ShowDialog();
                return false;
            }
        }

        private void atualizar_situacao_atual(string _rota)
        {
            string situacao_atual = "";
            string situacao_rota = "";
            string finalizado = "null";
            string os = "", posicao = "", operacao = "";
            try
            {
                if (verificar_se_existe_algum_apontamento_em_andamento(_rota))
                {
                    buscar_informacoes_rota(_rota, out os, out posicao, out operacao);
                    situacao_atual = "EM ANDAMENTO - " + operacao;
                    situacao_rota = "EM ANDAMENTO";
                }
                else
                {
                    if (verificar_se_rota_foi_finalizada(_rota))
                    {
                        buscar_informacoes_rota(_rota, out os, out posicao, out operacao);
                        situacao_rota = "FINALIZADO";
                        
                        if (operacao != "Embalar")
                        {
                            //sistema verifica qual é a próxima operação para saber o que colocar no status da peça
                            //mas existe um problema pois quando uma nova operação é colocada posteriormente a rota sai da sequencia
                            //e pode ser que a peça não esteja finalizada e o sistema achar que está
                            int rota_posterior = 0;
                            bool _ultima_rota = false;
                            bool existem_rotas_abertas = false;
                            string [] _rotas_abertas = new string[100];
                            int numero_rota_nao_finalizada;
                            buscar_informacoes_rota_e_os(_rota, os, out _ultima_rota, out _rotas_abertas,
                                out existem_rotas_abertas, out operacao, out numero_rota_nao_finalizada);
                            if(_ultima_rota) //ULTIMA ROTA
                            {
                                if (existem_rotas_abertas)
                                {
                                    situacao_atual = "ROTAS NÃO FINALIZADAS";
                                    for(int l = 0; l < numero_rota_nao_finalizada; l++)
                                    {
                                        situacao_atual = situacao_atual + " " + _rotas_abertas[l] + "/";
                                    }
                                }
                                else
                                {
                                    situacao_atual = "ITEM FINALIZADO";
                                    finalizado = "'1'";
                                }
                            }
                            else
                                situacao_atual = "AGUARDANDO - " + operacao;
                        }
                        else
                        {
                            situacao_atual = "AGUARDANDO - FATURAMENTO";
                        }
                    }
                    else
                    {
                        buscar_informacoes_rota(_rota, out os, out posicao, out operacao);
                        situacao_atual = "PARADA - " + operacao;
                        situacao_rota = "PARADA";
                    }
                }
                buscar_informacoes_rota(_rota, out os, out posicao, out operacao);
                FbCommand update_os = new FbCommand();
                update_os.Connection = fbConnection1;
                fbConnection1.Open();
                update_os.CommandText =
                    "UPDATE OP SET POSICAO_ATUAL_OP = '" + situacao_atual.Replace("'", "") + "', FINALIZADO_OP = " + finalizado + " WHERE COD_OP = '" + 
                    os.Replace("'","") + "'";
                FbDataAdapter datOs = new FbDataAdapter();
                datOs.UpdateCommand = update_os;
                datOs.UpdateCommand.ExecuteNonQuery();
                fbConnection1.Close();

                FbCommand update_rota = new FbCommand();
                update_rota.Connection = fbConnection1;
                fbConnection1.Open();
                update_rota.CommandText =
                    "UPDATE ROTAS_CAMPO SET POSICAO_ATUAL = '" + situacao_rota.Replace("'", "") + "' " + 
                " WHERE COD_ROTA_CAMPO = '" + _rota + "'";
                FbDataAdapter datRota = new FbDataAdapter();
                datRota.UpdateCommand = update_rota;
                datRota.UpdateCommand.ExecuteNonQuery();
                fbConnection1.Close();


            }
            catch(Exception a)
            {
                ok = false;
                fbConnection1.Close();
                form_erro erro = new form_erro();
                erro.erro = a.ToString();
                erro.ShowDialog();
            }
        }

        private void buscar_informacoes_rota_e_os(string _rota, string op, 
            out bool _ultima_rota, out string[] _rotas_abertas,
            out bool existem_rotas_abertas, out string operacao, out int numero_de_rota_nao_finalizada)
        {
            operacao = "";
            _ultima_rota = false;
            existem_rotas_abertas = false;
            numero_de_rota_nao_finalizada = 0;
            string[] clone = new string[100];
            _rotas_abertas = clone;
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT * FROM ROTAS_CAMPO WHERE OP_ROTA = " + op + " ORDER BY COD_ROTA_CAMPO";
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.SelectCommand = select;
                DataSet dsTabela = new DataSet();
                datTabela.Fill(dsTabela);
                fbConnection1.Close();
                
                int numero_linha = 0;
                bool proxima_rota = false;
                foreach (DataRow dr in dsTabela.Tables[0].Rows)
                {
                    if (numero_linha == dsTabela.Tables[0].Rows.Count - 1 && !proxima_rota)
                    { //se for a ultima rota da op
                        if (dr["COD_ROTA_CAMPO"].ToString() == _rota)
                            _ultima_rota = true;
                        
                    }
                    else
                    {
                        if (proxima_rota)
                        {
                            operacao = dr["OPERACAO_CAMPO"].ToString();
                            proxima_rota = false;
                        }
                    }
                    try
                    {
                        DateTime data_fechamento = Convert.ToDateTime(dr["DATA_FECHAMENTO"].ToString());
                    }
                    catch
                    {
                        existem_rotas_abertas = true;
                        _rotas_abertas[numero_de_rota_nao_finalizada] = dr["OPERACAO_CAMPO"].ToString();
                        numero_de_rota_nao_finalizada++;
                    }
                    if (_rota == dr["COD_ROTA_CAMPO"].ToString())
                    {
                        proxima_rota = true;
                    }
                    numero_linha++;
                }
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                form_erro erro = new form_erro();
                erro.erro = a.ToString();
                erro.ShowDialog();
            }
        }

        private bool verificar_se_rota_foi_finalizada(string _rota)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                select.CommandText =
                    "SELECT COD_ROTA_CAMPO FROM ROTAS_CAMPO WHERE COD_ROTA_CAMPO = '" + _rota + 
                    "' AND DATA_FECHAMENTO IS NOT NULL";
                FbDataAdapter datApontamentos = new FbDataAdapter();
                datApontamentos.SelectCommand = select;
                fbConnection1.Open();
                DataSet dsApontamentos = new DataSet();
                datApontamentos.Fill(dsApontamentos);
                fbConnection1.Close();
                if (dsApontamentos.Tables[0].Rows.Count == 1)
                    return true;
                else
                    return false;
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                form_erro erro = new form_erro();
                erro.erro = a.ToString();
                erro.ShowDialog();
                return false;
            }
        }

        private bool verificar_se_existe_algum_apontamento_em_andamento(string _rota)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                select.CommandText =
                    "SELECT COD_AP FROM APONTAMENTOS WHERE ROTA_AP = '" + _rota + "' AND DATA_FIM_AP IS NULL";
                FbDataAdapter datApontamentos = new FbDataAdapter();
                datApontamentos.SelectCommand = select;
                fbConnection1.Open();
                DataSet dsApontamentos = new DataSet();
                datApontamentos.Fill(dsApontamentos);
                fbConnection1.Close();
                if (dsApontamentos.Tables[0].Rows.Count > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                form_erro erro = new form_erro();
                erro.erro = a.ToString();
                erro.ShowDialog();
                return false;
            }
        }

        private void inserir_inicio(string _rota)
        {
            try
            {
                string os = "", posicao = "", operacao = "", desenho = "", ferramenta = "", item = "", tipo_op =  "";
                buscar_informacoes_rota(_rota, out os, out posicao, out operacao);
                buscar_informacoes_op_desenho_ferramenta_item(_rota, out desenho, out ferramenta, out item, out tipo_op);
                //INFORMACOES SERVIÇO EXTERNO
                string retrabalho = "null", se = "null", fornecedor = "null", cnpj_forn = "null", horas_se = "null", valor_se = "null";
                if (servico_externo)
                {
                    se = "'1'";
                    if(_fornecedor_se != "")
                        fornecedor = "'" + _fornecedor_se + "'";
                    if(_cnpj_fornecedor_se != "")
                        cnpj_forn = "'" + _cnpj_fornecedor_se + "'";
                    if(_horas_se != null)
                        horas_se = "'" + _horas_se.ToString().Replace(".","").Replace(",",".") + "'";
                    if(_valor_se != null)
                        valor_se = "'" + _valor_se.ToString().Replace(".", "").Replace(",", ".") + "'";
                }
                
                if (tipo_op == "'01'")
                {
                    retrabalho = "'1'";
                }
               

                if (lote == "")
                    lote = "null";
                else
                    lote = "'" + lote.Replace("'","") + "'";
                FbCommand insert_ap = new FbCommand();
                insert_ap.Connection = fbConnection1;
                fbConnection1.Open();
                insert_ap.CommandText =
                    "INSERT INTO APONTAMENTOS " +
                    "(DATA_INICIO_AP, " +
                    "HORA_INICIO_AP, " +
                    "MAQUINA_AP, " +
                    "OPERADOR_AP, " +
                    "ROTA_AP, " +
                    "CONJUNTAS_AP, " +
                    "OS_AP, " +
                    "POSICAO_AP, " +
                    "OPERACAO_AP, " + 
                    "SERVICO_EXTERNO_AP, " + 
                    "FORN_SERVICO_EXTERNO_AP, " + 
                    "CNPJ_FORN_SERVICO_EXTERNO_AP, " + 
                    "HORAS_SERVICO_EXTERNO_AP, " + 
                    "VALOR_SERVICO_EXTERNO_AP, " + 
                    "DESENHO_AP, FERRAMENTA_AP, ITEM_AP, RETRABALHO_AP, LOTE_AP, TIPO_AP) VALUES " +
                    "('" + DateTime.Now.ToShortDateString().Replace("/", ".") + "', " +
                    "'" + DateTime.Now.ToShortTimeString() + "', " +
                    "'" + maquina + "', " +
                    "'" + operador + "', " +
                    "'" + _rota + "', " +
                    "'" + rotas_conjuntas.ToString() + "', " +
                    os + "," + posicao + "," + operacao + "," + se + "," + fornecedor + "," + cnpj_forn + "," + 
                    horas_se + "," + valor_se + "," + 
                    desenho + "," + ferramenta + "," + item + "," + retrabalho + "," + lote + "," + tipo_op + ")";
                FbDataAdapter datApontamentos = new FbDataAdapter();
                datApontamentos.InsertCommand = insert_ap;
                datApontamentos.InsertCommand.ExecuteNonQuery();
                fbConnection1.Close();
            }
            catch (Exception a)
            {
                ok = false;
                fbConnection1.Close();
                form_erro erro = new form_erro();
                erro.erro = a.ToString();
                erro.ShowDialog();
            }
        }

        private void buscar_informacoes_op_desenho_ferramenta_item(string _rota, out string desenho, 
            out string ferramenta, out string item, out string tipo_op)
        {
            desenho = "null"; ferramenta = "null"; item = "null"; tipo_op = "'00'";
            try
            {
                FbCommand select_rota = new FbCommand();
                select_rota.Connection = fbConnection1;
                fbConnection1.Open();
                select_rota.CommandText =
                    "SELECT OP_ROTA " +
                    "FROM ROTAS_CAMPO WHERE COD_ROTA_CAMPO = '" + _rota + "'";
                FbDataAdapter datRotas = new FbDataAdapter();
                datRotas.SelectCommand = select_rota;
                DataSet dsRotas = new DataSet();
                datRotas.Fill(dsRotas);
                fbConnection1.Close();
                DataRow dr = dsRotas.Tables[0].Rows[0];

                FbCommand select_op = new FbCommand();
                select_op.Connection = fbConnection1;
                fbConnection1.Open();
                select_op.CommandText = 
                    "SELECT DESENHO_OP_ATUAL, FERRAMENTA_OP, COND_PGTO, CODIGO_OP " + 
                    "FROM OP WHERE COD_OP = '" + dr[0].ToString() + "'";
                FbDataAdapter datOp = new FbDataAdapter();
                datOp.SelectCommand = select_op;
                DataSet dsOp = new DataSet();
                datOp.Fill(dsOp);
                fbConnection1.Close();
                DataRow dr_op = dsOp.Tables[0].Rows[0];
                
                try
                {
                    desenho = "'" + dr_op[0].ToString() + "'";
                }
                catch { }
                try
                {
                    if(dr_op[1].ToString() != "")
                        ferramenta = "'" + dr_op[1].ToString() + "'";
                }
                catch { }
                try
                {
                    if(dr_op[2].ToString() != "")
                        item = "'" + dr_op[2].ToString() + "'";
                }
                catch { }
                try
                {
                    if (dr_op[3].ToString() != "")
                        tipo_op = "'" + dr_op[3].ToString() + "'";
                }
                catch { }
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                form_erro erro = new form_erro();
                erro.erro = a.ToString();
                erro.ShowDialog();
            }
        }

        public void buscar_informacoes_rota_com_os_e_nao_cod_op(string _rota, out string os, out string posicao, out string operacao)
        {
            os = "null"; posicao = "null"; operacao = "null";
            try
            {
                FbCommand select_rota = new FbCommand();
                select_rota.Connection = fbConnection1;
                fbConnection1.Open();
                select_rota.CommandText =
                    "SELECT DESENHO_CAMPO, N_PDF_CAMPO, OPERACAO_CAMPO " +
                    "FROM ROTAS_CAMPO WHERE COD_ROTA_CAMPO = '" + _rota + "'";
                FbDataAdapter datRotas = new FbDataAdapter();
                datRotas.SelectCommand = select_rota;
                DataSet dsRotas = new DataSet();
                datRotas.Fill(dsRotas);
                fbConnection1.Close();
                DataRow dr = dsRotas.Tables[0].Rows[0];
                try
                {
                    os = "'" + dr[0].ToString() + "'";
                }
                catch { }
                try
                {
                    if(dr[1].ToString() != "")
                        posicao = "'" + dr[1].ToString() + "'";
                }
                catch { }
                try
                {
                    operacao = "'" + dr[2].ToString() + "'";
                }
                catch { }
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                form_erro erro = new form_erro();
                erro.erro = a.ToString();
                erro.ShowDialog();
            }
        }

        public void buscar_informacoes_rota(string _rota, out string os, out string posicao, out string operacao)
        {
            os = "null"; posicao = "null"; operacao = "null";
            try
            {
                FbCommand select_rota = new FbCommand();
                select_rota.Connection = fbConnection1;
                fbConnection1.Open();
                select_rota.CommandText =
                    "SELECT OP_ROTA, N_PDF_CAMPO, OPERACAO_CAMPO " +
                    "FROM ROTAS_CAMPO WHERE COD_ROTA_CAMPO = '" + _rota + "'";
                FbDataAdapter datRotas = new FbDataAdapter();
                datRotas.SelectCommand = select_rota;
                DataSet dsRotas = new DataSet();
                datRotas.Fill(dsRotas);
                fbConnection1.Close();
                foreach(DataRow dr in dsRotas.Tables[0].Rows)
                {
                    try
                    {
                        os = "'" + dr[0].ToString() + "'";
                    }
                    catch { }
                    try
                    {
                        if(dr[1].ToString() != "")
                            posicao = "'" + dr[1].ToString() + "'";
                        
                    }
                    catch { }
                    try
                    {
                        operacao = "'" + dr[2].ToString() + "'";
                    }
                    catch { }
                }
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                form_erro erro = new form_erro();
                erro.erro = a.ToString();
                erro.ShowDialog();
            }
        }

        private void update_entrada_rota(string _rota)
        {
            try
            {
                FbCommand update_rota = new FbCommand();
                update_rota.Connection = fbConnection1;
                fbConnection1.Open();
                update_rota.CommandText =
                    "UPDATE ROTAS_CAMPO SET HORA_ENTRADA = '" + DateTime.Now.ToShortTimeString() + "', " +
                    "DATA_ENTRADA = '" + DateTime.Now.ToShortDateString().Replace("/", ".") + "' WHERE " +
                    "COD_ROTA_CAMPO = '" + _rota + "'";
                FbDataAdapter datRotas = new FbDataAdapter();
                datRotas.UpdateCommand = update_rota;
                datRotas.UpdateCommand.ExecuteNonQuery();
                fbConnection1.Close();
            }
            catch(Exception a)
            {
                ok = false;
                fbConnection1.Close();
                form_erro erro = new form_erro();
                erro.erro = a.ToString();
                
                    erro.ShowDialog();
            }
        }

        private bool verificar_se_ja_existe_inicio_na_rota(string _rota)
        {
            try
            {
                FbCommand select_apontamentos = new FbCommand();
                select_apontamentos.Connection = fbConnection1;
                fbConnection1.Open();
                select_apontamentos.CommandText =
                    "SELECT COD_AP FROM APONTAMENTOS WHERE ROTA_AP = '" + _rota + "'";
                FbDataAdapter datApontamentos = new FbDataAdapter();
                datApontamentos.SelectCommand = select_apontamentos;
                DataSet dsApontamentos = new DataSet();
                datApontamentos.Fill(dsApontamentos);
                fbConnection1.Close();
                if (dsApontamentos.Tables[0].Rows.Count > 0)
                    return true;
                else
                    return false;
            }
            catch(Exception a)
            {
                fbConnection1.Close();
                form_erro erro = new form_erro();
                erro.erro = a.ToString();
                erro.ShowDialog();
                return false;
            }
        }

        internal void inserir_finalizacao(string tipo)
        {
            for (int i = 0; i < rotas_conjuntas; i++)
            {
                try
                {
                    if (tipo != "parada" && verificar_se_so_existe_um_apontamento_em_andamento(rotas[i, 0]))
                    {
                        //COLOCAR A QUANTIDADE NO APONTAMENTO TAMBÉM !!
                        update_finalizacao_rota(rotas[i, 0]);
                    }
                    inserir_parada(rotas[i, 0], tipo);
                    calcular_horas(rotas[i, 0]);
                    atualizar_situacao_atual(rotas[i, 0]);
                }
                catch
                {

                }
            }
        }

        private bool verificar_se_so_existe_um_apontamento_em_andamento(string _rota)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                select.CommandText =
                    "SELECT COD_AP FROM APONTAMENTOS WHERE ROTA_AP = '" + _rota + "' AND DATA_FIM_AP IS NULL";
                FbDataAdapter datApontamentos = new FbDataAdapter();
                datApontamentos.SelectCommand = select;
                fbConnection1.Open();
                DataSet dsApontamentos = new DataSet();
                datApontamentos.Fill(dsApontamentos);
                fbConnection1.Close();
                if (dsApontamentos.Tables[0].Rows.Count == 1)
                    return true;
                else
                    return false;
            }
            catch(Exception a)
            {
                fbConnection1.Close();
                form_erro erro = new form_erro();
                erro.erro = a.ToString();
                erro.ShowDialog();
                return false;
            }
        }

        public void calcular_horas(string _rota)
        {
            try
            {
                FbCommand select_ap = new FbCommand();
                select_ap.Connection = fbConnection1;
                fbConnection1.Open();
                select_ap.CommandText =
                    "SELECT * FROM APONTAMENTOS WHERE ROTA_AP = '" + _rota + "'" + 
                    " AND DATA_FIM_AP IS NOT NULL ORDER BY COD_AP";
                FbDataAdapter datAp = new FbDataAdapter();
                datAp.SelectCommand = select_ap;
                DataSet dsAp = new DataSet();
                datAp.Fill(dsAp);
                fbConnection1.Close();
                double horas_rota = 0;
                bool primeira = true;
                string os, posicao, operacao;
                buscar_informacoes_rota(_rota, out os, out posicao, out operacao);
                string desenho, ferramenta, item, tipo;
                buscar_informacoes_op_desenho_ferramenta_item(_rota, out desenho, out ferramenta, out item, out tipo);
                os = desenho.Replace("'", ""); // nesse caso a OS é o desenho
                operacao = operacao.Replace("'", "");
                posicao = posicao.Replace("'", "");
                operacao = operacao.Replace("'", "");
                update_zerar_semanas(operacao, _rota);
                string situacao_atual = verificar_situacao_rota(_rota);
                if (situacao_atual == "")
                    situacao_atual = "null";
                else
                    situacao_atual = "'" + situacao_atual + "'";

                foreach (DataRow dr in dsAp.Tables[0].Rows)
                {
                    double horas_parciais = 0;
                    if (dr["SERVICO_EXTERNO_AP"].ToString() != "1")
                    {
                        double horas_conjuntas = 1;
                        try
                        {
                            horas_conjuntas = Convert.ToDouble(dr["CONJUNTAS_AP"].ToString());
                        }
                        catch { }
                        DateTime inicio = Convert.ToDateTime(Convert.ToDateTime(dr["DATA_INICIO_AP"].ToString()).ToShortDateString() + " " +
                            Convert.ToDateTime(dr["HORA_INICIO_AP"].ToString()).ToShortTimeString());
                        DateTime fim = Convert.ToDateTime(Convert.ToDateTime(dr["DATA_FIM_AP"].ToString()).ToShortDateString() + " " +
                            Convert.ToDateTime(dr["HORA_FIM_AP"].ToString()).ToShortTimeString());
                        TimeSpan diferenca = fim - inicio;
                        
                        horas_parciais = diferenca.TotalMinutes / 60 / horas_conjuntas;
                        int n_semana = 0;
                        int ano = inicio.Year;
                        buscar_semana(inicio, out n_semana);

                        if (verificar_se_ja_existe_insercao_semana(n_semana, ano, dr["OPERACAO_AP"].ToString(), 
                            dr["ROTA_AP"].ToString()))
                        {
                            update_somar_na_semana(n_semana, ano, dr["OPERACAO_AP"].ToString(), dr["ROTA_AP"].ToString(),
                                horas_parciais, situacao_atual);
                        }
                        else
                        {
                            insert_semana(n_semana, ano, dr["OPERACAO_AP"].ToString(), dr["ROTA_AP"].ToString(),
                                horas_parciais, os, posicao, situacao_atual);
                        }

                    }
                    else
                    {
                        try
                        {
                            horas_parciais = Convert.ToDouble(dr["HORAS_SERVICO_EXTERNO_AP"].ToString());
                        }
                        catch { }
                    }
                    horas_rota = horas_rota + horas_parciais;
                    FbCommand update_ap = new FbCommand();
                    update_ap.Connection = fbConnection1;
                    fbConnection1.Open();
                    update_ap.CommandText =
                        "UPDATE APONTAMENTOS SET SALDO_HORAS_AP = '" + horas_parciais.ToString("n2").Replace(".","").Replace(",",".") + "'" +
                        " WHERE COD_AP = '" + dr["COD_AP"].ToString() + "'";
                    FbDataAdapter datUpdate_ap = new FbDataAdapter();
                    datUpdate_ap.UpdateCommand = update_ap;
                    datUpdate_ap.UpdateCommand.ExecuteNonQuery();
                    fbConnection1.Close();
                }

                FbCommand update_rota = new FbCommand();
                update_rota.Connection = fbConnection1;
                fbConnection1.Open();
                update_rota.CommandText =
                    "UPDATE ROTAS_CAMPO SET SALDO_HORAS = '" + horas_rota.ToString("n2").Replace(".", "").Replace(",", ".") + "'" +
                    " WHERE COD_ROTA_CAMPO = '" + _rota + "'";
                FbDataAdapter datUpdate_rota = new FbDataAdapter();
                datUpdate_rota.UpdateCommand = update_rota;
                datUpdate_rota.UpdateCommand.ExecuteNonQuery();
                fbConnection1.Close();

                FbCommand update_semana = new FbCommand();
                update_semana.Connection = fbConnection1;
                fbConnection1.Open();
                update_semana.CommandText =
                    "UPDATE HORAS_SEMANA SET SITUACAO_ROTA_SEMANA = " + situacao_atual + "" +
                    " WHERE ROTA_HORAS_SEMANA = '" + _rota + "'";
                FbDataAdapter datUpdate_semana = new FbDataAdapter();
                datUpdate_semana.UpdateCommand = update_semana;
                datUpdate_semana.UpdateCommand.ExecuteNonQuery();
                fbConnection1.Close();



                if (situacao_atual == "'FINALIZADO'")
                {
                    delete_semana_em_branco(_rota);
                }

            }
            catch(Exception a)
            {
                ok = false;
                fbConnection1.Close();
                form_erro erro = new form_erro();
                erro.erro = a.ToString();
                erro.ShowDialog();
            }
        }

        private string verificar_situacao_rota(string _rota)
        {
            string situacao_rota = "";
            string finalizado = "null";
            string os = "", posicao = "", operacao = "";
            try
            {
                if (verificar_se_existe_algum_apontamento_em_andamento(_rota))
                {
                    situacao_rota = "EM ANDAMENTO";
                }
                else
                {
                    if (verificar_se_rota_foi_finalizada(_rota))
                    {
                        situacao_rota = "FINALIZADO";
                    }
                    else
                    {
                        situacao_rota = "PARADA";
                    }
                }
                return situacao_rota;
            }
            catch (Exception a)
            {
                ok = false;
                fbConnection1.Close();
                form_erro erro = new form_erro();
                erro.erro = a.ToString();
                erro.ShowDialog();
                return "";
            }
        }

        private void insert_semana(int n_semana, int ano, string operacao, string rota, double horas_parciais, string os, 
            string posicao, string situacao_atual)
        {
            try
            {
                FbCommand insert = new FbCommand();
                insert.Connection = fbConnection1;
                fbConnection1.Open();
                insert.CommandText =
                    "INSERT INTO HORAS_SEMANA (N_SEMANA, ANO_SEMANA, OPERACAO_SEMANA, ROTA_HORAS_SEMANA, " + 
                    "HORAS_OPERACAO_SEMANA, OS_SEMANA, POSICAO_OS_SEMANA, SITUACAO_ROTA_SEMANA, " + 
                    "HORAS_REAIS_OPERACAO, DATA_LANCAMENTO_SEMANA)" + 
                    "VALUES ('" + n_semana.ToString() + "','" + ano.ToString() + "','" + operacao + "','" + rota + "','0','" + 
                    os + "','" + posicao + "'," + situacao_atual + ",'" + 
                    horas_parciais.ToString().Replace(".","").Replace(",",".") + "','" + 
                    DateTime.Now.ToShortDateString().Replace("/",".") + "')";
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.InsertCommand = insert;
                datTabela.InsertCommand.ExecuteNonQuery();
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

        private void update_somar_na_semana(int n_semana, int ano, string operacao, string rota, double horas_parciais,
            string situacao_atual)
        {
            try
            {
                FbCommand update = new FbCommand();
                update.Connection = fbConnection1;
                fbConnection1.Open();
                update.CommandText =
                    "UPDATE HORAS_SEMANA SET HORAS_REAIS_OPERACAO = HORAS_REAIS_OPERACAO + " + 
                    horas_parciais.ToString().Replace(".","").Replace(",",".") + ", SITUACAO_ROTA_SEMANA = " + situacao_atual + 
                    " WHERE ROTA_HORAS_SEMANA = '" + rota + "' AND OPERACAO_SEMANA = '" + operacao + 
                    "' AND N_SEMANA = '" + n_semana.ToString() + "' AND ANO_SEMANA = '" + ano.ToString() + "'";
                FbDataAdapter datUpdate = new FbDataAdapter();
                datUpdate.UpdateCommand = update;
                datUpdate.UpdateCommand.ExecuteNonQuery();
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

        private bool verificar_se_ja_existe_insercao_semana(int n_semana, int ano, string operacao, string rota)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT * FROM HORAS_SEMANA WHERE N_SEMANA = '" + n_semana.ToString() + 
                    "' AND ANO_SEMANA = '" + ano.ToString() + "' " + 
                    " AND OPERACAO_SEMANA = '" + operacao + "' AND ROTA_HORAS_SEMANA = '" + rota + "'";
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.SelectCommand = select;
                DataSet dsTabela = new DataSet();
                datTabela.Fill(dsTabela);
                fbConnection1.Close();
                foreach (DataRow dr in dsTabela.Tables[0].Rows)
                {
                    return true;
                }
                return false;
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                form_erro erro = new form_erro();
                erro.erro = a.ToString();
                erro.ShowDialog();
                return false;
            }
        }

        public void buscar_semanas(DateTime primeiro_dia_os, DateTime ultimo_dia_os,
            out DateTime[] primeiro_dia_semana, out DateTime[] ultimo_dia_semana,
            out int[] semana_numero, out int n_semanas)
        {
            DateTime domingo_corrente = buscar_domingo(primeiro_dia_os);
            DateTime sabado_corrente = buscar_domingo(primeiro_dia_os).AddDays(6);
            DateTime[] inicializar = new DateTime[200];
            DateTime[] inicializar2 = new DateTime[200];
            int[] _inicializar = new int[200];
            primeiro_dia_semana = inicializar; ultimo_dia_semana = inicializar2; semana_numero = _inicializar;
            n_semanas = 0;
            for (int j = 0; j < 200; j++)
            {
                primeiro_dia_semana[j] = Convert.ToDateTime("01/01/2001");
                ultimo_dia_semana[j] = Convert.ToDateTime("01/01/2001");
                semana_numero[j] = 0;
            }
            for (int i = 0; domingo_corrente < ultimo_dia_os; i++)
            {
                //buscando primeira semana ano
                try
                {
                    FbCommand select = new FbCommand();
                    select.Connection = fbConnection1;
                    fbConnection1.Open();
                    select.CommandText =
                        "SELECT * FROM DIA_SEMANA_ANO WHERE ANO_DSA = '" + domingo_corrente.Year.ToString() + "'";
                    FbDataAdapter datTabela = new FbDataAdapter();
                    datTabela.SelectCommand = select;
                    DataSet dsTabela = new DataSet();
                    datTabela.Fill(dsTabela);
                    fbConnection1.Close();
                    foreach (DataRow dr in dsTabela.Tables[0].Rows)
                    {
                        DateTime primeiro_dia_ano = Convert.ToDateTime(dr["PRIMEIRO_DIA_ANO_DSA"].ToString());
                        int primeira_semana_ano = Convert.ToInt32(dr["PRIMEIRA_SEMANA_ANO_DSA"].ToString());
                        primeiro_dia_semana[i] = domingo_corrente;
                        ultimo_dia_semana[i] = sabado_corrente;
                        semana_numero[i] = buscar_semana_numero(primeiro_dia_ano, domingo_corrente, primeira_semana_ano);
                    }
                }
                catch (Exception a)
                {
                    fbConnection1.Close();
                    form_erro erro = new form_erro();
                    erro.erro = a.ToString();
                    erro.ShowDialog();
                }
                n_semanas = i + 1;
                domingo_corrente = domingo_corrente.AddDays(7);
                sabado_corrente = sabado_corrente.AddDays(7);
            }

        }

        private void update_zerar_semanas(object operacao, object rota)
        {
            try
            {
                FbCommand update = new FbCommand();
                update.Connection = fbConnection1;
                fbConnection1.Open();
                update.CommandText =
                    "UPDATE HORAS_SEMANA SET HORAS_REAIS_OPERACAO = '0' WHERE " +  
                    " ROTA_HORAS_SEMANA = '" + rota +  "' AND OPERACAO_SEMANA = '" + operacao + "'";
                FbDataAdapter datUpdate = new FbDataAdapter();
                datUpdate.UpdateCommand = update;
                datUpdate.UpdateCommand.ExecuteNonQuery();
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

        private void delete_semana_em_branco(string _rota)
        {
            try
            {
                FbCommand update = new FbCommand();
                update.Connection = fbConnection1;
                fbConnection1.Open();
                update.CommandText =
                    "UPDATE HORAS_SEMANA SET DATA_EXCLUSAO_SEMANA = '" + DateTime.Now.ToShortDateString().Replace("/", ".") +
                    "', EXCLUIDO_ONDE_SEMANA = 'TERMINAL' WHERE ROTA_HORAS_SEMANA = '" + _rota +
                    "' AND (HORAS_REAIS_OPERACAO IS NULL OR HORAS_REAIS_OPERACAO = 0) AND DATA_EXCLUSAO_SEMANA IS NULL"; 
                FbDataAdapter datUpdate = new FbDataAdapter();
                datUpdate.UpdateCommand = update;
                datUpdate.UpdateCommand.ExecuteNonQuery();
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

        public void buscar_semana(DateTime primeiro_dia_os, out int semana_numero)
        {
            DateTime domingo_corrente = buscar_domingo(primeiro_dia_os);
            DateTime sabado_corrente = buscar_domingo(primeiro_dia_os).AddDays(6);
            semana_numero = 0;
                //buscando primeira semana ano
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT * FROM DIA_SEMANA_ANO WHERE ANO_DSA = '" + domingo_corrente.Year.ToString() + "'";
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.SelectCommand = select;
                DataSet dsTabela = new DataSet();
                datTabela.Fill(dsTabela);
                fbConnection1.Close();
                foreach (DataRow dr in dsTabela.Tables[0].Rows)
                {
                    DateTime primeiro_dia_ano = Convert.ToDateTime(dr["PRIMEIRO_DIA_ANO_DSA"].ToString());
                    int primeira_semana_ano = Convert.ToInt32(dr["PRIMEIRA_SEMANA_ANO_DSA"].ToString());
                    semana_numero = buscar_semana_numero(primeiro_dia_ano, domingo_corrente, primeira_semana_ano);
                }
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                form_erro erro = new form_erro();
                erro.erro = a.ToString();
                erro.ShowDialog();
            }
        }

        private int buscar_semana_numero(DateTime primeiro_dia_ano, DateTime domingo_corrente, int primeira_semana_ano)
        {
            int diferenca_em_semanas = 0;
            try
            {
                TimeSpan diferenca = domingo_corrente - primeiro_dia_ano;
                diferenca_em_semanas = diferenca.Days / 7;
                return diferenca_em_semanas + primeira_semana_ano;
            }
            catch
            {
                return 0;
            }

        }

        private DateTime buscar_domingo(DateTime primeiro_dia_os)
        {
            DateTime domingo = primeiro_dia_os;
            while (domingo.DayOfWeek != DayOfWeek.Sunday)
            {
                domingo = domingo.AddDays(-1);
            }
            return domingo;
        }


        private void inserir_parada(string _rota, string tipo)
        {
            try
            {
                int numero_dias_depois = 0; DateTime inicio = new DateTime();
                if (verificar_se_agora_maior_data_entrada(_rota, out numero_dias_depois, out inicio, DateTime.Now))
                {
                    for (int i = 1; i <= numero_dias_depois; i++)
                    {
                        inserir_parada_do_dia(inicio, _rota);
                        inserir_reinicio_do_proximo_dia(inicio.AddDays(1), _rota);
                        inicio = inicio.AddDays(1);
                    }
                }
                string os = "", posicao = "", operacao = "";
                FbCommand update_ap = new FbCommand();
                update_ap.Connection = fbConnection1;
                fbConnection1.Open();
                string horas_se = "null";
                string valor_se = "null";
                string motivo_parada = "null";
                if (tipo == "parada")
                {
                    form_motivo_parada motivo = new form_motivo_parada();
                    try
                    {
                        motivo.ShowDialog();
                    }
                    finally
                    {
                        motivo_parada = "'" + motivo._tipo_parada + "'";
                    }
                }
                if (servico_externo)
                {
                    try
                    {
                        horas_se = "'" + _horas_se.ToString().Replace(".", "").Replace(",", ".") + "'";
                    }
                    catch { }
                    try
                    {
                        valor_se = "'" + _valor_se.ToString().Replace(".", "").Replace(",", ".") + "'";
                    }
                    catch { }
                }
                update_ap.CommandText =
                    "UPDATE APONTAMENTOS SET " +
                    "DATA_FIM_AP = '" + DateTime.Now.ToShortDateString().Replace("/", ".") + "', " +
                    "HORA_FIM_AP = '" + DateTime.Now.ToShortTimeString() + "', " +
                    "MOTIVO_PARADA_AP = " + motivo_parada + ", " +
                    "HORAS_SERVICO_EXTERNO_AP = " + horas_se + ", " + 
                    "VALOR_SERVICO_EXTERNO_AP = " + valor_se + "" +
                    " WHERE MAQUINA_AP = '" + maquina + "' AND " +
                    "OPERADOR_AP = '" + operador + "' AND " +
                    "ROTA_AP = '" + _rota + "' AND " +
                    "CONJUNTAS_AP = '" + rotas_conjuntas.ToString() + "' AND " +
                    "DATA_FIM_AP IS NULL";
                FbDataAdapter datApontamentos = new FbDataAdapter();
                datApontamentos.UpdateCommand = update_ap;
                datApontamentos.UpdateCommand.ExecuteNonQuery();
                fbConnection1.Close();

            }
            catch (Exception a)
            {
                ok = false;
                fbConnection1.Close();
                form_erro erro = new form_erro();
                erro.erro = a.ToString();
                erro.ShowDialog();
            }
        }

        private void inserir_reinicio_manual(DateTime reinicio, string _rota)
        {
            try
            {
                string os = "", posicao = "", operacao = "", desenho = "", ferramenta = "", item = "", tipo_op = "";
                buscar_informacoes_rota(_rota, out os, out posicao, out operacao);
                buscar_informacoes_op_desenho_ferramenta_item(_rota, out desenho, out ferramenta, out item, out tipo_op);
                //INFORMACOES SERVIÇO EXTERNO
                string se = "null", fornecedor = "null", cnpj_forn = "null", horas_se = "null", valor_se = "null", retrabalho = "null";
                if (servico_externo)
                {
                    se = "'1'";
                    if (_fornecedor_se != "")
                        fornecedor = "'" + _fornecedor_se + "'";
                    if (_cnpj_fornecedor_se != "")
                        cnpj_forn = "'" + _cnpj_fornecedor_se + "'";
                    if (_horas_se != null)
                        horas_se = "'" + _horas_se.ToString().Replace(".", "").Replace(",", ".") + "'";
                    if (_valor_se != null)
                        valor_se = "'" + _valor_se.ToString().Replace(".", "").Replace(",", ".") + "'";
                }
                if (tipo_op == "01")
                {
                    retrabalho = "'1'";
                }
                FbCommand insert_ap = new FbCommand();
                insert_ap.Connection = fbConnection1;
                fbConnection1.Open();
                insert_ap.CommandText =
                    "INSERT INTO APONTAMENTOS " +
                    "(DATA_INICIO_AP, " +
                    "HORA_INICIO_AP, " +
                    "MAQUINA_AP, " +
                    "OPERADOR_AP, " +
                    "ROTA_AP, " +
                    "CONJUNTAS_AP, " +
                    "OS_AP, " +
                    "POSICAO_AP, " +
                    "OPERACAO_AP, " +
                    "SERVICO_EXTERNO_AP, " +
                    "FORN_SERVICO_EXTERNO_AP, " +
                    "CNPJ_FORN_SERVICO_EXTERNO_AP, " +
                    "HORAS_SERVICO_EXTERNO_AP, " +
                    "VALOR_SERVICO_EXTERNO_AP, " +
                    "DESENHO_AP, FERRAMENTA_AP, ITEM_AP, RETRABALHO_AP) VALUES " +
                    "('" + reinicio.ToShortDateString().Replace("/", ".") + "', " +
                    "'" + reinicio.ToShortTimeString() + "', " +
                    "'" + maquina + "', " +
                    "'" + operador + "', " +
                    "'" + _rota + "', " +
                    "'" + rotas_conjuntas.ToString() + "', " +
                    os + "," + posicao + "," + operacao + "," + se + "," + fornecedor + "," + cnpj_forn + "," +
                    horas_se + "," + valor_se + "," +
                    desenho + "," + ferramenta + "," + item + "," + retrabalho + ")";
                FbDataAdapter datApontamentos = new FbDataAdapter();
                datApontamentos.InsertCommand = insert_ap;
                datApontamentos.InsertCommand.ExecuteNonQuery();
                fbConnection1.Close();
            }
            catch (Exception a)
            {
                ok = false;
                fbConnection1.Close();
                form_erro erro = new form_erro();
                erro.erro = a.ToString();
                erro.ShowDialog();
            }
        }

        private void inserir_parada_manual(DateTime parada, string _rota)
        {
            try
            {
                string os = "", posicao = "", operacao = "";
                FbCommand update_ap = new FbCommand();
                update_ap.Connection = fbConnection1;
                fbConnection1.Open();
                string horas_se = "null";
                string valor_se = "null";
                string motivo_parada = "null";
                motivo_parada = "'APONTAMENTO MANUAL'";
                update_ap.CommandText =
                    "UPDATE APONTAMENTOS SET " +
                    "DATA_FIM_AP = '" + parada.ToShortDateString().Replace("/", ".") + "', " +
                    "HORA_FIM_AP = '" + parada.ToShortTimeString() + "', " +
                    "MOTIVO_PARADA_AP = " + motivo_parada + ", " +
                    "HORAS_SERVICO_EXTERNO_AP = " + horas_se + ", " +
                    "VALOR_SERVICO_EXTERNO_AP = " + valor_se + "" +
                    " WHERE MAQUINA_AP = '" + maquina + "' AND " +
                    "OPERADOR_AP = '" + operador + "' AND " +
                    "ROTA_AP = '" + _rota + "' AND " +
                    "CONJUNTAS_AP = '" + rotas_conjuntas.ToString() + "' AND " +
                    "DATA_FIM_AP IS NULL";
                FbDataAdapter datApontamentos = new FbDataAdapter();
                datApontamentos.UpdateCommand = update_ap;
                datApontamentos.UpdateCommand.ExecuteNonQuery();
                fbConnection1.Close();
            }
            catch (Exception a)
            {
                ok = false;
                fbConnection1.Close();
                form_erro erro = new form_erro();
                erro.erro = a.ToString();
                erro.ShowDialog();
            }
        }


        private void inserir_reinicio_do_proximo_dia(DateTime reinicio, string _rota)
        {
            try
            {
                string os = "", posicao = "", operacao = "", desenho = "", ferramenta = "", item = "", tipo_op = "";
                buscar_informacoes_rota(_rota, out os, out posicao, out operacao);
                buscar_informacoes_op_desenho_ferramenta_item(_rota, out desenho, out ferramenta, out item, out tipo_op);
                //INFORMACOES SERVIÇO EXTERNO
                string se = "null", fornecedor = "null", cnpj_forn = "null", horas_se = "null", valor_se = "null", retrabalho = "null";
                if (servico_externo)
                {
                    se = "'1'";
                    if (_fornecedor_se != "")
                        fornecedor = "'" + _fornecedor_se + "'";
                    if (_cnpj_fornecedor_se != "")
                        cnpj_forn = "'" + _cnpj_fornecedor_se + "'";
                    if (_horas_se != null)
                        horas_se = "'" + _horas_se.ToString().Replace(".", "").Replace(",", ".") + "'";
                    if (_valor_se != null)
                        valor_se = "'" + _valor_se.ToString().Replace(".", "").Replace(",", ".") + "'";
                }
                if (tipo_op == "01")
                {
                    retrabalho = "'1'";
                }
                FbCommand insert_ap = new FbCommand();
                insert_ap.Connection = fbConnection1;
                fbConnection1.Open();
                insert_ap.CommandText =
                    "INSERT INTO APONTAMENTOS " +
                    "(DATA_INICIO_AP, " +
                    "HORA_INICIO_AP, " +
                    "MAQUINA_AP, " +
                    "OPERADOR_AP, " +
                    "ROTA_AP, " +
                    "CONJUNTAS_AP, " +
                    "OS_AP, " +
                    "POSICAO_AP, " +
                    "OPERACAO_AP, " +
                    "SERVICO_EXTERNO_AP, " +
                    "FORN_SERVICO_EXTERNO_AP, " +
                    "CNPJ_FORN_SERVICO_EXTERNO_AP, " +
                    "HORAS_SERVICO_EXTERNO_AP, " +
                    "VALOR_SERVICO_EXTERNO_AP, " +
                    "DESENHO_AP, FERRAMENTA_AP, ITEM_AP, RETRABALHO_AP) VALUES " +
                    "('" + reinicio.ToShortDateString().Replace("/", ".") + "', " +
                    "'00:00:00', " +
                    "'" + maquina + "', " +
                    "'" + operador + "', " +
                    "'" + _rota + "', " +
                    "'" + rotas_conjuntas.ToString() + "', " +
                    os + "," + posicao + "," + operacao + "," + se + "," + fornecedor + "," + cnpj_forn + "," +
                    horas_se + "," + valor_se + "," +
                    desenho + "," + ferramenta + "," + item + "," + retrabalho + ")";
                FbDataAdapter datApontamentos = new FbDataAdapter();
                datApontamentos.InsertCommand = insert_ap;
                datApontamentos.InsertCommand.ExecuteNonQuery();
                fbConnection1.Close();
            }
            catch (Exception a)
            {
                ok = false;
                fbConnection1.Close();
                form_erro erro = new form_erro();
                erro.erro = a.ToString();
                erro.ShowDialog();
            }
        }

        private void inserir_parada_do_dia(DateTime inicio, string _rota)
        {
            try
            {
                string os = "", posicao = "", operacao = "";
                FbCommand update_ap = new FbCommand();
                update_ap.Connection = fbConnection1;
                fbConnection1.Open();
                string horas_se = "null";
                string valor_se = "null";
                string motivo_parada = "null";
                motivo_parada = "'FIM DO DIA'";
                update_ap.CommandText =
                    "UPDATE APONTAMENTOS SET " +
                    "DATA_FIM_AP = '" + Convert.ToDateTime(inicio.ToShortDateString()).ToShortDateString().Replace("/", ".") + "', " +
                    "HORA_FIM_AP = '23:59:59', " +
                    "MOTIVO_PARADA_AP = " + motivo_parada + ", " +
                    "HORAS_SERVICO_EXTERNO_AP = " + horas_se + ", " +
                    "VALOR_SERVICO_EXTERNO_AP = " + valor_se + "" +
                    " WHERE MAQUINA_AP = '" + maquina + "' AND " +
                    "OPERADOR_AP = '" + operador + "' AND " +
                    "ROTA_AP = '" + _rota + "' AND " +
                    "CONJUNTAS_AP = '" + rotas_conjuntas.ToString() + "' AND " +
                    "DATA_FIM_AP IS NULL";
                FbDataAdapter datApontamentos = new FbDataAdapter();
                datApontamentos.UpdateCommand = update_ap;
                datApontamentos.UpdateCommand.ExecuteNonQuery();
                fbConnection1.Close();
            }
            catch (Exception a)
            {
                ok = false;
                fbConnection1.Close();
                form_erro erro = new form_erro();
                erro.erro = a.ToString();
                erro.ShowDialog();
            }
        }

        private bool verificar_se_agora_maior_data_entrada(string _rota, out int numero_dias_depois, out DateTime data_inicio, DateTime data_hora_parada)
        {
            numero_dias_depois = 0;
            data_inicio = DateTime.Now;
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT DATA_INICIO_AP FROM APONTAMENTOS WHERE MAQUINA_AP = '" + maquina + "' AND " +
                    "OPERADOR_AP = '" + operador + "' AND " +
                    "ROTA_AP = '" + _rota + "' AND " +
                    "CONJUNTAS_AP = '" + rotas_conjuntas.ToString() + "' AND " +
                    "DATA_FIM_AP IS NULL";
                FbDataAdapter datAp = new FbDataAdapter();
                datAp.SelectCommand = select;
                DataSet dsAp = new DataSet();
                datAp.Fill(dsAp);
                fbConnection1.Close();
                foreach (DataRow dr in dsAp.Tables[0].Rows)
                {
                    data_inicio = Convert.ToDateTime(dr[0].ToString());
                    if (Convert.ToDateTime(data_hora_parada.ToShortDateString()) >
                        data_inicio)
                    {
                        TimeSpan diferenca = Convert.ToDateTime(data_hora_parada.ToShortDateString()) -
                            Convert.ToDateTime(data_inicio.ToShortDateString());
                        //double numero_dias
                        numero_dias_depois = diferenca.Days;
                        return true;
                    }
                    else
                        return false;
                }
                    return false;
            }
            catch(Exception a)
            {
                
                fbConnection1.Close();
                form_erro erro = new form_erro();
                erro.erro = a.ToString();
                erro.ShowDialog();
                return false;
            }
        }

        private void update_finalizacao_rota(string _rota)
        {
            try
            {
                double aprovadas = 0, rejeitadas = 0;
                double qtde = buscar_qtde(_rota, out aprovadas, out rejeitadas);
                string op = "", posicao = "", operacao = "";
                buscar_informacoes_rota(_rota, out op, out posicao, out operacao);
                if (verificar_se_qtde_aprovada_maior_igual_pedido(op, aprovadas))
                {
                    inserir_qtde_ap(_rota, qtde.ToString());
                    inserir_ocorrencia(_rota, "2");
                    form_erro erro = new form_erro();
                    erro.erro = "A quantidade aprovada é menor do que a quantidade que é necessária fabricar. \r\n" +
                        "AVISE IMEDIATAMENTE SEU SUPERVISOR PARA QUE ELE POSSA TOMAR AS PROVIDÊNCIAS CABÍVEIS";
                    erro.ShowDialog();

                }
                else
                {
                    inserir_qtde_ap(_rota, qtde.ToString());
                    //UPDATE NA ROTA
                    FbCommand update_rota = new FbCommand();
                    update_rota.Connection = fbConnection1;
                    fbConnection1.Open();
                    update_rota.CommandText =
                        "UPDATE ROTAS_CAMPO SET HORA_FECHAMENTO = '" + DateTime.Now.ToShortTimeString() + "', " +
                        "DATA_FECHAMENTO = '" + DateTime.Now.ToShortDateString().Replace("/", ".") + "' " +
                        //"PECAS_APROVADAS = '" + aprovadas.ToString() + "', PECAS_REJEITADAS = '" + rejeitadas.ToString() + "' " +
                        "WHERE COD_ROTA_CAMPO = '" + _rota + "'";
                    FbDataAdapter datRotas = new FbDataAdapter();
                    datRotas.UpdateCommand = update_rota;
                    datRotas.UpdateCommand.ExecuteNonQuery();
                    fbConnection1.Close();
                    /*
                    //UPDATE PREVISAO DO RESTANTE DAS PECAS
                    FbCommand update_rotas = new FbCommand();
                    update_rotas.Connection = fbConnection1;
                    fbConnection1.Open();
                    update_rotas.CommandText =
                        "UPDATE ROTAS_CAMPO SET PREVISAO_PRODUCAO = '" + aprovadas.ToString() + "'" +
                        " WHERE OP_ROTA = " + op + " AND DATA_FECHAMENTO IS NULL";
                    FbDataAdapter datRotas_restantes = new FbDataAdapter();
                    datRotas_restantes.UpdateCommand = update_rotas;
                    datRotas_restantes.UpdateCommand.ExecuteNonQuery();
                    fbConnection1.Close();
                     * */
                }
            }
            catch (Exception a)
            {
                ok = false;
                fbConnection1.Close();
                form_erro erro = new form_erro();
                erro.erro = a.ToString();
                erro.ShowDialog();
            }
        }

        private void inserir_ocorrencia(string _rota, string tipo_ocorrencia)
        {
            try
            {
                string os = "null", posicao = "null", operacao = "null";
                buscar_informacoes_rota_com_os_e_nao_cod_op(_rota, out os, out posicao, out operacao);

                string descricao = "'OS: " + os.Replace("'", "") + " Pos: " + posicao.Replace("'", "") + " Operação: " + operacao.Replace("'", "") + " Operador = " + operador + "' "; 

                FbCommand insert = new FbCommand();
                insert.Connection = fbConnection1;
                insert.CommandText =
                    "INSERT INTO AGENDA_OS (OS_AGENDA_OS, POSICAO_AGENDA_OS, " +
                    "DESCRICAO_AGENDA_OS, DATA_AGENDA_OS, TIPO_OCORRENCIA_AGENDA_OS, HORA_AGENDA_OS) " +
                    " VALUES (" + os + "," + posicao + "," + descricao + ",'" +
                    DateTime.Now.ToShortDateString().Replace("/", ".") + "','QTDE FINALIZADA INFERIOR A QTDE A FABRICAR','" + 
                    DateTime.Now.ToShortTimeString() + "')";
                fbConnection1.Open();
                FbDataAdapter datAgenda = new FbDataAdapter();
                datAgenda.InsertCommand = insert;
                datAgenda.InsertCommand.ExecuteNonQuery();
                fbConnection1.Close();
            }
            catch (Exception a)
            {
                ok = false;
                fbConnection1.Close();
                form_erro erro = new form_erro();
                erro.erro = a.ToString();
                erro.ShowDialog();
            }
        }

        private string buscar_tipo_ocorrencia(string tipo_ocorrencia)
        {
            string retorno = "null";
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT DESCRICAO_OCORRENCIA FROM TIPOS_OCORRENCIAS " +
                    " WHERE COD_TIPO_OCORRENCIA = '" + tipo_ocorrencia + "'";
                FbDataAdapter datTipos_ocorrencias = new FbDataAdapter();
                datTipos_ocorrencias.SelectCommand = select;
                DataSet dsTipos_ocorrencias = new DataSet();
                datTipos_ocorrencias.Fill(dsTipos_ocorrencias);
                fbConnection1.Close();
                foreach (DataRow dr in dsTipos_ocorrencias.Tables[0].Rows)
                {
                    retorno = "'" + dr[0].ToString() + "'";
                }
                return retorno;

            }
            catch (Exception a)
            {
                ok = false;
                fbConnection1.Close();
                form_erro erro = new form_erro();
                erro.erro = a.ToString();
                erro.ShowDialog();
                return retorno;
            }
        }

        private void inserir_qtde_ap(string _rota, string _qtde)
        {
            try
            {
                FbCommand update_ap = new FbCommand();
                update_ap.Connection = fbConnection1;
                fbConnection1.Open();
                update_ap.CommandText =
                    "UPDATE APONTAMENTOS SET " +
                    "QTDE_AP = '" + _qtde.Replace(".","").Replace(",",".") + "' " +
                    " WHERE MAQUINA_AP = '" + maquina + "' AND " +
                    "OPERADOR_AP = '" + operador + "' AND " +
                    "ROTA_AP = '" + _rota + "' AND " +
                    "CONJUNTAS_AP = '" + rotas_conjuntas.ToString() + "' AND " +
                    "DATA_FIM_AP IS NULL";
                FbDataAdapter datApontamentos = new FbDataAdapter();
                datApontamentos.UpdateCommand = update_ap;
                datApontamentos.UpdateCommand.ExecuteNonQuery();
                fbConnection1.Close();
            }
            catch (Exception a)
            {
                ok = false;
                fbConnection1.Close();
                form_erro erro = new form_erro();
                erro.erro = a.ToString();
                erro.ShowDialog();
            }
        }

        private bool verificar_se_qtde_aprovada_maior_igual_pedido(string op, double aprovadas)
        {
            DataRow dr = null;
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                select.CommandText =
                    "SELECT QDE_FAB FROM OP WHERE COD_OP = " + op + "";
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataSet dsSelect = new DataSet();
                datSelect.Fill(dsSelect);
                double qtde = 0;
                fbConnection1.Close();
                dr = dsSelect.Tables[0].Rows[0];

                qtde = Convert.ToDouble(dr[0].ToString());
                
                
                if (qtde > aprovadas)
                    return true;
                else
                    return false;
            }
            catch(Exception a)
            {
                if (dr[0].ToString() == "")
                {
                    return false;
                }
                else
                {
                    fbConnection1.Close();
                    form_erro erro = new form_erro();
                    erro.erro = a.ToString();
                    erro.ShowDialog();
                    return false;
                }
            }
        }

        private double buscar_qtde(string rota, out double aprovadas, out double rejeitadas)
        {
            double qtde = 0; aprovadas = 0; rejeitadas = 0;
            string op = "", posicao = "", operacao = "";
            buscar_informacoes_rota(rota, out op, out posicao, out operacao);
            try
            {
                if (verificar_se_operacao_conta(operacao))
                {
                    form_qtde_fabricada qtde_fab = new form_qtde_fabricada();
                    try
                    {
                        qtde_fab.rota = rota;
                        qtde_fab.ShowDialog();

                    }
                    finally
                    {
                        qtde = qtde_fab.qtde;
                        aprovadas = qtde;
                        rejeitadas = buscar_qtde_rota(rota) - aprovadas;
                    }

                }
                else //ACERTAR QUANDO FOR COLOCADA AS PECAS MORTAS (FAZER O FORM, BUSCAR QTDE_PREVISTA, ETC)
                {
                    form_qtde_morta qtde_morta = new form_qtde_morta();
                    try
                    {
                        qtde_morta.rota = rota;
                        qtde_morta.ShowDialog();

                    }
                    finally
                    {
                        qtde = buscar_qtde_rota(rota) - qtde_morta.qtde;
                        aprovadas = qtde;
                        rejeitadas = qtde_morta.qtde;
                    }
                }
                return qtde;
            }
            catch
            {
                return qtde;
            }
        }

        private double buscar_qtde_rota(string rota)
        {
            try
            {
                FbCommand select_rota = new FbCommand();
                select_rota.Connection = fbConnection1;
                fbConnection1.Open();
                select_rota.CommandText =
                    "SELECT PREVISAO_PRODUCAO " +
                    "FROM ROTAS_CAMPO WHERE COD_ROTA_CAMPO = '" + rota + "'";
                FbDataAdapter datRotas = new FbDataAdapter();
                datRotas.SelectCommand = select_rota;
                DataSet dsRotas = new DataSet();
                datRotas.Fill(dsRotas);
                fbConnection1.Close();
                foreach (DataRow dr in dsRotas.Tables[0].Rows)
                {
                    try
                    {
                        if (dr[0].ToString() != "" && dr[0].ToString() != null)
                            return Convert.ToInt32(dr[0].ToString());
                        else
                            return 0;
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
                form_erro erro = new form_erro();
                erro.erro = a.ToString();
                erro.ShowDialog();
                return 0;
            }
        }

        private bool verificar_se_operacao_conta(string operacao)
        {
            
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT SETOR_TIPO FROM TIPOS_OPERACOES WHERE TIPO = " + operacao + "";
                FbDataAdapter datOperacao = new FbDataAdapter();
                datOperacao.SelectCommand = select;
                DataSet dsOperacao = new DataSet();
                datOperacao.Fill(dsOperacao);
                DataRow dr = dsOperacao.Tables[0].Rows[0];
                fbConnection1.Close();
                if (dr[0].ToString() != "")
                {
                    FbCommand select_setor = new FbCommand();
                    select_setor.Connection = fbConnection1;
                    select_setor.CommandText =
                        "SELECT CONTAR_SETOR FROM SETORES WHERE DESCRICAO_SETOR = '" + dr[0].ToString() + "'";
                    fbConnection1.Open();
                    FbDataAdapter datSetor = new FbDataAdapter();
                    datSetor.SelectCommand = select_setor;
                    DataSet dsSetor = new DataSet();
                    datSetor.Fill(dsSetor);
                    fbConnection1.Close();
                    DataRow dr_setor = dsSetor.Tables[0].Rows[0];
                    if (dr_setor[0].ToString() == "1")
                        return true;
                    else
                        return false;

                }
                else
                    return false;

            }
            catch(Exception a)
            {
                fbConnection1.Close();
                form_erro erro = new form_erro();
                erro.erro = a.ToString();
                erro.ShowDialog();
                return false;
            }
        }

        internal void inserir_paradas_conjuntas(int numero_ap)
        {
            for (int i = 0; i < numero_ap; i++)
            {
                try
                {
                    FbCommand update_ap = new FbCommand();
                    update_ap.Connection = fbConnection1;
                    fbConnection1.Open();
                    update_ap.CommandText =
                        "UPDATE APONTAMENTOS SET " +
                        "DATA_FIM_AP = '" + DateTime.Now.ToShortDateString().Replace("/", ".") + "', " +
                        "HORA_FIM_AP = '" + DateTime.Now.ToShortTimeString() + "' " +
                        " WHERE COD_AP = '" + apontamentos_a_parar[i] + "'";
                    FbDataAdapter datApontamentos = new FbDataAdapter();
                    datApontamentos.UpdateCommand = update_ap;
                    datApontamentos.UpdateCommand.ExecuteNonQuery();
                    fbConnection1.Close();
                    string rota_parada = buscar_rota(apontamentos_a_parar[i]);
                    calcular_horas(rota_parada);
                    atualizar_situacao_atual(rota_parada);
                }
                catch (Exception a)
                {
                    fbConnection1.Close();
                    form_erro erro = new form_erro();
                    erro.erro = a.ToString();
                    erro.ShowDialog();
                }
            }
            
        }

        private string buscar_rota(string _ap)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT ROTA_AP FROM APONTAMENTOS WHERE COD_AP = '" + _ap + "'";
                FbDataAdapter datAp = new FbDataAdapter();
                datAp.SelectCommand = select;
                DataSet dsAp = new DataSet();
                datAp.Fill(dsAp);
                fbConnection1.Close();
                DataRow dr = dsAp.Tables[0].Rows[0];
                return dr[0].ToString();
                
            }
            catch(Exception a)
            {
                fbConnection1.Close();
                form_erro erro = new form_erro();
                erro.erro = a.ToString();
                erro.ShowDialog();
                return "erro";
            }
        }
    }
}
