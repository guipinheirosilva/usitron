using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.IO;
using CTe_Util;
using System.Collections;
using System.Data.OleDb;
using System.Globalization;

namespace Evolucao
{
    public partial class form_cte : Form
    {
        NFe_Util_2G.Util util2 = new NFe_Util_2G.Util();
        CTe_Util.Util util = new CTe_Util.Util();
        public string empresa_emissora, cnpj_empresa_emissora;
        public string funcionario_emissor;
        public string n_cte;
        public bool desabilita = false, ok = false;
        public bool geradoXml = false;
        DateTime gerarEnviar = new DateTime();
        string rntrc_empresa, mercadoria_cte_empresa;

        public bool impressao_cte;
        public string cte_a_abrir = "";
        public string cnpj_emitente_a_abrir = "";

        public form_cte()
        {
            InitializeComponent();
        }

        private void form_cte_Load(object sender, EventArgs e)
        {
           
                gerarEnviar = DateTime.Now.AddYears(-1);
                empresatoolStripStatusLabel.Text = empresa_emissora;
                cnpjtoolStripStatusLabel.Text = cnpj_empresa_emissora;
                buscar_informacoes_empresa(cnpj_empresa_emissora, out rntrc_empresa, out mercadoria_cte_empresa);


                if (empresa_emissora.Contains("LIVIA"))
                {
                    empresatoolStripStatusLabel.BackColor = Color.YellowGreen;
                    this.BackColor = Color.YellowGreen;
                }
                if (empresa_emissora.Contains("LUZIA"))
                {
                    empresatoolStripStatusLabel.BackColor = Color.Red;
                    this.BackColor = Color.Red;
                }
                if (empresa_emissora.Contains("FILIAL"))
                {
                    empresatoolStripStatusLabel.BackColor = Color.GreenYellow;
                    this.BackColor = Color.GreenYellow;
                }
                if (n_cte != null)
                    selecionar_cte(n_cte, cnpj_empresa_emissora);
                if (desabilita)
                {
                    desabilitaBotoesDetalhada(this);
                }
                else if (tb_func.Text.Trim() != "")
                {
                    if (funcionario_emissor != tb_func.Text && funcionario_emissor != "1" && funcionario_emissor != "8")
                    {
                        desabilitaBotoes(this);
                    }
                    else
                    {
                        if (button4.Enabled == false)
                        {
                            abilitaBotoes(this);
                        }
                    }
                }
                else
                {
                    if (button4.Enabled == false)
                    {
                        abilitaBotoes(this);
                    }
                }

                if (cte_a_abrir != "")
                {
                    selecionar_cte(cte_a_abrir, cnpj_emitente_a_abrir);
                    imprimir_cte();
                    this.Close();
                }

            
        }

        private void buscar_informacoes_empresa(string cnpj_empresa_emissora, out string rntrc_empresa, out string mercadoria_cte_empresa)
        {
            rntrc_empresa = ""; mercadoria_cte_empresa = "";
            try
            {
                FbCommand select = new FbCommand();
                FbDataAdapter datSel = new FbDataAdapter();
                DataTable dt = new DataTable();
                select.CommandText = "SELECT * FROM EMPRESA WHERE CNPJ_EMPRESA = '" + cnpj_empresa_emissora + "'";
                select.Connection = fbConnection1;
                datSel.SelectCommand = select;
                fbConnection1.Open();
                datSel.Fill(dt);
                fbConnection1.Close();
                foreach (DataRow d in dt.Rows)
                {
                    rntrc_empresa = d["RNTRC_EMPRESA"].ToString();
                    mercadoria_cte_empresa = d["MERCADORIA_CTE_EMPRESA"].ToString();
                }
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool erro;
            novo(out erro);
            if (button4.Enabled == false)
            {
                abilitaBotoes(this);
            }
            geradoXml = false;
        }

        private void novo(out bool erro)
        {
            erro = false;
            try
            {
                /*
                Random r = new Random();
                int i = r.Next(2000, 4000);
                Thread.Sleep(i);
                tb_chave_a_buscar.Text = "";
                tb_caminho.Text = "";
                 
                while (reservado())
                {
                    MessageBox.Show("Aguarde enquanto outro CTe é inserido para não haver duplicidade");
                }
                reservar();
                 
               
                
                if (verificar_se_existe(proximo, cnpj_empresa_emissora))
                {
                    while (reservado())
                    {
                        MessageBox.Show("Aguarde enquanto outro CTe é inserido para não haver duplicidade");
                    }
                    proximo = buscar_proximo_numero(cnpj_empresa_emissora).ToString();
                }
                 * */
                string proximo = buscar_proximo_numero(cnpj_empresa_emissora).ToString();
                string cteCnpj = proximo + cnpj_empresa_emissora;
                datCte.InsertCommand.CommandText =
                    "INSERT INTO CTE (N_CTE, DATA_EMISSAO_CTE, HORA_EMISSAO_CTE, " +
                    "EMITENTE_NOME_CTE, EMITENTE_CNPJ_CTE, CTE_CNPJ, EMITIDO_POR_CTE) VALUES (" +
                    proximo + ", CURRENT_DATE, " +
                    "CURRENT_TIME, '" + empresa_emissora + "', '" +
                    cnpj_empresa_emissora + "', '" + cteCnpj + "', '" + funcionario_emissor + "')";
                datCte.InsertCommand.Connection = fbConnection1;
                fbConnection1.Open();
                datCte.InsertCommand.ExecuteNonQuery();
                fbConnection1.Close(); 
                retirar_reserva();

                selecionar_cte(proximo, cnpj_empresa_emissora);
                cbFrete.Text = "0 - Pago";
                tb_cfop.Text = "5353";
                tb_natureza_operacao.Text = "Prestação de serviço de transporte a estabelecimento comercial";
                tb_mercadoria.Text = mercadoria_cte_empresa;
                tb_rntrc.Text = rntrc_empresa;
                cb_outros.Checked = false;
                atualizar(false);
                tb_chave_a_buscar.Focus();
                if (verificar_se_existe_2_registros_iguais(proximo, cnpj_empresa_emissora))
                {
                    MessageBox.Show("Esse registro será excluído pois já existe um com o mesmo número");
                    excluir_por_numero(proximo, cnpj_empresa_emissora);
                    erro = true;
                }


            }

            catch (FbException a)
            {
                fbConnection1.Close(); 
                if (a.Message.Contains("UNQ1_CTE"))
                {
                    novo(out erro);
                }
                else
                {

                    erro = true;
                    MessageBox.Show(a.Message);
                }
            }
            catch (Exception a)
            {
                fbConnection1.Close(); 
                erro = true;
                MessageBox.Show(a.Message);
            }
        }

        private void excluir_por_numero(string _n_cte, string _cnpj)
        {

            try
            {
                this.datCte.DeleteCommand.CommandText =
                   "DELETE FROM CTE WHERE N_CTE = '" + _n_cte + "' AND EMITENTE_CNPJ_CTE = '" + _cnpj + "'";
                this.fbConnection1.Open();
                this.datCte.DeleteCommand.Connection = fbConnection1;
                this.datCte.DeleteCommand.ExecuteNonQuery();
                this.fbConnection1.Close(); 

                dsCte.Clear();
            }
            catch (Exception a)
            {
                fbConnection1.Close(); 
                MessageBox.Show(a.ToString());
            }


        }

        private bool verificar_se_existe_2_registros_iguais(string proximo, string cnpj_empresa_emissora)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT * FROM CTE WHERE " +
                    "N_CTE = '" + proximo +
                    "' AND EMITENTE_CNPJ_CTE = '" + cnpj_empresa_emissora + "'";
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.SelectCommand = select;
                DataSet dsTabela = new DataSet();
                datTabela.Fill(dsTabela);
                fbConnection1.Close(); 
                foreach (DataRow dr in dsTabela.Tables[0].Rows)
                {
                    if (dsTabela.Tables[0].Rows.Count > 1)
                        return true;
                }
                return false;
            }
            catch (Exception a)
            {
                fbConnection1.Close(); 
                MessageBox.Show(a.ToString());
                return false;
            }
        }

        private bool verificar_se_existe(string proximo, string cnpj_empresa_emissora)
        {
            throw new Exception("The method or operation is not implemented.");
        }


        private void retirar_reserva()
        {
            try
            {
                FbCommand update = new FbCommand();
                update.Connection = fbConnection1;
                fbConnection1.Open();
                update.CommandText =
                    "UPDATE RESERVA SET RESERVADO_RESERVA = '0' WHERE COD_RESERVA = '1'";
                FbDataAdapter datUpdate = new FbDataAdapter();
                datUpdate.UpdateCommand = update;
                datUpdate.UpdateCommand.ExecuteNonQuery();
                fbConnection1.Close(); 
            }
            catch (Exception a)
            {
                fbConnection1.Close(); 
                MessageBox.Show(a.ToString());
            }
        }

        private void reservar()
        {
            try
            {
                FbCommand update = new FbCommand();
                update.Connection = fbConnection1;
                fbConnection1.Open();
                update.CommandText =
                    "UPDATE RESERVA SET RESERVADO_RESERVA = '1' WHERE COD_RESERVA = '1'";
                FbDataAdapter datUpdate = new FbDataAdapter();
                datUpdate.UpdateCommand = update;
                datUpdate.UpdateCommand.ExecuteNonQuery();
                fbConnection1.Close(); 
            }
            catch (Exception a)
            {
                fbConnection1.Close(); 
                MessageBox.Show(a.ToString());
            }
        }

