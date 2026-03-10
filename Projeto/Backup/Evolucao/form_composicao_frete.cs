using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Data.OleDb;

namespace Evolucao
{
    public partial class form_composicao_frete : Form
    {
        public string cod_cte;
        public string nota_fiscal;
        DataSet dsTabela_composicao_preco = new DataSet();

        public double sub_total;
        public double aliquota;
        public double valor_icms;
        public double valor_total;
        public bool calcular_automatico;

        public form_composicao_frete()
        {
            InitializeComponent();
        }

        private void form_composicao_frete_Load(object sender, EventArgs e)
        {

            tb_aliquota.Text = "12";
            selecionar_itens_composicao();
            if (calcular_automatico)
            {
                //buscar_da_tabela();
                buscar_tabela_excel();
                selecionar_itens_composicao();
                somar_valores();
                salvar();
                this.Close();
            }
        }

        private void buscar_tabela_excel()
        {
            try
            {
                OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;data source='c:\\evolucao_dokinos\\excel\\notas.xls';Extended Properties=\"Excel 8.0;HDR=NO;IMEX=1;\"");
                theConnection.Open();
                OleDbDataAdapter theDataAdapter = new OleDbDataAdapter("SELECT * FROM [Plan1$]", theConnection);
                DataSet theDS = new DataSet();
                theDataAdapter.Fill(theDS);
                theConnection.Close();
                foreach (DataRow dr in theDS.Tables[0].Select("F1 = '" + nota_fiscal + "'"))
                {
                    try
                    {
                        inserir_item_composicao("FRETE", Convert.ToDouble(dr[1].ToString()));
                    }
                    catch
                    {
                        inserir_item_composicao("FRETE", Convert.ToDouble("0"));
                    }
                }

            }
            catch (Exception a)
            {

            }
        }

