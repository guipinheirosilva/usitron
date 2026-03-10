using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Collections;
using System.Data.OleDb;

namespace Evolucao
{
    public partial class form_orcamentos : Form
    {
        public string cod_a_abrir, _cnpj;
        string cnpj_empresa;
        public bool selecao_orc;
        public bool selecao_ped;
        double totalSemImpostos;
        public int numero_orcamento;
        public string[] orcamentos_selecionados = new string[500];

        public form_orcamentos(string cnpj_empresa)
        {
            this.cnpj_empresa = cnpj_empresa;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((!rdbPeca.Checked) && (!rdbMolde.Checked))
            {
                MessageBox.Show("Selecione 'Molde' ou 'Peça' antes de escolher o cliente");
            }
            else
            {
                form_localiza_cliente localiza_cliente = new form_localiza_cliente(true, cnpj_empresa);
                try
                {
                    localiza_cliente.ShowDialog();
                }
                finally
                {
                    localiza_cliente.Dispose();
                    tb_cliente.Text = localiza_cliente.cliente_escolhido;
                    comando_select.CommandText = "SELECT * FROM CLIENTES WHERE RAZAO_SOCIAL = '" + tb_cliente.Text + "'";
                    DataSet cliente = new DataSet();
                    fbConnection1.Open();
                    datClientes.SelectCommand = comando_select;
                    datClientes.Fill(cliente);
                    fbConnection1.Close();
                    string _contato = "", _email = "", _cnpj = "";

                    form_busca_contato busca = new form_busca_contato();
                    try
                    {
                        busca.cod_cli_forn = detectar_cod();
                        busca.cli_forn = "CLIENTE";
                        busca.ShowDialog();
                    }
                    finally
                    {
                        _contato = busca.valores[0, 0];
                        _email = busca.valores[0, 1];
                        
                    }


                    tb_contato.Text = _contato;
                    tb_email.Text = _email;
                    _cnpj = cliente.Tables[0].Rows[0]["CNPJ"].ToString();
                    tb_cnpj_cliente.Text = _cnpj;
                    exibirColunasOperacoes();
                    if (rdbPeca.Checked)
                    {
                        //if (verificaSeTemHorasNoCliente())
                        //{
                        exibirColunasOperacoes();
                        limparOperacoesDgv();
                        preencher_tbs_vh(_cnpj);
                        renomearDgvItensOrc(_cnpj);
                        ocultarColunasDGV();
                        inserirMateriaPrimaPadraoPeca();
                        //}
                        //else
                        //{
                        //    exibirColunasOperacoes();
                        //    limparOperacoesDgv();
                        //    preencher_tbs_vh_padrao();
                        //    renomearDgvItensOrcPadrao();
                        //    ocultarColunasDGV();
                        //    inserirMateriaPrimaPadraoPeca();
                        //}
                    }

                }
            }
        }

        private void inserirMateriaPrimaPadraoPeca()
        {
            try
            {
                string desc = ""; double valor_outras = 0; double qtde_outras = 1; double total_outras = 0;

                deletarOutrosServicos();

                FbCommand cmd = new FbCommand();
                FbDataAdapter datCmd = new FbDataAdapter();
                DataTable dtcmd = new DataTable();

                cmd.CommandText = "SELECT * from OUTROS_SERVICOS WHERE PADRAO_ORC_OUTRO_SERV = 1";
                cmd.Connection = fbConnection1;
                datCmd.SelectCommand = cmd;
                fbConnection1.Open();
                datCmd.Fill(dtcmd);
                fbConnection1.Close();

                foreach (DataRow dr in dtcmd.Rows)
                {
                    try
                    {
                        desc = dr["DESCRICAO_OUTRO_SERV"].ToString();
                        valor_outras = 0;
                    }
                    catch
                    { }

                    string qtde = "1";

                    total_outras = qtde_outras * valor_outras;

                    try
                    {
                        this.datOutros_servicos.InsertCommand.CommandText =
                            "INSERT INTO OUTROS_SERVICOS_ORC (DESCRICAO_OUTROS, VALOR_OUTROS, COD_ORC_OUTROS,VALOR_TOTAL_OUTROS,QTD_VALOR_OUTROS) VALUES ('" +
                            desc + "', '" + valor_outras.ToString().Replace(".", "").Replace(",", ".") + "', '" + tb_cod.Text + "', '" + total_outras.ToString().Replace(".", "").Replace(",", ".") + "'," + qtde + ")";
                        this.fbConnection1.Open();
                        this.datOutros_servicos.InsertCommand.Connection = fbConnection1;
                        this.datOutros_servicos.InsertCommand.ExecuteNonQuery();
                        this.fbConnection1.Close();
                    }
                    catch
                    {
                        fbConnection1.Close();
                    }
                }

                dsOutros_servicos.Clear();
                this.datOutros_servicos.SelectCommand.CommandText =
                    "SELECT * FROM OUTROS_SERVICOS_ORC WHERE COD_ORC_OUTROS = '" + tb_cod.Text + "'";
                this.fbConnection1.Open();
                this.datOutros_servicos.SelectCommand.Connection = fbConnection1;
                this.datOutros_servicos.SelectCommand.ExecuteNonQuery();
                datOutros_servicos.Fill(OUTROS_SERVICOS_ORC);
                this.fbConnection1.Close();
                tb_qtde_outras.Text = "";
                tb_desc_outras.Text = "";
                tb_valor_outras.Text = "";
            }
            catch
            {
                fbConnection1.Close();
            }
        }

        private void exibirColunasOperacoes()
        {
            try
            {
                dgvItens_orcamento.Columns["colOpr1"].Visible = true;
                dgvItens_orcamento.Columns["colOpr2"].Visible = true;
                dgvItens_orcamento.Columns["colOpr3"].Visible = true;
                dgvItens_orcamento.Columns["colOpr4"].Visible = true;
                dgvItens_orcamento.Columns["colOpr5"].Visible = true;
                dgvItens_orcamento.Columns["colOpr6"].Visible = true;
                dgvItens_orcamento.Columns["colOpr7"].Visible = true;
                dgvItens_orcamento.Columns["colOpr8"].Visible = true;
                dgvItens_orcamento.Columns["colOpr9"].Visible = true;
                dgvItens_orcamento.Columns["colOpr10"].Visible = true;
                dgvItens_orcamento.Columns["colOpr11"].Visible = true;
                dgvItens_orcamento.Columns["colOpr12"].Visible = true;
                dgvItens_orcamento.Columns["colOpr13"].Visible = true;
                dgvItens_orcamento.Columns["colOpr14"].Visible = true;
                dgvItens_orcamento.Columns["colOpr15"].Visible = true;
                dgvItens_orcamento.Columns["colOpr16"].Visible = true;
                dgvItens_orcamento.Columns["colOpr17"].Visible = true;
                dgvItens_orcamento.Columns["colOpr18"].Visible = true;
                dgvItens_orcamento.Columns["colOpr19"].Visible = true;
                dgvItens_orcamento.Columns["colOpr20"].Visible = true;
                dgvItens_orcamento.Columns["colOpr21"].Visible = true;
                dgvItens_orcamento.Columns["colOpr22"].Visible = true;

                //Renomer itens que bugam

                dgvItens_orcamento.Columns["col_material"].HeaderText = "Material";
                dgvItens_orcamento.Columns["but_material"].HeaderText = "Material";
                dgvItens_orcamento.Columns["colValorMaterial"].HeaderText = "Valor Material";
                dgvItens_orcamento.Columns["colKgPc"].HeaderText = "KG / PÇ";
                dgvItens_orcamento.Columns["col_valor_unit"].HeaderText = "Valor Unitario";
                dgvItens_orcamento.Columns["col_valor_total"].HeaderText = "Valor Total";
                dgvItens_orcamento.Columns["col_valor_total_com_imposto"].HeaderText = "Valor Total com Imposto";
                dgvItens_orcamento.Columns["col_prazo_entrega"].HeaderText = "Prazo Entrega";
                dgvItens_orcamento.Columns["col_valor_unit_com_imposto"].HeaderText = "Valor Unitario com Imposto";
                dgvItens_orcamento.Columns["col_status"].HeaderText = "Status";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void ocultarColunasDGV()
        {
            for (int i = 0; i < dgvItens_orcamento.Columns.Count; i++)
            {
                switch (dgvItens_orcamento.Columns[i].HeaderText.ToString())
                {
                    case "Oper1":
                        {
                            dgvItens_orcamento.Columns[i].Visible = false;
                            break;
                        }
                    case "Oper2":
                        {
                            dgvItens_orcamento.Columns[i].Visible = false;
                            break;
                        }
                    case "Oper3":
                        {
                            dgvItens_orcamento.Columns[i].Visible = false;
                            break;
                        }
                    case "Oper4":
                        {
                            dgvItens_orcamento.Columns[i].Visible = false;
                            break;
                        }
                    case "Oper5":
                        {
                            dgvItens_orcamento.Columns[i].Visible = false;
                            break;
                        }
                    case "Oper6":
                        {
                            dgvItens_orcamento.Columns[i].Visible = false;
                            break;
                        }
                    case "Oper7":
                        {
                            dgvItens_orcamento.Columns[i].Visible = false;
                            break;
                        }
                    case "Oper8":
                        {
                            dgvItens_orcamento.Columns[i].Visible = false;
                            break;
                        }
                    case "Oper9":
                        {
                            dgvItens_orcamento.Columns[i].Visible = false;
                            break;
                        }
                    case "Oper10":
                        {
                            dgvItens_orcamento.Columns[i].Visible = false;
                            break;
                        }
                    case "Oper11":
                        {
                            dgvItens_orcamento.Columns[i].Visible = false;
                            break;
                        }
                    case "Oper12":
                        {
                            dgvItens_orcamento.Columns[i].Visible = false;
                            break;
                        }
                    case "Oper13":
                        {
                            dgvItens_orcamento.Columns[i].Visible = false;
                            break;
                        }
                    case "Oper14":
                        {
                            dgvItens_orcamento.Columns[i].Visible = false;
                            break;
                        }
                    case "Oper15":
                        {
                            dgvItens_orcamento.Columns[i].Visible = false;
                            break;
                        }
                    case "Oper16":
                        {
                            dgvItens_orcamento.Columns[i].Visible = false;
                            break;
                        }
                    case "Oper17":
                        {
                            dgvItens_orcamento.Columns[i].Visible = false;
                            break;
                        }
                    case "Oper18":
                        {
                            dgvItens_orcamento.Columns[i].Visible = false;
                            break;
                        }
                    case "Oper19":
                        {
                            dgvItens_orcamento.Columns[i].Visible = false;
                            break;
                        }
                    case "Oper20":
                        {
                            dgvItens_orcamento.Columns[i].Visible = false;
                            break;
                        }
                    case "Oper21":
                        {
                            dgvItens_orcamento.Columns[i].Visible = false;
                            break;
                        }
                    case "Oper22":
                        {
                            dgvItens_orcamento.Columns[i].Visible = false;
                            break;
                        }
                }
            }
        }

        private void renomearDgvItensOrcPadrao()
        {
            limparOperacoesDgv();
            //Aqui o datagridview terá seus cabeçalhos de coluna renomeados de acordo com as operações do cliente
            DataTable operCliente = new DataTable();
            string[] nomeOper = new string[dgvItens_orcamento.Columns.Count];
            int i, j = 0;
            try
            {
                FbCommand cmdOperacao = new FbCommand();
                FbDataAdapter datCmdOperacao = new FbDataAdapter();
                DataTable dtOperacao = new DataTable();
                cmdOperacao.CommandText = "select * from tipos_operacoes t where t.valor_operacao_tipo is not null and t.ordem_operacao_tipo is not null order by t.ordem_operacao_tipo";
                cmdOperacao.Connection = fbConnection1;
                datCmdOperacao.SelectCommand = cmdOperacao;
                fbConnection1.Open();
                datCmdOperacao.Fill(dtOperacao);
                fbConnection1.Close();

                if (dtOperacao.Rows.Count > 0)
                {
                    for (i = 0; i < dgvItens_orcamento.Columns.Count - 3; i++)
                    {
                        int coluna = i + 3;
                        if (dgvItens_orcamento.Columns[coluna].Visible == true)
                        {
                            if (j < dtOperacao.Rows.Count)
                            {
                                dgvItens_orcamento.Columns[coluna].HeaderText = dtOperacao.Rows[j]["TIPO"].ToString();
                                nomeOper[j] = dtOperacao.Rows[j]["TIPO"].ToString();
                                j++;
                            }
                            else
                            {
                                nomeOper[j] = dgvItens_orcamento.Columns[coluna].HeaderText.ToString();
                                j++;
                            }
                        }
                    }

                    datOrcamentos.UpdateCommand.CommandText =
                        "UPDATE orcamentos SET " +
                            "nome_oper1_orcamento = '" + nomeOper[0] + "'," +
                            "nome_oper2_orcamento = '" + nomeOper[1] + "'," +
                            "nome_oper3_orcamento = '" + nomeOper[2] + "'," +
                            "nome_oper4_orcamento = '" + nomeOper[3] + "'," +
                            "nome_oper5_orcamento = '" + nomeOper[4] + "'," +
                            "nome_oper6_orcamento = '" + nomeOper[5] + "'," +
                            "nome_oper7_orcamento = '" + nomeOper[6] + "'," +
                            "nome_oper8_orcamento = '" + nomeOper[7] + "'," +
                            "nome_oper9_orcamento = '" + nomeOper[8] + "'," +
                            "nome_oper10_orcamento = '" + nomeOper[9] + "'," +
                            "nome_oper11_orcamento = '" + nomeOper[10] + "'," +
                            "nome_oper12_orcamento = '" + nomeOper[11] + "'," +
                            "nome_oper13_orcamento = '" + nomeOper[12] + "'," +
                            "nome_oper14_orcamento = '" + nomeOper[13] + "'," +
                            "nome_oper15_orcamento = '" + nomeOper[14] + "'," +
                            "nome_oper16_orcamento = '" + nomeOper[15] + "'," +
                            "nome_oper17_orcamento = '" + nomeOper[16] + "'," +
                            "nome_oper18_orcamento = '" + nomeOper[17] + "'," +
                            "nome_oper19_orcamento = '" + nomeOper[18] + "'," +
                            "nome_oper20_orcamento = '" + nomeOper[19] + "'," +
                            "nome_oper21_orcamento = '" + nomeOper[20] + "'," +
                            "nome_oper22_orcamento = '" + nomeOper[21] + "' " +
                        "WHERE cod_orcamento = " + tb_cod.Text;
                    datOrcamentos.UpdateCommand.Connection = fbConnection1;
                    datOrcamentos.UpdateCommand.Connection.Open();
                    datOrcamentos.UpdateCommand.ExecuteNonQuery();
                    datOrcamentos.UpdateCommand.Connection.Close();
                }
            }
            catch (Exception a)
            {
                //MessageBox.Show("Erro ao renomear o dataGridView!");
                MessageBox.Show(a.Message);
                datClientes.SelectCommand.Connection.Close();
            }
        }

        private void limparOperacoesDgv()
        {
            DataTable operCliente = new DataTable();
            string[] nomeOper = new string[dgvItens_orcamento.Columns.Count];
            int i, j = 0;
            try
            {

                //if (dtOperacao.Rows.Count > 0)
                //{
                for (i = 3; i < dgvItens_orcamento.Columns.Count; i++)
                {
                    if (dgvItens_orcamento.Columns[i].Visible == true)
                    {
                        if (j < 22)
                        {
                            dgvItens_orcamento.Columns[i].HeaderText = "Oper" + (j + 1).ToString();
                            nomeOper[j] = "Oper" + j.ToString();
                            j++;
                        }
                        //else
                        //{
                        //    nomeOper[j] = dgvItens_orcamento.Columns[i].HeaderText.ToString();
                        //    j++;
                        //}
                    }
                    //}
                }

                //datOrcamentos.UpdateCommand.CommandText =
                //    "UPDATE orcamentos SET " +
                //        "nome_oper1_orcamento = '" + nomeOper[0] + "'," +
                //        "nome_oper2_orcamento = '" + nomeOper[1] + "'," +
                //        "nome_oper3_orcamento = '" + nomeOper[2] + "'," +
                //        "nome_oper4_orcamento = '" + nomeOper[3] + "'," +
                //        "nome_oper5_orcamento = '" + nomeOper[4] + "'," +
                //        "nome_oper6_orcamento = '" + nomeOper[5] + "'," +
                //        "nome_oper7_orcamento = '" + nomeOper[6] + "'," +
                //        "nome_oper8_orcamento = '" + nomeOper[7] + "'," +
                //        "nome_oper9_orcamento = '" + nomeOper[8] + "'," +
                //        "nome_oper10_orcamento = '" + nomeOper[9] + "'," +
                //        "nome_oper11_orcamento = '" + nomeOper[10] + "'," +
                //        "nome_oper12_orcamento = '" + nomeOper[11] + "'," +
                //        "nome_oper13_orcamento = '" + nomeOper[12] + "'," +
                //        "nome_oper14_orcamento = '" + nomeOper[13] + "'," +
                //        "nome_oper15_orcamento = '" + nomeOper[14] + "'," +
                //        "nome_oper16_orcamento = '" + nomeOper[15] + "'," +
                //        "nome_oper17_orcamento = '" + nomeOper[16] + "'," +
                //        "nome_oper18_orcamento = '" + nomeOper[17] + "'," +
                //        "nome_oper19_orcamento = '" + nomeOper[18] + "'," +
                //        "nome_oper20_orcamento = '" + nomeOper[19] + "'," +
                //        "nome_oper21_orcamento = '" + nomeOper[20] + "'," +
                //        "nome_oper22_orcamento = '" + nomeOper[21] + "' " +
                //    "WHERE cod_orcamento = " + tb_cod.Text;

                datOrcamentos.UpdateCommand.CommandText =
              "UPDATE orcamentos SET " +
                  "nome_oper1_orcamento = '" + nomeOper[3] + "'," +
                  "nome_oper2_orcamento = '" + nomeOper[4] + "'," +
                  "nome_oper3_orcamento = '" + nomeOper[5] + "'," +
                  "nome_oper4_orcamento = '" + nomeOper[6] + "'," +
                  "nome_oper5_orcamento = '" + nomeOper[7] + "'," +
                  "nome_oper6_orcamento = '" + nomeOper[8] + "'," +
                  "nome_oper7_orcamento = '" + nomeOper[9] + "'," +
                  "nome_oper8_orcamento = '" + nomeOper[10] + "'," +
                  "nome_oper9_orcamento = '" + nomeOper[11] + "'," +
                  "nome_oper10_orcamento = '" + nomeOper[12] + "'," +
                  "nome_oper11_orcamento = '" + nomeOper[13] + "'," +
                  "nome_oper12_orcamento = '" + nomeOper[14] + "'," +
                  "nome_oper13_orcamento = '" + nomeOper[15] + "'," +
                  "nome_oper14_orcamento = '" + nomeOper[16] + "'," +
                  "nome_oper15_orcamento = '" + nomeOper[17] + "'," +
                  "nome_oper16_orcamento = '" + nomeOper[18] + "'," +
                  "nome_oper17_orcamento = '" + nomeOper[19] + "'," +
                  "nome_oper18_orcamento = '" + nomeOper[20] + "'," +
                  "nome_oper19_orcamento = '" + nomeOper[21] + "'," +
                  "nome_oper20_orcamento = '" + nomeOper[22] + "'," +
                  "nome_oper21_orcamento = '" + nomeOper[23] + "'," +
                  "nome_oper22_orcamento = '" + nomeOper[24] + "' " +
              "WHERE cod_orcamento = " + tb_cod.Text;
                datOrcamentos.UpdateCommand.Connection = fbConnection1;
                datOrcamentos.UpdateCommand.Connection.Open();
                datOrcamentos.UpdateCommand.ExecuteNonQuery();
                datOrcamentos.UpdateCommand.Connection.Close();

            }
            catch (Exception a)
            {
                //MessageBox.Show("Erro ao renomear o dataGridView!");
                MessageBox.Show(a.Message);
                datClientes.SelectCommand.Connection.Close();
            }
        }

        private void preencher_tbs_vh_padrao()
        {
            DataTable operCliente = new DataTable();

            try
            {
                limparCamposVh();

                FbCommand cmdOperacao = new FbCommand();
                FbDataAdapter datCmdOperacao = new FbDataAdapter();
                DataTable dtOperacao = new DataTable();
                cmdOperacao.CommandText = "select * from tipos_operacoes t where t.valor_operacao_tipo is not null and t.ordem_operacao_tipo is not null order by t.ordem_operacao_tipo";
                cmdOperacao.Connection = fbConnection1;
                datCmdOperacao.SelectCommand = cmdOperacao;
                fbConnection1.Open();
                datCmdOperacao.Fill(dtOperacao);
                fbConnection1.Close();

                string coluna = "VALOR_OPERACAO_TIPO";
                //if (rdbMolde.Checked)
                //    coluna = "VALOR_HORA_MOLDE_VOC";
                //else
                //    coluna = "VALOR_HORA_PECA_VOC";
                if (dtOperacao.Rows.Count > 0)
                {
                    foreach (DataRow dr in dtOperacao.Rows)
                    {
                        switch (Convert.ToInt32(dr["ordem_operacao_tipo"].ToString()))
                        {
                            case 1:
                                {
                                    tbVhOper1.Text = dr[coluna].ToString();
                                    break;
                                }
                            case 2:
                                {
                                    tbVhOper2.Text = dr[coluna].ToString();
                                    break;
                                }
                            case 3:
                                {
                                    tbVhOper3.Text = dr[coluna].ToString();
                                    break;
                                }
                            case 4:
                                {
                                    tbVhOper4.Text = dr[coluna].ToString();
                                    break;
                                }
                            case 5:
                                {
                                    tbVhOper5.Text = dr[coluna].ToString();
                                    break;
                                }
                            case 6:
                                {
                                    tbVhOper6.Text = dr[coluna].ToString();
                                    break;
                                }
                            case 7:
                                {
                                    tbVhOper7.Text = dr[coluna].ToString();
                                    break;
                                }
                            case 8:
                                {
                                    tbVhOper8.Text = dr[coluna].ToString();
                                    break;
                                }
                            case 9:
                                {
                                    tbVhOper9.Text = dr[coluna].ToString();
                                    break;
                                }
                            case 10:
                                {
                                    tbVhOper10.Text = dr[coluna].ToString();
                                    break;
                                }
                            case 11:
                                {
                                    tbVhOper11.Text = dr[coluna].ToString();
                                    break;
                                }
                            case 12:
                                {
                                    tbVhOper12.Text = dr[coluna].ToString();
                                    break;
                                }
                            case 13:
                                {
                                    tbVhOper13.Text = dr[coluna].ToString();
                                    break;
                                }
                            case 14:
                                {
                                    tbVhOper14.Text = dr[coluna].ToString();
                                    break;
                                }
                            case 15:
                                {
                                    tbVhOper15.Text = dr[coluna].ToString();
                                    break;
                                }
                            case 16:
                                {
                                    tbVhOper16.Text = dr[coluna].ToString();
                                    break;
                                }
                            case 17:
                                {
                                    tbVhOper17.Text = dr[coluna].ToString();
                                    break;
                                }
                            case 18:
                                {
                                    tbVhOper18.Text = dr[coluna].ToString();
                                    break;
                                }
                            case 19:
                                {
                                    tbVhOper19.Text = dr[coluna].ToString();
                                    break;
                                }
                            case 20:
                                {
                                    tbVhOper20.Text = dr[coluna].ToString();
                                    break;
                                }
                            case 21:
                                {
                                    tbVhOper21.Text = dr[coluna].ToString();
                                    break;
                                }
                            case 22:
                                {
                                    tbVhOper22.Text = dr[coluna].ToString();
                                    break;
                                }
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Erro ao selecionar as operações do cliente!");
                datClientes.SelectCommand.Connection.Close();
            }
            //tbVhBancada.Text = "60";
            //tbVhErosaoPen.Text = "80";
            //tbVhCncHaas.Text = "60";
            //tbVhErosaoFio.Text = "60";
            //tbVhTempera.Text = "60";
            //tbVhFresa.Text = "60";
            //tbVhAjusteRetifica.Text = "100";
            //tbVhCncDesb.Text = "60";
            //tbVhTornoConv.Text = "60";
            //tbVhCncAcab.Text = "60";
            //tbVhRetPerfil.Text = "50";
            //tbVhPolim.Text = "0";
            //tbVhFresaPm.Text = "60";
            //tbVhMont.Text = "50";
        }

        private bool verificaSeTemHorasNoCliente()
        {
            bool ok = false;
            try
            {
                FbCommand cmd = new FbCommand();
                FbDataAdapter datCmd = new FbDataAdapter();
                DataTable dtcmd = new DataTable();

                cmd.CommandText = "SELECT * FROM VALOR_OPERACAO_CLIENTE WHERE CNPJ_CLIENTE_VOC = '" + tb_cnpj_cliente.Text + "'";
                cmd.Connection = fbConnection1;
                datCmd.SelectCommand = cmd;
                fbConnection1.Open();
                datCmd.Fill(dtcmd);
                fbConnection1.Close();
                foreach (DataRow dr in dtcmd.Rows)
                {
                    if (dr["VALOR_HORA_PECA_VOC"].ToString() != "")
                    {
                        ok = true;
                    }
                }
            }
            catch (Exception)
            {
                fbConnection1.Close();
            }
            return ok;
        }

        private void renomearDgvItensOrc(string cnpjCliente)
        {
            //Aqui o datagridview terá seus cabeçalhos de coluna renomeados de acordo com as operações do cliente
            //DataTable operCliente = new DataTable();
            DataTable operacoes = new DataTable();
            string[] nomeOper = new string[dgvItens_orcamento.Columns.Count];
            int i, j = 0;
            try
            {
                datOperacoes.SelectCommand.CommandText = "SELECT * FROM TIPOS_OPERACOES ORDER BY ORDEM_OPERACAO_TIPO";
                datOperacoes.SelectCommand.Connection = fbConnection1;
                datOperacoes.SelectCommand.Connection.Open();
                datOperacoes.SelectCommand.ExecuteNonQuery();
                datOperacoes.Fill(operacoes);
                datOperacoes.SelectCommand.Connection.Close();

                if (operacoes.Rows.Count > 0)
                {
                    for (i = 0; i < dgvItens_orcamento.Columns.Count - 3; i++)
                    {
                        int coluna = i + 3;
                        if (dgvItens_orcamento.Columns[coluna].Visible == true)
                        {
                            if (j < operacoes.Rows.Count)
                            {
                                dgvItens_orcamento.Columns[coluna].HeaderText = operacoes.Rows[j]["TIPO"].ToString();
                                nomeOper[j] = operacoes.Rows[j]["TIPO"].ToString();
                                j++;
                            }
                            else
                            {
                                nomeOper[j] = dgvItens_orcamento.Columns[coluna].HeaderText.ToString();
                                j++;
                            }
                        }
                    }

                    datOrcamentos.UpdateCommand.CommandText =
                        "UPDATE orcamentos SET " +
                            "nome_oper1_orcamento = '" + nomeOper[0] + "'," +
                            "nome_oper2_orcamento = '" + nomeOper[1] + "'," +
                            "nome_oper3_orcamento = '" + nomeOper[2] + "'," +
                            "nome_oper4_orcamento = '" + nomeOper[3] + "'," +
                            "nome_oper5_orcamento = '" + nomeOper[4] + "'," +
                            "nome_oper6_orcamento = '" + nomeOper[5] + "'," +
                            "nome_oper7_orcamento = '" + nomeOper[6] + "'," +
                            "nome_oper8_orcamento = '" + nomeOper[7] + "'," +
                            "nome_oper9_orcamento = '" + nomeOper[8] + "'," +
                            "nome_oper10_orcamento = '" + nomeOper[9] + "'," +
                            "nome_oper11_orcamento = '" + nomeOper[10] + "'," +
                            "nome_oper12_orcamento = '" + nomeOper[11] + "'," +
                            "nome_oper13_orcamento = '" + nomeOper[12] + "'," +
                            "nome_oper14_orcamento = '" + nomeOper[13] + "'," +
                            "nome_oper15_orcamento = '" + nomeOper[14] + "'," +
                            "nome_oper16_orcamento = '" + nomeOper[15] + "'," +
                            "nome_oper17_orcamento = '" + nomeOper[16] + "'," +
                            "nome_oper18_orcamento = '" + nomeOper[17] + "'," +
                            "nome_oper19_orcamento = '" + nomeOper[18] + "'," +
                            "nome_oper20_orcamento = '" + nomeOper[19] + "'," +
                            "nome_oper21_orcamento = '" + nomeOper[20] + "'," +
                            "nome_oper22_orcamento = '" + nomeOper[21] + "' " +
                        "WHERE cod_orcamento = " + tb_cod.Text;
                    datOrcamentos.UpdateCommand.Connection = fbConnection1;
                    datOrcamentos.UpdateCommand.Connection.Open();
                    datOrcamentos.UpdateCommand.ExecuteNonQuery();
                    datOrcamentos.UpdateCommand.Connection.Close();
                }
            }
            catch (Exception a)
            {
                //MessageBox.Show("Erro ao renomear o dataGridView!");
                MessageBox.Show(a.Message);
                datClientes.SelectCommand.Connection.Close();
            }
        }

        private void preencher_tbs_vh(string cnpj)
        {
            DataTable operacoes = new DataTable();

            try
            {
                limparCamposVh();

                datOperacoes.SelectCommand.CommandText = "SELECT * FROM TIPOS_OPERACOES ORDER BY ORDEM_OPERACAO_TIPO";
                datOperacoes.SelectCommand.Connection = fbConnection1;
                datOperacoes.SelectCommand.Connection.Open();
                datOperacoes.SelectCommand.ExecuteNonQuery();
                datOperacoes.Fill(operacoes);
                datOperacoes.SelectCommand.Connection.Close();
                string coluna = "";
                coluna = "VALOR_OPERACAO_TIPO";
                if (operacoes.Rows.Count > 0)
                {
                    foreach (DataRow dr in operacoes.Rows)
                    {
                        switch (Convert.ToInt32(dr["ORDEM_OPERACAO_TIPO"].ToString()))
                        {
                            case 1:
                                {
                                    tbVhOper1.Text = dr[coluna].ToString();
                                    break;
                                }
                            case 2:
                                {
                                    tbVhOper2.Text = dr[coluna].ToString();
                                    break;
                                }
                            case 3:
                                {
                                    tbVhOper3.Text = dr[coluna].ToString();
                                    break;
                                }
                            case 4:
                                {
                                    tbVhOper4.Text = dr[coluna].ToString();
                                    break;
                                }
                            case 5:
                                {
                                    tbVhOper5.Text = dr[coluna].ToString();
                                    break;
                                }
                            case 6:
                                {
                                    tbVhOper6.Text = dr[coluna].ToString();
                                    break;
                                }
                            case 7:
                                {
                                    tbVhOper7.Text = dr[coluna].ToString();
                                    break;
                                }
                            case 8:
                                {
                                    tbVhOper8.Text = dr[coluna].ToString();
                                    break;
                                }
                            case 9:
                                {
                                    tbVhOper9.Text = dr[coluna].ToString();
                                    break;
                                }
                            case 10:
                                {
                                    tbVhOper10.Text = dr[coluna].ToString();
                                    break;
                                }
                            case 11:
                                {
                                    tbVhOper11.Text = dr[coluna].ToString();
                                    break;
                                }
                            case 12:
                                {
                                    tbVhOper12.Text = dr[coluna].ToString();
                                    break;
                                }
                            case 13:
                                {
                                    tbVhOper13.Text = dr[coluna].ToString();
                                    break;
                                }
                            case 14:
                                {
                                    tbVhOper14.Text = dr[coluna].ToString();
                                    break;
                                }
                            case 15:
                                {
                                    tbVhOper15.Text = dr[coluna].ToString();
                                    break;
                                }
                            case 16:
                                {
                                    tbVhOper16.Text = dr[coluna].ToString();
                                    break;
                                }
                            case 17:
                                {
                                    tbVhOper17.Text = dr[coluna].ToString();
                                    break;
                                }
                            case 18:
                                {
                                    tbVhOper18.Text = dr[coluna].ToString();
                                    break;
                                }
                            case 19:
                                {
                                    tbVhOper19.Text = dr[coluna].ToString();
                                    break;
                                }
                            case 20:
                                {
                                    tbVhOper20.Text = dr[coluna].ToString();
                                    break;
                                }
                            case 21:
                                {
                                    tbVhOper21.Text = dr[coluna].ToString();
                                    break;
                                }
                            case 22:
                                {
                                    tbVhOper22.Text = dr[coluna].ToString();
                                    break;
                                }
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Erro ao selecionar as operações.");
                datOperacoes.SelectCommand.Connection.Close();
            }
            //tbVhBancada.Text = "60";
            //tbVhErosaoPen.Text = "80";
            //tbVhCncHaas.Text = "60";
            //tbVhErosaoFio.Text = "60";
            //tbVhTempera.Text = "60";
            //tbVhFresa.Text = "60";
            //tbVhAjusteRetifica.Text = "100";
            //tbVhCncDesb.Text = "60";
            //tbVhTornoConv.Text = "60";
            //tbVhCncAcab.Text = "60";
            //tbVhRetPerfil.Text = "50";
            //tbVhPolim.Text = "0";
            //tbVhFresaPm.Text = "60";
            //tbVhMont.Text = "50";
        }

        private void limparCamposVh()
        {
            tbVhOper1.Text = "0";
            tbVhOper2.Text = "0";
            tbVhOper3.Text = "0";
            tbVhOper4.Text = "0";
            tbVhOper5.Text = "0";
            tbVhOper6.Text = "0";
            tbVhOper7.Text = "0";
            tbVhOper8.Text = "0";
            tbVhOper9.Text = "0";
            tbVhOper10.Text = "0";
            tbVhOper11.Text = "0";
            tbVhOper12.Text = "0";
            tbVhOper13.Text = "0";
            tbVhOper14.Text = "0";
            tbVhOper15.Text = "0";
            tbVhOper16.Text = "0";
            tbVhOper17.Text = "0";
            tbVhOper18.Text = "0";
            tbVhOper19.Text = "0";
            tbVhOper20.Text = "0";
            tbVhOper21.Text = "0";
            tbVhOper22.Text = "0";
        }

        private void button1_Click_1(object sender, EventArgs e)
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
                tb_forma_pgto.Text = localiza_forma.forma_pgto_escolhida;

            }

        }

        private void bt_novo_Click(object sender, EventArgs e)
        {
            dsOrcamentos.Clear();
            dsItens_orcamento.Clear();
            dsMat_prima_orc.Clear();
            dsImpostos_orc.Clear();
            dsOutros_servicos.Clear();
            
            this.datOrcamentos.InsertCommand.CommandText =
                "INSERT INTO ORCAMENTOS (CLIENTE_ORCAMENTO, VALOR_BICO_QUENTE_ORC, DATA_CRIACAO_ORCAMENTO)" +
                "VALUES ('NOVO', " + selecionaBicoQuente() + ",CURRENT_DATE) returning COD_ORCAMENTO";
            this.fbConnection1.Open();
            this.datOrcamentos.InsertCommand.Connection = fbConnection1;
            object cod = datOrcamentos.InsertCommand.ExecuteScalar();
            this.fbConnection1.Close();

            try
            {
                this.datOrcamentos.SelectCommand.CommandText =
                    "SELECT * FROM ORCAMENTOS WHERE COD_ORCAMENTO = '" + cod.ToString() + "' ORDER BY COD_ORCAMENTO DESC";
                this.fbConnection1.Open();
                this.datOrcamentos.SelectCommand.Connection = fbConnection1;
                this.datOrcamentos.SelectCommand.ExecuteNonQuery();
                datOrcamentos.Fill(ORCAMENTOS);
                this.fbConnection1.Close();
                tb_data_orcamento.Text = DateTime.Now.ToShortDateString();
                tb_impostos.Text = "INCLUSOS";
                //string[] newLines = new string[3];
                //newLines[0] = "40% Na Aprovação do Pedido de Compra";
                //newLines[1] = "40% Na Entrega da Primeiras Amostras";
                //newLines[2] = "20% Faturado 30ddl após a aprovação da peça";
                //tb_forma_pgto.Lines = newLines;
                tb_impostos.Text = "INCLUSOS";
                tb_revisao.Text = "0";
                //rdbPeca.Checked = true;
                limparOperacoesDgv();
                inserirValoresPadrao();
                exibirColunasOperacoes();
            }
            catch
            {
                fbConnection1.Close();
                MessageBox.Show("Erro");
            }
        }

        private void inserirValoresPadrao()
        {
            selecionaCameraQuente();
            selecionaGavetas();
            inserirImpostosPadrao();
        }

        private string selecionaBicoQuente()
        {
            string valorBicoQuente = "null";
            try
            {
                FbCommand cmd = new FbCommand();
                FbDataAdapter datCmd = new FbDataAdapter();
                DataTable dtcmd = new DataTable();

                cmd.CommandText = "SELECT * FROM BICO_QUENTE";
                cmd.Connection = fbConnection1;
                datCmd.SelectCommand = cmd;
                fbConnection1.Open();
                datCmd.Fill(dtcmd);
                fbConnection1.Close();

                foreach (DataRow dr in dtcmd.Rows)
                {
                    valorBicoQuente = dr["VALOR_BICO_QUENTE"].ToString().Replace(".", ",");
                }
            }
            catch (Exception)
            {
                fbConnection1.Close();
            }
            return valorBicoQuente;
        }

        private void inserirImpostosPadrao()
        {
            try
            {
                string desc = ""; double perc = 0;

                FbCommand cmd = new FbCommand();
                FbDataAdapter datCmd = new FbDataAdapter();
                DataTable dtcmd = new DataTable();

                cmd.CommandText = "SELECT * FROM IMPOSTOS WHERE PADRAO_ORC_IMPOSTO = 1";
                cmd.Connection = fbConnection1;
                datCmd.SelectCommand = cmd;
                fbConnection1.Open();
                datCmd.Fill(dtcmd);
                fbConnection1.Close();

                foreach (DataRow dr in dtcmd.Rows)
                {
                    try
                    {
                        desc = dr["DESCRICAO_IMPOSTO"].ToString();
                        perc = Convert.ToDouble(dr["PORCENTAGEM_IMPOPSTO"].ToString());
                    }
                    catch
                    { }
                    try
                    {
                        this.datImpostos_orc.InsertCommand.CommandText =
                            "INSERT INTO IMPOSTOS_ORC (DESCRICAO_IMPOSTOS_ORC, PERCENTUAL_IMPOSTOS_ORC, COD_ORC_IMPOSTOS_ORC) VALUES ('" +
                            desc + "', '" + perc.ToString().Replace(".", "").Replace(",", ".") + "', '" + tb_cod.Text + "')";
                        this.fbConnection1.Open();
                        this.datImpostos_orc.InsertCommand.Connection = fbConnection1;
                        this.datImpostos_orc.InsertCommand.ExecuteNonQuery();
                        this.fbConnection1.Close();
                    }
                    catch
                    {
                        fbConnection1.Close();
                    }
                }

                dsImpostos_orc.Clear();
                this.datImpostos_orc.SelectCommand.CommandText =
                    "SELECT * FROM IMPOSTOS_ORC WHERE COD_ORC_IMPOSTOS_ORC = '" + tb_cod.Text + "'";
                this.fbConnection1.Open();
                this.datImpostos_orc.SelectCommand.Connection = fbConnection1;
                this.datImpostos_orc.SelectCommand.ExecuteNonQuery();
                datImpostos_orc.Fill(IMPOSTOS_ORC);
                this.fbConnection1.Close();
                tb_imp_perc.Text = "";
                tb_imp_desc.Text = "";
            }
            catch
            {
                fbConnection1.Close();
            }
        }

        private void inserirMateriaPrimaPadrao()
        {

            try
            {
                double valor_total = 0;
                double qtde_unidade = 1;
                double valor_unidade = 0;
                string item = "";
                string unidade = "";


                FbCommand cmd = new FbCommand();
                FbDataAdapter datCmd = new FbDataAdapter();
                DataTable dtcmd = new DataTable();

                cmd.CommandText = "SELECT * from VALOR_MATERIA_PRIMA_PESO v inner join peso_moldes_pecas p " +
                "on p.cod_peso_moldes_pecas = v.cod_peso_valor_mp_peso WHERE " + tbPeso.Text.ToString().Replace(",", ".") + " between P.peso_minimo_moldes_pecas and P.peso_maximo_moldes_pecas  ORDER BY v.cod_valor_mp_peso";
                cmd.Connection = fbConnection1;
                datCmd.SelectCommand = cmd;
                fbConnection1.Open();
                datCmd.Fill(dtcmd);
                fbConnection1.Close();

                foreach (DataRow dr in dtcmd.Rows)
                {
                    if (dr["DESCRICAO_VALOR_MP_PESO"].ToString() != "")
                    {
                        item = "'" + dr["DESCRICAO_VALOR_MP_PESO"].ToString() + "'";
                    }
                    else
                    {
                        item = "null";
                    }
                    string descricao = "null";
                    string qtde = "1";

                    string peso = "";
                    if (dr["DESCRICAO_VALOR_MP_PESO"].ToString() != "")
                    {
                        try
                        {
                            unidade = "'" + dr["UN_VALOR_MP_PESO"].ToString() + "'";
                        }
                        catch { }
                    }
                    else
                    {
                        unidade = "null";
                    }

                    string total = "";


                    try
                    {
                        valor_unidade = Convert.ToDouble(dr["VALOR_VALOR_MP_PESO"].ToString());
                        valor_total = valor_unidade * qtde_unidade;
                    }
                    catch { }
                    total = "'" + valor_total.ToString().Replace(".", "").Replace(",", ".") + "'";
                    if (total != "")
                    { }
                    else
                    {
                        total = "null";
                    }

                    this.datMat_prima_orc.InsertCommand.CommandText =
                       "INSERT INTO MAT_PRIMA_ORCAMENTO (ITEM_MAT_PRIMA_ORC, DESCRICAO_MAT_PRIMA_ORC, QTDE_MAT_PRIMA_ORC, TOTAL_MAT_PRIMA_ORC, COD_ORC_MAT_PRIMA_ORC, VALOR_MAT_PRIMA_ORC) " +
                       "VALUES (" + item + "," + unidade + "," + qtde + "," + total + ",'" + tb_cod.Text + "', " + valor_unidade + ")";
                    this.fbConnection1.Open();
                    this.datMat_prima_orc.InsertCommand.Connection = fbConnection1;
                    this.datMat_prima_orc.InsertCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                }

                dsMat_prima_orc.Clear();
                this.datMat_prima_orc.SelectCommand.CommandText =
                "SELECT * FROM MAT_PRIMA_ORCAMENTO WHERE COD_ORC_MAT_PRIMA_ORC = '" + tb_cod.Text + "'";
                this.fbConnection1.Open();
                this.datMat_prima_orc.SelectCommand.Connection = fbConnection1;
                this.datMat_prima_orc.SelectCommand.ExecuteNonQuery();
                datMat_prima_orc.Fill(MAT_PRIMA_ORCAMENTO);
                this.fbConnection1.Close();
                tb_item_mat.Text = "";
                tb_qtde_mat.Text = "";
                tb_un_mat.Text = "";
                tb_total_mat.Text = "";

            }
            catch
            {
                fbConnection1.Close();
            }
        }

        private void deletarMateriaPrima()
        {
            try
            {
                FbCommand cmd = new FbCommand();
                FbDataAdapter datCmd = new FbDataAdapter();
                cmd.CommandText = "delete from MAT_PRIMA_ORCAMENTO mp where mp.cod_orc_mat_prima_orc = " + tb_cod.Text;
                cmd.Connection = fbConnection1;
                datCmd.DeleteCommand = cmd;
                fbConnection1.Open();
                datCmd.DeleteCommand.ExecuteNonQuery();
                fbConnection1.Close();
            }
            catch (Exception)
            {
                fbConnection1.Close();
            }
        }

        private void inserirOutrosServicosPadrao()
        {
            try
            {
                string desc = ""; double valor_outras = 0; double qtde_outras = 1; double total_outras = 0;

                deletarOutrosServicos();

                FbCommand cmd = new FbCommand();
                FbDataAdapter datCmd = new FbDataAdapter();
                DataTable dtcmd = new DataTable();

                cmd.CommandText = "SELECT * from valor_outros_servicos_peso v " +
                "inner join peso_moldes_pecas p on p.cod_peso_moldes_pecas = v.cod_peso_outros_serv_peso " +
                "WHERE " + tbPeso.Text.ToString().Replace(",", ".") + " between P.peso_minimo_moldes_pecas and P.peso_maximo_moldes_pecas  ORDER BY v.cod_outros_serv_peso";
                cmd.Connection = fbConnection1;
                datCmd.SelectCommand = cmd;
                fbConnection1.Open();
                datCmd.Fill(dtcmd);
                fbConnection1.Close();

                foreach (DataRow dr in dtcmd.Rows)
                {
                    try
                    {
                        desc = dr["DESCRICAO_OUTROS_SERV_PESO"].ToString();
                        Double.TryParse(dr["VALOR_OUTROS_SERV_PESO"].ToString(), out valor_outras);
                    }
                    catch
                    { }

                    string qtde = "1";

                    total_outras = qtde_outras * valor_outras;

                    try
                    {
                        this.datOutros_servicos.InsertCommand.CommandText =
                            "INSERT INTO OUTROS_SERVICOS_ORC (DESCRICAO_OUTROS, VALOR_OUTROS, COD_ORC_OUTROS,VALOR_TOTAL_OUTROS,QTD_VALOR_OUTROS) VALUES ('" +
                            desc + "', '" + valor_outras.ToString().Replace(".", "").Replace(",", ".") + "', '" + tb_cod.Text + "', '" + total_outras.ToString().Replace(".", "").Replace(",", ".") + "'," + qtde + ")";
                        this.fbConnection1.Open();
                        this.datOutros_servicos.InsertCommand.Connection = fbConnection1;
                        this.datOutros_servicos.InsertCommand.ExecuteNonQuery();
                        this.fbConnection1.Close();
                    }
                    catch
                    {
                        fbConnection1.Close();
                    }
                }

                dsOutros_servicos.Clear();
                this.datOutros_servicos.SelectCommand.CommandText =
                    "SELECT * FROM OUTROS_SERVICOS_ORC WHERE COD_ORC_OUTROS = '" + tb_cod.Text + "'";
                this.fbConnection1.Open();
                this.datOutros_servicos.SelectCommand.Connection = fbConnection1;
                this.datOutros_servicos.SelectCommand.ExecuteNonQuery();
                datOutros_servicos.Fill(OUTROS_SERVICOS_ORC);
                this.fbConnection1.Close();
                tb_qtde_outras.Text = "";
                tb_desc_outras.Text = "";
                tb_valor_outras.Text = "";
            }
            catch
            {
                fbConnection1.Close();
            }
        }

        private void deletarOutrosServicos()
        {
            try
            {
                FbCommand cmd = new FbCommand();
                FbDataAdapter datCmd = new FbDataAdapter();
                cmd.CommandText = "delete from outros_servicos_orc o where o.cod_orc_outros = " + tb_cod.Text;
                cmd.Connection = fbConnection1;
                datCmd.DeleteCommand = cmd;
                fbConnection1.Open();
                datCmd.DeleteCommand.ExecuteNonQuery();
                fbConnection1.Close();
            }
            catch (Exception)
            {
                fbConnection1.Close();
            }
        }

        private void selecionaCameraQuente()
        {
            try
            {
                FbCommand cmd = new FbCommand();
                FbDataAdapter datCmd = new FbDataAdapter();
                DataTable dtcmd = new DataTable();

                cmd.CommandText = "SELECT * FROM CAMERA_QUENTE";
                cmd.Connection = fbConnection1;
                datCmd.SelectCommand = cmd;
                fbConnection1.Open();
                datCmd.Fill(dtcmd);
                fbConnection1.Close();

                foreach (DataRow dr in dtcmd.Rows)
                {
                    dsCamaraQuente.Clear();
                    this.datCamara_quente.InsertCommand.CommandText =
                        "INSERT INTO CAMERA_QUENTE_ORC (DIMENSAO_CAMERA_QUENTE_ORC, VALOR_CAMERA_QUENTE_ORC,COD_ORC_CAMERA_QUENTE_ORC) " +
                        "VALUES ('" + dr["DIMENSAO_CAMERA_QUENTE"].ToString() + "', " + dr["VALOR_CAMERA_QUENTE"].ToString().Replace(",", ".") + ", " + tb_cod.Text + ")";
                    this.fbConnection1.Open();
                    this.datCamara_quente.InsertCommand.Connection = fbConnection1;
                    this.datCamara_quente.InsertCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                }

                FbCommand cmd2 = new FbCommand();
                FbDataAdapter datCmd2 = new FbDataAdapter();

                cmd2.CommandText = "SELECT * FROM CAMERA_QUENTE_ORC WHERE COD_ORC_CAMERA_QUENTE_ORC = " + tb_cod.Text;
                cmd2.Connection = fbConnection1;
                datCmd2.SelectCommand = cmd2;
                fbConnection1.Open();
                datCmd2.Fill(CAMERA_QUENTE_ORC);
                fbConnection1.Close();
            }
            catch (Exception)
            {
                fbConnection1.Close();
            }
        }

        private void selecionaGavetas()
        {
            try
            {
                FbCommand cmd = new FbCommand();
                FbDataAdapter datCmd = new FbDataAdapter();
                DataTable dtcmd = new DataTable();

                cmd.CommandText = "SELECT * FROM GAVETAS";
                cmd.Connection = fbConnection1;
                datCmd.SelectCommand = cmd;
                fbConnection1.Open();
                datCmd.Fill(dtcmd);
                fbConnection1.Close();

                foreach (DataRow dr in dtcmd.Rows)
                {
                    dsGavetas.Clear();
                    this.datGavetas.InsertCommand.CommandText =
                        "INSERT INTO GAVETAS_ORC (DIMENSAO_GAVETAS_ORC, VALOR_GAVETAS_ORC, COD_ORC_GAVETAS_ORC) " +
                        "VALUES ('" + dr["DIMENSAO_GAVETA"].ToString() + "', " + dr["VALOR_GAVETA"].ToString() + ", " + tb_cod.Text + ")";
                    this.fbConnection1.Open();
                    this.datGavetas.InsertCommand.Connection = fbConnection1;
                    this.datGavetas.InsertCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                }

                FbCommand cmd2 = new FbCommand();
                FbDataAdapter datCmd2 = new FbDataAdapter();

                cmd2.CommandText = "SELECT * FROM GAVETAS_ORC WHERE COD_ORC_GAVETAS_ORC = " + tb_cod.Text;
                cmd2.Connection = fbConnection1;
                datCmd2.SelectCommand = cmd2;
                fbConnection1.Open();
                datCmd2.Fill(GAVETAS_ORC);
                fbConnection1.Close();
            }
            catch (Exception)
            {
                fbConnection1.Close();
            }
        }

        private void bt_inserir_Click(object sender, EventArgs e)
        {
            inserir();
        }

        private void inserir()
        {
            string _horas_oper1 = "", _horas_oper2 = "", _horas_oper3 = "", _horas_oper4 = "",
            _horas_oper5 = "", _horas_oper6 = "", _horas_oper7 = "", _horas_oper8 = "", _horas_oper9 = "",
            _horas_oper10 = "", _horas_oper11 = "", _horas_oper12 = "", _horas_oper13 = "",
            _horas_oper14 = "", _horas_oper15 = "", _horas_oper16 = "", _horas_oper17 = "", _horas_oper18 = "", _horas_oper19 = "", _horas_oper20 = "",
            _horas_oper21 = "", _horas_oper22 = "";
            double _confere;
            string ncm = "73259910";

            if (dgvItens_orcamento.Rows.Count <= 1 || rdbPeca.Checked)
            {
                try
                {
                    _confere = Convert.ToDouble(tbHrOper1.Text);
                    _horas_oper1 = "'" + _confere.ToString("n2").Replace(",", ".") + "'";
                }
                catch
                {
                    _horas_oper1 = "null";
                }

                try
                {
                    _confere = Convert.ToDouble(tbHrOper2.Text);
                    _horas_oper2 = "'" + _confere.ToString("n2").Replace(",", ".") + "'";
                }
                catch
                {
                    _horas_oper2 = "null";
                }

                try
                {
                    _confere = Convert.ToDouble(tbHrOper3.Text);
                    _horas_oper3 = "'" + _confere.ToString("n2").Replace(",", ".") + "'";
                }
                catch
                {
                    _horas_oper3 = "null";
                }

                try
                {
                    _confere = Convert.ToDouble(tbHrOper4.Text);
                    _horas_oper4 = "'" + _confere.ToString("n2").Replace(",", ".") + "'";
                }
                catch
                {
                    _horas_oper4 = "null";
                }

                try
                {
                    _confere = Convert.ToDouble(tbHrOper5.Text);
                    _horas_oper5 = "'" + _confere.ToString("n2").Replace(",", ".") + "'";
                }
                catch
                {
                    _horas_oper5 = "null";
                }

                try
                {
                    _confere = Convert.ToDouble(tbHrOper6.Text);
                    _horas_oper6 = "'" + _confere.ToString("n2").Replace(",", ".") + "'";
                }
                catch
                {
                    _horas_oper6 = "null";
                }

                try
                {
                    _confere = Convert.ToDouble(tbHrOper7.Text);
                    _horas_oper7 = "'" + _confere.ToString("n2").Replace(",", ".") + "'";
                }
                catch
                {
                    _horas_oper7 = "null";
                }

                try
                {
                    _confere = Convert.ToDouble(tbHrOper8.Text);
                    _horas_oper8 = "'" + _confere.ToString("n2").Replace(",", ".") + "'";
                }
                catch
                {
                    _horas_oper8 = "null";
                }

                try
                {
                    _confere = Convert.ToDouble(tbHrOper9.Text);
                    _horas_oper9 = "'" + _confere.ToString("n2").Replace(",", ".") + "'";
                }
                catch
                {
                    _horas_oper9 = "null";
                }

                try
                {
                    _confere = Convert.ToDouble(tbHrOper10.Text);
                    _horas_oper10 = "'" + _confere.ToString("n2").Replace(",", ".") + "'";
                }
                catch
                {
                    _horas_oper10 = "null";
                }

                try
                {
                    _confere = Convert.ToDouble(tbHrOper11.Text);
                    _horas_oper11 = "'" + _confere.ToString("n2").Replace(",", ".") + "'";
                }
                catch
                {
                    _horas_oper11 = "null";
                }

                try
                {
                    _confere = Convert.ToDouble(tbHrOper12.Text);
                    _horas_oper12 = "'" + _confere.ToString("n2").Replace(",", ".") + "'";
                }
                catch
                {
                    _horas_oper12 = "null";
                }

                try
                {
                    _confere = Convert.ToDouble(tbHrOper13.Text);
                    _horas_oper13 = "'" + _confere.ToString("n2").Replace(",", ".") + "'";
                }
                catch
                {
                    _horas_oper13 = "null";
                }

                try
                {
                    _confere = Convert.ToDouble(tbHrOper14.Text);
                    _horas_oper14 = "'" + _confere.ToString("n2").Replace(",", ".") + "'";
                }
                catch
                {
                    _horas_oper14 = "null";
                }

                try
                {
                    _confere = Convert.ToDouble(tbHrOper15.Text);
                    _horas_oper15 = "'" + _confere.ToString("n2").Replace(",", ".") + "'";
                }
                catch
                {
                    _horas_oper15 = "null";
                }

                try
                {
                    _confere = Convert.ToDouble(tbHrOper16.Text);
                    _horas_oper16 = "'" + _confere.ToString("n2").Replace(",", ".") + "'";
                }
                catch
                {
                    _horas_oper16 = "null";
                }

                try
                {
                    _confere = Convert.ToDouble(tbHrOper17.Text);
                    _horas_oper17 = "'" + _confere.ToString("n2").Replace(",", ".") + "'";
                }
                catch
                {
                    _horas_oper17 = "null";
                }

                try
                {
                    _confere = Convert.ToDouble(tbHrOper18.Text);
                    _horas_oper18 = "'" + _confere.ToString("n2").Replace(",", ".") + "'";
                }
                catch
                {
                    _horas_oper18 = "null";
                }

                try
                {
                    _confere = Convert.ToDouble(tbHrOper19.Text);
                    _horas_oper19 = "'" + _confere.ToString("n2").Replace(",", ".") + "'";
                }
                catch
                {
                    _horas_oper19 = "null";
                }

                try
                {
                    _confere = Convert.ToDouble(tbHrOper20.Text);
                    _horas_oper20 = "'" + _confere.ToString("n2").Replace(",", ".") + "'";
                }
                catch
                {
                    _horas_oper20 = "null";
                }

                try
                {
                    _confere = Convert.ToDouble(tbHrOper21.Text);
                    _horas_oper21 = "'" + _confere.ToString("n2").Replace(",", ".") + "'";
                }
                catch
                {
                    _horas_oper21 = "null";
                }

                try
                {
                    _confere = Convert.ToDouble(tbHrOper22.Text);
                    _horas_oper22 = "'" + _confere.ToString("n2").Replace(",", ".") + "'";
                }
                catch
                {
                    _horas_oper22 = "null";
                }

                dsItens_orcamento.Clear();
                try
                {
                    int qtde = 0;
                    Int32.TryParse(tb_qtde_item.Text, out qtde);
                    double qtde_peso = 1, valor_material = 0;
                    Double.TryParse(tb_peso_qtde_item.Text, out qtde_peso);
                    Double.TryParse(tb_valor_material_item.Text, out valor_material);
                    string material = tb_material.Text;
                    this.datItens_orcamento.InsertCommand.CommandText =
                        "INSERT INTO ITENS_ORCAMENTO (COD_ORCAMENTO_ITEM_ORC, HORAS_OPER1_ITEM_ORC, " +
                        "HORAS_OPER2_ITEM_ORC, HORAS_OPER3_ITEM_ORC, HORAS_OPER4_ITEM_ORC, HORAS_OPER5_ITEM_ORC, " +
                        "HORAS_OPER6_ITEM_ORC, HORAS_OPER7_ITEM_ORC, HORAS_OPER8_ITEM_ORC, HORAS_OPER9_ITEM_ORC, " +
                        "HORAS_OPER10_ITEM_ORC, HORAS_OPER11_ITEM_ORC, HORAS_OPER12_ITEM_ORC, " +
                        "HORAS_OPER13_ITEM_ORC, HORAS_OPER14_ITEM_ORC, HORAS_OPER15_ITEM_ORC, " +
                        "HORAS_OPER16_ITEM_ORC, HORAS_OPER17_ITEM_ORC, HORAS_OPER18_ITEM_ORC, " +
                        "HORAS_OPER19_ITEM_ORC, HORAS_OPER20_ITEM_ORC, HORAS_OPER21_ITEM_ORC, " +
                        "HORAS_OPER22_ITEM_ORC,NOME_ITEM_ORC, QTDE_ITEM_ORC, MATERIAL_ITEM_ORC, " +
                        "KG_PC_ITEM_ORC, VALOR_MATERIAL_ITEM_ORC, NCM_ITEM_ORC)" +
                        "VALUES ('" + tb_cod.Text + "'," + _horas_oper1 + "," + _horas_oper2 + ","
                        + _horas_oper3 + "," + _horas_oper4 + "," + _horas_oper5 + "," + _horas_oper6 + ","
                        + _horas_oper7 + "," + _horas_oper8 + "," + _horas_oper9 + "," + _horas_oper10 + ","
                        + _horas_oper11 + "," + _horas_oper12 + "," + _horas_oper13 + "," + _horas_oper14 + ","
                        + _horas_oper15 + "," + _horas_oper16 + "," + _horas_oper17 + "," + _horas_oper18 + ","
                        + _horas_oper19 + "," + _horas_oper20 + "," + _horas_oper21 + "," + _horas_oper22 + ",'"
                        + tb_descricao_item.Text + "'," + qtde.ToString() + ", '" + material + "',"
                        + qtde_peso.ToString().Replace(",", ".") + ", " + valor_material.ToString().Replace(",", ".") + ", '" + ncm + "')";
                    this.fbConnection1.Open();
                    this.datItens_orcamento.InsertCommand.Connection = fbConnection1;
                    this.datItens_orcamento.InsertCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();

                    this.datItens_orcamento.SelectCommand.CommandText =
                        "SELECT * FROM ITENS_ORCAMENTO WHERE COD_ORCAMENTO_ITEM_ORC = '" + tb_cod.Text + "' ORDER BY COD_ITEM_ORC";
                    this.fbConnection1.Open();
                    this.datItens_orcamento.SelectCommand.Connection = fbConnection1;
                    this.datItens_orcamento.SelectCommand.ExecuteNonQuery();
                    datItens_orcamento.Fill(ITENS_ORCAMENTO);
                    this.fbConnection1.Close();
                    apagar_tbs();

                }
                catch
                {
                    MessageBox.Show("Erro na inserção, verifique os dados");
                    fbConnection1.Close();
                }
            }
            else
            {
                MessageBox.Show("Os valores da primeira linha são os valores padrão e os da segunda os valores adicionais caso queira inserir mas horas adicionais edite a segunda linha", "Atenção");
            }

        }

        private void deletarItensOrc()
        {
            try
            {
                FbCommand cmd = new FbCommand();
                FbDataAdapter datCmd = new FbDataAdapter();
                cmd.CommandText = "delete from itens_orcamento i where i.cod_orcamento_item_orc = " + tb_cod.Text;
                cmd.Connection = fbConnection1;
                datCmd.DeleteCommand = cmd;
                fbConnection1.Open();
                datCmd.DeleteCommand.ExecuteNonQuery();
                fbConnection1.Close();
                dsItens_orcamento.Clear();
            }
            catch (Exception)
            {
                fbConnection1.Close();
            }
        }

        private void apagar_tbs()
        {
            tbHrOper1.Text = "";
            tbHrOper2.Text = "";
            tbHrOper3.Text = "";
            tbHrOper4.Text = "";
            tbHrOper5.Text = "";
            tbHrOper6.Text = "";
            tbHrOper7.Text = "";
            tbHrOper8.Text = "";
            tbHrOper9.Text = "";
            tbHrOper10.Text = "";
            tbHrOper11.Text = "";
            tbHrOper12.Text = "";
            tbHrOper13.Text = "";
            tbHrOper14.Text = "";
            tbHrOper15.Text = "";
            tbHrOper16.Text = "";
            tbHrOper17.Text = "";
            tbHrOper18.Text = "";
            tbHrOper19.Text = "";
            tbHrOper20.Text = "";
            tbHrOper21.Text = "";
        }

        private void bt_calcular_Click(object sender, EventArgs e)
        {
            somar_horas();
            somar_material_peca();

        }
        private void somar_horas()
        {
            if (tb_cliente.Text == "")
                MessageBox.Show("Insira o cliente por favor");
            else
            {
                //pegando as informações de horas do cliente
                /*
                comando_select.CommandText = "SELECT * FROM CLIENTES WHERE RAZAO_SOCIAL = '" + tb_cliente.Text + "'";
                DataSet cliente = new DataSet();
                fbConnection1.Open();
                datClientes.SelectCommand = comando_select;
                datClientes.Fill(cliente);
                string _porc_beneficiamento = "", _porc_venda = "", 
                _valor_fresa = "", _valor_retifica_plana = "", _valor_retifica_cilindrica = "", _valor_retifica_overbeck = "",
            _valor_retifica_cnc = "", _valor_edm = "", _valor_torno_convencional = "", _valor_torno_cnc = "", _valor_wedm = "",
            _valor_centro_usinagem = "", _valor_tratamento_termico = "", _valor_servico_externo_1 = "", _valor_servico_externo_2 = "",
            _valor_servico_externo_3 = "", _valor_qa = "", _valor_bancada = "", _valor_materia_prima = "";
                //_valor_fresa = "", _valor_retifica = "", _valor_ret_opt = "", _valor_edm = "", _valor_torno = "", _valor_ewc = "", _valor_ewc015 = "", _valor_cnc = "", _valor_bancada = "";
                foreach (DataRow dr in cliente.Tables[0].Rows)
                {
                    _valor_fresa = dr["VALOR_FRESA_CLIENTE"].ToString();
                    _valor_retifica_plana = dr["VALOR_RET_PLANA_CLIENTE"].ToString();
                    _valor_retifica_cilindrica = dr["VALOR_RET_CILIN_CLIENTE"].ToString();
                    _valor_retifica_overbeck = dr["VALOR_RET_OVER_CLIENTE"].ToString();
                    _valor_retifica_cnc = dr["VALOR_RET_CNC_CLIENTE"].ToString();
                    _valor_edm = dr["VALOR_EDM_CLIENTE"].ToString();
                    _valor_torno_convencional = dr["VALOR_TORNO_CONV_CLIENTE"].ToString();
                    _valor_torno_cnc = dr["VALOR_TORNO_CNC_CLIENTE"].ToString();
                    _valor_wedm = dr["VALOR_WEDM_CLIENTE"].ToString();
                    _valor_centro_usinagem = dr["VALOR_CENTRO_USI_CLIENTE"].ToString();
                    _valor_tratamento_termico = dr["VALOR_TRAT_TERM_CLIENTE"].ToString();
                    _valor_qa = dr["VALOR_QA_CLIENTE"].ToString();
                    _valor_bancada = dr["VALOR_BANCADA_CLIENTE"].ToString();
                    _porc_beneficiamento = dr["PORC_BENEFICIAMENTO_CLIENTE"].ToString();
                    _porc_venda = dr["PORC_VENDA_CLIENTE"].ToString();
                }
                fbConnection1.Close();
                 * */


                string _valor_oper1 = tbVhOper1.Text, _valor_oper2 = tbVhOper2.Text, _valor_oper3 = tbVhOper3.Text, _valor_oper4 = tbVhOper4.Text,
            _valor_oper5 = tbVhOper5.Text, _valor_oper6 = tbVhOper6.Text, _valor_oper7 = tbVhOper7.Text, _valor_oper8 = tbVhOper8.Text, _valor_oper9 = tbVhOper9.Text,
            _valor_oper10 = tbVhOper10.Text, _valor_oper11 = tbVhOper11.Text, _valor_oper12 = tbVhOper12.Text, _valor_oper13 = tbVhOper13.Text,
            _valor_oper14 = tbVhOper14.Text, _valor_oper15 = tbVhOper15.Text, _valor_oper16 = tbVhOper16.Text, _valor_oper17 = tbVhOper17.Text, _valor_oper18 = tbVhOper18.Text,
            _valor_oper19 = tbVhOper19.Text, _valor_oper20 = tbVhOper20.Text, _valor_oper21 = tbVhOper21.Text, _valor_oper22 = tbVhOper2.Text;

                int qtde_total = 0;
                double valor_total = 0;
                double valor_unit = 0;
                double _total_valor_oper1 = 0, _total_valor_oper2 = 0, _total_valor_oper3 = 0, _total_valor_oper4 = 0,
            _total_valor_oper5 = 0, _total_valor_oper6 = 0, _total_valor_oper7 = 0, _total_valor_oper8 = 0, _total_valor_oper9 = 0,
            _total_valor_oper10 = 0, _total_valor_oper11 = 0, _total_valor_oper12 = 0, _total_valor_oper13 = 0,
            _total_valor_oper14 = 0, _total_valor_oper15 = 0, _total_valor_oper16 = 0, _total_valor_oper17 = 0, _total_valor_oper18 = 0, _total_valor_oper19 = 0,
            _total_valor_oper20 = 0, _total_valor_oper21 = 0, _total_valor_oper22 = 0;
                double _total_horas_oper1 = 0, _total_horas_oper2 = 0, _total_horas_oper3 = 0, _total_horas_oper4 = 0,
            _total_horas_oper5 = 0, _total_horas_oper6 = 0, _total_horas_oper7 = 0, _total_horas_oper8 = 0, _total_horas_oper9 = 0,
            _total_horas_oper10 = 0, _total_horas_oper11 = 0, _total_horas_oper12 = 0, _total_horas_oper13 = 0,
            _total_horas_oper14 = 0, _total_horas_oper15 = 0, _total_horas_oper16 = 0, _total_horas_oper17 = 0, _total_horas_oper18 = 0, _total_horas_oper19 = 0,
            _total_horas_oper20 = 0, _total_horas_oper21 = 0, _total_horas_oper22 = 0;

                double impostos = 1;
                if (tb_valor_impostos.Text != "")
                {
                    impostos = Convert.ToDouble(tb_valor_impostos.Text) / 100;
                    impostos = 1 - impostos;
                }
                double total_outros = 0;
                try
                {

                    total_outros = Convert.ToDouble(tb_total_outras.Text);

                }
                catch { total_outros = 0; }
                double valor_unit_com_despesas = 0;
                try
                {
                     valor_unit_com_despesas = total_outros / dgvItens_orcamento.RowCount;
                }
                catch 
                {
                    valor_unit_com_despesas = 0;
                }
                for (int i = 0; i < dgvItens_orcamento.RowCount; i++)
                {
                    double _total_horas_item = 0;
                    double _qtde_total_item = 0;
                    double _valor_unit_item = 0;

                    for (int j = 1; j <= 22; j++)
                    {
                        try
                        {
                            _total_horas_item = _total_horas_item + Convert.ToDouble(dgvItens_orcamento.Rows[i].Cells["colOpr" + j].Value);
                        }
                        catch { }
                    }

                    dgvItens_orcamento.Rows[i].Cells["col_total_horas"].Value = _total_horas_item.ToString();
                    //calculando os valores e as horas por operação
                    double _horas_oper1 = 0, _horas_oper2 = 0, _horas_oper3 = 0, _horas_oper4 = 0,
            _horas_oper5 = 0, _horas_oper6 = 0, _horas_oper7 = 0, _horas_oper8 = 0, _horas_oper9 = 0,
            _horas_oper10 = 0, _horas_oper11 = 0, _horas_oper12 = 0, _horas_oper13 = 0,
            _horas_oper14 = 0, _horas_oper15 = 0, _horas_oper16 = 0, _horas_oper17 = 0, _horas_oper18 = 0, _horas_oper19 = 0, _horas_oper20 = 0,
            _horas_oper21 = 0, _horas_oper22 = 0;
                    double _item_valor_oper1 = 0, _item_valor_oper2 = 0, _item_valor_oper3 = 0, _item_valor_oper4 = 0,
            _item_valor_oper5 = 0, _item_valor_oper6 = 0, _item_valor_oper7 = 0, _item_valor_oper8 = 0, _item_valor_oper9 = 0,
            _item_valor_oper10 = 0, _item_valor_oper11 = 0, _item_valor_oper12 = 0, _item_valor_oper13 = 0,
            _item_valor_oper14 = 0, _item_valor_oper15 = 0, _item_valor_oper16 = 0, _item_valor_oper17 = 0,
            _item_valor_oper18 = 0, _item_valor_oper19 = 0, _item_valor_oper20 = 0, _item_valor_oper21 = 0, _item_valor_oper22 = 0;

                    try
                    {
                        _horas_oper1 = Convert.ToDouble(dgvItens_orcamento.Rows[i].Cells["colOpr1"].Value);
                        _item_valor_oper1 = _horas_oper1 * Convert.ToDouble(_valor_oper1);
                        _total_horas_oper1 = _total_horas_oper1 + _horas_oper1;
                        _total_valor_oper1 = _total_valor_oper1 + _item_valor_oper1;
                    }
                    catch { }
                    try
                    {
                        _horas_oper2 = Convert.ToDouble(dgvItens_orcamento.Rows[i].Cells["colOpr2"].Value);
                        _item_valor_oper2 = _horas_oper2 * Convert.ToDouble(_valor_oper2);
                        _total_horas_oper2 = _total_horas_oper2 + _horas_oper2;
                        _total_valor_oper2 = _total_valor_oper2 + _item_valor_oper2;
                    }
                    catch { }
                    try
                    {
                        _horas_oper3 = Convert.ToDouble(dgvItens_orcamento.Rows[i].Cells["colOpr3"].Value);
                        _item_valor_oper3 = _horas_oper3 * Convert.ToDouble(_valor_oper3);
                        _total_horas_oper3 = _total_horas_oper3 + _horas_oper3;
                        _total_valor_oper3 = _total_valor_oper3 + _item_valor_oper3;
                    }
                    catch { }

                    try
                    {
                        _horas_oper4 = Convert.ToDouble(dgvItens_orcamento.Rows[i].Cells["colOpr4"].Value);
                        _item_valor_oper4 = _horas_oper4 * Convert.ToDouble(_valor_oper4);
                        _total_horas_oper4 = _total_horas_oper4 + _horas_oper4;
                        _total_valor_oper4 = _total_valor_oper4 + _item_valor_oper4;
                    }
                    catch { }

                    try
                    {
                        _horas_oper5 = Convert.ToDouble(dgvItens_orcamento.Rows[i].Cells["colOpr5"].Value);
                        _item_valor_oper5 = _horas_oper5 * Convert.ToDouble(_valor_oper5);
                        _total_horas_oper5 = _total_horas_oper5 + _horas_oper5;
                        _total_valor_oper5 = _total_valor_oper5 + _item_valor_oper5;
                    }
                    catch { }

                    try
                    {
                        _horas_oper6 = Convert.ToDouble(dgvItens_orcamento.Rows[i].Cells["colOpr6"].Value);
                        _item_valor_oper6 = _horas_oper6 * Convert.ToDouble(_valor_oper6);
                        _total_horas_oper6 = _total_horas_oper6 + _horas_oper6;
                        _total_valor_oper6 = _total_valor_oper6 + _item_valor_oper6;
                    }
                    catch { }

                    try
                    {
                        _horas_oper7 = Convert.ToDouble(dgvItens_orcamento.Rows[i].Cells["colOpr7"].Value);
                        _item_valor_oper7 = _horas_oper7 * Convert.ToDouble(_valor_oper7);
                        _total_horas_oper7 = _total_horas_oper7 + _horas_oper7;
                        _total_valor_oper7 = _total_valor_oper7 + _item_valor_oper7;
                    }
                    catch { }

                    try
                    {
                        _horas_oper8 = Convert.ToDouble(dgvItens_orcamento.Rows[i].Cells["colOpr8"].Value);
                        _item_valor_oper8 = _horas_oper8 * Convert.ToDouble(_valor_oper8);
                        _total_horas_oper8 = _total_horas_oper8 + _horas_oper8;
                        _total_valor_oper8 = _total_valor_oper8 + _item_valor_oper8;
                    }
                    catch { }

                    try
                    {
                        _horas_oper9 = Convert.ToDouble(dgvItens_orcamento.Rows[i].Cells["colOpr9"].Value);
                        _item_valor_oper9 = _horas_oper9 * Convert.ToDouble(_valor_oper9);
                        _total_horas_oper9 = _total_horas_oper9 + _horas_oper9;
                        _total_valor_oper9 = _total_valor_oper9 + _item_valor_oper9;
                    }
                    catch { }

                    try
                    {
                        _horas_oper10 = Convert.ToDouble(dgvItens_orcamento.Rows[i].Cells["colOpr10"].Value);
                        _item_valor_oper10 = _horas_oper10 * Convert.ToDouble(_valor_oper10);
                        _total_horas_oper10 = _total_horas_oper10 + _horas_oper10;
                        _total_valor_oper10 = _total_valor_oper10 + _item_valor_oper10;
                    }
                    catch { }

                    try
                    {
                        _horas_oper11 = Convert.ToDouble(dgvItens_orcamento.Rows[i].Cells["colOpr11"].Value);
                        _item_valor_oper11 = _horas_oper11 * Convert.ToDouble(_valor_oper11);
                        _total_horas_oper11 = _total_horas_oper11 + _horas_oper11;
                        _total_valor_oper11 = _total_valor_oper11 + _item_valor_oper11;
                    }
                    catch { }

                    try
                    {
                        _horas_oper12 = Convert.ToDouble(dgvItens_orcamento.Rows[i].Cells["colOpr12"].Value);
                        _item_valor_oper12 = _horas_oper12 * Convert.ToDouble(_valor_oper12);
                        _total_horas_oper12 = _total_horas_oper12 + _horas_oper12;
                        _total_valor_oper12 = _total_valor_oper12 + _item_valor_oper12;
                    }
                    catch { }

                    try
                    {
                        _horas_oper13 = Convert.ToDouble(dgvItens_orcamento.Rows[i].Cells["colOpr13"].Value);
                        _item_valor_oper13 = _horas_oper13 * Convert.ToDouble(_valor_oper13);
                        _total_horas_oper13 = _total_horas_oper13 + _horas_oper13;
                        _total_valor_oper13 = _total_valor_oper13 + _item_valor_oper13;
                    }
                    catch { }

                    try
                    {
                        _horas_oper14 = Convert.ToDouble(dgvItens_orcamento.Rows[i].Cells["colOpr14"].Value);
                        _item_valor_oper14 = _horas_oper14 * Convert.ToDouble(_valor_oper14);
                        _total_horas_oper14 = _total_horas_oper14 + _horas_oper14;
                        _total_valor_oper14 = _total_valor_oper14 + _item_valor_oper14;
                    }
                    catch { }

                    try
                    {
                        _horas_oper15 = Convert.ToDouble(dgvItens_orcamento.Rows[i].Cells["colOpr15"].Value);
                        _item_valor_oper15 = _horas_oper15 * Convert.ToDouble(_valor_oper15);
                        _total_horas_oper15 = _total_horas_oper15 + _horas_oper15;
                        _total_valor_oper15 = _total_valor_oper15 + _item_valor_oper15;
                    }
                    catch { }

                    try
                    {
                        _horas_oper16 = Convert.ToDouble(dgvItens_orcamento.Rows[i].Cells["colOpr16"].Value);
                        _item_valor_oper16 = _horas_oper16 * Convert.ToDouble(_valor_oper16);
                        _total_horas_oper16 = _total_horas_oper16 + _horas_oper16;
                        _total_valor_oper16 = _total_valor_oper16 + _item_valor_oper16;
                    }
                    catch { }

                    try
                    {
                        _horas_oper17 = Convert.ToDouble(dgvItens_orcamento.Rows[i].Cells["colOpr17"].Value);
                        _item_valor_oper17 = _horas_oper17 * Convert.ToDouble(_valor_oper17);
                        _total_horas_oper17 = _total_horas_oper17 + _horas_oper17;
                        _total_valor_oper17 = _total_valor_oper17 + _item_valor_oper17;
                    }
                    catch { }

                    try
                    {
                        _horas_oper18 = Convert.ToDouble(dgvItens_orcamento.Rows[i].Cells["colOpr18"].Value);
                        _item_valor_oper18 = _horas_oper18 * Convert.ToDouble(_valor_oper18);
                        _total_horas_oper18 = _total_horas_oper18 + _horas_oper18;
                        _total_valor_oper18 = _total_valor_oper18 + _item_valor_oper18;
                    }
                    catch { }

                    try
                    {
                        _horas_oper19 = Convert.ToDouble(dgvItens_orcamento.Rows[i].Cells["colOpr19"].Value);
                        _item_valor_oper19 = _horas_oper19 * Convert.ToDouble(_valor_oper19);
                        _total_horas_oper19 = _total_horas_oper19 + _horas_oper19;
                        _total_valor_oper19 = _total_valor_oper19 + _item_valor_oper19;
                    }
                    catch { }

                    try
                    {
                        _horas_oper20 = Convert.ToDouble(dgvItens_orcamento.Rows[i].Cells["colOpr20"].Value);
                        _item_valor_oper20 = _horas_oper20 * Convert.ToDouble(_valor_oper20);
                        _total_horas_oper20 = _total_horas_oper20 + _horas_oper20;
                        _total_valor_oper20 = _total_valor_oper20 + _item_valor_oper20;
                    }
                    catch { }

                    try
                    {
                        _horas_oper21 = Convert.ToDouble(dgvItens_orcamento.Rows[i].Cells["colOpr21"].Value);
                        _item_valor_oper21 = _horas_oper21 * Convert.ToDouble(_valor_oper21);
                        _total_horas_oper21 = _total_horas_oper21 + _horas_oper21;
                        _total_valor_oper21 = _total_valor_oper21 + _item_valor_oper21;
                    }
                    catch { }

                    try
                    {
                        _horas_oper22 = Convert.ToDouble(dgvItens_orcamento.Rows[i].Cells["colOpr22"].Value);
                        _item_valor_oper22 = _horas_oper22 * Convert.ToDouble(_valor_oper22);
                        _total_horas_oper22 = _total_horas_oper22 + _horas_oper22;
                        _total_valor_oper22 = _total_valor_oper22 + _item_valor_oper22;
                    }
                    catch { }
                    double desconto = 0, porc_desconto = 0;
                    double valor_total_item = 0, valor_item = 0;
                    double material_peca = 0;
                    try
                    {
                        porc_desconto = Convert.ToDouble(dgvItens_orcamento.Rows[i].Cells["col_porc_desconto"].Value.ToString());
                    }
                    catch
                    {
                        porc_desconto = 0;
                    }
                    try
                    {
                        Double.TryParse(dgvItens_orcamento.Rows[i].Cells["colValorMaterial"].Value.ToString(), out material_peca);
                    }
                    catch
                    {
                        material_peca = 0;
                    }
                    try
                    {
                        desconto = Convert.ToDouble(dgvItens_orcamento.Rows[i].Cells["col_desconto"].Value.ToString());
                    }
                    catch
                    {
                        desconto = 0;
                    }
                    
                        valor_item = _item_valor_oper1 + _item_valor_oper2 + _item_valor_oper3 + _item_valor_oper4 +
                        _item_valor_oper5 + _item_valor_oper6 + _item_valor_oper7 + _item_valor_oper8 + _item_valor_oper9 +
                        _item_valor_oper10 + _item_valor_oper11 + _item_valor_oper12 + _item_valor_oper13 +
                        _item_valor_oper14 + _item_valor_oper15 + _item_valor_oper16 + _item_valor_oper17 + _item_valor_oper18 + _item_valor_oper19 +
                        _item_valor_oper20 + _item_valor_oper21 + _item_valor_oper22;
                    
                    double valor_total_item_com_imposto = 0;
                    double valor_item_com_imposto = 0;
                    double valor_unitario_item_com_imposto = 0;
                    double valor_material = 0;
                    
                    try
                    {
                        _qtde_total_item = Convert.ToDouble(dgvItens_orcamento.Rows[i].Cells["col_qtde"].Value.ToString());

                    }
                    catch
                    { }
                    double despesas = 0; 
                    try
                    {
                        despesas = valor_unit_com_despesas / _qtde_total_item;
                    }
                    catch
                    {
                        despesas = 0;
                    }

                    try
                    {
                        valor_material = Convert.ToDouble(dgvItens_orcamento.Rows[i].Cells["colValorMaterial"].Value);
                    }
                    catch
                    {
                        valor_material = 0;
                    }

                    try
                    {
                        _valor_unit_item = valor_item + valor_material + despesas;
                        dgvItens_orcamento.Rows[i].Cells["col_valor_unit"].Value = _valor_unit_item.ToString("n2").Replace(".", "");
                    }
                    catch { }
                    if (desconto != 0 || porc_desconto != 0)
                    {
                        if (porc_desconto == 0)
                        {
                            try
                            {
                                _valor_unit_item = _valor_unit_item - desconto;
                                dgvItens_orcamento.Rows[i].Cells["col_valor_unit"].Value = _valor_unit_item.ToString("n2").Replace(".", "");
                            }
                            catch { }
                        }
                        else
                        {
                            try
                            {
                                _valor_unit_item = _valor_unit_item - ((_valor_unit_item * porc_desconto) / 100);
                                dgvItens_orcamento.Rows[i].Cells["col_valor_unit"].Value = _valor_unit_item.ToString("n2").Replace(".", "");
                            }
                            catch
                            { }
                        }
                    }
                    //_item_valor_fresa + _item_valor_retifica + _item_valor_ret_opt + _item_vO u=alor_torno +
                    //_item_valor_edm + _item_valor_ewc + _item_valor_ewc015 + _item_valor_bancada + _item_valor_cnc + _item_valor_mat_pri;

                    valor_total_item = _valor_unit_item * _qtde_total_item;
                    valor_item_com_imposto = valor_total_item / impostos;
                    dgvItens_orcamento.Rows[i].Cells["col_valor_total"].Value = valor_total_item.ToString("n2").Replace(".", "");
                    dgvItens_orcamento.Rows[i].Cells["col_valor_total_com_imposto"].Value = valor_total_item_com_imposto.ToString("n2").Replace(".", "");


                    //try
                    //{
                    //    _qtde_total_item = Convert.ToDouble(dgvItens_orcamento.Rows[i].Cells["col_qtde"].Value.ToString());

                    //    _valor_unit_item = valor_total_item / _qtde_total_item;
                    //    dgvItens_orcamento.Rows[i].Cells["col_valor_unit"].Value = _valor_unit_item.ToString("n2").Replace(".", "");

                    //}
                    //catch
                    //{ }
                    valor_unitario_item_com_imposto = _valor_unit_item / impostos;
                    dgvItens_orcamento.Rows[i].Cells["col_valor_unit_com_imposto"].Value = valor_unitario_item_com_imposto.ToString("n2").Replace(".", "");

                    //calculando a quantidade e os totais
                    //try
                    //{
                    //    //double total_item = Convert.ToDouble(dgvItens_orcamento.Rows[i].Cells["col_valor_total"].Value) + Convert.ToDouble(dgvItens_orcamento.Rows[i].Cells["colValorMaterial"].Value);
                    //    //valor_total += total_item;

                        valor_total = valor_total + (Convert.ToDouble(dgvItens_orcamento.Rows[i].Cells["col_valor_total"].Value));
                    //    //qtde_total = qtde_total + Convert.ToInt32(dgvItens_orcamento.Rows[i].Cells["col_qtde"].Value);

                    //}
                    //catch { }
                }
                //inserindo totais
                tbTotHrOper1.Text = _total_horas_oper1.ToString("n2");
                tbTotHrOper2.Text = _total_horas_oper2.ToString("n2");
                tbTotHrOper3.Text = _total_horas_oper3.ToString("n2");
                tbTotHrOper4.Text = _total_horas_oper4.ToString("n2");
                tbTotHrOper5.Text = _total_horas_oper5.ToString("n2");
                tbTotHrOper6.Text = _total_horas_oper6.ToString("n2");
                tbTotHrOper7.Text = _total_horas_oper7.ToString("n2");
                tbTotHrOper8.Text = _total_horas_oper8.ToString("n2");
                tbTotHrOper9.Text = _total_horas_oper9.ToString("n2");
                tbTotHrOper10.Text = _total_horas_oper10.ToString("n2");
                tbTotHrOper11.Text = _total_horas_oper11.ToString("n2");
                tbTotHrOper12.Text = _total_horas_oper12.ToString("n2");
                tbTotHrOper13.Text = _total_horas_oper13.ToString("n2");
                tbTotHrOper14.Text = _total_horas_oper14.ToString("n2");
                tbTotHrOper15.Text = _total_horas_oper15.ToString("n2");
                tbTotHrOper16.Text = _total_horas_oper16.ToString("n2");
                tbTotHrOper17.Text = _total_horas_oper17.ToString("n2");
                tbTotHrOper18.Text = _total_horas_oper18.ToString("n2");
                tbTotHrOper19.Text = _total_horas_oper19.ToString("n2");
                tbTotHrOper20.Text = _total_horas_oper20.ToString("n2");
                tbTotHrOper21.Text = _total_horas_oper21.ToString("n2");
                tbTotHrOper22.Text = _total_horas_oper22.ToString("n2");

                double total_horas = _total_horas_oper1 + _total_horas_oper2 + _total_horas_oper3 + _total_horas_oper4 +
            _total_horas_oper5 + _total_horas_oper6 + _total_horas_oper7 + _total_horas_oper8 + _total_horas_oper9 +
            _total_horas_oper10 + _total_horas_oper11 + _total_horas_oper12 + _total_horas_oper13 +
            _total_horas_oper14 + _total_horas_oper15 + _total_horas_oper16 + _total_horas_oper17 + _total_horas_oper18 +
            _total_horas_oper19 + _total_horas_oper20 + _total_horas_oper21 + _total_horas_oper22;

                //   _total_horas_edm + _total_horas_ewc + _total_horas_ewc015 + _total_horas_fresa + _total_horas_ret_opt + _total_horas_retifica + _total_horas_torno + _total_horas_bancada + _total_horas_cnc;
                tb_total_horas.Text = total_horas.ToString("n2");

                tbVhTotOper1.Text = _total_valor_oper1.ToString("n2");
                tbVhTotOper2.Text = _total_valor_oper2.ToString("n2");
                tbVhTotOper3.Text = _total_valor_oper3.ToString("n2");
                tbVhTotOper4.Text = _total_valor_oper4.ToString("n2");
                tbVhTotOper5.Text = _total_valor_oper5.ToString("n2");
                tbVhTotOper6.Text = _total_valor_oper6.ToString("n2");
                tbVhTotOper7.Text = _total_valor_oper7.ToString("n2");
                tbVhTotOper8.Text = _total_valor_oper8.ToString("n2");
                tbVhTotOper9.Text = _total_valor_oper9.ToString("n2");
                tbVhTotOper10.Text = _total_valor_oper10.ToString("n2");
                tbVhTotOper11.Text = _total_valor_oper11.ToString("n2");
                tbVhTotOper12.Text = _total_valor_oper12.ToString("n2");
                tbVhTotOper13.Text = _total_valor_oper13.ToString("n2");
                tbVhTotOper14.Text = _total_valor_oper14.ToString("n2");
                tbVhTotOper15.Text = _total_valor_oper15.ToString("n2");
                tbVhTotOper16.Text = _total_valor_oper16.ToString("n2");
                tbVhTotOper17.Text = _total_valor_oper17.ToString("n2");
                tbVhTotOper18.Text = _total_valor_oper18.ToString("n2");
                tbVhTotOper19.Text = _total_valor_oper19.ToString("n2");
                tbVhTotOper20.Text = _total_valor_oper20.ToString("n2");
                tbVhTotOper21.Text = _total_valor_oper21.ToString("n2");
                tbVhTotOper22.Text = _total_valor_oper22.ToString("n2");

                /*
                tb_valor_fresa.Text = _total_valor_fresa.ToString("n2"); tb_valor_retifica.Text = _total_valor_retifica.ToString("n2");
                tb_valor_ret_opt.Text = _total_valor_ret_opt.ToString("n2"); tb_valor_torno.Text = _total_valor_torno.ToString("n2");
                tb_valor_edm.Text = _total_valor_edm.ToString("n2"); tb_valor_ewc.Text = _total_valor_ewc.ToString("n2");
                tb_valor_ewc015.Text = _total_valor_ewc015.ToString("n2"); tb_valor_mat_pri.Text = _total_valor_mat_pri.ToString("n2");
                tb_valor_cnc.Text = _total_valor_cnc.ToString("n2"); tb_valor_bancada.Text = _total_valor_bancada.ToString("n2");
                */
                //tb_qtde.Text = qtde_total.ToString();
                tb_valor_total.Text = valor_total.ToString("n2");
            }


        }

        private string buscar_valor_se(string qual, int linha)
        {
            comando_select.CommandText = "SELECT * FROM SERVICOS_EXTERNOS_ORC WHERE N_ORCAMENTO_SE_ORC = '" + tb_cod.Text + "' AND ITEM_SE_ORC = '" + dgvItens_orcamento.Rows[linha].Cells["col_item"].Value.ToString() + "' AND SE_1_2_3_SE_ORC = '" + qual + "'";
            DataSet se = new DataSet();
            fbConnection1.Open();

            datServicos_externos_orc.SelectCommand = comando_select;
            datServicos_externos_orc.Fill(se);
            string valor = "";
            foreach (DataRow dr in se.Tables[0].Rows)
            {
                valor = dr["VALOR_SE_ORC"].ToString();
            }
            fbConnection1.Close();
            if (valor == "")
                return "0,0";
            else
                return valor;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvItens_orcamento.RowCount; i++)
            {
                dgvItens_orcamento.Rows[i].Cells["col_status"].Value = "ITEM APROVADO";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvItens_orcamento.RowCount; i++)
            {
                dgvItens_orcamento.Rows[i].Cells["col_status"].Value = "ITEM REPROVADO";
            }
        }

        private void dgvItens_orcamento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvItens_orcamento.Columns[e.ColumnIndex].Name == "Aprovado")
            {
                dgvItens_orcamento.Rows[e.RowIndex].Cells["col_status"].Value = "ITEM APROVADO";
            }
            if (dgvItens_orcamento.Columns[e.ColumnIndex].Name == "Reprovado")
            {
                dgvItens_orcamento.Rows[e.RowIndex].Cells["col_status"].Value = "ITEM REPROVADO";
            }
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            tb_data_orcamento.Text = DateTime.Now.ToShortDateString();
            Salvar();
        }

        private void Salvar()
        {
            try
            {
                this.BindingContext[dsOrcamentos, "ORCAMENTOS"].EndCurrentEdit();
                if (dsOrcamentos.HasChanges())
                {
                    fbConnection1.Open();
                    datOrcamentos.UpdateCommand = cbOrcamentos.GetUpdateCommand();
                    datOrcamentos.InsertCommand = cbOrcamentos.GetInsertCommand();
                    datOrcamentos.DeleteCommand = cbOrcamentos.GetDeleteCommand();
                    datOrcamentos.Update(dsOrcamentos, "ORCAMENTOS");
                    dsOrcamentos.AcceptChanges();
                    fbConnection1.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CONTATE O ADMINSITRADOR DO SISTEMA.\n\n" + ex.ToString() + "\n", "Erro ao Salvar Orçamentos");
            }

            try
            {
                this.BindingContext[dsItens_orcamento, "ITENS_ORCAMENTO"].EndCurrentEdit();
                if (dsItens_orcamento.HasChanges())
                {

                    fbConnection1.Open();
                    datItens_orcamento.UpdateCommand = cbItens_orcamento.GetUpdateCommand();
                    datItens_orcamento.InsertCommand = cbItens_orcamento.GetInsertCommand();
                    datItens_orcamento.DeleteCommand = cbItens_orcamento.GetDeleteCommand();
                    datItens_orcamento.Update(dsItens_orcamento, "ITENS_ORCAMENTO");
                    dsItens_orcamento.AcceptChanges();
                    fbConnection1.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CONTATE O ADMINSITRADOR DO SISTEMA.\n\n" + ex.ToString() + "\n", "Erro ao Salvar Itens Orçamento");
            }

            try
            {
                this.BindingContext[dsMat_prima_orc, "MAT_PRIMA_ORCAMENTO"].EndCurrentEdit();
                if (dsMat_prima_orc.HasChanges())
                {

                    fbConnection1.Open();
                    datMat_prima_orc.UpdateCommand = cbMat_prima_orc.GetUpdateCommand();
                    datMat_prima_orc.InsertCommand = cbMat_prima_orc.GetInsertCommand();
                    datMat_prima_orc.DeleteCommand = cbMat_prima_orc.GetDeleteCommand();
                    datMat_prima_orc.Update(dsMat_prima_orc, "MAT_PRIMA_ORCAMENTO");
                    dsMat_prima_orc.AcceptChanges();
                    fbConnection1.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CONTATE O ADMINSITRADOR DO SISTEMA.\n\n" + ex.ToString() + "\n", "Erro ao Salvar Materia Prima");
            }

            try
            {
                this.BindingContext[dsOutros_servicos, "OUTROS_SERVICOS_ORC"].EndCurrentEdit();
                if (dsOutros_servicos.HasChanges())
                {
                    fbConnection1.Open();
                    datOutros_servicos.UpdateCommand = cbOutros_servicos.GetUpdateCommand();
                    datOutros_servicos.InsertCommand = cbOutros_servicos.GetInsertCommand();
                    datOutros_servicos.DeleteCommand = cbOutros_servicos.GetDeleteCommand();
                    datOutros_servicos.Update(dsOutros_servicos, "OUTROS_SERVICOS_ORC");
                    dsOutros_servicos.AcceptChanges();
                    fbConnection1.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CONTATE O ADMINSITRADOR DO SISTEMA.\n\n" + ex.ToString() + "\n", "Erro ao Salvar Outros Serviços");
            }
            try
            {
                this.BindingContext[dsGavetas, "GAVETAS_ORC"].EndCurrentEdit();
                if (dsGavetas.HasChanges())
                {
                    fbConnection1.Open();
                    datGavetas.UpdateCommand = cbGavetas.GetUpdateCommand();
                    datGavetas.InsertCommand = cbGavetas.GetInsertCommand();
                    datGavetas.DeleteCommand = cbGavetas.GetDeleteCommand();
                    datGavetas.Update(dsGavetas, "GAVETAS_ORC");
                    dsGavetas.AcceptChanges();
                    fbConnection1.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CONTATE O ADMINSITRADOR DO SISTEMA.\n\n" + ex.ToString() + "\n", "Erro ao Salvar Gavetas");
            }
            try
            {
                this.BindingContext[dsCamaraQuente, "CAMERA_QUENTE_ORC"].EndCurrentEdit();
                if (dsCamaraQuente.HasChanges())
                {
                    fbConnection1.Open();
                    datCamara_quente.UpdateCommand = cbCamaraQuente.GetUpdateCommand();
                    datCamara_quente.InsertCommand = cbCamaraQuente.GetInsertCommand();
                    datCamara_quente.DeleteCommand = cbCamaraQuente.GetDeleteCommand();
                    datCamara_quente.Update(dsCamaraQuente, "CAMERA_QUENTE_ORC");
                    dsCamaraQuente.AcceptChanges();
                    fbConnection1.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CONTATE O ADMINSITRADOR DO SISTEMA.\n\n" + ex.ToString() + "\n", "Erro ao Salvar Camera Quente");
            }
            try
            {
                this.BindingContext[dsImpostos_orc, "IMPOSTOS_ORC"].EndCurrentEdit();
                if (dsImpostos_orc.HasChanges())
                {
                    fbConnection1.Open();
                    datImpostos_orc.UpdateCommand = cbImpostos.GetUpdateCommand();
                    datImpostos_orc.InsertCommand = cbImpostos.GetInsertCommand();
                    datImpostos_orc.DeleteCommand = cbImpostos.GetDeleteCommand();
                    datImpostos_orc.Update(dsImpostos_orc, "IMPOSTOS_ORC");
                    dsImpostos_orc.AcceptChanges();
                    fbConnection1.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CONTATE O ADMINSITRADOR DO SISTEMA.\n\n" + ex.ToString() + "\n", "Erro ao Salvar Impostos");
            }
            updateGenerator();
        }

        private void updateGenerator()
        {
            try
            {
                FbCommand alter = new FbCommand();
                alter.CommandText = "set generator gen_orcamentos2_id to " + tb_n_orc.Text;
                alter.Connection = fbConnection1;
                fbConnection1.Open();
                alter.ExecuteNonQuery();
                fbConnection1.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Coloque um numero para o Orçamento!");
            }
        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("O registro será excluído permanentemente, tem certeza?",
               "Confirma a exclusão?", MessageBoxButtons.YesNo))
            {
                this.datItens_orcamento.DeleteCommand.CommandText =
                    "DELETE FROM ITENS_ORCAMENTO WHERE COD_ORCAMENTO_ITEM_ORC = '" + tb_cod.Text + "'";
                this.fbConnection1.Open();
                this.datItens_orcamento.DeleteCommand.Connection = fbConnection1;
                this.datItens_orcamento.DeleteCommand.ExecuteNonQuery();
                this.fbConnection1.Close();

                this.datOrcamentos.DeleteCommand.CommandText =
                    "DELETE FROM ORCAMENTOS WHERE COD_ORCAMENTO = '" + tb_cod.Text + "'";
                this.fbConnection1.Open();
                this.datOrcamentos.DeleteCommand.Connection = fbConnection1;
                this.datOrcamentos.DeleteCommand.ExecuteNonQuery();
                this.fbConnection1.Close();

                this.datMat_prima_orc.DeleteCommand.CommandText =
                    "DELETE FROM MAT_PRIMA_ORCAMENTO WHERE COD_ORC_MAT_PRIMA_ORC = '" + tb_cod.Text + "'";
                this.fbConnection1.Open();
                this.datMat_prima_orc.DeleteCommand.Connection = fbConnection1;
                this.datMat_prima_orc.DeleteCommand.ExecuteNonQuery();
                this.fbConnection1.Close();

                this.datOutros_servicos.DeleteCommand.CommandText =
                    "DELETE FROM OUTROS_SERVICOS_ORC WHERE COD_OUTROS_SERV = '" + tb_cod.Text + "'";
                this.fbConnection1.Open();
                this.datOutros_servicos.DeleteCommand.Connection = fbConnection1;
                this.datOutros_servicos.DeleteCommand.ExecuteNonQuery();
                this.fbConnection1.Close();

                dsOrcamentos.Clear();
                dsItens_orcamento.Clear();
                dsMat_prima_orc.Clear();
                dsOutros_servicos.Clear();

            }
        }

        private void bt_localizar_Click(object sender, EventArgs e)
        {
            form_localiza_orcamento abre_orcamento = new form_localiza_orcamento();
            try
            {
                //this.Close();
                abre_orcamento.ShowDialog();

            }
            finally
            {
                abre_orcamento.Dispose();
                try
                {
                    if (abre_orcamento.cod_escolhido != "")
                    {
                        if (abre_orcamento.cod_escolhido != null)
                        {
                            selecionar_orcamento(abre_orcamento.cod_escolhido);
                            buscarFornecedores();
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Erro");
                    fbConnection1.Close();
                }
            }
        }

        private void selecionar_orcamento(string _cod)
        {
            try
            {
                dsItens_orcamento.Clear();
                dsOrcamentos.Clear();
                this.datOrcamentos.SelectCommand.CommandText =
                "SELECT * FROM ORCAMENTOS WHERE COD_ORCAMENTO = '" + _cod + "'";
                this.fbConnection1.Open();
                this.datOrcamentos.SelectCommand.Connection = fbConnection1;
                this.datOrcamentos.SelectCommand.ExecuteNonQuery();
                datOrcamentos.Fill(ORCAMENTOS);
                this.fbConnection1.Close();

                this.datItens_orcamento.SelectCommand.CommandText =
                "SELECT * FROM ITENS_ORCAMENTO WHERE COD_ORCAMENTO_ITEM_ORC = '" + _cod + "'";
                this.fbConnection1.Open();
                this.datItens_orcamento.SelectCommand.Connection = fbConnection1;
                this.datItens_orcamento.SelectCommand.ExecuteNonQuery();
                datItens_orcamento.Fill(ITENS_ORCAMENTO);
                this.fbConnection1.Close();

                dsMat_prima_orc.Clear();
                this.datMat_prima_orc.SelectCommand.CommandText =
                "SELECT * FROM MAT_PRIMA_ORCAMENTO WHERE COD_ORC_MAT_PRIMA_ORC = '" + _cod + "'";
                this.fbConnection1.Open();
                this.datMat_prima_orc.SelectCommand.Connection = fbConnection1;
                this.datMat_prima_orc.SelectCommand.ExecuteNonQuery();
                datMat_prima_orc.Fill(MAT_PRIMA_ORCAMENTO);
                this.fbConnection1.Close();

                dsOutros_servicos.Clear();
                this.datOutros_servicos.SelectCommand.CommandText =
                    "SELECT * FROM OUTROS_SERVICOS_ORC WHERE COD_ORC_OUTROS = '" + _cod + "'";
                this.fbConnection1.Open();
                this.datOutros_servicos.SelectCommand.Connection = fbConnection1;
                this.datOutros_servicos.SelectCommand.ExecuteNonQuery();
                datOutros_servicos.Fill(OUTROS_SERVICOS_ORC);
                this.fbConnection1.Close();

                dsImpostos_orc.Clear();
                this.datImpostos_orc.SelectCommand.CommandText =
                    "SELECT * FROM IMPOSTOS_ORC WHERE COD_ORC_IMPOSTOS_ORC = '" + _cod + "'";
                this.fbConnection1.Open();
                this.datImpostos_orc.SelectCommand.Connection = fbConnection1;
                this.datImpostos_orc.SelectCommand.ExecuteNonQuery();
                datImpostos_orc.Fill(IMPOSTOS_ORC);
                this.fbConnection1.Close();

                dsGavetas.Clear();
                this.datGavetas.SelectCommand.CommandText =
                    "SELECT * FROM GAVETAS_ORC WHERE COD_ORC_GAVETAS_ORC = '" + _cod + "'";
                this.fbConnection1.Open();
                this.datGavetas.SelectCommand.Connection = fbConnection1;
                this.datGavetas.SelectCommand.ExecuteNonQuery();
                datGavetas.Fill(GAVETAS_ORC);
                this.fbConnection1.Close();

                dsCamaraQuente.Clear();
                this.datCamara_quente.SelectCommand.CommandText =
                    "SELECT * FROM CAMERA_QUENTE_ORC WHERE COD_ORC_CAMERA_QUENTE_ORC = '" + _cod + "'";
                this.fbConnection1.Open();
                this.datCamara_quente.SelectCommand.Connection = fbConnection1;
                this.datCamara_quente.SelectCommand.ExecuteNonQuery();
                datCamara_quente.Fill(CAMERA_QUENTE_ORC);
                this.fbConnection1.Close();
                //Carregar os nomes das operações no dataGridView
                exibirColunasOperacoes();
                carregarNomesDgvItensOrc(_cod);
                tabControl1.SelectedTab = tabPage6;
                tabControl1.SelectedTab = tabPage4;
                ocultarColunasDGV();

                //somar_tudo();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void carregarNomesDgvItensOrc(string _cod)
        {
            DataTable nomeOper = new DataTable();
            int j = 0;

            try
            {
                //Aqui vou selecionar os nomes dos cabeçalhos das colunas gravadas no banco de dados
                FbDataAdapter datTabela = new FbDataAdapter();
                FbCommand selectOper = new FbCommand();
                selectOper.Connection = fbConnection1;
                fbConnection1.Open();
                selectOper.CommandText =
                    "SELECT " +
                        "nome_oper1_orcamento," +
                        "nome_oper2_orcamento," +
                        "nome_oper3_orcamento," +
                        "nome_oper4_orcamento," +
                        "nome_oper5_orcamento," +
                        "nome_oper6_orcamento," +
                        "nome_oper7_orcamento," +
                        "nome_oper8_orcamento," +
                        "nome_oper9_orcamento," +
                        "nome_oper10_orcamento," +
                        "nome_oper11_orcamento," +
                        "nome_oper12_orcamento," +
                        "nome_oper13_orcamento," +
                        "nome_oper14_orcamento," +
                        "nome_oper15_orcamento," +
                        "nome_oper16_orcamento," +
                        "nome_oper17_orcamento," +
                        "nome_oper18_orcamento," +
                        "nome_oper19_orcamento," +
                        "nome_oper20_orcamento," +
                        "nome_oper21_orcamento," +
                        "nome_oper22_orcamento " +
                    "FROM orcamentos WHERE cod_orcamento = " + _cod;
                datTabela.SelectCommand = selectOper;
                datTabela.SelectCommand.ExecuteNonQuery();
                datTabela.Fill(nomeOper);
                fbConnection1.Close();

                for (int i = 0; i < dgvItens_orcamento.Columns.Count - 1; i++)
                {
                    try
                    {
                        int coluna = i + 3;
                        if (dgvItens_orcamento.Columns[coluna].Visible == true)
                        {
                            if (j < 22)
                            {
                                dgvItens_orcamento.Columns[coluna].HeaderText = nomeOper.Rows[0][j].ToString();
                                j++;
                            }
                            else { break; }
                        }
                    }
                    catch (Exception)
                    {

                        //throw;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Houve um erro ao carregar os nomes das operações!");
                fbConnection1.Close();
            }
        }
        private void bt_imprimir_Click(object sender, EventArgs e)
        {
            if (rdbMolde.Checked)
            {
                imprimirMolde();
            }
            else if (rdbPeca.Checked)
            {
                imprimirPeca();
            }
            else
            {
                MessageBox.Show("Selecione 'Molde' ou 'Peça'");
            }
        }

        private void update_cod_orcamento(string _cod, string _revisao)
        {
            try
            {
                if (_revisao != "")
                    _revisao = "-" + _revisao;

                this.datOrcamentos.UpdateCommand.CommandText =
                            "UPDATE ORCAMENTOS SET IMPRESSAO_COD_ORCAMENTO = '" + numero_orc(3, tb_n_orc.Text) + _revisao + "/" + Convert.ToDateTime(tb_data_criacao.Text).Year.ToString() + "' WHERE COD_ORCAMENTO = " + tb_cod.Text + "";
                this.fbConnection1.Open();
                this.datOrcamentos.UpdateCommand.Connection = fbConnection1;
                this.datOrcamentos.UpdateCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private string numero_orc(int tamanho_pretendido, string valor)
        {

            int tamanho = valor.Length;
            for (int p = 0; p < tamanho_pretendido - tamanho; p++)
            {
                valor = "0" + valor;
            }
            return valor;
        }
        string razao_social_empresa = "", nome_fantasia_empresa = "", ie_empresa = "", im_empresa = "", cnae_empresa = "", endereco_empresa = "", n_endereco_empresa = "",
       complemento_empresa = "", bairro_empresa = "", cidade_empresa = "", estado_empresa = "", cep_empresa = "", telefone_empresa = "", cod_cidade_empresa = "", pais_empresa = "",
       cod_pais_empresa = "", licenca_dll_nfe_empresa = "", nome_certificado_nfe_empresa = "", assunto_nfe_email_empresa = "", smtp_nfe_empresa = "", email_nfe_empresa = "",
       senha_email_nfe_empresa = "", logotipo_empresa = "", proxy_empresa = "", usuario_proxy_empresa = "", senha_proxy_empresa = "", crt_empresa = "", portaEmailEmpresa = "",
       sslEmpresa = "", serie_empresa = "", boleto_pedido_empresa = "", cliente_inadimplente_empresa = "", _cod_transmissao = "";

        private void detectar_dados_empresa(out string razao_social_empresa, out string nome_fantasia_empresa, out string cnpj_empresa, out string ie_empresa, out string im_empresa, out string cnae_empresa, out string endereco_empresa, out string n_endereco_empresa,
               out string complemento_empresa, out string bairro_empresa, out string cidade_empresa, out string estado_empresa, out string cep_empresa, out string telefone_empresa, out string cod_cidade_empresa, out string pais_empresa,
               out string cod_pais_empresa, out string licenca_dll_nfe_empresa, out string nome_certificado_nfe_empresa, out string assunto_nfe_email_empresa, out string smtp_nfe_empresa, out string email_nfe_empresa,
               out string senha_email_nfe_empresa, out string logotipo_empresa, out string proxy_empresa, out string usuario_proxy_empresa, out string senha_proxy_empresa,
       out string crt_empresa, out string portaEmailEmpresa, out string sslEmpresa, out string serie_empresa, out string boleto_pedido_empresa, out string cliente_inadimplente_empresa)
        {
            razao_social_empresa = ""; nome_fantasia_empresa = ""; cnpj_empresa = this.cnpj_empresa; ie_empresa = ""; im_empresa = ""; cnae_empresa = ""; endereco_empresa = ""; n_endereco_empresa = "";
            complemento_empresa = ""; bairro_empresa = ""; cidade_empresa = ""; estado_empresa = ""; cep_empresa = ""; telefone_empresa = ""; cod_cidade_empresa = ""; pais_empresa = "";
            cod_pais_empresa = ""; licenca_dll_nfe_empresa = ""; nome_certificado_nfe_empresa = ""; assunto_nfe_email_empresa = ""; smtp_nfe_empresa = ""; email_nfe_empresa = "";
            senha_email_nfe_empresa = ""; logotipo_empresa = ""; proxy_empresa = ""; usuario_proxy_empresa = ""; senha_proxy_empresa = ""; crt_empresa = ""; portaEmailEmpresa = "";
            sslEmpresa = ""; serie_empresa = ""; boleto_pedido_empresa = ""; cliente_inadimplente_empresa = "";
            try
            {
                FbCommand comando = new FbCommand();
                comando.Connection = fbConnection1;
                comando.CommandText = "SELECT * FROM EMPRESA where LICENCA_DLL_NFE_EMPRESA is not null and cnpj_empresa = '" + cnpj_empresa + "'";
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
                    // cnpj_empresa = dr["CNPJ_EMPRESA"].ToString().Replace(".", "").Replace("/", "").Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
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
                    licenca_dll_nfe_empresa = dr["LICENCA_DLL_NFE_EMPRESA"].ToString();
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
                    try
                    {
                        portaEmailEmpresa = dr["PORTA_EMAIL_EMP"].ToString();
                    }
                    catch { }
                    try
                    {
                        sslEmpresa = dr["SSL_EMP"].ToString();
                    }
                    catch { }

                    serie_empresa = dr["SERIE_EMPRESA"].ToString();
                    try
                    {
                        boleto_pedido_empresa = dr["BOLETO_PEDIDO_EMPRESA"].ToString();
                    }
                    catch { }
                    try
                    {
                        cliente_inadimplente_empresa = dr["CLIENTE_INADIMPLENTE_EMPRESA"].ToString();
                    }
                    catch { }
                    //if (tb_cnpj_empresa.Text == "")
                    //{
                    //    tb_cnpj_empresa.Text = cnpj_empresa;
                    //    tb_descricao_empresa.Text = razao_social_empresa;
                    //}
                }

            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }


        private void form_orcamentos_Load(object sender, EventArgs e)
        {
            detectar_dados_empresa(out razao_social_empresa, out nome_fantasia_empresa, out cnpj_empresa, out ie_empresa, out im_empresa, out cnae_empresa, out endereco_empresa, out n_endereco_empresa,
      out complemento_empresa, out bairro_empresa, out cidade_empresa, out estado_empresa, out cep_empresa, out telefone_empresa, out cod_cidade_empresa, out pais_empresa,
      out cod_pais_empresa, out licenca_dll_nfe_empresa, out nome_certificado_nfe_empresa, out assunto_nfe_email_empresa, out smtp_nfe_empresa, out email_nfe_empresa,
      out senha_email_nfe_empresa, out logotipo_empresa, out proxy_empresa, out usuario_proxy_empresa, out senha_proxy_empresa, out crt_empresa, out portaEmailEmpresa, out sslEmpresa, out serie_empresa,
      out boleto_pedido_empresa, out cliente_inadimplente_empresa);

            rdbPeca.Checked = true;
            if (cod_a_abrir != "" && cod_a_abrir != null)
                selecionar_orcamento(cod_a_abrir);
        }

        private void imprimirPeca()
        {

            if (tb_data_orcamento.Text == "")
                MessageBox.Show("Digite uma data para o orçamento por favor");
            else
            {
                try
                {
                    somar_tudo();
                    Salvar();
                    double total = 0, totalCamaraBicoQuente = 0;
                    decimal valorOutrosServicos = 0;
                    Double.TryParse(tb_valor_total.Text, out total);
                    if (cb_Camara_quente.Checked)
                    {
                        Double.TryParse(tbTotalCameraQuente.Text, out totalCamaraBicoQuente);
                    }
                    else if (cb_Bico_quente.Checked)
                    {
                        Double.TryParse(tbTotalBicoQuente.Text, out totalCamaraBicoQuente);
                    }

                    comando_select.CommandText = "SELECT * FROM CLIENTES WHERE RAZAO_SOCIAL = '" + tb_cliente.Text + "'";
                    DataSet cliente = new DataSet();
                    fbConnection1.Open();
                    datClientes.SelectCommand = comando_select;
                    datClientes.Fill(cliente);
                    string _cod = "";
                    foreach (DataRow dr in cliente.Tables[0].Rows)
                    {
                        _cod = dr["COD_CLIENTE"].ToString();

                    }
                    fbConnection1.Close();
                    update_cod_orcamento(_cod, tb_revisao.Text);

                    this.datOrcamentos.SelectCommand.CommandText =
                        "SELECT * FROM ORCAMENTOS WHERE COD_ORCAMENTO = '" + tb_cod.Text + "'";
                    this.fbConnection1.Open();
                    this.datOrcamentos.SelectCommand.Connection = fbConnection1;
                    this.datOrcamentos.SelectCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();

                    this.datItens_orcamento.SelectCommand.CommandText =
                        "SELECT * FROM ITENS_ORCAMENTO WHERE COD_ORCAMENTO_ITEM_ORC = '" + tb_cod.Text + "'";
                    this.fbConnection1.Open();
                    this.datItens_orcamento.SelectCommand.Connection = fbConnection1;
                    this.datItens_orcamento.SelectCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();

                    FbCommand cmdEmpresa = new FbCommand();
                    FbDataAdapter datEmpresa = new FbDataAdapter();
                    cmdEmpresa.CommandText =
                      "SELECT * FROM EMPRESA WHERE CNPJ_EMPRESA = '" + cnpj_empresa + "'";
                    datEmpresa.SelectCommand = cmdEmpresa;
                    cmdEmpresa.Connection = fbConnection1;
                    fbConnection1.Open();
                    datEmpresa.SelectCommand.ExecuteNonQuery();
                    fbConnection1.Close();

                    dsOrcamentoMolde orc = new dsOrcamentoMolde();
                    fbConnection1.Open();
                    datClientes.Fill(orc.CLIENTES);
                    datOrcamentos.Fill(orc.ORCAMENTOS);
                    datItens_orcamento.Fill(orc.ITENS_ORCAMENTO);
                    datEmpresa.Fill(orc.EMPRESA);
                    datOutros_servicos.Fill(orc.OUTROS_SERVICOS_ORC);
                    fbConnection1.Close();

                    valorOutrosServicos = buscarValorServicosPorPeca();

                    double ipi = 0;
                    
                        somar_impostos(out ipi);
                        ipi = Convert.ToDouble(tb_valor_total.Text) * ipi / 100;
                        if (cbNao_imprimir_sem_imposto.Checked)
                        {
                            orc.totais.AddtotaisRow(0, total, totalSemImpostos, totalCamaraBicoQuente, Convert.ToDouble(valorOutrosServicos), ipi, "1");
                        }
                        else
                            orc.totais.AddtotaisRow(0, total, totalSemImpostos, totalCamaraBicoQuente, Convert.ToDouble(valorOutrosServicos), ipi, "0");
                   // orc.totais.AddtotaisRow(0, total, totalSemImpostos, totalCamaraBicoQuente, Convert.ToDouble(valorOutrosServicos), ipi);


                    crOrcamentos_pecas orc_novo = new crOrcamentos_pecas();
                    orc_novo.SetDataSource(orc);
                    orc_novo.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4;
                    orc_novo.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto;
                    form_imprimir imprimir = new form_imprimir(orc_novo);
                    imprimir.orcamento_peca = true;
                    imprimir.n_orcamento = "FB_002A_PROPOSTA_COMERCIAL_" + numero_orc(4, tb_n_orc.Text) + "." + tb_revisao.Text + "." + Convert.ToDateTime(tb_data_criacao.Text).Year.ToString();
                    imprimir.ano_orcamento = Convert.ToDateTime(tb_data_criacao.Text).Year.ToString();
                    imprimir.Show();
                }
                catch (Exception ex)
                {
                    fbConnection1.Close();
                    MessageBox.Show(ex.ToString());
                }

                //PARA FINALIZAR ACERTAR IMPOSTOS = VALOR TOTAL / (100 - IMPOSTO)
                //EM MATERIA DAS CAV. E TIPO DE ACABAMENTO PERMITIR MAIS DE UMA MARCAÇÃO
            }
            //if (tb_data_orcamento.Text == "")
            //    MessageBox.Show("Digite uma data para o orçamento por favor");
            //else
            //{
            //    comando_select.CommandText = "SELECT * FROM CLIENTES WHERE RAZAO_SOCIAL = '" + tb_cliente.Text + "'";
            //    DataSet cliente = new DataSet();
            //    fbConnection1.Open();
            //    datClientes.SelectCommand = comando_select;
            //    datClientes.Fill(cliente);
            //    string _cod = "";
            //    foreach (DataRow dr in cliente.Tables[0].Rows)
            //    {
            //        _cod = dr["COD_CLIENTE"].ToString();

            //    }
            //    fbConnection1.Close();

            //    update_cod_orcamento(_cod);
            //    this.datOrcamentos.SelectCommand.CommandText =
            //            "SELECT * FROM ORCAMENTOS WHERE COD_ORCAMENTO = '" + tb_cod.Text + "'";
            //    this.fbConnection1.Open();
            //    this.datOrcamentos.SelectCommand.Connection = fbConnection1;
            //    this.datOrcamentos.SelectCommand.ExecuteNonQuery();
            //    fbConnection1.Close();

            //    this.datClientes.SelectCommand.CommandText =
            //            "SELECT * FROM CLIENTES WHERE RAZAO_SOCIAL = '" + tb_cliente.Text + "'";
            //    this.fbConnection1.Open();
            //    this.datClientes.SelectCommand.Connection = fbConnection1;
            //    this.datClientes.SelectCommand.ExecuteNonQuery();

            //    this.fbConnection1.Close();

            //    dsOrcamentos orc = new dsOrcamentos();
            //    fbConnection1.Open();
            //    datOrcamentos.Fill(orc.ORCAMENTOS);
            //    datClientes.Fill(orc.CLIENTES);
            //    datItens_orcamento.Fill(orc.ITENS_ORCAMENTO);
            //    datMat_prima_orc.Fill(orc.MAT_PRIMA_ORCAMENTO);
            //    fbConnection1.Close();
            //    crOrcamentos_pecas orc_novo = new crOrcamentos_pecas();
            //    orc_novo.SetDataSource(orc);
            //    orc_novo.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4;
            //    orc_novo.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto;
            //    form_imprimir imprimir = new form_imprimir(orc_novo);
            //    imprimir.orcamento = true;
            //    imprimir.n_orcamento = "FB_002A_PROPOSTA_COMERCIAL_" + numero_orc(3, tb_cod.Text) + "." + Convert.ToDateTime(tb_data_orcamento.Text).Year.ToString();
            //    imprimir.Show();
            //}
        }

        private decimal buscarValorServicosPorPeca()
        {
            decimal ValorServicosPorPeca = 0;
            try
            {
                int qtde = 0;
                decimal total_serv = 0;
                FbCommand cmd = new FbCommand();
                FbDataAdapter datCmd = new FbDataAdapter();
                DataTable dtCmd = new DataTable();
                cmd.CommandText =
                    "SELECT sum(qtde_item_orc) as qtde FROM ITENS_ORCAMENTO WHERE COD_ORCAMENTO_ITEM_ORC = '" + tb_cod.Text + "'";
                cmd.Connection = fbConnection1;
                datCmd.SelectCommand = cmd;
                fbConnection1.Open();
                qtde = Convert.ToInt32(datCmd.SelectCommand.ExecuteScalar());
                fbConnection1.Close();

                decimal impostos = 1;
                if (tb_valor_impostos.Text != "")
                {
                    impostos = Convert.ToDecimal(tb_valor_impostos.Text) / 100;
                    impostos = 1 - impostos;
                }

                Decimal.TryParse(tb_total_outras.Text, out total_serv);
                ValorServicosPorPeca = (total_serv / qtde) / impostos;
                ValorServicosPorPeca = Convert.ToDecimal(ValorServicosPorPeca.ToString("N2"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return ValorServicosPorPeca;
        }
        private void imprimirMolde()
        {
            if (tb_data_orcamento.Text == "")
                MessageBox.Show("Digite uma data para o orçamento por favor");
            else
            {
                somar_tudo();
                Salvar();
                double total = 0, totalCamaraBicoQuente = 0;
                Double.TryParse(tb_total_orcamento.Text, out total);
                if (cb_Camara_quente.Checked)
                {
                    Double.TryParse(tbTotalCameraQuente.Text, out totalCamaraBicoQuente);
                }
                else if (cb_Bico_quente.Checked)
                {
                    Double.TryParse(tbTotalBicoQuente.Text, out totalCamaraBicoQuente);
                }



                comando_select.CommandText = "SELECT * FROM CLIENTES WHERE RAZAO_SOCIAL = '" + tb_cliente.Text + "'";
                DataSet cliente = new DataSet();
                fbConnection1.Open();
                datClientes.SelectCommand = comando_select;
                datClientes.Fill(cliente);
                string _cod = "";
                foreach (DataRow dr in cliente.Tables[0].Rows)
                {
                    _cod = dr["COD_CLIENTE"].ToString();

                }
                fbConnection1.Close();
                update_cod_orcamento(_cod, tb_revisao.Text);

                this.datOrcamentos.SelectCommand.CommandText =
                    "SELECT * FROM ORCAMENTOS WHERE COD_ORCAMENTO = '" + tb_cod.Text + "'";
                this.fbConnection1.Open();
                this.datOrcamentos.SelectCommand.Connection = fbConnection1;
                this.datOrcamentos.SelectCommand.ExecuteNonQuery();
                this.fbConnection1.Close();

                FbCommand cmdEmpresa = new FbCommand();
                FbDataAdapter datEmpresa = new FbDataAdapter();
                cmdEmpresa.CommandText =
                  "SELECT * FROM EMPRESA";
                datEmpresa.SelectCommand = cmdEmpresa;
                cmdEmpresa.Connection = fbConnection1;
                fbConnection1.Open();
                datEmpresa.SelectCommand.ExecuteNonQuery();
                fbConnection1.Close();

                dsOrcamentoMolde orc = new dsOrcamentoMolde();
                fbConnection1.Open();
                datClientes.Fill(orc.CLIENTES);
                datOrcamentos.Fill(orc.ORCAMENTOS);
                datEmpresa.Fill(orc.EMPRESA);

                double ipi = 0;
               
                
                somar_impostos(out ipi);
                ipi = Convert.ToDouble(tb_total_orcamento.Text) * ipi / 100;
                if (cbNao_imprimir_sem_imposto.Checked)
                {
                     orc.totais.AddtotaisRow(0, total, totalSemImpostos, totalCamaraBicoQuente, 0, ipi, "1");
                }
                 else
                    orc.totais.AddtotaisRow(0, total, totalSemImpostos, totalCamaraBicoQuente, 0, ipi, "0");

               
                fbConnection1.Close();

                crOrcamentos_sem_horas orc_novo = new crOrcamentos_sem_horas();
                orc_novo.SetDataSource(orc);
                orc_novo.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4;
                orc_novo.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto;
                form_imprimir imprimir = new form_imprimir(orc_novo);
                imprimir.orcamento_molde = true;
                imprimir.n_orcamento = "FB_002_PROPOSTA_COMERCIAL_" + numero_orc(4, tb_n_orc.Text) + "." + tb_revisao.Text + "." + Convert.ToDateTime(tb_data_criacao.Text).Year.ToString();
                imprimir.ano_orcamento = Convert.ToDateTime(tb_data_criacao.Text).Year.ToString();
                imprimir.Show();
            }

            //if (tb_data_orcamento.Text == "")
            //    MessageBox.Show("Digite uma data para o orçamento por favor");
            //else
            //{
            //    Salvar();
            //    comando_select.CommandText = "SELECT * FROM CLIENTES WHERE RAZAO_SOCIAL = '" + tb_cliente.Text + "'";
            //    DataSet cliente = new DataSet();
            //    fbConnection1.Open();
            //    datClientes.SelectCommand = comando_select;
            //    datClientes.Fill(cliente);
            //    string _cod = "";
            //    foreach (DataRow dr in cliente.Tables[0].Rows)
            //    {
            //        _cod = dr["COD_CLIENTE"].ToString();

            //    }
            //    fbConnection1.Close();
            //    update_cod_orcamento(_cod);

            //    this.datOrcamentos.SelectCommand.CommandText =
            //        "SELECT * FROM ORCAMENTOS WHERE COD_ORCAMENTO = '" + tb_cod.Text + "'";
            //    this.fbConnection1.Open();
            //    this.datOrcamentos.SelectCommand.Connection = fbConnection1;
            //    this.datOrcamentos.SelectCommand.ExecuteNonQuery();

            //    this.fbConnection1.Close();
            //    dsOrcamentos orc = new dsOrcamentos();
            //    fbConnection1.Open();
            //    datClientes.Fill(orc.CLIENTES);
            //    datOrcamentos.Fill(orc.ORCAMENTOS);
            //    datItens_orcamento.Fill(orc.ITENS_ORCAMENTO);
            //    fbConnection1.Close();
            //    crOrcamentos_sem_horas orc_novo = new crOrcamentos_sem_horas();
            //    orc_novo.SetDataSource(orc);
            //    orc_novo.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4;
            //    orc_novo.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto;
            //    form_imprimir imprimir = new form_imprimir(orc_novo);
            //    imprimir.orcamento = true;
            //    imprimir.n_orcamento = "FB_002_PROPOSTA_COMERCIAL_" + numero_orc(3, tb_cod.Text) + "." + Convert.ToDateTime(tb_data_orcamento.Text).Year.ToString();
            //    imprimir.Show();

            //    //PARA FINALIZAR ACERTAR IMPOSTOS = VALOR TOTAL / (100 - IMPOSTO)
            //    //EM MATERIA DAS CAV. E TIPO DE ACABAMENTO PERMITIR MAIS DE UMA MARCAÇÃO

            //}
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void detectar_dados_empresa(out string razao_social_empresa, out string nome_fantasia_empresa, out string cnpj_empresa, out string ie_empresa, out string im_empresa, out string endereco_empresa, out string n_endereco_empresa,
                    out string complemento_empresa, out string bairro_empresa, out string cidade_empresa, out string estado_empresa, out string cep_empresa, out string telefone_empresa, out string cod_cidade_empresa, out string pais_empresa,
                    out string cod_pais_empresa, out string licenca_dll_nfe_empresa, out string nome_certificado_nfe_empresa, out string assunto_nfe_email_empresa, out string smtp_nfe_empresa, out string email_nfe_empresa,
                    out string senha_email_nfe_empresa, out string logotipo_empresa, out string proxy_empresa, out string usuario_proxy_empresa, out string senha_proxy_empresa)
        {
            razao_social_empresa = ""; nome_fantasia_empresa = ""; cnpj_empresa = ""; ie_empresa = ""; im_empresa = ""; endereco_empresa = ""; n_endereco_empresa = "";
            complemento_empresa = ""; bairro_empresa = ""; cidade_empresa = ""; estado_empresa = ""; cep_empresa = ""; telefone_empresa = ""; cod_cidade_empresa = ""; pais_empresa = "";
            cod_pais_empresa = ""; licenca_dll_nfe_empresa = ""; nome_certificado_nfe_empresa = ""; assunto_nfe_email_empresa = ""; smtp_nfe_empresa = ""; email_nfe_empresa = "";
            senha_email_nfe_empresa = ""; logotipo_empresa = ""; proxy_empresa = ""; usuario_proxy_empresa = ""; senha_proxy_empresa = "";
            try
            {
                comando_select.CommandText = "SELECT * FROM EMPRESA";
                DataSet empresa = new DataSet();
                fbConnection1.Open();
                datEmpresa.SelectCommand = comando_select;
                datEmpresa.Fill(empresa);

                foreach (DataRow dr in empresa.Tables[0].Rows)
                {
                    razao_social_empresa = dr["RAZAO_SOCIAL_EMPRESA"].ToString();
                    nome_fantasia_empresa = dr["NOME_FANTASIA_EMPRESA"].ToString();
                    cnpj_empresa = dr["CNPJ_EMPRESA"].ToString();
                    ie_empresa = dr["IE_EMPRESA"].ToString();
                    im_empresa = dr["IM_EMPRESA"].ToString();
                    endereco_empresa = dr["ENDERECO_EMPRESA"].ToString();
                    n_endereco_empresa = dr["N_ENDERECO_EMPRESA"].ToString();
                    complemento_empresa = dr["COMPLEMENTO_EMPRESA"].ToString();
                    bairro_empresa = dr["BAIRRO_EMPRESA"].ToString();
                    cidade_empresa = dr["CIDADE_EMPRESA"].ToString();
                    estado_empresa = dr["ESTADO_EMPRESA"].ToString();
                    cep_empresa = dr["CEP_EMPRESA"].ToString();
                    telefone_empresa = dr["TELEFONE_EMPRESA"].ToString();
                    cod_cidade_empresa = dr["COD_CIDADE_EMPRESA"].ToString();
                    pais_empresa = dr["PAIS_EMPRESA"].ToString();
                    cod_cidade_empresa = dr["COD_CIDADE_EMPRESA"].ToString();
                    licenca_dll_nfe_empresa = dr["LICENCA_DLL_NFE_EMPRESA"].ToString();
                    nome_certificado_nfe_empresa = dr["NOME_CERTIFICADO_NFE_EMPRESA"].ToString();
                    assunto_nfe_email_empresa = dr["ASSUNTO_NFE_EMAIL_EMPRESA"].ToString();
                    smtp_nfe_empresa = dr["SMTP_NFE_EMPRESA"].ToString();
                    email_nfe_empresa = dr["EMAIL_NFE_EMPRESA"].ToString();
                    senha_email_nfe_empresa = dr["SENHA_EMAIL_NFE_EMPRESA"].ToString();
                    logotipo_empresa = dr["LOGOTIPO_EMPRESA"].ToString();
                    proxy_empresa = dr["PROXY_EMPRESA"].ToString();
                    usuario_proxy_empresa = dr["USUARIO_PROXY_EMPRESA"].ToString();
                    senha_proxy_empresa = dr["SENHA_PROXY_EMPRESA"].ToString();
                }
                this.fbConnection1.Close();
            }
            catch
            {
                fbConnection1.Close();
                MessageBox.Show("Erro ao buscar dados da empresa");
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            enviar_email();
            //form_busca_contato busca = new form_busca_contato();
            //try
            //{
            //    busca.cod_cli_forn = detectar_cod();
            //    busca.cli_forn = "CLIENTE";
            //    busca.ShowDialog();
            //}
            //finally
            //{
                //for (int i = 0; i < busca.qtde; i++)
                //{
                    //enviar_email(busca.valores[i, 1]);
                //}
            //}
        }

        private string detectar_cod()
        {
            comando_select.CommandText =
                "SELECT COD_CLIENTE FROM CLIENTES WHERE RAZAO_SOCIAL = '" + tb_cliente.Text + "'";
            fbConnection1.Open();
            datClientes.SelectCommand = comando_select;
            DataSet Clientes = new DataSet();
            datClientes.Fill(Clientes);
            fbConnection1.Close();
            try
            {
                DataRow dr = Clientes.Tables[0].Rows[0];
                return dr[0].ToString();
            }
            catch
            {
                return "erro";
            }

        }
        private void enviar_email(/*string email*/)
        {
            string razao_social_empresa = "", nome_fantasia_empresa = "", cnpj_empresa = "", ie_empresa = "", im_empresa = "", endereco_empresa = "", n_endereco_empresa = "",
                complemento_empresa = "", bairro_empresa = "", cidade_empresa = "", estado_empresa = "", cep_empresa = "", telefone_empresa = "", cod_cidade_empresa = "", pais_empresa = "",
                cod_pais_empresa = "", licenca_dll_nfe_empresa = "", nome_certificado_nfe_empresa = "", assunto_nfe_email_empresa = "", smtp_nfe_empresa = "", email_nfe_empresa = "",
                senha_email_nfe_empresa = "", logotipo_empresa = "", proxy_empresa = "", usuario_proxy_empresa = "", senha_proxy_empresa = "";

            detectar_dados_empresa(out razao_social_empresa, out nome_fantasia_empresa, out cnpj_empresa, out ie_empresa, out im_empresa, out endereco_empresa, out n_endereco_empresa,
                    out complemento_empresa, out bairro_empresa, out cidade_empresa, out estado_empresa, out cep_empresa, out telefone_empresa, out cod_cidade_empresa, out pais_empresa,
                    out cod_pais_empresa, out licenca_dll_nfe_empresa, out nome_certificado_nfe_empresa, out assunto_nfe_email_empresa, out smtp_nfe_empresa, out email_nfe_empresa,
                    out senha_email_nfe_empresa, out logotipo_empresa, out proxy_empresa, out usuario_proxy_empresa, out senha_proxy_empresa);

            
            comando_select.CommandText = "SELECT * FROM CLIENTES WHERE RAZAO_SOCIAL = '" + tb_cliente.Text + "'";
            DataSet cliente = new DataSet();
            fbConnection1.Open();
            datClientes.SelectCommand = comando_select;
            datClientes.Fill(cliente);
            string _cod = "";
            foreach (DataRow dr in cliente.Tables[0].Rows)
            {
                _cod = dr["COD_CLIENTE"].ToString();

            }
            fbConnection1.Close();
            string _caminho_arquivo = "";
            string _caminho_arquivo2 = "";
            if (rdbMolde.Checked)
            {
                if (cbProposta.Checked)
                {
                    _caminho_arquivo = "c:\\evolucao\\ORCAMENTOS\\" + "ORCAMENTO_FB_002_PROPOSTA_COMERCIAL_" + numero_orc(3, tb_cod.Text) + "." + Convert.ToDateTime(tb_data_orcamento.Text).Year.ToString() + ".pdf";
                }
                if (cbAnalise.Checked)
                {
                    _caminho_arquivo2 = "c:\\evolucao\\ORCAMENTOS\\" + "ORCAMENTO_FB_001_ANALISE_CRITICA_DE_CUSTO_" + numero_orc(3, tb_cod.Text) + "." + Convert.ToDateTime(tb_data_orcamento.Text).Year.ToString() + ".pdf";
                }
            }
            else if (rdbPeca.Checked)
            {
                //if (cbProposta.Checked)
                //{
                    _caminho_arquivo = "c:\\evolucao\\ORCAMENTOS\\" + "ORCAMENTO_FB_002A_PROPOSTA_COMERCIAL_" + numero_orc(4, tb_cod.Text) + "." + tb_revisao.Text + "." + Convert.ToDateTime(tb_data_orcamento.Text).Year.ToString() + ".pdf";
                //}
                if (cbAnalise.Checked)
                {
                    _caminho_arquivo2 = "c:\\evolucao\\ORCAMENTOS\\" + "ORCAMENTO_FB_001A_ANALISE_CRITICA_DE_CUSTO_" + numero_orc(4, tb_cod.Text) + "." + Convert.ToDateTime(tb_data_orcamento.Text).Year.ToString() + ".pdf";
                }
               
            }
            string _assunto = "Novo Orçamento: " + numero_orc(3, tb_cod.Text) + "." + Convert.ToDateTime(tb_data_orcamento.Text).Year.ToString();
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


"Prezado cliente, <br> " +
"Segue anexo orçamento nº " + numero_orc(3, tb_cod.Text) + "." + Convert.ToDateTime(tb_data_orcamento.Text).Year.ToString() + " conforme solicitado. Caso haja alguma dúvida entrar em contato.<br>" +

"Atenciosamente, <br>" +


"<br><br>" +
"______________________________<br>" +
" "+ razao_social_empresa + "<br>" +
"" + telefone_empresa + "<br>" +
"e-mail: <a href='" + email_nfe_empresa + "'>" + email_nfe_empresa + "</a><br>" +
"<p class=MsoNormal><span style='font-size:10.0pt;font-family:'Comic Sans MS';" +
"mso-no-proof:yes'>&nbsp;<o:p></o:p></span></p>" +
"</font>" +
"</div>" +
"</body>" +
"</html>";

            Email_orcamento novo_email = new Email_orcamento();
            bool _erro;
            novo_email.EnviarEmail(detectar_email_cliente(), _assunto, _mensagem, _caminho_arquivo, _caminho_arquivo2, email_nfe_empresa, senha_email_nfe_empresa, smtp_nfe_empresa, out _erro);

            if (_erro == false)
            {
                if (barra_status.Text == "Status Atual")
                    barra_status.Text = "";
                barra_status.Text = barra_status.Text + "Email enviado com sucesso. ";
                inserir_historico_email(detectar_email(), _caminho_arquivo, _assunto);
            }
            else
            {
                if (barra_status.Text == "Status Atual")
                    barra_status.Text = "";
                barra_status.Text = barra_status.Text + "Email não enviado. Favor verificar dados. ";
            }

            //Envia o email para a lista de contatos  
            string[] destinatarios = new string[50];
            int numero_destinatarios = detectar_destinatarios(out destinatarios);
            if (numero_destinatarios > 0)
            {
                string mensagem = "";
                for (int j = 0; j < numero_destinatarios; j++)
                {
                    novo_email.EnviarEmail(destinatarios[j], _assunto, _mensagem, _caminho_arquivo, _caminho_arquivo2, email_nfe_empresa, senha_email_nfe_empresa, smtp_nfe_empresa, out _erro);

                    if (_erro == false)
                    {
                        barra_status.Text = barra_status.Text + "Email enviado com sucesso para: " + destinatarios[j] + ". /r/n";
                        mensagem = mensagem + "Email enviado com sucesso para: " + destinatarios[j] + ".";
                    }
                    else
                    {
                        barra_status.Text = barra_status.Text + "Email não enviado para: " + destinatarios[j] + ". Favor verificar dados. ";
                        mensagem = mensagem + "Email não enviado para: " + destinatarios[j] + ". Favor verificar dados. /r/n ";
                    }
                }
                MessageBox.Show(mensagem);
            }
            else
            {
                MessageBox.Show("Não existem destinátios para NFe cadastrados no sistema, favor verificar");
            }

        }

        private string detectar_email_cliente()
        {
            comando_select.CommandText = "SELECT EMAIL " +
               "FROM CLIENTES WHERE RAZAO_SOCIAL = '" + tb_cliente.Text + "'";
            DataSet cliente = new DataSet();
            fbConnection1.Open();
            datClientes.SelectCommand = comando_select;
            datClientes.Fill(cliente);
            string cliente_atual = "";
            foreach (DataRow dr in cliente.Tables[0].Rows)
            {

                cliente_atual = dr["EMAIL"].ToString();
            }

            this.fbConnection1.Close();
            return cliente_atual;
        }

        private int detectar_destinatarios(out string[] destinatarios)
        {
            try
            {
                string[] _destinatarios = new string[100];
                string cod_cliente = detectar_cod_cliente(tb_cnpj_cliente.Text);
                FbCommand select_destinatarios = new FbCommand();
                select_destinatarios.CommandText =
                    "SELECT EMAIL_CONTATO FROM CONTATOS WHERE COD_CLIENTE_FORN_CONTATO = '" +
                    cod_cliente + "' AND (TIPO_CONTATO LIKE ('%ORCAMENTO%') OR TIPO_CONTATO LIKE ('%orcamento%'))";
                select_destinatarios.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datContatos = new FbDataAdapter();
                datContatos.SelectCommand = select_destinatarios;
                DataSet dsContatos = new DataSet();
                datContatos.Fill(dsContatos);
                fbConnection1.Close();
                int i = 0;
                foreach (DataRow dr in dsContatos.Tables[0].Rows)
                {
                    _destinatarios[i] = dr[0].ToString();
                    i++;
                }
                destinatarios = _destinatarios;
                return i;
            }
            catch (Exception a)
            {
                destinatarios = null;
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
                return 0;
            }
        }

        private string detectar_cod_cliente(string _cnpj)
        {
            string _cod = "";
            FbCommand comando = new FbCommand();
            comando.Connection = fbConnection1;
            comando.CommandText =
                "SELECT * " +
                "FROM CLIENTES WHERE CNPJ = '" + _cnpj + "'";
            DataSet nf = new DataSet();
            fbConnection1.Open();
            datClientes.SelectCommand = comando;
            datClientes.Fill(nf);
            int n = 0;
            foreach (DataRow dr in nf.Tables[0].Rows)
            {

                _cod = dr["COD_CLIENTE"].ToString();

            }
            fbConnection1.Close();
            return _cod;
        }

        private void inserir_historico_email(string destinatario, string caminho, string tipo)
        {
            try
            {
                this.datEmails_enviados.InsertCommand.CommandText =
                           "INSERT INTO EMAILS_ENVIADOS (DESTINATARIO_EMAIL_ENVIADO, DATA_EMAIL_ENVIADO, TIPO_EMAIL_ENVIADO, HORA_EMAIL_ENVIADO, CAMINHO_ARQUIVO_EMAIL_ENVIADO)" +
                           "VALUES ('" + destinatario + "','" + DateTime.Now.ToShortDateString().Replace("/", ".") + "','" + tipo + "','" + DateTime.Now.ToShortTimeString() + "','" + caminho + "')";
                this.fbConnection1.Open();
                this.datEmails_enviados.InsertCommand.Connection = fbConnection1;
                this.datEmails_enviados.InsertCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
            }
            catch
            {
                MessageBox.Show("Erro na inserção do histórico de emails enviados");
                fbConnection1.Close();
            }
        }


        private string detectar_email()
        {
            comando_select.CommandText = "SELECT EMAIL2 " +
                "FROM CLIENTES WHERE RAZAO_SOCIAL = '" + tb_cliente.Text + "'";
            DataSet cliente = new DataSet();
            fbConnection1.Open();
            datClientes.SelectCommand = comando_select;
            datClientes.Fill(cliente);
            string cliente_atual = "";
            foreach (DataRow dr in cliente.Tables[0].Rows)
            {

                cliente_atual = dr["EMAIL2"].ToString();
            }

            this.fbConnection1.Close();
            return cliente_atual;

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            somar_tudo();
        }

        private void somar_tudo()
        {
            somar_materia_prima();
            somar_outras_despesas();
            double ipi = 0;
            somar_impostos(out ipi);
            //somar_horas();
            somar_projeto();
            somar_servicos_molde();
            somar_material_peca();
            double _valor_horas = 0, _valor_cad = 0, _valor_modelamento = 0, _valor_mat_prima = 0, _valor_try_out = 0, _valor_transporte = 0, _valor_outras_despesas = 0, _valor_servicos_molde = 0, _valor_material_peça = 0;
            try
            {
                _valor_horas = Convert.ToDouble(tb_valor_total.Text);
            }
            catch
            { }
            try
            {
                _valor_cad = Convert.ToDouble(tb_valor_total_cad.Text);
            }
            catch
            { }
            try
            {
                _valor_modelamento = Convert.ToDouble(tb_valor_total_modelamento.Text);
            }
            catch
            { }
            try
            {
                _valor_mat_prima = Convert.ToDouble(tb_materia_prima.Text);
            }
            catch
            { }
            try
            {
                _valor_outras_despesas = Convert.ToDouble(tb_total_outras.Text);
            }
            catch
            { }

            try
            {
                _valor_servicos_molde = Convert.ToDouble(tb_total_servicos_molde.Text);
            }
            catch
            { }

            try
            {
                _valor_material_peça = Convert.ToDouble(tb_total_material_peca.Text);
            }
            catch
            { }

            double impostos = 1;
            if (tb_valor_impostos.Text != "")
            {
                //o ipi não será somado ao total , aoenas na impressão
                impostos = (Convert.ToDouble(tb_valor_impostos.Text)) / 100;
                impostos = 1 - impostos;
            }
            double _total_geral = (_valor_transporte + _valor_try_out + _valor_modelamento + _valor_outras_despesas + _valor_mat_prima + _valor_horas + _valor_cad + _valor_servicos_molde + _valor_material_peça) / impostos;
            totalSemImpostos = (_valor_transporte + _valor_try_out + _valor_modelamento + _valor_outras_despesas + _valor_mat_prima + _valor_horas + _valor_cad + _valor_servicos_molde + _valor_material_peça);
            tb_total_orcamento.Text = _total_geral.ToString("n2");
            tb_total_orcamento_sem_imposto.Text = totalSemImpostos.ToString("n2");
            //Salvar();
        }

        private void somar_material_peca()
        {
            double _valor_mat = 0, _total = 0, _qtde = 0; ;
            for (int i = 0; i < dgvItens_orcamento.RowCount; i++)
            {
                try
                {
                    _qtde = Convert.ToDouble(dgvItens_orcamento.Rows[i].Cells["col_qtde"].Value.ToString());
                    Double.TryParse(dgvItens_orcamento.Rows[i].Cells["colValorMaterial"].Value.ToString(), out _valor_mat);
                    _valor_mat = _valor_mat * _qtde;
                    _total += _valor_mat;
                }
                catch { }
            }
            tb_total_material_peca.Text = _total.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            somar_projeto();
        }

        private void somar_projeto()
        {
            double _total_cad = 0, _total_modelamento = 0;
            try
            {
                _total_cad = Convert.ToDouble(tb_horas_cad.Text) * Convert.ToDouble(tb_custo_cad.Text);
            }
            catch { }
            tb_valor_total_cad.Text = _total_cad.ToString("n2");

            try
            {
                _total_modelamento = Convert.ToDouble(tb_horas_modelamento.Text) * Convert.ToDouble(tb_custo_modelamento.Text);
            }
            catch { }
            tb_valor_total_modelamento.Text = _total_modelamento.ToString("n2");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            somar_materia_prima();
        }

        private void somar_materia_prima()
        {
            double _total_mat = 0, _qtde_mat = 0, _valor_mat = 0, _total = 0;
            for (int i = 0; i < dgvMat_prima_orc.RowCount; i++)
            {
                try
                {
                    Double.TryParse(dgvMat_prima_orc.Rows[i].Cells["col_qtde_mat"].Value.ToString(), out _qtde_mat);
                    Double.TryParse(dgvMat_prima_orc.Rows[i].Cells["col_valor_mat"].Value.ToString(), out _valor_mat);
                    _total = _qtde_mat * _valor_mat;
                    dgvMat_prima_orc.Rows[i].Cells["col_total"].Value = _total;
                }
                catch { }
            }

            for (int i = 0; i < dgvMat_prima_orc.RowCount; i++)
            {
                try
                {
                    _total_mat = _total_mat + Convert.ToDouble(dgvMat_prima_orc.Rows[i].Cells["col_total"].Value.ToString());
                }
                catch { }
            }
            tb_materia_prima.Text = _total_mat.ToString();
        }

        private void tb_total_mat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                inserir_item();
            }
        }

        private void inserir_item()
        {
            try
            {
                double valor_total = 0;
                double qtde_unidade = 0;
                double valor_unidade = 0;
                string item = "";
                string unidade = "";
                if (tb_item_mat.Text != "")
                {
                    item = "'" + Convert.ToString(tb_item_mat.Text) + "'";
                }
                else
                {
                    item = "null";
                }
                string descricao = "null";
                /*
                if (tb_descricao_mat.Text != "")
                {
                    descricao = "'" + Convert.ToString(tb_descricao_mat.Text) + "'";
                }
                else
                {
                    descricao = "null";
                }
                 * */

                string qtde = "";
                if (tb_qtde_mat.Text != "")
                {
                    try
                    {
                        qtde_unidade = Convert.ToDouble(tb_qtde_mat.Text);
                    }
                    catch { }
                    qtde = "'" + Convert.ToString(tb_qtde_mat.Text).Replace(".", "").Replace(",", ".") + "'";
                }
                else
                {
                    qtde = "null";
                }

                string peso = "";
                if (tb_un_mat.Text != "")
                {
                    try
                    {
                        unidade = "'" + Convert.ToString(tb_un_mat.Text) + "'";
                    }
                    catch { }
                }
                else
                {
                    unidade = "null";
                }

                string total = "";
                if (tb_total_mat.Text != "")
                {

                    try
                    {
                        valor_unidade = Convert.ToDouble(tb_total_mat.Text);
                        valor_total = valor_unidade * qtde_unidade;
                    }
                    catch { }
                    total = "'" + valor_total.ToString().Replace(".", "").Replace(",", ".") + "'";
                }
                else
                {
                    total = "null";
                }

                this.datMat_prima_orc.InsertCommand.CommandText =
                   "INSERT INTO MAT_PRIMA_ORCAMENTO (ITEM_MAT_PRIMA_ORC, DESCRICAO_MAT_PRIMA_ORC, QTDE_MAT_PRIMA_ORC, TOTAL_MAT_PRIMA_ORC, COD_ORC_MAT_PRIMA_ORC, VALOR_MAT_PRIMA_ORC) " +
                   "VALUES (" + item + "," + unidade + "," + qtde + "," + total + ",'" + tb_cod.Text + "', " + valor_unidade + ")";
                this.fbConnection1.Open();
                this.datMat_prima_orc.InsertCommand.Connection = fbConnection1;
                this.datMat_prima_orc.InsertCommand.ExecuteNonQuery();
                this.fbConnection1.Close();

                dsMat_prima_orc.Clear();
                this.datMat_prima_orc.SelectCommand.CommandText =
                "SELECT * FROM MAT_PRIMA_ORCAMENTO WHERE COD_ORC_MAT_PRIMA_ORC = '" + tb_cod.Text + "'";
                this.fbConnection1.Open();
                this.datMat_prima_orc.SelectCommand.Connection = fbConnection1;
                this.datMat_prima_orc.SelectCommand.ExecuteNonQuery();
                datMat_prima_orc.Fill(MAT_PRIMA_ORCAMENTO);
                this.fbConnection1.Close();
                tb_item_mat.Text = "";
                tb_qtde_mat.Text = "";
                tb_un_mat.Text = "";
                tb_total_mat.Text = "";

            }
            catch
            {
                fbConnection1.Close();
            }


        }

        private void radioButton36_CheckedChanged(object sender, EventArgs e)
        {
            tb_responsavel.Text = "Emerson de Oliveira";

        }

        private void radioButton37_CheckedChanged(object sender, EventArgs e)
        {
            tb_responsavel.Text = "Fabiano Baldi";
        }

        private void tb_item_mat_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            form_valor_materia_prima mat = new form_valor_materia_prima();
            try
            {
                mat.ShowDialog();
            }
            finally
            {
                for (int i = 0; i < mat.numero_de_itens; i++)
                {
                    tb_item_mat.Text = mat._descricao_escolhida[i];
                    tb_total_mat.Text = mat._valor_escolhido[i];
                    tb_un_mat.Text = mat._unidade_escolhida[i];
                    tb_qtde_mat.Focus();
                    inserir_item();
                    //inserir_rota(abre.operacao_escolhida[i, 0], "", "");
                }
            }
        }

        private void tb_peso_mat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                inserir_item();
            }
        }

        private void tb_qtde_mat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                inserir_item();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //enviar_email("financeiro@baldi.ind.br");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (tb_cod.Text != "")
            {
                string _cod_orcamento = tb_cod.Text;
                inserir_tabela_orcamento(_cod_orcamento);
                inserir_tabela_itens_orcamento(_cod_orcamento);
                inserir_tabela_mate_prima_orcamento(_cod_orcamento);
                inserir_tabela_camara_quente_orcamento(_cod_orcamento);
                inserir_tabela_gavetas_orcamento(_cod_orcamento);
                inserir_tabela_impostos_orcamento(_cod_orcamento);
                inserir_tabela_outras_despesas_orcamento(_cod_orcamento);
                selecionar_orcamento(buscar_ultimo_orcamento());
            }
            else
            {
                MessageBox.Show("É necessário abrir um orçamento para copiá-lo.");
            }
        }

        private void inserir_tabela_camara_quente_orcamento(string cod_orcamento)
        {
            try
            {
                //SELECIONAR ITENS_ORCAMENTO
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT " +
                "	DIMENSAO_CAMERA_QUENTE_ORC	, " +
                "	VALOR_CAMERA_QUENTE_ORC	, " +
                "	ADICIONAL_CAMERA_QUENTE_ORC	, " +
                "	COD_ORC_CAMERA_QUENTE_ORC	, " +
                "	QTDE_CAMERA_QUENTE_ORC" +
                    " FROM CAMERA_QUENTE_ORC WHERE COD_ORC_CAMERA_QUENTE_ORC = '" + cod_orcamento + "'";
                FbDataAdapter itens_orcamentoDataAdapter = new FbDataAdapter();
                itens_orcamentoDataAdapter.SelectCommand = select;
                DataSet itens_orcamentoDataSet = new DataSet();
                itens_orcamentoDataAdapter.Fill(itens_orcamentoDataSet);
                fbConnection1.Close();
                foreach (DataRow dr in itens_orcamentoDataSet.Tables[0].Rows)
                {
                    //INSERINDO ITENS
                    object[] _dr = new object[23];
                    for (int i = 0; i < 5; i++)
                    {
                        if (dr[i].ToString() == "")
                            _dr[i] = DBNull.Value;
                        else
                            _dr[i] = dr[i].ToString();
                    }
                    //INSERINDO ITENS
                    fbConnection1.Open();
                    FbTransaction trans = fbConnection1.BeginTransaction();
                    fbConnection1.Close();
                    FbCommand insert = new FbCommand(
        "INSERT INTO CAMERA_QUENTE_ORC (" +
                "	DIMENSAO_CAMERA_QUENTE_ORC	, " +
                "	VALOR_CAMERA_QUENTE_ORC	, " +
                "	ADICIONAL_CAMERA_QUENTE_ORC	, " +
                "	COD_ORC_CAMERA_QUENTE_ORC	, " +
                "	QTDE_CAMERA_QUENTE_ORC) " +
        "VALUES (?,?,?,?,?)", fbConnection1, trans);
                    insert.Parameters.AddWithValue("DIMENSAO_CAMERA_QUENTE_ORC", _dr[0]);
                    insert.Parameters.AddWithValue("VALOR_CAMERA_QUENTE_ORC", _dr[1]);
                    insert.Parameters.AddWithValue("ADICIONAL_CAMERA_QUENTE_ORC", _dr[2]);
                    insert.Parameters.AddWithValue("COD_ORC_CAMERA_QUENTE_ORC", buscar_ultimo_orcamento());
                    insert.Parameters.AddWithValue("QTDE_CAMERA_QUENTE_ORC", _dr[4]);
                    fbConnection1.Open();
                    datMat_prima_orc.InsertCommand = insert;
                    datMat_prima_orc.InsertCommand.ExecuteNonQuery();
                    fbConnection1.Close();
                }
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void inserir_tabela_gavetas_orcamento(string cod_orcamento)
        {
            try
            {
                //SELECIONAR ITENS_ORCAMENTO
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT " +
                "	DIMENSAO_GAVETAS_ORC	, " +
                "	QTDE_GAVETAS_ORC	, " +
                "	VALOR_GAVETAS_ORC	, " +
                "	ADICIONAL_GAVETAS_ORC	, " +
                "	COD_ORC_GAVETAS_ORC" +
                    " FROM GAVETAS_ORC WHERE COD_ORC_GAVETAS_ORC = '" + cod_orcamento + "'";
                FbDataAdapter itens_orcamentoDataAdapter = new FbDataAdapter();
                itens_orcamentoDataAdapter.SelectCommand = select;
                DataSet itens_orcamentoDataSet = new DataSet();
                itens_orcamentoDataAdapter.Fill(itens_orcamentoDataSet);
                fbConnection1.Close();
                foreach (DataRow dr in itens_orcamentoDataSet.Tables[0].Rows)
                {
                    //INSERINDO ITENS
                    object[] _dr = new object[23];
                    for (int i = 0; i < 5; i++)
                    {
                        if (dr[i].ToString() == "")
                            _dr[i] = DBNull.Value;
                        else
                            _dr[i] = dr[i].ToString();
                    }
                    //INSERINDO ITENS
                    fbConnection1.Open();
                    FbTransaction trans = fbConnection1.BeginTransaction();
                    fbConnection1.Close();
                    FbCommand insert = new FbCommand(
        "INSERT INTO GAVETAS_ORC (" +
                 "	DIMENSAO_GAVETAS_ORC	, " +
                "	QTDE_GAVETAS_ORC	, " +
                "	VALOR_GAVETAS_ORC	, " +
                "	ADICIONAL_GAVETAS_ORC	, " +
                "	COD_ORC_GAVETAS_ORC) " +
        "VALUES (?,?,?,?,?)", fbConnection1, trans);
                    insert.Parameters.AddWithValue("DIMENSAO_GAVETAS_ORC", _dr[0]);
                    insert.Parameters.AddWithValue("QTDE_GAVETAS_ORC", _dr[1]);
                    insert.Parameters.AddWithValue("VALOR_GAVETAS_ORC", _dr[2]);
                    insert.Parameters.AddWithValue("ADICIONAL_GAVETAS_ORC", _dr[3]);
                    insert.Parameters.AddWithValue("COD_ORC_GAVETAS_ORC", buscar_ultimo_orcamento());
                    fbConnection1.Open();
                    datMat_prima_orc.InsertCommand = insert;
                    datMat_prima_orc.InsertCommand.ExecuteNonQuery();
                    fbConnection1.Close();
                }
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void inserir_tabela_impostos_orcamento(string cod_orcamento)
        {
            try
            {
                //SELECIONAR ITENS_ORCAMENTO
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT " +
                "	DESCRICAO_IMPOSTOS_ORC	, " +
                "	PERCENTUAL_IMPOSTOS_ORC	, " +
                "	COD_ORC_IMPOSTOS_ORC" +
                "   FROM IMPOSTOS_ORC WHERE COD_ORC_IMPOSTOS_ORC = '" + cod_orcamento + "'";
                FbDataAdapter itens_orcamentoDataAdapter = new FbDataAdapter();
                itens_orcamentoDataAdapter.SelectCommand = select;
                DataSet itens_orcamentoDataSet = new DataSet();
                itens_orcamentoDataAdapter.Fill(itens_orcamentoDataSet);
                fbConnection1.Close();
                foreach (DataRow dr in itens_orcamentoDataSet.Tables[0].Rows)
                {
                    //INSERINDO ITENS
                    object[] _dr = new object[23];
                    for (int i = 0; i < 3; i++)
                    {
                        if (dr[i].ToString() == "")
                            _dr[i] = DBNull.Value;
                        else
                            _dr[i] = dr[i].ToString();
                    }


                    //INSERINDO ITENS
                    fbConnection1.Open();
                    FbTransaction trans = fbConnection1.BeginTransaction();
                    fbConnection1.Close();
                    FbCommand insert = new FbCommand(
        "INSERT INTO IMPOSTOS_ORC (" +
                 "	DESCRICAO_IMPOSTOS_ORC	, " +
                "	PERCENTUAL_IMPOSTOS_ORC	, " +
                "	COD_ORC_IMPOSTOS_ORC) " +
        "VALUES (?,?,?)", fbConnection1, trans);
                    insert.Parameters.AddWithValue("DESCRICAO_IMPOSTOS_ORC", _dr[0]);
                    insert.Parameters.AddWithValue("PERCENTUAL_IMPOSTOS_ORC", _dr[1].ToString().Replace(",", "."));
                    insert.Parameters.AddWithValue("COD_ORC_IMPOSTOS_ORC", buscar_ultimo_orcamento());
                    fbConnection1.Open();
                    datMat_prima_orc.InsertCommand = insert;
                    datMat_prima_orc.InsertCommand.ExecuteNonQuery();
                    fbConnection1.Close();
                }
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void inserir_tabela_outras_despesas_orcamento(string cod_orcamento)
        {
            try
            {
                //SELECIONAR ITENS_ORCAMENTO
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT " +
                "	DESCRICAO_OUTROS	, " +
                "	VALOR_OUTROS	, " +
                "	COD_ORC_OUTROS	, " +
                "	VALOR_TOTAL_OUTROS	, " +
                "	QTD_VALOR_OUTROS " +
                "   FROM OUTROS_SERVICOS_ORC WHERE COD_ORC_OUTROS = '" + cod_orcamento + "'";
                FbDataAdapter itens_orcamentoDataAdapter = new FbDataAdapter();
                itens_orcamentoDataAdapter.SelectCommand = select;
                DataSet itens_orcamentoDataSet = new DataSet();
                itens_orcamentoDataAdapter.Fill(itens_orcamentoDataSet);
                fbConnection1.Close();
                foreach (DataRow dr in itens_orcamentoDataSet.Tables[0].Rows)
                {
                    //INSERINDO ITENS
                    object[] _dr = new object[23];
                    for (int i = 0; i < 5; i++)
                    {
                        if (dr[i].ToString() == "")
                            _dr[i] = DBNull.Value;
                        else
                            _dr[i] = dr[i].ToString();
                    }
                    //INSERINDO ITENS
                    fbConnection1.Open();
                    FbTransaction trans = fbConnection1.BeginTransaction();
                    fbConnection1.Close();
                    FbCommand insert = new FbCommand(
        "INSERT INTO OUTROS_SERVICOS_ORC (" +
                "	DESCRICAO_OUTROS	, " +
                "	VALOR_OUTROS	, " +
                "	COD_ORC_OUTROS	, " +
                "	VALOR_TOTAL_OUTROS	, " +
                "	QTD_VALOR_OUTROS )" +
        "VALUES (?,?,?,?,?)", fbConnection1, trans);
                    insert.Parameters.AddWithValue("DESCRICAO_OUTROS", _dr[0]);
                    insert.Parameters.AddWithValue("VALOR_OUTROS", _dr[1]);
                    insert.Parameters.AddWithValue("COD_ORC_OUTROS", buscar_ultimo_orcamento());
                    insert.Parameters.AddWithValue("VALOR_TOTAL_OUTROS", _dr[3]);
                    insert.Parameters.AddWithValue("QTD_VALOR_OUTROS", _dr[4]);
                    fbConnection1.Open();
                    datMat_prima_orc.InsertCommand = insert;
                    datMat_prima_orc.InsertCommand.ExecuteNonQuery();
                    fbConnection1.Close();
                }
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }
        private string buscar_ultimo_orcamento()
        {
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT COD_ORCAMENTO FROM ORCAMENTOS ORDER BY COD_ORCAMENTO DESC";
                FbDataAdapter orcamentosDataAdapter = new FbDataAdapter();
                orcamentosDataAdapter.SelectCommand = select;
                DataSet orcamentosDataSet = new DataSet();
                orcamentosDataAdapter.Fill(orcamentosDataSet);
                fbConnection1.Close();
                foreach (DataRow dr in orcamentosDataSet.Tables[0].Rows)
                {
                    return dr[0].ToString();
                }
                return "erro";
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
                return "erro";
            }
        }

        private void inserir_tabela_mate_prima_orcamento(string _cod_orcamento)
        {
            try
            {
                //SELECIONAR ITENS_ORCAMENTO
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT " +
                "	ITEM_MAT_PRIMA_ORC	, " +
                "	DESCRICAO_MAT_PRIMA_ORC	, " +
                "	PESO_MAT_PRIMA_ORC	, " +
                "	QTDE_MAT_PRIMA_ORC	, " +
                "	TOTAL_MAT_PRIMA_ORC	, " +
                "	OBS_MAT_PRIMA_ORC, " +
                "   VALOR_MAT_PRIMA_ORC" +
                "   FROM MAT_PRIMA_ORCAMENTO WHERE COD_ORC_MAT_PRIMA_ORC = '" + _cod_orcamento + "'";
                FbDataAdapter itens_orcamentoDataAdapter = new FbDataAdapter();
                itens_orcamentoDataAdapter.SelectCommand = select;
                DataSet itens_orcamentoDataSet = new DataSet();
                itens_orcamentoDataAdapter.Fill(itens_orcamentoDataSet);
                fbConnection1.Close();
                foreach (DataRow dr in itens_orcamentoDataSet.Tables[0].Rows)
                {
                    //INSERINDO ITENS
                    object[] _dr = new object[23];
                    for (int i = 0; i < 7; i++)
                    {
                        if (dr[i].ToString() == "")
                            _dr[i] = DBNull.Value;
                        else
                            _dr[i] = dr[i].ToString();
                    }

                    double peso = 0;
                    double.TryParse(_dr[2].ToString(), out peso);

                    //INSERINDO ITENS
                    fbConnection1.Open();
                    FbTransaction trans = fbConnection1.BeginTransaction();
                    fbConnection1.Close();
                    FbCommand insert = new FbCommand(
       "INSERT INTO MAT_PRIMA_ORCAMENTO (COD_ORC_MAT_PRIMA_ORC, " +
   "	ITEM_MAT_PRIMA_ORC	, " +
   "	DESCRICAO_MAT_PRIMA_ORC	, " +
   "	PESO_MAT_PRIMA_ORC	, " +
   "	QTDE_MAT_PRIMA_ORC	, " +
   "	TOTAL_MAT_PRIMA_ORC	, " +
   "	OBS_MAT_PRIMA_ORC, " +
   "   VALOR_MAT_PRIMA_ORC) " +
                   //"VALUES (" + buscar_ultimo_orcamento() + ",'" + _dr[0] + "','" + _dr[1] + "'," +
                   //"" + peso + "," + _dr[3].ToString().Replace(".", "").Replace(",", ".") + "," +
                   //"" + _dr[4] + ",'" + _dr[5] + "'," + _dr[6] + "," + _dr[7] +")", fbConnection1, trans);
                   "VALUES (?,?,?,?,?,?,?,?)", fbConnection1, trans);
                    insert.Parameters.AddWithValue("COD_ORC_MAT_PRIMA_ORC", buscar_ultimo_orcamento());
                    insert.Parameters.AddWithValue("ITEM_MAT_PRIMA_ORC", _dr[0]);
                    insert.Parameters.AddWithValue("DESCRICAO_MAT_PRIMA_ORC", _dr[1]);
                    insert.Parameters.AddWithValue("PESO_MAT_PRIMA_ORC", peso);
                    insert.Parameters.AddWithValue("QTDE_MAT_PRIMA_ORC", _dr[3].ToString().Replace(".", "").Replace(",", "."));
                    insert.Parameters.AddWithValue("TOTAL_MAT_PRIMA_ORC", _dr[4]);
                    insert.Parameters.AddWithValue("OBS_MAT_PRIMA_ORC", _dr[5]);
                    insert.Parameters.AddWithValue("VALOR_MAT_PRIMA_ORC", _dr[6].ToString().Replace(".", "").Replace(",", "."));
                    fbConnection1.Open();
                    datMat_prima_orc.InsertCommand = insert;
                    datMat_prima_orc.InsertCommand.ExecuteNonQuery();
                    fbConnection1.Close();
                }
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void inserir_tabela_itens_orcamento(string _cod_orcamento)
        {
            try
            {
                //SELECIONAR ITENS_ORCAMENTO
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT " +
                    "	NOME_ITEM_ORC	, " +
                    "	QTDE_ITEM_ORC	, " +
                    "	HORAS_OPER1_ITEM_ORC	, " +
                    "	HORAS_OPER2_ITEM_ORC	, " +
                    "	HORAS_OPER3_ITEM_ORC	, " +
                    "	HORAS_OPER4_ITEM_ORC	, " +
                    "	HORAS_OPER5_ITEM_ORC	, " +
                    "	HORAS_OPER6_ITEM_ORC	, " +
                    "	HORAS_OPER7_ITEM_ORC	, " +
                    "	HORAS_OPER8_ITEM_ORC	, " +
                    "	HORAS_OPER9_ITEM_ORC	, " +
                    "	HORAS_OPER10_ITEM_ORC	, " +
                    "	HORAS_OPER11_ITEM_ORC	, " +
                    "	HORAS_OPER12_ITEM_ORC	, " +
                    "	HORAS_OPER13_ITEM_ORC	, " +
                    "	HORAS_OPER14_ITEM_ORC	, " +
                    "	HORAS_OPER15_ITEM_ORC	, " +
                    "	HORAS_OPER16_ITEM_ORC	, " +
                    "	HORAS_OPER17_ITEM_ORC	, " +
                    "	HORAS_OPER18_ITEM_ORC	, " +
                    "	HORAS_OPER19_ITEM_ORC	, " +
                    "	HORAS_OPER20_ITEM_ORC	, " +
                    "	HORAS_OPER21_ITEM_ORC	, " +
                    "	HORAS_OPER22_ITEM_ORC	, " +
                    "	VALOR_TOTAL_ITEM_ORC	, " +
                    "	STATUS_ITEM_ORC	, " +
                    "	OBS_ITEM_ORC	, " +
                    "	TOTAL_HORAS_ITEM_ORC	, " +
                    "	VALOR_UNIT_ITEM_ORC	, " +
                    "	VALOR_MATERIAL_ITEM_ORC	, " +
                    "	PRAZO_ENTREGA_ITEM_ORC, NCM_ITEM_ORC " +
                    " FROM ITENS_ORCAMENTO WHERE COD_ORCAMENTO_ITEM_ORC = '" + _cod_orcamento + "'";
                FbDataAdapter itens_orcamentoDataAdapter = new FbDataAdapter();
                itens_orcamentoDataAdapter.SelectCommand = select;
                DataSet itens_orcamentoDataSet = new DataSet();
                itens_orcamentoDataAdapter.Fill(itens_orcamentoDataSet);
                fbConnection1.Close();
                foreach (DataRow dr in itens_orcamentoDataSet.Tables[0].Rows)
                {
                    object[] _dr = new object[32];
                    for (int i = 0; i < 32; i++)
                    {
                        if (dr[i].ToString() == "")
                            _dr[i] = DBNull.Value;
                        else
                            _dr[i] = dr[i].ToString();
                        try
                        {
                            double numero = Convert.ToDouble(dr[i].ToString());
                            _dr[i] = numero.ToString().Replace(".", "").Replace(",", ".");

                        }
                        catch { }
                    }
                    //INSERINDO ITENS
                    fbConnection1.Open();
                    FbTransaction trans = fbConnection1.BeginTransaction();
                    fbConnection1.Close();
                    FbCommand insert = new FbCommand(
        "INSERT INTO ITENS_ORCAMENTO (" +
        "   COD_ORCAMENTO_ITEM_ORC, " +
        "   NOME_ITEM_ORC	, " +
        "	QTDE_ITEM_ORC	, " +
        "	HORAS_OPER1_ITEM_ORC	, " +
        "	HORAS_OPER2_ITEM_ORC	, " +
        "	HORAS_OPER3_ITEM_ORC	, " +
        "	HORAS_OPER4_ITEM_ORC	, " +
        "	HORAS_OPER5_ITEM_ORC	, " +
        "	HORAS_OPER6_ITEM_ORC	, " +
        "	HORAS_OPER7_ITEM_ORC	, " +
        "	HORAS_OPER8_ITEM_ORC	, " +
        "	HORAS_OPER9_ITEM_ORC	, " +
        "	HORAS_OPER10_ITEM_ORC	, " +
        "	HORAS_OPER11_ITEM_ORC	, " +
        "	HORAS_OPER12_ITEM_ORC	, " +
        "	HORAS_OPER13_ITEM_ORC	, " +
        "	HORAS_OPER14_ITEM_ORC	, " +
        "	HORAS_OPER15_ITEM_ORC	, " +
        "	HORAS_OPER16_ITEM_ORC	, " +
        "	HORAS_OPER17_ITEM_ORC	, " +
        "	HORAS_OPER18_ITEM_ORC	, " +
        "	HORAS_OPER19_ITEM_ORC	, " +
        "	HORAS_OPER20_ITEM_ORC	, " +
        "	HORAS_OPER21_ITEM_ORC	, " +
        "	HORAS_OPER22_ITEM_ORC	, " +
        "	VALOR_TOTAL_ITEM_ORC	, " +
        "	STATUS_ITEM_ORC	, " +
        "	OBS_ITEM_ORC	, " +
        "	TOTAL_HORAS_ITEM_ORC	, " +
        "	VALOR_UNIT_ITEM_ORC	, " +
        "	VALOR_MATERIAL_ITEM_ORC	, " +
        "	PRAZO_ENTREGA_ITEM_ORC, NCM_ITEM_ORC)" +
        "VALUES (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)", fbConnection1, trans);
                    insert.Parameters.AddWithValue("COD_ORCAMENTO_ITEM_ORC", buscar_ultimo_orcamento());
                    insert.Parameters.AddWithValue("NOME_ITEM_ORC", _dr[0]);
                    insert.Parameters.AddWithValue("QTDE_ITEM_ORC", _dr[1]);
                    insert.Parameters.AddWithValue("HORAS_OPER1_ITEM_ORC", _dr[2]);
                    insert.Parameters.AddWithValue("HORAS_OPER2_ITEM_ORC", _dr[3]);
                    insert.Parameters.AddWithValue("HORAS_OPER3_ITEM_ORC", _dr[4]);
                    insert.Parameters.AddWithValue("HORAS_OPER4_ITEM_ORC", _dr[5]);
                    insert.Parameters.AddWithValue("HORAS_OPER5_ITEM_ORC", _dr[6]);
                    insert.Parameters.AddWithValue("HORAS_OPER6_ITEM_ORC", _dr[7]);
                    insert.Parameters.AddWithValue("HORAS_OPER7_ITEM_ORC", _dr[8]);
                    insert.Parameters.AddWithValue("HORAS_OPER8_ITEM_ORC", _dr[9]);
                    insert.Parameters.AddWithValue("HORAS_OPER9_ITEM_ORC", _dr[10]);
                    insert.Parameters.AddWithValue("HORAS_OPER10_ITEM_ORC", _dr[11]);
                    insert.Parameters.AddWithValue("HORAS_OPER11_ITEM_ORC", _dr[12]);
                    insert.Parameters.AddWithValue("HORAS_OPER12_ITEM_ORC", _dr[13]);
                    insert.Parameters.AddWithValue("HORAS_OPER13_ITEM_ORC", _dr[14]);
                    insert.Parameters.AddWithValue("HORAS_OPER14_ITEM_ORC", _dr[15]);
                    insert.Parameters.AddWithValue("HORAS_OPER15_ITEM_ORC", _dr[16]);
                    insert.Parameters.AddWithValue("HORAS_OPER16_ITEM_ORC", _dr[17]);
                    insert.Parameters.AddWithValue("HORAS_OPER17_ITEM_ORC", _dr[18]);
                    insert.Parameters.AddWithValue("HORAS_OPER18_ITEM_ORC", _dr[19]);
                    insert.Parameters.AddWithValue("HORAS_OPER19_ITEM_ORC", _dr[20]);
                    insert.Parameters.AddWithValue("HORAS_OPER20_ITEM_ORC", _dr[21]);
                    insert.Parameters.AddWithValue("HORAS_OPER21_ITEM_ORC", _dr[22]);
                    insert.Parameters.AddWithValue("HORAS_OPER22_ITEM_ORC", _dr[23]);
                    insert.Parameters.AddWithValue("VALOR_TOTAL_ITEM_ORC", _dr[24]);
                    insert.Parameters.AddWithValue("STATUS_ITEM_ORC", _dr[25]);
                    insert.Parameters.AddWithValue("OBS_ITEM_ORC", _dr[26]);
                    insert.Parameters.AddWithValue("TOTAL_HORAS_ITEM_ORC", _dr[27]);
                    insert.Parameters.AddWithValue("VALOR_UNIT_ITEM_ORC", _dr[28]);
                    insert.Parameters.AddWithValue("VALOR_MATERIAL_ITEM_ORC", _dr[29]);
                    insert.Parameters.AddWithValue("PRAZO_ENTREGA_ITEM_ORC", _dr[30]);
                    insert.Parameters.AddWithValue("NCM_ITEM_ORC", _dr[31]);

                    fbConnection1.Open();
                    datItens_orcamento.InsertCommand = insert;
                    datItens_orcamento.InsertCommand.ExecuteNonQuery();
                    fbConnection1.Close();

                }
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void inserir_tabela_orcamento(string _cod_orcamento)
        {
            try
            {
                dsOrcamentos.Clear();
                dsItens_orcamento.Clear();
                dsMat_prima_orc.Clear();
                this.datOrcamentos.InsertCommand.CommandText =
                    "INSERT INTO ORCAMENTOS (" +
"CLIENTE_ORCAMENTO				," +
"CONTATO_CLIENTE_ORCAMENTO		," +
"EMAIL_CONTATO_ORCAMENTO			," +
"DATA_ORCAMENTO					," +
"BENEFICIAMENTO_ORCAMENTO		," +
"VENDAS_ORCAMENTO				," +
"TOTAL_QTDE_PECAS_ORCAMENTO		," +
"HORAS_OPER1_ORCAMENTO			," +
"HORAS_OPER2_ORCAMENTO			," +
"HORAS_OPER3_ORCAMENTO			," +
"HORAS_OPER4_ORCAMENTO			," +
"HORAS_OPER5_ORCAMENTO			," +
"HORAS_OPER6_ORCAMENTO			," +
"HORAS_OPER7_ORCAMENTO			," +
"HORAS_OPER8_ORCAMENTO			," +
"HORAS_OPER9_ORCAMENTO			," +
"HORAS_OPER10_ORCAMENTO			," +
"HORAS_OPER11_ORCAMENTO			," +
"HORAS_OPER12_ORCAMENTO			," +
"HORAS_OPER13_ORCAMENTO			," +
"HORAS_OPER14_ORCAMENTO			," +
"VALOR_OPER1_ORCAMENTO			," +
"VALOR_OPER2_ORCAMENTO			," +
"VALOR_OPER3_ORCAMENTO			," +
"VALOR_OPER4_ORCAMENTO			," +
"VALOR_OPER5_ORCAMENTO			," +
"VALOR_OPER6_ORCAMENTO			," +
"VALOR_OPER7_ORCAMENTO			," +
"VALOR_OPER8_ORCAMENTO			," +
"VALOR_OPER9_ORCAMENTO			," +
"VALOR_OPER10_ORCAMENTO			," +
"VALOR_OPER11_ORCAMENTO			," +
"VALOR_OPER12_ORCAMENTO			," +
"VALOR_OPER13_ORCAMENTO			," +
"VALOR_OPER14_ORCAMENTO			," +
"VALOR_TOTAL_ORCAMENTO			," +
"PRAZO_ENTREGA_ORCAMENTO			," +
"VALIDADE_ORCAMENTO				," +
"IMPOSTOS_ORCAMENTO				," +
"STATUS_ORCAMENTO				," +
"OBS_ORCAMENTO					," +
"IMPRESSAO_COD_ORCAMENTO			," +
"MAT_PRI_COMP_DISP_ORC_SIM		," +
"MAT_PRI_COMP_DISP_ORC_NAO		," +
"MAO_OBRA_EQUIP_DISP_ORC_SIM		," +
"MAO_OBRA_EQUIP_DISP_ORC_NAO		," +
"EMBAL_TRANSP_DISP_ORC_SIM		," +
"EMBAL_TRANSP_DISP_ORC_NAO		," +
"ESPEC_MAT_PRI_COMP_ORCAMENTO	," +
"ESPEC_MAO_OBRA_EQUIP_ORCAMENTO	," +
"ESPEC_EMBAL_TRANSP_ORCAMENTO	," +
"TOTAL_HORAS_ORCAMENTO			," +
"DATA_APROVACAO_ORCAMENTO		," +
"VALOR_MAT_PRI_ORCAMENTO			," +
"MAT_PRI_FORN_POR_ORCAMENTO		," +
"VALIDADE_ORC_ORCAMENTO			," +
"COND_ENTREGA_ORCAMENTO			," +
"RESPONSAVEL_ORCAMENTO			," +
"TIPO_INJECAO_ORCAMENTO			," +
"FORN_TIPO_INJECAO_ORCAMENTO		," +
"QTDE_BICOS_INJECAO_ORCAMENTO	," +
"HORAS_CAD_ORCAMENTO				," +
"CUSTO_CAD_ORCAMENTO				," +
"VALOR_TOTAL_CAD_ORCAMENTO		," +
"HORAS_MODEL_ORCAMENTO			," +
"CUSTO_MODEL_ORCAMENTO			," +
"VALOR_TOTAL_MODEL_ORCAMENTO		," +
"N_P_ORCAMENTO					," +
"DESCRICAO_ORCAMENTO				," +
"PROJETO_ORCAMENTO				," +
"N_CAVIDADES_ORCAMENTO			," +
"TRANSPORTE_ORCAMENTO			," +
"TRY_OUT_ORCAMENTO				," +
"VH_OPER1_ORCAMENTO				," +
"VH_OPER2_ORCAMENTO				," +
"VH_OPER3_ORCAMENTO				," +
"VH_OPER4_ORCAMENTO				," +
"VH_OPER5_ORCAMENTO				," +
"VH_OPER6_ORCAMENTO				," +
"VH_OPER7_ORCAMENTO				," +
"VH_OPER8_ORCAMENTO				," +
"VH_OPER9_ORCAMENTO				," +
"VH_OPER10_ORCAMENTO				," +
"VH_OPER11_ORCAMENTO				," +
"VH_OPER12_ORCAMENTO				," +
"VH_OPER13_ORCAMENTO				," +
"VH_OPER14_ORCAMENTO				," +
"FERRAMENTA_ORCAMENTO			," +
"VALORES_IMPOSTOS_ORCAMENTO		," +
"TOTAL_GERAL_ORCAMENTO			," +
"PM_H13_ORCAMENTO				," +
"PM_1045_ORCAMENTO				," +
"PM_TEMPERADO_ORCAMENTO			," +
"PM_RAMAX_ORCAMENTO				," +
"PM_P20_ORCAMENTO				," +
"PM_S_TEMPERA_ORCAMENTO			," +
"MAT_H13_ORCAMENTO				," +
"MAT_E420_ORCAMENTO				," +
"MAT_VND_ORCAMENTO				," +
"MAT_VC131_ORCAMENTO				," +
"MAT_CPM4_ORCAMENTO				," +
"MAT_OUTROS_ORCAMENTO			," +
"MAT_TEMPERADO_ORCAMENTO			," +
"COM_GAVETAS_ORCAMENTO			," +
"SEM_GAVETAS_ORCAMENTO			," +
"EXT_PINOS_ORCAMENTO				," +
"EXT_LAMINAS_ORCAMENTO			," +
"EXT_CAMES_ORCAMENTO				," +
"EXT_COM_PLACA_ORCAMENTO			," +
"EXT_BUCHA_ORCAMENTO				," +
"INJ_DIRETA_ORCAMENTO			," +
"INJ_SUBMARINA_ORCAMENTO			," +
"INJ_BICO_QUENTE_ORCAMENTO		," +
"INJ_CAMARA_QUENTE_ORCAMENTO		," +
"ACAB_POLIDO_ORCAMENTO			," +
"ACAB_ESPELHADO_ORCAMENTO		," +
"ACAB_TEXTURA_ORCAMENTO			," +
"ACAB_QUIMICA_ORCAMENTO			," +
"ACAB_EROSAO_ORCAMENTO			," +
"DESC_OUTROS_MAT_ORCAMENTO		," +
"EXT_OUTROS_ORCAMENTO			," +
"DESC_EXT_OUTROS_ORCAMENTO		," +
"CONDICAO_PGTO_ORCAMENTO			," +
"VH_OPER15_ORCAMENTO				," +
"VH_OPER16_ORCAMENTO				," +
"VH_OPER17_ORCAMENTO				," +
"VH_OPER18_ORCAMENTO				," +
"VH_OPER19_ORCAMENTO				," +
"VH_OPER20_ORCAMENTO				," +
"VH_OPER21_ORCAMENTO				," +
"VH_OPER22_ORCAMENTO				," +
"HORAS_OPER15_ORCAMENTO			," +
"HORAS_OPER16_ORCAMENTO			," +
"HORAS_OPER17_ORCAMENTO			," +
"HORAS_OPER18_ORCAMENTO			," +
"HORAS_OPER19_ORCAMENTO			," +
"HORAS_OPER20_ORCAMENTO			," +
"HORAS_OPER21_ORCAMENTO			," +
"HORAS_OPER22_ORCAMENTO			," +
"VALOR_OPER15_ORCAMENTO			," +
"VALOR_OPER16_ORCAMENTO			," +
"VALOR_OPER17_ORCAMENTO			," +
"VALOR_OPER18_ORCAMENTO			," +
"VALOR_OPER19_ORCAMENTO			," +
"VALOR_OPER20_ORCAMENTO			," +
"VALOR_OPER21_ORCAMENTO			," +
"VALOR_OPER22_ORCAMENTO			," +
"NOME_OPER1_ORCAMENTO			," +
"NOME_OPER2_ORCAMENTO			," +
"NOME_OPER3_ORCAMENTO			," +
"NOME_OPER4_ORCAMENTO			," +
"NOME_OPER5_ORCAMENTO			," +
"NOME_OPER6_ORCAMENTO			," +
"NOME_OPER7_ORCAMENTO			," +
"NOME_OPER8_ORCAMENTO			," +
"NOME_OPER9_ORCAMENTO			," +
"NOME_OPER10_ORCAMENTO			," +
"NOME_OPER11_ORCAMENTO			," +
"NOME_OPER12_ORCAMENTO			," +
"NOME_OPER13_ORCAMENTO			," +
"NOME_OPER14_ORCAMENTO			," +
"NOME_OPER15_ORCAMENTO			," +
"NOME_OPER16_ORCAMENTO			," +
"NOME_OPER17_ORCAMENTO			," +
"NOME_OPER18_ORCAMENTO			," +
"NOME_OPER19_ORCAMENTO			," +
"NOME_OPER20_ORCAMENTO			," +
"NOME_OPER21_ORCAMENTO			," +
"NOME_OPER22_ORCAMENTO			," +
"VALOR_OUTROS_SERV				," +
"INJ_INJETORA_ORCAMENTO			," +
"INJ_CAPACIDADE_ORCAMENTO		," +
"INJ_DIMENSAO_ORCAMENTO			," +
"INJ_CLICO_ORCAMENTOS			," +
"INJ_OBS_ORCAMENTOS				," +
"INJ_PESO_PRODUTO_ORCAMENTO		," +
"INJ_PESO_CANAL_ORCAMENTO		," +
"INJ_MATERIAL_ORCAMENTO			," +
"INJ_PERIFERICOS_ORCAMENTOS		," +
"INJ_VALOR_PER_ORCAMENTOS		," +
"GAVETAS_MECANICAS_ORCAMENTO		," +
"GAVETAS_HIDRAULICAS_ORCAMENTO	," +
"SENSORES_ORCAMENTO				," +
"REVISAO_ORCAMENTO				," +
"PART_NUMBER_ORCAMENTO			," +
"MOLDES_SIMILARES_ORCAMENTOS		," +
"MAIOR_POTENCIAL_ORCAMENTO		," +
"INJ_PONTOS_ORCAMENTO			," +
"HORAS_FRESA_ORCAMENTO			," +
"HORAS_RET_PERFIL_ORCAMENTO		," +
"HORAS_RET_CILIN_ORCAMENTO		," +
"HORAS_EROSAO_PEN_ORCAMENTO		," +
"HORAS_TORNO_CONV_ORCAMENTO		," +
"HORAS_TORNO_CNC_ORCAMENTO		," +
"HORAS_EROSAO_FIO_ORCAMENTO		," +
"HORAS_CENTRO_USI_ORCAMENTO		," +
"HORAS_TRAT_TERM_ORCAMENTO		," +
"HORAS_ELETRODO_CONV_ORCAMENTO	," +
"HORAS_ELETRODO_HIGH_ORCAMENTO	," +
"HORAS_ELETRODO_FIO_ORCAMENTO	," +
"HORAS_HIGH_SPEED_ORCAMENTO		," +
"HORAS_BANCADA_ORCAMENTO			," +
"VALOR_FRESA_ORCAMENTO			," +
"VALOR_RET_PERFIL_ORCAMENTO		," +
"VALOR_RET_CILIN_ORCAMENTO		," +
"VALOR_EROSAO_PEN_ORCAMENTO		," +
"VALOR_TORNO_CONV_ORCAMENTO		," +
"VALOR_TORNO_CNC_ORCAMENTO		," +
"VALOR_EROSAO_FIO_ORCAMENTO		," +
"VALOR_CENTRO_USI_ORCAMENTO		," +
"VALOR_TRAT_TERM_ORCAMENTO		," +
"VALOR_ELETRODO_CONV_ORCAMENTO	," +
"VALOR_ELETRODO_HIGH_ORCAMENTO	," +
"VALOR_ELETRODO_FIO_ORCAMENTO	," +
"VALOR_HIGH_SPEED_ORCAMENTO		," +
"VALOR_BANCADA_ORCAMENTO			," +
"VH_FRESA_ORCAMENTO				," +
"VH_RET_PERFIL_ORCAMENTO			," +
"VH_RET_CILIN_ORCAMENTO			," +
"VH_EROSAO_PEN_ORCAMENTO			," +
"VH_TORNO_CONV_ORCAMENTO			," +
"VH_TORNO_CNC_ORCAMENTO			," +
"VH_EROSAO_FIO_ORCAMENTO			," +
"VH_CENTRO_USI_ORCAMENTO			," +
"VH_TRAT_TERM_ORCAMENTO			," +
"VH_ELETRODO_CONV_ORCAMENTO		," +
"VH_ELETRODO_HIGH_ORCAMENTO		," +
"VH_ELETRODO_FIO_ORCAMENTO		," +
"VH_HIGH_SPEED_ORCAMENTO			," +
"VH_BANCADA_ORCAMENTO			," +
"LARGURA_PORTA_MOLDE_ORC			," +
"COMPRIMENTO_PORTA_MOLDE_ORC		," +
"ALTURA_PORTA_MOLDE_ORC			," +
"PESO_PORTA_MOLDE_ORC			," +
"QUANTIDADE_BICO_QUENTE_ORC		," +
"VALOR_BICO_QUENTE_ORC			," +
"ADICIONAL_BICO_QUENTE_ORC		," +
"QTDE_CAVIDADES_ORC				," +
"CAMARA_QUENTE_ORC				," +
"BICO_QUENTE_ORC					," +
"DIMENSAO_CAVIDADE_ORC			," +
"TOTAL_BICO_QUENTE_ORC			," +
"TOTAL_CAMERA_QUENTE_ORC			," +
"TOTAL_GAVETAS_ORC				," +
"HORAS_ADIC_OPER1_ORCAMENTO		," +
"HORAS_ADIC_OPER2_ORCAMENTO		," +
"HORAS_ADIC_OPER3_ORCAMENTO		," +
"HORAS_ADIC_OPER4_ORCAMENTO		," +
"HORAS_ADIC_OPER5_ORCAMENTO		," +
"HORAS_ADIC_OPER6_ORCAMENTO		," +
"HORAS_ADIC_OPER7_ORCAMENTO		," +
"HORAS_ADIC_OPER8_ORCAMENTO		," +
"HORAS_ADIC_OPER9_ORCAMENTO		," +
"HORAS_ADIC_OPER10_ORCAMENTO		," +
"HORAS_ADIC_OPER11_ORCAMENTO		," +
"HORAS_ADIC_OPER12_ORCAMENTO		," +
"HORAS_ADIC_OPER13_ORCAMENTO		," +
"HORAS_ADIC_OPER14_ORCAMENTO		," +
"HORAS_ADIC_OPER15_ORCAMENTO		," +
"HORAS_ADIC_OPER16_ORCAMENTO		," +
"HORAS_ADIC_OPER17_ORCAMENTO		," +
"HORAS_ADIC_OPER18_ORCAMENTO		," +
"HORAS_ADIC_OPER19_ORCAMENTO		," +
"HORAS_ADIC_OPER20_ORCAMENTO		," +
"HORAS_ADIC_OPER21_ORCAMENTO		," +
"HORAS_ADIC_OPER22_ORCAMENTO		," +
"HORAS_PADRAO_OPER1_ORCAMENTO	," +
"HORAS_PADRAO_OPER2_ORCAMENTO	," +
"HORAS_PADRAO_OPER3_ORCAMENTO	," +
"HORAS_PADRAO_OPER4_ORCAMENTO	," +
"HORAS_PADRAO_OPER5_ORCAMENTO	," +
"HORAS_PADRAO_OPER6_ORCAMENTO	," +
"HORAS_PADRAO_OPER7_ORCAMENTO	," +
"HORAS_PADRAO_OPER8_ORCAMENTO	," +
"HORAS_PADRAO_OPER9_ORCAMENTO	," +
"HORAS_PADRAO_OPER10_ORCAMENTO	," +
"HORAS_PADRAO_OPER11_ORCAMENTO	," +
"HORAS_PADRAO_OPER12_ORCAMENTO	," +
"HORAS_PADRAO_OPER13_ORCAMENTO	," +
"HORAS_PADRAO_OPER14_ORCAMENTO	," +
"HORAS_PADRAO_OPER15_ORCAMENTO	," +
"HORAS_PADRAO_OPER16_ORCAMENTO	," +
"HORAS_PADRAO_OPER17_ORCAMENTO	," +
"HORAS_PADRAO_OPER18_ORCAMENTO	," +
"HORAS_PADRAO_OPER19_ORCAMENTO	," +
"HORAS_PADRAO_OPER20_ORCAMENTO	," +
"HORAS_PADRAO_OPER21_ORCAMENTO	," +
"HORAS_PADRAO_OPER22_ORCAMENTO	," +
"TOTAL_SERV_MOLDE_ORCAMENTO		," +
"VALOR_MATERIAL_PECA_ORCAMENTO	," +
"MOLDE_SIMILAR_ORCAMENTO			," +
"N_ORCAMENTO						," +
"INJ_OUTROS_ORCAMENTOS			," +
"INJ_CONVECIONAL_ORCAMENTO, DATA_CRIACAO_ORCAMENTO " +
                ")  SELECT " +
                "CLIENTE_ORCAMENTO				," +
                "CONTATO_CLIENTE_ORCAMENTO		," +
                "EMAIL_CONTATO_ORCAMENTO			," +
                "DATA_ORCAMENTO					," +
                "BENEFICIAMENTO_ORCAMENTO		," +
                "VENDAS_ORCAMENTO				," +
                "TOTAL_QTDE_PECAS_ORCAMENTO		," +
                "HORAS_OPER1_ORCAMENTO			," +
                "HORAS_OPER2_ORCAMENTO			," +
                "HORAS_OPER3_ORCAMENTO			," +
                "HORAS_OPER4_ORCAMENTO			," +
                "HORAS_OPER5_ORCAMENTO			," +
                "HORAS_OPER6_ORCAMENTO			," +
                "HORAS_OPER7_ORCAMENTO			," +
                "HORAS_OPER8_ORCAMENTO			," +
                "HORAS_OPER9_ORCAMENTO			," +
                "HORAS_OPER10_ORCAMENTO			," +
                "HORAS_OPER11_ORCAMENTO			," +
                "HORAS_OPER12_ORCAMENTO			," +
                "HORAS_OPER13_ORCAMENTO			," +
                "HORAS_OPER14_ORCAMENTO			," +
                "VALOR_OPER1_ORCAMENTO			," +
                "VALOR_OPER2_ORCAMENTO			," +
                "VALOR_OPER3_ORCAMENTO			," +
                "VALOR_OPER4_ORCAMENTO			," +
                "VALOR_OPER5_ORCAMENTO			," +
                "VALOR_OPER6_ORCAMENTO			," +
                "VALOR_OPER7_ORCAMENTO			," +
                "VALOR_OPER8_ORCAMENTO			," +
                "VALOR_OPER9_ORCAMENTO			," +
                "VALOR_OPER10_ORCAMENTO			," +
                "VALOR_OPER11_ORCAMENTO			," +
                "VALOR_OPER12_ORCAMENTO			," +
                "VALOR_OPER13_ORCAMENTO			," +
                "VALOR_OPER14_ORCAMENTO			," +
                "VALOR_TOTAL_ORCAMENTO			," +
                "PRAZO_ENTREGA_ORCAMENTO			," +
                "VALIDADE_ORCAMENTO				," +
                "IMPOSTOS_ORCAMENTO				," +
                "STATUS_ORCAMENTO				," +
                "OBS_ORCAMENTO					," +
                "IMPRESSAO_COD_ORCAMENTO			," +
                "MAT_PRI_COMP_DISP_ORC_SIM		," +
                "MAT_PRI_COMP_DISP_ORC_NAO		," +
                "MAO_OBRA_EQUIP_DISP_ORC_SIM		," +
                "MAO_OBRA_EQUIP_DISP_ORC_NAO		," +
                "EMBAL_TRANSP_DISP_ORC_SIM		," +
                "EMBAL_TRANSP_DISP_ORC_NAO		," +
                "ESPEC_MAT_PRI_COMP_ORCAMENTO	," +
                "ESPEC_MAO_OBRA_EQUIP_ORCAMENTO	," +
                "ESPEC_EMBAL_TRANSP_ORCAMENTO	," +
                "TOTAL_HORAS_ORCAMENTO			," +
                "DATA_APROVACAO_ORCAMENTO		," +
                "VALOR_MAT_PRI_ORCAMENTO			," +
                "MAT_PRI_FORN_POR_ORCAMENTO		," +
                "VALIDADE_ORC_ORCAMENTO			," +
                "COND_ENTREGA_ORCAMENTO			," +
                "RESPONSAVEL_ORCAMENTO			," +
                "TIPO_INJECAO_ORCAMENTO			," +
                "FORN_TIPO_INJECAO_ORCAMENTO		," +
                "QTDE_BICOS_INJECAO_ORCAMENTO	," +
                "HORAS_CAD_ORCAMENTO				," +
                "CUSTO_CAD_ORCAMENTO				," +
                "VALOR_TOTAL_CAD_ORCAMENTO		," +
                "HORAS_MODEL_ORCAMENTO			," +
                "CUSTO_MODEL_ORCAMENTO			," +
                "VALOR_TOTAL_MODEL_ORCAMENTO		," +
                "N_P_ORCAMENTO					," +
                "DESCRICAO_ORCAMENTO				," +
                "PROJETO_ORCAMENTO				," +
                "N_CAVIDADES_ORCAMENTO			," +
                "TRANSPORTE_ORCAMENTO			," +
                "TRY_OUT_ORCAMENTO				," +
                "VH_OPER1_ORCAMENTO				," +
                "VH_OPER2_ORCAMENTO				," +
                "VH_OPER3_ORCAMENTO				," +
                "VH_OPER4_ORCAMENTO				," +
                "VH_OPER5_ORCAMENTO				," +
                "VH_OPER6_ORCAMENTO				," +
                "VH_OPER7_ORCAMENTO				," +
                "VH_OPER8_ORCAMENTO				," +
                "VH_OPER9_ORCAMENTO				," +
                "VH_OPER10_ORCAMENTO				," +
                "VH_OPER11_ORCAMENTO				," +
                "VH_OPER12_ORCAMENTO				," +
                "VH_OPER13_ORCAMENTO				," +
                "VH_OPER14_ORCAMENTO				," +
                "FERRAMENTA_ORCAMENTO			," +
                "VALORES_IMPOSTOS_ORCAMENTO		," +
                "TOTAL_GERAL_ORCAMENTO			," +
                "PM_H13_ORCAMENTO				," +
                "PM_1045_ORCAMENTO				," +
                "PM_TEMPERADO_ORCAMENTO			," +
                "PM_RAMAX_ORCAMENTO				," +
                "PM_P20_ORCAMENTO				," +
                "PM_S_TEMPERA_ORCAMENTO			," +
                "MAT_H13_ORCAMENTO				," +
                "MAT_E420_ORCAMENTO				," +
                "MAT_VND_ORCAMENTO				," +
                "MAT_VC131_ORCAMENTO				," +
                "MAT_CPM4_ORCAMENTO				," +
                "MAT_OUTROS_ORCAMENTO			," +
                "MAT_TEMPERADO_ORCAMENTO			," +
                "COM_GAVETAS_ORCAMENTO			," +
                "SEM_GAVETAS_ORCAMENTO			," +
                "EXT_PINOS_ORCAMENTO				," +
                "EXT_LAMINAS_ORCAMENTO			," +
                "EXT_CAMES_ORCAMENTO				," +
                "EXT_COM_PLACA_ORCAMENTO			," +
                "EXT_BUCHA_ORCAMENTO				," +
                "INJ_DIRETA_ORCAMENTO			," +
                "INJ_SUBMARINA_ORCAMENTO			," +
                "INJ_BICO_QUENTE_ORCAMENTO		," +
                "INJ_CAMARA_QUENTE_ORCAMENTO		," +
                "ACAB_POLIDO_ORCAMENTO			," +
                "ACAB_ESPELHADO_ORCAMENTO		," +
                "ACAB_TEXTURA_ORCAMENTO			," +
                "ACAB_QUIMICA_ORCAMENTO			," +
                "ACAB_EROSAO_ORCAMENTO			," +
                "DESC_OUTROS_MAT_ORCAMENTO		," +
                "EXT_OUTROS_ORCAMENTO			," +
                "DESC_EXT_OUTROS_ORCAMENTO		," +
                "CONDICAO_PGTO_ORCAMENTO			," +
                "VH_OPER15_ORCAMENTO				," +
                "VH_OPER16_ORCAMENTO				," +
                "VH_OPER17_ORCAMENTO				," +
                "VH_OPER18_ORCAMENTO				," +
                "VH_OPER19_ORCAMENTO				," +
                "VH_OPER20_ORCAMENTO				," +
                "VH_OPER21_ORCAMENTO				," +
                "VH_OPER22_ORCAMENTO				," +
                "HORAS_OPER15_ORCAMENTO			," +
                "HORAS_OPER16_ORCAMENTO			," +
                "HORAS_OPER17_ORCAMENTO			," +
                "HORAS_OPER18_ORCAMENTO			," +
                "HORAS_OPER19_ORCAMENTO			," +
                "HORAS_OPER20_ORCAMENTO			," +
                "HORAS_OPER21_ORCAMENTO			," +
                "HORAS_OPER22_ORCAMENTO			," +
                "VALOR_OPER15_ORCAMENTO			," +
                "VALOR_OPER16_ORCAMENTO			," +
                "VALOR_OPER17_ORCAMENTO			," +
                "VALOR_OPER18_ORCAMENTO			," +
                "VALOR_OPER19_ORCAMENTO			," +
                "VALOR_OPER20_ORCAMENTO			," +
                "VALOR_OPER21_ORCAMENTO			," +
                "VALOR_OPER22_ORCAMENTO			," +
                "NOME_OPER1_ORCAMENTO			," +
                "NOME_OPER2_ORCAMENTO			," +
                "NOME_OPER3_ORCAMENTO			," +
                "NOME_OPER4_ORCAMENTO			," +
                "NOME_OPER5_ORCAMENTO			," +
                "NOME_OPER6_ORCAMENTO			," +
                "NOME_OPER7_ORCAMENTO			," +
                "NOME_OPER8_ORCAMENTO			," +
                "NOME_OPER9_ORCAMENTO			," +
                "NOME_OPER10_ORCAMENTO			," +
                "NOME_OPER11_ORCAMENTO			," +
                "NOME_OPER12_ORCAMENTO			," +
                "NOME_OPER13_ORCAMENTO			," +
                "NOME_OPER14_ORCAMENTO			," +
                "NOME_OPER15_ORCAMENTO			," +
                "NOME_OPER16_ORCAMENTO			," +
                "NOME_OPER17_ORCAMENTO			," +
                "NOME_OPER18_ORCAMENTO			," +
                "NOME_OPER19_ORCAMENTO			," +
                "NOME_OPER20_ORCAMENTO			," +
                "NOME_OPER21_ORCAMENTO			," +
                "NOME_OPER22_ORCAMENTO			," +
                "VALOR_OUTROS_SERV				," +
                "INJ_INJETORA_ORCAMENTO			," +
                "INJ_CAPACIDADE_ORCAMENTO		," +
                "INJ_DIMENSAO_ORCAMENTO			," +
                "INJ_CLICO_ORCAMENTOS			," +
                "INJ_OBS_ORCAMENTOS				," +
                "INJ_PESO_PRODUTO_ORCAMENTO		," +
                "INJ_PESO_CANAL_ORCAMENTO		," +
                "INJ_MATERIAL_ORCAMENTO			," +
                "INJ_PERIFERICOS_ORCAMENTOS		," +
                "INJ_VALOR_PER_ORCAMENTOS		," +
                "GAVETAS_MECANICAS_ORCAMENTO		," +
                "GAVETAS_HIDRAULICAS_ORCAMENTO	," +
                "SENSORES_ORCAMENTO				," +
                "REVISAO_ORCAMENTO				," +
                "PART_NUMBER_ORCAMENTO			," +
                "MOLDES_SIMILARES_ORCAMENTOS		," +
                "MAIOR_POTENCIAL_ORCAMENTO		," +
                "INJ_PONTOS_ORCAMENTO			," +
                "HORAS_FRESA_ORCAMENTO			," +
                "HORAS_RET_PERFIL_ORCAMENTO		," +
                "HORAS_RET_CILIN_ORCAMENTO		," +
                "HORAS_EROSAO_PEN_ORCAMENTO		," +
                "HORAS_TORNO_CONV_ORCAMENTO		," +
                "HORAS_TORNO_CNC_ORCAMENTO		," +
                "HORAS_EROSAO_FIO_ORCAMENTO		," +
                "HORAS_CENTRO_USI_ORCAMENTO		," +
                "HORAS_TRAT_TERM_ORCAMENTO		," +
                "HORAS_ELETRODO_CONV_ORCAMENTO	," +
                "HORAS_ELETRODO_HIGH_ORCAMENTO	," +
                "HORAS_ELETRODO_FIO_ORCAMENTO	," +
                "HORAS_HIGH_SPEED_ORCAMENTO		," +
                "HORAS_BANCADA_ORCAMENTO			," +
                "VALOR_FRESA_ORCAMENTO			," +
                "VALOR_RET_PERFIL_ORCAMENTO		," +
                "VALOR_RET_CILIN_ORCAMENTO		," +
                "VALOR_EROSAO_PEN_ORCAMENTO		," +
                "VALOR_TORNO_CONV_ORCAMENTO		," +
                "VALOR_TORNO_CNC_ORCAMENTO		," +
                "VALOR_EROSAO_FIO_ORCAMENTO		," +
                "VALOR_CENTRO_USI_ORCAMENTO		," +
                "VALOR_TRAT_TERM_ORCAMENTO		," +
                "VALOR_ELETRODO_CONV_ORCAMENTO	," +
                "VALOR_ELETRODO_HIGH_ORCAMENTO	," +
                "VALOR_ELETRODO_FIO_ORCAMENTO	," +
                "VALOR_HIGH_SPEED_ORCAMENTO		," +
                "VALOR_BANCADA_ORCAMENTO			," +
                "VH_FRESA_ORCAMENTO				," +
                "VH_RET_PERFIL_ORCAMENTO			," +
                "VH_RET_CILIN_ORCAMENTO			," +
                "VH_EROSAO_PEN_ORCAMENTO			," +
                "VH_TORNO_CONV_ORCAMENTO			," +
                "VH_TORNO_CNC_ORCAMENTO			," +
                "VH_EROSAO_FIO_ORCAMENTO			," +
                "VH_CENTRO_USI_ORCAMENTO			," +
                "VH_TRAT_TERM_ORCAMENTO			," +
                "VH_ELETRODO_CONV_ORCAMENTO		," +
                "VH_ELETRODO_HIGH_ORCAMENTO		," +
                "VH_ELETRODO_FIO_ORCAMENTO		," +
                "VH_HIGH_SPEED_ORCAMENTO			," +
                "VH_BANCADA_ORCAMENTO			," +
                "LARGURA_PORTA_MOLDE_ORC			," +
                "COMPRIMENTO_PORTA_MOLDE_ORC		," +
                "ALTURA_PORTA_MOLDE_ORC			," +
                "PESO_PORTA_MOLDE_ORC			," +
                "QUANTIDADE_BICO_QUENTE_ORC		," +
                "VALOR_BICO_QUENTE_ORC			," +
                "ADICIONAL_BICO_QUENTE_ORC		," +
                "QTDE_CAVIDADES_ORC				," +
                "CAMARA_QUENTE_ORC				," +
                "BICO_QUENTE_ORC					," +
                "DIMENSAO_CAVIDADE_ORC			," +
                "TOTAL_BICO_QUENTE_ORC			," +
                "TOTAL_CAMERA_QUENTE_ORC			," +
                "TOTAL_GAVETAS_ORC				," +
                "HORAS_ADIC_OPER1_ORCAMENTO		," +
                "HORAS_ADIC_OPER2_ORCAMENTO		," +
                "HORAS_ADIC_OPER3_ORCAMENTO		," +
                "HORAS_ADIC_OPER4_ORCAMENTO		," +
                "HORAS_ADIC_OPER5_ORCAMENTO		," +
                "HORAS_ADIC_OPER6_ORCAMENTO		," +
                "HORAS_ADIC_OPER7_ORCAMENTO		," +
                "HORAS_ADIC_OPER8_ORCAMENTO		," +
                "HORAS_ADIC_OPER9_ORCAMENTO		," +
                "HORAS_ADIC_OPER10_ORCAMENTO		," +
                "HORAS_ADIC_OPER11_ORCAMENTO		," +
                "HORAS_ADIC_OPER12_ORCAMENTO		," +
                "HORAS_ADIC_OPER13_ORCAMENTO		," +
                "HORAS_ADIC_OPER14_ORCAMENTO		," +
                "HORAS_ADIC_OPER15_ORCAMENTO		," +
                "HORAS_ADIC_OPER16_ORCAMENTO		," +
                "HORAS_ADIC_OPER17_ORCAMENTO		," +
                "HORAS_ADIC_OPER18_ORCAMENTO		," +
                "HORAS_ADIC_OPER19_ORCAMENTO		," +
                "HORAS_ADIC_OPER20_ORCAMENTO		," +
                "HORAS_ADIC_OPER21_ORCAMENTO		," +
                "HORAS_ADIC_OPER22_ORCAMENTO		," +
                "HORAS_PADRAO_OPER1_ORCAMENTO	," +
                "HORAS_PADRAO_OPER2_ORCAMENTO	," +
                "HORAS_PADRAO_OPER3_ORCAMENTO	," +
                "HORAS_PADRAO_OPER4_ORCAMENTO	," +
                "HORAS_PADRAO_OPER5_ORCAMENTO	," +
                "HORAS_PADRAO_OPER6_ORCAMENTO	," +
                "HORAS_PADRAO_OPER7_ORCAMENTO	," +
                "HORAS_PADRAO_OPER8_ORCAMENTO	," +
                "HORAS_PADRAO_OPER9_ORCAMENTO	," +
                "HORAS_PADRAO_OPER10_ORCAMENTO	," +
                "HORAS_PADRAO_OPER11_ORCAMENTO	," +
                "HORAS_PADRAO_OPER12_ORCAMENTO	," +
                "HORAS_PADRAO_OPER13_ORCAMENTO	," +
                "HORAS_PADRAO_OPER14_ORCAMENTO	," +
                "HORAS_PADRAO_OPER15_ORCAMENTO	," +
                "HORAS_PADRAO_OPER16_ORCAMENTO	," +
                "HORAS_PADRAO_OPER17_ORCAMENTO	," +
                "HORAS_PADRAO_OPER18_ORCAMENTO	," +
                "HORAS_PADRAO_OPER19_ORCAMENTO	," +
                "HORAS_PADRAO_OPER20_ORCAMENTO	," +
                "HORAS_PADRAO_OPER21_ORCAMENTO	," +
                "HORAS_PADRAO_OPER22_ORCAMENTO	," +
                "TOTAL_SERV_MOLDE_ORCAMENTO		," +
                "VALOR_MATERIAL_PECA_ORCAMENTO	," +
                "MOLDE_SIMILAR_ORCAMENTO			," +
                "N_ORCAMENTO						," +
                "INJ_OUTROS_ORCAMENTOS			," +
                "INJ_CONVECIONAL_ORCAMENTO, DATA_CRIACAO_ORCAMENTO " +
                " FROM ORCAMENTOS WHERE COD_ORCAMENTO = '" + _cod_orcamento + "'";
                //this.datOrcamentos.InsertCommand.CommandText =
                //    "INSERT INTO ORCAMENTOS (" +
                //"   CLIENTE_ORCAMENTO	, " +
                //"	CONTATO_CLIENTE_ORCAMENTO	, " +
                //"	EMAIL_CONTATO_ORCAMENTO	, " +
                //"	DATA_ORCAMENTO	, " +
                //"	BENEFICIAMENTO_ORCAMENTO	, " +
                //"	VENDAS_ORCAMENTO	, " +
                //"	TOTAL_QTDE_PECAS_ORCAMENTO	, " +
                //"	HORAS_OPER1_ORCAMENTO	, " +
                //"	HORAS_OPER2_ORCAMENTO	, " +
                //"	HORAS_OPER3_ORCAMENTO	, " +
                //"	HORAS_OPER4_ORCAMENTO	, " +
                //"	HORAS_OPER5_ORCAMENTO	, " +
                //"	HORAS_OPER6_ORCAMENTO	, " +
                //"	HORAS_OPER7_ORCAMENTO	, " +
                //"	HORAS_OPER8_ORCAMENTO	, " +
                //"	HORAS_OPER9_ORCAMENTO	, " +
                //"	HORAS_OPER10_ORCAMENTO	, " +
                //"	HORAS_OPER11_ORCAMENTO	, " +
                //"	HORAS_OPER12_ORCAMENTO	, " +
                //"	HORAS_OPER13_ORCAMENTO	, " +
                //"	HORAS_OPER14_ORCAMENTO	, " +
                //"	HORAS_OPER15_ORCAMENTO	, " +
                //"	HORAS_OPER16_ORCAMENTO	, " +
                //"	HORAS_OPER17_ORCAMENTO	, " +
                //"	HORAS_OPER18_ORCAMENTO	, " +
                //"	HORAS_OPER19_ORCAMENTO	, " +
                //"	HORAS_OPER20_ORCAMENTO	, " +
                //"	HORAS_OPER21_ORCAMENTO	, " +
                //"	HORAS_OPER22_ORCAMENTO	, " +
                //"	VALOR_OPER1_ORCAMENTO	, " +
                //"	VALOR_OPER2_ORCAMENTO	, " +
                //"	VALOR_OPER3_ORCAMENTO	, " +
                //"	VALOR_OPER4_ORCAMENTO	, " +
                //"	VALOR_OPER5_ORCAMENTO	, " +
                //"	VALOR_OPER6_ORCAMENTO	, " +
                //"	VALOR_OPER7_ORCAMENTO	, " +
                //"	VALOR_OPER8_ORCAMENTO	, " +
                //"	VALOR_OPER9_ORCAMENTO	, " +
                //"	VALOR_OPER10_ORCAMENTO	, " +
                //"	VALOR_OPER11_ORCAMENTO	, " +
                //"	VALOR_OPER12_ORCAMENTO	, " +
                //"	VALOR_OPER13_ORCAMENTO	, " +
                //"	VALOR_OPER14_ORCAMENTO	, " +
                //"	VALOR_OPER15_ORCAMENTO	, " +
                //"	VALOR_OPER16_ORCAMENTO	, " +
                //"	VALOR_OPER17_ORCAMENTO	, " +
                //"	VALOR_OPER18_ORCAMENTO	, " +
                //"	VALOR_OPER19_ORCAMENTO	, " +
                //"	VALOR_OPER20_ORCAMENTO	, " +
                //"	VALOR_OPER21_ORCAMENTO	, " +
                //"	VALOR_OPER22_ORCAMENTO	, " +
                //"	VALOR_TOTAL_ORCAMENTO	, " +
                //"	PRAZO_ENTREGA_ORCAMENTO	, " +
                //"	VALIDADE_ORCAMENTO	, " +
                //"	IMPOSTOS_ORCAMENTO	, " +
                //"	STATUS_ORCAMENTO	, " +
                //"	OBS_ORCAMENTO	, " +
                //"	IMPRESSAO_COD_ORCAMENTO	, " +
                //"	MAT_PRI_COMP_DISP_ORC_SIM	, " +
                //"	MAT_PRI_COMP_DISP_ORC_NAO	, " +
                //"	MAO_OBRA_EQUIP_DISP_ORC_SIM	, " +
                //"	MAO_OBRA_EQUIP_DISP_ORC_NAO	, " +
                //"	EMBAL_TRANSP_DISP_ORC_SIM	, " +
                //"	EMBAL_TRANSP_DISP_ORC_NAO	, " +
                //"	ESPEC_MAT_PRI_COMP_ORCAMENTO	, " +
                //"	ESPEC_MAO_OBRA_EQUIP_ORCAMENTO	, " +
                //"	ESPEC_EMBAL_TRANSP_ORCAMENTO	, " +
                //"	TOTAL_HORAS_ORCAMENTO	, " +
                //"	DATA_APROVACAO_ORCAMENTO	, " +
                //"	VALOR_MAT_PRI_ORCAMENTO	, " +
                //"	MAT_PRI_FORN_POR_ORCAMENTO	, " +
                //"	VALIDADE_ORC_ORCAMENTO	, " +
                //"	COND_ENTREGA_ORCAMENTO	, " +
                //"	RESPONSAVEL_ORCAMENTO	, " +
                //"	TIPO_INJECAO_ORCAMENTO	, " +
                //"	FORN_TIPO_INJECAO_ORCAMENTO	, " +
                //"	QTDE_BICOS_INJECAO_ORCAMENTO	, " +
                //"	HORAS_CAD_ORCAMENTO	, " +
                //"	CUSTO_CAD_ORCAMENTO	, " +
                //"	VALOR_TOTAL_CAD_ORCAMENTO	, " +
                //"	HORAS_MODEL_ORCAMENTO	, " +
                //"	CUSTO_MODEL_ORCAMENTO	, " +
                //"	VALOR_TOTAL_MODEL_ORCAMENTO	, " +
                //"	N_P_ORCAMENTO	, " +
                //"	DESCRICAO_ORCAMENTO	, " +
                //"	PROJETO_ORCAMENTO	, " +
                //"	N_CAVIDADES_ORCAMENTO	, " +
                //"	TRANSPORTE_ORCAMENTO	, " +
                //"	TRY_OUT_ORCAMENTO	, " +
                //"	VH_OPER1_ORCAMENTO	, " +
                //"	VH_OPER2_ORCAMENTO	, " +
                //"	VH_OPER3_ORCAMENTO	, " +
                //"	VH_OPER4_ORCAMENTO	, " +
                //"	VH_OPER5_ORCAMENTO	, " +
                //"	VH_OPER6_ORCAMENTO	, " +
                //"	VH_OPER7_ORCAMENTO	, " +
                //"	VH_OPER8_ORCAMENTO	, " +
                //"	VH_OPER9_ORCAMENTO	, " +
                //"	VH_OPER10_ORCAMENTO	, " +
                //"	VH_OPER11_ORCAMENTO	, " +
                //"	VH_OPER12_ORCAMENTO	, " +
                //"	VH_OPER13_ORCAMENTO	, " +
                //"	VH_OPER14_ORCAMENTO	, " +
                //"	VH_OPER15_ORCAMENTO	, " +
                //"	VH_OPER16_ORCAMENTO	, " +
                //"	VH_OPER17_ORCAMENTO	, " +
                //"	VH_OPER18_ORCAMENTO	, " +
                //"	VH_OPER19_ORCAMENTO	, " +
                //"	VH_OPER20_ORCAMENTO	, " +
                //"	VH_OPER21_ORCAMENTO	, " +
                //"	VH_OPER22_ORCAMENTO	, " +
                //"	FERRAMENTA_ORCAMENTO	, " +
                //"	VALORES_IMPOSTOS_ORCAMENTO	, " +
                //"	TOTAL_GERAL_ORCAMENTO	, " +
                //"	PM_H13_ORCAMENTO	, " +
                //"	PM_1045_ORCAMENTO	, " +
                //"	PM_TEMPERADO_ORCAMENTO	, " +
                //"	PM_RAMAX_ORCAMENTO	, " +
                //"	PM_P20_ORCAMENTO	, " +
                //"	PM_S_TEMPERA_ORCAMENTO	, " +
                //"	MAT_H13_ORCAMENTO	, " +
                //"	MAT_E420_ORCAMENTO	, " +
                //"	MAT_VND_ORCAMENTO	, " +
                //"	MAT_VC131_ORCAMENTO	, " +
                //"	MAT_CPM4_ORCAMENTO	, " +
                //"	MAT_OUTROS_ORCAMENTO	, " +
                //"	MAT_TEMPERADO_ORCAMENTO	, " +
                //"	COM_GAVETAS_ORCAMENTO	, " +
                //"	SEM_GAVETAS_ORCAMENTO	, " +
                //"	EXT_PINOS_ORCAMENTO	, " +
                //"	EXT_LAMINAS_ORCAMENTO	, " +
                //"	EXT_CAMES_ORCAMENTO	, " +
                //"	EXT_COM_PLACA_ORCAMENTO	, " +
                //"	EXT_BUCHA_ORCAMENTO	, " +
                //"	INJ_DIRETA_ORCAMENTO	, " +
                //"	INJ_SUBMARINA_ORCAMENTO	, " +
                //"	INJ_BICO_QUENTE_ORCAMENTO	, " +
                //"	INJ_CAMARA_QUENTE_ORCAMENTO	, " +
                //"	ACAB_POLIDO_ORCAMENTO	, " +
                //"	ACAB_ESPELHADO_ORCAMENTO	, " +
                //"	ACAB_TEXTURA_ORCAMENTO	, " +
                //"	ACAB_QUIMICA_ORCAMENTO	, " +
                //"	ACAB_EROSAO_ORCAMENTO	, " +
                //"	DESC_OUTROS_MAT_ORCAMENTO	, " +
                //"	EXT_OUTROS_ORCAMENTO	, " +
                //"	DESC_EXT_OUTROS_ORCAMENTO	, " +
                //"	CONDICAO_PGTO_ORCAMENTO" +
                //")  SELECT" +
                //"   CLIENTE_ORCAMENTO	, " +
                //"	CONTATO_CLIENTE_ORCAMENTO	, " +
                //"	EMAIL_CONTATO_ORCAMENTO	, " +
                //"	DATA_ORCAMENTO	, " +
                //"	BENEFICIAMENTO_ORCAMENTO	, " +
                //"	VENDAS_ORCAMENTO	, " +
                //"	TOTAL_QTDE_PECAS_ORCAMENTO	, " +
                //"	HORAS_OPER1_ORCAMENTO	, " +
                //"	HORAS_OPER2_ORCAMENTO	, " +
                //"	HORAS_OPER3_ORCAMENTO	, " +
                //"	HORAS_OPER4_ORCAMENTO	, " +
                //"	HORAS_OPER5_ORCAMENTO	, " +
                //"	HORAS_OPER6_ORCAMENTO	, " +
                //"	HORAS_OPER7_ORCAMENTO	, " +
                //"	HORAS_OPER8_ORCAMENTO	, " +
                //"	HORAS_OPER9_ORCAMENTO	, " +
                //"	HORAS_OPER10_ORCAMENTO	, " +
                //"	HORAS_OPER11_ORCAMENTO	, " +
                //"	HORAS_OPER12_ORCAMENTO	, " +
                //"	HORAS_OPER13_ORCAMENTO	, " +
                //"	HORAS_OPER14_ORCAMENTO	, " +
                //"	HORAS_OPER15_ORCAMENTO	, " +
                //"	HORAS_OPER16_ORCAMENTO	, " +
                //"	HORAS_OPER17_ORCAMENTO	, " +
                //"	HORAS_OPER18_ORCAMENTO	, " +
                //"	HORAS_OPER19_ORCAMENTO	, " +
                //"	HORAS_OPER20_ORCAMENTO	, " +
                //"	HORAS_OPER21_ORCAMENTO	, " +
                //"	HORAS_OPER22_ORCAMENTO	, " +
                //"	VALOR_OPER1_ORCAMENTO	, " +
                //"	VALOR_OPER2_ORCAMENTO	, " +
                //"	VALOR_OPER3_ORCAMENTO	, " +
                //"	VALOR_OPER4_ORCAMENTO	, " +
                //"	VALOR_OPER5_ORCAMENTO	, " +
                //"	VALOR_OPER6_ORCAMENTO	, " +
                //"	VALOR_OPER7_ORCAMENTO	, " +
                //"	VALOR_OPER8_ORCAMENTO	, " +
                //"	VALOR_OPER9_ORCAMENTO	, " +
                //"	VALOR_OPER10_ORCAMENTO	, " +
                //"	VALOR_OPER11_ORCAMENTO	, " +
                //"	VALOR_OPER12_ORCAMENTO	, " +
                //"	VALOR_OPER13_ORCAMENTO	, " +
                //"	VALOR_OPER14_ORCAMENTO	, " +
                //"	VALOR_OPER15_ORCAMENTO	, " +
                //"	VALOR_OPER16_ORCAMENTO	, " +
                //"	VALOR_OPER17_ORCAMENTO	, " +
                //"	VALOR_OPER18_ORCAMENTO	, " +
                //"	VALOR_OPER19_ORCAMENTO	, " +
                //"	VALOR_OPER20_ORCAMENTO	, " +
                //"	VALOR_OPER21_ORCAMENTO	, " +
                //"	VALOR_OPER22_ORCAMENTO	, " +
                //"	VALOR_TOTAL_ORCAMENTO	, " +
                //"	PRAZO_ENTREGA_ORCAMENTO	, " +
                //"	VALIDADE_ORCAMENTO	, " +
                //"	IMPOSTOS_ORCAMENTO	, " +
                //"	STATUS_ORCAMENTO	, " +
                //"	OBS_ORCAMENTO	, " +
                //"	IMPRESSAO_COD_ORCAMENTO	, " +
                //"	MAT_PRI_COMP_DISP_ORC_SIM	, " +
                //"	MAT_PRI_COMP_DISP_ORC_NAO	, " +
                //"	MAO_OBRA_EQUIP_DISP_ORC_SIM	, " +
                //"	MAO_OBRA_EQUIP_DISP_ORC_NAO	, " +
                //"	EMBAL_TRANSP_DISP_ORC_SIM	, " +
                //"	EMBAL_TRANSP_DISP_ORC_NAO	, " +
                //"	ESPEC_MAT_PRI_COMP_ORCAMENTO	, " +
                //"	ESPEC_MAO_OBRA_EQUIP_ORCAMENTO	, " +
                //"	ESPEC_EMBAL_TRANSP_ORCAMENTO	, " +
                //"	TOTAL_HORAS_ORCAMENTO	, " +
                //"	DATA_APROVACAO_ORCAMENTO	, " +
                //"	VALOR_MAT_PRI_ORCAMENTO	, " +
                //"	MAT_PRI_FORN_POR_ORCAMENTO	, " +
                //"	VALIDADE_ORC_ORCAMENTO	, " +
                //"	COND_ENTREGA_ORCAMENTO	, " +
                //"	RESPONSAVEL_ORCAMENTO	, " +
                //"	TIPO_INJECAO_ORCAMENTO	, " +
                //"	FORN_TIPO_INJECAO_ORCAMENTO	, " +
                //"	QTDE_BICOS_INJECAO_ORCAMENTO	, " +
                //"	HORAS_CAD_ORCAMENTO	, " +
                //"	CUSTO_CAD_ORCAMENTO	, " +
                //"	VALOR_TOTAL_CAD_ORCAMENTO	, " +
                //"	HORAS_MODEL_ORCAMENTO	, " +
                //"	CUSTO_MODEL_ORCAMENTO	, " +
                //"	VALOR_TOTAL_MODEL_ORCAMENTO	, " +
                //"	N_P_ORCAMENTO	, " +
                //"	DESCRICAO_ORCAMENTO	, " +
                //"	PROJETO_ORCAMENTO	, " +
                //"	N_CAVIDADES_ORCAMENTO	, " +
                //"	TRANSPORTE_ORCAMENTO	, " +
                //"	TRY_OUT_ORCAMENTO	, " +
                //"	VH_OPER1_ORCAMENTO	, " +
                //"	VH_OPER2_ORCAMENTO	, " +
                //"	VH_OPER3_ORCAMENTO	, " +
                //"	VH_OPER4_ORCAMENTO	, " +
                //"	VH_OPER5_ORCAMENTO	, " +
                //"	VH_OPER6_ORCAMENTO	, " +
                //"	VH_OPER7_ORCAMENTO	, " +
                //"	VH_OPER8_ORCAMENTO	, " +
                //"	VH_OPER9_ORCAMENTO	, " +
                //"	VH_OPER10_ORCAMENTO	, " +
                //"	VH_OPER11_ORCAMENTO	, " +
                //"	VH_OPER12_ORCAMENTO	, " +
                //"	VH_OPER13_ORCAMENTO	, " +
                //"	VH_OPER14_ORCAMENTO	, " +
                //"	VH_OPER15_ORCAMENTO	, " +
                //"	VH_OPER16_ORCAMENTO	, " +
                //"	VH_OPER17_ORCAMENTO	, " +
                //"	VH_OPER18_ORCAMENTO	, " +
                //"	VH_OPER19_ORCAMENTO	, " +
                //"	VH_OPER20_ORCAMENTO	, " +
                //"	VH_OPER21_ORCAMENTO	, " +
                //"	VH_OPER22_ORCAMENTO	, " +
                //"	FERRAMENTA_ORCAMENTO	, " +
                //"	VALORES_IMPOSTOS_ORCAMENTO	, " +
                //"	TOTAL_GERAL_ORCAMENTO	, " +
                //"	PM_H13_ORCAMENTO	, " +
                //"	PM_1045_ORCAMENTO	, " +
                //"	PM_TEMPERADO_ORCAMENTO	, " +
                //"	PM_RAMAX_ORCAMENTO	, " +
                //"	PM_P20_ORCAMENTO	, " +
                //"	PM_S_TEMPERA_ORCAMENTO	, " +
                //"	MAT_H13_ORCAMENTO	, " +
                //"	MAT_E420_ORCAMENTO	, " +
                //"	MAT_VND_ORCAMENTO	, " +
                //"	MAT_VC131_ORCAMENTO	, " +
                //"	MAT_CPM4_ORCAMENTO	, " +
                //"	MAT_OUTROS_ORCAMENTO	, " +
                //"	MAT_TEMPERADO_ORCAMENTO	, " +
                //"	COM_GAVETAS_ORCAMENTO	, " +
                //"	SEM_GAVETAS_ORCAMENTO	, " +
                //"	EXT_PINOS_ORCAMENTO	, " +
                //"	EXT_LAMINAS_ORCAMENTO	, " +
                //"	EXT_CAMES_ORCAMENTO	, " +
                //"	EXT_COM_PLACA_ORCAMENTO	, " +
                //"	EXT_BUCHA_ORCAMENTO	, " +
                //"	INJ_DIRETA_ORCAMENTO	, " +
                //"	INJ_SUBMARINA_ORCAMENTO	, " +
                //"	INJ_BICO_QUENTE_ORCAMENTO	, " +
                //"	INJ_CAMARA_QUENTE_ORCAMENTO	, " +
                //"	ACAB_POLIDO_ORCAMENTO	, " +
                //"	ACAB_ESPELHADO_ORCAMENTO	, " +
                //"	ACAB_TEXTURA_ORCAMENTO	, " +
                //"	ACAB_QUIMICA_ORCAMENTO	, " +
                //"	ACAB_EROSAO_ORCAMENTO	, " +
                //"	DESC_OUTROS_MAT_ORCAMENTO	, " +
                //"	EXT_OUTROS_ORCAMENTO	, " +
                //"	DESC_EXT_OUTROS_ORCAMENTO	, " +
                //"	CONDICAO_PGTO_ORCAMENTO" +
                //" FROM ORCAMENTOS WHERE COD_ORCAMENTO = '" + _cod_orcamento + "'";
                this.fbConnection1.Open();
                this.datOrcamentos.InsertCommand.Connection = fbConnection1;
                this.datOrcamentos.InsertCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void tb_item_ret_perfil_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdbPeca_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPeca.Checked)
            {
                if (tb_cliente.Text.Trim() != "NOVO")
                {
                    if (tb_cliente.Text.Trim() != "")
                    {
                        preencher_tbs_vh(_cnpj);
                        renomearDgvItensOrc(_cnpj);
                    }
                }
            }
        }

        private void rdbMolde_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMolde.Checked)
            {
                if (tb_cliente.Text.Trim() != "NOVO")
                {

                    if (tb_cliente.Text.Trim() != "")
                    {
                        preencher_tbs_vh(_cnpj);
                        renomearDgvItensOrc(_cnpj);
                    }
                }
            }
        }

        private void tb_valor_outras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                inserir_outros_servicos();
            }
        }

        private void inserir_outros_servicos()
        {
            string desc = ""; double valor_outras = 0; double qtde_outras = 0; double total_outras = 0;
            try
            {
                desc = tb_desc_outras.Text.ToString();
                Double.TryParse(tb_valor_outras.Text.ToString(), out valor_outras);
            }
            catch
            { }

            string qtde = "";

            try
            {
                qtde_outras = Convert.ToDouble(tb_qtde_outras.Text.ToString());
                qtde = "'" + qtde_outras.ToString().Replace(",", ".") + "'";
            }
            catch { qtde = "null"; }


            total_outras = qtde_outras * valor_outras;

            try
            {
                this.datOutros_servicos.InsertCommand.CommandText =
                    "INSERT INTO OUTROS_SERVICOS_ORC (DESCRICAO_OUTROS, VALOR_OUTROS, COD_ORC_OUTROS,VALOR_TOTAL_OUTROS,QTD_VALOR_OUTROS) VALUES ('" +
                    desc + "', '" + valor_outras.ToString().Replace(".", "").Replace(",", ".") + "', '" + tb_cod.Text + "', '" + total_outras.ToString().Replace(".", "").Replace(",", ".") + "'," + qtde + ")";
                this.fbConnection1.Open();
                this.datOutros_servicos.InsertCommand.Connection = fbConnection1;
                this.datOutros_servicos.InsertCommand.ExecuteNonQuery();
                this.fbConnection1.Close();

                dsOutros_servicos.Clear();
                this.datOutros_servicos.SelectCommand.CommandText =
                    "SELECT * FROM OUTROS_SERVICOS_ORC WHERE COD_ORC_OUTROS = '" + tb_cod.Text + "'";
                this.fbConnection1.Open();
                this.datOutros_servicos.SelectCommand.Connection = fbConnection1;
                this.datOutros_servicos.SelectCommand.ExecuteNonQuery();
                datOutros_servicos.Fill(OUTROS_SERVICOS_ORC);
                this.fbConnection1.Close();
                tb_qtde_outras.Text = "";
                tb_desc_outras.Text = "";
                tb_valor_outras.Text = "";
            }
            catch
            {
                fbConnection1.Close();
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            somar_outras_despesas();
        }

        private void somar_outras_despesas()
        {
            double _total_outras = 0, _qtde_mat = 0, _valor_mat = 0, _total = 0;
            for (int i = 0; i < dgvOutras.RowCount; i++)
            {
                try
                {
                    Double.TryParse(dgvOutras.Rows[i].Cells["col_qtde_outros"].Value.ToString(), out _qtde_mat);
                    Double.TryParse(dgvOutras.Rows[i].Cells["col_valor_outros"].Value.ToString(), out _valor_mat);
                    _total = _qtde_mat * _valor_mat;
                    dgvOutras.Rows[i].Cells["col_total_outros"].Value = _total;
                }
                catch { }
            }

            for (int i = 0; i < dgvOutras.RowCount; i++)
            {
                try
                {
                    _total_outras = _total_outras + Convert.ToDouble(dgvOutras.Rows[i].Cells["col_total_outros"].Value.ToString());
                }
                catch { }
            }
            tb_total_outras.Text = _total_outras.ToString();

        }

        private void cbEmerson_CheckedChanged(object sender, EventArgs e)
        {
            if (cbClemilton.Checked)
            {
                if (cbEmerson.Checked)
                {
                    tb_responsavel.Text = "Emerson de Oliveira / Fabiano Baldi";
                }
                else
                {
                    tb_responsavel.Text = "Fabiano Baldi";
                }
            }
            else
            {
                if (cbEmerson.Checked)
                {
                    tb_responsavel.Text = "Emerson de Oliveira";
                }
                else
                {
                    tb_responsavel.Text = "";
                }
            }
        }

        private void cbFabiano_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEmerson.Checked)
            {
                if (cbClemilton.Checked)
                {
                    tb_responsavel.Text = "Emerson de Oliveira / Fabiano Baldi";
                }
                else
                {
                    tb_responsavel.Text = "Emerson de Oliveira";
                }
            }
            else
            {
                if (cbClemilton.Checked)
                {
                    tb_responsavel.Text = "Fabiano Baldi";
                }
                else
                {
                    tb_responsavel.Text = "";
                }
            }
        }

        private void tb_item_mat_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_qtde_outras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                inserir_outros_servicos();
            }
        }

        private void tb_desc_outras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                inserir_outros_servicos();
            }
        }

        private void tb_imp_perc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                inserir_impostos();
            }
        }

        private void inserir_impostos()
        {
            string desc = ""; double perc = 0;
            try
            {
                desc = tb_imp_desc.Text.ToString();
                perc = Convert.ToDouble(tb_imp_perc.Text.ToString());

            }
            catch
            { }
            try
            {
                this.datImpostos_orc.InsertCommand.CommandText =
                    "INSERT INTO IMPOSTOS_ORC (DESCRICAO_IMPOSTOS_ORC, PERCENTUAL_IMPOSTOS_ORC, COD_ORC_IMPOSTOS_ORC) VALUES ('" +
                    desc + "', '" + perc.ToString().Replace(".", "").Replace(",", ".") + "', '" + tb_cod.Text + "')";
                this.fbConnection1.Open();
                this.datImpostos_orc.InsertCommand.Connection = fbConnection1;
                this.datImpostos_orc.InsertCommand.ExecuteNonQuery();
                this.fbConnection1.Close();

                dsImpostos_orc.Clear();
                this.datImpostos_orc.SelectCommand.CommandText =
                    "SELECT * FROM IMPOSTOS_ORC WHERE COD_ORC_IMPOSTOS_ORC = '" + tb_cod.Text + "'";
                this.fbConnection1.Open();
                this.datImpostos_orc.SelectCommand.Connection = fbConnection1;
                this.datImpostos_orc.SelectCommand.ExecuteNonQuery();
                datImpostos_orc.Fill(IMPOSTOS_ORC);
                this.fbConnection1.Close();
                tb_imp_perc.Text = "";
                tb_imp_desc.Text = "";
            }
            catch
            {
                fbConnection1.Close();
            }
        }
        private void somar_impostos(out double ipi)
        {
            ipi = 0;
            double _total_imposto = 0;
            for (int i = 0; i < dgvImposto_orc.RowCount; i++)
            {
                try
                {
                    if (dgvImposto_orc.Rows[i].Cells["col_descricao_imposto"].Value.ToString() == "IPI")
                    {
                        try
                        {
                            ipi = Convert.ToDouble(dgvImposto_orc.Rows[i].Cells["col_perc"].Value.ToString());
                        }
                        catch { ipi = 0; }
                    }
                    else
                    {
                        _total_imposto = _total_imposto + Convert.ToDouble(dgvImposto_orc.Rows[i].Cells["col_perc"].Value.ToString());
                    }
                }
                catch { }
            }
            tb_valor_impostos.Text = _total_imposto.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            double ipi = 0;
            somar_impostos(out ipi);
        }
        private void imprimirAnaliseMolde()
        {
            //if (tb_data_orcamento.Text == "")
            //    MessageBox.Show("Digite uma data para o orçamento por favor");
            //else
            //{
            //    Salvar();
            //    comando_select.CommandText = "SELECT * FROM CLIENTES WHERE RAZAO_SOCIAL = '" + tb_cliente.Text + "'";
            //    DataSet cliente = new DataSet();
            //    fbConnection1.Open();
            //    datClientes.SelectCommand = comando_select;
            //    datClientes.Fill(cliente);
            //    string _cod = "";
            //    foreach (DataRow dr in cliente.Tables[0].Rows)
            //    {
            //        _cod = dr["COD_CLIENTE"].ToString();

            //    }
            //    fbConnection1.Close();
            //    update_cod_orcamento(_cod);

            //    this.datOrcamentos.SelectCommand.CommandText =
            //        "SELECT * FROM ORCAMENTOS WHERE COD_ORCAMENTO = '" + tb_cod.Text + "'";
            //    this.fbConnection1.Open();
            //    this.datOrcamentos.SelectCommand.Connection = fbConnection1;
            //    this.datOrcamentos.SelectCommand.ExecuteNonQuery();

            //    this.fbConnection1.Close();
            //    dsOrcamentos orc = new dsOrcamentos();
            //    fbConnection1.Open();
            //    datClientes.Fill(orc.CLIENTES);
            //    datOrcamentos.Fill(orc.ORCAMENTOS);
            //    int h1 = orc.ORCAMENTOS.Columns["HORAS_OPER1_ORCAMENTO"].Ordinal;
            //    int v1 = orc.ORCAMENTOS.Columns["VALOR_OPER1_ORCAMENTO"].Ordinal;
            //    int vh1 = orc.ORCAMENTOS.Columns["VH_OPER1_ORCAMENTO"].Ordinal;
            //    int n1 = orc.ORCAMENTOS.Columns["NOME_OPER1_ORCAMENTO"].Ordinal;
            //    for (int i = h1; i < (h1 + 14); i++)
            //    {
            //        if (orc.ORCAMENTOS.Rows[0][i].ToString() != "0" && orc.ORCAMENTOS.Rows[0][i].ToString().Trim() != "")
            //        {
            //            orc.operacoesMolde.AddoperacoesMoldeRow(orc.ORCAMENTOS.Rows[0][n1].ToString(),
            //                Convert.ToDouble(orc.ORCAMENTOS.Rows[0][i].ToString()),
            //                Convert.ToDouble(orc.ORCAMENTOS.Rows[0][vh1].ToString()),
            //                Convert.ToDouble(orc.ORCAMENTOS.Rows[0][v1].ToString()));
            //        }
            //        v1++;
            //        vh1++;
            //        n1++;
            //    }
            //    h1 = orc.ORCAMENTOS.Columns["HORAS_OPER15_ORCAMENTO"].Ordinal;
            //    v1 = orc.ORCAMENTOS.Columns["VALOR_OPER15_ORCAMENTO"].Ordinal;
            //    vh1 = orc.ORCAMENTOS.Columns["VH_OPER15_ORCAMENTO"].Ordinal;
            //    n1 = orc.ORCAMENTOS.Columns["NOME_OPER15_ORCAMENTO"].Ordinal;
            //    for (int i = h1; i < (h1 + 8); i++)
            //    {
            //        if (orc.ORCAMENTOS.Rows[0][i].ToString() != "0" && orc.ORCAMENTOS.Rows[0][i].ToString().Trim() != "")
            //        {
            //            orc.operacoesMolde.AddoperacoesMoldeRow(orc.ORCAMENTOS.Rows[0][n1].ToString(),
            //                Convert.ToDouble(orc.ORCAMENTOS.Rows[0][i].ToString()),
            //                Convert.ToDouble(orc.ORCAMENTOS.Rows[0][vh1].ToString()),
            //                Convert.ToDouble(orc.ORCAMENTOS.Rows[0][v1].ToString()));
            //        }
            //        v1++;
            //        vh1++;
            //        n1++;
            //    }
            //    datItens_orcamento.Fill(orc.ITENS_ORCAMENTO);
            //    datOutros_servicos.Fill(orc.OUTROS_SERVICOS_ORC);
            //    datMat_prima_orc.Fill(orc.MAT_PRIMA_ORCAMENTO);
            //    datImpostos_orc.Fill(orc.IMPOSTOS_ORC);
            //    fbConnection1.Close();
            //    crOrcamentos_sem_horas_analise orc_novo = new crOrcamentos_sem_horas_analise();
            //    orc_novo.SetDataSource(orc);
            //    orc_novo.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4;
            //    orc_novo.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto;
            //    form_imprimir imprimir = new form_imprimir(orc_novo);
            //    imprimir.orcamento = true;
            //    imprimir.n_orcamento = "FB_001_ANALISE_CRITICA_DE_CUSTO_" + numero_orc(3, tb_cod.Text) + "." + Convert.ToDateTime(tb_data_orcamento.Text).Year.ToString();
            //    imprimir.Show();

            //    //PARA FINALIZAR ACERTAR IMPOSTOS = VALOR TOTAL / (100 - IMPOSTO)
            //    //EM MATERIA DAS CAV. E TIPO DE ACABAMENTO PERMITIR MAIS DE UMA MARCAÇÃO

            //}


            if (tb_data_orcamento.Text == "")
                MessageBox.Show("Digite uma data para o orçamento por favor");
            else
            {
                somar_tudo();
                Salvar();
                comando_select.CommandText = "SELECT * FROM CLIENTES WHERE RAZAO_SOCIAL = '" + tb_cliente.Text + "'";
                DataSet cliente = new DataSet();
                fbConnection1.Open();
                datClientes.SelectCommand = comando_select;
                datClientes.Fill(cliente);
                string _cod = "";
                foreach (DataRow dr in cliente.Tables[0].Rows)
                {
                    _cod = dr["COD_CLIENTE"].ToString();

                }
                fbConnection1.Close();
                update_cod_orcamento(_cod, tb_revisao.Text);
                calcularHorasPadraoEAdicionais();

                this.datOrcamentos.SelectCommand.CommandText =
                    "SELECT * FROM ORCAMENTOS WHERE COD_ORCAMENTO = '" + tb_cod.Text + "'";
                this.fbConnection1.Open();
                this.datOrcamentos.SelectCommand.Connection = fbConnection1;
                this.datOrcamentos.SelectCommand.ExecuteNonQuery();

                this.fbConnection1.Close();
                dsOrcamentoMolde orc = new dsOrcamentoMolde();
                fbConnection1.Open();
                datClientes.Fill(orc.CLIENTES);
                datOrcamentos.Fill(orc.ORCAMENTOS);
                int n1 = orc.ORCAMENTOS.Columns["NOME_OPER1_ORCAMENTO"].Ordinal;
                int h1 = orc.ORCAMENTOS.Columns["HORAS_OPER1_ORCAMENTO"].Ordinal;
                int vh1 = orc.ORCAMENTOS.Columns["VH_OPER1_ORCAMENTO"].Ordinal;
                int v1 = orc.ORCAMENTOS.Columns["VALOR_OPER1_ORCAMENTO"].Ordinal;

                int vp1 = orc.ORCAMENTOS.Columns["HORAS_PADRAO_OPER1_ORCAMENTO"].Ordinal;
                int va1 = orc.ORCAMENTOS.Columns["HORAS_ADIC_OPER1_ORCAMENTO"].Ordinal;

                string nomeOperacao = "";
                double valorHora = 0, TotalhorasOperacao = 0, totalOperacao = 0, horaPadrao = 0, horaAdicional = 0;
                for (int i = h1; i < (h1 + 14); i++)
                {
                    if (orc.ORCAMENTOS.Rows[0][i].ToString() != "0" && orc.ORCAMENTOS.Rows[0][i].ToString().Trim() != "")
                    {
                        nomeOperacao = orc.ORCAMENTOS.Rows[0][n1].ToString();
                        Double.TryParse(orc.ORCAMENTOS.Rows[0][i].ToString(), out TotalhorasOperacao);
                        Double.TryParse(orc.ORCAMENTOS.Rows[0][vh1].ToString(), out valorHora);
                        Double.TryParse(orc.ORCAMENTOS.Rows[0][v1].ToString(), out totalOperacao);
                        Double.TryParse(orc.ORCAMENTOS.Rows[0][vp1].ToString(), out horaPadrao);
                        Double.TryParse(orc.ORCAMENTOS.Rows[0][va1].ToString(), out horaAdicional);

                        orc.operacoesMolde.AddoperacoesMoldeRow(nomeOperacao, TotalhorasOperacao, valorHora, totalOperacao, horaAdicional, horaPadrao);
                    }
                    v1++;
                    vh1++;
                    n1++;
                    vp1++;
                    va1++;
                }
                h1 = orc.ORCAMENTOS.Columns["HORAS_OPER15_ORCAMENTO"].Ordinal;
                v1 = orc.ORCAMENTOS.Columns["VALOR_OPER15_ORCAMENTO"].Ordinal;
                vh1 = orc.ORCAMENTOS.Columns["VH_OPER15_ORCAMENTO"].Ordinal;
                n1 = orc.ORCAMENTOS.Columns["NOME_OPER15_ORCAMENTO"].Ordinal;
                for (int i = h1; i < (h1 + 8); i++)
                {
                    nomeOperacao = orc.ORCAMENTOS.Rows[0][n1].ToString();
                    Double.TryParse(orc.ORCAMENTOS.Rows[0][i].ToString(), out TotalhorasOperacao);
                    Double.TryParse(orc.ORCAMENTOS.Rows[0][vh1].ToString(), out valorHora);
                    Double.TryParse(orc.ORCAMENTOS.Rows[0][v1].ToString(), out totalOperacao);
                    Double.TryParse(orc.ORCAMENTOS.Rows[0][vp1].ToString(), out horaPadrao);
                    Double.TryParse(orc.ORCAMENTOS.Rows[0][va1].ToString(), out horaAdicional);

                    if (orc.ORCAMENTOS.Rows[0][i].ToString() != "0" && orc.ORCAMENTOS.Rows[0][i].ToString().Trim() != "")
                    {
                        orc.operacoesMolde.AddoperacoesMoldeRow(nomeOperacao, TotalhorasOperacao, valorHora, totalOperacao, horaAdicional, horaPadrao);
                    }
                    v1++;
                    vh1++;
                    n1++;
                    vp1++;
                    va1++;
                }
                fbConnection1.Close();

                FbCommand cmdEmpresa = new FbCommand();
                FbDataAdapter datEmpresa = new FbDataAdapter();
                cmdEmpresa.CommandText =
                  "SELECT * FROM EMPRESA";
                datEmpresa.SelectCommand = cmdEmpresa;
                cmdEmpresa.Connection = fbConnection1;
                fbConnection1.Open();
                datEmpresa.SelectCommand.ExecuteNonQuery();
                fbConnection1.Close();

                datItens_orcamento.Fill(orc.ITENS_ORCAMENTO);
                datOutros_servicos.Fill(orc.OUTROS_SERVICOS_ORC);
                datMat_prima_orc.Fill(orc.MAT_PRIMA_ORCAMENTO);
                datImpostos_orc.Fill(orc.IMPOSTOS_ORC);
                datEmpresa.Fill(orc.EMPRESA);
                fbConnection1.Close();

                FbCommand cmdGavetas = new FbCommand();
                FbDataAdapter datCmdGavetas = new FbDataAdapter();
                cmdGavetas.CommandText = "SELECT * FROM GAVETAS_ORC WHERE COD_ORC_GAVETAS_ORC = " + tb_cod.Text + " AND QTDE_GAVETAS_ORC IS NOT NULL";
                cmdGavetas.Connection = fbConnection1;
                fbConnection1.Open();
                datCmdGavetas.SelectCommand = cmdGavetas;
                datCmdGavetas.Fill(orc.GAVETAS_ORC);
                fbConnection1.Close();

                FbCommand cmdCamaraQuente = new FbCommand();
                FbDataAdapter datCmdCamaraQuente = new FbDataAdapter();
                cmdCamaraQuente.CommandText = "SELECT * FROM CAMERA_QUENTE_ORC WHERE COD_ORC_CAMERA_QUENTE_ORC = " + tb_cod.Text + " AND QTDE_CAMERA_QUENTE_ORC = 1"; ;
                cmdCamaraQuente.Connection = fbConnection1;
                fbConnection1.Open();
                datCmdCamaraQuente.SelectCommand = cmdCamaraQuente;
                datCmdCamaraQuente.Fill(orc.CAMERA_QUENTE_ORC);
                fbConnection1.Close();

                double totalCaracTec = 0;
                Double.TryParse(tb_total_servicos_molde.Text, out totalCaracTec);
                double ipi = 0;
                somar_impostos(out ipi);
                ipi = Convert.ToDouble(tb_valor_total.Text) * ipi / 100;
                orc.totais.AddtotaisRow(totalCaracTec, 0, 0, 0, 0, ipi, "0");

                crOrcamentos_sem_horas_analise orc_novo = new crOrcamentos_sem_horas_analise();
                orc_novo.SetDataSource(orc);
                orc_novo.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4;
                orc_novo.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto;
                form_imprimir imprimir = new form_imprimir(orc_novo);
                imprimir.orcamento_molde = true;
                imprimir.n_orcamento = "FB_001_ANALISE_CRITICA_DE_CUSTO_" + numero_orc(4, tb_n_orc.Text) + "." + tb_revisao.Text + "." + Convert.ToDateTime(tb_data_criacao.Text).Year.ToString();
                imprimir.Show();

            }
        }

        private void calcularHorasPadraoEAdicionais()
        {
            UpdateHorasPadrao();
            UpdateHorasAdicionais();
        }

        private void UpdateHorasAdicionais()
        {
            try
            {
                string haOperacao1 = "NULL", haOperacao2 = "NULL", haOperacao3 = "NULL", haOperacao4 = "NULL",
                haOperacao5 = "NULL", haOperacao6 = "NULL", haOperacao7 = "NULL", haOperacao8 = "NULL",
                haOperacao9 = "NULL", haOperacao10 = "NULL", haOperacao11 = "NULL", haOperacao12 = "NULL",
                haOperacao13 = "NULL", haOperacao14 = "NULL", haOperacao15 = "NULL", haOperacao16 = "NULL",
                haOperacao17 = "NULL", haOperacao18 = "NULL", haOperacao19 = "NULL", haOperacao20 = "NULL",
                haOperacao21 = "NULL", haOperacao22 = "NULL";

                if (dgvItens_orcamento.Rows.Count > 1)
                {
                    if (dgvItens_orcamento.Rows[1].Cells["colOpr1"].Value.ToString() != "")
                    {
                        haOperacao1 = dgvItens_orcamento.Rows[1].Cells["colOpr1"].Value.ToString().Replace(",", ".");
                    }
                    if (dgvItens_orcamento.Rows[1].Cells["colOpr2"].Value.ToString() != "")
                    {
                        haOperacao2 = dgvItens_orcamento.Rows[1].Cells["colOpr2"].Value.ToString().Replace(",", ".");
                    }
                    if (dgvItens_orcamento.Rows[1].Cells["colOpr3"].Value.ToString() != "")
                    {
                        haOperacao3 = dgvItens_orcamento.Rows[1].Cells["colOpr3"].Value.ToString().Replace(",", ".");
                    }
                    if (dgvItens_orcamento.Rows[1].Cells["colOpr4"].Value.ToString() != "")
                    {
                        haOperacao4 = dgvItens_orcamento.Rows[1].Cells["colOpr4"].Value.ToString().Replace(",", ".");
                    }
                    if (dgvItens_orcamento.Rows[1].Cells["colOpr5"].Value.ToString() != "")
                    {
                        haOperacao5 = dgvItens_orcamento.Rows[1].Cells["colOpr5"].Value.ToString().Replace(",", ".");
                    }
                    if (dgvItens_orcamento.Rows[1].Cells["colOpr6"].Value.ToString() != "")
                    {
                        haOperacao6 = dgvItens_orcamento.Rows[1].Cells["colOpr6"].Value.ToString().Replace(",", ".");
                    }
                    if (dgvItens_orcamento.Rows[1].Cells["colOpr7"].Value.ToString() != "")
                    {
                        haOperacao7 = dgvItens_orcamento.Rows[1].Cells["colOpr7"].Value.ToString().Replace(",", ".");
                    }
                    if (dgvItens_orcamento.Rows[1].Cells["colOpr8"].Value.ToString() != "")
                    {
                        haOperacao8 = dgvItens_orcamento.Rows[1].Cells["colOpr8"].Value.ToString().Replace(",", ".");
                    }
                    if (dgvItens_orcamento.Rows[1].Cells["colOpr9"].Value.ToString() != "")
                    {
                        haOperacao9 = dgvItens_orcamento.Rows[1].Cells["colOpr9"].Value.ToString().Replace(",", ".");
                    }
                    if (dgvItens_orcamento.Rows[1].Cells["colOpr10"].Value.ToString() != "")
                    {
                        haOperacao10 = dgvItens_orcamento.Rows[1].Cells["colOpr10"].Value.ToString().Replace(",", ".");
                    }
                    if (dgvItens_orcamento.Rows[1].Cells["colOpr11"].Value.ToString() != "")
                    {
                        haOperacao11 = dgvItens_orcamento.Rows[1].Cells["colOpr11"].Value.ToString().Replace(",", ".");
                    }
                    if (dgvItens_orcamento.Rows[1].Cells["colOpr12"].Value.ToString() != "")
                    {
                        haOperacao12 = dgvItens_orcamento.Rows[1].Cells["colOpr12"].Value.ToString().Replace(",", ".");
                    }
                    if (dgvItens_orcamento.Rows[1].Cells["colOpr13"].Value.ToString() != "")
                    {
                        haOperacao13 = dgvItens_orcamento.Rows[1].Cells["colOpr13"].Value.ToString().Replace(",", ".");
                    }
                    if (dgvItens_orcamento.Rows[1].Cells["colOpr14"].Value.ToString() != "")
                    {
                        haOperacao14 = dgvItens_orcamento.Rows[1].Cells["colOpr14"].Value.ToString().Replace(",", ".");
                    }

                    if (dgvItens_orcamento.Rows[1].Cells["colOpr15"].Value.ToString() != "")
                    {
                        haOperacao15 = dgvItens_orcamento.Rows[1].Cells["colOpr15"].Value.ToString().Replace(",", ".");
                    }
                    if (dgvItens_orcamento.Rows[1].Cells["colOpr16"].Value.ToString() != "")
                    {
                        haOperacao16 = dgvItens_orcamento.Rows[1].Cells["colOpr16"].Value.ToString().Replace(",", ".");
                    }
                    if (dgvItens_orcamento.Rows[1].Cells["colOpr17"].Value.ToString() != "")
                    {
                        haOperacao17 = dgvItens_orcamento.Rows[1].Cells["colOpr17"].Value.ToString().Replace(",", ".");
                    }
                    if (dgvItens_orcamento.Rows[1].Cells["colOpr18"].Value.ToString() != "")
                    {
                        haOperacao18 = dgvItens_orcamento.Rows[1].Cells["colOpr18"].Value.ToString().Replace(",", ".");
                    }
                    if (dgvItens_orcamento.Rows[1].Cells["colOpr19"].Value.ToString() != "")
                    {
                        haOperacao19 = dgvItens_orcamento.Rows[1].Cells["colOpr19"].Value.ToString().Replace(",", ".");
                    }
                    if (dgvItens_orcamento.Rows[1].Cells["colOpr20"].Value.ToString() != "")
                    {
                        haOperacao20 = dgvItens_orcamento.Rows[1].Cells["colOpr20"].Value.ToString().Replace(",", ".");
                    }
                    if (dgvItens_orcamento.Rows[1].Cells["colOpr21"].Value.ToString() != "")
                    {
                        haOperacao21 = dgvItens_orcamento.Rows[1].Cells["colOpr21"].Value.ToString().Replace(",", ".");
                    }
                    if (dgvItens_orcamento.Rows[1].Cells["colOpr22"].Value.ToString() != "")
                    {
                        haOperacao22 = dgvItens_orcamento.Rows[1].Cells["colOpr22"].Value.ToString().Replace(",", ".");
                    }

                    this.datOrcamentos.UpdateCommand.CommandText =
                    " UPDATE ORCAMENTOS SET HORAS_ADIC_OPER1_ORCAMENTO = " + haOperacao1 + ",HORAS_ADIC_OPER2_ORCAMENTO = " + haOperacao2 + "," +
                    "HORAS_ADIC_OPER3_ORCAMENTO = " + haOperacao3 + ", HORAS_ADIC_OPER4_ORCAMENTO = " + haOperacao4 + ",HORAS_ADIC_OPER5_ORCAMENTO = " + haOperacao5 + "," +
                    "HORAS_ADIC_OPER6_ORCAMENTO = " + haOperacao6 + ", HORAS_ADIC_OPER7_ORCAMENTO = " + haOperacao7 + ",HORAS_ADIC_OPER8_ORCAMENTO = " + haOperacao8 + "," +
                    "HORAS_ADIC_OPER9_ORCAMENTO = " + haOperacao9 + ",HORAS_ADIC_OPER10_ORCAMENTO = " + haOperacao10 + ",HORAS_ADIC_OPER11_ORCAMENTO = " + haOperacao11 + "," +
                    "HORAS_ADIC_OPER12_ORCAMENTO = " + haOperacao12 + ",HORAS_ADIC_OPER13_ORCAMENTO = " + haOperacao13 + ", HORAS_ADIC_OPER14_ORCAMENTO = " + haOperacao14 + ", " +
                    "HORAS_ADIC_OPER15_ORCAMENTO = " + haOperacao15 + ",HORAS_ADIC_OPER16_ORCAMENTO = " + haOperacao16 + ",HORAS_ADIC_OPER17_ORCAMENTO = " + haOperacao17 + ", " +
                    "HORAS_ADIC_OPER18_ORCAMENTO = " + haOperacao18 + ", HORAS_ADIC_OPER19_ORCAMENTO = " + haOperacao19 + ",HORAS_ADIC_OPER20_ORCAMENTO = " + haOperacao20 + "," +
                    "HORAS_ADIC_OPER21_ORCAMENTO = " + haOperacao21 + ", HORAS_ADIC_OPER22_ORCAMENTO = " + haOperacao22 + " " +
                    "WHERE COD_ORCAMENTO = " + tb_cod.Text + "";
                    this.fbConnection1.Open();
                    this.datOrcamentos.UpdateCommand.Connection = fbConnection1;
                    this.datOrcamentos.UpdateCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                }
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void UpdateHorasPadrao()
        {
            try
            {
                string hpOperacao1 = "NULL", hpOperacao2 = "NULL", hpOperacao3 = "NULL", hpOperacao4 = "NULL",
                hpOperacao5 = "NULL", hpOperacao6 = "NULL", hpOperacao7 = "NULL", hpOperacao8 = "NULL",
                hpOperacao9 = "NULL", hpOperacao10 = "NULL", hpOperacao11 = "NULL", hpOperacao12 = "NULL",
                hpOperacao13 = "NULL", hpOperacao14 = "NULL", hpOperacao15 = "NULL", hpOperacao16 = "NULL",
                hpOperacao17 = "NULL", hpOperacao18 = "NULL", hpOperacao19 = "NULL", hpOperacao20 = "NULL",
                hpOperacao21 = "NULL", hpOperacao22 = "NULL";

                if (dgvItens_orcamento.Rows[0].Cells["colOpr1"].Value.ToString() != "")
                {
                    hpOperacao1 = dgvItens_orcamento.Rows[0].Cells["colOpr1"].Value.ToString().Replace(",", ".");
                }
                if (dgvItens_orcamento.Rows[0].Cells["colOpr2"].Value.ToString() != "")
                {
                    hpOperacao2 = dgvItens_orcamento.Rows[0].Cells["colOpr2"].Value.ToString().Replace(",", ".");
                }
                if (dgvItens_orcamento.Rows[0].Cells["colOpr3"].Value.ToString() != "")
                {
                    hpOperacao3 = dgvItens_orcamento.Rows[0].Cells["colOpr3"].Value.ToString().Replace(",", ".");
                }
                if (dgvItens_orcamento.Rows[0].Cells["colOpr4"].Value.ToString() != "")
                {
                    hpOperacao4 = dgvItens_orcamento.Rows[0].Cells["colOpr4"].Value.ToString().Replace(",", ".");
                }
                if (dgvItens_orcamento.Rows[0].Cells["colOpr5"].Value.ToString() != "")
                {
                    hpOperacao5 = dgvItens_orcamento.Rows[0].Cells["colOpr5"].Value.ToString().Replace(",", ".");
                }
                if (dgvItens_orcamento.Rows[0].Cells["colOpr6"].Value.ToString() != "")
                {
                    hpOperacao6 = dgvItens_orcamento.Rows[0].Cells["colOpr6"].Value.ToString().Replace(",", ".");
                }
                if (dgvItens_orcamento.Rows[0].Cells["colOpr7"].Value.ToString() != "")
                {
                    hpOperacao7 = dgvItens_orcamento.Rows[0].Cells["colOpr7"].Value.ToString().Replace(",", ".");
                }
                if (dgvItens_orcamento.Rows[0].Cells["colOpr8"].Value.ToString() != "")
                {
                    hpOperacao8 = dgvItens_orcamento.Rows[0].Cells["colOpr8"].Value.ToString().Replace(",", ".");
                }
                if (dgvItens_orcamento.Rows[0].Cells["colOpr9"].Value.ToString() != "")
                {
                    hpOperacao9 = dgvItens_orcamento.Rows[0].Cells["colOpr9"].Value.ToString().Replace(",", ".");
                }
                if (dgvItens_orcamento.Rows[0].Cells["colOpr10"].Value.ToString() != "")
                {
                    hpOperacao10 = dgvItens_orcamento.Rows[0].Cells["colOpr10"].Value.ToString().Replace(",", ".");
                }
                if (dgvItens_orcamento.Rows[0].Cells["colOpr11"].Value.ToString() != "")
                {
                    hpOperacao11 = dgvItens_orcamento.Rows[0].Cells["colOpr11"].Value.ToString().Replace(",", ".");
                }
                if (dgvItens_orcamento.Rows[0].Cells["colOpr12"].Value.ToString() != "")
                {
                    hpOperacao12 = dgvItens_orcamento.Rows[0].Cells["colOpr12"].Value.ToString().Replace(",", ".");
                }
                if (dgvItens_orcamento.Rows[0].Cells["colOpr13"].Value.ToString() != "")
                {
                    hpOperacao13 = dgvItens_orcamento.Rows[0].Cells["colOpr13"].Value.ToString().Replace(",", ".");
                }
                if (dgvItens_orcamento.Rows[0].Cells["colOpr14"].Value.ToString() != "")
                {
                    hpOperacao14 = dgvItens_orcamento.Rows[0].Cells["colOpr14"].Value.ToString().Replace(",", ".");
                }

                if (dgvItens_orcamento.Rows[0].Cells["colOpr15"].Value.ToString() != "")
                {
                    hpOperacao15 = dgvItens_orcamento.Rows[0].Cells["colOpr15"].Value.ToString().Replace(",", ".");
                }
                if (dgvItens_orcamento.Rows[0].Cells["colOpr16"].Value.ToString() != "")
                {
                    hpOperacao16 = dgvItens_orcamento.Rows[0].Cells["colOpr16"].Value.ToString().Replace(",", ".");
                }
                if (dgvItens_orcamento.Rows[0].Cells["colOpr17"].Value.ToString() != "")
                {
                    hpOperacao17 = dgvItens_orcamento.Rows[0].Cells["colOpr17"].Value.ToString().Replace(",", ".");
                }
                if (dgvItens_orcamento.Rows[0].Cells["colOpr18"].Value.ToString() != "")
                {
                    hpOperacao18 = dgvItens_orcamento.Rows[0].Cells["colOpr18"].Value.ToString().Replace(",", ".");
                }
                if (dgvItens_orcamento.Rows[0].Cells["colOpr19"].Value.ToString() != "")
                {
                    hpOperacao19 = dgvItens_orcamento.Rows[0].Cells["colOpr19"].Value.ToString().Replace(",", ".");
                }
                if (dgvItens_orcamento.Rows[0].Cells["colOpr20"].Value.ToString() != "")
                {
                    hpOperacao20 = dgvItens_orcamento.Rows[0].Cells["colOpr20"].Value.ToString().Replace(",", ".");
                }
                if (dgvItens_orcamento.Rows[0].Cells["colOpr21"].Value.ToString() != "")
                {
                    hpOperacao21 = dgvItens_orcamento.Rows[0].Cells["colOpr21"].Value.ToString().Replace(",", ".");
                }
                if (dgvItens_orcamento.Rows[0].Cells["colOpr22"].Value.ToString() != "")
                {
                    hpOperacao22 = dgvItens_orcamento.Rows[0].Cells["colOpr22"].Value.ToString().Replace(",", ".");
                }

                this.datOrcamentos.UpdateCommand.CommandText =
                " UPDATE ORCAMENTOS SET HORAS_PADRAO_OPER1_ORCAMENTO = " + hpOperacao1 + ",HORAS_PADRAO_OPER2_ORCAMENTO = " + hpOperacao2 + "," +
                "HORAS_PADRAO_OPER3_ORCAMENTO = " + hpOperacao3 + ", HORAS_PADRAO_OPER4_ORCAMENTO = " + hpOperacao4 + ",HORAS_PADRAO_OPER5_ORCAMENTO = " + hpOperacao5 + "," +
                "HORAS_PADRAO_OPER6_ORCAMENTO = " + hpOperacao6 + ", HORAS_PADRAO_OPER7_ORCAMENTO = " + hpOperacao7 + ",HORAS_PADRAO_OPER8_ORCAMENTO = " + hpOperacao8 + "," +
                "HORAS_PADRAO_OPER9_ORCAMENTO = " + hpOperacao9 + ",HORAS_PADRAO_OPER10_ORCAMENTO = " + hpOperacao10 + ",HORAS_PADRAO_OPER11_ORCAMENTO = " + hpOperacao11 + "," +
                "HORAS_PADRAO_OPER12_ORCAMENTO = " + hpOperacao12 + ",HORAS_PADRAO_OPER13_ORCAMENTO = " + hpOperacao13 + ", HORAS_PADRAO_OPER14_ORCAMENTO = " + hpOperacao14 + ", " +
                "HORAS_PADRAO_OPER15_ORCAMENTO = " + hpOperacao15 + ",HORAS_PADRAO_OPER16_ORCAMENTO = " + hpOperacao16 + ",HORAS_PADRAO_OPER17_ORCAMENTO = " + hpOperacao17 + ", " +
                "HORAS_PADRAO_OPER18_ORCAMENTO = " + hpOperacao18 + ", HORAS_PADRAO_OPER19_ORCAMENTO = " + hpOperacao19 + ",HORAS_PADRAO_OPER20_ORCAMENTO = " + hpOperacao20 + "," +
                "HORAS_PADRAO_OPER21_ORCAMENTO = " + hpOperacao21 + ", HORAS_PADRAO_OPER22_ORCAMENTO = " + hpOperacao22 + " " +
                "WHERE COD_ORCAMENTO = " + tb_cod.Text + "";
                this.fbConnection1.Open();
                this.datOrcamentos.UpdateCommand.Connection = fbConnection1;
                this.datOrcamentos.UpdateCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void imprimirAnalisePeca()
        {
            if (tb_data_orcamento.Text == "")
                MessageBox.Show("Digite uma data para o orçamento por favor");
            else
            {
                somar_tudo();
                Salvar();
                comando_select.CommandText = "SELECT * FROM CLIENTES WHERE RAZAO_SOCIAL = '" + tb_cliente.Text + "'";
                DataSet cliente = new DataSet();
                fbConnection1.Open();
                datClientes.SelectCommand = comando_select;
                datClientes.Fill(cliente);
                string _cod = "";
                foreach (DataRow dr in cliente.Tables[0].Rows)
                {
                    _cod = dr["COD_CLIENTE"].ToString();

                }

                fbConnection1.Close();
                update_cod_orcamento(_cod, tb_revisao.Text);

                this.datOrcamentos.SelectCommand.CommandText =
                    "SELECT * FROM ORCAMENTOS WHERE COD_ORCAMENTO = '" + tb_cod.Text + "'";
                this.fbConnection1.Open();
                this.datOrcamentos.SelectCommand.Connection = fbConnection1;
                this.datOrcamentos.SelectCommand.ExecuteNonQuery();

                this.fbConnection1.Close();
                this.datItens_orcamento.SelectCommand.CommandText =
                    "SELECT * FROM ITENS_ORCAMENTO WHERE COD_ORCAMENTO_ITEM_ORC = '" + tb_cod.Text + "'";
                this.fbConnection1.Open();
                this.datItens_orcamento.SelectCommand.Connection = fbConnection1;
                this.datItens_orcamento.SelectCommand.ExecuteNonQuery();

                this.fbConnection1.Close();
                this.datOutros_servicos.SelectCommand.CommandText =
                    "SELECT * FROM OUTROS_SERVICOS_ORC WHERE COD_ORC_OUTROS = '" + tb_cod.Text + "'";
                this.fbConnection1.Open();
                this.datOutros_servicos.SelectCommand.Connection = fbConnection1;
                this.datOutros_servicos.SelectCommand.ExecuteNonQuery();

                this.fbConnection1.Close();
                this.datMat_prima_orc.SelectCommand.CommandText =
                    "SELECT * FROM MAT_PRIMA_ORCAMENTO WHERE COD_ORC_MAT_PRIMA_ORC = '" + tb_cod.Text + "'";
                this.fbConnection1.Open();
                this.datMat_prima_orc.SelectCommand.Connection = fbConnection1;
                this.datMat_prima_orc.SelectCommand.ExecuteNonQuery();

                this.fbConnection1.Close();
                this.datImpostos_orc.SelectCommand.CommandText =
                    "SELECT * FROM IMPOSTOS_ORC WHERE COD_ORC_IMPOSTOS_ORC = '" + tb_cod.Text + "'";
                this.fbConnection1.Open();
                this.datImpostos_orc.SelectCommand.Connection = fbConnection1;
                this.datImpostos_orc.SelectCommand.ExecuteNonQuery();
                fbConnection1.Close();

                FbCommand cmdEmpresa = new FbCommand();
                FbDataAdapter datEmpresa = new FbDataAdapter();
                cmdEmpresa.CommandText =
                  "SELECT * FROM EMPRESA";
                datEmpresa.SelectCommand = cmdEmpresa;
                cmdEmpresa.Connection = fbConnection1;
                fbConnection1.Open();
                datEmpresa.SelectCommand.ExecuteNonQuery();
                fbConnection1.Close();


                dsOrcamentoMolde orc = new dsOrcamentoMolde();
                fbConnection1.Open();
                datClientes.Fill(orc.CLIENTES);
                datOrcamentos.Fill(orc.ORCAMENTOS);
                datItens_orcamento.Fill(orc.ITENS_ORCAMENTO);
                datOutros_servicos.Fill(orc.OUTROS_SERVICOS_ORC);
                datMat_prima_orc.Fill(orc.MAT_PRIMA_ORCAMENTO);
                datEmpresa.Fill(orc.EMPRESA);
                datImpostos_orc.Fill(orc.IMPOSTOS_ORC); fbConnection1.Close();
                int h1 = orc.ORCAMENTOS.Columns["HORAS_OPER1_ORCAMENTO"].Ordinal;
                int v1 = orc.ORCAMENTOS.Columns["VALOR_OPER1_ORCAMENTO"].Ordinal;
                int vh1 = orc.ORCAMENTOS.Columns["VH_OPER1_ORCAMENTO"].Ordinal;
                int n1 = orc.ORCAMENTOS.Columns["NOME_OPER1_ORCAMENTO"].Ordinal;
                int itemOp1 = orc.ITENS_ORCAMENTO.Columns["HORAS_OPER1_ITEM_ORC"].Ordinal;
                string[] nomes = new string[22];
                double[] valores = new double[22];
                double[] valoresItem = new double[22];
                int[] nOper = new int[22];
                int j = 0;
                int nOp = 1;
                for (int i = 0; i < 22; i++)
                {
                    valores[i] = 0;
                    valoresItem[i] = 0;
                }
                for (int i = h1; i < (h1 + 14); i++)
                {
                    if (orc.ORCAMENTOS.Rows[0][i].ToString() != "0" && orc.ORCAMENTOS.Rows[0][i].ToString().Trim() != "")
                    {

                        nomes[j] = orc.ORCAMENTOS.Rows[0][n1].ToString();
                        valores[j] = Convert.ToDouble(orc.ORCAMENTOS.Rows[0][vh1].ToString());
                        nOper[j] = nOp;
                        j++;
                    }
                    v1++;
                    vh1++;
                    n1++;
                    nOp++;
                }
                h1 = orc.ORCAMENTOS.Columns["HORAS_OPER15_ORCAMENTO"].Ordinal;
                v1 = orc.ORCAMENTOS.Columns["VALOR_OPER15_ORCAMENTO"].Ordinal;
                vh1 = orc.ORCAMENTOS.Columns["VH_OPER15_ORCAMENTO"].Ordinal;
                n1 = orc.ORCAMENTOS.Columns["NOME_OPER15_ORCAMENTO"].Ordinal;
                itemOp1 = orc.ITENS_ORCAMENTO.Columns["HORAS_OPER1_ITEM_ORC"].Ordinal;
                nOp = 15;
                for (int i = h1; i < (h1 + 8); i++)
                {
                    if (orc.ORCAMENTOS.Rows[0][i].ToString() != "0" && orc.ORCAMENTOS.Rows[0][i].ToString().Trim() != "")
                    {
                        nomes[j] = orc.ORCAMENTOS.Rows[0][n1].ToString();
                        valores[j] = Convert.ToDouble(orc.ORCAMENTOS.Rows[0][vh1].ToString());
                        nOper[j] = nOp;
                        j++;
                    }
                    v1++;
                    vh1++;
                    n1++;
                    nOp++;
                }
                string coluna = "";
                foreach (DataRow dr in orc.ITENS_ORCAMENTO.Rows)
                {
                    for (int i = 0; i < nOper.Length; i++)
                    {
                        coluna = "HORAS_OPER" + nOper[i].ToString() + "_ITEM_ORC";
                        double valor = 0;
                        try
                        {
                            valor = Convert.ToDouble(dr[coluna].ToString());
                        }
                        catch { }
                        valoresItem[i] = valor;
                    }
                    orc.operacoesPeca.AddoperacoesPecaRow(Convert.ToInt32(dr[0].ToString()),
                        valoresItem[0], valoresItem[1], valoresItem[2], valoresItem[3], valoresItem[4], valoresItem[5], valoresItem[6], valoresItem[7], valoresItem[8], valoresItem[9], valoresItem[10], valoresItem[11], valoresItem[12], valoresItem[13], valoresItem[14], valoresItem[15], valoresItem[16], valoresItem[17], valoresItem[18], valoresItem[19], valoresItem[20], valoresItem[21]);

                }
                orc.operacoesNomePeca.AddoperacoesNomePecaRow(nomes[0], nomes[1], nomes[2], nomes[3], nomes[4], nomes[5], nomes[6], nomes[7], nomes[8], nomes[9], nomes[10], nomes[11], nomes[12], nomes[13], nomes[14], nomes[15], nomes[16], nomes[17], nomes[18], nomes[19], nomes[20], nomes[21],
                    valores[0], valores[1], valores[2], valores[3], valores[4], valores[5], valores[6], valores[7], valores[8], valores[9], valores[10], valores[11], valores[12], valores[13], valores[14], valores[15], valores[16], valores[17], valores[18], valores[19], valores[20], valores[21]);
                string[] nomeMp = new string[30];
                double[] totalMp = new double[30];
                double[] qtdMp = new double[30];
                for (int i = 0; i < 30; i++)
                {
                    nomeMp[i] = Convert.ToString(i + 1);
                    totalMp[i] = 0;
                    qtdMp[i] = 0;
                }
                int index = 0;
                foreach (DataRow drMp in orc.ITENS_ORCAMENTO.Rows)
                {
                    try
                    {
                        qtdMp[index] = Convert.ToDouble(drMp["KG_PC_ITEM_ORC"].ToString());
                    }
                    catch { }
                    try
                    {
                        totalMp[index] = Convert.ToDouble(drMp["VALOR_MATERIAL_ITEM_ORC"].ToString());
                    }
                    catch { }

                }
                /*
                 orc.materiaPrimaPeca.AddmateriaPrimaPecaRow(
                    nomeMp[0], nomeMp[1], nomeMp[2], nomeMp[3], nomeMp[4], nomeMp[5], nomeMp[6], nomeMp[7], nomeMp[8], nomeMp[9],
                    totalMp[0], totalMp[1], totalMp[2], totalMp[3], totalMp[4], totalMp[5], totalMp[6], totalMp[7], totalMp[8], totalMp[9],
                    qtdMp[0], qtdMp[1], qtdMp[2], qtdMp[3], qtdMp[4], qtdMp[5], qtdMp[6], qtdMp[7], qtdMp[8], qtdMp[9]);
                 */

                double ipi = 0;
               somar_impostos(out ipi);
               ipi = Convert.ToDouble(tb_valor_total.Text) * ipi / 100;
               orc.totais.AddtotaisRow(0, totalSemImpostos, totalSemImpostos, 0,0 , ipi, "0");

                crOrcamentosAnalisePeca orc_novo = new crOrcamentosAnalisePeca();
                orc_novo.SetDataSource(orc);
                orc_novo.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4;
                orc_novo.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto;
                form_imprimir imprimir = new form_imprimir(orc_novo);
                imprimir.orcamento_peca = true;
                imprimir.zoom150 = true;
                imprimir.n_orcamento = "FB_001A_ANALISE_CRITICA_DE_CUSTO_" + numero_orc(4, tb_n_orc.Text) + "." + tb_revisao.Text + "." + Convert.ToDateTime(tb_data_criacao.Text).Year.ToString();
                imprimir.Show();
                //PARA FINALIZAR ACERTAR IMPOSTOS = VALOR TOTAL / (100 - IMPOSTO)
                //EM MATERIA DAS CAV. E TIPO DE ACABAMENTO PERMITIR MAIS DE UMA MARCAÇÃO
            }
        }


        //private void imprimirAnalisePeca()
        //{
        //    if (tb_data_orcamento.Text == "")
        //        MessageBox.Show("Digite uma data para o orçamento por favor");
        //    else
        //    {
        //        Salvar();
        //        comando_select.CommandText = "SELECT * FROM CLIENTES WHERE RAZAO_SOCIAL = '" + tb_cliente.Text + "'";
        //        DataSet cliente = new DataSet();
        //        fbConnection1.Open();
        //        datClientes.SelectCommand = comando_select;
        //        datClientes.Fill(cliente);
        //        string _cod = "";
        //        foreach (DataRow dr in cliente.Tables[0].Rows)
        //        {
        //            _cod = dr["COD_CLIENTE"].ToString();

        //        }
        //        fbConnection1.Close();
        //        update_cod_orcamento(_cod);

        //        this.datOrcamentos.SelectCommand.CommandText =
        //            "SELECT * FROM ORCAMENTOS WHERE COD_ORCAMENTO = '" + tb_cod.Text + "'";
        //        this.fbConnection1.Open();
        //        this.datOrcamentos.SelectCommand.Connection = fbConnection1;
        //        this.datOrcamentos.SelectCommand.ExecuteNonQuery();

        //        this.fbConnection1.Close();
        //        this.datItens_orcamento.SelectCommand.CommandText =
        //            "SELECT * FROM ITENS_ORCAMENTO WHERE COD_ORCAMENTO_ITEM_ORC = '" + tb_cod.Text + "'";
        //        this.fbConnection1.Open();
        //        this.datItens_orcamento.SelectCommand.Connection = fbConnection1;
        //        this.datItens_orcamento.SelectCommand.ExecuteNonQuery();

        //        this.fbConnection1.Close();
        //        this.datOutros_servicos.SelectCommand.CommandText =
        //            "SELECT * FROM OUTROS_SERVICOS_ORC WHERE COD_ORC_OUTROS = '" + tb_cod.Text + "'";
        //        this.fbConnection1.Open();
        //        this.datOutros_servicos.SelectCommand.Connection = fbConnection1;
        //        this.datOutros_servicos.SelectCommand.ExecuteNonQuery();

        //        this.fbConnection1.Close();
        //        this.datMat_prima_orc.SelectCommand.CommandText =
        //            "SELECT * FROM MAT_PRIMA_ORCAMENTO WHERE COD_ORC_MAT_PRIMA_ORC = '" + tb_cod.Text + "'";
        //        this.fbConnection1.Open();
        //        this.datMat_prima_orc.SelectCommand.Connection = fbConnection1;
        //        this.datMat_prima_orc.SelectCommand.ExecuteNonQuery();

        //        this.fbConnection1.Close();
        //        this.datImpostos_orc.SelectCommand.CommandText =
        //            "SELECT * FROM IMPOSTOS_ORC WHERE COD_ORC_IMPOSTOS_ORC = '" + tb_cod.Text + "'";
        //        this.fbConnection1.Open();
        //        this.datImpostos_orc.SelectCommand.Connection = fbConnection1;
        //        this.datImpostos_orc.SelectCommand.ExecuteNonQuery();
        //        fbConnection1.Close();
        //        dsOrcamentos orc = new dsOrcamentos();
        //        fbConnection1.Open();
        //        datClientes.Fill(orc.CLIENTES);
        //        datOrcamentos.Fill(orc.ORCAMENTOS);
        //        datItens_orcamento.Fill(orc.ITENS_ORCAMENTO);
        //        datOutros_servicos.Fill(orc.OUTROS_SERVICOS_ORC);
        //        datMat_prima_orc.Fill(orc.MAT_PRIMA_ORCAMENTO);
        //        datImpostos_orc.Fill(orc.IMPOSTOS_ORC); fbConnection1.Close();
        //        int h1 = orc.ORCAMENTOS.Columns["HORAS_OPER1_ORCAMENTO"].Ordinal;
        //        int v1 = orc.ORCAMENTOS.Columns["VALOR_OPER1_ORCAMENTO"].Ordinal;
        //        int vh1 = orc.ORCAMENTOS.Columns["VH_OPER1_ORCAMENTO"].Ordinal;
        //        int n1 = orc.ORCAMENTOS.Columns["NOME_OPER1_ORCAMENTO"].Ordinal;
        //        int itemOp1 = orc.ITENS_ORCAMENTO.Columns["HORAS_OPER1_ITEM_ORC"].Ordinal;
        //        string[] nomes = new string[22];
        //        double[] valores = new double[22];
        //        double[] valoresItem = new double[22];
        //        int[] nOper = new int[22];
        //        int j = 0;
        //        int nOp = 1;
        //        for (int i = 0; i < 22; i++)
        //        {
        //            valores[i] = 0;
        //            valoresItem[i] = 0;
        //        }
        //        for (int i = h1; i < (h1 + 14); i++)
        //        {
        //            if (orc.ORCAMENTOS.Rows[0][i].ToString() != "0" && orc.ORCAMENTOS.Rows[0][i].ToString().Trim() != "")
        //            {

        //                nomes[j] = orc.ORCAMENTOS.Rows[0][n1].ToString();
        //                valores[j] = Convert.ToDouble(orc.ORCAMENTOS.Rows[0][vh1].ToString());
        //                nOper[j] = nOp;
        //                j++;
        //            }
        //            v1++;
        //            vh1++;
        //            n1++;
        //            nOp++;
        //        }
        //        h1 = orc.ORCAMENTOS.Columns["HORAS_OPER15_ORCAMENTO"].Ordinal;
        //        v1 = orc.ORCAMENTOS.Columns["VALOR_OPER15_ORCAMENTO"].Ordinal;
        //        vh1 = orc.ORCAMENTOS.Columns["VH_OPER15_ORCAMENTO"].Ordinal;
        //        n1 = orc.ORCAMENTOS.Columns["NOME_OPER15_ORCAMENTO"].Ordinal;
        //        itemOp1 = orc.ITENS_ORCAMENTO.Columns["HORAS_OPER1_ITEM_ORC"].Ordinal;
        //        nOp = 15;
        //        for (int i = h1; i < (h1 + 8); i++)
        //        {
        //            if (orc.ORCAMENTOS.Rows[0][i].ToString() != "0" && orc.ORCAMENTOS.Rows[0][i].ToString().Trim() != "")
        //            {
        //                nomes[j] = orc.ORCAMENTOS.Rows[0][n1].ToString();
        //                valores[j] = Convert.ToDouble(orc.ORCAMENTOS.Rows[0][vh1].ToString());
        //                nOper[j] = nOp;
        //                j++;
        //            }
        //            v1++;
        //            vh1++;
        //            n1++;
        //            nOp++;
        //        }
        //        string coluna = "";
        //        foreach (DataRow dr in orc.ITENS_ORCAMENTO.Rows)
        //        {
        //            for (int i = 0; i < nOper.Length; i++)
        //            {
        //                coluna = "HORAS_OPER" + nOper[i].ToString() + "_ITEM_ORC";
        //                double valor = 0;
        //                try
        //                {
        //                    valor = Convert.ToDouble(dr[coluna].ToString());
        //                }
        //                catch { }
        //                valoresItem[i] = valor;
        //            }
        //            orc.operacoesPeca.AddoperacoesPecaRow(Convert.ToInt32(dr[0].ToString()),
        //                valoresItem[0], valoresItem[1], valoresItem[2], valoresItem[3], valoresItem[4], valoresItem[5], valoresItem[6], valoresItem[7], valoresItem[8], valoresItem[9]);

        //        }
        //        orc.operacoesNomePeca.AddoperacoesNomePecaRow(nomes[0], nomes[1], nomes[2], nomes[3], nomes[4], nomes[5], nomes[6], nomes[7], nomes[8], nomes[9],
        //            valores[0], valores[1], valores[2], valores[3], valores[4], valores[5], valores[6], valores[7], valores[8], valores[9]);
        //        string[] nomeMp = new string[30];
        //        double[] totalMp = new double[30];
        //        double[] qtdMp = new double[30];
        //        for (int i = 0; i < 30; i++)
        //        {
        //            nomeMp[i] = Convert.ToString(i + 1);
        //            totalMp[i] = 0;
        //            qtdMp[i] = 0;
        //        }
        //        int index = 0;
        //        foreach (DataRow drMp in orc.ITENS_ORCAMENTO.Rows)
        //        {
        //            try
        //            {
        //                qtdMp[index] = Convert.ToDouble(drMp["KG_PC_ITEM_ORC"].ToString());
        //            }
        //            catch { }
        //            try
        //            {
        //                totalMp[index] = Convert.ToDouble(drMp["VALOR_MATERIAL_ITEM_ORC"].ToString());
        //            }
        //            catch { }

        //        }
        //        orc.materiaPrimaPeca.AddmateriaPrimaPecaRow(
        //            nomeMp[0], nomeMp[1], nomeMp[2], nomeMp[3], nomeMp[4], nomeMp[5], nomeMp[6], nomeMp[7], nomeMp[8], nomeMp[9],
        //            totalMp[0], totalMp[1], totalMp[2], totalMp[3], totalMp[4], totalMp[5], totalMp[6], totalMp[7], totalMp[8], totalMp[9],
        //            qtdMp[0], qtdMp[1], qtdMp[2], qtdMp[3], qtdMp[4], qtdMp[5], qtdMp[6], qtdMp[7], qtdMp[8], qtdMp[9]);
        //        crOrcamentosAnalisePeca orc_novo = new crOrcamentosAnalisePeca();
        //        orc_novo.SetDataSource(orc);
        //        orc_novo.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4;
        //        orc_novo.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto;
        //        form_imprimir imprimir = new form_imprimir(orc_novo);
        //        imprimir.orcamento = true;
        //        imprimir.n_orcamento = "FB_001A_ANALISE_CRITICA_DE_CUSTO_" + numero_orc(3, tb_cod.Text) + "." + Convert.ToDateTime(tb_data_orcamento.Text).Year.ToString();
        //        imprimir.Show();

        //        //PARA FINALIZAR ACERTAR IMPOSTOS = VALOR TOTAL / (100 - IMPOSTO)
        //        //EM MATERIA DAS CAV. E TIPO DE ACABAMENTO PERMITIR MAIS DE UMA MARCAÇÃO
        //    }
        //}

        private void button10_Click(object sender, EventArgs e)
        {
            if (rdbMolde.Checked)
            {
                imprimirAnaliseMolde();
            }
            else if (rdbPeca.Checked)
            {
                imprimirAnalisePeca();
            }
        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            if (rdbMolde.Checked)
            {
                imprimirAnaliseMolde();
            }
            else if (rdbPeca.Checked)
            {
                imprimirAnalisePeca();
            }
            else
            {
                MessageBox.Show("Selecione 'Molde' ou 'Peça'");
            }
        }

        private void checkBox34_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tb_desc_outras_DoubleClick(object sender, EventArgs e)
        {
            form_outros_serviços outrosServ = new form_outros_serviços();
            try
            {
                outrosServ.ShowDialog();
            }
            finally
            {
                for (int i = 0; i < outrosServ.numero_de_itens; i++)
                {
                    tb_desc_outras.Text = outrosServ._descricao_escolhida[i];
                    tb_valor_outras.Text = outrosServ._valor_escolhido[i];
                    tb_qtde_mat.Focus();
                    inserir_outros_servicos();
                    //inserir_rota(abre.operacao_escolhida[i, 0], "", "");
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            form_valor_materia_prima mat = new form_valor_materia_prima();
            try
            {
                mat.ShowDialog();
            }
            finally
            {
                for (int i = 0; i < mat.numero_de_itens; i++)
                {
                    tb_item_mat.Text = mat._descricao_escolhida[i];
                    tb_total_mat.Text = mat._valor_escolhido[i];
                    tb_un_mat.Text = mat._unidade_escolhida[i];
                    tb_qtde_mat.Focus();
                    inserir_item();
                    //inserir_rota(abre.operacao_escolhida[i, 0], "", "");
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            form_outros_serviços outrosServ = new form_outros_serviços();
            try
            {
                outrosServ.ShowDialog();
            }
            finally
            {
                for (int i = 0; i < outrosServ.numero_de_itens; i++)
                {
                    tb_desc_outras.Text = outrosServ._descricao_escolhida[i];
                    tb_valor_outras.Text = outrosServ._valor_escolhido[i];
                    tb_qtde_mat.Focus();
                    inserir_outros_servicos();
                    //inserir_rota(abre.operacao_escolhida[i, 0], "", "");
                }
            }
        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void label47_Click(object sender, EventArgs e)
        {

        }

        private void tb_n_cavidades_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbBico_quente_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Bico_quente.Checked)
            {
                panelBico_quente.Enabled = true;
                cb_Camara_quente.Checked = false;
            }
            else
            {
                panelBico_quente.Enabled = false;
            }
        }

        private void cb_Camara_quente_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Camara_quente.Checked)
            {
                panelCamara_quente.Enabled = true;
                cb_Bico_quente.Checked = false;
            }
            else
            {
                panelCamara_quente.Enabled = false;
            }
        }

        private void BtnGerarHoras_Click(object sender, EventArgs e)
        {
            if (tb_cliente.Text == "NOVO" || tb_cliente.Text == "")
            {
                MessageBox.Show("Selecione o cliente antes de gerar o peso!");
            }
            else
            {
                exibirColunasOperacoes();
                double largura = 0, comprimento = 0, altura = 0, peso = 0;
                double.TryParse(tbLargura_molde.Text, out largura);
                double.TryParse(tbComprimentoMolde.Text, out comprimento);
                double.TryParse(tbAltura.Text, out altura);
                peso = calcularPeso(largura, comprimento, altura);
                tbPeso.Text = peso.ToString();
                buscar_horas_peso(peso);
                deletarItensOrc();
                inserirMateriaPrimaPadrao();
                inserirOutrosServicosPadrao();
                tb_qtde_item.Text = "1";
                tb_descricao_item.Text = "Horas Padrão";
                inserir();
                tb_descricao_item.Text = "Horas Adicionais";
                inserirLinhaEmBranco();
                tb_descricao_item.Text = "";
                tb_qtde_item.Text = "";
                ocultarColunasDGV();
                somar_tudo();
                Salvar();
            }
        }

        private void inserirLinhaEmBranco()
        {
            string _horas_oper1 = "", _horas_oper2 = "", _horas_oper3 = "", _horas_oper4 = "",
          _horas_oper5 = "", _horas_oper6 = "", _horas_oper7 = "", _horas_oper8 = "", _horas_oper9 = "",
          _horas_oper10 = "", _horas_oper11 = "", _horas_oper12 = "", _horas_oper13 = "",
          _horas_oper14 = "", _horas_oper15 = "", _horas_oper16 = "", _horas_oper17 = "", _horas_oper18 = "", _horas_oper19 = "", _horas_oper20 = "",
          _horas_oper21 = "", _horas_oper22 = "";

            if (dgvItens_orcamento.Rows.Count <= 1 || rdbPeca.Checked)
            {
                _horas_oper1 = "null";
                _horas_oper2 = "null";
                _horas_oper3 = "null";
                _horas_oper4 = "null";
                _horas_oper5 = "null";
                _horas_oper6 = "null";
                _horas_oper7 = "null";
                _horas_oper8 = "null";
                _horas_oper9 = "null";
                _horas_oper10 = "null";
                _horas_oper11 = "null";
                _horas_oper12 = "null";
                _horas_oper13 = "null";
                _horas_oper14 = "null";
                _horas_oper15 = "null";
                _horas_oper16 = "null";
                _horas_oper17 = "null";
                _horas_oper18 = "null";
                _horas_oper19 = "null";
                _horas_oper20 = "null";
                _horas_oper21 = "null";
                _horas_oper22 = "null";

                try
                {
                    int qtde = 0;
                    Int32.TryParse(tb_qtde_item.Text, out qtde);
                    double qtde_peso = 1, valor_material = 0;
                    Double.TryParse(tb_peso_qtde_item.Text, out qtde_peso);
                    Double.TryParse(tb_valor_material_item.Text, out valor_material);
                    string material = tb_material.Text;
                    this.datItens_orcamento.InsertCommand.CommandText =
                        "INSERT INTO ITENS_ORCAMENTO (COD_ORCAMENTO_ITEM_ORC, HORAS_OPER1_ITEM_ORC, " +
                        "HORAS_OPER2_ITEM_ORC, HORAS_OPER3_ITEM_ORC, HORAS_OPER4_ITEM_ORC, HORAS_OPER5_ITEM_ORC, " +
                        "HORAS_OPER6_ITEM_ORC, HORAS_OPER7_ITEM_ORC, HORAS_OPER8_ITEM_ORC, HORAS_OPER9_ITEM_ORC, " +
                        "HORAS_OPER10_ITEM_ORC, HORAS_OPER11_ITEM_ORC, HORAS_OPER12_ITEM_ORC, " +
                        "HORAS_OPER13_ITEM_ORC, HORAS_OPER14_ITEM_ORC, HORAS_OPER15_ITEM_ORC, " +
                        "HORAS_OPER16_ITEM_ORC, HORAS_OPER17_ITEM_ORC, HORAS_OPER18_ITEM_ORC, " +
                        "HORAS_OPER19_ITEM_ORC, HORAS_OPER20_ITEM_ORC, HORAS_OPER21_ITEM_ORC, " +
                        "HORAS_OPER22_ITEM_ORC,NOME_ITEM_ORC, QTDE_ITEM_ORC, MATERIAL_ITEM_ORC, " +
                        "KG_PC_ITEM_ORC, VALOR_MATERIAL_ITEM_ORC)" +
                        "VALUES ('" + tb_cod.Text + "'," + _horas_oper1 + "," + _horas_oper2 + ","
                        + _horas_oper3 + "," + _horas_oper4 + "," + _horas_oper5 + "," + _horas_oper6 + ","
                        + _horas_oper7 + "," + _horas_oper8 + "," + _horas_oper9 + "," + _horas_oper10 + ","
                        + _horas_oper11 + "," + _horas_oper12 + "," + _horas_oper13 + "," + _horas_oper14 + ","
                        + _horas_oper15 + "," + _horas_oper16 + "," + _horas_oper17 + "," + _horas_oper18 + ","
                        + _horas_oper19 + "," + _horas_oper20 + "," + _horas_oper21 + "," + _horas_oper22 + ",'"
                        + tb_descricao_item.Text + "'," + qtde.ToString() + ", '" + material + "',"
                        + qtde_peso.ToString().Replace(",", ".") + ", " + valor_material.ToString().Replace(",", ".") + ")";
                    this.fbConnection1.Open();
                    this.datItens_orcamento.InsertCommand.Connection = fbConnection1;
                    this.datItens_orcamento.InsertCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();

                    this.datItens_orcamento.SelectCommand.CommandText =
                        "SELECT * FROM ITENS_ORCAMENTO WHERE COD_ORCAMENTO_ITEM_ORC = '" + tb_cod.Text + "' ORDER BY COD_ITEM_ORC";
                    this.fbConnection1.Open();
                    this.datItens_orcamento.SelectCommand.Connection = fbConnection1;
                    this.datItens_orcamento.SelectCommand.ExecuteNonQuery();
                    datItens_orcamento.Fill(ITENS_ORCAMENTO);
                    this.fbConnection1.Close();
                    apagar_tbs();

                }
                catch
                {
                    MessageBox.Show("Erro na inserção, verifique os dados");
                    fbConnection1.Close();
                }
            }
            else
            {
                MessageBox.Show("Os valores da primeira linha são os valores padrão e os da segunda os valores adicionais caso queira inserir mas horas adicionais edite a segunda linha", "Atenção");
            }
        }

        private void buscar_horas_peso(double peso)
        {
            try
            {
                deletarMateriaPrima();
                deletePortaMoldeMP();
                FbCommand cmd = new FbCommand();
                FbDataAdapter datCmd = new FbDataAdapter();
                DataTable dtCmd = new DataTable();

                cmd.CommandText = "SELECT VOP.*, p.PRECO_MOLDES_PECAS FROM valor_operacao_peso VOP " +
                "INNER JOIN peso_moldes_pecas P ON VOP.cod_peso_operacao_peso = P.cod_peso_moldes_pecas " +
                "WHERE " + tbPeso.Text.ToString().Replace(",", ".") + " between P.peso_minimo_moldes_pecas and P.peso_maximo_moldes_pecas  ORDER BY SEQUENCIA_VALOR_OPERACAO_PESO";
                cmd.Connection = fbConnection1;
                datCmd.SelectCommand = cmd;
                fbConnection1.Open();
                datCmd.Fill(dtCmd);
                fbConnection1.Close();


                //renomearDgvItensOrc(_cnpj);

                //BUSCA HORAS
                string coluna = "HORA_VALOR_OPERACAO_PESO";
                if (dtCmd.Rows.Count > 0)
                {

                    foreach (DataRow dr in dtCmd.Rows)
                    {
                        tb_item_mat.Text = "Porta Molde  " + tbLargura_molde.Text + " x " + tbComprimentoMolde.Text + " x " + tbAltura.Text + " Peso: " + tbPeso.Text;
                        tb_total_mat.Text = dr["PRECO_MOLDES_PECAS"].ToString();
                        tb_un_mat.Text = "KG";
                        tb_qtde_mat.Text = "1";
                        inserir_item();
                        break;
                    }

                    foreach (DataRow dr in dtCmd.Rows)
                    {

                        switch (Convert.ToInt32(dr["SEQUENCIA_VALOR_OPERACAO_PESO"].ToString()))
                        {
                            case 1:
                                {
                                    tbHrOper1.Text = dr[coluna].ToString();
                                    tbVhOper1.Text = buscar_valor_operacao(dr["OPERACAO_VALOR_OPERACAO_PESO"].ToString());
                                    break;
                                }
                            case 2:
                                {
                                    tbHrOper2.Text = dr[coluna].ToString();
                                    tbVhOper2.Text = buscar_valor_operacao(dr["OPERACAO_VALOR_OPERACAO_PESO"].ToString());
                                    break;
                                }
                            case 3:
                                {
                                    tbHrOper3.Text = dr[coluna].ToString();
                                    tbVhOper3.Text = buscar_valor_operacao(dr["OPERACAO_VALOR_OPERACAO_PESO"].ToString());
                                    break;
                                }
                            case 4:
                                {
                                    tbHrOper4.Text = dr[coluna].ToString();
                                    tbVhOper4.Text = buscar_valor_operacao(dr["OPERACAO_VALOR_OPERACAO_PESO"].ToString());
                                    break;
                                }
                            case 5:
                                {
                                    tbHrOper5.Text = dr[coluna].ToString();
                                    tbVhOper5.Text = buscar_valor_operacao(dr["OPERACAO_VALOR_OPERACAO_PESO"].ToString());
                                    break;
                                }
                            case 6:
                                {
                                    tbHrOper6.Text = dr[coluna].ToString();
                                    tbVhOper6.Text = buscar_valor_operacao(dr["OPERACAO_VALOR_OPERACAO_PESO"].ToString());
                                    break;
                                }
                            case 7:
                                {
                                    tbHrOper7.Text = dr[coluna].ToString();
                                    tbVhOper7.Text = buscar_valor_operacao(dr["OPERACAO_VALOR_OPERACAO_PESO"].ToString());
                                    break;
                                }
                            case 8:
                                {
                                    tbHrOper8.Text = dr[coluna].ToString();
                                    tbVhOper8.Text = buscar_valor_operacao(dr["OPERACAO_VALOR_OPERACAO_PESO"].ToString());
                                    break;
                                }
                            case 9:
                                {
                                    tbHrOper9.Text = dr[coluna].ToString();
                                    tbVhOper9.Text = buscar_valor_operacao(dr["OPERACAO_VALOR_OPERACAO_PESO"].ToString());
                                    break;
                                }
                            case 10:
                                {
                                    tbHrOper10.Text = dr[coluna].ToString();
                                    tbVhOper10.Text = buscar_valor_operacao(dr["OPERACAO_VALOR_OPERACAO_PESO"].ToString());
                                    break;
                                }
                            case 11:
                                {
                                    tbHrOper11.Text = dr[coluna].ToString();
                                    tbVhOper11.Text = buscar_valor_operacao(dr["OPERACAO_VALOR_OPERACAO_PESO"].ToString());
                                    break;
                                }
                            case 12:
                                {
                                    tbHrOper12.Text = dr[coluna].ToString();
                                    tbVhOper12.Text = buscar_valor_operacao(dr["OPERACAO_VALOR_OPERACAO_PESO"].ToString());
                                    break;
                                }
                            case 13:
                                {
                                    tbHrOper13.Text = dr[coluna].ToString();
                                    tbVhOper13.Text = buscar_valor_operacao(dr["OPERACAO_VALOR_OPERACAO_PESO"].ToString());
                                    break;
                                }
                            case 14:
                                {
                                    tbHrOper14.Text = dr[coluna].ToString();
                                    tbVhOper14.Text = buscar_valor_operacao(dr["OPERACAO_VALOR_OPERACAO_PESO"].ToString());
                                    break;
                                }
                            case 15:
                                {
                                    tbHrOper15.Text = dr[coluna].ToString();
                                    tbVhOper15.Text = buscar_valor_operacao(dr["OPERACAO_VALOR_OPERACAO_PESO"].ToString());
                                    break;
                                }
                            case 16:
                                {
                                    tbHrOper16.Text = dr[coluna].ToString();
                                    tbVhOper16.Text = buscar_valor_operacao(dr["OPERACAO_VALOR_OPERACAO_PESO"].ToString());
                                    break;
                                }
                            case 17:
                                {
                                    tbHrOper17.Text = dr[coluna].ToString();
                                    tbVhOper17.Text = buscar_valor_operacao(dr["OPERACAO_VALOR_OPERACAO_PESO"].ToString());
                                    break;
                                }
                            case 18:
                                {
                                    tbHrOper18.Text = dr[coluna].ToString();
                                    tbVhOper18.Text = buscar_valor_operacao(dr["OPERACAO_VALOR_OPERACAO_PESO"].ToString());
                                    break;
                                }
                            case 19:
                                {
                                    tbHrOper19.Text = dr[coluna].ToString();
                                    tbVhOper19.Text = buscar_valor_operacao(dr["OPERACAO_VALOR_OPERACAO_PESO"].ToString());
                                    break;
                                }
                            case 20:
                                {
                                    tbHrOper20.Text = dr[coluna].ToString();
                                    tbVhOper20.Text = buscar_valor_operacao(dr["OPERACAO_VALOR_OPERACAO_PESO"].ToString());
                                    break;
                                }
                            case 21:
                                {
                                    tbHrOper21.Text = dr[coluna].ToString();
                                    tbVhOper21.Text = buscar_valor_operacao(dr["OPERACAO_VALOR_OPERACAO_PESO"].ToString());
                                    break;
                                }
                            case 22:
                                {
                                    tbHrOper22.Text = dr[coluna].ToString();
                                    tbVhOper22.Text = buscar_valor_operacao(dr["OPERACAO_VALOR_OPERACAO_PESO"].ToString());
                                    break;
                                }
                        }
                    }
                }

                renomearDgvItensOrcPorPeso();
            }
            catch (Exception)
            {
                fbConnection1.Close();
            }


        }

        private void deletePortaMoldeMP()
        {
            try
            {
                FbCommand cmdDelete = new FbCommand();
                FbDataAdapter datCmdDelete = new FbDataAdapter();
                cmdDelete.CommandText = "delete from MAT_PRIMA_ORCAMENTO m " +
                "where m.item_mat_prima_orc like 'Porta Molde%' and m.cod_orc_mat_prima_orc = " + tb_cod.Text;
                datCmdDelete.DeleteCommand = cmdDelete;
                cmdDelete.Connection = fbConnection1;
                fbConnection1.Open();
                datCmdDelete.DeleteCommand.ExecuteNonQuery();
                fbConnection1.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private string buscar_valor_operacao(string operacao)
        {
            string valor = "";
            try
            {
                FbCommand cmd = new FbCommand();
                FbDataAdapter datCmd = new FbDataAdapter();
                DataTable dtcmd = new DataTable();

                cmd.CommandText = "SELECT * FROM TIPOS_OPERACOES WHERE TIPO = '" + operacao + "'";
                cmd.Connection = fbConnection1;
                datCmd.SelectCommand = cmd;
                fbConnection1.Open();
                datCmd.Fill(dtcmd);
                fbConnection1.Close();
                foreach (DataRow dr in dtcmd.Rows)
                {
                    valor = dr["VALOR_OPERACAO_TIPO"].ToString();
                }
            }
            catch (Exception)
            {
                fbConnection1.Close();
            }
            return valor;
        }

        private void renomearDgvItensOrcPorPeso()
        {
            //Aqui o datagridview terá seus cabeçalhos de coluna renomeados de acordo com as operações do cliente
            string[] nomeOper = new string[dgvItens_orcamento.Columns.Count];
            int i, j = 0;
            try
            {
                FbCommand cmd = new FbCommand();
                FbDataAdapter datCmd = new FbDataAdapter();
                DataTable dtCmd = new DataTable();

                cmd.CommandText = "SELECT VOP.* FROM valor_operacao_peso VOP " +
                "INNER JOIN peso_moldes_pecas P ON VOP.cod_peso_operacao_peso = P.cod_peso_moldes_pecas " +
                "WHERE " + tbPeso.Text.ToString().Replace(",", ".") + " between P.peso_minimo_moldes_pecas and P.peso_maximo_moldes_pecas  ORDER BY SEQUENCIA_VALOR_OPERACAO_PESO";
                cmd.Connection = fbConnection1;
                datCmd.SelectCommand = cmd;
                fbConnection1.Open();
                datCmd.Fill(dtCmd);
                fbConnection1.Close();

                if (dtCmd.Rows.Count > 0)
                {
                    //o 3 é a coluna que começa as operações
                    for (i = 0; i < dgvItens_orcamento.Columns.Count - 3; i++)
                    {
                        int coluna = i + 3;
                        if (dgvItens_orcamento.Columns[coluna].Visible == true)
                        {
                            if (j < dtCmd.Rows.Count)
                            {

                                dgvItens_orcamento.Columns[coluna].HeaderText = dtCmd.Rows[j]["OPERACAO_VALOR_OPERACAO_PESO"].ToString();
                                nomeOper[j] = dtCmd.Rows[j]["OPERACAO_VALOR_OPERACAO_PESO"].ToString();
                                j++;
                            }
                            else
                            {
                                nomeOper[j] = dgvItens_orcamento.Columns[coluna].HeaderText.ToString();
                                j++;
                            }
                        }
                    }

                    datOrcamentos.UpdateCommand.CommandText =
                        "UPDATE orcamentos SET " +
                            "nome_oper1_orcamento = '" + nomeOper[0] + "'," +
                            "nome_oper2_orcamento = '" + nomeOper[1] + "'," +
                            "nome_oper3_orcamento = '" + nomeOper[2] + "'," +
                            "nome_oper4_orcamento = '" + nomeOper[3] + "'," +
                            "nome_oper5_orcamento = '" + nomeOper[4] + "'," +
                            "nome_oper6_orcamento = '" + nomeOper[5] + "'," +
                            "nome_oper7_orcamento = '" + nomeOper[6] + "'," +
                            "nome_oper8_orcamento = '" + nomeOper[7] + "'," +
                            "nome_oper9_orcamento = '" + nomeOper[8] + "'," +
                            "nome_oper10_orcamento = '" + nomeOper[9] + "'," +
                            "nome_oper11_orcamento = '" + nomeOper[10] + "'," +
                            "nome_oper12_orcamento = '" + nomeOper[11] + "'," +
                            "nome_oper13_orcamento = '" + nomeOper[12] + "'," +
                            "nome_oper14_orcamento = '" + nomeOper[13] + "'," +
                            "nome_oper15_orcamento = '" + nomeOper[14] + "'," +
                            "nome_oper16_orcamento = '" + nomeOper[15] + "'," +
                            "nome_oper17_orcamento = '" + nomeOper[16] + "'," +
                            "nome_oper18_orcamento = '" + nomeOper[17] + "'," +
                            "nome_oper19_orcamento = '" + nomeOper[18] + "'," +
                            "nome_oper20_orcamento = '" + nomeOper[19] + "'," +
                            "nome_oper21_orcamento = '" + nomeOper[20] + "'," +
                            "nome_oper22_orcamento = '" + nomeOper[21] + "' " +
                        "WHERE cod_orcamento = " + tb_cod.Text;
                    datOrcamentos.UpdateCommand.Connection = fbConnection1;
                    datOrcamentos.UpdateCommand.Connection.Open();
                    datOrcamentos.UpdateCommand.ExecuteNonQuery();
                    datOrcamentos.UpdateCommand.Connection.Close();
                }
            }
            catch (Exception a)
            {
                //MessageBox.Show("Erro ao renomear o dataGridView!");
                MessageBox.Show(a.Message);
                datClientes.SelectCommand.Connection.Close();
            }
        }

        private double calcularPeso(double largura, double comprimento, double altura)
        {
            double peso = 0;

            try
            {
                peso = (largura * comprimento * altura) * 0.00786;
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique se os parametros estão corretos!", "Erro ao calcular peso");
            }

            return peso;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            form_impostos impostos = new form_impostos();
            try
            {
                impostos.ShowDialog();
            }
            finally
            {
                for (int i = 0; i < impostos.numero_de_itens; i++)
                {
                    tb_imp_desc.Text = impostos._descricao_escolhida[i];
                    tb_imp_perc.Text = impostos._porc_escolhida[i];
                    tb_qtde_mat.Focus();
                    inserir_impostos();
                }
            }
        }

        private void btnSomar_molde_Click(object sender, EventArgs e)
        {
            somar_servicos_molde();
        }

        private void somar_servicos_molde()
        {
            double total = 0, totalGavetas = 0, totalCameraQuente = 0, totalBicoQuente = 0;
            double camara_quente = 0, qtde_camera_quente = 0, camara_quente_adicional = 0, bico_quente = 0, bico_quente_adicional = 0, gaveta = 0, qtde_gavetas = 0, gaveta_adicional = 0;

            if (cb_Camara_quente.Checked)
            {
                for (int i = 0; i < dgvCamara_quente.Rows.Count; i++)
                {
                    double.TryParse(dgvCamara_quente.Rows[i].Cells["col_valor_camera_quente"].Value.ToString(), out camara_quente);
                    double.TryParse(dgvCamara_quente.Rows[i].Cells["col_qtde_camera_quente"].Value.ToString(), out qtde_camera_quente);
                    double.TryParse(dgvCamara_quente.Rows[i].Cells["col_adicional_camera_quente"].Value.ToString(), out camara_quente_adicional);
                    camara_quente = camara_quente * qtde_camera_quente;
                    totalCameraQuente += camara_quente;
                    totalCameraQuente += camara_quente_adicional;
                }
            }
            else if (cb_Bico_quente.Checked)
            {
                double.TryParse(tb_valor_bq.Text, out bico_quente);
                double.TryParse(tb_adicional_bq.Text, out bico_quente_adicional);
                totalBicoQuente += bico_quente;
                totalBicoQuente += bico_quente_adicional;
            }

            //Soma Gavetas
            for (int i = 0; i < dgvGavetas.Rows.Count; i++)
            {
                double.TryParse(dgvGavetas.Rows[i].Cells["col_valor_gaveta"].Value.ToString(), out gaveta);
                double.TryParse(dgvGavetas.Rows[i].Cells["col_qtde_gavetas"].Value.ToString(), out qtde_gavetas);
                double.TryParse(dgvGavetas.Rows[i].Cells["col_adicional_gaveta"].Value.ToString(), out gaveta_adicional);
                gaveta = gaveta * qtde_gavetas;
                totalGavetas += gaveta;
                totalGavetas += gaveta_adicional;
            }

            total = totalGavetas + totalCameraQuente + totalBicoQuente;
            tbTotalGavetas.Text = totalGavetas.ToString("N2");
            tbTotalCameraQuente.Text = totalCameraQuente.ToString("N2");
            tbTotalBicoQuente.Text = totalBicoQuente.ToString("N2");
            tb_total_servicos_molde.Text = total.ToString("N2");
            preencherQtdeBicos();
        }

        private void preencherQtdeBicos()
        {
            try
            {
                int marcado = 0;
                for (int i = 0; i < dgvCamara_quente.Rows.Count - 1; i++)
                {
                    Int32.TryParse(dgvCamara_quente.Rows[i].Cells["col_qtde_camera_quente"].Value.ToString(), out marcado);
                    if (marcado == 1)
                    {
                        tbQtdeBicos.Text = dgvCamara_quente.Rows[i].Cells["col_dim_camera_quente"].Value.ToString();
                    }

                }
            }
            catch { }
        }

        private void dgvCamara_quente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvItens_orcamento_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            int linhas = 0;
            Int32.TryParse(tb_qtde_linhas.Text, out linhas);
            tb_qtde_item.Text = "1";
            for (int i = 0; i < linhas; i++)
            {
                inserir();
            }
            tb_qtde_item.Text = "";
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void cbEmerson_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cbClemilton.Checked)
            {
                if (cbEmerson.Checked)
                {
                    tb_responsavel.Text = "Emerson / Clemilton";
                }
                else
                {
                    tb_responsavel.Text = "Clemilton";
                }
            }
            else
            {
                if (cbEmerson.Checked)
                {
                    tb_responsavel.Text = "Emerson ";
                }
                else
                {
                    tb_responsavel.Text = "";
                }
            }
        }

        private void cbFabiano_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cbClemilton.Checked)
            {
                if (cbEmerson.Checked)
                {
                    tb_responsavel.Text = "Emerson / Clemilton";
                }
                else
                {
                    tb_responsavel.Text = "Clemilton";
                }
            }
            else
            {
                if (cbEmerson.Checked)
                {
                    tb_responsavel.Text = "Emerson de Oliveira";
                }
                else
                {
                    tb_responsavel.Text = "";
                }
            }
        }

        private void dgvItens_orcamento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvItens_orcamento.Columns[e.ColumnIndex].Name == "but_material")
                {
                    form_material cart = new form_material();
                    try
                    {
                        cart.ShowDialog();
                    }
                    finally
                    {
                        dgvItens_orcamento.Rows[e.RowIndex].Cells["col_material"].Value = cart.material_escolhido;
                    }
                }
                if (dgvItens_orcamento.Columns[e.ColumnIndex].Name == "col_aprovado")
                {
                    form_ncm ncm = new form_ncm();
                    try
                    {
                        ncm.ShowDialog();
                    }
                    finally
                    {
                        dgvItens_orcamento.Rows[e.RowIndex].Cells["NCM_ITEM_ORC"].Value = ncm.ncm_escolhida;
                        dgvItens_orcamento.Rows[e.RowIndex].Cells["col_status"].Value = "APROVADO";
                        Salvar();
                    }
                    
                }
                if (dgvItens_orcamento.Columns[e.ColumnIndex].Name == "col_reprovado")
                {

                    dgvItens_orcamento.Rows[e.RowIndex].Cells["col_status"].Value = "REPROVADO";
                    Salvar();

                }

            }
            catch { }
        }

        //private void localizar_item(string p)
        //{
        //    throw new NotImplementedException();
        //}

        private void dgvGavetas_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCamara_quente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    if (dgvCamara_quente.Columns[e.ColumnIndex].Name == "col_qtde_camera_quente")
            //    {
            //        desmarcarCamaraQuente();
            //        if (Convert.ToInt32(dgvCamara_quente.Rows[e.RowIndex].Cells["col_qtde_camera_quente"].Value.ToString()) == 1)
            //        {
            //            tbQtdeBicos.Text = dgvCamara_quente.Rows[e.RowIndex].Cells["col_dim_camera_quente"].Value.ToString();
            //        }
            //    }
            //}
            //catch { }
        }

        private void desmarcarCamaraQuente()
        {
            try
            {
                for (int i = 0; i < dgvCamara_quente.Rows.Count - 1; i++)
                {
                    dgvCamara_quente.Rows[i].Cells["col_qtde_camera_quente"].Value = 0;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cbHusky_CheckedChanged(object sender, EventArgs e)
        {
            gerarStringFornecedor();
        }

        private void cbMoldMasters_CheckedChanged(object sender, EventArgs e)
        {
            gerarStringFornecedor();
        }

        private void cbIncoe_CheckedChanged(object sender, EventArgs e)
        {

            gerarStringFornecedor();
        }

        private void cbPolimod_CheckedChanged(object sender, EventArgs e)
        {
            gerarStringFornecedor();
        }

        private void cbSyventive_CheckedChanged(object sender, EventArgs e)
        {
            gerarStringFornecedor();
        }

        private void gerarStringFornecedor()
        {
            string fornTemp = tb_forn_injecao.Text;
            string forn = "";

            if (cbHusky.Checked)
            {
                //forn = forn.Replace(cbHusky.Text,"");
                forn += ("/" + cbHusky.Text);
            }
            if (cbMoldMasters.Checked)
            {
                //forn = forn.Replace(cbMoldMasters.Text, "");
                forn += ("/" + cbMoldMasters.Text);
            }
            if (cbIncoe.Checked)
            {
                //forn = forn.Replace(cbIncoe.Text, "");
                forn += ("/" + cbIncoe.Text);
            }
            if (cbPolimod.Checked)
            {
                //forn = forn.Replace(cbPolimod.Text, "");
                forn += ("/" + cbPolimod.Text);
            }
            if (cbSyventive.Checked)
            {
                //forn = forn.Replace(cbSyventive.Text, "");
                forn += ("/" + cbSyventive.Text);
            }

            ArrayList arrayForn = new ArrayList(fornTemp.Split('/'));
            foreach (Control control in panelForn.Controls)
            {
                if (control is CheckBox)
                {
                    if (arrayForn.Contains(control.Text))
                    {
                        arrayForn.Remove(control.Text);
                    }
                }
            }
            arrayForn.Remove("");

            string resto = "";

            if (arrayForn.Count > 0)
            {
                resto = "/" + string.Join("/", arrayForn.ToArray());
            }
            forn += resto;

            try
            {
                if (forn.Substring(0, 1) == "/")
                {
                    tb_forn_injecao.Text = forn.Remove(0, 1) + "/";
                }
            }
            catch { tb_forn_injecao.Text = ""; }
        }

        private void buscarFornecedores()
        {
            try
            {
                string fornTemp = tb_forn_injecao.Text;
                cbHusky.Checked = false;
                cbMoldMasters.Checked = false;
                cbIncoe.Checked = false;
                cbPolimod.Checked = false;
                cbSyventive.Checked = false;
                tb_forn_injecao.Text = "";

                //if (fornTemp.Contains(cbHusky.Text))
                //{
                //    cbHusky.Checked = true;
                //}
                //if (fornTemp.Contains(cbMoldMasters.Text))
                //{
                //    cbMoldMasters.Checked = true;
                //}
                //if (fornTemp.Contains(cbIncoe.Text))
                //{
                //    cbIncoe.Checked = true;
                //}
                //if (fornTemp.Contains(cbPolimod.Text))
                //{
                //    cbPolimod.Checked = true;
                //}
                //if (fornTemp.Contains(cbSyventive.Text))
                //{
                //    cbSyventive.Checked = true;
                //}

                ArrayList arrayForn = new ArrayList(fornTemp.Split('/'));
                foreach (Control control in panelForn.Controls)
                {
                    if (control is CheckBox)
                    {
                        if (arrayForn.Contains(control.Text))
                        {
                            arrayForn.Remove(control.Text);
                            ((CheckBox)control).Checked = true;
                        }
                    }
                }

                string resto = string.Join("/", arrayForn.ToArray());
                tb_forn_injecao.Text += resto;
                /*
                 string forns = "joao/manuel/marcelo/";
          ArrayList arrayForn = new ArrayList(forns.Split('/');

          if (arrayForn.Contains("joao")){
              arrayForn.Remove("joao");
              // ... do others stuff here
          }
          // ... outros fornecedores ...
          string resto = String.Join("/", arrayForn.ToArray());
          Console.WriteLine(resto);
         /*
          foreach (var fo in arrayForn) {
              Console.WriteLine(fo);
          }
        */
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                int revisao = 0;
                int.TryParse(tb_revisao.Text.Replace("R", ""), out revisao);
                revisao++;
                tb_revisao.Text = "R" + revisao.ToString();
            }
            catch { }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            OleDbConnection _olecon = new OleDbConnection();
            OleDbCommand _oleCmd;
            String _Arquivo;
            string file;
            string path;
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            if (of.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                file = of.FileName;
                path = file.Replace(of.SafeFileName, "");
                _Arquivo = @file;
                //_StringConexao = String.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0 Xml;HDR=YES;ReadOnly=False';", _Arquivo);
                try
                {
                    _olecon = new OleDbConnection(@"provider=Microsoft.ACE.OLEDB.12.0;data source='" + file + @"';Extended Properties='Excel 8.0;HDR=YES;IMEX=1;'");
                    _olecon.Open();

                    _oleCmd = new OleDbCommand();
                    _oleCmd.Connection = _olecon;
                    _oleCmd.CommandType = CommandType.Text;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                OleDbDataAdapter theDataAdapter = new OleDbDataAdapter("SELECT * FROM [Planilha1$]", _olecon);
                DataSet theDS = new DataSet();
                theDataAdapter.Fill(theDS);
                IDictionary<int, double> plan = new Dictionary<int, double>();

                foreach (DataRow dr in theDS.Tables[0].Rows)
                {
                    string item;

                    try
                    {
                        item = dr[0].ToString();

                    }
                    catch
                    {
                        item = "";
                    }
                    if (item != "")
                    {
                        try
                        {
                            
                            FbCommand insert = new FbCommand();
                            
                            this.datItens_orcamento.InsertCommand.CommandText =
                                "INSERT INTO ITENS_ORCAMENTO (COD_ORCAMENTO_ITEM_ORC, NOME_ITEM_ORC, QTDE_ITEM_ORC, NCM_ITEM_ORC, DESCONTO_ITEM_ORC)" +
                        "VALUES ('" + tb_cod.Text + "','" + dr[0].ToString() + "'," + dr[1].ToString() + ",'" + dr[2].ToString() + "', 0)";
                            this.fbConnection1.Open();
                            this.datItens_orcamento.InsertCommand.Connection = fbConnection1;
                            this.datItens_orcamento.InsertCommand.ExecuteNonQuery();
                            this.fbConnection1.Close();

                            this.datItens_orcamento.SelectCommand.CommandText =
                        "SELECT * FROM ITENS_ORCAMENTO WHERE COD_ORCAMENTO_ITEM_ORC = '" + tb_cod.Text + "' ORDER BY COD_ITEM_ORC";
                            this.fbConnection1.Open();
                            this.datItens_orcamento.SelectCommand.Connection = fbConnection1;
                            this.datItens_orcamento.SelectCommand.ExecuteNonQuery();
                            datItens_orcamento.Fill(ITENS_ORCAMENTO);
                            this.fbConnection1.Close();

                            
                        }
                        catch (Exception a)
                        {
                            fbConnection1.Close();
                            MessageBox.Show("Erro ao inserir novo item \n" + a.ToString());
                        }


                    }
         
                }
                MessageBox.Show("Processo Realizado com Sucesso! ");

                //cadastrar_produto();
                
            }
        }

        private void cadastrar_produto()
        {
//            form_produto prod = new form_produto(cnpj_empresa);
//            for (int i = 0; i < dgvItens_orcamento.RowCount; i++)
//            {
//                try
//                {
//                    int encontrada = 0;
//                    int produto_atual = buscar_ultimo_produto(out encontrada);
//                    produto_atual++;
//                    string descricao_produto, ncm;
//                    descricao_produto = dgvItens_orcamento.Rows[i].Cells["col_nome"].Value.ToString();
//                    ncm = dgvItens_orcamento.Rows[i].Cells["NCM_ITEM_ORC"].Value.ToString();
//                    FbCommand insert = new FbCommand();
//                    insert.Connection = fbConnection1;
//                    insert.CommandText = @"INSERT INTO PRODUTOS (COD_PRODUTO, COD_FORNECEDOR_PRODUTO, DESCRICAO_PRODUTO, 
//                                                                NCM_PRODUTO, COD_BARRAS_PRODUTO, COD_BARRAS_CAIXA_PRODUTO, ST_SAIDA_PRODUTO, ALIQUOTA_ICMS_PRODUTO, REDUCAO_ICMS_PRODUTO, 
//                                                                ESTOQUE_ATUAL_PRODUTO, ESTOQUE_MEDIO_PRODUTO) 
//                                                                VALUES ('" + produto_atual + "','" + produto_atual + "','" + descricao_produto + "','" +
//                                        ncm + "','" + produto_atual + "','" + produto_atual + "', 101,0,0,0,0)";
//                    fbConnection1.Open();
//                    FbDataAdapter datInsert = new FbDataAdapter();
//                    datInsert.InsertCommand = insert;
//                    datInsert.InsertCommand.ExecuteNonQuery();
//                    fbConnection1.Close();
//                }
//                catch (Exception e)
//                {
//                    MessageBox.Show(e.ToString());
//                    fbConnection1.Close();
//                }

//            }

        }

        private int buscar_ultimo_produto(out int encontrada)
        {
            encontrada = 0;
            try
            {
                FbCommand comando = new FbCommand();
                comando.Connection = fbConnection1;
                comando.CommandText =
                    "SELECT first(1) COD_PRODUTO FROM PRODUTOS ORDER BY COD_PRODUTO DESC";
                DataSet produto = new DataSet();
                fbConnection1.Open();
                datProdutos.SelectCommand = comando;
                datProdutos.Fill(produto);

                if (produto.Tables[0].Rows.Count > 0)
                {
                    DataRow dr = produto.Tables[0].Rows[0];
                    encontrada = Convert.ToInt32(dr[0].ToString());
                }
                else
                { encontrada = 1; }
                fbConnection1.Close();
                return encontrada;
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
                fbConnection1.Close();
                return encontrada;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string n_ped, razao_emissor;
            if (!verificar_se_orcamento_ja_esta_em_um_pedido(out n_ped, out razao_emissor))
            {

                form_pedidos ped = new form_pedidos(cnpj_empresa);
                try
                {

                    ped.novo_pedido = true;
                    ped.n_orc = Convert.ToInt32(tb_cod.Text);
                    ped.ShowDialog();
                }
                finally
                {

                }
            }
            else
                MessageBox.Show("Esse orçamento já está lançado no pedido " + n_ped + " da Empresa: " + razao_emissor);
        }

        private bool verificar_se_orcamento_ja_esta_em_um_pedido(out string n_ped, out string razao_emissor)
        {
            n_ped = ""; razao_emissor = "";
            try
            {

                string cod_orc = tb_n_orc.Text;
                try
                {
                    FbCommand select = new FbCommand();
                    select.CommandText =
                        "SELECT ped.COD_PED_VENDA, ped.CLIENTE_PED_VENDA FROM PEDIDOS_VENDA ped " +
                        " INNER JOIN ORCAMENTOS orc ON ped.COD_ORCAMENTO_PED_VENDA = orc.COD_ORCAMENTO " +
                        " WHERE orc.N_ORCAMENTO = '" + cod_orc + "'";
                    select.Connection = fbConnection1;
                    fbConnection1.Open();
                    FbDataAdapter datSelect = new FbDataAdapter();
                    datSelect.SelectCommand = select;
                    DataTable dtSelect = new DataTable();
                    datSelect.Fill(dtSelect);
                    fbConnection1.Close();
                    foreach (DataRow dr in dtSelect.Rows)
                    {

                        n_ped = dr[0].ToString();
                        razao_emissor = dr[1].ToString();

                        if (n_ped == "")
                            return true;

                    }
                    //return false;
                }
                catch (Exception a)
                {
                    fbConnection1.Close();
                    MessageBox.Show(a.ToString());
                }


                return false;
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                return false;
            }
        }

        private void btn_Ajustar_Valor_Click(object sender, EventArgs e)
        {
            double novo_valor_unitario = 0, valor_unitario = 0, valor_total = 0, qtde = 0;
            double material_peca = 0;
            for (int i = 0; i <= dgvItens_orcamento.SelectedRows.Count; i++)
            {
                valor_unitario = Convert.ToDouble(dgvItens_orcamento.SelectedRows[i].Cells["col_valor_unit"].Value.ToString());
                qtde = Convert.ToDouble(dgvItens_orcamento.SelectedRows[i].Cells["col_qtde"].Value.ToString());

                Double.TryParse(dgvItens_orcamento.Rows[i].Cells["colValorMaterial"].Value.ToString(), out material_peca);

                valor_total = valor_unitario * qtde + material_peca;
                dgvItens_orcamento.Rows[i].Cells["col_valor_total"].Value = valor_total.ToString("n2").Replace(".", "");

               
            }
        }

        private void label28_Click(object sender, EventArgs e)
        {

        }
    }
}