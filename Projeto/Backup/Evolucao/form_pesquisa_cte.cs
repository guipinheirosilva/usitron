using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.IO;
using System.Xml;

namespace Evolucao
{
    public partial class form_pesquisa_cte : Form
    {
        NFe_Util_2G.Util util2 = new NFe_Util_2G.Util();
        CTe_Util.Util util = new CTe_Util.Util();

        DataTable dtPesquisa = new DataTable();
        public string _n_cte, _cnpj_emitente, empresa_emissora;
        public string[] ctes_coletivos = new string[100];
        public int qtde_ctes_coletivos;
        public bool busca;
        public bool busca_coletiva;
        public string cod_usuario;
        public form_pesquisa_cte()
        {
            InitializeComponent();
        }

        private void form_pesquisa_cte_e_pedido_coleta_Load(object sender, EventArgs e)
        {
            acertar_acessos_usuarios();
            cbData.Checked = true;
            dtInicio.Text = DateTime.Now.AddDays(-7).ToShortDateString();
            dgvPesquisa.AutoGenerateColumns = false;
            dgvPesquisa.DataSource = dsCte.Tables["CTE"];
            selecionar();

            

            empresatoolStripStatusLabel.Text = empresa_emissora;
            cnpjtoolStripStatusLabel.Text = _cnpj_emitente;

        }

        private void acertar_acessos_usuarios()
        {
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT * FROM USUARIOS WHERE COD_USUARIO = '" + cod_usuario + "'";
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.SelectCommand = select;
                DataSet dsTabela = new DataSet();
                datTabela.Fill(dsTabela);
                fbConnection1.Close();
                foreach (DataRow dr in dsTabela.Tables[0].Rows)
                {
                    if (dr["FATURA_USUARIO"].ToString() == "1")
                    {
                        panelFaturas.Visible = true;
                        panelSeguradora.Visible = true;
                    }
                }
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void selecionar()
        {
            try
            {
                string data = "";
                string cnpj_tomador = "";
                string status = "";
                string nf = "", nf2 = "";
                if (cbData.Checked)
                    data = " AND cte.DATA_EMISSAO_CTE >= '" + Convert.ToDateTime(dtInicio.Text).ToShortDateString().Replace("/", ".") + "' AND " +
                        " cte.DATA_EMISSAO_CTE <= '" + Convert.ToDateTime(dtTermino.Text).ToShortDateString().Replace("/", ".") + "' ";
                if (cbTomador.Checked)
                    cnpj_tomador = " AND cte.TOMADOR_CNPJ_CTE = '" + tb_tomador_cnpj.Text + "' ";
                if (cbStatus.Checked)
                    status = " AND cte.STATUS_CTE = '" + comboStatus.Text + "' ";
                if (tb_n_nf.Text != "")
                {
                    nf = " INNER JOIN CTE_NOTAS_FISCAIS nf ON cte.COD_CTE = nf.COD_CTE_CNF ";
                    nf2 = " AND nf.N_NF_CNF = '" + tb_n_nf.Text + "'";

                }

                

                dsCte.Clear();
                
                datCte.SelectCommand.CommandText =
                    "SELECT * " +
                    "FROM CTE cte " + nf + " WHERE cte.EMITENTE_CNPJ_CTE LIKE '" + _cnpj_emitente + "'" + nf2 + data + cnpj_tomador + status + " ORDER BY cte.N_CTE DESC";
                datCte.SelectCommand.Connection = fbConnection1;
                fbConnection1.Open();
                datCte.SelectCommand.ExecuteNonQuery();
                datCte.Fill(CTE);
                fbConnection1.Close();
           
                cores();
                colunas();
            }
            catch(Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }

        }

        private void colunas()
        {
            //dgvPesquisa.Columns[0].Visible = false;
            //dgvPesquisa.Columns[1].Visible = false;
        }

        private void cores()
        {
            double valor_total = 0;
            for (int i = 0; i < dgvPesquisa.RowCount; i++)
            {
                if (dgvPesquisa.Rows[i].Cells["col_status"].Value.ToString().Contains("Autorizada"))
                {
                    dgvPesquisa.Rows[i].DefaultCellStyle.BackColor = Color.LimeGreen;
                    if (cbSomar.Checked)
                    {
                        try
                        {
                            valor_total = valor_total + Convert.ToDouble(dgvPesquisa.Rows[i].Cells["col_valor_total"].Value.ToString());
                        }
                        catch { }
                    }
                }
                if (dgvPesquisa.Rows[i].Cells["col_status"].Value.ToString().Contains("Cancelada"))
                {
                    dgvPesquisa.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
                if (dgvPesquisa.Rows[i].Cells["col_status"].Value.ToString().Contains("Inutilizada"))
                {
                    dgvPesquisa.Rows[i].DefaultCellStyle.BackColor = Color.Pink;
                }
                
            }
            tb_valor_total.Text = valor_total.ToString("n2");
        }

        private void dgvPesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (busca)
            {
                try
                {
                    _n_cte = dgvPesquisa.Rows[e.RowIndex].Cells["col_n_cte"].Value.ToString();
                    _cnpj_emitente = dgvPesquisa.Rows[e.RowIndex].Cells["col_cnpj_emitente"].Value.ToString();
                    this.Dispose();
                }
                catch { }
            }
            else
            {
                try
                {
                    form_cte cte = new form_cte();
                    _n_cte = dgvPesquisa.Rows[e.RowIndex].Cells["col_n_cte"].Value.ToString();
                    cte.n_cte = _n_cte;
                    cte.cnpj_empresa_emissora = dgvPesquisa.Rows[e.RowIndex].Cells["col_cnpj_emitente"].Value.ToString();
                    cte.empresa_emissora = dgvPesquisa.Rows[e.RowIndex].Cells["col_nome_emitente"].Value.ToString();
                    cte.funcionario_emissor = cod_usuario;
                    cte.Show();
                }
                finally { }
            }
        }

        private void tb_cte_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tb_cte_TextChanged_1(object sender, EventArgs e)
        {
            try
            {

                dsCte.Tables[0].DefaultView.RowFilter = "N_CTE = '" + tb_cte.Text + "'";
            }
            catch { }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsCte.Tables[0].DefaultView.RowFilter = "REMETENTE_NOME_CTE LIKE '*" + tb_remetente.Text + "*'";
            }
            catch { }
        }