        private bool reservado()
        {
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT * FROM RESERVA WHERE " +
                    "RESERVADO_RESERVA = '1'";
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
                MessageBox.Show(a.ToString());
                return false;
            }
        }

        private void selecionar_cte(string _n_cte, string _cnpj_empresa_emissora)
        {
            try
            {
                dsCte.Clear();
                datCte.SelectCommand.CommandText =
                "SELECT * FROM CTE WHERE N_CTE = '" + _n_cte + "' AND EMITENTE_CNPJ_CTE = '" + _cnpj_empresa_emissora + "'";
                datCte.SelectCommand.Connection = fbConnection1;
                fbConnection1.Open();
                datCte.SelectCommand.ExecuteNonQuery();
                datCte.Fill(CTE);
                fbConnection1.Close(); 
                selecionar_faturas();
                selecionar_nfs_do_cte();
                selecionar_itens_composicao();

            }
            catch (Exception a)
            {
                fbConnection1.Close(); 
                MessageBox.Show(a.ToString());
            }
        }

        private int buscar_proximo_numero(string cnpj_empresa_emissora)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT FIRST(1) N_CTE FROM CTE WHERE " +
                    "EMITENTE_CNPJ_CTE = '" + cnpj_empresa_emissora + "' " +
                    "ORDER BY N_CTE DESC";
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.SelectCommand = select;
                DataSet dsTabela = new DataSet();
                datTabela.Fill(dsTabela);
                fbConnection1.Close(); 
                foreach (DataRow dr in dsTabela.Tables[0].Rows)
                {
                    try
                    {
                        return Convert.ToInt32(dr[0].ToString()) + 1;
                    }
                    catch
                    {
                        return 0;
                    }
                }
                return 1;
            }
            catch (Exception a)
            {
                fbConnection1.Close(); 
                MessageBox.Show(a.ToString());
                return 0;
            }
        }

        private bool verificaRepetido(string caminho, out string status)
        {
            status = "";
            try
            {
                DataSet ds = new DataSet();
                ds.ReadXml(@caminho);
                string chave;
                DataRow dr_chave = ds.Tables["infProt"].Rows[0];
                chave = dr_chave["chNFe"].ToString();
                
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT cnf.COD_CNF, cte.STATUS_CTE FROM CTE_NOTAS_FISCAIS cnf INNER JOIN " +
                    "CTE cte ON cnf.COD_CTE_CNF = cte.COD_CTE WHERE " +
                    "cnf.CHAVE_NF_CNF = '" + chave + "'";
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.SelectCommand = select;
                DataSet dsTabela = new DataSet();
                datTabela.Fill(dsTabela);
                fbConnection1.Close(); 
                foreach (DataRow dr in dsTabela.Tables[0].Rows)
                {
                    status = dr[1].ToString();
                    return true;
                }
                return false;
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
                fbConnection1.Close(); 
                return false;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Multiselect = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                progressBar1.Maximum = openFileDialog1.FileNames.Length - 1;
                progressBar1.Value = 0;
                DateTime inicio = DateTime.Now;
                if (openFileDialog1.FileNames.Length > 1)
                {
                    /*
                    novo(out erro);
                    if (verificar_se_nf_esta_na_planilha(openFileDialog1.FileNames[0].ToString()))
                        importar_xml(openFileDialog1.FileNames[0].ToString());
                    atualizar(false);
                    */

                    for (int i = 0; i < openFileDialog1.FileNames.Length; i++)
                    {
                        if (cbPortaria_121.Checked)
                        {
                            if (openFileDialog1.FileNames.Length > 4)
                            {

                                importar_xml(openFileDialog1.FileNames[i].ToString());
                                //gerarXml(false);
                                atualizar(false);

                            }
                            else
                                MessageBox.Show("O número mínimo de remetentes para atender a Portaria Cat 121 é de 5 (Cinco).");
                        }
                        else
                        {

                            if (verificar_se_nf_esta_na_planilha(openFileDialog1.FileNames[i].ToString()) || empresa_emissora.Contains("LLOC"))
                            {
                                string status;
                                bool verifica = verificaRepetido(openFileDialog1.FileNames[i].ToString(), out status);

                                if ((verifica == true && (status.Contains("Cancelada") || status.Contains("Inutilizada"))) ||
                                    verifica == false)
                                {
                                    progressBar1.Value = i;
                                    progressBar1.Update();
                                    bool erro = false;
                                    novo(out erro);
                                    if (!erro)
                                    {
                                        importar_xml(openFileDialog1.FileNames[i].ToString());
                                        gerarXml(false);
                                        atualizar(false);
                                    }
                                    else
                                        i--;
                                }
                            }


                        }
                    }
                    if (cbPortaria_121.Checked)
                    {
                        gerarXml(true);
                    }


                }
                else
                {
                    tb_caminho.Text = openFileDialog1.FileNames[0].ToString();
                }
                DateTime fim = DateTime.Now;
                TimeSpan diferenca = fim - inicio;
                MessageBox.Show(diferenca.ToString());
            }
            else { }
            geradoXml = false;
        }

        private bool verificar_se_nf_esta_na_planilha(string caminho)
        {

            try
            {
                DataSet ds = new DataSet();
                ds.ReadXml(@caminho);
                string nf = "999999", serie;
                foreach (DataRow dr_n_nf in ds.Tables["ide"].Rows)
                {
                    nf = dr_n_nf["nNF"].ToString();
                    serie = dr_n_nf["serie"].ToString();
                }
                
                /*
                if (serie != "16")
                {
                    return true;
                }
                */

                OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:\\evolucao\\excel\\notas.xls';Extended Properties=\"Excel 8.0;HDR=NO;IMEX=1;\"");
                theConnection.Open();
                OleDbDataAdapter theDataAdapter = new OleDbDataAdapter("SELECT * FROM [Plan1$]", theConnection);
                DataSet theDS = new DataSet();
                theDataAdapter.Fill(theDS);
                theConnection.Close();
                foreach (DataRow dr in theDS.Tables[0].Select("F1 = '" + nf + "'"))
                {
                    if (Convert.ToDouble(dr[1].ToString()) > 0)
                    {
                        return true;
                    }
                    else
                        return false;
                }
                return false;
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
                return false;
            }
        }


        private void button15_Click(object sender, EventArgs e)
        {
            importar_xml(tb_caminho.Text);
        }

        private void importar_xml(string caminho)
        {
            buscar_dados(caminho);
            atualizar(true);
            mover_arquivo(caminho);
        }

        private void mover_arquivo(string caminho)
        {
            //quando terminar importação mover o arquivo para uma pasta chamada IMPORTADOS
        }

        private void buscar_dados(string caminho)
        {
            try
            {
                DataSet ds = new DataSet();

                ds.ReadXml(@caminho);
                //inserindo/atualizando remetente
                foreach (DataRow dr in ds.Tables["emit"].Rows)
                {
                    verificar_se_cliente_ja_existe(dr["CNPJ"].ToString(), ds.Tables["emit"], ds.Tables["enderEmit"], "REMETENTE");
                    tb_remetente_nome.Text = dr["xNome"].ToString();
                    tb_remetente_cnpj.Text = dr["CNPJ"].ToString();
                    //tb_expedidor_nome.Text = dr["xNome"].ToString();
                    //tb_expedidor_cnpj.Text = dr["CNPJ"].ToString();                    

                    tb_tomador_nome.Text = dr["xNome"].ToString();
                    tb_tomador_cnpj.Text = dr["CNPJ"].ToString();

                    //QUANDO A EMPRESA FOR NIVALDO (NESVALE)
                    if ((tb_tomador_cnpj.Text == "61116331009647") && (cnpj_empresa_emissora == "13438952000133"))
                        tb_tomador_cnpj.Text = "61116331000186";
                    if ((tb_remetente_cnpj.Text == "61116331009647") && (cnpj_empresa_emissora == "13438952000133"))
                        tb_remetente_cnpj.Text = "61116331000186";

                }
                //inserindo/atualizando destinatario
                if (cbPortaria_121.Checked)
                {
                    try
                    {
                        tb_destinatario_nome.Text = "DIVERSOS";
                        tb_destinatario_cnpj.Text = cnpj_empresa_emissora;
                        if (!tb_observacoes.Text.Contains("Portaria CAT"))
                            tb_observacoes.Text = tb_observacoes.Text +
                                "Procedimento efetuado nos termos da Portaria CAT 121/2013.";
                    }
                    catch (Exception a)
                    {
                        MessageBox.Show(a.ToString());
                    }
                }
                else
                {
                    foreach (DataRow dr_destinatario in ds.Tables["dest"].Rows)
                    {

                        try
                        {
                            verificar_se_cliente_ja_existe(dr_destinatario["CNPJ"].ToString(), ds.Tables["dest"], ds.Tables["enderDest"], "DESTINATARIO");
                            tb_destinatario_nome.Text = dr_destinatario["xNome"].ToString();
                            tb_destinatario_cnpj.Text = dr_destinatario["CNPJ"].ToString();
                            //tb_recebedor_nome.Text = dr_destinatario["xNome"].ToString();
                            // tb_recebedor_cnpj.Text = dr_destinatario["CNPJ"].ToString();
                        }
                        catch
                        {
                            verificar_se_cliente_ja_existe(dr_destinatario["CPF"].ToString(), ds.Tables["dest"], ds.Tables["enderDest"], "DESTINATARIO");
                            tb_destinatario_nome.Text = dr_destinatario["xNome"].ToString();
                            tb_destinatario_cnpj.Text = dr_destinatario["CPF"].ToString();
                            //tb_recebedor_nome.Text = dr_destinatario["xNome"].ToString();
                            // tb_recebedor_cnpj.Text = dr_destinatario["CNPJ"].ToString();

                        }

                    }
                }
                //inserindo/buscando_dados do transporte
                string volumes = "0";
                string peso = "0";

                double _volumes = 0, _peso = 0;
                try
                {
                    foreach (DataRow dr_vol in ds.Tables["vol"].Rows)
                    {
                        try
                        {
                            _volumes = _volumes + Convert.ToDouble(dr_vol["qVol"].ToString().Replace(".", ","));
                            _peso = _peso + Convert.ToDouble(dr_vol["pesoB"].ToString().Replace(".", ","));
                        }
                        catch { }
                    }
                    volumes = _volumes.ToString().Replace(".","").Replace(",",".");
                    peso = _peso.ToString().Replace(".", "").Replace(",", ".");
                }
                catch { }

                /* NAO USARÁ TRANSPORTADORA NA DOKINOS
                //inserindo/atualizando transportadora
                try
                {
                    foreach (DataRow dr_transp in ds.Tables["transporta"].Rows)
                    {
                        try
                        {
                            if (dr_transp["CNPJ"].ToString() != cnpj_empresa_emissora)
                            {
                                verificar_se_transportadora_ja_existe(dr_transp["CNPJ"].ToString(), ds.Tables["transporta"]);
                                tb_recebedor_nome.Text = dr_transp["xNome"].ToString();
                                tb_recebedor_cnpj.Text = dr_transp["CNPJ"].ToString();
                            }
                        }
                        catch
                        {
                            verificar_se_transportadora_ja_existe(dr_transp["CPF"].ToString(), ds.Tables["transporta"]);
                            tb_recebedor_nome.Text = dr_transp["xNome"].ToString();
                            tb_recebedor_cnpj.Text = dr_transp["CPF"].ToString();
                        }
                    }
                }
                catch { }
                 * */
                //valor de mercado
                string valor_nota = "";
                foreach (DataRow dr_totais in ds.Tables["ICMSTot"].Rows)
                {
                    /* NA DOKINOS SERÁ SEMPRE VALOR DOS PRODUTOS
                    valor_nota = dr_totais["vNF"].ToString().Replace(".",",");
                    if (tb_tomador_cnpj.Text == "72909146000165" ||
                        tb_tomador_cnpj.Text == "46690038000134" ||
                        tb_tomador_cnpj.Text == "56415631000126") 283..17
                    {*/
                    valor_nota = dr_totais["vNF"].ToString().Replace("..", ".").Replace(".", ",");
                    //}
                    //
                }
                
                //numero nota
                foreach (DataRow dr_n_nf in ds.Tables["ide"].Rows)
                {
                    DateTime _data_emissao = Convert.ToDateTime("01/01/2000");
                    try
                    {
                        _data_emissao = Convert.ToDateTime(dr_n_nf["dhEmi"].ToString());
                    }
                    catch { }
                    DataRow dr_chave = ds.Tables["infProt"].Rows[0];
                    
                    inserir_notas_envolvidas(dr_n_nf["nNF"].ToString(), valor_nota, volumes, peso, dr_chave["chNFe"].ToString(), _data_emissao.ToShortDateString().ToString());
                    selecionar_nfs_do_cte();
                }
                somar_valores_nf();
                //dados adicionais
                string dados_adicionais = "";
                /* DADOS ADICIONAIS - DOKINOS NÃO PRECISA
                try
                {
                    foreach (DataRow dr_adic in ds.Tables["infAdic"].Rows)
                    {
                        tb_observacoes.Text = dr_adic["infCpl"].ToString();
                        if (tb_observacoes.Text.Length > 500)
                        {
                            tb_observacoes.Text = tb_observacoes.Text.Replace(" ", "");
                            if (tb_observacoes.Text.Length > 500)
                            {
                                tb_observacoes.Text = tb_observacoes.Text.Remove(500);
                            }

                        }
                    }
                }
                catch { }
                */
                //exceções
                if (tb_tomador_nome.Text.Contains("SAKATA"))
                {
                    tb_mercadoria.Text = "SEMENTES";
                    tb_cfop.Text = "5353";
                }

                composicao_preco(true);
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
            }
        }

        private void somar_valores_nf()
        {
            double valor = 0;
            double peso = 0;
            double volumes = 0;
            for (int i = 0; i < dgvCte_notas_fiscais.Rows.Count; i++)
            {
                try
                {
                    valor = valor + Convert.ToDouble(dgvCte_notas_fiscais.Rows[i].Cells["col_valor_nfe"].Value.ToString());
                }
                catch { }
                try
                {
                    peso = peso + Convert.ToDouble(dgvCte_notas_fiscais.Rows[i].Cells["col_peso_nfe"].Value.ToString());
                }
                catch { }
                try
                {
                    volumes = volumes + Convert.ToDouble(dgvCte_notas_fiscais.Rows[i].Cells["col_volumes_nfe"].Value.ToString());
                }
                catch { }
            }
            tb_valor_mercado.Text = valor.ToString();
            tb_peso.Text = peso.ToString();
            tb_qtde_volumes.Text = volumes.ToString();

        }

        private void selecionar_nfs_do_cte()
        {
            try
            {
                dsCte_notas_fiscais.Clear();
                datCte_notas_fiscais.SelectCommand.CommandText =
                "SELECT * FROM CTE_NOTAS_FISCAIS WHERE COD_CTE_CNF = '" + tb_cod.Text + "'";
                datCte_notas_fiscais.SelectCommand.Connection = fbConnection1;
                fbConnection1.Open();
                datCte_notas_fiscais.SelectCommand.ExecuteNonQuery();
                datCte_notas_fiscais.Fill(CTE_NOTAS_FISCAIS);
                fbConnection1.Close(); 
            }
            catch (Exception a)
            {
                fbConnection1.Close(); 
                MessageBox.Show(a.ToString());
            }

        }


        private void inserir_notas_envolvidas(string n_nf, string valor_nota,
            string volume, string peso, string chave, string _data_emissao)
        {
            try
            {


                FbCommand insert = new FbCommand();
                insert.Connection = fbConnection1;
                fbConnection1.Open();
                insert.CommandText =
                    "INSERT INTO CTE_NOTAS_FISCAIS (N_NF_CNF, CHAVE_NF_CNF, COD_CTE_CNF, VALOR_NOTA_CNF, " +
                    "VOLUMES_NOTA_CNF, PESO_NOTA_CNF, DATA_EMISSAO_NF_CNF) VALUES " +
                    "('" + n_nf + "','" + chave.Replace(" ", "") + "','" + tb_cod.Text + "','" + valor_nota.Replace(".", "").Replace(",", ".") + "','" +
                    volume + "','" + peso + "','" + Convert.ToDateTime(_data_emissao).ToShortDateString().Replace("/",".") + "')";
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

        private void verificar_se_transportadora_ja_existe(string cnpj, DataTable ds)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT COD_CLIENTE FROM CLIENTES WHERE CNPJ = '" + cnpj + "'";
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.SelectCommand = select;
                DataSet dsTabela = new DataSet();
                datTabela.Fill(dsTabela);
                fbConnection1.Close(); 
                DataRow dr_dados = ds.Rows[0];
                bool registro_existe = false;
                string pessoa_fisica = "null";

                if (cnpj.Length != 14)
                    pessoa_fisica = "'1'";
                //TRATANDO CAMPO VAZIOS
                string _razao_social = "null", _ie = "null", _endereco = "null",
                    _cidade = "null",
                    _estado = "null";
                try
                {
                    _razao_social = "'" + dr_dados["xNome"].ToString() + "'";
                }
                catch { }

                try
                {
                    _ie = "'" + dr_dados["IE"].ToString() + "'";
                }
                catch { }
                try
                {
                    _endereco = "'" + dr_dados["xEnder"].ToString() + "'";
                }
                catch { }
                try
                {
                    _cidade = "'" + dr_dados["xMun"].ToString() + "'";
                }
                catch { }
                try
                {
                    _estado = "'" + dr_dados["UF"].ToString() + "'";
                }
                catch { }


                foreach (DataRow dr in dsTabela.Tables[0].Rows)
                {
                    registro_existe = true;
                    //já existe então não faz nada
                }
                if (!registro_existe)
                {
                    MessageBox.Show("Será necessário completar o cadastro da transportadora");
                    try
                    {
                        string _cnpj = "";
                        try
                        {
                            _cnpj = dr_dados["CNPJ"].ToString();
                        }
                        catch
                        {
                            _cnpj = dr_dados["CPF"].ToString();
                        }
                        FbCommand insert = new FbCommand();
                        insert.Connection = fbConnection1;
                        fbConnection1.Open();
                        insert.CommandText =
                            "INSERT INTO CLIENTES (CNPJ, RAZAO_SOCIAL, " +
                            "IE, ENDERECO, CIDADE, ESTADO) " +
                            "VALUES ('" + _cnpj + "'," + _razao_social + "," +
                            _ie + "," + _endereco + "," +
                            _cidade + "," + _estado + ")";
                        FbDataAdapter datInsert = new FbDataAdapter();
                        datInsert.InsertCommand = insert;
                        datInsert.InsertCommand.ExecuteNonQuery();
                        fbConnection1.Close(); 
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
        private void verificar_se_cliente_ja_existe_html(string cnpj, DataTable ds, string tipo)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT COD_CLIENTE FROM CLIENTES WHERE CNPJ = '" + cnpj + "'";
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.SelectCommand = select;
                DataSet dsTabela = new DataSet();
                datTabela.Fill(dsTabela);
                fbConnection1.Close(); 
                DataRow dr_emit = ds.Rows[0];

                bool registro_existe = false;
                string pessoa_fisica = "null";

                if (cnpj.Length != 14)
                    pessoa_fisica = "'1'";
                //TRATANDO CAMPO VAZIOS
                string _razao_social = "null", _nome_fantasia = "null", _ie = "null", _endereco = "null",
                    _numero = "null", _complemento = "null", _bairro = "null", _cod_cidade = "null", _cidade = "null",
                    _estado = "null", _cep = "null", _cod_pais = "null", _pais = "null", _fone = "null";
                try
                {
                    _razao_social = "'" + dr_emit["Nome/Raz?oSocial2"].ToString() + "'";
                }
                catch { }
                try
                {
                    _nome_fantasia = "'" + dr_emit["NomeFantasia"].ToString() + "'";
                }
                catch { }
                try
                {
                    _ie = "'" + dr_emit["Inscri??oEstadual"].ToString() + "'";
                }
                catch { }
                try
                {
                    _endereco = "'" + dr_emit["Endere?o"].ToString() + "'";
                }
                catch { }
                try
                {
                    _numero = "'-'";
                }
                catch { }

                try
                {
                    _complemento = "'" + "'";
                }
                catch { }
                try
                {
                    _bairro = "'" + dr_emit["Bairro/Distrito"].ToString() + "'";
                }
                catch { }
                try
                {
                    _cod_cidade = "'" + dr_emit["Munic?pio"].ToString().Remove(7) + "'";
                }
                catch { }
                try
                {
                    string mun = dr_emit["Munic?pio"].ToString();
                    _cidade = "'" + mun.Substring(15, mun.Length - 15) + "'";
                }
                catch { }
                try
                {
                    _estado = "'" + dr_emit["UF2"].ToString() + "'";
                }
                catch { }
                try
                {
                    _cep = "'" + dr_emit["CEP"].ToString() + "'";
                }
                catch { }
                try
                {
                    _cod_pais = "'" + dr_emit["Pa?s"].ToString().Remove(4) + "'";
                }
                catch { }
                try
                {
                    string pais = dr_emit["Pa?s"].ToString();
                    _pais = "'" + pais.Substring(15, pais.Length - 15) + "'";
                }
                catch { }
                try
                {
                    _fone = "'" + dr_emit["TELEFONE"].ToString() + "'";
                }
                catch { }

                foreach (DataRow dr in dsTabela.Tables[0].Rows)
                {

                    registro_existe = true;
                    /*
                    if (tipo == "DESTINATARIO")
                    {
                        try
                        {
                            FbCommand update = new FbCommand();
                            update.Connection = fbConnection1;
                            fbConnection1.Open();
                            update.CommandText =
                                "UPDATE CLIENTES SET RAZAO_SOCIAL = " + _razao_social + ", " +
                                "NOME_FANTASIA = " + _nome_fantasia + ", " +
                                "IE = " + _ie + ", " +
                                "ENDERECO = " + _endereco + ", " +
                                "NUMERO_CLIENTE = " + _numero + ", " +
                                "COMPLEMENTO_CLIENTE = " + _complemento + ", " +
                                "BAIRRO = " + _bairro + ", " +
                                "COD_CIDADE_CLIENTE = " + _cod_cidade + ", " +
                                "CIDADE = " + _cidade + ", " +
                                "ESTADO = " + _estado + ", " +
                                "CEP_CLIENTE = " + _cep + ", " +
                                "COD_PAIS_CLIENTE = " + _cod_pais + ", " +
                                "PAIS = " + _pais + ", " +
                                "PESSOA_FISICA_CLIENTE = " + pessoa_fisica + ", " +
                                "FONE = " + _fone + " " +
                                "WHERE CNPJ = '" + dr_emit["CNPJ"].ToString() + "'";
                            FbDataAdapter datUpdate = new FbDataAdapter();
                            datUpdate.UpdateCommand = update;
                            datUpdate.UpdateCommand.ExecuteNonQuery();
                            fbConnection1.Close(); 
                        }
                        catch (Exception a)
                        {
                            fbConnection1.Close(); 
                            MessageBox.Show(a.ToString());
                        }
                    }
                    */
                }
                if (!registro_existe)
                {
                    try
                    {

                        FbCommand insert = new FbCommand();
                        insert.Connection = fbConnection1;
                        fbConnection1.Open();
                        insert.CommandText =
                            "INSERT INTO CLIENTES (CNPJ, RAZAO_SOCIAL, NOME_FANTASIA, " +
                            "IE, ENDERECO, NUMERO_CLIENTE, COMPLEMENTO_CLIENTE, " +
                            "BAIRRO, COD_CIDADE_CLIENTE, CIDADE, ESTADO, CEP_CLIENTE, " +
                            "COD_PAIS_CLIENTE, PAIS, FONE, PESSOA_FISICA_CLIENTE) " +
                            "VALUES ('" + cnpj + "'," + _razao_social + "," + _nome_fantasia + "," +
                            _ie + "," + _endereco + "," + _numero + "," + _complemento + "," + _bairro + "," + _cod_cidade + "," +
                            _cidade + "," + _estado + "," + _cep + "," + _cod_pais + "," + _pais + "," + _fone + "," + pessoa_fisica + ")";
                        FbDataAdapter datInsert = new FbDataAdapter();
                        datInsert.InsertCommand = insert;
                        datInsert.InsertCommand.ExecuteNonQuery();
                        fbConnection1.Close(); 
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

        private void verificar_se_cliente_ja_existe_destinatario_html(string cnpj, DataTable ds, string tipo)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT COD_CLIENTE FROM CLIENTES WHERE CNPJ = '" + cnpj + "'";
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.SelectCommand = select;
                DataSet dsTabela = new DataSet();
                datTabela.Fill(dsTabela);
                fbConnection1.Close(); 
                DataRow dr_emit = ds.Rows[0];

                bool registro_existe = false;
                string pessoa_fisica = "null";

                if (cnpj.Length != 14)
                    pessoa_fisica = "'1'";
                //TRATANDO CAMPO VAZIOS
                string _razao_social = "null", _nome_fantasia = "null", _ie = "null", _endereco = "null",
                    _numero = "null", _complemento = "null", _bairro = "null", _cod_cidade = "null", _cidade = "null",
                    _estado = "null", _cep = "null", _cod_pais = "null", _pais = "null", _fone = "null";
                try
                {
                    _razao_social = "'" + dr_emit["Nome/Raz?osocial3"].ToString() + "'";
                }
                catch { }
                try
                {
                    _nome_fantasia = "'" + dr_emit["NomeFantasia1"].ToString() + "'";
                }
                catch { }
                try
                {
                    _ie = "'" + dr_emit["Inscri??oEstadual3"].ToString() + "'";
                }
                catch { }
                try
                {
                    string _end;
                    _end = dr_emit["Endere?o1"].ToString();
                    //_endereco = "'" + dr_emit["Endereco1"].ToString() + "'";
                    if (_end.Length > 50)
                    {
                        _end = _end.Remove(49);
                    }
                    _endereco = "'" + _end + "'";
                }
                catch { }
                try
                {
                    _numero = "'-'";
                }
                catch { }

                try
                {
                    _complemento = "'" + "'";
                }
                catch { }
                try
                {
                    _bairro = "'" + dr_emit["Bairro/Distrito1"].ToString() + "'";
                }
                catch { }
                try
                {
                    _cod_cidade = "'" + dr_emit["Munic?pio1"].ToString().Remove(7) + "'";
                }
                catch { }
                try
                {
                    string mun = dr_emit["Munic?pio1"].ToString();
                    _cidade = "'" + mun.Substring(16, mun.Length - 16) + "'";
                }
                catch { }
                try
                {
                    _estado = "'" + dr_emit["UF3"].ToString() + "'";
                }
                catch { }
                try
                {
                    _cep = "'" + dr_emit["CEP1"].ToString() + "'";
                }
                catch { }
                try
                {
                    _cod_pais = "'" + dr_emit["Pa?s1"].ToString().Remove(4) + "'";
                }
                catch { }
                try
                {
                    string pais = dr_emit["Pa?s1"].ToString();
                    _pais = "'" + pais.Substring(15, pais.Length - 15) + "'";
                }
                catch { }
                try
                {
                    _fone = "'" + dr_emit["TELEFONE1"].ToString() + "'";
                }
                catch { }

                foreach (DataRow dr in dsTabela.Tables[0].Rows)
                {

                    registro_existe = true;
                    /*
                    if (tipo == "DESTINATARIO")
                    {
                        try
                        {
                            FbCommand update = new FbCommand();
                            update.Connection = fbConnection1;
                            fbConnection1.Open();
                            update.CommandText =
                                "UPDATE CLIENTES SET RAZAO_SOCIAL = " + _razao_social + ", " +
                                "NOME_FANTASIA = " + _nome_fantasia + ", " +
                                "IE = " + _ie + ", " +
                                "ENDERECO = " + _endereco + ", " +
                                "NUMERO_CLIENTE = " + _numero + ", " +
                                "COMPLEMENTO_CLIENTE = " + _complemento + ", " +
                                "BAIRRO = " + _bairro + ", " +
                                "COD_CIDADE_CLIENTE = " + _cod_cidade + ", " +
                                "CIDADE = " + _cidade + ", " +
                                "ESTADO = " + _estado + ", " +
                                "CEP_CLIENTE = " + _cep + ", " +
                                "COD_PAIS_CLIENTE = " + _cod_pais + ", " +
                                "PAIS = " + _pais + ", " +
                                "PESSOA_FISICA_CLIENTE = " + pessoa_fisica + ", " +
                                "FONE = " + _fone + " " +
                                "WHERE CNPJ = '" + dr_emit["CNPJ"].ToString() + "'";
                            FbDataAdapter datUpdate = new FbDataAdapter();
                            datUpdate.UpdateCommand = update;
                            datUpdate.UpdateCommand.ExecuteNonQuery();
                            fbConnection1.Close(); 
                        }
                        catch (Exception a)
                        {
                            fbConnection1.Close(); 
                            MessageBox.Show(a.ToString());
                        }
                    }
                    */
                }
                if (!registro_existe)
                {
                    try
                    {
                        string _cnpj = "";

                        FbCommand insert = new FbCommand();
                        insert.Connection = fbConnection1;
                        fbConnection1.Open();
                        insert.CommandText =
                            "INSERT INTO CLIENTES (CNPJ, RAZAO_SOCIAL, NOME_FANTASIA, " +
                            "IE, ENDERECO, NUMERO_CLIENTE, COMPLEMENTO_CLIENTE, " +
                            "BAIRRO, COD_CIDADE_CLIENTE, CIDADE, ESTADO, CEP_CLIENTE, " +
                            "COD_PAIS_CLIENTE, PAIS, FONE, PESSOA_FISICA_CLIENTE) " +
                            "VALUES ('" + cnpj
                            + "'," + _razao_social + "," + _nome_fantasia + "," +
                            _ie + "," + _endereco + "," + _numero + "," + _complemento + "," + _bairro + "," + _cod_cidade + "," +
                            _cidade + "," + _estado + "," + _cep + "," + _cod_pais + "," + _pais + "," + _fone + "," + pessoa_fisica + ")";
                        FbDataAdapter datInsert = new FbDataAdapter();
                        datInsert.InsertCommand = insert;
                        datInsert.InsertCommand.ExecuteNonQuery();
                        fbConnection1.Close(); 
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

        private void verificar_se_cliente_ja_existe(string cnpj, DataTable ds, DataTable end, string tipo)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT COD_CLIENTE FROM CLIENTES WHERE CNPJ = '" + cnpj + "'";
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.SelectCommand = select;
                DataSet dsTabela = new DataSet();
                datTabela.Fill(dsTabela);
                fbConnection1.Close(); 
                DataRow dr_emit = ds.Rows[0];
                DataRow dr_endereco = end.Rows[0];
                bool registro_existe = false;
                string pessoa_fisica = "null";

                if (cnpj.Length != 14)
                    pessoa_fisica = "'1'";
                //TRATANDO CAMPO VAZIOS
                string _razao_social = "null", _nome_fantasia = "null", _ie = "null", _endereco = "null",
                    _numero = "null", _complemento = "null", _bairro = "null", _cod_cidade = "null", _cidade = "null",
                    _estado = "null", _cep = "null", _cod_pais = "null", _pais = "null", _fone = "null";
                try
                {
                    _razao_social = "'" + dr_emit["xNome"].ToString() + "'";
                }
                catch { }
                try
                {
                    _nome_fantasia = "'" + dr_emit["xFant"].ToString() + "'";
                }
                catch { }
                try
                {
                    _ie = "'" + dr_emit["IE"].ToString() + "'";
                }
                catch { }
                try
                {
                    _endereco = "'" + dr_endereco["xLgr"].ToString() + "'";
                }
                catch { }
                try
                {
                    _numero = "'" + dr_endereco["nro"].ToString() + "'";
                }
                catch { }
                try
                {
                    _complemento = "'" + dr_endereco["xCpl"].ToString() + "'";
                }
                catch { }
                try
                {
                    _bairro = "'" + dr_endereco["xBairro"].ToString() + "'";
                }
                catch { }
                try
                {
                    _cod_cidade = "'" + dr_endereco["cMun"].ToString() + "'";
                }
                catch { }
                try
                {
                    _cidade = "'" + dr_endereco["xMun"].ToString() + "'";
                }
                catch { }
                try
                {
                    _estado = "'" + dr_endereco["UF"].ToString() + "'";
                }
                catch { }
                try
                {
                    _cep = "'" + dr_endereco["CEP"].ToString() + "'";
                }
                catch { }
                try
                {
                    _cod_pais = "'" + dr_endereco["cPais"].ToString() + "'";
                }
                catch { }
                try
                {
                    _pais = "'" + dr_endereco["xPais"].ToString() + "'";
                }
                catch { }
                try
                {
                    _fone = "'" + dr_endereco["Fone"].ToString() + "'";
                }
                catch { }

                foreach (DataRow dr in dsTabela.Tables[0].Rows)
                {

                    registro_existe = true;
                    /*
                    if (tipo == "DESTINATARIO")
                    {
                        try
                        {
                            FbCommand update = new FbCommand();
                            update.Connection = fbConnection1;
                            fbConnection1.Open();
                            update.CommandText =
                                "UPDATE CLIENTES SET RAZAO_SOCIAL = " + _razao_social + ", " +
                                "NOME_FANTASIA = " + _nome_fantasia + ", " +
                                "IE = " + _ie + ", " +
                                "ENDERECO = " + _endereco + ", " +
                                "NUMERO_CLIENTE = " + _numero + ", " +
                                "COMPLEMENTO_CLIENTE = " + _complemento + ", " +
                                "BAIRRO = " + _bairro + ", " +
                                "COD_CIDADE_CLIENTE = " + _cod_cidade + ", " +
                                "CIDADE = " + _cidade + ", " +
                                "ESTADO = " + _estado + ", " +
                                "CEP_CLIENTE = " + _cep + ", " +
                                "COD_PAIS_CLIENTE = " + _cod_pais + ", " +
                                "PAIS = " + _pais + ", " +
                                "PESSOA_FISICA_CLIENTE = " + pessoa_fisica + ", " +
                                "FONE = " + _fone + " " +
                                "WHERE CNPJ = '" + dr_emit["CNPJ"].ToString() + "'";
                            FbDataAdapter datUpdate = new FbDataAdapter();
                            datUpdate.UpdateCommand = update;
                            datUpdate.UpdateCommand.ExecuteNonQuery();
                            fbConnection1.Close(); 
                        }
                        catch (Exception a)
                        {
                            fbConnection1.Close(); 
                            MessageBox.Show(a.ToString());
                        }
                    }
                    */
                }
                if (!registro_existe)
                {
                    try
                    {
                        string _cnpj = "";
                        try
                        {
                            _cnpj = dr_emit["CNPJ"].ToString();
                        }
                        catch
                        {
                            _cnpj = dr_emit["CPF"].ToString();
                        }

                        if (_razao_social.Replace("'","").Length > 50)
                            _razao_social = "'" + _razao_social.Replace("'", "").Remove(50) + "'";

                        if (_nome_fantasia.Replace("'", "").Length > 50)
                            _nome_fantasia = "'" + _nome_fantasia.Replace("'", "").Remove(50) + "'";


                        FbCommand insert = new FbCommand();
                        insert.Connection = fbConnection1;
                        fbConnection1.Open();
                        insert.CommandText =
                            "INSERT INTO CLIENTES (CNPJ, RAZAO_SOCIAL, NOME_FANTASIA, " +
                            "IE, ENDERECO, NUMERO_CLIENTE, COMPLEMENTO_CLIENTE, " +
                            "BAIRRO, COD_CIDADE_CLIENTE, CIDADE, ESTADO, CEP_CLIENTE, " +
                            "COD_PAIS_CLIENTE, PAIS, FONE, PESSOA_FISICA_CLIENTE) " +
                            "VALUES ('" + _cnpj + "'," + _razao_social + "," + _nome_fantasia + "," +
                            _ie + "," + _endereco + "," + _numero + "," + _complemento + "," + _bairro + "," + _cod_cidade + "," +
                            _cidade + "," + _estado + "," + _cep + "," + _cod_pais + "," + _pais + "," + _fone + "," + pessoa_fisica + ")";
                        FbDataAdapter datInsert = new FbDataAdapter();
                        datInsert.InsertCommand = insert;
                        datInsert.InsertCommand.ExecuteNonQuery();
                        fbConnection1.Close(); 
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

        private void button18_Click(object sender, EventArgs e)
        {
            inserir_nova_forma_pgto();
        }

        private void inserir_nova_forma_pgto()
        {
            if (tb_valor_total_cte.Text != "")
            {

                form_forma_pgto localiza_forma = new form_forma_pgto();
                try
                {
                    localiza_forma.busca_forma_escolhida = true;
                    localiza_forma.ShowDialog();
                }
                finally
                {
                    localiza_forma.Dispose();
                    apaga_faturas_anteriores();
                    acertar_faturas(localiza_forma.n_parcelas, localiza_forma.prazo_1, localiza_forma.prazo_2, localiza_forma.prazo_3,
                                    localiza_forma.prazo_4, localiza_forma.prazo_5, localiza_forma.prazo_6);
                    selecionar_faturas();

                }

            }
            else
                MessageBox.Show("Calcule o valor da Nota antes de inserir a forma de pagamento.");
        }

        private void selecionar_faturas()
        {
            try
            {
                dsFatura_cte.Clear();
                datFatura_cte.SelectCommand.CommandText =
                "SELECT * FROM FATURA_CTE WHERE COD_CTE_FATURA_CTE = '" + tb_cod.Text + "'";
                fbConnection1.Open();
                datFatura_cte.SelectCommand.Connection = fbConnection1;
                datFatura_cte.SelectCommand.ExecuteNonQuery();
                datFatura_cte.Fill(FATURA_CTE);
                fbConnection1.Close(); 
            }
            catch
            {
                fbConnection1.Close(); 
            }
        }

        private void insere_fatura(string prazo, string data, string valor)
        {
            try
            {
                if (prazo != "null")
                    prazo = "'" + prazo + "'";
                this.datFatura_cte.InsertCommand.CommandText =
                        "INSERT INTO FATURA_CTE (PRAZO_FATURA_CTE, DATA_VENC_FATURA_CTE, " +
                        "VALOR_FATURA_CTE, COD_CTE_FATURA_CTE)" +
                        "VALUES (" + prazo + ",'" + data.Replace("/", ".") + "','" +
                        valor + "','" + tb_cod.Text + "')";
                this.fbConnection1.Open();
                this.datFatura_cte.InsertCommand.Connection = fbConnection1;
                this.datFatura_cte.InsertCommand.ExecuteNonQuery();
                this.fbConnection1.Close(); 
            }
            catch (Exception a)
            {
                fbConnection1.Close(); 
                MessageBox.Show(a.ToString());
            }

        }

        private void acertar_faturas(string n_parcelas, string prazo_1, string prazo_2, string prazo_3,
            string prazo_4, string prazo_5, string prazo_6)
        {

            int numero_parcelas = 0;
            DateTime hoje = DateTime.Now;
            //hoje = DateTime.Now;
            try
            {
                numero_parcelas = Convert.ToInt32(n_parcelas);
            }
            catch
            {
                numero_parcelas = 0;
                MessageBox.Show("Número de parcelas incorreto");
            }
            double valor = 0;
            try
            {
                valor = Convert.ToDouble(tb_valor_total_cte.Text) / numero_parcelas; //buscar_valor_faturado() / numero_parcelas;
            }
            catch { }

            switch (numero_parcelas)
            {

                case 1:
                    {
                        double prazo = Convert.ToDouble(prazo_1);
                        DateTime data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_1, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."));
                        break;
                    }

                case 2:
                    {
                        double prazo = Convert.ToDouble(prazo_1);
                        DateTime data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_1, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."));
                        prazo = Convert.ToDouble(prazo_2);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_2, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."));
                        break;
                    }
                case 3:
                    {
                        double prazo = Convert.ToDouble(prazo_1);
                        DateTime data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_1, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."));
                        prazo = Convert.ToDouble(prazo_2);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_2, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."));
                        prazo = Convert.ToDouble(prazo_3);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_3, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."));
                        break;
                    }
                case 4:
                    {
                        double prazo = Convert.ToDouble(prazo_1);
                        DateTime data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_1, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."));
                        prazo = Convert.ToDouble(prazo_2);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_2, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."));
                        prazo = Convert.ToDouble(prazo_3);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_3, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."));
                        prazo = Convert.ToDouble(prazo_4);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_4, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."));
                        break;
                    }
                case 5:
                    {
                        double prazo = Convert.ToDouble(prazo_1);
                        DateTime data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_1, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."));
                        prazo = Convert.ToDouble(prazo_2);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_2, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."));
                        prazo = Convert.ToDouble(prazo_3);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_3, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."));
                        prazo = Convert.ToDouble(prazo_4);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_4, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."));
                        prazo = Convert.ToDouble(prazo_5);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_5, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."));
                        break;
                    }
                case 6:
                    {
                        double prazo = Convert.ToDouble(prazo_1);
                        DateTime data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_1, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."));
                        prazo = Convert.ToDouble(prazo_2);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_2, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."));
                        prazo = Convert.ToDouble(prazo_3);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_3, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."));
                        prazo = Convert.ToDouble(prazo_4);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_4, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."));
                        prazo = Convert.ToDouble(prazo_5);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_5, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."));
                        prazo = Convert.ToDouble(prazo_6);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_6, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."));
                        break;
                    }



            }

        }

        private void apaga_faturas_anteriores()
        {
            try
            {
                this.datFatura_cte.DeleteCommand.CommandText =
                        "DELETE FROM FATURA_CTE WHERE COD_CTE_FATURA_CTE = '" + tb_n_cte.Text + "'";
                this.fbConnection1.Open();
                this.datFatura_cte.DeleteCommand.Connection = fbConnection1;
                this.datFatura_cte.DeleteCommand.ExecuteNonQuery();
                this.fbConnection1.Close(); 
            }
            catch (Exception a)
            {
                fbConnection1.Close(); 
                MessageBox.Show(a.ToString());
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            atualizar(false);
        }

        private void atualizar(bool pode_salvar)
        {
            if (tb_protocolo_autorizacao.Text == "" || pode_salvar)
            {
                try
                {
                    this.BindingContext[dsCte, "CTE"].EndCurrentEdit();
                    if (dsCte.HasChanges())
                    {
                        fbConnection1.Open();
                        datCte.UpdateCommand = cbCte.GetUpdateCommand();
                        datCte.InsertCommand = cbCte.GetInsertCommand();
                        datCte.DeleteCommand = cbCte.GetDeleteCommand();
                        datCte.Update(dsCte, "CTE");
                        dsCte.AcceptChanges();
                        fbConnection1.Close(); 
                        geradoXml = false;
                    }
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
                        geradoXml = false;
                    }
                    this.BindingContext[dsCte_notas_fiscais, "CTE_NOTAS_FISCAIS"].EndCurrentEdit();
                    if (dsCte_notas_fiscais.HasChanges())
                    {
                        fbConnection1.Open();
                        datCte_notas_fiscais.UpdateCommand = cbCte_notas_fiscais.GetUpdateCommand();
                        datCte_notas_fiscais.InsertCommand = cbCte_notas_fiscais.GetInsertCommand();
                        datCte_notas_fiscais.DeleteCommand = cbCte_notas_fiscais.GetDeleteCommand();
                        datCte_notas_fiscais.Update(dsCte_notas_fiscais, "CTE_NOTAS_FISCAIS");
                        dsCte_notas_fiscais.AcceptChanges();
                        fbConnection1.Close(); 
                        geradoXml = false;
                    }
                    this.BindingContext[dsFatura_cte, "FATURA_CTE"].EndCurrentEdit();
                    if (dsFatura_cte.HasChanges())
                    {
                        fbConnection1.Open();
                        datFatura_cte.UpdateCommand = cbFatura_cte.GetUpdateCommand();
                        datFatura_cte.InsertCommand = cbFatura_cte.GetInsertCommand();
                        datFatura_cte.DeleteCommand = cbFatura_cte.GetDeleteCommand();
                        datFatura_cte.Update(dsFatura_cte, "FATURA_CTE");
                        dsFatura_cte.AcceptChanges();
                        fbConnection1.Close(); 
                        geradoXml = false;
                    }
                }
                catch (Exception a)
                {
                    fbConnection1.Close(); 
                    MessageBox.Show(a.ToString());
                }
            }
            else
            {
                MessageBox.Show("Impossível Salvar. Cte já foi autorizado");
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            form_localiza_cfo cfo = new form_localiza_cfo();
            try
            {
                cfo.ShowDialog();
            }
            finally
            {
                tb_cfop.Text = cfo.cfo_escolhida;
                tb_natureza_operacao.Text = cfo.nome_escolhido;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            form_localiza_cliente cli = new form_localiza_cliente(false, "");
            try
            {
                cli._cadastro = true;
                cli.ShowDialog();
            }
            finally
            {
                tb_remetente_nome.Text = cli.cliente_escolhido;
                tb_remetente_cnpj.Text = cli.cnpj_escolhido;
                // tb_expedidor_nome.Text = cli.cliente_escolhido;
                //tb_expedidor_cnpj.Text = cli.cnpj_escolhido;
                tb_tomador_nome.Text = cli.cliente_escolhido;
                tb_tomador_cnpj.Text = cli.cnpj_escolhido;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            form_localiza_cliente cli = new form_localiza_cliente(false, "");
            try
            {
                cli._cadastro = true;
                cli.ShowDialog();
            }
            finally
            {
                tb_destinatario_nome.Text = cli.cliente_escolhido;
                tb_destinatario_cnpj.Text = cli.cnpj_escolhido;
                //tb_recebedor_nome.Text = cli.cliente_escolhido;
                //tb_recebedor_cnpj.Text = cli.cnpj_escolhido;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            form_localiza_cliente cli = new form_localiza_cliente(false, "");
            try
            {
                cli._cadastro = true;
                cli.ShowDialog();
            }
            finally
            {
                tb_expedidor_nome.Text = cli.cliente_escolhido;
                tb_expedidor_cnpj.Text = cli.cnpj_escolhido;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            form_localiza_cliente cli = new form_localiza_cliente(false, "");
            try
            {
                cli._cadastro = true;
                cli.ShowDialog();
            }
            finally
            {
                tb_recebedor_nome.Text = cli.cliente_escolhido;
                tb_recebedor_cnpj.Text = cli.cnpj_escolhido;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            form_localiza_cliente cli = new form_localiza_cliente(false, "");
            try
            {
                cli._cadastro = true;
                cli.ShowDialog();
            }
            finally
            {
                tb_tomador_nome.Text = cli.cliente_escolhido;
                tb_tomador_cnpj.Text = cli.cnpj_escolhido;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            form_pesquisa_cte pesquisa = new form_pesquisa_cte();
            try
            {
                pesquisa.busca = true;
                pesquisa._cnpj_emitente = cnpj_empresa_emissora;
                pesquisa.empresa_emissora = empresa_emissora;
                pesquisa.cod_usuario = funcionario_emissor;
                pesquisa.ShowDialog();
            }
            finally
            {
                if (pesquisa._n_cte != "")
                    selecionar_cte(pesquisa._n_cte, pesquisa._cnpj_emitente);
                if (tb_func.Text.Trim() != "")
                {
                    if (funcionario_emissor != tb_func.Text && funcionario_emissor != "1" && funcionario_emissor != "8")
                    {
                        desabilitaBotoes(this);
                    }
                    else
                    {
                        if (button4.Enabled == false)
                        {
                            abilitaBotoes(this);
                        }
                    }
                }
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            importar_chave();
        }

        private void importar_chave()
        {
            try
            {
                string razao_social_empresa = "", nome_fantasia_empresa = "", cnpj_empresa = "", ie_empresa = "", im_empresa = "", cnae_empresa = "", endereco_empresa = "", n_endereco_empresa = "",
                           complemento_empresa = "", bairro_empresa = "", cidade_empresa = "", estado_empresa = "", cep_empresa = "", telefone_empresa = "", cod_cidade_empresa = "", pais_empresa = "",
                           cod_pais_empresa = "", licenca_dll_nfe_empresa = "", nome_certificado_nfe_empresa = "", assunto_nfe_email_empresa = "", smtp_nfe_empresa = "", email_nfe_empresa = "",
                           senha_email_nfe_empresa = "", logotipo_empresa = "", proxy_empresa = "", usuario_proxy_empresa = "", senha_proxy_empresa = "", crt_empresa = "", rntrc_empresa = "", serie_nf_empresa = "",
                        serie_cte_empresa = "", porta_email = "";
                detectar_dados_empresa(tb_cnpj_emitente.Text, out razao_social_empresa, out nome_fantasia_empresa, out cnpj_empresa, out ie_empresa, out im_empresa, out cnae_empresa, out endereco_empresa, out n_endereco_empresa,
                        out complemento_empresa, out bairro_empresa, out cidade_empresa, out estado_empresa, out cep_empresa, out telefone_empresa, out cod_cidade_empresa, out pais_empresa,
                        out cod_pais_empresa, out licenca_dll_nfe_empresa, out nome_certificado_nfe_empresa, out assunto_nfe_email_empresa, out smtp_nfe_empresa, out email_nfe_empresa,
                        out senha_email_nfe_empresa, out logotipo_empresa, out proxy_empresa, out usuario_proxy_empresa, out senha_proxy_empresa, out crt_empresa, out rntrc_empresa, out serie_nf_empresa, out serie_cte_empresa, out porta_email);

                string proxy = proxy_empresa;
                string usuario = usuario_proxy_empresa;
                string senha = senha_proxy_empresa;
                string licenca = licenca_dll_nfe_empresa;
                string nomeCertificado = nome_certificado_nfe_empresa;
                string xml;
                string msgResultado;
                int resultado;
                xml = util2.DownloadNFWeb(nomeCertificado, tb_chave_a_buscar.Text, cnpj_empresa, out resultado, out msgResultado, "");

                if (resultado == 8000)
                {
                    string nome_arquivo = "NFE" + tb_chave_a_buscar.Text + "_upload.xml";
                    criar_arquivo_xml(nome_arquivo);
                    string caminho = @"c:\\evolucao\\NFE\buscadas\";
                    FileInfo t = new FileInfo(caminho + nome_arquivo);
                    using (StreamWriter texto = t.CreateText())
                    {
                        texto.WriteLine(xml);
                    }

                    buscar_dados(caminho + nome_arquivo);

                }
                else
                {
                    MessageBox.Show("Erro ao buscar chave: " + resultado.ToString());
                    //classe_ler_tabela_html html = new classe_ler_tabela_html();
                    // html.buscar_html("http://www.bmfbovespa.com.br/indices/ResumoCarteiraTeorica.aspx?Indice=IBOVESPA&idioma=pt-br");

                }
            }
            catch (Exception a)
            {
                fbConnection1.Close(); 
                MessageBox.Show(a.ToString());
            }
        }

        private void detectar_dados_empresa(string cnpj, out string razao_social_empresa, out string nome_fantasia_empresa, out string cnpj_empresa, out string ie_empresa, out string im_empresa, out string cnae_empresa, out string endereco_empresa, out string n_endereco_empresa,
            out string complemento_empresa, out string bairro_empresa, out string cidade_empresa, out string estado_empresa, out string cep_empresa, out string telefone_empresa, out string cod_cidade_empresa, out string pais_empresa,
            out string cod_pais_empresa, out string licenca_dll_nfe_empresa, out string nome_certificado_nfe_empresa, out string assunto_nfe_email_empresa, out string smtp_nfe_empresa, out string email_nfe_empresa,
            out string senha_email_nfe_empresa, out string logotipo_empresa, out string proxy_empresa, out string usuario_proxy_empresa, out string senha_proxy_empresa, out string crt_empresa, out string rntrc_empresa, out string serie_nf_empresa, out string serie_cte_empresa, out string porta_email)
        {
            razao_social_empresa = ""; nome_fantasia_empresa = ""; cnpj_empresa = ""; ie_empresa = ""; im_empresa = ""; cnae_empresa = ""; endereco_empresa = ""; n_endereco_empresa = "";
            complemento_empresa = ""; bairro_empresa = ""; cidade_empresa = ""; estado_empresa = ""; cep_empresa = ""; telefone_empresa = ""; cod_cidade_empresa = ""; pais_empresa = "";
            cod_pais_empresa = ""; licenca_dll_nfe_empresa = ""; nome_certificado_nfe_empresa = ""; assunto_nfe_email_empresa = ""; smtp_nfe_empresa = ""; email_nfe_empresa = "";
            senha_email_nfe_empresa = ""; logotipo_empresa = ""; proxy_empresa = ""; usuario_proxy_empresa = "";
            senha_proxy_empresa = ""; crt_empresa = ""; rntrc_empresa = ""; serie_nf_empresa = ""; serie_cte_empresa = ""; porta_email = "";
            try
            {
                FbCommand comando = new FbCommand();
                comando.Connection = fbConnection1;
                comando.CommandText = "SELECT * FROM EMPRESA WHERE CNPJ_EMPRESA = '" + cnpj + "'";
                DataSet empresa = new DataSet();
                fbConnection1.Open();
                FbDataAdapter datEmpresa = new FbDataAdapter();
                datEmpresa.SelectCommand = comando;
                datEmpresa.Fill(empresa);
                fbConnection1.Close(); 
                foreach (DataRow dr in empresa.Tables[0].Rows)
                {
                    razao_social_empresa = dr["RAZAO_SOCIAL_EMPRESA"].ToString();
                    nome_fantasia_empresa = dr["NOME_FANTASIA_EMPRESA"].ToString();
                    cnpj_empresa = dr["CNPJ_EMPRESA"].ToString().Replace(".", "").Replace("/", "").Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
                    ie_empresa = dr["IE_EMPRESA"].ToString().Replace(".", "").Replace("/", "").Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
                    im_empresa = dr["IM_EMPRESA"].ToString().Replace(".", "").Replace("/", "").Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
                    cnae_empresa = dr["CNAE_EMPRESA"].ToString().Replace(".", "").Replace("/", "").Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
                    endereco_empresa = dr["ENDERECO_EMPRESA"].ToString();
                    n_endereco_empresa = dr["N_ENDERECO_EMPRESA"].ToString();
                    complemento_empresa = dr["COMPLEMENTO_EMPRESA"].ToString();
                    bairro_empresa = dr["BAIRRO_EMPRESA"].ToString();
                    cidade_empresa = dr["CIDADE_EMPRESA"].ToString();
                    estado_empresa = dr["ESTADO_EMPRESA"].ToString();
                    cep_empresa = dr["CEP_EMPRESA"].ToString().Replace(".", "").Replace("/", "").Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
                    telefone_empresa = dr["TELEFONE_EMPRESA"].ToString().Replace(".", "").Replace("/", "").Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
                    cod_cidade_empresa = dr["COD_CIDADE_EMPRESA"].ToString();
                    pais_empresa = dr["PAIS_EMPRESA"].ToString();
                    cod_cidade_empresa = dr["COD_CIDADE_EMPRESA"].ToString();
                    licenca_dll_nfe_empresa = dr["LICENCA_DLL_CTE_EMPRESA"].ToString(); //POR SER CTE
                    nome_certificado_nfe_empresa = dr["NOME_CERTIFICADO_NFE_EMPRESA"].ToString();
                    assunto_nfe_email_empresa = dr["ASSUNTO_NFE_EMAIL_EMPRESA"].ToString();
                    smtp_nfe_empresa = dr["SMTP_NFE_EMPRESA"].ToString();
                    email_nfe_empresa = dr["EMAIL_NFE_EMPRESA"].ToString();
                    senha_email_nfe_empresa = dr["SENHA_EMAIL_NFE_EMPRESA"].ToString();
                    try
                    {
                        logotipo_empresa = dr["LOGOTIPO_EMPRESA"].ToString();
                    }
                    catch { }
                    proxy_empresa = dr["PROXY_EMPRESA"].ToString();
                    usuario_proxy_empresa = dr["USUARIO_PROXY_EMPRESA"].ToString();
                    senha_proxy_empresa = dr["SENHA_PROXY_EMPRESA"].ToString();
                    crt_empresa = dr["CRT_EMPRESA"].ToString();
                    rntrc_empresa = dr["rntrc_empresa"].ToString();
                    serie_cte_empresa = dr["SERIE_CTE_EMPRESA"].ToString();
                    serie_nf_empresa = dr["SERIE_NF_EMPRESA"].ToString();
                    porta_email = dr["PORTA_EMAIL_EMP"].ToString();
                }

            }
            catch
            {
                fbConnection1.Close(); 
                MessageBox.Show("Erro ao buscar dados da empresa");
            }
        }

        public Boolean criar_arquivo_xml(String Name)
        {
            StreamWriter Arquivo;
            try
            {
                Arquivo = new StreamWriter(@"c:\\evolucao\\NFE\BUSCADAS\" + Name);
                Arquivo.Close();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void tb_valor_mercado_TextChanged(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            form_nova_nf_cte nf = new form_nova_nf_cte();
            try
            {
                nf.cod_cte = tb_cod.Text;
                nf.ShowDialog();
            }
            finally
            {
                selecionar_nfs_do_cte();
                somar_valores_nf();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            composicao_preco(false);
        }

        private void composicao_preco(bool automatico)
        {
            atualizar(false);
            form_composicao_frete frete = new form_composicao_frete();
            frete.cnpj_emitente = cnpj_empresa_emissora;
            frete.razao_social_empresa = empresa_emissora;
            double peso = 0;
            try { peso = Convert.ToDouble(tb_peso.Text); }
            catch { }
            frete.peso = peso;
            frete.remetente = tb_remetente_nome.Text;
            frete.calcular_automatico = automatico;
            if (automatico)
                frete.Opacity = 0;
            frete.cod_cte = tb_cod.Text;
            frete.nota_fiscal = dgvCte_notas_fiscais.Rows[0].Cells[0].Value.ToString();
            frete.data_emissao_nf = dgvCte_notas_fiscais.Rows[0].Cells["col_data_emissao_nf"].Value.ToString();
            try
            {
                frete.ShowDialog();
            }
            finally
            {
                selecionar_itens_composicao();
                tb_subtotal.Text = frete.sub_total.ToString("n2");
                tb_aliquota.Text = frete.aliquota.ToString("n2");
                tb_base_calculo.Text = frete.valor_total.ToString("n2");
                tb_valor_total_cte.Text = frete.valor_total.ToString("n2");
                tb_valor_icms.Text = frete.valor_icms.ToString("n2");
                buscar_observacoes(tb_remetente_cnpj.Text);
                buscar_observacoes(tb_destinatario_cnpj.Text);
                buscar_observacoes(tb_expedidor_cnpj.Text);
                buscar_observacoes(tb_recebedor_cnpj.Text);
            }
        }

        private void buscar_observacoes(string cnpj)
        {
            string observacoes = "";

            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT OBSERVACOES_CLIENTE FROM CLIENTES WHERE CNPJ = '" + cnpj + "'";
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.SelectCommand = select;
                DataSet dsTabela = new DataSet();
                datTabela.Fill(dsTabela);
                fbConnection1.Close(); 
                foreach (DataRow dr in dsTabela.Tables[0].Rows)
                {
                    observacoes = dr[0].ToString();
                }
            }
            catch (Exception a)
            {
                fbConnection1.Close(); 
                MessageBox.Show(a.ToString());
            }
            if (observacoes != "")
                tb_observacoes.Text = tb_observacoes.Text + " " + observacoes;
        }

        private void selecionar_itens_composicao()
        {
            try
            {
                dsCte_frete_composicao.Clear();

                datCte_frete_composicao.SelectCommand.CommandText =
                "SELECT * FROM CTE_FRETE_COMPOSICAO WHERE COD_CTE_CFC = '" + tb_cod.Text + "'";
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

        private void textBox24_TextChanged(object sender, EventArgs e)
        {

        }

        private string transforma_decimal(int qtde_depois_virg, string numero, int n_caracteres)
        {
            int tamanho = numero.Length;
            int pos_virgula = 0;
            int qtde_decimais = 0;
            if (numero.Contains(","))
            {
                while (numero[pos_virgula].ToString() != ",")
                {
                    pos_virgula++;
                }
                pos_virgula++; //por que começa com 0
                qtde_decimais = tamanho - pos_virgula;
                if (qtde_decimais > qtde_depois_virg)
                {
                    numero = Convert.ToDouble(numero).ToString("n" + qtde_depois_virg.ToString());
                    numero = numero.Replace(".", "");
                }
                for (int i = qtde_decimais; i < qtde_depois_virg; i++)
                {
                    numero = numero + "0";
                }
            }
            else
            {
                if (numero == "")
                    numero = "0";
                numero = numero + ",";
                for (int i = qtde_decimais; i < qtde_depois_virg; i++)
                {
                    numero = numero + "0";
                }
            }
            return numero.Replace(",", ".");
        }

        public void criar_codigo_barras()
        {
            try
            {
                SaveFileDialog file = new SaveFileDialog();
                file.FileName = @"c:\\evolucao\\cte\COD_BARRAS\bar.jpg";
                BarcodeLib.Barcode bar = new BarcodeLib.Barcode();
                bar.Encode(BarcodeLib.TYPE.CODE128, tb_chave_acesso_nfe.Text);
                pb_codigo.Image = bar.Encode(BarcodeLib.TYPE.CODE128, tb_chave_acesso_nfe.Text, 300, 150);
                bar.SaveImage(file.FileName, BarcodeLib.SaveTypes.JPG);
            }
            catch
            {
                MessageBox.Show("Erro ao gerar o código de barras");
            }
        }

        private void bt_gerarXML_Click(object sender, EventArgs e)
        {
            gerarXml(true);
        }

        private void gerarXml(bool mostrar)
        {
            ok = true;
            if (verificar_se_existe_2_registros_iguais(tb_n_cte.Text, cnpj_empresa_emissora))
            {
                MessageBox.Show("Esse registro será excluído pois já existe um com o mesmo número");
                excluir_por_numero(tb_n_cte.Text, cnpj_empresa_emissora);
            }
            else
            {
                verificar_frete();
                double valorTotalTrib = 0;
                double porcTotalTrib = 0;
                if (cnpj_empresa_emissora == "06112790000183")
                {
                    porcTotalTrib = 13.99;
                }
                else
                {
                    porcTotalTrib = 35.65;
                }
                valorTotalTrib = (Convert.ToDouble(tb_valor_total_cte.Text) * porcTotalTrib) / 100;
                try
                {
                    //dados da empresa
                    string razao_social_empresa = "", nome_fantasia_empresa = "", cnpj_empresa = "", ie_empresa = "", im_empresa = "", cnae_empresa = "", endereco_empresa = "", n_endereco_empresa = "",
                       complemento_empresa = "", bairro_empresa = "", cidade_empresa = "", estado_empresa = "", cep_empresa = "", telefone_empresa = "", cod_cidade_empresa = "", pais_empresa = "",
                       cod_pais_empresa = "", licenca_dll_nfe_empresa = "", nome_certificado_nfe_empresa = "", assunto_nfe_email_empresa = "", smtp_nfe_empresa = "", email_nfe_empresa = "",
                       senha_email_nfe_empresa = "", logotipo_empresa = "", proxy_empresa = "", usuario_proxy_empresa = "", senha_proxy_empresa = "", crt_empresa = "", rntrc_empresa = "", serie_nf_empresa = "",
                    serie_cte_empresa = "", porta_email = "";
                    detectar_dados_empresa(tb_cnpj_emitente.Text, out razao_social_empresa, out nome_fantasia_empresa, out cnpj_empresa, out ie_empresa, out im_empresa, out cnae_empresa, out endereco_empresa, out n_endereco_empresa,
                            out complemento_empresa, out bairro_empresa, out cidade_empresa, out estado_empresa, out cep_empresa, out telefone_empresa, out cod_cidade_empresa, out pais_empresa,
                            out cod_pais_empresa, out licenca_dll_nfe_empresa, out nome_certificado_nfe_empresa, out assunto_nfe_email_empresa, out smtp_nfe_empresa, out email_nfe_empresa,
                            out senha_email_nfe_empresa, out logotipo_empresa, out proxy_empresa, out usuario_proxy_empresa, out senha_proxy_empresa, out crt_empresa, out rntrc_empresa, out serie_nf_empresa, out serie_cte_empresa, out porta_email);


                    //variaveis globais da funcao
                    int cod_seguranca = 13;
                    int digito_verificador_chave_acesso = 1;
                    int tipo_ambiente = 1; //1 - PRODUÇÃO 2- HOMOLOGACAO
                    int tipo_cte = 0;
                    int tipo_servico = 0;
                    int retira = 1;
                    string inf_retira = "1";
                    if (cbTeste.Checked)
                        tipo_ambiente = 2;
                    int serie_cte = Convert.ToInt32(serie_cte_empresa);

                    //DADOS EXPEDIDOR
                    string _expedidor_cnpj, _expedidor_cpf, _expedidor_ie, _expedidor_xNome, _expedidor_xFant_Opc, _expedidor_fone_Opc,
                        _expedidor_xLgr, _expedidor_nro, _expedidor_xCpl_Opc, _expedidor_xBairro, _expedidor_cMun, _expedidor_xMun,
                        _expedidor_CEP_Opc, _expedidor_UF, _expedidor_cPais_Opc, _expedidor_xPais_Opc, _expedidor_email_Opc;
                    buscar_dados_cliente(tb_expedidor_cnpj.Text, out _expedidor_cnpj, out _expedidor_cpf, out _expedidor_ie, out _expedidor_xNome, out _expedidor_xFant_Opc, out _expedidor_fone_Opc, out
                _expedidor_xLgr, out _expedidor_nro, out _expedidor_xCpl_Opc, out _expedidor_xBairro, out _expedidor_cMun, out _expedidor_xMun, out
                _expedidor_CEP_Opc, out _expedidor_UF, out _expedidor_cPais_Opc, out _expedidor_xPais_Opc, out _expedidor_email_Opc);

                    //DADOS RECEBEDOR
                    string _recebedor_cnpj, _recebedor_cpf, _recebedor_ie, _recebedor_xNome, _recebedor_xFant_Opc, _recebedor_fone_Opc,
                       _recebedor_xLgr, _recebedor_nro, _recebedor_xCpl_Opc, _recebedor_xBairro, _recebedor_cMun, _recebedor_xMun,
                       _recebedor_CEP_Opc, _recebedor_UF, _recebedor_cPais_Opc, _recebedor_xPais_Opc, _recebedor_email_Opc;
                    buscar_dados_cliente(tb_recebedor_cnpj.Text, out _recebedor_cnpj, out _recebedor_cpf, out _recebedor_ie, out _recebedor_xNome, out _recebedor_xFant_Opc, out _recebedor_fone_Opc, out
                _recebedor_xLgr, out _recebedor_nro, out _recebedor_xCpl_Opc, out _recebedor_xBairro, out _recebedor_cMun, out _recebedor_xMun, out
                _recebedor_CEP_Opc, out _recebedor_UF, out _recebedor_cPais_Opc, out _recebedor_xPais_Opc, out _recebedor_email_Opc);

                    //DADOS REMETENTE
                    string _remetente_cnpj, _remetente_cpf, _remetente_ie, _remetente_xNome, _remetente_xFant_Opc, _remetente_fone_Opc,
                      _remetente_xLgr, _remetente_nro, _remetente_xCpl_Opc, _remetente_xBairro, _remetente_cMun, _remetente_xMun,
                      _remetente_CEP_Opc, _remetente_UF, _remetente_cPais_Opc, _remetente_xPais_Opc, _remetente_email_Opc;
                    buscar_dados_cliente(tb_remetente_cnpj.Text, out _remetente_cnpj, out _remetente_cpf, out _remetente_ie, out _remetente_xNome, out _remetente_xFant_Opc, out _remetente_fone_Opc, out
                _remetente_xLgr, out _remetente_nro, out _remetente_xCpl_Opc, out _remetente_xBairro, out _remetente_cMun, out _remetente_xMun, out
                _remetente_CEP_Opc, out _remetente_UF, out _remetente_cPais_Opc, out _remetente_xPais_Opc, out _remetente_email_Opc);

                    //DADOS DESTINATARIO
                    string _destinatario_cnpj, _destinatario_cpf, _destinatario_ie, _destinatario_xNome, _destinatario_xFant_Opc, _destinatario_fone_Opc,
                      _destinatario_xLgr, _destinatario_nro, _destinatario_xCpl_Opc, _destinatario_xBairro, _destinatario_cMun, _destinatario_xMun,
                      _destinatario_CEP_Opc, _destinatario_UF, _destinatario_cPais_Opc, _destinatario_xPais_Opc, _destinatario_email_Opc;
                    buscar_dados_cliente(tb_destinatario_cnpj.Text, out _destinatario_cnpj, out _destinatario_cpf, out _destinatario_ie, out _destinatario_xNome, out _destinatario_xFant_Opc, out _destinatario_fone_Opc, out
                _destinatario_xLgr, out _destinatario_nro, out _destinatario_xCpl_Opc, out _destinatario_xBairro, out _destinatario_cMun, out _destinatario_xMun, out
                _destinatario_CEP_Opc, out _destinatario_UF, out _destinatario_cPais_Opc, out _destinatario_xPais_Opc, out _destinatario_email_Opc);

                    //DADOS TOMADOR
                    string _tomador_cnpj, _tomador_cpf, _tomador_ie, _tomador_xNome, _tomador_xFant_Opc, _tomador_fone_Opc,
                      _tomador_xLgr, _tomador_nro, _tomador_xCpl_Opc, _tomador_xBairro, _tomador_cMun, _tomador_xMun,
                      _tomador_CEP_Opc, _tomador_UF, _tomador_cPais_Opc, _tomador_xPais_Opc, _tomador_email_Opc;
                    buscar_dados_cliente(tb_tomador_cnpj.Text, out _tomador_cnpj, out _tomador_cpf, out _tomador_ie, out _tomador_xNome, out _tomador_xFant_Opc, out _tomador_fone_Opc, out
                _tomador_xLgr, out _tomador_nro, out _tomador_xCpl_Opc, out _tomador_xBairro, out _tomador_cMun, out _tomador_xMun, out
                _tomador_CEP_Opc, out _tomador_UF, out _tomador_cPais_Opc, out _tomador_xPais_Opc, out _tomador_email_Opc);

                    int indIEToma = 1;

                    if (_tomador_cpf != "")
                        indIEToma = 9;

                    if (_tomador_ie == "ISENTO" || _tomador_ie == "")
                    {
                        indIEToma = 9;
                        _tomador_ie = "";
                    }

                    //VERIFICAR DEPOIS SE EXISTE ESSA POSSIBILIDADE DO TOMADOR SER DIFERENTE DO REMETENTE, DESTINATARIO, EXPEDIDOR E RECEBEDOR
                    int tipo_tomador = 4;
                    if (tb_tomador_cnpj.Text == tb_remetente_cnpj.Text)
                        tipo_tomador = 0;
                    if (tb_tomador_cnpj.Text == tb_expedidor_cnpj.Text)
                        tipo_tomador = 1;
                    if (tb_tomador_cnpj.Text == tb_recebedor_cnpj.Text)
                        tipo_tomador = 2;
                    if (tb_tomador_cnpj.Text == tb_destinatario_cnpj.Text)
                        tipo_tomador = 3;

                    string tomador = util.tomador300(tipo_tomador, _tomador_cnpj, _tomador_cpf, _tomador_ie, _tomador_xNome, _tomador_xFant_Opc,
                             _tomador_fone_Opc, _tomador_xLgr, _tomador_nro, _tomador_xCpl_Opc, _tomador_xBairro, _tomador_cMun, _tomador_xMun,
                             _recebedor_CEP_Opc, _tomador_UF, _tomador_cPais_Opc, _tomador_xPais_Opc, _tomador_email_Opc);

                    //chave
                    string _msgResultado, _cCt, _cDv, _chaveCte;
                    //   string tpEmis = "1";
                    string tpEmis = "1";
                    int busca_chave = util.CriaChaveCTeNovo("35", Convert.ToDateTime(tb_data_emissao.Text).ToString("yy"),
                        Convert.ToDateTime(tb_data_emissao.Text).ToString("MM"), tb_cnpj_emitente.Text, "57", "0", tb_n_cte.Text, "1",
                        cod_seguranca.ToString(), out _msgResultado, out _cCt, out _cDv, out _chaveCte);
                    if (busca_chave == 0)
                    {
                        tb_chave_acesso_nfe.Text = _chaveCte;
                        //GERAR IDENTIFICAÇÃO
                        string cod_mun_inicio = "", cidade_inicio = "", uf_inicio = "";
                        string cod_mun_fim = "", cidade_fim = "", uf_fim = "";

                        if (tb_origem.Text == "" && tb_uf_origem.Text == "" && tb_cod_origem.Text == "")
                        {
                            if (tb_expedidor_cnpj.Text != "")
                            {
                                cod_mun_inicio = _expedidor_cMun;
                                cidade_inicio = _expedidor_xMun;
                                uf_inicio = _expedidor_UF;
                            }
                            else
                            {
                                cod_mun_inicio = _remetente_cMun;
                                cidade_inicio = _remetente_xMun;
                                uf_inicio = _remetente_UF;
                            }
                            tb_origem.Text = cidade_inicio;
                            tb_cod_origem.Text = cod_mun_inicio;
                            tb_uf_origem.Text = uf_inicio;
                            if (tb_origem.Text == "EMBU DAS ARTES" && _tomador_cnpj == "61116331000186")
                                tb_origem.Text = "SAO PAULO";

                        }
                        else
                        {
                            cidade_inicio = tb_origem.Text;
                            cod_mun_inicio = tb_cod_origem.Text;
                            uf_inicio = tb_uf_origem.Text;
                        }
                        if (tb_destino.Text == "" && tb_uf_destino.Text == "" && tb_cod_destino.Text == "")
                        {
                            if (tb_recebedor_cnpj.Text != "")
                            {
                                cod_mun_fim = _recebedor_cMun;
                                cidade_fim = _recebedor_xMun;
                                uf_fim = _recebedor_UF;
                            }
                            else
                            {
                                cod_mun_fim = _destinatario_cMun;
                                cidade_fim = _destinatario_xMun;
                                uf_fim = _destinatario_UF;
                            }
                            tb_destino.Text = cidade_fim;
                            tb_uf_destino.Text = uf_fim;
                            tb_cod_destino.Text = cod_mun_fim;

                            if (tb_destino.Text == "SAO PAULO" && _tomador_cnpj == "61116331000186")
                                tb_destino.Text = "SAO JOSE DOS CAMPOS";
                        }
                        else
                        {
                            cidade_fim = tb_destino.Text;
                            uf_fim = tb_uf_destino.Text;
                            cod_mun_fim = tb_cod_destino.Text;
                        }
                        if (tb_destino.Text == "" || tb_uf_destino.Text == "" || tb_cod_destino.Text == "" )
                        {
                            MessageBox.Show("Faltam informações em destino");
                            ok = false;
                        }
                        else if (tb_origem.Text == "" || tb_uf_origem.Text == "" || tb_cod_origem.Text == "")
                        {
                            MessageBox.Show("Faltam informações em origem");
                            ok = false;
                        }
                        else if (uf_inicio.ToUpper() == uf_fim.ToUpper())
                        {
                            if (tb_cfop.Text.Substring(0, 1) != "5")
                            {
                                MessageBox.Show("Origem e Destino estão no mesmo estado, o CFOP deveria iniciar com 5");
                                ok = false;
                            }
                        }
                        else
                        {
                            if (tb_cfop.Text == "")
                            {
                                if (uf_inicio.ToUpper() != uf_fim.ToUpper())
                                {

                                    //tb_cfop.Text = "6353";
                                    if (tb_cfop.Text.Substring(0, 1) == "5")
                                    {
                                        MessageBox.Show("Origem e Destino estão em estados diferentes, o CFOP não deveria iniciar com 5");
                                        ok = false;
                                    }
                                }

                                else if (uf_inicio.ToUpper() != "SP")
                                {
                                    if (tb_cfop.Text == "6932")
                                    {
                                        MessageBox.Show("Quando o estado de origem for diferente de SP, o CFOP deve ser 6932");
                                        ok = false;
                                    }

                                }
                            }
                        }
                        if (ok)
                        {
                            tb_tipo.Text = "Normal";
                            tipo_servico = 0;
                            string indGlobalizado = "";
                            if (cbPortaria_121.Checked)
                            {
                                indGlobalizado = "1";
                            }
                            string _dhEmi = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:sszz:00");

                            string identificacao = util.identificador300(35, Convert.ToInt32(_cCt), tb_cfop.Text, tb_natureza_operacao.Text,
                                57, Convert.ToInt16(serie_cte_empresa), Convert.ToInt32(tb_n_cte.Text), _dhEmi, 1, 1, Convert.ToInt32(_cDv), tipo_ambiente, tipo_cte, 0,
                                "3.00", indGlobalizado, cod_cidade_empresa, cidade_empresa, estado_empresa, "01", tipo_servico, cod_mun_inicio, cidade_inicio,
                                uf_inicio, cod_mun_fim, cidade_fim, uf_fim, retira, inf_retira, indIEToma, tomador, "", "");

                            string xTextoObs = "O valor aproximado de tributos incidentes sobre o preço deste serviço é de R$ " + valorTotalTrib.ToString("n2");
                            string obsContribuinte = util.obsCont("LEI DA TRANSPARENCIA", xTextoObs);

                            tb_transparencia.Text = xTextoObs;
                            //tb_func.Text = funcionario_emissor;

                            //TOMADOR DO SERVIÇO
                            //VERIFICAR NECESSIDADE

                            //DADOS COMPLEMENTARES
                            string dados_complementares = util.compl("", "", funcionario_emissor, "", "", cidade_inicio, cidade_fim,
                                retirar_caracteres(tb_observacoes.Text), obsContribuinte, "");

                            string xNome = razao_social_empresa;
                           
                            //DADOS DO EMITENTE
                            string emitente = util.emitente300(tb_cnpj_emitente.Text, ie_empresa, "", xNome, nome_fantasia_empresa, endereco_empresa,
                                 n_endereco_empresa, complemento_empresa, bairro_empresa, cod_cidade_empresa, cidade_empresa, cep_empresa, estado_empresa,
                                 telefone_empresa);

                            //DADOS REMETENTE
                            string notas = "";
                            if (cb_outros.Checked == true)
                            {
                                notas = util.infOutros_2G("00", "OUTROS", "", DateTime.Now,0, DateTime.Now.AddDays(1), "");
                            }
                            else
                            {
                                for (int i = 0; i < dgvCte_notas_fiscais.RowCount; i++)
                                {
                                    if (dgvCte_notas_fiscais.Rows[i].Cells["col_chave_nfe"].Value.ToString() != "")
                                        notas = notas + util.infNFe_2G(dgvCte_notas_fiscais.Rows[i].Cells["col_chave_nfe"].Value.ToString(), "", DateTime.MinValue, "");
                                    else
                                        notas = notas + util.infNF_2G("", "",
                                            dgvCte_notas_fiscais.Rows[i].Cells["col_modelo_nf"].Value.ToString(),
                                            dgvCte_notas_fiscais.Rows[i].Cells["col_serie_nf"].Value.ToString(),
                                            dgvCte_notas_fiscais.Rows[i].Cells["col_n_nfe"].Value.ToString(),
                                            Convert.ToDateTime(dgvCte_notas_fiscais.Rows[i].Cells["col_data_emissao_nf"].Value.ToString()),
                                            Convert.ToDouble(dgvCte_notas_fiscais.Rows[i].Cells["col_valor_bc_nf"].Value.ToString()),
                                            Convert.ToDouble(dgvCte_notas_fiscais.Rows[i].Cells["col_valor_icms_nf"].Value.ToString()),
                                            Convert.ToDouble(dgvCte_notas_fiscais.Rows[i].Cells["col_valor_bc_st_nf"].Value.ToString()),
                                            Convert.ToDouble(dgvCte_notas_fiscais.Rows[i].Cells["col_valor_icms_st_nf"].Value.ToString()),
                                            Convert.ToDouble(dgvCte_notas_fiscais.Rows[i].Cells["col_valor_produtos_nf"].Value.ToString()),
                                            Convert.ToDouble(dgvCte_notas_fiscais.Rows[i].Cells["col_valor_nfe"].Value.ToString()),
                                            dgvCte_notas_fiscais.Rows[i].Cells["col_cfop_nf"].Value.ToString(),
                                            Convert.ToDouble(dgvCte_notas_fiscais.Rows[i].Cells["col_peso_nfe"].Value.ToString()), "", DateTime.MinValue, "");
                                }
                            }
                            //DADOS REMETENTE
                            string remetente = util.remetente300(_remetente_cnpj, _remetente_cpf, _remetente_ie, _remetente_xNome, _remetente_xFant_Opc,
                                _remetente_fone_Opc, _remetente_xLgr, _remetente_nro, _remetente_xCpl_Opc, _remetente_xBairro, _remetente_cMun, _remetente_xMun,
                                _recebedor_CEP_Opc, _remetente_UF, _remetente_cPais_Opc, _remetente_xPais_Opc, _remetente_email_Opc);


                            //DADOS EXPEDIDOR
                            string expedidor = util.expedidor300(_expedidor_cnpj, _expedidor_cpf, _expedidor_ie, _expedidor_xNome,
                                 _expedidor_fone_Opc, _expedidor_xLgr, _expedidor_nro, _expedidor_xCpl_Opc, _expedidor_xBairro, _expedidor_cMun, _expedidor_xMun,
                                 _recebedor_CEP_Opc, _expedidor_UF, _expedidor_cPais_Opc, _expedidor_xPais_Opc, _expedidor_email_Opc);

                            //DADOS RECEBEDOR

                            string recebedor = util.recebedor300(_recebedor_cnpj, _recebedor_cpf, _recebedor_ie, _recebedor_xNome,
                                 _recebedor_fone_Opc, _recebedor_xLgr, _recebedor_nro, _recebedor_xCpl_Opc, _recebedor_xBairro, _recebedor_cMun, _recebedor_xMun,
                                 _recebedor_CEP_Opc, _recebedor_UF, _recebedor_cPais_Opc, _recebedor_xPais_Opc, _recebedor_email_Opc);

                            //DADOS DESTINATARIO
                            string local_entrega = ""; //CRIAR UM FORM PARA COLOCAR O LOCAL DE ENTREGA DIFERENTE DO DESTINATARIO
                            string suframa = "";
                            string destinatario = util.destinatario300(_destinatario_cnpj, _destinatario_cpf, _destinatario_ie, _destinatario_xNome,
                                 _destinatario_fone_Opc, suframa, _destinatario_xLgr, _destinatario_nro, _destinatario_xCpl_Opc, _destinatario_xBairro, _destinatario_cMun, _destinatario_xMun,
                                 _recebedor_CEP_Opc, _destinatario_UF, _destinatario_cPais_Opc, _destinatario_xPais_Opc, _destinatario_email_Opc);

                            //VALORES SERVICO
                            string composicao_preco = "";
                            for (int i = 0; i < dgvCte_frete_composicao.RowCount; i++)
                            {
                                composicao_preco = composicao_preco + util.compVPrest(dgvCte_frete_composicao.Rows[i].Cells["col_descricao"].Value.ToString(),
                                    Convert.ToDouble(dgvCte_frete_composicao.Rows[i].Cells["col_valor"].Value.ToString()));
                            }
                            string valores_servico = util.vPrest(Convert.ToDouble(tb_valor_total_cte.Text), Convert.ToDouble(tb_valor_total_cte.Text), composicao_preco);

                            // ICMS
                            string icms = "";
                            if (crt_empresa == "1") //SIMPLES NACIONAL
                                icms = util.ImpICMSSN300(valorTotalTrib, "", "");
                            else
                            {
                                //icms = util.ImpICMS00("00", Convert.ToDouble(tb_base_calculo.Text), Convert.ToDouble(tb_aliquota.Text),
                                //  Convert.ToDouble(tb_valor_icms.Text), "");
                                string cst = "00";
                                if (uf_inicio != "SP")
                                    cst = "81";
                                icms = util.ImpICMS00_NT2015003("00", Convert.ToDouble(tb_base_calculo.Text), Convert.ToDouble(tb_aliquota.Text),
                                    Convert.ToDouble(tb_valor_icms.Text), valorTotalTrib, "", "");
                            }


                            //CTE NORMAL
                            string cte_normal = "";
                            string informacoes_de_carga = "";
                            string qtdes_carga = "";
                            qtdes_carga = util.infQ("01", "PESO BRUTO", Convert.ToDouble(tb_peso.Text));
                            if (tb_mercadoria.Text == "")
                                tb_mercadoria.Text = "DIVERSOS";

                            informacoes_de_carga = util.infCarga300(Convert.ToDouble(tb_valor_mercado.Text), tb_mercadoria.Text, "", qtdes_carga, Convert.ToDouble(tb_valor_mercado.Text));
                            string seg_xSeg_Opc = "", seg_nApol_Opc = "", seg_nAver_Opc = "";
                            int seg_respSeg = 0;
                            double seg_vCarga_Opc = 0;
                            if (tb_tomador_nome.Text.Contains("TYCO"))
                            {
                                seg_respSeg = 5;
                            }
                            /*
                        else if (empresa_emissora.Contains("LUZIA"))
                        {
                            seg_respSeg = 4;
                            seg_xSeg_Opc = "Allianz Seguros";
                            seg_nApol_Opc = "2I5400000040";
                        }
                        else if(
                        {
                            seg_respSeg = 4;
                            seg_xSeg_Opc = "Allianz Seguros";
                            seg_nApol_Opc = "2I540000039";
                        }
                        */
                            string informacoes_seguro = util.seg(seg_respSeg, seg_xSeg_Opc, seg_nApol_Opc, seg_nAver_Opc, Convert.ToDouble(tb_valor_mercado.Text)); //VERIFICAR NECESSIDADE

                            string modal_rodoviario = "";
                            string RNTRC = tb_rntrc.Text;
                            modal_rodoviario = util.rod300("3.00", RNTRC, "");

                            //cte_normal = util.infCTeNorm(informacoes_de_carga, "", "", informacoes_seguro, modal_rodoviario, "", "", "", "");
                            cte_normal = util.infCTeNorm300(informacoes_de_carga, notas, "", modal_rodoviario, "", "", "", "", "");


                            string infCteComp = "";
                            //string infCteComp = util.infCteComp_2G(_chaveCte);
                            //CONSOLIDACAO DAS INFORMACOES
                            if (tb_remetente_cnpj.Text == "")
                                remetente = "";
                            if (tb_expedidor_cnpj.Text == "")
                                expedidor = "";
                            if (tb_recebedor_cnpj.Text == "")
                                recebedor = "";
                            if (tb_destinatario_cnpj.Text == "")
                                destinatario = "";

                            string cte = util.CTe2G("3.00", _chaveCte, identificacao, dados_complementares, emitente, remetente, expedidor, recebedor, destinatario,
                                     valores_servico, icms, cte_normal, "");
                            salvar_na_pasta(cte, @"c:\\evolucao\\CTE\XML\CTE" + tb_chave_acesso_nfe.Text + ".xml");
                            try
                            {
                                update_coluna_xml_gerado(cte, tb_cod.Text, nome_certificado_nfe_empresa);
                            }
                            catch
                            { }
                            tb_status_nfe.Text = "XML gerado.";
                            atualizar(false);
                            if (mostrar)
                                MessageBox.Show(cte);
                            criar_codigo_barras();
                            verificar_cores();
                            gerarEnviar = DateTime.Now;

                        }
                        else
                        {
                            MessageBox.Show("");
                        }
                    }
                    else
                    {
                        MessageBox.Show(_msgResultado);
                    }
                }
                catch (Exception a)
                {
                    fbConnection1.Close(); 
                    MessageBox.Show(a.ToString());

                }
            }
        }

        private void update_coluna_xml_gerado(string cte, string cod, string Nome)
        {
            try
            {
                string xmlAssinado = "", msgResultado = "";
                int resultado;

                xmlAssinado = util2.Assinar(cte, "infCte", Nome,    out resultado, out msgResultado);
                //    util.Assinar(dr[0].ToString(), "infCte", Nome, out xmlAssinado, out msgResultado);
                if (resultado == 5300)
                {
                    salvar_na_pasta(xmlAssinado, @"c:\\evolucao\\CTE\ASSINADAS\CTE" + tb_chave_acesso_nfe.Text + ".xml");

                    fbConnection1.Open();
                    FbTransaction trans = fbConnection1.BeginTransaction();
                    fbConnection1.Close(); 
                    FbCommand update = new FbCommand("UPDATE CTE SET XML_GERADO = ? " +
                        "WHERE COD_CTE = ?", fbConnection1, trans);
                    update.Parameters.AddWithValue("XML_ASSINADO", xmlAssinado);
                    update.Parameters.AddWithValue("COD_CTE", cod);
                    fbConnection1.Open();
                    FbDataAdapter datTabela = new FbDataAdapter();
                    datTabela.UpdateCommand = update;
                    datTabela.UpdateCommand.ExecuteNonQuery();
                    fbConnection1.Close(); 
                }
                else
                {
                   // MessageBox.Show(msgResultado);
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
                fbConnection1.Close(); 
            }
        }

        private void verificar_cores()
        {
            if (tb_chave_acesso_nfe.Text != "")
                gbNfe.BackColor = Color.Yellow;
            if (tb_recibo.Text != "")
                gbNfe.BackColor = Color.Orange;
            if (tb_protocolo_autorizacao.Text != "")
                gbNfe.BackColor = Color.LimeGreen;
            if (tb_status_nfe.Text.Contains("Cancelada"))
                gbNfe.BackColor = Color.Red;
            if (tb_status_nfe.Text.Contains("Inutilizada"))
                gbNfe.BackColor = Color.Pink;



        }

        private void salvar_na_pasta(string cte, string caminho)
        {
            try
            {
                FileInfo t = new FileInfo(caminho);
                using (StreamWriter texto = t.CreateText())
                {
                    texto.WriteLine(cte);
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
            }
        }

        private void buscar_dados_cliente(string cnpj, out string _cnpj, out string _cpf, out string _ie, out string _xNome,
            out string _xFant_Opc, out string _fone_Opc, out string _xLgr, out string _nro, out string _xCpl_Opc,
            out string _xBairro, out string _cMun, out string _xMun, out string _CEP_Opc, out string _UF, out string _cPais_Opc,
            out string _xPais_Opc, out string _email_Opc)
        {

            _cnpj = ""; _cpf = ""; _ie = ""; _xNome = "";
            _xFant_Opc = ""; _fone_Opc = ""; _xLgr = ""; _nro = ""; _xCpl_Opc = "";
            _xBairro = ""; _cMun = ""; _xMun = ""; _CEP_Opc = ""; _UF = ""; _cPais_Opc = "";
            _xPais_Opc = ""; _email_Opc = "";
            if (cnpj != "")
            {
                try
                {
                    FbCommand select = new FbCommand();
                    select.Connection = fbConnection1;
                    fbConnection1.Open();
                    select.CommandText =
                        "SELECT * FROM CLIENTES WHERE CNPJ = '" + cnpj + "'";
                    FbDataAdapter datTabela = new FbDataAdapter();
                    datTabela.SelectCommand = select;
                    DataSet dsTabela = new DataSet();
                    datTabela.Fill(dsTabela);
                    fbConnection1.Close(); 
                    foreach (DataRow dr in dsTabela.Tables[0].Rows)
                    {
                        if (dr["PESSOA_FISICA_CLIENTE"].ToString() == "1")
                            _cpf = dr["CNPJ"].ToString();
                        else
                            _cnpj = dr["CNPJ"].ToString();

                        if (dr["CNPJ"].ToString() == dr["COD_CLIENTE"].ToString())
                        {
                            _cnpj = "99999999999999";
                            _cpf = "99999999999";
                        }
                        _ie = dr["IE"].ToString().Replace(".","");

                        _xNome = retirar_caracteres(dr["RAZAO_SOCIAL"].ToString());
                        if (cbTeste.Checked)
                            _xNome = "CT-E EMITIDO EM AMBIENTE DE HOMOLOGACAO - SEM VALOR FISCAL";
                        _xFant_Opc = retirar_caracteres(dr["NOME_FANTASIA"].ToString());
                        _fone_Opc = retirar_caracteres(dr["FONE"].ToString()).Replace(" ", "");
                        try
                        {
                            _fone_Opc = _fone_Opc.Remove(10);
                        }
                        catch { }
                        if (_fone_Opc == "" || _fone_Opc.Length < 8)
                            _fone_Opc = "00000000";
                        _xLgr = retirar_caracteres(dr["ENDERECO"].ToString());
                        _nro = dr["NUMERO_CLIENTE"].ToString();
                        _xCpl_Opc = retirar_caracteres(dr["COMPLEMENTO_CLIENTE"].ToString());
                        _xBairro = retirar_caracteres(dr["BAIRRO"].ToString());
                        _cMun = retirar_caracteres(dr["COD_CIDADE_CLIENTE"].ToString());
                        _xMun = retirar_caracteres(dr["CIDADE"].ToString());
                        _CEP_Opc = retirar_caracteres(dr["CEP_CLIENTE"].ToString());
                        _UF = retirar_caracteres(dr["ESTADO"].ToString());
                        _cPais_Opc = retirar_caracteres(dr["COD_PAIS_CLIENTE"].ToString());
                        _xPais_Opc = retirar_caracteres(dr["PAIS"].ToString());
                        _email_Opc = dr["EMAIL"].ToString();
                    }
                }
                catch (Exception a)
                {
                    fbConnection1.Close(); 
                    MessageBox.Show(a.ToString());
                }
            }
        }

        private void bt_enviarNFe_Click(object sender, EventArgs e)
        {
            if (verificar_se_existe_2_registros_iguais(tb_n_cte.Text, cnpj_empresa_emissora))
            {
                MessageBox.Show("Esse registro será excluído pois já existe um com o mesmo número");
                excluir_por_numero(tb_n_cte.Text, cnpj_empresa_emissora);
            }
            try
            {
                gerarXml(false);
                if (1 == 0)
                {}
                else
                {
                    try
                    {
                        bt_enviarNFe.Enabled = false;

                        if (tb_recibo.Text == "")
                        {
                            string razao_social_empresa = "", nome_fantasia_empresa = "", cnpj_empresa = "", ie_empresa = "", im_empresa = "", cnae_empresa = "", endereco_empresa = "", n_endereco_empresa = "",
                                                   complemento_empresa = "", bairro_empresa = "", cidade_empresa = "", estado_empresa = "", cep_empresa = "", telefone_empresa = "", cod_cidade_empresa = "", pais_empresa = "",
                                                   cod_pais_empresa = "", licenca_dll_nfe_empresa = "", nome_certificado_nfe_empresa = "", assunto_nfe_email_empresa = "", smtp_nfe_empresa = "", email_nfe_empresa = "",
                                                   senha_email_nfe_empresa = "", logotipo_empresa = "", proxy_empresa = "", usuario_proxy_empresa = "", senha_proxy_empresa = "", crt_empresa = "", rntrc_empresa = "", serie_nf_empresa = "",
                                                serie_cte_empresa = "", porta_email;
                            detectar_dados_empresa(tb_cnpj_emitente.Text, out razao_social_empresa, out nome_fantasia_empresa, out cnpj_empresa, out ie_empresa, out im_empresa, out cnae_empresa, out endereco_empresa, out n_endereco_empresa,
                                    out complemento_empresa, out bairro_empresa, out cidade_empresa, out estado_empresa, out cep_empresa, out telefone_empresa, out cod_cidade_empresa, out pais_empresa,
                                    out cod_pais_empresa, out licenca_dll_nfe_empresa, out nome_certificado_nfe_empresa, out assunto_nfe_email_empresa, out smtp_nfe_empresa, out email_nfe_empresa,
                                    out senha_email_nfe_empresa, out logotipo_empresa, out proxy_empresa, out usuario_proxy_empresa, out senha_proxy_empresa, out crt_empresa, out rntrc_empresa, out serie_nf_empresa, out serie_cte_empresa, out porta_email);

                            string proxy = proxy_empresa;
                            string usuario = usuario_proxy_empresa;
                            string senha = senha_proxy_empresa;
                            string licenca = licenca_dll_nfe_empresa;
                            string nomeCertificado = nome_certificado_nfe_empresa;
                            string _nroRecibo, _msgCabec, _msgDados, _msgRetWS, _msgResultado, _NFeAssinada;
                            string arquivo = "";
                            //lendo XML
                            string caminho = @"c:\\evolucao\\CTE\XML\CTE" + tb_chave_acesso_nfe.Text + ".xml";
                            StreamReader objReader = new StreamReader(caminho);
                            ArrayList arrText = new ArrayList();
                            arquivo = objReader.ReadToEnd();
                            objReader.Close();
                            //arquivo = retirar_caracteres(arquivo);
                            int resultado = 0;
                            int _cStat = 0;
                            string _dhRecbto = "";
                            string tMed = "";

                            string CTeAssinada = "";

                            /*   int envia = util.EnviaCTe(estado_empresa, ref arquivo, out _nroRecibo, nomeCertificado, "2.00", out _msgDados,
                                   out _msgRetWS, out _msgResultado, out CTeAssinada, proxy, usuario, senha, licenca);*/

                            int envia = util.EnviaCTe(estado_empresa, ref arquivo, out _nroRecibo, nomeCertificado, "3.00", out _msgDados,
                                out _msgRetWS, out _msgResultado, out CTeAssinada, proxy, usuario, senha, licenca);

                            
                            if (envia == 103)
                            {
                                salvar_na_pasta(CTeAssinada, @"c:\\evolucao\\CTE\ASSINADAS\CTE" + tb_chave_acesso_nfe.Text + ".xml");
                                //salvar_na_pasta(CTeAssinada, @"T:\ASSINADAS\CTE" + tb_n_cte.Text + ".xml");
                                tb_status_nfe.Text = "CTe Assinada";
                                tb_recibo.Text = _nroRecibo;

                                atualizar(false);
                                verificar_cores();
                                try
                                {
                                    update_coluna_xml_assin(CTeAssinada, tb_cod.Text);
                                }
                                catch
                                { }
                            }
                            else
                            {
                                MessageBox.Show(envia.ToString() + " " + _msgResultado + " " + _msgRetWS + " " + _msgDados);
                            }


                        }
                        bt_enviarNFe.Enabled = true;


                    }
                    catch (Exception a)
                    {
                        MessageBox.Show(a.ToString());
                    }
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
                fbConnection1.Close(); 
            }

        }

        private string retirar_caracteres(string arquivo)
        {
            return arquivo.Replace("Ã", "A").Replace("Õ", "O").Replace("Ç", "C").Replace("Â", "A").Replace("Á", "A").Replace("À", "A")
                .Replace("Ô", "O").Replace("\r\n", " ").Replace("-", "").Replace("(", "").Replace(")", "").Replace("/", "").Replace("&", "e").Replace("'", "");
        }

        private void br_consultaStatus_Click(object sender, EventArgs e)
        {
            try
            {
                string razao_social_empresa = "", nome_fantasia_empresa = "", cnpj_empresa = "", ie_empresa = "", im_empresa = "", cnae_empresa = "", endereco_empresa = "", n_endereco_empresa = "",
                        complemento_empresa = "", bairro_empresa = "", cidade_empresa = "", estado_empresa = "", cep_empresa = "", telefone_empresa = "", cod_cidade_empresa = "", pais_empresa = "",
                        cod_pais_empresa = "", licenca_dll_nfe_empresa = "", nome_certificado_nfe_empresa = "", assunto_nfe_email_empresa = "", smtp_nfe_empresa = "", email_nfe_empresa = "",
                        senha_email_nfe_empresa = "", logotipo_empresa = "", proxy_empresa = "", usuario_proxy_empresa = "", senha_proxy_empresa = "", crt_empresa = "", rntrc_empresa = "", serie_nf_empresa = "",
                     serie_cte_empresa = "", porta_email = "";
                detectar_dados_empresa(tb_cnpj_emitente.Text, out razao_social_empresa, out nome_fantasia_empresa, out cnpj_empresa, out ie_empresa, out im_empresa, out cnae_empresa, out endereco_empresa, out n_endereco_empresa,
                        out complemento_empresa, out bairro_empresa, out cidade_empresa, out estado_empresa, out cep_empresa, out telefone_empresa, out cod_cidade_empresa, out pais_empresa,
                        out cod_pais_empresa, out licenca_dll_nfe_empresa, out nome_certificado_nfe_empresa, out assunto_nfe_email_empresa, out smtp_nfe_empresa, out email_nfe_empresa,
                        out senha_email_nfe_empresa, out logotipo_empresa, out proxy_empresa, out usuario_proxy_empresa, out senha_proxy_empresa, out crt_empresa, out rntrc_empresa, out serie_nf_empresa, out serie_cte_empresa, out porta_email);


                string proxy = proxy_empresa;
                string usuario = usuario_proxy_empresa;
                string senha = senha_proxy_empresa;
                string licenca = licenca_dll_nfe_empresa;
                string nomeCertificado = nome_certificado_nfe_empresa;

                string arquivo = "";
                //lendo XML
                bool arquivo_ok = false;
                string caminho = @"c:\\evolucao\\CTE\ASSINADAS\CTE" + tb_chave_acesso_nfe.Text + ".xml";
                if (System.IO.File.Exists(caminho))
                {
                    StreamReader objReader = new StreamReader(caminho);
                    ArrayList arrText = new ArrayList();
                    arquivo = objReader.ReadToEnd();
                    objReader.Close();
                    arquivo_ok = true;
                }
                else
                {
                    /*
                    caminho = @"T:\ASSINADAS\CTE" + tb_n_cte.Text + ".xml";
                    if (System.IO.File.Exists(caminho))
                    {
                        StreamReader objReader = new StreamReader(caminho);
                        ArrayList arrText = new ArrayList();
                        arquivo = objReader.ReadToEnd();
                        objReader.Close();
                        arquivo_ok = true;
                    }
                     * */
                }

                if (arquivo_ok)
                {
                    string procCTe, nroProtocolo, dAutorizacao, _msgDados, _msgRetWS, _msgResultado;

                    string n_recibo = tb_recibo.Text;

                    int tipo_ambiente = 1;
                    if (cbTeste.Checked)
                        tipo_ambiente = 2;
                    int consulta = util.BuscaCTe(estado_empresa, tipo_ambiente, "SP", ref arquivo, ref n_recibo, out procCTe, out nroProtocolo, out dAutorizacao,
                        nome_certificado_nfe_empresa, "3.00", out _msgDados, out _msgRetWS, out _msgResultado, proxy, usuario, senha, licenca);

                    if (consulta == 100)
                    {
                        salvar_na_pasta(procCTe, @"c:\\evolucao\\CTE\AUTORIZADAS\CTE" + tb_chave_acesso_nfe.Text + ".xml");
                        //salvar_na_pasta(procCTe, @"T:\AUTORIZADAS\CTE" + tb_chave_acesso_nfe.Text + ".xml");
                        tb_status_nfe.Text = "CTe Autorizada";
                        tb_protocolo_autorizacao.Text = nroProtocolo;
                        atualizar(true);
                        try
                        {
                            update_coluna_xml_aut(procCTe, tb_cod.Text);
                        }
                        catch { }
                        verificar_cores();
                        try
                        {
                            imprimir_cte();
                        }
                        finally
                        {
                            enviar_email();
                        }
                    }
                    else if (consulta == 105)
                    {
                        MessageBox.Show(consulta.ToString() + " " + _msgResultado);
                    }
                    else
                    {
                        MessageBox.Show(consulta.ToString() + " " + _msgResultado);
                        tb_recibo.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Arquivo Assinado não encontrado");
                }

            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
            }
        }

        private void update_coluna_xml_aut(string procCTe, string cod)
        {
            try
            {
                fbConnection1.Open();
                FbTransaction trans = fbConnection1.BeginTransaction();
                fbConnection1.Close(); 
                FbCommand update = new FbCommand("UPDATE CTE SET XML_AUTORIZADO = ? " +
                    "WHERE COD_CTE = ?", fbConnection1, trans);
                update.Parameters.AddWithValue("XML_AUTORIZADO", procCTe);
                update.Parameters.AddWithValue("COD_CTE", cod);
                fbConnection1.Open();
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.UpdateCommand = update;
                datTabela.UpdateCommand.ExecuteNonQuery();
                fbConnection1.Close(); 
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
                fbConnection1.Close(); 
            }

        }
        private void update_coluna_xml_assin(string procAssi, string cod)
        {
            try
            {
                fbConnection1.Open();
                FbTransaction trans = fbConnection1.BeginTransaction();
                fbConnection1.Close(); 
                FbCommand update = new FbCommand("UPDATE CTE SET XML_ASSINADO = ? " +
                    "WHERE COD_CTE = ?", fbConnection1, trans);
                update.Parameters.AddWithValue("XML_ASSINADO", procAssi);
                update.Parameters.AddWithValue("COD_CTE", cod);
                fbConnection1.Open();
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.UpdateCommand = update;
                datTabela.UpdateCommand.ExecuteNonQuery();
                fbConnection1.Close(); 
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
                fbConnection1.Close(); 
            }

        }
        private void update_coluna_xml_canc(string procCTe, string cod)
        {
            try
            {
                fbConnection1.Open();
                FbTransaction trans = fbConnection1.BeginTransaction();
                fbConnection1.Close(); 
                FbCommand update = new FbCommand("UPDATE CTE SET XML_CANCELADO = ? " +
                    "WHERE COD_CTE = ?", fbConnection1, trans);
                update.Parameters.AddWithValue("XML_CANCELADO", procCTe);
                update.Parameters.AddWithValue("COD_CTE", cod);
                fbConnection1.Open();
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.UpdateCommand = update;
                datTabela.UpdateCommand.ExecuteNonQuery();
                fbConnection1.Close(); 
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
                fbConnection1.Close(); 
            }

        }
        private void update_coluna_xml_inut(string procCTe, string cod)
        {
            try
            {
                fbConnection1.Open();
                FbTransaction trans = fbConnection1.BeginTransaction();
                fbConnection1.Close(); 
                FbCommand update = new FbCommand("UPDATE CTE SET XML_INUTILIZADO = ? " +
                    "WHERE COD_CTE = ?", fbConnection1, trans);
                update.Parameters.AddWithValue("XML_INUTILIZADO", procCTe);
                update.Parameters.AddWithValue("COD_CTE", cod);
                fbConnection1.Open();
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.UpdateCommand = update;
                datTabela.UpdateCommand.ExecuteNonQuery();
                fbConnection1.Close(); 
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
                fbConnection1.Close(); 
            }

        }
        private void enviar_email()
        {
            try
            {
                string razao_social_empresa = "", nome_fantasia_empresa = "", cnpj_empresa = "", ie_empresa = "", im_empresa = "", cnae_empresa = "", endereco_empresa = "", n_endereco_empresa = "",
                         complemento_empresa = "", bairro_empresa = "", cidade_empresa = "", estado_empresa = "", cep_empresa = "", telefone_empresa = "", cod_cidade_empresa = "", pais_empresa = "",
                         cod_pais_empresa = "", licenca_dll_nfe_empresa = "", nome_certificado_nfe_empresa = "", assunto_nfe_email_empresa = "", smtp_nfe_empresa = "", email_nfe_empresa = "",
                         senha_email_nfe_empresa = "", logotipo_empresa = "", proxy_empresa = "", usuario_proxy_empresa = "", senha_proxy_empresa = "", crt_empresa = "", rntrc_empresa = "", serie_nf_empresa = "",
                      serie_cte_empresa = "", porta_email;
                detectar_dados_empresa(tb_cnpj_emitente.Text, out razao_social_empresa, out nome_fantasia_empresa, out cnpj_empresa, out ie_empresa, out im_empresa, out cnae_empresa, out endereco_empresa, out n_endereco_empresa,
                        out complemento_empresa, out bairro_empresa, out cidade_empresa, out estado_empresa, out cep_empresa, out telefone_empresa, out cod_cidade_empresa, out pais_empresa,
                        out cod_pais_empresa, out licenca_dll_nfe_empresa, out nome_certificado_nfe_empresa, out assunto_nfe_email_empresa, out smtp_nfe_empresa, out email_nfe_empresa,
                        out senha_email_nfe_empresa, out logotipo_empresa, out proxy_empresa, out usuario_proxy_empresa, out senha_proxy_empresa, out crt_empresa, out rntrc_empresa, out serie_nf_empresa, out serie_cte_empresa, out porta_email);

                string _caminho_arquivo = @"c:\\evolucao\\cte\autorizadas\CTE" + tb_chave_acesso_nfe.Text + ".xml";
                string _caminho_danfe = @"c:\\evolucao\\cte\DANFES\DACTE_CTE_" + tb_n_cte.Text + ".pdf";
                //var assunto
                string _assunto = assunto_nfe_email_empresa + " " + tb_chave_acesso_nfe.Text;

                string boa = "Bom dia, ";
                if (DateTime.Now > Convert.ToDateTime(DateTime.Now.ToShortDateString() + " " + "12:00:00"))
                    boa = "Boa tarde, ";
                if (DateTime.Now > Convert.ToDateTime(DateTime.Now.ToShortDateString() + " " + "18:00:00"))
                    boa = "Boa Noite, ";
                string _mensagem = "<html xmlns:v='urn:schemas-microsoft-com:vml'" +
    "xmlns:o='urn:schemas-microsoft-com:office:office'" +
    "xmlns:w='urn:schemas-microsoft-com:office:word'" +
    "xmlns='http://www.w3.org/TR/REC-html40'>" +

    "<head>" +
    "<meta http-equiv=Content-Type content='text/html; charset=windows-1252'>" +
    "<meta name=ProgId content=Word.Document>" +
    "<meta name=Generator content='Microsoft Word 11'>" +
    "<meta name=Originator content='Microsoft Word 11'>" +
    "<link rel=File-List href='body_arquivos/filelist.xml'>" +
    "<title>Prezado cliente,</title>" +
    "</head>" +
    "<body>" +
    "<font size='2' face='tahoma' color='black'>" +

    "<div class=Section1> " +
    boa + " <br>" +

    "Prezado Cliente, <br> " +

    "Segue anexo Conhecimento de Transporte Eletrônico nº " + tb_n_cte.Text + " , de " + tb_data_emissao.Text + ".<br>" +
    "A DACTE segue em anexo e fisicamente com a sua mercadoria.<br><br>" +

    "Caso haja alguma divergência entrar em contato, <br>" +

    "Atenciosamente, <br> <br>" +
    "" +
                    //"<img src='cid:atual'/> <br>" +
    empresa_emissora + "<br>" +
    telefone_empresa + "<br>" +

    "Cte emitido por Sistema Evolução (www.evolucaoinfo.com.br)" +
    "</font>" +
    "</div>" +
    "</body>" +
    "</html>";
                Email_cte novo_email = new Email_cte();
                bool _erro = true;
                //var smtp, email, senha_email
                string email_cliente = detectar_email();
                if (email_cliente != "")
                {

                    novo_email.EnviarEmail(email_cliente, _assunto, _mensagem, _caminho_arquivo, _caminho_danfe, email_nfe_empresa, senha_email_nfe_empresa, smtp_nfe_empresa, out _erro);
                    if (_erro == false)
                    {
                        statustoolStripStatusLabel.Text = "Email enviado com sucesso. ";
                    }
                    else
                    {
                        statustoolStripStatusLabel.Text = "Email não enviado. Favor verificar dados. ";
                    }
                }
                else
                {
                    statustoolStripStatusLabel.Text = "Email não cadastrado. Favor verificar dados. ";
                }
            }
            catch (Exception a)
            {
                fbConnection1.Close(); 
                MessageBox.Show(a.ToString());
            }
        }

        private string detectar_email()
        {
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                "SELECT EMAIL " +
                "FROM CLIENTES WHERE CNPJ = '" + tb_tomador_cnpj.Text + "'";
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.SelectCommand = select;
                DataSet dsTabela = new DataSet();
                datTabela.Fill(dsTabela);
                fbConnection1.Close(); 
                string cliente_atual = "";
                foreach (DataRow dr in dsTabela.Tables[0].Rows)
                {
                    cliente_atual = dr["EMAIL"].ToString();
                }
                return cliente_atual;
            }
            catch (Exception a)
            {
                fbConnection1.Close(); 
                MessageBox.Show(a.ToString());
                return "";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tb_recibo.Text = "";
        }

        private void bt_imprimirNFe_Click(object sender, EventArgs e)
        {
            imprimir_cte();
        }

        private void imprimir_cte()
        {
            //if (tb_protocolo_autorizacao.Text != "")
            //{
            Evolucao.dsCte ds = new dsCte();
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT * FROM CTE WHERE COD_CTE = '" + tb_cod.Text + "'";
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.SelectCommand = select;
                datTabela.Fill(ds.CTE);
                fbConnection1.Close(); 

                //DADOS EXPEDIDOR
                string _expedidor_cnpj, _expedidor_cpf, _expedidor_ie, _expedidor_xNome, _expedidor_xFant_Opc, _expedidor_fone_Opc,
                    _expedidor_xLgr, _expedidor_nro, _expedidor_xCpl_Opc, _expedidor_xBairro, _expedidor_cMun, _expedidor_xMun,
                    _expedidor_CEP_Opc, _expedidor_UF, _expedidor_cPais_Opc, _expedidor_xPais_Opc, _expedidor_email_Opc;
                buscar_dados_cliente(tb_expedidor_cnpj.Text, out _expedidor_cnpj, out _expedidor_cpf, out _expedidor_ie, out _expedidor_xNome, out _expedidor_xFant_Opc, out _expedidor_fone_Opc, out
                _expedidor_xLgr, out _expedidor_nro, out _expedidor_xCpl_Opc, out _expedidor_xBairro, out _expedidor_cMun, out _expedidor_xMun, out
                _expedidor_CEP_Opc, out _expedidor_UF, out _expedidor_cPais_Opc, out _expedidor_xPais_Opc, out _expedidor_email_Opc);

                ds.EXPEDIDOR.AddEXPEDIDORRow(_expedidor_xNome, _expedidor_xLgr, _expedidor_nro, _expedidor_xCpl_Opc, _expedidor_xBairro,
                    _expedidor_xMun, _expedidor_UF, _expedidor_CEP_Opc, _expedidor_cnpj, _expedidor_ie, _expedidor_fone_Opc);

                //DADOS RECEBEDOR
                string _recebedor_cnpj, _recebedor_cpf, _recebedor_ie, _recebedor_xNome, _recebedor_xFant_Opc, _recebedor_fone_Opc,
                   _recebedor_xLgr, _recebedor_nro, _recebedor_xCpl_Opc, _recebedor_xBairro, _recebedor_cMun, _recebedor_xMun,
                   _recebedor_CEP_Opc, _recebedor_UF, _recebedor_cPais_Opc, _recebedor_xPais_Opc, _recebedor_email_Opc;
                buscar_dados_cliente(tb_recebedor_cnpj.Text, out _recebedor_cnpj, out _recebedor_cpf, out _recebedor_ie, out _recebedor_xNome, out _recebedor_xFant_Opc, out _recebedor_fone_Opc, out
                _recebedor_xLgr, out _recebedor_nro, out _recebedor_xCpl_Opc, out _recebedor_xBairro, out _recebedor_cMun, out _recebedor_xMun, out
                _recebedor_CEP_Opc, out _recebedor_UF, out _recebedor_cPais_Opc, out _recebedor_xPais_Opc, out _recebedor_email_Opc);

                ds.RECEBEDOR.AddRECEBEDORRow(_recebedor_xNome, _recebedor_xLgr, _recebedor_nro, _recebedor_xCpl_Opc, _recebedor_xBairro,
                   _recebedor_xMun, _recebedor_UF, _recebedor_CEP_Opc, _recebedor_cnpj, _recebedor_ie, _recebedor_fone_Opc);

                //DADOS REMETENTE
                string _remetente_cnpj, _remetente_cpf, _remetente_ie, _remetente_xNome, _remetente_xFant_Opc, _remetente_fone_Opc,
                  _remetente_xLgr, _remetente_nro, _remetente_xCpl_Opc, _remetente_xBairro, _remetente_cMun, _remetente_xMun,
                  _remetente_CEP_Opc, _remetente_UF, _remetente_cPais_Opc, _remetente_xPais_Opc, _remetente_email_Opc;
                buscar_dados_cliente(tb_remetente_cnpj.Text, out _remetente_cnpj, out _remetente_cpf, out _remetente_ie, out _remetente_xNome, out _remetente_xFant_Opc, out _remetente_fone_Opc, out
                _remetente_xLgr, out _remetente_nro, out _remetente_xCpl_Opc, out _remetente_xBairro, out _remetente_cMun, out _remetente_xMun, out
                _remetente_CEP_Opc, out _remetente_UF, out _remetente_cPais_Opc, out _remetente_xPais_Opc, out _remetente_email_Opc);

                ds.REMETENTE.AddREMETENTERow(_remetente_xNome, _remetente_xLgr, _remetente_nro, _remetente_xCpl_Opc, _remetente_xBairro,
                   _remetente_xMun, _remetente_UF, _remetente_CEP_Opc, _remetente_cnpj, _remetente_ie, _remetente_fone_Opc);

                //DADOS DESTINATARIO
                string _destinatario_cnpj, _destinatario_cpf, _destinatario_ie, _destinatario_xNome, _destinatario_xFant_Opc, _destinatario_fone_Opc,
                  _destinatario_xLgr, _destinatario_nro, _destinatario_xCpl_Opc, _destinatario_xBairro, _destinatario_cMun, _destinatario_xMun,
                  _destinatario_CEP_Opc, _destinatario_UF, _destinatario_cPais_Opc, _destinatario_xPais_Opc, _destinatario_email_Opc;
                buscar_dados_cliente(tb_destinatario_cnpj.Text, out _destinatario_cnpj, out _destinatario_cpf, out _destinatario_ie, out _destinatario_xNome, out _destinatario_xFant_Opc, out _destinatario_fone_Opc, out
                _destinatario_xLgr, out _destinatario_nro, out _destinatario_xCpl_Opc, out _destinatario_xBairro, out _destinatario_cMun, out _destinatario_xMun, out
                _destinatario_CEP_Opc, out _destinatario_UF, out _destinatario_cPais_Opc, out _destinatario_xPais_Opc, out _destinatario_email_Opc);

                ds.DESTINATARIO.AddDESTINATARIORow(_destinatario_xNome, _destinatario_xLgr, _destinatario_nro, _destinatario_xCpl_Opc, _destinatario_xBairro,
                   _destinatario_xMun, _destinatario_UF, _destinatario_CEP_Opc, _destinatario_cnpj, _destinatario_ie, _destinatario_fone_Opc);

                //DADOS TOMADOR
                string _tomador_cnpj, _tomador_cpf, _tomador_ie, _tomador_xNome, _tomador_xFant_Opc, _tomador_fone_Opc,
                  _tomador_xLgr, _tomador_nro, _tomador_xCpl_Opc, _tomador_xBairro, _tomador_cMun, _tomador_xMun,
                  _tomador_CEP_Opc, _tomador_UF, _tomador_cPais_Opc, _tomador_xPais_Opc, _tomador_email_Opc;
                buscar_dados_cliente(tb_tomador_cnpj.Text, out _tomador_cnpj, out _tomador_cpf, out _tomador_ie, out _tomador_xNome, out _tomador_xFant_Opc, out _tomador_fone_Opc, out
                _tomador_xLgr, out _tomador_nro, out _tomador_xCpl_Opc, out _tomador_xBairro, out _tomador_cMun, out _tomador_xMun, out
                _tomador_CEP_Opc, out _tomador_UF, out _tomador_cPais_Opc, out _tomador_xPais_Opc, out _tomador_email_Opc);

                ds.TOMADOR.AddTOMADORRow(_tomador_xNome, _tomador_xLgr, _tomador_nro, _tomador_xCpl_Opc, _tomador_xBairro,
                   _tomador_xMun, _tomador_UF, _tomador_CEP_Opc, _tomador_cnpj, _tomador_ie, _tomador_fone_Opc);

                //NOTAS FISCAIS
                select.Connection = fbConnection1;
                fbConnection1.Open();
                if (cbPortaria_121.Checked)
                {
                    select.CommandText =
                        "SELECT first(140) * FROM CTE_NOTAS_FISCAIS WHERE COD_CTE_CNF = '" + tb_cod.Text + "'";
                }
                else
                {
                    select.CommandText =
                        "SELECT * FROM CTE_NOTAS_FISCAIS WHERE COD_CTE_CNF = '" + tb_cod.Text + "'";
                }
                datTabela.SelectCommand = select;
                datTabela.Fill(ds.CTE_NOTAS_FISCAIS);
                fbConnection1.Close(); 



                //COMPOSICAO
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT * FROM CTE_FRETE_COMPOSICAO WHERE COD_CTE_CFC = '" + tb_cod.Text + "'";
                datTabela.SelectCommand = select;
            //    datTabela.SelectCommand = select;
                datTabela.Fill(ds.CTE_FRETE_COMPOSICAO);
                fbConnection1.Close(); 

                //EMPRESA
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT * FROM EMPRESA WHERE CNPJ_EMPRESA = '" + cnpjtoolStripStatusLabel.Text + "'";
                datTabela.SelectCommand = select;
                datTabela.Fill(ds.EMPRESA);
                fbConnection1.Close();

                if (cbPortaria_121.Checked)
                {
                    crCte_chave nova_nota = new crCte_chave();

                    nova_nota.SetDataSource(ds);

                    form_imprimir imprime = new form_imprimir(nova_nota);
                    imprime.n_cte = tb_n_cte.Text;
                    imprime.cte = true;
                    imprime.Show();
                }
                else
                {
                    crCte nova_nota = new crCte();
                    nova_nota.SetDataSource(ds);
                    form_imprimir imprime = new form_imprimir(nova_nota);
                    imprime.n_cte = tb_n_cte.Text;
                    imprime.cte = true;
                    if (impressao_cte)
                        imprime.cte_direto = impressao_cte;
                    imprime.Show();
                }

            }
            catch (Exception a)
            {
                fbConnection1.Close(); 
                MessageBox.Show(a.ToString());
            }
            //}
            //else
            //{
            //    MessageBox.Show("CTe não autorizado");
            //}

        }

        private void button17_Click(object sender, EventArgs e)
        {
            somar_valores_nf();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            form_selecionar_empresa emp = new form_selecionar_empresa();
            try
            {
                emp.busca_dentro = true;
                emp.ShowDialog();
            }
            finally
            {
                if (emp.empresa_emissora != "")
                {
                    cnpj_empresa_emissora = emp.cnpj_empresa_emissora;
                    empresa_emissora = emp.empresa_emissora;
                    empresatoolStripStatusLabel.Text = empresa_emissora;
                    cnpjtoolStripStatusLabel.Text = cnpj_empresa_emissora;
                }
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {

            if (tb_tomador_cnpj.Text == tb_remetente_cnpj.Text)
            {
                tb_tomador_cnpj.Text = tb_destinatario_cnpj.Text;
                tb_tomador_nome.Text = tb_destinatario_nome.Text;
                cbFrete.Text = "1 - À Pagar";

            }
            else
            {
                if (tb_tomador_cnpj.Text == tb_destinatario_cnpj.Text)
                {
                    tb_tomador_cnpj.Text = tb_remetente_cnpj.Text;
                    tb_tomador_nome.Text = tb_remetente_nome.Text;
                    cbFrete.Text = "0 - Pago";
                }
            }

        }

        private void bt_cancelarNFe_Click(object sender, EventArgs e)
        {
            try
            {
                string razao_social_empresa = "", nome_fantasia_empresa = "", cnpj_empresa = "", ie_empresa = "", im_empresa = "", cnae_empresa = "", endereco_empresa = "", n_endereco_empresa = "",
                           complemento_empresa = "", bairro_empresa = "", cidade_empresa = "", estado_empresa = "", cep_empresa = "", telefone_empresa = "", cod_cidade_empresa = "", pais_empresa = "",
                           cod_pais_empresa = "", licenca_dll_nfe_empresa = "", nome_certificado_nfe_empresa = "", assunto_nfe_email_empresa = "", smtp_nfe_empresa = "", email_nfe_empresa = "",
                           senha_email_nfe_empresa = "", logotipo_empresa = "", proxy_empresa = "", usuario_proxy_empresa = "", senha_proxy_empresa = "", crt_empresa = "", rntrc_empresa = "", serie_nf_empresa = "",
                        serie_cte_empresa = "", porta_email = "";
                detectar_dados_empresa(tb_cnpj_emitente.Text, out razao_social_empresa, out nome_fantasia_empresa, out cnpj_empresa, out ie_empresa, out im_empresa, out cnae_empresa, out endereco_empresa, out n_endereco_empresa,
                        out complemento_empresa, out bairro_empresa, out cidade_empresa, out estado_empresa, out cep_empresa, out telefone_empresa, out cod_cidade_empresa, out pais_empresa,
                        out cod_pais_empresa, out licenca_dll_nfe_empresa, out nome_certificado_nfe_empresa, out assunto_nfe_email_empresa, out smtp_nfe_empresa, out email_nfe_empresa,
                        out senha_email_nfe_empresa, out logotipo_empresa, out proxy_empresa, out usuario_proxy_empresa, out senha_proxy_empresa, out crt_empresa, out rntrc_empresa, out serie_nf_empresa, out serie_cte_empresa, out porta_email);

                string proxy = proxy_empresa;
                string usuario = usuario_proxy_empresa;
                string senha = senha_proxy_empresa;
                string licenca = licenca_dll_nfe_empresa;
                string nomeCertificado = nome_certificado_nfe_empresa;
                string _msgDados, _msgRetWS, _msgResultado;
                string procCanc;
                string protocolo = tb_protocolo_autorizacao.Text;
                string _dhEvento = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:sszz:00");
                
                int _cStat;
                string _nProtocoloCanc, dProtocoloCanc;
                if (protocolo.Length > 15)
                {
                    protocolo = protocolo.Remove(15);
                }
               // int consulta = util.CancelaCT(estado_empresa, estado_empresa, 1, nome_certificado_nfe_empresa, "2.00", out _msgDados, out _msgRetWS,
               //     out _msgResultado, out procCanc, tb_chave_acesso_nfe.Text, protocolo, tb_motivo_cancelamento.Text, proxy, usuario, senha, licenca);
                string procEvento = util.CancelaCTEvento(estado_empresa, 1, nome_certificado_nfe_empresa, "3.00", out _msgDados, out _msgRetWS,
                    out _cStat, out _msgResultado, tb_chave_acesso_nfe.Text, protocolo, tb_motivo_cancelamento.Text, _dhEvento, out _nProtocoloCanc, out dProtocoloCanc,
                    proxy, usuario, senha, licenca);


                if (_cStat == 135)
                {
                    salvar_na_pasta(_msgRetWS, @"c:\\evolucao\\CTE\CANCELADAS\CTE" + tb_chave_acesso_nfe.Text + ".xml");
                    //salvar_na_pasta(procCanc, @"T:\CANCELADAS\CTE" + tb_chave_acesso_nfe.Text + ".xml");
                    tb_status_nfe.Text = "CTe Cancelada";
                    atualizar(true);
                    verificar_cores();
                    MessageBox.Show("Item Cancelado as: " + _dhEvento);
                    try
                    {
                        update_coluna_xml_canc(_msgRetWS, tb_cod.Text);
                    }
                    catch { }
                    //enviar_email_cancelada();
                }
                else
                {
                    MessageBox.Show(_cStat.ToString() + " " + _msgResultado);
                }

            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
            }
        }

        private void tb_remetente_cnpj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                if (tb_remetente_cnpj.Text.Length == 14)
                {
                    tb_remetente_nome.Text = buscar_nome_cliente(tb_remetente_cnpj.Text);
                }
                else
                {
                    form_localiza_cliente cli = new form_localiza_cliente(false, "");
                    try
                    {
                        cli.cnpj_a_buscar = tb_remetente_cnpj.Text;
                        cli.ShowDialog();
                    }
                    finally
                    {
                        tb_remetente_nome.Text = cli.cliente_escolhido;
                        tb_remetente_cnpj.Text = cli.cnpj_escolhido;
                        // tb_expedidor_nome.Text = cli.cliente_escolhido;
                        //tb_expedidor_cnpj.Text = cli.cnpj_escolhido;
                        tb_tomador_nome.Text = cli.cliente_escolhido;
                        tb_tomador_cnpj.Text = cli.cnpj_escolhido;
                        tb_destinatario_cnpj.Focus();
                    }
                }

            }
        }

        private void tb_destinatario_cnpj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                if (tb_destinatario_cnpj.Text.Length == 14)
                {
                    tb_destinatario_nome.Text = buscar_nome_cliente(tb_destinatario_cnpj.Text);
                }
                else
                {
                    form_localiza_cliente cli = new form_localiza_cliente(false, "");
                    try
                    {
                        cli.cnpj_a_buscar = tb_destinatario_cnpj.Text;
                        cli.ShowDialog();
                    }
                    finally
                    {
                        tb_destinatario_nome.Text = cli.cliente_escolhido;
                        tb_destinatario_cnpj.Text = cli.cnpj_escolhido;
                        tb_recebedor_cnpj.Focus();
                    }
                }

            }
        }

        private void tb_recebedor_cnpj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                if (tb_recebedor_cnpj.Text.Length == 14)
                {
                    tb_recebedor_nome.Text = buscar_nome_cliente(tb_recebedor_cnpj.Text);
                }
                else
                {
                    form_localiza_cliente cli = new form_localiza_cliente(false, "");
                    try
                    {
                        cli.cnpj_a_buscar = tb_recebedor_cnpj.Text;
                        cli.ShowDialog();
                    }
                    finally
                    {
                        tb_recebedor_nome.Text = cli.cliente_escolhido;
                        tb_recebedor_cnpj.Text = cli.cnpj_escolhido;
                        bt_nova_nf.Focus();
                    }
                }
            }
        }

        private string buscar_nome_cliente(string cnpj)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT RAZAO_SOCIAL FROM CLIENTES WHERE CNPJ = '" + cnpj + "'";
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.SelectCommand = select;
                DataSet dsTabela = new DataSet();
                datTabela.Fill(dsTabela);
                fbConnection1.Close(); 
                foreach (DataRow dr in dsTabela.Tables[0].Rows)
                {
                    return dr["RAZAO_SOCIAL"].ToString();
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

        private void button2_Click(object sender, EventArgs e)
        {
            excluir(false);

        }

        private void excluir(bool _excluir)
        {
            if (tb_protocolo_autorizacao.Text == "" && tb_recibo.Text == "")
            {
                if (_excluir || DialogResult.Yes == MessageBox.Show("O registro será excluído permanentemente, tem certeza?",
                   "Confirma a exclusão?", MessageBoxButtons.YesNo))
                {
                    try
                    {
                        this.datCte_frete_composicao.DeleteCommand.CommandText =
                            "DELETE FROM CTE_FRETE_COMPOSICAO WHERE COD_CTE_CFC = '" + tb_cod.Text + "'";
                        this.fbConnection1.Open();
                        this.datCte_frete_composicao.DeleteCommand.Connection = fbConnection1;
                        this.datCte_frete_composicao.DeleteCommand.ExecuteNonQuery();
                        this.fbConnection1.Close(); 

                        this.datCte_notas_fiscais.DeleteCommand.CommandText =
                            "DELETE FROM CTE_NOTAS_FISCAIS WHERE COD_CTE_CNF = '" + tb_cod.Text + "'";
                        this.fbConnection1.Open();
                        this.datCte_notas_fiscais.DeleteCommand.Connection = fbConnection1;
                        this.datCte_notas_fiscais.DeleteCommand.ExecuteNonQuery();
                        this.fbConnection1.Close(); 

                        this.datFatura_cte.DeleteCommand.CommandText =
                            "DELETE FROM FATURA_CTE WHERE COD_CTE_FATURA_CTE = '" + tb_cod.Text + "'";
                        this.fbConnection1.Open();
                        this.datFatura_cte.DeleteCommand.Connection = fbConnection1;
                        this.datFatura_cte.DeleteCommand.ExecuteNonQuery();
                        this.fbConnection1.Close(); 

                        this.datCte.DeleteCommand.CommandText =
                           "DELETE FROM CTE WHERE COD_CTE = '" + tb_cod.Text + "'";
                        this.fbConnection1.Open();
                        this.datCte.DeleteCommand.Connection = fbConnection1;
                        this.datCte.DeleteCommand.ExecuteNonQuery();
                        this.fbConnection1.Close(); 

                        dsCte.Clear();
                        dsCte_frete_composicao.Clear();
                        dsCte_notas_fiscais.Clear();
                        dsFatura_cte.Clear();


                    }
                    catch (Exception a)
                    {
                        fbConnection1.Close(); 
                        MessageBox.Show(a.ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("Impossível excluir, CTe já foi autorizado ou enviado");

            }
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            if (tb_chave_acesso_nfe.Text.Trim() == "")
            {
                int cod_seguranca = 13;
                string _msgResultado, _cCt, _cDv, _chaveCte;
                int busca_chave = util.CriaChaveCTeNovo("35", Convert.ToDateTime(tb_data_emissao.Text).ToString("yy"),
                    Convert.ToDateTime(tb_data_emissao.Text).ToString("MM"), tb_cnpj_emitente.Text, "57", "0", tb_n_cte.Text, "1",
                    cod_seguranca.ToString(), out _msgResultado, out _cCt, out _cDv, out _chaveCte);
                if (busca_chave == 0)
                {
                    tb_chave_acesso_nfe.Text = _chaveCte;
                }
            }


            try
            {
                string razao_social_empresa = "", nome_fantasia_empresa = "", cnpj_empresa = "", ie_empresa = "", im_empresa = "", cnae_empresa = "", endereco_empresa = "", n_endereco_empresa = "",
                            complemento_empresa = "", bairro_empresa = "", cidade_empresa = "", estado_empresa = "", cep_empresa = "", telefone_empresa = "", cod_cidade_empresa = "", pais_empresa = "",
                            cod_pais_empresa = "", licenca_dll_nfe_empresa = "", nome_certificado_nfe_empresa = "", assunto_nfe_email_empresa = "", smtp_nfe_empresa = "", email_nfe_empresa = "",
                            senha_email_nfe_empresa = "", logotipo_empresa = "", proxy_empresa = "", usuario_proxy_empresa = "", senha_proxy_empresa = "", crt_empresa = "", rntrc_empresa = "", serie_nf_empresa = "",
                         serie_cte_empresa = "", porta_email = "";
                detectar_dados_empresa(tb_cnpj_emitente.Text, out razao_social_empresa, out nome_fantasia_empresa, out cnpj_empresa, out ie_empresa, out im_empresa, out cnae_empresa, out endereco_empresa, out n_endereco_empresa,
                        out complemento_empresa, out bairro_empresa, out cidade_empresa, out estado_empresa, out cep_empresa, out telefone_empresa, out cod_cidade_empresa, out pais_empresa,
                        out cod_pais_empresa, out licenca_dll_nfe_empresa, out nome_certificado_nfe_empresa, out assunto_nfe_email_empresa, out smtp_nfe_empresa, out email_nfe_empresa,
                        out senha_email_nfe_empresa, out logotipo_empresa, out proxy_empresa, out usuario_proxy_empresa, out senha_proxy_empresa, out crt_empresa, out rntrc_empresa, out serie_nf_empresa, out serie_cte_empresa, out porta_email);
                string proxy = proxy_empresa;
                string usuario = usuario_proxy_empresa;
                string senha = senha_proxy_empresa;
                string licenca = licenca_dll_nfe_empresa;
                string nomeCertificado = nome_certificado_nfe_empresa;

                string _msgDados, _msgRetWS, _msgResultado;
                string procInut;
                string ano = Convert.ToDateTime(tb_data_emissao.Text).ToString("yy");
                int consulta = util.InutilizaNroCT(estado_empresa, estado_empresa, 1, nome_certificado_nfe_empresa, "3.00",
                    out _msgDados, out _msgRetWS, out _msgResultado, out procInut, cod_cidade_empresa.Remove(2),
                    ano, cnpj_empresa, "57", serie_cte_empresa, tb_n_cte.Text, tb_n_cte.Text,
                    tb_motivo_cancelamento.Text, proxy, usuario, senha, licenca);

                if (consulta == 102)
                {
                    salvar_na_pasta(procInut, @"c:\\evolucao\\CTE\INUTILIZADAS\CTE" + tb_chave_acesso_nfe.Text + ".xml");
                    tb_status_nfe.Text = "CTe Inutilizada";
                    atualizar(true);
                    verificar_cores();
                    try
                    {
                        update_coluna_xml_inut(procInut, tb_cod.Text);
                    }
                    catch { }
                }
                else
                {
                    MessageBox.Show(consulta.ToString() + " " + _msgResultado);
                    salvar_na_pasta(_msgDados, @"c:\\evolucao\\CTE\INUTILIZADAS\CTE" + tb_chave_acesso_nfe.Text + ".xml");
                }

            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            enviar_email();
        }

        private void cbFrete_SelectedValueChanged(object sender, EventArgs e)
        {
            verificar_frete();
        }

        private void verificar_frete()
        {
            try
            {
                if (cbFrete.Text[0].ToString() == "1")
                {
                    tb_tomador_cnpj.Text = tb_destinatario_cnpj.Text;
                    tb_tomador_nome.Text = tb_destinatario_nome.Text;
                }
                else
                {
                    if (cbFrete.Text[0].ToString() == "0")
                    {
                        tb_tomador_cnpj.Text = tb_remetente_cnpj.Text;
                        tb_tomador_nome.Text = tb_remetente_nome.Text;
                    }
                }

                //SE FOR CLIENTE NESVALE (NIVALDO)
                if ((tb_tomador_cnpj.Text == "61116331009647") && (cnpj_empresa_emissora == "13438952000133"))
                    tb_tomador_cnpj.Text = "61116331000186";
            }
            catch { }

        }

        private void tb_chave_a_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            // {
            //    importar_chave();
            //    tb_chave_a_buscar.Text = "";
            //}
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                string razao_social_empresa = "", nome_fantasia_empresa = "", cnpj_empresa = "", ie_empresa = "", im_empresa = "", cnae_empresa = "", endereco_empresa = "", n_endereco_empresa = "",
                           complemento_empresa = "", bairro_empresa = "", cidade_empresa = "", estado_empresa = "", cep_empresa = "", telefone_empresa = "", cod_cidade_empresa = "", pais_empresa = "",
                           cod_pais_empresa = "", licenca_dll_nfe_empresa = "", nome_certificado_nfe_empresa = "", assunto_nfe_email_empresa = "", smtp_nfe_empresa = "", email_nfe_empresa = "",
                           senha_email_nfe_empresa = "", logotipo_empresa = "", proxy_empresa = "", usuario_proxy_empresa = "", senha_proxy_empresa = "", crt_empresa = "", rntrc_empresa = "", serie_nf_empresa = "",
                        serie_cte_empresa = "", porta_email = "";
                detectar_dados_empresa(tb_cnpj_emitente.Text, out razao_social_empresa, out nome_fantasia_empresa, out cnpj_empresa, out ie_empresa, out im_empresa, out cnae_empresa, out endereco_empresa, out n_endereco_empresa,
                        out complemento_empresa, out bairro_empresa, out cidade_empresa, out estado_empresa, out cep_empresa, out telefone_empresa, out cod_cidade_empresa, out pais_empresa,
                        out cod_pais_empresa, out licenca_dll_nfe_empresa, out nome_certificado_nfe_empresa, out assunto_nfe_email_empresa, out smtp_nfe_empresa, out email_nfe_empresa,
                        out senha_email_nfe_empresa, out logotipo_empresa, out proxy_empresa, out usuario_proxy_empresa, out senha_proxy_empresa, out crt_empresa, out rntrc_empresa, out serie_nf_empresa, out serie_cte_empresa, out porta_email);

                string proxy = proxy_empresa;
                string usuario = usuario_proxy_empresa;
                string senha = senha_proxy_empresa;
                string licenca = licenca_dll_nfe_empresa;
                string nomeCertificado = nome_certificado_nfe_empresa;

                string arquivo = "";
                //lendo XML
                bool arquivo_ok = false;
                string caminho = @"c:\\evolucao\\CTE\ASSINADAS\CTE" + tb_chave_acesso_nfe.Text + ".xml";
                StreamReader fileStream = new StreamReader(caminho);
                string fileContent = fileStream.ReadToEnd();
                Encoding fileEncoding = fileStream.CurrentEncoding;
                fileStream.Close();
                Encoding unicode = Encoding.Unicode;

                Encoding ansi = Encoding.GetEncoding(1252);

                Byte[] utf8Bytes = unicode.GetBytes(fileContent);

                Byte[] ansiBytes = Encoding.Convert(unicode, ansi, utf8Bytes);

                string ansiContent = ansi.GetString(ansiBytes);
                arquivo_ok = true;

                /*
                if (System.IO.File.Exists(caminho))
                {
                    StreamReader objReader = new StreamReader(caminho);
                    ArrayList arrText = new ArrayList();
                    arquivo = objReader.ReadToEnd();
                    objReader.Close();
                    arquivo_ok = true;
                }
                else
                {
                    /*
                    try
                    {
                        FbCommand comando = new FbCommand();
                        comando.Connection = fbConnection1;
                        comando.CommandText =
                            "SELECT XML_ASSINADO FROM CTE WHERE COD_CTE = '" + tb_cod.Text + "'";
                        fbConnection1.Open();
                        FbDataReader reader = comando.ExecuteReader();
                        string texto = "";
                        while (reader.Read())
                        {
                            texto = reader[0].ToString();
                            if (texto != "")
                            {
                                arquivo_ok = true;
                            }
                        }
                    }
                    catch
                    {
                        fbConnection1.Close(); 
                    }
                    
                    //@"\\10.3.3.4\nfe\xml\" + data_emissao.ToString("MM")
                    caminho = @"\\10.3.3.4\ASSINADAS\CTE" + tb_n_cte.Text + ".xml";
                    if (System.IO.File.Exists(caminho))
                    {
                        StreamReader objReader = new StreamReader(caminho);
                        ArrayList arrText = new ArrayList();
                        arquivo = objReader.ReadToEnd();
                        objReader.Close();
                        arquivo_ok = true;
                    }
                }
                    */

                if (arquivo_ok)
                {
                    string procCTe, nroProtocolo, dAutorizacao, _msgDados, _msgRetWS, _msgResultado;
                    string cancelamento;
                    string n_recibo = tb_recibo.Text;
                    int resultado;

                    procCTe = util.CriaProcCTe(estado_empresa, ref ansiContent, out nroProtocolo, out cancelamento, out resultado,
                        nome_certificado_nfe_empresa, out _msgResultado, proxy, usuario, senha);

                    if (resultado == 6201)
                    {
                        salvar_na_pasta(procCTe, @"c:\\evolucao\\CTE\AUTORIZADAS\CTE" + tb_chave_acesso_nfe.Text + ".xml");
                        //salvar_na_pasta(procCTe, @"T:\AUTORIZADAS\CTE" + tb_chave_acesso_nfe.Text + ".xml");
                        tb_status_nfe.Text = "CTe Autorizada";
                        tb_protocolo_autorizacao.Text = nroProtocolo;
                        try
                        {
                            update_coluna_xml_aut(procCTe, tb_cod.Text);
                        }
                        catch { }
                        atualizar(true);
                        verificar_cores();
                        try
                        {
                            imprimir_cte();
                        }
                        finally
                        {
                            //enviar_email();
                        }
                    }
                    else
                    {
                        if (resultado == 6216)
                        {
                            salvar_na_pasta(procCTe, @"c:\\evolucao\\CTE\CANCELADAS\CTE" + tb_chave_acesso_nfe.Text + ".xml");
                            salvar_na_pasta(procCTe, @"T:\CANCELADAS\CTE" + tb_chave_acesso_nfe.Text + ".xml");
                            tb_status_nfe.Text = "CTe Cancelada";
                            tb_protocolo_autorizacao.Text = nroProtocolo;
                            try
                            {
                                update_coluna_xml_canc(procCTe, tb_cod.Text);
                            }
                            catch { }
                            atualizar(false);
                            verificar_cores();
                        }
                        else
                        {
                            MessageBox.Show(resultado.ToString() + " " + _msgResultado);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Arquivo Assinado não encontrado");
                }

            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
            }
        }

        private void tb_expedidor_cnpj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                if (tb_expedidor_cnpj.Text.Length == 14)
                {
                    tb_expedidor_nome.Text = buscar_nome_cliente(tb_expedidor_cnpj.Text);
                }
                else
                {
                    form_localiza_cliente cli = new form_localiza_cliente(false, "");
                    try
                    {
                        cli.cnpj_a_buscar = tb_expedidor_cnpj.Text;
                        cli.ShowDialog();
                    }
                    finally
                    {
                        tb_expedidor_nome.Text = cli.cliente_escolhido;
                        tb_expedidor_cnpj.Text = cli.cnpj_escolhido;
                        bt_nova_nf.Focus();
                    }
                }
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            tb_observacoes.Text = "";
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            string proxCte = "", atual;
            if (tb_n_cte.Text.Trim() != "")
            {
                try
                {
                    atual = tb_n_cte.Text;
                    FbCommand prox = new FbCommand();
                    prox.CommandText =
                        "SELECT FIRST(1) N_CTE FROM CTE WHERE N_CTE > '" + atual + "' AND EMITENTE_CNPJ_CTE = '" + cnpj_empresa_emissora + "' " +
                        "ORDER BY N_CTE";
                    prox.Connection = fbConnection1;
                    fbConnection1.Open();
                    FbDataAdapter datTabela = new FbDataAdapter();
                    datTabela.SelectCommand = prox;
                    DataSet dsTabela = new DataSet();
                    datTabela.Fill(dsTabela);
                    fbConnection1.Close(); 
                    foreach (DataRow dr in dsTabela.Tables[0].Rows)
                    {
                        proxCte = dr[0].ToString();
                    }
                    if (proxCte.Trim() == "")
                    {
                        MessageBox.Show("Este é o ultimo CTE");
                    }
                    else
                    {
                        selecionar_cte(proxCte, cnpj_empresa_emissora);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    fbConnection1.Close(); 
                }
                if (tb_func.Text.Trim() != "")
                {
                    if (funcionario_emissor != tb_func.Text && funcionario_emissor != "1")
                    {
                        desabilitaBotoes(this);
                    }
                    else
                    {
                        if (button4.Enabled == false)
                        {
                            abilitaBotoes(this);
                        }
                    }
                }
                else
                {
                    if (button4.Enabled == false)
                    {
                        abilitaBotoes(this);
                    }
                }
            }
            else
            {
                MessageBox.Show("Abra um CTE antes de procurar o próximo");
            }
        }

        private void btAnterior_Click(object sender, EventArgs e)
        {
            string proxCte = "", atual;
            if (tb_n_cte.Text.Trim() != "")
            {
                try
                {
                    atual = tb_n_cte.Text;
                    FbCommand prox = new FbCommand();
                    prox.CommandText =
                        "SELECT FIRST(1) N_CTE FROM CTE WHERE N_CTE < '" + atual + "' AND EMITENTE_CNPJ_CTE = '" + cnpj_empresa_emissora + "' " +
                        "ORDER BY N_CTE DESC";
                    prox.Connection = fbConnection1;
                    fbConnection1.Open();
                    FbDataAdapter datTabela = new FbDataAdapter();
                    datTabela.SelectCommand = prox;
                    DataSet dsTabela = new DataSet();
                    datTabela.Fill(dsTabela);
                    fbConnection1.Close(); 
                    foreach (DataRow dr in dsTabela.Tables[0].Rows)
                    {
                        proxCte = dr[0].ToString();
                    }
                    if (proxCte.Trim() == "")
                    {
                        MessageBox.Show("Este é o primeiro CTE");
                    }
                    else
                    {
                        selecionar_cte(proxCte, cnpj_empresa_emissora);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    fbConnection1.Close(); 
                }
                if (tb_func.Text.Trim() != "")
                {
                    if (funcionario_emissor != tb_func.Text && funcionario_emissor != "1")
                    {
                        desabilitaBotoes(this);
                    }
                    else
                    {
                        if (button4.Enabled == false)
                        {
                            abilitaBotoes(this);
                        }
                    }
                }
                else
                {
                    if (button4.Enabled == false)
                    {
                        abilitaBotoes(this);
                    }
                }
            }
            else
            {
                MessageBox.Show("Abra um CTE antes de procurar o próximo");
            }
        }
        private void desabilitaBotoes(Control a)
        {
            foreach (Control c in a.Controls)
            {
                if (c is Button)
                {
                    if (c.Name.ToString() != "button3" && c.Name.ToString() != "button1" && c.Name.ToString() != "btAnterior" && c.Name.ToString() != "btnProximo" &&
                         c.Name.ToString() != "bt_imprimirNFe" && c.Name.ToString() != "bt_cancelarNFe" && c.Name.ToString() != "button5" && c.Name.ToString() != "button16" &&
                         c.Name.ToString() != "button6" && c.Name.ToString() != "button8" && c.Name.ToString() != "button9" && c.Name.ToString() != "button10" && c.Name.ToString() != "button21")
                    {
                        c.Enabled = false;
                    }
                }
                if (c.HasChildren)
                {
                    desabilitaBotoes(c);
                }
            }
        }
        private void desabilitaBotoesDetalhada(Control a)
        {
            foreach (Control c in a.Controls)
            {
                if (c is Button)
                {
                    c.Enabled = false;
                }
                if (c.HasChildren)
                {
                    desabilitaBotoesDetalhada(c);
                }
            }
        }
        private void abilitaBotoes(Control a)
        {
            foreach (Control c in a.Controls)
            {
                if (c is Button)
                {
                    c.Enabled = true;
                }
                if (c.HasChildren)
                {
                    abilitaBotoes(c);
                }
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            form_consulta_html_captcha consulta = new form_consulta_html_captcha();
            consulta.chave = tb_chave_a_buscar.Text;
            try
            {
                consulta.ShowDialog();
            }
            finally
            {
                buscar_dados_html("c:\\evolucao\\pagina.csv");
            }
            tb_chave_a_buscar.Text = "";

        }

        private void buscar_dados_html(string caminho)
        {
            DataTable dataTable = new DataTable();
            try
            {
                StreamWriter swrArquivo = new StreamWriter(@"c:\\evolucao\\schema.ini");

                // Monta o cabeçalho
                swrArquivo.WriteLine("[pagina.CSV]");
                swrArquivo.WriteLine("ColNameHeader=False");
                swrArquivo.WriteLine("CharacterSet=ANSI");
                swrArquivo.WriteLine("Format=Delimited(;)");

                swrArquivo.Close();


                string pathOnly = Path.GetDirectoryName(caminho);
                string fileName = Path.GetFileName(caminho);

                string sql = @"SELECT * FROM [" + fileName + "]";

                using (OleDbConnection connection = new OleDbConnection(
                          @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + pathOnly +
                          ";Extended Properties=\"Text;FMT=Delimited(;);HDR=Yes\""))
                using (OleDbCommand command = new OleDbCommand(sql, connection))

                using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
                {
                    dataTable.Locale = CultureInfo.CurrentCulture;
                    adapter.Fill(dataTable);
                }

                DataTable correto = new DataTable();
                correto = inverter_data(dataTable);




                //inserindo/atualizando remetente
                DataRow dr = correto.Rows[0];

                try
                {
                    verificar_se_cliente_ja_existe_html(retirar_caracteres(dr["CNPJ2"].ToString()).Replace(".", ""),
                        correto, "REMETENTE");
                    tb_remetente_nome.Text = dr["Nome/Raz?oSocial2"].ToString();
                    tb_remetente_nome.Text = buscarRazao(retirar_caracteres(dr["CNPJ2"].ToString()).Replace(".", ""));
                    tb_remetente_cnpj.Text = retirar_caracteres(dr["CNPJ2"].ToString()).Replace(".", "");

                    tb_tomador_nome.Text = dr["Nome/Raz?oSocial2"].ToString();
                    tb_tomador_nome.Text = buscarRazao(retirar_caracteres(dr["CNPJ2"].ToString()).Replace(".", ""));
                    tb_tomador_cnpj.Text = retirar_caracteres(dr["CNPJ2"].ToString()).Replace(".", "");
                }
                catch { }

                //inserindo/atualizando destinatario
                try
                {
                    verificar_se_cliente_ja_existe_destinatario_html(retirar_caracteres(dr["CNPJ3"].ToString()).Replace(".", ""),
                       correto, "DESTINAT?RIO");
                    tb_destinatario_nome.Text = dr["Nome/Raz?osocial3"].ToString();
                    tb_destinatario_nome.Text = buscarRazao(retirar_caracteres(dr["CNPJ3"].ToString()).Replace(".", ""));
                    tb_destinatario_cnpj.Text = retirar_caracteres(dr["CNPJ3"].ToString()).Replace(".", "");
                    //tb_recebedor_nome.Text = dr_destinatario["xNome"].ToString();
                    // tb_recebedor_cnpj.Text = dr_destinatario["CNPJ"].ToString();
                }
                catch
                {
                    verificar_se_cliente_ja_existe_destinatario_html(retirar_caracteres(dr["CPF"].ToString()).Replace(".", ""),
                       correto, "DESTINAT?RIO");
                    tb_destinatario_nome.Text = dr["Nome/Raz?osocial3"].ToString();
                    tb_destinatario_nome.Text = buscarRazao(retirar_caracteres(dr["CPF"].ToString()).Replace(".", ""));
                    tb_destinatario_cnpj.Text = retirar_caracteres(dr["CPF"].ToString()).Replace(".", "");
                    //tb_recebedor_nome.Text = dr_destinatario["xNome"].ToString();
                    // tb_recebedor_cnpj.Text = dr_destinatario["CNPJ"].ToString();

                }
                //inserindo/buscando_dados do transporte
                /*
                string volumes = "0";
                string peso = "0";

                try
                {
                    volumes = "0"; //dr["qVol"].ToString();
                    peso = "0";// Convert.ToDouble(dr_vol["pesoB"].ToString().Replace(".", ",")).ToString().Replace(",", ".");
                }
                catch { }
                */
                double volumes = 0;
                double peso = 0;
                double vol = 0;
                double p = 0;
                try
                {

                    try
                    {
                        try
                        {
                            vol = Convert.ToDouble(dr["Quantidade"].ToString().Replace(".", ","));
                        }
                        catch { vol = 0; }
                        try
                        {
                            p = Convert.ToDouble(dr["PesoBruto"].ToString().Replace(".", ","));
                        }
                        catch { p = 0; }
                    }
                    catch { }
                    volumes = vol;
                    peso = p;
                }
                catch { }

                //inserindo/atualizando transportadora
                try
                {
                    string cnpjTransp = retirar_caracteres(dr["CNPJ4"].ToString()).Replace(".", "");
                    try
                    {
                        if (cnpjTransp != cnpj_empresa_emissora)
                        {
                            verificar_se_transportadora_ja_existe_html(cnpjTransp, correto);
                            tb_recebedor_nome.Text = dr["Raz?oSocial/Nome"].ToString();
                            tb_recebedor_nome.Text = buscarRazao(cnpjTransp);
                            tb_recebedor_cnpj.Text = cnpjTransp;
                        }
                    }
                    catch
                    {
                        verificar_se_transportadora_ja_existe_html(cnpjTransp, correto);
                        tb_recebedor_nome.Text = dr["Raz?oSocial/Nome"].ToString();
                        tb_recebedor_nome.Text = buscarRazao(cnpjTransp);
                        tb_recebedor_cnpj.Text = cnpjTransp;
                    }

                }
                catch { }
                //valor de mercado
                string valor_nota = "";
                string data_emi = dr[7].ToString().Substring(0, 10);


                valor_nota = dr["ValorTotaldaNFe"].ToString().Replace(".", "");
                /* retirado em 15/01/2016 pedido Ney
                if (tb_tomador_cnpj.Text == "72909146000165" ||
                    tb_tomador_cnpj.Text == "46690038000134" ||
                    tb_tomador_cnpj.Text == "56415631000126")
                {
                    valor_nota = dr["ValorTotaldosProdutos"].ToString().Replace(".", "");
                }
               */

                //numero nota

                inserir_notas_envolvidas(dr["N?mero"].ToString(), valor_nota, volumes.ToString().Replace(".", "").Replace(",", "."),
                        peso.ToString().Replace(".", "").Replace(",", "."), retirar_caracteres(dr["ChavedeAcesso"].ToString()).Replace(".", "").Replace(" ", ""), data_emi);
                selecionar_nfs_do_cte();

                somar_valores_nf();
                //dados adicionais
                string dados_adicionais = "";

                try
                {

                    tb_observacoes.Text = dr["Descri??o1"].ToString();
                    if (tb_observacoes.Text.Length > 500)
                    {
                        tb_observacoes.Text = tb_observacoes.Text.Replace(" ", "");
                        if (tb_observacoes.Text.Length > 500)
                        {
                            tb_observacoes.Text = tb_observacoes.Text.Remove(500);
                        }

                    }

                }
                catch { }

                //exceções
                if (tb_tomador_nome.Text.Contains("SAKATA"))
                {
                    tb_mercadoria.Text = "SEMENTES";
                    tb_cfop.Text = "5353";
                }
                if (tb_tomador_nome.Text.Contains("JBACUS") || tb_tomador_nome.Text.Contains("HORTEC") ||
                    tb_tomador_nome.Text.Contains("MULTIGRAMA") || tb_tomador_nome.Text.Contains("BEJO SEMENTES") ||
                    tb_tomador_nome.Text.Contains("ARENA SOCIETY") || tb_tomador_nome.Text.Contains("BELLA AZUL") ||
                    tb_tomador_nome.Text.Contains("PALANI") || tb_tomador_nome.Text.Contains("ZANESCO"))
                {
                    tb_cfop.Text = "5353";
                }

                composicao_preco(true);
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
            }
        }

        private void verificar_se_transportadora_ja_existe_html(string cnpj, DataTable ds)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT COD_CLIENTE FROM CLIENTES WHERE CNPJ = '" + cnpj + "'";
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.SelectCommand = select;
                DataSet dsTabela = new DataSet();
                datTabela.Fill(dsTabela);
                fbConnection1.Close();
                DataRow dr_dados = ds.Rows[0];
                bool registro_existe = false;
                string pessoa_fisica = "null";

                if (cnpj.Length != 14)
                    pessoa_fisica = "'1'";
                //TRATANDO CAMPO VAZIOS
                string _razao_social = "null", _ie = "null", _endereco = "null",
                    _cidade = "null",
                    _estado = "null";
                try
                {
                    _razao_social = "'" + dr_dados["RazaoSocial/Nome"].ToString() + "'";
                }
                catch { }

                try
                {
                    _ie = "'" + dr_dados["InscricaoEstadual4"].ToString() + "'";
                }
                catch { }
                try
                {
                    _endereco = "'" + dr_dados["EnderecoCompleto"].ToString() + "'";
                }
                catch { }
                try
                {
                    _cidade = "'" + dr_dados["Municipio2"].ToString() + "'";
                }
                catch { }
                try
                {
                    _estado = "'" + dr_dados["UF4"].ToString() + "'";
                }
                catch { }


                foreach (DataRow dr in dsTabela.Tables[0].Rows)
                {
                    registro_existe = true;
                    //já existe então não faz nada
                }
                if (!registro_existe)
                {
                    MessageBox.Show("Será necessário completar o cadastro da transportadora");
                    try
                    {
                        string _cnpj = "";
                        try
                        {
                            _cnpj = dr_dados["CNPJ4"].ToString();
                        }
                        catch
                        {
                            _cnpj = dr_dados["CNPJ4"].ToString();
                        }
                        FbCommand insert = new FbCommand();
                        insert.Connection = fbConnection1;
                        fbConnection1.Open();
                        insert.CommandText =
                            "INSERT INTO CLIENTES (CNPJ, RAZAO_SOCIAL, " +
                            "IE, ENDERECO, CIDADE, ESTADO) " +
                            "VALUES ('" + _cnpj + "'," + _razao_social + "," +
                            _ie + "," + _endereco + "," +
                            _cidade + "," + _estado + ")";
                        FbDataAdapter datInsert = new FbDataAdapter();
                        datInsert.InsertCommand = insert;
                        datInsert.InsertCommand.ExecuteNonQuery();
                        fbConnection1.Close();
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
        private string buscarRazao(string cnpj)
        {
            string razao = "";
            try
            {
                FbCommand selectCte = new FbCommand();
                selectCte.CommandText =
                    "SELECT RAZAO_SOCIAL FROM CLIENTES WHERE CNPJ = '" + cnpj + "'";
                selectCte.Connection = fbConnection1;
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.SelectCommand = selectCte;
                fbConnection1.Open();
                DataSet dsTabela = new DataSet();
                datTabela.Fill(dsTabela);
                fbConnection1.Close();
                DataRow dr = dsTabela.Tables[0].Rows[0];
                razao = dr[0].ToString();
                return razao;
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.Message, "Erro Buscar Razão");
                return "";
            }
        }
        private void inserir_notas_envolvidas(string n_nf, string valor_nota,
             string volume, string peso, string chave)
        {
            try
            {

                FbCommand insert = new FbCommand();
                insert.Connection = fbConnection1;
                fbConnection1.Open();
                insert.CommandText =
                    "INSERT INTO CTE_NOTAS_FISCAIS (N_NF_CNF, CHAVE_NF_CNF, COD_CTE_CNF, VALOR_NOTA_CNF, " +
                    "VOLUMES_NOTA_CNF, PESO_NOTA_CNF, DATA_EMISSAO_NF_CNF) VALUES " +
                    "('" + n_nf + "','" + chave + "','" + tb_cod.Text + "','" + valor_nota.Replace(".", "").Replace(",", ".") + "','" +
                    volume + "','" + peso + "')";
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

        private DataTable inverter_data(DataTable dataTable)
        {
            DataTable table = new DataTable("MyData");
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                DataRow dr = dataTable.Rows[i];
                DataColumn column = new DataColumn();
                column.ColumnName = dr[0].ToString();
                table.Columns.Add(column);
            }

            int rowNumber = 0;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                try
                {
                    DataRow dr = dataTable.Rows[i];
                    table.Rows.Add();
                    table.Rows[0][i] = dr[1].ToString();
                }
                catch { }
            }
            return table;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private bool proxCte()
        {
            string proxCte = "", atual;
            if (tb_n_cte.Text.Trim() != "")
            {
                try
                {
                    atual = tb_n_cte.Text;
                    FbCommand prox = new FbCommand();
                    prox.CommandText =
                        "SELECT FIRST(1) N_CTE FROM CTE WHERE N_CTE > '" + atual + "' AND EMITENTE_CNPJ_CTE = '" + cnpj_empresa_emissora + "' " +
                        "ORDER BY N_CTE";
                    prox.Connection = fbConnection1;
                    fbConnection1.Open();
                    FbDataAdapter datTabela = new FbDataAdapter();
                    datTabela.SelectCommand = prox;
                    DataSet dsTabela = new DataSet();
                    datTabela.Fill(dsTabela);
                    fbConnection1.Close(); 
                    foreach (DataRow dr in dsTabela.Tables[0].Rows)
                    {
                        proxCte = dr[0].ToString();
                    }
                    if (proxCte.Trim() == "")
                    {
                        MessageBox.Show("Este é o ultimo CTE");
                        return false;
                    }
                    else
                    {
                        selecionar_cte(proxCte, cnpj_empresa_emissora);
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    fbConnection1.Close(); 
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Abra um CTE antes de procurar o próximo");
                return false;
            }


        }
        private void button27_Click(object sender, EventArgs e)
        {
            while (proxCte())
            {
                gerarXml(false);
            }

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvFatura_cte_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button28_Click(object sender, EventArgs e)
        {
            form_cte_carta_correcao_tag tags = new form_cte_carta_correcao_tag();
            try
            {
                tags.n_cte = tb_n_cte.Text;
                tags.cod_cte = tb_cod.Text;
                tags.ShowDialog();
            }
            finally
            {
                if (tags.xml_retorno != "")
                {
                    tb_texto_correcao.Text = tags.xml_retorno;
                    if (tb_protocolo_autorizacao.Text != "")
                    {
                        string razao_social_empresa = "", nome_fantasia_empresa = "", cnpj_empresa = "", ie_empresa = "", im_empresa = "", cnae_empresa = "", endereco_empresa = "", n_endereco_empresa = "",
                        complemento_empresa = "", bairro_empresa = "", cidade_empresa = "", estado_empresa = "", cep_empresa = "", telefone_empresa = "", cod_cidade_empresa = "", pais_empresa = "",
                        cod_pais_empresa = "", licenca_dll_nfe_empresa = "", nome_certificado_nfe_empresa = "", assunto_nfe_email_empresa = "", smtp_nfe_empresa = "", email_nfe_empresa = "",
                        senha_email_nfe_empresa = "", logotipo_empresa = "", proxy_empresa = "", usuario_proxy_empresa = "", senha_proxy_empresa = "", crt_empresa = "", rntrc_empresa = "", porta_email = "", ssl_email = "", serie_nf_empresa = "", serie_cte_empresa = "";

                        detectar_dados_empresa(tb_cnpj_emitente.Text, out razao_social_empresa, out nome_fantasia_empresa, out cnpj_empresa, out ie_empresa, out im_empresa, out cnae_empresa, out endereco_empresa, out n_endereco_empresa,
                            out complemento_empresa, out bairro_empresa, out cidade_empresa, out estado_empresa, out cep_empresa, out telefone_empresa, out cod_cidade_empresa, out pais_empresa,
                            out cod_pais_empresa, out licenca_dll_nfe_empresa, out nome_certificado_nfe_empresa, out assunto_nfe_email_empresa, out smtp_nfe_empresa, out email_nfe_empresa,
                            out senha_email_nfe_empresa, out logotipo_empresa, out proxy_empresa, out usuario_proxy_empresa, out senha_proxy_empresa, out crt_empresa, out rntrc_empresa, out serie_nf_empresa, out serie_cte_empresa, out porta_email);

                        int ambiente = 1;

                        string proxy = proxy_empresa;
                        string usuario = usuario_proxy_empresa;
                        string senha = senha_proxy_empresa;
                        string licenca = licenca_dll_nfe_empresa;
                        string nomeCertificado = nome_certificado_nfe_empresa;
                        string _msgCabec, _msgDados, _msgRetWS, _msgResultado;
                        string recibo = tb_recibo.Text;
                        string _dhProtocolo = "";
                        string _nroProtocolo = "";
                        string _retCancNFe = "";
                        string _cMsg = ""; string _xMsg = "";
                        int resultado;
                        int cStat = 0;
                        if (tb_sequencial_correcao.Text == "")
                            tb_sequencial_correcao.Text = "1";
                        else
                        {
                            int seq = Convert.ToInt32(tb_sequencial_correcao.Text);
                            seq++;
                            tb_sequencial_correcao.Text = seq.ToString();
                        }

                        string _dhEvento = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:sszz:00");

                        string _procNF = util.EnviaCCe("SP", ambiente, nomeCertificado, "3.00", out _msgDados, out _msgRetWS, out cStat, out _msgResultado,
                            tb_chave_acesso_nfe.Text, tb_texto_correcao.Text, 0, Convert.ToInt32(tb_sequencial_correcao.Text), _dhEvento, out _nroProtocolo,
                            out _dhProtocolo, proxy, usuario, senha, licenca);

                        if (cStat == 135)
                        {
                            gerar_xml_corrigida(_procNF);
                            //barra_status.Text = "NFe Corrigida. ";
                            atualizar(true);
                            try
                            {
                                imprimir_corrigida();
                            }
                            finally
                            {
                                //enviar_email_corrigida();
                                atualizar(true);
                            }
                        }
                        else
                        {
                            MessageBox.Show(_msgResultado, cStat.ToString());
                        }
                    }
                }
            }
        }

        private void gerar_xml_corrigida(string _procNF)
        {
            FileInfo t = new FileInfo("c:\\evolucao\\CTE\\CORRIGIDAS\\CTE   " + tb_chave_acesso_nfe.Text + " - " + tb_sequencial_correcao.Text + ".xml");
            using (StreamWriter texto = t.CreateText())
            {
                texto.WriteLine(_procNF);
            }
        }

        private void imprimir_corrigida()
        {
            try
            {
                if (tb_protocolo_autorizacao.Text == "")
                {
                    MessageBox.Show("Não esqueça de Consultar o Status da NFe");
                }
                dsCte imprimir = new dsCte();
                FbCommand comando = new FbCommand();
                comando.Connection = fbConnection1;
                comando.CommandText = "SELECT * FROM EMPRESA WHERE CNPJ_EMPRESA = '" + tb_cnpj_emitente.Text + "'";
                DataSet empresa = new DataSet();
                fbConnection1.Open();
                FbDataAdapter datEmpresa = new FbDataAdapter();
                datEmpresa.SelectCommand = comando;
                datEmpresa.Fill(imprimir.EMPRESA);
                fbConnection1.Close();

                FbCommand select = new FbCommand();
                select.CommandText =
                   "SELECT * FROM CARTA_CORRECAO_TAGS WHERE COD_CTE_CCT = '" + tb_cod.Text + "'";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                datSelect.Fill(imprimir.CARTA_CORRECAO_TAGS);
                fbConnection1.Close();

                datCte.Fill(imprimir.CTE);
                fbConnection1.Close();
                crCorrecaoCte nova_nota = new crCorrecaoCte();
                nova_nota.SetDataSource(imprimir);
                form_imprimir imprime = new form_imprimir(nova_nota);
                imprime.n_nfe_correcao = tb_n_cte.Text;
                imprime.correcao = true;
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