        private void buscar_da_tabela()
        {
            double peso = 0;
            string cnpj_tomador = "";
            double cubagem = 0;
            double valor_nf = 0;
            string cod_cidade = "";
            string tipo_frete = "";
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT cte.TOMADOR_CNPJ_CTE, cte.PESO_CTE, cte.CUBAGEM_CTE, " + 
                    "cte.VALOR_MERCADO_CTE, cte.COD_CTE, cte.TIPO_FRETE_CTE FROM CTE cte INNER JOIN " + 
                    "CLIENTES cli ON cte.TOMADOR_CNPJ_CTE = cli.CNPJ " + 
                    "WHERE COD_CTE = '" + cod_cte + "'";
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.SelectCommand = select;
                DataSet dsTabela = new DataSet();
                datTabela.Fill(dsTabela);
                fbConnection1.Close();

                foreach (DataRow dr in dsTabela.Tables[0].Rows)
                {
                   
                    //pegando dados do cte
                    try
                    {
                        cnpj_tomador = dr[0].ToString();
                    }
                    catch { }
                    try
                    {
                        peso = Convert.ToDouble(dr[1].ToString());
                    }
                    catch { }
                    try
                    {
                        cubagem = Convert.ToDouble(dr[2].ToString());
                    }
                    catch { }
                    try
                    {
                        valor_nf = Convert.ToDouble(dr[3].ToString());
                    }
                    catch { }
                    try
                    {
                        tipo_frete = dr["TIPO_FRETE_CTE"].ToString()[0].ToString();
                    }
                    catch { }
                    
                }


                //pegar dados dA TABELA DO TOMADOR OU PADRAO
                //WHERE CNPJ = XXXXXX OU CNPJ = 9999999 ORDER BY CNPJ
                double seguro = 0, coleta = 0, pedagio = 0,
                    m3 = 0, porc_aliq = 0, acima_kgs_bp = 0, 
                    valor_acima_bp = 0, acima_kgs_sp = 0, valor_acima_sp = 0, 
                    cat = 0, despacho = 0, peso_inicial = 0, peso_final = 0, valor_peso = 0, 
                    porc_outras_taxas = 0, valor_outras_taxas = 0, 
                    valor_frete = 0, 
                    valor_pelo_peso = 0, valor_outras_despesas = 0;
                string descricao_outras_taxas = "";
                try
                {
                    FbCommand select_tabela = new FbCommand();
                    select_tabela.Connection = fbConnection1;
                    fbConnection1.Open();
                    select_tabela.CommandText =
                        "SELECT * FROM TABELA_COMPOSICAO_PRECO WHERE "+
                        "(CNPJ_CLIENTE_TCP = '" + cnpj_tomador + "') AND " +
                        "(PESO_INICIAL_TCP < '" + peso.ToString().Replace(",", ".") + "' AND " +
                        "PESO_FINAL_TCP >= '" + peso.ToString().Replace(",", ".") + "') AND " + 
                        "FRETE_TCP = '" + tipo_frete + "' " +
                        "ORDER BY CNPJ_CLIENTE_TCP"; 
                    FbDataAdapter datTabela_precos = new FbDataAdapter();
                    datTabela_precos.SelectCommand = select_tabela;
                    DataSet dsTabela_precos = new DataSet();
                    datTabela_precos.Fill(dsTabela_precos);
                    fbConnection1.Close();
                    bool primeiro = true;
                    if (dsTabela_precos.Tables[0].Rows.Count == 0)
                    {
                        //dsTabela_precos.Clear();
                        select_tabela.Connection = fbConnection1;
                        fbConnection1.Open();
                        select_tabela.CommandText =
                            "SELECT * FROM TABELA_COMPOSICAO_PRECO WHERE " +
                            "(CNPJ_CLIENTE_TCP = '99999999999999') AND " +
                            "(PESO_INICIAL_TCP < '" + peso.ToString().Replace(",", ".") + "' AND " +
                        "PESO_FINAL_TCP >= '" + peso.ToString().Replace(",", ".") + "') AND " +
                        "FRETE_TCP = '" + tipo_frete + "' " +
                            "ORDER BY CNPJ_CLIENTE_TCP";
                        datTabela_precos.SelectCommand = select_tabela;
                        DataSet dsTabela_padrao = new DataSet();
                        datTabela_precos.Fill(dsTabela_padrao);
                        fbConnection1.Close();
                        dsTabela_precos = dsTabela_padrao;
                    }
                    foreach (DataRow dr in dsTabela_precos.Tables[0].Rows)
                    {
                        if (primeiro)
                        {

                            try
                            {
                                if (Convert.ToDouble(dr["PESO_FINAL_TCP"].ToString()) == 99999)
                                {
                                    try
                                    {
                                        double _valor = 0;
                                        double _peso_inicial = 0;
                                        try
                                        {
                                            _valor = Convert.ToDouble(dr["VALOR_PESO_TCP"].ToString());
                                        }
                                        catch { }
                                        try
                                        {
                                            _peso_inicial = Convert.ToDouble(dr["PESO_INICIAL_TCP"].ToString());
                                        }
                                        catch { }
                                        if (_valor != 0 && _peso_inicial != 0)
                                        {
                                            valor_pelo_peso = peso *
                                                _valor /
                                                _peso_inicial;
                                        }
                                       
                                    }
                                    catch { }
                                }
                                else
                                {
                                    valor_pelo_peso = Convert.ToDouble(dr["VALOR_PESO_TCP"].ToString());
                                }
                                inserir_item_composicao("FRETE PESO", valor_pelo_peso);
                            }
                            catch
                            { }
                            try
                            {
                                double _seguro = Convert.ToDouble(dr["SEGURO_TCP"].ToString());
                                valor_frete = valor_nf * _seguro / 100;
                                double valor_minimo = 0;
                                try
                                {
                                    valor_minimo = Convert.ToDouble(dr["MINIMO_TCP"].ToString());
                                }
                                catch { }
                                if (valor_minimo > valor_frete)
                                    valor_frete = valor_minimo;
                                inserir_item_composicao("FRETE VALOR", valor_frete);
                            }
                            catch { }
                            try
                            {
                                cat = Convert.ToDouble(dr["CAT_BP_TCP"].ToString());
                                inserir_item_composicao("CAT", cat);
                            }
                            catch { }
                            try
                            {
                                despacho = Convert.ToDouble(dr["DESP_BP_TCP"].ToString());
                                inserir_item_composicao("DESPACHO", despacho);
                            }
                            catch { }


                            try
                            {
                                pedagio = Convert.ToDouble(dr["PEDAGIO_TCP"].ToString());
                                inserir_item_composicao("PEDAGIO", pedagio);
                            }
                            catch { }
                            try
                            {
                                if (cbColeta.Checked)
                                {
                                    coleta = Convert.ToDouble(dr["COLETA_TCP"].ToString());
                                }
                                else
                                {
                                    coleta = 0;
                                }
                                inserir_item_composicao("COLETA", coleta);
                            }
                            catch { }
                            try
                            {
                                if (cbCubagem.Checked)
                                    m3 = cubagem * Convert.ToDouble(dr["M3_TCP"].ToString());
                                if (m3 > 0)
                                    inserir_item_composicao("CUBAGEM", m3);
                            }
                            catch { }
                            try
                            {
                                valor_outras_taxas = Convert.ToDouble(dr["VALOR_OUTRAS_TAXAS_TCP"].ToString());
                                descricao_outras_taxas = dr["DESCRIC_VALOR_OUTRAS_TAXAS_TCP"].ToString();
                                inserir_item_composicao(descricao_outras_taxas, valor_outras_taxas);
                            }
                            catch { }
                            sub_total = valor_pelo_peso + valor_frete + coleta + pedagio + cat + despacho + valor_outras_taxas;
                            double variavel = Convert.ToDouble("13,6364");
                            try
                            {
                                porc_aliq = Convert.ToDouble(tb_aliquota.Text);
                            }
                            catch { }
                            if (porc_aliq == 7)
                                variavel = Convert.ToDouble("7,531");
                            variavel = (1 - (porc_aliq / 100));
                            if (verificar_se_e_simples(cod_cte))
                            {
                                variavel = 0;
                                porc_aliq = 0;
                            }
                            else
                            {
                                tb_aliquota.Text = porc_aliq.ToString("n2");
                                valor_icms = (sub_total / variavel) - sub_total;
                                inserir_item_composicao("VALOR ICMS", valor_icms);
                            }
                            selecionar_itens_composicao();
                            somar_valores();

                        }
                        primeiro = false;
                    }
                    
                }
                catch (Exception a)
                {
                    fbConnection1.Close();
                    MessageBox.Show(a.ToString());
                }
                
           }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private string buscar_cod_cidade(string cod_cte)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT DESTINATARIO_CNPJ_CTE, RECEBEDOR_CNPJ_CTE FROM CTE WHERE COD_CTE = '" + cod_cte + "'";
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.SelectCommand = select;
                DataSet dsTabela = new DataSet();
                datTabela.Fill(dsTabela);
                fbConnection1.Close();
                string cnpj = "";
                foreach (DataRow dr in dsTabela.Tables[0].Rows)
                {
                    if (dr[1].ToString() != "")
                        cnpj = dr[1].ToString();
                    else
                        cnpj = dr[0].ToString();
                }
                try
                {
                    select.Connection = fbConnection1;
                    fbConnection1.Open();
                    select.CommandText =
                        "SELECT COD_CIDADE_CLIENTE FROM CLIENTES WHERE CNPJ = '" + cnpj + "'";
                    datTabela.SelectCommand = select;
                    DataSet dsCidade = new DataSet();
                    datTabela.Fill(dsCidade);
                    fbConnection1.Close();
                    foreach (DataRow dr_cidade in dsCidade.Tables[0].Rows)
                    {
                        return dr_cidade[0].ToString();
                    }

                }
                catch (Exception a)
                {
                    fbConnection1.Close();
                    MessageBox.Show(a.ToString());
                }
                return "";
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
                return "";
            }
        }

        private bool verificar_se_e_simples(string cod_cte)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT empresa.CRT_EMPRESA FROM EMPRESA empresa INNER JOIN CTE cte ON empresa.CNPJ_EMPRESA = cte.EMITENTE_CNPJ_CTE " +
                    "WHERE cte.COD_CTE = '" + cod_cte + "'";
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.SelectCommand = select;
                DataSet dsTabela = new DataSet();
                datTabela.Fill(dsTabela);
                fbConnection1.Close();
                foreach (DataRow dr in dsTabela.Tables[0].Rows)
                {
                    if (dr[0].ToString() == "3")
                        return false;
                }
                return true;

            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
                return true;
            }
        }

        private void somar_valores()
        {
            if (tb_aliquota.Text == "")
                tb_aliquota.Text = buscar_aliquota();
            double _sub_total = 0;
            int linha_icms = 999999;
            for (int i = 0; i < dgvCte_frete_composicao.RowCount; i++)
            {
                try
                {
                    if (!dgvCte_frete_composicao.Rows[i].Cells["col_descricao"].Value.ToString().ToUpper().Contains("ICMS"))
                    {
                        _sub_total = _sub_total + Convert.ToDouble(dgvCte_frete_composicao.Rows[i].Cells["col_valor"].Value.ToString());
                    }
                    else
                    {
                        linha_icms = i;
                    }

                }
                catch { }
            }
            double porc_aliq = 0;
            
            try
            {
                porc_aliq = Convert.ToDouble(tb_aliquota.Text);
            }
            catch { }
            double variavel = porc_aliq;// Convert.ToDouble("13,6364");
            //if (porc_aliq == 7)
           //     variavel = Convert.ToDouble("7,531");
            if(verificar_se_e_simples(cod_cte))
            {
                porc_aliq = 0;
                //variavel = 0;
            }
            double _valor_icms = _sub_total * variavel / 100;
            if (linha_icms != 999999)
                excluir_linha(dgvCte_frete_composicao.Rows[linha_icms].Cells["col_cod"].Value.ToString());

            inserir_item_composicao("VALOR ICMS", _valor_icms);
            tb_valor_icms.Text = _valor_icms.ToString("n2");
            tb_subtotal.Text = _sub_total.ToString("n2");
            double _valor_total = _sub_total;// + _valor_icms;
            tb_valor_total_cte.Text = _valor_total.ToString("n2");
            tb_base_calculo.Text = _valor_total.ToString("n2");
            

            valor_total = Convert.ToDouble(tb_valor_total_cte.Text);
            aliquota = Convert.ToDouble(tb_aliquota.Text);
            valor_icms = Convert.ToDouble(tb_valor_icms.Text);
            sub_total = Convert.ToDouble(tb_subtotal.Text);
            selecionar_itens_composicao();
            
        }

        private string buscar_aliquota()
        {
            double peso = 0;
            string cnpj_tomador = "";
            double cubagem = 0;
            double valor_nf = 0;
            string cod_cidade = "";
            try
            {
               FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT cte.TOMADOR_CNPJ_CTE, cte.PESO_CTE, cte.CUBAGEM_CTE, " + 
                    "cte.VALOR_MERCADO_CTE, cli.COD_CIDADE_CLIENTE FROM CTE cte INNER JOIN " + 
                    "CLIENTES cli ON cte.TOMADOR_CNPJ_CTE = cli.CNPJ " + 
                    "WHERE COD_CTE = '" + cod_cte + "'";
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.SelectCommand = select;
                DataSet dsTabela = new DataSet();
                datTabela.Fill(dsTabela);
                fbConnection1.Close();
                foreach (DataRow dr in dsTabela.Tables[0].Rows)
                {
                   
                    //pegando dados do cte
                    try
                    {
                        cnpj_tomador = dr[0].ToString();
                    }
                    catch { }
                    try
                    {
                        peso = Convert.ToDouble(dr[1].ToString());
                    }
                    catch { }
                    try
                    {
                        cubagem = Convert.ToDouble(dr[2].ToString());
                    }
                    catch { }
                    try
                    {
                        valor_nf = Convert.ToDouble(dr[3].ToString());
                    }
                    catch { }
                    try
                    {
                        cod_cidade = dr[4].ToString();
                    }
                    catch { }
                }


                //pegar dados dA TABELA DO TOMADOR OU PADRAO
                //WHERE CNPJ = XXXXXX OU CNPJ = 9999999 ORDER BY CNPJ
                double seguro = 0, coleta = 0, pedagio = 0,
                    m3 = 0, porc_aliq = 0, acima_kgs_bp = 0, 
                    valor_acima_bp = 0, acima_kgs_sp = 0, valor_acima_sp = 0, 
                    cat = 0, despacho = 0, peso_inicial = 0, peso_final = 0, valor_peso = 0, 
                    porc_outras_taxas = 0, valor_outras_taxas = 0, 
                    valor_frete = 0, 
                    valor_pelo_peso = 0, valor_outras_despesas = 0;
                string descricao_outras_taxas = "";
                try
                {
                    FbCommand select_tabela = new FbCommand();
                    select_tabela.Connection = fbConnection1;
                    fbConnection1.Open();
                    select_tabela.CommandText =
                        "SELECT PORC_ALIQ_TCP FROM TABELA_COMPOSICAO_PRECO WHERE " +
                        "(CNPJ_CLIENTE_TCP = '" + cnpj_tomador + "') AND " +
                        "((VALOR_ACIMA_KG_BP_TCP <= '" + peso + "' OR " +
                        "VALOR_ACIMA_KG_SP_TCP <= '" + peso + "') OR " +
                        "(PESO_INICIAL_TCP <= '" + peso + "' AND " +
                        "PESO_FINAL_TCP >= '" + peso + "'))" +
                        " OR (CNPJ_CLIENTE_TCP = '99999999999999') " +
                        "ORDER BY CNPJ_CLIENTE_TCP";
                    FbDataAdapter datTabela_precos = new FbDataAdapter();
                    datTabela_precos.SelectCommand = select_tabela;
                    DataSet dsTabela_precos = new DataSet();
                    datTabela_precos.Fill(dsTabela_precos);
                    fbConnection1.Close();
                    bool primeiro = true;
                    foreach (DataRow dr in dsTabela_precos.Tables[0].Rows)
                    {
                        return dr[0].ToString();
                    }
                    return "";
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.ToString());
                    fbConnection1.Close();
                    return "";
                }
            }
            catch(Exception a) 
            {
                
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
                return "";
            }
        }

        private void excluir_linha(string cod)
        {
           
                try
                {
                    datCte_frete_composicao.DeleteCommand.CommandText =
                        "DELETE FROM CTE_FRETE_COMPOSICAO WHERE COD_CFC = '" + cod + "'";
                    datCte_frete_composicao.DeleteCommand.Connection = fbConnection1;
                    fbConnection1.Open();
                    datCte_frete_composicao.DeleteCommand.ExecuteNonQuery();
                    fbConnection1.Close();
                    
                }
                catch (Exception a)
                {
                    fbConnection1.Close();
                    MessageBox.Show(a.ToString());
                }
            
        }

        private void selecionar_itens_composicao()
        {
            try
            {
                dsCte_frete_composicao.Clear();

                datCte_frete_composicao.SelectCommand.CommandText =
                "SELECT * FROM CTE_FRETE_COMPOSICAO WHERE COD_CTE_CFC = '" + cod_cte + "'";
                datCte_frete_composicao.SelectCommand.Connection = fbConnection1;
                fbConnection1.Open();
                datCte_frete_composicao.SelectCommand.ExecuteNonQuery();
                datCte_frete_composicao.Fill(CTE_FRETE_COMPOSICAO);
                fbConnection1.Close();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }

        }

        private void inserir_item_composicao(string descricao, double valor_frete)
        {
            try
            {
                FbCommand insert = new FbCommand();
                insert.Connection = fbConnection1;
                fbConnection1.Open();
                insert.CommandText =
                    "INSERT INTO CTE_FRETE_COMPOSICAO (DESCRICAO_CFC, VALOR_CFC, COD_CTE_CFC) " +
                    "VALUES ('" + descricao + "','" + valor_frete.ToString().Replace(".","").Replace(",",".") + "','" + cod_cte + "')";
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.InsertCommand = insert;
                datTabela.InsertCommand.ExecuteNonQuery();
                fbConnection1.Close();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            buscar_da_tabela();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_valor.Text == "")
                tb_valor.Text = "0";
            inserir_item_composicao(tb_descricao.Text, Convert.ToDouble(tb_valor.Text));
            somar_valores();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            salvar();
            
        }
        
        private void salvar()
        {
            try
            {
                this.BindingContext[dsCte_frete_composicao, "CTE_FRETE_COMPOSICAO"].EndCurrentEdit();
                if (dsCte_frete_composicao.HasChanges())
                {
                    fbConnection1.Open();
                    datCte_frete_composicao.UpdateCommand = cbCte_frete_composicao.GetUpdateCommand();
                    datCte_frete_composicao.InsertCommand = cbCte_frete_composicao.GetInsertCommand();
                    datCte_frete_composicao.DeleteCommand = cbCte_frete_composicao.GetDeleteCommand();
                    datCte_frete_composicao.Update(dsCte_frete_composicao, "CTE_FRETE_COMPOSICAO");
                    dsCte_frete_composicao.AcceptChanges();
                    fbConnection1.Close();
                }
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            somar_valores();
        }

        private void form_composicao_frete_FormClosed(object sender, FormClosedEventArgs e)
        {
            somar_valores();

        }
    }
}