        private void tb_recebedor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsCte.Tables[0].DefaultView.RowFilter = "RECEBEDOR_NOME_CTE LIKE '*" + tb_recebedor.Text + "*'";
            }
            catch { }
        }

        private void tb_tomador_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsCte.Tables[0].DefaultView.RowFilter = "TOMADOR_NOME_CTE LIKE '*" + tb_tomador.Text + "*'";
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            update_nao_faturar();
            selecionar();
        }

        private void update_nao_faturar()
        {
            try
            {
                FbCommand update = new FbCommand();
                update.Connection = fbConnection1;
                fbConnection1.Open();
                update.CommandText =
                    "UPDATE CTE SET NAO_FATURAR_CTE = '0' WHERE NAO_FATURAR_CTE = '1'";
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

        private void button21_Click(object sender, EventArgs e)
        {
            form_localiza_cliente cli = new form_localiza_cliente(false);
            try
            {
                cli.ShowDialog();
            }
            finally
            {
                tb_tomador_nome.Text = cli.cliente_escolhido;
                tb_tomador_cnpj.Text = cli.cnpj_escolhido;
            }
        }

        private void tb_tomador_cnpj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                form_localiza_cliente cli = new form_localiza_cliente(false);
                try
                {
                    cli.cnpj_a_buscar = tb_tomador_cnpj.Text;
                    cli.ShowDialog();
                }
                finally
                {
                    tb_tomador_nome.Text = cli.cliente_escolhido;
                    tb_tomador_cnpj.Text = cli.cnpj_escolhido;
                }

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dsPesquisa_cte cte = new dsPesquisa_cte();
            try
            {
                for(int i = 0; i < dgvPesquisa.Rows.Count; i++)
                {
                    try
                    {
                        cte.CTe.AddCTeRow(dgvPesquisa.Rows[i].Cells["col_tomador_nome"].Value.ToString(),
                            dgvPesquisa.Rows[i].Cells["col_tomador_cnpj"].Value.ToString(),
                            Convert.ToDouble(dgvPesquisa.Rows[i].Cells["col_valor_total"].Value.ToString()),
                            Convert.ToDateTime(dgvPesquisa.Rows[i].Cells["col_data_emissao"].Value.ToString()),
                            dgvPesquisa.Rows[i].Cells["col_status"].Value.ToString(), "",
                            dgvPesquisa.Rows[i].Cells["col_n_cte"].Value.ToString(),
                            dgvPesquisa.Rows[i].Cells["col_remetente_nome"].Value.ToString(),
                            dgvPesquisa.Rows[i].Cells["col_destinatario_nome"].Value.ToString(),
                            Convert.ToDouble(dgvPesquisa.Rows[i].Cells["col_peso"].Value.ToString()),
                            Convert.ToDouble(dgvPesquisa.Rows[i].Cells["col_valor_mercado"].Value.ToString()),
                            Convert.ToInt32(dgvPesquisa.Rows[i].Cells["col_cod_cte"].Value.ToString()));
                        try
                        {
                            FbCommand select = new FbCommand();
                            select.Connection = fbConnection1;
                            fbConnection1.Open();
                            select.CommandText =
                                "SELECT * FROM CTE_FRETE_COMPOSICAO WHERE COD_CTE_CFC = '" + dgvPesquisa.Rows[i].Cells["col_cod_cte"].Value.ToString() + "' ";
                            FbDataAdapter datTabela = new FbDataAdapter();
                            datTabela.SelectCommand = select;
                            DataSet dsTabela = new DataSet();
                            datTabela.Fill(dsTabela);
                            fbConnection1.Close();
                            foreach (DataRow dr in dsTabela.Tables[0].Rows)
                            {
                                
                                cte.CTE_FRETE_COMPOSICAO.AddCTE_FRETE_COMPOSICAORow(Convert.ToInt32(dr["COD_CFC"].ToString()),  dr["DESCRICAO_CFC"].ToString(), 
                                  Convert.ToDouble(dr["VALOR_CFC"].ToString()), Convert.ToInt32( dr["COD_CTE_CFC"].ToString()));
                            }

                        }
                        catch (Exception a)
                        {
                            fbConnection1.Close();
                            MessageBox.Show(a.ToString());
                        }
                    }
                    catch { }
                }
                string por_data = "0";
                if (cbData.Checked)
                    por_data = "1";
                cte.Informacoes.AddInformacoesRow(Convert.ToDateTime(dtInicio.Text), Convert.ToDateTime(dtTermino.Text), por_data);
                try
                {
                    FbCommand select = new FbCommand();
                    select.Connection = fbConnection1;
                    fbConnection1.Open();
                    select.CommandText =
                        "SELECT * FROM EMPRESA WHERE CNPJ_EMPRESA = '" + _cnpj_emitente + "'";
                    FbDataAdapter datTabela = new FbDataAdapter();
                    datTabela.SelectCommand = select;
                    datTabela.Fill(cte.EMPRESA);
                    fbConnection1.Close();
                }
                catch (Exception a)
                {
                    fbConnection1.Close();
                    MessageBox.Show(a.ToString());
                }

                crCte_por_cliente_detalhado relatorio = new crCte_por_cliente_detalhado();
                relatorio.SetDataSource(cte);
                form_imprimir imprime = new form_imprimir(relatorio);
                imprime.Show();

            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            salvar();
            try
            {
                string data = "";
                string cnpj_tomador = "";
                string status = "";
                if (cbData.Checked)
                    data = " AND cte.DATA_EMISSAO_CTE >= '" + Convert.ToDateTime(dtInicio.Text).ToShortDateString().Replace("/", ".") + "' AND " +
                        " cte.DATA_EMISSAO_CTE <= '" + Convert.ToDateTime(dtTermino.Text).ToShortDateString().Replace("/", ".") + "' ";
                if (cbTomador.Checked)
                    cnpj_tomador = " AND cte.TOMADOR_CNPJ_CTE = '" + tb_tomador_cnpj.Text + "' ";
                if (cbStatus.Checked)
                    status = " AND cte.STATUS_CTE = '" + comboStatus.Text + "' ";

           //SELECIONANDO CLIENTES ENVOLVIDOS
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT DISTINCT(TOMADOR_CNPJ_CTE) " +
                    "FROM CTE cte WHERE cte.EMITENTE_CNPJ_CTE = '" + _cnpj_emitente + "'" +
                    " AND (NAO_FATURAR_CTE = '0' OR NAO_FATURAR_CTE IS NULL) " +
                    data + cnpj_tomador + status + " ORDER BY cte.TOMADOR_CNPJ_CTE DESC";
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.SelectCommand = select;
                DataSet dsTabela = new DataSet();
                datTabela.Fill(dsTabela);
                fbConnection1.Close();
                foreach (DataRow dr in dsTabela.Tables[0].Rows)
                {
                    try
                    {
                        select.Connection = fbConnection1;
                        fbConnection1.Open();
                        select.CommandText =
                            "SELECT * FROM CTE cte WHERE cte.EMITENTE_CNPJ_CTE = '" + 
                            _cnpj_emitente + "'" + data + cnpj_tomador + status + 
                            " AND TOMADOR_CNPJ_CTE = '" + dr[0].ToString() + "'" + 
                            " AND (NAO_FATURAR_CTE = '0' OR NAO_FATURAR_CTE IS NULL) " +
                            " AND N_FATURA_CTE IS NULL " + 
                            " ORDER BY cte.N_CTE DESC";
                        datTabela.SelectCommand = select;
                        DataSet dsValor = new DataSet();
                        datTabela.Fill(dsValor);
                        fbConnection1.Close();
                        double valor_total = 0;
                        foreach (DataRow dr_valor in dsValor.Tables[0].Rows)
                        {
                            try
                            {
                                valor_total = valor_total + Convert.ToDouble(dr_valor["VALOR_TOTAL_CTE"].ToString());
                            }
                            catch { }
                        }
                        //INSERIR CONTA A RECEBER
                        if (valor_total > 0)
                        {
                            try
                            {
                                string _nome_cliente = "";
                                string _cod_cliente = detectar_cod_cliente(dr[0].ToString(), out _nome_cliente);
                                FbCommand insert = new FbCommand();
                                insert.Connection = fbConnection1;
                                fbConnection1.Open();
                                insert.CommandText =
                                     "INSERT INTO CONTAS_A_RECEBER (VALOR_CR, DATA_PREVISTA_CR, COD_CLIENTE_CR, " +
                           "RAZAO_CLIENTE_CR, DESCRICAO_CR, DUPLICATA_CR, CNPJ_EMITENTE_CR, CNPJ_CLIENTE_CR, " +
                           "DATA_INICIAL_PERIODO_CR, DATA_FINAL_PERIODO_CR, DATA_EMISSAO_CR) " +
                           "VALUES ('" + valor_total.ToString().Replace(".", "").Replace(",", ".") + "', '" +
                           Convert.ToDateTime(dtVencimento.Text).ToShortDateString().Replace("/", ".") +
                           "', '" + _cod_cliente + "','" + _nome_cliente +
                           "', 'REFERENTE AOS CTES DO PERIODO " + dtInicio.Text + " ATÉ " + dtTermino.Text +
                           "', '1/1','" + _cnpj_emitente + "','" + dr[0].ToString() + "','" +
                           Convert.ToDateTime(dtInicio.Text).ToShortDateString().Replace("/", ".") + "','" +
                           Convert.ToDateTime(dtTermino.Text).ToShortDateString().Replace("/", ".") + "','" +
                           DateTime.Now.ToShortDateString().Replace("/", ".") + "')";
                                datTabela.InsertCommand = insert;
                                datTabela.InsertCommand.ExecuteNonQuery();
                                fbConnection1.Close();

                                int n_fatura = buscar_ultimo_inserido();
                                //UPDATE NOS CTES
                                try
                                {
                                    FbCommand update = new FbCommand();
                                    update.Connection = fbConnection1;
                                    fbConnection1.Open();
                                    update.CommandText =
                                        "UPDATE CTE SET N_FATURA_CTE = '" + n_fatura.ToString() + "'" +
                                        "WHERE cte.EMITENTE_CNPJ_CTE = '" +
                                _cnpj_emitente + "'" + data + cnpj_tomador + status +
                                " AND TOMADOR_CNPJ_CTE = '" + dr[0].ToString() + "'" +
                                " AND (NAO_FATURAR_CTE = '0' OR NAO_FATURAR_CTE IS NULL) AND N_FATURA_CTE IS NULL";
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
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private int buscar_ultimo_inserido()
        {
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                "Select FIRST 1 COD_CR from CONTAS_A_RECEBER order by COD_CR desc";
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.SelectCommand = select;
                DataSet dsTabela = new DataSet();
                datTabela.Fill(dsTabela);
                fbConnection1.Close();
                foreach (DataRow dr in dsTabela.Tables[0].Rows)
                {
                    return Convert.ToInt32(dr[0].ToString());
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

        private string detectar_cod_cliente(string _cnpj, out string nome_cliente)
        {
            nome_cliente = "";
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT * " +
                    "FROM CLIENTES WHERE CNPJ = '" + _cnpj + "'";
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.SelectCommand = select;
                DataSet dsTabela = new DataSet();
                datTabela.Fill(dsTabela);
                fbConnection1.Close();
                foreach (DataRow dr in dsTabela.Tables[0].Rows)
                {
                    nome_cliente = dr["RAZAO_SOCIAL"].ToString();
                    return dr[0].ToString();
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
        private void salvar()
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
                }
            }
            catch (Exception a)
            {
                fbConnection1.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                dsCte.Tables[0].DefaultView.RowFilter = "N_FATURA_CTE = '*" + textBox1.Text + "*'";
            }
            catch { }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (busca_coletiva)
            {
                try
                {
                    for (int i = 0; i < dgvPesquisa.SelectedRows.Count; i++)
                    {
                        ctes_coletivos[i] = dgvPesquisa.SelectedRows[i].Cells["col_n_cte"].Value.ToString();
                        qtde_ctes_coletivos = i + 1;
                    }
                    //_cnpj_emitente = dgvPesquisa.Rows[e.RowIndex].Cells[5].Value.ToString();
                    this.Dispose(); 

                }
                catch { }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            selecionar();
        }

        private string zero_antes(int tamanho_pretendido, string valor)
        {

            int tamanho = valor.Length;
            for (int p = 0; p < tamanho_pretendido - tamanho; p++)
            {
                valor = "0" + valor;
            }
            return valor;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string caminho = @"c:\evolucao_dokinos\\seguradora\" + Convert.ToDateTime(dtInicio.Text).ToShortDateString().Replace("/", "") +
                Convert.ToDateTime(dtTermino.Text).ToShortDateString().Replace("/", "") + ".txt";
            criar_arquivo(caminho);

            string placa = "";
            if (empresa_emissora.Contains("SANTA LUZIA"))
                placa = "EFU4976";
            else
                placa = "DRL4084";
            FileInfo t = new FileInfo(caminho);
            using (StreamWriter texto = t.CreateText())
            {
                for (int i = 0; i < dgvPesquisa.Rows.Count; i++)
                {
                    string uf_inicio = "", uf_fim = "";
                    buscar_inicio_fim(dgvPesquisa.Rows[i].Cells["col_cod_cte"].Value.ToString(), out uf_inicio, out uf_fim);
                    try
                    {
                        texto.WriteLine("UN   |" + zero_antes(8, dgvPesquisa.Rows[i].Cells["col_n_cte"].Value.ToString()) + "|" + 
                            uf_inicio + "|" + uf_fim + "|" + placa + "|" +
                                Convert.ToDateTime(dgvPesquisa.Rows[i].Cells["col_data_emissao"].Value.ToString()).ToShortDateString().Replace("/","") + "|" +
                                zero_antes(9, 
                                Convert.ToDouble(dgvPesquisa.Rows[i].Cells["col_valor_mercado"].Value.ToString()).ToString("n2").Replace(".","").Replace(",","")) +
                                "|T");
                    }
                    catch { }
                }
            }
        }

        private string retirar_caracteres(string arquivo)
        {
            return arquivo.Replace("Ã", "A").Replace("Õ", "O").Replace("Ç", "C").Replace("Â", "A").Replace("Á", "A").Replace("À", "A")
                .Replace("Ô", "O").Replace("\r\n", " ").Replace("-", "").Replace("(", "").Replace(")", "").Replace("/", "").Replace("&", "e");
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
                    if (cnpj != "")
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
                            _ie = dr["IE"].ToString();
                            _xNome = retirar_caracteres(dr["RAZAO_SOCIAL"].ToString());
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
                }
                catch (Exception a)
                {
                    fbConnection1.Close();
                    MessageBox.Show(a.ToString());
                }
            }
        }


        private void buscar_inicio_fim(string cod_cte, out string uf_inicio, out string uf_fim)
        {
            uf_inicio = ""; uf_fim = "";
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT * FROM CTE WHERE COD_CTE = '" + cod_cte + "'";
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.SelectCommand = select;
                DataSet dsTabela = new DataSet();
                datTabela.Fill(dsTabela);
                fbConnection1.Close();
                foreach (DataRow dr in dsTabela.Tables[0].Rows)
                {
                    //DADOS EXPEDIDOR
                    string _expedidor_cnpj, _expedidor_cpf, _expedidor_ie, _expedidor_xNome, _expedidor_xFant_Opc, _expedidor_fone_Opc,
                        _expedidor_xLgr, _expedidor_nro, _expedidor_xCpl_Opc, _expedidor_xBairro, _expedidor_cMun, _expedidor_xMun,
                        _expedidor_CEP_Opc, _expedidor_UF, _expedidor_cPais_Opc, _expedidor_xPais_Opc, _expedidor_email_Opc;
                    buscar_dados_cliente(dr["EXPEDIDOR_CNPJ_CTE"].ToString(), out _expedidor_cnpj, out _expedidor_cpf, out _expedidor_ie, out _expedidor_xNome, out _expedidor_xFant_Opc, out _expedidor_fone_Opc, out
                _expedidor_xLgr, out _expedidor_nro, out _expedidor_xCpl_Opc, out _expedidor_xBairro, out _expedidor_cMun, out _expedidor_xMun, out
                _expedidor_CEP_Opc, out _expedidor_UF, out _expedidor_cPais_Opc, out _expedidor_xPais_Opc, out _expedidor_email_Opc);

                    //DADOS RECEBEDOR
                    string _recebedor_cnpj, _recebedor_cpf, _recebedor_ie, _recebedor_xNome, _recebedor_xFant_Opc, _recebedor_fone_Opc,
                       _recebedor_xLgr, _recebedor_nro, _recebedor_xCpl_Opc, _recebedor_xBairro, _recebedor_cMun, _recebedor_xMun,
                       _recebedor_CEP_Opc, _recebedor_UF, _recebedor_cPais_Opc, _recebedor_xPais_Opc, _recebedor_email_Opc;
                    buscar_dados_cliente(dr["RECEBEDOR_CNPJ_CTE"].ToString(), out _recebedor_cnpj, out _recebedor_cpf, out _recebedor_ie, out _recebedor_xNome, out _recebedor_xFant_Opc, out _recebedor_fone_Opc, out
                _recebedor_xLgr, out _recebedor_nro, out _recebedor_xCpl_Opc, out _recebedor_xBairro, out _recebedor_cMun, out _recebedor_xMun, out
                _recebedor_CEP_Opc, out _recebedor_UF, out _recebedor_cPais_Opc, out _recebedor_xPais_Opc, out _recebedor_email_Opc);

                    //DADOS REMETENTE
                    string _remetente_cnpj, _remetente_cpf, _remetente_ie, _remetente_xNome, _remetente_xFant_Opc, _remetente_fone_Opc,
                      _remetente_xLgr, _remetente_nro, _remetente_xCpl_Opc, _remetente_xBairro, _remetente_cMun, _remetente_xMun,
                      _remetente_CEP_Opc, _remetente_UF, _remetente_cPais_Opc, _remetente_xPais_Opc, _remetente_email_Opc;
                    buscar_dados_cliente(dr["REMETENTE_CNPJ_CTE"].ToString(), out _remetente_cnpj, out _remetente_cpf, out _remetente_ie, out _remetente_xNome, out _remetente_xFant_Opc, out _remetente_fone_Opc, out
                _remetente_xLgr, out _remetente_nro, out _remetente_xCpl_Opc, out _remetente_xBairro, out _remetente_cMun, out _remetente_xMun, out
                _remetente_CEP_Opc, out _remetente_UF, out _remetente_cPais_Opc, out _remetente_xPais_Opc, out _remetente_email_Opc);

                    //DADOS DESTINATARIO
                    string _destinatario_cnpj, _destinatario_cpf, _destinatario_ie, _destinatario_xNome, _destinatario_xFant_Opc, _destinatario_fone_Opc,
                      _destinatario_xLgr, _destinatario_nro, _destinatario_xCpl_Opc, _destinatario_xBairro, _destinatario_cMun, _destinatario_xMun,
                      _destinatario_CEP_Opc, _destinatario_UF, _destinatario_cPais_Opc, _destinatario_xPais_Opc, _destinatario_email_Opc;
                    buscar_dados_cliente(dr["DESTINATARIO_CNPJ_CTE"].ToString(), out _destinatario_cnpj, out _destinatario_cpf, out _destinatario_ie, out _destinatario_xNome, out _destinatario_xFant_Opc, out _destinatario_fone_Opc, out
                _destinatario_xLgr, out _destinatario_nro, out _destinatario_xCpl_Opc, out _destinatario_xBairro, out _destinatario_cMun, out _destinatario_xMun, out
                _destinatario_CEP_Opc, out _destinatario_UF, out _destinatario_cPais_Opc, out _destinatario_xPais_Opc, out _destinatario_email_Opc);



                    if (_expedidor_cnpj != "")
                    {
                        uf_inicio = _expedidor_UF;
                    }
                    else
                    {
                        uf_inicio = _remetente_UF;
                    }
                    if (_recebedor_cnpj != "")
                    {
                        uf_fim = _recebedor_UF;
                    }
                    else
                    {
                        uf_fim = _destinatario_UF;
                    }
                    if (uf_inicio == "EX")
                        uf_inicio = "SP";
                    if (uf_fim == "EX")
                        uf_fim = "SP";
                }
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }

        }

        private void criar_arquivo(string caminho)
        {
            StreamWriter Arquivo;
            try
            {
                Arquivo = new StreamWriter(caminho);
                Arquivo.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            
            if (cbTomador.Checked)
            {
                string cnpjEmpresa;
                string dataIni, dataFim;
                string dataSelect;
                cnpjEmpresa = tb_tomador_cnpj.Text;
                dataIni = dtInicio.Value.ToShortDateString().Replace("/", ".");
                dataFim = dtTermino.Value.ToShortDateString().Replace("/", ".");
                if (cbData.Checked)
                {
                    dataSelect = " AND DATA_EMISSAO_CTE >= '" + dataIni + "' AND DATA_EMISSAO_CTE <= '" + dataFim + "'";
                }
                else
                {
                    dataSelect = "";
                }
                form_gerar_xml xml = new form_gerar_xml(dataSelect, cnpjEmpresa, 1);
                xml.Show();
                xml.gerarPorCliente(cnpjEmpresa);
            }
            else
            {
                string dataIni, dataFim;
                dataIni = dtInicio.Value.ToShortDateString().Replace("/", ".");
                dataFim = dtTermino.Value.ToShortDateString().Replace("/", ".");
                string dataSelect = " WHERE DATA_EMISSAO_CTE >= '" + dataIni + "' AND DATA_EMISSAO_CTE <= '" + dataFim + "'";
                form_gerar_xml xml = new form_gerar_xml(dataSelect, _cnpj_emitente, 0);
                xml.Show();
                xml.gerarXml(true);
            }
        }

        private void btnGerarLog_Click(object sender, EventArgs e)
        {
            string dataIni, dataFim;
            dataIni = dtInicio.Value.ToShortDateString().Replace("/", ".");
            dataFim = dtTermino.Value.ToShortDateString().Replace("/", ".");
            string dataSelect = " WHERE DATA_EMISSAO_CTE >= '" + dataIni + "' AND DATA_EMISSAO_CTE <= '" + dataFim + "'";
            form_gerar_xml xml = new form_gerar_xml(dataSelect, _cnpj_emitente, 1);
            xml.Show();
            xml.gerarXml(false);
        }

        private void dgvPesquisa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void detectar_dados_empresa(string cnpj, out string razao_social_empresa, out string nome_fantasia_empresa, out string cnpj_empresa, out string ie_empresa, out string im_empresa, out string cnae_empresa, out string endereco_empresa, out string n_endereco_empresa,
    out string complemento_empresa, out string bairro_empresa, out string cidade_empresa, out string estado_empresa, out string cep_empresa, out string telefone_empresa, out string cod_cidade_empresa, out string pais_empresa,
    out string cod_pais_empresa, out string licenca_dll_nfe_empresa, out string nome_certificado_nfe_empresa, out string assunto_nfe_email_empresa, out string smtp_nfe_empresa, out string email_nfe_empresa,
    out string senha_email_nfe_empresa, out string logotipo_empresa, out string proxy_empresa, out string usuario_proxy_empresa, out string senha_proxy_empresa, out string crt_empresa, out string rntrc_empresa)
        {
            razao_social_empresa = ""; nome_fantasia_empresa = ""; cnpj_empresa = ""; ie_empresa = ""; im_empresa = ""; cnae_empresa = ""; endereco_empresa = ""; n_endereco_empresa = "";
            complemento_empresa = ""; bairro_empresa = ""; cidade_empresa = ""; estado_empresa = ""; cep_empresa = ""; telefone_empresa = ""; cod_cidade_empresa = ""; pais_empresa = "";
            cod_pais_empresa = ""; licenca_dll_nfe_empresa = ""; nome_certificado_nfe_empresa = ""; assunto_nfe_email_empresa = ""; smtp_nfe_empresa = ""; email_nfe_empresa = "";
            senha_email_nfe_empresa = ""; logotipo_empresa = ""; proxy_empresa = ""; usuario_proxy_empresa = ""; senha_proxy_empresa = ""; crt_empresa = ""; rntrc_empresa = "";
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
                    logotipo_empresa = dr["LOGOTIPO_EMPRESA"].ToString();
                    proxy_empresa = dr["PROXY_EMPRESA"].ToString();
                    usuario_proxy_empresa = dr["USUARIO_PROXY_EMPRESA"].ToString();
                    senha_proxy_empresa = dr["SENHA_PROXY_EMPRESA"].ToString();
                    crt_empresa = dr["CRT_EMPRESA"].ToString();
                    rntrc_empresa = dr["rntrc_empresa"].ToString();
                }

            }
            catch
            {
                fbConnection1.Close();
                MessageBox.Show("Erro ao buscar dados da empresa");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (dgvPesquisa.SelectedRows.Count > 50)
                MessageBox.Show("Só é possível enviar 50 CTes por vez");
            else
            {
                if (verificar_se_existe_alguma_linha_com_lote_enviado())
                {
                    string razao_social_empresa = "", nome_fantasia_empresa = "", cnpj_empresa = "", ie_empresa = "", im_empresa = "", cnae_empresa = "", endereco_empresa = "", n_endereco_empresa = "",
                                          complemento_empresa = "", bairro_empresa = "", cidade_empresa = "", estado_empresa = "", cep_empresa = "", telefone_empresa = "", cod_cidade_empresa = "", pais_empresa = "",
                                          cod_pais_empresa = "", licenca_dll_nfe_empresa = "", nome_certificado_nfe_empresa = "", assunto_nfe_email_empresa = "", smtp_nfe_empresa = "", email_nfe_empresa = "",
                                          senha_email_nfe_empresa = "", logotipo_empresa = "", proxy_empresa = "", usuario_proxy_empresa = "", senha_proxy_empresa = "", crt_empresa = "", rntrc_empresa = "";

                    detectar_dados_empresa(cnpjtoolStripStatusLabel.Text, out razao_social_empresa, out nome_fantasia_empresa, out cnpj_empresa, out ie_empresa, out im_empresa, out cnae_empresa, out endereco_empresa, out n_endereco_empresa,
                            out complemento_empresa, out bairro_empresa, out cidade_empresa, out estado_empresa, out cep_empresa, out telefone_empresa, out cod_cidade_empresa, out pais_empresa,
                            out cod_pais_empresa, out licenca_dll_nfe_empresa, out nome_certificado_nfe_empresa, out assunto_nfe_email_empresa, out smtp_nfe_empresa, out email_nfe_empresa,
                            out senha_email_nfe_empresa, out logotipo_empresa, out proxy_empresa, out usuario_proxy_empresa, out senha_proxy_empresa, out crt_empresa, out rntrc_empresa);
                    string proxy = proxy_empresa;
                    string usuario = usuario_proxy_empresa;
                    string senha = senha_proxy_empresa;
                    string licenca = licenca_dll_nfe_empresa;
                    string nomeCertificado = nome_certificado_nfe_empresa;
                    string _nroRecibo, _msgCabec, _msgDados, _msgRetWS, _msgResultado, _NFeAssinada;

                    int tipo_ambiente = 1; //1 - PRODUÇÃO 2- HOMOLOGACAO
                    if (cbTeste.Checked)
                        tipo_ambiente = 2;
                    string arquivo = "";
                    for (int i = 0; i < dgvPesquisa.SelectedRows.Count; i++)
                    { //GERANDO CONJUNTO DE CTEs
                        arquivo = arquivo + buscar_xml_gerado(dgvPesquisa.SelectedRows[i].Cells["col_COD_CTE"].Value.ToString(), nomeCertificado) + "\n";
                    }
                    string numero_lote = gerar_numero_de_lote();

                    int quantidadeCTe; int cResultado; string MsgResultado;
                    string montar_lote = util.MontaLoteCTe("1.04", numero_lote, arquivo, out quantidadeCTe, out cResultado, out MsgResultado);

                    salvar_na_pasta(montar_lote, @"c:\evolucao_dokinos\\CTE\LOTE_ENVIADO\LOTE" + numero_lote + ".xml");

                    int envia = util.EnviaLote(estado_empresa, estado_empresa, tipo_ambiente, nomeCertificado, "1.04", ref montar_lote,
                        out _msgRetWS, out _msgResultado, proxy, usuario, senha, licenca);

                    if (envia == 103)
                    {
                        string recibo = "";
                        salvar_na_pasta(_msgRetWS, @"c:\evolucao_dokinos\\CTE\LOTE_RECEBIDO\LOTE" + numero_lote + ".xml");

                        StringReader theReader = new StringReader(_msgRetWS);
                        DataSet ds = new DataSet();
                        ds.ReadXml(theReader);
                        foreach (DataRow dr in ds.Tables["infRec"].Rows)
                            recibo = dr["nRec"].ToString();

                        try
                        {
                            //gravar xml assinada e lote de envio no cte
                            //update_coluna_xml_assin(CTeAssinada, tb_cod.Text);
                            for (int i = 0; i < dgvPesquisa.SelectedRows.Count; i++)
                            { //update cte
                                update_cte(dgvPesquisa.SelectedRows[i].Cells["col_COD_CTE"].Value.ToString(), numero_lote, recibo);
                            }

                            update_lote(numero_lote, montar_lote, _msgRetWS, _msgResultado, recibo);
                            MessageBox.Show("Lote Recebido");
                            selecionar();
                        }
                        catch
                        { }

                    }
                    else
                    {
                        MessageBox.Show(envia.ToString() + " " + _msgResultado + " " + _msgRetWS);
                    }
                }
                else
                {
                    MessageBox.Show("Não é possível enviar o lote pois foram selecionados CTes já enviados.");
                }
            }
        }

        private bool verificar_se_existe_alguma_linha_com_lote_enviado()
        {
            for (int i = 0; i < dgvPesquisa.SelectedRows.Count; i++)
            {
                if (dgvPesquisa.SelectedRows[i].Cells[1].Value.ToString() != "" ||
                    dgvPesquisa.SelectedRows[i].Cells["col_protocolo"].Value.ToString() != "")
                    return false;
            }
            return true;
        }
        void update_lote(string numero_lote, string montar_lote, string _msgRetWS, string _msgResultado, object recibo)
        {
            try
            {
                fbConnection1.Open();
                FbTransaction trans = fbConnection1.BeginTransaction();
                fbConnection1.Close();
                FbCommand update = new FbCommand(
                    "UPDATE LOTE_ENVIO_CTE SET MSG_RET_WS_LEC = ?, " +
                    "MSG_RESULTADO_LEC = ?, " + 
                    "RECIBO_LEC = ?, " + 
                    "XML_ENVIO_LEC = ?,  " + 
                    "DATA_ENVIO_LEC = ?," + 
                    "HORA_ENVIO_LEC = ?" + 
                    " WHERE COD_LOTE_ENVIO_CTE = ?", fbConnection1, trans);
                update.Parameters.AddWithValue("MSG_RET_WS_LEC", _msgRetWS);
                update.Parameters.AddWithValue("MSG_RESULTADO_LEC", _msgResultado);
                update.Parameters.AddWithValue("RECIBO_LEC", recibo);
                update.Parameters.AddWithValue("XML_ENVIO_LEC", montar_lote);
                update.Parameters.AddWithValue("DATA_ENVIO_LEC", DateTime.Now.ToShortDateString());
                update.Parameters.AddWithValue("HORA_ENVIO_LEC", DateTime.Now.ToShortTimeString());
                update.Parameters.AddWithValue("COD_LOTE_ENVIO_CTE", numero_lote);
                fbConnection1.Open();
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.UpdateCommand = update;
                datTabela.UpdateCommand.ExecuteNonQuery();
                fbConnection1.Close();

            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void update_cte(string cod_cte, string numero_lote, string recibo)
        {
            try
            {
                FbCommand update = new FbCommand();
                update.CommandText =
                    "UPDATE CTE SET NUMERO_LOTE_ENVIO_CTE = '" + numero_lote + 
                    "', RECIBO_CTE = '" + recibo + "', STATUS_CTE = 'CTe Enviada no lote " + 
                    numero_lote + "' WHERE COD_CTE = '" + cod_cte + "'";
                update.Connection = fbConnection1;
                fbConnection1.Open();
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

        private string gerar_numero_de_lote()
        {
            string retorno = "0";
            try
            {
                FbCommand insert = new FbCommand();
                insert.CommandText =
                    "INSERT INTO LOTE_ENVIO_CTE (MSG_DADOS_LEC) VALUES ('NOVO')";
                insert.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datInsert = new FbDataAdapter();
                datInsert.InsertCommand = insert;
                datInsert.InsertCommand.ExecuteNonQuery();
                fbConnection1.Close();

                //buscando ultimo lote inserido;
                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT FIRST(1) COD_LOTE_ENVIO_CTE FROM LOTE_ENVIO_CTE ORDER BY COD_LOTE_ENVIO_CTE DESC";
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
                return retorno;

            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
                fbConnection1.Close();
                return "0";
            }
        }

        private string buscar_xml_gerado(string cod, string Nome)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT XML_GERADO FROM CTE WHERE COD_CTE = '" + cod + "'";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    /*
                    string xmlAssinado = "", msgResultado = "";
                    int resultado;
                    xmlAssinado = util2.Assinar(dr[0].ToString(), "infCte", Nome, out resultado, out msgResultado);
                    //    util.Assinar(dr[0].ToString(), "infCte", Nome, out xmlAssinado, out msgResultado);
                    if (resultado == 5300)
                        return xmlAssinado;
                     * */
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

        private void button8_Click(object sender, EventArgs e)
        {

            try
            {
                string razao_social_empresa = "", nome_fantasia_empresa = "", cnpj_empresa = "", ie_empresa = "", im_empresa = "", cnae_empresa = "", endereco_empresa = "", n_endereco_empresa = "",
                                      complemento_empresa = "", bairro_empresa = "", cidade_empresa = "", estado_empresa = "", cep_empresa = "", telefone_empresa = "", cod_cidade_empresa = "", pais_empresa = "",
                                      cod_pais_empresa = "", licenca_dll_nfe_empresa = "", nome_certificado_nfe_empresa = "", assunto_nfe_email_empresa = "", smtp_nfe_empresa = "", email_nfe_empresa = "",
                                      senha_email_nfe_empresa = "", logotipo_empresa = "", proxy_empresa = "", usuario_proxy_empresa = "", senha_proxy_empresa = "", crt_empresa = "", rntrc_empresa = "";

                detectar_dados_empresa(cnpjtoolStripStatusLabel.Text, out razao_social_empresa, out nome_fantasia_empresa, out cnpj_empresa, out ie_empresa, out im_empresa, out cnae_empresa, out endereco_empresa, out n_endereco_empresa,
                        out complemento_empresa, out bairro_empresa, out cidade_empresa, out estado_empresa, out cep_empresa, out telefone_empresa, out cod_cidade_empresa, out pais_empresa,
                        out cod_pais_empresa, out licenca_dll_nfe_empresa, out nome_certificado_nfe_empresa, out assunto_nfe_email_empresa, out smtp_nfe_empresa, out email_nfe_empresa,
                        out senha_email_nfe_empresa, out logotipo_empresa, out proxy_empresa, out usuario_proxy_empresa, out senha_proxy_empresa, out crt_empresa, out rntrc_empresa);

                string proxy = proxy_empresa;
                string usuario = usuario_proxy_empresa;
                string senha = senha_proxy_empresa;
                string licenca = licenca_dll_nfe_empresa;
                string nomeCertificado = nome_certificado_nfe_empresa;
                string _msgDados, _msgRetWS, _msgResultado;

                int tipo_ambiente = 1; //1 - PRODUÇÃO 2- HOMOLOGACAO
                if (cbTeste.Checked)
                    tipo_ambiente = 2;
                string nroRecibo = buscar_recibo();
                //nroRecibo = "351000003575510";
                long consulta = util.BuscaLote(estado_empresa, estado_empresa, tipo_ambiente, nomeCertificado, "1.04", out _msgDados,
                    out _msgRetWS, out _msgResultado, nroRecibo, proxy, usuario, senha);

                if (consulta == 104)
                {
                    salvar_na_pasta(_msgRetWS, @"c:\evolucao_dokinos\\CTE\LOTE_PROCESSADO\LOTE_RECIBO" + nroRecibo + ".xml");

                    StringReader theReader = new StringReader(_msgRetWS);
                    DataSet ds = new DataSet();
                    ds.ReadXml(theReader);

                    MessageBox.Show("Lote Processado");

                    //tratar resultado
                    try
                    {
                        foreach (DataRow dr in ds.Tables["infProt"].Rows)
                        {
                            if (dr["nProt"].ToString() != "")
                            {
                                string arquivo = buscar_xml_assinado(dr["chCTe"].ToString(), nomeCertificado);

                                string procCTe, nroProtocolo, dAutorizacao;
                                string cancelamento;
                                string msgResultado;
                                int resultado;

                                procCTe = util.CriaProcCTe(estado_empresa, ref arquivo, out nroProtocolo, out cancelamento, out resultado,
                                    nome_certificado_nfe_empresa, out msgResultado, proxy, usuario, senha);

                                if (resultado == 6201)
                                {
                                    salvar_na_pasta(procCTe, @"c:\evolucao_dokinos\\CTE\AUTORIZADAS\CTE" + dr["chCTe"].ToString() + ".xml");
                                    try
                                    {
                                        update_coluna_xml_aut(procCTe, nroProtocolo, "CTe Autorizada", dr["chCTe"].ToString());
                                    }
                                    catch { }
                                }
                                else
                                {
                                    if (resultado == 6216)
                                    {
                                        salvar_na_pasta(procCTe, @"c:\evolucao_dokinos\\CTE\CANCELADAS\CTE" + dr["chCTe"].ToString() + ".xml");
                                        try
                                        {
                                            update_coluna_xml_canc(procCTe, nroProtocolo, "CTe Cancelada", dr["chCTe"].ToString());
                                        }
                                        catch { }
                                    }
                                    else
                                    {
                                        MessageBox.Show(resultado.ToString() + " " + msgResultado);
                                    }
                                }
                            }
                        }
                    }
                    catch
                    { }
                }
                else
                {
                    MessageBox.Show(consulta.ToString() + " " + _msgResultado + " " + _msgRetWS);
                }
                selecionar();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
            
        }

        private string buscar_recibo()
        {
            string retorno = "";
            form_lote_envio_cte lote = new form_lote_envio_cte();
            try
            {
                lote.ShowDialog();
            }
            finally
            {
                retorno = lote.numero_recibo;
            }
            return retorno;
        }

        private void update_coluna_xml_aut(string procCTe, string nroProtocolo, string status, string chave_acesso)
        {
            try
            {
                fbConnection1.Open();
                FbTransaction trans = fbConnection1.BeginTransaction();
                fbConnection1.Close();
                FbCommand update = new FbCommand("UPDATE CTE SET XML_AUTORIZADO = ?, STATUS_CTE = ?, PROTOCOLO_CTE = ? " +
                    "WHERE CHAVE_ACESSO_CTE = ?", fbConnection1, trans);
                update.Parameters.AddWithValue("XML_AUTORIZADO", procCTe);
                update.Parameters.AddWithValue("STATUS_CTE", status);
                update.Parameters.AddWithValue("PROTOCOLO_CTE", nroProtocolo);
                update.Parameters.AddWithValue("CHAVE_ACESSO_CTE", chave_acesso);
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

        private void update_coluna_xml_canc(string procCTe, string nroProtocolo, string status, string chave_acesso)
        {
            try
            {
                fbConnection1.Open();
                FbTransaction trans = fbConnection1.BeginTransaction();
                fbConnection1.Close();
                FbCommand update = new FbCommand("UPDATE CTE SET XML_CANCELADO = ?, STATUS_CTE = ?, PROTOCOLO_CTE = ? " +
                    "WHERE CHAVE_ACESSO_CTE = ?", fbConnection1, trans);
                update.Parameters.AddWithValue("XML_CANCELADO", procCTe);
                update.Parameters.AddWithValue("STATUS_CTE", status);
                update.Parameters.AddWithValue("PROTOCOLO_CTE", nroProtocolo);
                update.Parameters.AddWithValue("CHAVE_ACESSO_CTE", chave_acesso);
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

        private string buscar_xml_assinado(string chave, string Nome)
        {
            
            try
            {
                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT XML_GERADO FROM CTE WHERE CHAVE_ACESSO_CTE = '" + chave + "'";
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
                    /*
                    string xmlAssinado = "", msgResultado = "";
                    int i = util.Assinar(dr[0].ToString(), "infCte", Nome, out xmlAssinado, out msgResultado);
                    if (i == 0)
                        return xmlAssinado;
                     * */
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

        private void button10_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvPesquisa.SelectedRows.Count; i++)
            {
                if (dgvPesquisa.SelectedRows[i].Cells["col_protocolo"].Value.ToString() != "")
                {
                    Evolucao.dsCte ds = new dsCte();

                    try
                    {

                        string cod_cte = " COD_CTE = '" + dgvPesquisa.SelectedRows[i].Cells["col_cod_cte"].Value.ToString() + "'";
                        string cod_cte_cnf = " COD_CTE_CNF = '" + dgvPesquisa.SelectedRows[i].Cells["col_cod_cte"].Value.ToString() + "'";
                        string cod_cte_cfc = " COD_CTE_CFC = '" + dgvPesquisa.SelectedRows[i].Cells["col_cod_cte"].Value.ToString() + "'";

                        //DADOS EXPEDIDOR
                        string _expedidor_cnpj, _expedidor_cpf, _expedidor_ie, _expedidor_xNome, _expedidor_xFant_Opc, _expedidor_fone_Opc,
                            _expedidor_xLgr, _expedidor_nro, _expedidor_xCpl_Opc, _expedidor_xBairro, _expedidor_cMun, _expedidor_xMun,
                            _expedidor_CEP_Opc, _expedidor_UF, _expedidor_cPais_Opc, _expedidor_xPais_Opc, _expedidor_email_Opc;
                        buscar_dados_cliente(dgvPesquisa.SelectedRows[i].Cells["col_expedidor_cnpj"].Value.ToString(), out _expedidor_cnpj, out _expedidor_cpf, out _expedidor_ie, out _expedidor_xNome, out _expedidor_xFant_Opc, out _expedidor_fone_Opc, out
                _expedidor_xLgr, out _expedidor_nro, out _expedidor_xCpl_Opc, out _expedidor_xBairro, out _expedidor_cMun, out _expedidor_xMun, out
                _expedidor_CEP_Opc, out _expedidor_UF, out _expedidor_cPais_Opc, out _expedidor_xPais_Opc, out _expedidor_email_Opc);

                        ds.EXPEDIDOR.AddEXPEDIDORRow(_expedidor_xNome, _expedidor_xLgr, _expedidor_nro, _expedidor_xCpl_Opc, _expedidor_xBairro,
                            _expedidor_xMun, _expedidor_UF, _expedidor_CEP_Opc, _expedidor_cnpj, _expedidor_ie, _expedidor_fone_Opc);

                        //DADOS RECEBEDOR
                        string _recebedor_cnpj, _recebedor_cpf, _recebedor_ie, _recebedor_xNome, _recebedor_xFant_Opc, _recebedor_fone_Opc,
                           _recebedor_xLgr, _recebedor_nro, _recebedor_xCpl_Opc, _recebedor_xBairro, _recebedor_cMun, _recebedor_xMun,
                           _recebedor_CEP_Opc, _recebedor_UF, _recebedor_cPais_Opc, _recebedor_xPais_Opc, _recebedor_email_Opc;
                        buscar_dados_cliente(dgvPesquisa.SelectedRows[i].Cells["col_recebedor_cnpj"].Value.ToString(), out _recebedor_cnpj, out _recebedor_cpf, out _recebedor_ie, out _recebedor_xNome, out _recebedor_xFant_Opc, out _recebedor_fone_Opc, out
                _recebedor_xLgr, out _recebedor_nro, out _recebedor_xCpl_Opc, out _recebedor_xBairro, out _recebedor_cMun, out _recebedor_xMun, out
                _recebedor_CEP_Opc, out _recebedor_UF, out _recebedor_cPais_Opc, out _recebedor_xPais_Opc, out _recebedor_email_Opc);

                        ds.RECEBEDOR.AddRECEBEDORRow(_recebedor_xNome, _recebedor_xLgr, _recebedor_nro, _recebedor_xCpl_Opc, _recebedor_xBairro,
                           _recebedor_xMun, _recebedor_UF, _recebedor_CEP_Opc, _recebedor_cnpj, _recebedor_ie, _recebedor_fone_Opc);

                        //DADOS REMETENTE
                        string _remetente_cnpj, _remetente_cpf, _remetente_ie, _remetente_xNome, _remetente_xFant_Opc, _remetente_fone_Opc,
                          _remetente_xLgr, _remetente_nro, _remetente_xCpl_Opc, _remetente_xBairro, _remetente_cMun, _remetente_xMun,
                          _remetente_CEP_Opc, _remetente_UF, _remetente_cPais_Opc, _remetente_xPais_Opc, _remetente_email_Opc;
                        buscar_dados_cliente(dgvPesquisa.SelectedRows[i].Cells["col_remetente_cnpj"].Value.ToString(), out _remetente_cnpj, out _remetente_cpf, out _remetente_ie, out _remetente_xNome, out _remetente_xFant_Opc, out _remetente_fone_Opc, out
                _remetente_xLgr, out _remetente_nro, out _remetente_xCpl_Opc, out _remetente_xBairro, out _remetente_cMun, out _remetente_xMun, out
                _remetente_CEP_Opc, out _remetente_UF, out _remetente_cPais_Opc, out _remetente_xPais_Opc, out _remetente_email_Opc);

                        ds.REMETENTE.AddREMETENTERow(_remetente_xNome, _remetente_xLgr, _remetente_nro, _remetente_xCpl_Opc, _remetente_xBairro,
                           _remetente_xMun, _remetente_UF, _remetente_CEP_Opc, _remetente_cnpj, _remetente_ie, _remetente_fone_Opc);

                        //DADOS DESTINATARIO
                        string _destinatario_cnpj, _destinatario_cpf, _destinatario_ie, _destinatario_xNome, _destinatario_xFant_Opc, _destinatario_fone_Opc,
                          _destinatario_xLgr, _destinatario_nro, _destinatario_xCpl_Opc, _destinatario_xBairro, _destinatario_cMun, _destinatario_xMun,
                          _destinatario_CEP_Opc, _destinatario_UF, _destinatario_cPais_Opc, _destinatario_xPais_Opc, _destinatario_email_Opc;
                        buscar_dados_cliente(dgvPesquisa.SelectedRows[i].Cells["col_destinatario_cnpj"].Value.ToString(), out _destinatario_cnpj, out _destinatario_cpf, out _destinatario_ie, out _destinatario_xNome, out _destinatario_xFant_Opc, out _destinatario_fone_Opc, out
                _destinatario_xLgr, out _destinatario_nro, out _destinatario_xCpl_Opc, out _destinatario_xBairro, out _destinatario_cMun, out _destinatario_xMun, out
                _destinatario_CEP_Opc, out _destinatario_UF, out _destinatario_cPais_Opc, out _destinatario_xPais_Opc, out _destinatario_email_Opc);

                        ds.DESTINATARIO.AddDESTINATARIORow(_destinatario_xNome, _destinatario_xLgr, _destinatario_nro, _destinatario_xCpl_Opc, _destinatario_xBairro,
                           _destinatario_xMun, _destinatario_UF, _destinatario_CEP_Opc, _destinatario_cnpj, _destinatario_ie, _destinatario_fone_Opc);

                        //DADOS TOMADOR
                        string _tomador_cnpj, _tomador_cpf, _tomador_ie, _tomador_xNome, _tomador_xFant_Opc, _tomador_fone_Opc,
                          _tomador_xLgr, _tomador_nro, _tomador_xCpl_Opc, _tomador_xBairro, _tomador_cMun, _tomador_xMun,
                          _tomador_CEP_Opc, _tomador_UF, _tomador_cPais_Opc, _tomador_xPais_Opc, _tomador_email_Opc;
                        buscar_dados_cliente(dgvPesquisa.SelectedRows[i].Cells["col_tomador_cnpj"].Value.ToString(), out _tomador_cnpj, out _tomador_cpf, out _tomador_ie, out _tomador_xNome, out _tomador_xFant_Opc, out _tomador_fone_Opc, out
                _tomador_xLgr, out _tomador_nro, out _tomador_xCpl_Opc, out _tomador_xBairro, out _tomador_cMun, out _tomador_xMun, out
                _tomador_CEP_Opc, out _tomador_UF, out _tomador_cPais_Opc, out _tomador_xPais_Opc, out _tomador_email_Opc);

                        ds.TOMADOR.AddTOMADORRow(_tomador_xNome, _tomador_xLgr, _tomador_nro, _tomador_xCpl_Opc, _tomador_xBairro,
                           _tomador_xMun, _tomador_UF, _tomador_CEP_Opc, _tomador_cnpj, _tomador_ie, _tomador_fone_Opc);

                        FbCommand select = new FbCommand();
                        select.Connection = fbConnection1;
                        fbConnection1.Open();
                        select.CommandText =
                            "SELECT * FROM CTE WHERE " + cod_cte;
                        FbDataAdapter datTabela = new FbDataAdapter();
                        datTabela.SelectCommand = select;
                        datTabela.Fill(ds.CTE);
                        fbConnection1.Close();

                        //NOTAS FISCAIS
                        select.Connection = fbConnection1;
                        fbConnection1.Open();
                        select.CommandText =
                            "SELECT * FROM CTE_NOTAS_FISCAIS WHERE " + cod_cte_cnf;
                        datTabela.SelectCommand = select;
                        datTabela.Fill(ds.CTE_NOTAS_FISCAIS);
                        fbConnection1.Close();

                        //COMPOSICAO
                        select.Connection = fbConnection1;
                        fbConnection1.Open();
                        select.CommandText =
                            "SELECT * FROM CTE_FRETE_COMPOSICAO WHERE " + cod_cte_cfc;
                        datTabela.SelectCommand = select;
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

                        crCte nova_nota = new crCte();

                        nova_nota.SetDataSource(ds);
                        form_imprimir imprime = new form_imprimir(nova_nota);
                        try
                        {
                            
                            imprime.n_cte = dgvPesquisa.SelectedRows[i].Cells["col_n_cte"].Value.ToString();
                            imprime.cte = true;
                            imprime.cte_direto = true;
                            imprime.ShowDialog();
                        }
                        finally
                        {
                            imprime.Dispose();
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
                    MessageBox.Show("CTe não autorizado");
                }
            }
            MessageBox.Show("Impressão realizada");

            /*
            Evolucao.dsCte ds = new dsCte();
            try
            {
                string cod_cte = " COD_CTE = '" + dgvPesquisa.SelectedRows[0].Cells["col_cod_cte"].Value.ToString() + "'";
                string cod_cte_cnf = " COD_CTE_CNF = '" + dgvPesquisa.SelectedRows[0].Cells["col_cod_cte"].Value.ToString() + "'";
                string cod_cte_cfc = " COD_CTE_CFC = '" + dgvPesquisa.SelectedRows[0].Cells["col_cod_cte"].Value.ToString() + "'";

                for (int i = 0; i < dgvPesquisa.SelectedRows.Count; i++)
                {
                    cod_cte = cod_cte +  " OR COD_CTE = '" + dgvPesquisa.SelectedRows[i].Cells["col_cod_cte"].Value.ToString() + "'";
                    cod_cte_cnf = cod_cte_cnf + " OR COD_CTE_CNF = '" + dgvPesquisa.SelectedRows[i].Cells["col_cod_cte"].Value.ToString() + "'";
                    cod_cte_cfc = cod_cte_cfc + " OR COD_CTE_CFC = '" + dgvPesquisa.SelectedRows[i].Cells["col_cod_cte"].Value.ToString() + "'";

                    //DADOS EXPEDIDOR
                    string _expedidor_cnpj, _expedidor_cpf, _expedidor_ie, _expedidor_xNome, _expedidor_xFant_Opc, _expedidor_fone_Opc,
                        _expedidor_xLgr, _expedidor_nro, _expedidor_xCpl_Opc, _expedidor_xBairro, _expedidor_cMun, _expedidor_xMun,
                        _expedidor_CEP_Opc, _expedidor_UF, _expedidor_cPais_Opc, _expedidor_xPais_Opc, _expedidor_email_Opc;
                    buscar_dados_cliente(dgvPesquisa.SelectedRows[i].Cells["col_expedidor_cnpj"].Value.ToString(), out _expedidor_cnpj, out _expedidor_cpf, out _expedidor_ie, out _expedidor_xNome, out _expedidor_xFant_Opc, out _expedidor_fone_Opc, out
                _expedidor_xLgr, out _expedidor_nro, out _expedidor_xCpl_Opc, out _expedidor_xBairro, out _expedidor_cMun, out _expedidor_xMun, out
                _expedidor_CEP_Opc, out _expedidor_UF, out _expedidor_cPais_Opc, out _expedidor_xPais_Opc, out _expedidor_email_Opc);

                    ds.EXPEDIDOR.AddEXPEDIDORRow(_expedidor_xNome, _expedidor_xLgr, _expedidor_nro, _expedidor_xCpl_Opc, _expedidor_xBairro,
                        _expedidor_xMun, _expedidor_UF, _expedidor_CEP_Opc, _expedidor_cnpj, _expedidor_ie, _expedidor_fone_Opc);

                    //DADOS RECEBEDOR
                    string _recebedor_cnpj, _recebedor_cpf, _recebedor_ie, _recebedor_xNome, _recebedor_xFant_Opc, _recebedor_fone_Opc,
                       _recebedor_xLgr, _recebedor_nro, _recebedor_xCpl_Opc, _recebedor_xBairro, _recebedor_cMun, _recebedor_xMun,
                       _recebedor_CEP_Opc, _recebedor_UF, _recebedor_cPais_Opc, _recebedor_xPais_Opc, _recebedor_email_Opc;
                    buscar_dados_cliente(dgvPesquisa.SelectedRows[i].Cells["col_recebedor_cnpj"].Value.ToString(), out _recebedor_cnpj, out _recebedor_cpf, out _recebedor_ie, out _recebedor_xNome, out _recebedor_xFant_Opc, out _recebedor_fone_Opc, out
                _recebedor_xLgr, out _recebedor_nro, out _recebedor_xCpl_Opc, out _recebedor_xBairro, out _recebedor_cMun, out _recebedor_xMun, out
                _recebedor_CEP_Opc, out _recebedor_UF, out _recebedor_cPais_Opc, out _recebedor_xPais_Opc, out _recebedor_email_Opc);

                    ds.RECEBEDOR.AddRECEBEDORRow(_recebedor_xNome, _recebedor_xLgr, _recebedor_nro, _recebedor_xCpl_Opc, _recebedor_xBairro,
                       _recebedor_xMun, _recebedor_UF, _recebedor_CEP_Opc, _recebedor_cnpj, _recebedor_ie, _recebedor_fone_Opc);

                    //DADOS REMETENTE
                    string _remetente_cnpj, _remetente_cpf, _remetente_ie, _remetente_xNome, _remetente_xFant_Opc, _remetente_fone_Opc,
                      _remetente_xLgr, _remetente_nro, _remetente_xCpl_Opc, _remetente_xBairro, _remetente_cMun, _remetente_xMun,
                      _remetente_CEP_Opc, _remetente_UF, _remetente_cPais_Opc, _remetente_xPais_Opc, _remetente_email_Opc;
                    buscar_dados_cliente(dgvPesquisa.SelectedRows[i].Cells["col_remetente_cnpj"].Value.ToString(), out _remetente_cnpj, out _remetente_cpf, out _remetente_ie, out _remetente_xNome, out _remetente_xFant_Opc, out _remetente_fone_Opc, out
                _remetente_xLgr, out _remetente_nro, out _remetente_xCpl_Opc, out _remetente_xBairro, out _remetente_cMun, out _remetente_xMun, out
                _remetente_CEP_Opc, out _remetente_UF, out _remetente_cPais_Opc, out _remetente_xPais_Opc, out _remetente_email_Opc);

                    ds.REMETENTE.AddREMETENTERow(_remetente_xNome, _remetente_xLgr, _remetente_nro, _remetente_xCpl_Opc, _remetente_xBairro,
                       _remetente_xMun, _remetente_UF, _remetente_CEP_Opc, _remetente_cnpj, _remetente_ie, _remetente_fone_Opc);

                    //DADOS DESTINATARIO
                    string _destinatario_cnpj, _destinatario_cpf, _destinatario_ie, _destinatario_xNome, _destinatario_xFant_Opc, _destinatario_fone_Opc,
                      _destinatario_xLgr, _destinatario_nro, _destinatario_xCpl_Opc, _destinatario_xBairro, _destinatario_cMun, _destinatario_xMun,
                      _destinatario_CEP_Opc, _destinatario_UF, _destinatario_cPais_Opc, _destinatario_xPais_Opc, _destinatario_email_Opc;
                    buscar_dados_cliente(dgvPesquisa.SelectedRows[i].Cells["col_destinatario_cnpj"].Value.ToString(), out _destinatario_cnpj, out _destinatario_cpf, out _destinatario_ie, out _destinatario_xNome, out _destinatario_xFant_Opc, out _destinatario_fone_Opc, out
                _destinatario_xLgr, out _destinatario_nro, out _destinatario_xCpl_Opc, out _destinatario_xBairro, out _destinatario_cMun, out _destinatario_xMun, out
                _destinatario_CEP_Opc, out _destinatario_UF, out _destinatario_cPais_Opc, out _destinatario_xPais_Opc, out _destinatario_email_Opc);

                    ds.DESTINATARIO.AddDESTINATARIORow(_destinatario_xNome, _destinatario_xLgr, _destinatario_nro, _destinatario_xCpl_Opc, _destinatario_xBairro,
                       _destinatario_xMun, _destinatario_UF, _destinatario_CEP_Opc, _destinatario_cnpj, _destinatario_ie, _destinatario_fone_Opc);

                    //DADOS TOMADOR
                    string _tomador_cnpj, _tomador_cpf, _tomador_ie, _tomador_xNome, _tomador_xFant_Opc, _tomador_fone_Opc,
                      _tomador_xLgr, _tomador_nro, _tomador_xCpl_Opc, _tomador_xBairro, _tomador_cMun, _tomador_xMun,
                      _tomador_CEP_Opc, _tomador_UF, _tomador_cPais_Opc, _tomador_xPais_Opc, _tomador_email_Opc;
                    buscar_dados_cliente(dgvPesquisa.SelectedRows[i].Cells["col_tomador_cnpj"].Value.ToString(), out _tomador_cnpj, out _tomador_cpf, out _tomador_ie, out _tomador_xNome, out _tomador_xFant_Opc, out _tomador_fone_Opc, out
                _tomador_xLgr, out _tomador_nro, out _tomador_xCpl_Opc, out _tomador_xBairro, out _tomador_cMun, out _tomador_xMun, out
                _tomador_CEP_Opc, out _tomador_UF, out _tomador_cPais_Opc, out _tomador_xPais_Opc, out _tomador_email_Opc);

                    ds.TOMADOR.AddTOMADORRow(_tomador_xNome, _tomador_xLgr, _tomador_nro, _tomador_xCpl_Opc, _tomador_xBairro,
                       _tomador_xMun, _tomador_UF, _tomador_CEP_Opc, _tomador_cnpj, _tomador_ie, _tomador_fone_Opc);
                }


                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT * FROM CTE WHERE " + cod_cte;
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.SelectCommand = select;
                datTabela.Fill(ds.CTE);
                fbConnection1.Close();

                //NOTAS FISCAIS
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT * FROM CTE_NOTAS_FISCAIS WHERE " + cod_cte_cnf;
                datTabela.SelectCommand = select;
                datTabela.Fill(ds.CTE_NOTAS_FISCAIS);
                fbConnection1.Close();

                //COMPOSICAO
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT * FROM CTE_FRETE_COMPOSICAO WHERE " + cod_cte_cfc;
                datTabela.SelectCommand = select;
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
                crCte_duplo nova_nota = new crCte_duplo();

                nova_nota.SetDataSource(ds);

                form_imprimir imprime = new form_imprimir(nova_nota);
                imprime.n_cte = "CONJUNTO";
                imprime.cte = true;
                imprime.Show();


            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
             * */
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Evolucao.dsCte imprimir = new dsCte();


            try
            {
                datCte.Fill(imprimir.CTE);
                crPesquisaCTE cr = new crPesquisaCTE();
                cr.SetDataSource(imprimir);
                form_imprimir imprime = new form_imprimir(cr);
                imprime.Show();

            }

            catch (Exception a)
            {


            }
        }
        








    }
}